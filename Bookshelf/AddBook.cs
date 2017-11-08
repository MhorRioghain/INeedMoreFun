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
        public AddBook()
        {
            InitializeComponent();
        }

        private void tBooksBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tBooksBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.booksDataSet);
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
            FavouriteImage();
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
            FavouriteImage();
        }

        public void FavouriteImage()
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
        
        private void TitleBtn_Click(object sender, EventArgs e)
        {
            tBooksBindingSource.Filter = "[Title] LIKE '%" + FilterBox.Text + "%'";
        }
    }
}
