// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package unifi

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

type DevicePortOverride struct {
	// Human-readable name of the port.
	Name *string `pulumi:"name"`
	// Switch port number.
	Number int `pulumi:"number"`
	// ID of the Port Profile used on this port.
	PortProfileId *string `pulumi:"portProfileId"`
}

// DevicePortOverrideInput is an input type that accepts DevicePortOverrideArgs and DevicePortOverrideOutput values.
// You can construct a concrete instance of `DevicePortOverrideInput` via:
//
//	DevicePortOverrideArgs{...}
type DevicePortOverrideInput interface {
	pulumi.Input

	ToDevicePortOverrideOutput() DevicePortOverrideOutput
	ToDevicePortOverrideOutputWithContext(context.Context) DevicePortOverrideOutput
}

type DevicePortOverrideArgs struct {
	// Human-readable name of the port.
	Name pulumi.StringPtrInput `pulumi:"name"`
	// Switch port number.
	Number pulumi.IntInput `pulumi:"number"`
	// ID of the Port Profile used on this port.
	PortProfileId pulumi.StringPtrInput `pulumi:"portProfileId"`
}

func (DevicePortOverrideArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*DevicePortOverride)(nil)).Elem()
}

func (i DevicePortOverrideArgs) ToDevicePortOverrideOutput() DevicePortOverrideOutput {
	return i.ToDevicePortOverrideOutputWithContext(context.Background())
}

func (i DevicePortOverrideArgs) ToDevicePortOverrideOutputWithContext(ctx context.Context) DevicePortOverrideOutput {
	return pulumi.ToOutputWithContext(ctx, i).(DevicePortOverrideOutput)
}

// DevicePortOverrideArrayInput is an input type that accepts DevicePortOverrideArray and DevicePortOverrideArrayOutput values.
// You can construct a concrete instance of `DevicePortOverrideArrayInput` via:
//
//	DevicePortOverrideArray{ DevicePortOverrideArgs{...} }
type DevicePortOverrideArrayInput interface {
	pulumi.Input

	ToDevicePortOverrideArrayOutput() DevicePortOverrideArrayOutput
	ToDevicePortOverrideArrayOutputWithContext(context.Context) DevicePortOverrideArrayOutput
}

type DevicePortOverrideArray []DevicePortOverrideInput

func (DevicePortOverrideArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]DevicePortOverride)(nil)).Elem()
}

func (i DevicePortOverrideArray) ToDevicePortOverrideArrayOutput() DevicePortOverrideArrayOutput {
	return i.ToDevicePortOverrideArrayOutputWithContext(context.Background())
}

func (i DevicePortOverrideArray) ToDevicePortOverrideArrayOutputWithContext(ctx context.Context) DevicePortOverrideArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(DevicePortOverrideArrayOutput)
}

type DevicePortOverrideOutput struct{ *pulumi.OutputState }

func (DevicePortOverrideOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*DevicePortOverride)(nil)).Elem()
}

func (o DevicePortOverrideOutput) ToDevicePortOverrideOutput() DevicePortOverrideOutput {
	return o
}

func (o DevicePortOverrideOutput) ToDevicePortOverrideOutputWithContext(ctx context.Context) DevicePortOverrideOutput {
	return o
}

// Human-readable name of the port.
func (o DevicePortOverrideOutput) Name() pulumi.StringPtrOutput {
	return o.ApplyT(func(v DevicePortOverride) *string { return v.Name }).(pulumi.StringPtrOutput)
}

// Switch port number.
func (o DevicePortOverrideOutput) Number() pulumi.IntOutput {
	return o.ApplyT(func(v DevicePortOverride) int { return v.Number }).(pulumi.IntOutput)
}

// ID of the Port Profile used on this port.
func (o DevicePortOverrideOutput) PortProfileId() pulumi.StringPtrOutput {
	return o.ApplyT(func(v DevicePortOverride) *string { return v.PortProfileId }).(pulumi.StringPtrOutput)
}

type DevicePortOverrideArrayOutput struct{ *pulumi.OutputState }

func (DevicePortOverrideArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]DevicePortOverride)(nil)).Elem()
}

func (o DevicePortOverrideArrayOutput) ToDevicePortOverrideArrayOutput() DevicePortOverrideArrayOutput {
	return o
}

func (o DevicePortOverrideArrayOutput) ToDevicePortOverrideArrayOutputWithContext(ctx context.Context) DevicePortOverrideArrayOutput {
	return o
}

func (o DevicePortOverrideArrayOutput) Index(i pulumi.IntInput) DevicePortOverrideOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) DevicePortOverride {
		return vs[0].([]DevicePortOverride)[vs[1].(int)]
	}).(DevicePortOverrideOutput)
}

type WlanSchedule struct {
	// Time of day to end the block.
	BlockEnd string `pulumi:"blockEnd"`
	// Time of day to start the block.
	BlockStart string `pulumi:"blockStart"`
	// Day of week for the block. Valid values are `sun`, `mon`, `tue`, `wed`, `thu`, `fri`, `sat`.
	DayOfWeek string `pulumi:"dayOfWeek"`
}

