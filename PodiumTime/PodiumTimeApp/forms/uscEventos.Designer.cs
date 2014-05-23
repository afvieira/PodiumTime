namespace PodiumTimeApp.forms {
    partial class uscEventos {
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
            Telerik.WinControls.UI.GridViewCheckBoxColumn gridViewCheckBoxColumn1 = new Telerik.WinControls.UI.GridViewCheckBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            this.dgvEventos = new Telerik.WinControls.UI.RadGridView();
            this.btnLimparFiltro = new Telerik.WinControls.UI.RadButton();
            this.btnExport = new Telerik.WinControls.UI.RadButton();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnNovo = new Telerik.WinControls.UI.RadButton();
            this.btnRemover = new Telerik.WinControls.UI.RadButton();
            this.btnGuardar = new Telerik.WinControls.UI.RadButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.chkCancelado = new Telerik.WinControls.UI.RadCheckBox();
            this.dtpData = new Telerik.WinControls.UI.RadDateTimePicker();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.txtDescricao = new Telerik.WinControls.UI.RadTextBox();
            this.txtNome = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel5 = new Telerik.WinControls.UI.RadLabel();
            this.lblID = new Telerik.WinControls.UI.RadLabel();
            this.radLabel7 = new Telerik.WinControls.UI.RadLabel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEventos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEventos.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLimparFiltro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnNovo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRemover)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGuardar)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkCancelado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescricao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel7)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvEventos
            // 
            this.dgvEventos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEventos.Location = new System.Drawing.Point(3, 3);
            // 
            // dgvEventos
            // 
            this.dgvEventos.MasterTemplate.AllowAddNewRow = false;
            this.dgvEventos.MasterTemplate.AllowDeleteRow = false;
            this.dgvEventos.MasterTemplate.AllowEditRow = false;
            this.dgvEventos.MasterTemplate.AllowRowResize = false;
            this.dgvEventos.MasterTemplate.AutoGenerateColumns = false;
            this.dgvEventos.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewDecimalColumn1.ExcelExportType = Telerik.WinControls.UI.Export.DisplayFormatType.Text;
            gridViewDecimalColumn1.FieldName = "ID";
            gridViewDecimalColumn1.HeaderText = "ID";
            gridViewDecimalColumn1.Name = "ID";
            gridViewDecimalColumn1.Width = 64;
            gridViewDateTimeColumn1.ExcelExportType = Telerik.WinControls.UI.Export.DisplayFormatType.GeneralDate;
            gridViewDateTimeColumn1.FieldName = "Data";
            gridViewDateTimeColumn1.FilteringMode = Telerik.WinControls.UI.GridViewTimeFilteringMode.Date;
            gridViewDateTimeColumn1.HeaderText = "Data";
            gridViewDateTimeColumn1.Name = "Data";
            gridViewDateTimeColumn1.Width = 128;
            gridViewTextBoxColumn1.ExcelExportType = Telerik.WinControls.UI.Export.DisplayFormatType.Text;
            gridViewTextBoxColumn1.FieldName = "Nome";
            gridViewTextBoxColumn1.HeaderText = "Nome";
            gridViewTextBoxColumn1.Name = "Nome";
            gridViewTextBoxColumn1.Width = 192;
            gridViewCheckBoxColumn1.FieldName = "Cancelado";
            gridViewCheckBoxColumn1.HeaderText = "Cancelado";
            gridViewCheckBoxColumn1.Name = "Cancelado";
            gridViewCheckBoxColumn1.Width = 128;
            gridViewTextBoxColumn2.ExcelExportType = Telerik.WinControls.UI.Export.DisplayFormatType.Text;
            gridViewTextBoxColumn2.FieldName = "Descricao";
            gridViewTextBoxColumn2.HeaderText = "Descrição";
            gridViewTextBoxColumn2.Name = "Descrição";
            gridViewTextBoxColumn2.Width = 254;
            this.dgvEventos.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewDecimalColumn1,
            gridViewDateTimeColumn1,
            gridViewTextBoxColumn1,
            gridViewCheckBoxColumn1,
            gridViewTextBoxColumn2});
            this.dgvEventos.MasterTemplate.EnableAlternatingRowColor = true;
            this.dgvEventos.MasterTemplate.EnableFiltering = true;
            this.dgvEventos.Name = "dgvEventos";
            this.dgvEventos.ReadOnly = true;
            this.dgvEventos.Size = new System.Drawing.Size(782, 166);
            this.dgvEventos.TabIndex = 1;
            this.dgvEventos.Text = "radGridView1";
            this.dgvEventos.SelectionChanged += new System.EventHandler(this.dgvInscricoes_SelectionChanged);
            // 
            // btnLimparFiltro
            // 
            this.btnLimparFiltro.Image = global::PodiumTimeApp.img16.filter;
            this.btnLimparFiltro.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLimparFiltro.Location = new System.Drawing.Point(3, 3);
            this.btnLimparFiltro.Name = "btnLimparFiltro";
            this.btnLimparFiltro.Size = new System.Drawing.Size(26, 26);
            this.btnLimparFiltro.TabIndex = 0;
            this.btnLimparFiltro.Click += new System.EventHandler(this.btnLimparFiltro_Click);
            // 
            // btnExport
            // 
            this.btnExport.Image = global::PodiumTimeApp.img16.excel;
            this.btnExport.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnExport.Location = new System.Drawing.Point(35, 3);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(26, 26);
            this.btnExport.TabIndex = 1;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.tableLayoutPanel2);
            this.radGroupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.radGroupBox1.HeaderText = "Inscrição";
            this.radGroupBox1.Location = new System.Drawing.Point(0, 33);
            this.radGroupBox1.MaximumSize = new System.Drawing.Size(795, 400);
            this.radGroupBox1.Name = "radGroupBox1";
            // 
            // 
            // 
            this.radGroupBox1.RootElement.MaxSize = new System.Drawing.Size(795, 400);
            this.radGroupBox1.Size = new System.Drawing.Size(711, 182);
            this.radGroupBox1.TabIndex = 2;
            this.radGroupBox1.Text = "Inscrição";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 271F));
            this.tableLayoutPanel2.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel3, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(5, 21);
            this.tableLayoutPanel2.MaximumSize = new System.Drawing.Size(781, 300);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(697, 156);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnNovo);
            this.panel2.Controls.Add(this.btnRemover);
            this.panel2.Controls.Add(this.btnGuardar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(429, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(265, 150);
            this.panel2.TabIndex = 0;
            // 
            // btnNovo
            // 
            this.btnNovo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNovo.Image = global::PodiumTimeApp.img16.edit_add;
            this.btnNovo.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnNovo.Location = new System.Drawing.Point(4, 123);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(82, 24);
            this.btnNovo.TabIndex = 7;
            this.btnNovo.Text = "Novo";
            this.btnNovo.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNovo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemover.Image = global::PodiumTimeApp.img16.delete;
            this.btnRemover.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRemover.Location = new System.Drawing.Point(92, 123);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(82, 24);
            this.btnRemover.TabIndex = 8;
            this.btnRemover.Text = "Remover";
            this.btnRemover.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemover.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardar.Image = global::PodiumTimeApp.img16.save;
            this.btnGuardar.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnGuardar.Location = new System.Drawing.Point(180, 123);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(82, 24);
            this.btnGuardar.TabIndex = 9;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.chkCancelado);
            this.panel3.Controls.Add(this.dtpData);
            this.panel3.Controls.Add(this.radLabel2);
            this.panel3.Controls.Add(this.txtDescricao);
            this.panel3.Controls.Add(this.txtNome);
            this.panel3.Controls.Add(this.radLabel4);
            this.panel3.Controls.Add(this.radLabel5);
            this.panel3.Controls.Add(this.lblID);
            this.panel3.Controls.Add(this.radLabel7);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(420, 150);
            this.panel3.TabIndex = 1;
            // 
            // chkCancelado
            // 
            this.chkCancelado.Location = new System.Drawing.Point(253, 28);
            this.chkCancelado.Name = "chkCancelado";
            this.chkCancelado.Size = new System.Drawing.Size(72, 18);
            this.chkCancelado.TabIndex = 22;
            this.chkCancelado.Text = "Cancelado";
            // 
            // dtpData
            // 
            this.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpData.Location = new System.Drawing.Point(106, 27);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(95, 20);
            this.dtpData.TabIndex = 21;
            this.dtpData.TabStop = false;
            this.dtpData.Text = "22/05/2014";
            this.dtpData.Value = new System.DateTime(2014, 5, 22, 22, 18, 34, 157);
            // 
            // radLabel2
            // 
            this.radLabel2.Location = new System.Drawing.Point(80, 3);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(20, 18);
            this.radLabel2.TabIndex = 0;
            this.radLabel2.Text = "ID:";
            // 
            // txtDescricao
            // 
            this.txtDescricao.AcceptsReturn = true;
            this.txtDescricao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescricao.AutoSize = false;
            this.txtDescricao.Location = new System.Drawing.Point(106, 79);
            this.txtDescricao.MaximumSize = new System.Drawing.Size(311, 67);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            // 
            // 
            // 
            this.txtDescricao.RootElement.MaxSize = new System.Drawing.Size(311, 67);
            this.txtDescricao.Size = new System.Drawing.Size(311, 67);
            this.txtDescricao.TabIndex = 4;
            // 
            // txtNome
            // 
            this.txtNome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNome.Location = new System.Drawing.Point(106, 53);
            this.txtNome.MaximumSize = new System.Drawing.Size(311, 20);
            this.txtNome.Name = "txtNome";
            // 
            // 
            // 
            this.txtNome.RootElement.MaxSize = new System.Drawing.Size(311, 20);
            this.txtNome.Size = new System.Drawing.Size(311, 20);
            this.txtNome.TabIndex = 3;
            // 
            // radLabel4
            // 
            this.radLabel4.Location = new System.Drawing.Point(43, 78);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.Size = new System.Drawing.Size(57, 18);
            this.radLabel4.TabIndex = 2;
            this.radLabel4.Text = "Descrição:";
            // 
            // radLabel5
            // 
            this.radLabel5.Location = new System.Drawing.Point(61, 54);
            this.radLabel5.Name = "radLabel5";
            this.radLabel5.Size = new System.Drawing.Size(39, 18);
            this.radLabel5.TabIndex = 3;
            this.radLabel5.Text = "Nome:";
            // 
            // lblID
            // 
            this.lblID.Location = new System.Drawing.Point(106, 3);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(17, 18);
            this.lblID.TabIndex = 12;
            this.lblID.Text = "ID";
            // 
            // radLabel7
            // 
            this.radLabel7.Location = new System.Drawing.Point(68, 28);
            this.radLabel7.Name = "radLabel7";
            this.radLabel7.Size = new System.Drawing.Size(32, 18);
            this.radLabel7.TabIndex = 5;
            this.radLabel7.Text = "Data:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.dgvEventos, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 221F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(788, 393);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnLimparFiltro);
            this.panel1.Controls.Add(this.radGroupBox1);
            this.panel1.Controls.Add(this.btnExport);
            this.panel1.Location = new System.Drawing.Point(3, 175);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(711, 215);
            this.panel1.TabIndex = 3;
            // 
            // uscEventos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "uscEventos";
            this.Size = new System.Drawing.Size(788, 393);
            this.VisibleChanged += new System.EventHandler(this.uscEventos_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEventos.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEventos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLimparFiltro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnNovo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRemover)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGuardar)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkCancelado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescricao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel7)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView dgvEventos;
        private Telerik.WinControls.UI.RadButton btnLimparFiltro;
        private Telerik.WinControls.UI.RadButton btnExport;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private Telerik.WinControls.UI.RadLabel radLabel7;
        private Telerik.WinControls.UI.RadLabel radLabel5;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private Telerik.WinControls.UI.RadTextBox txtDescricao;
        private Telerik.WinControls.UI.RadTextBox txtNome;
        private Telerik.WinControls.UI.RadLabel lblID;
        private Telerik.WinControls.UI.RadButton btnGuardar;
        private Telerik.WinControls.UI.RadButton btnNovo;
        private Telerik.WinControls.UI.RadButton btnRemover;
        private Telerik.WinControls.UI.RadDateTimePicker dtpData;
        private Telerik.WinControls.UI.RadCheckBox chkCancelado;
    }
}
