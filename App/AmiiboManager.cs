// Namespace: App
public class AmiiboManager : SingletonClass<AmiiboManager> // TypeDefIndex: 10394
{
	// Fields
	public const int DeviceCountMax = 9;
	[CompilerGeneratedAttribute] // RVA: 0x28DFC0 Offset: 0x28E0C1 VA: 0x28DFC0
	private static int <ReceiveCountMax>k__BackingField; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x28DFD0 Offset: 0x28E0D1 VA: 0x28DFD0
	private static int <ReceiveFEAmiiboCountMax>k__BackingField; // 0x4
	private DeviceHandle[] m_DeviceHandles; // 0x20
	private int m_DeviceCount; // 0x28
	private int m_SelectDeviceIndex; // 0x2C
	private AmiiboManager.Sequence m_Sequence; // 0x30
	private uint m_ActivateEventIndex; // 0x34
	private uint m_DeactivateEventIndex; // 0x38
	private bool m_AttachedEvent; // 0x3C
	private NpadId m_NpadId; // 0x40

	// Properties
	public static int ReceiveCountMax { get; set; }
	public static int ReceiveFEAmiiboCountMax { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2BDE50 Offset: 0x2BDF51 VA: 0x2BDE50
	// RVA: 0x20E6C00 Offset: 0x20E6D01 VA: 0x20E6C00
	public static int get_ReceiveCountMax() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BDE60 Offset: 0x2BDF61 VA: 0x2BDE60
	// RVA: 0x20E6C70 Offset: 0x20E6D71 VA: 0x20E6C70
	public static void set_ReceiveCountMax(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BDE70 Offset: 0x2BDF71 VA: 0x2BDE70
	// RVA: 0x20E6CE0 Offset: 0x20E6DE1 VA: 0x20E6CE0
	public static int get_ReceiveFEAmiiboCountMax() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BDE80 Offset: 0x2BDF81 VA: 0x2BDE80
	// RVA: 0x20E6D50 Offset: 0x20E6E51 VA: 0x20E6D50
	public static void set_ReceiveFEAmiiboCountMax(int value) { }

	// RVA: 0x20E6DC0 Offset: 0x20E6EC1 VA: 0x20E6DC0
	public void InitializeSystem() { }

	// RVA: 0x20E6E40 Offset: 0x20E6F41 VA: 0x20E6E40
	public void FinalizeSystem() { }

	// RVA: 0x20E6FE0 Offset: 0x20E70E1 VA: 0x20E6FE0
	public Result ListNfcDevices() { }

	// RVA: 0x20E7030 Offset: 0x20E7131 VA: 0x20E7030
	public Result AttachEvent() { }

	// RVA: 0x20E6FA0 Offset: 0x20E70A1 VA: 0x20E6FA0
	public void DestroyEvent() { }

	// RVA: 0x20E70E0 Offset: 0x20E71E1 VA: 0x20E70E0
	public Result StartDetection() { }

	// RVA: 0x20E6F50 Offset: 0x20E7051 VA: 0x20E6F50
	public Result StopDetection() { }

	// RVA: 0x20E7130 Offset: 0x20E7231 VA: 0x20E7130
	public Result Mount() { }

	// RVA: 0x20E7180 Offset: 0x20E7281 VA: 0x20E7180
	public Result Unmount() { }

	// RVA: 0x20E71D0 Offset: 0x20E72D1 VA: 0x20E71D0
	public Result ReadTagInfo(out TagInfo outTagInfo) { }

	// RVA: 0x20E7260 Offset: 0x20E7361 VA: 0x20E7260
	public Result ReadAmiiboInfo(out AmiiboManager.AmiiboInfo outAmiiboInfo) { }

	// RVA: 0x20E7340 Offset: 0x20E7441 VA: 0x20E7340
	public bool IsAvailabilityChanged() { }

	// RVA: 0x20E7350 Offset: 0x20E7451 VA: 0x20E7350
	public bool IsActivatedDevice() { }

	// RVA: 0x20E7360 Offset: 0x20E7461 VA: 0x20E7360
	public bool IsDeactivatedDevice() { }

	// RVA: 0x20E7370 Offset: 0x20E7471 VA: 0x20E7370
	public bool SelectDevice(int index) { }

	// RVA: 0x20E73B0 Offset: 0x20E74B1 VA: 0x20E73B0
	public Result SelectDevice(NpadId id) { }

	// RVA: 0x20E7470 Offset: 0x20E7571 VA: 0x20E7470
	public Result SelectControlDevice() { }

	// RVA: 0x20E7530 Offset: 0x20E7631 VA: 0x20E7530
	public int GetSelectDeviceIndex() { }

	// RVA: 0x20E7540 Offset: 0x20E7641 VA: 0x20E7540
	public int GetDeviceCount() { }

	// RVA: 0x20E7550 Offset: 0x20E7651 VA: 0x20E7550
	public State GetNfpState() { }

	// RVA: 0x20E6F00 Offset: 0x20E7001 VA: 0x20E6F00
	public DeviceState GetSelectDeviceState() { }

	// RVA: 0x20E7560 Offset: 0x20E7661 VA: 0x20E7560
	private DeviceHandle GetSelectDeviceHandle() { }

	// RVA: 0x20E75A0 Offset: 0x20E76A1 VA: 0x20E75A0
	public void SetupPad(NpadId npadId) { }

	// RVA: 0x20E75B0 Offset: 0x20E76B1 VA: 0x20E75B0
	public void Dump() { }

	// RVA: 0x20E75C0 Offset: 0x20E76C1 VA: 0x20E75C0
	public void .ctor() { }

	// RVA: 0x20E7650 Offset: 0x20E7751 VA: 0x20E7650
	private static void .cctor() { }
}

