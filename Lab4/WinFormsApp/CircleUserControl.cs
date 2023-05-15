using Model;

namespace WinFormsApp
{
    /// <summary>
    /// Class CircleUserControl.
    /// </summary>
    public partial class CircleUserControl : FigureBaseUserControl
    {
        /// <summary>
        /// CircleUserControl instance constructor.
        /// </summary>
        public CircleUserControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Method to get an Figure object.
        /// </summary>
        /// <returns>A FigureBase object.</returns>
        public override FigureBase GetFigure()
        {
            var newCircle = new Circle();

            var actions = new List<Action>()
            {
                () =>
                {
                    newCircle.Radius = Convert.ToDouble
                    (radius.Text.ReplaceByComma());
                },
            };

            InputParameters(actions);

            return newCircle;
        }
    }
}
