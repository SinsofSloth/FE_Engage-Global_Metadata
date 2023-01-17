// Namespace: App
[DefaultMemberAttribute] // RVA: 0x275280 Offset: 0x275381 VA: 0x275280
public class RawStructList<T> // TypeDefIndex: 9211
{
	// Fields
	public int Count; // 0x0
	public T[] Values; // 0x0

	// Properties
	public int Capacity { get; }
	public T Item { get; set; }

	// Methods

	// RVA: -1 Offset: -1
	public int get_Capacity() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A8D2E0 Offset: 0x2A8D3E1 VA: 0x2A8D2E0
	|-RawStructList<Color>.get_Capacity
	|
	|-RVA: 0x2A8D720 Offset: 0x2A8D821 VA: 0x2A8D720
	|-RawStructList<Vector2>.get_Capacity
	|
	|-RVA: 0x2A8DAF0 Offset: 0x2A8DBF1 VA: 0x2A8DAF0
	|-RawStructList<Vector3>.get_Capacity
	|
	|-RVA: 0x2A8DF30 Offset: 0x2A8E031 VA: 0x2A8DF30
	|-RawStructList<Vector4>.get_Capacity
	*/

	// RVA: -1 Offset: -1
	public void .ctor(int capacity) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A8D2F0 Offset: 0x2A8D3F1 VA: 0x2A8D2F0
	|-RawStructList<Color>..ctor
	|
	|-RVA: 0x2A8D730 Offset: 0x2A8D831 VA: 0x2A8D730
	|-RawStructList<Vector2>..ctor
	|
	|-RVA: 0x2A8DB00 Offset: 0x2A8DC01 VA: 0x2A8DB00
	|-RawStructList<Vector3>..ctor
	|
	|-RVA: 0x2A8DF40 Offset: 0x2A8E041 VA: 0x2A8DF40
	|-RawStructList<Vector4>..ctor
	*/

