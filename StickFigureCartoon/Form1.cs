using Microsoft.VisualBasic.Devices;
using System.Drawing.Drawing2D;




namespace StickFigureCartoon
{
    public partial class Form1 : Form
    {
        Pen drawingPen;
        int mouseX, mouseY, mouseX1, mouseY1;
        bool drawStickManStraight = false;
        bool drawStickManArmsUp = false;
        bool drawStickManArmsDown = false;
        bool drawStickWoman = false;

        Bitmap bitmapObject;
        Graphics graphicsObject;

        //

        bool isDrawingEllipse = false;
        Rectangle ellipseRectangle;

        readonly Stack<Bitmap> UndoStack = new Stack<Bitmap>();
        readonly Stack<Bitmap> RedoStack = new Stack<Bitmap>();




        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Loadc(object sender, EventArgs e)
        {


            drawingPen = new Pen(Color.Black);
            drawingPen.DashStyle = DashStyle.Solid;
            drawingPen.Width = TrackBrushSize.Value;

            bitmapObject = new Bitmap(PBSurface.Width, PBSurface.Height);
            graphicsObject = Graphics.FromImage(bitmapObject);

            drawStickManStraight = true;  //get the stick figure man without clicking buttons
            PBSurface.Cursor = Cursors.Cross;









            //Load Combo box with system colors


            foreach (KnownColor inbuiltColor in Enum.GetValues(typeof(KnownColor)))          //color stored in inbuiltColor,knownColor is enum,getvalues it's method 
            {
                Color loadColor = Color.FromKnownColor(inbuiltColor);

                if (loadColor.IsSystemColor == false)
                {

                    if (loadColor.Name != "Transparent")
                    {

                        cmbColors.Items.Add(loadColor.Name);


                    }

                }



            }
        }

        private void cmbColors_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelColor.BackColor = Color.FromName(cmbColors.SelectedItem.ToString());
            drawingPen.Color = Color.FromName(cmbColors.SelectedItem.ToString());





        }

        private void PBSurface_Click(object sender, EventArgs e)
        {

        }

        private void BtnCustomColor_Click(object sender, EventArgs e)
        {
            if (ColorDB.ShowDialog() != DialogResult.Cancel)
            {
                labelColor.BackColor = ColorDB.Color;
                drawingPen.Color = ColorDB.Color;





            }
        }

        private void BtnBlue_Click(object sender, EventArgs e)
        {
            labelColor.BackColor = Color.Blue;
            drawingPen.Color = Color.Blue;
        }

        private void BtnRed_Click(object sender, EventArgs e)
        {
            labelColor.BackColor = Color.Red;
            drawingPen.Color = Color.Red;
        }

        private void BtnYellow_Click(object sender, EventArgs e)
        {
            labelColor.BackColor = Color.Yellow;
            drawingPen.Color = Color.Yellow;
        }

        private void BtnGrey_Click(object sender, EventArgs e)
        {
            labelColor.BackColor = Color.Gray;
            drawingPen.Color = Color.Gray;
        }

        private void BtnBlack_Click(object sender, EventArgs e)
        {
            labelColor.BackColor = Color.Black;
            drawingPen.Color = Color.Black;

        }

        private void BtnGreen_Click(object sender, EventArgs e)
        {
            labelColor.BackColor = Color.Green;
            drawingPen.Color = Color.Green;

        }

        private void TrackBrushSize_Scroll(object sender, EventArgs e)
        {
            drawingPen.Width = TrackBrushSize.Value;


        }

        private void PBSurface_MouseDown(object sender, MouseEventArgs e)
        {
            mouseX = e.X;
            mouseY = e.Y;
            //UNDO ,REDO

            UndoStack.Push((Bitmap)bitmapObject.Clone());
            RedoStack.Clear();
        }

        private void BtnArmsStraight_Click(object sender, EventArgs e)
        {
            drawStickManStraight = true;
            drawStickManArmsDown = false;
            drawStickManArmsUp = false;
            drawStickWoman = false;
        }

        private void BtnArmsUp_Click(object sender, EventArgs e)
        {
            drawStickManStraight = false;
            drawStickManArmsDown = false;
            drawStickManArmsUp = true;
            drawStickWoman = false;

        }

        private void BtnArmsDown_Click(object sender, EventArgs e)
        {
            drawStickManStraight = false;
            drawStickManArmsDown = true;
            drawStickManArmsUp = false;
            drawStickWoman = false;
        }

        private void BtnStickWoman_Click(object sender, EventArgs e)
        {
            drawStickManStraight = false;
            drawStickManArmsDown = false;
            drawStickManArmsUp = false;
            drawStickWoman = true;
        }

