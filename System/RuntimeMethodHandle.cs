// Namespace: System
[ComVisibleAttribute] // RVA: 0x4711E0 Offset: 0x4712E1 VA: 0x4711E0
[Serializable]
public struct RuntimeMethodHandle : ISerializable // TypeDefIndex: 392
{
	// Fields
	private IntPtr value; // 0x0

	// Properties
	public IntPtr Value { get; }

	// Methods

	// RVA: 0x322D2A0 Offset: 0x322D3A1 VA: 0x322D2A0
	internal void .ctor(IntPtr v) { }

	// RVA: 0x322D2B0 Offset: 0x322D3B1 VA: 0x322D2B0
	private void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x322D480 Offset: 0x322D581 VA: 0x322D480
	public IntPtr get_Value() { }

	// RVA: 0x322D490 Offset: 0x322D591 VA: 0x322D490 Slot: 4
	public void GetObjectData(SerializationInfo info, StreamingContext context) { }

	[ReliabilityContractAttribute] // RVA: 0x47B260 Offset: 0x47B361 VA: 0x47B260
	// RVA: 0x322D650 Offset: 0x322D751 VA: 0x322D650 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x322D770 Offset: 0x322D871 VA: 0x322D770 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x322D780 Offset: 0x322D881 VA: 0x322D780
	internal static string ConstructInstantiation(RuntimeMethodInfo method, TypeNameFormatFlags format) { }

	// RVA: 0x322D8E0 Offset: 0x322D9E1 VA: 0x322D8E0
	internal bool IsNullHandle() { }
}

