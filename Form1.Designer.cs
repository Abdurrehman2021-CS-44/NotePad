
namespace NotePad
{
    partial class frmNotePad
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.cmbSaveFile = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnUnderline = new System.Windows.Forms.Button();
            this.btnItalic = new System.Windows.Forms.Button();
            this.btnBold = new System.Windows.Forms.Button();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.cmbFontSize = new System.Windows.Forms.ComboBox();
            this.lblFSize = new System.Windows.Forms.Label();
            this.cmbFonts = new System.Windows.Forms.ComboBox();
            this.lblFont = new System.Windows.Forms.Label();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.lblWord = new System.Windows.Forms.Label();
            this.lblWordCounter = new System.Windows.Forms.Label();
            this.lblLinesCount = new System.Windows.Forms.Label();
            this.lblLineCounter = new System.Windows.Forms.Label();
            this.rtb1 = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel5, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.rtb1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.32461F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 81.67539F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(646, 412);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.34375F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 82.65625F));
            this.tableLayoutPanel2.Controls.Add(this.cmbSaveFile, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 1, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(640, 64);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // cmbSaveFile
            // 
            this.cmbSaveFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbSaveFile.FormattingEnabled = true;
            this.cmbSaveFile.Location = new System.Drawing.Point(3, 5);
            this.cmbSaveFile.Name = "cmbSaveFile";
            this.cmbSaveFile.Size = new System.Drawing.Size(105, 21);
            this.cmbSaveFile.TabIndex = 0;
            this.cmbSaveFile.SelectedIndexChanged += new System.EventHandler(this.cmbSaveFile_SelectedIndexChanged);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel3.Controls.Add(this.btnUnderline, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnItalic, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnBold, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 35);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(105, 26);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // btnUnderline
            // 
            this.btnUnderline.BackColor = System.Drawing.Color.White;
            this.btnUnderline.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUnderline.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUnderline.Location = new System.Drawing.Point(75, 3);
            this.btnUnderline.Name = "btnUnderline";
            this.btnUnderline.Size = new System.Drawing.Size(27, 20);
            this.btnUnderline.TabIndex = 5;
            this.btnUnderline.Text = "U";
            this.btnUnderline.UseVisualStyleBackColor = false;
            this.btnUnderline.Click += new System.EventHandler(this.btnUnderline_Click);
            // 
            // btnItalic
            // 
            this.btnItalic.BackColor = System.Drawing.Color.White;
            this.btnItalic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnItalic.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnItalic.Location = new System.Drawing.Point(39, 3);
            this.btnItalic.Name = "btnItalic";
            this.btnItalic.Size = new System.Drawing.Size(30, 20);
            this.btnItalic.TabIndex = 4;
            this.btnItalic.Text = "l";
            this.btnItalic.UseVisualStyleBackColor = false;
            this.btnItalic.Click += new System.EventHandler(this.btnItalic_Click);
            // 
            // btnBold
            // 
            this.btnBold.BackColor = System.Drawing.Color.White;
            this.btnBold.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBold.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBold.Location = new System.Drawing.Point(3, 3);
            this.btnBold.Name = "btnBold";
            this.btnBold.Size = new System.Drawing.Size(30, 20);
            this.btnBold.TabIndex = 3;
            this.btnBold.Text = "B";
            this.btnBold.UseVisualStyleBackColor = false;
            this.btnBold.Click += new System.EventHandler(this.btnBold_Click);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 5;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.02083F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.97917F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 66F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 105F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 179F));
            this.tableLayoutPanel4.Controls.Add(this.cmbFontSize, 3, 0);
            this.tableLayoutPanel4.Controls.Add(this.lblFSize, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.cmbFonts, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.lblFont, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(114, 35);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(523, 26);
            this.tableLayoutPanel4.TabIndex = 2;
            // 
            // cmbFontSize
            // 
            this.cmbFontSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbFontSize.FormattingEnabled = true;
            this.cmbFontSize.Location = new System.Drawing.Point(241, 3);
            this.cmbFontSize.Name = "cmbFontSize";
            this.cmbFontSize.Size = new System.Drawing.Size(99, 21);
            this.cmbFontSize.TabIndex = 6;
            this.cmbFontSize.Text = "10";
            this.cmbFontSize.SelectedIndexChanged += new System.EventHandler(this.cmbFontSize_SelectedIndexChanged);
            // 
            // lblFSize
            // 
            this.lblFSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFSize.AutoSize = true;
            this.lblFSize.BackColor = System.Drawing.Color.Transparent;
            this.lblFSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFSize.Location = new System.Drawing.Point(175, 6);
            this.lblFSize.Name = "lblFSize";
            this.lblFSize.Size = new System.Drawing.Size(60, 13);
            this.lblFSize.TabIndex = 5;
            this.lblFSize.Text = "Font Size";
            this.lblFSize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbFonts
            // 
            this.cmbFonts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbFonts.FormattingEnabled = true;
            this.cmbFonts.Location = new System.Drawing.Point(68, 3);
            this.cmbFonts.Name = "cmbFonts";
            this.cmbFonts.Size = new System.Drawing.Size(101, 21);
            this.cmbFonts.TabIndex = 4;
            this.cmbFonts.Text = "Calbiri";
            this.cmbFonts.SelectedIndexChanged += new System.EventHandler(this.cmbFonts_SelectedIndexChanged);
            // 
            // lblFont
            // 
            this.lblFont.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFont.AutoSize = true;
            this.lblFont.BackColor = System.Drawing.Color.Transparent;
            this.lblFont.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFont.Location = new System.Drawing.Point(3, 0);
            this.lblFont.Name = "lblFont";
            this.lblFont.Size = new System.Drawing.Size(59, 26);
            this.lblFont.TabIndex = 1;
            this.lblFont.Text = "Font Family";
            this.lblFont.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tableLayoutPanel5.ColumnCount = 5;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.11267F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.88733F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 472F));
            this.tableLayoutPanel5.Controls.Add(this.lblWord, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.lblWordCounter, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.lblLinesCount, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.lblLineCounter, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 385);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(640, 24);
            this.tableLayoutPanel5.TabIndex = 1;
            // 
            // lblWord
            // 
            this.lblWord.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWord.AutoSize = true;
            this.lblWord.BackColor = System.Drawing.Color.Transparent;
            this.lblWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWord.Location = new System.Drawing.Point(84, 5);
            this.lblWord.Name = "lblWord";
            this.lblWord.Size = new System.Drawing.Size(38, 13);
            this.lblWord.TabIndex = 5;
            this.lblWord.Text = "Word";
            this.lblWord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblWordCounter
            // 
            this.lblWordCounter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWordCounter.AutoSize = true;
            this.lblWordCounter.BackColor = System.Drawing.Color.Transparent;
            this.lblWordCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWordCounter.Location = new System.Drawing.Point(128, 5);
            this.lblWordCounter.Name = "lblWordCounter";
            this.lblWordCounter.Size = new System.Drawing.Size(36, 13);
            this.lblWordCounter.TabIndex = 4;
            this.lblWordCounter.Text = "-";
            this.lblWordCounter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLinesCount
            // 
            this.lblLinesCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLinesCount.AutoSize = true;
            this.lblLinesCount.BackColor = System.Drawing.Color.Transparent;
            this.lblLinesCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLinesCount.Location = new System.Drawing.Point(3, 5);
            this.lblLinesCount.Name = "lblLinesCount";
            this.lblLinesCount.Size = new System.Drawing.Size(36, 13);
            this.lblLinesCount.TabIndex = 3;
            this.lblLinesCount.Text = "Lines";
            this.lblLinesCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLineCounter
            // 
            this.lblLineCounter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLineCounter.AutoSize = true;
            this.lblLineCounter.BackColor = System.Drawing.Color.Transparent;
            this.lblLineCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLineCounter.Location = new System.Drawing.Point(45, 5);
            this.lblLineCounter.Name = "lblLineCounter";
            this.lblLineCounter.Size = new System.Drawing.Size(33, 13);
            this.lblLineCounter.TabIndex = 2;
            this.lblLineCounter.Text = "-";
            this.lblLineCounter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rtb1
            // 
            this.rtb1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtb1.Location = new System.Drawing.Point(3, 73);
            this.rtb1.Name = "rtb1";
            this.rtb1.Size = new System.Drawing.Size(640, 306);
            this.rtb1.TabIndex = 2;
            this.rtb1.Text = "";
            this.rtb1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // frmNotePad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 412);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.Name = "frmNotePad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Note Pad";
            this.Load += new System.EventHandler(this.frmNotePad_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ComboBox cmbSaveFile;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.ComboBox cmbFontSize;
        private System.Windows.Forms.Label lblFSize;
        private System.Windows.Forms.ComboBox cmbFonts;
        private System.Windows.Forms.Label lblFont;
        private System.Windows.Forms.RichTextBox rtb1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label lblWord;
        private System.Windows.Forms.Label lblWordCounter;
        private System.Windows.Forms.Label lblLinesCount;
        private System.Windows.Forms.Label lblLineCounter;
        private System.Windows.Forms.Button btnBold;
        private System.Windows.Forms.Button btnUnderline;
        private System.Windows.Forms.Button btnItalic;
    }
}

