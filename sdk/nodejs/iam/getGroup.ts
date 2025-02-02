// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

/**
 * `unifi.iam.Group` data source can be used to retrieve the ID for a user group by name.
 */
export function getGroup(args?: GetGroupArgs, opts?: pulumi.InvokeOptions): Promise<GetGroupResult> {
    args = args || {};
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("unifi:iam/getGroup:getGroup", {
        "name": args.name,
        "site": args.site,
    }, opts);
}

/**
 * A collection of arguments for invoking getGroup.
 */
export interface GetGroupArgs {
    /**
     * The name of the user group to look up. Defaults to `Default`.
     */
    name?: string;
    /**
     * The name of the site the user group is associated with.
     */
    site?: string;
}

/**
 * A collection of values returned by getGroup.
 */
export interface GetGroupResult {
    /**
     * The ID of this AP group.
     */
    readonly id: string;
    /**
     * The name of the user group to look up. Defaults to `Default`.
     */
    readonly name?: string;
    readonly qosRateMaxDown: number;
    readonly qosRateMaxUp: number;
    /**
     * The name of the site the user group is associated with.
     */
    readonly site: string;
}

export function getGroupOutput(args?: GetGroupOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetGroupResult> {
    return pulumi.output(args).apply(a => getGroup(a, opts))
}

/**
 * A collection of arguments for invoking getGroup.
 */
export interface GetGroupOutputArgs {
    /**
     * The name of the user group to look up. Defaults to `Default`.
     */
    name?: pulumi.Input<string>;
    /**
     * The name of the site the user group is associated with.
     */
    site?: pulumi.Input<string>;
}
