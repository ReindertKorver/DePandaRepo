using DePandaWinForms.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DePandaWinForms.Entities
{
    public class Navigation
    {
        public event EventHandler PageBound;

        private List<FormDataProvider> PageStack { get; set; }
        public FormDataProvider currentPage { get; set; }
        public int PageStackIndex { get; set; } = 0;

        public void PushNextPage(FormDataProvider newPage)
        {
            if (PageStack == null)
            {
                PageStack = new List<FormDataProvider>() { newPage };
            }
            else
            {
                PageStack.Add(newPage);
                DestroyPage();
            }

            PageStackIndex = PageStack.Count - 1;
            currentPage = newPage;
            ShowPage();
        }

        private void DestroyPage()
        {
            currentPage.OnFormDataUnLoad();
        }

        private void ShowPage()
        {
            PageBound?.Invoke(this, new FormEventArgs(currentPage));
            currentPage.OnFormDataLoad();
        }

        public void PopPage()
        {
            _ = PageStack ??
                throw new NullReferenceException("Can't go back a page when there are no pages in the stack");
            _ = (PageStack.Count <= 0) ?
                throw new IndexOutOfRangeException("Can't go back a page when there are no pages in the stack") : 0;
            _ = (PageStackIndex - 1 < 0) ?
                throw new IndexOutOfRangeException("Can't go back a page while being on the first page") : 0;
            DestroyPage();
            PageStack.RemoveAt(PageStackIndex);
            currentPage = PageStack[PageStackIndex - 1];
            PageStackIndex = PageStack.Count - 1;
            ShowPage();
        }
    }
}