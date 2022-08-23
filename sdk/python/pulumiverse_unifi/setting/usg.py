# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import copy
import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from .. import _utilities

__all__ = ['USGArgs', 'USG']

@pulumi.input_type
class USGArgs:
    def __init__(__self__, *,
                 dhcp_relay_servers: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 firewall_guest_default_log: Optional[pulumi.Input[bool]] = None,
                 firewall_lan_default_log: Optional[pulumi.Input[bool]] = None,
                 firewall_wan_default_log: Optional[pulumi.Input[bool]] = None,
                 multicast_dns_enabled: Optional[pulumi.Input[bool]] = None,
                 site: Optional[pulumi.Input[str]] = None):
        """
        The set of arguments for constructing a USG resource.
        :param pulumi.Input[Sequence[pulumi.Input[str]]] dhcp_relay_servers: The DHCP relay servers.
        :param pulumi.Input[bool] firewall_guest_default_log: Whether the guest firewall log is enabled.
        :param pulumi.Input[bool] firewall_lan_default_log: Whether the LAN firewall log is enabled.
        :param pulumi.Input[bool] firewall_wan_default_log: Whether the WAN firewall log is enabled.
        :param pulumi.Input[bool] multicast_dns_enabled: Whether multicast DNS is enabled.
        :param pulumi.Input[str] site: The name of the site to associate the settings with.
        """
        if dhcp_relay_servers is not None:
            pulumi.set(__self__, "dhcp_relay_servers", dhcp_relay_servers)
        if firewall_guest_default_log is not None:
            pulumi.set(__self__, "firewall_guest_default_log", firewall_guest_default_log)
        if firewall_lan_default_log is not None:
            pulumi.set(__self__, "firewall_lan_default_log", firewall_lan_default_log)
        if firewall_wan_default_log is not None:
            pulumi.set(__self__, "firewall_wan_default_log", firewall_wan_default_log)
        if multicast_dns_enabled is not None:
            pulumi.set(__self__, "multicast_dns_enabled", multicast_dns_enabled)
        if site is not None:
            pulumi.set(__self__, "site", site)

    @property
    @pulumi.getter(name="dhcpRelayServers")
    def dhcp_relay_servers(self) -> Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]:
        """
        The DHCP relay servers.
        """
        return pulumi.get(self, "dhcp_relay_servers")

    @dhcp_relay_servers.setter
    def dhcp_relay_servers(self, value: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]):
        pulumi.set(self, "dhcp_relay_servers", value)

    @property
    @pulumi.getter(name="firewallGuestDefaultLog")
    def firewall_guest_default_log(self) -> Optional[pulumi.Input[bool]]:
        """
        Whether the guest firewall log is enabled.
        """
        return pulumi.get(self, "firewall_guest_default_log")

    @firewall_guest_default_log.setter
    def firewall_guest_default_log(self, value: Optional[pulumi.Input[bool]]):
        pulumi.set(self, "firewall_guest_default_log", value)

    @property
    @pulumi.getter(name="firewallLanDefaultLog")
    def firewall_lan_default_log(self) -> Optional[pulumi.Input[bool]]:
        """
        Whether the LAN firewall log is enabled.
        """
        return pulumi.get(self, "firewall_lan_default_log")

    @firewall_lan_default_log.setter
    def firewall_lan_default_log(self, value: Optional[pulumi.Input[bool]]):
        pulumi.set(self, "firewall_lan_default_log", value)

    @property
    @pulumi.getter(name="firewallWanDefaultLog")
    def firewall_wan_default_log(self) -> Optional[pulumi.Input[bool]]:
        """
        Whether the WAN firewall log is enabled.
        """
        return pulumi.get(self, "firewall_wan_default_log")

    @firewall_wan_default_log.setter
    def firewall_wan_default_log(self, value: Optional[pulumi.Input[bool]]):
        pulumi.set(self, "firewall_wan_default_log", value)

    @property
    @pulumi.getter(name="multicastDnsEnabled")
    def multicast_dns_enabled(self) -> Optional[pulumi.Input[bool]]:
        """
        Whether multicast DNS is enabled.
        """
        return pulumi.get(self, "multicast_dns_enabled")

    @multicast_dns_enabled.setter
    def multicast_dns_enabled(self, value: Optional[pulumi.Input[bool]]):
        pulumi.set(self, "multicast_dns_enabled", value)

    @property
    @pulumi.getter
    def site(self) -> Optional[pulumi.Input[str]]:
        """
        The name of the site to associate the settings with.
        """
        return pulumi.get(self, "site")

    @site.setter
    def site(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "site", value)


