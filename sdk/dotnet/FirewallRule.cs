// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace Pulumiverse.Unifi
{
    /// <summary>
    /// `unifi.FirewallRule` manages an individual firewall rule on the gateway.
    /// 
    /// ## Example Usage
    /// 
    /// ```csharp
    /// using Pulumi;
    /// using Unifi = Pulumiverse.Unifi;
    /// 
    /// class MyStack : Stack
    /// {
    ///     public MyStack()
    ///     {
    ///         var config = new Config();
    ///         var ipAddress = config.Require("ipAddress");
    ///         var dropAll = new Unifi.FirewallRule("dropAll", new Unifi.FirewallRuleArgs
    ///         {
    ///             Action = "drop",
    ///             Ruleset = "LAN_IN",
    ///             RuleIndex = 2011,
    ///             Protocol = "all",
    ///             DstAddress = ipAddress,
    ///         });
    ///     }
    /// 
    /// }
    /// ```
    /// 
    /// ## Import
    /// 
    /// # import using the ID from the controller API/UI
    /// 
    /// ```sh
    ///  $ pulumi import unifi:index/firewallRule:FirewallRule my_rule 5f7080eb6b8969064f80494f
    /// ```
    /// </summary>
    [UnifiResourceType("unifi:index/firewallRule:FirewallRule")]
    public partial class FirewallRule : Pulumi.CustomResource
    {
        /// <summary>
        /// The action of the firewall rule. Must be one of `drop`, `accept`, or `reject`.
        /// </summary>
        [Output("action")]
        public Output<string> Action { get; private set; } = null!;

        /// <summary>
        /// The destination address of the firewall rule.
        /// </summary>
        [Output("dstAddress")]
        public Output<string?> DstAddress { get; private set; } = null!;

        /// <summary>
        /// The destination firewall group IDs of the firewall rule.
        /// </summary>
        [Output("dstFirewallGroupIds")]
        public Output<ImmutableArray<string>> DstFirewallGroupIds { get; private set; } = null!;

        /// <summary>
        /// The destination network ID of the firewall rule.
        /// </summary>
        [Output("dstNetworkId")]
        public Output<string?> DstNetworkId { get; private set; } = null!;

        /// <summary>
        /// The destination network type of the firewall rule. Can be one of `ADDRv4` or `NETv4`. Defaults to `NETv4`.
        /// </summary>
        [Output("dstNetworkType")]
        public Output<string?> DstNetworkType { get; private set; } = null!;

        /// <summary>
        /// The destination port of the firewall rule.
        /// </summary>
        [Output("dstPort")]
        public Output<string?> DstPort { get; private set; } = null!;

        /// <summary>
        /// ICMP type name.
        /// </summary>
        [Output("icmpTypename")]
        public Output<string?> IcmpTypename { get; private set; } = null!;

        /// <summary>
        /// Specify whether the rule matches on IPsec packets. Can be one of `match-ipset` or `match-none`.
        /// </summary>
        [Output("ipSec")]
        public Output<string?> IpSec { get; private set; } = null!;

        /// <summary>
        /// Enable logging for the firewall rule.
        /// </summary>
        [Output("logging")]
        public Output<bool?> Logging { get; private set; } = null!;

        /// <summary>
        /// The name of the firewall rule.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// The protocol of the rule.
        /// </summary>
        [Output("protocol")]
        public Output<string> Protocol { get; private set; } = null!;

        /// <summary>
        /// The index of the rule. Must be &gt;= 2000 &lt; 3000 or &gt;= 4000 &lt; 5000.
        /// </summary>
        [Output("ruleIndex")]
        public Output<int> RuleIndex { get; private set; } = null!;

        /// <summary>
        /// The ruleset for the rule. This is from the perspective of the security gateway. Must be one of `WAN_IN`, `WAN_OUT`, `WAN_LOCAL`, `LAN_IN`, `LAN_OUT`, `LAN_LOCAL`, `GUEST_IN`, `GUEST_OUT`, `GUEST_LOCAL`, `WANv6_IN`, `WANv6_OUT`, `WANv6_LOCAL`, `LANv6_IN`, `LANv6_OUT`, `LANv6_LOCAL`, `GUESTv6_IN`, `GUESTv6_OUT`, or `GUESTv6_LOCAL`.
        /// </summary>
        [Output("ruleset")]
        public Output<string> Ruleset { get; private set; } = null!;

        /// <summary>
        /// The name of the site to associate the firewall rule with.
        /// </summary>
        [Output("site")]
        public Output<string> Site { get; private set; } = null!;

        /// <summary>
        /// The source address for the firewall rule.
        /// </summary>
        [Output("srcAddress")]
        public Output<string?> SrcAddress { get; private set; } = null!;

        /// <summary>
        /// The source firewall group IDs for the firewall rule.
        /// </summary>
        [Output("srcFirewallGroupIds")]
        public Output<ImmutableArray<string>> SrcFirewallGroupIds { get; private set; } = null!;

        /// <summary>
        /// The source MAC address of the firewall rule.
        /// </summary>
        [Output("srcMac")]
        public Output<string?> SrcMac { get; private set; } = null!;

        /// <summary>
        /// The source network ID for the firewall rule.
        /// </summary>
        [Output("srcNetworkId")]
        public Output<string?> SrcNetworkId { get; private set; } = null!;

        /// <summary>
        /// The source network type of the firewall rule. Can be one of `ADDRv4` or `NETv4`. Defaults to `NETv4`.
        /// </summary>
        [Output("srcNetworkType")]
        public Output<string?> SrcNetworkType { get; private set; } = null!;

        /// <summary>
        /// Match where the state is established.
        /// </summary>
        [Output("stateEstablished")]
        public Output<bool?> StateEstablished { get; private set; } = null!;

        /// <summary>
        /// Match where the state is invalid.
        /// </summary>
        [Output("stateInvalid")]
        public Output<bool?> StateInvalid { get; private set; } = null!;

        /// <summary>
        /// Match where the state is new.
        /// </summary>
        [Output("stateNew")]
        public Output<bool?> StateNew { get; private set; } = null!;

        /// <summary>
        /// Match where the state is related.
        /// </summary>
        [Output("stateRelated")]
        public Output<bool?> StateRelated { get; private set; } = null!;


        /// <summary>
        /// Create a FirewallRule resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public FirewallRule(string name, FirewallRuleArgs args, CustomResourceOptions? options = null)
            : base("unifi:index/firewallRule:FirewallRule", name, args ?? new FirewallRuleArgs(), MakeResourceOptions(options, ""))
        {
        }

        private FirewallRule(string name, Input<string> id, FirewallRuleState? state = null, CustomResourceOptions? options = null)
            : base("unifi:index/firewallRule:FirewallRule", name, state, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                PluginDownloadURL = "https://github.com/pulumiverse/pulumi-unifi/releases/download/${VERSION}",
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing FirewallRule resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static FirewallRule Get(string name, Input<string> id, FirewallRuleState? state = null, CustomResourceOptions? options = null)
        {
            return new FirewallRule(name, id, state, options);
        }
    }

    public sealed class FirewallRuleArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The action of the firewall rule. Must be one of `drop`, `accept`, or `reject`.
        /// </summary>
        [Input("action", required: true)]
        public Input<string> Action { get; set; } = null!;

        /// <summary>
        /// The destination address of the firewall rule.
        /// </summary>
        [Input("dstAddress")]
        public Input<string>? DstAddress { get; set; }

        [Input("dstFirewallGroupIds")]
        private InputList<string>? _dstFirewallGroupIds;

        /// <summary>
        /// The destination firewall group IDs of the firewall rule.
        /// </summary>
        public InputList<string> DstFirewallGroupIds
        {
            get => _dstFirewallGroupIds ?? (_dstFirewallGroupIds = new InputList<string>());
            set => _dstFirewallGroupIds = value;
        }

        /// <summary>
        /// The destination network ID of the firewall rule.
        /// </summary>
        [Input("dstNetworkId")]
        public Input<string>? DstNetworkId { get; set; }

        /// <summary>
        /// The destination network type of the firewall rule. Can be one of `ADDRv4` or `NETv4`. Defaults to `NETv4`.
        /// </summary>
        [Input("dstNetworkType")]
        public Input<string>? DstNetworkType { get; set; }

        /// <summary>
        /// The destination port of the firewall rule.
        /// </summary>
        [Input("dstPort")]
        public Input<string>? DstPort { get; set; }

        /// <summary>
        /// ICMP type name.
        /// </summary>
        [Input("icmpTypename")]
        public Input<string>? IcmpTypename { get; set; }

        /// <summary>
        /// Specify whether the rule matches on IPsec packets. Can be one of `match-ipset` or `match-none`.
        /// </summary>
        [Input("ipSec")]
        public Input<string>? IpSec { get; set; }

        /// <summary>
        /// Enable logging for the firewall rule.
        /// </summary>
        [Input("logging")]
        public Input<bool>? Logging { get; set; }

        /// <summary>
        /// The name of the firewall rule.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// The protocol of the rule.
        /// </summary>
        [Input("protocol", required: true)]
        public Input<string> Protocol { get; set; } = null!;

        /// <summary>
        /// The index of the rule. Must be &gt;= 2000 &lt; 3000 or &gt;= 4000 &lt; 5000.
        /// </summary>
        [Input("ruleIndex", required: true)]
        public Input<int> RuleIndex { get; set; } = null!;

        /// <summary>
        /// The ruleset for the rule. This is from the perspective of the security gateway. Must be one of `WAN_IN`, `WAN_OUT`, `WAN_LOCAL`, `LAN_IN`, `LAN_OUT`, `LAN_LOCAL`, `GUEST_IN`, `GUEST_OUT`, `GUEST_LOCAL`, `WANv6_IN`, `WANv6_OUT`, `WANv6_LOCAL`, `LANv6_IN`, `LANv6_OUT`, `LANv6_LOCAL`, `GUESTv6_IN`, `GUESTv6_OUT`, or `GUESTv6_LOCAL`.
        /// </summary>
        [Input("ruleset", required: true)]
        public Input<string> Ruleset { get; set; } = null!;

        /// <summary>
        /// The name of the site to associate the firewall rule with.
        /// </summary>
        [Input("site")]
        public Input<string>? Site { get; set; }

        /// <summary>
        /// The source address for the firewall rule.
        /// </summary>
        [Input("srcAddress")]
        public Input<string>? SrcAddress { get; set; }

        [Input("srcFirewallGroupIds")]
        private InputList<string>? _srcFirewallGroupIds;

        /// <summary>
        /// The source firewall group IDs for the firewall rule.
        /// </summary>
        public InputList<string> SrcFirewallGroupIds
        {
            get => _srcFirewallGroupIds ?? (_srcFirewallGroupIds = new InputList<string>());
            set => _srcFirewallGroupIds = value;
        }

        /// <summary>
        /// The source MAC address of the firewall rule.
        /// </summary>
        [Input("srcMac")]
        public Input<string>? SrcMac { get; set; }

        /// <summary>
        /// The source network ID for the firewall rule.
        /// </summary>
        [Input("srcNetworkId")]
        public Input<string>? SrcNetworkId { get; set; }

        /// <summary>
        /// The source network type of the firewall rule. Can be one of `ADDRv4` or `NETv4`. Defaults to `NETv4`.
        /// </summary>
        [Input("srcNetworkType")]
        public Input<string>? SrcNetworkType { get; set; }

        /// <summary>
        /// Match where the state is established.
        /// </summary>
        [Input("stateEstablished")]
        public Input<bool>? StateEstablished { get; set; }

        /// <summary>
        /// Match where the state is invalid.
        /// </summary>
        [Input("stateInvalid")]
        public Input<bool>? StateInvalid { get; set; }

        /// <summary>
        /// Match where the state is new.
        /// </summary>
        [Input("stateNew")]
        public Input<bool>? StateNew { get; set; }

        /// <summary>
        /// Match where the state is related.
        /// </summary>
        [Input("stateRelated")]
        public Input<bool>? StateRelated { get; set; }

        public FirewallRuleArgs()
        {
        }
    }

    public sealed class FirewallRuleState : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The action of the firewall rule. Must be one of `drop`, `accept`, or `reject`.
        /// </summary>
        [Input("action")]
        public Input<string>? Action { get; set; }

        /// <summary>
        /// The destination address of the firewall rule.
        /// </summary>
        [Input("dstAddress")]
        public Input<string>? DstAddress { get; set; }

        [Input("dstFirewallGroupIds")]
        private InputList<string>? _dstFirewallGroupIds;

        /// <summary>
        /// The destination firewall group IDs of the firewall rule.
        /// </summary>
        public InputList<string> DstFirewallGroupIds
        {
            get => _dstFirewallGroupIds ?? (_dstFirewallGroupIds = new InputList<string>());
            set => _dstFirewallGroupIds = value;
        }

        /// <summary>
        /// The destination network ID of the firewall rule.
        /// </summary>
        [Input("dstNetworkId")]
        public Input<string>? DstNetworkId { get; set; }

        /// <summary>
        /// The destination network type of the firewall rule. Can be one of `ADDRv4` or `NETv4`. Defaults to `NETv4`.
        /// </summary>
        [Input("dstNetworkType")]
        public Input<string>? DstNetworkType { get; set; }

        /// <summary>
        /// The destination port of the firewall rule.
        /// </summary>
        [Input("dstPort")]
        public Input<string>? DstPort { get; set; }

        /// <summary>
        /// ICMP type name.
        /// </summary>
        [Input("icmpTypename")]
        public Input<string>? IcmpTypename { get; set; }

        /// <summary>
        /// Specify whether the rule matches on IPsec packets. Can be one of `match-ipset` or `match-none`.
        /// </summary>
        [Input("ipSec")]
        public Input<string>? IpSec { get; set; }

        /// <summary>
        /// Enable logging for the firewall rule.
        /// </summary>
        [Input("logging")]
        public Input<bool>? Logging { get; set; }

        /// <summary>
        /// The name of the firewall rule.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// The protocol of the rule.
        /// </summary>
        [Input("protocol")]
        public Input<string>? Protocol { get; set; }

        /// <summary>
        /// The index of the rule. Must be &gt;= 2000 &lt; 3000 or &gt;= 4000 &lt; 5000.
        /// </summary>
        [Input("ruleIndex")]
        public Input<int>? RuleIndex { get; set; }

        /// <summary>
        /// The ruleset for the rule. This is from the perspective of the security gateway. Must be one of `WAN_IN`, `WAN_OUT`, `WAN_LOCAL`, `LAN_IN`, `LAN_OUT`, `LAN_LOCAL`, `GUEST_IN`, `GUEST_OUT`, `GUEST_LOCAL`, `WANv6_IN`, `WANv6_OUT`, `WANv6_LOCAL`, `LANv6_IN`, `LANv6_OUT`, `LANv6_LOCAL`, `GUESTv6_IN`, `GUESTv6_OUT`, or `GUESTv6_LOCAL`.
        /// </summary>
        [Input("ruleset")]
        public Input<string>? Ruleset { get; set; }

        /// <summary>
        /// The name of the site to associate the firewall rule with.
        /// </summary>
        [Input("site")]
        public Input<string>? Site { get; set; }

        /// <summary>
        /// The source address for the firewall rule.
        /// </summary>
        [Input("srcAddress")]
        public Input<string>? SrcAddress { get; set; }

        [Input("srcFirewallGroupIds")]
        private InputList<string>? _srcFirewallGroupIds;

        /// <summary>
        /// The source firewall group IDs for the firewall rule.
        /// </summary>
        public InputList<string> SrcFirewallGroupIds
        {
            get => _srcFirewallGroupIds ?? (_srcFirewallGroupIds = new InputList<string>());
            set => _srcFirewallGroupIds = value;
        }

        /// <summary>
        /// The source MAC address of the firewall rule.
        /// </summary>
        [Input("srcMac")]
        public Input<string>? SrcMac { get; set; }

        /// <summary>
        /// The source network ID for the firewall rule.
        /// </summary>
        [Input("srcNetworkId")]
        public Input<string>? SrcNetworkId { get; set; }

        /// <summary>
        /// The source network type of the firewall rule. Can be one of `ADDRv4` or `NETv4`. Defaults to `NETv4`.
        /// </summary>
        [Input("srcNetworkType")]
        public Input<string>? SrcNetworkType { get; set; }

        /// <summary>
        /// Match where the state is established.
        /// </summary>
        [Input("stateEstablished")]
        public Input<bool>? StateEstablished { get; set; }

        /// <summary>
        /// Match where the state is invalid.
        /// </summary>
        [Input("stateInvalid")]
        public Input<bool>? StateInvalid { get; set; }

        /// <summary>
        /// Match where the state is new.
        /// </summary>
        [Input("stateNew")]
        public Input<bool>? StateNew { get; set; }

        /// <summary>
        /// Match where the state is related.
        /// </summary>
        [Input("stateRelated")]
        public Input<bool>? StateRelated { get; set; }

        public FirewallRuleState()
        {
        }
    }
}
