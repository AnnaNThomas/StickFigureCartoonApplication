

using Microsoft.VisualBasic.Devices;

namespace StickFigureCartoon
{
    internal class StrickFigureDimensions
    {
        private readonly int Yvalue;


        public StrickFigureDimensions(int mouseY, int mouseY1)
        {

            BaseUnit = (mouseY1 - mouseY) / 10;
            Yvalue = mouseY;






        }
        public int BaseUnit { get; }
        /// <summary>
        /// Get the diameter of the head for a stick figure
        /// </summary>

        public int HeadDiameter
        {

            get { return BaseUnit * 3; }

        }

        public int HeadRadius
        {

            get { return (BaseUnit * 3) / 2; }

        }

        public int BodySize
        {

            get { return BaseUnit * 4; }

        }
        public int MidBody
        {

            get { return Yvalue + (BaseUnit * 5); }

        }
        public int LegSize
        {

            get { return BaseUnit * 3; }

        }





    }









}


       






    

    




    
