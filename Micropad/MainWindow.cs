using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Micropad
{
    public partial class MainWindow : Form
    {
        public Notebook Notebook { get; private set; }

        private readonly StartWindow StartWindow;
        private readonly PageListPanel PageListPanel;
        private readonly TextPanel TextPanel;
        private NotebookPage CurrentPage;

        private MainWindow()
        {
            InitializeComponent();
        }

        public MainWindow(StartWindow win, Notebook notebook)
        {
            InitializeComponent();
            StartWindow = win;
            Notebook = notebook;
            PageListPanel = new PageListPanel(this);
            TextPanel = new TextPanel(this);
            PageListPanel.Parent = SplitContainer.Panel1;
            TextPanel.Parent = SplitContainer.Panel2;
            Text = "MicroPad - " + notebook.File;
            FormClosed += MainWindow_FormClosed;
        }

        private void MainWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (e.CloseReason != CloseReason.ApplicationExitCall)
                StartWindow.Show();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            SaveNotebook();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void PageSelected(NotebookPage page)
        {
            if (!TextPanel.Enabled)
                TextPanel.Enabled = true;

            if (CurrentPage != null)
                CurrentPage.Text = TextPanel.Content;

            CurrentPage = page;
            TextPanel.Content = page.Text;
        }

        public void PageDeleted(NotebookPage page)
        {
            if (page == CurrentPage)
            {
                TextPanel.Content = null;
                TextPanel.Enabled = false;
            }
        }

        private void SaveNotebook()
        {
        }
    }
}
