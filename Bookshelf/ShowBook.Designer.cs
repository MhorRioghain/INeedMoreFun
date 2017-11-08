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
            this.seriesTextBox = new System.Windows.Forms.TextBox();
            this.seriesNumberTextBox = new System.Windows.Forms.TextBox();
            this.tableOfContentsTextBox = new System.Windows.Forms.TextBox();
            this.isReadCheckBox = new System.Windows.Forms.CheckBox();
            this.isFavouriteCheckBox = new System.Windows.Forms.CheckBox();
            this.tShelfBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoryTextBox = new System.Windows.Forms.TextBox();
            this.shelfTextBox = new System.Windows.Forms.TextBox();
            this.CategoryComboBox = new System.Windows.Forms.ComboBox();
            this.ShelfComboBox = new System.Windows.Forms.ComboBox();
            this.tCategoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tCategoriesTableAdapter = new Bookshelf.BooksDataSetTableAdapters.TCategoriesTableAdapter();
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
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Location = new System.Drawing.Point(23, 56);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new System.Drawing.Size(76, 17);
            titleLabel.TabIndex = 3;
            titleLabel.Text = "Название:";
            // 
            // authorLabel
            // 
            authorLabel.AutoSize = true;
            authorLabel.Location = new System.Drawing.Point(390, 56);
            authorLabel.Name = "authorLabel";
            authorLabel.Size = new System.Drawing.Size(51, 17);
            authorLabel.TabIndex = 5;
            authorLabel.Text = "Автор:";
            // 
            // categoryLabel
            // 
            categoryLabel.AutoSize = true;
            categoryLabel.Location = new System.Drawing.Point(23, 137);
            categoryLabel.Name = "categoryLabel";
            categoryLabel.Size = new System.Drawing.Size(69, 17);
            categoryLabel.TabIndex = 7;
            categoryLabel.Text = "Category:";
            // 
            // seriesLabel
            // 
            seriesLabel.AutoSize = true;
            seriesLabel.Location = new System.Drawing.Point(23, 97);
            seriesLabel.Name = "seriesLabel";
            seriesLabel.Size = new System.Drawing.Size(52, 17);
            seriesLabel.TabIndex = 9;
            seriesLabel.Text = "Series:";
            // 
            // seriesNumberLabel
            // 
            seriesNumberLabel.AutoSize = true;
            seriesNumberLabel.Location = new System.Drawing.Point(318, 100);
            seriesNumberLabel.Name = "seriesNumberLabel";
            seriesNumberLabel.Size = new System.Drawing.Size(26, 17);
            seriesNumberLabel.TabIndex = 11;
            seriesNumberLabel.Text = "№:";
            // 
            // tableOfContentsLabel
            // 
            tableOfContentsLabel.AutoSize = true;
            tableOfContentsLabel.Location = new System.Drawing.Point(109, 197);
            tableOfContentsLabel.Name = "tableOfContentsLabel";
            tableOfContentsLabel.Size = new System.Drawing.Size(127, 17);
            tableOfContentsLabel.TabIndex = 13;
            tableOfContentsLabel.Text = "Table Of Contents:";
            // 
            // isReadLabel
            // 
            isReadLabel.AutoSize = true;
            isReadLabel.Location = new System.Drawing.Point(440, 232);
            isReadLabel.Name = "isReadLabel";
            isReadLabel.Size = new System.Drawing.Size(60, 17);
            isReadLabel.TabIndex = 15;
            isReadLabel.Text = "Is Read:";
            // 
            // isFavouriteLabel
            // 
            isFavouriteLabel.AutoSize = true;
            isFavouriteLabel.Location = new System.Drawing.Point(430, 276);
            isFavouriteLabel.Name = "isFavouriteLabel";
            isFavouriteLabel.Size = new System.Drawing.Size(85, 17);
            isFavouriteLabel.TabIndex = 17;
            isFavouriteLabel.Text = "Is Favourite:";
            // 
            // shelfLabel1
            // 
            shelfLabel1.AutoSize = true;
            shelfLabel1.Location = new System.Drawing.Point(318, 137);
            shelfLabel1.Name = "shelfLabel1";
            shelfLabel1.Size = new System.Drawing.Size(44, 17);
            shelfLabel1.TabIndex = 24;
            shelfLabel1.Text = "Shelf:";
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
            this.titleTextBox.Location = new System.Drawing.Point(99, 53);
            this.titleTextBox.Multiline = true;
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(257, 24);
            this.titleTextBox.TabIndex = 4;
            // 
            // authorTextBox
            // 
            this.authorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tBooksBindingSource, "Author", true));
            this.authorTextBox.Location = new System.Drawing.Point(448, 53);
            this.authorTextBox.Multiline = true;
            this.authorTextBox.Name = "authorTextBox";
            this.authorTextBox.Size = new System.Drawing.Size(183, 24);
            this.authorTextBox.TabIndex = 6;
            // 
            // seriesTextBox
            // 
            this.seriesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tBooksBindingSource, "Series", true));
            this.seriesTextBox.Location = new System.Drawing.Point(99, 97);
            this.seriesTextBox.Name = "seriesTextBox";
            this.seriesTextBox.Size = new System.Drawing.Size(203, 22);
            this.seriesTextBox.TabIndex = 10;
            // 
            // seriesNumberTextBox
            // 
            this.seriesNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tBooksBindingSource, "SeriesNumber", true));
            this.seriesNumberTextBox.Location = new System.Drawing.Point(350, 97);
            this.seriesNumberTextBox.Name = "seriesNumberTextBox";
            this.seriesNumberTextBox.Size = new System.Drawing.Size(52, 22);
            this.seriesNumberTextBox.TabIndex = 12;
            // 
            // tableOfContentsTextBox
            // 
            this.tableOfContentsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tBooksBindingSource, "TableOfContents", true));
            this.tableOfContentsTextBox.Location = new System.Drawing.Point(24, 219);
            this.tableOfContentsTextBox.Multiline = true;
            this.tableOfContentsTextBox.Name = "tableOfContentsTextBox";
            this.tableOfContentsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tableOfContentsTextBox.Size = new System.Drawing.Size(332, 132);
            this.tableOfContentsTextBox.TabIndex = 14;
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
            this.isReadCheckBox.Location = new System.Drawing.Point(522, 219);
            this.isReadCheckBox.Name = "isReadCheckBox";
            this.isReadCheckBox.Size = new System.Drawing.Size(52, 43);
            this.isReadCheckBox.TabIndex = 16;
            this.isReadCheckBox.UseVisualStyleBackColor = true;
            this.isReadCheckBox.CheckedChanged += new System.EventHandler(this.isReadCheckBox_CheckedChanged);
            // 
            // isFavouriteCheckBox
            // 
            this.isFavouriteCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.isFavouriteCheckBox.BackgroundImage = global::Bookshelf.Properties.Resources.star_empty;
            this.isFavouriteCheckBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.isFavouriteCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.tBooksBindingSource, "IsFavourite", true));
            this.isFavouriteCheckBox.FlatAppearance.BorderSize = 0;
            this.isFavouriteCheckBox.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.isFavouriteCheckBox.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.isFavouriteCheckBox.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.isFavouriteCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.isFavouriteCheckBox.Location = new System.Drawing.Point(522, 276);
            this.isFavouriteCheckBox.Name = "isFavouriteCheckBox";
            this.isFavouriteCheckBox.Size = new System.Drawing.Size(52, 43);
            this.isFavouriteCheckBox.TabIndex = 18;
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
            this.categoryTextBox.Location = new System.Drawing.Point(99, 134);
            this.categoryTextBox.Name = "categoryTextBox";
            this.categoryTextBox.Size = new System.Drawing.Size(162, 22);
            this.categoryTextBox.TabIndex = 26;
            // 
            // shelfTextBox
            // 
            this.shelfTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tBooksBindingSource, "Shelf", true));
            this.shelfTextBox.Location = new System.Drawing.Point(393, 134);
            this.shelfTextBox.Name = "shelfTextBox";
            this.shelfTextBox.Size = new System.Drawing.Size(237, 22);
            this.shelfTextBox.TabIndex = 27;
            // 
            // CategoryComboBox
            // 
            this.CategoryComboBox.DataSource = this.tCategoriesBindingSource;
            this.CategoryComboBox.DisplayMember = "Category";
            this.CategoryComboBox.FormattingEnabled = true;
            this.CategoryComboBox.Location = new System.Drawing.Point(98, 134);
            this.CategoryComboBox.Name = "CategoryComboBox";
            this.CategoryComboBox.Size = new System.Drawing.Size(163, 24);
            this.CategoryComboBox.TabIndex = 28;
            this.CategoryComboBox.ValueMember = "Id";
            this.CategoryComboBox.SelectedValueChanged += new System.EventHandler(this.CategoryComboBox_SelectedValueChanged);
            // 
            // ShelfComboBox
            // 
            this.ShelfComboBox.DataSource = this.tShelfBindingSource;
            this.ShelfComboBox.DisplayMember = "Place";
            this.ShelfComboBox.FormattingEnabled = true;
            this.ShelfComboBox.Location = new System.Drawing.Point(394, 132);
            this.ShelfComboBox.Name = "ShelfComboBox";
            this.ShelfComboBox.Size = new System.Drawing.Size(237, 24);
            this.ShelfComboBox.TabIndex = 29;
            this.ShelfComboBox.ValueMember = "Id";
            this.ShelfComboBox.SelectedValueChanged += new System.EventHandler(this.ShelfComboBox_SelectedValueChanged);
            // 
            // tCategoriesBindingSource
            // 
            this.tCategoriesBindingSource.DataMember = "TCategories";
            this.tCategoriesBindingSource.DataSource = this.booksDataSet;
            // 
            // tCategoriesTableAdapter
            // 
            this.tCategoriesTableAdapter.ClearBeforeFill = true;
            // 
            // ShowBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 373);
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
            this.Controls.Add(this.seriesTextBox);
            this.Controls.Add(seriesNumberLabel);
            this.Controls.Add(this.seriesNumberTextBox);
            this.Controls.Add(tableOfContentsLabel);
            this.Controls.Add(this.tableOfContentsTextBox);
            this.Controls.Add(isReadLabel);
            this.Controls.Add(this.isReadCheckBox);
            this.Controls.Add(isFavouriteLabel);
            this.Controls.Add(this.isFavouriteCheckBox);
            this.Controls.Add(this.tBooksBindingNavigator);
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
        private System.Windows.Forms.TextBox seriesTextBox;
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
    }
}