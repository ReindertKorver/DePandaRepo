using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DePandaClassLib.Entities
{
    public class Settings
    {
        public string PinCode { get; set; } = "00000";
        public List<AlternativeDate> AlternativeDates { get; set; } = new List<AlternativeDate>();
        public List<WeekDay> WeekDays { get; set; } = new List<WeekDay>() { new WeekDay("xx:xx", "xx:xx"), new WeekDay("xx:xx", "xx:xx"), new WeekDay("xx:xx", "xx:xx"), new WeekDay("xx:xx", "xx:xx"), new WeekDay("xx:xx", "xx:xx"), new WeekDay("xx:xx", "xx:xx"), new WeekDay("xx:xx", "xx:xx") };
    }
}