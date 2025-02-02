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
        /// using System.Collections.Generic;
        /// using Pulumi;
        /// using Unifi = Pulumi.Unifi;
        /// 
        /// return await Deployment.RunAsync(() =&gt; 
        /// {
        ///     var @default = Unifi.GetApGroup.Invoke();
        /// 
        /// });
        /// ```
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Task<GetApGroupResult> InvokeAsync(GetApGroupArgs? args = null, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetApGroupResult>("unifi:index/getApGroup:getApGroup", args ?? new GetApGroupArgs(), options.WithDefaults());

        /// <summary>
        /// `unifi.getApGroup` data source can be used to retrieve the ID for an AP group by name.
        /// 
        /// {{% examples %}}
        /// ## Example Usage
        /// {{% example %}}
        /// 
        /// ```csharp
        /// using System.Collections.Generic;
        /// using Pulumi;
        /// using Unifi = Pulumi.Unifi;
        /// 
        /// return await Deployment.RunAsync(() =&gt; 
        /// {
        ///     var @default = Unifi.GetApGroup.Invoke();
        /// 
        /// });
        /// ```
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Output<GetApGroupResult> Invoke(GetApGroupInvokeArgs? args = null, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetApGroupResult>("unifi:index/getApGroup:getApGroup", args ?? new GetApGroupInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetApGroupArgs : global::Pulumi.InvokeArgs
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
        public static new GetApGroupArgs Empty => new GetApGroupArgs();
    }

    public sealed class GetApGroupInvokeArgs : global::Pulumi.InvokeArgs
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
        public static new GetApGroupInvokeArgs Empty => new GetApGroupInvokeArgs();
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
