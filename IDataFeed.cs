using System.Collections.Generic;

namespace PanelDataFeed
{
    /// <summary>
    /// A DataFeed will provide the panel with a stream of data that it can optionally respond to. 
    /// </summary>
    public interface IDataFeed
    {

        /// <summary>
        /// Called when data feed should start providing data. An IPanelCommunicator is provided in order to send that data
        /// to the panel. This method will be called in its own thread, so feel free to add loops and sleeps, as it will not
        /// affect the running of the Desktop Client.
        /// </summary>
        /// <param name="dataFeedContext">The context of this datafeed. Provides some useful information that may be needed for your datafeed to run</param>
        /// <param name="panelCommunicator">A communicator used to send messages to the panel.</param>
        void Start(IDataFeedContext dataFeedContext, IPanelCommunicator panelCommunicators);

        /// <summary>
        /// Implement this method to state which settings are required for your DataFeed to function (i.e. location to a certain file or directory).
        /// This method will be used by the client to validate that the user has provided the settings needed for your data feed to run, and if not,
        /// will prompt the user for those settings. 
        /// </summary>
        /// <returns></returns>
        IEnumerable<DataFeedSettingDeclaration> RequiredSettings();
    }
}
