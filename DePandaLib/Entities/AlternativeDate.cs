﻿using DePandaLib.DAL;
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

    }
    public class WeekDay
    {
        public WeekDay(DateTime start, DateTime end)
        {
            this.OpenTime = start;
            this.CloseTime = end;
        }

        public DateTime OpenTime { get; set; }
        public DateTime CloseTime { get; set; }

    }
}