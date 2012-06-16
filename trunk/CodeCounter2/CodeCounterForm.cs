using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

// CHANGES:
// ----------------------------------------------------------------------------
// 04/22/2011 - Scott - Fist written
// 06/16/2012 - Scott - Code reformatted, cleaned up, and posted on Google Code

namespace CodeCounter2
{
    public partial class CodeCounterForm : Form
    {
        string[] files;
        string directory;
        string pattern;
        string commentChar;
        string endOfCodeLineChar;

        bool cont;

        int lines;
        int whitespace;
        int code;
        int comments;
        long bytes;

        public CodeCounterForm()
        {
            InitializeComponent();
        }

        private void btnBegin_Click(object sender, EventArgs e)
        {
            DialogResult d = folderBrowserDialog1.ShowDialog();
            if (d == DialogResult.OK)
            {
                btnBegin.Enabled = false;
                txtCodeChar.Enabled = false;
                txtCommentChar.Enabled = false;
                txtFilter.Enabled = false;
                pictureBox1.Visible = true;

                directory = folderBrowserDialog1.SelectedPath;
                pattern = txtFilter.Text;
                commentChar = txtCommentChar.Text;
                endOfCodeLineChar = txtCodeChar.Text;

                if (directory.Length > 75)
                {
                    lbFolder.Text = directory.Substring(0, 75) + "...";
                }
                else
                {
                    lbFolder.Text = directory;
                }
                lbStatus.Text = "Finding Files";

                workerLoadFiles.RunWorkerAsync();
            }
        }

        private void workerLoadFiles_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                cont = true;
                files = Directory.GetFiles(directory, pattern, SearchOption.AllDirectories);
            }
            catch
            {
                cont = false;
                workerLoadFiles.ReportProgress(1);
            }
        }

        private void workerLoadFiles_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (cont)
            {
                lbCodeFiles.Text = files.Length.ToString();
                lbStatus.Text = "Counting Lines";
                workerCounter.RunWorkerAsync();
            }
            else
            {
                lbStatus.Text = "Error";
            }
        }

        private void workerLoadFiles_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (e.ProgressPercentage == 1)
            {
                lbStatus.Text = "Error";
                MessageBox.Show("There was an error finding files that match the file filter you specified.", "Code Counter 2", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void workerCounter_DoWork(object sender, DoWorkEventArgs e)
        {
            code = 0;
            lines = 0;
            whitespace = 0;
            comments = 0;
            bytes = 0;

            for (int i = 0; i < files.Length; i++)
            {
                StreamReader r = new StreamReader(new FileStream(files[i], FileMode.Open, FileAccess.Read));

                string line;

                while ((line = r.ReadLine()) != null)
                {
                    lines++;
                    bytes += line.Length;

                    if (line.Replace(" ", "").Replace("\t", "").StartsWith(commentChar))
                    {
                        comments++;
                    }
                    else if (line.Replace(" ", "").Replace("\t", "").EndsWith(")"))
                    {
                        code++;
                    }
                    else if (line.Replace(" ", "").Replace("\t", "").EndsWith("{"))
                    {
                        code++;
                    }
                    else if (line.Replace(" ", "").Replace("\t", "").EndsWith("}"))
                    {
                        code++;
                    }
                    else if (line.Contains(endOfCodeLineChar))
                    {
                        code++;
                    }
                    else if (line.Replace(" ", "").Replace("\t", "") == "")
                    {
                        whitespace++;
                    }
                    else
                    {
                        // Assume all non-whitespace and non-comments are code.
                        code++;
                    }
                }

                r.Close();

                workerCounter.ReportProgress(i + 1);
            }
        }

        private void workerCounter_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            double percent = 100.0;
            if (files.Length > 0)
            {
                percent = ((double)e.ProgressPercentage / (double)files.Length) * 100.0;
            }

            lbProcessed.Text = e.ProgressPercentage.ToString() + "/" + files.Length.ToString() + " (" + percent.ToString("0.00") + "%)";

            if (endOfCodeLineChar.Length == 0)
            {
                lbCode.Text = "Not Specified";
            }
            else
            {
                lbCode.Text = code.ToString("#,##0");
            }
            if (commentChar.Length == 0)
            {
                lbComments.Text = "Not Specified";
            }
            else
            {
                lbComments.Text = comments.ToString("#,##0");
            }

            lbWhitespace.Text = whitespace.ToString("#,##0");
            lbLines.Text = lines.ToString("#,##0");
            lbPhySize.Text = GetSizeString(bytes);
        }

        private string GetSizeString(long bytes)
        {
            int up = 0;
            double num = bytes;
            while (num >= 1024.0)
            {
                up++;
                num /= 1024.0;
            }
            string end = "Bytes";
            if (up == 1)
            {
                end = "KB";
            }
            else if (up == 2)
            {
                end = "MB";
            }
            else if (up == 3)
            {
                end = "GB";
            }
            else if (up == 4)
            {
                end = "TB";
            }
            return num.ToString("0.00") + " " + end;
        }

        private void workerCounter_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            btnBegin.Enabled = true;
            txtCodeChar.Enabled = true;
            txtCommentChar.Enabled = true;
            txtFilter.Enabled = true;
            pictureBox1.Visible = false;

            lbStatus.Text = "Done";
        }
    }
}
