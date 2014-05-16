using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using podiumTimeModels;

namespace PodiumTimeApp
{
    public partial class frmPrincipal : Telerik.WinControls.UI.RadForm
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            podiumTimeClassesDataContext db = new podiumTimeClassesDataContext();

            var inscricoes = from i in db.Inscricaos
                             select i;

            raddgvInscricoes.DataSource = inscricoes;
        }
    }
}