@pulumi.input_type
class _USGState:
    def __init__(__self__, *,
                 dhcp_relay_servers: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 firewall_guest_default_log: Optional[pulumi.Input[bool]] = None,
                 firewall_lan_default_log: Optional[pulumi.Input[bool]] = None,
                 firewall_wan_default_log: Optional[pulumi.Input[bool]] = None,
                 multicast_dns_enabled: Optional[pulumi.Input[bool]] = None,
                 site: Optional[pulumi.Input[str]] = None):
        """
        Input properties used for looking up and filtering USG resources.
        :param pulumi.Input[Sequence[pulumi.Input[str]]] dhcp_relay_servers: The DHCP relay servers.
        :param pulumi.Input[bool] firewall_guest_default_log: Whether the guest firewall log is enabled.
        :param pulumi.Input[bool] firewall_lan_default_log: Whether the LAN firewall log is enabled.
        :param pulumi.Input[bool] firewall_wan_default_log: Whether the WAN firewall log is enabled.
        :param pulumi.Input[bool] multicast_dns_enabled: Whether multicast DNS is enabled.
        :param pulumi.Input[str] site: The name of the site to associate the settings with.
        """
        if dhcp_relay_servers is not None:
            pulumi.set(__self__, "dhcp_relay_servers", dhcp_relay_servers)
        if firewall_guest_default_log is not None:
            pulumi.set(__self__, "firewall_guest_default_log", firewall_guest_default_log)
        if firewall_lan_default_log is not None:
            pulumi.set(__self__, "firewall_lan_default_log", firewall_lan_default_log)
        if firewall_wan_default_log is not None:
            pulumi.set(__self__, "firewall_wan_default_log", firewall_wan_default_log)
        if multicast_dns_enabled is not None:
            pulumi.set(__self__, "multicast_dns_enabled", multicast_dns_enabled)
        if site is not None:
            pulumi.set(__self__, "site", site)

    @property
    @pulumi.getter(name="dhcpRelayServers")
    def dhcp_relay_servers(self) -> Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]:
        """
        The DHCP relay servers.
        """
        return pulumi.get(self, "dhcp_relay_servers")

    @dhcp_relay_servers.setter
    def dhcp_relay_servers(self, value: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]):
        pulumi.set(self, "dhcp_relay_servers", value)

    @property
    @pulumi.getter(name="firewallGuestDefaultLog")
    def firewall_guest_default_log(self) -> Optional[pulumi.Input[bool]]:
        """
        Whether the guest firewall log is enabled.
        """
        return pulumi.get(self, "firewall_guest_default_log")

    @firewall_guest_default_log.setter
    def firewall_guest_default_log(self, value: Optional[pulumi.Input[bool]]):
        pulumi.set(self, "firewall_guest_default_log", value)

    @property
    @pulumi.getter(name="firewallLanDefaultLog")
    def firewall_lan_default_log(self) -> Optional[pulumi.Input[bool]]:
        """
        Whether the LAN firewall log is enabled.
        """
        return pulumi.get(self, "firewall_lan_default_log")

    @firewall_lan_default_log.setter
    def firewall_lan_default_log(self, value: Optional[pulumi.Input[bool]]):
        pulumi.set(self, "firewall_lan_default_log", value)

    @property
    @pulumi.getter(name="firewallWanDefaultLog")
    def firewall_wan_default_log(self) -> Optional[pulumi.Input[bool]]:
        """
        Whether the WAN firewall log is enabled.
        """
        return pulumi.get(self, "firewall_wan_default_log")

    @firewall_wan_default_log.setter
    def firewall_wan_default_log(self, value: Optional[pulumi.Input[bool]]):
        pulumi.set(self, "firewall_wan_default_log", value)

    @property
    @pulumi.getter(name="multicastDnsEnabled")
    def multicast_dns_enabled(self) -> Optional[pulumi.Input[bool]]:
        """
        Whether multicast DNS is enabled.
        """
        return pulumi.get(self, "multicast_dns_enabled")

    @multicast_dns_enabled.setter
    def multicast_dns_enabled(self, value: Optional[pulumi.Input[bool]]):
        pulumi.set(self, "multicast_dns_enabled", value)

    @property
    @pulumi.getter
    def site(self) -> Optional[pulumi.Input[str]]:
        """
        The name of the site to associate the settings with.
        """
        return pulumi.get(self, "site")

    @site.setter
    def site(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "site", value)


