// Namespace: System.IO
[ComVisibleAttribute] // RVA: 0x472A80 Offset: 0x472B81 VA: 0x472A80
[Serializable]
public class FileNotFoundException : IOException // TypeDefIndex: 623
{
	// Fields
	private string _fileName; // 0x90
	private string _fusionLog; // 0x98

	// Properties
	public override string Message { get; }
	public string FusionLog { get; }

	// Methods

	// RVA: 0x38AEB80 Offset: 0x38AEC81 VA: 0x38AEB80
	public void .ctor() { }

	// RVA: 0x38AEC00 Offset: 0x38AED01 VA: 0x38AEC00
	public void .ctor(string message) { }

	// RVA: 0x38ACDE0 Offset: 0x38ACEE1 VA: 0x38ACDE0
	public void .ctor(string message, string fileName) { }

	// RVA: 0x38AEC40 Offset: 0x38AED41 VA: 0x38AEC40 Slot: 5
	public override string get_Message() { }

	// RVA: 0x38AEC70 Offset: 0x38AED71 VA: 0x38AEC70
	private void SetMessageField() { }

	// RVA: 0x38AED80 Offset: 0x38AEE81 VA: 0x38AED80 Slot: 3
	public override string ToString() { }

	// RVA: 0x38AF070 Offset: 0x38AF171 VA: 0x38AF070
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x38AF1E0 Offset: 0x38AF2E1 VA: 0x38AF1E0
	public string get_FusionLog() { }

	// RVA: 0x38AF1F0 Offset: 0x38AF2F1 VA: 0x38AF1F0 Slot: 15
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }
}

