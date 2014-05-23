using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PodiumTimeController;
using System.Threading;
using Telerik.WinControls.UI.Export;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using PodiumTimeApp.Geral;

namespace PodiumTimeApp.forms {
    public partial class uscInscricoes : UserControl {

        private PodiumTimeModels.Inscricao _inscricaoSelected = null;

        private InscricaoController _inscricaoController = new InscricaoController();
        private EventoController _eventoController = new EventoController();

        public uscInscricoes() {
            InitializeComponent();
        }

        #region Eventos

        private void uscInscricoes_VisibleChanged(object sender, EventArgs e) {
            try {
                this.Fill();
            } catch(Exception ex) {
                Geral.geral.showErrorMessage(ex);
            }
        }

        private void btnLimparFiltro_Click(object sender, EventArgs e) {
            try {
                dgvInscricoes.FilterDescriptors.Clear();
            } catch(Exception ex) {
                Geral.geral.showErrorMessage(ex);
            }
        }

        private void btnExport_Click(object sender, EventArgs e) {
            try {

                SaveFileDialog saveDialog1 = new SaveFileDialog();
                saveDialog1.Filter = "Excel (*.xls)|*.xls";

                if(saveDialog1.ShowDialog(this) == DialogResult.OK) {
                    ExportToExcelML exporter = new ExportToExcelML(this.dgvInscricoes);
                    exporter.ExportVisualSettings = true;
                    exporter.RunExport(saveDialog1.FileName);

                    RadMessageBox.Show("Exportação concluída!");
                }

            } catch(Exception ex) {
                Geral.geral.showErrorMessage(ex);
            }
        }

        private void cmbEvento_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e) {
            try {
                if(cmbEvento.SelectedItem != null && (int)cmbEvento.SelectedValue > 0) {
                    dgvInscricoes.DataSource = _inscricaoController.GetAllByEvento((int)cmbEvento.SelectedValue);
                } else {
                    dgvInscricoes.DataSource = null;
                    this.Clear();
                }
                dgvInscricoes.resizeGrid();
            } catch(Exception ex) {
                Geral.geral.showErrorMessage(ex);
            }
        }

        private void chkDorsal_ToggleStateChanged(object sender, StateChangedEventArgs args) {
            try {
                nudDorsal.Enabled = chkDorsal.Checked;
            } catch(Exception ex) {
                Geral.geral.showErrorMessage(ex);
            }
        }

        private void btnNovo_Click(object sender, EventArgs e) {
            try {
                dgvInscricoes.ClearSelection();
                _inscricaoSelected = null;
                this.Clear();
            } catch(Exception ex) {
                Geral.geral.showErrorMessage(ex);
            }
        }

