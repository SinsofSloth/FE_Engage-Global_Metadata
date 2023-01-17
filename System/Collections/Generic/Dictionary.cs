// Namespace: System.Collections.Generic
[DefaultMemberAttribute] // RVA: 0x4774C0 Offset: 0x4775C1 VA: 0x4774C0
[DebuggerDisplayAttribute] // RVA: 0x4774C0 Offset: 0x4775C1 VA: 0x4774C0
[DebuggerTypeProxyAttribute] // RVA: 0x4774C0 Offset: 0x4775C1 VA: 0x4774C0
[Serializable]
public class Dictionary<TKey, TValue> : IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable, IDictionary, ICollection, IReadOnlyDictionary<TKey, TValue>, IReadOnlyCollection<KeyValuePair<TKey, TValue>>, ISerializable, IDeserializationCallback // TypeDefIndex: 1407
{
	// Fields
	private int[] buckets; // 0x0
	private Dictionary.Entry<TKey, TValue>[] entries; // 0x0
	private int count; // 0x0
	private int version; // 0x0
	private int freeList; // 0x0
	private int freeCount; // 0x0
	private IEqualityComparer<TKey> comparer; // 0x0
	private Dictionary.KeyCollection<TKey, TValue> keys; // 0x0
	private Dictionary.ValueCollection<TKey, TValue> values; // 0x0
	private object _syncRoot; // 0x0
	private const string VersionName = "Version";
	private const string HashSizeName = "HashSize";
	private const string KeyValuePairsName = "KeyValuePairs";
	private const string ComparerName = "Comparer";

	// Properties
	public int Count { get; }
	public Dictionary.KeyCollection<TKey, TValue> Keys { get; }
	private ICollection<TKey> System.Collections.Generic.IDictionary<TKey,TValue>.Keys { get; }
	public Dictionary.ValueCollection<TKey, TValue> Values { get; }
	private ICollection<TValue> System.Collections.Generic.IDictionary<TKey,TValue>.Values { get; }
	public TValue Item { get; set; }
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.IsReadOnly { get; }
	private bool System.Collections.ICollection.IsSynchronized { get; }
	private object System.Collections.ICollection.SyncRoot { get; }
	private bool System.Collections.IDictionary.IsFixedSize { get; }
	private bool System.Collections.IDictionary.IsReadOnly { get; }
	private ICollection System.Collections.IDictionary.Keys { get; }
	private ICollection System.Collections.IDictionary.Values { get; }
	private object System.Collections.IDictionary.Item { get; set; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x251C300 Offset: 0x251C401 VA: 0x251C300
	|-Dictionary<ValueTuple<object, int>, object>..ctor
	|-Dictionary<ValueTuple<Type, int>, Stack<object>>..ctor
	|
	|-RVA: 0x3CEFA60 Offset: 0x3CEFB61 VA: 0x3CEFA60
	|-Dictionary<byte[], Encoding>..ctor
	|-Dictionary<Action, LinkedListNode<Action>>..ctor
	|-Dictionary<AkAudioListener, AkObstructionOcclusion.ObstructionOcclusionValue>..ctor
	|-Dictionary<AnimationClip, List<CinemachineStateDrivenCamera.HashPair>>..ctor
	|-Dictionary<Camera, HashSet<Action<RenderTargetIdentifier, CommandBuffer>>>..ctor
	|-Dictionary<Camera, Camera>..ctor
	|-Dictionary<Canvas, IndexedSet<Graphic>>..ctor
	|-Dictionary<CinemachineVirtualCameraBase, CinemachineCore.UpdateStatus>..ctor
	|-Dictionary<Collider, AkRoomAwareObject>..ctor
	|-Dictionary<FieldInfo, Instruction>..ctor
	|-Dictionary<Font, HashSet<Text>>..ctor
	|-Dictionary<GmapSpot, GmapSpot>..ctor
	|-Dictionary<IAsyncLocal, object>..ctor
	|-Dictionary<ICinemachineCamera, object>..ctor
	|-Dictionary<IDtdEntityInfo, IDtdEntityInfo>..ctor
	|-Dictionary<IOperationCacheKey, IAsyncOperation>..ctor
	|-Dictionary<IResourceLocation, ContentCatalogProvider.InternalOp>..ctor
	|-Dictionary<ItemData, ChallengeMapSelectRoot.ItemDropNum>..ctor
	|-Dictionary<object, object>..ctor
	|-Dictionary<ParameterExpression, LocalVariable>..ctor
	|-Dictionary<Renderer, Material[]>..ctor
	|-Dictionary<Renderer, MapObject.DitherPair>..ctor
	|-Dictionary<string, List<Renderer>>..ctor
	|-Dictionary<string, List<string>>..ctor
	|-Dictionary<string, List<GodGrowthData.LevelData>>..ctor
	|-Dictionary<string, List<RangeData.Offset>>..ctor
	|-Dictionary<string, TResourceHandle<AnimationClip>>..ctor
	|-Dictionary<string, Tuple<Guid, string>>..ctor
	|-Dictionary<string, Color[]>..ctor
	|-Dictionary<string, Unit[]>..ctor
	|-Dictionary<string, BasicMenuItem>..ctor
	|-Dictionary<string, CharacterAsset>..ctor
	|-Dictionary<string, CultureInfo>..ctor
	|-Dictionary<string, FileData>..ctor
	|-Dictionary<string, GodData>..ctor
	|-Dictionary<string, IMemberDescriptor>..ctor
	|-Dictionary<string, LabelStatement>..ctor
	|-Dictionary<string, LocalDataStoreSlot>..ctor
	|-Dictionary<string, MapObject>..ctor
	|-Dictionary<string, MsgFile>..ctor
	|-Dictionary<string, object>..ctor
	|-Dictionary<string, Object>..ctor
	|-Dictionary<string, PropertyInfo>..ctor
	|-Dictionary<string, RelayAwardeeData>..ctor
	|-Dictionary<string, ResourceHandle>..ctor
	|-Dictionary<string, ResourceLocationBase>..ctor
	|-Dictionary<string, ResourceLocationData>..ctor
	|-Dictionary<string, ResourceSet>..ctor
	|-Dictionary<string, RuntimeAnimatorController>..ctor
	|-Dictionary<string, SchemaNotation>..ctor
	|-Dictionary<string, Sprite>..ctor
	|-Dictionary<string, string>..ctor
	|-Dictionary<string, SymbolRef>..ctor
	|-Dictionary<string, Transform>..ctor
	|-Dictionary<string, Type>..ctor
	|-Dictionary<string, VibrationFile>..ctor
	|-Dictionary<string, AkBankManager.BankHandle>..ctor
	|-Dictionary<string, AssetTable.Accessory>..ctor
	|-Dictionary<string, ChapterRecord.Record>..ctor
	|-Dictionary<string, DtdParser.UndeclaredNotation>..ctor
	|-Dictionary<string, EventDemoSequence.CharacterWork>..ctor
	|-Dictionary<string, EventDemoSequence.CmdFunc>..ctor
	|-Dictionary<string, EventDemoSequence.EffectWork>..ctor
	|-Dictionary<string, EventDemoSequence.SplitViewWork>..ctor
	|-Dictionary<string, FieldBgmManager.BgmHandle>..ctor
	|-Dictionary<string, GameUserRestartData.Growth>..ctor
	|-Dictionary<string, RingInfo.RingPrefabObject>..ctor
	|-Dictionary<string, ServicePointScheduler.ConnectionGroup>..ctor
	|-Dictionary<string, SoundSystem.LipSyncDataFile>..ctor
	|-Dictionary<string, SoundWwise.SoundBankManager.BankHandle>..ctor
	|-Dictionary<string, SoundWwise.SoundPrepareManager.EventParam>..ctor
	|-Dictionary<string, SoundWwise.SoundPrepareManager.SwitchParam>..ctor
	|-Dictionary<string, SoundWwise.SoundPrepareManager.SwitchParamList>..ctor
	|-Dictionary<Thread, StackTrace>..ctor
	|-Dictionary<Transform, List<SpringBone>>..ctor
	|-Dictionary<Transform, TargetPositionCache.CacheEntry>..ctor
	|-Dictionary<Transform, UpdateTracker.UpdateStatus>..ctor
	|-Dictionary<Type, Func<DynValue, object>>..ctor
	|-Dictionary<Type, Func<Script, object, DynValue>>..ctor
	|-Dictionary<Type, AttributeUsageAttribute>..ctor
	|-Dictionary<Type, IPropertyTableAssigner>..ctor
	|-Dictionary<Type, IUserDataDescriptor>..ctor
	|-Dictionary<Type, object>..ctor
	|-Dictionary<Type, string>..ctor
	|-Dictionary<Type, TrackBindingTypeAttribute>..ctor
	|-Dictionary<Type, Transform>..ctor
	|-Dictionary<Type, Type>..ctor
	|-Dictionary<Type, TypeInformation>..ctor
	|-Dictionary<Type, VolumeComponent>..ctor
	|-Dictionary<Unit, string>..ctor
	|-Dictionary<VersusServerReplayMetaData, string>..ctor
	|-Dictionary<XmlQualifiedName, SchemaAttDef>..ctor
	|-Dictionary<XmlQualifiedName, SchemaElementDecl>..ctor
	|-Dictionary<XmlQualifiedName, SchemaEntity>..ctor
	|-Dictionary<XmlQualifiedName, XmlQualifiedName>..ctor
	|-Dictionary<XmlQualifiedName, XmlSchemaObject>..ctor
	|
	|-RVA: 0x251FE50 Offset: 0x251FF51 VA: 0x251FE50
	|-Dictionary<byte, List<byte>>..ctor
	|-Dictionary<byte, object>..ctor
	|
	|-RVA: 0x3CA4D90 Offset: 0x3CA4E91 VA: 0x3CA4D90
	|-Dictionary<CancellationToken, object>..ctor
	|
	|-RVA: 0x3CA8890 Offset: 0x3CA8991 VA: 0x3CA8890
	|-Dictionary<char, object>..ctor
	|-Dictionary<char, string>..ctor
	|
	|-RVA: 0x3CE46B0 Offset: 0x3CE47B1 VA: 0x3CE46B0
	|-Dictionary<CinemachineVirtualCameraBase, int>..ctor
	|-Dictionary<FoodstuffData, int>..ctor
	|-Dictionary<Graphic, int>..ctor
	|-Dictionary<ICanvasElement, int>..ctor
	|-Dictionary<IClipper, int>..ctor
	|-Dictionary<ItemData, int>..ctor
	|-Dictionary<object, int>..ctor
	|-Dictionary<ParameterExpression, int>..ctor
	|-Dictionary<string, int>..ctor
	|-Dictionary<SymbolRef, int>..ctor
	|-Dictionary<Unit, int>..ctor
	|
	|-RVA: 0x3CBEF50 Offset: 0x3CBF051 VA: 0x3CBEF50
	|-Dictionary<FormatUsage, bool>..ctor
	|-Dictionary<Int32Enum, bool>..ctor
	|-Dictionary<RenderTextureFormat, bool>..ctor
	|
	|-RVA: 0x3CD5070 Offset: 0x3CD5171 VA: 0x3CD5070
	|-Dictionary<GameObject, AsyncOperationHandle<GameObject>>..ctor
	|-Dictionary<object, AsyncOperationHandle<object>>..ctor
	|
	|-RVA: 0x3CC9F30 Offset: 0x3CCA031 VA: 0x3CC9F30
	|-Dictionary<GraphicsFormat, Dictionary<FormatUsage, bool>>..ctor
	|-Dictionary<Int32Enum, object>..ctor
	|-Dictionary<KeyHelp.Type, KeyHelp.UI.Element>..ctor
	|-Dictionary<Mess.TagGroup, TalkTag>..ctor
	|
	|-RVA: 0x3CAC3A0 Offset: 0x3CAC4A1 VA: 0x3CAC3A0
	|-Dictionary<Guid, MonoTlsProvider>..ctor
	|-Dictionary<Guid, object>..ctor
	|
	|-RVA: 0x3D5B100 Offset: 0x3D5B201 VA: 0x3D5B100
	|-Dictionary<int, List<object>>..ctor
	|-Dictionary<int, List<Volume>>..ctor
	|-Dictionary<int, RTHandle[]>..ctor
	|-Dictionary<int, CalculatorCommand>..ctor
	|-Dictionary<int, CultureInfo>..ctor
	|-Dictionary<int, DiagnosticInfo>..ctor
	|-Dictionary<int, GameObject>..ctor
	|-Dictionary<int, IResourceProvider>..ctor
	|-Dictionary<int, MapInfoIconLocatorRoot>..ctor
	|-Dictionary<int, Material>..ctor
	|-Dictionary<int, object>..ctor
	|-Dictionary<int, PointerEventData>..ctor
	|-Dictionary<int, PrefetchedSignal>..ctor
	|-Dictionary<int, ProfilingSampler>..ctor
	|-Dictionary<int, ResourceGameObject>..ctor
	|-Dictionary<int, SourceCode>..ctor
	|-Dictionary<int, string>..ctor
	|-Dictionary<int, TMP_ColorGradient>..ctor
	|-Dictionary<int, TMP_FontAsset>..ctor
	|-Dictionary<int, TMP_SpriteAsset>..ctor
	|-Dictionary<int, TMP_Style>..ctor
	|-Dictionary<int, Task>..ctor
	|-Dictionary<int, AkCallbackManager.BankCallbackPackage>..ctor
	|-Dictionary<int, AkCallbackManager.EventCallbackPackage>..ctor
	|-Dictionary<int, GUILayoutUtility.LayoutCache>..ctor
	|-Dictionary<int, TerrainUtility.TerrainMap>..ctor
	|
	|-RVA: 0x3CAFEE0 Offset: 0x3CAFFE1 VA: 0x3CAFEE0
	|-Dictionary<int, bool>..ctor
	|
	|-RVA: 0x3CB39A0 Offset: 0x3CB3AA1 VA: 0x3CB39A0
	|-Dictionary<int, byte>..ctor
	|
	|-RVA: 0x3CB7460 Offset: 0x3CB7561 VA: 0x3CB7460
	|-Dictionary<int, char>..ctor
	|
	|-RVA: 0x3CBAF20 Offset: 0x3CBB021 VA: 0x3CBAF20
	|-Dictionary<int, DiagnosticEvent>..ctor
	|
	|-RVA: 0x3D4C530 Offset: 0x3D4C631 VA: 0x3D4C530
	|-Dictionary<int, int>..ctor
	|
	|-RVA: 0x3D4FFC0 Offset: 0x3D500C1 VA: 0x3D4FFC0
	|-Dictionary<int, Int32Enum>..ctor
	|-Dictionary<int, UnitRecord.Kinds>..ctor
	|
	|-RVA: 0x3D53A50 Offset: 0x3D53B51 VA: 0x3D53A50
	|-Dictionary<int, long>..ctor
	|
	|-RVA: 0x3D575B0 Offset: 0x3D576B1 VA: 0x3D575B0
	|-Dictionary<int, MapPos>..ctor
	|
	|-RVA: 0x3D5EC10 Offset: 0x3D5ED11 VA: 0x3D5EC10
	|-Dictionary<int, uint>..ctor
	|
	|-RVA: 0x3D626A0 Offset: 0x3D627A1 VA: 0x3D626A0
	|-Dictionary<int, AIThink.EnchantThink.SurroundingInfo>..ctor
	|
	|-RVA: 0x3CC2A10 Offset: 0x3CC2B11 VA: 0x3CC2A10
	|-Dictionary<Int32Enum, int>..ctor
	|-Dictionary<UnitRecord.Kinds, int>..ctor
	|-Dictionary<HubAccessManager.MaterialCalculator.Type, int>..ctor
	|
	|-RVA: 0x3CC64A0 Offset: 0x3CC65A1 VA: 0x3CC64A0
	|-Dictionary<Int32Enum, Int32Enum>..ctor
	|-Dictionary<RuntimePlatform, AddressablesPlatform>..ctor
	|
	|-RVA: 0x3CCDA40 Offset: 0x3CCDB41 VA: 0x3CCDA40
	|-Dictionary<long, object>..ctor
	|-Dictionary<long, TMP_MaterialManager.FallbackMaterial>..ctor
	|
	|-RVA: 0x3CD1530 Offset: 0x3CD1631 VA: 0x3CD1530
	|-Dictionary<MapPos, int>..ctor
	|
	|-RVA: 0x3CD8F90 Offset: 0x3CD9091 VA: 0x3CD8F90
	|-Dictionary<object, AsyncOperationHandle>..ctor
	|
	|-RVA: 0x3CDCEB0 Offset: 0x3CDCFB1 VA: 0x3CDCEB0
	|-Dictionary<object, bool>..ctor
	|-Dictionary<string, bool>..ctor
	|
	|-RVA: 0x3CE0AC0 Offset: 0x3CE0BC1 VA: 0x3CE0AC0
	|-Dictionary<object, byte>..ctor
	|
	|-RVA: 0x3CE82A0 Offset: 0x3CE83A1 VA: 0x3CE82A0
	|-Dictionary<object, Int32Enum>..ctor
	|-Dictionary<string, RangeData.Targets>..ctor
	|
	|-RVA: 0x3CEBE90 Offset: 0x3CEBF91 VA: 0x3CEBE90
	|-Dictionary<object, IntPtr>..ctor
	|-Dictionary<string, IntPtr>..ctor
	|
	|-RVA: 0x3C8A810 Offset: 0x3C8A911 VA: 0x3C8A810
	|-Dictionary<object, Playable>..ctor
	|-Dictionary<TrackAsset, Playable>..ctor
	|
	|-RVA: 0x3C8E3F0 Offset: 0x3C8E4F1 VA: 0x3C8E3F0
	|-Dictionary<object, ResourceLocator>..ctor
	|
	|-RVA: 0x3C91FF0 Offset: 0x3C920F1 VA: 0x3C91FF0
	|-Dictionary<object, float>..ctor
	|
	|-RVA: 0x3C95BD0 Offset: 0x3C95CD1 VA: 0x3C95BD0
	|-Dictionary<object, ushort>..ctor
	|-Dictionary<VersusServerReplayMetaData, ushort>..ctor
	|
	|-RVA: 0x3C997C0 Offset: 0x3C998C1 VA: 0x3C997C0
	|-Dictionary<object, GameVariable.Value>..ctor
	|
	|-RVA: 0x3C9D3C0 Offset: 0x3C9D4C1 VA: 0x3C9D3C0
	|-Dictionary<sbyte, DataStoreRatingInfo>..ctor
	|
	|-RVA: 0x3CA1280 Offset: 0x3CA1381 VA: 0x3CA1280
	|-Dictionary<sbyte, DataStoreRatingInitParam>..ctor
	|-Dictionary<sbyte, object>..ctor
	|
	|-RVA: 0x3D32180 Offset: 0x3D32281 VA: 0x3D32180
	|-Dictionary<ushort, int>..ctor
	|
	|-RVA: 0x3D396D0 Offset: 0x3D397D1 VA: 0x3D396D0
	|-Dictionary<uint, AkMultiPosEvent>..ctor
	|-Dictionary<uint, Glyph>..ctor
	|-Dictionary<uint, Material>..ctor
	|-Dictionary<uint, object>..ctor
	|-Dictionary<uint, string>..ctor
	|-Dictionary<uint, TMP_Character>..ctor
	|-Dictionary<uint, TMP_GlyphPairAdjustmentRecord>..ctor
	|-Dictionary<uint, TMP_SpriteCharacter>..ctor
	|-Dictionary<uint, TMP_SpriteGlyph>..ctor
	|-Dictionary<uint, AkAudioInputManager.AudioFormatDelegate>..ctor
	|-Dictionary<uint, AkAudioInputManager.AudioSamplesDelegate>..ctor
	|
	|-RVA: 0x3D35C40 Offset: 0x3D35D41 VA: 0x3D35C40
	|-Dictionary<uint, int>..ctor
	|
	|-RVA: 0x3D3D1E0 Offset: 0x3D3D2E1 VA: 0x3D3D1E0
	|-Dictionary<ulong, Friend>..ctor
	|
	|-RVA: 0x3D41230 Offset: 0x3D41331 VA: 0x3D41230
	|-Dictionary<ulong, Int32Enum>..ctor
	|-Dictionary<ulong, NexVersus.TargetSlotList.Results>..ctor
	|
	|-RVA: 0x3D44DA0 Offset: 0x3D44EA1 VA: 0x3D44DA0
	|-Dictionary<ulong, object>..ctor
	|-Dictionary<ulong, RelayUserGlobalData.Ticket>..ctor
	|
	|-RVA: 0x3D48890 Offset: 0x3D48991 VA: 0x3D48890
	|-Dictionary<Vector3, int>..ctor
	|
	|-RVA: 0x2626CD0 Offset: 0x2626DD1 VA: 0x2626CD0
	|-Dictionary<XPathNodeRef, XPathNodeRef>..ctor
	|
	|-RVA: 0x262A970 Offset: 0x262AA71 VA: 0x262A970
	|-Dictionary<TerrainUtility.TerrainMap.TileCoord, object>..ctor
	|-Dictionary<TerrainUtility.TerrainMap.TileCoord, Terrain>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(int capacity) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x251C320 Offset: 0x251C421 VA: 0x251C320
	|-Dictionary<ValueTuple<object, int>, object>..ctor
	|
	|-RVA: 0x251FE70 Offset: 0x251FF71 VA: 0x251FE70
	|-Dictionary<byte, object>..ctor
	|
	|-RVA: 0x3CA4DB0 Offset: 0x3CA4EB1 VA: 0x3CA4DB0
	|-Dictionary<CancellationToken, object>..ctor
	|
	|-RVA: 0x3CA88B0 Offset: 0x3CA89B1 VA: 0x3CA88B0
	|-Dictionary<char, object>..ctor
	|
	|-RVA: 0x3CEFA80 Offset: 0x3CEFB81 VA: 0x3CEFA80
	|-Dictionary<GameObject, Stack<GameObject>>..ctor
	|-Dictionary<GameObject, GameObject>..ctor
	|-Dictionary<object, IList<IResourceLocation>>..ctor
	|-Dictionary<object, object>..ctor
	|-Dictionary<string, Stack<ResourceHandle>>..ctor
	|-Dictionary<string, AssetBundleLocalResource>..ctor
	|-Dictionary<string, GodBond>..ctor
	|-Dictionary<string, GodUnit>..ctor
	|-Dictionary<string, GodWeaponRefineLevels>..ctor
	|-Dictionary<string, GodWeaponRefineResult>..ctor
	|-Dictionary<string, string>..ctor
	|-Dictionary<string, Transform>..ctor
	|-Dictionary<string, UnitRelianceData>..ctor
	|-Dictionary<string, UriParser>..ctor
	|-Dictionary<Type, MonoCustomAttrs.AttributeInfo>..ctor
	|
	|-RVA: 0x3CAC3C0 Offset: 0x3CAC4C1 VA: 0x3CAC3C0
	|-Dictionary<Guid, object>..ctor
	|
	|-RVA: 0x3D5B120 Offset: 0x3D5B221 VA: 0x3D5B120
	|-Dictionary<int, List<AchieveData>>..ctor
	|-Dictionary<int, object>..ctor
	|-Dictionary<int, TimeType>..ctor
	|-Dictionary<int, MapEditor.EditObject>..ctor
	|-Dictionary<int, MapHistory.Rewind.OverlapData>..ctor
	|
	|-RVA: 0x3CAFF00 Offset: 0x3CB0001 VA: 0x3CAFF00
	|-Dictionary<int, bool>..ctor
	|
	|-RVA: 0x3CB39C0 Offset: 0x3CB3AC1 VA: 0x3CB39C0
	|-Dictionary<int, byte>..ctor
	|
	|-RVA: 0x3CB7480 Offset: 0x3CB7581 VA: 0x3CB7480
	|-Dictionary<int, char>..ctor
	|
	|-RVA: 0x3CBAF40 Offset: 0x3CBB041 VA: 0x3CBAF40
	|-Dictionary<int, DiagnosticEvent>..ctor
	|
	|-RVA: 0x3D4C550 Offset: 0x3D4C651 VA: 0x3D4C550
	|-Dictionary<int, int>..ctor
	|
	|-RVA: 0x3D4FFE0 Offset: 0x3D500E1 VA: 0x3D4FFE0
	|-Dictionary<int, Int32Enum>..ctor
	|-Dictionary<int, MapPanelTarget.DangerType>..ctor
	|
	|-RVA: 0x3D53A70 Offset: 0x3D53B71 VA: 0x3D53A70
	|-Dictionary<int, long>..ctor
	|
	|-RVA: 0x3D575D0 Offset: 0x3D576D1 VA: 0x3D575D0
	|-Dictionary<int, MapPos>..ctor
	|
	|-RVA: 0x3D5EC30 Offset: 0x3D5ED31 VA: 0x3D5EC30
	|-Dictionary<int, uint>..ctor
	|
	|-RVA: 0x3D626C0 Offset: 0x3D627C1 VA: 0x3D626C0
	|-Dictionary<int, AIThink.EnchantThink.SurroundingInfo>..ctor
	|
	|-RVA: 0x3CBEF70 Offset: 0x3CBF071 VA: 0x3CBEF70
	|-Dictionary<Int32Enum, bool>..ctor
	|
	|-RVA: 0x3CC2A30 Offset: 0x3CC2B31 VA: 0x3CC2A30
	|-Dictionary<Int32Enum, int>..ctor
	|
	|-RVA: 0x3CC64C0 Offset: 0x3CC65C1 VA: 0x3CC64C0
	|-Dictionary<Int32Enum, Int32Enum>..ctor
	|
	|-RVA: 0x3CC9F50 Offset: 0x3CCA051 VA: 0x3CC9F50
	|-Dictionary<Int32Enum, object>..ctor
	|
	|-RVA: 0x3CCDA60 Offset: 0x3CCDB61 VA: 0x3CCDA60
	|-Dictionary<long, object>..ctor
	|
	|-RVA: 0x3C92010 Offset: 0x3C92111 VA: 0x3C92010
	|-Dictionary<MapCollision, float>..ctor
	|-Dictionary<object, float>..ctor
	|
	|-RVA: 0x3CE46D0 Offset: 0x3CE47D1 VA: 0x3CE46D0
	|-Dictionary<MapEditorCategoryData, int>..ctor
	|-Dictionary<object, int>..ctor
	|-Dictionary<string, int>..ctor
	|
	|-RVA: 0x3CD1550 Offset: 0x3CD1651 VA: 0x3CD1550
	|-Dictionary<MapPos, int>..ctor
	|
	|-RVA: 0x3CD5090 Offset: 0x3CD5191 VA: 0x3CD5090
	|-Dictionary<object, AsyncOperationHandle<object>>..ctor
	|
	|-RVA: 0x3CD8FB0 Offset: 0x3CD90B1 VA: 0x3CD8FB0
	|-Dictionary<object, AsyncOperationHandle>..ctor
	|-Dictionary<string, AsyncOperationHandle>..ctor
	|
	|-RVA: 0x3CDCED0 Offset: 0x3CDCFD1 VA: 0x3CDCED0
	|-Dictionary<object, bool>..ctor
	|
	|-RVA: 0x3CE0AE0 Offset: 0x3CE0BE1 VA: 0x3CE0AE0
	|-Dictionary<object, byte>..ctor
	|-Dictionary<string, byte>..ctor
	|
	|-RVA: 0x3CE82C0 Offset: 0x3CE83C1 VA: 0x3CE82C0
	|-Dictionary<object, Int32Enum>..ctor
	|
	|-RVA: 0x3CEBEB0 Offset: 0x3CEBFB1 VA: 0x3CEBEB0
	|-Dictionary<object, IntPtr>..ctor
	|
	|-RVA: 0x3C8A830 Offset: 0x3C8A931 VA: 0x3C8A830
	|-Dictionary<object, Playable>..ctor
	|
	|-RVA: 0x3C8E410 Offset: 0x3C8E511 VA: 0x3C8E410
	|-Dictionary<object, ResourceLocator>..ctor
	|
	|-RVA: 0x3C95BF0 Offset: 0x3C95CF1 VA: 0x3C95BF0
	|-Dictionary<object, ushort>..ctor
	|
	|-RVA: 0x3C997E0 Offset: 0x3C998E1 VA: 0x3C997E0
	|-Dictionary<object, GameVariable.Value>..ctor
	|-Dictionary<string, GameVariable.Value>..ctor
	|
	|-RVA: 0x3C9D3E0 Offset: 0x3C9D4E1 VA: 0x3C9D3E0
	|-Dictionary<sbyte, DataStoreRatingInfo>..ctor
	|
	|-RVA: 0x3CA12A0 Offset: 0x3CA13A1 VA: 0x3CA12A0
	|-Dictionary<sbyte, object>..ctor
	|
	|-RVA: 0x3D321A0 Offset: 0x3D322A1 VA: 0x3D321A0
	|-Dictionary<ushort, int>..ctor
	|
	|-RVA: 0x3D35C60 Offset: 0x3D35D61 VA: 0x3D35C60
	|-Dictionary<uint, int>..ctor
	|
	|-RVA: 0x3D396F0 Offset: 0x3D397F1 VA: 0x3D396F0
	|-Dictionary<uint, object>..ctor
	|
	|-RVA: 0x3D3D200 Offset: 0x3D3D301 VA: 0x3D3D200
	|-Dictionary<ulong, Friend>..ctor
	|
	|-RVA: 0x3D41250 Offset: 0x3D41351 VA: 0x3D41250
	|-Dictionary<ulong, Int32Enum>..ctor
	|
	|-RVA: 0x3D44DC0 Offset: 0x3D44EC1 VA: 0x3D44DC0
	|-Dictionary<ulong, object>..ctor
	|
	|-RVA: 0x3D488B0 Offset: 0x3D489B1 VA: 0x3D488B0
	|-Dictionary<Vector3, int>..ctor
	|
	|-RVA: 0x2626CF0 Offset: 0x2626DF1 VA: 0x2626CF0
	|-Dictionary<XPathNodeRef, XPathNodeRef>..ctor
	|
	|-RVA: 0x262A990 Offset: 0x262AA91 VA: 0x262A990
	|-Dictionary<TerrainUtility.TerrainMap.TileCoord, object>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(IEqualityComparer<TKey> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x251C340 Offset: 0x251C441 VA: 0x251C340
	|-Dictionary<ValueTuple<object, int>, object>..ctor
	|
	|-RVA: 0x251FE90 Offset: 0x251FF91 VA: 0x251FE90
	|-Dictionary<byte, object>..ctor
	|
	|-RVA: 0x3CA4DD0 Offset: 0x3CA4ED1 VA: 0x3CA4DD0
	|-Dictionary<CancellationToken, object>..ctor
	|
	|-RVA: 0x3CA88D0 Offset: 0x3CA89D1 VA: 0x3CA88D0
	|-Dictionary<char, object>..ctor
	|
	|-RVA: 0x3CAC3E0 Offset: 0x3CAC4E1 VA: 0x3CAC3E0
	|-Dictionary<Guid, object>..ctor
	|
	|-RVA: 0x3CAFF20 Offset: 0x3CB0021 VA: 0x3CAFF20
	|-Dictionary<int, bool>..ctor
	|
	|-RVA: 0x3CB39E0 Offset: 0x3CB3AE1 VA: 0x3CB39E0
	|-Dictionary<int, byte>..ctor
	|
	|-RVA: 0x3CB74A0 Offset: 0x3CB75A1 VA: 0x3CB74A0
	|-Dictionary<int, char>..ctor
	|
	|-RVA: 0x3CBAF60 Offset: 0x3CBB061 VA: 0x3CBAF60
	|-Dictionary<int, DiagnosticEvent>..ctor
	|
	|-RVA: 0x3D4C570 Offset: 0x3D4C671 VA: 0x3D4C570
	|-Dictionary<int, int>..ctor
	|
	|-RVA: 0x3D50000 Offset: 0x3D50101 VA: 0x3D50000
	|-Dictionary<int, Int32Enum>..ctor
	|
	|-RVA: 0x3D53A90 Offset: 0x3D53B91 VA: 0x3D53A90
	|-Dictionary<int, long>..ctor
	|
	|-RVA: 0x3D575F0 Offset: 0x3D576F1 VA: 0x3D575F0
	|-Dictionary<int, MapPos>..ctor
	|
	|-RVA: 0x3D5B140 Offset: 0x3D5B241 VA: 0x3D5B140
	|-Dictionary<int, object>..ctor
	|
	|-RVA: 0x3D5EC50 Offset: 0x3D5ED51 VA: 0x3D5EC50
	|-Dictionary<int, uint>..ctor
	|
	|-RVA: 0x3D626E0 Offset: 0x3D627E1 VA: 0x3D626E0
	|-Dictionary<int, AIThink.EnchantThink.SurroundingInfo>..ctor
	|
	|-RVA: 0x3CBEF90 Offset: 0x3CBF091 VA: 0x3CBEF90
	|-Dictionary<Int32Enum, bool>..ctor
	|
	|-RVA: 0x3CC2A50 Offset: 0x3CC2B51 VA: 0x3CC2A50
	|-Dictionary<Int32Enum, int>..ctor
	|
	|-RVA: 0x3CC64E0 Offset: 0x3CC65E1 VA: 0x3CC64E0
	|-Dictionary<Int32Enum, Int32Enum>..ctor
	|
	|-RVA: 0x3CC9F70 Offset: 0x3CCA071 VA: 0x3CC9F70
	|-Dictionary<Int32Enum, object>..ctor
	|
	|-RVA: 0x3CCDA80 Offset: 0x3CCDB81 VA: 0x3CCDA80
	|-Dictionary<long, object>..ctor
	|
	|-RVA: 0x3CD1570 Offset: 0x3CD1671 VA: 0x3CD1570
	|-Dictionary<MapPos, int>..ctor
	|
	|-RVA: 0x3CD50B0 Offset: 0x3CD51B1 VA: 0x3CD50B0
	|-Dictionary<object, AsyncOperationHandle<object>>..ctor
	|
	|-RVA: 0x3CD8FD0 Offset: 0x3CD90D1 VA: 0x3CD8FD0
	|-Dictionary<object, AsyncOperationHandle>..ctor
	|
	|-RVA: 0x3CDCEF0 Offset: 0x3CDCFF1 VA: 0x3CDCEF0
	|-Dictionary<object, bool>..ctor
	|
	|-RVA: 0x3CE0B00 Offset: 0x3CE0C01 VA: 0x3CE0B00
	|-Dictionary<object, byte>..ctor
	|
	|-RVA: 0x3CEFAA0 Offset: 0x3CEFBA1 VA: 0x3CEFAA0
	|-Dictionary<object, Delegate>..ctor
	|-Dictionary<object, object>..ctor
	|-Dictionary<string, GUIStyle>..ctor
	|-Dictionary<string, SimpleCollator>..ctor
	|
	|-RVA: 0x3CE46F0 Offset: 0x3CE47F1 VA: 0x3CE46F0
	|-Dictionary<object, int>..ctor
	|
	|-RVA: 0x3CE82E0 Offset: 0x3CE83E1 VA: 0x3CE82E0
	|-Dictionary<object, Int32Enum>..ctor
	|
	|-RVA: 0x3CEBED0 Offset: 0x3CEBFD1 VA: 0x3CEBED0
	|-Dictionary<object, IntPtr>..ctor
	|
	|-RVA: 0x3C8A850 Offset: 0x3C8A951 VA: 0x3C8A850
	|-Dictionary<object, Playable>..ctor
	|
	|-RVA: 0x3C8E430 Offset: 0x3C8E531 VA: 0x3C8E430
	|-Dictionary<object, ResourceLocator>..ctor
	|-Dictionary<string, ResourceLocator>..ctor
	|
	|-RVA: 0x3C92030 Offset: 0x3C92131 VA: 0x3C92030
	|-Dictionary<object, float>..ctor
	|
	|-RVA: 0x3C95C10 Offset: 0x3C95D11 VA: 0x3C95C10
	|-Dictionary<object, ushort>..ctor
	|
	|-RVA: 0x3C99800 Offset: 0x3C99901 VA: 0x3C99800
	|-Dictionary<object, GameVariable.Value>..ctor
	|
	|-RVA: 0x3C9D400 Offset: 0x3C9D501 VA: 0x3C9D400
	|-Dictionary<sbyte, DataStoreRatingInfo>..ctor
	|
	|-RVA: 0x3CA12C0 Offset: 0x3CA13C1 VA: 0x3CA12C0
	|-Dictionary<sbyte, object>..ctor
	|
	|-RVA: 0x3D321C0 Offset: 0x3D322C1 VA: 0x3D321C0
	|-Dictionary<ushort, int>..ctor
	|
	|-RVA: 0x3D35C80 Offset: 0x3D35D81 VA: 0x3D35C80
	|-Dictionary<uint, int>..ctor
	|
	|-RVA: 0x3D39710 Offset: 0x3D39811 VA: 0x3D39710
	|-Dictionary<uint, object>..ctor
	|
	|-RVA: 0x3D3D220 Offset: 0x3D3D321 VA: 0x3D3D220
	|-Dictionary<ulong, Friend>..ctor
	|
	|-RVA: 0x3D41270 Offset: 0x3D41371 VA: 0x3D41270
	|-Dictionary<ulong, Int32Enum>..ctor
	|
	|-RVA: 0x3D44DE0 Offset: 0x3D44EE1 VA: 0x3D44DE0
	|-Dictionary<ulong, object>..ctor
	|
	|-RVA: 0x3D488D0 Offset: 0x3D489D1 VA: 0x3D488D0
	|-Dictionary<Vector3, int>..ctor
	|
	|-RVA: 0x2626D10 Offset: 0x2626E11 VA: 0x2626D10
	|-Dictionary<XPathNodeRef, XPathNodeRef>..ctor
	|
	|-RVA: 0x262A9B0 Offset: 0x262AAB1 VA: 0x262A9B0
	|-Dictionary<TerrainUtility.TerrainMap.TileCoord, object>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(int capacity, IEqualityComparer<TKey> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x251C360 Offset: 0x251C461 VA: 0x251C360
	|-Dictionary<ValueTuple<object, int>, object>..ctor
	|
	|-RVA: 0x251FEB0 Offset: 0x251FFB1 VA: 0x251FEB0
	|-Dictionary<byte, object>..ctor
	|
	|-RVA: 0x3CA4DF0 Offset: 0x3CA4EF1 VA: 0x3CA4DF0
	|-Dictionary<CancellationToken, object>..ctor
	|
	|-RVA: 0x3CA88F0 Offset: 0x3CA89F1 VA: 0x3CA88F0
	|-Dictionary<char, object>..ctor
	|
	|-RVA: 0x3CAC400 Offset: 0x3CAC501 VA: 0x3CAC400
	|-Dictionary<Guid, object>..ctor
	|
	|-RVA: 0x3CAFF40 Offset: 0x3CB0041 VA: 0x3CAFF40
	|-Dictionary<int, bool>..ctor
	|
	|-RVA: 0x3CB3A00 Offset: 0x3CB3B01 VA: 0x3CB3A00
	|-Dictionary<int, byte>..ctor
	|
	|-RVA: 0x3CB74C0 Offset: 0x3CB75C1 VA: 0x3CB74C0
	|-Dictionary<int, char>..ctor
	|
	|-RVA: 0x3CBAF80 Offset: 0x3CBB081 VA: 0x3CBAF80
	|-Dictionary<int, DiagnosticEvent>..ctor
	|
	|-RVA: 0x3D4C590 Offset: 0x3D4C691 VA: 0x3D4C590
	|-Dictionary<int, int>..ctor
	|
	|-RVA: 0x3D50020 Offset: 0x3D50121 VA: 0x3D50020
	|-Dictionary<int, Int32Enum>..ctor
	|
	|-RVA: 0x3D53AB0 Offset: 0x3D53BB1 VA: 0x3D53AB0
	|-Dictionary<int, long>..ctor
	|
	|-RVA: 0x3D57610 Offset: 0x3D57711 VA: 0x3D57610
	|-Dictionary<int, MapPos>..ctor
	|
	|-RVA: 0x3D5B160 Offset: 0x3D5B261 VA: 0x3D5B160
	|-Dictionary<int, object>..ctor
	|
	|-RVA: 0x3D5EC70 Offset: 0x3D5ED71 VA: 0x3D5EC70
	|-Dictionary<int, uint>..ctor
	|
	|-RVA: 0x3D62700 Offset: 0x3D62801 VA: 0x3D62700
	|-Dictionary<int, AIThink.EnchantThink.SurroundingInfo>..ctor
	|
	|-RVA: 0x3CBEFB0 Offset: 0x3CBF0B1 VA: 0x3CBEFB0
	|-Dictionary<Int32Enum, bool>..ctor
	|
	|-RVA: 0x3CC2A70 Offset: 0x3CC2B71 VA: 0x3CC2A70
	|-Dictionary<Int32Enum, int>..ctor
	|
	|-RVA: 0x3CC6500 Offset: 0x3CC6601 VA: 0x3CC6500
	|-Dictionary<Int32Enum, Int32Enum>..ctor
	|
	|-RVA: 0x3CC9F90 Offset: 0x3CCA091 VA: 0x3CC9F90
	|-Dictionary<Int32Enum, object>..ctor
	|
	|-RVA: 0x3CCDAA0 Offset: 0x3CCDBA1 VA: 0x3CCDAA0
	|-Dictionary<long, object>..ctor
	|
	|-RVA: 0x3CD1590 Offset: 0x3CD1691 VA: 0x3CD1590
	|-Dictionary<MapPos, int>..ctor
	|
	|-RVA: 0x3CD50D0 Offset: 0x3CD51D1 VA: 0x3CD50D0
	|-Dictionary<object, AsyncOperationHandle<object>>..ctor
	|
	|-RVA: 0x3CD8FF0 Offset: 0x3CD90F1 VA: 0x3CD8FF0
	|-Dictionary<object, AsyncOperationHandle>..ctor
	|
	|-RVA: 0x3CDCF10 Offset: 0x3CDD011 VA: 0x3CDCF10
	|-Dictionary<object, bool>..ctor
	|
	|-RVA: 0x3CE0B20 Offset: 0x3CE0C21 VA: 0x3CE0B20
	|-Dictionary<object, byte>..ctor
	|
	|-RVA: 0x3CE4710 Offset: 0x3CE4811 VA: 0x3CE4710
	|-Dictionary<object, int>..ctor
	|
	|-RVA: 0x3CE8300 Offset: 0x3CE8401 VA: 0x3CE8300
	|-Dictionary<object, Int32Enum>..ctor
	|
	|-RVA: 0x3CEBEF0 Offset: 0x3CEBFF1 VA: 0x3CEBEF0
	|-Dictionary<object, IntPtr>..ctor
	|
	|-RVA: 0x3CEFAC0 Offset: 0x3CEFBC1 VA: 0x3CEFAC0
	|-Dictionary<object, object>..ctor
	|-Dictionary<string, string>..ctor
	|
	|-RVA: 0x3C8A870 Offset: 0x3C8A971 VA: 0x3C8A870
	|-Dictionary<object, Playable>..ctor
	|
	|-RVA: 0x3C8E450 Offset: 0x3C8E551 VA: 0x3C8E450
	|-Dictionary<object, ResourceLocator>..ctor
	|
	|-RVA: 0x3C92050 Offset: 0x3C92151 VA: 0x3C92050
	|-Dictionary<object, float>..ctor
	|
	|-RVA: 0x3C95C30 Offset: 0x3C95D31 VA: 0x3C95C30
	|-Dictionary<object, ushort>..ctor
	|
	|-RVA: 0x3C99820 Offset: 0x3C99921 VA: 0x3C99820
	|-Dictionary<object, GameVariable.Value>..ctor
	|
	|-RVA: 0x3C9D420 Offset: 0x3C9D521 VA: 0x3C9D420
	|-Dictionary<sbyte, DataStoreRatingInfo>..ctor
	|
	|-RVA: 0x3CA12E0 Offset: 0x3CA13E1 VA: 0x3CA12E0
	|-Dictionary<sbyte, object>..ctor
	|
	|-RVA: 0x3D321E0 Offset: 0x3D322E1 VA: 0x3D321E0
	|-Dictionary<ushort, int>..ctor
	|
	|-RVA: 0x3D35CA0 Offset: 0x3D35DA1 VA: 0x3D35CA0
	|-Dictionary<uint, int>..ctor
	|
	|-RVA: 0x3D39730 Offset: 0x3D39831 VA: 0x3D39730
	|-Dictionary<uint, object>..ctor
	|
	|-RVA: 0x3D3D240 Offset: 0x3D3D341 VA: 0x3D3D240
	|-Dictionary<ulong, Friend>..ctor
	|
	|-RVA: 0x3D41290 Offset: 0x3D41391 VA: 0x3D41290
	|-Dictionary<ulong, Int32Enum>..ctor
	|
	|-RVA: 0x3D44E00 Offset: 0x3D44F01 VA: 0x3D44E00
	|-Dictionary<ulong, object>..ctor
	|
	|-RVA: 0x3D488F0 Offset: 0x3D489F1 VA: 0x3D488F0
	|-Dictionary<Vector3, int>..ctor
	|
	|-RVA: 0x2626D30 Offset: 0x2626E31 VA: 0x2626D30
	|-Dictionary<XPathNodeRef, XPathNodeRef>..ctor
	|
	|-RVA: 0x262A9D0 Offset: 0x262AAD1 VA: 0x262A9D0
	|-Dictionary<TerrainUtility.TerrainMap.TileCoord, object>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(IDictionary<TKey, TValue> dictionary) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x251C470 Offset: 0x251C571 VA: 0x251C470
	|-Dictionary<ValueTuple<object, int>, object>..ctor
	|
	|-RVA: 0x251FFC0 Offset: 0x25200C1 VA: 0x251FFC0
	|-Dictionary<byte, object>..ctor
	|
	|-RVA: 0x3CA4F00 Offset: 0x3CA5001 VA: 0x3CA4F00
	|-Dictionary<CancellationToken, object>..ctor
	|
	|-RVA: 0x3CA8A00 Offset: 0x3CA8B01 VA: 0x3CA8A00
	|-Dictionary<char, object>..ctor
	|
	|-RVA: 0x3CAC510 Offset: 0x3CAC611 VA: 0x3CAC510
	|-Dictionary<Guid, object>..ctor
	|
	|-RVA: 0x3CEFBD0 Offset: 0x3CEFCD1 VA: 0x3CEFBD0
	|-Dictionary<IAsyncLocal, object>..ctor
	|-Dictionary<object, object>..ctor
	|-Dictionary<string, RelayAwardeeData>..ctor
	|
	|-RVA: 0x3CB0050 Offset: 0x3CB0151 VA: 0x3CB0050
	|-Dictionary<int, bool>..ctor
	|
	|-RVA: 0x3CB3B10 Offset: 0x3CB3C11 VA: 0x3CB3B10
	|-Dictionary<int, byte>..ctor
	|
	|-RVA: 0x3CB75D0 Offset: 0x3CB76D1 VA: 0x3CB75D0
	|-Dictionary<int, char>..ctor
	|
	|-RVA: 0x3CBB090 Offset: 0x3CBB191 VA: 0x3CBB090
	|-Dictionary<int, DiagnosticEvent>..ctor
	|
	|-RVA: 0x3D4C6A0 Offset: 0x3D4C7A1 VA: 0x3D4C6A0
	|-Dictionary<int, int>..ctor
	|
	|-RVA: 0x3D50130 Offset: 0x3D50231 VA: 0x3D50130
	|-Dictionary<int, Int32Enum>..ctor
	|
	|-RVA: 0x3D53BC0 Offset: 0x3D53CC1 VA: 0x3D53BC0
	|-Dictionary<int, long>..ctor
	|
	|-RVA: 0x3D57720 Offset: 0x3D57821 VA: 0x3D57720
	|-Dictionary<int, MapPos>..ctor
	|
	|-RVA: 0x3D5B270 Offset: 0x3D5B371 VA: 0x3D5B270
	|-Dictionary<int, object>..ctor
	|
	|-RVA: 0x3D5ED80 Offset: 0x3D5EE81 VA: 0x3D5ED80
	|-Dictionary<int, uint>..ctor
	|
	|-RVA: 0x3D62810 Offset: 0x3D62911 VA: 0x3D62810
	|-Dictionary<int, AIThink.EnchantThink.SurroundingInfo>..ctor
	|
	|-RVA: 0x3CBF0C0 Offset: 0x3CBF1C1 VA: 0x3CBF0C0
	|-Dictionary<Int32Enum, bool>..ctor
	|
	|-RVA: 0x3CC2B80 Offset: 0x3CC2C81 VA: 0x3CC2B80
	|-Dictionary<Int32Enum, int>..ctor
	|
	|-RVA: 0x3CC6610 Offset: 0x3CC6711 VA: 0x3CC6610
	|-Dictionary<Int32Enum, Int32Enum>..ctor
	|
	|-RVA: 0x3CCA0A0 Offset: 0x3CCA1A1 VA: 0x3CCA0A0
	|-Dictionary<Int32Enum, object>..ctor
	|
	|-RVA: 0x3CCDBB0 Offset: 0x3CCDCB1 VA: 0x3CCDBB0
	|-Dictionary<long, object>..ctor
	|
	|-RVA: 0x3CD16A0 Offset: 0x3CD17A1 VA: 0x3CD16A0
	|-Dictionary<MapPos, int>..ctor
	|
	|-RVA: 0x3CD51E0 Offset: 0x3CD52E1 VA: 0x3CD51E0
	|-Dictionary<object, AsyncOperationHandle<object>>..ctor
	|
	|-RVA: 0x3CD9100 Offset: 0x3CD9201 VA: 0x3CD9100
	|-Dictionary<object, AsyncOperationHandle>..ctor
	|
	|-RVA: 0x3CDD020 Offset: 0x3CDD121 VA: 0x3CDD020
	|-Dictionary<object, bool>..ctor
	|
	|-RVA: 0x3CE0C30 Offset: 0x3CE0D31 VA: 0x3CE0C30
	|-Dictionary<object, byte>..ctor
	|
	|-RVA: 0x3CE4820 Offset: 0x3CE4921 VA: 0x3CE4820
	|-Dictionary<object, int>..ctor
	|
	|-RVA: 0x3CE8410 Offset: 0x3CE8511 VA: 0x3CE8410
	|-Dictionary<object, Int32Enum>..ctor
	|
	|-RVA: 0x3CEC000 Offset: 0x3CEC101 VA: 0x3CEC000
	|-Dictionary<object, IntPtr>..ctor
	|
	|-RVA: 0x3C8A980 Offset: 0x3C8AA81 VA: 0x3C8A980
	|-Dictionary<object, Playable>..ctor
	|
	|-RVA: 0x3C8E560 Offset: 0x3C8E661 VA: 0x3C8E560
	|-Dictionary<object, ResourceLocator>..ctor
	|
	|-RVA: 0x3C92160 Offset: 0x3C92261 VA: 0x3C92160
	|-Dictionary<object, float>..ctor
	|
	|-RVA: 0x3C95D40 Offset: 0x3C95E41 VA: 0x3C95D40
	|-Dictionary<object, ushort>..ctor
	|
	|-RVA: 0x3C99930 Offset: 0x3C99A31 VA: 0x3C99930
	|-Dictionary<object, GameVariable.Value>..ctor
	|
	|-RVA: 0x3C9D530 Offset: 0x3C9D631 VA: 0x3C9D530
	|-Dictionary<sbyte, DataStoreRatingInfo>..ctor
	|
	|-RVA: 0x3CA13F0 Offset: 0x3CA14F1 VA: 0x3CA13F0
	|-Dictionary<sbyte, object>..ctor
	|
	|-RVA: 0x3D322F0 Offset: 0x3D323F1 VA: 0x3D322F0
	|-Dictionary<ushort, int>..ctor
	|
	|-RVA: 0x3D35DB0 Offset: 0x3D35EB1 VA: 0x3D35DB0
	|-Dictionary<uint, int>..ctor
	|
	|-RVA: 0x3D39840 Offset: 0x3D39941 VA: 0x3D39840
	|-Dictionary<uint, object>..ctor
	|
	|-RVA: 0x3D3D350 Offset: 0x3D3D451 VA: 0x3D3D350
	|-Dictionary<ulong, Friend>..ctor
	|
	|-RVA: 0x3D413A0 Offset: 0x3D414A1 VA: 0x3D413A0
	|-Dictionary<ulong, Int32Enum>..ctor
	|
	|-RVA: 0x3D44F10 Offset: 0x3D45011 VA: 0x3D44F10
	|-Dictionary<ulong, object>..ctor
	|
	|-RVA: 0x3D48A00 Offset: 0x3D48B01 VA: 0x3D48A00
	|-Dictionary<Vector3, int>..ctor
	|
	|-RVA: 0x2626E40 Offset: 0x2626F41 VA: 0x2626E40
	|-Dictionary<XPathNodeRef, XPathNodeRef>..ctor
	|
	|-RVA: 0x262AAE0 Offset: 0x262ABE1 VA: 0x262AAE0
	|-Dictionary<TerrainUtility.TerrainMap.TileCoord, object>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(IDictionary<TKey, TValue> dictionary, IEqualityComparer<TKey> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x251C490 Offset: 0x251C591 VA: 0x251C490
	|-Dictionary<ValueTuple<object, int>, object>..ctor
	|
	|-RVA: 0x251FFE0 Offset: 0x25200E1 VA: 0x251FFE0
	|-Dictionary<byte, object>..ctor
	|
	|-RVA: 0x3CA4F20 Offset: 0x3CA5021 VA: 0x3CA4F20
	|-Dictionary<CancellationToken, object>..ctor
	|
	|-RVA: 0x3CA8A20 Offset: 0x3CA8B21 VA: 0x3CA8A20
	|-Dictionary<char, object>..ctor
	|
	|-RVA: 0x3CAC530 Offset: 0x3CAC631 VA: 0x3CAC530
	|-Dictionary<Guid, object>..ctor
	|
	|-RVA: 0x3CB0070 Offset: 0x3CB0171 VA: 0x3CB0070
	|-Dictionary<int, bool>..ctor
	|
	|-RVA: 0x3CB3B30 Offset: 0x3CB3C31 VA: 0x3CB3B30
	|-Dictionary<int, byte>..ctor
	|
	|-RVA: 0x3CB75F0 Offset: 0x3CB76F1 VA: 0x3CB75F0
	|-Dictionary<int, char>..ctor
	|
	|-RVA: 0x3CBB0B0 Offset: 0x3CBB1B1 VA: 0x3CBB0B0
	|-Dictionary<int, DiagnosticEvent>..ctor
	|
	|-RVA: 0x3D4C6C0 Offset: 0x3D4C7C1 VA: 0x3D4C6C0
	|-Dictionary<int, int>..ctor
	|
	|-RVA: 0x3D50150 Offset: 0x3D50251 VA: 0x3D50150
	|-Dictionary<int, Int32Enum>..ctor
	|
	|-RVA: 0x3D53BE0 Offset: 0x3D53CE1 VA: 0x3D53BE0
	|-Dictionary<int, long>..ctor
	|
	|-RVA: 0x3D57740 Offset: 0x3D57841 VA: 0x3D57740
	|-Dictionary<int, MapPos>..ctor
	|
	|-RVA: 0x3D5B290 Offset: 0x3D5B391 VA: 0x3D5B290
	|-Dictionary<int, object>..ctor
	|
	|-RVA: 0x3D5EDA0 Offset: 0x3D5EEA1 VA: 0x3D5EDA0
	|-Dictionary<int, uint>..ctor
	|
	|-RVA: 0x3D62830 Offset: 0x3D62931 VA: 0x3D62830
	|-Dictionary<int, AIThink.EnchantThink.SurroundingInfo>..ctor
	|
	|-RVA: 0x3CBF0E0 Offset: 0x3CBF1E1 VA: 0x3CBF0E0
	|-Dictionary<Int32Enum, bool>..ctor
	|
	|-RVA: 0x3CC2BA0 Offset: 0x3CC2CA1 VA: 0x3CC2BA0
	|-Dictionary<Int32Enum, int>..ctor
	|
	|-RVA: 0x3CC6630 Offset: 0x3CC6731 VA: 0x3CC6630
	|-Dictionary<Int32Enum, Int32Enum>..ctor
	|
	|-RVA: 0x3CCA0C0 Offset: 0x3CCA1C1 VA: 0x3CCA0C0
	|-Dictionary<Int32Enum, object>..ctor
	|
	|-RVA: 0x3CCDBD0 Offset: 0x3CCDCD1 VA: 0x3CCDBD0
	|-Dictionary<long, object>..ctor
	|
	|-RVA: 0x3CD16C0 Offset: 0x3CD17C1 VA: 0x3CD16C0
	|-Dictionary<MapPos, int>..ctor
	|
	|-RVA: 0x3CD5200 Offset: 0x3CD5301 VA: 0x3CD5200
	|-Dictionary<object, AsyncOperationHandle<object>>..ctor
	|
	|-RVA: 0x3CD9120 Offset: 0x3CD9221 VA: 0x3CD9120
	|-Dictionary<object, AsyncOperationHandle>..ctor
	|
	|-RVA: 0x3CDD040 Offset: 0x3CDD141 VA: 0x3CDD040
	|-Dictionary<object, bool>..ctor
	|
	|-RVA: 0x3CE0C50 Offset: 0x3CE0D51 VA: 0x3CE0C50
	|-Dictionary<object, byte>..ctor
	|
	|-RVA: 0x3CE4840 Offset: 0x3CE4941 VA: 0x3CE4840
	|-Dictionary<object, int>..ctor
	|
	|-RVA: 0x3CE8430 Offset: 0x3CE8531 VA: 0x3CE8430
	|-Dictionary<object, Int32Enum>..ctor
	|
	|-RVA: 0x3CEC020 Offset: 0x3CEC121 VA: 0x3CEC020
	|-Dictionary<object, IntPtr>..ctor
	|
	|-RVA: 0x3CEFBF0 Offset: 0x3CEFCF1 VA: 0x3CEFBF0
	|-Dictionary<object, object>..ctor
	|
	|-RVA: 0x3C8A9A0 Offset: 0x3C8AAA1 VA: 0x3C8A9A0
	|-Dictionary<object, Playable>..ctor
	|
	|-RVA: 0x3C8E580 Offset: 0x3C8E681 VA: 0x3C8E580
	|-Dictionary<object, ResourceLocator>..ctor
	|
	|-RVA: 0x3C92180 Offset: 0x3C92281 VA: 0x3C92180
	|-Dictionary<object, float>..ctor
	|
	|-RVA: 0x3C95D60 Offset: 0x3C95E61 VA: 0x3C95D60
	|-Dictionary<object, ushort>..ctor
	|
	|-RVA: 0x3C99950 Offset: 0x3C99A51 VA: 0x3C99950
	|-Dictionary<object, GameVariable.Value>..ctor
	|
	|-RVA: 0x3C9D550 Offset: 0x3C9D651 VA: 0x3C9D550
	|-Dictionary<sbyte, DataStoreRatingInfo>..ctor
	|
	|-RVA: 0x3CA1410 Offset: 0x3CA1511 VA: 0x3CA1410
	|-Dictionary<sbyte, object>..ctor
	|
	|-RVA: 0x3D32310 Offset: 0x3D32411 VA: 0x3D32310
	|-Dictionary<ushort, int>..ctor
	|
	|-RVA: 0x3D35DD0 Offset: 0x3D35ED1 VA: 0x3D35DD0
	|-Dictionary<uint, int>..ctor
	|
	|-RVA: 0x3D39860 Offset: 0x3D39961 VA: 0x3D39860
	|-Dictionary<uint, object>..ctor
	|
	|-RVA: 0x3D3D370 Offset: 0x3D3D471 VA: 0x3D3D370
	|-Dictionary<ulong, Friend>..ctor
	|
	|-RVA: 0x3D413C0 Offset: 0x3D414C1 VA: 0x3D413C0
	|-Dictionary<ulong, Int32Enum>..ctor
	|
	|-RVA: 0x3D44F30 Offset: 0x3D45031 VA: 0x3D44F30
	|-Dictionary<ulong, object>..ctor
	|
	|-RVA: 0x3D48A20 Offset: 0x3D48B21 VA: 0x3D48A20
	|-Dictionary<Vector3, int>..ctor
	|
	|-RVA: 0x2626E60 Offset: 0x2626F61 VA: 0x2626E60
	|-Dictionary<XPathNodeRef, XPathNodeRef>..ctor
	|
	|-RVA: 0x262AB00 Offset: 0x262AC01 VA: 0x262AB00
	|-Dictionary<TerrainUtility.TerrainMap.TileCoord, object>..ctor
	*/

	// RVA: -1 Offset: -1
	protected void .ctor(SerializationInfo info, StreamingContext context) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x251C950 Offset: 0x251CA51 VA: 0x251C950
	|-Dictionary<ValueTuple<object, int>, object>..ctor
	|
	|-RVA: 0x25204A0 Offset: 0x25205A1 VA: 0x25204A0
	|-Dictionary<byte, object>..ctor
	|
	|-RVA: 0x3CA53E0 Offset: 0x3CA54E1 VA: 0x3CA53E0
	|-Dictionary<CancellationToken, object>..ctor
	|
	|-RVA: 0x3CA8EE0 Offset: 0x3CA8FE1 VA: 0x3CA8EE0
	|-Dictionary<char, object>..ctor
	|
	|-RVA: 0x3CAC9F0 Offset: 0x3CACAF1 VA: 0x3CAC9F0
	|-Dictionary<Guid, object>..ctor
	|
	|-RVA: 0x3CB0530 Offset: 0x3CB0631 VA: 0x3CB0530
	|-Dictionary<int, bool>..ctor
	|
	|-RVA: 0x3CB3FF0 Offset: 0x3CB40F1 VA: 0x3CB3FF0
	|-Dictionary<int, byte>..ctor
	|
	|-RVA: 0x3CB7AB0 Offset: 0x3CB7BB1 VA: 0x3CB7AB0
	|-Dictionary<int, char>..ctor
	|
	|-RVA: 0x3CBB600 Offset: 0x3CBB701 VA: 0x3CBB600
	|-Dictionary<int, DiagnosticEvent>..ctor
	|
	|-RVA: 0x3D4CB70 Offset: 0x3D4CC71 VA: 0x3D4CB70
	|-Dictionary<int, int>..ctor
	|
	|-RVA: 0x3D50600 Offset: 0x3D50701 VA: 0x3D50600
	|-Dictionary<int, Int32Enum>..ctor
	|
	|-RVA: 0x3D540A0 Offset: 0x3D541A1 VA: 0x3D540A0
	|-Dictionary<int, long>..ctor
	|
	|-RVA: 0x3D57C10 Offset: 0x3D57D11 VA: 0x3D57C10
	|-Dictionary<int, MapPos>..ctor
	|
	|-RVA: 0x3D5B750 Offset: 0x3D5B851 VA: 0x3D5B750
	|-Dictionary<int, object>..ctor
	|
	|-RVA: 0x3D5F250 Offset: 0x3D5F351 VA: 0x3D5F250
	|-Dictionary<int, uint>..ctor
	|
	|-RVA: 0x3D62CE0 Offset: 0x3D62DE1 VA: 0x3D62CE0
	|-Dictionary<int, AIThink.EnchantThink.SurroundingInfo>..ctor
	|
	|-RVA: 0x3CBF5A0 Offset: 0x3CBF6A1 VA: 0x3CBF5A0
	|-Dictionary<Int32Enum, bool>..ctor
	|
	|-RVA: 0x3CC3050 Offset: 0x3CC3151 VA: 0x3CC3050
	|-Dictionary<Int32Enum, int>..ctor
	|
	|-RVA: 0x3CC6AE0 Offset: 0x3CC6BE1 VA: 0x3CC6AE0
	|-Dictionary<Int32Enum, Int32Enum>..ctor
	|
	|-RVA: 0x3CCA580 Offset: 0x3CCA681 VA: 0x3CCA580
	|-Dictionary<Int32Enum, object>..ctor
	|
	|-RVA: 0x3CCE090 Offset: 0x3CCE191 VA: 0x3CCE090
	|-Dictionary<long, object>..ctor
	|
	|-RVA: 0x3CD1B80 Offset: 0x3CD1C81 VA: 0x3CD1B80
	|-Dictionary<MapPos, int>..ctor
	|
	|-RVA: 0x3CD5700 Offset: 0x3CD5801 VA: 0x3CD5700
	|-Dictionary<object, AsyncOperationHandle<object>>..ctor
	|
	|-RVA: 0x3CD9620 Offset: 0x3CD9721 VA: 0x3CD9620
	|-Dictionary<object, AsyncOperationHandle>..ctor
	|
	|-RVA: 0x3CDD500 Offset: 0x3CDD601 VA: 0x3CDD500
	|-Dictionary<object, bool>..ctor
	|
	|-RVA: 0x3CE1110 Offset: 0x3CE1211 VA: 0x3CE1110
	|-Dictionary<object, byte>..ctor
	|
	|-RVA: 0x3CE4D00 Offset: 0x3CE4E01 VA: 0x3CE4D00
	|-Dictionary<object, int>..ctor
	|
	|-RVA: 0x3CE88F0 Offset: 0x3CE89F1 VA: 0x3CE88F0
	|-Dictionary<object, Int32Enum>..ctor
	|
	|-RVA: 0x3CEC4E0 Offset: 0x3CEC5E1 VA: 0x3CEC4E0
	|-Dictionary<object, IntPtr>..ctor
	|
	|-RVA: 0x3CF00B0 Offset: 0x3CF01B1 VA: 0x3CF00B0
	|-Dictionary<object, object>..ctor
	|
	|-RVA: 0x3C8AE60 Offset: 0x3C8AF61 VA: 0x3C8AE60
	|-Dictionary<object, Playable>..ctor
	|
	|-RVA: 0x3C8EA40 Offset: 0x3C8EB41 VA: 0x3C8EA40
	|-Dictionary<object, ResourceLocator>..ctor
	|
	|-RVA: 0x3C92640 Offset: 0x3C92741 VA: 0x3C92640
	|-Dictionary<object, float>..ctor
	|
	|-RVA: 0x3C96220 Offset: 0x3C96321 VA: 0x3C96220
	|-Dictionary<object, ushort>..ctor
	|
	|-RVA: 0x3C99E10 Offset: 0x3C99F11 VA: 0x3C99E10
	|-Dictionary<object, GameVariable.Value>..ctor
	|
	|-RVA: 0x3C9DA80 Offset: 0x3C9DB81 VA: 0x3C9DA80
	|-Dictionary<sbyte, DataStoreRatingInfo>..ctor
	|
	|-RVA: 0x3CA18D0 Offset: 0x3CA19D1 VA: 0x3CA18D0
	|-Dictionary<sbyte, object>..ctor
	|
	|-RVA: 0x3D327D0 Offset: 0x3D328D1 VA: 0x3D327D0
	|-Dictionary<ushort, int>..ctor
	|
	|-RVA: 0x3D36280 Offset: 0x3D36381 VA: 0x3D36280
	|-Dictionary<uint, int>..ctor
	|
	|-RVA: 0x3D39D20 Offset: 0x3D39E21 VA: 0x3D39D20
	|-Dictionary<uint, object>..ctor
	|
	|-RVA: 0x3D3D8B0 Offset: 0x3D3D9B1 VA: 0x3D3D8B0
	|-Dictionary<ulong, Friend>..ctor
	|
	|-RVA: 0x3D41880 Offset: 0x3D41981 VA: 0x3D41880
	|-Dictionary<ulong, Int32Enum>..ctor
	|
	|-RVA: 0x3D453F0 Offset: 0x3D454F1 VA: 0x3D453F0
	|-Dictionary<ulong, object>..ctor
	|
	|-RVA: 0x3D48EF0 Offset: 0x3D48FF1 VA: 0x3D48EF0
	|-Dictionary<Vector3, int>..ctor
	|
	|-RVA: 0x2627320 Offset: 0x2627421 VA: 0x2627320
	|-Dictionary<XPathNodeRef, XPathNodeRef>..ctor
	|
	|-RVA: 0x262AFC0 Offset: 0x262B0C1 VA: 0x262AFC0
	|-Dictionary<TerrainUtility.TerrainMap.TileCoord, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 31
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x251CA40 Offset: 0x251CB41 VA: 0x251CA40
	|-Dictionary<ValueTuple<object, int>, object>.get_Count
	|
	|-RVA: 0x2520590 Offset: 0x2520691 VA: 0x2520590
	|-Dictionary<byte, object>.get_Count
	|
	|-RVA: 0x3CA54D0 Offset: 0x3CA55D1 VA: 0x3CA54D0
	|-Dictionary<CancellationToken, object>.get_Count
	|
	|-RVA: 0x3CA8FD0 Offset: 0x3CA90D1 VA: 0x3CA8FD0
	|-Dictionary<char, object>.get_Count
	|
	|-RVA: 0x3CF01A0 Offset: 0x3CF02A1 VA: 0x3CF01A0
	|-Dictionary<Font, HashSet<Text>>.get_Count
	|-Dictionary<IOperationCacheKey, IAsyncOperation>.get_Count
	|-Dictionary<ItemData, ChallengeMapSelectRoot.ItemDropNum>.get_Count
	|-Dictionary<object, object>.get_Count
	|-Dictionary<ParameterExpression, LocalVariable>.get_Count
	|-Dictionary<string, Stack<ResourceHandle>>.get_Count
	|-Dictionary<string, GodBond>.get_Count
	|-Dictionary<string, GodWeaponRefineLevels>.get_Count
	|-Dictionary<string, RelayAwardeeData>.get_Count
	|-Dictionary<string, Sprite>.get_Count
	|-Dictionary<string, string>.get_Count
	|-Dictionary<string, SymbolRef>.get_Count
	|-Dictionary<string, UnitRelianceData>.get_Count
	|-Dictionary<string, UriParser>.get_Count
	|-Dictionary<string, GameUserRestartData.Growth>.get_Count
	|-Dictionary<string, ServicePointScheduler.ConnectionGroup>.get_Count
	|-Dictionary<string, SoundWwise.SoundPrepareManager.SwitchParam>.get_Count
	|-Dictionary<Unit, string>.get_Count
	|-Dictionary<XmlQualifiedName, XmlSchemaObject>.get_Count
	|
	|-RVA: 0x3CE4DF0 Offset: 0x3CE4EF1 VA: 0x3CE4DF0
	|-Dictionary<FoodstuffData, int>.get_Count
	|-Dictionary<ItemData, int>.get_Count
	|-Dictionary<object, int>.get_Count
	|-Dictionary<string, int>.get_Count
	|-Dictionary<SymbolRef, int>.get_Count
	|-Dictionary<Unit, int>.get_Count
	|
	|-RVA: 0x3CACAE0 Offset: 0x3CACBE1 VA: 0x3CACAE0
	|-Dictionary<Guid, object>.get_Count
	|
	|-RVA: 0x3CB0620 Offset: 0x3CB0721 VA: 0x3CB0620
	|-Dictionary<int, bool>.get_Count
	|
	|-RVA: 0x3CB40E0 Offset: 0x3CB41E1 VA: 0x3CB40E0
	|-Dictionary<int, byte>.get_Count
	|
	|-RVA: 0x3D5B840 Offset: 0x3D5B941 VA: 0x3D5B840
	|-Dictionary<int, CalculatorCommand>.get_Count
	|-Dictionary<int, MapInfoIconLocatorRoot>.get_Count
	|-Dictionary<int, object>.get_Count
	|-Dictionary<int, TimeType>.get_Count
	|-Dictionary<int, TerrainUtility.TerrainMap>.get_Count
	|
	|-RVA: 0x3CB7BA0 Offset: 0x3CB7CA1 VA: 0x3CB7BA0
	|-Dictionary<int, char>.get_Count
	|
	|-RVA: 0x3CBB6F0 Offset: 0x3CBB7F1 VA: 0x3CBB6F0
	|-Dictionary<int, DiagnosticEvent>.get_Count
	|
	|-RVA: 0x3D4CC60 Offset: 0x3D4CD61 VA: 0x3D4CC60
	|-Dictionary<int, int>.get_Count
	|
	|-RVA: 0x3D506F0 Offset: 0x3D507F1 VA: 0x3D506F0
	|-Dictionary<int, Int32Enum>.get_Count
	|
	|-RVA: 0x3D54190 Offset: 0x3D54291 VA: 0x3D54190
	|-Dictionary<int, long>.get_Count
	|
	|-RVA: 0x3D57D00 Offset: 0x3D57E01 VA: 0x3D57D00
	|-Dictionary<int, MapPos>.get_Count
	|
	|-RVA: 0x3D5F340 Offset: 0x3D5F441 VA: 0x3D5F340
	|-Dictionary<int, uint>.get_Count
	|
	|-RVA: 0x3D62DD0 Offset: 0x3D62ED1 VA: 0x3D62DD0
	|-Dictionary<int, AIThink.EnchantThink.SurroundingInfo>.get_Count
	|
	|-RVA: 0x3CBF690 Offset: 0x3CBF791 VA: 0x3CBF690
	|-Dictionary<Int32Enum, bool>.get_Count
	|
	|-RVA: 0x3CC3140 Offset: 0x3CC3241 VA: 0x3CC3140
	|-Dictionary<Int32Enum, int>.get_Count
	|
	|-RVA: 0x3CC6BD0 Offset: 0x3CC6CD1 VA: 0x3CC6BD0
	|-Dictionary<Int32Enum, Int32Enum>.get_Count
	|
	|-RVA: 0x3CCA670 Offset: 0x3CCA771 VA: 0x3CCA670
	|-Dictionary<Int32Enum, object>.get_Count
	|
	|-RVA: 0x3CCE180 Offset: 0x3CCE281 VA: 0x3CCE180
	|-Dictionary<long, object>.get_Count
	|
	|-RVA: 0x3CD1C70 Offset: 0x3CD1D71 VA: 0x3CD1C70
	|-Dictionary<MapPos, int>.get_Count
	|
	|-RVA: 0x3CD57F0 Offset: 0x3CD58F1 VA: 0x3CD57F0
	|-Dictionary<object, AsyncOperationHandle<object>>.get_Count
	|
	|-RVA: 0x3CD9710 Offset: 0x3CD9811 VA: 0x3CD9710
	|-Dictionary<object, AsyncOperationHandle>.get_Count
	|
	|-RVA: 0x3CDD5F0 Offset: 0x3CDD6F1 VA: 0x3CDD5F0
	|-Dictionary<object, bool>.get_Count
	|
	|-RVA: 0x3CE1200 Offset: 0x3CE1301 VA: 0x3CE1200
	|-Dictionary<object, byte>.get_Count
	|
	|-RVA: 0x3CE89E0 Offset: 0x3CE8AE1 VA: 0x3CE89E0
	|-Dictionary<object, Int32Enum>.get_Count
	|
	|-RVA: 0x3CEC5D0 Offset: 0x3CEC6D1 VA: 0x3CEC5D0
	|-Dictionary<object, IntPtr>.get_Count
	|
	|-RVA: 0x3C8AF50 Offset: 0x3C8B051 VA: 0x3C8AF50
	|-Dictionary<object, Playable>.get_Count
	|
	|-RVA: 0x3C8EB30 Offset: 0x3C8EC31 VA: 0x3C8EB30
	|-Dictionary<object, ResourceLocator>.get_Count
	|
	|-RVA: 0x3C92730 Offset: 0x3C92831 VA: 0x3C92730
	|-Dictionary<object, float>.get_Count
	|
	|-RVA: 0x3C96310 Offset: 0x3C96411 VA: 0x3C96310
	|-Dictionary<object, ushort>.get_Count
	|
	|-RVA: 0x3C99F00 Offset: 0x3C9A001 VA: 0x3C99F00
	|-Dictionary<object, GameVariable.Value>.get_Count
	|-Dictionary<string, GameVariable.Value>.get_Count
	|
	|-RVA: 0x3C9DB70 Offset: 0x3C9DC71 VA: 0x3C9DB70
	|-Dictionary<sbyte, DataStoreRatingInfo>.get_Count
	|
	|-RVA: 0x3CA19C0 Offset: 0x3CA1AC1 VA: 0x3CA19C0
	|-Dictionary<sbyte, DataStoreRatingInitParam>.get_Count
	|-Dictionary<sbyte, object>.get_Count
	|
	|-RVA: 0x3D328C0 Offset: 0x3D329C1 VA: 0x3D328C0
	|-Dictionary<ushort, int>.get_Count
	|
	|-RVA: 0x3D36370 Offset: 0x3D36471 VA: 0x3D36370
	|-Dictionary<uint, int>.get_Count
	|
	|-RVA: 0x3D39E10 Offset: 0x3D39F11 VA: 0x3D39E10
	|-Dictionary<uint, object>.get_Count
	|
	|-RVA: 0x3D3D9A0 Offset: 0x3D3DAA1 VA: 0x3D3D9A0
	|-Dictionary<ulong, Friend>.get_Count
	|
	|-RVA: 0x3D41970 Offset: 0x3D41A71 VA: 0x3D41970
	|-Dictionary<ulong, Int32Enum>.get_Count
	|-Dictionary<ulong, NexVersus.TargetSlotList.Results>.get_Count
	|
	|-RVA: 0x3D454E0 Offset: 0x3D455E1 VA: 0x3D454E0
	|-Dictionary<ulong, object>.get_Count
	|-Dictionary<ulong, RelayUserGlobalData.Ticket>.get_Count
	|
	|-RVA: 0x3D48FE0 Offset: 0x3D490E1 VA: 0x3D48FE0
	|-Dictionary<Vector3, int>.get_Count
	|
	|-RVA: 0x2627410 Offset: 0x2627511 VA: 0x2627410
	|-Dictionary<XPathNodeRef, XPathNodeRef>.get_Count
	|
	|-RVA: 0x262B0B0 Offset: 0x262B1B1 VA: 0x262B0B0
	|-Dictionary<TerrainUtility.TerrainMap.TileCoord, object>.get_Count
	|-Dictionary<TerrainUtility.TerrainMap.TileCoord, Terrain>.get_Count
	*/

	// RVA: -1 Offset: -1
	public Dictionary.KeyCollection<TKey, TValue> get_Keys() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x251CA50 Offset: 0x251CB51 VA: 0x251CA50
	|-Dictionary<ValueTuple<object, int>, object>.get_Keys
	|
	|-RVA: 0x25205A0 Offset: 0x25206A1 VA: 0x25205A0
	|-Dictionary<byte, object>.get_Keys
	|
	|-RVA: 0x3CA54E0 Offset: 0x3CA55E1 VA: 0x3CA54E0
	|-Dictionary<CancellationToken, object>.get_Keys
	|
	|-RVA: 0x3CA8FE0 Offset: 0x3CA90E1 VA: 0x3CA8FE0
	|-Dictionary<char, object>.get_Keys
	|
	|-RVA: 0x3CACAF0 Offset: 0x3CACBF1 VA: 0x3CACAF0
	|-Dictionary<Guid, object>.get_Keys
	|
	|-RVA: 0x3CB0630 Offset: 0x3CB0731 VA: 0x3CB0630
	|-Dictionary<int, bool>.get_Keys
	|
	|-RVA: 0x3CB40F0 Offset: 0x3CB41F1 VA: 0x3CB40F0
	|-Dictionary<int, byte>.get_Keys
	|
	|-RVA: 0x3CB7BB0 Offset: 0x3CB7CB1 VA: 0x3CB7BB0
	|-Dictionary<int, char>.get_Keys
	|
	|-RVA: 0x3CBB700 Offset: 0x3CBB801 VA: 0x3CBB700
	|-Dictionary<int, DiagnosticEvent>.get_Keys
	|
	|-RVA: 0x3D4CC70 Offset: 0x3D4CD71 VA: 0x3D4CC70
	|-Dictionary<int, int>.get_Keys
	|
	|-RVA: 0x3D50700 Offset: 0x3D50801 VA: 0x3D50700
	|-Dictionary<int, Int32Enum>.get_Keys
	|
	|-RVA: 0x3D541A0 Offset: 0x3D542A1 VA: 0x3D541A0
	|-Dictionary<int, long>.get_Keys
	|
	|-RVA: 0x3D57D10 Offset: 0x3D57E11 VA: 0x3D57D10
	|-Dictionary<int, MapPos>.get_Keys
	|
	|-RVA: 0x3D5B850 Offset: 0x3D5B951 VA: 0x3D5B850
	|-Dictionary<int, object>.get_Keys
	|-Dictionary<int, MapHistory.Rewind.OverlapData>.get_Keys
	|
	|-RVA: 0x3D5F350 Offset: 0x3D5F451 VA: 0x3D5F350
	|-Dictionary<int, uint>.get_Keys
	|
	|-RVA: 0x3D62DE0 Offset: 0x3D62EE1 VA: 0x3D62DE0
	|-Dictionary<int, AIThink.EnchantThink.SurroundingInfo>.get_Keys
	|
	|-RVA: 0x3CBF6A0 Offset: 0x3CBF7A1 VA: 0x3CBF6A0
	|-Dictionary<Int32Enum, bool>.get_Keys
	|
	|-RVA: 0x3CC3150 Offset: 0x3CC3251 VA: 0x3CC3150
	|-Dictionary<Int32Enum, int>.get_Keys
	|
	|-RVA: 0x3CC6BE0 Offset: 0x3CC6CE1 VA: 0x3CC6BE0
	|-Dictionary<Int32Enum, Int32Enum>.get_Keys
	|
	|-RVA: 0x3CCA680 Offset: 0x3CCA781 VA: 0x3CCA680
	|-Dictionary<Int32Enum, object>.get_Keys
	|
	|-RVA: 0x3CCE190 Offset: 0x3CCE291 VA: 0x3CCE190
	|-Dictionary<long, object>.get_Keys
	|
	|-RVA: 0x3CE4E00 Offset: 0x3CE4F01 VA: 0x3CE4E00
	|-Dictionary<ItemData, int>.get_Keys
	|-Dictionary<object, int>.get_Keys
	|-Dictionary<string, int>.get_Keys
	|-Dictionary<SymbolRef, int>.get_Keys
	|-Dictionary<Unit, int>.get_Keys
	|
	|-RVA: 0x3CD1C80 Offset: 0x3CD1D81 VA: 0x3CD1C80
	|-Dictionary<MapPos, int>.get_Keys
	|
	|-RVA: 0x3CD5800 Offset: 0x3CD5901 VA: 0x3CD5800
	|-Dictionary<object, AsyncOperationHandle<object>>.get_Keys
	|
	|-RVA: 0x3CF01B0 Offset: 0x3CF02B1 VA: 0x3CF01B0
	|-Dictionary<object, IList<IResourceLocation>>.get_Keys
	|-Dictionary<object, object>.get_Keys
	|-Dictionary<ParameterExpression, LocalVariable>.get_Keys
	|-Dictionary<Renderer, Material[]>.get_Keys
	|-Dictionary<string, GodBond>.get_Keys
	|-Dictionary<string, GodUnit>.get_Keys
	|-Dictionary<string, GodWeaponRefineLevels>.get_Keys
	|-Dictionary<string, IMemberDescriptor>.get_Keys
	|-Dictionary<string, RelayAwardeeData>.get_Keys
	|-Dictionary<string, string>.get_Keys
	|-Dictionary<string, RingInfo.RingPrefabObject>.get_Keys
	|-Dictionary<string, ServicePointScheduler.ConnectionGroup>.get_Keys
	|
	|-RVA: 0x3CD9720 Offset: 0x3CD9821 VA: 0x3CD9720
	|-Dictionary<object, AsyncOperationHandle>.get_Keys
	|
	|-RVA: 0x3CDD600 Offset: 0x3CDD701 VA: 0x3CDD600
	|-Dictionary<object, bool>.get_Keys
	|-Dictionary<string, bool>.get_Keys
	|
	|-RVA: 0x3CE1210 Offset: 0x3CE1311 VA: 0x3CE1210
	|-Dictionary<object, byte>.get_Keys
	|
	|-RVA: 0x3CE89F0 Offset: 0x3CE8AF1 VA: 0x3CE89F0
	|-Dictionary<object, Int32Enum>.get_Keys
	|
	|-RVA: 0x3CEC5E0 Offset: 0x3CEC6E1 VA: 0x3CEC5E0
	|-Dictionary<object, IntPtr>.get_Keys
	|-Dictionary<string, IntPtr>.get_Keys
	|
	|-RVA: 0x3C8AF60 Offset: 0x3C8B061 VA: 0x3C8AF60
	|-Dictionary<object, Playable>.get_Keys
	|
	|-RVA: 0x3C8EB40 Offset: 0x3C8EC41 VA: 0x3C8EB40
	|-Dictionary<object, ResourceLocator>.get_Keys
	|
	|-RVA: 0x3C92740 Offset: 0x3C92841 VA: 0x3C92740
	|-Dictionary<object, float>.get_Keys
	|
	|-RVA: 0x3C96320 Offset: 0x3C96421 VA: 0x3C96320
	|-Dictionary<object, ushort>.get_Keys
	|
	|-RVA: 0x3C99F10 Offset: 0x3C9A011 VA: 0x3C99F10
	|-Dictionary<object, GameVariable.Value>.get_Keys
	|-Dictionary<string, GameVariable.Value>.get_Keys
	|
	|-RVA: 0x3C9DB80 Offset: 0x3C9DC81 VA: 0x3C9DB80
	|-Dictionary<sbyte, DataStoreRatingInfo>.get_Keys
	|
	|-RVA: 0x3CA19D0 Offset: 0x3CA1AD1 VA: 0x3CA19D0
	|-Dictionary<sbyte, object>.get_Keys
	|
	|-RVA: 0x3D328D0 Offset: 0x3D329D1 VA: 0x3D328D0
	|-Dictionary<ushort, int>.get_Keys
	|
	|-RVA: 0x3D36380 Offset: 0x3D36481 VA: 0x3D36380
	|-Dictionary<uint, int>.get_Keys
	|
	|-RVA: 0x3D39E20 Offset: 0x3D39F21 VA: 0x3D39E20
	|-Dictionary<uint, object>.get_Keys
	|
	|-RVA: 0x3D454F0 Offset: 0x3D455F1 VA: 0x3D454F0
	|-Dictionary<ulong, DataStorePreparePostParam>.get_Keys
	|-Dictionary<ulong, object>.get_Keys
	|-Dictionary<ulong, RelayUserGlobalData.Ticket>.get_Keys
	|
	|-RVA: 0x3D3D9B0 Offset: 0x3D3DAB1 VA: 0x3D3D9B0
	|-Dictionary<ulong, Friend>.get_Keys
	|
	|-RVA: 0x3D41980 Offset: 0x3D41A81 VA: 0x3D41980
	|-Dictionary<ulong, Int32Enum>.get_Keys
	|-Dictionary<ulong, NexVersus.TargetSlotList.Results>.get_Keys
	|
	|-RVA: 0x3D48FF0 Offset: 0x3D490F1 VA: 0x3D48FF0
	|-Dictionary<Vector3, int>.get_Keys
	|
	|-RVA: 0x2627420 Offset: 0x2627521 VA: 0x2627420
	|-Dictionary<XPathNodeRef, XPathNodeRef>.get_Keys
	|
	|-RVA: 0x262B0C0 Offset: 0x262B1C1 VA: 0x262B0C0
	|-Dictionary<TerrainUtility.TerrainMap.TileCoord, object>.get_Keys
	|-Dictionary<TerrainUtility.TerrainMap.TileCoord, Terrain>.get_Keys
	*/

	// RVA: -1 Offset: -1 Slot: 4
	private ICollection<TKey> System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x251CAF0 Offset: 0x251CBF1 VA: 0x251CAF0
	|-Dictionary<ValueTuple<object, int>, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x2520640 Offset: 0x2520741 VA: 0x2520640
	|-Dictionary<byte, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x3CA5580 Offset: 0x3CA5681 VA: 0x3CA5580
	|-Dictionary<CancellationToken, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x3CA9080 Offset: 0x3CA9181 VA: 0x3CA9080
	|-Dictionary<char, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x3CACB90 Offset: 0x3CACC91 VA: 0x3CACB90
	|-Dictionary<Guid, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x3CB06D0 Offset: 0x3CB07D1 VA: 0x3CB06D0
	|-Dictionary<int, bool>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x3CB4190 Offset: 0x3CB4291 VA: 0x3CB4190
	|-Dictionary<int, byte>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x3D5B8F0 Offset: 0x3D5B9F1 VA: 0x3D5B8F0
	|-Dictionary<int, CalculatorCommand>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|-Dictionary<int, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|-Dictionary<int, TerrainUtility.TerrainMap>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x3CB7C50 Offset: 0x3CB7D51 VA: 0x3CB7C50
	|-Dictionary<int, char>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x3CBB7A0 Offset: 0x3CBB8A1 VA: 0x3CBB7A0
	|-Dictionary<int, DiagnosticEvent>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x3D4CD10 Offset: 0x3D4CE11 VA: 0x3D4CD10
	|-Dictionary<int, int>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x3D507A0 Offset: 0x3D508A1 VA: 0x3D507A0
	|-Dictionary<int, Int32Enum>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x3D54240 Offset: 0x3D54341 VA: 0x3D54240
	|-Dictionary<int, long>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x3D57DB0 Offset: 0x3D57EB1 VA: 0x3D57DB0
	|-Dictionary<int, MapPos>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x3D5F3F0 Offset: 0x3D5F4F1 VA: 0x3D5F3F0
	|-Dictionary<int, uint>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x3D62E80 Offset: 0x3D62F81 VA: 0x3D62E80
	|-Dictionary<int, AIThink.EnchantThink.SurroundingInfo>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x3CBF740 Offset: 0x3CBF841 VA: 0x3CBF740
	|-Dictionary<Int32Enum, bool>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x3CC31F0 Offset: 0x3CC32F1 VA: 0x3CC31F0
	|-Dictionary<Int32Enum, int>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x3CC6C80 Offset: 0x3CC6D81 VA: 0x3CC6C80
	|-Dictionary<Int32Enum, Int32Enum>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x3CCA720 Offset: 0x3CCA821 VA: 0x3CCA720
	|-Dictionary<Int32Enum, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x3CCE230 Offset: 0x3CCE331 VA: 0x3CCE230
	|-Dictionary<long, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x3CD1D20 Offset: 0x3CD1E21 VA: 0x3CD1D20
	|-Dictionary<MapPos, int>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x3CD58A0 Offset: 0x3CD59A1 VA: 0x3CD58A0
	|-Dictionary<object, AsyncOperationHandle<object>>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x3CD97C0 Offset: 0x3CD98C1 VA: 0x3CD97C0
	|-Dictionary<object, AsyncOperationHandle>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x3CDD6A0 Offset: 0x3CDD7A1 VA: 0x3CDD6A0
	|-Dictionary<object, bool>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x3CE12B0 Offset: 0x3CE13B1 VA: 0x3CE12B0
	|-Dictionary<object, byte>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x3CE4EA0 Offset: 0x3CE4FA1 VA: 0x3CE4EA0
	|-Dictionary<object, int>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|-Dictionary<string, int>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x3CE8A90 Offset: 0x3CE8B91 VA: 0x3CE8A90
	|-Dictionary<object, Int32Enum>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x3CEC680 Offset: 0x3CEC781 VA: 0x3CEC680
	|-Dictionary<object, IntPtr>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x3CF0250 Offset: 0x3CF0351 VA: 0x3CF0250
	|-Dictionary<object, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|-Dictionary<string, GameUserRestartData.Growth>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x3C8B000 Offset: 0x3C8B101 VA: 0x3C8B000
	|-Dictionary<object, Playable>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x3C8EBE0 Offset: 0x3C8ECE1 VA: 0x3C8EBE0
	|-Dictionary<object, ResourceLocator>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x3C927E0 Offset: 0x3C928E1 VA: 0x3C927E0
	|-Dictionary<object, float>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x3C963C0 Offset: 0x3C964C1 VA: 0x3C963C0
	|-Dictionary<object, ushort>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x3C99FB0 Offset: 0x3C9A0B1 VA: 0x3C99FB0
	|-Dictionary<object, GameVariable.Value>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x3C9DC20 Offset: 0x3C9DD21 VA: 0x3C9DC20
	|-Dictionary<sbyte, DataStoreRatingInfo>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x3CA1A70 Offset: 0x3CA1B71 VA: 0x3CA1A70
	|-Dictionary<sbyte, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x3D32970 Offset: 0x3D32A71 VA: 0x3D32970
	|-Dictionary<ushort, int>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x3D36420 Offset: 0x3D36521 VA: 0x3D36420
	|-Dictionary<uint, int>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x3D39EC0 Offset: 0x3D39FC1 VA: 0x3D39EC0
	|-Dictionary<uint, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x3D3DA50 Offset: 0x3D3DB51 VA: 0x3D3DA50
	|-Dictionary<ulong, Friend>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x3D41A20 Offset: 0x3D41B21 VA: 0x3D41A20
	|-Dictionary<ulong, Int32Enum>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x3D45590 Offset: 0x3D45691 VA: 0x3D45590
	|-Dictionary<ulong, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x3D49090 Offset: 0x3D49191 VA: 0x3D49090
	|-Dictionary<Vector3, int>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x26274C0 Offset: 0x26275C1 VA: 0x26274C0
	|-Dictionary<XPathNodeRef, XPathNodeRef>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x262B160 Offset: 0x262B261 VA: 0x262B160
	|-Dictionary<TerrainUtility.TerrainMap.TileCoord, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	*/

	// RVA: -1 Offset: -1
	public Dictionary.ValueCollection<TKey, TValue> get_Values() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x251CB90 Offset: 0x251CC91 VA: 0x251CB90
	|-Dictionary<ValueTuple<object, int>, object>.get_Values
	|
	|-RVA: 0x25206E0 Offset: 0x25207E1 VA: 0x25206E0
	|-Dictionary<byte, object>.get_Values
	|
	|-RVA: 0x3CA5620 Offset: 0x3CA5721 VA: 0x3CA5620
	|-Dictionary<CancellationToken, object>.get_Values
	|
	|-RVA: 0x3CA9120 Offset: 0x3CA9221 VA: 0x3CA9120
	|-Dictionary<char, object>.get_Values
	|
	|-RVA: 0x3CE4F40 Offset: 0x3CE5041 VA: 0x3CE4F40
	|-Dictionary<FoodstuffData, int>.get_Values
	|-Dictionary<object, int>.get_Values
	|
	|-RVA: 0x3CACC30 Offset: 0x3CACD31 VA: 0x3CACC30
	|-Dictionary<Guid, object>.get_Values
	|
	|-RVA: 0x3CB0770 Offset: 0x3CB0871 VA: 0x3CB0770
	|-Dictionary<int, bool>.get_Values
	|
	|-RVA: 0x3CB4230 Offset: 0x3CB4331 VA: 0x3CB4230
	|-Dictionary<int, byte>.get_Values
	|
	|-RVA: 0x3D5B990 Offset: 0x3D5BA91 VA: 0x3D5B990
	|-Dictionary<int, CalculatorCommand>.get_Values
	|-Dictionary<int, GameObject>.get_Values
	|-Dictionary<int, object>.get_Values
	|-Dictionary<int, PointerEventData>.get_Values
	|-Dictionary<int, ResourceGameObject>.get_Values
	|-Dictionary<int, SourceCode>.get_Values
	|-Dictionary<int, MapHistory.Rewind.OverlapData>.get_Values
	|
	|-RVA: 0x3CB7CF0 Offset: 0x3CB7DF1 VA: 0x3CB7CF0
	|-Dictionary<int, char>.get_Values
	|
	|-RVA: 0x3CBB840 Offset: 0x3CBB941 VA: 0x3CBB840
	|-Dictionary<int, DiagnosticEvent>.get_Values
	|
	|-RVA: 0x3D4CDB0 Offset: 0x3D4CEB1 VA: 0x3D4CDB0
	|-Dictionary<int, int>.get_Values
	|
	|-RVA: 0x3D50840 Offset: 0x3D50941 VA: 0x3D50840
	|-Dictionary<int, Int32Enum>.get_Values
	|
	|-RVA: 0x3D542E0 Offset: 0x3D543E1 VA: 0x3D542E0
	|-Dictionary<int, long>.get_Values
	|
	|-RVA: 0x3D57E50 Offset: 0x3D57F51 VA: 0x3D57E50
	|-Dictionary<int, MapPos>.get_Values
	|
	|-RVA: 0x3D5F490 Offset: 0x3D5F591 VA: 0x3D5F490
	|-Dictionary<int, uint>.get_Values
	|
	|-RVA: 0x3D62F20 Offset: 0x3D63021 VA: 0x3D62F20
	|-Dictionary<int, AIThink.EnchantThink.SurroundingInfo>.get_Values
	|
	|-RVA: 0x3CBF7E0 Offset: 0x3CBF8E1 VA: 0x3CBF7E0
	|-Dictionary<Int32Enum, bool>.get_Values
	|
	|-RVA: 0x3CC3290 Offset: 0x3CC3391 VA: 0x3CC3290
	|-Dictionary<Int32Enum, int>.get_Values
	|-Dictionary<HubAccessManager.MaterialCalculator.Type, int>.get_Values
	|
	|-RVA: 0x3CC6D20 Offset: 0x3CC6E21 VA: 0x3CC6D20
	|-Dictionary<Int32Enum, Int32Enum>.get_Values
	|
	|-RVA: 0x3CCA7C0 Offset: 0x3CCA8C1 VA: 0x3CCA7C0
	|-Dictionary<Int32Enum, object>.get_Values
	|
	|-RVA: 0x3CCE2D0 Offset: 0x3CCE3D1 VA: 0x3CCE2D0
	|-Dictionary<long, object>.get_Values
	|
	|-RVA: 0x3CD1DC0 Offset: 0x3CD1EC1 VA: 0x3CD1DC0
	|-Dictionary<MapPos, int>.get_Values
	|
	|-RVA: 0x3CD5940 Offset: 0x3CD5A41 VA: 0x3CD5940
	|-Dictionary<object, AsyncOperationHandle<object>>.get_Values
	|
	|-RVA: 0x3CD9860 Offset: 0x3CD9961 VA: 0x3CD9860
	|-Dictionary<object, AsyncOperationHandle>.get_Values
	|-Dictionary<string, AsyncOperationHandle>.get_Values
	|
	|-RVA: 0x3CDD740 Offset: 0x3CDD841 VA: 0x3CDD740
	|-Dictionary<object, bool>.get_Values
	|
	|-RVA: 0x3CE1350 Offset: 0x3CE1451 VA: 0x3CE1350
	|-Dictionary<object, byte>.get_Values
	|
	|-RVA: 0x3CE8B30 Offset: 0x3CE8C31 VA: 0x3CE8B30
	|-Dictionary<object, Int32Enum>.get_Values
	|
	|-RVA: 0x3CEC720 Offset: 0x3CEC821 VA: 0x3CEC720
	|-Dictionary<object, IntPtr>.get_Values
	|
	|-RVA: 0x3CF02F0 Offset: 0x3CF03F1 VA: 0x3CF02F0
	|-Dictionary<object, object>.get_Values
	|-Dictionary<string, FileData>.get_Values
	|-Dictionary<string, GUIStyle>.get_Values
	|-Dictionary<string, GodBond>.get_Values
	|-Dictionary<string, IMemberDescriptor>.get_Values
	|-Dictionary<string, LabelStatement>.get_Values
	|-Dictionary<string, ResourceHandle>.get_Values
	|-Dictionary<string, SchemaNotation>.get_Values
	|-Dictionary<string, Sprite>.get_Values
	|-Dictionary<string, string>.get_Values
	|-Dictionary<string, SymbolRef>.get_Values
	|-Dictionary<string, Transform>.get_Values
	|-Dictionary<string, UnitRelianceData>.get_Values
	|-Dictionary<string, DtdParser.UndeclaredNotation>.get_Values
	|-Dictionary<string, EventDemoSequence.CharacterWork>.get_Values
	|-Dictionary<string, EventDemoSequence.SplitViewWork>.get_Values
	|-Dictionary<XmlQualifiedName, SchemaAttDef>.get_Values
	|-Dictionary<XmlQualifiedName, SchemaElementDecl>.get_Values
	|-Dictionary<XmlQualifiedName, SchemaEntity>.get_Values
	|
	|-RVA: 0x3C8B0A0 Offset: 0x3C8B1A1 VA: 0x3C8B0A0
	|-Dictionary<object, Playable>.get_Values
	|
	|-RVA: 0x3C8EC80 Offset: 0x3C8ED81 VA: 0x3C8EC80
	|-Dictionary<object, ResourceLocator>.get_Values
	|
	|-RVA: 0x3C92880 Offset: 0x3C92981 VA: 0x3C92880
	|-Dictionary<object, float>.get_Values
	|
	|-RVA: 0x3C96460 Offset: 0x3C96561 VA: 0x3C96460
	|-Dictionary<object, ushort>.get_Values
	|
	|-RVA: 0x3C9A050 Offset: 0x3C9A151 VA: 0x3C9A050
	|-Dictionary<object, GameVariable.Value>.get_Values
	|
	|-RVA: 0x3C9DCC0 Offset: 0x3C9DDC1 VA: 0x3C9DCC0
	|-Dictionary<sbyte, DataStoreRatingInfo>.get_Values
	|
	|-RVA: 0x3CA1B10 Offset: 0x3CA1C11 VA: 0x3CA1B10
	|-Dictionary<sbyte, object>.get_Values
	|
	|-RVA: 0x3D32A10 Offset: 0x3D32B11 VA: 0x3D32A10
	|-Dictionary<ushort, int>.get_Values
	|
	|-RVA: 0x3D364C0 Offset: 0x3D365C1 VA: 0x3D364C0
	|-Dictionary<uint, int>.get_Values
	|
	|-RVA: 0x3D39F60 Offset: 0x3D3A061 VA: 0x3D39F60
	|-Dictionary<uint, object>.get_Values
	|
	|-RVA: 0x3D45630 Offset: 0x3D45731 VA: 0x3D45630
	|-Dictionary<ulong, DataStorePreparePostParam>.get_Values
	|-Dictionary<ulong, object>.get_Values
	|
	|-RVA: 0x3D3DAF0 Offset: 0x3D3DBF1 VA: 0x3D3DAF0
	|-Dictionary<ulong, Friend>.get_Values
	|
	|-RVA: 0x3D41AC0 Offset: 0x3D41BC1 VA: 0x3D41AC0
	|-Dictionary<ulong, Int32Enum>.get_Values
	|
	|-RVA: 0x3D49130 Offset: 0x3D49231 VA: 0x3D49130
	|-Dictionary<Vector3, int>.get_Values
	|
	|-RVA: 0x2627560 Offset: 0x2627661 VA: 0x2627560
	|-Dictionary<XPathNodeRef, XPathNodeRef>.get_Values
	|
	|-RVA: 0x262B200 Offset: 0x262B301 VA: 0x262B200
	|-Dictionary<TerrainUtility.TerrainMap.TileCoord, object>.get_Values
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private ICollection<TValue> System.Collections.Generic.IDictionary<TKey,TValue>.get_Values() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x251CC30 Offset: 0x251CD31 VA: 0x251CC30
	|-Dictionary<ValueTuple<object, int>, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|
	|-RVA: 0x2520780 Offset: 0x2520881 VA: 0x2520780
	|-Dictionary<byte, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|
	|-RVA: 0x3CA56C0 Offset: 0x3CA57C1 VA: 0x3CA56C0
	|-Dictionary<CancellationToken, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|
	|-RVA: 0x3CA91C0 Offset: 0x3CA92C1 VA: 0x3CA91C0
	|-Dictionary<char, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|
	|-RVA: 0x3CACCD0 Offset: 0x3CACDD1 VA: 0x3CACCD0
	|-Dictionary<Guid, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|
	|-RVA: 0x3CB0810 Offset: 0x3CB0911 VA: 0x3CB0810
	|-Dictionary<int, bool>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|
	|-RVA: 0x3CB42D0 Offset: 0x3CB43D1 VA: 0x3CB42D0
	|-Dictionary<int, byte>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|
	|-RVA: 0x3D5BA30 Offset: 0x3D5BB31 VA: 0x3D5BA30
	|-Dictionary<int, CalculatorCommand>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|-Dictionary<int, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|-Dictionary<int, TerrainUtility.TerrainMap>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|
	|-RVA: 0x3CB7D90 Offset: 0x3CB7E91 VA: 0x3CB7D90
	|-Dictionary<int, char>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|
	|-RVA: 0x3CBB8E0 Offset: 0x3CBB9E1 VA: 0x3CBB8E0
	|-Dictionary<int, DiagnosticEvent>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|
	|-RVA: 0x3D4CE50 Offset: 0x3D4CF51 VA: 0x3D4CE50
	|-Dictionary<int, int>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|
	|-RVA: 0x3D508E0 Offset: 0x3D509E1 VA: 0x3D508E0
	|-Dictionary<int, Int32Enum>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|
	|-RVA: 0x3D54380 Offset: 0x3D54481 VA: 0x3D54380
	|-Dictionary<int, long>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|
	|-RVA: 0x3D57EF0 Offset: 0x3D57FF1 VA: 0x3D57EF0
	|-Dictionary<int, MapPos>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|
	|-RVA: 0x3D5F530 Offset: 0x3D5F631 VA: 0x3D5F530
	|-Dictionary<int, uint>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|
	|-RVA: 0x3D62FC0 Offset: 0x3D630C1 VA: 0x3D62FC0
	|-Dictionary<int, AIThink.EnchantThink.SurroundingInfo>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|
	|-RVA: 0x3CBF880 Offset: 0x3CBF981 VA: 0x3CBF880
	|-Dictionary<Int32Enum, bool>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|
	|-RVA: 0x3CC3330 Offset: 0x3CC3431 VA: 0x3CC3330
	|-Dictionary<Int32Enum, int>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|
	|-RVA: 0x3CC6DC0 Offset: 0x3CC6EC1 VA: 0x3CC6DC0
	|-Dictionary<Int32Enum, Int32Enum>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|
	|-RVA: 0x3CCA860 Offset: 0x3CCA961 VA: 0x3CCA860
	|-Dictionary<Int32Enum, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|
	|-RVA: 0x3CCE370 Offset: 0x3CCE471 VA: 0x3CCE370
	|-Dictionary<long, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|
	|-RVA: 0x3CD1E60 Offset: 0x3CD1F61 VA: 0x3CD1E60
	|-Dictionary<MapPos, int>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|
	|-RVA: 0x3CD59E0 Offset: 0x3CD5AE1 VA: 0x3CD59E0
	|-Dictionary<object, AsyncOperationHandle<object>>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|
	|-RVA: 0x3CD9900 Offset: 0x3CD9A01 VA: 0x3CD9900
	|-Dictionary<object, AsyncOperationHandle>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|
	|-RVA: 0x3CDD7E0 Offset: 0x3CDD8E1 VA: 0x3CDD7E0
	|-Dictionary<object, bool>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|
	|-RVA: 0x3CE13F0 Offset: 0x3CE14F1 VA: 0x3CE13F0
	|-Dictionary<object, byte>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|
	|-RVA: 0x3CE4FE0 Offset: 0x3CE50E1 VA: 0x3CE4FE0
	|-Dictionary<object, int>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|-Dictionary<string, int>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|
	|-RVA: 0x3CE8BD0 Offset: 0x3CE8CD1 VA: 0x3CE8BD0
	|-Dictionary<object, Int32Enum>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|
	|-RVA: 0x3CEC7C0 Offset: 0x3CEC8C1 VA: 0x3CEC7C0
	|-Dictionary<object, IntPtr>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|
	|-RVA: 0x3CF0390 Offset: 0x3CF0491 VA: 0x3CF0390
	|-Dictionary<object, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|-Dictionary<string, GameUserRestartData.Growth>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|
	|-RVA: 0x3C8B140 Offset: 0x3C8B241 VA: 0x3C8B140
	|-Dictionary<object, Playable>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|
	|-RVA: 0x3C8ED20 Offset: 0x3C8EE21 VA: 0x3C8ED20
	|-Dictionary<object, ResourceLocator>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|
	|-RVA: 0x3C92920 Offset: 0x3C92A21 VA: 0x3C92920
	|-Dictionary<object, float>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|
	|-RVA: 0x3C96500 Offset: 0x3C96601 VA: 0x3C96500
	|-Dictionary<object, ushort>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|
	|-RVA: 0x3C9A0F0 Offset: 0x3C9A1F1 VA: 0x3C9A0F0
	|-Dictionary<object, GameVariable.Value>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|
	|-RVA: 0x3C9DD60 Offset: 0x3C9DE61 VA: 0x3C9DD60
	|-Dictionary<sbyte, DataStoreRatingInfo>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|
	|-RVA: 0x3CA1BB0 Offset: 0x3CA1CB1 VA: 0x3CA1BB0
	|-Dictionary<sbyte, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|
	|-RVA: 0x3D32AB0 Offset: 0x3D32BB1 VA: 0x3D32AB0
	|-Dictionary<ushort, int>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|
	|-RVA: 0x3D36560 Offset: 0x3D36661 VA: 0x3D36560
	|-Dictionary<uint, int>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|
	|-RVA: 0x3D3A000 Offset: 0x3D3A101 VA: 0x3D3A000
	|-Dictionary<uint, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|
	|-RVA: 0x3D3DB90 Offset: 0x3D3DC91 VA: 0x3D3DB90
	|-Dictionary<ulong, Friend>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|
	|-RVA: 0x3D41B60 Offset: 0x3D41C61 VA: 0x3D41B60
	|-Dictionary<ulong, Int32Enum>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|
	|-RVA: 0x3D456D0 Offset: 0x3D457D1 VA: 0x3D456D0
	|-Dictionary<ulong, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|
	|-RVA: 0x3D491D0 Offset: 0x3D492D1 VA: 0x3D491D0
	|-Dictionary<Vector3, int>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|
	|-RVA: 0x2627600 Offset: 0x2627701 VA: 0x2627600
	|-Dictionary<XPathNodeRef, XPathNodeRef>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|
	|-RVA: 0x262B2A0 Offset: 0x262B3A1 VA: 0x262B2A0
	|-Dictionary<TerrainUtility.TerrainMap.TileCoord, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	*/

	// RVA: -1 Offset: -1 Slot: 34
	public TValue get_Item(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x251CCD0 Offset: 0x251CDD1 VA: 0x251CCD0
	|-Dictionary<ValueTuple<object, int>, object>.get_Item
	|
	|-RVA: 0x2520820 Offset: 0x2520921 VA: 0x2520820
	|-Dictionary<byte, List<byte>>.get_Item
	|-Dictionary<byte, object>.get_Item
	|
	|-RVA: 0x3CA5760 Offset: 0x3CA5861 VA: 0x3CA5760
	|-Dictionary<CancellationToken, object>.get_Item
	|
	|-RVA: 0x3CA9260 Offset: 0x3CA9361 VA: 0x3CA9260
	|-Dictionary<char, object>.get_Item
	|-Dictionary<char, string>.get_Item
	|
	|-RVA: 0x3CE5080 Offset: 0x3CE5181 VA: 0x3CE5080
	|-Dictionary<FoodstuffData, int>.get_Item
	|-Dictionary<ItemData, int>.get_Item
	|-Dictionary<MapEditorCategoryData, int>.get_Item
	|-Dictionary<object, int>.get_Item
	|-Dictionary<ParameterExpression, int>.get_Item
	|-Dictionary<string, int>.get_Item
	|-Dictionary<SymbolRef, int>.get_Item
	|
	|-RVA: 0x3CF0430 Offset: 0x3CF0531 VA: 0x3CF0430
	|-Dictionary<GameObject, Stack<GameObject>>.get_Item
	|-Dictionary<GmapSpot, GmapSpot>.get_Item
	|-Dictionary<IResourceLocation, ContentCatalogProvider.InternalOp>.get_Item
	|-Dictionary<ItemData, ChallengeMapSelectRoot.ItemDropNum>.get_Item
	|-Dictionary<object, object>.get_Item
	|-Dictionary<Renderer, Material[]>.get_Item
	|-Dictionary<string, List<Renderer>>.get_Item
	|-Dictionary<string, List<string>>.get_Item
	|-Dictionary<string, Color[]>.get_Item
	|-Dictionary<string, CharacterAsset>.get_Item
	|-Dictionary<string, GodBond>.get_Item
	|-Dictionary<string, GodUnit>.get_Item
	|-Dictionary<string, GodWeaponRefineLevels>.get_Item
	|-Dictionary<string, IMemberDescriptor>.get_Item
	|-Dictionary<string, LabelStatement>.get_Item
	|-Dictionary<string, PropertyInfo>.get_Item
	|-Dictionary<string, RelayAwardeeData>.get_Item
	|-Dictionary<string, ResourceHandle>.get_Item
	|-Dictionary<string, ResourceLocationBase>.get_Item
	|-Dictionary<string, ResourceLocationData>.get_Item
	|-Dictionary<string, RuntimeAnimatorController>.get_Item
	|-Dictionary<string, SpringCapsuleCollider>.get_Item
	|-Dictionary<string, SpringPanelCollider>.get_Item
	|-Dictionary<string, SpringSphereCollider>.get_Item
	|-Dictionary<string, Sprite>.get_Item
	|-Dictionary<string, string>.get_Item
	|-Dictionary<string, SymbolRef>.get_Item
	|-Dictionary<string, Transform>.get_Item
	|-Dictionary<string, EventDemoSequence.CharacterWork>.get_Item
	|-Dictionary<string, EventDemoSequence.EffectWork>.get_Item
	|-Dictionary<string, EventDemoSequence.SplitViewWork>.get_Item
	|-Dictionary<string, GameUserRestartData.Growth>.get_Item
	|-Dictionary<string, RingInfo.RingPrefabObject>.get_Item
	|-Dictionary<string, ServicePointScheduler.ConnectionGroup>.get_Item
	|-Dictionary<Thread, StackTrace>.get_Item
	|-Dictionary<Type, IPropertyTableAssigner>.get_Item
	|-Dictionary<Type, IUserDataDescriptor>.get_Item
	|
	|-RVA: 0x3CACD70 Offset: 0x3CACE71 VA: 0x3CACD70
	|-Dictionary<Guid, object>.get_Item
	|
	|-RVA: 0x3D5BAD0 Offset: 0x3D5BBD1 VA: 0x3D5BAD0
	|-Dictionary<int, RTHandle[]>.get_Item
	|-Dictionary<int, CalculatorCommand>.get_Item
	|-Dictionary<int, object>.get_Item
	|-Dictionary<int, SourceCode>.get_Item
	|-Dictionary<int, string>.get_Item
	|-Dictionary<int, TimeType>.get_Item
	|-Dictionary<int, TerrainUtility.TerrainMap>.get_Item
	|-Dictionary<int, MapHistory.Rewind.OverlapData>.get_Item
	|
	|-RVA: 0x3CB08B0 Offset: 0x3CB09B1 VA: 0x3CB08B0
	|-Dictionary<int, bool>.get_Item
	|
	|-RVA: 0x3CB4370 Offset: 0x3CB4471 VA: 0x3CB4370
	|-Dictionary<int, byte>.get_Item
	|
	|-RVA: 0x3CB7E30 Offset: 0x3CB7F31 VA: 0x3CB7E30
	|-Dictionary<int, char>.get_Item
	|
	|-RVA: 0x3CBB980 Offset: 0x3CBBA81 VA: 0x3CBB980
	|-Dictionary<int, DiagnosticEvent>.get_Item
	|
	|-RVA: 0x3D4CEF0 Offset: 0x3D4CFF1 VA: 0x3D4CEF0
	|-Dictionary<int, int>.get_Item
	|
	|-RVA: 0x3D50980 Offset: 0x3D50A81 VA: 0x3D50980
	|-Dictionary<int, Int32Enum>.get_Item
	|-Dictionary<int, MapPanelTarget.DangerType>.get_Item
	|
	|-RVA: 0x3D54420 Offset: 0x3D54521 VA: 0x3D54420
	|-Dictionary<int, long>.get_Item
	|
	|-RVA: 0x3D57F90 Offset: 0x3D58091 VA: 0x3D57F90
	|-Dictionary<int, MapPos>.get_Item
	|
	|-RVA: 0x3D5F5D0 Offset: 0x3D5F6D1 VA: 0x3D5F5D0
	|-Dictionary<int, uint>.get_Item
	|
	|-RVA: 0x3D63060 Offset: 0x3D63161 VA: 0x3D63060
	|-Dictionary<int, AIThink.EnchantThink.SurroundingInfo>.get_Item
	|
	|-RVA: 0x3CBF920 Offset: 0x3CBFA21 VA: 0x3CBF920
	|-Dictionary<Int32Enum, bool>.get_Item
	|
	|-RVA: 0x3CC33D0 Offset: 0x3CC34D1 VA: 0x3CC33D0
	|-Dictionary<Int32Enum, int>.get_Item
	|-Dictionary<HubAccessManager.MaterialCalculator.Type, int>.get_Item
	|
	|-RVA: 0x3CC6E60 Offset: 0x3CC6F61 VA: 0x3CC6E60
	|-Dictionary<Int32Enum, Int32Enum>.get_Item
	|-Dictionary<RuntimePlatform, AddressablesPlatform>.get_Item
	|
	|-RVA: 0x3CCA900 Offset: 0x3CCAA01 VA: 0x3CCA900
	|-Dictionary<Int32Enum, object>.get_Item
	|-Dictionary<KeyHelp.Type, KeyHelp.UI.Element>.get_Item
	|
	|-RVA: 0x3CCE410 Offset: 0x3CCE511 VA: 0x3CCE410
	|-Dictionary<long, object>.get_Item
	|
	|-RVA: 0x3CD1F00 Offset: 0x3CD2001 VA: 0x3CD1F00
	|-Dictionary<MapPos, int>.get_Item
	|
	|-RVA: 0x3CD5A80 Offset: 0x3CD5B81 VA: 0x3CD5A80
	|-Dictionary<object, AsyncOperationHandle<object>>.get_Item
	|
	|-RVA: 0x3CD99A0 Offset: 0x3CD9AA1 VA: 0x3CD99A0
	|-Dictionary<object, AsyncOperationHandle>.get_Item
	|
	|-RVA: 0x3CDD880 Offset: 0x3CDD981 VA: 0x3CDD880
	|-Dictionary<object, bool>.get_Item
	|
	|-RVA: 0x3CE1490 Offset: 0x3CE1591 VA: 0x3CE1490
	|-Dictionary<object, byte>.get_Item
	|-Dictionary<string, byte>.get_Item
	|
	|-RVA: 0x3CE8C70 Offset: 0x3CE8D71 VA: 0x3CE8C70
	|-Dictionary<object, Int32Enum>.get_Item
	|-Dictionary<string, RangeData.Targets>.get_Item
	|
	|-RVA: 0x3CEC860 Offset: 0x3CEC961 VA: 0x3CEC860
	|-Dictionary<object, IntPtr>.get_Item
	|
	|-RVA: 0x3C8B1E0 Offset: 0x3C8B2E1 VA: 0x3C8B1E0
	|-Dictionary<object, Playable>.get_Item
	|
	|-RVA: 0x3C8EDC0 Offset: 0x3C8EEC1 VA: 0x3C8EDC0
	|-Dictionary<object, ResourceLocator>.get_Item
	|
	|-RVA: 0x3C929C0 Offset: 0x3C92AC1 VA: 0x3C929C0
	|-Dictionary<object, float>.get_Item
	|
	|-RVA: 0x3C965A0 Offset: 0x3C966A1 VA: 0x3C965A0
	|-Dictionary<object, ushort>.get_Item
	|-Dictionary<VersusServerReplayMetaData, ushort>.get_Item
	|
	|-RVA: 0x3C9A190 Offset: 0x3C9A291 VA: 0x3C9A190
	|-Dictionary<object, GameVariable.Value>.get_Item
	|-Dictionary<string, GameVariable.Value>.get_Item
	|
	|-RVA: 0x3C9DE00 Offset: 0x3C9DF01 VA: 0x3C9DE00
	|-Dictionary<sbyte, DataStoreRatingInfo>.get_Item
	|
	|-RVA: 0x3CA1C50 Offset: 0x3CA1D51 VA: 0x3CA1C50
	|-Dictionary<sbyte, object>.get_Item
	|
	|-RVA: 0x3D32B50 Offset: 0x3D32C51 VA: 0x3D32B50
	|-Dictionary<ushort, int>.get_Item
	|
	|-RVA: 0x3D3A0A0 Offset: 0x3D3A1A1 VA: 0x3D3A0A0
	|-Dictionary<uint, AkMultiPosEvent>.get_Item
	|-Dictionary<uint, Glyph>.get_Item
	|-Dictionary<uint, object>.get_Item
	|-Dictionary<uint, TMP_Character>.get_Item
	|-Dictionary<uint, TMP_SpriteGlyph>.get_Item
	|-Dictionary<uint, AkAudioInputManager.AudioFormatDelegate>.get_Item
	|-Dictionary<uint, AkAudioInputManager.AudioSamplesDelegate>.get_Item
	|
	|-RVA: 0x3D36600 Offset: 0x3D36701 VA: 0x3D36600
	|-Dictionary<uint, int>.get_Item
	|
	|-RVA: 0x3D3DC30 Offset: 0x3D3DD31 VA: 0x3D3DC30
	|-Dictionary<ulong, Friend>.get_Item
	|
	|-RVA: 0x3D41C00 Offset: 0x3D41D01 VA: 0x3D41C00
	|-Dictionary<ulong, Int32Enum>.get_Item
	|-Dictionary<ulong, NexVersus.TargetSlotList.Results>.get_Item
	|
	|-RVA: 0x3D45770 Offset: 0x3D45871 VA: 0x3D45770
	|-Dictionary<ulong, object>.get_Item
	|-Dictionary<ulong, RelayUserGlobalData.Ticket>.get_Item
	|
	|-RVA: 0x3D49270 Offset: 0x3D49371 VA: 0x3D49270
	|-Dictionary<Vector3, int>.get_Item
	|
	|-RVA: 0x26276A0 Offset: 0x26277A1 VA: 0x26276A0
	|-Dictionary<XPathNodeRef, XPathNodeRef>.get_Item
	|
	|-RVA: 0x262B340 Offset: 0x262B441 VA: 0x262B340
	|-Dictionary<TerrainUtility.TerrainMap.TileCoord, object>.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 35
	public void set_Item(TKey key, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x251CD60 Offset: 0x251CE61 VA: 0x251CD60
	|-Dictionary<ValueTuple<object, int>, object>.set_Item
	|
	|-RVA: 0x3CF04C0 Offset: 0x3CF05C1 VA: 0x3CF04C0
	|-Dictionary<byte[], Encoding>.set_Item
	|-Dictionary<Action, LinkedListNode<Action>>.set_Item
	|-Dictionary<AnimationClip, List<CinemachineStateDrivenCamera.HashPair>>.set_Item
	|-Dictionary<Camera, Camera>.set_Item
	|-Dictionary<IAsyncLocal, object>.set_Item
	|-Dictionary<ICinemachineCamera, object>.set_Item
	|-Dictionary<object, object>.set_Item
	|-Dictionary<ParameterExpression, LocalVariable>.set_Item
	|-Dictionary<string, List<Renderer>>.set_Item
	|-Dictionary<string, CultureInfo>.set_Item
	|-Dictionary<string, GUIStyle>.set_Item
	|-Dictionary<string, object>.set_Item
	|-Dictionary<string, SimpleCollator>.set_Item
	|-Dictionary<string, string>.set_Item
	|-Dictionary<string, Transform>.set_Item
	|-Dictionary<string, UriParser>.set_Item
	|-Dictionary<string, AssetTable.Accessory>.set_Item
	|-Dictionary<string, GameUserRestartData.Growth>.set_Item
	|-Dictionary<Transform, List<SpringBone>>.set_Item
	|-Dictionary<Type, Func<DynValue, object>>.set_Item
	|-Dictionary<Type, Func<Script, object, DynValue>>.set_Item
	|-Dictionary<Type, AttributeUsageAttribute>.set_Item
	|-Dictionary<Type, IPropertyTableAssigner>.set_Item
	|-Dictionary<Type, IUserDataDescriptor>.set_Item
	|-Dictionary<Type, object>.set_Item
	|-Dictionary<XmlQualifiedName, XmlSchemaObject>.set_Item
	|
	|-RVA: 0x25208B0 Offset: 0x25209B1 VA: 0x25208B0
	|-Dictionary<byte, object>.set_Item
	|
	|-RVA: 0x3CA57F0 Offset: 0x3CA58F1 VA: 0x3CA57F0
	|-Dictionary<CancellationToken, object>.set_Item
	|
	|-RVA: 0x3CA92F0 Offset: 0x3CA93F1 VA: 0x3CA92F0
	|-Dictionary<char, object>.set_Item
	|
	|-RVA: 0x3CE5110 Offset: 0x3CE5211 VA: 0x3CE5110
	|-Dictionary<FoodstuffData, int>.set_Item
	|-Dictionary<ItemData, int>.set_Item
	|-Dictionary<MapEditorCategoryData, int>.set_Item
	|-Dictionary<object, int>.set_Item
	|-Dictionary<ParameterExpression, int>.set_Item
	|-Dictionary<string, int>.set_Item
	|
	|-RVA: 0x3CACE00 Offset: 0x3CACF01 VA: 0x3CACE00
	|-Dictionary<Guid, object>.set_Item
	|
	|-RVA: 0x3CB0940 Offset: 0x3CB0A41 VA: 0x3CB0940
	|-Dictionary<int, bool>.set_Item
	|
	|-RVA: 0x3CB4400 Offset: 0x3CB4501 VA: 0x3CB4400
	|-Dictionary<int, byte>.set_Item
	|
	|-RVA: 0x3D5BB60 Offset: 0x3D5BC61 VA: 0x3D5BB60
	|-Dictionary<int, CalculatorCommand>.set_Item
	|-Dictionary<int, CultureInfo>.set_Item
	|-Dictionary<int, object>.set_Item
	|-Dictionary<int, SourceCode>.set_Item
	|-Dictionary<int, string>.set_Item
	|-Dictionary<int, Task>.set_Item
	|-Dictionary<int, AkCallbackManager.BankCallbackPackage>.set_Item
	|-Dictionary<int, AkCallbackManager.EventCallbackPackage>.set_Item
	|-Dictionary<int, GUILayoutUtility.LayoutCache>.set_Item
	|-Dictionary<int, TerrainUtility.TerrainMap>.set_Item
	|
	|-RVA: 0x3CB7EC0 Offset: 0x3CB7FC1 VA: 0x3CB7EC0
	|-Dictionary<int, char>.set_Item
	|
	|-RVA: 0x3CBBA30 Offset: 0x3CBBB31 VA: 0x3CBBA30
	|-Dictionary<int, DiagnosticEvent>.set_Item
	|
	|-RVA: 0x3D4CF80 Offset: 0x3D4D081 VA: 0x3D4CF80
	|-Dictionary<int, int>.set_Item
	|
	|-RVA: 0x3D50A10 Offset: 0x3D50B11 VA: 0x3D50A10
	|-Dictionary<int, Int32Enum>.set_Item
	|-Dictionary<int, MapPanelTarget.DangerType>.set_Item
	|
	|-RVA: 0x3D544B0 Offset: 0x3D545B1 VA: 0x3D544B0
	|-Dictionary<int, long>.set_Item
	|
	|-RVA: 0x3D58020 Offset: 0x3D58121 VA: 0x3D58020
	|-Dictionary<int, MapPos>.set_Item
	|
	|-RVA: 0x3D5F660 Offset: 0x3D5F761 VA: 0x3D5F660
	|-Dictionary<int, uint>.set_Item
	|
	|-RVA: 0x3D630F0 Offset: 0x3D631F1 VA: 0x3D630F0
	|-Dictionary<int, AIThink.EnchantThink.SurroundingInfo>.set_Item
	|
	|-RVA: 0x3CBF9B0 Offset: 0x3CBFAB1 VA: 0x3CBF9B0
	|-Dictionary<Int32Enum, bool>.set_Item
	|
	|-RVA: 0x3CC3460 Offset: 0x3CC3561 VA: 0x3CC3460
	|-Dictionary<Int32Enum, int>.set_Item
	|-Dictionary<HubAccessManager.MaterialCalculator.Type, int>.set_Item
	|
	|-RVA: 0x3CC6EF0 Offset: 0x3CC6FF1 VA: 0x3CC6EF0
	|-Dictionary<Int32Enum, Int32Enum>.set_Item
	|
	|-RVA: 0x3CCA990 Offset: 0x3CCAA91 VA: 0x3CCA990
	|-Dictionary<Int32Enum, object>.set_Item
	|
	|-RVA: 0x3CCE4A0 Offset: 0x3CCE5A1 VA: 0x3CCE4A0
	|-Dictionary<long, object>.set_Item
	|
	|-RVA: 0x3C92A50 Offset: 0x3C92B51 VA: 0x3C92A50
	|-Dictionary<MapCollision, float>.set_Item
	|-Dictionary<object, float>.set_Item
	|
	|-RVA: 0x3CD1F90 Offset: 0x3CD2091 VA: 0x3CD1F90
	|-Dictionary<MapPos, int>.set_Item
	|
	|-RVA: 0x3CD5B20 Offset: 0x3CD5C21 VA: 0x3CD5B20
	|-Dictionary<object, AsyncOperationHandle<object>>.set_Item
	|
	|-RVA: 0x3CD9A40 Offset: 0x3CD9B41 VA: 0x3CD9A40
	|-Dictionary<object, AsyncOperationHandle>.set_Item
	|
	|-RVA: 0x3CDD910 Offset: 0x3CDDA11 VA: 0x3CDD910
	|-Dictionary<object, bool>.set_Item
	|-Dictionary<string, bool>.set_Item
	|
	|-RVA: 0x3CE1520 Offset: 0x3CE1621 VA: 0x3CE1520
	|-Dictionary<object, byte>.set_Item
	|
	|-RVA: 0x3CE8D00 Offset: 0x3CE8E01 VA: 0x3CE8D00
	|-Dictionary<object, Int32Enum>.set_Item
	|
	|-RVA: 0x3CEC8F0 Offset: 0x3CEC9F1 VA: 0x3CEC8F0
	|-Dictionary<object, IntPtr>.set_Item
	|
	|-RVA: 0x3C8B270 Offset: 0x3C8B371 VA: 0x3C8B270
	|-Dictionary<object, Playable>.set_Item
	|-Dictionary<TrackAsset, Playable>.set_Item
	|
	|-RVA: 0x3C8EE50 Offset: 0x3C8EF51 VA: 0x3C8EE50
	|-Dictionary<object, ResourceLocator>.set_Item
	|-Dictionary<string, ResourceLocator>.set_Item
	|
	|-RVA: 0x3C96630 Offset: 0x3C96731 VA: 0x3C96630
	|-Dictionary<object, ushort>.set_Item
	|
	|-RVA: 0x3C9A220 Offset: 0x3C9A321 VA: 0x3C9A220
	|-Dictionary<object, GameVariable.Value>.set_Item
	|-Dictionary<string, GameVariable.Value>.set_Item
	|
	|-RVA: 0x3C9DEA0 Offset: 0x3C9DFA1 VA: 0x3C9DEA0
	|-Dictionary<sbyte, DataStoreRatingInfo>.set_Item
	|
	|-RVA: 0x3CA1CE0 Offset: 0x3CA1DE1 VA: 0x3CA1CE0
	|-Dictionary<sbyte, object>.set_Item
	|
	|-RVA: 0x3D32BE0 Offset: 0x3D32CE1 VA: 0x3D32BE0
	|-Dictionary<ushort, int>.set_Item
	|
	|-RVA: 0x3D36690 Offset: 0x3D36791 VA: 0x3D36690
	|-Dictionary<uint, int>.set_Item
	|
	|-RVA: 0x3D3A130 Offset: 0x3D3A231 VA: 0x3D3A130
	|-Dictionary<uint, Material>.set_Item
	|-Dictionary<uint, object>.set_Item
	|
	|-RVA: 0x3D3DCD0 Offset: 0x3D3DDD1 VA: 0x3D3DCD0
	|-Dictionary<ulong, Friend>.set_Item
	|
	|-RVA: 0x3D41C90 Offset: 0x3D41D91 VA: 0x3D41C90
	|-Dictionary<ulong, Int32Enum>.set_Item
	|-Dictionary<ulong, NexVersus.TargetSlotList.Results>.set_Item
	|
	|-RVA: 0x3D45800 Offset: 0x3D45901 VA: 0x3D45800
	|-Dictionary<ulong, object>.set_Item
	|
	|-RVA: 0x3D49300 Offset: 0x3D49401 VA: 0x3D49300
	|-Dictionary<Vector3, int>.set_Item
	|
	|-RVA: 0x2627730 Offset: 0x2627831 VA: 0x2627730
	|-Dictionary<XPathNodeRef, XPathNodeRef>.set_Item
	|
	|-RVA: 0x262B3D0 Offset: 0x262B4D1 VA: 0x262B3D0
	|-Dictionary<TerrainUtility.TerrainMap.TileCoord, object>.set_Item
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public void Add(TKey key, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x251CD80 Offset: 0x251CE81 VA: 0x251CD80
	|-Dictionary<ValueTuple<object, int>, object>.Add
	|-Dictionary<ValueTuple<Type, int>, Stack<object>>.Add
	|
	|-RVA: 0x3CF04E0 Offset: 0x3CF05E1 VA: 0x3CF04E0
	|-Dictionary<AkAudioListener, AkObstructionOcclusion.ObstructionOcclusionValue>.Add
	|-Dictionary<Camera, HashSet<Action<RenderTargetIdentifier, CommandBuffer>>>.Add
	|-Dictionary<Canvas, IndexedSet<Graphic>>.Add
	|-Dictionary<CinemachineVirtualCameraBase, CinemachineCore.UpdateStatus>.Add
	|-Dictionary<Collider, AkRoomAwareObject>.Add
	|-Dictionary<FieldInfo, Instruction>.Add
	|-Dictionary<Font, HashSet<Text>>.Add
	|-Dictionary<GameObject, Stack<GameObject>>.Add
	|-Dictionary<GameObject, GameObject>.Add
	|-Dictionary<GmapSpot, GmapSpot>.Add
	|-Dictionary<IDtdEntityInfo, IDtdEntityInfo>.Add
	|-Dictionary<IOperationCacheKey, IAsyncOperation>.Add
	|-Dictionary<IResourceLocation, ContentCatalogProvider.InternalOp>.Add
	|-Dictionary<ItemData, ChallengeMapSelectRoot.ItemDropNum>.Add
	|-Dictionary<object, IList<IResourceLocation>>.Add
	|-Dictionary<object, object>.Add
	|-Dictionary<ParameterExpression, LocalVariable>.Add
	|-Dictionary<Renderer, Material[]>.Add
	|-Dictionary<Renderer, MapObject.DitherPair>.Add
	|-Dictionary<string, List<string>>.Add
	|-Dictionary<string, List<GodGrowthData.LevelData>>.Add
	|-Dictionary<string, List<RangeData.Offset>>.Add
	|-Dictionary<string, Stack<ResourceHandle>>.Add
	|-Dictionary<string, TResourceHandle<AnimationClip>>.Add
	|-Dictionary<string, Tuple<Guid, string>>.Add
	|-Dictionary<string, Color[]>.Add
	|-Dictionary<string, Unit[]>.Add
	|-Dictionary<string, AssetBundleLocalResource>.Add
	|-Dictionary<string, BasicMenuItem>.Add
	|-Dictionary<string, CharacterAsset>.Add
	|-Dictionary<string, FileData>.Add
	|-Dictionary<string, GodBond>.Add
	|-Dictionary<string, GodData>.Add
	|-Dictionary<string, GodUnit>.Add
	|-Dictionary<string, GodWeaponRefineLevels>.Add
	|-Dictionary<string, GodWeaponRefineResult>.Add
	|-Dictionary<string, IMemberDescriptor>.Add
	|-Dictionary<string, LabelStatement>.Add
	|-Dictionary<string, LocalDataStoreSlot>.Add
	|-Dictionary<string, MapObject>.Add
	|-Dictionary<string, MsgFile>.Add
	|-Dictionary<string, Object>.Add
	|-Dictionary<string, PropertyInfo>.Add
	|-Dictionary<string, RelayAwardeeData>.Add
	|-Dictionary<string, ResourceHandle>.Add
	|-Dictionary<string, ResourceLocationBase>.Add
	|-Dictionary<string, ResourceLocationData>.Add
	|-Dictionary<string, RuntimeAnimatorController>.Add
	|-Dictionary<string, SchemaNotation>.Add
	|-Dictionary<string, Sprite>.Add
	|-Dictionary<string, string>.Add
	|-Dictionary<string, SymbolRef>.Add
	|-Dictionary<string, Transform>.Add
	|-Dictionary<string, Type>.Add
	|-Dictionary<string, UnitRelianceData>.Add
	|-Dictionary<string, VibrationFile>.Add
	|-Dictionary<string, AkBankManager.BankHandle>.Add
	|-Dictionary<string, AssetTable.Accessory>.Add
	|-Dictionary<string, ChapterRecord.Record>.Add
	|-Dictionary<string, DtdParser.UndeclaredNotation>.Add
	|-Dictionary<string, EventDemoSequence.CharacterWork>.Add
	|-Dictionary<string, EventDemoSequence.CmdFunc>.Add
	|-Dictionary<string, EventDemoSequence.EffectWork>.Add
	|-Dictionary<string, EventDemoSequence.SplitViewWork>.Add
	|-Dictionary<string, FieldBgmManager.BgmHandle>.Add
	|-Dictionary<string, GameUserRestartData.Growth>.Add
	|-Dictionary<string, RingInfo.RingPrefabObject>.Add
	|-Dictionary<string, ServicePointScheduler.ConnectionGroup>.Add
	|-Dictionary<string, SoundSystem.LipSyncDataFile>.Add
	|-Dictionary<string, SoundWwise.SoundBankManager.BankHandle>.Add
	|-Dictionary<string, SoundWwise.SoundPrepareManager.EventParam>.Add
	|-Dictionary<string, SoundWwise.SoundPrepareManager.SwitchParam>.Add
	|-Dictionary<string, SoundWwise.SoundPrepareManager.SwitchParamList>.Add
	|-Dictionary<Thread, StackTrace>.Add
	|-Dictionary<Transform, TargetPositionCache.CacheEntry>.Add
	|-Dictionary<Transform, UpdateTracker.UpdateStatus>.Add
	|-Dictionary<Type, object>.Add
	|-Dictionary<Type, string>.Add
	|-Dictionary<Type, TrackBindingTypeAttribute>.Add
	|-Dictionary<Type, Transform>.Add
	|-Dictionary<Type, Type>.Add
	|-Dictionary<Type, TypeInformation>.Add
	|-Dictionary<Type, VolumeComponent>.Add
	|-Dictionary<Type, MonoCustomAttrs.AttributeInfo>.Add
	|-Dictionary<Unit, string>.Add
	|-Dictionary<VersusServerReplayMetaData, string>.Add
	|-Dictionary<XmlQualifiedName, SchemaAttDef>.Add
	|-Dictionary<XmlQualifiedName, SchemaElementDecl>.Add
	|-Dictionary<XmlQualifiedName, SchemaEntity>.Add
	|-Dictionary<XmlQualifiedName, XmlQualifiedName>.Add
	|-Dictionary<XmlQualifiedName, XmlSchemaObject>.Add
	|
	|-RVA: 0x25208D0 Offset: 0x25209D1 VA: 0x25208D0
	|-Dictionary<byte, List<byte>>.Add
	|-Dictionary<byte, object>.Add
	|
	|-RVA: 0x3CA5810 Offset: 0x3CA5911 VA: 0x3CA5810
	|-Dictionary<CancellationToken, object>.Add
	|
	|-RVA: 0x3CA9310 Offset: 0x3CA9411 VA: 0x3CA9310
	|-Dictionary<char, object>.Add
	|-Dictionary<char, string>.Add
	|
	|-RVA: 0x3CE5130 Offset: 0x3CE5231 VA: 0x3CE5130
	|-Dictionary<CinemachineVirtualCameraBase, int>.Add
	|-Dictionary<FoodstuffData, int>.Add
	|-Dictionary<ItemData, int>.Add
	|-Dictionary<MapEditorCategoryData, int>.Add
	|-Dictionary<object, int>.Add
	|-Dictionary<string, int>.Add
	|-Dictionary<SymbolRef, int>.Add
	|-Dictionary<Unit, int>.Add
	|
	|-RVA: 0x3CBF9D0 Offset: 0x3CBFAD1 VA: 0x3CBF9D0
	|-Dictionary<FormatUsage, bool>.Add
	|-Dictionary<Int32Enum, bool>.Add
	|-Dictionary<RenderTextureFormat, bool>.Add
	|
	|-RVA: 0x3CD5B70 Offset: 0x3CD5C71 VA: 0x3CD5B70
	|-Dictionary<GameObject, AsyncOperationHandle<GameObject>>.Add
	|-Dictionary<object, AsyncOperationHandle<object>>.Add
	|
	|-RVA: 0x3CCA9B0 Offset: 0x3CCAAB1 VA: 0x3CCA9B0
	|-Dictionary<GraphicsFormat, Dictionary<FormatUsage, bool>>.Add
	|-Dictionary<Int32Enum, object>.Add
	|-Dictionary<KeyHelp.Type, KeyHelp.UI.Element>.Add
	|-Dictionary<Mess.TagGroup, TalkTag>.Add
	|
	|-RVA: 0x3CACE20 Offset: 0x3CACF21 VA: 0x3CACE20
	|-Dictionary<Guid, MonoTlsProvider>.Add
	|-Dictionary<Guid, object>.Add
	|
	|-RVA: 0x3D5BB80 Offset: 0x3D5BC81 VA: 0x3D5BB80
	|-Dictionary<int, List<AchieveData>>.Add
	|-Dictionary<int, List<object>>.Add
	|-Dictionary<int, List<Volume>>.Add
	|-Dictionary<int, RTHandle[]>.Add
	|-Dictionary<int, CalculatorCommand>.Add
	|-Dictionary<int, DiagnosticInfo>.Add
	|-Dictionary<int, GameObject>.Add
	|-Dictionary<int, IResourceProvider>.Add
	|-Dictionary<int, MapInfoIconLocatorRoot>.Add
	|-Dictionary<int, Material>.Add
	|-Dictionary<int, object>.Add
	|-Dictionary<int, PointerEventData>.Add
	|-Dictionary<int, PrefetchedSignal>.Add
	|-Dictionary<int, ProfilingSampler>.Add
	|-Dictionary<int, ResourceGameObject>.Add
	|-Dictionary<int, string>.Add
	|-Dictionary<int, TMP_ColorGradient>.Add
	|-Dictionary<int, TMP_FontAsset>.Add
	|-Dictionary<int, TMP_SpriteAsset>.Add
	|-Dictionary<int, TMP_Style>.Add
	|-Dictionary<int, TimeType>.Add
	|-Dictionary<int, MapEditor.EditObject>.Add
	|-Dictionary<int, TerrainUtility.TerrainMap>.Add
	|-Dictionary<int, MapHistory.Rewind.OverlapData>.Add
	|
	|-RVA: 0x3CB0960 Offset: 0x3CB0A61 VA: 0x3CB0960
	|-Dictionary<int, bool>.Add
	|
	|-RVA: 0x3CB4420 Offset: 0x3CB4521 VA: 0x3CB4420
	|-Dictionary<int, byte>.Add
	|
	|-RVA: 0x3CB7EE0 Offset: 0x3CB7FE1 VA: 0x3CB7EE0
	|-Dictionary<int, char>.Add
	|
	|-RVA: 0x3CBBA90 Offset: 0x3CBBB91 VA: 0x3CBBA90
	|-Dictionary<int, DiagnosticEvent>.Add
	|
	|-RVA: 0x3D4CFA0 Offset: 0x3D4D0A1 VA: 0x3D4CFA0
	|-Dictionary<int, int>.Add
	|
	|-RVA: 0x3D50A30 Offset: 0x3D50B31 VA: 0x3D50A30
	|-Dictionary<int, Int32Enum>.Add
	|-Dictionary<int, MapPanelTarget.DangerType>.Add
	|-Dictionary<int, UnitRecord.Kinds>.Add
	|
	|-RVA: 0x3D544D0 Offset: 0x3D545D1 VA: 0x3D544D0
	|-Dictionary<int, long>.Add
	|
	|-RVA: 0x3D58040 Offset: 0x3D58141 VA: 0x3D58040
	|-Dictionary<int, MapPos>.Add
	|
	|-RVA: 0x3D5F680 Offset: 0x3D5F781 VA: 0x3D5F680
	|-Dictionary<int, uint>.Add
	|
	|-RVA: 0x3D63110 Offset: 0x3D63211 VA: 0x3D63110
	|-Dictionary<int, AIThink.EnchantThink.SurroundingInfo>.Add
	|
	|-RVA: 0x3CC3480 Offset: 0x3CC3581 VA: 0x3CC3480
	|-Dictionary<Int32Enum, int>.Add
	|-Dictionary<UnitRecord.Kinds, int>.Add
	|-Dictionary<HubAccessManager.MaterialCalculator.Type, int>.Add
	|
	|-RVA: 0x3CC6F10 Offset: 0x3CC7011 VA: 0x3CC6F10
	|-Dictionary<Int32Enum, Int32Enum>.Add
	|-Dictionary<RuntimePlatform, AddressablesPlatform>.Add
	|
	|-RVA: 0x3CCE4C0 Offset: 0x3CCE5C1 VA: 0x3CCE4C0
	|-Dictionary<long, object>.Add
	|-Dictionary<long, TMP_MaterialManager.FallbackMaterial>.Add
	|
	|-RVA: 0x3C92A70 Offset: 0x3C92B71 VA: 0x3C92A70
	|-Dictionary<MapCollision, float>.Add
	|-Dictionary<object, float>.Add
	|
	|-RVA: 0x3CD1FB0 Offset: 0x3CD20B1 VA: 0x3CD1FB0
	|-Dictionary<MapPos, int>.Add
	|
	|-RVA: 0x3CD9A90 Offset: 0x3CD9B91 VA: 0x3CD9A90
	|-Dictionary<object, AsyncOperationHandle>.Add
	|-Dictionary<string, AsyncOperationHandle>.Add
	|
	|-RVA: 0x3CDD930 Offset: 0x3CDDA31 VA: 0x3CDD930
	|-Dictionary<object, bool>.Add
	|-Dictionary<string, bool>.Add
	|
	|-RVA: 0x3CE1540 Offset: 0x3CE1641 VA: 0x3CE1540
	|-Dictionary<object, byte>.Add
	|-Dictionary<string, byte>.Add
	|
	|-RVA: 0x3CE8D20 Offset: 0x3CE8E21 VA: 0x3CE8D20
	|-Dictionary<object, Int32Enum>.Add
	|-Dictionary<string, RangeData.Targets>.Add
	|
	|-RVA: 0x3CEC910 Offset: 0x3CECA11 VA: 0x3CEC910
	|-Dictionary<object, IntPtr>.Add
	|-Dictionary<string, IntPtr>.Add
	|
	|-RVA: 0x3C8B290 Offset: 0x3C8B391 VA: 0x3C8B290
	|-Dictionary<object, Playable>.Add
	|
	|-RVA: 0x3C8EE70 Offset: 0x3C8EF71 VA: 0x3C8EE70
	|-Dictionary<object, ResourceLocator>.Add
	|-Dictionary<string, ResourceLocator>.Add
	|
	|-RVA: 0x3C96650 Offset: 0x3C96751 VA: 0x3C96650
	|-Dictionary<object, ushort>.Add
	|-Dictionary<VersusServerReplayMetaData, ushort>.Add
	|
	|-RVA: 0x3C9A240 Offset: 0x3C9A341 VA: 0x3C9A240
	|-Dictionary<object, GameVariable.Value>.Add
	|-Dictionary<string, GameVariable.Value>.Add
	|
	|-RVA: 0x3C9DEF0 Offset: 0x3C9DFF1 VA: 0x3C9DEF0
	|-Dictionary<sbyte, DataStoreRatingInfo>.Add
	|
	|-RVA: 0x3CA1D00 Offset: 0x3CA1E01 VA: 0x3CA1D00
	|-Dictionary<sbyte, DataStoreRatingInitParam>.Add
	|-Dictionary<sbyte, object>.Add
	|
	|-RVA: 0x3D32C00 Offset: 0x3D32D01 VA: 0x3D32C00
	|-Dictionary<ushort, int>.Add
	|
	|-RVA: 0x3D3A150 Offset: 0x3D3A251 VA: 0x3D3A150
	|-Dictionary<uint, AkMultiPosEvent>.Add
	|-Dictionary<uint, Glyph>.Add
	|-Dictionary<uint, object>.Add
	|-Dictionary<uint, string>.Add
	|-Dictionary<uint, TMP_Character>.Add
	|-Dictionary<uint, TMP_GlyphPairAdjustmentRecord>.Add
	|-Dictionary<uint, TMP_SpriteCharacter>.Add
	|-Dictionary<uint, TMP_SpriteGlyph>.Add
	|-Dictionary<uint, AkAudioInputManager.AudioFormatDelegate>.Add
	|-Dictionary<uint, AkAudioInputManager.AudioSamplesDelegate>.Add
	|
	|-RVA: 0x3D366B0 Offset: 0x3D367B1 VA: 0x3D366B0
	|-Dictionary<uint, int>.Add
	|
	|-RVA: 0x3D3DD60 Offset: 0x3D3DE61 VA: 0x3D3DD60
	|-Dictionary<ulong, Friend>.Add
	|
	|-RVA: 0x3D41CB0 Offset: 0x3D41DB1 VA: 0x3D41CB0
	|-Dictionary<ulong, Int32Enum>.Add
	|-Dictionary<ulong, NexVersus.TargetSlotList.Results>.Add
	|
	|-RVA: 0x3D45820 Offset: 0x3D45921 VA: 0x3D45820
	|-Dictionary<ulong, object>.Add
	|-Dictionary<ulong, RelayUserGlobalData.Ticket>.Add
	|
	|-RVA: 0x3D49320 Offset: 0x3D49421 VA: 0x3D49320
	|-Dictionary<Vector3, int>.Add
	|
	|-RVA: 0x2627750 Offset: 0x2627851 VA: 0x2627750
	|-Dictionary<XPathNodeRef, XPathNodeRef>.Add
	|
	|-RVA: 0x262B3F0 Offset: 0x262B4F1 VA: 0x262B3F0
	|-Dictionary<TerrainUtility.TerrainMap.TileCoord, object>.Add
	|-Dictionary<TerrainUtility.TerrainMap.TileCoord, Terrain>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 9
	private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(KeyValuePair<TKey, TValue> keyValuePair) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x251CDA0 Offset: 0x251CEA1 VA: 0x251CDA0
	|-Dictionary<ValueTuple<object, int>, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x25208F0 Offset: 0x25209F1 VA: 0x25208F0
	|-Dictionary<byte, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x3CA5830 Offset: 0x3CA5931 VA: 0x3CA5830
	|-Dictionary<CancellationToken, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x3CA9330 Offset: 0x3CA9431 VA: 0x3CA9330
	|-Dictionary<char, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x3CACE40 Offset: 0x3CACF41 VA: 0x3CACE40
	|-Dictionary<Guid, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x3CB0980 Offset: 0x3CB0A81 VA: 0x3CB0980
	|-Dictionary<int, bool>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x3CB4440 Offset: 0x3CB4541 VA: 0x3CB4440
	|-Dictionary<int, byte>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x3D5BBA0 Offset: 0x3D5BCA1 VA: 0x3D5BBA0
	|-Dictionary<int, CalculatorCommand>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|-Dictionary<int, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|-Dictionary<int, TerrainUtility.TerrainMap>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x3CB7F00 Offset: 0x3CB8001 VA: 0x3CB7F00
	|-Dictionary<int, char>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x3CBBAF0 Offset: 0x3CBBBF1 VA: 0x3CBBAF0
	|-Dictionary<int, DiagnosticEvent>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x3D4CFC0 Offset: 0x3D4D0C1 VA: 0x3D4CFC0
	|-Dictionary<int, int>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x3D50A50 Offset: 0x3D50B51 VA: 0x3D50A50
	|-Dictionary<int, Int32Enum>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x3D544F0 Offset: 0x3D545F1 VA: 0x3D544F0
	|-Dictionary<int, long>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x3D58060 Offset: 0x3D58161 VA: 0x3D58060
	|-Dictionary<int, MapPos>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x3D5F6A0 Offset: 0x3D5F7A1 VA: 0x3D5F6A0
	|-Dictionary<int, uint>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x3D63130 Offset: 0x3D63231 VA: 0x3D63130
	|-Dictionary<int, AIThink.EnchantThink.SurroundingInfo>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x3CBF9F0 Offset: 0x3CBFAF1 VA: 0x3CBF9F0
	|-Dictionary<Int32Enum, bool>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x3CC34A0 Offset: 0x3CC35A1 VA: 0x3CC34A0
	|-Dictionary<Int32Enum, int>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x3CC6F30 Offset: 0x3CC7031 VA: 0x3CC6F30
	|-Dictionary<Int32Enum, Int32Enum>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x3CCA9D0 Offset: 0x3CCAAD1 VA: 0x3CCA9D0
	|-Dictionary<Int32Enum, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x3CCE4E0 Offset: 0x3CCE5E1 VA: 0x3CCE4E0
	|-Dictionary<long, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x3CD1FD0 Offset: 0x3CD20D1 VA: 0x3CD1FD0
	|-Dictionary<MapPos, int>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x3CD5BC0 Offset: 0x3CD5CC1 VA: 0x3CD5BC0
	|-Dictionary<object, AsyncOperationHandle<object>>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x3CD9AE0 Offset: 0x3CD9BE1 VA: 0x3CD9AE0
	|-Dictionary<object, AsyncOperationHandle>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x3CDD950 Offset: 0x3CDDA51 VA: 0x3CDD950
	|-Dictionary<object, bool>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x3CE1560 Offset: 0x3CE1661 VA: 0x3CE1560
	|-Dictionary<object, byte>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x3CE5150 Offset: 0x3CE5251 VA: 0x3CE5150
	|-Dictionary<object, int>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|-Dictionary<string, int>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x3CE8D40 Offset: 0x3CE8E41 VA: 0x3CE8D40
	|-Dictionary<object, Int32Enum>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x3CEC930 Offset: 0x3CECA31 VA: 0x3CEC930
	|-Dictionary<object, IntPtr>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x3CF0500 Offset: 0x3CF0601 VA: 0x3CF0500
	|-Dictionary<object, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|-Dictionary<string, GameUserRestartData.Growth>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x3C8B2B0 Offset: 0x3C8B3B1 VA: 0x3C8B2B0
	|-Dictionary<object, Playable>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x3C8EE90 Offset: 0x3C8EF91 VA: 0x3C8EE90
	|-Dictionary<object, ResourceLocator>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x3C92A90 Offset: 0x3C92B91 VA: 0x3C92A90
	|-Dictionary<object, float>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x3C96670 Offset: 0x3C96771 VA: 0x3C96670
	|-Dictionary<object, ushort>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x3C9A260 Offset: 0x3C9A361 VA: 0x3C9A260
	|-Dictionary<object, GameVariable.Value>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x3C9DF40 Offset: 0x3C9E041 VA: 0x3C9DF40
	|-Dictionary<sbyte, DataStoreRatingInfo>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x3CA1D20 Offset: 0x3CA1E21 VA: 0x3CA1D20
	|-Dictionary<sbyte, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x3D32C20 Offset: 0x3D32D21 VA: 0x3D32C20
	|-Dictionary<ushort, int>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x3D366D0 Offset: 0x3D367D1 VA: 0x3D366D0
	|-Dictionary<uint, int>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x3D3A170 Offset: 0x3D3A271 VA: 0x3D3A170
	|-Dictionary<uint, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x3D3DDF0 Offset: 0x3D3DEF1 VA: 0x3D3DDF0
	|-Dictionary<ulong, Friend>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x3D41CD0 Offset: 0x3D41DD1 VA: 0x3D41CD0
	|-Dictionary<ulong, Int32Enum>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x3D45840 Offset: 0x3D45941 VA: 0x3D45840
	|-Dictionary<ulong, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x3D49340 Offset: 0x3D49441 VA: 0x3D49340
	|-Dictionary<Vector3, int>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x2627770 Offset: 0x2627871 VA: 0x2627770
	|-Dictionary<XPathNodeRef, XPathNodeRef>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x262B410 Offset: 0x262B511 VA: 0x262B410
	|-Dictionary<TerrainUtility.TerrainMap.TileCoord, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 11
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(KeyValuePair<TKey, TValue> keyValuePair) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x251CDC0 Offset: 0x251CEC1 VA: 0x251CDC0
	|-Dictionary<ValueTuple<object, int>, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x2520910 Offset: 0x2520A11 VA: 0x2520910
	|-Dictionary<byte, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x3CA5850 Offset: 0x3CA5951 VA: 0x3CA5850
	|-Dictionary<CancellationToken, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x3CA9350 Offset: 0x3CA9451 VA: 0x3CA9350
	|-Dictionary<char, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x3CACE60 Offset: 0x3CACF61 VA: 0x3CACE60
	|-Dictionary<Guid, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x3CB09A0 Offset: 0x3CB0AA1 VA: 0x3CB09A0
	|-Dictionary<int, bool>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x3CB4460 Offset: 0x3CB4561 VA: 0x3CB4460
	|-Dictionary<int, byte>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x3D5BBC0 Offset: 0x3D5BCC1 VA: 0x3D5BBC0
	|-Dictionary<int, CalculatorCommand>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|-Dictionary<int, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|-Dictionary<int, TerrainUtility.TerrainMap>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x3CB7F20 Offset: 0x3CB8021 VA: 0x3CB7F20
	|-Dictionary<int, char>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x3CBBB50 Offset: 0x3CBBC51 VA: 0x3CBBB50
	|-Dictionary<int, DiagnosticEvent>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x3D4CFE0 Offset: 0x3D4D0E1 VA: 0x3D4CFE0
	|-Dictionary<int, int>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x3D50A70 Offset: 0x3D50B71 VA: 0x3D50A70
	|-Dictionary<int, Int32Enum>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x3D54510 Offset: 0x3D54611 VA: 0x3D54510
	|-Dictionary<int, long>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x3D58090 Offset: 0x3D58191 VA: 0x3D58090
	|-Dictionary<int, MapPos>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x3D5F6C0 Offset: 0x3D5F7C1 VA: 0x3D5F6C0
	|-Dictionary<int, uint>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x3D63150 Offset: 0x3D63251 VA: 0x3D63150
	|-Dictionary<int, AIThink.EnchantThink.SurroundingInfo>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x3CBFA10 Offset: 0x3CBFB11 VA: 0x3CBFA10
	|-Dictionary<Int32Enum, bool>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x3CC34C0 Offset: 0x3CC35C1 VA: 0x3CC34C0
	|-Dictionary<Int32Enum, int>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x3CC6F50 Offset: 0x3CC7051 VA: 0x3CC6F50
	|-Dictionary<Int32Enum, Int32Enum>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x3CCA9F0 Offset: 0x3CCAAF1 VA: 0x3CCA9F0
	|-Dictionary<Int32Enum, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x3CCE500 Offset: 0x3CCE601 VA: 0x3CCE500
	|-Dictionary<long, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x3CD1FF0 Offset: 0x3CD20F1 VA: 0x3CD1FF0
	|-Dictionary<MapPos, int>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x3CD5C10 Offset: 0x3CD5D11 VA: 0x3CD5C10
	|-Dictionary<object, AsyncOperationHandle<object>>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x3CD9B30 Offset: 0x3CD9C31 VA: 0x3CD9B30
	|-Dictionary<object, AsyncOperationHandle>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x3CDD970 Offset: 0x3CDDA71 VA: 0x3CDD970
	|-Dictionary<object, bool>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x3CE1580 Offset: 0x3CE1681 VA: 0x3CE1580
	|-Dictionary<object, byte>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x3CE5170 Offset: 0x3CE5271 VA: 0x3CE5170
	|-Dictionary<object, int>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|-Dictionary<string, int>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x3CE8D60 Offset: 0x3CE8E61 VA: 0x3CE8D60
	|-Dictionary<object, Int32Enum>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x3CEC950 Offset: 0x3CECA51 VA: 0x3CEC950
	|-Dictionary<object, IntPtr>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x3CF0520 Offset: 0x3CF0621 VA: 0x3CF0520
	|-Dictionary<object, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|-Dictionary<string, GameUserRestartData.Growth>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x3C8B2D0 Offset: 0x3C8B3D1 VA: 0x3C8B2D0
	|-Dictionary<object, Playable>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x3C8EEB0 Offset: 0x3C8EFB1 VA: 0x3C8EEB0
	|-Dictionary<object, ResourceLocator>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x3C92AB0 Offset: 0x3C92BB1 VA: 0x3C92AB0
	|-Dictionary<object, float>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x3C96690 Offset: 0x3C96791 VA: 0x3C96690
	|-Dictionary<object, ushort>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x3C9A280 Offset: 0x3C9A381 VA: 0x3C9A280
	|-Dictionary<object, GameVariable.Value>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x3C9DF90 Offset: 0x3C9E091 VA: 0x3C9DF90
	|-Dictionary<sbyte, DataStoreRatingInfo>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x3CA1D40 Offset: 0x3CA1E41 VA: 0x3CA1D40
	|-Dictionary<sbyte, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x3D32C40 Offset: 0x3D32D41 VA: 0x3D32C40
	|-Dictionary<ushort, int>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x3D366F0 Offset: 0x3D367F1 VA: 0x3D366F0
	|-Dictionary<uint, int>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x3D3A190 Offset: 0x3D3A291 VA: 0x3D3A190
	|-Dictionary<uint, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x3D3DE70 Offset: 0x3D3DF71 VA: 0x3D3DE70
	|-Dictionary<ulong, Friend>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x3D41CF0 Offset: 0x3D41DF1 VA: 0x3D41CF0
	|-Dictionary<ulong, Int32Enum>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x3D45860 Offset: 0x3D45961 VA: 0x3D45860
	|-Dictionary<ulong, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x3D49370 Offset: 0x3D49471 VA: 0x3D49370
	|-Dictionary<Vector3, int>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x2627790 Offset: 0x2627891 VA: 0x2627790
	|-Dictionary<XPathNodeRef, XPathNodeRef>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x262B430 Offset: 0x262B531 VA: 0x262B430
	|-Dictionary<TerrainUtility.TerrainMap.TileCoord, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 13
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(KeyValuePair<TKey, TValue> keyValuePair) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x251CE80 Offset: 0x251CF81 VA: 0x251CE80
	|-Dictionary<ValueTuple<object, int>, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x25209C0 Offset: 0x2520AC1 VA: 0x25209C0
	|-Dictionary<byte, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x3CA5900 Offset: 0x3CA5A01 VA: 0x3CA5900
	|-Dictionary<CancellationToken, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x3CA9400 Offset: 0x3CA9501 VA: 0x3CA9400
	|-Dictionary<char, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x3CACF20 Offset: 0x3CAD021 VA: 0x3CACF20
	|-Dictionary<Guid, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x3CB0A50 Offset: 0x3CB0B51 VA: 0x3CB0A50
	|-Dictionary<int, bool>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x3CB4510 Offset: 0x3CB4611 VA: 0x3CB4510
	|-Dictionary<int, byte>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x3D5BC70 Offset: 0x3D5BD71 VA: 0x3D5BC70
	|-Dictionary<int, CalculatorCommand>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|-Dictionary<int, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|-Dictionary<int, TerrainUtility.TerrainMap>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x3CB7FD0 Offset: 0x3CB80D1 VA: 0x3CB7FD0
	|-Dictionary<int, char>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x3CBBC70 Offset: 0x3CBBD71 VA: 0x3CBBC70
	|-Dictionary<int, DiagnosticEvent>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x3D4D090 Offset: 0x3D4D191 VA: 0x3D4D090
	|-Dictionary<int, int>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x3D50B20 Offset: 0x3D50C21 VA: 0x3D50B20
	|-Dictionary<int, Int32Enum>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x3D545C0 Offset: 0x3D546C1 VA: 0x3D545C0
	|-Dictionary<int, long>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x3D58140 Offset: 0x3D58241 VA: 0x3D58140
	|-Dictionary<int, MapPos>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x3D5F770 Offset: 0x3D5F871 VA: 0x3D5F770
	|-Dictionary<int, uint>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x3D63200 Offset: 0x3D63301 VA: 0x3D63200
	|-Dictionary<int, AIThink.EnchantThink.SurroundingInfo>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x3CBFAC0 Offset: 0x3CBFBC1 VA: 0x3CBFAC0
	|-Dictionary<Int32Enum, bool>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x3CC3570 Offset: 0x3CC3671 VA: 0x3CC3570
	|-Dictionary<Int32Enum, int>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x3CC7000 Offset: 0x3CC7101 VA: 0x3CC7000
	|-Dictionary<Int32Enum, Int32Enum>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x3CCAAA0 Offset: 0x3CCABA1 VA: 0x3CCAAA0
	|-Dictionary<Int32Enum, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x3CCE5B0 Offset: 0x3CCE6B1 VA: 0x3CCE5B0
	|-Dictionary<long, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x3CD20A0 Offset: 0x3CD21A1 VA: 0x3CD20A0
	|-Dictionary<MapPos, int>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x3CD5D10 Offset: 0x3CD5E11 VA: 0x3CD5D10
	|-Dictionary<object, AsyncOperationHandle<object>>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x3CD9C30 Offset: 0x3CD9D31 VA: 0x3CD9C30
	|-Dictionary<object, AsyncOperationHandle>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x3CDDA30 Offset: 0x3CDDB31 VA: 0x3CDDA30
	|-Dictionary<object, bool>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x3CE1630 Offset: 0x3CE1731 VA: 0x3CE1630
	|-Dictionary<object, byte>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x3CE5220 Offset: 0x3CE5321 VA: 0x3CE5220
	|-Dictionary<object, int>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|-Dictionary<string, int>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x3CE8E10 Offset: 0x3CE8F11 VA: 0x3CE8E10
	|-Dictionary<object, Int32Enum>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x3CECA00 Offset: 0x3CECB01 VA: 0x3CECA00
	|-Dictionary<object, IntPtr>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x3CF05D0 Offset: 0x3CF06D1 VA: 0x3CF05D0
	|-Dictionary<object, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|-Dictionary<string, GameUserRestartData.Growth>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x3C8B390 Offset: 0x3C8B491 VA: 0x3C8B390
	|-Dictionary<object, Playable>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x3C8EF70 Offset: 0x3C8F071 VA: 0x3C8EF70
	|-Dictionary<object, ResourceLocator>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x3C92B60 Offset: 0x3C92C61 VA: 0x3C92B60
	|-Dictionary<object, float>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x3C96740 Offset: 0x3C96841 VA: 0x3C96740
	|-Dictionary<object, ushort>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x3C9A340 Offset: 0x3C9A441 VA: 0x3C9A340
	|-Dictionary<object, GameVariable.Value>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x3C9E090 Offset: 0x3C9E191 VA: 0x3C9E090
	|-Dictionary<sbyte, DataStoreRatingInfo>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x3CA1DF0 Offset: 0x3CA1EF1 VA: 0x3CA1DF0
	|-Dictionary<sbyte, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x3D32CF0 Offset: 0x3D32DF1 VA: 0x3D32CF0
	|-Dictionary<ushort, int>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x3D367A0 Offset: 0x3D368A1 VA: 0x3D367A0
	|-Dictionary<uint, int>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x3D3A240 Offset: 0x3D3A341 VA: 0x3D3A240
	|-Dictionary<uint, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x3D3DF80 Offset: 0x3D3E081 VA: 0x3D3DF80
	|-Dictionary<ulong, Friend>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x3D41DA0 Offset: 0x3D41EA1 VA: 0x3D41DA0
	|-Dictionary<ulong, Int32Enum>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x3D45910 Offset: 0x3D45A11 VA: 0x3D45910
	|-Dictionary<ulong, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x3D49430 Offset: 0x3D49531 VA: 0x3D49430
	|-Dictionary<Vector3, int>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x2627850 Offset: 0x2627951 VA: 0x2627850
	|-Dictionary<XPathNodeRef, XPathNodeRef>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x262B4E0 Offset: 0x262B5E1 VA: 0x262B4E0
	|-Dictionary<TerrainUtility.TerrainMap.TileCoord, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x251CF60 Offset: 0x251D061 VA: 0x251CF60
	|-Dictionary<ValueTuple<object, int>, object>.Clear
	|
	|-RVA: 0x2520A90 Offset: 0x2520B91 VA: 0x2520A90
	|-Dictionary<byte, object>.Clear
	|
	|-RVA: 0x3CF06A0 Offset: 0x3CF07A1 VA: 0x3CF06A0
	|-Dictionary<Camera, Camera>.Clear
	|-Dictionary<GameObject, Stack<GameObject>>.Clear
	|-Dictionary<GameObject, GameObject>.Clear
	|-Dictionary<object, object>.Clear
	|-Dictionary<Renderer, Material[]>.Clear
	|-Dictionary<Renderer, MapObject.DitherPair>.Clear
	|-Dictionary<string, List<GodGrowthData.LevelData>>.Clear
	|-Dictionary<string, List<RangeData.Offset>>.Clear
	|-Dictionary<string, Stack<ResourceHandle>>.Clear
	|-Dictionary<string, TResourceHandle<AnimationClip>>.Clear
	|-Dictionary<string, CharacterAsset>.Clear
	|-Dictionary<string, GodBond>.Clear
	|-Dictionary<string, GodUnit>.Clear
	|-Dictionary<string, GodWeaponRefineLevels>.Clear
	|-Dictionary<string, GodWeaponRefineResult>.Clear
	|-Dictionary<string, MapObject>.Clear
	|-Dictionary<string, MsgFile>.Clear
	|-Dictionary<string, RelayAwardeeData>.Clear
	|-Dictionary<string, ResourceHandle>.Clear
	|-Dictionary<string, Sprite>.Clear
	|-Dictionary<string, string>.Clear
	|-Dictionary<string, UnitRelianceData>.Clear
	|-Dictionary<string, VibrationFile>.Clear
	|-Dictionary<string, AkBankManager.BankHandle>.Clear
	|-Dictionary<string, AssetTable.Accessory>.Clear
	|-Dictionary<string, ChapterRecord.Record>.Clear
	|-Dictionary<string, EventDemoSequence.CmdFunc>.Clear
	|-Dictionary<string, FieldBgmManager.BgmHandle>.Clear
	|-Dictionary<string, GameUserRestartData.Growth>.Clear
	|-Dictionary<string, SoundSystem.LipSyncDataFile>.Clear
	|-Dictionary<string, SoundWwise.SoundBankManager.BankHandle>.Clear
	|-Dictionary<string, SoundWwise.SoundPrepareManager.EventParam>.Clear
	|-Dictionary<string, SoundWwise.SoundPrepareManager.SwitchParam>.Clear
	|-Dictionary<string, SoundWwise.SoundPrepareManager.SwitchParamList>.Clear
	|-Dictionary<Transform, UpdateTracker.UpdateStatus>.Clear
	|-Dictionary<Type, Func<DynValue, object>>.Clear
	|-Dictionary<Type, Func<Script, object, DynValue>>.Clear
	|-Dictionary<Type, object>.Clear
	|-Dictionary<Type, Transform>.Clear
	|-Dictionary<Type, VolumeComponent>.Clear
	|-Dictionary<Unit, string>.Clear
	|-Dictionary<XmlQualifiedName, XmlSchemaObject>.Clear
	|
	|-RVA: 0x3CA59D0 Offset: 0x3CA5AD1 VA: 0x3CA59D0
	|-Dictionary<CancellationToken, object>.Clear
	|
	|-RVA: 0x3CA94D0 Offset: 0x3CA95D1 VA: 0x3CA94D0
	|-Dictionary<char, object>.Clear
	|
	|-RVA: 0x3CCAB70 Offset: 0x3CCAC71 VA: 0x3CCAB70
	|-Dictionary<GraphicsFormat, Dictionary<FormatUsage, bool>>.Clear
	|-Dictionary<Int32Enum, object>.Clear
	|
	|-RVA: 0x3CAD000 Offset: 0x3CAD101 VA: 0x3CAD000
	|-Dictionary<Guid, object>.Clear
	|
	|-RVA: 0x3D5BD40 Offset: 0x3D5BE41 VA: 0x3D5BD40
	|-Dictionary<int, List<AchieveData>>.Clear
	|-Dictionary<int, RTHandle[]>.Clear
	|-Dictionary<int, CalculatorCommand>.Clear
	|-Dictionary<int, GameObject>.Clear
	|-Dictionary<int, MapInfoIconLocatorRoot>.Clear
	|-Dictionary<int, object>.Clear
	|-Dictionary<int, PointerEventData>.Clear
	|-Dictionary<int, ResourceGameObject>.Clear
	|-Dictionary<int, string>.Clear
	|-Dictionary<int, TMP_Style>.Clear
	|-Dictionary<int, MapEditor.EditObject>.Clear
	|-Dictionary<int, TerrainUtility.TerrainMap>.Clear
	|-Dictionary<int, MapHistory.Rewind.OverlapData>.Clear
	|
	|-RVA: 0x3CB0B20 Offset: 0x3CB0C21 VA: 0x3CB0B20
	|-Dictionary<int, bool>.Clear
	|
	|-RVA: 0x3CB45E0 Offset: 0x3CB46E1 VA: 0x3CB45E0
	|-Dictionary<int, byte>.Clear
	|
	|-RVA: 0x3CB80A0 Offset: 0x3CB81A1 VA: 0x3CB80A0
	|-Dictionary<int, char>.Clear
	|
	|-RVA: 0x3CBBDA0 Offset: 0x3CBBEA1 VA: 0x3CBBDA0
	|-Dictionary<int, DiagnosticEvent>.Clear
	|
	|-RVA: 0x3D4D160 Offset: 0x3D4D261 VA: 0x3D4D160
	|-Dictionary<int, int>.Clear
	|
	|-RVA: 0x3D50BF0 Offset: 0x3D50CF1 VA: 0x3D50BF0
	|-Dictionary<int, Int32Enum>.Clear
	|-Dictionary<int, MapPanelTarget.DangerType>.Clear
	|-Dictionary<int, UnitRecord.Kinds>.Clear
	|
	|-RVA: 0x3D54690 Offset: 0x3D54791 VA: 0x3D54690
	|-Dictionary<int, long>.Clear
	|
	|-RVA: 0x3D58210 Offset: 0x3D58311 VA: 0x3D58210
	|-Dictionary<int, MapPos>.Clear
	|
	|-RVA: 0x3D5F840 Offset: 0x3D5F941 VA: 0x3D5F840
	|-Dictionary<int, uint>.Clear
	|
	|-RVA: 0x3D632D0 Offset: 0x3D633D1 VA: 0x3D632D0
	|-Dictionary<int, AIThink.EnchantThink.SurroundingInfo>.Clear
	|
	|-RVA: 0x3CBFB90 Offset: 0x3CBFC91 VA: 0x3CBFB90
	|-Dictionary<Int32Enum, bool>.Clear
	|-Dictionary<RenderTextureFormat, bool>.Clear
	|
	|-RVA: 0x3CC3640 Offset: 0x3CC3741 VA: 0x3CC3640
	|-Dictionary<Int32Enum, int>.Clear
	|-Dictionary<UnitRecord.Kinds, int>.Clear
	|
	|-RVA: 0x3CC70D0 Offset: 0x3CC71D1 VA: 0x3CC70D0
	|-Dictionary<Int32Enum, Int32Enum>.Clear
	|
	|-RVA: 0x3CCE680 Offset: 0x3CCE781 VA: 0x3CCE680
	|-Dictionary<long, object>.Clear
	|
	|-RVA: 0x3C92C30 Offset: 0x3C92D31 VA: 0x3C92C30
	|-Dictionary<MapCollision, float>.Clear
	|-Dictionary<object, float>.Clear
	|
	|-RVA: 0x3CD2170 Offset: 0x3CD2271 VA: 0x3CD2170
	|-Dictionary<MapPos, int>.Clear
	|
	|-RVA: 0x3CD5E20 Offset: 0x3CD5F21 VA: 0x3CD5E20
	|-Dictionary<object, AsyncOperationHandle<object>>.Clear
	|
	|-RVA: 0x3CD9D40 Offset: 0x3CD9E41 VA: 0x3CD9D40
	|-Dictionary<object, AsyncOperationHandle>.Clear
	|-Dictionary<string, AsyncOperationHandle>.Clear
	|
	|-RVA: 0x3CDDB00 Offset: 0x3CDDC01 VA: 0x3CDDB00
	|-Dictionary<object, bool>.Clear
	|-Dictionary<string, bool>.Clear
	|
	|-RVA: 0x3CE1700 Offset: 0x3CE1801 VA: 0x3CE1700
	|-Dictionary<object, byte>.Clear
	|-Dictionary<string, byte>.Clear
	|
	|-RVA: 0x3CE52F0 Offset: 0x3CE53F1 VA: 0x3CE52F0
	|-Dictionary<object, int>.Clear
	|-Dictionary<string, int>.Clear
	|-Dictionary<Unit, int>.Clear
	|
	|-RVA: 0x3CE8EE0 Offset: 0x3CE8FE1 VA: 0x3CE8EE0
	|-Dictionary<object, Int32Enum>.Clear
	|-Dictionary<string, RangeData.Targets>.Clear
	|
	|-RVA: 0x3CECAD0 Offset: 0x3CECBD1 VA: 0x3CECAD0
	|-Dictionary<object, IntPtr>.Clear
	|-Dictionary<string, IntPtr>.Clear
	|
	|-RVA: 0x3C8B460 Offset: 0x3C8B561 VA: 0x3C8B460
	|-Dictionary<object, Playable>.Clear
	|-Dictionary<TrackAsset, Playable>.Clear
	|
	|-RVA: 0x3C8F040 Offset: 0x3C8F141 VA: 0x3C8F040
	|-Dictionary<object, ResourceLocator>.Clear
	|
	|-RVA: 0x3C96810 Offset: 0x3C96911 VA: 0x3C96810
	|-Dictionary<object, ushort>.Clear
	|
	|-RVA: 0x3C9A410 Offset: 0x3C9A511 VA: 0x3C9A410
	|-Dictionary<object, GameVariable.Value>.Clear
	|-Dictionary<string, GameVariable.Value>.Clear
	|
	|-RVA: 0x3C9E1A0 Offset: 0x3C9E2A1 VA: 0x3C9E1A0
	|-Dictionary<sbyte, DataStoreRatingInfo>.Clear
	|
	|-RVA: 0x3CA1EC0 Offset: 0x3CA1FC1 VA: 0x3CA1EC0
	|-Dictionary<sbyte, DataStoreRatingInitParam>.Clear
	|-Dictionary<sbyte, object>.Clear
	|
	|-RVA: 0x3D32DC0 Offset: 0x3D32EC1 VA: 0x3D32DC0
	|-Dictionary<ushort, int>.Clear
	|
	|-RVA: 0x3D3A310 Offset: 0x3D3A411 VA: 0x3D3A310
	|-Dictionary<uint, Glyph>.Clear
	|-Dictionary<uint, object>.Clear
	|-Dictionary<uint, TMP_Character>.Clear
	|-Dictionary<uint, TMP_GlyphPairAdjustmentRecord>.Clear
	|-Dictionary<uint, TMP_SpriteCharacter>.Clear
	|-Dictionary<uint, TMP_SpriteGlyph>.Clear
	|
	|-RVA: 0x3D36870 Offset: 0x3D36971 VA: 0x3D36870
	|-Dictionary<uint, int>.Clear
	|
	|-RVA: 0x3D3E0B0 Offset: 0x3D3E1B1 VA: 0x3D3E0B0
	|-Dictionary<ulong, Friend>.Clear
	|
	|-RVA: 0x3D41E70 Offset: 0x3D41F71 VA: 0x3D41E70
	|-Dictionary<ulong, Int32Enum>.Clear
	|-Dictionary<ulong, NexVersus.TargetSlotList.Results>.Clear
	|
	|-RVA: 0x3D459E0 Offset: 0x3D45AE1 VA: 0x3D459E0
	|-Dictionary<ulong, object>.Clear
	|-Dictionary<ulong, RelayUserGlobalData.Ticket>.Clear
	|
	|-RVA: 0x3D49530 Offset: 0x3D49631 VA: 0x3D49530
	|-Dictionary<Vector3, int>.Clear
	|
	|-RVA: 0x2627930 Offset: 0x2627A31 VA: 0x2627930
	|-Dictionary<XPathNodeRef, XPathNodeRef>.Clear
	|
	|-RVA: 0x262B5B0 Offset: 0x262B6B1 VA: 0x262B5B0
	|-Dictionary<TerrainUtility.TerrainMap.TileCoord, object>.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 36
	public bool ContainsKey(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x251D000 Offset: 0x251D101 VA: 0x251D000
	|-Dictionary<ValueTuple<object, int>, object>.ContainsKey
	|
	|-RVA: 0x3CF0740 Offset: 0x3CF0841 VA: 0x3CF0740
	|-Dictionary<Action, LinkedListNode<Action>>.ContainsKey
	|-Dictionary<AkAudioListener, AkObstructionOcclusion.ObstructionOcclusionValue>.ContainsKey
	|-Dictionary<CinemachineVirtualCameraBase, CinemachineCore.UpdateStatus>.ContainsKey
	|-Dictionary<GmapSpot, GmapSpot>.ContainsKey
	|-Dictionary<IDtdEntityInfo, IDtdEntityInfo>.ContainsKey
	|-Dictionary<IOperationCacheKey, IAsyncOperation>.ContainsKey
	|-Dictionary<IResourceLocation, ContentCatalogProvider.InternalOp>.ContainsKey
	|-Dictionary<ItemData, ChallengeMapSelectRoot.ItemDropNum>.ContainsKey
	|-Dictionary<object, object>.ContainsKey
	|-Dictionary<Renderer, Material[]>.ContainsKey
	|-Dictionary<string, List<Renderer>>.ContainsKey
	|-Dictionary<string, List<string>>.ContainsKey
	|-Dictionary<string, Stack<ResourceHandle>>.ContainsKey
	|-Dictionary<string, Color[]>.ContainsKey
	|-Dictionary<string, BasicMenuItem>.ContainsKey
	|-Dictionary<string, CharacterAsset>.ContainsKey
	|-Dictionary<string, GodUnit>.ContainsKey
	|-Dictionary<string, IMemberDescriptor>.ContainsKey
	|-Dictionary<string, LabelStatement>.ContainsKey
	|-Dictionary<string, MapObject>.ContainsKey
	|-Dictionary<string, MsgFile>.ContainsKey
	|-Dictionary<string, object>.ContainsKey
	|-Dictionary<string, PropertyInfo>.ContainsKey
	|-Dictionary<string, ResourceLocationBase>.ContainsKey
	|-Dictionary<string, SchemaNotation>.ContainsKey
	|-Dictionary<string, SpringCapsuleCollider>.ContainsKey
	|-Dictionary<string, SpringPanelCollider>.ContainsKey
	|-Dictionary<string, SpringSphereCollider>.ContainsKey
	|-Dictionary<string, Sprite>.ContainsKey
	|-Dictionary<string, string>.ContainsKey
	|-Dictionary<string, Transform>.ContainsKey
	|-Dictionary<string, AssetTable.Accessory>.ContainsKey
	|-Dictionary<string, EventDemoSequence.CharacterWork>.ContainsKey
	|-Dictionary<string, EventDemoSequence.EffectWork>.ContainsKey
	|-Dictionary<string, EventDemoSequence.SplitViewWork>.ContainsKey
	|-Dictionary<string, GameUserRestartData.Growth>.ContainsKey
	|-Dictionary<string, RingInfo.RingPrefabObject>.ContainsKey
	|-Dictionary<string, ServicePointScheduler.ConnectionGroup>.ContainsKey
	|-Dictionary<string, SoundSystem.LipSyncDataFile>.ContainsKey
	|-Dictionary<Type, Func<DynValue, object>>.ContainsKey
	|-Dictionary<Type, Func<Script, object, DynValue>>.ContainsKey
	|-Dictionary<Type, IPropertyTableAssigner>.ContainsKey
	|-Dictionary<Type, IUserDataDescriptor>.ContainsKey
	|-Dictionary<Unit, string>.ContainsKey
	|-Dictionary<XmlQualifiedName, SchemaAttDef>.ContainsKey
	|-Dictionary<XmlQualifiedName, SchemaElementDecl>.ContainsKey
	|-Dictionary<XmlQualifiedName, SchemaEntity>.ContainsKey
	|-Dictionary<XmlQualifiedName, XmlQualifiedName>.ContainsKey
	|-Dictionary<XmlQualifiedName, XmlSchemaObject>.ContainsKey
	|
	|-RVA: 0x2520B30 Offset: 0x2520C31 VA: 0x2520B30
	|-Dictionary<byte, List<byte>>.ContainsKey
	|-Dictionary<byte, object>.ContainsKey
	|
	|-RVA: 0x3CA5A70 Offset: 0x3CA5B71 VA: 0x3CA5A70
	|-Dictionary<CancellationToken, object>.ContainsKey
	|
	|-RVA: 0x3CA9570 Offset: 0x3CA9671 VA: 0x3CA9570
	|-Dictionary<char, object>.ContainsKey
	|-Dictionary<char, string>.ContainsKey
	|
	|-RVA: 0x3CE5390 Offset: 0x3CE5491 VA: 0x3CE5390
	|-Dictionary<FoodstuffData, int>.ContainsKey
	|-Dictionary<ItemData, int>.ContainsKey
	|-Dictionary<MapEditorCategoryData, int>.ContainsKey
	|-Dictionary<object, int>.ContainsKey
	|-Dictionary<ParameterExpression, int>.ContainsKey
	|-Dictionary<string, int>.ContainsKey
	|-Dictionary<SymbolRef, int>.ContainsKey
	|-Dictionary<Unit, int>.ContainsKey
	|
	|-RVA: 0x3CAD0A0 Offset: 0x3CAD1A1 VA: 0x3CAD0A0
	|-Dictionary<Guid, MonoTlsProvider>.ContainsKey
	|-Dictionary<Guid, object>.ContainsKey
	|
	|-RVA: 0x3D5BDE0 Offset: 0x3D5BEE1 VA: 0x3D5BDE0
	|-Dictionary<int, RTHandle[]>.ContainsKey
	|-Dictionary<int, CalculatorCommand>.ContainsKey
	|-Dictionary<int, MapInfoIconLocatorRoot>.ContainsKey
	|-Dictionary<int, object>.ContainsKey
	|-Dictionary<int, PrefetchedSignal>.ContainsKey
	|-Dictionary<int, SourceCode>.ContainsKey
	|-Dictionary<int, string>.ContainsKey
	|-Dictionary<int, TMP_ColorGradient>.ContainsKey
	|-Dictionary<int, TMP_FontAsset>.ContainsKey
	|-Dictionary<int, TMP_SpriteAsset>.ContainsKey
	|-Dictionary<int, TMP_Style>.ContainsKey
	|-Dictionary<int, TerrainUtility.TerrainMap>.ContainsKey
	|-Dictionary<int, MapHistory.Rewind.OverlapData>.ContainsKey
	|
	|-RVA: 0x3CB0BC0 Offset: 0x3CB0CC1 VA: 0x3CB0BC0
	|-Dictionary<int, bool>.ContainsKey
	|
	|-RVA: 0x3CB4680 Offset: 0x3CB4781 VA: 0x3CB4680
	|-Dictionary<int, byte>.ContainsKey
	|
	|-RVA: 0x3CB8140 Offset: 0x3CB8241 VA: 0x3CB8140
	|-Dictionary<int, char>.ContainsKey
	|
	|-RVA: 0x3CBBE40 Offset: 0x3CBBF41 VA: 0x3CBBE40
	|-Dictionary<int, DiagnosticEvent>.ContainsKey
	|
	|-RVA: 0x3D4D200 Offset: 0x3D4D301 VA: 0x3D4D200
	|-Dictionary<int, int>.ContainsKey
	|
	|-RVA: 0x3D50C90 Offset: 0x3D50D91 VA: 0x3D50C90
	|-Dictionary<int, Int32Enum>.ContainsKey
	|
	|-RVA: 0x3D54730 Offset: 0x3D54831 VA: 0x3D54730
	|-Dictionary<int, long>.ContainsKey
	|
	|-RVA: 0x3D582B0 Offset: 0x3D583B1 VA: 0x3D582B0
	|-Dictionary<int, MapPos>.ContainsKey
	|
	|-RVA: 0x3D5F8E0 Offset: 0x3D5F9E1 VA: 0x3D5F8E0
	|-Dictionary<int, uint>.ContainsKey
	|
	|-RVA: 0x3D63370 Offset: 0x3D63471 VA: 0x3D63370
	|-Dictionary<int, AIThink.EnchantThink.SurroundingInfo>.ContainsKey
	|
	|-RVA: 0x3CBFC30 Offset: 0x3CBFD31 VA: 0x3CBFC30
	|-Dictionary<Int32Enum, bool>.ContainsKey
	|
	|-RVA: 0x3CC36E0 Offset: 0x3CC37E1 VA: 0x3CC36E0
	|-Dictionary<Int32Enum, int>.ContainsKey
	|-Dictionary<HubAccessManager.MaterialCalculator.Type, int>.ContainsKey
	|
	|-RVA: 0x3CC7170 Offset: 0x3CC7271 VA: 0x3CC7170
	|-Dictionary<Int32Enum, Int32Enum>.ContainsKey
	|-Dictionary<RuntimePlatform, AddressablesPlatform>.ContainsKey
	|
	|-RVA: 0x3CCAC10 Offset: 0x3CCAD11 VA: 0x3CCAC10
	|-Dictionary<Int32Enum, object>.ContainsKey
	|
	|-RVA: 0x3CCE720 Offset: 0x3CCE821 VA: 0x3CCE720
	|-Dictionary<long, object>.ContainsKey
	|
	|-RVA: 0x3C92CD0 Offset: 0x3C92DD1 VA: 0x3C92CD0
	|-Dictionary<MapCollision, float>.ContainsKey
	|-Dictionary<object, float>.ContainsKey
	|
	|-RVA: 0x3CD2210 Offset: 0x3CD2311 VA: 0x3CD2210
	|-Dictionary<MapPos, int>.ContainsKey
	|
	|-RVA: 0x3CD5EC0 Offset: 0x3CD5FC1 VA: 0x3CD5EC0
	|-Dictionary<object, AsyncOperationHandle<object>>.ContainsKey
	|
	|-RVA: 0x3CD9DE0 Offset: 0x3CD9EE1 VA: 0x3CD9DE0
	|-Dictionary<object, AsyncOperationHandle>.ContainsKey
	|
	|-RVA: 0x3CDDBA0 Offset: 0x3CDDCA1 VA: 0x3CDDBA0
	|-Dictionary<object, bool>.ContainsKey
	|-Dictionary<string, bool>.ContainsKey
	|
	|-RVA: 0x3CE17A0 Offset: 0x3CE18A1 VA: 0x3CE17A0
	|-Dictionary<object, byte>.ContainsKey
	|-Dictionary<string, byte>.ContainsKey
	|
	|-RVA: 0x3CE8F80 Offset: 0x3CE9081 VA: 0x3CE8F80
	|-Dictionary<object, Int32Enum>.ContainsKey
	|
	|-RVA: 0x3CECB70 Offset: 0x3CECC71 VA: 0x3CECB70
	|-Dictionary<object, IntPtr>.ContainsKey
	|-Dictionary<string, IntPtr>.ContainsKey
	|
	|-RVA: 0x3C8B500 Offset: 0x3C8B601 VA: 0x3C8B500
	|-Dictionary<object, Playable>.ContainsKey
	|-Dictionary<TrackAsset, Playable>.ContainsKey
	|
	|-RVA: 0x3C8F0E0 Offset: 0x3C8F1E1 VA: 0x3C8F0E0
	|-Dictionary<object, ResourceLocator>.ContainsKey
	|
	|-RVA: 0x3C968B0 Offset: 0x3C969B1 VA: 0x3C968B0
	|-Dictionary<object, ushort>.ContainsKey
	|
	|-RVA: 0x3C9A4B0 Offset: 0x3C9A5B1 VA: 0x3C9A4B0
	|-Dictionary<object, GameVariable.Value>.ContainsKey
	|-Dictionary<string, GameVariable.Value>.ContainsKey
	|
	|-RVA: 0x3C9E240 Offset: 0x3C9E341 VA: 0x3C9E240
	|-Dictionary<sbyte, DataStoreRatingInfo>.ContainsKey
	|
	|-RVA: 0x3CA1F60 Offset: 0x3CA2061 VA: 0x3CA1F60
	|-Dictionary<sbyte, DataStoreRatingInitParam>.ContainsKey
	|-Dictionary<sbyte, object>.ContainsKey
	|
	|-RVA: 0x3D32E60 Offset: 0x3D32F61 VA: 0x3D32E60
	|-Dictionary<ushort, int>.ContainsKey
	|
	|-RVA: 0x3D3A3B0 Offset: 0x3D3A4B1 VA: 0x3D3A3B0
	|-Dictionary<uint, Glyph>.ContainsKey
	|-Dictionary<uint, object>.ContainsKey
	|-Dictionary<uint, TMP_Character>.ContainsKey
	|-Dictionary<uint, TMP_GlyphPairAdjustmentRecord>.ContainsKey
	|-Dictionary<uint, TMP_SpriteCharacter>.ContainsKey
	|-Dictionary<uint, TMP_SpriteGlyph>.ContainsKey
	|-Dictionary<uint, AkAudioInputManager.AudioFormatDelegate>.ContainsKey
	|-Dictionary<uint, AkAudioInputManager.AudioSamplesDelegate>.ContainsKey
	|
	|-RVA: 0x3D36910 Offset: 0x3D36A11 VA: 0x3D36910
	|-Dictionary<uint, int>.ContainsKey
	|
	|-RVA: 0x3D3E150 Offset: 0x3D3E251 VA: 0x3D3E150
	|-Dictionary<ulong, Friend>.ContainsKey
	|
	|-RVA: 0x3D41F10 Offset: 0x3D42011 VA: 0x3D41F10
	|-Dictionary<ulong, Int32Enum>.ContainsKey
	|-Dictionary<ulong, NexVersus.TargetSlotList.Results>.ContainsKey
	|
	|-RVA: 0x3D45A80 Offset: 0x3D45B81 VA: 0x3D45A80
	|-Dictionary<ulong, object>.ContainsKey
	|-Dictionary<ulong, RelayUserGlobalData.Ticket>.ContainsKey
	|
	|-RVA: 0x3D495D0 Offset: 0x3D496D1 VA: 0x3D495D0
	|-Dictionary<Vector3, int>.ContainsKey
	|
	|-RVA: 0x26279D0 Offset: 0x2627AD1 VA: 0x26279D0
	|-Dictionary<XPathNodeRef, XPathNodeRef>.ContainsKey
	|
	|-RVA: 0x262B650 Offset: 0x262B751 VA: 0x262B650
	|-Dictionary<TerrainUtility.TerrainMap.TileCoord, object>.ContainsKey
	*/

	// RVA: -1 Offset: -1
	public bool ContainsValue(TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x251D030 Offset: 0x251D131 VA: 0x251D030
	|-Dictionary<ValueTuple<object, int>, object>.ContainsValue
	|
	|-RVA: 0x2520B60 Offset: 0x2520C61 VA: 0x2520B60
	|-Dictionary<byte, object>.ContainsValue
	|
	|-RVA: 0x3CA5AA0 Offset: 0x3CA5BA1 VA: 0x3CA5AA0
	|-Dictionary<CancellationToken, object>.ContainsValue
	|
	|-RVA: 0x3CA95A0 Offset: 0x3CA96A1 VA: 0x3CA95A0
	|-Dictionary<char, object>.ContainsValue
	|
	|-RVA: 0x3CAD0D0 Offset: 0x3CAD1D1 VA: 0x3CAD0D0
	|-Dictionary<Guid, object>.ContainsValue
	|
	|-RVA: 0x3CB0BF0 Offset: 0x3CB0CF1 VA: 0x3CB0BF0
	|-Dictionary<int, bool>.ContainsValue
	|
	|-RVA: 0x3CB46B0 Offset: 0x3CB47B1 VA: 0x3CB46B0
	|-Dictionary<int, byte>.ContainsValue
	|
	|-RVA: 0x3CB8170 Offset: 0x3CB8271 VA: 0x3CB8170
	|-Dictionary<int, char>.ContainsValue
	|
	|-RVA: 0x3CBBE70 Offset: 0x3CBBF71 VA: 0x3CBBE70
	|-Dictionary<int, DiagnosticEvent>.ContainsValue
	|
	|-RVA: 0x3D4D230 Offset: 0x3D4D331 VA: 0x3D4D230
	|-Dictionary<int, int>.ContainsValue
	|
	|-RVA: 0x3D50CC0 Offset: 0x3D50DC1 VA: 0x3D50CC0
	|-Dictionary<int, Int32Enum>.ContainsValue
	|
	|-RVA: 0x3D54760 Offset: 0x3D54861 VA: 0x3D54760
	|-Dictionary<int, long>.ContainsValue
	|
	|-RVA: 0x3D582E0 Offset: 0x3D583E1 VA: 0x3D582E0
	|-Dictionary<int, MapPos>.ContainsValue
	|
	|-RVA: 0x3D5BE10 Offset: 0x3D5BF11 VA: 0x3D5BE10
	|-Dictionary<int, object>.ContainsValue
	|
	|-RVA: 0x3D5F910 Offset: 0x3D5FA11 VA: 0x3D5F910
	|-Dictionary<int, uint>.ContainsValue
	|
	|-RVA: 0x3D633A0 Offset: 0x3D634A1 VA: 0x3D633A0
	|-Dictionary<int, AIThink.EnchantThink.SurroundingInfo>.ContainsValue
	|
	|-RVA: 0x3CBFC60 Offset: 0x3CBFD61 VA: 0x3CBFC60
	|-Dictionary<Int32Enum, bool>.ContainsValue
	|
	|-RVA: 0x3CC3710 Offset: 0x3CC3811 VA: 0x3CC3710
	|-Dictionary<Int32Enum, int>.ContainsValue
	|
	|-RVA: 0x3CC71A0 Offset: 0x3CC72A1 VA: 0x3CC71A0
	|-Dictionary<Int32Enum, Int32Enum>.ContainsValue
	|
	|-RVA: 0x3CCAC40 Offset: 0x3CCAD41 VA: 0x3CCAC40
	|-Dictionary<Int32Enum, object>.ContainsValue
	|
	|-RVA: 0x3CCE750 Offset: 0x3CCE851 VA: 0x3CCE750
	|-Dictionary<long, object>.ContainsValue
	|
	|-RVA: 0x3CD2240 Offset: 0x3CD2341 VA: 0x3CD2240
	|-Dictionary<MapPos, int>.ContainsValue
	|
	|-RVA: 0x3CD5EF0 Offset: 0x3CD5FF1 VA: 0x3CD5EF0
	|-Dictionary<object, AsyncOperationHandle<object>>.ContainsValue
	|
	|-RVA: 0x3CD9E10 Offset: 0x3CD9F11 VA: 0x3CD9E10
	|-Dictionary<object, AsyncOperationHandle>.ContainsValue
	|
	|-RVA: 0x3CDDBD0 Offset: 0x3CDDCD1 VA: 0x3CDDBD0
	|-Dictionary<object, bool>.ContainsValue
	|
	|-RVA: 0x3CE17D0 Offset: 0x3CE18D1 VA: 0x3CE17D0
	|-Dictionary<object, byte>.ContainsValue
	|
	|-RVA: 0x3CE53C0 Offset: 0x3CE54C1 VA: 0x3CE53C0
	|-Dictionary<object, int>.ContainsValue
	|
	|-RVA: 0x3CE8FB0 Offset: 0x3CE90B1 VA: 0x3CE8FB0
	|-Dictionary<object, Int32Enum>.ContainsValue
	|
	|-RVA: 0x3CECBA0 Offset: 0x3CECCA1 VA: 0x3CECBA0
	|-Dictionary<object, IntPtr>.ContainsValue
	|
	|-RVA: 0x3CF0770 Offset: 0x3CF0871 VA: 0x3CF0770
	|-Dictionary<object, object>.ContainsValue
	|
	|-RVA: 0x3C8B530 Offset: 0x3C8B631 VA: 0x3C8B530
	|-Dictionary<object, Playable>.ContainsValue
	|
	|-RVA: 0x3C8F110 Offset: 0x3C8F211 VA: 0x3C8F110
	|-Dictionary<object, ResourceLocator>.ContainsValue
	|
	|-RVA: 0x3C92D00 Offset: 0x3C92E01 VA: 0x3C92D00
	|-Dictionary<object, float>.ContainsValue
	|
	|-RVA: 0x3C968E0 Offset: 0x3C969E1 VA: 0x3C968E0
	|-Dictionary<object, ushort>.ContainsValue
	|
	|-RVA: 0x3C9A4E0 Offset: 0x3C9A5E1 VA: 0x3C9A4E0
	|-Dictionary<object, GameVariable.Value>.ContainsValue
	|
	|-RVA: 0x3C9E270 Offset: 0x3C9E371 VA: 0x3C9E270
	|-Dictionary<sbyte, DataStoreRatingInfo>.ContainsValue
	|
	|-RVA: 0x3CA1F90 Offset: 0x3CA2091 VA: 0x3CA1F90
	|-Dictionary<sbyte, object>.ContainsValue
	|
	|-RVA: 0x3D32E90 Offset: 0x3D32F91 VA: 0x3D32E90
	|-Dictionary<ushort, int>.ContainsValue
	|
	|-RVA: 0x3D36940 Offset: 0x3D36A41 VA: 0x3D36940
	|-Dictionary<uint, int>.ContainsValue
	|
	|-RVA: 0x3D3A3E0 Offset: 0x3D3A4E1 VA: 0x3D3A3E0
	|-Dictionary<uint, object>.ContainsValue
	|
	|-RVA: 0x3D3E180 Offset: 0x3D3E281 VA: 0x3D3E180
	|-Dictionary<ulong, Friend>.ContainsValue
	|
	|-RVA: 0x3D41F40 Offset: 0x3D42041 VA: 0x3D41F40
	|-Dictionary<ulong, Int32Enum>.ContainsValue
	|
	|-RVA: 0x3D45AB0 Offset: 0x3D45BB1 VA: 0x3D45AB0
	|-Dictionary<ulong, object>.ContainsValue
	|
	|-RVA: 0x3D49600 Offset: 0x3D49701 VA: 0x3D49600
	|-Dictionary<Vector3, int>.ContainsValue
	|
	|-RVA: 0x2627A00 Offset: 0x2627B01 VA: 0x2627A00
	|-Dictionary<XPathNodeRef, XPathNodeRef>.ContainsValue
	|
	|-RVA: 0x262B680 Offset: 0x262B781 VA: 0x262B680
	|-Dictionary<TerrainUtility.TerrainMap.TileCoord, object>.ContainsValue
	*/

	// RVA: -1 Offset: -1
	private void CopyTo(KeyValuePair<TKey, TValue>[] array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x251D150 Offset: 0x251D251 VA: 0x251D150
	|-Dictionary<ValueTuple<object, int>, object>.CopyTo
	|
	|-RVA: 0x2520C80 Offset: 0x2520D81 VA: 0x2520C80
	|-Dictionary<byte, object>.CopyTo
	|
	|-RVA: 0x3CA5BC0 Offset: 0x3CA5CC1 VA: 0x3CA5BC0
	|-Dictionary<CancellationToken, object>.CopyTo
	|
	|-RVA: 0x3CA96C0 Offset: 0x3CA97C1 VA: 0x3CA96C0
	|-Dictionary<char, object>.CopyTo
	|
	|-RVA: 0x3CAD1F0 Offset: 0x3CAD2F1 VA: 0x3CAD1F0
	|-Dictionary<Guid, object>.CopyTo
	|
	|-RVA: 0x3CB0CC0 Offset: 0x3CB0DC1 VA: 0x3CB0CC0
	|-Dictionary<int, bool>.CopyTo
	|
	|-RVA: 0x3CB4780 Offset: 0x3CB4881 VA: 0x3CB4780
	|-Dictionary<int, byte>.CopyTo
	|
	|-RVA: 0x3CB8240 Offset: 0x3CB8341 VA: 0x3CB8240
	|-Dictionary<int, char>.CopyTo
	|
	|-RVA: 0x3CBBFB0 Offset: 0x3CBC0B1 VA: 0x3CBBFB0
	|-Dictionary<int, DiagnosticEvent>.CopyTo
	|
	|-RVA: 0x3D4D300 Offset: 0x3D4D401 VA: 0x3D4D300
	|-Dictionary<int, int>.CopyTo
	|
	|-RVA: 0x3D50D90 Offset: 0x3D50E91 VA: 0x3D50D90
	|-Dictionary<int, Int32Enum>.CopyTo
	|
	|-RVA: 0x3D54830 Offset: 0x3D54931 VA: 0x3D54830
	|-Dictionary<int, long>.CopyTo
	|
	|-RVA: 0x3D583B0 Offset: 0x3D584B1 VA: 0x3D583B0
	|-Dictionary<int, MapPos>.CopyTo
	|
	|-RVA: 0x3D5BF30 Offset: 0x3D5C031 VA: 0x3D5BF30
	|-Dictionary<int, object>.CopyTo
	|
	|-RVA: 0x3D5F9E0 Offset: 0x3D5FAE1 VA: 0x3D5F9E0
	|-Dictionary<int, uint>.CopyTo
	|
	|-RVA: 0x3D63470 Offset: 0x3D63571 VA: 0x3D63470
	|-Dictionary<int, AIThink.EnchantThink.SurroundingInfo>.CopyTo
	|
	|-RVA: 0x3CBFD30 Offset: 0x3CBFE31 VA: 0x3CBFD30
	|-Dictionary<Int32Enum, bool>.CopyTo
	|
	|-RVA: 0x3CC37E0 Offset: 0x3CC38E1 VA: 0x3CC37E0
	|-Dictionary<Int32Enum, int>.CopyTo
	|
	|-RVA: 0x3CC7270 Offset: 0x3CC7371 VA: 0x3CC7270
	|-Dictionary<Int32Enum, Int32Enum>.CopyTo
	|
	|-RVA: 0x3CCAD60 Offset: 0x3CCAE61 VA: 0x3CCAD60
	|-Dictionary<Int32Enum, object>.CopyTo
	|
	|-RVA: 0x3CCE870 Offset: 0x3CCE971 VA: 0x3CCE870
	|-Dictionary<long, object>.CopyTo
	|
	|-RVA: 0x3CD2310 Offset: 0x3CD2411 VA: 0x3CD2310
	|-Dictionary<MapPos, int>.CopyTo
	|
	|-RVA: 0x3CD6010 Offset: 0x3CD6111 VA: 0x3CD6010
	|-Dictionary<object, AsyncOperationHandle<object>>.CopyTo
	|
	|-RVA: 0x3CD9F30 Offset: 0x3CDA031 VA: 0x3CD9F30
	|-Dictionary<object, AsyncOperationHandle>.CopyTo
	|
	|-RVA: 0x3CDDCA0 Offset: 0x3CDDDA1 VA: 0x3CDDCA0
	|-Dictionary<object, bool>.CopyTo
	|
	|-RVA: 0x3CE18A0 Offset: 0x3CE19A1 VA: 0x3CE18A0
	|-Dictionary<object, byte>.CopyTo
	|
	|-RVA: 0x3CE5490 Offset: 0x3CE5591 VA: 0x3CE5490
	|-Dictionary<object, int>.CopyTo
	|
	|-RVA: 0x3CE9080 Offset: 0x3CE9181 VA: 0x3CE9080
	|-Dictionary<object, Int32Enum>.CopyTo
	|
	|-RVA: 0x3CECC70 Offset: 0x3CECD71 VA: 0x3CECC70
	|-Dictionary<object, IntPtr>.CopyTo
	|
	|-RVA: 0x3CF0890 Offset: 0x3CF0991 VA: 0x3CF0890
	|-Dictionary<object, object>.CopyTo
	|
	|-RVA: 0x3C8B600 Offset: 0x3C8B701 VA: 0x3C8B600
	|-Dictionary<object, Playable>.CopyTo
	|
	|-RVA: 0x3C8F1E0 Offset: 0x3C8F2E1 VA: 0x3C8F1E0
	|-Dictionary<object, ResourceLocator>.CopyTo
	|
	|-RVA: 0x3C92DD0 Offset: 0x3C92ED1 VA: 0x3C92DD0
	|-Dictionary<object, float>.CopyTo
	|
	|-RVA: 0x3C969B0 Offset: 0x3C96AB1 VA: 0x3C969B0
	|-Dictionary<object, ushort>.CopyTo
	|
	|-RVA: 0x3C9A5B0 Offset: 0x3C9A6B1 VA: 0x3C9A5B0
	|-Dictionary<object, GameVariable.Value>.CopyTo
	|
	|-RVA: 0x3C9E390 Offset: 0x3C9E491 VA: 0x3C9E390
	|-Dictionary<sbyte, DataStoreRatingInfo>.CopyTo
	|
	|-RVA: 0x3CA20B0 Offset: 0x3CA21B1 VA: 0x3CA20B0
	|-Dictionary<sbyte, object>.CopyTo
	|
	|-RVA: 0x3D32F60 Offset: 0x3D33061 VA: 0x3D32F60
	|-Dictionary<ushort, int>.CopyTo
	|
	|-RVA: 0x3D36A10 Offset: 0x3D36B11 VA: 0x3D36A10
	|-Dictionary<uint, int>.CopyTo
	|
	|-RVA: 0x3D3A500 Offset: 0x3D3A601 VA: 0x3D3A500
	|-Dictionary<uint, object>.CopyTo
	|
	|-RVA: 0x3D3E2A0 Offset: 0x3D3E3A1 VA: 0x3D3E2A0
	|-Dictionary<ulong, Friend>.CopyTo
	|
	|-RVA: 0x3D42010 Offset: 0x3D42111 VA: 0x3D42010
	|-Dictionary<ulong, Int32Enum>.CopyTo
	|
	|-RVA: 0x3D45BD0 Offset: 0x3D45CD1 VA: 0x3D45BD0
	|-Dictionary<ulong, object>.CopyTo
	|
	|-RVA: 0x3D496D0 Offset: 0x3D497D1 VA: 0x3D496D0
	|-Dictionary<Vector3, int>.CopyTo
	|
	|-RVA: 0x2627AD0 Offset: 0x2627BD1 VA: 0x2627AD0
	|-Dictionary<XPathNodeRef, XPathNodeRef>.CopyTo
	|
	|-RVA: 0x262B7A0 Offset: 0x262B8A1 VA: 0x262B7A0
	|-Dictionary<TerrainUtility.TerrainMap.TileCoord, object>.CopyTo
	*/

	// RVA: -1 Offset: -1
	public Dictionary.Enumerator<TKey, TValue> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x251D380 Offset: 0x251D481 VA: 0x251D380
	|-Dictionary<ValueTuple<object, int>, object>.GetEnumerator
	|
	|-RVA: 0x3CF0AA0 Offset: 0x3CF0BA1 VA: 0x3CF0AA0
	|-Dictionary<byte[], Encoding>.GetEnumerator
	|-Dictionary<AkAudioListener, AkObstructionOcclusion.ObstructionOcclusionValue>.GetEnumerator
	|-Dictionary<Camera, Camera>.GetEnumerator
	|-Dictionary<GameObject, Stack<GameObject>>.GetEnumerator
	|-Dictionary<GameObject, GameObject>.GetEnumerator
	|-Dictionary<ICinemachineCamera, object>.GetEnumerator
	|-Dictionary<ItemData, ChallengeMapSelectRoot.ItemDropNum>.GetEnumerator
	|-Dictionary<object, IList<IResourceLocation>>.GetEnumerator
	|-Dictionary<object, object>.GetEnumerator
	|-Dictionary<string, List<Renderer>>.GetEnumerator
	|-Dictionary<string, List<string>>.GetEnumerator
	|-Dictionary<string, BasicMenuItem>.GetEnumerator
	|-Dictionary<string, CharacterAsset>.GetEnumerator
	|-Dictionary<string, GodBond>.GetEnumerator
	|-Dictionary<string, MsgFile>.GetEnumerator
	|-Dictionary<string, RelayAwardeeData>.GetEnumerator
	|-Dictionary<string, ResourceHandle>.GetEnumerator
	|-Dictionary<string, ResourceLocationBase>.GetEnumerator
	|-Dictionary<string, Sprite>.GetEnumerator
	|-Dictionary<string, string>.GetEnumerator
	|-Dictionary<string, Transform>.GetEnumerator
	|-Dictionary<string, UnitRelianceData>.GetEnumerator
	|-Dictionary<string, AssetTable.Accessory>.GetEnumerator
	|-Dictionary<string, EventDemoSequence.SplitViewWork>.GetEnumerator
	|-Dictionary<string, FieldBgmManager.BgmHandle>.GetEnumerator
	|-Dictionary<string, ServicePointScheduler.ConnectionGroup>.GetEnumerator
	|-Dictionary<string, SoundSystem.LipSyncDataFile>.GetEnumerator
	|-Dictionary<string, SoundWwise.SoundBankManager.BankHandle>.GetEnumerator
	|-Dictionary<string, SoundWwise.SoundPrepareManager.EventParam>.GetEnumerator
	|-Dictionary<string, SoundWwise.SoundPrepareManager.SwitchParam>.GetEnumerator
	|-Dictionary<string, SoundWwise.SoundPrepareManager.SwitchParamList>.GetEnumerator
	|-Dictionary<Transform, List<SpringBone>>.GetEnumerator
	|-Dictionary<Transform, TargetPositionCache.CacheEntry>.GetEnumerator
	|-Dictionary<Transform, UpdateTracker.UpdateStatus>.GetEnumerator
	|-Dictionary<Type, VolumeComponent>.GetEnumerator
	|-Dictionary<Unit, string>.GetEnumerator
	|-Dictionary<XmlQualifiedName, SchemaAttDef>.GetEnumerator
	|-Dictionary<XmlQualifiedName, SchemaElementDecl>.GetEnumerator
	|
	|-RVA: 0x2520EA0 Offset: 0x2520FA1 VA: 0x2520EA0
	|-Dictionary<byte, List<byte>>.GetEnumerator
	|-Dictionary<byte, object>.GetEnumerator
	|
	|-RVA: 0x3CA5DD0 Offset: 0x3CA5ED1 VA: 0x3CA5DD0
	|-Dictionary<CancellationToken, object>.GetEnumerator
	|
	|-RVA: 0x3CA98E0 Offset: 0x3CA99E1 VA: 0x3CA98E0
	|-Dictionary<char, object>.GetEnumerator
	|
	|-RVA: 0x3CAD420 Offset: 0x3CAD521 VA: 0x3CAD420
	|-Dictionary<Guid, object>.GetEnumerator
	|
	|-RVA: 0x3D5C150 Offset: 0x3D5C251 VA: 0x3D5C150
	|-Dictionary<int, List<ValueTuple<ComputeBuffer, int>>>.GetEnumerator
	|-Dictionary<int, List<ValueTuple<RTHandle, int>>>.GetEnumerator
	|-Dictionary<int, List<Volume>>.GetEnumerator
	|-Dictionary<int, RTHandle[]>.GetEnumerator
	|-Dictionary<int, CalculatorCommand>.GetEnumerator
	|-Dictionary<int, MapInfoIconLocatorRoot>.GetEnumerator
	|-Dictionary<int, object>.GetEnumerator
	|-Dictionary<int, PointerEventData>.GetEnumerator
	|-Dictionary<int, string>.GetEnumerator
	|-Dictionary<int, AkCallbackManager.BankCallbackPackage>.GetEnumerator
	|-Dictionary<int, AkCallbackManager.EventCallbackPackage>.GetEnumerator
	|-Dictionary<int, TerrainUtility.TerrainMap>.GetEnumerator
	|-Dictionary<int, MapHistory.Rewind.OverlapData>.GetEnumerator
	|
	|-RVA: 0x3CB0ED0 Offset: 0x3CB0FD1 VA: 0x3CB0ED0
	|-Dictionary<int, bool>.GetEnumerator
	|
	|-RVA: 0x3CB4990 Offset: 0x3CB4A91 VA: 0x3CB4990
	|-Dictionary<int, byte>.GetEnumerator
	|
	|-RVA: 0x3CB8450 Offset: 0x3CB8551 VA: 0x3CB8450
	|-Dictionary<int, char>.GetEnumerator
	|
	|-RVA: 0x3CBC250 Offset: 0x3CBC351 VA: 0x3CBC250
	|-Dictionary<int, DiagnosticEvent>.GetEnumerator
	|
	|-RVA: 0x3D4D500 Offset: 0x3D4D601 VA: 0x3D4D500
	|-Dictionary<int, int>.GetEnumerator
	|
	|-RVA: 0x3D50F90 Offset: 0x3D51091 VA: 0x3D50F90
	|-Dictionary<int, Int32Enum>.GetEnumerator
	|
	|-RVA: 0x3D54A40 Offset: 0x3D54B41 VA: 0x3D54A40
	|-Dictionary<int, long>.GetEnumerator
	|
	|-RVA: 0x3D585D0 Offset: 0x3D586D1 VA: 0x3D585D0
	|-Dictionary<int, MapPos>.GetEnumerator
	|
	|-RVA: 0x3D5FBE0 Offset: 0x3D5FCE1 VA: 0x3D5FBE0
	|-Dictionary<int, uint>.GetEnumerator
	|
	|-RVA: 0x3D63670 Offset: 0x3D63771 VA: 0x3D63670
	|-Dictionary<int, AIThink.EnchantThink.SurroundingInfo>.GetEnumerator
	|
	|-RVA: 0x3CBFF40 Offset: 0x3CC0041 VA: 0x3CBFF40
	|-Dictionary<Int32Enum, bool>.GetEnumerator
	|
	|-RVA: 0x3CC39E0 Offset: 0x3CC3AE1 VA: 0x3CC39E0
	|-Dictionary<Int32Enum, int>.GetEnumerator
	|-Dictionary<HubAccessManager.MaterialCalculator.Type, int>.GetEnumerator
	|
	|-RVA: 0x3CC7470 Offset: 0x3CC7571 VA: 0x3CC7470
	|-Dictionary<Int32Enum, Int32Enum>.GetEnumerator
	|
	|-RVA: 0x3CCAF80 Offset: 0x3CCB081 VA: 0x3CCAF80
	|-Dictionary<Int32Enum, object>.GetEnumerator
	|
	|-RVA: 0x3CCEA80 Offset: 0x3CCEB81 VA: 0x3CCEA80
	|-Dictionary<long, object>.GetEnumerator
	|
	|-RVA: 0x3CE56B0 Offset: 0x3CE57B1 VA: 0x3CE56B0
	|-Dictionary<ItemData, int>.GetEnumerator
	|-Dictionary<MapEditorCategoryData, int>.GetEnumerator
	|-Dictionary<object, int>.GetEnumerator
	|-Dictionary<SymbolRef, int>.GetEnumerator
	|-Dictionary<Unit, int>.GetEnumerator
	|
	|-RVA: 0x3CD2530 Offset: 0x3CD2631 VA: 0x3CD2530
	|-Dictionary<MapPos, int>.GetEnumerator
	|
	|-RVA: 0x3CD6260 Offset: 0x3CD6361 VA: 0x3CD6260
	|-Dictionary<object, AsyncOperationHandle<object>>.GetEnumerator
	|
	|-RVA: 0x3CDA180 Offset: 0x3CDA281 VA: 0x3CDA180
	|-Dictionary<object, AsyncOperationHandle>.GetEnumerator
	|
	|-RVA: 0x3CDDEC0 Offset: 0x3CDDFC1 VA: 0x3CDDEC0
	|-Dictionary<object, bool>.GetEnumerator
	|
	|-RVA: 0x3CE1AC0 Offset: 0x3CE1BC1 VA: 0x3CE1AC0
	|-Dictionary<object, byte>.GetEnumerator
	|-Dictionary<string, byte>.GetEnumerator
	|
	|-RVA: 0x3CE92A0 Offset: 0x3CE93A1 VA: 0x3CE92A0
	|-Dictionary<object, Int32Enum>.GetEnumerator
	|
	|-RVA: 0x3CECE80 Offset: 0x3CECF81 VA: 0x3CECE80
	|-Dictionary<object, IntPtr>.GetEnumerator
	|
	|-RVA: 0x3C8B830 Offset: 0x3C8B931 VA: 0x3C8B830
	|-Dictionary<object, Playable>.GetEnumerator
	|
	|-RVA: 0x3C8F410 Offset: 0x3C8F511 VA: 0x3C8F410
	|-Dictionary<object, ResourceLocator>.GetEnumerator
	|
	|-RVA: 0x3C92FF0 Offset: 0x3C930F1 VA: 0x3C92FF0
	|-Dictionary<object, float>.GetEnumerator
	|
	|-RVA: 0x3C96BD0 Offset: 0x3C96CD1 VA: 0x3C96BD0
	|-Dictionary<object, ushort>.GetEnumerator
	|
	|-RVA: 0x3C9A7E0 Offset: 0x3C9A8E1 VA: 0x3C9A7E0
	|-Dictionary<object, GameVariable.Value>.GetEnumerator
	|-Dictionary<string, GameVariable.Value>.GetEnumerator
	|
	|-RVA: 0x3C9E5E0 Offset: 0x3C9E6E1 VA: 0x3C9E5E0
	|-Dictionary<sbyte, DataStoreRatingInfo>.GetEnumerator
	|
	|-RVA: 0x3CA22D0 Offset: 0x3CA23D1 VA: 0x3CA22D0
	|-Dictionary<sbyte, DataStoreRatingInitParam>.GetEnumerator
	|-Dictionary<sbyte, object>.GetEnumerator
	|
	|-RVA: 0x3D33170 Offset: 0x3D33271 VA: 0x3D33170
	|-Dictionary<ushort, int>.GetEnumerator
	|
	|-RVA: 0x3D36C10 Offset: 0x3D36D11 VA: 0x3D36C10
	|-Dictionary<uint, int>.GetEnumerator
	|
	|-RVA: 0x3D3A720 Offset: 0x3D3A821 VA: 0x3D3A720
	|-Dictionary<uint, object>.GetEnumerator
	|
	|-RVA: 0x3D3E500 Offset: 0x3D3E601 VA: 0x3D3E500
	|-Dictionary<ulong, Friend>.GetEnumerator
	|
	|-RVA: 0x3D42220 Offset: 0x3D42321 VA: 0x3D42220
	|-Dictionary<ulong, Int32Enum>.GetEnumerator
	|
	|-RVA: 0x3D45DE0 Offset: 0x3D45EE1 VA: 0x3D45DE0
	|-Dictionary<ulong, object>.GetEnumerator
	|-Dictionary<ulong, RelayUserGlobalData.Ticket>.GetEnumerator
	|
	|-RVA: 0x3D498E0 Offset: 0x3D499E1 VA: 0x3D498E0
	|-Dictionary<Vector3, int>.GetEnumerator
	|
	|-RVA: 0x2627D00 Offset: 0x2627E01 VA: 0x2627D00
	|-Dictionary<XPathNodeRef, XPathNodeRef>.GetEnumerator
	|
	|-RVA: 0x262B9B0 Offset: 0x262BAB1 VA: 0x262B9B0
	|-Dictionary<TerrainUtility.TerrainMap.TileCoord, object>.GetEnumerator
	|-Dictionary<TerrainUtility.TerrainMap.TileCoord, Terrain>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 14
	private IEnumerator<KeyValuePair<TKey, TValue>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x251D3F0 Offset: 0x251D4F1 VA: 0x251D3F0
	|-Dictionary<ValueTuple<object, int>, object>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x2520F10 Offset: 0x2521011 VA: 0x2520F10
	|-Dictionary<byte, object>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x3CA5E40 Offset: 0x3CA5F41 VA: 0x3CA5E40
	|-Dictionary<CancellationToken, object>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x3CA9950 Offset: 0x3CA9A51 VA: 0x3CA9950
	|-Dictionary<char, object>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x3CAD490 Offset: 0x3CAD591 VA: 0x3CAD490
	|-Dictionary<Guid, object>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x3CB0F30 Offset: 0x3CB1031 VA: 0x3CB0F30
	|-Dictionary<int, bool>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x3CB49F0 Offset: 0x3CB4AF1 VA: 0x3CB49F0
	|-Dictionary<int, byte>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x3D5C1C0 Offset: 0x3D5C2C1 VA: 0x3D5C1C0
	|-Dictionary<int, CalculatorCommand>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|-Dictionary<int, object>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|-Dictionary<int, TerrainUtility.TerrainMap>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x3CB84B0 Offset: 0x3CB85B1 VA: 0x3CB84B0
	|-Dictionary<int, char>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x3CBC2D0 Offset: 0x3CBC3D1 VA: 0x3CBC2D0
	|-Dictionary<int, DiagnosticEvent>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x3D4D560 Offset: 0x3D4D661 VA: 0x3D4D560
	|-Dictionary<int, int>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x3D50FF0 Offset: 0x3D510F1 VA: 0x3D50FF0
	|-Dictionary<int, Int32Enum>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x3D54AB0 Offset: 0x3D54BB1 VA: 0x3D54AB0
	|-Dictionary<int, long>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x3D58630 Offset: 0x3D58731 VA: 0x3D58630
	|-Dictionary<int, MapPos>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x3D5FC40 Offset: 0x3D5FD41 VA: 0x3D5FC40
	|-Dictionary<int, uint>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x3D636D0 Offset: 0x3D637D1 VA: 0x3D636D0
	|-Dictionary<int, AIThink.EnchantThink.SurroundingInfo>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x3CBFFA0 Offset: 0x3CC00A1 VA: 0x3CBFFA0
	|-Dictionary<Int32Enum, bool>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x3CC3A40 Offset: 0x3CC3B41 VA: 0x3CC3A40
	|-Dictionary<Int32Enum, int>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x3CC74D0 Offset: 0x3CC75D1 VA: 0x3CC74D0
	|-Dictionary<Int32Enum, Int32Enum>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x3CCAFF0 Offset: 0x3CCB0F1 VA: 0x3CCAFF0
	|-Dictionary<Int32Enum, object>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x3CCEAF0 Offset: 0x3CCEBF1 VA: 0x3CCEAF0
	|-Dictionary<long, object>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x3CD2590 Offset: 0x3CD2691 VA: 0x3CD2590
	|-Dictionary<MapPos, int>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x3CD62E0 Offset: 0x3CD63E1 VA: 0x3CD62E0
	|-Dictionary<object, AsyncOperationHandle<object>>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x3CDA200 Offset: 0x3CDA301 VA: 0x3CDA200
	|-Dictionary<object, AsyncOperationHandle>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x3CDDF30 Offset: 0x3CDE031 VA: 0x3CDDF30
	|-Dictionary<object, bool>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x3CE1B30 Offset: 0x3CE1C31 VA: 0x3CE1B30
	|-Dictionary<object, byte>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x3CE5720 Offset: 0x3CE5821 VA: 0x3CE5720
	|-Dictionary<object, int>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|-Dictionary<string, int>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x3CE9310 Offset: 0x3CE9411 VA: 0x3CE9310
	|-Dictionary<object, Int32Enum>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x3CECEF0 Offset: 0x3CECFF1 VA: 0x3CECEF0
	|-Dictionary<object, IntPtr>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x3CF0B10 Offset: 0x3CF0C11 VA: 0x3CF0B10
	|-Dictionary<object, object>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|-Dictionary<string, GameUserRestartData.Growth>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x3C8B8A0 Offset: 0x3C8B9A1 VA: 0x3C8B8A0
	|-Dictionary<object, Playable>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x3C8F480 Offset: 0x3C8F581 VA: 0x3C8F480
	|-Dictionary<object, ResourceLocator>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x3C93060 Offset: 0x3C93161 VA: 0x3C93060
	|-Dictionary<object, float>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x3C96C40 Offset: 0x3C96D41 VA: 0x3C96C40
	|-Dictionary<object, ushort>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x3C9A850 Offset: 0x3C9A951 VA: 0x3C9A850
	|-Dictionary<object, GameVariable.Value>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x3C9E660 Offset: 0x3C9E761 VA: 0x3C9E660
	|-Dictionary<sbyte, DataStoreRatingInfo>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x3CA2340 Offset: 0x3CA2441 VA: 0x3CA2340
	|-Dictionary<sbyte, object>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x3D331D0 Offset: 0x3D332D1 VA: 0x3D331D0
	|-Dictionary<ushort, int>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x3D36C70 Offset: 0x3D36D71 VA: 0x3D36C70
	|-Dictionary<uint, int>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x3D3A790 Offset: 0x3D3A891 VA: 0x3D3A790
	|-Dictionary<uint, object>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x3D3E580 Offset: 0x3D3E681 VA: 0x3D3E580
	|-Dictionary<ulong, Friend>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x3D42290 Offset: 0x3D42391 VA: 0x3D42290
	|-Dictionary<ulong, Int32Enum>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x3D45E50 Offset: 0x3D45F51 VA: 0x3D45E50
	|-Dictionary<ulong, object>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x3D49950 Offset: 0x3D49A51 VA: 0x3D49950
	|-Dictionary<Vector3, int>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x2627D80 Offset: 0x2627E81 VA: 0x2627D80
	|-Dictionary<XPathNodeRef, XPathNodeRef>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x262BA20 Offset: 0x262BB21 VA: 0x262BA20
	|-Dictionary<TerrainUtility.TerrainMap.TileCoord, object>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 37
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x251D480 Offset: 0x251D581 VA: 0x251D480
	|-Dictionary<ValueTuple<object, int>, object>.GetObjectData
	|
	|-RVA: 0x2520FA0 Offset: 0x25210A1 VA: 0x2520FA0
	|-Dictionary<byte, object>.GetObjectData
	|
	|-RVA: 0x3CA5ED0 Offset: 0x3CA5FD1 VA: 0x3CA5ED0
	|-Dictionary<CancellationToken, object>.GetObjectData
	|
	|-RVA: 0x3CA99E0 Offset: 0x3CA9AE1 VA: 0x3CA99E0
	|-Dictionary<char, object>.GetObjectData
	|
	|-RVA: 0x3CAD520 Offset: 0x3CAD621 VA: 0x3CAD520
	|-Dictionary<Guid, object>.GetObjectData
	|
	|-RVA: 0x3CB0FB0 Offset: 0x3CB10B1 VA: 0x3CB0FB0
	|-Dictionary<int, bool>.GetObjectData
	|
	|-RVA: 0x3CB4A70 Offset: 0x3CB4B71 VA: 0x3CB4A70
	|-Dictionary<int, byte>.GetObjectData
	|
	|-RVA: 0x3D5C250 Offset: 0x3D5C351 VA: 0x3D5C250
	|-Dictionary<int, CalculatorCommand>.GetObjectData
	|-Dictionary<int, object>.GetObjectData
	|-Dictionary<int, TerrainUtility.TerrainMap>.GetObjectData
	|
	|-RVA: 0x3CB8530 Offset: 0x3CB8631 VA: 0x3CB8530
	|-Dictionary<int, char>.GetObjectData
	|
	|-RVA: 0x3CBC380 Offset: 0x3CBC481 VA: 0x3CBC380
	|-Dictionary<int, DiagnosticEvent>.GetObjectData
	|
	|-RVA: 0x3D4D5E0 Offset: 0x3D4D6E1 VA: 0x3D4D5E0
	|-Dictionary<int, int>.GetObjectData
	|
	|-RVA: 0x3D51070 Offset: 0x3D51171 VA: 0x3D51070
	|-Dictionary<int, Int32Enum>.GetObjectData
	|
	|-RVA: 0x3D54B40 Offset: 0x3D54C41 VA: 0x3D54B40
	|-Dictionary<int, long>.GetObjectData
	|
	|-RVA: 0x3D586B0 Offset: 0x3D587B1 VA: 0x3D586B0
	|-Dictionary<int, MapPos>.GetObjectData
	|
	|-RVA: 0x3D5FCC0 Offset: 0x3D5FDC1 VA: 0x3D5FCC0
	|-Dictionary<int, uint>.GetObjectData
	|
	|-RVA: 0x3D63750 Offset: 0x3D63851 VA: 0x3D63750
	|-Dictionary<int, AIThink.EnchantThink.SurroundingInfo>.GetObjectData
	|
	|-RVA: 0x3CC0020 Offset: 0x3CC0121 VA: 0x3CC0020
	|-Dictionary<Int32Enum, bool>.GetObjectData
	|
	|-RVA: 0x3CC3AC0 Offset: 0x3CC3BC1 VA: 0x3CC3AC0
	|-Dictionary<Int32Enum, int>.GetObjectData
	|
	|-RVA: 0x3CC7550 Offset: 0x3CC7651 VA: 0x3CC7550
	|-Dictionary<Int32Enum, Int32Enum>.GetObjectData
	|
	|-RVA: 0x3CCB080 Offset: 0x3CCB181 VA: 0x3CCB080
	|-Dictionary<Int32Enum, object>.GetObjectData
	|
	|-RVA: 0x3CCEB80 Offset: 0x3CCEC81 VA: 0x3CCEB80
	|-Dictionary<long, object>.GetObjectData
	|
	|-RVA: 0x3CD2610 Offset: 0x3CD2711 VA: 0x3CD2610
	|-Dictionary<MapPos, int>.GetObjectData
	|
	|-RVA: 0x3CD6380 Offset: 0x3CD6481 VA: 0x3CD6380
	|-Dictionary<object, AsyncOperationHandle<object>>.GetObjectData
	|
	|-RVA: 0x3CDA2A0 Offset: 0x3CDA3A1 VA: 0x3CDA2A0
	|-Dictionary<object, AsyncOperationHandle>.GetObjectData
	|
	|-RVA: 0x3CDDFC0 Offset: 0x3CDE0C1 VA: 0x3CDDFC0
	|-Dictionary<object, bool>.GetObjectData
	|
	|-RVA: 0x3CE1BC0 Offset: 0x3CE1CC1 VA: 0x3CE1BC0
	|-Dictionary<object, byte>.GetObjectData
	|
	|-RVA: 0x3CE57B0 Offset: 0x3CE58B1 VA: 0x3CE57B0
	|-Dictionary<object, int>.GetObjectData
	|-Dictionary<string, int>.GetObjectData
	|
	|-RVA: 0x3CE93A0 Offset: 0x3CE94A1 VA: 0x3CE93A0
	|-Dictionary<object, Int32Enum>.GetObjectData
	|
	|-RVA: 0x3CECF80 Offset: 0x3CED081 VA: 0x3CECF80
	|-Dictionary<object, IntPtr>.GetObjectData
	|
	|-RVA: 0x3CF0BA0 Offset: 0x3CF0CA1 VA: 0x3CF0BA0
	|-Dictionary<object, object>.GetObjectData
	|-Dictionary<string, GameUserRestartData.Growth>.GetObjectData
	|
	|-RVA: 0x3C8B930 Offset: 0x3C8BA31 VA: 0x3C8B930
	|-Dictionary<object, Playable>.GetObjectData
	|
	|-RVA: 0x3C8F510 Offset: 0x3C8F611 VA: 0x3C8F510
	|-Dictionary<object, ResourceLocator>.GetObjectData
	|
	|-RVA: 0x3C930F0 Offset: 0x3C931F1 VA: 0x3C930F0
	|-Dictionary<object, float>.GetObjectData
	|
	|-RVA: 0x3C96CD0 Offset: 0x3C96DD1 VA: 0x3C96CD0
	|-Dictionary<object, ushort>.GetObjectData
	|
	|-RVA: 0x3C9A8E0 Offset: 0x3C9A9E1 VA: 0x3C9A8E0
	|-Dictionary<object, GameVariable.Value>.GetObjectData
	|
	|-RVA: 0x3C9E700 Offset: 0x3C9E801 VA: 0x3C9E700
	|-Dictionary<sbyte, DataStoreRatingInfo>.GetObjectData
	|
	|-RVA: 0x3CA23D0 Offset: 0x3CA24D1 VA: 0x3CA23D0
	|-Dictionary<sbyte, object>.GetObjectData
	|
	|-RVA: 0x3D33250 Offset: 0x3D33351 VA: 0x3D33250
	|-Dictionary<ushort, int>.GetObjectData
	|
	|-RVA: 0x3D36CF0 Offset: 0x3D36DF1 VA: 0x3D36CF0
	|-Dictionary<uint, int>.GetObjectData
	|
	|-RVA: 0x3D3A820 Offset: 0x3D3A921 VA: 0x3D3A820
	|-Dictionary<uint, object>.GetObjectData
	|
	|-RVA: 0x3D3E620 Offset: 0x3D3E721 VA: 0x3D3E620
	|-Dictionary<ulong, Friend>.GetObjectData
	|
	|-RVA: 0x3D42320 Offset: 0x3D42421 VA: 0x3D42320
	|-Dictionary<ulong, Int32Enum>.GetObjectData
	|
	|-RVA: 0x3D45EE0 Offset: 0x3D45FE1 VA: 0x3D45EE0
	|-Dictionary<ulong, object>.GetObjectData
	|
	|-RVA: 0x3D499E0 Offset: 0x3D49AE1 VA: 0x3D499E0
	|-Dictionary<Vector3, int>.GetObjectData
	|
	|-RVA: 0x2627E20 Offset: 0x2627F21 VA: 0x2627E20
	|-Dictionary<XPathNodeRef, XPathNodeRef>.GetObjectData
	|
	|-RVA: 0x262BAB0 Offset: 0x262BBB1 VA: 0x262BAB0
	|-Dictionary<TerrainUtility.TerrainMap.TileCoord, object>.GetObjectData
	*/

	// RVA: -1 Offset: -1
	private int FindEntry(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x251D6D0 Offset: 0x251D7D1 VA: 0x251D6D0
	|-Dictionary<ValueTuple<object, int>, object>.FindEntry
	|
	|-RVA: 0x25211F0 Offset: 0x25212F1 VA: 0x25211F0
	|-Dictionary<byte, object>.FindEntry
	|
	|-RVA: 0x3CA6120 Offset: 0x3CA6221 VA: 0x3CA6120
	|-Dictionary<CancellationToken, object>.FindEntry
	|
	|-RVA: 0x3CA9C30 Offset: 0x3CA9D31 VA: 0x3CA9C30
	|-Dictionary<char, object>.FindEntry
	|
	|-RVA: 0x3CAD770 Offset: 0x3CAD871 VA: 0x3CAD770
	|-Dictionary<Guid, object>.FindEntry
	|
	|-RVA: 0x3CB1200 Offset: 0x3CB1301 VA: 0x3CB1200
	|-Dictionary<int, bool>.FindEntry
	|
	|-RVA: 0x3CB4CC0 Offset: 0x3CB4DC1 VA: 0x3CB4CC0
	|-Dictionary<int, byte>.FindEntry
	|
	|-RVA: 0x3CB8780 Offset: 0x3CB8881 VA: 0x3CB8780
	|-Dictionary<int, char>.FindEntry
	|
	|-RVA: 0x3CBC5D0 Offset: 0x3CBC6D1 VA: 0x3CBC5D0
	|-Dictionary<int, DiagnosticEvent>.FindEntry
	|
	|-RVA: 0x3D4D830 Offset: 0x3D4D931 VA: 0x3D4D830
	|-Dictionary<int, int>.FindEntry
	|
	|-RVA: 0x3D512C0 Offset: 0x3D513C1 VA: 0x3D512C0
	|-Dictionary<int, Int32Enum>.FindEntry
	|
	|-RVA: 0x3D54D90 Offset: 0x3D54E91 VA: 0x3D54D90
	|-Dictionary<int, long>.FindEntry
	|
	|-RVA: 0x3D58900 Offset: 0x3D58A01 VA: 0x3D58900
	|-Dictionary<int, MapPos>.FindEntry
	|
	|-RVA: 0x3D5C4A0 Offset: 0x3D5C5A1 VA: 0x3D5C4A0
	|-Dictionary<int, object>.FindEntry
	|
	|-RVA: 0x3D5FF10 Offset: 0x3D60011 VA: 0x3D5FF10
	|-Dictionary<int, uint>.FindEntry
	|
	|-RVA: 0x3D639A0 Offset: 0x3D63AA1 VA: 0x3D639A0
	|-Dictionary<int, AIThink.EnchantThink.SurroundingInfo>.FindEntry
	|
	|-RVA: 0x3CC0270 Offset: 0x3CC0371 VA: 0x3CC0270
	|-Dictionary<Int32Enum, bool>.FindEntry
	|
	|-RVA: 0x3CC3D10 Offset: 0x3CC3E11 VA: 0x3CC3D10
	|-Dictionary<Int32Enum, int>.FindEntry
	|
	|-RVA: 0x3CC77A0 Offset: 0x3CC78A1 VA: 0x3CC77A0
	|-Dictionary<Int32Enum, Int32Enum>.FindEntry
	|
	|-RVA: 0x3CCB2D0 Offset: 0x3CCB3D1 VA: 0x3CCB2D0
	|-Dictionary<Int32Enum, object>.FindEntry
	|
	|-RVA: 0x3CCEDD0 Offset: 0x3CCEED1 VA: 0x3CCEDD0
	|-Dictionary<long, object>.FindEntry
	|
	|-RVA: 0x3CD2860 Offset: 0x3CD2961 VA: 0x3CD2860
	|-Dictionary<MapPos, int>.FindEntry
	|
	|-RVA: 0x3CD65D0 Offset: 0x3CD66D1 VA: 0x3CD65D0
	|-Dictionary<object, AsyncOperationHandle<object>>.FindEntry
	|
	|-RVA: 0x3CDA4F0 Offset: 0x3CDA5F1 VA: 0x3CDA4F0
	|-Dictionary<object, AsyncOperationHandle>.FindEntry
	|
	|-RVA: 0x3CDE210 Offset: 0x3CDE311 VA: 0x3CDE210
	|-Dictionary<object, bool>.FindEntry
	|
	|-RVA: 0x3CE1E10 Offset: 0x3CE1F11 VA: 0x3CE1E10
	|-Dictionary<object, byte>.FindEntry
	|
	|-RVA: 0x3CE5A00 Offset: 0x3CE5B01 VA: 0x3CE5A00
	|-Dictionary<object, int>.FindEntry
	|
	|-RVA: 0x3CE95F0 Offset: 0x3CE96F1 VA: 0x3CE95F0
	|-Dictionary<object, Int32Enum>.FindEntry
	|
	|-RVA: 0x3CED1D0 Offset: 0x3CED2D1 VA: 0x3CED1D0
	|-Dictionary<object, IntPtr>.FindEntry
	|
	|-RVA: 0x3CF0DF0 Offset: 0x3CF0EF1 VA: 0x3CF0DF0
	|-Dictionary<object, object>.FindEntry
	|
	|-RVA: 0x3C8BB80 Offset: 0x3C8BC81 VA: 0x3C8BB80
	|-Dictionary<object, Playable>.FindEntry
	|
	|-RVA: 0x3C8F760 Offset: 0x3C8F861 VA: 0x3C8F760
	|-Dictionary<object, ResourceLocator>.FindEntry
	|
	|-RVA: 0x3C93340 Offset: 0x3C93441 VA: 0x3C93340
	|-Dictionary<object, float>.FindEntry
	|
	|-RVA: 0x3C96F20 Offset: 0x3C97021 VA: 0x3C96F20
	|-Dictionary<object, ushort>.FindEntry
	|
	|-RVA: 0x3C9AB30 Offset: 0x3C9AC31 VA: 0x3C9AB30
	|-Dictionary<object, GameVariable.Value>.FindEntry
	|
	|-RVA: 0x3C9E950 Offset: 0x3C9EA51 VA: 0x3C9E950
	|-Dictionary<sbyte, DataStoreRatingInfo>.FindEntry
	|
	|-RVA: 0x3CA2620 Offset: 0x3CA2721 VA: 0x3CA2620
	|-Dictionary<sbyte, object>.FindEntry
	|
	|-RVA: 0x3D334A0 Offset: 0x3D335A1 VA: 0x3D334A0
	|-Dictionary<ushort, int>.FindEntry
	|
	|-RVA: 0x3D36F40 Offset: 0x3D37041 VA: 0x3D36F40
	|-Dictionary<uint, int>.FindEntry
	|
	|-RVA: 0x3D3AA70 Offset: 0x3D3AB71 VA: 0x3D3AA70
	|-Dictionary<uint, object>.FindEntry
	|
	|-RVA: 0x3D3E870 Offset: 0x3D3E971 VA: 0x3D3E870
	|-Dictionary<ulong, Friend>.FindEntry
	|
	|-RVA: 0x3D42570 Offset: 0x3D42671 VA: 0x3D42570
	|-Dictionary<ulong, Int32Enum>.FindEntry
	|
	|-RVA: 0x3D46130 Offset: 0x3D46231 VA: 0x3D46130
	|-Dictionary<ulong, object>.FindEntry
	|
	|-RVA: 0x3D49C30 Offset: 0x3D49D31 VA: 0x3D49C30
	|-Dictionary<Vector3, int>.FindEntry
	|
	|-RVA: 0x2628070 Offset: 0x2628171 VA: 0x2628070
	|-Dictionary<XPathNodeRef, XPathNodeRef>.FindEntry
	|
	|-RVA: 0x262BD00 Offset: 0x262BE01 VA: 0x262BD00
	|-Dictionary<TerrainUtility.TerrainMap.TileCoord, object>.FindEntry
	*/

	// RVA: -1 Offset: -1
	private void Initialize(int capacity) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x251D8C0 Offset: 0x251D9C1 VA: 0x251D8C0
	|-Dictionary<ValueTuple<object, int>, object>.Initialize
	|
	|-RVA: 0x25213D0 Offset: 0x25214D1 VA: 0x25213D0
	|-Dictionary<byte, object>.Initialize
	|
	|-RVA: 0x3CA6300 Offset: 0x3CA6401 VA: 0x3CA6300
	|-Dictionary<CancellationToken, object>.Initialize
	|
	|-RVA: 0x3CA9E10 Offset: 0x3CA9F11 VA: 0x3CA9E10
	|-Dictionary<char, object>.Initialize
	|
	|-RVA: 0x3CAD960 Offset: 0x3CADA61 VA: 0x3CAD960
	|-Dictionary<Guid, object>.Initialize
	|
	|-RVA: 0x3CB13E0 Offset: 0x3CB14E1 VA: 0x3CB13E0
	|-Dictionary<int, bool>.Initialize
	|
	|-RVA: 0x3CB4EA0 Offset: 0x3CB4FA1 VA: 0x3CB4EA0
	|-Dictionary<int, byte>.Initialize
	|
	|-RVA: 0x3CB8960 Offset: 0x3CB8A61 VA: 0x3CB8960
	|-Dictionary<int, char>.Initialize
	|
	|-RVA: 0x3CBC7B0 Offset: 0x3CBC8B1 VA: 0x3CBC7B0
	|-Dictionary<int, DiagnosticEvent>.Initialize
	|
	|-RVA: 0x3D4DA10 Offset: 0x3D4DB11 VA: 0x3D4DA10
	|-Dictionary<int, int>.Initialize
	|
	|-RVA: 0x3D514A0 Offset: 0x3D515A1 VA: 0x3D514A0
	|-Dictionary<int, Int32Enum>.Initialize
	|
	|-RVA: 0x3D54F70 Offset: 0x3D55071 VA: 0x3D54F70
	|-Dictionary<int, long>.Initialize
	|
	|-RVA: 0x3D58AE0 Offset: 0x3D58BE1 VA: 0x3D58AE0
	|-Dictionary<int, MapPos>.Initialize
	|
	|-RVA: 0x3D5C680 Offset: 0x3D5C781 VA: 0x3D5C680
	|-Dictionary<int, object>.Initialize
	|
	|-RVA: 0x3D600F0 Offset: 0x3D601F1 VA: 0x3D600F0
	|-Dictionary<int, uint>.Initialize
	|
	|-RVA: 0x3D63B80 Offset: 0x3D63C81 VA: 0x3D63B80
	|-Dictionary<int, AIThink.EnchantThink.SurroundingInfo>.Initialize
	|
	|-RVA: 0x3CC0450 Offset: 0x3CC0551 VA: 0x3CC0450
	|-Dictionary<Int32Enum, bool>.Initialize
	|
	|-RVA: 0x3CC3EF0 Offset: 0x3CC3FF1 VA: 0x3CC3EF0
	|-Dictionary<Int32Enum, int>.Initialize
	|
	|-RVA: 0x3CC7980 Offset: 0x3CC7A81 VA: 0x3CC7980
	|-Dictionary<Int32Enum, Int32Enum>.Initialize
	|
	|-RVA: 0x3CCB4B0 Offset: 0x3CCB5B1 VA: 0x3CCB4B0
	|-Dictionary<Int32Enum, object>.Initialize
	|
	|-RVA: 0x3CCEFB0 Offset: 0x3CCF0B1 VA: 0x3CCEFB0
	|-Dictionary<long, object>.Initialize
	|
	|-RVA: 0x3CD2A40 Offset: 0x3CD2B41 VA: 0x3CD2A40
	|-Dictionary<MapPos, int>.Initialize
	|
	|-RVA: 0x3CD6800 Offset: 0x3CD6901 VA: 0x3CD6800
	|-Dictionary<object, AsyncOperationHandle<object>>.Initialize
	|
	|-RVA: 0x3CDA720 Offset: 0x3CDA821 VA: 0x3CDA720
	|-Dictionary<object, AsyncOperationHandle>.Initialize
	|
	|-RVA: 0x3CDE440 Offset: 0x3CDE541 VA: 0x3CDE440
	|-Dictionary<object, bool>.Initialize
	|
	|-RVA: 0x3CE2040 Offset: 0x3CE2141 VA: 0x3CE2040
	|-Dictionary<object, byte>.Initialize
	|
	|-RVA: 0x3CE5C30 Offset: 0x3CE5D31 VA: 0x3CE5C30
	|-Dictionary<object, int>.Initialize
	|
	|-RVA: 0x3CE9820 Offset: 0x3CE9921 VA: 0x3CE9820
	|-Dictionary<object, Int32Enum>.Initialize
	|
	|-RVA: 0x3CED400 Offset: 0x3CED501 VA: 0x3CED400
	|-Dictionary<object, IntPtr>.Initialize
	|
	|-RVA: 0x3CF1020 Offset: 0x3CF1121 VA: 0x3CF1020
	|-Dictionary<object, object>.Initialize
	|
	|-RVA: 0x3C8BDB0 Offset: 0x3C8BEB1 VA: 0x3C8BDB0
	|-Dictionary<object, Playable>.Initialize
	|
	|-RVA: 0x3C8F990 Offset: 0x3C8FA91 VA: 0x3C8F990
	|-Dictionary<object, ResourceLocator>.Initialize
	|
	|-RVA: 0x3C93570 Offset: 0x3C93671 VA: 0x3C93570
	|-Dictionary<object, float>.Initialize
	|
	|-RVA: 0x3C97150 Offset: 0x3C97251 VA: 0x3C97150
	|-Dictionary<object, ushort>.Initialize
	|
	|-RVA: 0x3C9AD60 Offset: 0x3C9AE61 VA: 0x3C9AD60
	|-Dictionary<object, GameVariable.Value>.Initialize
	|
	|-RVA: 0x3C9EB30 Offset: 0x3C9EC31 VA: 0x3C9EB30
	|-Dictionary<sbyte, DataStoreRatingInfo>.Initialize
	|
	|-RVA: 0x3CA2800 Offset: 0x3CA2901 VA: 0x3CA2800
	|-Dictionary<sbyte, object>.Initialize
	|
	|-RVA: 0x3D33680 Offset: 0x3D33781 VA: 0x3D33680
	|-Dictionary<ushort, int>.Initialize
	|
	|-RVA: 0x3D37120 Offset: 0x3D37221 VA: 0x3D37120
	|-Dictionary<uint, int>.Initialize
	|
	|-RVA: 0x3D3AC50 Offset: 0x3D3AD51 VA: 0x3D3AC50
	|-Dictionary<uint, object>.Initialize
	|
	|-RVA: 0x3D3EA50 Offset: 0x3D3EB51 VA: 0x3D3EA50
	|-Dictionary<ulong, Friend>.Initialize
	|
	|-RVA: 0x3D42750 Offset: 0x3D42851 VA: 0x3D42750
	|-Dictionary<ulong, Int32Enum>.Initialize
	|
	|-RVA: 0x3D46310 Offset: 0x3D46411 VA: 0x3D46310
	|-Dictionary<ulong, object>.Initialize
	|
	|-RVA: 0x3D49E50 Offset: 0x3D49F51 VA: 0x3D49E50
	|-Dictionary<Vector3, int>.Initialize
	|
	|-RVA: 0x2628260 Offset: 0x2628361 VA: 0x2628260
	|-Dictionary<XPathNodeRef, XPathNodeRef>.Initialize
	|
	|-RVA: 0x262BEE0 Offset: 0x262BFE1 VA: 0x262BEE0
	|-Dictionary<TerrainUtility.TerrainMap.TileCoord, object>.Initialize
	*/

	// RVA: -1 Offset: -1
	private bool TryInsert(TKey key, TValue value, InsertionBehavior behavior) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x251DA10 Offset: 0x251DB11 VA: 0x251DA10
	|-Dictionary<ValueTuple<object, int>, object>.TryInsert
	|
	|-RVA: 0x2521520 Offset: 0x2521621 VA: 0x2521520
	|-Dictionary<byte, object>.TryInsert
	|
	|-RVA: 0x3CA6450 Offset: 0x3CA6551 VA: 0x3CA6450
	|-Dictionary<CancellationToken, object>.TryInsert
	|
	|-RVA: 0x3CA9F60 Offset: 0x3CAA061 VA: 0x3CA9F60
	|-Dictionary<char, object>.TryInsert
	|
	|-RVA: 0x3CADAB0 Offset: 0x3CADBB1 VA: 0x3CADAB0
	|-Dictionary<Guid, object>.TryInsert
	|
	|-RVA: 0x3CB1530 Offset: 0x3CB1631 VA: 0x3CB1530
	|-Dictionary<int, bool>.TryInsert
	|
	|-RVA: 0x3CB4FF0 Offset: 0x3CB50F1 VA: 0x3CB4FF0
	|-Dictionary<int, byte>.TryInsert
	|
	|-RVA: 0x3CB8AB0 Offset: 0x3CB8BB1 VA: 0x3CB8AB0
	|-Dictionary<int, char>.TryInsert
	|
	|-RVA: 0x3CBC900 Offset: 0x3CBCA01 VA: 0x3CBC900
	|-Dictionary<int, DiagnosticEvent>.TryInsert
	|
	|-RVA: 0x3D4DB60 Offset: 0x3D4DC61 VA: 0x3D4DB60
	|-Dictionary<int, int>.TryInsert
	|
	|-RVA: 0x3D515F0 Offset: 0x3D516F1 VA: 0x3D515F0
	|-Dictionary<int, Int32Enum>.TryInsert
	|
	|-RVA: 0x3D550C0 Offset: 0x3D551C1 VA: 0x3D550C0
	|-Dictionary<int, long>.TryInsert
	|
	|-RVA: 0x3D58C30 Offset: 0x3D58D31 VA: 0x3D58C30
	|-Dictionary<int, MapPos>.TryInsert
	|
	|-RVA: 0x3D5C7D0 Offset: 0x3D5C8D1 VA: 0x3D5C7D0
	|-Dictionary<int, object>.TryInsert
	|
	|-RVA: 0x3D60240 Offset: 0x3D60341 VA: 0x3D60240
	|-Dictionary<int, uint>.TryInsert
	|
	|-RVA: 0x3D63CD0 Offset: 0x3D63DD1 VA: 0x3D63CD0
	|-Dictionary<int, AIThink.EnchantThink.SurroundingInfo>.TryInsert
	|
	|-RVA: 0x3CC05A0 Offset: 0x3CC06A1 VA: 0x3CC05A0
	|-Dictionary<Int32Enum, bool>.TryInsert
	|
	|-RVA: 0x3CC4040 Offset: 0x3CC4141 VA: 0x3CC4040
	|-Dictionary<Int32Enum, int>.TryInsert
	|
	|-RVA: 0x3CC7AD0 Offset: 0x3CC7BD1 VA: 0x3CC7AD0
	|-Dictionary<Int32Enum, Int32Enum>.TryInsert
	|
	|-RVA: 0x3CCB600 Offset: 0x3CCB701 VA: 0x3CCB600
	|-Dictionary<Int32Enum, object>.TryInsert
	|
	|-RVA: 0x3CCF100 Offset: 0x3CCF201 VA: 0x3CCF100
	|-Dictionary<long, object>.TryInsert
	|
	|-RVA: 0x3CD2B90 Offset: 0x3CD2C91 VA: 0x3CD2B90
	|-Dictionary<MapPos, int>.TryInsert
	|
	|-RVA: 0x3CD6950 Offset: 0x3CD6A51 VA: 0x3CD6950
	|-Dictionary<object, AsyncOperationHandle<object>>.TryInsert
	|
	|-RVA: 0x3CDA870 Offset: 0x3CDA971 VA: 0x3CDA870
	|-Dictionary<object, AsyncOperationHandle>.TryInsert
	|
	|-RVA: 0x3CDE590 Offset: 0x3CDE691 VA: 0x3CDE590
	|-Dictionary<object, bool>.TryInsert
	|
	|-RVA: 0x3CE2190 Offset: 0x3CE2291 VA: 0x3CE2190
	|-Dictionary<object, byte>.TryInsert
	|
	|-RVA: 0x3CE5D80 Offset: 0x3CE5E81 VA: 0x3CE5D80
	|-Dictionary<object, int>.TryInsert
	|
	|-RVA: 0x3CE9970 Offset: 0x3CE9A71 VA: 0x3CE9970
	|-Dictionary<object, Int32Enum>.TryInsert
	|
	|-RVA: 0x3CED550 Offset: 0x3CED651 VA: 0x3CED550
	|-Dictionary<object, IntPtr>.TryInsert
	|
	|-RVA: 0x3CF1170 Offset: 0x3CF1271 VA: 0x3CF1170
	|-Dictionary<object, object>.TryInsert
	|
	|-RVA: 0x3C8BF00 Offset: 0x3C8C001 VA: 0x3C8BF00
	|-Dictionary<object, Playable>.TryInsert
	|
	|-RVA: 0x3C8FAE0 Offset: 0x3C8FBE1 VA: 0x3C8FAE0
	|-Dictionary<object, ResourceLocator>.TryInsert
	|
	|-RVA: 0x3C936C0 Offset: 0x3C937C1 VA: 0x3C936C0
	|-Dictionary<object, float>.TryInsert
	|
	|-RVA: 0x3C972A0 Offset: 0x3C973A1 VA: 0x3C972A0
	|-Dictionary<object, ushort>.TryInsert
	|
	|-RVA: 0x3C9AEB0 Offset: 0x3C9AFB1 VA: 0x3C9AEB0
	|-Dictionary<object, GameVariable.Value>.TryInsert
	|
	|-RVA: 0x3C9EC80 Offset: 0x3C9ED81 VA: 0x3C9EC80
	|-Dictionary<sbyte, DataStoreRatingInfo>.TryInsert
	|
	|-RVA: 0x3CA2950 Offset: 0x3CA2A51 VA: 0x3CA2950
	|-Dictionary<sbyte, object>.TryInsert
	|
	|-RVA: 0x3D337D0 Offset: 0x3D338D1 VA: 0x3D337D0
	|-Dictionary<ushort, int>.TryInsert
	|
	|-RVA: 0x3D37270 Offset: 0x3D37371 VA: 0x3D37270
	|-Dictionary<uint, int>.TryInsert
	|
	|-RVA: 0x3D3ADA0 Offset: 0x3D3AEA1 VA: 0x3D3ADA0
	|-Dictionary<uint, object>.TryInsert
	|
	|-RVA: 0x3D3EBA0 Offset: 0x3D3ECA1 VA: 0x3D3EBA0
	|-Dictionary<ulong, Friend>.TryInsert
	|
	|-RVA: 0x3D428A0 Offset: 0x3D429A1 VA: 0x3D428A0
	|-Dictionary<ulong, Int32Enum>.TryInsert
	|
	|-RVA: 0x3D46460 Offset: 0x3D46561 VA: 0x3D46460
	|-Dictionary<ulong, object>.TryInsert
	|
	|-RVA: 0x3D49FA0 Offset: 0x3D4A0A1 VA: 0x3D49FA0
	|-Dictionary<Vector3, int>.TryInsert
	|
	|-RVA: 0x26283B0 Offset: 0x26284B1 VA: 0x26283B0
	|-Dictionary<XPathNodeRef, XPathNodeRef>.TryInsert
	|
	|-RVA: 0x262C030 Offset: 0x262C131 VA: 0x262C030
	|-Dictionary<TerrainUtility.TerrainMap.TileCoord, object>.TryInsert
	*/

	// RVA: -1 Offset: -1 Slot: 38
	public virtual void OnDeserialization(object sender) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x251DF60 Offset: 0x251E061 VA: 0x251DF60
	|-Dictionary<ValueTuple<object, int>, object>.OnDeserialization
	|
	|-RVA: 0x2521A60 Offset: 0x2521B61 VA: 0x2521A60
	|-Dictionary<byte, object>.OnDeserialization
	|
	|-RVA: 0x3CA69A0 Offset: 0x3CA6AA1 VA: 0x3CA69A0
	|-Dictionary<CancellationToken, object>.OnDeserialization
	|
	|-RVA: 0x3CAA4A0 Offset: 0x3CAA5A1 VA: 0x3CAA4A0
	|-Dictionary<char, object>.OnDeserialization
	|
	|-RVA: 0x3CADFF0 Offset: 0x3CAE0F1 VA: 0x3CADFF0
	|-Dictionary<Guid, object>.OnDeserialization
	|
	|-RVA: 0x3CB1A30 Offset: 0x3CB1B31 VA: 0x3CB1A30
	|-Dictionary<int, bool>.OnDeserialization
	|
	|-RVA: 0x3CB54F0 Offset: 0x3CB55F1 VA: 0x3CB54F0
	|-Dictionary<int, byte>.OnDeserialization
	|
	|-RVA: 0x3D5CD10 Offset: 0x3D5CE11 VA: 0x3D5CD10
	|-Dictionary<int, CalculatorCommand>.OnDeserialization
	|-Dictionary<int, object>.OnDeserialization
	|-Dictionary<int, TerrainUtility.TerrainMap>.OnDeserialization
	|
	|-RVA: 0x3CB8FB0 Offset: 0x3CB90B1 VA: 0x3CB8FB0
	|-Dictionary<int, char>.OnDeserialization
	|
	|-RVA: 0x3CBCE70 Offset: 0x3CBCF71 VA: 0x3CBCE70
	|-Dictionary<int, DiagnosticEvent>.OnDeserialization
	|
	|-RVA: 0x3D4E060 Offset: 0x3D4E161 VA: 0x3D4E060
	|-Dictionary<int, int>.OnDeserialization
	|
	|-RVA: 0x3D51AF0 Offset: 0x3D51BF1 VA: 0x3D51AF0
	|-Dictionary<int, Int32Enum>.OnDeserialization
	|
	|-RVA: 0x3D555F0 Offset: 0x3D556F1 VA: 0x3D555F0
	|-Dictionary<int, long>.OnDeserialization
	|
	|-RVA: 0x3D59160 Offset: 0x3D59261 VA: 0x3D59160
	|-Dictionary<int, MapPos>.OnDeserialization
	|
	|-RVA: 0x3D60740 Offset: 0x3D60841 VA: 0x3D60740
	|-Dictionary<int, uint>.OnDeserialization
	|
	|-RVA: 0x3D641D0 Offset: 0x3D642D1 VA: 0x3D641D0
	|-Dictionary<int, AIThink.EnchantThink.SurroundingInfo>.OnDeserialization
	|
	|-RVA: 0x3CC0AA0 Offset: 0x3CC0BA1 VA: 0x3CC0AA0
	|-Dictionary<Int32Enum, bool>.OnDeserialization
	|
	|-RVA: 0x3CC4540 Offset: 0x3CC4641 VA: 0x3CC4540
	|-Dictionary<Int32Enum, int>.OnDeserialization
	|
	|-RVA: 0x3CC7FD0 Offset: 0x3CC80D1 VA: 0x3CC7FD0
	|-Dictionary<Int32Enum, Int32Enum>.OnDeserialization
	|
	|-RVA: 0x3CCBB40 Offset: 0x3CCBC41 VA: 0x3CCBB40
	|-Dictionary<Int32Enum, object>.OnDeserialization
	|
	|-RVA: 0x3CCF640 Offset: 0x3CCF741 VA: 0x3CCF640
	|-Dictionary<long, object>.OnDeserialization
	|
	|-RVA: 0x3CD30D0 Offset: 0x3CD31D1 VA: 0x3CD30D0
	|-Dictionary<MapPos, int>.OnDeserialization
	|
	|-RVA: 0x3CD6F00 Offset: 0x3CD7001 VA: 0x3CD6F00
	|-Dictionary<object, AsyncOperationHandle<object>>.OnDeserialization
	|
	|-RVA: 0x3CDAE20 Offset: 0x3CDAF21 VA: 0x3CDAE20
	|-Dictionary<object, AsyncOperationHandle>.OnDeserialization
	|
	|-RVA: 0x3CDEB10 Offset: 0x3CDEC11 VA: 0x3CDEB10
	|-Dictionary<object, bool>.OnDeserialization
	|
	|-RVA: 0x3CE2700 Offset: 0x3CE2801 VA: 0x3CE2700
	|-Dictionary<object, byte>.OnDeserialization
	|
	|-RVA: 0x3CE62F0 Offset: 0x3CE63F1 VA: 0x3CE62F0
	|-Dictionary<object, int>.OnDeserialization
	|-Dictionary<string, int>.OnDeserialization
	|
	|-RVA: 0x3CE9EE0 Offset: 0x3CE9FE1 VA: 0x3CE9EE0
	|-Dictionary<object, Int32Enum>.OnDeserialization
	|
	|-RVA: 0x3CEDAC0 Offset: 0x3CEDBC1 VA: 0x3CEDAC0
	|-Dictionary<object, IntPtr>.OnDeserialization
	|
	|-RVA: 0x3CF16E0 Offset: 0x3CF17E1 VA: 0x3CF16E0
	|-Dictionary<object, object>.OnDeserialization
	|-Dictionary<string, GameUserRestartData.Growth>.OnDeserialization
	|
	|-RVA: 0x3C8C450 Offset: 0x3C8C551 VA: 0x3C8C450
	|-Dictionary<object, Playable>.OnDeserialization
	|
	|-RVA: 0x3C90040 Offset: 0x3C90141 VA: 0x3C90040
	|-Dictionary<object, ResourceLocator>.OnDeserialization
	|
	|-RVA: 0x3C93C20 Offset: 0x3C93D21 VA: 0x3C93C20
	|-Dictionary<object, float>.OnDeserialization
	|
	|-RVA: 0x3C97810 Offset: 0x3C97911 VA: 0x3C97810
	|-Dictionary<object, ushort>.OnDeserialization
	|
	|-RVA: 0x3C9B410 Offset: 0x3C9B511 VA: 0x3C9B410
	|-Dictionary<object, GameVariable.Value>.OnDeserialization
	|
	|-RVA: 0x3C9F1F0 Offset: 0x3C9F2F1 VA: 0x3C9F1F0
	|-Dictionary<sbyte, DataStoreRatingInfo>.OnDeserialization
	|
	|-RVA: 0x3CA2E90 Offset: 0x3CA2F91 VA: 0x3CA2E90
	|-Dictionary<sbyte, object>.OnDeserialization
	|
	|-RVA: 0x3D33CD0 Offset: 0x3D33DD1 VA: 0x3D33CD0
	|-Dictionary<ushort, int>.OnDeserialization
	|
	|-RVA: 0x3D37770 Offset: 0x3D37871 VA: 0x3D37770
	|-Dictionary<uint, int>.OnDeserialization
	|
	|-RVA: 0x3D3B2E0 Offset: 0x3D3B3E1 VA: 0x3D3B2E0
	|-Dictionary<uint, object>.OnDeserialization
	|
	|-RVA: 0x3D3F110 Offset: 0x3D3F211 VA: 0x3D3F110
	|-Dictionary<ulong, Friend>.OnDeserialization
	|
	|-RVA: 0x3D42DE0 Offset: 0x3D42EE1 VA: 0x3D42DE0
	|-Dictionary<ulong, Int32Enum>.OnDeserialization
	|
	|-RVA: 0x3D469A0 Offset: 0x3D46AA1 VA: 0x3D469A0
	|-Dictionary<ulong, object>.OnDeserialization
	|
	|-RVA: 0x3D4A500 Offset: 0x3D4A601 VA: 0x3D4A500
	|-Dictionary<Vector3, int>.OnDeserialization
	|
	|-RVA: 0x2628940 Offset: 0x2628A41 VA: 0x2628940
	|-Dictionary<XPathNodeRef, XPathNodeRef>.OnDeserialization
	|
	|-RVA: 0x262C570 Offset: 0x262C671 VA: 0x262C570
	|-Dictionary<TerrainUtility.TerrainMap.TileCoord, object>.OnDeserialization
	*/

	// RVA: -1 Offset: -1
	private void Resize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x251E440 Offset: 0x251E541 VA: 0x251E440
	|-Dictionary<ValueTuple<object, int>, object>.Resize
	|
	|-RVA: 0x2521F40 Offset: 0x2522041 VA: 0x2521F40
	|-Dictionary<byte, object>.Resize
	|
	|-RVA: 0x3CA6E80 Offset: 0x3CA6F81 VA: 0x3CA6E80
	|-Dictionary<CancellationToken, object>.Resize
	|
	|-RVA: 0x3CAA980 Offset: 0x3CAAA81 VA: 0x3CAA980
	|-Dictionary<char, object>.Resize
	|
	|-RVA: 0x3CAE4D0 Offset: 0x3CAE5D1 VA: 0x3CAE4D0
	|-Dictionary<Guid, object>.Resize
	|
	|-RVA: 0x3CB1F10 Offset: 0x3CB2011 VA: 0x3CB1F10
	|-Dictionary<int, bool>.Resize
	|
	|-RVA: 0x3CB59D0 Offset: 0x3CB5AD1 VA: 0x3CB59D0
	|-Dictionary<int, byte>.Resize
	|
	|-RVA: 0x3CB9490 Offset: 0x3CB9591 VA: 0x3CB9490
	|-Dictionary<int, char>.Resize
	|
	|-RVA: 0x3CBD370 Offset: 0x3CBD471 VA: 0x3CBD370
	|-Dictionary<int, DiagnosticEvent>.Resize
	|
	|-RVA: 0x3D4E540 Offset: 0x3D4E641 VA: 0x3D4E540
	|-Dictionary<int, int>.Resize
	|
	|-RVA: 0x3D51FD0 Offset: 0x3D520D1 VA: 0x3D51FD0
	|-Dictionary<int, Int32Enum>.Resize
	|
	|-RVA: 0x3D55AD0 Offset: 0x3D55BD1 VA: 0x3D55AD0
	|-Dictionary<int, long>.Resize
	|
	|-RVA: 0x3D59640 Offset: 0x3D59741 VA: 0x3D59640
	|-Dictionary<int, MapPos>.Resize
	|
	|-RVA: 0x3D5D1F0 Offset: 0x3D5D2F1 VA: 0x3D5D1F0
	|-Dictionary<int, object>.Resize
	|
	|-RVA: 0x3D60C20 Offset: 0x3D60D21 VA: 0x3D60C20
	|-Dictionary<int, uint>.Resize
	|
	|-RVA: 0x3D646B0 Offset: 0x3D647B1 VA: 0x3D646B0
	|-Dictionary<int, AIThink.EnchantThink.SurroundingInfo>.Resize
	|
	|-RVA: 0x3CC0F80 Offset: 0x3CC1081 VA: 0x3CC0F80
	|-Dictionary<Int32Enum, bool>.Resize
	|
	|-RVA: 0x3CC4A20 Offset: 0x3CC4B21 VA: 0x3CC4A20
	|-Dictionary<Int32Enum, int>.Resize
	|
	|-RVA: 0x3CC84B0 Offset: 0x3CC85B1 VA: 0x3CC84B0
	|-Dictionary<Int32Enum, Int32Enum>.Resize
	|
	|-RVA: 0x3CCC020 Offset: 0x3CCC121 VA: 0x3CCC020
	|-Dictionary<Int32Enum, object>.Resize
	|
	|-RVA: 0x3CCFB20 Offset: 0x3CCFC21 VA: 0x3CCFB20
	|-Dictionary<long, object>.Resize
	|
	|-RVA: 0x3CD35B0 Offset: 0x3CD36B1 VA: 0x3CD35B0
	|-Dictionary<MapPos, int>.Resize
	|
	|-RVA: 0x3CD7410 Offset: 0x3CD7511 VA: 0x3CD7410
	|-Dictionary<object, AsyncOperationHandle<object>>.Resize
	|
	|-RVA: 0x3CDB330 Offset: 0x3CDB431 VA: 0x3CDB330
	|-Dictionary<object, AsyncOperationHandle>.Resize
	|
	|-RVA: 0x3CDF010 Offset: 0x3CDF111 VA: 0x3CDF010
	|-Dictionary<object, bool>.Resize
	|
	|-RVA: 0x3CE2C00 Offset: 0x3CE2D01 VA: 0x3CE2C00
	|-Dictionary<object, byte>.Resize
	|
	|-RVA: 0x3CE67F0 Offset: 0x3CE68F1 VA: 0x3CE67F0
	|-Dictionary<object, int>.Resize
	|
	|-RVA: 0x3CEA3E0 Offset: 0x3CEA4E1 VA: 0x3CEA3E0
	|-Dictionary<object, Int32Enum>.Resize
	|
	|-RVA: 0x3CEDFC0 Offset: 0x3CEE0C1 VA: 0x3CEDFC0
	|-Dictionary<object, IntPtr>.Resize
	|
	|-RVA: 0x3CF1BE0 Offset: 0x3CF1CE1 VA: 0x3CF1BE0
	|-Dictionary<object, object>.Resize
	|
	|-RVA: 0x3C8C950 Offset: 0x3C8CA51 VA: 0x3C8C950
	|-Dictionary<object, Playable>.Resize
	|
	|-RVA: 0x3C90540 Offset: 0x3C90641 VA: 0x3C90540
	|-Dictionary<object, ResourceLocator>.Resize
	|
	|-RVA: 0x3C94120 Offset: 0x3C94221 VA: 0x3C94120
	|-Dictionary<object, float>.Resize
	|
	|-RVA: 0x3C97D10 Offset: 0x3C97E11 VA: 0x3C97D10
	|-Dictionary<object, ushort>.Resize
	|
	|-RVA: 0x3C9B910 Offset: 0x3C9BA11 VA: 0x3C9B910
	|-Dictionary<object, GameVariable.Value>.Resize
	|
	|-RVA: 0x3C9F6E0 Offset: 0x3C9F7E1 VA: 0x3C9F6E0
	|-Dictionary<sbyte, DataStoreRatingInfo>.Resize
	|
	|-RVA: 0x3CA3370 Offset: 0x3CA3471 VA: 0x3CA3370
	|-Dictionary<sbyte, object>.Resize
	|
	|-RVA: 0x3D341B0 Offset: 0x3D342B1 VA: 0x3D341B0
	|-Dictionary<ushort, int>.Resize
	|
	|-RVA: 0x3D37C50 Offset: 0x3D37D51 VA: 0x3D37C50
	|-Dictionary<uint, int>.Resize
	|
	|-RVA: 0x3D3B7C0 Offset: 0x3D3B8C1 VA: 0x3D3B7C0
	|-Dictionary<uint, object>.Resize
	|
	|-RVA: 0x3D3F630 Offset: 0x3D3F731 VA: 0x3D3F630
	|-Dictionary<ulong, Friend>.Resize
	|
	|-RVA: 0x3D432C0 Offset: 0x3D433C1 VA: 0x3D432C0
	|-Dictionary<ulong, Int32Enum>.Resize
	|
	|-RVA: 0x3D46E80 Offset: 0x3D46F81 VA: 0x3D46E80
	|-Dictionary<ulong, object>.Resize
	|
	|-RVA: 0x3D4A9E0 Offset: 0x3D4AAE1 VA: 0x3D4A9E0
	|-Dictionary<Vector3, int>.Resize
	|
	|-RVA: 0x2628E20 Offset: 0x2628F21 VA: 0x2628E20
	|-Dictionary<XPathNodeRef, XPathNodeRef>.Resize
	|
	|-RVA: 0x262CA50 Offset: 0x262CB51 VA: 0x262CA50
	|-Dictionary<TerrainUtility.TerrainMap.TileCoord, object>.Resize
	*/

	// RVA: -1 Offset: -1
	private void Resize(int newSize, bool forceNewHashCodes) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x251E4E0 Offset: 0x251E5E1 VA: 0x251E4E0
	|-Dictionary<ValueTuple<object, int>, object>.Resize
	|
	|-RVA: 0x2521FE0 Offset: 0x25220E1 VA: 0x2521FE0
	|-Dictionary<byte, object>.Resize
	|
	|-RVA: 0x3CA6F20 Offset: 0x3CA7021 VA: 0x3CA6F20
	|-Dictionary<CancellationToken, object>.Resize
	|
	|-RVA: 0x3CAAA20 Offset: 0x3CAAB21 VA: 0x3CAAA20
	|-Dictionary<char, object>.Resize
	|
	|-RVA: 0x3CAE570 Offset: 0x3CAE671 VA: 0x3CAE570
	|-Dictionary<Guid, object>.Resize
	|
	|-RVA: 0x3CB1FB0 Offset: 0x3CB20B1 VA: 0x3CB1FB0
	|-Dictionary<int, bool>.Resize
	|
	|-RVA: 0x3CB5A70 Offset: 0x3CB5B71 VA: 0x3CB5A70
	|-Dictionary<int, byte>.Resize
	|
	|-RVA: 0x3CB9530 Offset: 0x3CB9631 VA: 0x3CB9530
	|-Dictionary<int, char>.Resize
	|
	|-RVA: 0x3CBD410 Offset: 0x3CBD511 VA: 0x3CBD410
	|-Dictionary<int, DiagnosticEvent>.Resize
	|
	|-RVA: 0x3D4E5E0 Offset: 0x3D4E6E1 VA: 0x3D4E5E0
	|-Dictionary<int, int>.Resize
	|
	|-RVA: 0x3D52070 Offset: 0x3D52171 VA: 0x3D52070
	|-Dictionary<int, Int32Enum>.Resize
	|
	|-RVA: 0x3D55B70 Offset: 0x3D55C71 VA: 0x3D55B70
	|-Dictionary<int, long>.Resize
	|
	|-RVA: 0x3D596E0 Offset: 0x3D597E1 VA: 0x3D596E0
	|-Dictionary<int, MapPos>.Resize
	|
	|-RVA: 0x3D5D290 Offset: 0x3D5D391 VA: 0x3D5D290
	|-Dictionary<int, object>.Resize
	|
	|-RVA: 0x3D60CC0 Offset: 0x3D60DC1 VA: 0x3D60CC0
	|-Dictionary<int, uint>.Resize
	|
	|-RVA: 0x3D64750 Offset: 0x3D64851 VA: 0x3D64750
	|-Dictionary<int, AIThink.EnchantThink.SurroundingInfo>.Resize
	|
	|-RVA: 0x3CC1020 Offset: 0x3CC1121 VA: 0x3CC1020
	|-Dictionary<Int32Enum, bool>.Resize
	|
	|-RVA: 0x3CC4AC0 Offset: 0x3CC4BC1 VA: 0x3CC4AC0
	|-Dictionary<Int32Enum, int>.Resize
	|
	|-RVA: 0x3CC8550 Offset: 0x3CC8651 VA: 0x3CC8550
	|-Dictionary<Int32Enum, Int32Enum>.Resize
	|
	|-RVA: 0x3CCC0C0 Offset: 0x3CCC1C1 VA: 0x3CCC0C0
	|-Dictionary<Int32Enum, object>.Resize
	|
	|-RVA: 0x3CCFBC0 Offset: 0x3CCFCC1 VA: 0x3CCFBC0
	|-Dictionary<long, object>.Resize
	|
	|-RVA: 0x3CD3650 Offset: 0x3CD3751 VA: 0x3CD3650
	|-Dictionary<MapPos, int>.Resize
	|
	|-RVA: 0x3CD74B0 Offset: 0x3CD75B1 VA: 0x3CD74B0
	|-Dictionary<object, AsyncOperationHandle<object>>.Resize
	|
	|-RVA: 0x3CDB3D0 Offset: 0x3CDB4D1 VA: 0x3CDB3D0
	|-Dictionary<object, AsyncOperationHandle>.Resize
	|
	|-RVA: 0x3CDF0B0 Offset: 0x3CDF1B1 VA: 0x3CDF0B0
	|-Dictionary<object, bool>.Resize
	|
	|-RVA: 0x3CE2CA0 Offset: 0x3CE2DA1 VA: 0x3CE2CA0
	|-Dictionary<object, byte>.Resize
	|
	|-RVA: 0x3CE6890 Offset: 0x3CE6991 VA: 0x3CE6890
	|-Dictionary<object, int>.Resize
	|
	|-RVA: 0x3CEA480 Offset: 0x3CEA581 VA: 0x3CEA480
	|-Dictionary<object, Int32Enum>.Resize
	|
	|-RVA: 0x3CEE060 Offset: 0x3CEE161 VA: 0x3CEE060
	|-Dictionary<object, IntPtr>.Resize
	|
	|-RVA: 0x3CF1C80 Offset: 0x3CF1D81 VA: 0x3CF1C80
	|-Dictionary<object, object>.Resize
	|
	|-RVA: 0x3C8C9F0 Offset: 0x3C8CAF1 VA: 0x3C8C9F0
	|-Dictionary<object, Playable>.Resize
	|
	|-RVA: 0x3C905E0 Offset: 0x3C906E1 VA: 0x3C905E0
	|-Dictionary<object, ResourceLocator>.Resize
	|
	|-RVA: 0x3C941C0 Offset: 0x3C942C1 VA: 0x3C941C0
	|-Dictionary<object, float>.Resize
	|
	|-RVA: 0x3C97DB0 Offset: 0x3C97EB1 VA: 0x3C97DB0
	|-Dictionary<object, ushort>.Resize
	|
	|-RVA: 0x3C9B9B0 Offset: 0x3C9BAB1 VA: 0x3C9B9B0
	|-Dictionary<object, GameVariable.Value>.Resize
	|
	|-RVA: 0x3C9F780 Offset: 0x3C9F881 VA: 0x3C9F780
	|-Dictionary<sbyte, DataStoreRatingInfo>.Resize
	|
	|-RVA: 0x3CA3410 Offset: 0x3CA3511 VA: 0x3CA3410
	|-Dictionary<sbyte, object>.Resize
	|
	|-RVA: 0x3D34250 Offset: 0x3D34351 VA: 0x3D34250
	|-Dictionary<ushort, int>.Resize
	|
	|-RVA: 0x3D37CF0 Offset: 0x3D37DF1 VA: 0x3D37CF0
	|-Dictionary<uint, int>.Resize
	|
	|-RVA: 0x3D3B860 Offset: 0x3D3B961 VA: 0x3D3B860
	|-Dictionary<uint, object>.Resize
	|
	|-RVA: 0x3D3F6D0 Offset: 0x3D3F7D1 VA: 0x3D3F6D0
	|-Dictionary<ulong, Friend>.Resize
	|
	|-RVA: 0x3D43360 Offset: 0x3D43461 VA: 0x3D43360
	|-Dictionary<ulong, Int32Enum>.Resize
	|
	|-RVA: 0x3D46F20 Offset: 0x3D47021 VA: 0x3D46F20
	|-Dictionary<ulong, object>.Resize
	|
	|-RVA: 0x3D4AA80 Offset: 0x3D4AB81 VA: 0x3D4AA80
	|-Dictionary<Vector3, int>.Resize
	|
	|-RVA: 0x2628EC0 Offset: 0x2628FC1 VA: 0x2628EC0
	|-Dictionary<XPathNodeRef, XPathNodeRef>.Resize
	|
	|-RVA: 0x262CAF0 Offset: 0x262CBF1 VA: 0x262CAF0
	|-Dictionary<TerrainUtility.TerrainMap.TileCoord, object>.Resize
	*/

	// RVA: -1 Offset: -1 Slot: 39
	public bool Remove(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x251E780 Offset: 0x251E881 VA: 0x251E780
	|-Dictionary<ValueTuple<object, int>, object>.Remove
	|
	|-RVA: 0x3CF1F20 Offset: 0x3CF2021 VA: 0x3CF1F20
	|-Dictionary<Action, LinkedListNode<Action>>.Remove
	|-Dictionary<AkAudioListener, AkObstructionOcclusion.ObstructionOcclusionValue>.Remove
	|-Dictionary<Canvas, IndexedSet<Graphic>>.Remove
	|-Dictionary<CinemachineVirtualCameraBase, CinemachineCore.UpdateStatus>.Remove
	|-Dictionary<Collider, AkRoomAwareObject>.Remove
	|-Dictionary<Font, HashSet<Text>>.Remove
	|-Dictionary<GameObject, GameObject>.Remove
	|-Dictionary<IDtdEntityInfo, IDtdEntityInfo>.Remove
	|-Dictionary<IOperationCacheKey, IAsyncOperation>.Remove
	|-Dictionary<IResourceLocation, ContentCatalogProvider.InternalOp>.Remove
	|-Dictionary<object, Delegate>.Remove
	|-Dictionary<object, object>.Remove
	|-Dictionary<string, Stack<ResourceHandle>>.Remove
	|-Dictionary<string, AssetBundleLocalResource>.Remove
	|-Dictionary<string, FileData>.Remove
	|-Dictionary<string, GodBond>.Remove
	|-Dictionary<string, GodData>.Remove
	|-Dictionary<string, IMemberDescriptor>.Remove
	|-Dictionary<string, LocalDataStoreSlot>.Remove
	|-Dictionary<string, MsgFile>.Remove
	|-Dictionary<string, object>.Remove
	|-Dictionary<string, ResourceHandle>.Remove
	|-Dictionary<string, string>.Remove
	|-Dictionary<string, SymbolRef>.Remove
	|-Dictionary<string, Transform>.Remove
	|-Dictionary<string, AkBankManager.BankHandle>.Remove
	|-Dictionary<string, AssetTable.Accessory>.Remove
	|-Dictionary<string, DtdParser.UndeclaredNotation>.Remove
	|-Dictionary<string, EventDemoSequence.CharacterWork>.Remove
	|-Dictionary<string, EventDemoSequence.EffectWork>.Remove
	|-Dictionary<string, GameUserRestartData.Growth>.Remove
	|-Dictionary<string, RingInfo.RingPrefabObject>.Remove
	|-Dictionary<string, ServicePointScheduler.ConnectionGroup>.Remove
	|-Dictionary<string, SoundSystem.LipSyncDataFile>.Remove
	|-Dictionary<string, SoundWwise.SoundBankManager.BankHandle>.Remove
	|-Dictionary<string, SoundWwise.SoundPrepareManager.EventParam>.Remove
	|-Dictionary<string, SoundWwise.SoundPrepareManager.SwitchParam>.Remove
	|-Dictionary<Thread, StackTrace>.Remove
	|-Dictionary<Transform, UpdateTracker.UpdateStatus>.Remove
	|-Dictionary<Type, Func<DynValue, object>>.Remove
	|-Dictionary<Type, Func<Script, object, DynValue>>.Remove
	|-Dictionary<Type, IUserDataDescriptor>.Remove
	|-Dictionary<Unit, string>.Remove
	|-Dictionary<XmlQualifiedName, SchemaElementDecl>.Remove
	|-Dictionary<XmlQualifiedName, XmlSchemaObject>.Remove
	|
	|-RVA: 0x2522280 Offset: 0x2522381 VA: 0x2522280
	|-Dictionary<byte, object>.Remove
	|
	|-RVA: 0x3CA71C0 Offset: 0x3CA72C1 VA: 0x3CA71C0
	|-Dictionary<CancellationToken, object>.Remove
	|
	|-RVA: 0x3CAACC0 Offset: 0x3CAADC1 VA: 0x3CAACC0
	|-Dictionary<char, object>.Remove
	|
	|-RVA: 0x3CD7750 Offset: 0x3CD7851 VA: 0x3CD7750
	|-Dictionary<GameObject, AsyncOperationHandle<GameObject>>.Remove
	|-Dictionary<object, AsyncOperationHandle<object>>.Remove
	|
	|-RVA: 0x3CAE810 Offset: 0x3CAE911 VA: 0x3CAE810
	|-Dictionary<Guid, object>.Remove
	|
	|-RVA: 0x3D5D530 Offset: 0x3D5D631 VA: 0x3D5D530
	|-Dictionary<int, List<object>>.Remove
	|-Dictionary<int, RTHandle[]>.Remove
	|-Dictionary<int, CalculatorCommand>.Remove
	|-Dictionary<int, DiagnosticInfo>.Remove
	|-Dictionary<int, MapInfoIconLocatorRoot>.Remove
	|-Dictionary<int, object>.Remove
	|-Dictionary<int, PointerEventData>.Remove
	|-Dictionary<int, Task>.Remove
	|-Dictionary<int, AkCallbackManager.BankCallbackPackage>.Remove
	|-Dictionary<int, AkCallbackManager.EventCallbackPackage>.Remove
	|-Dictionary<int, TerrainUtility.TerrainMap>.Remove
	|
	|-RVA: 0x3CB2240 Offset: 0x3CB2341 VA: 0x3CB2240
	|-Dictionary<int, bool>.Remove
	|
	|-RVA: 0x3CB5D00 Offset: 0x3CB5E01 VA: 0x3CB5D00
	|-Dictionary<int, byte>.Remove
	|
	|-RVA: 0x3CB97C0 Offset: 0x3CB98C1 VA: 0x3CB97C0
	|-Dictionary<int, char>.Remove
	|
	|-RVA: 0x3CBD6A0 Offset: 0x3CBD7A1 VA: 0x3CBD6A0
	|-Dictionary<int, DiagnosticEvent>.Remove
	|
	|-RVA: 0x3D4E870 Offset: 0x3D4E971 VA: 0x3D4E870
	|-Dictionary<int, int>.Remove
	|
	|-RVA: 0x3D52300 Offset: 0x3D52401 VA: 0x3D52300
	|-Dictionary<int, Int32Enum>.Remove
	|
	|-RVA: 0x3D55E10 Offset: 0x3D55F11 VA: 0x3D55E10
	|-Dictionary<int, long>.Remove
	|
	|-RVA: 0x3D59980 Offset: 0x3D59A81 VA: 0x3D59980
	|-Dictionary<int, MapPos>.Remove
	|
	|-RVA: 0x3D60F50 Offset: 0x3D61051 VA: 0x3D60F50
	|-Dictionary<int, uint>.Remove
	|
	|-RVA: 0x3D649E0 Offset: 0x3D64AE1 VA: 0x3D649E0
	|-Dictionary<int, AIThink.EnchantThink.SurroundingInfo>.Remove
	|
	|-RVA: 0x3CC12B0 Offset: 0x3CC13B1 VA: 0x3CC12B0
	|-Dictionary<Int32Enum, bool>.Remove
	|
	|-RVA: 0x3CC4D50 Offset: 0x3CC4E51 VA: 0x3CC4D50
	|-Dictionary<Int32Enum, int>.Remove
	|
	|-RVA: 0x3CC87E0 Offset: 0x3CC88E1 VA: 0x3CC87E0
	|-Dictionary<Int32Enum, Int32Enum>.Remove
	|
	|-RVA: 0x3CCC360 Offset: 0x3CCC461 VA: 0x3CCC360
	|-Dictionary<Int32Enum, object>.Remove
	|
	|-RVA: 0x3CCFE60 Offset: 0x3CCFF61 VA: 0x3CCFE60
	|-Dictionary<long, object>.Remove
	|-Dictionary<long, TMP_MaterialManager.FallbackMaterial>.Remove
	|
	|-RVA: 0x3CD38F0 Offset: 0x3CD39F1 VA: 0x3CD38F0
	|-Dictionary<MapPos, int>.Remove
	|
	|-RVA: 0x3CDB670 Offset: 0x3CDB771 VA: 0x3CDB670
	|-Dictionary<object, AsyncOperationHandle>.Remove
	|-Dictionary<string, AsyncOperationHandle>.Remove
	|
	|-RVA: 0x3CDF350 Offset: 0x3CDF451 VA: 0x3CDF350
	|-Dictionary<object, bool>.Remove
	|
	|-RVA: 0x3CE2F40 Offset: 0x3CE3041 VA: 0x3CE2F40
	|-Dictionary<object, byte>.Remove
	|
	|-RVA: 0x3CE6B30 Offset: 0x3CE6C31 VA: 0x3CE6B30
	|-Dictionary<object, int>.Remove
	|-Dictionary<ParameterExpression, int>.Remove
	|-Dictionary<string, int>.Remove
	|-Dictionary<Unit, int>.Remove
	|
	|-RVA: 0x3CEA720 Offset: 0x3CEA821 VA: 0x3CEA720
	|-Dictionary<object, Int32Enum>.Remove
	|
	|-RVA: 0x3CEE300 Offset: 0x3CEE401 VA: 0x3CEE300
	|-Dictionary<object, IntPtr>.Remove
	|-Dictionary<string, IntPtr>.Remove
	|
	|-RVA: 0x3C8CC80 Offset: 0x3C8CD81 VA: 0x3C8CC80
	|-Dictionary<object, Playable>.Remove
	|
	|-RVA: 0x3C90870 Offset: 0x3C90971 VA: 0x3C90870
	|-Dictionary<object, ResourceLocator>.Remove
	|
	|-RVA: 0x3C94460 Offset: 0x3C94561 VA: 0x3C94460
	|-Dictionary<object, float>.Remove
	|
	|-RVA: 0x3C98050 Offset: 0x3C98151 VA: 0x3C98050
	|-Dictionary<object, ushort>.Remove
	|
	|-RVA: 0x3C9BC40 Offset: 0x3C9BD41 VA: 0x3C9BC40
	|-Dictionary<object, GameVariable.Value>.Remove
	|-Dictionary<string, GameVariable.Value>.Remove
	|
	|-RVA: 0x3C9FA20 Offset: 0x3C9FB21 VA: 0x3C9FA20
	|-Dictionary<sbyte, DataStoreRatingInfo>.Remove
	|
	|-RVA: 0x3CA36B0 Offset: 0x3CA37B1 VA: 0x3CA36B0
	|-Dictionary<sbyte, object>.Remove
	|
	|-RVA: 0x3D344E0 Offset: 0x3D345E1 VA: 0x3D344E0
	|-Dictionary<ushort, int>.Remove
	|
	|-RVA: 0x3D3BB00 Offset: 0x3D3BC01 VA: 0x3D3BB00
	|-Dictionary<uint, AkMultiPosEvent>.Remove
	|-Dictionary<uint, object>.Remove
	|-Dictionary<uint, AkAudioInputManager.AudioFormatDelegate>.Remove
	|-Dictionary<uint, AkAudioInputManager.AudioSamplesDelegate>.Remove
	|
	|-RVA: 0x3D37F80 Offset: 0x3D38081 VA: 0x3D37F80
	|-Dictionary<uint, int>.Remove
	|
	|-RVA: 0x3D3F970 Offset: 0x3D3FA71 VA: 0x3D3F970
	|-Dictionary<ulong, Friend>.Remove
	|
	|-RVA: 0x3D43600 Offset: 0x3D43701 VA: 0x3D43600
	|-Dictionary<ulong, Int32Enum>.Remove
	|
	|-RVA: 0x3D471C0 Offset: 0x3D472C1 VA: 0x3D471C0
	|-Dictionary<ulong, object>.Remove
	|-Dictionary<ulong, RelayUserGlobalData.Ticket>.Remove
	|
	|-RVA: 0x3D4AD30 Offset: 0x3D4AE31 VA: 0x3D4AD30
	|-Dictionary<Vector3, int>.Remove
	|
	|-RVA: 0x2629180 Offset: 0x2629281 VA: 0x2629180
	|-Dictionary<XPathNodeRef, XPathNodeRef>.Remove
	|
	|-RVA: 0x262CD90 Offset: 0x262CE91 VA: 0x262CD90
	|-Dictionary<TerrainUtility.TerrainMap.TileCoord, object>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 30
	public bool TryGetValue(TKey key, out TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x251EA80 Offset: 0x251EB81 VA: 0x251EA80
	|-Dictionary<ValueTuple<object, int>, object>.TryGetValue
	|-Dictionary<ValueTuple<Type, int>, Stack<object>>.TryGetValue
	|
	|-RVA: 0x3CF2280 Offset: 0x3CF2381 VA: 0x3CF2280
	|-Dictionary<Action, LinkedListNode<Action>>.TryGetValue
	|-Dictionary<AnimationClip, List<CinemachineStateDrivenCamera.HashPair>>.TryGetValue
	|-Dictionary<Camera, HashSet<Action<RenderTargetIdentifier, CommandBuffer>>>.TryGetValue
	|-Dictionary<Camera, Camera>.TryGetValue
	|-Dictionary<Canvas, IndexedSet<Graphic>>.TryGetValue
	|-Dictionary<CinemachineVirtualCameraBase, CinemachineCore.UpdateStatus>.TryGetValue
	|-Dictionary<Collider, AkRoomAwareObject>.TryGetValue
	|-Dictionary<FieldInfo, Instruction>.TryGetValue
	|-Dictionary<Font, HashSet<Text>>.TryGetValue
	|-Dictionary<GameObject, Stack<GameObject>>.TryGetValue
	|-Dictionary<GameObject, GameObject>.TryGetValue
	|-Dictionary<IAsyncLocal, object>.TryGetValue
	|-Dictionary<ICinemachineCamera, object>.TryGetValue
	|-Dictionary<IOperationCacheKey, IAsyncOperation>.TryGetValue
	|-Dictionary<object, IList<IResourceLocation>>.TryGetValue
	|-Dictionary<object, object>.TryGetValue
	|-Dictionary<ParameterExpression, LocalVariable>.TryGetValue
	|-Dictionary<Renderer, MapObject.DitherPair>.TryGetValue
	|-Dictionary<string, List<GodGrowthData.LevelData>>.TryGetValue
	|-Dictionary<string, List<RangeData.Offset>>.TryGetValue
	|-Dictionary<string, Stack<ResourceHandle>>.TryGetValue
	|-Dictionary<string, TResourceHandle<AnimationClip>>.TryGetValue
	|-Dictionary<string, Tuple<Guid, string>>.TryGetValue
	|-Dictionary<string, Unit[]>.TryGetValue
	|-Dictionary<string, CultureInfo>.TryGetValue
	|-Dictionary<string, FileData>.TryGetValue
	|-Dictionary<string, GUIStyle>.TryGetValue
	|-Dictionary<string, GodBond>.TryGetValue
	|-Dictionary<string, GodData>.TryGetValue
	|-Dictionary<string, GodWeaponRefineLevels>.TryGetValue
	|-Dictionary<string, GodWeaponRefineResult>.TryGetValue
	|-Dictionary<string, IMemberDescriptor>.TryGetValue
	|-Dictionary<string, LabelStatement>.TryGetValue
	|-Dictionary<string, MapObject>.TryGetValue
	|-Dictionary<string, MsgFile>.TryGetValue
	|-Dictionary<string, object>.TryGetValue
	|-Dictionary<string, Object>.TryGetValue
	|-Dictionary<string, ResourceHandle>.TryGetValue
	|-Dictionary<string, SimpleCollator>.TryGetValue
	|-Dictionary<string, Sprite>.TryGetValue
	|-Dictionary<string, string>.TryGetValue
	|-Dictionary<string, Transform>.TryGetValue
	|-Dictionary<string, Type>.TryGetValue
	|-Dictionary<string, UnitRelianceData>.TryGetValue
	|-Dictionary<string, UriParser>.TryGetValue
	|-Dictionary<string, VibrationFile>.TryGetValue
	|-Dictionary<string, AkBankManager.BankHandle>.TryGetValue
	|-Dictionary<string, ChapterRecord.Record>.TryGetValue
	|-Dictionary<string, DtdParser.UndeclaredNotation>.TryGetValue
	|-Dictionary<string, EventDemoSequence.CmdFunc>.TryGetValue
	|-Dictionary<string, FieldBgmManager.BgmHandle>.TryGetValue
	|-Dictionary<string, GameUserRestartData.Growth>.TryGetValue
	|-Dictionary<string, ServicePointScheduler.ConnectionGroup>.TryGetValue
	|-Dictionary<string, SoundSystem.LipSyncDataFile>.TryGetValue
	|-Dictionary<string, SoundWwise.SoundBankManager.BankHandle>.TryGetValue
	|-Dictionary<string, SoundWwise.SoundPrepareManager.EventParam>.TryGetValue
	|-Dictionary<string, SoundWwise.SoundPrepareManager.SwitchParam>.TryGetValue
	|-Dictionary<string, SoundWwise.SoundPrepareManager.SwitchParamList>.TryGetValue
	|-Dictionary<Transform, List<SpringBone>>.TryGetValue
	|-Dictionary<Transform, TargetPositionCache.CacheEntry>.TryGetValue
	|-Dictionary<Transform, UpdateTracker.UpdateStatus>.TryGetValue
	|-Dictionary<Type, AttributeUsageAttribute>.TryGetValue
	|-Dictionary<Type, IUserDataDescriptor>.TryGetValue
	|-Dictionary<Type, object>.TryGetValue
	|-Dictionary<Type, string>.TryGetValue
	|-Dictionary<Type, TrackBindingTypeAttribute>.TryGetValue
	|-Dictionary<Type, Transform>.TryGetValue
	|-Dictionary<Type, Type>.TryGetValue
	|-Dictionary<Type, TypeInformation>.TryGetValue
	|-Dictionary<Type, VolumeComponent>.TryGetValue
	|-Dictionary<Type, MonoCustomAttrs.AttributeInfo>.TryGetValue
	|-Dictionary<VersusServerReplayMetaData, string>.TryGetValue
	|-Dictionary<XmlQualifiedName, SchemaAttDef>.TryGetValue
	|-Dictionary<XmlQualifiedName, SchemaElementDecl>.TryGetValue
	|-Dictionary<XmlQualifiedName, SchemaEntity>.TryGetValue
	|-Dictionary<XmlQualifiedName, XmlSchemaObject>.TryGetValue
	|
	|-RVA: 0x2522590 Offset: 0x2522691 VA: 0x2522590
	|-Dictionary<byte, object>.TryGetValue
	|
	|-RVA: 0x3CA74D0 Offset: 0x3CA75D1 VA: 0x3CA74D0
	|-Dictionary<CancellationToken, object>.TryGetValue
	|
	|-RVA: 0x3CAAFD0 Offset: 0x3CAB0D1 VA: 0x3CAAFD0
	|-Dictionary<char, object>.TryGetValue
	|
	|-RVA: 0x3CE6E90 Offset: 0x3CE6F91 VA: 0x3CE6E90
	|-Dictionary<CinemachineVirtualCameraBase, int>.TryGetValue
	|-Dictionary<object, int>.TryGetValue
	|-Dictionary<ParameterExpression, int>.TryGetValue
	|-Dictionary<string, int>.TryGetValue
	|
	|-RVA: 0x3CC15A0 Offset: 0x3CC16A1 VA: 0x3CC15A0
	|-Dictionary<FormatUsage, bool>.TryGetValue
	|-Dictionary<Int32Enum, bool>.TryGetValue
	|-Dictionary<RenderTextureFormat, bool>.TryGetValue
	|
	|-RVA: 0x3CD7AB0 Offset: 0x3CD7BB1 VA: 0x3CD7AB0
	|-Dictionary<GameObject, AsyncOperationHandle<GameObject>>.TryGetValue
	|-Dictionary<object, AsyncOperationHandle<object>>.TryGetValue
	|
	|-RVA: 0x3CCC670 Offset: 0x3CCC771 VA: 0x3CCC670
	|-Dictionary<GraphicsFormat, Dictionary<FormatUsage, bool>>.TryGetValue
	|-Dictionary<Int32Enum, object>.TryGetValue
	|-Dictionary<Mess.TagGroup, TalkTag>.TryGetValue
	|
	|-RVA: 0x3CAEB10 Offset: 0x3CAEC11 VA: 0x3CAEB10
	|-Dictionary<Guid, MonoTlsProvider>.TryGetValue
	|-Dictionary<Guid, object>.TryGetValue
	|
	|-RVA: 0x3D5D840 Offset: 0x3D5D941 VA: 0x3D5D840
	|-Dictionary<int, List<AchieveData>>.TryGetValue
	|-Dictionary<int, List<object>>.TryGetValue
	|-Dictionary<int, List<Volume>>.TryGetValue
	|-Dictionary<int, RTHandle[]>.TryGetValue
	|-Dictionary<int, CalculatorCommand>.TryGetValue
	|-Dictionary<int, CultureInfo>.TryGetValue
	|-Dictionary<int, DiagnosticInfo>.TryGetValue
	|-Dictionary<int, GameObject>.TryGetValue
	|-Dictionary<int, IResourceProvider>.TryGetValue
	|-Dictionary<int, Material>.TryGetValue
	|-Dictionary<int, object>.TryGetValue
	|-Dictionary<int, PointerEventData>.TryGetValue
	|-Dictionary<int, PrefetchedSignal>.TryGetValue
	|-Dictionary<int, ProfilingSampler>.TryGetValue
	|-Dictionary<int, ResourceGameObject>.TryGetValue
	|-Dictionary<int, string>.TryGetValue
	|-Dictionary<int, TMP_ColorGradient>.TryGetValue
	|-Dictionary<int, TMP_FontAsset>.TryGetValue
	|-Dictionary<int, TMP_SpriteAsset>.TryGetValue
	|-Dictionary<int, TMP_Style>.TryGetValue
	|-Dictionary<int, AkCallbackManager.BankCallbackPackage>.TryGetValue
	|-Dictionary<int, AkCallbackManager.EventCallbackPackage>.TryGetValue
	|-Dictionary<int, GUILayoutUtility.LayoutCache>.TryGetValue
	|-Dictionary<int, MapEditor.EditObject>.TryGetValue
	|-Dictionary<int, TerrainUtility.TerrainMap>.TryGetValue
	|-Dictionary<int, MapHistory.Rewind.OverlapData>.TryGetValue
	|
	|-RVA: 0x3CB2530 Offset: 0x3CB2631 VA: 0x3CB2530
	|-Dictionary<int, bool>.TryGetValue
	|
	|-RVA: 0x3CB5FF0 Offset: 0x3CB60F1 VA: 0x3CB5FF0
	|-Dictionary<int, byte>.TryGetValue
	|
	|-RVA: 0x3CB9AB0 Offset: 0x3CB9BB1 VA: 0x3CB9AB0
	|-Dictionary<int, char>.TryGetValue
	|
	|-RVA: 0x3CBD990 Offset: 0x3CBDA91 VA: 0x3CBD990
	|-Dictionary<int, DiagnosticEvent>.TryGetValue
	|
	|-RVA: 0x3D4EB60 Offset: 0x3D4EC61 VA: 0x3D4EB60
	|-Dictionary<int, int>.TryGetValue
	|
	|-RVA: 0x3D525F0 Offset: 0x3D526F1 VA: 0x3D525F0
	|-Dictionary<int, Int32Enum>.TryGetValue
	|-Dictionary<int, MapPanelTarget.DangerType>.TryGetValue
	|-Dictionary<int, UnitRecord.Kinds>.TryGetValue
	|
	|-RVA: 0x3D56120 Offset: 0x3D56221 VA: 0x3D56120
	|-Dictionary<int, long>.TryGetValue
	|
	|-RVA: 0x3D59C90 Offset: 0x3D59D91 VA: 0x3D59C90
	|-Dictionary<int, MapPos>.TryGetValue
	|
	|-RVA: 0x3D61240 Offset: 0x3D61341 VA: 0x3D61240
	|-Dictionary<int, uint>.TryGetValue
	|
	|-RVA: 0x3D64CD0 Offset: 0x3D64DD1 VA: 0x3D64CD0
	|-Dictionary<int, AIThink.EnchantThink.SurroundingInfo>.TryGetValue
	|
	|-RVA: 0x3CC5040 Offset: 0x3CC5141 VA: 0x3CC5040
	|-Dictionary<Int32Enum, int>.TryGetValue
	|-Dictionary<UnitRecord.Kinds, int>.TryGetValue
	|
	|-RVA: 0x3CC8AD0 Offset: 0x3CC8BD1 VA: 0x3CC8AD0
	|-Dictionary<Int32Enum, Int32Enum>.TryGetValue
	|
	|-RVA: 0x3CD0170 Offset: 0x3CD0271 VA: 0x3CD0170
	|-Dictionary<long, object>.TryGetValue
	|-Dictionary<long, TMP_MaterialManager.FallbackMaterial>.TryGetValue
	|
	|-RVA: 0x3C947C0 Offset: 0x3C948C1 VA: 0x3C947C0
	|-Dictionary<MapCollision, float>.TryGetValue
	|-Dictionary<object, float>.TryGetValue
	|
	|-RVA: 0x3CD3C00 Offset: 0x3CD3D01 VA: 0x3CD3C00
	|-Dictionary<MapPos, int>.TryGetValue
	|
	|-RVA: 0x3CDB9D0 Offset: 0x3CDBAD1 VA: 0x3CDB9D0
	|-Dictionary<object, AsyncOperationHandle>.TryGetValue
	|-Dictionary<string, AsyncOperationHandle>.TryGetValue
	|
	|-RVA: 0x3CDF6B0 Offset: 0x3CDF7B1 VA: 0x3CDF6B0
	|-Dictionary<object, bool>.TryGetValue
	|-Dictionary<string, bool>.TryGetValue
	|
	|-RVA: 0x3CE32A0 Offset: 0x3CE33A1 VA: 0x3CE32A0
	|-Dictionary<object, byte>.TryGetValue
	|
	|-RVA: 0x3CEAA80 Offset: 0x3CEAB81 VA: 0x3CEAA80
	|-Dictionary<object, Int32Enum>.TryGetValue
	|
	|-RVA: 0x3CEE660 Offset: 0x3CEE761 VA: 0x3CEE660
	|-Dictionary<object, IntPtr>.TryGetValue
	|-Dictionary<string, IntPtr>.TryGetValue
	|
	|-RVA: 0x3C8CFC0 Offset: 0x3C8D0C1 VA: 0x3C8CFC0
	|-Dictionary<object, Playable>.TryGetValue
	|-Dictionary<TrackAsset, Playable>.TryGetValue
	|
	|-RVA: 0x3C90BB0 Offset: 0x3C90CB1 VA: 0x3C90BB0
	|-Dictionary<object, ResourceLocator>.TryGetValue
	|-Dictionary<string, ResourceLocator>.TryGetValue
	|
	|-RVA: 0x3C983B0 Offset: 0x3C984B1 VA: 0x3C983B0
	|-Dictionary<object, ushort>.TryGetValue
	|
	|-RVA: 0x3C9BF80 Offset: 0x3C9C081 VA: 0x3C9BF80
	|-Dictionary<object, GameVariable.Value>.TryGetValue
	|-Dictionary<string, GameVariable.Value>.TryGetValue
	|
	|-RVA: 0x3C9FD30 Offset: 0x3C9FE31 VA: 0x3C9FD30
	|-Dictionary<sbyte, DataStoreRatingInfo>.TryGetValue
	|
	|-RVA: 0x3CA39C0 Offset: 0x3CA3AC1 VA: 0x3CA39C0
	|-Dictionary<sbyte, DataStoreRatingInitParam>.TryGetValue
	|-Dictionary<sbyte, object>.TryGetValue
	|
	|-RVA: 0x3D347D0 Offset: 0x3D348D1 VA: 0x3D347D0
	|-Dictionary<ushort, int>.TryGetValue
	|
	|-RVA: 0x3D3BE10 Offset: 0x3D3BF11 VA: 0x3D3BE10
	|-Dictionary<uint, AkMultiPosEvent>.TryGetValue
	|-Dictionary<uint, Glyph>.TryGetValue
	|-Dictionary<uint, Material>.TryGetValue
	|-Dictionary<uint, object>.TryGetValue
	|-Dictionary<uint, string>.TryGetValue
	|-Dictionary<uint, TMP_Character>.TryGetValue
	|-Dictionary<uint, TMP_GlyphPairAdjustmentRecord>.TryGetValue
	|-Dictionary<uint, TMP_SpriteCharacter>.TryGetValue
	|
	|-RVA: 0x3D38270 Offset: 0x3D38371 VA: 0x3D38270
	|-Dictionary<uint, int>.TryGetValue
	|
	|-RVA: 0x3D3FC90 Offset: 0x3D3FD91 VA: 0x3D3FC90
	|-Dictionary<ulong, Friend>.TryGetValue
	|
	|-RVA: 0x3D43910 Offset: 0x3D43A11 VA: 0x3D43910
	|-Dictionary<ulong, Int32Enum>.TryGetValue
	|
	|-RVA: 0x3D474D0 Offset: 0x3D475D1 VA: 0x3D474D0
	|-Dictionary<ulong, object>.TryGetValue
	|
	|-RVA: 0x3D4B070 Offset: 0x3D4B171 VA: 0x3D4B070
	|-Dictionary<Vector3, int>.TryGetValue
	|
	|-RVA: 0x26294B0 Offset: 0x26295B1 VA: 0x26294B0
	|-Dictionary<XPathNodeRef, XPathNodeRef>.TryGetValue
	|
	|-RVA: 0x262D0A0 Offset: 0x262D1A1 VA: 0x262D0A0
	|-Dictionary<TerrainUtility.TerrainMap.TileCoord, object>.TryGetValue
	|-Dictionary<TerrainUtility.TerrainMap.TileCoord, Terrain>.TryGetValue
	*/

	// RVA: -1 Offset: -1
	public bool TryAdd(TKey key, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x251EB10 Offset: 0x251EC11 VA: 0x251EB10
	|-Dictionary<ValueTuple<object, int>, object>.TryAdd
	|
	|-RVA: 0x2522620 Offset: 0x2522721 VA: 0x2522620
	|-Dictionary<byte, object>.TryAdd
	|
	|-RVA: 0x3CA7560 Offset: 0x3CA7661 VA: 0x3CA7560
	|-Dictionary<CancellationToken, object>.TryAdd
	|
	|-RVA: 0x3CAB060 Offset: 0x3CAB161 VA: 0x3CAB060
	|-Dictionary<char, object>.TryAdd
	|
	|-RVA: 0x3CAEBA0 Offset: 0x3CAECA1 VA: 0x3CAEBA0
	|-Dictionary<Guid, object>.TryAdd
	|
	|-RVA: 0x3CB25B0 Offset: 0x3CB26B1 VA: 0x3CB25B0
	|-Dictionary<int, bool>.TryAdd
	|
	|-RVA: 0x3CB6070 Offset: 0x3CB6171 VA: 0x3CB6070
	|-Dictionary<int, byte>.TryAdd
	|
	|-RVA: 0x3CB9B30 Offset: 0x3CB9C31 VA: 0x3CB9B30
	|-Dictionary<int, char>.TryAdd
	|
	|-RVA: 0x3CBDA30 Offset: 0x3CBDB31 VA: 0x3CBDA30
	|-Dictionary<int, DiagnosticEvent>.TryAdd
	|
	|-RVA: 0x3D4EBE0 Offset: 0x3D4ECE1 VA: 0x3D4EBE0
	|-Dictionary<int, int>.TryAdd
	|
	|-RVA: 0x3D52670 Offset: 0x3D52771 VA: 0x3D52670
	|-Dictionary<int, Int32Enum>.TryAdd
	|
	|-RVA: 0x3D561A0 Offset: 0x3D562A1 VA: 0x3D561A0
	|-Dictionary<int, long>.TryAdd
	|
	|-RVA: 0x3D59D10 Offset: 0x3D59E11 VA: 0x3D59D10
	|-Dictionary<int, MapPos>.TryAdd
	|
	|-RVA: 0x3D5D8D0 Offset: 0x3D5D9D1 VA: 0x3D5D8D0
	|-Dictionary<int, object>.TryAdd
	|
	|-RVA: 0x3D612C0 Offset: 0x3D613C1 VA: 0x3D612C0
	|-Dictionary<int, uint>.TryAdd
	|
	|-RVA: 0x3D64D50 Offset: 0x3D64E51 VA: 0x3D64D50
	|-Dictionary<int, AIThink.EnchantThink.SurroundingInfo>.TryAdd
	|
	|-RVA: 0x3CC1620 Offset: 0x3CC1721 VA: 0x3CC1620
	|-Dictionary<Int32Enum, bool>.TryAdd
	|
	|-RVA: 0x3CC50C0 Offset: 0x3CC51C1 VA: 0x3CC50C0
	|-Dictionary<Int32Enum, int>.TryAdd
	|
	|-RVA: 0x3CC8B50 Offset: 0x3CC8C51 VA: 0x3CC8B50
	|-Dictionary<Int32Enum, Int32Enum>.TryAdd
	|
	|-RVA: 0x3CCC700 Offset: 0x3CCC801 VA: 0x3CCC700
	|-Dictionary<Int32Enum, object>.TryAdd
	|
	|-RVA: 0x3CD0200 Offset: 0x3CD0301 VA: 0x3CD0200
	|-Dictionary<long, object>.TryAdd
	|
	|-RVA: 0x3CD3C80 Offset: 0x3CD3D81 VA: 0x3CD3C80
	|-Dictionary<MapPos, int>.TryAdd
	|
	|-RVA: 0x3CD7B50 Offset: 0x3CD7C51 VA: 0x3CD7B50
	|-Dictionary<object, AsyncOperationHandle<object>>.TryAdd
	|
	|-RVA: 0x3CDBA70 Offset: 0x3CDBB71 VA: 0x3CDBA70
	|-Dictionary<object, AsyncOperationHandle>.TryAdd
	|
	|-RVA: 0x3CDF730 Offset: 0x3CDF831 VA: 0x3CDF730
	|-Dictionary<object, bool>.TryAdd
	|
	|-RVA: 0x3CE3320 Offset: 0x3CE3421 VA: 0x3CE3320
	|-Dictionary<object, byte>.TryAdd
	|
	|-RVA: 0x3CE6F10 Offset: 0x3CE7011 VA: 0x3CE6F10
	|-Dictionary<object, int>.TryAdd
	|-Dictionary<string, int>.TryAdd
	|
	|-RVA: 0x3CEAB00 Offset: 0x3CEAC01 VA: 0x3CEAB00
	|-Dictionary<object, Int32Enum>.TryAdd
	|
	|-RVA: 0x3CEE6E0 Offset: 0x3CEE7E1 VA: 0x3CEE6E0
	|-Dictionary<object, IntPtr>.TryAdd
	|
	|-RVA: 0x3CF2310 Offset: 0x3CF2411 VA: 0x3CF2310
	|-Dictionary<object, object>.TryAdd
	|
	|-RVA: 0x3C8D040 Offset: 0x3C8D141 VA: 0x3C8D040
	|-Dictionary<object, Playable>.TryAdd
	|
	|-RVA: 0x3C90C40 Offset: 0x3C90D41 VA: 0x3C90C40
	|-Dictionary<object, ResourceLocator>.TryAdd
	|
	|-RVA: 0x3C94840 Offset: 0x3C94941 VA: 0x3C94840
	|-Dictionary<object, float>.TryAdd
	|
	|-RVA: 0x3C98430 Offset: 0x3C98531 VA: 0x3C98430
	|-Dictionary<object, ushort>.TryAdd
	|
	|-RVA: 0x3C9C010 Offset: 0x3C9C111 VA: 0x3C9C010
	|-Dictionary<object, GameVariable.Value>.TryAdd
	|
	|-RVA: 0x3C9FDC0 Offset: 0x3C9FEC1 VA: 0x3C9FDC0
	|-Dictionary<sbyte, DataStoreRatingInfo>.TryAdd
	|
	|-RVA: 0x3CA3A50 Offset: 0x3CA3B51 VA: 0x3CA3A50
	|-Dictionary<sbyte, object>.TryAdd
	|
	|-RVA: 0x3D34850 Offset: 0x3D34951 VA: 0x3D34850
	|-Dictionary<ushort, int>.TryAdd
	|
	|-RVA: 0x3D382F0 Offset: 0x3D383F1 VA: 0x3D382F0
	|-Dictionary<uint, int>.TryAdd
	|
	|-RVA: 0x3D3BEA0 Offset: 0x3D3BFA1 VA: 0x3D3BEA0
	|-Dictionary<uint, object>.TryAdd
	|
	|-RVA: 0x3D3FD20 Offset: 0x3D3FE21 VA: 0x3D3FD20
	|-Dictionary<ulong, Friend>.TryAdd
	|
	|-RVA: 0x3D43990 Offset: 0x3D43A91 VA: 0x3D43990
	|-Dictionary<ulong, Int32Enum>.TryAdd
	|
	|-RVA: 0x3D47560 Offset: 0x3D47661 VA: 0x3D47560
	|-Dictionary<ulong, object>.TryAdd
	|
	|-RVA: 0x3D4B0F0 Offset: 0x3D4B1F1 VA: 0x3D4B0F0
	|-Dictionary<Vector3, int>.TryAdd
	|
	|-RVA: 0x2629540 Offset: 0x2629641 VA: 0x2629540
	|-Dictionary<XPathNodeRef, XPathNodeRef>.TryAdd
	|
	|-RVA: 0x262D130 Offset: 0x262D231 VA: 0x262D130
	|-Dictionary<TerrainUtility.TerrainMap.TileCoord, object>.TryAdd
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x251EB30 Offset: 0x251EC31 VA: 0x251EB30
	|-Dictionary<ValueTuple<object, int>, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x2522640 Offset: 0x2522741 VA: 0x2522640
	|-Dictionary<byte, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x3CA7580 Offset: 0x3CA7681 VA: 0x3CA7580
	|-Dictionary<CancellationToken, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x3CAB080 Offset: 0x3CAB181 VA: 0x3CAB080
	|-Dictionary<char, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x3CAEBC0 Offset: 0x3CAECC1 VA: 0x3CAEBC0
	|-Dictionary<Guid, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x3CB25D0 Offset: 0x3CB26D1 VA: 0x3CB25D0
	|-Dictionary<int, bool>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x3CB6090 Offset: 0x3CB6191 VA: 0x3CB6090
	|-Dictionary<int, byte>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x3D5D8F0 Offset: 0x3D5D9F1 VA: 0x3D5D8F0
	|-Dictionary<int, CalculatorCommand>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|-Dictionary<int, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|-Dictionary<int, TerrainUtility.TerrainMap>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x3CB9B50 Offset: 0x3CB9C51 VA: 0x3CB9B50
	|-Dictionary<int, char>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x3CBDA90 Offset: 0x3CBDB91 VA: 0x3CBDA90
	|-Dictionary<int, DiagnosticEvent>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x3D4EC00 Offset: 0x3D4ED01 VA: 0x3D4EC00
	|-Dictionary<int, int>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x3D52690 Offset: 0x3D52791 VA: 0x3D52690
	|-Dictionary<int, Int32Enum>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x3D561C0 Offset: 0x3D562C1 VA: 0x3D561C0
	|-Dictionary<int, long>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x3D59D30 Offset: 0x3D59E31 VA: 0x3D59D30
	|-Dictionary<int, MapPos>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x3D612E0 Offset: 0x3D613E1 VA: 0x3D612E0
	|-Dictionary<int, uint>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x3D64D70 Offset: 0x3D64E71 VA: 0x3D64D70
	|-Dictionary<int, AIThink.EnchantThink.SurroundingInfo>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x3CC1640 Offset: 0x3CC1741 VA: 0x3CC1640
	|-Dictionary<Int32Enum, bool>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x3CC50E0 Offset: 0x3CC51E1 VA: 0x3CC50E0
	|-Dictionary<Int32Enum, int>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x3CC8B70 Offset: 0x3CC8C71 VA: 0x3CC8B70
	|-Dictionary<Int32Enum, Int32Enum>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x3CCC720 Offset: 0x3CCC821 VA: 0x3CCC720
	|-Dictionary<Int32Enum, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x3CD0220 Offset: 0x3CD0321 VA: 0x3CD0220
	|-Dictionary<long, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x3CD3CA0 Offset: 0x3CD3DA1 VA: 0x3CD3CA0
	|-Dictionary<MapPos, int>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x3CD7BA0 Offset: 0x3CD7CA1 VA: 0x3CD7BA0
	|-Dictionary<object, AsyncOperationHandle<object>>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x3CDBAC0 Offset: 0x3CDBBC1 VA: 0x3CDBAC0
	|-Dictionary<object, AsyncOperationHandle>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x3CDF750 Offset: 0x3CDF851 VA: 0x3CDF750
	|-Dictionary<object, bool>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x3CE3340 Offset: 0x3CE3441 VA: 0x3CE3340
	|-Dictionary<object, byte>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x3CE6F30 Offset: 0x3CE7031 VA: 0x3CE6F30
	|-Dictionary<object, int>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|-Dictionary<string, int>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x3CEAB20 Offset: 0x3CEAC21 VA: 0x3CEAB20
	|-Dictionary<object, Int32Enum>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x3CEE700 Offset: 0x3CEE801 VA: 0x3CEE700
	|-Dictionary<object, IntPtr>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x3CF2330 Offset: 0x3CF2431 VA: 0x3CF2330
	|-Dictionary<object, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|-Dictionary<string, GameUserRestartData.Growth>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x3C8D060 Offset: 0x3C8D161 VA: 0x3C8D060
	|-Dictionary<object, Playable>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x3C90C60 Offset: 0x3C90D61 VA: 0x3C90C60
	|-Dictionary<object, ResourceLocator>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x3C94860 Offset: 0x3C94961 VA: 0x3C94860
	|-Dictionary<object, float>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x3C98450 Offset: 0x3C98551 VA: 0x3C98450
	|-Dictionary<object, ushort>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x3C9C030 Offset: 0x3C9C131 VA: 0x3C9C030
	|-Dictionary<object, GameVariable.Value>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x3C9FE10 Offset: 0x3C9FF11 VA: 0x3C9FE10
	|-Dictionary<sbyte, DataStoreRatingInfo>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x3CA3A70 Offset: 0x3CA3B71 VA: 0x3CA3A70
	|-Dictionary<sbyte, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x3D34870 Offset: 0x3D34971 VA: 0x3D34870
	|-Dictionary<ushort, int>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x3D38310 Offset: 0x3D38411 VA: 0x3D38310
	|-Dictionary<uint, int>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x3D3BEC0 Offset: 0x3D3BFC1 VA: 0x3D3BEC0
	|-Dictionary<uint, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x3D3FDB0 Offset: 0x3D3FEB1 VA: 0x3D3FDB0
	|-Dictionary<ulong, Friend>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x3D439B0 Offset: 0x3D43AB1 VA: 0x3D439B0
	|-Dictionary<ulong, Int32Enum>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x3D47580 Offset: 0x3D47681 VA: 0x3D47580
	|-Dictionary<ulong, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x3D4B110 Offset: 0x3D4B211 VA: 0x3D4B110
	|-Dictionary<Vector3, int>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x2629560 Offset: 0x2629661 VA: 0x2629560
	|-Dictionary<XPathNodeRef, XPathNodeRef>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x262D150 Offset: 0x262D251 VA: 0x262D150
	|-Dictionary<TerrainUtility.TerrainMap.TileCoord, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 12
	private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(KeyValuePair<TKey, TValue>[] array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x251EB40 Offset: 0x251EC41 VA: 0x251EB40
	|-Dictionary<ValueTuple<object, int>, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x2522650 Offset: 0x2522751 VA: 0x2522650
	|-Dictionary<byte, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x3CA7590 Offset: 0x3CA7691 VA: 0x3CA7590
	|-Dictionary<CancellationToken, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x3CAB090 Offset: 0x3CAB191 VA: 0x3CAB090
	|-Dictionary<char, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x3CAEBD0 Offset: 0x3CAECD1 VA: 0x3CAEBD0
	|-Dictionary<Guid, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x3CB25E0 Offset: 0x3CB26E1 VA: 0x3CB25E0
	|-Dictionary<int, bool>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x3CB60A0 Offset: 0x3CB61A1 VA: 0x3CB60A0
	|-Dictionary<int, byte>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x3D5D900 Offset: 0x3D5DA01 VA: 0x3D5D900
	|-Dictionary<int, CalculatorCommand>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|-Dictionary<int, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|-Dictionary<int, TerrainUtility.TerrainMap>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x3CB9B60 Offset: 0x3CB9C61 VA: 0x3CB9B60
	|-Dictionary<int, char>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x3CBDAA0 Offset: 0x3CBDBA1 VA: 0x3CBDAA0
	|-Dictionary<int, DiagnosticEvent>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x3D4EC10 Offset: 0x3D4ED11 VA: 0x3D4EC10
	|-Dictionary<int, int>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x3D526A0 Offset: 0x3D527A1 VA: 0x3D526A0
	|-Dictionary<int, Int32Enum>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x3D561D0 Offset: 0x3D562D1 VA: 0x3D561D0
	|-Dictionary<int, long>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x3D59D40 Offset: 0x3D59E41 VA: 0x3D59D40
	|-Dictionary<int, MapPos>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x3D612F0 Offset: 0x3D613F1 VA: 0x3D612F0
	|-Dictionary<int, uint>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x3D64D80 Offset: 0x3D64E81 VA: 0x3D64D80
	|-Dictionary<int, AIThink.EnchantThink.SurroundingInfo>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x3CC1650 Offset: 0x3CC1751 VA: 0x3CC1650
	|-Dictionary<Int32Enum, bool>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x3CC50F0 Offset: 0x3CC51F1 VA: 0x3CC50F0
	|-Dictionary<Int32Enum, int>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x3CC8B80 Offset: 0x3CC8C81 VA: 0x3CC8B80
	|-Dictionary<Int32Enum, Int32Enum>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x3CCC730 Offset: 0x3CCC831 VA: 0x3CCC730
	|-Dictionary<Int32Enum, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x3CD0230 Offset: 0x3CD0331 VA: 0x3CD0230
	|-Dictionary<long, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x3CD3CB0 Offset: 0x3CD3DB1 VA: 0x3CD3CB0
	|-Dictionary<MapPos, int>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x3CD7BB0 Offset: 0x3CD7CB1 VA: 0x3CD7BB0
	|-Dictionary<object, AsyncOperationHandle<object>>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x3CDBAD0 Offset: 0x3CDBBD1 VA: 0x3CDBAD0
	|-Dictionary<object, AsyncOperationHandle>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x3CDF760 Offset: 0x3CDF861 VA: 0x3CDF760
	|-Dictionary<object, bool>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x3CE3350 Offset: 0x3CE3451 VA: 0x3CE3350
	|-Dictionary<object, byte>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x3CE6F40 Offset: 0x3CE7041 VA: 0x3CE6F40
	|-Dictionary<object, int>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|-Dictionary<string, int>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x3CEAB30 Offset: 0x3CEAC31 VA: 0x3CEAB30
	|-Dictionary<object, Int32Enum>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x3CEE710 Offset: 0x3CEE811 VA: 0x3CEE710
	|-Dictionary<object, IntPtr>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x3CF2340 Offset: 0x3CF2441 VA: 0x3CF2340
	|-Dictionary<object, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|-Dictionary<string, GameUserRestartData.Growth>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x3C8D070 Offset: 0x3C8D171 VA: 0x3C8D070
	|-Dictionary<object, Playable>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x3C90C70 Offset: 0x3C90D71 VA: 0x3C90C70
	|-Dictionary<object, ResourceLocator>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x3C94870 Offset: 0x3C94971 VA: 0x3C94870
	|-Dictionary<object, float>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x3C98460 Offset: 0x3C98561 VA: 0x3C98460
	|-Dictionary<object, ushort>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x3C9C040 Offset: 0x3C9C141 VA: 0x3C9C040
	|-Dictionary<object, GameVariable.Value>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x3C9FE20 Offset: 0x3C9FF21 VA: 0x3C9FE20
	|-Dictionary<sbyte, DataStoreRatingInfo>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x3CA3A80 Offset: 0x3CA3B81 VA: 0x3CA3A80
	|-Dictionary<sbyte, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x3D34880 Offset: 0x3D34981 VA: 0x3D34880
	|-Dictionary<ushort, int>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x3D38320 Offset: 0x3D38421 VA: 0x3D38320
	|-Dictionary<uint, int>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x3D3BED0 Offset: 0x3D3BFD1 VA: 0x3D3BED0
	|-Dictionary<uint, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x3D3FDC0 Offset: 0x3D3FEC1 VA: 0x3D3FDC0
	|-Dictionary<ulong, Friend>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x3D439C0 Offset: 0x3D43AC1 VA: 0x3D439C0
	|-Dictionary<ulong, Int32Enum>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x3D47590 Offset: 0x3D47691 VA: 0x3D47590
	|-Dictionary<ulong, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x3D4B120 Offset: 0x3D4B221 VA: 0x3D4B120
	|-Dictionary<Vector3, int>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x2629570 Offset: 0x2629671 VA: 0x2629570
	|-Dictionary<XPathNodeRef, XPathNodeRef>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x262D160 Offset: 0x262D261 VA: 0x262D160
	|-Dictionary<TerrainUtility.TerrainMap.TileCoord, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 26
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x251EB60 Offset: 0x251EC61 VA: 0x251EB60
	|-Dictionary<ValueTuple<object, int>, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2522670 Offset: 0x2522771 VA: 0x2522670
	|-Dictionary<byte, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3CA75B0 Offset: 0x3CA76B1 VA: 0x3CA75B0
	|-Dictionary<CancellationToken, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3CAB0B0 Offset: 0x3CAB1B1 VA: 0x3CAB0B0
	|-Dictionary<char, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3CAEBF0 Offset: 0x3CAECF1 VA: 0x3CAEBF0
	|-Dictionary<Guid, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3CB2600 Offset: 0x3CB2701 VA: 0x3CB2600
	|-Dictionary<int, bool>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3CB60C0 Offset: 0x3CB61C1 VA: 0x3CB60C0
	|-Dictionary<int, byte>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3D5D920 Offset: 0x3D5DA21 VA: 0x3D5D920
	|-Dictionary<int, CalculatorCommand>.System.Collections.ICollection.CopyTo
	|-Dictionary<int, object>.System.Collections.ICollection.CopyTo
	|-Dictionary<int, TerrainUtility.TerrainMap>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3CB9B80 Offset: 0x3CB9C81 VA: 0x3CB9B80
	|-Dictionary<int, char>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3CBDAC0 Offset: 0x3CBDBC1 VA: 0x3CBDAC0
	|-Dictionary<int, DiagnosticEvent>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3D4EC30 Offset: 0x3D4ED31 VA: 0x3D4EC30
	|-Dictionary<int, int>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3D526C0 Offset: 0x3D527C1 VA: 0x3D526C0
	|-Dictionary<int, Int32Enum>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3D561F0 Offset: 0x3D562F1 VA: 0x3D561F0
	|-Dictionary<int, long>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3D59D60 Offset: 0x3D59E61 VA: 0x3D59D60
	|-Dictionary<int, MapPos>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3D61310 Offset: 0x3D61411 VA: 0x3D61310
	|-Dictionary<int, uint>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3D64DA0 Offset: 0x3D64EA1 VA: 0x3D64DA0
	|-Dictionary<int, AIThink.EnchantThink.SurroundingInfo>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3CC1670 Offset: 0x3CC1771 VA: 0x3CC1670
	|-Dictionary<Int32Enum, bool>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3CC5110 Offset: 0x3CC5211 VA: 0x3CC5110
	|-Dictionary<Int32Enum, int>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3CC8BA0 Offset: 0x3CC8CA1 VA: 0x3CC8BA0
	|-Dictionary<Int32Enum, Int32Enum>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3CCC750 Offset: 0x3CCC851 VA: 0x3CCC750
	|-Dictionary<Int32Enum, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3CD0250 Offset: 0x3CD0351 VA: 0x3CD0250
	|-Dictionary<long, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3CD3CD0 Offset: 0x3CD3DD1 VA: 0x3CD3CD0
	|-Dictionary<MapPos, int>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3CD7BD0 Offset: 0x3CD7CD1 VA: 0x3CD7BD0
	|-Dictionary<object, AsyncOperationHandle<object>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3CDBAF0 Offset: 0x3CDBBF1 VA: 0x3CDBAF0
	|-Dictionary<object, AsyncOperationHandle>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3CDF780 Offset: 0x3CDF881 VA: 0x3CDF780
	|-Dictionary<object, bool>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3CE3370 Offset: 0x3CE3471 VA: 0x3CE3370
	|-Dictionary<object, byte>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3CE6F60 Offset: 0x3CE7061 VA: 0x3CE6F60
	|-Dictionary<object, int>.System.Collections.ICollection.CopyTo
	|-Dictionary<string, int>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3CEAB50 Offset: 0x3CEAC51 VA: 0x3CEAB50
	|-Dictionary<object, Int32Enum>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3CEE730 Offset: 0x3CEE831 VA: 0x3CEE730
	|-Dictionary<object, IntPtr>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3CF2360 Offset: 0x3CF2461 VA: 0x3CF2360
	|-Dictionary<object, object>.System.Collections.ICollection.CopyTo
	|-Dictionary<string, GameUserRestartData.Growth>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3C8D090 Offset: 0x3C8D191 VA: 0x3C8D090
	|-Dictionary<object, Playable>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3C90C90 Offset: 0x3C90D91 VA: 0x3C90C90
	|-Dictionary<object, ResourceLocator>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3C94890 Offset: 0x3C94991 VA: 0x3C94890
	|-Dictionary<object, float>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3C98480 Offset: 0x3C98581 VA: 0x3C98480
	|-Dictionary<object, ushort>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3C9C060 Offset: 0x3C9C161 VA: 0x3C9C060
	|-Dictionary<object, GameVariable.Value>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3C9FE40 Offset: 0x3C9FF41 VA: 0x3C9FE40
	|-Dictionary<sbyte, DataStoreRatingInfo>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3CA3AA0 Offset: 0x3CA3BA1 VA: 0x3CA3AA0
	|-Dictionary<sbyte, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3D348A0 Offset: 0x3D349A1 VA: 0x3D348A0
	|-Dictionary<ushort, int>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3D38340 Offset: 0x3D38441 VA: 0x3D38340
	|-Dictionary<uint, int>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3D3BEF0 Offset: 0x3D3BFF1 VA: 0x3D3BEF0
	|-Dictionary<uint, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3D3FDE0 Offset: 0x3D3FEE1 VA: 0x3D3FDE0
	|-Dictionary<ulong, Friend>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3D439E0 Offset: 0x3D43AE1 VA: 0x3D439E0
	|-Dictionary<ulong, Int32Enum>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3D475B0 Offset: 0x3D476B1 VA: 0x3D475B0
	|-Dictionary<ulong, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3D4B140 Offset: 0x3D4B241 VA: 0x3D4B140
	|-Dictionary<Vector3, int>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2629590 Offset: 0x2629691 VA: 0x2629590
	|-Dictionary<XPathNodeRef, XPathNodeRef>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x262D180 Offset: 0x262D281 VA: 0x262D180
	|-Dictionary<TerrainUtility.TerrainMap.TileCoord, object>.System.Collections.ICollection.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 15
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x251F0C0 Offset: 0x251F1C1 VA: 0x251F0C0
	|-Dictionary<ValueTuple<object, int>, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2522BD0 Offset: 0x2522CD1 VA: 0x2522BD0
	|-Dictionary<byte, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3CA7B00 Offset: 0x3CA7C01 VA: 0x3CA7B00
	|-Dictionary<CancellationToken, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3CAB610 Offset: 0x3CAB711 VA: 0x3CAB610
	|-Dictionary<char, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3CAF150 Offset: 0x3CAF251 VA: 0x3CAF150
	|-Dictionary<Guid, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3CB2BA0 Offset: 0x3CB2CA1 VA: 0x3CB2BA0
	|-Dictionary<int, bool>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3CB6660 Offset: 0x3CB6761 VA: 0x3CB6660
	|-Dictionary<int, byte>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3D5DE80 Offset: 0x3D5DF81 VA: 0x3D5DE80
	|-Dictionary<int, CalculatorCommand>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary<int, object>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary<int, TerrainUtility.TerrainMap>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3CBA120 Offset: 0x3CBA221 VA: 0x3CBA120
	|-Dictionary<int, char>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3CBE0C0 Offset: 0x3CBE1C1 VA: 0x3CBE0C0
	|-Dictionary<int, DiagnosticEvent>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3D4F1C0 Offset: 0x3D4F2C1 VA: 0x3D4F1C0
	|-Dictionary<int, int>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3D52C50 Offset: 0x3D52D51 VA: 0x3D52C50
	|-Dictionary<int, Int32Enum>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3D56790 Offset: 0x3D56891 VA: 0x3D56790
	|-Dictionary<int, long>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3D5A300 Offset: 0x3D5A401 VA: 0x3D5A300
	|-Dictionary<int, MapPos>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3D618A0 Offset: 0x3D619A1 VA: 0x3D618A0
	|-Dictionary<int, uint>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3D65330 Offset: 0x3D65431 VA: 0x3D65330
	|-Dictionary<int, AIThink.EnchantThink.SurroundingInfo>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3CC1C10 Offset: 0x3CC1D11 VA: 0x3CC1C10
	|-Dictionary<Int32Enum, bool>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3CC56A0 Offset: 0x3CC57A1 VA: 0x3CC56A0
	|-Dictionary<Int32Enum, int>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3CC9130 Offset: 0x3CC9231 VA: 0x3CC9130
	|-Dictionary<Int32Enum, Int32Enum>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3CCCCB0 Offset: 0x3CCCDB1 VA: 0x3CCCCB0
	|-Dictionary<Int32Enum, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3CD07A0 Offset: 0x3CD08A1 VA: 0x3CD07A0
	|-Dictionary<long, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3CD4270 Offset: 0x3CD4371 VA: 0x3CD4270
	|-Dictionary<MapPos, int>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3CD8160 Offset: 0x3CD8261 VA: 0x3CD8160
	|-Dictionary<object, AsyncOperationHandle<object>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3CDC080 Offset: 0x3CDC181 VA: 0x3CDC080
	|-Dictionary<object, AsyncOperationHandle>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3CDFCE0 Offset: 0x3CDFDE1 VA: 0x3CDFCE0
	|-Dictionary<object, bool>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3CE38D0 Offset: 0x3CE39D1 VA: 0x3CE38D0
	|-Dictionary<object, byte>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3CE74C0 Offset: 0x3CE75C1 VA: 0x3CE74C0
	|-Dictionary<object, int>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary<string, int>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3CEB0B0 Offset: 0x3CEB1B1 VA: 0x3CEB0B0
	|-Dictionary<object, Int32Enum>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3CEEC80 Offset: 0x3CEED81 VA: 0x3CEEC80
	|-Dictionary<object, IntPtr>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3CF2870 Offset: 0x3CF2971 VA: 0x3CF2870
	|-Dictionary<object, object>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary<string, GameUserRestartData.Growth>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3C8D600 Offset: 0x3C8D701 VA: 0x3C8D600
	|-Dictionary<object, Playable>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3C91200 Offset: 0x3C91301 VA: 0x3C91200
	|-Dictionary<object, ResourceLocator>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3C94DF0 Offset: 0x3C94EF1 VA: 0x3C94DF0
	|-Dictionary<object, float>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3C989E0 Offset: 0x3C98AE1 VA: 0x3C989E0
	|-Dictionary<object, ushort>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3C9C5D0 Offset: 0x3C9C6D1 VA: 0x3C9C5D0
	|-Dictionary<object, GameVariable.Value>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3CA0410 Offset: 0x3CA0511 VA: 0x3CA0410
	|-Dictionary<sbyte, DataStoreRatingInfo>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3CA4000 Offset: 0x3CA4101 VA: 0x3CA4000
	|-Dictionary<sbyte, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3D34E40 Offset: 0x3D34F41 VA: 0x3D34E40
	|-Dictionary<ushort, int>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3D388D0 Offset: 0x3D389D1 VA: 0x3D388D0
	|-Dictionary<uint, int>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3D3C450 Offset: 0x3D3C551 VA: 0x3D3C450
	|-Dictionary<uint, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3D403C0 Offset: 0x3D404C1 VA: 0x3D403C0
	|-Dictionary<ulong, Friend>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3D43F80 Offset: 0x3D44081 VA: 0x3D43F80
	|-Dictionary<ulong, Int32Enum>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3D47B00 Offset: 0x3D47C01 VA: 0x3D47B00
	|-Dictionary<ulong, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3D4B6E0 Offset: 0x3D4B7E1 VA: 0x3D4B6E0
	|-Dictionary<Vector3, int>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2629B30 Offset: 0x2629C31 VA: 0x2629B30
	|-Dictionary<XPathNodeRef, XPathNodeRef>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x262D6D0 Offset: 0x262D7D1 VA: 0x262D6D0
	|-Dictionary<TerrainUtility.TerrainMap.TileCoord, object>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 29
	private bool System.Collections.ICollection.get_IsSynchronized() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x251F150 Offset: 0x251F251 VA: 0x251F150
	|-Dictionary<ValueTuple<object, int>, object>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2522C60 Offset: 0x2522D61 VA: 0x2522C60
	|-Dictionary<byte, object>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3CA7B90 Offset: 0x3CA7C91 VA: 0x3CA7B90
	|-Dictionary<CancellationToken, object>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3CAB6A0 Offset: 0x3CAB7A1 VA: 0x3CAB6A0
	|-Dictionary<char, object>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3CAF1E0 Offset: 0x3CAF2E1 VA: 0x3CAF1E0
	|-Dictionary<Guid, object>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3CB2C20 Offset: 0x3CB2D21 VA: 0x3CB2C20
	|-Dictionary<int, bool>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3CB66E0 Offset: 0x3CB67E1 VA: 0x3CB66E0
	|-Dictionary<int, byte>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3D5DF10 Offset: 0x3D5E011 VA: 0x3D5DF10
	|-Dictionary<int, CalculatorCommand>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary<int, object>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary<int, TerrainUtility.TerrainMap>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3CBA1A0 Offset: 0x3CBA2A1 VA: 0x3CBA1A0
	|-Dictionary<int, char>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3CBE170 Offset: 0x3CBE271 VA: 0x3CBE170
	|-Dictionary<int, DiagnosticEvent>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3D4F240 Offset: 0x3D4F341 VA: 0x3D4F240
	|-Dictionary<int, int>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3D52CD0 Offset: 0x3D52DD1 VA: 0x3D52CD0
	|-Dictionary<int, Int32Enum>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3D56820 Offset: 0x3D56921 VA: 0x3D56820
	|-Dictionary<int, long>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3D5A380 Offset: 0x3D5A481 VA: 0x3D5A380
	|-Dictionary<int, MapPos>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3D61920 Offset: 0x3D61A21 VA: 0x3D61920
	|-Dictionary<int, uint>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3D653B0 Offset: 0x3D654B1 VA: 0x3D653B0
	|-Dictionary<int, AIThink.EnchantThink.SurroundingInfo>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3CC1C90 Offset: 0x3CC1D91 VA: 0x3CC1C90
	|-Dictionary<Int32Enum, bool>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3CC5720 Offset: 0x3CC5821 VA: 0x3CC5720
	|-Dictionary<Int32Enum, int>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3CC91B0 Offset: 0x3CC92B1 VA: 0x3CC91B0
	|-Dictionary<Int32Enum, Int32Enum>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3CCCD40 Offset: 0x3CCCE41 VA: 0x3CCCD40
	|-Dictionary<Int32Enum, object>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3CD0830 Offset: 0x3CD0931 VA: 0x3CD0830
	|-Dictionary<long, object>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3CD42F0 Offset: 0x3CD43F1 VA: 0x3CD42F0
	|-Dictionary<MapPos, int>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3CD8200 Offset: 0x3CD8301 VA: 0x3CD8200
	|-Dictionary<object, AsyncOperationHandle<object>>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3CDC120 Offset: 0x3CDC221 VA: 0x3CDC120
	|-Dictionary<object, AsyncOperationHandle>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3CDFD70 Offset: 0x3CDFE71 VA: 0x3CDFD70
	|-Dictionary<object, bool>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3CE3960 Offset: 0x3CE3A61 VA: 0x3CE3960
	|-Dictionary<object, byte>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3CE7550 Offset: 0x3CE7651 VA: 0x3CE7550
	|-Dictionary<object, int>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary<string, int>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3CEB140 Offset: 0x3CEB241 VA: 0x3CEB140
	|-Dictionary<object, Int32Enum>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3CEED10 Offset: 0x3CEEE11 VA: 0x3CEED10
	|-Dictionary<object, IntPtr>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3CF2900 Offset: 0x3CF2A01 VA: 0x3CF2900
	|-Dictionary<object, object>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary<string, GameUserRestartData.Growth>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3C8D690 Offset: 0x3C8D791 VA: 0x3C8D690
	|-Dictionary<object, Playable>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3C91290 Offset: 0x3C91391 VA: 0x3C91290
	|-Dictionary<object, ResourceLocator>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3C94E80 Offset: 0x3C94F81 VA: 0x3C94E80
	|-Dictionary<object, float>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3C98A70 Offset: 0x3C98B71 VA: 0x3C98A70
	|-Dictionary<object, ushort>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3C9C660 Offset: 0x3C9C761 VA: 0x3C9C660
	|-Dictionary<object, GameVariable.Value>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3CA04B0 Offset: 0x3CA05B1 VA: 0x3CA04B0
	|-Dictionary<sbyte, DataStoreRatingInfo>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3CA4090 Offset: 0x3CA4191 VA: 0x3CA4090
	|-Dictionary<sbyte, object>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3D34EC0 Offset: 0x3D34FC1 VA: 0x3D34EC0
	|-Dictionary<ushort, int>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3D38950 Offset: 0x3D38A51 VA: 0x3D38950
	|-Dictionary<uint, int>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3D3C4E0 Offset: 0x3D3C5E1 VA: 0x3D3C4E0
	|-Dictionary<uint, object>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3D40460 Offset: 0x3D40561 VA: 0x3D40460
	|-Dictionary<ulong, Friend>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3D44010 Offset: 0x3D44111 VA: 0x3D44010
	|-Dictionary<ulong, Int32Enum>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3D47B90 Offset: 0x3D47C91 VA: 0x3D47B90
	|-Dictionary<ulong, object>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3D4B770 Offset: 0x3D4B871 VA: 0x3D4B770
	|-Dictionary<Vector3, int>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2629BD0 Offset: 0x2629CD1 VA: 0x2629BD0
	|-Dictionary<XPathNodeRef, XPathNodeRef>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x262D760 Offset: 0x262D861 VA: 0x262D760
	|-Dictionary<TerrainUtility.TerrainMap.TileCoord, object>.System.Collections.ICollection.get_IsSynchronized
	*/

	// RVA: -1 Offset: -1 Slot: 28
	private object System.Collections.ICollection.get_SyncRoot() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x251F160 Offset: 0x251F261 VA: 0x251F160
	|-Dictionary<ValueTuple<object, int>, object>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2522C70 Offset: 0x2522D71 VA: 0x2522C70
	|-Dictionary<byte, object>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3CA7BA0 Offset: 0x3CA7CA1 VA: 0x3CA7BA0
	|-Dictionary<CancellationToken, object>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3CAB6B0 Offset: 0x3CAB7B1 VA: 0x3CAB6B0
	|-Dictionary<char, object>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3CAF1F0 Offset: 0x3CAF2F1 VA: 0x3CAF1F0
	|-Dictionary<Guid, object>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3CB2C30 Offset: 0x3CB2D31 VA: 0x3CB2C30
	|-Dictionary<int, bool>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3CB66F0 Offset: 0x3CB67F1 VA: 0x3CB66F0
	|-Dictionary<int, byte>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3D5DF20 Offset: 0x3D5E021 VA: 0x3D5DF20
	|-Dictionary<int, CalculatorCommand>.System.Collections.ICollection.get_SyncRoot
	|-Dictionary<int, object>.System.Collections.ICollection.get_SyncRoot
	|-Dictionary<int, TerrainUtility.TerrainMap>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3CBA1B0 Offset: 0x3CBA2B1 VA: 0x3CBA1B0
	|-Dictionary<int, char>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3CBE180 Offset: 0x3CBE281 VA: 0x3CBE180
	|-Dictionary<int, DiagnosticEvent>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3D4F250 Offset: 0x3D4F351 VA: 0x3D4F250
	|-Dictionary<int, int>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3D52CE0 Offset: 0x3D52DE1 VA: 0x3D52CE0
	|-Dictionary<int, Int32Enum>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3D56830 Offset: 0x3D56931 VA: 0x3D56830
	|-Dictionary<int, long>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3D5A390 Offset: 0x3D5A491 VA: 0x3D5A390
	|-Dictionary<int, MapPos>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3D61930 Offset: 0x3D61A31 VA: 0x3D61930
	|-Dictionary<int, uint>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3D653C0 Offset: 0x3D654C1 VA: 0x3D653C0
	|-Dictionary<int, AIThink.EnchantThink.SurroundingInfo>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3CC1CA0 Offset: 0x3CC1DA1 VA: 0x3CC1CA0
	|-Dictionary<Int32Enum, bool>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3CC5730 Offset: 0x3CC5831 VA: 0x3CC5730
	|-Dictionary<Int32Enum, int>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3CC91C0 Offset: 0x3CC92C1 VA: 0x3CC91C0
	|-Dictionary<Int32Enum, Int32Enum>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3CCCD50 Offset: 0x3CCCE51 VA: 0x3CCCD50
	|-Dictionary<Int32Enum, object>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3CD0840 Offset: 0x3CD0941 VA: 0x3CD0840
	|-Dictionary<long, object>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3CD4300 Offset: 0x3CD4401 VA: 0x3CD4300
	|-Dictionary<MapPos, int>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3CD8210 Offset: 0x3CD8311 VA: 0x3CD8210
	|-Dictionary<object, AsyncOperationHandle<object>>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3CDC130 Offset: 0x3CDC231 VA: 0x3CDC130
	|-Dictionary<object, AsyncOperationHandle>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3CDFD80 Offset: 0x3CDFE81 VA: 0x3CDFD80
	|-Dictionary<object, bool>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3CE3970 Offset: 0x3CE3A71 VA: 0x3CE3970
	|-Dictionary<object, byte>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3CE7560 Offset: 0x3CE7661 VA: 0x3CE7560
	|-Dictionary<object, int>.System.Collections.ICollection.get_SyncRoot
	|-Dictionary<string, int>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3CEB150 Offset: 0x3CEB251 VA: 0x3CEB150
	|-Dictionary<object, Int32Enum>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3CEED20 Offset: 0x3CEEE21 VA: 0x3CEED20
	|-Dictionary<object, IntPtr>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3CF2910 Offset: 0x3CF2A11 VA: 0x3CF2910
	|-Dictionary<object, object>.System.Collections.ICollection.get_SyncRoot
	|-Dictionary<string, GameUserRestartData.Growth>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3C8D6A0 Offset: 0x3C8D7A1 VA: 0x3C8D6A0
	|-Dictionary<object, Playable>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3C912A0 Offset: 0x3C913A1 VA: 0x3C912A0
	|-Dictionary<object, ResourceLocator>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3C94E90 Offset: 0x3C94F91 VA: 0x3C94E90
	|-Dictionary<object, float>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3C98A80 Offset: 0x3C98B81 VA: 0x3C98A80
	|-Dictionary<object, ushort>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3C9C670 Offset: 0x3C9C771 VA: 0x3C9C670
	|-Dictionary<object, GameVariable.Value>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3CA04C0 Offset: 0x3CA05C1 VA: 0x3CA04C0
	|-Dictionary<sbyte, DataStoreRatingInfo>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3CA40A0 Offset: 0x3CA41A1 VA: 0x3CA40A0
	|-Dictionary<sbyte, object>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3D34ED0 Offset: 0x3D34FD1 VA: 0x3D34ED0
	|-Dictionary<ushort, int>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3D38960 Offset: 0x3D38A61 VA: 0x3D38960
	|-Dictionary<uint, int>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3D3C4F0 Offset: 0x3D3C5F1 VA: 0x3D3C4F0
	|-Dictionary<uint, object>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3D40470 Offset: 0x3D40571 VA: 0x3D40470
	|-Dictionary<ulong, Friend>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3D44020 Offset: 0x3D44121 VA: 0x3D44020
	|-Dictionary<ulong, Int32Enum>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3D47BA0 Offset: 0x3D47CA1 VA: 0x3D47BA0
	|-Dictionary<ulong, object>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3D4B780 Offset: 0x3D4B881 VA: 0x3D4B780
	|-Dictionary<Vector3, int>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2629BE0 Offset: 0x2629CE1 VA: 0x2629BE0
	|-Dictionary<XPathNodeRef, XPathNodeRef>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x262D770 Offset: 0x262D871 VA: 0x262D770
	|-Dictionary<TerrainUtility.TerrainMap.TileCoord, object>.System.Collections.ICollection.get_SyncRoot
	*/

	// RVA: -1 Offset: -1 Slot: 23
	private bool System.Collections.IDictionary.get_IsFixedSize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x251F1F0 Offset: 0x251F2F1 VA: 0x251F1F0
	|-Dictionary<ValueTuple<object, int>, object>.System.Collections.IDictionary.get_IsFixedSize
	|
	|-RVA: 0x2522D00 Offset: 0x2522E01 VA: 0x2522D00
	|-Dictionary<byte, object>.System.Collections.IDictionary.get_IsFixedSize
	|
	|-RVA: 0x3CA7C30 Offset: 0x3CA7D31 VA: 0x3CA7C30
	|-Dictionary<CancellationToken, object>.System.Collections.IDictionary.get_IsFixedSize
	|
	|-RVA: 0x3CAB740 Offset: 0x3CAB841 VA: 0x3CAB740
	|-Dictionary<char, object>.System.Collections.IDictionary.get_IsFixedSize
	|
	|-RVA: 0x3CAF280 Offset: 0x3CAF381 VA: 0x3CAF280
	|-Dictionary<Guid, object>.System.Collections.IDictionary.get_IsFixedSize
	|
	|-RVA: 0x3CB2CC0 Offset: 0x3CB2DC1 VA: 0x3CB2CC0
	|-Dictionary<int, bool>.System.Collections.IDictionary.get_IsFixedSize
	|
	|-RVA: 0x3CB6780 Offset: 0x3CB6881 VA: 0x3CB6780
	|-Dictionary<int, byte>.System.Collections.IDictionary.get_IsFixedSize
	|
	|-RVA: 0x3D5DFB0 Offset: 0x3D5E0B1 VA: 0x3D5DFB0
	|-Dictionary<int, CalculatorCommand>.System.Collections.IDictionary.get_IsFixedSize
	|-Dictionary<int, object>.System.Collections.IDictionary.get_IsFixedSize
	|-Dictionary<int, TerrainUtility.TerrainMap>.System.Collections.IDictionary.get_IsFixedSize
	|
	|-RVA: 0x3CBA240 Offset: 0x3CBA341 VA: 0x3CBA240
	|-Dictionary<int, char>.System.Collections.IDictionary.get_IsFixedSize
	|
	|-RVA: 0x3CBE210 Offset: 0x3CBE311 VA: 0x3CBE210
	|-Dictionary<int, DiagnosticEvent>.System.Collections.IDictionary.get_IsFixedSize
	|
	|-RVA: 0x3D4F2E0 Offset: 0x3D4F3E1 VA: 0x3D4F2E0
	|-Dictionary<int, int>.System.Collections.IDictionary.get_IsFixedSize
	|
	|-RVA: 0x3D52D70 Offset: 0x3D52E71 VA: 0x3D52D70
	|-Dictionary<int, Int32Enum>.System.Collections.IDictionary.get_IsFixedSize
	|
	|-RVA: 0x3D568C0 Offset: 0x3D569C1 VA: 0x3D568C0
	|-Dictionary<int, long>.System.Collections.IDictionary.get_IsFixedSize
	|
	|-RVA: 0x3D5A420 Offset: 0x3D5A521 VA: 0x3D5A420
	|-Dictionary<int, MapPos>.System.Collections.IDictionary.get_IsFixedSize
	|
	|-RVA: 0x3D619C0 Offset: 0x3D61AC1 VA: 0x3D619C0
	|-Dictionary<int, uint>.System.Collections.IDictionary.get_IsFixedSize
	|
	|-RVA: 0x3D65450 Offset: 0x3D65551 VA: 0x3D65450
	|-Dictionary<int, AIThink.EnchantThink.SurroundingInfo>.System.Collections.IDictionary.get_IsFixedSize
	|
	|-RVA: 0x3CC1D30 Offset: 0x3CC1E31 VA: 0x3CC1D30
	|-Dictionary<Int32Enum, bool>.System.Collections.IDictionary.get_IsFixedSize
	|
	|-RVA: 0x3CC57C0 Offset: 0x3CC58C1 VA: 0x3CC57C0
	|-Dictionary<Int32Enum, int>.System.Collections.IDictionary.get_IsFixedSize
	|
	|-RVA: 0x3CC9250 Offset: 0x3CC9351 VA: 0x3CC9250
	|-Dictionary<Int32Enum, Int32Enum>.System.Collections.IDictionary.get_IsFixedSize
	|
	|-RVA: 0x3CCCDE0 Offset: 0x3CCCEE1 VA: 0x3CCCDE0
	|-Dictionary<Int32Enum, object>.System.Collections.IDictionary.get_IsFixedSize
	|
	|-RVA: 0x3CD08D0 Offset: 0x3CD09D1 VA: 0x3CD08D0
	|-Dictionary<long, object>.System.Collections.IDictionary.get_IsFixedSize
	|
	|-RVA: 0x3CD4390 Offset: 0x3CD4491 VA: 0x3CD4390
	|-Dictionary<MapPos, int>.System.Collections.IDictionary.get_IsFixedSize
	|
	|-RVA: 0x3CD82A0 Offset: 0x3CD83A1 VA: 0x3CD82A0
	|-Dictionary<object, AsyncOperationHandle<object>>.System.Collections.IDictionary.get_IsFixedSize
	|
	|-RVA: 0x3CDC1C0 Offset: 0x3CDC2C1 VA: 0x3CDC1C0
	|-Dictionary<object, AsyncOperationHandle>.System.Collections.IDictionary.get_IsFixedSize
	|
	|-RVA: 0x3CDFE10 Offset: 0x3CDFF11 VA: 0x3CDFE10
	|-Dictionary<object, bool>.System.Collections.IDictionary.get_IsFixedSize
	|
	|-RVA: 0x3CE3A00 Offset: 0x3CE3B01 VA: 0x3CE3A00
	|-Dictionary<object, byte>.System.Collections.IDictionary.get_IsFixedSize
	|
	|-RVA: 0x3CE75F0 Offset: 0x3CE76F1 VA: 0x3CE75F0
	|-Dictionary<object, int>.System.Collections.IDictionary.get_IsFixedSize
	|-Dictionary<string, int>.System.Collections.IDictionary.get_IsFixedSize
	|
	|-RVA: 0x3CEB1E0 Offset: 0x3CEB2E1 VA: 0x3CEB1E0
	|-Dictionary<object, Int32Enum>.System.Collections.IDictionary.get_IsFixedSize
	|
	|-RVA: 0x3CEEDB0 Offset: 0x3CEEEB1 VA: 0x3CEEDB0
	|-Dictionary<object, IntPtr>.System.Collections.IDictionary.get_IsFixedSize
	|
	|-RVA: 0x3CF29A0 Offset: 0x3CF2AA1 VA: 0x3CF29A0
	|-Dictionary<object, object>.System.Collections.IDictionary.get_IsFixedSize
	|-Dictionary<string, GameUserRestartData.Growth>.System.Collections.IDictionary.get_IsFixedSize
	|
	|-RVA: 0x3C8D730 Offset: 0x3C8D831 VA: 0x3C8D730
	|-Dictionary<object, Playable>.System.Collections.IDictionary.get_IsFixedSize
	|
	|-RVA: 0x3C91330 Offset: 0x3C91431 VA: 0x3C91330
	|-Dictionary<object, ResourceLocator>.System.Collections.IDictionary.get_IsFixedSize
	|
	|-RVA: 0x3C94F20 Offset: 0x3C95021 VA: 0x3C94F20
	|-Dictionary<object, float>.System.Collections.IDictionary.get_IsFixedSize
	|
	|-RVA: 0x3C98B10 Offset: 0x3C98C11 VA: 0x3C98B10
	|-Dictionary<object, ushort>.System.Collections.IDictionary.get_IsFixedSize
	|
	|-RVA: 0x3C9C700 Offset: 0x3C9C801 VA: 0x3C9C700
	|-Dictionary<object, GameVariable.Value>.System.Collections.IDictionary.get_IsFixedSize
	|
	|-RVA: 0x3CA0550 Offset: 0x3CA0651 VA: 0x3CA0550
	|-Dictionary<sbyte, DataStoreRatingInfo>.System.Collections.IDictionary.get_IsFixedSize
	|
	|-RVA: 0x3CA4130 Offset: 0x3CA4231 VA: 0x3CA4130
	|-Dictionary<sbyte, object>.System.Collections.IDictionary.get_IsFixedSize
	|
	|-RVA: 0x3D34F60 Offset: 0x3D35061 VA: 0x3D34F60
	|-Dictionary<ushort, int>.System.Collections.IDictionary.get_IsFixedSize
	|
	|-RVA: 0x3D389F0 Offset: 0x3D38AF1 VA: 0x3D389F0
	|-Dictionary<uint, int>.System.Collections.IDictionary.get_IsFixedSize
	|
	|-RVA: 0x3D3C580 Offset: 0x3D3C681 VA: 0x3D3C580
	|-Dictionary<uint, object>.System.Collections.IDictionary.get_IsFixedSize
	|
	|-RVA: 0x3D40500 Offset: 0x3D40601 VA: 0x3D40500
	|-Dictionary<ulong, Friend>.System.Collections.IDictionary.get_IsFixedSize
	|
	|-RVA: 0x3D440B0 Offset: 0x3D441B1 VA: 0x3D440B0
	|-Dictionary<ulong, Int32Enum>.System.Collections.IDictionary.get_IsFixedSize
	|
	|-RVA: 0x3D47C30 Offset: 0x3D47D31 VA: 0x3D47C30
	|-Dictionary<ulong, object>.System.Collections.IDictionary.get_IsFixedSize
	|
	|-RVA: 0x3D4B810 Offset: 0x3D4B911 VA: 0x3D4B810
	|-Dictionary<Vector3, int>.System.Collections.IDictionary.get_IsFixedSize
	|
	|-RVA: 0x2629C70 Offset: 0x2629D71 VA: 0x2629C70
	|-Dictionary<XPathNodeRef, XPathNodeRef>.System.Collections.IDictionary.get_IsFixedSize
	|
	|-RVA: 0x262D800 Offset: 0x262D901 VA: 0x262D800
	|-Dictionary<TerrainUtility.TerrainMap.TileCoord, object>.System.Collections.IDictionary.get_IsFixedSize
	*/

	// RVA: -1 Offset: -1 Slot: 22
	private bool System.Collections.IDictionary.get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x251F200 Offset: 0x251F301 VA: 0x251F200
	|-Dictionary<ValueTuple<object, int>, object>.System.Collections.IDictionary.get_IsReadOnly
	|
	|-RVA: 0x2522D10 Offset: 0x2522E11 VA: 0x2522D10
	|-Dictionary<byte, object>.System.Collections.IDictionary.get_IsReadOnly
	|
	|-RVA: 0x3CA7C40 Offset: 0x3CA7D41 VA: 0x3CA7C40
	|-Dictionary<CancellationToken, object>.System.Collections.IDictionary.get_IsReadOnly
	|
	|-RVA: 0x3CAB750 Offset: 0x3CAB851 VA: 0x3CAB750
	|-Dictionary<char, object>.System.Collections.IDictionary.get_IsReadOnly
	|
	|-RVA: 0x3CAF290 Offset: 0x3CAF391 VA: 0x3CAF290
	|-Dictionary<Guid, object>.System.Collections.IDictionary.get_IsReadOnly
	|
	|-RVA: 0x3CB2CD0 Offset: 0x3CB2DD1 VA: 0x3CB2CD0
	|-Dictionary<int, bool>.System.Collections.IDictionary.get_IsReadOnly
	|
	|-RVA: 0x3CB6790 Offset: 0x3CB6891 VA: 0x3CB6790
	|-Dictionary<int, byte>.System.Collections.IDictionary.get_IsReadOnly
	|
	|-RVA: 0x3D5DFC0 Offset: 0x3D5E0C1 VA: 0x3D5DFC0
	|-Dictionary<int, CalculatorCommand>.System.Collections.IDictionary.get_IsReadOnly
	|-Dictionary<int, object>.System.Collections.IDictionary.get_IsReadOnly
	|-Dictionary<int, TerrainUtility.TerrainMap>.System.Collections.IDictionary.get_IsReadOnly
	|
	|-RVA: 0x3CBA250 Offset: 0x3CBA351 VA: 0x3CBA250
	|-Dictionary<int, char>.System.Collections.IDictionary.get_IsReadOnly
	|
	|-RVA: 0x3CBE220 Offset: 0x3CBE321 VA: 0x3CBE220
	|-Dictionary<int, DiagnosticEvent>.System.Collections.IDictionary.get_IsReadOnly
	|
	|-RVA: 0x3D4F2F0 Offset: 0x3D4F3F1 VA: 0x3D4F2F0
	|-Dictionary<int, int>.System.Collections.IDictionary.get_IsReadOnly
	|
	|-RVA: 0x3D52D80 Offset: 0x3D52E81 VA: 0x3D52D80
	|-Dictionary<int, Int32Enum>.System.Collections.IDictionary.get_IsReadOnly
	|
	|-RVA: 0x3D568D0 Offset: 0x3D569D1 VA: 0x3D568D0
	|-Dictionary<int, long>.System.Collections.IDictionary.get_IsReadOnly
	|
	|-RVA: 0x3D5A430 Offset: 0x3D5A531 VA: 0x3D5A430
	|-Dictionary<int, MapPos>.System.Collections.IDictionary.get_IsReadOnly
	|
	|-RVA: 0x3D619D0 Offset: 0x3D61AD1 VA: 0x3D619D0
	|-Dictionary<int, uint>.System.Collections.IDictionary.get_IsReadOnly
	|
	|-RVA: 0x3D65460 Offset: 0x3D65561 VA: 0x3D65460
	|-Dictionary<int, AIThink.EnchantThink.SurroundingInfo>.System.Collections.IDictionary.get_IsReadOnly
	|
	|-RVA: 0x3CC1D40 Offset: 0x3CC1E41 VA: 0x3CC1D40
	|-Dictionary<Int32Enum, bool>.System.Collections.IDictionary.get_IsReadOnly
	|
	|-RVA: 0x3CC57D0 Offset: 0x3CC58D1 VA: 0x3CC57D0
	|-Dictionary<Int32Enum, int>.System.Collections.IDictionary.get_IsReadOnly
	|
	|-RVA: 0x3CC9260 Offset: 0x3CC9361 VA: 0x3CC9260
	|-Dictionary<Int32Enum, Int32Enum>.System.Collections.IDictionary.get_IsReadOnly
	|
	|-RVA: 0x3CCCDF0 Offset: 0x3CCCEF1 VA: 0x3CCCDF0
	|-Dictionary<Int32Enum, object>.System.Collections.IDictionary.get_IsReadOnly
	|
	|-RVA: 0x3CD08E0 Offset: 0x3CD09E1 VA: 0x3CD08E0
	|-Dictionary<long, object>.System.Collections.IDictionary.get_IsReadOnly
	|
	|-RVA: 0x3CD43A0 Offset: 0x3CD44A1 VA: 0x3CD43A0
	|-Dictionary<MapPos, int>.System.Collections.IDictionary.get_IsReadOnly
	|
	|-RVA: 0x3CD82B0 Offset: 0x3CD83B1 VA: 0x3CD82B0
	|-Dictionary<object, AsyncOperationHandle<object>>.System.Collections.IDictionary.get_IsReadOnly
	|
	|-RVA: 0x3CDC1D0 Offset: 0x3CDC2D1 VA: 0x3CDC1D0
	|-Dictionary<object, AsyncOperationHandle>.System.Collections.IDictionary.get_IsReadOnly
	|
	|-RVA: 0x3CDFE20 Offset: 0x3CDFF21 VA: 0x3CDFE20
	|-Dictionary<object, bool>.System.Collections.IDictionary.get_IsReadOnly
	|
	|-RVA: 0x3CE3A10 Offset: 0x3CE3B11 VA: 0x3CE3A10
	|-Dictionary<object, byte>.System.Collections.IDictionary.get_IsReadOnly
	|
	|-RVA: 0x3CE7600 Offset: 0x3CE7701 VA: 0x3CE7600
	|-Dictionary<object, int>.System.Collections.IDictionary.get_IsReadOnly
	|-Dictionary<string, int>.System.Collections.IDictionary.get_IsReadOnly
	|
	|-RVA: 0x3CEB1F0 Offset: 0x3CEB2F1 VA: 0x3CEB1F0
	|-Dictionary<object, Int32Enum>.System.Collections.IDictionary.get_IsReadOnly
	|
	|-RVA: 0x3CEEDC0 Offset: 0x3CEEEC1 VA: 0x3CEEDC0
	|-Dictionary<object, IntPtr>.System.Collections.IDictionary.get_IsReadOnly
	|
	|-RVA: 0x3CF29B0 Offset: 0x3CF2AB1 VA: 0x3CF29B0
	|-Dictionary<object, object>.System.Collections.IDictionary.get_IsReadOnly
	|-Dictionary<string, GameUserRestartData.Growth>.System.Collections.IDictionary.get_IsReadOnly
	|
	|-RVA: 0x3C8D740 Offset: 0x3C8D841 VA: 0x3C8D740
	|-Dictionary<object, Playable>.System.Collections.IDictionary.get_IsReadOnly
	|
	|-RVA: 0x3C91340 Offset: 0x3C91441 VA: 0x3C91340
	|-Dictionary<object, ResourceLocator>.System.Collections.IDictionary.get_IsReadOnly
	|
	|-RVA: 0x3C94F30 Offset: 0x3C95031 VA: 0x3C94F30
	|-Dictionary<object, float>.System.Collections.IDictionary.get_IsReadOnly
	|
	|-RVA: 0x3C98B20 Offset: 0x3C98C21 VA: 0x3C98B20
	|-Dictionary<object, ushort>.System.Collections.IDictionary.get_IsReadOnly
	|
	|-RVA: 0x3C9C710 Offset: 0x3C9C811 VA: 0x3C9C710
	|-Dictionary<object, GameVariable.Value>.System.Collections.IDictionary.get_IsReadOnly
	|
	|-RVA: 0x3CA0560 Offset: 0x3CA0661 VA: 0x3CA0560
	|-Dictionary<sbyte, DataStoreRatingInfo>.System.Collections.IDictionary.get_IsReadOnly
	|
	|-RVA: 0x3CA4140 Offset: 0x3CA4241 VA: 0x3CA4140
	|-Dictionary<sbyte, object>.System.Collections.IDictionary.get_IsReadOnly
	|
	|-RVA: 0x3D34F70 Offset: 0x3D35071 VA: 0x3D34F70
	|-Dictionary<ushort, int>.System.Collections.IDictionary.get_IsReadOnly
	|
	|-RVA: 0x3D38A00 Offset: 0x3D38B01 VA: 0x3D38A00
	|-Dictionary<uint, int>.System.Collections.IDictionary.get_IsReadOnly
	|
	|-RVA: 0x3D3C590 Offset: 0x3D3C691 VA: 0x3D3C590
	|-Dictionary<uint, object>.System.Collections.IDictionary.get_IsReadOnly
	|
	|-RVA: 0x3D40510 Offset: 0x3D40611 VA: 0x3D40510
	|-Dictionary<ulong, Friend>.System.Collections.IDictionary.get_IsReadOnly
	|
	|-RVA: 0x3D440C0 Offset: 0x3D441C1 VA: 0x3D440C0
	|-Dictionary<ulong, Int32Enum>.System.Collections.IDictionary.get_IsReadOnly
	|
	|-RVA: 0x3D47C40 Offset: 0x3D47D41 VA: 0x3D47C40
	|-Dictionary<ulong, object>.System.Collections.IDictionary.get_IsReadOnly
	|
	|-RVA: 0x3D4B820 Offset: 0x3D4B921 VA: 0x3D4B820
	|-Dictionary<Vector3, int>.System.Collections.IDictionary.get_IsReadOnly
	|
	|-RVA: 0x2629C80 Offset: 0x2629D81 VA: 0x2629C80
	|-Dictionary<XPathNodeRef, XPathNodeRef>.System.Collections.IDictionary.get_IsReadOnly
	|
	|-RVA: 0x262D810 Offset: 0x262D911 VA: 0x262D810
	|-Dictionary<TerrainUtility.TerrainMap.TileCoord, object>.System.Collections.IDictionary.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 18
	private ICollection System.Collections.IDictionary.get_Keys() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x251F210 Offset: 0x251F311 VA: 0x251F210
	|-Dictionary<ValueTuple<object, int>, object>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x2522D20 Offset: 0x2522E21 VA: 0x2522D20
	|-Dictionary<byte, object>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x3CA7C50 Offset: 0x3CA7D51 VA: 0x3CA7C50
	|-Dictionary<CancellationToken, object>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x3CAB760 Offset: 0x3CAB861 VA: 0x3CAB760
	|-Dictionary<char, object>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x3CAF2A0 Offset: 0x3CAF3A1 VA: 0x3CAF2A0
	|-Dictionary<Guid, object>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x3CB2CE0 Offset: 0x3CB2DE1 VA: 0x3CB2CE0
	|-Dictionary<int, bool>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x3CB67A0 Offset: 0x3CB68A1 VA: 0x3CB67A0
	|-Dictionary<int, byte>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x3D5DFD0 Offset: 0x3D5E0D1 VA: 0x3D5DFD0
	|-Dictionary<int, CalculatorCommand>.System.Collections.IDictionary.get_Keys
	|-Dictionary<int, object>.System.Collections.IDictionary.get_Keys
	|-Dictionary<int, TerrainUtility.TerrainMap>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x3CBA260 Offset: 0x3CBA361 VA: 0x3CBA260
	|-Dictionary<int, char>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x3CBE230 Offset: 0x3CBE331 VA: 0x3CBE230
	|-Dictionary<int, DiagnosticEvent>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x3D4F300 Offset: 0x3D4F401 VA: 0x3D4F300
	|-Dictionary<int, int>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x3D52D90 Offset: 0x3D52E91 VA: 0x3D52D90
	|-Dictionary<int, Int32Enum>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x3D568E0 Offset: 0x3D569E1 VA: 0x3D568E0
	|-Dictionary<int, long>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x3D5A440 Offset: 0x3D5A541 VA: 0x3D5A440
	|-Dictionary<int, MapPos>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x3D619E0 Offset: 0x3D61AE1 VA: 0x3D619E0
	|-Dictionary<int, uint>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x3D65470 Offset: 0x3D65571 VA: 0x3D65470
	|-Dictionary<int, AIThink.EnchantThink.SurroundingInfo>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x3CC1D50 Offset: 0x3CC1E51 VA: 0x3CC1D50
	|-Dictionary<Int32Enum, bool>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x3CC57E0 Offset: 0x3CC58E1 VA: 0x3CC57E0
	|-Dictionary<Int32Enum, int>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x3CC9270 Offset: 0x3CC9371 VA: 0x3CC9270
	|-Dictionary<Int32Enum, Int32Enum>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x3CCCE00 Offset: 0x3CCCF01 VA: 0x3CCCE00
	|-Dictionary<Int32Enum, object>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x3CD08F0 Offset: 0x3CD09F1 VA: 0x3CD08F0
	|-Dictionary<long, object>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x3CD43B0 Offset: 0x3CD44B1 VA: 0x3CD43B0
	|-Dictionary<MapPos, int>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x3CD82C0 Offset: 0x3CD83C1 VA: 0x3CD82C0
	|-Dictionary<object, AsyncOperationHandle<object>>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x3CDC1E0 Offset: 0x3CDC2E1 VA: 0x3CDC1E0
	|-Dictionary<object, AsyncOperationHandle>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x3CDFE30 Offset: 0x3CDFF31 VA: 0x3CDFE30
	|-Dictionary<object, bool>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x3CE3A20 Offset: 0x3CE3B21 VA: 0x3CE3A20
	|-Dictionary<object, byte>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x3CE7610 Offset: 0x3CE7711 VA: 0x3CE7610
	|-Dictionary<object, int>.System.Collections.IDictionary.get_Keys
	|-Dictionary<string, int>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x3CEB200 Offset: 0x3CEB301 VA: 0x3CEB200
	|-Dictionary<object, Int32Enum>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x3CEEDD0 Offset: 0x3CEEED1 VA: 0x3CEEDD0
	|-Dictionary<object, IntPtr>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x3CF29C0 Offset: 0x3CF2AC1 VA: 0x3CF29C0
	|-Dictionary<object, object>.System.Collections.IDictionary.get_Keys
	|-Dictionary<string, GameUserRestartData.Growth>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x3C8D750 Offset: 0x3C8D851 VA: 0x3C8D750
	|-Dictionary<object, Playable>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x3C91350 Offset: 0x3C91451 VA: 0x3C91350
	|-Dictionary<object, ResourceLocator>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x3C94F40 Offset: 0x3C95041 VA: 0x3C94F40
	|-Dictionary<object, float>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x3C98B30 Offset: 0x3C98C31 VA: 0x3C98B30
	|-Dictionary<object, ushort>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x3C9C720 Offset: 0x3C9C821 VA: 0x3C9C720
	|-Dictionary<object, GameVariable.Value>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x3CA0570 Offset: 0x3CA0671 VA: 0x3CA0570
	|-Dictionary<sbyte, DataStoreRatingInfo>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x3CA4150 Offset: 0x3CA4251 VA: 0x3CA4150
	|-Dictionary<sbyte, object>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x3D34F80 Offset: 0x3D35081 VA: 0x3D34F80
	|-Dictionary<ushort, int>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x3D38A10 Offset: 0x3D38B11 VA: 0x3D38A10
	|-Dictionary<uint, int>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x3D3C5A0 Offset: 0x3D3C6A1 VA: 0x3D3C5A0
	|-Dictionary<uint, object>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x3D40520 Offset: 0x3D40621 VA: 0x3D40520
	|-Dictionary<ulong, Friend>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x3D440D0 Offset: 0x3D441D1 VA: 0x3D440D0
	|-Dictionary<ulong, Int32Enum>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x3D47C50 Offset: 0x3D47D51 VA: 0x3D47C50
	|-Dictionary<ulong, object>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x3D4B830 Offset: 0x3D4B931 VA: 0x3D4B830
	|-Dictionary<Vector3, int>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x2629C90 Offset: 0x2629D91 VA: 0x2629C90
	|-Dictionary<XPathNodeRef, XPathNodeRef>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x262D820 Offset: 0x262D921 VA: 0x262D820
	|-Dictionary<TerrainUtility.TerrainMap.TileCoord, object>.System.Collections.IDictionary.get_Keys
	*/

	// RVA: -1 Offset: -1 Slot: 19
	private ICollection System.Collections.IDictionary.get_Values() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x251F230 Offset: 0x251F331 VA: 0x251F230
	|-Dictionary<ValueTuple<object, int>, object>.System.Collections.IDictionary.get_Values
	|
	|-RVA: 0x2522D40 Offset: 0x2522E41 VA: 0x2522D40
	|-Dictionary<byte, object>.System.Collections.IDictionary.get_Values
	|
	|-RVA: 0x3CA7C70 Offset: 0x3CA7D71 VA: 0x3CA7C70
	|-Dictionary<CancellationToken, object>.System.Collections.IDictionary.get_Values
	|
	|-RVA: 0x3CAB780 Offset: 0x3CAB881 VA: 0x3CAB780
	|-Dictionary<char, object>.System.Collections.IDictionary.get_Values
	|
	|-RVA: 0x3CAF2C0 Offset: 0x3CAF3C1 VA: 0x3CAF2C0
	|-Dictionary<Guid, object>.System.Collections.IDictionary.get_Values
	|
	|-RVA: 0x3CB2D00 Offset: 0x3CB2E01 VA: 0x3CB2D00
	|-Dictionary<int, bool>.System.Collections.IDictionary.get_Values
	|
	|-RVA: 0x3CB67C0 Offset: 0x3CB68C1 VA: 0x3CB67C0
	|-Dictionary<int, byte>.System.Collections.IDictionary.get_Values
	|
	|-RVA: 0x3D5DFF0 Offset: 0x3D5E0F1 VA: 0x3D5DFF0
	|-Dictionary<int, CalculatorCommand>.System.Collections.IDictionary.get_Values
	|-Dictionary<int, object>.System.Collections.IDictionary.get_Values
	|-Dictionary<int, TerrainUtility.TerrainMap>.System.Collections.IDictionary.get_Values
	|
	|-RVA: 0x3CBA280 Offset: 0x3CBA381 VA: 0x3CBA280
	|-Dictionary<int, char>.System.Collections.IDictionary.get_Values
	|
	|-RVA: 0x3CBE250 Offset: 0x3CBE351 VA: 0x3CBE250
	|-Dictionary<int, DiagnosticEvent>.System.Collections.IDictionary.get_Values
	|
	|-RVA: 0x3D4F320 Offset: 0x3D4F421 VA: 0x3D4F320
	|-Dictionary<int, int>.System.Collections.IDictionary.get_Values
	|
	|-RVA: 0x3D52DB0 Offset: 0x3D52EB1 VA: 0x3D52DB0
	|-Dictionary<int, Int32Enum>.System.Collections.IDictionary.get_Values
	|
	|-RVA: 0x3D56900 Offset: 0x3D56A01 VA: 0x3D56900
	|-Dictionary<int, long>.System.Collections.IDictionary.get_Values
	|
	|-RVA: 0x3D5A460 Offset: 0x3D5A561 VA: 0x3D5A460
	|-Dictionary<int, MapPos>.System.Collections.IDictionary.get_Values
	|
	|-RVA: 0x3D61A00 Offset: 0x3D61B01 VA: 0x3D61A00
	|-Dictionary<int, uint>.System.Collections.IDictionary.get_Values
	|
	|-RVA: 0x3D65490 Offset: 0x3D65591 VA: 0x3D65490
	|-Dictionary<int, AIThink.EnchantThink.SurroundingInfo>.System.Collections.IDictionary.get_Values
	|
	|-RVA: 0x3CC1D70 Offset: 0x3CC1E71 VA: 0x3CC1D70
	|-Dictionary<Int32Enum, bool>.System.Collections.IDictionary.get_Values
	|
	|-RVA: 0x3CC5800 Offset: 0x3CC5901 VA: 0x3CC5800
	|-Dictionary<Int32Enum, int>.System.Collections.IDictionary.get_Values
	|
	|-RVA: 0x3CC9290 Offset: 0x3CC9391 VA: 0x3CC9290
	|-Dictionary<Int32Enum, Int32Enum>.System.Collections.IDictionary.get_Values
	|
	|-RVA: 0x3CCCE20 Offset: 0x3CCCF21 VA: 0x3CCCE20
	|-Dictionary<Int32Enum, object>.System.Collections.IDictionary.get_Values
	|
	|-RVA: 0x3CD0910 Offset: 0x3CD0A11 VA: 0x3CD0910
	|-Dictionary<long, object>.System.Collections.IDictionary.get_Values
	|
	|-RVA: 0x3CD43D0 Offset: 0x3CD44D1 VA: 0x3CD43D0
	|-Dictionary<MapPos, int>.System.Collections.IDictionary.get_Values
	|
	|-RVA: 0x3CD82E0 Offset: 0x3CD83E1 VA: 0x3CD82E0
	|-Dictionary<object, AsyncOperationHandle<object>>.System.Collections.IDictionary.get_Values
	|
	|-RVA: 0x3CDC200 Offset: 0x3CDC301 VA: 0x3CDC200
	|-Dictionary<object, AsyncOperationHandle>.System.Collections.IDictionary.get_Values
	|
	|-RVA: 0x3CDFE50 Offset: 0x3CDFF51 VA: 0x3CDFE50
	|-Dictionary<object, bool>.System.Collections.IDictionary.get_Values
	|
	|-RVA: 0x3CE3A40 Offset: 0x3CE3B41 VA: 0x3CE3A40
	|-Dictionary<object, byte>.System.Collections.IDictionary.get_Values
	|
	|-RVA: 0x3CE7630 Offset: 0x3CE7731 VA: 0x3CE7630
	|-Dictionary<object, int>.System.Collections.IDictionary.get_Values
	|-Dictionary<string, int>.System.Collections.IDictionary.get_Values
	|
	|-RVA: 0x3CEB220 Offset: 0x3CEB321 VA: 0x3CEB220
	|-Dictionary<object, Int32Enum>.System.Collections.IDictionary.get_Values
	|
	|-RVA: 0x3CEEDF0 Offset: 0x3CEEEF1 VA: 0x3CEEDF0
	|-Dictionary<object, IntPtr>.System.Collections.IDictionary.get_Values
	|
	|-RVA: 0x3CF29E0 Offset: 0x3CF2AE1 VA: 0x3CF29E0
	|-Dictionary<object, object>.System.Collections.IDictionary.get_Values
	|-Dictionary<string, GameUserRestartData.Growth>.System.Collections.IDictionary.get_Values
	|
	|-RVA: 0x3C8D770 Offset: 0x3C8D871 VA: 0x3C8D770
	|-Dictionary<object, Playable>.System.Collections.IDictionary.get_Values
	|
	|-RVA: 0x3C91370 Offset: 0x3C91471 VA: 0x3C91370
	|-Dictionary<object, ResourceLocator>.System.Collections.IDictionary.get_Values
	|
	|-RVA: 0x3C94F60 Offset: 0x3C95061 VA: 0x3C94F60
	|-Dictionary<object, float>.System.Collections.IDictionary.get_Values
	|
	|-RVA: 0x3C98B50 Offset: 0x3C98C51 VA: 0x3C98B50
	|-Dictionary<object, ushort>.System.Collections.IDictionary.get_Values
	|
	|-RVA: 0x3C9C740 Offset: 0x3C9C841 VA: 0x3C9C740
	|-Dictionary<object, GameVariable.Value>.System.Collections.IDictionary.get_Values
	|
	|-RVA: 0x3CA0590 Offset: 0x3CA0691 VA: 0x3CA0590
	|-Dictionary<sbyte, DataStoreRatingInfo>.System.Collections.IDictionary.get_Values
	|
	|-RVA: 0x3CA4170 Offset: 0x3CA4271 VA: 0x3CA4170
	|-Dictionary<sbyte, object>.System.Collections.IDictionary.get_Values
	|
	|-RVA: 0x3D34FA0 Offset: 0x3D350A1 VA: 0x3D34FA0
	|-Dictionary<ushort, int>.System.Collections.IDictionary.get_Values
	|
	|-RVA: 0x3D38A30 Offset: 0x3D38B31 VA: 0x3D38A30
	|-Dictionary<uint, int>.System.Collections.IDictionary.get_Values
	|
	|-RVA: 0x3D3C5C0 Offset: 0x3D3C6C1 VA: 0x3D3C5C0
	|-Dictionary<uint, object>.System.Collections.IDictionary.get_Values
	|
	|-RVA: 0x3D40540 Offset: 0x3D40641 VA: 0x3D40540
	|-Dictionary<ulong, Friend>.System.Collections.IDictionary.get_Values
	|
	|-RVA: 0x3D440F0 Offset: 0x3D441F1 VA: 0x3D440F0
	|-Dictionary<ulong, Int32Enum>.System.Collections.IDictionary.get_Values
	|
	|-RVA: 0x3D47C70 Offset: 0x3D47D71 VA: 0x3D47C70
	|-Dictionary<ulong, object>.System.Collections.IDictionary.get_Values
	|
	|-RVA: 0x3D4B850 Offset: 0x3D4B951 VA: 0x3D4B850
	|-Dictionary<Vector3, int>.System.Collections.IDictionary.get_Values
	|
	|-RVA: 0x2629CB0 Offset: 0x2629DB1 VA: 0x2629CB0
	|-Dictionary<XPathNodeRef, XPathNodeRef>.System.Collections.IDictionary.get_Values
	|
	|-RVA: 0x262D840 Offset: 0x262D941 VA: 0x262D840
	|-Dictionary<TerrainUtility.TerrainMap.TileCoord, object>.System.Collections.IDictionary.get_Values
	*/

	// RVA: -1 Offset: -1 Slot: 16
	private object System.Collections.IDictionary.get_Item(object key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x251F250 Offset: 0x251F351 VA: 0x251F250
	|-Dictionary<ValueTuple<object, int>, object>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x2522D60 Offset: 0x2522E61 VA: 0x2522D60
	|-Dictionary<byte, object>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x3CA7C90 Offset: 0x3CA7D91 VA: 0x3CA7C90
	|-Dictionary<CancellationToken, object>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x3CAB7A0 Offset: 0x3CAB8A1 VA: 0x3CAB7A0
	|-Dictionary<char, object>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x3CAF2E0 Offset: 0x3CAF3E1 VA: 0x3CAF2E0
	|-Dictionary<Guid, object>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x3CB2D20 Offset: 0x3CB2E21 VA: 0x3CB2D20
	|-Dictionary<int, bool>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x3CB67E0 Offset: 0x3CB68E1 VA: 0x3CB67E0
	|-Dictionary<int, byte>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x3D5E010 Offset: 0x3D5E111 VA: 0x3D5E010
	|-Dictionary<int, CalculatorCommand>.System.Collections.IDictionary.get_Item
	|-Dictionary<int, object>.System.Collections.IDictionary.get_Item
	|-Dictionary<int, TerrainUtility.TerrainMap>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x3CBA2A0 Offset: 0x3CBA3A1 VA: 0x3CBA2A0
	|-Dictionary<int, char>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x3CBE270 Offset: 0x3CBE371 VA: 0x3CBE270
	|-Dictionary<int, DiagnosticEvent>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x3D4F340 Offset: 0x3D4F441 VA: 0x3D4F340
	|-Dictionary<int, int>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x3D52DD0 Offset: 0x3D52ED1 VA: 0x3D52DD0
	|-Dictionary<int, Int32Enum>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x3D56920 Offset: 0x3D56A21 VA: 0x3D56920
	|-Dictionary<int, long>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x3D5A480 Offset: 0x3D5A581 VA: 0x3D5A480
	|-Dictionary<int, MapPos>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x3D61A20 Offset: 0x3D61B21 VA: 0x3D61A20
	|-Dictionary<int, uint>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x3D654B0 Offset: 0x3D655B1 VA: 0x3D654B0
	|-Dictionary<int, AIThink.EnchantThink.SurroundingInfo>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x3CC1D90 Offset: 0x3CC1E91 VA: 0x3CC1D90
	|-Dictionary<Int32Enum, bool>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x3CC5820 Offset: 0x3CC5921 VA: 0x3CC5820
	|-Dictionary<Int32Enum, int>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x3CC92B0 Offset: 0x3CC93B1 VA: 0x3CC92B0
	|-Dictionary<Int32Enum, Int32Enum>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x3CCCE40 Offset: 0x3CCCF41 VA: 0x3CCCE40
	|-Dictionary<Int32Enum, object>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x3CD0930 Offset: 0x3CD0A31 VA: 0x3CD0930
	|-Dictionary<long, object>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x3CD43F0 Offset: 0x3CD44F1 VA: 0x3CD43F0
	|-Dictionary<MapPos, int>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x3CD8300 Offset: 0x3CD8401 VA: 0x3CD8300
	|-Dictionary<object, AsyncOperationHandle<object>>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x3CDC220 Offset: 0x3CDC321 VA: 0x3CDC220
	|-Dictionary<object, AsyncOperationHandle>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x3CDFE70 Offset: 0x3CDFF71 VA: 0x3CDFE70
	|-Dictionary<object, bool>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x3CE3A60 Offset: 0x3CE3B61 VA: 0x3CE3A60
	|-Dictionary<object, byte>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x3CE7650 Offset: 0x3CE7751 VA: 0x3CE7650
	|-Dictionary<object, int>.System.Collections.IDictionary.get_Item
	|-Dictionary<string, int>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x3CEB240 Offset: 0x3CEB341 VA: 0x3CEB240
	|-Dictionary<object, Int32Enum>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x3CEEE10 Offset: 0x3CEEF11 VA: 0x3CEEE10
	|-Dictionary<object, IntPtr>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x3CF2A00 Offset: 0x3CF2B01 VA: 0x3CF2A00
	|-Dictionary<object, object>.System.Collections.IDictionary.get_Item
	|-Dictionary<string, GameUserRestartData.Growth>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x3C8D790 Offset: 0x3C8D891 VA: 0x3C8D790
	|-Dictionary<object, Playable>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x3C91390 Offset: 0x3C91491 VA: 0x3C91390
	|-Dictionary<object, ResourceLocator>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x3C94F80 Offset: 0x3C95081 VA: 0x3C94F80
	|-Dictionary<object, float>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x3C98B70 Offset: 0x3C98C71 VA: 0x3C98B70
	|-Dictionary<object, ushort>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x3C9C760 Offset: 0x3C9C861 VA: 0x3C9C760
	|-Dictionary<object, GameVariable.Value>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x3CA05B0 Offset: 0x3CA06B1 VA: 0x3CA05B0
	|-Dictionary<sbyte, DataStoreRatingInfo>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x3CA4190 Offset: 0x3CA4291 VA: 0x3CA4190
	|-Dictionary<sbyte, object>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x3D34FC0 Offset: 0x3D350C1 VA: 0x3D34FC0
	|-Dictionary<ushort, int>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x3D38A50 Offset: 0x3D38B51 VA: 0x3D38A50
	|-Dictionary<uint, int>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x3D3C5E0 Offset: 0x3D3C6E1 VA: 0x3D3C5E0
	|-Dictionary<uint, object>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x3D40560 Offset: 0x3D40661 VA: 0x3D40560
	|-Dictionary<ulong, Friend>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x3D44110 Offset: 0x3D44211 VA: 0x3D44110
	|-Dictionary<ulong, Int32Enum>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x3D47C90 Offset: 0x3D47D91 VA: 0x3D47C90
	|-Dictionary<ulong, object>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x3D4B870 Offset: 0x3D4B971 VA: 0x3D4B870
	|-Dictionary<Vector3, int>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x2629CD0 Offset: 0x2629DD1 VA: 0x2629CD0
	|-Dictionary<XPathNodeRef, XPathNodeRef>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x262D860 Offset: 0x262D961 VA: 0x262D860
	|-Dictionary<TerrainUtility.TerrainMap.TileCoord, object>.System.Collections.IDictionary.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 17
	private void System.Collections.IDictionary.set_Item(object key, object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x251F340 Offset: 0x251F441 VA: 0x251F340
	|-Dictionary<ValueTuple<object, int>, object>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x2522E50 Offset: 0x2522F51 VA: 0x2522E50
	|-Dictionary<byte, object>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x3CA7D80 Offset: 0x3CA7E81 VA: 0x3CA7D80
	|-Dictionary<CancellationToken, object>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x3CAB890 Offset: 0x3CAB991 VA: 0x3CAB890
	|-Dictionary<char, object>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x3CAF3D0 Offset: 0x3CAF4D1 VA: 0x3CAF3D0
	|-Dictionary<Guid, object>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x3CB2E40 Offset: 0x3CB2F41 VA: 0x3CB2E40
	|-Dictionary<int, bool>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x3CB6900 Offset: 0x3CB6A01 VA: 0x3CB6900
	|-Dictionary<int, byte>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x3D5E100 Offset: 0x3D5E201 VA: 0x3D5E100
	|-Dictionary<int, CalculatorCommand>.System.Collections.IDictionary.set_Item
	|-Dictionary<int, object>.System.Collections.IDictionary.set_Item
	|-Dictionary<int, TerrainUtility.TerrainMap>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x3CBA3C0 Offset: 0x3CBA4C1 VA: 0x3CBA3C0
	|-Dictionary<int, char>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x3CBE3A0 Offset: 0x3CBE4A1 VA: 0x3CBE3A0
	|-Dictionary<int, DiagnosticEvent>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x3D4F460 Offset: 0x3D4F561 VA: 0x3D4F460
	|-Dictionary<int, int>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x3D52EF0 Offset: 0x3D52FF1 VA: 0x3D52EF0
	|-Dictionary<int, Int32Enum>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x3D56A40 Offset: 0x3D56B41 VA: 0x3D56A40
	|-Dictionary<int, long>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x3D5A5A0 Offset: 0x3D5A6A1 VA: 0x3D5A5A0
	|-Dictionary<int, MapPos>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x3D61B40 Offset: 0x3D61C41 VA: 0x3D61B40
	|-Dictionary<int, uint>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x3D655D0 Offset: 0x3D656D1 VA: 0x3D655D0
	|-Dictionary<int, AIThink.EnchantThink.SurroundingInfo>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x3CC1EB0 Offset: 0x3CC1FB1 VA: 0x3CC1EB0
	|-Dictionary<Int32Enum, bool>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x3CC5940 Offset: 0x3CC5A41 VA: 0x3CC5940
	|-Dictionary<Int32Enum, int>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x3CC93D0 Offset: 0x3CC94D1 VA: 0x3CC93D0
	|-Dictionary<Int32Enum, Int32Enum>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x3CCCF30 Offset: 0x3CCD031 VA: 0x3CCCF30
	|-Dictionary<Int32Enum, object>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x3CD0A20 Offset: 0x3CD0B21 VA: 0x3CD0A20
	|-Dictionary<long, object>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x3CD4510 Offset: 0x3CD4611 VA: 0x3CD4510
	|-Dictionary<MapPos, int>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x3CD8420 Offset: 0x3CD8521 VA: 0x3CD8420
	|-Dictionary<object, AsyncOperationHandle<object>>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x3CDC340 Offset: 0x3CDC441 VA: 0x3CDC340
	|-Dictionary<object, AsyncOperationHandle>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x3CDFF80 Offset: 0x3CE0081 VA: 0x3CDFF80
	|-Dictionary<object, bool>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x3CE3B70 Offset: 0x3CE3C71 VA: 0x3CE3B70
	|-Dictionary<object, byte>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x3CE7760 Offset: 0x3CE7861 VA: 0x3CE7760
	|-Dictionary<object, int>.System.Collections.IDictionary.set_Item
	|-Dictionary<string, int>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x3CEB350 Offset: 0x3CEB451 VA: 0x3CEB350
	|-Dictionary<object, Int32Enum>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x3CEEF20 Offset: 0x3CEF021 VA: 0x3CEEF20
	|-Dictionary<object, IntPtr>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x3CF2AF0 Offset: 0x3CF2BF1 VA: 0x3CF2AF0
	|-Dictionary<object, object>.System.Collections.IDictionary.set_Item
	|-Dictionary<string, GameUserRestartData.Growth>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x3C8D8B0 Offset: 0x3C8D9B1 VA: 0x3C8D8B0
	|-Dictionary<object, Playable>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x3C914B0 Offset: 0x3C915B1 VA: 0x3C914B0
	|-Dictionary<object, ResourceLocator>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x3C95090 Offset: 0x3C95191 VA: 0x3C95090
	|-Dictionary<object, float>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x3C98C80 Offset: 0x3C98D81 VA: 0x3C98C80
	|-Dictionary<object, ushort>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x3C9C880 Offset: 0x3C9C981 VA: 0x3C9C880
	|-Dictionary<object, GameVariable.Value>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x3CA06E0 Offset: 0x3CA07E1 VA: 0x3CA06E0
	|-Dictionary<sbyte, DataStoreRatingInfo>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x3CA4280 Offset: 0x3CA4381 VA: 0x3CA4280
	|-Dictionary<sbyte, object>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x3D350E0 Offset: 0x3D351E1 VA: 0x3D350E0
	|-Dictionary<ushort, int>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x3D38B70 Offset: 0x3D38C71 VA: 0x3D38B70
	|-Dictionary<uint, int>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x3D3C6D0 Offset: 0x3D3C7D1 VA: 0x3D3C6D0
	|-Dictionary<uint, object>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x3D40690 Offset: 0x3D40791 VA: 0x3D40690
	|-Dictionary<ulong, Friend>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x3D44230 Offset: 0x3D44331 VA: 0x3D44230
	|-Dictionary<ulong, Int32Enum>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x3D47D80 Offset: 0x3D47E81 VA: 0x3D47D80
	|-Dictionary<ulong, object>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x3D4B990 Offset: 0x3D4BA91 VA: 0x3D4B990
	|-Dictionary<Vector3, int>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x2629DF0 Offset: 0x2629EF1 VA: 0x2629DF0
	|-Dictionary<XPathNodeRef, XPathNodeRef>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x262D950 Offset: 0x262DA51 VA: 0x262D950
	|-Dictionary<TerrainUtility.TerrainMap.TileCoord, object>.System.Collections.IDictionary.set_Item
	*/

	// RVA: -1 Offset: -1
	private static bool IsCompatibleKey(object key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x251F750 Offset: 0x251F851 VA: 0x251F750
	|-Dictionary<ValueTuple<object, int>, object>.IsCompatibleKey
	|
	|-RVA: 0x2523260 Offset: 0x2523361 VA: 0x2523260
	|-Dictionary<byte, object>.IsCompatibleKey
	|
	|-RVA: 0x3CA8190 Offset: 0x3CA8291 VA: 0x3CA8190
	|-Dictionary<CancellationToken, object>.IsCompatibleKey
	|
	|-RVA: 0x3CABCA0 Offset: 0x3CABDA1 VA: 0x3CABCA0
	|-Dictionary<char, object>.IsCompatibleKey
	|
	|-RVA: 0x3CAF7E0 Offset: 0x3CAF8E1 VA: 0x3CAF7E0
	|-Dictionary<Guid, object>.IsCompatibleKey
	|
	|-RVA: 0x3CB3280 Offset: 0x3CB3381 VA: 0x3CB3280
	|-Dictionary<int, bool>.IsCompatibleKey
	|
	|-RVA: 0x3CB6D40 Offset: 0x3CB6E41 VA: 0x3CB6D40
	|-Dictionary<int, byte>.IsCompatibleKey
	|
	|-RVA: 0x3CBA800 Offset: 0x3CBA901 VA: 0x3CBA800
	|-Dictionary<int, char>.IsCompatibleKey
	|
	|-RVA: 0x3CBE7F0 Offset: 0x3CBE8F1 VA: 0x3CBE7F0
	|-Dictionary<int, DiagnosticEvent>.IsCompatibleKey
	|
	|-RVA: 0x3D4F8A0 Offset: 0x3D4F9A1 VA: 0x3D4F8A0
	|-Dictionary<int, int>.IsCompatibleKey
	|
	|-RVA: 0x3D53330 Offset: 0x3D53431 VA: 0x3D53330
	|-Dictionary<int, Int32Enum>.IsCompatibleKey
	|
	|-RVA: 0x3D56E80 Offset: 0x3D56F81 VA: 0x3D56E80
	|-Dictionary<int, long>.IsCompatibleKey
	|
	|-RVA: 0x3D5A9E0 Offset: 0x3D5AAE1 VA: 0x3D5A9E0
	|-Dictionary<int, MapPos>.IsCompatibleKey
	|
	|-RVA: 0x3D5E510 Offset: 0x3D5E611 VA: 0x3D5E510
	|-Dictionary<int, object>.IsCompatibleKey
	|
	|-RVA: 0x3D61F80 Offset: 0x3D62081 VA: 0x3D61F80
	|-Dictionary<int, uint>.IsCompatibleKey
	|
	|-RVA: 0x3D65A10 Offset: 0x3D65B11 VA: 0x3D65A10
	|-Dictionary<int, AIThink.EnchantThink.SurroundingInfo>.IsCompatibleKey
	|
	|-RVA: 0x3CC22F0 Offset: 0x3CC23F1 VA: 0x3CC22F0
	|-Dictionary<Int32Enum, bool>.IsCompatibleKey
	|
	|-RVA: 0x3CC5D80 Offset: 0x3CC5E81 VA: 0x3CC5D80
	|-Dictionary<Int32Enum, int>.IsCompatibleKey
	|
	|-RVA: 0x3CC9810 Offset: 0x3CC9911 VA: 0x3CC9810
	|-Dictionary<Int32Enum, Int32Enum>.IsCompatibleKey
	|
	|-RVA: 0x3CCD340 Offset: 0x3CCD441 VA: 0x3CCD340
	|-Dictionary<Int32Enum, object>.IsCompatibleKey
	|
	|-RVA: 0x3CD0E30 Offset: 0x3CD0F31 VA: 0x3CD0E30
	|-Dictionary<long, object>.IsCompatibleKey
	|
	|-RVA: 0x3CD4950 Offset: 0x3CD4A51 VA: 0x3CD4950
	|-Dictionary<MapPos, int>.IsCompatibleKey
	|
	|-RVA: 0x3CD8860 Offset: 0x3CD8961 VA: 0x3CD8860
	|-Dictionary<object, AsyncOperationHandle<object>>.IsCompatibleKey
	|
	|-RVA: 0x3CDC780 Offset: 0x3CDC881 VA: 0x3CDC780
	|-Dictionary<object, AsyncOperationHandle>.IsCompatibleKey
	|
	|-RVA: 0x3CE03B0 Offset: 0x3CE04B1 VA: 0x3CE03B0
	|-Dictionary<object, bool>.IsCompatibleKey
	|
	|-RVA: 0x3CE3FA0 Offset: 0x3CE40A1 VA: 0x3CE3FA0
	|-Dictionary<object, byte>.IsCompatibleKey
	|
	|-RVA: 0x3CE7B90 Offset: 0x3CE7C91 VA: 0x3CE7B90
	|-Dictionary<object, int>.IsCompatibleKey
	|
	|-RVA: 0x3CEB780 Offset: 0x3CEB881 VA: 0x3CEB780
	|-Dictionary<object, Int32Enum>.IsCompatibleKey
	|
	|-RVA: 0x3CEF350 Offset: 0x3CEF451 VA: 0x3CEF350
	|-Dictionary<object, IntPtr>.IsCompatibleKey
	|
	|-RVA: 0x3CF2EF0 Offset: 0x3CF2FF1 VA: 0x3CF2EF0
	|-Dictionary<object, object>.IsCompatibleKey
	|
	|-RVA: 0x3C8DCE0 Offset: 0x3C8DDE1 VA: 0x3C8DCE0
	|-Dictionary<object, Playable>.IsCompatibleKey
	|
	|-RVA: 0x3C918E0 Offset: 0x3C919E1 VA: 0x3C918E0
	|-Dictionary<object, ResourceLocator>.IsCompatibleKey
	|
	|-RVA: 0x3C954C0 Offset: 0x3C955C1 VA: 0x3C954C0
	|-Dictionary<object, float>.IsCompatibleKey
	|
	|-RVA: 0x3C990B0 Offset: 0x3C991B1 VA: 0x3C990B0
	|-Dictionary<object, ushort>.IsCompatibleKey
	|
	|-RVA: 0x3C9CCB0 Offset: 0x3C9CDB1 VA: 0x3C9CCB0
	|-Dictionary<object, GameVariable.Value>.IsCompatibleKey
	|
	|-RVA: 0x3CA0B30 Offset: 0x3CA0C31 VA: 0x3CA0B30
	|-Dictionary<sbyte, DataStoreRatingInfo>.IsCompatibleKey
	|
	|-RVA: 0x3CA4690 Offset: 0x3CA4791 VA: 0x3CA4690
	|-Dictionary<sbyte, object>.IsCompatibleKey
	|
	|-RVA: 0x3D35520 Offset: 0x3D35621 VA: 0x3D35520
	|-Dictionary<ushort, int>.IsCompatibleKey
	|
	|-RVA: 0x3D38FB0 Offset: 0x3D390B1 VA: 0x3D38FB0
	|-Dictionary<uint, int>.IsCompatibleKey
	|
	|-RVA: 0x3D3CAE0 Offset: 0x3D3CBE1 VA: 0x3D3CAE0
	|-Dictionary<uint, object>.IsCompatibleKey
	|
	|-RVA: 0x3D40AE0 Offset: 0x3D40BE1 VA: 0x3D40AE0
	|-Dictionary<ulong, Friend>.IsCompatibleKey
	|
	|-RVA: 0x3D44670 Offset: 0x3D44771 VA: 0x3D44670
	|-Dictionary<ulong, Int32Enum>.IsCompatibleKey
	|
	|-RVA: 0x3D48190 Offset: 0x3D48291 VA: 0x3D48190
	|-Dictionary<ulong, object>.IsCompatibleKey
	|
	|-RVA: 0x3D4BDE0 Offset: 0x3D4BEE1 VA: 0x3D4BDE0
	|-Dictionary<Vector3, int>.IsCompatibleKey
	|
	|-RVA: 0x262A230 Offset: 0x262A331 VA: 0x262A230
	|-Dictionary<XPathNodeRef, XPathNodeRef>.IsCompatibleKey
	|
	|-RVA: 0x262DD60 Offset: 0x262DE61 VA: 0x262DD60
	|-Dictionary<TerrainUtility.TerrainMap.TileCoord, object>.IsCompatibleKey
	*/

	// RVA: -1 Offset: -1 Slot: 21
	private void System.Collections.IDictionary.Add(object key, object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x251F800 Offset: 0x251F901 VA: 0x251F800
	|-Dictionary<ValueTuple<object, int>, object>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x2523310 Offset: 0x2523411 VA: 0x2523310
	|-Dictionary<byte, object>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x3CA8240 Offset: 0x3CA8341 VA: 0x3CA8240
	|-Dictionary<CancellationToken, object>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x3CABD50 Offset: 0x3CABE51 VA: 0x3CABD50
	|-Dictionary<char, object>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x3CAF890 Offset: 0x3CAF991 VA: 0x3CAF890
	|-Dictionary<Guid, object>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x3CB3330 Offset: 0x3CB3431 VA: 0x3CB3330
	|-Dictionary<int, bool>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x3CB6DF0 Offset: 0x3CB6EF1 VA: 0x3CB6DF0
	|-Dictionary<int, byte>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x3D5E5C0 Offset: 0x3D5E6C1 VA: 0x3D5E5C0
	|-Dictionary<int, CalculatorCommand>.System.Collections.IDictionary.Add
	|-Dictionary<int, object>.System.Collections.IDictionary.Add
	|-Dictionary<int, TerrainUtility.TerrainMap>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x3CBA8B0 Offset: 0x3CBA9B1 VA: 0x3CBA8B0
	|-Dictionary<int, char>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x3CBE8A0 Offset: 0x3CBE9A1 VA: 0x3CBE8A0
	|-Dictionary<int, DiagnosticEvent>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x3D4F950 Offset: 0x3D4FA51 VA: 0x3D4F950
	|-Dictionary<int, int>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x3D533E0 Offset: 0x3D534E1 VA: 0x3D533E0
	|-Dictionary<int, Int32Enum>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x3D56F30 Offset: 0x3D57031 VA: 0x3D56F30
	|-Dictionary<int, long>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x3D5AA90 Offset: 0x3D5AB91 VA: 0x3D5AA90
	|-Dictionary<int, MapPos>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x3D62030 Offset: 0x3D62131 VA: 0x3D62030
	|-Dictionary<int, uint>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x3D65AC0 Offset: 0x3D65BC1 VA: 0x3D65AC0
	|-Dictionary<int, AIThink.EnchantThink.SurroundingInfo>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x3CC23A0 Offset: 0x3CC24A1 VA: 0x3CC23A0
	|-Dictionary<Int32Enum, bool>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x3CC5E30 Offset: 0x3CC5F31 VA: 0x3CC5E30
	|-Dictionary<Int32Enum, int>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x3CC98C0 Offset: 0x3CC99C1 VA: 0x3CC98C0
	|-Dictionary<Int32Enum, Int32Enum>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x3CCD3F0 Offset: 0x3CCD4F1 VA: 0x3CCD3F0
	|-Dictionary<Int32Enum, object>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x3CD0EE0 Offset: 0x3CD0FE1 VA: 0x3CD0EE0
	|-Dictionary<long, object>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x3CD4A00 Offset: 0x3CD4B01 VA: 0x3CD4A00
	|-Dictionary<MapPos, int>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x3CD8910 Offset: 0x3CD8A11 VA: 0x3CD8910
	|-Dictionary<object, AsyncOperationHandle<object>>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x3CDC830 Offset: 0x3CDC931 VA: 0x3CDC830
	|-Dictionary<object, AsyncOperationHandle>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x3CE0460 Offset: 0x3CE0561 VA: 0x3CE0460
	|-Dictionary<object, bool>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x3CE4050 Offset: 0x3CE4151 VA: 0x3CE4050
	|-Dictionary<object, byte>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x3CE7C40 Offset: 0x3CE7D41 VA: 0x3CE7C40
	|-Dictionary<object, int>.System.Collections.IDictionary.Add
	|-Dictionary<string, int>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x3CEB830 Offset: 0x3CEB931 VA: 0x3CEB830
	|-Dictionary<object, Int32Enum>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x3CEF400 Offset: 0x3CEF501 VA: 0x3CEF400
	|-Dictionary<object, IntPtr>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x3CF2FA0 Offset: 0x3CF30A1 VA: 0x3CF2FA0
	|-Dictionary<object, object>.System.Collections.IDictionary.Add
	|-Dictionary<string, GameUserRestartData.Growth>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x3C8DD90 Offset: 0x3C8DE91 VA: 0x3C8DD90
	|-Dictionary<object, Playable>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x3C91990 Offset: 0x3C91A91 VA: 0x3C91990
	|-Dictionary<object, ResourceLocator>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x3C95570 Offset: 0x3C95671 VA: 0x3C95570
	|-Dictionary<object, float>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x3C99160 Offset: 0x3C99261 VA: 0x3C99160
	|-Dictionary<object, ushort>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x3C9CD60 Offset: 0x3C9CE61 VA: 0x3C9CD60
	|-Dictionary<object, GameVariable.Value>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x3CA0BE0 Offset: 0x3CA0CE1 VA: 0x3CA0BE0
	|-Dictionary<sbyte, DataStoreRatingInfo>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x3CA4740 Offset: 0x3CA4841 VA: 0x3CA4740
	|-Dictionary<sbyte, object>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x3D355D0 Offset: 0x3D356D1 VA: 0x3D355D0
	|-Dictionary<ushort, int>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x3D39060 Offset: 0x3D39161 VA: 0x3D39060
	|-Dictionary<uint, int>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x3D3CB90 Offset: 0x3D3CC91 VA: 0x3D3CB90
	|-Dictionary<uint, object>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x3D40B90 Offset: 0x3D40C91 VA: 0x3D40B90
	|-Dictionary<ulong, Friend>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x3D44720 Offset: 0x3D44821 VA: 0x3D44720
	|-Dictionary<ulong, Int32Enum>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x3D48240 Offset: 0x3D48341 VA: 0x3D48240
	|-Dictionary<ulong, object>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x3D4BE90 Offset: 0x3D4BF91 VA: 0x3D4BE90
	|-Dictionary<Vector3, int>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x262A2E0 Offset: 0x262A3E1 VA: 0x262A2E0
	|-Dictionary<XPathNodeRef, XPathNodeRef>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x262DE10 Offset: 0x262DF11 VA: 0x262DE10
	|-Dictionary<TerrainUtility.TerrainMap.TileCoord, object>.System.Collections.IDictionary.Add
	*/

	// RVA: -1 Offset: -1 Slot: 20
	private bool System.Collections.IDictionary.Contains(object key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x251FC10 Offset: 0x251FD11 VA: 0x251FC10
	|-Dictionary<ValueTuple<object, int>, object>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x2523720 Offset: 0x2523821 VA: 0x2523720
	|-Dictionary<byte, object>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x3CA8650 Offset: 0x3CA8751 VA: 0x3CA8650
	|-Dictionary<CancellationToken, object>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x3CAC160 Offset: 0x3CAC261 VA: 0x3CAC160
	|-Dictionary<char, object>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x3CAFCA0 Offset: 0x3CAFDA1 VA: 0x3CAFCA0
	|-Dictionary<Guid, object>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x3CB3770 Offset: 0x3CB3871 VA: 0x3CB3770
	|-Dictionary<int, bool>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x3CB7230 Offset: 0x3CB7331 VA: 0x3CB7230
	|-Dictionary<int, byte>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x3D5E9D0 Offset: 0x3D5EAD1 VA: 0x3D5E9D0
	|-Dictionary<int, CalculatorCommand>.System.Collections.IDictionary.Contains
	|-Dictionary<int, object>.System.Collections.IDictionary.Contains
	|-Dictionary<int, TerrainUtility.TerrainMap>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x3CBACF0 Offset: 0x3CBADF1 VA: 0x3CBACF0
	|-Dictionary<int, char>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x3CBECF0 Offset: 0x3CBEDF1 VA: 0x3CBECF0
	|-Dictionary<int, DiagnosticEvent>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x3D4FD90 Offset: 0x3D4FE91 VA: 0x3D4FD90
	|-Dictionary<int, int>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x3D53820 Offset: 0x3D53921 VA: 0x3D53820
	|-Dictionary<int, Int32Enum>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x3D57370 Offset: 0x3D57471 VA: 0x3D57370
	|-Dictionary<int, long>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x3D5AED0 Offset: 0x3D5AFD1 VA: 0x3D5AED0
	|-Dictionary<int, MapPos>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x3D62470 Offset: 0x3D62571 VA: 0x3D62470
	|-Dictionary<int, uint>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x3D65F00 Offset: 0x3D66001 VA: 0x3D65F00
	|-Dictionary<int, AIThink.EnchantThink.SurroundingInfo>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x3CC27E0 Offset: 0x3CC28E1 VA: 0x3CC27E0
	|-Dictionary<Int32Enum, bool>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x3CC6270 Offset: 0x3CC6371 VA: 0x3CC6270
	|-Dictionary<Int32Enum, int>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x3CC9D00 Offset: 0x3CC9E01 VA: 0x3CC9D00
	|-Dictionary<Int32Enum, Int32Enum>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x3CCD800 Offset: 0x3CCD901 VA: 0x3CCD800
	|-Dictionary<Int32Enum, object>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x3CD12F0 Offset: 0x3CD13F1 VA: 0x3CD12F0
	|-Dictionary<long, object>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x3CD4E40 Offset: 0x3CD4F41 VA: 0x3CD4E40
	|-Dictionary<MapPos, int>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x3CD8D50 Offset: 0x3CD8E51 VA: 0x3CD8D50
	|-Dictionary<object, AsyncOperationHandle<object>>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x3CDCC70 Offset: 0x3CDCD71 VA: 0x3CDCC70
	|-Dictionary<object, AsyncOperationHandle>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x3CE0890 Offset: 0x3CE0991 VA: 0x3CE0890
	|-Dictionary<object, bool>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x3CE4480 Offset: 0x3CE4581 VA: 0x3CE4480
	|-Dictionary<object, byte>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x3CE8070 Offset: 0x3CE8171 VA: 0x3CE8070
	|-Dictionary<object, int>.System.Collections.IDictionary.Contains
	|-Dictionary<string, int>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x3CEBC60 Offset: 0x3CEBD61 VA: 0x3CEBC60
	|-Dictionary<object, Int32Enum>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x3CEF830 Offset: 0x3CEF931 VA: 0x3CEF830
	|-Dictionary<object, IntPtr>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x3CF33A0 Offset: 0x3CF34A1 VA: 0x3CF33A0
	|-Dictionary<object, object>.System.Collections.IDictionary.Contains
	|-Dictionary<string, GameUserRestartData.Growth>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x3C8E1C0 Offset: 0x3C8E2C1 VA: 0x3C8E1C0
	|-Dictionary<object, Playable>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x3C91DC0 Offset: 0x3C91EC1 VA: 0x3C91DC0
	|-Dictionary<object, ResourceLocator>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x3C959A0 Offset: 0x3C95AA1 VA: 0x3C959A0
	|-Dictionary<object, float>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x3C99590 Offset: 0x3C99691 VA: 0x3C99590
	|-Dictionary<object, ushort>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x3C9D190 Offset: 0x3C9D291 VA: 0x3C9D190
	|-Dictionary<object, GameVariable.Value>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x3CA1030 Offset: 0x3CA1131 VA: 0x3CA1030
	|-Dictionary<sbyte, DataStoreRatingInfo>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x3CA4B50 Offset: 0x3CA4C51 VA: 0x3CA4B50
	|-Dictionary<sbyte, object>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x3D35A10 Offset: 0x3D35B11 VA: 0x3D35A10
	|-Dictionary<ushort, int>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x3D394A0 Offset: 0x3D395A1 VA: 0x3D394A0
	|-Dictionary<uint, int>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x3D3CFA0 Offset: 0x3D3D0A1 VA: 0x3D3CFA0
	|-Dictionary<uint, object>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x3D40FE0 Offset: 0x3D410E1 VA: 0x3D40FE0
	|-Dictionary<ulong, Friend>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x3D44B60 Offset: 0x3D44C61 VA: 0x3D44B60
	|-Dictionary<ulong, Int32Enum>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x3D48650 Offset: 0x3D48751 VA: 0x3D48650
	|-Dictionary<ulong, object>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x3D4C2E0 Offset: 0x3D4C3E1 VA: 0x3D4C2E0
	|-Dictionary<Vector3, int>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x262A720 Offset: 0x262A821 VA: 0x262A720
	|-Dictionary<XPathNodeRef, XPathNodeRef>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x262E220 Offset: 0x262E321 VA: 0x262E220
	|-Dictionary<TerrainUtility.TerrainMap.TileCoord, object>.System.Collections.IDictionary.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 24
	private IDictionaryEnumerator System.Collections.IDictionary.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x251FCF0 Offset: 0x251FDF1 VA: 0x251FCF0
	|-Dictionary<ValueTuple<object, int>, object>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x2523800 Offset: 0x2523901 VA: 0x2523800
	|-Dictionary<byte, object>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x3CA8730 Offset: 0x3CA8831 VA: 0x3CA8730
	|-Dictionary<CancellationToken, object>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x3CAC240 Offset: 0x3CAC341 VA: 0x3CAC240
	|-Dictionary<char, object>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x3CAFD80 Offset: 0x3CAFE81 VA: 0x3CAFD80
	|-Dictionary<Guid, object>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x3CB3850 Offset: 0x3CB3951 VA: 0x3CB3850
	|-Dictionary<int, bool>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x3CB7310 Offset: 0x3CB7411 VA: 0x3CB7310
	|-Dictionary<int, byte>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x3D5EAB0 Offset: 0x3D5EBB1 VA: 0x3D5EAB0
	|-Dictionary<int, CalculatorCommand>.System.Collections.IDictionary.GetEnumerator
	|-Dictionary<int, object>.System.Collections.IDictionary.GetEnumerator
	|-Dictionary<int, TerrainUtility.TerrainMap>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x3CBADD0 Offset: 0x3CBAED1 VA: 0x3CBADD0
	|-Dictionary<int, char>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x3CBEDD0 Offset: 0x3CBEED1 VA: 0x3CBEDD0
	|-Dictionary<int, DiagnosticEvent>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x3D4FE70 Offset: 0x3D4FF71 VA: 0x3D4FE70
	|-Dictionary<int, int>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x3D53900 Offset: 0x3D53A01 VA: 0x3D53900
	|-Dictionary<int, Int32Enum>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x3D57450 Offset: 0x3D57551 VA: 0x3D57450
	|-Dictionary<int, long>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x3D5AFB0 Offset: 0x3D5B0B1 VA: 0x3D5AFB0
	|-Dictionary<int, MapPos>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x3D62550 Offset: 0x3D62651 VA: 0x3D62550
	|-Dictionary<int, uint>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x3D65FE0 Offset: 0x3D660E1 VA: 0x3D65FE0
	|-Dictionary<int, AIThink.EnchantThink.SurroundingInfo>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x3CC28C0 Offset: 0x3CC29C1 VA: 0x3CC28C0
	|-Dictionary<Int32Enum, bool>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x3CC6350 Offset: 0x3CC6451 VA: 0x3CC6350
	|-Dictionary<Int32Enum, int>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x3CC9DE0 Offset: 0x3CC9EE1 VA: 0x3CC9DE0
	|-Dictionary<Int32Enum, Int32Enum>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x3CCD8E0 Offset: 0x3CCD9E1 VA: 0x3CCD8E0
	|-Dictionary<Int32Enum, object>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x3CD13D0 Offset: 0x3CD14D1 VA: 0x3CD13D0
	|-Dictionary<long, object>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x3CD4F20 Offset: 0x3CD5021 VA: 0x3CD4F20
	|-Dictionary<MapPos, int>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x3CD8E20 Offset: 0x3CD8F21 VA: 0x3CD8E20
	|-Dictionary<object, AsyncOperationHandle<object>>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x3CDCD40 Offset: 0x3CDCE41 VA: 0x3CDCD40
	|-Dictionary<object, AsyncOperationHandle>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x3CE0960 Offset: 0x3CE0A61 VA: 0x3CE0960
	|-Dictionary<object, bool>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x3CE4550 Offset: 0x3CE4651 VA: 0x3CE4550
	|-Dictionary<object, byte>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x3CE8140 Offset: 0x3CE8241 VA: 0x3CE8140
	|-Dictionary<object, int>.System.Collections.IDictionary.GetEnumerator
	|-Dictionary<string, int>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x3CEBD30 Offset: 0x3CEBE31 VA: 0x3CEBD30
	|-Dictionary<object, Int32Enum>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x3CEF900 Offset: 0x3CEFA01 VA: 0x3CEF900
	|-Dictionary<object, IntPtr>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x3CF3470 Offset: 0x3CF3571 VA: 0x3CF3470
	|-Dictionary<object, object>.System.Collections.IDictionary.GetEnumerator
	|-Dictionary<string, GameUserRestartData.Growth>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x3C8E290 Offset: 0x3C8E391 VA: 0x3C8E290
	|-Dictionary<object, Playable>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x3C91E90 Offset: 0x3C91F91 VA: 0x3C91E90
	|-Dictionary<object, ResourceLocator>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x3C95A70 Offset: 0x3C95B71 VA: 0x3C95A70
	|-Dictionary<object, float>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x3C99660 Offset: 0x3C99761 VA: 0x3C99660
	|-Dictionary<object, ushort>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x3C9D260 Offset: 0x3C9D361 VA: 0x3C9D260
	|-Dictionary<object, GameVariable.Value>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x3CA1110 Offset: 0x3CA1211 VA: 0x3CA1110
	|-Dictionary<sbyte, DataStoreRatingInfo>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x3CA4C30 Offset: 0x3CA4D31 VA: 0x3CA4C30
	|-Dictionary<sbyte, object>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x3D35AF0 Offset: 0x3D35BF1 VA: 0x3D35AF0
	|-Dictionary<ushort, int>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x3D39580 Offset: 0x3D39681 VA: 0x3D39580
	|-Dictionary<uint, int>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x3D3D080 Offset: 0x3D3D181 VA: 0x3D3D080
	|-Dictionary<uint, object>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x3D410C0 Offset: 0x3D411C1 VA: 0x3D410C0
	|-Dictionary<ulong, Friend>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x3D44C40 Offset: 0x3D44D41 VA: 0x3D44C40
	|-Dictionary<ulong, Int32Enum>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x3D48730 Offset: 0x3D48831 VA: 0x3D48730
	|-Dictionary<ulong, object>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x3D4C3C0 Offset: 0x3D4C4C1 VA: 0x3D4C3C0
	|-Dictionary<Vector3, int>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x262A800 Offset: 0x262A901 VA: 0x262A800
	|-Dictionary<XPathNodeRef, XPathNodeRef>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x262E300 Offset: 0x262E401 VA: 0x262E300
	|-Dictionary<TerrainUtility.TerrainMap.TileCoord, object>.System.Collections.IDictionary.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 25
	private void System.Collections.IDictionary.Remove(object key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x251FD80 Offset: 0x251FE81 VA: 0x251FD80
	|-Dictionary<ValueTuple<object, int>, object>.System.Collections.IDictionary.Remove
	|
	|-RVA: 0x2523890 Offset: 0x2523991 VA: 0x2523890
	|-Dictionary<byte, object>.System.Collections.IDictionary.Remove
	|
	|-RVA: 0x3CA87C0 Offset: 0x3CA88C1 VA: 0x3CA87C0
	|-Dictionary<CancellationToken, object>.System.Collections.IDictionary.Remove
	|
	|-RVA: 0x3CAC2D0 Offset: 0x3CAC3D1 VA: 0x3CAC2D0
	|-Dictionary<char, object>.System.Collections.IDictionary.Remove
	|
	|-RVA: 0x3CAFE10 Offset: 0x3CAFF11 VA: 0x3CAFE10
	|-Dictionary<Guid, object>.System.Collections.IDictionary.Remove
	|
	|-RVA: 0x3CB38D0 Offset: 0x3CB39D1 VA: 0x3CB38D0
	|-Dictionary<int, bool>.System.Collections.IDictionary.Remove
	|
	|-RVA: 0x3CB7390 Offset: 0x3CB7491 VA: 0x3CB7390
	|-Dictionary<int, byte>.System.Collections.IDictionary.Remove
	|
	|-RVA: 0x3D5EB40 Offset: 0x3D5EC41 VA: 0x3D5EB40
	|-Dictionary<int, CalculatorCommand>.System.Collections.IDictionary.Remove
	|-Dictionary<int, object>.System.Collections.IDictionary.Remove
	|-Dictionary<int, TerrainUtility.TerrainMap>.System.Collections.IDictionary.Remove
	|
	|-RVA: 0x3CBAE50 Offset: 0x3CBAF51 VA: 0x3CBAE50
	|-Dictionary<int, char>.System.Collections.IDictionary.Remove
	|
	|-RVA: 0x3CBEE80 Offset: 0x3CBEF81 VA: 0x3CBEE80
	|-Dictionary<int, DiagnosticEvent>.System.Collections.IDictionary.Remove
	|
	|-RVA: 0x3D4FEF0 Offset: 0x3D4FFF1 VA: 0x3D4FEF0
	|-Dictionary<int, int>.System.Collections.IDictionary.Remove
	|
	|-RVA: 0x3D53980 Offset: 0x3D53A81 VA: 0x3D53980
	|-Dictionary<int, Int32Enum>.System.Collections.IDictionary.Remove
	|
	|-RVA: 0x3D574E0 Offset: 0x3D575E1 VA: 0x3D574E0
	|-Dictionary<int, long>.System.Collections.IDictionary.Remove
	|
	|-RVA: 0x3D5B030 Offset: 0x3D5B131 VA: 0x3D5B030
	|-Dictionary<int, MapPos>.System.Collections.IDictionary.Remove
	|
	|-RVA: 0x3D625D0 Offset: 0x3D626D1 VA: 0x3D625D0
	|-Dictionary<int, uint>.System.Collections.IDictionary.Remove
	|
	|-RVA: 0x3D66060 Offset: 0x3D66161 VA: 0x3D66060
	|-Dictionary<int, AIThink.EnchantThink.SurroundingInfo>.System.Collections.IDictionary.Remove
	|
	|-RVA: 0x3CC2940 Offset: 0x3CC2A41 VA: 0x3CC2940
	|-Dictionary<Int32Enum, bool>.System.Collections.IDictionary.Remove
	|
	|-RVA: 0x3CC63D0 Offset: 0x3CC64D1 VA: 0x3CC63D0
	|-Dictionary<Int32Enum, int>.System.Collections.IDictionary.Remove
	|
	|-RVA: 0x3CC9E60 Offset: 0x3CC9F61 VA: 0x3CC9E60
	|-Dictionary<Int32Enum, Int32Enum>.System.Collections.IDictionary.Remove
	|
	|-RVA: 0x3CCD970 Offset: 0x3CCDA71 VA: 0x3CCD970
	|-Dictionary<Int32Enum, object>.System.Collections.IDictionary.Remove
	|
	|-RVA: 0x3CD1460 Offset: 0x3CD1561 VA: 0x3CD1460
	|-Dictionary<long, object>.System.Collections.IDictionary.Remove
	|
	|-RVA: 0x3CD4FA0 Offset: 0x3CD50A1 VA: 0x3CD4FA0
	|-Dictionary<MapPos, int>.System.Collections.IDictionary.Remove
	|
	|-RVA: 0x3CD8EC0 Offset: 0x3CD8FC1 VA: 0x3CD8EC0
	|-Dictionary<object, AsyncOperationHandle<object>>.System.Collections.IDictionary.Remove
	|
	|-RVA: 0x3CDCDE0 Offset: 0x3CDCEE1 VA: 0x3CDCDE0
	|-Dictionary<object, AsyncOperationHandle>.System.Collections.IDictionary.Remove
	|
	|-RVA: 0x3CE09F0 Offset: 0x3CE0AF1 VA: 0x3CE09F0
	|-Dictionary<object, bool>.System.Collections.IDictionary.Remove
	|
	|-RVA: 0x3CE45E0 Offset: 0x3CE46E1 VA: 0x3CE45E0
	|-Dictionary<object, byte>.System.Collections.IDictionary.Remove
	|
	|-RVA: 0x3CE81D0 Offset: 0x3CE82D1 VA: 0x3CE81D0
	|-Dictionary<object, int>.System.Collections.IDictionary.Remove
	|-Dictionary<string, int>.System.Collections.IDictionary.Remove
	|
	|-RVA: 0x3CEBDC0 Offset: 0x3CEBEC1 VA: 0x3CEBDC0
	|-Dictionary<object, Int32Enum>.System.Collections.IDictionary.Remove
	|
	|-RVA: 0x3CEF990 Offset: 0x3CEFA91 VA: 0x3CEF990
	|-Dictionary<object, IntPtr>.System.Collections.IDictionary.Remove
	|
	|-RVA: 0x3CF3500 Offset: 0x3CF3601 VA: 0x3CF3500
	|-Dictionary<object, object>.System.Collections.IDictionary.Remove
	|-Dictionary<string, GameUserRestartData.Growth>.System.Collections.IDictionary.Remove
	|
	|-RVA: 0x3C8E320 Offset: 0x3C8E421 VA: 0x3C8E320
	|-Dictionary<object, Playable>.System.Collections.IDictionary.Remove
	|
	|-RVA: 0x3C91F20 Offset: 0x3C92021 VA: 0x3C91F20
	|-Dictionary<object, ResourceLocator>.System.Collections.IDictionary.Remove
	|
	|-RVA: 0x3C95B00 Offset: 0x3C95C01 VA: 0x3C95B00
	|-Dictionary<object, float>.System.Collections.IDictionary.Remove
	|
	|-RVA: 0x3C996F0 Offset: 0x3C997F1 VA: 0x3C996F0
	|-Dictionary<object, ushort>.System.Collections.IDictionary.Remove
	|
	|-RVA: 0x3C9D2F0 Offset: 0x3C9D3F1 VA: 0x3C9D2F0
	|-Dictionary<object, GameVariable.Value>.System.Collections.IDictionary.Remove
	|
	|-RVA: 0x3CA11B0 Offset: 0x3CA12B1 VA: 0x3CA11B0
	|-Dictionary<sbyte, DataStoreRatingInfo>.System.Collections.IDictionary.Remove
	|
	|-RVA: 0x3CA4CC0 Offset: 0x3CA4DC1 VA: 0x3CA4CC0
	|-Dictionary<sbyte, object>.System.Collections.IDictionary.Remove
	|
	|-RVA: 0x3D35B70 Offset: 0x3D35C71 VA: 0x3D35B70
	|-Dictionary<ushort, int>.System.Collections.IDictionary.Remove
	|
	|-RVA: 0x3D39600 Offset: 0x3D39701 VA: 0x3D39600
	|-Dictionary<uint, int>.System.Collections.IDictionary.Remove
	|
	|-RVA: 0x3D3D110 Offset: 0x3D3D211 VA: 0x3D3D110
	|-Dictionary<uint, object>.System.Collections.IDictionary.Remove
	|
	|-RVA: 0x3D41160 Offset: 0x3D41261 VA: 0x3D41160
	|-Dictionary<ulong, Friend>.System.Collections.IDictionary.Remove
	|
	|-RVA: 0x3D44CD0 Offset: 0x3D44DD1 VA: 0x3D44CD0
	|-Dictionary<ulong, Int32Enum>.System.Collections.IDictionary.Remove
	|
	|-RVA: 0x3D487C0 Offset: 0x3D488C1 VA: 0x3D487C0
	|-Dictionary<ulong, object>.System.Collections.IDictionary.Remove
	|
	|-RVA: 0x3D4C450 Offset: 0x3D4C551 VA: 0x3D4C450
	|-Dictionary<Vector3, int>.System.Collections.IDictionary.Remove
	|
	|-RVA: 0x262A8A0 Offset: 0x262A9A1 VA: 0x262A8A0
	|-Dictionary<XPathNodeRef, XPathNodeRef>.System.Collections.IDictionary.Remove
	|
	|-RVA: 0x262E390 Offset: 0x262E491 VA: 0x262E390
	|-Dictionary<TerrainUtility.TerrainMap.TileCoord, object>.System.Collections.IDictionary.Remove
	*/
}

