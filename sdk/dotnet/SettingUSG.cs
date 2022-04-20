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
    /// `unifi.SettingUSG` manages settings for a Unifi Security Gateway.
    /// </summary>
    [UnifiResourceType("unifi:index/settingUSG:SettingUSG")]
    public partial class SettingUSG : Pulumi.CustomResource
    {
        /// <summary>
        /// The DHCP relay servers.
        /// </summary>
        [Output("dhcpRelayServers")]
        public Output<ImmutableArray<string>> DhcpRelayServers { get; private set; } = null!;

        /// <summary>
        /// Whether the guest firewall log is enabled.
        /// </summary>
        [Output("firewallGuestDefaultLog")]
        public Output<bool> FirewallGuestDefaultLog { get; private set; } = null!;

        /// <summary>
        /// Whether the LAN firewall log is enabled.
        /// </summary>
        [Output("firewallLanDefaultLog")]
        public Output<bool> FirewallLanDefaultLog { get; private set; } = null!;

        /// <summary>
        /// Whether the WAN firewall log is enabled.
        /// </summary>
        [Output("firewallWanDefaultLog")]
        public Output<bool> FirewallWanDefaultLog { get; private set; } = null!;

        /// <summary>
        /// Whether multicast DNS is enabled.
        /// </summary>
        [Output("multicastDnsEnabled")]
        public Output<bool> MulticastDnsEnabled { get; private set; } = null!;

        /// <summary>
        /// The name of the site to associate the settings with.
        /// </summary>
        [Output("site")]
        public Output<string> Site { get; private set; } = null!;


        /// <summary>
        /// Create a SettingUSG resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public SettingUSG(string name, SettingUSGArgs? args = null, CustomResourceOptions? options = null)
            : base("unifi:index/settingUSG:SettingUSG", name, args ?? new SettingUSGArgs(), MakeResourceOptions(options, ""))
        {
        }

        private SettingUSG(string name, Input<string> id, SettingUSGState? state = null, CustomResourceOptions? options = null)
            : base("unifi:index/settingUSG:SettingUSG", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing SettingUSG resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static SettingUSG Get(string name, Input<string> id, SettingUSGState? state = null, CustomResourceOptions? options = null)
        {
            return new SettingUSG(name, id, state, options);
        }
    }

    public sealed class SettingUSGArgs : Pulumi.ResourceArgs
    {
        [Input("dhcpRelayServers")]
        private InputList<string>? _dhcpRelayServers;

        /// <summary>
        /// The DHCP relay servers.
        /// </summary>
        public InputList<string> DhcpRelayServers
        {
            get => _dhcpRelayServers ?? (_dhcpRelayServers = new InputList<string>());
            set => _dhcpRelayServers = value;
        }

        /// <summary>
        /// Whether the guest firewall log is enabled.
        /// </summary>
        [Input("firewallGuestDefaultLog")]
        public Input<bool>? FirewallGuestDefaultLog { get; set; }

        /// <summary>
        /// Whether the LAN firewall log is enabled.
        /// </summary>
        [Input("firewallLanDefaultLog")]
        public Input<bool>? FirewallLanDefaultLog { get; set; }

        /// <summary>
        /// Whether the WAN firewall log is enabled.
        /// </summary>
        [Input("firewallWanDefaultLog")]
        public Input<bool>? FirewallWanDefaultLog { get; set; }

        /// <summary>
        /// Whether multicast DNS is enabled.
        /// </summary>
        [Input("multicastDnsEnabled")]
        public Input<bool>? MulticastDnsEnabled { get; set; }

        /// <summary>
        /// The name of the site to associate the settings with.
        /// </summary>
        [Input("site")]
        public Input<string>? Site { get; set; }

        public SettingUSGArgs()
        {
        }
    }

    public sealed class SettingUSGState : Pulumi.ResourceArgs
    {
        [Input("dhcpRelayServers")]
        private InputList<string>? _dhcpRelayServers;

        /// <summary>
        /// The DHCP relay servers.
        /// </summary>
        public InputList<string> DhcpRelayServers
        {
            get => _dhcpRelayServers ?? (_dhcpRelayServers = new InputList<string>());
            set => _dhcpRelayServers = value;
        }

        /// <summary>
        /// Whether the guest firewall log is enabled.
        /// </summary>
        [Input("firewallGuestDefaultLog")]
        public Input<bool>? FirewallGuestDefaultLog { get; set; }

        /// <summary>
        /// Whether the LAN firewall log is enabled.
        /// </summary>
        [Input("firewallLanDefaultLog")]
        public Input<bool>? FirewallLanDefaultLog { get; set; }

        /// <summary>
        /// Whether the WAN firewall log is enabled.
        /// </summary>
        [Input("firewallWanDefaultLog")]
        public Input<bool>? FirewallWanDefaultLog { get; set; }

        /// <summary>
        /// Whether multicast DNS is enabled.
        /// </summary>
        [Input("multicastDnsEnabled")]
        public Input<bool>? MulticastDnsEnabled { get; set; }

        /// <summary>
        /// The name of the site to associate the settings with.
        /// </summary>
        [Input("site")]
        public Input<string>? Site { get; set; }

        public SettingUSGState()
        {
        }
    }
}
