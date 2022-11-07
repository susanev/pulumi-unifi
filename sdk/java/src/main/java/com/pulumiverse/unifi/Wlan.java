// *** WARNING: this file was generated by pulumi-java-gen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package com.pulumiverse.unifi;

import com.pulumi.core.Output;
import com.pulumi.core.annotations.Export;
import com.pulumi.core.annotations.ResourceType;
import com.pulumi.core.internal.Codegen;
import com.pulumiverse.unifi.Utilities;
import com.pulumiverse.unifi.WlanArgs;
import com.pulumiverse.unifi.inputs.WlanState;
import com.pulumiverse.unifi.outputs.WlanSchedule;
import java.lang.Boolean;
import java.lang.Integer;
import java.lang.String;
import java.util.List;
import java.util.Optional;
import javax.annotation.Nullable;

/**
 * `unifi.Wlan` manages a WiFi network / SSID.
 * 
 * ## Example Usage
 * ```java
 * package generated_program;
 * 
 * import com.pulumi.Context;
 * import com.pulumi.Pulumi;
 * import com.pulumi.core.Output;
 * import com.pulumi.unifi.UnifiFunctions;
 * import com.pulumi.unifi.inputs.GetApGroupArgs;
 * import com.pulumi.unifi.iam.IamFunctions;
 * import com.pulumi.unifi.iam.inputs.GetGroupArgs;
 * import com.pulumi.unifi.Network;
 * import com.pulumi.unifi.NetworkArgs;
 * import com.pulumi.unifi.Wlan;
 * import com.pulumi.unifi.WlanArgs;
 * import java.util.List;
 * import java.util.ArrayList;
 * import java.util.Map;
 * import java.io.File;
 * import java.nio.file.Files;
 * import java.nio.file.Paths;
 * 
 * public class App {
 *     public static void main(String[] args) {
 *         Pulumi.run(App::stack);
 *     }
 * 
 *     public static void stack(Context ctx) {
 *         final var config = ctx.config();
 *         final var vlanId = config.get(&#34;vlanId&#34;).orElse(10);
 *         final var defaultApGroup = UnifiFunctions.getApGroup();
 * 
 *         final var defaultGroup = IamFunctions.getGroup();
 * 
 *         var vlan = new Network(&#34;vlan&#34;, NetworkArgs.builder()        
 *             .purpose(&#34;corporate&#34;)
 *             .subnet(&#34;10.0.0.1/24&#34;)
 *             .vlanId(vlanId)
 *             .dhcpStart(&#34;10.0.0.6&#34;)
 *             .dhcpStop(&#34;10.0.0.254&#34;)
 *             .dhcpEnabled(true)
 *             .build());
 * 
 *         var wifi = new Wlan(&#34;wifi&#34;, WlanArgs.builder()        
 *             .passphrase(&#34;12345678&#34;)
 *             .security(&#34;wpapsk&#34;)
 *             .wpa3Support(true)
 *             .wpa3Transition(true)
 *             .pmfMode(&#34;optional&#34;)
 *             .networkId(vlan.id())
 *             .apGroupIds(defaultApGroup.applyValue(getApGroupResult -&gt; getApGroupResult.id()))
 *             .userGroupId(defaultGroup.applyValue(getGroupResult -&gt; getGroupResult.id()))
 *             .build());
 * 
 *     }
 * }
 * ```
 * 
 * ## Import
 * 
 * import from provider configured site
 * 
 * ```sh
 *  $ pulumi import unifi:index/wlan:Wlan mywlan 5dc28e5e9106d105bdc87217
 * ```
 * 
 *  import from another site
 * 
 * ```sh
 *  $ pulumi import unifi:index/wlan:Wlan mywlan bfa2l6i7:5dc28e5e9106d105bdc87217
 * ```
 * 
 */
@ResourceType(type="unifi:index/wlan:Wlan")
public class Wlan extends com.pulumi.resources.CustomResource {
    /**
     * IDs of the AP groups to use for this network.
     * 
     */
    @Export(name="apGroupIds", refs={List.class,String.class}, tree="[0,1]")
    private Output</* @Nullable */ List<String>> apGroupIds;

