// Namespace: System.Runtime.Serialization
[ComVisibleAttribute] // RVA: 0x4747E0 Offset: 0x4748E1 VA: 0x4747E0
[Serializable]
public struct StreamingContext // TypeDefIndex: 1024
{
	// Fields
	internal object m_additionalContext; // 0x0
	internal StreamingContextStates m_state; // 0x8

	// Properties
	public StreamingContextStates State { get; }

	// Methods

	// RVA: 0x38368B0 Offset: 0x38369B1 VA: 0x38368B0
	public void .ctor(StreamingContextStates state) { }

	// RVA: 0x38368C0 Offset: 0x38369C1 VA: 0x38368C0
	public void .ctor(StreamingContextStates state, object additional) { }

	// RVA: 0x38368D0 Offset: 0x38369D1 VA: 0x38368D0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x38369A0 Offset: 0x3836AA1 VA: 0x38369A0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x38369B0 Offset: 0x3836AB1 VA: 0x38369B0
	public StreamingContextStates get_State() { }
}

