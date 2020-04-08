using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DePandaClassLib.Entities
{
    public class Identifier
    {
        public Identifier()
        {
            this.ID = Guid.NewGuid().ToString();
        }

        public string ID { get; set; }
    }
}