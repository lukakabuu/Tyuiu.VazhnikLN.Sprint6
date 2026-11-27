using System.Drawing.Drawing2D;
using Tyuiu.VazhnikLN.Sprint6.Task3.V28.Lib;
namespace Tyuiu.VazhnikLN.Spint6.Task3.V28
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        int[,] matrix =
        {
                {-9, 8, 9, 16, -18 },
                { -13, -11, -20, -15, 9 },
                {18,  13, -12, -15, -11 },
                {10,  -2,  19,  -4, -10 },
                {6, -20,  -4,  13, -14}
        };
        private void FormMain_Load(object sender, EventArgs e)
        {
            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.Length / rows;
            for (int i = 0; i < columns; i++)
            {
                dataGridView.Columns.Add($"col{i}", $"Col {i}");
                dataGridView.Columns[i].Width = 50;
            }
            for (int i = 0; i < rows; i++)
            {
                dataGridView.Rows.Add();
            }

            for (int i = 0; i <  rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridView.Rows[i].Cells[j].Value = Convert.ToString(matrix[i, j]);
                }

            }
        }
        private void Done_Click(object sender, EventArgs e)
        {
            int[,] neww = ds.Calculate(matrix);
            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.Length / rows;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridView.Rows[i].Cells[j].Value = Convert.ToString(matrix[i, j]);
                }

            }
            dataGridView.Update();
        }
        private void Help_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Спринт 6 Таск 3 Вариант 28 выполнил студент ПКТб-26-1 Важник Лука Николаевич", "Справка", MessageBoxButtons.OK);
        }
    }
}
