using DePandaWinForms.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DePandaWinForms.Entities
{
    public class FormEventArgs : EventArgs
    {
        public FormEventArgs(FormDataProvider form)
        {
            this.form = form;
        }
        public FormDataProvider form { get; set; }
    }
}