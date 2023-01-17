// Namespace: App
public class SortieEntrustUnitData // TypeDefIndex: 13167
{
	// Fields
	private Unit m_Unit; // 0x10
	private UnitItem[] m_UnitItems; // 0x18
	private int m_Count; // 0x20
	private SortieEntrustProgress m_Progress; // 0x24
	private List<SortieEntrustUnitData.WeaponKindExp> m_SortedWeaponKind; // 0x28

	// Properties
	public Unit Unit { get; }
	public UnitItem[] UnitItems { get; }
	public int Count { get; }
	public SortieEntrustProgress Progress { get; }

	// Methods

	// RVA: 0x2158220 Offset: 0x2158321 VA: 0x2158220
	public void .ctor(Unit unit) { }

	// RVA: 0x21589A0 Offset: 0x2158AA1 VA: 0x21589A0
	public void Add(UnitItem unitItem) { }

	// RVA: 0x2158B30 Offset: 0x2158C31 VA: 0x2158B30
	public void NextProgress() { }

	// RVA: 0x2158B50 Offset: 0x2158C51 VA: 0x2158B50
	public void EndProgress() { }

	// RVA: 0x2157100 Offset: 0x2157201 VA: 0x2157100
	public ItemData.Kinds GetSortedWeaponKind(int index) { }

	// RVA: 0x2158B60 Offset: 0x2158C61 VA: 0x2158B60
	public Unit get_Unit() { }

	// RVA: 0x2158B70 Offset: 0x2158C71 VA: 0x2158B70
	public UnitItem[] get_UnitItems() { }

	// RVA: 0x2158B80 Offset: 0x2158C81 VA: 0x2158B80
	public int get_Count() { }

	// RVA: 0x2158B90 Offset: 0x2158C91 VA: 0x2158B90
	public SortieEntrustProgress get_Progress() { }
}

