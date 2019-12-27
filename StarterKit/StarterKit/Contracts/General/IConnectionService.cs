using Plugin.Connectivity.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace StarterKit.Contracts.Services.General
{
    /// <summary>
    /// Connection Service
    /// </summary>
    public interface IConnectionService
    {
        /// <summary>
        /// Is Connected
        /// </summary>
        bool IsConnected { get; }

        /// <summary>
        /// Connectivity Changed
        /// </summary>
        event ConnectivityChangedEventHandler ConnectivityChanged;
    }
}
