using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
using System.IO;
using BitMiracle.Docotic.Pdf;
using System.Diagnostics;

namespace EZPdfTextExtractor
{
    public partial class Form_extractor : Form
    {
        private bool fileselected;
        private string filename;

        public Form_extractor()
        {
            InitializeComponent();
        }

        private void button_start_Click(object sender, EventArgs e)
        {
            openpdf();
        }

        private void openpdf()
        {
            var file = new OpenFileDialog();
            file.Filter = "Pdf Files (*.pdf)|*.pdf|All Files (*.*)|*.*";
            if (file.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            StringBuilder sb = new StringBuilder();

            filename = file.FileName;
            fileselected = true;
        }

        private void Form_extractor_Load(object sender, EventArgs e)
        {
        }

        private void linkLabel_Github_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/Glumboi");
        }

        private void timer_OnTick_Tick(object sender, EventArgs e)
        {
            if (fileselected)
            {
                textBox_file.Text = filename;
            }
            else if (!fileselected)
            {
                textBox_file.Text = "No file selected...";
            }
        }

        private void button_extract_Click(object sender, EventArgs e)
        {
            extract();
        }

        private void extract()
        {
            if (filename == null)
            {
                MessageBox.Show("You do not have a file selected!");
            }
            else

                using (var pdf = new BitMiracle.Docotic.Pdf.PdfDocument(filename))
                {
                    //string Desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                    //string path = @"extracted.txt";
                    string formattedText = pdf.GetTextWithFormatting(); // or use pdf.Pages[i].GetTextWithFormatting()
                    Console.WriteLine(formattedText);
                    //Stream myStream;
                    SaveFileDialog save = new SaveFileDialog();
                    save.Filter = ".txt files (*.txt)|*.txt|All files (*.*)|*.*";
                    save.FilterIndex = 1;
                    if (save.ShowDialog() == DialogResult.OK)
                    {
                        string savelocation = save.FileName;
                        File.WriteAllText(savelocation, formattedText);
                    }
                }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/Glumboi/EZPdfExtractor");
        }
    }
}