using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace PodiumTimeApp.forms {
    public partial class frmMessage : Telerik.WinControls.UI.RadForm {

        public frmMessage(string msg, string stackTrace, MessageBoxIcon icon) {
            InitializeComponent();

            switch(icon) {
                case MessageBoxIcon.Error:
                    this.Icon = SystemIcons.Error;
                    break;
                case MessageBoxIcon.Information:
                    this.Icon = SystemIcons.Information;
                    break;
                case MessageBoxIcon.None:
                    this.Icon = SystemIcons.WinLogo;
                    break;
                case MessageBoxIcon.Question:
                    this.Icon = SystemIcons.Question;
                    break;
                case MessageBoxIcon.Warning:
                    this.Icon = SystemIcons.Warning;
                    break;
                default:
                    this.Icon = SystemIcons.WinLogo;
                    break;
            }

            txtMessage.Text = msg;
            txtStackTrace.Text = stackTrace;
        }

        private void btnOK_Click(object sender, EventArgs e) {
            this.Dispose(true);
            this.Close();
        }
    }
}
