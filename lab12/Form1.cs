using System.IO;
using Microsoft.Office.Interop.Word;

namespace lab12
{
    public partial class Form1 : Form
    {
        private string templatesPath = @"C:\Users\Алексей\Desktop\OOP\Templates\";


        public Form1()
        {
            InitializeComponent();
            LoadTemplates();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void LoadTemplates()
        {
            var files = Directory.GetFiles(templatesPath, "*.docx");
            foreach (var file in files)
            {
                comboBoxTemplates.Items.Add(Path.GetFileName(file));
            }
            if (comboBoxTemplates.Items.Count > 0)
                comboBoxTemplates.SelectedIndex = 0;
        }

        private void buttonPreview_Click(object sender, EventArgs e)
        {
            string selectedTemplate = Path.Combine(templatesPath, comboBoxTemplates.SelectedItem.ToString());
            System.Diagnostics.Process.Start(selectedTemplate);
        }

        private void buttonSavePath_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Word Documents (*.docx)|*.docx";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    textBoxSavePath.Text = saveFileDialog.FileName;
                }
            }
        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            string selectedTemplate = Path.Combine(templatesPath, comboBoxTemplates.SelectedItem.ToString());
            string savePath = textBoxSavePath.Text;

            if (string.IsNullOrEmpty(savePath))
            {
                MessageBox.Show("Please select a save path.");
                return;
            }

            GenerateDocument(selectedTemplate, savePath);
        }

        private void GenerateDocument(string templatePath, string savePath)
        {
            var wordApp = new Microsoft.Office.Interop.Word.Application();
            Document doc = null;

            try
            {
                doc = wordApp.Documents.Open(templatePath);
                foreach (Field field in doc.Fields)
                {
                    if (field.Code.Text.Contains("MERGEFIELD"))
                    {
                        string fieldName = field.Code.Text.Split(' ')[1].Trim();
                        switch (fieldName)
                        {
                            case "Name":
                                field.Result.Text = textBoxName.Text;
                                break;
                            case "Date":
                                field.Result.Text = dateTimePickerDate.Value.ToString("MMMM dd, yyyy");
                                break;
                            case "Time":
                                field.Result.Text = textBoxTime.Text;
                                break;
                            case "Location":
                                field.Result.Text = textBoxLocation.Text;
                                break;
                        }
                    }
                }
                doc.SaveAs2(savePath);
                MessageBox.Show("Document generated successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (doc != null)
                    doc.Close();
                wordApp.Quit();
            }
        }
    }
}
