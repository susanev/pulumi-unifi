# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import copy
import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from . import _utilities

__all__ = [
    'GetAccountResult',
    'AwaitableGetAccountResult',
    'get_account',
    'get_account_output',
]

@pulumi.output_type
class GetAccountResult:
    """
    A collection of values returned by getAccount.
    """
    def __init__(__self__, id=None, name=None, network_id=None, password=None, site=None, tunnel_medium_type=None, tunnel_type=None):
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        pulumi.set(__self__, "id", id)
        if name and not isinstance(name, str):
            raise TypeError("Expected argument 'name' to be a str")
        pulumi.set(__self__, "name", name)
        if network_id and not isinstance(network_id, str):
            raise TypeError("Expected argument 'network_id' to be a str")
        pulumi.set(__self__, "network_id", network_id)
        if password and not isinstance(password, str):
            raise TypeError("Expected argument 'password' to be a str")
        pulumi.set(__self__, "password", password)
        if site and not isinstance(site, str):
            raise TypeError("Expected argument 'site' to be a str")
        pulumi.set(__self__, "site", site)
        if tunnel_medium_type and not isinstance(tunnel_medium_type, int):
            raise TypeError("Expected argument 'tunnel_medium_type' to be a int")
        pulumi.set(__self__, "tunnel_medium_type", tunnel_medium_type)
        if tunnel_type and not isinstance(tunnel_type, int):
            raise TypeError("Expected argument 'tunnel_type' to be a int")
        pulumi.set(__self__, "tunnel_type", tunnel_type)

    @property
    @pulumi.getter
    def id(self) -> str:
        """
        The ID of this account.
        """
        return pulumi.get(self, "id")

    @property
    @pulumi.getter
    def name(self) -> str:
        """
        The name of the account to look up
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter(name="networkId")
    def network_id(self) -> str:
        """
        ID of the network for this account
        """
        return pulumi.get(self, "network_id")

    @property
    @pulumi.getter
    def password(self) -> str:
        """
        The password of the account.
        """
        return pulumi.get(self, "password")

    @property
    @pulumi.getter
    def site(self) -> str:
        """
        The name of the site the account is associated with.
        """
        return pulumi.get(self, "site")

    @property
    @pulumi.getter(name="tunnelMediumType")
    def tunnel_medium_type(self) -> int:
        """
        See RFC2868 section 3.2
        """
        return pulumi.get(self, "tunnel_medium_type")

    @property
    @pulumi.getter(name="tunnelType")
    def tunnel_type(self) -> int:
        """
        See RFC2868 section 3.1
        """
        return pulumi.get(self, "tunnel_type")


class AwaitableGetAccountResult(GetAccountResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetAccountResult(
            id=self.id,
            name=self.name,
            network_id=self.network_id,
            password=self.password,
            site=self.site,
            tunnel_medium_type=self.tunnel_medium_type,
            tunnel_type=self.tunnel_type)


def get_account(name: Optional[str] = None,
                site: Optional[str] = None,
                opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetAccountResult:
    """
    `Account` data source can be used to retrieve RADIUS user accounts


    :param str name: The name of the account to look up
    :param str site: The name of the site the account is associated with.
    """
    __args__ = dict()
    __args__['name'] = name
    __args__['site'] = site
    opts = pulumi.InvokeOptions.merge(_utilities.get_invoke_opts_defaults(), opts)
    __ret__ = pulumi.runtime.invoke('unifi:index/getAccount:getAccount', __args__, opts=opts, typ=GetAccountResult).value

    return AwaitableGetAccountResult(
        id=__ret__.id,
        name=__ret__.name,
        network_id=__ret__.network_id,
        password=__ret__.password,
        site=__ret__.site,
        tunnel_medium_type=__ret__.tunnel_medium_type,
        tunnel_type=__ret__.tunnel_type)


@_utilities.lift_output_func(get_account)
def get_account_output(name: Optional[pulumi.Input[str]] = None,
                       site: Optional[pulumi.Input[Optional[str]]] = None,
                       opts: Optional[pulumi.InvokeOptions] = None) -> pulumi.Output[GetAccountResult]:
    """
    `Account` data source can be used to retrieve RADIUS user accounts


    :param str name: The name of the account to look up
    :param str site: The name of the site the account is associated with.
    """
    ...