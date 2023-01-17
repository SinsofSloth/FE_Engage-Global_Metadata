// Namespace: 
public class AkAuxSendValue : IDisposable // TypeDefIndex: 7830
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public ulong listenerID { get; set; }
	public uint auxBusID { get; set; }
	public float fControlValue { get; set; }

	// Methods

	// RVA: 0x2ED0D50 Offset: 0x2ED0E51 VA: 0x2ED0D50
	internal void .ctor(IntPtr cPtr, bool cMemoryOwn) { }

	// RVA: 0x2ED1660 Offset: 0x2ED1761 VA: 0x2ED1660
	internal static IntPtr getCPtr(AkAuxSendValue obj) { }

	// RVA: 0x2ED16C0 Offset: 0x2ED17C1 VA: 0x2ED16C0 Slot: 5
	internal virtual void setCPtr(IntPtr cPtr) { }

	// RVA: 0x2ED16F0 Offset: 0x2ED17F1 VA: 0x2ED16F0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x2ED1760 Offset: 0x2ED1861 VA: 0x2ED1760 Slot: 6
	public virtual void Dispose() { }

	// RVA: 0x2ED18F0 Offset: 0x2ED19F1 VA: 0x2ED18F0
	public void set_listenerID(ulong value) { }

	// RVA: 0x2ED1970 Offset: 0x2ED1A71 VA: 0x2ED1970
	public ulong get_listenerID() { }

	// RVA: 0x2ED19E0 Offset: 0x2ED1AE1 VA: 0x2ED19E0
	public void set_auxBusID(uint value) { }

	// RVA: 0x2ED1A60 Offset: 0x2ED1B61 VA: 0x2ED1A60
	public uint get_auxBusID() { }

	// RVA: 0x2ED1AD0 Offset: 0x2ED1BD1 VA: 0x2ED1AD0
	public void set_fControlValue(float value) { }

	// RVA: 0x2ED1B50 Offset: 0x2ED1C51 VA: 0x2ED1B50
	public float get_fControlValue() { }

	// RVA: 0x2ED1BC0 Offset: 0x2ED1CC1 VA: 0x2ED1BC0
	public void Set(GameObject listener, uint id, float value) { }

	// RVA: 0x2ED1CB0 Offset: 0x2ED1DB1 VA: 0x2ED1CB0
	public bool IsSame(GameObject listener, uint id) { }

	// RVA: 0x2ED1D90 Offset: 0x2ED1E91 VA: 0x2ED1D90
	public static int GetSizeOf() { }
}

