// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

// Export members:
export { GetGroupArgs, GetGroupResult, GetGroupOutputArgs } from "./getGroup";
export const getGroup: typeof import("./getGroup").getGroup = null as any;
export const getGroupOutput: typeof import("./getGroup").getGroupOutput = null as any;

export { GetUserArgs, GetUserResult, GetUserOutputArgs } from "./getUser";
export const getUser: typeof import("./getUser").getUser = null as any;
export const getUserOutput: typeof import("./getUser").getUserOutput = null as any;

export { GroupArgs, GroupState } from "./group";
export type Group = import("./group").Group;
export const Group: typeof import("./group").Group = null as any;

export { UserArgs, UserState } from "./user";
export type User = import("./user").User;
export const User: typeof import("./user").User = null as any;

utilities.lazyLoad(exports, ["getGroup","getGroupOutput"], () => require("./getGroup"));
utilities.lazyLoad(exports, ["getUser","getUserOutput"], () => require("./getUser"));
utilities.lazyLoad(exports, ["Group"], () => require("./group"));
utilities.lazyLoad(exports, ["User"], () => require("./user"));

const _module = {
    version: utilities.getVersion(),
    construct: (name: string, type: string, urn: string): pulumi.Resource => {
        switch (type) {
            case "unifi:iam/group:Group":
                return new Group(name, <any>undefined, { urn })
            case "unifi:iam/user:User":
                return new User(name, <any>undefined, { urn })
            default:
                throw new Error(`unknown resource type ${type}`);
        }
    },
};
pulumi.runtime.registerResourceModule("unifi", "iam/group", _module)
pulumi.runtime.registerResourceModule("unifi", "iam/user", _module)
