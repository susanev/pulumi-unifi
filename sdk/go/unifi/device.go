// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package unifi

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// ## Example Usage
//
// ```go
// package main
//
// import (
//
//	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
//	"github.com/pulumiverse/pulumi-unifi/sdk/go/unifi"
//	"github.com/pulumiverse/pulumi-unifi/sdk/go/unifi/port"
//
// )
//
//	func main() {
//		pulumi.Run(func(ctx *pulumi.Context) error {
//			disabled, err := port.LookupProfile(ctx, &port.LookupProfileArgs{
//				Name: pulumi.StringRef("Disabled"),
//			}, nil)
//			if err != nil {
//				return err
//			}
//			poe, err := port.NewProfile(ctx, "poe", &port.ProfileArgs{
//				Forward:             pulumi.String("customize"),
//				NativeNetworkconfId: pulumi.Any(_var.Native_network_id),
//				TaggedNetworkconfIds: pulumi.StringArray{
//					pulumi.Any(_var.Some_vlan_network_id),
//				},
//				PoeMode: pulumi.String("auto"),
//			})
//			if err != nil {
//				return err
//			}
//			_, err = unifi.NewDevice(ctx, "us24Poe", &unifi.DeviceArgs{
//				Mac: pulumi.String("01:23:45:67:89:AB"),
//				PortOverrides: DevicePortOverrideArray{
//					&DevicePortOverrideArgs{
//						Number:        pulumi.Int(1),
//						Name:          pulumi.String("port w/ poe"),
//						PortProfileId: poe.ID(),
//					},
//					&DevicePortOverrideArgs{
//						Number:        pulumi.Int(2),
//						Name:          pulumi.String("disabled"),
//						PortProfileId: pulumi.String(disabled.Id),
//					},
//				},
//			})
//			if err != nil {
//				return err
//			}
//			return nil
//		})
//	}
//
// ```
type Device struct {
	pulumi.CustomResourceState

	// Specifies whether this device should be disabled.
	Disabled pulumi.BoolOutput `pulumi:"disabled"`
	// The MAC address of the device. This can be specified so that the provider can take control of a device (since devices are created through adoption).
	Mac pulumi.StringOutput `pulumi:"mac"`
	// The name of the device.
	Name pulumi.StringOutput `pulumi:"name"`
	// Settings overrides for specific switch ports.
	PortOverrides DevicePortOverrideArrayOutput `pulumi:"portOverrides"`
	// The name of the site to associate the device with.
	Site pulumi.StringOutput `pulumi:"site"`
}

// NewDevice registers a new resource with the given unique name, arguments, and options.
func NewDevice(ctx *pulumi.Context,
	name string, args *DeviceArgs, opts ...pulumi.ResourceOption) (*Device, error) {
	if args == nil {
		args = &DeviceArgs{}
	}

	opts = pkgResourceDefaultOpts(opts)
	var resource Device
	err := ctx.RegisterResource("unifi:index/device:Device", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetDevice gets an existing Device resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetDevice(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *DeviceState, opts ...pulumi.ResourceOption) (*Device, error) {
	var resource Device
	err := ctx.ReadResource("unifi:index/device:Device", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering Device resources.
type deviceState struct {
	// Specifies whether this device should be disabled.
	Disabled *bool `pulumi:"disabled"`
	// The MAC address of the device. This can be specified so that the provider can take control of a device (since devices are created through adoption).
	Mac *string `pulumi:"mac"`
	// The name of the device.
	Name *string `pulumi:"name"`
	// Settings overrides for specific switch ports.
	PortOverrides []DevicePortOverride `pulumi:"portOverrides"`
	// The name of the site to associate the device with.
	Site *string `pulumi:"site"`
}

type DeviceState struct {
	// Specifies whether this device should be disabled.
	Disabled pulumi.BoolPtrInput
	// The MAC address of the device. This can be specified so that the provider can take control of a device (since devices are created through adoption).
	Mac pulumi.StringPtrInput
	// The name of the device.
	Name pulumi.StringPtrInput
	// Settings overrides for specific switch ports.
	PortOverrides DevicePortOverrideArrayInput
	// The name of the site to associate the device with.
	Site pulumi.StringPtrInput
}

func (DeviceState) ElementType() reflect.Type {
	return reflect.TypeOf((*deviceState)(nil)).Elem()
}

type deviceArgs struct {
	// The MAC address of the device. This can be specified so that the provider can take control of a device (since devices are created through adoption).
	Mac *string `pulumi:"mac"`
	// The name of the device.
	Name *string `pulumi:"name"`
	// Settings overrides for specific switch ports.
	PortOverrides []DevicePortOverride `pulumi:"portOverrides"`
	// The name of the site to associate the device with.
	Site *string `pulumi:"site"`
}

// The set of arguments for constructing a Device resource.
type DeviceArgs struct {
	// The MAC address of the device. This can be specified so that the provider can take control of a device (since devices are created through adoption).
	Mac pulumi.StringPtrInput
	// The name of the device.
	Name pulumi.StringPtrInput
	// Settings overrides for specific switch ports.
	PortOverrides DevicePortOverrideArrayInput
	// The name of the site to associate the device with.
	Site pulumi.StringPtrInput
}

func (DeviceArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*deviceArgs)(nil)).Elem()
}

type DeviceInput interface {
	pulumi.Input

	ToDeviceOutput() DeviceOutput
	ToDeviceOutputWithContext(ctx context.Context) DeviceOutput
}

func (*Device) ElementType() reflect.Type {
	return reflect.TypeOf((**Device)(nil)).Elem()
}

func (i *Device) ToDeviceOutput() DeviceOutput {
	return i.ToDeviceOutputWithContext(context.Background())
}

func (i *Device) ToDeviceOutputWithContext(ctx context.Context) DeviceOutput {
	return pulumi.ToOutputWithContext(ctx, i).(DeviceOutput)
}

// DeviceArrayInput is an input type that accepts DeviceArray and DeviceArrayOutput values.
// You can construct a concrete instance of `DeviceArrayInput` via:
//
//	DeviceArray{ DeviceArgs{...} }
type DeviceArrayInput interface {
	pulumi.Input

	ToDeviceArrayOutput() DeviceArrayOutput
	ToDeviceArrayOutputWithContext(context.Context) DeviceArrayOutput
}

type DeviceArray []DeviceInput

func (DeviceArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*Device)(nil)).Elem()
}