    /**
     * @return IDs of the AP groups to use for this network.
     * 
     */
    public Output<Optional<List<String>>> apGroupIds() {
        return Codegen.optional(this.apGroupIds);
    }
    /**
     * Indicates whether or not to hide the SSID from broadcast.
     * 
     */
    @Export(name="hideSsid", refs={Boolean.class}, tree="[0]")
    private Output</* @Nullable */ Boolean> hideSsid;

    /**
     * @return Indicates whether or not to hide the SSID from broadcast.
     * 
     */
    public Output<Optional<Boolean>> hideSsid() {
        return Codegen.optional(this.hideSsid);
    }
    /**
     * Indicates that this is a guest WLAN and should use guest behaviors.
     * 
     */
    @Export(name="isGuest", refs={Boolean.class}, tree="[0]")
    private Output</* @Nullable */ Boolean> isGuest;

    /**
     * @return Indicates that this is a guest WLAN and should use guest behaviors.
     * 
     */
    public Output<Optional<Boolean>> isGuest() {
        return Codegen.optional(this.isGuest);
    }
    /**
     * Isolates stations on layer 2 (ethernet) level Defaults to `false`.
     * 
     */
    @Export(name="l2Isolation", refs={Boolean.class}, tree="[0]")
    private Output</* @Nullable */ Boolean> l2Isolation;

    /**
     * @return Isolates stations on layer 2 (ethernet) level Defaults to `false`.
     * 
     */
    public Output<Optional<Boolean>> l2Isolation() {
        return Codegen.optional(this.l2Isolation);
    }
    /**
     * Indicates whether or not the MAC filter is turned of for the network.
     * 
     */
    @Export(name="macFilterEnabled", refs={Boolean.class}, tree="[0]")
    private Output</* @Nullable */ Boolean> macFilterEnabled;

    /**
     * @return Indicates whether or not the MAC filter is turned of for the network.
     * 
     */
    public Output<Optional<Boolean>> macFilterEnabled() {
        return Codegen.optional(this.macFilterEnabled);
    }
    /**
     * List of MAC addresses to filter (only valid if `mac_filter_enabled` is `true`).
     * 
     */
    @Export(name="macFilterLists", refs={List.class,String.class}, tree="[0,1]")
    private Output</* @Nullable */ List<String>> macFilterLists;

    /**
     * @return List of MAC addresses to filter (only valid if `mac_filter_enabled` is `true`).
     * 
     */
    public Output<Optional<List<String>>> macFilterLists() {
        return Codegen.optional(this.macFilterLists);
    }
    /**
     * MAC address filter policy (only valid if `mac_filter_enabled` is `true`). Defaults to `deny`.
     * 
     */
    @Export(name="macFilterPolicy", refs={String.class}, tree="[0]")
    private Output</* @Nullable */ String> macFilterPolicy;

    /**
     * @return MAC address filter policy (only valid if `mac_filter_enabled` is `true`). Defaults to `deny`.
     * 
     */
    public Output<Optional<String>> macFilterPolicy() {
        return Codegen.optional(this.macFilterPolicy);
    }
    /**
     * Set minimum data rate control for 2G devices, in Kbps. Use `0` to disable minimum data rates. Valid values are: `1000`, `2000`, `5500`, `6000`, `9000`, `11000`, `12000`, `18000`, `24000`, `36000`, `48000`,  and `54000`.
     * 
     */
    @Export(name="minimumDataRate2gKbps", refs={Integer.class}, tree="[0]")
    private Output</* @Nullable */ Integer> minimumDataRate2gKbps;

    /**
     * @return Set minimum data rate control for 2G devices, in Kbps. Use `0` to disable minimum data rates. Valid values are: `1000`, `2000`, `5500`, `6000`, `9000`, `11000`, `12000`, `18000`, `24000`, `36000`, `48000`,  and `54000`.
     * 
     */
    public Output<Optional<Integer>> minimumDataRate2gKbps() {
        return Codegen.optional(this.minimumDataRate2gKbps);
    }
    /**
     * Set minimum data rate control for 5G devices, in Kbps. Use `0` to disable minimum data rates. Valid values are: `6000`, `9000`, `12000`, `18000`, `24000`, `36000`, `48000`,  and `54000`.
     * 
     */
    @Export(name="minimumDataRate5gKbps", refs={Integer.class}, tree="[0]")
    private Output</* @Nullable */ Integer> minimumDataRate5gKbps;

