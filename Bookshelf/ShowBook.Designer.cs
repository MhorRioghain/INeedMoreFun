namespace Bookshelf
{
    partial class ShowBook
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
            System.Windows.Forms.Label titleLabel;
            System.Windows.Forms.Label authorLabel;
            System.Windows.Forms.Label categoryLabel;
            System.Windows.Forms.Label seriesLabel;
            System.Windows.Forms.Label seriesNumberLabel;
            System.Windows.Forms.Label tableOfContentsLabel;
            System.Windows.Forms.Label isReadLabel;
            System.Windows.Forms.Label isFavouriteLabel;
            System.Windows.Forms.Label shelfLabel1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowBook));
            this.booksDataSet = new Bookshelf.BooksDataSet();
            this.tBooksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tBooksTableAdapter = new Bookshelf.BooksDataSetTableAdapters.TBooksTableAdapter();
            this.tableAdapterManager = new Bookshelf.BooksDataSetTableAdapters.TableAdapterManager();
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
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.authorTextBox = new System.Windows.Forms.TextBox();
            this.seriesNumberTextBox = new System.Windows.Forms.TextBox();
            this.tableOfContentsTextBox = new System.Windows.Forms.TextBox();
            this.isReadCheckBox = new System.Windows.Forms.CheckBox();
            this.isFavouriteCheckBox = new System.Windows.Forms.CheckBox();
            this.tShelfBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoryTextBox = new System.Windows.Forms.TextBox();
            this.shelfTextBox = new System.Windows.Forms.TextBox();
            this.CategoryComboBox = new System.Windows.Forms.ComboBox();
            this.tCategoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ShelfComboBox = new System.Windows.Forms.ComboBox();
            this.tCategoriesTableAdapter = new Bookshelf.BooksDataSetTableAdapters.TCategoriesTableAdapter();
            this.SaveButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.categoryComboBox1 = new System.Windows.Forms.ComboBox();
            this.tSeriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tSeriesTableAdapter = new Bookshelf.BooksDataSetTableAdapters.TSeriesTableAdapter();
            titleLabel = new System.Windows.Forms.Label();
            authorLabel = new System.Windows.Forms.Label();
            categoryLabel = new System.Windows.Forms.Label();
            seriesLabel = new System.Windows.Forms.Label();
            seriesNumberLabel = new System.Windows.Forms.Label();
            tableOfContentsLabel = new System.Windows.Forms.Label();
            isReadLabel = new System.Windows.Forms.Label();
            isFavouriteLabel = new System.Windows.Forms.Label();
            shelfLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.booksDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBooksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBooksBindingNavigator)).BeginInit();
            this.tBooksBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tShelfBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tCategoriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tSeriesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Location = new System.Drawing.Point(12, 46);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new System.Drawing.Size(76, 17);
            titleLabel.TabIndex = 3;
            titleLabel.Text = "Название:";
            // 
            // authorLabel
            // 
            authorLabel.AutoSize = true;
            authorLabel.Location = new System.Drawing.Point(389, 46);
            authorLabel.Name = "authorLabel";
            authorLabel.Size = new System.Drawing.Size(51, 17);
            authorLabel.TabIndex = 5;
            authorLabel.Text = "Автор:";
            // 
            // categoryLabel
            // 
            categoryLabel.AutoSize = true;
            categoryLabel.Location = new System.Drawing.Point(12, 122);
            categoryLabel.Name = "categoryLabel";
            categoryLabel.Size = new System.Drawing.Size(81, 17);
            categoryLabel.TabIndex = 7;
            categoryLabel.Text = "Категория:";
            // 
            // seriesLabel
            // 
            seriesLabel.AutoSize = true;
            seriesLabel.Location = new System.Drawing.Point(12, 85);
            seriesLabel.Name = "seriesLabel";
            seriesLabel.Size = new System.Drawing.Size(53, 17);
            seriesLabel.TabIndex = 9;
            seriesLabel.Text = "Серия:";
            // 
            // seriesNumberLabel
            // 
            seriesNumberLabel.AutoSize = true;
            seriesNumberLabel.Location = new System.Drawing.Point(317, 85);
            seriesNumberLabel.Name = "seriesNumberLabel";
            seriesNumberLabel.Size = new System.Drawing.Size(26, 17);
            seriesNumberLabel.TabIndex = 11;
            seriesNumberLabel.Text = "№:";
            // 
            // tableOfContentsLabel
            // 
            tableOfContentsLabel.AutoSize = true;
            tableOfContentsLabel.Location = new System.Drawing.Point(127, 180);
            tableOfContentsLabel.Name = "tableOfContentsLabel";
            tableOfContentsLabel.Size = new System.Drawing.Size(94, 17);
            tableOfContentsLabel.TabIndex = 13;
            tableOfContentsLabel.Text = "Содержание:";
            // 
            // isReadLabel
            // 
            isReadLabel.AutoSize = true;
            isReadLabel.Location = new System.Drawing.Point(410, 178);
            isReadLabel.Name = "isReadLabel";
            isReadLabel.Size = new System.Drawing.Size(85, 17);
            isReadLabel.TabIndex = 15;
            isReadLabel.Text = "Прочитана:";
            // 
            // isFavouriteLabel
            // 
            isFavouriteLabel.AutoSize = true;
            isFavouriteLabel.Location = new System.Drawing.Point(410, 235);
            isFavouriteLabel.Name = "isFavouriteLabel";
            isFavouriteLabel.Size = new System.Drawing.Size(85, 17);
            isFavouriteLabel.TabIndex = 17;
            isFavouriteLabel.Text = "Избранное:";
            // 
            // shelfLabel1
            // 
            shelfLabel1.AutoSize = true;
            shelfLabel1.Location = new System.Drawing.Point(317, 122);
            shelfLabel1.Name = "shelfLabel1";
            shelfLabel1.Size = new System.Drawing.Size(53, 17);
            shelfLabel1.TabIndex = 24;
            shelfLabel1.Text = "Полка:";
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
            this.tableAdapterManager.TCategoriesTableAdapter = null;
            this.tableAdapterManager.TSeriesTableAdapter = null;
            this.tableAdapterManager.TShelfTableAdapter = this.tShelfTableAdapter;
            this.tableAdapterManager.UpdateOrder = Bookshelf.BooksDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
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
            this.tBooksBindingNavigator.Size = new System.Drawing.Size(656, 27);
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
            // titleTextBox
            // 
            this.titleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tBooksBindingSource, "Title", true));
            this.titleTextBox.Location = new System.Drawing.Point(98, 43);
            this.titleTextBox.Multiline = true;
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(257, 24);
            this.titleTextBox.TabIndex = 4;
            // 
            // authorTextBox
            // 
            this.authorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tBooksBindingSource, "Author", true));
            this.authorTextBox.Location = new System.Drawing.Point(447, 43);
            this.authorTextBox.Multiline = true;
            this.authorTextBox.Name = "authorTextBox";
            this.authorTextBox.Size = new System.Drawing.Size(183, 24);
            this.authorTextBox.TabIndex = 6;
            // 
            // seriesNumberTextBox
            // 
            this.seriesNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tBooksBindingSource, "SeriesNumber", true));
            this.seriesNumberTextBox.Location = new System.Drawing.Point(349, 82);
            this.seriesNumberTextBox.Name = "seriesNumberTextBox";
            this.seriesNumberTextBox.Size = new System.Drawing.Size(52, 22);
            this.seriesNumberTextBox.TabIndex = 12;
            // 
            // tableOfContentsTextBox
            // 
            this.tableOfContentsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tBooksBindingSource, "TableOfContents", true));
            this.tableOfContentsTextBox.Location = new System.Drawing.Point(21, 200);
            this.tableOfContentsTextBox.Multiline = true;
            this.tableOfContentsTextBox.Name = "tableOfContentsTextBox";
            this.tableOfContentsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tableOfContentsTextBox.Size = new System.Drawing.Size(332, 132);
            this.tableOfContentsTextBox.TabIndex = 18;
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
            this.isReadCheckBox.Location = new System.Drawing.Point(502, 165);
            this.isReadCheckBox.Name = "isReadCheckBox";
            this.isReadCheckBox.Size = new System.Drawing.Size(52, 43);
            this.isReadCheckBox.TabIndex = 20;
            this.isReadCheckBox.UseVisualStyleBackColor = true;
            this.isReadCheckBox.CheckedChanged += new System.EventHandler(this.isReadCheckBox_CheckedChanged);
            // 
            // isFavouriteCheckBox
            // 
            this.isFavouriteCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.isFavouriteCheckBox.BackgroundImage = global::Bookshelf.Properties.Resources.starN2;
            this.isFavouriteCheckBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.isFavouriteCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.tBooksBindingSource, "IsFavourite", true));
            this.isFavouriteCheckBox.FlatAppearance.BorderSize = 0;
            this.isFavouriteCheckBox.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.isFavouriteCheckBox.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.isFavouriteCheckBox.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.isFavouriteCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.isFavouriteCheckBox.Location = new System.Drawing.Point(502, 222);
            this.isFavouriteCheckBox.Name = "isFavouriteCheckBox";
            this.isFavouriteCheckBox.Size = new System.Drawing.Size(52, 43);
            this.isFavouriteCheckBox.TabIndex = 22;
            this.isFavouriteCheckBox.UseVisualStyleBackColor = true;
            this.isFavouriteCheckBox.CheckedChanged += new System.EventHandler(this.isFavouriteCheckBox_CheckedChanged);
            // 
            // tShelfBindingSource
            // 
            this.tShelfBindingSource.DataMember = "TShelf";
            this.tShelfBindingSource.DataSource = this.booksDataSet;
            // 
            // categoryTextBox
            // 
            this.categoryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tBooksBindingSource, "Category", true));
            this.categoryTextBox.Location = new System.Drawing.Point(109, 119);
            this.categoryTextBox.Name = "categoryTextBox";
            this.categoryTextBox.Size = new System.Drawing.Size(162, 22);
            this.categoryTextBox.TabIndex = 26;
            this.categoryTextBox.TabStop = false;
            this.categoryTextBox.TextChanged += new System.EventHandler(this.categoryTextBox_TextChanged);
            // 
            // shelfTextBox
            // 
            this.shelfTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tBooksBindingSource, "Shelf", true));
            this.shelfTextBox.Location = new System.Drawing.Point(392, 119);
            this.shelfTextBox.Name = "shelfTextBox";
            this.shelfTextBox.Size = new System.Drawing.Size(237, 22);
            this.shelfTextBox.TabIndex = 27;
            this.shelfTextBox.TabStop = false;
            this.shelfTextBox.TextChanged += new System.EventHandler(this.shelfTextBox_TextChanged);
            // 
            // CategoryComboBox
            // 
            this.CategoryComboBox.DataSource = this.tCategoriesBindingSource;
            this.CategoryComboBox.DisplayMember = "Category";
            this.CategoryComboBox.FormattingEnabled = true;
            this.CategoryComboBox.Location = new System.Drawing.Point(98, 119);
            this.CategoryComboBox.Name = "CategoryComboBox";
            this.CategoryComboBox.Size = new System.Drawing.Size(203, 24);
            this.CategoryComboBox.TabIndex = 14;
            this.CategoryComboBox.ValueMember = "Id";
            this.CategoryComboBox.SelectedValueChanged += new System.EventHandler(this.CategoryComboBox_SelectedValueChanged);
            // 
            // tCategoriesBindingSource
            // 
            this.tCategoriesBindingSource.DataMember = "TCategories";
            this.tCategoriesBindingSource.DataSource = this.booksDataSet;
            // 
            // ShelfComboBox
            // 
            this.ShelfComboBox.DataSource = this.tShelfBindingSource;
            this.ShelfComboBox.DisplayMember = "Place";
            this.ShelfComboBox.FormattingEnabled = true;
            this.ShelfComboBox.Location = new System.Drawing.Point(392, 119);
            this.ShelfComboBox.Name = "ShelfComboBox";
            this.ShelfComboBox.Size = new System.Drawing.Size(237, 24);
            this.ShelfComboBox.TabIndex = 16;
            this.ShelfComboBox.ValueMember = "Id";
            this.ShelfComboBox.SelectedValueChanged += new System.EventHandler(this.ShelfComboBox_SelectedValueChanged);
            // 
            // tCategoriesTableAdapter
            // 
            this.tCategoriesTableAdapter.ClearBeforeFill = true;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(435, 280);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(94, 39);
            this.SaveButton.TabIndex = 30;
            this.SaveButton.Text = "Сохранить";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackgroundImage = global::Bookshelf.Properties.Resources.ribbon;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(577, 288);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(61, 62);
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(232, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 17);
            this.label1.TabIndex = 32;
            this.label1.Text = "Информация о книге";
            // 
            // categoryComboBox1
            // 
            this.categoryComboBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tBooksBindingSource, "Category", true));
            this.categoryComboBox1.DataSource = this.tSeriesBindingSource;
            this.categoryComboBox1.DisplayMember = "Series";
            this.categoryComboBox1.FormattingEnabled = true;
            this.categoryComboBox1.Location = new System.Drawing.Point(98, 82);
            this.categoryComboBox1.Name = "categoryComboBox1";
            this.categoryComboBox1.Size = new System.Drawing.Size(203, 24);
            this.categoryComboBox1.TabIndex = 10;
            // 
            // tSeriesBindingSource
            // 
            this.tSeriesBindingSource.DataMember = "TSeries";
            this.tSeriesBindingSource.DataSource = this.booksDataSet;
            // 
            // tSeriesTableAdapter
            // 
            this.tSeriesTableAdapter.ClearBeforeFill = true;
            // 
            // ShowBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 356);
            this.Controls.Add(this.categoryComboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.ShelfComboBox);
            this.Controls.Add(this.CategoryComboBox);
            this.Controls.Add(this.shelfTextBox);
            this.Controls.Add(this.categoryTextBox);
            this.Controls.Add(shelfLabel1);
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
            this.Controls.Add(this.tBooksBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ShowBook";
            this.Text = "ShowBook";
            this.Load += new System.EventHandler(this.ShowBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.booksDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBooksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBooksBindingNavigator)).EndInit();
            this.tBooksBindingNavigator.ResumeLayout(false);
            this.tBooksBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tShelfBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tCategoriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tSeriesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.TextBox authorTextBox;
        private System.Windows.Forms.TextBox seriesNumberTextBox;
        private System.Windows.Forms.TextBox tableOfContentsTextBox;
        private System.Windows.Forms.CheckBox isReadCheckBox;
        private System.Windows.Forms.CheckBox isFavouriteCheckBox;
        public BooksDataSet booksDataSet;
        public System.Windows.Forms.BindingSource tBooksBindingSource;
        private BooksDataSetTableAdapters.TBooksTableAdapter tBooksTableAdapter;
        private BooksDataSetTableAdapters.TShelfTableAdapter tShelfTableAdapter;
        private System.Windows.Forms.BindingSource tShelfBindingSource;
        private System.Windows.Forms.TextBox categoryTextBox;
        private System.Windows.Forms.TextBox shelfTextBox;
        private System.Windows.Forms.ComboBox CategoryComboBox;
        private System.Windows.Forms.ComboBox ShelfComboBox;
        private System.Windows.Forms.BindingSource tCategoriesBindingSource;
        private BooksDataSetTableAdapters.TCategoriesTableAdapter tCategoriesTableAdapter;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox categoryComboBox1;
        private System.Windows.Forms.BindingSource tSeriesBindingSource;
        private BooksDataSetTableAdapters.TSeriesTableAdapter tSeriesTableAdapter;
    }
}