// Namespace: System
[ComVisibleAttribute] // RVA: 0x4712D0 Offset: 0x4713D1 VA: 0x4712D0
[Serializable]
public abstract class ValueType // TypeDefIndex: 419
{
	// Methods

	// RVA: 0x34CD890 Offset: 0x34CD991 VA: 0x34CD890
	protected void .ctor() { }

	// RVA: 0x34CD8A0 Offset: 0x34CD9A1 VA: 0x34CD8A0
	private static bool InternalEquals(object o1, object o2, out object[] fields) { }

	// RVA: 0x34CD8B0 Offset: 0x34CD9B1 VA: 0x34CD8B0
	internal static bool DefaultEquals(object o1, object o2) { }

	// RVA: 0x34CDA90 Offset: 0x34CDB91 VA: 0x34CDA90 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x34CDAA0 Offset: 0x34CDBA1 VA: 0x34CDAA0
	internal static int InternalGetHashCode(object o, out object[] fields) { }

	// RVA: 0x34CDAB0 Offset: 0x34CDBB1 VA: 0x34CDAB0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x34CDB50 Offset: 0x34CDC51 VA: 0x34CDB50 Slot: 3
	public override string ToString() { }
}

