namespace StickFigureCartoon
{
    partial class FormText
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormText));
            TextboxStickFigure = new TextBox();
            groupBox1 = new GroupBox();
            SpinFontSize = new NumericUpDown();
            CmbFontFamily = new ComboBox();
            groupBox2 = new GroupBox();
            RadioItalic = new RadioButton();
            RadioBold = new RadioButton();
            RadioRegular = new RadioButton();
            groupBox3 = new GroupBox();
            labelColor = new Label();
            button3 = new Button();
            BtnCancel = new Button();
            BtnOK = new Button();
            ColorDB = new ColorDialog();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SpinFontSize).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // TextboxStickFigure
            // 
            TextboxStickFigure.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TextboxStickFigure.Location = new Point(12, 12);
            TextboxStickFigure.Multiline = true;
            TextboxStickFigure.Name = "TextboxStickFigure";
            TextboxStickFigure.Size = new Size(415, 130);
            TextboxStickFigure.TabIndex = 0;
            TextboxStickFigure.Text = "Default Text";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(SpinFontSize);
            groupBox1.Controls.Add(CmbFontFamily);
            groupBox1.Location = new Point(12, 163);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(415, 86);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Font Family and Size";
            // 
            // SpinFontSize
            // 
            SpinFontSize.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SpinFontSize.Location = new Point(268, 38);
            SpinFontSize.Maximum = new decimal(new int[] { 36, 0, 0, 0 });
            SpinFontSize.Minimum = new decimal(new int[] { 8, 0, 0, 0 });
            SpinFontSize.Name = "SpinFontSize";
            SpinFontSize.Size = new Size(103, 30);
            SpinFontSize.TabIndex = 1;
            SpinFontSize.Value = new decimal(new int[] { 14, 0, 0, 0 });
            SpinFontSize.ValueChanged += SpinFontSize_ValueChanged;
            // 
            // CmbFontFamily
            // 
            CmbFontFamily.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CmbFontFamily.FormattingEnabled = true;
            CmbFontFamily.Location = new Point(34, 38);
            CmbFontFamily.Name = "CmbFontFamily";
            CmbFontFamily.Size = new Size(208, 33);
            CmbFontFamily.TabIndex = 0;
            CmbFontFamily.Text = "Arial";
            CmbFontFamily.SelectedIndexChanged += CmbFontFamily_SelectedIndexChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(RadioItalic);
            groupBox2.Controls.Add(RadioBold);
            groupBox2.Controls.Add(RadioRegular);
            groupBox2.Location = new Point(12, 271);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(415, 82);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Font Style";
            // 
            // RadioItalic
            // 
            RadioItalic.AutoSize = true;
            RadioItalic.BackColor = SystemColors.ControlLight;
            RadioItalic.Location = new Point(285, 39);
            RadioItalic.Name = "RadioItalic";
            RadioItalic.Size = new Size(62, 24);
            RadioItalic.TabIndex = 2;
            RadioItalic.Text = "Italic";
            RadioItalic.UseVisualStyleBackColor = false;
            // 
            // RadioBold
            // 
            RadioBold.AutoSize = true;
            RadioBold.BackColor = SystemColors.ControlLight;
            RadioBold.Location = new Point(159, 39);
            RadioBold.Name = "RadioBold";
            RadioBold.Size = new Size(61, 24);
            RadioBold.TabIndex = 1;
            RadioBold.Text = "Bold";
            RadioBold.UseVisualStyleBackColor = false;
            // 
            // RadioRegular
            // 
            RadioRegular.AutoSize = true;
            RadioRegular.BackColor = SystemColors.ControlLight;
            RadioRegular.Checked = true;
            RadioRegular.Location = new Point(34, 39);
            RadioRegular.Name = "RadioRegular";
            RadioRegular.Size = new Size(81, 24);
            RadioRegular.TabIndex = 0;
            RadioRegular.TabStop = true;
            RadioRegular.Text = "Regular";
            RadioRegular.UseVisualStyleBackColor = false;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(labelColor);
            groupBox3.Controls.Add(button3);
            groupBox3.Location = new Point(12, 374);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(415, 85);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = " Font Color";
            groupBox3.Enter += groupBox3_Enter;
            // 
            // labelColor
            // 
            labelColor.AutoSize = true;
            labelColor.BackColor = SystemColors.ControlText;
            labelColor.Location = new Point(285, 37);
            labelColor.Name = "labelColor";
            labelColor.Size = new Size(41, 20);
            labelColor.TabIndex = 1;
            labelColor.Text = "        ";
            // 
            // button3
            // 
            button3.Location = new Point(54, 26);
            button3.Name = "button3";
            button3.Size = new Size(166, 42);
            button3.TabIndex = 0;
            button3.Text = "Font Color";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // BtnCancel
            // 
            BtnCancel.BackColor = SystemColors.ControlLight;
            BtnCancel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnCancel.Location = new Point(219, 483);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(119, 53);
            BtnCancel.TabIndex = 4;
            BtnCancel.Text = "CANCEL";
            BtnCancel.UseVisualStyleBackColor = false;
            BtnCancel.Click += BtnCancel_Click;
            // 
            // BtnOK
            // 
            BtnOK.BackColor = SystemColors.ControlLight;
            BtnOK.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnOK.Location = new Point(66, 483);
            BtnOK.Name = "BtnOK";
            BtnOK.Size = new Size(119, 53);
            BtnOK.TabIndex = 5;
            BtnOK.Text = "OK";
            BtnOK.UseVisualStyleBackColor = false;
            BtnOK.Click += BtnOK_Click;
            // 
            // FormText
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(460, 551);
            Controls.Add(BtnOK);
            Controls.Add(BtnCancel);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(TextboxStickFigure);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormText";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " ";
            Load += FormText_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)SpinFontSize).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TextboxStickFigure;
        private GroupBox groupBox1;
        private NumericUpDown SpinFontSize;
        private ComboBox CmbFontFamily;
        private GroupBox groupBox2;
        private RadioButton RadioItalic;
        private RadioButton RadioBold;
        private RadioButton RadioRegular;
        private GroupBox groupBox3;
        private Button BtnCancel;
        private Button BtnOK;
        private Label labelColor;
        private Button button3;
        private ColorDialog ColorDB;
    }
}