using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    internal class Rectangle
    {
        /// <summary>
        /// Rectangle class.
        /// </summary>
        public class Rectangle : FigureBase, IAreaCalculatable
        {
            /// <summary>
            /// Side A length.
            /// </summary>
            private double _sideA;

            /// <summary>
            /// Side B length.
            /// </summary>
            private double _sideB;

            /// <summary>
            /// Initializes a new instance of the <see cref="SideA"/> class.
            /// </summary>
            public double SideA
            {
                get => _sideA;
                set => _sideA = CheckValue(value);
            }

            /// <summary>
            /// Initializes a new instance of the <see cref="SideB"/> class.
            /// </summary>
            public double SideB
            {
                get => _sideB;
                set => _sideB = CheckValue(value);
            }

            /// <summary>
            /// Констукрутор класса "Прямоугольник"
            /// </summary>
            /// <param name="sideA">Длинна одной из сторон прямоугольника</param>
            /// <param name="sideB">Длинна одной из сторон прямоугольника</param>
            Rectangle(double sideA, double sideB)
            {
                SideA = sideA;
                SideB = sideB;
            }

            /// <summary>
            /// Площадь прямоугольника
            /// </summary>
            public double Calculate()
            {
                return SideA * SideB;
            }
        }
    }
}
