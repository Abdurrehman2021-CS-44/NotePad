using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotePad
{
    public partial class frmNotePad : Form
    {
        public frmNotePad()
        {
            InitializeComponent();
        }

        private void frmNotePad_Load(object sender, EventArgs e)
        {
            cmbSaveFile.Items.Add("Open");
            cmbSaveFile.Items.Add("Save");
            cmbFonts.Items.Add("Times New Roman");
            cmbFonts.Items.Add("Calibri");
            cmbFontSize.Items.Add("10");
            cmbFontSize.Items.Add("12");
            cmbFontSize.Items.Add("14");
            cmbFontSize.Items.Add("16");
            if (cmbFontSize.Text == "10")
            {
                rtb1.Font = new Font(Font.FontFamily, 10);
            }
            if (cmbFonts.Text == "Calibri")
            {
                rtb1.Font = new Font("Calbiri", int.Parse(cmbFontSize.Text));
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            string data = rtb1.Text;
            lblWordCounter.Text = (data.Length).ToString();
            int lines = rtb1.Lines.Count();
            lblLineCounter.Text = lines.ToString();
        }

        private void cmbFonts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFonts.Text == "Times New Roman")
            {
                rtb1.Font = new Font("Times New Roman",int.Parse(cmbFontSize.Text));
            }
            if (cmbFonts.Text == "Calibri")
            {
                rtb1.Font = new Font("Calbiri", int.Parse(cmbFontSize.Text));
            }
        }

        private void cmbFontSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFontSize.Text == "10")
            {
                rtb1.Font = new Font(Font.FontFamily, 10);
            }
            if (cmbFontSize.Text == "12")
            {
                rtb1.Font = new Font(Font.FontFamily, 12);
            }
            if (cmbFontSize.Text == "14")
            {
                rtb1.Font = new Font(Font.FontFamily, 14);
            }
            if (cmbFontSize.Text == "16")
            {
                rtb1.Font = new Font(Font.FontFamily, 16);
            }
        }

        private void btnBold_Click(object sender, EventArgs e)
        {
            if (btnBold.BackColor == Color.White)
            {
                btnBold.BackColor = Color.Gray;
                rtb1.Font = new Font(rtb1.Font, FontStyle.Bold);
            }
            else if (btnBold.BackColor == Color.Gray)
            {
                btnBold.BackColor = Color.White;
                rtb1.Font = new Font(rtb1.Font, FontStyle.Regular);
            }
        }

        private void btnItalic_Click(object sender, EventArgs e)
        {
            if (btnItalic.BackColor == Color.White)
            {
                btnItalic.BackColor = Color.Gray;
                rtb1.Font = new Font(rtb1.Font, FontStyle.Italic);
            }
            else if (btnItalic.BackColor == Color.Gray)
            {
                btnItalic.BackColor = Color.White;
                rtb1.Font = new Font(rtb1.Font, FontStyle.Regular);
            }
        }

        private void btnUnderline_Click(object sender, EventArgs e)
        {
            if(btnUnderline.BackColor == Color.White)
            {
                btnUnderline.BackColor = Color.Gray;
                rtb1.Font = new Font(rtb1.Font, FontStyle.Underline);
            }
            else if (btnUnderline.BackColor == Color.Gray)
            {
                btnUnderline.BackColor = Color.White;
                rtb1.Font = new Font(rtb1.Font, FontStyle.Regular);
            }
        }

        private void cmbSaveFile_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSaveFile.Text == "Save")
            {
                MessageBox.Show("File is Saved");
                cmbSaveFile.Text = "";
                rtb1.Text = "";
            }
            if (cmbSaveFile.Text == "Open")
            {
                MessageBox.Show("File is Open");
                rtb1.Text = "";
                cmbSaveFile.Text = "";
            }
        }
    }
}
