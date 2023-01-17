// Namespace: 
public abstract class StructScriptableData<T> // TypeDefIndex: 7602
{
	// Fields
	private static Dictionary<string, int> s_KeyToIndex; // 0x0
	private static List<T> s_DataList; // 0x0
	private static List<string> s_PublicNames; // 0x0

	// Properties
	public static int Count { get; }
	public static string[] PublicNames { get; }

	// Methods

	// RVA: -1 Offset: -1
	public static bool Load(string path) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36CD980 Offset: 0x36CDA81 VA: 0x36CD980
	|-StructScriptableData<object>.Load
	|-StructScriptableData<TestSampleData>.Load
	*/

	// RVA: -1 Offset: -1
	public static void Unload() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36CE380 Offset: 0x36CE481 VA: 0x36CE380
	|-StructScriptableData<object>.Unload
	|-StructScriptableData<TestSampleData>.Unload
	*/

	// RVA: -1 Offset: -1
	public static int IndexOf(string key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36CE860 Offset: 0x36CE961 VA: 0x36CE860
	|-StructScriptableData<object>.IndexOf
	*/

	// RVA: -1 Offset: -1
	public static T TryGet(string key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36CE9F0 Offset: 0x36CEAF1 VA: 0x36CE9F0
	|-StructScriptableData<object>.TryGet
	*/

	// RVA: -1 Offset: -1
	public static T TryGet(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36CECD0 Offset: 0x36CEDD1 VA: 0x36CECD0
	|-StructScriptableData<object>.TryGet
	*/

	// RVA: -1 Offset: -1
	public static int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36CEE60 Offset: 0x36CEF61 VA: 0x36CEE60
	|-StructScriptableData<object>.get_Count
	*/

	// RVA: -1 Offset: -1
	public static string[] get_PublicNames() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36CEFF0 Offset: 0x36CF0F1 VA: 0x36CEFF0
	|-StructScriptableData<object>.get_PublicNames
	*/

	// RVA: -1 Offset: -1
	public static void Dump() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36CF160 Offset: 0x36CF261 VA: 0x36CF160
	|-StructScriptableData<object>.Dump
	|-StructScriptableData<TestSampleData>.Dump
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public abstract string GetKey();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-StructScriptableData<object>.GetKey
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public virtual void OnBuild() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36CF3F0 Offset: 0x36CF4F1 VA: 0x36CF3F0
	|-StructScriptableData<object>.OnBuild
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public virtual void OnRelease() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36CF400 Offset: 0x36CF501 VA: 0x36CF400
	|-StructScriptableData<object>.OnRelease
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public virtual string GetDebugName() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36CF410 Offset: 0x36CF511 VA: 0x36CF410
	|-StructScriptableData<object>.GetDebugName
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36CF420 Offset: 0x36CF521 VA: 0x36CF420
	|-StructScriptableData<object>..ctor
	|-StructScriptableData<TestSampleData>..ctor
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36CF430 Offset: 0x36CF531 VA: 0x36CF430
	|-StructScriptableData<object>..cctor
	*/
}

