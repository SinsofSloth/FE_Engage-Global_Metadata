// Namespace: 
public class MapTarget.Data // TypeDefIndex: 12240
{
	// Fields
	private byte m_Index; // 0x10
	private Unit m_Unit; // 0x18
	private sbyte m_X; // 0x20
	private sbyte m_Z; // 0x21
	private sbyte m_X1; // 0x22
	private sbyte m_Z1; // 0x23
	private sbyte m_X2; // 0x24
	private sbyte m_Z2; // 0x25
	private uint m_ItemMask; // 0x28
	private sbyte m_SelectItemIndex; // 0x2C

	// Properties
	public int Index { get; set; }
	public Unit Unit { get; }
	public int X { get; }
	public int Z { get; }
	public int X1 { get; }
	public int Z1 { get; }
	public int X2 { get; }
	public int Z2 { get; }
	public uint ItemMask { get; }
	public int SelectItemIndex { get; set; }

	// Methods

	// RVA: 0x213F510 Offset: 0x213F611 VA: 0x213F510
	public MapTarget.Data Set(Unit unit, uint itemMask = 0, int selectItemIndex = -1) { }

	// RVA: 0x213F5F0 Offset: 0x213F6F1 VA: 0x213F5F0
	public MapTarget.Data Set(Unit unit, int x, int z, uint itemMask = 0, int selectItemIndex = -1) { }

	// RVA: 0x213F6D0 Offset: 0x213F7D1 VA: 0x213F6D0
	public MapTarget.Data Set(int x, int z, uint itemMask = 0, int selectItemIndex = -1) { }

	// RVA: 0x213F7B0 Offset: 0x213F8B1 VA: 0x213F7B0
	public MapTarget.Data SetRect(int x1, int z1, int x2, int z2) { }

	// RVA: 0x213F7D0 Offset: 0x213F8D1 VA: 0x213F7D0
	public int get_Index() { }

	// RVA: 0x213F7E0 Offset: 0x213F8E1 VA: 0x213F7E0
	public void set_Index(int value) { }

	// RVA: 0x213F7F0 Offset: 0x213F8F1 VA: 0x213F7F0
	public Unit get_Unit() { }

	// RVA: 0x213F800 Offset: 0x213F901 VA: 0x213F800
	public int get_X() { }

	// RVA: 0x213F810 Offset: 0x213F911 VA: 0x213F810
	public int get_Z() { }

	// RVA: 0x213F820 Offset: 0x213F921 VA: 0x213F820
	public int get_X1() { }

	// RVA: 0x213F830 Offset: 0x213F931 VA: 0x213F830
	public int get_Z1() { }

	// RVA: 0x213F840 Offset: 0x213F941 VA: 0x213F840
	public int get_X2() { }

	// RVA: 0x213F850 Offset: 0x213F951 VA: 0x213F850
	public int get_Z2() { }

	// RVA: 0x213F860 Offset: 0x213F961 VA: 0x213F860
	public uint get_ItemMask() { }

	// RVA: 0x213F870 Offset: 0x213F971 VA: 0x213F870
	public int get_SelectItemIndex() { }

	// RVA: 0x213F880 Offset: 0x213F981 VA: 0x213F880
	public void set_SelectItemIndex(int value) { }

	// RVA: 0x213F890 Offset: 0x213F991 VA: 0x213F890
	public bool CheckItemMask(int index) { }

	// RVA: 0x213F8A0 Offset: 0x213F9A1 VA: 0x213F8A0
	public bool IsOutSide(int x, int z) { }

	// RVA: 0x213F8F0 Offset: 0x213F9F1 VA: 0x213F8F0
	public void CopyFrom(MapTarget.Data from) { }

	// RVA: 0x213F970 Offset: 0x213FA71 VA: 0x213F970
	public string GetName() { }

	// RVA: 0x213F9D0 Offset: 0x213FAD1 VA: 0x213F9D0
	public void .ctor() { }
}

// Namespace: 
[DefaultMemberAttribute] // RVA: 0x278080 Offset: 0x278181 VA: 0x278080
public class MapTarget.DataSet // TypeDefIndex: 12242
{
	// Fields
	private List<MapTarget.Data> m_List; // 0x10
	private Stack<MapTarget.Data> m_Stack; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x299D40 Offset: 0x299E41 VA: 0x299D40
	private uint <ItemMask>k__BackingField; // 0x20

