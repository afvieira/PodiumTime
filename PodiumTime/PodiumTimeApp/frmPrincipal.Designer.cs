namespace PodiumTimeApp
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvInscricoes = new Telerik.WinControls.UI.RadGridView();
            this.cmbEventos = new Telerik.WinControls.UI.RadDropDownList();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInscricoes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInscricoes.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbEventos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvInscricoes
            // 
            this.dgvInscricoes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvInscricoes.Location = new System.Drawing.Point(12, 38);
            // 
            // dgvInscricoes
            // 
            this.dgvInscricoes.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            this.dgvInscricoes.Name = "dgvInscricoes";
            this.dgvInscricoes.Size = new System.Drawing.Size(462, 232);
            this.dgvInscricoes.TabIndex = 0;
            this.dgvInscricoes.Text = "radGridView1";
            // 
            // cmbEventos
            // 
            this.cmbEventos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbEventos.AutoCompleteDisplayMember = "Nome";
            this.cmbEventos.AutoCompleteValueMember = "ID";
            this.cmbEventos.DisplayMember = "Nome";
            this.cmbEventos.Location = new System.Drawing.Point(12, 12);
            this.cmbEventos.Name = "cmbEventos";
            this.cmbEventos.Size = new System.Drawing.Size(462, 20);
            this.cmbEventos.TabIndex = 1;
            this.cmbEventos.Text = "radDropDownList1";
            this.cmbEventos.ValueMember = "ID";
            this.cmbEventos.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.cmbEventos_SelectedIndexChanged);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 282);
            this.Controls.Add(this.cmbEventos);
            this.Controls.Add(this.dgvInscricoes);
            this.Name = "frmPrincipal";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "frmPrincipal";
            this.ThemeName = "ControlDefault";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInscricoes.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInscricoes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbEventos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView dgvInscricoes;
        private Telerik.WinControls.UI.RadDropDownList cmbEventos;
    }
}
