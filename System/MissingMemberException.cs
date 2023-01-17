// Namespace: System
[ComVisibleAttribute] // RVA: 0x4705F0 Offset: 0x4706F1 VA: 0x4705F0
[Serializable]
public class MissingMemberException : MemberAccessException, ISerializable // TypeDefIndex: 274
{
	// Fields
	protected string ClassName; // 0x88
	protected string MemberName; // 0x90
	protected byte[] Signature; // 0x98

	// Properties
	public override string Message { get; }

	// Methods

	// RVA: 0x34F21E0 Offset: 0x34F22E1 VA: 0x34F21E0
	public void .ctor() { }

	// RVA: 0x34F1BD0 Offset: 0x34F1CD1 VA: 0x34F1BD0
	public void .ctor(string message) { }

	// RVA: 0x34F1C90 Offset: 0x34F1D91 VA: 0x34F1C90
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x34F1F90 Offset: 0x34F2091 VA: 0x34F1F90 Slot: 5
	public override string get_Message() { }

	// RVA: 0x34F2110 Offset: 0x34F2211 VA: 0x34F2110
	internal static string FormatSignature(byte[] signature) { }

	// RVA: 0x34F2300 Offset: 0x34F2401 VA: 0x34F2300 Slot: 15
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }
}

