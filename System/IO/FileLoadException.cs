// Namespace: System.IO
[ComVisibleAttribute] // RVA: 0x472A60 Offset: 0x472B61 VA: 0x472A60
[Serializable]
public class FileLoadException : IOException // TypeDefIndex: 622
{
	// Fields
	private string _fileName; // 0x90
	private string _fusionLog; // 0x98

	// Properties
	public override string Message { get; }
	public string FusionLog { get; }

	// Methods

	// RVA: 0x38AE300 Offset: 0x38AE401 VA: 0x38AE300
	public void .ctor() { }

	// RVA: 0x38AE380 Offset: 0x38AE481 VA: 0x38AE380
	public void .ctor(string message) { }

	// RVA: 0x38AE3C0 Offset: 0x38AE4C1 VA: 0x38AE3C0 Slot: 5
	public override string get_Message() { }

	// RVA: 0x38AE3F0 Offset: 0x38AE4F1 VA: 0x38AE3F0
	private void SetMessageField() { }

	// RVA: 0x38AE540 Offset: 0x38AE641 VA: 0x38AE540 Slot: 3
	public override string ToString() { }

	// RVA: 0x38AE830 Offset: 0x38AE931 VA: 0x38AE830
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x38AE9A0 Offset: 0x38AEAA1 VA: 0x38AE9A0
	public string get_FusionLog() { }

	// RVA: 0x38AE9B0 Offset: 0x38AEAB1 VA: 0x38AE9B0 Slot: 15
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x38AE4B0 Offset: 0x38AE5B1 VA: 0x38AE4B0
	internal static string FormatFileLoadExceptionMessage(string fileName, int hResult) { }
}

