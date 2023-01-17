// Namespace: System
[ComVisibleAttribute] // RVA: 0x471290 Offset: 0x471391 VA: 0x471290
[CLSCompliantAttribute] // RVA: 0x471290 Offset: 0x471391 VA: 0x471290
[Serializable]
public struct UIntPtr : ISerializable // TypeDefIndex: 418
{
	// Fields
	public static readonly UIntPtr Zero; // 0x0
	private void* _pointer; // 0x0

	// Properties
	public static int Size { get; }

	// Methods

	// RVA: 0x3648870 Offset: 0x3648971 VA: 0x3648870
	public void .ctor(uint value) { }

	// RVA: 0x3648880 Offset: 0x3648981 VA: 0x3648880 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x3648910 Offset: 0x3648A11 VA: 0x3648910 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x3648920 Offset: 0x3648A21 VA: 0x3648920 Slot: 3
	public override string ToString() { }

	// RVA: 0x36489B0 Offset: 0x3648AB1 VA: 0x36489B0 Slot: 4
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x3648A60 Offset: 0x3648B61 VA: 0x3648A60
	public static bool op_Equality(UIntPtr value1, UIntPtr value2) { }

	// RVA: 0x36489A0 Offset: 0x3648AA1 VA: 0x36489A0
	public static int get_Size() { }

	// RVA: 0x3648A70 Offset: 0x3648B71 VA: 0x3648A70
	private static void .cctor() { }
}

