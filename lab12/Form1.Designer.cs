namespace lab12
{
    partial class Form1
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
            comboBoxTemplates = new ComboBox();
            buttonPreview = new Button();
            label1 = new Label();
            textBoxName = new TextBox();
            label2 = new Label();
            textBoxLocation = new TextBox();
            label3 = new Label();
            textBoxTime = new TextBox();
            label4 = new Label();
            dateTimePickerDate = new DateTimePicker();
            buttonGenerate = new Button();
            buttonSavePath = new Button();
            textBoxSavePath = new TextBox();
            SuspendLayout();
            // 
            // comboBoxTemplates
            // 
            comboBoxTemplates.FormattingEnabled = true;
            comboBoxTemplates.Location = new Point(12, 12);
            comboBoxTemplates.Name = "comboBoxTemplates";
            comboBoxTemplates.Size = new Size(121, 23);
            comboBoxTemplates.TabIndex = 0;
            // 
            // buttonPreview
            // 
            buttonPreview.Location = new Point(151, 12);
            buttonPreview.Name = "buttonPreview";
            buttonPreview.Size = new Size(75, 23);
            buttonPreview.TabIndex = 1;
            buttonPreview.Text = "Перегляд";
            buttonPreview.UseVisualStyleBackColor = true;
            buttonPreview.Click += buttonPreview_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(107, 90);
            label1.Name = "label1";
            label1.Size = new Size(28, 15);
            label1.TabIndex = 2;
            label1.Text = "Ім'я";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(73, 108);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(100, 23);
            textBoxName.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(107, 152);
            label2.Name = "label2";
            label2.Size = new Size(32, 15);
            label2.TabIndex = 4;
            label2.Text = "Дата";
            // 
            // textBoxLocation
            // 
            textBoxLocation.Location = new Point(73, 298);
            textBoxLocation.Name = "textBoxLocation";
            textBoxLocation.Size = new Size(100, 23);
            textBoxLocation.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(98, 280);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 8;
            label3.Text = "Локація";
            // 
            // textBoxTime
            // 
            textBoxTime.Location = new Point(73, 236);
            textBoxTime.Name = "textBoxTime";
            textBoxTime.Size = new Size(100, 23);
            textBoxTime.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(107, 218);
            label4.Name = "label4";
            label4.Size = new Size(27, 15);
            label4.TabIndex = 6;
            label4.Text = "Час";
            // 
            // dateTimePickerDate
            // 
            dateTimePickerDate.Location = new Point(31, 179);
            dateTimePickerDate.Name = "dateTimePickerDate";
            dateTimePickerDate.Size = new Size(200, 23);
            dateTimePickerDate.TabIndex = 10;
            // 
            // buttonGenerate
            // 
            buttonGenerate.Location = new Point(47, 350);
            buttonGenerate.Name = "buttonGenerate";
            buttonGenerate.Size = new Size(160, 76);
            buttonGenerate.TabIndex = 11;
            buttonGenerate.Text = "Згенерувати";
            buttonGenerate.UseVisualStyleBackColor = true;
            buttonGenerate.Click += buttonGenerate_Click;
            // 
            // buttonSavePath
            // 
            buttonSavePath.Location = new Point(268, 46);
            buttonSavePath.Name = "buttonSavePath";
            buttonSavePath.Size = new Size(358, 76);
            buttonSavePath.TabIndex = 12;
            buttonSavePath.Text = "Обрати шлях для збереження";
            buttonSavePath.UseVisualStyleBackColor = true;
            buttonSavePath.Click += buttonSavePath_Click;
            // 
            // textBoxSavePath
            // 
            textBoxSavePath.Location = new Point(268, 12);
            textBoxSavePath.Name = "textBoxSavePath";
            textBoxSavePath.Size = new Size(358, 23);
            textBoxSavePath.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(658, 450);
            Controls.Add(textBoxSavePath);
            Controls.Add(buttonSavePath);
            Controls.Add(buttonGenerate);
            Controls.Add(dateTimePickerDate);
            Controls.Add(textBoxLocation);
            Controls.Add(label3);
            Controls.Add(textBoxTime);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(textBoxName);
            Controls.Add(label1);
            Controls.Add(buttonPreview);
            Controls.Add(comboBoxTemplates);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxTemplates;
        private Button buttonPreview;
        private Label label1;
        private TextBox textBoxName;
        private Label label2;
        private TextBox textBoxLocation;
        private Label label3;
        private TextBox textBoxTime;
        private Label label4;
        private DateTimePicker dateTimePickerDate;
        private Button buttonGenerate;
        private Button buttonSavePath;
        private TextBox textBoxSavePath;
    }
}
