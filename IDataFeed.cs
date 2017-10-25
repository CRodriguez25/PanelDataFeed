using System;

namespace PanelDataFeed
{
    public interface IDataFeed
    {
        void Start(IPanelCommunicator panelCommunicator);
        
    }
}
