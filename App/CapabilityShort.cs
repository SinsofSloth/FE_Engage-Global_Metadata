// Namespace: App
public class CapabilityShort : CapabilityBase<short> // TypeDefIndex: 9831
{
	// Fields
	public const int Min = -10000;
	public const int Max = 10000;

	// Methods

	// RVA: 0x29AA140 Offset: 0x29AA241 VA: 0x29AA140
	public void .ctor(short value) { }

	// RVA: 0x29AA1A0 Offset: 0x29AA2A1 VA: 0x29AA1A0 Slot: 5
	public override void Add(int i, short v) { }

	// RVA: 0x29AA240 Offset: 0x29AA341 VA: 0x29AA240 Slot: 6
	public override bool IsZero() { }

	// RVA: 0x29AA300 Offset: 0x29AA401 VA: 0x29AA300 Slot: 7
	protected override void WriteToStream(Stream stream, short v) { }

	// RVA: 0x29AA310 Offset: 0x29AA411 VA: 0x29AA310 Slot: 8
	protected override short ReadFromStream(Stream stream) { }
}

