using System;

namespace PanelDataFeed
{
    /// <summary>
    /// An interface for communicating with the associated panels
    /// </summary>
    public interface IPanelCommunicator
    {
        /// <summary>
        /// Sends the provided message to the panel. Note, delivery of a message is NOT ensured (Panel may not be active)
        /// so code accordingly. 
        /// </summary>
        /// <param name="message"></param>
        void SendMessageToPanel(object message);
    }
}
