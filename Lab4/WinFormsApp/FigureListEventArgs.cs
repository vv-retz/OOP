using Model;
using System.ComponentModel;

namespace WinFormsApp
{
    /// <summary>
    /// Class FigureListEventArgs.
    /// </summary>
    public class FigureListEventArgs : EventArgs
    {
        /// <summary>
        /// Filtered figure list.
        /// </summary>
        public BindingList<FigureBase> FigureListFiltered { get; private set; }

        /// <summary>
        /// Constructor of event FigureEventArgs class with filtered figure list.
        /// </summary>
        /// <param name="figureListFiltered">Filtered figure list.</param>
        public FigureListEventArgs(BindingList<FigureBase> figureListFiltered)
        {
            FigureListFiltered = figureListFiltered;
        }
    }
}
