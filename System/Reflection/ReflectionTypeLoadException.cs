// Namespace: System.Reflection
[ComVisibleAttribute] // RVA: 0x472100 Offset: 0x472201 VA: 0x472100
[Serializable]
public sealed class ReflectionTypeLoadException : SystemException, ISerializable // TypeDefIndex: 546
{
	// Fields
	private Type[] _classes; // 0x88
	private Exception[] _exceptions; // 0x90

	// Methods

	// RVA: 0x3B737B0 Offset: 0x3B738B1 VA: 0x3B737B0
	private void .ctor() { }

	// RVA: 0x3B73830 Offset: 0x3B73931 VA: 0x3B73830
	public void .ctor(Type[] classes, Exception[] exceptions) { }

	// RVA: 0x3B738A0 Offset: 0x3B739A1 VA: 0x3B738A0
	internal void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x3B73A60 Offset: 0x3B73B61 VA: 0x3B73A60 Slot: 15
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }
}

