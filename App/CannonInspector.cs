// Namespace: App
public class CannonInspector : MapInspector // TypeDefIndex: 12159
{
	// Fields
	private const int Version = 1;
	private int m_X; // 0x30
	private int m_Z; // 0x34
	private int m_MaxShells; // 0x38
	private string m_KeyShells; // 0x40

	// Properties
	public override int X { get; }
	public override int Z { get; }

	// Methods

	// RVA: 0x29A6CD0 Offset: 0x29A6DD1 VA: 0x29A6CD0
	public void .ctor(int x, int z, int maxShells) { }

	// RVA: 0x29A6E50 Offset: 0x29A6F51 VA: 0x29A6E50 Slot: 5
	public override bool IsEanble() { }

	// RVA: 0x29A6F90 Offset: 0x29A7091 VA: 0x29A6F90 Slot: 4
	public override void Completed() { }

	// RVA: 0x29A6FA0 Offset: 0x29A70A1 VA: 0x29A6FA0 Slot: 12
	public override int get_X() { }

	// RVA: 0x29A6FB0 Offset: 0x29A70B1 VA: 0x29A6FB0 Slot: 13
	public override int get_Z() { }

	// RVA: 0x29A6FC0 Offset: 0x29A70C1 VA: 0x29A6FC0
	public int GetMaxShells() { }

	// RVA: 0x29A6FD0 Offset: 0x29A70D1 VA: 0x29A6FD0
	public void SetShells(int num) { }

	// RVA: 0x29A71A0 Offset: 0x29A72A1 VA: 0x29A71A0
	public int GetShells() { }

	// RVA: 0x29A7280 Offset: 0x29A7381 VA: 0x29A7280
	public void DecreaseShell() { }

	// RVA: 0x29A72C0 Offset: 0x29A73C1 VA: 0x29A72C0
	public SkillData GetCannonSkill(bool isForce = False) { }

	// RVA: 0x29A7330 Offset: 0x29A7431 VA: 0x29A7330
	public bool IsTerrainFlag(TerrainData.Flags flags) { }

	// RVA: 0x29A73B0 Offset: 0x29A74B1 VA: 0x29A73B0
	public bool IsBowCannon() { }

	// RVA: 0x29A7430 Offset: 0x29A7531 VA: 0x29A7430
	public bool IsMagicCannon() { }

	// RVA: 0x29A74B0 Offset: 0x29A75B1 VA: 0x29A74B0
	public bool IsFireCannon() { }

	// RVA: 0x29A6E70 Offset: 0x29A6F71 VA: 0x29A6E70
	private TerrainData GetTerrain() { }
}

