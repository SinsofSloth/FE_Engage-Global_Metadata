// Namespace: System.Reflection
[ComVisibleAttribute] // RVA: 0x472080 Offset: 0x472181 VA: 0x472080
[CLSCompliantAttribute] // RVA: 0x472080 Offset: 0x472181 VA: 0x472080
[Serializable]
public sealed class Pointer : ISerializable // TypeDefIndex: 544
{
	// Fields
	private void* _ptr; // 0x10
	private RuntimeType _ptrType; // 0x18

	// Methods

	// RVA: 0x3821B50 Offset: 0x3821C51 VA: 0x3821B50
	private void .ctor() { }

	// RVA: 0x3821B60 Offset: 0x3821C61 VA: 0x3821B60
	private void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x3821D10 Offset: 0x3821E11 VA: 0x3821D10
	public static object Box(void* ptr, Type type) { }

	// RVA: 0x3821F10 Offset: 0x3822011 VA: 0x3821F10 Slot: 4
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }
}

