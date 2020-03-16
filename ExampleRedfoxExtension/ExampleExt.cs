using NLog;
using System;

namespace ExampleRedfoxExtension
{
    public class ExampleExt : Redfox.Extensions.RedfoxExtension
    {
        /// <summary>
        /// Provide the extension name via the base constructor.
        /// </summary>
        public ExampleExt() : base("MyExampleExtension")
        {
            
        }

        /// <summary>
        /// Assign event handlers and zone authenticator in this method.
        /// </summary>
        public override void Initialize()
        {
            this.Zone.SetAuthenticator(new ExampleZoneAuthenticator());
            this.extensionEventManager.ZoneReady += OnZoneReady;
        }

        private void OnZoneReady()
        {
            LogManager.GetCurrentClassLogger().Info("The zone is ready I guess, hello from an example extension!");

        }
    }
}
