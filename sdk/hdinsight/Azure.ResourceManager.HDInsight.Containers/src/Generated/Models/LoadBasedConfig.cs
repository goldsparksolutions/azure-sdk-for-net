// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.ResourceManager.HDInsight.Containers.Models
{
    /// <summary> Profile of load based Autoscale. </summary>
    public partial class LoadBasedConfig
    {
        /// <summary> Initializes a new instance of LoadBasedConfig. </summary>
        /// <param name="minNodes"> User needs to set the minimum number of nodes for load based scaling, the load based scaling will use this to scale up and scale down between minimum and maximum number of nodes. </param>
        /// <param name="maxNodes"> User needs to set the maximum number of nodes for load based scaling, the load based scaling will use this to scale up and scale down between minimum and maximum number of nodes. </param>
        /// <param name="scalingRules"> The scaling rules. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="scalingRules"/> is null. </exception>
        public LoadBasedConfig(int minNodes, int maxNodes, IEnumerable<ScalingRule> scalingRules)
        {
            Argument.AssertNotNull(scalingRules, nameof(scalingRules));

            MinNodes = minNodes;
            MaxNodes = maxNodes;
            ScalingRules = scalingRules.ToList();
        }

        /// <summary> Initializes a new instance of LoadBasedConfig. </summary>
        /// <param name="minNodes"> User needs to set the minimum number of nodes for load based scaling, the load based scaling will use this to scale up and scale down between minimum and maximum number of nodes. </param>
        /// <param name="maxNodes"> User needs to set the maximum number of nodes for load based scaling, the load based scaling will use this to scale up and scale down between minimum and maximum number of nodes. </param>
        /// <param name="pollIntervalInSeconds"> User can specify the poll interval, this is the time period (in seconds) after which scaling metrics are polled for triggering a scaling operation. </param>
        /// <param name="cooldownPeriod"> This is a cool down period, this is a time period in seconds, which determines the amount of time that must elapse between a scaling activity started by a rule and the start of the next scaling activity, regardless of the rule that triggers it. The default value is 300 seconds. </param>
        /// <param name="scalingRules"> The scaling rules. </param>
        internal LoadBasedConfig(int minNodes, int maxNodes, int? pollIntervalInSeconds, int? cooldownPeriod, IList<ScalingRule> scalingRules)
        {
            MinNodes = minNodes;
            MaxNodes = maxNodes;
            PollIntervalInSeconds = pollIntervalInSeconds;
            CooldownPeriod = cooldownPeriod;
            ScalingRules = scalingRules;
        }

        /// <summary> User needs to set the minimum number of nodes for load based scaling, the load based scaling will use this to scale up and scale down between minimum and maximum number of nodes. </summary>
        public int MinNodes { get; set; }
        /// <summary> User needs to set the maximum number of nodes for load based scaling, the load based scaling will use this to scale up and scale down between minimum and maximum number of nodes. </summary>
        public int MaxNodes { get; set; }
        /// <summary> User can specify the poll interval, this is the time period (in seconds) after which scaling metrics are polled for triggering a scaling operation. </summary>
        public int? PollIntervalInSeconds { get; set; }
        /// <summary> This is a cool down period, this is a time period in seconds, which determines the amount of time that must elapse between a scaling activity started by a rule and the start of the next scaling activity, regardless of the rule that triggers it. The default value is 300 seconds. </summary>
        public int? CooldownPeriod { get; set; }
        /// <summary> The scaling rules. </summary>
        public IList<ScalingRule> ScalingRules { get; }
    }
}
