using Tyuiu.VazhnikLN.Sprint6.Task1.V21.Lib;

namespace Tyuiu.VazhnikLN.Sprint6.Task1.V21
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        private void HelpButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 Вариант 21 выполнил студент группы ПКТб-26-1", "Справка");
        }

        private void ExecuteButton_Click(object sender, EventArgs e)
        {
            try
            {
                int startvalue = Convert.ToInt16(InputStartValue.Text);
                int stopvalue = Convert.ToInt16(InputStopValue.Text);
                string str;
                int len = ds.GetMassFunction(startvalue, stopvalue).Length;
                double[] s = new double[len];
                s = ds.GetMassFunction(startvalue, stopvalue);
                OutputTextBox.AppendText("+----------+----------+" + Environment.NewLine);
                OutputTextBox.AppendText("|    X     +    F(x)  |" + Environment.NewLine);
                OutputTextBox.AppendText("+----------+----------+" + Environment.NewLine);
                for (int i = 0; i <= len - 1; i++)
                {
                    if (s[i] >= 10 || s[i] <= -10)
                    {
                        str = String.Format("|{0,5:d}     | {1, 5:f2}   | ", startvalue, s[i]);
                    }
                    else
                    {
                        str = String.Format("|{0,5:d}     | {1, 5:f2}    | ", startvalue, s[i]);
                    }
                    OutputTextBox.AppendText(str + Environment.NewLine);
                    startvalue++;
                }
                OutputTextBox.AppendText("+----------+----------+" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
