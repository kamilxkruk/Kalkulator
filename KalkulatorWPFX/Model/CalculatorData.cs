using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace KalkulatorWPFX.Model
{
    class CalculatorData
    {
        public CalculatorData(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public int X { get; }
        public int Y { get; }

        public int Sum()
        {
            return X + Y;
        }

        public int Subtract()
        {
            return X - Y;
        }

        public int Multiply()
        {
            return X * Y;
        }

        public double Divide()
        {
            if (Y == 0)
            {
                MessageBox.Show("Nie mogę dzielić przez zero");
                return 0;
            }
            return X / Y;
        }
    }
}
