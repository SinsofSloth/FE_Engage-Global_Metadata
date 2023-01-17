// Namespace: 
private struct Dictionary.Entry<TKey, TValue> // TypeDefIndex: 1401
{
	// Fields
	public int hashCode; // 0x0
	public int next; // 0x0
	public TKey key; // 0x0
	public TValue value; // 0x0
}

// Namespace: 
[Serializable]
public struct Dictionary.Enumerator<TKey, TValue> : IEnumerator<KeyValuePair<TKey, TValue>>, IDisposable, IEnumerator, IDictionaryEnumerator // TypeDefIndex: 1402
{
	// Fields
	private Dictionary<TKey, TValue> dictionary; // 0x0
	private int version; // 0x0
	private int index; // 0x0
	private KeyValuePair<TKey, TValue> current; // 0x0
	private int getEnumeratorRetType; // 0x0

	// Properties
	public KeyValuePair<TKey, TValue> Current { get; }
	private object System.Collections.IEnumerator.Current { get; }
	private DictionaryEntry System.Collections.IDictionaryEnumerator.Entry { get; }
	private object System.Collections.IDictionaryEnumerator.Key { get; }
	private object System.Collections.IDictionaryEnumerator.Value { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(Dictionary<TKey, TValue> dictionary, int getEnumeratorRetType) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x349A000 Offset: 0x349A101 VA: 0x349A000
	|-Dictionary.Enumerator<ValueTuple<object, int>, object>..ctor
	|
	|-RVA: 0x349ACA0 Offset: 0x349ADA1 VA: 0x349ACA0
	|-Dictionary.Enumerator<byte, object>..ctor
	|
	|-RVA: 0x349B8D0 Offset: 0x349B9D1 VA: 0x349B8D0
	|-Dictionary.Enumerator<CancellationToken, object>..ctor
	|
	|-RVA: 0x349C510 Offset: 0x349C611 VA: 0x349C510
	|-Dictionary.Enumerator<char, object>..ctor
	|
	|-RVA: 0x349D140 Offset: 0x349D241 VA: 0x349D140
	|-Dictionary.Enumerator<Guid, object>..ctor
	|
	|-RVA: 0x349DDD0 Offset: 0x349DED1 VA: 0x349DDD0
	|-Dictionary.Enumerator<int, bool>..ctor
	|
	|-RVA: 0x349FD80 Offset: 0x349FE81 VA: 0x349FD80
	|-Dictionary.Enumerator<int, byte>..ctor
	|
	|-RVA: 0x34A0AE0 Offset: 0x34A0BE1 VA: 0x34A0AE0
	|-Dictionary.Enumerator<int, char>..ctor
	|
	|-RVA: 0x34A1840 Offset: 0x34A1941 VA: 0x34A1840
	|-Dictionary.Enumerator<int, DiagnosticEvent>..ctor
	|
	|-RVA: 0x34A26E0 Offset: 0x34A27E1 VA: 0x34A26E0
	|-Dictionary.Enumerator<int, int>..ctor
	|
	|-RVA: 0x34A46B0 Offset: 0x34A47B1 VA: 0x34A46B0
	|-Dictionary.Enumerator<int, Int32Enum>..ctor
	|
	|-RVA: 0x34A5410 Offset: 0x34A5511 VA: 0x34A5410
	|-Dictionary.Enumerator<int, long>..ctor
	|
	|-RVA: 0x34A61A0 Offset: 0x34A62A1 VA: 0x34A61A0
	|-Dictionary.Enumerator<int, MapPos>..ctor
	|
	|-RVA: 0x34A6F40 Offset: 0x34A7041 VA: 0x34A6F40
	|-Dictionary.Enumerator<int, object>..ctor
	|
	|-RVA: 0x34A7B70 Offset: 0x34A7C71 VA: 0x34A7B70
	|-Dictionary.Enumerator<int, uint>..ctor
	|
	|-RVA: 0x34A88D0 Offset: 0x34A89D1 VA: 0x34A88D0
	|-Dictionary.Enumerator<int, AIThink.EnchantThink.SurroundingInfo>..ctor
	|
	|-RVA: 0x34A9630 Offset: 0x34A9731 VA: 0x34A9630
	|-Dictionary.Enumerator<Int32Enum, bool>..ctor
	|
	|-RVA: 0x34AA3A0 Offset: 0x34AA4A1 VA: 0x34AA3A0
	|-Dictionary.Enumerator<Int32Enum, int>..ctor
	|
	|-RVA: 0x34AB100 Offset: 0x34AB201 VA: 0x34AB100
	|-Dictionary.Enumerator<Int32Enum, Int32Enum>..ctor
	|
	|-RVA: 0x35CD260 Offset: 0x35CD361 VA: 0x35CD260
	|-Dictionary.Enumerator<Int32Enum, object>..ctor
	|
	|-RVA: 0x35CDE90 Offset: 0x35CDF91 VA: 0x35CDE90
	|-Dictionary.Enumerator<long, object>..ctor
	|
	|-RVA: 0x35CEAC0 Offset: 0x35CEBC1 VA: 0x35CEAC0
	|-Dictionary.Enumerator<MapPos, int>..ctor
	|
	|-RVA: 0x35CF860 Offset: 0x35CF961 VA: 0x35CF860
	|-Dictionary.Enumerator<object, AsyncOperationHandle<object>>..ctor
	|
	|-RVA: 0x35D0520 Offset: 0x35D0621 VA: 0x35D0520
	|-Dictionary.Enumerator<object, AsyncOperationHandle>..ctor
	|
	|-RVA: 0x35D11E0 Offset: 0x35D12E1 VA: 0x35D11E0
	|-Dictionary.Enumerator<object, bool>..ctor
	|
	|-RVA: 0x35D1E30 Offset: 0x35D1F31 VA: 0x35D1E30
	|-Dictionary.Enumerator<object, byte>..ctor
	|
	|-RVA: 0x35D2A70 Offset: 0x35D2B71 VA: 0x35D2A70
	|-Dictionary.Enumerator<object, int>..ctor
	|
	|-RVA: 0x35D36B0 Offset: 0x35D37B1 VA: 0x35D36B0
	|-Dictionary.Enumerator<object, Int32Enum>..ctor
	|
	|-RVA: 0x35D42F0 Offset: 0x35D43F1 VA: 0x35D42F0
	|-Dictionary.Enumerator<object, IntPtr>..ctor
	|
	|-RVA: 0x35D4F30 Offset: 0x35D5031 VA: 0x35D4F30
	|-Dictionary.Enumerator<object, object>..ctor
	|
	|-RVA: 0x35D6960 Offset: 0x35D6A61 VA: 0x35D6960
	|-Dictionary.Enumerator<object, Playable>..ctor
	|
	|-RVA: 0x35D7600 Offset: 0x35D7701 VA: 0x35D7600
	|-Dictionary.Enumerator<object, ResourceLocator>..ctor
	|
	|-RVA: 0x35D82B0 Offset: 0x35D83B1 VA: 0x35D82B0
	|-Dictionary.Enumerator<object, float>..ctor
	|
	|-RVA: 0x35D8F00 Offset: 0x35D9001 VA: 0x35D8F00
	|-Dictionary.Enumerator<object, ushort>..ctor
	|
	|-RVA: 0x35D9B40 Offset: 0x35D9C41 VA: 0x35D9B40
	|-Dictionary.Enumerator<object, GameVariable.Value>..ctor
	|
	|-RVA: 0x35DA7F0 Offset: 0x35DA8F1 VA: 0x35DA7F0
	|-Dictionary.Enumerator<sbyte, DataStoreRatingInfo>..ctor
	|
	|-RVA: 0x35DB5F0 Offset: 0x35DB6F1 VA: 0x35DB5F0
	|-Dictionary.Enumerator<sbyte, object>..ctor
	|
	|-RVA: 0x35DC220 Offset: 0x35DC321 VA: 0x35DC220
	|-Dictionary.Enumerator<ushort, int>..ctor
	|
	|-RVA: 0x35DCF80 Offset: 0x35DD081 VA: 0x35DCF80
	|-Dictionary.Enumerator<uint, int>..ctor
	|
	|-RVA: 0x3762490 Offset: 0x3762591 VA: 0x3762490
	|-Dictionary.Enumerator<uint, object>..ctor
	|
	|-RVA: 0x37630C0 Offset: 0x37631C1 VA: 0x37630C0
	|-Dictionary.Enumerator<ulong, Friend>..ctor
	|
	|-RVA: 0x3763EF0 Offset: 0x3763FF1 VA: 0x3763EF0
	|-Dictionary.Enumerator<ulong, Int32Enum>..ctor
	|
	|-RVA: 0x3764C80 Offset: 0x3764D81 VA: 0x3764C80
	|-Dictionary.Enumerator<ulong, object>..ctor
	|
	|-RVA: 0x37658B0 Offset: 0x37659B1 VA: 0x37658B0
	|-Dictionary.Enumerator<Vector3, int>..ctor
	|
	|-RVA: 0x3766680 Offset: 0x3766781 VA: 0x3766680
	|-Dictionary.Enumerator<XPathNodeRef, XPathNodeRef>..ctor
	|
	|-RVA: 0x37674D0 Offset: 0x37675D1 VA: 0x37674D0
	|-Dictionary.Enumerator<TerrainUtility.TerrainMap.TileCoord, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x349A050 Offset: 0x349A151 VA: 0x349A050
	|-Dictionary.Enumerator<ValueTuple<object, int>, object>.MoveNext
	|
	|-RVA: 0x35D4F80 Offset: 0x35D5081 VA: 0x35D4F80
	|-Dictionary.Enumerator<byte[], Encoding>.MoveNext
	|-Dictionary.Enumerator<AkAudioListener, AkObstructionOcclusion.ObstructionOcclusionValue>.MoveNext
	|-Dictionary.Enumerator<Camera, Camera>.MoveNext
	|-Dictionary.Enumerator<GameObject, Stack<GameObject>>.MoveNext
	|-Dictionary.Enumerator<GameObject, GameObject>.MoveNext
	|-Dictionary.Enumerator<ICinemachineCamera, object>.MoveNext
	|-Dictionary.Enumerator<ItemData, ChallengeMapSelectRoot.ItemDropNum>.MoveNext
	|-Dictionary.Enumerator<object, IList<IResourceLocation>>.MoveNext
	|-Dictionary.Enumerator<object, object>.MoveNext
	|-Dictionary.Enumerator<string, List<Renderer>>.MoveNext
	|-Dictionary.Enumerator<string, List<string>>.MoveNext
	|-Dictionary.Enumerator<string, BasicMenuItem>.MoveNext
	|-Dictionary.Enumerator<string, CharacterAsset>.MoveNext
	|-Dictionary.Enumerator<string, GodBond>.MoveNext
	|-Dictionary.Enumerator<string, MsgFile>.MoveNext
	|-Dictionary.Enumerator<string, RelayAwardeeData>.MoveNext
	|-Dictionary.Enumerator<string, ResourceHandle>.MoveNext
	|-Dictionary.Enumerator<string, ResourceLocationBase>.MoveNext
	|-Dictionary.Enumerator<string, Sprite>.MoveNext
	|-Dictionary.Enumerator<string, string>.MoveNext
	|-Dictionary.Enumerator<string, Transform>.MoveNext
	|-Dictionary.Enumerator<string, UnitRelianceData>.MoveNext
	|-Dictionary.Enumerator<string, AssetTable.Accessory>.MoveNext
	|-Dictionary.Enumerator<string, EventDemoSequence.SplitViewWork>.MoveNext
	|-Dictionary.Enumerator<string, FieldBgmManager.BgmHandle>.MoveNext
	|-Dictionary.Enumerator<string, ServicePointScheduler.ConnectionGroup>.MoveNext
	|-Dictionary.Enumerator<string, SoundSystem.LipSyncDataFile>.MoveNext
	|-Dictionary.Enumerator<string, SoundWwise.SoundBankManager.BankHandle>.MoveNext
	|-Dictionary.Enumerator<string, SoundWwise.SoundPrepareManager.EventParam>.MoveNext
	|-Dictionary.Enumerator<string, SoundWwise.SoundPrepareManager.SwitchParam>.MoveNext
	|-Dictionary.Enumerator<string, SoundWwise.SoundPrepareManager.SwitchParamList>.MoveNext
	|-Dictionary.Enumerator<Transform, List<SpringBone>>.MoveNext
	|-Dictionary.Enumerator<Transform, TargetPositionCache.CacheEntry>.MoveNext
	|-Dictionary.Enumerator<Transform, UpdateTracker.UpdateStatus>.MoveNext
	|-Dictionary.Enumerator<Type, VolumeComponent>.MoveNext
	|-Dictionary.Enumerator<Unit, string>.MoveNext
	|-Dictionary.Enumerator<XmlQualifiedName, SchemaElementDecl>.MoveNext
	|
	|-RVA: 0x349ACF0 Offset: 0x349ADF1 VA: 0x349ACF0
	|-Dictionary.Enumerator<byte, List<byte>>.MoveNext
	|-Dictionary.Enumerator<byte, object>.MoveNext
	|
	|-RVA: 0x349B920 Offset: 0x349BA21 VA: 0x349B920
	|-Dictionary.Enumerator<CancellationToken, object>.MoveNext
	|
	|-RVA: 0x349C560 Offset: 0x349C661 VA: 0x349C560
	|-Dictionary.Enumerator<char, object>.MoveNext
	|
	|-RVA: 0x349D190 Offset: 0x349D291 VA: 0x349D190
	|-Dictionary.Enumerator<Guid, object>.MoveNext
	|
	|-RVA: 0x34A6F90 Offset: 0x34A7091 VA: 0x34A6F90
	|-Dictionary.Enumerator<int, List<ValueTuple<ComputeBuffer, int>>>.MoveNext
	|-Dictionary.Enumerator<int, List<ValueTuple<RTHandle, int>>>.MoveNext
	|-Dictionary.Enumerator<int, List<Volume>>.MoveNext
	|-Dictionary.Enumerator<int, RTHandle[]>.MoveNext
	|-Dictionary.Enumerator<int, CalculatorCommand>.MoveNext
	|-Dictionary.Enumerator<int, MapInfoIconLocatorRoot>.MoveNext
	|-Dictionary.Enumerator<int, object>.MoveNext
	|-Dictionary.Enumerator<int, PointerEventData>.MoveNext
	|-Dictionary.Enumerator<int, string>.MoveNext
	|-Dictionary.Enumerator<int, AkCallbackManager.BankCallbackPackage>.MoveNext
	|-Dictionary.Enumerator<int, AkCallbackManager.EventCallbackPackage>.MoveNext
	|-Dictionary.Enumerator<int, TerrainUtility.TerrainMap>.MoveNext
	|-Dictionary.Enumerator<int, MapHistory.Rewind.OverlapData>.MoveNext
	|
	|-RVA: 0x349DE20 Offset: 0x349DF21 VA: 0x349DE20
	|-Dictionary.Enumerator<int, bool>.MoveNext
	|
	|-RVA: 0x349FDD0 Offset: 0x349FED1 VA: 0x349FDD0
	|-Dictionary.Enumerator<int, byte>.MoveNext
	|
	|-RVA: 0x34A0B30 Offset: 0x34A0C31 VA: 0x34A0B30
	|-Dictionary.Enumerator<int, char>.MoveNext
	|
	|-RVA: 0x34A1890 Offset: 0x34A1991 VA: 0x34A1890
	|-Dictionary.Enumerator<int, DiagnosticEvent>.MoveNext
	|
	|-RVA: 0x34A2730 Offset: 0x34A2831 VA: 0x34A2730
	|-Dictionary.Enumerator<int, int>.MoveNext
	|
	|-RVA: 0x34A4700 Offset: 0x34A4801 VA: 0x34A4700
	|-Dictionary.Enumerator<int, Int32Enum>.MoveNext
	|
	|-RVA: 0x34A5460 Offset: 0x34A5561 VA: 0x34A5460
	|-Dictionary.Enumerator<int, long>.MoveNext
	|
	|-RVA: 0x34A61F0 Offset: 0x34A62F1 VA: 0x34A61F0
	|-Dictionary.Enumerator<int, MapPos>.MoveNext
	|
	|-RVA: 0x34A7BC0 Offset: 0x34A7CC1 VA: 0x34A7BC0
	|-Dictionary.Enumerator<int, uint>.MoveNext
	|
	|-RVA: 0x34A8920 Offset: 0x34A8A21 VA: 0x34A8920
	|-Dictionary.Enumerator<int, AIThink.EnchantThink.SurroundingInfo>.MoveNext
	|
	|-RVA: 0x34A9680 Offset: 0x34A9781 VA: 0x34A9680
	|-Dictionary.Enumerator<Int32Enum, bool>.MoveNext
	|
	|-RVA: 0x34AA3F0 Offset: 0x34AA4F1 VA: 0x34AA3F0
	|-Dictionary.Enumerator<Int32Enum, int>.MoveNext
	|-Dictionary.Enumerator<HubAccessManager.MaterialCalculator.Type, int>.MoveNext
	|
	|-RVA: 0x34AB150 Offset: 0x34AB251 VA: 0x34AB150
	|-Dictionary.Enumerator<Int32Enum, Int32Enum>.MoveNext
	|
	|-RVA: 0x35CD2B0 Offset: 0x35CD3B1 VA: 0x35CD2B0
	|-Dictionary.Enumerator<Int32Enum, object>.MoveNext
	|
	|-RVA: 0x35CDEE0 Offset: 0x35CDFE1 VA: 0x35CDEE0
	|-Dictionary.Enumerator<long, object>.MoveNext
	|
	|-RVA: 0x35D2AC0 Offset: 0x35D2BC1 VA: 0x35D2AC0
	|-Dictionary.Enumerator<ItemData, int>.MoveNext
	|-Dictionary.Enumerator<MapEditorCategoryData, int>.MoveNext
	|-Dictionary.Enumerator<object, int>.MoveNext
	|-Dictionary.Enumerator<SymbolRef, int>.MoveNext
	|-Dictionary.Enumerator<Unit, int>.MoveNext
	|
	|-RVA: 0x35CEB10 Offset: 0x35CEC11 VA: 0x35CEB10
	|-Dictionary.Enumerator<MapPos, int>.MoveNext
	|
	|-RVA: 0x35CF8B0 Offset: 0x35CF9B1 VA: 0x35CF8B0
	|-Dictionary.Enumerator<object, AsyncOperationHandle<object>>.MoveNext
	|
	|-RVA: 0x35D0570 Offset: 0x35D0671 VA: 0x35D0570
	|-Dictionary.Enumerator<object, AsyncOperationHandle>.MoveNext
	|
	|-RVA: 0x35D1230 Offset: 0x35D1331 VA: 0x35D1230
	|-Dictionary.Enumerator<object, bool>.MoveNext
	|
	|-RVA: 0x35D1E80 Offset: 0x35D1F81 VA: 0x35D1E80
	|-Dictionary.Enumerator<object, byte>.MoveNext
	|-Dictionary.Enumerator<string, byte>.MoveNext
	|
	|-RVA: 0x35D3700 Offset: 0x35D3801 VA: 0x35D3700
	|-Dictionary.Enumerator<object, Int32Enum>.MoveNext
	|
	|-RVA: 0x35D4340 Offset: 0x35D4441 VA: 0x35D4340
	|-Dictionary.Enumerator<object, IntPtr>.MoveNext
	|
	|-RVA: 0x35D69B0 Offset: 0x35D6AB1 VA: 0x35D69B0
	|-Dictionary.Enumerator<object, Playable>.MoveNext
	|
	|-RVA: 0x35D7650 Offset: 0x35D7751 VA: 0x35D7650
	|-Dictionary.Enumerator<object, ResourceLocator>.MoveNext
	|
	|-RVA: 0x35D8300 Offset: 0x35D8401 VA: 0x35D8300
	|-Dictionary.Enumerator<object, float>.MoveNext
	|
	|-RVA: 0x35D8F50 Offset: 0x35D9051 VA: 0x35D8F50
	|-Dictionary.Enumerator<object, ushort>.MoveNext
	|
	|-RVA: 0x35D9B90 Offset: 0x35D9C91 VA: 0x35D9B90
	|-Dictionary.Enumerator<object, GameVariable.Value>.MoveNext
	|-Dictionary.Enumerator<string, GameVariable.Value>.MoveNext
	|
	|-RVA: 0x35DA840 Offset: 0x35DA941 VA: 0x35DA840
	|-Dictionary.Enumerator<sbyte, DataStoreRatingInfo>.MoveNext
	|
	|-RVA: 0x35DB640 Offset: 0x35DB741 VA: 0x35DB640
	|-Dictionary.Enumerator<sbyte, DataStoreRatingInitParam>.MoveNext
	|-Dictionary.Enumerator<sbyte, object>.MoveNext
	|
	|-RVA: 0x35DC270 Offset: 0x35DC371 VA: 0x35DC270
	|-Dictionary.Enumerator<ushort, int>.MoveNext
	|
	|-RVA: 0x35DCFD0 Offset: 0x35DD0D1 VA: 0x35DCFD0
	|-Dictionary.Enumerator<uint, int>.MoveNext
	|
	|-RVA: 0x37624E0 Offset: 0x37625E1 VA: 0x37624E0
	|-Dictionary.Enumerator<uint, object>.MoveNext
	|
	|-RVA: 0x3763110 Offset: 0x3763211 VA: 0x3763110
	|-Dictionary.Enumerator<ulong, Friend>.MoveNext
	|
	|-RVA: 0x3763F40 Offset: 0x3764041 VA: 0x3763F40
	|-Dictionary.Enumerator<ulong, Int32Enum>.MoveNext
	|
	|-RVA: 0x3764CD0 Offset: 0x3764DD1 VA: 0x3764CD0
	|-Dictionary.Enumerator<ulong, object>.MoveNext
	|-Dictionary.Enumerator<ulong, RelayUserGlobalData.Ticket>.MoveNext
	|
	|-RVA: 0x3765900 Offset: 0x3765A01 VA: 0x3765900
	|-Dictionary.Enumerator<Vector3, int>.MoveNext
	|
	|-RVA: 0x37666D0 Offset: 0x37667D1 VA: 0x37666D0
	|-Dictionary.Enumerator<XPathNodeRef, XPathNodeRef>.MoveNext
	|
	|-RVA: 0x3767520 Offset: 0x3767621 VA: 0x3767520
	|-Dictionary.Enumerator<TerrainUtility.TerrainMap.TileCoord, object>.MoveNext
	|-Dictionary.Enumerator<TerrainUtility.TerrainMap.TileCoord, Terrain>.MoveNext
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public KeyValuePair<TKey, TValue> get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x349A1C0 Offset: 0x349A2C1 VA: 0x349A1C0
	|-Dictionary.Enumerator<ValueTuple<object, int>, object>.get_Current
	|
	|-RVA: 0x35D50E0 Offset: 0x35D51E1 VA: 0x35D50E0
	|-Dictionary.Enumerator<byte[], Encoding>.get_Current
	|-Dictionary.Enumerator<AkAudioListener, AkObstructionOcclusion.ObstructionOcclusionValue>.get_Current
	|-Dictionary.Enumerator<Camera, Camera>.get_Current
	|-Dictionary.Enumerator<GameObject, Stack<GameObject>>.get_Current
	|-Dictionary.Enumerator<GameObject, GameObject>.get_Current
	|-Dictionary.Enumerator<ICinemachineCamera, object>.get_Current
	|-Dictionary.Enumerator<ItemData, ChallengeMapSelectRoot.ItemDropNum>.get_Current
	|-Dictionary.Enumerator<object, IList<IResourceLocation>>.get_Current
	|-Dictionary.Enumerator<object, object>.get_Current
	|-Dictionary.Enumerator<string, List<Renderer>>.get_Current
	|-Dictionary.Enumerator<string, List<string>>.get_Current
	|-Dictionary.Enumerator<string, BasicMenuItem>.get_Current
	|-Dictionary.Enumerator<string, CharacterAsset>.get_Current
	|-Dictionary.Enumerator<string, GodBond>.get_Current
	|-Dictionary.Enumerator<string, MsgFile>.get_Current
	|-Dictionary.Enumerator<string, RelayAwardeeData>.get_Current
	|-Dictionary.Enumerator<string, ResourceHandle>.get_Current
	|-Dictionary.Enumerator<string, ResourceLocationBase>.get_Current
	|-Dictionary.Enumerator<string, Sprite>.get_Current
	|-Dictionary.Enumerator<string, string>.get_Current
	|-Dictionary.Enumerator<string, Transform>.get_Current
	|-Dictionary.Enumerator<string, UnitRelianceData>.get_Current
	|-Dictionary.Enumerator<string, AssetTable.Accessory>.get_Current
	|-Dictionary.Enumerator<string, EventDemoSequence.SplitViewWork>.get_Current
	|-Dictionary.Enumerator<string, FieldBgmManager.BgmHandle>.get_Current
	|-Dictionary.Enumerator<string, ServicePointScheduler.ConnectionGroup>.get_Current
	|-Dictionary.Enumerator<string, SoundSystem.LipSyncDataFile>.get_Current
	|-Dictionary.Enumerator<string, SoundWwise.SoundBankManager.BankHandle>.get_Current
	|-Dictionary.Enumerator<string, SoundWwise.SoundPrepareManager.EventParam>.get_Current
	|-Dictionary.Enumerator<string, SoundWwise.SoundPrepareManager.SwitchParam>.get_Current
	|-Dictionary.Enumerator<string, SoundWwise.SoundPrepareManager.SwitchParamList>.get_Current
	|-Dictionary.Enumerator<Transform, List<SpringBone>>.get_Current
	|-Dictionary.Enumerator<Transform, TargetPositionCache.CacheEntry>.get_Current
	|-Dictionary.Enumerator<Transform, UpdateTracker.UpdateStatus>.get_Current
	|-Dictionary.Enumerator<Type, VolumeComponent>.get_Current
	|-Dictionary.Enumerator<Unit, string>.get_Current
	|-Dictionary.Enumerator<XmlQualifiedName, SchemaElementDecl>.get_Current
	|
	|-RVA: 0x349AE50 Offset: 0x349AF51 VA: 0x349AE50
	|-Dictionary.Enumerator<byte, List<byte>>.get_Current
	|-Dictionary.Enumerator<byte, object>.get_Current
	|
	|-RVA: 0x349BA80 Offset: 0x349BB81 VA: 0x349BA80
	|-Dictionary.Enumerator<CancellationToken, object>.get_Current
	|
	|-RVA: 0x349C6C0 Offset: 0x349C7C1 VA: 0x349C6C0
	|-Dictionary.Enumerator<char, object>.get_Current
	|
	|-RVA: 0x349D300 Offset: 0x349D401 VA: 0x349D300
	|-Dictionary.Enumerator<Guid, object>.get_Current
	|
	|-RVA: 0x34A70F0 Offset: 0x34A71F1 VA: 0x34A70F0
	|-Dictionary.Enumerator<int, List<ValueTuple<ComputeBuffer, int>>>.get_Current
	|-Dictionary.Enumerator<int, List<ValueTuple<RTHandle, int>>>.get_Current
	|-Dictionary.Enumerator<int, List<Volume>>.get_Current
	|-Dictionary.Enumerator<int, RTHandle[]>.get_Current
	|-Dictionary.Enumerator<int, CalculatorCommand>.get_Current
	|-Dictionary.Enumerator<int, MapInfoIconLocatorRoot>.get_Current
	|-Dictionary.Enumerator<int, object>.get_Current
	|-Dictionary.Enumerator<int, PointerEventData>.get_Current
	|-Dictionary.Enumerator<int, string>.get_Current
	|-Dictionary.Enumerator<int, AkCallbackManager.BankCallbackPackage>.get_Current
	|-Dictionary.Enumerator<int, AkCallbackManager.EventCallbackPackage>.get_Current
	|-Dictionary.Enumerator<int, TerrainUtility.TerrainMap>.get_Current
	|-Dictionary.Enumerator<int, MapHistory.Rewind.OverlapData>.get_Current
	|
	|-RVA: 0x349DF70 Offset: 0x349E071 VA: 0x349DF70
	|-Dictionary.Enumerator<int, bool>.get_Current
	|
	|-RVA: 0x349FF10 Offset: 0x34A0011 VA: 0x349FF10
	|-Dictionary.Enumerator<int, byte>.get_Current
	|
	|-RVA: 0x34A0C70 Offset: 0x34A0D71 VA: 0x34A0C70
	|-Dictionary.Enumerator<int, char>.get_Current
	|
	|-RVA: 0x34A1A40 Offset: 0x34A1B41 VA: 0x34A1A40
	|-Dictionary.Enumerator<int, DiagnosticEvent>.get_Current
	|
	|-RVA: 0x34A2870 Offset: 0x34A2971 VA: 0x34A2870
	|-Dictionary.Enumerator<int, int>.get_Current
	|
	|-RVA: 0x34A4840 Offset: 0x34A4941 VA: 0x34A4840
	|-Dictionary.Enumerator<int, Int32Enum>.get_Current
	|
	|-RVA: 0x34A55B0 Offset: 0x34A56B1 VA: 0x34A55B0
	|-Dictionary.Enumerator<int, long>.get_Current
	|
	|-RVA: 0x34A6350 Offset: 0x34A6451 VA: 0x34A6350
	|-Dictionary.Enumerator<int, MapPos>.get_Current
	|
	|-RVA: 0x34A7D00 Offset: 0x34A7E01 VA: 0x34A7D00
	|-Dictionary.Enumerator<int, uint>.get_Current
	|
	|-RVA: 0x34A8A60 Offset: 0x34A8B61 VA: 0x34A8A60
	|-Dictionary.Enumerator<int, AIThink.EnchantThink.SurroundingInfo>.get_Current
	|
	|-RVA: 0x34A97D0 Offset: 0x34A98D1 VA: 0x34A97D0
	|-Dictionary.Enumerator<Int32Enum, bool>.get_Current
	|
	|-RVA: 0x34AA530 Offset: 0x34AA631 VA: 0x34AA530
	|-Dictionary.Enumerator<Int32Enum, int>.get_Current
	|-Dictionary.Enumerator<HubAccessManager.MaterialCalculator.Type, int>.get_Current
	|
	|-RVA: 0x34AB290 Offset: 0x34AB391 VA: 0x34AB290
	|-Dictionary.Enumerator<Int32Enum, Int32Enum>.get_Current
	|
	|-RVA: 0x35CD410 Offset: 0x35CD511 VA: 0x35CD410
	|-Dictionary.Enumerator<Int32Enum, object>.get_Current
	|
	|-RVA: 0x35CE040 Offset: 0x35CE141 VA: 0x35CE040
	|-Dictionary.Enumerator<long, object>.get_Current
	|
	|-RVA: 0x35D2C20 Offset: 0x35D2D21 VA: 0x35D2C20
	|-Dictionary.Enumerator<ItemData, int>.get_Current
	|-Dictionary.Enumerator<MapEditorCategoryData, int>.get_Current
	|-Dictionary.Enumerator<object, int>.get_Current
	|-Dictionary.Enumerator<SymbolRef, int>.get_Current
	|-Dictionary.Enumerator<Unit, int>.get_Current
	|
	|-RVA: 0x35CEC70 Offset: 0x35CED71 VA: 0x35CEC70
	|-Dictionary.Enumerator<MapPos, int>.get_Current
	|
	|-RVA: 0x35CFA30 Offset: 0x35CFB31 VA: 0x35CFA30
	|-Dictionary.Enumerator<object, AsyncOperationHandle<object>>.get_Current
	|
	|-RVA: 0x35D06F0 Offset: 0x35D07F1 VA: 0x35D06F0
	|-Dictionary.Enumerator<object, AsyncOperationHandle>.get_Current
	|
	|-RVA: 0x35D1390 Offset: 0x35D1491 VA: 0x35D1390
	|-Dictionary.Enumerator<object, bool>.get_Current
	|
	|-RVA: 0x35D1FE0 Offset: 0x35D20E1 VA: 0x35D1FE0
	|-Dictionary.Enumerator<object, byte>.get_Current
	|-Dictionary.Enumerator<string, byte>.get_Current
	|
	|-RVA: 0x35D3860 Offset: 0x35D3961 VA: 0x35D3860
	|-Dictionary.Enumerator<object, Int32Enum>.get_Current
	|
	|-RVA: 0x35D44A0 Offset: 0x35D45A1 VA: 0x35D44A0
	|-Dictionary.Enumerator<object, IntPtr>.get_Current
	|
	|-RVA: 0x35D6B20 Offset: 0x35D6C21 VA: 0x35D6B20
	|-Dictionary.Enumerator<object, Playable>.get_Current
	|
	|-RVA: 0x35D77C0 Offset: 0x35D78C1 VA: 0x35D77C0
	|-Dictionary.Enumerator<object, ResourceLocator>.get_Current
	|
	|-RVA: 0x35D8460 Offset: 0x35D8561 VA: 0x35D8460
	|-Dictionary.Enumerator<object, float>.get_Current
	|
	|-RVA: 0x35D90B0 Offset: 0x35D91B1 VA: 0x35D90B0
	|-Dictionary.Enumerator<object, ushort>.get_Current
	|
	|-RVA: 0x35D9D00 Offset: 0x35D9E01 VA: 0x35D9D00
	|-Dictionary.Enumerator<object, GameVariable.Value>.get_Current
	|-Dictionary.Enumerator<string, GameVariable.Value>.get_Current
	|
	|-RVA: 0x35DA9C0 Offset: 0x35DAAC1 VA: 0x35DA9C0
	|-Dictionary.Enumerator<sbyte, DataStoreRatingInfo>.get_Current
	|
	|-RVA: 0x35DB7A0 Offset: 0x35DB8A1 VA: 0x35DB7A0
	|-Dictionary.Enumerator<sbyte, DataStoreRatingInitParam>.get_Current
	|-Dictionary.Enumerator<sbyte, object>.get_Current
	|
	|-RVA: 0x35DC3B0 Offset: 0x35DC4B1 VA: 0x35DC3B0
	|-Dictionary.Enumerator<ushort, int>.get_Current
	|
	|-RVA: 0x35DD110 Offset: 0x35DD211 VA: 0x35DD110
	|-Dictionary.Enumerator<uint, int>.get_Current
	|
	|-RVA: 0x3762640 Offset: 0x3762741 VA: 0x3762640
	|-Dictionary.Enumerator<uint, object>.get_Current
	|
	|-RVA: 0x37632A0 Offset: 0x37633A1 VA: 0x37632A0
	|-Dictionary.Enumerator<ulong, Friend>.get_Current
	|
	|-RVA: 0x3764090 Offset: 0x3764191 VA: 0x3764090
	|-Dictionary.Enumerator<ulong, Int32Enum>.get_Current
	|
	|-RVA: 0x3764E30 Offset: 0x3764F31 VA: 0x3764E30
	|-Dictionary.Enumerator<ulong, object>.get_Current
	|-Dictionary.Enumerator<ulong, RelayUserGlobalData.Ticket>.get_Current
	|
	|-RVA: 0x3765A70 Offset: 0x3765B71 VA: 0x3765A70
	|-Dictionary.Enumerator<Vector3, int>.get_Current
	|
	|-RVA: 0x3766850 Offset: 0x3766951 VA: 0x3766850
	|-Dictionary.Enumerator<XPathNodeRef, XPathNodeRef>.get_Current
	|
	|-RVA: 0x3767680 Offset: 0x3767781 VA: 0x3767680
	|-Dictionary.Enumerator<TerrainUtility.TerrainMap.TileCoord, object>.get_Current
	|-Dictionary.Enumerator<TerrainUtility.TerrainMap.TileCoord, Terrain>.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x349A1E0 Offset: 0x349A2E1 VA: 0x349A1E0
	|-Dictionary.Enumerator<ValueTuple<object, int>, object>.Dispose
	|
	|-RVA: 0x35D50F0 Offset: 0x35D51F1 VA: 0x35D50F0
	|-Dictionary.Enumerator<byte[], Encoding>.Dispose
	|-Dictionary.Enumerator<AkAudioListener, AkObstructionOcclusion.ObstructionOcclusionValue>.Dispose
	|-Dictionary.Enumerator<Camera, Camera>.Dispose
	|-Dictionary.Enumerator<GameObject, Stack<GameObject>>.Dispose
	|-Dictionary.Enumerator<GameObject, GameObject>.Dispose
	|-Dictionary.Enumerator<ItemData, ChallengeMapSelectRoot.ItemDropNum>.Dispose
	|-Dictionary.Enumerator<object, IList<IResourceLocation>>.Dispose
	|-Dictionary.Enumerator<object, object>.Dispose
	|-Dictionary.Enumerator<string, List<Renderer>>.Dispose
	|-Dictionary.Enumerator<string, List<string>>.Dispose
	|-Dictionary.Enumerator<string, BasicMenuItem>.Dispose
	|-Dictionary.Enumerator<string, CharacterAsset>.Dispose
	|-Dictionary.Enumerator<string, GodBond>.Dispose
	|-Dictionary.Enumerator<string, MsgFile>.Dispose
	|-Dictionary.Enumerator<string, RelayAwardeeData>.Dispose
	|-Dictionary.Enumerator<string, ResourceHandle>.Dispose
	|-Dictionary.Enumerator<string, ResourceLocationBase>.Dispose
	|-Dictionary.Enumerator<string, Sprite>.Dispose
	|-Dictionary.Enumerator<string, string>.Dispose
	|-Dictionary.Enumerator<string, Transform>.Dispose
	|-Dictionary.Enumerator<string, UnitRelianceData>.Dispose
	|-Dictionary.Enumerator<string, AssetTable.Accessory>.Dispose
	|-Dictionary.Enumerator<string, EventDemoSequence.SplitViewWork>.Dispose
	|-Dictionary.Enumerator<string, FieldBgmManager.BgmHandle>.Dispose
	|-Dictionary.Enumerator<string, ServicePointScheduler.ConnectionGroup>.Dispose
	|-Dictionary.Enumerator<string, SoundSystem.LipSyncDataFile>.Dispose
	|-Dictionary.Enumerator<string, SoundWwise.SoundBankManager.BankHandle>.Dispose
	|-Dictionary.Enumerator<string, SoundWwise.SoundPrepareManager.EventParam>.Dispose
	|-Dictionary.Enumerator<string, SoundWwise.SoundPrepareManager.SwitchParam>.Dispose
	|-Dictionary.Enumerator<string, SoundWwise.SoundPrepareManager.SwitchParamList>.Dispose
	|-Dictionary.Enumerator<Transform, List<SpringBone>>.Dispose
	|-Dictionary.Enumerator<Type, VolumeComponent>.Dispose
	|-Dictionary.Enumerator<Unit, string>.Dispose
	|-Dictionary.Enumerator<XmlQualifiedName, SchemaElementDecl>.Dispose
	|
	|-RVA: 0x349AE60 Offset: 0x349AF61 VA: 0x349AE60
	|-Dictionary.Enumerator<byte, List<byte>>.Dispose
	|-Dictionary.Enumerator<byte, object>.Dispose
	|
	|-RVA: 0x349BA90 Offset: 0x349BB91 VA: 0x349BA90
	|-Dictionary.Enumerator<CancellationToken, object>.Dispose
	|
	|-RVA: 0x349C6D0 Offset: 0x349C7D1 VA: 0x349C6D0
	|-Dictionary.Enumerator<char, object>.Dispose
	|
	|-RVA: 0x349D320 Offset: 0x349D421 VA: 0x349D320
	|-Dictionary.Enumerator<Guid, object>.Dispose
	|
	|-RVA: 0x34A7100 Offset: 0x34A7201 VA: 0x34A7100
	|-Dictionary.Enumerator<int, List<ValueTuple<ComputeBuffer, int>>>.Dispose
	|-Dictionary.Enumerator<int, List<ValueTuple<RTHandle, int>>>.Dispose
	|-Dictionary.Enumerator<int, List<Volume>>.Dispose
	|-Dictionary.Enumerator<int, RTHandle[]>.Dispose
	|-Dictionary.Enumerator<int, MapInfoIconLocatorRoot>.Dispose
	|-Dictionary.Enumerator<int, object>.Dispose
	|-Dictionary.Enumerator<int, PointerEventData>.Dispose
	|-Dictionary.Enumerator<int, string>.Dispose
	|-Dictionary.Enumerator<int, AkCallbackManager.BankCallbackPackage>.Dispose
	|-Dictionary.Enumerator<int, AkCallbackManager.EventCallbackPackage>.Dispose
	|-Dictionary.Enumerator<int, TerrainUtility.TerrainMap>.Dispose
	|-Dictionary.Enumerator<int, MapHistory.Rewind.OverlapData>.Dispose
	|
	|-RVA: 0x349DF80 Offset: 0x349E081 VA: 0x349DF80
	|-Dictionary.Enumerator<int, bool>.Dispose
	|
	|-RVA: 0x349FF20 Offset: 0x34A0021 VA: 0x349FF20
	|-Dictionary.Enumerator<int, byte>.Dispose
	|
	|-RVA: 0x34A0C80 Offset: 0x34A0D81 VA: 0x34A0C80
	|-Dictionary.Enumerator<int, char>.Dispose
	|
	|-RVA: 0x34A1A70 Offset: 0x34A1B71 VA: 0x34A1A70
	|-Dictionary.Enumerator<int, DiagnosticEvent>.Dispose
	|
	|-RVA: 0x34A2880 Offset: 0x34A2981 VA: 0x34A2880
	|-Dictionary.Enumerator<int, int>.Dispose
	|
	|-RVA: 0x34A4850 Offset: 0x34A4951 VA: 0x34A4850
	|-Dictionary.Enumerator<int, Int32Enum>.Dispose
	|
	|-RVA: 0x34A55C0 Offset: 0x34A56C1 VA: 0x34A55C0
	|-Dictionary.Enumerator<int, long>.Dispose
	|
	|-RVA: 0x34A6360 Offset: 0x34A6461 VA: 0x34A6360
	|-Dictionary.Enumerator<int, MapPos>.Dispose
	|
	|-RVA: 0x34A7D10 Offset: 0x34A7E11 VA: 0x34A7D10
	|-Dictionary.Enumerator<int, uint>.Dispose
	|
	|-RVA: 0x34A8A70 Offset: 0x34A8B71 VA: 0x34A8A70
	|-Dictionary.Enumerator<int, AIThink.EnchantThink.SurroundingInfo>.Dispose
	|
	|-RVA: 0x34A97E0 Offset: 0x34A98E1 VA: 0x34A97E0
	|-Dictionary.Enumerator<Int32Enum, bool>.Dispose
	|
	|-RVA: 0x34AA540 Offset: 0x34AA641 VA: 0x34AA540
	|-Dictionary.Enumerator<Int32Enum, int>.Dispose
	|-Dictionary.Enumerator<HubAccessManager.MaterialCalculator.Type, int>.Dispose
	|
	|-RVA: 0x34AB2A0 Offset: 0x34AB3A1 VA: 0x34AB2A0
	|-Dictionary.Enumerator<Int32Enum, Int32Enum>.Dispose
	|
	|-RVA: 0x35CD420 Offset: 0x35CD521 VA: 0x35CD420
	|-Dictionary.Enumerator<Int32Enum, object>.Dispose
	|
	|-RVA: 0x35CE050 Offset: 0x35CE151 VA: 0x35CE050
	|-Dictionary.Enumerator<long, object>.Dispose
	|
	|-RVA: 0x35D2C30 Offset: 0x35D2D31 VA: 0x35D2C30
	|-Dictionary.Enumerator<ItemData, int>.Dispose
	|-Dictionary.Enumerator<MapEditorCategoryData, int>.Dispose
	|-Dictionary.Enumerator<object, int>.Dispose
	|-Dictionary.Enumerator<SymbolRef, int>.Dispose
	|-Dictionary.Enumerator<Unit, int>.Dispose
	|
	|-RVA: 0x35CEC80 Offset: 0x35CED81 VA: 0x35CEC80
	|-Dictionary.Enumerator<MapPos, int>.Dispose
	|
	|-RVA: 0x35CFA50 Offset: 0x35CFB51 VA: 0x35CFA50
	|-Dictionary.Enumerator<object, AsyncOperationHandle<object>>.Dispose
	|
	|-RVA: 0x35D0710 Offset: 0x35D0811 VA: 0x35D0710
	|-Dictionary.Enumerator<object, AsyncOperationHandle>.Dispose
	|
	|-RVA: 0x35D13A0 Offset: 0x35D14A1 VA: 0x35D13A0
	|-Dictionary.Enumerator<object, bool>.Dispose
	|
	|-RVA: 0x35D1FF0 Offset: 0x35D20F1 VA: 0x35D1FF0
	|-Dictionary.Enumerator<object, byte>.Dispose
	|-Dictionary.Enumerator<string, byte>.Dispose
	|
	|-RVA: 0x35D3870 Offset: 0x35D3971 VA: 0x35D3870
	|-Dictionary.Enumerator<object, Int32Enum>.Dispose
	|
	|-RVA: 0x35D44B0 Offset: 0x35D45B1 VA: 0x35D44B0
	|-Dictionary.Enumerator<object, IntPtr>.Dispose
	|
	|-RVA: 0x35D6B40 Offset: 0x35D6C41 VA: 0x35D6B40
	|-Dictionary.Enumerator<object, Playable>.Dispose
	|
	|-RVA: 0x35D77E0 Offset: 0x35D78E1 VA: 0x35D77E0
	|-Dictionary.Enumerator<object, ResourceLocator>.Dispose
	|
	|-RVA: 0x35D8470 Offset: 0x35D8571 VA: 0x35D8470
	|-Dictionary.Enumerator<object, float>.Dispose
	|
	|-RVA: 0x35D90C0 Offset: 0x35D91C1 VA: 0x35D90C0
	|-Dictionary.Enumerator<object, ushort>.Dispose
	|
	|-RVA: 0x35D9D20 Offset: 0x35D9E21 VA: 0x35D9D20
	|-Dictionary.Enumerator<object, GameVariable.Value>.Dispose
	|-Dictionary.Enumerator<string, GameVariable.Value>.Dispose
	|
	|-RVA: 0x35DA9E0 Offset: 0x35DAAE1 VA: 0x35DA9E0
	|-Dictionary.Enumerator<sbyte, DataStoreRatingInfo>.Dispose
	|
	|-RVA: 0x35DB7B0 Offset: 0x35DB8B1 VA: 0x35DB7B0
	|-Dictionary.Enumerator<sbyte, DataStoreRatingInitParam>.Dispose
	|-Dictionary.Enumerator<sbyte, object>.Dispose
	|
	|-RVA: 0x35DC3C0 Offset: 0x35DC4C1 VA: 0x35DC3C0
	|-Dictionary.Enumerator<ushort, int>.Dispose
	|
	|-RVA: 0x35DD120 Offset: 0x35DD221 VA: 0x35DD120
	|-Dictionary.Enumerator<uint, int>.Dispose
	|
	|-RVA: 0x3762650 Offset: 0x3762751 VA: 0x3762650
	|-Dictionary.Enumerator<uint, object>.Dispose
	|
	|-RVA: 0x37632C0 Offset: 0x37633C1 VA: 0x37632C0
	|-Dictionary.Enumerator<ulong, Friend>.Dispose
	|
	|-RVA: 0x37640A0 Offset: 0x37641A1 VA: 0x37640A0
	|-Dictionary.Enumerator<ulong, Int32Enum>.Dispose
	|
	|-RVA: 0x3764E40 Offset: 0x3764F41 VA: 0x3764E40
	|-Dictionary.Enumerator<ulong, object>.Dispose
	|-Dictionary.Enumerator<ulong, RelayUserGlobalData.Ticket>.Dispose
	|
	|-RVA: 0x3765A80 Offset: 0x3765B81 VA: 0x3765A80
	|-Dictionary.Enumerator<Vector3, int>.Dispose
	|
	|-RVA: 0x3766870 Offset: 0x3766971 VA: 0x3766870
	|-Dictionary.Enumerator<XPathNodeRef, XPathNodeRef>.Dispose
	|
	|-RVA: 0x3767690 Offset: 0x3767791 VA: 0x3767690
	|-Dictionary.Enumerator<TerrainUtility.TerrainMap.TileCoord, object>.Dispose
	|-Dictionary.Enumerator<TerrainUtility.TerrainMap.TileCoord, Terrain>.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x349A1F0 Offset: 0x349A2F1 VA: 0x349A1F0
	|-Dictionary.Enumerator<ValueTuple<object, int>, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x349AE70 Offset: 0x349AF71 VA: 0x349AE70
	|-Dictionary.Enumerator<byte, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x349BAA0 Offset: 0x349BBA1 VA: 0x349BAA0
	|-Dictionary.Enumerator<CancellationToken, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x349C6E0 Offset: 0x349C7E1 VA: 0x349C6E0
	|-Dictionary.Enumerator<char, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x349D330 Offset: 0x349D431 VA: 0x349D330
	|-Dictionary.Enumerator<Guid, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x349DF90 Offset: 0x349E091 VA: 0x349DF90
	|-Dictionary.Enumerator<int, bool>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x349FF30 Offset: 0x34A0031 VA: 0x349FF30
	|-Dictionary.Enumerator<int, byte>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x34A0C90 Offset: 0x34A0D91 VA: 0x34A0C90
	|-Dictionary.Enumerator<int, char>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x34A1A80 Offset: 0x34A1B81 VA: 0x34A1A80
	|-Dictionary.Enumerator<int, DiagnosticEvent>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x34A2890 Offset: 0x34A2991 VA: 0x34A2890
	|-Dictionary.Enumerator<int, int>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x34A4860 Offset: 0x34A4961 VA: 0x34A4860
	|-Dictionary.Enumerator<int, Int32Enum>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x34A55D0 Offset: 0x34A56D1 VA: 0x34A55D0
	|-Dictionary.Enumerator<int, long>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x34A6370 Offset: 0x34A6471 VA: 0x34A6370
	|-Dictionary.Enumerator<int, MapPos>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x34A7110 Offset: 0x34A7211 VA: 0x34A7110
	|-Dictionary.Enumerator<int, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x34A7D20 Offset: 0x34A7E21 VA: 0x34A7D20
	|-Dictionary.Enumerator<int, uint>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x34A8A80 Offset: 0x34A8B81 VA: 0x34A8A80
	|-Dictionary.Enumerator<int, AIThink.EnchantThink.SurroundingInfo>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x34A97F0 Offset: 0x34A98F1 VA: 0x34A97F0
	|-Dictionary.Enumerator<Int32Enum, bool>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x34AA550 Offset: 0x34AA651 VA: 0x34AA550
	|-Dictionary.Enumerator<Int32Enum, int>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x34AB2B0 Offset: 0x34AB3B1 VA: 0x34AB2B0
	|-Dictionary.Enumerator<Int32Enum, Int32Enum>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x35CD430 Offset: 0x35CD531 VA: 0x35CD430
	|-Dictionary.Enumerator<Int32Enum, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x35CE060 Offset: 0x35CE161 VA: 0x35CE060
	|-Dictionary.Enumerator<long, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x35CEC90 Offset: 0x35CED91 VA: 0x35CEC90
	|-Dictionary.Enumerator<MapPos, int>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x35CFA60 Offset: 0x35CFB61 VA: 0x35CFA60
	|-Dictionary.Enumerator<object, AsyncOperationHandle<object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x35D0720 Offset: 0x35D0821 VA: 0x35D0720
	|-Dictionary.Enumerator<object, AsyncOperationHandle>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x35D13B0 Offset: 0x35D14B1 VA: 0x35D13B0
	|-Dictionary.Enumerator<object, bool>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x35D2000 Offset: 0x35D2101 VA: 0x35D2000
	|-Dictionary.Enumerator<object, byte>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x35D2C40 Offset: 0x35D2D41 VA: 0x35D2C40
	|-Dictionary.Enumerator<object, int>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x35D3880 Offset: 0x35D3981 VA: 0x35D3880
	|-Dictionary.Enumerator<object, Int32Enum>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x35D44C0 Offset: 0x35D45C1 VA: 0x35D44C0
	|-Dictionary.Enumerator<object, IntPtr>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x35D5100 Offset: 0x35D5201 VA: 0x35D5100
	|-Dictionary.Enumerator<object, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x35D6B50 Offset: 0x35D6C51 VA: 0x35D6B50
	|-Dictionary.Enumerator<object, Playable>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x35D77F0 Offset: 0x35D78F1 VA: 0x35D77F0
	|-Dictionary.Enumerator<object, ResourceLocator>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x35D8480 Offset: 0x35D8581 VA: 0x35D8480
	|-Dictionary.Enumerator<object, float>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x35D90D0 Offset: 0x35D91D1 VA: 0x35D90D0
	|-Dictionary.Enumerator<object, ushort>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x35D9D30 Offset: 0x35D9E31 VA: 0x35D9D30
	|-Dictionary.Enumerator<object, GameVariable.Value>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x35DA9F0 Offset: 0x35DAAF1 VA: 0x35DA9F0
	|-Dictionary.Enumerator<sbyte, DataStoreRatingInfo>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x35DB7C0 Offset: 0x35DB8C1 VA: 0x35DB7C0
	|-Dictionary.Enumerator<sbyte, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x35DC3D0 Offset: 0x35DC4D1 VA: 0x35DC3D0
	|-Dictionary.Enumerator<ushort, int>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x35DD130 Offset: 0x35DD231 VA: 0x35DD130
	|-Dictionary.Enumerator<uint, int>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x3762660 Offset: 0x3762761 VA: 0x3762660
	|-Dictionary.Enumerator<uint, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x37632D0 Offset: 0x37633D1 VA: 0x37632D0
	|-Dictionary.Enumerator<ulong, Friend>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x37640B0 Offset: 0x37641B1 VA: 0x37640B0
	|-Dictionary.Enumerator<ulong, Int32Enum>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x3764E50 Offset: 0x3764F51 VA: 0x3764E50
	|-Dictionary.Enumerator<ulong, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x3765A90 Offset: 0x3765B91 VA: 0x3765A90
	|-Dictionary.Enumerator<Vector3, int>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x3766880 Offset: 0x3766981 VA: 0x3766880
	|-Dictionary.Enumerator<XPathNodeRef, XPathNodeRef>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x37676A0 Offset: 0x37677A1 VA: 0x37676A0
	|-Dictionary.Enumerator<TerrainUtility.TerrainMap.TileCoord, object>.System.Collections.IEnumerator.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x349A3F0 Offset: 0x349A4F1 VA: 0x349A3F0
	|-Dictionary.Enumerator<ValueTuple<object, int>, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x349B050 Offset: 0x349B151 VA: 0x349B050
	|-Dictionary.Enumerator<byte, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x349BC80 Offset: 0x349BD81 VA: 0x349BC80
	|-Dictionary.Enumerator<CancellationToken, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x349C8C0 Offset: 0x349C9C1 VA: 0x349C8C0
	|-Dictionary.Enumerator<char, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x349D530 Offset: 0x349D631 VA: 0x349D530
	|-Dictionary.Enumerator<Guid, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x349E1E0 Offset: 0x349E2E1 VA: 0x349E1E0
	|-Dictionary.Enumerator<int, bool>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x34A0180 Offset: 0x34A0281 VA: 0x34A0180
	|-Dictionary.Enumerator<int, byte>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x34A0EE0 Offset: 0x34A0FE1 VA: 0x34A0EE0
	|-Dictionary.Enumerator<int, char>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x34A1D10 Offset: 0x34A1E11 VA: 0x34A1D10
	|-Dictionary.Enumerator<int, DiagnosticEvent>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x34A2AE0 Offset: 0x34A2BE1 VA: 0x34A2AE0
	|-Dictionary.Enumerator<int, int>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x34A4AB0 Offset: 0x34A4BB1 VA: 0x34A4AB0
	|-Dictionary.Enumerator<int, Int32Enum>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x34A5820 Offset: 0x34A5921 VA: 0x34A5820
	|-Dictionary.Enumerator<int, long>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x34A65C0 Offset: 0x34A66C1 VA: 0x34A65C0
	|-Dictionary.Enumerator<int, MapPos>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x34A72F0 Offset: 0x34A73F1 VA: 0x34A72F0
	|-Dictionary.Enumerator<int, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x34A7F70 Offset: 0x34A8071 VA: 0x34A7F70
	|-Dictionary.Enumerator<int, uint>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x34A8CD0 Offset: 0x34A8DD1 VA: 0x34A8CD0
	|-Dictionary.Enumerator<int, AIThink.EnchantThink.SurroundingInfo>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x34A9A40 Offset: 0x34A9B41 VA: 0x34A9A40
	|-Dictionary.Enumerator<Int32Enum, bool>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x34AA7A0 Offset: 0x34AA8A1 VA: 0x34AA7A0
	|-Dictionary.Enumerator<Int32Enum, int>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x34AB500 Offset: 0x34AB601 VA: 0x34AB500
	|-Dictionary.Enumerator<Int32Enum, Int32Enum>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x35CD610 Offset: 0x35CD711 VA: 0x35CD610
	|-Dictionary.Enumerator<Int32Enum, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x35CE240 Offset: 0x35CE341 VA: 0x35CE240
	|-Dictionary.Enumerator<long, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x35CEEE0 Offset: 0x35CEFE1 VA: 0x35CEEE0
	|-Dictionary.Enumerator<MapPos, int>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x35CFC80 Offset: 0x35CFD81 VA: 0x35CFC80
	|-Dictionary.Enumerator<object, AsyncOperationHandle<object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x35D0940 Offset: 0x35D0A41 VA: 0x35D0940
	|-Dictionary.Enumerator<object, AsyncOperationHandle>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x35D15A0 Offset: 0x35D16A1 VA: 0x35D15A0
	|-Dictionary.Enumerator<object, bool>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x35D21E0 Offset: 0x35D22E1 VA: 0x35D21E0
	|-Dictionary.Enumerator<object, byte>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x35D2E20 Offset: 0x35D2F21 VA: 0x35D2E20
	|-Dictionary.Enumerator<object, int>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x35D3A60 Offset: 0x35D3B61 VA: 0x35D3A60
	|-Dictionary.Enumerator<object, Int32Enum>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x35D46A0 Offset: 0x35D47A1 VA: 0x35D46A0
	|-Dictionary.Enumerator<object, IntPtr>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x35D52A0 Offset: 0x35D53A1 VA: 0x35D52A0
	|-Dictionary.Enumerator<object, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x35D6D50 Offset: 0x35D6E51 VA: 0x35D6D50
	|-Dictionary.Enumerator<object, Playable>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x35D79F0 Offset: 0x35D7AF1 VA: 0x35D79F0
	|-Dictionary.Enumerator<object, ResourceLocator>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x35D8670 Offset: 0x35D8771 VA: 0x35D8670
	|-Dictionary.Enumerator<object, float>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x35D92B0 Offset: 0x35D93B1 VA: 0x35D92B0
	|-Dictionary.Enumerator<object, ushort>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x35D9F30 Offset: 0x35DA031 VA: 0x35D9F30
	|-Dictionary.Enumerator<object, GameVariable.Value>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x35DAC50 Offset: 0x35DAD51 VA: 0x35DAC50
	|-Dictionary.Enumerator<sbyte, DataStoreRatingInfo>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x35DB9A0 Offset: 0x35DBAA1 VA: 0x35DB9A0
	|-Dictionary.Enumerator<sbyte, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x35DC620 Offset: 0x35DC721 VA: 0x35DC620
	|-Dictionary.Enumerator<ushort, int>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x35DD380 Offset: 0x35DD481 VA: 0x35DD380
	|-Dictionary.Enumerator<uint, int>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x3762840 Offset: 0x3762941 VA: 0x3762840
	|-Dictionary.Enumerator<uint, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x3763540 Offset: 0x3763641 VA: 0x3763540
	|-Dictionary.Enumerator<ulong, Friend>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x3764300 Offset: 0x3764401 VA: 0x3764300
	|-Dictionary.Enumerator<ulong, Int32Enum>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x3765030 Offset: 0x3765131 VA: 0x3765030
	|-Dictionary.Enumerator<ulong, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x3765D00 Offset: 0x3765E01 VA: 0x3765D00
	|-Dictionary.Enumerator<Vector3, int>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x3766AE0 Offset: 0x3766BE1 VA: 0x3766AE0
	|-Dictionary.Enumerator<XPathNodeRef, XPathNodeRef>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x3767880 Offset: 0x3767981 VA: 0x3767880
	|-Dictionary.Enumerator<TerrainUtility.TerrainMap.TileCoord, object>.System.Collections.IEnumerator.Reset
	*/

	// RVA: -1 Offset: -1 Slot: 11
	private DictionaryEntry System.Collections.IDictionaryEnumerator.get_Entry() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x349A480 Offset: 0x349A581 VA: 0x349A480
	|-Dictionary.Enumerator<ValueTuple<object, int>, object>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x349B0D0 Offset: 0x349B1D1 VA: 0x349B0D0
	|-Dictionary.Enumerator<byte, object>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x349BD00 Offset: 0x349BE01 VA: 0x349BD00
	|-Dictionary.Enumerator<CancellationToken, object>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x349C940 Offset: 0x349CA41 VA: 0x349C940
	|-Dictionary.Enumerator<char, object>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x349D5C0 Offset: 0x349D6C1 VA: 0x349D5C0
	|-Dictionary.Enumerator<Guid, object>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x349E260 Offset: 0x349E361 VA: 0x349E260
	|-Dictionary.Enumerator<int, bool>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x34A0200 Offset: 0x34A0301 VA: 0x34A0200
	|-Dictionary.Enumerator<int, byte>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x34A0F60 Offset: 0x34A1061 VA: 0x34A0F60
	|-Dictionary.Enumerator<int, char>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x34A1DB0 Offset: 0x34A1EB1 VA: 0x34A1DB0
	|-Dictionary.Enumerator<int, DiagnosticEvent>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x34A2B60 Offset: 0x34A2C61 VA: 0x34A2B60
	|-Dictionary.Enumerator<int, int>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x34A4B30 Offset: 0x34A4C31 VA: 0x34A4B30
	|-Dictionary.Enumerator<int, Int32Enum>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x34A58A0 Offset: 0x34A59A1 VA: 0x34A58A0
	|-Dictionary.Enumerator<int, long>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x34A6640 Offset: 0x34A6741 VA: 0x34A6640
	|-Dictionary.Enumerator<int, MapPos>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x34A7370 Offset: 0x34A7471 VA: 0x34A7370
	|-Dictionary.Enumerator<int, object>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x34A7FF0 Offset: 0x34A80F1 VA: 0x34A7FF0
	|-Dictionary.Enumerator<int, uint>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x34A8D50 Offset: 0x34A8E51 VA: 0x34A8D50
	|-Dictionary.Enumerator<int, AIThink.EnchantThink.SurroundingInfo>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x34A9AC0 Offset: 0x34A9BC1 VA: 0x34A9AC0
	|-Dictionary.Enumerator<Int32Enum, bool>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x34AA820 Offset: 0x34AA921 VA: 0x34AA820
	|-Dictionary.Enumerator<Int32Enum, int>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x34AB580 Offset: 0x34AB681 VA: 0x34AB580
	|-Dictionary.Enumerator<Int32Enum, Int32Enum>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x35CD690 Offset: 0x35CD791 VA: 0x35CD690
	|-Dictionary.Enumerator<Int32Enum, object>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x35CE2C0 Offset: 0x35CE3C1 VA: 0x35CE2C0
	|-Dictionary.Enumerator<long, object>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x35CEF60 Offset: 0x35CF061 VA: 0x35CEF60
	|-Dictionary.Enumerator<MapPos, int>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x35CFD10 Offset: 0x35CFE11 VA: 0x35CFD10
	|-Dictionary.Enumerator<object, AsyncOperationHandle<object>>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x35D09D0 Offset: 0x35D0AD1 VA: 0x35D09D0
	|-Dictionary.Enumerator<object, AsyncOperationHandle>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x35D1620 Offset: 0x35D1721 VA: 0x35D1620
	|-Dictionary.Enumerator<object, bool>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x35D2260 Offset: 0x35D2361 VA: 0x35D2260
	|-Dictionary.Enumerator<object, byte>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x35D2EA0 Offset: 0x35D2FA1 VA: 0x35D2EA0
	|-Dictionary.Enumerator<object, int>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x35D3AE0 Offset: 0x35D3BE1 VA: 0x35D3AE0
	|-Dictionary.Enumerator<object, Int32Enum>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x35D4720 Offset: 0x35D4821 VA: 0x35D4720
	|-Dictionary.Enumerator<object, IntPtr>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x35D5320 Offset: 0x35D5421 VA: 0x35D5320
	|-Dictionary.Enumerator<object, object>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x35D6DE0 Offset: 0x35D6EE1 VA: 0x35D6DE0
	|-Dictionary.Enumerator<object, Playable>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x35D7A80 Offset: 0x35D7B81 VA: 0x35D7A80
	|-Dictionary.Enumerator<object, ResourceLocator>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x35D86F0 Offset: 0x35D87F1 VA: 0x35D86F0
	|-Dictionary.Enumerator<object, float>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x35D9330 Offset: 0x35D9431 VA: 0x35D9330
	|-Dictionary.Enumerator<object, ushort>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x35D9FC0 Offset: 0x35DA0C1 VA: 0x35D9FC0
	|-Dictionary.Enumerator<object, GameVariable.Value>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x35DACE0 Offset: 0x35DADE1 VA: 0x35DACE0
	|-Dictionary.Enumerator<sbyte, DataStoreRatingInfo>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x35DBA20 Offset: 0x35DBB21 VA: 0x35DBA20
	|-Dictionary.Enumerator<sbyte, object>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x35DC6A0 Offset: 0x35DC7A1 VA: 0x35DC6A0
	|-Dictionary.Enumerator<ushort, int>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x35DD400 Offset: 0x35DD501 VA: 0x35DD400
	|-Dictionary.Enumerator<uint, int>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x37628C0 Offset: 0x37629C1 VA: 0x37628C0
	|-Dictionary.Enumerator<uint, object>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x37635D0 Offset: 0x37636D1 VA: 0x37635D0
	|-Dictionary.Enumerator<ulong, Friend>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x3764380 Offset: 0x3764481 VA: 0x3764380
	|-Dictionary.Enumerator<ulong, Int32Enum>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x37650B0 Offset: 0x37651B1 VA: 0x37650B0
	|-Dictionary.Enumerator<ulong, object>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x3765D80 Offset: 0x3765E81 VA: 0x3765D80
	|-Dictionary.Enumerator<Vector3, int>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x3766B70 Offset: 0x3766C71 VA: 0x3766B70
	|-Dictionary.Enumerator<XPathNodeRef, XPathNodeRef>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x3767900 Offset: 0x3767A01 VA: 0x3767900
	|-Dictionary.Enumerator<TerrainUtility.TerrainMap.TileCoord, object>.System.Collections.IDictionaryEnumerator.get_Entry
	*/

	// RVA: -1 Offset: -1 Slot: 9
	private object System.Collections.IDictionaryEnumerator.get_Key() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x349A5C0 Offset: 0x349A6C1 VA: 0x349A5C0
	|-Dictionary.Enumerator<ValueTuple<object, int>, object>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x349B210 Offset: 0x349B311 VA: 0x349B210
	|-Dictionary.Enumerator<byte, object>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x349BE40 Offset: 0x349BF41 VA: 0x349BE40
	|-Dictionary.Enumerator<CancellationToken, object>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x349CA80 Offset: 0x349CB81 VA: 0x349CA80
	|-Dictionary.Enumerator<char, object>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x349D700 Offset: 0x349D801 VA: 0x349D700
	|-Dictionary.Enumerator<Guid, object>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x349E400 Offset: 0x349E501 VA: 0x349E400
	|-Dictionary.Enumerator<int, bool>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x34A03A0 Offset: 0x34A04A1 VA: 0x34A03A0
	|-Dictionary.Enumerator<int, byte>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x34A1100 Offset: 0x34A1201 VA: 0x34A1100
	|-Dictionary.Enumerator<int, char>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x34A1F40 Offset: 0x34A2041 VA: 0x34A1F40
	|-Dictionary.Enumerator<int, DiagnosticEvent>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x34A2D00 Offset: 0x34A2E01 VA: 0x34A2D00
	|-Dictionary.Enumerator<int, int>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x34A4CD0 Offset: 0x34A4DD1 VA: 0x34A4CD0
	|-Dictionary.Enumerator<int, Int32Enum>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x34A5A40 Offset: 0x34A5B41 VA: 0x34A5A40
	|-Dictionary.Enumerator<int, long>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x34A67E0 Offset: 0x34A68E1 VA: 0x34A67E0
	|-Dictionary.Enumerator<int, MapPos>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x34A74B0 Offset: 0x34A75B1 VA: 0x34A74B0
	|-Dictionary.Enumerator<int, object>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x34A8190 Offset: 0x34A8291 VA: 0x34A8190
	|-Dictionary.Enumerator<int, uint>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x34A8EF0 Offset: 0x34A8FF1 VA: 0x34A8EF0
	|-Dictionary.Enumerator<int, AIThink.EnchantThink.SurroundingInfo>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x34A9C60 Offset: 0x34A9D61 VA: 0x34A9C60
	|-Dictionary.Enumerator<Int32Enum, bool>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x34AA9C0 Offset: 0x34AAAC1 VA: 0x34AA9C0
	|-Dictionary.Enumerator<Int32Enum, int>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x34AB720 Offset: 0x34AB821 VA: 0x34AB720
	|-Dictionary.Enumerator<Int32Enum, Int32Enum>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x35CD7D0 Offset: 0x35CD8D1 VA: 0x35CD7D0
	|-Dictionary.Enumerator<Int32Enum, object>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x35CE400 Offset: 0x35CE501 VA: 0x35CE400
	|-Dictionary.Enumerator<long, object>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x35CF100 Offset: 0x35CF201 VA: 0x35CF100
	|-Dictionary.Enumerator<MapPos, int>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x35CFE40 Offset: 0x35CFF41 VA: 0x35CFE40
	|-Dictionary.Enumerator<object, AsyncOperationHandle<object>>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x35D0B00 Offset: 0x35D0C01 VA: 0x35D0B00
	|-Dictionary.Enumerator<object, AsyncOperationHandle>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x35D1770 Offset: 0x35D1871 VA: 0x35D1770
	|-Dictionary.Enumerator<object, bool>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x35D23B0 Offset: 0x35D24B1 VA: 0x35D23B0
	|-Dictionary.Enumerator<object, byte>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x35D2FF0 Offset: 0x35D30F1 VA: 0x35D2FF0
	|-Dictionary.Enumerator<object, int>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x35D3C30 Offset: 0x35D3D31 VA: 0x35D3C30
	|-Dictionary.Enumerator<object, Int32Enum>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x35D4870 Offset: 0x35D4971 VA: 0x35D4870
	|-Dictionary.Enumerator<object, IntPtr>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x35D53F0 Offset: 0x35D54F1 VA: 0x35D53F0
	|-Dictionary.Enumerator<object, object>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x35D6F30 Offset: 0x35D7031 VA: 0x35D6F30
	|-Dictionary.Enumerator<object, Playable>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x35D7BD0 Offset: 0x35D7CD1 VA: 0x35D7BD0
	|-Dictionary.Enumerator<object, ResourceLocator>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x35D8840 Offset: 0x35D8941 VA: 0x35D8840
	|-Dictionary.Enumerator<object, float>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x35D9480 Offset: 0x35D9581 VA: 0x35D9480
	|-Dictionary.Enumerator<object, ushort>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x35DA110 Offset: 0x35DA211 VA: 0x35DA110
	|-Dictionary.Enumerator<object, GameVariable.Value>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x35DAE70 Offset: 0x35DAF71 VA: 0x35DAE70
	|-Dictionary.Enumerator<sbyte, DataStoreRatingInfo>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x35DBB60 Offset: 0x35DBC61 VA: 0x35DBB60
	|-Dictionary.Enumerator<sbyte, object>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x35DC840 Offset: 0x35DC941 VA: 0x35DC840
	|-Dictionary.Enumerator<ushort, int>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x35DD5A0 Offset: 0x35DD6A1 VA: 0x35DD5A0
	|-Dictionary.Enumerator<uint, int>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x3762A00 Offset: 0x3762B01 VA: 0x3762A00
	|-Dictionary.Enumerator<uint, object>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x3763760 Offset: 0x3763861 VA: 0x3763760
	|-Dictionary.Enumerator<ulong, Friend>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x3764520 Offset: 0x3764621 VA: 0x3764520
	|-Dictionary.Enumerator<ulong, Int32Enum>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x37651F0 Offset: 0x37652F1 VA: 0x37651F0
	|-Dictionary.Enumerator<ulong, object>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x3765F10 Offset: 0x3766011 VA: 0x3765F10
	|-Dictionary.Enumerator<Vector3, int>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x3766D10 Offset: 0x3766E11 VA: 0x3766D10
	|-Dictionary.Enumerator<XPathNodeRef, XPathNodeRef>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x3767A40 Offset: 0x3767B41 VA: 0x3767A40
	|-Dictionary.Enumerator<TerrainUtility.TerrainMap.TileCoord, object>.System.Collections.IDictionaryEnumerator.get_Key
	*/

	// RVA: -1 Offset: -1 Slot: 10
	private object System.Collections.IDictionaryEnumerator.get_Value() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x349A6D0 Offset: 0x349A7D1 VA: 0x349A6D0
	|-Dictionary.Enumerator<ValueTuple<object, int>, object>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x349B310 Offset: 0x349B411 VA: 0x349B310
	|-Dictionary.Enumerator<byte, object>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x349BF40 Offset: 0x349C041 VA: 0x349BF40
	|-Dictionary.Enumerator<CancellationToken, object>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x349CB80 Offset: 0x349CC81 VA: 0x349CB80
	|-Dictionary.Enumerator<char, object>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x349D810 Offset: 0x349D911 VA: 0x349D810
	|-Dictionary.Enumerator<Guid, object>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x349E500 Offset: 0x349E601 VA: 0x349E500
	|-Dictionary.Enumerator<int, bool>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x34A04A0 Offset: 0x34A05A1 VA: 0x34A04A0
	|-Dictionary.Enumerator<int, byte>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x34A1200 Offset: 0x34A1301 VA: 0x34A1200
	|-Dictionary.Enumerator<int, char>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x34A2040 Offset: 0x34A2141 VA: 0x34A2040
	|-Dictionary.Enumerator<int, DiagnosticEvent>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x34A2E00 Offset: 0x34A2F01 VA: 0x34A2E00
	|-Dictionary.Enumerator<int, int>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x34A4DD0 Offset: 0x34A4ED1 VA: 0x34A4DD0
	|-Dictionary.Enumerator<int, Int32Enum>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x34A5B40 Offset: 0x34A5C41 VA: 0x34A5B40
	|-Dictionary.Enumerator<int, long>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x34A68E0 Offset: 0x34A69E1 VA: 0x34A68E0
	|-Dictionary.Enumerator<int, MapPos>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x34A75B0 Offset: 0x34A76B1 VA: 0x34A75B0
	|-Dictionary.Enumerator<int, object>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x34A8290 Offset: 0x34A8391 VA: 0x34A8290
	|-Dictionary.Enumerator<int, uint>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x34A8FF0 Offset: 0x34A90F1 VA: 0x34A8FF0
	|-Dictionary.Enumerator<int, AIThink.EnchantThink.SurroundingInfo>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x34A9D60 Offset: 0x34A9E61 VA: 0x34A9D60
	|-Dictionary.Enumerator<Int32Enum, bool>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x34AAAC0 Offset: 0x34AABC1 VA: 0x34AAAC0
	|-Dictionary.Enumerator<Int32Enum, int>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x34AB820 Offset: 0x34AB921 VA: 0x34AB820
	|-Dictionary.Enumerator<Int32Enum, Int32Enum>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x35CD8D0 Offset: 0x35CD9D1 VA: 0x35CD8D0
	|-Dictionary.Enumerator<Int32Enum, object>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x35CE500 Offset: 0x35CE601 VA: 0x35CE500
	|-Dictionary.Enumerator<long, object>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x35CF200 Offset: 0x35CF301 VA: 0x35CF200
	|-Dictionary.Enumerator<MapPos, int>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x35CFEE0 Offset: 0x35CFFE1 VA: 0x35CFEE0
	|-Dictionary.Enumerator<object, AsyncOperationHandle<object>>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x35D0BA0 Offset: 0x35D0CA1 VA: 0x35D0BA0
	|-Dictionary.Enumerator<object, AsyncOperationHandle>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x35D1810 Offset: 0x35D1911 VA: 0x35D1810
	|-Dictionary.Enumerator<object, bool>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x35D2450 Offset: 0x35D2551 VA: 0x35D2450
	|-Dictionary.Enumerator<object, byte>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x35D3090 Offset: 0x35D3191 VA: 0x35D3090
	|-Dictionary.Enumerator<object, int>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x35D3CD0 Offset: 0x35D3DD1 VA: 0x35D3CD0
	|-Dictionary.Enumerator<object, Int32Enum>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x35D4910 Offset: 0x35D4A11 VA: 0x35D4910
	|-Dictionary.Enumerator<object, IntPtr>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x35D5490 Offset: 0x35D5591 VA: 0x35D5490
	|-Dictionary.Enumerator<object, object>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x35D6FD0 Offset: 0x35D70D1 VA: 0x35D6FD0
	|-Dictionary.Enumerator<object, Playable>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x35D7C70 Offset: 0x35D7D71 VA: 0x35D7C70
	|-Dictionary.Enumerator<object, ResourceLocator>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x35D88E0 Offset: 0x35D89E1 VA: 0x35D88E0
	|-Dictionary.Enumerator<object, float>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x35D9520 Offset: 0x35D9621 VA: 0x35D9520
	|-Dictionary.Enumerator<object, ushort>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x35DA1B0 Offset: 0x35DA2B1 VA: 0x35DA1B0
	|-Dictionary.Enumerator<object, GameVariable.Value>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x35DAF70 Offset: 0x35DB071 VA: 0x35DAF70
	|-Dictionary.Enumerator<sbyte, DataStoreRatingInfo>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x35DBC60 Offset: 0x35DBD61 VA: 0x35DBC60
	|-Dictionary.Enumerator<sbyte, object>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x35DC940 Offset: 0x35DCA41 VA: 0x35DC940
	|-Dictionary.Enumerator<ushort, int>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x35DD6A0 Offset: 0x35DD7A1 VA: 0x35DD6A0
	|-Dictionary.Enumerator<uint, int>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x3762B00 Offset: 0x3762C01 VA: 0x3762B00
	|-Dictionary.Enumerator<uint, object>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x3763860 Offset: 0x3763961 VA: 0x3763860
	|-Dictionary.Enumerator<ulong, Friend>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x3764620 Offset: 0x3764721 VA: 0x3764620
	|-Dictionary.Enumerator<ulong, Int32Enum>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x37652F0 Offset: 0x37653F1 VA: 0x37652F0
	|-Dictionary.Enumerator<ulong, object>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x3766000 Offset: 0x3766101 VA: 0x3766000
	|-Dictionary.Enumerator<Vector3, int>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x3766E20 Offset: 0x3766F21 VA: 0x3766E20
	|-Dictionary.Enumerator<XPathNodeRef, XPathNodeRef>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x3767B40 Offset: 0x3767C41 VA: 0x3767B40
	|-Dictionary.Enumerator<TerrainUtility.TerrainMap.TileCoord, object>.System.Collections.IDictionaryEnumerator.get_Value
	*/
}

// Namespace: 
[Serializable]
public struct Dictionary.KeyCollection.Enumerator<TKey, TValue> : IEnumerator<TKey>, IDisposable, IEnumerator // TypeDefIndex: 1403
{
	// Fields
	private Dictionary<TKey, TValue> dictionary; // 0x0
	private int index; // 0x0
	private int version; // 0x0
	private TKey currentKey; // 0x0

	// Properties
	public TKey Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(Dictionary<TKey, TValue> dictionary) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x349A770 Offset: 0x349A871 VA: 0x349A770
	|-Dictionary.KeyCollection.Enumerator<ValueTuple<object, int>, object>..ctor
	|
	|-RVA: 0x349B3B0 Offset: 0x349B4B1 VA: 0x349B3B0
	|-Dictionary.KeyCollection.Enumerator<byte, object>..ctor
	|
	|-RVA: 0x349BFE0 Offset: 0x349C0E1 VA: 0x349BFE0
	|-Dictionary.KeyCollection.Enumerator<CancellationToken, object>..ctor
	|
	|-RVA: 0x349CC20 Offset: 0x349CD21 VA: 0x349CC20
	|-Dictionary.KeyCollection.Enumerator<char, object>..ctor
	|
	|-RVA: 0x349D8B0 Offset: 0x349D9B1 VA: 0x349D8B0
	|-Dictionary.KeyCollection.Enumerator<Guid, object>..ctor
	|
	|-RVA: 0x349F060 Offset: 0x349F161 VA: 0x349F060
	|-Dictionary.KeyCollection.Enumerator<int, bool>..ctor
	|
	|-RVA: 0x34A05A0 Offset: 0x34A06A1 VA: 0x34A05A0
	|-Dictionary.KeyCollection.Enumerator<int, byte>..ctor
	|
	|-RVA: 0x34A1300 Offset: 0x34A1401 VA: 0x34A1300
	|-Dictionary.KeyCollection.Enumerator<int, char>..ctor
	|
	|-RVA: 0x34A2140 Offset: 0x34A2241 VA: 0x34A2140
	|-Dictionary.KeyCollection.Enumerator<int, DiagnosticEvent>..ctor
	|
	|-RVA: 0x34A3990 Offset: 0x34A3A91 VA: 0x34A3990
	|-Dictionary.KeyCollection.Enumerator<int, int>..ctor
	|
	|-RVA: 0x34A4ED0 Offset: 0x34A4FD1 VA: 0x34A4ED0
	|-Dictionary.KeyCollection.Enumerator<int, Int32Enum>..ctor
	|
	|-RVA: 0x34A5C40 Offset: 0x34A5D41 VA: 0x34A5C40
	|-Dictionary.KeyCollection.Enumerator<int, long>..ctor
	|
	|-RVA: 0x34A69E0 Offset: 0x34A6AE1 VA: 0x34A69E0
	|-Dictionary.KeyCollection.Enumerator<int, MapPos>..ctor
	|
	|-RVA: 0x34A7650 Offset: 0x34A7751 VA: 0x34A7650
	|-Dictionary.KeyCollection.Enumerator<int, object>..ctor
	|
	|-RVA: 0x34A8390 Offset: 0x34A8491 VA: 0x34A8390
	|-Dictionary.KeyCollection.Enumerator<int, uint>..ctor
	|
	|-RVA: 0x34A90F0 Offset: 0x34A91F1 VA: 0x34A90F0
	|-Dictionary.KeyCollection.Enumerator<int, AIThink.EnchantThink.SurroundingInfo>..ctor
	|
	|-RVA: 0x34A9E60 Offset: 0x34A9F61 VA: 0x34A9E60
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, bool>..ctor
	|
	|-RVA: 0x34AABC0 Offset: 0x34AACC1 VA: 0x34AABC0
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, int>..ctor
	|
	|-RVA: 0x35CCD20 Offset: 0x35CCE21 VA: 0x35CCD20
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, Int32Enum>..ctor
	|
	|-RVA: 0x35CD970 Offset: 0x35CDA71 VA: 0x35CD970
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, object>..ctor
	|
	|-RVA: 0x35CE5A0 Offset: 0x35CE6A1 VA: 0x35CE5A0
	|-Dictionary.KeyCollection.Enumerator<long, object>..ctor
	|
	|-RVA: 0x35CF300 Offset: 0x35CF401 VA: 0x35CF300
	|-Dictionary.KeyCollection.Enumerator<MapPos, int>..ctor
	|
	|-RVA: 0x35CFFD0 Offset: 0x35D00D1 VA: 0x35CFFD0
	|-Dictionary.KeyCollection.Enumerator<object, AsyncOperationHandle<object>>..ctor
	|
	|-RVA: 0x35D0C90 Offset: 0x35D0D91 VA: 0x35D0C90
	|-Dictionary.KeyCollection.Enumerator<object, AsyncOperationHandle>..ctor
	|
	|-RVA: 0x35D1910 Offset: 0x35D1A11 VA: 0x35D1910
	|-Dictionary.KeyCollection.Enumerator<object, bool>..ctor
	|
	|-RVA: 0x35D2550 Offset: 0x35D2651 VA: 0x35D2550
	|-Dictionary.KeyCollection.Enumerator<object, byte>..ctor
	|
	|-RVA: 0x35D3190 Offset: 0x35D3291 VA: 0x35D3190
	|-Dictionary.KeyCollection.Enumerator<object, int>..ctor
	|
	|-RVA: 0x35D3DD0 Offset: 0x35D3ED1 VA: 0x35D3DD0
	|-Dictionary.KeyCollection.Enumerator<object, Int32Enum>..ctor
	|
	|-RVA: 0x35D4A10 Offset: 0x35D4B11 VA: 0x35D4A10
	|-Dictionary.KeyCollection.Enumerator<object, IntPtr>..ctor
	|
	|-RVA: 0x35D5D60 Offset: 0x35D5E61 VA: 0x35D5D60
	|-Dictionary.KeyCollection.Enumerator<object, object>..ctor
	|
	|-RVA: 0x35D70E0 Offset: 0x35D71E1 VA: 0x35D70E0
	|-Dictionary.KeyCollection.Enumerator<object, Playable>..ctor
	|
	|-RVA: 0x35D7D80 Offset: 0x35D7E81 VA: 0x35D7D80
	|-Dictionary.KeyCollection.Enumerator<object, ResourceLocator>..ctor
	|
	|-RVA: 0x35D89E0 Offset: 0x35D8AE1 VA: 0x35D89E0
	|-Dictionary.KeyCollection.Enumerator<object, float>..ctor
	|
	|-RVA: 0x35D9620 Offset: 0x35D9721 VA: 0x35D9620
	|-Dictionary.KeyCollection.Enumerator<object, ushort>..ctor
	|
	|-RVA: 0x35DA2C0 Offset: 0x35DA3C1 VA: 0x35DA2C0
	|-Dictionary.KeyCollection.Enumerator<object, GameVariable.Value>..ctor
	|
	|-RVA: 0x35DB060 Offset: 0x35DB161 VA: 0x35DB060
	|-Dictionary.KeyCollection.Enumerator<sbyte, DataStoreRatingInfo>..ctor
	|
	|-RVA: 0x35DBD00 Offset: 0x35DBE01 VA: 0x35DBD00
	|-Dictionary.KeyCollection.Enumerator<sbyte, object>..ctor
	|
	|-RVA: 0x35DCA40 Offset: 0x35DCB41 VA: 0x35DCA40
	|-Dictionary.KeyCollection.Enumerator<ushort, int>..ctor
	|
	|-RVA: 0x3761F50 Offset: 0x3762051 VA: 0x3761F50
	|-Dictionary.KeyCollection.Enumerator<uint, int>..ctor
	|
	|-RVA: 0x3762BA0 Offset: 0x3762CA1 VA: 0x3762BA0
	|-Dictionary.KeyCollection.Enumerator<uint, object>..ctor
	|
	|-RVA: 0x3763950 Offset: 0x3763A51 VA: 0x3763950
	|-Dictionary.KeyCollection.Enumerator<ulong, Friend>..ctor
	|
	|-RVA: 0x3764720 Offset: 0x3764821 VA: 0x3764720
	|-Dictionary.KeyCollection.Enumerator<ulong, Int32Enum>..ctor
	|
	|-RVA: 0x3765390 Offset: 0x3765491 VA: 0x3765390
	|-Dictionary.KeyCollection.Enumerator<ulong, object>..ctor
	|
	|-RVA: 0x3766100 Offset: 0x3766201 VA: 0x3766100
	|-Dictionary.KeyCollection.Enumerator<Vector3, int>..ctor
	|
	|-RVA: 0x3766F30 Offset: 0x3767031 VA: 0x3766F30
	|-Dictionary.KeyCollection.Enumerator<XPathNodeRef, XPathNodeRef>..ctor
	|
	|-RVA: 0x3767BE0 Offset: 0x3767CE1 VA: 0x3767BE0
	|-Dictionary.KeyCollection.Enumerator<TerrainUtility.TerrainMap.TileCoord, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x349A7B0 Offset: 0x349A8B1 VA: 0x349A7B0
	|-Dictionary.KeyCollection.Enumerator<ValueTuple<object, int>, object>.Dispose
	|
	|-RVA: 0x349B3F0 Offset: 0x349B4F1 VA: 0x349B3F0
	|-Dictionary.KeyCollection.Enumerator<byte, object>.Dispose
	|
	|-RVA: 0x349C020 Offset: 0x349C121 VA: 0x349C020
	|-Dictionary.KeyCollection.Enumerator<CancellationToken, object>.Dispose
	|
	|-RVA: 0x349CC60 Offset: 0x349CD61 VA: 0x349CC60
	|-Dictionary.KeyCollection.Enumerator<char, object>.Dispose
	|
	|-RVA: 0x349D8F0 Offset: 0x349D9F1 VA: 0x349D8F0
	|-Dictionary.KeyCollection.Enumerator<Guid, object>.Dispose
	|
	|-RVA: 0x349F0A0 Offset: 0x349F1A1 VA: 0x349F0A0
	|-Dictionary.KeyCollection.Enumerator<int, bool>.Dispose
	|
	|-RVA: 0x34A05E0 Offset: 0x34A06E1 VA: 0x34A05E0
	|-Dictionary.KeyCollection.Enumerator<int, byte>.Dispose
	|
	|-RVA: 0x34A1340 Offset: 0x34A1441 VA: 0x34A1340
	|-Dictionary.KeyCollection.Enumerator<int, char>.Dispose
	|
	|-RVA: 0x34A2180 Offset: 0x34A2281 VA: 0x34A2180
	|-Dictionary.KeyCollection.Enumerator<int, DiagnosticEvent>.Dispose
	|
	|-RVA: 0x34A39D0 Offset: 0x34A3AD1 VA: 0x34A39D0
	|-Dictionary.KeyCollection.Enumerator<int, int>.Dispose
	|
	|-RVA: 0x34A4F10 Offset: 0x34A5011 VA: 0x34A4F10
	|-Dictionary.KeyCollection.Enumerator<int, Int32Enum>.Dispose
	|
	|-RVA: 0x34A5C80 Offset: 0x34A5D81 VA: 0x34A5C80
	|-Dictionary.KeyCollection.Enumerator<int, long>.Dispose
	|
	|-RVA: 0x34A6A20 Offset: 0x34A6B21 VA: 0x34A6A20
	|-Dictionary.KeyCollection.Enumerator<int, MapPos>.Dispose
	|
	|-RVA: 0x34A7690 Offset: 0x34A7791 VA: 0x34A7690
	|-Dictionary.KeyCollection.Enumerator<int, object>.Dispose
	|-Dictionary.KeyCollection.Enumerator<int, MapHistory.Rewind.OverlapData>.Dispose
	|
	|-RVA: 0x34A83D0 Offset: 0x34A84D1 VA: 0x34A83D0
	|-Dictionary.KeyCollection.Enumerator<int, uint>.Dispose
	|
	|-RVA: 0x34A9130 Offset: 0x34A9231 VA: 0x34A9130
	|-Dictionary.KeyCollection.Enumerator<int, AIThink.EnchantThink.SurroundingInfo>.Dispose
	|
	|-RVA: 0x34A9EA0 Offset: 0x34A9FA1 VA: 0x34A9EA0
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, bool>.Dispose
	|
	|-RVA: 0x34AAC00 Offset: 0x34AAD01 VA: 0x34AAC00
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, int>.Dispose
	|
	|-RVA: 0x35CCD60 Offset: 0x35CCE61 VA: 0x35CCD60
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, Int32Enum>.Dispose
	|
	|-RVA: 0x35CD9B0 Offset: 0x35CDAB1 VA: 0x35CD9B0
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, object>.Dispose
	|
	|-RVA: 0x35CE5E0 Offset: 0x35CE6E1 VA: 0x35CE5E0
	|-Dictionary.KeyCollection.Enumerator<long, object>.Dispose
	|
	|-RVA: 0x35D31D0 Offset: 0x35D32D1 VA: 0x35D31D0
	|-Dictionary.KeyCollection.Enumerator<ItemData, int>.Dispose
	|-Dictionary.KeyCollection.Enumerator<object, int>.Dispose
	|-Dictionary.KeyCollection.Enumerator<string, int>.Dispose
	|
	|-RVA: 0x35CF340 Offset: 0x35CF441 VA: 0x35CF340
	|-Dictionary.KeyCollection.Enumerator<MapPos, int>.Dispose
	|
	|-RVA: 0x35D0010 Offset: 0x35D0111 VA: 0x35D0010
	|-Dictionary.KeyCollection.Enumerator<object, AsyncOperationHandle<object>>.Dispose
	|
	|-RVA: 0x35D0CD0 Offset: 0x35D0DD1 VA: 0x35D0CD0
	|-Dictionary.KeyCollection.Enumerator<object, AsyncOperationHandle>.Dispose
	|
	|-RVA: 0x35D1950 Offset: 0x35D1A51 VA: 0x35D1950
	|-Dictionary.KeyCollection.Enumerator<object, bool>.Dispose
	|-Dictionary.KeyCollection.Enumerator<string, bool>.Dispose
	|
	|-RVA: 0x35D2590 Offset: 0x35D2691 VA: 0x35D2590
	|-Dictionary.KeyCollection.Enumerator<object, byte>.Dispose
	|
	|-RVA: 0x35D3E10 Offset: 0x35D3F11 VA: 0x35D3E10
	|-Dictionary.KeyCollection.Enumerator<object, Int32Enum>.Dispose
	|
	|-RVA: 0x35D4A50 Offset: 0x35D4B51 VA: 0x35D4A50
	|-Dictionary.KeyCollection.Enumerator<object, IntPtr>.Dispose
	|-Dictionary.KeyCollection.Enumerator<string, IntPtr>.Dispose
	|
	|-RVA: 0x35D5DA0 Offset: 0x35D5EA1 VA: 0x35D5DA0
	|-Dictionary.KeyCollection.Enumerator<object, object>.Dispose
	|-Dictionary.KeyCollection.Enumerator<ParameterExpression, LocalVariable>.Dispose
	|-Dictionary.KeyCollection.Enumerator<Renderer, Material[]>.Dispose
	|-Dictionary.KeyCollection.Enumerator<string, GodBond>.Dispose
	|-Dictionary.KeyCollection.Enumerator<string, GodUnit>.Dispose
	|-Dictionary.KeyCollection.Enumerator<string, GodWeaponRefineLevels>.Dispose
	|-Dictionary.KeyCollection.Enumerator<string, string>.Dispose
	|
	|-RVA: 0x35D7120 Offset: 0x35D7221 VA: 0x35D7120
	|-Dictionary.KeyCollection.Enumerator<object, Playable>.Dispose
	|
	|-RVA: 0x35D7DC0 Offset: 0x35D7EC1 VA: 0x35D7DC0
	|-Dictionary.KeyCollection.Enumerator<object, ResourceLocator>.Dispose
	|
	|-RVA: 0x35D8A20 Offset: 0x35D8B21 VA: 0x35D8A20
	|-Dictionary.KeyCollection.Enumerator<object, float>.Dispose
	|
	|-RVA: 0x35D9660 Offset: 0x35D9761 VA: 0x35D9660
	|-Dictionary.KeyCollection.Enumerator<object, ushort>.Dispose
	|
	|-RVA: 0x35DA300 Offset: 0x35DA401 VA: 0x35DA300
	|-Dictionary.KeyCollection.Enumerator<object, GameVariable.Value>.Dispose
	|-Dictionary.KeyCollection.Enumerator<string, GameVariable.Value>.Dispose
	|
	|-RVA: 0x35DB0A0 Offset: 0x35DB1A1 VA: 0x35DB0A0
	|-Dictionary.KeyCollection.Enumerator<sbyte, DataStoreRatingInfo>.Dispose
	|
	|-RVA: 0x35DBD40 Offset: 0x35DBE41 VA: 0x35DBD40
	|-Dictionary.KeyCollection.Enumerator<sbyte, object>.Dispose
	|
	|-RVA: 0x35DCA80 Offset: 0x35DCB81 VA: 0x35DCA80
	|-Dictionary.KeyCollection.Enumerator<ushort, int>.Dispose
	|
	|-RVA: 0x3761F90 Offset: 0x3762091 VA: 0x3761F90
	|-Dictionary.KeyCollection.Enumerator<uint, int>.Dispose
	|
	|-RVA: 0x3762BE0 Offset: 0x3762CE1 VA: 0x3762BE0
	|-Dictionary.KeyCollection.Enumerator<uint, object>.Dispose
	|
	|-RVA: 0x3763990 Offset: 0x3763A91 VA: 0x3763990
	|-Dictionary.KeyCollection.Enumerator<ulong, Friend>.Dispose
	|
	|-RVA: 0x3764760 Offset: 0x3764861 VA: 0x3764760
	|-Dictionary.KeyCollection.Enumerator<ulong, Int32Enum>.Dispose
	|-Dictionary.KeyCollection.Enumerator<ulong, NexVersus.TargetSlotList.Results>.Dispose
	|
	|-RVA: 0x37653D0 Offset: 0x37654D1 VA: 0x37653D0
	|-Dictionary.KeyCollection.Enumerator<ulong, object>.Dispose
	|-Dictionary.KeyCollection.Enumerator<ulong, RelayUserGlobalData.Ticket>.Dispose
	|
	|-RVA: 0x3766140 Offset: 0x3766241 VA: 0x3766140
	|-Dictionary.KeyCollection.Enumerator<Vector3, int>.Dispose
	|
	|-RVA: 0x3766F70 Offset: 0x3767071 VA: 0x3766F70
	|-Dictionary.KeyCollection.Enumerator<XPathNodeRef, XPathNodeRef>.Dispose
	|
	|-RVA: 0x3767C20 Offset: 0x3767D21 VA: 0x3767C20
	|-Dictionary.KeyCollection.Enumerator<TerrainUtility.TerrainMap.TileCoord, object>.Dispose
	|-Dictionary.KeyCollection.Enumerator<TerrainUtility.TerrainMap.TileCoord, Terrain>.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x349A7C0 Offset: 0x349A8C1 VA: 0x349A7C0
	|-Dictionary.KeyCollection.Enumerator<ValueTuple<object, int>, object>.MoveNext
	|
	|-RVA: 0x349B400 Offset: 0x349B501 VA: 0x349B400
	|-Dictionary.KeyCollection.Enumerator<byte, object>.MoveNext
	|
	|-RVA: 0x349C030 Offset: 0x349C131 VA: 0x349C030
	|-Dictionary.KeyCollection.Enumerator<CancellationToken, object>.MoveNext
	|
	|-RVA: 0x349CC70 Offset: 0x349CD71 VA: 0x349CC70
	|-Dictionary.KeyCollection.Enumerator<char, object>.MoveNext
	|
	|-RVA: 0x349D900 Offset: 0x349DA01 VA: 0x349D900
	|-Dictionary.KeyCollection.Enumerator<Guid, object>.MoveNext
	|
	|-RVA: 0x349F0B0 Offset: 0x349F1B1 VA: 0x349F0B0
	|-Dictionary.KeyCollection.Enumerator<int, bool>.MoveNext
	|
	|-RVA: 0x34A05F0 Offset: 0x34A06F1 VA: 0x34A05F0
	|-Dictionary.KeyCollection.Enumerator<int, byte>.MoveNext
	|
	|-RVA: 0x34A1350 Offset: 0x34A1451 VA: 0x34A1350
	|-Dictionary.KeyCollection.Enumerator<int, char>.MoveNext
	|
	|-RVA: 0x34A2190 Offset: 0x34A2291 VA: 0x34A2190
	|-Dictionary.KeyCollection.Enumerator<int, DiagnosticEvent>.MoveNext
	|
	|-RVA: 0x34A39E0 Offset: 0x34A3AE1 VA: 0x34A39E0
	|-Dictionary.KeyCollection.Enumerator<int, int>.MoveNext
	|
	|-RVA: 0x34A4F20 Offset: 0x34A5021 VA: 0x34A4F20
	|-Dictionary.KeyCollection.Enumerator<int, Int32Enum>.MoveNext
	|
	|-RVA: 0x34A5C90 Offset: 0x34A5D91 VA: 0x34A5C90
	|-Dictionary.KeyCollection.Enumerator<int, long>.MoveNext
	|
	|-RVA: 0x34A6A30 Offset: 0x34A6B31 VA: 0x34A6A30
	|-Dictionary.KeyCollection.Enumerator<int, MapPos>.MoveNext
	|
	|-RVA: 0x34A76A0 Offset: 0x34A77A1 VA: 0x34A76A0
	|-Dictionary.KeyCollection.Enumerator<int, object>.MoveNext
	|-Dictionary.KeyCollection.Enumerator<int, MapHistory.Rewind.OverlapData>.MoveNext
	|
	|-RVA: 0x34A83E0 Offset: 0x34A84E1 VA: 0x34A83E0
	|-Dictionary.KeyCollection.Enumerator<int, uint>.MoveNext
	|
	|-RVA: 0x34A9140 Offset: 0x34A9241 VA: 0x34A9140
	|-Dictionary.KeyCollection.Enumerator<int, AIThink.EnchantThink.SurroundingInfo>.MoveNext
	|
	|-RVA: 0x34A9EB0 Offset: 0x34A9FB1 VA: 0x34A9EB0
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, bool>.MoveNext
	|
	|-RVA: 0x34AAC10 Offset: 0x34AAD11 VA: 0x34AAC10
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, int>.MoveNext
	|
	|-RVA: 0x35CCD70 Offset: 0x35CCE71 VA: 0x35CCD70
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, Int32Enum>.MoveNext
	|
	|-RVA: 0x35CD9C0 Offset: 0x35CDAC1 VA: 0x35CD9C0
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, object>.MoveNext
	|
	|-RVA: 0x35CE5F0 Offset: 0x35CE6F1 VA: 0x35CE5F0
	|-Dictionary.KeyCollection.Enumerator<long, object>.MoveNext
	|
	|-RVA: 0x35D31E0 Offset: 0x35D32E1 VA: 0x35D31E0
	|-Dictionary.KeyCollection.Enumerator<ItemData, int>.MoveNext
	|-Dictionary.KeyCollection.Enumerator<object, int>.MoveNext
	|-Dictionary.KeyCollection.Enumerator<string, int>.MoveNext
	|
	|-RVA: 0x35CF350 Offset: 0x35CF451 VA: 0x35CF350
	|-Dictionary.KeyCollection.Enumerator<MapPos, int>.MoveNext
	|
	|-RVA: 0x35D0020 Offset: 0x35D0121 VA: 0x35D0020
	|-Dictionary.KeyCollection.Enumerator<object, AsyncOperationHandle<object>>.MoveNext
	|
	|-RVA: 0x35D0CE0 Offset: 0x35D0DE1 VA: 0x35D0CE0
	|-Dictionary.KeyCollection.Enumerator<object, AsyncOperationHandle>.MoveNext
	|
	|-RVA: 0x35D1960 Offset: 0x35D1A61 VA: 0x35D1960
	|-Dictionary.KeyCollection.Enumerator<object, bool>.MoveNext
	|-Dictionary.KeyCollection.Enumerator<string, bool>.MoveNext
	|
	|-RVA: 0x35D25A0 Offset: 0x35D26A1 VA: 0x35D25A0
	|-Dictionary.KeyCollection.Enumerator<object, byte>.MoveNext
	|
	|-RVA: 0x35D3E20 Offset: 0x35D3F21 VA: 0x35D3E20
	|-Dictionary.KeyCollection.Enumerator<object, Int32Enum>.MoveNext
	|
	|-RVA: 0x35D4A60 Offset: 0x35D4B61 VA: 0x35D4A60
	|-Dictionary.KeyCollection.Enumerator<object, IntPtr>.MoveNext
	|-Dictionary.KeyCollection.Enumerator<string, IntPtr>.MoveNext
	|
	|-RVA: 0x35D5DB0 Offset: 0x35D5EB1 VA: 0x35D5DB0
	|-Dictionary.KeyCollection.Enumerator<object, object>.MoveNext
	|-Dictionary.KeyCollection.Enumerator<ParameterExpression, LocalVariable>.MoveNext
	|-Dictionary.KeyCollection.Enumerator<Renderer, Material[]>.MoveNext
	|-Dictionary.KeyCollection.Enumerator<string, GodBond>.MoveNext
	|-Dictionary.KeyCollection.Enumerator<string, GodUnit>.MoveNext
	|-Dictionary.KeyCollection.Enumerator<string, GodWeaponRefineLevels>.MoveNext
	|-Dictionary.KeyCollection.Enumerator<string, string>.MoveNext
	|
	|-RVA: 0x35D7130 Offset: 0x35D7231 VA: 0x35D7130
	|-Dictionary.KeyCollection.Enumerator<object, Playable>.MoveNext
	|
	|-RVA: 0x35D7DD0 Offset: 0x35D7ED1 VA: 0x35D7DD0
	|-Dictionary.KeyCollection.Enumerator<object, ResourceLocator>.MoveNext
	|
	|-RVA: 0x35D8A30 Offset: 0x35D8B31 VA: 0x35D8A30
	|-Dictionary.KeyCollection.Enumerator<object, float>.MoveNext
	|
	|-RVA: 0x35D9670 Offset: 0x35D9771 VA: 0x35D9670
	|-Dictionary.KeyCollection.Enumerator<object, ushort>.MoveNext
	|
	|-RVA: 0x35DA310 Offset: 0x35DA411 VA: 0x35DA310
	|-Dictionary.KeyCollection.Enumerator<object, GameVariable.Value>.MoveNext
	|-Dictionary.KeyCollection.Enumerator<string, GameVariable.Value>.MoveNext
	|
	|-RVA: 0x35DB0B0 Offset: 0x35DB1B1 VA: 0x35DB0B0
	|-Dictionary.KeyCollection.Enumerator<sbyte, DataStoreRatingInfo>.MoveNext
	|
	|-RVA: 0x35DBD50 Offset: 0x35DBE51 VA: 0x35DBD50
	|-Dictionary.KeyCollection.Enumerator<sbyte, object>.MoveNext
	|
	|-RVA: 0x35DCA90 Offset: 0x35DCB91 VA: 0x35DCA90
	|-Dictionary.KeyCollection.Enumerator<ushort, int>.MoveNext
	|
	|-RVA: 0x3761FA0 Offset: 0x37620A1 VA: 0x3761FA0
	|-Dictionary.KeyCollection.Enumerator<uint, int>.MoveNext
	|
	|-RVA: 0x3762BF0 Offset: 0x3762CF1 VA: 0x3762BF0
	|-Dictionary.KeyCollection.Enumerator<uint, object>.MoveNext
	|
	|-RVA: 0x37639A0 Offset: 0x3763AA1 VA: 0x37639A0
	|-Dictionary.KeyCollection.Enumerator<ulong, Friend>.MoveNext
	|
	|-RVA: 0x3764770 Offset: 0x3764871 VA: 0x3764770
	|-Dictionary.KeyCollection.Enumerator<ulong, Int32Enum>.MoveNext
	|-Dictionary.KeyCollection.Enumerator<ulong, NexVersus.TargetSlotList.Results>.MoveNext
	|
	|-RVA: 0x37653E0 Offset: 0x37654E1 VA: 0x37653E0
	|-Dictionary.KeyCollection.Enumerator<ulong, object>.MoveNext
	|-Dictionary.KeyCollection.Enumerator<ulong, RelayUserGlobalData.Ticket>.MoveNext
	|
	|-RVA: 0x3766150 Offset: 0x3766251 VA: 0x3766150
	|-Dictionary.KeyCollection.Enumerator<Vector3, int>.MoveNext
	|
	|-RVA: 0x3766F80 Offset: 0x3767081 VA: 0x3766F80
	|-Dictionary.KeyCollection.Enumerator<XPathNodeRef, XPathNodeRef>.MoveNext
	|
	|-RVA: 0x3767C30 Offset: 0x3767D31 VA: 0x3767C30
	|-Dictionary.KeyCollection.Enumerator<TerrainUtility.TerrainMap.TileCoord, object>.MoveNext
	|-Dictionary.KeyCollection.Enumerator<TerrainUtility.TerrainMap.TileCoord, Terrain>.MoveNext
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public TKey get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x349A8D0 Offset: 0x349A9D1 VA: 0x349A8D0
	|-Dictionary.KeyCollection.Enumerator<ValueTuple<object, int>, object>.get_Current
	|
	|-RVA: 0x349B510 Offset: 0x349B611 VA: 0x349B510
	|-Dictionary.KeyCollection.Enumerator<byte, object>.get_Current
	|
	|-RVA: 0x349C150 Offset: 0x349C251 VA: 0x349C150
	|-Dictionary.KeyCollection.Enumerator<CancellationToken, object>.get_Current
	|
	|-RVA: 0x349CD80 Offset: 0x349CE81 VA: 0x349CD80
	|-Dictionary.KeyCollection.Enumerator<char, object>.get_Current
	|
	|-RVA: 0x349DA00 Offset: 0x349DB01 VA: 0x349DA00
	|-Dictionary.KeyCollection.Enumerator<Guid, object>.get_Current
	|
	|-RVA: 0x349F1B0 Offset: 0x349F2B1 VA: 0x349F1B0
	|-Dictionary.KeyCollection.Enumerator<int, bool>.get_Current
	|
	|-RVA: 0x34A06F0 Offset: 0x34A07F1 VA: 0x34A06F0
	|-Dictionary.KeyCollection.Enumerator<int, byte>.get_Current
	|
	|-RVA: 0x34A1450 Offset: 0x34A1551 VA: 0x34A1450
	|-Dictionary.KeyCollection.Enumerator<int, char>.get_Current
	|
	|-RVA: 0x34A2290 Offset: 0x34A2391 VA: 0x34A2290
	|-Dictionary.KeyCollection.Enumerator<int, DiagnosticEvent>.get_Current
	|
	|-RVA: 0x34A3AE0 Offset: 0x34A3BE1 VA: 0x34A3AE0
	|-Dictionary.KeyCollection.Enumerator<int, int>.get_Current
	|
	|-RVA: 0x34A5020 Offset: 0x34A5121 VA: 0x34A5020
	|-Dictionary.KeyCollection.Enumerator<int, Int32Enum>.get_Current
	|
	|-RVA: 0x34A5DA0 Offset: 0x34A5EA1 VA: 0x34A5DA0
	|-Dictionary.KeyCollection.Enumerator<int, long>.get_Current
	|
	|-RVA: 0x34A6B40 Offset: 0x34A6C41 VA: 0x34A6B40
	|-Dictionary.KeyCollection.Enumerator<int, MapPos>.get_Current
	|
	|-RVA: 0x34A77B0 Offset: 0x34A78B1 VA: 0x34A77B0
	|-Dictionary.KeyCollection.Enumerator<int, object>.get_Current
	|-Dictionary.KeyCollection.Enumerator<int, MapHistory.Rewind.OverlapData>.get_Current
	|
	|-RVA: 0x34A84E0 Offset: 0x34A85E1 VA: 0x34A84E0
	|-Dictionary.KeyCollection.Enumerator<int, uint>.get_Current
	|
	|-RVA: 0x34A9240 Offset: 0x34A9341 VA: 0x34A9240
	|-Dictionary.KeyCollection.Enumerator<int, AIThink.EnchantThink.SurroundingInfo>.get_Current
	|
	|-RVA: 0x34A9FB0 Offset: 0x34AA0B1 VA: 0x34A9FB0
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, bool>.get_Current
	|
	|-RVA: 0x34AAD10 Offset: 0x34AAE11 VA: 0x34AAD10
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, int>.get_Current
	|
	|-RVA: 0x35CCE70 Offset: 0x35CCF71 VA: 0x35CCE70
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, Int32Enum>.get_Current
	|
	|-RVA: 0x35CDAD0 Offset: 0x35CDBD1 VA: 0x35CDAD0
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, object>.get_Current
	|
	|-RVA: 0x35CE700 Offset: 0x35CE801 VA: 0x35CE700
	|-Dictionary.KeyCollection.Enumerator<long, object>.get_Current
	|
	|-RVA: 0x35D32F0 Offset: 0x35D33F1 VA: 0x35D32F0
	|-Dictionary.KeyCollection.Enumerator<ItemData, int>.get_Current
	|-Dictionary.KeyCollection.Enumerator<object, int>.get_Current
	|-Dictionary.KeyCollection.Enumerator<string, int>.get_Current
	|
	|-RVA: 0x35CF460 Offset: 0x35CF561 VA: 0x35CF460
	|-Dictionary.KeyCollection.Enumerator<MapPos, int>.get_Current
	|
	|-RVA: 0x35D0130 Offset: 0x35D0231 VA: 0x35D0130
	|-Dictionary.KeyCollection.Enumerator<object, AsyncOperationHandle<object>>.get_Current
	|
	|-RVA: 0x35D0DF0 Offset: 0x35D0EF1 VA: 0x35D0DF0
	|-Dictionary.KeyCollection.Enumerator<object, AsyncOperationHandle>.get_Current
	|
	|-RVA: 0x35D1A70 Offset: 0x35D1B71 VA: 0x35D1A70
	|-Dictionary.KeyCollection.Enumerator<object, bool>.get_Current
	|-Dictionary.KeyCollection.Enumerator<string, bool>.get_Current
	|
	|-RVA: 0x35D26B0 Offset: 0x35D27B1 VA: 0x35D26B0
	|-Dictionary.KeyCollection.Enumerator<object, byte>.get_Current
	|
	|-RVA: 0x35D3F30 Offset: 0x35D4031 VA: 0x35D3F30
	|-Dictionary.KeyCollection.Enumerator<object, Int32Enum>.get_Current
	|
	|-RVA: 0x35D4B70 Offset: 0x35D4C71 VA: 0x35D4B70
	|-Dictionary.KeyCollection.Enumerator<object, IntPtr>.get_Current
	|-Dictionary.KeyCollection.Enumerator<string, IntPtr>.get_Current
	|
	|-RVA: 0x35D5EC0 Offset: 0x35D5FC1 VA: 0x35D5EC0
	|-Dictionary.KeyCollection.Enumerator<object, object>.get_Current
	|-Dictionary.KeyCollection.Enumerator<ParameterExpression, LocalVariable>.get_Current
	|-Dictionary.KeyCollection.Enumerator<Renderer, Material[]>.get_Current
	|-Dictionary.KeyCollection.Enumerator<string, GodBond>.get_Current
	|-Dictionary.KeyCollection.Enumerator<string, GodUnit>.get_Current
	|-Dictionary.KeyCollection.Enumerator<string, GodWeaponRefineLevels>.get_Current
	|-Dictionary.KeyCollection.Enumerator<string, string>.get_Current
	|
	|-RVA: 0x35D7240 Offset: 0x35D7341 VA: 0x35D7240
	|-Dictionary.KeyCollection.Enumerator<object, Playable>.get_Current
	|
	|-RVA: 0x35D7EE0 Offset: 0x35D7FE1 VA: 0x35D7EE0
	|-Dictionary.KeyCollection.Enumerator<object, ResourceLocator>.get_Current
	|
	|-RVA: 0x35D8B40 Offset: 0x35D8C41 VA: 0x35D8B40
	|-Dictionary.KeyCollection.Enumerator<object, float>.get_Current
	|
	|-RVA: 0x35D9780 Offset: 0x35D9881 VA: 0x35D9780
	|-Dictionary.KeyCollection.Enumerator<object, ushort>.get_Current
	|
	|-RVA: 0x35DA420 Offset: 0x35DA521 VA: 0x35DA420
	|-Dictionary.KeyCollection.Enumerator<object, GameVariable.Value>.get_Current
	|-Dictionary.KeyCollection.Enumerator<string, GameVariable.Value>.get_Current
	|
	|-RVA: 0x35DB1C0 Offset: 0x35DB2C1 VA: 0x35DB1C0
	|-Dictionary.KeyCollection.Enumerator<sbyte, DataStoreRatingInfo>.get_Current
	|
	|-RVA: 0x35DBE60 Offset: 0x35DBF61 VA: 0x35DBE60
	|-Dictionary.KeyCollection.Enumerator<sbyte, object>.get_Current
	|
	|-RVA: 0x35DCB90 Offset: 0x35DCC91 VA: 0x35DCB90
	|-Dictionary.KeyCollection.Enumerator<ushort, int>.get_Current
	|
	|-RVA: 0x37620A0 Offset: 0x37621A1 VA: 0x37620A0
	|-Dictionary.KeyCollection.Enumerator<uint, int>.get_Current
	|
	|-RVA: 0x3762D00 Offset: 0x3762E01 VA: 0x3762D00
	|-Dictionary.KeyCollection.Enumerator<uint, object>.get_Current
	|
	|-RVA: 0x3763AB0 Offset: 0x3763BB1 VA: 0x3763AB0
	|-Dictionary.KeyCollection.Enumerator<ulong, Friend>.get_Current
	|
	|-RVA: 0x3764880 Offset: 0x3764981 VA: 0x3764880
	|-Dictionary.KeyCollection.Enumerator<ulong, Int32Enum>.get_Current
	|-Dictionary.KeyCollection.Enumerator<ulong, NexVersus.TargetSlotList.Results>.get_Current
	|
	|-RVA: 0x37654F0 Offset: 0x37655F1 VA: 0x37654F0
	|-Dictionary.KeyCollection.Enumerator<ulong, object>.get_Current
	|-Dictionary.KeyCollection.Enumerator<ulong, RelayUserGlobalData.Ticket>.get_Current
	|
	|-RVA: 0x3766270 Offset: 0x3766371 VA: 0x3766270
	|-Dictionary.KeyCollection.Enumerator<Vector3, int>.get_Current
	|
	|-RVA: 0x37670A0 Offset: 0x37671A1 VA: 0x37670A0
	|-Dictionary.KeyCollection.Enumerator<XPathNodeRef, XPathNodeRef>.get_Current
	|
	|-RVA: 0x3767D40 Offset: 0x3767E41 VA: 0x3767D40
	|-Dictionary.KeyCollection.Enumerator<TerrainUtility.TerrainMap.TileCoord, object>.get_Current
	|-Dictionary.KeyCollection.Enumerator<TerrainUtility.TerrainMap.TileCoord, Terrain>.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x349A8E0 Offset: 0x349A9E1 VA: 0x349A8E0
	|-Dictionary.KeyCollection.Enumerator<ValueTuple<object, int>, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x349B520 Offset: 0x349B621 VA: 0x349B520
	|-Dictionary.KeyCollection.Enumerator<byte, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x349C160 Offset: 0x349C261 VA: 0x349C160
	|-Dictionary.KeyCollection.Enumerator<CancellationToken, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x349CD90 Offset: 0x349CE91 VA: 0x349CD90
	|-Dictionary.KeyCollection.Enumerator<char, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x349DA10 Offset: 0x349DB11 VA: 0x349DA10
	|-Dictionary.KeyCollection.Enumerator<Guid, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x349F1C0 Offset: 0x349F2C1 VA: 0x349F1C0
	|-Dictionary.KeyCollection.Enumerator<int, bool>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x34A0700 Offset: 0x34A0801 VA: 0x34A0700
	|-Dictionary.KeyCollection.Enumerator<int, byte>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x34A1460 Offset: 0x34A1561 VA: 0x34A1460
	|-Dictionary.KeyCollection.Enumerator<int, char>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x34A22A0 Offset: 0x34A23A1 VA: 0x34A22A0
	|-Dictionary.KeyCollection.Enumerator<int, DiagnosticEvent>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x34A3AF0 Offset: 0x34A3BF1 VA: 0x34A3AF0
	|-Dictionary.KeyCollection.Enumerator<int, int>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x34A5030 Offset: 0x34A5131 VA: 0x34A5030
	|-Dictionary.KeyCollection.Enumerator<int, Int32Enum>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x34A5DB0 Offset: 0x34A5EB1 VA: 0x34A5DB0
	|-Dictionary.KeyCollection.Enumerator<int, long>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x34A6B50 Offset: 0x34A6C51 VA: 0x34A6B50
	|-Dictionary.KeyCollection.Enumerator<int, MapPos>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x34A77C0 Offset: 0x34A78C1 VA: 0x34A77C0
	|-Dictionary.KeyCollection.Enumerator<int, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x34A84F0 Offset: 0x34A85F1 VA: 0x34A84F0
	|-Dictionary.KeyCollection.Enumerator<int, uint>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x34A9250 Offset: 0x34A9351 VA: 0x34A9250
	|-Dictionary.KeyCollection.Enumerator<int, AIThink.EnchantThink.SurroundingInfo>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x34A9FC0 Offset: 0x34AA0C1 VA: 0x34A9FC0
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, bool>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x34AAD20 Offset: 0x34AAE21 VA: 0x34AAD20
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, int>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x35CCE80 Offset: 0x35CCF81 VA: 0x35CCE80
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, Int32Enum>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x35CDAE0 Offset: 0x35CDBE1 VA: 0x35CDAE0
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x35CE710 Offset: 0x35CE811 VA: 0x35CE710
	|-Dictionary.KeyCollection.Enumerator<long, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x35CF470 Offset: 0x35CF571 VA: 0x35CF470
	|-Dictionary.KeyCollection.Enumerator<MapPos, int>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x35D0140 Offset: 0x35D0241 VA: 0x35D0140
	|-Dictionary.KeyCollection.Enumerator<object, AsyncOperationHandle<object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x35D0E00 Offset: 0x35D0F01 VA: 0x35D0E00
	|-Dictionary.KeyCollection.Enumerator<object, AsyncOperationHandle>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x35D1A80 Offset: 0x35D1B81 VA: 0x35D1A80
	|-Dictionary.KeyCollection.Enumerator<object, bool>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x35D26C0 Offset: 0x35D27C1 VA: 0x35D26C0
	|-Dictionary.KeyCollection.Enumerator<object, byte>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x35D3300 Offset: 0x35D3401 VA: 0x35D3300
	|-Dictionary.KeyCollection.Enumerator<object, int>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x35D3F40 Offset: 0x35D4041 VA: 0x35D3F40
	|-Dictionary.KeyCollection.Enumerator<object, Int32Enum>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x35D4B80 Offset: 0x35D4C81 VA: 0x35D4B80
	|-Dictionary.KeyCollection.Enumerator<object, IntPtr>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x35D5ED0 Offset: 0x35D5FD1 VA: 0x35D5ED0
	|-Dictionary.KeyCollection.Enumerator<object, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x35D7250 Offset: 0x35D7351 VA: 0x35D7250
	|-Dictionary.KeyCollection.Enumerator<object, Playable>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x35D7EF0 Offset: 0x35D7FF1 VA: 0x35D7EF0
	|-Dictionary.KeyCollection.Enumerator<object, ResourceLocator>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x35D8B50 Offset: 0x35D8C51 VA: 0x35D8B50
	|-Dictionary.KeyCollection.Enumerator<object, float>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x35D9790 Offset: 0x35D9891 VA: 0x35D9790
	|-Dictionary.KeyCollection.Enumerator<object, ushort>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x35DA430 Offset: 0x35DA531 VA: 0x35DA430
	|-Dictionary.KeyCollection.Enumerator<object, GameVariable.Value>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x35DB1D0 Offset: 0x35DB2D1 VA: 0x35DB1D0
	|-Dictionary.KeyCollection.Enumerator<sbyte, DataStoreRatingInfo>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x35DBE70 Offset: 0x35DBF71 VA: 0x35DBE70
	|-Dictionary.KeyCollection.Enumerator<sbyte, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x35DCBA0 Offset: 0x35DCCA1 VA: 0x35DCBA0
	|-Dictionary.KeyCollection.Enumerator<ushort, int>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x37620B0 Offset: 0x37621B1 VA: 0x37620B0
	|-Dictionary.KeyCollection.Enumerator<uint, int>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x3762D10 Offset: 0x3762E11 VA: 0x3762D10
	|-Dictionary.KeyCollection.Enumerator<uint, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x3763AC0 Offset: 0x3763BC1 VA: 0x3763AC0
	|-Dictionary.KeyCollection.Enumerator<ulong, Friend>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x3764890 Offset: 0x3764991 VA: 0x3764890
	|-Dictionary.KeyCollection.Enumerator<ulong, Int32Enum>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x3765500 Offset: 0x3765601 VA: 0x3765500
	|-Dictionary.KeyCollection.Enumerator<ulong, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x3766280 Offset: 0x3766381 VA: 0x3766280
	|-Dictionary.KeyCollection.Enumerator<Vector3, int>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x37670B0 Offset: 0x37671B1 VA: 0x37670B0
	|-Dictionary.KeyCollection.Enumerator<XPathNodeRef, XPathNodeRef>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x3767D50 Offset: 0x3767E51 VA: 0x3767D50
	|-Dictionary.KeyCollection.Enumerator<TerrainUtility.TerrainMap.TileCoord, object>.System.Collections.IEnumerator.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x349A9B0 Offset: 0x349AAB1 VA: 0x349A9B0
	|-Dictionary.KeyCollection.Enumerator<ValueTuple<object, int>, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x349B5E0 Offset: 0x349B6E1 VA: 0x349B5E0
	|-Dictionary.KeyCollection.Enumerator<byte, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x349C220 Offset: 0x349C321 VA: 0x349C220
	|-Dictionary.KeyCollection.Enumerator<CancellationToken, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x349CE50 Offset: 0x349CF51 VA: 0x349CE50
	|-Dictionary.KeyCollection.Enumerator<char, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x349DAE0 Offset: 0x349DBE1 VA: 0x349DAE0
	|-Dictionary.KeyCollection.Enumerator<Guid, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x349F280 Offset: 0x349F381 VA: 0x349F280
	|-Dictionary.KeyCollection.Enumerator<int, bool>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x34A07C0 Offset: 0x34A08C1 VA: 0x34A07C0
	|-Dictionary.KeyCollection.Enumerator<int, byte>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x34A1520 Offset: 0x34A1621 VA: 0x34A1520
	|-Dictionary.KeyCollection.Enumerator<int, char>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x34A2360 Offset: 0x34A2461 VA: 0x34A2360
	|-Dictionary.KeyCollection.Enumerator<int, DiagnosticEvent>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x34A3BB0 Offset: 0x34A3CB1 VA: 0x34A3BB0
	|-Dictionary.KeyCollection.Enumerator<int, int>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x34A50F0 Offset: 0x34A51F1 VA: 0x34A50F0
	|-Dictionary.KeyCollection.Enumerator<int, Int32Enum>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x34A5E70 Offset: 0x34A5F71 VA: 0x34A5E70
	|-Dictionary.KeyCollection.Enumerator<int, long>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x34A6C10 Offset: 0x34A6D11 VA: 0x34A6C10
	|-Dictionary.KeyCollection.Enumerator<int, MapPos>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x34A7880 Offset: 0x34A7981 VA: 0x34A7880
	|-Dictionary.KeyCollection.Enumerator<int, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x34A85B0 Offset: 0x34A86B1 VA: 0x34A85B0
	|-Dictionary.KeyCollection.Enumerator<int, uint>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x34A9310 Offset: 0x34A9411 VA: 0x34A9310
	|-Dictionary.KeyCollection.Enumerator<int, AIThink.EnchantThink.SurroundingInfo>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x34AA080 Offset: 0x34AA181 VA: 0x34AA080
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, bool>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x34AADE0 Offset: 0x34AAEE1 VA: 0x34AADE0
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, int>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x35CCF40 Offset: 0x35CD041 VA: 0x35CCF40
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, Int32Enum>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x35CDBA0 Offset: 0x35CDCA1 VA: 0x35CDBA0
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x35CE7D0 Offset: 0x35CE8D1 VA: 0x35CE7D0
	|-Dictionary.KeyCollection.Enumerator<long, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x35CF530 Offset: 0x35CF631 VA: 0x35CF530
	|-Dictionary.KeyCollection.Enumerator<MapPos, int>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x35D01C0 Offset: 0x35D02C1 VA: 0x35D01C0
	|-Dictionary.KeyCollection.Enumerator<object, AsyncOperationHandle<object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x35D0E80 Offset: 0x35D0F81 VA: 0x35D0E80
	|-Dictionary.KeyCollection.Enumerator<object, AsyncOperationHandle>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x35D1B00 Offset: 0x35D1C01 VA: 0x35D1B00
	|-Dictionary.KeyCollection.Enumerator<object, bool>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x35D2740 Offset: 0x35D2841 VA: 0x35D2740
	|-Dictionary.KeyCollection.Enumerator<object, byte>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x35D3380 Offset: 0x35D3481 VA: 0x35D3380
	|-Dictionary.KeyCollection.Enumerator<object, int>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x35D3FC0 Offset: 0x35D40C1 VA: 0x35D3FC0
	|-Dictionary.KeyCollection.Enumerator<object, Int32Enum>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x35D4C00 Offset: 0x35D4D01 VA: 0x35D4C00
	|-Dictionary.KeyCollection.Enumerator<object, IntPtr>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x35D5F50 Offset: 0x35D6051 VA: 0x35D5F50
	|-Dictionary.KeyCollection.Enumerator<object, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x35D72D0 Offset: 0x35D73D1 VA: 0x35D72D0
	|-Dictionary.KeyCollection.Enumerator<object, Playable>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x35D7F70 Offset: 0x35D8071 VA: 0x35D7F70
	|-Dictionary.KeyCollection.Enumerator<object, ResourceLocator>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x35D8BD0 Offset: 0x35D8CD1 VA: 0x35D8BD0
	|-Dictionary.KeyCollection.Enumerator<object, float>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x35D9810 Offset: 0x35D9911 VA: 0x35D9810
	|-Dictionary.KeyCollection.Enumerator<object, ushort>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x35DA4B0 Offset: 0x35DA5B1 VA: 0x35DA4B0
	|-Dictionary.KeyCollection.Enumerator<object, GameVariable.Value>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x35DB290 Offset: 0x35DB391 VA: 0x35DB290
	|-Dictionary.KeyCollection.Enumerator<sbyte, DataStoreRatingInfo>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x35DBF30 Offset: 0x35DC031 VA: 0x35DBF30
	|-Dictionary.KeyCollection.Enumerator<sbyte, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x35DCC60 Offset: 0x35DCD61 VA: 0x35DCC60
	|-Dictionary.KeyCollection.Enumerator<ushort, int>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x3762170 Offset: 0x3762271 VA: 0x3762170
	|-Dictionary.KeyCollection.Enumerator<uint, int>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x3762DD0 Offset: 0x3762ED1 VA: 0x3762DD0
	|-Dictionary.KeyCollection.Enumerator<uint, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x3763B80 Offset: 0x3763C81 VA: 0x3763B80
	|-Dictionary.KeyCollection.Enumerator<ulong, Friend>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x3764950 Offset: 0x3764A51 VA: 0x3764950
	|-Dictionary.KeyCollection.Enumerator<ulong, Int32Enum>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x37655C0 Offset: 0x37656C1 VA: 0x37655C0
	|-Dictionary.KeyCollection.Enumerator<ulong, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x3766350 Offset: 0x3766451 VA: 0x3766350
	|-Dictionary.KeyCollection.Enumerator<Vector3, int>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x3767180 Offset: 0x3767281 VA: 0x3767180
	|-Dictionary.KeyCollection.Enumerator<XPathNodeRef, XPathNodeRef>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x3767E10 Offset: 0x3767F11 VA: 0x3767E10
	|-Dictionary.KeyCollection.Enumerator<TerrainUtility.TerrainMap.TileCoord, object>.System.Collections.IEnumerator.Reset
	*/
}

// Namespace: 
[DebuggerTypeProxyAttribute] // RVA: 0x477570 Offset: 0x477671 VA: 0x477570
[DebuggerDisplayAttribute] // RVA: 0x477570 Offset: 0x477671 VA: 0x477570
[Serializable]
public sealed class Dictionary.KeyCollection<TKey, TValue> : ICollection<TKey>, IEnumerable<TKey>, IEnumerable, ICollection, IReadOnlyCollection<TKey> // TypeDefIndex: 1404
{
	// Fields
	private Dictionary<TKey, TValue> dictionary; // 0x0

	// Properties
	public int Count { get; }
	private bool System.Collections.Generic.ICollection<TKey>.IsReadOnly { get; }
	private bool System.Collections.ICollection.IsSynchronized { get; }
	private object System.Collections.ICollection.SyncRoot { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(Dictionary<TKey, TValue> dictionary) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2F7EFB0 Offset: 0x2F7F0B1 VA: 0x2F7EFB0
	|-Dictionary.KeyCollection<ValueTuple<object, int>, object>..ctor
	|
	|-RVA: 0x2F7F9E0 Offset: 0x2F7FAE1 VA: 0x2F7F9E0
	|-Dictionary.KeyCollection<byte, object>..ctor
	|
	|-RVA: 0x2F803F0 Offset: 0x2F804F1 VA: 0x2F803F0
	|-Dictionary.KeyCollection<CancellationToken, object>..ctor
	|
	|-RVA: 0x2F80E20 Offset: 0x2F80F21 VA: 0x2F80E20
	|-Dictionary.KeyCollection<char, object>..ctor
	|
	|-RVA: 0x2F81830 Offset: 0x2F81931 VA: 0x2F81830
	|-Dictionary.KeyCollection<Guid, object>..ctor
	|
	|-RVA: 0x2F82250 Offset: 0x2F82351 VA: 0x2F82250
	|-Dictionary.KeyCollection<int, bool>..ctor
	|
	|-RVA: 0x2F836A0 Offset: 0x2F837A1 VA: 0x2F836A0
	|-Dictionary.KeyCollection<int, byte>..ctor
	|
	|-RVA: 0x2F840B0 Offset: 0x2F841B1 VA: 0x2F840B0
	|-Dictionary.KeyCollection<int, char>..ctor
	|
	|-RVA: 0x2F84AC0 Offset: 0x2F84BC1 VA: 0x2F84AC0
	|-Dictionary.KeyCollection<int, DiagnosticEvent>..ctor
	|
	|-RVA: 0x2F854D0 Offset: 0x2F855D1 VA: 0x2F854D0
	|-Dictionary.KeyCollection<int, int>..ctor
	|
	|-RVA: 0x2F86920 Offset: 0x2F86A21 VA: 0x2F86920
	|-Dictionary.KeyCollection<int, Int32Enum>..ctor
	|
	|-RVA: 0x2F87330 Offset: 0x2F87431 VA: 0x2F87330
	|-Dictionary.KeyCollection<int, long>..ctor
	|
	|-RVA: 0x2F87D40 Offset: 0x2F87E41 VA: 0x2F87D40
	|-Dictionary.KeyCollection<int, MapPos>..ctor
	|
	|-RVA: 0x2F88750 Offset: 0x2F88851 VA: 0x2F88750
	|-Dictionary.KeyCollection<int, object>..ctor
	|
	|-RVA: 0x2F89160 Offset: 0x2F89261 VA: 0x2F89160
	|-Dictionary.KeyCollection<int, uint>..ctor
	|
	|-RVA: 0x2F89B70 Offset: 0x2F89C71 VA: 0x2F89B70
	|-Dictionary.KeyCollection<int, AIThink.EnchantThink.SurroundingInfo>..ctor
	|
	|-RVA: 0x2F8A580 Offset: 0x2F8A681 VA: 0x2F8A580
	|-Dictionary.KeyCollection<Int32Enum, bool>..ctor
	|
	|-RVA: 0x2F8AF90 Offset: 0x2F8B091 VA: 0x2F8AF90
	|-Dictionary.KeyCollection<Int32Enum, int>..ctor
	|
	|-RVA: 0x2F8B9A0 Offset: 0x2F8BAA1 VA: 0x2F8B9A0
	|-Dictionary.KeyCollection<Int32Enum, Int32Enum>..ctor
	|
	|-RVA: 0x2F8C3B0 Offset: 0x2F8C4B1 VA: 0x2F8C3B0
	|-Dictionary.KeyCollection<Int32Enum, object>..ctor
	|
	|-RVA: 0x2F8CDC0 Offset: 0x2F8CEC1 VA: 0x2F8CDC0
	|-Dictionary.KeyCollection<long, object>..ctor
	|
	|-RVA: 0x2F8D7D0 Offset: 0x2F8D8D1 VA: 0x2F8D7D0
	|-Dictionary.KeyCollection<MapPos, int>..ctor
	|
	|-RVA: 0x2F8E1E0 Offset: 0x2F8E2E1 VA: 0x2F8E1E0
	|-Dictionary.KeyCollection<object, AsyncOperationHandle<object>>..ctor
	|
	|-RVA: 0x2F8EBD0 Offset: 0x2F8ECD1 VA: 0x2F8EBD0
	|-Dictionary.KeyCollection<object, AsyncOperationHandle>..ctor
	|
	|-RVA: 0x2F8F5C0 Offset: 0x2F8F6C1 VA: 0x2F8F5C0
	|-Dictionary.KeyCollection<object, bool>..ctor
	|
	|-RVA: 0x288C130 Offset: 0x288C231 VA: 0x288C130
	|-Dictionary.KeyCollection<object, byte>..ctor
	|
	|-RVA: 0x288CB20 Offset: 0x288CC21 VA: 0x288CB20
	|-Dictionary.KeyCollection<object, int>..ctor
	|
	|-RVA: 0x288D510 Offset: 0x288D611 VA: 0x288D510
	|-Dictionary.KeyCollection<object, Int32Enum>..ctor
	|
	|-RVA: 0x288DF00 Offset: 0x288E001 VA: 0x288DF00
	|-Dictionary.KeyCollection<object, IntPtr>..ctor
	|
	|-RVA: 0x288E8F0 Offset: 0x288E9F1 VA: 0x288E8F0
	|-Dictionary.KeyCollection<object, object>..ctor
	|
	|-RVA: 0x288FD20 Offset: 0x288FE21 VA: 0x288FD20
	|-Dictionary.KeyCollection<object, Playable>..ctor
	|
	|-RVA: 0x2890710 Offset: 0x2890811 VA: 0x2890710
	|-Dictionary.KeyCollection<object, ResourceLocator>..ctor
	|
	|-RVA: 0x2891100 Offset: 0x2891201 VA: 0x2891100
	|-Dictionary.KeyCollection<object, float>..ctor
	|
	|-RVA: 0x2891AF0 Offset: 0x2891BF1 VA: 0x2891AF0
	|-Dictionary.KeyCollection<object, ushort>..ctor
	|
	|-RVA: 0x28924E0 Offset: 0x28925E1 VA: 0x28924E0
	|-Dictionary.KeyCollection<object, GameVariable.Value>..ctor
	|
	|-RVA: 0x2892ED0 Offset: 0x2892FD1 VA: 0x2892ED0
	|-Dictionary.KeyCollection<sbyte, DataStoreRatingInfo>..ctor
	|
	|-RVA: 0x28938E0 Offset: 0x28939E1 VA: 0x28938E0
	|-Dictionary.KeyCollection<sbyte, object>..ctor
	|
	|-RVA: 0x28942F0 Offset: 0x28943F1 VA: 0x28942F0
	|-Dictionary.KeyCollection<ushort, int>..ctor
	|
	|-RVA: 0x2894D00 Offset: 0x2894E01 VA: 0x2894D00
	|-Dictionary.KeyCollection<uint, int>..ctor
	|
	|-RVA: 0x2895710 Offset: 0x2895811 VA: 0x2895710
	|-Dictionary.KeyCollection<uint, object>..ctor
	|
	|-RVA: 0x2896120 Offset: 0x2896221 VA: 0x2896120
	|-Dictionary.KeyCollection<ulong, Friend>..ctor
	|
	|-RVA: 0x2896B30 Offset: 0x2896C31 VA: 0x2896B30
	|-Dictionary.KeyCollection<ulong, Int32Enum>..ctor
	|
	|-RVA: 0x2897540 Offset: 0x2897641 VA: 0x2897540
	|-Dictionary.KeyCollection<ulong, object>..ctor
	|
	|-RVA: 0x2897F50 Offset: 0x2898051 VA: 0x2897F50
	|-Dictionary.KeyCollection<Vector3, int>..ctor
	|
	|-RVA: 0x2898980 Offset: 0x2898A81 VA: 0x2898980
	|-Dictionary.KeyCollection<XPathNodeRef, XPathNodeRef>..ctor
	|
	|-RVA: 0x28993B0 Offset: 0x28994B1 VA: 0x28993B0
	|-Dictionary.KeyCollection<TerrainUtility.TerrainMap.TileCoord, object>..ctor
	*/

	// RVA: -1 Offset: -1
	public Dictionary.KeyCollection.Enumerator<TKey, TValue> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2F7F030 Offset: 0x2F7F131 VA: 0x2F7F030
	|-Dictionary.KeyCollection<ValueTuple<object, int>, object>.GetEnumerator
	|
	|-RVA: 0x2F7FA60 Offset: 0x2F7FB61 VA: 0x2F7FA60
	|-Dictionary.KeyCollection<byte, object>.GetEnumerator
	|
	|-RVA: 0x2F80470 Offset: 0x2F80571 VA: 0x2F80470
	|-Dictionary.KeyCollection<CancellationToken, object>.GetEnumerator
	|
	|-RVA: 0x2F80EA0 Offset: 0x2F80FA1 VA: 0x2F80EA0
	|-Dictionary.KeyCollection<char, object>.GetEnumerator
	|
	|-RVA: 0x2F818B0 Offset: 0x2F819B1 VA: 0x2F818B0
	|-Dictionary.KeyCollection<Guid, object>.GetEnumerator
	|
	|-RVA: 0x2F822D0 Offset: 0x2F823D1 VA: 0x2F822D0
	|-Dictionary.KeyCollection<int, bool>.GetEnumerator
	|
	|-RVA: 0x2F83720 Offset: 0x2F83821 VA: 0x2F83720
	|-Dictionary.KeyCollection<int, byte>.GetEnumerator
	|
	|-RVA: 0x2F84130 Offset: 0x2F84231 VA: 0x2F84130
	|-Dictionary.KeyCollection<int, char>.GetEnumerator
	|
	|-RVA: 0x2F84B40 Offset: 0x2F84C41 VA: 0x2F84B40
	|-Dictionary.KeyCollection<int, DiagnosticEvent>.GetEnumerator
	|
	|-RVA: 0x2F85550 Offset: 0x2F85651 VA: 0x2F85550
	|-Dictionary.KeyCollection<int, int>.GetEnumerator
	|
	|-RVA: 0x2F869A0 Offset: 0x2F86AA1 VA: 0x2F869A0
	|-Dictionary.KeyCollection<int, Int32Enum>.GetEnumerator
	|
	|-RVA: 0x2F873B0 Offset: 0x2F874B1 VA: 0x2F873B0
	|-Dictionary.KeyCollection<int, long>.GetEnumerator
	|
	|-RVA: 0x2F87DC0 Offset: 0x2F87EC1 VA: 0x2F87DC0
	|-Dictionary.KeyCollection<int, MapPos>.GetEnumerator
	|
	|-RVA: 0x2F887D0 Offset: 0x2F888D1 VA: 0x2F887D0
	|-Dictionary.KeyCollection<int, object>.GetEnumerator
	|-Dictionary.KeyCollection<int, MapHistory.Rewind.OverlapData>.GetEnumerator
	|
	|-RVA: 0x2F891E0 Offset: 0x2F892E1 VA: 0x2F891E0
	|-Dictionary.KeyCollection<int, uint>.GetEnumerator
	|
	|-RVA: 0x2F89BF0 Offset: 0x2F89CF1 VA: 0x2F89BF0
	|-Dictionary.KeyCollection<int, AIThink.EnchantThink.SurroundingInfo>.GetEnumerator
	|
	|-RVA: 0x2F8A600 Offset: 0x2F8A701 VA: 0x2F8A600
	|-Dictionary.KeyCollection<Int32Enum, bool>.GetEnumerator
	|
	|-RVA: 0x2F8B010 Offset: 0x2F8B111 VA: 0x2F8B010
	|-Dictionary.KeyCollection<Int32Enum, int>.GetEnumerator
	|
	|-RVA: 0x2F8BA20 Offset: 0x2F8BB21 VA: 0x2F8BA20
	|-Dictionary.KeyCollection<Int32Enum, Int32Enum>.GetEnumerator
	|
	|-RVA: 0x2F8C430 Offset: 0x2F8C531 VA: 0x2F8C430
	|-Dictionary.KeyCollection<Int32Enum, object>.GetEnumerator
	|
	|-RVA: 0x2F8CE40 Offset: 0x2F8CF41 VA: 0x2F8CE40
	|-Dictionary.KeyCollection<long, object>.GetEnumerator
	|
	|-RVA: 0x288CBA0 Offset: 0x288CCA1 VA: 0x288CBA0
	|-Dictionary.KeyCollection<ItemData, int>.GetEnumerator
	|-Dictionary.KeyCollection<object, int>.GetEnumerator
	|-Dictionary.KeyCollection<string, int>.GetEnumerator
	|
	|-RVA: 0x2F8D850 Offset: 0x2F8D951 VA: 0x2F8D850
	|-Dictionary.KeyCollection<MapPos, int>.GetEnumerator
	|
	|-RVA: 0x2F8E260 Offset: 0x2F8E361 VA: 0x2F8E260
	|-Dictionary.KeyCollection<object, AsyncOperationHandle<object>>.GetEnumerator
	|
	|-RVA: 0x2F8EC50 Offset: 0x2F8ED51 VA: 0x2F8EC50
	|-Dictionary.KeyCollection<object, AsyncOperationHandle>.GetEnumerator
	|
	|-RVA: 0x2F8F640 Offset: 0x2F8F741 VA: 0x2F8F640
	|-Dictionary.KeyCollection<object, bool>.GetEnumerator
	|-Dictionary.KeyCollection<string, bool>.GetEnumerator
	|
	|-RVA: 0x288C1B0 Offset: 0x288C2B1 VA: 0x288C1B0
	|-Dictionary.KeyCollection<object, byte>.GetEnumerator
	|
	|-RVA: 0x288D590 Offset: 0x288D691 VA: 0x288D590
	|-Dictionary.KeyCollection<object, Int32Enum>.GetEnumerator
	|
	|-RVA: 0x288DF80 Offset: 0x288E081 VA: 0x288DF80
	|-Dictionary.KeyCollection<object, IntPtr>.GetEnumerator
	|-Dictionary.KeyCollection<string, IntPtr>.GetEnumerator
	|
	|-RVA: 0x288E970 Offset: 0x288EA71 VA: 0x288E970
	|-Dictionary.KeyCollection<object, object>.GetEnumerator
	|-Dictionary.KeyCollection<ParameterExpression, LocalVariable>.GetEnumerator
	|-Dictionary.KeyCollection<Renderer, Material[]>.GetEnumerator
	|-Dictionary.KeyCollection<string, GodBond>.GetEnumerator
	|-Dictionary.KeyCollection<string, GodUnit>.GetEnumerator
	|-Dictionary.KeyCollection<string, GodWeaponRefineLevels>.GetEnumerator
	|-Dictionary.KeyCollection<string, string>.GetEnumerator
	|
	|-RVA: 0x288FDA0 Offset: 0x288FEA1 VA: 0x288FDA0
	|-Dictionary.KeyCollection<object, Playable>.GetEnumerator
	|
	|-RVA: 0x2890790 Offset: 0x2890891 VA: 0x2890790
	|-Dictionary.KeyCollection<object, ResourceLocator>.GetEnumerator
	|
	|-RVA: 0x2891180 Offset: 0x2891281 VA: 0x2891180
	|-Dictionary.KeyCollection<object, float>.GetEnumerator
	|
	|-RVA: 0x2891B70 Offset: 0x2891C71 VA: 0x2891B70
	|-Dictionary.KeyCollection<object, ushort>.GetEnumerator
	|
	|-RVA: 0x2892560 Offset: 0x2892661 VA: 0x2892560
	|-Dictionary.KeyCollection<object, GameVariable.Value>.GetEnumerator
	|-Dictionary.KeyCollection<string, GameVariable.Value>.GetEnumerator
	|
	|-RVA: 0x2892F50 Offset: 0x2893051 VA: 0x2892F50
	|-Dictionary.KeyCollection<sbyte, DataStoreRatingInfo>.GetEnumerator
	|
	|-RVA: 0x2893960 Offset: 0x2893A61 VA: 0x2893960
	|-Dictionary.KeyCollection<sbyte, object>.GetEnumerator
	|
	|-RVA: 0x2894370 Offset: 0x2894471 VA: 0x2894370
	|-Dictionary.KeyCollection<ushort, int>.GetEnumerator
	|
	|-RVA: 0x2894D80 Offset: 0x2894E81 VA: 0x2894D80
	|-Dictionary.KeyCollection<uint, int>.GetEnumerator
	|
	|-RVA: 0x2895790 Offset: 0x2895891 VA: 0x2895790
	|-Dictionary.KeyCollection<uint, object>.GetEnumerator
	|
	|-RVA: 0x28961A0 Offset: 0x28962A1 VA: 0x28961A0
	|-Dictionary.KeyCollection<ulong, Friend>.GetEnumerator
	|
	|-RVA: 0x2896BB0 Offset: 0x2896CB1 VA: 0x2896BB0
	|-Dictionary.KeyCollection<ulong, Int32Enum>.GetEnumerator
	|-Dictionary.KeyCollection<ulong, NexVersus.TargetSlotList.Results>.GetEnumerator
	|
	|-RVA: 0x28975C0 Offset: 0x28976C1 VA: 0x28975C0
	|-Dictionary.KeyCollection<ulong, object>.GetEnumerator
	|-Dictionary.KeyCollection<ulong, RelayUserGlobalData.Ticket>.GetEnumerator
	|
	|-RVA: 0x2897FD0 Offset: 0x28980D1 VA: 0x2897FD0
	|-Dictionary.KeyCollection<Vector3, int>.GetEnumerator
	|
	|-RVA: 0x2898A00 Offset: 0x2898B01 VA: 0x2898A00
	|-Dictionary.KeyCollection<XPathNodeRef, XPathNodeRef>.GetEnumerator
	|
	|-RVA: 0x2899430 Offset: 0x2899531 VA: 0x2899430
	|-Dictionary.KeyCollection<TerrainUtility.TerrainMap.TileCoord, object>.GetEnumerator
	|-Dictionary.KeyCollection<TerrainUtility.TerrainMap.TileCoord, Terrain>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public void CopyTo(TKey[] array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2F7F090 Offset: 0x2F7F191 VA: 0x2F7F090
	|-Dictionary.KeyCollection<ValueTuple<object, int>, object>.CopyTo
	|
	|-RVA: 0x2F7FAC0 Offset: 0x2F7FBC1 VA: 0x2F7FAC0
	|-Dictionary.KeyCollection<byte, object>.CopyTo
	|
	|-RVA: 0x2F804D0 Offset: 0x2F805D1 VA: 0x2F804D0
	|-Dictionary.KeyCollection<CancellationToken, object>.CopyTo
	|
	|-RVA: 0x2F80F00 Offset: 0x2F81001 VA: 0x2F80F00
	|-Dictionary.KeyCollection<char, object>.CopyTo
	|
	|-RVA: 0x2F81910 Offset: 0x2F81A11 VA: 0x2F81910
	|-Dictionary.KeyCollection<Guid, object>.CopyTo
	|
	|-RVA: 0x2F82330 Offset: 0x2F82431 VA: 0x2F82330
	|-Dictionary.KeyCollection<int, bool>.CopyTo
	|
	|-RVA: 0x2F83780 Offset: 0x2F83881 VA: 0x2F83780
	|-Dictionary.KeyCollection<int, byte>.CopyTo
	|
	|-RVA: 0x2F84190 Offset: 0x2F84291 VA: 0x2F84190
	|-Dictionary.KeyCollection<int, char>.CopyTo
	|
	|-RVA: 0x2F84BA0 Offset: 0x2F84CA1 VA: 0x2F84BA0
	|-Dictionary.KeyCollection<int, DiagnosticEvent>.CopyTo
	|
	|-RVA: 0x2F855B0 Offset: 0x2F856B1 VA: 0x2F855B0
	|-Dictionary.KeyCollection<int, int>.CopyTo
	|
	|-RVA: 0x2F86A00 Offset: 0x2F86B01 VA: 0x2F86A00
	|-Dictionary.KeyCollection<int, Int32Enum>.CopyTo
	|
	|-RVA: 0x2F87410 Offset: 0x2F87511 VA: 0x2F87410
	|-Dictionary.KeyCollection<int, long>.CopyTo
	|
	|-RVA: 0x2F87E20 Offset: 0x2F87F21 VA: 0x2F87E20
	|-Dictionary.KeyCollection<int, MapPos>.CopyTo
	|
	|-RVA: 0x2F88830 Offset: 0x2F88931 VA: 0x2F88830
	|-Dictionary.KeyCollection<int, object>.CopyTo
	|
	|-RVA: 0x2F89240 Offset: 0x2F89341 VA: 0x2F89240
	|-Dictionary.KeyCollection<int, uint>.CopyTo
	|
	|-RVA: 0x2F89C50 Offset: 0x2F89D51 VA: 0x2F89C50
	|-Dictionary.KeyCollection<int, AIThink.EnchantThink.SurroundingInfo>.CopyTo
	|
	|-RVA: 0x2F8A660 Offset: 0x2F8A761 VA: 0x2F8A660
	|-Dictionary.KeyCollection<Int32Enum, bool>.CopyTo
	|
	|-RVA: 0x2F8B070 Offset: 0x2F8B171 VA: 0x2F8B070
	|-Dictionary.KeyCollection<Int32Enum, int>.CopyTo
	|
	|-RVA: 0x2F8BA80 Offset: 0x2F8BB81 VA: 0x2F8BA80
	|-Dictionary.KeyCollection<Int32Enum, Int32Enum>.CopyTo
	|
	|-RVA: 0x2F8C490 Offset: 0x2F8C591 VA: 0x2F8C490
	|-Dictionary.KeyCollection<Int32Enum, object>.CopyTo
	|
	|-RVA: 0x2F8CEA0 Offset: 0x2F8CFA1 VA: 0x2F8CEA0
	|-Dictionary.KeyCollection<long, object>.CopyTo
	|
	|-RVA: 0x2F8D8B0 Offset: 0x2F8D9B1 VA: 0x2F8D8B0
	|-Dictionary.KeyCollection<MapPos, int>.CopyTo
	|
	|-RVA: 0x2F8E2C0 Offset: 0x2F8E3C1 VA: 0x2F8E2C0
	|-Dictionary.KeyCollection<object, AsyncOperationHandle<object>>.CopyTo
	|
	|-RVA: 0x2F8ECB0 Offset: 0x2F8EDB1 VA: 0x2F8ECB0
	|-Dictionary.KeyCollection<object, AsyncOperationHandle>.CopyTo
	|
	|-RVA: 0x2F8F6A0 Offset: 0x2F8F7A1 VA: 0x2F8F6A0
	|-Dictionary.KeyCollection<object, bool>.CopyTo
	|
	|-RVA: 0x288C210 Offset: 0x288C311 VA: 0x288C210
	|-Dictionary.KeyCollection<object, byte>.CopyTo
	|
	|-RVA: 0x288CC00 Offset: 0x288CD01 VA: 0x288CC00
	|-Dictionary.KeyCollection<object, int>.CopyTo
	|
	|-RVA: 0x288D5F0 Offset: 0x288D6F1 VA: 0x288D5F0
	|-Dictionary.KeyCollection<object, Int32Enum>.CopyTo
	|
	|-RVA: 0x288DFE0 Offset: 0x288E0E1 VA: 0x288DFE0
	|-Dictionary.KeyCollection<object, IntPtr>.CopyTo
	|
	|-RVA: 0x288E9D0 Offset: 0x288EAD1 VA: 0x288E9D0
	|-Dictionary.KeyCollection<object, object>.CopyTo
	|-Dictionary.KeyCollection<string, RelayAwardeeData>.CopyTo
	|-Dictionary.KeyCollection<string, string>.CopyTo
	|-Dictionary.KeyCollection<string, ServicePointScheduler.ConnectionGroup>.CopyTo
	|
	|-RVA: 0x288FE00 Offset: 0x288FF01 VA: 0x288FE00
	|-Dictionary.KeyCollection<object, Playable>.CopyTo
	|
	|-RVA: 0x28907F0 Offset: 0x28908F1 VA: 0x28907F0
	|-Dictionary.KeyCollection<object, ResourceLocator>.CopyTo
	|
	|-RVA: 0x28911E0 Offset: 0x28912E1 VA: 0x28911E0
	|-Dictionary.KeyCollection<object, float>.CopyTo
	|
	|-RVA: 0x2891BD0 Offset: 0x2891CD1 VA: 0x2891BD0
	|-Dictionary.KeyCollection<object, ushort>.CopyTo
	|
	|-RVA: 0x28925C0 Offset: 0x28926C1 VA: 0x28925C0
	|-Dictionary.KeyCollection<object, GameVariable.Value>.CopyTo
	|
	|-RVA: 0x2892FB0 Offset: 0x28930B1 VA: 0x2892FB0
	|-Dictionary.KeyCollection<sbyte, DataStoreRatingInfo>.CopyTo
	|
	|-RVA: 0x28939C0 Offset: 0x2893AC1 VA: 0x28939C0
	|-Dictionary.KeyCollection<sbyte, object>.CopyTo
	|
	|-RVA: 0x28943D0 Offset: 0x28944D1 VA: 0x28943D0
	|-Dictionary.KeyCollection<ushort, int>.CopyTo
	|
	|-RVA: 0x2894DE0 Offset: 0x2894EE1 VA: 0x2894DE0
	|-Dictionary.KeyCollection<uint, int>.CopyTo
	|
	|-RVA: 0x28957F0 Offset: 0x28958F1 VA: 0x28957F0
	|-Dictionary.KeyCollection<uint, object>.CopyTo
	|
	|-RVA: 0x2896200 Offset: 0x2896301 VA: 0x2896200
	|-Dictionary.KeyCollection<ulong, Friend>.CopyTo
	|
	|-RVA: 0x2896C10 Offset: 0x2896D11 VA: 0x2896C10
	|-Dictionary.KeyCollection<ulong, Int32Enum>.CopyTo
	|
	|-RVA: 0x2897620 Offset: 0x2897721 VA: 0x2897620
	|-Dictionary.KeyCollection<ulong, object>.CopyTo
	|
	|-RVA: 0x2898030 Offset: 0x2898131 VA: 0x2898030
	|-Dictionary.KeyCollection<Vector3, int>.CopyTo
	|
	|-RVA: 0x2898A60 Offset: 0x2898B61 VA: 0x2898A60
	|-Dictionary.KeyCollection<XPathNodeRef, XPathNodeRef>.CopyTo
	|
	|-RVA: 0x2899490 Offset: 0x2899591 VA: 0x2899490
	|-Dictionary.KeyCollection<TerrainUtility.TerrainMap.TileCoord, object>.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 17
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2F7F280 Offset: 0x2F7F381 VA: 0x2F7F280
	|-Dictionary.KeyCollection<ValueTuple<object, int>, object>.get_Count
	|
	|-RVA: 0x2F7FC90 Offset: 0x2F7FD91 VA: 0x2F7FC90
	|-Dictionary.KeyCollection<byte, object>.get_Count
	|
	|-RVA: 0x2F806C0 Offset: 0x2F807C1 VA: 0x2F806C0
	|-Dictionary.KeyCollection<CancellationToken, object>.get_Count
	|
	|-RVA: 0x2F810D0 Offset: 0x2F811D1 VA: 0x2F810D0
	|-Dictionary.KeyCollection<char, object>.get_Count
	|
	|-RVA: 0x2F81AF0 Offset: 0x2F81BF1 VA: 0x2F81AF0
	|-Dictionary.KeyCollection<Guid, object>.get_Count
	|
	|-RVA: 0x2F82500 Offset: 0x2F82601 VA: 0x2F82500
	|-Dictionary.KeyCollection<int, bool>.get_Count
	|
	|-RVA: 0x2F83950 Offset: 0x2F83A51 VA: 0x2F83950
	|-Dictionary.KeyCollection<int, byte>.get_Count
	|
	|-RVA: 0x2F84360 Offset: 0x2F84461 VA: 0x2F84360
	|-Dictionary.KeyCollection<int, char>.get_Count
	|
	|-RVA: 0x2F84D70 Offset: 0x2F84E71 VA: 0x2F84D70
	|-Dictionary.KeyCollection<int, DiagnosticEvent>.get_Count
	|
	|-RVA: 0x2F85780 Offset: 0x2F85881 VA: 0x2F85780
	|-Dictionary.KeyCollection<int, int>.get_Count
	|
	|-RVA: 0x2F86BD0 Offset: 0x2F86CD1 VA: 0x2F86BD0
	|-Dictionary.KeyCollection<int, Int32Enum>.get_Count
	|
	|-RVA: 0x2F875E0 Offset: 0x2F876E1 VA: 0x2F875E0
	|-Dictionary.KeyCollection<int, long>.get_Count
	|
	|-RVA: 0x2F87FF0 Offset: 0x2F880F1 VA: 0x2F87FF0
	|-Dictionary.KeyCollection<int, MapPos>.get_Count
	|
	|-RVA: 0x2F88A00 Offset: 0x2F88B01 VA: 0x2F88A00
	|-Dictionary.KeyCollection<int, object>.get_Count
	|
	|-RVA: 0x2F89410 Offset: 0x2F89511 VA: 0x2F89410
	|-Dictionary.KeyCollection<int, uint>.get_Count
	|
	|-RVA: 0x2F89E20 Offset: 0x2F89F21 VA: 0x2F89E20
	|-Dictionary.KeyCollection<int, AIThink.EnchantThink.SurroundingInfo>.get_Count
	|
	|-RVA: 0x2F8A830 Offset: 0x2F8A931 VA: 0x2F8A830
	|-Dictionary.KeyCollection<Int32Enum, bool>.get_Count
	|
	|-RVA: 0x2F8B240 Offset: 0x2F8B341 VA: 0x2F8B240
	|-Dictionary.KeyCollection<Int32Enum, int>.get_Count
	|
	|-RVA: 0x2F8BC50 Offset: 0x2F8BD51 VA: 0x2F8BC50
	|-Dictionary.KeyCollection<Int32Enum, Int32Enum>.get_Count
	|
	|-RVA: 0x2F8C660 Offset: 0x2F8C761 VA: 0x2F8C660
	|-Dictionary.KeyCollection<Int32Enum, object>.get_Count
	|
	|-RVA: 0x2F8D070 Offset: 0x2F8D171 VA: 0x2F8D070
	|-Dictionary.KeyCollection<long, object>.get_Count
	|
	|-RVA: 0x2F8DA80 Offset: 0x2F8DB81 VA: 0x2F8DA80
	|-Dictionary.KeyCollection<MapPos, int>.get_Count
	|
	|-RVA: 0x2F8E4B0 Offset: 0x2F8E5B1 VA: 0x2F8E4B0
	|-Dictionary.KeyCollection<object, AsyncOperationHandle<object>>.get_Count
	|
	|-RVA: 0x2F8EEA0 Offset: 0x2F8EFA1 VA: 0x2F8EEA0
	|-Dictionary.KeyCollection<object, AsyncOperationHandle>.get_Count
	|
	|-RVA: 0x2F8F890 Offset: 0x2F8F991 VA: 0x2F8F890
	|-Dictionary.KeyCollection<object, bool>.get_Count
	|
	|-RVA: 0x288C400 Offset: 0x288C501 VA: 0x288C400
	|-Dictionary.KeyCollection<object, byte>.get_Count
	|
	|-RVA: 0x288CDF0 Offset: 0x288CEF1 VA: 0x288CDF0
	|-Dictionary.KeyCollection<object, int>.get_Count
	|
	|-RVA: 0x288D7E0 Offset: 0x288D8E1 VA: 0x288D7E0
	|-Dictionary.KeyCollection<object, Int32Enum>.get_Count
	|
	|-RVA: 0x288E1D0 Offset: 0x288E2D1 VA: 0x288E1D0
	|-Dictionary.KeyCollection<object, IntPtr>.get_Count
	|
	|-RVA: 0x288EBC0 Offset: 0x288ECC1 VA: 0x288EBC0
	|-Dictionary.KeyCollection<object, object>.get_Count
	|-Dictionary.KeyCollection<string, string>.get_Count
	|
	|-RVA: 0x288FFF0 Offset: 0x28900F1 VA: 0x288FFF0
	|-Dictionary.KeyCollection<object, Playable>.get_Count
	|
	|-RVA: 0x28909E0 Offset: 0x2890AE1 VA: 0x28909E0
	|-Dictionary.KeyCollection<object, ResourceLocator>.get_Count
	|
	|-RVA: 0x28913D0 Offset: 0x28914D1 VA: 0x28913D0
	|-Dictionary.KeyCollection<object, float>.get_Count
	|
	|-RVA: 0x2891DC0 Offset: 0x2891EC1 VA: 0x2891DC0
	|-Dictionary.KeyCollection<object, ushort>.get_Count
	|
	|-RVA: 0x28927B0 Offset: 0x28928B1 VA: 0x28927B0
	|-Dictionary.KeyCollection<object, GameVariable.Value>.get_Count
	|
	|-RVA: 0x2893180 Offset: 0x2893281 VA: 0x2893180
	|-Dictionary.KeyCollection<sbyte, DataStoreRatingInfo>.get_Count
	|
	|-RVA: 0x2893B90 Offset: 0x2893C91 VA: 0x2893B90
	|-Dictionary.KeyCollection<sbyte, object>.get_Count
	|
	|-RVA: 0x28945A0 Offset: 0x28946A1 VA: 0x28945A0
	|-Dictionary.KeyCollection<ushort, int>.get_Count
	|
	|-RVA: 0x2894FB0 Offset: 0x28950B1 VA: 0x2894FB0
	|-Dictionary.KeyCollection<uint, int>.get_Count
	|
	|-RVA: 0x28959C0 Offset: 0x2895AC1 VA: 0x28959C0
	|-Dictionary.KeyCollection<uint, object>.get_Count
	|
	|-RVA: 0x28963D0 Offset: 0x28964D1 VA: 0x28963D0
	|-Dictionary.KeyCollection<ulong, Friend>.get_Count
	|
	|-RVA: 0x2896DE0 Offset: 0x2896EE1 VA: 0x2896DE0
	|-Dictionary.KeyCollection<ulong, Int32Enum>.get_Count
	|
	|-RVA: 0x28977F0 Offset: 0x28978F1 VA: 0x28977F0
	|-Dictionary.KeyCollection<ulong, object>.get_Count
	|
	|-RVA: 0x2898210 Offset: 0x2898311 VA: 0x2898210
	|-Dictionary.KeyCollection<Vector3, int>.get_Count
	|
	|-RVA: 0x2898C50 Offset: 0x2898D51 VA: 0x2898C50
	|-Dictionary.KeyCollection<XPathNodeRef, XPathNodeRef>.get_Count
	|
	|-RVA: 0x2899660 Offset: 0x2899761 VA: 0x2899660
	|-Dictionary.KeyCollection<TerrainUtility.TerrainMap.TileCoord, object>.get_Count
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private bool System.Collections.Generic.ICollection<TKey>.get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2F7F2A0 Offset: 0x2F7F3A1 VA: 0x2F7F2A0
	|-Dictionary.KeyCollection<ValueTuple<object, int>, object>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x2F7FCB0 Offset: 0x2F7FDB1 VA: 0x2F7FCB0
	|-Dictionary.KeyCollection<byte, object>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x2F806E0 Offset: 0x2F807E1 VA: 0x2F806E0
	|-Dictionary.KeyCollection<CancellationToken, object>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x2F810F0 Offset: 0x2F811F1 VA: 0x2F810F0
	|-Dictionary.KeyCollection<char, object>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x2F81B10 Offset: 0x2F81C11 VA: 0x2F81B10
	|-Dictionary.KeyCollection<Guid, object>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x2F82520 Offset: 0x2F82621 VA: 0x2F82520
	|-Dictionary.KeyCollection<int, bool>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x2F83970 Offset: 0x2F83A71 VA: 0x2F83970
	|-Dictionary.KeyCollection<int, byte>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x2F84380 Offset: 0x2F84481 VA: 0x2F84380
	|-Dictionary.KeyCollection<int, char>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x2F84D90 Offset: 0x2F84E91 VA: 0x2F84D90
	|-Dictionary.KeyCollection<int, DiagnosticEvent>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x2F857A0 Offset: 0x2F858A1 VA: 0x2F857A0
	|-Dictionary.KeyCollection<int, int>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x2F86BF0 Offset: 0x2F86CF1 VA: 0x2F86BF0
	|-Dictionary.KeyCollection<int, Int32Enum>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x2F87600 Offset: 0x2F87701 VA: 0x2F87600
	|-Dictionary.KeyCollection<int, long>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x2F88010 Offset: 0x2F88111 VA: 0x2F88010
	|-Dictionary.KeyCollection<int, MapPos>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x2F88A20 Offset: 0x2F88B21 VA: 0x2F88A20
	|-Dictionary.KeyCollection<int, object>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x2F89430 Offset: 0x2F89531 VA: 0x2F89430
	|-Dictionary.KeyCollection<int, uint>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x2F89E40 Offset: 0x2F89F41 VA: 0x2F89E40
	|-Dictionary.KeyCollection<int, AIThink.EnchantThink.SurroundingInfo>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x2F8A850 Offset: 0x2F8A951 VA: 0x2F8A850
	|-Dictionary.KeyCollection<Int32Enum, bool>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x2F8B260 Offset: 0x2F8B361 VA: 0x2F8B260
	|-Dictionary.KeyCollection<Int32Enum, int>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x2F8BC70 Offset: 0x2F8BD71 VA: 0x2F8BC70
	|-Dictionary.KeyCollection<Int32Enum, Int32Enum>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x2F8C680 Offset: 0x2F8C781 VA: 0x2F8C680
	|-Dictionary.KeyCollection<Int32Enum, object>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x2F8D090 Offset: 0x2F8D191 VA: 0x2F8D090
	|-Dictionary.KeyCollection<long, object>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x2F8DAA0 Offset: 0x2F8DBA1 VA: 0x2F8DAA0
	|-Dictionary.KeyCollection<MapPos, int>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x2F8E4D0 Offset: 0x2F8E5D1 VA: 0x2F8E4D0
	|-Dictionary.KeyCollection<object, AsyncOperationHandle<object>>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x2F8EEC0 Offset: 0x2F8EFC1 VA: 0x2F8EEC0
	|-Dictionary.KeyCollection<object, AsyncOperationHandle>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x2F8F8B0 Offset: 0x2F8F9B1 VA: 0x2F8F8B0
	|-Dictionary.KeyCollection<object, bool>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x288C420 Offset: 0x288C521 VA: 0x288C420
	|-Dictionary.KeyCollection<object, byte>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x288CE10 Offset: 0x288CF11 VA: 0x288CE10
	|-Dictionary.KeyCollection<object, int>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x288D800 Offset: 0x288D901 VA: 0x288D800
	|-Dictionary.KeyCollection<object, Int32Enum>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x288E1F0 Offset: 0x288E2F1 VA: 0x288E1F0
	|-Dictionary.KeyCollection<object, IntPtr>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x288EBE0 Offset: 0x288ECE1 VA: 0x288EBE0
	|-Dictionary.KeyCollection<object, object>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x2890010 Offset: 0x2890111 VA: 0x2890010
	|-Dictionary.KeyCollection<object, Playable>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x2890A00 Offset: 0x2890B01 VA: 0x2890A00
	|-Dictionary.KeyCollection<object, ResourceLocator>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x28913F0 Offset: 0x28914F1 VA: 0x28913F0
	|-Dictionary.KeyCollection<object, float>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x2891DE0 Offset: 0x2891EE1 VA: 0x2891DE0
	|-Dictionary.KeyCollection<object, ushort>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x28927D0 Offset: 0x28928D1 VA: 0x28927D0
	|-Dictionary.KeyCollection<object, GameVariable.Value>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x28931A0 Offset: 0x28932A1 VA: 0x28931A0
	|-Dictionary.KeyCollection<sbyte, DataStoreRatingInfo>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x2893BB0 Offset: 0x2893CB1 VA: 0x2893BB0
	|-Dictionary.KeyCollection<sbyte, object>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x28945C0 Offset: 0x28946C1 VA: 0x28945C0
	|-Dictionary.KeyCollection<ushort, int>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x2894FD0 Offset: 0x28950D1 VA: 0x2894FD0
	|-Dictionary.KeyCollection<uint, int>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x28959E0 Offset: 0x2895AE1 VA: 0x28959E0
	|-Dictionary.KeyCollection<uint, object>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x28963F0 Offset: 0x28964F1 VA: 0x28963F0
	|-Dictionary.KeyCollection<ulong, Friend>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x2896E00 Offset: 0x2896F01 VA: 0x2896E00
	|-Dictionary.KeyCollection<ulong, Int32Enum>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x2897810 Offset: 0x2897911 VA: 0x2897810
	|-Dictionary.KeyCollection<ulong, object>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x2898230 Offset: 0x2898331 VA: 0x2898230
	|-Dictionary.KeyCollection<Vector3, int>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x2898C70 Offset: 0x2898D71 VA: 0x2898C70
	|-Dictionary.KeyCollection<XPathNodeRef, XPathNodeRef>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x2899680 Offset: 0x2899781 VA: 0x2899680
	|-Dictionary.KeyCollection<TerrainUtility.TerrainMap.TileCoord, object>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private void System.Collections.Generic.ICollection<TKey>.Add(TKey item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2F7F2B0 Offset: 0x2F7F3B1 VA: 0x2F7F2B0
	|-Dictionary.KeyCollection<ValueTuple<object, int>, object>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x2F7FCC0 Offset: 0x2F7FDC1 VA: 0x2F7FCC0
	|-Dictionary.KeyCollection<byte, object>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x2F806F0 Offset: 0x2F807F1 VA: 0x2F806F0
	|-Dictionary.KeyCollection<CancellationToken, object>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x2F81100 Offset: 0x2F81201 VA: 0x2F81100
	|-Dictionary.KeyCollection<char, object>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x2F81B20 Offset: 0x2F81C21 VA: 0x2F81B20
	|-Dictionary.KeyCollection<Guid, object>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x2F82530 Offset: 0x2F82631 VA: 0x2F82530
	|-Dictionary.KeyCollection<int, bool>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x2F83980 Offset: 0x2F83A81 VA: 0x2F83980
	|-Dictionary.KeyCollection<int, byte>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x2F84390 Offset: 0x2F84491 VA: 0x2F84390
	|-Dictionary.KeyCollection<int, char>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x2F84DA0 Offset: 0x2F84EA1 VA: 0x2F84DA0
	|-Dictionary.KeyCollection<int, DiagnosticEvent>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x2F857B0 Offset: 0x2F858B1 VA: 0x2F857B0
	|-Dictionary.KeyCollection<int, int>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x2F86C00 Offset: 0x2F86D01 VA: 0x2F86C00
	|-Dictionary.KeyCollection<int, Int32Enum>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x2F87610 Offset: 0x2F87711 VA: 0x2F87610
	|-Dictionary.KeyCollection<int, long>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x2F88020 Offset: 0x2F88121 VA: 0x2F88020
	|-Dictionary.KeyCollection<int, MapPos>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x2F88A30 Offset: 0x2F88B31 VA: 0x2F88A30
	|-Dictionary.KeyCollection<int, object>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x2F89440 Offset: 0x2F89541 VA: 0x2F89440
	|-Dictionary.KeyCollection<int, uint>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x2F89E50 Offset: 0x2F89F51 VA: 0x2F89E50
	|-Dictionary.KeyCollection<int, AIThink.EnchantThink.SurroundingInfo>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x2F8A860 Offset: 0x2F8A961 VA: 0x2F8A860
	|-Dictionary.KeyCollection<Int32Enum, bool>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x2F8B270 Offset: 0x2F8B371 VA: 0x2F8B270
	|-Dictionary.KeyCollection<Int32Enum, int>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x2F8BC80 Offset: 0x2F8BD81 VA: 0x2F8BC80
	|-Dictionary.KeyCollection<Int32Enum, Int32Enum>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x2F8C690 Offset: 0x2F8C791 VA: 0x2F8C690
	|-Dictionary.KeyCollection<Int32Enum, object>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x2F8D0A0 Offset: 0x2F8D1A1 VA: 0x2F8D0A0
	|-Dictionary.KeyCollection<long, object>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x2F8DAB0 Offset: 0x2F8DBB1 VA: 0x2F8DAB0
	|-Dictionary.KeyCollection<MapPos, int>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x2F8E4E0 Offset: 0x2F8E5E1 VA: 0x2F8E4E0
	|-Dictionary.KeyCollection<object, AsyncOperationHandle<object>>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x2F8EED0 Offset: 0x2F8EFD1 VA: 0x2F8EED0
	|-Dictionary.KeyCollection<object, AsyncOperationHandle>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x2F8F8C0 Offset: 0x2F8F9C1 VA: 0x2F8F8C0
	|-Dictionary.KeyCollection<object, bool>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x288C430 Offset: 0x288C531 VA: 0x288C430
	|-Dictionary.KeyCollection<object, byte>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x288CE20 Offset: 0x288CF21 VA: 0x288CE20
	|-Dictionary.KeyCollection<object, int>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x288D810 Offset: 0x288D911 VA: 0x288D810
	|-Dictionary.KeyCollection<object, Int32Enum>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x288E200 Offset: 0x288E301 VA: 0x288E200
	|-Dictionary.KeyCollection<object, IntPtr>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x288EBF0 Offset: 0x288ECF1 VA: 0x288EBF0
	|-Dictionary.KeyCollection<object, object>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x2890020 Offset: 0x2890121 VA: 0x2890020
	|-Dictionary.KeyCollection<object, Playable>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x2890A10 Offset: 0x2890B11 VA: 0x2890A10
	|-Dictionary.KeyCollection<object, ResourceLocator>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x2891400 Offset: 0x2891501 VA: 0x2891400
	|-Dictionary.KeyCollection<object, float>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x2891DF0 Offset: 0x2891EF1 VA: 0x2891DF0
	|-Dictionary.KeyCollection<object, ushort>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x28927E0 Offset: 0x28928E1 VA: 0x28927E0
	|-Dictionary.KeyCollection<object, GameVariable.Value>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x28931B0 Offset: 0x28932B1 VA: 0x28931B0
	|-Dictionary.KeyCollection<sbyte, DataStoreRatingInfo>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x2893BC0 Offset: 0x2893CC1 VA: 0x2893BC0
	|-Dictionary.KeyCollection<sbyte, object>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x28945D0 Offset: 0x28946D1 VA: 0x28945D0
	|-Dictionary.KeyCollection<ushort, int>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x2894FE0 Offset: 0x28950E1 VA: 0x2894FE0
	|-Dictionary.KeyCollection<uint, int>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x28959F0 Offset: 0x2895AF1 VA: 0x28959F0
	|-Dictionary.KeyCollection<uint, object>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x2896400 Offset: 0x2896501 VA: 0x2896400
	|-Dictionary.KeyCollection<ulong, Friend>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x2896E10 Offset: 0x2896F11 VA: 0x2896E10
	|-Dictionary.KeyCollection<ulong, Int32Enum>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x2897820 Offset: 0x2897921 VA: 0x2897820
	|-Dictionary.KeyCollection<ulong, object>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x2898240 Offset: 0x2898341 VA: 0x2898240
	|-Dictionary.KeyCollection<Vector3, int>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x2898C80 Offset: 0x2898D81 VA: 0x2898C80
	|-Dictionary.KeyCollection<XPathNodeRef, XPathNodeRef>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x2899690 Offset: 0x2899791 VA: 0x2899690
	|-Dictionary.KeyCollection<TerrainUtility.TerrainMap.TileCoord, object>.System.Collections.Generic.ICollection<TKey>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private void System.Collections.Generic.ICollection<TKey>.Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2F7F310 Offset: 0x2F7F411 VA: 0x2F7F310
	|-Dictionary.KeyCollection<ValueTuple<object, int>, object>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x2F7FD20 Offset: 0x2F7FE21 VA: 0x2F7FD20
	|-Dictionary.KeyCollection<byte, object>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x2F80750 Offset: 0x2F80851 VA: 0x2F80750
	|-Dictionary.KeyCollection<CancellationToken, object>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x2F81160 Offset: 0x2F81261 VA: 0x2F81160
	|-Dictionary.KeyCollection<char, object>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x2F81B80 Offset: 0x2F81C81 VA: 0x2F81B80
	|-Dictionary.KeyCollection<Guid, object>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x2F82590 Offset: 0x2F82691 VA: 0x2F82590
	|-Dictionary.KeyCollection<int, bool>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x2F839E0 Offset: 0x2F83AE1 VA: 0x2F839E0
	|-Dictionary.KeyCollection<int, byte>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x2F843F0 Offset: 0x2F844F1 VA: 0x2F843F0
	|-Dictionary.KeyCollection<int, char>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x2F84E00 Offset: 0x2F84F01 VA: 0x2F84E00
	|-Dictionary.KeyCollection<int, DiagnosticEvent>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x2F85810 Offset: 0x2F85911 VA: 0x2F85810
	|-Dictionary.KeyCollection<int, int>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x2F86C60 Offset: 0x2F86D61 VA: 0x2F86C60
	|-Dictionary.KeyCollection<int, Int32Enum>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x2F87670 Offset: 0x2F87771 VA: 0x2F87670
	|-Dictionary.KeyCollection<int, long>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x2F88080 Offset: 0x2F88181 VA: 0x2F88080
	|-Dictionary.KeyCollection<int, MapPos>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x2F88A90 Offset: 0x2F88B91 VA: 0x2F88A90
	|-Dictionary.KeyCollection<int, object>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x2F894A0 Offset: 0x2F895A1 VA: 0x2F894A0
	|-Dictionary.KeyCollection<int, uint>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x2F89EB0 Offset: 0x2F89FB1 VA: 0x2F89EB0
	|-Dictionary.KeyCollection<int, AIThink.EnchantThink.SurroundingInfo>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x2F8A8C0 Offset: 0x2F8A9C1 VA: 0x2F8A8C0
	|-Dictionary.KeyCollection<Int32Enum, bool>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x2F8B2D0 Offset: 0x2F8B3D1 VA: 0x2F8B2D0
	|-Dictionary.KeyCollection<Int32Enum, int>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x2F8BCE0 Offset: 0x2F8BDE1 VA: 0x2F8BCE0
	|-Dictionary.KeyCollection<Int32Enum, Int32Enum>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x2F8C6F0 Offset: 0x2F8C7F1 VA: 0x2F8C6F0
	|-Dictionary.KeyCollection<Int32Enum, object>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x2F8D100 Offset: 0x2F8D201 VA: 0x2F8D100
	|-Dictionary.KeyCollection<long, object>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x2F8DB10 Offset: 0x2F8DC11 VA: 0x2F8DB10
	|-Dictionary.KeyCollection<MapPos, int>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x2F8E540 Offset: 0x2F8E641 VA: 0x2F8E540
	|-Dictionary.KeyCollection<object, AsyncOperationHandle<object>>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x2F8EF30 Offset: 0x2F8F031 VA: 0x2F8EF30
	|-Dictionary.KeyCollection<object, AsyncOperationHandle>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x2F8F920 Offset: 0x2F8FA21 VA: 0x2F8F920
	|-Dictionary.KeyCollection<object, bool>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x288C490 Offset: 0x288C591 VA: 0x288C490
	|-Dictionary.KeyCollection<object, byte>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x288CE80 Offset: 0x288CF81 VA: 0x288CE80
	|-Dictionary.KeyCollection<object, int>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x288D870 Offset: 0x288D971 VA: 0x288D870
	|-Dictionary.KeyCollection<object, Int32Enum>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x288E260 Offset: 0x288E361 VA: 0x288E260
	|-Dictionary.KeyCollection<object, IntPtr>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x288EC50 Offset: 0x288ED51 VA: 0x288EC50
	|-Dictionary.KeyCollection<object, object>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x2890080 Offset: 0x2890181 VA: 0x2890080
	|-Dictionary.KeyCollection<object, Playable>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x2890A70 Offset: 0x2890B71 VA: 0x2890A70
	|-Dictionary.KeyCollection<object, ResourceLocator>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x2891460 Offset: 0x2891561 VA: 0x2891460
	|-Dictionary.KeyCollection<object, float>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x2891E50 Offset: 0x2891F51 VA: 0x2891E50
	|-Dictionary.KeyCollection<object, ushort>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x2892840 Offset: 0x2892941 VA: 0x2892840
	|-Dictionary.KeyCollection<object, GameVariable.Value>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x2893210 Offset: 0x2893311 VA: 0x2893210
	|-Dictionary.KeyCollection<sbyte, DataStoreRatingInfo>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x2893C20 Offset: 0x2893D21 VA: 0x2893C20
	|-Dictionary.KeyCollection<sbyte, object>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x2894630 Offset: 0x2894731 VA: 0x2894630
	|-Dictionary.KeyCollection<ushort, int>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x2895040 Offset: 0x2895141 VA: 0x2895040
	|-Dictionary.KeyCollection<uint, int>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x2895A50 Offset: 0x2895B51 VA: 0x2895A50
	|-Dictionary.KeyCollection<uint, object>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x2896460 Offset: 0x2896561 VA: 0x2896460
	|-Dictionary.KeyCollection<ulong, Friend>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x2896E70 Offset: 0x2896F71 VA: 0x2896E70
	|-Dictionary.KeyCollection<ulong, Int32Enum>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x2897880 Offset: 0x2897981 VA: 0x2897880
	|-Dictionary.KeyCollection<ulong, object>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x28982A0 Offset: 0x28983A1 VA: 0x28982A0
	|-Dictionary.KeyCollection<Vector3, int>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x2898CE0 Offset: 0x2898DE1 VA: 0x2898CE0
	|-Dictionary.KeyCollection<XPathNodeRef, XPathNodeRef>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x28996F0 Offset: 0x28997F1 VA: 0x28996F0
	|-Dictionary.KeyCollection<TerrainUtility.TerrainMap.TileCoord, object>.System.Collections.Generic.ICollection<TKey>.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private bool System.Collections.Generic.ICollection<TKey>.Contains(TKey item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2F7F370 Offset: 0x2F7F471 VA: 0x2F7F370
	|-Dictionary.KeyCollection<ValueTuple<object, int>, object>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x2F7FD80 Offset: 0x2F7FE81 VA: 0x2F7FD80
	|-Dictionary.KeyCollection<byte, object>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x2F807B0 Offset: 0x2F808B1 VA: 0x2F807B0
	|-Dictionary.KeyCollection<CancellationToken, object>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x2F811C0 Offset: 0x2F812C1 VA: 0x2F811C0
	|-Dictionary.KeyCollection<char, object>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x2F81BE0 Offset: 0x2F81CE1 VA: 0x2F81BE0
	|-Dictionary.KeyCollection<Guid, object>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x2F825F0 Offset: 0x2F826F1 VA: 0x2F825F0
	|-Dictionary.KeyCollection<int, bool>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x2F83A40 Offset: 0x2F83B41 VA: 0x2F83A40
	|-Dictionary.KeyCollection<int, byte>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x2F84450 Offset: 0x2F84551 VA: 0x2F84450
	|-Dictionary.KeyCollection<int, char>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x2F84E60 Offset: 0x2F84F61 VA: 0x2F84E60
	|-Dictionary.KeyCollection<int, DiagnosticEvent>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x2F85870 Offset: 0x2F85971 VA: 0x2F85870
	|-Dictionary.KeyCollection<int, int>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x2F86CC0 Offset: 0x2F86DC1 VA: 0x2F86CC0
	|-Dictionary.KeyCollection<int, Int32Enum>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x2F876D0 Offset: 0x2F877D1 VA: 0x2F876D0
	|-Dictionary.KeyCollection<int, long>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x2F880E0 Offset: 0x2F881E1 VA: 0x2F880E0
	|-Dictionary.KeyCollection<int, MapPos>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x2F88AF0 Offset: 0x2F88BF1 VA: 0x2F88AF0
	|-Dictionary.KeyCollection<int, object>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x2F89500 Offset: 0x2F89601 VA: 0x2F89500
	|-Dictionary.KeyCollection<int, uint>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x2F89F10 Offset: 0x2F8A011 VA: 0x2F89F10
	|-Dictionary.KeyCollection<int, AIThink.EnchantThink.SurroundingInfo>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x2F8A920 Offset: 0x2F8AA21 VA: 0x2F8A920
	|-Dictionary.KeyCollection<Int32Enum, bool>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x2F8B330 Offset: 0x2F8B431 VA: 0x2F8B330
	|-Dictionary.KeyCollection<Int32Enum, int>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x2F8BD40 Offset: 0x2F8BE41 VA: 0x2F8BD40
	|-Dictionary.KeyCollection<Int32Enum, Int32Enum>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x2F8C750 Offset: 0x2F8C851 VA: 0x2F8C750
	|-Dictionary.KeyCollection<Int32Enum, object>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x2F8D160 Offset: 0x2F8D261 VA: 0x2F8D160
	|-Dictionary.KeyCollection<long, object>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x2F8DB70 Offset: 0x2F8DC71 VA: 0x2F8DB70
	|-Dictionary.KeyCollection<MapPos, int>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x2F8E5A0 Offset: 0x2F8E6A1 VA: 0x2F8E5A0
	|-Dictionary.KeyCollection<object, AsyncOperationHandle<object>>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x2F8EF90 Offset: 0x2F8F091 VA: 0x2F8EF90
	|-Dictionary.KeyCollection<object, AsyncOperationHandle>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x2F8F980 Offset: 0x2F8FA81 VA: 0x2F8F980
	|-Dictionary.KeyCollection<object, bool>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x288C4F0 Offset: 0x288C5F1 VA: 0x288C4F0
	|-Dictionary.KeyCollection<object, byte>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x288CEE0 Offset: 0x288CFE1 VA: 0x288CEE0
	|-Dictionary.KeyCollection<object, int>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x288D8D0 Offset: 0x288D9D1 VA: 0x288D8D0
	|-Dictionary.KeyCollection<object, Int32Enum>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x288E2C0 Offset: 0x288E3C1 VA: 0x288E2C0
	|-Dictionary.KeyCollection<object, IntPtr>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x288ECB0 Offset: 0x288EDB1 VA: 0x288ECB0
	|-Dictionary.KeyCollection<object, object>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x28900E0 Offset: 0x28901E1 VA: 0x28900E0
	|-Dictionary.KeyCollection<object, Playable>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x2890AD0 Offset: 0x2890BD1 VA: 0x2890AD0
	|-Dictionary.KeyCollection<object, ResourceLocator>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x28914C0 Offset: 0x28915C1 VA: 0x28914C0
	|-Dictionary.KeyCollection<object, float>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x2891EB0 Offset: 0x2891FB1 VA: 0x2891EB0
	|-Dictionary.KeyCollection<object, ushort>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x28928A0 Offset: 0x28929A1 VA: 0x28928A0
	|-Dictionary.KeyCollection<object, GameVariable.Value>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x2893270 Offset: 0x2893371 VA: 0x2893270
	|-Dictionary.KeyCollection<sbyte, DataStoreRatingInfo>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x2893C80 Offset: 0x2893D81 VA: 0x2893C80
	|-Dictionary.KeyCollection<sbyte, object>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x2894690 Offset: 0x2894791 VA: 0x2894690
	|-Dictionary.KeyCollection<ushort, int>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x28950A0 Offset: 0x28951A1 VA: 0x28950A0
	|-Dictionary.KeyCollection<uint, int>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x2895AB0 Offset: 0x2895BB1 VA: 0x2895AB0
	|-Dictionary.KeyCollection<uint, object>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x28964C0 Offset: 0x28965C1 VA: 0x28964C0
	|-Dictionary.KeyCollection<ulong, Friend>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x2896ED0 Offset: 0x2896FD1 VA: 0x2896ED0
	|-Dictionary.KeyCollection<ulong, Int32Enum>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x28978E0 Offset: 0x28979E1 VA: 0x28978E0
	|-Dictionary.KeyCollection<ulong, object>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x2898300 Offset: 0x2898401 VA: 0x2898300
	|-Dictionary.KeyCollection<Vector3, int>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x2898D40 Offset: 0x2898E41 VA: 0x2898D40
	|-Dictionary.KeyCollection<XPathNodeRef, XPathNodeRef>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x2899750 Offset: 0x2899851 VA: 0x2899750
	|-Dictionary.KeyCollection<TerrainUtility.TerrainMap.TileCoord, object>.System.Collections.Generic.ICollection<TKey>.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 10
	private bool System.Collections.Generic.ICollection<TKey>.Remove(TKey item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2F7F390 Offset: 0x2F7F491 VA: 0x2F7F390
	|-Dictionary.KeyCollection<ValueTuple<object, int>, object>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x2F7FDA0 Offset: 0x2F7FEA1 VA: 0x2F7FDA0
	|-Dictionary.KeyCollection<byte, object>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x2F807D0 Offset: 0x2F808D1 VA: 0x2F807D0
	|-Dictionary.KeyCollection<CancellationToken, object>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x2F811E0 Offset: 0x2F812E1 VA: 0x2F811E0
	|-Dictionary.KeyCollection<char, object>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x2F81C00 Offset: 0x2F81D01 VA: 0x2F81C00
	|-Dictionary.KeyCollection<Guid, object>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x2F82610 Offset: 0x2F82711 VA: 0x2F82610
	|-Dictionary.KeyCollection<int, bool>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x2F83A60 Offset: 0x2F83B61 VA: 0x2F83A60
	|-Dictionary.KeyCollection<int, byte>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x2F84470 Offset: 0x2F84571 VA: 0x2F84470
	|-Dictionary.KeyCollection<int, char>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x2F84E80 Offset: 0x2F84F81 VA: 0x2F84E80
	|-Dictionary.KeyCollection<int, DiagnosticEvent>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x2F85890 Offset: 0x2F85991 VA: 0x2F85890
	|-Dictionary.KeyCollection<int, int>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x2F86CE0 Offset: 0x2F86DE1 VA: 0x2F86CE0
	|-Dictionary.KeyCollection<int, Int32Enum>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x2F876F0 Offset: 0x2F877F1 VA: 0x2F876F0
	|-Dictionary.KeyCollection<int, long>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x2F88100 Offset: 0x2F88201 VA: 0x2F88100
	|-Dictionary.KeyCollection<int, MapPos>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x2F88B10 Offset: 0x2F88C11 VA: 0x2F88B10
	|-Dictionary.KeyCollection<int, object>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x2F89520 Offset: 0x2F89621 VA: 0x2F89520
	|-Dictionary.KeyCollection<int, uint>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x2F89F30 Offset: 0x2F8A031 VA: 0x2F89F30
	|-Dictionary.KeyCollection<int, AIThink.EnchantThink.SurroundingInfo>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x2F8A940 Offset: 0x2F8AA41 VA: 0x2F8A940
	|-Dictionary.KeyCollection<Int32Enum, bool>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x2F8B350 Offset: 0x2F8B451 VA: 0x2F8B350
	|-Dictionary.KeyCollection<Int32Enum, int>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x2F8BD60 Offset: 0x2F8BE61 VA: 0x2F8BD60
	|-Dictionary.KeyCollection<Int32Enum, Int32Enum>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x2F8C770 Offset: 0x2F8C871 VA: 0x2F8C770
	|-Dictionary.KeyCollection<Int32Enum, object>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x2F8D180 Offset: 0x2F8D281 VA: 0x2F8D180
	|-Dictionary.KeyCollection<long, object>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x2F8DB90 Offset: 0x2F8DC91 VA: 0x2F8DB90
	|-Dictionary.KeyCollection<MapPos, int>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x2F8E5C0 Offset: 0x2F8E6C1 VA: 0x2F8E5C0
	|-Dictionary.KeyCollection<object, AsyncOperationHandle<object>>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x2F8EFB0 Offset: 0x2F8F0B1 VA: 0x2F8EFB0
	|-Dictionary.KeyCollection<object, AsyncOperationHandle>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x2F8F9A0 Offset: 0x2F8FAA1 VA: 0x2F8F9A0
	|-Dictionary.KeyCollection<object, bool>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x288C510 Offset: 0x288C611 VA: 0x288C510
	|-Dictionary.KeyCollection<object, byte>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x288CF00 Offset: 0x288D001 VA: 0x288CF00
	|-Dictionary.KeyCollection<object, int>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x288D8F0 Offset: 0x288D9F1 VA: 0x288D8F0
	|-Dictionary.KeyCollection<object, Int32Enum>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x288E2E0 Offset: 0x288E3E1 VA: 0x288E2E0
	|-Dictionary.KeyCollection<object, IntPtr>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x288ECD0 Offset: 0x288EDD1 VA: 0x288ECD0
	|-Dictionary.KeyCollection<object, object>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x2890100 Offset: 0x2890201 VA: 0x2890100
	|-Dictionary.KeyCollection<object, Playable>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x2890AF0 Offset: 0x2890BF1 VA: 0x2890AF0
	|-Dictionary.KeyCollection<object, ResourceLocator>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x28914E0 Offset: 0x28915E1 VA: 0x28914E0
	|-Dictionary.KeyCollection<object, float>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x2891ED0 Offset: 0x2891FD1 VA: 0x2891ED0
	|-Dictionary.KeyCollection<object, ushort>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x28928C0 Offset: 0x28929C1 VA: 0x28928C0
	|-Dictionary.KeyCollection<object, GameVariable.Value>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x2893290 Offset: 0x2893391 VA: 0x2893290
	|-Dictionary.KeyCollection<sbyte, DataStoreRatingInfo>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x2893CA0 Offset: 0x2893DA1 VA: 0x2893CA0
	|-Dictionary.KeyCollection<sbyte, object>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x28946B0 Offset: 0x28947B1 VA: 0x28946B0
	|-Dictionary.KeyCollection<ushort, int>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x28950C0 Offset: 0x28951C1 VA: 0x28950C0
	|-Dictionary.KeyCollection<uint, int>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x2895AD0 Offset: 0x2895BD1 VA: 0x2895AD0
	|-Dictionary.KeyCollection<uint, object>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x28964E0 Offset: 0x28965E1 VA: 0x28964E0
	|-Dictionary.KeyCollection<ulong, Friend>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x2896EF0 Offset: 0x2896FF1 VA: 0x2896EF0
	|-Dictionary.KeyCollection<ulong, Int32Enum>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x2897900 Offset: 0x2897A01 VA: 0x2897900
	|-Dictionary.KeyCollection<ulong, object>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x2898320 Offset: 0x2898421 VA: 0x2898320
	|-Dictionary.KeyCollection<Vector3, int>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x2898D60 Offset: 0x2898E61 VA: 0x2898D60
	|-Dictionary.KeyCollection<XPathNodeRef, XPathNodeRef>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x2899770 Offset: 0x2899871 VA: 0x2899770
	|-Dictionary.KeyCollection<TerrainUtility.TerrainMap.TileCoord, object>.System.Collections.Generic.ICollection<TKey>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 11
	private IEnumerator<TKey> System.Collections.Generic.IEnumerable<TKey>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2F7F3F0 Offset: 0x2F7F4F1 VA: 0x2F7F3F0
	|-Dictionary.KeyCollection<ValueTuple<object, int>, object>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x2F7FE00 Offset: 0x2F7FF01 VA: 0x2F7FE00
	|-Dictionary.KeyCollection<byte, object>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x2F80830 Offset: 0x2F80931 VA: 0x2F80830
	|-Dictionary.KeyCollection<CancellationToken, object>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x2F81240 Offset: 0x2F81341 VA: 0x2F81240
	|-Dictionary.KeyCollection<char, object>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x2F81C60 Offset: 0x2F81D61 VA: 0x2F81C60
	|-Dictionary.KeyCollection<Guid, object>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x2F82670 Offset: 0x2F82771 VA: 0x2F82670
	|-Dictionary.KeyCollection<int, bool>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x2F83AC0 Offset: 0x2F83BC1 VA: 0x2F83AC0
	|-Dictionary.KeyCollection<int, byte>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x2F844D0 Offset: 0x2F845D1 VA: 0x2F844D0
	|-Dictionary.KeyCollection<int, char>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x2F84EE0 Offset: 0x2F84FE1 VA: 0x2F84EE0
	|-Dictionary.KeyCollection<int, DiagnosticEvent>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x2F858F0 Offset: 0x2F859F1 VA: 0x2F858F0
	|-Dictionary.KeyCollection<int, int>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x2F86D40 Offset: 0x2F86E41 VA: 0x2F86D40
	|-Dictionary.KeyCollection<int, Int32Enum>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x2F87750 Offset: 0x2F87851 VA: 0x2F87750
	|-Dictionary.KeyCollection<int, long>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x2F88160 Offset: 0x2F88261 VA: 0x2F88160
	|-Dictionary.KeyCollection<int, MapPos>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x2F88B70 Offset: 0x2F88C71 VA: 0x2F88B70
	|-Dictionary.KeyCollection<int, object>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x2F89580 Offset: 0x2F89681 VA: 0x2F89580
	|-Dictionary.KeyCollection<int, uint>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x2F89F90 Offset: 0x2F8A091 VA: 0x2F89F90
	|-Dictionary.KeyCollection<int, AIThink.EnchantThink.SurroundingInfo>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x2F8A9A0 Offset: 0x2F8AAA1 VA: 0x2F8A9A0
	|-Dictionary.KeyCollection<Int32Enum, bool>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x2F8B3B0 Offset: 0x2F8B4B1 VA: 0x2F8B3B0
	|-Dictionary.KeyCollection<Int32Enum, int>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x2F8BDC0 Offset: 0x2F8BEC1 VA: 0x2F8BDC0
	|-Dictionary.KeyCollection<Int32Enum, Int32Enum>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x2F8C7D0 Offset: 0x2F8C8D1 VA: 0x2F8C7D0
	|-Dictionary.KeyCollection<Int32Enum, object>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x2F8D1E0 Offset: 0x2F8D2E1 VA: 0x2F8D1E0
	|-Dictionary.KeyCollection<long, object>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x2F8DBF0 Offset: 0x2F8DCF1 VA: 0x2F8DBF0
	|-Dictionary.KeyCollection<MapPos, int>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x2F8E620 Offset: 0x2F8E721 VA: 0x2F8E620
	|-Dictionary.KeyCollection<object, AsyncOperationHandle<object>>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x2F8F010 Offset: 0x2F8F111 VA: 0x2F8F010
	|-Dictionary.KeyCollection<object, AsyncOperationHandle>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x2F8FA00 Offset: 0x2F8FB01 VA: 0x2F8FA00
	|-Dictionary.KeyCollection<object, bool>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x288C570 Offset: 0x288C671 VA: 0x288C570
	|-Dictionary.KeyCollection<object, byte>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x288CF60 Offset: 0x288D061 VA: 0x288CF60
	|-Dictionary.KeyCollection<object, int>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x288D950 Offset: 0x288DA51 VA: 0x288D950
	|-Dictionary.KeyCollection<object, Int32Enum>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x288E340 Offset: 0x288E441 VA: 0x288E340
	|-Dictionary.KeyCollection<object, IntPtr>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x288ED30 Offset: 0x288EE31 VA: 0x288ED30
	|-Dictionary.KeyCollection<object, object>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x2890160 Offset: 0x2890261 VA: 0x2890160
	|-Dictionary.KeyCollection<object, Playable>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x2890B50 Offset: 0x2890C51 VA: 0x2890B50
	|-Dictionary.KeyCollection<object, ResourceLocator>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x2891540 Offset: 0x2891641 VA: 0x2891540
	|-Dictionary.KeyCollection<object, float>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x2891F30 Offset: 0x2892031 VA: 0x2891F30
	|-Dictionary.KeyCollection<object, ushort>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x2892920 Offset: 0x2892A21 VA: 0x2892920
	|-Dictionary.KeyCollection<object, GameVariable.Value>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x28932F0 Offset: 0x28933F1 VA: 0x28932F0
	|-Dictionary.KeyCollection<sbyte, DataStoreRatingInfo>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x2893D00 Offset: 0x2893E01 VA: 0x2893D00
	|-Dictionary.KeyCollection<sbyte, object>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x2894710 Offset: 0x2894811 VA: 0x2894710
	|-Dictionary.KeyCollection<ushort, int>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x2895120 Offset: 0x2895221 VA: 0x2895120
	|-Dictionary.KeyCollection<uint, int>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x2895B30 Offset: 0x2895C31 VA: 0x2895B30
	|-Dictionary.KeyCollection<uint, object>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x2896540 Offset: 0x2896641 VA: 0x2896540
	|-Dictionary.KeyCollection<ulong, Friend>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x2896F50 Offset: 0x2897051 VA: 0x2896F50
	|-Dictionary.KeyCollection<ulong, Int32Enum>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x2897960 Offset: 0x2897A61 VA: 0x2897960
	|-Dictionary.KeyCollection<ulong, object>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x2898380 Offset: 0x2898481 VA: 0x2898380
	|-Dictionary.KeyCollection<Vector3, int>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x2898DC0 Offset: 0x2898EC1 VA: 0x2898DC0
	|-Dictionary.KeyCollection<XPathNodeRef, XPathNodeRef>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x28997D0 Offset: 0x28998D1 VA: 0x28997D0
	|-Dictionary.KeyCollection<TerrainUtility.TerrainMap.TileCoord, object>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 12
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2F7F470 Offset: 0x2F7F571 VA: 0x2F7F470
	|-Dictionary.KeyCollection<ValueTuple<object, int>, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2F7FE80 Offset: 0x2F7FF81 VA: 0x2F7FE80
	|-Dictionary.KeyCollection<byte, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2F808B0 Offset: 0x2F809B1 VA: 0x2F808B0
	|-Dictionary.KeyCollection<CancellationToken, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2F812C0 Offset: 0x2F813C1 VA: 0x2F812C0
	|-Dictionary.KeyCollection<char, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2F81CE0 Offset: 0x2F81DE1 VA: 0x2F81CE0
	|-Dictionary.KeyCollection<Guid, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2F826F0 Offset: 0x2F827F1 VA: 0x2F826F0
	|-Dictionary.KeyCollection<int, bool>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2F83B40 Offset: 0x2F83C41 VA: 0x2F83B40
	|-Dictionary.KeyCollection<int, byte>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2F84550 Offset: 0x2F84651 VA: 0x2F84550
	|-Dictionary.KeyCollection<int, char>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2F84F60 Offset: 0x2F85061 VA: 0x2F84F60
	|-Dictionary.KeyCollection<int, DiagnosticEvent>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2F85970 Offset: 0x2F85A71 VA: 0x2F85970
	|-Dictionary.KeyCollection<int, int>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2F86DC0 Offset: 0x2F86EC1 VA: 0x2F86DC0
	|-Dictionary.KeyCollection<int, Int32Enum>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2F877D0 Offset: 0x2F878D1 VA: 0x2F877D0
	|-Dictionary.KeyCollection<int, long>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2F881E0 Offset: 0x2F882E1 VA: 0x2F881E0
	|-Dictionary.KeyCollection<int, MapPos>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2F88BF0 Offset: 0x2F88CF1 VA: 0x2F88BF0
	|-Dictionary.KeyCollection<int, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2F89600 Offset: 0x2F89701 VA: 0x2F89600
	|-Dictionary.KeyCollection<int, uint>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2F8A010 Offset: 0x2F8A111 VA: 0x2F8A010
	|-Dictionary.KeyCollection<int, AIThink.EnchantThink.SurroundingInfo>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2F8AA20 Offset: 0x2F8AB21 VA: 0x2F8AA20
	|-Dictionary.KeyCollection<Int32Enum, bool>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2F8B430 Offset: 0x2F8B531 VA: 0x2F8B430
	|-Dictionary.KeyCollection<Int32Enum, int>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2F8BE40 Offset: 0x2F8BF41 VA: 0x2F8BE40
	|-Dictionary.KeyCollection<Int32Enum, Int32Enum>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2F8C850 Offset: 0x2F8C951 VA: 0x2F8C850
	|-Dictionary.KeyCollection<Int32Enum, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2F8D260 Offset: 0x2F8D361 VA: 0x2F8D260
	|-Dictionary.KeyCollection<long, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2F8DC70 Offset: 0x2F8DD71 VA: 0x2F8DC70
	|-Dictionary.KeyCollection<MapPos, int>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2F8E6A0 Offset: 0x2F8E7A1 VA: 0x2F8E6A0
	|-Dictionary.KeyCollection<object, AsyncOperationHandle<object>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2F8F090 Offset: 0x2F8F191 VA: 0x2F8F090
	|-Dictionary.KeyCollection<object, AsyncOperationHandle>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2F8FA80 Offset: 0x2F8FB81 VA: 0x2F8FA80
	|-Dictionary.KeyCollection<object, bool>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x288C5F0 Offset: 0x288C6F1 VA: 0x288C5F0
	|-Dictionary.KeyCollection<object, byte>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x288CFE0 Offset: 0x288D0E1 VA: 0x288CFE0
	|-Dictionary.KeyCollection<object, int>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x288D9D0 Offset: 0x288DAD1 VA: 0x288D9D0
	|-Dictionary.KeyCollection<object, Int32Enum>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x288E3C0 Offset: 0x288E4C1 VA: 0x288E3C0
	|-Dictionary.KeyCollection<object, IntPtr>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x288EDB0 Offset: 0x288EEB1 VA: 0x288EDB0
	|-Dictionary.KeyCollection<object, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x28901E0 Offset: 0x28902E1 VA: 0x28901E0
	|-Dictionary.KeyCollection<object, Playable>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2890BD0 Offset: 0x2890CD1 VA: 0x2890BD0
	|-Dictionary.KeyCollection<object, ResourceLocator>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x28915C0 Offset: 0x28916C1 VA: 0x28915C0
	|-Dictionary.KeyCollection<object, float>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2891FB0 Offset: 0x28920B1 VA: 0x2891FB0
	|-Dictionary.KeyCollection<object, ushort>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x28929A0 Offset: 0x2892AA1 VA: 0x28929A0
	|-Dictionary.KeyCollection<object, GameVariable.Value>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2893370 Offset: 0x2893471 VA: 0x2893370
	|-Dictionary.KeyCollection<sbyte, DataStoreRatingInfo>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2893D80 Offset: 0x2893E81 VA: 0x2893D80
	|-Dictionary.KeyCollection<sbyte, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2894790 Offset: 0x2894891 VA: 0x2894790
	|-Dictionary.KeyCollection<ushort, int>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x28951A0 Offset: 0x28952A1 VA: 0x28951A0
	|-Dictionary.KeyCollection<uint, int>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2895BB0 Offset: 0x2895CB1 VA: 0x2895BB0
	|-Dictionary.KeyCollection<uint, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x28965C0 Offset: 0x28966C1 VA: 0x28965C0
	|-Dictionary.KeyCollection<ulong, Friend>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2896FD0 Offset: 0x28970D1 VA: 0x2896FD0
	|-Dictionary.KeyCollection<ulong, Int32Enum>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x28979E0 Offset: 0x2897AE1 VA: 0x28979E0
	|-Dictionary.KeyCollection<ulong, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2898400 Offset: 0x2898501 VA: 0x2898400
	|-Dictionary.KeyCollection<Vector3, int>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2898E40 Offset: 0x2898F41 VA: 0x2898E40
	|-Dictionary.KeyCollection<XPathNodeRef, XPathNodeRef>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2899850 Offset: 0x2899951 VA: 0x2899850
	|-Dictionary.KeyCollection<TerrainUtility.TerrainMap.TileCoord, object>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 13
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2F7F4F0 Offset: 0x2F7F5F1 VA: 0x2F7F4F0
	|-Dictionary.KeyCollection<ValueTuple<object, int>, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2F7FF00 Offset: 0x2F80001 VA: 0x2F7FF00
	|-Dictionary.KeyCollection<byte, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2F80930 Offset: 0x2F80A31 VA: 0x2F80930
	|-Dictionary.KeyCollection<CancellationToken, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2F81340 Offset: 0x2F81441 VA: 0x2F81340
	|-Dictionary.KeyCollection<char, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2F81D60 Offset: 0x2F81E61 VA: 0x2F81D60
	|-Dictionary.KeyCollection<Guid, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2F82770 Offset: 0x2F82871 VA: 0x2F82770
	|-Dictionary.KeyCollection<int, bool>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2F83BC0 Offset: 0x2F83CC1 VA: 0x2F83BC0
	|-Dictionary.KeyCollection<int, byte>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2F845D0 Offset: 0x2F846D1 VA: 0x2F845D0
	|-Dictionary.KeyCollection<int, char>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2F84FE0 Offset: 0x2F850E1 VA: 0x2F84FE0
	|-Dictionary.KeyCollection<int, DiagnosticEvent>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2F859F0 Offset: 0x2F85AF1 VA: 0x2F859F0
	|-Dictionary.KeyCollection<int, int>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2F86E40 Offset: 0x2F86F41 VA: 0x2F86E40
	|-Dictionary.KeyCollection<int, Int32Enum>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2F87850 Offset: 0x2F87951 VA: 0x2F87850
	|-Dictionary.KeyCollection<int, long>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2F88260 Offset: 0x2F88361 VA: 0x2F88260
	|-Dictionary.KeyCollection<int, MapPos>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2F88C70 Offset: 0x2F88D71 VA: 0x2F88C70
	|-Dictionary.KeyCollection<int, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2F89680 Offset: 0x2F89781 VA: 0x2F89680
	|-Dictionary.KeyCollection<int, uint>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2F8A090 Offset: 0x2F8A191 VA: 0x2F8A090
	|-Dictionary.KeyCollection<int, AIThink.EnchantThink.SurroundingInfo>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2F8AAA0 Offset: 0x2F8ABA1 VA: 0x2F8AAA0
	|-Dictionary.KeyCollection<Int32Enum, bool>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2F8B4B0 Offset: 0x2F8B5B1 VA: 0x2F8B4B0
	|-Dictionary.KeyCollection<Int32Enum, int>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2F8BEC0 Offset: 0x2F8BFC1 VA: 0x2F8BEC0
	|-Dictionary.KeyCollection<Int32Enum, Int32Enum>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2F8C8D0 Offset: 0x2F8C9D1 VA: 0x2F8C8D0
	|-Dictionary.KeyCollection<Int32Enum, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2F8D2E0 Offset: 0x2F8D3E1 VA: 0x2F8D2E0
	|-Dictionary.KeyCollection<long, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2F8DCF0 Offset: 0x2F8DDF1 VA: 0x2F8DCF0
	|-Dictionary.KeyCollection<MapPos, int>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2F8E720 Offset: 0x2F8E821 VA: 0x2F8E720
	|-Dictionary.KeyCollection<object, AsyncOperationHandle<object>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2F8F110 Offset: 0x2F8F211 VA: 0x2F8F110
	|-Dictionary.KeyCollection<object, AsyncOperationHandle>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2F8FB00 Offset: 0x2F8FC01 VA: 0x2F8FB00
	|-Dictionary.KeyCollection<object, bool>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x288C670 Offset: 0x288C771 VA: 0x288C670
	|-Dictionary.KeyCollection<object, byte>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x288D060 Offset: 0x288D161 VA: 0x288D060
	|-Dictionary.KeyCollection<object, int>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x288DA50 Offset: 0x288DB51 VA: 0x288DA50
	|-Dictionary.KeyCollection<object, Int32Enum>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x288E440 Offset: 0x288E541 VA: 0x288E440
	|-Dictionary.KeyCollection<object, IntPtr>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x288EE30 Offset: 0x288EF31 VA: 0x288EE30
	|-Dictionary.KeyCollection<object, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2890260 Offset: 0x2890361 VA: 0x2890260
	|-Dictionary.KeyCollection<object, Playable>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2890C50 Offset: 0x2890D51 VA: 0x2890C50
	|-Dictionary.KeyCollection<object, ResourceLocator>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2891640 Offset: 0x2891741 VA: 0x2891640
	|-Dictionary.KeyCollection<object, float>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2892030 Offset: 0x2892131 VA: 0x2892030
	|-Dictionary.KeyCollection<object, ushort>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2892A20 Offset: 0x2892B21 VA: 0x2892A20
	|-Dictionary.KeyCollection<object, GameVariable.Value>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x28933F0 Offset: 0x28934F1 VA: 0x28933F0
	|-Dictionary.KeyCollection<sbyte, DataStoreRatingInfo>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2893E00 Offset: 0x2893F01 VA: 0x2893E00
	|-Dictionary.KeyCollection<sbyte, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2894810 Offset: 0x2894911 VA: 0x2894810
	|-Dictionary.KeyCollection<ushort, int>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2895220 Offset: 0x2895321 VA: 0x2895220
	|-Dictionary.KeyCollection<uint, int>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2895C30 Offset: 0x2895D31 VA: 0x2895C30
	|-Dictionary.KeyCollection<uint, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2896640 Offset: 0x2896741 VA: 0x2896640
	|-Dictionary.KeyCollection<ulong, Friend>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2897050 Offset: 0x2897151 VA: 0x2897050
	|-Dictionary.KeyCollection<ulong, Int32Enum>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2897A60 Offset: 0x2897B61 VA: 0x2897A60
	|-Dictionary.KeyCollection<ulong, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2898480 Offset: 0x2898581 VA: 0x2898480
	|-Dictionary.KeyCollection<Vector3, int>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2898EC0 Offset: 0x2898FC1 VA: 0x2898EC0
	|-Dictionary.KeyCollection<XPathNodeRef, XPathNodeRef>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x28998D0 Offset: 0x28999D1 VA: 0x28998D0
	|-Dictionary.KeyCollection<TerrainUtility.TerrainMap.TileCoord, object>.System.Collections.ICollection.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 16
	private bool System.Collections.ICollection.get_IsSynchronized() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2F7F920 Offset: 0x2F7FA21 VA: 0x2F7F920
	|-Dictionary.KeyCollection<ValueTuple<object, int>, object>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2F80330 Offset: 0x2F80431 VA: 0x2F80330
	|-Dictionary.KeyCollection<byte, object>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2F80D60 Offset: 0x2F80E61 VA: 0x2F80D60
	|-Dictionary.KeyCollection<CancellationToken, object>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2F81770 Offset: 0x2F81871 VA: 0x2F81770
	|-Dictionary.KeyCollection<char, object>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2F82190 Offset: 0x2F82291 VA: 0x2F82190
	|-Dictionary.KeyCollection<Guid, object>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2F82BA0 Offset: 0x2F82CA1 VA: 0x2F82BA0
	|-Dictionary.KeyCollection<int, bool>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2F83FF0 Offset: 0x2F840F1 VA: 0x2F83FF0
	|-Dictionary.KeyCollection<int, byte>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2F84A00 Offset: 0x2F84B01 VA: 0x2F84A00
	|-Dictionary.KeyCollection<int, char>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2F85410 Offset: 0x2F85511 VA: 0x2F85410
	|-Dictionary.KeyCollection<int, DiagnosticEvent>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2F85E20 Offset: 0x2F85F21 VA: 0x2F85E20
	|-Dictionary.KeyCollection<int, int>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2F87270 Offset: 0x2F87371 VA: 0x2F87270
	|-Dictionary.KeyCollection<int, Int32Enum>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2F87C80 Offset: 0x2F87D81 VA: 0x2F87C80
	|-Dictionary.KeyCollection<int, long>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2F88690 Offset: 0x2F88791 VA: 0x2F88690
	|-Dictionary.KeyCollection<int, MapPos>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2F890A0 Offset: 0x2F891A1 VA: 0x2F890A0
	|-Dictionary.KeyCollection<int, object>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2F89AB0 Offset: 0x2F89BB1 VA: 0x2F89AB0
	|-Dictionary.KeyCollection<int, uint>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2F8A4C0 Offset: 0x2F8A5C1 VA: 0x2F8A4C0
	|-Dictionary.KeyCollection<int, AIThink.EnchantThink.SurroundingInfo>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2F8AED0 Offset: 0x2F8AFD1 VA: 0x2F8AED0
	|-Dictionary.KeyCollection<Int32Enum, bool>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2F8B8E0 Offset: 0x2F8B9E1 VA: 0x2F8B8E0
	|-Dictionary.KeyCollection<Int32Enum, int>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2F8C2F0 Offset: 0x2F8C3F1 VA: 0x2F8C2F0
	|-Dictionary.KeyCollection<Int32Enum, Int32Enum>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2F8CD00 Offset: 0x2F8CE01 VA: 0x2F8CD00
	|-Dictionary.KeyCollection<Int32Enum, object>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2F8D710 Offset: 0x2F8D811 VA: 0x2F8D710
	|-Dictionary.KeyCollection<long, object>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2F8E120 Offset: 0x2F8E221 VA: 0x2F8E120
	|-Dictionary.KeyCollection<MapPos, int>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2F8EB10 Offset: 0x2F8EC11 VA: 0x2F8EB10
	|-Dictionary.KeyCollection<object, AsyncOperationHandle<object>>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2F8F500 Offset: 0x2F8F601 VA: 0x2F8F500
	|-Dictionary.KeyCollection<object, AsyncOperationHandle>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2F8FEF0 Offset: 0x2F8FFF1 VA: 0x2F8FEF0
	|-Dictionary.KeyCollection<object, bool>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x288CA60 Offset: 0x288CB61 VA: 0x288CA60
	|-Dictionary.KeyCollection<object, byte>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x288D450 Offset: 0x288D551 VA: 0x288D450
	|-Dictionary.KeyCollection<object, int>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x288DE40 Offset: 0x288DF41 VA: 0x288DE40
	|-Dictionary.KeyCollection<object, Int32Enum>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x288E830 Offset: 0x288E931 VA: 0x288E830
	|-Dictionary.KeyCollection<object, IntPtr>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x288F220 Offset: 0x288F321 VA: 0x288F220
	|-Dictionary.KeyCollection<object, object>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2890650 Offset: 0x2890751 VA: 0x2890650
	|-Dictionary.KeyCollection<object, Playable>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2891040 Offset: 0x2891141 VA: 0x2891040
	|-Dictionary.KeyCollection<object, ResourceLocator>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2891A30 Offset: 0x2891B31 VA: 0x2891A30
	|-Dictionary.KeyCollection<object, float>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2892420 Offset: 0x2892521 VA: 0x2892420
	|-Dictionary.KeyCollection<object, ushort>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2892E10 Offset: 0x2892F11 VA: 0x2892E10
	|-Dictionary.KeyCollection<object, GameVariable.Value>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2893820 Offset: 0x2893921 VA: 0x2893820
	|-Dictionary.KeyCollection<sbyte, DataStoreRatingInfo>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2894230 Offset: 0x2894331 VA: 0x2894230
	|-Dictionary.KeyCollection<sbyte, object>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2894C40 Offset: 0x2894D41 VA: 0x2894C40
	|-Dictionary.KeyCollection<ushort, int>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2895650 Offset: 0x2895751 VA: 0x2895650
	|-Dictionary.KeyCollection<uint, int>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2896060 Offset: 0x2896161 VA: 0x2896060
	|-Dictionary.KeyCollection<uint, object>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2896A70 Offset: 0x2896B71 VA: 0x2896A70
	|-Dictionary.KeyCollection<ulong, Friend>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2897480 Offset: 0x2897581 VA: 0x2897480
	|-Dictionary.KeyCollection<ulong, Int32Enum>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2897E90 Offset: 0x2897F91 VA: 0x2897E90
	|-Dictionary.KeyCollection<ulong, object>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x28988C0 Offset: 0x28989C1 VA: 0x28988C0
	|-Dictionary.KeyCollection<Vector3, int>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x28992F0 Offset: 0x28993F1 VA: 0x28992F0
	|-Dictionary.KeyCollection<XPathNodeRef, XPathNodeRef>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2899D00 Offset: 0x2899E01 VA: 0x2899D00
	|-Dictionary.KeyCollection<TerrainUtility.TerrainMap.TileCoord, object>.System.Collections.ICollection.get_IsSynchronized
	*/

	// RVA: -1 Offset: -1 Slot: 15
	private object System.Collections.ICollection.get_SyncRoot() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2F7F930 Offset: 0x2F7FA31 VA: 0x2F7F930
	|-Dictionary.KeyCollection<ValueTuple<object, int>, object>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2F80340 Offset: 0x2F80441 VA: 0x2F80340
	|-Dictionary.KeyCollection<byte, object>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2F80D70 Offset: 0x2F80E71 VA: 0x2F80D70
	|-Dictionary.KeyCollection<CancellationToken, object>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2F81780 Offset: 0x2F81881 VA: 0x2F81780
	|-Dictionary.KeyCollection<char, object>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2F821A0 Offset: 0x2F822A1 VA: 0x2F821A0
	|-Dictionary.KeyCollection<Guid, object>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2F82BB0 Offset: 0x2F82CB1 VA: 0x2F82BB0
	|-Dictionary.KeyCollection<int, bool>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2F84000 Offset: 0x2F84101 VA: 0x2F84000
	|-Dictionary.KeyCollection<int, byte>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2F84A10 Offset: 0x2F84B11 VA: 0x2F84A10
	|-Dictionary.KeyCollection<int, char>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2F85420 Offset: 0x2F85521 VA: 0x2F85420
	|-Dictionary.KeyCollection<int, DiagnosticEvent>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2F85E30 Offset: 0x2F85F31 VA: 0x2F85E30
	|-Dictionary.KeyCollection<int, int>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2F87280 Offset: 0x2F87381 VA: 0x2F87280
	|-Dictionary.KeyCollection<int, Int32Enum>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2F87C90 Offset: 0x2F87D91 VA: 0x2F87C90
	|-Dictionary.KeyCollection<int, long>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2F886A0 Offset: 0x2F887A1 VA: 0x2F886A0
	|-Dictionary.KeyCollection<int, MapPos>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2F890B0 Offset: 0x2F891B1 VA: 0x2F890B0
	|-Dictionary.KeyCollection<int, object>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2F89AC0 Offset: 0x2F89BC1 VA: 0x2F89AC0
	|-Dictionary.KeyCollection<int, uint>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2F8A4D0 Offset: 0x2F8A5D1 VA: 0x2F8A4D0
	|-Dictionary.KeyCollection<int, AIThink.EnchantThink.SurroundingInfo>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2F8AEE0 Offset: 0x2F8AFE1 VA: 0x2F8AEE0
	|-Dictionary.KeyCollection<Int32Enum, bool>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2F8B8F0 Offset: 0x2F8B9F1 VA: 0x2F8B8F0
	|-Dictionary.KeyCollection<Int32Enum, int>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2F8C300 Offset: 0x2F8C401 VA: 0x2F8C300
	|-Dictionary.KeyCollection<Int32Enum, Int32Enum>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2F8CD10 Offset: 0x2F8CE11 VA: 0x2F8CD10
	|-Dictionary.KeyCollection<Int32Enum, object>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2F8D720 Offset: 0x2F8D821 VA: 0x2F8D720
	|-Dictionary.KeyCollection<long, object>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2F8E130 Offset: 0x2F8E231 VA: 0x2F8E130
	|-Dictionary.KeyCollection<MapPos, int>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2F8EB20 Offset: 0x2F8EC21 VA: 0x2F8EB20
	|-Dictionary.KeyCollection<object, AsyncOperationHandle<object>>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2F8F510 Offset: 0x2F8F611 VA: 0x2F8F510
	|-Dictionary.KeyCollection<object, AsyncOperationHandle>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2F8FF00 Offset: 0x2F90001 VA: 0x2F8FF00
	|-Dictionary.KeyCollection<object, bool>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x288CA70 Offset: 0x288CB71 VA: 0x288CA70
	|-Dictionary.KeyCollection<object, byte>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x288D460 Offset: 0x288D561 VA: 0x288D460
	|-Dictionary.KeyCollection<object, int>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x288DE50 Offset: 0x288DF51 VA: 0x288DE50
	|-Dictionary.KeyCollection<object, Int32Enum>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x288E840 Offset: 0x288E941 VA: 0x288E840
	|-Dictionary.KeyCollection<object, IntPtr>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x288F230 Offset: 0x288F331 VA: 0x288F230
	|-Dictionary.KeyCollection<object, object>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2890660 Offset: 0x2890761 VA: 0x2890660
	|-Dictionary.KeyCollection<object, Playable>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2891050 Offset: 0x2891151 VA: 0x2891050
	|-Dictionary.KeyCollection<object, ResourceLocator>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2891A40 Offset: 0x2891B41 VA: 0x2891A40
	|-Dictionary.KeyCollection<object, float>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2892430 Offset: 0x2892531 VA: 0x2892430
	|-Dictionary.KeyCollection<object, ushort>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2892E20 Offset: 0x2892F21 VA: 0x2892E20
	|-Dictionary.KeyCollection<object, GameVariable.Value>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2893830 Offset: 0x2893931 VA: 0x2893830
	|-Dictionary.KeyCollection<sbyte, DataStoreRatingInfo>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2894240 Offset: 0x2894341 VA: 0x2894240
	|-Dictionary.KeyCollection<sbyte, object>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2894C50 Offset: 0x2894D51 VA: 0x2894C50
	|-Dictionary.KeyCollection<ushort, int>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2895660 Offset: 0x2895761 VA: 0x2895660
	|-Dictionary.KeyCollection<uint, int>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2896070 Offset: 0x2896171 VA: 0x2896070
	|-Dictionary.KeyCollection<uint, object>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2896A80 Offset: 0x2896B81 VA: 0x2896A80
	|-Dictionary.KeyCollection<ulong, Friend>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2897490 Offset: 0x2897591 VA: 0x2897490
	|-Dictionary.KeyCollection<ulong, Int32Enum>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2897EA0 Offset: 0x2897FA1 VA: 0x2897EA0
	|-Dictionary.KeyCollection<ulong, object>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x28988D0 Offset: 0x28989D1 VA: 0x28988D0
	|-Dictionary.KeyCollection<Vector3, int>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2899300 Offset: 0x2899401 VA: 0x2899300
	|-Dictionary.KeyCollection<XPathNodeRef, XPathNodeRef>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2899D10 Offset: 0x2899E11 VA: 0x2899D10
	|-Dictionary.KeyCollection<TerrainUtility.TerrainMap.TileCoord, object>.System.Collections.ICollection.get_SyncRoot
	*/
}

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

// Namespace: 
[DebuggerDisplayAttribute] // RVA: 0x477600 Offset: 0x477701 VA: 0x477600
[DebuggerTypeProxyAttribute] // RVA: 0x477600 Offset: 0x477701 VA: 0x477600
[Serializable]
public sealed class Dictionary.ValueCollection<TKey, TValue> : ICollection<TValue>, IEnumerable<TValue>, IEnumerable, ICollection, IReadOnlyCollection<TValue> // TypeDefIndex: 1406
{
	// Fields
	private Dictionary<TKey, TValue> dictionary; // 0x0

	// Properties
	public int Count { get; }
	private bool System.Collections.Generic.ICollection<TValue>.IsReadOnly { get; }
	private bool System.Collections.ICollection.IsSynchronized { get; }
	private object System.Collections.ICollection.SyncRoot { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(Dictionary<TKey, TValue> dictionary) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DF9CD0 Offset: 0x2DF9DD1 VA: 0x2DF9CD0
	|-Dictionary.ValueCollection<ValueTuple<object, int>, object>..ctor
	|
	|-RVA: 0x2DFA6C0 Offset: 0x2DFA7C1 VA: 0x2DFA6C0
	|-Dictionary.ValueCollection<byte, object>..ctor
	|
	|-RVA: 0x2DFB0B0 Offset: 0x2DFB1B1 VA: 0x2DFB0B0
	|-Dictionary.ValueCollection<CancellationToken, object>..ctor
	|
	|-RVA: 0x2DFBAA0 Offset: 0x2DFBBA1 VA: 0x2DFBAA0
	|-Dictionary.ValueCollection<char, object>..ctor
	|
	|-RVA: 0x2DFC490 Offset: 0x2DFC591 VA: 0x2DFC490
	|-Dictionary.ValueCollection<Guid, object>..ctor
	|
	|-RVA: 0x2DFCE80 Offset: 0x2DFCF81 VA: 0x2DFCE80
	|-Dictionary.ValueCollection<int, bool>..ctor
	|
	|-RVA: 0x2DFE2D0 Offset: 0x2DFE3D1 VA: 0x2DFE2D0
	|-Dictionary.ValueCollection<int, byte>..ctor
	|
	|-RVA: 0x2DFECE0 Offset: 0x2DFEDE1 VA: 0x2DFECE0
	|-Dictionary.ValueCollection<int, char>..ctor
	|
	|-RVA: 0x2DFF6F0 Offset: 0x2DFF7F1 VA: 0x2DFF6F0
	|-Dictionary.ValueCollection<int, DiagnosticEvent>..ctor
	|
	|-RVA: 0x2E00200 Offset: 0x2E00301 VA: 0x2E00200
	|-Dictionary.ValueCollection<int, int>..ctor
	|
	|-RVA: 0x2E01650 Offset: 0x2E01751 VA: 0x2E01650
	|-Dictionary.ValueCollection<int, Int32Enum>..ctor
	|
	|-RVA: 0x2E02060 Offset: 0x2E02161 VA: 0x2E02060
	|-Dictionary.ValueCollection<int, long>..ctor
	|
	|-RVA: 0x337B150 Offset: 0x337B251 VA: 0x337B150
	|-Dictionary.ValueCollection<int, MapPos>..ctor
	|
	|-RVA: 0x337BB60 Offset: 0x337BC61 VA: 0x337BB60
	|-Dictionary.ValueCollection<int, object>..ctor
	|
	|-RVA: 0x337C550 Offset: 0x337C651 VA: 0x337C550
	|-Dictionary.ValueCollection<int, uint>..ctor
	|
	|-RVA: 0x337CF60 Offset: 0x337D061 VA: 0x337CF60
	|-Dictionary.ValueCollection<int, AIThink.EnchantThink.SurroundingInfo>..ctor
	|
	|-RVA: 0x337D970 Offset: 0x337DA71 VA: 0x337D970
	|-Dictionary.ValueCollection<Int32Enum, bool>..ctor
	|
	|-RVA: 0x337E380 Offset: 0x337E481 VA: 0x337E380
	|-Dictionary.ValueCollection<Int32Enum, int>..ctor
	|
	|-RVA: 0x337ED90 Offset: 0x337EE91 VA: 0x337ED90
	|-Dictionary.ValueCollection<Int32Enum, Int32Enum>..ctor
	|
	|-RVA: 0x337F7A0 Offset: 0x337F8A1 VA: 0x337F7A0
	|-Dictionary.ValueCollection<Int32Enum, object>..ctor
	|
	|-RVA: 0x3380190 Offset: 0x3380291 VA: 0x3380190
	|-Dictionary.ValueCollection<long, object>..ctor
	|
	|-RVA: 0x3380B80 Offset: 0x3380C81 VA: 0x3380B80
	|-Dictionary.ValueCollection<MapPos, int>..ctor
	|
	|-RVA: 0x3381590 Offset: 0x3381691 VA: 0x3381590
	|-Dictionary.ValueCollection<object, AsyncOperationHandle<object>>..ctor
	|
	|-RVA: 0x3382050 Offset: 0x3382151 VA: 0x3382050
	|-Dictionary.ValueCollection<object, AsyncOperationHandle>..ctor
	|
	|-RVA: 0x3382B10 Offset: 0x3382C11 VA: 0x3382B10
	|-Dictionary.ValueCollection<object, bool>..ctor
	|
	|-RVA: 0x3383520 Offset: 0x3383621 VA: 0x3383520
	|-Dictionary.ValueCollection<object, byte>..ctor
	|
	|-RVA: 0x3383F30 Offset: 0x3384031 VA: 0x3383F30
	|-Dictionary.ValueCollection<object, int>..ctor
	|
	|-RVA: 0x3384940 Offset: 0x3384A41 VA: 0x3384940
	|-Dictionary.ValueCollection<object, Int32Enum>..ctor
	|
	|-RVA: 0x3385350 Offset: 0x3385451 VA: 0x3385350
	|-Dictionary.ValueCollection<object, IntPtr>..ctor
	|
	|-RVA: 0x3385D60 Offset: 0x3385E61 VA: 0x3385D60
	|-Dictionary.ValueCollection<object, object>..ctor
	|
	|-RVA: 0x3387190 Offset: 0x3387291 VA: 0x3387190
	|-Dictionary.ValueCollection<object, Playable>..ctor
	|
	|-RVA: 0x3387BB0 Offset: 0x3387CB1 VA: 0x3387BB0
	|-Dictionary.ValueCollection<object, ResourceLocator>..ctor
	|
	|-RVA: 0x33885E0 Offset: 0x33886E1 VA: 0x33885E0
	|-Dictionary.ValueCollection<object, float>..ctor
	|
	|-RVA: 0x3388FF0 Offset: 0x33890F1 VA: 0x3388FF0
	|-Dictionary.ValueCollection<object, ushort>..ctor
	|
	|-RVA: 0x3389A00 Offset: 0x3389B01 VA: 0x3389A00
	|-Dictionary.ValueCollection<object, GameVariable.Value>..ctor
	|
	|-RVA: 0x338A430 Offset: 0x338A531 VA: 0x338A430
	|-Dictionary.ValueCollection<sbyte, DataStoreRatingInfo>..ctor
	|
	|-RVA: 0x338AEE0 Offset: 0x338AFE1 VA: 0x338AEE0
	|-Dictionary.ValueCollection<sbyte, object>..ctor
	|
	|-RVA: 0x338B8D0 Offset: 0x338B9D1 VA: 0x338B8D0
	|-Dictionary.ValueCollection<ushort, int>..ctor
	|
	|-RVA: 0x338C2E0 Offset: 0x338C3E1 VA: 0x338C2E0
	|-Dictionary.ValueCollection<uint, int>..ctor
	|
	|-RVA: 0x338CCF0 Offset: 0x338CDF1 VA: 0x338CCF0
	|-Dictionary.ValueCollection<uint, object>..ctor
	|
	|-RVA: 0x338D6E0 Offset: 0x338D7E1 VA: 0x338D6E0
	|-Dictionary.ValueCollection<ulong, Friend>..ctor
	|
	|-RVA: 0x338E200 Offset: 0x338E301 VA: 0x338E200
	|-Dictionary.ValueCollection<ulong, Int32Enum>..ctor
	|
	|-RVA: 0x338EC10 Offset: 0x338ED11 VA: 0x338EC10
	|-Dictionary.ValueCollection<ulong, object>..ctor
	|
	|-RVA: 0x338F600 Offset: 0x338F701 VA: 0x338F600
	|-Dictionary.ValueCollection<Vector3, int>..ctor
	|
	|-RVA: 0x3390010 Offset: 0x3390111 VA: 0x3390010
	|-Dictionary.ValueCollection<XPathNodeRef, XPathNodeRef>..ctor
	|
	|-RVA: 0x3390A40 Offset: 0x3390B41 VA: 0x3390A40
	|-Dictionary.ValueCollection<TerrainUtility.TerrainMap.TileCoord, object>..ctor
	*/

	// RVA: -1 Offset: -1
	public Dictionary.ValueCollection.Enumerator<TKey, TValue> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DF9D50 Offset: 0x2DF9E51 VA: 0x2DF9D50
	|-Dictionary.ValueCollection<ValueTuple<object, int>, object>.GetEnumerator
	|
	|-RVA: 0x2DFA740 Offset: 0x2DFA841 VA: 0x2DFA740
	|-Dictionary.ValueCollection<byte, object>.GetEnumerator
	|
	|-RVA: 0x2DFB130 Offset: 0x2DFB231 VA: 0x2DFB130
	|-Dictionary.ValueCollection<CancellationToken, object>.GetEnumerator
	|
	|-RVA: 0x2DFBB20 Offset: 0x2DFBC21 VA: 0x2DFBB20
	|-Dictionary.ValueCollection<char, object>.GetEnumerator
	|
	|-RVA: 0x2DFC510 Offset: 0x2DFC611 VA: 0x2DFC510
	|-Dictionary.ValueCollection<Guid, object>.GetEnumerator
	|
	|-RVA: 0x2DFCF00 Offset: 0x2DFD001 VA: 0x2DFCF00
	|-Dictionary.ValueCollection<int, bool>.GetEnumerator
	|
	|-RVA: 0x2DFE350 Offset: 0x2DFE451 VA: 0x2DFE350
	|-Dictionary.ValueCollection<int, byte>.GetEnumerator
	|
	|-RVA: 0x337BBE0 Offset: 0x337BCE1 VA: 0x337BBE0
	|-Dictionary.ValueCollection<int, CalculatorCommand>.GetEnumerator
	|-Dictionary.ValueCollection<int, GameObject>.GetEnumerator
	|-Dictionary.ValueCollection<int, object>.GetEnumerator
	|-Dictionary.ValueCollection<int, PointerEventData>.GetEnumerator
	|-Dictionary.ValueCollection<int, ResourceGameObject>.GetEnumerator
	|-Dictionary.ValueCollection<int, MapHistory.Rewind.OverlapData>.GetEnumerator
	|
	|-RVA: 0x2DFED60 Offset: 0x2DFEE61 VA: 0x2DFED60
	|-Dictionary.ValueCollection<int, char>.GetEnumerator
	|
	|-RVA: 0x2DFF770 Offset: 0x2DFF871 VA: 0x2DFF770
	|-Dictionary.ValueCollection<int, DiagnosticEvent>.GetEnumerator
	|
	|-RVA: 0x2E00280 Offset: 0x2E00381 VA: 0x2E00280
	|-Dictionary.ValueCollection<int, int>.GetEnumerator
	|
	|-RVA: 0x2E016D0 Offset: 0x2E017D1 VA: 0x2E016D0
	|-Dictionary.ValueCollection<int, Int32Enum>.GetEnumerator
	|
	|-RVA: 0x2E020E0 Offset: 0x2E021E1 VA: 0x2E020E0
	|-Dictionary.ValueCollection<int, long>.GetEnumerator
	|
	|-RVA: 0x337B1D0 Offset: 0x337B2D1 VA: 0x337B1D0
	|-Dictionary.ValueCollection<int, MapPos>.GetEnumerator
	|
	|-RVA: 0x337C5D0 Offset: 0x337C6D1 VA: 0x337C5D0
	|-Dictionary.ValueCollection<int, uint>.GetEnumerator
	|
	|-RVA: 0x337CFE0 Offset: 0x337D0E1 VA: 0x337CFE0
	|-Dictionary.ValueCollection<int, AIThink.EnchantThink.SurroundingInfo>.GetEnumerator
	|
	|-RVA: 0x337D9F0 Offset: 0x337DAF1 VA: 0x337D9F0
	|-Dictionary.ValueCollection<Int32Enum, bool>.GetEnumerator
	|
	|-RVA: 0x337E400 Offset: 0x337E501 VA: 0x337E400
	|-Dictionary.ValueCollection<Int32Enum, int>.GetEnumerator
	|-Dictionary.ValueCollection<HubAccessManager.MaterialCalculator.Type, int>.GetEnumerator
	|
	|-RVA: 0x337EE10 Offset: 0x337EF11 VA: 0x337EE10
	|-Dictionary.ValueCollection<Int32Enum, Int32Enum>.GetEnumerator
	|
	|-RVA: 0x337F820 Offset: 0x337F921 VA: 0x337F820
	|-Dictionary.ValueCollection<Int32Enum, object>.GetEnumerator
	|
	|-RVA: 0x3380210 Offset: 0x3380311 VA: 0x3380210
	|-Dictionary.ValueCollection<long, object>.GetEnumerator
	|
	|-RVA: 0x3380C00 Offset: 0x3380D01 VA: 0x3380C00
	|-Dictionary.ValueCollection<MapPos, int>.GetEnumerator
	|
	|-RVA: 0x3381610 Offset: 0x3381711 VA: 0x3381610
	|-Dictionary.ValueCollection<object, AsyncOperationHandle<object>>.GetEnumerator
	|
	|-RVA: 0x33820D0 Offset: 0x33821D1 VA: 0x33820D0
	|-Dictionary.ValueCollection<object, AsyncOperationHandle>.GetEnumerator
	|-Dictionary.ValueCollection<string, AsyncOperationHandle>.GetEnumerator
	|
	|-RVA: 0x3382B90 Offset: 0x3382C91 VA: 0x3382B90
	|-Dictionary.ValueCollection<object, bool>.GetEnumerator
	|
	|-RVA: 0x33835A0 Offset: 0x33836A1 VA: 0x33835A0
	|-Dictionary.ValueCollection<object, byte>.GetEnumerator
	|
	|-RVA: 0x3383FB0 Offset: 0x33840B1 VA: 0x3383FB0
	|-Dictionary.ValueCollection<object, int>.GetEnumerator
	|
	|-RVA: 0x33849C0 Offset: 0x3384AC1 VA: 0x33849C0
	|-Dictionary.ValueCollection<object, Int32Enum>.GetEnumerator
	|
	|-RVA: 0x33853D0 Offset: 0x33854D1 VA: 0x33853D0
	|-Dictionary.ValueCollection<object, IntPtr>.GetEnumerator
	|
	|-RVA: 0x3385DE0 Offset: 0x3385EE1 VA: 0x3385DE0
	|-Dictionary.ValueCollection<object, object>.GetEnumerator
	|-Dictionary.ValueCollection<string, FileData>.GetEnumerator
	|-Dictionary.ValueCollection<string, GUIStyle>.GetEnumerator
	|-Dictionary.ValueCollection<string, GodBond>.GetEnumerator
	|-Dictionary.ValueCollection<string, LabelStatement>.GetEnumerator
	|-Dictionary.ValueCollection<string, ResourceHandle>.GetEnumerator
	|-Dictionary.ValueCollection<string, SchemaNotation>.GetEnumerator
	|-Dictionary.ValueCollection<string, Sprite>.GetEnumerator
	|-Dictionary.ValueCollection<string, string>.GetEnumerator
	|-Dictionary.ValueCollection<string, SymbolRef>.GetEnumerator
	|-Dictionary.ValueCollection<string, Transform>.GetEnumerator
	|-Dictionary.ValueCollection<string, UnitRelianceData>.GetEnumerator
	|-Dictionary.ValueCollection<string, DtdParser.UndeclaredNotation>.GetEnumerator
	|-Dictionary.ValueCollection<string, EventDemoSequence.CharacterWork>.GetEnumerator
	|-Dictionary.ValueCollection<string, EventDemoSequence.SplitViewWork>.GetEnumerator
	|-Dictionary.ValueCollection<XmlQualifiedName, SchemaAttDef>.GetEnumerator
	|-Dictionary.ValueCollection<XmlQualifiedName, SchemaElementDecl>.GetEnumerator
	|-Dictionary.ValueCollection<XmlQualifiedName, SchemaEntity>.GetEnumerator
	|
	|-RVA: 0x3387210 Offset: 0x3387311 VA: 0x3387210
	|-Dictionary.ValueCollection<object, Playable>.GetEnumerator
	|
	|-RVA: 0x3387C30 Offset: 0x3387D31 VA: 0x3387C30
	|-Dictionary.ValueCollection<object, ResourceLocator>.GetEnumerator
	|
	|-RVA: 0x3388660 Offset: 0x3388761 VA: 0x3388660
	|-Dictionary.ValueCollection<object, float>.GetEnumerator
	|
	|-RVA: 0x3389070 Offset: 0x3389171 VA: 0x3389070
	|-Dictionary.ValueCollection<object, ushort>.GetEnumerator
	|
	|-RVA: 0x3389A80 Offset: 0x3389B81 VA: 0x3389A80
	|-Dictionary.ValueCollection<object, GameVariable.Value>.GetEnumerator
	|
	|-RVA: 0x338A4B0 Offset: 0x338A5B1 VA: 0x338A4B0
	|-Dictionary.ValueCollection<sbyte, DataStoreRatingInfo>.GetEnumerator
	|
	|-RVA: 0x338AF60 Offset: 0x338B061 VA: 0x338AF60
	|-Dictionary.ValueCollection<sbyte, object>.GetEnumerator
	|
	|-RVA: 0x338B950 Offset: 0x338BA51 VA: 0x338B950
	|-Dictionary.ValueCollection<ushort, int>.GetEnumerator
	|
	|-RVA: 0x338C360 Offset: 0x338C461 VA: 0x338C360
	|-Dictionary.ValueCollection<uint, int>.GetEnumerator
	|
	|-RVA: 0x338CD70 Offset: 0x338CE71 VA: 0x338CD70
	|-Dictionary.ValueCollection<uint, object>.GetEnumerator
	|
	|-RVA: 0x338D760 Offset: 0x338D861 VA: 0x338D760
	|-Dictionary.ValueCollection<ulong, Friend>.GetEnumerator
	|
	|-RVA: 0x338E280 Offset: 0x338E381 VA: 0x338E280
	|-Dictionary.ValueCollection<ulong, Int32Enum>.GetEnumerator
	|
	|-RVA: 0x338EC90 Offset: 0x338ED91 VA: 0x338EC90
	|-Dictionary.ValueCollection<ulong, object>.GetEnumerator
	|
	|-RVA: 0x338F680 Offset: 0x338F781 VA: 0x338F680
	|-Dictionary.ValueCollection<Vector3, int>.GetEnumerator
	|
	|-RVA: 0x3390090 Offset: 0x3390191 VA: 0x3390090
	|-Dictionary.ValueCollection<XPathNodeRef, XPathNodeRef>.GetEnumerator
	|
	|-RVA: 0x3390AC0 Offset: 0x3390BC1 VA: 0x3390AC0
	|-Dictionary.ValueCollection<TerrainUtility.TerrainMap.TileCoord, object>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public void CopyTo(TValue[] array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DF9DB0 Offset: 0x2DF9EB1 VA: 0x2DF9DB0
	|-Dictionary.ValueCollection<ValueTuple<object, int>, object>.CopyTo
	|
	|-RVA: 0x2DFA7A0 Offset: 0x2DFA8A1 VA: 0x2DFA7A0
	|-Dictionary.ValueCollection<byte, object>.CopyTo
	|
	|-RVA: 0x2DFB190 Offset: 0x2DFB291 VA: 0x2DFB190
	|-Dictionary.ValueCollection<CancellationToken, object>.CopyTo
	|
	|-RVA: 0x2DFBB80 Offset: 0x2DFBC81 VA: 0x2DFBB80
	|-Dictionary.ValueCollection<char, object>.CopyTo
	|
	|-RVA: 0x2DFC570 Offset: 0x2DFC671 VA: 0x2DFC570
	|-Dictionary.ValueCollection<Guid, object>.CopyTo
	|
	|-RVA: 0x2DFCF60 Offset: 0x2DFD061 VA: 0x2DFCF60
	|-Dictionary.ValueCollection<int, bool>.CopyTo
	|
	|-RVA: 0x2DFE3B0 Offset: 0x2DFE4B1 VA: 0x2DFE3B0
	|-Dictionary.ValueCollection<int, byte>.CopyTo
	|
	|-RVA: 0x2DFEDC0 Offset: 0x2DFEEC1 VA: 0x2DFEDC0
	|-Dictionary.ValueCollection<int, char>.CopyTo
	|
	|-RVA: 0x2DFF7E0 Offset: 0x2DFF8E1 VA: 0x2DFF7E0
	|-Dictionary.ValueCollection<int, DiagnosticEvent>.CopyTo
	|
	|-RVA: 0x2E002E0 Offset: 0x2E003E1 VA: 0x2E002E0
	|-Dictionary.ValueCollection<int, int>.CopyTo
	|
	|-RVA: 0x2E01730 Offset: 0x2E01831 VA: 0x2E01730
	|-Dictionary.ValueCollection<int, Int32Enum>.CopyTo
	|
	|-RVA: 0x2E02140 Offset: 0x2E02241 VA: 0x2E02140
	|-Dictionary.ValueCollection<int, long>.CopyTo
	|
	|-RVA: 0x337B230 Offset: 0x337B331 VA: 0x337B230
	|-Dictionary.ValueCollection<int, MapPos>.CopyTo
	|
	|-RVA: 0x337BC40 Offset: 0x337BD41 VA: 0x337BC40
	|-Dictionary.ValueCollection<int, object>.CopyTo
	|
	|-RVA: 0x337C630 Offset: 0x337C731 VA: 0x337C630
	|-Dictionary.ValueCollection<int, uint>.CopyTo
	|
	|-RVA: 0x337D040 Offset: 0x337D141 VA: 0x337D040
	|-Dictionary.ValueCollection<int, AIThink.EnchantThink.SurroundingInfo>.CopyTo
	|
	|-RVA: 0x337DA50 Offset: 0x337DB51 VA: 0x337DA50
	|-Dictionary.ValueCollection<Int32Enum, bool>.CopyTo
	|
	|-RVA: 0x337E460 Offset: 0x337E561 VA: 0x337E460
	|-Dictionary.ValueCollection<Int32Enum, int>.CopyTo
	|
	|-RVA: 0x337EE70 Offset: 0x337EF71 VA: 0x337EE70
	|-Dictionary.ValueCollection<Int32Enum, Int32Enum>.CopyTo
	|
	|-RVA: 0x337F880 Offset: 0x337F981 VA: 0x337F880
	|-Dictionary.ValueCollection<Int32Enum, object>.CopyTo
	|
	|-RVA: 0x3380270 Offset: 0x3380371 VA: 0x3380270
	|-Dictionary.ValueCollection<long, object>.CopyTo
	|
	|-RVA: 0x3380C60 Offset: 0x3380D61 VA: 0x3380C60
	|-Dictionary.ValueCollection<MapPos, int>.CopyTo
	|
	|-RVA: 0x3381680 Offset: 0x3381781 VA: 0x3381680
	|-Dictionary.ValueCollection<object, AsyncOperationHandle<object>>.CopyTo
	|
	|-RVA: 0x3382140 Offset: 0x3382241 VA: 0x3382140
	|-Dictionary.ValueCollection<object, AsyncOperationHandle>.CopyTo
	|
	|-RVA: 0x3382BF0 Offset: 0x3382CF1 VA: 0x3382BF0
	|-Dictionary.ValueCollection<object, bool>.CopyTo
	|
	|-RVA: 0x3383600 Offset: 0x3383701 VA: 0x3383600
	|-Dictionary.ValueCollection<object, byte>.CopyTo
	|
	|-RVA: 0x3384010 Offset: 0x3384111 VA: 0x3384010
	|-Dictionary.ValueCollection<object, int>.CopyTo
	|
	|-RVA: 0x3384A20 Offset: 0x3384B21 VA: 0x3384A20
	|-Dictionary.ValueCollection<object, Int32Enum>.CopyTo
	|
	|-RVA: 0x3385430 Offset: 0x3385531 VA: 0x3385430
	|-Dictionary.ValueCollection<object, IntPtr>.CopyTo
	|
	|-RVA: 0x3385E40 Offset: 0x3385F41 VA: 0x3385E40
	|-Dictionary.ValueCollection<object, object>.CopyTo
	|
	|-RVA: 0x3387270 Offset: 0x3387371 VA: 0x3387270
	|-Dictionary.ValueCollection<object, Playable>.CopyTo
	|
	|-RVA: 0x3387C90 Offset: 0x3387D91 VA: 0x3387C90
	|-Dictionary.ValueCollection<object, ResourceLocator>.CopyTo
	|
	|-RVA: 0x33886C0 Offset: 0x33887C1 VA: 0x33886C0
	|-Dictionary.ValueCollection<object, float>.CopyTo
	|
	|-RVA: 0x33890D0 Offset: 0x33891D1 VA: 0x33890D0
	|-Dictionary.ValueCollection<object, ushort>.CopyTo
	|
	|-RVA: 0x3389AE0 Offset: 0x3389BE1 VA: 0x3389AE0
	|-Dictionary.ValueCollection<object, GameVariable.Value>.CopyTo
	|
	|-RVA: 0x338A520 Offset: 0x338A621 VA: 0x338A520
	|-Dictionary.ValueCollection<sbyte, DataStoreRatingInfo>.CopyTo
	|
	|-RVA: 0x338AFC0 Offset: 0x338B0C1 VA: 0x338AFC0
	|-Dictionary.ValueCollection<sbyte, object>.CopyTo
	|
	|-RVA: 0x338B9B0 Offset: 0x338BAB1 VA: 0x338B9B0
	|-Dictionary.ValueCollection<ushort, int>.CopyTo
	|
	|-RVA: 0x338C3C0 Offset: 0x338C4C1 VA: 0x338C3C0
	|-Dictionary.ValueCollection<uint, int>.CopyTo
	|
	|-RVA: 0x338CDD0 Offset: 0x338CED1 VA: 0x338CDD0
	|-Dictionary.ValueCollection<uint, object>.CopyTo
	|
	|-RVA: 0x338D7E0 Offset: 0x338D8E1 VA: 0x338D7E0
	|-Dictionary.ValueCollection<ulong, Friend>.CopyTo
	|
	|-RVA: 0x338E2E0 Offset: 0x338E3E1 VA: 0x338E2E0
	|-Dictionary.ValueCollection<ulong, Int32Enum>.CopyTo
	|
	|-RVA: 0x338ECF0 Offset: 0x338EDF1 VA: 0x338ECF0
	|-Dictionary.ValueCollection<ulong, object>.CopyTo
	|
	|-RVA: 0x338F6E0 Offset: 0x338F7E1 VA: 0x338F6E0
	|-Dictionary.ValueCollection<Vector3, int>.CopyTo
	|
	|-RVA: 0x33900F0 Offset: 0x33901F1 VA: 0x33900F0
	|-Dictionary.ValueCollection<XPathNodeRef, XPathNodeRef>.CopyTo
	|
	|-RVA: 0x3390B20 Offset: 0x3390C21 VA: 0x3390B20
	|-Dictionary.ValueCollection<TerrainUtility.TerrainMap.TileCoord, object>.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 17
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DF9FA0 Offset: 0x2DFA0A1 VA: 0x2DF9FA0
	|-Dictionary.ValueCollection<ValueTuple<object, int>, object>.get_Count
	|
	|-RVA: 0x2DFA990 Offset: 0x2DFAA91 VA: 0x2DFA990
	|-Dictionary.ValueCollection<byte, object>.get_Count
	|
	|-RVA: 0x2DFB380 Offset: 0x2DFB481 VA: 0x2DFB380
	|-Dictionary.ValueCollection<CancellationToken, object>.get_Count
	|
	|-RVA: 0x2DFBD70 Offset: 0x2DFBE71 VA: 0x2DFBD70
	|-Dictionary.ValueCollection<char, object>.get_Count
	|
	|-RVA: 0x2DFC760 Offset: 0x2DFC861 VA: 0x2DFC760
	|-Dictionary.ValueCollection<Guid, object>.get_Count
	|
	|-RVA: 0x2DFD130 Offset: 0x2DFD231 VA: 0x2DFD130
	|-Dictionary.ValueCollection<int, bool>.get_Count
	|
	|-RVA: 0x2DFE580 Offset: 0x2DFE681 VA: 0x2DFE580
	|-Dictionary.ValueCollection<int, byte>.get_Count
	|
	|-RVA: 0x2DFEF90 Offset: 0x2DFF091 VA: 0x2DFEF90
	|-Dictionary.ValueCollection<int, char>.get_Count
	|
	|-RVA: 0x2DFFA10 Offset: 0x2DFFB11 VA: 0x2DFFA10
	|-Dictionary.ValueCollection<int, DiagnosticEvent>.get_Count
	|
	|-RVA: 0x2E004B0 Offset: 0x2E005B1 VA: 0x2E004B0
	|-Dictionary.ValueCollection<int, int>.get_Count
	|
	|-RVA: 0x2E01900 Offset: 0x2E01A01 VA: 0x2E01900
	|-Dictionary.ValueCollection<int, Int32Enum>.get_Count
	|
	|-RVA: 0x2E02310 Offset: 0x2E02411 VA: 0x2E02310
	|-Dictionary.ValueCollection<int, long>.get_Count
	|
	|-RVA: 0x337B400 Offset: 0x337B501 VA: 0x337B400
	|-Dictionary.ValueCollection<int, MapPos>.get_Count
	|
	|-RVA: 0x337BE30 Offset: 0x337BF31 VA: 0x337BE30
	|-Dictionary.ValueCollection<int, object>.get_Count
	|
	|-RVA: 0x337C800 Offset: 0x337C901 VA: 0x337C800
	|-Dictionary.ValueCollection<int, uint>.get_Count
	|
	|-RVA: 0x337D210 Offset: 0x337D311 VA: 0x337D210
	|-Dictionary.ValueCollection<int, AIThink.EnchantThink.SurroundingInfo>.get_Count
	|
	|-RVA: 0x337DC20 Offset: 0x337DD21 VA: 0x337DC20
	|-Dictionary.ValueCollection<Int32Enum, bool>.get_Count
	|
	|-RVA: 0x337E630 Offset: 0x337E731 VA: 0x337E630
	|-Dictionary.ValueCollection<Int32Enum, int>.get_Count
	|
	|-RVA: 0x337F040 Offset: 0x337F141 VA: 0x337F040
	|-Dictionary.ValueCollection<Int32Enum, Int32Enum>.get_Count
	|
	|-RVA: 0x337FA70 Offset: 0x337FB71 VA: 0x337FA70
	|-Dictionary.ValueCollection<Int32Enum, object>.get_Count
	|
	|-RVA: 0x3380460 Offset: 0x3380561 VA: 0x3380460
	|-Dictionary.ValueCollection<long, object>.get_Count
	|
	|-RVA: 0x3380E30 Offset: 0x3380F31 VA: 0x3380E30
	|-Dictionary.ValueCollection<MapPos, int>.get_Count
	|
	|-RVA: 0x3381890 Offset: 0x3381991 VA: 0x3381890
	|-Dictionary.ValueCollection<object, AsyncOperationHandle<object>>.get_Count
	|
	|-RVA: 0x3382350 Offset: 0x3382451 VA: 0x3382350
	|-Dictionary.ValueCollection<object, AsyncOperationHandle>.get_Count
	|
	|-RVA: 0x3382DC0 Offset: 0x3382EC1 VA: 0x3382DC0
	|-Dictionary.ValueCollection<object, bool>.get_Count
	|
	|-RVA: 0x33837D0 Offset: 0x33838D1 VA: 0x33837D0
	|-Dictionary.ValueCollection<object, byte>.get_Count
	|
	|-RVA: 0x33841E0 Offset: 0x33842E1 VA: 0x33841E0
	|-Dictionary.ValueCollection<object, int>.get_Count
	|
	|-RVA: 0x3384BF0 Offset: 0x3384CF1 VA: 0x3384BF0
	|-Dictionary.ValueCollection<object, Int32Enum>.get_Count
	|
	|-RVA: 0x3385600 Offset: 0x3385701 VA: 0x3385600
	|-Dictionary.ValueCollection<object, IntPtr>.get_Count
	|
	|-RVA: 0x3386030 Offset: 0x3386131 VA: 0x3386030
	|-Dictionary.ValueCollection<object, object>.get_Count
	|
	|-RVA: 0x3387450 Offset: 0x3387551 VA: 0x3387450
	|-Dictionary.ValueCollection<object, Playable>.get_Count
	|
	|-RVA: 0x3387E80 Offset: 0x3387F81 VA: 0x3387E80
	|-Dictionary.ValueCollection<object, ResourceLocator>.get_Count
	|
	|-RVA: 0x3388890 Offset: 0x3388991 VA: 0x3388890
	|-Dictionary.ValueCollection<object, float>.get_Count
	|
	|-RVA: 0x33892A0 Offset: 0x33893A1 VA: 0x33892A0
	|-Dictionary.ValueCollection<object, ushort>.get_Count
	|
	|-RVA: 0x3389CD0 Offset: 0x3389DD1 VA: 0x3389CD0
	|-Dictionary.ValueCollection<object, GameVariable.Value>.get_Count
	|
	|-RVA: 0x338A720 Offset: 0x338A821 VA: 0x338A720
	|-Dictionary.ValueCollection<sbyte, DataStoreRatingInfo>.get_Count
	|
	|-RVA: 0x338B1B0 Offset: 0x338B2B1 VA: 0x338B1B0
	|-Dictionary.ValueCollection<sbyte, object>.get_Count
	|
	|-RVA: 0x338BB80 Offset: 0x338BC81 VA: 0x338BB80
	|-Dictionary.ValueCollection<ushort, int>.get_Count
	|
	|-RVA: 0x338C590 Offset: 0x338C691 VA: 0x338C590
	|-Dictionary.ValueCollection<uint, int>.get_Count
	|
	|-RVA: 0x338CFC0 Offset: 0x338D0C1 VA: 0x338CFC0
	|-Dictionary.ValueCollection<uint, object>.get_Count
	|
	|-RVA: 0x338D9F0 Offset: 0x338DAF1 VA: 0x338D9F0
	|-Dictionary.ValueCollection<ulong, Friend>.get_Count
	|
	|-RVA: 0x338E4B0 Offset: 0x338E5B1 VA: 0x338E4B0
	|-Dictionary.ValueCollection<ulong, Int32Enum>.get_Count
	|
	|-RVA: 0x338EEE0 Offset: 0x338EFE1 VA: 0x338EEE0
	|-Dictionary.ValueCollection<ulong, object>.get_Count
	|
	|-RVA: 0x338F8B0 Offset: 0x338F9B1 VA: 0x338F8B0
	|-Dictionary.ValueCollection<Vector3, int>.get_Count
	|
	|-RVA: 0x33902E0 Offset: 0x33903E1 VA: 0x33902E0
	|-Dictionary.ValueCollection<XPathNodeRef, XPathNodeRef>.get_Count
	|
	|-RVA: 0x3390D10 Offset: 0x3390E11 VA: 0x3390D10
	|-Dictionary.ValueCollection<TerrainUtility.TerrainMap.TileCoord, object>.get_Count
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private bool System.Collections.Generic.ICollection<TValue>.get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DF9FC0 Offset: 0x2DFA0C1 VA: 0x2DF9FC0
	|-Dictionary.ValueCollection<ValueTuple<object, int>, object>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x2DFA9B0 Offset: 0x2DFAAB1 VA: 0x2DFA9B0
	|-Dictionary.ValueCollection<byte, object>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x2DFB3A0 Offset: 0x2DFB4A1 VA: 0x2DFB3A0
	|-Dictionary.ValueCollection<CancellationToken, object>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x2DFBD90 Offset: 0x2DFBE91 VA: 0x2DFBD90
	|-Dictionary.ValueCollection<char, object>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x2DFC780 Offset: 0x2DFC881 VA: 0x2DFC780
	|-Dictionary.ValueCollection<Guid, object>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x2DFD150 Offset: 0x2DFD251 VA: 0x2DFD150
	|-Dictionary.ValueCollection<int, bool>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x2DFE5A0 Offset: 0x2DFE6A1 VA: 0x2DFE5A0
	|-Dictionary.ValueCollection<int, byte>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x2DFEFB0 Offset: 0x2DFF0B1 VA: 0x2DFEFB0
	|-Dictionary.ValueCollection<int, char>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x2DFFA30 Offset: 0x2DFFB31 VA: 0x2DFFA30
	|-Dictionary.ValueCollection<int, DiagnosticEvent>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x2E004D0 Offset: 0x2E005D1 VA: 0x2E004D0
	|-Dictionary.ValueCollection<int, int>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x2E01920 Offset: 0x2E01A21 VA: 0x2E01920
	|-Dictionary.ValueCollection<int, Int32Enum>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x2E02330 Offset: 0x2E02431 VA: 0x2E02330
	|-Dictionary.ValueCollection<int, long>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x337B420 Offset: 0x337B521 VA: 0x337B420
	|-Dictionary.ValueCollection<int, MapPos>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x337BE50 Offset: 0x337BF51 VA: 0x337BE50
	|-Dictionary.ValueCollection<int, object>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x337C820 Offset: 0x337C921 VA: 0x337C820
	|-Dictionary.ValueCollection<int, uint>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x337D230 Offset: 0x337D331 VA: 0x337D230
	|-Dictionary.ValueCollection<int, AIThink.EnchantThink.SurroundingInfo>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x337DC40 Offset: 0x337DD41 VA: 0x337DC40
	|-Dictionary.ValueCollection<Int32Enum, bool>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x337E650 Offset: 0x337E751 VA: 0x337E650
	|-Dictionary.ValueCollection<Int32Enum, int>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x337F060 Offset: 0x337F161 VA: 0x337F060
	|-Dictionary.ValueCollection<Int32Enum, Int32Enum>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x337FA90 Offset: 0x337FB91 VA: 0x337FA90
	|-Dictionary.ValueCollection<Int32Enum, object>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x3380480 Offset: 0x3380581 VA: 0x3380480
	|-Dictionary.ValueCollection<long, object>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x3380E50 Offset: 0x3380F51 VA: 0x3380E50
	|-Dictionary.ValueCollection<MapPos, int>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x33818B0 Offset: 0x33819B1 VA: 0x33818B0
	|-Dictionary.ValueCollection<object, AsyncOperationHandle<object>>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x3382370 Offset: 0x3382471 VA: 0x3382370
	|-Dictionary.ValueCollection<object, AsyncOperationHandle>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x3382DE0 Offset: 0x3382EE1 VA: 0x3382DE0
	|-Dictionary.ValueCollection<object, bool>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x33837F0 Offset: 0x33838F1 VA: 0x33837F0
	|-Dictionary.ValueCollection<object, byte>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x3384200 Offset: 0x3384301 VA: 0x3384200
	|-Dictionary.ValueCollection<object, int>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x3384C10 Offset: 0x3384D11 VA: 0x3384C10
	|-Dictionary.ValueCollection<object, Int32Enum>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x3385620 Offset: 0x3385721 VA: 0x3385620
	|-Dictionary.ValueCollection<object, IntPtr>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x3386050 Offset: 0x3386151 VA: 0x3386050
	|-Dictionary.ValueCollection<object, object>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x3387470 Offset: 0x3387571 VA: 0x3387470
	|-Dictionary.ValueCollection<object, Playable>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x3387EA0 Offset: 0x3387FA1 VA: 0x3387EA0
	|-Dictionary.ValueCollection<object, ResourceLocator>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x33888B0 Offset: 0x33889B1 VA: 0x33888B0
	|-Dictionary.ValueCollection<object, float>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x33892C0 Offset: 0x33893C1 VA: 0x33892C0
	|-Dictionary.ValueCollection<object, ushort>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x3389CF0 Offset: 0x3389DF1 VA: 0x3389CF0
	|-Dictionary.ValueCollection<object, GameVariable.Value>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x338A740 Offset: 0x338A841 VA: 0x338A740
	|-Dictionary.ValueCollection<sbyte, DataStoreRatingInfo>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x338B1D0 Offset: 0x338B2D1 VA: 0x338B1D0
	|-Dictionary.ValueCollection<sbyte, object>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x338BBA0 Offset: 0x338BCA1 VA: 0x338BBA0
	|-Dictionary.ValueCollection<ushort, int>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x338C5B0 Offset: 0x338C6B1 VA: 0x338C5B0
	|-Dictionary.ValueCollection<uint, int>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x338CFE0 Offset: 0x338D0E1 VA: 0x338CFE0
	|-Dictionary.ValueCollection<uint, object>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x338DA10 Offset: 0x338DB11 VA: 0x338DA10
	|-Dictionary.ValueCollection<ulong, Friend>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x338E4D0 Offset: 0x338E5D1 VA: 0x338E4D0
	|-Dictionary.ValueCollection<ulong, Int32Enum>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x338EF00 Offset: 0x338F001 VA: 0x338EF00
	|-Dictionary.ValueCollection<ulong, object>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x338F8D0 Offset: 0x338F9D1 VA: 0x338F8D0
	|-Dictionary.ValueCollection<Vector3, int>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x3390300 Offset: 0x3390401 VA: 0x3390300
	|-Dictionary.ValueCollection<XPathNodeRef, XPathNodeRef>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x3390D30 Offset: 0x3390E31 VA: 0x3390D30
	|-Dictionary.ValueCollection<TerrainUtility.TerrainMap.TileCoord, object>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private void System.Collections.Generic.ICollection<TValue>.Add(TValue item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DF9FD0 Offset: 0x2DFA0D1 VA: 0x2DF9FD0
	|-Dictionary.ValueCollection<ValueTuple<object, int>, object>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x2DFA9C0 Offset: 0x2DFAAC1 VA: 0x2DFA9C0
	|-Dictionary.ValueCollection<byte, object>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x2DFB3B0 Offset: 0x2DFB4B1 VA: 0x2DFB3B0
	|-Dictionary.ValueCollection<CancellationToken, object>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x2DFBDA0 Offset: 0x2DFBEA1 VA: 0x2DFBDA0
	|-Dictionary.ValueCollection<char, object>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x2DFC790 Offset: 0x2DFC891 VA: 0x2DFC790
	|-Dictionary.ValueCollection<Guid, object>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x2DFD160 Offset: 0x2DFD261 VA: 0x2DFD160
	|-Dictionary.ValueCollection<int, bool>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x2DFE5B0 Offset: 0x2DFE6B1 VA: 0x2DFE5B0
	|-Dictionary.ValueCollection<int, byte>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x2DFEFC0 Offset: 0x2DFF0C1 VA: 0x2DFEFC0
	|-Dictionary.ValueCollection<int, char>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x2DFFA40 Offset: 0x2DFFB41 VA: 0x2DFFA40
	|-Dictionary.ValueCollection<int, DiagnosticEvent>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x2E004E0 Offset: 0x2E005E1 VA: 0x2E004E0
	|-Dictionary.ValueCollection<int, int>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x2E01930 Offset: 0x2E01A31 VA: 0x2E01930
	|-Dictionary.ValueCollection<int, Int32Enum>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x2E02340 Offset: 0x2E02441 VA: 0x2E02340
	|-Dictionary.ValueCollection<int, long>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x337B430 Offset: 0x337B531 VA: 0x337B430
	|-Dictionary.ValueCollection<int, MapPos>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x337BE60 Offset: 0x337BF61 VA: 0x337BE60
	|-Dictionary.ValueCollection<int, object>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x337C830 Offset: 0x337C931 VA: 0x337C830
	|-Dictionary.ValueCollection<int, uint>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x337D240 Offset: 0x337D341 VA: 0x337D240
	|-Dictionary.ValueCollection<int, AIThink.EnchantThink.SurroundingInfo>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x337DC50 Offset: 0x337DD51 VA: 0x337DC50
	|-Dictionary.ValueCollection<Int32Enum, bool>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x337E660 Offset: 0x337E761 VA: 0x337E660
	|-Dictionary.ValueCollection<Int32Enum, int>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x337F070 Offset: 0x337F171 VA: 0x337F070
	|-Dictionary.ValueCollection<Int32Enum, Int32Enum>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x337FAA0 Offset: 0x337FBA1 VA: 0x337FAA0
	|-Dictionary.ValueCollection<Int32Enum, object>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x3380490 Offset: 0x3380591 VA: 0x3380490
	|-Dictionary.ValueCollection<long, object>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x3380E60 Offset: 0x3380F61 VA: 0x3380E60
	|-Dictionary.ValueCollection<MapPos, int>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x33818C0 Offset: 0x33819C1 VA: 0x33818C0
	|-Dictionary.ValueCollection<object, AsyncOperationHandle<object>>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x3382380 Offset: 0x3382481 VA: 0x3382380
	|-Dictionary.ValueCollection<object, AsyncOperationHandle>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x3382DF0 Offset: 0x3382EF1 VA: 0x3382DF0
	|-Dictionary.ValueCollection<object, bool>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x3383800 Offset: 0x3383901 VA: 0x3383800
	|-Dictionary.ValueCollection<object, byte>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x3384210 Offset: 0x3384311 VA: 0x3384210
	|-Dictionary.ValueCollection<object, int>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x3384C20 Offset: 0x3384D21 VA: 0x3384C20
	|-Dictionary.ValueCollection<object, Int32Enum>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x3385630 Offset: 0x3385731 VA: 0x3385630
	|-Dictionary.ValueCollection<object, IntPtr>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x3386060 Offset: 0x3386161 VA: 0x3386060
	|-Dictionary.ValueCollection<object, object>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x3387480 Offset: 0x3387581 VA: 0x3387480
	|-Dictionary.ValueCollection<object, Playable>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x3387EB0 Offset: 0x3387FB1 VA: 0x3387EB0
	|-Dictionary.ValueCollection<object, ResourceLocator>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x33888C0 Offset: 0x33889C1 VA: 0x33888C0
	|-Dictionary.ValueCollection<object, float>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x33892D0 Offset: 0x33893D1 VA: 0x33892D0
	|-Dictionary.ValueCollection<object, ushort>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x3389D00 Offset: 0x3389E01 VA: 0x3389D00
	|-Dictionary.ValueCollection<object, GameVariable.Value>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x338A750 Offset: 0x338A851 VA: 0x338A750
	|-Dictionary.ValueCollection<sbyte, DataStoreRatingInfo>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x338B1E0 Offset: 0x338B2E1 VA: 0x338B1E0
	|-Dictionary.ValueCollection<sbyte, object>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x338BBB0 Offset: 0x338BCB1 VA: 0x338BBB0
	|-Dictionary.ValueCollection<ushort, int>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x338C5C0 Offset: 0x338C6C1 VA: 0x338C5C0
	|-Dictionary.ValueCollection<uint, int>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x338CFF0 Offset: 0x338D0F1 VA: 0x338CFF0
	|-Dictionary.ValueCollection<uint, object>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x338DA20 Offset: 0x338DB21 VA: 0x338DA20
	|-Dictionary.ValueCollection<ulong, Friend>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x338E4E0 Offset: 0x338E5E1 VA: 0x338E4E0
	|-Dictionary.ValueCollection<ulong, Int32Enum>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x338EF10 Offset: 0x338F011 VA: 0x338EF10
	|-Dictionary.ValueCollection<ulong, object>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x338F8E0 Offset: 0x338F9E1 VA: 0x338F8E0
	|-Dictionary.ValueCollection<Vector3, int>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x3390310 Offset: 0x3390411 VA: 0x3390310
	|-Dictionary.ValueCollection<XPathNodeRef, XPathNodeRef>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x3390D40 Offset: 0x3390E41 VA: 0x3390D40
	|-Dictionary.ValueCollection<TerrainUtility.TerrainMap.TileCoord, object>.System.Collections.Generic.ICollection<TValue>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 10
	private bool System.Collections.Generic.ICollection<TValue>.Remove(TValue item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DFA030 Offset: 0x2DFA131 VA: 0x2DFA030
	|-Dictionary.ValueCollection<ValueTuple<object, int>, object>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x2DFAA20 Offset: 0x2DFAB21 VA: 0x2DFAA20
	|-Dictionary.ValueCollection<byte, object>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x2DFB410 Offset: 0x2DFB511 VA: 0x2DFB410
	|-Dictionary.ValueCollection<CancellationToken, object>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x2DFBE00 Offset: 0x2DFBF01 VA: 0x2DFBE00
	|-Dictionary.ValueCollection<char, object>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x2DFC7F0 Offset: 0x2DFC8F1 VA: 0x2DFC7F0
	|-Dictionary.ValueCollection<Guid, object>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x2DFD1C0 Offset: 0x2DFD2C1 VA: 0x2DFD1C0
	|-Dictionary.ValueCollection<int, bool>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x2DFE610 Offset: 0x2DFE711 VA: 0x2DFE610
	|-Dictionary.ValueCollection<int, byte>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x2DFF020 Offset: 0x2DFF121 VA: 0x2DFF020
	|-Dictionary.ValueCollection<int, char>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x2DFFAA0 Offset: 0x2DFFBA1 VA: 0x2DFFAA0
	|-Dictionary.ValueCollection<int, DiagnosticEvent>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x2E00540 Offset: 0x2E00641 VA: 0x2E00540
	|-Dictionary.ValueCollection<int, int>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x2E01990 Offset: 0x2E01A91 VA: 0x2E01990
	|-Dictionary.ValueCollection<int, Int32Enum>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x2E023A0 Offset: 0x2E024A1 VA: 0x2E023A0
	|-Dictionary.ValueCollection<int, long>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x337B490 Offset: 0x337B591 VA: 0x337B490
	|-Dictionary.ValueCollection<int, MapPos>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x337BEC0 Offset: 0x337BFC1 VA: 0x337BEC0
	|-Dictionary.ValueCollection<int, object>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x337C890 Offset: 0x337C991 VA: 0x337C890
	|-Dictionary.ValueCollection<int, uint>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x337D2A0 Offset: 0x337D3A1 VA: 0x337D2A0
	|-Dictionary.ValueCollection<int, AIThink.EnchantThink.SurroundingInfo>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x337DCB0 Offset: 0x337DDB1 VA: 0x337DCB0
	|-Dictionary.ValueCollection<Int32Enum, bool>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x337E6C0 Offset: 0x337E7C1 VA: 0x337E6C0
	|-Dictionary.ValueCollection<Int32Enum, int>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x337F0D0 Offset: 0x337F1D1 VA: 0x337F0D0
	|-Dictionary.ValueCollection<Int32Enum, Int32Enum>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x337FB00 Offset: 0x337FC01 VA: 0x337FB00
	|-Dictionary.ValueCollection<Int32Enum, object>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x33804F0 Offset: 0x33805F1 VA: 0x33804F0
	|-Dictionary.ValueCollection<long, object>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x3380EC0 Offset: 0x3380FC1 VA: 0x3380EC0
	|-Dictionary.ValueCollection<MapPos, int>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x3381920 Offset: 0x3381A21 VA: 0x3381920
	|-Dictionary.ValueCollection<object, AsyncOperationHandle<object>>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x33823E0 Offset: 0x33824E1 VA: 0x33823E0
	|-Dictionary.ValueCollection<object, AsyncOperationHandle>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x3382E50 Offset: 0x3382F51 VA: 0x3382E50
	|-Dictionary.ValueCollection<object, bool>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x3383860 Offset: 0x3383961 VA: 0x3383860
	|-Dictionary.ValueCollection<object, byte>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x3384270 Offset: 0x3384371 VA: 0x3384270
	|-Dictionary.ValueCollection<object, int>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x3384C80 Offset: 0x3384D81 VA: 0x3384C80
	|-Dictionary.ValueCollection<object, Int32Enum>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x3385690 Offset: 0x3385791 VA: 0x3385690
	|-Dictionary.ValueCollection<object, IntPtr>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x33860C0 Offset: 0x33861C1 VA: 0x33860C0
	|-Dictionary.ValueCollection<object, object>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x33874E0 Offset: 0x33875E1 VA: 0x33874E0
	|-Dictionary.ValueCollection<object, Playable>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x3387F10 Offset: 0x3388011 VA: 0x3387F10
	|-Dictionary.ValueCollection<object, ResourceLocator>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x3388920 Offset: 0x3388A21 VA: 0x3388920
	|-Dictionary.ValueCollection<object, float>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x3389330 Offset: 0x3389431 VA: 0x3389330
	|-Dictionary.ValueCollection<object, ushort>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x3389D60 Offset: 0x3389E61 VA: 0x3389D60
	|-Dictionary.ValueCollection<object, GameVariable.Value>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x338A7B0 Offset: 0x338A8B1 VA: 0x338A7B0
	|-Dictionary.ValueCollection<sbyte, DataStoreRatingInfo>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x338B240 Offset: 0x338B341 VA: 0x338B240
	|-Dictionary.ValueCollection<sbyte, object>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x338BC10 Offset: 0x338BD11 VA: 0x338BC10
	|-Dictionary.ValueCollection<ushort, int>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x338C620 Offset: 0x338C721 VA: 0x338C620
	|-Dictionary.ValueCollection<uint, int>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x338D050 Offset: 0x338D151 VA: 0x338D050
	|-Dictionary.ValueCollection<uint, object>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x338DA80 Offset: 0x338DB81 VA: 0x338DA80
	|-Dictionary.ValueCollection<ulong, Friend>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x338E540 Offset: 0x338E641 VA: 0x338E540
	|-Dictionary.ValueCollection<ulong, Int32Enum>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x338EF70 Offset: 0x338F071 VA: 0x338EF70
	|-Dictionary.ValueCollection<ulong, object>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x338F940 Offset: 0x338FA41 VA: 0x338F940
	|-Dictionary.ValueCollection<Vector3, int>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x3390370 Offset: 0x3390471 VA: 0x3390370
	|-Dictionary.ValueCollection<XPathNodeRef, XPathNodeRef>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x3390DA0 Offset: 0x3390EA1 VA: 0x3390DA0
	|-Dictionary.ValueCollection<TerrainUtility.TerrainMap.TileCoord, object>.System.Collections.Generic.ICollection<TValue>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private void System.Collections.Generic.ICollection<TValue>.Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DFA090 Offset: 0x2DFA191 VA: 0x2DFA090
	|-Dictionary.ValueCollection<ValueTuple<object, int>, object>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x2DFAA80 Offset: 0x2DFAB81 VA: 0x2DFAA80
	|-Dictionary.ValueCollection<byte, object>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x2DFB470 Offset: 0x2DFB571 VA: 0x2DFB470
	|-Dictionary.ValueCollection<CancellationToken, object>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x2DFBE60 Offset: 0x2DFBF61 VA: 0x2DFBE60
	|-Dictionary.ValueCollection<char, object>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x2DFC850 Offset: 0x2DFC951 VA: 0x2DFC850
	|-Dictionary.ValueCollection<Guid, object>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x2DFD220 Offset: 0x2DFD321 VA: 0x2DFD220
	|-Dictionary.ValueCollection<int, bool>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x2DFE670 Offset: 0x2DFE771 VA: 0x2DFE670
	|-Dictionary.ValueCollection<int, byte>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x2DFF080 Offset: 0x2DFF181 VA: 0x2DFF080
	|-Dictionary.ValueCollection<int, char>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x2DFFB00 Offset: 0x2DFFC01 VA: 0x2DFFB00
	|-Dictionary.ValueCollection<int, DiagnosticEvent>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x2E005A0 Offset: 0x2E006A1 VA: 0x2E005A0
	|-Dictionary.ValueCollection<int, int>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x2E019F0 Offset: 0x2E01AF1 VA: 0x2E019F0
	|-Dictionary.ValueCollection<int, Int32Enum>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x2E02400 Offset: 0x2E02501 VA: 0x2E02400
	|-Dictionary.ValueCollection<int, long>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x337B4F0 Offset: 0x337B5F1 VA: 0x337B4F0
	|-Dictionary.ValueCollection<int, MapPos>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x337BF20 Offset: 0x337C021 VA: 0x337BF20
	|-Dictionary.ValueCollection<int, object>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x337C8F0 Offset: 0x337C9F1 VA: 0x337C8F0
	|-Dictionary.ValueCollection<int, uint>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x337D300 Offset: 0x337D401 VA: 0x337D300
	|-Dictionary.ValueCollection<int, AIThink.EnchantThink.SurroundingInfo>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x337DD10 Offset: 0x337DE11 VA: 0x337DD10
	|-Dictionary.ValueCollection<Int32Enum, bool>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x337E720 Offset: 0x337E821 VA: 0x337E720
	|-Dictionary.ValueCollection<Int32Enum, int>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x337F130 Offset: 0x337F231 VA: 0x337F130
	|-Dictionary.ValueCollection<Int32Enum, Int32Enum>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x337FB60 Offset: 0x337FC61 VA: 0x337FB60
	|-Dictionary.ValueCollection<Int32Enum, object>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x3380550 Offset: 0x3380651 VA: 0x3380550
	|-Dictionary.ValueCollection<long, object>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x3380F20 Offset: 0x3381021 VA: 0x3380F20
	|-Dictionary.ValueCollection<MapPos, int>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x3381980 Offset: 0x3381A81 VA: 0x3381980
	|-Dictionary.ValueCollection<object, AsyncOperationHandle<object>>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x3382440 Offset: 0x3382541 VA: 0x3382440
	|-Dictionary.ValueCollection<object, AsyncOperationHandle>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x3382EB0 Offset: 0x3382FB1 VA: 0x3382EB0
	|-Dictionary.ValueCollection<object, bool>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x33838C0 Offset: 0x33839C1 VA: 0x33838C0
	|-Dictionary.ValueCollection<object, byte>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x33842D0 Offset: 0x33843D1 VA: 0x33842D0
	|-Dictionary.ValueCollection<object, int>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x3384CE0 Offset: 0x3384DE1 VA: 0x3384CE0
	|-Dictionary.ValueCollection<object, Int32Enum>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x33856F0 Offset: 0x33857F1 VA: 0x33856F0
	|-Dictionary.ValueCollection<object, IntPtr>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x3386120 Offset: 0x3386221 VA: 0x3386120
	|-Dictionary.ValueCollection<object, object>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x3387540 Offset: 0x3387641 VA: 0x3387540
	|-Dictionary.ValueCollection<object, Playable>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x3387F70 Offset: 0x3388071 VA: 0x3387F70
	|-Dictionary.ValueCollection<object, ResourceLocator>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x3388980 Offset: 0x3388A81 VA: 0x3388980
	|-Dictionary.ValueCollection<object, float>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x3389390 Offset: 0x3389491 VA: 0x3389390
	|-Dictionary.ValueCollection<object, ushort>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x3389DC0 Offset: 0x3389EC1 VA: 0x3389DC0
	|-Dictionary.ValueCollection<object, GameVariable.Value>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x338A810 Offset: 0x338A911 VA: 0x338A810
	|-Dictionary.ValueCollection<sbyte, DataStoreRatingInfo>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x338B2A0 Offset: 0x338B3A1 VA: 0x338B2A0
	|-Dictionary.ValueCollection<sbyte, object>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x338BC70 Offset: 0x338BD71 VA: 0x338BC70
	|-Dictionary.ValueCollection<ushort, int>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x338C680 Offset: 0x338C781 VA: 0x338C680
	|-Dictionary.ValueCollection<uint, int>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x338D0B0 Offset: 0x338D1B1 VA: 0x338D0B0
	|-Dictionary.ValueCollection<uint, object>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x338DAE0 Offset: 0x338DBE1 VA: 0x338DAE0
	|-Dictionary.ValueCollection<ulong, Friend>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x338E5A0 Offset: 0x338E6A1 VA: 0x338E5A0
	|-Dictionary.ValueCollection<ulong, Int32Enum>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x338EFD0 Offset: 0x338F0D1 VA: 0x338EFD0
	|-Dictionary.ValueCollection<ulong, object>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x338F9A0 Offset: 0x338FAA1 VA: 0x338F9A0
	|-Dictionary.ValueCollection<Vector3, int>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x33903D0 Offset: 0x33904D1 VA: 0x33903D0
	|-Dictionary.ValueCollection<XPathNodeRef, XPathNodeRef>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x3390E00 Offset: 0x3390F01 VA: 0x3390E00
	|-Dictionary.ValueCollection<TerrainUtility.TerrainMap.TileCoord, object>.System.Collections.Generic.ICollection<TValue>.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private bool System.Collections.Generic.ICollection<TValue>.Contains(TValue item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DFA0F0 Offset: 0x2DFA1F1 VA: 0x2DFA0F0
	|-Dictionary.ValueCollection<ValueTuple<object, int>, object>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x2DFAAE0 Offset: 0x2DFABE1 VA: 0x2DFAAE0
	|-Dictionary.ValueCollection<byte, object>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x2DFB4D0 Offset: 0x2DFB5D1 VA: 0x2DFB4D0
	|-Dictionary.ValueCollection<CancellationToken, object>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x2DFBEC0 Offset: 0x2DFBFC1 VA: 0x2DFBEC0
	|-Dictionary.ValueCollection<char, object>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x2DFC8B0 Offset: 0x2DFC9B1 VA: 0x2DFC8B0
	|-Dictionary.ValueCollection<Guid, object>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x2DFD280 Offset: 0x2DFD381 VA: 0x2DFD280
	|-Dictionary.ValueCollection<int, bool>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x2DFE6D0 Offset: 0x2DFE7D1 VA: 0x2DFE6D0
	|-Dictionary.ValueCollection<int, byte>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x2DFF0E0 Offset: 0x2DFF1E1 VA: 0x2DFF0E0
	|-Dictionary.ValueCollection<int, char>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x2DFFB60 Offset: 0x2DFFC61 VA: 0x2DFFB60
	|-Dictionary.ValueCollection<int, DiagnosticEvent>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x2E00600 Offset: 0x2E00701 VA: 0x2E00600
	|-Dictionary.ValueCollection<int, int>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x2E01A50 Offset: 0x2E01B51 VA: 0x2E01A50
	|-Dictionary.ValueCollection<int, Int32Enum>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x2E02460 Offset: 0x2E02561 VA: 0x2E02460
	|-Dictionary.ValueCollection<int, long>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x337B550 Offset: 0x337B651 VA: 0x337B550
	|-Dictionary.ValueCollection<int, MapPos>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x337BF80 Offset: 0x337C081 VA: 0x337BF80
	|-Dictionary.ValueCollection<int, object>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x337C950 Offset: 0x337CA51 VA: 0x337C950
	|-Dictionary.ValueCollection<int, uint>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x337D360 Offset: 0x337D461 VA: 0x337D360
	|-Dictionary.ValueCollection<int, AIThink.EnchantThink.SurroundingInfo>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x337DD70 Offset: 0x337DE71 VA: 0x337DD70
	|-Dictionary.ValueCollection<Int32Enum, bool>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x337E780 Offset: 0x337E881 VA: 0x337E780
	|-Dictionary.ValueCollection<Int32Enum, int>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x337F190 Offset: 0x337F291 VA: 0x337F190
	|-Dictionary.ValueCollection<Int32Enum, Int32Enum>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x337FBC0 Offset: 0x337FCC1 VA: 0x337FBC0
	|-Dictionary.ValueCollection<Int32Enum, object>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x33805B0 Offset: 0x33806B1 VA: 0x33805B0
	|-Dictionary.ValueCollection<long, object>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x3380F80 Offset: 0x3381081 VA: 0x3380F80
	|-Dictionary.ValueCollection<MapPos, int>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x33819E0 Offset: 0x3381AE1 VA: 0x33819E0
	|-Dictionary.ValueCollection<object, AsyncOperationHandle<object>>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x33824A0 Offset: 0x33825A1 VA: 0x33824A0
	|-Dictionary.ValueCollection<object, AsyncOperationHandle>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x3382F10 Offset: 0x3383011 VA: 0x3382F10
	|-Dictionary.ValueCollection<object, bool>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x3383920 Offset: 0x3383A21 VA: 0x3383920
	|-Dictionary.ValueCollection<object, byte>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x3384330 Offset: 0x3384431 VA: 0x3384330
	|-Dictionary.ValueCollection<object, int>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x3384D40 Offset: 0x3384E41 VA: 0x3384D40
	|-Dictionary.ValueCollection<object, Int32Enum>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x3385750 Offset: 0x3385851 VA: 0x3385750
	|-Dictionary.ValueCollection<object, IntPtr>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x3386180 Offset: 0x3386281 VA: 0x3386180
	|-Dictionary.ValueCollection<object, object>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x33875A0 Offset: 0x33876A1 VA: 0x33875A0
	|-Dictionary.ValueCollection<object, Playable>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x3387FD0 Offset: 0x33880D1 VA: 0x3387FD0
	|-Dictionary.ValueCollection<object, ResourceLocator>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x33889E0 Offset: 0x3388AE1 VA: 0x33889E0
	|-Dictionary.ValueCollection<object, float>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x33893F0 Offset: 0x33894F1 VA: 0x33893F0
	|-Dictionary.ValueCollection<object, ushort>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x3389E20 Offset: 0x3389F21 VA: 0x3389E20
	|-Dictionary.ValueCollection<object, GameVariable.Value>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x338A870 Offset: 0x338A971 VA: 0x338A870
	|-Dictionary.ValueCollection<sbyte, DataStoreRatingInfo>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x338B300 Offset: 0x338B401 VA: 0x338B300
	|-Dictionary.ValueCollection<sbyte, object>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x338BCD0 Offset: 0x338BDD1 VA: 0x338BCD0
	|-Dictionary.ValueCollection<ushort, int>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x338C6E0 Offset: 0x338C7E1 VA: 0x338C6E0
	|-Dictionary.ValueCollection<uint, int>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x338D110 Offset: 0x338D211 VA: 0x338D110
	|-Dictionary.ValueCollection<uint, object>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x338DB40 Offset: 0x338DC41 VA: 0x338DB40
	|-Dictionary.ValueCollection<ulong, Friend>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x338E600 Offset: 0x338E701 VA: 0x338E600
	|-Dictionary.ValueCollection<ulong, Int32Enum>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x338F030 Offset: 0x338F131 VA: 0x338F030
	|-Dictionary.ValueCollection<ulong, object>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x338FA00 Offset: 0x338FB01 VA: 0x338FA00
	|-Dictionary.ValueCollection<Vector3, int>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x3390430 Offset: 0x3390531 VA: 0x3390430
	|-Dictionary.ValueCollection<XPathNodeRef, XPathNodeRef>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x3390E60 Offset: 0x3390F61 VA: 0x3390E60
	|-Dictionary.ValueCollection<TerrainUtility.TerrainMap.TileCoord, object>.System.Collections.Generic.ICollection<TValue>.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 11
	private IEnumerator<TValue> System.Collections.Generic.IEnumerable<TValue>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DFA110 Offset: 0x2DFA211 VA: 0x2DFA110
	|-Dictionary.ValueCollection<ValueTuple<object, int>, object>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x2DFAB00 Offset: 0x2DFAC01 VA: 0x2DFAB00
	|-Dictionary.ValueCollection<byte, object>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x2DFB4F0 Offset: 0x2DFB5F1 VA: 0x2DFB4F0
	|-Dictionary.ValueCollection<CancellationToken, object>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x2DFBEE0 Offset: 0x2DFBFE1 VA: 0x2DFBEE0
	|-Dictionary.ValueCollection<char, object>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x2DFC8D0 Offset: 0x2DFC9D1 VA: 0x2DFC8D0
	|-Dictionary.ValueCollection<Guid, object>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x2DFD2A0 Offset: 0x2DFD3A1 VA: 0x2DFD2A0
	|-Dictionary.ValueCollection<int, bool>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x2DFE6F0 Offset: 0x2DFE7F1 VA: 0x2DFE6F0
	|-Dictionary.ValueCollection<int, byte>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x2DFF100 Offset: 0x2DFF201 VA: 0x2DFF100
	|-Dictionary.ValueCollection<int, char>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x2DFFBC0 Offset: 0x2DFFCC1 VA: 0x2DFFBC0
	|-Dictionary.ValueCollection<int, DiagnosticEvent>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x2E00620 Offset: 0x2E00721 VA: 0x2E00620
	|-Dictionary.ValueCollection<int, int>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x2E01A70 Offset: 0x2E01B71 VA: 0x2E01A70
	|-Dictionary.ValueCollection<int, Int32Enum>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x2E02480 Offset: 0x2E02581 VA: 0x2E02480
	|-Dictionary.ValueCollection<int, long>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x337B570 Offset: 0x337B671 VA: 0x337B570
	|-Dictionary.ValueCollection<int, MapPos>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x337BFA0 Offset: 0x337C0A1 VA: 0x337BFA0
	|-Dictionary.ValueCollection<int, object>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x337C970 Offset: 0x337CA71 VA: 0x337C970
	|-Dictionary.ValueCollection<int, uint>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x337D380 Offset: 0x337D481 VA: 0x337D380
	|-Dictionary.ValueCollection<int, AIThink.EnchantThink.SurroundingInfo>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x337DD90 Offset: 0x337DE91 VA: 0x337DD90
	|-Dictionary.ValueCollection<Int32Enum, bool>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x337E7A0 Offset: 0x337E8A1 VA: 0x337E7A0
	|-Dictionary.ValueCollection<Int32Enum, int>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x337F1B0 Offset: 0x337F2B1 VA: 0x337F1B0
	|-Dictionary.ValueCollection<Int32Enum, Int32Enum>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x337FBE0 Offset: 0x337FCE1 VA: 0x337FBE0
	|-Dictionary.ValueCollection<Int32Enum, object>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x33805D0 Offset: 0x33806D1 VA: 0x33805D0
	|-Dictionary.ValueCollection<long, object>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x3380FA0 Offset: 0x33810A1 VA: 0x3380FA0
	|-Dictionary.ValueCollection<MapPos, int>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x3381A30 Offset: 0x3381B31 VA: 0x3381A30
	|-Dictionary.ValueCollection<object, AsyncOperationHandle<object>>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x33824F0 Offset: 0x33825F1 VA: 0x33824F0
	|-Dictionary.ValueCollection<object, AsyncOperationHandle>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x3382F30 Offset: 0x3383031 VA: 0x3382F30
	|-Dictionary.ValueCollection<object, bool>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x3383940 Offset: 0x3383A41 VA: 0x3383940
	|-Dictionary.ValueCollection<object, byte>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x3384350 Offset: 0x3384451 VA: 0x3384350
	|-Dictionary.ValueCollection<object, int>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x3384D60 Offset: 0x3384E61 VA: 0x3384D60
	|-Dictionary.ValueCollection<object, Int32Enum>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x3385770 Offset: 0x3385871 VA: 0x3385770
	|-Dictionary.ValueCollection<object, IntPtr>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x33861A0 Offset: 0x33862A1 VA: 0x33861A0
	|-Dictionary.ValueCollection<object, object>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x33875C0 Offset: 0x33876C1 VA: 0x33875C0
	|-Dictionary.ValueCollection<object, Playable>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x3387FF0 Offset: 0x33880F1 VA: 0x3387FF0
	|-Dictionary.ValueCollection<object, ResourceLocator>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x3388A00 Offset: 0x3388B01 VA: 0x3388A00
	|-Dictionary.ValueCollection<object, float>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x3389410 Offset: 0x3389511 VA: 0x3389410
	|-Dictionary.ValueCollection<object, ushort>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x3389E40 Offset: 0x3389F41 VA: 0x3389E40
	|-Dictionary.ValueCollection<object, GameVariable.Value>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x338A8C0 Offset: 0x338A9C1 VA: 0x338A8C0
	|-Dictionary.ValueCollection<sbyte, DataStoreRatingInfo>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x338B320 Offset: 0x338B421 VA: 0x338B320
	|-Dictionary.ValueCollection<sbyte, object>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x338BCF0 Offset: 0x338BDF1 VA: 0x338BCF0
	|-Dictionary.ValueCollection<ushort, int>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x338C700 Offset: 0x338C801 VA: 0x338C700
	|-Dictionary.ValueCollection<uint, int>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x338D130 Offset: 0x338D231 VA: 0x338D130
	|-Dictionary.ValueCollection<uint, object>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x338DBC0 Offset: 0x338DCC1 VA: 0x338DBC0
	|-Dictionary.ValueCollection<ulong, Friend>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x338E620 Offset: 0x338E721 VA: 0x338E620
	|-Dictionary.ValueCollection<ulong, Int32Enum>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x338F050 Offset: 0x338F151 VA: 0x338F050
	|-Dictionary.ValueCollection<ulong, object>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x338FA20 Offset: 0x338FB21 VA: 0x338FA20
	|-Dictionary.ValueCollection<Vector3, int>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x3390450 Offset: 0x3390551 VA: 0x3390450
	|-Dictionary.ValueCollection<XPathNodeRef, XPathNodeRef>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x3390E80 Offset: 0x3390F81 VA: 0x3390E80
	|-Dictionary.ValueCollection<TerrainUtility.TerrainMap.TileCoord, object>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 12
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DFA190 Offset: 0x2DFA291 VA: 0x2DFA190
	|-Dictionary.ValueCollection<ValueTuple<object, int>, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2DFAB80 Offset: 0x2DFAC81 VA: 0x2DFAB80
	|-Dictionary.ValueCollection<byte, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2DFB570 Offset: 0x2DFB671 VA: 0x2DFB570
	|-Dictionary.ValueCollection<CancellationToken, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2DFBF60 Offset: 0x2DFC061 VA: 0x2DFBF60
	|-Dictionary.ValueCollection<char, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2DFC950 Offset: 0x2DFCA51 VA: 0x2DFC950
	|-Dictionary.ValueCollection<Guid, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2DFD320 Offset: 0x2DFD421 VA: 0x2DFD320
	|-Dictionary.ValueCollection<int, bool>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2DFE770 Offset: 0x2DFE871 VA: 0x2DFE770
	|-Dictionary.ValueCollection<int, byte>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2DFF180 Offset: 0x2DFF281 VA: 0x2DFF180
	|-Dictionary.ValueCollection<int, char>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2DFFC60 Offset: 0x2DFFD61 VA: 0x2DFFC60
	|-Dictionary.ValueCollection<int, DiagnosticEvent>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2E006A0 Offset: 0x2E007A1 VA: 0x2E006A0
	|-Dictionary.ValueCollection<int, int>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2E01AF0 Offset: 0x2E01BF1 VA: 0x2E01AF0
	|-Dictionary.ValueCollection<int, Int32Enum>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2E02500 Offset: 0x2E02601 VA: 0x2E02500
	|-Dictionary.ValueCollection<int, long>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x337B5F0 Offset: 0x337B6F1 VA: 0x337B5F0
	|-Dictionary.ValueCollection<int, MapPos>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x337C020 Offset: 0x337C121 VA: 0x337C020
	|-Dictionary.ValueCollection<int, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x337C9F0 Offset: 0x337CAF1 VA: 0x337C9F0
	|-Dictionary.ValueCollection<int, uint>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x337D400 Offset: 0x337D501 VA: 0x337D400
	|-Dictionary.ValueCollection<int, AIThink.EnchantThink.SurroundingInfo>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x337DE10 Offset: 0x337DF11 VA: 0x337DE10
	|-Dictionary.ValueCollection<Int32Enum, bool>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x337E820 Offset: 0x337E921 VA: 0x337E820
	|-Dictionary.ValueCollection<Int32Enum, int>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x337F230 Offset: 0x337F331 VA: 0x337F230
	|-Dictionary.ValueCollection<Int32Enum, Int32Enum>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x337FC60 Offset: 0x337FD61 VA: 0x337FC60
	|-Dictionary.ValueCollection<Int32Enum, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3380650 Offset: 0x3380751 VA: 0x3380650
	|-Dictionary.ValueCollection<long, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3381020 Offset: 0x3381121 VA: 0x3381020
	|-Dictionary.ValueCollection<MapPos, int>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3381AC0 Offset: 0x3381BC1 VA: 0x3381AC0
	|-Dictionary.ValueCollection<object, AsyncOperationHandle<object>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3382580 Offset: 0x3382681 VA: 0x3382580
	|-Dictionary.ValueCollection<object, AsyncOperationHandle>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3382FB0 Offset: 0x33830B1 VA: 0x3382FB0
	|-Dictionary.ValueCollection<object, bool>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x33839C0 Offset: 0x3383AC1 VA: 0x33839C0
	|-Dictionary.ValueCollection<object, byte>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x33843D0 Offset: 0x33844D1 VA: 0x33843D0
	|-Dictionary.ValueCollection<object, int>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3384DE0 Offset: 0x3384EE1 VA: 0x3384DE0
	|-Dictionary.ValueCollection<object, Int32Enum>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x33857F0 Offset: 0x33858F1 VA: 0x33857F0
	|-Dictionary.ValueCollection<object, IntPtr>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3386220 Offset: 0x3386321 VA: 0x3386220
	|-Dictionary.ValueCollection<object, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3387640 Offset: 0x3387741 VA: 0x3387640
	|-Dictionary.ValueCollection<object, Playable>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3388070 Offset: 0x3388171 VA: 0x3388070
	|-Dictionary.ValueCollection<object, ResourceLocator>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3388A80 Offset: 0x3388B81 VA: 0x3388A80
	|-Dictionary.ValueCollection<object, float>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3389490 Offset: 0x3389591 VA: 0x3389490
	|-Dictionary.ValueCollection<object, ushort>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3389EC0 Offset: 0x3389FC1 VA: 0x3389EC0
	|-Dictionary.ValueCollection<object, GameVariable.Value>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x338A950 Offset: 0x338AA51 VA: 0x338A950
	|-Dictionary.ValueCollection<sbyte, DataStoreRatingInfo>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x338B3A0 Offset: 0x338B4A1 VA: 0x338B3A0
	|-Dictionary.ValueCollection<sbyte, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x338BD70 Offset: 0x338BE71 VA: 0x338BD70
	|-Dictionary.ValueCollection<ushort, int>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x338C780 Offset: 0x338C881 VA: 0x338C780
	|-Dictionary.ValueCollection<uint, int>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x338D1B0 Offset: 0x338D2B1 VA: 0x338D1B0
	|-Dictionary.ValueCollection<uint, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x338DC60 Offset: 0x338DD61 VA: 0x338DC60
	|-Dictionary.ValueCollection<ulong, Friend>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x338E6A0 Offset: 0x338E7A1 VA: 0x338E6A0
	|-Dictionary.ValueCollection<ulong, Int32Enum>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x338F0D0 Offset: 0x338F1D1 VA: 0x338F0D0
	|-Dictionary.ValueCollection<ulong, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x338FAA0 Offset: 0x338FBA1 VA: 0x338FAA0
	|-Dictionary.ValueCollection<Vector3, int>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x33904D0 Offset: 0x33905D1 VA: 0x33904D0
	|-Dictionary.ValueCollection<XPathNodeRef, XPathNodeRef>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3390F00 Offset: 0x3391001 VA: 0x3390F00
	|-Dictionary.ValueCollection<TerrainUtility.TerrainMap.TileCoord, object>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 13
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DFA210 Offset: 0x2DFA311 VA: 0x2DFA210
	|-Dictionary.ValueCollection<ValueTuple<object, int>, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2DFAC00 Offset: 0x2DFAD01 VA: 0x2DFAC00
	|-Dictionary.ValueCollection<byte, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2DFB5F0 Offset: 0x2DFB6F1 VA: 0x2DFB5F0
	|-Dictionary.ValueCollection<CancellationToken, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2DFBFE0 Offset: 0x2DFC0E1 VA: 0x2DFBFE0
	|-Dictionary.ValueCollection<char, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2DFC9D0 Offset: 0x2DFCAD1 VA: 0x2DFC9D0
	|-Dictionary.ValueCollection<Guid, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2DFD3A0 Offset: 0x2DFD4A1 VA: 0x2DFD3A0
	|-Dictionary.ValueCollection<int, bool>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2DFE7F0 Offset: 0x2DFE8F1 VA: 0x2DFE7F0
	|-Dictionary.ValueCollection<int, byte>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2DFF200 Offset: 0x2DFF301 VA: 0x2DFF200
	|-Dictionary.ValueCollection<int, char>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2DFFD00 Offset: 0x2DFFE01 VA: 0x2DFFD00
	|-Dictionary.ValueCollection<int, DiagnosticEvent>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2E00720 Offset: 0x2E00821 VA: 0x2E00720
	|-Dictionary.ValueCollection<int, int>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2E01B70 Offset: 0x2E01C71 VA: 0x2E01B70
	|-Dictionary.ValueCollection<int, Int32Enum>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2E02580 Offset: 0x2E02681 VA: 0x2E02580
	|-Dictionary.ValueCollection<int, long>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x337B670 Offset: 0x337B771 VA: 0x337B670
	|-Dictionary.ValueCollection<int, MapPos>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x337C0A0 Offset: 0x337C1A1 VA: 0x337C0A0
	|-Dictionary.ValueCollection<int, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x337CA70 Offset: 0x337CB71 VA: 0x337CA70
	|-Dictionary.ValueCollection<int, uint>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x337D480 Offset: 0x337D581 VA: 0x337D480
	|-Dictionary.ValueCollection<int, AIThink.EnchantThink.SurroundingInfo>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x337DE90 Offset: 0x337DF91 VA: 0x337DE90
	|-Dictionary.ValueCollection<Int32Enum, bool>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x337E8A0 Offset: 0x337E9A1 VA: 0x337E8A0
	|-Dictionary.ValueCollection<Int32Enum, int>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x337F2B0 Offset: 0x337F3B1 VA: 0x337F2B0
	|-Dictionary.ValueCollection<Int32Enum, Int32Enum>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x337FCE0 Offset: 0x337FDE1 VA: 0x337FCE0
	|-Dictionary.ValueCollection<Int32Enum, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x33806D0 Offset: 0x33807D1 VA: 0x33806D0
	|-Dictionary.ValueCollection<long, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x33810A0 Offset: 0x33811A1 VA: 0x33810A0
	|-Dictionary.ValueCollection<MapPos, int>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3381B50 Offset: 0x3381C51 VA: 0x3381B50
	|-Dictionary.ValueCollection<object, AsyncOperationHandle<object>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3382610 Offset: 0x3382711 VA: 0x3382610
	|-Dictionary.ValueCollection<object, AsyncOperationHandle>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3383030 Offset: 0x3383131 VA: 0x3383030
	|-Dictionary.ValueCollection<object, bool>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3383A40 Offset: 0x3383B41 VA: 0x3383A40
	|-Dictionary.ValueCollection<object, byte>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3384450 Offset: 0x3384551 VA: 0x3384450
	|-Dictionary.ValueCollection<object, int>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3384E60 Offset: 0x3384F61 VA: 0x3384E60
	|-Dictionary.ValueCollection<object, Int32Enum>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3385870 Offset: 0x3385971 VA: 0x3385870
	|-Dictionary.ValueCollection<object, IntPtr>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x33862A0 Offset: 0x33863A1 VA: 0x33862A0
	|-Dictionary.ValueCollection<object, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x33876C0 Offset: 0x33877C1 VA: 0x33876C0
	|-Dictionary.ValueCollection<object, Playable>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x33880F0 Offset: 0x33881F1 VA: 0x33880F0
	|-Dictionary.ValueCollection<object, ResourceLocator>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3388B00 Offset: 0x3388C01 VA: 0x3388B00
	|-Dictionary.ValueCollection<object, float>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3389510 Offset: 0x3389611 VA: 0x3389510
	|-Dictionary.ValueCollection<object, ushort>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3389F40 Offset: 0x338A041 VA: 0x3389F40
	|-Dictionary.ValueCollection<object, GameVariable.Value>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x338A9E0 Offset: 0x338AAE1 VA: 0x338A9E0
	|-Dictionary.ValueCollection<sbyte, DataStoreRatingInfo>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x338B420 Offset: 0x338B521 VA: 0x338B420
	|-Dictionary.ValueCollection<sbyte, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x338BDF0 Offset: 0x338BEF1 VA: 0x338BDF0
	|-Dictionary.ValueCollection<ushort, int>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x338C800 Offset: 0x338C901 VA: 0x338C800
	|-Dictionary.ValueCollection<uint, int>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x338D230 Offset: 0x338D331 VA: 0x338D230
	|-Dictionary.ValueCollection<uint, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x338DD00 Offset: 0x338DE01 VA: 0x338DD00
	|-Dictionary.ValueCollection<ulong, Friend>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x338E720 Offset: 0x338E821 VA: 0x338E720
	|-Dictionary.ValueCollection<ulong, Int32Enum>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x338F150 Offset: 0x338F251 VA: 0x338F150
	|-Dictionary.ValueCollection<ulong, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x338FB20 Offset: 0x338FC21 VA: 0x338FB20
	|-Dictionary.ValueCollection<Vector3, int>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3390550 Offset: 0x3390651 VA: 0x3390550
	|-Dictionary.ValueCollection<XPathNodeRef, XPathNodeRef>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3390F80 Offset: 0x3391081 VA: 0x3390F80
	|-Dictionary.ValueCollection<TerrainUtility.TerrainMap.TileCoord, object>.System.Collections.ICollection.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 16
	private bool System.Collections.ICollection.get_IsSynchronized() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DFA600 Offset: 0x2DFA701 VA: 0x2DFA600
	|-Dictionary.ValueCollection<ValueTuple<object, int>, object>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2DFAFF0 Offset: 0x2DFB0F1 VA: 0x2DFAFF0
	|-Dictionary.ValueCollection<byte, object>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2DFB9E0 Offset: 0x2DFBAE1 VA: 0x2DFB9E0
	|-Dictionary.ValueCollection<CancellationToken, object>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2DFC3D0 Offset: 0x2DFC4D1 VA: 0x2DFC3D0
	|-Dictionary.ValueCollection<char, object>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2DFCDC0 Offset: 0x2DFCEC1 VA: 0x2DFCDC0
	|-Dictionary.ValueCollection<Guid, object>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2DFD7D0 Offset: 0x2DFD8D1 VA: 0x2DFD7D0
	|-Dictionary.ValueCollection<int, bool>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2DFEC20 Offset: 0x2DFED21 VA: 0x2DFEC20
	|-Dictionary.ValueCollection<int, byte>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2DFF630 Offset: 0x2DFF731 VA: 0x2DFF630
	|-Dictionary.ValueCollection<int, char>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2E00140 Offset: 0x2E00241 VA: 0x2E00140
	|-Dictionary.ValueCollection<int, DiagnosticEvent>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2E00B50 Offset: 0x2E00C51 VA: 0x2E00B50
	|-Dictionary.ValueCollection<int, int>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2E01FA0 Offset: 0x2E020A1 VA: 0x2E01FA0
	|-Dictionary.ValueCollection<int, Int32Enum>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2E029B0 Offset: 0x2E02AB1 VA: 0x2E029B0
	|-Dictionary.ValueCollection<int, long>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x337BAA0 Offset: 0x337BBA1 VA: 0x337BAA0
	|-Dictionary.ValueCollection<int, MapPos>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x337C490 Offset: 0x337C591 VA: 0x337C490
	|-Dictionary.ValueCollection<int, object>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x337CEA0 Offset: 0x337CFA1 VA: 0x337CEA0
	|-Dictionary.ValueCollection<int, uint>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x337D8B0 Offset: 0x337D9B1 VA: 0x337D8B0
	|-Dictionary.ValueCollection<int, AIThink.EnchantThink.SurroundingInfo>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x337E2C0 Offset: 0x337E3C1 VA: 0x337E2C0
	|-Dictionary.ValueCollection<Int32Enum, bool>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x337ECD0 Offset: 0x337EDD1 VA: 0x337ECD0
	|-Dictionary.ValueCollection<Int32Enum, int>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x337F6E0 Offset: 0x337F7E1 VA: 0x337F6E0
	|-Dictionary.ValueCollection<Int32Enum, Int32Enum>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x33800D0 Offset: 0x33801D1 VA: 0x33800D0
	|-Dictionary.ValueCollection<Int32Enum, object>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3380AC0 Offset: 0x3380BC1 VA: 0x3380AC0
	|-Dictionary.ValueCollection<long, object>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x33814D0 Offset: 0x33815D1 VA: 0x33814D0
	|-Dictionary.ValueCollection<MapPos, int>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3381F90 Offset: 0x3382091 VA: 0x3381F90
	|-Dictionary.ValueCollection<object, AsyncOperationHandle<object>>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3382A50 Offset: 0x3382B51 VA: 0x3382A50
	|-Dictionary.ValueCollection<object, AsyncOperationHandle>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3383460 Offset: 0x3383561 VA: 0x3383460
	|-Dictionary.ValueCollection<object, bool>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3383E70 Offset: 0x3383F71 VA: 0x3383E70
	|-Dictionary.ValueCollection<object, byte>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3384880 Offset: 0x3384981 VA: 0x3384880
	|-Dictionary.ValueCollection<object, int>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3385290 Offset: 0x3385391 VA: 0x3385290
	|-Dictionary.ValueCollection<object, Int32Enum>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3385CA0 Offset: 0x3385DA1 VA: 0x3385CA0
	|-Dictionary.ValueCollection<object, IntPtr>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3386690 Offset: 0x3386791 VA: 0x3386690
	|-Dictionary.ValueCollection<object, object>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3387AF0 Offset: 0x3387BF1 VA: 0x3387AF0
	|-Dictionary.ValueCollection<object, Playable>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3388520 Offset: 0x3388621 VA: 0x3388520
	|-Dictionary.ValueCollection<object, ResourceLocator>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3388F30 Offset: 0x3389031 VA: 0x3388F30
	|-Dictionary.ValueCollection<object, float>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3389940 Offset: 0x3389A41 VA: 0x3389940
	|-Dictionary.ValueCollection<object, ushort>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x338A370 Offset: 0x338A471 VA: 0x338A370
	|-Dictionary.ValueCollection<object, GameVariable.Value>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x338AE20 Offset: 0x338AF21 VA: 0x338AE20
	|-Dictionary.ValueCollection<sbyte, DataStoreRatingInfo>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x338B810 Offset: 0x338B911 VA: 0x338B810
	|-Dictionary.ValueCollection<sbyte, object>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x338C220 Offset: 0x338C321 VA: 0x338C220
	|-Dictionary.ValueCollection<ushort, int>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x338CC30 Offset: 0x338CD31 VA: 0x338CC30
	|-Dictionary.ValueCollection<uint, int>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x338D620 Offset: 0x338D721 VA: 0x338D620
	|-Dictionary.ValueCollection<uint, object>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x338E140 Offset: 0x338E241 VA: 0x338E140
	|-Dictionary.ValueCollection<ulong, Friend>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x338EB50 Offset: 0x338EC51 VA: 0x338EB50
	|-Dictionary.ValueCollection<ulong, Int32Enum>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x338F540 Offset: 0x338F641 VA: 0x338F540
	|-Dictionary.ValueCollection<ulong, object>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x338FF50 Offset: 0x3390051 VA: 0x338FF50
	|-Dictionary.ValueCollection<Vector3, int>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3390980 Offset: 0x3390A81 VA: 0x3390980
	|-Dictionary.ValueCollection<XPathNodeRef, XPathNodeRef>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3391370 Offset: 0x3391471 VA: 0x3391370
	|-Dictionary.ValueCollection<TerrainUtility.TerrainMap.TileCoord, object>.System.Collections.ICollection.get_IsSynchronized
	*/

	// RVA: -1 Offset: -1 Slot: 15
	private object System.Collections.ICollection.get_SyncRoot() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DFA610 Offset: 0x2DFA711 VA: 0x2DFA610
	|-Dictionary.ValueCollection<ValueTuple<object, int>, object>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2DFB000 Offset: 0x2DFB101 VA: 0x2DFB000
	|-Dictionary.ValueCollection<byte, object>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2DFB9F0 Offset: 0x2DFBAF1 VA: 0x2DFB9F0
	|-Dictionary.ValueCollection<CancellationToken, object>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2DFC3E0 Offset: 0x2DFC4E1 VA: 0x2DFC3E0
	|-Dictionary.ValueCollection<char, object>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2DFCDD0 Offset: 0x2DFCED1 VA: 0x2DFCDD0
	|-Dictionary.ValueCollection<Guid, object>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2DFD7E0 Offset: 0x2DFD8E1 VA: 0x2DFD7E0
	|-Dictionary.ValueCollection<int, bool>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2DFEC30 Offset: 0x2DFED31 VA: 0x2DFEC30
	|-Dictionary.ValueCollection<int, byte>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2DFF640 Offset: 0x2DFF741 VA: 0x2DFF640
	|-Dictionary.ValueCollection<int, char>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2E00150 Offset: 0x2E00251 VA: 0x2E00150
	|-Dictionary.ValueCollection<int, DiagnosticEvent>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2E00B60 Offset: 0x2E00C61 VA: 0x2E00B60
	|-Dictionary.ValueCollection<int, int>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2E01FB0 Offset: 0x2E020B1 VA: 0x2E01FB0
	|-Dictionary.ValueCollection<int, Int32Enum>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2E029C0 Offset: 0x2E02AC1 VA: 0x2E029C0
	|-Dictionary.ValueCollection<int, long>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x337BAB0 Offset: 0x337BBB1 VA: 0x337BAB0
	|-Dictionary.ValueCollection<int, MapPos>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x337C4A0 Offset: 0x337C5A1 VA: 0x337C4A0
	|-Dictionary.ValueCollection<int, object>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x337CEB0 Offset: 0x337CFB1 VA: 0x337CEB0
	|-Dictionary.ValueCollection<int, uint>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x337D8C0 Offset: 0x337D9C1 VA: 0x337D8C0
	|-Dictionary.ValueCollection<int, AIThink.EnchantThink.SurroundingInfo>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x337E2D0 Offset: 0x337E3D1 VA: 0x337E2D0
	|-Dictionary.ValueCollection<Int32Enum, bool>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x337ECE0 Offset: 0x337EDE1 VA: 0x337ECE0
	|-Dictionary.ValueCollection<Int32Enum, int>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x337F6F0 Offset: 0x337F7F1 VA: 0x337F6F0
	|-Dictionary.ValueCollection<Int32Enum, Int32Enum>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x33800E0 Offset: 0x33801E1 VA: 0x33800E0
	|-Dictionary.ValueCollection<Int32Enum, object>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3380AD0 Offset: 0x3380BD1 VA: 0x3380AD0
	|-Dictionary.ValueCollection<long, object>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x33814E0 Offset: 0x33815E1 VA: 0x33814E0
	|-Dictionary.ValueCollection<MapPos, int>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3381FA0 Offset: 0x33820A1 VA: 0x3381FA0
	|-Dictionary.ValueCollection<object, AsyncOperationHandle<object>>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3382A60 Offset: 0x3382B61 VA: 0x3382A60
	|-Dictionary.ValueCollection<object, AsyncOperationHandle>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3383470 Offset: 0x3383571 VA: 0x3383470
	|-Dictionary.ValueCollection<object, bool>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3383E80 Offset: 0x3383F81 VA: 0x3383E80
	|-Dictionary.ValueCollection<object, byte>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3384890 Offset: 0x3384991 VA: 0x3384890
	|-Dictionary.ValueCollection<object, int>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x33852A0 Offset: 0x33853A1 VA: 0x33852A0
	|-Dictionary.ValueCollection<object, Int32Enum>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3385CB0 Offset: 0x3385DB1 VA: 0x3385CB0
	|-Dictionary.ValueCollection<object, IntPtr>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x33866A0 Offset: 0x33867A1 VA: 0x33866A0
	|-Dictionary.ValueCollection<object, object>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3387B00 Offset: 0x3387C01 VA: 0x3387B00
	|-Dictionary.ValueCollection<object, Playable>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3388530 Offset: 0x3388631 VA: 0x3388530
	|-Dictionary.ValueCollection<object, ResourceLocator>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3388F40 Offset: 0x3389041 VA: 0x3388F40
	|-Dictionary.ValueCollection<object, float>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3389950 Offset: 0x3389A51 VA: 0x3389950
	|-Dictionary.ValueCollection<object, ushort>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x338A380 Offset: 0x338A481 VA: 0x338A380
	|-Dictionary.ValueCollection<object, GameVariable.Value>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x338AE30 Offset: 0x338AF31 VA: 0x338AE30
	|-Dictionary.ValueCollection<sbyte, DataStoreRatingInfo>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x338B820 Offset: 0x338B921 VA: 0x338B820
	|-Dictionary.ValueCollection<sbyte, object>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x338C230 Offset: 0x338C331 VA: 0x338C230
	|-Dictionary.ValueCollection<ushort, int>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x338CC40 Offset: 0x338CD41 VA: 0x338CC40
	|-Dictionary.ValueCollection<uint, int>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x338D630 Offset: 0x338D731 VA: 0x338D630
	|-Dictionary.ValueCollection<uint, object>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x338E150 Offset: 0x338E251 VA: 0x338E150
	|-Dictionary.ValueCollection<ulong, Friend>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x338EB60 Offset: 0x338EC61 VA: 0x338EB60
	|-Dictionary.ValueCollection<ulong, Int32Enum>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x338F550 Offset: 0x338F651 VA: 0x338F550
	|-Dictionary.ValueCollection<ulong, object>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x338FF60 Offset: 0x3390061 VA: 0x338FF60
	|-Dictionary.ValueCollection<Vector3, int>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3390990 Offset: 0x3390A91 VA: 0x3390990
	|-Dictionary.ValueCollection<XPathNodeRef, XPathNodeRef>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3391380 Offset: 0x3391481 VA: 0x3391380
	|-Dictionary.ValueCollection<TerrainUtility.TerrainMap.TileCoord, object>.System.Collections.ICollection.get_SyncRoot
	*/
}

