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
    public static class GetApGroup
    {
        /// <summary>
        /// `unifi.getApGroup` data source can be used to retrieve the ID for an AP group by name.
        /// 
        /// {{% examples %}}
        /// ## Example Usage
        /// {{% example %}}
        /// 
        /// ```csharp
        /// using Pulumi;
        /// using Unifi = Pulumi.Unifi;
        /// 
        /// class MyStack : Stack
        /// {
        ///     public MyStack()
        ///     {
        ///         var @default = Output.Create(Unifi.GetApGroup.InvokeAsync());
        ///     }
        /// 
        /// }
        /// ```
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Task<GetApGroupResult> InvokeAsync(GetApGroupArgs? args = null, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetApGroupResult>("unifi:index/getApGroup:getApGroup", args ?? new GetApGroupArgs(), options.WithDefaults());

        /// <summary>
        /// `unifi.getApGroup` data source can be used to retrieve the ID for an AP group by name.
        /// 
        /// {{% examples %}}
        /// ## Example Usage
        /// {{% example %}}
        /// 
        /// ```csharp
        /// using Pulumi;
        /// using Unifi = Pulumi.Unifi;
        /// 
        /// class MyStack : Stack
        /// {
        ///     public MyStack()
        ///     {
        ///         var @default = Output.Create(Unifi.GetApGroup.InvokeAsync());
        ///     }
        /// 
        /// }
        /// ```
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Output<GetApGroupResult> Invoke(GetApGroupInvokeArgs? args = null, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<GetApGroupResult>("unifi:index/getApGroup:getApGroup", args ?? new GetApGroupInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetApGroupArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The name of the AP group to look up, leave blank to look up the default AP group.
        /// </summary>
        [Input("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The name of the site the AP group is associated with.
        /// </summary>
        [Input("site")]
        public string? Site { get; set; }

        public GetApGroupArgs()
        {
        }
    }

    public sealed class GetApGroupInvokeArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The name of the AP group to look up, leave blank to look up the default AP group.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// The name of the site the AP group is associated with.
        /// </summary>
        [Input("site")]
        public Input<string>? Site { get; set; }

        public GetApGroupInvokeArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetApGroupResult
    {
        /// <summary>
        /// The ID of this AP group.
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// The name of the AP group to look up, leave blank to look up the default AP group.
        /// </summary>
        public readonly string? Name;
        /// <summary>
        /// The name of the site the AP group is associated with.
        /// </summary>
        public readonly string Site;

        [OutputConstructor]
        private GetApGroupResult(
            string id,

            string? name,

            string site)
        {
            Id = id;
            Name = name;
            Site = site;
        }
    }
}
