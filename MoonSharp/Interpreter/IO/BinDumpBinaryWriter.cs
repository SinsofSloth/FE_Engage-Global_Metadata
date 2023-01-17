// Namespace: MoonSharp.Interpreter.IO
public class BinDumpBinaryWriter : BinaryWriter // TypeDefIndex: 6172
{
	// Fields
	private Dictionary<string, int> m_StringMap; // 0x48

	// Methods

	// RVA: 0x30EC090 Offset: 0x30EC191 VA: 0x30EC090
	public void .ctor(Stream s) { }

	// RVA: 0x30EC160 Offset: 0x30EC261 VA: 0x30EC160
	public void .ctor(Stream s, Encoding e) { }

	// RVA: 0x30EC240 Offset: 0x30EC341 VA: 0x30EC240 Slot: 18
	public override void Write(uint value) { }

	// RVA: 0x30EC2E0 Offset: 0x30EC3E1 VA: 0x30EC2E0 Slot: 17
	public override void Write(int value) { }

	// RVA: 0x30EC380 Offset: 0x30EC481 VA: 0x30EC380 Slot: 22
	public override void Write(string value) { }
}

