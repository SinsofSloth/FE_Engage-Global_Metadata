// Namespace: MoonSharp.Interpreter.CoreLib.IO
internal abstract class StreamFileUserDataBase : FileUserDataBase // TypeDefIndex: 6258
{
	// Fields
	protected Stream m_Stream; // 0x18
	protected StreamReader m_Reader; // 0x20
	protected StreamWriter m_Writer; // 0x28
	protected bool m_Closed; // 0x30

	// Methods

	// RVA: 0x3024670 Offset: 0x3024771 VA: 0x3024670
	protected void Initialize(Stream stream, StreamReader reader, StreamWriter writer) { }

	// RVA: 0x30271A0 Offset: 0x30272A1 VA: 0x30271A0
	private void CheckFileIsNotClosed() { }

	// RVA: 0x3027210 Offset: 0x3027311 VA: 0x3027210 Slot: 4
	protected override bool Eof() { }

	// RVA: 0x3027290 Offset: 0x3027391 VA: 0x3027290 Slot: 5
	protected override string ReadLine() { }

	// RVA: 0x3027310 Offset: 0x3027411 VA: 0x3027310 Slot: 7
	protected override string ReadToEnd() { }

	// RVA: 0x3027380 Offset: 0x3027481 VA: 0x3027380 Slot: 6
	protected override string ReadBuffer(int p) { }

	// RVA: 0x3027460 Offset: 0x3027561 VA: 0x3027460 Slot: 8
	protected override char Peek() { }

	// RVA: 0x30274E0 Offset: 0x30275E1 VA: 0x30274E0 Slot: 9
	protected override void Write(string value) { }

	// RVA: 0x3027560 Offset: 0x3027661 VA: 0x3027560 Slot: 11
	protected override string Close() { }

	// RVA: 0x3027600 Offset: 0x3027701 VA: 0x3027600 Slot: 12
	public override bool flush() { }

	// RVA: 0x3027680 Offset: 0x3027781 VA: 0x3027680 Slot: 13
	public override long seek(string whence, long offset) { }

	// RVA: 0x3027840 Offset: 0x3027941 VA: 0x3027840 Slot: 14
	public override bool setvbuf(string mode) { }

	// RVA: 0x3027940 Offset: 0x3027A41 VA: 0x3027940 Slot: 10
	protected internal override bool isopen() { }

	// RVA: 0x3024780 Offset: 0x3024881 VA: 0x3024780
	protected void .ctor() { }
}

