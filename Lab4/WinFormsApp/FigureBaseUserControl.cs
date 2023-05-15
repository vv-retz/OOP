using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;

namespace WinFormsApp
{
    /// <summary>
    /// Abstract base class FigureBaseUserControl.
    /// </summary>
    public abstract partial class FigureBaseUserControl : UserControl
    {
        /// <summary>
        /// Abstract method to get an Figure object.
        /// </summary>
        /// <returns>An Figure object.</returns>
        public abstract FigureBase GetFigure();

        /// <summary>
        /// Wright input parameters in instance.
        /// </summary>
        /// <param name="actions">Action list of parameters.</param>
        public void InputParameters(List<Action> actions)
        {
            foreach (var action in actions)
            {
                action.Invoke();
            }
        }
    }
}
