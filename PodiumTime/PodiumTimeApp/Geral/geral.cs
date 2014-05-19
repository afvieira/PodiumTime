using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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

        public static IList<T> Clone<T>(this IList<T> listToClone) where T : ICloneable {
            return listToClone.Select(item => (T)item.Clone()).ToList();
        }
    }
}
