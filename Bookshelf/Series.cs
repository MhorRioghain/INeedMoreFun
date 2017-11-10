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
    public partial class Series : Form
    {
        public Series()
        {
            InitializeComponent();
        }

        private void tSeriesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tSeriesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.booksDataSet);

        }

        private void Series_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "booksDataSet.TSeries". При необходимости она может быть перемещена или удалена.
            this.tSeriesTableAdapter.Fill(this.booksDataSet.TSeries);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.tSeriesTableAdapter.Fill(this.booksDataSet.TSeries);
        }
    }
}
