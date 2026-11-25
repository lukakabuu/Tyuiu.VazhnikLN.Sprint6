namespace Tyuiu.VazhnikLN.Sprint6.Task2.V13
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            ConditionText = new TextBox();
            ConditionTextBox = new TextBox();
            DataEntryText = new TextBox();
            InputStart = new TextBox();
            StartValueText = new TextBox();
            StopValueText = new TextBox();
            InputStop = new TextBox();
            Reference = new Button();
            Done = new Button();
            dataGridViewFunction = new DataGridView();
            x = new DataGridViewTextBoxColumn();
            F = new DataGridViewTextBoxColumn();
            DataOutputText = new TextBox();
            ResultTextBox = new TextBox();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFunction).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            SuspendLayout();
            // 
            // ConditionText
            // 
            ConditionText.BackColor = SystemColors.Control;
            ConditionText.BorderStyle = BorderStyle.None;
            ConditionText.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            ConditionText.Location = new Point(28, 25);
            ConditionText.Name = "ConditionText";
            ConditionText.ReadOnly = true;
            ConditionText.Size = new Size(100, 26);
            ConditionText.TabIndex = 0;
            ConditionText.Text = "Условие";
            // 
            // ConditionTextBox
            // 
            ConditionTextBox.BackColor = SystemColors.Control;
            ConditionTextBox.BorderStyle = BorderStyle.None;
            ConditionTextBox.Font = new Font("Segoe UI", 12F);
            ConditionTextBox.Location = new Point(28, 66);
            ConditionTextBox.Multiline = true;
            ConditionTextBox.Name = "ConditionTextBox";
            ConditionTextBox.ReadOnly = true;
            ConditionTextBox.Size = new Size(499, 71);
            ConditionTextBox.TabIndex = 1;
            ConditionTextBox.Text = "Протабулировать функцию cos(x) + 2/3 * x - 4x * cos(x) на заданном диапозоне\r\nРезультат вывести в DataGridView и построить график функции\r\n";
            // 
            // DataEntryText
            // 
            DataEntryText.BackColor = SystemColors.Control;
            DataEntryText.BorderStyle = BorderStyle.None;
            DataEntryText.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            DataEntryText.Location = new Point(28, 331);
            DataEntryText.Name = "DataEntryText";
            DataEntryText.ReadOnly = true;
            DataEntryText.Size = new Size(136, 26);
            DataEntryText.TabIndex = 2;
            DataEntryText.Text = "Ввод данных:";
            // 
            // InputStart
            // 
            InputStart.BackColor = SystemColors.Control;
            InputStart.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            InputStart.Location = new Point(28, 409);
            InputStart.Name = "InputStart";
            InputStart.Size = new Size(136, 29);
            InputStart.TabIndex = 3;
            // 
            // StartValueText
            // 
            StartValueText.BackColor = SystemColors.Control;
            StartValueText.BorderStyle = BorderStyle.None;
            StartValueText.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            StartValueText.Location = new Point(28, 381);
            StartValueText.Name = "StartValueText";
            StartValueText.ReadOnly = true;
            StartValueText.Size = new Size(100, 22);
            StartValueText.TabIndex = 4;
            StartValueText.Text = "Старт шага:";
            // 
            // StopValueText
            // 
            StopValueText.BackColor = SystemColors.Control;
            StopValueText.BorderStyle = BorderStyle.None;
            StopValueText.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            StopValueText.Location = new Point(232, 381);
            StopValueText.Name = "StopValueText";
            StopValueText.ReadOnly = true;
            StopValueText.Size = new Size(100, 22);
            StopValueText.TabIndex = 5;
            StopValueText.Text = "Конец шага:";
            // 
            // InputStop
            // 
            InputStop.BackColor = SystemColors.Control;
            InputStop.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            InputStop.Location = new Point(232, 409);
            InputStop.Name = "InputStop";
            InputStop.Size = new Size(136, 29);
            InputStop.TabIndex = 6;
            // 
            // Reference
            // 
            Reference.BackColor = SystemColors.MenuHighlight;
            Reference.Font = new Font("Segoe UI", 12F);
            Reference.ForeColor = Color.Black;
            Reference.Location = new Point(395, 381);
            Reference.Name = "Reference";
            Reference.Size = new Size(105, 57);
            Reference.TabIndex = 7;
            Reference.Text = "Справка";
            Reference.UseVisualStyleBackColor = false;
            Reference.Click += Reference_Click;
            // 
            // Done
            // 
            Done.BackColor = Color.Lime;
            Done.Font = new Font("Segoe UI", 12F);
            Done.ForeColor = Color.Black;
            Done.Location = new Point(506, 381);
            Done.Name = "Done";
            Done.Size = new Size(105, 57);
            Done.TabIndex = 8;
            Done.Text = "Выполнить";
            Done.UseVisualStyleBackColor = false;
            Done.Click += Done_Click;
            Done.MouseHover += Done_MouseHover;
            // 
            // dataGridViewFunction
            // 
            dataGridViewFunction.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFunction.Columns.AddRange(new DataGridViewColumn[] { x, F });
            dataGridViewFunction.Location = new Point(643, 86);
            dataGridViewFunction.Name = "dataGridViewFunction";
            dataGridViewFunction.RowHeadersVisible = false;
            dataGridViewFunction.Size = new Size(189, 352);
            dataGridViewFunction.TabIndex = 9;
            // 
            // x
            // 
            x.HeaderText = "X";
            x.Name = "x";
            x.ReadOnly = true;
            x.Width = 73;
            // 
            // F
            // 
            F.HeaderText = "F(x)";
            F.Name = "F";
            F.Width = 73;
            // 
            // DataOutputText
            // 
            DataOutputText.BackColor = SystemColors.Control;
            DataOutputText.BorderStyle = BorderStyle.None;
            DataOutputText.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            DataOutputText.Location = new Point(643, 12);
            DataOutputText.Name = "DataOutputText";
            DataOutputText.ReadOnly = true;
            DataOutputText.Size = new Size(163, 26);
            DataOutputText.TabIndex = 10;
            DataOutputText.Text = "Вывод данных:";
            // 
            // ResultTextBox
            // 
            ResultTextBox.BackColor = SystemColors.Control;
            ResultTextBox.BorderStyle = BorderStyle.None;
            ResultTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            ResultTextBox.Location = new Point(643, 58);
            ResultTextBox.Name = "ResultTextBox";
            ResultTextBox.Size = new Size(100, 22);
            ResultTextBox.TabIndex = 11;
            ResultTextBox.Text = "Результат:";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(829, 86);
            chart1.Name = "chart1";
            chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chart1.Series.Add(series1);
            chart1.Size = new Size(455, 352);
            chart1.TabIndex = 12;
            chart1.Text = "chartFunction";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1286, 450);
            Controls.Add(chart1);
            Controls.Add(ResultTextBox);
            Controls.Add(DataOutputText);
            Controls.Add(dataGridViewFunction);
            Controls.Add(Done);
            Controls.Add(Reference);
            Controls.Add(InputStop);
            Controls.Add(StopValueText);
            Controls.Add(StartValueText);
            Controls.Add(InputStart);
            Controls.Add(DataEntryText);
            Controls.Add(ConditionTextBox);
            Controls.Add(ConditionText);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 2 | Вариант 13 | Важник Л. Н";
            ((System.ComponentModel.ISupportInitialize)dataGridViewFunction).EndInit();
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox ConditionText;
        private TextBox ConditionTextBox;
        private TextBox DataEntryText;
        private TextBox InputStart;
        private TextBox StartValueText;
        private TextBox StopValueText;
        private TextBox InputStop;
        private Button Reference;
        private Button Done;
        private DataGridView dataGridViewFunction;
        private TextBox DataOutputText;
        private TextBox ResultTextBox;
        private DataGridViewTextBoxColumn x;
        private DataGridViewTextBoxColumn F;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}
