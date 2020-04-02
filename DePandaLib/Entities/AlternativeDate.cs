using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DePandaClassLib.Entities
{
    public class AlternativeDate
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        /// <summary>
        /// Returns the start and end date in the form of a tuple
        /// Example of result: result.Item1= 02-04-2020, result.Item2= 10:00, result.Item3= 13:00
        /// </summary>
        /// <returns></returns>
        public (string, string, string) ToTupleString()
        {
            return (StartDate.ToString("dd-MM-yyyy"), StartDate.ToString("hh:mm"), EndDate.ToString("hh:mm"));
        }
    }
}