// WlanScheduleInput is an input type that accepts WlanScheduleArgs and WlanScheduleOutput values.
// You can construct a concrete instance of `WlanScheduleInput` via:
//
//	WlanScheduleArgs{...}
type WlanScheduleInput interface {
	pulumi.Input

	ToWlanScheduleOutput() WlanScheduleOutput
	ToWlanScheduleOutputWithContext(context.Context) WlanScheduleOutput
}

type WlanScheduleArgs struct {
	// Time of day to end the block.
	BlockEnd pulumi.StringInput `pulumi:"blockEnd"`
	// Time of day to start the block.
	BlockStart pulumi.StringInput `pulumi:"blockStart"`
	// Day of week for the block. Valid values are `sun`, `mon`, `tue`, `wed`, `thu`, `fri`, `sat`.
	DayOfWeek pulumi.StringInput `pulumi:"dayOfWeek"`
}

func (WlanScheduleArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*WlanSchedule)(nil)).Elem()
}

func (i WlanScheduleArgs) ToWlanScheduleOutput() WlanScheduleOutput {
	return i.ToWlanScheduleOutputWithContext(context.Background())
}

func (i WlanScheduleArgs) ToWlanScheduleOutputWithContext(ctx context.Context) WlanScheduleOutput {
	return pulumi.ToOutputWithContext(ctx, i).(WlanScheduleOutput)
}

// WlanScheduleArrayInput is an input type that accepts WlanScheduleArray and WlanScheduleArrayOutput values.
// You can construct a concrete instance of `WlanScheduleArrayInput` via:
//
//	WlanScheduleArray{ WlanScheduleArgs{...} }
type WlanScheduleArrayInput interface {
	pulumi.Input

	ToWlanScheduleArrayOutput() WlanScheduleArrayOutput
	ToWlanScheduleArrayOutputWithContext(context.Context) WlanScheduleArrayOutput
}

type WlanScheduleArray []WlanScheduleInput

func (WlanScheduleArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]WlanSchedule)(nil)).Elem()
}

func (i WlanScheduleArray) ToWlanScheduleArrayOutput() WlanScheduleArrayOutput {
	return i.ToWlanScheduleArrayOutputWithContext(context.Background())
}

func (i WlanScheduleArray) ToWlanScheduleArrayOutputWithContext(ctx context.Context) WlanScheduleArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(WlanScheduleArrayOutput)
}

type WlanScheduleOutput struct{ *pulumi.OutputState }

func (WlanScheduleOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*WlanSchedule)(nil)).Elem()
}

func (o WlanScheduleOutput) ToWlanScheduleOutput() WlanScheduleOutput {
	return o
}

func (o WlanScheduleOutput) ToWlanScheduleOutputWithContext(ctx context.Context) WlanScheduleOutput {
	return o
}

// Time of day to end the block.
func (o WlanScheduleOutput) BlockEnd() pulumi.StringOutput {
	return o.ApplyT(func(v WlanSchedule) string { return v.BlockEnd }).(pulumi.StringOutput)
}

// Time of day to start the block.
func (o WlanScheduleOutput) BlockStart() pulumi.StringOutput {
	return o.ApplyT(func(v WlanSchedule) string { return v.BlockStart }).(pulumi.StringOutput)
}

// Day of week for the block. Valid values are `sun`, `mon`, `tue`, `wed`, `thu`, `fri`, `sat`.
func (o WlanScheduleOutput) DayOfWeek() pulumi.StringOutput {
	return o.ApplyT(func(v WlanSchedule) string { return v.DayOfWeek }).(pulumi.StringOutput)
}

type WlanScheduleArrayOutput struct{ *pulumi.OutputState }

func (WlanScheduleArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]WlanSchedule)(nil)).Elem()
}

func (o WlanScheduleArrayOutput) ToWlanScheduleArrayOutput() WlanScheduleArrayOutput {
	return o
}

func (o WlanScheduleArrayOutput) ToWlanScheduleArrayOutputWithContext(ctx context.Context) WlanScheduleArrayOutput {
	return o
}

func (o WlanScheduleArrayOutput) Index(i pulumi.IntInput) WlanScheduleOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) WlanSchedule {
		return vs[0].([]WlanSchedule)[vs[1].(int)]
	}).(WlanScheduleOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*DevicePortOverrideInput)(nil)).Elem(), DevicePortOverrideArgs{})
	pulumi.RegisterInputType(reflect.TypeOf((*DevicePortOverrideArrayInput)(nil)).Elem(), DevicePortOverrideArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*WlanScheduleInput)(nil)).Elem(), WlanScheduleArgs{})
	pulumi.RegisterInputType(reflect.TypeOf((*WlanScheduleArrayInput)(nil)).Elem(), WlanScheduleArray{})
	pulumi.RegisterOutputType(DevicePortOverrideOutput{})
	pulumi.RegisterOutputType(DevicePortOverrideArrayOutput{})
	pulumi.RegisterOutputType(WlanScheduleOutput{})
	pulumi.RegisterOutputType(WlanScheduleArrayOutput{})
}
