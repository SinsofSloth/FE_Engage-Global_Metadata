// Namespace: UnityEngine
[StaticAccessorAttribute] // RVA: 0x43C6C0 Offset: 0x43C7C1 VA: 0x43C6C0
[NativeHeaderAttribute] // RVA: 0x43C6C0 Offset: 0x43C7C1 VA: 0x43C6C0
public sealed class LightmapSettings : Object // TypeDefIndex: 3448
{
	// Properties
	public static LightmapData[] lightmaps { get; set; }
	public static LightmapsMode lightmapsMode { get; set; }
	public static LightProbes lightProbes { get; set; }
	[ObsoleteAttribute] // RVA: 0x4596C0 Offset: 0x4597C1 VA: 0x4596C0
	public static LightmapsModeLegacy lightmapsModeLegacy { get; set; }
	[ObsoleteAttribute] // RVA: 0x459700 Offset: 0x459801 VA: 0x459700
	public static ColorSpace bakedColorSpace { get; set; }

	// Methods

	// RVA: 0x2F2A890 Offset: 0x2F2A991 VA: 0x2F2A890
	private void .ctor() { }

	[FreeFunctionAttribute] // RVA: 0x4478B0 Offset: 0x4479B1 VA: 0x4478B0
	// RVA: 0x2F2A900 Offset: 0x2F2AA01 VA: 0x2F2A900
	public static LightmapData[] get_lightmaps() { }

	[FreeFunctionAttribute] // RVA: 0x4478C0 Offset: 0x4479C1 VA: 0x4478C0
	// RVA: 0x2F2A940 Offset: 0x2F2AA41 VA: 0x2F2A940
	public static void set_lightmaps(LightmapData[] value) { }

	// RVA: 0x2F2A990 Offset: 0x2F2AA91 VA: 0x2F2A990
	public static LightmapsMode get_lightmapsMode() { }

	[FreeFunctionAttribute] // RVA: 0x447900 Offset: 0x447A01 VA: 0x447900
	// RVA: 0x2F2A9D0 Offset: 0x2F2AAD1 VA: 0x2F2A9D0
	public static void set_lightmapsMode(LightmapsMode value) { }

	// RVA: 0x2F2AA20 Offset: 0x2F2AB21 VA: 0x2F2AA20
	public static LightProbes get_lightProbes() { }

	[NativeNameAttribute] // RVA: 0x447940 Offset: 0x447A41 VA: 0x447940
	[FreeFunctionAttribute] // RVA: 0x447940 Offset: 0x447A41 VA: 0x447940
	// RVA: 0x2F2AA60 Offset: 0x2F2AB61 VA: 0x2F2AA60
	public static void set_lightProbes(LightProbes value) { }

	[NativeNameAttribute] // RVA: 0x447990 Offset: 0x447A91 VA: 0x447990
	// RVA: 0x2F2AAB0 Offset: 0x2F2ABB1 VA: 0x2F2AAB0
	internal static void Reset() { }

	// RVA: 0x2F2AAF0 Offset: 0x2F2ABF1 VA: 0x2F2AAF0
	public static LightmapsModeLegacy get_lightmapsModeLegacy() { }

	// RVA: 0x2F2AB00 Offset: 0x2F2AC01 VA: 0x2F2AB00
	public static void set_lightmapsModeLegacy(LightmapsModeLegacy value) { }

	// RVA: 0x2F2AB10 Offset: 0x2F2AC11 VA: 0x2F2AB10
	public static ColorSpace get_bakedColorSpace() { }

	// RVA: 0x2F2AB20 Offset: 0x2F2AC21 VA: 0x2F2AB20
	public static void set_bakedColorSpace(ColorSpace value) { }
}

