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
    /// `unifi.Site` manages Unifi sites
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
    ///         var mysite = new Unifi.Site("mysite", new Unifi.SiteArgs
    ///         {
    ///             Description = "mysite",
    ///         });
    ///     }
    /// 
    /// }
    /// ```
    /// 
    /// ## Import
    /// 
    /// # import using the API/UI ID
    /// 
    /// ```sh
    ///  $ pulumi import unifi:index/site:Site mysite 5fe6261995fe130013456a36
    /// ```
    /// 
    /// # import using the name (short ID)
    /// 
    /// ```sh
    ///  $ pulumi import unifi:index/site:Site mysite vq98kwez
    /// ```
    /// </summary>
    [UnifiResourceType("unifi:index/site:Site")]
    public partial class Site : Pulumi.CustomResource
    {
        /// <summary>
        /// The description of the site.
        /// </summary>
        [Output("description")]
        public Output<string> Description { get; private set; } = null!;

        /// <summary>
        /// The name of the site.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;


        /// <summary>
        /// Create a Site resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Site(string name, SiteArgs args, CustomResourceOptions? options = null)
            : base("unifi:index/site:Site", name, args ?? new SiteArgs(), MakeResourceOptions(options, ""))
        {
        }

        private Site(string name, Input<string> id, SiteState? state = null, CustomResourceOptions? options = null)
            : base("unifi:index/site:Site", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing Site resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static Site Get(string name, Input<string> id, SiteState? state = null, CustomResourceOptions? options = null)
        {
            return new Site(name, id, state, options);
        }
    }

    public sealed class SiteArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The description of the site.
        /// </summary>
        [Input("description", required: true)]
        public Input<string> Description { get; set; } = null!;

        public SiteArgs()
        {
        }
    }

    public sealed class SiteState : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The description of the site.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// The name of the site.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        public SiteState()
        {
        }
    }
}
