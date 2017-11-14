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
    public partial class Categories : Form
    {
        public Categories()
        {
            InitializeComponent();
        }

        private void tCategoriesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.tCategoriesBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.booksDataSet);
            }
            catch (global::System.Exception ex)
            {
                if (ex.Message == "Необходимо ввести значение в поле \"TCategories.Category\".")
                {
                    MessageBox.Show("Необходимо ввести название категории", "Внимание!");
                }
                else
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void Categories_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "booksDataSet.TCategories". При необходимости она может быть перемещена или удалена.
            this.tCategoriesTableAdapter.Fill(this.booksDataSet.TCategories);

        }

        private void tCategoriesDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (e.Exception.Message == "В столбце \"id\" не допускаются значения равные nulls.")
            {
                MessageBox.Show("Номер категории п.п. обязателен", "Ошибка!");
            }
            else
            {
                MessageBox.Show(e.Exception.Message);
            }
        }
    }
}
