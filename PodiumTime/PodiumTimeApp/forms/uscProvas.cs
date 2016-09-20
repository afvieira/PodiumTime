using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PodiumTimeController;
using Telerik.WinControls.UI.Export;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using PodiumTimeApp.Geral;

namespace PodiumTimeApp.forms {
    public partial class uscProvas : UserControl {

        private PodiumTimeModels.Prova _provaSelected = null;

        private ProvaController _provaController = new ProvaController();
        private EventoController _eventoController = new EventoController();

        public uscProvas() {
            InitializeComponent();
        }

        #region Eventos

        private void uscProvas_VisibleChanged(object sender, EventArgs e) {
            try {
                this.Fill();
            } catch(Exception ex) {
                Geral.geral.showErrorMessage(ex);
            }
        }

        private void btnLimparFiltro_Click(object sender, EventArgs e) {
            try {
                dgvProvas.FilterDescriptors.Clear();
            } catch(Exception ex) {
                Geral.geral.showErrorMessage(ex);
            }
        }

        private void btnExport_Click(object sender, EventArgs e) {
            try {

                SaveFileDialog saveDialog1 = new SaveFileDialog();
                saveDialog1.Filter = "Excel (*.xls)|*.xls";

                if(saveDialog1.ShowDialog(this) == DialogResult.OK) {
                    ExportToExcelML exporter = new ExportToExcelML(this.dgvProvas);
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
                    dgvProvas.DataSource = _provaController.GetAllByEvento((int)cmbEvento.SelectedValue);
                } else {
                    dgvProvas.DataSource = null;
                    this.Clear();
                }
                dgvProvas.resizeGrid();
            } catch(Exception ex) {
                Geral.geral.showErrorMessage(ex);
            }
        }

        private void btnNovo_Click(object sender, EventArgs e) {
            try {
                dgvProvas.ClearSelection();
                _provaSelected = null;
                this.Clear();
            } catch(Exception ex) {
                Geral.geral.showErrorMessage(ex);
            }
        }

        private void btnRemover_Click(object sender, EventArgs e) {
            try {
                if(_provaSelected != null) {
                    if(Telerik.WinControls.RadMessageBox.Show("A prova vai ser removida. Deseja continuar?", "Podium Time", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes) {
                        _provaController.Delete(_provaSelected.ID);
                        dgvProvas.DataSource = _provaController.GetAllByEvento((int)cmbEvento.SelectedValue);
                    }
                }
            } catch(Exception ex) {
                Geral.geral.showErrorMessage(ex);
            }

        }

        private void btnGuardar_Click(object sender, EventArgs e) {
            int id;

            try {
                if(cmbEvento.SelectedItem == null || (int)cmbEvento.SelectedValue <= 0) {
                    Telerik.WinControls.RadMessageBox.Show("Escolha primeiro o evento!", "Inválido", System.Windows.Forms.MessageBoxButtons.OK);
                    return;
                }

                this.CurrentInfo();

                if(!_provaController.isValid(_provaSelected)) {
                    Geral.geral.showInvalidInformation(_provaController.Valid(_provaSelected));
                    return;
                }

                _provaController.Save(_provaSelected);
                id = _provaSelected.ID;
                dgvProvas.DataSource = _provaController.GetAllByEvento((int)cmbEvento.SelectedValue);

                dgvProvas.CurrentRow = dgvProvas.Rows.Where(x => ((PodiumTimeModels.Prova)x.DataBoundItem).ID == id).First();
            } catch(Exception ex) {
                Geral.geral.showErrorMessage(ex);
            }
        }

        private void btnIniciarProva_Click(object sender, EventArgs e) {
            try {
                throw new NotImplementedException();
            } catch(Exception ex) {
                Geral.geral.showErrorMessage(ex);
            }
        }

        private void dgvProvas_SelectionChanged(object sender, EventArgs e) {
            PodiumTimeModels.Prova provaSelecionada;

            try {
                if(dgvProvas.CurrentRow != null && dgvProvas.CurrentRow.DataBoundItem != null) {
                    provaSelecionada = _provaController.Find(((PodiumTimeModels.Prova)dgvProvas.CurrentRow.DataBoundItem).ID);

                    _provaSelected = new PodiumTimeModels.Prova();
                    _provaSelected.ID = provaSelecionada.ID;
                    _provaSelected.Nome = provaSelecionada.Nome;
                    _provaSelected.Descricao = provaSelecionada.Descricao;
                    _provaSelected.Distancia = provaSelecionada.Distancia;
                    _provaSelected.EventoID = provaSelecionada.EventoID;

                    this.FillProva();
                    btnGuardar.Text = "Atualizar";
                    btnIniciarProva.Enabled = true;
                } else {
                    _provaSelected = null;
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

            foreach(GridViewColumn column in this.dgvProvas.Columns) {
                column.RadPropertyChanged += new Telerik.WinControls.RadPropertyChangedEventHandler(this.ColumnRadPropertyChangedHandler);
            }
        }

        private void ColumnRadPropertyChangedHandler(object sender, Telerik.WinControls.RadPropertyChangedEventArgs e) {
            if(String.Equals(e.Property.Name, "IsVisible")) {
                dgvProvas.resizeGrid();
            }
        }

        private void Clear() {
            lblID.Text = string.Empty;
            txtNome.Clear();
            nudDistancia.Value = 0;
            txtDescricao.Clear();
            btnGuardar.Text = "Guardar";
            btnIniciarProva.Enabled = false;
        }

        private void FillProva() {
            lblID.Text = _provaSelected.ID.ToString();
            txtNome.Text = _provaSelected.Nome;
            nudDistancia.Value = _provaSelected.Distancia;
            txtDescricao.Text = _provaSelected.Descricao;
        }

        private void CurrentInfo() {
            if(_provaSelected == null) {
                _provaSelected = new PodiumTimeModels.Prova();
            }

            _provaSelected.Nome = txtNome.Text;
            _provaSelected.Distancia = nudDistancia.Value;
            _provaSelected.Descricao = txtDescricao.Text;
            _provaSelected.EventoID = (int)cmbEvento.SelectedValue;

        }

    }
}
