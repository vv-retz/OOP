using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// FigureAreaBase class.
    /// </summary>
    public abstract class FigureAreaBase
    {
        /// <summary>
        /// Method which allow to count area of figure.
        /// </summary>
        public abstract double FigureArea { get; set; }

        /// <summary>
        /// Проверка знака (плюс или минус) отрезка фигуры
        /// </summary>
        /// <param name="lineSegment">Отрезок фигуры</param>
        /// <returns>Отрезок фигуры</returns>
        protected double CheckValue(double lineSegment)
        {
            return lineSegment <= 0
                ? throw new ArgumentException("Неправильный ввод данных")
                : lineSegment;
        }
    }
}
