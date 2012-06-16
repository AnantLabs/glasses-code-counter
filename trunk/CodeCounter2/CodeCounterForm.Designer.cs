namespace CodeCounter2
{
    partial class CodeCounterForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CodeCounterForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.btnBegin = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lbLines = new System.Windows.Forms.Label();
            this.lbCode = new System.Windows.Forms.Label();
            this.lbFolder = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbComments = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbProcessed = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lbWhitespace = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lbCodeFiles = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lbPhySize = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtCodeChar = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtCommentChar = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.lbStatus = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.workerLoadFiles = new System.ComponentModel.BackgroundWorker();
            this.workerCounter = new System.ComponentModel.BackgroundWorker();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lines of Text:";
            this.toolTip2.SetToolTip(this.label1, "The total number of lines of text in the file, whether they are blank lines (whit" +
                    "e space), comments, or actual code.");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Lines of Code:";
            this.toolTip1.SetToolTip(this.label2, resources.GetString("label2.ToolTip"));
            // 
            // toolTip1
            // 
            this.toolTip1.Tag = "";
            // 
            // btnBegin
            // 
            this.btnBegin.Location = new System.Drawing.Point(365, 281);
            this.btnBegin.Name = "btnBegin";
            this.btnBegin.Size = new System.Drawing.Size(139, 23);
            this.btnBegin.TabIndex = 1;
            this.btnBegin.Text = "Begin Counting";
            this.btnBegin.UseVisualStyleBackColor = true;
            this.btnBegin.Click += new System.EventHandler(this.btnBegin_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Folder:";
            // 
            // lbLines
            // 
            this.lbLines.Location = new System.Drawing.Point(27, 60);
            this.lbLines.Name = "lbLines";
            this.lbLines.Size = new System.Drawing.Size(218, 13);
            this.lbLines.TabIndex = 3;
            this.lbLines.Text = "...";
            this.lbLines.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbCode
            // 
            this.lbCode.Location = new System.Drawing.Point(27, 101);
            this.lbCode.Name = "lbCode";
            this.lbCode.Size = new System.Drawing.Size(218, 13);
            this.lbCode.TabIndex = 3;
            this.lbCode.Text = "...";
            this.lbCode.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbFolder
            // 
            this.lbFolder.AutoSize = true;
            this.lbFolder.Location = new System.Drawing.Point(57, 19);
            this.lbFolder.Name = "lbFolder";
            this.lbFolder.Size = new System.Drawing.Size(16, 13);
            this.lbFolder.TabIndex = 4;
            this.lbFolder.Text = "...";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 142);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Lines of Comments:";
            // 
            // lbComments
            // 
            this.lbComments.Location = new System.Drawing.Point(27, 142);
            this.lbComments.Name = "lbComments";
            this.lbComments.Size = new System.Drawing.Size(218, 13);
            this.lbComments.TabIndex = 3;
            this.lbComments.Text = "...";
            this.lbComments.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(260, 183);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Files Processed:";
            // 
            // lbProcessed
            // 
            this.lbProcessed.Location = new System.Drawing.Point(286, 183);
            this.lbProcessed.Name = "lbProcessed";
            this.lbProcessed.Size = new System.Drawing.Size(218, 13);
            this.lbProcessed.TabIndex = 3;
            this.lbProcessed.Text = "...";
            this.lbProcessed.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 183);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(107, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Lines of Whitespace:";
            // 
            // lbWhitespace
            // 
            this.lbWhitespace.Location = new System.Drawing.Point(27, 183);
            this.lbWhitespace.Name = "lbWhitespace";
            this.lbWhitespace.Size = new System.Drawing.Size(218, 13);
            this.lbWhitespace.TabIndex = 3;
            this.lbWhitespace.Text = "...";
            this.lbWhitespace.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(260, 60);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(86, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "Total Code Files:";
            // 
            // lbCodeFiles
            // 
            this.lbCodeFiles.Location = new System.Drawing.Point(286, 60);
            this.lbCodeFiles.Name = "lbCodeFiles";
            this.lbCodeFiles.Size = new System.Drawing.Size(218, 13);
            this.lbCodeFiles.TabIndex = 3;
            this.lbCodeFiles.Text = "...";
            this.lbCodeFiles.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(260, 101);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(99, 13);
            this.label15.TabIndex = 0;
            this.label15.Text = "Total Physical Size:";
            // 
            // lbPhySize
            // 
            this.lbPhySize.Location = new System.Drawing.Point(286, 101);
            this.lbPhySize.Name = "lbPhySize";
            this.lbPhySize.Size = new System.Drawing.Size(218, 13);
            this.lbPhySize.TabIndex = 3;
            this.lbPhySize.Text = "...";
            this.lbPhySize.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(12, 239);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(78, 13);
            this.label17.TabIndex = 5;
            this.label17.Text = "File Type Filter:";
            // 
            // txtFilter
            // 
            this.txtFilter.BackColor = System.Drawing.SystemColors.Control;
            this.txtFilter.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilter.ForeColor = System.Drawing.Color.Firebrick;
            this.txtFilter.Location = new System.Drawing.Point(127, 239);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(118, 13);
            this.txtFilter.TabIndex = 6;
            this.txtFilter.Text = "*.cs";
            this.txtFilter.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(12, 265);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(141, 13);
            this.label18.TabIndex = 5;
            this.label18.Text = "End of Code Line Character:";
            // 
            // txtCodeChar
            // 
            this.txtCodeChar.BackColor = System.Drawing.SystemColors.Control;
            this.txtCodeChar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCodeChar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodeChar.ForeColor = System.Drawing.Color.Firebrick;
            this.txtCodeChar.Location = new System.Drawing.Point(159, 265);
            this.txtCodeChar.Name = "txtCodeChar";
            this.txtCodeChar.Size = new System.Drawing.Size(86, 13);
            this.txtCodeChar.TabIndex = 6;
            this.txtCodeChar.Text = ";";
            this.txtCodeChar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(12, 291);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(158, 13);
            this.label19.TabIndex = 5;
            this.label19.Text = "Single Line Comment Character:";
            // 
            // txtCommentChar
            // 
            this.txtCommentChar.BackColor = System.Drawing.SystemColors.Control;
            this.txtCommentChar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCommentChar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCommentChar.ForeColor = System.Drawing.Color.Firebrick;
            this.txtCommentChar.Location = new System.Drawing.Point(176, 291);
            this.txtCommentChar.Name = "txtCommentChar";
            this.txtCommentChar.Size = new System.Drawing.Size(69, 13);
            this.txtCommentChar.TabIndex = 6;
            this.txtCommentChar.Text = "//";
            this.txtCommentChar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(260, 142);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(40, 13);
            this.label20.TabIndex = 7;
            this.label20.Text = "Status:";
            // 
            // lbStatus
            // 
            this.lbStatus.Location = new System.Drawing.Point(286, 142);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(218, 13);
            this.lbStatus.TabIndex = 3;
            this.lbStatus.Text = "...";
            this.lbStatus.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.Description = "Select the folder that contains the code files you want to count.";
            // 
            // workerLoadFiles
            // 
            this.workerLoadFiles.WorkerReportsProgress = true;
            this.workerLoadFiles.DoWork += new System.ComponentModel.DoWorkEventHandler(this.workerLoadFiles_DoWork);
            this.workerLoadFiles.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.workerLoadFiles_ProgressChanged);
            this.workerLoadFiles.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.workerLoadFiles_RunWorkerCompleted);
            // 
            // workerCounter
            // 
            this.workerCounter.WorkerReportsProgress = true;
            this.workerCounter.DoWork += new System.ComponentModel.DoWorkEventHandler(this.workerCounter_DoWork);
            this.workerCounter.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.workerCounter_ProgressChanged);
            this.workerCounter.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.workerCounter_RunWorkerCompleted);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label4.Location = new System.Drawing.Point(407, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Scott Clayton 2011";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CodeCounter2.Properties.Resources.glasses2;
            this.pictureBox1.Location = new System.Drawing.Point(280, 240);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // CodeCounterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 330);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.txtCommentChar);
            this.Controls.Add(this.txtCodeChar);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.btnBegin);
            this.Controls.Add(this.lbFolder);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbPhySize);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.lbProcessed);
            this.Controls.Add(this.lbComments);
            this.Controls.Add(this.lbCode);
            this.Controls.Add(this.lbCodeFiles);
            this.Controls.Add(this.lbWhitespace);
            this.Controls.Add(this.lbLines);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CodeCounterForm";
            this.Text = "Glasses Code Counter";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.Button btnBegin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbLines;
        private System.Windows.Forms.Label lbCode;
        private System.Windows.Forms.Label lbFolder;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbComments;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbProcessed;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbWhitespace;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lbCodeFiles;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lbPhySize;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtCodeChar;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtCommentChar;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.ComponentModel.BackgroundWorker workerLoadFiles;
        private System.ComponentModel.BackgroundWorker workerCounter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

