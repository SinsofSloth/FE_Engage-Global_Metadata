// Namespace: System.Runtime.Serialization
[ComVisibleAttribute] // RVA: 0x474570 Offset: 0x474671 VA: 0x474570
[Serializable]
public class ObjectIDGenerator // TypeDefIndex: 998
{
	// Fields
	internal int m_currentCount; // 0x10
	internal int m_currentSize; // 0x14
	internal long[] m_ids; // 0x18
	internal object[] m_objs; // 0x20
	private static readonly int[] sizes; // 0x0

	// Methods

	// RVA: 0x3865240 Offset: 0x3865341 VA: 0x3865240
	public void .ctor() { }

	// RVA: 0x3865340 Offset: 0x3865441 VA: 0x3865340
	private int FindElement(object obj, out bool found) { }

	// RVA: 0x3865480 Offset: 0x3865581 VA: 0x3865480 Slot: 4
	public virtual long GetId(object obj, out bool firstTime) { }

	// RVA: 0x3865B30 Offset: 0x3865C31 VA: 0x3865B30 Slot: 5
	public virtual long HasId(object obj, out bool firstTime) { }

	// RVA: 0x3865720 Offset: 0x3865821 VA: 0x3865720
	private void Rehash() { }

	// RVA: 0x3865D00 Offset: 0x3865E01 VA: 0x3865D00
	private static void .cctor() { }
}

