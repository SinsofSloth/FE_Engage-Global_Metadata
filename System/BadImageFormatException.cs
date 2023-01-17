// Namespace: System
[ComVisibleAttribute] // RVA: 0x46FE10 Offset: 0x46FF11 VA: 0x46FE10
[Serializable]
public class BadImageFormatException : SystemException // TypeDefIndex: 176
{
	// Fields
	private string _fileName; // 0x88
	private string _fusionLog; // 0x90

	// Properties
	public override string Message { get; }
	public string FusionLog { get; }

	// Methods

	// RVA: 0x34FFE40 Offset: 0x34FFF41 VA: 0x34FFE40
	public void .ctor() { }

	// RVA: 0x34FFEC0 Offset: 0x34FFFC1 VA: 0x34FFEC0
	public void .ctor(string message) { }

	// RVA: 0x34FFF00 Offset: 0x3500001 VA: 0x34FFF00
	public void .ctor(string message, Exception inner) { }

	// RVA: 0x34FFF40 Offset: 0x3500041 VA: 0x34FFF40
	public void .ctor(string message, string fileName) { }

	// RVA: 0x34FFF90 Offset: 0x3500091 VA: 0x34FFF90 Slot: 5
	public override string get_Message() { }

	// RVA: 0x3500050 Offset: 0x3500151 VA: 0x3500050
	private void SetMessageField() { }

	// RVA: 0x35000F0 Offset: 0x35001F1 VA: 0x35000F0 Slot: 3
	public override string ToString() { }

	// RVA: 0x35003E0 Offset: 0x35004E1 VA: 0x35003E0
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x3500550 Offset: 0x3500651 VA: 0x3500550
	public string get_FusionLog() { }

	// RVA: 0x3500560 Offset: 0x3500661 VA: 0x3500560 Slot: 15
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }
}

