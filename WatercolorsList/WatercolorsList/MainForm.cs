using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace WatercolorsList
{
    public partial class MainForm : Form
    {
        private string color_set_Filter = null;
        
        public MainForm()
        {
            InitializeComponent();
        }

        private void tWatercolorBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tWatercolorBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.watercolorsDataSet);

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            DataLoad();         
            tWatercolorDataGridView.Sort(id, ListSortDirection.Ascending);
        }

        private void DataLoad()
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "watercolorsDataSet.TAmount". При необходимости она может быть перемещена или удалена.
            this.tAmountTableAdapter.Fill(this.watercolorsDataSet.TAmount);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "watercolorsDataSet.TColorSets". При необходимости она может быть перемещена или удалена.
            this.tColorSetsTableAdapter.Fill(this.watercolorsDataSet.TColorSets);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "watercolorsDataSet.TSets". При необходимости она может быть перемещена или удалена.
            this.tSetsTableAdapter.Fill(this.watercolorsDataSet.TSets);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "watercolorsDataSet.TWatercolor". При необходимости она может быть перемещена или удалена.
            this.tWatercolorTableAdapter.Fill(this.watercolorsDataSet.TWatercolor);   
        }

        private void tWatercolorDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 15 && e.RowIndex < tWatercolorDataGridView.RowCount - 1)
            {
                ShowColor sb = new ShowColor();
                sb.tWatercolorBindingSource.Filter = "id = " + Convert.ToInt32(tWatercolorDataGridView[0, e.RowIndex].Value);
                sb.Show();
            }
        }

        private void ShowPictures()
        {
            for (int row = 0; row < tWatercolorDataGridView.Rows.Count - 1; row++)
            {
                if (tWatercolorDataGridView["Coloring", row].Value.ToString() != "")
                {
                    tWatercolorDataGridView["ColoringPicture", row].Value = Image.FromFile(tWatercolorDataGridView["Coloring", row].Value.ToString());
                }
                if (tWatercolorDataGridView["MyOwnColoring", row].Value.ToString() != "")
                { 
                    tWatercolorDataGridView["MyOwnColoringPicture", row].Value = Image.FromFile(tWatercolorDataGridView["MyOwnColoring", row].Value.ToString()); 
                }
            }
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            DataLoad();
        }

        private void SetFilter_SelectedValueChanged(object sender, EventArgs e)
        {
            if (SetFilter.Focused == true)
            {
                tWatercolorBindingSource.Filter = "Set = " + SetFilter.SelectedValue;
            }
        }

        private void ColorSetFilter_SelectedValueChanged(object sender, EventArgs e)
        {
            if (ColorSetFilter.Focused == true)
            {
                tWatercolorBindingSource.Filter = "ColorSet = " + ColorSetFilter.SelectedValue;
                color_set_Filter = tWatercolorBindingSource.Filter + " AND ";
            }
        }

        private void AmountFilter_SelectedValueChanged(object sender, EventArgs e)
        {
            if (AmountFilter.Focused == true)
            {
                tWatercolorBindingSource.Filter = "Amount = " + AmountFilter.SelectedValue;
            }
        }

        private void ShowAll_Click(object sender, EventArgs e)
        {
            tWatercolorBindingSource.RemoveFilter();
            color_set_Filter = null;
        }

        private void LF1_Click(object sender, EventArgs e)
        {
            tWatercolorBindingSource.Filter = color_set_Filter + "[Light-fastness] = 1";
        }

        private void LF2_Click(object sender, EventArgs e)
        {
            tWatercolorBindingSource.Filter = color_set_Filter + "[Light-fastness] = 2";
        }

        private void LF3_Click(object sender, EventArgs e)
        {
            tWatercolorBindingSource.Filter = color_set_Filter + "[Light-fastness] = 3";
        }

        private void tWatercolorBindingSource_ListChanged(object sender, ListChangedEventArgs e)
        {
            ShowPictures();
        }

        private void tWatercolorDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Что-то пошло не так.", "Упс!"); //что-то же падало в комбобоксах после сортировок!!!
        }

        private void RusNameSearch_Click(object sender, EventArgs e)
        {
            tWatercolorBindingSource.Filter = "[Russian name] like '%" + FilterBox.Text + "%'";
        }

        private void EnNameSearch_Click(object sender, EventArgs e)
        {
            tWatercolorBindingSource.Filter = "[English name] like '%" + FilterBox.Text + "%'";
        }

        private void PygmentsSearch_Click(object sender, EventArgs e)
        {
            tWatercolorBindingSource.Filter = "Pigments like '%" + FilterBox.Text + "%'";
        }

        private void BestMatch_Click(object sender, EventArgs e)
        {
            tWatercolorBindingSource.Filter = color_set_Filter + "[Light-fastness] = 3 AND [Hiding power] = 1";
        }

        private void HP1_Click(object sender, EventArgs e)
        {
            tWatercolorBindingSource.Filter = color_set_Filter + "[Hiding power] = 1";
        }

        private void HP2_Click(object sender, EventArgs e)
        {
            tWatercolorBindingSource.Filter = color_set_Filter + "[Hiding power] = 2";
        }

        private void HP3_Click(object sender, EventArgs e)
        {
            tWatercolorBindingSource.Filter = color_set_Filter + "[Hiding power] = 3";
        }

        private void ToBuyAll_Click(object sender, EventArgs e)
        {
            tWatercolorBindingSource.Filter = color_set_Filter + "ToBuy = true OR " + color_set_Filter + "ToBuy = false";
        }

        private void NotToBuy_Click(object sender, EventArgs e)
        {
            tWatercolorBindingSource.Filter = color_set_Filter + "ToBuy = false";
        }

        private void TrueToBuy_Click(object sender, EventArgs e)
        {
            tWatercolorBindingSource.Filter = color_set_Filter + "ToBuy = true";
        }
    }
}
