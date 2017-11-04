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
        public static AddBooks ab = null;

        public MainForm()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {            
            if (ab == null)
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

        private void MainForm_Activated(object sender, EventArgs e)
        {
            this.tBooksTableAdapter.Fill(this.booksDataSet.TBooks);
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            ab = null;
        }

        private void TitleBtn_Click(object sender, EventArgs e)
        {
            ab = null;
        }
    }
}
