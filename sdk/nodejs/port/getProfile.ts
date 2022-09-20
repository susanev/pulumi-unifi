// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

/**
 * `unifi.port.Profile` data source can be used to retrieve the ID for a port profile by name.
 *
 * ## Example Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as unifi from "@pulumi/unifi";
 *
 * const all = pulumi.output(unifi.port.getProfile());
 * ```
 */
export function getProfile(args?: GetProfileArgs, opts?: pulumi.InvokeOptions): Promise<GetProfileResult> {
    args = args || {};
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("unifi:port/getProfile:getProfile", {
        "name": args.name,
        "site": args.site,
    }, opts);
}

/**
 * A collection of arguments for invoking getProfile.
 */
export interface GetProfileArgs {
    /**
     * The name of the port profile to look up. Defaults to `All`.
     */
    name?: string;
    /**
     * The name of the site the port profile is associated with.
     */
    site?: string;
}

/**
 * A collection of values returned by getProfile.
 */
export interface GetProfileResult {
    /**
     * The ID of this port profile.
     */
    readonly id: string;
    /**
     * The name of the port profile to look up. Defaults to `All`.
     */
    readonly name?: string;
    /**
     * The name of the site the port profile is associated with.
     */
    readonly site: string;
}

export function getProfileOutput(args?: GetProfileOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetProfileResult> {
    return pulumi.output(args).apply(a => getProfile(a, opts))
}

/**
 * A collection of arguments for invoking getProfile.
 */
export interface GetProfileOutputArgs {
    /**
     * The name of the port profile to look up. Defaults to `All`.
     */
    name?: pulumi.Input<string>;
    /**
     * The name of the site the port profile is associated with.
     */
    site?: pulumi.Input<string>;
}