// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Nginx.Models
{
    /// <summary> The NginxDeploymentUpdateProperties. </summary>
    public partial class NginxDeploymentUpdateProperties
    {
        /// <summary> Initializes a new instance of NginxDeploymentUpdateProperties. </summary>
        public NginxDeploymentUpdateProperties()
        {
        }

        /// <summary> Gets or sets the enable diagnostics support. </summary>
        public bool? EnableDiagnosticsSupport { get; set; }
        /// <summary> Gets or sets the logging. </summary>
        internal NginxLogging Logging { get; set; }
        /// <summary> Gets or sets the logging storage account. </summary>
        public NginxStorageAccount LoggingStorageAccount
        {
            get => Logging is null ? default : Logging.StorageAccount;
            set
            {
                if (Logging is null)
                    Logging = new NginxLogging();
                Logging.StorageAccount = value;
            }
        }
    }
}
