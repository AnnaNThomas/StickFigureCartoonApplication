

using System;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Windows.Forms;



namespace StickFigureCartoon
{


    public partial class FormText : Form
    {
        bool isFontColorSet;
        decimal fontSize;
        string fontFamily;
        Color fontColor;
        FontStyle style;

        public FormText()
        {
            InitializeComponent();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void FormText_Load(object sender, EventArgs e)
        {
            InstalledFontCollection systemFonts = new InstalledFontCollection();
            FontFamily[] fonts = systemFonts.Families.ToArray();
            for (int i = 0; i < fonts.Length; i++)
            {

                CmbFontFamily.Items.Add(fonts[i].Name);

            }
            isFontColorSet = false;
            fontSize = 14;
            systemFonts.Dispose();






        }

        private void SpinFontSize_ValueChanged(object sender, EventArgs e)
        {
            fontSize = SpinFontSize.Value;




        }

        private void CmbFontFamily_SelectedIndexChanged(object sender, EventArgs e)
        {
            fontFamily = CmbFontFamily.Text;



        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (ColorDB.ShowDialog() != DialogResult.Cancel) //ColorDB is colordialog

            {

                fontColor = ColorDB.Color;
                labelColor.BackColor = ColorDB.Color;
                isFontColorSet = true;

            }
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            if (isFontColorSet == false)
            {

                MessageBox.Show("No font color set");
                return;

            }
            if (RadioRegular.Checked)
            {

                style = FontStyle.Regular;

            }
            else if (RadioBold.Checked)
            {

                style = FontStyle.Bold;

            }
            else if (RadioItalic.Checked)
            {

                style = FontStyle.Italic;

            }

            Font fontObject = new Font(fontFamily, (float)fontSize, style);

            Form1.theFont = fontObject;
            Form1.theText = TextboxStickFigure.Text;
            Form1.theFontColor = fontColor;

            DialogResult = DialogResult.OK;




        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;


        }
    }
}
