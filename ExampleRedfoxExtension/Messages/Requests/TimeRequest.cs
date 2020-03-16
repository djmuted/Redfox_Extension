using ExampleRedfoxExtension.Messages.Responses;
using Newtonsoft.Json;
using Redfox.Messages;
using Redfox.Users;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExampleRedfoxExtension.Messages.Requests
{
    class TimeRequest : IZoneRequestMessage
    {
        //Example message property
        [JsonProperty]
        public string format;

        /// <summary>
        /// Provide the message type name via the base constructor. The usual naming convention is extensionNameAcronym#handlerName
        /// </summary>
        public TimeRequest() : base("ee#time")
        {
        }

        /// <summary>
        /// The actual message handler, called when user sends a message of its type.
        /// </summary>
        public override void Handle(User user)
        {
            Console.WriteLine("Handling time request message from extension!");
            var response = new TimeResponse(DateTime.Now, this.format);
            user.SendMessage(response);
        }
    }
}
