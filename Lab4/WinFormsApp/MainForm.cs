using System.ComponentModel;
using System.Xml.Serialization;
using Model;

namespace WinFormsApp
{
    /// <summary>
    /// Class of the main form.
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// List of FigureBase objects.
        /// </summary>
        private BindingList<FigureBase> _figureList = new();

        /// <summary>
        /// List of FigureBase objects, created by filter.
        /// </summary>
        private BindingList<FigureBase> _filteredList = new();

        /// <summary>
        /// Main form instance constructor.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();

            var source = new BindingSource(_figureList, null);
            FigureDataGridView.DataSource = source;
        }

        /// <summary>
        /// Click event to add an FigureBase object to the list.
        /// </summary>
        /// <param name="sender">AddButton.</param>
        /// <param name="e">Event argument.</param>
        private void AddButton_Click(object sender, EventArgs e)
        {
            var newInputForm = new InputForm();

            newInputForm.Show();

            newInputForm.FigureAdded += (_, args) =>
            {
                _figureList.Add(args.Figure);

                FigureDataGridView.DataSource = _figureList;
            };

            newInputForm.Closed += (_, _) =>
            {
                AddButton.Enabled = true;
            };

            AddButton.Enabled = false;
        }

        /// <summary>
        /// Click event to remove an FigureBase object from the list.
        /// </summary>
        /// <param name="sender">RemoveButton.</param>
        /// <param name="e">Event argument.</param>
        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (FigureDataGridView.SelectedCells.Count != 0)
            {
                foreach (DataGridViewRow row in
                    FigureDataGridView.SelectedRows)
                {
                    _ = _figureList.Remove(row.DataBoundItem as FigureBase);

                    _ = _filteredList.Remove(row.DataBoundItem as FigureBase);
                }
            }
        }

        /// <summary>
        /// Click event to remove all FigureBase objects from the list.
        /// </summary>
        /// <param name="sender">ClearButton.</param>
        /// <param name="e">Event argument.</param>
        private void ClearButton_Click(object sender, EventArgs e)
        {
            _figureList.Clear();
            _filteredList.Clear();
        }

        /// <summary>
        /// Click event to filter FigureBase objects from the list.
        /// </summary>
        /// <param name="sender">FilterButton.</param>
        /// <param name="e">Event argument.</param>
        private void FilterButton_Click(object sender, EventArgs e)
        {
            var newFilterForm = new FilterForm();

            newFilterForm.FigureListMain = _figureList;

            newFilterForm.Show();

            newFilterForm.FigureListFiltered += (_, args) =>
            {
                FigureDataGridView.DataSource = args.FigureListFiltered;
                _filteredList = args.FigureListFiltered;
            };

            newFilterForm.Closed += (_, _) =>
            {
                FilterButton.Enabled = true;
            };

            FilterButton.Enabled = false;
        }

        /// <summary>
        /// Click event to save FigurenBase objects from the list in file.
        /// </summary>
        /// <param name="sender">SaveToolStripMenuItem.</param>
        /// <param name="e">Event argument.</param>
        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var fileBrowser = new SaveFileDialog
            {
                Filter = "FigureArea (*.fgar)|*.fgar"
            };

            _ = fileBrowser.ShowDialog();

            var path = fileBrowser.FileName;

            var xmlSerializer = new XmlSerializer
                (typeof(BindingList<FigureBase>));

            if (string.IsNullOrEmpty(path))
            {
                return;
            }

            using (var file = File.Create(path))
            {
                xmlSerializer.Serialize(file, FigureDataGridView.DataSource);
                file.Close();
            }
        }

        /// <summary>
        /// Click event to load FigureBase objects from the file.
        /// </summary>
        /// <param name="sender">LoadToolStripMenuItem.</param>
        /// <param name="e">Event argument.</param>
        private void LoadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var fileBrowser = new OpenFileDialog
            {
                Filter = "FigureArea (*.fgar)|*.fgar"
            };

            _ = fileBrowser.ShowDialog();

            var path = fileBrowser.FileName;

            if (string.IsNullOrEmpty(path))
            {
                return;
            }

            var xmlSerializer = new XmlSerializer
                (typeof(BindingList<FigureBase>));

            try
            {
                using (var file = new StreamReader(path))
                {
                    _figureList = (BindingList<FigureBase>)xmlSerializer.Deserialize(file);
                }

                FigureDataGridView.DataSource = _figureList;
            }

            catch (Exception exception)
            {
                if (exception.GetType() ==
                    typeof(InvalidOperationException))
                {
                    _ = MessageBox.Show("File upload error.");
                }
                else if (exception.GetType() ==
                    typeof(ArgumentException))
                {
                    _ = MessageBox.Show("The data structure of the " +
                        "uploaded file is broken.");
                }
                else
                {
                    throw;
                }
            }
        }
    }
}
