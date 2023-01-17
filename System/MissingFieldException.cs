// Namespace: System
[ComVisibleAttribute] // RVA: 0x4705D0 Offset: 0x4706D1 VA: 0x4705D0
[Serializable]
public class MissingFieldException : MissingMemberException, ISerializable // TypeDefIndex: 273
{
	// Properties
	public override string Message { get; }

	// Methods

	// RVA: 0x34F1B30 Offset: 0x34F1C31 VA: 0x34F1B30
	public void .ctor() { }

	// RVA: 0x34F1C20 Offset: 0x34F1D21 VA: 0x34F1C20
	public void .ctor(string message) { }

	// RVA: 0x34F1C80 Offset: 0x34F1D81 VA: 0x34F1C80
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x34F1E30 Offset: 0x34F1F31 VA: 0x34F1E30 Slot: 5
	public override string get_Message() { }

	// RVA: 0x34F2120 Offset: 0x34F2221 VA: 0x34F2120
	public void .ctor(string className, string fieldName) { }
}

