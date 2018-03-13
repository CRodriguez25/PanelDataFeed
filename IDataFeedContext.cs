using System;
using System.Collections.Generic;

namespace PanelDataFeed
{
    public interface IDataFeedContext : IConvertible
    {
        /// <summary>
        /// Returns the location of the program that this DataFeed is linked to.
        /// </summary>
        string GetExeLocation();

        /// <summary>
        /// Returns the settings for your DataFeed
        /// </summary>
        Dictionary<string, DataFeedSetting> GetSettings();
    }
}
