using Model;
using System.ComponentModel;
using Rectangle = Model.Rectangle;

namespace WinFormsApp
{
    /// <summary>
    /// Filter form instance constructor.
    /// </summary>
    public partial class FilterForm : Form
    {
        /// <summary>
        /// Dictionary of figure types.
        /// </summary>
        private readonly Dictionary<string, Type> _figureTypes = new()
        {
            {nameof(Triangle), typeof(Triangle)},
            {nameof(Rectangle), typeof(Rectangle)},
            {nameof(Circle), typeof(Circle)}
        };

        /// <summary>
        /// Dictionary of figure type names.
        /// </summary>
        private readonly Dictionary<string, string> _listBoxToFigureType;

        /// <summary>
        /// Handler to event of filtering figure.
        /// </summary>
        private EventHandler<FigureListEventArgs> _figureListFiltered;

        /// <summary>
        /// EventHandler _figureListFiltered field's property.
        /// </summary>
        public EventHandler<FigureListEventArgs> FigureListFiltered
        {
            get => _figureListFiltered;
            set => _figureListFiltered = value;
        }

        /// <summary>
        /// Property for link to MainForm _motionList object.
        /// </summary>
        public BindingList<FigureBase> FigureListMain { get; set; }

        /// <summary>
        /// Filter form instance constructor.
        /// </summary>
        public FilterForm()
        {
            InitializeComponent();

            _listBoxToFigureType = new Dictionary<string, string>()
            {
                {"Triangle", nameof(Triangle)},
                {"Rectangle", nameof(Rectangle)},
                {"Circle", nameof(Circle) }
            };

            FigureTypeCheckedListBox.Items.AddRange
                (_listBoxToFigureType.Keys.ToArray());
        }

        /// <summary>
        /// Click event to filter information in DataGrid.
        /// </summary>
        /// <param name="sender">FilterButton.</param>
        /// <param name="e">Event argument.</param>
        private void FilterButton_Click(object sender, EventArgs e)
        {
            // TODO: refactoring
            var valueFilteredList = new BindingList<FigureBase>();
            var typeFilteredList = new BindingList<FigureBase>();

            var upperBoundFilled = double.TryParse(UpperBoundTextBox.Text.
                ReplaceByComma(),
                out double upperBound);
            var lowerBoundFilled = double.TryParse(LowerBoundTextBox.Text.
                ReplaceByComma(),
                out double lowerBound);

            if (string.IsNullOrEmpty(UpperBoundTextBox.Text) &&
                string.IsNullOrEmpty(LowerBoundTextBox.Text))
            {
                if (FigureTypeCheckedListBox.SelectedItems.Count == 0)
                {
                    Close();
                }
                else
                {
                    FigureTypeFilter(typeFilteredList);

                    var eventArgs = new FigureListEventArgs
                        (typeFilteredList);
                    FigureListFiltered?.Invoke(this, eventArgs);
                }
            }
            else if (!upperBoundFilled || !lowerBoundFilled)
            {
                _ = MessageBox.Show("Check range parameters!");
            }
            else
            {
                if ((upperBound <= lowerBound) && (lowerBound != 0))
                {
                    _ = MessageBox.Show("Wrong range!");
                }
                else
                {
                    if (FigureTypeCheckedListBox.SelectedItems.Count == 0)
                    {
                        typeFilteredList = FigureListMain;
                        FigureAreaFilter(typeFilteredList, valueFilteredList);
                    }
                    else
                    {
                        FigureTypeFilter(typeFilteredList);
                        FigureAreaFilter(typeFilteredList, valueFilteredList);
                    }

                    var eventArgs = new FigureListEventArgs
                        (valueFilteredList);
                    FigureListFiltered?.Invoke(this, eventArgs);
                }
            }
        }

        /// <summary>
        /// MM.
        /// </summary>
        /// <param name="type">MM.</param>
        public void FigureTypeFilter(
            BindingList<FigureBase> type)
        {
            var action = new Action<BindingList<FigureBase>>
            (
            (BindingList<FigureBase> type) =>
            {
                foreach (var figure in FigureListMain)
                {
                    foreach (var checkedFigure in
                        FigureTypeCheckedListBox.CheckedItems)
                    {
                        if (figure.GetType() ==
                            _figureTypes[_listBoxToFigureType
                            [checkedFigure.ToString()]])
                        {
                            type.Add(figure);
                        }
                    }
                }
            });

            action.Invoke(type);
        }

        /// <summary>
        /// fff.
        /// </summary>
        /// <param name="type">ggg.</param>
        /// <param name="value">hh.</param>
        public void FigureAreaFilter(BindingList<FigureBase> type,
            BindingList<FigureBase> value)
        {
            var action = new Action<BindingList<FigureBase>>
            (
            (BindingList<FigureBase> type) =>
            {
                foreach (var figure in type)
                {
                    if (((IAreaCalculatable)figure).Calculate() >=
                            Convert.ToDouble(LowerBoundTextBox.Text.
                            ReplaceByComma())
                        && ((IAreaCalculatable)figure).Calculate() <=
                            Convert.ToDouble(UpperBoundTextBox.Text.
                            ReplaceByComma()))
                    {
                        value.Add(figure);
                    }
                }
            });

            action.Invoke(type);
        }

        /// <summary>
        /// Click event to reset information in DataGrid to initial values.
        /// </summary>
        /// <param name="sender">ResetButton.</param>
        /// <param name="e">Event argument.</param>
        private void ResetButton_Click(object sender, EventArgs e)
        {
            var eventArgs = new FigureListEventArgs(FigureListMain);
            FigureListFiltered?.Invoke(this, eventArgs);
        }
    }
}
