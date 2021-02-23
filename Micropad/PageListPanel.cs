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
    public partial class PageListPanel : UserControl
    {
        private readonly MainWindow MainWindow;
        private readonly Notebook Notebook;

        public NotebookPage SelectedPage { get; private set; }

        private PageListPanel()
        {
            InitializeComponent();
        }

        public PageListPanel(MainWindow win)
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
            MainWindow = win;
            Notebook = win.Notebook;
            LstPages.MouseDoubleClick += LstPages_MouseDoubleClick;
        }

        private void LstPages_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (LstPages.SelectedItem != null)
                SelectPage((NotebookPage)LstPages.SelectedItem);
        }

        private void UpdateList()
        {
            LstPages.Items.Clear();
            foreach (NotebookPage page in Notebook.Pages)
                LstPages.Items.Add(page);
        }

        private void BtnAddNewPage_Click(object sender, EventArgs e)
        {
            AddNewPage();
        }

        private void AddNewPage()
        {
            StringInputWindow win = new StringInputWindow("Add new page", "Enter page title:");
            string name = win.ShowDialog(this);

            if (!string.IsNullOrWhiteSpace(name))
            {
                Notebook.AddPage(name);
                UpdateList();
            }
        }

        private void BtnDeletePage_Click(object sender, EventArgs e)
        {
            DeleteSelectedPage();
        }

        private void DeleteSelectedPage()
        {
            if (LstPages.SelectedItem == null)
                return;
            
            if (Alert.Confirm("Delete selected page?"))
            {
                NotebookPage selected = (NotebookPage)LstPages.SelectedItem;
                MainWindow.PageDeleted(selected);
                Notebook.DeletePage(selected);
                UpdateList();
            }
        }

        private void SelectPage(NotebookPage page)
        {
            SelectedPage = page;
            MainWindow.PageSelected(page);
        }
    }
}
