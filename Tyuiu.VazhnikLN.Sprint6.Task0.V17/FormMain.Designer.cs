namespace Tyuiu.VazhnikLN.Sprint6.Task0.V17
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            PressButton = new Button();
            PictureExpression = new PictureBox();
            ConditionText = new TextBox();
            InscriptionText = new TextBox();
            InputX = new TextBox();
            DataEntryText = new TextBox();
            DigitText = new TextBox();
            DataOutputText = new TextBox();
            textBox1 = new TextBox();
            Help = new Button();
            Result = new TextBox();
            ((System.ComponentModel.ISupportInitialize)PictureExpression).BeginInit();
            SuspendLayout();
            // 
            // PressButton
            // 
            PressButton.Font = new Font("Segoe UI", 14F);
            PressButton.ForeColor = Color.Black;
            PressButton.Location = new Point(644, 362);
            PressButton.Name = "PressButton";
            PressButton.Size = new Size(144, 34);
            PressButton.TabIndex = 0;
            PressButton.Text = "Выполнить";
            PressButton.UseVisualStyleBackColor = true;
            // 
            // PictureExpression
            // 
            PictureExpression.Image = Properties.Resources._60;
            PictureExpression.InitialImage = (Image)resources.GetObject("PictureExpression.InitialImage");
            PictureExpression.Location = new Point(684, 46);
            PictureExpression.Name = "PictureExpression";
            PictureExpression.Size = new Size(72, 55);
            PictureExpression.TabIndex = 1;
            PictureExpression.TabStop = false;
            // 
            // ConditionText
            // 
            ConditionText.BackColor = Color.White;
            ConditionText.BorderStyle = BorderStyle.None;
            ConditionText.Font = new Font("Segoe UI", 14F);
            ConditionText.Location = new Point(28, 28);
            ConditionText.Name = "ConditionText";
            ConditionText.ReadOnly = true;
            ConditionText.Size = new Size(313, 25);
            ConditionText.TabIndex = 2;
            ConditionText.Text = "Условие:";
            // 
            // InscriptionText
            // 
            InscriptionText.BackColor = Color.White;
            InscriptionText.BorderStyle = BorderStyle.None;
            InscriptionText.Font = new Font("Segoe UI", 14F);
            InscriptionText.Location = new Point(28, 64);
            InscriptionText.Multiline = true;
            InscriptionText.Name = "InscriptionText";
            InscriptionText.ReadOnly = true;
            InscriptionText.Size = new Size(619, 168);
            InscriptionText.TabIndex = 3;
            InscriptionText.Text = "Вычислить выражение по формуле";
            // 
            // InputX
            // 
            InputX.Font = new Font("Segoe UI", 14F);
            InputX.Location = new Point(42, 318);
            InputX.Name = "InputX";
            InputX.Size = new Size(171, 32);
            InputX.TabIndex = 4;
            InputX.KeyPress += InputX_KeyPress;
            // 
            // DataEntryText
            // 
            DataEntryText.BackColor = Color.White;
            DataEntryText.BorderStyle = BorderStyle.None;
            DataEntryText.Font = new Font("Segoe UI", 14F);
            DataEntryText.Location = new Point(42, 238);
            DataEntryText.Name = "DataEntryText";
            DataEntryText.ReadOnly = true;
            DataEntryText.Size = new Size(150, 25);
            DataEntryText.TabIndex = 5;
            DataEntryText.Text = "Ввод данных";
            // 
            // DigitText
            // 
            DigitText.BackColor = Color.White;
            DigitText.BorderStyle = BorderStyle.None;
            DigitText.Font = new Font("Segoe UI", 14F);
            DigitText.Location = new Point(42, 287);
            DigitText.Name = "DigitText";
            DigitText.Size = new Size(136, 25);
            DigitText.TabIndex = 6;
            DigitText.Text = "Переменная X";
            // 
            // DataOutputText
            // 
            DataOutputText.BackColor = Color.White;
            DataOutputText.BorderStyle = BorderStyle.None;
            DataOutputText.Font = new Font("Segoe UI", 14F);
            DataOutputText.Location = new Point(477, 238);
            DataOutputText.Name = "DataOutputText";
            DataOutputText.ReadOnly = true;
            DataOutputText.Size = new Size(134, 25);
            DataOutputText.TabIndex = 7;
            DataOutputText.Text = "Вывод данных";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.White;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 14F);
            textBox1.Location = new Point(477, 287);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 25);
            textBox1.TabIndex = 8;
            textBox1.Text = "Результат";
            // 
            // Help
            // 
            Help.BackgroundImageLayout = ImageLayout.None;
            Help.FlatStyle = FlatStyle.Flat;
            Help.Font = new Font("Segoe UI", 14F);
            Help.Location = new Point(590, 362);
            Help.Name = "Help";
            Help.Size = new Size(39, 32);
            Help.TabIndex = 10;
            Help.Text = "?";
            Help.UseVisualStyleBackColor = true;
            Help.Click += Help_Click;
            // 
            // Result
            // 
            Result.Font = new Font("Segoe UI", 14F);
            Result.Location = new Point(477, 327);
            Result.Name = "Result";
            Result.ReadOnly = true;
            Result.Size = new Size(100, 32);
            Result.TabIndex = 11;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 408);
            Controls.Add(Result);
            Controls.Add(Help);
            Controls.Add(textBox1);
            Controls.Add(DataOutputText);
            Controls.Add(DigitText);
            Controls.Add(DataEntryText);
            Controls.Add(InputX);
            Controls.Add(InscriptionText);
            Controls.Add(ConditionText);
            Controls.Add(PictureExpression);
            Controls.Add(PressButton);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 0 | Вариант 17 | Важник.Л.Н";
            ((System.ComponentModel.ISupportInitialize)PictureExpression).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button PressButton;
        private PictureBox PictureExpression;
        private TextBox ConditionText;
        private TextBox InscriptionText;
        private TextBox InputX;
        private TextBox DataEntryText;
        private TextBox DigitText;
        private TextBox DataOutputText;
        private TextBox textBox1;
        private Button Help;
        private TextBox Result;
    }
}
