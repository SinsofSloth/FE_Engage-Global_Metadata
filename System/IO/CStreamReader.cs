// Namespace: System.IO
internal class CStreamReader : StreamReader // TypeDefIndex: 677
{
	// Fields
	private TermInfoDriver driver; // 0x68

	// Methods

	// RVA: 0x3512130 Offset: 0x3512231 VA: 0x3512130
	public void .ctor(Stream stream, Encoding encoding) { }

	// RVA: 0x3512260 Offset: 0x3512361 VA: 0x3512260 Slot: 9
	public override int Peek() { }

	// RVA: 0x3512300 Offset: 0x3512401 VA: 0x3512300 Slot: 10
	public override int Read() { }

	// RVA: 0x35123F0 Offset: 0x35124F1 VA: 0x35123F0 Slot: 11
	public override int Read([In] [Out] char[] dest, int index, int count) { }

	// RVA: 0x3512590 Offset: 0x3512691 VA: 0x3512590 Slot: 14
	public override string ReadLine() { }

	// RVA: 0x3512630 Offset: 0x3512731 VA: 0x3512630 Slot: 12
	public override string ReadToEnd() { }
}

