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
    public partial class MainForm : Form
    {
        public AddBook ab = null;
        public Series ser = null;

        // TODO: переменные необходимые для работы нескольких фильтров сразу.
        string filterName = null;
        string filterSeries = null;
        string filterRead = null;

        public MainForm()
        {
            InitializeComponent();        
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            // TODO: открытие новой формы или активация уже открытой.
            if (ab == null || ab.Text == "")
            {
                ab = new AddBook();
                ab.Show();
            }
            else
            {
                ab.Activate();
            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            if (ser == null || ser.Text == "")
            {
                ser = new Series();                
                ser.Show();
            }
            else
            {
                ser.Activate();
            }

            ser.tSeriesTableAdapter.InsertQuery();
            ser.tSeriesTableAdapter.Fill(ser.booksDataSet.TSeries);
        }

        private void tBooksBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.tBooksBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.booksDataSet);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "booksDataSet.TShelf". При необходимости она может быть перемещена или удалена.
            this.tShelfTableAdapter.Fill(this.booksDataSet.TShelf);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "booksDataSet.TSeries". При необходимости она может быть перемещена или удалена.
            this.tSeriesTableAdapter.Fill(this.booksDataSet.TSeries);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "booksDataSet.TCategories". При необходимости она может быть перемещена или удалена.
            this.tCategoriesTableAdapter.Fill(this.booksDataSet.TCategories);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "booksDataSet.TBooks". При необходимости она может быть перемещена или удалена.
            this.tBooksTableAdapter.Fill(this.booksDataSet.TBooks);
        }

        private void UpdateTable_Click(object sender, EventArgs e)
        {
            // TODO: обновление данных на форме.
            tBooksTableAdapter.Fill(this.booksDataSet.TBooks);
            tCategoriesTableAdapter.Fill(this.booksDataSet.TCategories);
            tSeriesTableAdapter.Fill(this.booksDataSet.TSeries);
        }

        private void TitleFilter_Click(object sender, EventArgs e)
        {
            filterName = null;
            filterName = AddAnd() + "Title LIKE '%" + FilterBox.Text + "%'";
            tBooksBindingSource.Filter = filterName + filterSeries + filterRead;
        }

        private void AuthorFilter_Click(object sender, EventArgs e)
        {
            filterName = null;
            filterName = AddAnd() + "Author LIKE '%" + FilterBox.Text + "%'";
            tBooksBindingSource.Filter = filterName + filterSeries + filterRead;
        }

        private void ShowAll_Click(object sender, EventArgs e)
        {
            filterName = null;
            filterSeries = null;
            filterRead = null;
            tBooksBindingSource.RemoveFilter();
        }

        private void CategoryFltr_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CategoryFltr.Focused == true)
            { 
                tBooksBindingSource.Filter = "Category = " + (int)(CategoryFltr.SelectedValue); 
            }
        }

        private void SeriesFltr_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SeriesFltr.Focused == true)
            {
                filterSeries = null;
                filterSeries = AddAnd() + "Series LIKE '" + SeriesFltr.SelectedValue + "'";
                tBooksBindingSource.Filter = filterName + filterSeries + filterRead;
            }
        }

        private void Read_Click(object sender, EventArgs e)
        {
            filterRead = null;
            filterRead = AddAnd() + "IsRead = true";
            tBooksBindingSource.Filter = filterName + filterSeries + filterRead;
        }

        private void Unread_Click(object sender, EventArgs e)
        {
            filterRead = null;
            filterRead = AddAnd() + "IsRead = false";
            tBooksBindingSource.Filter = filterName + filterSeries + filterRead;
        }

        private void Un_Read_Click(object sender, EventArgs e)
        {
            filterRead = null;
            filterRead = AddAnd() + "IsRead = false OR IsRead = true";
            tBooksBindingSource.Filter = filterName + filterSeries + filterRead;
        }

        private string AddAnd()
        {
            string str = null;
            if (filterName != null || filterRead != null || filterSeries != null)
            {
                str = " AND ";
            }
            return str;
        }

        private void FavouriteUncheck_Click(object sender, EventArgs e)
        {
            tBooksBindingSource.Filter = "IsFavourite = false";
        }

        private void FavouriteCheck_Click(object sender, EventArgs e)
        {
            tBooksBindingSource.Filter = "IsFavourite = true";
        }

        private void FavouriteAll_Click(object sender, EventArgs e)
        {
            tBooksBindingSource.Filter = "IsFavourite = false OR IsFavourite = true";
        }

        private void tBooksDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 10)
            {
                ShowBook sb = new ShowBook();
                sb.tBooksBindingSource.Filter = "id = " + Convert.ToInt32(tBooksDataGridView[0, e.RowIndex].Value);
                sb.Show();
            }
        }
    }
}
