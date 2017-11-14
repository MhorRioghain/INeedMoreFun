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
    public partial class Shelfs : Form
    {
        public Shelfs()
        {
            InitializeComponent();
        }

        private void tShelfBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.tShelfBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.booksDataSet);
            }
            catch (global::System.Exception ex)
            {
                if (ex.Message == "Необходимо ввести значение в поле \"TShelf.Place\".")
                {
                    MessageBox.Show("Необходимо ввести местоположение полки", "Внимание!");
                }
                else
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void Shelfs_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "booksDataSet.TShelf". При необходимости она может быть перемещена или удалена.
            this.tShelfTableAdapter.Fill(this.booksDataSet.TShelf);

        }

        private void tShelfDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (e.Exception.Message == "В столбце \"id\" не допускаются значения равные nulls.")
            {
                MessageBox.Show("Номер полки п.п. обязателен", "Ошибка!");
            }
            else
            {
                MessageBox.Show(e.Exception.Message);
            }
        }
    }
}
