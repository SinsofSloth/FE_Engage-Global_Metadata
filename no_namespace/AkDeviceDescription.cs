// Namespace: 
public class AkDeviceDescription : IDisposable // TypeDefIndex: 7843
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public uint idDevice { get; set; }
	public string deviceName { get; set; }
	public AkAudioDeviceState deviceStateMask { get; set; }
	public bool isDefaultDevice { get; set; }

	// Methods

	// RVA: 0x316E060 Offset: 0x316E161 VA: 0x316E060
	internal void .ctor(IntPtr cPtr, bool cMemoryOwn) { }

	// RVA: 0x316E0A0 Offset: 0x316E1A1 VA: 0x316E0A0
	internal static IntPtr getCPtr(AkDeviceDescription obj) { }

	// RVA: 0x316E100 Offset: 0x316E201 VA: 0x316E100 Slot: 5
	internal virtual void setCPtr(IntPtr cPtr) { }

	// RVA: 0x316E130 Offset: 0x316E231 VA: 0x316E130 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x316E1A0 Offset: 0x316E2A1 VA: 0x316E1A0 Slot: 6
	public virtual void Dispose() { }

	// RVA: 0x316E330 Offset: 0x316E431 VA: 0x316E330
	public void set_idDevice(uint value) { }

	// RVA: 0x316E3B0 Offset: 0x316E4B1 VA: 0x316E3B0
	public uint get_idDevice() { }

	// RVA: 0x316E420 Offset: 0x316E521 VA: 0x316E420
	public void set_deviceName(string value) { }

	// RVA: 0x316E4A0 Offset: 0x316E5A1 VA: 0x316E4A0
	public string get_deviceName() { }

	// RVA: 0x316E550 Offset: 0x316E651 VA: 0x316E550
	public void set_deviceStateMask(AkAudioDeviceState value) { }

	// RVA: 0x316E5D0 Offset: 0x316E6D1 VA: 0x316E5D0
	public AkAudioDeviceState get_deviceStateMask() { }

	// RVA: 0x316E640 Offset: 0x316E741 VA: 0x316E640
	public void set_isDefaultDevice(bool value) { }

	// RVA: 0x316E6C0 Offset: 0x316E7C1 VA: 0x316E6C0
	public bool get_isDefaultDevice() { }

	// RVA: 0x316E730 Offset: 0x316E831 VA: 0x316E730
	public void Clear() { }

	// RVA: 0x316E7A0 Offset: 0x316E8A1 VA: 0x316E7A0
	public static int GetSizeOf() { }

	// RVA: 0x316E810 Offset: 0x316E911 VA: 0x316E810
	public void Clone(AkDeviceDescription other) { }

	// RVA: 0x316E8D0 Offset: 0x316E9D1 VA: 0x316E8D0
	public void .ctor() { }
}

