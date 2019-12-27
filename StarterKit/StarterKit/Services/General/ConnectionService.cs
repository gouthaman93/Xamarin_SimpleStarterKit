using Plugin.Connectivity;
using Plugin.Connectivity.Abstractions;
using StarterKit.Contracts.Services.General;
using System;
using System.Collections.Generic;
using System.Text;

namespace StarterKit.Services.General
{
    public class ConnectionService : IConnectionService
    {
        public bool IsConnected => _connectivity.IsConnected;

        public event ConnectivityChangedEventHandler ConnectivityChanged;

        private readonly IConnectivity _connectivity;

        public ConnectionService()
        {
            _connectivity = CrossConnectivity.Current;
            _connectivity.ConnectivityChanged += Connectivity_ConnectivityChanged;
        }

        private void Connectivity_ConnectivityChanged(object sender, ConnectivityChangedEventArgs e)
        {
            ConnectivityChanged?.Invoke(this, new ConnectivityChangedEventArgs() { IsConnected = e.IsConnected });
        }
    }
}
