namespace Bookshelf
{
    partial class AddBooks
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
            System.Windows.Forms.Label isReadLabel;
            System.Windows.Forms.Label isFavouriteLabel;
            System.Windows.Forms.Label shelfLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddBooks));
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
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.authorTextBox = new System.Windows.Forms.TextBox();
            this.tCategoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.booksDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.seriesTextBox = new System.Windows.Forms.TextBox();
            this.seriesNumberTextBox = new System.Windows.Forms.TextBox();
            this.tableOfContentsTextBox = new System.Windows.Forms.TextBox();
            this.isReadCheckBox = new System.Windows.Forms.CheckBox();
            this.isFavouriteCheckBox = new System.Windows.Forms.CheckBox();
            this.shelfTextBox = new System.Windows.Forms.TextBox();
            this.categoryTextBox = new System.Windows.Forms.TextBox();
            this.catComboBox = new System.Windows.Forms.ComboBox();
            this.shComboBox = new System.Windows.Forms.ComboBox();
            this.tShelfBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tShelfTableAdapter = new Bookshelf.BooksDataSetTableAdapters.TShelfTableAdapter();
            this.FilterBox = new System.Windows.Forms.TextBox();
            this.TitleBtn = new System.Windows.Forms.Button();
            this.ShowAll = new System.Windows.Forms.Button();
            this.AuthorBtn = new System.Windows.Forms.Button();
            this.CategoryFltr = new System.Windows.Forms.ComboBox();
            this.SeriesFltr = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            idLabel = new System.Windows.Forms.Label();
            titleLabel = new System.Windows.Forms.Label();
            authorLabel = new System.Windows.Forms.Label();
            categoryLabel = new System.Windows.Forms.Label();
            seriesLabel = new System.Windows.Forms.Label();
            seriesNumberLabel = new System.Windows.Forms.Label();
            tableOfContentsLabel = new System.Windows.Forms.Label();
            isReadLabel = new System.Windows.Forms.Label();
            isFavouriteLabel = new System.Windows.Forms.Label();
            shelfLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.booksDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBooksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBooksBindingNavigator)).BeginInit();
            this.tBooksBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tCategoriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tShelfBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(120, 73);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(23, 17);
            idLabel.TabIndex = 1;
            idLabel.Text = "id:";
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Location = new System.Drawing.Point(120, 101);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new System.Drawing.Size(39, 17);
            titleLabel.TabIndex = 3;
            titleLabel.Text = "Title:";
            // 
            // authorLabel
            // 
            authorLabel.AutoSize = true;
            authorLabel.Location = new System.Drawing.Point(120, 129);
            authorLabel.Name = "authorLabel";
            authorLabel.Size = new System.Drawing.Size(54, 17);
            authorLabel.TabIndex = 5;
            authorLabel.Text = "Author:";
            // 
            // categoryLabel
            // 
            categoryLabel.AutoSize = true;
            categoryLabel.Location = new System.Drawing.Point(120, 157);
            categoryLabel.Name = "categoryLabel";
            categoryLabel.Size = new System.Drawing.Size(69, 17);
            categoryLabel.TabIndex = 7;
            categoryLabel.Text = "Category:";
            // 
            // seriesLabel
            // 
            seriesLabel.AutoSize = true;
            seriesLabel.Location = new System.Drawing.Point(120, 188);
            seriesLabel.Name = "seriesLabel";
            seriesLabel.Size = new System.Drawing.Size(52, 17);
            seriesLabel.TabIndex = 9;
            seriesLabel.Text = "Series:";
            // 
            // seriesNumberLabel
            // 
            seriesNumberLabel.AutoSize = true;
            seriesNumberLabel.Location = new System.Drawing.Point(120, 216);
            seriesNumberLabel.Name = "seriesNumberLabel";
            seriesNumberLabel.Size = new System.Drawing.Size(106, 17);
            seriesNumberLabel.TabIndex = 11;
            seriesNumberLabel.Text = "Series Number:";
            // 
            // tableOfContentsLabel
            // 
            tableOfContentsLabel.AutoSize = true;
            tableOfContentsLabel.Location = new System.Drawing.Point(120, 244);
            tableOfContentsLabel.Name = "tableOfContentsLabel";
            tableOfContentsLabel.Size = new System.Drawing.Size(127, 17);
            tableOfContentsLabel.TabIndex = 13;
            tableOfContentsLabel.Text = "Table Of Contents:";
            // 
            // isReadLabel
            // 
            isReadLabel.AutoSize = true;
            isReadLabel.Location = new System.Drawing.Point(120, 274);
            isReadLabel.Name = "isReadLabel";
            isReadLabel.Size = new System.Drawing.Size(60, 17);
            isReadLabel.TabIndex = 15;
            isReadLabel.Text = "Is Read:";
            // 
            // isFavouriteLabel
            // 
            isFavouriteLabel.AutoSize = true;
            isFavouriteLabel.Location = new System.Drawing.Point(120, 304);
            isFavouriteLabel.Name = "isFavouriteLabel";
            isFavouriteLabel.Size = new System.Drawing.Size(85, 17);
            isFavouriteLabel.TabIndex = 17;
            isFavouriteLabel.Text = "Is Favourite:";
            // 
            // shelfLabel
            // 
            shelfLabel.AutoSize = true;
            shelfLabel.Location = new System.Drawing.Point(120, 332);
            shelfLabel.Name = "shelfLabel";
            shelfLabel.Size = new System.Drawing.Size(44, 17);
            shelfLabel.TabIndex = 19;
            shelfLabel.Text = "Shelf:";
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
            this.tBooksBindingNavigatorSaveItem});
            this.tBooksBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tBooksBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tBooksBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tBooksBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tBooksBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tBooksBindingNavigator.Name = "tBooksBindingNavigator";
            this.tBooksBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tBooksBindingNavigator.Size = new System.Drawing.Size(876, 27);
            this.tBooksBindingNavigator.TabIndex = 0;
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
            this.idTextBox.Location = new System.Drawing.Point(253, 70);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(121, 22);
            this.idTextBox.TabIndex = 2;
            // 
            // titleTextBox
            // 
            this.titleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tBooksBindingSource, "Title", true));
            this.titleTextBox.Location = new System.Drawing.Point(253, 98);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(121, 22);
            this.titleTextBox.TabIndex = 4;
            // 
            // authorTextBox
            // 
            this.authorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tBooksBindingSource, "Author", true));
            this.authorTextBox.Location = new System.Drawing.Point(253, 126);
            this.authorTextBox.Name = "authorTextBox";
            this.authorTextBox.Size = new System.Drawing.Size(121, 22);
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
            // seriesTextBox
            // 
            this.seriesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tBooksBindingSource, "Series", true));
            this.seriesTextBox.Location = new System.Drawing.Point(253, 185);
            this.seriesTextBox.Name = "seriesTextBox";
            this.seriesTextBox.Size = new System.Drawing.Size(121, 22);
            this.seriesTextBox.TabIndex = 10;
            // 
            // seriesNumberTextBox
            // 
            this.seriesNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tBooksBindingSource, "SeriesNumber", true));
            this.seriesNumberTextBox.Location = new System.Drawing.Point(253, 213);
            this.seriesNumberTextBox.Name = "seriesNumberTextBox";
            this.seriesNumberTextBox.Size = new System.Drawing.Size(121, 22);
            this.seriesNumberTextBox.TabIndex = 12;
            // 
            // tableOfContentsTextBox
            // 
            this.tableOfContentsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tBooksBindingSource, "TableOfContents", true));
            this.tableOfContentsTextBox.Location = new System.Drawing.Point(253, 241);
            this.tableOfContentsTextBox.Name = "tableOfContentsTextBox";
            this.tableOfContentsTextBox.Size = new System.Drawing.Size(121, 22);
            this.tableOfContentsTextBox.TabIndex = 14;
            // 
            // isReadCheckBox
            // 
            this.isReadCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.tBooksBindingSource, "IsRead", true));
            this.isReadCheckBox.Location = new System.Drawing.Point(253, 269);
            this.isReadCheckBox.Name = "isReadCheckBox";
            this.isReadCheckBox.Size = new System.Drawing.Size(121, 24);
            this.isReadCheckBox.TabIndex = 16;
            this.isReadCheckBox.Text = "checkBox1";
            this.isReadCheckBox.UseVisualStyleBackColor = true;
            // 
            // isFavouriteCheckBox
            // 
            this.isFavouriteCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.isFavouriteCheckBox.BackColor = System.Drawing.SystemColors.Control;
            this.isFavouriteCheckBox.BackgroundImage = global::Bookshelf.Properties.Resources.star_empty;
            this.isFavouriteCheckBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.isFavouriteCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.isFavouriteCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.tBooksBindingSource, "IsFavourite", true));
            this.isFavouriteCheckBox.FlatAppearance.BorderSize = 0;
            this.isFavouriteCheckBox.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.isFavouriteCheckBox.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.isFavouriteCheckBox.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.isFavouriteCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.isFavouriteCheckBox.ForeColor = System.Drawing.Color.Transparent;
            this.isFavouriteCheckBox.Location = new System.Drawing.Point(253, 295);
            this.isFavouriteCheckBox.Name = "isFavouriteCheckBox";
            this.isFavouriteCheckBox.Size = new System.Drawing.Size(41, 28);
            this.isFavouriteCheckBox.TabIndex = 18;
            this.isFavouriteCheckBox.UseVisualStyleBackColor = false;
            this.isFavouriteCheckBox.CheckedChanged += new System.EventHandler(this.isFavouriteCheckBox_CheckedChanged);
            // 
            // shelfTextBox
            // 
            this.shelfTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tBooksBindingSource, "Shelf", true));
            this.shelfTextBox.Location = new System.Drawing.Point(253, 329);
            this.shelfTextBox.Name = "shelfTextBox";
            this.shelfTextBox.Size = new System.Drawing.Size(121, 22);
            this.shelfTextBox.TabIndex = 20;
            this.shelfTextBox.TextChanged += new System.EventHandler(this.shelfTextBox_TextChanged);
            // 
            // categoryTextBox
            // 
            this.categoryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tBooksBindingSource, "Category", true));
            this.categoryTextBox.Location = new System.Drawing.Point(253, 154);
            this.categoryTextBox.Name = "categoryTextBox";
            this.categoryTextBox.Size = new System.Drawing.Size(121, 22);
            this.categoryTextBox.TabIndex = 22;
            this.categoryTextBox.TextChanged += new System.EventHandler(this.categoryTextBox_TextChanged);
            // 
            // catComboBox
            // 
            this.catComboBox.DataSource = this.tCategoriesBindingSource;
            this.catComboBox.DisplayMember = "Category";
            this.catComboBox.FormattingEnabled = true;
            this.catComboBox.Location = new System.Drawing.Point(253, 154);
            this.catComboBox.Name = "catComboBox";
            this.catComboBox.Size = new System.Drawing.Size(121, 24);
            this.catComboBox.TabIndex = 23;
            this.catComboBox.ValueMember = "Id";
            this.catComboBox.SelectedValueChanged += new System.EventHandler(this.catComboBox_SelectedValueChanged);
            // 
            // shComboBox
            // 
            this.shComboBox.DataSource = this.tShelfBindingSource;
            this.shComboBox.DisplayMember = "Place";
            this.shComboBox.FormattingEnabled = true;
            this.shComboBox.Location = new System.Drawing.Point(253, 329);
            this.shComboBox.Name = "shComboBox";
            this.shComboBox.Size = new System.Drawing.Size(121, 24);
            this.shComboBox.TabIndex = 24;
            this.shComboBox.ValueMember = "Id";
            this.shComboBox.SelectedIndexChanged += new System.EventHandler(this.shComboBox_SelectedIndexChanged);
            // 
            // tShelfBindingSource
            // 
            this.tShelfBindingSource.DataMember = "TShelf";
            this.tShelfBindingSource.DataSource = this.booksDataSetBindingSource;
            // 
            // tShelfTableAdapter
            // 
            this.tShelfTableAdapter.ClearBeforeFill = true;
            // 
            // FilterBox
            // 
            this.FilterBox.Location = new System.Drawing.Point(443, 69);
            this.FilterBox.Name = "FilterBox";
            this.FilterBox.Size = new System.Drawing.Size(190, 22);
            this.FilterBox.TabIndex = 25;
            // 
            // TitleBtn
            // 
            this.TitleBtn.Location = new System.Drawing.Point(443, 101);
            this.TitleBtn.Name = "TitleBtn";
            this.TitleBtn.Size = new System.Drawing.Size(92, 50);
            this.TitleBtn.TabIndex = 26;
            this.TitleBtn.Text = "Фильтр по названию";
            this.TitleBtn.UseVisualStyleBackColor = true;
            this.TitleBtn.Click += new System.EventHandler(this.TitleBtn_Click);
            // 
            // ShowAll
            // 
            this.ShowAll.Location = new System.Drawing.Point(639, 108);
            this.ShowAll.Name = "ShowAll";
            this.ShowAll.Size = new System.Drawing.Size(109, 37);
            this.ShowAll.TabIndex = 27;
            this.ShowAll.Text = "Показать всё";
            this.ShowAll.UseVisualStyleBackColor = true;
            // 
            // AuthorBtn
            // 
            this.AuthorBtn.Location = new System.Drawing.Point(541, 101);
            this.AuthorBtn.Name = "AuthorBtn";
            this.AuthorBtn.Size = new System.Drawing.Size(92, 50);
            this.AuthorBtn.TabIndex = 28;
            this.AuthorBtn.Text = "Фильтр по автору";
            this.AuthorBtn.UseVisualStyleBackColor = true;
            // 
            // CategoryFltr
            // 
            this.CategoryFltr.FormattingEnabled = true;
            this.CategoryFltr.Location = new System.Drawing.Point(443, 157);
            this.CategoryFltr.Name = "CategoryFltr";
            this.CategoryFltr.Size = new System.Drawing.Size(199, 24);
            this.CategoryFltr.TabIndex = 29;
            // 
            // SeriesFltr
            // 
            this.SeriesFltr.FormattingEnabled = true;
            this.SeriesFltr.Location = new System.Drawing.Point(443, 187);
            this.SeriesFltr.Name = "SeriesFltr";
            this.SeriesFltr.Size = new System.Drawing.Size(199, 24);
            this.SeriesFltr.TabIndex = 30;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(443, 217);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 44);
            this.button1.TabIndex = 31;
            this.button1.Text = "Фильтр по автору";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(514, 217);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(66, 44);
            this.button2.TabIndex = 32;
            this.button2.Text = "Фильтр по автору";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(586, 217);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(66, 46);
            this.button3.TabIndex = 33;
            this.button3.Text = "Фильтр по автору";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(442, 267);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(66, 44);
            this.button4.TabIndex = 34;
            this.button4.Text = "Фильтр по автору";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(514, 267);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(66, 44);
            this.button5.TabIndex = 35;
            this.button5.Text = "Фильтр по автору";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(586, 267);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(66, 44);
            this.button6.TabIndex = 36;
            this.button6.Text = "Фильтр по автору";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // AddBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 486);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SeriesFltr);
            this.Controls.Add(this.CategoryFltr);
            this.Controls.Add(this.AuthorBtn);
            this.Controls.Add(this.ShowAll);
            this.Controls.Add(this.TitleBtn);
            this.Controls.Add(this.FilterBox);
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
            this.Controls.Add(this.seriesTextBox);
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
            this.Name = "AddBooks";
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
        private System.Windows.Forms.TextBox seriesTextBox;
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
        private System.Windows.Forms.TextBox FilterBox;
        private System.Windows.Forms.Button TitleBtn;
        private System.Windows.Forms.Button ShowAll;
        private System.Windows.Forms.Button AuthorBtn;
        private System.Windows.Forms.ComboBox CategoryFltr;
        private System.Windows.Forms.ComboBox SeriesFltr;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}