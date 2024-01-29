
namespace insert_image_to_pdf
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.txtPageCount = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.txtNamesCount = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.btnTextFile = new System.Windows.Forms.Button();
            this.txtTextFile = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.pgbMain = new MetroFramework.Controls.MetroProgressBar();
            this.btnOutput = new System.Windows.Forms.Button();
            this.txtOutput = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.btnGenerate = new MetroFramework.Controls.MetroButton();
            this.btnPdf = new System.Windows.Forms.Button();
            this.txtPdf = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.bwMain = new System.ComponentModel.BackgroundWorker();
            this.btnClear = new MetroFramework.Controls.MetroButton();
            this.btnCancel = new MetroFramework.Controls.MetroButton();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.txtSuffix = new MetroFramework.Controls.MetroTextBox();
            this.rbSuffix = new MetroFramework.Controls.MetroRadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbTextFile = new MetroFramework.Controls.MetroRadioButton();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel1.Controls.Add(this.metroLabel7);
            this.metroPanel1.Controls.Add(this.groupBox1);
            this.metroPanel1.Controls.Add(this.txtSuffix);
            this.metroPanel1.Controls.Add(this.metroLabel6);
            this.metroPanel1.Controls.Add(this.btnCancel);
            this.metroPanel1.Controls.Add(this.btnClear);
            this.metroPanel1.Controls.Add(this.txtPageCount);
            this.metroPanel1.Controls.Add(this.metroLabel5);
            this.metroPanel1.Controls.Add(this.txtNamesCount);
            this.metroPanel1.Controls.Add(this.metroLabel4);
            this.metroPanel1.Controls.Add(this.btnTextFile);
            this.metroPanel1.Controls.Add(this.txtTextFile);
            this.metroPanel1.Controls.Add(this.metroLabel2);
            this.metroPanel1.Controls.Add(this.pgbMain);
            this.metroPanel1.Controls.Add(this.btnOutput);
            this.metroPanel1.Controls.Add(this.txtOutput);
            this.metroPanel1.Controls.Add(this.metroLabel3);
            this.metroPanel1.Controls.Add(this.btnGenerate);
            this.metroPanel1.Controls.Add(this.btnPdf);
            this.metroPanel1.Controls.Add(this.txtPdf);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.CustomBackground = false;
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel1.HorizontalScrollbar = false;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(20, 60);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(443, 444);
            this.metroPanel1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroPanel1.StyleManager = null;
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroPanel1.VerticalScrollbar = false;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // txtPageCount
            // 
            this.txtPageCount.Enabled = false;
            this.txtPageCount.FontSize = MetroFramework.MetroTextBoxSize.Small;
            this.txtPageCount.FontWeight = MetroFramework.MetroTextBoxWeight.Regular;
            this.txtPageCount.Location = new System.Drawing.Point(230, 68);
            this.txtPageCount.Multiline = false;
            this.txtPageCount.Name = "txtPageCount";
            this.txtPageCount.SelectedText = "";
            this.txtPageCount.Size = new System.Drawing.Size(75, 23);
            this.txtPageCount.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPageCount.StyleManager = null;
            this.txtPageCount.TabIndex = 19;
            this.txtPageCount.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPageCount.UseStyleColors = false;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.CustomBackground = false;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.metroLabel5.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.metroLabel5.Location = new System.Drawing.Point(139, 70);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(85, 19);
            this.metroLabel5.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel5.StyleManager = null;
            this.metroLabel5.TabIndex = 18;
            this.metroLabel5.Text = "Page count : ";
            this.metroLabel5.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel5.UseStyleColors = false;
            // 
            // txtNamesCount
            // 
            this.txtNamesCount.Enabled = false;
            this.txtNamesCount.FontSize = MetroFramework.MetroTextBoxSize.Small;
            this.txtNamesCount.FontWeight = MetroFramework.MetroTextBoxWeight.Regular;
            this.txtNamesCount.Location = new System.Drawing.Point(229, 260);
            this.txtNamesCount.Multiline = false;
            this.txtNamesCount.Name = "txtNamesCount";
            this.txtNamesCount.SelectedText = "";
            this.txtNamesCount.Size = new System.Drawing.Size(75, 23);
            this.txtNamesCount.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNamesCount.StyleManager = null;
            this.txtNamesCount.TabIndex = 17;
            this.txtNamesCount.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNamesCount.UseStyleColors = false;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.CustomBackground = false;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.metroLabel4.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.metroLabel4.Location = new System.Drawing.Point(127, 261);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(97, 19);
            this.metroLabel4.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel4.StyleManager = null;
            this.metroLabel4.TabIndex = 16;
            this.metroLabel4.Text = "Names count : ";
            this.metroLabel4.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel4.UseStyleColors = false;
            // 
            // btnTextFile
            // 
            this.btnTextFile.BackgroundImage = global::split_rename_pdf.Properties.Resources.magnifier;
            this.btnTextFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTextFile.Enabled = false;
            this.btnTextFile.Location = new System.Drawing.Point(366, 230);
            this.btnTextFile.Name = "btnTextFile";
            this.btnTextFile.Size = new System.Drawing.Size(39, 23);
            this.btnTextFile.TabIndex = 15;
            this.btnTextFile.UseVisualStyleBackColor = true;
            this.btnTextFile.Click += new System.EventHandler(this.btnTextFile_Click);
            // 
            // txtTextFile
            // 
            this.txtTextFile.Enabled = false;
            this.txtTextFile.FontSize = MetroFramework.MetroTextBoxSize.Small;
            this.txtTextFile.FontWeight = MetroFramework.MetroTextBoxWeight.Regular;
            this.txtTextFile.Location = new System.Drawing.Point(127, 230);
            this.txtTextFile.Multiline = false;
            this.txtTextFile.Name = "txtTextFile";
            this.txtTextFile.SelectedText = "";
            this.txtTextFile.Size = new System.Drawing.Size(223, 23);
            this.txtTextFile.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTextFile.StyleManager = null;
            this.txtTextFile.TabIndex = 14;
            this.txtTextFile.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTextFile.UseStyleColors = false;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.CustomBackground = false;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.metroLabel2.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.metroLabel2.Location = new System.Drawing.Point(54, 234);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(66, 19);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel2.StyleManager = null;
            this.metroLabel2.TabIndex = 13;
            this.metroLabel2.Text = "Text File : ";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel2.UseStyleColors = false;
            // 
            // pgbMain
            // 
            this.pgbMain.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pgbMain.FontSize = MetroFramework.MetroProgressBarSize.Medium;
            this.pgbMain.FontWeight = MetroFramework.MetroProgressBarWeight.Light;
            this.pgbMain.HideProgressText = true;
            this.pgbMain.Location = new System.Drawing.Point(33, 406);
            this.pgbMain.Name = "pgbMain";
            this.pgbMain.ProgressBarStyle = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pgbMain.Size = new System.Drawing.Size(374, 23);
            this.pgbMain.Style = MetroFramework.MetroColorStyle.Blue;
            this.pgbMain.StyleManager = null;
            this.pgbMain.TabIndex = 12;
            this.pgbMain.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.pgbMain.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // btnOutput
            // 
            this.btnOutput.BackgroundImage = global::split_rename_pdf.Properties.Resources.magnifier;
            this.btnOutput.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnOutput.Location = new System.Drawing.Point(366, 308);
            this.btnOutput.Name = "btnOutput";
            this.btnOutput.Size = new System.Drawing.Size(39, 23);
            this.btnOutput.TabIndex = 11;
            this.btnOutput.UseVisualStyleBackColor = true;
            this.btnOutput.Click += new System.EventHandler(this.btnOutput_Click);
            // 
            // txtOutput
            // 
            this.txtOutput.Enabled = false;
            this.txtOutput.FontSize = MetroFramework.MetroTextBoxSize.Small;
            this.txtOutput.FontWeight = MetroFramework.MetroTextBoxWeight.Regular;
            this.txtOutput.Location = new System.Drawing.Point(127, 308);
            this.txtOutput.Multiline = false;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.SelectedText = "";
            this.txtOutput.Size = new System.Drawing.Size(223, 23);
            this.txtOutput.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtOutput.StyleManager = null;
            this.txtOutput.TabIndex = 10;
            this.txtOutput.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtOutput.UseStyleColors = false;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.CustomBackground = false;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.metroLabel3.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.metroLabel3.Location = new System.Drawing.Point(31, 310);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(90, 19);
            this.metroLabel3.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel3.StyleManager = null;
            this.metroLabel3.TabIndex = 9;
            this.metroLabel3.Text = "Output Path : ";
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel3.UseStyleColors = false;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Highlight = false;
            this.btnGenerate.Location = new System.Drawing.Point(331, 357);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(75, 35);
            this.btnGenerate.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnGenerate.StyleManager = null;
            this.btnGenerate.TabIndex = 8;
            this.btnGenerate.Text = "&Generate";
            this.btnGenerate.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnPdf
            // 
            this.btnPdf.BackgroundImage = global::split_rename_pdf.Properties.Resources.magnifier;
            this.btnPdf.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPdf.Location = new System.Drawing.Point(367, 37);
            this.btnPdf.Name = "btnPdf";
            this.btnPdf.Size = new System.Drawing.Size(39, 23);
            this.btnPdf.TabIndex = 6;
            this.btnPdf.UseVisualStyleBackColor = true;
            this.btnPdf.Click += new System.EventHandler(this.btnPdf_Click);
            // 
            // txtPdf
            // 
            this.txtPdf.Enabled = false;
            this.txtPdf.FontSize = MetroFramework.MetroTextBoxSize.Small;
            this.txtPdf.FontWeight = MetroFramework.MetroTextBoxWeight.Regular;
            this.txtPdf.Location = new System.Drawing.Point(128, 37);
            this.txtPdf.Multiline = false;
            this.txtPdf.Name = "txtPdf";
            this.txtPdf.SelectedText = "";
            this.txtPdf.Size = new System.Drawing.Size(223, 23);
            this.txtPdf.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPdf.StyleManager = null;
            this.txtPdf.TabIndex = 4;
            this.txtPdf.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPdf.UseStyleColors = false;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.CustomBackground = false;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.metroLabel1.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.metroLabel1.Location = new System.Drawing.Point(54, 39);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(68, 19);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel1.StyleManager = null;
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "PDF File : ";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel1.UseStyleColors = false;
            // 
            // bwMain
            // 
            this.bwMain.WorkerReportsProgress = true;
            this.bwMain.WorkerSupportsCancellation = true;
            this.bwMain.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwMain_DoWork);
            this.bwMain.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bwMain_ProgressChanged);
            this.bwMain.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwMain_RunWorkerCompleted);
            // 
            // btnClear
            // 
            this.btnClear.Highlight = false;
            this.btnClear.Location = new System.Drawing.Point(250, 357);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 35);
            this.btnClear.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnClear.StyleManager = null;
            this.btnClear.TabIndex = 20;
            this.btnClear.Text = "&Clear";
            this.btnClear.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Highlight = false;
            this.btnCancel.Location = new System.Drawing.Point(169, 357);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 35);
            this.btnCancel.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnCancel.StyleManager = null;
            this.btnCancel.TabIndex = 21;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.CustomBackground = false;
            this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.metroLabel6.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.metroLabel6.Location = new System.Drawing.Point(70, 168);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(51, 19);
            this.metroLabel6.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel6.StyleManager = null;
            this.metroLabel6.TabIndex = 22;
            this.metroLabel6.Text = "Suffix : ";
            this.metroLabel6.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel6.UseStyleColors = false;
            // 
            // txtSuffix
            // 
            this.txtSuffix.FontSize = MetroFramework.MetroTextBoxSize.Small;
            this.txtSuffix.FontWeight = MetroFramework.MetroTextBoxWeight.Regular;
            this.txtSuffix.Location = new System.Drawing.Point(127, 167);
            this.txtSuffix.Multiline = false;
            this.txtSuffix.Name = "txtSuffix";
            this.txtSuffix.SelectedText = "";
            this.txtSuffix.Size = new System.Drawing.Size(223, 23);
            this.txtSuffix.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSuffix.StyleManager = null;
            this.txtSuffix.TabIndex = 23;
            this.txtSuffix.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSuffix.UseStyleColors = false;
            // 
            // rbSuffix
            // 
            this.rbSuffix.AutoSize = true;
            this.rbSuffix.Checked = true;
            this.rbSuffix.CustomBackground = false;
            this.rbSuffix.FontSize = MetroFramework.MetroLinkSize.Small;
            this.rbSuffix.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.rbSuffix.Location = new System.Drawing.Point(16, 19);
            this.rbSuffix.Name = "rbSuffix";
            this.rbSuffix.Size = new System.Drawing.Size(53, 15);
            this.rbSuffix.Style = MetroFramework.MetroColorStyle.Blue;
            this.rbSuffix.StyleManager = null;
            this.rbSuffix.TabIndex = 24;
            this.rbSuffix.TabStop = true;
            this.rbSuffix.Text = "Suffix";
            this.rbSuffix.Theme = MetroFramework.MetroThemeStyle.Light;
            this.rbSuffix.UseStyleColors = false;
            this.rbSuffix.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbTextFile);
            this.groupBox1.Controls.Add(this.rbSuffix);
            this.groupBox1.Location = new System.Drawing.Point(148, 109);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(190, 48);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Naming Option";
            // 
            // rbTextFile
            // 
            this.rbTextFile.AutoSize = true;
            this.rbTextFile.CustomBackground = false;
            this.rbTextFile.FontSize = MetroFramework.MetroLinkSize.Small;
            this.rbTextFile.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.rbTextFile.Location = new System.Drawing.Point(85, 19);
            this.rbTextFile.Name = "rbTextFile";
            this.rbTextFile.Size = new System.Drawing.Size(65, 15);
            this.rbTextFile.Style = MetroFramework.MetroColorStyle.Blue;
            this.rbTextFile.StyleManager = null;
            this.rbTextFile.TabIndex = 25;
            this.rbTextFile.Text = "Text File";
            this.rbTextFile.Theme = MetroFramework.MetroThemeStyle.Light;
            this.rbTextFile.UseStyleColors = false;
            this.rbTextFile.UseVisualStyleBackColor = true;
            this.rbTextFile.CheckedChanged += new System.EventHandler(this.rbTextFile_CheckedChanged);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.CustomBackground = false;
            this.metroLabel7.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.metroLabel7.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.metroLabel7.Location = new System.Drawing.Point(148, 193);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(178, 19);
            this.metroLabel7.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel7.StyleManager = null;
            this.metroLabel7.TabIndex = 26;
            this.metroLabel7.Text = "Suffix can\'t contain : \\/:*?\"<>|";
            this.metroLabel7.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel7.UseStyleColors = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 524);
            this.Controls.Add(this.metroPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(0, 0);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "PDF Splitter / Namer";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtPdf;
        private System.Windows.Forms.Button btnPdf;
        private MetroFramework.Controls.MetroButton btnGenerate;
        private System.Windows.Forms.Button btnOutput;
        private MetroFramework.Controls.MetroTextBox txtOutput;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroProgressBar pgbMain;
        private System.ComponentModel.BackgroundWorker bwMain;
        private System.Windows.Forms.Button btnTextFile;
        private MetroFramework.Controls.MetroTextBox txtTextFile;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtPageCount;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox txtNamesCount;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroButton btnClear;
        private MetroFramework.Controls.MetroButton btnCancel;
        private MetroFramework.Controls.MetroTextBox txtSuffix;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroRadioButton rbTextFile;
        private MetroFramework.Controls.MetroRadioButton rbSuffix;
        private MetroFramework.Controls.MetroLabel metroLabel7;
    }
}

