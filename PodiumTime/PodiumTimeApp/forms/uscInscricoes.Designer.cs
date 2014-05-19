namespace PodiumTimeApp.forms {
    partial class uscInscricoes {
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn1 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn1 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn7 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn2 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewCheckBoxColumn gridViewCheckBoxColumn1 = new Telerik.WinControls.UI.GridViewCheckBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn8 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            this.dgvInscricoes = new Telerik.WinControls.UI.RadGridView();
            this.btnLimparFiltro = new Telerik.WinControls.UI.RadButton();
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            this.cmbEvento = new Telerik.WinControls.UI.RadDropDownList();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.btnExport = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInscricoes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInscricoes.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLimparFiltro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            this.radPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbEvento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExport)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvInscricoes
            // 
            this.dgvInscricoes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvInscricoes.Location = new System.Drawing.Point(0, 45);
            // 
            // dgvInscricoes
            // 
            this.dgvInscricoes.MasterTemplate.AllowAddNewRow = false;
            this.dgvInscricoes.MasterTemplate.AllowDeleteRow = false;
            this.dgvInscricoes.MasterTemplate.AllowEditRow = false;
            this.dgvInscricoes.MasterTemplate.AllowRowResize = false;
            this.dgvInscricoes.MasterTemplate.AutoGenerateColumns = false;
            this.dgvInscricoes.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewDecimalColumn1.ExcelExportType = Telerik.WinControls.UI.Export.DisplayFormatType.Text;
            gridViewDecimalColumn1.FieldName = "ID";
            gridViewDecimalColumn1.HeaderText = "ID";
            gridViewDecimalColumn1.IsVisible = false;
            gridViewDecimalColumn1.Name = "ID";
            gridViewDecimalColumn1.Width = 5;
            gridViewDateTimeColumn1.ExcelExportType = Telerik.WinControls.UI.Export.DisplayFormatType.GeneralDate;
            gridViewDateTimeColumn1.FieldName = "DataInscricao";
            gridViewDateTimeColumn1.FilteringMode = Telerik.WinControls.UI.GridViewTimeFilteringMode.Date;
            gridViewDateTimeColumn1.HeaderText = "Data Inscrição";
            gridViewDateTimeColumn1.Name = "DataInscricao";
            gridViewDateTimeColumn1.Width = 43;
            gridViewTextBoxColumn1.ExcelExportType = Telerik.WinControls.UI.Export.DisplayFormatType.Text;
            gridViewTextBoxColumn1.FieldName = "Nome";
            gridViewTextBoxColumn1.HeaderText = "Nome";
            gridViewTextBoxColumn1.Name = "Nome";
            gridViewTextBoxColumn1.Width = 132;
            gridViewTextBoxColumn2.ExcelExportType = Telerik.WinControls.UI.Export.DisplayFormatType.Text;
            gridViewTextBoxColumn2.FieldName = "Sexo";
            gridViewTextBoxColumn2.HeaderText = "Sexo";
            gridViewTextBoxColumn2.IsVisible = false;
            gridViewTextBoxColumn2.Name = "Sexo";
            gridViewTextBoxColumn2.Width = 8;
            gridViewTextBoxColumn3.ExcelExportType = Telerik.WinControls.UI.Export.DisplayFormatType.Text;
            gridViewTextBoxColumn3.FieldName = "Email";
            gridViewTextBoxColumn3.HeaderText = "Email";
            gridViewTextBoxColumn3.Name = "Email";
            gridViewTextBoxColumn3.Width = 73;
            gridViewTextBoxColumn4.ExcelExportType = Telerik.WinControls.UI.Export.DisplayFormatType.Text;
            gridViewTextBoxColumn4.FieldName = "Equipa";
            gridViewTextBoxColumn4.HeaderText = "Equipa";
            gridViewTextBoxColumn4.Name = "Equipa";
            gridViewTextBoxColumn4.Width = 89;
            gridViewTextBoxColumn5.ExcelExportType = Telerik.WinControls.UI.Export.DisplayFormatType.Text;
            gridViewTextBoxColumn5.FieldName = "TipoInscricao";
            gridViewTextBoxColumn5.HeaderText = "Tipo Inscricao";
            gridViewTextBoxColumn5.Name = "TipoInscricao";
            gridViewTextBoxColumn5.Width = 80;
            gridViewTextBoxColumn6.ExcelExportType = Telerik.WinControls.UI.Export.DisplayFormatType.Text;
            gridViewTextBoxColumn6.FieldName = "DocIdentificacao";
            gridViewTextBoxColumn6.HeaderText = "Doc. Identificacao";
            gridViewTextBoxColumn6.Name = "DocIdentificacao";
            gridViewTextBoxColumn6.Width = 73;
            gridViewTextBoxColumn7.ExcelExportType = Telerik.WinControls.UI.Export.DisplayFormatType.Text;
            gridViewTextBoxColumn7.FieldName = "Contacto";
            gridViewTextBoxColumn7.HeaderText = "Contacto";
            gridViewTextBoxColumn7.IsVisible = false;
            gridViewTextBoxColumn7.Name = "Contacto";
            gridViewTextBoxColumn7.Width = 8;
            gridViewDecimalColumn2.ExcelExportType = Telerik.WinControls.UI.Export.DisplayFormatType.Text;
            gridViewDecimalColumn2.FieldName = "Dorsal";
            gridViewDecimalColumn2.HeaderText = "Dorsal";
            gridViewDecimalColumn2.Name = "Dorsal";
            gridViewDecimalColumn2.Width = 43;
            gridViewCheckBoxColumn1.FieldName = "Pago";
            gridViewCheckBoxColumn1.HeaderText = "Pago";
            gridViewCheckBoxColumn1.Name = "Pago";
            gridViewCheckBoxColumn1.Width = 39;
            gridViewTextBoxColumn8.ExcelExportType = Telerik.WinControls.UI.Export.DisplayFormatType.Text;
            gridViewTextBoxColumn8.FieldName = "TamanhoJersey";
            gridViewTextBoxColumn8.HeaderText = "Tamanho Jersey";
            gridViewTextBoxColumn8.IsVisible = false;
            gridViewTextBoxColumn8.Name = "TamanhoJersey";
            gridViewTextBoxColumn8.Width = 7;
            this.dgvInscricoes.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewDecimalColumn1,
            gridViewDateTimeColumn1,
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5,
            gridViewTextBoxColumn6,
            gridViewTextBoxColumn7,
            gridViewDecimalColumn2,
            gridViewCheckBoxColumn1,
            gridViewTextBoxColumn8});
            this.dgvInscricoes.MasterTemplate.EnableAlternatingRowColor = true;
            this.dgvInscricoes.MasterTemplate.EnableFiltering = true;
            this.dgvInscricoes.Name = "dgvInscricoes";
            this.dgvInscricoes.ReadOnly = true;
            this.dgvInscricoes.Size = new System.Drawing.Size(585, 238);
            this.dgvInscricoes.TabIndex = 0;
            this.dgvInscricoes.Text = "radGridView1";
            // 
            // btnLimparFiltro
            // 
            this.btnLimparFiltro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLimparFiltro.Image = global::PodiumTimeApp.img16.filter;
            this.btnLimparFiltro.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLimparFiltro.Location = new System.Drawing.Point(3, 289);
            this.btnLimparFiltro.Name = "btnLimparFiltro";
            this.btnLimparFiltro.Size = new System.Drawing.Size(26, 26);
            this.btnLimparFiltro.TabIndex = 1;
            this.btnLimparFiltro.Click += new System.EventHandler(this.btnLimparFiltro_Click);
            // 
            // radPanel1
            // 
            this.radPanel1.Controls.Add(this.cmbEvento);
            this.radPanel1.Controls.Add(this.radLabel1);
            this.radPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.radPanel1.Location = new System.Drawing.Point(0, 0);
            this.radPanel1.Name = "radPanel1";
            this.radPanel1.Size = new System.Drawing.Size(585, 39);
            this.radPanel1.TabIndex = 2;
            // 
            // cmbEvento
            // 
            this.cmbEvento.AutoCompleteDisplayMember = "Nome";
            this.cmbEvento.AutoCompleteValueMember = "ID";
            this.cmbEvento.DisplayMember = "Nome";
            this.cmbEvento.Location = new System.Drawing.Point(58, 9);
            this.cmbEvento.MinimumSize = new System.Drawing.Size(220, 20);
            this.cmbEvento.Name = "cmbEvento";
            // 
            // 
            // 
            this.cmbEvento.RootElement.MinSize = new System.Drawing.Size(220, 20);
            this.cmbEvento.Size = new System.Drawing.Size(220, 20);
            this.cmbEvento.TabIndex = 1;
            this.cmbEvento.ValueMember = "ID";
            this.cmbEvento.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.cmbEvento_SelectedIndexChanged);
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(9, 10);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(43, 18);
            this.radLabel1.TabIndex = 0;
            this.radLabel1.Text = "Evento:";
            // 
            // btnExport
            // 
            this.btnExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnExport.Image = global::PodiumTimeApp.img16.excel;
            this.btnExport.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnExport.Location = new System.Drawing.Point(35, 289);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(26, 26);
            this.btnExport.TabIndex = 3;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // uscInscricoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.radPanel1);
            this.Controls.Add(this.btnLimparFiltro);
            this.Controls.Add(this.dgvInscricoes);
            this.Name = "uscInscricoes";
            this.Size = new System.Drawing.Size(585, 318);
            this.VisibleChanged += new System.EventHandler(this.uscInscricoes_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInscricoes.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInscricoes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLimparFiltro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            this.radPanel1.ResumeLayout(false);
            this.radPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbEvento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExport)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView dgvInscricoes;
        private Telerik.WinControls.UI.RadButton btnLimparFiltro;
        private Telerik.WinControls.UI.RadPanel radPanel1;
        private Telerik.WinControls.UI.RadDropDownList cmbEvento;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadButton btnExport;
    }
}
