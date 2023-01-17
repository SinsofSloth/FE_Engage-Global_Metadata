// Namespace: 
[Serializable]
public struct Dictionary.ValueCollection.Enumerator<TKey, TValue> : IEnumerator<TValue>, IDisposable, IEnumerator // TypeDefIndex: 1405
{
	// Fields
	private Dictionary<TKey, TValue> dictionary; // 0x0
	private int index; // 0x0
	private int version; // 0x0
	private TValue currentValue; // 0x0

	// Properties
	public TValue Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(Dictionary<TKey, TValue> dictionary) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x349AA30 Offset: 0x349AB31 VA: 0x349AA30
	|-Dictionary.ValueCollection.Enumerator<ValueTuple<object, int>, object>..ctor
	|
	|-RVA: 0x349B660 Offset: 0x349B761 VA: 0x349B660
	|-Dictionary.ValueCollection.Enumerator<byte, object>..ctor
	|
	|-RVA: 0x349C2A0 Offset: 0x349C3A1 VA: 0x349C2A0
	|-Dictionary.ValueCollection.Enumerator<CancellationToken, object>..ctor
	|
	|-RVA: 0x349CED0 Offset: 0x349CFD1 VA: 0x349CED0
	|-Dictionary.ValueCollection.Enumerator<char, object>..ctor
	|
	|-RVA: 0x349DB60 Offset: 0x349DC61 VA: 0x349DB60
	|-Dictionary.ValueCollection.Enumerator<Guid, object>..ctor
	|
	|-RVA: 0x349F300 Offset: 0x349F401 VA: 0x349F300
	|-Dictionary.ValueCollection.Enumerator<int, bool>..ctor
	|
	|-RVA: 0x34A0840 Offset: 0x34A0941 VA: 0x34A0840
	|-Dictionary.ValueCollection.Enumerator<int, byte>..ctor
	|
	|-RVA: 0x34A15A0 Offset: 0x34A16A1 VA: 0x34A15A0
	|-Dictionary.ValueCollection.Enumerator<int, char>..ctor
	|
	|-RVA: 0x34A23E0 Offset: 0x34A24E1 VA: 0x34A23E0
	|-Dictionary.ValueCollection.Enumerator<int, DiagnosticEvent>..ctor
	|
	|-RVA: 0x34A3C30 Offset: 0x34A3D31 VA: 0x34A3C30
	|-Dictionary.ValueCollection.Enumerator<int, int>..ctor
	|
	|-RVA: 0x34A5170 Offset: 0x34A5271 VA: 0x34A5170
	|-Dictionary.ValueCollection.Enumerator<int, Int32Enum>..ctor
	|
	|-RVA: 0x34A5EF0 Offset: 0x34A5FF1 VA: 0x34A5EF0
	|-Dictionary.ValueCollection.Enumerator<int, long>..ctor
	|
	|-RVA: 0x34A6C90 Offset: 0x34A6D91 VA: 0x34A6C90
	|-Dictionary.ValueCollection.Enumerator<int, MapPos>..ctor
	|
	|-RVA: 0x34A7900 Offset: 0x34A7A01 VA: 0x34A7900
	|-Dictionary.ValueCollection.Enumerator<int, object>..ctor
	|
	|-RVA: 0x34A8630 Offset: 0x34A8731 VA: 0x34A8630
	|-Dictionary.ValueCollection.Enumerator<int, uint>..ctor
	|
	|-RVA: 0x34A9390 Offset: 0x34A9491 VA: 0x34A9390
	|-Dictionary.ValueCollection.Enumerator<int, AIThink.EnchantThink.SurroundingInfo>..ctor
	|
	|-RVA: 0x34AA100 Offset: 0x34AA201 VA: 0x34AA100
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, bool>..ctor
	|
	|-RVA: 0x34AAE60 Offset: 0x34AAF61 VA: 0x34AAE60
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, int>..ctor
	|
	|-RVA: 0x35CCFC0 Offset: 0x35CD0C1 VA: 0x35CCFC0
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, Int32Enum>..ctor
	|
	|-RVA: 0x35CDC20 Offset: 0x35CDD21 VA: 0x35CDC20
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, object>..ctor
	|
	|-RVA: 0x35CE850 Offset: 0x35CE951 VA: 0x35CE850
	|-Dictionary.ValueCollection.Enumerator<long, object>..ctor
	|
	|-RVA: 0x35CF5B0 Offset: 0x35CF6B1 VA: 0x35CF5B0
	|-Dictionary.ValueCollection.Enumerator<MapPos, int>..ctor
	|
	|-RVA: 0x35D0240 Offset: 0x35D0341 VA: 0x35D0240
	|-Dictionary.ValueCollection.Enumerator<object, AsyncOperationHandle<object>>..ctor
	|
	|-RVA: 0x35D0F00 Offset: 0x35D1001 VA: 0x35D0F00
	|-Dictionary.ValueCollection.Enumerator<object, AsyncOperationHandle>..ctor
	|
	|-RVA: 0x35D1B80 Offset: 0x35D1C81 VA: 0x35D1B80
	|-Dictionary.ValueCollection.Enumerator<object, bool>..ctor
	|
	|-RVA: 0x35D27C0 Offset: 0x35D28C1 VA: 0x35D27C0
	|-Dictionary.ValueCollection.Enumerator<object, byte>..ctor
	|
	|-RVA: 0x35D3400 Offset: 0x35D3501 VA: 0x35D3400
	|-Dictionary.ValueCollection.Enumerator<object, int>..ctor
	|
	|-RVA: 0x35D4040 Offset: 0x35D4141 VA: 0x35D4040
	|-Dictionary.ValueCollection.Enumerator<object, Int32Enum>..ctor
	|
	|-RVA: 0x35D4C80 Offset: 0x35D4D81 VA: 0x35D4C80
	|-Dictionary.ValueCollection.Enumerator<object, IntPtr>..ctor
	|
	|-RVA: 0x35D5FD0 Offset: 0x35D60D1 VA: 0x35D5FD0
	|-Dictionary.ValueCollection.Enumerator<object, object>..ctor
	|
	|-RVA: 0x35D7350 Offset: 0x35D7451 VA: 0x35D7350
	|-Dictionary.ValueCollection.Enumerator<object, Playable>..ctor
	|
	|-RVA: 0x35D7FF0 Offset: 0x35D80F1 VA: 0x35D7FF0
	|-Dictionary.ValueCollection.Enumerator<object, ResourceLocator>..ctor
	|
	|-RVA: 0x35D8C50 Offset: 0x35D8D51 VA: 0x35D8C50
	|-Dictionary.ValueCollection.Enumerator<object, float>..ctor
	|
	|-RVA: 0x35D9890 Offset: 0x35D9991 VA: 0x35D9890
	|-Dictionary.ValueCollection.Enumerator<object, ushort>..ctor
	|
	|-RVA: 0x35DA530 Offset: 0x35DA631 VA: 0x35DA530
	|-Dictionary.ValueCollection.Enumerator<object, GameVariable.Value>..ctor
	|
	|-RVA: 0x35DB310 Offset: 0x35DB411 VA: 0x35DB310
	|-Dictionary.ValueCollection.Enumerator<sbyte, DataStoreRatingInfo>..ctor
	|
	|-RVA: 0x35DBFB0 Offset: 0x35DC0B1 VA: 0x35DBFB0
	|-Dictionary.ValueCollection.Enumerator<sbyte, object>..ctor
	|
	|-RVA: 0x35DCCE0 Offset: 0x35DCDE1 VA: 0x35DCCE0
	|-Dictionary.ValueCollection.Enumerator<ushort, int>..ctor
	|
	|-RVA: 0x37621F0 Offset: 0x37622F1 VA: 0x37621F0
	|-Dictionary.ValueCollection.Enumerator<uint, int>..ctor
	|
	|-RVA: 0x3762E50 Offset: 0x3762F51 VA: 0x3762E50
	|-Dictionary.ValueCollection.Enumerator<uint, object>..ctor
	|
	|-RVA: 0x3763C00 Offset: 0x3763D01 VA: 0x3763C00
	|-Dictionary.ValueCollection.Enumerator<ulong, Friend>..ctor
	|
	|-RVA: 0x37649D0 Offset: 0x3764AD1 VA: 0x37649D0
	|-Dictionary.ValueCollection.Enumerator<ulong, Int32Enum>..ctor
	|
	|-RVA: 0x3765640 Offset: 0x3765741 VA: 0x3765640
	|-Dictionary.ValueCollection.Enumerator<ulong, object>..ctor
	|
	|-RVA: 0x37663D0 Offset: 0x37664D1 VA: 0x37663D0
	|-Dictionary.ValueCollection.Enumerator<Vector3, int>..ctor
	|
	|-RVA: 0x3767200 Offset: 0x3767301 VA: 0x3767200
	|-Dictionary.ValueCollection.Enumerator<XPathNodeRef, XPathNodeRef>..ctor
	|
	|-RVA: 0x3767E90 Offset: 0x3767F91 VA: 0x3767E90
	|-Dictionary.ValueCollection.Enumerator<TerrainUtility.TerrainMap.TileCoord, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x349AA70 Offset: 0x349AB71 VA: 0x349AA70
	|-Dictionary.ValueCollection.Enumerator<ValueTuple<object, int>, object>.Dispose
	|
	|-RVA: 0x349B6A0 Offset: 0x349B7A1 VA: 0x349B6A0
	|-Dictionary.ValueCollection.Enumerator<byte, object>.Dispose
	|
	|-RVA: 0x349C2E0 Offset: 0x349C3E1 VA: 0x349C2E0
	|-Dictionary.ValueCollection.Enumerator<CancellationToken, object>.Dispose
	|
	|-RVA: 0x349CF10 Offset: 0x349D011 VA: 0x349CF10
	|-Dictionary.ValueCollection.Enumerator<char, object>.Dispose
	|
	|-RVA: 0x349DBA0 Offset: 0x349DCA1 VA: 0x349DBA0
	|-Dictionary.ValueCollection.Enumerator<Guid, object>.Dispose
	|
	|-RVA: 0x349F340 Offset: 0x349F441 VA: 0x349F340
	|-Dictionary.ValueCollection.Enumerator<int, bool>.Dispose
	|
	|-RVA: 0x34A0880 Offset: 0x34A0981 VA: 0x34A0880
	|-Dictionary.ValueCollection.Enumerator<int, byte>.Dispose
	|
	|-RVA: 0x34A7940 Offset: 0x34A7A41 VA: 0x34A7940
	|-Dictionary.ValueCollection.Enumerator<int, CalculatorCommand>.Dispose
	|-Dictionary.ValueCollection.Enumerator<int, GameObject>.Dispose
	|-Dictionary.ValueCollection.Enumerator<int, object>.Dispose
	|-Dictionary.ValueCollection.Enumerator<int, PointerEventData>.Dispose
	|-Dictionary.ValueCollection.Enumerator<int, ResourceGameObject>.Dispose
	|-Dictionary.ValueCollection.Enumerator<int, MapHistory.Rewind.OverlapData>.Dispose
	|
	|-RVA: 0x34A15E0 Offset: 0x34A16E1 VA: 0x34A15E0
	|-Dictionary.ValueCollection.Enumerator<int, char>.Dispose
	|
	|-RVA: 0x34A2420 Offset: 0x34A2521 VA: 0x34A2420
	|-Dictionary.ValueCollection.Enumerator<int, DiagnosticEvent>.Dispose
	|
	|-RVA: 0x34A3C70 Offset: 0x34A3D71 VA: 0x34A3C70
	|-Dictionary.ValueCollection.Enumerator<int, int>.Dispose
	|
	|-RVA: 0x34A51B0 Offset: 0x34A52B1 VA: 0x34A51B0
	|-Dictionary.ValueCollection.Enumerator<int, Int32Enum>.Dispose
	|
	|-RVA: 0x34A5F30 Offset: 0x34A6031 VA: 0x34A5F30
	|-Dictionary.ValueCollection.Enumerator<int, long>.Dispose
	|
	|-RVA: 0x34A6CD0 Offset: 0x34A6DD1 VA: 0x34A6CD0
	|-Dictionary.ValueCollection.Enumerator<int, MapPos>.Dispose
	|
	|-RVA: 0x34A8670 Offset: 0x34A8771 VA: 0x34A8670
	|-Dictionary.ValueCollection.Enumerator<int, uint>.Dispose
	|
	|-RVA: 0x34A93D0 Offset: 0x34A94D1 VA: 0x34A93D0
	|-Dictionary.ValueCollection.Enumerator<int, AIThink.EnchantThink.SurroundingInfo>.Dispose
	|
	|-RVA: 0x34AA140 Offset: 0x34AA241 VA: 0x34AA140
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, bool>.Dispose
	|
	|-RVA: 0x34AAEA0 Offset: 0x34AAFA1 VA: 0x34AAEA0
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, int>.Dispose
	|-Dictionary.ValueCollection.Enumerator<HubAccessManager.MaterialCalculator.Type, int>.Dispose
	|
	|-RVA: 0x35CD000 Offset: 0x35CD101 VA: 0x35CD000
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, Int32Enum>.Dispose
	|
	|-RVA: 0x35CDC60 Offset: 0x35CDD61 VA: 0x35CDC60
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, object>.Dispose
	|
	|-RVA: 0x35CE890 Offset: 0x35CE991 VA: 0x35CE890
	|-Dictionary.ValueCollection.Enumerator<long, object>.Dispose
	|
	|-RVA: 0x35CF5F0 Offset: 0x35CF6F1 VA: 0x35CF5F0
	|-Dictionary.ValueCollection.Enumerator<MapPos, int>.Dispose
	|
	|-RVA: 0x35D0280 Offset: 0x35D0381 VA: 0x35D0280
	|-Dictionary.ValueCollection.Enumerator<object, AsyncOperationHandle<object>>.Dispose
	|
	|-RVA: 0x35D0F40 Offset: 0x35D1041 VA: 0x35D0F40
	|-Dictionary.ValueCollection.Enumerator<object, AsyncOperationHandle>.Dispose
	|-Dictionary.ValueCollection.Enumerator<string, AsyncOperationHandle>.Dispose
	|
	|-RVA: 0x35D1BC0 Offset: 0x35D1CC1 VA: 0x35D1BC0
	|-Dictionary.ValueCollection.Enumerator<object, bool>.Dispose
	|
	|-RVA: 0x35D2800 Offset: 0x35D2901 VA: 0x35D2800
	|-Dictionary.ValueCollection.Enumerator<object, byte>.Dispose
	|
	|-RVA: 0x35D3440 Offset: 0x35D3541 VA: 0x35D3440
	|-Dictionary.ValueCollection.Enumerator<object, int>.Dispose
	|
	|-RVA: 0x35D4080 Offset: 0x35D4181 VA: 0x35D4080
	|-Dictionary.ValueCollection.Enumerator<object, Int32Enum>.Dispose
	|
	|-RVA: 0x35D4CC0 Offset: 0x35D4DC1 VA: 0x35D4CC0
	|-Dictionary.ValueCollection.Enumerator<object, IntPtr>.Dispose
	|
	|-RVA: 0x35D6010 Offset: 0x35D6111 VA: 0x35D6010
	|-Dictionary.ValueCollection.Enumerator<object, object>.Dispose
	|-Dictionary.ValueCollection.Enumerator<string, FileData>.Dispose
	|-Dictionary.ValueCollection.Enumerator<string, GodBond>.Dispose
	|-Dictionary.ValueCollection.Enumerator<string, LabelStatement>.Dispose
	|-Dictionary.ValueCollection.Enumerator<string, ResourceHandle>.Dispose
	|-Dictionary.ValueCollection.Enumerator<string, SchemaNotation>.Dispose
	|-Dictionary.ValueCollection.Enumerator<string, Sprite>.Dispose
	|-Dictionary.ValueCollection.Enumerator<string, string>.Dispose
	|-Dictionary.ValueCollection.Enumerator<string, SymbolRef>.Dispose
	|-Dictionary.ValueCollection.Enumerator<string, Transform>.Dispose
	|-Dictionary.ValueCollection.Enumerator<string, UnitRelianceData>.Dispose
	|-Dictionary.ValueCollection.Enumerator<string, DtdParser.UndeclaredNotation>.Dispose
	|-Dictionary.ValueCollection.Enumerator<string, EventDemoSequence.CharacterWork>.Dispose
	|-Dictionary.ValueCollection.Enumerator<string, EventDemoSequence.SplitViewWork>.Dispose
	|-Dictionary.ValueCollection.Enumerator<XmlQualifiedName, SchemaAttDef>.Dispose
	|-Dictionary.ValueCollection.Enumerator<XmlQualifiedName, SchemaElementDecl>.Dispose
	|-Dictionary.ValueCollection.Enumerator<XmlQualifiedName, SchemaEntity>.Dispose
	|
	|-RVA: 0x35D7390 Offset: 0x35D7491 VA: 0x35D7390
	|-Dictionary.ValueCollection.Enumerator<object, Playable>.Dispose
	|
	|-RVA: 0x35D8030 Offset: 0x35D8131 VA: 0x35D8030
	|-Dictionary.ValueCollection.Enumerator<object, ResourceLocator>.Dispose
	|
	|-RVA: 0x35D8C90 Offset: 0x35D8D91 VA: 0x35D8C90
	|-Dictionary.ValueCollection.Enumerator<object, float>.Dispose
	|
	|-RVA: 0x35D98D0 Offset: 0x35D99D1 VA: 0x35D98D0
	|-Dictionary.ValueCollection.Enumerator<object, ushort>.Dispose
	|
	|-RVA: 0x35DA570 Offset: 0x35DA671 VA: 0x35DA570
	|-Dictionary.ValueCollection.Enumerator<object, GameVariable.Value>.Dispose
	|
	|-RVA: 0x35DB350 Offset: 0x35DB451 VA: 0x35DB350
	|-Dictionary.ValueCollection.Enumerator<sbyte, DataStoreRatingInfo>.Dispose
	|
	|-RVA: 0x35DBFF0 Offset: 0x35DC0F1 VA: 0x35DBFF0
	|-Dictionary.ValueCollection.Enumerator<sbyte, object>.Dispose
	|
	|-RVA: 0x35DCD20 Offset: 0x35DCE21 VA: 0x35DCD20
	|-Dictionary.ValueCollection.Enumerator<ushort, int>.Dispose
	|
	|-RVA: 0x3762230 Offset: 0x3762331 VA: 0x3762230
	|-Dictionary.ValueCollection.Enumerator<uint, int>.Dispose
	|
	|-RVA: 0x3762E90 Offset: 0x3762F91 VA: 0x3762E90
	|-Dictionary.ValueCollection.Enumerator<uint, object>.Dispose
	|
	|-RVA: 0x3763C40 Offset: 0x3763D41 VA: 0x3763C40
	|-Dictionary.ValueCollection.Enumerator<ulong, Friend>.Dispose
	|
	|-RVA: 0x3764A10 Offset: 0x3764B11 VA: 0x3764A10
	|-Dictionary.ValueCollection.Enumerator<ulong, Int32Enum>.Dispose
	|
	|-RVA: 0x3765680 Offset: 0x3765781 VA: 0x3765680
	|-Dictionary.ValueCollection.Enumerator<ulong, object>.Dispose
	|
	|-RVA: 0x3766410 Offset: 0x3766511 VA: 0x3766410
	|-Dictionary.ValueCollection.Enumerator<Vector3, int>.Dispose
	|
	|-RVA: 0x3767240 Offset: 0x3767341 VA: 0x3767240
	|-Dictionary.ValueCollection.Enumerator<XPathNodeRef, XPathNodeRef>.Dispose
	|
	|-RVA: 0x3767ED0 Offset: 0x3767FD1 VA: 0x3767ED0
	|-Dictionary.ValueCollection.Enumerator<TerrainUtility.TerrainMap.TileCoord, object>.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x349AA80 Offset: 0x349AB81 VA: 0x349AA80
	|-Dictionary.ValueCollection.Enumerator<ValueTuple<object, int>, object>.MoveNext
	|
	|-RVA: 0x349B6B0 Offset: 0x349B7B1 VA: 0x349B6B0
	|-Dictionary.ValueCollection.Enumerator<byte, object>.MoveNext
	|
	|-RVA: 0x349C2F0 Offset: 0x349C3F1 VA: 0x349C2F0
	|-Dictionary.ValueCollection.Enumerator<CancellationToken, object>.MoveNext
	|
	|-RVA: 0x349CF20 Offset: 0x349D021 VA: 0x349CF20
	|-Dictionary.ValueCollection.Enumerator<char, object>.MoveNext
	|
	|-RVA: 0x349DBB0 Offset: 0x349DCB1 VA: 0x349DBB0
	|-Dictionary.ValueCollection.Enumerator<Guid, object>.MoveNext
	|
	|-RVA: 0x349F350 Offset: 0x349F451 VA: 0x349F350
	|-Dictionary.ValueCollection.Enumerator<int, bool>.MoveNext
	|
	|-RVA: 0x34A0890 Offset: 0x34A0991 VA: 0x34A0890
	|-Dictionary.ValueCollection.Enumerator<int, byte>.MoveNext
	|
	|-RVA: 0x34A7950 Offset: 0x34A7A51 VA: 0x34A7950
	|-Dictionary.ValueCollection.Enumerator<int, CalculatorCommand>.MoveNext
	|-Dictionary.ValueCollection.Enumerator<int, GameObject>.MoveNext
	|-Dictionary.ValueCollection.Enumerator<int, object>.MoveNext
	|-Dictionary.ValueCollection.Enumerator<int, PointerEventData>.MoveNext
	|-Dictionary.ValueCollection.Enumerator<int, ResourceGameObject>.MoveNext
	|-Dictionary.ValueCollection.Enumerator<int, MapHistory.Rewind.OverlapData>.MoveNext
	|
	|-RVA: 0x34A15F0 Offset: 0x34A16F1 VA: 0x34A15F0
	|-Dictionary.ValueCollection.Enumerator<int, char>.MoveNext
	|
	|-RVA: 0x34A2430 Offset: 0x34A2531 VA: 0x34A2430
	|-Dictionary.ValueCollection.Enumerator<int, DiagnosticEvent>.MoveNext
	|
	|-RVA: 0x34A3C80 Offset: 0x34A3D81 VA: 0x34A3C80
	|-Dictionary.ValueCollection.Enumerator<int, int>.MoveNext
	|
	|-RVA: 0x34A51C0 Offset: 0x34A52C1 VA: 0x34A51C0
	|-Dictionary.ValueCollection.Enumerator<int, Int32Enum>.MoveNext
	|
	|-RVA: 0x34A5F40 Offset: 0x34A6041 VA: 0x34A5F40
	|-Dictionary.ValueCollection.Enumerator<int, long>.MoveNext
	|
	|-RVA: 0x34A6CE0 Offset: 0x34A6DE1 VA: 0x34A6CE0
	|-Dictionary.ValueCollection.Enumerator<int, MapPos>.MoveNext
	|
	|-RVA: 0x34A8680 Offset: 0x34A8781 VA: 0x34A8680
	|-Dictionary.ValueCollection.Enumerator<int, uint>.MoveNext
	|
	|-RVA: 0x34A93E0 Offset: 0x34A94E1 VA: 0x34A93E0
	|-Dictionary.ValueCollection.Enumerator<int, AIThink.EnchantThink.SurroundingInfo>.MoveNext
	|
	|-RVA: 0x34AA150 Offset: 0x34AA251 VA: 0x34AA150
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, bool>.MoveNext
	|
	|-RVA: 0x34AAEB0 Offset: 0x34AAFB1 VA: 0x34AAEB0
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, int>.MoveNext
	|-Dictionary.ValueCollection.Enumerator<HubAccessManager.MaterialCalculator.Type, int>.MoveNext
	|
	|-RVA: 0x35CD010 Offset: 0x35CD111 VA: 0x35CD010
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, Int32Enum>.MoveNext
	|
	|-RVA: 0x35CDC70 Offset: 0x35CDD71 VA: 0x35CDC70
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, object>.MoveNext
	|
	|-RVA: 0x35CE8A0 Offset: 0x35CE9A1 VA: 0x35CE8A0
	|-Dictionary.ValueCollection.Enumerator<long, object>.MoveNext
	|
	|-RVA: 0x35CF600 Offset: 0x35CF701 VA: 0x35CF600
	|-Dictionary.ValueCollection.Enumerator<MapPos, int>.MoveNext
	|
	|-RVA: 0x35D0290 Offset: 0x35D0391 VA: 0x35D0290
	|-Dictionary.ValueCollection.Enumerator<object, AsyncOperationHandle<object>>.MoveNext
	|
	|-RVA: 0x35D0F50 Offset: 0x35D1051 VA: 0x35D0F50
	|-Dictionary.ValueCollection.Enumerator<object, AsyncOperationHandle>.MoveNext
	|-Dictionary.ValueCollection.Enumerator<string, AsyncOperationHandle>.MoveNext
	|
	|-RVA: 0x35D1BD0 Offset: 0x35D1CD1 VA: 0x35D1BD0
	|-Dictionary.ValueCollection.Enumerator<object, bool>.MoveNext
	|
	|-RVA: 0x35D2810 Offset: 0x35D2911 VA: 0x35D2810
	|-Dictionary.ValueCollection.Enumerator<object, byte>.MoveNext
	|
	|-RVA: 0x35D3450 Offset: 0x35D3551 VA: 0x35D3450
	|-Dictionary.ValueCollection.Enumerator<object, int>.MoveNext
	|
	|-RVA: 0x35D4090 Offset: 0x35D4191 VA: 0x35D4090
	|-Dictionary.ValueCollection.Enumerator<object, Int32Enum>.MoveNext
	|
	|-RVA: 0x35D4CD0 Offset: 0x35D4DD1 VA: 0x35D4CD0
	|-Dictionary.ValueCollection.Enumerator<object, IntPtr>.MoveNext
	|
	|-RVA: 0x35D6020 Offset: 0x35D6121 VA: 0x35D6020
	|-Dictionary.ValueCollection.Enumerator<object, object>.MoveNext
	|-Dictionary.ValueCollection.Enumerator<string, FileData>.MoveNext
	|-Dictionary.ValueCollection.Enumerator<string, GodBond>.MoveNext
	|-Dictionary.ValueCollection.Enumerator<string, LabelStatement>.MoveNext
	|-Dictionary.ValueCollection.Enumerator<string, ResourceHandle>.MoveNext
	|-Dictionary.ValueCollection.Enumerator<string, SchemaNotation>.MoveNext
	|-Dictionary.ValueCollection.Enumerator<string, Sprite>.MoveNext
	|-Dictionary.ValueCollection.Enumerator<string, string>.MoveNext
	|-Dictionary.ValueCollection.Enumerator<string, SymbolRef>.MoveNext
	|-Dictionary.ValueCollection.Enumerator<string, Transform>.MoveNext
	|-Dictionary.ValueCollection.Enumerator<string, UnitRelianceData>.MoveNext
	|-Dictionary.ValueCollection.Enumerator<string, DtdParser.UndeclaredNotation>.MoveNext
	|-Dictionary.ValueCollection.Enumerator<string, EventDemoSequence.CharacterWork>.MoveNext
	|-Dictionary.ValueCollection.Enumerator<string, EventDemoSequence.SplitViewWork>.MoveNext
	|-Dictionary.ValueCollection.Enumerator<XmlQualifiedName, SchemaAttDef>.MoveNext
	|-Dictionary.ValueCollection.Enumerator<XmlQualifiedName, SchemaElementDecl>.MoveNext
	|-Dictionary.ValueCollection.Enumerator<XmlQualifiedName, SchemaEntity>.MoveNext
	|
	|-RVA: 0x35D73A0 Offset: 0x35D74A1 VA: 0x35D73A0
	|-Dictionary.ValueCollection.Enumerator<object, Playable>.MoveNext
	|
	|-RVA: 0x35D8040 Offset: 0x35D8141 VA: 0x35D8040
	|-Dictionary.ValueCollection.Enumerator<object, ResourceLocator>.MoveNext
	|
	|-RVA: 0x35D8CA0 Offset: 0x35D8DA1 VA: 0x35D8CA0
	|-Dictionary.ValueCollection.Enumerator<object, float>.MoveNext
	|
	|-RVA: 0x35D98E0 Offset: 0x35D99E1 VA: 0x35D98E0
	|-Dictionary.ValueCollection.Enumerator<object, ushort>.MoveNext
	|
	|-RVA: 0x35DA580 Offset: 0x35DA681 VA: 0x35DA580
	|-Dictionary.ValueCollection.Enumerator<object, GameVariable.Value>.MoveNext
	|
	|-RVA: 0x35DB360 Offset: 0x35DB461 VA: 0x35DB360
	|-Dictionary.ValueCollection.Enumerator<sbyte, DataStoreRatingInfo>.MoveNext
	|
	|-RVA: 0x35DC000 Offset: 0x35DC101 VA: 0x35DC000
	|-Dictionary.ValueCollection.Enumerator<sbyte, object>.MoveNext
	|
	|-RVA: 0x35DCD30 Offset: 0x35DCE31 VA: 0x35DCD30
	|-Dictionary.ValueCollection.Enumerator<ushort, int>.MoveNext
	|
	|-RVA: 0x3762240 Offset: 0x3762341 VA: 0x3762240
	|-Dictionary.ValueCollection.Enumerator<uint, int>.MoveNext
	|
	|-RVA: 0x3762EA0 Offset: 0x3762FA1 VA: 0x3762EA0
	|-Dictionary.ValueCollection.Enumerator<uint, object>.MoveNext
	|
	|-RVA: 0x3763C50 Offset: 0x3763D51 VA: 0x3763C50
	|-Dictionary.ValueCollection.Enumerator<ulong, Friend>.MoveNext
	|
	|-RVA: 0x3764A20 Offset: 0x3764B21 VA: 0x3764A20
	|-Dictionary.ValueCollection.Enumerator<ulong, Int32Enum>.MoveNext
	|
	|-RVA: 0x3765690 Offset: 0x3765791 VA: 0x3765690
	|-Dictionary.ValueCollection.Enumerator<ulong, object>.MoveNext
	|
	|-RVA: 0x3766420 Offset: 0x3766521 VA: 0x3766420
	|-Dictionary.ValueCollection.Enumerator<Vector3, int>.MoveNext
	|
	|-RVA: 0x3767250 Offset: 0x3767351 VA: 0x3767250
	|-Dictionary.ValueCollection.Enumerator<XPathNodeRef, XPathNodeRef>.MoveNext
	|
	|-RVA: 0x3767EE0 Offset: 0x3767FE1 VA: 0x3767EE0
	|-Dictionary.ValueCollection.Enumerator<TerrainUtility.TerrainMap.TileCoord, object>.MoveNext
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public TValue get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x349AB90 Offset: 0x349AC91 VA: 0x349AB90
	|-Dictionary.ValueCollection.Enumerator<ValueTuple<object, int>, object>.get_Current
	|
	|-RVA: 0x349B7C0 Offset: 0x349B8C1 VA: 0x349B7C0
	|-Dictionary.ValueCollection.Enumerator<byte, object>.get_Current
	|
	|-RVA: 0x349C400 Offset: 0x349C501 VA: 0x349C400
	|-Dictionary.ValueCollection.Enumerator<CancellationToken, object>.get_Current
	|
	|-RVA: 0x349D030 Offset: 0x349D131 VA: 0x349D030
	|-Dictionary.ValueCollection.Enumerator<char, object>.get_Current
	|
	|-RVA: 0x349DCC0 Offset: 0x349DDC1 VA: 0x349DCC0
	|-Dictionary.ValueCollection.Enumerator<Guid, object>.get_Current
	|
	|-RVA: 0x349F450 Offset: 0x349F551 VA: 0x349F450
	|-Dictionary.ValueCollection.Enumerator<int, bool>.get_Current
	|
	|-RVA: 0x34A0990 Offset: 0x34A0A91 VA: 0x34A0990
	|-Dictionary.ValueCollection.Enumerator<int, byte>.get_Current
	|
	|-RVA: 0x34A7A60 Offset: 0x34A7B61 VA: 0x34A7A60
	|-Dictionary.ValueCollection.Enumerator<int, CalculatorCommand>.get_Current
	|-Dictionary.ValueCollection.Enumerator<int, GameObject>.get_Current
	|-Dictionary.ValueCollection.Enumerator<int, object>.get_Current
	|-Dictionary.ValueCollection.Enumerator<int, PointerEventData>.get_Current
	|-Dictionary.ValueCollection.Enumerator<int, ResourceGameObject>.get_Current
	|-Dictionary.ValueCollection.Enumerator<int, MapHistory.Rewind.OverlapData>.get_Current
	|
	|-RVA: 0x34A16F0 Offset: 0x34A17F1 VA: 0x34A16F0
	|-Dictionary.ValueCollection.Enumerator<int, char>.get_Current
	|
	|-RVA: 0x34A2550 Offset: 0x34A2651 VA: 0x34A2550
	|-Dictionary.ValueCollection.Enumerator<int, DiagnosticEvent>.get_Current
	|
	|-RVA: 0x34A3D80 Offset: 0x34A3E81 VA: 0x34A3D80
	|-Dictionary.ValueCollection.Enumerator<int, int>.get_Current
	|
	|-RVA: 0x34A52C0 Offset: 0x34A53C1 VA: 0x34A52C0
	|-Dictionary.ValueCollection.Enumerator<int, Int32Enum>.get_Current
	|
	|-RVA: 0x34A6050 Offset: 0x34A6151 VA: 0x34A6050
	|-Dictionary.ValueCollection.Enumerator<int, long>.get_Current
	|
	|-RVA: 0x34A6DF0 Offset: 0x34A6EF1 VA: 0x34A6DF0
	|-Dictionary.ValueCollection.Enumerator<int, MapPos>.get_Current
	|
	|-RVA: 0x34A8780 Offset: 0x34A8881 VA: 0x34A8780
	|-Dictionary.ValueCollection.Enumerator<int, uint>.get_Current
	|
	|-RVA: 0x34A94E0 Offset: 0x34A95E1 VA: 0x34A94E0
	|-Dictionary.ValueCollection.Enumerator<int, AIThink.EnchantThink.SurroundingInfo>.get_Current
	|
	|-RVA: 0x34AA250 Offset: 0x34AA351 VA: 0x34AA250
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, bool>.get_Current
	|
	|-RVA: 0x34AAFB0 Offset: 0x34AB0B1 VA: 0x34AAFB0
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, int>.get_Current
	|-Dictionary.ValueCollection.Enumerator<HubAccessManager.MaterialCalculator.Type, int>.get_Current
	|
	|-RVA: 0x35CD110 Offset: 0x35CD211 VA: 0x35CD110
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, Int32Enum>.get_Current
	|
	|-RVA: 0x35CDD80 Offset: 0x35CDE81 VA: 0x35CDD80
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, object>.get_Current
	|
	|-RVA: 0x35CE9B0 Offset: 0x35CEAB1 VA: 0x35CE9B0
	|-Dictionary.ValueCollection.Enumerator<long, object>.get_Current
	|
	|-RVA: 0x35CF710 Offset: 0x35CF811 VA: 0x35CF710
	|-Dictionary.ValueCollection.Enumerator<MapPos, int>.get_Current
	|
	|-RVA: 0x35D03B0 Offset: 0x35D04B1 VA: 0x35D03B0
	|-Dictionary.ValueCollection.Enumerator<object, AsyncOperationHandle<object>>.get_Current
	|
	|-RVA: 0x35D1070 Offset: 0x35D1171 VA: 0x35D1070
	|-Dictionary.ValueCollection.Enumerator<object, AsyncOperationHandle>.get_Current
	|-Dictionary.ValueCollection.Enumerator<string, AsyncOperationHandle>.get_Current
	|
	|-RVA: 0x35D1CE0 Offset: 0x35D1DE1 VA: 0x35D1CE0
	|-Dictionary.ValueCollection.Enumerator<object, bool>.get_Current
	|
	|-RVA: 0x35D2920 Offset: 0x35D2A21 VA: 0x35D2920
	|-Dictionary.ValueCollection.Enumerator<object, byte>.get_Current
	|
	|-RVA: 0x35D3560 Offset: 0x35D3661 VA: 0x35D3560
	|-Dictionary.ValueCollection.Enumerator<object, int>.get_Current
	|
	|-RVA: 0x35D41A0 Offset: 0x35D42A1 VA: 0x35D41A0
	|-Dictionary.ValueCollection.Enumerator<object, Int32Enum>.get_Current
	|
	|-RVA: 0x35D4DE0 Offset: 0x35D4EE1 VA: 0x35D4DE0
	|-Dictionary.ValueCollection.Enumerator<object, IntPtr>.get_Current
	|
	|-RVA: 0x35D6130 Offset: 0x35D6231 VA: 0x35D6130
	|-Dictionary.ValueCollection.Enumerator<object, object>.get_Current
	|-Dictionary.ValueCollection.Enumerator<string, FileData>.get_Current
	|-Dictionary.ValueCollection.Enumerator<string, GodBond>.get_Current
	|-Dictionary.ValueCollection.Enumerator<string, LabelStatement>.get_Current
	|-Dictionary.ValueCollection.Enumerator<string, ResourceHandle>.get_Current
	|-Dictionary.ValueCollection.Enumerator<string, SchemaNotation>.get_Current
	|-Dictionary.ValueCollection.Enumerator<string, Sprite>.get_Current
	|-Dictionary.ValueCollection.Enumerator<string, string>.get_Current
	|-Dictionary.ValueCollection.Enumerator<string, SymbolRef>.get_Current
	|-Dictionary.ValueCollection.Enumerator<string, Transform>.get_Current
	|-Dictionary.ValueCollection.Enumerator<string, UnitRelianceData>.get_Current
	|-Dictionary.ValueCollection.Enumerator<string, DtdParser.UndeclaredNotation>.get_Current
	|-Dictionary.ValueCollection.Enumerator<string, EventDemoSequence.CharacterWork>.get_Current
	|-Dictionary.ValueCollection.Enumerator<string, EventDemoSequence.SplitViewWork>.get_Current
	|-Dictionary.ValueCollection.Enumerator<XmlQualifiedName, SchemaAttDef>.get_Current
	|-Dictionary.ValueCollection.Enumerator<XmlQualifiedName, SchemaElementDecl>.get_Current
	|-Dictionary.ValueCollection.Enumerator<XmlQualifiedName, SchemaEntity>.get_Current
	|
	|-RVA: 0x35D74A0 Offset: 0x35D75A1 VA: 0x35D74A0
	|-Dictionary.ValueCollection.Enumerator<object, Playable>.get_Current
	|
	|-RVA: 0x35D8150 Offset: 0x35D8251 VA: 0x35D8150
	|-Dictionary.ValueCollection.Enumerator<object, ResourceLocator>.get_Current
	|
	|-RVA: 0x35D8DB0 Offset: 0x35D8EB1 VA: 0x35D8DB0
	|-Dictionary.ValueCollection.Enumerator<object, float>.get_Current
	|
	|-RVA: 0x35D99F0 Offset: 0x35D9AF1 VA: 0x35D99F0
	|-Dictionary.ValueCollection.Enumerator<object, ushort>.get_Current
	|
	|-RVA: 0x35DA690 Offset: 0x35DA791 VA: 0x35DA690
	|-Dictionary.ValueCollection.Enumerator<object, GameVariable.Value>.get_Current
	|
	|-RVA: 0x35DB480 Offset: 0x35DB581 VA: 0x35DB480
	|-Dictionary.ValueCollection.Enumerator<sbyte, DataStoreRatingInfo>.get_Current
	|
	|-RVA: 0x35DC110 Offset: 0x35DC211 VA: 0x35DC110
	|-Dictionary.ValueCollection.Enumerator<sbyte, object>.get_Current
	|
	|-RVA: 0x35DCE30 Offset: 0x35DCF31 VA: 0x35DCE30
	|-Dictionary.ValueCollection.Enumerator<ushort, int>.get_Current
	|
	|-RVA: 0x3762340 Offset: 0x3762441 VA: 0x3762340
	|-Dictionary.ValueCollection.Enumerator<uint, int>.get_Current
	|
	|-RVA: 0x3762FB0 Offset: 0x37630B1 VA: 0x3762FB0
	|-Dictionary.ValueCollection.Enumerator<uint, object>.get_Current
	|
	|-RVA: 0x3763D70 Offset: 0x3763E71 VA: 0x3763D70
	|-Dictionary.ValueCollection.Enumerator<ulong, Friend>.get_Current
	|
	|-RVA: 0x3764B30 Offset: 0x3764C31 VA: 0x3764B30
	|-Dictionary.ValueCollection.Enumerator<ulong, Int32Enum>.get_Current
	|
	|-RVA: 0x37657A0 Offset: 0x37658A1 VA: 0x37657A0
	|-Dictionary.ValueCollection.Enumerator<ulong, object>.get_Current
	|
	|-RVA: 0x3766530 Offset: 0x3766631 VA: 0x3766530
	|-Dictionary.ValueCollection.Enumerator<Vector3, int>.get_Current
	|
	|-RVA: 0x3767370 Offset: 0x3767471 VA: 0x3767370
	|-Dictionary.ValueCollection.Enumerator<XPathNodeRef, XPathNodeRef>.get_Current
	|
	|-RVA: 0x3767FF0 Offset: 0x37680F1 VA: 0x3767FF0
	|-Dictionary.ValueCollection.Enumerator<TerrainUtility.TerrainMap.TileCoord, object>.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x349ABA0 Offset: 0x349ACA1 VA: 0x349ABA0
	|-Dictionary.ValueCollection.Enumerator<ValueTuple<object, int>, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x349B7D0 Offset: 0x349B8D1 VA: 0x349B7D0
	|-Dictionary.ValueCollection.Enumerator<byte, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x349C410 Offset: 0x349C511 VA: 0x349C410
	|-Dictionary.ValueCollection.Enumerator<CancellationToken, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x349D040 Offset: 0x349D141 VA: 0x349D040
	|-Dictionary.ValueCollection.Enumerator<char, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x349DCD0 Offset: 0x349DDD1 VA: 0x349DCD0
	|-Dictionary.ValueCollection.Enumerator<Guid, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x349F460 Offset: 0x349F561 VA: 0x349F460
	|-Dictionary.ValueCollection.Enumerator<int, bool>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x34A09A0 Offset: 0x34A0AA1 VA: 0x34A09A0
	|-Dictionary.ValueCollection.Enumerator<int, byte>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x34A1700 Offset: 0x34A1801 VA: 0x34A1700
	|-Dictionary.ValueCollection.Enumerator<int, char>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x34A2570 Offset: 0x34A2671 VA: 0x34A2570
	|-Dictionary.ValueCollection.Enumerator<int, DiagnosticEvent>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x34A3D90 Offset: 0x34A3E91 VA: 0x34A3D90
	|-Dictionary.ValueCollection.Enumerator<int, int>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x34A52D0 Offset: 0x34A53D1 VA: 0x34A52D0
	|-Dictionary.ValueCollection.Enumerator<int, Int32Enum>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x34A6060 Offset: 0x34A6161 VA: 0x34A6060
	|-Dictionary.ValueCollection.Enumerator<int, long>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x34A6E00 Offset: 0x34A6F01 VA: 0x34A6E00
	|-Dictionary.ValueCollection.Enumerator<int, MapPos>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x34A7A70 Offset: 0x34A7B71 VA: 0x34A7A70
	|-Dictionary.ValueCollection.Enumerator<int, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x34A8790 Offset: 0x34A8891 VA: 0x34A8790
	|-Dictionary.ValueCollection.Enumerator<int, uint>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x34A94F0 Offset: 0x34A95F1 VA: 0x34A94F0
	|-Dictionary.ValueCollection.Enumerator<int, AIThink.EnchantThink.SurroundingInfo>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x34AA260 Offset: 0x34AA361 VA: 0x34AA260
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, bool>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x34AAFC0 Offset: 0x34AB0C1 VA: 0x34AAFC0
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, int>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x35CD120 Offset: 0x35CD221 VA: 0x35CD120
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, Int32Enum>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x35CDD90 Offset: 0x35CDE91 VA: 0x35CDD90
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x35CE9C0 Offset: 0x35CEAC1 VA: 0x35CE9C0
	|-Dictionary.ValueCollection.Enumerator<long, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x35CF720 Offset: 0x35CF821 VA: 0x35CF720
	|-Dictionary.ValueCollection.Enumerator<MapPos, int>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x35D03D0 Offset: 0x35D04D1 VA: 0x35D03D0
	|-Dictionary.ValueCollection.Enumerator<object, AsyncOperationHandle<object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x35D1090 Offset: 0x35D1191 VA: 0x35D1090
	|-Dictionary.ValueCollection.Enumerator<object, AsyncOperationHandle>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x35D1CF0 Offset: 0x35D1DF1 VA: 0x35D1CF0
	|-Dictionary.ValueCollection.Enumerator<object, bool>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x35D2930 Offset: 0x35D2A31 VA: 0x35D2930
	|-Dictionary.ValueCollection.Enumerator<object, byte>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x35D3570 Offset: 0x35D3671 VA: 0x35D3570
	|-Dictionary.ValueCollection.Enumerator<object, int>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x35D41B0 Offset: 0x35D42B1 VA: 0x35D41B0
	|-Dictionary.ValueCollection.Enumerator<object, Int32Enum>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x35D4DF0 Offset: 0x35D4EF1 VA: 0x35D4DF0
	|-Dictionary.ValueCollection.Enumerator<object, IntPtr>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x35D6140 Offset: 0x35D6241 VA: 0x35D6140
	|-Dictionary.ValueCollection.Enumerator<object, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x35D74B0 Offset: 0x35D75B1 VA: 0x35D74B0
	|-Dictionary.ValueCollection.Enumerator<object, Playable>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x35D8160 Offset: 0x35D8261 VA: 0x35D8160
	|-Dictionary.ValueCollection.Enumerator<object, ResourceLocator>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x35D8DC0 Offset: 0x35D8EC1 VA: 0x35D8DC0
	|-Dictionary.ValueCollection.Enumerator<object, float>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x35D9A00 Offset: 0x35D9B01 VA: 0x35D9A00
	|-Dictionary.ValueCollection.Enumerator<object, ushort>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x35DA6A0 Offset: 0x35DA7A1 VA: 0x35DA6A0
	|-Dictionary.ValueCollection.Enumerator<object, GameVariable.Value>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x35DB4A0 Offset: 0x35DB5A1 VA: 0x35DB4A0
	|-Dictionary.ValueCollection.Enumerator<sbyte, DataStoreRatingInfo>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x35DC120 Offset: 0x35DC221 VA: 0x35DC120
	|-Dictionary.ValueCollection.Enumerator<sbyte, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x35DCE40 Offset: 0x35DCF41 VA: 0x35DCE40
	|-Dictionary.ValueCollection.Enumerator<ushort, int>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x3762350 Offset: 0x3762451 VA: 0x3762350
	|-Dictionary.ValueCollection.Enumerator<uint, int>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x3762FC0 Offset: 0x37630C1 VA: 0x3762FC0
	|-Dictionary.ValueCollection.Enumerator<uint, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x3763D90 Offset: 0x3763E91 VA: 0x3763D90
	|-Dictionary.ValueCollection.Enumerator<ulong, Friend>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x3764B40 Offset: 0x3764C41 VA: 0x3764B40
	|-Dictionary.ValueCollection.Enumerator<ulong, Int32Enum>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x37657B0 Offset: 0x37658B1 VA: 0x37657B0
	|-Dictionary.ValueCollection.Enumerator<ulong, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x3766540 Offset: 0x3766641 VA: 0x3766540
	|-Dictionary.ValueCollection.Enumerator<Vector3, int>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x3767380 Offset: 0x3767481 VA: 0x3767380
	|-Dictionary.ValueCollection.Enumerator<XPathNodeRef, XPathNodeRef>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x3768000 Offset: 0x3768101 VA: 0x3768000
	|-Dictionary.ValueCollection.Enumerator<TerrainUtility.TerrainMap.TileCoord, object>.System.Collections.IEnumerator.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x349AC20 Offset: 0x349AD21 VA: 0x349AC20
	|-Dictionary.ValueCollection.Enumerator<ValueTuple<object, int>, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x349B850 Offset: 0x349B951 VA: 0x349B850
	|-Dictionary.ValueCollection.Enumerator<byte, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x349C490 Offset: 0x349C591 VA: 0x349C490
	|-Dictionary.ValueCollection.Enumerator<CancellationToken, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x349D0C0 Offset: 0x349D1C1 VA: 0x349D0C0
	|-Dictionary.ValueCollection.Enumerator<char, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x349DD50 Offset: 0x349DE51 VA: 0x349DD50
	|-Dictionary.ValueCollection.Enumerator<Guid, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x349F520 Offset: 0x349F621 VA: 0x349F520
	|-Dictionary.ValueCollection.Enumerator<int, bool>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x34A0A60 Offset: 0x34A0B61 VA: 0x34A0A60
	|-Dictionary.ValueCollection.Enumerator<int, byte>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x34A17C0 Offset: 0x34A18C1 VA: 0x34A17C0
	|-Dictionary.ValueCollection.Enumerator<int, char>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x34A2650 Offset: 0x34A2751 VA: 0x34A2650
	|-Dictionary.ValueCollection.Enumerator<int, DiagnosticEvent>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x34A3E50 Offset: 0x34A3F51 VA: 0x34A3E50
	|-Dictionary.ValueCollection.Enumerator<int, int>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x34A5390 Offset: 0x34A5491 VA: 0x34A5390
	|-Dictionary.ValueCollection.Enumerator<int, Int32Enum>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x34A6120 Offset: 0x34A6221 VA: 0x34A6120
	|-Dictionary.ValueCollection.Enumerator<int, long>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x34A6EC0 Offset: 0x34A6FC1 VA: 0x34A6EC0
	|-Dictionary.ValueCollection.Enumerator<int, MapPos>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x34A7AF0 Offset: 0x34A7BF1 VA: 0x34A7AF0
	|-Dictionary.ValueCollection.Enumerator<int, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x34A8850 Offset: 0x34A8951 VA: 0x34A8850
	|-Dictionary.ValueCollection.Enumerator<int, uint>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x34A95B0 Offset: 0x34A96B1 VA: 0x34A95B0
	|-Dictionary.ValueCollection.Enumerator<int, AIThink.EnchantThink.SurroundingInfo>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x34AA320 Offset: 0x34AA421 VA: 0x34AA320
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, bool>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x34AB080 Offset: 0x34AB181 VA: 0x34AB080
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, int>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x35CD1E0 Offset: 0x35CD2E1 VA: 0x35CD1E0
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, Int32Enum>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x35CDE10 Offset: 0x35CDF11 VA: 0x35CDE10
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x35CEA40 Offset: 0x35CEB41 VA: 0x35CEA40
	|-Dictionary.ValueCollection.Enumerator<long, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x35CF7E0 Offset: 0x35CF8E1 VA: 0x35CF7E0
	|-Dictionary.ValueCollection.Enumerator<MapPos, int>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x35D04A0 Offset: 0x35D05A1 VA: 0x35D04A0
	|-Dictionary.ValueCollection.Enumerator<object, AsyncOperationHandle<object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x35D1160 Offset: 0x35D1261 VA: 0x35D1160
	|-Dictionary.ValueCollection.Enumerator<object, AsyncOperationHandle>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x35D1DB0 Offset: 0x35D1EB1 VA: 0x35D1DB0
	|-Dictionary.ValueCollection.Enumerator<object, bool>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x35D29F0 Offset: 0x35D2AF1 VA: 0x35D29F0
	|-Dictionary.ValueCollection.Enumerator<object, byte>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x35D3630 Offset: 0x35D3731 VA: 0x35D3630
	|-Dictionary.ValueCollection.Enumerator<object, int>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x35D4270 Offset: 0x35D4371 VA: 0x35D4270
	|-Dictionary.ValueCollection.Enumerator<object, Int32Enum>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x35D4EB0 Offset: 0x35D4FB1 VA: 0x35D4EB0
	|-Dictionary.ValueCollection.Enumerator<object, IntPtr>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x35D61C0 Offset: 0x35D62C1 VA: 0x35D61C0
	|-Dictionary.ValueCollection.Enumerator<object, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x35D7580 Offset: 0x35D7681 VA: 0x35D7580
	|-Dictionary.ValueCollection.Enumerator<object, Playable>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x35D8230 Offset: 0x35D8331 VA: 0x35D8230
	|-Dictionary.ValueCollection.Enumerator<object, ResourceLocator>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x35D8E80 Offset: 0x35D8F81 VA: 0x35D8E80
	|-Dictionary.ValueCollection.Enumerator<object, float>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x35D9AC0 Offset: 0x35D9BC1 VA: 0x35D9AC0
	|-Dictionary.ValueCollection.Enumerator<object, ushort>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x35DA770 Offset: 0x35DA871 VA: 0x35DA770
	|-Dictionary.ValueCollection.Enumerator<object, GameVariable.Value>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x35DB570 Offset: 0x35DB671 VA: 0x35DB570
	|-Dictionary.ValueCollection.Enumerator<sbyte, DataStoreRatingInfo>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x35DC1A0 Offset: 0x35DC2A1 VA: 0x35DC1A0
	|-Dictionary.ValueCollection.Enumerator<sbyte, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x35DCF00 Offset: 0x35DD001 VA: 0x35DCF00
	|-Dictionary.ValueCollection.Enumerator<ushort, int>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x3762410 Offset: 0x3762511 VA: 0x3762410
	|-Dictionary.ValueCollection.Enumerator<uint, int>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x3763040 Offset: 0x3763141 VA: 0x3763040
	|-Dictionary.ValueCollection.Enumerator<uint, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x3763E60 Offset: 0x3763F61 VA: 0x3763E60
	|-Dictionary.ValueCollection.Enumerator<ulong, Friend>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x3764C00 Offset: 0x3764D01 VA: 0x3764C00
	|-Dictionary.ValueCollection.Enumerator<ulong, Int32Enum>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x3765830 Offset: 0x3765931 VA: 0x3765830
	|-Dictionary.ValueCollection.Enumerator<ulong, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x3766600 Offset: 0x3766701 VA: 0x3766600
	|-Dictionary.ValueCollection.Enumerator<Vector3, int>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x3767450 Offset: 0x3767551 VA: 0x3767450
	|-Dictionary.ValueCollection.Enumerator<XPathNodeRef, XPathNodeRef>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x3768080 Offset: 0x3768181 VA: 0x3768080
	|-Dictionary.ValueCollection.Enumerator<TerrainUtility.TerrainMap.TileCoord, object>.System.Collections.IEnumerator.Reset
	*/
}

