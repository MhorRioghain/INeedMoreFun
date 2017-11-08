namespace Bookshelf
{
    partial class MainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.MainMenu = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.booksDataSet = new Bookshelf.BooksDataSet();
            this.tBooksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tBooksTableAdapter = new Bookshelf.BooksDataSetTableAdapters.TBooksTableAdapter();
            this.tableAdapterManager = new Bookshelf.BooksDataSetTableAdapters.TableAdapterManager();
            this.tCategoriesTableAdapter = new Bookshelf.BooksDataSetTableAdapters.TCategoriesTableAdapter();
            this.tBooksBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tBooksBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.UpdateTable = new System.Windows.Forms.ToolStripButton();
            this.tBooksDataGridView = new System.Windows.Forms.DataGridView();
            this.tCategoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CategoryFltr = new System.Windows.Forms.ComboBox();
            this.SeriesFltr = new System.Windows.Forms.ComboBox();
            this.tSeriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AuthorFilter = new System.Windows.Forms.Button();
            this.TitleFilter = new System.Windows.Forms.Button();
            this.FavouriteUncheck = new System.Windows.Forms.Button();
            this.ShowAll = new System.Windows.Forms.Button();
            this.FilterBox = new System.Windows.Forms.TextBox();
            this.FavouriteCheck = new System.Windows.Forms.Button();
            this.FavouriteAll = new System.Windows.Forms.Button();
            this.Read = new System.Windows.Forms.Button();
            this.Unread = new System.Windows.Forms.Button();
            this.Un_Read = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tSeriesTableAdapter = new Bookshelf.BooksDataSetTableAdapters.TSeriesTableAdapter();
            this.tShelfBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tShelfTableAdapter = new Bookshelf.BooksDataSetTableAdapters.TShelfTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.OpenBook = new System.Windows.Forms.DataGridViewButtonColumn();
            this.MainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.booksDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBooksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBooksBindingNavigator)).BeginInit();
            this.tBooksBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tBooksDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tCategoriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tSeriesBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tShelfBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripButton4});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(1507, 25);
            this.MainMenu.TabIndex = 0;
            this.MainMenu.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "toolStripButton2";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "toolStripButton3";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton4.Text = "toolStripButton4";
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // booksDataSet
            // 
            this.booksDataSet.DataSetName = "BooksDataSet";
            this.booksDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tBooksBindingSource
            // 
            this.tBooksBindingSource.DataMember = "TBooks";
            this.tBooksBindingSource.DataSource = this.booksDataSet;
            // 
            // tBooksTableAdapter
            // 
            this.tBooksTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.TBooksTableAdapter = this.tBooksTableAdapter;
            this.tableAdapterManager.TCategoriesTableAdapter = this.tCategoriesTableAdapter;
            this.tableAdapterManager.TSeriesTableAdapter = null;
            this.tableAdapterManager.TShelfTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Bookshelf.BooksDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tCategoriesTableAdapter
            // 
            this.tCategoriesTableAdapter.ClearBeforeFill = true;
            // 
            // tBooksBindingNavigator
            // 
            this.tBooksBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tBooksBindingNavigator.BindingSource = this.tBooksBindingSource;
            this.tBooksBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tBooksBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tBooksBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.tBooksBindingNavigatorSaveItem,
            this.UpdateTable});
            this.tBooksBindingNavigator.Location = new System.Drawing.Point(0, 25);
            this.tBooksBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tBooksBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tBooksBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tBooksBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tBooksBindingNavigator.Name = "tBooksBindingNavigator";
            this.tBooksBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tBooksBindingNavigator.Size = new System.Drawing.Size(1507, 27);
            this.tBooksBindingNavigator.TabIndex = 1;
            this.tBooksBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 24);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(55, 24);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 24);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = global::Bookshelf.Properties.Resources.first;
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 24);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = global::Bookshelf.Properties.Resources.last;
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 24);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // tBooksBindingNavigatorSaveItem
            // 
            this.tBooksBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tBooksBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tBooksBindingNavigatorSaveItem.Image")));
            this.tBooksBindingNavigatorSaveItem.Name = "tBooksBindingNavigatorSaveItem";
            this.tBooksBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 24);
            this.tBooksBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.tBooksBindingNavigatorSaveItem.Click += new System.EventHandler(this.tBooksBindingNavigatorSaveItem_Click_1);
            // 
            // UpdateTable
            // 
            this.UpdateTable.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.UpdateTable.Image = global::Bookshelf.Properties.Resources.rel;
            this.UpdateTable.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.UpdateTable.Name = "UpdateTable";
            this.UpdateTable.Size = new System.Drawing.Size(23, 24);
            this.UpdateTable.Text = "toolStripButton2";
            this.UpdateTable.Click += new System.EventHandler(this.UpdateTable_Click);
            // 
            // tBooksDataGridView
            // 
            this.tBooksDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tBooksDataGridView.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tBooksDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tBooksDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tBooksDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewCheckBoxColumn2,
            this.dataGridViewTextBoxColumn8,
            this.OpenBook});
            this.tBooksDataGridView.DataSource = this.tBooksBindingSource;
            this.tBooksDataGridView.Location = new System.Drawing.Point(0, 55);
            this.tBooksDataGridView.Name = "tBooksDataGridView";
            this.tBooksDataGridView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tBooksDataGridView.RowTemplate.Height = 24;
            this.tBooksDataGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.tBooksDataGridView.Size = new System.Drawing.Size(1180, 611);
            this.tBooksDataGridView.TabIndex = 2;
            this.tBooksDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tBooksDataGridView_CellContentClick);
            // 
            // tCategoriesBindingSource
            // 
            this.tCategoriesBindingSource.DataMember = "TCategories";
            this.tCategoriesBindingSource.DataSource = this.booksDataSet;
            // 
            // CategoryFltr
            // 
            this.CategoryFltr.DataSource = this.tCategoriesBindingSource;
            this.CategoryFltr.DisplayMember = "Category";
            this.CategoryFltr.FormattingEnabled = true;
            this.CategoryFltr.Location = new System.Drawing.Point(43, 170);
            this.CategoryFltr.Name = "CategoryFltr";
            this.CategoryFltr.Size = new System.Drawing.Size(199, 24);
            this.CategoryFltr.TabIndex = 41;
            this.CategoryFltr.ValueMember = "Id";
            this.CategoryFltr.SelectedIndexChanged += new System.EventHandler(this.CategoryFltr_SelectedIndexChanged);
            // 
            // SeriesFltr
            // 
            this.SeriesFltr.DataSource = this.tSeriesBindingSource;
            this.SeriesFltr.DisplayMember = "Series";
            this.SeriesFltr.FormattingEnabled = true;
            this.SeriesFltr.Location = new System.Drawing.Point(43, 232);
            this.SeriesFltr.Name = "SeriesFltr";
            this.SeriesFltr.Size = new System.Drawing.Size(198, 24);
            this.SeriesFltr.TabIndex = 42;
            this.SeriesFltr.ValueMember = "Series";
            this.SeriesFltr.SelectedIndexChanged += new System.EventHandler(this.SeriesFltr_SelectedIndexChanged);
            // 
            // tSeriesBindingSource
            // 
            this.tSeriesBindingSource.DataMember = "TSeries";
            this.tSeriesBindingSource.DataSource = this.booksDataSet;
            // 
            // AuthorFilter
            // 
            this.AuthorFilter.Image = global::Bookshelf.Properties.Resources.zoom;
            this.AuthorFilter.Location = new System.Drawing.Point(151, 100);
            this.AuthorFilter.Name = "AuthorFilter";
            this.AuthorFilter.Size = new System.Drawing.Size(125, 30);
            this.AuthorFilter.TabIndex = 40;
            this.AuthorFilter.Text = "по автору";
            this.AuthorFilter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AuthorFilter.UseVisualStyleBackColor = true;
            this.AuthorFilter.Click += new System.EventHandler(this.AuthorFilter_Click);
            // 
            // TitleFilter
            // 
            this.TitleFilter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.TitleFilter.Image = global::Bookshelf.Properties.Resources.zoom;
            this.TitleFilter.Location = new System.Drawing.Point(20, 100);
            this.TitleFilter.Name = "TitleFilter";
            this.TitleFilter.Size = new System.Drawing.Size(125, 30);
            this.TitleFilter.TabIndex = 38;
            this.TitleFilter.Text = "по названию";
            this.TitleFilter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.TitleFilter.UseVisualStyleBackColor = true;
            this.TitleFilter.Click += new System.EventHandler(this.TitleFilter_Click);
            // 
            // FavouriteUncheck
            // 
            this.FavouriteUncheck.BackgroundImage = global::Bookshelf.Properties.Resources.starempty;
            this.FavouriteUncheck.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.FavouriteUncheck.FlatAppearance.BorderSize = 0;
            this.FavouriteUncheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FavouriteUncheck.Location = new System.Drawing.Point(55, 400);
            this.FavouriteUncheck.Name = "FavouriteUncheck";
            this.FavouriteUncheck.Size = new System.Drawing.Size(44, 44);
            this.FavouriteUncheck.TabIndex = 46;
            this.FavouriteUncheck.UseVisualStyleBackColor = true;
            this.FavouriteUncheck.Click += new System.EventHandler(this.FavouriteUncheck_Click);
            // 
            // ShowAll
            // 
            this.ShowAll.Location = new System.Drawing.Point(84, 481);
            this.ShowAll.Name = "ShowAll";
            this.ShowAll.Size = new System.Drawing.Size(109, 37);
            this.ShowAll.TabIndex = 39;
            this.ShowAll.Text = "Показать всё";
            this.ShowAll.UseVisualStyleBackColor = true;
            this.ShowAll.Click += new System.EventHandler(this.ShowAll_Click);
            // 
            // FilterBox
            // 
            this.FilterBox.Location = new System.Drawing.Point(46, 72);
            this.FilterBox.Name = "FilterBox";
            this.FilterBox.Size = new System.Drawing.Size(190, 22);
            this.FilterBox.TabIndex = 37;
            // 
            // FavouriteCheck
            // 
            this.FavouriteCheck.BackgroundImage = global::Bookshelf.Properties.Resources.starfull;
            this.FavouriteCheck.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.FavouriteCheck.FlatAppearance.BorderSize = 0;
            this.FavouriteCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FavouriteCheck.Location = new System.Drawing.Point(115, 400);
            this.FavouriteCheck.Name = "FavouriteCheck";
            this.FavouriteCheck.Size = new System.Drawing.Size(44, 44);
            this.FavouriteCheck.TabIndex = 47;
            this.FavouriteCheck.UseVisualStyleBackColor = true;
            this.FavouriteCheck.Click += new System.EventHandler(this.FavouriteCheck_Click);
            // 
            // FavouriteAll
            // 
            this.FavouriteAll.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("FavouriteAll.BackgroundImage")));
            this.FavouriteAll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.FavouriteAll.FlatAppearance.BorderSize = 0;
            this.FavouriteAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FavouriteAll.Location = new System.Drawing.Point(176, 400);
            this.FavouriteAll.Name = "FavouriteAll";
            this.FavouriteAll.Size = new System.Drawing.Size(44, 44);
            this.FavouriteAll.TabIndex = 48;
            this.FavouriteAll.UseVisualStyleBackColor = true;
            this.FavouriteAll.Click += new System.EventHandler(this.FavouriteAll_Click);
            // 
            // Read
            // 
            this.Read.BackgroundImage = global::Bookshelf.Properties.Resources.green_tick;
            this.Read.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Read.FlatAppearance.BorderSize = 0;
            this.Read.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Read.Location = new System.Drawing.Point(55, 312);
            this.Read.Name = "Read";
            this.Read.Size = new System.Drawing.Size(44, 44);
            this.Read.TabIndex = 49;
            this.Read.UseVisualStyleBackColor = true;
            this.Read.Click += new System.EventHandler(this.Read_Click);
            // 
            // Unread
            // 
            this.Unread.BackgroundImage = global::Bookshelf.Properties.Resources.cross_red;
            this.Unread.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Unread.FlatAppearance.BorderSize = 0;
            this.Unread.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Unread.Location = new System.Drawing.Point(116, 312);
            this.Unread.Name = "Unread";
            this.Unread.Size = new System.Drawing.Size(44, 44);
            this.Unread.TabIndex = 50;
            this.Unread.UseVisualStyleBackColor = true;
            this.Unread.Click += new System.EventHandler(this.Unread_Click);
            // 
            // Un_Read
            // 
            this.Un_Read.BackgroundImage = global::Bookshelf.Properties.Resources.half;
            this.Un_Read.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Un_Read.FlatAppearance.BorderSize = 0;
            this.Un_Read.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Un_Read.Location = new System.Drawing.Point(177, 312);
            this.Un_Read.Name = "Un_Read";
            this.Un_Read.Size = new System.Drawing.Size(44, 44);
            this.Un_Read.TabIndex = 51;
            this.Un_Read.UseVisualStyleBackColor = true;
            this.Un_Read.Click += new System.EventHandler(this.Un_Read_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(65, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 18);
            this.label1.TabIndex = 52;
            this.label1.Text = "Поиск и фильтры";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 17);
            this.label2.TabIndex = 53;
            this.label2.Text = "Поиск по названию или автору";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 17);
            this.label3.TabIndex = 54;
            this.label3.Text = "Фильтр по категории";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 17);
            this.label4.TabIndex = 55;
            this.label4.Text = "Фильтр по серии";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(65, 283);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 17);
            this.label5.TabIndex = 56;
            this.label5.Text = "Фильтр прочитанного";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(72, 380);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 17);
            this.label6.TabIndex = 57;
            this.label6.Text = "Фильтр избранного";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Un_Read);
            this.panel1.Controls.Add(this.Unread);
            this.panel1.Controls.Add(this.Read);
            this.panel1.Controls.Add(this.FavouriteAll);
            this.panel1.Controls.Add(this.FavouriteCheck);
            this.panel1.Controls.Add(this.FilterBox);
            this.panel1.Controls.Add(this.ShowAll);
            this.panel1.Controls.Add(this.FavouriteUncheck);
            this.panel1.Controls.Add(this.TitleFilter);
            this.panel1.Controls.Add(this.AuthorFilter);
            this.panel1.Controls.Add(this.SeriesFltr);
            this.panel1.Controls.Add(this.CategoryFltr);
            this.panel1.Location = new System.Drawing.Point(1199, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(296, 601);
            this.panel1.TabIndex = 49;
            // 
            // tSeriesTableAdapter
            // 
            this.tSeriesTableAdapter.ClearBeforeFill = true;
            // 
            // tShelfBindingSource
            // 
            this.tShelfBindingSource.DataMember = "TShelf";
            this.tShelfBindingSource.DataSource = this.booksDataSet;
            // 
            // tShelfTableAdapter
            // 
            this.tShelfTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "№";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn1.Width = 30;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Title";
            this.dataGridViewTextBoxColumn2.HeaderText = "Название";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Author";
            this.dataGridViewTextBoxColumn3.HeaderText = "Автор";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 120;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Category";
            this.dataGridViewTextBoxColumn4.DataSource = this.tCategoriesBindingSource;
            this.dataGridViewTextBoxColumn4.DisplayMember = "Category";
            this.dataGridViewTextBoxColumn4.HeaderText = "Категория";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn4.ValueMember = "Id";
            this.dataGridViewTextBoxColumn4.Width = 130;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Series";
            this.dataGridViewTextBoxColumn5.HeaderText = "Серия";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn5.Width = 120;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "SeriesNumber";
            this.dataGridViewTextBoxColumn6.HeaderText = "№ в серии";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 50;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "TableOfContents";
            this.dataGridViewTextBoxColumn7.HeaderText = "Содержание";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 190;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "IsRead";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Проч.";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.Width = 50;
            // 
            // dataGridViewCheckBoxColumn2
            // 
            this.dataGridViewCheckBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewCheckBoxColumn2.DataPropertyName = "IsFavourite";
            this.dataGridViewCheckBoxColumn2.HeaderText = "Избр.";
            this.dataGridViewCheckBoxColumn2.Name = "dataGridViewCheckBoxColumn2";
            this.dataGridViewCheckBoxColumn2.Width = 49;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Shelf";
            this.dataGridViewTextBoxColumn8.DataSource = this.tShelfBindingSource;
            this.dataGridViewTextBoxColumn8.DisplayMember = "Place";
            this.dataGridViewTextBoxColumn8.HeaderText = "Полка";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn8.ValueMember = "Id";
            this.dataGridViewTextBoxColumn8.Width = 150;
            // 
            // OpenBook
            // 
            this.OpenBook.HeaderText = "Открыть книгу";
            this.OpenBook.Name = "OpenBook";
            this.OpenBook.Text = "Открыть";
            this.OpenBook.UseColumnTextForButtonValue = true;
            this.OpenBook.Width = 80;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1507, 669);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tBooksDataGridView);
            this.Controls.Add(this.tBooksBindingNavigator);
            this.Controls.Add(this.MainMenu);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.booksDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBooksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBooksBindingNavigator)).EndInit();
            this.tBooksBindingNavigator.ResumeLayout(false);
            this.tBooksBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tBooksDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tCategoriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tSeriesBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tShelfBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip MainMenu;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private BooksDataSet booksDataSet;
        private System.Windows.Forms.BindingSource tBooksBindingSource;
        private BooksDataSetTableAdapters.TBooksTableAdapter tBooksTableAdapter;
        private BooksDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tBooksBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton tBooksBindingNavigatorSaveItem;
        private BooksDataSetTableAdapters.TCategoriesTableAdapter tCategoriesTableAdapter;
        private System.Windows.Forms.BindingSource tCategoriesBindingSource;
        public System.Windows.Forms.DataGridView tBooksDataGridView;
        private System.Windows.Forms.ToolStripButton UpdateTable;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ComboBox CategoryFltr;
        private System.Windows.Forms.ComboBox SeriesFltr;
        private System.Windows.Forms.Button AuthorFilter;
        private System.Windows.Forms.Button TitleFilter;
        private System.Windows.Forms.Button FavouriteUncheck;
        private System.Windows.Forms.Button ShowAll;
        private System.Windows.Forms.TextBox FilterBox;
        private System.Windows.Forms.Button FavouriteCheck;
        private System.Windows.Forms.Button FavouriteAll;
        private System.Windows.Forms.Button Read;
        private System.Windows.Forms.Button Unread;
        private System.Windows.Forms.Button Un_Read;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingSource tSeriesBindingSource;
        private BooksDataSetTableAdapters.TSeriesTableAdapter tSeriesTableAdapter;
        private System.Windows.Forms.BindingSource tShelfBindingSource;
        private BooksDataSetTableAdapters.TShelfTableAdapter tShelfTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn2;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewButtonColumn OpenBook;
    }
}