class USG(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 dhcp_relay_servers: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 firewall_guest_default_log: Optional[pulumi.Input[bool]] = None,
                 firewall_lan_default_log: Optional[pulumi.Input[bool]] = None,
                 firewall_wan_default_log: Optional[pulumi.Input[bool]] = None,
                 multicast_dns_enabled: Optional[pulumi.Input[bool]] = None,
                 site: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        """
        `setting.USG` manages settings for a Unifi Security Gateway.

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[Sequence[pulumi.Input[str]]] dhcp_relay_servers: The DHCP relay servers.
        :param pulumi.Input[bool] firewall_guest_default_log: Whether the guest firewall log is enabled.
        :param pulumi.Input[bool] firewall_lan_default_log: Whether the LAN firewall log is enabled.
        :param pulumi.Input[bool] firewall_wan_default_log: Whether the WAN firewall log is enabled.
        :param pulumi.Input[bool] multicast_dns_enabled: Whether multicast DNS is enabled.
        :param pulumi.Input[str] site: The name of the site to associate the settings with.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: Optional[USGArgs] = None,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        `setting.USG` manages settings for a Unifi Security Gateway.

        :param str resource_name: The name of the resource.
        :param USGArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(USGArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 dhcp_relay_servers: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 firewall_guest_default_log: Optional[pulumi.Input[bool]] = None,
                 firewall_lan_default_log: Optional[pulumi.Input[bool]] = None,
                 firewall_wan_default_log: Optional[pulumi.Input[bool]] = None,
                 multicast_dns_enabled: Optional[pulumi.Input[bool]] = None,
                 site: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        opts = pulumi.ResourceOptions.merge(_utilities.get_resource_opts_defaults(), opts)
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = USGArgs.__new__(USGArgs)

            __props__.__dict__["dhcp_relay_servers"] = dhcp_relay_servers
            __props__.__dict__["firewall_guest_default_log"] = firewall_guest_default_log
            __props__.__dict__["firewall_lan_default_log"] = firewall_lan_default_log
            __props__.__dict__["firewall_wan_default_log"] = firewall_wan_default_log
            __props__.__dict__["multicast_dns_enabled"] = multicast_dns_enabled
            __props__.__dict__["site"] = site
        super(USG, __self__).__init__(
            'unifi:setting/uSG:USG',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            dhcp_relay_servers: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
            firewall_guest_default_log: Optional[pulumi.Input[bool]] = None,
            firewall_lan_default_log: Optional[pulumi.Input[bool]] = None,
            firewall_wan_default_log: Optional[pulumi.Input[bool]] = None,
            multicast_dns_enabled: Optional[pulumi.Input[bool]] = None,
            site: Optional[pulumi.Input[str]] = None) -> 'USG':
        """
        Get an existing USG resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[Sequence[pulumi.Input[str]]] dhcp_relay_servers: The DHCP relay servers.
        :param pulumi.Input[bool] firewall_guest_default_log: Whether the guest firewall log is enabled.
        :param pulumi.Input[bool] firewall_lan_default_log: Whether the LAN firewall log is enabled.
        :param pulumi.Input[bool] firewall_wan_default_log: Whether the WAN firewall log is enabled.
        :param pulumi.Input[bool] multicast_dns_enabled: Whether multicast DNS is enabled.
        :param pulumi.Input[str] site: The name of the site to associate the settings with.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = _USGState.__new__(_USGState)

        __props__.__dict__["dhcp_relay_servers"] = dhcp_relay_servers
        __props__.__dict__["firewall_guest_default_log"] = firewall_guest_default_log
        __props__.__dict__["firewall_lan_default_log"] = firewall_lan_default_log
        __props__.__dict__["firewall_wan_default_log"] = firewall_wan_default_log
        __props__.__dict__["multicast_dns_enabled"] = multicast_dns_enabled
        __props__.__dict__["site"] = site
        return USG(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="dhcpRelayServers")
    def dhcp_relay_servers(self) -> pulumi.Output[Sequence[str]]:
        """
        The DHCP relay servers.
        """
        return pulumi.get(self, "dhcp_relay_servers")

    @property
    @pulumi.getter(name="firewallGuestDefaultLog")
    def firewall_guest_default_log(self) -> pulumi.Output[bool]:
        """
        Whether the guest firewall log is enabled.
        """
        return pulumi.get(self, "firewall_guest_default_log")

    @property
    @pulumi.getter(name="firewallLanDefaultLog")
    def firewall_lan_default_log(self) -> pulumi.Output[bool]:
        """
        Whether the LAN firewall log is enabled.
        """
        return pulumi.get(self, "firewall_lan_default_log")

    @property
    @pulumi.getter(name="firewallWanDefaultLog")
    def firewall_wan_default_log(self) -> pulumi.Output[bool]:
        """
        Whether the WAN firewall log is enabled.
        """
        return pulumi.get(self, "firewall_wan_default_log")

    @property
    @pulumi.getter(name="multicastDnsEnabled")
    def multicast_dns_enabled(self) -> pulumi.Output[bool]:
        """
        Whether multicast DNS is enabled.
        """
        return pulumi.get(self, "multicast_dns_enabled")

    @property
    @pulumi.getter
    def site(self) -> pulumi.Output[str]:
        """
        The name of the site to associate the settings with.
        """
        return pulumi.get(self, "site")

