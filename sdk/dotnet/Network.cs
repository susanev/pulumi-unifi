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
    /// `unifi.Network` manages WAN/LAN/VLAN networks.
    /// 
    /// ## Example Usage
    /// 
    /// ```csharp
    /// using System.Collections.Generic;
    /// using Pulumi;
    /// using Unifi = Pulumiverse.Unifi;
    /// 
    /// return await Deployment.RunAsync(() =&gt; 
    /// {
    ///     var config = new Config();
    ///     var vlanId = config.GetNumber("vlanId") ?? 10;
    ///     var vlan = new Unifi.Network("vlan", new()
    ///     {
    ///         Purpose = "corporate",
    ///         Subnet = "10.0.0.1/24",
    ///         VlanId = vlanId,
    ///         DhcpStart = "10.0.0.6",
    ///         DhcpStop = "10.0.0.254",
    ///         DhcpEnabled = true,
    ///     });
    /// 
    ///     var wan = new Unifi.Network("wan", new()
    ///     {
    ///         Purpose = "wan",
    ///         WanNetworkgroup = "WAN",
    ///         WanType = "pppoe",
    ///         WanIp = "192.168.1.1",
    ///         WanEgressQos = 1,
    ///         WanUsername = "username",
    ///         XWanPassword = "password",
    ///     });
    /// 
    /// });
    /// ```
    /// 
    /// ## Import
    /// 
    /// import from provider configured site
    /// 
    /// ```sh
    ///  $ pulumi import unifi:index/network:Network mynetwork 5dc28e5e9106d105bdc87217
    /// ```
    /// 
    ///  import from another site
    /// 
    /// ```sh
    ///  $ pulumi import unifi:index/network:Network mynetwork bfa2l6i7:5dc28e5e9106d105bdc87217
    /// ```
    /// 
    ///  import network by name
    /// 
    /// ```sh
    ///  $ pulumi import unifi:index/network:Network mynetwork name=LAN
    /// ```
    /// </summary>
    [UnifiResourceType("unifi:index/network:Network")]
    public partial class Network : global::Pulumi.CustomResource
    {
        /// <summary>
        /// Specifies the IPv4 addresses for the DNS server to be returned from the DHCP server. Leave blank to disable this feature.
        /// </summary>
        [Output("dhcpDns")]
        public Output<ImmutableArray<string>> DhcpDns { get; private set; } = null!;

        /// <summary>
        /// Specifies whether DHCP is enabled or not on this network.
        /// </summary>
        [Output("dhcpEnabled")]
        public Output<bool?> DhcpEnabled { get; private set; } = null!;

        /// <summary>
        /// Specifies the lease time for DHCP addresses. Defaults to `86400`.
        /// </summary>
        [Output("dhcpLease")]
        public Output<int?> DhcpLease { get; private set; } = null!;

        /// <summary>
        /// Specifies whether DHCP relay is enabled or not on this network.
        /// </summary>
        [Output("dhcpRelayEnabled")]
        public Output<bool?> DhcpRelayEnabled { get; private set; } = null!;

        /// <summary>
        /// The IPv4 address where the DHCP range of addresses starts.
        /// </summary>
        [Output("dhcpStart")]
        public Output<string?> DhcpStart { get; private set; } = null!;

        /// <summary>
        /// The IPv4 address where the DHCP range of addresses stops.
        /// </summary>
        [Output("dhcpStop")]
        public Output<string?> DhcpStop { get; private set; } = null!;

        /// <summary>
        /// Toggles on the DHCP boot options. Should be set to true when you want to have dhcpd*boot*filename, and dhcpd*boot*server to take effect.
        /// </summary>
        [Output("dhcpdBootEnabled")]
        public Output<bool?> DhcpdBootEnabled { get; private set; } = null!;

        /// <summary>
        /// Specifies the file to PXE boot from on the dhcpd*boot*server.
        /// </summary>
        [Output("dhcpdBootFilename")]
        public Output<string?> DhcpdBootFilename { get; private set; } = null!;

        /// <summary>
        /// Specifies the IPv4 address of a TFTP server to network boot from.
        /// </summary>
        [Output("dhcpdBootServer")]
        public Output<string?> DhcpdBootServer { get; private set; } = null!;

        /// <summary>
        /// The domain name of this network.
        /// </summary>
        [Output("domainName")]
        public Output<string?> DomainName { get; private set; } = null!;

        /// <summary>
        /// Specifies whether IGMP snooping is enabled or not.
        /// </summary>
        [Output("igmpSnooping")]
        public Output<bool?> IgmpSnooping { get; private set; } = null!;

        /// <summary>
        /// Specifies which type of IPv6 connection to use. Defaults to `none`.
        /// </summary>
        [Output("ipv6InterfaceType")]
        public Output<string?> Ipv6InterfaceType { get; private set; } = null!;

        /// <summary>
        /// Specifies which WAN interface to use for IPv6 PD.
        /// </summary>
        [Output("ipv6PdInterface")]
        public Output<string?> Ipv6PdInterface { get; private set; } = null!;

        /// <summary>
        /// Specifies the IPv6 Prefix ID.
        /// </summary>
        [Output("ipv6PdPrefixid")]
        public Output<string?> Ipv6PdPrefixid { get; private set; } = null!;

        /// <summary>
        /// Specifies whether to enable router advertisements or not.
        /// </summary>
        [Output("ipv6RaEnable")]
        public Output<bool?> Ipv6RaEnable { get; private set; } = null!;

        /// <summary>
        /// Specifies the static IPv6 subnet when ipv6*interface*type is 'static'.
        /// </summary>
        [Output("ipv6StaticSubnet")]
        public Output<string?> Ipv6StaticSubnet { get; private set; } = null!;

        /// <summary>
        /// The name of the network.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// The group of the network. Defaults to `LAN`.
        /// </summary>
        [Output("networkGroup")]
        public Output<string?> NetworkGroup { get; private set; } = null!;

        /// <summary>
        /// The purpose of the network. Must be one of `corporate`, `guest`, `wan`, or `vlan-only`.
        /// </summary>
        [Output("purpose")]
        public Output<string> Purpose { get; private set; } = null!;

        /// <summary>
        /// The name of the site to associate the network with.
        /// </summary>
        [Output("site")]
        public Output<string> Site { get; private set; } = null!;

        /// <summary>
        /// The subnet of the network. Must be a valid CIDR address.
        /// </summary>
        [Output("subnet")]
        public Output<string?> Subnet { get; private set; } = null!;

        /// <summary>
        /// The VLAN ID of the network.
        /// </summary>
        [Output("vlanId")]
        public Output<int?> VlanId { get; private set; } = null!;

        /// <summary>
        /// DNS servers IPs of the WAN.
        /// </summary>
        [Output("wanDns")]
        public Output<ImmutableArray<string>> WanDns { get; private set; } = null!;

        /// <summary>
        /// Specifies the WAN egress quality of service. Defaults to `0`.
        /// </summary>
        [Output("wanEgressQos")]
        public Output<int?> WanEgressQos { get; private set; } = null!;

        /// <summary>
        /// The IPv4 gateway of the WAN.
        /// </summary>
        [Output("wanGateway")]
        public Output<string?> WanGateway { get; private set; } = null!;

        /// <summary>
        /// The IPv4 address of the WAN.
        /// </summary>
        [Output("wanIp")]
        public Output<string?> WanIp { get; private set; } = null!;

        /// <summary>
        /// The IPv4 netmask of the WAN.
        /// </summary>
        [Output("wanNetmask")]
        public Output<string?> WanNetmask { get; private set; } = null!;

        /// <summary>
        /// Specifies the WAN network group. Must be one of either `WAN`, `WAN2` or `WAN_LTE_FAILOVER`.
        /// </summary>
        [Output("wanNetworkgroup")]
        public Output<string?> WanNetworkgroup { get; private set; } = null!;

        /// <summary>
        /// Specifies the IPV4 WAN connection type. Must be one of either `disabled`, `static`, `dhcp`, or `pppoe`.
        /// </summary>
        [Output("wanType")]
        public Output<string?> WanType { get; private set; } = null!;

        /// <summary>
        /// Specifies the IPV4 WAN username.
        /// </summary>
        [Output("wanUsername")]
        public Output<string?> WanUsername { get; private set; } = null!;

        /// <summary>
        /// Specifies the IPV4 WAN password.
        /// </summary>
        [Output("xWanPassword")]
        public Output<string?> XWanPassword { get; private set; } = null!;


        /// <summary>
        /// Create a Network resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Network(string name, NetworkArgs args, CustomResourceOptions? options = null)
            : base("unifi:index/network:Network", name, args ?? new NetworkArgs(), MakeResourceOptions(options, ""))
        {
        }

        private Network(string name, Input<string> id, NetworkState? state = null, CustomResourceOptions? options = null)
            : base("unifi:index/network:Network", name, state, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                PluginDownloadURL = "github://api.github.com/pulumiverse",
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing Network resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static Network Get(string name, Input<string> id, NetworkState? state = null, CustomResourceOptions? options = null)
        {
            return new Network(name, id, state, options);
        }
    }

    public sealed class NetworkArgs : global::Pulumi.ResourceArgs
    {
        [Input("dhcpDns")]
        private InputList<string>? _dhcpDns;

        /// <summary>
        /// Specifies the IPv4 addresses for the DNS server to be returned from the DHCP server. Leave blank to disable this feature.
        /// </summary>
        public InputList<string> DhcpDns
        {
            get => _dhcpDns ?? (_dhcpDns = new InputList<string>());
            set => _dhcpDns = value;
        }

        /// <summary>
        /// Specifies whether DHCP is enabled or not on this network.
        /// </summary>
        [Input("dhcpEnabled")]
        public Input<bool>? DhcpEnabled { get; set; }

        /// <summary>
        /// Specifies the lease time for DHCP addresses. Defaults to `86400`.
        /// </summary>
        [Input("dhcpLease")]
        public Input<int>? DhcpLease { get; set; }

        /// <summary>
        /// Specifies whether DHCP relay is enabled or not on this network.
        /// </summary>
        [Input("dhcpRelayEnabled")]
        public Input<bool>? DhcpRelayEnabled { get; set; }

        /// <summary>
        /// The IPv4 address where the DHCP range of addresses starts.
        /// </summary>
        [Input("dhcpStart")]
        public Input<string>? DhcpStart { get; set; }

        /// <summary>
        /// The IPv4 address where the DHCP range of addresses stops.
        /// </summary>
        [Input("dhcpStop")]
        public Input<string>? DhcpStop { get; set; }

        /// <summary>
        /// Toggles on the DHCP boot options. Should be set to true when you want to have dhcpd*boot*filename, and dhcpd*boot*server to take effect.
        /// </summary>
        [Input("dhcpdBootEnabled")]
        public Input<bool>? DhcpdBootEnabled { get; set; }

        /// <summary>
        /// Specifies the file to PXE boot from on the dhcpd*boot*server.
        /// </summary>
        [Input("dhcpdBootFilename")]
        public Input<string>? DhcpdBootFilename { get; set; }

        /// <summary>
        /// Specifies the IPv4 address of a TFTP server to network boot from.
        /// </summary>
        [Input("dhcpdBootServer")]
        public Input<string>? DhcpdBootServer { get; set; }

        /// <summary>
        /// The domain name of this network.
        /// </summary>
        [Input("domainName")]
        public Input<string>? DomainName { get; set; }

        /// <summary>
        /// Specifies whether IGMP snooping is enabled or not.
        /// </summary>
        [Input("igmpSnooping")]
        public Input<bool>? IgmpSnooping { get; set; }

        /// <summary>
        /// Specifies which type of IPv6 connection to use. Defaults to `none`.
        /// </summary>
        [Input("ipv6InterfaceType")]
        public Input<string>? Ipv6InterfaceType { get; set; }

        /// <summary>
        /// Specifies which WAN interface to use for IPv6 PD.
        /// </summary>
        [Input("ipv6PdInterface")]
        public Input<string>? Ipv6PdInterface { get; set; }

        /// <summary>
        /// Specifies the IPv6 Prefix ID.
        /// </summary>
        [Input("ipv6PdPrefixid")]
        public Input<string>? Ipv6PdPrefixid { get; set; }

        /// <summary>
        /// Specifies whether to enable router advertisements or not.
        /// </summary>
        [Input("ipv6RaEnable")]
        public Input<bool>? Ipv6RaEnable { get; set; }

        /// <summary>
        /// Specifies the static IPv6 subnet when ipv6*interface*type is 'static'.
        /// </summary>
        [Input("ipv6StaticSubnet")]
        public Input<string>? Ipv6StaticSubnet { get; set; }

        /// <summary>
        /// The name of the network.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// The group of the network. Defaults to `LAN`.
        /// </summary>
        [Input("networkGroup")]
        public Input<string>? NetworkGroup { get; set; }

        /// <summary>
        /// The purpose of the network. Must be one of `corporate`, `guest`, `wan`, or `vlan-only`.
        /// </summary>
        [Input("purpose", required: true)]
        public Input<string> Purpose { get; set; } = null!;

        /// <summary>
        /// The name of the site to associate the network with.
        /// </summary>
        [Input("site")]
        public Input<string>? Site { get; set; }

        /// <summary>
        /// The subnet of the network. Must be a valid CIDR address.
        /// </summary>
        [Input("subnet")]
        public Input<string>? Subnet { get; set; }

        /// <summary>
        /// The VLAN ID of the network.
        /// </summary>
        [Input("vlanId")]
        public Input<int>? VlanId { get; set; }

        [Input("wanDns")]
        private InputList<string>? _wanDns;

        /// <summary>
        /// DNS servers IPs of the WAN.
        /// </summary>
        public InputList<string> WanDns
        {
            get => _wanDns ?? (_wanDns = new InputList<string>());
            set => _wanDns = value;
        }

        /// <summary>
        /// Specifies the WAN egress quality of service. Defaults to `0`.
        /// </summary>
        [Input("wanEgressQos")]
        public Input<int>? WanEgressQos { get; set; }

        /// <summary>
        /// The IPv4 gateway of the WAN.
        /// </summary>
        [Input("wanGateway")]
        public Input<string>? WanGateway { get; set; }

        /// <summary>
        /// The IPv4 address of the WAN.
        /// </summary>
        [Input("wanIp")]
        public Input<string>? WanIp { get; set; }

        /// <summary>
        /// The IPv4 netmask of the WAN.
        /// </summary>
        [Input("wanNetmask")]
        public Input<string>? WanNetmask { get; set; }

        /// <summary>
        /// Specifies the WAN network group. Must be one of either `WAN`, `WAN2` or `WAN_LTE_FAILOVER`.
        /// </summary>
        [Input("wanNetworkgroup")]
        public Input<string>? WanNetworkgroup { get; set; }

        /// <summary>
        /// Specifies the IPV4 WAN connection type. Must be one of either `disabled`, `static`, `dhcp`, or `pppoe`.
        /// </summary>
        [Input("wanType")]
        public Input<string>? WanType { get; set; }

        /// <summary>
        /// Specifies the IPV4 WAN username.
        /// </summary>
        [Input("wanUsername")]
        public Input<string>? WanUsername { get; set; }

        /// <summary>
        /// Specifies the IPV4 WAN password.
        /// </summary>
        [Input("xWanPassword")]
        public Input<string>? XWanPassword { get; set; }

        public NetworkArgs()
        {
        }
        public static new NetworkArgs Empty => new NetworkArgs();
    }

    public sealed class NetworkState : global::Pulumi.ResourceArgs
    {
        [Input("dhcpDns")]
        private InputList<string>? _dhcpDns;

        /// <summary>
        /// Specifies the IPv4 addresses for the DNS server to be returned from the DHCP server. Leave blank to disable this feature.
        /// </summary>
        public InputList<string> DhcpDns
        {
            get => _dhcpDns ?? (_dhcpDns = new InputList<string>());
            set => _dhcpDns = value;
        }

        /// <summary>
        /// Specifies whether DHCP is enabled or not on this network.
        /// </summary>
        [Input("dhcpEnabled")]
        public Input<bool>? DhcpEnabled { get; set; }

        /// <summary>
        /// Specifies the lease time for DHCP addresses. Defaults to `86400`.
        /// </summary>
        [Input("dhcpLease")]
        public Input<int>? DhcpLease { get; set; }

        /// <summary>
        /// Specifies whether DHCP relay is enabled or not on this network.
        /// </summary>
        [Input("dhcpRelayEnabled")]
        public Input<bool>? DhcpRelayEnabled { get; set; }

        /// <summary>
        /// The IPv4 address where the DHCP range of addresses starts.
        /// </summary>
        [Input("dhcpStart")]
        public Input<string>? DhcpStart { get; set; }

        /// <summary>
        /// The IPv4 address where the DHCP range of addresses stops.
        /// </summary>
        [Input("dhcpStop")]
        public Input<string>? DhcpStop { get; set; }

        /// <summary>
        /// Toggles on the DHCP boot options. Should be set to true when you want to have dhcpd*boot*filename, and dhcpd*boot*server to take effect.
        /// </summary>
        [Input("dhcpdBootEnabled")]
        public Input<bool>? DhcpdBootEnabled { get; set; }

        /// <summary>
        /// Specifies the file to PXE boot from on the dhcpd*boot*server.
        /// </summary>
        [Input("dhcpdBootFilename")]
        public Input<string>? DhcpdBootFilename { get; set; }

        /// <summary>
        /// Specifies the IPv4 address of a TFTP server to network boot from.
        /// </summary>
        [Input("dhcpdBootServer")]
        public Input<string>? DhcpdBootServer { get; set; }

        /// <summary>
        /// The domain name of this network.
        /// </summary>
        [Input("domainName")]
        public Input<string>? DomainName { get; set; }

        /// <summary>
        /// Specifies whether IGMP snooping is enabled or not.
        /// </summary>
        [Input("igmpSnooping")]
        public Input<bool>? IgmpSnooping { get; set; }

        /// <summary>
        /// Specifies which type of IPv6 connection to use. Defaults to `none`.
        /// </summary>
        [Input("ipv6InterfaceType")]
        public Input<string>? Ipv6InterfaceType { get; set; }

        /// <summary>
        /// Specifies which WAN interface to use for IPv6 PD.
        /// </summary>
        [Input("ipv6PdInterface")]
        public Input<string>? Ipv6PdInterface { get; set; }

        /// <summary>
        /// Specifies the IPv6 Prefix ID.
        /// </summary>
        [Input("ipv6PdPrefixid")]
        public Input<string>? Ipv6PdPrefixid { get; set; }

        /// <summary>
        /// Specifies whether to enable router advertisements or not.
        /// </summary>
        [Input("ipv6RaEnable")]
        public Input<bool>? Ipv6RaEnable { get; set; }

        /// <summary>
        /// Specifies the static IPv6 subnet when ipv6*interface*type is 'static'.
        /// </summary>
        [Input("ipv6StaticSubnet")]
        public Input<string>? Ipv6StaticSubnet { get; set; }

        /// <summary>
        /// The name of the network.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// The group of the network. Defaults to `LAN`.
        /// </summary>
        [Input("networkGroup")]
        public Input<string>? NetworkGroup { get; set; }

        /// <summary>
        /// The purpose of the network. Must be one of `corporate`, `guest`, `wan`, or `vlan-only`.
        /// </summary>
        [Input("purpose")]
        public Input<string>? Purpose { get; set; }

        /// <summary>
        /// The name of the site to associate the network with.
        /// </summary>
        [Input("site")]
        public Input<string>? Site { get; set; }

        /// <summary>
        /// The subnet of the network. Must be a valid CIDR address.
        /// </summary>
        [Input("subnet")]
        public Input<string>? Subnet { get; set; }

        /// <summary>
        /// The VLAN ID of the network.
        /// </summary>
        [Input("vlanId")]
        public Input<int>? VlanId { get; set; }

        [Input("wanDns")]
        private InputList<string>? _wanDns;

        /// <summary>
        /// DNS servers IPs of the WAN.
        /// </summary>
        public InputList<string> WanDns
        {
            get => _wanDns ?? (_wanDns = new InputList<string>());
            set => _wanDns = value;
        }

        /// <summary>
        /// Specifies the WAN egress quality of service. Defaults to `0`.
        /// </summary>
        [Input("wanEgressQos")]
        public Input<int>? WanEgressQos { get; set; }

        /// <summary>
        /// The IPv4 gateway of the WAN.
        /// </summary>
        [Input("wanGateway")]
        public Input<string>? WanGateway { get; set; }

        /// <summary>
        /// The IPv4 address of the WAN.
        /// </summary>
        [Input("wanIp")]
        public Input<string>? WanIp { get; set; }

        /// <summary>
        /// The IPv4 netmask of the WAN.
        /// </summary>
        [Input("wanNetmask")]
        public Input<string>? WanNetmask { get; set; }

        /// <summary>
        /// Specifies the WAN network group. Must be one of either `WAN`, `WAN2` or `WAN_LTE_FAILOVER`.
        /// </summary>
        [Input("wanNetworkgroup")]
        public Input<string>? WanNetworkgroup { get; set; }

        /// <summary>
        /// Specifies the IPV4 WAN connection type. Must be one of either `disabled`, `static`, `dhcp`, or `pppoe`.
        /// </summary>
        [Input("wanType")]
        public Input<string>? WanType { get; set; }

        /// <summary>
        /// Specifies the IPV4 WAN username.
        /// </summary>
        [Input("wanUsername")]
        public Input<string>? WanUsername { get; set; }

        /// <summary>
        /// Specifies the IPV4 WAN password.
        /// </summary>
        [Input("xWanPassword")]
        public Input<string>? XWanPassword { get; set; }

        public NetworkState()
        {
        }
        public static new NetworkState Empty => new NetworkState();
    }
}
