using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Json_Converter
{
    public partial class JsonSelector : Form
    {
        string filePath = string.Empty;
        string fileContent = string.Empty;
        public JsonSelector()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                //openFileDialog.InitialDirectory = "C:\\Users/%USER%/Desktop";
                openFileDialog.Filter = "JSON file |*.json";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;

                    //Read the contents of the file into a stream
                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        fileContent = reader.ReadToEnd();
                        //txtShow.Text = fileContent;
                    }
                }
            }
            showFilepath();
            var decodedText = decode();
            txtShow.Text = decodedText;
        }

        private void showFilepath()
        {
            lblPath.Text = filePath;
            var filename = Path.GetFileName(filePath);
            lblPath.Text = filename;
            return;
        }
        
        private string decode()
        { //If file contains characters like \u00ce 
            Encoding targetEncoding = Encoding.GetEncoding("ISO-8859-1");
            var unescapeText = System.Text.RegularExpressions.Regex.Unescape(fileContent);
            return Encoding.UTF8.GetString(targetEncoding.GetBytes(unescapeText));
        }

        private void txtShow_TextChanged(object sender, EventArgs e)
        {
            txtShow.ScrollBars = ScrollBars.Vertical;
            txtShow.WordWrap = false;
        }
    }

    public static class Prompt
    {
        public static string ShowDialog(string text, string caption)
        {
            Form prompt = new Form()
            {
                Width = 500,
                Height = 150,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = caption,
                StartPosition = FormStartPosition.CenterScreen
            };
            Label textLabel = new Label() { Left = 50, Top = 20, Text = text };
            TextBox textBox = new TextBox() { Left = 50, Top = 50, Width = 400 };
            Button confirmation = new Button() { Text = "Ok", Left = 350, Width = 100, Top = 70, DialogResult = DialogResult.OK };
            confirmation.Click += (sender, e) => { prompt.Close(); };
            prompt.Controls.Add(textBox);
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(textLabel);
            prompt.AcceptButton = confirmation;

            return prompt.ShowDialog() == DialogResult.OK ? textBox.Text : "";
        }
    }
}
