namespace Bookshelf
{
    partial class AddBook
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label titleLabel;
            System.Windows.Forms.Label authorLabel;
            System.Windows.Forms.Label categoryLabel;
            System.Windows.Forms.Label seriesLabel;
            System.Windows.Forms.Label seriesNumberLabel;
            System.Windows.Forms.Label tableOfContentsLabel;
            System.Windows.Forms.Label shelfLabel;
            System.Windows.Forms.Label isFavouriteLabel;
            System.Windows.Forms.Label isReadLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddBook));
            this.booksDataSet = new Bookshelf.BooksDataSet();
            this.tBooksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tBooksTableAdapter = new Bookshelf.BooksDataSetTableAdapters.TBooksTableAdapter();
            this.tableAdapterManager = new Bookshelf.BooksDataSetTableAdapters.TableAdapterManager();
            this.tCategoriesTableAdapter = new Bookshelf.BooksDataSetTableAdapters.TCategoriesTableAdapter();
            this.tSeriesTableAdapter = new Bookshelf.BooksDataSetTableAdapters.TSeriesTableAdapter();
            this.tShelfTableAdapter = new Bookshelf.BooksDataSetTableAdapters.TShelfTableAdapter();
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
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.authorTextBox = new System.Windows.Forms.TextBox();
            this.tCategoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.booksDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.seriesNumberTextBox = new System.Windows.Forms.TextBox();
            this.tableOfContentsTextBox = new System.Windows.Forms.TextBox();
            this.isReadCheckBox = new System.Windows.Forms.CheckBox();
            this.isFavouriteCheckBox = new System.Windows.Forms.CheckBox();
            this.shelfTextBox = new System.Windows.Forms.TextBox();
            this.categoryTextBox = new System.Windows.Forms.TextBox();
            this.catComboBox = new System.Windows.Forms.ComboBox();
            this.shComboBox = new System.Windows.Forms.ComboBox();
            this.tShelfBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.seriesComboBox = new System.Windows.Forms.ComboBox();
            this.tSeriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.SaveButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            idLabel = new System.Windows.Forms.Label();
            titleLabel = new System.Windows.Forms.Label();
            authorLabel = new System.Windows.Forms.Label();
            categoryLabel = new System.Windows.Forms.Label();
            seriesLabel = new System.Windows.Forms.Label();
            seriesNumberLabel = new System.Windows.Forms.Label();
            tableOfContentsLabel = new System.Windows.Forms.Label();
            shelfLabel = new System.Windows.Forms.Label();
            isFavouriteLabel = new System.Windows.Forms.Label();
            isReadLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.booksDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBooksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBooksBindingNavigator)).BeginInit();
            this.tBooksBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tCategoriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tShelfBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tSeriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(26, 45);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(26, 17);
            idLabel.TabIndex = 1;
            idLabel.Text = "№:";
            idLabel.Visible = false;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Location = new System.Drawing.Point(26, 73);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new System.Drawing.Size(76, 17);
            titleLabel.TabIndex = 3;
            titleLabel.Text = "Название:";
            // 
            // authorLabel
            // 
            authorLabel.AutoSize = true;
            authorLabel.Location = new System.Drawing.Point(26, 101);
            authorLabel.Name = "authorLabel";
            authorLabel.Size = new System.Drawing.Size(51, 17);
            authorLabel.TabIndex = 5;
            authorLabel.Text = "Автор:";
            // 
            // categoryLabel
            // 
            categoryLabel.AutoSize = true;
            categoryLabel.Location = new System.Drawing.Point(26, 129);
            categoryLabel.Name = "categoryLabel";
            categoryLabel.Size = new System.Drawing.Size(81, 17);
            categoryLabel.TabIndex = 7;
            categoryLabel.Text = "Категория:";
            // 
            // seriesLabel
            // 
            seriesLabel.AutoSize = true;
            seriesLabel.Location = new System.Drawing.Point(26, 160);
            seriesLabel.Name = "seriesLabel";
            seriesLabel.Size = new System.Drawing.Size(53, 17);
            seriesLabel.TabIndex = 9;
            seriesLabel.Text = "Серия:";
            // 
            // seriesNumberLabel
            // 
            seriesNumberLabel.AutoSize = true;
            seriesNumberLabel.Location = new System.Drawing.Point(323, 160);
            seriesNumberLabel.Name = "seriesNumberLabel";
            seriesNumberLabel.Size = new System.Drawing.Size(26, 17);
            seriesNumberLabel.TabIndex = 11;
            seriesNumberLabel.Text = "№:";
            // 
            // tableOfContentsLabel
            // 
            tableOfContentsLabel.AutoSize = true;
            tableOfContentsLabel.Location = new System.Drawing.Point(26, 230);
            tableOfContentsLabel.Name = "tableOfContentsLabel";
            tableOfContentsLabel.Size = new System.Drawing.Size(94, 17);
            tableOfContentsLabel.TabIndex = 13;
            tableOfContentsLabel.Text = "Содержание:";
            // 
            // shelfLabel
            // 
            shelfLabel.AutoSize = true;
            shelfLabel.Location = new System.Drawing.Point(26, 190);
            shelfLabel.Name = "shelfLabel";
            shelfLabel.Size = new System.Drawing.Size(53, 17);
            shelfLabel.TabIndex = 19;
            shelfLabel.Text = "Полка:";
            // 
            // isFavouriteLabel
            // 
            isFavouriteLabel.AutoSize = true;
            isFavouriteLabel.Location = new System.Drawing.Point(298, 293);
            isFavouriteLabel.Name = "isFavouriteLabel";
            isFavouriteLabel.Size = new System.Drawing.Size(85, 17);
            isFavouriteLabel.TabIndex = 17;
            isFavouriteLabel.Text = "Избранное:";
            // 
            // isReadLabel
            // 
            isReadLabel.AutoSize = true;
            isReadLabel.Location = new System.Drawing.Point(298, 228);
            isReadLabel.Name = "isReadLabel";
            isReadLabel.Size = new System.Drawing.Size(93, 17);
            isReadLabel.TabIndex = 15;
            isReadLabel.Text = "Прочитанна:";
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
            this.tableAdapterManager.TSeriesTableAdapter = this.tSeriesTableAdapter;
            this.tableAdapterManager.TShelfTableAdapter = this.tShelfTableAdapter;
            this.tableAdapterManager.UpdateOrder = Bookshelf.BooksDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tCategoriesTableAdapter
            // 
            this.tCategoriesTableAdapter.ClearBeforeFill = true;
            // 
            // tSeriesTableAdapter
            // 
            this.tSeriesTableAdapter.ClearBeforeFill = true;
            // 
            // tShelfTableAdapter
            // 
            this.tShelfTableAdapter.ClearBeforeFill = true;
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
            this.tBooksBindingNavigatorSaveItem});
            this.tBooksBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tBooksBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tBooksBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tBooksBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tBooksBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tBooksBindingNavigator.Name = "tBooksBindingNavigator";
            this.tBooksBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tBooksBindingNavigator.Size = new System.Drawing.Size(425, 27);
            this.tBooksBindingNavigator.TabIndex = 0;
            this.tBooksBindingNavigator.Text = "bindingNavigator1";
            this.tBooksBindingNavigator.Visible = false;
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
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
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
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
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
            this.tBooksBindingNavigatorSaveItem.Click += new System.EventHandler(this.tBooksBindingNavigatorSaveItem_Click);
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tBooksBindingSource, "id", true));
            this.idTextBox.Location = new System.Drawing.Point(74, 42);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(32, 22);
            this.idTextBox.TabIndex = 2;
            this.idTextBox.Visible = false;
            // 
            // titleTextBox
            // 
            this.titleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tBooksBindingSource, "Title", true));
            this.titleTextBox.Location = new System.Drawing.Point(117, 70);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(275, 22);
            this.titleTextBox.TabIndex = 4;
            // 
            // authorTextBox
            // 
            this.authorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tBooksBindingSource, "Author", true));
            this.authorTextBox.Location = new System.Drawing.Point(117, 98);
            this.authorTextBox.Name = "authorTextBox";
            this.authorTextBox.Size = new System.Drawing.Size(275, 22);
            this.authorTextBox.TabIndex = 6;
            // 
            // tCategoriesBindingSource
            // 
            this.tCategoriesBindingSource.DataMember = "TCategories";
            this.tCategoriesBindingSource.DataSource = this.booksDataSetBindingSource;
            // 
            // booksDataSetBindingSource
            // 
            this.booksDataSetBindingSource.DataSource = this.booksDataSet;
            this.booksDataSetBindingSource.Position = 0;
            // 
            // seriesNumberTextBox
            // 
            this.seriesNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tBooksBindingSource, "SeriesNumber", true));
            this.seriesNumberTextBox.Location = new System.Drawing.Point(355, 157);
            this.seriesNumberTextBox.Name = "seriesNumberTextBox";
            this.seriesNumberTextBox.Size = new System.Drawing.Size(37, 22);
            this.seriesNumberTextBox.TabIndex = 12;
            // 
            // tableOfContentsTextBox
            // 
            this.tableOfContentsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tBooksBindingSource, "TableOfContents", true));
            this.tableOfContentsTextBox.Location = new System.Drawing.Point(29, 259);
            this.tableOfContentsTextBox.Multiline = true;
            this.tableOfContentsTextBox.Name = "tableOfContentsTextBox";
            this.tableOfContentsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tableOfContentsTextBox.Size = new System.Drawing.Size(249, 235);
            this.tableOfContentsTextBox.TabIndex = 16;
            // 
            // isReadCheckBox
            // 
            this.isReadCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.isReadCheckBox.BackgroundImage = global::Bookshelf.Properties.Resources.cross_red;
            this.isReadCheckBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.isReadCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.tBooksBindingSource, "IsRead", true));
            this.isReadCheckBox.FlatAppearance.BorderSize = 0;
            this.isReadCheckBox.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.isReadCheckBox.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.isReadCheckBox.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.isReadCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.isReadCheckBox.Location = new System.Drawing.Point(317, 245);
            this.isReadCheckBox.Name = "isReadCheckBox";
            this.isReadCheckBox.Size = new System.Drawing.Size(43, 43);
            this.isReadCheckBox.TabIndex = 18;
            this.isReadCheckBox.UseVisualStyleBackColor = true;
            this.isReadCheckBox.CheckedChanged += new System.EventHandler(this.isReadCheckBox_CheckedChanged);
            // 
            // isFavouriteCheckBox
            // 
            this.isFavouriteCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.isFavouriteCheckBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.isFavouriteCheckBox.BackgroundImage = global::Bookshelf.Properties.Resources.starN2;
            this.isFavouriteCheckBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.isFavouriteCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.isFavouriteCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.tBooksBindingSource, "IsFavourite", true));
            this.isFavouriteCheckBox.FlatAppearance.BorderSize = 0;
            this.isFavouriteCheckBox.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.isFavouriteCheckBox.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.isFavouriteCheckBox.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.isFavouriteCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.isFavouriteCheckBox.ForeColor = System.Drawing.Color.Transparent;
            this.isFavouriteCheckBox.Location = new System.Drawing.Point(317, 313);
            this.isFavouriteCheckBox.Name = "isFavouriteCheckBox";
            this.isFavouriteCheckBox.Size = new System.Drawing.Size(43, 43);
            this.isFavouriteCheckBox.TabIndex = 20;
            this.isFavouriteCheckBox.UseVisualStyleBackColor = false;
            this.isFavouriteCheckBox.CheckedChanged += new System.EventHandler(this.isFavouriteCheckBox_CheckedChanged);
            // 
            // shelfTextBox
            // 
            this.shelfTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tBooksBindingSource, "Shelf", true));
            this.shelfTextBox.Location = new System.Drawing.Point(117, 187);
            this.shelfTextBox.Name = "shelfTextBox";
            this.shelfTextBox.Size = new System.Drawing.Size(121, 22);
            this.shelfTextBox.TabIndex = 20;
            this.shelfTextBox.TabStop = false;
            this.shelfTextBox.TextChanged += new System.EventHandler(this.shelfTextBox_TextChanged);
            // 
            // categoryTextBox
            // 
            this.categoryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tBooksBindingSource, "Category", true));
            this.categoryTextBox.Location = new System.Drawing.Point(117, 126);
            this.categoryTextBox.Name = "categoryTextBox";
            this.categoryTextBox.Size = new System.Drawing.Size(121, 22);
            this.categoryTextBox.TabIndex = 22;
            this.categoryTextBox.TabStop = false;
            this.categoryTextBox.TextChanged += new System.EventHandler(this.categoryTextBox_TextChanged);
            // 
            // catComboBox
            // 
            this.catComboBox.DataSource = this.tCategoriesBindingSource;
            this.catComboBox.DisplayMember = "Category";
            this.catComboBox.FormattingEnabled = true;
            this.catComboBox.Location = new System.Drawing.Point(117, 126);
            this.catComboBox.Name = "catComboBox";
            this.catComboBox.Size = new System.Drawing.Size(193, 24);
            this.catComboBox.TabIndex = 8;
            this.catComboBox.ValueMember = "Id";
            this.catComboBox.SelectedValueChanged += new System.EventHandler(this.catComboBox_SelectedValueChanged);
            // 
            // shComboBox
            // 
            this.shComboBox.DataSource = this.tShelfBindingSource;
            this.shComboBox.DisplayMember = "Place";
            this.shComboBox.FormattingEnabled = true;
            this.shComboBox.Location = new System.Drawing.Point(117, 187);
            this.shComboBox.Name = "shComboBox";
            this.shComboBox.Size = new System.Drawing.Size(275, 24);
            this.shComboBox.TabIndex = 14;
            this.shComboBox.ValueMember = "Id";
            this.shComboBox.SelectedIndexChanged += new System.EventHandler(this.shComboBox_SelectedIndexChanged);
            // 
            // tShelfBindingSource
            // 
            this.tShelfBindingSource.DataMember = "TShelf";
            this.tShelfBindingSource.DataSource = this.booksDataSetBindingSource;
            // 
            // seriesComboBox
            // 
            this.seriesComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tBooksBindingSource, "Series", true));
            this.seriesComboBox.DataSource = this.tSeriesBindingSource;
            this.seriesComboBox.DisplayMember = "Series";
            this.seriesComboBox.FormattingEnabled = true;
            this.seriesComboBox.Location = new System.Drawing.Point(117, 157);
            this.seriesComboBox.Name = "seriesComboBox";
            this.seriesComboBox.Size = new System.Drawing.Size(193, 24);
            this.seriesComboBox.TabIndex = 10;
            // 
            // tSeriesBindingSource
            // 
            this.tSeriesBindingSource.DataMember = "TSeries";
            this.tSeriesBindingSource.DataSource = this.booksDataSet;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(132, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 17);
            this.label1.TabIndex = 24;
            this.label1.Text = "Добавление книги";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackgroundImage = global::Bookshelf.Properties.Resources.booklet;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(343, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(62, 62);
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // AddButton
            // 
            this.AddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddButton.ImageIndex = 2;
            this.AddButton.ImageList = this.imageList1;
            this.AddButton.Location = new System.Drawing.Point(293, 379);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(112, 34);
            this.AddButton.TabIndex = 25;
            this.AddButton.Text = "Добавить";
            this.AddButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            this.AddButton.Leave += new System.EventHandler(this.FocusLeave);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "compose.png");
            this.imageList1.Images.SetKeyName(1, "minus.png");
            this.imageList1.Images.SetKeyName(2, "plus.png");
            // 
            // SaveButton
            // 
            this.SaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SaveButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SaveButton.ImageIndex = 0;
            this.SaveButton.ImageList = this.imageList1;
            this.SaveButton.Location = new System.Drawing.Point(293, 419);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(112, 34);
            this.SaveButton.TabIndex = 26;
            this.SaveButton.Text = "Сохранить";
            this.SaveButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            this.SaveButton.Leave += new System.EventHandler(this.FocusLeave);
            // 
            // ClearButton
            // 
            this.ClearButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ClearButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ClearButton.ImageIndex = 1;
            this.ClearButton.ImageList = this.imageList1;
            this.ClearButton.Location = new System.Drawing.Point(293, 459);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(112, 34);
            this.ClearButton.TabIndex = 27;
            this.ClearButton.Text = "Очистить";
            this.ClearButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.ClearButton, "Все введённые данные данные будут потеряны.");
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 5000;
            this.toolTip1.InitialDelay = 1;
            this.toolTip1.ReshowDelay = 0;
            // 
            // AddBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(425, 505);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.seriesComboBox);
            this.Controls.Add(this.shComboBox);
            this.Controls.Add(this.catComboBox);
            this.Controls.Add(this.categoryTextBox);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(titleLabel);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(authorLabel);
            this.Controls.Add(this.authorTextBox);
            this.Controls.Add(categoryLabel);
            this.Controls.Add(seriesLabel);
            this.Controls.Add(seriesNumberLabel);
            this.Controls.Add(this.seriesNumberTextBox);
            this.Controls.Add(tableOfContentsLabel);
            this.Controls.Add(this.tableOfContentsTextBox);
            this.Controls.Add(isReadLabel);
            this.Controls.Add(this.isReadCheckBox);
            this.Controls.Add(isFavouriteLabel);
            this.Controls.Add(this.isFavouriteCheckBox);
            this.Controls.Add(shelfLabel);
            this.Controls.Add(this.shelfTextBox);
            this.Controls.Add(this.tBooksBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddBook";
            this.RightToLeftLayout = true;
            this.Text = "AddBooks";
            this.Load += new System.EventHandler(this.AddBooks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.booksDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBooksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBooksBindingNavigator)).EndInit();
            this.tBooksBindingNavigator.ResumeLayout(false);
            this.tBooksBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tCategoriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tShelfBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tSeriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.TextBox authorTextBox;
        private System.Windows.Forms.TextBox seriesNumberTextBox;
        private System.Windows.Forms.TextBox tableOfContentsTextBox;
        private System.Windows.Forms.CheckBox isReadCheckBox;
        private System.Windows.Forms.CheckBox isFavouriteCheckBox;
        private System.Windows.Forms.TextBox shelfTextBox;
        private BooksDataSetTableAdapters.TCategoriesTableAdapter tCategoriesTableAdapter;
        private System.Windows.Forms.BindingSource booksDataSetBindingSource;
        private System.Windows.Forms.BindingSource tCategoriesBindingSource;
        private System.Windows.Forms.TextBox categoryTextBox;
        private System.Windows.Forms.ComboBox catComboBox;
        private System.Windows.Forms.ComboBox shComboBox;
        private System.Windows.Forms.BindingSource tShelfBindingSource;
        private BooksDataSetTableAdapters.TShelfTableAdapter tShelfTableAdapter;
        private System.Windows.Forms.ComboBox seriesComboBox;
        private System.Windows.Forms.BindingSource tSeriesBindingSource;
        private BooksDataSetTableAdapters.TSeriesTableAdapter tSeriesTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}