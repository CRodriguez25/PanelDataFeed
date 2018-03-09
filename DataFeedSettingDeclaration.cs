using System;

namespace PanelDataFeed
{
    /// <summary>
    /// A single setting that your datafeed may need to run
    /// </summary>
    public class DataFeedSettingDeclaration : MarshalByRefObject
    {
        /// <summary>
        /// The name of your setting. Used as the key of the settings dictionary passed to you in the IDataFeedContext.
        /// </summary>
        public string SettingName { get; set; }

        /// <summary>
        /// What text will be displayeed to the user when requesting this setting. For example, "Please specify location of folder..."
        /// </summary>
        public string DisplayRequestForSetting { get; set; }

        /// <summary>
        /// The default value of this setting. If your setting has a default value, yhe user will not be prompted for the setting UNLESS the setting
        /// is a file or directory which does not exist on their machine. 
        /// </summary>
        public string DefaultValue { get; set; }

        /// <summary>
        /// Explicitly state the type of setting this is (File, Directory, or just Text). This is used by the desktop client to better
        /// ask for input from the user.
        /// </summary>
        public SettingType SettingType { get; set; }
    }

    public enum SettingType
    {
        Text = 0,
        File = 1,
        Directory = 2
    }
}
