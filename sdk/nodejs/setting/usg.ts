// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

/**
 * `unifi.setting.USG` manages settings for a Unifi Security Gateway.
 */
export class USG extends pulumi.CustomResource {
    /**
     * Get an existing USG resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: USGState, opts?: pulumi.CustomResourceOptions): USG {
        return new USG(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'unifi:setting/uSG:USG';

    /**
     * Returns true if the given object is an instance of USG.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is USG {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === USG.__pulumiType;
    }

    /**
     * The DHCP relay servers.
     */
    public readonly dhcpRelayServers!: pulumi.Output<string[]>;
    /**
     * Whether the guest firewall log is enabled.
     */
    public readonly firewallGuestDefaultLog!: pulumi.Output<boolean>;
    /**
     * Whether the LAN firewall log is enabled.
     */
    public readonly firewallLanDefaultLog!: pulumi.Output<boolean>;
    /**
     * Whether the WAN firewall log is enabled.
     */
    public readonly firewallWanDefaultLog!: pulumi.Output<boolean>;
    /**
     * Whether multicast DNS is enabled.
     */
    public readonly multicastDnsEnabled!: pulumi.Output<boolean>;
    /**
     * The name of the site to associate the settings with.
     */
    public readonly site!: pulumi.Output<string>;

    /**
     * Create a USG resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args?: USGArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: USGArgs | USGState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as USGState | undefined;
            resourceInputs["dhcpRelayServers"] = state ? state.dhcpRelayServers : undefined;
            resourceInputs["firewallGuestDefaultLog"] = state ? state.firewallGuestDefaultLog : undefined;
            resourceInputs["firewallLanDefaultLog"] = state ? state.firewallLanDefaultLog : undefined;
            resourceInputs["firewallWanDefaultLog"] = state ? state.firewallWanDefaultLog : undefined;
            resourceInputs["multicastDnsEnabled"] = state ? state.multicastDnsEnabled : undefined;
            resourceInputs["site"] = state ? state.site : undefined;
        } else {
            const args = argsOrState as USGArgs | undefined;
            resourceInputs["dhcpRelayServers"] = args ? args.dhcpRelayServers : undefined;
            resourceInputs["firewallGuestDefaultLog"] = args ? args.firewallGuestDefaultLog : undefined;
            resourceInputs["firewallLanDefaultLog"] = args ? args.firewallLanDefaultLog : undefined;
            resourceInputs["firewallWanDefaultLog"] = args ? args.firewallWanDefaultLog : undefined;
            resourceInputs["multicastDnsEnabled"] = args ? args.multicastDnsEnabled : undefined;
            resourceInputs["site"] = args ? args.site : undefined;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(USG.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering USG resources.
 */
export interface USGState {
    /**
     * The DHCP relay servers.
     */
    dhcpRelayServers?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * Whether the guest firewall log is enabled.
     */
    firewallGuestDefaultLog?: pulumi.Input<boolean>;
    /**
     * Whether the LAN firewall log is enabled.
     */
    firewallLanDefaultLog?: pulumi.Input<boolean>;
    /**
     * Whether the WAN firewall log is enabled.
     */
    firewallWanDefaultLog?: pulumi.Input<boolean>;
    /**
     * Whether multicast DNS is enabled.
     */
    multicastDnsEnabled?: pulumi.Input<boolean>;
    /**
     * The name of the site to associate the settings with.
     */
    site?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a USG resource.
 */
export interface USGArgs {
    /**
     * The DHCP relay servers.
     */
    dhcpRelayServers?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * Whether the guest firewall log is enabled.
     */
    firewallGuestDefaultLog?: pulumi.Input<boolean>;
    /**
     * Whether the LAN firewall log is enabled.
     */
    firewallLanDefaultLog?: pulumi.Input<boolean>;
    /**
     * Whether the WAN firewall log is enabled.
     */
    firewallWanDefaultLog?: pulumi.Input<boolean>;
    /**
     * Whether multicast DNS is enabled.
     */
    multicastDnsEnabled?: pulumi.Input<boolean>;
    /**
     * The name of the site to associate the settings with.
     */
    site?: pulumi.Input<string>;
}
