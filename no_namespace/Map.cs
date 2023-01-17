// Namespace: 
[DefaultMemberAttribute] // RVA: 0x277C20 Offset: 0x277D21 VA: 0x277C20
public class Map.CellVertex // TypeDefIndex: 11884
{
	// Fields
	private Vector3[] m_Position; // 0x10

	// Properties
	public Vector3 Item { get; set; }
	public float MinHeight { get; }
	public float MaxHeight { get; }

	// Methods

	// RVA: 0x223E6C0 Offset: 0x223E7C1 VA: 0x223E6C0
	public void Clear() { }

	// RVA: 0x223E750 Offset: 0x223E851 VA: 0x223E750
	public void Calc(int x, int z) { }

	// RVA: 0x223E9D0 Offset: 0x223EAD1 VA: 0x223E9D0
	public Vector3 get_Item(int i) { }

	// RVA: 0x223EA10 Offset: 0x223EB11 VA: 0x223EA10
	public void set_Item(int i, Vector3 value) { }

	// RVA: 0x223EA60 Offset: 0x223EB61 VA: 0x223EA60
	public float get_MinHeight() { }

	// RVA: 0x223EAF0 Offset: 0x223EBF1 VA: 0x223EAF0
	public float get_MaxHeight() { }

	// RVA: 0x2238150 Offset: 0x2238251 VA: 0x2238150
	public void .ctor() { }
}

// Namespace: 
private class Map.FillList : List<Map.Pos> // TypeDefIndex: 11886
{
	// Methods

	// RVA: 0x223EB80 Offset: 0x223EC81 VA: 0x223EB80
	public void FillTerrain(int x, int z, int before, int after) { }

	// RVA: 0x223EDF0 Offset: 0x223EEF1 VA: 0x223EDF0
	public void .ctor() { }
}

