// Namespace: App
public class MapImageUnit : MapImageCoreByte // TypeDefIndex: 12120
{
	// Fields
	private MapPos[] m_Cells; // 0x18

	// Methods

	// RVA: 0x24708D0 Offset: 0x24709D1 VA: 0x24708D0
	public Unit GetUnit(int x, int z) { }

	// RVA: 0x2470960 Offset: 0x2470A61 VA: 0x2470960
	public Unit GetUnitWithMind(int x, int z) { }

	// RVA: 0x2470AF0 Offset: 0x2470BF1 VA: 0x2470AF0
	public void Update() { }

	// RVA: 0x2473F60 Offset: 0x2474061 VA: 0x2473F60
	public void Update(Unit unit) { }

	// RVA: 0x24743A0 Offset: 0x24744A1 VA: 0x24743A0
	public bool TryAdd(Unit unit) { }

	// RVA: 0x24744C0 Offset: 0x24745C1 VA: 0x24744C0
	public bool TryDelete(Unit unit) { }

	// RVA: 0x2470ED0 Offset: 0x2470FD1 VA: 0x2470ED0
	public void UpdateSupportSkill() { }

	// RVA: 0x24745F0 Offset: 0x24746F1 VA: 0x24745F0
	public void UpdateSupportSkill(Unit unit, int x, int z) { }

	// RVA: 0x2470D10 Offset: 0x2470E11 VA: 0x2470D10
	private void AddImpl(Unit unit, int baseX, int baseZ) { }

	// RVA: 0x24741F0 Offset: 0x24742F1 VA: 0x24741F0
	private void DeleteImpl(Unit unit, int baseX, int baseZ) { }

	// RVA: 0x2474670 Offset: 0x2474771 VA: 0x2474670
	public void Add(Unit unit) { }

	// RVA: 0x2474690 Offset: 0x2474791 VA: 0x2474690
	public void Add(Unit unit, int x, int z) { }

	// RVA: 0x24746B0 Offset: 0x24747B1 VA: 0x24746B0
	public void AddNoUpdatingSupportSkill(Unit unit, int x, int z) { }

	// RVA: 0x24746C0 Offset: 0x24747C1 VA: 0x24746C0
	public void Delete(Unit unit) { }

	// RVA: 0x24746E0 Offset: 0x24747E1 VA: 0x24746E0
	public void Delete(Unit unit, int x, int z) { }

	// RVA: 0x2474700 Offset: 0x2474801 VA: 0x2474700
	public void DeleteNoUpdatingSupportSkill(Unit unit, int x, int z) { }

	// RVA: 0x2474710 Offset: 0x2474811 VA: 0x2474710
	public bool TryMove(Unit unit, int oldX, int oldZ, int newX, int newZ) { }

	// RVA: 0x24748C0 Offset: 0x24749C1 VA: 0x24748C0
	public void .ctor() { }
}

