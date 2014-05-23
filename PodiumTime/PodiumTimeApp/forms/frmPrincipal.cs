using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI.Docking;

namespace PodiumTimeApp.forms {

    public partial class frmPrincipal : Telerik.WinControls.UI.RadForm {

        public frmPrincipal() {
            InitializeComponent();
            this.Icon = PodiumTimeApp.imgCustom.chronometer;
            new Telerik.WinControls.Themes.Office2010SilverTheme();
            Telerik.WinControls.ThemeResolutionService.ApplicationThemeName = "Office2010Silver";
        }

        #region Form

        private void frmDock_Load(object sender, EventArgs e) {
            try {
                this.WindowState = FormWindowState.Maximized;
            } catch(Exception ex) {
                Geral.geral.showErrorMessage(ex);
            }
        }

        private void frmDock_FormClosing(object sender, FormClosingEventArgs e) {
            try {
                if(Telerik.WinControls.RadMessageBox.Show("A aplicação vai encerrar. Deseja continuar?", "Podium Time", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes) {
                    this.Dispose(true);
                    this.Close();
                } else {
                    e.Cancel = true;
                }
            } catch(Exception ex) {
                Geral.geral.showErrorMessage(ex);
            }
        }
        #endregion

        #region TopMenu

        private void mnuExit_Click(object sender, EventArgs e) {
            try {
                this.Close();
            } catch(Exception ex) {
                Geral.geral.showErrorMessage(ex);
            }
        }

        #endregion

        #region Botoes

        private void btnEventos_Click(object sender, EventArgs e) {
            try {
                addControl("Eventos", new uscEventos());
            } catch(Exception ex) {
                Geral.geral.showErrorMessage(ex);
            }
        }

        private void btnProvas_Click(object sender, EventArgs e) {
            try {
                addControl("Provas", new uscProvas());
            } catch(Exception ex) {
                Geral.geral.showErrorMessage(ex);
            }
        }

        private void btnResultados_Click(object sender, EventArgs e) {

        }

        private void btnInscricoes_Click(object sender, EventArgs e) {
            try {
                addControl("Inscrições", new uscInscricoes());
            } catch(Exception ex) {
                Geral.geral.showErrorMessage(ex);
            }
        }

        #endregion

        #region Outros controlos

        private void radDock1_FloatingWindowCreated(object sender, FloatingWindowEventArgs e) {
            e.Window.FormElement.TitleBar.CloseButton.Visibility = ElementVisibility.Collapsed;
        }

        #endregion

        #region Rotinas

        private void addControl(string titulo, System.Windows.Forms.UserControl control) {
            DocumentWindow docWindow = new DocumentWindow(titulo);

            control.Dock = DockStyle.Fill;
            docWindow.Controls.Add(control);
            this.dockPrincipal.AddDocument(docWindow);
        }

        #endregion

    }
}
