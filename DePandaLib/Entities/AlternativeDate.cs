using DePandaLib.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DePandaClassLib.Entities
{
    public class AlternativeDate
    {
        public AlternativeDate(DateTime start, DateTime end)
        {
            this.StartDate = start;
            this.EndDate = end;
        }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string DateString { get { return StartDate.ToString("dd-MM-yyyy"); } }
        public string EndTimeString { get { return EndDate.ToString("HH:mm"); } }
        public string StartTimeString { get { return StartDate.ToString("HH:mm"); } }

        public static void Example()
        {
            if (DataStorageHandler.Storage.Settings.AlternativeDates.Count == 0)
            {
                var newAltDate = new DePandaClassLib.Entities.AlternativeDate(new DateTime(2020, 04, 07, 11, 0, 0), new DateTime(2020, 04, 07, 11, 0, 0));

                DataStorageHandler.Storage.Settings.AlternativeDates.Add(newAltDate);
            }
        }
    }
}