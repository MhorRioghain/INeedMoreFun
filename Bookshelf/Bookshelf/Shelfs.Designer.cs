namespace Bookshelf
{
    partial class Shelfs
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Shelfs));
            this.booksDataSet = new Bookshelf.BooksDataSet();
            this.tShelfBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tShelfTableAdapter = new Bookshelf.BooksDataSetTableAdapters.TShelfTableAdapter();
            this.tableAdapterManager = new Bookshelf.BooksDataSetTableAdapters.TableAdapterManager();
            this.tShelfBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.tShelfBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.tShelfDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCapacity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewPlace = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.booksDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tShelfBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tShelfBindingNavigator)).BeginInit();
            this.tShelfBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tShelfDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // booksDataSet
            // 
            this.booksDataSet.DataSetName = "BooksDataSet";
            this.booksDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.TBooksTableAdapter = null;
            this.tableAdapterManager.TCategoriesTableAdapter = null;
            this.tableAdapterManager.TSeriesTableAdapter = null;
            this.tableAdapterManager.TShelfTableAdapter = this.tShelfTableAdapter;
            this.tableAdapterManager.UpdateOrder = Bookshelf.BooksDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tShelfBindingNavigator
            // 
            this.tShelfBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tShelfBindingNavigator.BindingSource = this.tShelfBindingSource;
            this.tShelfBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tShelfBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tShelfBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.tShelfBindingNavigatorSaveItem});
            this.tShelfBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tShelfBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tShelfBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tShelfBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tShelfBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tShelfBindingNavigator.Name = "tShelfBindingNavigator";
            this.tShelfBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tShelfBindingNavigator.Size = new System.Drawing.Size(524, 27);
            this.tShelfBindingNavigator.TabIndex = 0;
            this.tShelfBindingNavigator.Text = "bindingNavigator1";
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
            // tShelfBindingNavigatorSaveItem
            // 
            this.tShelfBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tShelfBindingNavigatorSaveItem.Image = global::Bookshelf.Properties.Resources.diskette;
            this.tShelfBindingNavigatorSaveItem.Name = "tShelfBindingNavigatorSaveItem";
            this.tShelfBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 24);
            this.tShelfBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.tShelfBindingNavigatorSaveItem.Click += new System.EventHandler(this.tShelfBindingNavigatorSaveItem_Click);
            // 
            // tShelfDataGridView
            // 
            this.tShelfDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tShelfDataGridView.AutoGenerateColumns = false;
            this.tShelfDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.tShelfDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tShelfDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewId,
            this.dataGridViewCapacity,
            this.dataGridViewPlace});
            this.tShelfDataGridView.DataSource = this.tShelfBindingSource;
            this.tShelfDataGridView.Location = new System.Drawing.Point(12, 68);
            this.tShelfDataGridView.Name = "tShelfDataGridView";
            this.tShelfDataGridView.RowTemplate.Height = 24;
            this.tShelfDataGridView.Size = new System.Drawing.Size(500, 315);
            this.tShelfDataGridView.TabIndex = 1;
            this.tShelfDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.tShelfDataGridView_DataError);
            // 
            // dataGridViewId
            // 
            this.dataGridViewId.DataPropertyName = "Id";
            this.dataGridViewId.HeaderText = "№";
            this.dataGridViewId.Name = "dataGridViewId";
            this.dataGridViewId.Width = 30;
            // 
            // dataGridViewCapacity
            // 
            this.dataGridViewCapacity.DataPropertyName = "Capacity";
            this.dataGridViewCapacity.HeaderText = "Вместимость";
            this.dataGridViewCapacity.Name = "dataGridViewCapacity";
            // 
            // dataGridViewPlace
            // 
            this.dataGridViewPlace.DataPropertyName = "Place";
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewPlace.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewPlace.HeaderText = "Место расположения";
            this.dataGridViewPlace.Name = "dataGridViewPlace";
            this.dataGridViewPlace.Width = 300;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(173, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Книжные полки";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackgroundImage = global::Bookshelf.Properties.Resources.bookshelf;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(450, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(62, 62);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Shelfs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(524, 395);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tShelfDataGridView);
            this.Controls.Add(this.tShelfBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Shelfs";
            this.Text = "Shelfs";
            this.Load += new System.EventHandler(this.Shelfs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.booksDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tShelfBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tShelfBindingNavigator)).EndInit();
            this.tShelfBindingNavigator.ResumeLayout(false);
            this.tShelfBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tShelfDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BooksDataSet booksDataSet;
        private System.Windows.Forms.BindingSource tShelfBindingSource;
        private BooksDataSetTableAdapters.TShelfTableAdapter tShelfTableAdapter;
        private BooksDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tShelfBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton tShelfBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView tShelfDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewCapacity;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewPlace;
    }
}