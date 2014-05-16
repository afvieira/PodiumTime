namespace PodiumTimeApp {
    partial class frmPrincipal {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.raddgvInscricoes = new Telerik.WinControls.UI.RadGridView();
            ((System.ComponentModel.ISupportInitialize)(this.raddgvInscricoes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.raddgvInscricoes.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // raddgvInscricoes
            // 
            this.raddgvInscricoes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.raddgvInscricoes.Location = new System.Drawing.Point(0, 0);
            this.raddgvInscricoes.Name = "raddgvInscricoes";
            this.raddgvInscricoes.Size = new System.Drawing.Size(622, 392);
            this.raddgvInscricoes.TabIndex = 0;
            this.raddgvInscricoes.Text = "radGridView1";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 392);
            this.Controls.Add(this.raddgvInscricoes);
            this.Name = "frmPrincipal";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.raddgvInscricoes.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.raddgvInscricoes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView raddgvInscricoes;
    }
}

