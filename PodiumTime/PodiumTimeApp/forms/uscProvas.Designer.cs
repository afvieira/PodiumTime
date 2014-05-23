namespace PodiumTimeApp.forms {
    partial class uscProvas {
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn2 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.btnNovo = new Telerik.WinControls.UI.RadButton();
            this.btnRemover = new Telerik.WinControls.UI.RadButton();
            this.btnGuardar = new Telerik.WinControls.UI.RadButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLimparFiltro = new Telerik.WinControls.UI.RadButton();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnIniciarProva = new Telerik.WinControls.UI.RadButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtDescricao = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel8 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.txtNome = new Telerik.WinControls.UI.RadTextBox();
            this.lblID = new Telerik.WinControls.UI.RadLabel();
            this.radLabel7 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel10 = new Telerik.WinControls.UI.RadLabel();
            this.nudDistancia = new Telerik.WinControls.UI.RadSpinEditor();
            this.btnExport = new Telerik.WinControls.UI.RadButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            this.cmbEvento = new Telerik.WinControls.UI.RadDropDownList();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.dgvProvas = new Telerik.WinControls.UI.RadGridView();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNovo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRemover)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGuardar)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnLimparFiltro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnIniciarProva)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescricao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDistancia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExport)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            this.radPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbEvento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProvas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProvas.MasterTemplate)).BeginInit();
            this.SuspendLayout();
            // 
            // radLabel2
            // 
            this.radLabel2.Location = new System.Drawing.Point(80, 3);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(20, 18);
            this.radLabel2.TabIndex = 0;
            this.radLabel2.Text = "ID:";
            // 
            // btnNovo
            // 
            this.btnNovo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNovo.Image = global::PodiumTimeApp.img16.edit_add;
            this.btnNovo.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnNovo.Location = new System.Drawing.Point(6, 133);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(82, 24);
            this.btnNovo.TabIndex = 1;
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
            this.btnRemover.Location = new System.Drawing.Point(94, 133);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(82, 24);
            this.btnRemover.TabIndex = 2;
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
            this.btnGuardar.Location = new System.Drawing.Point(182, 133);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(82, 24);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnLimparFiltro);
            this.panel1.Controls.Add(this.radGroupBox1);
            this.panel1.Controls.Add(this.btnExport);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 181);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(683, 227);
            this.panel1.TabIndex = 0;
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
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.tableLayoutPanel2);
            this.radGroupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.radGroupBox1.HeaderText = "Inscrição";
            this.radGroupBox1.Location = new System.Drawing.Point(0, 35);
            this.radGroupBox1.MaximumSize = new System.Drawing.Size(795, 400);
            this.radGroupBox1.Name = "radGroupBox1";
            // 
            // 
            // 
            this.radGroupBox1.RootElement.MaxSize = new System.Drawing.Size(795, 400);
            this.radGroupBox1.Size = new System.Drawing.Size(683, 192);
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
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 273F));
            this.tableLayoutPanel2.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel3, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(5, 21);
            this.tableLayoutPanel2.MaximumSize = new System.Drawing.Size(781, 300);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(669, 166);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnIniciarProva);
            this.panel2.Controls.Add(this.btnNovo);
            this.panel2.Controls.Add(this.btnRemover);
            this.panel2.Controls.Add(this.btnGuardar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(399, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(267, 160);
            this.panel2.TabIndex = 1;
            // 
            // btnIniciarProva
            // 
            this.btnIniciarProva.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnIniciarProva.BackColor = System.Drawing.SystemColors.Control;
            this.btnIniciarProva.Image = global::PodiumTimeApp.img64.player_play;
            this.btnIniciarProva.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnIniciarProva.Location = new System.Drawing.Point(66, 27);
            this.btnIniciarProva.Name = "btnIniciarProva";
            this.btnIniciarProva.Size = new System.Drawing.Size(143, 84);
            this.btnIniciarProva.TabIndex = 0;
            this.btnIniciarProva.Text = "Iniciar Prova";
            this.btnIniciarProva.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnIniciarProva.Click += new System.EventHandler(this.btnIniciarProva_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtDescricao);
            this.panel3.Controls.Add(this.radLabel8);
            this.panel3.Controls.Add(this.radLabel4);
            this.panel3.Controls.Add(this.radLabel2);
            this.panel3.Controls.Add(this.txtNome);
            this.panel3.Controls.Add(this.lblID);
            this.panel3.Controls.Add(this.radLabel7);
            this.panel3.Controls.Add(this.radLabel10);
            this.panel3.Controls.Add(this.nudDistancia);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(390, 160);
            this.panel3.TabIndex = 0;
            // 
            // txtDescricao
            // 
            this.txtDescricao.AcceptsReturn = true;
            this.txtDescricao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescricao.AutoSize = false;
            this.txtDescricao.Location = new System.Drawing.Point(106, 79);
            this.txtDescricao.MaximumSize = new System.Drawing.Size(393, 67);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            // 
            // 
            // 
            this.txtDescricao.RootElement.MaxSize = new System.Drawing.Size(393, 67);
            this.txtDescricao.Size = new System.Drawing.Size(281, 67);
            this.txtDescricao.TabIndex = 2;
            // 
            // radLabel8
            // 
            this.radLabel8.Location = new System.Drawing.Point(43, 78);
            this.radLabel8.Name = "radLabel8";
            this.radLabel8.Size = new System.Drawing.Size(57, 18);
            this.radLabel8.TabIndex = 5;
            this.radLabel8.Text = "Descrição:";
            // 
            // radLabel4
            // 
            this.radLabel4.Location = new System.Drawing.Point(176, 54);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.Size = new System.Drawing.Size(27, 18);
            this.radLabel4.TabIndex = 13;
            this.radLabel4.Text = "Kms";
            // 
            // txtNome
            // 
            this.txtNome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNome.Location = new System.Drawing.Point(106, 27);
            this.txtNome.MaximumSize = new System.Drawing.Size(393, 20);
            this.txtNome.Name = "txtNome";
            // 
            // 
            // 
            this.txtNome.RootElement.MaxSize = new System.Drawing.Size(393, 20);
            this.txtNome.Size = new System.Drawing.Size(281, 20);
            this.txtNome.TabIndex = 0;
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
            this.radLabel7.Location = new System.Drawing.Point(61, 28);
            this.radLabel7.Name = "radLabel7";
            this.radLabel7.Size = new System.Drawing.Size(39, 18);
            this.radLabel7.TabIndex = 5;
            this.radLabel7.Text = "Nome:";
            // 
            // radLabel10
            // 
            this.radLabel10.Location = new System.Drawing.Point(46, 54);
            this.radLabel10.Name = "radLabel10";
            this.radLabel10.Size = new System.Drawing.Size(54, 18);
            this.radLabel10.TabIndex = 8;
            this.radLabel10.Text = "Distância:";
            // 
            // nudDistancia
            // 
            this.nudDistancia.DecimalPlaces = 2;
            this.nudDistancia.Location = new System.Drawing.Point(106, 53);
            this.nudDistancia.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudDistancia.Name = "nudDistancia";
            this.nudDistancia.Size = new System.Drawing.Size(64, 20);
            this.nudDistancia.TabIndex = 1;
            this.nudDistancia.TabStop = false;
            this.nudDistancia.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
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
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.radPanel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dgvProvas, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 233F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(689, 411);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // radPanel1
            // 
            this.radPanel1.Controls.Add(this.cmbEvento);
            this.radPanel1.Controls.Add(this.radLabel1);
            this.radPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radPanel1.Location = new System.Drawing.Point(3, 3);
            this.radPanel1.Name = "radPanel1";
            this.radPanel1.Size = new System.Drawing.Size(683, 37);
            this.radPanel1.TabIndex = 1;
            // 
            // cmbEvento
            // 
            this.cmbEvento.AutoCompleteDisplayMember = "Nome";
            this.cmbEvento.AutoCompleteValueMember = "ID";
            this.cmbEvento.DisplayMember = "Nome";
            this.cmbEvento.Location = new System.Drawing.Point(58, 9);
            this.cmbEvento.MinimumSize = new System.Drawing.Size(220, 20);
            this.cmbEvento.Name = "cmbEvento";
            this.cmbEvento.RootElement.MinSize = new System.Drawing.Size(220, 20);
            this.cmbEvento.Size = new System.Drawing.Size(220, 20);
            this.cmbEvento.TabIndex = 0;
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
            // dgvProvas
            // 
            this.dgvProvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProvas.Location = new System.Drawing.Point(3, 46);
            this.dgvProvas.SelectionChanged += new System.EventHandler(this.dgvProvas_SelectionChanged);
            // 
            // dgvProvas
            // 
            this.dgvProvas.MasterTemplate.AllowAddNewRow = false;
            this.dgvProvas.MasterTemplate.AllowDeleteRow = false;
            this.dgvProvas.MasterTemplate.AllowEditRow = false;
            this.dgvProvas.MasterTemplate.AllowRowResize = false;
            this.dgvProvas.MasterTemplate.AutoGenerateColumns = false;
            this.dgvProvas.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewDecimalColumn1.ExcelExportType = Telerik.WinControls.UI.Export.DisplayFormatType.Text;
            gridViewDecimalColumn1.FieldName = "ID";
            gridViewDecimalColumn1.HeaderText = "ID";
            gridViewDecimalColumn1.Name = "ID";
            gridViewDecimalColumn1.Width = 53;
            gridViewTextBoxColumn1.ExcelExportType = Telerik.WinControls.UI.Export.DisplayFormatType.Text;
            gridViewTextBoxColumn1.FieldName = "Nome";
            gridViewTextBoxColumn1.HeaderText = "Nome";
            gridViewTextBoxColumn1.Name = "Nome";
            gridViewTextBoxColumn1.Width = 215;
            gridViewTextBoxColumn2.ExcelExportType = Telerik.WinControls.UI.Export.DisplayFormatType.Text;
            gridViewTextBoxColumn2.FieldName = "Descricao";
            gridViewTextBoxColumn2.HeaderText = "Descrição";
            gridViewTextBoxColumn2.Name = "Descrição";
            gridViewTextBoxColumn2.Width = 282;
            gridViewDecimalColumn2.ExcelExportType = Telerik.WinControls.UI.Export.DisplayFormatType.Text;
            gridViewDecimalColumn2.FieldName = "Distancia";
            gridViewDecimalColumn2.HeaderText = "Distância";
            gridViewDecimalColumn2.Name = "Distância";
            gridViewDecimalColumn2.Width = 116;
            this.dgvProvas.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewDecimalColumn1,
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewDecimalColumn2});
            this.dgvProvas.MasterTemplate.EnableAlternatingRowColor = true;
            this.dgvProvas.MasterTemplate.EnableFiltering = true;
            this.dgvProvas.Name = "dgvProvas";
            this.dgvProvas.ReadOnly = true;
            this.dgvProvas.Size = new System.Drawing.Size(683, 129);
            this.dgvProvas.TabIndex = 2;
            this.dgvProvas.Text = "radGridView1";
            // 
            // uscProvas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "uscProvas";
            this.Size = new System.Drawing.Size(689, 411);
            this.VisibleChanged += new System.EventHandler(this.uscProvas_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNovo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRemover)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGuardar)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnLimparFiltro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnIniciarProva)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescricao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDistancia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExport)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            this.radPanel1.ResumeLayout(false);
            this.radPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbEvento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProvas.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProvas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadButton btnNovo;
        private Telerik.WinControls.UI.RadButton btnRemover;
        private Telerik.WinControls.UI.RadButton btnGuardar;
        private System.Windows.Forms.Panel panel1;
        private Telerik.WinControls.UI.RadButton btnLimparFiltro;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel2;
        private Telerik.WinControls.UI.RadSpinEditor nudDistancia;
        private Telerik.WinControls.UI.RadLabel radLabel10;
        private System.Windows.Forms.Panel panel3;
        private Telerik.WinControls.UI.RadTextBox txtNome;
        private Telerik.WinControls.UI.RadLabel lblID;
        private Telerik.WinControls.UI.RadLabel radLabel7;
        private Telerik.WinControls.UI.RadButton btnExport;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Telerik.WinControls.UI.RadPanel radPanel1;
        private Telerik.WinControls.UI.RadDropDownList cmbEvento;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadGridView dgvProvas;
        private Telerik.WinControls.UI.RadTextBox txtDescricao;
        private Telerik.WinControls.UI.RadLabel radLabel8;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        private Telerik.WinControls.UI.RadButton btnIniciarProva;
    }
}
