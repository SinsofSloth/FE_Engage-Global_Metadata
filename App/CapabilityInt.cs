// Namespace: App
public class CapabilityInt : CapabilityBase<int> // TypeDefIndex: 9832
{
	// Fields
	public const int Min = -10000;
	public const int Max = 10000;

	// Methods

	// RVA: 0x29A9CB0 Offset: 0x29A9DB1 VA: 0x29A9CB0
	public void .ctor(int value = 0) { }

	// RVA: 0x29A9D10 Offset: 0x29A9E11 VA: 0x29A9D10 Slot: 5
	public override void Add(int i, int v) { }

	// RVA: 0x29A9DB0 Offset: 0x29A9EB1 VA: 0x29A9DB0 Slot: 6
	public override bool IsZero() { }

	// RVA: 0x29A9E50 Offset: 0x29A9F51 VA: 0x29A9E50 Slot: 7
	protected override void WriteToStream(Stream stream, int v) { }

	// RVA: 0x29A9E60 Offset: 0x29A9F61 VA: 0x29A9E60 Slot: 8
	protected override int ReadFromStream(Stream stream) { }
}

