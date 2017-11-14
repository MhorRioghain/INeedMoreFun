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
    public partial class AddBook : Form
    {
        string id;

        public AddBook()
        {
            InitializeComponent();
        }

        private void tBooksBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tBooksBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.booksDataSet);
            // TODO: заполняет таблицу "booksDataSet.TSeries" отсутствующими неповторяющимеся данными из таблицы "booksDataSet.TBooks".
            tSeriesTableAdapter.InsertQuery();
            tSeriesTableAdapter.Fill(booksDataSet.TSeries);
        }

        private void AddBooks_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "booksDataSet.TSeries". При необходимости она может быть перемещена или удалена.
            this.tSeriesTableAdapter.Fill(this.booksDataSet.TSeries);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "booksDataSet.TShelf". При необходимости она может быть перемещена или удалена.
            this.tShelfTableAdapter.Fill(this.booksDataSet.TShelf);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "booksDataSet.TCategories". При необходимости она может быть перемещена или удалена.
            this.tCategoriesTableAdapter.Fill(this.booksDataSet.TCategories);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "booksDataSet.TBooks". При необходимости она может быть перемещена или удалена.
            this.tBooksTableAdapter.Fill(this.booksDataSet.TBooks);
            tBooksBindingSource.AddNew();
            id = idTextBox.Text;
        }

        private void catComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            categoryTextBox.Text = Convert.ToString(catComboBox.SelectedValue);
        }

        private void shComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            shelfTextBox.Text = Convert.ToString(shComboBox.SelectedValue);
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

        private void categoryTextBox_TextChanged(object sender, EventArgs e)
        {
            if (categoryTextBox.Text != "")
            {
                catComboBox.SelectedValue = categoryTextBox.Text;
            }
        }        

        private void shelfTextBox_TextChanged(object sender, EventArgs e)
        {
            if (shelfTextBox.Text != "")
            {
                shComboBox.SelectedValue = shelfTextBox.Text;
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

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (titleTextBox.Text != "")
            {
                tBooksBindingSource.AddNew();
                id = idTextBox.Text;
                toolTip1.Hide(AddButton);
            }
            else
            {
                toolTip1.Show("Введите название книги", AddButton);
            }
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
                toolTip1.Hide(SaveButton);
            }
            else
            {
                toolTip1.Show("Введите название книги", SaveButton);
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            tBooksBindingSource.RemoveCurrent();
            tBooksBindingSource.AddNew();
            idTextBox.Text = id;
        }

        private void FocusLeave(object sender, EventArgs e)
        {
            toolTip1.Hide(AddButton);
            toolTip1.Hide(SaveButton);
        }
    }
}
