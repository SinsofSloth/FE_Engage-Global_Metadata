// Namespace: System.IO
internal class CStreamWriter : StreamWriter // TypeDefIndex: 678
{
	// Fields
	private TermInfoDriver driver; // 0x68

	// Methods

	// RVA: 0x35126D0 Offset: 0x35127D1 VA: 0x35126D0
	public void .ctor(Stream stream, Encoding encoding, bool leaveOpen) { }

	// RVA: 0x3512810 Offset: 0x3512911 VA: 0x3512810 Slot: 14
	public override void Write(char[] buffer, int index, int count) { }

	// RVA: 0x3512BB0 Offset: 0x3512CB1 VA: 0x3512BB0 Slot: 12
	public override void Write(char val) { }

	// RVA: 0x3512DE0 Offset: 0x3512EE1 VA: 0x3512DE0
	public void InternalWriteString(string val) { }

	// RVA: 0x3512D40 Offset: 0x3512E41 VA: 0x3512D40
	public void InternalWriteChar(char val) { }

	// RVA: 0x3512E80 Offset: 0x3512F81 VA: 0x3512E80
	public void InternalWriteChars(char[] buffer, int n) { }

	// RVA: 0x3512F20 Offset: 0x3513021 VA: 0x3512F20 Slot: 13
	public override void Write(char[] val) { }

	// RVA: 0x3512F40 Offset: 0x3513041 VA: 0x3512F40 Slot: 15
	public override void Write(string val) { }
}

