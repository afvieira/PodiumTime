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
    public partial class uscEventos : UserControl {

        private PodiumTimeModels.Evento _eventoSelected = null;

        private EventoController _eventoController = new EventoController();

        public uscEventos() {
            InitializeComponent();
        }

        #region Eventos

        private void uscEventos_VisibleChanged(object sender, EventArgs e) {
            try {
                this.Fill();
            } catch(Exception ex) {
                Geral.geral.showErrorMessage(ex);
            }
        }

        private void btnLimparFiltro_Click(object sender, EventArgs e) {
            try {
                dgvEventos.FilterDescriptors.Clear();
            } catch(Exception ex) {
                Geral.geral.showErrorMessage(ex);
            }
        }

        private void btnExport_Click(object sender, EventArgs e) {
            try {

                SaveFileDialog saveDialog1 = new SaveFileDialog();
                saveDialog1.Filter = "Excel (*.xls)|*.xls";

                if(saveDialog1.ShowDialog(this) == DialogResult.OK) {
                    ExportToExcelML exporter = new ExportToExcelML(this.dgvEventos);
                    exporter.ExportVisualSettings = true;
                    exporter.RunExport(saveDialog1.FileName);

                    RadMessageBox.Show("Exportação concluída!");
                }

            } catch(Exception ex) {
                Geral.geral.showErrorMessage(ex);
            }
        }

        private void btnNovo_Click(object sender, EventArgs e) {
            try {
                dgvEventos.ClearSelection();
                _eventoSelected = null;
                this.Clear();
            } catch(Exception ex) {
                Geral.geral.showErrorMessage(ex);
            }
        }

        private void btnRemover_Click(object sender, EventArgs e) {
            try {
                if(_eventoSelected != null) {
                    if(Telerik.WinControls.RadMessageBox.Show("O evento vai ser removido. Deseja continuar?", "Podium Time", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes) {
                        _eventoController.Delete(_eventoSelected.ID);
                        dgvEventos.DataSource = _eventoController.GetAll();
                    }
                }
            } catch(Exception ex) {
                Geral.geral.showErrorMessage(ex);
            }

        }

        private void btnGuardar_Click(object sender, EventArgs e) {
            int id;

            try {
                this.CurrentInfo();

                if(!_eventoController.isValid(_eventoSelected)) {
                    Geral.geral.showInvalidInformation(_eventoController.Valid(_eventoSelected));
                    return;
                }

                _eventoController.Save(_eventoSelected);
                id = _eventoSelected.ID;
                dgvEventos.DataSource = _eventoController.GetAll();

                dgvEventos.CurrentRow = dgvEventos.Rows.Where(x => ((PodiumTimeModels.Evento)x.DataBoundItem).ID == id).First();
            } catch(Exception ex) {
                Geral.geral.showErrorMessage(ex);
            }
        }

        private void dgvInscricoes_SelectionChanged(object sender, EventArgs e) {
            PodiumTimeModels.Evento eventoSelect;

            try {
                if(dgvEventos.CurrentRow != null && dgvEventos.CurrentRow.DataBoundItem != null) {
                    eventoSelect = _eventoController.Find(((PodiumTimeModels.Evento)dgvEventos.CurrentRow.DataBoundItem).ID);

                    _eventoSelected = new PodiumTimeModels.Evento();
                    _eventoSelected.ID = eventoSelect.ID;
                    _eventoSelected.Nome = eventoSelect.Nome;
                    _eventoSelected.Data = eventoSelect.Data;
                    _eventoSelected.Cancelado = eventoSelect.Cancelado;
                    _eventoSelected.Descricao = eventoSelect.Descricao;

                    this.FillEvento();
                    btnGuardar.Text = "Atualizar";
                } else {
                    _eventoSelected = null;
                    this.Clear();
                }
            } catch(Exception ex) {
                Geral.geral.showErrorMessage(ex);
            }
        }

        #endregion

        private void Fill() {
            if(this.Visible) {
                dgvEventos.DataSource = _eventoController.GetAll();
            }

            foreach(GridViewColumn column in this.dgvEventos.Columns) {
                column.RadPropertyChanged += new Telerik.WinControls.RadPropertyChangedEventHandler(this.ColumnRadPropertyChangedHandler);
            }
        }

        private void ColumnRadPropertyChangedHandler(object sender, Telerik.WinControls.RadPropertyChangedEventArgs e) {
            if(String.Equals(e.Property.Name, "IsVisible")) {
                dgvEventos.resizeGrid();
            }
        }

        private void Clear() {
            lblID.Text = string.Empty;
            dtpData.Value = DateTime.Now;
            txtNome.Clear();
            chkCancelado.Checked = false;
            txtDescricao.Clear();
            btnGuardar.Text = "Guardar";
        }

        private void FillEvento() {
            lblID.Text = _eventoSelected.ID.ToString();
            dtpData.Value = (DateTime)_eventoSelected.Data;
            txtNome.Text = _eventoSelected.Nome;
            chkCancelado.Checked = _eventoSelected.Cancelado;
            txtDescricao.Text = _eventoSelected.Descricao;
        }

        private void CurrentInfo() {
            if(_eventoSelected == null) {
                _eventoSelected = new PodiumTimeModels.Evento();
            }

            _eventoSelected.Data = dtpData.Value;
            _eventoSelected.Nome = txtNome.Text;
            _eventoSelected.Cancelado = chkCancelado.Checked;
            _eventoSelected.Descricao = txtDescricao.Text;
        }
    }
}
