using DePandaConsole.Pages;
using System;
using System.Collections.Generic;
using System.Text;

namespace DePandaConsole.Entities
{
    public class Navigation
    {
        public Navigation(BasePage firstPage)
        {
            PageStack = new List<BasePage>() { firstPage };
            currentPage = firstPage;
        }

        public void Initialize()
        {
            //Can only show the page outside of the constructor
            //otherwise the navigator could be called within the page without being initialized
            ShowPage();
        }

        private List<BasePage> PageStack { get; set; }
        private BasePage currentPage { get; set; }
        public int PageStackIndex { get; set; } = 0;

        public void PushNextPage(BasePage newPage)
        {
            if (PageStack == null)
            {
                PageStack = new List<BasePage>() { newPage };
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
            currentPage.OnPageUnLoad();
        }

        private void ShowPage()
        {
            currentPage.OnPageLoad();
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