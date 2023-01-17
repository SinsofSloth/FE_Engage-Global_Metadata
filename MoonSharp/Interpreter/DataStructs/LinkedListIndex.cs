// Namespace: MoonSharp.Interpreter.DataStructs
internal class LinkedListIndex<TKey, TValue> // TypeDefIndex: 6222
{
	// Fields
	private LinkedList<TValue> m_LinkedList; // 0x0
	private Dictionary<TKey, LinkedListNode<TValue>> m_Map; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(LinkedList<TValue> linkedList) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AD6460 Offset: 0x2AD6561 VA: 0x2AD6460
	|-LinkedListIndex<DynValue, TablePair>..ctor
	|-LinkedListIndex<object, TablePair>..ctor
	|-LinkedListIndex<string, TablePair>..ctor
	|
	|-RVA: 0x2AD5E80 Offset: 0x2AD5F81 VA: 0x2AD5E80
	|-LinkedListIndex<int, TablePair>..ctor
	|
	|-RVA: 0x2AD6180 Offset: 0x2AD6281 VA: 0x2AD6180
	|-LinkedListIndex<object, object>..ctor
	*/

	// RVA: -1 Offset: -1
	public LinkedListNode<TValue> Find(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AD64A0 Offset: 0x2AD65A1 VA: 0x2AD64A0
	|-LinkedListIndex<DynValue, TablePair>.Find
	|-LinkedListIndex<object, TablePair>.Find
	|-LinkedListIndex<string, TablePair>.Find
	|
	|-RVA: 0x2AD5EC0 Offset: 0x2AD5FC1 VA: 0x2AD5EC0
	|-LinkedListIndex<int, TablePair>.Find
	|
	|-RVA: 0x2AD61C0 Offset: 0x2AD62C1 VA: 0x2AD61C0
	|-LinkedListIndex<object, object>.Find
	*/

	// RVA: -1 Offset: -1
	public TValue Set(TKey key, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AD5F10 Offset: 0x2AD6011 VA: 0x2AD5F10
	|-LinkedListIndex<int, TablePair>.Set
	|
	|-RVA: 0x2AD6210 Offset: 0x2AD6311 VA: 0x2AD6210
	|-LinkedListIndex<object, object>.Set
	|
	|-RVA: 0x2AD64F0 Offset: 0x2AD65F1 VA: 0x2AD64F0
	|-LinkedListIndex<object, TablePair>.Set
	*/

	// RVA: -1 Offset: -1
	public void Add(TKey key, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AD5FE0 Offset: 0x2AD60E1 VA: 0x2AD5FE0
	|-LinkedListIndex<int, TablePair>.Add
	|
	|-RVA: 0x2AD62C0 Offset: 0x2AD63C1 VA: 0x2AD62C0
	|-LinkedListIndex<object, object>.Add
	|
	|-RVA: 0x2AD65C0 Offset: 0x2AD66C1 VA: 0x2AD65C0
	|-LinkedListIndex<object, TablePair>.Add
	*/

	// RVA: -1 Offset: -1
	public bool Remove(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AD60B0 Offset: 0x2AD61B1 VA: 0x2AD60B0
	|-LinkedListIndex<int, TablePair>.Remove
	|
	|-RVA: 0x2AD6390 Offset: 0x2AD6491 VA: 0x2AD6390
	|-LinkedListIndex<object, object>.Remove
	|
	|-RVA: 0x2AD6690 Offset: 0x2AD6791 VA: 0x2AD6690
	|-LinkedListIndex<object, TablePair>.Remove
	*/

	// RVA: -1 Offset: -1
	public bool ContainsKey(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AD6140 Offset: 0x2AD6241 VA: 0x2AD6140
	|-LinkedListIndex<int, TablePair>.ContainsKey
	|
	|-RVA: 0x2AD6420 Offset: 0x2AD6521 VA: 0x2AD6420
	|-LinkedListIndex<object, object>.ContainsKey
	|
	|-RVA: 0x2AD6720 Offset: 0x2AD6821 VA: 0x2AD6720
	|-LinkedListIndex<object, TablePair>.ContainsKey
	*/

	// RVA: -1 Offset: -1
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AD6740 Offset: 0x2AD6841 VA: 0x2AD6740
	|-LinkedListIndex<DynValue, TablePair>.Clear
	|-LinkedListIndex<object, TablePair>.Clear
	|-LinkedListIndex<string, TablePair>.Clear
	|
	|-RVA: 0x2AD6160 Offset: 0x2AD6261 VA: 0x2AD6160
	|-LinkedListIndex<int, TablePair>.Clear
	|
	|-RVA: 0x2AD6440 Offset: 0x2AD6541 VA: 0x2AD6440
	|-LinkedListIndex<object, object>.Clear
	*/
}

