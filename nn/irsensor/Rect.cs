// Namespace: nn.irsensor
public struct Rect : IEquatable<Rect> // TypeDefIndex: 14593
{
	// Fields
	public short x; // 0x0
	public short y; // 0x2
	public short width; // 0x4
	public short height; // 0x6

	// Methods

	// RVA: 0x2773890 Offset: 0x2773991 VA: 0x2773890
	public void .ctor(short x, short y, short width, short height) { }

	// RVA: 0x27738B0 Offset: 0x27739B1 VA: 0x27738B0 Slot: 3
	public override string ToString() { }

	// RVA: 0x2773A90 Offset: 0x2773B91 VA: 0x2773A90
	public static bool op_Equality(Rect lhs, Rect rhs) { }

	// RVA: 0x2773AD0 Offset: 0x2773BD1 VA: 0x2773AD0
	public static bool op_Inequality(Rect lhs, Rect rhs) { }

	// RVA: 0x2773B20 Offset: 0x2773C21 VA: 0x2773B20 Slot: 0
	public override bool Equals(object right) { }

	// RVA: 0x2773BE0 Offset: 0x2773CE1 VA: 0x2773BE0 Slot: 4
	public bool Equals(Rect other) { }

	// RVA: 0x2773C30 Offset: 0x2773D31 VA: 0x2773C30 Slot: 2
	public override int GetHashCode() { }
}

