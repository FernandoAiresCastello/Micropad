using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Micropad
{
    public partial class StartWindow : Form
    {
        private RecentFiles RecentFiles;

        public StartWindow()
        {
            InitializeComponent();
            Shown += StartWindow_Shown;
        }

        private void StartWindow_Shown(object sender, EventArgs e)
        {
            UpdateRecentFilesList();
        }

        private void BtnCreateNotebook_Click(object sender, EventArgs e)
        {
            CreateNewNotebook();
        }

        private void UpdateRecentFilesList()
        {
            RecentFiles = new RecentFiles();
            LstFiles.Items.Clear();
            LstFiles.Items.AddRange(RecentFiles.Files.ToArray());
            LstFiles.DoubleClick += LstFiles_DoubleClick;
            LstFiles.MouseDown += LstFiles_MouseDown;
        }

        private void LstFiles_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                LstFiles.SelectedIndex = LstFiles.IndexFromPoint(e.Location);
        }

        private void LstFiles_DoubleClick(object sender, EventArgs e)
        {
            object item = LstFiles.SelectedItem;
            if (item != null)
                OpenNotebook((string)item);
        }

        private void CreateNewNotebook()
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "MicroPad notebooks | *.mpn";

            if (dlg.ShowDialog(this) == DialogResult.OK)
            {
                File.Create(dlg.FileName).Close();
                OpenNotebook(dlg.FileName);
            }
        }

        private void BtnOpenNotebook_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "MicroPad notebooks | *.mpn";

            if (dlg.ShowDialog(this) == DialogResult.OK)
            {
                OpenNotebook(dlg.FileName);
            }
        }

        private void BtnOpenFileLocation_Click(object sender, EventArgs e)
        {
            OpenSelectedFileLocation();
        }

        private void BtnRemoveFromList_Click(object sender, EventArgs e)
        {
            RemoveFromRecentFilesList();
        }

        private void OpenSelectedFileLocation()
        {
            string path = (string)LstFiles.SelectedItem;

            if (path == null)
            {
                Alert.Warning("Select a file to open location");
                return;
            }

            string folder = Path.GetDirectoryName(path);
            Process.Start("explorer.exe", folder);
        }

        private void RemoveFromRecentFilesList()
        {
            string path = (string)LstFiles.SelectedItem;

            if (path == null)
            {
                Alert.Warning("Select a file to remove");
                return;
            }

            if (Alert.Confirm("Remove this file from the list?"))
            {
                RecentFiles.Remove(path);
                RecentFiles.Save();
                UpdateRecentFilesList();
            }
        }

        private void OpenNotebook(string path)
        {
            try
            {
                Notebook notebook = new Notebook();
                notebook.Load(path);

                RecentFiles.Add(path);
                RecentFiles.Save();
                UpdateRecentFilesList();
                Hide();

                MainWindow mainWindow = new MainWindow(this, notebook);
                mainWindow.Show(this);
            }
            catch (Exception ex)
            {
                Alert.Error("Couldn't open notebook file: " + path);
                Debug.WriteLine(ex);
            }
        }
    }
}
