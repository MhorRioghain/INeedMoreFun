using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WatercolorsList
{
    public partial class ShowColor : Form
    {
        public ShowColor()
        {
            InitializeComponent();
        }

        private void tWatercolorBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tWatercolorBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.watercolorsDataSet);

        }

        private void ShowColor_Load(object sender, EventArgs e)
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

        private void coloringTextBox_TextChanged(object sender, EventArgs e)
        {
            ColoringPictureBox.Image = Image.FromFile(coloringTextBox.Text);
        }

        private void myOwnColoringTextBox_TextChanged(object sender, EventArgs e)
        {
            MyOwnColoringPictureBox.Image = Image.FromFile(myOwnColoringTextBox.Text);
        }
        private void lightfastness_CheckStateChanged(object sender, EventArgs e)
        {
            switch (lightfastness.CheckState)
            {
                case CheckState.Checked:
                    light_fastnessTextBox.Text = "3";
                    lightfastness.BackgroundImage = global::WatercolorsList.Properties.Resources.star3;
                    break;
                case CheckState.Indeterminate:
                    light_fastnessTextBox.Text = "2";
                    lightfastness.BackgroundImage = global::WatercolorsList.Properties.Resources.star2;
                    break;
                case CheckState.Unchecked:
                    light_fastnessTextBox.Text = "1";
                    lightfastness.BackgroundImage = global::WatercolorsList.Properties.Resources.star1;
                    break;
                default:
                    break;
            }
        }

        private void hidingpower_CheckStateChanged(object sender, EventArgs e)
        {
            switch (hidingpower.CheckState)
            {
                case CheckState.Checked:
                    hiding_powerTextBox.Text = "3";
                    hidingpower.BackgroundImage = global::WatercolorsList.Properties.Resources.hp3;
                    break;
                case CheckState.Indeterminate:
                    hiding_powerTextBox.Text = "2";
                    hidingpower.BackgroundImage = global::WatercolorsList.Properties.Resources.hp2;
                    break;
                case CheckState.Unchecked:
                    hiding_powerTextBox.Text = "1";
                    hidingpower.BackgroundImage = global::WatercolorsList.Properties.Resources.hp1;
                    break;
                default:
                    break;
            }
        }
        private void light_fastnessTextBox_TextChanged(object sender, EventArgs e)
        {
            switch (light_fastnessTextBox.Text)
            {
                case "1":
                    lightfastness.CheckState = CheckState.Unchecked;
                    break;
                case "2":
                    lightfastness.CheckState = CheckState.Indeterminate;
                    break;
                case "3":
                    lightfastness.CheckState = CheckState.Checked;
                    break;
                default:
                    break;
            }
        }

        private void hiding_powerTextBox_TextChanged(object sender, EventArgs e)
        {
            switch (hiding_powerTextBox.Text)
            {
                case "1":
                    hidingpower.CheckState = CheckState.Unchecked;
                    break;
                case "2":
                    hidingpower.CheckState = CheckState.Indeterminate;
                    break;
                case "3":
                    hidingpower.CheckState = CheckState.Checked;
                    break;
                default:
                    break;
            }
        }

        private void setTextBox_TextChanged(object sender, EventArgs e)
        {
            SetComboBox.SelectedValue = setTextBox.Text;
        }

        private void SetComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            setTextBox.Text = Convert.ToString(SetComboBox.SelectedValue);
        }

        private void colorSetTextBox_TextChanged(object sender, EventArgs e)
        {
            ColorSetComboBox.SelectedValue = colorSetTextBox.Text;
        }

        private void ColorSetComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            colorSetTextBox.Text = Convert.ToString(ColorSetComboBox.SelectedValue);
        }

        private void amountTextBox_TextChanged(object sender, EventArgs e)
        {
            AmountComboBox.SelectedValue = amountTextBox.Text;
        }

        private void AmountComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            amountTextBox.Text = Convert.ToString(AmountComboBox.SelectedValue);
        }


    }
}
