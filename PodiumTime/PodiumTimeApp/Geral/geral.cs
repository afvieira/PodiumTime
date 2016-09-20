using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Telerik.WinControls.UI;

namespace PodiumTimeApp.Geral {
    public static class geral {

        public static void showErrorMessage(Exception ex) {
            forms.frmMessage frm = new forms.frmMessage(ex.Message, ex.StackTrace, System.Windows.Forms.MessageBoxIcon.Error);
            frm.ShowDialog();
        }

        public static void showWarningessage(Exception ex) {
            forms.frmMessage frm = new forms.frmMessage(ex.Message, ex.StackTrace, System.Windows.Forms.MessageBoxIcon.Warning);
            frm.ShowDialog();
        }

        public static void showInformationMessage(Exception ex) {
            forms.frmMessage frm = new forms.frmMessage(ex.Message, ex.StackTrace, System.Windows.Forms.MessageBoxIcon.Information);
            frm.ShowDialog();
        }

        public static void showInvalidInformation(List<string> campos) {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Faltam preencher os seguintes campos:");
            sb.AppendLine();

            foreach(var str in campos) {
                sb.AppendLine(str);
            }

            Telerik.WinControls.RadMessageBox.Show(sb.ToString(), "Inválido", System.Windows.Forms.MessageBoxButtons.OK);
        }

        public static void resizeGrid(this Telerik.WinControls.UI.RadGridView control) {
            // get out if working base is not given
            var grid = control;
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
                foreach(var column in visibleColumns) {
                    column.Width += (emptySpace / (visibleColumns.Count() + 1));
                }
                //visibleColumns.Last().Width += emptySpace;
            }
        }

    }
}
