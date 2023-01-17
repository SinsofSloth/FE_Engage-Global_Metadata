// Namespace: System.IO
[ComVisibleAttribute] // RVA: 0x472A40 Offset: 0x472B41 VA: 0x472A40
[Serializable]
public sealed class FileInfo : FileSystemInfo // TypeDefIndex: 621
{
	// Fields
	private string _name; // 0x60

	// Properties
	public override string Name { get; }
	public string DirectoryName { get; }
	public DirectoryInfo Directory { get; }
	public override bool Exists { get; }

	// Methods

	// RVA: 0x38ADB10 Offset: 0x38ADC11 VA: 0x38ADB10
	public void .ctor(string fileName) { }

	// RVA: 0x38ADC50 Offset: 0x38ADD51 VA: 0x38ADC50
	private void Init(string fileName, bool checkHost) { }

	// RVA: 0x38ADD10 Offset: 0x38ADE11 VA: 0x38ADD10
	private string GetDisplayPath(string originalPath) { }

	// RVA: 0x38ADD20 Offset: 0x38ADE21 VA: 0x38ADD20
	private void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x38ADF30 Offset: 0x38AE031 VA: 0x38ADF30 Slot: 8
	public override string get_Name() { }

	// RVA: 0x38ADF40 Offset: 0x38AE041 VA: 0x38ADF40
	public string get_DirectoryName() { }

	// RVA: 0x38ADFB0 Offset: 0x38AE0B1 VA: 0x38ADFB0
	public DirectoryInfo get_Directory() { }

	// RVA: 0x38AE090 Offset: 0x38AE191 VA: 0x38AE090 Slot: 9
	public override bool get_Exists() { }

	// RVA: 0x38AE2F0 Offset: 0x38AE3F1 VA: 0x38AE2F0 Slot: 3
	public override string ToString() { }
}

