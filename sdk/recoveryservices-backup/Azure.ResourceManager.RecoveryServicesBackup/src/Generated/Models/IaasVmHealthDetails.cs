// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    /// <summary> Azure IaaS VM workload-specific Health Details. </summary>
    public partial class IaasVmHealthDetails : ResourceHealthDetails
    {
        /// <summary> Initializes a new instance of IaasVmHealthDetails. </summary>
        public IaasVmHealthDetails()
        {
        }

        /// <summary> Initializes a new instance of IaasVmHealthDetails. </summary>
        /// <param name="code"> Health Code. </param>
        /// <param name="title"> Health Title. </param>
        /// <param name="message"> Health Message. </param>
        /// <param name="recommendations"> Health Recommended Actions. </param>
        internal IaasVmHealthDetails(int? code, string title, string message, IReadOnlyList<string> recommendations) : base(code, title, message, recommendations)
        {
        }
    }
}
