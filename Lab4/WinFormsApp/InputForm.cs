using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp
{
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

        public InputForm()
        {
            InitializeComponent();
        }
    }
}
