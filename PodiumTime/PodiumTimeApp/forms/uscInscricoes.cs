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

namespace PodiumTimeApp.forms {
    public partial class uscInscricoes : UserControl {

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
                }
                this.resizeGrid();
            } catch(Exception ex) {
                Geral.geral.showErrorMessage(ex);
            }
        }

        #endregion

        public void Fill() {
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

        private void resizeGrid() {
            // get out if working base is not given
            var grid = dgvInscricoes;
            if(grid == null || !grid.Rows.Any()) return;

            // Set this property to prevent BestFitColumns() from shrinking columns whose cells don't
            // contain values to a minimum. I know there was some fitting style thing (HeaderCells
            // or something) but I fogot what it was, so this basically works fine too
            grid.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.None;

            // Then call BestFitColumns(), it does almost all the resizing work for you
            // well, except glueing columns
            grid.BestFitColumns();

            // Now that all columns are best fitted, let's see if there is still space after the last column
            var visibleColumns = grid.Columns.Where(c => c.IsVisible);
            var parentWidth = grid.Parent.Width;
            var sumVisisbleColumnsWidth = visibleColumns.Sum(c => c.Width);
            var emptySpace = parentWidth - sumVisisbleColumnsWidth;
            if(emptySpace > 0) {
                // If so, modify the width of our glued column
                // In this example, the last Column is glued column
                visibleColumns.Last().Width += emptySpace;
            }
        }

        private void ColumnRadPropertyChangedHandler(object sender, Telerik.WinControls.RadPropertyChangedEventArgs e) {
            if(String.Equals(e.Property.Name, "IsVisible")) {
                this.resizeGrid();
            }
        }

        private void radLabel5_Click(object sender, EventArgs e) {

        }

        private void radLabel7_Click(object sender, EventArgs e) {

        }
    }
}
