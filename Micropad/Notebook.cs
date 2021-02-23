using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Micropad
{
    public class Notebook
    {
        public string File { get; private set; }
        public string DateCreated { get; private set; }
        public string DateLastModified { get; private set; }
        public string Name { get; set; }
        public string FontFamily { get; set; }
        public string FontSize { get; set; }
        public string WindowColor { get; set; }
        public string BackColor { get; set; }
        public string ForeColor { get; set; }
        public List<NotebookPage> Pages { get; private set; }

        public Notebook()
        {
            Pages = new List<NotebookPage>();
        }

        public void Save(string file)
        {
            File = file;
        }

        public void Load(string file)
        {
            File = file;
        }

        public void AddPage(string name)
        {
            Pages.Add(new NotebookPage(this, name.Trim()));
        }

        public void DeletePage(NotebookPage page)
        {
            Pages.Remove(page);
        }
    }
}