        private void btnRemover_Click(object sender, EventArgs e) {
            try {
                if(_inscricaoSelected != null) {
                    if(Telerik.WinControls.RadMessageBox.Show("A inscrição vai ser removida. Deseja continuar?", "Podium Time", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes) {
                        _inscricaoController.Delete(_inscricaoSelected.ID);
                        dgvInscricoes.DataSource = _inscricaoController.GetAllByEvento((int)cmbEvento.SelectedValue);
                    }
                }
            } catch(Exception ex) {
                Geral.geral.showErrorMessage(ex);
            }

        }

        private void btnGuardar_Click(object sender, EventArgs e) {
            int id;
            List<PodiumTimeModels.Inscricao> inscricoes;

            try {
                if(cmbEvento.SelectedItem == null || (int)cmbEvento.SelectedValue <= 0) {
                    Telerik.WinControls.RadMessageBox.Show("Escolha primeiro o evento!", "Inválido", System.Windows.Forms.MessageBoxButtons.OK);
                    return;
                }

                this.CurrentInfo();

                if(_inscricaoSelected.Dorsal != null) {
                    inscricoes = _inscricaoController.GetAllByEvento((int)cmbEvento.SelectedValue);

                    if(inscricoes.Exists(x => x.Dorsal == _inscricaoSelected.Dorsal && x.ID != _inscricaoSelected.ID)) {
                        Telerik.WinControls.RadMessageBox.Show("O dorsal atribuído já existe!", "Inválido", System.Windows.Forms.MessageBoxButtons.OK);
                        return;
                    }
                }

                if(!_inscricaoController.isValid(_inscricaoSelected)) {
                    Geral.geral.showInvalidInformation(_inscricaoController.Valid(_inscricaoSelected));
                    return;
                }

                _inscricaoController.Save(_inscricaoSelected);
                id = _inscricaoSelected.ID;
                dgvInscricoes.DataSource = _inscricaoController.GetAllByEvento((int)cmbEvento.SelectedValue);

                dgvInscricoes.CurrentRow = dgvInscricoes.Rows.Where(x => ((PodiumTimeModels.Inscricao)x.DataBoundItem).ID == id).First();
            } catch(Exception ex) {
                Geral.geral.showErrorMessage(ex);
            }
        }

        private void btnImportar_Click(object sender, EventArgs e) {

        }

        private void dgvInscricoes_SelectionChanged(object sender, EventArgs e) {
            PodiumTimeModels.Inscricao inscrSlecionada;

            try {
                if(dgvInscricoes.CurrentRow != null && dgvInscricoes.CurrentRow.DataBoundItem != null) {
                    inscrSlecionada = _inscricaoController.Find(((PodiumTimeModels.Inscricao)dgvInscricoes.CurrentRow.DataBoundItem).ID);

                    _inscricaoSelected = new PodiumTimeModels.Inscricao();
                    _inscricaoSelected.ID = inscrSlecionada.ID;
                    _inscricaoSelected.Nome = inscrSlecionada.Nome;
                    _inscricaoSelected.Pago = inscrSlecionada.Pago;
                    _inscricaoSelected.Sexo = inscrSlecionada.Sexo;
                    _inscricaoSelected.TamanhoJersey = inscrSlecionada.TamanhoJersey;
                    _inscricaoSelected.TipoInscricao = inscrSlecionada.TipoInscricao;
                    _inscricaoSelected.EventoID = inscrSlecionada.EventoID;
                    _inscricaoSelected.Equipa = inscrSlecionada.Equipa;
                    _inscricaoSelected.Email = inscrSlecionada.Email;
                    _inscricaoSelected.Dorsal = inscrSlecionada.Dorsal;
                    _inscricaoSelected.DocIdentificacao = inscrSlecionada.DocIdentificacao;
                    _inscricaoSelected.DataInscricao = inscrSlecionada.DataInscricao;
                    _inscricaoSelected.Contacto = inscrSlecionada.Contacto;

                    this.FillInscricao();
                    btnGuardar.Text = "Atualizar";
                } else {
                    _inscricaoSelected = null;
                    this.Clear();
                }
            } catch(Exception ex) {
                Geral.geral.showErrorMessage(ex);
            }
        }

        #endregion

        private void Fill() {
            int idselected = -1;

            if(this.Visible) {
                if(cmbEvento.SelectedItem != null && (int)cmbEvento.SelectedValue > 0) {
                    idselected = (int)cmbEvento.SelectedValue;
                }
                cmbEvento.DataSource = _eventoController.GetAll(true);
                cmbEvento.SelectedValue = idselected;
            }

            foreach(GridViewColumn column in this.dgvInscricoes.Columns) {
                column.RadPropertyChanged += new Telerik.WinControls.RadPropertyChangedEventHandler(this.ColumnRadPropertyChangedHandler);
            }
        }

        private void ColumnRadPropertyChangedHandler(object sender, Telerik.WinControls.RadPropertyChangedEventArgs e) {
            if(String.Equals(e.Property.Name, "IsVisible")) {
                dgvInscricoes.resizeGrid();
            }
        }

        private void Clear() {
            lblID.Text = string.Empty;
            txtContacto.Clear();
            txtDocIdentificacao.Clear();
            txtEmail.Clear();
            txtNome.Clear();
            txtTamanhoJersey.Clear();
            txtTipoInscricao.Clear();
            txtEquipa.Clear();
            lblData.Text = string.Empty;
            rdbMasculino.IsChecked = true;
            rdbNao.IsChecked = true;
            nudDorsal.Value = 0;
            chkDorsal.Checked = false;
            btnGuardar.Text = "Guardar";
        }

        private void FillInscricao() {
            lblID.Text = _inscricaoSelected.ID.ToString();
            txtContacto.Text = _inscricaoSelected.Contacto;
            txtDocIdentificacao.Text = _inscricaoSelected.DocIdentificacao;
            txtEmail.Text = _inscricaoSelected.Email;
            txtNome.Text = _inscricaoSelected.Nome;
            txtTamanhoJersey.Text = _inscricaoSelected.TamanhoJersey;
            txtTipoInscricao.Text = _inscricaoSelected.TipoInscricao;
            txtEquipa.Text = _inscricaoSelected.Equipa;
            lblData.Text = (_inscricaoSelected.DataInscricao == null ? string.Empty : _inscricaoSelected.DataInscricao.ToString());

            if(_inscricaoSelected.Sexo == "Masculino") {
                rdbMasculino.IsChecked = true;
            } else {
                rdbFeminino.IsChecked = true;
            }

            if(_inscricaoSelected.Pago == true) {
                rdbSim.IsChecked = true;
            } else {
                rdbNao.IsChecked = true;
            }

            if(_inscricaoSelected.Dorsal != null && _inscricaoSelected.Dorsal > 0) {
                nudDorsal.Value = (decimal)_inscricaoSelected.Dorsal;
                chkDorsal.Checked = true;
            } else {
                nudDorsal.Value = 0;
                chkDorsal.Checked = false;
            }
        }

        private void CurrentInfo() {
            if(_inscricaoSelected == null) {
                _inscricaoSelected = new PodiumTimeModels.Inscricao();
                _inscricaoSelected.DataInscricao = System.DateTime.Now;
            }

            _inscricaoSelected.Contacto = txtContacto.Text;
            _inscricaoSelected.DocIdentificacao = txtDocIdentificacao.Text;
            _inscricaoSelected.Email = txtEmail.Text;
            _inscricaoSelected.Nome = txtNome.Text;
            _inscricaoSelected.TamanhoJersey = txtTamanhoJersey.Text;
            _inscricaoSelected.TipoInscricao = txtTipoInscricao.Text;
            _inscricaoSelected.Equipa = txtEquipa.Text;
            _inscricaoSelected.EventoID = (int)cmbEvento.SelectedValue;

            if(rdbMasculino.IsChecked) {
                _inscricaoSelected.Sexo = "Masculino";
            } else {
                _inscricaoSelected.Sexo = "Feminino";
            }

            if(rdbSim.IsChecked) {
                _inscricaoSelected.Pago = true;
            } else {
                _inscricaoSelected.Pago = false;
            }

            if(chkDorsal.Checked) {
                _inscricaoSelected.Dorsal = (int)nudDorsal.Value;
            } else {
                _inscricaoSelected.Dorsal = null;
            }

        }
    }
}
