using DePandaConsole.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DePandaConsole.Pages
{
    /// <summary>
    /// Classes extending this class can be used to display pages in the console
    /// </summary>
    public abstract class BasePage
    {
        //static because we only want one
        public static Navigation Navigator { get; set; }

        public virtual void Initialize()
        {
            Navigator = new Navigation(this);
            Navigator.Initialize();
        }

        /// <summary>
        /// Called when the page is shown on the screen
        /// </summary>
        public virtual void OnPageLoad()
        {
        }

        /// <summary>
        /// Called when the page is removed from the screen
        /// </summary>
        public virtual void OnPageUnLoad()
        {
            Console.Clear();
        }
    }
}