// Namespace: nn.hid
public struct GestureState // TypeDefIndex: 14635
{
	// Fields
	public long eventNumber; // 0x0
	public long contextNumber; // 0x8
	public int _type; // 0x10
	public int _direction; // 0x14
	public int x; // 0x18
	public int y; // 0x1C
	public int deltaX; // 0x20
	public int deltaY; // 0x24
	public Float2 velocity; // 0x28
	public GestureAttribute attributes; // 0x30
	public float scale; // 0x34
	public float rotationAngle; // 0x38
	public int pointCount; // 0x3C
	public GestureState.GesturePointArray4 points; // 0x40

	// Properties
	public GestureType type { get; }
	public GestureDirection direction { get; }
	public bool isDoubleTap { get; }

	// Methods

	// RVA: 0x28E1030 Offset: 0x28E1131 VA: 0x28E1030
	public void SetDefault() { }

	// RVA: 0x28E1040 Offset: 0x28E1141 VA: 0x28E1040
	public GestureType get_type() { }

	// RVA: 0x28E1050 Offset: 0x28E1151 VA: 0x28E1050
	public GestureDirection get_direction() { }

	// RVA: 0x28E1060 Offset: 0x28E1161 VA: 0x28E1060
	public bool get_isDoubleTap() { }

	// RVA: 0x28E1070 Offset: 0x28E1171 VA: 0x28E1070 Slot: 3
	public override string ToString() { }
}

