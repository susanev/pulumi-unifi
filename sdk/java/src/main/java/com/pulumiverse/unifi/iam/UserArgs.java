// *** WARNING: this file was generated by pulumi-java-gen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package com.pulumiverse.unifi.iam;

import com.pulumi.core.Output;
import com.pulumi.core.annotations.Import;
import java.lang.Boolean;
import java.lang.Integer;
import java.lang.String;
import java.util.Objects;
import java.util.Optional;
import javax.annotation.Nullable;


public final class UserArgs extends com.pulumi.resources.ResourceArgs {

    public static final UserArgs Empty = new UserArgs();

    /**
     * Specifies whether this resource should just take over control of an existing user. Defaults to `true`.
     * 
     */
    @Import(name="allowExisting")
    private @Nullable Output<Boolean> allowExisting;

    /**
     * @return Specifies whether this resource should just take over control of an existing user. Defaults to `true`.
     * 
     */
    public Optional<Output<Boolean>> allowExisting() {
        return Optional.ofNullable(this.allowExisting);
    }

    /**
     * Specifies whether this user should be blocked from the network.
     * 
     */
    @Import(name="blocked")
    private @Nullable Output<Boolean> blocked;

    /**
     * @return Specifies whether this user should be blocked from the network.
     * 
     */
    public Optional<Output<Boolean>> blocked() {
        return Optional.ofNullable(this.blocked);
    }

    /**
     * Override the device fingerprint.
     * 
     */
    @Import(name="devIdOverride")
    private @Nullable Output<Integer> devIdOverride;

    /**
     * @return Override the device fingerprint.
     * 
     */
    public Optional<Output<Integer>> devIdOverride() {
        return Optional.ofNullable(this.devIdOverride);
    }

    /**
     * A fixed IPv4 address for this user.
     * 
     */
    @Import(name="fixedIp")
    private @Nullable Output<String> fixedIp;

    /**
     * @return A fixed IPv4 address for this user.
     * 
     */
    public Optional<Output<String>> fixedIp() {
        return Optional.ofNullable(this.fixedIp);
    }

    /**
     * The MAC address of the user.
     * 
     */
    @Import(name="mac", required=true)
    private Output<String> mac;

    /**
     * @return The MAC address of the user.
     * 
     */
    public Output<String> mac() {
        return this.mac;
    }

    /**
     * The name of the user.
     * 
     */
    @Import(name="name")
    private @Nullable Output<String> name;

    /**
     * @return The name of the user.
     * 
     */
    public Optional<Output<String>> name() {
        return Optional.ofNullable(this.name);
    }

    /**
     * The network ID for this user.
     * 
     */
    @Import(name="networkId")
    private @Nullable Output<String> networkId;

    /**
     * @return The network ID for this user.
     * 
     */
    public Optional<Output<String>> networkId() {
        return Optional.ofNullable(this.networkId);
    }

    /**
     * A note with additional information for the user.
     * 
     */
    @Import(name="note")
    private @Nullable Output<String> note;

    /**
     * @return A note with additional information for the user.
     * 
     */
    public Optional<Output<String>> note() {
        return Optional.ofNullable(this.note);
    }

    /**
     * The name of the site to associate the user with.
     * 
     */
    @Import(name="site")
    private @Nullable Output<String> site;

    /**
     * @return The name of the site to associate the user with.
     * 
     */
    public Optional<Output<String>> site() {
        return Optional.ofNullable(this.site);
    }

    /**
     * Specifies whether this resource should tell the controller to &#34;forget&#34; the user on destroy. Defaults to `false`.
     * 
     */
    @Import(name="skipForgetOnDestroy")
    private @Nullable Output<Boolean> skipForgetOnDestroy;

    /**
     * @return Specifies whether this resource should tell the controller to &#34;forget&#34; the user on destroy. Defaults to `false`.
     * 
     */
    public Optional<Output<Boolean>> skipForgetOnDestroy() {
        return Optional.ofNullable(this.skipForgetOnDestroy);
    }

    /**
     * The user group ID for the user.
     * 
     */
    @Import(name="userGroupId")
    private @Nullable Output<String> userGroupId;

    /**
     * @return The user group ID for the user.
     * 
     */
    public Optional<Output<String>> userGroupId() {
        return Optional.ofNullable(this.userGroupId);
    }

    private UserArgs() {}

    private UserArgs(UserArgs $) {
        this.allowExisting = $.allowExisting;
        this.blocked = $.blocked;
        this.devIdOverride = $.devIdOverride;
        this.fixedIp = $.fixedIp;
        this.mac = $.mac;
        this.name = $.name;
        this.networkId = $.networkId;
        this.note = $.note;
        this.site = $.site;
        this.skipForgetOnDestroy = $.skipForgetOnDestroy;
        this.userGroupId = $.userGroupId;
    }

    public static Builder builder() {
        return new Builder();
    }
    public static Builder builder(UserArgs defaults) {
        return new Builder(defaults);
    }

    public static final class Builder {
        private UserArgs $;

        public Builder() {
            $ = new UserArgs();
        }

        public Builder(UserArgs defaults) {
            $ = new UserArgs(Objects.requireNonNull(defaults));
        }

