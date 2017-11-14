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
        // TODO: переменные новых форм
        public AddBook ab = null;
        public Series ser = null;
        public Categories cat = null;
        public Shelfs shelf = null;

        // TODO: переменные необходимые для работы нескольких фильтров сразу.
        string filterName = null;
        string filterSeries = null;
        string filterRead = null;

        public MainForm()
        {
            InitializeComponent();        
        }

        private void tBooksBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.tBooksBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.booksDataSet);
                // TODO: заполняет таблицу "booksDataSet.TSeries" отсутствующими неповторяющимеся данными из таблицы "booksDataSet.TBooks".
                tSeriesTableAdapter.InsertQuery();
                tSeriesTableAdapter.Fill(booksDataSet.TSeries);
                RowHeaderColor();
            }
            catch (global::System.Exception ex)
            {
                if (ex.Message == "Необходимо ввести значение в поле \"TBooks.Title\".")
                {
                    MessageBox.Show("Необходимо ввести название книги", "Внимание!");
                }
                else 
                { 
                    MessageBox.Show(ex.Message); 
                }
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            DataLoad();
        }

        private void DataLoad()
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "booksDataSet.TShelf". При необходимости она может быть перемещена или удалена.
            this.tShelfTableAdapter.Fill(this.booksDataSet.TShelf);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "booksDataSet.TSeries". При необходимости она может быть перемещена или удалена.
            this.tSeriesTableAdapter.Fill(this.booksDataSet.TSeries);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "booksDataSet.TCategories". При необходимости она может быть перемещена или удалена.
            this.tCategoriesTableAdapter.Fill(this.booksDataSet.TCategories);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "booksDataSet.TBooks". При необходимости она может быть перемещена или удалена.
            this.tBooksTableAdapter.Fill(this.booksDataSet.TBooks);
            RowHeaderColor();
        }

        private void UpdateTable_Click(object sender, EventArgs e)
        {
            DataLoad();
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

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            // TODO: открытие новой формы или активация уже открытой.
            if (cat == null || cat.Text == "")
            {
                cat = new Categories();
                cat.Show();
            }
            else
            {
                cat.Activate();
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            // TODO: открытие новой формы или активация уже открытой.
            if (shelf == null || shelf.Text == "")
            {
                shelf = new Shelfs();
                shelf.Show();
            }
            else
            {
                shelf.Activate();
            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            // TODO: открытие новой формы или активация уже открытой.
            if (ser == null || ser.Text == "")
            {
                ser = new Series();                
                ser.Show();
            }
            else
            {
                ser.Activate();
            }
        }

        // TODO: фильтры для таблицы "booksDataSet.TBooks".
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

        private void ContentFilter_Click(object sender, EventArgs e)
        {
            tBooksBindingSource.Filter = "TableOfContents LIKE '%" + FilterBox.Text + "%'";
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

        private void ShelfFltr_SelectedValueChanged(object sender, EventArgs e)
        {
            if (ShelfFltr.Focused == true)
            {
                tBooksBindingSource.Filter = "Shelf = " + (int)ShelfFltr.SelectedValue;
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
            filterRead = AddAnd();
            tBooksBindingSource.Filter = filterName + filterSeries + filterRead + "IsRead = false OR " + filterName + filterSeries + filterRead + "IsRead = true";
        }

        // TODO: добавляет операнд "и" к началу строки фильтра, если задано несколько критериев поиска. 
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
        
        // TODO: очистка фильтров для таблицы "booksDataSet.TBooks".
        private void ShowAll_Click(object sender, EventArgs e)
        {            
            filterName = null;
            filterSeries = null;
            filterRead = null;
            tBooksBindingSource.RemoveFilter();
        }
        
        private void tBooksDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // TODO: открытие определённой записи таблицы "booksDataSet.TBooks".
            if (e.ColumnIndex == 10 && e.RowIndex < tBooksDataGridView.RowCount - 1)
            {
                ShowBook sb = new ShowBook();
                sb.tBooksBindingSource.Filter = "id = " + Convert.ToInt32(tBooksDataGridView[0, e.RowIndex].Value);
                sb.Show();
            }
        }

        private void tBooksDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (e.Exception.Message == "В столбце \"id\" не допускаются значения равные nulls.")
            {
                MessageBox.Show("Номер книги п.п. обязателен", "Ошибка!");
            }
            else
            {
                MessageBox.Show(e.Exception.Message);
            }
        }
            
        // TODO: функция закрашивает заголовки строк, в которых не присвоены значения параметрам "Категория" и "Полка"
        private void RowHeaderColor()
        {
            tBooksDataGridView.EnableHeadersVisualStyles = false;
            foreach (DataGridViewRow r in tBooksDataGridView.Rows)
            {                
                if (r.Cells["dataGridViewShelf"].Value == null || r.Cells["dataGridViewShelf"].Value.ToString() == "" 
                    || r.Cells["dataGridViewCategory"].Value.ToString() == "" || r.Cells["dataGridViewCategory"].Value == null)
                {
                    r.HeaderCell.Style.BackColor = Color.Salmon;
                }
                else
                {
                    r.HeaderCell.Style.BackColor = Color.WhiteSmoke;
                }
                if (r.Index == tBooksDataGridView.RowCount - 1)
                {
                    r.HeaderCell.Style.BackColor = Color.WhiteSmoke;
                }   
            }
        }

        private void tBooksDataGridView_Sorted(object sender, EventArgs e)
        {
            RowHeaderColor();        
        }

        private void tBooksDataGridView_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            // TODO: меняет стандартную иконку сортировки на выбранные изображения из ресурсов проекта.
            imageList1.Images.Add(global::Bookshelf.Properties.Resources.arrowupM);
            imageList1.Images.Add(global::Bookshelf.Properties.Resources.arrowdownM);
            if (e.RowIndex == -1 && e.ColumnIndex >= 1 && tBooksDataGridView.Columns[e.ColumnIndex].HeaderCell.SortGlyphDirection != SortOrder.None)
            {
                Image image = null;
                if (tBooksDataGridView.Columns[e.ColumnIndex].HeaderCell.SortGlyphDirection == SortOrder.Ascending)
                {
                    image = imageList1.Images[0];
                }
                else if (tBooksDataGridView.Columns[e.ColumnIndex].HeaderCell.SortGlyphDirection == SortOrder.Descending)
                {
                    image = imageList1.Images[1];
                }
                SolidBrush brush = new SolidBrush(Color.WhiteSmoke);                
                e.Graphics.FillRectangle(brush, e.CellBounds);                                
                e.Paint(e.ClipBounds, (DataGridViewPaintParts.All & ~DataGridViewPaintParts.Background));
                e.Graphics.DrawImage(image, new Point(e.CellBounds.X + e.CellBounds.Width - 20, e.CellBounds.Y + (e.CellBounds.Height / 2) - (image.Height / 2)));
                e.Handled = true;
            }
        }
    }
}
