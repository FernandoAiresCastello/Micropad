using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Micropad
{
    public partial class TextPanel : UserControl
    {
        private readonly MainWindow MainWindow;
        private readonly Notebook Notebook;

        public string Content
        {
            get => TxtContent.Text;

            set
            {
                TxtContent.Text = value;
                TxtContent.Select(0, 0);
            }
        }

    private TextPanel()
        {
            InitializeComponent();
        }

        public TextPanel(MainWindow win)
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
            Enabled = false;
            TxtContent.Text = "";
            MainWindow = win;
            Notebook = win.Notebook;
        }
    }
}
