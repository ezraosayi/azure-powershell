﻿// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using Microsoft.Azure.Commands.Network.Models;

namespace Microsoft.Azure.Commands.Network
{
    [Cmdlet(VerbsCommon.New, ResourceManager.Common.AzureRMConstants.AzureRMPrefix + "FirewallPolicyApplicationRuleCondition", SupportsShouldProcess = true, DefaultParameterSetName = AzureFirewallPolicyApplicationRuleConditionParameterSets.TargetFqdn), OutputType(typeof(PSAzureFirewallPolicyApplicationRuleCondition))]
    public class NewAzFirewallPolicyApplicationRuleConditionCommand : AzureFirewallPolicyBaseCmdlet
    {
        [Parameter(
            Mandatory = true,
            ParameterSetName = AzureFirewallPolicyApplicationRuleConditionParameterSets.TargetFqdn,
            HelpMessage = "The name of the Application Rule")]
        [Parameter(
            Mandatory = true,
            ParameterSetName = AzureFirewallPolicyApplicationRuleConditionParameterSets.FqdnTag,
            HelpMessage = "The name of the Application Rule")]
        [ValidateNotNullOrEmpty]
        public virtual string Name { get; set; }

        [Parameter(
            Mandatory = false,
            HelpMessage = "The description of the rule")]
        [ValidateNotNullOrEmpty]
        public string Description { get; set; }

        [Parameter(
            Mandatory = false,
            HelpMessage = "The source addresses of the rule")]
        [ValidateNotNullOrEmpty]
        public string[] SourceAddress { get; set; }

        [Parameter(
            Mandatory = true,
            ParameterSetName = AzureFirewallPolicyApplicationRuleConditionParameterSets.TargetFqdn,
            HelpMessage = "The target FQDNs of the rule")]
        [ValidateNotNullOrEmpty]
        public string[] TargetFqdns { get; set; }

        [Parameter(
            Mandatory = true,
            ParameterSetName = AzureFirewallPolicyApplicationRuleConditionParameterSets.FqdnTag,
            HelpMessage = "The FQDN Tags of the rule")]
        [ValidateNotNullOrEmpty]
        public string[] FqdnTags { get; set; }

        [Parameter(
            Mandatory = true,
            ParameterSetName = AzureFirewallPolicyApplicationRuleConditionParameterSets.TargetFqdn,
            HelpMessage = "The protocols of the rule")]
        [ValidateNotNullOrEmpty]
        public string[] Protocol { get; set; }

        public override void Execute()
        {
            base.Execute();

            if (FqdnTags != null)
            {
                this.Protocol = new string[] { "http", "https" };
                FqdnTags = AzureFirewallFqdnTagHelper.MapUserInputToAllowedFqdnTags(FqdnTags, this.AzureFirewallPolicyFqdnTagClient).ToArray();
            }

            var protocolsAsWeExpectThem = MapUserProtocolsToFirewallPolicyProtocols(Protocol?.ToList());

            var applicationRule = new PSAzureFirewallPolicyApplicationRuleCondition
            {
                Name = this.Name,
                Description = this.Description,
                SourceAddresses = this.SourceAddress?.ToList(),
                Protocols = protocolsAsWeExpectThem,
                TargetFqdns = this.TargetFqdns?.ToList(),
                FqdnTags = this.FqdnTags?.ToList()
            };
            WriteObject(applicationRule);
        }

        private List<PSAzureFirewallPolicyApplicationRuleProtocol> MapUserProtocolsToFirewallPolicyProtocols(List<string> userProtocols)
        {
            return userProtocols.Select(PSAzureFirewallPolicyApplicationRuleProtocol.MapUserInputToApplicationRuleProtocol)?.ToList();
        }
    }
}
