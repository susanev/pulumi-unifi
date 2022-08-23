// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace Pulumiverse.Unifi.IAM
{
    public static class GetUser
    {
        /// <summary>
        /// `unifi.iam.User` retrieves properties of a user (or "client" in the UI) of the network by MAC address.
        /// </summary>
        public static Task<GetUserResult> InvokeAsync(GetUserArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetUserResult>("unifi:iam/getUser:getUser", args ?? new GetUserArgs(), options.WithDefaults());

        /// <summary>
        /// `unifi.iam.User` retrieves properties of a user (or "client" in the UI) of the network by MAC address.
        /// </summary>
        public static Output<GetUserResult> Invoke(GetUserInvokeArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<GetUserResult>("unifi:iam/getUser:getUser", args ?? new GetUserInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetUserArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The MAC address of the user.
        /// </summary>
        [Input("mac", required: true)]
        public string Mac { get; set; } = null!;

        /// <summary>
        /// The name of the site the user is associated with.
        /// </summary>
        [Input("site")]
        public string? Site { get; set; }

        public GetUserArgs()
        {
        }
    }

    public sealed class GetUserInvokeArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The MAC address of the user.
        /// </summary>
        [Input("mac", required: true)]
        public Input<string> Mac { get; set; } = null!;

        /// <summary>
        /// The name of the site the user is associated with.
        /// </summary>
        [Input("site")]
        public Input<string>? Site { get; set; }

        public GetUserInvokeArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetUserResult
    {
        /// <summary>
        /// Specifies whether this user should be blocked from the network.
        /// </summary>
        public readonly bool Blocked;
        /// <summary>
        /// Override the device fingerprint.
        /// </summary>
        public readonly int DevIdOverride;
        /// <summary>
        /// fixed IPv4 address set for this user.
        /// </summary>
        public readonly string FixedIp;
        /// <summary>
        /// The hostname of the user.
        /// </summary>
        public readonly string Hostname;
        /// <summary>
        /// The ID of the user.
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// The IP address of the user.
        /// </summary>
        public readonly string Ip;
        /// <summary>
        /// The MAC address of the user.
        /// </summary>
        public readonly string Mac;
        /// <summary>
        /// The name of the user.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// The network ID for this user.
        /// </summary>
        public readonly string NetworkId;
        /// <summary>
        /// A note with additional information for the user.
        /// </summary>
        public readonly string Note;
        /// <summary>
        /// The name of the site the user is associated with.
        /// </summary>
        public readonly string Site;
        /// <summary>
        /// The user group ID for the user.
        /// </summary>
        public readonly string UserGroupId;

        [OutputConstructor]
        private GetUserResult(
            bool blocked,

            int devIdOverride,

            string fixedIp,

            string hostname,

            string id,

            string ip,

            string mac,

            string name,

            string networkId,

            string note,

            string site,

            string userGroupId)
        {
            Blocked = blocked;
            DevIdOverride = devIdOverride;
            FixedIp = fixedIp;
            Hostname = hostname;
            Id = id;
            Ip = ip;
            Mac = mac;
            Name = name;
            NetworkId = networkId;
            Note = note;
            Site = site;
            UserGroupId = userGroupId;
        }
    }
}
