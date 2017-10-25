using System;

namespace PanelDataFeed
{
    public interface IPanelCommunicator
    {
        void SendMessageToPanel(string message);
    }
}
