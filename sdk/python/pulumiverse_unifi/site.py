# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from . import _utilities

__all__ = ['SiteArgs', 'Site']

@pulumi.input_type
class SiteArgs:
    def __init__(__self__, *,
                 description: pulumi.Input[str]):
        """
        The set of arguments for constructing a Site resource.
        :param pulumi.Input[str] description: The description of the site.
        """
        pulumi.set(__self__, "description", description)

    @property
    @pulumi.getter
    def description(self) -> pulumi.Input[str]:
        """
        The description of the site.
        """
        return pulumi.get(self, "description")

    @description.setter
    def description(self, value: pulumi.Input[str]):
        pulumi.set(self, "description", value)


@pulumi.input_type
class _SiteState:
    def __init__(__self__, *,
                 description: Optional[pulumi.Input[str]] = None,
                 name: Optional[pulumi.Input[str]] = None):
        """
        Input properties used for looking up and filtering Site resources.
        :param pulumi.Input[str] description: The description of the site.
        :param pulumi.Input[str] name: The name of the site.
        """
        if description is not None:
            pulumi.set(__self__, "description", description)
        if name is not None:
            pulumi.set(__self__, "name", name)

    @property
    @pulumi.getter
    def description(self) -> Optional[pulumi.Input[str]]:
        """
        The description of the site.
        """
        return pulumi.get(self, "description")

    @description.setter
    def description(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "description", value)

    @property
    @pulumi.getter
    def name(self) -> Optional[pulumi.Input[str]]:
        """
        The name of the site.
        """
        return pulumi.get(self, "name")

    @name.setter
    def name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "name", value)


class Site(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        """
        `Site` manages Unifi sites

        ## Example Usage

        ```python
        import pulumi
        import pulumiverse_unifi as unifi

        mysite = unifi.Site("mysite", description="mysite")
        ```

        ## Import

        # import using the API/UI ID

        ```sh
         $ pulumi import unifi:index/site:Site mysite 5fe6261995fe130013456a36
        ```

        # import using the name (short ID)

        ```sh
         $ pulumi import unifi:index/site:Site mysite vq98kwez
        ```

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] description: The description of the site.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: SiteArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        `Site` manages Unifi sites

        ## Example Usage

        ```python
        import pulumi
        import pulumiverse_unifi as unifi

        mysite = unifi.Site("mysite", description="mysite")
        ```

        ## Import

        # import using the API/UI ID

        ```sh
         $ pulumi import unifi:index/site:Site mysite 5fe6261995fe130013456a36
        ```

        # import using the name (short ID)

        ```sh
         $ pulumi import unifi:index/site:Site mysite vq98kwez
        ```

        :param str resource_name: The name of the resource.
        :param SiteArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(SiteArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        if opts is None:
            opts = pulumi.ResourceOptions()
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.version is None:
            opts.version = _utilities.get_version()
        if opts.plugin_download_url is None:
            opts.plugin_download_url = _utilities.get_plugin_download_url()
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = SiteArgs.__new__(SiteArgs)

            if description is None and not opts.urn:
                raise TypeError("Missing required property 'description'")
            __props__.__dict__["description"] = description
            __props__.__dict__["name"] = None
        super(Site, __self__).__init__(
            'unifi:index/site:Site',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            description: Optional[pulumi.Input[str]] = None,
            name: Optional[pulumi.Input[str]] = None) -> 'Site':
        """
        Get an existing Site resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] description: The description of the site.
        :param pulumi.Input[str] name: The name of the site.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = _SiteState.__new__(_SiteState)

        __props__.__dict__["description"] = description
        __props__.__dict__["name"] = name
        return Site(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter
    def description(self) -> pulumi.Output[str]:
        """
        The description of the site.
        """
        return pulumi.get(self, "description")

    @property
    @pulumi.getter
    def name(self) -> pulumi.Output[str]:
        """
        The name of the site.
        """
        return pulumi.get(self, "name")

