using DePandaLib.DAL;
using DePandaWinForms.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DePandaWinForms.DAL
{
    public abstract class FormDataProvider : Form
    {
        public void Init()
        {
            Navigator = new Navigation();
        }

        public static DataStorageHandler DataStorage { get; set; }
        public Navigation Navigator { get; set; }

        public virtual void OnFormDataUnLoad()
        {
        }

        public virtual void OnFormDataLoad()
        {
        }
    }
}