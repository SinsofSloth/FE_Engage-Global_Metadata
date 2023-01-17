// Namespace: App
public abstract class PokeInspector : MapInspector // TypeDefIndex: 12146
{
	// Fields
	private int m_X; // 0x30
	private int m_Z; // 0x34
	private int m_W; // 0x38
	private int m_H; // 0x3C
	private int m_MaxHp; // 0x40
	private int m_Person; // 0x44
	private string m_HpLabel; // 0x48

	// Properties
	public override int X { get; }
	public override int Z { get; }
	public override int X1 { get; }
	public override int Z1 { get; }
	public override int X2 { get; }
	public override int Z2 { get; }
	public override int MaxHp { get; }
	public override int Hp { get; set; }

	// Methods

	// RVA: 0x29D9470 Offset: 0x29D9571 VA: 0x29D9470
	public void .ctor(MapInspector.Kind kind) { }

	// RVA: 0x29D9480 Offset: 0x29D9581 VA: 0x29D9480
	public void .ctor(MapInspector.Kind kind, int x, int z, int w, int h) { }

	// RVA: 0x29D94E0 Offset: 0x29D95E1 VA: 0x29D94E0
	public void .ctor(MapInspector.Kind kind, DynValue[] args) { }

	// RVA: 0x29D9680 Offset: 0x29D9781 VA: 0x29D9680 Slot: 12
	public override int get_X() { }

	// RVA: 0x29D9690 Offset: 0x29D9791 VA: 0x29D9690 Slot: 13
	public override int get_Z() { }

	// RVA: 0x29D96A0 Offset: 0x29D97A1 VA: 0x29D96A0 Slot: 14
	public override int get_X1() { }

	// RVA: 0x29D96B0 Offset: 0x29D97B1 VA: 0x29D96B0 Slot: 15
	public override int get_Z1() { }

	// RVA: 0x29D96C0 Offset: 0x29D97C1 VA: 0x29D96C0 Slot: 16
	public override int get_X2() { }

	// RVA: 0x29D96E0 Offset: 0x29D97E1 VA: 0x29D96E0 Slot: 17
	public override int get_Z2() { }

	// RVA: 0x29D9700 Offset: 0x29D9801 VA: 0x29D9700 Slot: 22
	public override int get_MaxHp() { }

	// RVA: 0x29D9710 Offset: 0x29D9811 VA: 0x29D9710 Slot: 20
	public override int get_Hp() { }

	// RVA: 0x29D9800 Offset: 0x29D9901 VA: 0x29D9800 Slot: 21
	public override void set_Hp(int value) { }

	// RVA: -1 Offset: -1 Slot: 36
	public abstract string GetLabel();

	// RVA: -1 Offset: -1 Slot: 37
	public abstract int GetRange();

	// RVA: 0x29D99D0 Offset: 0x29D9AD1 VA: 0x29D99D0
	public int GetNearX(int x) { }

	// RVA: 0x29D9A60 Offset: 0x29D9B61 VA: 0x29D9A60
	public int GetNearZ(int z) { }

	// RVA: 0x29D9AF0 Offset: 0x29D9BF1 VA: 0x29D9AF0
	protected int GetDistance(int x, int z) { }

	// RVA: 0x29D9C00 Offset: 0x29D9D01 VA: 0x29D9C00
	protected bool IsSightOut(int x, int z) { }

	// RVA: 0x29D9E30 Offset: 0x29D9F31 VA: 0x29D9E30 Slot: 7
	public override bool IsEanble(int x, int z) { }

	// RVA: 0x29D9E40 Offset: 0x29D9F41 VA: 0x29D9E40 Slot: 8
	public override bool IsEanble(int x, int z, int person) { }

	// RVA: 0x29D9EF0 Offset: 0x29D9FF1 VA: 0x29D9EF0
	public PokeInspector SetPos(int x, int z, int w, int h) { }

	// RVA: 0x29DA160 Offset: 0x29DA261 VA: 0x29DA160
	public PokeInspector SetMaxHp(int maxHp) { }
}

