using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Micropad
{
    public class NotebookPage
    {
        public Notebook Notebook { get; private set; }
        public string Title { set; get; }
        public string Text { set; get; }

        public NotebookPage(Notebook notebook, string title)
        {
            Notebook = notebook;
            Title = title;
        }

        public override string ToString()
        {
            return Title;
        }
    }
}
