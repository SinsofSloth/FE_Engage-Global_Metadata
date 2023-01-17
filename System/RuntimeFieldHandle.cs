// Namespace: System
[ComVisibleAttribute] // RVA: 0x4711C0 Offset: 0x4712C1 VA: 0x4711C0
[Serializable]
public struct RuntimeFieldHandle : ISerializable // TypeDefIndex: 391
{
	// Fields
	private IntPtr value; // 0x0

	// Properties
	public IntPtr Value { get; }

	// Methods

	// RVA: 0x322C380 Offset: 0x322C481 VA: 0x322C380
	internal void .ctor(IntPtr v) { }

	// RVA: 0x322C390 Offset: 0x322C491 VA: 0x322C390
	private void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x322C560 Offset: 0x322C661 VA: 0x322C560
	public IntPtr get_Value() { }

	// RVA: 0x322C570 Offset: 0x322C671 VA: 0x322C570 Slot: 4
	public void GetObjectData(SerializationInfo info, StreamingContext context) { }

	[ReliabilityContractAttribute] // RVA: 0x47B240 Offset: 0x47B341 VA: 0x47B240
	// RVA: 0x322C730 Offset: 0x322C831 VA: 0x322C730 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x322C850 Offset: 0x322C951 VA: 0x322C850 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x322C860 Offset: 0x322C961 VA: 0x322C860
	private static void SetValueInternal(FieldInfo fi, object obj, object value) { }

	// RVA: 0x322B370 Offset: 0x322B471 VA: 0x322B370
	internal static void SetValue(RtFieldInfo field, object obj, object value, RuntimeType fieldType, FieldAttributes fieldAttr, RuntimeType declaringType, ref bool domainInitialized) { }

	// RVA: 0x322B4F0 Offset: 0x322B5F1 VA: 0x322B4F0
	internal static void SetValueDirect(RtFieldInfo field, RuntimeType fieldType, void* pTypedRef, object value, RuntimeType contextType) { }
}

