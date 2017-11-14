using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bookshelf
{
    public partial class ShowBook : Form
    {
        public ShowBook()
        {
            InitializeComponent();
        }

        private void tBooksBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tBooksBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.booksDataSet);

        }

        private void ShowBook_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "booksDataSet.TSeries". При необходимости она может быть перемещена или удалена.
            this.tSeriesTableAdapter.Fill(this.booksDataSet.TSeries);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "booksDataSet.TCategories". При необходимости она может быть перемещена или удалена.
            this.tCategoriesTableAdapter.Fill(this.booksDataSet.TCategories);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "booksDataSet.TShelf". При необходимости она может быть перемещена или удалена.
            this.tShelfTableAdapter.Fill(this.booksDataSet.TShelf);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "booksDataSet.TBooks". При необходимости она может быть перемещена или удалена.
            this.tBooksTableAdapter.Fill(this.booksDataSet.TBooks);
        }

        private void isFavouriteCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            switch (isFavouriteCheckBox.CheckState)
            {
                case CheckState.Checked:
                    isFavouriteCheckBox.BackgroundImage = global::Bookshelf.Properties.Resources.star_full;
                    break;
                case CheckState.Indeterminate:
                    isFavouriteCheckBox.BackgroundImage = global::Bookshelf.Properties.Resources.star_half;
                    break;
                case CheckState.Unchecked:
                    isFavouriteCheckBox.BackgroundImage = global::Bookshelf.Properties.Resources.star_empty;
                    break;
                default:
                    break;
            }
        }

        private void isReadCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            switch (isReadCheckBox.CheckState)
            {
                case CheckState.Checked:
                    isReadCheckBox.BackgroundImage = global::Bookshelf.Properties.Resources.green_tick;
                    break;
                case CheckState.Indeterminate:
                    isReadCheckBox.BackgroundImage = global::Bookshelf.Properties.Resources.half;
                    break;
                case CheckState.Unchecked:
                    isReadCheckBox.BackgroundImage = global::Bookshelf.Properties.Resources.cross_red;
                    break;
                default:
                    break;
            }
        }


        // TODO: устанавливает значение в выпадающий список.
        private void CategoryComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            categoryTextBox.Text = Convert.ToString(CategoryComboBox.SelectedValue);
        }

        private void ShelfComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            shelfTextBox.Text = Convert.ToString(ShelfComboBox.SelectedValue);
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (titleTextBox.Text != "")
            {
                this.Validate();
                this.tBooksBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.booksDataSet);
                // TODO: заполняет таблицу "booksDataSet.TSeries" отсутствующими неповторяющимеся данными из таблицы "booksDataSet.TBooks".
                tSeriesTableAdapter.InsertQuery();
                tSeriesTableAdapter.Fill(booksDataSet.TSeries);
            }
            else
            {
                toolTip1.Show("Введите название книги", SaveButton);
            }
        }

        // TODO: устанавливает текущее значение в выпадающий список.
        private void categoryTextBox_TextChanged(object sender, EventArgs e)
        {
            CategoryComboBox.SelectedValue = categoryTextBox.Text;
        }

        // TODO: устанавливает текущее значение в выпадающий список.
        private void shelfTextBox_TextChanged(object sender, EventArgs e)
        {
            ShelfComboBox.SelectedValue = shelfTextBox.Text;
        }
    }
}
