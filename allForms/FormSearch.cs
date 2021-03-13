using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace allForms
{
    public partial class FormSearch : Form
    {
        private DataTable dt = MainForm.dtSearch;
        private int rowIndex = -1;
        public static DateTime cellDate;
        Point lastPoint;
        public FormSearch()
        {
            InitializeComponent();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormSearch_Load(object sender, EventArgs e)
        {

            //dataGridView1.CurrentCell = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex + 1].Cells[dataGridView1.CurrentCell.ColumnIndex];
            dataGridView1.DataSource = MainForm.dtSearch;

            // меняем высоту таблицу по высоте всех строк
            //dataGridView1.Height = dataGridView1.Rows.GetRowsHeight(DataGridViewElementStates.Visible) + dataGridView1.ColumnHeadersHeight + 12;
            ChangeHeight();
            // 
            dataGridView1.Columns[0].HeaderText = "Заголовок";
            dataGridView1.Columns[1].HeaderText = "Текст заметки";
            dataGridView1.Columns[2].HeaderText = "Дата создания";

            ////
            dataGridView1.Columns[0].Width = 105;
            dataGridView1.Columns[1].Width = 250;
            dataGridView1.Columns[2].Width = 120;

            //
            dataGridView1.DefaultCellStyle.Font = new Font("Century Gothic", 11, FontStyle.Italic);
            dataGridView1.ForeColor = Color.FromArgb(49, 46, 44);
            dataGridView1.GridColor = Color.FromArgb(73, 69, 65);
            dataGridView1.BorderStyle = BorderStyle.FixedSingle;

            //
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 12, FontStyle.Italic);

            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(138, 129, 121);

            //
            dataGridView1.BackgroundColor = Color.FromArgb(204, 194, 183);
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.FromArgb(227, 220, 211);
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.FromArgb(49, 46, 44);
          
        }

        // при нажатие на ячейку данные заносятся  в текст. поля title и  Note
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.RowIndex >= 0)
            //{
            //    rowIndex = e.RowIndex;
            //    textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells["creationDate"].Value.ToString();
            //    cellDate = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells["creationDate"].Value.ToString());
            //    this.Hide();

            //    //title.Text = dgvData.Rows[e.RowIndex].Cells["noteTitle"].Value.ToString();
            //}
        }

        private void ChangeHeight()
        {
            // меняем высоту таблицу по высоте всех строк
            dataGridView1.Height = dataGridView1.Rows.GetRowsHeight(DataGridViewElementStates.Visible) + dataGridView1.ColumnHeadersHeight + 30;
        }

        private void labelDown_Click(object sender, EventArgs e)
        {
            // dataGridView1.CurrentCell = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex + 1].Cells[dataGridView1.CurrentCell.ColumnIndex];
        }

        private void labelUp_Click(object sender, EventArgs e)
        {
            // dataGridView1.CurrentCell = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex - 1].Cells[dataGridView1.CurrentCell.ColumnIndex];
        }

        private void labelBeg_Click(object sender, EventArgs e)
        {
            dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[0];
        }

        private void labelEnd_Click(object sender, EventArgs e)
        {
            dataGridView1.CurrentCell = dataGridView1.Rows[dataGridView1.RowCount - 1].Cells[0];
        }

        // передвижение формы
        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void pictureBox2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void closeX_Click(object sender, EventArgs e)
        {
            this.Close();
            //MainForm main = new MainForm();
            //main.Show();
        }
    }
}
