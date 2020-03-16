using System;
using System.Collections.Generic;
using System.Text;
using Redfox.Messages;
using Redfox.Users;

namespace ExampleRedfoxExtension.Messages.Responses
{
    public class TimeResponse : IZoneResponseMessage
    {
        public string time;
        public TimeResponse(DateTime _dateTime, string _format) : base("ee#time")
        {
            this.time = _dateTime.ToString(_format);
        }
    }

}