namespace StickFigureCartoon
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            PBSurface = new PictureBox();
            groupBox1 = new GroupBox();
            dateTimePicker1 = new DateTimePicker();
            BtnStickWoman = new Button();
            BtnArmsDown = new Button();
            BtnArmsUp = new Button();
            BtnArmsStraight = new Button();
            groupBox2 = new GroupBox();
            labelColor = new Label();
            BtnCustomColor = new Button();
            BtnYellow = new Button();
            BtnRed = new Button();
            BtnGreen = new Button();
            BtnBlack = new Button();
            BtnGrey = new Button();
            BtnBlue = new Button();
            cmbColors = new ComboBox();
            groupBox3 = new GroupBox();
            RadioDashed = new RadioButton();
            RadioSolid = new RadioButton();
            groupBox4 = new GroupBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            TrackBrushSize = new TrackBar();
            groupBox5 = new GroupBox();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            ColorDB = new ColorDialog();
            ((System.ComponentModel.ISupportInitialize)PBSurface).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TrackBrushSize).BeginInit();
            groupBox5.SuspendLayout();
            SuspendLayout();
            // 
            // PBSurface
            // 
            PBSurface.BackColor = SystemColors.ControlLightLight;
            PBSurface.BorderStyle = BorderStyle.FixedSingle;
            PBSurface.Location = new Point(12, 12);
            PBSurface.Name = "PBSurface";
            PBSurface.Size = new Size(985, 443);
            PBSurface.TabIndex = 0;
            PBSurface.TabStop = false;
            PBSurface.Click += PBSurface_Click;
            PBSurface.Paint += PBSurface_Paint;
            PBSurface.MouseDown += PBSurface_MouseDown;
            PBSurface.MouseUp += PBSurface_MouseUp;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(BtnStickWoman);
            groupBox1.Controls.Add(BtnArmsDown);
            groupBox1.Controls.Add(BtnArmsUp);
            groupBox1.Controls.Add(BtnArmsStraight);
            groupBox1.Location = new Point(1020, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 436);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Stick Figures.";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(6, 387);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 4;
            // 
            // BtnStickWoman
            // 
            BtnStickWoman.BackgroundImage = Properties.Resources.f_arms_straight;
            BtnStickWoman.BackgroundImageLayout = ImageLayout.Zoom;
            BtnStickWoman.Location = new Point(125, 152);
            BtnStickWoman.Name = "BtnStickWoman";
            BtnStickWoman.Size = new Size(94, 86);
            BtnStickWoman.TabIndex = 3;
            BtnStickWoman.UseVisualStyleBackColor = true;
            BtnStickWoman.Click += BtnStickWoman_Click;
            // 
            // BtnArmsDown
            // 
            BtnArmsDown.BackgroundImage = Properties.Resources.m_arms_down;
            BtnArmsDown.BackgroundImageLayout = ImageLayout.Zoom;
            BtnArmsDown.Location = new Point(15, 152);
            BtnArmsDown.Name = "BtnArmsDown";
            BtnArmsDown.Size = new Size(94, 86);
            BtnArmsDown.TabIndex = 2;
            BtnArmsDown.UseVisualStyleBackColor = true;
            BtnArmsDown.Click += BtnArmsDown_Click;
            // 
            // BtnArmsUp
            // 
            BtnArmsUp.BackgroundImage = Properties.Resources.m_arms_up;
            BtnArmsUp.BackgroundImageLayout = ImageLayout.Zoom;
            BtnArmsUp.Location = new Point(125, 49);
            BtnArmsUp.Name = "BtnArmsUp";
            BtnArmsUp.Size = new Size(94, 86);
            BtnArmsUp.TabIndex = 1;
            BtnArmsUp.UseVisualStyleBackColor = true;
            BtnArmsUp.Click += BtnArmsUp_Click;
            // 
            // BtnArmsStraight
            // 
            BtnArmsStraight.BackgroundImage = Properties.Resources.m_arms_straight;
            BtnArmsStraight.BackgroundImageLayout = ImageLayout.Zoom;
            BtnArmsStraight.Location = new Point(15, 49);
            BtnArmsStraight.Name = "BtnArmsStraight";
            BtnArmsStraight.Size = new Size(94, 86);
            BtnArmsStraight.TabIndex = 0;
            BtnArmsStraight.UseVisualStyleBackColor = true;
            BtnArmsStraight.Click += BtnArmsStraight_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(labelColor);
            groupBox2.Controls.Add(BtnCustomColor);
            groupBox2.Controls.Add(BtnYellow);
            groupBox2.Controls.Add(BtnRed);
            groupBox2.Controls.Add(BtnGreen);
            groupBox2.Controls.Add(BtnBlack);
            groupBox2.Controls.Add(BtnGrey);
            groupBox2.Controls.Add(BtnBlue);
            groupBox2.Controls.Add(cmbColors);
            groupBox2.Location = new Point(12, 474);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(406, 210);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Colors";
            // 
            // labelColor
            // 
            labelColor.AutoSize = true;
            labelColor.BorderStyle = BorderStyle.FixedSingle;
            labelColor.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelColor.Location = new Point(291, 38);
            labelColor.Name = "labelColor";
            labelColor.Size = new Size(82, 33);
            labelColor.TabIndex = 8;
            labelColor.Text = "           ";
            // 
            // BtnCustomColor
            // 
            BtnCustomColor.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnCustomColor.Location = new Point(18, 93);
            BtnCustomColor.Name = "BtnCustomColor";
            BtnCustomColor.Size = new Size(246, 38);
            BtnCustomColor.TabIndex = 7;
            BtnCustomColor.Text = "               Custom";
            BtnCustomColor.TextAlign = ContentAlignment.TopLeft;
            BtnCustomColor.UseVisualStyleBackColor = true;
            BtnCustomColor.Click += BtnCustomColor_Click;
            // 
            // BtnYellow
            // 
            BtnYellow.BackColor = Color.Yellow;
            BtnYellow.Location = new Point(60, 38);
            BtnYellow.Name = "BtnYellow";
            BtnYellow.Size = new Size(36, 31);
            BtnYellow.TabIndex = 6;
            BtnYellow.UseVisualStyleBackColor = false;
            BtnYellow.Click += BtnYellow_Click;
            // 
            // BtnRed
            // 
            BtnRed.BackColor = Color.Red;
            BtnRed.Location = new Point(18, 38);
            BtnRed.Name = "BtnRed";
            BtnRed.Size = new Size(36, 31);
            BtnRed.TabIndex = 5;
            BtnRed.UseVisualStyleBackColor = false;
            BtnRed.Click += BtnRed_Click;
            // 
            // BtnGreen
            // 
            BtnGreen.BackColor = Color.Lime;
            BtnGreen.Location = new Point(228, 38);
            BtnGreen.Name = "BtnGreen";
            BtnGreen.Size = new Size(36, 31);
            BtnGreen.TabIndex = 4;
            BtnGreen.UseVisualStyleBackColor = false;
            BtnGreen.Click += BtnGreen_Click;
            // 
            // BtnBlack
            // 
            BtnBlack.BackColor = Color.Black;
            BtnBlack.Location = new Point(186, 38);
            BtnBlack.Name = "BtnBlack";
            BtnBlack.Size = new Size(36, 31);
            BtnBlack.TabIndex = 3;
            BtnBlack.UseVisualStyleBackColor = false;
            BtnBlack.Click += BtnBlack_Click;
            // 
            // BtnGrey
            // 
            BtnGrey.BackColor = Color.Gray;
            BtnGrey.Location = new Point(144, 38);
            BtnGrey.Name = "BtnGrey";
            BtnGrey.Size = new Size(36, 31);
            BtnGrey.TabIndex = 2;
            BtnGrey.UseVisualStyleBackColor = false;
            BtnGrey.Click += BtnGrey_Click;
            // 
            // BtnBlue
            // 
            BtnBlue.BackColor = Color.Blue;
            BtnBlue.Location = new Point(102, 38);
            BtnBlue.Name = "BtnBlue";
            BtnBlue.Size = new Size(36, 31);
            BtnBlue.TabIndex = 1;
            BtnBlue.UseVisualStyleBackColor = false;
            BtnBlue.Click += BtnBlue_Click;
            // 
            // cmbColors
            // 
            cmbColors.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbColors.FormattingEnabled = true;
            cmbColors.Location = new Point(21, 167);
            cmbColors.Name = "cmbColors";
            cmbColors.Size = new Size(363, 36);
            cmbColors.TabIndex = 0;
            cmbColors.Text = "Color Selector";
            cmbColors.SelectedIndexChanged += cmbColors_SelectedIndexChanged;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(RadioDashed);
            groupBox3.Controls.Add(RadioSolid);
            groupBox3.Location = new Point(457, 585);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(523, 109);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Line Style";
            // 
            // RadioDashed
            // 
            RadioDashed.AutoSize = true;
            RadioDashed.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RadioDashed.Location = new Point(174, 41);
            RadioDashed.Name = "RadioDashed";
            RadioDashed.Size = new Size(82, 24);
            RadioDashed.TabIndex = 1;
            RadioDashed.Text = "Dashed";
            RadioDashed.UseVisualStyleBackColor = true;
            // 
            // RadioSolid
            // 
            RadioSolid.AutoSize = true;
            RadioSolid.Checked = true;
            RadioSolid.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RadioSolid.Location = new Point(40, 41);
            RadioSolid.Name = "RadioSolid";
            RadioSolid.Size = new Size(64, 24);
            RadioSolid.TabIndex = 0;
            RadioSolid.TabStop = true;
            RadioSolid.Text = "Solid";
            RadioSolid.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(label3);
            groupBox4.Controls.Add(label2);
            groupBox4.Controls.Add(label1);
            groupBox4.Controls.Add(TrackBrushSize);
            groupBox4.Location = new Point(457, 474);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(523, 105);
            groupBox4.TabIndex = 4;
            groupBox4.TabStop = false;
            groupBox4.Text = "Brush Size";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(442, 76);
            label3.Name = "label3";
            label3.Size = new Size(25, 20);
            label3.TabIndex = 3;
            label3.Text = "20";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(234, 76);
            label2.Name = "label2";
            label2.Size = new Size(25, 20);
            label2.TabIndex = 2;
            label2.Text = "10";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 76);
            label1.Name = "label1";
            label1.Size = new Size(17, 20);
            label1.TabIndex = 1;
            label1.Text = "1";
            // 
            // TrackBrushSize
            // 
            TrackBrushSize.Location = new Point(30, 39);
            TrackBrushSize.Maximum = 20;
            TrackBrushSize.Minimum = 1;
            TrackBrushSize.Name = "TrackBrushSize";
            TrackBrushSize.Size = new Size(445, 56);
            TrackBrushSize.TabIndex = 0;
            TrackBrushSize.Value = 5;
            TrackBrushSize.Scroll += TrackBrushSize_Scroll;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(button4);
            groupBox5.Controls.Add(button3);
            groupBox5.Controls.Add(button2);
            groupBox5.Controls.Add(button1);
            groupBox5.Location = new Point(1003, 454);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(295, 240);
            groupBox5.TabIndex = 0;
            groupBox5.TabStop = false;
            groupBox5.Text = "Actions";
            // 
            // button4
            // 
            button4.Location = new Point(70, 187);
            button4.Name = "button4";
            button4.Size = new Size(153, 36);
            button4.TabIndex = 3;
            button4.Text = "Clear Surface";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(70, 131);
            button3.Name = "button3";
            button3.Size = new Size(153, 39);
            button3.TabIndex = 2;
            button3.Text = "Save Image";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(70, 87);
            button2.Name = "button2";
            button2.Size = new Size(153, 38);
            button2.TabIndex = 1;
            button2.Text = "Redo";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(70, 26);
            button1.Name = "button1";
            button1.Size = new Size(153, 41);
            button1.TabIndex = 0;
            button1.Text = "Undo";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1310, 706);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(PBSurface);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Stick Figure Draw";
            Load += Form1_Loadc;
            MouseDown += Form1_MouseDown;
            ((System.ComponentModel.ISupportInitialize)PBSurface).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)TrackBrushSize).EndInit();
            groupBox5.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private PictureBox PBSurface;
        private GroupBox groupBox1;
        private GroupBox groupBox5;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private ComboBox cmbColors;
        private Button BtnArmsStraight;
        private Button BtnStickWoman;
        private Button BtnArmsDown;
        private Button BtnArmsUp;
        private Button BtnYellow;
        private Button BtnRed;
        private Button BtnGreen;
        private Button BtnBlack;
        private Button BtnGrey;
        private Button BtnBlue;
        private Button BtnCustomColor;
        private Label labelColor;
        private RadioButton RadioDashed;
        private RadioButton RadioSolid;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Label label3;
        private Label label2;
        private Label label1;
        private TrackBar TrackBrushSize;
        private ColorDialog ColorDB;
        private DateTimePicker dateTimePicker1;
    }
}
