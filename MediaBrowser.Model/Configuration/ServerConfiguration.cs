﻿
namespace MediaBrowser.Model.Configuration
{
    public class ServerConfiguration : BaseApplicationConfiguration
    {
        public bool EnableInternetProviders { get; set; }
        public string WeatherZipCode { get; set; }
        public bool EnableUserProfiles { get; set; }

        public ServerConfiguration()
            : base()
        {
            EnableUserProfiles = true;
            WeatherZipCode = "02116";
        }
    }
}
