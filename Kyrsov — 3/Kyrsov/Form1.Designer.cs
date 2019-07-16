namespace Kyrsov
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.iDzakazDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDklientDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stoimostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDkurierDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zakazBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bazaDataSet = new Kyrsov.bazaDataSet();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDklientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameklientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.klientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.iDzakazDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDtovarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nametovarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolvotovarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tovarzakazBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bazaDataSet1 = new Kyrsov.bazaDataSet();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.iDtovarDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nametovarDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stoimosttovarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolvovnalichDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.assortimentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.iDkyrierDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namekyrierDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kyrierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tovarzakazBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.заказToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.заказToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.курьеровToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.klientTableAdapter = new Kyrsov.bazaDataSetTableAdapters.KlientTableAdapter();
            this.zakazTableAdapter = new Kyrsov.bazaDataSetTableAdapters.ZakazTableAdapter();
            this.tovar_zakazTableAdapter = new Kyrsov.bazaDataSetTableAdapters.Tovar_zakazTableAdapter();
            this.kyrierTableAdapter = new Kyrsov.bazaDataSetTableAdapters.KyrierTableAdapter();
            this.assortimentTableAdapter = new Kyrsov.bazaDataSetTableAdapters.AssortimentTableAdapter();
            this.zakazTovarzakazBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zakazBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bazaDataSet)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.klientBindingSource)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tovarzakazBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bazaDataSet1)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assortimentBindingSource)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kyrierBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tovarzakazBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zakazTovarzakazBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(12, 49);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(789, 233);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(781, 207);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Заказы";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDzakazDataGridViewTextBoxColumn,
            this.iDklientDataGridViewTextBoxColumn1,
            this.stoimostDataGridViewTextBoxColumn,
            this.iDkurierDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.zakazBindingSource;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(775, 201);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dataGridView2_RowsRemoved);
            // 
            // iDzakazDataGridViewTextBoxColumn
            // 
            this.iDzakazDataGridViewTextBoxColumn.DataPropertyName = "ID_zakaz";
            this.iDzakazDataGridViewTextBoxColumn.HeaderText = "ID_zakaz";
            this.iDzakazDataGridViewTextBoxColumn.Name = "iDzakazDataGridViewTextBoxColumn";
            this.iDzakazDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDklientDataGridViewTextBoxColumn1
            // 
            this.iDklientDataGridViewTextBoxColumn1.DataPropertyName = "ID_klient";
            this.iDklientDataGridViewTextBoxColumn1.HeaderText = "ID_klient";
            this.iDklientDataGridViewTextBoxColumn1.Name = "iDklientDataGridViewTextBoxColumn1";
            this.iDklientDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // stoimostDataGridViewTextBoxColumn
            // 
            this.stoimostDataGridViewTextBoxColumn.DataPropertyName = "Stoimost";
            this.stoimostDataGridViewTextBoxColumn.HeaderText = "Stoimost";
            this.stoimostDataGridViewTextBoxColumn.Name = "stoimostDataGridViewTextBoxColumn";
            this.stoimostDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDkurierDataGridViewTextBoxColumn
            // 
            this.iDkurierDataGridViewTextBoxColumn.DataPropertyName = "ID_kurier";
            this.iDkurierDataGridViewTextBoxColumn.HeaderText = "ID_kurier";
            this.iDkurierDataGridViewTextBoxColumn.Name = "iDkurierDataGridViewTextBoxColumn";
            this.iDkurierDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDkurierDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // zakazBindingSource
            // 
            this.zakazBindingSource.DataMember = "Zakaz";
            this.zakazBindingSource.DataSource = this.bazaDataSet;
            // 
            // bazaDataSet
            // 
            this.bazaDataSet.DataSetName = "bazaDataSet";
            this.bazaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(781, 207);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Клиент";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDklientDataGridViewTextBoxColumn,
            this.nameklientDataGridViewTextBoxColumn,
            this.adresDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.klientBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(775, 201);
            this.dataGridView1.TabIndex = 0;
            // 
            // iDklientDataGridViewTextBoxColumn
            // 
            this.iDklientDataGridViewTextBoxColumn.DataPropertyName = "ID_klient";
            this.iDklientDataGridViewTextBoxColumn.HeaderText = "ID_klient";
            this.iDklientDataGridViewTextBoxColumn.Name = "iDklientDataGridViewTextBoxColumn";
            this.iDklientDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameklientDataGridViewTextBoxColumn
            // 
            this.nameklientDataGridViewTextBoxColumn.DataPropertyName = "Name_klient";
            this.nameklientDataGridViewTextBoxColumn.HeaderText = "Name_klient";
            this.nameklientDataGridViewTextBoxColumn.Name = "nameklientDataGridViewTextBoxColumn";
            this.nameklientDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // adresDataGridViewTextBoxColumn
            // 
            this.adresDataGridViewTextBoxColumn.DataPropertyName = "Adres";
            this.adresDataGridViewTextBoxColumn.HeaderText = "Adres";
            this.adresDataGridViewTextBoxColumn.Name = "adresDataGridViewTextBoxColumn";
            this.adresDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // klientBindingSource
            // 
            this.klientBindingSource.DataMember = "Klient";
            this.klientBindingSource.DataSource = this.bazaDataSet;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridView3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(781, 207);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Список товаров";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDzakazDataGridViewTextBoxColumn1,
            this.iDtovarDataGridViewTextBoxColumn,
            this.nametovarDataGridViewTextBoxColumn,
            this.kolvotovarDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.tovarzakazBindingSource1;
            this.dataGridView3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView3.Location = new System.Drawing.Point(3, 3);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.Size = new System.Drawing.Size(775, 201);
            this.dataGridView3.TabIndex = 0;
            // 
            // iDzakazDataGridViewTextBoxColumn1
            // 
            this.iDzakazDataGridViewTextBoxColumn1.DataPropertyName = "ID_zakaz";
            this.iDzakazDataGridViewTextBoxColumn1.HeaderText = "ID_zakaz";
            this.iDzakazDataGridViewTextBoxColumn1.Name = "iDzakazDataGridViewTextBoxColumn1";
            this.iDzakazDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // iDtovarDataGridViewTextBoxColumn
            // 
            this.iDtovarDataGridViewTextBoxColumn.DataPropertyName = "ID_tovar";
            this.iDtovarDataGridViewTextBoxColumn.HeaderText = "ID_tovar";
            this.iDtovarDataGridViewTextBoxColumn.Name = "iDtovarDataGridViewTextBoxColumn";
            this.iDtovarDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nametovarDataGridViewTextBoxColumn
            // 
            this.nametovarDataGridViewTextBoxColumn.DataPropertyName = "Name_tovar";
            this.nametovarDataGridViewTextBoxColumn.HeaderText = "Name_tovar";
            this.nametovarDataGridViewTextBoxColumn.Name = "nametovarDataGridViewTextBoxColumn";
            this.nametovarDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kolvotovarDataGridViewTextBoxColumn
            // 
            this.kolvotovarDataGridViewTextBoxColumn.DataPropertyName = "Kolvo_tovar";
            this.kolvotovarDataGridViewTextBoxColumn.HeaderText = "Kolvo_tovar";
            this.kolvotovarDataGridViewTextBoxColumn.Name = "kolvotovarDataGridViewTextBoxColumn";
            this.kolvotovarDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tovarzakazBindingSource1
            // 
            this.tovarzakazBindingSource1.DataMember = "Tovar_zakaz";
            this.tovarzakazBindingSource1.DataSource = this.bazaDataSet1;
            // 
            // bazaDataSet1
            // 
            this.bazaDataSet1.DataSetName = "bazaDataSet";
            this.bazaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.dataGridView5);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(781, 207);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Ассортимент";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // dataGridView5
            // 
            this.dataGridView5.AutoGenerateColumns = false;
            this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView5.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDtovarDataGridViewTextBoxColumn1,
            this.nametovarDataGridViewTextBoxColumn1,
            this.stoimosttovarDataGridViewTextBoxColumn,
            this.kolvovnalichDataGridViewTextBoxColumn});
            this.dataGridView5.DataSource = this.assortimentBindingSource;
            this.dataGridView5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView5.Location = new System.Drawing.Point(3, 3);
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.Size = new System.Drawing.Size(775, 201);
            this.dataGridView5.TabIndex = 0;
            // 
            // iDtovarDataGridViewTextBoxColumn1
            // 
            this.iDtovarDataGridViewTextBoxColumn1.DataPropertyName = "ID_tovar";
            this.iDtovarDataGridViewTextBoxColumn1.HeaderText = "ID_tovar";
            this.iDtovarDataGridViewTextBoxColumn1.Name = "iDtovarDataGridViewTextBoxColumn1";
            // 
            // nametovarDataGridViewTextBoxColumn1
            // 
            this.nametovarDataGridViewTextBoxColumn1.DataPropertyName = "Name_tovar";
            this.nametovarDataGridViewTextBoxColumn1.HeaderText = "Name_tovar";
            this.nametovarDataGridViewTextBoxColumn1.Name = "nametovarDataGridViewTextBoxColumn1";
            // 
            // stoimosttovarDataGridViewTextBoxColumn
            // 
            this.stoimosttovarDataGridViewTextBoxColumn.DataPropertyName = "Stoimost_tovar";
            this.stoimosttovarDataGridViewTextBoxColumn.HeaderText = "Stoimost_tovar";
            this.stoimosttovarDataGridViewTextBoxColumn.Name = "stoimosttovarDataGridViewTextBoxColumn";
            // 
            // kolvovnalichDataGridViewTextBoxColumn
            // 
            this.kolvovnalichDataGridViewTextBoxColumn.DataPropertyName = "Kolvo_v_nalich";
            this.kolvovnalichDataGridViewTextBoxColumn.HeaderText = "Kolvo_v_nalich";
            this.kolvovnalichDataGridViewTextBoxColumn.Name = "kolvovnalichDataGridViewTextBoxColumn";
            // 
            // assortimentBindingSource
            // 
            this.assortimentBindingSource.DataMember = "Assortiment";
            this.assortimentBindingSource.DataSource = this.bazaDataSet1;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.dataGridView4);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(781, 207);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Курьеры";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // dataGridView4
            // 
            this.dataGridView4.AutoGenerateColumns = false;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDkyrierDataGridViewTextBoxColumn,
            this.namekyrierDataGridViewTextBoxColumn});
            this.dataGridView4.DataSource = this.kyrierBindingSource;
            this.dataGridView4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView4.Location = new System.Drawing.Point(3, 3);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.ReadOnly = true;
            this.dataGridView4.Size = new System.Drawing.Size(775, 201);
            this.dataGridView4.TabIndex = 0;
            // 
            // iDkyrierDataGridViewTextBoxColumn
            // 
            this.iDkyrierDataGridViewTextBoxColumn.DataPropertyName = "ID_kyrier";
            this.iDkyrierDataGridViewTextBoxColumn.HeaderText = "ID_kyrier";
            this.iDkyrierDataGridViewTextBoxColumn.Name = "iDkyrierDataGridViewTextBoxColumn";
            this.iDkyrierDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // namekyrierDataGridViewTextBoxColumn
            // 
            this.namekyrierDataGridViewTextBoxColumn.DataPropertyName = "Name_kyrier";
            this.namekyrierDataGridViewTextBoxColumn.HeaderText = "Name_kyrier";
            this.namekyrierDataGridViewTextBoxColumn.Name = "namekyrierDataGridViewTextBoxColumn";
            this.namekyrierDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kyrierBindingSource
            // 
            this.kyrierBindingSource.DataMember = "Kyrier";
            this.kyrierBindingSource.DataSource = this.bazaDataSet1;
            // 
            // tovarzakazBindingSource
            // 
            this.tovarzakazBindingSource.DataMember = "Tovar_zakaz";
            this.tovarzakazBindingSource.DataSource = this.bazaDataSet1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem,
            this.удалитьToolStripMenuItem,
            this.изменитьToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(814, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.заказToolStripMenuItem});
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.добавитьToolStripMenuItem.Text = "Добавить";
            // 
            // заказToolStripMenuItem
            // 
            this.заказToolStripMenuItem.Name = "заказToolStripMenuItem";
            this.заказToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.заказToolStripMenuItem.Text = "Заказ";
            this.заказToolStripMenuItem.Click += new System.EventHandler(this.заказToolStripMenuItem_Click);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.заказToolStripMenuItem1});
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            // 
            // заказToolStripMenuItem1
            // 
            this.заказToolStripMenuItem1.Name = "заказToolStripMenuItem1";
            this.заказToolStripMenuItem1.Size = new System.Drawing.Size(104, 22);
            this.заказToolStripMenuItem1.Text = "Заказ";
            this.заказToolStripMenuItem1.Click += new System.EventHandler(this.заказToolStripMenuItem1_Click);
            // 
            // изменитьToolStripMenuItem
            // 
            this.изменитьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.курьеровToolStripMenuItem});
            this.изменитьToolStripMenuItem.Name = "изменитьToolStripMenuItem";
            this.изменитьToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.изменитьToolStripMenuItem.Text = "Изменить";
            // 
            // курьеровToolStripMenuItem
            // 
            this.курьеровToolStripMenuItem.Name = "курьеровToolStripMenuItem";
            this.курьеровToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.курьеровToolStripMenuItem.Text = "курьеров";
            this.курьеровToolStripMenuItem.Click += new System.EventHandler(this.курьераToolStripMenuItem_Click);
            // 
            // klientTableAdapter
            // 
            this.klientTableAdapter.ClearBeforeFill = true;
            // 
            // zakazTableAdapter
            // 
            this.zakazTableAdapter.ClearBeforeFill = true;
            // 
            // tovar_zakazTableAdapter
            // 
            this.tovar_zakazTableAdapter.ClearBeforeFill = true;
            // 
            // kyrierTableAdapter
            // 
            this.kyrierTableAdapter.ClearBeforeFill = true;
            // 
            // assortimentTableAdapter
            // 
            this.assortimentTableAdapter.ClearBeforeFill = true;
            // 
            // zakazTovarzakazBindingSource
            // 
            this.zakazTovarzakazBindingSource.DataMember = "Zakaz_Tovar_zakaz";
            this.zakazTovarzakazBindingSource.DataSource = this.zakazBindingSource;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 352);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zakazBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bazaDataSet)).EndInit();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.klientBindingSource)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tovarzakazBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bazaDataSet1)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assortimentBindingSource)).EndInit();
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kyrierBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tovarzakazBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zakazTovarzakazBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изменитьToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private bazaDataSet bazaDataSet;
        private System.Windows.Forms.BindingSource klientBindingSource;
        private bazaDataSetTableAdapters.KlientTableAdapter klientTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDklientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameklientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource zakazBindingSource;
        private bazaDataSetTableAdapters.ZakazTableAdapter zakazTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.BindingSource zakazTovarzakazBindingSource;
        private bazaDataSetTableAdapters.Tovar_zakazTableAdapter tovar_zakazTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDzakazDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDtovarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nametovarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolvotovarDataGridViewTextBoxColumn;
        private bazaDataSet bazaDataSet1;
        private System.Windows.Forms.BindingSource tovarzakazBindingSource;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.BindingSource kyrierBindingSource;
        private bazaDataSetTableAdapters.KyrierTableAdapter kyrierTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDkyrierDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namekyrierDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView5;
        private System.Windows.Forms.BindingSource assortimentBindingSource;
        private bazaDataSetTableAdapters.AssortimentTableAdapter assortimentTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDtovarDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nametovarDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn stoimosttovarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolvovnalichDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripMenuItem заказToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem заказToolStripMenuItem1;
        private System.Windows.Forms.BindingSource tovarzakazBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDzakazDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDklientDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn stoimostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDkurierDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripMenuItem курьеровToolStripMenuItem;
    }
}

