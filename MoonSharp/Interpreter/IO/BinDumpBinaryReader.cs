// Namespace: MoonSharp.Interpreter.IO
public class BinDumpBinaryReader : BinaryReader // TypeDefIndex: 6171
{
	// Fields
	private List<string> m_Strings; // 0x48

	// Methods

	// RVA: 0x30EBD50 Offset: 0x30EBE51 VA: 0x30EBD50
	public void .ctor(Stream s) { }

	// RVA: 0x30EBDF0 Offset: 0x30EBEF1 VA: 0x30EBDF0
	public void .ctor(Stream s, Encoding e) { }

	// RVA: 0x30EBEA0 Offset: 0x30EBFA1 VA: 0x30EBEA0 Slot: 15
	public override int ReadInt32() { }

	// RVA: 0x30EBF10 Offset: 0x30EC011 VA: 0x30EBF10 Slot: 16
	public override uint ReadUInt32() { }

	// RVA: 0x30EBF70 Offset: 0x30EC071 VA: 0x30EBF70 Slot: 22
	public override string ReadString() { }
}

