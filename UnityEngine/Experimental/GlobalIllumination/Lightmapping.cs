// Namespace: UnityEngine.Experimental.GlobalIllumination
public static class Lightmapping // TypeDefIndex: 4020
{
	// Fields
	[RequiredByNativeCodeAttribute] // RVA: 0x4456B0 Offset: 0x4457B1 VA: 0x4456B0
	private static readonly Lightmapping.RequestLightsDelegate s_DefaultDelegate; // 0x0
	[RequiredByNativeCodeAttribute] // RVA: 0x4456C0 Offset: 0x4457C1 VA: 0x4456C0
	private static Lightmapping.RequestLightsDelegate s_RequestLightsDelegate; // 0x8

	// Methods

	[RequiredByNativeCodeAttribute] // RVA: 0x4558A0 Offset: 0x4559A1 VA: 0x4558A0
	// RVA: 0x2F2C1E0 Offset: 0x2F2C2E1 VA: 0x2F2C1E0
	public static void SetDelegate(Lightmapping.RequestLightsDelegate del) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x4558B0 Offset: 0x4559B1 VA: 0x4558B0
	// RVA: 0x2F2C290 Offset: 0x2F2C391 VA: 0x2F2C290
	public static Lightmapping.RequestLightsDelegate GetDelegate() { }

	[RequiredByNativeCodeAttribute] // RVA: 0x4558C0 Offset: 0x4559C1 VA: 0x4558C0
	// RVA: 0x2F2C300 Offset: 0x2F2C401 VA: 0x2F2C300
	public static void ResetDelegate() { }

	[RequiredByNativeCodeAttribute] // RVA: 0x4558D0 Offset: 0x4559D1 VA: 0x4558D0
	// RVA: 0x2F2C370 Offset: 0x2F2C471 VA: 0x2F2C370
	internal static void RequestLights(Light[] lights, IntPtr outLightsPtr, int outLightsCount) { }

	// RVA: 0x2F2C440 Offset: 0x2F2C541 VA: 0x2F2C440
	private static void .cctor() { }
}

