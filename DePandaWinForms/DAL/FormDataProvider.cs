using DePandaLib.DAL;
using DePandaWinForms.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DePandaWinForms.DAL
{
    public class FormDataProvider : Form
    {
        public void Init()
        {
            Navigator = new Navigation();
        }

        public static DataStorageHandler DataStorage { get; } = new DataStorageHandler(Properties.Resources.DataStorage);
        public Navigation Navigator { get; private set; }

        public virtual void OnFormDataUnLoad()
        {
        }

        public virtual void OnFormDataLoad()
        {
        }
    }
}