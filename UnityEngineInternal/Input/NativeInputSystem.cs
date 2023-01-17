// Namespace: UnityEngineInternal.Input
[NativeHeaderAttribute] // RVA: 0x7FB40 Offset: 0x7FC41 VA: 0x7FB40
[NativeHeaderAttribute] // RVA: 0x7FB40 Offset: 0x7FC41 VA: 0x7FB40
internal class NativeInputSystem // TypeDefIndex: 7525
{
	// Fields
	public static NativeUpdateCallback onUpdate; // 0x0
	public static Action<NativeInputUpdateType> onBeforeUpdate; // 0x8
	public static Func<NativeInputUpdateType, bool> onShouldRunUpdate; // 0x10
	private static Action<int, string> s_OnDeviceDiscoveredCallback; // 0x18

	// Properties
	internal static bool hasDeviceDiscoveredCallback { set; }

	// Methods

	// RVA: 0x1C6CE70 Offset: 0x1C6CF71 VA: 0x1C6CE70
	private static void .cctor() { }

	[RequiredByNativeCodeAttribute] // RVA: 0x7FBA0 Offset: 0x7FCA1 VA: 0x7FBA0
	// RVA: 0x1C6CF10 Offset: 0x1C6D011 VA: 0x1C6CF10
	internal static void NotifyBeforeUpdate(NativeInputUpdateType updateType) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x7FBB0 Offset: 0x7FCB1 VA: 0x7FBB0
	// RVA: 0x1C6CFC0 Offset: 0x1C6D0C1 VA: 0x1C6CFC0
	internal static void NotifyUpdate(NativeInputUpdateType updateType, IntPtr eventBuffer) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x7FBC0 Offset: 0x7FCC1 VA: 0x7FBC0
	// RVA: 0x1C6D2D0 Offset: 0x1C6D3D1 VA: 0x1C6D2D0
	internal static void NotifyDeviceDiscovered(int deviceId, string deviceDescriptor) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x7FBD0 Offset: 0x7FCD1 VA: 0x7FBD0
	// RVA: 0x1C6D390 Offset: 0x1C6D491 VA: 0x1C6D390
	internal static void ShouldRunUpdate(NativeInputUpdateType updateType, out bool retval) { }

	// RVA: 0x1C6CEC0 Offset: 0x1C6CFC1 VA: 0x1C6CEC0
	internal static void set_hasDeviceDiscoveredCallback(bool value) { }
}

