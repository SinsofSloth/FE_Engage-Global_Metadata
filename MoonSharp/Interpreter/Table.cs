// Namespace: MoonSharp.Interpreter
[DefaultMemberAttribute] // RVA: 0xD3C0 Offset: 0xD4C1 VA: 0xD3C0
public class Table : RefIdObject, IScriptPrivateResource // TypeDefIndex: 5948
{
	// Fields
	private readonly LinkedList<TablePair> m_Values; // 0x18
	private readonly LinkedListIndex<DynValue, TablePair> m_ValueMap; // 0x20
	private readonly LinkedListIndex<string, TablePair> m_StringMap; // 0x28
	private readonly LinkedListIndex<int, TablePair> m_ArrayMap; // 0x30
	private readonly Script m_Owner; // 0x38
	private int m_InitArray; // 0x40
	private int m_CachedLength; // 0x44
	private bool m_ContainsNilEntries; // 0x48
	private Table m_MetaTable; // 0x50

	// Properties
	public Script OwnerScript { get; }
	public object Item { get; set; }
	public object Item { get; set; }
	public int Length { get; }
	public Table MetaTable { get; set; }
	public IEnumerable<TablePair> Pairs { get; }
	public IEnumerable<DynValue> Keys { get; }
	public IEnumerable<DynValue> Values { get; }

	// Methods

	// RVA: 0x3016AE0 Offset: 0x3016BE1 VA: 0x3016AE0
	public void .ctor(Script owner) { }

	// RVA: 0x302A060 Offset: 0x302A161 VA: 0x302A060
	public void .ctor(Script owner, DynValue[] arrayValues) { }

	// RVA: 0x302A2D0 Offset: 0x302A3D1 VA: 0x302A2D0 Slot: 4
	public Script get_OwnerScript() { }

	// RVA: 0x302A2E0 Offset: 0x302A3E1 VA: 0x302A2E0
	public void Clear() { }

	// RVA: 0x302A3B0 Offset: 0x302A4B1 VA: 0x302A3B0
	private int GetIntegralKey(double d) { }

	// RVA: 0x302A3E0 Offset: 0x302A4E1 VA: 0x302A3E0
	public object get_Item(object[] keys) { }

	// RVA: 0x302A510 Offset: 0x302A611 VA: 0x302A510
	public void set_Item(object[] keys, object value) { }

	// RVA: 0x30122C0 Offset: 0x30123C1 VA: 0x30122C0
	public object get_Item(object key) { }

	// RVA: 0x302A750 Offset: 0x302A851 VA: 0x302A750
	public void set_Item(object key, object value) { }

	// RVA: 0x302A930 Offset: 0x302AA31 VA: 0x302A930
	private Table ResolveMultipleKeys(object[] keys, out object key) { }

	// RVA: 0x302AC40 Offset: 0x302AD41 VA: 0x302AC40
	public void Append(DynValue value) { }

	// RVA: -1 Offset: -1
	private void PerformTableSet<T>(LinkedListIndex<T, TablePair> listIndex, T key, DynValue keyDynValue, DynValue value, bool isNumber, int appendKey) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2024420 Offset: 0x2024521 VA: 0x2024420
	|-Table.PerformTableSet<DynValue>
	|-Table.PerformTableSet<object>
	|-Table.PerformTableSet<string>
	|
	|-RVA: 0x20242A0 Offset: 0x20243A1 VA: 0x20242A0
	|-Table.PerformTableSet<int>
	*/

	// RVA: 0x3010240 Offset: 0x3010341 VA: 0x3010240
	public void Set(string key, DynValue value) { }

	// RVA: 0x302AE20 Offset: 0x302AF21 VA: 0x302AE20
	public void Set(int key, DynValue value) { }

	// RVA: 0x302A140 Offset: 0x302A241 VA: 0x302A140
	public void Set(DynValue key, DynValue value) { }

	// RVA: 0x302A7F0 Offset: 0x302A8F1 VA: 0x302A7F0
	public void Set(object key, DynValue value) { }

	// RVA: 0x302A5F0 Offset: 0x302A6F1 VA: 0x302A5F0
	public void Set(object[] keys, DynValue value) { }

