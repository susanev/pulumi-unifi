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
    public static class GetUserGroup
    {
        /// <summary>
        /// `unifi.UserGroup` data source can be used to retrieve the ID for a user group by name.
        /// </summary>
        public static Task<GetUserGroupResult> InvokeAsync(GetUserGroupArgs? args = null, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetUserGroupResult>("unifi:index/getUserGroup:getUserGroup", args ?? new GetUserGroupArgs(), options.WithDefaults());

        /// <summary>
        /// `unifi.UserGroup` data source can be used to retrieve the ID for a user group by name.
        /// </summary>
        public static Output<GetUserGroupResult> Invoke(GetUserGroupInvokeArgs? args = null, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<GetUserGroupResult>("unifi:index/getUserGroup:getUserGroup", args ?? new GetUserGroupInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetUserGroupArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The name of the user group to look up. Defaults to `Default`.
        /// </summary>
        [Input("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The name of the site the user group is associated with.
        /// </summary>
        [Input("site")]
        public string? Site { get; set; }

        public GetUserGroupArgs()
        {
        }
    }

    public sealed class GetUserGroupInvokeArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The name of the user group to look up. Defaults to `Default`.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// The name of the site the user group is associated with.
        /// </summary>
        [Input("site")]
        public Input<string>? Site { get; set; }

        public GetUserGroupInvokeArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetUserGroupResult
    {
        /// <summary>
        /// The ID of this AP group.
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// The name of the user group to look up. Defaults to `Default`.
        /// </summary>
        public readonly string? Name;
        public readonly int QosRateMaxDown;
        public readonly int QosRateMaxUp;
        /// <summary>
        /// The name of the site the user group is associated with.
        /// </summary>
        public readonly string Site;

        [OutputConstructor]
        private GetUserGroupResult(
            string id,

            string? name,

            int qosRateMaxDown,

            int qosRateMaxUp,

            string site)
        {
            Id = id;
            Name = name;
            QosRateMaxDown = qosRateMaxDown;
            QosRateMaxUp = qosRateMaxUp;
            Site = site;
        }
    }
}
