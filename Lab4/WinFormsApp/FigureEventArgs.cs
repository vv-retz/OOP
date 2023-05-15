using Model;
using System.ComponentModel;

namespace WinFormsApp
{
    /// <summary>
    /// Class FigureEventArgs.
    /// </summary>
    public class FigureEventArgs : EventArgs
    {
        /// <summary>
        /// Figure.
        /// </summary>
        public FigureBase Figure { get; private set; }

        /// <summary>
        /// Constructor of event FigureEventArgs class with FigureBase.
        /// </summary>
        /// <param name="figure">Figure.</param>
        public FigureEventArgs(FigureBase figure)
        {
            Figure = figure;
        }

        /// <summary>
        /// Filtered figure list.
        /// </summary>
        public BindingList<FigureBase> FigureListFiltered { get; private set; }

        /// <summary>
        /// Constructor of event FigureEventArgs class with filtered figure list.
        /// </summary>
        /// <param name="figureListFiltered">Filtered figure list.</param>
        public FigureEventArgs(BindingList<FigureBase> figureListFiltered)
        {
            FigureListFiltered = figureListFiltered;
        }
    }
}
