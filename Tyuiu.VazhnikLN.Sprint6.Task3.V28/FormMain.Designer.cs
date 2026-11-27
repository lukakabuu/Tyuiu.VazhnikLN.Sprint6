namespace Tyuiu.VazhnikLN.Spint6.Task3.V28
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
            Condition = new TextBox();
            ConditionText = new TextBox();
            dataGridView = new DataGridView();
            Done = new Button();
            Help = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // Condition
            // 
            Condition.BackColor = SystemColors.Control;
            Condition.BorderStyle = BorderStyle.None;
            Condition.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Condition.Location = new Point(25, 31);
            Condition.Name = "Condition";
            Condition.ReadOnly = true;
            Condition.Size = new Size(100, 26);
            Condition.TabIndex = 0;
            Condition.Text = "Условие:";
            // 
            // ConditionText
            // 
            ConditionText.BackColor = SystemColors.Control;
            ConditionText.BorderStyle = BorderStyle.None;
            ConditionText.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ConditionText.Location = new Point(25, 63);
            ConditionText.Multiline = true;
            ConditionText.Name = "ConditionText";
            ConditionText.ReadOnly = true;
            ConditionText.Size = new Size(603, 221);
            ConditionText.TabIndex = 1;
            ConditionText.Text = resources.GetString("ConditionText.Text");
            // 
            // dataGridView
            // 
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(669, 63);
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.Size = new Size(400, 250);
            dataGridView.TabIndex = 2;
            // 
            // Done
            // 
            Done.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Done.Location = new Point(494, 380);
            Done.Name = "Done";
            Done.Size = new Size(134, 58);
            Done.TabIndex = 3;
            Done.Text = "Выполнить";
            Done.UseVisualStyleBackColor = true;
            Done.Click += Done_Click;
            // 
            // Help
            // 
            Help.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Help.Location = new Point(371, 380);
            Help.Name = "Help";
            Help.Size = new Size(117, 58);
            Help.TabIndex = 4;
            Help.Text = "Справка";
            Help.UseVisualStyleBackColor = true;
            Help.Click += Help_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1115, 450);
            Controls.Add(Help);
            Controls.Add(Done);
            Controls.Add(dataGridView);
            Controls.Add(ConditionText);
            Controls.Add(Condition);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 3 | Вариант 28 | Важник Л.Н";
            Load += FormMain_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Condition;
        private TextBox ConditionText;
        private DataGridView dataGridView;
        private Button Done;
        private Button Help;
    }
}
