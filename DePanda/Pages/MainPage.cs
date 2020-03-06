using System;
using System.Collections.Generic;
using System.Text;

namespace DePandaConsole.Pages
{
    public class MainPage : BasePage
    {
        public override void OnPageLoad()
        {
            base.OnPageLoad();

            Console.WriteLine("Want to create a new reservation?");
            string res = Console.ReadLine();
            if (res == "yes")
                Navigator.PushNextPage(new MenuPage());
            else
                Console.WriteLine("Me neither :)");
        }

        public override void OnPageUnLoad()
        {
            base.OnPageUnLoad();
        }
    }
}