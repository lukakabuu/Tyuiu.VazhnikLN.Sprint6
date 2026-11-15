using Tyuiu.VazhnikLN.Sprint6.Task0.V17.Lib;
namespace Tyuiu.VazhnikLN.Sprint6.Task0.V17
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            PressButton.Click += PressButton_Click;
        }
        private void InputX_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }
        private void PressButton_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();

            try
            {
                Result.Text = Convert.ToString(Math.Round(ds.Calculate(Convert.ToInt16(InputX.Text)), 3));
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Help_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 0 выполнил студент группы ПКТб-26-1 Важник Лука Николаевич", "Сообщение");
        }
    }
}
