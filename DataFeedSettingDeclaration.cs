namespace PanelDataFeed
{
    /// <summary>
    /// A single setting that your datafeed may need to run
    /// </summary>
    public class DataFeedSettingDeclaration
    {
        /// <summary>
        /// The name of your setting. Used as the key of the settings dictionary passed to you in the IDataFeedContext.
        /// </summary>
        public string SettingName { get; set; }

        /// <summary>
        /// A display description of this setting. This will be used if/when prompting the user for providing this setting. 
        /// </summary>
        public string SettingDescription { get; set; }

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
