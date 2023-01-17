// Namespace: App
public class StructTemplate<T> : StructBase // TypeDefIndex: 13976
{
	// Fields
	protected static StructHeader s_header; // 0x0
	protected static StructDictionary<T> s_dictionary; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public static StructHeader GetHeader() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36CF630 Offset: 0x36CF731 VA: 0x36CF630
	|-StructTemplate<object>.GetHeader
	*/

	// RVA: -1 Offset: -1
	public static string GetFilePath() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36CF760 Offset: 0x36CF861 VA: 0x36CF760
	|-StructTemplate<DisposData>.GetFilePath
	|-StructTemplate<object>.GetFilePath
	*/

	// RVA: -1 Offset: -1
	public static bool IsExist() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36CF9D0 Offset: 0x36CFAD1 VA: 0x36CF9D0
	|-StructTemplate<EncountJobData>.IsExist
	|-StructTemplate<GameParam>.IsExist
	|-StructTemplate<object>.IsExist
	|-StructTemplate<TerrainCostData>.IsExist
	|-StructTemplate<TerrainData>.IsExist
	*/

	// RVA: -1 Offset: -1
	public static bool IsExist(string name) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36CFB60 Offset: 0x36CFC61 VA: 0x36CFB60
	|-StructTemplate<AIData>.IsExist
	|-StructTemplate<DisposData>.IsExist
	|-StructTemplate<GameParam>.IsExist
	|-StructTemplate<GodData>.IsExist
	|-StructTemplate<ItemData>.IsExist
	|-StructTemplate<object>.IsExist
	|-StructTemplate<PersonData>.IsExist
	|-StructTemplate<TerrainData>.IsExist
	*/

	// RVA: -1 Offset: -1
	protected static T CreateInstance(XmlReader reader, List<StructProperty> propertys, int index, Action<T> publicFunc) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36CFCF0 Offset: 0x36CFDF1 VA: 0x36CFCF0
	|-StructTemplate<object>.CreateInstance
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36D1AC0 Offset: 0x36D1BC1 VA: 0x36D1AC0
	|-StructTemplate<object>..ctor
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36D1AD0 Offset: 0x36D1BD1 VA: 0x36D1AD0
	|-StructTemplate<object>..cctor
	*/
}