    /**
     * @return Set minimum data rate control for 5G devices, in Kbps. Use `0` to disable minimum data rates. Valid values are: `6000`, `9000`, `12000`, `18000`, `24000`, `36000`, `48000`,  and `54000`.
     * 
     */
    public Output<Optional<Integer>> minimumDataRate5gKbps() {
        return Codegen.optional(this.minimumDataRate5gKbps);
    }
    /**
     * Indicates whether or not Multicast Enhance is turned of for the network.
     * 
     */
    @Export(name="multicastEnhance", refs={Boolean.class}, tree="[0]")
    private Output</* @Nullable */ Boolean> multicastEnhance;

    /**
     * @return Indicates whether or not Multicast Enhance is turned of for the network.
     * 
     */
    public Output<Optional<Boolean>> multicastEnhance() {
        return Codegen.optional(this.multicastEnhance);
    }
    /**
     * The SSID of the network.
     * 
     */
    @Export(name="name", refs={String.class}, tree="[0]")
    private Output<String> name;

    /**
     * @return The SSID of the network.
     * 
     */
    public Output<String> name() {
        return this.name;
    }
    /**
     * ID of the network for this SSID
     * 
     */
    @Export(name="networkId", refs={String.class}, tree="[0]")
    private Output</* @Nullable */ String> networkId;

    /**
     * @return ID of the network for this SSID
     * 
     */
    public Output<Optional<String>> networkId() {
        return Codegen.optional(this.networkId);
    }
    /**
     * Connect high performance clients to 5 GHz only Defaults to `true`.
     * 
     */
    @Export(name="no2ghzOui", refs={Boolean.class}, tree="[0]")
    private Output</* @Nullable */ Boolean> no2ghzOui;

    /**
     * @return Connect high performance clients to 5 GHz only Defaults to `true`.
     * 
     */
    public Output<Optional<Boolean>> no2ghzOui() {
        return Codegen.optional(this.no2ghzOui);
    }
    /**
     * The passphrase for the network, this is only required if `security` is not set to `open`.
     * 
     */
    @Export(name="passphrase", refs={String.class}, tree="[0]")
    private Output</* @Nullable */ String> passphrase;

    /**
     * @return The passphrase for the network, this is only required if `security` is not set to `open`.
     * 
     */
    public Output<Optional<String>> passphrase() {
        return Codegen.optional(this.passphrase);
    }
    /**
     * Enable Protected Management Frames. This cannot be disabled if using WPA 3. Valid values are `required`, `optional` and `disabled`. Defaults to `disabled`.
     * 
     */
    @Export(name="pmfMode", refs={String.class}, tree="[0]")
    private Output</* @Nullable */ String> pmfMode;

    /**
     * @return Enable Protected Management Frames. This cannot be disabled if using WPA 3. Valid values are `required`, `optional` and `disabled`. Defaults to `disabled`.
     * 
     */
    public Output<Optional<String>> pmfMode() {
        return Codegen.optional(this.pmfMode);
    }
    /**
     * ID of the RADIUS profile to use when security `wpaeap`. You can query this via the `unifi.getRadiusProfile` data source.
     * 
     */
    @Export(name="radiusProfileId", refs={String.class}, tree="[0]")
    private Output</* @Nullable */ String> radiusProfileId;

    /**
     * @return ID of the RADIUS profile to use when security `wpaeap`. You can query this via the `unifi.getRadiusProfile` data source.
     * 
     */
    public Output<Optional<String>> radiusProfileId() {
        return Codegen.optional(this.radiusProfileId);
    }
    /**
     * Start and stop schedules for the WLAN
     * 
     */
    @Export(name="schedules", refs={List.class,WlanSchedule.class}, tree="[0,1]")
    private Output</* @Nullable */ List<WlanSchedule>> schedules;

    /**
     * @return Start and stop schedules for the WLAN
     * 
     */
    public Output<Optional<List<WlanSchedule>>> schedules() {
        return Codegen.optional(this.schedules);
    }
    /**
     * The type of WiFi security for this network. Valid values are: `wpapsk`, `wpaeap`, and `open`.
     * 
     */
    @Export(name="security", refs={String.class}, tree="[0]")
    private Output<String> security;

    /**
     * @return The type of WiFi security for this network. Valid values are: `wpapsk`, `wpaeap`, and `open`.
     * 
     */
    public Output<String> security() {
        return this.security;
    }
    /**
     * The name of the site to associate the wlan with.
     * 
     */
    @Export(name="site", refs={String.class}, tree="[0]")
    private Output<String> site;