	// Properties
	public List<MapTarget.Data> List { get; }
	public int Count { get; }
	public MapTarget.Data Item { get; }
	public uint ItemMask { get; set; }

	// Methods

	// RVA: 0x213F9E0 Offset: 0x213FAE1 VA: 0x213F9E0
	public void .ctor(int capacity = 1024) { }

	// RVA: 0x213FB40 Offset: 0x213FC41 VA: 0x213FB40
	public List<MapTarget.Data> get_List() { }

	// RVA: 0x213FB50 Offset: 0x213FC51 VA: 0x213FB50
	public int get_Count() { }

	// RVA: 0x213FBA0 Offset: 0x213FCA1 VA: 0x213FBA0
	public MapTarget.Data get_Item(int i) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C8180 Offset: 0x2C8281 VA: 0x2C8180
	// RVA: 0x213FC10 Offset: 0x213FD11 VA: 0x213FC10
	public uint get_ItemMask() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C8190 Offset: 0x2C8291 VA: 0x2C8190
	// RVA: 0x213FC20 Offset: 0x213FD21 VA: 0x213FC20
	public void set_ItemMask(uint value) { }

	// RVA: 0x213FC30 Offset: 0x213FD31 VA: 0x213FC30
	public int IndexOf(Unit unit) { }

	// RVA: 0x213FD30 Offset: 0x213FE31 VA: 0x213FD30
	public int IndexOf(int x, int z) { }

	// RVA: 0x213FE80 Offset: 0x213FF81 VA: 0x213FE80
	public bool IsExist(Unit unit) { }

	// RVA: 0x213FF80 Offset: 0x2140081 VA: 0x213FF80
	public bool IsExist(int x, int z) { }

	// RVA: 0x21400E0 Offset: 0x21401E1 VA: 0x21400E0
	public MapTarget.Data NewData() { }

	// RVA: 0x2140190 Offset: 0x2140291 VA: 0x2140190
	public MapTarget.Data NewData(Unit unit, int x, int z, uint itemMask = 0, int selectItemIndex = -1) { }

	// RVA: 0x2140320 Offset: 0x2140421 VA: 0x2140320
	public MapTarget.Data NewData(int x, int z, uint itemMask = 0, int selectItemIndex = -1) { }

	// RVA: 0x21404B0 Offset: 0x21405B1 VA: 0x21404B0
	public void Clear() { }

	// RVA: 0x21405A0 Offset: 0x21406A1 VA: 0x21405A0
	public void CopyFrom(MapTarget.DataSet from) { }

	// RVA: 0x2140760 Offset: 0x2140861 VA: 0x2140760
	public void Sort() { }

	// RVA: 0x2140900 Offset: 0x2140A01 VA: 0x2140900
	public int GetDataItemCount() { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x2780D0 Offset: 0x2781D1 VA: 0x2780D0
private sealed class MapTarget.<>c__DisplayClass82_0 // TypeDefIndex: 12244
{
	// Fields
	public int count; // 0x10

	// Methods

	// RVA: 0x213F360 Offset: 0x213F461 VA: 0x213F360
	public void .ctor() { }

	// RVA: 0x213F370 Offset: 0x213F471 VA: 0x213F370
	internal void <EnumerateAttack>b__0(int x, int z, Unit target) { }

	// RVA: 0x213F380 Offset: 0x213F481 VA: 0x213F380
	internal void <EnumerateAttack>b__1(int x, int z, TerrainData terrain) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x2780F0 Offset: 0x2781F1 VA: 0x2780F0
private sealed class MapTarget.<>c__DisplayClass106_0 // TypeDefIndex: 12246
{
	// Fields
	public int count; // 0x10

	// Methods

	// RVA: 0x213F340 Offset: 0x213F441 VA: 0x213F340
	public void .ctor() { }

	// RVA: 0x213F350 Offset: 0x213F451 VA: 0x213F350
	internal void <EnumerateOverlapSkill>b__0(int x, int z, TerrainData terrain) { }
}

