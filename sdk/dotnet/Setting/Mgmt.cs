// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace Pulumiverse.Unifi.Setting
{
    /// <summary>
    /// `unifi.setting.Mgmt` manages settings for a unifi site.
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
    ///     var exampleSite = new Unifi.Site("exampleSite", new()
    ///     {
    ///         Description = "example",
    ///     });
    /// 
    ///     var exampleMgmt = new Unifi.Setting.Mgmt("exampleMgmt", new()
    ///     {
    ///         Site = exampleSite.Name,
    ///         AutoUpgrade = true,
    ///     });
    /// 
    /// });
    /// ```
    /// </summary>
    [UnifiResourceType("unifi:setting/mgmt:Mgmt")]
    public partial class Mgmt : global::Pulumi.CustomResource
    {
        /// <summary>
        /// Automatically upgrade device firmware.
        /// </summary>
        [Output("autoUpgrade")]
        public Output<bool?> AutoUpgrade { get; private set; } = null!;

        /// <summary>
        /// The name of the site to associate the settings with.
        /// </summary>
        [Output("site")]
        public Output<string> Site { get; private set; } = null!;

        /// <summary>
        /// Enable SSH authentication.
        /// </summary>
        [Output("sshEnabled")]
        public Output<bool?> SshEnabled { get; private set; } = null!;

        /// <summary>
        /// SSH key.
        /// </summary>
        [Output("sshKeys")]
        public Output<ImmutableArray<Outputs.MgmtSshKey>> SshKeys { get; private set; } = null!;


        /// <summary>
        /// Create a Mgmt resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Mgmt(string name, MgmtArgs? args = null, CustomResourceOptions? options = null)
            : base("unifi:setting/mgmt:Mgmt", name, args ?? new MgmtArgs(), MakeResourceOptions(options, ""))
        {
        }

        private Mgmt(string name, Input<string> id, MgmtState? state = null, CustomResourceOptions? options = null)
            : base("unifi:setting/mgmt:Mgmt", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing Mgmt resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static Mgmt Get(string name, Input<string> id, MgmtState? state = null, CustomResourceOptions? options = null)
        {
            return new Mgmt(name, id, state, options);
        }
    }

    public sealed class MgmtArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Automatically upgrade device firmware.
        /// </summary>
        [Input("autoUpgrade")]
        public Input<bool>? AutoUpgrade { get; set; }

        /// <summary>
        /// The name of the site to associate the settings with.
        /// </summary>
        [Input("site")]
        public Input<string>? Site { get; set; }

        /// <summary>
        /// Enable SSH authentication.
        /// </summary>
        [Input("sshEnabled")]
        public Input<bool>? SshEnabled { get; set; }

        [Input("sshKeys")]
        private InputList<Inputs.MgmtSshKeyArgs>? _sshKeys;

        /// <summary>
        /// SSH key.
        /// </summary>
        public InputList<Inputs.MgmtSshKeyArgs> SshKeys
        {
            get => _sshKeys ?? (_sshKeys = new InputList<Inputs.MgmtSshKeyArgs>());
            set => _sshKeys = value;
        }

        public MgmtArgs()
        {
        }
        public static new MgmtArgs Empty => new MgmtArgs();
    }

    public sealed class MgmtState : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Automatically upgrade device firmware.
        /// </summary>
        [Input("autoUpgrade")]
        public Input<bool>? AutoUpgrade { get; set; }

        /// <summary>
        /// The name of the site to associate the settings with.
        /// </summary>
        [Input("site")]
        public Input<string>? Site { get; set; }

        /// <summary>
        /// Enable SSH authentication.
        /// </summary>
        [Input("sshEnabled")]
        public Input<bool>? SshEnabled { get; set; }

        [Input("sshKeys")]
        private InputList<Inputs.MgmtSshKeyGetArgs>? _sshKeys;

        /// <summary>
        /// SSH key.
        /// </summary>
        public InputList<Inputs.MgmtSshKeyGetArgs> SshKeys
        {
            get => _sshKeys ?? (_sshKeys = new InputList<Inputs.MgmtSshKeyGetArgs>());
            set => _sshKeys = value;
        }

        public MgmtState()
        {
        }
        public static new MgmtState Empty => new MgmtState();
    }
}
