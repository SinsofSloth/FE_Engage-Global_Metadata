// Namespace: 
[DefaultMemberAttribute] // RVA: 0x271E10 Offset: 0x271F11 VA: 0x271E10
public class AkMIDIPostArray // TypeDefIndex: 7968
{
	// Fields
	private readonly int m_Count; // 0x10
	private readonly int SIZE_OF; // 0x14
	private IntPtr m_Buffer; // 0x18

	// Properties
	public AkMIDIPost Item { get; set; }

	// Methods

	// RVA: 0x317DE50 Offset: 0x317DF51 VA: 0x317DE50
	public void .ctor(int size) { }

	// RVA: 0x317DF30 Offset: 0x317E031 VA: 0x317DF30
	public AkMIDIPost get_Item(int index) { }

	// RVA: 0x317E0B0 Offset: 0x317E1B1 VA: 0x317E0B0
	public void set_Item(int index, AkMIDIPost value) { }

	// RVA: 0x317E1D0 Offset: 0x317E2D1 VA: 0x317E1D0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x317E2A0 Offset: 0x317E3A1 VA: 0x317E2A0
	public void PostOnEvent(uint in_eventID, GameObject gameObject) { }

	// RVA: 0x317E380 Offset: 0x317E481 VA: 0x317E380
	public void PostOnEvent(uint in_eventID, GameObject gameObject, int count) { }

	// RVA: 0x317E4B0 Offset: 0x317E5B1 VA: 0x317E4B0
	public IntPtr GetBuffer() { }

	// RVA: 0x317E4C0 Offset: 0x317E5C1 VA: 0x317E4C0
	public int Count() { }

	// RVA: 0x317E070 Offset: 0x317E171 VA: 0x317E070
	private IntPtr GetObjectPtr(int index) { }
}

