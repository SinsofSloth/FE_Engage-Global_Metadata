// Namespace: System
[ComVisibleAttribute] // RVA: 0x470610 Offset: 0x470711 VA: 0x470610
[Serializable]
public class MissingMethodException : MissingMemberException, ISerializable // TypeDefIndex: 275
{
	// Fields
	private string signature; // 0xA0

	// Properties
	public override string Message { get; }

	// Methods

	// RVA: 0x34F24D0 Offset: 0x34F25D1 VA: 0x34F24D0
	public void .ctor() { }

	// RVA: 0x34F2570 Offset: 0x34F2671 VA: 0x34F2570
	public void .ctor(string message) { }

	// RVA: 0x34F25D0 Offset: 0x34F26D1 VA: 0x34F25D0
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x34F25E0 Offset: 0x34F26E1 VA: 0x34F25E0 Slot: 5
	public override string get_Message() { }

	// RVA: 0x34F26F0 Offset: 0x34F27F1 VA: 0x34F26F0
	public void .ctor(string className, string methodName) { }

	// RVA: 0x34F27B0 Offset: 0x34F28B1 VA: 0x34F27B0
	private void .ctor(string className, string methodName, string signature, string message) { }
}

