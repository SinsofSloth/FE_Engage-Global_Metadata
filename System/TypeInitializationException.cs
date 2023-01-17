// Namespace: System
[ComVisibleAttribute] // RVA: 0x470D80 Offset: 0x470E81 VA: 0x470D80
[Serializable]
public sealed class TypeInitializationException : SystemException // TypeDefIndex: 327
{
	// Fields
	private string _typeName; // 0x88

	// Properties
	public string TypeName { get; }

	// Methods

	// RVA: 0x3642EE0 Offset: 0x3642FE1 VA: 0x3642EE0
	private void .ctor() { }

	// RVA: 0x3642F60 Offset: 0x3643061 VA: 0x3642F60
	public void .ctor(string fullTypeName, Exception innerException) { }

	// RVA: 0x3643070 Offset: 0x3643171 VA: 0x3643070
	internal void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x3643110 Offset: 0x3643211 VA: 0x3643110
	public string get_TypeName() { }

	// RVA: 0x3643180 Offset: 0x3643281 VA: 0x3643180 Slot: 15
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }
}

