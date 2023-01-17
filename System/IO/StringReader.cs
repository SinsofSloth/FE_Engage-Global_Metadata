// Namespace: System.IO
[ComVisibleAttribute] // RVA: 0x472BA0 Offset: 0x472CA1 VA: 0x472BA0
[Serializable]
public class StringReader : TextReader // TypeDefIndex: 646
{
	// Fields
	private string _s; // 0x18
	private int _pos; // 0x20
	private int _length; // 0x24

	// Methods

	// RVA: 0x365A3A0 Offset: 0x365A4A1 VA: 0x365A3A0
	public void .ctor(string s) { }

	// RVA: 0x365A480 Offset: 0x365A581 VA: 0x365A480 Slot: 7
	public override void Close() { }

	// RVA: 0x365A490 Offset: 0x365A591 VA: 0x365A490 Slot: 8
	protected override void Dispose(bool disposing) { }

	// RVA: 0x365A4D0 Offset: 0x365A5D1 VA: 0x365A4D0 Slot: 9
	public override int Peek() { }

	// RVA: 0x365A540 Offset: 0x365A641 VA: 0x365A540 Slot: 10
	public override int Read() { }

	// RVA: 0x365A5B0 Offset: 0x365A6B1 VA: 0x365A5B0 Slot: 11
	public override int Read([In] [Out] char[] buffer, int index, int count) { }

	// RVA: 0x365A780 Offset: 0x365A881 VA: 0x365A780 Slot: 12
	public override string ReadToEnd() { }

	// RVA: 0x365A7E0 Offset: 0x365A8E1 VA: 0x365A7E0 Slot: 14
	public override string ReadLine() { }
}

