using Model;
using System;

namespace WinFormsApp
{
    /// <summary>
    /// Class TriangleUserControl.
    /// </summary>
    public partial class TriangleUserControl : FigureBaseUserControl
    {
        /// <summary>
        /// TriangleUserControl instance constructor.
        /// </summary>
        public TriangleUserControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Method to get an Figure object.
        /// </summary>
        /// <returns>A FigureBase object.</returns>
        public override FigureBase GetFigure()
        {
            var newTriangle = new Triangle();

            var actions = new List<Action>()
            {
                () =>
                {
                    newTriangle.SideA = Convert.ToDouble
                    (sideA.Text.ReplaceByComma());
                },

                () =>
                {
                    newTriangle.SideB = Convert.ToDouble
                    (sideB.Text.ReplaceByComma());
                },

                () =>
                {
                    newTriangle.SideC = Convert.ToDouble
                    (sideC.Text.ReplaceByComma());
                },
                () =>
                {
                    try
                    {
                        var triangle = new Triangle
                            (newTriangle.SideA,
                            newTriangle.SideB,
                            newTriangle.SideC);
                    }
                    catch (AggregateException ex)
                    {
                    }
                }
            };

            InputParameters(actions);

            return newTriangle;
        }
    }
}