    /**
     * @return The name of the site to associate the wlan with.
     * 
     */
    public Output<String> site() {
        return this.site;
    }
    /**
     * Enable Unscheduled Automatic Power Save Delivery Defaults to `false`.
     * 
     */
    @Export(name="uapsd", refs={Boolean.class}, tree="[0]")
    private Output</* @Nullable */ Boolean> uapsd;

    /**
     * @return Enable Unscheduled Automatic Power Save Delivery Defaults to `false`.
     * 
     */
    public Output<Optional<Boolean>> uapsd() {
        return Codegen.optional(this.uapsd);
    }
    /**
     * ID of the user group to use for this network.
     * 
     */
    @Export(name="userGroupId", refs={String.class}, tree="[0]")
    private Output<String> userGroupId;

    /**
     * @return ID of the user group to use for this network.
     * 
     */
    public Output<String> userGroupId() {
        return this.userGroupId;
    }
    /**
     * Radio band your WiFi network will use.
     * 
     */
    @Export(name="wlanBand", refs={String.class}, tree="[0]")
    private Output</* @Nullable */ String> wlanBand;

    /**
     * @return Radio band your WiFi network will use.
     * 
     */
    public Output<Optional<String>> wlanBand() {
        return Codegen.optional(this.wlanBand);
    }
    /**
     * Enable WPA 3 support (security must be `wpapsk` and PMF must be turned on).
     * 
     */
    @Export(name="wpa3Support", refs={Boolean.class}, tree="[0]")
    private Output</* @Nullable */ Boolean> wpa3Support;

    /**
     * @return Enable WPA 3 support (security must be `wpapsk` and PMF must be turned on).
     * 
     */
    public Output<Optional<Boolean>> wpa3Support() {
        return Codegen.optional(this.wpa3Support);
    }
    /**
     * Enable WPA 3 and WPA 2 support (security must be `wpapsk` and `wpa3_support` must be true).
     * 
     */
    @Export(name="wpa3Transition", refs={Boolean.class}, tree="[0]")
    private Output</* @Nullable */ Boolean> wpa3Transition;

    /**
     * @return Enable WPA 3 and WPA 2 support (security must be `wpapsk` and `wpa3_support` must be true).
     * 
     */
    public Output<Optional<Boolean>> wpa3Transition() {
        return Codegen.optional(this.wpa3Transition);
    }

    /**
     *
     * @param name The _unique_ name of the resulting resource.
     */
    public Wlan(String name) {
        this(name, WlanArgs.Empty);
    }
    /**
     *
     * @param name The _unique_ name of the resulting resource.
     * @param args The arguments to use to populate this resource's properties.
     */
    public Wlan(String name, WlanArgs args) {
        this(name, args, null);
    }
    /**
     *
     * @param name The _unique_ name of the resulting resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param options A bag of options that control this resource's behavior.
     */
    public Wlan(String name, WlanArgs args, @Nullable com.pulumi.resources.CustomResourceOptions options) {
        super("unifi:index/wlan:Wlan", name, args == null ? WlanArgs.Empty : args, makeResourceOptions(options, Codegen.empty()));
    }

    private Wlan(String name, Output<String> id, @Nullable WlanState state, @Nullable com.pulumi.resources.CustomResourceOptions options) {
        super("unifi:index/wlan:Wlan", name, state, makeResourceOptions(options, id));
    }

    private static com.pulumi.resources.CustomResourceOptions makeResourceOptions(@Nullable com.pulumi.resources.CustomResourceOptions options, @Nullable Output<String> id) {
        var defaultOptions = com.pulumi.resources.CustomResourceOptions.builder()
            .version(Utilities.getVersion())
            .additionalSecretOutputs(List.of(
                "passphrase"
            ))
            .build();
        return com.pulumi.resources.CustomResourceOptions.merge(defaultOptions, options, id);
    }

    /**
     * Get an existing Host resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state
     * @param options Optional settings to control the behavior of the CustomResource.
     */
    public static Wlan get(String name, Output<String> id, @Nullable WlanState state, @Nullable com.pulumi.resources.CustomResourceOptions options) {
        return new Wlan(name, id, state, options);
    }
}
