// Namespace: System
[ComVisibleAttribute] // RVA: 0x46FC80 Offset: 0x46FD81 VA: 0x46FC80
[Serializable]
public class ArgumentException : SystemException, ISerializable // TypeDefIndex: 165
{
	// Fields
	private string m_paramName; // 0x88

	// Properties
	public override string Message { get; }

	// Methods

	// RVA: 0x355F1B0 Offset: 0x355F2B1 VA: 0x355F1B0
	public void .ctor() { }

	// RVA: 0x3556390 Offset: 0x3556491 VA: 0x3556390
	public void .ctor(string message) { }

	// RVA: 0x355F230 Offset: 0x355F331 VA: 0x355F230
	public void .ctor(string message, Exception innerException) { }

	// RVA: 0x3554A50 Offset: 0x3554B51 VA: 0x3554A50
	public void .ctor(string message, string paramName) { }

	// RVA: 0x355F270 Offset: 0x355F371 VA: 0x355F270
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x355F310 Offset: 0x355F411 VA: 0x355F310 Slot: 5
	public override string get_Message() { }

	// RVA: 0x355F430 Offset: 0x355F531 VA: 0x355F430 Slot: 15
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }
}