	// RVA: -1 Offset: -1
	public T Get(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A8D360 Offset: 0x2A8D461 VA: 0x2A8D360
	|-RawStructList<Color>.Get
	|
	|-RVA: 0x2A8D7A0 Offset: 0x2A8D8A1 VA: 0x2A8D7A0
	|-RawStructList<Vector2>.Get
	|
	|-RVA: 0x2A8DB70 Offset: 0x2A8DC71 VA: 0x2A8DB70
	|-RawStructList<Vector3>.Get
	|
	|-RVA: 0x2A8DFB0 Offset: 0x2A8E0B1 VA: 0x2A8DFB0
	|-RawStructList<Vector4>.Get
	*/

	// RVA: -1 Offset: -1
	public void Set(int index, in T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A8D3A0 Offset: 0x2A8D4A1 VA: 0x2A8D3A0
	|-RawStructList<Color>.Set
	|
	|-RVA: 0x2A8D7E0 Offset: 0x2A8D8E1 VA: 0x2A8D7E0
	|-RawStructList<Vector2>.Set
	|
	|-RVA: 0x2A8DBB0 Offset: 0x2A8DCB1 VA: 0x2A8DBB0
	|-RawStructList<Vector3>.Set
	|
	|-RVA: 0x2A8DFF0 Offset: 0x2A8E0F1 VA: 0x2A8DFF0
	|-RawStructList<Vector4>.Set
	*/

	// RVA: -1 Offset: -1
	public void Add(in T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A8D3F0 Offset: 0x2A8D4F1 VA: 0x2A8D3F0
	|-RawStructList<Color>.Add
	|
	|-RVA: 0x2A8D820 Offset: 0x2A8D921 VA: 0x2A8D820
	|-RawStructList<Vector2>.Add
	|
	|-RVA: 0x2A8DC00 Offset: 0x2A8DD01 VA: 0x2A8DC00
	|-RawStructList<Vector3>.Add
	|
	|-RVA: 0x2A8E040 Offset: 0x2A8E141 VA: 0x2A8E040
	|-RawStructList<Vector4>.Add
	*/

	// RVA: -1 Offset: -1
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A8D440 Offset: 0x2A8D541 VA: 0x2A8D440
	|-RawStructList<Color>.Clear
	|
	|-RVA: 0x2A8D870 Offset: 0x2A8D971 VA: 0x2A8D870
	|-RawStructList<Vector2>.Clear
	|
	|-RVA: 0x2A8DC50 Offset: 0x2A8DD51 VA: 0x2A8DC50
	|-RawStructList<Vector3>.Clear
	|
	|-RVA: 0x2A8E090 Offset: 0x2A8E191 VA: 0x2A8E090
	|-RawStructList<Vector4>.Clear
	*/

	// RVA: -1 Offset: -1
	public void RemoveAt(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A8D450 Offset: 0x2A8D551 VA: 0x2A8D450
	|-RawStructList<Color>.RemoveAt
	|
	|-RVA: 0x2A8D880 Offset: 0x2A8D981 VA: 0x2A8D880
	|-RawStructList<Vector2>.RemoveAt
	|
	|-RVA: 0x2A8DC60 Offset: 0x2A8DD61 VA: 0x2A8DC60
	|-RawStructList<Vector3>.RemoveAt
	|
	|-RVA: 0x2A8E0A0 Offset: 0x2A8E1A1 VA: 0x2A8E0A0
	|-RawStructList<Vector4>.RemoveAt
	*/

	// RVA: -1 Offset: -1
	public void Insert(int index, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A8D4E0 Offset: 0x2A8D5E1 VA: 0x2A8D4E0
	|-RawStructList<Color>.Insert
	|
	|-RVA: 0x2A8D900 Offset: 0x2A8DA01 VA: 0x2A8D900
	|-RawStructList<Vector2>.Insert
	|
	|-RVA: 0x2A8DCF0 Offset: 0x2A8DDF1 VA: 0x2A8DCF0
	|-RawStructList<Vector3>.Insert
	|
	|-RVA: 0x2A8E130 Offset: 0x2A8E231 VA: 0x2A8E130
	|-RawStructList<Vector4>.Insert
	*/

	// RVA: -1 Offset: -1
	public void Swap(int index1, int index2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A8D5F0 Offset: 0x2A8D6F1 VA: 0x2A8D5F0
	|-RawStructList<Color>.Swap
	|
	|-RVA: 0x2A8D9F0 Offset: 0x2A8DAF1 VA: 0x2A8D9F0
	|-RawStructList<Vector2>.Swap
	|
	|-RVA: 0x2A8DE00 Offset: 0x2A8DF01 VA: 0x2A8DE00
	|-RawStructList<Vector3>.Swap
	|
	|-RVA: 0x2A8E240 Offset: 0x2A8E341 VA: 0x2A8E240
	|-RawStructList<Vector4>.Swap
	*/

	// RVA: -1 Offset: -1
	public T get_Item(int i) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A8D690 Offset: 0x2A8D791 VA: 0x2A8D690
	|-RawStructList<Color>.get_Item
	|
	|-RVA: 0x2A8DA70 Offset: 0x2A8DB71 VA: 0x2A8DA70
	|-RawStructList<Vector2>.get_Item
	|
	|-RVA: 0x2A8DEA0 Offset: 0x2A8DFA1 VA: 0x2A8DEA0
	|-RawStructList<Vector3>.get_Item
	|
	|-RVA: 0x2A8E2E0 Offset: 0x2A8E3E1 VA: 0x2A8E2E0
	|-RawStructList<Vector4>.get_Item
	*/

	// RVA: -1 Offset: -1
	public void set_Item(int i, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A8D6D0 Offset: 0x2A8D7D1 VA: 0x2A8D6D0
	|-RawStructList<Color>.set_Item
	|
	|-RVA: 0x2A8DAB0 Offset: 0x2A8DBB1 VA: 0x2A8DAB0
	|-RawStructList<Vector2>.set_Item
	|
	|-RVA: 0x2A8DEE0 Offset: 0x2A8DFE1 VA: 0x2A8DEE0
	|-RawStructList<Vector3>.set_Item
	|
	|-RVA: 0x2A8E320 Offset: 0x2A8E421 VA: 0x2A8E320
	|-RawStructList<Vector4>.set_Item
	*/
}

