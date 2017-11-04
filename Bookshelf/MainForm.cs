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
        public AddBooks ab = null;

        public MainForm()
        {
            InitializeComponent();        
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (ab == null || ab.Text == "")
            {
                ab = new AddBooks();
                ab.Show();
            }
            else
            {
                ab.Activate();
            }
        }

        private void tBooksBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.tBooksBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.booksDataSet);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "booksDataSet.TCategories". При необходимости она может быть перемещена или удалена.
            this.tCategoriesTableAdapter.Fill(this.booksDataSet.TCategories);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "booksDataSet.TBooks". При необходимости она может быть перемещена или удалена.
            this.tBooksTableAdapter.Fill(this.booksDataSet.TBooks);
        }

        private void UpdateTable_Click(object sender, EventArgs e)
        {
            tBooksTableAdapter.Fill(this.booksDataSet.TBooks);
            tCategoriesTableAdapter.Fill(this.booksDataSet.TCategories);
        }

        private void TitleFilter_Click(object sender, EventArgs e)
        {
            tBooksBindingSource.Filter = "[Title] LIKE '%" + FilterBox.Text + "%'";
        }

        private void AuthorFilter_Click(object sender, EventArgs e)
        {

        }

        private void ShowAll_Click(object sender, EventArgs e)
        {
            tBooksBindingSource.Filter = "";
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
                tBooksBindingSource.Filter = "Series LIKE '" + SeriesFltr.SelectedValue + "'";
            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {

        }

        private void SeriesFltr_Click(object sender, EventArgs e)
        {

        }

        private void findSeriesToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tBooksTableAdapter.FindSeries(this.booksDataSet.TBooks);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void findSeriesToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.tBooksTableAdapter.FindSeries(this.booksDataSet.TBooks);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