func (i DeviceArray) ToDeviceArrayOutput() DeviceArrayOutput {
	return i.ToDeviceArrayOutputWithContext(context.Background())
}

func (i DeviceArray) ToDeviceArrayOutputWithContext(ctx context.Context) DeviceArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(DeviceArrayOutput)
}

// DeviceMapInput is an input type that accepts DeviceMap and DeviceMapOutput values.
// You can construct a concrete instance of `DeviceMapInput` via:
//
//	DeviceMap{ "key": DeviceArgs{...} }
type DeviceMapInput interface {
	pulumi.Input

	ToDeviceMapOutput() DeviceMapOutput
	ToDeviceMapOutputWithContext(context.Context) DeviceMapOutput
}

type DeviceMap map[string]DeviceInput

func (DeviceMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*Device)(nil)).Elem()
}

func (i DeviceMap) ToDeviceMapOutput() DeviceMapOutput {
	return i.ToDeviceMapOutputWithContext(context.Background())
}

func (i DeviceMap) ToDeviceMapOutputWithContext(ctx context.Context) DeviceMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(DeviceMapOutput)
}

type DeviceOutput struct{ *pulumi.OutputState }

func (DeviceOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**Device)(nil)).Elem()
}

func (o DeviceOutput) ToDeviceOutput() DeviceOutput {
	return o
}

func (o DeviceOutput) ToDeviceOutputWithContext(ctx context.Context) DeviceOutput {
	return o
}

// Specifies whether this device should be disabled.
func (o DeviceOutput) Disabled() pulumi.BoolOutput {
	return o.ApplyT(func(v *Device) pulumi.BoolOutput { return v.Disabled }).(pulumi.BoolOutput)
}

// The MAC address of the device. This can be specified so that the provider can take control of a device (since devices are created through adoption).
func (o DeviceOutput) Mac() pulumi.StringOutput {
	return o.ApplyT(func(v *Device) pulumi.StringOutput { return v.Mac }).(pulumi.StringOutput)
}

// The name of the device.
func (o DeviceOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v *Device) pulumi.StringOutput { return v.Name }).(pulumi.StringOutput)
}

// Settings overrides for specific switch ports.
func (o DeviceOutput) PortOverrides() DevicePortOverrideArrayOutput {
	return o.ApplyT(func(v *Device) DevicePortOverrideArrayOutput { return v.PortOverrides }).(DevicePortOverrideArrayOutput)
}

// The name of the site to associate the device with.
func (o DeviceOutput) Site() pulumi.StringOutput {
	return o.ApplyT(func(v *Device) pulumi.StringOutput { return v.Site }).(pulumi.StringOutput)
}

type DeviceArrayOutput struct{ *pulumi.OutputState }

func (DeviceArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*Device)(nil)).Elem()
}

func (o DeviceArrayOutput) ToDeviceArrayOutput() DeviceArrayOutput {
	return o
}

func (o DeviceArrayOutput) ToDeviceArrayOutputWithContext(ctx context.Context) DeviceArrayOutput {
	return o
}

func (o DeviceArrayOutput) Index(i pulumi.IntInput) DeviceOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *Device {
		return vs[0].([]*Device)[vs[1].(int)]
	}).(DeviceOutput)
}

type DeviceMapOutput struct{ *pulumi.OutputState }

func (DeviceMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*Device)(nil)).Elem()
}

func (o DeviceMapOutput) ToDeviceMapOutput() DeviceMapOutput {
	return o
}

func (o DeviceMapOutput) ToDeviceMapOutputWithContext(ctx context.Context) DeviceMapOutput {
	return o
}

func (o DeviceMapOutput) MapIndex(k pulumi.StringInput) DeviceOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *Device {
		return vs[0].(map[string]*Device)[vs[1].(string)]
	}).(DeviceOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*DeviceInput)(nil)).Elem(), &Device{})
	pulumi.RegisterInputType(reflect.TypeOf((*DeviceArrayInput)(nil)).Elem(), DeviceArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*DeviceMapInput)(nil)).Elem(), DeviceMap{})
	pulumi.RegisterOutputType(DeviceOutput{})
	pulumi.RegisterOutputType(DeviceArrayOutput{})
	pulumi.RegisterOutputType(DeviceMapOutput{})
}