        private void PBSurface_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(bitmapObject, 0, 0);


        }



        private void DrawStickMan()
        {
            StrickFigureDimensions size = new StrickFigureDimensions(mouseY, mouseY1);

            //HEAD
            graphicsObject.DrawEllipse(drawingPen, mouseX, mouseY, size.HeadDiameter, size.HeadDiameter);

            //BODY
            graphicsObject.DrawLine(drawingPen,

            mouseX + size.HeadRadius,
            mouseY + size.HeadDiameter,
          mouseX + size.HeadRadius,
          mouseY + size.HeadDiameter + size.BodySize);


            //RIGHT LEG
            graphicsObject.DrawLine(drawingPen,
                mouseX + size.HeadRadius,
                mouseY + (size.HeadDiameter + size.BodySize),
                 mouseX + (size.HeadRadius + size.BaseUnit * 2),
            mouseY + (size.HeadDiameter + size.BodySize + size.LegSize));

            //LEFT LEG
            graphicsObject.DrawLine(drawingPen,
               mouseX + size.HeadRadius,
               mouseY + (size.HeadDiameter + size.BodySize),
                mouseX + (size.HeadRadius - size.BaseUnit * 2),
           mouseY + (size.HeadDiameter + size.BodySize + size.LegSize));


            if (drawStickManStraight)
            {
                //LEFT ARM
                graphicsObject.DrawLine(drawingPen,
               mouseX,
               size.MidBody,
               mouseX + size.HeadRadius,
               size.MidBody);

                //RIGHT ARM

                graphicsObject.DrawLine(drawingPen,
              mouseX + size.HeadRadius,
              size.MidBody,
              mouseX + size.HeadDiameter,
              size.MidBody);


            }
            else if (drawStickManArmsUp)
            {

                //LEFT ARM
                graphicsObject.DrawLine(drawingPen,
               mouseX,
               size.MidBody - (size.BaseUnit * 2),
               mouseX + size.HeadRadius,
               size.MidBody);

                //RIGHT ARM

                graphicsObject.DrawLine(drawingPen,
              mouseX + size.HeadRadius,
              size.MidBody,
              mouseX + size.HeadDiameter,
              size.MidBody - size.BaseUnit * 2);


            }
            else if (drawStickManArmsDown)
            {
                //LEFT ARM
                graphicsObject.DrawLine(drawingPen,
               mouseX,
               size.MidBody + (size.BaseUnit * 2),
               mouseX + size.HeadRadius,
               size.MidBody);

                //RIGHT ARM

                graphicsObject.DrawLine(drawingPen,
              mouseX + size.HeadRadius,
              size.MidBody,
              mouseX + size.HeadDiameter,
              size.MidBody + (size.BaseUnit * 2));


            }





        }

        private void DrawStickLady()
        {
            StrickFigureDimensions size = new StrickFigureDimensions(mouseY, mouseY1);
            Point[]  polygonPoints = new Point[3];
            polygonPoints[0] = new Point(0, 0);
            polygonPoints[1] = new Point(0, 0);
            polygonPoints[2] = new Point(0, 0);

            polygonPoints[0].X = mouseX + size.HeadRadius;
            polygonPoints[0].Y = mouseY + (int)(size.HeadDiameter + drawingPen.Width);

            polygonPoints[1].X = mouseX + size.HeadDiameter;
            polygonPoints[1].Y = mouseY + size.HeadDiameter + size.BodySize;

            polygonPoints[2].X = mouseX;
            polygonPoints[2].Y = mouseY + size.HeadDiameter + size.BodySize;
            //HEAD
            graphicsObject.DrawEllipse(drawingPen, mouseX, mouseY, size.HeadDiameter, size.HeadDiameter);
            //BODY
            graphicsObject.DrawPolygon(drawingPen, polygonPoints);
            //LEFT ARM
            graphicsObject.DrawLine(drawingPen, mouseX, size.MidBody, mouseX + (size.HeadRadius / 2), size.MidBody);


            //RIGHT ARM
            graphicsObject.DrawLine(drawingPen, mouseX + (int)(size.HeadDiameter * 0.75), size.MidBody, mouseX + size.HeadDiameter, size.MidBody);
            //RIGHT LEG
            graphicsObject.DrawLine(drawingPen, mouseX + (int)(size.HeadDiameter * 0.75),
mouseY + size.HeadDiameter + size.BodySize,
mouseX + (int)(size.HeadDiameter * 0.75),
mouseY + size.HeadDiameter + size.BodySize + size.LegSize);
            //LEFT LEG
            graphicsObject.DrawLine(drawingPen, mouseX + (size.HeadRadius / 2),
mouseY + size.HeadDiameter + size.BodySize,
mouseX + (size.HeadRadius / 2),
mouseY + size.HeadDiameter + size.BodySize + size.LegSize);







        }

        private void PBSurface_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseX1 = e.X;
                mouseY1 = e.Y;

                graphicsObject.SmoothingMode = SmoothingMode.AntiAlias;

                if (drawStickWoman)
                {
                    DrawStickLady();
                }
                else
                {
                    DrawStickMan();
                }

                PBSurface.Invalidate();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (UndoStack.Count > 0)
            {
                RedoStack.Push((Bitmap)bitmapObject.Clone());
                bitmapObject = UndoStack.Pop();
                graphicsObject = Graphics.FromImage(bitmapObject);
                PBSurface.Invalidate();




            }
            else
            {

                MessageBox.Show("Nothing to Undo");

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (RedoStack.Count > 0)
            {

                UndoStack.Push((Bitmap)bitmapObject.Clone());
                bitmapObject = RedoStack.Pop();
                graphicsObject = Graphics.FromImage(bitmapObject);
                PBSurface.Invalidate();
            }
            else
            {

                MessageBox.Show("Nothing to Redo ");

            }
        }
    }
}
