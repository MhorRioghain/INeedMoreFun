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
            this.Menu = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
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
            this.tBooksDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.tCategoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FavouriteUncheck = new System.Windows.Forms.Button();
            this.SeriesFltr = new System.Windows.Forms.ComboBox();
            this.CategoryFltr = new System.Windows.Forms.ComboBox();
            this.AuthorBtn = new System.Windows.Forms.Button();
            this.ShowAll = new System.Windows.Forms.Button();
            this.TitleBtn = new System.Windows.Forms.Button();
            this.FilterBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.FavouriteAll = new System.Windows.Forms.Button();
            this.FavouriteCheck = new System.Windows.Forms.Button();
            this.Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.booksDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBooksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBooksBindingNavigator)).BeginInit();
            this.tBooksBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tBooksDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tCategoriesBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(1460, 25);
            this.Menu.TabIndex = 0;
            this.Menu.Text = "toolStrip1";
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
            this.tBooksBindingNavigator.Location = new System.Drawing.Point(0, 25);
            this.tBooksBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tBooksBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tBooksBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tBooksBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tBooksBindingNavigator.Name = "tBooksBindingNavigator";
            this.tBooksBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tBooksBindingNavigator.Size = new System.Drawing.Size(1460, 27);
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
            this.tBooksBindingNavigatorSaveItem.Click += new System.EventHandler(this.tBooksBindingNavigatorSaveItem_Click_1);
            // 
            // tBooksDataGridView
            // 
            this.tBooksDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tBooksDataGridView.AutoGenerateColumns = false;
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
            this.dataGridViewTextBoxColumn8});
            this.tBooksDataGridView.DataSource = this.tBooksBindingSource;
            this.tBooksDataGridView.Location = new System.Drawing.Point(0, 55);
            this.tBooksDataGridView.Name = "tBooksDataGridView";
            this.tBooksDataGridView.RowTemplate.Height = 24;
            this.tBooksDataGridView.Size = new System.Drawing.Size(1172, 433);
            this.tBooksDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 40;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Title";
            this.dataGridViewTextBoxColumn2.HeaderText = "Title";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Author";
            this.dataGridViewTextBoxColumn3.HeaderText = "Author";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Category";
            this.dataGridViewTextBoxColumn4.DataSource = this.tCategoriesBindingSource;
            this.dataGridViewTextBoxColumn4.DisplayMember = "Category";
            this.dataGridViewTextBoxColumn4.HeaderText = "Category";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn4.ValueMember = "Id";
            this.dataGridViewTextBoxColumn4.Width = 130;
            // 
            // tCategoriesBindingSource
            // 
            this.tCategoriesBindingSource.DataMember = "TCategories";
            this.tCategoriesBindingSource.DataSource = this.booksDataSet;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Series";
            this.dataGridViewTextBoxColumn5.HeaderText = "Series";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "SeriesNumber";
            this.dataGridViewTextBoxColumn6.HeaderText = "SeriesNumber";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 50;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "TableOfContents";
            this.dataGridViewTextBoxColumn7.HeaderText = "TableOfContents";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 200;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "IsRead";
            this.dataGridViewCheckBoxColumn1.HeaderText = "IsRead";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.Width = 40;
            // 
            // dataGridViewCheckBoxColumn2
            // 
            this.dataGridViewCheckBoxColumn2.DataPropertyName = "IsFavourite";
            this.dataGridViewCheckBoxColumn2.HeaderText = "IsFavourite";
            this.dataGridViewCheckBoxColumn2.Name = "dataGridViewCheckBoxColumn2";
            this.dataGridViewCheckBoxColumn2.Width = 40;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Shelf";
            this.dataGridViewTextBoxColumn8.HeaderText = "Shelf";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 200;
            // 
            // FavouriteUncheck
            // 
            this.FavouriteUncheck.BackgroundImage = global::Bookshelf.Properties.Resources.starempty;
            this.FavouriteUncheck.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.FavouriteUncheck.FlatAppearance.BorderSize = 0;
            this.FavouriteUncheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FavouriteUncheck.Location = new System.Drawing.Point(22, 361);
            this.FavouriteUncheck.Name = "FavouriteUncheck";
            this.FavouriteUncheck.Size = new System.Drawing.Size(44, 44);
            this.FavouriteUncheck.TabIndex = 46;
            this.FavouriteUncheck.UseVisualStyleBackColor = true;
            // 
            // SeriesFltr
            // 
            this.SeriesFltr.FormattingEnabled = true;
            this.SeriesFltr.Location = new System.Drawing.Point(13, 203);
            this.SeriesFltr.Name = "SeriesFltr";
            this.SeriesFltr.Size = new System.Drawing.Size(199, 24);
            this.SeriesFltr.TabIndex = 42;
            // 
            // CategoryFltr
            // 
            this.CategoryFltr.FormattingEnabled = true;
            this.CategoryFltr.Location = new System.Drawing.Point(13, 173);
            this.CategoryFltr.Name = "CategoryFltr";
            this.CategoryFltr.Size = new System.Drawing.Size(199, 24);
            this.CategoryFltr.TabIndex = 41;
            // 
            // AuthorBtn
            // 
            this.AuthorBtn.Location = new System.Drawing.Point(111, 60);
            this.AuthorBtn.Name = "AuthorBtn";
            this.AuthorBtn.Size = new System.Drawing.Size(92, 50);
            this.AuthorBtn.TabIndex = 40;
            this.AuthorBtn.Text = "Фильтр по автору";
            this.AuthorBtn.UseVisualStyleBackColor = true;
            // 
            // ShowAll
            // 
            this.ShowAll.Location = new System.Drawing.Point(111, 126);
            this.ShowAll.Name = "ShowAll";
            this.ShowAll.Size = new System.Drawing.Size(109, 37);
            this.ShowAll.TabIndex = 39;
            this.ShowAll.Text = "Показать всё";
            this.ShowAll.UseVisualStyleBackColor = true;
            // 
            // TitleBtn
            // 
            this.TitleBtn.Location = new System.Drawing.Point(13, 60);
            this.TitleBtn.Name = "TitleBtn";
            this.TitleBtn.Size = new System.Drawing.Size(92, 50);
            this.TitleBtn.TabIndex = 38;
            this.TitleBtn.Text = "Фильтр по названию";
            this.TitleBtn.UseVisualStyleBackColor = true;
            this.TitleBtn.Click += new System.EventHandler(this.TitleBtn_Click);
            // 
            // FilterBox
            // 
            this.FilterBox.Location = new System.Drawing.Point(13, 32);
            this.FilterBox.Name = "FilterBox";
            this.FilterBox.Size = new System.Drawing.Size(190, 22);
            this.FilterBox.TabIndex = 37;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.FavouriteAll);
            this.panel1.Controls.Add(this.FavouriteCheck);
            this.panel1.Controls.Add(this.FilterBox);
            this.panel1.Controls.Add(this.ShowAll);
            this.panel1.Controls.Add(this.FavouriteUncheck);
            this.panel1.Controls.Add(this.TitleBtn);
            this.panel1.Controls.Add(this.AuthorBtn);
            this.panel1.Controls.Add(this.SeriesFltr);
            this.panel1.Controls.Add(this.CategoryFltr);
            this.panel1.Location = new System.Drawing.Point(1203, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(245, 420);
            this.panel1.TabIndex = 49;
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::Bookshelf.Properties.Resources.half;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(144, 311);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(44, 44);
            this.button3.TabIndex = 51;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::Bookshelf.Properties.Resources.green_tick;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(83, 311);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(44, 44);
            this.button2.TabIndex = 50;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Bookshelf.Properties.Resources.cross_red;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(22, 311);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(44, 44);
            this.button1.TabIndex = 49;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FavouriteAll
            // 
            this.FavouriteAll.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("FavouriteAll.BackgroundImage")));
            this.FavouriteAll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.FavouriteAll.FlatAppearance.BorderSize = 0;
            this.FavouriteAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FavouriteAll.Location = new System.Drawing.Point(144, 361);
            this.FavouriteAll.Name = "FavouriteAll";
            this.FavouriteAll.Size = new System.Drawing.Size(44, 44);
            this.FavouriteAll.TabIndex = 48;
            this.FavouriteAll.UseVisualStyleBackColor = true;
            // 
            // FavouriteCheck
            // 
            this.FavouriteCheck.BackgroundImage = global::Bookshelf.Properties.Resources.starfull;
            this.FavouriteCheck.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.FavouriteCheck.FlatAppearance.BorderSize = 0;
            this.FavouriteCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FavouriteCheck.Location = new System.Drawing.Point(83, 361);
            this.FavouriteCheck.Name = "FavouriteCheck";
            this.FavouriteCheck.Size = new System.Drawing.Size(44, 44);
            this.FavouriteCheck.TabIndex = 47;
            this.FavouriteCheck.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1460, 487);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tBooksDataGridView);
            this.Controls.Add(this.tBooksBindingNavigator);
            this.Controls.Add(this.Menu);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Activated += new System.EventHandler(this.MainForm_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.booksDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBooksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBooksBindingNavigator)).EndInit();
            this.tBooksBindingNavigator.ResumeLayout(false);
            this.tBooksBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tBooksDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tCategoriesBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip Menu;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.Button FavouriteUncheck;
        private System.Windows.Forms.ComboBox SeriesFltr;
        private System.Windows.Forms.ComboBox CategoryFltr;
        private System.Windows.Forms.Button AuthorBtn;
        private System.Windows.Forms.Button ShowAll;
        private System.Windows.Forms.Button TitleBtn;
        private System.Windows.Forms.TextBox FilterBox;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.DataGridView tBooksDataGridView;
        private System.Windows.Forms.Button FavouriteAll;
        private System.Windows.Forms.Button FavouriteCheck;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
    }
}

