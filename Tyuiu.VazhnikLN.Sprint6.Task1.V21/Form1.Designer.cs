namespace Tyuiu.VazhnikLN.Sprint6.Task1.V21
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
            Condition = new TextBox();
            ConsitionText = new TextBox();
            DataEnter = new TextBox();
            InputStartValue = new TextBox();
            InputStartValueText = new TextBox();
            InputStopValueText = new TextBox();
            InputStopValue = new TextBox();
            HelpButton = new Button();
            ExecuteButton = new Button();
            pictureTask = new PictureBox();
            textBox1 = new TextBox();
            OutputTextBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureTask).BeginInit();
            SuspendLayout();
            // 
            // Condition
            // 
            Condition.BorderStyle = BorderStyle.None;
            Condition.Font = new Font("Segoe UI", 18F);
            Condition.Location = new Point(33, 27);
            Condition.Name = "Condition";
            Condition.ReadOnly = true;
            Condition.Size = new Size(100, 32);
            Condition.TabIndex = 0;
            Condition.Text = "Условие";
            // 
            // ConsitionText
            // 
            ConsitionText.BackColor = SystemColors.Control;
            ConsitionText.BorderStyle = BorderStyle.None;
            ConsitionText.Font = new Font("Segoe UI", 16F);
            ConsitionText.Location = new Point(33, 65);
            ConsitionText.Multiline = true;
            ConsitionText.Name = "ConsitionText";
            ConsitionText.ReadOnly = true;
            ConsitionText.Size = new Size(365, 138);
            ConsitionText.TabIndex = 1;
            ConsitionText.Text = "Протабулировать функцию на заданном диапозоне\r\nРезультат вывести в виде таблицы";
            // 
            // DataEnter
            // 
            DataEnter.BorderStyle = BorderStyle.None;
            DataEnter.Font = new Font("Segoe UI", 14F);
            DataEnter.Location = new Point(33, 347);
            DataEnter.Name = "DataEnter";
            DataEnter.ReadOnly = true;
            DataEnter.Size = new Size(122, 25);
            DataEnter.TabIndex = 2;
            DataEnter.Text = "Ввод данных";
            // 
            // InputStartValue
            // 
            InputStartValue.Location = new Point(33, 404);
            InputStartValue.Name = "InputStartValue";
            InputStartValue.Size = new Size(122, 23);
            InputStartValue.TabIndex = 3;
            // 
            // InputStartValueText
            // 
            InputStartValueText.BackColor = SystemColors.Control;
            InputStartValueText.BorderStyle = BorderStyle.None;
            InputStartValueText.Font = new Font("Segoe UI", 12F);
            InputStartValueText.Location = new Point(33, 375);
            InputStartValueText.Name = "InputStartValueText";
            InputStartValueText.ReadOnly = true;
            InputStartValueText.Size = new Size(100, 22);
            InputStartValueText.TabIndex = 4;
            InputStartValueText.Text = "Начало шага:";
            // 
            // InputStopValueText
            // 
            InputStopValueText.BackColor = SystemColors.Control;
            InputStopValueText.BorderStyle = BorderStyle.None;
            InputStopValueText.Font = new Font("Segoe UI", 12F);
            InputStopValueText.Location = new Point(217, 375);
            InputStopValueText.Name = "InputStopValueText";
            InputStopValueText.ReadOnly = true;
            InputStopValueText.Size = new Size(100, 22);
            InputStopValueText.TabIndex = 5;
            InputStopValueText.Text = "Конец шага:";
            // 
            // InputStopValue
            // 
            InputStopValue.Location = new Point(217, 404);
            InputStopValue.Name = "InputStopValue";
            InputStopValue.Size = new Size(125, 23);
            InputStopValue.TabIndex = 6;
            // 
            // HelpButton
            // 
            HelpButton.BackColor = Color.FromArgb(255, 128, 128);
            HelpButton.Font = new Font("Segoe UI", 12F);
            HelpButton.Location = new Point(367, 383);
            HelpButton.Name = "HelpButton";
            HelpButton.Size = new Size(100, 44);
            HelpButton.TabIndex = 7;
            HelpButton.Text = "Справка";
            HelpButton.UseVisualStyleBackColor = false;
            HelpButton.Click += HelpButton_Click;
            // 
            // ExecuteButton
            // 
            ExecuteButton.BackColor = Color.Cyan;
            ExecuteButton.Font = new Font("Segoe UI", 12F);
            ExecuteButton.Location = new Point(482, 383);
            ExecuteButton.Name = "ExecuteButton";
            ExecuteButton.Size = new Size(109, 46);
            ExecuteButton.TabIndex = 8;
            ExecuteButton.Text = "Выполнить";
            ExecuteButton.UseVisualStyleBackColor = false;
            ExecuteButton.Click += ExecuteButton_Click;
            // 
            // pictureTask
            // 
            pictureTask.Image = Properties.Resources._611;
            pictureTask.Location = new Point(33, 174);
            pictureTask.Name = "pictureTask";
            pictureTask.Size = new Size(307, 50);
            pictureTask.TabIndex = 9;
            pictureTask.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Control;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 14F);
            textBox1.Location = new Point(592, 27);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(132, 25);
            textBox1.TabIndex = 10;
            textBox1.Text = "Вывод данных:";
            // 
            // OutputTextBox
            // 
            OutputTextBox.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            OutputTextBox.Location = new Point(530, 58);
            OutputTextBox.Multiline = true;
            OutputTextBox.Name = "OutputTextBox";
            OutputTextBox.ScrollBars = ScrollBars.Vertical;
            OutputTextBox.Size = new Size(258, 314);
            OutputTextBox.TabIndex = 11;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(OutputTextBox);
            Controls.Add(textBox1);
            Controls.Add(pictureTask);
            Controls.Add(ExecuteButton);
            Controls.Add(HelpButton);
            Controls.Add(InputStopValue);
            Controls.Add(InputStopValueText);
            Controls.Add(InputStartValueText);
            Controls.Add(InputStartValue);
            Controls.Add(DataEnter);
            Controls.Add(ConsitionText);
            Controls.Add(Condition);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 1 | Вариант 21 | Важник. Л. Н";
            ((System.ComponentModel.ISupportInitialize)pictureTask).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Condition;
        private TextBox ConsitionText;
        private TextBox DataEnter;
        private TextBox InputStartValue;
        private TextBox InputStartValueText;
        private TextBox InputStopValueText;
        private TextBox InputStopValue;
        private Button HelpButton;
        private Button ExecuteButton;
        private PictureBox pictureTask;
        private TextBox textBox1;
        private TextBox OutputTextBox;
    }
}
