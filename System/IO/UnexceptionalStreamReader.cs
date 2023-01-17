// Namespace: System.IO
internal class UnexceptionalStreamReader : StreamReader // TypeDefIndex: 675
{
	// Fields
	private static bool[] newline; // 0x0
	private static char newlineChar; // 0x8

	// Methods

	// RVA: 0x3650D70 Offset: 0x3650E71 VA: 0x3650D70
	private static void .cctor() { }

	// RVA: 0x3650E20 Offset: 0x3650F21 VA: 0x3650E20
	public void .ctor(Stream stream, Encoding encoding) { }

	// RVA: 0x3650EB0 Offset: 0x3650FB1 VA: 0x3650EB0 Slot: 9
	public override int Peek() { }

	// RVA: 0x3650F50 Offset: 0x3651051 VA: 0x3650F50 Slot: 10
	public override int Read() { }

	// RVA: 0x3650FF0 Offset: 0x36510F1 VA: 0x3650FF0 Slot: 11
	public override int Read([In] [Out] char[] dest_buffer, int index, int count) { }

	// RVA: 0x36512D0 Offset: 0x36513D1 VA: 0x36512D0
	private bool CheckEOL(char current) { }

	// RVA: 0x36514B0 Offset: 0x36515B1 VA: 0x36514B0 Slot: 14
	public override string ReadLine() { }

	// RVA: 0x3651550 Offset: 0x3651651 VA: 0x3651550 Slot: 12
	public override string ReadToEnd() { }
}

