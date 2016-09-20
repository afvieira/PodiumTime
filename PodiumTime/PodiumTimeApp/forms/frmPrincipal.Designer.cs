namespace PodiumTimeApp.forms {
    partial class frmPrincipal {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.dockPrincipal = new Telerik.WinControls.UI.Docking.RadDock();
            this.twMenu = new Telerik.WinControls.UI.Docking.ToolWindow();
            this.btnInscricoes = new Telerik.WinControls.UI.RadButton();
            this.btnResultados = new Telerik.WinControls.UI.RadButton();
            this.btnProvas = new Telerik.WinControls.UI.RadButton();
            this.btnEventos = new Telerik.WinControls.UI.RadButton();
            this.toolTabStrip1 = new Telerik.WinControls.UI.Docking.ToolTabStrip();
            this.documentContainer1 = new Telerik.WinControls.UI.Docking.DocumentContainer();
            this.radStatusStrip1 = new Telerik.WinControls.UI.RadStatusStrip();
            this.radLabelElement1 = new Telerik.WinControls.UI.RadLabelElement();
            this.radMenuItem2 = new Telerik.WinControls.UI.RadMenuItem();
            this.mnuExit = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuSeparatorItem1 = new Telerik.WinControls.UI.RadMenuSeparatorItem();
            this.radMenu2 = new Telerik.WinControls.UI.RadMenu();
            ((System.ComponentModel.ISupportInitialize)(this.dockPrincipal)).BeginInit();
            this.dockPrincipal.SuspendLayout();
            this.twMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnInscricoes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnResultados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnProvas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEventos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolTabStrip1)).BeginInit();
            this.toolTabStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.documentContainer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radStatusStrip1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radMenu2)).BeginInit();
            this.SuspendLayout();
            // 
            // dockPrincipal
            // 
            this.dockPrincipal.ActiveWindow = this.twMenu;
            this.dockPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dockPrincipal.Controls.Add(this.toolTabStrip1);
            this.dockPrincipal.Controls.Add(this.documentContainer1);
            this.dockPrincipal.IsCleanUpTarget = true;
            this.dockPrincipal.Location = new System.Drawing.Point(0, 23);
            this.dockPrincipal.MainDocumentContainer = this.documentContainer1;
            this.dockPrincipal.Name = "dockPrincipal";
            // 
            // 
            // 
            this.dockPrincipal.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this.dockPrincipal.Size = new System.Drawing.Size(599, 325);
            this.dockPrincipal.TabIndex = 0;
            this.dockPrincipal.TabStop = false;
            this.dockPrincipal.Text = "radDock1";
            this.dockPrincipal.FloatingWindowCreated += new Telerik.WinControls.UI.Docking.FloatingWindowEventHandler(this.radDock1_FloatingWindowCreated);
            // 
            // twMenu
            // 
            this.twMenu.Caption = null;
            this.twMenu.Controls.Add(this.btnInscricoes);
            this.twMenu.Controls.Add(this.btnResultados);
            this.twMenu.Controls.Add(this.btnProvas);
            this.twMenu.Controls.Add(this.btnEventos);
            this.twMenu.DocumentButtons = Telerik.WinControls.UI.Docking.DocumentStripButtons.ActiveWindowList;
            this.twMenu.Location = new System.Drawing.Point(1, 24);
            this.twMenu.Name = "twMenu";
            this.twMenu.PreviousDockState = Telerik.WinControls.UI.Docking.DockState.Docked;
            this.twMenu.Size = new System.Drawing.Size(159, 289);
            this.twMenu.Text = "Menu";
            this.twMenu.ToolCaptionButtons = Telerik.WinControls.UI.Docking.ToolStripCaptionButtons.AutoHide;
            // 
            // btnInscricoes
            // 
            this.btnInscricoes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInscricoes.Location = new System.Drawing.Point(5, 97);
            this.btnInscricoes.Name = "btnInscricoes";
            this.btnInscricoes.Size = new System.Drawing.Size(149, 24);
            this.btnInscricoes.TabIndex = 1;
            this.btnInscricoes.Text = "Inscrições";
            this.btnInscricoes.Click += new System.EventHandler(this.btnInscricoes_Click);
            // 
            // btnResultados
            // 
            this.btnResultados.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnResultados.Location = new System.Drawing.Point(5, 67);
            this.btnResultados.Name = "btnResultados";
            this.btnResultados.Size = new System.Drawing.Size(149, 24);
            this.btnResultados.TabIndex = 1;
            this.btnResultados.Text = "Resultados";
            this.btnResultados.Click += new System.EventHandler(this.btnResultados_Click);
            // 
            // btnProvas
            // 
            this.btnProvas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProvas.Location = new System.Drawing.Point(5, 37);
            this.btnProvas.Name = "btnProvas";
            this.btnProvas.Size = new System.Drawing.Size(149, 24);
            this.btnProvas.TabIndex = 1;
            this.btnProvas.Text = "Provas";
            this.btnProvas.Click += new System.EventHandler(this.btnProvas_Click);
            // 
            // btnEventos
            // 
            this.btnEventos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEventos.Location = new System.Drawing.Point(5, 7);
            this.btnEventos.Name = "btnEventos";
            this.btnEventos.Size = new System.Drawing.Size(149, 24);
            this.btnEventos.TabIndex = 0;
            this.btnEventos.Text = "Eventos";
            this.btnEventos.Click += new System.EventHandler(this.btnEventos_Click);
            // 
            // toolTabStrip1
            // 
            this.toolTabStrip1.CanUpdateChildIndex = true;
            this.toolTabStrip1.Controls.Add(this.twMenu);
            this.toolTabStrip1.Location = new System.Drawing.Point(5, 5);
            this.toolTabStrip1.Name = "toolTabStrip1";
            // 
            // 
            // 
            this.toolTabStrip1.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this.toolTabStrip1.SelectedIndex = 0;
            this.toolTabStrip1.Size = new System.Drawing.Size(161, 315);
            this.toolTabStrip1.SizeInfo.AbsoluteSize = new System.Drawing.Size(161, 200);
            this.toolTabStrip1.SizeInfo.SplitterCorrection = new System.Drawing.Size(-39, 0);
            this.toolTabStrip1.TabIndex = 1;
            this.toolTabStrip1.TabStop = false;
            // 
            // documentContainer1
            // 
            this.documentContainer1.Name = "documentContainer1";
            // 
            // 
            // 
            this.documentContainer1.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this.documentContainer1.SizeInfo.AbsoluteSize = new System.Drawing.Size(424, 200);
            this.documentContainer1.SizeInfo.SizeMode = Telerik.WinControls.UI.Docking.SplitPanelSizeMode.Fill;
            this.documentContainer1.SizeInfo.SplitterCorrection = new System.Drawing.Size(39, 0);
            this.documentContainer1.TabIndex = 2;
            // 
            // radStatusStrip1
            // 
            this.radStatusStrip1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radLabelElement1});
            this.radStatusStrip1.Location = new System.Drawing.Point(0, 351);
            this.radStatusStrip1.Name = "radStatusStrip1";
            this.radStatusStrip1.Size = new System.Drawing.Size(599, 24);
            this.radStatusStrip1.TabIndex = 2;
            this.radStatusStrip1.Text = "radStatusStrip1";
            // 
            // radLabelElement1
            // 
            this.radLabelElement1.AccessibleDescription = "© 2014 André Vieira";
            this.radLabelElement1.AccessibleName = "© 2014 André Vieira";
            this.radLabelElement1.Name = "radLabelElement1";
            this.radStatusStrip1.SetSpring(this.radLabelElement1, false);
            this.radLabelElement1.Text = "© 2014 André Vieira";
            this.radLabelElement1.TextWrap = true;
            this.radLabelElement1.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radMenuItem2
            // 
            this.radMenuItem2.AccessibleDescription = "radMenuItem2";
            this.radMenuItem2.AccessibleName = "radMenuItem2";
            this.radMenuItem2.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.mnuExit,
            this.radMenuSeparatorItem1});
            this.radMenuItem2.Name = "radMenuItem2";
            this.radMenuItem2.Text = "Geral";
            this.radMenuItem2.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // mnuExit
            // 
            this.mnuExit.AccessibleDescription = "radMenuItem3";
            this.mnuExit.AccessibleName = "radMenuItem3";
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Text = "Sair";
            this.mnuExit.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // radMenuSeparatorItem1
            // 
            this.radMenuSeparatorItem1.AccessibleDescription = "radMenuSeparatorItem1";
            this.radMenuSeparatorItem1.AccessibleName = "radMenuSeparatorItem1";
            this.radMenuSeparatorItem1.Name = "radMenuSeparatorItem1";
            this.radMenuSeparatorItem1.Text = "radMenuSeparatorItem1";
            this.radMenuSeparatorItem1.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 375);
            // 
            // radMenu2
            // 
            this.radMenu2.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radMenuItem2});
            this.radMenu2.Location = new System.Drawing.Point(0, 0);
            this.radMenu2.Name = "radMenu2";
            this.radMenu2.Size = new System.Drawing.Size(599, 20);
            this.radMenu2.TabIndex = 3;
            this.radMenu2.Text = "radMenu2";
            this.Controls.Add(this.radMenu2);
            this.Controls.Add(this.radStatusStrip1);
            this.Controls.Add(this.dockPrincipal);
            this.Name = "frmPrincipal";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Podium Time";
            this.ThemeName = "ControlDefault";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmDock_FormClosing);
            this.Load += new System.EventHandler(this.frmDock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dockPrincipal)).EndInit();
            this.dockPrincipal.ResumeLayout(false);
            this.twMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnInscricoes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnResultados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnProvas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEventos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolTabStrip1)).EndInit();
            this.toolTabStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.documentContainer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radStatusStrip1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radMenu2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.Docking.RadDock dockPrincipal;
        private Telerik.WinControls.UI.Docking.DocumentContainer documentContainer1;
        private Telerik.WinControls.UI.Docking.ToolTabStrip toolTabStrip1;
        private Telerik.WinControls.UI.Docking.ToolWindow twMenu;
        private Telerik.WinControls.UI.RadStatusStrip radStatusStrip1;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem2;
        private Telerik.WinControls.UI.RadMenuItem mnuExit;
        private Telerik.WinControls.UI.RadButton btnEventos;
        private Telerik.WinControls.UI.RadButton btnInscricoes;
        private Telerik.WinControls.UI.RadButton btnResultados;
        private Telerik.WinControls.UI.RadButton btnProvas;
        private Telerik.WinControls.UI.RadLabelElement radLabelElement1;
        private Telerik.WinControls.UI.RadMenuSeparatorItem radMenuSeparatorItem1;
        private Telerik.WinControls.UI.RadMenu radMenu2;
    }
}
