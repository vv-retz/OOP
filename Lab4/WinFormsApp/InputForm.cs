using Model;

namespace WinFormsApp
{
    /// <summary>
    /// Class of the input form.
    /// </summary>
    public partial class InputForm : Form
    {
        /// <summary>
        /// Dictionary of motion user controls.
        /// </summary>
        private readonly Dictionary<string,
            UserControl> _comboBoxToUserControl;

        /// <summary>
        /// Handler to event of adding motion.
        /// </summary>
        private EventHandler<FigureEventArgs> _figureAdded;

        /// <summary>
        /// EventHandler _figureAdded field's property.
        /// </summary>
        public EventHandler<FigureEventArgs> FigureAdded
        {
            get => _figureAdded;
            set => _figureAdded = value;
        }

        /// <summary>
        /// Input form instance constructor.
        /// </summary>
        /// <param name="motionList">MainForm _figureList object.</param>
        public InputForm()
        {
            InitializeComponent();
#if DEBUG
            AddRandomObjectButton.Visible = true;
#endif
            string[] figureTypes = { "Rectangle", "Triangle",
                "Circle" };

            _comboBoxToUserControl = new Dictionary<string, UserControl>()
            {
                {figureTypes[0], rectangleUserControl1},
                {figureTypes[1], triangleUserControl1},
                {figureTypes[2], circleUserControl1}
            };

            ComboBoxFigureTypes.Items.AddRange(figureTypes);

            ComboBoxFigureTypes.SelectedIndexChanged +=
                ComboBoxFigureTypes_SelectedIndexChanged;
        }

        /// <summary>
        /// Click event to check changes in ComboBox.
        /// </summary>
        /// <param name="sender">ComboBoxFigureTypes.</param>
        /// <param name="e">Event argument.</param>
        private void ComboBoxFigureTypes_SelectedIndexChanged
            (object sender, EventArgs e)
        {
            string selectedState =
                ComboBoxFigureTypes.SelectedItem.ToString();

            foreach (var (figureType, userControl) in
                _comboBoxToUserControl)
            {
                userControl.Visible = false;
                if (selectedState == figureType)
                {
                    userControl.Visible = true;
                }
            }
        }

        /// <summary>
        /// Click event to add a new figure object.
        /// </summary>
        /// <param name="sender">OKButton.</param>
        /// <param name="e">Event argument.</param>
        private void OKButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ComboBoxFigureTypes.Text.ToString()))
            {
                Close();
            }
            else
            {
                try
                {
                    var chosenFigure =
                        ComboBoxFigureTypes.SelectedItem.ToString();
                    var chosenFigureControl =
                        _comboBoxToUserControl[chosenFigure];
                    var eventArgs = new FigureEventArgs
                        (((FigureBaseUserControl)chosenFigureControl).
                        GetFigure());

                    FigureAdded?.Invoke(this, eventArgs);
                }
                catch (Exception exception)
                {
                    if (exception.GetType() == typeof
                        (ArgumentOutOfRangeException) ||
                        exception.GetType() == typeof
                        (FormatException) ||
                        exception.GetType() == typeof
                        (ArgumentException))
                    {
                        _ = MessageBox.Show
                            ($"Incorrect input parameters.\n" +
                            $"Error: {exception.Message}");
                    }
                    else
                    {
                        throw;
                    }
                }
            }
        }

        /// <summary>
        /// Click event to close the form.
        /// </summary>
        /// <param name="sender">CancelButton.</param>
        /// <param name="e">Event argument.</param>
        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Click event to add a random motion object.
        /// </summary>
        /// <param name="sender">AddRandomObjectButton.</param>
        /// <param name="e">Event argument.</param>
        private void AddRandomObjectButton_Click(object sender, EventArgs e)
        {
            var rnd = new Random();
            var figureTypes = new Dictionary<int, FigureType>
            {
                {0, FigureType.Triangle },
                {1, FigureType.Rectangle },
                {2, FigureType.Circle }
            };
            var randomType = rnd.Next(figureTypes.Count);
            var randomMotion =
                new RandomFigureFactory()
                    .GetInstance(figureTypes[randomType]);

            var eventArgs = new FigureEventArgs(randomMotion);
            FigureAdded?.Invoke(this, eventArgs);
        }
    }
}