        /**
         * @param allowExisting Specifies whether this resource should just take over control of an existing user. Defaults to `true`.
         * 
         * @return builder
         * 
         */
        public Builder allowExisting(@Nullable Output<Boolean> allowExisting) {
            $.allowExisting = allowExisting;
            return this;
        }

        /**
         * @param allowExisting Specifies whether this resource should just take over control of an existing user. Defaults to `true`.
         * 
         * @return builder
         * 
         */
        public Builder allowExisting(Boolean allowExisting) {
            return allowExisting(Output.of(allowExisting));
        }

        /**
         * @param blocked Specifies whether this user should be blocked from the network.
         * 
         * @return builder
         * 
         */
        public Builder blocked(@Nullable Output<Boolean> blocked) {
            $.blocked = blocked;
            return this;
        }

        /**
         * @param blocked Specifies whether this user should be blocked from the network.
         * 
         * @return builder
         * 
         */
        public Builder blocked(Boolean blocked) {
            return blocked(Output.of(blocked));
        }

        /**
         * @param devIdOverride Override the device fingerprint.
         * 
         * @return builder
         * 
         */
        public Builder devIdOverride(@Nullable Output<Integer> devIdOverride) {
            $.devIdOverride = devIdOverride;
            return this;
        }

        /**
         * @param devIdOverride Override the device fingerprint.
         * 
         * @return builder
         * 
         */
        public Builder devIdOverride(Integer devIdOverride) {
            return devIdOverride(Output.of(devIdOverride));
        }

        /**
         * @param fixedIp A fixed IPv4 address for this user.
         * 
         * @return builder
         * 
         */
        public Builder fixedIp(@Nullable Output<String> fixedIp) {
            $.fixedIp = fixedIp;
            return this;
        }

        /**
         * @param fixedIp A fixed IPv4 address for this user.
         * 
         * @return builder
         * 
         */
        public Builder fixedIp(String fixedIp) {
            return fixedIp(Output.of(fixedIp));
        }

        /**
         * @param mac The MAC address of the user.
         * 
         * @return builder
         * 
         */
        public Builder mac(Output<String> mac) {
            $.mac = mac;
            return this;
        }

        /**
         * @param mac The MAC address of the user.
         * 
         * @return builder
         * 
         */
        public Builder mac(String mac) {
            return mac(Output.of(mac));
        }

        /**
         * @param name The name of the user.
         * 
         * @return builder
         * 
         */
        public Builder name(@Nullable Output<String> name) {
            $.name = name;
            return this;
        }

        /**
         * @param name The name of the user.
         * 
         * @return builder
         * 
         */
        public Builder name(String name) {
            return name(Output.of(name));
        }

        /**
         * @param networkId The network ID for this user.
         * 
         * @return builder
         * 
         */
        public Builder networkId(@Nullable Output<String> networkId) {
            $.networkId = networkId;
            return this;
        }

        /**
         * @param networkId The network ID for this user.
         * 
         * @return builder
         * 
         */
        public Builder networkId(String networkId) {
            return networkId(Output.of(networkId));
        }

        /**
         * @param note A note with additional information for the user.
         * 
         * @return builder
         * 
         */
        public Builder note(@Nullable Output<String> note) {
            $.note = note;
            return this;
        }

        /**
         * @param note A note with additional information for the user.
         * 
         * @return builder
         * 
         */
        public Builder note(String note) {
            return note(Output.of(note));
        }

        /**
         * @param site The name of the site to associate the user with.
         * 
         * @return builder
         * 
         */
        public Builder site(@Nullable Output<String> site) {
            $.site = site;
            return this;
        }

        /**
         * @param site The name of the site to associate the user with.
         * 
         * @return builder
         * 
         */
        public Builder site(String site) {
            return site(Output.of(site));
        }

        /**
         * @param skipForgetOnDestroy Specifies whether this resource should tell the controller to &#34;forget&#34; the user on destroy. Defaults to `false`.
         * 
         * @return builder
         * 
         */
        public Builder skipForgetOnDestroy(@Nullable Output<Boolean> skipForgetOnDestroy) {
            $.skipForgetOnDestroy = skipForgetOnDestroy;
            return this;
        }

        /**
         * @param skipForgetOnDestroy Specifies whether this resource should tell the controller to &#34;forget&#34; the user on destroy. Defaults to `false`.
         * 
         * @return builder
         * 
         */
        public Builder skipForgetOnDestroy(Boolean skipForgetOnDestroy) {
            return skipForgetOnDestroy(Output.of(skipForgetOnDestroy));
        }

        /**
         * @param userGroupId The user group ID for the user.
         * 
         * @return builder
         * 
         */
        public Builder userGroupId(@Nullable Output<String> userGroupId) {
            $.userGroupId = userGroupId;
            return this;
        }

        /**
         * @param userGroupId The user group ID for the user.
         * 
         * @return builder
         * 
         */
        public Builder userGroupId(String userGroupId) {
            return userGroupId(Output.of(userGroupId));
        }

        public UserArgs build() {
            $.mac = Objects.requireNonNull($.mac, "expected parameter 'mac' to be non-null");
            return $;
        }
    }

}