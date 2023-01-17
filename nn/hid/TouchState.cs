// Namespace: nn.hid
public struct TouchState : IEquatable<TouchState> // TypeDefIndex: 14669
{
	// Fields
	public long deltaTimeNanoSeconds; // 0x0
	public TouchAttribute attributes; // 0x8
	public int fingerId; // 0xC
	public int x; // 0x10
	public int y; // 0x14
	public int diameterX; // 0x18
	public int diameterY; // 0x1C
	public int rotationAngle; // 0x20
	private int _reserved; // 0x24

	// Methods

	// RVA: 0x25E8720 Offset: 0x25E8821 VA: 0x25E8720 Slot: 3
	public override string ToString() { }

	// RVA: 0x25E8A60 Offset: 0x25E8B61 VA: 0x25E8A60
	public static bool op_Equality(TouchState lhs, TouchState rhs) { }

	// RVA: 0x25E8AF0 Offset: 0x25E8BF1 VA: 0x25E8AF0
	public static bool op_Inequality(TouchState lhs, TouchState rhs) { }

	// RVA: 0x25E8B80 Offset: 0x25E8C81 VA: 0x25E8B80 Slot: 0
	public override bool Equals(object right) { }

	// RVA: 0x25E8CA0 Offset: 0x25E8DA1 VA: 0x25E8CA0 Slot: 4
	public bool Equals(TouchState other) { }

	// RVA: 0x25E8D30 Offset: 0x25E8E31 VA: 0x25E8D30 Slot: 2
	public override int GetHashCode() { }
}

