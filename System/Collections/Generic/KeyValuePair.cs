// Namespace: System.Collections.Generic
[Serializable]
public struct KeyValuePair<TKey, TValue> // TypeDefIndex: 1396
{
	// Fields
	private TKey key; // 0x0
	private TValue value; // 0x0

	// Properties
	public TKey Key { get; }
	public TValue Value { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(TKey key, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x289A150 Offset: 0x289A251 VA: 0x289A150
	|-KeyValuePair<ValueTuple<object, int>, object>..ctor
	|
	|-RVA: 0x289C730 Offset: 0x289C831 VA: 0x289C730
	|-KeyValuePair<byte[], Encoding>..ctor
	|-KeyValuePair<AnimationClip, AnimationClip>..ctor
	|-KeyValuePair<Expression, Expression>..ctor
	|-KeyValuePair<object, object>..ctor
	|
	|-RVA: 0x289A280 Offset: 0x289A381 VA: 0x289A280
	|-KeyValuePair<byte, object>..ctor
	|
	|-RVA: 0x289A370 Offset: 0x289A471 VA: 0x289A370
	|-KeyValuePair<CancellationToken, object>..ctor
	|
	|-RVA: 0x289A490 Offset: 0x289A591 VA: 0x289A490
	|-KeyValuePair<char, object>..ctor
	|
	|-RVA: 0x289A580 Offset: 0x289A681 VA: 0x289A580
	|-KeyValuePair<DateTime, object>..ctor
	|-KeyValuePair<DateTime, TimeType>..ctor
	|
	|-RVA: 0x289A670 Offset: 0x289A771 VA: 0x289A670
	|-KeyValuePair<Guid, object>..ctor
	|
	|-RVA: 0x289BEE0 Offset: 0x289BFE1 VA: 0x289BEE0
	|-KeyValuePair<IAwaiter, ValueTuple<int, DateTime, string>>..ctor
	|-KeyValuePair<object, ValueTuple<int, DateTime, object>>..ctor
	|
	|-RVA: 0x289A770 Offset: 0x289A871 VA: 0x289A770
	|-KeyValuePair<int, bool>..ctor
	|
	|-RVA: 0x289A8D0 Offset: 0x289A9D1 VA: 0x289A8D0
	|-KeyValuePair<int, byte>..ctor
	|
	|-RVA: 0x289AA30 Offset: 0x289AB31 VA: 0x289AA30
	|-KeyValuePair<int, char>..ctor
	|
	|-RVA: 0x289AB90 Offset: 0x289AC91 VA: 0x289AB90
	|-KeyValuePair<int, DiagnosticEvent>..ctor
	|
	|-RVA: 0x289AD20 Offset: 0x289AE21 VA: 0x289AD20
	|-KeyValuePair<int, int>..ctor
	|
	|-RVA: 0x289AE80 Offset: 0x289AF81 VA: 0x289AE80
	|-KeyValuePair<int, Int32Enum>..ctor
	|
	|-RVA: 0x289AFE0 Offset: 0x289B0E1 VA: 0x289AFE0
	|-KeyValuePair<int, long>..ctor
	|
	|-RVA: 0x289B140 Offset: 0x289B241 VA: 0x289B140
	|-KeyValuePair<int, MapPos>..ctor
	|
	|-RVA: 0x289B2A0 Offset: 0x289B3A1 VA: 0x289B2A0
	|-KeyValuePair<int, object>..ctor
	|-KeyValuePair<int, string>..ctor
	|
	|-RVA: 0x289B390 Offset: 0x289B491 VA: 0x289B390
	|-KeyValuePair<int, uint>..ctor
	|
	|-RVA: 0x289B4F0 Offset: 0x289B5F1 VA: 0x289B4F0
	|-KeyValuePair<int, AIThink.EnchantThink.SurroundingInfo>..ctor
	|
	|-RVA: 0x289B650 Offset: 0x289B751 VA: 0x289B650
	|-KeyValuePair<Int32Enum, bool>..ctor
	|
	|-RVA: 0x289B7B0 Offset: 0x289B8B1 VA: 0x289B7B0
	|-KeyValuePair<Int32Enum, int>..ctor
	|
	|-RVA: 0x289B910 Offset: 0x289BA11 VA: 0x289B910
	|-KeyValuePair<Int32Enum, Int32Enum>..ctor
	|
	|-RVA: 0x289BA70 Offset: 0x289BB71 VA: 0x289BA70
	|-KeyValuePair<Int32Enum, object>..ctor
	|
	|-RVA: 0x289BB60 Offset: 0x289BC61 VA: 0x289BB60
	|-KeyValuePair<long, object>..ctor
	|
	|-RVA: 0x289BC50 Offset: 0x289BD51 VA: 0x289BC50
	|-KeyValuePair<MapPos, int>..ctor
	|
	|-RVA: 0x289BDB0 Offset: 0x289BEB1 VA: 0x289BDB0
	|-KeyValuePair<object, AsyncOperationHandle<object>>..ctor
	|
	|-RVA: 0x289C010 Offset: 0x289C111 VA: 0x289C010
	|-KeyValuePair<object, AsyncOperationHandle>..ctor
	|
	|-RVA: 0x289C140 Offset: 0x289C241 VA: 0x289C140
	|-KeyValuePair<object, bool>..ctor
	|
	|-RVA: 0x289C270 Offset: 0x289C371 VA: 0x289C270
	|-KeyValuePair<object, byte>..ctor
	|
	|-RVA: 0x289C3A0 Offset: 0x289C4A1 VA: 0x289C3A0
	|-KeyValuePair<object, int>..ctor
	|
	|-RVA: 0x289C4D0 Offset: 0x289C5D1 VA: 0x289C4D0
	|-KeyValuePair<object, Int32Enum>..ctor
	|
	|-RVA: 0x289C600 Offset: 0x289C701 VA: 0x289C600
	|-KeyValuePair<object, IntPtr>..ctor
	|
	|-RVA: 0x289C7E0 Offset: 0x289C8E1 VA: 0x289C7E0
	|-KeyValuePair<object, Playable>..ctor
	|
	|-RVA: 0x289C920 Offset: 0x289CA21 VA: 0x289C920
	|-KeyValuePair<object, ResourceLocator>..ctor
	|
	|-RVA: 0x289CA70 Offset: 0x289CB71 VA: 0x289CA70
	|-KeyValuePair<object, float>..ctor
	|
	|-RVA: 0x289CBB0 Offset: 0x289CCB1 VA: 0x289CBB0
	|-KeyValuePair<object, ushort>..ctor
	|
	|-RVA: 0x289CCE0 Offset: 0x289CDE1 VA: 0x289CCE0
	|-KeyValuePair<object, GameVariable.Value>..ctor
	|
	|-RVA: 0x289CE30 Offset: 0x289CF31 VA: 0x289CE30
	|-KeyValuePair<sbyte, DataStoreRatingInfo>..ctor
	|
	|-RVA: 0x289CFA0 Offset: 0x289D0A1 VA: 0x289CFA0
	|-KeyValuePair<sbyte, object>..ctor
	|
	|-RVA: 0x289D090 Offset: 0x289D191 VA: 0x289D090
	|-KeyValuePair<ushort, int>..ctor
	|
	|-RVA: 0x289D1F0 Offset: 0x289D2F1 VA: 0x289D1F0
	|-KeyValuePair<uint, int>..ctor
	|
	|-RVA: 0x289D350 Offset: 0x289D451 VA: 0x289D350
	|-KeyValuePair<uint, object>..ctor
	|
	|-RVA: 0x289D440 Offset: 0x289D541 VA: 0x289D440
	|-KeyValuePair<ulong, Friend>..ctor
	|
	|-RVA: 0x289D5B0 Offset: 0x289D6B1 VA: 0x289D5B0
	|-KeyValuePair<ulong, Int32Enum>..ctor
	|
	|-RVA: 0x289D710 Offset: 0x289D811 VA: 0x289D710
	|-KeyValuePair<ulong, object>..ctor
	|
	|-RVA: 0x289D800 Offset: 0x289D901 VA: 0x289D800
	|-KeyValuePair<Vector3, int>..ctor
	|
	|-RVA: 0x289D960 Offset: 0x289DA61 VA: 0x289D960
	|-KeyValuePair<XPathNodeRef, XPathNodeRef>..ctor
	|
	|-RVA: 0x289DB00 Offset: 0x289DC01 VA: 0x289DB00
	|-KeyValuePair<TerrainUtility.TerrainMap.TileCoord, object>..ctor
	*/

	// RVA: -1 Offset: -1
	public TKey get_Key() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x289A190 Offset: 0x289A291 VA: 0x289A190
	|-KeyValuePair<ValueTuple<object, int>, object>.get_Key
	|
	|-RVA: 0x289C770 Offset: 0x289C871 VA: 0x289C770
	|-KeyValuePair<byte[], Encoding>.get_Key
	|-KeyValuePair<AkAudioListener, AkObstructionOcclusion.ObstructionOcclusionValue>.get_Key
	|-KeyValuePair<AnimationClip, AnimationClip>.get_Key
	|-KeyValuePair<Expression, Expression>.get_Key
	|-KeyValuePair<GameObject, GameObject>.get_Key
	|-KeyValuePair<ItemData, ChallengeMapSelectRoot.ItemDropNum>.get_Key
	|-KeyValuePair<object, object>.get_Key
	|-KeyValuePair<string, List<Renderer>>.get_Key
	|-KeyValuePair<string, List<string>>.get_Key
	|-KeyValuePair<string, CharacterAsset>.get_Key
	|-KeyValuePair<string, GodBond>.get_Key
	|-KeyValuePair<string, IMemberDescriptor>.get_Key
	|-KeyValuePair<string, MsgFile>.get_Key
	|-KeyValuePair<string, object>.get_Key
	|-KeyValuePair<string, RelayAwardeeData>.get_Key
	|-KeyValuePair<string, ResourceLocationBase>.get_Key
	|-KeyValuePair<string, string>.get_Key
	|-KeyValuePair<string, Transform>.get_Key
	|-KeyValuePair<string, UnitRelianceData>.get_Key
	|-KeyValuePair<string, EventDemoSequence.SplitViewWork>.get_Key
	|-KeyValuePair<string, FieldBgmManager.BgmHandle>.get_Key
	|-KeyValuePair<Transform, List<SpringBone>>.get_Key
	|-KeyValuePair<Transform, UpdateTracker.UpdateStatus>.get_Key
	|-KeyValuePair<Type, IUserDataDescriptor>.get_Key
	|-KeyValuePair<Type, VolumeComponent>.get_Key
	|-KeyValuePair<Unit, string>.get_Key
	|-KeyValuePair<XmlQualifiedName, SchemaElementDecl>.get_Key
	|
	|-RVA: 0x289A290 Offset: 0x289A391 VA: 0x289A290
	|-KeyValuePair<byte, List<byte>>.get_Key
	|-KeyValuePair<byte, object>.get_Key
	|
	|-RVA: 0x289A3B0 Offset: 0x289A4B1 VA: 0x289A3B0
	|-KeyValuePair<CancellationToken, object>.get_Key
	|
	|-RVA: 0x289A4A0 Offset: 0x289A5A1 VA: 0x289A4A0
	|-KeyValuePair<char, object>.get_Key
	|
	|-RVA: 0x289A590 Offset: 0x289A691 VA: 0x289A590
	|-KeyValuePair<DateTime, object>.get_Key
	|-KeyValuePair<DateTime, TimeType>.get_Key
	|
	|-RVA: 0x289A680 Offset: 0x289A781 VA: 0x289A680
	|-KeyValuePair<Guid, object>.get_Key
	|
	|-RVA: 0x289BF20 Offset: 0x289C021 VA: 0x289BF20
	|-KeyValuePair<IAwaiter, ValueTuple<int, DateTime, string>>.get_Key
	|-KeyValuePair<object, ValueTuple<int, DateTime, object>>.get_Key
	|
	|-RVA: 0x289B2B0 Offset: 0x289B3B1 VA: 0x289B2B0
	|-KeyValuePair<int, List<Volume>>.get_Key
	|-KeyValuePair<int, MapInfoIconLocatorRoot>.get_Key
	|-KeyValuePair<int, object>.get_Key
	|-KeyValuePair<int, PointerEventData>.get_Key
	|-KeyValuePair<int, string>.get_Key
	|-KeyValuePair<int, AkCallbackManager.BankCallbackPackage>.get_Key
	|-KeyValuePair<int, AkCallbackManager.EventCallbackPackage>.get_Key
	|-KeyValuePair<int, MapHistory.Rewind.OverlapData>.get_Key
	|
	|-RVA: 0x289A780 Offset: 0x289A881 VA: 0x289A780
	|-KeyValuePair<int, bool>.get_Key
	|
	|-RVA: 0x289A8E0 Offset: 0x289A9E1 VA: 0x289A8E0
	|-KeyValuePair<int, byte>.get_Key
	|
	|-RVA: 0x289AA40 Offset: 0x289AB41 VA: 0x289AA40
	|-KeyValuePair<int, char>.get_Key
	|
	|-RVA: 0x289ABD0 Offset: 0x289ACD1 VA: 0x289ABD0
	|-KeyValuePair<int, DiagnosticEvent>.get_Key
	|
	|-RVA: 0x289AD30 Offset: 0x289AE31 VA: 0x289AD30
	|-KeyValuePair<int, int>.get_Key
	|
	|-RVA: 0x289AE90 Offset: 0x289AF91 VA: 0x289AE90
	|-KeyValuePair<int, Int32Enum>.get_Key
	|
	|-RVA: 0x289AFF0 Offset: 0x289B0F1 VA: 0x289AFF0
	|-KeyValuePair<int, long>.get_Key
	|
	|-RVA: 0x289B150 Offset: 0x289B251 VA: 0x289B150
	|-KeyValuePair<int, MapPos>.get_Key
	|
	|-RVA: 0x289B3A0 Offset: 0x289B4A1 VA: 0x289B3A0
	|-KeyValuePair<int, uint>.get_Key
	|
	|-RVA: 0x289B500 Offset: 0x289B601 VA: 0x289B500
	|-KeyValuePair<int, AIThink.EnchantThink.SurroundingInfo>.get_Key
	|
	|-RVA: 0x289B660 Offset: 0x289B761 VA: 0x289B660
	|-KeyValuePair<Int32Enum, bool>.get_Key
	|
	|-RVA: 0x289B7C0 Offset: 0x289B8C1 VA: 0x289B7C0
	|-KeyValuePair<Int32Enum, int>.get_Key
	|-KeyValuePair<HubAccessManager.MaterialCalculator.Type, int>.get_Key
	|
	|-RVA: 0x289B920 Offset: 0x289BA21 VA: 0x289B920
	|-KeyValuePair<Int32Enum, Int32Enum>.get_Key
	|
	|-RVA: 0x289BA80 Offset: 0x289BB81 VA: 0x289BA80
	|-KeyValuePair<Int32Enum, object>.get_Key
	|
	|-RVA: 0x289BB70 Offset: 0x289BC71 VA: 0x289BB70
	|-KeyValuePair<long, object>.get_Key
	|
	|-RVA: 0x289C3D0 Offset: 0x289C4D1 VA: 0x289C3D0
	|-KeyValuePair<ItemData, int>.get_Key
	|-KeyValuePair<MapEditorCategoryData, int>.get_Key
	|-KeyValuePair<object, int>.get_Key
	|-KeyValuePair<SymbolRef, int>.get_Key
	|-KeyValuePair<Unit, int>.get_Key
	|
	|-RVA: 0x289BC60 Offset: 0x289BD61 VA: 0x289BC60
	|-KeyValuePair<MapPos, int>.get_Key
	|
	|-RVA: 0x289BDF0 Offset: 0x289BEF1 VA: 0x289BDF0
	|-KeyValuePair<object, AsyncOperationHandle<object>>.get_Key
	|
	|-RVA: 0x289C050 Offset: 0x289C151 VA: 0x289C050
	|-KeyValuePair<object, AsyncOperationHandle>.get_Key
	|
	|-RVA: 0x289C170 Offset: 0x289C271 VA: 0x289C170
	|-KeyValuePair<object, bool>.get_Key
	|
	|-RVA: 0x289C2A0 Offset: 0x289C3A1 VA: 0x289C2A0
	|-KeyValuePair<object, byte>.get_Key
	|-KeyValuePair<string, byte>.get_Key
	|
	|-RVA: 0x289C500 Offset: 0x289C601 VA: 0x289C500
	|-KeyValuePair<object, Int32Enum>.get_Key
	|
	|-RVA: 0x289C630 Offset: 0x289C731 VA: 0x289C630
	|-KeyValuePair<object, IntPtr>.get_Key
	|
	|-RVA: 0x289C820 Offset: 0x289C921 VA: 0x289C820
	|-KeyValuePair<object, Playable>.get_Key
	|
	|-RVA: 0x289C970 Offset: 0x289CA71 VA: 0x289C970
	|-KeyValuePair<object, ResourceLocator>.get_Key
	|
	|-RVA: 0x289CAB0 Offset: 0x289CBB1 VA: 0x289CAB0
	|-KeyValuePair<object, float>.get_Key
	|
	|-RVA: 0x289CBE0 Offset: 0x289CCE1 VA: 0x289CBE0
	|-KeyValuePair<object, ushort>.get_Key
	|
	|-RVA: 0x289CD30 Offset: 0x289CE31 VA: 0x289CD30
	|-KeyValuePair<object, GameVariable.Value>.get_Key
	|-KeyValuePair<string, GameVariable.Value>.get_Key
	|
	|-RVA: 0x289CE50 Offset: 0x289CF51 VA: 0x289CE50
	|-KeyValuePair<sbyte, DataStoreRatingInfo>.get_Key
	|
	|-RVA: 0x289CFB0 Offset: 0x289D0B1 VA: 0x289CFB0
	|-KeyValuePair<sbyte, DataStoreRatingInitParam>.get_Key
	|-KeyValuePair<sbyte, object>.get_Key
	|
	|-RVA: 0x289D0A0 Offset: 0x289D1A1 VA: 0x289D0A0
	|-KeyValuePair<ushort, int>.get_Key
	|
	|-RVA: 0x289D200 Offset: 0x289D301 VA: 0x289D200
	|-KeyValuePair<uint, int>.get_Key
	|
	|-RVA: 0x289D360 Offset: 0x289D461 VA: 0x289D360
	|-KeyValuePair<uint, object>.get_Key
	|
	|-RVA: 0x289D460 Offset: 0x289D561 VA: 0x289D460
	|-KeyValuePair<ulong, Friend>.get_Key
	|
	|-RVA: 0x289D5C0 Offset: 0x289D6C1 VA: 0x289D5C0
	|-KeyValuePair<ulong, Int32Enum>.get_Key
	|
	|-RVA: 0x289D720 Offset: 0x289D821 VA: 0x289D720
	|-KeyValuePair<ulong, object>.get_Key
	|-KeyValuePair<ulong, RelayUserGlobalData.Ticket>.get_Key
	|
	|-RVA: 0x289D820 Offset: 0x289D921 VA: 0x289D820
	|-KeyValuePair<Vector3, int>.get_Key
	|
	|-RVA: 0x289D9B0 Offset: 0x289DAB1 VA: 0x289D9B0
	|-KeyValuePair<XPathNodeRef, XPathNodeRef>.get_Key
	|
	|-RVA: 0x289DB10 Offset: 0x289DC11 VA: 0x289DB10
	|-KeyValuePair<TerrainUtility.TerrainMap.TileCoord, object>.get_Key
	|-KeyValuePair<TerrainUtility.TerrainMap.TileCoord, Terrain>.get_Key
	*/

	// RVA: -1 Offset: -1
	public TValue get_Value() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x289A1A0 Offset: 0x289A2A1 VA: 0x289A1A0
	|-KeyValuePair<ValueTuple<object, int>, object>.get_Value
	|
	|-RVA: 0x289C780 Offset: 0x289C881 VA: 0x289C780
	|-KeyValuePair<byte[], Encoding>.get_Value
	|-KeyValuePair<AkAudioListener, AkObstructionOcclusion.ObstructionOcclusionValue>.get_Value
	|-KeyValuePair<AnimationClip, AnimationClip>.get_Value
	|-KeyValuePair<Camera, Camera>.get_Value
	|-KeyValuePair<Expression, Expression>.get_Value
	|-KeyValuePair<GameObject, Stack<GameObject>>.get_Value
	|-KeyValuePair<ICinemachineCamera, object>.get_Value
	|-KeyValuePair<ItemData, ChallengeMapSelectRoot.ItemDropNum>.get_Value
	|-KeyValuePair<LabelTarget, LabelInfo>.get_Value
	|-KeyValuePair<object, IList<IResourceLocation>>.get_Value
	|-KeyValuePair<object, object>.get_Value
	|-KeyValuePair<string, List<Renderer>>.get_Value
	|-KeyValuePair<string, List<string>>.get_Value
	|-KeyValuePair<string, BasicMenuItem>.get_Value
	|-KeyValuePair<string, CharacterAsset>.get_Value
	|-KeyValuePair<string, GodBond>.get_Value
	|-KeyValuePair<string, IMemberDescriptor>.get_Value
	|-KeyValuePair<string, MsgFile>.get_Value
	|-KeyValuePair<string, object>.get_Value
	|-KeyValuePair<string, RelayAwardeeData>.get_Value
	|-KeyValuePair<string, ResourceHandle>.get_Value
	|-KeyValuePair<string, ResourceLocationBase>.get_Value
	|-KeyValuePair<string, Sprite>.get_Value
	|-KeyValuePair<string, string>.get_Value
	|-KeyValuePair<string, Transform>.get_Value
	|-KeyValuePair<string, UnitRelianceData>.get_Value
	|-KeyValuePair<string, AssetTable.Accessory>.get_Value
	|-KeyValuePair<string, EventDemoSequence.SplitViewWork>.get_Value
	|-KeyValuePair<string, ServicePointScheduler.ConnectionGroup>.get_Value
	|-KeyValuePair<string, SoundSystem.LipSyncDataFile>.get_Value
	|-KeyValuePair<string, SoundWwise.SoundBankManager.BankHandle>.get_Value
	|-KeyValuePair<string, SoundWwise.SoundPrepareManager.EventParam>.get_Value
	|-KeyValuePair<string, SoundWwise.SoundPrepareManager.SwitchParam>.get_Value
	|-KeyValuePair<string, SoundWwise.SoundPrepareManager.SwitchParamList>.get_Value
	|-KeyValuePair<Transform, List<SpringBone>>.get_Value
	|-KeyValuePair<Transform, TargetPositionCache.CacheEntry>.get_Value
	|-KeyValuePair<Transform, UpdateTracker.UpdateStatus>.get_Value
	|-KeyValuePair<Type, IUserDataDescriptor>.get_Value
	|-KeyValuePair<Type, VolumeComponent>.get_Value
	|-KeyValuePair<Unit, string>.get_Value
	|-KeyValuePair<XmlQualifiedName, SchemaElementDecl>.get_Value
	|
	|-RVA: 0x289A2A0 Offset: 0x289A3A1 VA: 0x289A2A0
	|-KeyValuePair<byte, List<byte>>.get_Value
	|-KeyValuePair<byte, object>.get_Value
	|
	|-RVA: 0x289A3C0 Offset: 0x289A4C1 VA: 0x289A3C0
	|-KeyValuePair<CancellationToken, object>.get_Value
	|
	|-RVA: 0x289A4B0 Offset: 0x289A5B1 VA: 0x289A4B0
	|-KeyValuePair<char, object>.get_Value
	|
	|-RVA: 0x289A5A0 Offset: 0x289A6A1 VA: 0x289A5A0
	|-KeyValuePair<DateTime, object>.get_Value
	|-KeyValuePair<DateTime, TimeType>.get_Value
	|
	|-RVA: 0x289A690 Offset: 0x289A791 VA: 0x289A690
	|-KeyValuePair<Guid, object>.get_Value
	|
	|-RVA: 0x289BF30 Offset: 0x289C031 VA: 0x289BF30
	|-KeyValuePair<IAwaiter, ValueTuple<int, DateTime, string>>.get_Value
	|-KeyValuePair<object, ValueTuple<int, DateTime, object>>.get_Value
	|
	|-RVA: 0x289B2C0 Offset: 0x289B3C1 VA: 0x289B2C0
	|-KeyValuePair<int, List<ValueTuple<ComputeBuffer, int>>>.get_Value
	|-KeyValuePair<int, List<ValueTuple<RTHandle, int>>>.get_Value
	|-KeyValuePair<int, List<Volume>>.get_Value
	|-KeyValuePair<int, RTHandle[]>.get_Value
	|-KeyValuePair<int, CalculatorCommand>.get_Value
	|-KeyValuePair<int, MapInfoIconLocatorRoot>.get_Value
	|-KeyValuePair<int, object>.get_Value
	|-KeyValuePair<int, PointerEventData>.get_Value
	|-KeyValuePair<int, string>.get_Value
	|-KeyValuePair<int, AkCallbackManager.BankCallbackPackage>.get_Value
	|-KeyValuePair<int, AkCallbackManager.EventCallbackPackage>.get_Value
	|-KeyValuePair<int, TerrainUtility.TerrainMap>.get_Value
	|-KeyValuePair<int, MapHistory.Rewind.OverlapData>.get_Value
	|
	|-RVA: 0x289A790 Offset: 0x289A891 VA: 0x289A790
	|-KeyValuePair<int, bool>.get_Value
	|
	|-RVA: 0x289A8F0 Offset: 0x289A9F1 VA: 0x289A8F0
	|-KeyValuePair<int, byte>.get_Value
	|
	|-RVA: 0x289AA50 Offset: 0x289AB51 VA: 0x289AA50
	|-KeyValuePair<int, char>.get_Value
	|
	|-RVA: 0x289ABE0 Offset: 0x289ACE1 VA: 0x289ABE0
	|-KeyValuePair<int, DiagnosticEvent>.get_Value
	|
	|-RVA: 0x289AD40 Offset: 0x289AE41 VA: 0x289AD40
	|-KeyValuePair<int, int>.get_Value
	|
	|-RVA: 0x289AEA0 Offset: 0x289AFA1 VA: 0x289AEA0
	|-KeyValuePair<int, Int32Enum>.get_Value
	|
	|-RVA: 0x289B000 Offset: 0x289B101 VA: 0x289B000
	|-KeyValuePair<int, long>.get_Value
	|
	|-RVA: 0x289B160 Offset: 0x289B261 VA: 0x289B160
	|-KeyValuePair<int, MapPos>.get_Value
	|
	|-RVA: 0x289B3B0 Offset: 0x289B4B1 VA: 0x289B3B0
	|-KeyValuePair<int, uint>.get_Value
	|
	|-RVA: 0x289B510 Offset: 0x289B611 VA: 0x289B510
	|-KeyValuePair<int, AIThink.EnchantThink.SurroundingInfo>.get_Value
	|
	|-RVA: 0x289B670 Offset: 0x289B771 VA: 0x289B670
	|-KeyValuePair<Int32Enum, bool>.get_Value
	|
	|-RVA: 0x289B7D0 Offset: 0x289B8D1 VA: 0x289B7D0
	|-KeyValuePair<Int32Enum, int>.get_Value
	|-KeyValuePair<HubAccessManager.MaterialCalculator.Type, int>.get_Value
	|
	|-RVA: 0x289B930 Offset: 0x289BA31 VA: 0x289B930
	|-KeyValuePair<Int32Enum, Int32Enum>.get_Value
	|
	|-RVA: 0x289BA90 Offset: 0x289BB91 VA: 0x289BA90
	|-KeyValuePair<Int32Enum, object>.get_Value
	|
	|-RVA: 0x289BB80 Offset: 0x289BC81 VA: 0x289BB80
	|-KeyValuePair<long, object>.get_Value
	|
	|-RVA: 0x289C3E0 Offset: 0x289C4E1 VA: 0x289C3E0
	|-KeyValuePair<ItemData, int>.get_Value
	|-KeyValuePair<MapEditorCategoryData, int>.get_Value
	|-KeyValuePair<object, int>.get_Value
	|-KeyValuePair<SymbolRef, int>.get_Value
	|-KeyValuePair<Unit, int>.get_Value
	|
	|-RVA: 0x289BC70 Offset: 0x289BD71 VA: 0x289BC70
	|-KeyValuePair<MapPos, int>.get_Value
	|
	|-RVA: 0x289BE00 Offset: 0x289BF01 VA: 0x289BE00
	|-KeyValuePair<object, AsyncOperationHandle<object>>.get_Value
	|
	|-RVA: 0x289C060 Offset: 0x289C161 VA: 0x289C060
	|-KeyValuePair<object, AsyncOperationHandle>.get_Value
	|
	|-RVA: 0x289C180 Offset: 0x289C281 VA: 0x289C180
	|-KeyValuePair<object, bool>.get_Value
	|
	|-RVA: 0x289C2B0 Offset: 0x289C3B1 VA: 0x289C2B0
	|-KeyValuePair<object, byte>.get_Value
	|-KeyValuePair<string, byte>.get_Value
	|
	|-RVA: 0x289C510 Offset: 0x289C611 VA: 0x289C510
	|-KeyValuePair<object, Int32Enum>.get_Value
	|
	|-RVA: 0x289C640 Offset: 0x289C741 VA: 0x289C640
	|-KeyValuePair<object, IntPtr>.get_Value
	|
	|-RVA: 0x289C830 Offset: 0x289C931 VA: 0x289C830
	|-KeyValuePair<object, Playable>.get_Value
	|
	|-RVA: 0x289C980 Offset: 0x289CA81 VA: 0x289C980
	|-KeyValuePair<object, ResourceLocator>.get_Value
	|
	|-RVA: 0x289CAC0 Offset: 0x289CBC1 VA: 0x289CAC0
	|-KeyValuePair<object, float>.get_Value
	|
	|-RVA: 0x289CBF0 Offset: 0x289CCF1 VA: 0x289CBF0
	|-KeyValuePair<object, ushort>.get_Value
	|
	|-RVA: 0x289CD40 Offset: 0x289CE41 VA: 0x289CD40
	|-KeyValuePair<object, GameVariable.Value>.get_Value
	|-KeyValuePair<string, GameVariable.Value>.get_Value
	|
	|-RVA: 0x289CE60 Offset: 0x289CF61 VA: 0x289CE60
	|-KeyValuePair<sbyte, DataStoreRatingInfo>.get_Value
	|
	|-RVA: 0x289CFC0 Offset: 0x289D0C1 VA: 0x289CFC0
	|-KeyValuePair<sbyte, DataStoreRatingInitParam>.get_Value
	|-KeyValuePair<sbyte, object>.get_Value
	|
	|-RVA: 0x289D0B0 Offset: 0x289D1B1 VA: 0x289D0B0
	|-KeyValuePair<ushort, int>.get_Value
	|
	|-RVA: 0x289D210 Offset: 0x289D311 VA: 0x289D210
	|-KeyValuePair<uint, int>.get_Value
	|
	|-RVA: 0x289D370 Offset: 0x289D471 VA: 0x289D370
	|-KeyValuePair<uint, object>.get_Value
	|
	|-RVA: 0x289D470 Offset: 0x289D571 VA: 0x289D470
	|-KeyValuePair<ulong, Friend>.get_Value
	|
	|-RVA: 0x289D5D0 Offset: 0x289D6D1 VA: 0x289D5D0
	|-KeyValuePair<ulong, Int32Enum>.get_Value
	|
	|-RVA: 0x289D730 Offset: 0x289D831 VA: 0x289D730
	|-KeyValuePair<ulong, object>.get_Value
	|-KeyValuePair<ulong, RelayUserGlobalData.Ticket>.get_Value
	|
	|-RVA: 0x289D830 Offset: 0x289D931 VA: 0x289D830
	|-KeyValuePair<Vector3, int>.get_Value
	|
	|-RVA: 0x289D9C0 Offset: 0x289DAC1 VA: 0x289D9C0
	|-KeyValuePair<XPathNodeRef, XPathNodeRef>.get_Value
	|
	|-RVA: 0x289DB20 Offset: 0x289DC21 VA: 0x289DB20
	|-KeyValuePair<TerrainUtility.TerrainMap.TileCoord, object>.get_Value
	*/

	// RVA: -1 Offset: -1 Slot: 3
	public override string ToString() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x289A1B0 Offset: 0x289A2B1 VA: 0x289A1B0
	|-KeyValuePair<ValueTuple<object, int>, object>.ToString
	|
	|-RVA: 0x289A2B0 Offset: 0x289A3B1 VA: 0x289A2B0
	|-KeyValuePair<byte, object>.ToString
	|
	|-RVA: 0x289A3D0 Offset: 0x289A4D1 VA: 0x289A3D0
	|-KeyValuePair<CancellationToken, object>.ToString
	|
	|-RVA: 0x289A4C0 Offset: 0x289A5C1 VA: 0x289A4C0
	|-KeyValuePair<char, object>.ToString
	|
	|-RVA: 0x289A5B0 Offset: 0x289A6B1 VA: 0x289A5B0
	|-KeyValuePair<DateTime, object>.ToString
	|
	|-RVA: 0x289A6A0 Offset: 0x289A7A1 VA: 0x289A6A0
	|-KeyValuePair<Guid, object>.ToString
	|
	|-RVA: 0x289A7A0 Offset: 0x289A8A1 VA: 0x289A7A0
	|-KeyValuePair<int, bool>.ToString
	|
	|-RVA: 0x289A900 Offset: 0x289AA01 VA: 0x289A900
	|-KeyValuePair<int, byte>.ToString
	|
	|-RVA: 0x289AA60 Offset: 0x289AB61 VA: 0x289AA60
	|-KeyValuePair<int, char>.ToString
	|
	|-RVA: 0x289AC00 Offset: 0x289AD01 VA: 0x289AC00
	|-KeyValuePair<int, DiagnosticEvent>.ToString
	|
	|-RVA: 0x289AD50 Offset: 0x289AE51 VA: 0x289AD50
	|-KeyValuePair<int, int>.ToString
	|
	|-RVA: 0x289AEB0 Offset: 0x289AFB1 VA: 0x289AEB0
	|-KeyValuePair<int, Int32Enum>.ToString
	|
	|-RVA: 0x289B010 Offset: 0x289B111 VA: 0x289B010
	|-KeyValuePair<int, long>.ToString
	|
	|-RVA: 0x289B170 Offset: 0x289B271 VA: 0x289B170
	|-KeyValuePair<int, MapPos>.ToString
	|
	|-RVA: 0x289B2D0 Offset: 0x289B3D1 VA: 0x289B2D0
	|-KeyValuePair<int, object>.ToString
	|-KeyValuePair<int, PointerEventData>.ToString
	|
	|-RVA: 0x289B3C0 Offset: 0x289B4C1 VA: 0x289B3C0
	|-KeyValuePair<int, uint>.ToString
	|
	|-RVA: 0x289B520 Offset: 0x289B621 VA: 0x289B520
	|-KeyValuePair<int, AIThink.EnchantThink.SurroundingInfo>.ToString
	|
	|-RVA: 0x289B680 Offset: 0x289B781 VA: 0x289B680
	|-KeyValuePair<Int32Enum, bool>.ToString
	|
	|-RVA: 0x289B7E0 Offset: 0x289B8E1 VA: 0x289B7E0
	|-KeyValuePair<Int32Enum, int>.ToString
	|
	|-RVA: 0x289B940 Offset: 0x289BA41 VA: 0x289B940
	|-KeyValuePair<Int32Enum, Int32Enum>.ToString
	|
	|-RVA: 0x289BAA0 Offset: 0x289BBA1 VA: 0x289BAA0
	|-KeyValuePair<Int32Enum, object>.ToString
	|
	|-RVA: 0x289BB90 Offset: 0x289BC91 VA: 0x289BB90
	|-KeyValuePair<long, object>.ToString
	|
	|-RVA: 0x289BC80 Offset: 0x289BD81 VA: 0x289BC80
	|-KeyValuePair<MapPos, int>.ToString
	|
	|-RVA: 0x289BE20 Offset: 0x289BF21 VA: 0x289BE20
	|-KeyValuePair<object, AsyncOperationHandle<object>>.ToString
	|
	|-RVA: 0x289BF50 Offset: 0x289C051 VA: 0x289BF50
	|-KeyValuePair<object, ValueTuple<int, DateTime, object>>.ToString
	|
	|-RVA: 0x289C080 Offset: 0x289C181 VA: 0x289C080
	|-KeyValuePair<object, AsyncOperationHandle>.ToString
	|
	|-RVA: 0x289C190 Offset: 0x289C291 VA: 0x289C190
	|-KeyValuePair<object, bool>.ToString
	|
	|-RVA: 0x289C2C0 Offset: 0x289C3C1 VA: 0x289C2C0
	|-KeyValuePair<object, byte>.ToString
	|
	|-RVA: 0x289C3F0 Offset: 0x289C4F1 VA: 0x289C3F0
	|-KeyValuePair<object, int>.ToString
	|
	|-RVA: 0x289C520 Offset: 0x289C621 VA: 0x289C520
	|-KeyValuePair<object, Int32Enum>.ToString
	|
	|-RVA: 0x289C650 Offset: 0x289C751 VA: 0x289C650
	|-KeyValuePair<object, IntPtr>.ToString
	|
	|-RVA: 0x289C790 Offset: 0x289C891 VA: 0x289C790
	|-KeyValuePair<object, object>.ToString
	|
	|-RVA: 0x289C840 Offset: 0x289C941 VA: 0x289C840
	|-KeyValuePair<object, Playable>.ToString
	|
	|-RVA: 0x289C990 Offset: 0x289CA91 VA: 0x289C990
	|-KeyValuePair<object, ResourceLocator>.ToString
	|
	|-RVA: 0x289CAD0 Offset: 0x289CBD1 VA: 0x289CAD0
	|-KeyValuePair<object, float>.ToString
	|
	|-RVA: 0x289CC00 Offset: 0x289CD01 VA: 0x289CC00
	|-KeyValuePair<object, ushort>.ToString
	|
	|-RVA: 0x289CD50 Offset: 0x289CE51 VA: 0x289CD50
	|-KeyValuePair<object, GameVariable.Value>.ToString
	|
	|-RVA: 0x289CE80 Offset: 0x289CF81 VA: 0x289CE80
	|-KeyValuePair<sbyte, DataStoreRatingInfo>.ToString
	|
	|-RVA: 0x289CFD0 Offset: 0x289D0D1 VA: 0x289CFD0
	|-KeyValuePair<sbyte, object>.ToString
	|
	|-RVA: 0x289D0C0 Offset: 0x289D1C1 VA: 0x289D0C0
	|-KeyValuePair<ushort, int>.ToString
	|
	|-RVA: 0x289D220 Offset: 0x289D321 VA: 0x289D220
	|-KeyValuePair<uint, int>.ToString
	|
	|-RVA: 0x289D380 Offset: 0x289D481 VA: 0x289D380
	|-KeyValuePair<uint, object>.ToString
	|
	|-RVA: 0x289D490 Offset: 0x289D591 VA: 0x289D490
	|-KeyValuePair<ulong, Friend>.ToString
	|
	|-RVA: 0x289D5E0 Offset: 0x289D6E1 VA: 0x289D5E0
	|-KeyValuePair<ulong, Int32Enum>.ToString
	|
	|-RVA: 0x289D740 Offset: 0x289D841 VA: 0x289D740
	|-KeyValuePair<ulong, object>.ToString
	|
	|-RVA: 0x289D840 Offset: 0x289D941 VA: 0x289D840
	|-KeyValuePair<Vector3, int>.ToString
	|
	|-RVA: 0x289D9D0 Offset: 0x289DAD1 VA: 0x289D9D0
	|-KeyValuePair<XPathNodeRef, XPathNodeRef>.ToString
	|
	|-RVA: 0x289DB30 Offset: 0x289DC31 VA: 0x289DB30
	|-KeyValuePair<TerrainUtility.TerrainMap.TileCoord, object>.ToString
	*/
}

