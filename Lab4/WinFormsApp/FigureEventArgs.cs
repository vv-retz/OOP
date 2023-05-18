using Model;

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
    }
}
