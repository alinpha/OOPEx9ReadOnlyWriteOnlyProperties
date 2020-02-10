using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace WMAD.ClassLibs
{
    public class MyColor
    {
        const int DEFAULT = 128;
        const int MAX = 256;
        const int MIN = 0;

        private int blue;
        private int green;
        private int red;

        public int Blue 
        { 
            get
            {
                return blue;
            }

            set
            {
                blue = value >= MIN && value <= MAX ? value : DEFAULT;
            }
        }

        public int Green
        {
            get
            {
                return green;
            }

            set
            {
                green = value >= MIN && value <= MAX ? value : DEFAULT;
            }
        }

        public int Red
        {
            get
            {
                return red;
            }

            set
            {
                if (value < MIN || value > MAX)
                {
                    throw new ConstraintException("Value must be between 0 and 256");
                }
                red = value;
            }
        }

    }
}
