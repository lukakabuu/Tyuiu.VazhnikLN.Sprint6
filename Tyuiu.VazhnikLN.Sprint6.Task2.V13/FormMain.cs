using System.Diagnostics.CodeAnalysis;
using Tyuiu.VazhnikLN.Sprint6.Task2.V13.Lib;
namespace Tyuiu.VazhnikLN.Sprint6.Task2.V13
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void Done_Click(object sender, EventArgs e)
        {
            try
            {
                int startvalue = Convert.ToInt16(InputStart.Text);
                int stopvalue = Convert.ToInt16(InputStop.Text);
                this.chart1.Titles.Add("График функции");
                this.chart1.ChartAreas[0].AxisX.Title = "Ось X";
                this.chart1.ChartAreas[0].AxisY.Title = "Ось Y";
                DataService ds = new DataService();
                int len = stopvalue - startvalue + 1;
                double[] res = ds.GetMassFunction(startvalue, stopvalue);
                for (int i = 0; i < len; i++)
                {
                    this.dataGridViewFunction.Rows.Add(Convert.ToString(startvalue), Convert.ToString(res[i]));
                    this.chart1.Series[0].Points.AddXY(startvalue, res[i]);
                    startvalue++;
                }
                Done.BackColor = Color.DarkGreen;
            }
            catch
            {
                MessageBox.Show("Введены неверные данные!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Done.BackColor = Color.Red;
            }
        }

        private void Reference_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Спринт 6 Таск 2 выполнил Важник Лука Николаевич ПКТб-26-1");
        }
        private void Done_MouseHover(object sender, EventArgs e)
        {
            Done.BackColor = Color.Blue;
            Done.Update();
        }
    }
}
