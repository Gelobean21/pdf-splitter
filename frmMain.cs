using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetroFramework.Forms;
using System.Windows.Forms;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.IO;
using Image = iTextSharp.text.Image;

namespace insert_image_to_pdf
{
    public partial class frmMain : MetroForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

        string pdfPath = string.Empty;
        string outputPath = string.Empty;
        string textFilePath = string.Empty;
        int filename = 1;

        private void frmMain_Load(object sender, EventArgs e)
        {

        }
        
        private void generatePDF()
        {
            int interval = 1;

            PdfReader reader = new PdfReader(pdfPath);

            string pdfFileName = txtSuffix.Text;


            for (int pageNumber = 1; pageNumber <= reader.NumberOfPages; pageNumber += interval)
            {
                string newPdfFileName = "";


                if (txtTextFile.Text == "")
                {
                    newPdfFileName = filename + pdfFileName;
                    filename++;
                }
                else
                {
                    newPdfFileName = getPdfNames()[pageNumber - 1];
                }

                if (isValidFileName(newPdfFileName))
                {
                    SplitAndSaveInterval(pdfPath, outputPath, pageNumber, interval, newPdfFileName);
                }

                bwMain.ReportProgress(pageNumber + 1);
            }
            
            bwMain.ReportProgress(100);
            filename = 1;
        }

        private string[] getPdfNames()
        {
            string[] lines = File.ReadAllLines(textFilePath);
            return lines;
        }

        void SplitAndSaveInterval(string pdfFilePath, string outputPath, int startPage, int interval, string pdfFileName)
        {
            using (PdfReader reader = new PdfReader(pdfFilePath))
            {
                Document document = new Document();
                PdfCopy copy = new PdfCopy(document, new FileStream(outputPath + "\\" + pdfFileName + ".pdf", FileMode.Create));
                document.Open();

                for (int pagenumber = startPage; pagenumber < (startPage + interval); pagenumber++)
                {
                    if (reader.NumberOfPages >= pagenumber)
                    {
                        copy.AddPage(copy.GetImportedPage(reader, pagenumber));
                    }
                    else
                    {
                        break;
                    }

                }
                document.Close();
            }
        }

        private bool isTextinTextFilesValid(string textfile)
        {
            bool retval = true;

            if (File.Exists(textfile))
            {
                string[] lines = File.ReadAllLines(textfile);

                for(int i = 0; i < lines.Length; i++)
                {
                    if (!isValidFileName(lines[i]))
                    {
                        return false;
                    }
                }
            }

            return retval;
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if(Directory.Exists(outputPath)) 
            {
                if (File.Exists(pdfPath))
                {
                    if (rbSuffix.Checked)
                    {
                        if (isValidFileName(txtSuffix.Text))
                        {
                            int pageCount = 0;
                            int.TryParse(txtPageCount.Text, out pageCount);
                            ManageProgressbar(pgbMain, pageCount);
                            bwMain.RunWorkerAsync();
                        }
                        else
                        {
                            MessageBox.Show("Suffix is not a valid file name, please change", "Close Window",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else  // rbtextfile is checked
                    {
                        int totalPage = 0;
                        int.TryParse(txtPageCount.Text, out totalPage);
                        int totalNames = 0;
                        int.TryParse(txtNamesCount.Text, out totalNames);

                        if (totalPage == totalNames)
                        {
                            ManageProgressbar(pgbMain, getPdfNames().Length);
                            bwMain.RunWorkerAsync();
                        }
                        else
                        {
                            MessageBox.Show("Number of pages must be equal to Number of rows in text file", "Close Window",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                }
                else
                {
                    MessageBox.Show("PDF File doesn't exists", "Close Window", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Output Path doesn't exists", "Close Window", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool isValidFileName(string filename)
        {
            char[] pattern = Path.GetInvalidFileNameChars();
            return !filename.Any(pattern.Contains);
        }

        private void bwMain_DoWork(object sender, DoWorkEventArgs e)
        {
            generatePDF();

            if (bwMain.CancellationPending)
            {
                e.Cancel = true;
            }
        }

        private void bwMain_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            pgbMain.Value = e.ProgressPercentage;
        }

        private void bwMain_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                MessageBox.Show("Process was cancelled", "Close Window", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (e.Error != null)
            {
                //"There was an error running the process. The thread aborted";
            }
            else
            {
                MessageBox.Show("Process was completed", "Close Window", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            pgbMain.Value = 0;
            ClearAll();
        }

        private void ManageProgressbar(ProgressBar pgb, int max)
        {
            pgb.Invoke((MethodInvoker)delegate
            {
                pgb.Minimum = 0;
                pgb.Maximum = max;
                pgb.Value = 0;
                pgb.Step = 1;
            });
        }

        private void btnPdf_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "PDF File (*.pdf) |*.pdf";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    pdfPath = ofd.FileName;
                    txtPdf.Text = pdfPath;
                    PdfReader reader = new PdfReader(pdfPath);
                    txtPageCount.Text = reader.NumberOfPages.ToString();
                }
            }
        }

        private void btnTextFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Text File (*.txt) |*.txt";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    if (!isTextinTextFilesValid(ofd.FileName))
                    {
                        MessageBox.Show("There is invalid file name inside text file, please check", "Close Windows",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        textFilePath = ofd.FileName;
                        txtTextFile.Text = textFilePath;
                        txtNamesCount.Text = getPdfNames().Length.ToString();
                    }
                }
            }
        }

        private void btnOutput_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    outputPath = fbd.SelectedPath;
                    txtOutput.Text = outputPath;
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void ClearAll()
        {
            txtNamesCount.Text = "";
            txtOutput.Text = "";
            txtPageCount.Text = "";
            txtPdf.Text = "";
            txtTextFile.Text = "";
            pdfPath = "";
            outputPath = "";
            textFilePath = "";
            pgbMain.Value = 0;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            bwMain.CancelAsync();
        }

        private void rbTextFile_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTextFile.Checked)
            {
                btnTextFile.Enabled = true;
                txtSuffix.Text = "";
                txtSuffix.Enabled = false;
            }
            else
            {
                btnTextFile.Enabled = false;
                txtSuffix.Enabled = true;
                txtTextFile.Text = "";
                textFilePath = "";
                txtNamesCount.Text = "";
            }
        }
    }
}
