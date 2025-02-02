// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

/**
 * `unifi.iam.User` retrieves properties of a user (or "client" in the UI) of the network by MAC address.
 *
 * ## Example Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as unifi from "@pulumi/unifi";
 *
 * const client = pulumi.output(unifi.iam.getUser({
 *     mac: "01:23:45:67:89:ab",
 * }));
 * ```
 */
export function getUser(args: GetUserArgs, opts?: pulumi.InvokeOptions): Promise<GetUserResult> {
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("unifi:iam/getUser:getUser", {
        "mac": args.mac,
        "site": args.site,
    }, opts);
}

/**
 * A collection of arguments for invoking getUser.
 */
export interface GetUserArgs {
    /**
     * The MAC address of the user.
     */
    mac: string;
    /**
     * The name of the site the user is associated with.
     */
    site?: string;
}

/**
 * A collection of values returned by getUser.
 */
export interface GetUserResult {
    /**
     * Specifies whether this user should be blocked from the network.
     */
    readonly blocked: boolean;
    /**
     * Override the device fingerprint.
     */
    readonly devIdOverride: number;
    /**
     * fixed IPv4 address set for this user.
     */
    readonly fixedIp: string;
    /**
     * The hostname of the user.
     */
    readonly hostname: string;
    /**
     * The ID of the user.
     */
    readonly id: string;
    /**
     * The IP address of the user.
     */
    readonly ip: string;
    /**
     * The MAC address of the user.
     */
    readonly mac: string;
    /**
     * The name of the user.
     */
    readonly name: string;
    /**
     * The network ID for this user.
     */
    readonly networkId: string;
    /**
     * A note with additional information for the user.
     */
    readonly note: string;
    /**
     * The name of the site the user is associated with.
     */
    readonly site: string;
    /**
     * The user group ID for the user.
     */
    readonly userGroupId: string;
}

export function getUserOutput(args: GetUserOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetUserResult> {
    return pulumi.output(args).apply(a => getUser(a, opts))
}

/**
 * A collection of arguments for invoking getUser.
 */
export interface GetUserOutputArgs {
    /**
     * The MAC address of the user.
     */
    mac: pulumi.Input<string>;
    /**
     * The name of the site the user is associated with.
     */
    site?: pulumi.Input<string>;
}
