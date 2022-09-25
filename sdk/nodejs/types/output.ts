// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";

export interface DevicePortOverride {
    /**
     * Human-readable name of the port.
     */
    name?: string;
    /**
     * Switch port number.
     */
    number: number;
    /**
     * ID of the Port Profile used on this port.
     */
    portProfileId?: string;
}

export interface WlanSchedule {
    /**
     * Time of day to end the block.
     */
    blockEnd: string;
    /**
     * Time of day to start the block.
     */
    blockStart: string;
    /**
     * Day of week for the block. Valid values are `sun`, `mon`, `tue`, `wed`, `thu`, `fri`, `sat`.
     */
    dayOfWeek: string;
}

export namespace setting {
    export interface MgmtSshKey {
        /**
         * Comment.
         */
        comment?: string;
        /**
         * Public SSH key.
         */
        key?: string;
        /**
         * Name of SSH key.
         */
        name: string;
        /**
         * Type of SSH key, e.g. ssh-rsa.
         */
        type: string;
    }

}