	// RVA: 0x30123F0 Offset: 0x30124F1 VA: 0x30123F0
	public DynValue Get(string key) { }

	// RVA: 0x302AF00 Offset: 0x302B001 VA: 0x302AF00
	public DynValue Get(int key) { }

	// RVA: 0x302B0F0 Offset: 0x302B1F1 VA: 0x302B0F0
	public DynValue Get(DynValue key) { }

	// RVA: 0x302A650 Offset: 0x302A751 VA: 0x302A650
	public DynValue Get(object key) { }

	// RVA: 0x302A400 Offset: 0x302A501 VA: 0x302A400
	public DynValue Get(object[] keys) { }

	// RVA: 0x302B3C0 Offset: 0x302B4C1 VA: 0x302B3C0
	private static DynValue RawGetValue(LinkedListNode<TablePair> linkedListNode) { }

	// RVA: 0x3015450 Offset: 0x3015551 VA: 0x3015450
	public DynValue RawGet(string key) { }

	// RVA: 0x302B050 Offset: 0x302B151 VA: 0x302B050
	public DynValue RawGet(int key) { }

	// RVA: 0x302B1F0 Offset: 0x302B2F1 VA: 0x302B1F0
	public DynValue RawGet(DynValue key) { }

	// RVA: 0x302AA80 Offset: 0x302AB81 VA: 0x302AA80
	public DynValue RawGet(object key) { }

	// RVA: 0x302B370 Offset: 0x302B471 VA: 0x302B370
	public DynValue RawGet(object[] keys) { }

	// RVA: -1 Offset: -1
	private bool PerformTableRemove<T>(LinkedListIndex<T, TablePair> listIndex, T key, bool isNumber) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2024250 Offset: 0x2024351 VA: 0x2024250
	|-Table.PerformTableRemove<DynValue>
	|-Table.PerformTableRemove<object>
	|-Table.PerformTableRemove<string>
	|
	|-RVA: 0x2024200 Offset: 0x2024301 VA: 0x2024200
	|-Table.PerformTableRemove<int>
	*/

	// RVA: 0x302B420 Offset: 0x302B521 VA: 0x302B420
	public bool Remove(string key) { }

	// RVA: 0x302B490 Offset: 0x302B591 VA: 0x302B490
	public bool Remove(int key) { }

	// RVA: 0x302B500 Offset: 0x302B601 VA: 0x302B500
	public bool Remove(DynValue key) { }

	// RVA: 0x302B640 Offset: 0x302B741 VA: 0x302B640
	public bool Remove(object key) { }

	// RVA: 0x302B7B0 Offset: 0x302B8B1 VA: 0x302B7B0
	public bool Remove(object[] keys) { }

	// RVA: 0x302B800 Offset: 0x302B901 VA: 0x302B800
	public void CollectDeadKeys() { }

	// RVA: 0x302B8C0 Offset: 0x302B9C1 VA: 0x302B8C0
	public Nullable<TablePair> NextKey(DynValue v) { }

	// RVA: 0x302BB00 Offset: 0x302BC01 VA: 0x302BB00
	private Nullable<TablePair> GetNextOf(LinkedListNode<TablePair> linkedListNode) { }

	// RVA: 0x302AD50 Offset: 0x302AE51 VA: 0x302AD50
	public int get_Length() { }

	// RVA: 0x302BC70 Offset: 0x302BD71 VA: 0x302BC70
	internal void InitNextArrayKeys(DynValue val, bool lastpos) { }

	// RVA: 0x302BD40 Offset: 0x302BE41 VA: 0x302BD40
	public Table get_MetaTable() { }

	// RVA: 0x302BD50 Offset: 0x302BE51 VA: 0x302BD50
	public void set_MetaTable(Table value) { }

	// RVA: 0x30113C0 Offset: 0x30114C1 VA: 0x30113C0
	public IEnumerable<TablePair> get_Pairs() { }

	// RVA: 0x302BD90 Offset: 0x302BE91 VA: 0x302BD90
	public IEnumerable<DynValue> get_Keys() { }

	// RVA: 0x301EC00 Offset: 0x301ED01 VA: 0x301EC00
	public IEnumerable<DynValue> get_Values() { }
}

