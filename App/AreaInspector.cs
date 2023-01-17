// Namespace: App
public class AreaInspector : MapInspector // TypeDefIndex: 12127
{
	// Fields
	private int m_X1; // 0x30
	private int m_Z1; // 0x34
	private int m_X2; // 0x38
	private int m_Z2; // 0x3C
	private int m_Force; // 0x40

	// Properties
	public override int X1 { get; }
	public override int Z1 { get; }
	public override int X2 { get; }
	public override int Z2 { get; }
	public override Color Color { get; }

	// Methods

	// RVA: 0x2101890 Offset: 0x2101991 VA: 0x2101890
	public void .ctor(DynValue[] args) { }

	// RVA: 0x21019E0 Offset: 0x2101AE1 VA: 0x21019E0 Slot: 8
	public override bool IsEanble(int x, int z, int force) { }

	// RVA: 0x2101A70 Offset: 0x2101B71 VA: 0x2101A70 Slot: 14
	public override int get_X1() { }

	// RVA: 0x2101A80 Offset: 0x2101B81 VA: 0x2101A80 Slot: 15
	public override int get_Z1() { }

	// RVA: 0x2101A90 Offset: 0x2101B91 VA: 0x2101A90 Slot: 16
	public override int get_X2() { }

	// RVA: 0x2101AA0 Offset: 0x2101BA1 VA: 0x2101AA0 Slot: 17
	public override int get_Z2() { }

	// RVA: 0x2101AB0 Offset: 0x2101BB1 VA: 0x2101AB0 Slot: 11
	public override Color get_Color() { }
}

