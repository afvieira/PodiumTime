using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using PodiumTimeController;

namespace PodiumTimeApp {
    public partial class frmInscricoes : Telerik.WinControls.UI.RadForm {

        private EventoController _EventoController = new EventoController();
        private InscricaoController _InscricaoController = new InscricaoController();

        public frmInscricoes() {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e) {
            try {
                cmbEventos.DataSource = _EventoController.GetAll(true);
            } catch(Exception ex) {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void cmbEventos_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e) {

        }
    }
}
