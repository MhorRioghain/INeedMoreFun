namespace Bookshelf
{
    partial class Categories
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Categories));
            this.booksDataSet = new Bookshelf.BooksDataSet();
            this.tCategoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tCategoriesTableAdapter = new Bookshelf.BooksDataSetTableAdapters.TCategoriesTableAdapter();
            this.tableAdapterManager = new Bookshelf.BooksDataSetTableAdapters.TableAdapterManager();
            this.tCategoriesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.tCategoriesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.tCategoriesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.booksDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tCategoriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tCategoriesBindingNavigator)).BeginInit();
            this.tCategoriesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tCategoriesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // booksDataSet
            // 
            this.booksDataSet.DataSetName = "BooksDataSet";
            this.booksDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.TBooksTableAdapter = null;
            this.tableAdapterManager.TCategoriesTableAdapter = this.tCategoriesTableAdapter;
            this.tableAdapterManager.TSeriesTableAdapter = null;
            this.tableAdapterManager.TShelfTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Bookshelf.BooksDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tCategoriesBindingNavigator
            // 
            this.tCategoriesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tCategoriesBindingNavigator.BindingSource = this.tCategoriesBindingSource;
            this.tCategoriesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tCategoriesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tCategoriesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.tCategoriesBindingNavigatorSaveItem});
            this.tCategoriesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tCategoriesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tCategoriesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tCategoriesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tCategoriesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tCategoriesBindingNavigator.Name = "tCategoriesBindingNavigator";
            this.tCategoriesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tCategoriesBindingNavigator.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tCategoriesBindingNavigator.Size = new System.Drawing.Size(368, 27);
            this.tCategoriesBindingNavigator.TabIndex = 0;
            this.tCategoriesBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = global::Bookshelf.Properties.Resources.add2;
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
            this.bindingNavigatorDeleteItem.Image = global::Bookshelf.Properties.Resources.close;
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
            this.bindingNavigatorMovePreviousItem.Image = global::Bookshelf.Properties.Resources.left;
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
            this.bindingNavigatorMoveNextItem.Image = global::Bookshelf.Properties.Resources.right;
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
            // tCategoriesBindingNavigatorSaveItem
            // 
            this.tCategoriesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tCategoriesBindingNavigatorSaveItem.Image = global::Bookshelf.Properties.Resources.diskette;
            this.tCategoriesBindingNavigatorSaveItem.Name = "tCategoriesBindingNavigatorSaveItem";
            this.tCategoriesBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 24);
            this.tCategoriesBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.tCategoriesBindingNavigatorSaveItem.Click += new System.EventHandler(this.tCategoriesBindingNavigatorSaveItem_Click);
            // 
            // tCategoriesDataGridView
            // 
            this.tCategoriesDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tCategoriesDataGridView.AutoGenerateColumns = false;
            this.tCategoriesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tCategoriesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewId,
            this.dataGridViewCategory});
            this.tCategoriesDataGridView.DataSource = this.tCategoriesBindingSource;
            this.tCategoriesDataGridView.Location = new System.Drawing.Point(12, 68);
            this.tCategoriesDataGridView.Name = "tCategoriesDataGridView";
            this.tCategoriesDataGridView.RowTemplate.Height = 24;
            this.tCategoriesDataGridView.Size = new System.Drawing.Size(348, 320);
            this.tCategoriesDataGridView.TabIndex = 1;
            this.tCategoriesDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.tCategoriesDataGridView_DataError);
            // 
            // dataGridViewId
            // 
            this.dataGridViewId.DataPropertyName = "Id";
            this.dataGridViewId.HeaderText = "№";
            this.dataGridViewId.Name = "dataGridViewId";
            this.dataGridViewId.Width = 30;
            // 
            // dataGridViewCategory
            // 
            this.dataGridViewCategory.DataPropertyName = "Category";
            this.dataGridViewCategory.HeaderText = "Жанр или категория";
            this.dataGridViewCategory.Name = "dataGridViewCategory";
            this.dataGridViewCategory.Width = 250;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(36, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Жанры и категории литературы";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackgroundImage = global::Bookshelf.Properties.Resources.swatches;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(298, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(62, 62);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Categories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(368, 395);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tCategoriesDataGridView);
            this.Controls.Add(this.tCategoriesBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Categories";
            this.Text = "Categories";
            this.Load += new System.EventHandler(this.Categories_Load);
            ((System.ComponentModel.ISupportInitialize)(this.booksDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tCategoriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tCategoriesBindingNavigator)).EndInit();
            this.tCategoriesBindingNavigator.ResumeLayout(false);
            this.tCategoriesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tCategoriesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BooksDataSet booksDataSet;
        private System.Windows.Forms.BindingSource tCategoriesBindingSource;
        private BooksDataSetTableAdapters.TCategoriesTableAdapter tCategoriesTableAdapter;
        private BooksDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tCategoriesBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton tCategoriesBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView tCategoriesDataGridView;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewCategory;
    }
}