using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Rectangle = Model.Rectangle;

namespace WinFormsApp
{
    /// <summary>
    /// Class RectangleUserControl.
    /// </summary>
    public partial class RectangleUserControl : FigureBaseUserControl
    {
        /// <summary>
        /// RectangleUserControl instance constructor.
        /// </summary>
        public RectangleUserControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Method to get an Figure object.
        /// </summary>
        /// <returns>A FigureBase object.</returns>
        public override FigureBase GetFigure()
        {
            var newRectangle = new Rectangle();

            var actions = new List<Action>()
            {
                () =>
                {
                    newRectangle.SideA = Convert.ToDouble
                    (sideA.Text.ReplaceByComma());
                },

                () =>
                {
                    newRectangle.SideB = Convert.ToDouble
                    (sideB.Text.ReplaceByComma());
                },
            };

            InputParameters(actions);

            return newRectangle;
        }
    }
}
