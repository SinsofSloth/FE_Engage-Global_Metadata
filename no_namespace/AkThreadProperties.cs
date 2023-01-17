// Namespace: 
public class AkThreadProperties : IDisposable // TypeDefIndex: 7913
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public int nPriority { get; set; }
	public uint uStackSize { get; set; }
	public int iIdealCore { get; set; }
	public uint affinityMask { get; set; }

	// Methods

	// RVA: 0x20DA130 Offset: 0x20DA231 VA: 0x20DA130
	internal void .ctor(IntPtr cPtr, bool cMemoryOwn) { }

	// RVA: 0x20C8A90 Offset: 0x20C8B91 VA: 0x20C8A90
	internal static IntPtr getCPtr(AkThreadProperties obj) { }

	// RVA: 0x20DA170 Offset: 0x20DA271 VA: 0x20DA170 Slot: 5
	internal virtual void setCPtr(IntPtr cPtr) { }

	// RVA: 0x20DA1A0 Offset: 0x20DA2A1 VA: 0x20DA1A0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x20DA210 Offset: 0x20DA311 VA: 0x20DA210 Slot: 6
	public virtual void Dispose() { }

	// RVA: 0x20DA390 Offset: 0x20DA491 VA: 0x20DA390
	public void set_nPriority(int value) { }

	// RVA: 0x20DA410 Offset: 0x20DA511 VA: 0x20DA410
	public int get_nPriority() { }

	// RVA: 0x20DA480 Offset: 0x20DA581 VA: 0x20DA480
	public void set_uStackSize(uint value) { }

	// RVA: 0x20DA500 Offset: 0x20DA601 VA: 0x20DA500
	public uint get_uStackSize() { }

	// RVA: 0x20DA570 Offset: 0x20DA671 VA: 0x20DA570
	public void set_iIdealCore(int value) { }

	// RVA: 0x20DA5F0 Offset: 0x20DA6F1 VA: 0x20DA5F0
	public int get_iIdealCore() { }

	// RVA: 0x20DA660 Offset: 0x20DA761 VA: 0x20DA660
	public void set_affinityMask(uint value) { }

	// RVA: 0x20DA6E0 Offset: 0x20DA7E1 VA: 0x20DA6E0
	public uint get_affinityMask() { }

	// RVA: 0x20DA750 Offset: 0x20DA851 VA: 0x20DA750
	public void .ctor() { }
}

