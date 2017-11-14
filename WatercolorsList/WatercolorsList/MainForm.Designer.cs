namespace WatercolorsList
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
            this.watercolorsDataSet = new WatercolorsList.WatercolorsDataSet();
            this.tWatercolorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tWatercolorTableAdapter = new WatercolorsList.WatercolorsDataSetTableAdapters.TWatercolorTableAdapter();
            this.tableAdapterManager = new WatercolorsList.WatercolorsDataSetTableAdapters.TableAdapterManager();
            this.tWatercolorBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.tWatercolorBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.UpdateBtn = new System.Windows.Forms.ToolStripButton();
            this.tSetsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tColorSetsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tAmountBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tSetsTableAdapter = new WatercolorsList.WatercolorsDataSetTableAdapters.TSetsTableAdapter();
            this.tColorSetsTableAdapter = new WatercolorsList.WatercolorsDataSetTableAdapters.TColorSetsTableAdapter();
            this.tAmountTableAdapter = new WatercolorsList.WatercolorsDataSetTableAdapters.TAmountTableAdapter();
            this.tWatercolorDataGridView = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Set = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Coloring = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColoringPicture = new System.Windows.Forms.DataGridViewImageColumn();
            this.MyOwnColoring = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MyOwnColoringPicture = new System.Windows.Forms.DataGridViewImageColumn();
            this.RussianName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EnglishName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pigments = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColorSet = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.LightFastness = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HidingPower = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Cuvets = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ToBuy = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Open = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Duplicates = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BestMatch = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AmountFilter = new System.Windows.Forms.ComboBox();
            this.ColorSetFilter = new System.Windows.Forms.ComboBox();
            this.SetFilter = new System.Windows.Forms.ComboBox();
            this.ShowAll = new System.Windows.Forms.Button();
            this.ToBuyAll = new System.Windows.Forms.Button();
            this.NotToBuy = new System.Windows.Forms.Button();
            this.TrueToBuy = new System.Windows.Forms.Button();
            this.HP3 = new System.Windows.Forms.Button();
            this.HP2 = new System.Windows.Forms.Button();
            this.HP1 = new System.Windows.Forms.Button();
            this.LF3 = new System.Windows.Forms.Button();
            this.LF2 = new System.Windows.Forms.Button();
            this.LF1 = new System.Windows.Forms.Button();
            this.PygmentsSearch = new System.Windows.Forms.Button();
            this.EnNameSearch = new System.Windows.Forms.Button();
            this.RusNameSearch = new System.Windows.Forms.Button();
            this.FilterBox = new System.Windows.Forms.TextBox();
            this.countLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.watercolorsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tWatercolorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tWatercolorBindingNavigator)).BeginInit();
            this.tWatercolorBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tSetsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tColorSetsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAmountBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tWatercolorDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // watercolorsDataSet
            // 
            this.watercolorsDataSet.DataSetName = "WatercolorsDataSet";
            this.watercolorsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tWatercolorBindingSource
            // 
            this.tWatercolorBindingSource.DataMember = "TWatercolor";
            this.tWatercolorBindingSource.DataSource = this.watercolorsDataSet;
            this.tWatercolorBindingSource.ListChanged += new System.ComponentModel.ListChangedEventHandler(this.tWatercolorBindingSource_ListChanged);
            // 
            // tWatercolorTableAdapter
            // 
            this.tWatercolorTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.TAmountTableAdapter = null;
            this.tableAdapterManager.TColorSetsTableAdapter = null;
            this.tableAdapterManager.TSetsTableAdapter = null;
            this.tableAdapterManager.TWatercolorTableAdapter = this.tWatercolorTableAdapter;
            this.tableAdapterManager.UpdateOrder = WatercolorsList.WatercolorsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tWatercolorBindingNavigator
            // 
            this.tWatercolorBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tWatercolorBindingNavigator.BindingSource = this.tWatercolorBindingSource;
            this.tWatercolorBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tWatercolorBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tWatercolorBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.tWatercolorBindingNavigatorSaveItem,
            this.UpdateBtn});
            this.tWatercolorBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tWatercolorBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tWatercolorBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tWatercolorBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tWatercolorBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tWatercolorBindingNavigator.Name = "tWatercolorBindingNavigator";
            this.tWatercolorBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tWatercolorBindingNavigator.Size = new System.Drawing.Size(1481, 27);
            this.tWatercolorBindingNavigator.TabIndex = 0;
            this.tWatercolorBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = global::WatercolorsList.Properties.Resources.add2;
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
            this.bindingNavigatorDeleteItem.Image = global::WatercolorsList.Properties.Resources.close1;
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 24);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = global::WatercolorsList.Properties.Resources.first;
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = global::WatercolorsList.Properties.Resources.left1;
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
            this.bindingNavigatorMoveNextItem.Image = global::WatercolorsList.Properties.Resources.right1;
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 24);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = global::WatercolorsList.Properties.Resources.last;
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
            // tWatercolorBindingNavigatorSaveItem
            // 
            this.tWatercolorBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tWatercolorBindingNavigatorSaveItem.Image = global::WatercolorsList.Properties.Resources.diskette1;
            this.tWatercolorBindingNavigatorSaveItem.Name = "tWatercolorBindingNavigatorSaveItem";
            this.tWatercolorBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 24);
            this.tWatercolorBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.tWatercolorBindingNavigatorSaveItem.Click += new System.EventHandler(this.tWatercolorBindingNavigatorSaveItem_Click);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.UpdateBtn.Image = global::WatercolorsList.Properties.Resources.rel;
            this.UpdateBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(23, 24);
            this.UpdateBtn.Text = "toolStripButton1";
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // tSetsBindingSource
            // 
            this.tSetsBindingSource.DataMember = "TSets";
            this.tSetsBindingSource.DataSource = this.watercolorsDataSet;
            // 
            // tColorSetsBindingSource
            // 
            this.tColorSetsBindingSource.DataMember = "TColorSets";
            this.tColorSetsBindingSource.DataSource = this.watercolorsDataSet;
            // 
            // tAmountBindingSource
            // 
            this.tAmountBindingSource.DataMember = "TAmount";
            this.tAmountBindingSource.DataSource = this.watercolorsDataSet;
            // 
            // tSetsTableAdapter
            // 
            this.tSetsTableAdapter.ClearBeforeFill = true;
            // 
            // tColorSetsTableAdapter
            // 
            this.tColorSetsTableAdapter.ClearBeforeFill = true;
            // 
            // tAmountTableAdapter
            // 
            this.tAmountTableAdapter.ClearBeforeFill = true;
            // 
            // tWatercolorDataGridView
            // 
            this.tWatercolorDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tWatercolorDataGridView.AutoGenerateColumns = false;
            this.tWatercolorDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tWatercolorDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Set,
            this.Coloring,
            this.ColoringPicture,
            this.MyOwnColoring,
            this.MyOwnColoringPicture,
            this.RussianName,
            this.EnglishName,
            this.Pigments,
            this.ColorSet,
            this.LightFastness,
            this.HidingPower,
            this.Amount,
            this.Cuvets,
            this.ToBuy,
            this.Open});
            this.tWatercolorDataGridView.DataSource = this.tWatercolorBindingSource;
            this.tWatercolorDataGridView.Location = new System.Drawing.Point(12, 30);
            this.tWatercolorDataGridView.Name = "tWatercolorDataGridView";
            this.tWatercolorDataGridView.RowTemplate.Height = 24;
            this.tWatercolorDataGridView.Size = new System.Drawing.Size(1214, 593);
            this.tWatercolorDataGridView.TabIndex = 33;
            this.tWatercolorDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tWatercolorDataGridView_CellContentClick);
            this.tWatercolorDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.tWatercolorDataGridView_DataError);
            // 
            // id
            // 
            this.id.DataPropertyName = "Id";
            this.id.HeaderText = "№";
            this.id.Name = "id";
            this.id.Width = 30;
            // 
            // Set
            // 
            this.Set.DataPropertyName = "Set";
            this.Set.DataSource = this.tSetsBindingSource;
            this.Set.DisplayMember = "Title";
            this.Set.HeaderText = "Набор";
            this.Set.Name = "Set";
            this.Set.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Set.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Set.ValueMember = "Id";
            this.Set.Width = 120;
            // 
            // Coloring
            // 
            this.Coloring.DataPropertyName = "Coloring";
            this.Coloring.HeaderText = "Coloring";
            this.Coloring.Name = "Coloring";
            this.Coloring.Width = 5;
            // 
            // ColoringPicture
            // 
            this.ColoringPicture.HeaderText = "Выкраска";
            this.ColoringPicture.Name = "ColoringPicture";
            this.ColoringPicture.Width = 70;
            // 
            // MyOwnColoring
            // 
            this.MyOwnColoring.DataPropertyName = "MyOwnColoring";
            this.MyOwnColoring.HeaderText = "MyOwnColoring";
            this.MyOwnColoring.Name = "MyOwnColoring";
            this.MyOwnColoring.Width = 5;
            // 
            // MyOwnColoringPicture
            // 
            this.MyOwnColoringPicture.HeaderText = "Моя выкраска";
            this.MyOwnColoringPicture.Name = "MyOwnColoringPicture";
            this.MyOwnColoringPicture.Width = 70;
            // 
            // RussianName
            // 
            this.RussianName.DataPropertyName = "Russian name";
            this.RussianName.HeaderText = "Русское название";
            this.RussianName.Name = "RussianName";
            this.RussianName.Width = 120;
            // 
            // EnglishName
            // 
            this.EnglishName.DataPropertyName = "English name";
            this.EnglishName.HeaderText = "Английское название";
            this.EnglishName.Name = "EnglishName";
            this.EnglishName.Width = 120;
            // 
            // Pigments
            // 
            this.Pigments.DataPropertyName = "Pigments";
            this.Pigments.HeaderText = "Пигменты";
            this.Pigments.Name = "Pigments";
            // 
            // ColorSet
            // 
            this.ColorSet.DataPropertyName = "ColorSet";
            this.ColorSet.DataSource = this.tColorSetsBindingSource;
            this.ColorSet.DisplayMember = "Title_ru";
            this.ColorSet.HeaderText = "Цвет";
            this.ColorSet.Name = "ColorSet";
            this.ColorSet.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColorSet.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ColorSet.ValueMember = "Id";
            this.ColorSet.Width = 120;
            // 
            // LightFastness
            // 
            this.LightFastness.DataPropertyName = "Light-fastness";
            this.LightFastness.HeaderText = "Свет.";
            this.LightFastness.Name = "LightFastness";
            this.LightFastness.Width = 50;
            // 
            // HidingPower
            // 
            this.HidingPower.DataPropertyName = "Hiding power";
            this.HidingPower.HeaderText = "Укрыв.";
            this.HidingPower.Name = "HidingPower";
            this.HidingPower.Width = 50;
            // 
            // Amount
            // 
            this.Amount.DataPropertyName = "Amount";
            this.Amount.DataSource = this.tAmountBindingSource;
            this.Amount.DisplayMember = "Title_ru";
            this.Amount.HeaderText = "Количество";
            this.Amount.Name = "Amount";
            this.Amount.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Amount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Amount.ValueMember = "Id";
            // 
            // Cuvets
            // 
            this.Cuvets.DataPropertyName = "Cuvets";
            this.Cuvets.HeaderText = "Кюв.";
            this.Cuvets.Name = "Cuvets";
            this.Cuvets.Width = 40;
            // 
            // ToBuy
            // 
            this.ToBuy.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ToBuy.DataPropertyName = "ToBuy";
            this.ToBuy.HeaderText = "Куп.";
            this.ToBuy.Name = "ToBuy";
            this.ToBuy.Width = 40;
            // 
            // Open
            // 
            this.Open.HeaderText = "Открыть цвет";
            this.Open.Name = "Open";
            this.Open.Text = "Открыть";
            this.Open.UseColumnTextForButtonValue = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.countLabel);
            this.panel1.Controls.Add(this.Duplicates);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.BestMatch);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.AmountFilter);
            this.panel1.Controls.Add(this.ColorSetFilter);
            this.panel1.Controls.Add(this.SetFilter);
            this.panel1.Controls.Add(this.ShowAll);
            this.panel1.Controls.Add(this.ToBuyAll);
            this.panel1.Controls.Add(this.NotToBuy);
            this.panel1.Controls.Add(this.TrueToBuy);
            this.panel1.Controls.Add(this.HP3);
            this.panel1.Controls.Add(this.HP2);
            this.panel1.Controls.Add(this.HP1);
            this.panel1.Controls.Add(this.LF3);
            this.panel1.Controls.Add(this.LF2);
            this.panel1.Controls.Add(this.LF1);
            this.panel1.Controls.Add(this.PygmentsSearch);
            this.panel1.Controls.Add(this.EnNameSearch);
            this.panel1.Controls.Add(this.RusNameSearch);
            this.panel1.Controls.Add(this.FilterBox);
            this.panel1.Location = new System.Drawing.Point(1233, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(236, 592);
            this.panel1.TabIndex = 34;
            // 
            // Duplicates
            // 
            this.Duplicates.AutoSize = true;
            this.Duplicates.Location = new System.Drawing.Point(60, 508);
            this.Duplicates.Name = "Duplicates";
            this.Duplicates.Size = new System.Drawing.Size(134, 27);
            this.Duplicates.TabIndex = 35;
            this.Duplicates.Text = "Найти дубликаты";
            this.Duplicates.UseVisualStyleBackColor = true;
            this.Duplicates.Click += new System.EventHandler(this.Duplicates_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(78, 450);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 17);
            this.label8.TabIndex = 25;
            this.label8.Text = "Надо купить?";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 17);
            this.label7.TabIndex = 24;
            this.label7.Text = "Поиск по названию";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(44, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 18);
            this.label6.TabIndex = 23;
            this.label6.Text = "Поиск и фильтры";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(78, 345);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 17);
            this.label5.TabIndex = 22;
            this.label5.Text = "Укрывистость:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 294);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 17);
            this.label4.TabIndex = 21;
            this.label4.Text = "Светостойкость:";
            // 
            // BestMatch
            // 
            this.BestMatch.AutoSize = true;
            this.BestMatch.Location = new System.Drawing.Point(63, 408);
            this.BestMatch.Name = "BestMatch";
            this.BestMatch.Size = new System.Drawing.Size(134, 27);
            this.BestMatch.TabIndex = 20;
            this.BestMatch.Text = "Лучший вариант";
            this.BestMatch.UseVisualStyleBackColor = true;
            this.BestMatch.Click += new System.EventHandler(this.BestMatch_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "Кол-во";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "Цвет";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "Серия";
            // 
            // AmountFilter
            // 
            this.AmountFilter.DataSource = this.tAmountBindingSource;
            this.AmountFilter.DisplayMember = "Title_ru";
            this.AmountFilter.FormattingEnabled = true;
            this.AmountFilter.Location = new System.Drawing.Point(66, 236);
            this.AmountFilter.Name = "AmountFilter";
            this.AmountFilter.Size = new System.Drawing.Size(167, 24);
            this.AmountFilter.TabIndex = 16;
            this.AmountFilter.ValueMember = "Id";
            this.AmountFilter.SelectedValueChanged += new System.EventHandler(this.AmountFilter_SelectedValueChanged);
            // 
            // ColorSetFilter
            // 
            this.ColorSetFilter.DataSource = this.tColorSetsBindingSource;
            this.ColorSetFilter.DisplayMember = "Title_ru";
            this.ColorSetFilter.FormattingEnabled = true;
            this.ColorSetFilter.Location = new System.Drawing.Point(66, 206);
            this.ColorSetFilter.Name = "ColorSetFilter";
            this.ColorSetFilter.Size = new System.Drawing.Size(168, 24);
            this.ColorSetFilter.TabIndex = 15;
            this.ColorSetFilter.ValueMember = "Id";
            this.ColorSetFilter.SelectedValueChanged += new System.EventHandler(this.ColorSetFilter_SelectedValueChanged);
            // 
            // SetFilter
            // 
            this.SetFilter.DataSource = this.tSetsBindingSource;
            this.SetFilter.DisplayMember = "Title";
            this.SetFilter.FormattingEnabled = true;
            this.SetFilter.Location = new System.Drawing.Point(66, 176);
            this.SetFilter.Name = "SetFilter";
            this.SetFilter.Size = new System.Drawing.Size(167, 24);
            this.SetFilter.TabIndex = 14;
            this.SetFilter.ValueMember = "Id";
            this.SetFilter.SelectedValueChanged += new System.EventHandler(this.SetFilter_SelectedValueChanged);
            // 
            // ShowAll
            // 
            this.ShowAll.Location = new System.Drawing.Point(60, 550);
            this.ShowAll.Name = "ShowAll";
            this.ShowAll.Size = new System.Drawing.Size(122, 34);
            this.ShowAll.TabIndex = 13;
            this.ShowAll.Text = "Показать всё";
            this.ShowAll.UseVisualStyleBackColor = true;
            this.ShowAll.Click += new System.EventHandler(this.ShowAll_Click);
            // 
            // ToBuyAll
            // 
            this.ToBuyAll.Location = new System.Drawing.Point(166, 470);
            this.ToBuyAll.Name = "ToBuyAll";
            this.ToBuyAll.Size = new System.Drawing.Size(55, 23);
            this.ToBuyAll.TabIndex = 12;
            this.ToBuyAll.Text = "Все";
            this.ToBuyAll.UseVisualStyleBackColor = true;
            this.ToBuyAll.Click += new System.EventHandler(this.ToBuyAll_Click);
            // 
            // NotToBuy
            // 
            this.NotToBuy.Location = new System.Drawing.Point(98, 470);
            this.NotToBuy.Name = "NotToBuy";
            this.NotToBuy.Size = new System.Drawing.Size(55, 23);
            this.NotToBuy.TabIndex = 11;
            this.NotToBuy.Text = "Нет";
            this.NotToBuy.UseVisualStyleBackColor = true;
            this.NotToBuy.Click += new System.EventHandler(this.NotToBuy_Click);
            // 
            // TrueToBuy
            // 
            this.TrueToBuy.Location = new System.Drawing.Point(29, 470);
            this.TrueToBuy.Name = "TrueToBuy";
            this.TrueToBuy.Size = new System.Drawing.Size(55, 23);
            this.TrueToBuy.TabIndex = 10;
            this.TrueToBuy.Text = "Да";
            this.TrueToBuy.UseVisualStyleBackColor = true;
            this.TrueToBuy.Click += new System.EventHandler(this.TrueToBuy_Click);
            // 
            // HP3
            // 
            this.HP3.BackgroundImage = global::WatercolorsList.Properties.Resources.hp3;
            this.HP3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.HP3.FlatAppearance.BorderSize = 0;
            this.HP3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HP3.Location = new System.Drawing.Point(150, 365);
            this.HP3.Name = "HP3";
            this.HP3.Size = new System.Drawing.Size(32, 27);
            this.HP3.TabIndex = 9;
            this.HP3.UseVisualStyleBackColor = true;
            this.HP3.Click += new System.EventHandler(this.HP3_Click);
            // 
            // HP2
            // 
            this.HP2.BackgroundImage = global::WatercolorsList.Properties.Resources.hp2;
            this.HP2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.HP2.FlatAppearance.BorderSize = 0;
            this.HP2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HP2.Location = new System.Drawing.Point(112, 365);
            this.HP2.Name = "HP2";
            this.HP2.Size = new System.Drawing.Size(32, 27);
            this.HP2.TabIndex = 8;
            this.HP2.UseVisualStyleBackColor = true;
            this.HP2.Click += new System.EventHandler(this.HP2_Click);
            // 
            // HP1
            // 
            this.HP1.BackgroundImage = global::WatercolorsList.Properties.Resources.hp1;
            this.HP1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.HP1.FlatAppearance.BorderSize = 0;
            this.HP1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HP1.Location = new System.Drawing.Point(74, 365);
            this.HP1.Name = "HP1";
            this.HP1.Size = new System.Drawing.Size(32, 27);
            this.HP1.TabIndex = 7;
            this.HP1.UseVisualStyleBackColor = true;
            this.HP1.Click += new System.EventHandler(this.HP1_Click);
            // 
            // LF3
            // 
            this.LF3.BackgroundImage = global::WatercolorsList.Properties.Resources.star3;
            this.LF3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.LF3.FlatAppearance.BorderSize = 0;
            this.LF3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LF3.Location = new System.Drawing.Point(129, 314);
            this.LF3.Name = "LF3";
            this.LF3.Size = new System.Drawing.Size(75, 23);
            this.LF3.TabIndex = 6;
            this.LF3.UseVisualStyleBackColor = true;
            this.LF3.Click += new System.EventHandler(this.LF3_Click);
            // 
            // LF2
            // 
            this.LF2.BackgroundImage = global::WatercolorsList.Properties.Resources.star21;
            this.LF2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.LF2.FlatAppearance.BorderSize = 0;
            this.LF2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LF2.Location = new System.Drawing.Point(73, 314);
            this.LF2.Name = "LF2";
            this.LF2.Size = new System.Drawing.Size(50, 23);
            this.LF2.TabIndex = 5;
            this.LF2.UseVisualStyleBackColor = true;
            this.LF2.Click += new System.EventHandler(this.LF2_Click);
            // 
            // LF1
            // 
            this.LF1.BackgroundImage = global::WatercolorsList.Properties.Resources.star11;
            this.LF1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.LF1.FlatAppearance.BorderSize = 0;
            this.LF1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LF1.Location = new System.Drawing.Point(44, 314);
            this.LF1.Name = "LF1";
            this.LF1.Size = new System.Drawing.Size(23, 23);
            this.LF1.TabIndex = 4;
            this.LF1.UseVisualStyleBackColor = true;
            this.LF1.Click += new System.EventHandler(this.LF1_Click);
            // 
            // PygmentsSearch
            // 
            this.PygmentsSearch.AutoSize = true;
            this.PygmentsSearch.Image = global::WatercolorsList.Properties.Resources.zoom;
            this.PygmentsSearch.Location = new System.Drawing.Point(65, 127);
            this.PygmentsSearch.Name = "PygmentsSearch";
            this.PygmentsSearch.Size = new System.Drawing.Size(89, 27);
            this.PygmentsSearch.TabIndex = 3;
            this.PygmentsSearch.Text = "пигмент";
            this.PygmentsSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.PygmentsSearch.UseVisualStyleBackColor = true;
            this.PygmentsSearch.Click += new System.EventHandler(this.PygmentsSearch_Click);
            // 
            // EnNameSearch
            // 
            this.EnNameSearch.AutoSize = true;
            this.EnNameSearch.Image = global::WatercolorsList.Properties.Resources.zoom;
            this.EnNameSearch.Location = new System.Drawing.Point(114, 94);
            this.EnNameSearch.Name = "EnNameSearch";
            this.EnNameSearch.Size = new System.Drawing.Size(107, 27);
            this.EnNameSearch.TabIndex = 2;
            this.EnNameSearch.Text = "англ. назв.";
            this.EnNameSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.EnNameSearch.UseVisualStyleBackColor = true;
            this.EnNameSearch.Click += new System.EventHandler(this.EnNameSearch_Click);
            // 
            // RusNameSearch
            // 
            this.RusNameSearch.AutoSize = true;
            this.RusNameSearch.Image = global::WatercolorsList.Properties.Resources.zoom;
            this.RusNameSearch.Location = new System.Drawing.Point(11, 94);
            this.RusNameSearch.Name = "RusNameSearch";
            this.RusNameSearch.Size = new System.Drawing.Size(100, 27);
            this.RusNameSearch.TabIndex = 1;
            this.RusNameSearch.Text = "рус. назв.";
            this.RusNameSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.RusNameSearch.UseVisualStyleBackColor = true;
            this.RusNameSearch.Click += new System.EventHandler(this.RusNameSearch_Click);
            // 
            // FilterBox
            // 
            this.FilterBox.Location = new System.Drawing.Point(21, 66);
            this.FilterBox.Name = "FilterBox";
            this.FilterBox.Size = new System.Drawing.Size(189, 22);
            this.FilterBox.TabIndex = 0;
            // 
            // countLabel
            // 
            this.countLabel.AutoSize = true;
            this.countLabel.Location = new System.Drawing.Point(184, 450);
            this.countLabel.Name = "countLabel";
            this.countLabel.Size = new System.Drawing.Size(26, 17);
            this.countLabel.TabIndex = 36;
            this.countLabel.Text = "шт";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1481, 635);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tWatercolorDataGridView);
            this.Controls.Add(this.tWatercolorBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Список красок";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.watercolorsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tWatercolorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tWatercolorBindingNavigator)).EndInit();
            this.tWatercolorBindingNavigator.ResumeLayout(false);
            this.tWatercolorBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tSetsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tColorSetsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAmountBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tWatercolorDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private WatercolorsDataSet watercolorsDataSet;
        private System.Windows.Forms.BindingSource tWatercolorBindingSource;
        private WatercolorsDataSetTableAdapters.TWatercolorTableAdapter tWatercolorTableAdapter;
        private WatercolorsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tWatercolorBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton tWatercolorBindingNavigatorSaveItem;
        private System.Windows.Forms.BindingSource tSetsBindingSource;
        private WatercolorsDataSetTableAdapters.TSetsTableAdapter tSetsTableAdapter;
        private System.Windows.Forms.BindingSource tColorSetsBindingSource;
        private WatercolorsDataSetTableAdapters.TColorSetsTableAdapter tColorSetsTableAdapter;
        private System.Windows.Forms.BindingSource tAmountBindingSource;
        private WatercolorsDataSetTableAdapters.TAmountTableAdapter tAmountTableAdapter;
        private System.Windows.Forms.DataGridView tWatercolorDataGridView;
        private System.Windows.Forms.ToolStripButton UpdateBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button TrueToBuy;
        private System.Windows.Forms.Button HP3;
        private System.Windows.Forms.Button HP2;
        private System.Windows.Forms.Button HP1;
        private System.Windows.Forms.Button LF3;
        private System.Windows.Forms.Button LF2;
        private System.Windows.Forms.Button LF1;
        private System.Windows.Forms.Button PygmentsSearch;
        private System.Windows.Forms.Button EnNameSearch;
        private System.Windows.Forms.Button RusNameSearch;
        private System.Windows.Forms.TextBox FilterBox;
        private System.Windows.Forms.ComboBox ColorSetFilter;
        private System.Windows.Forms.ComboBox SetFilter;
        private System.Windows.Forms.Button ShowAll;
        private System.Windows.Forms.Button ToBuyAll;
        private System.Windows.Forms.Button NotToBuy;
        private System.Windows.Forms.ComboBox AmountFilter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BestMatch;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewComboBoxColumn Set;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coloring;
        private System.Windows.Forms.DataGridViewImageColumn ColoringPicture;
        private System.Windows.Forms.DataGridViewTextBoxColumn MyOwnColoring;
        private System.Windows.Forms.DataGridViewImageColumn MyOwnColoringPicture;
        private System.Windows.Forms.DataGridViewTextBoxColumn RussianName;
        private System.Windows.Forms.DataGridViewTextBoxColumn EnglishName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pigments;
        private System.Windows.Forms.DataGridViewComboBoxColumn ColorSet;
        private System.Windows.Forms.DataGridViewTextBoxColumn LightFastness;
        private System.Windows.Forms.DataGridViewTextBoxColumn HidingPower;
        private System.Windows.Forms.DataGridViewComboBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cuvets;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ToBuy;
        private System.Windows.Forms.DataGridViewButtonColumn Open;
        private System.Windows.Forms.Button Duplicates;
        private System.Windows.Forms.Label countLabel;
    }
}

