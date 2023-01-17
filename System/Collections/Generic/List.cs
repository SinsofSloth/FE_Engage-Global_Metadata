// Namespace: System.Collections.Generic
[DebuggerDisplayAttribute] // RVA: 0x477930 Offset: 0x477A31 VA: 0x477930
[DebuggerTypeProxyAttribute] // RVA: 0x477930 Offset: 0x477A31 VA: 0x477930
[DefaultMemberAttribute] // RVA: 0x477930 Offset: 0x477A31 VA: 0x477930
[Serializable]
public class List<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IList, ICollection, IReadOnlyList<T>, IReadOnlyCollection<T> // TypeDefIndex: 1441
{
	// Fields
	private const int _defaultCapacity = 4;
	private T[] _items; // 0x0
	private int _size; // 0x0
	private int _version; // 0x0
	private object _syncRoot; // 0x0
	private static readonly T[] _emptyArray; // 0x0

	// Properties
	public int Capacity { get; set; }
	public int Count { get; }
	private bool System.Collections.Generic.ICollection<T>.IsReadOnly { get; }
	private bool System.Collections.IList.IsReadOnly { get; }
	private bool System.Collections.ICollection.IsSynchronized { get; }
	private object System.Collections.ICollection.SyncRoot { get; }
	public T Item { get; set; }
	private object System.Collections.IList.Item { get; set; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3E10310 Offset: 0x3E10411 VA: 0x3E10310
	|-List<Dictionary<sbyte, DataStoreRatingInfo>>..ctor
	|-List<List<CinemachineVirtualCameraBase>>..ctor
	|-List<List<int>>..ctor
	|-List<List<object>>..ctor
	|-List<List<SubscriberContent>>..ctor
	|-List<List<Vector2>>..ctor
	|-List<List<Vector3>>..ctor
	|-List<MiniMapController.TImage<Image>>..ctor
	|-List<MiniMapController.TImage<UnitIcon>>..ctor
	|-List<KeyCode[]>..ctor
	|-List<string[]>..ctor
	|-List<AccessoryData>..ctor
	|-List<AccessoryShopContent>..ctor
	|-List<AchieveData>..ctor
	|-List<Action>..ctor
	|-List<AggregateException>..ctor
	|-List<AkAmbient>..ctor
	|-List<AkAmbientLargeModePositioner>..ctor
	|-List<AkAudioListener>..ctor
	|-List<AkEnvironment>..ctor
	|-List<AkEnvironmentPortal>..ctor
	|-List<AkGameObj>..ctor
	|-List<AkRoom>..ctor
	|-List<AkRoomAwareObject>..ctor
	|-List<AkRoomPortal>..ctor
	|-List<AkSpatialAudioListener>..ctor
	|-List<AkSurfaceReflector>..ctor
	|-List<AnimalData>..ctor
	|-List<AnimationClip>..ctor
	|-List<AnimationEvent>..ctor
	|-List<AnimationTrack>..ctor
	|-List<Animator>..ctor
	|-List<AssetTable>..ctor
	|-List<AssetTableItem>..ctor
	|-List<AsyncDebugger>..ctor
	|-List<AudienceAnime>..ctor
	|-List<BaseConverter>..ctor
	|-List<BaseInputModule>..ctor
	|-List<BaseInvokableCall>..ctor
	|-List<BaseRaycaster>..ctor
	|-List<BasicMenu>..ctor
	|-List<BasicMenuItem>..ctor
	|-List<BasicMenuSelect>..ctor
	|-List<Behaviour>..ctor
	|-List<BranchLabel>..ctor
	|-List<Breakpoint>..ctor
	|-List<BuildTimeScopeBlock>..ctor
	|-List<BuildTimeScopeFrame>..ctor
	|-List<ByRefUpdater>..ctor
	|-List<CalculatorCommand>..ctor
	|-List<Camera>..ctor
	|-List<CanvasGroup>..ctor
	|-List<ChapterData>..ctor
	|-List<CharacterProportion>..ctor
	|-List<CinemachineBrain>..ctor
	|-List<CinemachineComponentBase>..ctor
	|-List<CinemachineExtension>..ctor
	|-List<CinemachineVirtualCameraBase>..ctor
	|-List<Claim>..ctor
	|-List<Collider>..ctor
	|-List<Contraction>..ctor
	|-List<CustomEnvSet>..ctor
	|-List<DataStoreChangeMetaParam>..ctor
	|-List<DataStoreDeleteParam>..ctor
	|-List<DataStoreGetMetaParam>..ctor
	|-List<DataStoreMetaInfo>..ctor
	|-List<DataStorePasswordInfo>..ctor
	|-List<DataStorePersistenceInfo>..ctor
	|-List<DataStorePreparePostParam>..ctor
	|-List<DataStoreRateObjectParam>..ctor
	|-List<DataStoreRatingTarget>..ctor
	|-List<DebugInfo>..ctor
	|-List<DebugUIHandlerPanel>..ctor
	|-List<DebugUIHandlerValue>..ctor
	|-List<DebugUIHandlerWidget>..ctor
	|-List<DebugUIPrefabBundle>..ctor
	|-List<Decorator>..ctor
	|-List<DisposData>..ctor
	|-List<DynValue>..ctor
	|-List<DynamicExpression>..ctor
	|-List<EncountUnitData>..ctor
	|-List<EventCharacterMouthController>..ctor
	|-List<EventSystem>..ctor
	|-List<Exception>..ctor
	|-List<ExceptionHandler>..ctor
	|-List<Expression>..ctor
	|-List<Expression>..ctor
	|-List<FileData>..ctor
	|-List<FoodstuffData>..ctor
	|-List<ForecastFishData>..ctor
	|-List<GUILayoutEntry>..ctor
	|-List<GameObject>..ctor
	|-List<Glyph>..ctor
	|-List<GmapSpot>..ctor
	|-List<GodUnit>..ctor
	|-List<GotoStatement>..ctor
	|-List<Graphic>..ctor
	|-List<HubAccess>..ctor
	|-List<HubAccessData>..ctor
	|-List<HubAccessManager>..ctor
	|-List<HubAreaFog>..ctor
	|-List<HubDisposData>..ctor
	|-List<HubManualCulling>..ctor
	|-List<HubMoveState>..ctor
	|-List<HubUnitController>..ctor
	|-List<IAsyncLocal>..ctor
	|-List<IAsyncOperation>..ctor
	|-List<ICanvasElement>..ctor
	|-List<IClosureBuilder>..ctor
	|-List<IContextProperty>..ctor
	|-List<IDisposable>..ctor
	|-List<IDtdDefaultAttributeInfo>..ctor
	|-List<IMenuElement>..ctor
	|-List<IOverloadableMemberDescriptor>..ctor
	|-List<IPAddress>..ctor
	|-List<IResourceLocation>..ctor
	|-List<ISpringManager>..ctor
	|-List<ITimelineEvaluateCallback>..ctor
	|-List<IUpdateReceiver>..ctor
	|-List<IUserDataDescriptor>..ctor
	|-List<IVariable>..ctor
	|-List<Image>..ctor
	|-List<Instruction>..ctor
	|-List<Instruction>..ctor
	|-List<IntegratedSubsystem>..ctor
	|-List<IntegratedSubsystemDescriptor>..ctor
	|-List<InteractionTarget>..ctor
	|-List<InteractionTrigger>..ctor
	|-List<ItemData>..ctor
	|-List<JobData>..ctor
	|-List<KerningPair>..ctor
	|-List<LabelScopeInfo>..ctor
	|-List<Level2Map>..ctor
	|-List<Light2D>..ctor
	|-List<LocalDataStore>..ctor
	|-List<MagicSignal>..ctor
	|-List<MapInfoRoot>..ctor
	|-List<MapObject>..ctor
	|-List<MascotColorChangeItemContent>..ctor
	|-List<Material>..ctor
	|-List<MaterialPropertyBlock>..ctor
	|-List<MenuItem>..ctor
	|-List<Mesh>..ctor
	|-List<MethodInfo>..ctor
	|-List<ModifierSpec>..ctor
	|-List<MusclePushUpSpeedData>..ctor
	|-List<MuscleSitUpFallData>..ctor
	|-List<Note>..ctor
	|-List<NotificationEvent>..ctor
	|-List<NotificationEventCB>..ctor
	|-List<object>..ctor
	|-List<PersistentCall>..ctor
	|-List<Phase>..ctor
	|-List<PhotographCameraParameter>..ctor
	|-List<PhotographDisposInfo>..ctor
	|-List<PhotographPauseData>..ctor
	|-List<PlayReportSendBase>..ctor
	|-List<PrefetchedSignal>..ctor
	|-List<Processor>..ctor
	|-List<ProfileCard>..ctor
	|-List<Ranking2ChartInfo>..ctor
	|-List<Ranking2RankData>..ctor
	|-List<RankingCachedResult>..ctor
	|-List<RankingOrderParam>..ctor
	|-List<RankingRankData>..ctor
	|-List<RectMask2D>..ctor
	|-List<RectTransform>..ctor
	|-List<RelayLeavingUnitData>..ctor
	|-List<RelayServerMetaData>..ctor
	|-List<RelayStampData>..ctor
	|-List<RenderGraph>..ctor
	|-List<Renderer>..ctor
	|-List<ResourceGameObject>..ctor
	|-List<ResourceHandle>..ctor
	|-List<ResourceLocationData>..ctor
	|-List<RewardData>..ctor
	|-List<Rigidbody2D>..ctor
	|-List<RingCleaningVoiceData>..ctor
	|-List<RingData>..ctor
	|-List<RuntimeAnimatorController>..ctor
	|-List<RuntimeElement>..ctor
	|-List<Scope>..ctor
	|-List<ScreeningContextInfo>..ctor
	|-List<ScriptableObject>..ctor
	|-List<SerializationFieldInfo>..ctor
	|-List<ShadowCaster2D>..ctor
	|-List<ShadowCasterGroup2D>..ctor
	|-List<ShopContent>..ctor
	|-List<SignalAsset>..ctor
	|-List<SkillData>..ctor
	|-List<SkinQualityLodAdjuster>..ctor
	|-List<SkinnedMeshRenderer>..ctor
	|-List<SolverManager>..ctor
	|-List<SourceCode>..ctor
	|-List<SourceRef>..ctor
	|-List<SpringBone>..ctor
	|-List<Sprite>..ctor
	|-List<StackFrame>..ctor
	|-List<StackFrame>..ctor
	|-List<Statement>..ctor
	|-List<string>..ctor
	|-List<StringBuilder>..ctor
	|-List<StructProperty>..ctor
	|-List<SubscriberContent>..ctor
	|-List<SubscriberUserStatusInfo>..ctor
	|-List<Subsystem>..ctor
	|-List<SubsystemDescriptor>..ctor
	|-List<SubsystemDescriptorWithProvider>..ctor
	|-List<SubsystemWithProvider>..ctor
	|-List<SymbolRef>..ctor
	|-List<TMP_Character>..ctor
	|-List<TMP_FontAsset>..ctor
	|-List<TMP_GlyphPairAdjustmentRecord>..ctor
	|-List<TMP_SpriteCharacter>..ctor
	|-List<TMP_SpriteGlyph>..ctor
	|-List<TMP_Text>..ctor
	|-List<Task>..ctor
	|-List<Texture2D>..ctor
	|-List<Thread>..ctor
	|-List<Thread>..ctor
	|-List<TimeZoneInfo>..ctor
	|-List<TimelineClip>..ctor
	|-List<Toggle>..ctor
	|-List<TrackAsset>..ctor
	|-List<Transform>..ctor
	|-List<Type>..ctor
	|-List<TypeIdentifier>..ctor
	|-List<TypeSpec>..ctor
	|-List<UniqueIdInfo>..ctor
	|-List<Unit>..ctor
	|-List<UnitActor>..ctor
	|-List<UnitItem>..ctor
	|-List<UnityEvent>..ctor
	|-List<UnityWebRequestAsyncOperation>..ctor
	|-List<ValueCountController>..ctor
	|-List<Variable>..ctor
	|-List<VersusServerCasualMetaData>..ctor
	|-List<VersusServerRankedMetaData>..ctor
	|-List<VersusServerReplayMetaData>..ctor
	|-List<Volume>..ctor
	|-List<VolumeComponent>..ctor
	|-List<WatchItem>..ctor
	|-List<WeaponMask>..ctor
	|-List<WindActor>..ctor
	|-List<X509CertificateImpl>..ctor
	|-List<XRDisplaySubsystem>..ctor
	|-List<XRPass>..ctor
	|-List<XmlSchema>..ctor
	|-List<XmlSchemaElement>..ctor
	|-List<XmlSchemaObject>..ctor
	|-List<AICannon.CannonData>..ctor
	|-List<AddressablesImpl.ResourceLocatorInfo>..ctor
	|-List<AkBankManager.BankHandle>..ctor
	|-List<AkEvent.CallbackData>..ctor
	|-List<AkWwiseInitializationSettings.PlatformSettings>..ctor
	|-List<AssetBundleBuildMap.AssetBundleEntry>..ctor
	|-List<AssetTable.Accessory>..ctor
	|-List<BufferedGizmo.Segment>..ctor
	|-List<CalculatorUtil.Entity>..ctor
	|-List<ChapterRecord.Record>..ctor
	|-List<CinemachineBrain.BrainFrame>..ctor
	|-List<CinemachineImpulseManager.ImpulseEvent>..ctor
	|-List<CinemachineStoryboard.CanvasInfo>..ctor
	|-List<ClassChange.ChangeJobData>..ctor
	|-List<CombatViewerSettings.ViewerPhase>..ctor
	|-List<ConditionGetterCommand.Command>..ctor
	|-List<ConstantBuffer.ConstantBufferBase>..ctor
	|-List<DLCManager.MountData>..ctor
	|-List<DamageInfo.Info>..ctor
	|-List<DebugCommandline.Property>..ctor
	|-List<DebugPathMenu.EntryData>..ctor
	|-List<DebugUI.Panel>..ctor
	|-List<DebugUI.Widget>..ctor
	|-List<Directory.SearchData>..ctor
	|-List<DishSelectMenu.DishSelectMenuItem>..ctor
	|-List<DragonRideSequence.PrizeData>..ctor
	|-List<DragonRideTargetGroup.ChainSEManager>..ctor
	|-List<Dropdown.DropdownItem>..ctor
	|-List<Dropdown.OptionData>..ctor
	|-List<DynamicsSetup.ParseMessage>..ctor
	|-List<EmittersConstraint.Pair>..ctor
	|-List<EventSequence.Coroutine>..ctor
	|-List<EventTrigger.Entry>..ctor
	|-List<ExchangeYesNoDialog.ItemParam>..ctor
	|-List<FoodstuffMenu.FoodstuffMenuItem>..ctor
	|-List<GameSaveDataHeaderReader.Handle>..ctor
	|-List<GameSound.Handle>..ctor
	|-List<GmapMapInfoContent.ItemInfo>..ctor
	|-List<GodGrowthData.LevelData>..ctor
	|-List<HelpManager.Item>..ctor
	|-List<HubMiniMap.IconData>..ctor
	|-List<IfStatement.IfBlock>..ctor
	|-List<ItemListYesNoDialog.ItemParam>..ctor
	|-List<LaterTalkSetter.UnitData>..ctor
	|-List<LocalVariables.VariableScope>..ctor
	|-List<MapBattleInfoSequence.AttackInfo>..ctor
	|-List<MapEditData.UnitInfo>..ctor
	|-List<MapLayer.Data>..ctor
	|-List<MapMaterial.Node>..ctor
	|-List<MapObject.DitherPair>..ctor
	|-List<MapObject.RigidInfo>..ctor
	|-List<MapOverlap.Data>..ctor
	|-List<MapPrefab.Entity>..ctor
	|-List<MapTerrain.LayerData>..ctor
	|-List<MapTerrain.OverlapData>..ctor
	|-List<MapTerrainInfoAlignment.AlignMember>..ctor
	|-List<MapTerrainInfoAlignment.InversionMember>..ctor
	|-List<Mess.ReloadFileInfo>..ctor
	|-List<MuscleSquatSequence.RandomPack>..ctor
	|-List<MyRoomWakeupSequence.RelianceWakeup>..ctor
	|-List<PhotographTopSequence.UnitAccDataSet>..ctor
	|-List<PlayerEditorConnectionEvents.MessageTypeSubscribers>..ctor
	|-List<PointerInputModule.ButtonState>..ctor
	|-List<RefineRingInfoWindow.RingRefineStatistics>..ctor
	|-List<RelayMessageMenuContent.KindIcon>..ctor
	|-List<RelayUserData.EnteredBattle>..ctor
	|-List<RelayWdwMapHelp.ShowItem>..ctor
	|-List<ResourceManager.InstanceOperation>..ctor
	|-List<RingListSequence.GodPageData>..ctor
	|-List<RingListSequence.PageData>..ctor
	|-List<RingListSequence.RingPageData>..ctor
	|-List<SimpleAnimation.EditorState>..ctor
	|-List<SimpleAnimationPlayable.StateInfo>..ctor
	|-List<SkillData.Func>..ctor
	|-List<SkillStack.Packet>..ctor
	|-List<SolanelInfoMenuContent.HelpFastTravel>..ctor
	|-List<SolanelInfoMenuContent.Infomation>..ctor
	|-List<SolanelInfoMenuContent.SolanelUnit>..ctor
	|-List<SoundSystem.LipSyncData>..ctor
	|-List<SoundSystem.ResultSoundLoad>..ctor
	|-List<SoundSystem.SoundHandle>..ctor
	|-List<SpringBoneSerialization.PivotSerializer>..ctor
	|-List<SpringBoneSerialization.SpringBoneSerializer>..ctor
	|-List<SpringColliderSerialization.IColliderSerializer>..ctor
	|-List<SpringColliderSerialization.TransformSerializer>..ctor
	|-List<StencilMaterial.MatEntry>..ctor
	|-List<StructHeader.Param>..ctor
	|-List<TMP_Dropdown.DropdownItem>..ctor
	|-List<TMP_Dropdown.OptionData>..ctor
	|-List<TMP_MaterialManager.FallbackMaterial>..ctor
	|-List<TMP_MaterialManager.MaskingMaterial>..ctor
	|-List<TextRecordParsing.Record>..ctor
	|-List<TimeZoneInfo.AdjustmentRule>..ctor
	|-List<TransformAnimation.Animator>..ctor
	|-List<UnitSelectMenu.UnitSelectMenuItem>..ctor
	|-List<EventDemoSequence.SoundEnv.EventNameData>..ctor
	|-List<GameSaveDataUtil.ProcDeleteAll.Data>..ctor
	|-List<SoundWwise.SoundBankManager.BankHandle>..ctor
	|-List<TransformAnimation.Animator.Node>..ctor
	|-List<Versus.DownloadHistory.CheckData>..ctor
	|-List<VersusSequence.VersusSequenceLocal.MetaDataPack>..ctor
	|
	|-RVA: 0x3B0A270 Offset: 0x3B0A371 VA: 0x3B0A270
	|-List<IntervalTree.Entry<object>>..ctor
	|
	|-RVA: 0x3B164E0 Offset: 0x3B165E1 VA: 0x3B164E0
	|-List<KeyValuePair<AnimationClip, AnimationClip>>..ctor
	|-List<KeyValuePair<Expression, Expression>>..ctor
	|-List<KeyValuePair<object, object>>..ctor
	|
	|-RVA: 0x3B0D480 Offset: 0x3B0D581 VA: 0x3B0D480
	|-List<KeyValuePair<DateTime, object>>..ctor
	|
	|-RVA: 0x3B132C0 Offset: 0x3B133C1 VA: 0x3B132C0
	|-List<KeyValuePair<IAwaiter, ValueTuple<int, DateTime, string>>>..ctor
	|-List<KeyValuePair<object, ValueTuple<int, DateTime, object>>>..ctor
	|
	|-RVA: 0x3B103A0 Offset: 0x3B104A1 VA: 0x3B103A0
	|-List<KeyValuePair<int, object>>..ctor
	|
	|-RVA: 0x3B19400 Offset: 0x3B19501 VA: 0x3B19400
	|-List<CommonBattleSequence.Reliance<object>>..ctor
	|
	|-RVA: 0x3B1C610 Offset: 0x3B1C711 VA: 0x3B1C610
	|-List<RenderGraphResourcePool.ResourceLogInfo<object>>..ctor
	|
	|-RVA: 0x3B1F530 Offset: 0x3B1F631 VA: 0x3B1F530
	|-List<ValueTuple<int, object>>..ctor
	|
	|-RVA: 0x3DE01C0 Offset: 0x3DE02C1 VA: 0x3DE01C0
	|-List<ValueTuple<Int32Enum, int>>..ctor
	|-List<ValueTuple<HubAccessManager.MaterialCalculator.Type, int>>..ctor
	|
	|-RVA: 0x3DE2FD0 Offset: 0x3DE30D1 VA: 0x3DE2FD0
	|-List<ValueTuple<object, ValueTuple<object, int>>>..ctor
	|-List<ValueTuple<object, ValueTuple<Type, int>>>..ctor
	|
	|-RVA: 0x3DE61E0 Offset: 0x3DE62E1 VA: 0x3DE61E0
	|-List<ValueTuple<object, int>>..ctor
	|-List<ValueTuple<string, int>>..ctor
	|
	|-RVA: 0x3DE9100 Offset: 0x3DE9201 VA: 0x3DE9100
	|-List<ValueTuple<Vector3, float>>..ctor
	|
	|-RVA: 0x3DEC100 Offset: 0x3DEC201 VA: 0x3DEC100
	|-List<ValueTuple<ItemData.Kinds[], WeaponLevel.Kind, int>>..ctor
	|-List<ValueTuple<object, Int32Enum, int>>..ctor
	|
	|-RVA: 0x3DEF020 Offset: 0x3DEF121 VA: 0x3DEF020
	|-List<ValueTuple<object, int, int, int>>..ctor
	|-List<ValueTuple<string, int, int, int>>..ctor
	|
	|-RVA: 0x3DF2230 Offset: 0x3DF2331 VA: 0x3DF2230
	|-List<AnimatorClipInfo>..ctor
	|
	|-RVA: 0x3DF5040 Offset: 0x3DF5141 VA: 0x3DF5040
	|-List<AsyncOperationHandle>..ctor
	|
	|-RVA: 0x3DF8250 Offset: 0x3DF8351 VA: 0x3DF8250
	|-List<BoneWeight>..ctor
	|
	|-RVA: 0x3DFB440 Offset: 0x3DFB541 VA: 0x3DFB440
	|-List<bool>..ctor
	|
	|-RVA: 0x3E789A0 Offset: 0x3E78AA1 VA: 0x3E789A0
	|-List<byte>..ctor
	|
	|-RVA: 0x3E7B7B0 Offset: 0x3E7B8B1 VA: 0x3E7B7B0
	|-List<CameraInfo>..ctor
	|
	|-RVA: 0x3EAE0A0 Offset: 0x3EAE1A1 VA: 0x3EAE0A0
	|-List<CameraPosition>..ctor
	|-List<DataType>..ctor
	|-List<Int32Enum>..ctor
	|-List<RegexOptions>..ctor
	|-List<CapabilityDefinition.Type>..ctor
	|-List<Cooking.ConversationType>..ctor
	|-List<ItemData.Kinds>..ctor
	|-List<MapPanelActive.MeshIndex>..ctor
	|-List<MapPanelDanger.MeshIndex>..ctor
	|-List<MapPanelDeploy.MeshIndex>..ctor
	|-List<MapUIGauge.IconIndex>..ctor
	|-List<TutorialListTopMenu.SelectCategoryType>..ctor
	|
	|-RVA: 0x3E7E6D0 Offset: 0x3E7E7D1 VA: 0x3E7E6D0
	|-List<char>..ctor
	|
	|-RVA: 0x3E814D0 Offset: 0x3E815D1 VA: 0x3E814D0
	|-List<Color>..ctor
	|
	|-RVA: 0x3E844D0 Offset: 0x3E845D1 VA: 0x3E844D0
	|-List<Color32>..ctor
	|
	|-RVA: 0x3E872E0 Offset: 0x3E873E1 VA: 0x3E872E0
	|-List<ConstraintSource>..ctor
	|
	|-RVA: 0x3E8A200 Offset: 0x3E8A301 VA: 0x3E8A200
	|-List<ContourVertex>..ctor
	|
	|-RVA: 0x3E8D410 Offset: 0x3E8D511 VA: 0x3E8D410
	|-List<DataStoreRatingInfo>..ctor
	|
	|-RVA: 0x3E905F0 Offset: 0x3E906F1 VA: 0x3E905F0
	|-List<DataStoreResult>..ctor
	|
	|-RVA: 0x3E93400 Offset: 0x3E93501 VA: 0x3E93400
	|-List<DateTime>..ctor
	|
	|-RVA: 0x3E96210 Offset: 0x3E96311 VA: 0x3E96210
	|-List<DateTimeOffset>..ctor
	|
	|-RVA: 0x3E990F0 Offset: 0x3E991F1 VA: 0x3E990F0
	|-List<Decimal>..ctor
	|
	|-RVA: 0x3E9BFD0 Offset: 0x3E9C0D1 VA: 0x3E9BFD0
	|-List<DiagnosticEvent>..ctor
	|
	|-RVA: 0x3E9F410 Offset: 0x3E9F511 VA: 0x3E9F410
	|-List<double>..ctor
	|
	|-RVA: 0x3EA2230 Offset: 0x3EA2331 VA: 0x3EA2230
	|-List<Friend>..ctor
	|
	|-RVA: 0x3EA55C0 Offset: 0x3EA56C1 VA: 0x3EA55C0
	|-List<GlyphRect>..ctor
	|
	|-RVA: 0x3EA84A0 Offset: 0x3EA85A1 VA: 0x3EA84A0
	|-List<short>..ctor
	|
	|-RVA: 0x3EAB2A0 Offset: 0x3EAB3A1 VA: 0x3EAB2A0
	|-List<int>..ctor
	|
	|-RVA: 0x3EB0EA0 Offset: 0x3EB0FA1 VA: 0x3EB0EA0
	|-List<long>..ctor
	|
	|-RVA: 0x3DFE270 Offset: 0x3DFE371 VA: 0x3DFE270
	|-List<IntPtr>..ctor
	|
	|-RVA: 0x3E01070 Offset: 0x3E01171 VA: 0x3E01070
	|-List<InterpretedFrameInfo>..ctor
	|
	|-RVA: 0x3E03F90 Offset: 0x3E04091 VA: 0x3E03F90
	|-List<IntervalTreeNode>..ctor
	|
	|-RVA: 0x3E07170 Offset: 0x3E07271 VA: 0x3E07170
	|-List<LengthLimitProperties>..ctor
	|
	|-RVA: 0x3E09F80 Offset: 0x3E0A081 VA: 0x3E09F80
	|-List<MapPos>..ctor
	|
	|-RVA: 0x3E0CD90 Offset: 0x3E0CE91 VA: 0x3E0CD90
	|-List<Matrix4x4>..ctor
	|
	|-RVA: 0x3E130D0 Offset: 0x3E131D1 VA: 0x3E130D0
	|-List<ObjectInitializationData>..ctor
	|
	|-RVA: 0x3E16510 Offset: 0x3E16611 VA: 0x3E16510
	|-List<PlayableBinding>..ctor
	|
	|-RVA: 0x3E19730 Offset: 0x3E19831 VA: 0x3E19730
	|-List<PlayerLoopSystem>..ctor
	|
	|-RVA: 0x3DA3BD0 Offset: 0x3DA3CD1 VA: 0x3DA3BD0
	|-List<PlayerLoopSystemInternal>..ctor
	|
	|-RVA: 0x3DA6FA0 Offset: 0x3DA70A1 VA: 0x3DA6FA0
	|-List<RangePositionInfo>..ctor
	|
	|-RVA: 0x3DA9EC0 Offset: 0x3DA9FC1 VA: 0x3DA9EC0
	|-List<Ranking2ChartInfoInput>..ctor
	|
	|-RVA: 0x3DACCD0 Offset: 0x3DACDD1 VA: 0x3DACCD0
	|-List<RaycastHit2D>..ctor
	|
	|-RVA: 0x3DB00F0 Offset: 0x3DB01F1 VA: 0x3DB00F0
	|-List<RaycastResult>..ctor
	|
	|-RVA: 0x3DB3900 Offset: 0x3DB3A01 VA: 0x3DB3900
	|-List<Rect>..ctor
	|
	|-RVA: 0x3DB6900 Offset: 0x3DB6A01 VA: 0x3DB6900
	|-List<RendererListHandle>..ctor
	|
	|-RVA: 0x3DB9710 Offset: 0x3DB9811 VA: 0x3DB9710
	|-List<ResourceHandle>..ctor
	|
	|-RVA: 0x3DBC520 Offset: 0x3DBC621 VA: 0x3DBC520
	|-List<sbyte>..ctor
	|
	|-RVA: 0x3DBF330 Offset: 0x3DBF431 VA: 0x3DBF330
	|-List<ShaderTagId>..ctor
	|
	|-RVA: 0x3E3AF90 Offset: 0x3E3B091 VA: 0x3E3AF90
	|-List<float>..ctor
	|
	|-RVA: 0x3E3DDB0 Offset: 0x3E3DEB1 VA: 0x3E3DDB0
	|-List<SphericalHarmonicsL2>..ctor
	|
	|-RVA: 0x3E41A90 Offset: 0x3E41B91 VA: 0x3E41A90
	|-List<SubMeshDescriptor>..ctor
	|
	|-RVA: 0x3E44E80 Offset: 0x3E44F81 VA: 0x3E44E80
	|-List<TablePair>..ctor
	|
	|-RVA: 0x3E47DA0 Offset: 0x3E47EA1 VA: 0x3E47DA0
	|-List<TimeSpan>..ctor
	|
	|-RVA: 0x3E4ABB0 Offset: 0x3E4ACB1 VA: 0x3E4ABB0
	|-List<UICharInfo>..ctor
	|
	|-RVA: 0x3E4DB90 Offset: 0x3E4DC91 VA: 0x3E4DB90
	|-List<UILineInfo>..ctor
	|
	|-RVA: 0x3E50A70 Offset: 0x3E50B71 VA: 0x3E50A70
	|-List<UIVertex>..ctor
	|
	|-RVA: 0x3E54750 Offset: 0x3E54851 VA: 0x3E54750
	|-List<ushort>..ctor
	|
	|-RVA: 0x3E57550 Offset: 0x3E57651 VA: 0x3E57550
	|-List<uint>..ctor
	|
	|-RVA: 0x3DC2140 Offset: 0x3DC2241 VA: 0x3DC2140
	|-List<ulong>..ctor
	|
	|-RVA: 0x3DC4F40 Offset: 0x3DC5041 VA: 0x3DC4F40
	|-List<Vector2>..ctor
	|
	|-RVA: 0x3DC7E10 Offset: 0x3DC7F11 VA: 0x3DC7E10
	|-List<Vector3>..ctor
	|
	|-RVA: 0x3DCADF0 Offset: 0x3DCAEF1 VA: 0x3DCADF0
	|-List<Vector4>..ctor
	|
	|-RVA: 0x3DCDDF0 Offset: 0x3DCDEF1 VA: 0x3DCDDF0
	|-List<VertexAttributeDescriptor>..ctor
	|
	|-RVA: 0x3DD0CD0 Offset: 0x3DD0DD1 VA: 0x3DD0CD0
	|-List<X509ChainStatus>..ctor
	|
	|-RVA: 0x3DD3BF0 Offset: 0x3DD3CF1 VA: 0x3DD3BF0
	|-List<XRView>..ctor
	|
	|-RVA: 0x3DD6FE0 Offset: 0x3DD70E1 VA: 0x3DD6FE0
	|-List<AmiiboSequence.GainItemData>..ctor
	|
	|-RVA: 0x3DD9F00 Offset: 0x3DDA001 VA: 0x3DD9F00
	|-List<AnimationOutputWeightProcessor.WeightInfo>..ctor
	|
	|-RVA: 0x3DDD2A0 Offset: 0x3DDD3A1 VA: 0x3DDD2A0
	|-List<ArenaOrderSequence.GodInfo>..ctor
	|
	|-RVA: 0x3E1CB00 Offset: 0x3E1CC01 VA: 0x3E1CB00
	|-List<BattleInfo.SupportData>..ctor
	|
	|-RVA: 0x3E1FA20 Offset: 0x3E1FB21 VA: 0x3E1FA20
	|-List<BeforeRenderHelper.OrderBlock>..ctor
	|
	|-RVA: 0x3E22940 Offset: 0x3E22A41 VA: 0x3E22940
	|-List<Camera.RenderRequest>..ctor
	|
	|-RVA: 0x3E25B70 Offset: 0x3E25C71 VA: 0x3E25B70
	|-List<CameraState.CustomBlendable>..ctor
	|
	|-RVA: 0x3E28A90 Offset: 0x3E28B91 VA: 0x3E28A90
	|-List<CinemachineClearShot.Pair>..ctor
	|
	|-RVA: 0x3E2B8A0 Offset: 0x3E2B9A1 VA: 0x3E2B8A0
	|-List<CinemachineStateDrivenCamera.HashPair>..ctor
	|
	|-RVA: 0x3E2E6B0 Offset: 0x3E2E7B1 VA: 0x3E2E6B0
	|-List<DelayedActionManager.DelegateInfo>..ctor
	|
	|-RVA: 0x3E318D0 Offset: 0x3E319D1 VA: 0x3E318D0
	|-List<Detail.AsyncResultInt>..ctor
	|
	|-RVA: 0x3E34CC0 Offset: 0x3E34DC1 VA: 0x3E34CC0
	|-List<Detail.CppArray>..ctor
	|
	|-RVA: 0x3E37BA0 Offset: 0x3E37CA1 VA: 0x3E37BA0
	|-List<Detail.NotificationEventInt>..ctor
	|
	|-RVA: 0x3E5A350 Offset: 0x3E5A451 VA: 0x3E5A350
	|-List<DragonRideTargetGroup.ChainParam>..ctor
	|
	|-RVA: 0x3E5D270 Offset: 0x3E5D371 VA: 0x3E5D270
	|-List<GmapPathAdjuster.TargetModel>..ctor
	|
	|-RVA: 0x3E60480 Offset: 0x3E60581 VA: 0x3E60480
	|-List<GmapSpotAdjuster.TargetModel>..ctor
	|
	|-RVA: 0x3E63690 Offset: 0x3E63791 VA: 0x3E63690
	|-List<HubFastTravel.Location>..ctor
	|
	|-RVA: 0x3E668A0 Offset: 0x3E669A1 VA: 0x3E668A0
	|-List<HubLensFlare.Flare>..ctor
	|
	|-RVA: 0x3E69CE0 Offset: 0x3E69DE1 VA: 0x3E69CE0
	|-List<InventoryPoolItemMenuContent.KindBgNameClass>..ctor
	|
	|-RVA: 0x3E6CC00 Offset: 0x3E6CD01 VA: 0x3E6CC00
	|-List<Map.Pos>..ctor
	|
	|-RVA: 0x3E6FA10 Offset: 0x3E6FB11 VA: 0x3E6FA10
	|-List<MapImage.BackupTerrain>..ctor
	|
	|-RVA: 0x3E728F0 Offset: 0x3E729F1 VA: 0x3E728F0
	|-List<MapImageRange.Pos>..ctor
	|
	|-RVA: 0x3E75790 Offset: 0x3E75891 VA: 0x3E75790
	|-List<MapMind.Target>..ctor
	|
	|-RVA: 0x3D85390 Offset: 0x3D85491 VA: 0x3D85390
	|-List<MapPanelDebug.Entity>..ctor
	|
	|-RVA: 0x3D88570 Offset: 0x3D88671 VA: 0x3D88570
	|-List<NexRanking.Data>..ctor
	|
	|-RVA: 0x3D8B380 Offset: 0x3D8B481 VA: 0x3D8B380
	|-List<NexVersus.RatingData>..ctor
	|
	|-RVA: 0x3D8E260 Offset: 0x3D8E361 VA: 0x3D8E260
	|-List<PackedPlayModeBuildLogs.RuntimeBuildLog>..ctor
	|
	|-RVA: 0x3D91180 Offset: 0x3D91281 VA: 0x3D91180
	|-List<ParticleSystem.Particle>..ctor
	|
	|-RVA: 0x3D94530 Offset: 0x3D94631 VA: 0x3D94530
	|-List<RangeData.Offset>..ctor
	|
	|-RVA: 0x3D97340 Offset: 0x3D97441 VA: 0x3D97340
	|-List<RenderGraphDebugData.PassDebugData>..ctor
	|
	|-RVA: 0x3D9A560 Offset: 0x3D9A661 VA: 0x3D9A560
	|-List<RenderGraphDebugData.ResourceDebugData>..ctor
	|
	|-RVA: 0x3D9D930 Offset: 0x3D9DA31 VA: 0x3D9D930
	|-List<RingCleaningUnitSelectMenu.GodParam>..ctor
	|
	|-RVA: 0x3DA0850 Offset: 0x3DA0951 VA: 0x3DA0850
	|-List<ShadowUtility.Edge>..ctor
	|
	|-RVA: 0x3D130A0 Offset: 0x3D131A1 VA: 0x3D130A0
	|-List<SkillArray.Entity>..ctor
	|
	|-RVA: 0x3D15EB0 Offset: 0x3D15FB1 VA: 0x3D15EB0
	|-List<TexturePacker_JsonArray.Frame>..ctor
	|
	|-RVA: 0x3D19470 Offset: 0x3D19571 VA: 0x3D19470
	|-List<TimeNotificationBehaviour.NotificationEntry>..ctor
	|
	|-RVA: 0x3D1C6A0 Offset: 0x3D1C7A1 VA: 0x3D1C6A0
	|-List<UnitySynchronizationContext.WorkRequest>..ctor
	|
	|-RVA: 0x3D1F8B0 Offset: 0x3D1F9B1 VA: 0x3D1F8B0
	|-List<XmlSchemaObjectTable.XmlSchemaObjectEntry>..ctor
	|
	|-RVA: 0x3D227D0 Offset: 0x3D228D1 VA: 0x3D227D0
	|-List<AssetBundleBuildMap.AssetBundleEntry.AssetPathString>..ctor
	|
	|-RVA: 0x3D256F0 Offset: 0x3D257F1 VA: 0x3D256F0
	|-List<Detail.DataStore.DataStoreChangeMetaParamInt>..ctor
	|
	|-RVA: 0x3D28B10 Offset: 0x3D28C11 VA: 0x3D28B10
	|-List<Detail.DataStore.DataStoreDeleteParamInt>..ctor
	|
	|-RVA: 0x3D2B9F0 Offset: 0x3D2BAF1 VA: 0x3D2B9F0
	|-List<Detail.DataStore.DataStoreGetMetaParamInt>..ctor
	|
	|-RVA: 0x3D2ED90 Offset: 0x3D2EE91 VA: 0x3D2ED90
	|-List<Detail.DataStore.DataStoreMetaInfoInt>..ctor
	|
	|-RVA: 0x3CF35D0 Offset: 0x3CF36D1 VA: 0x3CF35D0
	|-List<Detail.DataStore.DataStorePasswordInfoInt>..ctor
	|
	|-RVA: 0x3CF67B0 Offset: 0x3CF68B1 VA: 0x3CF67B0
	|-List<Detail.DataStore.DataStorePersistenceInfoInt>..ctor
	|
	|-RVA: 0x3CF9990 Offset: 0x3CF9A91 VA: 0x3CF9990
	|-List<Detail.DataStore.DataStorePreparePostParamInt>..ctor
	|
	|-RVA: 0x3CFCD40 Offset: 0x3CFCE41 VA: 0x3CFCD40
	|-List<Detail.DataStore.DataStoreRateObjectParamInt>..ctor
	|
	|-RVA: 0x3CFFC20 Offset: 0x3CFFD21 VA: 0x3CFFC20
	|-List<Detail.DataStore.DataStoreRatingInitParamInt>..ctor
	|
	|-RVA: 0x3D02E10 Offset: 0x3D02F11 VA: 0x3D02E10
	|-List<Detail.DataStore.DataStoreRatingTargetInt>..ctor
	|
	|-RVA: 0x3D05CF0 Offset: 0x3D05DF1 VA: 0x3D05CF0
	|-List<Detail.Ranking.RankingCachedResultInt>..ctor
	|
	|-RVA: 0x3D092D0 Offset: 0x3D093D1 VA: 0x3D092D0
	|-List<Detail.Ranking.RankingOrderParamInt>..ctor
	|
	|-RVA: 0x3D0C1B0 Offset: 0x3D0C2B1 VA: 0x3D0C1B0
	|-List<Detail.Ranking.RankingRankDataInt>..ctor
	|
	|-RVA: 0x3D0F730 Offset: 0x3D0F831 VA: 0x3D0F730
	|-List<Detail.Ranking2.Ranking2ChartInfoInt>..ctor
	|
	|-RVA: 0x3D66130 Offset: 0x3D66231 VA: 0x3D66130
	|-List<Detail.Ranking2.Ranking2RankDataInt>..ctor
	|
	|-RVA: 0x3D696B0 Offset: 0x3D697B1 VA: 0x3D696B0
	|-List<Detail.Ranking2.Ranking2ScoreDataInt>..ctor
	|
	|-RVA: 0x3D6C590 Offset: 0x3D6C691 VA: 0x3D6C590
	|-List<Detail.Screening.ScreeningContextInfoInt>..ctor
	|
	|-RVA: 0x3D6F780 Offset: 0x3D6F881 VA: 0x3D6F780
	|-List<Detail.Subscriber.SubscriberContentInt>..ctor
	|
	|-RVA: 0x3D72F50 Offset: 0x3D73051 VA: 0x3D72F50
	|-List<Detail.Subscriber.SubscriberGetContentParamInt>..ctor
	|
	|-RVA: 0x3D76130 Offset: 0x3D76231 VA: 0x3D76130
	|-List<Detail.Subscriber.SubscriberUserStatusInfoInt>..ctor
	|
	|-RVA: 0x3D794D0 Offset: 0x3D795D1 VA: 0x3D794D0
	|-List<Detail.Subscriber.SubscriberUserStatusParamInt>..ctor
	|
	|-RVA: 0x3D7C6B0 Offset: 0x3D7C7B1 VA: 0x3D7C6B0
	|-List<Detail.Utility.IntegerSettings>..ctor
	|
	|-RVA: 0x3D7F4C0 Offset: 0x3D7F5C1 VA: 0x3D7F4C0
	|-List<Detail.Utility.UniqueIdInfoInt>..ctor
	|
	|-RVA: 0x3D823A0 Offset: 0x3D824A1 VA: 0x3D823A0
	|-List<MapHistory.Rewind.LatestInspectorData>..ctor
	|
	|-RVA: 0x305E660 Offset: 0x305E761 VA: 0x305E660
	|-List<MapHistory.Rewind.WorkTerrainData>..ctor
	|
	|-RVA: 0x3061650 Offset: 0x3061751 VA: 0x3061650
	|-List<MapSkill.AroundCalculator.Result>..ctor
	|
	|-RVA: 0x3064570 Offset: 0x3064671 VA: 0x3064570
	|-List<TargetPositionCache.CacheCurve.Item>..ctor
	|
	|-RVA: 0x30678F0 Offset: 0x30679F1 VA: 0x30678F0
	|-List<TargetPositionCache.CacheEntry.RecordingItem>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(int capacity) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3B0A340 Offset: 0x3B0A441 VA: 0x3B0A340
	|-List<IntervalTree.Entry<object>>..ctor
	|
	|-RVA: 0x3B0D550 Offset: 0x3B0D651 VA: 0x3B0D550
	|-List<KeyValuePair<DateTime, object>>..ctor
	|-List<KeyValuePair<DateTime, TimeType>>..ctor
	|
	|-RVA: 0x3B10470 Offset: 0x3B10571 VA: 0x3B10470
	|-List<KeyValuePair<int, object>>..ctor
	|
	|-RVA: 0x3B13390 Offset: 0x3B13491 VA: 0x3B13390
	|-List<KeyValuePair<object, ValueTuple<int, DateTime, object>>>..ctor
	|
	|-RVA: 0x3B165B0 Offset: 0x3B166B1 VA: 0x3B165B0
	|-List<KeyValuePair<object, object>>..ctor
	|
	|-RVA: 0x3E103E0 Offset: 0x3E104E1 VA: 0x3E103E0
	|-List<List<NexVersus.RatingData>>..ctor
	|-List<Animator>..ctor
	|-List<BasicMenuItem>..ctor
	|-List<BattleInfoSide>..ctor
	|-List<ChapterData>..ctor
	|-List<Character>..ctor
	|-List<CharacterCollision>..ctor
	|-List<Collider>..ctor
	|-List<CookData>..ctor
	|-List<DisposData>..ctor
	|-List<DynValue>..ctor
	|-List<EncountUnitData>..ctor
	|-List<ExceptionDispatchInfo>..ctor
	|-List<FoodstuffData>..ctor
	|-List<ForceProvider>..ctor
	|-List<FriendListData>..ctor
	|-List<GameObject>..ctor
	|-List<GodUnit>..ctor
	|-List<HelpItemList>..ctor
	|-List<HubAccess>..ctor
	|-List<IDisposable>..ctor
	|-List<IMarker>..ctor
	|-List<IResourceLocation>..ctor
	|-List<IResourceLocator>..ctor
	|-List<Image>..ctor
	|-List<ItemData>..ctor
	|-List<MapBackup>..ctor
	|-List<MapCollision>..ctor
	|-List<MapEditorObjectData>..ctor
	|-List<MapInspector>..ctor
	|-List<MapObject>..ctor
	|-List<Material>..ctor
	|-List<MethodBase>..ctor
	|-List<MethodInfo>..ctor
	|-List<Module>..ctor
	|-List<object>..ctor
	|-List<ParameterExpression>..ctor
	|-List<PokeInspector>..ctor
	|-List<RegexNode>..ctor
	|-List<RelayServerMetaData>..ctor
	|-List<RenderGraphPass>..ctor
	|-List<Renderer>..ctor
	|-List<RuntimeElement>..ctor
	|-List<RuntimeType>..ctor
	|-List<ScriptableObject>..ctor
	|-List<ScriptableRenderPass>..ctor
	|-List<ScriptableRendererFeature>..ctor
	|-List<SkillData>..ctor
	|-List<SortieEntrustStockData>..ctor
	|-List<SortieEntrustUnitData>..ctor
	|-List<SpringCollider>..ctor
	|-List<string>..ctor
	|-List<TMP_FontAsset>..ctor
	|-List<TMP_GlyphPairAdjustmentRecord>..ctor
	|-List<TMP_Style>..ctor
	|-List<TimelineClip>..ctor
	|-List<Timer>..ctor
	|-List<TipsData>..ctor
	|-List<TrackAsset>..ctor
	|-List<Transform>..ctor
	|-List<Type>..ctor
	|-List<Unit>..ctor
	|-List<UnitItem>..ctor
	|-List<UnitRelianceMapResult>..ctor
	|-List<UnitRing>..ctor
	|-List<VersusServerCasualMetaData>..ctor
	|-List<VersusServerRankedMetaData>..ctor
	|-List<WatchItem>..ctor
	|-List<AIInterruptAttack.Candidate>..ctor
	|-List<AddressablesImpl.ResourceLocatorInfo>..ctor
	|-List<AdhocAssetLoader.Asset>..ctor
	|-List<DishAllMenuContent.HistoryObject>..ctor
	|-List<DishSelectMenuCategoryContent.CategoryObject>..ctor
	|-List<DynamicsSetup.ParseMessage>..ctor
	|-List<GmapLineRenderer.LinePoint>..ctor
	|-List<MapDispos.ActualData>..ctor
	|-List<MapDispos.Pos>..ctor
	|-List<MapEditHistory.MapEditCommand>..ctor
	|-List<MapImageTerrain.MinimapInfo>..ctor
	|-List<MapOverlap.Data>..ctor
	|-List<MapTarget.Data>..ctor
	|-List<MonoChunkStream.Chunk>..ctor
	|-List<ProfileCard.FreeStamp>..ctor
	|-List<RegexCharClass.SingleRange>..ctor
	|-List<SortieEntrustUnitData.WeaponKindExp>..ctor
	|-List<SpringBoneSerialization.PivotSerializer>..ctor
	|-List<SpringBoneSerialization.SpringBoneSerializer>..ctor
	|-List<SpringColliderSerialization.IColliderSerializer>..ctor
	|-List<SpringColliderSerialization.TransformSerializer>..ctor
	|-List<TextRecordParsing.Record>..ctor
	|-List<RelayCompletionAwardData.CalcResult.Item>..ctor
	|
	|-RVA: 0x3B194D0 Offset: 0x3B195D1 VA: 0x3B194D0
	|-List<CommonBattleSequence.Reliance<object>>..ctor
	|
	|-RVA: 0x3B1C6E0 Offset: 0x3B1C7E1 VA: 0x3B1C6E0
	|-List<RenderGraphResourcePool.ResourceLogInfo<object>>..ctor
	|
	|-RVA: 0x3B1F600 Offset: 0x3B1F701 VA: 0x3B1F600
	|-List<ValueTuple<int, object>>..ctor
	|
	|-RVA: 0x3DE0290 Offset: 0x3DE0391 VA: 0x3DE0290
	|-List<ValueTuple<Int32Enum, int>>..ctor
	|
	|-RVA: 0x3DE30A0 Offset: 0x3DE31A1 VA: 0x3DE30A0
	|-List<ValueTuple<object, ValueTuple<object, int>>>..ctor
	|
	|-RVA: 0x3DE62B0 Offset: 0x3DE63B1 VA: 0x3DE62B0
	|-List<ValueTuple<object, int>>..ctor
	|
	|-RVA: 0x3DE91D0 Offset: 0x3DE92D1 VA: 0x3DE91D0
	|-List<ValueTuple<Vector3, float>>..ctor
	|
	|-RVA: 0x3DEC1D0 Offset: 0x3DEC2D1 VA: 0x3DEC1D0
	|-List<ValueTuple<object, Int32Enum, int>>..ctor
	|
	|-RVA: 0x3DEF0F0 Offset: 0x3DEF1F1 VA: 0x3DEF0F0
	|-List<ValueTuple<object, int, int, int>>..ctor
	|
	|-RVA: 0x3DF2300 Offset: 0x3DF2401 VA: 0x3DF2300
	|-List<AnimatorClipInfo>..ctor
	|
	|-RVA: 0x3DF5110 Offset: 0x3DF5211 VA: 0x3DF5110
	|-List<AsyncOperationHandle>..ctor
	|
	|-RVA: 0x3DF8320 Offset: 0x3DF8421 VA: 0x3DF8320
	|-List<BoneWeight>..ctor
	|
	|-RVA: 0x3DFB510 Offset: 0x3DFB611 VA: 0x3DFB510
	|-List<bool>..ctor
	|
	|-RVA: 0x3E78A70 Offset: 0x3E78B71 VA: 0x3E78A70
	|-List<byte>..ctor
	|
	|-RVA: 0x3E7B880 Offset: 0x3E7B981 VA: 0x3E7B880
	|-List<CameraInfo>..ctor
	|
	|-RVA: 0x3E7E7A0 Offset: 0x3E7E8A1 VA: 0x3E7E7A0
	|-List<char>..ctor
	|
	|-RVA: 0x3E815A0 Offset: 0x3E816A1 VA: 0x3E815A0
	|-List<Color>..ctor
	|
	|-RVA: 0x3E845A0 Offset: 0x3E846A1 VA: 0x3E845A0
	|-List<Color32>..ctor
	|
	|-RVA: 0x3E873B0 Offset: 0x3E874B1 VA: 0x3E873B0
	|-List<ConstraintSource>..ctor
	|
	|-RVA: 0x3E8A2D0 Offset: 0x3E8A3D1 VA: 0x3E8A2D0
	|-List<ContourVertex>..ctor
	|
	|-RVA: 0x3E8D4E0 Offset: 0x3E8D5E1 VA: 0x3E8D4E0
	|-List<DataStoreRatingInfo>..ctor
	|
	|-RVA: 0x3E906C0 Offset: 0x3E907C1 VA: 0x3E906C0
	|-List<DataStoreResult>..ctor
	|
	|-RVA: 0x3E934D0 Offset: 0x3E935D1 VA: 0x3E934D0
	|-List<DateTime>..ctor
	|
	|-RVA: 0x3E962E0 Offset: 0x3E963E1 VA: 0x3E962E0
	|-List<DateTimeOffset>..ctor
	|
	|-RVA: 0x3E991C0 Offset: 0x3E992C1 VA: 0x3E991C0
	|-List<Decimal>..ctor
	|
	|-RVA: 0x3E9C0A0 Offset: 0x3E9C1A1 VA: 0x3E9C0A0
	|-List<DiagnosticEvent>..ctor
	|
	|-RVA: 0x3E9F4E0 Offset: 0x3E9F5E1 VA: 0x3E9F4E0
	|-List<double>..ctor
	|
	|-RVA: 0x3EA2300 Offset: 0x3EA2401 VA: 0x3EA2300
	|-List<Friend>..ctor
	|
	|-RVA: 0x3EA5690 Offset: 0x3EA5791 VA: 0x3EA5690
	|-List<GlyphRect>..ctor
	|
	|-RVA: 0x3EA8570 Offset: 0x3EA8671 VA: 0x3EA8570
	|-List<short>..ctor
	|
	|-RVA: 0x3EAB370 Offset: 0x3EAB471 VA: 0x3EAB370
	|-List<int>..ctor
	|
	|-RVA: 0x3EAE170 Offset: 0x3EAE271 VA: 0x3EAE170
	|-List<Int32Enum>..ctor
	|-List<ParticleSystemVertexStream>..ctor
	|
	|-RVA: 0x3EB0F70 Offset: 0x3EB1071 VA: 0x3EB0F70
	|-List<long>..ctor
	|
	|-RVA: 0x3DFE340 Offset: 0x3DFE441 VA: 0x3DFE340
	|-List<IntPtr>..ctor
	|
	|-RVA: 0x3E01140 Offset: 0x3E01241 VA: 0x3E01140
	|-List<InterpretedFrameInfo>..ctor
	|
	|-RVA: 0x3E04060 Offset: 0x3E04161 VA: 0x3E04060
	|-List<IntervalTreeNode>..ctor
	|
	|-RVA: 0x3E07240 Offset: 0x3E07341 VA: 0x3E07240
	|-List<LengthLimitProperties>..ctor
	|
	|-RVA: 0x3E0A050 Offset: 0x3E0A151 VA: 0x3E0A050
	|-List<MapPos>..ctor
	|
	|-RVA: 0x3E0CE60 Offset: 0x3E0CF61 VA: 0x3E0CE60
	|-List<Matrix4x4>..ctor
	|
	|-RVA: 0x3E131A0 Offset: 0x3E132A1 VA: 0x3E131A0
	|-List<ObjectInitializationData>..ctor
	|
	|-RVA: 0x3E165E0 Offset: 0x3E166E1 VA: 0x3E165E0
	|-List<PlayableBinding>..ctor
	|
	|-RVA: 0x3E19800 Offset: 0x3E19901 VA: 0x3E19800
	|-List<PlayerLoopSystem>..ctor
	|
	|-RVA: 0x3DA3CA0 Offset: 0x3DA3DA1 VA: 0x3DA3CA0
	|-List<PlayerLoopSystemInternal>..ctor
	|
	|-RVA: 0x3DA7070 Offset: 0x3DA7171 VA: 0x3DA7070
	|-List<RangePositionInfo>..ctor
	|
	|-RVA: 0x3DA9F90 Offset: 0x3DAA091 VA: 0x3DA9F90
	|-List<Ranking2ChartInfoInput>..ctor
	|
	|-RVA: 0x3DACDA0 Offset: 0x3DACEA1 VA: 0x3DACDA0
	|-List<RaycastHit2D>..ctor
	|
	|-RVA: 0x3DB01C0 Offset: 0x3DB02C1 VA: 0x3DB01C0
	|-List<RaycastResult>..ctor
	|
	|-RVA: 0x3DB39D0 Offset: 0x3DB3AD1 VA: 0x3DB39D0
	|-List<Rect>..ctor
	|
	|-RVA: 0x3DB69D0 Offset: 0x3DB6AD1 VA: 0x3DB69D0
	|-List<RendererListHandle>..ctor
	|
	|-RVA: 0x3DB97E0 Offset: 0x3DB98E1 VA: 0x3DB97E0
	|-List<ResourceHandle>..ctor
	|
	|-RVA: 0x3DBC5F0 Offset: 0x3DBC6F1 VA: 0x3DBC5F0
	|-List<sbyte>..ctor
	|
	|-RVA: 0x3DBF400 Offset: 0x3DBF501 VA: 0x3DBF400
	|-List<ShaderTagId>..ctor
	|
	|-RVA: 0x3E3B060 Offset: 0x3E3B161 VA: 0x3E3B060
	|-List<float>..ctor
	|
	|-RVA: 0x3E3DE80 Offset: 0x3E3DF81 VA: 0x3E3DE80
	|-List<SphericalHarmonicsL2>..ctor
	|
	|-RVA: 0x3E41B60 Offset: 0x3E41C61 VA: 0x3E41B60
	|-List<SubMeshDescriptor>..ctor
	|
	|-RVA: 0x3E44F50 Offset: 0x3E45051 VA: 0x3E44F50
	|-List<TablePair>..ctor
	|
	|-RVA: 0x3E47E70 Offset: 0x3E47F71 VA: 0x3E47E70
	|-List<TimeSpan>..ctor
	|
	|-RVA: 0x3E4AC80 Offset: 0x3E4AD81 VA: 0x3E4AC80
	|-List<UICharInfo>..ctor
	|
	|-RVA: 0x3E4DC60 Offset: 0x3E4DD61 VA: 0x3E4DC60
	|-List<UILineInfo>..ctor
	|
	|-RVA: 0x3E50B40 Offset: 0x3E50C41 VA: 0x3E50B40
	|-List<UIVertex>..ctor
	|
	|-RVA: 0x3E54820 Offset: 0x3E54921 VA: 0x3E54820
	|-List<ushort>..ctor
	|
	|-RVA: 0x3E57620 Offset: 0x3E57721 VA: 0x3E57620
	|-List<uint>..ctor
	|
	|-RVA: 0x3DC2210 Offset: 0x3DC2311 VA: 0x3DC2210
	|-List<ulong>..ctor
	|
	|-RVA: 0x3DC5010 Offset: 0x3DC5111 VA: 0x3DC5010
	|-List<Vector2>..ctor
	|
	|-RVA: 0x3DC7EE0 Offset: 0x3DC7FE1 VA: 0x3DC7EE0
	|-List<Vector3>..ctor
	|
	|-RVA: 0x3DCAEC0 Offset: 0x3DCAFC1 VA: 0x3DCAEC0
	|-List<Vector4>..ctor
	|
	|-RVA: 0x3DCDEC0 Offset: 0x3DCDFC1 VA: 0x3DCDEC0
	|-List<VertexAttributeDescriptor>..ctor
	|
	|-RVA: 0x3DD0DA0 Offset: 0x3DD0EA1 VA: 0x3DD0DA0
	|-List<X509ChainStatus>..ctor
	|
	|-RVA: 0x3DD3CC0 Offset: 0x3DD3DC1 VA: 0x3DD3CC0
	|-List<XRView>..ctor
	|
	|-RVA: 0x3DD70B0 Offset: 0x3DD71B1 VA: 0x3DD70B0
	|-List<AmiiboSequence.GainItemData>..ctor
	|
	|-RVA: 0x3DD9FD0 Offset: 0x3DDA0D1 VA: 0x3DD9FD0
	|-List<AnimationOutputWeightProcessor.WeightInfo>..ctor
	|
	|-RVA: 0x3DDD370 Offset: 0x3DDD471 VA: 0x3DDD370
	|-List<ArenaOrderSequence.GodInfo>..ctor
	|
	|-RVA: 0x3E1CBD0 Offset: 0x3E1CCD1 VA: 0x3E1CBD0
	|-List<BattleInfo.SupportData>..ctor
	|
	|-RVA: 0x3E1FAF0 Offset: 0x3E1FBF1 VA: 0x3E1FAF0
	|-List<BeforeRenderHelper.OrderBlock>..ctor
	|
	|-RVA: 0x3E22A10 Offset: 0x3E22B11 VA: 0x3E22A10
	|-List<Camera.RenderRequest>..ctor
	|
	|-RVA: 0x3E25C40 Offset: 0x3E25D41 VA: 0x3E25C40
	|-List<CameraState.CustomBlendable>..ctor
	|
	|-RVA: 0x3E28B60 Offset: 0x3E28C61 VA: 0x3E28B60
	|-List<CinemachineClearShot.Pair>..ctor
	|
	|-RVA: 0x3E2B970 Offset: 0x3E2BA71 VA: 0x3E2B970
	|-List<CinemachineStateDrivenCamera.HashPair>..ctor
	|
	|-RVA: 0x3E2E780 Offset: 0x3E2E881 VA: 0x3E2E780
	|-List<DelayedActionManager.DelegateInfo>..ctor
	|
	|-RVA: 0x3E319A0 Offset: 0x3E31AA1 VA: 0x3E319A0
	|-List<Detail.AsyncResultInt>..ctor
	|
	|-RVA: 0x3E34D90 Offset: 0x3E34E91 VA: 0x3E34D90
	|-List<Detail.CppArray>..ctor
	|
	|-RVA: 0x3E37C70 Offset: 0x3E37D71 VA: 0x3E37C70
	|-List<Detail.NotificationEventInt>..ctor
	|
	|-RVA: 0x3E5A420 Offset: 0x3E5A521 VA: 0x3E5A420
	|-List<DragonRideTargetGroup.ChainParam>..ctor
	|
	|-RVA: 0x3E5D340 Offset: 0x3E5D441 VA: 0x3E5D340
	|-List<GmapPathAdjuster.TargetModel>..ctor
	|
	|-RVA: 0x3E60550 Offset: 0x3E60651 VA: 0x3E60550
	|-List<GmapSpotAdjuster.TargetModel>..ctor
	|
	|-RVA: 0x3E63760 Offset: 0x3E63861 VA: 0x3E63760
	|-List<HubFastTravel.Location>..ctor
	|
	|-RVA: 0x3E66970 Offset: 0x3E66A71 VA: 0x3E66970
	|-List<HubLensFlare.Flare>..ctor
	|
	|-RVA: 0x3E69DB0 Offset: 0x3E69EB1 VA: 0x3E69DB0
	|-List<InventoryPoolItemMenuContent.KindBgNameClass>..ctor
	|
	|-RVA: 0x3E6CCD0 Offset: 0x3E6CDD1 VA: 0x3E6CCD0
	|-List<Map.Pos>..ctor
	|
	|-RVA: 0x3E6FAE0 Offset: 0x3E6FBE1 VA: 0x3E6FAE0
	|-List<MapImage.BackupTerrain>..ctor
	|
	|-RVA: 0x3E729C0 Offset: 0x3E72AC1 VA: 0x3E729C0
	|-List<MapImageRange.Pos>..ctor
	|
	|-RVA: 0x3E75860 Offset: 0x3E75961 VA: 0x3E75860
	|-List<MapMind.Target>..ctor
	|
	|-RVA: 0x3D85460 Offset: 0x3D85561 VA: 0x3D85460
	|-List<MapPanelDebug.Entity>..ctor
	|
	|-RVA: 0x3D88640 Offset: 0x3D88741 VA: 0x3D88640
	|-List<NexRanking.Data>..ctor
	|
	|-RVA: 0x3D8B450 Offset: 0x3D8B551 VA: 0x3D8B450
	|-List<NexVersus.RatingData>..ctor
	|
	|-RVA: 0x3D8E330 Offset: 0x3D8E431 VA: 0x3D8E330
	|-List<PackedPlayModeBuildLogs.RuntimeBuildLog>..ctor
	|
	|-RVA: 0x3D91250 Offset: 0x3D91351 VA: 0x3D91250
	|-List<ParticleSystem.Particle>..ctor
	|
	|-RVA: 0x3D94600 Offset: 0x3D94701 VA: 0x3D94600
	|-List<RangeData.Offset>..ctor
	|
	|-RVA: 0x3D97410 Offset: 0x3D97511 VA: 0x3D97410
	|-List<RenderGraphDebugData.PassDebugData>..ctor
	|
	|-RVA: 0x3D9A630 Offset: 0x3D9A731 VA: 0x3D9A630
	|-List<RenderGraphDebugData.ResourceDebugData>..ctor
	|
	|-RVA: 0x3D9DA00 Offset: 0x3D9DB01 VA: 0x3D9DA00
	|-List<RingCleaningUnitSelectMenu.GodParam>..ctor
	|
	|-RVA: 0x3DA0920 Offset: 0x3DA0A21 VA: 0x3DA0920
	|-List<ShadowUtility.Edge>..ctor
	|
	|-RVA: 0x3D13170 Offset: 0x3D13271 VA: 0x3D13170
	|-List<SkillArray.Entity>..ctor
	|
	|-RVA: 0x3D15F80 Offset: 0x3D16081 VA: 0x3D15F80
	|-List<TexturePacker_JsonArray.Frame>..ctor
	|
	|-RVA: 0x3D19540 Offset: 0x3D19641 VA: 0x3D19540
	|-List<TimeNotificationBehaviour.NotificationEntry>..ctor
	|
	|-RVA: 0x3D1C770 Offset: 0x3D1C871 VA: 0x3D1C770
	|-List<UnitySynchronizationContext.WorkRequest>..ctor
	|
	|-RVA: 0x3D1F980 Offset: 0x3D1FA81 VA: 0x3D1F980
	|-List<XmlSchemaObjectTable.XmlSchemaObjectEntry>..ctor
	|
	|-RVA: 0x3D228A0 Offset: 0x3D229A1 VA: 0x3D228A0
	|-List<AssetBundleBuildMap.AssetBundleEntry.AssetPathString>..ctor
	|
	|-RVA: 0x3D257C0 Offset: 0x3D258C1 VA: 0x3D257C0
	|-List<Detail.DataStore.DataStoreChangeMetaParamInt>..ctor
	|
	|-RVA: 0x3D28BE0 Offset: 0x3D28CE1 VA: 0x3D28BE0
	|-List<Detail.DataStore.DataStoreDeleteParamInt>..ctor
	|
	|-RVA: 0x3D2BAC0 Offset: 0x3D2BBC1 VA: 0x3D2BAC0
	|-List<Detail.DataStore.DataStoreGetMetaParamInt>..ctor
	|
	|-RVA: 0x3D2EE60 Offset: 0x3D2EF61 VA: 0x3D2EE60
	|-List<Detail.DataStore.DataStoreMetaInfoInt>..ctor
	|
	|-RVA: 0x3CF36A0 Offset: 0x3CF37A1 VA: 0x3CF36A0
	|-List<Detail.DataStore.DataStorePasswordInfoInt>..ctor
	|
	|-RVA: 0x3CF6880 Offset: 0x3CF6981 VA: 0x3CF6880
	|-List<Detail.DataStore.DataStorePersistenceInfoInt>..ctor
	|
	|-RVA: 0x3CF9A60 Offset: 0x3CF9B61 VA: 0x3CF9A60
	|-List<Detail.DataStore.DataStorePreparePostParamInt>..ctor
	|
	|-RVA: 0x3CFCE10 Offset: 0x3CFCF11 VA: 0x3CFCE10
	|-List<Detail.DataStore.DataStoreRateObjectParamInt>..ctor
	|
	|-RVA: 0x3CFFCF0 Offset: 0x3CFFDF1 VA: 0x3CFFCF0
	|-List<Detail.DataStore.DataStoreRatingInitParamInt>..ctor
	|
	|-RVA: 0x3D02EE0 Offset: 0x3D02FE1 VA: 0x3D02EE0
	|-List<Detail.DataStore.DataStoreRatingTargetInt>..ctor
	|
	|-RVA: 0x3D05DC0 Offset: 0x3D05EC1 VA: 0x3D05DC0
	|-List<Detail.Ranking.RankingCachedResultInt>..ctor
	|
	|-RVA: 0x3D093A0 Offset: 0x3D094A1 VA: 0x3D093A0
	|-List<Detail.Ranking.RankingOrderParamInt>..ctor
	|
	|-RVA: 0x3D0C280 Offset: 0x3D0C381 VA: 0x3D0C280
	|-List<Detail.Ranking.RankingRankDataInt>..ctor
	|
	|-RVA: 0x3D0F800 Offset: 0x3D0F901 VA: 0x3D0F800
	|-List<Detail.Ranking2.Ranking2ChartInfoInt>..ctor
	|
	|-RVA: 0x3D66200 Offset: 0x3D66301 VA: 0x3D66200
	|-List<Detail.Ranking2.Ranking2RankDataInt>..ctor
	|
	|-RVA: 0x3D69780 Offset: 0x3D69881 VA: 0x3D69780
	|-List<Detail.Ranking2.Ranking2ScoreDataInt>..ctor
	|
	|-RVA: 0x3D6C660 Offset: 0x3D6C761 VA: 0x3D6C660
	|-List<Detail.Screening.ScreeningContextInfoInt>..ctor
	|
	|-RVA: 0x3D6F850 Offset: 0x3D6F951 VA: 0x3D6F850
	|-List<Detail.Subscriber.SubscriberContentInt>..ctor
	|
	|-RVA: 0x3D73020 Offset: 0x3D73121 VA: 0x3D73020
	|-List<Detail.Subscriber.SubscriberGetContentParamInt>..ctor
	|
	|-RVA: 0x3D76200 Offset: 0x3D76301 VA: 0x3D76200
	|-List<Detail.Subscriber.SubscriberUserStatusInfoInt>..ctor
	|
	|-RVA: 0x3D795A0 Offset: 0x3D796A1 VA: 0x3D795A0
	|-List<Detail.Subscriber.SubscriberUserStatusParamInt>..ctor
	|
	|-RVA: 0x3D7C780 Offset: 0x3D7C881 VA: 0x3D7C780
	|-List<Detail.Utility.IntegerSettings>..ctor
	|
	|-RVA: 0x3D7F590 Offset: 0x3D7F691 VA: 0x3D7F590
	|-List<Detail.Utility.UniqueIdInfoInt>..ctor
	|
	|-RVA: 0x3D82470 Offset: 0x3D82571 VA: 0x3D82470
	|-List<MapHistory.Rewind.LatestInspectorData>..ctor
	|
	|-RVA: 0x305E730 Offset: 0x305E831 VA: 0x305E730
	|-List<MapHistory.Rewind.WorkTerrainData>..ctor
	|
	|-RVA: 0x3061720 Offset: 0x3061821 VA: 0x3061720
	|-List<MapSkill.AroundCalculator.Result>..ctor
	|
	|-RVA: 0x3064640 Offset: 0x3064741 VA: 0x3064640
	|-List<TargetPositionCache.CacheCurve.Item>..ctor
	|
	|-RVA: 0x30679C0 Offset: 0x3067AC1 VA: 0x30679C0
	|-List<TargetPositionCache.CacheEntry.RecordingItem>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(IEnumerable<T> collection) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3B0A460 Offset: 0x3B0A561 VA: 0x3B0A460
	|-List<IntervalTree.Entry<object>>..ctor
	|
	|-RVA: 0x3E10500 Offset: 0x3E10601 VA: 0x3E10500
	|-List<IObservable<Unit>>..ctor
	|-List<BasicMenuItem>..ctor
	|-List<DataStorePreparePostParam>..ctor
	|-List<DynValue>..ctor
	|-List<Exception>..ctor
	|-List<ExceptionDispatchInfo>..ctor
	|-List<HubDisposData>..ctor
	|-List<IAsyncLocal>..ctor
	|-List<IDisposable>..ctor
	|-List<IOverloadableMemberDescriptor>..ctor
	|-List<IResourceLocation>..ctor
	|-List<MovieDefineData>..ctor
	|-List<object>..ctor
	|-List<PhotographPauseData>..ctor
	|-List<RelayCompletionAwardData>..ctor
	|-List<Selectable>..ctor
	|-List<string>..ctor
	|-List<TimelineClip>..ctor
	|-List<TrackAsset>..ctor
	|-List<RelayUserData.EnteredBattle>..ctor
	|
	|-RVA: 0x3B0D670 Offset: 0x3B0D771 VA: 0x3B0D670
	|-List<KeyValuePair<DateTime, object>>..ctor
	|
	|-RVA: 0x3B10590 Offset: 0x3B10691 VA: 0x3B10590
	|-List<KeyValuePair<int, object>>..ctor
	|
	|-RVA: 0x3B134B0 Offset: 0x3B135B1 VA: 0x3B134B0
	|-List<KeyValuePair<object, ValueTuple<int, DateTime, object>>>..ctor
	|
	|-RVA: 0x3B166D0 Offset: 0x3B167D1 VA: 0x3B166D0
	|-List<KeyValuePair<object, object>>..ctor
	|
	|-RVA: 0x3B195F0 Offset: 0x3B196F1 VA: 0x3B195F0
	|-List<CommonBattleSequence.Reliance<object>>..ctor
	|
	|-RVA: 0x3B1C800 Offset: 0x3B1C901 VA: 0x3B1C800
	|-List<RenderGraphResourcePool.ResourceLogInfo<object>>..ctor
	|
	|-RVA: 0x3B1F720 Offset: 0x3B1F821 VA: 0x3B1F720
	|-List<ValueTuple<int, object>>..ctor
	|
	|-RVA: 0x3DE03B0 Offset: 0x3DE04B1 VA: 0x3DE03B0
	|-List<ValueTuple<Int32Enum, int>>..ctor
	|
	|-RVA: 0x3DE31C0 Offset: 0x3DE32C1 VA: 0x3DE31C0
	|-List<ValueTuple<object, ValueTuple<object, int>>>..ctor
	|
	|-RVA: 0x3DE63D0 Offset: 0x3DE64D1 VA: 0x3DE63D0
	|-List<ValueTuple<object, int>>..ctor
	|
	|-RVA: 0x3DE92F0 Offset: 0x3DE93F1 VA: 0x3DE92F0
	|-List<ValueTuple<Vector3, float>>..ctor
	|
	|-RVA: 0x3DEC2F0 Offset: 0x3DEC3F1 VA: 0x3DEC2F0
	|-List<ValueTuple<object, Int32Enum, int>>..ctor
	|
	|-RVA: 0x3DEF210 Offset: 0x3DEF311 VA: 0x3DEF210
	|-List<ValueTuple<object, int, int, int>>..ctor
	|
	|-RVA: 0x3DF2420 Offset: 0x3DF2521 VA: 0x3DF2420
	|-List<AnimatorClipInfo>..ctor
	|
	|-RVA: 0x3DF5230 Offset: 0x3DF5331 VA: 0x3DF5230
	|-List<AsyncOperationHandle>..ctor
	|
	|-RVA: 0x3DF8440 Offset: 0x3DF8541 VA: 0x3DF8440
	|-List<BoneWeight>..ctor
	|
	|-RVA: 0x3DFB630 Offset: 0x3DFB731 VA: 0x3DFB630
	|-List<bool>..ctor
	|
	|-RVA: 0x3E78B90 Offset: 0x3E78C91 VA: 0x3E78B90
	|-List<byte>..ctor
	|
	|-RVA: 0x3E7B9A0 Offset: 0x3E7BAA1 VA: 0x3E7B9A0
	|-List<CameraInfo>..ctor
	|
	|-RVA: 0x3E7E8C0 Offset: 0x3E7E9C1 VA: 0x3E7E8C0
	|-List<char>..ctor
	|
	|-RVA: 0x3E816C0 Offset: 0x3E817C1 VA: 0x3E816C0
	|-List<Color>..ctor
	|
	|-RVA: 0x3E846C0 Offset: 0x3E847C1 VA: 0x3E846C0
	|-List<Color32>..ctor
	|
	|-RVA: 0x3E874D0 Offset: 0x3E875D1 VA: 0x3E874D0
	|-List<ConstraintSource>..ctor
	|
	|-RVA: 0x3E8A3F0 Offset: 0x3E8A4F1 VA: 0x3E8A3F0
	|-List<ContourVertex>..ctor
	|
	|-RVA: 0x3E8D600 Offset: 0x3E8D701 VA: 0x3E8D600
	|-List<DataStoreRatingInfo>..ctor
	|
	|-RVA: 0x3E907E0 Offset: 0x3E908E1 VA: 0x3E907E0
	|-List<DataStoreResult>..ctor
	|
	|-RVA: 0x3E935F0 Offset: 0x3E936F1 VA: 0x3E935F0
	|-List<DateTime>..ctor
	|
	|-RVA: 0x3E96400 Offset: 0x3E96501 VA: 0x3E96400
	|-List<DateTimeOffset>..ctor
	|
	|-RVA: 0x3E992E0 Offset: 0x3E993E1 VA: 0x3E992E0
	|-List<Decimal>..ctor
	|
	|-RVA: 0x3E9C1C0 Offset: 0x3E9C2C1 VA: 0x3E9C1C0
	|-List<DiagnosticEvent>..ctor
	|
	|-RVA: 0x3E9F600 Offset: 0x3E9F701 VA: 0x3E9F600
	|-List<double>..ctor
	|
	|-RVA: 0x3EA2420 Offset: 0x3EA2521 VA: 0x3EA2420
	|-List<Friend>..ctor
	|
	|-RVA: 0x3EA57B0 Offset: 0x3EA58B1 VA: 0x3EA57B0
	|-List<GlyphRect>..ctor
	|
	|-RVA: 0x3EA8690 Offset: 0x3EA8791 VA: 0x3EA8690
	|-List<short>..ctor
	|
	|-RVA: 0x3EAB490 Offset: 0x3EAB591 VA: 0x3EAB490
	|-List<int>..ctor
	|
	|-RVA: 0x3EAE290 Offset: 0x3EAE391 VA: 0x3EAE290
	|-List<Int32Enum>..ctor
	|
	|-RVA: 0x3EB1090 Offset: 0x3EB1191 VA: 0x3EB1090
	|-List<long>..ctor
	|
	|-RVA: 0x3DFE460 Offset: 0x3DFE561 VA: 0x3DFE460
	|-List<IntPtr>..ctor
	|
	|-RVA: 0x3E01260 Offset: 0x3E01361 VA: 0x3E01260
	|-List<InterpretedFrameInfo>..ctor
	|
	|-RVA: 0x3E04180 Offset: 0x3E04281 VA: 0x3E04180
	|-List<IntervalTreeNode>..ctor
	|
	|-RVA: 0x3E07360 Offset: 0x3E07461 VA: 0x3E07360
	|-List<LengthLimitProperties>..ctor
	|
	|-RVA: 0x3E0A170 Offset: 0x3E0A271 VA: 0x3E0A170
	|-List<MapPos>..ctor
	|
	|-RVA: 0x3E0CF80 Offset: 0x3E0D081 VA: 0x3E0CF80
	|-List<Matrix4x4>..ctor
	|
	|-RVA: 0x3E132C0 Offset: 0x3E133C1 VA: 0x3E132C0
	|-List<ObjectInitializationData>..ctor
	|
	|-RVA: 0x3E16700 Offset: 0x3E16801 VA: 0x3E16700
	|-List<PlayableBinding>..ctor
	|
	|-RVA: 0x3E19920 Offset: 0x3E19A21 VA: 0x3E19920
	|-List<PlayerLoopSystem>..ctor
	|
	|-RVA: 0x3DA3DC0 Offset: 0x3DA3EC1 VA: 0x3DA3DC0
	|-List<PlayerLoopSystemInternal>..ctor
	|
	|-RVA: 0x3DA7190 Offset: 0x3DA7291 VA: 0x3DA7190
	|-List<RangePositionInfo>..ctor
	|
	|-RVA: 0x3DAA0B0 Offset: 0x3DAA1B1 VA: 0x3DAA0B0
	|-List<Ranking2ChartInfoInput>..ctor
	|
	|-RVA: 0x3DACEC0 Offset: 0x3DACFC1 VA: 0x3DACEC0
	|-List<RaycastHit2D>..ctor
	|
	|-RVA: 0x3DB02E0 Offset: 0x3DB03E1 VA: 0x3DB02E0
	|-List<RaycastResult>..ctor
	|
	|-RVA: 0x3DB3AF0 Offset: 0x3DB3BF1 VA: 0x3DB3AF0
	|-List<Rect>..ctor
	|
	|-RVA: 0x3DB6AF0 Offset: 0x3DB6BF1 VA: 0x3DB6AF0
	|-List<RendererListHandle>..ctor
	|
	|-RVA: 0x3DB9900 Offset: 0x3DB9A01 VA: 0x3DB9900
	|-List<ResourceHandle>..ctor
	|
	|-RVA: 0x3DBC710 Offset: 0x3DBC811 VA: 0x3DBC710
	|-List<sbyte>..ctor
	|
	|-RVA: 0x3DBF520 Offset: 0x3DBF621 VA: 0x3DBF520
	|-List<ShaderTagId>..ctor
	|
	|-RVA: 0x3E3B180 Offset: 0x3E3B281 VA: 0x3E3B180
	|-List<float>..ctor
	|
	|-RVA: 0x3E3DFA0 Offset: 0x3E3E0A1 VA: 0x3E3DFA0
	|-List<SphericalHarmonicsL2>..ctor
	|
	|-RVA: 0x3E41C80 Offset: 0x3E41D81 VA: 0x3E41C80
	|-List<SubMeshDescriptor>..ctor
	|
	|-RVA: 0x3E45070 Offset: 0x3E45171 VA: 0x3E45070
	|-List<TablePair>..ctor
	|
	|-RVA: 0x3E47F90 Offset: 0x3E48091 VA: 0x3E47F90
	|-List<TimeSpan>..ctor
	|
	|-RVA: 0x3E4ADA0 Offset: 0x3E4AEA1 VA: 0x3E4ADA0
	|-List<UICharInfo>..ctor
	|
	|-RVA: 0x3E4DD80 Offset: 0x3E4DE81 VA: 0x3E4DD80
	|-List<UILineInfo>..ctor
	|
	|-RVA: 0x3E50C60 Offset: 0x3E50D61 VA: 0x3E50C60
	|-List<UIVertex>..ctor
	|
	|-RVA: 0x3E54940 Offset: 0x3E54A41 VA: 0x3E54940
	|-List<ushort>..ctor
	|
	|-RVA: 0x3E57740 Offset: 0x3E57841 VA: 0x3E57740
	|-List<uint>..ctor
	|
	|-RVA: 0x3DC2330 Offset: 0x3DC2431 VA: 0x3DC2330
	|-List<ulong>..ctor
	|
	|-RVA: 0x3DC5130 Offset: 0x3DC5231 VA: 0x3DC5130
	|-List<Vector2>..ctor
	|
	|-RVA: 0x3DC8000 Offset: 0x3DC8101 VA: 0x3DC8000
	|-List<Vector3>..ctor
	|
	|-RVA: 0x3DCAFE0 Offset: 0x3DCB0E1 VA: 0x3DCAFE0
	|-List<Vector4>..ctor
	|
	|-RVA: 0x3DCDFE0 Offset: 0x3DCE0E1 VA: 0x3DCDFE0
	|-List<VertexAttributeDescriptor>..ctor
	|
	|-RVA: 0x3DD0EC0 Offset: 0x3DD0FC1 VA: 0x3DD0EC0
	|-List<X509ChainStatus>..ctor
	|
	|-RVA: 0x3DD3DE0 Offset: 0x3DD3EE1 VA: 0x3DD3DE0
	|-List<XRView>..ctor
	|
	|-RVA: 0x3DD71D0 Offset: 0x3DD72D1 VA: 0x3DD71D0
	|-List<AmiiboSequence.GainItemData>..ctor
	|
	|-RVA: 0x3DDA0F0 Offset: 0x3DDA1F1 VA: 0x3DDA0F0
	|-List<AnimationOutputWeightProcessor.WeightInfo>..ctor
	|
	|-RVA: 0x3DDD490 Offset: 0x3DDD591 VA: 0x3DDD490
	|-List<ArenaOrderSequence.GodInfo>..ctor
	|
	|-RVA: 0x3E1CCF0 Offset: 0x3E1CDF1 VA: 0x3E1CCF0
	|-List<BattleInfo.SupportData>..ctor
	|
	|-RVA: 0x3E1FC10 Offset: 0x3E1FD11 VA: 0x3E1FC10
	|-List<BeforeRenderHelper.OrderBlock>..ctor
	|
	|-RVA: 0x3E22B30 Offset: 0x3E22C31 VA: 0x3E22B30
	|-List<Camera.RenderRequest>..ctor
	|
	|-RVA: 0x3E25D60 Offset: 0x3E25E61 VA: 0x3E25D60
	|-List<CameraState.CustomBlendable>..ctor
	|
	|-RVA: 0x3E28C80 Offset: 0x3E28D81 VA: 0x3E28C80
	|-List<CinemachineClearShot.Pair>..ctor
	|
	|-RVA: 0x3E2BA90 Offset: 0x3E2BB91 VA: 0x3E2BA90
	|-List<CinemachineStateDrivenCamera.HashPair>..ctor
	|
	|-RVA: 0x3E2E8A0 Offset: 0x3E2E9A1 VA: 0x3E2E8A0
	|-List<DelayedActionManager.DelegateInfo>..ctor
	|
	|-RVA: 0x3E31AC0 Offset: 0x3E31BC1 VA: 0x3E31AC0
	|-List<Detail.AsyncResultInt>..ctor
	|
	|-RVA: 0x3E34EB0 Offset: 0x3E34FB1 VA: 0x3E34EB0
	|-List<Detail.CppArray>..ctor
	|
	|-RVA: 0x3E37D90 Offset: 0x3E37E91 VA: 0x3E37D90
	|-List<Detail.NotificationEventInt>..ctor
	|
	|-RVA: 0x3E5A540 Offset: 0x3E5A641 VA: 0x3E5A540
	|-List<DragonRideTargetGroup.ChainParam>..ctor
	|
	|-RVA: 0x3E5D460 Offset: 0x3E5D561 VA: 0x3E5D460
	|-List<GmapPathAdjuster.TargetModel>..ctor
	|
	|-RVA: 0x3E60670 Offset: 0x3E60771 VA: 0x3E60670
	|-List<GmapSpotAdjuster.TargetModel>..ctor
	|
	|-RVA: 0x3E63880 Offset: 0x3E63981 VA: 0x3E63880
	|-List<HubFastTravel.Location>..ctor
	|
	|-RVA: 0x3E66A90 Offset: 0x3E66B91 VA: 0x3E66A90
	|-List<HubLensFlare.Flare>..ctor
	|
	|-RVA: 0x3E69ED0 Offset: 0x3E69FD1 VA: 0x3E69ED0
	|-List<InventoryPoolItemMenuContent.KindBgNameClass>..ctor
	|
	|-RVA: 0x3E6CDF0 Offset: 0x3E6CEF1 VA: 0x3E6CDF0
	|-List<Map.Pos>..ctor
	|
	|-RVA: 0x3E6FC00 Offset: 0x3E6FD01 VA: 0x3E6FC00
	|-List<MapImage.BackupTerrain>..ctor
	|
	|-RVA: 0x3E72AE0 Offset: 0x3E72BE1 VA: 0x3E72AE0
	|-List<MapImageRange.Pos>..ctor
	|
	|-RVA: 0x3E75980 Offset: 0x3E75A81 VA: 0x3E75980
	|-List<MapMind.Target>..ctor
	|
	|-RVA: 0x3D85580 Offset: 0x3D85681 VA: 0x3D85580
	|-List<MapPanelDebug.Entity>..ctor
	|
	|-RVA: 0x3D88760 Offset: 0x3D88861 VA: 0x3D88760
	|-List<NexRanking.Data>..ctor
	|
	|-RVA: 0x3D8B570 Offset: 0x3D8B671 VA: 0x3D8B570
	|-List<NexVersus.RatingData>..ctor
	|
	|-RVA: 0x3D8E450 Offset: 0x3D8E551 VA: 0x3D8E450
	|-List<PackedPlayModeBuildLogs.RuntimeBuildLog>..ctor
	|
	|-RVA: 0x3D91370 Offset: 0x3D91471 VA: 0x3D91370
	|-List<ParticleSystem.Particle>..ctor
	|
	|-RVA: 0x3D94720 Offset: 0x3D94821 VA: 0x3D94720
	|-List<RangeData.Offset>..ctor
	|
	|-RVA: 0x3D97530 Offset: 0x3D97631 VA: 0x3D97530
	|-List<RenderGraphDebugData.PassDebugData>..ctor
	|
	|-RVA: 0x3D9A750 Offset: 0x3D9A851 VA: 0x3D9A750
	|-List<RenderGraphDebugData.ResourceDebugData>..ctor
	|
	|-RVA: 0x3D9DB20 Offset: 0x3D9DC21 VA: 0x3D9DB20
	|-List<RingCleaningUnitSelectMenu.GodParam>..ctor
	|
	|-RVA: 0x3DA0A40 Offset: 0x3DA0B41 VA: 0x3DA0A40
	|-List<ShadowUtility.Edge>..ctor
	|
	|-RVA: 0x3D13290 Offset: 0x3D13391 VA: 0x3D13290
	|-List<SkillArray.Entity>..ctor
	|
	|-RVA: 0x3D160A0 Offset: 0x3D161A1 VA: 0x3D160A0
	|-List<TexturePacker_JsonArray.Frame>..ctor
	|
	|-RVA: 0x3D19660 Offset: 0x3D19761 VA: 0x3D19660
	|-List<TimeNotificationBehaviour.NotificationEntry>..ctor
	|
	|-RVA: 0x3D1C890 Offset: 0x3D1C991 VA: 0x3D1C890
	|-List<UnitySynchronizationContext.WorkRequest>..ctor
	|
	|-RVA: 0x3D1FAA0 Offset: 0x3D1FBA1 VA: 0x3D1FAA0
	|-List<XmlSchemaObjectTable.XmlSchemaObjectEntry>..ctor
	|
	|-RVA: 0x3D229C0 Offset: 0x3D22AC1 VA: 0x3D229C0
	|-List<AssetBundleBuildMap.AssetBundleEntry.AssetPathString>..ctor
	|
	|-RVA: 0x3D258E0 Offset: 0x3D259E1 VA: 0x3D258E0
	|-List<Detail.DataStore.DataStoreChangeMetaParamInt>..ctor
	|
	|-RVA: 0x3D28D00 Offset: 0x3D28E01 VA: 0x3D28D00
	|-List<Detail.DataStore.DataStoreDeleteParamInt>..ctor
	|
	|-RVA: 0x3D2BBE0 Offset: 0x3D2BCE1 VA: 0x3D2BBE0
	|-List<Detail.DataStore.DataStoreGetMetaParamInt>..ctor
	|
	|-RVA: 0x3D2EF80 Offset: 0x3D2F081 VA: 0x3D2EF80
	|-List<Detail.DataStore.DataStoreMetaInfoInt>..ctor
	|
	|-RVA: 0x3CF37C0 Offset: 0x3CF38C1 VA: 0x3CF37C0
	|-List<Detail.DataStore.DataStorePasswordInfoInt>..ctor
	|
	|-RVA: 0x3CF69A0 Offset: 0x3CF6AA1 VA: 0x3CF69A0
	|-List<Detail.DataStore.DataStorePersistenceInfoInt>..ctor
	|
	|-RVA: 0x3CF9B80 Offset: 0x3CF9C81 VA: 0x3CF9B80
	|-List<Detail.DataStore.DataStorePreparePostParamInt>..ctor
	|
	|-RVA: 0x3CFCF30 Offset: 0x3CFD031 VA: 0x3CFCF30
	|-List<Detail.DataStore.DataStoreRateObjectParamInt>..ctor
	|
	|-RVA: 0x3CFFE10 Offset: 0x3CFFF11 VA: 0x3CFFE10
	|-List<Detail.DataStore.DataStoreRatingInitParamInt>..ctor
	|
	|-RVA: 0x3D03000 Offset: 0x3D03101 VA: 0x3D03000
	|-List<Detail.DataStore.DataStoreRatingTargetInt>..ctor
	|
	|-RVA: 0x3D05EE0 Offset: 0x3D05FE1 VA: 0x3D05EE0
	|-List<Detail.Ranking.RankingCachedResultInt>..ctor
	|
	|-RVA: 0x3D094C0 Offset: 0x3D095C1 VA: 0x3D094C0
	|-List<Detail.Ranking.RankingOrderParamInt>..ctor
	|
	|-RVA: 0x3D0C3A0 Offset: 0x3D0C4A1 VA: 0x3D0C3A0
	|-List<Detail.Ranking.RankingRankDataInt>..ctor
	|
	|-RVA: 0x3D0F920 Offset: 0x3D0FA21 VA: 0x3D0F920
	|-List<Detail.Ranking2.Ranking2ChartInfoInt>..ctor
	|
	|-RVA: 0x3D66320 Offset: 0x3D66421 VA: 0x3D66320
	|-List<Detail.Ranking2.Ranking2RankDataInt>..ctor
	|
	|-RVA: 0x3D698A0 Offset: 0x3D699A1 VA: 0x3D698A0
	|-List<Detail.Ranking2.Ranking2ScoreDataInt>..ctor
	|
	|-RVA: 0x3D6C780 Offset: 0x3D6C881 VA: 0x3D6C780
	|-List<Detail.Screening.ScreeningContextInfoInt>..ctor
	|
	|-RVA: 0x3D6F970 Offset: 0x3D6FA71 VA: 0x3D6F970
	|-List<Detail.Subscriber.SubscriberContentInt>..ctor
	|
	|-RVA: 0x3D73140 Offset: 0x3D73241 VA: 0x3D73140
	|-List<Detail.Subscriber.SubscriberGetContentParamInt>..ctor
	|
	|-RVA: 0x3D76320 Offset: 0x3D76421 VA: 0x3D76320
	|-List<Detail.Subscriber.SubscriberUserStatusInfoInt>..ctor
	|
	|-RVA: 0x3D796C0 Offset: 0x3D797C1 VA: 0x3D796C0
	|-List<Detail.Subscriber.SubscriberUserStatusParamInt>..ctor
	|
	|-RVA: 0x3D7C8A0 Offset: 0x3D7C9A1 VA: 0x3D7C8A0
	|-List<Detail.Utility.IntegerSettings>..ctor
	|
	|-RVA: 0x3D7F6B0 Offset: 0x3D7F7B1 VA: 0x3D7F6B0
	|-List<Detail.Utility.UniqueIdInfoInt>..ctor
	|
	|-RVA: 0x3D82590 Offset: 0x3D82691 VA: 0x3D82590
	|-List<MapHistory.Rewind.LatestInspectorData>..ctor
	|
	|-RVA: 0x305E850 Offset: 0x305E951 VA: 0x305E850
	|-List<MapHistory.Rewind.WorkTerrainData>..ctor
	|
	|-RVA: 0x3061840 Offset: 0x3061941 VA: 0x3061840
	|-List<MapSkill.AroundCalculator.Result>..ctor
	|
	|-RVA: 0x3064760 Offset: 0x3064861 VA: 0x3064760
	|-List<TargetPositionCache.CacheCurve.Item>..ctor
	|
	|-RVA: 0x3067AE0 Offset: 0x3067BE1 VA: 0x3067AE0
	|-List<TargetPositionCache.CacheEntry.RecordingItem>..ctor
	*/

	// RVA: -1 Offset: -1
	public int get_Capacity() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3B0AA00 Offset: 0x3B0AB01 VA: 0x3B0AA00
	|-List<IntervalTree.Entry<object>>.get_Capacity
	|
	|-RVA: 0x3B16C50 Offset: 0x3B16D51 VA: 0x3B16C50
	|-List<KeyValuePair<AnimationClip, AnimationClip>>.get_Capacity
	|-List<KeyValuePair<object, object>>.get_Capacity
	|
	|-RVA: 0x3B0DBF0 Offset: 0x3B0DCF1 VA: 0x3B0DBF0
	|-List<KeyValuePair<DateTime, object>>.get_Capacity
	|
	|-RVA: 0x3B10B10 Offset: 0x3B10C11 VA: 0x3B10B10
	|-List<KeyValuePair<int, object>>.get_Capacity
	|
	|-RVA: 0x3B13A50 Offset: 0x3B13B51 VA: 0x3B13A50
	|-List<KeyValuePair<object, ValueTuple<int, DateTime, object>>>.get_Capacity
	|
	|-RVA: 0x3B19B90 Offset: 0x3B19C91 VA: 0x3B19B90
	|-List<CommonBattleSequence.Reliance<object>>.get_Capacity
	|
	|-RVA: 0x3B1CD80 Offset: 0x3B1CE81 VA: 0x3B1CD80
	|-List<RenderGraphResourcePool.ResourceLogInfo<object>>.get_Capacity
	|
	|-RVA: 0x3B1FCA0 Offset: 0x3B1FDA1 VA: 0x3B1FCA0
	|-List<ValueTuple<int, object>>.get_Capacity
	|
	|-RVA: 0x3DE0920 Offset: 0x3DE0A21 VA: 0x3DE0920
	|-List<ValueTuple<Int32Enum, int>>.get_Capacity
	|
	|-RVA: 0x3DE3760 Offset: 0x3DE3861 VA: 0x3DE3760
	|-List<ValueTuple<object, ValueTuple<object, int>>>.get_Capacity
	|
	|-RVA: 0x3DE6950 Offset: 0x3DE6A51 VA: 0x3DE6950
	|-List<ValueTuple<object, int>>.get_Capacity
	|
	|-RVA: 0x3DE9860 Offset: 0x3DE9961 VA: 0x3DE9860
	|-List<ValueTuple<Vector3, float>>.get_Capacity
	|
	|-RVA: 0x3DEC870 Offset: 0x3DEC971 VA: 0x3DEC870
	|-List<ValueTuple<object, Int32Enum, int>>.get_Capacity
	|
	|-RVA: 0x3DEF7B0 Offset: 0x3DEF8B1 VA: 0x3DEF7B0
	|-List<ValueTuple<object, int, int, int>>.get_Capacity
	|
	|-RVA: 0x3DF2990 Offset: 0x3DF2A91 VA: 0x3DF2990
	|-List<AnimatorClipInfo>.get_Capacity
	|
	|-RVA: 0x3DF57D0 Offset: 0x3DF58D1 VA: 0x3DF57D0
	|-List<AsyncOperationHandle>.get_Capacity
	|
	|-RVA: 0x3DF89E0 Offset: 0x3DF8AE1 VA: 0x3DF89E0
	|-List<BoneWeight>.get_Capacity
	|
	|-RVA: 0x3DFBBA0 Offset: 0x3DFBCA1 VA: 0x3DFBBA0
	|-List<bool>.get_Capacity
	|
	|-RVA: 0x3E79100 Offset: 0x3E79201 VA: 0x3E79100
	|-List<byte>.get_Capacity
	|
	|-RVA: 0x3E7BF20 Offset: 0x3E7C021 VA: 0x3E7BF20
	|-List<CameraInfo>.get_Capacity
	|
	|-RVA: 0x3E7EE30 Offset: 0x3E7EF31 VA: 0x3E7EE30
	|-List<char>.get_Capacity
	|
	|-RVA: 0x3E81C30 Offset: 0x3E81D31 VA: 0x3E81C30
	|-List<Color>.get_Capacity
	|
	|-RVA: 0x3E84C30 Offset: 0x3E84D31 VA: 0x3E84C30
	|-List<Color32>.get_Capacity
	|
	|-RVA: 0x3E87A50 Offset: 0x3E87B51 VA: 0x3E87A50
	|-List<ConstraintSource>.get_Capacity
	|
	|-RVA: 0x3E8A990 Offset: 0x3E8AA91 VA: 0x3E8A990
	|-List<ContourVertex>.get_Capacity
	|
	|-RVA: 0x3E8DBA0 Offset: 0x3E8DCA1 VA: 0x3E8DBA0
	|-List<DataStoreRatingInfo>.get_Capacity
	|
	|-RVA: 0x3E90D50 Offset: 0x3E90E51 VA: 0x3E90D50
	|-List<DataStoreResult>.get_Capacity
	|
	|-RVA: 0x3E93B60 Offset: 0x3E93C61 VA: 0x3E93B60
	|-List<DateTime>.get_Capacity
	|
	|-RVA: 0x3E96980 Offset: 0x3E96A81 VA: 0x3E96980
	|-List<DateTimeOffset>.get_Capacity
	|
	|-RVA: 0x3E99860 Offset: 0x3E99961 VA: 0x3E99860
	|-List<Decimal>.get_Capacity
	|
	|-RVA: 0x3E9C770 Offset: 0x3E9C871 VA: 0x3E9C770
	|-List<DiagnosticEvent>.get_Capacity
	|
	|-RVA: 0x3E9FB70 Offset: 0x3E9FC71 VA: 0x3E9FB70
	|-List<double>.get_Capacity
	|
	|-RVA: 0x3EA29D0 Offset: 0x3EA2AD1 VA: 0x3EA29D0
	|-List<Friend>.get_Capacity
	|
	|-RVA: 0x3E10A70 Offset: 0x3E10B71 VA: 0x3E10A70
	|-List<GameObject>.get_Capacity
	|-List<IDisposable>.get_Capacity
	|-List<object>.get_Capacity
	|-List<RelayLeavingUnitData>.get_Capacity
	|-List<RelayServerMetaData>.get_Capacity
	|-List<Timer>.get_Capacity
	|-List<MapImageTerrain.MinimapInfo>.get_Capacity
	|
	|-RVA: 0x3EA5D30 Offset: 0x3EA5E31 VA: 0x3EA5D30
	|-List<GlyphRect>.get_Capacity
	|
	|-RVA: 0x3EA8C00 Offset: 0x3EA8D01 VA: 0x3EA8C00
	|-List<short>.get_Capacity
	|
	|-RVA: 0x3EABA00 Offset: 0x3EABB01 VA: 0x3EABA00
	|-List<int>.get_Capacity
	|
	|-RVA: 0x3EAE800 Offset: 0x3EAE901 VA: 0x3EAE800
	|-List<Int32Enum>.get_Capacity
	|
	|-RVA: 0x3EB1600 Offset: 0x3EB1701 VA: 0x3EB1600
	|-List<long>.get_Capacity
	|
	|-RVA: 0x3DFE9D0 Offset: 0x3DFEAD1 VA: 0x3DFE9D0
	|-List<IntPtr>.get_Capacity
	|
	|-RVA: 0x3E017E0 Offset: 0x3E018E1 VA: 0x3E017E0
	|-List<InterpretedFrameInfo>.get_Capacity
	|
	|-RVA: 0x3E04720 Offset: 0x3E04821 VA: 0x3E04720
	|-List<IntervalTreeNode>.get_Capacity
	|
	|-RVA: 0x3E078D0 Offset: 0x3E079D1 VA: 0x3E078D0
	|-List<LengthLimitProperties>.get_Capacity
	|
	|-RVA: 0x3E0A6E0 Offset: 0x3E0A7E1 VA: 0x3E0A6E0
	|-List<MapPos>.get_Capacity
	|
	|-RVA: 0x3E0D540 Offset: 0x3E0D641 VA: 0x3E0D540
	|-List<Matrix4x4>.get_Capacity
	|
	|-RVA: 0x3E13870 Offset: 0x3E13971 VA: 0x3E13870
	|-List<ObjectInitializationData>.get_Capacity
	|
	|-RVA: 0x3E16CA0 Offset: 0x3E16DA1 VA: 0x3E16CA0
	|-List<PlayableBinding>.get_Capacity
	|
	|-RVA: 0x3E19ED0 Offset: 0x3E19FD1 VA: 0x3E19ED0
	|-List<PlayerLoopSystem>.get_Capacity
	|
	|-RVA: 0x3DA4370 Offset: 0x3DA4471 VA: 0x3DA4370
	|-List<PlayerLoopSystemInternal>.get_Capacity
	|
	|-RVA: 0x3DA7710 Offset: 0x3DA7811 VA: 0x3DA7710
	|-List<RangePositionInfo>.get_Capacity
	|
	|-RVA: 0x3DAA620 Offset: 0x3DAA721 VA: 0x3DAA620
	|-List<Ranking2ChartInfoInput>.get_Capacity
	|
	|-RVA: 0x3DAD470 Offset: 0x3DAD571 VA: 0x3DAD470
	|-List<RaycastHit2D>.get_Capacity
	|
	|-RVA: 0x3DB08B0 Offset: 0x3DB09B1 VA: 0x3DB08B0
	|-List<RaycastResult>.get_Capacity
	|
	|-RVA: 0x3DB4060 Offset: 0x3DB4161 VA: 0x3DB4060
	|-List<Rect>.get_Capacity
	|
	|-RVA: 0x3DB7060 Offset: 0x3DB7161 VA: 0x3DB7060
	|-List<RendererListHandle>.get_Capacity
	|
	|-RVA: 0x3DB9E70 Offset: 0x3DB9F71 VA: 0x3DB9E70
	|-List<ResourceHandle>.get_Capacity
	|
	|-RVA: 0x3DBCC80 Offset: 0x3DBCD81 VA: 0x3DBCC80
	|-List<sbyte>.get_Capacity
	|
	|-RVA: 0x3DBFA90 Offset: 0x3DBFB91 VA: 0x3DBFA90
	|-List<ShaderTagId>.get_Capacity
	|
	|-RVA: 0x3E3B6F0 Offset: 0x3E3B7F1 VA: 0x3E3B6F0
	|-List<float>.get_Capacity
	|
	|-RVA: 0x3E3E5B0 Offset: 0x3E3E6B1 VA: 0x3E3E5B0
	|-List<SphericalHarmonicsL2>.get_Capacity
	|
	|-RVA: 0x3E42230 Offset: 0x3E42331 VA: 0x3E42230
	|-List<SubMeshDescriptor>.get_Capacity
	|
	|-RVA: 0x3E455F0 Offset: 0x3E456F1 VA: 0x3E455F0
	|-List<TablePair>.get_Capacity
	|
	|-RVA: 0x3E48500 Offset: 0x3E48601 VA: 0x3E48500
	|-List<TimeSpan>.get_Capacity
	|
	|-RVA: 0x3E4B310 Offset: 0x3E4B411 VA: 0x3E4B310
	|-List<UICharInfo>.get_Capacity
	|
	|-RVA: 0x3E4E300 Offset: 0x3E4E401 VA: 0x3E4E300
	|-List<UILineInfo>.get_Capacity
	|
	|-RVA: 0x3E51270 Offset: 0x3E51371 VA: 0x3E51270
	|-List<UIVertex>.get_Capacity
	|
	|-RVA: 0x3E54EB0 Offset: 0x3E54FB1 VA: 0x3E54EB0
	|-List<ushort>.get_Capacity
	|
	|-RVA: 0x3E57CB0 Offset: 0x3E57DB1 VA: 0x3E57CB0
	|-List<uint>.get_Capacity
	|
	|-RVA: 0x3DC28A0 Offset: 0x3DC29A1 VA: 0x3DC28A0
	|-List<ulong>.get_Capacity
	|
	|-RVA: 0x3DC56A0 Offset: 0x3DC57A1 VA: 0x3DC56A0
	|-List<Vector2>.get_Capacity
	|
	|-RVA: 0x3DC8570 Offset: 0x3DC8671 VA: 0x3DC8570
	|-List<Vector3>.get_Capacity
	|
	|-RVA: 0x3DCB550 Offset: 0x3DCB651 VA: 0x3DCB550
	|-List<Vector4>.get_Capacity
	|
	|-RVA: 0x3DCE560 Offset: 0x3DCE661 VA: 0x3DCE560
	|-List<VertexAttributeDescriptor>.get_Capacity
	|
	|-RVA: 0x3DD1440 Offset: 0x3DD1541 VA: 0x3DD1440
	|-List<X509ChainStatus>.get_Capacity
	|
	|-RVA: 0x3DD4390 Offset: 0x3DD4491 VA: 0x3DD4390
	|-List<XRView>.get_Capacity
	|
	|-RVA: 0x3DD7750 Offset: 0x3DD7851 VA: 0x3DD7750
	|-List<AmiiboSequence.GainItemData>.get_Capacity
	|
	|-RVA: 0x3DDA6A0 Offset: 0x3DDA7A1 VA: 0x3DDA6A0
	|-List<AnimationOutputWeightProcessor.WeightInfo>.get_Capacity
	|
	|-RVA: 0x3DDDA10 Offset: 0x3DDDB11 VA: 0x3DDDA10
	|-List<ArenaOrderSequence.GodInfo>.get_Capacity
	|
	|-RVA: 0x3E1D270 Offset: 0x3E1D371 VA: 0x3E1D270
	|-List<BattleInfo.SupportData>.get_Capacity
	|
	|-RVA: 0x3E20190 Offset: 0x3E20291 VA: 0x3E20190
	|-List<BeforeRenderHelper.OrderBlock>.get_Capacity
	|
	|-RVA: 0x3E230D0 Offset: 0x3E231D1 VA: 0x3E230D0
	|-List<Camera.RenderRequest>.get_Capacity
	|
	|-RVA: 0x3E262E0 Offset: 0x3E263E1 VA: 0x3E262E0
	|-List<CameraState.CustomBlendable>.get_Capacity
	|
	|-RVA: 0x3E291F0 Offset: 0x3E292F1 VA: 0x3E291F0
	|-List<CinemachineClearShot.Pair>.get_Capacity
	|
	|-RVA: 0x3E2C000 Offset: 0x3E2C101 VA: 0x3E2C000
	|-List<CinemachineStateDrivenCamera.HashPair>.get_Capacity
	|
	|-RVA: 0x3E2EE40 Offset: 0x3E2EF41 VA: 0x3E2EE40
	|-List<DelayedActionManager.DelegateInfo>.get_Capacity
	|
	|-RVA: 0x3E32070 Offset: 0x3E32171 VA: 0x3E32070
	|-List<Detail.AsyncResultInt>.get_Capacity
	|
	|-RVA: 0x3E35430 Offset: 0x3E35531 VA: 0x3E35430
	|-List<Detail.CppArray>.get_Capacity
	|
	|-RVA: 0x3E38340 Offset: 0x3E38441 VA: 0x3E38340
	|-List<Detail.NotificationEventInt>.get_Capacity
	|
	|-RVA: 0x3E5AAC0 Offset: 0x3E5ABC1 VA: 0x3E5AAC0
	|-List<DragonRideTargetGroup.ChainParam>.get_Capacity
	|
	|-RVA: 0x3E5DA00 Offset: 0x3E5DB01 VA: 0x3E5DA00
	|-List<GmapPathAdjuster.TargetModel>.get_Capacity
	|
	|-RVA: 0x3E60C10 Offset: 0x3E60D11 VA: 0x3E60C10
	|-List<GmapSpotAdjuster.TargetModel>.get_Capacity
	|
	|-RVA: 0x3E63E20 Offset: 0x3E63F21 VA: 0x3E63E20
	|-List<HubFastTravel.Location>.get_Capacity
	|
	|-RVA: 0x3E67040 Offset: 0x3E67141 VA: 0x3E67040
	|-List<HubLensFlare.Flare>.get_Capacity
	|
	|-RVA: 0x3E6A450 Offset: 0x3E6A551 VA: 0x3E6A450
	|-List<InventoryPoolItemMenuContent.KindBgNameClass>.get_Capacity
	|
	|-RVA: 0x3E6D360 Offset: 0x3E6D461 VA: 0x3E6D360
	|-List<Map.Pos>.get_Capacity
	|
	|-RVA: 0x3E70180 Offset: 0x3E70281 VA: 0x3E70180
	|-List<MapImage.BackupTerrain>.get_Capacity
	|
	|-RVA: 0x3E73060 Offset: 0x3E73161 VA: 0x3E73060
	|-List<MapImageRange.Pos>.get_Capacity
	|
	|-RVA: 0x3E75F20 Offset: 0x3E76021 VA: 0x3E75F20
	|-List<MapMind.Target>.get_Capacity
	|
	|-RVA: 0x3D85B20 Offset: 0x3D85C21 VA: 0x3D85B20
	|-List<MapPanelDebug.Entity>.get_Capacity
	|
	|-RVA: 0x3D88CD0 Offset: 0x3D88DD1 VA: 0x3D88CD0
	|-List<NexRanking.Data>.get_Capacity
	|
	|-RVA: 0x3D8BAF0 Offset: 0x3D8BBF1 VA: 0x3D8BAF0
	|-List<NexVersus.RatingData>.get_Capacity
	|
	|-RVA: 0x3D8E9D0 Offset: 0x3D8EAD1 VA: 0x3D8E9D0
	|-List<PackedPlayModeBuildLogs.RuntimeBuildLog>.get_Capacity
	|
	|-RVA: 0x3D91920 Offset: 0x3D91A21 VA: 0x3D91920
	|-List<ParticleSystem.Particle>.get_Capacity
	|
	|-RVA: 0x3D94C90 Offset: 0x3D94D91 VA: 0x3D94C90
	|-List<RangeData.Offset>.get_Capacity
	|
	|-RVA: 0x3D97AD0 Offset: 0x3D97BD1 VA: 0x3D97AD0
	|-List<RenderGraphDebugData.PassDebugData>.get_Capacity
	|
	|-RVA: 0x3D9AD00 Offset: 0x3D9AE01 VA: 0x3D9AD00
	|-List<RenderGraphDebugData.ResourceDebugData>.get_Capacity
	|
	|-RVA: 0x3D9E0A0 Offset: 0x3D9E1A1 VA: 0x3D9E0A0
	|-List<RingCleaningUnitSelectMenu.GodParam>.get_Capacity
	|
	|-RVA: 0x3DA0FF0 Offset: 0x3DA10F1 VA: 0x3DA0FF0
	|-List<ShadowUtility.Edge>.get_Capacity
	|
	|-RVA: 0x3D13800 Offset: 0x3D13901 VA: 0x3D13800
	|-List<SkillArray.Entity>.get_Capacity
	|
	|-RVA: 0x3D16660 Offset: 0x3D16761 VA: 0x3D16660
	|-List<TexturePacker_JsonArray.Frame>.get_Capacity
	|
	|-RVA: 0x3D19C00 Offset: 0x3D19D01 VA: 0x3D19C00
	|-List<TimeNotificationBehaviour.NotificationEntry>.get_Capacity
	|
	|-RVA: 0x3D1CE30 Offset: 0x3D1CF31 VA: 0x3D1CE30
	|-List<UnitySynchronizationContext.WorkRequest>.get_Capacity
	|
	|-RVA: 0x3D20020 Offset: 0x3D20121 VA: 0x3D20020
	|-List<XmlSchemaObjectTable.XmlSchemaObjectEntry>.get_Capacity
	|
	|-RVA: 0x3D22F40 Offset: 0x3D23041 VA: 0x3D22F40
	|-List<AssetBundleBuildMap.AssetBundleEntry.AssetPathString>.get_Capacity
	|
	|-RVA: 0x3D25E90 Offset: 0x3D25F91 VA: 0x3D25E90
	|-List<Detail.DataStore.DataStoreChangeMetaParamInt>.get_Capacity
	|
	|-RVA: 0x3D29280 Offset: 0x3D29381 VA: 0x3D29280
	|-List<Detail.DataStore.DataStoreDeleteParamInt>.get_Capacity
	|
	|-RVA: 0x3D2C190 Offset: 0x3D2C291 VA: 0x3D2C190
	|-List<Detail.DataStore.DataStoreGetMetaParamInt>.get_Capacity
	|
	|-RVA: 0x3D2F530 Offset: 0x3D2F631 VA: 0x3D2F530
	|-List<Detail.DataStore.DataStoreMetaInfoInt>.get_Capacity
	|
	|-RVA: 0x3CF3D60 Offset: 0x3CF3E61 VA: 0x3CF3D60
	|-List<Detail.DataStore.DataStorePasswordInfoInt>.get_Capacity
	|
	|-RVA: 0x3CF6F40 Offset: 0x3CF7041 VA: 0x3CF6F40
	|-List<Detail.DataStore.DataStorePersistenceInfoInt>.get_Capacity
	|
	|-RVA: 0x3CFA130 Offset: 0x3CFA231 VA: 0x3CFA130
	|-List<Detail.DataStore.DataStorePreparePostParamInt>.get_Capacity
	|
	|-RVA: 0x3CFD4B0 Offset: 0x3CFD5B1 VA: 0x3CFD4B0
	|-List<Detail.DataStore.DataStoreRateObjectParamInt>.get_Capacity
	|
	|-RVA: 0x3D003B0 Offset: 0x3D004B1 VA: 0x3D003B0
	|-List<Detail.DataStore.DataStoreRatingInitParamInt>.get_Capacity
	|
	|-RVA: 0x3D03580 Offset: 0x3D03681 VA: 0x3D03580
	|-List<Detail.DataStore.DataStoreRatingTargetInt>.get_Capacity
	|
	|-RVA: 0x3D064B0 Offset: 0x3D065B1 VA: 0x3D064B0
	|-List<Detail.Ranking.RankingCachedResultInt>.get_Capacity
	|
	|-RVA: 0x3D09A40 Offset: 0x3D09B41 VA: 0x3D09A40
	|-List<Detail.Ranking.RankingOrderParamInt>.get_Capacity
	|
	|-RVA: 0x3D0C960 Offset: 0x3D0CA61 VA: 0x3D0C960
	|-List<Detail.Ranking.RankingRankDataInt>.get_Capacity
	|
	|-RVA: 0x3D0FF00 Offset: 0x3D10001 VA: 0x3D0FF00
	|-List<Detail.Ranking2.Ranking2ChartInfoInt>.get_Capacity
	|
	|-RVA: 0x3D668E0 Offset: 0x3D669E1 VA: 0x3D668E0
	|-List<Detail.Ranking2.Ranking2RankDataInt>.get_Capacity
	|
	|-RVA: 0x3D69E20 Offset: 0x3D69F21 VA: 0x3D69E20
	|-List<Detail.Ranking2.Ranking2ScoreDataInt>.get_Capacity
	|
	|-RVA: 0x3D6CD20 Offset: 0x3D6CE21 VA: 0x3D6CD20
	|-List<Detail.Screening.ScreeningContextInfoInt>.get_Capacity
	|
	|-RVA: 0x3D6FF40 Offset: 0x3D70041 VA: 0x3D6FF40
	|-List<Detail.Subscriber.SubscriberContentInt>.get_Capacity
	|
	|-RVA: 0x3D736E0 Offset: 0x3D737E1 VA: 0x3D736E0
	|-List<Detail.Subscriber.SubscriberGetContentParamInt>.get_Capacity
	|
	|-RVA: 0x3D768D0 Offset: 0x3D769D1 VA: 0x3D768D0
	|-List<Detail.Subscriber.SubscriberUserStatusInfoInt>.get_Capacity
	|
	|-RVA: 0x3D79C60 Offset: 0x3D79D61 VA: 0x3D79C60
	|-List<Detail.Subscriber.SubscriberUserStatusParamInt>.get_Capacity
	|
	|-RVA: 0x3D7CE10 Offset: 0x3D7CF11 VA: 0x3D7CE10
	|-List<Detail.Utility.IntegerSettings>.get_Capacity
	|
	|-RVA: 0x3D7FC30 Offset: 0x3D7FD31 VA: 0x3D7FC30
	|-List<Detail.Utility.UniqueIdInfoInt>.get_Capacity
	|
	|-RVA: 0x3D82B10 Offset: 0x3D82C11 VA: 0x3D82B10
	|-List<MapHistory.Rewind.LatestInspectorData>.get_Capacity
	|
	|-RVA: 0x305EDD0 Offset: 0x305EED1 VA: 0x305EDD0
	|-List<MapHistory.Rewind.WorkTerrainData>.get_Capacity
	|
	|-RVA: 0x3061DC0 Offset: 0x3061EC1 VA: 0x3061DC0
	|-List<MapSkill.AroundCalculator.Result>.get_Capacity
	|
	|-RVA: 0x3064D10 Offset: 0x3064E11 VA: 0x3064D10
	|-List<TargetPositionCache.CacheCurve.Item>.get_Capacity
	|
	|-RVA: 0x3068090 Offset: 0x3068191 VA: 0x3068090
	|-List<TargetPositionCache.CacheEntry.RecordingItem>.get_Capacity
	*/

	// RVA: -1 Offset: -1
	public void set_Capacity(int value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3B0AA10 Offset: 0x3B0AB11 VA: 0x3B0AA10
	|-List<IntervalTree.Entry<object>>.set_Capacity
	|
	|-RVA: 0x3B16C60 Offset: 0x3B16D61 VA: 0x3B16C60
	|-List<KeyValuePair<AnimationClip, AnimationClip>>.set_Capacity
	|-List<KeyValuePair<object, object>>.set_Capacity
	|
	|-RVA: 0x3B0DC00 Offset: 0x3B0DD01 VA: 0x3B0DC00
	|-List<KeyValuePair<DateTime, object>>.set_Capacity
	|
	|-RVA: 0x3B10B20 Offset: 0x3B10C21 VA: 0x3B10B20
	|-List<KeyValuePair<int, object>>.set_Capacity
	|
	|-RVA: 0x3B13A60 Offset: 0x3B13B61 VA: 0x3B13A60
	|-List<KeyValuePair<object, ValueTuple<int, DateTime, object>>>.set_Capacity
	|
	|-RVA: 0x3B19BA0 Offset: 0x3B19CA1 VA: 0x3B19BA0
	|-List<CommonBattleSequence.Reliance<object>>.set_Capacity
	|
	|-RVA: 0x3B1CD90 Offset: 0x3B1CE91 VA: 0x3B1CD90
	|-List<RenderGraphResourcePool.ResourceLogInfo<object>>.set_Capacity
	|
	|-RVA: 0x3B1FCB0 Offset: 0x3B1FDB1 VA: 0x3B1FCB0
	|-List<ValueTuple<int, object>>.set_Capacity
	|
	|-RVA: 0x3DE0930 Offset: 0x3DE0A31 VA: 0x3DE0930
	|-List<ValueTuple<Int32Enum, int>>.set_Capacity
	|
	|-RVA: 0x3DE3770 Offset: 0x3DE3871 VA: 0x3DE3770
	|-List<ValueTuple<object, ValueTuple<object, int>>>.set_Capacity
	|
	|-RVA: 0x3DE6960 Offset: 0x3DE6A61 VA: 0x3DE6960
	|-List<ValueTuple<object, int>>.set_Capacity
	|
	|-RVA: 0x3DE9870 Offset: 0x3DE9971 VA: 0x3DE9870
	|-List<ValueTuple<Vector3, float>>.set_Capacity
	|
	|-RVA: 0x3DEC880 Offset: 0x3DEC981 VA: 0x3DEC880
	|-List<ValueTuple<object, Int32Enum, int>>.set_Capacity
	|
	|-RVA: 0x3DEF7C0 Offset: 0x3DEF8C1 VA: 0x3DEF7C0
	|-List<ValueTuple<object, int, int, int>>.set_Capacity
	|
	|-RVA: 0x3DF29A0 Offset: 0x3DF2AA1 VA: 0x3DF29A0
	|-List<AnimatorClipInfo>.set_Capacity
	|
	|-RVA: 0x3DF57E0 Offset: 0x3DF58E1 VA: 0x3DF57E0
	|-List<AsyncOperationHandle>.set_Capacity
	|
	|-RVA: 0x3DF89F0 Offset: 0x3DF8AF1 VA: 0x3DF89F0
	|-List<BoneWeight>.set_Capacity
	|
	|-RVA: 0x3DFBBB0 Offset: 0x3DFBCB1 VA: 0x3DFBBB0
	|-List<bool>.set_Capacity
	|
	|-RVA: 0x3E79110 Offset: 0x3E79211 VA: 0x3E79110
	|-List<byte>.set_Capacity
	|
	|-RVA: 0x3E7BF30 Offset: 0x3E7C031 VA: 0x3E7BF30
	|-List<CameraInfo>.set_Capacity
	|
	|-RVA: 0x3E7EE40 Offset: 0x3E7EF41 VA: 0x3E7EE40
	|-List<char>.set_Capacity
	|
	|-RVA: 0x3E81C40 Offset: 0x3E81D41 VA: 0x3E81C40
	|-List<Color>.set_Capacity
	|
	|-RVA: 0x3E84C40 Offset: 0x3E84D41 VA: 0x3E84C40
	|-List<Color32>.set_Capacity
	|
	|-RVA: 0x3E87A60 Offset: 0x3E87B61 VA: 0x3E87A60
	|-List<ConstraintSource>.set_Capacity
	|
	|-RVA: 0x3E8A9A0 Offset: 0x3E8AAA1 VA: 0x3E8A9A0
	|-List<ContourVertex>.set_Capacity
	|
	|-RVA: 0x3E8DBB0 Offset: 0x3E8DCB1 VA: 0x3E8DBB0
	|-List<DataStoreRatingInfo>.set_Capacity
	|
	|-RVA: 0x3E90D60 Offset: 0x3E90E61 VA: 0x3E90D60
	|-List<DataStoreResult>.set_Capacity
	|
	|-RVA: 0x3E93B70 Offset: 0x3E93C71 VA: 0x3E93B70
	|-List<DateTime>.set_Capacity
	|
	|-RVA: 0x3E96990 Offset: 0x3E96A91 VA: 0x3E96990
	|-List<DateTimeOffset>.set_Capacity
	|
	|-RVA: 0x3E99870 Offset: 0x3E99971 VA: 0x3E99870
	|-List<Decimal>.set_Capacity
	|
	|-RVA: 0x3E9C780 Offset: 0x3E9C881 VA: 0x3E9C780
	|-List<DiagnosticEvent>.set_Capacity
	|
	|-RVA: 0x3E9FB80 Offset: 0x3E9FC81 VA: 0x3E9FB80
	|-List<double>.set_Capacity
	|
	|-RVA: 0x3EA29E0 Offset: 0x3EA2AE1 VA: 0x3EA29E0
	|-List<Friend>.set_Capacity
	|
	|-RVA: 0x3E10A80 Offset: 0x3E10B81 VA: 0x3E10A80
	|-List<GameObject>.set_Capacity
	|-List<object>.set_Capacity
	|-List<RelayLeavingUnitData>.set_Capacity
	|-List<RelayServerMetaData>.set_Capacity
	|-List<Timer>.set_Capacity
	|-List<SoundSystem.SoundHandle>.set_Capacity
	|
	|-RVA: 0x3EA5D40 Offset: 0x3EA5E41 VA: 0x3EA5D40
	|-List<GlyphRect>.set_Capacity
	|
	|-RVA: 0x3EA8C10 Offset: 0x3EA8D11 VA: 0x3EA8C10
	|-List<short>.set_Capacity
	|
	|-RVA: 0x3EABA10 Offset: 0x3EABB11 VA: 0x3EABA10
	|-List<int>.set_Capacity
	|
	|-RVA: 0x3EAE810 Offset: 0x3EAE911 VA: 0x3EAE810
	|-List<Int32Enum>.set_Capacity
	|
	|-RVA: 0x3EB1610 Offset: 0x3EB1711 VA: 0x3EB1610
	|-List<long>.set_Capacity
	|
	|-RVA: 0x3DFE9E0 Offset: 0x3DFEAE1 VA: 0x3DFE9E0
	|-List<IntPtr>.set_Capacity
	|
	|-RVA: 0x3E017F0 Offset: 0x3E018F1 VA: 0x3E017F0
	|-List<InterpretedFrameInfo>.set_Capacity
	|
	|-RVA: 0x3E04730 Offset: 0x3E04831 VA: 0x3E04730
	|-List<IntervalTreeNode>.set_Capacity
	|
	|-RVA: 0x3E078E0 Offset: 0x3E079E1 VA: 0x3E078E0
	|-List<LengthLimitProperties>.set_Capacity
	|
	|-RVA: 0x3E0A6F0 Offset: 0x3E0A7F1 VA: 0x3E0A6F0
	|-List<MapPos>.set_Capacity
	|
	|-RVA: 0x3E0D550 Offset: 0x3E0D651 VA: 0x3E0D550
	|-List<Matrix4x4>.set_Capacity
	|
	|-RVA: 0x3E13880 Offset: 0x3E13981 VA: 0x3E13880
	|-List<ObjectInitializationData>.set_Capacity
	|
	|-RVA: 0x3E16CB0 Offset: 0x3E16DB1 VA: 0x3E16CB0
	|-List<PlayableBinding>.set_Capacity
	|
	|-RVA: 0x3E19EE0 Offset: 0x3E19FE1 VA: 0x3E19EE0
	|-List<PlayerLoopSystem>.set_Capacity
	|
	|-RVA: 0x3DA4380 Offset: 0x3DA4481 VA: 0x3DA4380
	|-List<PlayerLoopSystemInternal>.set_Capacity
	|
	|-RVA: 0x3DA7720 Offset: 0x3DA7821 VA: 0x3DA7720
	|-List<RangePositionInfo>.set_Capacity
	|
	|-RVA: 0x3DAA630 Offset: 0x3DAA731 VA: 0x3DAA630
	|-List<Ranking2ChartInfoInput>.set_Capacity
	|
	|-RVA: 0x3DAD480 Offset: 0x3DAD581 VA: 0x3DAD480
	|-List<RaycastHit2D>.set_Capacity
	|
	|-RVA: 0x3DB08C0 Offset: 0x3DB09C1 VA: 0x3DB08C0
	|-List<RaycastResult>.set_Capacity
	|
	|-RVA: 0x3DB4070 Offset: 0x3DB4171 VA: 0x3DB4070
	|-List<Rect>.set_Capacity
	|
	|-RVA: 0x3DB7070 Offset: 0x3DB7171 VA: 0x3DB7070
	|-List<RendererListHandle>.set_Capacity
	|
	|-RVA: 0x3DB9E80 Offset: 0x3DB9F81 VA: 0x3DB9E80
	|-List<ResourceHandle>.set_Capacity
	|
	|-RVA: 0x3DBCC90 Offset: 0x3DBCD91 VA: 0x3DBCC90
	|-List<sbyte>.set_Capacity
	|
	|-RVA: 0x3DBFAA0 Offset: 0x3DBFBA1 VA: 0x3DBFAA0
	|-List<ShaderTagId>.set_Capacity
	|
	|-RVA: 0x3E3B700 Offset: 0x3E3B801 VA: 0x3E3B700
	|-List<float>.set_Capacity
	|
	|-RVA: 0x3E3E5C0 Offset: 0x3E3E6C1 VA: 0x3E3E5C0
	|-List<SphericalHarmonicsL2>.set_Capacity
	|
	|-RVA: 0x3E42240 Offset: 0x3E42341 VA: 0x3E42240
	|-List<SubMeshDescriptor>.set_Capacity
	|
	|-RVA: 0x3E45600 Offset: 0x3E45701 VA: 0x3E45600
	|-List<TablePair>.set_Capacity
	|
	|-RVA: 0x3E48510 Offset: 0x3E48611 VA: 0x3E48510
	|-List<TimeSpan>.set_Capacity
	|
	|-RVA: 0x3E4B320 Offset: 0x3E4B421 VA: 0x3E4B320
	|-List<UICharInfo>.set_Capacity
	|
	|-RVA: 0x3E4E310 Offset: 0x3E4E411 VA: 0x3E4E310
	|-List<UILineInfo>.set_Capacity
	|
	|-RVA: 0x3E51280 Offset: 0x3E51381 VA: 0x3E51280
	|-List<UIVertex>.set_Capacity
	|
	|-RVA: 0x3E54EC0 Offset: 0x3E54FC1 VA: 0x3E54EC0
	|-List<ushort>.set_Capacity
	|
	|-RVA: 0x3E57CC0 Offset: 0x3E57DC1 VA: 0x3E57CC0
	|-List<uint>.set_Capacity
	|
	|-RVA: 0x3DC28B0 Offset: 0x3DC29B1 VA: 0x3DC28B0
	|-List<ulong>.set_Capacity
	|
	|-RVA: 0x3DC56B0 Offset: 0x3DC57B1 VA: 0x3DC56B0
	|-List<Vector2>.set_Capacity
	|
	|-RVA: 0x3DC8580 Offset: 0x3DC8681 VA: 0x3DC8580
	|-List<Vector3>.set_Capacity
	|
	|-RVA: 0x3DCB560 Offset: 0x3DCB661 VA: 0x3DCB560
	|-List<Vector4>.set_Capacity
	|
	|-RVA: 0x3DCE570 Offset: 0x3DCE671 VA: 0x3DCE570
	|-List<VertexAttributeDescriptor>.set_Capacity
	|
	|-RVA: 0x3DD1450 Offset: 0x3DD1551 VA: 0x3DD1450
	|-List<X509ChainStatus>.set_Capacity
	|
	|-RVA: 0x3DD43A0 Offset: 0x3DD44A1 VA: 0x3DD43A0
	|-List<XRView>.set_Capacity
	|
	|-RVA: 0x3DD7760 Offset: 0x3DD7861 VA: 0x3DD7760
	|-List<AmiiboSequence.GainItemData>.set_Capacity
	|
	|-RVA: 0x3DDA6B0 Offset: 0x3DDA7B1 VA: 0x3DDA6B0
	|-List<AnimationOutputWeightProcessor.WeightInfo>.set_Capacity
	|
	|-RVA: 0x3DDDA20 Offset: 0x3DDDB21 VA: 0x3DDDA20
	|-List<ArenaOrderSequence.GodInfo>.set_Capacity
	|
	|-RVA: 0x3E1D280 Offset: 0x3E1D381 VA: 0x3E1D280
	|-List<BattleInfo.SupportData>.set_Capacity
	|
	|-RVA: 0x3E201A0 Offset: 0x3E202A1 VA: 0x3E201A0
	|-List<BeforeRenderHelper.OrderBlock>.set_Capacity
	|
	|-RVA: 0x3E230E0 Offset: 0x3E231E1 VA: 0x3E230E0
	|-List<Camera.RenderRequest>.set_Capacity
	|
	|-RVA: 0x3E262F0 Offset: 0x3E263F1 VA: 0x3E262F0
	|-List<CameraState.CustomBlendable>.set_Capacity
	|
	|-RVA: 0x3E29200 Offset: 0x3E29301 VA: 0x3E29200
	|-List<CinemachineClearShot.Pair>.set_Capacity
	|
	|-RVA: 0x3E2C010 Offset: 0x3E2C111 VA: 0x3E2C010
	|-List<CinemachineStateDrivenCamera.HashPair>.set_Capacity
	|
	|-RVA: 0x3E2EE50 Offset: 0x3E2EF51 VA: 0x3E2EE50
	|-List<DelayedActionManager.DelegateInfo>.set_Capacity
	|
	|-RVA: 0x3E32080 Offset: 0x3E32181 VA: 0x3E32080
	|-List<Detail.AsyncResultInt>.set_Capacity
	|
	|-RVA: 0x3E35440 Offset: 0x3E35541 VA: 0x3E35440
	|-List<Detail.CppArray>.set_Capacity
	|
	|-RVA: 0x3E38350 Offset: 0x3E38451 VA: 0x3E38350
	|-List<Detail.NotificationEventInt>.set_Capacity
	|
	|-RVA: 0x3E5AAD0 Offset: 0x3E5ABD1 VA: 0x3E5AAD0
	|-List<DragonRideTargetGroup.ChainParam>.set_Capacity
	|
	|-RVA: 0x3E5DA10 Offset: 0x3E5DB11 VA: 0x3E5DA10
	|-List<GmapPathAdjuster.TargetModel>.set_Capacity
	|
	|-RVA: 0x3E60C20 Offset: 0x3E60D21 VA: 0x3E60C20
	|-List<GmapSpotAdjuster.TargetModel>.set_Capacity
	|
	|-RVA: 0x3E63E30 Offset: 0x3E63F31 VA: 0x3E63E30
	|-List<HubFastTravel.Location>.set_Capacity
	|
	|-RVA: 0x3E67050 Offset: 0x3E67151 VA: 0x3E67050
	|-List<HubLensFlare.Flare>.set_Capacity
	|
	|-RVA: 0x3E6A460 Offset: 0x3E6A561 VA: 0x3E6A460
	|-List<InventoryPoolItemMenuContent.KindBgNameClass>.set_Capacity
	|
	|-RVA: 0x3E6D370 Offset: 0x3E6D471 VA: 0x3E6D370
	|-List<Map.Pos>.set_Capacity
	|
	|-RVA: 0x3E70190 Offset: 0x3E70291 VA: 0x3E70190
	|-List<MapImage.BackupTerrain>.set_Capacity
	|
	|-RVA: 0x3E73070 Offset: 0x3E73171 VA: 0x3E73070
	|-List<MapImageRange.Pos>.set_Capacity
	|
	|-RVA: 0x3E75F30 Offset: 0x3E76031 VA: 0x3E75F30
	|-List<MapMind.Target>.set_Capacity
	|
	|-RVA: 0x3D85B30 Offset: 0x3D85C31 VA: 0x3D85B30
	|-List<MapPanelDebug.Entity>.set_Capacity
	|
	|-RVA: 0x3D88CE0 Offset: 0x3D88DE1 VA: 0x3D88CE0
	|-List<NexRanking.Data>.set_Capacity
	|
	|-RVA: 0x3D8BB00 Offset: 0x3D8BC01 VA: 0x3D8BB00
	|-List<NexVersus.RatingData>.set_Capacity
	|
	|-RVA: 0x3D8E9E0 Offset: 0x3D8EAE1 VA: 0x3D8E9E0
	|-List<PackedPlayModeBuildLogs.RuntimeBuildLog>.set_Capacity
	|
	|-RVA: 0x3D91930 Offset: 0x3D91A31 VA: 0x3D91930
	|-List<ParticleSystem.Particle>.set_Capacity
	|
	|-RVA: 0x3D94CA0 Offset: 0x3D94DA1 VA: 0x3D94CA0
	|-List<RangeData.Offset>.set_Capacity
	|
	|-RVA: 0x3D97AE0 Offset: 0x3D97BE1 VA: 0x3D97AE0
	|-List<RenderGraphDebugData.PassDebugData>.set_Capacity
	|
	|-RVA: 0x3D9AD10 Offset: 0x3D9AE11 VA: 0x3D9AD10
	|-List<RenderGraphDebugData.ResourceDebugData>.set_Capacity
	|
	|-RVA: 0x3D9E0B0 Offset: 0x3D9E1B1 VA: 0x3D9E0B0
	|-List<RingCleaningUnitSelectMenu.GodParam>.set_Capacity
	|
	|-RVA: 0x3DA1000 Offset: 0x3DA1101 VA: 0x3DA1000
	|-List<ShadowUtility.Edge>.set_Capacity
	|
	|-RVA: 0x3D13810 Offset: 0x3D13911 VA: 0x3D13810
	|-List<SkillArray.Entity>.set_Capacity
	|
	|-RVA: 0x3D16670 Offset: 0x3D16771 VA: 0x3D16670
	|-List<TexturePacker_JsonArray.Frame>.set_Capacity
	|
	|-RVA: 0x3D19C10 Offset: 0x3D19D11 VA: 0x3D19C10
	|-List<TimeNotificationBehaviour.NotificationEntry>.set_Capacity
	|
	|-RVA: 0x3D1CE40 Offset: 0x3D1CF41 VA: 0x3D1CE40
	|-List<UnitySynchronizationContext.WorkRequest>.set_Capacity
	|
	|-RVA: 0x3D20030 Offset: 0x3D20131 VA: 0x3D20030
	|-List<XmlSchemaObjectTable.XmlSchemaObjectEntry>.set_Capacity
	|
	|-RVA: 0x3D22F50 Offset: 0x3D23051 VA: 0x3D22F50
	|-List<AssetBundleBuildMap.AssetBundleEntry.AssetPathString>.set_Capacity
	|
	|-RVA: 0x3D25EA0 Offset: 0x3D25FA1 VA: 0x3D25EA0
	|-List<Detail.DataStore.DataStoreChangeMetaParamInt>.set_Capacity
	|
	|-RVA: 0x3D29290 Offset: 0x3D29391 VA: 0x3D29290
	|-List<Detail.DataStore.DataStoreDeleteParamInt>.set_Capacity
	|
	|-RVA: 0x3D2C1A0 Offset: 0x3D2C2A1 VA: 0x3D2C1A0
	|-List<Detail.DataStore.DataStoreGetMetaParamInt>.set_Capacity
	|
	|-RVA: 0x3D2F540 Offset: 0x3D2F641 VA: 0x3D2F540
	|-List<Detail.DataStore.DataStoreMetaInfoInt>.set_Capacity
	|
	|-RVA: 0x3CF3D70 Offset: 0x3CF3E71 VA: 0x3CF3D70
	|-List<Detail.DataStore.DataStorePasswordInfoInt>.set_Capacity
	|
	|-RVA: 0x3CF6F50 Offset: 0x3CF7051 VA: 0x3CF6F50
	|-List<Detail.DataStore.DataStorePersistenceInfoInt>.set_Capacity
	|
	|-RVA: 0x3CFA140 Offset: 0x3CFA241 VA: 0x3CFA140
	|-List<Detail.DataStore.DataStorePreparePostParamInt>.set_Capacity
	|
	|-RVA: 0x3CFD4C0 Offset: 0x3CFD5C1 VA: 0x3CFD4C0
	|-List<Detail.DataStore.DataStoreRateObjectParamInt>.set_Capacity
	|
	|-RVA: 0x3D003C0 Offset: 0x3D004C1 VA: 0x3D003C0
	|-List<Detail.DataStore.DataStoreRatingInitParamInt>.set_Capacity
	|
	|-RVA: 0x3D03590 Offset: 0x3D03691 VA: 0x3D03590
	|-List<Detail.DataStore.DataStoreRatingTargetInt>.set_Capacity
	|
	|-RVA: 0x3D064C0 Offset: 0x3D065C1 VA: 0x3D064C0
	|-List<Detail.Ranking.RankingCachedResultInt>.set_Capacity
	|
	|-RVA: 0x3D09A50 Offset: 0x3D09B51 VA: 0x3D09A50
	|-List<Detail.Ranking.RankingOrderParamInt>.set_Capacity
	|
	|-RVA: 0x3D0C970 Offset: 0x3D0CA71 VA: 0x3D0C970
	|-List<Detail.Ranking.RankingRankDataInt>.set_Capacity
	|
	|-RVA: 0x3D0FF10 Offset: 0x3D10011 VA: 0x3D0FF10
	|-List<Detail.Ranking2.Ranking2ChartInfoInt>.set_Capacity
	|
	|-RVA: 0x3D668F0 Offset: 0x3D669F1 VA: 0x3D668F0
	|-List<Detail.Ranking2.Ranking2RankDataInt>.set_Capacity
	|
	|-RVA: 0x3D69E30 Offset: 0x3D69F31 VA: 0x3D69E30
	|-List<Detail.Ranking2.Ranking2ScoreDataInt>.set_Capacity
	|
	|-RVA: 0x3D6CD30 Offset: 0x3D6CE31 VA: 0x3D6CD30
	|-List<Detail.Screening.ScreeningContextInfoInt>.set_Capacity
	|
	|-RVA: 0x3D6FF50 Offset: 0x3D70051 VA: 0x3D6FF50
	|-List<Detail.Subscriber.SubscriberContentInt>.set_Capacity
	|
	|-RVA: 0x3D736F0 Offset: 0x3D737F1 VA: 0x3D736F0
	|-List<Detail.Subscriber.SubscriberGetContentParamInt>.set_Capacity
	|
	|-RVA: 0x3D768E0 Offset: 0x3D769E1 VA: 0x3D768E0
	|-List<Detail.Subscriber.SubscriberUserStatusInfoInt>.set_Capacity
	|
	|-RVA: 0x3D79C70 Offset: 0x3D79D71 VA: 0x3D79C70
	|-List<Detail.Subscriber.SubscriberUserStatusParamInt>.set_Capacity
	|
	|-RVA: 0x3D7CE20 Offset: 0x3D7CF21 VA: 0x3D7CE20
	|-List<Detail.Utility.IntegerSettings>.set_Capacity
	|
	|-RVA: 0x3D7FC40 Offset: 0x3D7FD41 VA: 0x3D7FC40
	|-List<Detail.Utility.UniqueIdInfoInt>.set_Capacity
	|
	|-RVA: 0x3D82B20 Offset: 0x3D82C21 VA: 0x3D82B20
	|-List<MapHistory.Rewind.LatestInspectorData>.set_Capacity
	|
	|-RVA: 0x305EDE0 Offset: 0x305EEE1 VA: 0x305EDE0
	|-List<MapHistory.Rewind.WorkTerrainData>.set_Capacity
	|
	|-RVA: 0x3061DD0 Offset: 0x3061ED1 VA: 0x3061DD0
	|-List<MapSkill.AroundCalculator.Result>.set_Capacity
	|
	|-RVA: 0x3064D20 Offset: 0x3064E21 VA: 0x3064D20
	|-List<TargetPositionCache.CacheCurve.Item>.set_Capacity
	|
	|-RVA: 0x30680A0 Offset: 0x30681A1 VA: 0x30680A0
	|-List<TargetPositionCache.CacheEntry.RecordingItem>.set_Capacity
	*/

	// RVA: -1 Offset: -1 Slot: 33
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3B0AB90 Offset: 0x3B0AC91 VA: 0x3B0AB90
	|-List<IntervalTree.Entry<object>>.get_Count
	|
	|-RVA: 0x3B16DE0 Offset: 0x3B16EE1 VA: 0x3B16DE0
	|-List<KeyValuePair<AnimationClip, AnimationClip>>.get_Count
	|-List<KeyValuePair<object, object>>.get_Count
	|
	|-RVA: 0x3B0DD80 Offset: 0x3B0DE81 VA: 0x3B0DD80
	|-List<KeyValuePair<DateTime, object>>.get_Count
	|-List<KeyValuePair<DateTime, TimeType>>.get_Count
	|
	|-RVA: 0x3B10CA0 Offset: 0x3B10DA1 VA: 0x3B10CA0
	|-List<KeyValuePair<int, object>>.get_Count
	|
	|-RVA: 0x3B13BE0 Offset: 0x3B13CE1 VA: 0x3B13BE0
	|-List<KeyValuePair<object, ValueTuple<int, DateTime, object>>>.get_Count
	|
	|-RVA: 0x3E10C00 Offset: 0x3E10D01 VA: 0x3E10C00
	|-List<List<CinemachineVirtualCameraBase>>.get_Count
	|-List<List<int>>.get_Count
	|-List<List<object>>.get_Count
	|-List<List<Vector2>>.get_Count
	|-List<StructDataArrayList<DragonRideTargetPatternData>>.get_Count
	|-List<StructDataArrayList<JobIntroData>>.get_Count
	|-List<StructDataArrayList<KillBonusData>>.get_Count
	|-List<StructDataArrayList<KilledBonusData>>.get_Count
	|-List<StructDataArrayList<LaterTalkData>>.get_Count
	|-List<StructDataArrayList<TutorialData>>.get_Count
	|-List<MiniMapController.TImage<Image>>.get_Count
	|-List<MiniMapController.TImage<UnitIcon>>.get_Count
	|-List<byte[]>.get_Count
	|-List<KeyCode[]>.get_Count
	|-List<string[]>.get_Count
	|-List<AIData>.get_Count
	|-List<AccessoryData>.get_Count
	|-List<AccessoryShopContent>.get_Count
	|-List<AccessoryShopData>.get_Count
	|-List<AchieveData>.get_Count
	|-List<Action>.get_Count
	|-List<AggregateException>.get_Count
	|-List<AkAmbient>.get_Count
	|-List<AkAmbientLargeModePositioner>.get_Count
	|-List<AkAudioListener>.get_Count
	|-List<AkEnvironment>.get_Count
	|-List<AkEnvironmentPortal>.get_Count
	|-List<AkGameObj>.get_Count
	|-List<AkRoom>.get_Count
	|-List<AkRoomAwareObject>.get_Count
	|-List<AkRoomPortal>.get_Count
	|-List<AkSpatialAudioListener>.get_Count
	|-List<AkSurfaceReflector>.get_Count
	|-List<AnimalData>.get_Count
	|-List<AnimationTrack>.get_Count
	|-List<Animator>.get_Count
	|-List<AssetTable>.get_Count
	|-List<AsyncDebugger>.get_Count
	|-List<AudienceAnime>.get_Count
	|-List<BaseInputModule>.get_Count
	|-List<BaseInvokableCall>.get_Count
	|-List<BaseRaycaster>.get_Count
	|-List<BasicMenu>.get_Count
	|-List<BasicMenuItem>.get_Count
	|-List<BattleInfoSide>.get_Count
	|-List<BuildTimeScopeFrame>.get_Count
	|-List<CalculatorCommand>.get_Count
	|-List<Camera>.get_Count
	|-List<Canvas>.get_Count
	|-List<CanvasGroup>.get_Count
	|-List<CapsuleCollider>.get_Count
	|-List<ChapterData>.get_Count
	|-List<CharacterCollision>.get_Count
	|-List<CharacterProportion>.get_Count
	|-List<CinemachineBrain>.get_Count
	|-List<CinemachineExtension>.get_Count
	|-List<CinemachineVirtualCameraBase>.get_Count
	|-List<Claim>.get_Count
	|-List<Collider>.get_Count
	|-List<Component>.get_Count
	|-List<CustomEnvSet>.get_Count
	|-List<DataStoreDeleteParam>.get_Count
	|-List<DataStoreMetaInfo>.get_Count
	|-List<DebugUIHandlerIndirectToggle>.get_Count
	|-List<DebugUIHandlerPanel>.get_Count
	|-List<DebugUIHandlerWidget>.get_Count
	|-List<Decorator>.get_Count
	|-List<DisposData>.get_Count
	|-List<DynValue>.get_Count
	|-List<EncountEquipData>.get_Count
	|-List<EncountUnitData>.get_Count
	|-List<EventCharacterMouthController>.get_Count
	|-List<EventSystem>.get_Count
	|-List<ExceptionDispatchInfo>.get_Count
	|-List<Expression>.get_Count
	|-List<FileData>.get_Count
	|-List<FoodstuffData>.get_Count
	|-List<ForceProvider>.get_Count
	|-List<ForceTextureSetter>.get_Count
	|-List<ForecastFishData>.get_Count
	|-List<FriendListData>.get_Count
	|-List<GUILayoutEntry>.get_Count
	|-List<GameObject>.get_Count
	|-List<Glyph>.get_Count
	|-List<GmapSpot>.get_Count
	|-List<GodData>.get_Count
	|-List<GodGrowthData>.get_Count
	|-List<GodUnit>.get_Count
	|-List<GodWeaponRefineData>.get_Count
	|-List<Graphic>.get_Count
	|-List<HubAccess>.get_Count
	|-List<HubAccessData>.get_Count
	|-List<HubAccessManager>.get_Count
	|-List<HubAreaFog>.get_Count
	|-List<HubInvestmentAnimal>.get_Count
	|-List<HubInvestmentBonusAnimal>.get_Count
	|-List<HubInvestmentBonusFood>.get_Count
	|-List<HubInvestmentBonusItem>.get_Count
	|-List<HubInvestmentFoodstuff>.get_Count
	|-List<HubInvestmentLevel>.get_Count
	|-List<HubManualCulling>.get_Count
	|-List<HubMoveState>.get_Count
	|-List<HubUnitController>.get_Count
	|-List<IAsyncOperation>.get_Count
	|-List<ICanvasElement>.get_Count
	|-List<IClosureBuilder>.get_Count
	|-List<IContextProperty>.get_Count
	|-List<IDisposable>.get_Count
	|-List<IEventSystemHandler>.get_Count
	|-List<IMarker>.get_Count
	|-List<IMaterialModifier>.get_Count
	|-List<IMenuElement>.get_Count
	|-List<IOverloadableMemberDescriptor>.get_Count
	|-List<IPAddress>.get_Count
	|-List<IResourceLocation>.get_Count
	|-List<ISpringManager>.get_Count
	|-List<ITimelineEvaluateCallback>.get_Count
	|-List<IUserDataDescriptor>.get_Count
	|-List<IVariable>.get_Count
	|-List<Image>.get_Count
	|-List<Instruction>.get_Count
	|-List<Instruction>.get_Count
	|-List<InteractionTrigger>.get_Count
	|-List<ItemData>.get_Count
	|-List<ItemEvolveData>.get_Count
	|-List<ItemRefineData>.get_Count
	|-List<JobData>.get_Count
	|-List<JobIntroData>.get_Count
	|-List<KerningPair>.get_Count
	|-List<KeyHelpData>.get_Count
	|-List<KillBonusData>.get_Count
	|-List<KilledBonusData>.get_Count
	|-List<LabelScopeInfo>.get_Count
	|-List<LaterTalkData>.get_Count
	|-List<Light2D>.get_Count
	|-List<LocalDataStore>.get_Count
	|-List<MapBackup>.get_Count
	|-List<MapCollision>.get_Count
	|-List<MapEditorObjectData>.get_Count
	|-List<MapInspector>.get_Count
	|-List<MapObject>.get_Count
	|-List<Mask>.get_Count
	|-List<Material>.get_Count
	|-List<MenuItem>.get_Count
	|-List<Mesh>.get_Count
	|-List<MethodBase>.get_Count
	|-List<MethodInfo>.get_Count
	|-List<MusclePushUpSpeedData>.get_Count
	|-List<MuscleSitUpFallData>.get_Count
	|-List<MuscleSquatScorePatternData>.get_Count
	|-List<Note>.get_Count
	|-List<object>.get_Count
	|-List<PersonData>.get_Count
	|-List<Phase>.get_Count
	|-List<PhotographCameraParameter>.get_Count
	|-List<PhotographDisposInfo>.get_Count
	|-List<PhotographPauseData>.get_Count
	|-List<PokeInspector>.get_Count
	|-List<PrefetchedSignal>.get_Count
	|-List<Processor>.get_Count
	|-List<ProfileCard>.get_Count
	|-List<RangeData>.get_Count
	|-List<RectMask2D>.get_Count
	|-List<RectTransform>.get_Count
	|-List<RegexNode>.get_Count
	|-List<RelayCompletionAwardData>.get_Count
	|-List<RelayLeavingUnitData>.get_Count
	|-List<RelayServerMetaData>.get_Count
	|-List<RelayStampData>.get_Count
	|-List<RelianceData>.get_Count
	|-List<RenderGraphPass>.get_Count
	|-List<Renderer>.get_Count
	|-List<ResourceGameObject>.get_Count
	|-List<ResourceHandle>.get_Count
	|-List<RewardData>.get_Count
	|-List<RingCleaningVoiceData>.get_Count
	|-List<RingData>.get_Count
	|-List<RuntimeElement>.get_Count
	|-List<ScreeningContextInfo>.get_Count
	|-List<ScriptableObject>.get_Count
	|-List<ScriptableRenderPass>.get_Count
	|-List<ScriptableRendererFeature>.get_Count
	|-List<SerializationFieldInfo>.get_Count
	|-List<ShadowCaster2D>.get_Count
	|-List<ShadowCasterGroup2D>.get_Count
	|-List<ShopContent>.get_Count
	|-List<ShopData>.get_Count
	|-List<SignalAsset>.get_Count
	|-List<SkillData>.get_Count
	|-List<SkinnedMeshRenderer>.get_Count
	|-List<SolverManager>.get_Count
	|-List<SortieEntrustStockData>.get_Count
	|-List<SortieEntrustUnitData>.get_Count
	|-List<SourceCode>.get_Count
	|-List<SourceRef>.get_Count
	|-List<SpringBone>.get_Count
	|-List<SpringCollider>.get_Count
	|-List<Sprite>.get_Count
	|-List<string>.get_Count
	|-List<StringBuilder>.get_Count
	|-List<StructProperty>.get_Count
	|-List<SymbolRef>.get_Count
	|-List<TMP_Character>.get_Count
	|-List<TMP_FontAsset>.get_Count
	|-List<TMP_Glyph>.get_Count
	|-List<TMP_GlyphPairAdjustmentRecord>.get_Count
	|-List<TMP_Sprite>.get_Count
	|-List<TMP_SpriteAsset>.get_Count
	|-List<TMP_SpriteCharacter>.get_Count
	|-List<TMP_SpriteGlyph>.get_Count
	|-List<TMP_Style>.get_Count
	|-List<TMP_Text>.get_Count
	|-List<Task>.get_Count
	|-List<TextMeshProUGUI>.get_Count
	|-List<Texture2D>.get_Count
	|-List<Thread>.get_Count
	|-List<TimeZoneInfo>.get_Count
	|-List<TimelineClip>.get_Count
	|-List<Timer>.get_Count
	|-List<TipsData>.get_Count
	|-List<Toggle>.get_Count
	|-List<TrackAsset>.get_Count
	|-List<Transform>.get_Count
	|-List<TutorialData>.get_Count
	|-List<TypeSpec>.get_Count
	|-List<Unit>.get_Count
	|-List<UnitItem>.get_Count
	|-List<UnitRelianceMapResult>.get_Count
	|-List<UnitRing>.get_Count
	|-List<UnityEvent>.get_Count
	|-List<UnityWebRequestAsyncOperation>.get_Count
	|-List<VersusMapEditCategoryContent>.get_Count
	|-List<VersusServerCasualMetaData>.get_Count
	|-List<VersusServerRankedMetaData>.get_Count
	|-List<VersusServerReplayMetaData>.get_Count
	|-List<Volume>.get_Count
	|-List<VolumeComponent>.get_Count
	|-List<WatchItem>.get_Count
	|-List<WindActor>.get_Count
	|-List<X509CertificateImpl>.get_Count
	|-List<XRDisplaySubsystem>.get_Count
	|-List<XRPass>.get_Count
	|-List<XmlSchema>.get_Count
	|-List<XmlSchemaElement>.get_Count
	|-List<XmlSchemaObject>.get_Count
	|-List<AICannon.CannonData>.get_Count
	|-List<AIInterruptAttack.Candidate>.get_Count
	|-List<AddressablesImpl.ResourceLocatorInfo>.get_Count
	|-List<AdhocAssetLoader.Asset>.get_Count
	|-List<AkBankManager.BankHandle>.get_Count
	|-List<AkEvent.CallbackData>.get_Count
	|-List<AkWwiseInitializationSettings.PlatformSettings>.get_Count
	|-List<AssetTable.Accessory>.get_Count
	|-List<CalculatorUtil.Entity>.get_Count
	|-List<ChapterRecord.Record>.get_Count
	|-List<CinemachineBrain.BrainFrame>.get_Count
	|-List<CinemachineImpulseManager.ImpulseEvent>.get_Count
	|-List<CinemachineStoryboard.CanvasInfo>.get_Count
	|-List<CinemachineVolumeSettings.VcamExtraState>.get_Count
	|-List<ClassChangeJobMenuItemContent.WeaponLevelItem>.get_Count
	|-List<CombatGaugeController.Value>.get_Count
	|-List<CombatViewerSettings.ViewerPhase>.get_Count
	|-List<ConditionGetterCommand.Command>.get_Count
	|-List<DamageInfo.Info>.get_Count
	|-List<DebugCommandline.Property>.get_Count
	|-List<DebugPathMenu.EntryData>.get_Count
	|-List<Directory.SearchData>.get_Count
	|-List<DishAllMenuContent.EnhanceObject>.get_Count
	|-List<DishSelectFoodInfoContent.FoodstuffObject>.get_Count
	|-List<DishSelectMenuCategoryContent.CategoryObject>.get_Count
	|-List<DragonRideTargetGroup.ChainSEManager>.get_Count
	|-List<Dropdown.DropdownItem>.get_Count
	|-List<Dropdown.OptionData>.get_Count
	|-List<DynamicsSetup.ParseMessage>.get_Count
	|-List<EventSequence.Coroutine>.get_Count
	|-List<EventTrigger.Entry>.get_Count
	|-List<ExchangeYesNoDialog.ItemParam>.get_Count
	|-List<GameSaveDataHeaderReader.Handle>.get_Count
	|-List<GmapMapInfoContent.ItemInfo>.get_Count
	|-List<GodGrowthData.LevelData>.get_Count
	|-List<GrassData.SpriteInfo>.get_Count
	|-List<HelpManager.Item>.get_Count
	|-List<HubMiniMap.IconData>.get_Count
	|-List<InvestmentMenuContent.AnimalInfo>.get_Count
	|-List<InvestmentMenuContent.DropItemInfo>.get_Count
	|-List<InvestmentNationDataMenu.AnimalInfo>.get_Count
	|-List<InvestmentNationDataMenu.ItemInfo>.get_Count
	|-List<ItemListYesNoDialog.ItemParam>.get_Count
	|-List<LaterTalkSetter.UnitData>.get_Count
	|-List<MapDispos.ActualData>.get_Count
	|-List<MapDispos.Pos>.get_Count
	|-List<MapEditHistory.MapEditCommand>.get_Count
	|-List<MapImageTerrain.MinimapInfo>.get_Count
	|-List<MapLayer.Data>.get_Count
	|-List<MapMaterial.Node>.get_Count
	|-List<MapObject.DitherPair>.get_Count
	|-List<MapObject.Pair>.get_Count
	|-List<MapObject.RigidInfo>.get_Count
	|-List<MapOverlap.Data>.get_Count
	|-List<MapTarget.Data>.get_Count
	|-List<MapTerrain.LayerData>.get_Count
	|-List<MapTerrain.OverlapData>.get_Count
	|-List<MuscleSquatSequence.RandomPack>.get_Count
	|-List<MyRoomWakeupSequence.RelianceWakeup>.get_Count
	|-List<PointerInputModule.ButtonState>.get_Count
	|-List<ProfileCard.FreeStamp>.get_Count
	|-List<RefineRingInfoWindow.RingRefineStatistics>.get_Count
	|-List<RegexCharClass.SingleRange>.get_Count
	|-List<RelayMessageMenuContent.KindIcon>.get_Count
	|-List<RelayUserData.EnteredBattle>.get_Count
	|-List<RelayWdwMapHelp.ShowItem>.get_Count
	|-List<RingListSequence.PageData>.get_Count
	|-List<SimpleAnimationPlayable.StateInfo>.get_Count
	|-List<SkillData.Func>.get_Count
	|-List<SolanelInfoMenuContent.HelpFastTravel>.get_Count
	|-List<SolanelInfoMenuContent.Infomation>.get_Count
	|-List<SoundSystem.LipSyncData>.get_Count
	|-List<SoundSystem.SoundHandle>.get_Count
	|-List<SpringColliderSerialization.IColliderSerializer>.get_Count
	|-List<SpringColliderSerialization.TransformSerializer>.get_Count
	|-List<StencilMaterial.MatEntry>.get_Count
	|-List<TMP_Dropdown.DropdownItem>.get_Count
	|-List<TMP_Dropdown.OptionData>.get_Count
	|-List<TMP_MaterialManager.FallbackMaterial>.get_Count
	|-List<TMP_MaterialManager.MaskingMaterial>.get_Count
	|-List<TextRecordParsing.Record>.get_Count
	|-List<TimeZoneInfo.AdjustmentRule>.get_Count
	|-List<TransformAnimation.Animator>.get_Count
	|-List<TroopListSortMenu.SortTitle>.get_Count
	|-List<UnitStatusSetter.SkillSetter>.get_Count
	|-List<UnitStatusSetter.WeaponLevelSetter>.get_Count
	|-List<GameSaveDataUtil.ProcDeleteAll.Data>.get_Count
	|-List<RelayCompletionAwardData.CalcResult.Item>.get_Count
	|-List<SoundWwise.SoundBankManager.BankHandle>.get_Count
	|-List<TransformAnimation.Animator.Node>.get_Count
	|
	|-RVA: 0x3B19D20 Offset: 0x3B19E21 VA: 0x3B19D20
	|-List<CommonBattleSequence.Reliance<object>>.get_Count
	|
	|-RVA: 0x3B1CF10 Offset: 0x3B1D011 VA: 0x3B1CF10
	|-List<RenderGraphResourcePool.ResourceLogInfo<object>>.get_Count
	|
	|-RVA: 0x3B1FE30 Offset: 0x3B1FF31 VA: 0x3B1FE30
	|-List<ValueTuple<int, object>>.get_Count
	|
	|-RVA: 0x3DE0AB0 Offset: 0x3DE0BB1 VA: 0x3DE0AB0
	|-List<ValueTuple<Int32Enum, int>>.get_Count
	|-List<ValueTuple<HubAccessManager.MaterialCalculator.Type, int>>.get_Count
	|
	|-RVA: 0x3DE38F0 Offset: 0x3DE39F1 VA: 0x3DE38F0
	|-List<ValueTuple<object, ValueTuple<object, int>>>.get_Count
	|
	|-RVA: 0x3DE6AE0 Offset: 0x3DE6BE1 VA: 0x3DE6AE0
	|-List<ValueTuple<object, int>>.get_Count
	|-List<ValueTuple<string, int>>.get_Count
	|
	|-RVA: 0x3DE99F0 Offset: 0x3DE9AF1 VA: 0x3DE99F0
	|-List<ValueTuple<Vector3, float>>.get_Count
	|
	|-RVA: 0x3DECA00 Offset: 0x3DECB01 VA: 0x3DECA00
	|-List<ValueTuple<ItemData.Kinds[], WeaponLevel.Kind, int>>.get_Count
	|-List<ValueTuple<object, Int32Enum, int>>.get_Count
	|
	|-RVA: 0x3DEF940 Offset: 0x3DEFA41 VA: 0x3DEF940
	|-List<ValueTuple<object, int, int, int>>.get_Count
	|-List<ValueTuple<string, int, int, int>>.get_Count
	|
	|-RVA: 0x3DF2B20 Offset: 0x3DF2C21 VA: 0x3DF2B20
	|-List<AnimatorClipInfo>.get_Count
	|
	|-RVA: 0x3DF5960 Offset: 0x3DF5A61 VA: 0x3DF5960
	|-List<AsyncOperationHandle>.get_Count
	|
	|-RVA: 0x3DF8B70 Offset: 0x3DF8C71 VA: 0x3DF8B70
	|-List<BoneWeight>.get_Count
	|
	|-RVA: 0x3DFBD30 Offset: 0x3DFBE31 VA: 0x3DFBD30
	|-List<bool>.get_Count
	|
	|-RVA: 0x3E79290 Offset: 0x3E79391 VA: 0x3E79290
	|-List<byte>.get_Count
	|
	|-RVA: 0x3E7C0B0 Offset: 0x3E7C1B1 VA: 0x3E7C0B0
	|-List<CameraInfo>.get_Count
	|
	|-RVA: 0x3E7EFC0 Offset: 0x3E7F0C1 VA: 0x3E7EFC0
	|-List<char>.get_Count
	|
	|-RVA: 0x3E81DC0 Offset: 0x3E81EC1 VA: 0x3E81DC0
	|-List<Color>.get_Count
	|
	|-RVA: 0x3E84DC0 Offset: 0x3E84EC1 VA: 0x3E84DC0
	|-List<Color32>.get_Count
	|
	|-RVA: 0x3E87BE0 Offset: 0x3E87CE1 VA: 0x3E87BE0
	|-List<ConstraintSource>.get_Count
	|
	|-RVA: 0x3E8AB20 Offset: 0x3E8AC21 VA: 0x3E8AB20
	|-List<ContourVertex>.get_Count
	|
	|-RVA: 0x3E8DD30 Offset: 0x3E8DE31 VA: 0x3E8DD30
	|-List<DataStoreRatingInfo>.get_Count
	|
	|-RVA: 0x3E90EE0 Offset: 0x3E90FE1 VA: 0x3E90EE0
	|-List<DataStoreResult>.get_Count
	|
	|-RVA: 0x3EAE990 Offset: 0x3EAEA91 VA: 0x3EAE990
	|-List<DataType>.get_Count
	|-List<Int32Enum>.get_Count
	|-List<RegexOptions>.get_Count
	|-List<CapabilityDefinition.Type>.get_Count
	|-List<Cooking.ConversationType>.get_Count
	|-List<ItemData.Kinds>.get_Count
	|-List<MapPanelActive.MeshIndex>.get_Count
	|-List<MapPanelDanger.MeshIndex>.get_Count
	|-List<MapPanelDeploy.MeshIndex>.get_Count
	|-List<MapUIGauge.IconIndex>.get_Count
	|-List<TutorialListTopMenu.SelectCategoryType>.get_Count
	|
	|-RVA: 0x3E93CF0 Offset: 0x3E93DF1 VA: 0x3E93CF0
	|-List<DateTime>.get_Count
	|
	|-RVA: 0x3E96B10 Offset: 0x3E96C11 VA: 0x3E96B10
	|-List<DateTimeOffset>.get_Count
	|
	|-RVA: 0x3E999F0 Offset: 0x3E99AF1 VA: 0x3E999F0
	|-List<Decimal>.get_Count
	|
	|-RVA: 0x3E9C900 Offset: 0x3E9CA01 VA: 0x3E9C900
	|-List<DiagnosticEvent>.get_Count
	|
	|-RVA: 0x3E9FD00 Offset: 0x3E9FE01 VA: 0x3E9FD00
	|-List<double>.get_Count
	|
	|-RVA: 0x3EA2B60 Offset: 0x3EA2C61 VA: 0x3EA2B60
	|-List<Friend>.get_Count
	|
	|-RVA: 0x3EA5EC0 Offset: 0x3EA5FC1 VA: 0x3EA5EC0
	|-List<GlyphRect>.get_Count
	|
	|-RVA: 0x3EA8D90 Offset: 0x3EA8E91 VA: 0x3EA8D90
	|-List<short>.get_Count
	|
	|-RVA: 0x3EABB90 Offset: 0x3EABC91 VA: 0x3EABB90
	|-List<int>.get_Count
	|
	|-RVA: 0x3EB1790 Offset: 0x3EB1891 VA: 0x3EB1790
	|-List<long>.get_Count
	|
	|-RVA: 0x3DFEB60 Offset: 0x3DFEC61 VA: 0x3DFEB60
	|-List<IntPtr>.get_Count
	|
	|-RVA: 0x3E01970 Offset: 0x3E01A71 VA: 0x3E01970
	|-List<InterpretedFrameInfo>.get_Count
	|
	|-RVA: 0x3E048B0 Offset: 0x3E049B1 VA: 0x3E048B0
	|-List<IntervalTreeNode>.get_Count
	|
	|-RVA: 0x3E07A60 Offset: 0x3E07B61 VA: 0x3E07A60
	|-List<LengthLimitProperties>.get_Count
	|
	|-RVA: 0x3E0A870 Offset: 0x3E0A971 VA: 0x3E0A870
	|-List<MapPos>.get_Count
	|
	|-RVA: 0x3E0D6D0 Offset: 0x3E0D7D1 VA: 0x3E0D6D0
	|-List<Matrix4x4>.get_Count
	|
	|-RVA: 0x3E13A00 Offset: 0x3E13B01 VA: 0x3E13A00
	|-List<ObjectInitializationData>.get_Count
	|
	|-RVA: 0x3E16E30 Offset: 0x3E16F31 VA: 0x3E16E30
	|-List<PlayableBinding>.get_Count
	|
	|-RVA: 0x3E1A060 Offset: 0x3E1A161 VA: 0x3E1A060
	|-List<PlayerLoopSystem>.get_Count
	|
	|-RVA: 0x3DA4500 Offset: 0x3DA4601 VA: 0x3DA4500
	|-List<PlayerLoopSystemInternal>.get_Count
	|
	|-RVA: 0x3DA78A0 Offset: 0x3DA79A1 VA: 0x3DA78A0
	|-List<RangePositionInfo>.get_Count
	|
	|-RVA: 0x3DAA7B0 Offset: 0x3DAA8B1 VA: 0x3DAA7B0
	|-List<Ranking2ChartInfoInput>.get_Count
	|
	|-RVA: 0x3DAD600 Offset: 0x3DAD701 VA: 0x3DAD600
	|-List<RaycastHit2D>.get_Count
	|
	|-RVA: 0x3DB0A40 Offset: 0x3DB0B41 VA: 0x3DB0A40
	|-List<RaycastResult>.get_Count
	|
	|-RVA: 0x3DB41F0 Offset: 0x3DB42F1 VA: 0x3DB41F0
	|-List<Rect>.get_Count
	|
	|-RVA: 0x3DB71F0 Offset: 0x3DB72F1 VA: 0x3DB71F0
	|-List<RendererListHandle>.get_Count
	|
	|-RVA: 0x3DBA000 Offset: 0x3DBA101 VA: 0x3DBA000
	|-List<ResourceHandle>.get_Count
	|
	|-RVA: 0x3DBCE10 Offset: 0x3DBCF11 VA: 0x3DBCE10
	|-List<sbyte>.get_Count
	|
	|-RVA: 0x3DBFC20 Offset: 0x3DBFD21 VA: 0x3DBFC20
	|-List<ShaderTagId>.get_Count
	|
	|-RVA: 0x3E3B880 Offset: 0x3E3B981 VA: 0x3E3B880
	|-List<float>.get_Count
	|
	|-RVA: 0x3E3E740 Offset: 0x3E3E841 VA: 0x3E3E740
	|-List<SphericalHarmonicsL2>.get_Count
	|
	|-RVA: 0x3E423C0 Offset: 0x3E424C1 VA: 0x3E423C0
	|-List<SubMeshDescriptor>.get_Count
	|
	|-RVA: 0x3E45780 Offset: 0x3E45881 VA: 0x3E45780
	|-List<TablePair>.get_Count
	|
	|-RVA: 0x3E48690 Offset: 0x3E48791 VA: 0x3E48690
	|-List<TimeSpan>.get_Count
	|
	|-RVA: 0x3E4B4A0 Offset: 0x3E4B5A1 VA: 0x3E4B4A0
	|-List<UICharInfo>.get_Count
	|
	|-RVA: 0x3E4E490 Offset: 0x3E4E591 VA: 0x3E4E490
	|-List<UILineInfo>.get_Count
	|
	|-RVA: 0x3E51400 Offset: 0x3E51501 VA: 0x3E51400
	|-List<UIVertex>.get_Count
	|
	|-RVA: 0x3E55040 Offset: 0x3E55141 VA: 0x3E55040
	|-List<ushort>.get_Count
	|
	|-RVA: 0x3E57E40 Offset: 0x3E57F41 VA: 0x3E57E40
	|-List<uint>.get_Count
	|
	|-RVA: 0x3DC2A30 Offset: 0x3DC2B31 VA: 0x3DC2A30
	|-List<ulong>.get_Count
	|
	|-RVA: 0x3DC5830 Offset: 0x3DC5931 VA: 0x3DC5830
	|-List<Vector2>.get_Count
	|
	|-RVA: 0x3DC8700 Offset: 0x3DC8801 VA: 0x3DC8700
	|-List<Vector3>.get_Count
	|
	|-RVA: 0x3DCB6E0 Offset: 0x3DCB7E1 VA: 0x3DCB6E0
	|-List<Vector4>.get_Count
	|
	|-RVA: 0x3DCE6F0 Offset: 0x3DCE7F1 VA: 0x3DCE6F0
	|-List<VertexAttributeDescriptor>.get_Count
	|
	|-RVA: 0x3DD15D0 Offset: 0x3DD16D1 VA: 0x3DD15D0
	|-List<X509ChainStatus>.get_Count
	|
	|-RVA: 0x3DD4520 Offset: 0x3DD4621 VA: 0x3DD4520
	|-List<XRView>.get_Count
	|
	|-RVA: 0x3DD78E0 Offset: 0x3DD79E1 VA: 0x3DD78E0
	|-List<AmiiboSequence.GainItemData>.get_Count
	|
	|-RVA: 0x3DDA830 Offset: 0x3DDA931 VA: 0x3DDA830
	|-List<AnimationOutputWeightProcessor.WeightInfo>.get_Count
	|
	|-RVA: 0x3DDDBA0 Offset: 0x3DDDCA1 VA: 0x3DDDBA0
	|-List<ArenaOrderSequence.GodInfo>.get_Count
	|
	|-RVA: 0x3E1D400 Offset: 0x3E1D501 VA: 0x3E1D400
	|-List<BattleInfo.SupportData>.get_Count
	|
	|-RVA: 0x3E20320 Offset: 0x3E20421 VA: 0x3E20320
	|-List<BeforeRenderHelper.OrderBlock>.get_Count
	|
	|-RVA: 0x3E23260 Offset: 0x3E23361 VA: 0x3E23260
	|-List<Camera.RenderRequest>.get_Count
	|
	|-RVA: 0x3E26470 Offset: 0x3E26571 VA: 0x3E26470
	|-List<CameraState.CustomBlendable>.get_Count
	|
	|-RVA: 0x3E29380 Offset: 0x3E29481 VA: 0x3E29380
	|-List<CinemachineClearShot.Pair>.get_Count
	|
	|-RVA: 0x3E2C190 Offset: 0x3E2C291 VA: 0x3E2C190
	|-List<CinemachineStateDrivenCamera.HashPair>.get_Count
	|
	|-RVA: 0x3E2EFD0 Offset: 0x3E2F0D1 VA: 0x3E2EFD0
	|-List<DelayedActionManager.DelegateInfo>.get_Count
	|
	|-RVA: 0x3E32200 Offset: 0x3E32301 VA: 0x3E32200
	|-List<Detail.AsyncResultInt>.get_Count
	|
	|-RVA: 0x3E355C0 Offset: 0x3E356C1 VA: 0x3E355C0
	|-List<Detail.CppArray>.get_Count
	|
	|-RVA: 0x3E384D0 Offset: 0x3E385D1 VA: 0x3E384D0
	|-List<Detail.NotificationEventInt>.get_Count
	|
	|-RVA: 0x3E5AC50 Offset: 0x3E5AD51 VA: 0x3E5AC50
	|-List<DragonRideTargetGroup.ChainParam>.get_Count
	|
	|-RVA: 0x3E5DB90 Offset: 0x3E5DC91 VA: 0x3E5DB90
	|-List<GmapPathAdjuster.TargetModel>.get_Count
	|
	|-RVA: 0x3E60DA0 Offset: 0x3E60EA1 VA: 0x3E60DA0
	|-List<GmapSpotAdjuster.TargetModel>.get_Count
	|
	|-RVA: 0x3E63FB0 Offset: 0x3E640B1 VA: 0x3E63FB0
	|-List<HubFastTravel.Location>.get_Count
	|
	|-RVA: 0x3E671D0 Offset: 0x3E672D1 VA: 0x3E671D0
	|-List<HubLensFlare.Flare>.get_Count
	|
	|-RVA: 0x3E6A5E0 Offset: 0x3E6A6E1 VA: 0x3E6A5E0
	|-List<InventoryPoolItemMenuContent.KindBgNameClass>.get_Count
	|
	|-RVA: 0x3E6D4F0 Offset: 0x3E6D5F1 VA: 0x3E6D4F0
	|-List<Map.Pos>.get_Count
	|
	|-RVA: 0x3E70310 Offset: 0x3E70411 VA: 0x3E70310
	|-List<MapImage.BackupTerrain>.get_Count
	|
	|-RVA: 0x3E731F0 Offset: 0x3E732F1 VA: 0x3E731F0
	|-List<MapImageRange.Pos>.get_Count
	|
	|-RVA: 0x3E760B0 Offset: 0x3E761B1 VA: 0x3E760B0
	|-List<MapMind.Target>.get_Count
	|
	|-RVA: 0x3D85CB0 Offset: 0x3D85DB1 VA: 0x3D85CB0
	|-List<MapPanelDebug.Entity>.get_Count
	|
	|-RVA: 0x3D88E60 Offset: 0x3D88F61 VA: 0x3D88E60
	|-List<NexRanking.Data>.get_Count
	|
	|-RVA: 0x3D8BC80 Offset: 0x3D8BD81 VA: 0x3D8BC80
	|-List<NexVersus.RatingData>.get_Count
	|
	|-RVA: 0x3D8EB60 Offset: 0x3D8EC61 VA: 0x3D8EB60
	|-List<PackedPlayModeBuildLogs.RuntimeBuildLog>.get_Count
	|
	|-RVA: 0x3D91AB0 Offset: 0x3D91BB1 VA: 0x3D91AB0
	|-List<ParticleSystem.Particle>.get_Count
	|
	|-RVA: 0x3D94E20 Offset: 0x3D94F21 VA: 0x3D94E20
	|-List<RangeData.Offset>.get_Count
	|
	|-RVA: 0x3D97C60 Offset: 0x3D97D61 VA: 0x3D97C60
	|-List<RenderGraphDebugData.PassDebugData>.get_Count
	|
	|-RVA: 0x3D9AE90 Offset: 0x3D9AF91 VA: 0x3D9AE90
	|-List<RenderGraphDebugData.ResourceDebugData>.get_Count
	|
	|-RVA: 0x3D9E230 Offset: 0x3D9E331 VA: 0x3D9E230
	|-List<RingCleaningUnitSelectMenu.GodParam>.get_Count
	|
	|-RVA: 0x3DA1180 Offset: 0x3DA1281 VA: 0x3DA1180
	|-List<ShadowUtility.Edge>.get_Count
	|
	|-RVA: 0x3D13990 Offset: 0x3D13A91 VA: 0x3D13990
	|-List<SkillArray.Entity>.get_Count
	|
	|-RVA: 0x3D167F0 Offset: 0x3D168F1 VA: 0x3D167F0
	|-List<TexturePacker_JsonArray.Frame>.get_Count
	|
	|-RVA: 0x3D19D90 Offset: 0x3D19E91 VA: 0x3D19D90
	|-List<TimeNotificationBehaviour.NotificationEntry>.get_Count
	|
	|-RVA: 0x3D1CFC0 Offset: 0x3D1D0C1 VA: 0x3D1CFC0
	|-List<UnitySynchronizationContext.WorkRequest>.get_Count
	|
	|-RVA: 0x3D201B0 Offset: 0x3D202B1 VA: 0x3D201B0
	|-List<XmlSchemaObjectTable.XmlSchemaObjectEntry>.get_Count
	|
	|-RVA: 0x3D230D0 Offset: 0x3D231D1 VA: 0x3D230D0
	|-List<AssetBundleBuildMap.AssetBundleEntry.AssetPathString>.get_Count
	|
	|-RVA: 0x3D26020 Offset: 0x3D26121 VA: 0x3D26020
	|-List<Detail.DataStore.DataStoreChangeMetaParamInt>.get_Count
	|
	|-RVA: 0x3D29410 Offset: 0x3D29511 VA: 0x3D29410
	|-List<Detail.DataStore.DataStoreDeleteParamInt>.get_Count
	|
	|-RVA: 0x3D2C320 Offset: 0x3D2C421 VA: 0x3D2C320
	|-List<Detail.DataStore.DataStoreGetMetaParamInt>.get_Count
	|
	|-RVA: 0x3D2F6C0 Offset: 0x3D2F7C1 VA: 0x3D2F6C0
	|-List<Detail.DataStore.DataStoreMetaInfoInt>.get_Count
	|
	|-RVA: 0x3CF3EF0 Offset: 0x3CF3FF1 VA: 0x3CF3EF0
	|-List<Detail.DataStore.DataStorePasswordInfoInt>.get_Count
	|
	|-RVA: 0x3CF70D0 Offset: 0x3CF71D1 VA: 0x3CF70D0
	|-List<Detail.DataStore.DataStorePersistenceInfoInt>.get_Count
	|
	|-RVA: 0x3CFA2C0 Offset: 0x3CFA3C1 VA: 0x3CFA2C0
	|-List<Detail.DataStore.DataStorePreparePostParamInt>.get_Count
	|
	|-RVA: 0x3CFD640 Offset: 0x3CFD741 VA: 0x3CFD640
	|-List<Detail.DataStore.DataStoreRateObjectParamInt>.get_Count
	|
	|-RVA: 0x3D00540 Offset: 0x3D00641 VA: 0x3D00540
	|-List<Detail.DataStore.DataStoreRatingInitParamInt>.get_Count
	|
	|-RVA: 0x3D03710 Offset: 0x3D03811 VA: 0x3D03710
	|-List<Detail.DataStore.DataStoreRatingTargetInt>.get_Count
	|
	|-RVA: 0x3D06640 Offset: 0x3D06741 VA: 0x3D06640
	|-List<Detail.Ranking.RankingCachedResultInt>.get_Count
	|
	|-RVA: 0x3D09BD0 Offset: 0x3D09CD1 VA: 0x3D09BD0
	|-List<Detail.Ranking.RankingOrderParamInt>.get_Count
	|
	|-RVA: 0x3D0CAF0 Offset: 0x3D0CBF1 VA: 0x3D0CAF0
	|-List<Detail.Ranking.RankingRankDataInt>.get_Count
	|
	|-RVA: 0x3D10090 Offset: 0x3D10191 VA: 0x3D10090
	|-List<Detail.Ranking2.Ranking2ChartInfoInt>.get_Count
	|
	|-RVA: 0x3D66A70 Offset: 0x3D66B71 VA: 0x3D66A70
	|-List<Detail.Ranking2.Ranking2RankDataInt>.get_Count
	|
	|-RVA: 0x3D69FB0 Offset: 0x3D6A0B1 VA: 0x3D69FB0
	|-List<Detail.Ranking2.Ranking2ScoreDataInt>.get_Count
	|
	|-RVA: 0x3D6CEB0 Offset: 0x3D6CFB1 VA: 0x3D6CEB0
	|-List<Detail.Screening.ScreeningContextInfoInt>.get_Count
	|
	|-RVA: 0x3D700D0 Offset: 0x3D701D1 VA: 0x3D700D0
	|-List<Detail.Subscriber.SubscriberContentInt>.get_Count
	|
	|-RVA: 0x3D73870 Offset: 0x3D73971 VA: 0x3D73870
	|-List<Detail.Subscriber.SubscriberGetContentParamInt>.get_Count
	|
	|-RVA: 0x3D76A60 Offset: 0x3D76B61 VA: 0x3D76A60
	|-List<Detail.Subscriber.SubscriberUserStatusInfoInt>.get_Count
	|
	|-RVA: 0x3D79DF0 Offset: 0x3D79EF1 VA: 0x3D79DF0
	|-List<Detail.Subscriber.SubscriberUserStatusParamInt>.get_Count
	|
	|-RVA: 0x3D7CFA0 Offset: 0x3D7D0A1 VA: 0x3D7CFA0
	|-List<Detail.Utility.IntegerSettings>.get_Count
	|
	|-RVA: 0x3D7FDC0 Offset: 0x3D7FEC1 VA: 0x3D7FDC0
	|-List<Detail.Utility.UniqueIdInfoInt>.get_Count
	|
	|-RVA: 0x3D82CA0 Offset: 0x3D82DA1 VA: 0x3D82CA0
	|-List<MapHistory.Rewind.LatestInspectorData>.get_Count
	|
	|-RVA: 0x305EF60 Offset: 0x305F061 VA: 0x305EF60
	|-List<MapHistory.Rewind.WorkTerrainData>.get_Count
	|
	|-RVA: 0x3061F50 Offset: 0x3062051 VA: 0x3061F50
	|-List<MapSkill.AroundCalculator.Result>.get_Count
	|
	|-RVA: 0x3064EA0 Offset: 0x3064FA1 VA: 0x3064EA0
	|-List<TargetPositionCache.CacheCurve.Item>.get_Count
	|
	|-RVA: 0x3068220 Offset: 0x3068321 VA: 0x3068220
	|-List<TargetPositionCache.CacheEntry.RecordingItem>.get_Count
	*/

	// RVA: -1 Offset: -1 Slot: 10
	private bool System.Collections.Generic.ICollection<T>.get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3B0ABA0 Offset: 0x3B0ACA1 VA: 0x3B0ABA0
	|-List<IntervalTree.Entry<object>>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3B0DD90 Offset: 0x3B0DE91 VA: 0x3B0DD90
	|-List<KeyValuePair<DateTime, object>>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3B10CB0 Offset: 0x3B10DB1 VA: 0x3B10CB0
	|-List<KeyValuePair<int, object>>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3B13BF0 Offset: 0x3B13CF1 VA: 0x3B13BF0
	|-List<KeyValuePair<object, ValueTuple<int, DateTime, object>>>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3B16DF0 Offset: 0x3B16EF1 VA: 0x3B16DF0
	|-List<KeyValuePair<object, object>>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3B19D30 Offset: 0x3B19E31 VA: 0x3B19D30
	|-List<CommonBattleSequence.Reliance<object>>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3B1CF20 Offset: 0x3B1D021 VA: 0x3B1CF20
	|-List<RenderGraphResourcePool.ResourceLogInfo<object>>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3B1FE40 Offset: 0x3B1FF41 VA: 0x3B1FE40
	|-List<ValueTuple<int, object>>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3DE0AC0 Offset: 0x3DE0BC1 VA: 0x3DE0AC0
	|-List<ValueTuple<Int32Enum, int>>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3DE3900 Offset: 0x3DE3A01 VA: 0x3DE3900
	|-List<ValueTuple<object, ValueTuple<object, int>>>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3DE6AF0 Offset: 0x3DE6BF1 VA: 0x3DE6AF0
	|-List<ValueTuple<object, int>>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3DE9A00 Offset: 0x3DE9B01 VA: 0x3DE9A00
	|-List<ValueTuple<Vector3, float>>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3DECA10 Offset: 0x3DECB11 VA: 0x3DECA10
	|-List<ValueTuple<object, Int32Enum, int>>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3DEF950 Offset: 0x3DEFA51 VA: 0x3DEF950
	|-List<ValueTuple<object, int, int, int>>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3DF2B30 Offset: 0x3DF2C31 VA: 0x3DF2B30
	|-List<AnimatorClipInfo>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3DF5970 Offset: 0x3DF5A71 VA: 0x3DF5970
	|-List<AsyncOperationHandle>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3DF8B80 Offset: 0x3DF8C81 VA: 0x3DF8B80
	|-List<BoneWeight>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3DFBD40 Offset: 0x3DFBE41 VA: 0x3DFBD40
	|-List<bool>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3E792A0 Offset: 0x3E793A1 VA: 0x3E792A0
	|-List<byte>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3E10C10 Offset: 0x3E10D11 VA: 0x3E10C10
	|-List<Camera>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-List<Decorator>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-List<DynValue>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-List<GameObject>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-List<MapBackup>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-List<object>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-List<Phase>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-List<ProfileCard>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-List<Unit>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-List<AssetTable.Accessory>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-List<GameSaveDataHeaderReader.Handle>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-List<MapDispos.ActualData>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-List<MapDispos.Pos>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-List<MapLayer.Data>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-List<MapObject.RigidInfo>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-List<RingListSequence.PageData>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3E7C0C0 Offset: 0x3E7C1C1 VA: 0x3E7C0C0
	|-List<CameraInfo>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3E7EFD0 Offset: 0x3E7F0D1 VA: 0x3E7EFD0
	|-List<char>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3E81DD0 Offset: 0x3E81ED1 VA: 0x3E81DD0
	|-List<Color>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3E84DD0 Offset: 0x3E84ED1 VA: 0x3E84DD0
	|-List<Color32>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3E87BF0 Offset: 0x3E87CF1 VA: 0x3E87BF0
	|-List<ConstraintSource>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3E8AB30 Offset: 0x3E8AC31 VA: 0x3E8AB30
	|-List<ContourVertex>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3E8DD40 Offset: 0x3E8DE41 VA: 0x3E8DD40
	|-List<DataStoreRatingInfo>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3E90EF0 Offset: 0x3E90FF1 VA: 0x3E90EF0
	|-List<DataStoreResult>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3E93D00 Offset: 0x3E93E01 VA: 0x3E93D00
	|-List<DateTime>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3E96B20 Offset: 0x3E96C21 VA: 0x3E96B20
	|-List<DateTimeOffset>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3E99A00 Offset: 0x3E99B01 VA: 0x3E99A00
	|-List<Decimal>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3E9C910 Offset: 0x3E9CA11 VA: 0x3E9C910
	|-List<DiagnosticEvent>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3E9FD10 Offset: 0x3E9FE11 VA: 0x3E9FD10
	|-List<double>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3EA2B70 Offset: 0x3EA2C71 VA: 0x3EA2B70
	|-List<Friend>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3EA5ED0 Offset: 0x3EA5FD1 VA: 0x3EA5ED0
	|-List<GlyphRect>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3EA8DA0 Offset: 0x3EA8EA1 VA: 0x3EA8DA0
	|-List<short>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3EABBA0 Offset: 0x3EABCA1 VA: 0x3EABBA0
	|-List<int>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3EAE9A0 Offset: 0x3EAEAA1 VA: 0x3EAE9A0
	|-List<Int32Enum>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3EB17A0 Offset: 0x3EB18A1 VA: 0x3EB17A0
	|-List<long>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3DFEB70 Offset: 0x3DFEC71 VA: 0x3DFEB70
	|-List<IntPtr>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3E01980 Offset: 0x3E01A81 VA: 0x3E01980
	|-List<InterpretedFrameInfo>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3E048C0 Offset: 0x3E049C1 VA: 0x3E048C0
	|-List<IntervalTreeNode>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3E07A70 Offset: 0x3E07B71 VA: 0x3E07A70
	|-List<LengthLimitProperties>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3E0A880 Offset: 0x3E0A981 VA: 0x3E0A880
	|-List<MapPos>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3E0D6E0 Offset: 0x3E0D7E1 VA: 0x3E0D6E0
	|-List<Matrix4x4>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3E13A10 Offset: 0x3E13B11 VA: 0x3E13A10
	|-List<ObjectInitializationData>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3E16E40 Offset: 0x3E16F41 VA: 0x3E16E40
	|-List<PlayableBinding>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3E1A070 Offset: 0x3E1A171 VA: 0x3E1A070
	|-List<PlayerLoopSystem>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3DA4510 Offset: 0x3DA4611 VA: 0x3DA4510
	|-List<PlayerLoopSystemInternal>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3DA78B0 Offset: 0x3DA79B1 VA: 0x3DA78B0
	|-List<RangePositionInfo>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3DAA7C0 Offset: 0x3DAA8C1 VA: 0x3DAA7C0
	|-List<Ranking2ChartInfoInput>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3DAD610 Offset: 0x3DAD711 VA: 0x3DAD610
	|-List<RaycastHit2D>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3DB0A50 Offset: 0x3DB0B51 VA: 0x3DB0A50
	|-List<RaycastResult>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3DB4200 Offset: 0x3DB4301 VA: 0x3DB4200
	|-List<Rect>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3DB7200 Offset: 0x3DB7301 VA: 0x3DB7200
	|-List<RendererListHandle>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3DBA010 Offset: 0x3DBA111 VA: 0x3DBA010
	|-List<ResourceHandle>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3DBCE20 Offset: 0x3DBCF21 VA: 0x3DBCE20
	|-List<sbyte>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3DBFC30 Offset: 0x3DBFD31 VA: 0x3DBFC30
	|-List<ShaderTagId>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3E3B890 Offset: 0x3E3B991 VA: 0x3E3B890
	|-List<float>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3E3E750 Offset: 0x3E3E851 VA: 0x3E3E750
	|-List<SphericalHarmonicsL2>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3E423D0 Offset: 0x3E424D1 VA: 0x3E423D0
	|-List<SubMeshDescriptor>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3E45790 Offset: 0x3E45891 VA: 0x3E45790
	|-List<TablePair>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3E486A0 Offset: 0x3E487A1 VA: 0x3E486A0
	|-List<TimeSpan>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3E4B4B0 Offset: 0x3E4B5B1 VA: 0x3E4B4B0
	|-List<UICharInfo>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3E4E4A0 Offset: 0x3E4E5A1 VA: 0x3E4E4A0
	|-List<UILineInfo>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3E51410 Offset: 0x3E51511 VA: 0x3E51410
	|-List<UIVertex>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3E55050 Offset: 0x3E55151 VA: 0x3E55050
	|-List<ushort>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3E57E50 Offset: 0x3E57F51 VA: 0x3E57E50
	|-List<uint>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3DC2A40 Offset: 0x3DC2B41 VA: 0x3DC2A40
	|-List<ulong>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3DC5840 Offset: 0x3DC5941 VA: 0x3DC5840
	|-List<Vector2>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3DC8710 Offset: 0x3DC8811 VA: 0x3DC8710
	|-List<Vector3>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3DCB6F0 Offset: 0x3DCB7F1 VA: 0x3DCB6F0
	|-List<Vector4>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3DCE700 Offset: 0x3DCE801 VA: 0x3DCE700
	|-List<VertexAttributeDescriptor>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3DD15E0 Offset: 0x3DD16E1 VA: 0x3DD15E0
	|-List<X509ChainStatus>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3DD4530 Offset: 0x3DD4631 VA: 0x3DD4530
	|-List<XRView>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3DD78F0 Offset: 0x3DD79F1 VA: 0x3DD78F0
	|-List<AmiiboSequence.GainItemData>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3DDA840 Offset: 0x3DDA941 VA: 0x3DDA840
	|-List<AnimationOutputWeightProcessor.WeightInfo>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3DDDBB0 Offset: 0x3DDDCB1 VA: 0x3DDDBB0
	|-List<ArenaOrderSequence.GodInfo>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3E1D410 Offset: 0x3E1D511 VA: 0x3E1D410
	|-List<BattleInfo.SupportData>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3E20330 Offset: 0x3E20431 VA: 0x3E20330
	|-List<BeforeRenderHelper.OrderBlock>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3E23270 Offset: 0x3E23371 VA: 0x3E23270
	|-List<Camera.RenderRequest>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3E26480 Offset: 0x3E26581 VA: 0x3E26480
	|-List<CameraState.CustomBlendable>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3E29390 Offset: 0x3E29491 VA: 0x3E29390
	|-List<CinemachineClearShot.Pair>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3E2C1A0 Offset: 0x3E2C2A1 VA: 0x3E2C1A0
	|-List<CinemachineStateDrivenCamera.HashPair>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3E2EFE0 Offset: 0x3E2F0E1 VA: 0x3E2EFE0
	|-List<DelayedActionManager.DelegateInfo>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3E32210 Offset: 0x3E32311 VA: 0x3E32210
	|-List<Detail.AsyncResultInt>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3E355D0 Offset: 0x3E356D1 VA: 0x3E355D0
	|-List<Detail.CppArray>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3E384E0 Offset: 0x3E385E1 VA: 0x3E384E0
	|-List<Detail.NotificationEventInt>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3E5AC60 Offset: 0x3E5AD61 VA: 0x3E5AC60
	|-List<DragonRideTargetGroup.ChainParam>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3E5DBA0 Offset: 0x3E5DCA1 VA: 0x3E5DBA0
	|-List<GmapPathAdjuster.TargetModel>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3E60DB0 Offset: 0x3E60EB1 VA: 0x3E60DB0
	|-List<GmapSpotAdjuster.TargetModel>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3E63FC0 Offset: 0x3E640C1 VA: 0x3E63FC0
	|-List<HubFastTravel.Location>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3E671E0 Offset: 0x3E672E1 VA: 0x3E671E0
	|-List<HubLensFlare.Flare>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3E6A5F0 Offset: 0x3E6A6F1 VA: 0x3E6A5F0
	|-List<InventoryPoolItemMenuContent.KindBgNameClass>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3E6D500 Offset: 0x3E6D601 VA: 0x3E6D500
	|-List<Map.Pos>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3E70320 Offset: 0x3E70421 VA: 0x3E70320
	|-List<MapImage.BackupTerrain>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3E73200 Offset: 0x3E73301 VA: 0x3E73200
	|-List<MapImageRange.Pos>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3E760C0 Offset: 0x3E761C1 VA: 0x3E760C0
	|-List<MapMind.Target>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3D85CC0 Offset: 0x3D85DC1 VA: 0x3D85CC0
	|-List<MapPanelDebug.Entity>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3D88E70 Offset: 0x3D88F71 VA: 0x3D88E70
	|-List<NexRanking.Data>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3D8BC90 Offset: 0x3D8BD91 VA: 0x3D8BC90
	|-List<NexVersus.RatingData>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3D8EB70 Offset: 0x3D8EC71 VA: 0x3D8EB70
	|-List<PackedPlayModeBuildLogs.RuntimeBuildLog>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3D91AC0 Offset: 0x3D91BC1 VA: 0x3D91AC0
	|-List<ParticleSystem.Particle>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3D94E30 Offset: 0x3D94F31 VA: 0x3D94E30
	|-List<RangeData.Offset>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3D97C70 Offset: 0x3D97D71 VA: 0x3D97C70
	|-List<RenderGraphDebugData.PassDebugData>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3D9AEA0 Offset: 0x3D9AFA1 VA: 0x3D9AEA0
	|-List<RenderGraphDebugData.ResourceDebugData>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3D9E240 Offset: 0x3D9E341 VA: 0x3D9E240
	|-List<RingCleaningUnitSelectMenu.GodParam>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3DA1190 Offset: 0x3DA1291 VA: 0x3DA1190
	|-List<ShadowUtility.Edge>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3D139A0 Offset: 0x3D13AA1 VA: 0x3D139A0
	|-List<SkillArray.Entity>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3D16800 Offset: 0x3D16901 VA: 0x3D16800
	|-List<TexturePacker_JsonArray.Frame>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3D19DA0 Offset: 0x3D19EA1 VA: 0x3D19DA0
	|-List<TimeNotificationBehaviour.NotificationEntry>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3D1CFD0 Offset: 0x3D1D0D1 VA: 0x3D1CFD0
	|-List<UnitySynchronizationContext.WorkRequest>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3D201C0 Offset: 0x3D202C1 VA: 0x3D201C0
	|-List<XmlSchemaObjectTable.XmlSchemaObjectEntry>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3D230E0 Offset: 0x3D231E1 VA: 0x3D230E0
	|-List<AssetBundleBuildMap.AssetBundleEntry.AssetPathString>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3D26030 Offset: 0x3D26131 VA: 0x3D26030
	|-List<Detail.DataStore.DataStoreChangeMetaParamInt>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3D29420 Offset: 0x3D29521 VA: 0x3D29420
	|-List<Detail.DataStore.DataStoreDeleteParamInt>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3D2C330 Offset: 0x3D2C431 VA: 0x3D2C330
	|-List<Detail.DataStore.DataStoreGetMetaParamInt>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3D2F6D0 Offset: 0x3D2F7D1 VA: 0x3D2F6D0
	|-List<Detail.DataStore.DataStoreMetaInfoInt>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3CF3F00 Offset: 0x3CF4001 VA: 0x3CF3F00
	|-List<Detail.DataStore.DataStorePasswordInfoInt>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3CF70E0 Offset: 0x3CF71E1 VA: 0x3CF70E0
	|-List<Detail.DataStore.DataStorePersistenceInfoInt>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3CFA2D0 Offset: 0x3CFA3D1 VA: 0x3CFA2D0
	|-List<Detail.DataStore.DataStorePreparePostParamInt>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3CFD650 Offset: 0x3CFD751 VA: 0x3CFD650
	|-List<Detail.DataStore.DataStoreRateObjectParamInt>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3D00550 Offset: 0x3D00651 VA: 0x3D00550
	|-List<Detail.DataStore.DataStoreRatingInitParamInt>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3D03720 Offset: 0x3D03821 VA: 0x3D03720
	|-List<Detail.DataStore.DataStoreRatingTargetInt>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3D06650 Offset: 0x3D06751 VA: 0x3D06650
	|-List<Detail.Ranking.RankingCachedResultInt>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3D09BE0 Offset: 0x3D09CE1 VA: 0x3D09BE0
	|-List<Detail.Ranking.RankingOrderParamInt>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3D0CB00 Offset: 0x3D0CC01 VA: 0x3D0CB00
	|-List<Detail.Ranking.RankingRankDataInt>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3D100A0 Offset: 0x3D101A1 VA: 0x3D100A0
	|-List<Detail.Ranking2.Ranking2ChartInfoInt>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3D66A80 Offset: 0x3D66B81 VA: 0x3D66A80
	|-List<Detail.Ranking2.Ranking2RankDataInt>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3D69FC0 Offset: 0x3D6A0C1 VA: 0x3D69FC0
	|-List<Detail.Ranking2.Ranking2ScoreDataInt>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3D6CEC0 Offset: 0x3D6CFC1 VA: 0x3D6CEC0
	|-List<Detail.Screening.ScreeningContextInfoInt>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3D700E0 Offset: 0x3D701E1 VA: 0x3D700E0
	|-List<Detail.Subscriber.SubscriberContentInt>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3D73880 Offset: 0x3D73981 VA: 0x3D73880
	|-List<Detail.Subscriber.SubscriberGetContentParamInt>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3D76A70 Offset: 0x3D76B71 VA: 0x3D76A70
	|-List<Detail.Subscriber.SubscriberUserStatusInfoInt>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3D79E00 Offset: 0x3D79F01 VA: 0x3D79E00
	|-List<Detail.Subscriber.SubscriberUserStatusParamInt>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3D7CFB0 Offset: 0x3D7D0B1 VA: 0x3D7CFB0
	|-List<Detail.Utility.IntegerSettings>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3D7FDD0 Offset: 0x3D7FED1 VA: 0x3D7FDD0
	|-List<Detail.Utility.UniqueIdInfoInt>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3D82CB0 Offset: 0x3D82DB1 VA: 0x3D82CB0
	|-List<MapHistory.Rewind.LatestInspectorData>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x305EF70 Offset: 0x305F071 VA: 0x305EF70
	|-List<MapHistory.Rewind.WorkTerrainData>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3061F60 Offset: 0x3062061 VA: 0x3061F60
	|-List<MapSkill.AroundCalculator.Result>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3064EB0 Offset: 0x3064FB1 VA: 0x3064EB0
	|-List<TargetPositionCache.CacheCurve.Item>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3068230 Offset: 0x3068331 VA: 0x3068230
	|-List<TargetPositionCache.CacheEntry.RecordingItem>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 23
	private bool System.Collections.IList.get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3B0ABB0 Offset: 0x3B0ACB1 VA: 0x3B0ABB0
	|-List<IntervalTree.Entry<object>>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3B0DDA0 Offset: 0x3B0DEA1 VA: 0x3B0DDA0
	|-List<KeyValuePair<DateTime, object>>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3B10CC0 Offset: 0x3B10DC1 VA: 0x3B10CC0
	|-List<KeyValuePair<int, object>>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3B13C00 Offset: 0x3B13D01 VA: 0x3B13C00
	|-List<KeyValuePair<object, ValueTuple<int, DateTime, object>>>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3B16E00 Offset: 0x3B16F01 VA: 0x3B16E00
	|-List<KeyValuePair<object, object>>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3B19D40 Offset: 0x3B19E41 VA: 0x3B19D40
	|-List<CommonBattleSequence.Reliance<object>>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3B1CF30 Offset: 0x3B1D031 VA: 0x3B1CF30
	|-List<RenderGraphResourcePool.ResourceLogInfo<object>>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3B1FE50 Offset: 0x3B1FF51 VA: 0x3B1FE50
	|-List<ValueTuple<int, object>>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3DE0AD0 Offset: 0x3DE0BD1 VA: 0x3DE0AD0
	|-List<ValueTuple<Int32Enum, int>>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3DE3910 Offset: 0x3DE3A11 VA: 0x3DE3910
	|-List<ValueTuple<object, ValueTuple<object, int>>>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3DE6B00 Offset: 0x3DE6C01 VA: 0x3DE6B00
	|-List<ValueTuple<object, int>>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3DE9A10 Offset: 0x3DE9B11 VA: 0x3DE9A10
	|-List<ValueTuple<Vector3, float>>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3DECA20 Offset: 0x3DECB21 VA: 0x3DECA20
	|-List<ValueTuple<object, Int32Enum, int>>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3DEF960 Offset: 0x3DEFA61 VA: 0x3DEF960
	|-List<ValueTuple<object, int, int, int>>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3DF2B40 Offset: 0x3DF2C41 VA: 0x3DF2B40
	|-List<AnimatorClipInfo>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3DF5980 Offset: 0x3DF5A81 VA: 0x3DF5980
	|-List<AsyncOperationHandle>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3DF8B90 Offset: 0x3DF8C91 VA: 0x3DF8B90
	|-List<BoneWeight>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3DFBD50 Offset: 0x3DFBE51 VA: 0x3DFBD50
	|-List<bool>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3E792B0 Offset: 0x3E793B1 VA: 0x3E792B0
	|-List<byte>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3E10C20 Offset: 0x3E10D21 VA: 0x3E10C20
	|-List<Camera>.System.Collections.IList.get_IsReadOnly
	|-List<Decorator>.System.Collections.IList.get_IsReadOnly
	|-List<DynValue>.System.Collections.IList.get_IsReadOnly
	|-List<GameObject>.System.Collections.IList.get_IsReadOnly
	|-List<MapBackup>.System.Collections.IList.get_IsReadOnly
	|-List<object>.System.Collections.IList.get_IsReadOnly
	|-List<Phase>.System.Collections.IList.get_IsReadOnly
	|-List<ProfileCard>.System.Collections.IList.get_IsReadOnly
	|-List<Unit>.System.Collections.IList.get_IsReadOnly
	|-List<AssetTable.Accessory>.System.Collections.IList.get_IsReadOnly
	|-List<GameSaveDataHeaderReader.Handle>.System.Collections.IList.get_IsReadOnly
	|-List<MapDispos.ActualData>.System.Collections.IList.get_IsReadOnly
	|-List<MapDispos.Pos>.System.Collections.IList.get_IsReadOnly
	|-List<MapLayer.Data>.System.Collections.IList.get_IsReadOnly
	|-List<MapObject.RigidInfo>.System.Collections.IList.get_IsReadOnly
	|-List<RingListSequence.PageData>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3E7C0D0 Offset: 0x3E7C1D1 VA: 0x3E7C0D0
	|-List<CameraInfo>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3E7EFE0 Offset: 0x3E7F0E1 VA: 0x3E7EFE0
	|-List<char>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3E81DE0 Offset: 0x3E81EE1 VA: 0x3E81DE0
	|-List<Color>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3E84DE0 Offset: 0x3E84EE1 VA: 0x3E84DE0
	|-List<Color32>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3E87C00 Offset: 0x3E87D01 VA: 0x3E87C00
	|-List<ConstraintSource>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3E8AB40 Offset: 0x3E8AC41 VA: 0x3E8AB40
	|-List<ContourVertex>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3E8DD50 Offset: 0x3E8DE51 VA: 0x3E8DD50
	|-List<DataStoreRatingInfo>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3E90F00 Offset: 0x3E91001 VA: 0x3E90F00
	|-List<DataStoreResult>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3E93D10 Offset: 0x3E93E11 VA: 0x3E93D10
	|-List<DateTime>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3E96B30 Offset: 0x3E96C31 VA: 0x3E96B30
	|-List<DateTimeOffset>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3E99A10 Offset: 0x3E99B11 VA: 0x3E99A10
	|-List<Decimal>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3E9C920 Offset: 0x3E9CA21 VA: 0x3E9C920
	|-List<DiagnosticEvent>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3E9FD20 Offset: 0x3E9FE21 VA: 0x3E9FD20
	|-List<double>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3EA2B80 Offset: 0x3EA2C81 VA: 0x3EA2B80
	|-List<Friend>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3EA5EE0 Offset: 0x3EA5FE1 VA: 0x3EA5EE0
	|-List<GlyphRect>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3EA8DB0 Offset: 0x3EA8EB1 VA: 0x3EA8DB0
	|-List<short>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3EABBB0 Offset: 0x3EABCB1 VA: 0x3EABBB0
	|-List<int>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3EAE9B0 Offset: 0x3EAEAB1 VA: 0x3EAE9B0
	|-List<Int32Enum>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3EB17B0 Offset: 0x3EB18B1 VA: 0x3EB17B0
	|-List<long>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3DFEB80 Offset: 0x3DFEC81 VA: 0x3DFEB80
	|-List<IntPtr>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3E01990 Offset: 0x3E01A91 VA: 0x3E01990
	|-List<InterpretedFrameInfo>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3E048D0 Offset: 0x3E049D1 VA: 0x3E048D0
	|-List<IntervalTreeNode>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3E07A80 Offset: 0x3E07B81 VA: 0x3E07A80
	|-List<LengthLimitProperties>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3E0A890 Offset: 0x3E0A991 VA: 0x3E0A890
	|-List<MapPos>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3E0D6F0 Offset: 0x3E0D7F1 VA: 0x3E0D6F0
	|-List<Matrix4x4>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3E13A20 Offset: 0x3E13B21 VA: 0x3E13A20
	|-List<ObjectInitializationData>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3E16E50 Offset: 0x3E16F51 VA: 0x3E16E50
	|-List<PlayableBinding>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3E1A080 Offset: 0x3E1A181 VA: 0x3E1A080
	|-List<PlayerLoopSystem>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3DA4520 Offset: 0x3DA4621 VA: 0x3DA4520
	|-List<PlayerLoopSystemInternal>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3DA78C0 Offset: 0x3DA79C1 VA: 0x3DA78C0
	|-List<RangePositionInfo>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3DAA7D0 Offset: 0x3DAA8D1 VA: 0x3DAA7D0
	|-List<Ranking2ChartInfoInput>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3DAD620 Offset: 0x3DAD721 VA: 0x3DAD620
	|-List<RaycastHit2D>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3DB0A60 Offset: 0x3DB0B61 VA: 0x3DB0A60
	|-List<RaycastResult>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3DB4210 Offset: 0x3DB4311 VA: 0x3DB4210
	|-List<Rect>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3DB7210 Offset: 0x3DB7311 VA: 0x3DB7210
	|-List<RendererListHandle>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3DBA020 Offset: 0x3DBA121 VA: 0x3DBA020
	|-List<ResourceHandle>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3DBCE30 Offset: 0x3DBCF31 VA: 0x3DBCE30
	|-List<sbyte>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3DBFC40 Offset: 0x3DBFD41 VA: 0x3DBFC40
	|-List<ShaderTagId>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3E3B8A0 Offset: 0x3E3B9A1 VA: 0x3E3B8A0
	|-List<float>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3E3E760 Offset: 0x3E3E861 VA: 0x3E3E760
	|-List<SphericalHarmonicsL2>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3E423E0 Offset: 0x3E424E1 VA: 0x3E423E0
	|-List<SubMeshDescriptor>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3E457A0 Offset: 0x3E458A1 VA: 0x3E457A0
	|-List<TablePair>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3E486B0 Offset: 0x3E487B1 VA: 0x3E486B0
	|-List<TimeSpan>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3E4B4C0 Offset: 0x3E4B5C1 VA: 0x3E4B4C0
	|-List<UICharInfo>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3E4E4B0 Offset: 0x3E4E5B1 VA: 0x3E4E4B0
	|-List<UILineInfo>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3E51420 Offset: 0x3E51521 VA: 0x3E51420
	|-List<UIVertex>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3E55060 Offset: 0x3E55161 VA: 0x3E55060
	|-List<ushort>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3E57E60 Offset: 0x3E57F61 VA: 0x3E57E60
	|-List<uint>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3DC2A50 Offset: 0x3DC2B51 VA: 0x3DC2A50
	|-List<ulong>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3DC5850 Offset: 0x3DC5951 VA: 0x3DC5850
	|-List<Vector2>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3DC8720 Offset: 0x3DC8821 VA: 0x3DC8720
	|-List<Vector3>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3DCB700 Offset: 0x3DCB801 VA: 0x3DCB700
	|-List<Vector4>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3DCE710 Offset: 0x3DCE811 VA: 0x3DCE710
	|-List<VertexAttributeDescriptor>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3DD15F0 Offset: 0x3DD16F1 VA: 0x3DD15F0
	|-List<X509ChainStatus>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3DD4540 Offset: 0x3DD4641 VA: 0x3DD4540
	|-List<XRView>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3DD7900 Offset: 0x3DD7A01 VA: 0x3DD7900
	|-List<AmiiboSequence.GainItemData>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3DDA850 Offset: 0x3DDA951 VA: 0x3DDA850
	|-List<AnimationOutputWeightProcessor.WeightInfo>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3DDDBC0 Offset: 0x3DDDCC1 VA: 0x3DDDBC0
	|-List<ArenaOrderSequence.GodInfo>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3E1D420 Offset: 0x3E1D521 VA: 0x3E1D420
	|-List<BattleInfo.SupportData>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3E20340 Offset: 0x3E20441 VA: 0x3E20340
	|-List<BeforeRenderHelper.OrderBlock>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3E23280 Offset: 0x3E23381 VA: 0x3E23280
	|-List<Camera.RenderRequest>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3E26490 Offset: 0x3E26591 VA: 0x3E26490
	|-List<CameraState.CustomBlendable>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3E293A0 Offset: 0x3E294A1 VA: 0x3E293A0
	|-List<CinemachineClearShot.Pair>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3E2C1B0 Offset: 0x3E2C2B1 VA: 0x3E2C1B0
	|-List<CinemachineStateDrivenCamera.HashPair>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3E2EFF0 Offset: 0x3E2F0F1 VA: 0x3E2EFF0
	|-List<DelayedActionManager.DelegateInfo>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3E32220 Offset: 0x3E32321 VA: 0x3E32220
	|-List<Detail.AsyncResultInt>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3E355E0 Offset: 0x3E356E1 VA: 0x3E355E0
	|-List<Detail.CppArray>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3E384F0 Offset: 0x3E385F1 VA: 0x3E384F0
	|-List<Detail.NotificationEventInt>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3E5AC70 Offset: 0x3E5AD71 VA: 0x3E5AC70
	|-List<DragonRideTargetGroup.ChainParam>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3E5DBB0 Offset: 0x3E5DCB1 VA: 0x3E5DBB0
	|-List<GmapPathAdjuster.TargetModel>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3E60DC0 Offset: 0x3E60EC1 VA: 0x3E60DC0
	|-List<GmapSpotAdjuster.TargetModel>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3E63FD0 Offset: 0x3E640D1 VA: 0x3E63FD0
	|-List<HubFastTravel.Location>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3E671F0 Offset: 0x3E672F1 VA: 0x3E671F0
	|-List<HubLensFlare.Flare>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3E6A600 Offset: 0x3E6A701 VA: 0x3E6A600
	|-List<InventoryPoolItemMenuContent.KindBgNameClass>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3E6D510 Offset: 0x3E6D611 VA: 0x3E6D510
	|-List<Map.Pos>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3E70330 Offset: 0x3E70431 VA: 0x3E70330
	|-List<MapImage.BackupTerrain>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3E73210 Offset: 0x3E73311 VA: 0x3E73210
	|-List<MapImageRange.Pos>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3E760D0 Offset: 0x3E761D1 VA: 0x3E760D0
	|-List<MapMind.Target>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3D85CD0 Offset: 0x3D85DD1 VA: 0x3D85CD0
	|-List<MapPanelDebug.Entity>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3D88E80 Offset: 0x3D88F81 VA: 0x3D88E80
	|-List<NexRanking.Data>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3D8BCA0 Offset: 0x3D8BDA1 VA: 0x3D8BCA0
	|-List<NexVersus.RatingData>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3D8EB80 Offset: 0x3D8EC81 VA: 0x3D8EB80
	|-List<PackedPlayModeBuildLogs.RuntimeBuildLog>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3D91AD0 Offset: 0x3D91BD1 VA: 0x3D91AD0
	|-List<ParticleSystem.Particle>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3D94E40 Offset: 0x3D94F41 VA: 0x3D94E40
	|-List<RangeData.Offset>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3D97C80 Offset: 0x3D97D81 VA: 0x3D97C80
	|-List<RenderGraphDebugData.PassDebugData>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3D9AEB0 Offset: 0x3D9AFB1 VA: 0x3D9AEB0
	|-List<RenderGraphDebugData.ResourceDebugData>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3D9E250 Offset: 0x3D9E351 VA: 0x3D9E250
	|-List<RingCleaningUnitSelectMenu.GodParam>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3DA11A0 Offset: 0x3DA12A1 VA: 0x3DA11A0
	|-List<ShadowUtility.Edge>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3D139B0 Offset: 0x3D13AB1 VA: 0x3D139B0
	|-List<SkillArray.Entity>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3D16810 Offset: 0x3D16911 VA: 0x3D16810
	|-List<TexturePacker_JsonArray.Frame>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3D19DB0 Offset: 0x3D19EB1 VA: 0x3D19DB0
	|-List<TimeNotificationBehaviour.NotificationEntry>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3D1CFE0 Offset: 0x3D1D0E1 VA: 0x3D1CFE0
	|-List<UnitySynchronizationContext.WorkRequest>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3D201D0 Offset: 0x3D202D1 VA: 0x3D201D0
	|-List<XmlSchemaObjectTable.XmlSchemaObjectEntry>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3D230F0 Offset: 0x3D231F1 VA: 0x3D230F0
	|-List<AssetBundleBuildMap.AssetBundleEntry.AssetPathString>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3D26040 Offset: 0x3D26141 VA: 0x3D26040
	|-List<Detail.DataStore.DataStoreChangeMetaParamInt>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3D29430 Offset: 0x3D29531 VA: 0x3D29430
	|-List<Detail.DataStore.DataStoreDeleteParamInt>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3D2C340 Offset: 0x3D2C441 VA: 0x3D2C340
	|-List<Detail.DataStore.DataStoreGetMetaParamInt>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3D2F6E0 Offset: 0x3D2F7E1 VA: 0x3D2F6E0
	|-List<Detail.DataStore.DataStoreMetaInfoInt>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3CF3F10 Offset: 0x3CF4011 VA: 0x3CF3F10
	|-List<Detail.DataStore.DataStorePasswordInfoInt>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3CF70F0 Offset: 0x3CF71F1 VA: 0x3CF70F0
	|-List<Detail.DataStore.DataStorePersistenceInfoInt>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3CFA2E0 Offset: 0x3CFA3E1 VA: 0x3CFA2E0
	|-List<Detail.DataStore.DataStorePreparePostParamInt>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3CFD660 Offset: 0x3CFD761 VA: 0x3CFD660
	|-List<Detail.DataStore.DataStoreRateObjectParamInt>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3D00560 Offset: 0x3D00661 VA: 0x3D00560
	|-List<Detail.DataStore.DataStoreRatingInitParamInt>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3D03730 Offset: 0x3D03831 VA: 0x3D03730
	|-List<Detail.DataStore.DataStoreRatingTargetInt>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3D06660 Offset: 0x3D06761 VA: 0x3D06660
	|-List<Detail.Ranking.RankingCachedResultInt>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3D09BF0 Offset: 0x3D09CF1 VA: 0x3D09BF0
	|-List<Detail.Ranking.RankingOrderParamInt>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3D0CB10 Offset: 0x3D0CC11 VA: 0x3D0CB10
	|-List<Detail.Ranking.RankingRankDataInt>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3D100B0 Offset: 0x3D101B1 VA: 0x3D100B0
	|-List<Detail.Ranking2.Ranking2ChartInfoInt>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3D66A90 Offset: 0x3D66B91 VA: 0x3D66A90
	|-List<Detail.Ranking2.Ranking2RankDataInt>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3D69FD0 Offset: 0x3D6A0D1 VA: 0x3D69FD0
	|-List<Detail.Ranking2.Ranking2ScoreDataInt>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3D6CED0 Offset: 0x3D6CFD1 VA: 0x3D6CED0
	|-List<Detail.Screening.ScreeningContextInfoInt>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3D700F0 Offset: 0x3D701F1 VA: 0x3D700F0
	|-List<Detail.Subscriber.SubscriberContentInt>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3D73890 Offset: 0x3D73991 VA: 0x3D73890
	|-List<Detail.Subscriber.SubscriberGetContentParamInt>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3D76A80 Offset: 0x3D76B81 VA: 0x3D76A80
	|-List<Detail.Subscriber.SubscriberUserStatusInfoInt>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3D79E10 Offset: 0x3D79F11 VA: 0x3D79E10
	|-List<Detail.Subscriber.SubscriberUserStatusParamInt>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3D7CFC0 Offset: 0x3D7D0C1 VA: 0x3D7CFC0
	|-List<Detail.Utility.IntegerSettings>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3D7FDE0 Offset: 0x3D7FEE1 VA: 0x3D7FDE0
	|-List<Detail.Utility.UniqueIdInfoInt>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3D82CC0 Offset: 0x3D82DC1 VA: 0x3D82CC0
	|-List<MapHistory.Rewind.LatestInspectorData>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x305EF80 Offset: 0x305F081 VA: 0x305EF80
	|-List<MapHistory.Rewind.WorkTerrainData>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3061F70 Offset: 0x3062071 VA: 0x3061F70
	|-List<MapSkill.AroundCalculator.Result>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3064EC0 Offset: 0x3064FC1 VA: 0x3064EC0
	|-List<TargetPositionCache.CacheCurve.Item>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3068240 Offset: 0x3068341 VA: 0x3068240
	|-List<TargetPositionCache.CacheEntry.RecordingItem>.System.Collections.IList.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 31
	private bool System.Collections.ICollection.get_IsSynchronized() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3B0ABC0 Offset: 0x3B0ACC1 VA: 0x3B0ABC0
	|-List<IntervalTree.Entry<object>>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3B0DDB0 Offset: 0x3B0DEB1 VA: 0x3B0DDB0
	|-List<KeyValuePair<DateTime, object>>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3B10CD0 Offset: 0x3B10DD1 VA: 0x3B10CD0
	|-List<KeyValuePair<int, object>>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3B13C10 Offset: 0x3B13D11 VA: 0x3B13C10
	|-List<KeyValuePair<object, ValueTuple<int, DateTime, object>>>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3B16E10 Offset: 0x3B16F11 VA: 0x3B16E10
	|-List<KeyValuePair<object, object>>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3B19D50 Offset: 0x3B19E51 VA: 0x3B19D50
	|-List<CommonBattleSequence.Reliance<object>>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3B1CF40 Offset: 0x3B1D041 VA: 0x3B1CF40
	|-List<RenderGraphResourcePool.ResourceLogInfo<object>>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3B1FE60 Offset: 0x3B1FF61 VA: 0x3B1FE60
	|-List<ValueTuple<int, object>>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3DE0AE0 Offset: 0x3DE0BE1 VA: 0x3DE0AE0
	|-List<ValueTuple<Int32Enum, int>>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3DE3920 Offset: 0x3DE3A21 VA: 0x3DE3920
	|-List<ValueTuple<object, ValueTuple<object, int>>>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3DE6B10 Offset: 0x3DE6C11 VA: 0x3DE6B10
	|-List<ValueTuple<object, int>>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3DE9A20 Offset: 0x3DE9B21 VA: 0x3DE9A20
	|-List<ValueTuple<Vector3, float>>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3DECA30 Offset: 0x3DECB31 VA: 0x3DECA30
	|-List<ValueTuple<object, Int32Enum, int>>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3DEF970 Offset: 0x3DEFA71 VA: 0x3DEF970
	|-List<ValueTuple<object, int, int, int>>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3DF2B50 Offset: 0x3DF2C51 VA: 0x3DF2B50
	|-List<AnimatorClipInfo>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3DF5990 Offset: 0x3DF5A91 VA: 0x3DF5990
	|-List<AsyncOperationHandle>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3DF8BA0 Offset: 0x3DF8CA1 VA: 0x3DF8BA0
	|-List<BoneWeight>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3DFBD60 Offset: 0x3DFBE61 VA: 0x3DFBD60
	|-List<bool>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3E792C0 Offset: 0x3E793C1 VA: 0x3E792C0
	|-List<byte>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3E10C30 Offset: 0x3E10D31 VA: 0x3E10C30
	|-List<Camera>.System.Collections.ICollection.get_IsSynchronized
	|-List<Decorator>.System.Collections.ICollection.get_IsSynchronized
	|-List<DynValue>.System.Collections.ICollection.get_IsSynchronized
	|-List<GameObject>.System.Collections.ICollection.get_IsSynchronized
	|-List<MapBackup>.System.Collections.ICollection.get_IsSynchronized
	|-List<object>.System.Collections.ICollection.get_IsSynchronized
	|-List<Phase>.System.Collections.ICollection.get_IsSynchronized
	|-List<ProfileCard>.System.Collections.ICollection.get_IsSynchronized
	|-List<Unit>.System.Collections.ICollection.get_IsSynchronized
	|-List<AssetTable.Accessory>.System.Collections.ICollection.get_IsSynchronized
	|-List<GameSaveDataHeaderReader.Handle>.System.Collections.ICollection.get_IsSynchronized
	|-List<MapDispos.ActualData>.System.Collections.ICollection.get_IsSynchronized
	|-List<MapDispos.Pos>.System.Collections.ICollection.get_IsSynchronized
	|-List<MapLayer.Data>.System.Collections.ICollection.get_IsSynchronized
	|-List<MapObject.RigidInfo>.System.Collections.ICollection.get_IsSynchronized
	|-List<RingListSequence.PageData>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3E7C0E0 Offset: 0x3E7C1E1 VA: 0x3E7C0E0
	|-List<CameraInfo>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3E7EFF0 Offset: 0x3E7F0F1 VA: 0x3E7EFF0
	|-List<char>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3E81DF0 Offset: 0x3E81EF1 VA: 0x3E81DF0
	|-List<Color>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3E84DF0 Offset: 0x3E84EF1 VA: 0x3E84DF0
	|-List<Color32>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3E87C10 Offset: 0x3E87D11 VA: 0x3E87C10
	|-List<ConstraintSource>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3E8AB50 Offset: 0x3E8AC51 VA: 0x3E8AB50
	|-List<ContourVertex>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3E8DD60 Offset: 0x3E8DE61 VA: 0x3E8DD60
	|-List<DataStoreRatingInfo>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3E90F10 Offset: 0x3E91011 VA: 0x3E90F10
	|-List<DataStoreResult>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3E93D20 Offset: 0x3E93E21 VA: 0x3E93D20
	|-List<DateTime>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3E96B40 Offset: 0x3E96C41 VA: 0x3E96B40
	|-List<DateTimeOffset>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3E99A20 Offset: 0x3E99B21 VA: 0x3E99A20
	|-List<Decimal>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3E9C930 Offset: 0x3E9CA31 VA: 0x3E9C930
	|-List<DiagnosticEvent>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3E9FD30 Offset: 0x3E9FE31 VA: 0x3E9FD30
	|-List<double>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3EA2B90 Offset: 0x3EA2C91 VA: 0x3EA2B90
	|-List<Friend>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3EA5EF0 Offset: 0x3EA5FF1 VA: 0x3EA5EF0
	|-List<GlyphRect>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3EA8DC0 Offset: 0x3EA8EC1 VA: 0x3EA8DC0
	|-List<short>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3EABBC0 Offset: 0x3EABCC1 VA: 0x3EABBC0
	|-List<int>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3EAE9C0 Offset: 0x3EAEAC1 VA: 0x3EAE9C0
	|-List<Int32Enum>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3EB17C0 Offset: 0x3EB18C1 VA: 0x3EB17C0
	|-List<long>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3DFEB90 Offset: 0x3DFEC91 VA: 0x3DFEB90
	|-List<IntPtr>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3E019A0 Offset: 0x3E01AA1 VA: 0x3E019A0
	|-List<InterpretedFrameInfo>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3E048E0 Offset: 0x3E049E1 VA: 0x3E048E0
	|-List<IntervalTreeNode>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3E07A90 Offset: 0x3E07B91 VA: 0x3E07A90
	|-List<LengthLimitProperties>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3E0A8A0 Offset: 0x3E0A9A1 VA: 0x3E0A8A0
	|-List<MapPos>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3E0D700 Offset: 0x3E0D801 VA: 0x3E0D700
	|-List<Matrix4x4>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3E13A30 Offset: 0x3E13B31 VA: 0x3E13A30
	|-List<ObjectInitializationData>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3E16E60 Offset: 0x3E16F61 VA: 0x3E16E60
	|-List<PlayableBinding>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3E1A090 Offset: 0x3E1A191 VA: 0x3E1A090
	|-List<PlayerLoopSystem>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3DA4530 Offset: 0x3DA4631 VA: 0x3DA4530
	|-List<PlayerLoopSystemInternal>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3DA78D0 Offset: 0x3DA79D1 VA: 0x3DA78D0
	|-List<RangePositionInfo>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3DAA7E0 Offset: 0x3DAA8E1 VA: 0x3DAA7E0
	|-List<Ranking2ChartInfoInput>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3DAD630 Offset: 0x3DAD731 VA: 0x3DAD630
	|-List<RaycastHit2D>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3DB0A70 Offset: 0x3DB0B71 VA: 0x3DB0A70
	|-List<RaycastResult>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3DB4220 Offset: 0x3DB4321 VA: 0x3DB4220
	|-List<Rect>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3DB7220 Offset: 0x3DB7321 VA: 0x3DB7220
	|-List<RendererListHandle>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3DBA030 Offset: 0x3DBA131 VA: 0x3DBA030
	|-List<ResourceHandle>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3DBCE40 Offset: 0x3DBCF41 VA: 0x3DBCE40
	|-List<sbyte>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3DBFC50 Offset: 0x3DBFD51 VA: 0x3DBFC50
	|-List<ShaderTagId>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3E3B8B0 Offset: 0x3E3B9B1 VA: 0x3E3B8B0
	|-List<float>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3E3E770 Offset: 0x3E3E871 VA: 0x3E3E770
	|-List<SphericalHarmonicsL2>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3E423F0 Offset: 0x3E424F1 VA: 0x3E423F0
	|-List<SubMeshDescriptor>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3E457B0 Offset: 0x3E458B1 VA: 0x3E457B0
	|-List<TablePair>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3E486C0 Offset: 0x3E487C1 VA: 0x3E486C0
	|-List<TimeSpan>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3E4B4D0 Offset: 0x3E4B5D1 VA: 0x3E4B4D0
	|-List<UICharInfo>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3E4E4C0 Offset: 0x3E4E5C1 VA: 0x3E4E4C0
	|-List<UILineInfo>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3E51430 Offset: 0x3E51531 VA: 0x3E51430
	|-List<UIVertex>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3E55070 Offset: 0x3E55171 VA: 0x3E55070
	|-List<ushort>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3E57E70 Offset: 0x3E57F71 VA: 0x3E57E70
	|-List<uint>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3DC2A60 Offset: 0x3DC2B61 VA: 0x3DC2A60
	|-List<ulong>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3DC5860 Offset: 0x3DC5961 VA: 0x3DC5860
	|-List<Vector2>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3DC8730 Offset: 0x3DC8831 VA: 0x3DC8730
	|-List<Vector3>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3DCB710 Offset: 0x3DCB811 VA: 0x3DCB710
	|-List<Vector4>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3DCE720 Offset: 0x3DCE821 VA: 0x3DCE720
	|-List<VertexAttributeDescriptor>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3DD1600 Offset: 0x3DD1701 VA: 0x3DD1600
	|-List<X509ChainStatus>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3DD4550 Offset: 0x3DD4651 VA: 0x3DD4550
	|-List<XRView>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3DD7910 Offset: 0x3DD7A11 VA: 0x3DD7910
	|-List<AmiiboSequence.GainItemData>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3DDA860 Offset: 0x3DDA961 VA: 0x3DDA860
	|-List<AnimationOutputWeightProcessor.WeightInfo>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3DDDBD0 Offset: 0x3DDDCD1 VA: 0x3DDDBD0
	|-List<ArenaOrderSequence.GodInfo>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3E1D430 Offset: 0x3E1D531 VA: 0x3E1D430
	|-List<BattleInfo.SupportData>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3E20350 Offset: 0x3E20451 VA: 0x3E20350
	|-List<BeforeRenderHelper.OrderBlock>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3E23290 Offset: 0x3E23391 VA: 0x3E23290
	|-List<Camera.RenderRequest>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3E264A0 Offset: 0x3E265A1 VA: 0x3E264A0
	|-List<CameraState.CustomBlendable>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3E293B0 Offset: 0x3E294B1 VA: 0x3E293B0
	|-List<CinemachineClearShot.Pair>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3E2C1C0 Offset: 0x3E2C2C1 VA: 0x3E2C1C0
	|-List<CinemachineStateDrivenCamera.HashPair>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3E2F000 Offset: 0x3E2F101 VA: 0x3E2F000
	|-List<DelayedActionManager.DelegateInfo>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3E32230 Offset: 0x3E32331 VA: 0x3E32230
	|-List<Detail.AsyncResultInt>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3E355F0 Offset: 0x3E356F1 VA: 0x3E355F0
	|-List<Detail.CppArray>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3E38500 Offset: 0x3E38601 VA: 0x3E38500
	|-List<Detail.NotificationEventInt>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3E5AC80 Offset: 0x3E5AD81 VA: 0x3E5AC80
	|-List<DragonRideTargetGroup.ChainParam>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3E5DBC0 Offset: 0x3E5DCC1 VA: 0x3E5DBC0
	|-List<GmapPathAdjuster.TargetModel>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3E60DD0 Offset: 0x3E60ED1 VA: 0x3E60DD0
	|-List<GmapSpotAdjuster.TargetModel>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3E63FE0 Offset: 0x3E640E1 VA: 0x3E63FE0
	|-List<HubFastTravel.Location>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3E67200 Offset: 0x3E67301 VA: 0x3E67200
	|-List<HubLensFlare.Flare>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3E6A610 Offset: 0x3E6A711 VA: 0x3E6A610
	|-List<InventoryPoolItemMenuContent.KindBgNameClass>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3E6D520 Offset: 0x3E6D621 VA: 0x3E6D520
	|-List<Map.Pos>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3E70340 Offset: 0x3E70441 VA: 0x3E70340
	|-List<MapImage.BackupTerrain>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3E73220 Offset: 0x3E73321 VA: 0x3E73220
	|-List<MapImageRange.Pos>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3E760E0 Offset: 0x3E761E1 VA: 0x3E760E0
	|-List<MapMind.Target>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3D85CE0 Offset: 0x3D85DE1 VA: 0x3D85CE0
	|-List<MapPanelDebug.Entity>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3D88E90 Offset: 0x3D88F91 VA: 0x3D88E90
	|-List<NexRanking.Data>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3D8BCB0 Offset: 0x3D8BDB1 VA: 0x3D8BCB0
	|-List<NexVersus.RatingData>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3D8EB90 Offset: 0x3D8EC91 VA: 0x3D8EB90
	|-List<PackedPlayModeBuildLogs.RuntimeBuildLog>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3D91AE0 Offset: 0x3D91BE1 VA: 0x3D91AE0
	|-List<ParticleSystem.Particle>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3D94E50 Offset: 0x3D94F51 VA: 0x3D94E50
	|-List<RangeData.Offset>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3D97C90 Offset: 0x3D97D91 VA: 0x3D97C90
	|-List<RenderGraphDebugData.PassDebugData>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3D9AEC0 Offset: 0x3D9AFC1 VA: 0x3D9AEC0
	|-List<RenderGraphDebugData.ResourceDebugData>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3D9E260 Offset: 0x3D9E361 VA: 0x3D9E260
	|-List<RingCleaningUnitSelectMenu.GodParam>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3DA11B0 Offset: 0x3DA12B1 VA: 0x3DA11B0
	|-List<ShadowUtility.Edge>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3D139C0 Offset: 0x3D13AC1 VA: 0x3D139C0
	|-List<SkillArray.Entity>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3D16820 Offset: 0x3D16921 VA: 0x3D16820
	|-List<TexturePacker_JsonArray.Frame>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3D19DC0 Offset: 0x3D19EC1 VA: 0x3D19DC0
	|-List<TimeNotificationBehaviour.NotificationEntry>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3D1CFF0 Offset: 0x3D1D0F1 VA: 0x3D1CFF0
	|-List<UnitySynchronizationContext.WorkRequest>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3D201E0 Offset: 0x3D202E1 VA: 0x3D201E0
	|-List<XmlSchemaObjectTable.XmlSchemaObjectEntry>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3D23100 Offset: 0x3D23201 VA: 0x3D23100
	|-List<AssetBundleBuildMap.AssetBundleEntry.AssetPathString>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3D26050 Offset: 0x3D26151 VA: 0x3D26050
	|-List<Detail.DataStore.DataStoreChangeMetaParamInt>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3D29440 Offset: 0x3D29541 VA: 0x3D29440
	|-List<Detail.DataStore.DataStoreDeleteParamInt>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3D2C350 Offset: 0x3D2C451 VA: 0x3D2C350
	|-List<Detail.DataStore.DataStoreGetMetaParamInt>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3D2F6F0 Offset: 0x3D2F7F1 VA: 0x3D2F6F0
	|-List<Detail.DataStore.DataStoreMetaInfoInt>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3CF3F20 Offset: 0x3CF4021 VA: 0x3CF3F20
	|-List<Detail.DataStore.DataStorePasswordInfoInt>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3CF7100 Offset: 0x3CF7201 VA: 0x3CF7100
	|-List<Detail.DataStore.DataStorePersistenceInfoInt>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3CFA2F0 Offset: 0x3CFA3F1 VA: 0x3CFA2F0
	|-List<Detail.DataStore.DataStorePreparePostParamInt>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3CFD670 Offset: 0x3CFD771 VA: 0x3CFD670
	|-List<Detail.DataStore.DataStoreRateObjectParamInt>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3D00570 Offset: 0x3D00671 VA: 0x3D00570
	|-List<Detail.DataStore.DataStoreRatingInitParamInt>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3D03740 Offset: 0x3D03841 VA: 0x3D03740
	|-List<Detail.DataStore.DataStoreRatingTargetInt>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3D06670 Offset: 0x3D06771 VA: 0x3D06670
	|-List<Detail.Ranking.RankingCachedResultInt>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3D09C00 Offset: 0x3D09D01 VA: 0x3D09C00
	|-List<Detail.Ranking.RankingOrderParamInt>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3D0CB20 Offset: 0x3D0CC21 VA: 0x3D0CB20
	|-List<Detail.Ranking.RankingRankDataInt>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3D100C0 Offset: 0x3D101C1 VA: 0x3D100C0
	|-List<Detail.Ranking2.Ranking2ChartInfoInt>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3D66AA0 Offset: 0x3D66BA1 VA: 0x3D66AA0
	|-List<Detail.Ranking2.Ranking2RankDataInt>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3D69FE0 Offset: 0x3D6A0E1 VA: 0x3D69FE0
	|-List<Detail.Ranking2.Ranking2ScoreDataInt>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3D6CEE0 Offset: 0x3D6CFE1 VA: 0x3D6CEE0
	|-List<Detail.Screening.ScreeningContextInfoInt>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3D70100 Offset: 0x3D70201 VA: 0x3D70100
	|-List<Detail.Subscriber.SubscriberContentInt>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3D738A0 Offset: 0x3D739A1 VA: 0x3D738A0
	|-List<Detail.Subscriber.SubscriberGetContentParamInt>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3D76A90 Offset: 0x3D76B91 VA: 0x3D76A90
	|-List<Detail.Subscriber.SubscriberUserStatusInfoInt>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3D79E20 Offset: 0x3D79F21 VA: 0x3D79E20
	|-List<Detail.Subscriber.SubscriberUserStatusParamInt>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3D7CFD0 Offset: 0x3D7D0D1 VA: 0x3D7CFD0
	|-List<Detail.Utility.IntegerSettings>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3D7FDF0 Offset: 0x3D7FEF1 VA: 0x3D7FDF0
	|-List<Detail.Utility.UniqueIdInfoInt>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3D82CD0 Offset: 0x3D82DD1 VA: 0x3D82CD0
	|-List<MapHistory.Rewind.LatestInspectorData>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x305EF90 Offset: 0x305F091 VA: 0x305EF90
	|-List<MapHistory.Rewind.WorkTerrainData>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3061F80 Offset: 0x3062081 VA: 0x3061F80
	|-List<MapSkill.AroundCalculator.Result>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3064ED0 Offset: 0x3064FD1 VA: 0x3064ED0
	|-List<TargetPositionCache.CacheCurve.Item>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3068250 Offset: 0x3068351 VA: 0x3068250
	|-List<TargetPositionCache.CacheEntry.RecordingItem>.System.Collections.ICollection.get_IsSynchronized
	*/

	// RVA: -1 Offset: -1 Slot: 30
	private object System.Collections.ICollection.get_SyncRoot() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3B0ABD0 Offset: 0x3B0ACD1 VA: 0x3B0ABD0
	|-List<IntervalTree.Entry<object>>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3B0DDC0 Offset: 0x3B0DEC1 VA: 0x3B0DDC0
	|-List<KeyValuePair<DateTime, object>>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3B10CE0 Offset: 0x3B10DE1 VA: 0x3B10CE0
	|-List<KeyValuePair<int, object>>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3B13C20 Offset: 0x3B13D21 VA: 0x3B13C20
	|-List<KeyValuePair<object, ValueTuple<int, DateTime, object>>>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3B16E20 Offset: 0x3B16F21 VA: 0x3B16E20
	|-List<KeyValuePair<object, object>>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3B19D60 Offset: 0x3B19E61 VA: 0x3B19D60
	|-List<CommonBattleSequence.Reliance<object>>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3B1CF50 Offset: 0x3B1D051 VA: 0x3B1CF50
	|-List<RenderGraphResourcePool.ResourceLogInfo<object>>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3B1FE70 Offset: 0x3B1FF71 VA: 0x3B1FE70
	|-List<ValueTuple<int, object>>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3DE0AF0 Offset: 0x3DE0BF1 VA: 0x3DE0AF0
	|-List<ValueTuple<Int32Enum, int>>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3DE3930 Offset: 0x3DE3A31 VA: 0x3DE3930
	|-List<ValueTuple<object, ValueTuple<object, int>>>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3DE6B20 Offset: 0x3DE6C21 VA: 0x3DE6B20
	|-List<ValueTuple<object, int>>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3DE9A30 Offset: 0x3DE9B31 VA: 0x3DE9A30
	|-List<ValueTuple<Vector3, float>>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3DECA40 Offset: 0x3DECB41 VA: 0x3DECA40
	|-List<ValueTuple<object, Int32Enum, int>>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3DEF980 Offset: 0x3DEFA81 VA: 0x3DEF980
	|-List<ValueTuple<object, int, int, int>>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3DF2B60 Offset: 0x3DF2C61 VA: 0x3DF2B60
	|-List<AnimatorClipInfo>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3DF59A0 Offset: 0x3DF5AA1 VA: 0x3DF59A0
	|-List<AsyncOperationHandle>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3DF8BB0 Offset: 0x3DF8CB1 VA: 0x3DF8BB0
	|-List<BoneWeight>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3DFBD70 Offset: 0x3DFBE71 VA: 0x3DFBD70
	|-List<bool>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3E792D0 Offset: 0x3E793D1 VA: 0x3E792D0
	|-List<byte>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3E10C40 Offset: 0x3E10D41 VA: 0x3E10C40
	|-List<Camera>.System.Collections.ICollection.get_SyncRoot
	|-List<Decorator>.System.Collections.ICollection.get_SyncRoot
	|-List<DynValue>.System.Collections.ICollection.get_SyncRoot
	|-List<GameObject>.System.Collections.ICollection.get_SyncRoot
	|-List<MapBackup>.System.Collections.ICollection.get_SyncRoot
	|-List<object>.System.Collections.ICollection.get_SyncRoot
	|-List<Phase>.System.Collections.ICollection.get_SyncRoot
	|-List<ProfileCard>.System.Collections.ICollection.get_SyncRoot
	|-List<Unit>.System.Collections.ICollection.get_SyncRoot
	|-List<AssetTable.Accessory>.System.Collections.ICollection.get_SyncRoot
	|-List<GameSaveDataHeaderReader.Handle>.System.Collections.ICollection.get_SyncRoot
	|-List<MapDispos.ActualData>.System.Collections.ICollection.get_SyncRoot
	|-List<MapDispos.Pos>.System.Collections.ICollection.get_SyncRoot
	|-List<MapLayer.Data>.System.Collections.ICollection.get_SyncRoot
	|-List<MapObject.RigidInfo>.System.Collections.ICollection.get_SyncRoot
	|-List<RingListSequence.PageData>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3E7C0F0 Offset: 0x3E7C1F1 VA: 0x3E7C0F0
	|-List<CameraInfo>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3E7F000 Offset: 0x3E7F101 VA: 0x3E7F000
	|-List<char>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3E81E00 Offset: 0x3E81F01 VA: 0x3E81E00
	|-List<Color>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3E84E00 Offset: 0x3E84F01 VA: 0x3E84E00
	|-List<Color32>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3E87C20 Offset: 0x3E87D21 VA: 0x3E87C20
	|-List<ConstraintSource>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3E8AB60 Offset: 0x3E8AC61 VA: 0x3E8AB60
	|-List<ContourVertex>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3E8DD70 Offset: 0x3E8DE71 VA: 0x3E8DD70
	|-List<DataStoreRatingInfo>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3E90F20 Offset: 0x3E91021 VA: 0x3E90F20
	|-List<DataStoreResult>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3E93D30 Offset: 0x3E93E31 VA: 0x3E93D30
	|-List<DateTime>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3E96B50 Offset: 0x3E96C51 VA: 0x3E96B50
	|-List<DateTimeOffset>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3E99A30 Offset: 0x3E99B31 VA: 0x3E99A30
	|-List<Decimal>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3E9C940 Offset: 0x3E9CA41 VA: 0x3E9C940
	|-List<DiagnosticEvent>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3E9FD40 Offset: 0x3E9FE41 VA: 0x3E9FD40
	|-List<double>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3EA2BA0 Offset: 0x3EA2CA1 VA: 0x3EA2BA0
	|-List<Friend>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3EA5F00 Offset: 0x3EA6001 VA: 0x3EA5F00
	|-List<GlyphRect>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3EA8DD0 Offset: 0x3EA8ED1 VA: 0x3EA8DD0
	|-List<short>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3EABBD0 Offset: 0x3EABCD1 VA: 0x3EABBD0
	|-List<int>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3EAE9D0 Offset: 0x3EAEAD1 VA: 0x3EAE9D0
	|-List<Int32Enum>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3EB17D0 Offset: 0x3EB18D1 VA: 0x3EB17D0
	|-List<long>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3DFEBA0 Offset: 0x3DFECA1 VA: 0x3DFEBA0
	|-List<IntPtr>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3E019B0 Offset: 0x3E01AB1 VA: 0x3E019B0
	|-List<InterpretedFrameInfo>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3E048F0 Offset: 0x3E049F1 VA: 0x3E048F0
	|-List<IntervalTreeNode>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3E07AA0 Offset: 0x3E07BA1 VA: 0x3E07AA0
	|-List<LengthLimitProperties>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3E0A8B0 Offset: 0x3E0A9B1 VA: 0x3E0A8B0
	|-List<MapPos>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3E0D710 Offset: 0x3E0D811 VA: 0x3E0D710
	|-List<Matrix4x4>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3E13A40 Offset: 0x3E13B41 VA: 0x3E13A40
	|-List<ObjectInitializationData>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3E16E70 Offset: 0x3E16F71 VA: 0x3E16E70
	|-List<PlayableBinding>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3E1A0A0 Offset: 0x3E1A1A1 VA: 0x3E1A0A0
	|-List<PlayerLoopSystem>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3DA4540 Offset: 0x3DA4641 VA: 0x3DA4540
	|-List<PlayerLoopSystemInternal>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3DA78E0 Offset: 0x3DA79E1 VA: 0x3DA78E0
	|-List<RangePositionInfo>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3DAA7F0 Offset: 0x3DAA8F1 VA: 0x3DAA7F0
	|-List<Ranking2ChartInfoInput>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3DAD640 Offset: 0x3DAD741 VA: 0x3DAD640
	|-List<RaycastHit2D>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3DB0A80 Offset: 0x3DB0B81 VA: 0x3DB0A80
	|-List<RaycastResult>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3DB4230 Offset: 0x3DB4331 VA: 0x3DB4230
	|-List<Rect>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3DB7230 Offset: 0x3DB7331 VA: 0x3DB7230
	|-List<RendererListHandle>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3DBA040 Offset: 0x3DBA141 VA: 0x3DBA040
	|-List<ResourceHandle>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3DBCE50 Offset: 0x3DBCF51 VA: 0x3DBCE50
	|-List<sbyte>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3DBFC60 Offset: 0x3DBFD61 VA: 0x3DBFC60
	|-List<ShaderTagId>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3E3B8C0 Offset: 0x3E3B9C1 VA: 0x3E3B8C0
	|-List<float>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3E3E780 Offset: 0x3E3E881 VA: 0x3E3E780
	|-List<SphericalHarmonicsL2>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3E42400 Offset: 0x3E42501 VA: 0x3E42400
	|-List<SubMeshDescriptor>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3E457C0 Offset: 0x3E458C1 VA: 0x3E457C0
	|-List<TablePair>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3E486D0 Offset: 0x3E487D1 VA: 0x3E486D0
	|-List<TimeSpan>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3E4B4E0 Offset: 0x3E4B5E1 VA: 0x3E4B4E0
	|-List<UICharInfo>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3E4E4D0 Offset: 0x3E4E5D1 VA: 0x3E4E4D0
	|-List<UILineInfo>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3E51440 Offset: 0x3E51541 VA: 0x3E51440
	|-List<UIVertex>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3E55080 Offset: 0x3E55181 VA: 0x3E55080
	|-List<ushort>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3E57E80 Offset: 0x3E57F81 VA: 0x3E57E80
	|-List<uint>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3DC2A70 Offset: 0x3DC2B71 VA: 0x3DC2A70
	|-List<ulong>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3DC5870 Offset: 0x3DC5971 VA: 0x3DC5870
	|-List<Vector2>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3DC8740 Offset: 0x3DC8841 VA: 0x3DC8740
	|-List<Vector3>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3DCB720 Offset: 0x3DCB821 VA: 0x3DCB720
	|-List<Vector4>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3DCE730 Offset: 0x3DCE831 VA: 0x3DCE730
	|-List<VertexAttributeDescriptor>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3DD1610 Offset: 0x3DD1711 VA: 0x3DD1610
	|-List<X509ChainStatus>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3DD4560 Offset: 0x3DD4661 VA: 0x3DD4560
	|-List<XRView>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3DD7920 Offset: 0x3DD7A21 VA: 0x3DD7920
	|-List<AmiiboSequence.GainItemData>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3DDA870 Offset: 0x3DDA971 VA: 0x3DDA870
	|-List<AnimationOutputWeightProcessor.WeightInfo>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3DDDBE0 Offset: 0x3DDDCE1 VA: 0x3DDDBE0
	|-List<ArenaOrderSequence.GodInfo>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3E1D440 Offset: 0x3E1D541 VA: 0x3E1D440
	|-List<BattleInfo.SupportData>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3E20360 Offset: 0x3E20461 VA: 0x3E20360
	|-List<BeforeRenderHelper.OrderBlock>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3E232A0 Offset: 0x3E233A1 VA: 0x3E232A0
	|-List<Camera.RenderRequest>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3E264B0 Offset: 0x3E265B1 VA: 0x3E264B0
	|-List<CameraState.CustomBlendable>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3E293C0 Offset: 0x3E294C1 VA: 0x3E293C0
	|-List<CinemachineClearShot.Pair>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3E2C1D0 Offset: 0x3E2C2D1 VA: 0x3E2C1D0
	|-List<CinemachineStateDrivenCamera.HashPair>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3E2F010 Offset: 0x3E2F111 VA: 0x3E2F010
	|-List<DelayedActionManager.DelegateInfo>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3E32240 Offset: 0x3E32341 VA: 0x3E32240
	|-List<Detail.AsyncResultInt>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3E35600 Offset: 0x3E35701 VA: 0x3E35600
	|-List<Detail.CppArray>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3E38510 Offset: 0x3E38611 VA: 0x3E38510
	|-List<Detail.NotificationEventInt>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3E5AC90 Offset: 0x3E5AD91 VA: 0x3E5AC90
	|-List<DragonRideTargetGroup.ChainParam>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3E5DBD0 Offset: 0x3E5DCD1 VA: 0x3E5DBD0
	|-List<GmapPathAdjuster.TargetModel>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3E60DE0 Offset: 0x3E60EE1 VA: 0x3E60DE0
	|-List<GmapSpotAdjuster.TargetModel>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3E63FF0 Offset: 0x3E640F1 VA: 0x3E63FF0
	|-List<HubFastTravel.Location>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3E67210 Offset: 0x3E67311 VA: 0x3E67210
	|-List<HubLensFlare.Flare>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3E6A620 Offset: 0x3E6A721 VA: 0x3E6A620
	|-List<InventoryPoolItemMenuContent.KindBgNameClass>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3E6D530 Offset: 0x3E6D631 VA: 0x3E6D530
	|-List<Map.Pos>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3E70350 Offset: 0x3E70451 VA: 0x3E70350
	|-List<MapImage.BackupTerrain>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3E73230 Offset: 0x3E73331 VA: 0x3E73230
	|-List<MapImageRange.Pos>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3E760F0 Offset: 0x3E761F1 VA: 0x3E760F0
	|-List<MapMind.Target>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3D85CF0 Offset: 0x3D85DF1 VA: 0x3D85CF0
	|-List<MapPanelDebug.Entity>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3D88EA0 Offset: 0x3D88FA1 VA: 0x3D88EA0
	|-List<NexRanking.Data>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3D8BCC0 Offset: 0x3D8BDC1 VA: 0x3D8BCC0
	|-List<NexVersus.RatingData>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3D8EBA0 Offset: 0x3D8ECA1 VA: 0x3D8EBA0
	|-List<PackedPlayModeBuildLogs.RuntimeBuildLog>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3D91AF0 Offset: 0x3D91BF1 VA: 0x3D91AF0
	|-List<ParticleSystem.Particle>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3D94E60 Offset: 0x3D94F61 VA: 0x3D94E60
	|-List<RangeData.Offset>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3D97CA0 Offset: 0x3D97DA1 VA: 0x3D97CA0
	|-List<RenderGraphDebugData.PassDebugData>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3D9AED0 Offset: 0x3D9AFD1 VA: 0x3D9AED0
	|-List<RenderGraphDebugData.ResourceDebugData>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3D9E270 Offset: 0x3D9E371 VA: 0x3D9E270
	|-List<RingCleaningUnitSelectMenu.GodParam>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3DA11C0 Offset: 0x3DA12C1 VA: 0x3DA11C0
	|-List<ShadowUtility.Edge>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3D139D0 Offset: 0x3D13AD1 VA: 0x3D139D0
	|-List<SkillArray.Entity>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3D16830 Offset: 0x3D16931 VA: 0x3D16830
	|-List<TexturePacker_JsonArray.Frame>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3D19DD0 Offset: 0x3D19ED1 VA: 0x3D19DD0
	|-List<TimeNotificationBehaviour.NotificationEntry>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3D1D000 Offset: 0x3D1D101 VA: 0x3D1D000
	|-List<UnitySynchronizationContext.WorkRequest>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3D201F0 Offset: 0x3D202F1 VA: 0x3D201F0
	|-List<XmlSchemaObjectTable.XmlSchemaObjectEntry>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3D23110 Offset: 0x3D23211 VA: 0x3D23110
	|-List<AssetBundleBuildMap.AssetBundleEntry.AssetPathString>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3D26060 Offset: 0x3D26161 VA: 0x3D26060
	|-List<Detail.DataStore.DataStoreChangeMetaParamInt>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3D29450 Offset: 0x3D29551 VA: 0x3D29450
	|-List<Detail.DataStore.DataStoreDeleteParamInt>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3D2C360 Offset: 0x3D2C461 VA: 0x3D2C360
	|-List<Detail.DataStore.DataStoreGetMetaParamInt>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3D2F700 Offset: 0x3D2F801 VA: 0x3D2F700
	|-List<Detail.DataStore.DataStoreMetaInfoInt>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3CF3F30 Offset: 0x3CF4031 VA: 0x3CF3F30
	|-List<Detail.DataStore.DataStorePasswordInfoInt>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3CF7110 Offset: 0x3CF7211 VA: 0x3CF7110
	|-List<Detail.DataStore.DataStorePersistenceInfoInt>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3CFA300 Offset: 0x3CFA401 VA: 0x3CFA300
	|-List<Detail.DataStore.DataStorePreparePostParamInt>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3CFD680 Offset: 0x3CFD781 VA: 0x3CFD680
	|-List<Detail.DataStore.DataStoreRateObjectParamInt>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3D00580 Offset: 0x3D00681 VA: 0x3D00580
	|-List<Detail.DataStore.DataStoreRatingInitParamInt>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3D03750 Offset: 0x3D03851 VA: 0x3D03750
	|-List<Detail.DataStore.DataStoreRatingTargetInt>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3D06680 Offset: 0x3D06781 VA: 0x3D06680
	|-List<Detail.Ranking.RankingCachedResultInt>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3D09C10 Offset: 0x3D09D11 VA: 0x3D09C10
	|-List<Detail.Ranking.RankingOrderParamInt>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3D0CB30 Offset: 0x3D0CC31 VA: 0x3D0CB30
	|-List<Detail.Ranking.RankingRankDataInt>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3D100D0 Offset: 0x3D101D1 VA: 0x3D100D0
	|-List<Detail.Ranking2.Ranking2ChartInfoInt>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3D66AB0 Offset: 0x3D66BB1 VA: 0x3D66AB0
	|-List<Detail.Ranking2.Ranking2RankDataInt>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3D69FF0 Offset: 0x3D6A0F1 VA: 0x3D69FF0
	|-List<Detail.Ranking2.Ranking2ScoreDataInt>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3D6CEF0 Offset: 0x3D6CFF1 VA: 0x3D6CEF0
	|-List<Detail.Screening.ScreeningContextInfoInt>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3D70110 Offset: 0x3D70211 VA: 0x3D70110
	|-List<Detail.Subscriber.SubscriberContentInt>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3D738B0 Offset: 0x3D739B1 VA: 0x3D738B0
	|-List<Detail.Subscriber.SubscriberGetContentParamInt>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3D76AA0 Offset: 0x3D76BA1 VA: 0x3D76AA0
	|-List<Detail.Subscriber.SubscriberUserStatusInfoInt>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3D79E30 Offset: 0x3D79F31 VA: 0x3D79E30
	|-List<Detail.Subscriber.SubscriberUserStatusParamInt>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3D7CFE0 Offset: 0x3D7D0E1 VA: 0x3D7CFE0
	|-List<Detail.Utility.IntegerSettings>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3D7FE00 Offset: 0x3D7FF01 VA: 0x3D7FE00
	|-List<Detail.Utility.UniqueIdInfoInt>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3D82CE0 Offset: 0x3D82DE1 VA: 0x3D82CE0
	|-List<MapHistory.Rewind.LatestInspectorData>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x305EFA0 Offset: 0x305F0A1 VA: 0x305EFA0
	|-List<MapHistory.Rewind.WorkTerrainData>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3061F90 Offset: 0x3062091 VA: 0x3061F90
	|-List<MapSkill.AroundCalculator.Result>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3064EE0 Offset: 0x3064FE1 VA: 0x3064EE0
	|-List<TargetPositionCache.CacheCurve.Item>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3068260 Offset: 0x3068361 VA: 0x3068260
	|-List<TargetPositionCache.CacheEntry.RecordingItem>.System.Collections.ICollection.get_SyncRoot
	*/

	// RVA: -1 Offset: -1 Slot: 32
	public T get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3B0AC60 Offset: 0x3B0AD61 VA: 0x3B0AC60
	|-List<IntervalTree.Entry<object>>.get_Item
	|
	|-RVA: 0x3B16EB0 Offset: 0x3B16FB1 VA: 0x3B16EB0
	|-List<KeyValuePair<AnimationClip, AnimationClip>>.get_Item
	|-List<KeyValuePair<object, object>>.get_Item
	|
	|-RVA: 0x3B0DE50 Offset: 0x3B0DF51 VA: 0x3B0DE50
	|-List<KeyValuePair<DateTime, object>>.get_Item
	|-List<KeyValuePair<DateTime, TimeType>>.get_Item
	|
	|-RVA: 0x3B13CB0 Offset: 0x3B13DB1 VA: 0x3B13CB0
	|-List<KeyValuePair<IAwaiter, ValueTuple<int, DateTime, string>>>.get_Item
	|-List<KeyValuePair<object, ValueTuple<int, DateTime, object>>>.get_Item
	|
	|-RVA: 0x3B10D70 Offset: 0x3B10E71 VA: 0x3B10D70
	|-List<KeyValuePair<int, object>>.get_Item
	|
	|-RVA: 0x3E10CD0 Offset: 0x3E10DD1 VA: 0x3E10CD0
	|-List<List<CinemachineVirtualCameraBase>>.get_Item
	|-List<List<int>>.get_Item
	|-List<List<object>>.get_Item
	|-List<List<Vector2>>.get_Item
	|-List<StructDataArrayList<DragonRideTargetPatternData>>.get_Item
	|-List<StructDataArrayList<ItemEvolveData>>.get_Item
	|-List<StructDataArrayList<JobIntroData>>.get_Item
	|-List<StructDataArrayList<KillBonusData>>.get_Item
	|-List<StructDataArrayList<KilledBonusData>>.get_Item
	|-List<StructDataArrayList<TutorialData>>.get_Item
	|-List<MiniMapController.TImage<Image>>.get_Item
	|-List<MiniMapController.TImage<UnitIcon>>.get_Item
	|-List<byte[]>.get_Item
	|-List<KeyCode[]>.get_Item
	|-List<string[]>.get_Item
	|-List<AIData>.get_Item
	|-List<AccessoryData>.get_Item
	|-List<AccessoryShopContent>.get_Item
	|-List<AccessoryShopData>.get_Item
	|-List<AchieveData>.get_Item
	|-List<Action>.get_Item
	|-List<AggregateException>.get_Item
	|-List<AkAmbient>.get_Item
	|-List<AkAmbientLargeModePositioner>.get_Item
	|-List<AkAudioListener>.get_Item
	|-List<AkEnvironment>.get_Item
	|-List<AkEnvironmentPortal>.get_Item
	|-List<AkGameObj>.get_Item
	|-List<AkRoom>.get_Item
	|-List<AkRoomAwareObject>.get_Item
	|-List<AkRoomPortal>.get_Item
	|-List<AkSpatialAudioListener>.get_Item
	|-List<AkSurfaceReflector>.get_Item
	|-List<AnimalData>.get_Item
	|-List<AnimationEvent>.get_Item
	|-List<AnimationTrack>.get_Item
	|-List<Animator>.get_Item
	|-List<AssetTable>.get_Item
	|-List<AssetTableItem>.get_Item
	|-List<AsyncDebugger>.get_Item
	|-List<AudienceAnime>.get_Item
	|-List<BaseInputModule>.get_Item
	|-List<BaseInvokableCall>.get_Item
	|-List<BaseRaycaster>.get_Item
	|-List<BasicMenu>.get_Item
	|-List<BasicMenuItem>.get_Item
	|-List<BasicMenuSelect>.get_Item
	|-List<BattleInfoSide>.get_Item
	|-List<BuildTimeScopeFrame>.get_Item
	|-List<CalculatorCommand>.get_Item
	|-List<Camera>.get_Item
	|-List<Canvas>.get_Item
	|-List<CanvasGroup>.get_Item
	|-List<CapsuleCollider>.get_Item
	|-List<ChallengeData>.get_Item
	|-List<ChapterData>.get_Item
	|-List<Character>.get_Item
	|-List<CharacterCollision>.get_Item
	|-List<CharacterProportion>.get_Item
	|-List<CinemachineBrain>.get_Item
	|-List<CinemachineExtension>.get_Item
	|-List<CinemachineVirtualCameraBase>.get_Item
	|-List<Claim>.get_Item
	|-List<Collider>.get_Item
	|-List<Component>.get_Item
	|-List<CookData>.get_Item
	|-List<CustomEnvSet>.get_Item
	|-List<DataStoreMetaInfo>.get_Item
	|-List<DebugUIHandlerIndirectToggle>.get_Item
	|-List<DebugUIHandlerPanel>.get_Item
	|-List<DebugUIHandlerValue>.get_Item
	|-List<DebugUIHandlerWidget>.get_Item
	|-List<Decorator>.get_Item
	|-List<DisposData>.get_Item
	|-List<DragonRideTargetPatternData>.get_Item
	|-List<DynValue>.get_Item
	|-List<EncountEquipData>.get_Item
	|-List<EncountUnitData>.get_Item
	|-List<EventCharacterMouthController>.get_Item
	|-List<EventSystem>.get_Item
	|-List<ExceptionDispatchInfo>.get_Item
	|-List<Expression>.get_Item
	|-List<FileData>.get_Item
	|-List<FoodstuffData>.get_Item
	|-List<ForceProvider>.get_Item
	|-List<ForceTextureSetter>.get_Item
	|-List<ForecastFishData>.get_Item
	|-List<FriendListData>.get_Item
	|-List<GUILayoutEntry>.get_Item
	|-List<GameObject>.get_Item
	|-List<Glyph>.get_Item
	|-List<GmapSpot>.get_Item
	|-List<GodData>.get_Item
	|-List<GodGrowthData>.get_Item
	|-List<GodUnit>.get_Item
	|-List<GodWeaponRefineData>.get_Item
	|-List<Graphic>.get_Item
	|-List<HubAccess>.get_Item
	|-List<HubAccessData>.get_Item
	|-List<HubAccessManager>.get_Item
	|-List<HubAreaFog>.get_Item
	|-List<HubInvestmentAnimal>.get_Item
	|-List<HubInvestmentBonusAnimal>.get_Item
	|-List<HubInvestmentBonusFood>.get_Item
	|-List<HubInvestmentBonusItem>.get_Item
	|-List<HubInvestmentFoodstuff>.get_Item
	|-List<HubInvestmentLevel>.get_Item
	|-List<HubManualCulling>.get_Item
	|-List<HubMoveState>.get_Item
	|-List<HubUnitController>.get_Item
	|-List<IAsyncOperation>.get_Item
	|-List<ICanvasElement>.get_Item
	|-List<IClosureBuilder>.get_Item
	|-List<IContextProperty>.get_Item
	|-List<IEventSystemHandler>.get_Item
	|-List<IMarker>.get_Item
	|-List<IMaterialModifier>.get_Item
	|-List<IMenuElement>.get_Item
	|-List<IOverloadableMemberDescriptor>.get_Item
	|-List<ISpringManager>.get_Item
	|-List<ITimelineEvaluateCallback>.get_Item
	|-List<IUserDataDescriptor>.get_Item
	|-List<IVariable>.get_Item
	|-List<Image>.get_Item
	|-List<Instruction>.get_Item
	|-List<Instruction>.get_Item
	|-List<InteractionTrigger>.get_Item
	|-List<ItemData>.get_Item
	|-List<ItemEvolveData>.get_Item
	|-List<ItemRefineData>.get_Item
	|-List<JobData>.get_Item
	|-List<JobIntroData>.get_Item
	|-List<KerningPair>.get_Item
	|-List<KeyHelpData>.get_Item
	|-List<KillBonusData>.get_Item
	|-List<KilledBonusData>.get_Item
	|-List<Light2D>.get_Item
	|-List<LocalDataStore>.get_Item
	|-List<MapBackup>.get_Item
	|-List<MapCollision>.get_Item
	|-List<MapEditorObjectData>.get_Item
	|-List<MapInspector>.get_Item
	|-List<MapObject>.get_Item
	|-List<MascotColorChangeItemContent>.get_Item
	|-List<Mask>.get_Item
	|-List<Material>.get_Item
	|-List<MenuItem>.get_Item
	|-List<MusclePushUpSpeedData>.get_Item
	|-List<MuscleSitUpFallData>.get_Item
	|-List<MuscleSquatScorePatternData>.get_Item
	|-List<Note>.get_Item
	|-List<object>.get_Item
	|-List<PersonData>.get_Item
	|-List<Phase>.get_Item
	|-List<PhotographCameraParameter>.get_Item
	|-List<PhotographDisposInfo>.get_Item
	|-List<PhotographPauseData>.get_Item
	|-List<PokeInspector>.get_Item
	|-List<PrefetchedSignal>.get_Item
	|-List<Processor>.get_Item
	|-List<ProfileCard>.get_Item
	|-List<RangeData>.get_Item
	|-List<RectMask2D>.get_Item
	|-List<RectTransform>.get_Item
	|-List<RegexNode>.get_Item
	|-List<RelayCompletionAwardData>.get_Item
	|-List<RelayLeavingUnitData>.get_Item
	|-List<RelayServerMetaData>.get_Item
	|-List<RelayStampData>.get_Item
	|-List<RelianceData>.get_Item
	|-List<RenderGraphPass>.get_Item
	|-List<Renderer>.get_Item
	|-List<ResourceGameObject>.get_Item
	|-List<ResourceHandle>.get_Item
	|-List<RewardData>.get_Item
	|-List<RingCleaningVoiceData>.get_Item
	|-List<RingData>.get_Item
	|-List<RuntimeElement>.get_Item
	|-List<ScreeningContextInfo>.get_Item
	|-List<ScriptableObject>.get_Item
	|-List<ScriptableRenderPass>.get_Item
	|-List<ScriptableRendererFeature>.get_Item
	|-List<ShadowCaster2D>.get_Item
	|-List<ShadowCasterGroup2D>.get_Item
	|-List<ShopContent>.get_Item
	|-List<ShopData>.get_Item
	|-List<SignalAsset>.get_Item
	|-List<SkillData>.get_Item
	|-List<SkinQualityLodAdjuster>.get_Item
	|-List<SkinnedMeshRenderer>.get_Item
	|-List<SolverManager>.get_Item
	|-List<SortieEntrustStockData>.get_Item
	|-List<SortieEntrustUnitData>.get_Item
	|-List<SourceCode>.get_Item
	|-List<SourceRef>.get_Item
	|-List<SpringCollider>.get_Item
	|-List<Sprite>.get_Item
	|-List<string>.get_Item
	|-List<StringBuilder>.get_Item
	|-List<StructProperty>.get_Item
	|-List<SupportData>.get_Item
	|-List<SymbolRef>.get_Item
	|-List<TMP_Character>.get_Item
	|-List<TMP_FontAsset>.get_Item
	|-List<TMP_Glyph>.get_Item
	|-List<TMP_GlyphPairAdjustmentRecord>.get_Item
	|-List<TMP_Sprite>.get_Item
	|-List<TMP_SpriteAsset>.get_Item
	|-List<TMP_SpriteCharacter>.get_Item
	|-List<TMP_SpriteGlyph>.get_Item
	|-List<TMP_Style>.get_Item
	|-List<TMP_Text>.get_Item
	|-List<Task>.get_Item
	|-List<TasteData>.get_Item
	|-List<TextMeshProUGUI>.get_Item
	|-List<Texture2D>.get_Item
	|-List<Thread>.get_Item
	|-List<TimelineClip>.get_Item
	|-List<Timer>.get_Item
	|-List<TipsData>.get_Item
	|-List<Toggle>.get_Item
	|-List<TrackAsset>.get_Item
	|-List<Transform>.get_Item
	|-List<TutorialData>.get_Item
	|-List<Type>.get_Item
	|-List<TypeSpec>.get_Item
	|-List<Unit>.get_Item
	|-List<UnitItem>.get_Item
	|-List<UnitRelianceMapResult>.get_Item
	|-List<UnitRing>.get_Item
	|-List<UnityEvent>.get_Item
	|-List<VersusMapEditCategoryContent>.get_Item
	|-List<VersusServerCasualMetaData>.get_Item
	|-List<VersusServerRankedMetaData>.get_Item
	|-List<VersusServerReplayMetaData>.get_Item
	|-List<Volume>.get_Item
	|-List<VolumeComponent>.get_Item
	|-List<WatchItem>.get_Item
	|-List<WindActor>.get_Item
	|-List<X509CertificateImpl>.get_Item
	|-List<XRDisplaySubsystem>.get_Item
	|-List<XmlSchema>.get_Item
	|-List<XmlSchemaElement>.get_Item
	|-List<XmlSchemaObject>.get_Item
	|-List<AICannon.CannonData>.get_Item
	|-List<AIInterruptAttack.Candidate>.get_Item
	|-List<AddressablesImpl.ResourceLocatorInfo>.get_Item
	|-List<AdhocAssetLoader.Asset>.get_Item
	|-List<AkBankManager.BankHandle>.get_Item
	|-List<AkEvent.CallbackData>.get_Item
	|-List<AkWwiseInitializationSettings.PlatformSettings>.get_Item
	|-List<AssetTable.Accessory>.get_Item
	|-List<CalculatorUtil.Entity>.get_Item
	|-List<ChapterRecord.Record>.get_Item
	|-List<CinemachineBrain.BrainFrame>.get_Item
	|-List<CinemachineImpulseManager.ImpulseEvent>.get_Item
	|-List<CinemachineStoryboard.CanvasInfo>.get_Item
	|-List<CinemachineVolumeSettings.VcamExtraState>.get_Item
	|-List<ClassChangeJobMenuItemContent.WeaponLevelItem>.get_Item
	|-List<CombatGaugeController.Value>.get_Item
	|-List<CombatViewerSettings.ViewerPhase>.get_Item
	|-List<ConditionGetterCommand.Command>.get_Item
	|-List<DamageInfo.Info>.get_Item
	|-List<DebugCommandline.Property>.get_Item
	|-List<DebugPathMenu.EntryData>.get_Item
	|-List<Directory.SearchData>.get_Item
	|-List<DishAllMenuContent.EnhanceObject>.get_Item
	|-List<DishSelectFoodInfoContent.FoodstuffObject>.get_Item
	|-List<DishSelectFoodInfoContent.UnitObject>.get_Item
	|-List<DishSelectMenuCategoryContent.CategoryObject>.get_Item
	|-List<DragonRideSequence.PrizeData>.get_Item
	|-List<DragonRideTargetGroup.ChainSEManager>.get_Item
	|-List<Dropdown.DropdownItem>.get_Item
	|-List<Dropdown.OptionData>.get_Item
	|-List<EventSequence.Coroutine>.get_Item
	|-List<EventTrigger.Entry>.get_Item
	|-List<ExchangeYesNoDialog.ItemParam>.get_Item
	|-List<GameSaveDataHeaderReader.Handle>.get_Item
	|-List<GmapMapInfoContent.ItemInfo>.get_Item
	|-List<GodGrowthData.LevelData>.get_Item
	|-List<GrassData.SpriteInfo>.get_Item
	|-List<HelpManager.Item>.get_Item
	|-List<HubMiniMap.IconData>.get_Item
	|-List<InvestmentMenuContent.AnimalInfo>.get_Item
	|-List<InvestmentMenuContent.DropItemInfo>.get_Item
	|-List<InvestmentNationDataMenu.AnimalInfo>.get_Item
	|-List<InvestmentNationDataMenu.ItemInfo>.get_Item
	|-List<ItemListYesNoDialog.ItemParam>.get_Item
	|-List<LaterTalkSetter.UnitData>.get_Item
	|-List<LocalVariables.VariableScope>.get_Item
	|-List<MapDispos.ActualData>.get_Item
	|-List<MapDispos.Pos>.get_Item
	|-List<MapEditHistory.MapEditCommand>.get_Item
	|-List<MapImageTerrain.MinimapInfo>.get_Item
	|-List<MapLayer.Data>.get_Item
	|-List<MapMaterial.Node>.get_Item
	|-List<MapObject.DitherPair>.get_Item
	|-List<MapObject.Pair>.get_Item
	|-List<MapObject.RigidInfo>.get_Item
	|-List<MapOverlap.Data>.get_Item
	|-List<MapTarget.Data>.get_Item
	|-List<MapTerrain.LayerData>.get_Item
	|-List<MapTerrain.OverlapData>.get_Item
	|-List<MuscleSquatSequence.RandomPack>.get_Item
	|-List<MyRoomWakeupSequence.RelianceWakeup>.get_Item
	|-List<PointerInputModule.ButtonState>.get_Item
	|-List<ProfileCard.FreeStamp>.get_Item
	|-List<RefineRingInfoWindow.RingRefineStatistics>.get_Item
	|-List<RegexCharClass.SingleRange>.get_Item
	|-List<RelayMessageMenuContent.KindIcon>.get_Item
	|-List<RelayUserData.EnteredBattle>.get_Item
	|-List<RelayWdwMapHelp.ShowItem>.get_Item
	|-List<RingListSequence.PageData>.get_Item
	|-List<SimpleAnimationPlayable.StateInfo>.get_Item
	|-List<SkillData.Func>.get_Item
	|-List<SolanelInfoMenuContent.HelpFastTravel>.get_Item
	|-List<SolanelInfoMenuContent.Infomation>.get_Item
	|-List<SortieEntrustUnitData.WeaponKindExp>.get_Item
	|-List<SoundSystem.LipSyncData>.get_Item
	|-List<StencilMaterial.MatEntry>.get_Item
	|-List<TMP_Dropdown.DropdownItem>.get_Item
	|-List<TMP_Dropdown.OptionData>.get_Item
	|-List<TMP_MaterialManager.FallbackMaterial>.get_Item
	|-List<TMP_MaterialManager.MaskingMaterial>.get_Item
	|-List<TransformAnimation.Animator>.get_Item
	|-List<TroopListSortMenu.SortTitle>.get_Item
	|-List<UnitStatusSetter.SkillSetter>.get_Item
	|-List<UnitStatusSetter.WeaponLevelSetter>.get_Item
	|-List<GameSaveDataUtil.ProcDeleteAll.Data>.get_Item
	|-List<RelayCompletionAwardData.CalcResult.Item>.get_Item
	|-List<SoundWwise.SoundBankManager.BankHandle>.get_Item
	|-List<TransformAnimation.Animator.Node>.get_Item
	|-List<Versus.DownloadHistory.CheckData>.get_Item
	|
	|-RVA: 0x3B19DF0 Offset: 0x3B19EF1 VA: 0x3B19DF0
	|-List<CommonBattleSequence.Reliance<object>>.get_Item
	|
	|-RVA: 0x3B1CFE0 Offset: 0x3B1D0E1 VA: 0x3B1CFE0
	|-List<RenderGraphResourcePool.ResourceLogInfo<object>>.get_Item
	|
	|-RVA: 0x3B1FF00 Offset: 0x3B20001 VA: 0x3B1FF00
	|-List<ValueTuple<int, object>>.get_Item
	|
	|-RVA: 0x3DE0B80 Offset: 0x3DE0C81 VA: 0x3DE0B80
	|-List<ValueTuple<Int32Enum, int>>.get_Item
	|-List<ValueTuple<HubAccessManager.MaterialCalculator.Type, int>>.get_Item
	|
	|-RVA: 0x3DE39C0 Offset: 0x3DE3AC1 VA: 0x3DE39C0
	|-List<ValueTuple<object, ValueTuple<object, int>>>.get_Item
	|
	|-RVA: 0x3DE6BB0 Offset: 0x3DE6CB1 VA: 0x3DE6BB0
	|-List<ValueTuple<object, int>>.get_Item
	|-List<ValueTuple<string, int>>.get_Item
	|
	|-RVA: 0x3DE9AC0 Offset: 0x3DE9BC1 VA: 0x3DE9AC0
	|-List<ValueTuple<Vector3, float>>.get_Item
	|
	|-RVA: 0x3DECAD0 Offset: 0x3DECBD1 VA: 0x3DECAD0
	|-List<ValueTuple<ItemData.Kinds[], WeaponLevel.Kind, int>>.get_Item
	|-List<ValueTuple<object, Int32Enum, int>>.get_Item
	|
	|-RVA: 0x3DEFA10 Offset: 0x3DEFB11 VA: 0x3DEFA10
	|-List<ValueTuple<object, int, int, int>>.get_Item
	|-List<ValueTuple<string, int, int, int>>.get_Item
	|
	|-RVA: 0x3DF2BF0 Offset: 0x3DF2CF1 VA: 0x3DF2BF0
	|-List<AnimatorClipInfo>.get_Item
	|
	|-RVA: 0x3DF5A30 Offset: 0x3DF5B31 VA: 0x3DF5A30
	|-List<AsyncOperationHandle>.get_Item
	|
	|-RVA: 0x3DF8C40 Offset: 0x3DF8D41 VA: 0x3DF8C40
	|-List<BoneWeight>.get_Item
	|
	|-RVA: 0x3DFBE00 Offset: 0x3DFBF01 VA: 0x3DFBE00
	|-List<bool>.get_Item
	|
	|-RVA: 0x3E79360 Offset: 0x3E79461 VA: 0x3E79360
	|-List<byte>.get_Item
	|
	|-RVA: 0x3E7C180 Offset: 0x3E7C281 VA: 0x3E7C180
	|-List<CameraInfo>.get_Item
	|
	|-RVA: 0x3EAEA60 Offset: 0x3EAEB61 VA: 0x3EAEA60
	|-List<CameraPosition>.get_Item
	|-List<DataType>.get_Item
	|-List<Int32Enum>.get_Item
	|-List<RegexOptions>.get_Item
	|-List<CapabilityDefinition.Type>.get_Item
	|-List<Cooking.ConversationType>.get_Item
	|-List<ItemData.Kinds>.get_Item
	|-List<MapPanelActive.MeshIndex>.get_Item
	|-List<MapPanelDeploy.MeshIndex>.get_Item
	|-List<MapUIGauge.IconIndex>.get_Item
	|-List<TutorialListTopMenu.SelectCategoryType>.get_Item
	|
	|-RVA: 0x3E7F090 Offset: 0x3E7F191 VA: 0x3E7F090
	|-List<char>.get_Item
	|
	|-RVA: 0x3E81E90 Offset: 0x3E81F91 VA: 0x3E81E90
	|-List<Color>.get_Item
	|
	|-RVA: 0x3E84E90 Offset: 0x3E84F91 VA: 0x3E84E90
	|-List<Color32>.get_Item
	|
	|-RVA: 0x3E87CB0 Offset: 0x3E87DB1 VA: 0x3E87CB0
	|-List<ConstraintSource>.get_Item
	|
	|-RVA: 0x3E8ABF0 Offset: 0x3E8ACF1 VA: 0x3E8ABF0
	|-List<ContourVertex>.get_Item
	|
	|-RVA: 0x3E8DE00 Offset: 0x3E8DF01 VA: 0x3E8DE00
	|-List<DataStoreRatingInfo>.get_Item
	|
	|-RVA: 0x3E90FB0 Offset: 0x3E910B1 VA: 0x3E90FB0
	|-List<DataStoreResult>.get_Item
	|
	|-RVA: 0x3E93DC0 Offset: 0x3E93EC1 VA: 0x3E93DC0
	|-List<DateTime>.get_Item
	|
	|-RVA: 0x3E96BE0 Offset: 0x3E96CE1 VA: 0x3E96BE0
	|-List<DateTimeOffset>.get_Item
	|
	|-RVA: 0x3E99AC0 Offset: 0x3E99BC1 VA: 0x3E99AC0
	|-List<Decimal>.get_Item
	|
	|-RVA: 0x3E9C9D0 Offset: 0x3E9CAD1 VA: 0x3E9C9D0
	|-List<DiagnosticEvent>.get_Item
	|
	|-RVA: 0x3E9FDD0 Offset: 0x3E9FED1 VA: 0x3E9FDD0
	|-List<double>.get_Item
	|
	|-RVA: 0x3EA2C30 Offset: 0x3EA2D31 VA: 0x3EA2C30
	|-List<Friend>.get_Item
	|
	|-RVA: 0x3EA5F90 Offset: 0x3EA6091 VA: 0x3EA5F90
	|-List<GlyphRect>.get_Item
	|
	|-RVA: 0x3EA8E60 Offset: 0x3EA8F61 VA: 0x3EA8E60
	|-List<short>.get_Item
	|
	|-RVA: 0x3EABC60 Offset: 0x3EABD61 VA: 0x3EABC60
	|-List<int>.get_Item
	|
	|-RVA: 0x3EB1860 Offset: 0x3EB1961 VA: 0x3EB1860
	|-List<long>.get_Item
	|
	|-RVA: 0x3DFEC30 Offset: 0x3DFED31 VA: 0x3DFEC30
	|-List<IntPtr>.get_Item
	|
	|-RVA: 0x3E01A40 Offset: 0x3E01B41 VA: 0x3E01A40
	|-List<InterpretedFrameInfo>.get_Item
	|
	|-RVA: 0x3E04980 Offset: 0x3E04A81 VA: 0x3E04980
	|-List<IntervalTreeNode>.get_Item
	|
	|-RVA: 0x3E07B30 Offset: 0x3E07C31 VA: 0x3E07B30
	|-List<LengthLimitProperties>.get_Item
	|
	|-RVA: 0x3E0A940 Offset: 0x3E0AA41 VA: 0x3E0A940
	|-List<MapPos>.get_Item
	|
	|-RVA: 0x3E0D7A0 Offset: 0x3E0D8A1 VA: 0x3E0D7A0
	|-List<Matrix4x4>.get_Item
	|
	|-RVA: 0x3E13AD0 Offset: 0x3E13BD1 VA: 0x3E13AD0
	|-List<ObjectInitializationData>.get_Item
	|
	|-RVA: 0x3E16F00 Offset: 0x3E17001 VA: 0x3E16F00
	|-List<PlayableBinding>.get_Item
	|
	|-RVA: 0x3E1A130 Offset: 0x3E1A231 VA: 0x3E1A130
	|-List<PlayerLoopSystem>.get_Item
	|
	|-RVA: 0x3DA45D0 Offset: 0x3DA46D1 VA: 0x3DA45D0
	|-List<PlayerLoopSystemInternal>.get_Item
	|
	|-RVA: 0x3DA7970 Offset: 0x3DA7A71 VA: 0x3DA7970
	|-List<RangePositionInfo>.get_Item
	|
	|-RVA: 0x3DAA880 Offset: 0x3DAA981 VA: 0x3DAA880
	|-List<Ranking2ChartInfoInput>.get_Item
	|
	|-RVA: 0x3DAD6D0 Offset: 0x3DAD7D1 VA: 0x3DAD6D0
	|-List<RaycastHit2D>.get_Item
	|
	|-RVA: 0x3DB0B10 Offset: 0x3DB0C11 VA: 0x3DB0B10
	|-List<RaycastResult>.get_Item
	|
	|-RVA: 0x3DB42C0 Offset: 0x3DB43C1 VA: 0x3DB42C0
	|-List<Rect>.get_Item
	|
	|-RVA: 0x3DB72C0 Offset: 0x3DB73C1 VA: 0x3DB72C0
	|-List<RendererListHandle>.get_Item
	|
	|-RVA: 0x3DBA0D0 Offset: 0x3DBA1D1 VA: 0x3DBA0D0
	|-List<ResourceHandle>.get_Item
	|
	|-RVA: 0x3DBCEE0 Offset: 0x3DBCFE1 VA: 0x3DBCEE0
	|-List<sbyte>.get_Item
	|
	|-RVA: 0x3DBFCF0 Offset: 0x3DBFDF1 VA: 0x3DBFCF0
	|-List<ShaderTagId>.get_Item
	|
	|-RVA: 0x3E3B950 Offset: 0x3E3BA51 VA: 0x3E3B950
	|-List<float>.get_Item
	|
	|-RVA: 0x3E3E810 Offset: 0x3E3E911 VA: 0x3E3E810
	|-List<SphericalHarmonicsL2>.get_Item
	|
	|-RVA: 0x3E42490 Offset: 0x3E42591 VA: 0x3E42490
	|-List<SubMeshDescriptor>.get_Item
	|
	|-RVA: 0x3E45850 Offset: 0x3E45951 VA: 0x3E45850
	|-List<TablePair>.get_Item
	|
	|-RVA: 0x3E48760 Offset: 0x3E48861 VA: 0x3E48760
	|-List<TimeSpan>.get_Item
	|
	|-RVA: 0x3E4B570 Offset: 0x3E4B671 VA: 0x3E4B570
	|-List<UICharInfo>.get_Item
	|
	|-RVA: 0x3E4E560 Offset: 0x3E4E661 VA: 0x3E4E560
	|-List<UILineInfo>.get_Item
	|
	|-RVA: 0x3E514D0 Offset: 0x3E515D1 VA: 0x3E514D0
	|-List<UIVertex>.get_Item
	|
	|-RVA: 0x3E55110 Offset: 0x3E55211 VA: 0x3E55110
	|-List<ushort>.get_Item
	|
	|-RVA: 0x3E57F10 Offset: 0x3E58011 VA: 0x3E57F10
	|-List<uint>.get_Item
	|
	|-RVA: 0x3DC2B00 Offset: 0x3DC2C01 VA: 0x3DC2B00
	|-List<ulong>.get_Item
	|
	|-RVA: 0x3DC5900 Offset: 0x3DC5A01 VA: 0x3DC5900
	|-List<Vector2>.get_Item
	|
	|-RVA: 0x3DC87D0 Offset: 0x3DC88D1 VA: 0x3DC87D0
	|-List<Vector3>.get_Item
	|
	|-RVA: 0x3DCB7B0 Offset: 0x3DCB8B1 VA: 0x3DCB7B0
	|-List<Vector4>.get_Item
	|
	|-RVA: 0x3DCE7C0 Offset: 0x3DCE8C1 VA: 0x3DCE7C0
	|-List<VertexAttributeDescriptor>.get_Item
	|
	|-RVA: 0x3DD16A0 Offset: 0x3DD17A1 VA: 0x3DD16A0
	|-List<X509ChainStatus>.get_Item
	|
	|-RVA: 0x3DD45F0 Offset: 0x3DD46F1 VA: 0x3DD45F0
	|-List<XRView>.get_Item
	|
	|-RVA: 0x3DD79B0 Offset: 0x3DD7AB1 VA: 0x3DD79B0
	|-List<AmiiboSequence.GainItemData>.get_Item
	|
	|-RVA: 0x3DDA900 Offset: 0x3DDAA01 VA: 0x3DDA900
	|-List<AnimationOutputWeightProcessor.WeightInfo>.get_Item
	|
	|-RVA: 0x3DDDC70 Offset: 0x3DDDD71 VA: 0x3DDDC70
	|-List<ArenaOrderSequence.GodInfo>.get_Item
	|
	|-RVA: 0x3E1D4D0 Offset: 0x3E1D5D1 VA: 0x3E1D4D0
	|-List<BattleInfo.SupportData>.get_Item
	|
	|-RVA: 0x3E203F0 Offset: 0x3E204F1 VA: 0x3E203F0
	|-List<BeforeRenderHelper.OrderBlock>.get_Item
	|
	|-RVA: 0x3E23330 Offset: 0x3E23431 VA: 0x3E23330
	|-List<Camera.RenderRequest>.get_Item
	|
	|-RVA: 0x3E26540 Offset: 0x3E26641 VA: 0x3E26540
	|-List<CameraState.CustomBlendable>.get_Item
	|
	|-RVA: 0x3E29450 Offset: 0x3E29551 VA: 0x3E29450
	|-List<CinemachineClearShot.Pair>.get_Item
	|
	|-RVA: 0x3E2C260 Offset: 0x3E2C361 VA: 0x3E2C260
	|-List<CinemachineStateDrivenCamera.HashPair>.get_Item
	|
	|-RVA: 0x3E2F0A0 Offset: 0x3E2F1A1 VA: 0x3E2F0A0
	|-List<DelayedActionManager.DelegateInfo>.get_Item
	|
	|-RVA: 0x3E322D0 Offset: 0x3E323D1 VA: 0x3E322D0
	|-List<Detail.AsyncResultInt>.get_Item
	|
	|-RVA: 0x3E35690 Offset: 0x3E35791 VA: 0x3E35690
	|-List<Detail.CppArray>.get_Item
	|
	|-RVA: 0x3E385A0 Offset: 0x3E386A1 VA: 0x3E385A0
	|-List<Detail.NotificationEventInt>.get_Item
	|
	|-RVA: 0x3E5AD20 Offset: 0x3E5AE21 VA: 0x3E5AD20
	|-List<DragonRideTargetGroup.ChainParam>.get_Item
	|
	|-RVA: 0x3E5DC60 Offset: 0x3E5DD61 VA: 0x3E5DC60
	|-List<GmapPathAdjuster.TargetModel>.get_Item
	|
	|-RVA: 0x3E60E70 Offset: 0x3E60F71 VA: 0x3E60E70
	|-List<GmapSpotAdjuster.TargetModel>.get_Item
	|
	|-RVA: 0x3E64080 Offset: 0x3E64181 VA: 0x3E64080
	|-List<HubFastTravel.Location>.get_Item
	|
	|-RVA: 0x3E672A0 Offset: 0x3E673A1 VA: 0x3E672A0
	|-List<HubLensFlare.Flare>.get_Item
	|
	|-RVA: 0x3E6A6B0 Offset: 0x3E6A7B1 VA: 0x3E6A6B0
	|-List<InventoryPoolItemMenuContent.KindBgNameClass>.get_Item
	|
	|-RVA: 0x3E6D5C0 Offset: 0x3E6D6C1 VA: 0x3E6D5C0
	|-List<Map.Pos>.get_Item
	|
	|-RVA: 0x3E703E0 Offset: 0x3E704E1 VA: 0x3E703E0
	|-List<MapImage.BackupTerrain>.get_Item
	|
	|-RVA: 0x3E732C0 Offset: 0x3E733C1 VA: 0x3E732C0
	|-List<MapImageRange.Pos>.get_Item
	|
	|-RVA: 0x3E76180 Offset: 0x3E76281 VA: 0x3E76180
	|-List<MapMind.Target>.get_Item
	|
	|-RVA: 0x3D85D80 Offset: 0x3D85E81 VA: 0x3D85D80
	|-List<MapPanelDebug.Entity>.get_Item
	|
	|-RVA: 0x3D88F30 Offset: 0x3D89031 VA: 0x3D88F30
	|-List<NexRanking.Data>.get_Item
	|
	|-RVA: 0x3D8BD50 Offset: 0x3D8BE51 VA: 0x3D8BD50
	|-List<NexVersus.RatingData>.get_Item
	|
	|-RVA: 0x3D8EC30 Offset: 0x3D8ED31 VA: 0x3D8EC30
	|-List<PackedPlayModeBuildLogs.RuntimeBuildLog>.get_Item
	|
	|-RVA: 0x3D91B80 Offset: 0x3D91C81 VA: 0x3D91B80
	|-List<ParticleSystem.Particle>.get_Item
	|
	|-RVA: 0x3D94EF0 Offset: 0x3D94FF1 VA: 0x3D94EF0
	|-List<RangeData.Offset>.get_Item
	|
	|-RVA: 0x3D97D30 Offset: 0x3D97E31 VA: 0x3D97D30
	|-List<RenderGraphDebugData.PassDebugData>.get_Item
	|
	|-RVA: 0x3D9AF60 Offset: 0x3D9B061 VA: 0x3D9AF60
	|-List<RenderGraphDebugData.ResourceDebugData>.get_Item
	|
	|-RVA: 0x3D9E300 Offset: 0x3D9E401 VA: 0x3D9E300
	|-List<RingCleaningUnitSelectMenu.GodParam>.get_Item
	|
	|-RVA: 0x3DA1250 Offset: 0x3DA1351 VA: 0x3DA1250
	|-List<ShadowUtility.Edge>.get_Item
	|
	|-RVA: 0x3D13A60 Offset: 0x3D13B61 VA: 0x3D13A60
	|-List<SkillArray.Entity>.get_Item
	|
	|-RVA: 0x3D168C0 Offset: 0x3D169C1 VA: 0x3D168C0
	|-List<TexturePacker_JsonArray.Frame>.get_Item
	|
	|-RVA: 0x3D19E60 Offset: 0x3D19F61 VA: 0x3D19E60
	|-List<TimeNotificationBehaviour.NotificationEntry>.get_Item
	|
	|-RVA: 0x3D1D090 Offset: 0x3D1D191 VA: 0x3D1D090
	|-List<UnitySynchronizationContext.WorkRequest>.get_Item
	|
	|-RVA: 0x3D20280 Offset: 0x3D20381 VA: 0x3D20280
	|-List<XmlSchemaObjectTable.XmlSchemaObjectEntry>.get_Item
	|
	|-RVA: 0x3D231A0 Offset: 0x3D232A1 VA: 0x3D231A0
	|-List<AssetBundleBuildMap.AssetBundleEntry.AssetPathString>.get_Item
	|
	|-RVA: 0x3D260F0 Offset: 0x3D261F1 VA: 0x3D260F0
	|-List<Detail.DataStore.DataStoreChangeMetaParamInt>.get_Item
	|
	|-RVA: 0x3D294E0 Offset: 0x3D295E1 VA: 0x3D294E0
	|-List<Detail.DataStore.DataStoreDeleteParamInt>.get_Item
	|
	|-RVA: 0x3D2C3F0 Offset: 0x3D2C4F1 VA: 0x3D2C3F0
	|-List<Detail.DataStore.DataStoreGetMetaParamInt>.get_Item
	|
	|-RVA: 0x3D2F790 Offset: 0x3D2F891 VA: 0x3D2F790
	|-List<Detail.DataStore.DataStoreMetaInfoInt>.get_Item
	|
	|-RVA: 0x3CF3FC0 Offset: 0x3CF40C1 VA: 0x3CF3FC0
	|-List<Detail.DataStore.DataStorePasswordInfoInt>.get_Item
	|
	|-RVA: 0x3CF71A0 Offset: 0x3CF72A1 VA: 0x3CF71A0
	|-List<Detail.DataStore.DataStorePersistenceInfoInt>.get_Item
	|
	|-RVA: 0x3CFA390 Offset: 0x3CFA491 VA: 0x3CFA390
	|-List<Detail.DataStore.DataStorePreparePostParamInt>.get_Item
	|
	|-RVA: 0x3CFD710 Offset: 0x3CFD811 VA: 0x3CFD710
	|-List<Detail.DataStore.DataStoreRateObjectParamInt>.get_Item
	|
	|-RVA: 0x3D00610 Offset: 0x3D00711 VA: 0x3D00610
	|-List<Detail.DataStore.DataStoreRatingInitParamInt>.get_Item
	|
	|-RVA: 0x3D037E0 Offset: 0x3D038E1 VA: 0x3D037E0
	|-List<Detail.DataStore.DataStoreRatingTargetInt>.get_Item
	|
	|-RVA: 0x3D06710 Offset: 0x3D06811 VA: 0x3D06710
	|-List<Detail.Ranking.RankingCachedResultInt>.get_Item
	|
	|-RVA: 0x3D09CA0 Offset: 0x3D09DA1 VA: 0x3D09CA0
	|-List<Detail.Ranking.RankingOrderParamInt>.get_Item
	|
	|-RVA: 0x3D0CBC0 Offset: 0x3D0CCC1 VA: 0x3D0CBC0
	|-List<Detail.Ranking.RankingRankDataInt>.get_Item
	|
	|-RVA: 0x3D10160 Offset: 0x3D10261 VA: 0x3D10160
	|-List<Detail.Ranking2.Ranking2ChartInfoInt>.get_Item
	|
	|-RVA: 0x3D66B40 Offset: 0x3D66C41 VA: 0x3D66B40
	|-List<Detail.Ranking2.Ranking2RankDataInt>.get_Item
	|
	|-RVA: 0x3D6A080 Offset: 0x3D6A181 VA: 0x3D6A080
	|-List<Detail.Ranking2.Ranking2ScoreDataInt>.get_Item
	|
	|-RVA: 0x3D6CF80 Offset: 0x3D6D081 VA: 0x3D6CF80
	|-List<Detail.Screening.ScreeningContextInfoInt>.get_Item
	|
	|-RVA: 0x3D701A0 Offset: 0x3D702A1 VA: 0x3D701A0
	|-List<Detail.Subscriber.SubscriberContentInt>.get_Item
	|
	|-RVA: 0x3D73940 Offset: 0x3D73A41 VA: 0x3D73940
	|-List<Detail.Subscriber.SubscriberGetContentParamInt>.get_Item
	|
	|-RVA: 0x3D76B30 Offset: 0x3D76C31 VA: 0x3D76B30
	|-List<Detail.Subscriber.SubscriberUserStatusInfoInt>.get_Item
	|
	|-RVA: 0x3D79EC0 Offset: 0x3D79FC1 VA: 0x3D79EC0
	|-List<Detail.Subscriber.SubscriberUserStatusParamInt>.get_Item
	|
	|-RVA: 0x3D7D070 Offset: 0x3D7D171 VA: 0x3D7D070
	|-List<Detail.Utility.IntegerSettings>.get_Item
	|
	|-RVA: 0x3D7FE90 Offset: 0x3D7FF91 VA: 0x3D7FE90
	|-List<Detail.Utility.UniqueIdInfoInt>.get_Item
	|
	|-RVA: 0x3D82D70 Offset: 0x3D82E71 VA: 0x3D82D70
	|-List<MapHistory.Rewind.LatestInspectorData>.get_Item
	|
	|-RVA: 0x305F030 Offset: 0x305F131 VA: 0x305F030
	|-List<MapHistory.Rewind.WorkTerrainData>.get_Item
	|
	|-RVA: 0x3062020 Offset: 0x3062121 VA: 0x3062020
	|-List<MapSkill.AroundCalculator.Result>.get_Item
	|
	|-RVA: 0x3064F70 Offset: 0x3065071 VA: 0x3064F70
	|-List<TargetPositionCache.CacheCurve.Item>.get_Item
	|
	|-RVA: 0x30682F0 Offset: 0x30683F1 VA: 0x30682F0
	|-List<TargetPositionCache.CacheEntry.RecordingItem>.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void set_Item(int index, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3B0ACC0 Offset: 0x3B0ADC1 VA: 0x3B0ACC0
	|-List<IntervalTree.Entry<object>>.set_Item
	|
	|-RVA: 0x3B16EF0 Offset: 0x3B16FF1 VA: 0x3B16EF0
	|-List<KeyValuePair<AnimationClip, AnimationClip>>.set_Item
	|-List<KeyValuePair<object, object>>.set_Item
	|
	|-RVA: 0x3B0DE90 Offset: 0x3B0DF91 VA: 0x3B0DE90
	|-List<KeyValuePair<DateTime, object>>.set_Item
	|
	|-RVA: 0x3B13D10 Offset: 0x3B13E11 VA: 0x3B13D10
	|-List<KeyValuePair<IAwaiter, ValueTuple<int, DateTime, string>>>.set_Item
	|-List<KeyValuePair<object, ValueTuple<int, DateTime, object>>>.set_Item
	|
	|-RVA: 0x3B10DB0 Offset: 0x3B10EB1 VA: 0x3B10DB0
	|-List<KeyValuePair<int, object>>.set_Item
	|
	|-RVA: 0x3B19E50 Offset: 0x3B19F51 VA: 0x3B19E50
	|-List<CommonBattleSequence.Reliance<object>>.set_Item
	|
	|-RVA: 0x3B1D020 Offset: 0x3B1D121 VA: 0x3B1D020
	|-List<RenderGraphResourcePool.ResourceLogInfo<object>>.set_Item
	|
	|-RVA: 0x3B1FF40 Offset: 0x3B20041 VA: 0x3B1FF40
	|-List<ValueTuple<int, object>>.set_Item
	|
	|-RVA: 0x3DE0BC0 Offset: 0x3DE0CC1 VA: 0x3DE0BC0
	|-List<ValueTuple<Int32Enum, int>>.set_Item
	|
	|-RVA: 0x3DE3A20 Offset: 0x3DE3B21 VA: 0x3DE3A20
	|-List<ValueTuple<object, ValueTuple<object, int>>>.set_Item
	|
	|-RVA: 0x3DE6BF0 Offset: 0x3DE6CF1 VA: 0x3DE6BF0
	|-List<ValueTuple<object, int>>.set_Item
	|-List<ValueTuple<string, int>>.set_Item
	|
	|-RVA: 0x3DE9B10 Offset: 0x3DE9C11 VA: 0x3DE9B10
	|-List<ValueTuple<Vector3, float>>.set_Item
	|
	|-RVA: 0x3DECB10 Offset: 0x3DECC11 VA: 0x3DECB10
	|-List<ValueTuple<ItemData.Kinds[], WeaponLevel.Kind, int>>.set_Item
	|-List<ValueTuple<object, Int32Enum, int>>.set_Item
	|
	|-RVA: 0x3DEFA70 Offset: 0x3DEFB71 VA: 0x3DEFA70
	|-List<ValueTuple<object, int, int, int>>.set_Item
	|
	|-RVA: 0x3DF2C30 Offset: 0x3DF2D31 VA: 0x3DF2C30
	|-List<AnimatorClipInfo>.set_Item
	|
	|-RVA: 0x3DF5A90 Offset: 0x3DF5B91 VA: 0x3DF5A90
	|-List<AsyncOperationHandle>.set_Item
	|
	|-RVA: 0x3DF8CA0 Offset: 0x3DF8DA1 VA: 0x3DF8CA0
	|-List<BoneWeight>.set_Item
	|
	|-RVA: 0x3DFBE40 Offset: 0x3DFBF41 VA: 0x3DFBE40
	|-List<bool>.set_Item
	|
	|-RVA: 0x3E793A0 Offset: 0x3E794A1 VA: 0x3E793A0
	|-List<byte>.set_Item
	|
	|-RVA: 0x3E10D10 Offset: 0x3E10E11 VA: 0x3E10D10
	|-List<Camera>.set_Item
	|-List<Decorator>.set_Item
	|-List<DynValue>.set_Item
	|-List<GameObject>.set_Item
	|-List<IDisposable>.set_Item
	|-List<Instruction>.set_Item
	|-List<ItemData>.set_Item
	|-List<MapBackup>.set_Item
	|-List<Material>.set_Item
	|-List<object>.set_Item
	|-List<Phase>.set_Item
	|-List<ProfileCard>.set_Item
	|-List<RegexNode>.set_Item
	|-List<ScriptableObject>.set_Item
	|-List<ScriptableRenderPass>.set_Item
	|-List<SignalAsset>.set_Item
	|-List<Sprite>.set_Item
	|-List<string>.set_Item
	|-List<Texture2D>.set_Item
	|-List<Unit>.set_Item
	|-List<UnitRelianceMapResult>.set_Item
	|-List<UnityEvent>.set_Item
	|-List<Volume>.set_Item
	|-List<AssetTable.Accessory>.set_Item
	|-List<GameSaveDataHeaderReader.Handle>.set_Item
	|-List<MapDispos.ActualData>.set_Item
	|-List<MapDispos.Pos>.set_Item
	|-List<MapLayer.Data>.set_Item
	|-List<MapObject.RigidInfo>.set_Item
	|-List<RegexCharClass.SingleRange>.set_Item
	|-List<RingListSequence.PageData>.set_Item
	|-List<SimpleAnimationPlayable.StateInfo>.set_Item
	|
	|-RVA: 0x3E7C1C0 Offset: 0x3E7C2C1 VA: 0x3E7C1C0
	|-List<CameraInfo>.set_Item
	|
	|-RVA: 0x3E7F0D0 Offset: 0x3E7F1D1 VA: 0x3E7F0D0
	|-List<char>.set_Item
	|
	|-RVA: 0x3E81EE0 Offset: 0x3E81FE1 VA: 0x3E81EE0
	|-List<Color>.set_Item
	|
	|-RVA: 0x3E84ED0 Offset: 0x3E84FD1 VA: 0x3E84ED0
	|-List<Color32>.set_Item
	|
	|-RVA: 0x3E87CF0 Offset: 0x3E87DF1 VA: 0x3E87CF0
	|-List<ConstraintSource>.set_Item
	|
	|-RVA: 0x3E8AC50 Offset: 0x3E8AD51 VA: 0x3E8AC50
	|-List<ContourVertex>.set_Item
	|
	|-RVA: 0x3E8DE60 Offset: 0x3E8DF61 VA: 0x3E8DE60
	|-List<DataStoreRatingInfo>.set_Item
	|
	|-RVA: 0x3E90FF0 Offset: 0x3E910F1 VA: 0x3E90FF0
	|-List<DataStoreResult>.set_Item
	|
	|-RVA: 0x3E93E00 Offset: 0x3E93F01 VA: 0x3E93E00
	|-List<DateTime>.set_Item
	|
	|-RVA: 0x3E96C20 Offset: 0x3E96D21 VA: 0x3E96C20
	|-List<DateTimeOffset>.set_Item
	|
	|-RVA: 0x3E99B00 Offset: 0x3E99C01 VA: 0x3E99B00
	|-List<Decimal>.set_Item
	|
	|-RVA: 0x3E9CA40 Offset: 0x3E9CB41 VA: 0x3E9CA40
	|-List<DiagnosticEvent>.set_Item
	|
	|-RVA: 0x3E9FE10 Offset: 0x3E9FF11 VA: 0x3E9FE10
	|-List<double>.set_Item
	|
	|-RVA: 0x3EA2C90 Offset: 0x3EA2D91 VA: 0x3EA2C90
	|-List<Friend>.set_Item
	|
	|-RVA: 0x3EA5FD0 Offset: 0x3EA60D1 VA: 0x3EA5FD0
	|-List<GlyphRect>.set_Item
	|
	|-RVA: 0x3EA8EA0 Offset: 0x3EA8FA1 VA: 0x3EA8EA0
	|-List<short>.set_Item
	|
	|-RVA: 0x3EABCA0 Offset: 0x3EABDA1 VA: 0x3EABCA0
	|-List<int>.set_Item
	|
	|-RVA: 0x3EAEAA0 Offset: 0x3EAEBA1 VA: 0x3EAEAA0
	|-List<Int32Enum>.set_Item
	|
	|-RVA: 0x3EB18A0 Offset: 0x3EB19A1 VA: 0x3EB18A0
	|-List<long>.set_Item
	|
	|-RVA: 0x3DFEC70 Offset: 0x3DFED71 VA: 0x3DFEC70
	|-List<IntPtr>.set_Item
	|
	|-RVA: 0x3E01A80 Offset: 0x3E01B81 VA: 0x3E01A80
	|-List<InterpretedFrameInfo>.set_Item
	|
	|-RVA: 0x3E049E0 Offset: 0x3E04AE1 VA: 0x3E049E0
	|-List<IntervalTreeNode>.set_Item
	|
	|-RVA: 0x3E07B70 Offset: 0x3E07C71 VA: 0x3E07B70
	|-List<LengthLimitProperties>.set_Item
	|
	|-RVA: 0x3E0A980 Offset: 0x3E0AA81 VA: 0x3E0A980
	|-List<MapPos>.set_Item
	|
	|-RVA: 0x3E0D810 Offset: 0x3E0D911 VA: 0x3E0D810
	|-List<Matrix4x4>.set_Item
	|
	|-RVA: 0x3E13B40 Offset: 0x3E13C41 VA: 0x3E13B40
	|-List<ObjectInitializationData>.set_Item
	|
	|-RVA: 0x3E16F60 Offset: 0x3E17061 VA: 0x3E16F60
	|-List<PlayableBinding>.set_Item
	|
	|-RVA: 0x3E1A1A0 Offset: 0x3E1A2A1 VA: 0x3E1A1A0
	|-List<PlayerLoopSystem>.set_Item
	|
	|-RVA: 0x3DA4640 Offset: 0x3DA4741 VA: 0x3DA4640
	|-List<PlayerLoopSystemInternal>.set_Item
	|
	|-RVA: 0x3DA79B0 Offset: 0x3DA7AB1 VA: 0x3DA79B0
	|-List<RangePositionInfo>.set_Item
	|
	|-RVA: 0x3DAA8C0 Offset: 0x3DAA9C1 VA: 0x3DAA8C0
	|-List<Ranking2ChartInfoInput>.set_Item
	|
	|-RVA: 0x3DAD740 Offset: 0x3DAD841 VA: 0x3DAD740
	|-List<RaycastHit2D>.set_Item
	|
	|-RVA: 0x3DB0B90 Offset: 0x3DB0C91 VA: 0x3DB0B90
	|-List<RaycastResult>.set_Item
	|
	|-RVA: 0x3DB4310 Offset: 0x3DB4411 VA: 0x3DB4310
	|-List<Rect>.set_Item
	|
	|-RVA: 0x3DB7300 Offset: 0x3DB7401 VA: 0x3DB7300
	|-List<RendererListHandle>.set_Item
	|
	|-RVA: 0x3DBA110 Offset: 0x3DBA211 VA: 0x3DBA110
	|-List<ResourceHandle>.set_Item
	|
	|-RVA: 0x3DBCF20 Offset: 0x3DBD021 VA: 0x3DBCF20
	|-List<sbyte>.set_Item
	|
	|-RVA: 0x3DBFD30 Offset: 0x3DBFE31 VA: 0x3DBFD30
	|-List<ShaderTagId>.set_Item
	|
	|-RVA: 0x3E3B990 Offset: 0x3E3BA91 VA: 0x3E3B990
	|-List<float>.set_Item
	|
	|-RVA: 0x3E3E8A0 Offset: 0x3E3E9A1 VA: 0x3E3E8A0
	|-List<SphericalHarmonicsL2>.set_Item
	|
	|-RVA: 0x3E42500 Offset: 0x3E42601 VA: 0x3E42500
	|-List<SubMeshDescriptor>.set_Item
	|
	|-RVA: 0x3E45890 Offset: 0x3E45991 VA: 0x3E45890
	|-List<TablePair>.set_Item
	|
	|-RVA: 0x3E487A0 Offset: 0x3E488A1 VA: 0x3E487A0
	|-List<TimeSpan>.set_Item
	|
	|-RVA: 0x3E4B5C0 Offset: 0x3E4B6C1 VA: 0x3E4B5C0
	|-List<UICharInfo>.set_Item
	|
	|-RVA: 0x3E4E5A0 Offset: 0x3E4E6A1 VA: 0x3E4E5A0
	|-List<UILineInfo>.set_Item
	|
	|-RVA: 0x3E51560 Offset: 0x3E51661 VA: 0x3E51560
	|-List<UIVertex>.set_Item
	|
	|-RVA: 0x3E55150 Offset: 0x3E55251 VA: 0x3E55150
	|-List<ushort>.set_Item
	|
	|-RVA: 0x3E57F50 Offset: 0x3E58051 VA: 0x3E57F50
	|-List<uint>.set_Item
	|
	|-RVA: 0x3DC2B40 Offset: 0x3DC2C41 VA: 0x3DC2B40
	|-List<ulong>.set_Item
	|
	|-RVA: 0x3DC5940 Offset: 0x3DC5A41 VA: 0x3DC5940
	|-List<Vector2>.set_Item
	|
	|-RVA: 0x3DC8820 Offset: 0x3DC8921 VA: 0x3DC8820
	|-List<Vector3>.set_Item
	|
	|-RVA: 0x3DCB800 Offset: 0x3DCB901 VA: 0x3DCB800
	|-List<Vector4>.set_Item
	|
	|-RVA: 0x3DCE800 Offset: 0x3DCE901 VA: 0x3DCE800
	|-List<VertexAttributeDescriptor>.set_Item
	|
	|-RVA: 0x3DD16E0 Offset: 0x3DD17E1 VA: 0x3DD16E0
	|-List<X509ChainStatus>.set_Item
	|
	|-RVA: 0x3DD4650 Offset: 0x3DD4751 VA: 0x3DD4650
	|-List<XRView>.set_Item
	|
	|-RVA: 0x3DD79F0 Offset: 0x3DD7AF1 VA: 0x3DD79F0
	|-List<AmiiboSequence.GainItemData>.set_Item
	|
	|-RVA: 0x3DDA970 Offset: 0x3DDAA71 VA: 0x3DDA970
	|-List<AnimationOutputWeightProcessor.WeightInfo>.set_Item
	|
	|-RVA: 0x3DDDCB0 Offset: 0x3DDDDB1 VA: 0x3DDDCB0
	|-List<ArenaOrderSequence.GodInfo>.set_Item
	|
	|-RVA: 0x3E1D510 Offset: 0x3E1D611 VA: 0x3E1D510
	|-List<BattleInfo.SupportData>.set_Item
	|
	|-RVA: 0x3E20430 Offset: 0x3E20531 VA: 0x3E20430
	|-List<BeforeRenderHelper.OrderBlock>.set_Item
	|
	|-RVA: 0x3E23390 Offset: 0x3E23491 VA: 0x3E23390
	|-List<Camera.RenderRequest>.set_Item
	|
	|-RVA: 0x3E26580 Offset: 0x3E26681 VA: 0x3E26580
	|-List<CameraState.CustomBlendable>.set_Item
	|
	|-RVA: 0x3E29490 Offset: 0x3E29591 VA: 0x3E29490
	|-List<CinemachineClearShot.Pair>.set_Item
	|
	|-RVA: 0x3E2C2A0 Offset: 0x3E2C3A1 VA: 0x3E2C2A0
	|-List<CinemachineStateDrivenCamera.HashPair>.set_Item
	|
	|-RVA: 0x3E2F100 Offset: 0x3E2F201 VA: 0x3E2F100
	|-List<DelayedActionManager.DelegateInfo>.set_Item
	|
	|-RVA: 0x3E32340 Offset: 0x3E32441 VA: 0x3E32340
	|-List<Detail.AsyncResultInt>.set_Item
	|
	|-RVA: 0x3E356D0 Offset: 0x3E357D1 VA: 0x3E356D0
	|-List<Detail.CppArray>.set_Item
	|
	|-RVA: 0x3E38610 Offset: 0x3E38711 VA: 0x3E38610
	|-List<Detail.NotificationEventInt>.set_Item
	|
	|-RVA: 0x3E5AD60 Offset: 0x3E5AE61 VA: 0x3E5AD60
	|-List<DragonRideTargetGroup.ChainParam>.set_Item
	|
	|-RVA: 0x3E5DCC0 Offset: 0x3E5DDC1 VA: 0x3E5DCC0
	|-List<GmapPathAdjuster.TargetModel>.set_Item
	|
	|-RVA: 0x3E60ED0 Offset: 0x3E60FD1 VA: 0x3E60ED0
	|-List<GmapSpotAdjuster.TargetModel>.set_Item
	|
	|-RVA: 0x3E640E0 Offset: 0x3E641E1 VA: 0x3E640E0
	|-List<HubFastTravel.Location>.set_Item
	|
	|-RVA: 0x3E67310 Offset: 0x3E67411 VA: 0x3E67310
	|-List<HubLensFlare.Flare>.set_Item
	|
	|-RVA: 0x3E6A6F0 Offset: 0x3E6A7F1 VA: 0x3E6A6F0
	|-List<InventoryPoolItemMenuContent.KindBgNameClass>.set_Item
	|
	|-RVA: 0x3E6D600 Offset: 0x3E6D701 VA: 0x3E6D600
	|-List<Map.Pos>.set_Item
	|
	|-RVA: 0x3E70420 Offset: 0x3E70521 VA: 0x3E70420
	|-List<MapImage.BackupTerrain>.set_Item
	|
	|-RVA: 0x3E73300 Offset: 0x3E73401 VA: 0x3E73300
	|-List<MapImageRange.Pos>.set_Item
	|
	|-RVA: 0x3E761E0 Offset: 0x3E762E1 VA: 0x3E761E0
	|-List<MapMind.Target>.set_Item
	|
	|-RVA: 0x3D85DE0 Offset: 0x3D85EE1 VA: 0x3D85DE0
	|-List<MapPanelDebug.Entity>.set_Item
	|
	|-RVA: 0x3D88F70 Offset: 0x3D89071 VA: 0x3D88F70
	|-List<NexRanking.Data>.set_Item
	|
	|-RVA: 0x3D8BD90 Offset: 0x3D8BE91 VA: 0x3D8BD90
	|-List<NexVersus.RatingData>.set_Item
	|
	|-RVA: 0x3D8EC70 Offset: 0x3D8ED71 VA: 0x3D8EC70
	|-List<PackedPlayModeBuildLogs.RuntimeBuildLog>.set_Item
	|
	|-RVA: 0x3D91BE0 Offset: 0x3D91CE1 VA: 0x3D91BE0
	|-List<ParticleSystem.Particle>.set_Item
	|
	|-RVA: 0x3D94F30 Offset: 0x3D95031 VA: 0x3D94F30
	|-List<RangeData.Offset>.set_Item
	|
	|-RVA: 0x3D97D90 Offset: 0x3D97E91 VA: 0x3D97D90
	|-List<RenderGraphDebugData.PassDebugData>.set_Item
	|
	|-RVA: 0x3D9AFD0 Offset: 0x3D9B0D1 VA: 0x3D9AFD0
	|-List<RenderGraphDebugData.ResourceDebugData>.set_Item
	|
	|-RVA: 0x3D9E340 Offset: 0x3D9E441 VA: 0x3D9E340
	|-List<RingCleaningUnitSelectMenu.GodParam>.set_Item
	|
	|-RVA: 0x3DA12C0 Offset: 0x3DA13C1 VA: 0x3DA12C0
	|-List<ShadowUtility.Edge>.set_Item
	|
	|-RVA: 0x3D13AA0 Offset: 0x3D13BA1 VA: 0x3D13AA0
	|-List<SkillArray.Entity>.set_Item
	|
	|-RVA: 0x3D16930 Offset: 0x3D16A31 VA: 0x3D16930
	|-List<TexturePacker_JsonArray.Frame>.set_Item
	|
	|-RVA: 0x3D19EC0 Offset: 0x3D19FC1 VA: 0x3D19EC0
	|-List<TimeNotificationBehaviour.NotificationEntry>.set_Item
	|
	|-RVA: 0x3D1D0F0 Offset: 0x3D1D1F1 VA: 0x3D1D0F0
	|-List<UnitySynchronizationContext.WorkRequest>.set_Item
	|
	|-RVA: 0x3D202C0 Offset: 0x3D203C1 VA: 0x3D202C0
	|-List<XmlSchemaObjectTable.XmlSchemaObjectEntry>.set_Item
	|
	|-RVA: 0x3D231E0 Offset: 0x3D232E1 VA: 0x3D231E0
	|-List<AssetBundleBuildMap.AssetBundleEntry.AssetPathString>.set_Item
	|
	|-RVA: 0x3D26150 Offset: 0x3D26251 VA: 0x3D26150
	|-List<Detail.DataStore.DataStoreChangeMetaParamInt>.set_Item
	|
	|-RVA: 0x3D29520 Offset: 0x3D29621 VA: 0x3D29520
	|-List<Detail.DataStore.DataStoreDeleteParamInt>.set_Item
	|
	|-RVA: 0x3D2C460 Offset: 0x3D2C561 VA: 0x3D2C460
	|-List<Detail.DataStore.DataStoreGetMetaParamInt>.set_Item
	|
	|-RVA: 0x3D2F7F0 Offset: 0x3D2F8F1 VA: 0x3D2F7F0
	|-List<Detail.DataStore.DataStoreMetaInfoInt>.set_Item
	|
	|-RVA: 0x3CF4020 Offset: 0x3CF4121 VA: 0x3CF4020
	|-List<Detail.DataStore.DataStorePasswordInfoInt>.set_Item
	|
	|-RVA: 0x3CF7200 Offset: 0x3CF7301 VA: 0x3CF7200
	|-List<Detail.DataStore.DataStorePersistenceInfoInt>.set_Item
	|
	|-RVA: 0x3CFA3F0 Offset: 0x3CFA4F1 VA: 0x3CFA3F0
	|-List<Detail.DataStore.DataStorePreparePostParamInt>.set_Item
	|
	|-RVA: 0x3CFD750 Offset: 0x3CFD851 VA: 0x3CFD750
	|-List<Detail.DataStore.DataStoreRateObjectParamInt>.set_Item
	|
	|-RVA: 0x3D00670 Offset: 0x3D00771 VA: 0x3D00670
	|-List<Detail.DataStore.DataStoreRatingInitParamInt>.set_Item
	|
	|-RVA: 0x3D03820 Offset: 0x3D03921 VA: 0x3D03820
	|-List<Detail.DataStore.DataStoreRatingTargetInt>.set_Item
	|
	|-RVA: 0x3D06780 Offset: 0x3D06881 VA: 0x3D06780
	|-List<Detail.Ranking.RankingCachedResultInt>.set_Item
	|
	|-RVA: 0x3D09CE0 Offset: 0x3D09DE1 VA: 0x3D09CE0
	|-List<Detail.Ranking.RankingOrderParamInt>.set_Item
	|
	|-RVA: 0x3D0CC30 Offset: 0x3D0CD31 VA: 0x3D0CC30
	|-List<Detail.Ranking.RankingRankDataInt>.set_Item
	|
	|-RVA: 0x3D101E0 Offset: 0x3D102E1 VA: 0x3D101E0
	|-List<Detail.Ranking2.Ranking2ChartInfoInt>.set_Item
	|
	|-RVA: 0x3D66BB0 Offset: 0x3D66CB1 VA: 0x3D66BB0
	|-List<Detail.Ranking2.Ranking2RankDataInt>.set_Item
	|
	|-RVA: 0x3D6A0C0 Offset: 0x3D6A1C1 VA: 0x3D6A0C0
	|-List<Detail.Ranking2.Ranking2ScoreDataInt>.set_Item
	|
	|-RVA: 0x3D6CFE0 Offset: 0x3D6D0E1 VA: 0x3D6CFE0
	|-List<Detail.Screening.ScreeningContextInfoInt>.set_Item
	|
	|-RVA: 0x3D70220 Offset: 0x3D70321 VA: 0x3D70220
	|-List<Detail.Subscriber.SubscriberContentInt>.set_Item
	|
	|-RVA: 0x3D739A0 Offset: 0x3D73AA1 VA: 0x3D739A0
	|-List<Detail.Subscriber.SubscriberGetContentParamInt>.set_Item
	|
	|-RVA: 0x3D76BA0 Offset: 0x3D76CA1 VA: 0x3D76BA0
	|-List<Detail.Subscriber.SubscriberUserStatusInfoInt>.set_Item
	|
	|-RVA: 0x3D79F20 Offset: 0x3D7A021 VA: 0x3D79F20
	|-List<Detail.Subscriber.SubscriberUserStatusParamInt>.set_Item
	|
	|-RVA: 0x3D7D0B0 Offset: 0x3D7D1B1 VA: 0x3D7D0B0
	|-List<Detail.Utility.IntegerSettings>.set_Item
	|
	|-RVA: 0x3D7FED0 Offset: 0x3D7FFD1 VA: 0x3D7FED0
	|-List<Detail.Utility.UniqueIdInfoInt>.set_Item
	|
	|-RVA: 0x3D82DC0 Offset: 0x3D82EC1 VA: 0x3D82DC0
	|-List<MapHistory.Rewind.LatestInspectorData>.set_Item
	|
	|-RVA: 0x305F080 Offset: 0x305F181 VA: 0x305F080
	|-List<MapHistory.Rewind.WorkTerrainData>.set_Item
	|
	|-RVA: 0x3062060 Offset: 0x3062161 VA: 0x3062060
	|-List<MapSkill.AroundCalculator.Result>.set_Item
	|
	|-RVA: 0x3064FE0 Offset: 0x30650E1 VA: 0x3064FE0
	|-List<TargetPositionCache.CacheCurve.Item>.set_Item
	|
	|-RVA: 0x3068360 Offset: 0x3068461 VA: 0x3068360
	|-List<TargetPositionCache.CacheEntry.RecordingItem>.set_Item
	*/

	// RVA: -1 Offset: -1
	private static bool IsCompatibleObject(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3B0AD70 Offset: 0x3B0AE71 VA: 0x3B0AD70
	|-List<IntervalTree.Entry<object>>.IsCompatibleObject
	|
	|-RVA: 0x3B0DF20 Offset: 0x3B0E021 VA: 0x3B0DF20
	|-List<KeyValuePair<DateTime, object>>.IsCompatibleObject
	|
	|-RVA: 0x3B10E40 Offset: 0x3B10F41 VA: 0x3B10E40
	|-List<KeyValuePair<int, object>>.IsCompatibleObject
	|
	|-RVA: 0x3B13DC0 Offset: 0x3B13EC1 VA: 0x3B13DC0
	|-List<KeyValuePair<object, ValueTuple<int, DateTime, object>>>.IsCompatibleObject
	|
	|-RVA: 0x3B16F80 Offset: 0x3B17081 VA: 0x3B16F80
	|-List<KeyValuePair<object, object>>.IsCompatibleObject
	|
	|-RVA: 0x3B19F00 Offset: 0x3B1A001 VA: 0x3B19F00
	|-List<CommonBattleSequence.Reliance<object>>.IsCompatibleObject
	|
	|-RVA: 0x3B1D0B0 Offset: 0x3B1D1B1 VA: 0x3B1D0B0
	|-List<RenderGraphResourcePool.ResourceLogInfo<object>>.IsCompatibleObject
	|
	|-RVA: 0x3B1FFD0 Offset: 0x3B200D1 VA: 0x3B1FFD0
	|-List<ValueTuple<int, object>>.IsCompatibleObject
	|
	|-RVA: 0x3DE0C30 Offset: 0x3DE0D31 VA: 0x3DE0C30
	|-List<ValueTuple<Int32Enum, int>>.IsCompatibleObject
	|
	|-RVA: 0x3DE3AD0 Offset: 0x3DE3BD1 VA: 0x3DE3AD0
	|-List<ValueTuple<object, ValueTuple<object, int>>>.IsCompatibleObject
	|
	|-RVA: 0x3DE6C80 Offset: 0x3DE6D81 VA: 0x3DE6C80
	|-List<ValueTuple<object, int>>.IsCompatibleObject
	|
	|-RVA: 0x3DE9BB0 Offset: 0x3DE9CB1 VA: 0x3DE9BB0
	|-List<ValueTuple<Vector3, float>>.IsCompatibleObject
	|
	|-RVA: 0x3DECBA0 Offset: 0x3DECCA1 VA: 0x3DECBA0
	|-List<ValueTuple<object, Int32Enum, int>>.IsCompatibleObject
	|
	|-RVA: 0x3DEFB20 Offset: 0x3DEFC21 VA: 0x3DEFB20
	|-List<ValueTuple<object, int, int, int>>.IsCompatibleObject
	|
	|-RVA: 0x3DF2CA0 Offset: 0x3DF2DA1 VA: 0x3DF2CA0
	|-List<AnimatorClipInfo>.IsCompatibleObject
	|
	|-RVA: 0x3DF5B40 Offset: 0x3DF5C41 VA: 0x3DF5B40
	|-List<AsyncOperationHandle>.IsCompatibleObject
	|
	|-RVA: 0x3DF8D40 Offset: 0x3DF8E41 VA: 0x3DF8D40
	|-List<BoneWeight>.IsCompatibleObject
	|
	|-RVA: 0x3DFBEC0 Offset: 0x3DFBFC1 VA: 0x3DFBEC0
	|-List<bool>.IsCompatibleObject
	|
	|-RVA: 0x3E79410 Offset: 0x3E79511 VA: 0x3E79410
	|-List<byte>.IsCompatibleObject
	|
	|-RVA: 0x3E7C250 Offset: 0x3E7C351 VA: 0x3E7C250
	|-List<CameraInfo>.IsCompatibleObject
	|
	|-RVA: 0x3E7F140 Offset: 0x3E7F241 VA: 0x3E7F140
	|-List<char>.IsCompatibleObject
	|
	|-RVA: 0x3E81F80 Offset: 0x3E82081 VA: 0x3E81F80
	|-List<Color>.IsCompatibleObject
	|
	|-RVA: 0x3E84F40 Offset: 0x3E85041 VA: 0x3E84F40
	|-List<Color32>.IsCompatibleObject
	|
	|-RVA: 0x3E87D80 Offset: 0x3E87E81 VA: 0x3E87D80
	|-List<ConstraintSource>.IsCompatibleObject
	|
	|-RVA: 0x3E8AD00 Offset: 0x3E8AE01 VA: 0x3E8AD00
	|-List<ContourVertex>.IsCompatibleObject
	|
	|-RVA: 0x3E8DF00 Offset: 0x3E8E001 VA: 0x3E8DF00
	|-List<DataStoreRatingInfo>.IsCompatibleObject
	|
	|-RVA: 0x3E91060 Offset: 0x3E91161 VA: 0x3E91060
	|-List<DataStoreResult>.IsCompatibleObject
	|
	|-RVA: 0x3E93E70 Offset: 0x3E93F71 VA: 0x3E93E70
	|-List<DateTime>.IsCompatibleObject
	|
	|-RVA: 0x3E96CA0 Offset: 0x3E96DA1 VA: 0x3E96CA0
	|-List<DateTimeOffset>.IsCompatibleObject
	|
	|-RVA: 0x3E99B80 Offset: 0x3E99C81 VA: 0x3E99B80
	|-List<Decimal>.IsCompatibleObject
	|
	|-RVA: 0x3E9CB00 Offset: 0x3E9CC01 VA: 0x3E9CB00
	|-List<DiagnosticEvent>.IsCompatibleObject
	|
	|-RVA: 0x3E9FE80 Offset: 0x3E9FF81 VA: 0x3E9FE80
	|-List<double>.IsCompatibleObject
	|
	|-RVA: 0x3EA2D30 Offset: 0x3EA2E31 VA: 0x3EA2D30
	|-List<Friend>.IsCompatibleObject
	|
	|-RVA: 0x3EA6050 Offset: 0x3EA6151 VA: 0x3EA6050
	|-List<GlyphRect>.IsCompatibleObject
	|
	|-RVA: 0x3EA8F10 Offset: 0x3EA9011 VA: 0x3EA8F10
	|-List<short>.IsCompatibleObject
	|
	|-RVA: 0x3EABD10 Offset: 0x3EABE11 VA: 0x3EABD10
	|-List<int>.IsCompatibleObject
	|
	|-RVA: 0x3EAEB10 Offset: 0x3EAEC11 VA: 0x3EAEB10
	|-List<Int32Enum>.IsCompatibleObject
	|
	|-RVA: 0x3EB1910 Offset: 0x3EB1A11 VA: 0x3EB1910
	|-List<long>.IsCompatibleObject
	|
	|-RVA: 0x3DFECE0 Offset: 0x3DFEDE1 VA: 0x3DFECE0
	|-List<IntPtr>.IsCompatibleObject
	|
	|-RVA: 0x3E01B10 Offset: 0x3E01C11 VA: 0x3E01B10
	|-List<InterpretedFrameInfo>.IsCompatibleObject
	|
	|-RVA: 0x3E04A80 Offset: 0x3E04B81 VA: 0x3E04A80
	|-List<IntervalTreeNode>.IsCompatibleObject
	|
	|-RVA: 0x3E07BE0 Offset: 0x3E07CE1 VA: 0x3E07BE0
	|-List<LengthLimitProperties>.IsCompatibleObject
	|
	|-RVA: 0x3E0A9F0 Offset: 0x3E0AAF1 VA: 0x3E0A9F0
	|-List<MapPos>.IsCompatibleObject
	|
	|-RVA: 0x3E0D8D0 Offset: 0x3E0D9D1 VA: 0x3E0D8D0
	|-List<Matrix4x4>.IsCompatibleObject
	|
	|-RVA: 0x3E10D90 Offset: 0x3E10E91 VA: 0x3E10D90
	|-List<object>.IsCompatibleObject
	|
	|-RVA: 0x3E13C00 Offset: 0x3E13D01 VA: 0x3E13C00
	|-List<ObjectInitializationData>.IsCompatibleObject
	|
	|-RVA: 0x3E17010 Offset: 0x3E17111 VA: 0x3E17010
	|-List<PlayableBinding>.IsCompatibleObject
	|
	|-RVA: 0x3E1A260 Offset: 0x3E1A361 VA: 0x3E1A260
	|-List<PlayerLoopSystem>.IsCompatibleObject
	|
	|-RVA: 0x3DA4700 Offset: 0x3DA4801 VA: 0x3DA4700
	|-List<PlayerLoopSystemInternal>.IsCompatibleObject
	|
	|-RVA: 0x3DA7A40 Offset: 0x3DA7B41 VA: 0x3DA7A40
	|-List<RangePositionInfo>.IsCompatibleObject
	|
	|-RVA: 0x3DAA930 Offset: 0x3DAAA31 VA: 0x3DAA930
	|-List<Ranking2ChartInfoInput>.IsCompatibleObject
	|
	|-RVA: 0x3DAD800 Offset: 0x3DAD901 VA: 0x3DAD800
	|-List<RaycastHit2D>.IsCompatibleObject
	|
	|-RVA: 0x3DB0C70 Offset: 0x3DB0D71 VA: 0x3DB0C70
	|-List<RaycastResult>.IsCompatibleObject
	|
	|-RVA: 0x3DB43B0 Offset: 0x3DB44B1 VA: 0x3DB43B0
	|-List<Rect>.IsCompatibleObject
	|
	|-RVA: 0x3DB7370 Offset: 0x3DB7471 VA: 0x3DB7370
	|-List<RendererListHandle>.IsCompatibleObject
	|
	|-RVA: 0x3DBA180 Offset: 0x3DBA281 VA: 0x3DBA180
	|-List<ResourceHandle>.IsCompatibleObject
	|
	|-RVA: 0x3DBCF90 Offset: 0x3DBD091 VA: 0x3DBCF90
	|-List<sbyte>.IsCompatibleObject
	|
	|-RVA: 0x3DBFDA0 Offset: 0x3DBFEA1 VA: 0x3DBFDA0
	|-List<ShaderTagId>.IsCompatibleObject
	|
	|-RVA: 0x3E3BA00 Offset: 0x3E3BB01 VA: 0x3E3BA00
	|-List<float>.IsCompatibleObject
	|
	|-RVA: 0x3E3E9A0 Offset: 0x3E3EAA1 VA: 0x3E3E9A0
	|-List<SphericalHarmonicsL2>.IsCompatibleObject
	|
	|-RVA: 0x3E425B0 Offset: 0x3E426B1 VA: 0x3E425B0
	|-List<SubMeshDescriptor>.IsCompatibleObject
	|
	|-RVA: 0x3E45920 Offset: 0x3E45A21 VA: 0x3E45920
	|-List<TablePair>.IsCompatibleObject
	|
	|-RVA: 0x3E48810 Offset: 0x3E48911 VA: 0x3E48810
	|-List<TimeSpan>.IsCompatibleObject
	|
	|-RVA: 0x3E4B650 Offset: 0x3E4B751 VA: 0x3E4B650
	|-List<UICharInfo>.IsCompatibleObject
	|
	|-RVA: 0x3E4E620 Offset: 0x3E4E721 VA: 0x3E4E620
	|-List<UILineInfo>.IsCompatibleObject
	|
	|-RVA: 0x3E51660 Offset: 0x3E51761 VA: 0x3E51660
	|-List<UIVertex>.IsCompatibleObject
	|
	|-RVA: 0x3E551C0 Offset: 0x3E552C1 VA: 0x3E551C0
	|-List<ushort>.IsCompatibleObject
	|
	|-RVA: 0x3E57FC0 Offset: 0x3E580C1 VA: 0x3E57FC0
	|-List<uint>.IsCompatibleObject
	|
	|-RVA: 0x3DC2BB0 Offset: 0x3DC2CB1 VA: 0x3DC2BB0
	|-List<ulong>.IsCompatibleObject
	|
	|-RVA: 0x3DC59C0 Offset: 0x3DC5AC1 VA: 0x3DC59C0
	|-List<Vector2>.IsCompatibleObject
	|
	|-RVA: 0x3DC88B0 Offset: 0x3DC89B1 VA: 0x3DC88B0
	|-List<Vector3>.IsCompatibleObject
	|
	|-RVA: 0x3DCB8A0 Offset: 0x3DCB9A1 VA: 0x3DCB8A0
	|-List<Vector4>.IsCompatibleObject
	|
	|-RVA: 0x3DCE880 Offset: 0x3DCE981 VA: 0x3DCE880
	|-List<VertexAttributeDescriptor>.IsCompatibleObject
	|
	|-RVA: 0x3DD1770 Offset: 0x3DD1871 VA: 0x3DD1770
	|-List<X509ChainStatus>.IsCompatibleObject
	|
	|-RVA: 0x3DD4700 Offset: 0x3DD4801 VA: 0x3DD4700
	|-List<XRView>.IsCompatibleObject
	|
	|-RVA: 0x3DD7A80 Offset: 0x3DD7B81 VA: 0x3DD7A80
	|-List<AmiiboSequence.GainItemData>.IsCompatibleObject
	|
	|-RVA: 0x3DDAA20 Offset: 0x3DDAB21 VA: 0x3DDAA20
	|-List<AnimationOutputWeightProcessor.WeightInfo>.IsCompatibleObject
	|
	|-RVA: 0x3DDDD40 Offset: 0x3DDDE41 VA: 0x3DDDD40
	|-List<ArenaOrderSequence.GodInfo>.IsCompatibleObject
	|
	|-RVA: 0x3E1D5A0 Offset: 0x3E1D6A1 VA: 0x3E1D5A0
	|-List<BattleInfo.SupportData>.IsCompatibleObject
	|
	|-RVA: 0x3E204C0 Offset: 0x3E205C1 VA: 0x3E204C0
	|-List<BeforeRenderHelper.OrderBlock>.IsCompatibleObject
	|
	|-RVA: 0x3E23440 Offset: 0x3E23541 VA: 0x3E23440
	|-List<Camera.RenderRequest>.IsCompatibleObject
	|
	|-RVA: 0x3E26610 Offset: 0x3E26711 VA: 0x3E26610
	|-List<CameraState.CustomBlendable>.IsCompatibleObject
	|
	|-RVA: 0x3E29500 Offset: 0x3E29601 VA: 0x3E29500
	|-List<CinemachineClearShot.Pair>.IsCompatibleObject
	|
	|-RVA: 0x3E2C310 Offset: 0x3E2C411 VA: 0x3E2C310
	|-List<CinemachineStateDrivenCamera.HashPair>.IsCompatibleObject
	|
	|-RVA: 0x3E2F1B0 Offset: 0x3E2F2B1 VA: 0x3E2F1B0
	|-List<DelayedActionManager.DelegateInfo>.IsCompatibleObject
	|
	|-RVA: 0x3E323F0 Offset: 0x3E324F1 VA: 0x3E323F0
	|-List<Detail.AsyncResultInt>.IsCompatibleObject
	|
	|-RVA: 0x3E35750 Offset: 0x3E35851 VA: 0x3E35750
	|-List<Detail.CppArray>.IsCompatibleObject
	|
	|-RVA: 0x3E386C0 Offset: 0x3E387C1 VA: 0x3E386C0
	|-List<Detail.NotificationEventInt>.IsCompatibleObject
	|
	|-RVA: 0x3E5ADF0 Offset: 0x3E5AEF1 VA: 0x3E5ADF0
	|-List<DragonRideTargetGroup.ChainParam>.IsCompatibleObject
	|
	|-RVA: 0x3E5DD70 Offset: 0x3E5DE71 VA: 0x3E5DD70
	|-List<GmapPathAdjuster.TargetModel>.IsCompatibleObject
	|
	|-RVA: 0x3E60F80 Offset: 0x3E61081 VA: 0x3E60F80
	|-List<GmapSpotAdjuster.TargetModel>.IsCompatibleObject
	|
	|-RVA: 0x3E64190 Offset: 0x3E64291 VA: 0x3E64190
	|-List<HubFastTravel.Location>.IsCompatibleObject
	|
	|-RVA: 0x3E673D0 Offset: 0x3E674D1 VA: 0x3E673D0
	|-List<HubLensFlare.Flare>.IsCompatibleObject
	|
	|-RVA: 0x3E6A780 Offset: 0x3E6A881 VA: 0x3E6A780
	|-List<InventoryPoolItemMenuContent.KindBgNameClass>.IsCompatibleObject
	|
	|-RVA: 0x3E6D670 Offset: 0x3E6D771 VA: 0x3E6D670
	|-List<Map.Pos>.IsCompatibleObject
	|
	|-RVA: 0x3E704A0 Offset: 0x3E705A1 VA: 0x3E704A0
	|-List<MapImage.BackupTerrain>.IsCompatibleObject
	|
	|-RVA: 0x3E73370 Offset: 0x3E73471 VA: 0x3E73370
	|-List<MapImageRange.Pos>.IsCompatibleObject
	|
	|-RVA: 0x3E76290 Offset: 0x3E76391 VA: 0x3E76290
	|-List<MapMind.Target>.IsCompatibleObject
	|
	|-RVA: 0x3D85E80 Offset: 0x3D85F81 VA: 0x3D85E80
	|-List<MapPanelDebug.Entity>.IsCompatibleObject
	|
	|-RVA: 0x3D88FE0 Offset: 0x3D890E1 VA: 0x3D88FE0
	|-List<NexRanking.Data>.IsCompatibleObject
	|
	|-RVA: 0x3D8BE10 Offset: 0x3D8BF11 VA: 0x3D8BE10
	|-List<NexVersus.RatingData>.IsCompatibleObject
	|
	|-RVA: 0x3D8ED00 Offset: 0x3D8EE01 VA: 0x3D8ED00
	|-List<PackedPlayModeBuildLogs.RuntimeBuildLog>.IsCompatibleObject
	|
	|-RVA: 0x3D91C80 Offset: 0x3D91D81 VA: 0x3D91C80
	|-List<ParticleSystem.Particle>.IsCompatibleObject
	|
	|-RVA: 0x3D94FA0 Offset: 0x3D950A1 VA: 0x3D94FA0
	|-List<RangeData.Offset>.IsCompatibleObject
	|
	|-RVA: 0x3D97E40 Offset: 0x3D97F41 VA: 0x3D97E40
	|-List<RenderGraphDebugData.PassDebugData>.IsCompatibleObject
	|
	|-RVA: 0x3D9B090 Offset: 0x3D9B191 VA: 0x3D9B090
	|-List<RenderGraphDebugData.ResourceDebugData>.IsCompatibleObject
	|
	|-RVA: 0x3D9E3D0 Offset: 0x3D9E4D1 VA: 0x3D9E3D0
	|-List<RingCleaningUnitSelectMenu.GodParam>.IsCompatibleObject
	|
	|-RVA: 0x3DA1370 Offset: 0x3DA1471 VA: 0x3DA1370
	|-List<ShadowUtility.Edge>.IsCompatibleObject
	|
	|-RVA: 0x3D13B10 Offset: 0x3D13C11 VA: 0x3D13B10
	|-List<SkillArray.Entity>.IsCompatibleObject
	|
	|-RVA: 0x3D16A00 Offset: 0x3D16B01 VA: 0x3D16A00
	|-List<TexturePacker_JsonArray.Frame>.IsCompatibleObject
	|
	|-RVA: 0x3D19F70 Offset: 0x3D1A071 VA: 0x3D19F70
	|-List<TimeNotificationBehaviour.NotificationEntry>.IsCompatibleObject
	|
	|-RVA: 0x3D1D1A0 Offset: 0x3D1D2A1 VA: 0x3D1D1A0
	|-List<UnitySynchronizationContext.WorkRequest>.IsCompatibleObject
	|
	|-RVA: 0x3D20350 Offset: 0x3D20451 VA: 0x3D20350
	|-List<XmlSchemaObjectTable.XmlSchemaObjectEntry>.IsCompatibleObject
	|
	|-RVA: 0x3D23270 Offset: 0x3D23371 VA: 0x3D23270
	|-List<AssetBundleBuildMap.AssetBundleEntry.AssetPathString>.IsCompatibleObject
	|
	|-RVA: 0x3D261F0 Offset: 0x3D262F1 VA: 0x3D261F0
	|-List<Detail.DataStore.DataStoreChangeMetaParamInt>.IsCompatibleObject
	|
	|-RVA: 0x3D295A0 Offset: 0x3D296A1 VA: 0x3D295A0
	|-List<Detail.DataStore.DataStoreDeleteParamInt>.IsCompatibleObject
	|
	|-RVA: 0x3D2C510 Offset: 0x3D2C611 VA: 0x3D2C510
	|-List<Detail.DataStore.DataStoreGetMetaParamInt>.IsCompatibleObject
	|
	|-RVA: 0x3D2F890 Offset: 0x3D2F991 VA: 0x3D2F890
	|-List<Detail.DataStore.DataStoreMetaInfoInt>.IsCompatibleObject
	|
	|-RVA: 0x3CF40C0 Offset: 0x3CF41C1 VA: 0x3CF40C0
	|-List<Detail.DataStore.DataStorePasswordInfoInt>.IsCompatibleObject
	|
	|-RVA: 0x3CF72A0 Offset: 0x3CF73A1 VA: 0x3CF72A0
	|-List<Detail.DataStore.DataStorePersistenceInfoInt>.IsCompatibleObject
	|
	|-RVA: 0x3CFA490 Offset: 0x3CFA591 VA: 0x3CFA490
	|-List<Detail.DataStore.DataStorePreparePostParamInt>.IsCompatibleObject
	|
	|-RVA: 0x3CFD7D0 Offset: 0x3CFD8D1 VA: 0x3CFD7D0
	|-List<Detail.DataStore.DataStoreRateObjectParamInt>.IsCompatibleObject
	|
	|-RVA: 0x3D00710 Offset: 0x3D00811 VA: 0x3D00710
	|-List<Detail.DataStore.DataStoreRatingInitParamInt>.IsCompatibleObject
	|
	|-RVA: 0x3D038A0 Offset: 0x3D039A1 VA: 0x3D038A0
	|-List<Detail.DataStore.DataStoreRatingTargetInt>.IsCompatibleObject
	|
	|-RVA: 0x3D06840 Offset: 0x3D06941 VA: 0x3D06840
	|-List<Detail.Ranking.RankingCachedResultInt>.IsCompatibleObject
	|
	|-RVA: 0x3D09D60 Offset: 0x3D09E61 VA: 0x3D09D60
	|-List<Detail.Ranking.RankingOrderParamInt>.IsCompatibleObject
	|
	|-RVA: 0x3D0CCF0 Offset: 0x3D0CDF1 VA: 0x3D0CCF0
	|-List<Detail.Ranking.RankingRankDataInt>.IsCompatibleObject
	|
	|-RVA: 0x3D102C0 Offset: 0x3D103C1 VA: 0x3D102C0
	|-List<Detail.Ranking2.Ranking2ChartInfoInt>.IsCompatibleObject
	|
	|-RVA: 0x3D66C70 Offset: 0x3D66D71 VA: 0x3D66C70
	|-List<Detail.Ranking2.Ranking2RankDataInt>.IsCompatibleObject
	|
	|-RVA: 0x3D6A140 Offset: 0x3D6A241 VA: 0x3D6A140
	|-List<Detail.Ranking2.Ranking2ScoreDataInt>.IsCompatibleObject
	|
	|-RVA: 0x3D6D080 Offset: 0x3D6D181 VA: 0x3D6D080
	|-List<Detail.Screening.ScreeningContextInfoInt>.IsCompatibleObject
	|
	|-RVA: 0x3D702F0 Offset: 0x3D703F1 VA: 0x3D702F0
	|-List<Detail.Subscriber.SubscriberContentInt>.IsCompatibleObject
	|
	|-RVA: 0x3D73A40 Offset: 0x3D73B41 VA: 0x3D73A40
	|-List<Detail.Subscriber.SubscriberGetContentParamInt>.IsCompatibleObject
	|
	|-RVA: 0x3D76C50 Offset: 0x3D76D51 VA: 0x3D76C50
	|-List<Detail.Subscriber.SubscriberUserStatusInfoInt>.IsCompatibleObject
	|
	|-RVA: 0x3D79FC0 Offset: 0x3D7A0C1 VA: 0x3D79FC0
	|-List<Detail.Subscriber.SubscriberUserStatusParamInt>.IsCompatibleObject
	|
	|-RVA: 0x3D7D120 Offset: 0x3D7D221 VA: 0x3D7D120
	|-List<Detail.Utility.IntegerSettings>.IsCompatibleObject
	|
	|-RVA: 0x3D7FF50 Offset: 0x3D80051 VA: 0x3D7FF50
	|-List<Detail.Utility.UniqueIdInfoInt>.IsCompatibleObject
	|
	|-RVA: 0x3D82E40 Offset: 0x3D82F41 VA: 0x3D82E40
	|-List<MapHistory.Rewind.LatestInspectorData>.IsCompatibleObject
	|
	|-RVA: 0x305F100 Offset: 0x305F201 VA: 0x305F100
	|-List<MapHistory.Rewind.WorkTerrainData>.IsCompatibleObject
	|
	|-RVA: 0x30620F0 Offset: 0x30621F1 VA: 0x30620F0
	|-List<MapSkill.AroundCalculator.Result>.IsCompatibleObject
	|
	|-RVA: 0x3065090 Offset: 0x3065191 VA: 0x3065090
	|-List<TargetPositionCache.CacheCurve.Item>.IsCompatibleObject
	|
	|-RVA: 0x3068420 Offset: 0x3068521 VA: 0x3068420
	|-List<TargetPositionCache.CacheEntry.RecordingItem>.IsCompatibleObject
	*/

	// RVA: -1 Offset: -1 Slot: 18
	private object System.Collections.IList.get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3B0AE60 Offset: 0x3B0AF61 VA: 0x3B0AE60
	|-List<IntervalTree.Entry<object>>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3B0E010 Offset: 0x3B0E111 VA: 0x3B0E010
	|-List<KeyValuePair<DateTime, object>>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3B10F30 Offset: 0x3B11031 VA: 0x3B10F30
	|-List<KeyValuePair<int, object>>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3B13EB0 Offset: 0x3B13FB1 VA: 0x3B13EB0
	|-List<KeyValuePair<object, ValueTuple<int, DateTime, object>>>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3B17070 Offset: 0x3B17171 VA: 0x3B17070
	|-List<KeyValuePair<object, object>>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3B19FF0 Offset: 0x3B1A0F1 VA: 0x3B19FF0
	|-List<CommonBattleSequence.Reliance<object>>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3B1D1A0 Offset: 0x3B1D2A1 VA: 0x3B1D1A0
	|-List<RenderGraphResourcePool.ResourceLogInfo<object>>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3B200C0 Offset: 0x3B201C1 VA: 0x3B200C0
	|-List<ValueTuple<int, object>>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3DE0D30 Offset: 0x3DE0E31 VA: 0x3DE0D30
	|-List<ValueTuple<Int32Enum, int>>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3DE3BC0 Offset: 0x3DE3CC1 VA: 0x3DE3BC0
	|-List<ValueTuple<object, ValueTuple<object, int>>>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3DE6D70 Offset: 0x3DE6E71 VA: 0x3DE6D70
	|-List<ValueTuple<object, int>>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3DE9CA0 Offset: 0x3DE9DA1 VA: 0x3DE9CA0
	|-List<ValueTuple<Vector3, float>>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3DECC90 Offset: 0x3DECD91 VA: 0x3DECC90
	|-List<ValueTuple<object, Int32Enum, int>>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3DEFC10 Offset: 0x3DEFD11 VA: 0x3DEFC10
	|-List<ValueTuple<object, int, int, int>>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3DF2DA0 Offset: 0x3DF2EA1 VA: 0x3DF2DA0
	|-List<AnimatorClipInfo>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3DF5C30 Offset: 0x3DF5D31 VA: 0x3DF5C30
	|-List<AsyncOperationHandle>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3DF8E30 Offset: 0x3DF8F31 VA: 0x3DF8E30
	|-List<BoneWeight>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3DFBFC0 Offset: 0x3DFC0C1 VA: 0x3DFBFC0
	|-List<bool>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3E79510 Offset: 0x3E79611 VA: 0x3E79510
	|-List<byte>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3E10E20 Offset: 0x3E10F21 VA: 0x3E10E20
	|-List<Camera>.System.Collections.IList.get_Item
	|-List<Decorator>.System.Collections.IList.get_Item
	|-List<DynValue>.System.Collections.IList.get_Item
	|-List<GameObject>.System.Collections.IList.get_Item
	|-List<MapBackup>.System.Collections.IList.get_Item
	|-List<object>.System.Collections.IList.get_Item
	|-List<Phase>.System.Collections.IList.get_Item
	|-List<ProfileCard>.System.Collections.IList.get_Item
	|-List<Unit>.System.Collections.IList.get_Item
	|-List<AssetTable.Accessory>.System.Collections.IList.get_Item
	|-List<GameSaveDataHeaderReader.Handle>.System.Collections.IList.get_Item
	|-List<MapDispos.ActualData>.System.Collections.IList.get_Item
	|-List<MapDispos.Pos>.System.Collections.IList.get_Item
	|-List<MapLayer.Data>.System.Collections.IList.get_Item
	|-List<MapObject.RigidInfo>.System.Collections.IList.get_Item
	|-List<RingListSequence.PageData>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3E7C340 Offset: 0x3E7C441 VA: 0x3E7C340
	|-List<CameraInfo>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3E7F240 Offset: 0x3E7F341 VA: 0x3E7F240
	|-List<char>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3E82070 Offset: 0x3E82171 VA: 0x3E82070
	|-List<Color>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3E85040 Offset: 0x3E85141 VA: 0x3E85040
	|-List<Color32>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3E87E70 Offset: 0x3E87F71 VA: 0x3E87E70
	|-List<ConstraintSource>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3E8ADF0 Offset: 0x3E8AEF1 VA: 0x3E8ADF0
	|-List<ContourVertex>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3E8DFF0 Offset: 0x3E8E0F1 VA: 0x3E8DFF0
	|-List<DataStoreRatingInfo>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3E91160 Offset: 0x3E91261 VA: 0x3E91160
	|-List<DataStoreResult>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3E93F70 Offset: 0x3E94071 VA: 0x3E93F70
	|-List<DateTime>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3E96D90 Offset: 0x3E96E91 VA: 0x3E96D90
	|-List<DateTimeOffset>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3E99C70 Offset: 0x3E99D71 VA: 0x3E99C70
	|-List<Decimal>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3E9CBF0 Offset: 0x3E9CCF1 VA: 0x3E9CBF0
	|-List<DiagnosticEvent>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3E9FF80 Offset: 0x3EA0081 VA: 0x3E9FF80
	|-List<double>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3EA2E20 Offset: 0x3EA2F21 VA: 0x3EA2E20
	|-List<Friend>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3EA6140 Offset: 0x3EA6241 VA: 0x3EA6140
	|-List<GlyphRect>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3EA9010 Offset: 0x3EA9111 VA: 0x3EA9010
	|-List<short>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3EABE10 Offset: 0x3EABF11 VA: 0x3EABE10
	|-List<int>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3EAEC10 Offset: 0x3EAED11 VA: 0x3EAEC10
	|-List<Int32Enum>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3EB1A10 Offset: 0x3EB1B11 VA: 0x3EB1A10
	|-List<long>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3DFEDE0 Offset: 0x3DFEEE1 VA: 0x3DFEDE0
	|-List<IntPtr>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3E01C00 Offset: 0x3E01D01 VA: 0x3E01C00
	|-List<InterpretedFrameInfo>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3E04B70 Offset: 0x3E04C71 VA: 0x3E04B70
	|-List<IntervalTreeNode>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3E07CE0 Offset: 0x3E07DE1 VA: 0x3E07CE0
	|-List<LengthLimitProperties>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3E0AAF0 Offset: 0x3E0ABF1 VA: 0x3E0AAF0
	|-List<MapPos>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3E0D9C0 Offset: 0x3E0DAC1 VA: 0x3E0D9C0
	|-List<Matrix4x4>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3E13CF0 Offset: 0x3E13DF1 VA: 0x3E13CF0
	|-List<ObjectInitializationData>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3E17100 Offset: 0x3E17201 VA: 0x3E17100
	|-List<PlayableBinding>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3E1A350 Offset: 0x3E1A451 VA: 0x3E1A350
	|-List<PlayerLoopSystem>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3DA47F0 Offset: 0x3DA48F1 VA: 0x3DA47F0
	|-List<PlayerLoopSystemInternal>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3DA7B30 Offset: 0x3DA7C31 VA: 0x3DA7B30
	|-List<RangePositionInfo>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3DAAA30 Offset: 0x3DAAB31 VA: 0x3DAAA30
	|-List<Ranking2ChartInfoInput>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3DAD8F0 Offset: 0x3DAD9F1 VA: 0x3DAD8F0
	|-List<RaycastHit2D>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3DB0D70 Offset: 0x3DB0E71 VA: 0x3DB0D70
	|-List<RaycastResult>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3DB44A0 Offset: 0x3DB45A1 VA: 0x3DB44A0
	|-List<Rect>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3DB7470 Offset: 0x3DB7571 VA: 0x3DB7470
	|-List<RendererListHandle>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3DBA280 Offset: 0x3DBA381 VA: 0x3DBA280
	|-List<ResourceHandle>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3DBD090 Offset: 0x3DBD191 VA: 0x3DBD090
	|-List<sbyte>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3DBFEA0 Offset: 0x3DBFFA1 VA: 0x3DBFEA0
	|-List<ShaderTagId>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3E3BB00 Offset: 0x3E3BC01 VA: 0x3E3BB00
	|-List<float>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3E3EAA0 Offset: 0x3E3EBA1 VA: 0x3E3EAA0
	|-List<SphericalHarmonicsL2>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3E426A0 Offset: 0x3E427A1 VA: 0x3E426A0
	|-List<SubMeshDescriptor>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3E45A10 Offset: 0x3E45B11 VA: 0x3E45A10
	|-List<TablePair>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3E48910 Offset: 0x3E48A11 VA: 0x3E48910
	|-List<TimeSpan>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3E4B740 Offset: 0x3E4B841 VA: 0x3E4B740
	|-List<UICharInfo>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3E4E710 Offset: 0x3E4E811 VA: 0x3E4E710
	|-List<UILineInfo>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3E51760 Offset: 0x3E51861 VA: 0x3E51760
	|-List<UIVertex>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3E552C0 Offset: 0x3E553C1 VA: 0x3E552C0
	|-List<ushort>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3E580C0 Offset: 0x3E581C1 VA: 0x3E580C0
	|-List<uint>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3DC2CB0 Offset: 0x3DC2DB1 VA: 0x3DC2CB0
	|-List<ulong>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3DC5AC0 Offset: 0x3DC5BC1 VA: 0x3DC5AC0
	|-List<Vector2>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3DC89A0 Offset: 0x3DC8AA1 VA: 0x3DC89A0
	|-List<Vector3>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3DCB990 Offset: 0x3DCBA91 VA: 0x3DCB990
	|-List<Vector4>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3DCE970 Offset: 0x3DCEA71 VA: 0x3DCE970
	|-List<VertexAttributeDescriptor>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3DD1860 Offset: 0x3DD1961 VA: 0x3DD1860
	|-List<X509ChainStatus>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3DD4810 Offset: 0x3DD4911 VA: 0x3DD4810
	|-List<XRView>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3DD7B70 Offset: 0x3DD7C71 VA: 0x3DD7B70
	|-List<AmiiboSequence.GainItemData>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3DDAB10 Offset: 0x3DDAC11 VA: 0x3DDAB10
	|-List<AnimationOutputWeightProcessor.WeightInfo>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3DDDE30 Offset: 0x3DDDF31 VA: 0x3DDDE30
	|-List<ArenaOrderSequence.GodInfo>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3E1D690 Offset: 0x3E1D791 VA: 0x3E1D690
	|-List<BattleInfo.SupportData>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3E205B0 Offset: 0x3E206B1 VA: 0x3E205B0
	|-List<BeforeRenderHelper.OrderBlock>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3E23530 Offset: 0x3E23631 VA: 0x3E23530
	|-List<Camera.RenderRequest>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3E26700 Offset: 0x3E26801 VA: 0x3E26700
	|-List<CameraState.CustomBlendable>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3E29600 Offset: 0x3E29701 VA: 0x3E29600
	|-List<CinemachineClearShot.Pair>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3E2C410 Offset: 0x3E2C511 VA: 0x3E2C410
	|-List<CinemachineStateDrivenCamera.HashPair>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3E2F2A0 Offset: 0x3E2F3A1 VA: 0x3E2F2A0
	|-List<DelayedActionManager.DelegateInfo>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3E324E0 Offset: 0x3E325E1 VA: 0x3E324E0
	|-List<Detail.AsyncResultInt>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3E35840 Offset: 0x3E35941 VA: 0x3E35840
	|-List<Detail.CppArray>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3E387B0 Offset: 0x3E388B1 VA: 0x3E387B0
	|-List<Detail.NotificationEventInt>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3E5AEE0 Offset: 0x3E5AFE1 VA: 0x3E5AEE0
	|-List<DragonRideTargetGroup.ChainParam>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3E5DE60 Offset: 0x3E5DF61 VA: 0x3E5DE60
	|-List<GmapPathAdjuster.TargetModel>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3E61070 Offset: 0x3E61171 VA: 0x3E61070
	|-List<GmapSpotAdjuster.TargetModel>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3E64280 Offset: 0x3E64381 VA: 0x3E64280
	|-List<HubFastTravel.Location>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3E674C0 Offset: 0x3E675C1 VA: 0x3E674C0
	|-List<HubLensFlare.Flare>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3E6A870 Offset: 0x3E6A971 VA: 0x3E6A870
	|-List<InventoryPoolItemMenuContent.KindBgNameClass>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3E6D770 Offset: 0x3E6D871 VA: 0x3E6D770
	|-List<Map.Pos>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3E70590 Offset: 0x3E70691 VA: 0x3E70590
	|-List<MapImage.BackupTerrain>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3E73470 Offset: 0x3E73571 VA: 0x3E73470
	|-List<MapImageRange.Pos>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3E76380 Offset: 0x3E76481 VA: 0x3E76380
	|-List<MapMind.Target>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3D85F70 Offset: 0x3D86071 VA: 0x3D85F70
	|-List<MapPanelDebug.Entity>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3D890E0 Offset: 0x3D891E1 VA: 0x3D890E0
	|-List<NexRanking.Data>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3D8BF00 Offset: 0x3D8C001 VA: 0x3D8BF00
	|-List<NexVersus.RatingData>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3D8EDF0 Offset: 0x3D8EEF1 VA: 0x3D8EDF0
	|-List<PackedPlayModeBuildLogs.RuntimeBuildLog>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3D91D90 Offset: 0x3D91E91 VA: 0x3D91D90
	|-List<ParticleSystem.Particle>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3D950A0 Offset: 0x3D951A1 VA: 0x3D950A0
	|-List<RangeData.Offset>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3D97F30 Offset: 0x3D98031 VA: 0x3D97F30
	|-List<RenderGraphDebugData.PassDebugData>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3D9B180 Offset: 0x3D9B281 VA: 0x3D9B180
	|-List<RenderGraphDebugData.ResourceDebugData>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3D9E4C0 Offset: 0x3D9E5C1 VA: 0x3D9E4C0
	|-List<RingCleaningUnitSelectMenu.GodParam>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3DA1460 Offset: 0x3DA1561 VA: 0x3DA1460
	|-List<ShadowUtility.Edge>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3D13C10 Offset: 0x3D13D11 VA: 0x3D13C10
	|-List<SkillArray.Entity>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3D16AF0 Offset: 0x3D16BF1 VA: 0x3D16AF0
	|-List<TexturePacker_JsonArray.Frame>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3D1A060 Offset: 0x3D1A161 VA: 0x3D1A060
	|-List<TimeNotificationBehaviour.NotificationEntry>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3D1D290 Offset: 0x3D1D391 VA: 0x3D1D290
	|-List<UnitySynchronizationContext.WorkRequest>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3D20440 Offset: 0x3D20541 VA: 0x3D20440
	|-List<XmlSchemaObjectTable.XmlSchemaObjectEntry>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3D23360 Offset: 0x3D23461 VA: 0x3D23360
	|-List<AssetBundleBuildMap.AssetBundleEntry.AssetPathString>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3D26310 Offset: 0x3D26411 VA: 0x3D26310
	|-List<Detail.DataStore.DataStoreChangeMetaParamInt>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3D29690 Offset: 0x3D29791 VA: 0x3D29690
	|-List<Detail.DataStore.DataStoreDeleteParamInt>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3D2C600 Offset: 0x3D2C701 VA: 0x3D2C600
	|-List<Detail.DataStore.DataStoreGetMetaParamInt>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3D2F9A0 Offset: 0x3D2FAA1 VA: 0x3D2F9A0
	|-List<Detail.DataStore.DataStoreMetaInfoInt>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3CF41B0 Offset: 0x3CF42B1 VA: 0x3CF41B0
	|-List<Detail.DataStore.DataStorePasswordInfoInt>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3CF7390 Offset: 0x3CF7491 VA: 0x3CF7390
	|-List<Detail.DataStore.DataStorePersistenceInfoInt>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3CFA5A0 Offset: 0x3CFA6A1 VA: 0x3CFA5A0
	|-List<Detail.DataStore.DataStorePreparePostParamInt>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3CFD8C0 Offset: 0x3CFD9C1 VA: 0x3CFD8C0
	|-List<Detail.DataStore.DataStoreRateObjectParamInt>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3D00800 Offset: 0x3D00901 VA: 0x3D00800
	|-List<Detail.DataStore.DataStoreRatingInitParamInt>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3D03990 Offset: 0x3D03A91 VA: 0x3D03990
	|-List<Detail.DataStore.DataStoreRatingTargetInt>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3D06930 Offset: 0x3D06A31 VA: 0x3D06930
	|-List<Detail.Ranking.RankingCachedResultInt>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3D09E50 Offset: 0x3D09F51 VA: 0x3D09E50
	|-List<Detail.Ranking.RankingOrderParamInt>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3D0CDE0 Offset: 0x3D0CEE1 VA: 0x3D0CDE0
	|-List<Detail.Ranking.RankingRankDataInt>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3D103C0 Offset: 0x3D104C1 VA: 0x3D103C0
	|-List<Detail.Ranking2.Ranking2ChartInfoInt>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3D66D60 Offset: 0x3D66E61 VA: 0x3D66D60
	|-List<Detail.Ranking2.Ranking2RankDataInt>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3D6A230 Offset: 0x3D6A331 VA: 0x3D6A230
	|-List<Detail.Ranking2.Ranking2ScoreDataInt>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3D6D170 Offset: 0x3D6D271 VA: 0x3D6D170
	|-List<Detail.Screening.ScreeningContextInfoInt>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3D703F0 Offset: 0x3D704F1 VA: 0x3D703F0
	|-List<Detail.Subscriber.SubscriberContentInt>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3D73B30 Offset: 0x3D73C31 VA: 0x3D73B30
	|-List<Detail.Subscriber.SubscriberGetContentParamInt>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3D76D40 Offset: 0x3D76E41 VA: 0x3D76D40
	|-List<Detail.Subscriber.SubscriberUserStatusInfoInt>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3D7A0B0 Offset: 0x3D7A1B1 VA: 0x3D7A0B0
	|-List<Detail.Subscriber.SubscriberUserStatusParamInt>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3D7D220 Offset: 0x3D7D321 VA: 0x3D7D220
	|-List<Detail.Utility.IntegerSettings>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3D80040 Offset: 0x3D80141 VA: 0x3D80040
	|-List<Detail.Utility.UniqueIdInfoInt>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3D82F40 Offset: 0x3D83041 VA: 0x3D82F40
	|-List<MapHistory.Rewind.LatestInspectorData>.System.Collections.IList.get_Item
	|
	|-RVA: 0x305F200 Offset: 0x305F301 VA: 0x305F200
	|-List<MapHistory.Rewind.WorkTerrainData>.System.Collections.IList.get_Item
	|
	|-RVA: 0x30621E0 Offset: 0x30622E1 VA: 0x30621E0
	|-List<MapSkill.AroundCalculator.Result>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3065180 Offset: 0x3065281 VA: 0x3065180
	|-List<TargetPositionCache.CacheCurve.Item>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3068510 Offset: 0x3068611 VA: 0x3068510
	|-List<TargetPositionCache.CacheEntry.RecordingItem>.System.Collections.IList.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 19
	private void System.Collections.IList.set_Item(int index, object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3B0AEE0 Offset: 0x3B0AFE1 VA: 0x3B0AEE0
	|-List<IntervalTree.Entry<object>>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3B0E080 Offset: 0x3B0E181 VA: 0x3B0E080
	|-List<KeyValuePair<DateTime, object>>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3B10FA0 Offset: 0x3B110A1 VA: 0x3B10FA0
	|-List<KeyValuePair<int, object>>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3B13F30 Offset: 0x3B14031 VA: 0x3B13F30
	|-List<KeyValuePair<object, ValueTuple<int, DateTime, object>>>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3B170E0 Offset: 0x3B171E1 VA: 0x3B170E0
	|-List<KeyValuePair<object, object>>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3B1A070 Offset: 0x3B1A171 VA: 0x3B1A070
	|-List<CommonBattleSequence.Reliance<object>>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3B1D210 Offset: 0x3B1D311 VA: 0x3B1D210
	|-List<RenderGraphResourcePool.ResourceLogInfo<object>>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3B20130 Offset: 0x3B20231 VA: 0x3B20130
	|-List<ValueTuple<int, object>>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3DE0D90 Offset: 0x3DE0E91 VA: 0x3DE0D90
	|-List<ValueTuple<Int32Enum, int>>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3DE3C40 Offset: 0x3DE3D41 VA: 0x3DE3C40
	|-List<ValueTuple<object, ValueTuple<object, int>>>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3DE6DE0 Offset: 0x3DE6EE1 VA: 0x3DE6DE0
	|-List<ValueTuple<object, int>>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3DE9D10 Offset: 0x3DE9E11 VA: 0x3DE9D10
	|-List<ValueTuple<Vector3, float>>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3DECD00 Offset: 0x3DECE01 VA: 0x3DECD00
	|-List<ValueTuple<object, Int32Enum, int>>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3DEFC90 Offset: 0x3DEFD91 VA: 0x3DEFC90
	|-List<ValueTuple<object, int, int, int>>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3DF2E00 Offset: 0x3DF2F01 VA: 0x3DF2E00
	|-List<AnimatorClipInfo>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3DF5CB0 Offset: 0x3DF5DB1 VA: 0x3DF5CB0
	|-List<AsyncOperationHandle>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3DF8EB0 Offset: 0x3DF8FB1 VA: 0x3DF8EB0
	|-List<BoneWeight>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3DFC020 Offset: 0x3DFC121 VA: 0x3DFC020
	|-List<bool>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3E79570 Offset: 0x3E79671 VA: 0x3E79570
	|-List<byte>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3E10E40 Offset: 0x3E10F41 VA: 0x3E10E40
	|-List<Camera>.System.Collections.IList.set_Item
	|-List<Decorator>.System.Collections.IList.set_Item
	|-List<DynValue>.System.Collections.IList.set_Item
	|-List<GameObject>.System.Collections.IList.set_Item
	|-List<MapBackup>.System.Collections.IList.set_Item
	|-List<object>.System.Collections.IList.set_Item
	|-List<Phase>.System.Collections.IList.set_Item
	|-List<ProfileCard>.System.Collections.IList.set_Item
	|-List<Unit>.System.Collections.IList.set_Item
	|-List<AssetTable.Accessory>.System.Collections.IList.set_Item
	|-List<GameSaveDataHeaderReader.Handle>.System.Collections.IList.set_Item
	|-List<MapDispos.ActualData>.System.Collections.IList.set_Item
	|-List<MapDispos.Pos>.System.Collections.IList.set_Item
	|-List<MapLayer.Data>.System.Collections.IList.set_Item
	|-List<MapObject.RigidInfo>.System.Collections.IList.set_Item
	|-List<RingListSequence.PageData>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3E7C3B0 Offset: 0x3E7C4B1 VA: 0x3E7C3B0
	|-List<CameraInfo>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3E7F2A0 Offset: 0x3E7F3A1 VA: 0x3E7F2A0
	|-List<char>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3E820E0 Offset: 0x3E821E1 VA: 0x3E820E0
	|-List<Color>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3E850A0 Offset: 0x3E851A1 VA: 0x3E850A0
	|-List<Color32>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3E87EE0 Offset: 0x3E87FE1 VA: 0x3E87EE0
	|-List<ConstraintSource>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3E8AE70 Offset: 0x3E8AF71 VA: 0x3E8AE70
	|-List<ContourVertex>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3E8E070 Offset: 0x3E8E171 VA: 0x3E8E070
	|-List<DataStoreRatingInfo>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3E911C0 Offset: 0x3E912C1 VA: 0x3E911C0
	|-List<DataStoreResult>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3E93FD0 Offset: 0x3E940D1 VA: 0x3E93FD0
	|-List<DateTime>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3E96E00 Offset: 0x3E96F01 VA: 0x3E96E00
	|-List<DateTimeOffset>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3E99CE0 Offset: 0x3E99DE1 VA: 0x3E99CE0
	|-List<Decimal>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3E9CC80 Offset: 0x3E9CD81 VA: 0x3E9CC80
	|-List<DiagnosticEvent>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3E9FFE0 Offset: 0x3EA00E1 VA: 0x3E9FFE0
	|-List<double>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3EA2EB0 Offset: 0x3EA2FB1 VA: 0x3EA2EB0
	|-List<Friend>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3EA61B0 Offset: 0x3EA62B1 VA: 0x3EA61B0
	|-List<GlyphRect>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3EA9070 Offset: 0x3EA9171 VA: 0x3EA9070
	|-List<short>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3EABE70 Offset: 0x3EABF71 VA: 0x3EABE70
	|-List<int>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3EAEC70 Offset: 0x3EAED71 VA: 0x3EAEC70
	|-List<Int32Enum>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3EB1A70 Offset: 0x3EB1B71 VA: 0x3EB1A70
	|-List<long>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3DFEE40 Offset: 0x3DFEF41 VA: 0x3DFEE40
	|-List<IntPtr>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3E01C70 Offset: 0x3E01D71 VA: 0x3E01C70
	|-List<InterpretedFrameInfo>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3E04BF0 Offset: 0x3E04CF1 VA: 0x3E04BF0
	|-List<IntervalTreeNode>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3E07D40 Offset: 0x3E07E41 VA: 0x3E07D40
	|-List<LengthLimitProperties>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3E0AB50 Offset: 0x3E0AC51 VA: 0x3E0AB50
	|-List<MapPos>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3E0DA60 Offset: 0x3E0DB61 VA: 0x3E0DA60
	|-List<Matrix4x4>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3E13D80 Offset: 0x3E13E81 VA: 0x3E13D80
	|-List<ObjectInitializationData>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3E17180 Offset: 0x3E17281 VA: 0x3E17180
	|-List<PlayableBinding>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3E1A3E0 Offset: 0x3E1A4E1 VA: 0x3E1A3E0
	|-List<PlayerLoopSystem>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3DA4880 Offset: 0x3DA4981 VA: 0x3DA4880
	|-List<PlayerLoopSystemInternal>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3DA7BA0 Offset: 0x3DA7CA1 VA: 0x3DA7BA0
	|-List<RangePositionInfo>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3DAAA90 Offset: 0x3DAAB91 VA: 0x3DAAA90
	|-List<Ranking2ChartInfoInput>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3DAD980 Offset: 0x3DADA81 VA: 0x3DAD980
	|-List<RaycastHit2D>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3DB0E40 Offset: 0x3DB0F41 VA: 0x3DB0E40
	|-List<RaycastResult>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3DB4510 Offset: 0x3DB4611 VA: 0x3DB4510
	|-List<Rect>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3DB74D0 Offset: 0x3DB75D1 VA: 0x3DB74D0
	|-List<RendererListHandle>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3DBA2E0 Offset: 0x3DBA3E1 VA: 0x3DBA2E0
	|-List<ResourceHandle>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3DBD0F0 Offset: 0x3DBD1F1 VA: 0x3DBD0F0
	|-List<sbyte>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3DBFF00 Offset: 0x3DC0001 VA: 0x3DBFF00
	|-List<ShaderTagId>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3E3BB60 Offset: 0x3E3BC61 VA: 0x3E3BB60
	|-List<float>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3E3EBC0 Offset: 0x3E3ECC1 VA: 0x3E3EBC0
	|-List<SphericalHarmonicsL2>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3E42730 Offset: 0x3E42831 VA: 0x3E42730
	|-List<SubMeshDescriptor>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3E45A80 Offset: 0x3E45B81 VA: 0x3E45A80
	|-List<TablePair>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3E48970 Offset: 0x3E48A71 VA: 0x3E48970
	|-List<TimeSpan>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3E4B7B0 Offset: 0x3E4B8B1 VA: 0x3E4B7B0
	|-List<UICharInfo>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3E4E780 Offset: 0x3E4E881 VA: 0x3E4E780
	|-List<UILineInfo>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3E51880 Offset: 0x3E51981 VA: 0x3E51880
	|-List<UIVertex>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3E55320 Offset: 0x3E55421 VA: 0x3E55320
	|-List<ushort>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3E58120 Offset: 0x3E58221 VA: 0x3E58120
	|-List<uint>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3DC2D10 Offset: 0x3DC2E11 VA: 0x3DC2D10
	|-List<ulong>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3DC5B20 Offset: 0x3DC5C21 VA: 0x3DC5B20
	|-List<Vector2>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3DC8A10 Offset: 0x3DC8B11 VA: 0x3DC8A10
	|-List<Vector3>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3DCBA00 Offset: 0x3DCBB01 VA: 0x3DCBA00
	|-List<Vector4>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3DCE9E0 Offset: 0x3DCEAE1 VA: 0x3DCE9E0
	|-List<VertexAttributeDescriptor>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3DD18D0 Offset: 0x3DD19D1 VA: 0x3DD18D0
	|-List<X509ChainStatus>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3DD48A0 Offset: 0x3DD49A1 VA: 0x3DD48A0
	|-List<XRView>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3DD7BE0 Offset: 0x3DD7CE1 VA: 0x3DD7BE0
	|-List<AmiiboSequence.GainItemData>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3DDABA0 Offset: 0x3DDACA1 VA: 0x3DDABA0
	|-List<AnimationOutputWeightProcessor.WeightInfo>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3DDDEA0 Offset: 0x3DDDFA1 VA: 0x3DDDEA0
	|-List<ArenaOrderSequence.GodInfo>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3E1D700 Offset: 0x3E1D801 VA: 0x3E1D700
	|-List<BattleInfo.SupportData>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3E20620 Offset: 0x3E20721 VA: 0x3E20620
	|-List<BeforeRenderHelper.OrderBlock>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3E235B0 Offset: 0x3E236B1 VA: 0x3E235B0
	|-List<Camera.RenderRequest>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3E26770 Offset: 0x3E26871 VA: 0x3E26770
	|-List<CameraState.CustomBlendable>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3E29660 Offset: 0x3E29761 VA: 0x3E29660
	|-List<CinemachineClearShot.Pair>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3E2C470 Offset: 0x3E2C571 VA: 0x3E2C470
	|-List<CinemachineStateDrivenCamera.HashPair>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3E2F320 Offset: 0x3E2F421 VA: 0x3E2F320
	|-List<DelayedActionManager.DelegateInfo>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3E32570 Offset: 0x3E32671 VA: 0x3E32570
	|-List<Detail.AsyncResultInt>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3E358B0 Offset: 0x3E359B1 VA: 0x3E358B0
	|-List<Detail.CppArray>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3E38840 Offset: 0x3E38941 VA: 0x3E38840
	|-List<Detail.NotificationEventInt>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3E5AF50 Offset: 0x3E5B051 VA: 0x3E5AF50
	|-List<DragonRideTargetGroup.ChainParam>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3E5DEE0 Offset: 0x3E5DFE1 VA: 0x3E5DEE0
	|-List<GmapPathAdjuster.TargetModel>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3E610F0 Offset: 0x3E611F1 VA: 0x3E610F0
	|-List<GmapSpotAdjuster.TargetModel>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3E64300 Offset: 0x3E64401 VA: 0x3E64300
	|-List<HubFastTravel.Location>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3E67550 Offset: 0x3E67651 VA: 0x3E67550
	|-List<HubLensFlare.Flare>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3E6A8E0 Offset: 0x3E6A9E1 VA: 0x3E6A8E0
	|-List<InventoryPoolItemMenuContent.KindBgNameClass>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3E6D7D0 Offset: 0x3E6D8D1 VA: 0x3E6D7D0
	|-List<Map.Pos>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3E70600 Offset: 0x3E70701 VA: 0x3E70600
	|-List<MapImage.BackupTerrain>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3E734D0 Offset: 0x3E735D1 VA: 0x3E734D0
	|-List<MapImageRange.Pos>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3E76400 Offset: 0x3E76501 VA: 0x3E76400
	|-List<MapMind.Target>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3D85FF0 Offset: 0x3D860F1 VA: 0x3D85FF0
	|-List<MapPanelDebug.Entity>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3D89140 Offset: 0x3D89241 VA: 0x3D89140
	|-List<NexRanking.Data>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3D8BF70 Offset: 0x3D8C071 VA: 0x3D8BF70
	|-List<NexVersus.RatingData>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3D8EE60 Offset: 0x3D8EF61 VA: 0x3D8EE60
	|-List<PackedPlayModeBuildLogs.RuntimeBuildLog>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3D91E20 Offset: 0x3D91F21 VA: 0x3D91E20
	|-List<ParticleSystem.Particle>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3D95100 Offset: 0x3D95201 VA: 0x3D95100
	|-List<RangeData.Offset>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3D97FB0 Offset: 0x3D980B1 VA: 0x3D97FB0
	|-List<RenderGraphDebugData.PassDebugData>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3D9B210 Offset: 0x3D9B311 VA: 0x3D9B210
	|-List<RenderGraphDebugData.ResourceDebugData>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3D9E530 Offset: 0x3D9E631 VA: 0x3D9E530
	|-List<RingCleaningUnitSelectMenu.GodParam>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3DA14F0 Offset: 0x3DA15F1 VA: 0x3DA14F0
	|-List<ShadowUtility.Edge>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3D13C70 Offset: 0x3D13D71 VA: 0x3D13C70
	|-List<SkillArray.Entity>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3D16B90 Offset: 0x3D16C91 VA: 0x3D16B90
	|-List<TexturePacker_JsonArray.Frame>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3D1A0E0 Offset: 0x3D1A1E1 VA: 0x3D1A0E0
	|-List<TimeNotificationBehaviour.NotificationEntry>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3D1D310 Offset: 0x3D1D411 VA: 0x3D1D310
	|-List<UnitySynchronizationContext.WorkRequest>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3D204B0 Offset: 0x3D205B1 VA: 0x3D204B0
	|-List<XmlSchemaObjectTable.XmlSchemaObjectEntry>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3D233D0 Offset: 0x3D234D1 VA: 0x3D233D0
	|-List<AssetBundleBuildMap.AssetBundleEntry.AssetPathString>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3D263A0 Offset: 0x3D264A1 VA: 0x3D263A0
	|-List<Detail.DataStore.DataStoreChangeMetaParamInt>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3D29700 Offset: 0x3D29801 VA: 0x3D29700
	|-List<Detail.DataStore.DataStoreDeleteParamInt>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3D2C690 Offset: 0x3D2C791 VA: 0x3D2C690
	|-List<Detail.DataStore.DataStoreGetMetaParamInt>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3D2FA30 Offset: 0x3D2FB31 VA: 0x3D2FA30
	|-List<Detail.DataStore.DataStoreMetaInfoInt>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3CF4230 Offset: 0x3CF4331 VA: 0x3CF4230
	|-List<Detail.DataStore.DataStorePasswordInfoInt>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3CF7410 Offset: 0x3CF7511 VA: 0x3CF7410
	|-List<Detail.DataStore.DataStorePersistenceInfoInt>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3CFA630 Offset: 0x3CFA731 VA: 0x3CFA630
	|-List<Detail.DataStore.DataStorePreparePostParamInt>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3CFD930 Offset: 0x3CFDA31 VA: 0x3CFD930
	|-List<Detail.DataStore.DataStoreRateObjectParamInt>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3D00880 Offset: 0x3D00981 VA: 0x3D00880
	|-List<Detail.DataStore.DataStoreRatingInitParamInt>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3D03A00 Offset: 0x3D03B01 VA: 0x3D03A00
	|-List<Detail.DataStore.DataStoreRatingTargetInt>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3D069C0 Offset: 0x3D06AC1 VA: 0x3D069C0
	|-List<Detail.Ranking.RankingCachedResultInt>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3D09EC0 Offset: 0x3D09FC1 VA: 0x3D09EC0
	|-List<Detail.Ranking.RankingOrderParamInt>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3D0CE80 Offset: 0x3D0CF81 VA: 0x3D0CE80
	|-List<Detail.Ranking.RankingRankDataInt>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3D104C0 Offset: 0x3D105C1 VA: 0x3D104C0
	|-List<Detail.Ranking2.Ranking2ChartInfoInt>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3D66E00 Offset: 0x3D66F01 VA: 0x3D66E00
	|-List<Detail.Ranking2.Ranking2RankDataInt>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3D6A2A0 Offset: 0x3D6A3A1 VA: 0x3D6A2A0
	|-List<Detail.Ranking2.Ranking2ScoreDataInt>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3D6D1F0 Offset: 0x3D6D2F1 VA: 0x3D6D1F0
	|-List<Detail.Screening.ScreeningContextInfoInt>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3D704C0 Offset: 0x3D705C1 VA: 0x3D704C0
	|-List<Detail.Subscriber.SubscriberContentInt>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3D73BB0 Offset: 0x3D73CB1 VA: 0x3D73BB0
	|-List<Detail.Subscriber.SubscriberGetContentParamInt>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3D76DD0 Offset: 0x3D76ED1 VA: 0x3D76DD0
	|-List<Detail.Subscriber.SubscriberUserStatusInfoInt>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3D7A130 Offset: 0x3D7A231 VA: 0x3D7A130
	|-List<Detail.Subscriber.SubscriberUserStatusParamInt>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3D7D280 Offset: 0x3D7D381 VA: 0x3D7D280
	|-List<Detail.Utility.IntegerSettings>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3D800B0 Offset: 0x3D801B1 VA: 0x3D800B0
	|-List<Detail.Utility.UniqueIdInfoInt>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3D82FB0 Offset: 0x3D830B1 VA: 0x3D82FB0
	|-List<MapHistory.Rewind.LatestInspectorData>.System.Collections.IList.set_Item
	|
	|-RVA: 0x305F270 Offset: 0x305F371 VA: 0x305F270
	|-List<MapHistory.Rewind.WorkTerrainData>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3062250 Offset: 0x3062351 VA: 0x3062250
	|-List<MapSkill.AroundCalculator.Result>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3065210 Offset: 0x3065311 VA: 0x3065210
	|-List<TargetPositionCache.CacheCurve.Item>.System.Collections.IList.set_Item
	|
	|-RVA: 0x30685A0 Offset: 0x30686A1 VA: 0x30685A0
	|-List<TargetPositionCache.CacheEntry.RecordingItem>.System.Collections.IList.set_Item
	*/

	// RVA: -1 Offset: -1 Slot: 11
	public void Add(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3E10FE0 Offset: 0x3E110E1 VA: 0x3E10FE0
	|-List<Dictionary<sbyte, DataStoreRatingInfo>>.Add
	|-List<List<CinemachineVirtualCameraBase>>.Add
	|-List<List<int>>.Add
	|-List<List<object>>.Add
	|-List<List<SubscriberContent>>.Add
	|-List<List<Vector2>>.Add
	|-List<List<Vector3>>.Add
	|-List<List<NexVersus.RatingData>>.Add
	|-List<StructDataArrayList<TutorialData>>.Add
	|-List<MiniMapController.TImage<Image>>.Add
	|-List<MiniMapController.TImage<UnitIcon>>.Add
	|-List<KeyCode[]>.Add
	|-List<string[]>.Add
	|-List<AccessoryData>.Add
	|-List<AccessoryShopContent>.Add
	|-List<AchieveData>.Add
	|-List<Action>.Add
	|-List<AggregateException>.Add
	|-List<AkAmbient>.Add
	|-List<AkAmbientLargeModePositioner>.Add
	|-List<AkAudioListener>.Add
	|-List<AkEnvironmentPortal>.Add
	|-List<AkGameObj>.Add
	|-List<AkRoomAwareObject>.Add
	|-List<AkRoomPortal>.Add
	|-List<AkSpatialAudioListener>.Add
	|-List<AkSurfaceReflector>.Add
	|-List<AnimalData>.Add
	|-List<AnimationClip>.Add
	|-List<AnimationEvent>.Add
	|-List<AnimationTrack>.Add
	|-List<Animator>.Add
	|-List<AssetTable>.Add
	|-List<AsyncDebugger>.Add
	|-List<AudienceAnime>.Add
	|-List<BaseConverter>.Add
	|-List<BaseInvokableCall>.Add
	|-List<BaseRaycaster>.Add
	|-List<BasicMenu>.Add
	|-List<BasicMenuItem>.Add
	|-List<BasicMenuSelect>.Add
	|-List<BattleInfoSide>.Add
	|-List<Behaviour>.Add
	|-List<BranchLabel>.Add
	|-List<Breakpoint>.Add
	|-List<BuildTimeScopeBlock>.Add
	|-List<BuildTimeScopeFrame>.Add
	|-List<ByRefUpdater>.Add
	|-List<CalculatorCommand>.Add
	|-List<Camera>.Add
	|-List<ChapterData>.Add
	|-List<Character>.Add
	|-List<CharacterCollision>.Add
	|-List<CharacterProportion>.Add
	|-List<CinemachineComponentBase>.Add
	|-List<CinemachineExtension>.Add
	|-List<CinemachineVirtualCameraBase>.Add
	|-List<Claim>.Add
	|-List<Collider>.Add
	|-List<Contraction>.Add
	|-List<CookData>.Add
	|-List<CustomEnvSet>.Add
	|-List<DataStoreChangeMetaParam>.Add
	|-List<DataStoreDeleteParam>.Add
	|-List<DataStoreGetMetaParam>.Add
	|-List<DataStorePreparePostParam>.Add
	|-List<DataStoreRateObjectParam>.Add
	|-List<DataStoreRatingTarget>.Add
	|-List<DebugInfo>.Add
	|-List<DebugUIHandlerPanel>.Add
	|-List<DebugUIHandlerValue>.Add
	|-List<DebugUIHandlerWidget>.Add
	|-List<Decorator>.Add
	|-List<DisposData>.Add
	|-List<DynValue>.Add
	|-List<EncountUnitData>.Add
	|-List<EventCharacterMouthController>.Add
	|-List<EventSystem>.Add
	|-List<Exception>.Add
	|-List<ExceptionDispatchInfo>.Add
	|-List<ExceptionHandler>.Add
	|-List<Expression>.Add
	|-List<Expression>.Add
	|-List<FileData>.Add
	|-List<FoodstuffData>.Add
	|-List<ForceProvider>.Add
	|-List<ForecastFishData>.Add
	|-List<FriendListData>.Add
	|-List<GUILayoutEntry>.Add
	|-List<GameObject>.Add
	|-List<Glyph>.Add
	|-List<GmapSpot>.Add
	|-List<GodUnit>.Add
	|-List<GotoStatement>.Add
	|-List<Graphic>.Add
	|-List<HelpItemList>.Add
	|-List<HubAccess>.Add
	|-List<HubAccessData>.Add
	|-List<HubAccessManager>.Add
	|-List<HubAreaFog>.Add
	|-List<HubManualCulling>.Add
	|-List<HubMoveState>.Add
	|-List<HubUnitController>.Add
	|-List<IAsyncLocal>.Add
	|-List<IAsyncOperation>.Add
	|-List<ICanvasElement>.Add
	|-List<IClosureBuilder>.Add
	|-List<IContextProperty>.Add
	|-List<IDisposable>.Add
	|-List<IDtdDefaultAttributeInfo>.Add
	|-List<IMarker>.Add
	|-List<IMenuElement>.Add
	|-List<IOverloadableMemberDescriptor>.Add
	|-List<IPAddress>.Add
	|-List<IResourceLocation>.Add
	|-List<IResourceLocator>.Add
	|-List<ISpringManager>.Add
	|-List<ITimelineEvaluateCallback>.Add
	|-List<IUpdateReceiver>.Add
	|-List<IUserDataDescriptor>.Add
	|-List<IVariable>.Add
	|-List<Image>.Add
	|-List<Instruction>.Add
	|-List<Instruction>.Add
	|-List<IntegratedSubsystem>.Add
	|-List<IntegratedSubsystemDescriptor>.Add
	|-List<InteractionTarget>.Add
	|-List<InteractionTrigger>.Add
	|-List<ItemData>.Add
	|-List<JobData>.Add
	|-List<KerningPair>.Add
	|-List<LabelScopeInfo>.Add
	|-List<Level2Map>.Add
	|-List<Light2D>.Add
	|-List<LocalDataStore>.Add
	|-List<MapBackup>.Add
	|-List<MapCollision>.Add
	|-List<MapEditorObjectData>.Add
	|-List<MapInfoRoot>.Add
	|-List<MapInspector>.Add
	|-List<MapObject>.Add
	|-List<MascotColorChangeItemContent>.Add
	|-List<Material>.Add
	|-List<MaterialPropertyBlock>.Add
	|-List<MenuItem>.Add
	|-List<MethodBase>.Add
	|-List<MethodInfo>.Add
	|-List<ModifierSpec>.Add
	|-List<Module>.Add
	|-List<MusclePushUpSpeedData>.Add
	|-List<MuscleSitUpFallData>.Add
	|-List<Note>.Add
	|-List<NotificationEventCB>.Add
	|-List<object>.Add
	|-List<ParameterExpression>.Add
	|-List<Phase>.Add
	|-List<PhotographCameraParameter>.Add
	|-List<PhotographDisposInfo>.Add
	|-List<PhotographPauseData>.Add
	|-List<PlayReportSendBase>.Add
	|-List<PrefetchedSignal>.Add
	|-List<Processor>.Add
	|-List<ProfileCard>.Add
	|-List<RankingOrderParam>.Add
	|-List<RectMask2D>.Add
	|-List<RectTransform>.Add
	|-List<RegexNode>.Add
	|-List<RelayLeavingUnitData>.Add
	|-List<RelayServerMetaData>.Add
	|-List<RelayStampData>.Add
	|-List<RenderGraph>.Add
	|-List<RenderGraphPass>.Add
	|-List<Renderer>.Add
	|-List<ResourceGameObject>.Add
	|-List<ResourceHandle>.Add
	|-List<RewardData>.Add
	|-List<RingCleaningVoiceData>.Add
	|-List<RingData>.Add
	|-List<RuntimeElement>.Add
	|-List<RuntimeType>.Add
	|-List<Scope>.Add
	|-List<ScreeningContextInfo>.Add
	|-List<ScriptableObject>.Add
	|-List<ScriptableRenderPass>.Add
	|-List<ScriptableRendererFeature>.Add
	|-List<SerializationFieldInfo>.Add
	|-List<ShadowCaster2D>.Add
	|-List<ShopContent>.Add
	|-List<SignalAsset>.Add
	|-List<SkillData>.Add
	|-List<SkinQualityLodAdjuster>.Add
	|-List<SkinnedMeshRenderer>.Add
	|-List<SolverManager>.Add
	|-List<SortieEntrustStockData>.Add
	|-List<SortieEntrustUnitData>.Add
	|-List<SourceCode>.Add
	|-List<SourceRef>.Add
	|-List<SpringBone>.Add
	|-List<SpringCollider>.Add
	|-List<Sprite>.Add
	|-List<StackFrame>.Add
	|-List<StackFrame>.Add
	|-List<Statement>.Add
	|-List<string>.Add
	|-List<StringBuilder>.Add
	|-List<StructProperty>.Add
	|-List<SymbolRef>.Add
	|-List<TMP_Character>.Add
	|-List<TMP_FontAsset>.Add
	|-List<TMP_GlyphPairAdjustmentRecord>.Add
	|-List<TMP_SpriteCharacter>.Add
	|-List<TMP_SpriteGlyph>.Add
	|-List<TMP_Style>.Add
	|-List<TMP_Text>.Add
	|-List<Task>.Add
	|-List<Texture2D>.Add
	|-List<Thread>.Add
	|-List<Thread>.Add
	|-List<TimeZoneInfo>.Add
	|-List<TimelineClip>.Add
	|-List<Timer>.Add
	|-List<TipsData>.Add
	|-List<Toggle>.Add
	|-List<TrackAsset>.Add
	|-List<Transform>.Add
	|-List<Type>.Add
	|-List<TypeIdentifier>.Add
	|-List<TypeSpec>.Add
	|-List<Unit>.Add
	|-List<UnitActor>.Add
	|-List<UnitItem>.Add
	|-List<UnitRelianceMapResult>.Add
	|-List<UnitRing>.Add
	|-List<UnityEvent>.Add
	|-List<UnityWebRequestAsyncOperation>.Add
	|-List<ValueCountController>.Add
	|-List<Variable>.Add
	|-List<VersusServerCasualMetaData>.Add
	|-List<VersusServerRankedMetaData>.Add
	|-List<VersusServerReplayMetaData>.Add
	|-List<Volume>.Add
	|-List<VolumeComponent>.Add
	|-List<WatchItem>.Add
	|-List<WeaponMask>.Add
	|-List<WindActor>.Add
	|-List<X509CertificateImpl>.Add
	|-List<XRPass>.Add
	|-List<XmlSchemaElement>.Add
	|-List<XmlSchemaObject>.Add
	|-List<AICannon.CannonData>.Add
	|-List<AIInterruptAttack.Candidate>.Add
	|-List<AddressablesImpl.ResourceLocatorInfo>.Add
	|-List<AdhocAssetLoader.Asset>.Add
	|-List<AkBankManager.BankHandle>.Add
	|-List<AssetBundleBuildMap.AssetBundleEntry>.Add
	|-List<AssetTable.Accessory>.Add
	|-List<BufferedGizmo.Segment>.Add
	|-List<CalculatorUtil.Entity>.Add
	|-List<CasualMap.ObjectData>.Add
	|-List<ChapterRecord.Record>.Add
	|-List<CinemachineBrain.BrainFrame>.Add
	|-List<CinemachineImpulseManager.ImpulseEvent>.Add
	|-List<CinemachineStoryboard.CanvasInfo>.Add
	|-List<ClassChange.ChangeJobData>.Add
	|-List<ConditionGetterCommand.Command>.Add
	|-List<ConstantBuffer.ConstantBufferBase>.Add
	|-List<DLCManager.MountData>.Add
	|-List<DamageInfo.Info>.Add
	|-List<DebugCommandline.Property>.Add
	|-List<DebugPathMenu.EntryData>.Add
	|-List<DebugUI.Panel>.Add
	|-List<DebugUI.Widget>.Add
	|-List<Directory.SearchData>.Add
	|-List<DishAllMenuContent.HistoryObject>.Add
	|-List<DishSelectMenu.DishSelectMenuItem>.Add
	|-List<DishSelectMenuCategoryContent.CategoryObject>.Add
	|-List<DragonRideSequence.PrizeData>.Add
	|-List<DragonRideTargetGroup.ChainSEManager>.Add
	|-List<Dropdown.DropdownItem>.Add
	|-List<Dropdown.OptionData>.Add
	|-List<DynamicsSetup.ParseMessage>.Add
	|-List<EventSequence.Coroutine>.Add
	|-List<ExchangeYesNoDialog.ItemParam>.Add
	|-List<FoodstuffMenu.FoodstuffMenuItem>.Add
	|-List<GameSaveDataHeaderReader.Handle>.Add
	|-List<GameSound.Handle>.Add
	|-List<GmapLineRenderer.LinePoint>.Add
	|-List<GmapMapInfoContent.ItemInfo>.Add
	|-List<GodGrowthData.LevelData>.Add
	|-List<GrassData.SpriteInfo>.Add
	|-List<HelpManager.Item>.Add
	|-List<HubMiniMap.IconData>.Add
	|-List<IfStatement.IfBlock>.Add
	|-List<ItemListYesNoDialog.ItemParam>.Add
	|-List<LaterTalkSetter.UnitData>.Add
	|-List<LocalVariables.VariableScope>.Add
	|-List<MapBattleInfoSequence.AttackInfo>.Add
	|-List<MapDispos.ActualData>.Add
	|-List<MapDispos.Pos>.Add
	|-List<MapEditData.UnitInfo>.Add
	|-List<MapEditHistory.MapEditCommand>.Add
	|-List<MapImageTerrain.MinimapInfo>.Add
	|-List<MapLayer.Data>.Add
	|-List<MapMaterial.Node>.Add
	|-List<MapObject.DitherPair>.Add
	|-List<MapObject.RigidInfo>.Add
	|-List<MapOverlap.Data>.Add
	|-List<MapPrefab.Entity>.Add
	|-List<MapTarget.Data>.Add
	|-List<MapTerrainInfoAlignment.AlignMember>.Add
	|-List<MapTerrainInfoAlignment.InversionMember>.Add
	|-List<Mess.ReloadFileInfo>.Add
	|-List<MonoChunkStream.Chunk>.Add
	|-List<MuscleSquatSequence.RandomPack>.Add
	|-List<MyRoomWakeupSequence.RelianceWakeup>.Add
	|-List<PhotographTopSequence.UnitAccDataSet>.Add
	|-List<PlayerEditorConnectionEvents.MessageTypeSubscribers>.Add
	|-List<PointerInputModule.ButtonState>.Add
	|-List<ProfileCard.FreeStamp>.Add
	|-List<RefineRingInfoWindow.RingRefineStatistics>.Add
	|-List<RegexCharClass.SingleRange>.Add
	|-List<RelayMessageMenuContent.KindIcon>.Add
	|-List<RelayUserData.EnteredBattle>.Add
	|-List<RelayWdwMapHelp.ShowItem>.Add
	|-List<ResourceManager.InstanceOperation>.Add
	|-List<RingListSequence.GodPageData>.Add
	|-List<RingListSequence.PageData>.Add
	|-List<RingListSequence.RingPageData>.Add
	|-List<SimpleAnimation.EditorState>.Add
	|-List<SimpleAnimationPlayable.StateInfo>.Add
	|-List<SkillData.Func>.Add
	|-List<SkillStack.Packet>.Add
	|-List<SolanelInfoMenuContent.HelpFastTravel>.Add
	|-List<SolanelInfoMenuContent.Infomation>.Add
	|-List<SolanelInfoMenuContent.SolanelUnit>.Add
	|-List<SortieEntrustUnitData.WeaponKindExp>.Add
	|-List<SoundSystem.LipSyncData>.Add
	|-List<SoundSystem.ResultSoundLoad>.Add
	|-List<SoundSystem.SoundHandle>.Add
	|-List<SpringBoneSerialization.PivotSerializer>.Add
	|-List<SpringBoneSerialization.SpringBoneSerializer>.Add
	|-List<SpringColliderSerialization.IColliderSerializer>.Add
	|-List<SpringColliderSerialization.TransformSerializer>.Add
	|-List<StencilMaterial.MatEntry>.Add
	|-List<StructHeader.Param>.Add
	|-List<TMP_Dropdown.DropdownItem>.Add
	|-List<TMP_Dropdown.OptionData>.Add
	|-List<TMP_MaterialManager.FallbackMaterial>.Add
	|-List<TMP_MaterialManager.MaskingMaterial>.Add
	|-List<TextRecordParsing.Record>.Add
	|-List<TimeZoneInfo.AdjustmentRule>.Add
	|-List<TransformAnimation.Animator>.Add
	|-List<UnitSelectMenu.UnitSelectMenuItem>.Add
	|-List<GameSaveDataUtil.ProcDeleteAll.Data>.Add
	|-List<RelayCompletionAwardData.CalcResult.Item>.Add
	|-List<SoundWwise.SoundBankManager.BankHandle>.Add
	|-List<TransformAnimation.Animator.Node>.Add
	|-List<Versus.DownloadHistory.CheckData>.Add
	|-List<VersusSequence.VersusSequenceLocal.MetaDataPack>.Add
	|
	|-RVA: 0x3B0B090 Offset: 0x3B0B191 VA: 0x3B0B090
	|-List<IntervalTree.Entry<object>>.Add
	|
	|-RVA: 0x3B17280 Offset: 0x3B17381 VA: 0x3B17280
	|-List<KeyValuePair<AnimationClip, AnimationClip>>.Add
	|-List<KeyValuePair<Expression, Expression>>.Add
	|-List<KeyValuePair<object, object>>.Add
	|
	|-RVA: 0x3B0E220 Offset: 0x3B0E321 VA: 0x3B0E220
	|-List<KeyValuePair<DateTime, object>>.Add
	|-List<KeyValuePair<DateTime, TimeType>>.Add
	|
	|-RVA: 0x3B11140 Offset: 0x3B11241 VA: 0x3B11140
	|-List<KeyValuePair<int, object>>.Add
	|
	|-RVA: 0x3B140E0 Offset: 0x3B141E1 VA: 0x3B140E0
	|-List<KeyValuePair<object, ValueTuple<int, DateTime, object>>>.Add
	|
	|-RVA: 0x3B1A220 Offset: 0x3B1A321 VA: 0x3B1A220
	|-List<CommonBattleSequence.Reliance<object>>.Add
	|
	|-RVA: 0x3B1D3B0 Offset: 0x3B1D4B1 VA: 0x3B1D3B0
	|-List<RenderGraphResourcePool.ResourceLogInfo<object>>.Add
	|
	|-RVA: 0x3B202D0 Offset: 0x3B203D1 VA: 0x3B202D0
	|-List<ValueTuple<int, object>>.Add
	|
	|-RVA: 0x3DE0F30 Offset: 0x3DE1031 VA: 0x3DE0F30
	|-List<ValueTuple<Int32Enum, int>>.Add
	|-List<ValueTuple<HubAccessManager.MaterialCalculator.Type, int>>.Add
	|
	|-RVA: 0x3DE3DF0 Offset: 0x3DE3EF1 VA: 0x3DE3DF0
	|-List<ValueTuple<object, ValueTuple<object, int>>>.Add
	|-List<ValueTuple<object, ValueTuple<Type, int>>>.Add
	|
	|-RVA: 0x3DE6F80 Offset: 0x3DE7081 VA: 0x3DE6F80
	|-List<ValueTuple<object, int>>.Add
	|-List<ValueTuple<string, int>>.Add
	|
	|-RVA: 0x3DE9EC0 Offset: 0x3DE9FC1 VA: 0x3DE9EC0
	|-List<ValueTuple<Vector3, float>>.Add
	|
	|-RVA: 0x3DECEA0 Offset: 0x3DECFA1 VA: 0x3DECEA0
	|-List<ValueTuple<ItemData.Kinds[], WeaponLevel.Kind, int>>.Add
	|-List<ValueTuple<object, Int32Enum, int>>.Add
	|
	|-RVA: 0x3DEFE40 Offset: 0x3DEFF41 VA: 0x3DEFE40
	|-List<ValueTuple<object, int, int, int>>.Add
	|-List<ValueTuple<string, int, int, int>>.Add
	|
	|-RVA: 0x3DF2FA0 Offset: 0x3DF30A1 VA: 0x3DF2FA0
	|-List<AnimatorClipInfo>.Add
	|
	|-RVA: 0x3DF5E60 Offset: 0x3DF5F61 VA: 0x3DF5E60
	|-List<AsyncOperationHandle>.Add
	|
	|-RVA: 0x3DF9060 Offset: 0x3DF9161 VA: 0x3DF9060
	|-List<BoneWeight>.Add
	|
	|-RVA: 0x3DFC1C0 Offset: 0x3DFC2C1 VA: 0x3DFC1C0
	|-List<bool>.Add
	|
	|-RVA: 0x3E79710 Offset: 0x3E79811 VA: 0x3E79710
	|-List<byte>.Add
	|
	|-RVA: 0x3E7C550 Offset: 0x3E7C651 VA: 0x3E7C550
	|-List<CameraInfo>.Add
	|
	|-RVA: 0x3EAEE10 Offset: 0x3EAEF11 VA: 0x3EAEE10
	|-List<CameraPosition>.Add
	|-List<DataType>.Add
	|-List<Int32Enum>.Add
	|-List<ParticleSystemVertexStream>.Add
	|-List<RegexOptions>.Add
	|-List<CapabilityDefinition.Type>.Add
	|-List<Cooking.ConversationType>.Add
	|-List<ItemData.Kinds>.Add
	|-List<MapPanelActive.MeshIndex>.Add
	|-List<MapPanelDanger.MeshIndex>.Add
	|-List<MapPanelDeploy.MeshIndex>.Add
	|-List<MapUIGauge.IconIndex>.Add
	|-List<TutorialListTopMenu.SelectCategoryType>.Add
	|
	|-RVA: 0x3E7F440 Offset: 0x3E7F541 VA: 0x3E7F440
	|-List<char>.Add
	|
	|-RVA: 0x3E82290 Offset: 0x3E82391 VA: 0x3E82290
	|-List<Color>.Add
	|
	|-RVA: 0x3E85240 Offset: 0x3E85341 VA: 0x3E85240
	|-List<Color32>.Add
	|
	|-RVA: 0x3E88080 Offset: 0x3E88181 VA: 0x3E88080
	|-List<ConstraintSource>.Add
	|
	|-RVA: 0x3E8B020 Offset: 0x3E8B121 VA: 0x3E8B020
	|-List<ContourVertex>.Add
	|
	|-RVA: 0x3E8E220 Offset: 0x3E8E321 VA: 0x3E8E220
	|-List<DataStoreRatingInfo>.Add
	|
	|-RVA: 0x3E91360 Offset: 0x3E91461 VA: 0x3E91360
	|-List<DataStoreResult>.Add
	|
	|-RVA: 0x3E94170 Offset: 0x3E94271 VA: 0x3E94170
	|-List<DateTime>.Add
	|
	|-RVA: 0x3E96FA0 Offset: 0x3E970A1 VA: 0x3E96FA0
	|-List<DateTimeOffset>.Add
	|
	|-RVA: 0x3E99E80 Offset: 0x3E99F81 VA: 0x3E99E80
	|-List<Decimal>.Add
	|
	|-RVA: 0x3E9CE40 Offset: 0x3E9CF41 VA: 0x3E9CE40
	|-List<DiagnosticEvent>.Add
	|
	|-RVA: 0x3EA0180 Offset: 0x3EA0281 VA: 0x3EA0180
	|-List<double>.Add
	|
	|-RVA: 0x3EA3070 Offset: 0x3EA3171 VA: 0x3EA3070
	|-List<Friend>.Add
	|
	|-RVA: 0x3EA6350 Offset: 0x3EA6451 VA: 0x3EA6350
	|-List<GlyphRect>.Add
	|
	|-RVA: 0x3EA9210 Offset: 0x3EA9311 VA: 0x3EA9210
	|-List<short>.Add
	|
	|-RVA: 0x3EAC010 Offset: 0x3EAC111 VA: 0x3EAC010
	|-List<int>.Add
	|
	|-RVA: 0x3EB1C10 Offset: 0x3EB1D11 VA: 0x3EB1C10
	|-List<long>.Add
	|
	|-RVA: 0x3DFEFE0 Offset: 0x3DFF0E1 VA: 0x3DFEFE0
	|-List<IntPtr>.Add
	|
	|-RVA: 0x3E01E10 Offset: 0x3E01F11 VA: 0x3E01E10
	|-List<InterpretedFrameInfo>.Add
	|
	|-RVA: 0x3E04DA0 Offset: 0x3E04EA1 VA: 0x3E04DA0
	|-List<IntervalTreeNode>.Add
	|
	|-RVA: 0x3E07EE0 Offset: 0x3E07FE1 VA: 0x3E07EE0
	|-List<LengthLimitProperties>.Add
	|
	|-RVA: 0x3E0ACF0 Offset: 0x3E0ADF1 VA: 0x3E0ACF0
	|-List<MapPos>.Add
	|
	|-RVA: 0x3E0DC20 Offset: 0x3E0DD21 VA: 0x3E0DC20
	|-List<Matrix4x4>.Add
	|
	|-RVA: 0x3E13F40 Offset: 0x3E14041 VA: 0x3E13F40
	|-List<ObjectInitializationData>.Add
	|
	|-RVA: 0x3E17330 Offset: 0x3E17431 VA: 0x3E17330
	|-List<PlayableBinding>.Add
	|
	|-RVA: 0x3E1A5A0 Offset: 0x3E1A6A1 VA: 0x3E1A5A0
	|-List<PlayerLoopSystem>.Add
	|
	|-RVA: 0x3DA4A40 Offset: 0x3DA4B41 VA: 0x3DA4A40
	|-List<PlayerLoopSystemInternal>.Add
	|
	|-RVA: 0x3DA7D40 Offset: 0x3DA7E41 VA: 0x3DA7D40
	|-List<RangePositionInfo>.Add
	|
	|-RVA: 0x3DAAC30 Offset: 0x3DAAD31 VA: 0x3DAAC30
	|-List<Ranking2ChartInfoInput>.Add
	|
	|-RVA: 0x3DADB40 Offset: 0x3DADC41 VA: 0x3DADB40
	|-List<RaycastHit2D>.Add
	|
	|-RVA: 0x3DB1010 Offset: 0x3DB1111 VA: 0x3DB1010
	|-List<RaycastResult>.Add
	|
	|-RVA: 0x3DB46C0 Offset: 0x3DB47C1 VA: 0x3DB46C0
	|-List<Rect>.Add
	|
	|-RVA: 0x3DB7670 Offset: 0x3DB7771 VA: 0x3DB7670
	|-List<RendererListHandle>.Add
	|
	|-RVA: 0x3DBA480 Offset: 0x3DBA581 VA: 0x3DBA480
	|-List<ResourceHandle>.Add
	|
	|-RVA: 0x3DBD290 Offset: 0x3DBD391 VA: 0x3DBD290
	|-List<sbyte>.Add
	|
	|-RVA: 0x3DC00A0 Offset: 0x3DC01A1 VA: 0x3DC00A0
	|-List<ShaderTagId>.Add
	|
	|-RVA: 0x3E3BD00 Offset: 0x3E3BE01 VA: 0x3E3BD00
	|-List<float>.Add
	|
	|-RVA: 0x3E3EDA0 Offset: 0x3E3EEA1 VA: 0x3E3EDA0
	|-List<SphericalHarmonicsL2>.Add
	|
	|-RVA: 0x3E428F0 Offset: 0x3E429F1 VA: 0x3E428F0
	|-List<SubMeshDescriptor>.Add
	|
	|-RVA: 0x3E45C20 Offset: 0x3E45D21 VA: 0x3E45C20
	|-List<TablePair>.Add
	|
	|-RVA: 0x3E48B10 Offset: 0x3E48C11 VA: 0x3E48B10
	|-List<TimeSpan>.Add
	|
	|-RVA: 0x3E4B960 Offset: 0x3E4BA61 VA: 0x3E4B960
	|-List<UICharInfo>.Add
	|
	|-RVA: 0x3E4E920 Offset: 0x3E4EA21 VA: 0x3E4E920
	|-List<UILineInfo>.Add
	|
	|-RVA: 0x3E51A60 Offset: 0x3E51B61 VA: 0x3E51A60
	|-List<UIVertex>.Add
	|
	|-RVA: 0x3E554C0 Offset: 0x3E555C1 VA: 0x3E554C0
	|-List<ushort>.Add
	|
	|-RVA: 0x3E582C0 Offset: 0x3E583C1 VA: 0x3E582C0
	|-List<uint>.Add
	|
	|-RVA: 0x3DC2EB0 Offset: 0x3DC2FB1 VA: 0x3DC2EB0
	|-List<ulong>.Add
	|
	|-RVA: 0x3DC5CC0 Offset: 0x3DC5DC1 VA: 0x3DC5CC0
	|-List<Vector2>.Add
	|
	|-RVA: 0x3DC8BC0 Offset: 0x3DC8CC1 VA: 0x3DC8BC0
	|-List<Vector3>.Add
	|
	|-RVA: 0x3DCBBB0 Offset: 0x3DCBCB1 VA: 0x3DCBBB0
	|-List<Vector4>.Add
	|
	|-RVA: 0x3DCEB80 Offset: 0x3DCEC81 VA: 0x3DCEB80
	|-List<VertexAttributeDescriptor>.Add
	|
	|-RVA: 0x3DD1A70 Offset: 0x3DD1B71 VA: 0x3DD1A70
	|-List<X509ChainStatus>.Add
	|
	|-RVA: 0x3DD4A50 Offset: 0x3DD4B51 VA: 0x3DD4A50
	|-List<XRView>.Add
	|
	|-RVA: 0x3DD7D80 Offset: 0x3DD7E81 VA: 0x3DD7D80
	|-List<AmiiboSequence.GainItemData>.Add
	|
	|-RVA: 0x3DDAD60 Offset: 0x3DDAE61 VA: 0x3DDAD60
	|-List<AnimationOutputWeightProcessor.WeightInfo>.Add
	|
	|-RVA: 0x3DDE040 Offset: 0x3DDE141 VA: 0x3DDE040
	|-List<ArenaOrderSequence.GodInfo>.Add
	|
	|-RVA: 0x3E1D8A0 Offset: 0x3E1D9A1 VA: 0x3E1D8A0
	|-List<BattleInfo.SupportData>.Add
	|
	|-RVA: 0x3E207C0 Offset: 0x3E208C1 VA: 0x3E207C0
	|-List<BeforeRenderHelper.OrderBlock>.Add
	|
	|-RVA: 0x3E23760 Offset: 0x3E23861 VA: 0x3E23760
	|-List<Camera.RenderRequest>.Add
	|
	|-RVA: 0x3E26910 Offset: 0x3E26A11 VA: 0x3E26910
	|-List<CameraState.CustomBlendable>.Add
	|
	|-RVA: 0x3E29800 Offset: 0x3E29901 VA: 0x3E29800
	|-List<CinemachineClearShot.Pair>.Add
	|
	|-RVA: 0x3E2C610 Offset: 0x3E2C711 VA: 0x3E2C610
	|-List<CinemachineStateDrivenCamera.HashPair>.Add
	|
	|-RVA: 0x3E2F4D0 Offset: 0x3E2F5D1 VA: 0x3E2F4D0
	|-List<DelayedActionManager.DelegateInfo>.Add
	|
	|-RVA: 0x3E32730 Offset: 0x3E32831 VA: 0x3E32730
	|-List<Detail.AsyncResultInt>.Add
	|
	|-RVA: 0x3E35A50 Offset: 0x3E35B51 VA: 0x3E35A50
	|-List<Detail.CppArray>.Add
	|
	|-RVA: 0x3E38A00 Offset: 0x3E38B01 VA: 0x3E38A00
	|-List<Detail.NotificationEventInt>.Add
	|
	|-RVA: 0x3E5B0F0 Offset: 0x3E5B1F1 VA: 0x3E5B0F0
	|-List<DragonRideTargetGroup.ChainParam>.Add
	|
	|-RVA: 0x3E5E090 Offset: 0x3E5E191 VA: 0x3E5E090
	|-List<GmapPathAdjuster.TargetModel>.Add
	|
	|-RVA: 0x3E612A0 Offset: 0x3E613A1 VA: 0x3E612A0
	|-List<GmapSpotAdjuster.TargetModel>.Add
	|
	|-RVA: 0x3E644B0 Offset: 0x3E645B1 VA: 0x3E644B0
	|-List<HubFastTravel.Location>.Add
	|
	|-RVA: 0x3E67710 Offset: 0x3E67811 VA: 0x3E67710
	|-List<HubLensFlare.Flare>.Add
	|
	|-RVA: 0x3E6AA80 Offset: 0x3E6AB81 VA: 0x3E6AA80
	|-List<InventoryPoolItemMenuContent.KindBgNameClass>.Add
	|
	|-RVA: 0x3E6D970 Offset: 0x3E6DA71 VA: 0x3E6D970
	|-List<Map.Pos>.Add
	|
	|-RVA: 0x3E707A0 Offset: 0x3E708A1 VA: 0x3E707A0
	|-List<MapImage.BackupTerrain>.Add
	|
	|-RVA: 0x3E73670 Offset: 0x3E73771 VA: 0x3E73670
	|-List<MapImageRange.Pos>.Add
	|
	|-RVA: 0x3E765B0 Offset: 0x3E766B1 VA: 0x3E765B0
	|-List<MapMind.Target>.Add
	|
	|-RVA: 0x3D861A0 Offset: 0x3D862A1 VA: 0x3D861A0
	|-List<MapPanelDebug.Entity>.Add
	|
	|-RVA: 0x3D892E0 Offset: 0x3D893E1 VA: 0x3D892E0
	|-List<NexRanking.Data>.Add
	|
	|-RVA: 0x3D8C110 Offset: 0x3D8C211 VA: 0x3D8C110
	|-List<NexVersus.RatingData>.Add
	|
	|-RVA: 0x3D8F000 Offset: 0x3D8F101 VA: 0x3D8F000
	|-List<PackedPlayModeBuildLogs.RuntimeBuildLog>.Add
	|
	|-RVA: 0x3D91FD0 Offset: 0x3D920D1 VA: 0x3D91FD0
	|-List<ParticleSystem.Particle>.Add
	|
	|-RVA: 0x3D952A0 Offset: 0x3D953A1 VA: 0x3D952A0
	|-List<RangeData.Offset>.Add
	|
	|-RVA: 0x3D98160 Offset: 0x3D98261 VA: 0x3D98160
	|-List<RenderGraphDebugData.PassDebugData>.Add
	|
	|-RVA: 0x3D9B3D0 Offset: 0x3D9B4D1 VA: 0x3D9B3D0
	|-List<RenderGraphDebugData.ResourceDebugData>.Add
	|
	|-RVA: 0x3D9E6D0 Offset: 0x3D9E7D1 VA: 0x3D9E6D0
	|-List<RingCleaningUnitSelectMenu.GodParam>.Add
	|
	|-RVA: 0x3DA16B0 Offset: 0x3DA17B1 VA: 0x3DA16B0
	|-List<ShadowUtility.Edge>.Add
	|
	|-RVA: 0x3D13E10 Offset: 0x3D13F11 VA: 0x3D13E10
	|-List<SkillArray.Entity>.Add
	|
	|-RVA: 0x3D16D50 Offset: 0x3D16E51 VA: 0x3D16D50
	|-List<TexturePacker_JsonArray.Frame>.Add
	|
	|-RVA: 0x3D1A290 Offset: 0x3D1A391 VA: 0x3D1A290
	|-List<TimeNotificationBehaviour.NotificationEntry>.Add
	|
	|-RVA: 0x3D1D4C0 Offset: 0x3D1D5C1 VA: 0x3D1D4C0
	|-List<UnitySynchronizationContext.WorkRequest>.Add
	|
	|-RVA: 0x3D20650 Offset: 0x3D20751 VA: 0x3D20650
	|-List<XmlSchemaObjectTable.XmlSchemaObjectEntry>.Add
	|
	|-RVA: 0x3D23570 Offset: 0x3D23671 VA: 0x3D23570
	|-List<AssetBundleBuildMap.AssetBundleEntry.AssetPathString>.Add
	|
	|-RVA: 0x3D26560 Offset: 0x3D26661 VA: 0x3D26560
	|-List<Detail.DataStore.DataStoreChangeMetaParamInt>.Add
	|
	|-RVA: 0x3D298A0 Offset: 0x3D299A1 VA: 0x3D298A0
	|-List<Detail.DataStore.DataStoreDeleteParamInt>.Add
	|
	|-RVA: 0x3D2C850 Offset: 0x3D2C951 VA: 0x3D2C850
	|-List<Detail.DataStore.DataStoreGetMetaParamInt>.Add
	|
	|-RVA: 0x3D2FBE0 Offset: 0x3D2FCE1 VA: 0x3D2FBE0
	|-List<Detail.DataStore.DataStoreMetaInfoInt>.Add
	|
	|-RVA: 0x3CF43E0 Offset: 0x3CF44E1 VA: 0x3CF43E0
	|-List<Detail.DataStore.DataStorePasswordInfoInt>.Add
	|
	|-RVA: 0x3CF75C0 Offset: 0x3CF76C1 VA: 0x3CF75C0
	|-List<Detail.DataStore.DataStorePersistenceInfoInt>.Add
	|
	|-RVA: 0x3CFA7E0 Offset: 0x3CFA8E1 VA: 0x3CFA7E0
	|-List<Detail.DataStore.DataStorePreparePostParamInt>.Add
	|
	|-RVA: 0x3CFDAD0 Offset: 0x3CFDBD1 VA: 0x3CFDAD0
	|-List<Detail.DataStore.DataStoreRateObjectParamInt>.Add
	|
	|-RVA: 0x3D00A30 Offset: 0x3D00B31 VA: 0x3D00A30
	|-List<Detail.DataStore.DataStoreRatingInitParamInt>.Add
	|
	|-RVA: 0x3D03BA0 Offset: 0x3D03CA1 VA: 0x3D03BA0
	|-List<Detail.DataStore.DataStoreRatingTargetInt>.Add
	|
	|-RVA: 0x3D06B80 Offset: 0x3D06C81 VA: 0x3D06B80
	|-List<Detail.Ranking.RankingCachedResultInt>.Add
	|
	|-RVA: 0x3D0A060 Offset: 0x3D0A161 VA: 0x3D0A060
	|-List<Detail.Ranking.RankingOrderParamInt>.Add
	|
	|-RVA: 0x3D0D040 Offset: 0x3D0D141 VA: 0x3D0D040
	|-List<Detail.Ranking.RankingRankDataInt>.Add
	|
	|-RVA: 0x3D10690 Offset: 0x3D10791 VA: 0x3D10690
	|-List<Detail.Ranking2.Ranking2ChartInfoInt>.Add
	|
	|-RVA: 0x3D66FC0 Offset: 0x3D670C1 VA: 0x3D66FC0
	|-List<Detail.Ranking2.Ranking2RankDataInt>.Add
	|
	|-RVA: 0x3D6A440 Offset: 0x3D6A541 VA: 0x3D6A440
	|-List<Detail.Ranking2.Ranking2ScoreDataInt>.Add
	|
	|-RVA: 0x3D6D3A0 Offset: 0x3D6D4A1 VA: 0x3D6D3A0
	|-List<Detail.Screening.ScreeningContextInfoInt>.Add
	|
	|-RVA: 0x3D70690 Offset: 0x3D70791 VA: 0x3D70690
	|-List<Detail.Subscriber.SubscriberContentInt>.Add
	|
	|-RVA: 0x3D73D60 Offset: 0x3D73E61 VA: 0x3D73D60
	|-List<Detail.Subscriber.SubscriberGetContentParamInt>.Add
	|
	|-RVA: 0x3D76F90 Offset: 0x3D77091 VA: 0x3D76F90
	|-List<Detail.Subscriber.SubscriberUserStatusInfoInt>.Add
	|
	|-RVA: 0x3D7A2E0 Offset: 0x3D7A3E1 VA: 0x3D7A2E0
	|-List<Detail.Subscriber.SubscriberUserStatusParamInt>.Add
	|
	|-RVA: 0x3D7D420 Offset: 0x3D7D521 VA: 0x3D7D420
	|-List<Detail.Utility.IntegerSettings>.Add
	|
	|-RVA: 0x3D80250 Offset: 0x3D80351 VA: 0x3D80250
	|-List<Detail.Utility.UniqueIdInfoInt>.Add
	|
	|-RVA: 0x3D83160 Offset: 0x3D83261 VA: 0x3D83160
	|-List<MapHistory.Rewind.LatestInspectorData>.Add
	|
	|-RVA: 0x305F420 Offset: 0x305F521 VA: 0x305F420
	|-List<MapHistory.Rewind.WorkTerrainData>.Add
	|
	|-RVA: 0x30623F0 Offset: 0x30624F1 VA: 0x30623F0
	|-List<MapSkill.AroundCalculator.Result>.Add
	|
	|-RVA: 0x30653D0 Offset: 0x30654D1 VA: 0x30653D0
	|-List<TargetPositionCache.CacheCurve.Item>.Add
	|
	|-RVA: 0x3068760 Offset: 0x3068861 VA: 0x3068760
	|-List<TargetPositionCache.CacheEntry.RecordingItem>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 20
	private int System.Collections.IList.Add(object item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3B0B150 Offset: 0x3B0B251 VA: 0x3B0B150
	|-List<IntervalTree.Entry<object>>.System.Collections.IList.Add
	|
	|-RVA: 0x3B0E2D0 Offset: 0x3B0E3D1 VA: 0x3B0E2D0
	|-List<KeyValuePair<DateTime, object>>.System.Collections.IList.Add
	|
	|-RVA: 0x3B111F0 Offset: 0x3B112F1 VA: 0x3B111F0
	|-List<KeyValuePair<int, object>>.System.Collections.IList.Add
	|
	|-RVA: 0x3B141A0 Offset: 0x3B142A1 VA: 0x3B141A0
	|-List<KeyValuePair<object, ValueTuple<int, DateTime, object>>>.System.Collections.IList.Add
	|
	|-RVA: 0x3B17330 Offset: 0x3B17431 VA: 0x3B17330
	|-List<KeyValuePair<object, object>>.System.Collections.IList.Add
	|
	|-RVA: 0x3B1A2E0 Offset: 0x3B1A3E1 VA: 0x3B1A2E0
	|-List<CommonBattleSequence.Reliance<object>>.System.Collections.IList.Add
	|
	|-RVA: 0x3B1D460 Offset: 0x3B1D561 VA: 0x3B1D460
	|-List<RenderGraphResourcePool.ResourceLogInfo<object>>.System.Collections.IList.Add
	|
	|-RVA: 0x3B20380 Offset: 0x3B20481 VA: 0x3B20380
	|-List<ValueTuple<int, object>>.System.Collections.IList.Add
	|
	|-RVA: 0x3DE0FC0 Offset: 0x3DE10C1 VA: 0x3DE0FC0
	|-List<ValueTuple<Int32Enum, int>>.System.Collections.IList.Add
	|
	|-RVA: 0x3DE3EB0 Offset: 0x3DE3FB1 VA: 0x3DE3EB0
	|-List<ValueTuple<object, ValueTuple<object, int>>>.System.Collections.IList.Add
	|
	|-RVA: 0x3DE7030 Offset: 0x3DE7131 VA: 0x3DE7030
	|-List<ValueTuple<object, int>>.System.Collections.IList.Add
	|
	|-RVA: 0x3DE9F80 Offset: 0x3DEA081 VA: 0x3DE9F80
	|-List<ValueTuple<Vector3, float>>.System.Collections.IList.Add
	|
	|-RVA: 0x3DECF50 Offset: 0x3DED051 VA: 0x3DECF50
	|-List<ValueTuple<object, Int32Enum, int>>.System.Collections.IList.Add
	|
	|-RVA: 0x3DEFF00 Offset: 0x3DF0001 VA: 0x3DEFF00
	|-List<ValueTuple<object, int, int, int>>.System.Collections.IList.Add
	|
	|-RVA: 0x3DF3030 Offset: 0x3DF3131 VA: 0x3DF3030
	|-List<AnimatorClipInfo>.System.Collections.IList.Add
	|
	|-RVA: 0x3DF5F20 Offset: 0x3DF6021 VA: 0x3DF5F20
	|-List<AsyncOperationHandle>.System.Collections.IList.Add
	|
	|-RVA: 0x3DF9120 Offset: 0x3DF9221 VA: 0x3DF9120
	|-List<BoneWeight>.System.Collections.IList.Add
	|
	|-RVA: 0x3DFC250 Offset: 0x3DFC351 VA: 0x3DFC250
	|-List<bool>.System.Collections.IList.Add
	|
	|-RVA: 0x3E797A0 Offset: 0x3E798A1 VA: 0x3E797A0
	|-List<byte>.System.Collections.IList.Add
	|
	|-RVA: 0x3E11080 Offset: 0x3E11181 VA: 0x3E11080
	|-List<Camera>.System.Collections.IList.Add
	|-List<Decorator>.System.Collections.IList.Add
	|-List<DynValue>.System.Collections.IList.Add
	|-List<GameObject>.System.Collections.IList.Add
	|-List<MapBackup>.System.Collections.IList.Add
	|-List<object>.System.Collections.IList.Add
	|-List<Phase>.System.Collections.IList.Add
	|-List<ProfileCard>.System.Collections.IList.Add
	|-List<Unit>.System.Collections.IList.Add
	|-List<AssetTable.Accessory>.System.Collections.IList.Add
	|-List<GameSaveDataHeaderReader.Handle>.System.Collections.IList.Add
	|-List<MapDispos.ActualData>.System.Collections.IList.Add
	|-List<MapDispos.Pos>.System.Collections.IList.Add
	|-List<MapLayer.Data>.System.Collections.IList.Add
	|-List<MapObject.RigidInfo>.System.Collections.IList.Add
	|-List<RingListSequence.PageData>.System.Collections.IList.Add
	|
	|-RVA: 0x3E7C600 Offset: 0x3E7C701 VA: 0x3E7C600
	|-List<CameraInfo>.System.Collections.IList.Add
	|
	|-RVA: 0x3E7F4D0 Offset: 0x3E7F5D1 VA: 0x3E7F4D0
	|-List<char>.System.Collections.IList.Add
	|
	|-RVA: 0x3E82350 Offset: 0x3E82451 VA: 0x3E82350
	|-List<Color>.System.Collections.IList.Add
	|
	|-RVA: 0x3E852D0 Offset: 0x3E853D1 VA: 0x3E852D0
	|-List<Color32>.System.Collections.IList.Add
	|
	|-RVA: 0x3E88130 Offset: 0x3E88231 VA: 0x3E88130
	|-List<ConstraintSource>.System.Collections.IList.Add
	|
	|-RVA: 0x3E8B0E0 Offset: 0x3E8B1E1 VA: 0x3E8B0E0
	|-List<ContourVertex>.System.Collections.IList.Add
	|
	|-RVA: 0x3E8E2E0 Offset: 0x3E8E3E1 VA: 0x3E8E2E0
	|-List<DataStoreRatingInfo>.System.Collections.IList.Add
	|
	|-RVA: 0x3E913F0 Offset: 0x3E914F1 VA: 0x3E913F0
	|-List<DataStoreResult>.System.Collections.IList.Add
	|
	|-RVA: 0x3E94200 Offset: 0x3E94301 VA: 0x3E94200
	|-List<DateTime>.System.Collections.IList.Add
	|
	|-RVA: 0x3E97040 Offset: 0x3E97141 VA: 0x3E97040
	|-List<DateTimeOffset>.System.Collections.IList.Add
	|
	|-RVA: 0x3E99F20 Offset: 0x3E9A021 VA: 0x3E99F20
	|-List<Decimal>.System.Collections.IList.Add
	|
	|-RVA: 0x3E9CF20 Offset: 0x3E9D021 VA: 0x3E9CF20
	|-List<DiagnosticEvent>.System.Collections.IList.Add
	|
	|-RVA: 0x3EA0220 Offset: 0x3EA0321 VA: 0x3EA0220
	|-List<double>.System.Collections.IList.Add
	|
	|-RVA: 0x3EA3140 Offset: 0x3EA3241 VA: 0x3EA3140
	|-List<Friend>.System.Collections.IList.Add
	|
	|-RVA: 0x3EA63F0 Offset: 0x3EA64F1 VA: 0x3EA63F0
	|-List<GlyphRect>.System.Collections.IList.Add
	|
	|-RVA: 0x3EA92A0 Offset: 0x3EA93A1 VA: 0x3EA92A0
	|-List<short>.System.Collections.IList.Add
	|
	|-RVA: 0x3EAC0A0 Offset: 0x3EAC1A1 VA: 0x3EAC0A0
	|-List<int>.System.Collections.IList.Add
	|
	|-RVA: 0x3EAEEA0 Offset: 0x3EAEFA1 VA: 0x3EAEEA0
	|-List<Int32Enum>.System.Collections.IList.Add
	|
	|-RVA: 0x3EB1CA0 Offset: 0x3EB1DA1 VA: 0x3EB1CA0
	|-List<long>.System.Collections.IList.Add
	|
	|-RVA: 0x3DFF070 Offset: 0x3DFF171 VA: 0x3DFF070
	|-List<IntPtr>.System.Collections.IList.Add
	|
	|-RVA: 0x3E01EC0 Offset: 0x3E01FC1 VA: 0x3E01EC0
	|-List<InterpretedFrameInfo>.System.Collections.IList.Add
	|
	|-RVA: 0x3E04E60 Offset: 0x3E04F61 VA: 0x3E04E60
	|-List<IntervalTreeNode>.System.Collections.IList.Add
	|
	|-RVA: 0x3E07F70 Offset: 0x3E08071 VA: 0x3E07F70
	|-List<LengthLimitProperties>.System.Collections.IList.Add
	|
	|-RVA: 0x3E0AD80 Offset: 0x3E0AE81 VA: 0x3E0AD80
	|-List<MapPos>.System.Collections.IList.Add
	|
	|-RVA: 0x3E0DD00 Offset: 0x3E0DE01 VA: 0x3E0DD00
	|-List<Matrix4x4>.System.Collections.IList.Add
	|
	|-RVA: 0x3E14020 Offset: 0x3E14121 VA: 0x3E14020
	|-List<ObjectInitializationData>.System.Collections.IList.Add
	|
	|-RVA: 0x3E173F0 Offset: 0x3E174F1 VA: 0x3E173F0
	|-List<PlayableBinding>.System.Collections.IList.Add
	|
	|-RVA: 0x3E1A670 Offset: 0x3E1A771 VA: 0x3E1A670
	|-List<PlayerLoopSystem>.System.Collections.IList.Add
	|
	|-RVA: 0x3DA4B10 Offset: 0x3DA4C11 VA: 0x3DA4B10
	|-List<PlayerLoopSystemInternal>.System.Collections.IList.Add
	|
	|-RVA: 0x3DA7DF0 Offset: 0x3DA7EF1 VA: 0x3DA7DF0
	|-List<RangePositionInfo>.System.Collections.IList.Add
	|
	|-RVA: 0x3DAACC0 Offset: 0x3DAADC1 VA: 0x3DAACC0
	|-List<Ranking2ChartInfoInput>.System.Collections.IList.Add
	|
	|-RVA: 0x3DADC20 Offset: 0x3DADD21 VA: 0x3DADC20
	|-List<RaycastHit2D>.System.Collections.IList.Add
	|
	|-RVA: 0x3DB1100 Offset: 0x3DB1201 VA: 0x3DB1100
	|-List<RaycastResult>.System.Collections.IList.Add
	|
	|-RVA: 0x3DB4780 Offset: 0x3DB4881 VA: 0x3DB4780
	|-List<Rect>.System.Collections.IList.Add
	|
	|-RVA: 0x3DB7700 Offset: 0x3DB7801 VA: 0x3DB7700
	|-List<RendererListHandle>.System.Collections.IList.Add
	|
	|-RVA: 0x3DBA510 Offset: 0x3DBA611 VA: 0x3DBA510
	|-List<ResourceHandle>.System.Collections.IList.Add
	|
	|-RVA: 0x3DBD320 Offset: 0x3DBD421 VA: 0x3DBD320
	|-List<sbyte>.System.Collections.IList.Add
	|
	|-RVA: 0x3DC0130 Offset: 0x3DC0231 VA: 0x3DC0130
	|-List<ShaderTagId>.System.Collections.IList.Add
	|
	|-RVA: 0x3E3BDA0 Offset: 0x3E3BEA1 VA: 0x3E3BDA0
	|-List<float>.System.Collections.IList.Add
	|
	|-RVA: 0x3E3EEC0 Offset: 0x3E3EFC1 VA: 0x3E3EEC0
	|-List<SphericalHarmonicsL2>.System.Collections.IList.Add
	|
	|-RVA: 0x3E429C0 Offset: 0x3E42AC1 VA: 0x3E429C0
	|-List<SubMeshDescriptor>.System.Collections.IList.Add
	|
	|-RVA: 0x3E45CD0 Offset: 0x3E45DD1 VA: 0x3E45CD0
	|-List<TablePair>.System.Collections.IList.Add
	|
	|-RVA: 0x3E48BA0 Offset: 0x3E48CA1 VA: 0x3E48BA0
	|-List<TimeSpan>.System.Collections.IList.Add
	|
	|-RVA: 0x3E4BA10 Offset: 0x3E4BB11 VA: 0x3E4BA10
	|-List<UICharInfo>.System.Collections.IList.Add
	|
	|-RVA: 0x3E4E9C0 Offset: 0x3E4EAC1 VA: 0x3E4E9C0
	|-List<UILineInfo>.System.Collections.IList.Add
	|
	|-RVA: 0x3E51B80 Offset: 0x3E51C81 VA: 0x3E51B80
	|-List<UIVertex>.System.Collections.IList.Add
	|
	|-RVA: 0x3E55550 Offset: 0x3E55651 VA: 0x3E55550
	|-List<ushort>.System.Collections.IList.Add
	|
	|-RVA: 0x3E58350 Offset: 0x3E58451 VA: 0x3E58350
	|-List<uint>.System.Collections.IList.Add
	|
	|-RVA: 0x3DC2F40 Offset: 0x3DC3041 VA: 0x3DC2F40
	|-List<ulong>.System.Collections.IList.Add
	|
	|-RVA: 0x3DC5D60 Offset: 0x3DC5E61 VA: 0x3DC5D60
	|-List<Vector2>.System.Collections.IList.Add
	|
	|-RVA: 0x3DC8C70 Offset: 0x3DC8D71 VA: 0x3DC8C70
	|-List<Vector3>.System.Collections.IList.Add
	|
	|-RVA: 0x3DCBC70 Offset: 0x3DCBD71 VA: 0x3DCBC70
	|-List<Vector4>.System.Collections.IList.Add
	|
	|-RVA: 0x3DCEC20 Offset: 0x3DCED21 VA: 0x3DCEC20
	|-List<VertexAttributeDescriptor>.System.Collections.IList.Add
	|
	|-RVA: 0x3DD1B20 Offset: 0x3DD1C21 VA: 0x3DD1B20
	|-List<X509ChainStatus>.System.Collections.IList.Add
	|
	|-RVA: 0x3DD4B20 Offset: 0x3DD4C21 VA: 0x3DD4B20
	|-List<XRView>.System.Collections.IList.Add
	|
	|-RVA: 0x3DD7E30 Offset: 0x3DD7F31 VA: 0x3DD7E30
	|-List<AmiiboSequence.GainItemData>.System.Collections.IList.Add
	|
	|-RVA: 0x3DDAE30 Offset: 0x3DDAF31 VA: 0x3DDAE30
	|-List<AnimationOutputWeightProcessor.WeightInfo>.System.Collections.IList.Add
	|
	|-RVA: 0x3DDE0F0 Offset: 0x3DDE1F1 VA: 0x3DDE0F0
	|-List<ArenaOrderSequence.GodInfo>.System.Collections.IList.Add
	|
	|-RVA: 0x3E1D950 Offset: 0x3E1DA51 VA: 0x3E1D950
	|-List<BattleInfo.SupportData>.System.Collections.IList.Add
	|
	|-RVA: 0x3E20870 Offset: 0x3E20971 VA: 0x3E20870
	|-List<BeforeRenderHelper.OrderBlock>.System.Collections.IList.Add
	|
	|-RVA: 0x3E23830 Offset: 0x3E23931 VA: 0x3E23830
	|-List<Camera.RenderRequest>.System.Collections.IList.Add
	|
	|-RVA: 0x3E269C0 Offset: 0x3E26AC1 VA: 0x3E269C0
	|-List<CameraState.CustomBlendable>.System.Collections.IList.Add
	|
	|-RVA: 0x3E29890 Offset: 0x3E29991 VA: 0x3E29890
	|-List<CinemachineClearShot.Pair>.System.Collections.IList.Add
	|
	|-RVA: 0x3E2C6A0 Offset: 0x3E2C7A1 VA: 0x3E2C6A0
	|-List<CinemachineStateDrivenCamera.HashPair>.System.Collections.IList.Add
	|
	|-RVA: 0x3E2F590 Offset: 0x3E2F691 VA: 0x3E2F590
	|-List<DelayedActionManager.DelegateInfo>.System.Collections.IList.Add
	|
	|-RVA: 0x3E32800 Offset: 0x3E32901 VA: 0x3E32800
	|-List<Detail.AsyncResultInt>.System.Collections.IList.Add
	|
	|-RVA: 0x3E35AF0 Offset: 0x3E35BF1 VA: 0x3E35AF0
	|-List<Detail.CppArray>.System.Collections.IList.Add
	|
	|-RVA: 0x3E38AD0 Offset: 0x3E38BD1 VA: 0x3E38AD0
	|-List<Detail.NotificationEventInt>.System.Collections.IList.Add
	|
	|-RVA: 0x3E5B1A0 Offset: 0x3E5B2A1 VA: 0x3E5B1A0
	|-List<DragonRideTargetGroup.ChainParam>.System.Collections.IList.Add
	|
	|-RVA: 0x3E5E150 Offset: 0x3E5E251 VA: 0x3E5E150
	|-List<GmapPathAdjuster.TargetModel>.System.Collections.IList.Add
	|
	|-RVA: 0x3E61360 Offset: 0x3E61461 VA: 0x3E61360
	|-List<GmapSpotAdjuster.TargetModel>.System.Collections.IList.Add
	|
	|-RVA: 0x3E64570 Offset: 0x3E64671 VA: 0x3E64570
	|-List<HubFastTravel.Location>.System.Collections.IList.Add
	|
	|-RVA: 0x3E677F0 Offset: 0x3E678F1 VA: 0x3E677F0
	|-List<HubLensFlare.Flare>.System.Collections.IList.Add
	|
	|-RVA: 0x3E6AB30 Offset: 0x3E6AC31 VA: 0x3E6AB30
	|-List<InventoryPoolItemMenuContent.KindBgNameClass>.System.Collections.IList.Add
	|
	|-RVA: 0x3E6DA00 Offset: 0x3E6DB01 VA: 0x3E6DA00
	|-List<Map.Pos>.System.Collections.IList.Add
	|
	|-RVA: 0x3E70840 Offset: 0x3E70941 VA: 0x3E70840
	|-List<MapImage.BackupTerrain>.System.Collections.IList.Add
	|
	|-RVA: 0x3E73700 Offset: 0x3E73801 VA: 0x3E73700
	|-List<MapImageRange.Pos>.System.Collections.IList.Add
	|
	|-RVA: 0x3E76670 Offset: 0x3E76771 VA: 0x3E76670
	|-List<MapMind.Target>.System.Collections.IList.Add
	|
	|-RVA: 0x3D86260 Offset: 0x3D86361 VA: 0x3D86260
	|-List<MapPanelDebug.Entity>.System.Collections.IList.Add
	|
	|-RVA: 0x3D89370 Offset: 0x3D89471 VA: 0x3D89370
	|-List<NexRanking.Data>.System.Collections.IList.Add
	|
	|-RVA: 0x3D8C1B0 Offset: 0x3D8C2B1 VA: 0x3D8C1B0
	|-List<NexVersus.RatingData>.System.Collections.IList.Add
	|
	|-RVA: 0x3D8F0B0 Offset: 0x3D8F1B1 VA: 0x3D8F0B0
	|-List<PackedPlayModeBuildLogs.RuntimeBuildLog>.System.Collections.IList.Add
	|
	|-RVA: 0x3D920A0 Offset: 0x3D921A1 VA: 0x3D920A0
	|-List<ParticleSystem.Particle>.System.Collections.IList.Add
	|
	|-RVA: 0x3D95330 Offset: 0x3D95431 VA: 0x3D95330
	|-List<RangeData.Offset>.System.Collections.IList.Add
	|
	|-RVA: 0x3D98220 Offset: 0x3D98321 VA: 0x3D98220
	|-List<RenderGraphDebugData.PassDebugData>.System.Collections.IList.Add
	|
	|-RVA: 0x3D9B4A0 Offset: 0x3D9B5A1 VA: 0x3D9B4A0
	|-List<RenderGraphDebugData.ResourceDebugData>.System.Collections.IList.Add
	|
	|-RVA: 0x3D9E780 Offset: 0x3D9E881 VA: 0x3D9E780
	|-List<RingCleaningUnitSelectMenu.GodParam>.System.Collections.IList.Add
	|
	|-RVA: 0x3DA1780 Offset: 0x3DA1881 VA: 0x3DA1780
	|-List<ShadowUtility.Edge>.System.Collections.IList.Add
	|
	|-RVA: 0x3D13EA0 Offset: 0x3D13FA1 VA: 0x3D13EA0
	|-List<SkillArray.Entity>.System.Collections.IList.Add
	|
	|-RVA: 0x3D16E30 Offset: 0x3D16F31 VA: 0x3D16E30
	|-List<TexturePacker_JsonArray.Frame>.System.Collections.IList.Add
	|
	|-RVA: 0x3D1A360 Offset: 0x3D1A461 VA: 0x3D1A360
	|-List<TimeNotificationBehaviour.NotificationEntry>.System.Collections.IList.Add
	|
	|-RVA: 0x3D1D580 Offset: 0x3D1D681 VA: 0x3D1D580
	|-List<UnitySynchronizationContext.WorkRequest>.System.Collections.IList.Add
	|
	|-RVA: 0x3D20700 Offset: 0x3D20801 VA: 0x3D20700
	|-List<XmlSchemaObjectTable.XmlSchemaObjectEntry>.System.Collections.IList.Add
	|
	|-RVA: 0x3D23620 Offset: 0x3D23721 VA: 0x3D23620
	|-List<AssetBundleBuildMap.AssetBundleEntry.AssetPathString>.System.Collections.IList.Add
	|
	|-RVA: 0x3D26630 Offset: 0x3D26731 VA: 0x3D26630
	|-List<Detail.DataStore.DataStoreChangeMetaParamInt>.System.Collections.IList.Add
	|
	|-RVA: 0x3D29940 Offset: 0x3D29A41 VA: 0x3D29940
	|-List<Detail.DataStore.DataStoreDeleteParamInt>.System.Collections.IList.Add
	|
	|-RVA: 0x3D2C920 Offset: 0x3D2CA21 VA: 0x3D2C920
	|-List<Detail.DataStore.DataStoreGetMetaParamInt>.System.Collections.IList.Add
	|
	|-RVA: 0x3D2FCB0 Offset: 0x3D2FDB1 VA: 0x3D2FCB0
	|-List<Detail.DataStore.DataStoreMetaInfoInt>.System.Collections.IList.Add
	|
	|-RVA: 0x3CF44A0 Offset: 0x3CF45A1 VA: 0x3CF44A0
	|-List<Detail.DataStore.DataStorePasswordInfoInt>.System.Collections.IList.Add
	|
	|-RVA: 0x3CF7680 Offset: 0x3CF7781 VA: 0x3CF7680
	|-List<Detail.DataStore.DataStorePersistenceInfoInt>.System.Collections.IList.Add
	|
	|-RVA: 0x3CFA8B0 Offset: 0x3CFA9B1 VA: 0x3CFA8B0
	|-List<Detail.DataStore.DataStorePreparePostParamInt>.System.Collections.IList.Add
	|
	|-RVA: 0x3CFDB70 Offset: 0x3CFDC71 VA: 0x3CFDB70
	|-List<Detail.DataStore.DataStoreRateObjectParamInt>.System.Collections.IList.Add
	|
	|-RVA: 0x3D00AF0 Offset: 0x3D00BF1 VA: 0x3D00AF0
	|-List<Detail.DataStore.DataStoreRatingInitParamInt>.System.Collections.IList.Add
	|
	|-RVA: 0x3D03C40 Offset: 0x3D03D41 VA: 0x3D03C40
	|-List<Detail.DataStore.DataStoreRatingTargetInt>.System.Collections.IList.Add
	|
	|-RVA: 0x3D06C60 Offset: 0x3D06D61 VA: 0x3D06C60
	|-List<Detail.Ranking.RankingCachedResultInt>.System.Collections.IList.Add
	|
	|-RVA: 0x3D0A100 Offset: 0x3D0A201 VA: 0x3D0A100
	|-List<Detail.Ranking.RankingOrderParamInt>.System.Collections.IList.Add
	|
	|-RVA: 0x3D0D120 Offset: 0x3D0D221 VA: 0x3D0D120
	|-List<Detail.Ranking.RankingRankDataInt>.System.Collections.IList.Add
	|
	|-RVA: 0x3D10790 Offset: 0x3D10891 VA: 0x3D10790
	|-List<Detail.Ranking2.Ranking2ChartInfoInt>.System.Collections.IList.Add
	|
	|-RVA: 0x3D670A0 Offset: 0x3D671A1 VA: 0x3D670A0
	|-List<Detail.Ranking2.Ranking2RankDataInt>.System.Collections.IList.Add
	|
	|-RVA: 0x3D6A4E0 Offset: 0x3D6A5E1 VA: 0x3D6A4E0
	|-List<Detail.Ranking2.Ranking2ScoreDataInt>.System.Collections.IList.Add
	|
	|-RVA: 0x3D6D460 Offset: 0x3D6D561 VA: 0x3D6D460
	|-List<Detail.Screening.ScreeningContextInfoInt>.System.Collections.IList.Add
	|
	|-RVA: 0x3D70780 Offset: 0x3D70881 VA: 0x3D70780
	|-List<Detail.Subscriber.SubscriberContentInt>.System.Collections.IList.Add
	|
	|-RVA: 0x3D73E20 Offset: 0x3D73F21 VA: 0x3D73E20
	|-List<Detail.Subscriber.SubscriberGetContentParamInt>.System.Collections.IList.Add
	|
	|-RVA: 0x3D77060 Offset: 0x3D77161 VA: 0x3D77060
	|-List<Detail.Subscriber.SubscriberUserStatusInfoInt>.System.Collections.IList.Add
	|
	|-RVA: 0x3D7A3A0 Offset: 0x3D7A4A1 VA: 0x3D7A3A0
	|-List<Detail.Subscriber.SubscriberUserStatusParamInt>.System.Collections.IList.Add
	|
	|-RVA: 0x3D7D4B0 Offset: 0x3D7D5B1 VA: 0x3D7D4B0
	|-List<Detail.Utility.IntegerSettings>.System.Collections.IList.Add
	|
	|-RVA: 0x3D802F0 Offset: 0x3D803F1 VA: 0x3D802F0
	|-List<Detail.Utility.UniqueIdInfoInt>.System.Collections.IList.Add
	|
	|-RVA: 0x3D83200 Offset: 0x3D83301 VA: 0x3D83200
	|-List<MapHistory.Rewind.LatestInspectorData>.System.Collections.IList.Add
	|
	|-RVA: 0x305F4C0 Offset: 0x305F5C1 VA: 0x305F4C0
	|-List<MapHistory.Rewind.WorkTerrainData>.System.Collections.IList.Add
	|
	|-RVA: 0x30624A0 Offset: 0x30625A1 VA: 0x30624A0
	|-List<MapSkill.AroundCalculator.Result>.System.Collections.IList.Add
	|
	|-RVA: 0x30654A0 Offset: 0x30655A1 VA: 0x30654A0
	|-List<TargetPositionCache.CacheCurve.Item>.System.Collections.IList.Add
	|
	|-RVA: 0x3068840 Offset: 0x3068941 VA: 0x3068840
	|-List<TargetPositionCache.CacheEntry.RecordingItem>.System.Collections.IList.Add
	*/

	// RVA: -1 Offset: -1
	public void AddRange(IEnumerable<T> collection) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3B0B310 Offset: 0x3B0B411 VA: 0x3B0B310
	|-List<IntervalTree.Entry<object>>.AddRange
	|
	|-RVA: 0x3B0E480 Offset: 0x3B0E581 VA: 0x3B0E480
	|-List<KeyValuePair<DateTime, object>>.AddRange
	|
	|-RVA: 0x3B113A0 Offset: 0x3B114A1 VA: 0x3B113A0
	|-List<KeyValuePair<int, object>>.AddRange
	|
	|-RVA: 0x3B14360 Offset: 0x3B14461 VA: 0x3B14360
	|-List<KeyValuePair<object, ValueTuple<int, DateTime, object>>>.AddRange
	|
	|-RVA: 0x3B174E0 Offset: 0x3B175E1 VA: 0x3B174E0
	|-List<KeyValuePair<object, object>>.AddRange
	|
	|-RVA: 0x3B1A4A0 Offset: 0x3B1A5A1 VA: 0x3B1A4A0
	|-List<CommonBattleSequence.Reliance<object>>.AddRange
	|
	|-RVA: 0x3B1D610 Offset: 0x3B1D711 VA: 0x3B1D610
	|-List<RenderGraphResourcePool.ResourceLogInfo<object>>.AddRange
	|
	|-RVA: 0x3B20530 Offset: 0x3B20631 VA: 0x3B20530
	|-List<ValueTuple<int, object>>.AddRange
	|
	|-RVA: 0x3DE1170 Offset: 0x3DE1271 VA: 0x3DE1170
	|-List<ValueTuple<Int32Enum, int>>.AddRange
	|
	|-RVA: 0x3DE4070 Offset: 0x3DE4171 VA: 0x3DE4070
	|-List<ValueTuple<object, ValueTuple<object, int>>>.AddRange
	|
	|-RVA: 0x3DE71E0 Offset: 0x3DE72E1 VA: 0x3DE71E0
	|-List<ValueTuple<object, int>>.AddRange
	|
	|-RVA: 0x3DEA130 Offset: 0x3DEA231 VA: 0x3DEA130
	|-List<ValueTuple<Vector3, float>>.AddRange
	|
	|-RVA: 0x3DED100 Offset: 0x3DED201 VA: 0x3DED100
	|-List<ValueTuple<object, Int32Enum, int>>.AddRange
	|
	|-RVA: 0x3DF00C0 Offset: 0x3DF01C1 VA: 0x3DF00C0
	|-List<ValueTuple<object, int, int, int>>.AddRange
	|
	|-RVA: 0x3E11220 Offset: 0x3E11321 VA: 0x3E11220
	|-List<AkAudioListener>.AddRange
	|-List<AnimationClip>.AddRange
	|-List<BaseInvokableCall>.AddRange
	|-List<BasicMenuItem>.AddRange
	|-List<DynValue>.AddRange
	|-List<ExceptionDispatchInfo>.AddRange
	|-List<ForecastFishData>.AddRange
	|-List<GodUnit>.AddRange
	|-List<IMarker>.AddRange
	|-List<IMenuElement>.AddRange
	|-List<IOverloadableMemberDescriptor>.AddRange
	|-List<IResourceLocation>.AddRange
	|-List<Image>.AddRange
	|-List<JobData>.AddRange
	|-List<object>.AddRange
	|-List<RankingRankData>.AddRange
	|-List<string>.AddRange
	|-List<TimeZoneInfo>.AddRange
	|-List<TimelineClip>.AddRange
	|-List<TrackAsset>.AddRange
	|-List<Transform>.AddRange
	|-List<Unit>.AddRange
	|-List<WatchItem>.AddRange
	|-List<ClassChange.ChangeJobData>.AddRange
	|-List<Dropdown.OptionData>.AddRange
	|-List<DynamicsSetup.ParseMessage>.AddRange
	|-List<GameSaveDataHeaderReader.Handle>.AddRange
	|-List<SpringBoneSerialization.PivotSerializer>.AddRange
	|-List<SpringBoneSerialization.SpringBoneSerializer>.AddRange
	|-List<SpringColliderSerialization.IColliderSerializer>.AddRange
	|-List<SpringColliderSerialization.TransformSerializer>.AddRange
	|-List<TMP_Dropdown.OptionData>.AddRange
	|-List<TimeZoneInfo.AdjustmentRule>.AddRange
	|
	|-RVA: 0x3DF31E0 Offset: 0x3DF32E1 VA: 0x3DF31E0
	|-List<AnimatorClipInfo>.AddRange
	|
	|-RVA: 0x3DF60E0 Offset: 0x3DF61E1 VA: 0x3DF60E0
	|-List<AsyncOperationHandle>.AddRange
	|
	|-RVA: 0x3DF92E0 Offset: 0x3DF93E1 VA: 0x3DF92E0
	|-List<BoneWeight>.AddRange
	|
	|-RVA: 0x3DFC400 Offset: 0x3DFC501 VA: 0x3DFC400
	|-List<bool>.AddRange
	|
	|-RVA: 0x3E79950 Offset: 0x3E79A51 VA: 0x3E79950
	|-List<byte>.AddRange
	|
	|-RVA: 0x3E7C7B0 Offset: 0x3E7C8B1 VA: 0x3E7C7B0
	|-List<CameraInfo>.AddRange
	|
	|-RVA: 0x3E7F680 Offset: 0x3E7F781 VA: 0x3E7F680
	|-List<char>.AddRange
	|
	|-RVA: 0x3E82500 Offset: 0x3E82601 VA: 0x3E82500
	|-List<Color>.AddRange
	|
	|-RVA: 0x3E85480 Offset: 0x3E85581 VA: 0x3E85480
	|-List<Color32>.AddRange
	|
	|-RVA: 0x3E882E0 Offset: 0x3E883E1 VA: 0x3E882E0
	|-List<ConstraintSource>.AddRange
	|
	|-RVA: 0x3E8B2A0 Offset: 0x3E8B3A1 VA: 0x3E8B2A0
	|-List<ContourVertex>.AddRange
	|
	|-RVA: 0x3E8E4A0 Offset: 0x3E8E5A1 VA: 0x3E8E4A0
	|-List<DataStoreRatingInfo>.AddRange
	|
	|-RVA: 0x3E915A0 Offset: 0x3E916A1 VA: 0x3E915A0
	|-List<DataStoreResult>.AddRange
	|
	|-RVA: 0x3E943B0 Offset: 0x3E944B1 VA: 0x3E943B0
	|-List<DateTime>.AddRange
	|
	|-RVA: 0x3E971F0 Offset: 0x3E972F1 VA: 0x3E971F0
	|-List<DateTimeOffset>.AddRange
	|
	|-RVA: 0x3E9A0D0 Offset: 0x3E9A1D1 VA: 0x3E9A0D0
	|-List<Decimal>.AddRange
	|
	|-RVA: 0x3E9D0F0 Offset: 0x3E9D1F1 VA: 0x3E9D0F0
	|-List<DiagnosticEvent>.AddRange
	|
	|-RVA: 0x3EA03D0 Offset: 0x3EA04D1 VA: 0x3EA03D0
	|-List<double>.AddRange
	|
	|-RVA: 0x3EA3300 Offset: 0x3EA3401 VA: 0x3EA3300
	|-List<Friend>.AddRange
	|
	|-RVA: 0x3EA65A0 Offset: 0x3EA66A1 VA: 0x3EA65A0
	|-List<GlyphRect>.AddRange
	|
	|-RVA: 0x3EA9450 Offset: 0x3EA9551 VA: 0x3EA9450
	|-List<short>.AddRange
	|
	|-RVA: 0x3EAC250 Offset: 0x3EAC351 VA: 0x3EAC250
	|-List<int>.AddRange
	|
	|-RVA: 0x3EAF050 Offset: 0x3EAF151 VA: 0x3EAF050
	|-List<Int32Enum>.AddRange
	|
	|-RVA: 0x3EB1E50 Offset: 0x3EB1F51 VA: 0x3EB1E50
	|-List<long>.AddRange
	|
	|-RVA: 0x3DFF220 Offset: 0x3DFF321 VA: 0x3DFF220
	|-List<IntPtr>.AddRange
	|
	|-RVA: 0x3E02070 Offset: 0x3E02171 VA: 0x3E02070
	|-List<InterpretedFrameInfo>.AddRange
	|
	|-RVA: 0x3E05020 Offset: 0x3E05121 VA: 0x3E05020
	|-List<IntervalTreeNode>.AddRange
	|
	|-RVA: 0x3E08120 Offset: 0x3E08221 VA: 0x3E08120
	|-List<LengthLimitProperties>.AddRange
	|
	|-RVA: 0x3E0AF30 Offset: 0x3E0B031 VA: 0x3E0AF30
	|-List<MapPos>.AddRange
	|
	|-RVA: 0x3E0DED0 Offset: 0x3E0DFD1 VA: 0x3E0DED0
	|-List<Matrix4x4>.AddRange
	|
	|-RVA: 0x3E141F0 Offset: 0x3E142F1 VA: 0x3E141F0
	|-List<ObjectInitializationData>.AddRange
	|
	|-RVA: 0x3E175B0 Offset: 0x3E176B1 VA: 0x3E175B0
	|-List<PlayableBinding>.AddRange
	|
	|-RVA: 0x3E1A840 Offset: 0x3E1A941 VA: 0x3E1A840
	|-List<PlayerLoopSystem>.AddRange
	|
	|-RVA: 0x3DA4CE0 Offset: 0x3DA4DE1 VA: 0x3DA4CE0
	|-List<PlayerLoopSystemInternal>.AddRange
	|
	|-RVA: 0x3DA7FA0 Offset: 0x3DA80A1 VA: 0x3DA7FA0
	|-List<RangePositionInfo>.AddRange
	|
	|-RVA: 0x3DAAE70 Offset: 0x3DAAF71 VA: 0x3DAAE70
	|-List<Ranking2ChartInfoInput>.AddRange
	|
	|-RVA: 0x3DADDF0 Offset: 0x3DADEF1 VA: 0x3DADDF0
	|-List<RaycastHit2D>.AddRange
	|
	|-RVA: 0x3DB12E0 Offset: 0x3DB13E1 VA: 0x3DB12E0
	|-List<RaycastResult>.AddRange
	|
	|-RVA: 0x3DB4930 Offset: 0x3DB4A31 VA: 0x3DB4930
	|-List<Rect>.AddRange
	|
	|-RVA: 0x3DB78B0 Offset: 0x3DB79B1 VA: 0x3DB78B0
	|-List<RendererListHandle>.AddRange
	|
	|-RVA: 0x3DBA6C0 Offset: 0x3DBA7C1 VA: 0x3DBA6C0
	|-List<ResourceHandle>.AddRange
	|
	|-RVA: 0x3DBD4D0 Offset: 0x3DBD5D1 VA: 0x3DBD4D0
	|-List<sbyte>.AddRange
	|
	|-RVA: 0x3DC02E0 Offset: 0x3DC03E1 VA: 0x3DC02E0
	|-List<ShaderTagId>.AddRange
	|
	|-RVA: 0x3E3BF50 Offset: 0x3E3C051 VA: 0x3E3BF50
	|-List<float>.AddRange
	|
	|-RVA: 0x3E3F0B0 Offset: 0x3E3F1B1 VA: 0x3E3F0B0
	|-List<SphericalHarmonicsL2>.AddRange
	|
	|-RVA: 0x3E42B90 Offset: 0x3E42C91 VA: 0x3E42B90
	|-List<SubMeshDescriptor>.AddRange
	|
	|-RVA: 0x3E45E80 Offset: 0x3E45F81 VA: 0x3E45E80
	|-List<TablePair>.AddRange
	|
	|-RVA: 0x3E48D50 Offset: 0x3E48E51 VA: 0x3E48D50
	|-List<TimeSpan>.AddRange
	|
	|-RVA: 0x3E4BBC0 Offset: 0x3E4BCC1 VA: 0x3E4BBC0
	|-List<UICharInfo>.AddRange
	|
	|-RVA: 0x3E4EB70 Offset: 0x3E4EC71 VA: 0x3E4EB70
	|-List<UILineInfo>.AddRange
	|
	|-RVA: 0x3E51D70 Offset: 0x3E51E71 VA: 0x3E51D70
	|-List<UIVertex>.AddRange
	|
	|-RVA: 0x3E55700 Offset: 0x3E55801 VA: 0x3E55700
	|-List<ushort>.AddRange
	|
	|-RVA: 0x3E58500 Offset: 0x3E58601 VA: 0x3E58500
	|-List<uint>.AddRange
	|
	|-RVA: 0x3DC30F0 Offset: 0x3DC31F1 VA: 0x3DC30F0
	|-List<ulong>.AddRange
	|
	|-RVA: 0x3DC5F10 Offset: 0x3DC6011 VA: 0x3DC5F10
	|-List<Vector2>.AddRange
	|
	|-RVA: 0x3DC8E20 Offset: 0x3DC8F21 VA: 0x3DC8E20
	|-List<Vector3>.AddRange
	|
	|-RVA: 0x3DCBE20 Offset: 0x3DCBF21 VA: 0x3DCBE20
	|-List<Vector4>.AddRange
	|
	|-RVA: 0x3DCEDD0 Offset: 0x3DCEED1 VA: 0x3DCEDD0
	|-List<VertexAttributeDescriptor>.AddRange
	|
	|-RVA: 0x3DD1CD0 Offset: 0x3DD1DD1 VA: 0x3DD1CD0
	|-List<X509ChainStatus>.AddRange
	|
	|-RVA: 0x3DD4CE0 Offset: 0x3DD4DE1 VA: 0x3DD4CE0
	|-List<XRView>.AddRange
	|
	|-RVA: 0x3DD7FE0 Offset: 0x3DD80E1 VA: 0x3DD7FE0
	|-List<AmiiboSequence.GainItemData>.AddRange
	|
	|-RVA: 0x3DDB000 Offset: 0x3DDB101 VA: 0x3DDB000
	|-List<AnimationOutputWeightProcessor.WeightInfo>.AddRange
	|
	|-RVA: 0x3DDE2A0 Offset: 0x3DDE3A1 VA: 0x3DDE2A0
	|-List<ArenaOrderSequence.GodInfo>.AddRange
	|
	|-RVA: 0x3E1DB00 Offset: 0x3E1DC01 VA: 0x3E1DB00
	|-List<BattleInfo.SupportData>.AddRange
	|
	|-RVA: 0x3E20A20 Offset: 0x3E20B21 VA: 0x3E20A20
	|-List<BeforeRenderHelper.OrderBlock>.AddRange
	|
	|-RVA: 0x3E239F0 Offset: 0x3E23AF1 VA: 0x3E239F0
	|-List<Camera.RenderRequest>.AddRange
	|
	|-RVA: 0x3E26B70 Offset: 0x3E26C71 VA: 0x3E26B70
	|-List<CameraState.CustomBlendable>.AddRange
	|
	|-RVA: 0x3E29A40 Offset: 0x3E29B41 VA: 0x3E29A40
	|-List<CinemachineClearShot.Pair>.AddRange
	|
	|-RVA: 0x3E2C850 Offset: 0x3E2C951 VA: 0x3E2C850
	|-List<CinemachineStateDrivenCamera.HashPair>.AddRange
	|
	|-RVA: 0x3E2F750 Offset: 0x3E2F851 VA: 0x3E2F750
	|-List<DelayedActionManager.DelegateInfo>.AddRange
	|
	|-RVA: 0x3E329D0 Offset: 0x3E32AD1 VA: 0x3E329D0
	|-List<Detail.AsyncResultInt>.AddRange
	|
	|-RVA: 0x3E35CA0 Offset: 0x3E35DA1 VA: 0x3E35CA0
	|-List<Detail.CppArray>.AddRange
	|
	|-RVA: 0x3E38CA0 Offset: 0x3E38DA1 VA: 0x3E38CA0
	|-List<Detail.NotificationEventInt>.AddRange
	|
	|-RVA: 0x3E5B350 Offset: 0x3E5B451 VA: 0x3E5B350
	|-List<DragonRideTargetGroup.ChainParam>.AddRange
	|
	|-RVA: 0x3E5E310 Offset: 0x3E5E411 VA: 0x3E5E310
	|-List<GmapPathAdjuster.TargetModel>.AddRange
	|
	|-RVA: 0x3E61520 Offset: 0x3E61621 VA: 0x3E61520
	|-List<GmapSpotAdjuster.TargetModel>.AddRange
	|
	|-RVA: 0x3E64730 Offset: 0x3E64831 VA: 0x3E64730
	|-List<HubFastTravel.Location>.AddRange
	|
	|-RVA: 0x3E679C0 Offset: 0x3E67AC1 VA: 0x3E679C0
	|-List<HubLensFlare.Flare>.AddRange
	|
	|-RVA: 0x3E6ACE0 Offset: 0x3E6ADE1 VA: 0x3E6ACE0
	|-List<InventoryPoolItemMenuContent.KindBgNameClass>.AddRange
	|
	|-RVA: 0x3E6DBB0 Offset: 0x3E6DCB1 VA: 0x3E6DBB0
	|-List<Map.Pos>.AddRange
	|
	|-RVA: 0x3E709F0 Offset: 0x3E70AF1 VA: 0x3E709F0
	|-List<MapImage.BackupTerrain>.AddRange
	|
	|-RVA: 0x3E738B0 Offset: 0x3E739B1 VA: 0x3E738B0
	|-List<MapImageRange.Pos>.AddRange
	|
	|-RVA: 0x3E76830 Offset: 0x3E76931 VA: 0x3E76830
	|-List<MapMind.Target>.AddRange
	|
	|-RVA: 0x3D86420 Offset: 0x3D86521 VA: 0x3D86420
	|-List<MapPanelDebug.Entity>.AddRange
	|
	|-RVA: 0x3D89520 Offset: 0x3D89621 VA: 0x3D89520
	|-List<NexRanking.Data>.AddRange
	|
	|-RVA: 0x3D8C360 Offset: 0x3D8C461 VA: 0x3D8C360
	|-List<NexVersus.RatingData>.AddRange
	|
	|-RVA: 0x3D8F260 Offset: 0x3D8F361 VA: 0x3D8F260
	|-List<PackedPlayModeBuildLogs.RuntimeBuildLog>.AddRange
	|
	|-RVA: 0x3D92260 Offset: 0x3D92361 VA: 0x3D92260
	|-List<ParticleSystem.Particle>.AddRange
	|
	|-RVA: 0x3D954E0 Offset: 0x3D955E1 VA: 0x3D954E0
	|-List<RangeData.Offset>.AddRange
	|
	|-RVA: 0x3D983E0 Offset: 0x3D984E1 VA: 0x3D983E0
	|-List<RenderGraphDebugData.PassDebugData>.AddRange
	|
	|-RVA: 0x3D9B670 Offset: 0x3D9B771 VA: 0x3D9B670
	|-List<RenderGraphDebugData.ResourceDebugData>.AddRange
	|
	|-RVA: 0x3D9E930 Offset: 0x3D9EA31 VA: 0x3D9E930
	|-List<RingCleaningUnitSelectMenu.GodParam>.AddRange
	|
	|-RVA: 0x3DA1950 Offset: 0x3DA1A51 VA: 0x3DA1950
	|-List<ShadowUtility.Edge>.AddRange
	|
	|-RVA: 0x3D14050 Offset: 0x3D14151 VA: 0x3D14050
	|-List<SkillArray.Entity>.AddRange
	|
	|-RVA: 0x3D17000 Offset: 0x3D17101 VA: 0x3D17000
	|-List<TexturePacker_JsonArray.Frame>.AddRange
	|
	|-RVA: 0x3D1A520 Offset: 0x3D1A621 VA: 0x3D1A520
	|-List<TimeNotificationBehaviour.NotificationEntry>.AddRange
	|
	|-RVA: 0x3D1D740 Offset: 0x3D1D841 VA: 0x3D1D740
	|-List<UnitySynchronizationContext.WorkRequest>.AddRange
	|
	|-RVA: 0x3D208B0 Offset: 0x3D209B1 VA: 0x3D208B0
	|-List<XmlSchemaObjectTable.XmlSchemaObjectEntry>.AddRange
	|
	|-RVA: 0x3D237D0 Offset: 0x3D238D1 VA: 0x3D237D0
	|-List<AssetBundleBuildMap.AssetBundleEntry.AssetPathString>.AddRange
	|
	|-RVA: 0x3D267F0 Offset: 0x3D268F1 VA: 0x3D267F0
	|-List<Detail.DataStore.DataStoreChangeMetaParamInt>.AddRange
	|
	|-RVA: 0x3D29AF0 Offset: 0x3D29BF1 VA: 0x3D29AF0
	|-List<Detail.DataStore.DataStoreDeleteParamInt>.AddRange
	|
	|-RVA: 0x3D2CAF0 Offset: 0x3D2CBF1 VA: 0x3D2CAF0
	|-List<Detail.DataStore.DataStoreGetMetaParamInt>.AddRange
	|
	|-RVA: 0x3D2FE70 Offset: 0x3D2FF71 VA: 0x3D2FE70
	|-List<Detail.DataStore.DataStoreMetaInfoInt>.AddRange
	|
	|-RVA: 0x3CF4660 Offset: 0x3CF4761 VA: 0x3CF4660
	|-List<Detail.DataStore.DataStorePasswordInfoInt>.AddRange
	|
	|-RVA: 0x3CF7840 Offset: 0x3CF7941 VA: 0x3CF7840
	|-List<Detail.DataStore.DataStorePersistenceInfoInt>.AddRange
	|
	|-RVA: 0x3CFAA70 Offset: 0x3CFAB71 VA: 0x3CFAA70
	|-List<Detail.DataStore.DataStorePreparePostParamInt>.AddRange
	|
	|-RVA: 0x3CFDD20 Offset: 0x3CFDE21 VA: 0x3CFDD20
	|-List<Detail.DataStore.DataStoreRateObjectParamInt>.AddRange
	|
	|-RVA: 0x3D00CB0 Offset: 0x3D00DB1 VA: 0x3D00CB0
	|-List<Detail.DataStore.DataStoreRatingInitParamInt>.AddRange
	|
	|-RVA: 0x3D03DF0 Offset: 0x3D03EF1 VA: 0x3D03DF0
	|-List<Detail.DataStore.DataStoreRatingTargetInt>.AddRange
	|
	|-RVA: 0x3D06E30 Offset: 0x3D06F31 VA: 0x3D06E30
	|-List<Detail.Ranking.RankingCachedResultInt>.AddRange
	|
	|-RVA: 0x3D0A2B0 Offset: 0x3D0A3B1 VA: 0x3D0A2B0
	|-List<Detail.Ranking.RankingOrderParamInt>.AddRange
	|
	|-RVA: 0x3D0D2F0 Offset: 0x3D0D3F1 VA: 0x3D0D2F0
	|-List<Detail.Ranking.RankingRankDataInt>.AddRange
	|
	|-RVA: 0x3D10970 Offset: 0x3D10A71 VA: 0x3D10970
	|-List<Detail.Ranking2.Ranking2ChartInfoInt>.AddRange
	|
	|-RVA: 0x3D67270 Offset: 0x3D67371 VA: 0x3D67270
	|-List<Detail.Ranking2.Ranking2RankDataInt>.AddRange
	|
	|-RVA: 0x3D6A690 Offset: 0x3D6A791 VA: 0x3D6A690
	|-List<Detail.Ranking2.Ranking2ScoreDataInt>.AddRange
	|
	|-RVA: 0x3D6D620 Offset: 0x3D6D721 VA: 0x3D6D620
	|-List<Detail.Screening.ScreeningContextInfoInt>.AddRange
	|
	|-RVA: 0x3D70960 Offset: 0x3D70A61 VA: 0x3D70960
	|-List<Detail.Subscriber.SubscriberContentInt>.AddRange
	|
	|-RVA: 0x3D73FE0 Offset: 0x3D740E1 VA: 0x3D73FE0
	|-List<Detail.Subscriber.SubscriberGetContentParamInt>.AddRange
	|
	|-RVA: 0x3D77230 Offset: 0x3D77331 VA: 0x3D77230
	|-List<Detail.Subscriber.SubscriberUserStatusInfoInt>.AddRange
	|
	|-RVA: 0x3D7A560 Offset: 0x3D7A661 VA: 0x3D7A560
	|-List<Detail.Subscriber.SubscriberUserStatusParamInt>.AddRange
	|
	|-RVA: 0x3D7D660 Offset: 0x3D7D761 VA: 0x3D7D660
	|-List<Detail.Utility.IntegerSettings>.AddRange
	|
	|-RVA: 0x3D804A0 Offset: 0x3D805A1 VA: 0x3D804A0
	|-List<Detail.Utility.UniqueIdInfoInt>.AddRange
	|
	|-RVA: 0x3D833B0 Offset: 0x3D834B1 VA: 0x3D833B0
	|-List<MapHistory.Rewind.LatestInspectorData>.AddRange
	|
	|-RVA: 0x305F670 Offset: 0x305F771 VA: 0x305F670
	|-List<MapHistory.Rewind.WorkTerrainData>.AddRange
	|
	|-RVA: 0x3062650 Offset: 0x3062751 VA: 0x3062650
	|-List<MapSkill.AroundCalculator.Result>.AddRange
	|
	|-RVA: 0x3065670 Offset: 0x3065771 VA: 0x3065670
	|-List<TargetPositionCache.CacheCurve.Item>.AddRange
	|
	|-RVA: 0x3068A10 Offset: 0x3068B11 VA: 0x3068A10
	|-List<TargetPositionCache.CacheEntry.RecordingItem>.AddRange
	*/

	// RVA: -1 Offset: -1
	public ReadOnlyCollection<T> AsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3B0B330 Offset: 0x3B0B431 VA: 0x3B0B330
	|-List<IntervalTree.Entry<object>>.AsReadOnly
	|
	|-RVA: 0x3B0E4A0 Offset: 0x3B0E5A1 VA: 0x3B0E4A0
	|-List<KeyValuePair<DateTime, object>>.AsReadOnly
	|
	|-RVA: 0x3B113C0 Offset: 0x3B114C1 VA: 0x3B113C0
	|-List<KeyValuePair<int, object>>.AsReadOnly
	|
	|-RVA: 0x3B14380 Offset: 0x3B14481 VA: 0x3B14380
	|-List<KeyValuePair<object, ValueTuple<int, DateTime, object>>>.AsReadOnly
	|
	|-RVA: 0x3B17500 Offset: 0x3B17601 VA: 0x3B17500
	|-List<KeyValuePair<object, object>>.AsReadOnly
	|
	|-RVA: 0x3B1A4C0 Offset: 0x3B1A5C1 VA: 0x3B1A4C0
	|-List<CommonBattleSequence.Reliance<object>>.AsReadOnly
	|
	|-RVA: 0x3B1D630 Offset: 0x3B1D731 VA: 0x3B1D630
	|-List<RenderGraphResourcePool.ResourceLogInfo<object>>.AsReadOnly
	|
	|-RVA: 0x3B20550 Offset: 0x3B20651 VA: 0x3B20550
	|-List<ValueTuple<int, object>>.AsReadOnly
	|
	|-RVA: 0x3DE1190 Offset: 0x3DE1291 VA: 0x3DE1190
	|-List<ValueTuple<Int32Enum, int>>.AsReadOnly
	|
	|-RVA: 0x3DE4090 Offset: 0x3DE4191 VA: 0x3DE4090
	|-List<ValueTuple<object, ValueTuple<object, int>>>.AsReadOnly
	|
	|-RVA: 0x3DE7200 Offset: 0x3DE7301 VA: 0x3DE7200
	|-List<ValueTuple<object, int>>.AsReadOnly
	|
	|-RVA: 0x3DEA150 Offset: 0x3DEA251 VA: 0x3DEA150
	|-List<ValueTuple<Vector3, float>>.AsReadOnly
	|
	|-RVA: 0x3DED120 Offset: 0x3DED221 VA: 0x3DED120
	|-List<ValueTuple<object, Int32Enum, int>>.AsReadOnly
	|
	|-RVA: 0x3DF00E0 Offset: 0x3DF01E1 VA: 0x3DF00E0
	|-List<ValueTuple<object, int, int, int>>.AsReadOnly
	|
	|-RVA: 0x3DF3200 Offset: 0x3DF3301 VA: 0x3DF3200
	|-List<AnimatorClipInfo>.AsReadOnly
	|
	|-RVA: 0x3DF6100 Offset: 0x3DF6201 VA: 0x3DF6100
	|-List<AsyncOperationHandle>.AsReadOnly
	|
	|-RVA: 0x3DF9300 Offset: 0x3DF9401 VA: 0x3DF9300
	|-List<BoneWeight>.AsReadOnly
	|
	|-RVA: 0x3DFC420 Offset: 0x3DFC521 VA: 0x3DFC420
	|-List<bool>.AsReadOnly
	|
	|-RVA: 0x3E79970 Offset: 0x3E79A71 VA: 0x3E79970
	|-List<byte>.AsReadOnly
	|
	|-RVA: 0x3E7C7D0 Offset: 0x3E7C8D1 VA: 0x3E7C7D0
	|-List<CameraInfo>.AsReadOnly
	|
	|-RVA: 0x3E7F6A0 Offset: 0x3E7F7A1 VA: 0x3E7F6A0
	|-List<char>.AsReadOnly
	|
	|-RVA: 0x3E82520 Offset: 0x3E82621 VA: 0x3E82520
	|-List<Color>.AsReadOnly
	|
	|-RVA: 0x3E854A0 Offset: 0x3E855A1 VA: 0x3E854A0
	|-List<Color32>.AsReadOnly
	|
	|-RVA: 0x3E88300 Offset: 0x3E88401 VA: 0x3E88300
	|-List<ConstraintSource>.AsReadOnly
	|
	|-RVA: 0x3E8B2C0 Offset: 0x3E8B3C1 VA: 0x3E8B2C0
	|-List<ContourVertex>.AsReadOnly
	|
	|-RVA: 0x3E8E4C0 Offset: 0x3E8E5C1 VA: 0x3E8E4C0
	|-List<DataStoreRatingInfo>.AsReadOnly
	|
	|-RVA: 0x3E915C0 Offset: 0x3E916C1 VA: 0x3E915C0
	|-List<DataStoreResult>.AsReadOnly
	|
	|-RVA: 0x3E943D0 Offset: 0x3E944D1 VA: 0x3E943D0
	|-List<DateTime>.AsReadOnly
	|
	|-RVA: 0x3E97210 Offset: 0x3E97311 VA: 0x3E97210
	|-List<DateTimeOffset>.AsReadOnly
	|
	|-RVA: 0x3E9A0F0 Offset: 0x3E9A1F1 VA: 0x3E9A0F0
	|-List<Decimal>.AsReadOnly
	|
	|-RVA: 0x3E9D110 Offset: 0x3E9D211 VA: 0x3E9D110
	|-List<DiagnosticEvent>.AsReadOnly
	|
	|-RVA: 0x3EA03F0 Offset: 0x3EA04F1 VA: 0x3EA03F0
	|-List<double>.AsReadOnly
	|
	|-RVA: 0x3EA3320 Offset: 0x3EA3421 VA: 0x3EA3320
	|-List<Friend>.AsReadOnly
	|
	|-RVA: 0x3EA65C0 Offset: 0x3EA66C1 VA: 0x3EA65C0
	|-List<GlyphRect>.AsReadOnly
	|
	|-RVA: 0x3EA9470 Offset: 0x3EA9571 VA: 0x3EA9470
	|-List<short>.AsReadOnly
	|
	|-RVA: 0x3EAC270 Offset: 0x3EAC371 VA: 0x3EAC270
	|-List<int>.AsReadOnly
	|
	|-RVA: 0x3EAF070 Offset: 0x3EAF171 VA: 0x3EAF070
	|-List<Int32Enum>.AsReadOnly
	|
	|-RVA: 0x3EB1E70 Offset: 0x3EB1F71 VA: 0x3EB1E70
	|-List<long>.AsReadOnly
	|
	|-RVA: 0x3DFF240 Offset: 0x3DFF341 VA: 0x3DFF240
	|-List<IntPtr>.AsReadOnly
	|
	|-RVA: 0x3E02090 Offset: 0x3E02191 VA: 0x3E02090
	|-List<InterpretedFrameInfo>.AsReadOnly
	|
	|-RVA: 0x3E05040 Offset: 0x3E05141 VA: 0x3E05040
	|-List<IntervalTreeNode>.AsReadOnly
	|
	|-RVA: 0x3E08140 Offset: 0x3E08241 VA: 0x3E08140
	|-List<LengthLimitProperties>.AsReadOnly
	|
	|-RVA: 0x3E0AF50 Offset: 0x3E0B051 VA: 0x3E0AF50
	|-List<MapPos>.AsReadOnly
	|
	|-RVA: 0x3E0DEF0 Offset: 0x3E0DFF1 VA: 0x3E0DEF0
	|-List<Matrix4x4>.AsReadOnly
	|
	|-RVA: 0x3E11240 Offset: 0x3E11341 VA: 0x3E11240
	|-List<object>.AsReadOnly
	|-List<VolumeParameter>.AsReadOnly
	|-List<DebugUI.Panel>.AsReadOnly
	|
	|-RVA: 0x3E14210 Offset: 0x3E14311 VA: 0x3E14210
	|-List<ObjectInitializationData>.AsReadOnly
	|
	|-RVA: 0x3E175D0 Offset: 0x3E176D1 VA: 0x3E175D0
	|-List<PlayableBinding>.AsReadOnly
	|
	|-RVA: 0x3E1A860 Offset: 0x3E1A961 VA: 0x3E1A860
	|-List<PlayerLoopSystem>.AsReadOnly
	|
	|-RVA: 0x3DA4D00 Offset: 0x3DA4E01 VA: 0x3DA4D00
	|-List<PlayerLoopSystemInternal>.AsReadOnly
	|
	|-RVA: 0x3DA7FC0 Offset: 0x3DA80C1 VA: 0x3DA7FC0
	|-List<RangePositionInfo>.AsReadOnly
	|
	|-RVA: 0x3DAAE90 Offset: 0x3DAAF91 VA: 0x3DAAE90
	|-List<Ranking2ChartInfoInput>.AsReadOnly
	|
	|-RVA: 0x3DADE10 Offset: 0x3DADF11 VA: 0x3DADE10
	|-List<RaycastHit2D>.AsReadOnly
	|
	|-RVA: 0x3DB1300 Offset: 0x3DB1401 VA: 0x3DB1300
	|-List<RaycastResult>.AsReadOnly
	|
	|-RVA: 0x3DB4950 Offset: 0x3DB4A51 VA: 0x3DB4950
	|-List<Rect>.AsReadOnly
	|
	|-RVA: 0x3DB78D0 Offset: 0x3DB79D1 VA: 0x3DB78D0
	|-List<RendererListHandle>.AsReadOnly
	|
	|-RVA: 0x3DBA6E0 Offset: 0x3DBA7E1 VA: 0x3DBA6E0
	|-List<ResourceHandle>.AsReadOnly
	|
	|-RVA: 0x3DBD4F0 Offset: 0x3DBD5F1 VA: 0x3DBD4F0
	|-List<sbyte>.AsReadOnly
	|
	|-RVA: 0x3DC0300 Offset: 0x3DC0401 VA: 0x3DC0300
	|-List<ShaderTagId>.AsReadOnly
	|
	|-RVA: 0x3E3BF70 Offset: 0x3E3C071 VA: 0x3E3BF70
	|-List<float>.AsReadOnly
	|
	|-RVA: 0x3E3F0D0 Offset: 0x3E3F1D1 VA: 0x3E3F0D0
	|-List<SphericalHarmonicsL2>.AsReadOnly
	|
	|-RVA: 0x3E42BB0 Offset: 0x3E42CB1 VA: 0x3E42BB0
	|-List<SubMeshDescriptor>.AsReadOnly
	|
	|-RVA: 0x3E45EA0 Offset: 0x3E45FA1 VA: 0x3E45EA0
	|-List<TablePair>.AsReadOnly
	|
	|-RVA: 0x3E48D70 Offset: 0x3E48E71 VA: 0x3E48D70
	|-List<TimeSpan>.AsReadOnly
	|
	|-RVA: 0x3E4BBE0 Offset: 0x3E4BCE1 VA: 0x3E4BBE0
	|-List<UICharInfo>.AsReadOnly
	|
	|-RVA: 0x3E4EB90 Offset: 0x3E4EC91 VA: 0x3E4EB90
	|-List<UILineInfo>.AsReadOnly
	|
	|-RVA: 0x3E51D90 Offset: 0x3E51E91 VA: 0x3E51D90
	|-List<UIVertex>.AsReadOnly
	|
	|-RVA: 0x3E55720 Offset: 0x3E55821 VA: 0x3E55720
	|-List<ushort>.AsReadOnly
	|
	|-RVA: 0x3E58520 Offset: 0x3E58621 VA: 0x3E58520
	|-List<uint>.AsReadOnly
	|
	|-RVA: 0x3DC3110 Offset: 0x3DC3211 VA: 0x3DC3110
	|-List<ulong>.AsReadOnly
	|
	|-RVA: 0x3DC5F30 Offset: 0x3DC6031 VA: 0x3DC5F30
	|-List<Vector2>.AsReadOnly
	|
	|-RVA: 0x3DC8E40 Offset: 0x3DC8F41 VA: 0x3DC8E40
	|-List<Vector3>.AsReadOnly
	|
	|-RVA: 0x3DCBE40 Offset: 0x3DCBF41 VA: 0x3DCBE40
	|-List<Vector4>.AsReadOnly
	|
	|-RVA: 0x3DCEDF0 Offset: 0x3DCEEF1 VA: 0x3DCEDF0
	|-List<VertexAttributeDescriptor>.AsReadOnly
	|
	|-RVA: 0x3DD1CF0 Offset: 0x3DD1DF1 VA: 0x3DD1CF0
	|-List<X509ChainStatus>.AsReadOnly
	|
	|-RVA: 0x3DD4D00 Offset: 0x3DD4E01 VA: 0x3DD4D00
	|-List<XRView>.AsReadOnly
	|
	|-RVA: 0x3DD8000 Offset: 0x3DD8101 VA: 0x3DD8000
	|-List<AmiiboSequence.GainItemData>.AsReadOnly
	|
	|-RVA: 0x3DDB020 Offset: 0x3DDB121 VA: 0x3DDB020
	|-List<AnimationOutputWeightProcessor.WeightInfo>.AsReadOnly
	|
	|-RVA: 0x3DDE2C0 Offset: 0x3DDE3C1 VA: 0x3DDE2C0
	|-List<ArenaOrderSequence.GodInfo>.AsReadOnly
	|
	|-RVA: 0x3E1DB20 Offset: 0x3E1DC21 VA: 0x3E1DB20
	|-List<BattleInfo.SupportData>.AsReadOnly
	|
	|-RVA: 0x3E20A40 Offset: 0x3E20B41 VA: 0x3E20A40
	|-List<BeforeRenderHelper.OrderBlock>.AsReadOnly
	|
	|-RVA: 0x3E23A10 Offset: 0x3E23B11 VA: 0x3E23A10
	|-List<Camera.RenderRequest>.AsReadOnly
	|
	|-RVA: 0x3E26B90 Offset: 0x3E26C91 VA: 0x3E26B90
	|-List<CameraState.CustomBlendable>.AsReadOnly
	|
	|-RVA: 0x3E29A60 Offset: 0x3E29B61 VA: 0x3E29A60
	|-List<CinemachineClearShot.Pair>.AsReadOnly
	|
	|-RVA: 0x3E2C870 Offset: 0x3E2C971 VA: 0x3E2C870
	|-List<CinemachineStateDrivenCamera.HashPair>.AsReadOnly
	|
	|-RVA: 0x3E2F770 Offset: 0x3E2F871 VA: 0x3E2F770
	|-List<DelayedActionManager.DelegateInfo>.AsReadOnly
	|
	|-RVA: 0x3E329F0 Offset: 0x3E32AF1 VA: 0x3E329F0
	|-List<Detail.AsyncResultInt>.AsReadOnly
	|
	|-RVA: 0x3E35CC0 Offset: 0x3E35DC1 VA: 0x3E35CC0
	|-List<Detail.CppArray>.AsReadOnly
	|
	|-RVA: 0x3E38CC0 Offset: 0x3E38DC1 VA: 0x3E38CC0
	|-List<Detail.NotificationEventInt>.AsReadOnly
	|
	|-RVA: 0x3E5B370 Offset: 0x3E5B471 VA: 0x3E5B370
	|-List<DragonRideTargetGroup.ChainParam>.AsReadOnly
	|
	|-RVA: 0x3E5E330 Offset: 0x3E5E431 VA: 0x3E5E330
	|-List<GmapPathAdjuster.TargetModel>.AsReadOnly
	|
	|-RVA: 0x3E61540 Offset: 0x3E61641 VA: 0x3E61540
	|-List<GmapSpotAdjuster.TargetModel>.AsReadOnly
	|
	|-RVA: 0x3E64750 Offset: 0x3E64851 VA: 0x3E64750
	|-List<HubFastTravel.Location>.AsReadOnly
	|
	|-RVA: 0x3E679E0 Offset: 0x3E67AE1 VA: 0x3E679E0
	|-List<HubLensFlare.Flare>.AsReadOnly
	|
	|-RVA: 0x3E6AD00 Offset: 0x3E6AE01 VA: 0x3E6AD00
	|-List<InventoryPoolItemMenuContent.KindBgNameClass>.AsReadOnly
	|
	|-RVA: 0x3E6DBD0 Offset: 0x3E6DCD1 VA: 0x3E6DBD0
	|-List<Map.Pos>.AsReadOnly
	|
	|-RVA: 0x3E70A10 Offset: 0x3E70B11 VA: 0x3E70A10
	|-List<MapImage.BackupTerrain>.AsReadOnly
	|
	|-RVA: 0x3E738D0 Offset: 0x3E739D1 VA: 0x3E738D0
	|-List<MapImageRange.Pos>.AsReadOnly
	|
	|-RVA: 0x3E76850 Offset: 0x3E76951 VA: 0x3E76850
	|-List<MapMind.Target>.AsReadOnly
	|
	|-RVA: 0x3D86440 Offset: 0x3D86541 VA: 0x3D86440
	|-List<MapPanelDebug.Entity>.AsReadOnly
	|
	|-RVA: 0x3D89540 Offset: 0x3D89641 VA: 0x3D89540
	|-List<NexRanking.Data>.AsReadOnly
	|
	|-RVA: 0x3D8C380 Offset: 0x3D8C481 VA: 0x3D8C380
	|-List<NexVersus.RatingData>.AsReadOnly
	|
	|-RVA: 0x3D8F280 Offset: 0x3D8F381 VA: 0x3D8F280
	|-List<PackedPlayModeBuildLogs.RuntimeBuildLog>.AsReadOnly
	|
	|-RVA: 0x3D92280 Offset: 0x3D92381 VA: 0x3D92280
	|-List<ParticleSystem.Particle>.AsReadOnly
	|
	|-RVA: 0x3D95500 Offset: 0x3D95601 VA: 0x3D95500
	|-List<RangeData.Offset>.AsReadOnly
	|
	|-RVA: 0x3D98400 Offset: 0x3D98501 VA: 0x3D98400
	|-List<RenderGraphDebugData.PassDebugData>.AsReadOnly
	|
	|-RVA: 0x3D9B690 Offset: 0x3D9B791 VA: 0x3D9B690
	|-List<RenderGraphDebugData.ResourceDebugData>.AsReadOnly
	|
	|-RVA: 0x3D9E950 Offset: 0x3D9EA51 VA: 0x3D9E950
	|-List<RingCleaningUnitSelectMenu.GodParam>.AsReadOnly
	|
	|-RVA: 0x3DA1970 Offset: 0x3DA1A71 VA: 0x3DA1970
	|-List<ShadowUtility.Edge>.AsReadOnly
	|
	|-RVA: 0x3D14070 Offset: 0x3D14171 VA: 0x3D14070
	|-List<SkillArray.Entity>.AsReadOnly
	|
	|-RVA: 0x3D17020 Offset: 0x3D17121 VA: 0x3D17020
	|-List<TexturePacker_JsonArray.Frame>.AsReadOnly
	|
	|-RVA: 0x3D1A540 Offset: 0x3D1A641 VA: 0x3D1A540
	|-List<TimeNotificationBehaviour.NotificationEntry>.AsReadOnly
	|
	|-RVA: 0x3D1D760 Offset: 0x3D1D861 VA: 0x3D1D760
	|-List<UnitySynchronizationContext.WorkRequest>.AsReadOnly
	|
	|-RVA: 0x3D208D0 Offset: 0x3D209D1 VA: 0x3D208D0
	|-List<XmlSchemaObjectTable.XmlSchemaObjectEntry>.AsReadOnly
	|
	|-RVA: 0x3D237F0 Offset: 0x3D238F1 VA: 0x3D237F0
	|-List<AssetBundleBuildMap.AssetBundleEntry.AssetPathString>.AsReadOnly
	|
	|-RVA: 0x3D26810 Offset: 0x3D26911 VA: 0x3D26810
	|-List<Detail.DataStore.DataStoreChangeMetaParamInt>.AsReadOnly
	|
	|-RVA: 0x3D29B10 Offset: 0x3D29C11 VA: 0x3D29B10
	|-List<Detail.DataStore.DataStoreDeleteParamInt>.AsReadOnly
	|
	|-RVA: 0x3D2CB10 Offset: 0x3D2CC11 VA: 0x3D2CB10
	|-List<Detail.DataStore.DataStoreGetMetaParamInt>.AsReadOnly
	|
	|-RVA: 0x3D2FE90 Offset: 0x3D2FF91 VA: 0x3D2FE90
	|-List<Detail.DataStore.DataStoreMetaInfoInt>.AsReadOnly
	|
	|-RVA: 0x3CF4680 Offset: 0x3CF4781 VA: 0x3CF4680
	|-List<Detail.DataStore.DataStorePasswordInfoInt>.AsReadOnly
	|
	|-RVA: 0x3CF7860 Offset: 0x3CF7961 VA: 0x3CF7860
	|-List<Detail.DataStore.DataStorePersistenceInfoInt>.AsReadOnly
	|
	|-RVA: 0x3CFAA90 Offset: 0x3CFAB91 VA: 0x3CFAA90
	|-List<Detail.DataStore.DataStorePreparePostParamInt>.AsReadOnly
	|
	|-RVA: 0x3CFDD40 Offset: 0x3CFDE41 VA: 0x3CFDD40
	|-List<Detail.DataStore.DataStoreRateObjectParamInt>.AsReadOnly
	|
	|-RVA: 0x3D00CD0 Offset: 0x3D00DD1 VA: 0x3D00CD0
	|-List<Detail.DataStore.DataStoreRatingInitParamInt>.AsReadOnly
	|
	|-RVA: 0x3D03E10 Offset: 0x3D03F11 VA: 0x3D03E10
	|-List<Detail.DataStore.DataStoreRatingTargetInt>.AsReadOnly
	|
	|-RVA: 0x3D06E50 Offset: 0x3D06F51 VA: 0x3D06E50
	|-List<Detail.Ranking.RankingCachedResultInt>.AsReadOnly
	|
	|-RVA: 0x3D0A2D0 Offset: 0x3D0A3D1 VA: 0x3D0A2D0
	|-List<Detail.Ranking.RankingOrderParamInt>.AsReadOnly
	|
	|-RVA: 0x3D0D310 Offset: 0x3D0D411 VA: 0x3D0D310
	|-List<Detail.Ranking.RankingRankDataInt>.AsReadOnly
	|
	|-RVA: 0x3D10990 Offset: 0x3D10A91 VA: 0x3D10990
	|-List<Detail.Ranking2.Ranking2ChartInfoInt>.AsReadOnly
	|
	|-RVA: 0x3D67290 Offset: 0x3D67391 VA: 0x3D67290
	|-List<Detail.Ranking2.Ranking2RankDataInt>.AsReadOnly
	|
	|-RVA: 0x3D6A6B0 Offset: 0x3D6A7B1 VA: 0x3D6A6B0
	|-List<Detail.Ranking2.Ranking2ScoreDataInt>.AsReadOnly
	|
	|-RVA: 0x3D6D640 Offset: 0x3D6D741 VA: 0x3D6D640
	|-List<Detail.Screening.ScreeningContextInfoInt>.AsReadOnly
	|
	|-RVA: 0x3D70980 Offset: 0x3D70A81 VA: 0x3D70980
	|-List<Detail.Subscriber.SubscriberContentInt>.AsReadOnly
	|
	|-RVA: 0x3D74000 Offset: 0x3D74101 VA: 0x3D74000
	|-List<Detail.Subscriber.SubscriberGetContentParamInt>.AsReadOnly
	|
	|-RVA: 0x3D77250 Offset: 0x3D77351 VA: 0x3D77250
	|-List<Detail.Subscriber.SubscriberUserStatusInfoInt>.AsReadOnly
	|
	|-RVA: 0x3D7A580 Offset: 0x3D7A681 VA: 0x3D7A580
	|-List<Detail.Subscriber.SubscriberUserStatusParamInt>.AsReadOnly
	|
	|-RVA: 0x3D7D680 Offset: 0x3D7D781 VA: 0x3D7D680
	|-List<Detail.Utility.IntegerSettings>.AsReadOnly
	|
	|-RVA: 0x3D804C0 Offset: 0x3D805C1 VA: 0x3D804C0
	|-List<Detail.Utility.UniqueIdInfoInt>.AsReadOnly
	|
	|-RVA: 0x3D833D0 Offset: 0x3D834D1 VA: 0x3D833D0
	|-List<MapHistory.Rewind.LatestInspectorData>.AsReadOnly
	|
	|-RVA: 0x305F690 Offset: 0x305F791 VA: 0x305F690
	|-List<MapHistory.Rewind.WorkTerrainData>.AsReadOnly
	|
	|-RVA: 0x3062670 Offset: 0x3062771 VA: 0x3062670
	|-List<MapSkill.AroundCalculator.Result>.AsReadOnly
	|
	|-RVA: 0x3065690 Offset: 0x3065791 VA: 0x3065690
	|-List<TargetPositionCache.CacheCurve.Item>.AsReadOnly
	|
	|-RVA: 0x3068A30 Offset: 0x3068B31 VA: 0x3068A30
	|-List<TargetPositionCache.CacheEntry.RecordingItem>.AsReadOnly
	*/

	// RVA: -1 Offset: -1
	public int BinarySearch(int index, int count, T item, IComparer<T> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3B0B3A0 Offset: 0x3B0B4A1 VA: 0x3B0B3A0
	|-List<IntervalTree.Entry<object>>.BinarySearch
	|
	|-RVA: 0x3B0E510 Offset: 0x3B0E611 VA: 0x3B0E510
	|-List<KeyValuePair<DateTime, object>>.BinarySearch
	|
	|-RVA: 0x3B11430 Offset: 0x3B11531 VA: 0x3B11430
	|-List<KeyValuePair<int, object>>.BinarySearch
	|
	|-RVA: 0x3B143F0 Offset: 0x3B144F1 VA: 0x3B143F0
	|-List<KeyValuePair<object, ValueTuple<int, DateTime, object>>>.BinarySearch
	|
	|-RVA: 0x3B17570 Offset: 0x3B17671 VA: 0x3B17570
	|-List<KeyValuePair<object, object>>.BinarySearch
	|
	|-RVA: 0x3B1A530 Offset: 0x3B1A631 VA: 0x3B1A530
	|-List<CommonBattleSequence.Reliance<object>>.BinarySearch
	|
	|-RVA: 0x3B1D6A0 Offset: 0x3B1D7A1 VA: 0x3B1D6A0
	|-List<RenderGraphResourcePool.ResourceLogInfo<object>>.BinarySearch
	|
	|-RVA: 0x3B205C0 Offset: 0x3B206C1 VA: 0x3B205C0
	|-List<ValueTuple<int, object>>.BinarySearch
	|
	|-RVA: 0x3DE1200 Offset: 0x3DE1301 VA: 0x3DE1200
	|-List<ValueTuple<Int32Enum, int>>.BinarySearch
	|
	|-RVA: 0x3DE4100 Offset: 0x3DE4201 VA: 0x3DE4100
	|-List<ValueTuple<object, ValueTuple<object, int>>>.BinarySearch
	|
	|-RVA: 0x3DE7270 Offset: 0x3DE7371 VA: 0x3DE7270
	|-List<ValueTuple<object, int>>.BinarySearch
	|
	|-RVA: 0x3DEA1C0 Offset: 0x3DEA2C1 VA: 0x3DEA1C0
	|-List<ValueTuple<Vector3, float>>.BinarySearch
	|
	|-RVA: 0x3DED190 Offset: 0x3DED291 VA: 0x3DED190
	|-List<ValueTuple<object, Int32Enum, int>>.BinarySearch
	|
	|-RVA: 0x3DF0150 Offset: 0x3DF0251 VA: 0x3DF0150
	|-List<ValueTuple<object, int, int, int>>.BinarySearch
	|
	|-RVA: 0x3DF3270 Offset: 0x3DF3371 VA: 0x3DF3270
	|-List<AnimatorClipInfo>.BinarySearch
	|
	|-RVA: 0x3DF6170 Offset: 0x3DF6271 VA: 0x3DF6170
	|-List<AsyncOperationHandle>.BinarySearch
	|
	|-RVA: 0x3DF9370 Offset: 0x3DF9471 VA: 0x3DF9370
	|-List<BoneWeight>.BinarySearch
	|
	|-RVA: 0x3DFC490 Offset: 0x3DFC591 VA: 0x3DFC490
	|-List<bool>.BinarySearch
	|
	|-RVA: 0x3E799E0 Offset: 0x3E79AE1 VA: 0x3E799E0
	|-List<byte>.BinarySearch
	|
	|-RVA: 0x3E7C840 Offset: 0x3E7C941 VA: 0x3E7C840
	|-List<CameraInfo>.BinarySearch
	|
	|-RVA: 0x3E7F710 Offset: 0x3E7F811 VA: 0x3E7F710
	|-List<char>.BinarySearch
	|
	|-RVA: 0x3E82590 Offset: 0x3E82691 VA: 0x3E82590
	|-List<Color>.BinarySearch
	|
	|-RVA: 0x3E85510 Offset: 0x3E85611 VA: 0x3E85510
	|-List<Color32>.BinarySearch
	|
	|-RVA: 0x3E88370 Offset: 0x3E88471 VA: 0x3E88370
	|-List<ConstraintSource>.BinarySearch
	|
	|-RVA: 0x3E8B330 Offset: 0x3E8B431 VA: 0x3E8B330
	|-List<ContourVertex>.BinarySearch
	|
	|-RVA: 0x3E8E530 Offset: 0x3E8E631 VA: 0x3E8E530
	|-List<DataStoreRatingInfo>.BinarySearch
	|
	|-RVA: 0x3E91630 Offset: 0x3E91731 VA: 0x3E91630
	|-List<DataStoreResult>.BinarySearch
	|
	|-RVA: 0x3E94440 Offset: 0x3E94541 VA: 0x3E94440
	|-List<DateTime>.BinarySearch
	|
	|-RVA: 0x3E97280 Offset: 0x3E97381 VA: 0x3E97280
	|-List<DateTimeOffset>.BinarySearch
	|
	|-RVA: 0x3E9A160 Offset: 0x3E9A261 VA: 0x3E9A160
	|-List<Decimal>.BinarySearch
	|
	|-RVA: 0x3E9D180 Offset: 0x3E9D281 VA: 0x3E9D180
	|-List<DiagnosticEvent>.BinarySearch
	|
	|-RVA: 0x3EA0460 Offset: 0x3EA0561 VA: 0x3EA0460
	|-List<double>.BinarySearch
	|
	|-RVA: 0x3EA3390 Offset: 0x3EA3491 VA: 0x3EA3390
	|-List<Friend>.BinarySearch
	|
	|-RVA: 0x3EA6630 Offset: 0x3EA6731 VA: 0x3EA6630
	|-List<GlyphRect>.BinarySearch
	|
	|-RVA: 0x3EA94E0 Offset: 0x3EA95E1 VA: 0x3EA94E0
	|-List<short>.BinarySearch
	|
	|-RVA: 0x3EAC2E0 Offset: 0x3EAC3E1 VA: 0x3EAC2E0
	|-List<int>.BinarySearch
	|
	|-RVA: 0x3EAF0E0 Offset: 0x3EAF1E1 VA: 0x3EAF0E0
	|-List<Int32Enum>.BinarySearch
	|
	|-RVA: 0x3EB1EE0 Offset: 0x3EB1FE1 VA: 0x3EB1EE0
	|-List<long>.BinarySearch
	|
	|-RVA: 0x3DFF2B0 Offset: 0x3DFF3B1 VA: 0x3DFF2B0
	|-List<IntPtr>.BinarySearch
	|
	|-RVA: 0x3E02100 Offset: 0x3E02201 VA: 0x3E02100
	|-List<InterpretedFrameInfo>.BinarySearch
	|
	|-RVA: 0x3E050B0 Offset: 0x3E051B1 VA: 0x3E050B0
	|-List<IntervalTreeNode>.BinarySearch
	|
	|-RVA: 0x3E081B0 Offset: 0x3E082B1 VA: 0x3E081B0
	|-List<LengthLimitProperties>.BinarySearch
	|
	|-RVA: 0x3E0AFC0 Offset: 0x3E0B0C1 VA: 0x3E0AFC0
	|-List<MapPos>.BinarySearch
	|
	|-RVA: 0x3E0DF60 Offset: 0x3E0E061 VA: 0x3E0DF60
	|-List<Matrix4x4>.BinarySearch
	|
	|-RVA: 0x3E112B0 Offset: 0x3E113B1 VA: 0x3E112B0
	|-List<object>.BinarySearch
	|
	|-RVA: 0x3E14280 Offset: 0x3E14381 VA: 0x3E14280
	|-List<ObjectInitializationData>.BinarySearch
	|
	|-RVA: 0x3E17640 Offset: 0x3E17741 VA: 0x3E17640
	|-List<PlayableBinding>.BinarySearch
	|
	|-RVA: 0x3E1A8D0 Offset: 0x3E1A9D1 VA: 0x3E1A8D0
	|-List<PlayerLoopSystem>.BinarySearch
	|
	|-RVA: 0x3DA4D70 Offset: 0x3DA4E71 VA: 0x3DA4D70
	|-List<PlayerLoopSystemInternal>.BinarySearch
	|
	|-RVA: 0x3DA8030 Offset: 0x3DA8131 VA: 0x3DA8030
	|-List<RangePositionInfo>.BinarySearch
	|
	|-RVA: 0x3DAAF00 Offset: 0x3DAB001 VA: 0x3DAAF00
	|-List<Ranking2ChartInfoInput>.BinarySearch
	|
	|-RVA: 0x3DADE80 Offset: 0x3DADF81 VA: 0x3DADE80
	|-List<RaycastHit2D>.BinarySearch
	|
	|-RVA: 0x3DB1370 Offset: 0x3DB1471 VA: 0x3DB1370
	|-List<RaycastResult>.BinarySearch
	|
	|-RVA: 0x3DB49C0 Offset: 0x3DB4AC1 VA: 0x3DB49C0
	|-List<Rect>.BinarySearch
	|
	|-RVA: 0x3DB7940 Offset: 0x3DB7A41 VA: 0x3DB7940
	|-List<RendererListHandle>.BinarySearch
	|
	|-RVA: 0x3DBA750 Offset: 0x3DBA851 VA: 0x3DBA750
	|-List<ResourceHandle>.BinarySearch
	|
	|-RVA: 0x3DBD560 Offset: 0x3DBD661 VA: 0x3DBD560
	|-List<sbyte>.BinarySearch
	|
	|-RVA: 0x3DC0370 Offset: 0x3DC0471 VA: 0x3DC0370
	|-List<ShaderTagId>.BinarySearch
	|
	|-RVA: 0x3E3BFE0 Offset: 0x3E3C0E1 VA: 0x3E3BFE0
	|-List<float>.BinarySearch
	|
	|-RVA: 0x3E3F140 Offset: 0x3E3F241 VA: 0x3E3F140
	|-List<SphericalHarmonicsL2>.BinarySearch
	|
	|-RVA: 0x3E42C20 Offset: 0x3E42D21 VA: 0x3E42C20
	|-List<SubMeshDescriptor>.BinarySearch
	|
	|-RVA: 0x3E45F10 Offset: 0x3E46011 VA: 0x3E45F10
	|-List<TablePair>.BinarySearch
	|
	|-RVA: 0x3E48DE0 Offset: 0x3E48EE1 VA: 0x3E48DE0
	|-List<TimeSpan>.BinarySearch
	|
	|-RVA: 0x3E4BC50 Offset: 0x3E4BD51 VA: 0x3E4BC50
	|-List<UICharInfo>.BinarySearch
	|
	|-RVA: 0x3E4EC00 Offset: 0x3E4ED01 VA: 0x3E4EC00
	|-List<UILineInfo>.BinarySearch
	|
	|-RVA: 0x3E51E00 Offset: 0x3E51F01 VA: 0x3E51E00
	|-List<UIVertex>.BinarySearch
	|
	|-RVA: 0x3E55790 Offset: 0x3E55891 VA: 0x3E55790
	|-List<ushort>.BinarySearch
	|
	|-RVA: 0x3E58590 Offset: 0x3E58691 VA: 0x3E58590
	|-List<uint>.BinarySearch
	|
	|-RVA: 0x3DC3180 Offset: 0x3DC3281 VA: 0x3DC3180
	|-List<ulong>.BinarySearch
	|
	|-RVA: 0x3DC5FA0 Offset: 0x3DC60A1 VA: 0x3DC5FA0
	|-List<Vector2>.BinarySearch
	|
	|-RVA: 0x3DC8EB0 Offset: 0x3DC8FB1 VA: 0x3DC8EB0
	|-List<Vector3>.BinarySearch
	|
	|-RVA: 0x3DCBEB0 Offset: 0x3DCBFB1 VA: 0x3DCBEB0
	|-List<Vector4>.BinarySearch
	|
	|-RVA: 0x3DCEE60 Offset: 0x3DCEF61 VA: 0x3DCEE60
	|-List<VertexAttributeDescriptor>.BinarySearch
	|
	|-RVA: 0x3DD1D60 Offset: 0x3DD1E61 VA: 0x3DD1D60
	|-List<X509ChainStatus>.BinarySearch
	|
	|-RVA: 0x3DD4D70 Offset: 0x3DD4E71 VA: 0x3DD4D70
	|-List<XRView>.BinarySearch
	|
	|-RVA: 0x3DD8070 Offset: 0x3DD8171 VA: 0x3DD8070
	|-List<AmiiboSequence.GainItemData>.BinarySearch
	|
	|-RVA: 0x3DDB090 Offset: 0x3DDB191 VA: 0x3DDB090
	|-List<AnimationOutputWeightProcessor.WeightInfo>.BinarySearch
	|
	|-RVA: 0x3DDE330 Offset: 0x3DDE431 VA: 0x3DDE330
	|-List<ArenaOrderSequence.GodInfo>.BinarySearch
	|
	|-RVA: 0x3E1DB90 Offset: 0x3E1DC91 VA: 0x3E1DB90
	|-List<BattleInfo.SupportData>.BinarySearch
	|
	|-RVA: 0x3E20AB0 Offset: 0x3E20BB1 VA: 0x3E20AB0
	|-List<BeforeRenderHelper.OrderBlock>.BinarySearch
	|
	|-RVA: 0x3E23A80 Offset: 0x3E23B81 VA: 0x3E23A80
	|-List<Camera.RenderRequest>.BinarySearch
	|
	|-RVA: 0x3E26C00 Offset: 0x3E26D01 VA: 0x3E26C00
	|-List<CameraState.CustomBlendable>.BinarySearch
	|
	|-RVA: 0x3E29AD0 Offset: 0x3E29BD1 VA: 0x3E29AD0
	|-List<CinemachineClearShot.Pair>.BinarySearch
	|
	|-RVA: 0x3E2C8E0 Offset: 0x3E2C9E1 VA: 0x3E2C8E0
	|-List<CinemachineStateDrivenCamera.HashPair>.BinarySearch
	|
	|-RVA: 0x3E2F7E0 Offset: 0x3E2F8E1 VA: 0x3E2F7E0
	|-List<DelayedActionManager.DelegateInfo>.BinarySearch
	|
	|-RVA: 0x3E32A60 Offset: 0x3E32B61 VA: 0x3E32A60
	|-List<Detail.AsyncResultInt>.BinarySearch
	|
	|-RVA: 0x3E35D30 Offset: 0x3E35E31 VA: 0x3E35D30
	|-List<Detail.CppArray>.BinarySearch
	|
	|-RVA: 0x3E38D30 Offset: 0x3E38E31 VA: 0x3E38D30
	|-List<Detail.NotificationEventInt>.BinarySearch
	|
	|-RVA: 0x3E5B3E0 Offset: 0x3E5B4E1 VA: 0x3E5B3E0
	|-List<DragonRideTargetGroup.ChainParam>.BinarySearch
	|
	|-RVA: 0x3E5E3A0 Offset: 0x3E5E4A1 VA: 0x3E5E3A0
	|-List<GmapPathAdjuster.TargetModel>.BinarySearch
	|
	|-RVA: 0x3E615B0 Offset: 0x3E616B1 VA: 0x3E615B0
	|-List<GmapSpotAdjuster.TargetModel>.BinarySearch
	|
	|-RVA: 0x3E647C0 Offset: 0x3E648C1 VA: 0x3E647C0
	|-List<HubFastTravel.Location>.BinarySearch
	|
	|-RVA: 0x3E67A50 Offset: 0x3E67B51 VA: 0x3E67A50
	|-List<HubLensFlare.Flare>.BinarySearch
	|
	|-RVA: 0x3E6AD70 Offset: 0x3E6AE71 VA: 0x3E6AD70
	|-List<InventoryPoolItemMenuContent.KindBgNameClass>.BinarySearch
	|
	|-RVA: 0x3E6DC40 Offset: 0x3E6DD41 VA: 0x3E6DC40
	|-List<Map.Pos>.BinarySearch
	|
	|-RVA: 0x3E70A80 Offset: 0x3E70B81 VA: 0x3E70A80
	|-List<MapImage.BackupTerrain>.BinarySearch
	|
	|-RVA: 0x3E73940 Offset: 0x3E73A41 VA: 0x3E73940
	|-List<MapImageRange.Pos>.BinarySearch
	|
	|-RVA: 0x3E768C0 Offset: 0x3E769C1 VA: 0x3E768C0
	|-List<MapMind.Target>.BinarySearch
	|
	|-RVA: 0x3D864B0 Offset: 0x3D865B1 VA: 0x3D864B0
	|-List<MapPanelDebug.Entity>.BinarySearch
	|
	|-RVA: 0x3D895B0 Offset: 0x3D896B1 VA: 0x3D895B0
	|-List<NexRanking.Data>.BinarySearch
	|
	|-RVA: 0x3D8C3F0 Offset: 0x3D8C4F1 VA: 0x3D8C3F0
	|-List<NexVersus.RatingData>.BinarySearch
	|
	|-RVA: 0x3D8F2F0 Offset: 0x3D8F3F1 VA: 0x3D8F2F0
	|-List<PackedPlayModeBuildLogs.RuntimeBuildLog>.BinarySearch
	|
	|-RVA: 0x3D922F0 Offset: 0x3D923F1 VA: 0x3D922F0
	|-List<ParticleSystem.Particle>.BinarySearch
	|
	|-RVA: 0x3D95570 Offset: 0x3D95671 VA: 0x3D95570
	|-List<RangeData.Offset>.BinarySearch
	|
	|-RVA: 0x3D98470 Offset: 0x3D98571 VA: 0x3D98470
	|-List<RenderGraphDebugData.PassDebugData>.BinarySearch
	|
	|-RVA: 0x3D9B700 Offset: 0x3D9B801 VA: 0x3D9B700
	|-List<RenderGraphDebugData.ResourceDebugData>.BinarySearch
	|
	|-RVA: 0x3D9E9C0 Offset: 0x3D9EAC1 VA: 0x3D9E9C0
	|-List<RingCleaningUnitSelectMenu.GodParam>.BinarySearch
	|
	|-RVA: 0x3DA19E0 Offset: 0x3DA1AE1 VA: 0x3DA19E0
	|-List<ShadowUtility.Edge>.BinarySearch
	|
	|-RVA: 0x3D140E0 Offset: 0x3D141E1 VA: 0x3D140E0
	|-List<SkillArray.Entity>.BinarySearch
	|
	|-RVA: 0x3D17090 Offset: 0x3D17191 VA: 0x3D17090
	|-List<TexturePacker_JsonArray.Frame>.BinarySearch
	|
	|-RVA: 0x3D1A5B0 Offset: 0x3D1A6B1 VA: 0x3D1A5B0
	|-List<TimeNotificationBehaviour.NotificationEntry>.BinarySearch
	|
	|-RVA: 0x3D1D7D0 Offset: 0x3D1D8D1 VA: 0x3D1D7D0
	|-List<UnitySynchronizationContext.WorkRequest>.BinarySearch
	|
	|-RVA: 0x3D20940 Offset: 0x3D20A41 VA: 0x3D20940
	|-List<XmlSchemaObjectTable.XmlSchemaObjectEntry>.BinarySearch
	|
	|-RVA: 0x3D23860 Offset: 0x3D23961 VA: 0x3D23860
	|-List<AssetBundleBuildMap.AssetBundleEntry.AssetPathString>.BinarySearch
	|
	|-RVA: 0x3D26880 Offset: 0x3D26981 VA: 0x3D26880
	|-List<Detail.DataStore.DataStoreChangeMetaParamInt>.BinarySearch
	|
	|-RVA: 0x3D29B80 Offset: 0x3D29C81 VA: 0x3D29B80
	|-List<Detail.DataStore.DataStoreDeleteParamInt>.BinarySearch
	|
	|-RVA: 0x3D2CB80 Offset: 0x3D2CC81 VA: 0x3D2CB80
	|-List<Detail.DataStore.DataStoreGetMetaParamInt>.BinarySearch
	|
	|-RVA: 0x3D2FF00 Offset: 0x3D30001 VA: 0x3D2FF00
	|-List<Detail.DataStore.DataStoreMetaInfoInt>.BinarySearch
	|
	|-RVA: 0x3CF46F0 Offset: 0x3CF47F1 VA: 0x3CF46F0
	|-List<Detail.DataStore.DataStorePasswordInfoInt>.BinarySearch
	|
	|-RVA: 0x3CF78D0 Offset: 0x3CF79D1 VA: 0x3CF78D0
	|-List<Detail.DataStore.DataStorePersistenceInfoInt>.BinarySearch
	|
	|-RVA: 0x3CFAB00 Offset: 0x3CFAC01 VA: 0x3CFAB00
	|-List<Detail.DataStore.DataStorePreparePostParamInt>.BinarySearch
	|
	|-RVA: 0x3CFDDB0 Offset: 0x3CFDEB1 VA: 0x3CFDDB0
	|-List<Detail.DataStore.DataStoreRateObjectParamInt>.BinarySearch
	|
	|-RVA: 0x3D00D40 Offset: 0x3D00E41 VA: 0x3D00D40
	|-List<Detail.DataStore.DataStoreRatingInitParamInt>.BinarySearch
	|
	|-RVA: 0x3D03E80 Offset: 0x3D03F81 VA: 0x3D03E80
	|-List<Detail.DataStore.DataStoreRatingTargetInt>.BinarySearch
	|
	|-RVA: 0x3D06EC0 Offset: 0x3D06FC1 VA: 0x3D06EC0
	|-List<Detail.Ranking.RankingCachedResultInt>.BinarySearch
	|
	|-RVA: 0x3D0A340 Offset: 0x3D0A441 VA: 0x3D0A340
	|-List<Detail.Ranking.RankingOrderParamInt>.BinarySearch
	|
	|-RVA: 0x3D0D380 Offset: 0x3D0D481 VA: 0x3D0D380
	|-List<Detail.Ranking.RankingRankDataInt>.BinarySearch
	|
	|-RVA: 0x3D10A00 Offset: 0x3D10B01 VA: 0x3D10A00
	|-List<Detail.Ranking2.Ranking2ChartInfoInt>.BinarySearch
	|
	|-RVA: 0x3D67300 Offset: 0x3D67401 VA: 0x3D67300
	|-List<Detail.Ranking2.Ranking2RankDataInt>.BinarySearch
	|
	|-RVA: 0x3D6A720 Offset: 0x3D6A821 VA: 0x3D6A720
	|-List<Detail.Ranking2.Ranking2ScoreDataInt>.BinarySearch
	|
	|-RVA: 0x3D6D6B0 Offset: 0x3D6D7B1 VA: 0x3D6D6B0
	|-List<Detail.Screening.ScreeningContextInfoInt>.BinarySearch
	|
	|-RVA: 0x3D709F0 Offset: 0x3D70AF1 VA: 0x3D709F0
	|-List<Detail.Subscriber.SubscriberContentInt>.BinarySearch
	|
	|-RVA: 0x3D74070 Offset: 0x3D74171 VA: 0x3D74070
	|-List<Detail.Subscriber.SubscriberGetContentParamInt>.BinarySearch
	|
	|-RVA: 0x3D772C0 Offset: 0x3D773C1 VA: 0x3D772C0
	|-List<Detail.Subscriber.SubscriberUserStatusInfoInt>.BinarySearch
	|
	|-RVA: 0x3D7A5F0 Offset: 0x3D7A6F1 VA: 0x3D7A5F0
	|-List<Detail.Subscriber.SubscriberUserStatusParamInt>.BinarySearch
	|
	|-RVA: 0x3D7D6F0 Offset: 0x3D7D7F1 VA: 0x3D7D6F0
	|-List<Detail.Utility.IntegerSettings>.BinarySearch
	|
	|-RVA: 0x3D80530 Offset: 0x3D80631 VA: 0x3D80530
	|-List<Detail.Utility.UniqueIdInfoInt>.BinarySearch
	|
	|-RVA: 0x3D83440 Offset: 0x3D83541 VA: 0x3D83440
	|-List<MapHistory.Rewind.LatestInspectorData>.BinarySearch
	|
	|-RVA: 0x305F700 Offset: 0x305F801 VA: 0x305F700
	|-List<MapHistory.Rewind.WorkTerrainData>.BinarySearch
	|
	|-RVA: 0x30626E0 Offset: 0x30627E1 VA: 0x30626E0
	|-List<MapSkill.AroundCalculator.Result>.BinarySearch
	|
	|-RVA: 0x3065700 Offset: 0x3065801 VA: 0x3065700
	|-List<TargetPositionCache.CacheCurve.Item>.BinarySearch
	|
	|-RVA: 0x3068AA0 Offset: 0x3068BA1 VA: 0x3068AA0
	|-List<TargetPositionCache.CacheEntry.RecordingItem>.BinarySearch
	*/

	// RVA: -1 Offset: -1
	public int BinarySearch(T item, IComparer<T> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3B0B490 Offset: 0x3B0B591 VA: 0x3B0B490
	|-List<IntervalTree.Entry<object>>.BinarySearch
	|
	|-RVA: 0x3B0E5E0 Offset: 0x3B0E6E1 VA: 0x3B0E5E0
	|-List<KeyValuePair<DateTime, object>>.BinarySearch
	|
	|-RVA: 0x3B11500 Offset: 0x3B11601 VA: 0x3B11500
	|-List<KeyValuePair<int, object>>.BinarySearch
	|
	|-RVA: 0x3B144E0 Offset: 0x3B145E1 VA: 0x3B144E0
	|-List<KeyValuePair<object, ValueTuple<int, DateTime, object>>>.BinarySearch
	|
	|-RVA: 0x3B17640 Offset: 0x3B17741 VA: 0x3B17640
	|-List<KeyValuePair<object, object>>.BinarySearch
	|
	|-RVA: 0x3B1A620 Offset: 0x3B1A721 VA: 0x3B1A620
	|-List<CommonBattleSequence.Reliance<object>>.BinarySearch
	|
	|-RVA: 0x3B1D770 Offset: 0x3B1D871 VA: 0x3B1D770
	|-List<RenderGraphResourcePool.ResourceLogInfo<object>>.BinarySearch
	|
	|-RVA: 0x3B20690 Offset: 0x3B20791 VA: 0x3B20690
	|-List<ValueTuple<int, object>>.BinarySearch
	|
	|-RVA: 0x3DE12C0 Offset: 0x3DE13C1 VA: 0x3DE12C0
	|-List<ValueTuple<Int32Enum, int>>.BinarySearch
	|
	|-RVA: 0x3DE41F0 Offset: 0x3DE42F1 VA: 0x3DE41F0
	|-List<ValueTuple<object, ValueTuple<object, int>>>.BinarySearch
	|
	|-RVA: 0x3DE7340 Offset: 0x3DE7441 VA: 0x3DE7340
	|-List<ValueTuple<object, int>>.BinarySearch
	|
	|-RVA: 0x3DEA2B0 Offset: 0x3DEA3B1 VA: 0x3DEA2B0
	|-List<ValueTuple<Vector3, float>>.BinarySearch
	|
	|-RVA: 0x3DED260 Offset: 0x3DED361 VA: 0x3DED260
	|-List<ValueTuple<object, Int32Enum, int>>.BinarySearch
	|
	|-RVA: 0x3DF0240 Offset: 0x3DF0341 VA: 0x3DF0240
	|-List<ValueTuple<object, int, int, int>>.BinarySearch
	|
	|-RVA: 0x3E11370 Offset: 0x3E11471 VA: 0x3E11370
	|-List<AkEnvironment>.BinarySearch
	|-List<AkRoom>.BinarySearch
	|-List<object>.BinarySearch
	|
	|-RVA: 0x3DF3330 Offset: 0x3DF3431 VA: 0x3DF3330
	|-List<AnimatorClipInfo>.BinarySearch
	|
	|-RVA: 0x3DF6260 Offset: 0x3DF6361 VA: 0x3DF6260
	|-List<AsyncOperationHandle>.BinarySearch
	|
	|-RVA: 0x3DF9460 Offset: 0x3DF9561 VA: 0x3DF9460
	|-List<BoneWeight>.BinarySearch
	|
	|-RVA: 0x3DFC550 Offset: 0x3DFC651 VA: 0x3DFC550
	|-List<bool>.BinarySearch
	|
	|-RVA: 0x3E79AA0 Offset: 0x3E79BA1 VA: 0x3E79AA0
	|-List<byte>.BinarySearch
	|
	|-RVA: 0x3E7C910 Offset: 0x3E7CA11 VA: 0x3E7C910
	|-List<CameraInfo>.BinarySearch
	|
	|-RVA: 0x3E7F7D0 Offset: 0x3E7F8D1 VA: 0x3E7F7D0
	|-List<char>.BinarySearch
	|
	|-RVA: 0x3E82680 Offset: 0x3E82781 VA: 0x3E82680
	|-List<Color>.BinarySearch
	|
	|-RVA: 0x3E855D0 Offset: 0x3E856D1 VA: 0x3E855D0
	|-List<Color32>.BinarySearch
	|
	|-RVA: 0x3E88440 Offset: 0x3E88541 VA: 0x3E88440
	|-List<ConstraintSource>.BinarySearch
	|
	|-RVA: 0x3E8B420 Offset: 0x3E8B521 VA: 0x3E8B420
	|-List<ContourVertex>.BinarySearch
	|
	|-RVA: 0x3E8E620 Offset: 0x3E8E721 VA: 0x3E8E620
	|-List<DataStoreRatingInfo>.BinarySearch
	|
	|-RVA: 0x3E916F0 Offset: 0x3E917F1 VA: 0x3E916F0
	|-List<DataStoreResult>.BinarySearch
	|
	|-RVA: 0x3E94500 Offset: 0x3E94601 VA: 0x3E94500
	|-List<DateTime>.BinarySearch
	|
	|-RVA: 0x3E97350 Offset: 0x3E97451 VA: 0x3E97350
	|-List<DateTimeOffset>.BinarySearch
	|
	|-RVA: 0x3E9A230 Offset: 0x3E9A331 VA: 0x3E9A230
	|-List<Decimal>.BinarySearch
	|
	|-RVA: 0x3E9D280 Offset: 0x3E9D381 VA: 0x3E9D280
	|-List<DiagnosticEvent>.BinarySearch
	|
	|-RVA: 0x3EA0530 Offset: 0x3EA0631 VA: 0x3EA0530
	|-List<double>.BinarySearch
	|
	|-RVA: 0x3EA3490 Offset: 0x3EA3591 VA: 0x3EA3490
	|-List<Friend>.BinarySearch
	|
	|-RVA: 0x3EA6700 Offset: 0x3EA6801 VA: 0x3EA6700
	|-List<GlyphRect>.BinarySearch
	|
	|-RVA: 0x3EA95A0 Offset: 0x3EA96A1 VA: 0x3EA95A0
	|-List<short>.BinarySearch
	|
	|-RVA: 0x3EAC3A0 Offset: 0x3EAC4A1 VA: 0x3EAC3A0
	|-List<int>.BinarySearch
	|
	|-RVA: 0x3EAF1A0 Offset: 0x3EAF2A1 VA: 0x3EAF1A0
	|-List<Int32Enum>.BinarySearch
	|
	|-RVA: 0x3EB1FA0 Offset: 0x3EB20A1 VA: 0x3EB1FA0
	|-List<long>.BinarySearch
	|
	|-RVA: 0x3DFF370 Offset: 0x3DFF471 VA: 0x3DFF370
	|-List<IntPtr>.BinarySearch
	|
	|-RVA: 0x3E021D0 Offset: 0x3E022D1 VA: 0x3E021D0
	|-List<InterpretedFrameInfo>.BinarySearch
	|
	|-RVA: 0x3E051A0 Offset: 0x3E052A1 VA: 0x3E051A0
	|-List<IntervalTreeNode>.BinarySearch
	|
	|-RVA: 0x3E08270 Offset: 0x3E08371 VA: 0x3E08270
	|-List<LengthLimitProperties>.BinarySearch
	|
	|-RVA: 0x3E0B080 Offset: 0x3E0B181 VA: 0x3E0B080
	|-List<MapPos>.BinarySearch
	|
	|-RVA: 0x3E0E070 Offset: 0x3E0E171 VA: 0x3E0E070
	|-List<Matrix4x4>.BinarySearch
	|
	|-RVA: 0x3E14380 Offset: 0x3E14481 VA: 0x3E14380
	|-List<ObjectInitializationData>.BinarySearch
	|
	|-RVA: 0x3E17730 Offset: 0x3E17831 VA: 0x3E17730
	|-List<PlayableBinding>.BinarySearch
	|
	|-RVA: 0x3E1A9D0 Offset: 0x3E1AAD1 VA: 0x3E1A9D0
	|-List<PlayerLoopSystem>.BinarySearch
	|
	|-RVA: 0x3DA4E70 Offset: 0x3DA4F71 VA: 0x3DA4E70
	|-List<PlayerLoopSystemInternal>.BinarySearch
	|
	|-RVA: 0x3DA8100 Offset: 0x3DA8201 VA: 0x3DA8100
	|-List<RangePositionInfo>.BinarySearch
	|
	|-RVA: 0x3DAAFC0 Offset: 0x3DAB0C1 VA: 0x3DAAFC0
	|-List<Ranking2ChartInfoInput>.BinarySearch
	|
	|-RVA: 0x3DADF80 Offset: 0x3DAE081 VA: 0x3DADF80
	|-List<RaycastHit2D>.BinarySearch
	|
	|-RVA: 0x3DB14A0 Offset: 0x3DB15A1 VA: 0x3DB14A0
	|-List<RaycastResult>.BinarySearch
	|
	|-RVA: 0x3DB4AB0 Offset: 0x3DB4BB1 VA: 0x3DB4AB0
	|-List<Rect>.BinarySearch
	|
	|-RVA: 0x3DB7A00 Offset: 0x3DB7B01 VA: 0x3DB7A00
	|-List<RendererListHandle>.BinarySearch
	|
	|-RVA: 0x3DBA810 Offset: 0x3DBA911 VA: 0x3DBA810
	|-List<ResourceHandle>.BinarySearch
	|
	|-RVA: 0x3DBD620 Offset: 0x3DBD721 VA: 0x3DBD620
	|-List<sbyte>.BinarySearch
	|
	|-RVA: 0x3DC0430 Offset: 0x3DC0531 VA: 0x3DC0430
	|-List<ShaderTagId>.BinarySearch
	|
	|-RVA: 0x3E3C0B0 Offset: 0x3E3C1B1 VA: 0x3E3C0B0
	|-List<float>.BinarySearch
	|
	|-RVA: 0x3E3F2A0 Offset: 0x3E3F3A1 VA: 0x3E3F2A0
	|-List<SphericalHarmonicsL2>.BinarySearch
	|
	|-RVA: 0x3E42D20 Offset: 0x3E42E21 VA: 0x3E42D20
	|-List<SubMeshDescriptor>.BinarySearch
	|
	|-RVA: 0x3E45FE0 Offset: 0x3E460E1 VA: 0x3E45FE0
	|-List<TablePair>.BinarySearch
	|
	|-RVA: 0x3E48EA0 Offset: 0x3E48FA1 VA: 0x3E48EA0
	|-List<TimeSpan>.BinarySearch
	|
	|-RVA: 0x3E4BD30 Offset: 0x3E4BE31 VA: 0x3E4BD30
	|-List<UICharInfo>.BinarySearch
	|
	|-RVA: 0x3E4ECD0 Offset: 0x3E4EDD1 VA: 0x3E4ECD0
	|-List<UILineInfo>.BinarySearch
	|
	|-RVA: 0x3E51F60 Offset: 0x3E52061 VA: 0x3E51F60
	|-List<UIVertex>.BinarySearch
	|
	|-RVA: 0x3E55850 Offset: 0x3E55951 VA: 0x3E55850
	|-List<ushort>.BinarySearch
	|
	|-RVA: 0x3E58650 Offset: 0x3E58751 VA: 0x3E58650
	|-List<uint>.BinarySearch
	|
	|-RVA: 0x3DC3240 Offset: 0x3DC3341 VA: 0x3DC3240
	|-List<ulong>.BinarySearch
	|
	|-RVA: 0x3DC6070 Offset: 0x3DC6171 VA: 0x3DC6070
	|-List<Vector2>.BinarySearch
	|
	|-RVA: 0x3DC8F90 Offset: 0x3DC9091 VA: 0x3DC8F90
	|-List<Vector3>.BinarySearch
	|
	|-RVA: 0x3DCBFA0 Offset: 0x3DCC0A1 VA: 0x3DCBFA0
	|-List<Vector4>.BinarySearch
	|
	|-RVA: 0x3DCEF30 Offset: 0x3DCF031 VA: 0x3DCEF30
	|-List<VertexAttributeDescriptor>.BinarySearch
	|
	|-RVA: 0x3DD1E30 Offset: 0x3DD1F31 VA: 0x3DD1E30
	|-List<X509ChainStatus>.BinarySearch
	|
	|-RVA: 0x3DD4E70 Offset: 0x3DD4F71 VA: 0x3DD4E70
	|-List<XRView>.BinarySearch
	|
	|-RVA: 0x3DD8140 Offset: 0x3DD8241 VA: 0x3DD8140
	|-List<AmiiboSequence.GainItemData>.BinarySearch
	|
	|-RVA: 0x3DDB190 Offset: 0x3DDB291 VA: 0x3DDB190
	|-List<AnimationOutputWeightProcessor.WeightInfo>.BinarySearch
	|
	|-RVA: 0x3DDE400 Offset: 0x3DDE501 VA: 0x3DDE400
	|-List<ArenaOrderSequence.GodInfo>.BinarySearch
	|
	|-RVA: 0x3E1DC60 Offset: 0x3E1DD61 VA: 0x3E1DC60
	|-List<BattleInfo.SupportData>.BinarySearch
	|
	|-RVA: 0x3E20B80 Offset: 0x3E20C81 VA: 0x3E20B80
	|-List<BeforeRenderHelper.OrderBlock>.BinarySearch
	|
	|-RVA: 0x3E23B70 Offset: 0x3E23C71 VA: 0x3E23B70
	|-List<Camera.RenderRequest>.BinarySearch
	|
	|-RVA: 0x3E26CD0 Offset: 0x3E26DD1 VA: 0x3E26CD0
	|-List<CameraState.CustomBlendable>.BinarySearch
	|
	|-RVA: 0x3E29B90 Offset: 0x3E29C91 VA: 0x3E29B90
	|-List<CinemachineClearShot.Pair>.BinarySearch
	|
	|-RVA: 0x3E2C9A0 Offset: 0x3E2CAA1 VA: 0x3E2C9A0
	|-List<CinemachineStateDrivenCamera.HashPair>.BinarySearch
	|
	|-RVA: 0x3E2F8D0 Offset: 0x3E2F9D1 VA: 0x3E2F8D0
	|-List<DelayedActionManager.DelegateInfo>.BinarySearch
	|
	|-RVA: 0x3E32B60 Offset: 0x3E32C61 VA: 0x3E32B60
	|-List<Detail.AsyncResultInt>.BinarySearch
	|
	|-RVA: 0x3E35E00 Offset: 0x3E35F01 VA: 0x3E35E00
	|-List<Detail.CppArray>.BinarySearch
	|
	|-RVA: 0x3E38E30 Offset: 0x3E38F31 VA: 0x3E38E30
	|-List<Detail.NotificationEventInt>.BinarySearch
	|
	|-RVA: 0x3E5B4B0 Offset: 0x3E5B5B1 VA: 0x3E5B4B0
	|-List<DragonRideTargetGroup.ChainParam>.BinarySearch
	|
	|-RVA: 0x3E5E490 Offset: 0x3E5E591 VA: 0x3E5E490
	|-List<GmapPathAdjuster.TargetModel>.BinarySearch
	|
	|-RVA: 0x3E616A0 Offset: 0x3E617A1 VA: 0x3E616A0
	|-List<GmapSpotAdjuster.TargetModel>.BinarySearch
	|
	|-RVA: 0x3E648B0 Offset: 0x3E649B1 VA: 0x3E648B0
	|-List<HubFastTravel.Location>.BinarySearch
	|
	|-RVA: 0x3E67B50 Offset: 0x3E67C51 VA: 0x3E67B50
	|-List<HubLensFlare.Flare>.BinarySearch
	|
	|-RVA: 0x3E6AE40 Offset: 0x3E6AF41 VA: 0x3E6AE40
	|-List<InventoryPoolItemMenuContent.KindBgNameClass>.BinarySearch
	|
	|-RVA: 0x3E6DD00 Offset: 0x3E6DE01 VA: 0x3E6DD00
	|-List<Map.Pos>.BinarySearch
	|
	|-RVA: 0x3E70B50 Offset: 0x3E70C51 VA: 0x3E70B50
	|-List<MapImage.BackupTerrain>.BinarySearch
	|
	|-RVA: 0x3E73A00 Offset: 0x3E73B01 VA: 0x3E73A00
	|-List<MapImageRange.Pos>.BinarySearch
	|
	|-RVA: 0x3E769B0 Offset: 0x3E76AB1 VA: 0x3E769B0
	|-List<MapMind.Target>.BinarySearch
	|
	|-RVA: 0x3D865A0 Offset: 0x3D866A1 VA: 0x3D865A0
	|-List<MapPanelDebug.Entity>.BinarySearch
	|
	|-RVA: 0x3D89670 Offset: 0x3D89771 VA: 0x3D89670
	|-List<NexRanking.Data>.BinarySearch
	|
	|-RVA: 0x3D8C4C0 Offset: 0x3D8C5C1 VA: 0x3D8C4C0
	|-List<NexVersus.RatingData>.BinarySearch
	|
	|-RVA: 0x3D8F3C0 Offset: 0x3D8F4C1 VA: 0x3D8F3C0
	|-List<PackedPlayModeBuildLogs.RuntimeBuildLog>.BinarySearch
	|
	|-RVA: 0x3D923F0 Offset: 0x3D924F1 VA: 0x3D923F0
	|-List<ParticleSystem.Particle>.BinarySearch
	|
	|-RVA: 0x3D95630 Offset: 0x3D95731 VA: 0x3D95630
	|-List<RangeData.Offset>.BinarySearch
	|
	|-RVA: 0x3D98560 Offset: 0x3D98661 VA: 0x3D98560
	|-List<RenderGraphDebugData.PassDebugData>.BinarySearch
	|
	|-RVA: 0x3D9B800 Offset: 0x3D9B901 VA: 0x3D9B800
	|-List<RenderGraphDebugData.ResourceDebugData>.BinarySearch
	|
	|-RVA: 0x3D9EA90 Offset: 0x3D9EB91 VA: 0x3D9EA90
	|-List<RingCleaningUnitSelectMenu.GodParam>.BinarySearch
	|
	|-RVA: 0x3DA1AE0 Offset: 0x3DA1BE1 VA: 0x3DA1AE0
	|-List<ShadowUtility.Edge>.BinarySearch
	|
	|-RVA: 0x3D141A0 Offset: 0x3D142A1 VA: 0x3D141A0
	|-List<SkillArray.Entity>.BinarySearch
	|
	|-RVA: 0x3D171A0 Offset: 0x3D172A1 VA: 0x3D171A0
	|-List<TexturePacker_JsonArray.Frame>.BinarySearch
	|
	|-RVA: 0x3D1A6A0 Offset: 0x3D1A7A1 VA: 0x3D1A6A0
	|-List<TimeNotificationBehaviour.NotificationEntry>.BinarySearch
	|
	|-RVA: 0x3D1D8C0 Offset: 0x3D1D9C1 VA: 0x3D1D8C0
	|-List<UnitySynchronizationContext.WorkRequest>.BinarySearch
	|
	|-RVA: 0x3D20A10 Offset: 0x3D20B11 VA: 0x3D20A10
	|-List<XmlSchemaObjectTable.XmlSchemaObjectEntry>.BinarySearch
	|
	|-RVA: 0x3D23930 Offset: 0x3D23A31 VA: 0x3D23930
	|-List<AssetBundleBuildMap.AssetBundleEntry.AssetPathString>.BinarySearch
	|
	|-RVA: 0x3D26980 Offset: 0x3D26A81 VA: 0x3D26980
	|-List<Detail.DataStore.DataStoreChangeMetaParamInt>.BinarySearch
	|
	|-RVA: 0x3D29C50 Offset: 0x3D29D51 VA: 0x3D29C50
	|-List<Detail.DataStore.DataStoreDeleteParamInt>.BinarySearch
	|
	|-RVA: 0x3D2CC80 Offset: 0x3D2CD81 VA: 0x3D2CC80
	|-List<Detail.DataStore.DataStoreGetMetaParamInt>.BinarySearch
	|
	|-RVA: 0x3D30000 Offset: 0x3D30101 VA: 0x3D30000
	|-List<Detail.DataStore.DataStoreMetaInfoInt>.BinarySearch
	|
	|-RVA: 0x3CF47E0 Offset: 0x3CF48E1 VA: 0x3CF47E0
	|-List<Detail.DataStore.DataStorePasswordInfoInt>.BinarySearch
	|
	|-RVA: 0x3CF79C0 Offset: 0x3CF7AC1 VA: 0x3CF79C0
	|-List<Detail.DataStore.DataStorePersistenceInfoInt>.BinarySearch
	|
	|-RVA: 0x3CFAC00 Offset: 0x3CFAD01 VA: 0x3CFAC00
	|-List<Detail.DataStore.DataStorePreparePostParamInt>.BinarySearch
	|
	|-RVA: 0x3CFDE80 Offset: 0x3CFDF81 VA: 0x3CFDE80
	|-List<Detail.DataStore.DataStoreRateObjectParamInt>.BinarySearch
	|
	|-RVA: 0x3D00E30 Offset: 0x3D00F31 VA: 0x3D00E30
	|-List<Detail.DataStore.DataStoreRatingInitParamInt>.BinarySearch
	|
	|-RVA: 0x3D03F50 Offset: 0x3D04051 VA: 0x3D03F50
	|-List<Detail.DataStore.DataStoreRatingTargetInt>.BinarySearch
	|
	|-RVA: 0x3D06FE0 Offset: 0x3D070E1 VA: 0x3D06FE0
	|-List<Detail.Ranking.RankingCachedResultInt>.BinarySearch
	|
	|-RVA: 0x3D0A410 Offset: 0x3D0A511 VA: 0x3D0A410
	|-List<Detail.Ranking.RankingOrderParamInt>.BinarySearch
	|
	|-RVA: 0x3D0D490 Offset: 0x3D0D591 VA: 0x3D0D490
	|-List<Detail.Ranking.RankingRankDataInt>.BinarySearch
	|
	|-RVA: 0x3D10B30 Offset: 0x3D10C31 VA: 0x3D10B30
	|-List<Detail.Ranking2.Ranking2ChartInfoInt>.BinarySearch
	|
	|-RVA: 0x3D67410 Offset: 0x3D67511 VA: 0x3D67410
	|-List<Detail.Ranking2.Ranking2RankDataInt>.BinarySearch
	|
	|-RVA: 0x3D6A7F0 Offset: 0x3D6A8F1 VA: 0x3D6A7F0
	|-List<Detail.Ranking2.Ranking2ScoreDataInt>.BinarySearch
	|
	|-RVA: 0x3D6D7A0 Offset: 0x3D6D8A1 VA: 0x3D6D7A0
	|-List<Detail.Screening.ScreeningContextInfoInt>.BinarySearch
	|
	|-RVA: 0x3D70B20 Offset: 0x3D70C21 VA: 0x3D70B20
	|-List<Detail.Subscriber.SubscriberContentInt>.BinarySearch
	|
	|-RVA: 0x3D74160 Offset: 0x3D74261 VA: 0x3D74160
	|-List<Detail.Subscriber.SubscriberGetContentParamInt>.BinarySearch
	|
	|-RVA: 0x3D773C0 Offset: 0x3D774C1 VA: 0x3D773C0
	|-List<Detail.Subscriber.SubscriberUserStatusInfoInt>.BinarySearch
	|
	|-RVA: 0x3D7A6E0 Offset: 0x3D7A7E1 VA: 0x3D7A6E0
	|-List<Detail.Subscriber.SubscriberUserStatusParamInt>.BinarySearch
	|
	|-RVA: 0x3D7D7B0 Offset: 0x3D7D8B1 VA: 0x3D7D7B0
	|-List<Detail.Utility.IntegerSettings>.BinarySearch
	|
	|-RVA: 0x3D80600 Offset: 0x3D80701 VA: 0x3D80600
	|-List<Detail.Utility.UniqueIdInfoInt>.BinarySearch
	|
	|-RVA: 0x3D83500 Offset: 0x3D83601 VA: 0x3D83500
	|-List<MapHistory.Rewind.LatestInspectorData>.BinarySearch
	|
	|-RVA: 0x305F7C0 Offset: 0x305F8C1 VA: 0x305F7C0
	|-List<MapHistory.Rewind.WorkTerrainData>.BinarySearch
	|
	|-RVA: 0x30627B0 Offset: 0x30628B1 VA: 0x30627B0
	|-List<MapSkill.AroundCalculator.Result>.BinarySearch
	|
	|-RVA: 0x3065800 Offset: 0x3065901 VA: 0x3065800
	|-List<TargetPositionCache.CacheCurve.Item>.BinarySearch
	|
	|-RVA: 0x3068BA0 Offset: 0x3068CA1 VA: 0x3068BA0
	|-List<TargetPositionCache.CacheEntry.RecordingItem>.BinarySearch
	*/

	// RVA: -1 Offset: -1 Slot: 22
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3B0B530 Offset: 0x3B0B631 VA: 0x3B0B530
	|-List<IntervalTree.Entry<object>>.Clear
	|
	|-RVA: 0x3B176C0 Offset: 0x3B177C1 VA: 0x3B176C0
	|-List<KeyValuePair<AnimationClip, AnimationClip>>.Clear
	|-List<KeyValuePair<object, object>>.Clear
	|
	|-RVA: 0x3B0E660 Offset: 0x3B0E761 VA: 0x3B0E660
	|-List<KeyValuePair<DateTime, object>>.Clear
	|
	|-RVA: 0x3B14580 Offset: 0x3B14681 VA: 0x3B14580
	|-List<KeyValuePair<IAwaiter, ValueTuple<int, DateTime, string>>>.Clear
	|-List<KeyValuePair<object, ValueTuple<int, DateTime, object>>>.Clear
	|
	|-RVA: 0x3B11580 Offset: 0x3B11681 VA: 0x3B11580
	|-List<KeyValuePair<int, object>>.Clear
	|
	|-RVA: 0x3E113E0 Offset: 0x3E114E1 VA: 0x3E113E0
	|-List<List<int>>.Clear
	|-List<MiniMapController.TImage<Image>>.Clear
	|-List<MiniMapController.TImage<UnitIcon>>.Clear
	|-List<AccessoryData>.Clear
	|-List<AchieveData>.Clear
	|-List<AkAudioListener>.Clear
	|-List<AkGameObj>.Clear
	|-List<AkRoom>.Clear
	|-List<AkRoomAwareObject>.Clear
	|-List<AkRoomPortal>.Clear
	|-List<AkSurfaceReflector>.Clear
	|-List<Animator>.Clear
	|-List<AssetTableItem>.Clear
	|-List<BaseInvokableCall>.Clear
	|-List<BasicMenuItem>.Clear
	|-List<BasicMenuSelect>.Clear
	|-List<BattleInfoSide>.Clear
	|-List<CalculatorCommand>.Clear
	|-List<Camera>.Clear
	|-List<CharacterProportion>.Clear
	|-List<Collider>.Clear
	|-List<CookData>.Clear
	|-List<DataStoreDeleteParam>.Clear
	|-List<DataStoreGetMetaParam>.Clear
	|-List<DataStoreRatingTarget>.Clear
	|-List<DebugUIHandlerPanel>.Clear
	|-List<DebugUIHandlerValue>.Clear
	|-List<Decorator>.Clear
	|-List<DynValue>.Clear
	|-List<EventCharacterMouthController>.Clear
	|-List<FileData>.Clear
	|-List<FoodstuffData>.Clear
	|-List<ForceProvider>.Clear
	|-List<GameObject>.Clear
	|-List<Glyph>.Clear
	|-List<GmapSpot>.Clear
	|-List<GodUnit>.Clear
	|-List<GotoStatement>.Clear
	|-List<Graphic>.Clear
	|-List<HubAccess>.Clear
	|-List<HubAccessData>.Clear
	|-List<HubAccessManager>.Clear
	|-List<HubAreaFog>.Clear
	|-List<HubManualCulling>.Clear
	|-List<HubUnitController>.Clear
	|-List<IAsyncOperation>.Clear
	|-List<ICanvasElement>.Clear
	|-List<IDisposable>.Clear
	|-List<IEventSystemHandler>.Clear
	|-List<IMarker>.Clear
	|-List<ISpringManager>.Clear
	|-List<ITimelineEvaluateCallback>.Clear
	|-List<IntegratedSubsystem>.Clear
	|-List<IntegratedSubsystemDescriptor>.Clear
	|-List<InteractionTrigger>.Clear
	|-List<ItemData>.Clear
	|-List<Light2D>.Clear
	|-List<MapBackup>.Clear
	|-List<MapCollision>.Clear
	|-List<MapInfoRoot>.Clear
	|-List<MapInspector>.Clear
	|-List<MapObject>.Clear
	|-List<MascotColorChangeItemContent>.Clear
	|-List<Material>.Clear
	|-List<MaterialPropertyBlock>.Clear
	|-List<MenuItem>.Clear
	|-List<Note>.Clear
	|-List<object>.Clear
	|-List<Phase>.Clear
	|-List<PhotographPauseData>.Clear
	|-List<PokeInspector>.Clear
	|-List<ProfileCard>.Clear
	|-List<RankingRankData>.Clear
	|-List<RectMask2D>.Clear
	|-List<RectTransform>.Clear
	|-List<RelayLeavingUnitData>.Clear
	|-List<RelayServerMetaData>.Clear
	|-List<RenderGraphPass>.Clear
	|-List<Renderer>.Clear
	|-List<ResourceGameObject>.Clear
	|-List<ResourceHandle>.Clear
	|-List<RuntimeElement>.Clear
	|-List<ScreeningContextInfo>.Clear
	|-List<ScriptableObject>.Clear
	|-List<ScriptableRenderPass>.Clear
	|-List<SkillData>.Clear
	|-List<SkinQualityLodAdjuster>.Clear
	|-List<SkinnedMeshRenderer>.Clear
	|-List<SpringCollider>.Clear
	|-List<Sprite>.Clear
	|-List<string>.Clear
	|-List<Subsystem>.Clear
	|-List<SubsystemWithProvider>.Clear
	|-List<TMP_Character>.Clear
	|-List<TMP_FontAsset>.Clear
	|-List<TMP_GlyphPairAdjustmentRecord>.Clear
	|-List<TMP_SpriteCharacter>.Clear
	|-List<TMP_SpriteGlyph>.Clear
	|-List<TMP_Text>.Clear
	|-List<TimelineClip>.Clear
	|-List<Timer>.Clear
	|-List<TrackAsset>.Clear
	|-List<Transform>.Clear
	|-List<Unit>.Clear
	|-List<UnitItem>.Clear
	|-List<ValueCountController>.Clear
	|-List<VersusServerCasualMetaData>.Clear
	|-List<VersusServerRankedMetaData>.Clear
	|-List<VersusServerReplayMetaData>.Clear
	|-List<Volume>.Clear
	|-List<VolumeComponent>.Clear
	|-List<WatchItem>.Clear
	|-List<X509CertificateImpl>.Clear
	|-List<XRPass>.Clear
	|-List<AddressablesImpl.ResourceLocatorInfo>.Clear
	|-List<AkBankManager.BankHandle>.Clear
	|-List<AssetBundleBuildMap.AssetBundleEntry>.Clear
	|-List<AssetTable.Accessory>.Clear
	|-List<BufferedGizmo.Segment>.Clear
	|-List<CalculatorUtil.Entity>.Clear
	|-List<CasualMap.ObjectData>.Clear
	|-List<ChapterRecord.Record>.Clear
	|-List<CinemachineBrain.BrainFrame>.Clear
	|-List<CinemachineImpulseManager.ImpulseEvent>.Clear
	|-List<CinemachineStoryboard.CanvasInfo>.Clear
	|-List<ConstantBuffer.ConstantBufferBase>.Clear
	|-List<DLCManager.MountData>.Clear
	|-List<DamageInfo.Info>.Clear
	|-List<DishSelectMenuCategoryContent.CategoryObject>.Clear
	|-List<Dropdown.DropdownItem>.Clear
	|-List<Dropdown.OptionData>.Clear
	|-List<EventSequence.Coroutine>.Clear
	|-List<GameSaveDataHeaderReader.Handle>.Clear
	|-List<GrassData.SpriteInfo>.Clear
	|-List<HelpManager.Item>.Clear
	|-List<HubMiniMap.IconData>.Clear
	|-List<MapDispos.ActualData>.Clear
	|-List<MapDispos.Pos>.Clear
	|-List<MapEditData.UnitInfo>.Clear
	|-List<MapImageTerrain.MinimapInfo>.Clear
	|-List<MapLayer.Data>.Clear
	|-List<MapObject.DitherPair>.Clear
	|-List<MapObject.RigidInfo>.Clear
	|-List<MapOverlap.Data>.Clear
	|-List<MapTarget.Data>.Clear
	|-List<ProfileCard.FreeStamp>.Clear
	|-List<RelayMessageMenuContent.KindIcon>.Clear
	|-List<RelayUserData.EnteredBattle>.Clear
	|-List<RingListSequence.PageData>.Clear
	|-List<SkillData.Func>.Clear
	|-List<SkillStack.Packet>.Clear
	|-List<SoundSystem.LipSyncData>.Clear
	|-List<SoundSystem.SoundHandle>.Clear
	|-List<StencilMaterial.MatEntry>.Clear
	|-List<TMP_Dropdown.DropdownItem>.Clear
	|-List<TMP_Dropdown.OptionData>.Clear
	|-List<TMP_MaterialManager.FallbackMaterial>.Clear
	|-List<TMP_MaterialManager.MaskingMaterial>.Clear
	|-List<SoundWwise.SoundBankManager.BankHandle>.Clear
	|-List<Versus.DownloadHistory.CheckData>.Clear
	|
	|-RVA: 0x3B1A6C0 Offset: 0x3B1A7C1 VA: 0x3B1A6C0
	|-List<CommonBattleSequence.Reliance<object>>.Clear
	|
	|-RVA: 0x3B1D7F0 Offset: 0x3B1D8F1 VA: 0x3B1D7F0
	|-List<RenderGraphResourcePool.ResourceLogInfo<object>>.Clear
	|
	|-RVA: 0x3B20710 Offset: 0x3B20811 VA: 0x3B20710
	|-List<ValueTuple<int, object>>.Clear
	|
	|-RVA: 0x3DE1330 Offset: 0x3DE1431 VA: 0x3DE1330
	|-List<ValueTuple<Int32Enum, int>>.Clear
	|
	|-RVA: 0x3DE4290 Offset: 0x3DE4391 VA: 0x3DE4290
	|-List<ValueTuple<object, ValueTuple<object, int>>>.Clear
	|-List<ValueTuple<object, ValueTuple<Type, int>>>.Clear
	|
	|-RVA: 0x3DE73C0 Offset: 0x3DE74C1 VA: 0x3DE73C0
	|-List<ValueTuple<object, int>>.Clear
	|-List<ValueTuple<string, int>>.Clear
	|
	|-RVA: 0x3DEA340 Offset: 0x3DEA441 VA: 0x3DEA340
	|-List<ValueTuple<Vector3, float>>.Clear
	|
	|-RVA: 0x3DED2E0 Offset: 0x3DED3E1 VA: 0x3DED2E0
	|-List<ValueTuple<object, Int32Enum, int>>.Clear
	|
	|-RVA: 0x3DF02E0 Offset: 0x3DF03E1 VA: 0x3DF02E0
	|-List<ValueTuple<object, int, int, int>>.Clear
	|
	|-RVA: 0x3DF33A0 Offset: 0x3DF34A1 VA: 0x3DF33A0
	|-List<AnimatorClipInfo>.Clear
	|
	|-RVA: 0x3DF6300 Offset: 0x3DF6401 VA: 0x3DF6300
	|-List<AsyncOperationHandle>.Clear
	|
	|-RVA: 0x3DF9500 Offset: 0x3DF9601 VA: 0x3DF9500
	|-List<BoneWeight>.Clear
	|
	|-RVA: 0x3DFC5C0 Offset: 0x3DFC6C1 VA: 0x3DFC5C0
	|-List<bool>.Clear
	|
	|-RVA: 0x3E79B10 Offset: 0x3E79C11 VA: 0x3E79B10
	|-List<byte>.Clear
	|
	|-RVA: 0x3E7C990 Offset: 0x3E7CA91 VA: 0x3E7C990
	|-List<CameraInfo>.Clear
	|
	|-RVA: 0x3E7F840 Offset: 0x3E7F941 VA: 0x3E7F840
	|-List<char>.Clear
	|
	|-RVA: 0x3E82710 Offset: 0x3E82811 VA: 0x3E82710
	|-List<Color>.Clear
	|
	|-RVA: 0x3E85640 Offset: 0x3E85741 VA: 0x3E85640
	|-List<Color32>.Clear
	|
	|-RVA: 0x3E884C0 Offset: 0x3E885C1 VA: 0x3E884C0
	|-List<ConstraintSource>.Clear
	|
	|-RVA: 0x3E8B4C0 Offset: 0x3E8B5C1 VA: 0x3E8B4C0
	|-List<ContourVertex>.Clear
	|
	|-RVA: 0x3E8E6C0 Offset: 0x3E8E7C1 VA: 0x3E8E6C0
	|-List<DataStoreRatingInfo>.Clear
	|
	|-RVA: 0x3E91760 Offset: 0x3E91861 VA: 0x3E91760
	|-List<DataStoreResult>.Clear
	|
	|-RVA: 0x3EAF210 Offset: 0x3EAF311 VA: 0x3EAF210
	|-List<DataType>.Clear
	|-List<Int32Enum>.Clear
	|-List<ItemData.Kinds>.Clear
	|-List<MapPanelActive.MeshIndex>.Clear
	|-List<MapPanelDeploy.MeshIndex>.Clear
	|-List<MapUIGauge.IconIndex>.Clear
	|-List<TutorialListTopMenu.SelectCategoryType>.Clear
	|
	|-RVA: 0x3E94570 Offset: 0x3E94671 VA: 0x3E94570
	|-List<DateTime>.Clear
	|
	|-RVA: 0x3E973D0 Offset: 0x3E974D1 VA: 0x3E973D0
	|-List<DateTimeOffset>.Clear
	|
	|-RVA: 0x3E9A2B0 Offset: 0x3E9A3B1 VA: 0x3E9A2B0
	|-List<Decimal>.Clear
	|
	|-RVA: 0x3E9D330 Offset: 0x3E9D431 VA: 0x3E9D330
	|-List<DiagnosticEvent>.Clear
	|
	|-RVA: 0x3EA05A0 Offset: 0x3EA06A1 VA: 0x3EA05A0
	|-List<double>.Clear
	|
	|-RVA: 0x3EA3540 Offset: 0x3EA3641 VA: 0x3EA3540
	|-List<Friend>.Clear
	|
	|-RVA: 0x3EA6780 Offset: 0x3EA6881 VA: 0x3EA6780
	|-List<GlyphRect>.Clear
	|
	|-RVA: 0x3EA9610 Offset: 0x3EA9711 VA: 0x3EA9610
	|-List<short>.Clear
	|
	|-RVA: 0x3EAC410 Offset: 0x3EAC511 VA: 0x3EAC410
	|-List<int>.Clear
	|
	|-RVA: 0x3EB2010 Offset: 0x3EB2111 VA: 0x3EB2010
	|-List<long>.Clear
	|
	|-RVA: 0x3DFF3E0 Offset: 0x3DFF4E1 VA: 0x3DFF3E0
	|-List<IntPtr>.Clear
	|
	|-RVA: 0x3E02250 Offset: 0x3E02351 VA: 0x3E02250
	|-List<InterpretedFrameInfo>.Clear
	|
	|-RVA: 0x3E05240 Offset: 0x3E05341 VA: 0x3E05240
	|-List<IntervalTreeNode>.Clear
	|
	|-RVA: 0x3E082E0 Offset: 0x3E083E1 VA: 0x3E082E0
	|-List<LengthLimitProperties>.Clear
	|
	|-RVA: 0x3E0B0F0 Offset: 0x3E0B1F1 VA: 0x3E0B0F0
	|-List<MapPos>.Clear
	|
	|-RVA: 0x3E0E130 Offset: 0x3E0E231 VA: 0x3E0E130
	|-List<Matrix4x4>.Clear
	|
	|-RVA: 0x3E14430 Offset: 0x3E14531 VA: 0x3E14430
	|-List<ObjectInitializationData>.Clear
	|
	|-RVA: 0x3E177D0 Offset: 0x3E178D1 VA: 0x3E177D0
	|-List<PlayableBinding>.Clear
	|
	|-RVA: 0x3E1AA80 Offset: 0x3E1AB81 VA: 0x3E1AA80
	|-List<PlayerLoopSystem>.Clear
	|
	|-RVA: 0x3DA4F20 Offset: 0x3DA5021 VA: 0x3DA4F20
	|-List<PlayerLoopSystemInternal>.Clear
	|
	|-RVA: 0x3DA8180 Offset: 0x3DA8281 VA: 0x3DA8180
	|-List<RangePositionInfo>.Clear
	|
	|-RVA: 0x3DAB030 Offset: 0x3DAB131 VA: 0x3DAB030
	|-List<Ranking2ChartInfoInput>.Clear
	|
	|-RVA: 0x3DAE030 Offset: 0x3DAE131 VA: 0x3DAE030
	|-List<RaycastHit2D>.Clear
	|
	|-RVA: 0x3DB1570 Offset: 0x3DB1671 VA: 0x3DB1570
	|-List<RaycastResult>.Clear
	|
	|-RVA: 0x3DB4B40 Offset: 0x3DB4C41 VA: 0x3DB4B40
	|-List<Rect>.Clear
	|
	|-RVA: 0x3DB7A70 Offset: 0x3DB7B71 VA: 0x3DB7A70
	|-List<RendererListHandle>.Clear
	|
	|-RVA: 0x3DBA880 Offset: 0x3DBA981 VA: 0x3DBA880
	|-List<ResourceHandle>.Clear
	|
	|-RVA: 0x3DBD690 Offset: 0x3DBD791 VA: 0x3DBD690
	|-List<sbyte>.Clear
	|
	|-RVA: 0x3DC04A0 Offset: 0x3DC05A1 VA: 0x3DC04A0
	|-List<ShaderTagId>.Clear
	|
	|-RVA: 0x3E3C120 Offset: 0x3E3C221 VA: 0x3E3C120
	|-List<float>.Clear
	|
	|-RVA: 0x3E3F3A0 Offset: 0x3E3F4A1 VA: 0x3E3F3A0
	|-List<SphericalHarmonicsL2>.Clear
	|
	|-RVA: 0x3E42DD0 Offset: 0x3E42ED1 VA: 0x3E42DD0
	|-List<SubMeshDescriptor>.Clear
	|
	|-RVA: 0x3E46060 Offset: 0x3E46161 VA: 0x3E46060
	|-List<TablePair>.Clear
	|
	|-RVA: 0x3E48F10 Offset: 0x3E49011 VA: 0x3E48F10
	|-List<TimeSpan>.Clear
	|
	|-RVA: 0x3E4BDC0 Offset: 0x3E4BEC1 VA: 0x3E4BDC0
	|-List<UICharInfo>.Clear
	|
	|-RVA: 0x3E4ED50 Offset: 0x3E4EE51 VA: 0x3E4ED50
	|-List<UILineInfo>.Clear
	|
	|-RVA: 0x3E52060 Offset: 0x3E52161 VA: 0x3E52060
	|-List<UIVertex>.Clear
	|
	|-RVA: 0x3E558C0 Offset: 0x3E559C1 VA: 0x3E558C0
	|-List<ushort>.Clear
	|
	|-RVA: 0x3E586C0 Offset: 0x3E587C1 VA: 0x3E586C0
	|-List<uint>.Clear
	|
	|-RVA: 0x3DC32B0 Offset: 0x3DC33B1 VA: 0x3DC32B0
	|-List<ulong>.Clear
	|
	|-RVA: 0x3DC60F0 Offset: 0x3DC61F1 VA: 0x3DC60F0
	|-List<Vector2>.Clear
	|
	|-RVA: 0x3DC9020 Offset: 0x3DC9121 VA: 0x3DC9020
	|-List<Vector3>.Clear
	|
	|-RVA: 0x3DCC030 Offset: 0x3DCC131 VA: 0x3DCC030
	|-List<Vector4>.Clear
	|
	|-RVA: 0x3DCEFB0 Offset: 0x3DCF0B1 VA: 0x3DCEFB0
	|-List<VertexAttributeDescriptor>.Clear
	|
	|-RVA: 0x3DD1EB0 Offset: 0x3DD1FB1 VA: 0x3DD1EB0
	|-List<X509ChainStatus>.Clear
	|
	|-RVA: 0x3DD4F20 Offset: 0x3DD5021 VA: 0x3DD4F20
	|-List<XRView>.Clear
	|
	|-RVA: 0x3DD81C0 Offset: 0x3DD82C1 VA: 0x3DD81C0
	|-List<AmiiboSequence.GainItemData>.Clear
	|
	|-RVA: 0x3DDB240 Offset: 0x3DDB341 VA: 0x3DDB240
	|-List<AnimationOutputWeightProcessor.WeightInfo>.Clear
	|
	|-RVA: 0x3DDE480 Offset: 0x3DDE581 VA: 0x3DDE480
	|-List<ArenaOrderSequence.GodInfo>.Clear
	|
	|-RVA: 0x3E1DCE0 Offset: 0x3E1DDE1 VA: 0x3E1DCE0
	|-List<BattleInfo.SupportData>.Clear
	|
	|-RVA: 0x3E20C00 Offset: 0x3E20D01 VA: 0x3E20C00
	|-List<BeforeRenderHelper.OrderBlock>.Clear
	|
	|-RVA: 0x3E23C10 Offset: 0x3E23D11 VA: 0x3E23C10
	|-List<Camera.RenderRequest>.Clear
	|
	|-RVA: 0x3E26D50 Offset: 0x3E26E51 VA: 0x3E26D50
	|-List<CameraState.CustomBlendable>.Clear
	|
	|-RVA: 0x3E29C00 Offset: 0x3E29D01 VA: 0x3E29C00
	|-List<CinemachineClearShot.Pair>.Clear
	|
	|-RVA: 0x3E2CA10 Offset: 0x3E2CB11 VA: 0x3E2CA10
	|-List<CinemachineStateDrivenCamera.HashPair>.Clear
	|
	|-RVA: 0x3E2F970 Offset: 0x3E2FA71 VA: 0x3E2F970
	|-List<DelayedActionManager.DelegateInfo>.Clear
	|
	|-RVA: 0x3E32C10 Offset: 0x3E32D11 VA: 0x3E32C10
	|-List<Detail.AsyncResultInt>.Clear
	|
	|-RVA: 0x3E35E80 Offset: 0x3E35F81 VA: 0x3E35E80
	|-List<Detail.CppArray>.Clear
	|
	|-RVA: 0x3E38EE0 Offset: 0x3E38FE1 VA: 0x3E38EE0
	|-List<Detail.NotificationEventInt>.Clear
	|
	|-RVA: 0x3E5B530 Offset: 0x3E5B631 VA: 0x3E5B530
	|-List<DragonRideTargetGroup.ChainParam>.Clear
	|
	|-RVA: 0x3E5E530 Offset: 0x3E5E631 VA: 0x3E5E530
	|-List<GmapPathAdjuster.TargetModel>.Clear
	|
	|-RVA: 0x3E61740 Offset: 0x3E61841 VA: 0x3E61740
	|-List<GmapSpotAdjuster.TargetModel>.Clear
	|
	|-RVA: 0x3E64950 Offset: 0x3E64A51 VA: 0x3E64950
	|-List<HubFastTravel.Location>.Clear
	|
	|-RVA: 0x3E67C00 Offset: 0x3E67D01 VA: 0x3E67C00
	|-List<HubLensFlare.Flare>.Clear
	|
	|-RVA: 0x3E6AEC0 Offset: 0x3E6AFC1 VA: 0x3E6AEC0
	|-List<InventoryPoolItemMenuContent.KindBgNameClass>.Clear
	|
	|-RVA: 0x3E6DD70 Offset: 0x3E6DE71 VA: 0x3E6DD70
	|-List<Map.Pos>.Clear
	|
	|-RVA: 0x3E70BD0 Offset: 0x3E70CD1 VA: 0x3E70BD0
	|-List<MapImage.BackupTerrain>.Clear
	|
	|-RVA: 0x3E73A70 Offset: 0x3E73B71 VA: 0x3E73A70
	|-List<MapImageRange.Pos>.Clear
	|
	|-RVA: 0x3E76A50 Offset: 0x3E76B51 VA: 0x3E76A50
	|-List<MapMind.Target>.Clear
	|
	|-RVA: 0x3D86640 Offset: 0x3D86741 VA: 0x3D86640
	|-List<MapPanelDebug.Entity>.Clear
	|
	|-RVA: 0x3D896E0 Offset: 0x3D897E1 VA: 0x3D896E0
	|-List<NexRanking.Data>.Clear
	|
	|-RVA: 0x3D8C540 Offset: 0x3D8C641 VA: 0x3D8C540
	|-List<NexVersus.RatingData>.Clear
	|
	|-RVA: 0x3D8F440 Offset: 0x3D8F541 VA: 0x3D8F440
	|-List<PackedPlayModeBuildLogs.RuntimeBuildLog>.Clear
	|
	|-RVA: 0x3D924A0 Offset: 0x3D925A1 VA: 0x3D924A0
	|-List<ParticleSystem.Particle>.Clear
	|
	|-RVA: 0x3D956A0 Offset: 0x3D957A1 VA: 0x3D956A0
	|-List<RangeData.Offset>.Clear
	|
	|-RVA: 0x3D98600 Offset: 0x3D98701 VA: 0x3D98600
	|-List<RenderGraphDebugData.PassDebugData>.Clear
	|
	|-RVA: 0x3D9B8B0 Offset: 0x3D9B9B1 VA: 0x3D9B8B0
	|-List<RenderGraphDebugData.ResourceDebugData>.Clear
	|
	|-RVA: 0x3D9EB10 Offset: 0x3D9EC11 VA: 0x3D9EB10
	|-List<RingCleaningUnitSelectMenu.GodParam>.Clear
	|
	|-RVA: 0x3DA1B90 Offset: 0x3DA1C91 VA: 0x3DA1B90
	|-List<ShadowUtility.Edge>.Clear
	|
	|-RVA: 0x3D14210 Offset: 0x3D14311 VA: 0x3D14210
	|-List<SkillArray.Entity>.Clear
	|
	|-RVA: 0x3D17260 Offset: 0x3D17361 VA: 0x3D17260
	|-List<TexturePacker_JsonArray.Frame>.Clear
	|
	|-RVA: 0x3D1A740 Offset: 0x3D1A841 VA: 0x3D1A740
	|-List<TimeNotificationBehaviour.NotificationEntry>.Clear
	|
	|-RVA: 0x3D1D960 Offset: 0x3D1DA61 VA: 0x3D1D960
	|-List<UnitySynchronizationContext.WorkRequest>.Clear
	|
	|-RVA: 0x3D20A90 Offset: 0x3D20B91 VA: 0x3D20A90
	|-List<XmlSchemaObjectTable.XmlSchemaObjectEntry>.Clear
	|
	|-RVA: 0x3D239B0 Offset: 0x3D23AB1 VA: 0x3D239B0
	|-List<AssetBundleBuildMap.AssetBundleEntry.AssetPathString>.Clear
	|
	|-RVA: 0x3D26A30 Offset: 0x3D26B31 VA: 0x3D26A30
	|-List<Detail.DataStore.DataStoreChangeMetaParamInt>.Clear
	|
	|-RVA: 0x3D29CD0 Offset: 0x3D29DD1 VA: 0x3D29CD0
	|-List<Detail.DataStore.DataStoreDeleteParamInt>.Clear
	|
	|-RVA: 0x3D2CD30 Offset: 0x3D2CE31 VA: 0x3D2CD30
	|-List<Detail.DataStore.DataStoreGetMetaParamInt>.Clear
	|
	|-RVA: 0x3D300B0 Offset: 0x3D301B1 VA: 0x3D300B0
	|-List<Detail.DataStore.DataStoreMetaInfoInt>.Clear
	|
	|-RVA: 0x3CF4880 Offset: 0x3CF4981 VA: 0x3CF4880
	|-List<Detail.DataStore.DataStorePasswordInfoInt>.Clear
	|
	|-RVA: 0x3CF7A60 Offset: 0x3CF7B61 VA: 0x3CF7A60
	|-List<Detail.DataStore.DataStorePersistenceInfoInt>.Clear
	|
	|-RVA: 0x3CFACB0 Offset: 0x3CFADB1 VA: 0x3CFACB0
	|-List<Detail.DataStore.DataStorePreparePostParamInt>.Clear
	|
	|-RVA: 0x3CFDF00 Offset: 0x3CFE001 VA: 0x3CFDF00
	|-List<Detail.DataStore.DataStoreRateObjectParamInt>.Clear
	|
	|-RVA: 0x3D00ED0 Offset: 0x3D00FD1 VA: 0x3D00ED0
	|-List<Detail.DataStore.DataStoreRatingInitParamInt>.Clear
	|
	|-RVA: 0x3D03FD0 Offset: 0x3D040D1 VA: 0x3D03FD0
	|-List<Detail.DataStore.DataStoreRatingTargetInt>.Clear
	|
	|-RVA: 0x3D070A0 Offset: 0x3D071A1 VA: 0x3D070A0
	|-List<Detail.Ranking.RankingCachedResultInt>.Clear
	|
	|-RVA: 0x3D0A490 Offset: 0x3D0A591 VA: 0x3D0A490
	|-List<Detail.Ranking.RankingOrderParamInt>.Clear
	|
	|-RVA: 0x3D0D550 Offset: 0x3D0D651 VA: 0x3D0D550
	|-List<Detail.Ranking.RankingRankDataInt>.Clear
	|
	|-RVA: 0x3D10C10 Offset: 0x3D10D11 VA: 0x3D10C10
	|-List<Detail.Ranking2.Ranking2ChartInfoInt>.Clear
	|
	|-RVA: 0x3D674D0 Offset: 0x3D675D1 VA: 0x3D674D0
	|-List<Detail.Ranking2.Ranking2RankDataInt>.Clear
	|
	|-RVA: 0x3D6A870 Offset: 0x3D6A971 VA: 0x3D6A870
	|-List<Detail.Ranking2.Ranking2ScoreDataInt>.Clear
	|
	|-RVA: 0x3D6D840 Offset: 0x3D6D941 VA: 0x3D6D840
	|-List<Detail.Screening.ScreeningContextInfoInt>.Clear
	|
	|-RVA: 0x3D70BF0 Offset: 0x3D70CF1 VA: 0x3D70BF0
	|-List<Detail.Subscriber.SubscriberContentInt>.Clear
	|
	|-RVA: 0x3D74200 Offset: 0x3D74301 VA: 0x3D74200
	|-List<Detail.Subscriber.SubscriberGetContentParamInt>.Clear
	|
	|-RVA: 0x3D77470 Offset: 0x3D77571 VA: 0x3D77470
	|-List<Detail.Subscriber.SubscriberUserStatusInfoInt>.Clear
	|
	|-RVA: 0x3D7A780 Offset: 0x3D7A881 VA: 0x3D7A780
	|-List<Detail.Subscriber.SubscriberUserStatusParamInt>.Clear
	|
	|-RVA: 0x3D7D820 Offset: 0x3D7D921 VA: 0x3D7D820
	|-List<Detail.Utility.IntegerSettings>.Clear
	|
	|-RVA: 0x3D80680 Offset: 0x3D80781 VA: 0x3D80680
	|-List<Detail.Utility.UniqueIdInfoInt>.Clear
	|
	|-RVA: 0x3D83570 Offset: 0x3D83671 VA: 0x3D83570
	|-List<MapHistory.Rewind.LatestInspectorData>.Clear
	|
	|-RVA: 0x305F830 Offset: 0x305F931 VA: 0x305F830
	|-List<MapHistory.Rewind.WorkTerrainData>.Clear
	|
	|-RVA: 0x3062830 Offset: 0x3062931 VA: 0x3062830
	|-List<MapSkill.AroundCalculator.Result>.Clear
	|
	|-RVA: 0x30658B0 Offset: 0x30659B1 VA: 0x30658B0
	|-List<TargetPositionCache.CacheCurve.Item>.Clear
	|
	|-RVA: 0x3068C50 Offset: 0x3068D51 VA: 0x3068C50
	|-List<TargetPositionCache.CacheEntry.RecordingItem>.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public bool Contains(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3B0B580 Offset: 0x3B0B681 VA: 0x3B0B580
	|-List<IntervalTree.Entry<object>>.Contains
	|
	|-RVA: 0x3B0E6B0 Offset: 0x3B0E7B1 VA: 0x3B0E6B0
	|-List<KeyValuePair<DateTime, object>>.Contains
	|
	|-RVA: 0x3B115D0 Offset: 0x3B116D1 VA: 0x3B115D0
	|-List<KeyValuePair<int, object>>.Contains
	|
	|-RVA: 0x3B145D0 Offset: 0x3B146D1 VA: 0x3B145D0
	|-List<KeyValuePair<object, ValueTuple<int, DateTime, object>>>.Contains
	|
	|-RVA: 0x3B17710 Offset: 0x3B17811 VA: 0x3B17710
	|-List<KeyValuePair<object, object>>.Contains
	|
	|-RVA: 0x3B1A710 Offset: 0x3B1A811 VA: 0x3B1A710
	|-List<CommonBattleSequence.Reliance<object>>.Contains
	|
	|-RVA: 0x3B1D840 Offset: 0x3B1D941 VA: 0x3B1D840
	|-List<RenderGraphResourcePool.ResourceLogInfo<object>>.Contains
	|
	|-RVA: 0x3B20760 Offset: 0x3B20861 VA: 0x3B20760
	|-List<ValueTuple<int, object>>.Contains
	|
	|-RVA: 0x3DE1380 Offset: 0x3DE1481 VA: 0x3DE1380
	|-List<ValueTuple<Int32Enum, int>>.Contains
	|
	|-RVA: 0x3DE42E0 Offset: 0x3DE43E1 VA: 0x3DE42E0
	|-List<ValueTuple<object, ValueTuple<object, int>>>.Contains
	|
	|-RVA: 0x3DE7410 Offset: 0x3DE7511 VA: 0x3DE7410
	|-List<ValueTuple<object, int>>.Contains
	|
	|-RVA: 0x3DEA390 Offset: 0x3DEA491 VA: 0x3DEA390
	|-List<ValueTuple<Vector3, float>>.Contains
	|
	|-RVA: 0x3DED330 Offset: 0x3DED431 VA: 0x3DED330
	|-List<ValueTuple<object, Int32Enum, int>>.Contains
	|
	|-RVA: 0x3DF0330 Offset: 0x3DF0431 VA: 0x3DF0330
	|-List<ValueTuple<object, int, int, int>>.Contains
	|
	|-RVA: 0x3E11430 Offset: 0x3E11531 VA: 0x3E11430
	|-List<AkAmbient>.Contains
	|-List<AkAmbientLargeModePositioner>.Contains
	|-List<AkAudioListener>.Contains
	|-List<AkRoom>.Contains
	|-List<AkRoomAwareObject>.Contains
	|-List<AkRoomPortal>.Contains
	|-List<AkSpatialAudioListener>.Contains
	|-List<AkSurfaceReflector>.Contains
	|-List<BaseRaycaster>.Contains
	|-List<Camera>.Contains
	|-List<CinemachineVirtualCameraBase>.Contains
	|-List<Collider>.Contains
	|-List<Decorator>.Contains
	|-List<DynValue>.Contains
	|-List<FoodstuffData>.Contains
	|-List<GameObject>.Contains
	|-List<GmapSpot>.Contains
	|-List<GodUnit>.Contains
	|-List<HubManualCulling>.Contains
	|-List<IDisposable>.Contains
	|-List<InteractionTrigger>.Contains
	|-List<ItemData>.Contains
	|-List<MapBackup>.Contains
	|-List<NotificationEventCB>.Contains
	|-List<object>.Contains
	|-List<Phase>.Contains
	|-List<PhotographPauseData>.Contains
	|-List<ProfileCard>.Contains
	|-List<ScriptableObject>.Contains
	|-List<SignalAsset>.Contains
	|-List<SkillData>.Contains
	|-List<string>.Contains
	|-List<TimelineClip>.Contains
	|-List<Toggle>.Contains
	|-List<Unit>.Contains
	|-List<Volume>.Contains
	|-List<AssetTable.Accessory>.Contains
	|-List<GameSaveDataHeaderReader.Handle>.Contains
	|-List<MapDispos.ActualData>.Contains
	|-List<MapDispos.Pos>.Contains
	|-List<MapLayer.Data>.Contains
	|-List<MapObject.RigidInfo>.Contains
	|-List<RingListSequence.PageData>.Contains
	|
	|-RVA: 0x3DF33F0 Offset: 0x3DF34F1 VA: 0x3DF33F0
	|-List<AnimatorClipInfo>.Contains
	|
	|-RVA: 0x3DF6350 Offset: 0x3DF6451 VA: 0x3DF6350
	|-List<AsyncOperationHandle>.Contains
	|
	|-RVA: 0x3DF9550 Offset: 0x3DF9651 VA: 0x3DF9550
	|-List<BoneWeight>.Contains
	|
	|-RVA: 0x3DFC610 Offset: 0x3DFC711 VA: 0x3DFC610
	|-List<bool>.Contains
	|
	|-RVA: 0x3E79B60 Offset: 0x3E79C61 VA: 0x3E79B60
	|-List<byte>.Contains
	|
	|-RVA: 0x3E7C9E0 Offset: 0x3E7CAE1 VA: 0x3E7C9E0
	|-List<CameraInfo>.Contains
	|
	|-RVA: 0x3EAF260 Offset: 0x3EAF361 VA: 0x3EAF260
	|-List<CameraPosition>.Contains
	|-List<Int32Enum>.Contains
	|-List<ParticleSystemVertexStream>.Contains
	|-List<MapPanelActive.MeshIndex>.Contains
	|-List<MapPanelDanger.MeshIndex>.Contains
	|-List<MapPanelDeploy.MeshIndex>.Contains
	|
	|-RVA: 0x3E7F890 Offset: 0x3E7F991 VA: 0x3E7F890
	|-List<char>.Contains
	|
	|-RVA: 0x3E82760 Offset: 0x3E82861 VA: 0x3E82760
	|-List<Color>.Contains
	|
	|-RVA: 0x3E85690 Offset: 0x3E85791 VA: 0x3E85690
	|-List<Color32>.Contains
	|
	|-RVA: 0x3E88510 Offset: 0x3E88611 VA: 0x3E88510
	|-List<ConstraintSource>.Contains
	|
	|-RVA: 0x3E8B510 Offset: 0x3E8B611 VA: 0x3E8B510
	|-List<ContourVertex>.Contains
	|
	|-RVA: 0x3E8E710 Offset: 0x3E8E811 VA: 0x3E8E710
	|-List<DataStoreRatingInfo>.Contains
	|
	|-RVA: 0x3E917B0 Offset: 0x3E918B1 VA: 0x3E917B0
	|-List<DataStoreResult>.Contains
	|
	|-RVA: 0x3E945C0 Offset: 0x3E946C1 VA: 0x3E945C0
	|-List<DateTime>.Contains
	|
	|-RVA: 0x3E97420 Offset: 0x3E97521 VA: 0x3E97420
	|-List<DateTimeOffset>.Contains
	|
	|-RVA: 0x3E9A300 Offset: 0x3E9A401 VA: 0x3E9A300
	|-List<Decimal>.Contains
	|
	|-RVA: 0x3E9D380 Offset: 0x3E9D481 VA: 0x3E9D380
	|-List<DiagnosticEvent>.Contains
	|
	|-RVA: 0x3EA05F0 Offset: 0x3EA06F1 VA: 0x3EA05F0
	|-List<double>.Contains
	|
	|-RVA: 0x3EA3590 Offset: 0x3EA3691 VA: 0x3EA3590
	|-List<Friend>.Contains
	|
	|-RVA: 0x3EA67D0 Offset: 0x3EA68D1 VA: 0x3EA67D0
	|-List<GlyphRect>.Contains
	|
	|-RVA: 0x3EA9660 Offset: 0x3EA9761 VA: 0x3EA9660
	|-List<short>.Contains
	|
	|-RVA: 0x3EAC460 Offset: 0x3EAC561 VA: 0x3EAC460
	|-List<int>.Contains
	|
	|-RVA: 0x3EB2060 Offset: 0x3EB2161 VA: 0x3EB2060
	|-List<long>.Contains
	|
	|-RVA: 0x3DFF430 Offset: 0x3DFF531 VA: 0x3DFF430
	|-List<IntPtr>.Contains
	|
	|-RVA: 0x3E022A0 Offset: 0x3E023A1 VA: 0x3E022A0
	|-List<InterpretedFrameInfo>.Contains
	|
	|-RVA: 0x3E05290 Offset: 0x3E05391 VA: 0x3E05290
	|-List<IntervalTreeNode>.Contains
	|
	|-RVA: 0x3E08330 Offset: 0x3E08431 VA: 0x3E08330
	|-List<LengthLimitProperties>.Contains
	|
	|-RVA: 0x3E0B140 Offset: 0x3E0B241 VA: 0x3E0B140
	|-List<MapPos>.Contains
	|
	|-RVA: 0x3E0E180 Offset: 0x3E0E281 VA: 0x3E0E180
	|-List<Matrix4x4>.Contains
	|
	|-RVA: 0x3E14480 Offset: 0x3E14581 VA: 0x3E14480
	|-List<ObjectInitializationData>.Contains
	|
	|-RVA: 0x3E17820 Offset: 0x3E17921 VA: 0x3E17820
	|-List<PlayableBinding>.Contains
	|
	|-RVA: 0x3E1AAD0 Offset: 0x3E1ABD1 VA: 0x3E1AAD0
	|-List<PlayerLoopSystem>.Contains
	|
	|-RVA: 0x3DA4F70 Offset: 0x3DA5071 VA: 0x3DA4F70
	|-List<PlayerLoopSystemInternal>.Contains
	|
	|-RVA: 0x3DA81D0 Offset: 0x3DA82D1 VA: 0x3DA81D0
	|-List<RangePositionInfo>.Contains
	|
	|-RVA: 0x3DAB080 Offset: 0x3DAB181 VA: 0x3DAB080
	|-List<Ranking2ChartInfoInput>.Contains
	|
	|-RVA: 0x3DAE080 Offset: 0x3DAE181 VA: 0x3DAE080
	|-List<RaycastHit2D>.Contains
	|
	|-RVA: 0x3DB15C0 Offset: 0x3DB16C1 VA: 0x3DB15C0
	|-List<RaycastResult>.Contains
	|
	|-RVA: 0x3DB4B90 Offset: 0x3DB4C91 VA: 0x3DB4B90
	|-List<Rect>.Contains
	|
	|-RVA: 0x3DB7AC0 Offset: 0x3DB7BC1 VA: 0x3DB7AC0
	|-List<RendererListHandle>.Contains
	|
	|-RVA: 0x3DBA8D0 Offset: 0x3DBA9D1 VA: 0x3DBA8D0
	|-List<ResourceHandle>.Contains
	|
	|-RVA: 0x3DBD6E0 Offset: 0x3DBD7E1 VA: 0x3DBD6E0
	|-List<sbyte>.Contains
	|
	|-RVA: 0x3DC04F0 Offset: 0x3DC05F1 VA: 0x3DC04F0
	|-List<ShaderTagId>.Contains
	|
	|-RVA: 0x3E3C170 Offset: 0x3E3C271 VA: 0x3E3C170
	|-List<float>.Contains
	|
	|-RVA: 0x3E3F3F0 Offset: 0x3E3F4F1 VA: 0x3E3F3F0
	|-List<SphericalHarmonicsL2>.Contains
	|
	|-RVA: 0x3E42E20 Offset: 0x3E42F21 VA: 0x3E42E20
	|-List<SubMeshDescriptor>.Contains
	|
	|-RVA: 0x3E460B0 Offset: 0x3E461B1 VA: 0x3E460B0
	|-List<TablePair>.Contains
	|
	|-RVA: 0x3E48F60 Offset: 0x3E49061 VA: 0x3E48F60
	|-List<TimeSpan>.Contains
	|
	|-RVA: 0x3E4BE10 Offset: 0x3E4BF11 VA: 0x3E4BE10
	|-List<UICharInfo>.Contains
	|
	|-RVA: 0x3E4EDA0 Offset: 0x3E4EEA1 VA: 0x3E4EDA0
	|-List<UILineInfo>.Contains
	|
	|-RVA: 0x3E520B0 Offset: 0x3E521B1 VA: 0x3E520B0
	|-List<UIVertex>.Contains
	|
	|-RVA: 0x3E55910 Offset: 0x3E55A11 VA: 0x3E55910
	|-List<ushort>.Contains
	|
	|-RVA: 0x3E58710 Offset: 0x3E58811 VA: 0x3E58710
	|-List<uint>.Contains
	|
	|-RVA: 0x3DC3300 Offset: 0x3DC3401 VA: 0x3DC3300
	|-List<ulong>.Contains
	|
	|-RVA: 0x3DC6140 Offset: 0x3DC6241 VA: 0x3DC6140
	|-List<Vector2>.Contains
	|
	|-RVA: 0x3DC9070 Offset: 0x3DC9171 VA: 0x3DC9070
	|-List<Vector3>.Contains
	|
	|-RVA: 0x3DCC080 Offset: 0x3DCC181 VA: 0x3DCC080
	|-List<Vector4>.Contains
	|
	|-RVA: 0x3DCF000 Offset: 0x3DCF101 VA: 0x3DCF000
	|-List<VertexAttributeDescriptor>.Contains
	|
	|-RVA: 0x3DD1F00 Offset: 0x3DD2001 VA: 0x3DD1F00
	|-List<X509ChainStatus>.Contains
	|
	|-RVA: 0x3DD4F70 Offset: 0x3DD5071 VA: 0x3DD4F70
	|-List<XRView>.Contains
	|
	|-RVA: 0x3DD8210 Offset: 0x3DD8311 VA: 0x3DD8210
	|-List<AmiiboSequence.GainItemData>.Contains
	|
	|-RVA: 0x3DDB290 Offset: 0x3DDB391 VA: 0x3DDB290
	|-List<AnimationOutputWeightProcessor.WeightInfo>.Contains
	|
	|-RVA: 0x3DDE4D0 Offset: 0x3DDE5D1 VA: 0x3DDE4D0
	|-List<ArenaOrderSequence.GodInfo>.Contains
	|
	|-RVA: 0x3E1DD30 Offset: 0x3E1DE31 VA: 0x3E1DD30
	|-List<BattleInfo.SupportData>.Contains
	|
	|-RVA: 0x3E20C50 Offset: 0x3E20D51 VA: 0x3E20C50
	|-List<BeforeRenderHelper.OrderBlock>.Contains
	|
	|-RVA: 0x3E23C60 Offset: 0x3E23D61 VA: 0x3E23C60
	|-List<Camera.RenderRequest>.Contains
	|
	|-RVA: 0x3E26DA0 Offset: 0x3E26EA1 VA: 0x3E26DA0
	|-List<CameraState.CustomBlendable>.Contains
	|
	|-RVA: 0x3E29C50 Offset: 0x3E29D51 VA: 0x3E29C50
	|-List<CinemachineClearShot.Pair>.Contains
	|
	|-RVA: 0x3E2CA60 Offset: 0x3E2CB61 VA: 0x3E2CA60
	|-List<CinemachineStateDrivenCamera.HashPair>.Contains
	|
	|-RVA: 0x3E2F9C0 Offset: 0x3E2FAC1 VA: 0x3E2F9C0
	|-List<DelayedActionManager.DelegateInfo>.Contains
	|
	|-RVA: 0x3E32C60 Offset: 0x3E32D61 VA: 0x3E32C60
	|-List<Detail.AsyncResultInt>.Contains
	|
	|-RVA: 0x3E35ED0 Offset: 0x3E35FD1 VA: 0x3E35ED0
	|-List<Detail.CppArray>.Contains
	|
	|-RVA: 0x3E38F30 Offset: 0x3E39031 VA: 0x3E38F30
	|-List<Detail.NotificationEventInt>.Contains
	|
	|-RVA: 0x3E5B580 Offset: 0x3E5B681 VA: 0x3E5B580
	|-List<DragonRideTargetGroup.ChainParam>.Contains
	|
	|-RVA: 0x3E5E580 Offset: 0x3E5E681 VA: 0x3E5E580
	|-List<GmapPathAdjuster.TargetModel>.Contains
	|
	|-RVA: 0x3E61790 Offset: 0x3E61891 VA: 0x3E61790
	|-List<GmapSpotAdjuster.TargetModel>.Contains
	|
	|-RVA: 0x3E649A0 Offset: 0x3E64AA1 VA: 0x3E649A0
	|-List<HubFastTravel.Location>.Contains
	|
	|-RVA: 0x3E67C50 Offset: 0x3E67D51 VA: 0x3E67C50
	|-List<HubLensFlare.Flare>.Contains
	|
	|-RVA: 0x3E6AF10 Offset: 0x3E6B011 VA: 0x3E6AF10
	|-List<InventoryPoolItemMenuContent.KindBgNameClass>.Contains
	|
	|-RVA: 0x3E6DDC0 Offset: 0x3E6DEC1 VA: 0x3E6DDC0
	|-List<Map.Pos>.Contains
	|
	|-RVA: 0x3E70C20 Offset: 0x3E70D21 VA: 0x3E70C20
	|-List<MapImage.BackupTerrain>.Contains
	|
	|-RVA: 0x3E73AC0 Offset: 0x3E73BC1 VA: 0x3E73AC0
	|-List<MapImageRange.Pos>.Contains
	|
	|-RVA: 0x3E76AA0 Offset: 0x3E76BA1 VA: 0x3E76AA0
	|-List<MapMind.Target>.Contains
	|
	|-RVA: 0x3D86690 Offset: 0x3D86791 VA: 0x3D86690
	|-List<MapPanelDebug.Entity>.Contains
	|
	|-RVA: 0x3D89730 Offset: 0x3D89831 VA: 0x3D89730
	|-List<NexRanking.Data>.Contains
	|
	|-RVA: 0x3D8C590 Offset: 0x3D8C691 VA: 0x3D8C590
	|-List<NexVersus.RatingData>.Contains
	|
	|-RVA: 0x3D8F490 Offset: 0x3D8F591 VA: 0x3D8F490
	|-List<PackedPlayModeBuildLogs.RuntimeBuildLog>.Contains
	|
	|-RVA: 0x3D924F0 Offset: 0x3D925F1 VA: 0x3D924F0
	|-List<ParticleSystem.Particle>.Contains
	|
	|-RVA: 0x3D956F0 Offset: 0x3D957F1 VA: 0x3D956F0
	|-List<RangeData.Offset>.Contains
	|
	|-RVA: 0x3D98650 Offset: 0x3D98751 VA: 0x3D98650
	|-List<RenderGraphDebugData.PassDebugData>.Contains
	|
	|-RVA: 0x3D9B900 Offset: 0x3D9BA01 VA: 0x3D9B900
	|-List<RenderGraphDebugData.ResourceDebugData>.Contains
	|
	|-RVA: 0x3D9EB60 Offset: 0x3D9EC61 VA: 0x3D9EB60
	|-List<RingCleaningUnitSelectMenu.GodParam>.Contains
	|
	|-RVA: 0x3DA1BE0 Offset: 0x3DA1CE1 VA: 0x3DA1BE0
	|-List<ShadowUtility.Edge>.Contains
	|
	|-RVA: 0x3D14260 Offset: 0x3D14361 VA: 0x3D14260
	|-List<SkillArray.Entity>.Contains
	|
	|-RVA: 0x3D172B0 Offset: 0x3D173B1 VA: 0x3D172B0
	|-List<TexturePacker_JsonArray.Frame>.Contains
	|
	|-RVA: 0x3D1A790 Offset: 0x3D1A891 VA: 0x3D1A790
	|-List<TimeNotificationBehaviour.NotificationEntry>.Contains
	|
	|-RVA: 0x3D1D9B0 Offset: 0x3D1DAB1 VA: 0x3D1D9B0
	|-List<UnitySynchronizationContext.WorkRequest>.Contains
	|
	|-RVA: 0x3D20AE0 Offset: 0x3D20BE1 VA: 0x3D20AE0
	|-List<XmlSchemaObjectTable.XmlSchemaObjectEntry>.Contains
	|
	|-RVA: 0x3D23A00 Offset: 0x3D23B01 VA: 0x3D23A00
	|-List<AssetBundleBuildMap.AssetBundleEntry.AssetPathString>.Contains
	|
	|-RVA: 0x3D26A80 Offset: 0x3D26B81 VA: 0x3D26A80
	|-List<Detail.DataStore.DataStoreChangeMetaParamInt>.Contains
	|
	|-RVA: 0x3D29D20 Offset: 0x3D29E21 VA: 0x3D29D20
	|-List<Detail.DataStore.DataStoreDeleteParamInt>.Contains
	|
	|-RVA: 0x3D2CD80 Offset: 0x3D2CE81 VA: 0x3D2CD80
	|-List<Detail.DataStore.DataStoreGetMetaParamInt>.Contains
	|
	|-RVA: 0x3D30100 Offset: 0x3D30201 VA: 0x3D30100
	|-List<Detail.DataStore.DataStoreMetaInfoInt>.Contains
	|
	|-RVA: 0x3CF48D0 Offset: 0x3CF49D1 VA: 0x3CF48D0
	|-List<Detail.DataStore.DataStorePasswordInfoInt>.Contains
	|
	|-RVA: 0x3CF7AB0 Offset: 0x3CF7BB1 VA: 0x3CF7AB0
	|-List<Detail.DataStore.DataStorePersistenceInfoInt>.Contains
	|
	|-RVA: 0x3CFAD00 Offset: 0x3CFAE01 VA: 0x3CFAD00
	|-List<Detail.DataStore.DataStorePreparePostParamInt>.Contains
	|
	|-RVA: 0x3CFDF50 Offset: 0x3CFE051 VA: 0x3CFDF50
	|-List<Detail.DataStore.DataStoreRateObjectParamInt>.Contains
	|
	|-RVA: 0x3D00F20 Offset: 0x3D01021 VA: 0x3D00F20
	|-List<Detail.DataStore.DataStoreRatingInitParamInt>.Contains
	|
	|-RVA: 0x3D04020 Offset: 0x3D04121 VA: 0x3D04020
	|-List<Detail.DataStore.DataStoreRatingTargetInt>.Contains
	|
	|-RVA: 0x3D070F0 Offset: 0x3D071F1 VA: 0x3D070F0
	|-List<Detail.Ranking.RankingCachedResultInt>.Contains
	|
	|-RVA: 0x3D0A4E0 Offset: 0x3D0A5E1 VA: 0x3D0A4E0
	|-List<Detail.Ranking.RankingOrderParamInt>.Contains
	|
	|-RVA: 0x3D0D5A0 Offset: 0x3D0D6A1 VA: 0x3D0D5A0
	|-List<Detail.Ranking.RankingRankDataInt>.Contains
	|
	|-RVA: 0x3D10C60 Offset: 0x3D10D61 VA: 0x3D10C60
	|-List<Detail.Ranking2.Ranking2ChartInfoInt>.Contains
	|
	|-RVA: 0x3D67520 Offset: 0x3D67621 VA: 0x3D67520
	|-List<Detail.Ranking2.Ranking2RankDataInt>.Contains
	|
	|-RVA: 0x3D6A8C0 Offset: 0x3D6A9C1 VA: 0x3D6A8C0
	|-List<Detail.Ranking2.Ranking2ScoreDataInt>.Contains
	|
	|-RVA: 0x3D6D890 Offset: 0x3D6D991 VA: 0x3D6D890
	|-List<Detail.Screening.ScreeningContextInfoInt>.Contains
	|
	|-RVA: 0x3D70C40 Offset: 0x3D70D41 VA: 0x3D70C40
	|-List<Detail.Subscriber.SubscriberContentInt>.Contains
	|
	|-RVA: 0x3D74250 Offset: 0x3D74351 VA: 0x3D74250
	|-List<Detail.Subscriber.SubscriberGetContentParamInt>.Contains
	|
	|-RVA: 0x3D774C0 Offset: 0x3D775C1 VA: 0x3D774C0
	|-List<Detail.Subscriber.SubscriberUserStatusInfoInt>.Contains
	|
	|-RVA: 0x3D7A7D0 Offset: 0x3D7A8D1 VA: 0x3D7A7D0
	|-List<Detail.Subscriber.SubscriberUserStatusParamInt>.Contains
	|
	|-RVA: 0x3D7D870 Offset: 0x3D7D971 VA: 0x3D7D870
	|-List<Detail.Utility.IntegerSettings>.Contains
	|
	|-RVA: 0x3D806D0 Offset: 0x3D807D1 VA: 0x3D806D0
	|-List<Detail.Utility.UniqueIdInfoInt>.Contains
	|
	|-RVA: 0x3D835C0 Offset: 0x3D836C1 VA: 0x3D835C0
	|-List<MapHistory.Rewind.LatestInspectorData>.Contains
	|
	|-RVA: 0x305F880 Offset: 0x305F981 VA: 0x305F880
	|-List<MapHistory.Rewind.WorkTerrainData>.Contains
	|
	|-RVA: 0x3062880 Offset: 0x3062981 VA: 0x3062880
	|-List<MapSkill.AroundCalculator.Result>.Contains
	|
	|-RVA: 0x3065900 Offset: 0x3065A01 VA: 0x3065900
	|-List<TargetPositionCache.CacheCurve.Item>.Contains
	|
	|-RVA: 0x3068CA0 Offset: 0x3068DA1 VA: 0x3068CA0
	|-List<TargetPositionCache.CacheEntry.RecordingItem>.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 21
	private bool System.Collections.IList.Contains(object item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3B0B690 Offset: 0x3B0B791 VA: 0x3B0B690
	|-List<IntervalTree.Entry<object>>.System.Collections.IList.Contains
	|
	|-RVA: 0x3B0E770 Offset: 0x3B0E871 VA: 0x3B0E770
	|-List<KeyValuePair<DateTime, object>>.System.Collections.IList.Contains
	|
	|-RVA: 0x3B11690 Offset: 0x3B11791 VA: 0x3B11690
	|-List<KeyValuePair<int, object>>.System.Collections.IList.Contains
	|
	|-RVA: 0x3B146E0 Offset: 0x3B147E1 VA: 0x3B146E0
	|-List<KeyValuePair<object, ValueTuple<int, DateTime, object>>>.System.Collections.IList.Contains
	|
	|-RVA: 0x3B177D0 Offset: 0x3B178D1 VA: 0x3B177D0
	|-List<KeyValuePair<object, object>>.System.Collections.IList.Contains
	|
	|-RVA: 0x3B1A820 Offset: 0x3B1A921 VA: 0x3B1A820
	|-List<CommonBattleSequence.Reliance<object>>.System.Collections.IList.Contains
	|
	|-RVA: 0x3B1D900 Offset: 0x3B1DA01 VA: 0x3B1D900
	|-List<RenderGraphResourcePool.ResourceLogInfo<object>>.System.Collections.IList.Contains
	|
	|-RVA: 0x3B20820 Offset: 0x3B20921 VA: 0x3B20820
	|-List<ValueTuple<int, object>>.System.Collections.IList.Contains
	|
	|-RVA: 0x3DE1440 Offset: 0x3DE1541 VA: 0x3DE1440
	|-List<ValueTuple<Int32Enum, int>>.System.Collections.IList.Contains
	|
	|-RVA: 0x3DE43F0 Offset: 0x3DE44F1 VA: 0x3DE43F0
	|-List<ValueTuple<object, ValueTuple<object, int>>>.System.Collections.IList.Contains
	|
	|-RVA: 0x3DE74D0 Offset: 0x3DE75D1 VA: 0x3DE74D0
	|-List<ValueTuple<object, int>>.System.Collections.IList.Contains
	|
	|-RVA: 0x3DEA470 Offset: 0x3DEA571 VA: 0x3DEA470
	|-List<ValueTuple<Vector3, float>>.System.Collections.IList.Contains
	|
	|-RVA: 0x3DED3F0 Offset: 0x3DED4F1 VA: 0x3DED3F0
	|-List<ValueTuple<object, Int32Enum, int>>.System.Collections.IList.Contains
	|
	|-RVA: 0x3DF0440 Offset: 0x3DF0541 VA: 0x3DF0440
	|-List<ValueTuple<object, int, int, int>>.System.Collections.IList.Contains
	|
	|-RVA: 0x3DF34B0 Offset: 0x3DF35B1 VA: 0x3DF34B0
	|-List<AnimatorClipInfo>.System.Collections.IList.Contains
	|
	|-RVA: 0x3DF6460 Offset: 0x3DF6561 VA: 0x3DF6460
	|-List<AsyncOperationHandle>.System.Collections.IList.Contains
	|
	|-RVA: 0x3DF9660 Offset: 0x3DF9761 VA: 0x3DF9660
	|-List<BoneWeight>.System.Collections.IList.Contains
	|
	|-RVA: 0x3DFC6D0 Offset: 0x3DFC7D1 VA: 0x3DFC6D0
	|-List<bool>.System.Collections.IList.Contains
	|
	|-RVA: 0x3E79C20 Offset: 0x3E79D21 VA: 0x3E79C20
	|-List<byte>.System.Collections.IList.Contains
	|
	|-RVA: 0x3E11530 Offset: 0x3E11631 VA: 0x3E11530
	|-List<Camera>.System.Collections.IList.Contains
	|-List<Decorator>.System.Collections.IList.Contains
	|-List<DynValue>.System.Collections.IList.Contains
	|-List<GameObject>.System.Collections.IList.Contains
	|-List<MapBackup>.System.Collections.IList.Contains
	|-List<object>.System.Collections.IList.Contains
	|-List<Phase>.System.Collections.IList.Contains
	|-List<ProfileCard>.System.Collections.IList.Contains
	|-List<Unit>.System.Collections.IList.Contains
	|-List<AssetTable.Accessory>.System.Collections.IList.Contains
	|-List<GameSaveDataHeaderReader.Handle>.System.Collections.IList.Contains
	|-List<MapDispos.ActualData>.System.Collections.IList.Contains
	|-List<MapDispos.Pos>.System.Collections.IList.Contains
	|-List<MapLayer.Data>.System.Collections.IList.Contains
	|-List<MapObject.RigidInfo>.System.Collections.IList.Contains
	|-List<RingListSequence.PageData>.System.Collections.IList.Contains
	|
	|-RVA: 0x3E7CAA0 Offset: 0x3E7CBA1 VA: 0x3E7CAA0
	|-List<CameraInfo>.System.Collections.IList.Contains
	|
	|-RVA: 0x3E7F950 Offset: 0x3E7FA51 VA: 0x3E7F950
	|-List<char>.System.Collections.IList.Contains
	|
	|-RVA: 0x3E82840 Offset: 0x3E82941 VA: 0x3E82840
	|-List<Color>.System.Collections.IList.Contains
	|
	|-RVA: 0x3E85750 Offset: 0x3E85851 VA: 0x3E85750
	|-List<Color32>.System.Collections.IList.Contains
	|
	|-RVA: 0x3E885D0 Offset: 0x3E886D1 VA: 0x3E885D0
	|-List<ConstraintSource>.System.Collections.IList.Contains
	|
	|-RVA: 0x3E8B620 Offset: 0x3E8B721 VA: 0x3E8B620
	|-List<ContourVertex>.System.Collections.IList.Contains
	|
	|-RVA: 0x3E8E820 Offset: 0x3E8E921 VA: 0x3E8E820
	|-List<DataStoreRatingInfo>.System.Collections.IList.Contains
	|
	|-RVA: 0x3E91870 Offset: 0x3E91971 VA: 0x3E91870
	|-List<DataStoreResult>.System.Collections.IList.Contains
	|
	|-RVA: 0x3E94680 Offset: 0x3E94781 VA: 0x3E94680
	|-List<DateTime>.System.Collections.IList.Contains
	|
	|-RVA: 0x3E974E0 Offset: 0x3E975E1 VA: 0x3E974E0
	|-List<DateTimeOffset>.System.Collections.IList.Contains
	|
	|-RVA: 0x3E9A3C0 Offset: 0x3E9A4C1 VA: 0x3E9A3C0
	|-List<Decimal>.System.Collections.IList.Contains
	|
	|-RVA: 0x3E9D4B0 Offset: 0x3E9D5B1 VA: 0x3E9D4B0
	|-List<DiagnosticEvent>.System.Collections.IList.Contains
	|
	|-RVA: 0x3EA06A0 Offset: 0x3EA07A1 VA: 0x3EA06A0
	|-List<double>.System.Collections.IList.Contains
	|
	|-RVA: 0x3EA36A0 Offset: 0x3EA37A1 VA: 0x3EA36A0
	|-List<Friend>.System.Collections.IList.Contains
	|
	|-RVA: 0x3EA6890 Offset: 0x3EA6991 VA: 0x3EA6890
	|-List<GlyphRect>.System.Collections.IList.Contains
	|
	|-RVA: 0x3EA9720 Offset: 0x3EA9821 VA: 0x3EA9720
	|-List<short>.System.Collections.IList.Contains
	|
	|-RVA: 0x3EAC520 Offset: 0x3EAC621 VA: 0x3EAC520
	|-List<int>.System.Collections.IList.Contains
	|
	|-RVA: 0x3EAF320 Offset: 0x3EAF421 VA: 0x3EAF320
	|-List<Int32Enum>.System.Collections.IList.Contains
	|
	|-RVA: 0x3EB2120 Offset: 0x3EB2221 VA: 0x3EB2120
	|-List<long>.System.Collections.IList.Contains
	|
	|-RVA: 0x3DFF4F0 Offset: 0x3DFF5F1 VA: 0x3DFF4F0
	|-List<IntPtr>.System.Collections.IList.Contains
	|
	|-RVA: 0x3E02360 Offset: 0x3E02461 VA: 0x3E02360
	|-List<InterpretedFrameInfo>.System.Collections.IList.Contains
	|
	|-RVA: 0x3E053A0 Offset: 0x3E054A1 VA: 0x3E053A0
	|-List<IntervalTreeNode>.System.Collections.IList.Contains
	|
	|-RVA: 0x3E083F0 Offset: 0x3E084F1 VA: 0x3E083F0
	|-List<LengthLimitProperties>.System.Collections.IList.Contains
	|
	|-RVA: 0x3E0B200 Offset: 0x3E0B301 VA: 0x3E0B200
	|-List<MapPos>.System.Collections.IList.Contains
	|
	|-RVA: 0x3E0E2D0 Offset: 0x3E0E3D1 VA: 0x3E0E2D0
	|-List<Matrix4x4>.System.Collections.IList.Contains
	|
	|-RVA: 0x3E145B0 Offset: 0x3E146B1 VA: 0x3E145B0
	|-List<ObjectInitializationData>.System.Collections.IList.Contains
	|
	|-RVA: 0x3E17930 Offset: 0x3E17A31 VA: 0x3E17930
	|-List<PlayableBinding>.System.Collections.IList.Contains
	|
	|-RVA: 0x3E1AC00 Offset: 0x3E1AD01 VA: 0x3E1AC00
	|-List<PlayerLoopSystem>.System.Collections.IList.Contains
	|
	|-RVA: 0x3DA50A0 Offset: 0x3DA51A1 VA: 0x3DA50A0
	|-List<PlayerLoopSystemInternal>.System.Collections.IList.Contains
	|
	|-RVA: 0x3DA8290 Offset: 0x3DA8391 VA: 0x3DA8290
	|-List<RangePositionInfo>.System.Collections.IList.Contains
	|
	|-RVA: 0x3DAB140 Offset: 0x3DAB241 VA: 0x3DAB140
	|-List<Ranking2ChartInfoInput>.System.Collections.IList.Contains
	|
	|-RVA: 0x3DAE1C0 Offset: 0x3DAE2C1 VA: 0x3DAE1C0
	|-List<RaycastHit2D>.System.Collections.IList.Contains
	|
	|-RVA: 0x3DB1730 Offset: 0x3DB1831 VA: 0x3DB1730
	|-List<RaycastResult>.System.Collections.IList.Contains
	|
	|-RVA: 0x3DB4C70 Offset: 0x3DB4D71 VA: 0x3DB4C70
	|-List<Rect>.System.Collections.IList.Contains
	|
	|-RVA: 0x3DB7B80 Offset: 0x3DB7C81 VA: 0x3DB7B80
	|-List<RendererListHandle>.System.Collections.IList.Contains
	|
	|-RVA: 0x3DBA990 Offset: 0x3DBAA91 VA: 0x3DBA990
	|-List<ResourceHandle>.System.Collections.IList.Contains
	|
	|-RVA: 0x3DBD7A0 Offset: 0x3DBD8A1 VA: 0x3DBD7A0
	|-List<sbyte>.System.Collections.IList.Contains
	|
	|-RVA: 0x3DC05B0 Offset: 0x3DC06B1 VA: 0x3DC05B0
	|-List<ShaderTagId>.System.Collections.IList.Contains
	|
	|-RVA: 0x3E3C220 Offset: 0x3E3C321 VA: 0x3E3C220
	|-List<float>.System.Collections.IList.Contains
	|
	|-RVA: 0x3E3F5C0 Offset: 0x3E3F6C1 VA: 0x3E3F5C0
	|-List<SphericalHarmonicsL2>.System.Collections.IList.Contains
	|
	|-RVA: 0x3E42F50 Offset: 0x3E43051 VA: 0x3E42F50
	|-List<SubMeshDescriptor>.System.Collections.IList.Contains
	|
	|-RVA: 0x3E46170 Offset: 0x3E46271 VA: 0x3E46170
	|-List<TablePair>.System.Collections.IList.Contains
	|
	|-RVA: 0x3E49020 Offset: 0x3E49121 VA: 0x3E49020
	|-List<TimeSpan>.System.Collections.IList.Contains
	|
	|-RVA: 0x3E4BEF0 Offset: 0x3E4BFF1 VA: 0x3E4BEF0
	|-List<UICharInfo>.System.Collections.IList.Contains
	|
	|-RVA: 0x3E4EE60 Offset: 0x3E4EF61 VA: 0x3E4EE60
	|-List<UILineInfo>.System.Collections.IList.Contains
	|
	|-RVA: 0x3E52280 Offset: 0x3E52381 VA: 0x3E52280
	|-List<UIVertex>.System.Collections.IList.Contains
	|
	|-RVA: 0x3E559D0 Offset: 0x3E55AD1 VA: 0x3E559D0
	|-List<ushort>.System.Collections.IList.Contains
	|
	|-RVA: 0x3E587D0 Offset: 0x3E588D1 VA: 0x3E587D0
	|-List<uint>.System.Collections.IList.Contains
	|
	|-RVA: 0x3DC33C0 Offset: 0x3DC34C1 VA: 0x3DC33C0
	|-List<ulong>.System.Collections.IList.Contains
	|
	|-RVA: 0x3DC6200 Offset: 0x3DC6301 VA: 0x3DC6200
	|-List<Vector2>.System.Collections.IList.Contains
	|
	|-RVA: 0x3DC9150 Offset: 0x3DC9251 VA: 0x3DC9150
	|-List<Vector3>.System.Collections.IList.Contains
	|
	|-RVA: 0x3DCC160 Offset: 0x3DCC261 VA: 0x3DCC160
	|-List<Vector4>.System.Collections.IList.Contains
	|
	|-RVA: 0x3DCF0C0 Offset: 0x3DCF1C1 VA: 0x3DCF0C0
	|-List<VertexAttributeDescriptor>.System.Collections.IList.Contains
	|
	|-RVA: 0x3DD1FC0 Offset: 0x3DD20C1 VA: 0x3DD1FC0
	|-List<X509ChainStatus>.System.Collections.IList.Contains
	|
	|-RVA: 0x3DD5090 Offset: 0x3DD5191 VA: 0x3DD5090
	|-List<XRView>.System.Collections.IList.Contains
	|
	|-RVA: 0x3DD82D0 Offset: 0x3DD83D1 VA: 0x3DD82D0
	|-List<AmiiboSequence.GainItemData>.System.Collections.IList.Contains
	|
	|-RVA: 0x3DDB3C0 Offset: 0x3DDB4C1 VA: 0x3DDB3C0
	|-List<AnimationOutputWeightProcessor.WeightInfo>.System.Collections.IList.Contains
	|
	|-RVA: 0x3DDE590 Offset: 0x3DDE691 VA: 0x3DDE590
	|-List<ArenaOrderSequence.GodInfo>.System.Collections.IList.Contains
	|
	|-RVA: 0x3E1DDF0 Offset: 0x3E1DEF1 VA: 0x3E1DDF0
	|-List<BattleInfo.SupportData>.System.Collections.IList.Contains
	|
	|-RVA: 0x3E20D10 Offset: 0x3E20E11 VA: 0x3E20D10
	|-List<BeforeRenderHelper.OrderBlock>.System.Collections.IList.Contains
	|
	|-RVA: 0x3E23D70 Offset: 0x3E23E71 VA: 0x3E23D70
	|-List<Camera.RenderRequest>.System.Collections.IList.Contains
	|
	|-RVA: 0x3E26E60 Offset: 0x3E26F61 VA: 0x3E26E60
	|-List<CameraState.CustomBlendable>.System.Collections.IList.Contains
	|
	|-RVA: 0x3E29D10 Offset: 0x3E29E11 VA: 0x3E29D10
	|-List<CinemachineClearShot.Pair>.System.Collections.IList.Contains
	|
	|-RVA: 0x3E2CB20 Offset: 0x3E2CC21 VA: 0x3E2CB20
	|-List<CinemachineStateDrivenCamera.HashPair>.System.Collections.IList.Contains
	|
	|-RVA: 0x3E2FAD0 Offset: 0x3E2FBD1 VA: 0x3E2FAD0
	|-List<DelayedActionManager.DelegateInfo>.System.Collections.IList.Contains
	|
	|-RVA: 0x3E32D90 Offset: 0x3E32E91 VA: 0x3E32D90
	|-List<Detail.AsyncResultInt>.System.Collections.IList.Contains
	|
	|-RVA: 0x3E35F90 Offset: 0x3E36091 VA: 0x3E35F90
	|-List<Detail.CppArray>.System.Collections.IList.Contains
	|
	|-RVA: 0x3E39060 Offset: 0x3E39161 VA: 0x3E39060
	|-List<Detail.NotificationEventInt>.System.Collections.IList.Contains
	|
	|-RVA: 0x3E5B640 Offset: 0x3E5B741 VA: 0x3E5B640
	|-List<DragonRideTargetGroup.ChainParam>.System.Collections.IList.Contains
	|
	|-RVA: 0x3E5E690 Offset: 0x3E5E791 VA: 0x3E5E690
	|-List<GmapPathAdjuster.TargetModel>.System.Collections.IList.Contains
	|
	|-RVA: 0x3E618A0 Offset: 0x3E619A1 VA: 0x3E618A0
	|-List<GmapSpotAdjuster.TargetModel>.System.Collections.IList.Contains
	|
	|-RVA: 0x3E64AB0 Offset: 0x3E64BB1 VA: 0x3E64AB0
	|-List<HubFastTravel.Location>.System.Collections.IList.Contains
	|
	|-RVA: 0x3E67D80 Offset: 0x3E67E81 VA: 0x3E67D80
	|-List<HubLensFlare.Flare>.System.Collections.IList.Contains
	|
	|-RVA: 0x3E6AFD0 Offset: 0x3E6B0D1 VA: 0x3E6AFD0
	|-List<InventoryPoolItemMenuContent.KindBgNameClass>.System.Collections.IList.Contains
	|
	|-RVA: 0x3E6DE80 Offset: 0x3E6DF81 VA: 0x3E6DE80
	|-List<Map.Pos>.System.Collections.IList.Contains
	|
	|-RVA: 0x3E70CE0 Offset: 0x3E70DE1 VA: 0x3E70CE0
	|-List<MapImage.BackupTerrain>.System.Collections.IList.Contains
	|
	|-RVA: 0x3E73B80 Offset: 0x3E73C81 VA: 0x3E73B80
	|-List<MapImageRange.Pos>.System.Collections.IList.Contains
	|
	|-RVA: 0x3E76BB0 Offset: 0x3E76CB1 VA: 0x3E76BB0
	|-List<MapMind.Target>.System.Collections.IList.Contains
	|
	|-RVA: 0x3D867A0 Offset: 0x3D868A1 VA: 0x3D867A0
	|-List<MapPanelDebug.Entity>.System.Collections.IList.Contains
	|
	|-RVA: 0x3D897F0 Offset: 0x3D898F1 VA: 0x3D897F0
	|-List<NexRanking.Data>.System.Collections.IList.Contains
	|
	|-RVA: 0x3D8C650 Offset: 0x3D8C751 VA: 0x3D8C650
	|-List<NexVersus.RatingData>.System.Collections.IList.Contains
	|
	|-RVA: 0x3D8F550 Offset: 0x3D8F651 VA: 0x3D8F550
	|-List<PackedPlayModeBuildLogs.RuntimeBuildLog>.System.Collections.IList.Contains
	|
	|-RVA: 0x3D92610 Offset: 0x3D92711 VA: 0x3D92610
	|-List<ParticleSystem.Particle>.System.Collections.IList.Contains
	|
	|-RVA: 0x3D957B0 Offset: 0x3D958B1 VA: 0x3D957B0
	|-List<RangeData.Offset>.System.Collections.IList.Contains
	|
	|-RVA: 0x3D98760 Offset: 0x3D98861 VA: 0x3D98760
	|-List<RenderGraphDebugData.PassDebugData>.System.Collections.IList.Contains
	|
	|-RVA: 0x3D9BA30 Offset: 0x3D9BB31 VA: 0x3D9BA30
	|-List<RenderGraphDebugData.ResourceDebugData>.System.Collections.IList.Contains
	|
	|-RVA: 0x3D9EC20 Offset: 0x3D9ED21 VA: 0x3D9EC20
	|-List<RingCleaningUnitSelectMenu.GodParam>.System.Collections.IList.Contains
	|
	|-RVA: 0x3DA1D10 Offset: 0x3DA1E11 VA: 0x3DA1D10
	|-List<ShadowUtility.Edge>.System.Collections.IList.Contains
	|
	|-RVA: 0x3D14320 Offset: 0x3D14421 VA: 0x3D14320
	|-List<SkillArray.Entity>.System.Collections.IList.Contains
	|
	|-RVA: 0x3D17400 Offset: 0x3D17501 VA: 0x3D17400
	|-List<TexturePacker_JsonArray.Frame>.System.Collections.IList.Contains
	|
	|-RVA: 0x3D1A8A0 Offset: 0x3D1A9A1 VA: 0x3D1A8A0
	|-List<TimeNotificationBehaviour.NotificationEntry>.System.Collections.IList.Contains
	|
	|-RVA: 0x3D1DAC0 Offset: 0x3D1DBC1 VA: 0x3D1DAC0
	|-List<UnitySynchronizationContext.WorkRequest>.System.Collections.IList.Contains
	|
	|-RVA: 0x3D20BA0 Offset: 0x3D20CA1 VA: 0x3D20BA0
	|-List<XmlSchemaObjectTable.XmlSchemaObjectEntry>.System.Collections.IList.Contains
	|
	|-RVA: 0x3D23AC0 Offset: 0x3D23BC1 VA: 0x3D23AC0
	|-List<AssetBundleBuildMap.AssetBundleEntry.AssetPathString>.System.Collections.IList.Contains
	|
	|-RVA: 0x3D26B90 Offset: 0x3D26C91 VA: 0x3D26B90
	|-List<Detail.DataStore.DataStoreChangeMetaParamInt>.System.Collections.IList.Contains
	|
	|-RVA: 0x3D29DE0 Offset: 0x3D29EE1 VA: 0x3D29DE0
	|-List<Detail.DataStore.DataStoreDeleteParamInt>.System.Collections.IList.Contains
	|
	|-RVA: 0x3D2CEB0 Offset: 0x3D2CFB1 VA: 0x3D2CEB0
	|-List<Detail.DataStore.DataStoreGetMetaParamInt>.System.Collections.IList.Contains
	|
	|-RVA: 0x3D30220 Offset: 0x3D30321 VA: 0x3D30220
	|-List<Detail.DataStore.DataStoreMetaInfoInt>.System.Collections.IList.Contains
	|
	|-RVA: 0x3CF49E0 Offset: 0x3CF4AE1 VA: 0x3CF49E0
	|-List<Detail.DataStore.DataStorePasswordInfoInt>.System.Collections.IList.Contains
	|
	|-RVA: 0x3CF7BC0 Offset: 0x3CF7CC1 VA: 0x3CF7BC0
	|-List<Detail.DataStore.DataStorePersistenceInfoInt>.System.Collections.IList.Contains
	|
	|-RVA: 0x3CFAE20 Offset: 0x3CFAF21 VA: 0x3CFAE20
	|-List<Detail.DataStore.DataStorePreparePostParamInt>.System.Collections.IList.Contains
	|
	|-RVA: 0x3CFE010 Offset: 0x3CFE111 VA: 0x3CFE010
	|-List<Detail.DataStore.DataStoreRateObjectParamInt>.System.Collections.IList.Contains
	|
	|-RVA: 0x3D01030 Offset: 0x3D01131 VA: 0x3D01030
	|-List<Detail.DataStore.DataStoreRatingInitParamInt>.System.Collections.IList.Contains
	|
	|-RVA: 0x3D040E0 Offset: 0x3D041E1 VA: 0x3D040E0
	|-List<Detail.DataStore.DataStoreRatingTargetInt>.System.Collections.IList.Contains
	|
	|-RVA: 0x3D07240 Offset: 0x3D07341 VA: 0x3D07240
	|-List<Detail.Ranking.RankingCachedResultInt>.System.Collections.IList.Contains
	|
	|-RVA: 0x3D0A5A0 Offset: 0x3D0A6A1 VA: 0x3D0A5A0
	|-List<Detail.Ranking.RankingOrderParamInt>.System.Collections.IList.Contains
	|
	|-RVA: 0x3D0D6F0 Offset: 0x3D0D7F1 VA: 0x3D0D6F0
	|-List<Detail.Ranking.RankingRankDataInt>.System.Collections.IList.Contains
	|
	|-RVA: 0x3D10DF0 Offset: 0x3D10EF1 VA: 0x3D10DF0
	|-List<Detail.Ranking2.Ranking2ChartInfoInt>.System.Collections.IList.Contains
	|
	|-RVA: 0x3D67670 Offset: 0x3D67771 VA: 0x3D67670
	|-List<Detail.Ranking2.Ranking2RankDataInt>.System.Collections.IList.Contains
	|
	|-RVA: 0x3D6A980 Offset: 0x3D6AA81 VA: 0x3D6A980
	|-List<Detail.Ranking2.Ranking2ScoreDataInt>.System.Collections.IList.Contains
	|
	|-RVA: 0x3D6D9A0 Offset: 0x3D6DAA1 VA: 0x3D6D9A0
	|-List<Detail.Screening.ScreeningContextInfoInt>.System.Collections.IList.Contains
	|
	|-RVA: 0x3D70DB0 Offset: 0x3D70EB1 VA: 0x3D70DB0
	|-List<Detail.Subscriber.SubscriberContentInt>.System.Collections.IList.Contains
	|
	|-RVA: 0x3D74360 Offset: 0x3D74461 VA: 0x3D74360
	|-List<Detail.Subscriber.SubscriberGetContentParamInt>.System.Collections.IList.Contains
	|
	|-RVA: 0x3D775F0 Offset: 0x3D776F1 VA: 0x3D775F0
	|-List<Detail.Subscriber.SubscriberUserStatusInfoInt>.System.Collections.IList.Contains
	|
	|-RVA: 0x3D7A8E0 Offset: 0x3D7A9E1 VA: 0x3D7A8E0
	|-List<Detail.Subscriber.SubscriberUserStatusParamInt>.System.Collections.IList.Contains
	|
	|-RVA: 0x3D7D930 Offset: 0x3D7DA31 VA: 0x3D7D930
	|-List<Detail.Utility.IntegerSettings>.System.Collections.IList.Contains
	|
	|-RVA: 0x3D80790 Offset: 0x3D80891 VA: 0x3D80790
	|-List<Detail.Utility.UniqueIdInfoInt>.System.Collections.IList.Contains
	|
	|-RVA: 0x3D83690 Offset: 0x3D83791 VA: 0x3D83690
	|-List<MapHistory.Rewind.LatestInspectorData>.System.Collections.IList.Contains
	|
	|-RVA: 0x305F950 Offset: 0x305FA51 VA: 0x305F950
	|-List<MapHistory.Rewind.WorkTerrainData>.System.Collections.IList.Contains
	|
	|-RVA: 0x3062940 Offset: 0x3062A41 VA: 0x3062940
	|-List<MapSkill.AroundCalculator.Result>.System.Collections.IList.Contains
	|
	|-RVA: 0x3065A30 Offset: 0x3065B31 VA: 0x3065A30
	|-List<TargetPositionCache.CacheCurve.Item>.System.Collections.IList.Contains
	|
	|-RVA: 0x3068DE0 Offset: 0x3068EE1 VA: 0x3068DE0
	|-List<TargetPositionCache.CacheEntry.RecordingItem>.System.Collections.IList.Contains
	*/

	// RVA: -1 Offset: -1
	public void CopyTo(T[] array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3B0B7E0 Offset: 0x3B0B8E1 VA: 0x3B0B7E0
	|-List<IntervalTree.Entry<object>>.CopyTo
	|
	|-RVA: 0x3B0E8B0 Offset: 0x3B0E9B1 VA: 0x3B0E8B0
	|-List<KeyValuePair<DateTime, object>>.CopyTo
	|
	|-RVA: 0x3B117D0 Offset: 0x3B118D1 VA: 0x3B117D0
	|-List<KeyValuePair<int, object>>.CopyTo
	|
	|-RVA: 0x3B14830 Offset: 0x3B14931 VA: 0x3B14830
	|-List<KeyValuePair<object, ValueTuple<int, DateTime, object>>>.CopyTo
	|
	|-RVA: 0x3B17910 Offset: 0x3B17A11 VA: 0x3B17910
	|-List<KeyValuePair<object, object>>.CopyTo
	|
	|-RVA: 0x3B1A970 Offset: 0x3B1AA71 VA: 0x3B1A970
	|-List<CommonBattleSequence.Reliance<object>>.CopyTo
	|
	|-RVA: 0x3B1DA40 Offset: 0x3B1DB41 VA: 0x3B1DA40
	|-List<RenderGraphResourcePool.ResourceLogInfo<object>>.CopyTo
	|
	|-RVA: 0x3B20960 Offset: 0x3B20A61 VA: 0x3B20960
	|-List<ValueTuple<int, object>>.CopyTo
	|
	|-RVA: 0x3DE1580 Offset: 0x3DE1681 VA: 0x3DE1580
	|-List<ValueTuple<Int32Enum, int>>.CopyTo
	|
	|-RVA: 0x3DE4540 Offset: 0x3DE4641 VA: 0x3DE4540
	|-List<ValueTuple<object, ValueTuple<object, int>>>.CopyTo
	|
	|-RVA: 0x3DE7610 Offset: 0x3DE7711 VA: 0x3DE7610
	|-List<ValueTuple<object, int>>.CopyTo
	|
	|-RVA: 0x3DEA5C0 Offset: 0x3DEA6C1 VA: 0x3DEA5C0
	|-List<ValueTuple<Vector3, float>>.CopyTo
	|
	|-RVA: 0x3DED530 Offset: 0x3DED631 VA: 0x3DED530
	|-List<ValueTuple<object, Int32Enum, int>>.CopyTo
	|
	|-RVA: 0x3DF0590 Offset: 0x3DF0691 VA: 0x3DF0590
	|-List<ValueTuple<object, int, int, int>>.CopyTo
	|
	|-RVA: 0x3DF35F0 Offset: 0x3DF36F1 VA: 0x3DF35F0
	|-List<AnimatorClipInfo>.CopyTo
	|
	|-RVA: 0x3DF65B0 Offset: 0x3DF66B1 VA: 0x3DF65B0
	|-List<AsyncOperationHandle>.CopyTo
	|
	|-RVA: 0x3DF97B0 Offset: 0x3DF98B1 VA: 0x3DF97B0
	|-List<BoneWeight>.CopyTo
	|
	|-RVA: 0x3DFC810 Offset: 0x3DFC911 VA: 0x3DFC810
	|-List<bool>.CopyTo
	|
	|-RVA: 0x3E79D60 Offset: 0x3E79E61 VA: 0x3E79D60
	|-List<byte>.CopyTo
	|
	|-RVA: 0x3E7CBE0 Offset: 0x3E7CCE1 VA: 0x3E7CBE0
	|-List<CameraInfo>.CopyTo
	|
	|-RVA: 0x3E7FA90 Offset: 0x3E7FB91 VA: 0x3E7FA90
	|-List<char>.CopyTo
	|
	|-RVA: 0x3E82990 Offset: 0x3E82A91 VA: 0x3E82990
	|-List<Color>.CopyTo
	|
	|-RVA: 0x3E85890 Offset: 0x3E85991 VA: 0x3E85890
	|-List<Color32>.CopyTo
	|
	|-RVA: 0x3E88710 Offset: 0x3E88811 VA: 0x3E88710
	|-List<ConstraintSource>.CopyTo
	|
	|-RVA: 0x3E8B770 Offset: 0x3E8B871 VA: 0x3E8B770
	|-List<ContourVertex>.CopyTo
	|
	|-RVA: 0x3E8E970 Offset: 0x3E8EA71 VA: 0x3E8E970
	|-List<DataStoreRatingInfo>.CopyTo
	|
	|-RVA: 0x3E919B0 Offset: 0x3E91AB1 VA: 0x3E919B0
	|-List<DataStoreResult>.CopyTo
	|
	|-RVA: 0x3E947C0 Offset: 0x3E948C1 VA: 0x3E947C0
	|-List<DateTime>.CopyTo
	|
	|-RVA: 0x3E97620 Offset: 0x3E97721 VA: 0x3E97620
	|-List<DateTimeOffset>.CopyTo
	|
	|-RVA: 0x3E9A500 Offset: 0x3E9A601 VA: 0x3E9A500
	|-List<Decimal>.CopyTo
	|
	|-RVA: 0x3E9D600 Offset: 0x3E9D701 VA: 0x3E9D600
	|-List<DiagnosticEvent>.CopyTo
	|
	|-RVA: 0x3EA07E0 Offset: 0x3EA08E1 VA: 0x3EA07E0
	|-List<double>.CopyTo
	|
	|-RVA: 0x3EA37F0 Offset: 0x3EA38F1 VA: 0x3EA37F0
	|-List<Friend>.CopyTo
	|
	|-RVA: 0x3EA69D0 Offset: 0x3EA6AD1 VA: 0x3EA69D0
	|-List<GlyphRect>.CopyTo
	|
	|-RVA: 0x3EA9860 Offset: 0x3EA9961 VA: 0x3EA9860
	|-List<short>.CopyTo
	|
	|-RVA: 0x3EAC660 Offset: 0x3EAC761 VA: 0x3EAC660
	|-List<int>.CopyTo
	|
	|-RVA: 0x3EAF460 Offset: 0x3EAF561 VA: 0x3EAF460
	|-List<Int32Enum>.CopyTo
	|
	|-RVA: 0x3EB2260 Offset: 0x3EB2361 VA: 0x3EB2260
	|-List<long>.CopyTo
	|
	|-RVA: 0x3DFF630 Offset: 0x3DFF731 VA: 0x3DFF630
	|-List<IntPtr>.CopyTo
	|
	|-RVA: 0x3E024A0 Offset: 0x3E025A1 VA: 0x3E024A0
	|-List<InterpretedFrameInfo>.CopyTo
	|
	|-RVA: 0x3E054F0 Offset: 0x3E055F1 VA: 0x3E054F0
	|-List<IntervalTreeNode>.CopyTo
	|
	|-RVA: 0x3E08530 Offset: 0x3E08631 VA: 0x3E08530
	|-List<LengthLimitProperties>.CopyTo
	|
	|-RVA: 0x3E0B340 Offset: 0x3E0B441 VA: 0x3E0B340
	|-List<MapPos>.CopyTo
	|
	|-RVA: 0x3E0E430 Offset: 0x3E0E531 VA: 0x3E0E430
	|-List<Matrix4x4>.CopyTo
	|
	|-RVA: 0x3E11670 Offset: 0x3E11771 VA: 0x3E11670
	|-List<MethodBase>.CopyTo
	|-List<MethodInfo>.CopyTo
	|-List<object>.CopyTo
	|
	|-RVA: 0x3E14700 Offset: 0x3E14801 VA: 0x3E14700
	|-List<ObjectInitializationData>.CopyTo
	|
	|-RVA: 0x3E17A80 Offset: 0x3E17B81 VA: 0x3E17A80
	|-List<PlayableBinding>.CopyTo
	|
	|-RVA: 0x3E1AD50 Offset: 0x3E1AE51 VA: 0x3E1AD50
	|-List<PlayerLoopSystem>.CopyTo
	|
	|-RVA: 0x3DA51F0 Offset: 0x3DA52F1 VA: 0x3DA51F0
	|-List<PlayerLoopSystemInternal>.CopyTo
	|
	|-RVA: 0x3DA83D0 Offset: 0x3DA84D1 VA: 0x3DA83D0
	|-List<RangePositionInfo>.CopyTo
	|
	|-RVA: 0x3DAB280 Offset: 0x3DAB381 VA: 0x3DAB280
	|-List<Ranking2ChartInfoInput>.CopyTo
	|
	|-RVA: 0x3DAE320 Offset: 0x3DAE421 VA: 0x3DAE320
	|-List<RaycastHit2D>.CopyTo
	|
	|-RVA: 0x3DB1890 Offset: 0x3DB1991 VA: 0x3DB1890
	|-List<RaycastResult>.CopyTo
	|
	|-RVA: 0x3DB4DC0 Offset: 0x3DB4EC1 VA: 0x3DB4DC0
	|-List<Rect>.CopyTo
	|
	|-RVA: 0x3DB7CC0 Offset: 0x3DB7DC1 VA: 0x3DB7CC0
	|-List<RendererListHandle>.CopyTo
	|
	|-RVA: 0x3DBAAD0 Offset: 0x3DBABD1 VA: 0x3DBAAD0
	|-List<ResourceHandle>.CopyTo
	|
	|-RVA: 0x3DBD8E0 Offset: 0x3DBD9E1 VA: 0x3DBD8E0
	|-List<sbyte>.CopyTo
	|
	|-RVA: 0x3DC06F0 Offset: 0x3DC07F1 VA: 0x3DC06F0
	|-List<ShaderTagId>.CopyTo
	|
	|-RVA: 0x3E3C360 Offset: 0x3E3C461 VA: 0x3E3C360
	|-List<float>.CopyTo
	|
	|-RVA: 0x3E3F740 Offset: 0x3E3F841 VA: 0x3E3F740
	|-List<SphericalHarmonicsL2>.CopyTo
	|
	|-RVA: 0x3E430A0 Offset: 0x3E431A1 VA: 0x3E430A0
	|-List<SubMeshDescriptor>.CopyTo
	|
	|-RVA: 0x3E462B0 Offset: 0x3E463B1 VA: 0x3E462B0
	|-List<TablePair>.CopyTo
	|
	|-RVA: 0x3E49160 Offset: 0x3E49261 VA: 0x3E49160
	|-List<TimeSpan>.CopyTo
	|
	|-RVA: 0x3E4C040 Offset: 0x3E4C141 VA: 0x3E4C040
	|-List<UICharInfo>.CopyTo
	|
	|-RVA: 0x3E4EFA0 Offset: 0x3E4F0A1 VA: 0x3E4EFA0
	|-List<UILineInfo>.CopyTo
	|
	|-RVA: 0x3E52400 Offset: 0x3E52501 VA: 0x3E52400
	|-List<UIVertex>.CopyTo
	|
	|-RVA: 0x3E55B10 Offset: 0x3E55C11 VA: 0x3E55B10
	|-List<ushort>.CopyTo
	|
	|-RVA: 0x3E58910 Offset: 0x3E58A11 VA: 0x3E58910
	|-List<uint>.CopyTo
	|
	|-RVA: 0x3DC3500 Offset: 0x3DC3601 VA: 0x3DC3500
	|-List<ulong>.CopyTo
	|
	|-RVA: 0x3DC6340 Offset: 0x3DC6441 VA: 0x3DC6340
	|-List<Vector2>.CopyTo
	|
	|-RVA: 0x3DC92A0 Offset: 0x3DC93A1 VA: 0x3DC92A0
	|-List<Vector3>.CopyTo
	|
	|-RVA: 0x3DCC2B0 Offset: 0x3DCC3B1 VA: 0x3DCC2B0
	|-List<Vector4>.CopyTo
	|
	|-RVA: 0x3DCF200 Offset: 0x3DCF301 VA: 0x3DCF200
	|-List<VertexAttributeDescriptor>.CopyTo
	|
	|-RVA: 0x3DD2100 Offset: 0x3DD2201 VA: 0x3DD2100
	|-List<X509ChainStatus>.CopyTo
	|
	|-RVA: 0x3DD51E0 Offset: 0x3DD52E1 VA: 0x3DD51E0
	|-List<XRView>.CopyTo
	|
	|-RVA: 0x3DD8410 Offset: 0x3DD8511 VA: 0x3DD8410
	|-List<AmiiboSequence.GainItemData>.CopyTo
	|
	|-RVA: 0x3DDB510 Offset: 0x3DDB611 VA: 0x3DDB510
	|-List<AnimationOutputWeightProcessor.WeightInfo>.CopyTo
	|
	|-RVA: 0x3DDE6D0 Offset: 0x3DDE7D1 VA: 0x3DDE6D0
	|-List<ArenaOrderSequence.GodInfo>.CopyTo
	|
	|-RVA: 0x3E1DF30 Offset: 0x3E1E031 VA: 0x3E1DF30
	|-List<BattleInfo.SupportData>.CopyTo
	|
	|-RVA: 0x3E20E50 Offset: 0x3E20F51 VA: 0x3E20E50
	|-List<BeforeRenderHelper.OrderBlock>.CopyTo
	|
	|-RVA: 0x3E23EC0 Offset: 0x3E23FC1 VA: 0x3E23EC0
	|-List<Camera.RenderRequest>.CopyTo
	|
	|-RVA: 0x3E26FA0 Offset: 0x3E270A1 VA: 0x3E26FA0
	|-List<CameraState.CustomBlendable>.CopyTo
	|
	|-RVA: 0x3E29E50 Offset: 0x3E29F51 VA: 0x3E29E50
	|-List<CinemachineClearShot.Pair>.CopyTo
	|
	|-RVA: 0x3E2CC60 Offset: 0x3E2CD61 VA: 0x3E2CC60
	|-List<CinemachineStateDrivenCamera.HashPair>.CopyTo
	|
	|-RVA: 0x3E2FC20 Offset: 0x3E2FD21 VA: 0x3E2FC20
	|-List<DelayedActionManager.DelegateInfo>.CopyTo
	|
	|-RVA: 0x3E32EE0 Offset: 0x3E32FE1 VA: 0x3E32EE0
	|-List<Detail.AsyncResultInt>.CopyTo
	|
	|-RVA: 0x3E360D0 Offset: 0x3E361D1 VA: 0x3E360D0
	|-List<Detail.CppArray>.CopyTo
	|
	|-RVA: 0x3E391B0 Offset: 0x3E392B1 VA: 0x3E391B0
	|-List<Detail.NotificationEventInt>.CopyTo
	|
	|-RVA: 0x3E5B780 Offset: 0x3E5B881 VA: 0x3E5B780
	|-List<DragonRideTargetGroup.ChainParam>.CopyTo
	|
	|-RVA: 0x3E5E7E0 Offset: 0x3E5E8E1 VA: 0x3E5E7E0
	|-List<GmapPathAdjuster.TargetModel>.CopyTo
	|
	|-RVA: 0x3E619F0 Offset: 0x3E61AF1 VA: 0x3E619F0
	|-List<GmapSpotAdjuster.TargetModel>.CopyTo
	|
	|-RVA: 0x3E64C00 Offset: 0x3E64D01 VA: 0x3E64C00
	|-List<HubFastTravel.Location>.CopyTo
	|
	|-RVA: 0x3E67ED0 Offset: 0x3E67FD1 VA: 0x3E67ED0
	|-List<HubLensFlare.Flare>.CopyTo
	|
	|-RVA: 0x3E6B110 Offset: 0x3E6B211 VA: 0x3E6B110
	|-List<InventoryPoolItemMenuContent.KindBgNameClass>.CopyTo
	|
	|-RVA: 0x3E6DFC0 Offset: 0x3E6E0C1 VA: 0x3E6DFC0
	|-List<Map.Pos>.CopyTo
	|
	|-RVA: 0x3E70E20 Offset: 0x3E70F21 VA: 0x3E70E20
	|-List<MapImage.BackupTerrain>.CopyTo
	|
	|-RVA: 0x3E73CC0 Offset: 0x3E73DC1 VA: 0x3E73CC0
	|-List<MapImageRange.Pos>.CopyTo
	|
	|-RVA: 0x3E76D00 Offset: 0x3E76E01 VA: 0x3E76D00
	|-List<MapMind.Target>.CopyTo
	|
	|-RVA: 0x3D868F0 Offset: 0x3D869F1 VA: 0x3D868F0
	|-List<MapPanelDebug.Entity>.CopyTo
	|
	|-RVA: 0x3D89930 Offset: 0x3D89A31 VA: 0x3D89930
	|-List<NexRanking.Data>.CopyTo
	|
	|-RVA: 0x3D8C790 Offset: 0x3D8C891 VA: 0x3D8C790
	|-List<NexVersus.RatingData>.CopyTo
	|
	|-RVA: 0x3D8F690 Offset: 0x3D8F791 VA: 0x3D8F690
	|-List<PackedPlayModeBuildLogs.RuntimeBuildLog>.CopyTo
	|
	|-RVA: 0x3D92760 Offset: 0x3D92861 VA: 0x3D92760
	|-List<ParticleSystem.Particle>.CopyTo
	|
	|-RVA: 0x3D958F0 Offset: 0x3D959F1 VA: 0x3D958F0
	|-List<RangeData.Offset>.CopyTo
	|
	|-RVA: 0x3D988B0 Offset: 0x3D989B1 VA: 0x3D988B0
	|-List<RenderGraphDebugData.PassDebugData>.CopyTo
	|
	|-RVA: 0x3D9BB80 Offset: 0x3D9BC81 VA: 0x3D9BB80
	|-List<RenderGraphDebugData.ResourceDebugData>.CopyTo
	|
	|-RVA: 0x3D9ED60 Offset: 0x3D9EE61 VA: 0x3D9ED60
	|-List<RingCleaningUnitSelectMenu.GodParam>.CopyTo
	|
	|-RVA: 0x3DA1E60 Offset: 0x3DA1F61 VA: 0x3DA1E60
	|-List<ShadowUtility.Edge>.CopyTo
	|
	|-RVA: 0x3D14460 Offset: 0x3D14561 VA: 0x3D14460
	|-List<SkillArray.Entity>.CopyTo
	|
	|-RVA: 0x3D17560 Offset: 0x3D17661 VA: 0x3D17560
	|-List<TexturePacker_JsonArray.Frame>.CopyTo
	|
	|-RVA: 0x3D1A9F0 Offset: 0x3D1AAF1 VA: 0x3D1A9F0
	|-List<TimeNotificationBehaviour.NotificationEntry>.CopyTo
	|
	|-RVA: 0x3D1DC10 Offset: 0x3D1DD11 VA: 0x3D1DC10
	|-List<UnitySynchronizationContext.WorkRequest>.CopyTo
	|
	|-RVA: 0x3D20CE0 Offset: 0x3D20DE1 VA: 0x3D20CE0
	|-List<XmlSchemaObjectTable.XmlSchemaObjectEntry>.CopyTo
	|
	|-RVA: 0x3D23C00 Offset: 0x3D23D01 VA: 0x3D23C00
	|-List<AssetBundleBuildMap.AssetBundleEntry.AssetPathString>.CopyTo
	|
	|-RVA: 0x3D26CE0 Offset: 0x3D26DE1 VA: 0x3D26CE0
	|-List<Detail.DataStore.DataStoreChangeMetaParamInt>.CopyTo
	|
	|-RVA: 0x3D29F20 Offset: 0x3D2A021 VA: 0x3D29F20
	|-List<Detail.DataStore.DataStoreDeleteParamInt>.CopyTo
	|
	|-RVA: 0x3D2D000 Offset: 0x3D2D101 VA: 0x3D2D000
	|-List<Detail.DataStore.DataStoreGetMetaParamInt>.CopyTo
	|
	|-RVA: 0x3D30370 Offset: 0x3D30471 VA: 0x3D30370
	|-List<Detail.DataStore.DataStoreMetaInfoInt>.CopyTo
	|
	|-RVA: 0x3CF4B30 Offset: 0x3CF4C31 VA: 0x3CF4B30
	|-List<Detail.DataStore.DataStorePasswordInfoInt>.CopyTo
	|
	|-RVA: 0x3CF7D10 Offset: 0x3CF7E11 VA: 0x3CF7D10
	|-List<Detail.DataStore.DataStorePersistenceInfoInt>.CopyTo
	|
	|-RVA: 0x3CFAF70 Offset: 0x3CFB071 VA: 0x3CFAF70
	|-List<Detail.DataStore.DataStorePreparePostParamInt>.CopyTo
	|
	|-RVA: 0x3CFE150 Offset: 0x3CFE251 VA: 0x3CFE150
	|-List<Detail.DataStore.DataStoreRateObjectParamInt>.CopyTo
	|
	|-RVA: 0x3D01180 Offset: 0x3D01281 VA: 0x3D01180
	|-List<Detail.DataStore.DataStoreRatingInitParamInt>.CopyTo
	|
	|-RVA: 0x3D04220 Offset: 0x3D04321 VA: 0x3D04220
	|-List<Detail.DataStore.DataStoreRatingTargetInt>.CopyTo
	|
	|-RVA: 0x3D073A0 Offset: 0x3D074A1 VA: 0x3D073A0
	|-List<Detail.Ranking.RankingCachedResultInt>.CopyTo
	|
	|-RVA: 0x3D0A6E0 Offset: 0x3D0A7E1 VA: 0x3D0A6E0
	|-List<Detail.Ranking.RankingOrderParamInt>.CopyTo
	|
	|-RVA: 0x3D0D850 Offset: 0x3D0D951 VA: 0x3D0D850
	|-List<Detail.Ranking.RankingRankDataInt>.CopyTo
	|
	|-RVA: 0x3D10F60 Offset: 0x3D11061 VA: 0x3D10F60
	|-List<Detail.Ranking2.Ranking2ChartInfoInt>.CopyTo
	|
	|-RVA: 0x3D677D0 Offset: 0x3D678D1 VA: 0x3D677D0
	|-List<Detail.Ranking2.Ranking2RankDataInt>.CopyTo
	|
	|-RVA: 0x3D6AAC0 Offset: 0x3D6ABC1 VA: 0x3D6AAC0
	|-List<Detail.Ranking2.Ranking2ScoreDataInt>.CopyTo
	|
	|-RVA: 0x3D6DAF0 Offset: 0x3D6DBF1 VA: 0x3D6DAF0
	|-List<Detail.Screening.ScreeningContextInfoInt>.CopyTo
	|
	|-RVA: 0x3D70F10 Offset: 0x3D71011 VA: 0x3D70F10
	|-List<Detail.Subscriber.SubscriberContentInt>.CopyTo
	|
	|-RVA: 0x3D744B0 Offset: 0x3D745B1 VA: 0x3D744B0
	|-List<Detail.Subscriber.SubscriberGetContentParamInt>.CopyTo
	|
	|-RVA: 0x3D77740 Offset: 0x3D77841 VA: 0x3D77740
	|-List<Detail.Subscriber.SubscriberUserStatusInfoInt>.CopyTo
	|
	|-RVA: 0x3D7AA30 Offset: 0x3D7AB31 VA: 0x3D7AA30
	|-List<Detail.Subscriber.SubscriberUserStatusParamInt>.CopyTo
	|
	|-RVA: 0x3D7DA70 Offset: 0x3D7DB71 VA: 0x3D7DA70
	|-List<Detail.Utility.IntegerSettings>.CopyTo
	|
	|-RVA: 0x3D808D0 Offset: 0x3D809D1 VA: 0x3D808D0
	|-List<Detail.Utility.UniqueIdInfoInt>.CopyTo
	|
	|-RVA: 0x3D837E0 Offset: 0x3D838E1 VA: 0x3D837E0
	|-List<MapHistory.Rewind.LatestInspectorData>.CopyTo
	|
	|-RVA: 0x305FAA0 Offset: 0x305FBA1 VA: 0x305FAA0
	|-List<MapHistory.Rewind.WorkTerrainData>.CopyTo
	|
	|-RVA: 0x3062A80 Offset: 0x3062B81 VA: 0x3062A80
	|-List<MapSkill.AroundCalculator.Result>.CopyTo
	|
	|-RVA: 0x3065B80 Offset: 0x3065C81 VA: 0x3065B80
	|-List<TargetPositionCache.CacheCurve.Item>.CopyTo
	|
	|-RVA: 0x3068F40 Offset: 0x3069041 VA: 0x3068F40
	|-List<TargetPositionCache.CacheEntry.RecordingItem>.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 28
	private void System.Collections.ICollection.CopyTo(Array array, int arrayIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3B0B800 Offset: 0x3B0B901 VA: 0x3B0B800
	|-List<IntervalTree.Entry<object>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3B0E8D0 Offset: 0x3B0E9D1 VA: 0x3B0E8D0
	|-List<KeyValuePair<DateTime, object>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3B117F0 Offset: 0x3B118F1 VA: 0x3B117F0
	|-List<KeyValuePair<int, object>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3B14850 Offset: 0x3B14951 VA: 0x3B14850
	|-List<KeyValuePair<object, ValueTuple<int, DateTime, object>>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3B17930 Offset: 0x3B17A31 VA: 0x3B17930
	|-List<KeyValuePair<object, object>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3B1A990 Offset: 0x3B1AA91 VA: 0x3B1A990
	|-List<CommonBattleSequence.Reliance<object>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3B1DA60 Offset: 0x3B1DB61 VA: 0x3B1DA60
	|-List<RenderGraphResourcePool.ResourceLogInfo<object>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3B20980 Offset: 0x3B20A81 VA: 0x3B20980
	|-List<ValueTuple<int, object>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3DE15A0 Offset: 0x3DE16A1 VA: 0x3DE15A0
	|-List<ValueTuple<Int32Enum, int>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3DE4560 Offset: 0x3DE4661 VA: 0x3DE4560
	|-List<ValueTuple<object, ValueTuple<object, int>>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3DE7630 Offset: 0x3DE7731 VA: 0x3DE7630
	|-List<ValueTuple<object, int>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3DEA5E0 Offset: 0x3DEA6E1 VA: 0x3DEA5E0
	|-List<ValueTuple<Vector3, float>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3DED550 Offset: 0x3DED651 VA: 0x3DED550
	|-List<ValueTuple<object, Int32Enum, int>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3DF05B0 Offset: 0x3DF06B1 VA: 0x3DF05B0
	|-List<ValueTuple<object, int, int, int>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3DF3610 Offset: 0x3DF3711 VA: 0x3DF3610
	|-List<AnimatorClipInfo>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3DF65D0 Offset: 0x3DF66D1 VA: 0x3DF65D0
	|-List<AsyncOperationHandle>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3DF97D0 Offset: 0x3DF98D1 VA: 0x3DF97D0
	|-List<BoneWeight>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3DFC830 Offset: 0x3DFC931 VA: 0x3DFC830
	|-List<bool>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3E79D80 Offset: 0x3E79E81 VA: 0x3E79D80
	|-List<byte>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3E11690 Offset: 0x3E11791 VA: 0x3E11690
	|-List<Camera>.System.Collections.ICollection.CopyTo
	|-List<Decorator>.System.Collections.ICollection.CopyTo
	|-List<DynValue>.System.Collections.ICollection.CopyTo
	|-List<GameObject>.System.Collections.ICollection.CopyTo
	|-List<MapBackup>.System.Collections.ICollection.CopyTo
	|-List<object>.System.Collections.ICollection.CopyTo
	|-List<Phase>.System.Collections.ICollection.CopyTo
	|-List<ProfileCard>.System.Collections.ICollection.CopyTo
	|-List<Unit>.System.Collections.ICollection.CopyTo
	|-List<AssetTable.Accessory>.System.Collections.ICollection.CopyTo
	|-List<GameSaveDataHeaderReader.Handle>.System.Collections.ICollection.CopyTo
	|-List<MapDispos.ActualData>.System.Collections.ICollection.CopyTo
	|-List<MapDispos.Pos>.System.Collections.ICollection.CopyTo
	|-List<MapLayer.Data>.System.Collections.ICollection.CopyTo
	|-List<MapObject.RigidInfo>.System.Collections.ICollection.CopyTo
	|-List<RingListSequence.PageData>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3E7CC00 Offset: 0x3E7CD01 VA: 0x3E7CC00
	|-List<CameraInfo>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3E7FAB0 Offset: 0x3E7FBB1 VA: 0x3E7FAB0
	|-List<char>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3E829B0 Offset: 0x3E82AB1 VA: 0x3E829B0
	|-List<Color>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3E858B0 Offset: 0x3E859B1 VA: 0x3E858B0
	|-List<Color32>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3E88730 Offset: 0x3E88831 VA: 0x3E88730
	|-List<ConstraintSource>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3E8B790 Offset: 0x3E8B891 VA: 0x3E8B790
	|-List<ContourVertex>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3E8E990 Offset: 0x3E8EA91 VA: 0x3E8E990
	|-List<DataStoreRatingInfo>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3E919D0 Offset: 0x3E91AD1 VA: 0x3E919D0
	|-List<DataStoreResult>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3E947E0 Offset: 0x3E948E1 VA: 0x3E947E0
	|-List<DateTime>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3E97640 Offset: 0x3E97741 VA: 0x3E97640
	|-List<DateTimeOffset>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3E9A520 Offset: 0x3E9A621 VA: 0x3E9A520
	|-List<Decimal>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3E9D620 Offset: 0x3E9D721 VA: 0x3E9D620
	|-List<DiagnosticEvent>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3EA0800 Offset: 0x3EA0901 VA: 0x3EA0800
	|-List<double>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3EA3810 Offset: 0x3EA3911 VA: 0x3EA3810
	|-List<Friend>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3EA69F0 Offset: 0x3EA6AF1 VA: 0x3EA69F0
	|-List<GlyphRect>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3EA9880 Offset: 0x3EA9981 VA: 0x3EA9880
	|-List<short>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3EAC680 Offset: 0x3EAC781 VA: 0x3EAC680
	|-List<int>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3EAF480 Offset: 0x3EAF581 VA: 0x3EAF480
	|-List<Int32Enum>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3EB2280 Offset: 0x3EB2381 VA: 0x3EB2280
	|-List<long>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3DFF650 Offset: 0x3DFF751 VA: 0x3DFF650
	|-List<IntPtr>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3E024C0 Offset: 0x3E025C1 VA: 0x3E024C0
	|-List<InterpretedFrameInfo>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3E05510 Offset: 0x3E05611 VA: 0x3E05510
	|-List<IntervalTreeNode>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3E08550 Offset: 0x3E08651 VA: 0x3E08550
	|-List<LengthLimitProperties>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3E0B360 Offset: 0x3E0B461 VA: 0x3E0B360
	|-List<MapPos>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3E0E450 Offset: 0x3E0E551 VA: 0x3E0E450
	|-List<Matrix4x4>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3E14720 Offset: 0x3E14821 VA: 0x3E14720
	|-List<ObjectInitializationData>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3E17AA0 Offset: 0x3E17BA1 VA: 0x3E17AA0
	|-List<PlayableBinding>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3E1AD70 Offset: 0x3E1AE71 VA: 0x3E1AD70
	|-List<PlayerLoopSystem>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3DA5210 Offset: 0x3DA5311 VA: 0x3DA5210
	|-List<PlayerLoopSystemInternal>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3DA83F0 Offset: 0x3DA84F1 VA: 0x3DA83F0
	|-List<RangePositionInfo>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3DAB2A0 Offset: 0x3DAB3A1 VA: 0x3DAB2A0
	|-List<Ranking2ChartInfoInput>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3DAE340 Offset: 0x3DAE441 VA: 0x3DAE340
	|-List<RaycastHit2D>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3DB18B0 Offset: 0x3DB19B1 VA: 0x3DB18B0
	|-List<RaycastResult>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3DB4DE0 Offset: 0x3DB4EE1 VA: 0x3DB4DE0
	|-List<Rect>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3DB7CE0 Offset: 0x3DB7DE1 VA: 0x3DB7CE0
	|-List<RendererListHandle>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3DBAAF0 Offset: 0x3DBABF1 VA: 0x3DBAAF0
	|-List<ResourceHandle>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3DBD900 Offset: 0x3DBDA01 VA: 0x3DBD900
	|-List<sbyte>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3DC0710 Offset: 0x3DC0811 VA: 0x3DC0710
	|-List<ShaderTagId>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3E3C380 Offset: 0x3E3C481 VA: 0x3E3C380
	|-List<float>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3E3F760 Offset: 0x3E3F861 VA: 0x3E3F760
	|-List<SphericalHarmonicsL2>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3E430C0 Offset: 0x3E431C1 VA: 0x3E430C0
	|-List<SubMeshDescriptor>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3E462D0 Offset: 0x3E463D1 VA: 0x3E462D0
	|-List<TablePair>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3E49180 Offset: 0x3E49281 VA: 0x3E49180
	|-List<TimeSpan>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3E4C060 Offset: 0x3E4C161 VA: 0x3E4C060
	|-List<UICharInfo>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3E4EFC0 Offset: 0x3E4F0C1 VA: 0x3E4EFC0
	|-List<UILineInfo>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3E52420 Offset: 0x3E52521 VA: 0x3E52420
	|-List<UIVertex>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3E55B30 Offset: 0x3E55C31 VA: 0x3E55B30
	|-List<ushort>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3E58930 Offset: 0x3E58A31 VA: 0x3E58930
	|-List<uint>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3DC3520 Offset: 0x3DC3621 VA: 0x3DC3520
	|-List<ulong>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3DC6360 Offset: 0x3DC6461 VA: 0x3DC6360
	|-List<Vector2>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3DC92C0 Offset: 0x3DC93C1 VA: 0x3DC92C0
	|-List<Vector3>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3DCC2D0 Offset: 0x3DCC3D1 VA: 0x3DCC2D0
	|-List<Vector4>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3DCF220 Offset: 0x3DCF321 VA: 0x3DCF220
	|-List<VertexAttributeDescriptor>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3DD2120 Offset: 0x3DD2221 VA: 0x3DD2120
	|-List<X509ChainStatus>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3DD5200 Offset: 0x3DD5301 VA: 0x3DD5200
	|-List<XRView>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3DD8430 Offset: 0x3DD8531 VA: 0x3DD8430
	|-List<AmiiboSequence.GainItemData>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3DDB530 Offset: 0x3DDB631 VA: 0x3DDB530
	|-List<AnimationOutputWeightProcessor.WeightInfo>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3DDE6F0 Offset: 0x3DDE7F1 VA: 0x3DDE6F0
	|-List<ArenaOrderSequence.GodInfo>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3E1DF50 Offset: 0x3E1E051 VA: 0x3E1DF50
	|-List<BattleInfo.SupportData>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3E20E70 Offset: 0x3E20F71 VA: 0x3E20E70
	|-List<BeforeRenderHelper.OrderBlock>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3E23EE0 Offset: 0x3E23FE1 VA: 0x3E23EE0
	|-List<Camera.RenderRequest>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3E26FC0 Offset: 0x3E270C1 VA: 0x3E26FC0
	|-List<CameraState.CustomBlendable>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3E29E70 Offset: 0x3E29F71 VA: 0x3E29E70
	|-List<CinemachineClearShot.Pair>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3E2CC80 Offset: 0x3E2CD81 VA: 0x3E2CC80
	|-List<CinemachineStateDrivenCamera.HashPair>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3E2FC40 Offset: 0x3E2FD41 VA: 0x3E2FC40
	|-List<DelayedActionManager.DelegateInfo>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3E32F00 Offset: 0x3E33001 VA: 0x3E32F00
	|-List<Detail.AsyncResultInt>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3E360F0 Offset: 0x3E361F1 VA: 0x3E360F0
	|-List<Detail.CppArray>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3E391D0 Offset: 0x3E392D1 VA: 0x3E391D0
	|-List<Detail.NotificationEventInt>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3E5B7A0 Offset: 0x3E5B8A1 VA: 0x3E5B7A0
	|-List<DragonRideTargetGroup.ChainParam>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3E5E800 Offset: 0x3E5E901 VA: 0x3E5E800
	|-List<GmapPathAdjuster.TargetModel>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3E61A10 Offset: 0x3E61B11 VA: 0x3E61A10
	|-List<GmapSpotAdjuster.TargetModel>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3E64C20 Offset: 0x3E64D21 VA: 0x3E64C20
	|-List<HubFastTravel.Location>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3E67EF0 Offset: 0x3E67FF1 VA: 0x3E67EF0
	|-List<HubLensFlare.Flare>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3E6B130 Offset: 0x3E6B231 VA: 0x3E6B130
	|-List<InventoryPoolItemMenuContent.KindBgNameClass>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3E6DFE0 Offset: 0x3E6E0E1 VA: 0x3E6DFE0
	|-List<Map.Pos>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3E70E40 Offset: 0x3E70F41 VA: 0x3E70E40
	|-List<MapImage.BackupTerrain>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3E73CE0 Offset: 0x3E73DE1 VA: 0x3E73CE0
	|-List<MapImageRange.Pos>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3E76D20 Offset: 0x3E76E21 VA: 0x3E76D20
	|-List<MapMind.Target>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3D86910 Offset: 0x3D86A11 VA: 0x3D86910
	|-List<MapPanelDebug.Entity>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3D89950 Offset: 0x3D89A51 VA: 0x3D89950
	|-List<NexRanking.Data>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3D8C7B0 Offset: 0x3D8C8B1 VA: 0x3D8C7B0
	|-List<NexVersus.RatingData>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3D8F6B0 Offset: 0x3D8F7B1 VA: 0x3D8F6B0
	|-List<PackedPlayModeBuildLogs.RuntimeBuildLog>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3D92780 Offset: 0x3D92881 VA: 0x3D92780
	|-List<ParticleSystem.Particle>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3D95910 Offset: 0x3D95A11 VA: 0x3D95910
	|-List<RangeData.Offset>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3D988D0 Offset: 0x3D989D1 VA: 0x3D988D0
	|-List<RenderGraphDebugData.PassDebugData>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3D9BBA0 Offset: 0x3D9BCA1 VA: 0x3D9BBA0
	|-List<RenderGraphDebugData.ResourceDebugData>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3D9ED80 Offset: 0x3D9EE81 VA: 0x3D9ED80
	|-List<RingCleaningUnitSelectMenu.GodParam>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3DA1E80 Offset: 0x3DA1F81 VA: 0x3DA1E80
	|-List<ShadowUtility.Edge>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3D14480 Offset: 0x3D14581 VA: 0x3D14480
	|-List<SkillArray.Entity>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3D17580 Offset: 0x3D17681 VA: 0x3D17580
	|-List<TexturePacker_JsonArray.Frame>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3D1AA10 Offset: 0x3D1AB11 VA: 0x3D1AA10
	|-List<TimeNotificationBehaviour.NotificationEntry>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3D1DC30 Offset: 0x3D1DD31 VA: 0x3D1DC30
	|-List<UnitySynchronizationContext.WorkRequest>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3D20D00 Offset: 0x3D20E01 VA: 0x3D20D00
	|-List<XmlSchemaObjectTable.XmlSchemaObjectEntry>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3D23C20 Offset: 0x3D23D21 VA: 0x3D23C20
	|-List<AssetBundleBuildMap.AssetBundleEntry.AssetPathString>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3D26D00 Offset: 0x3D26E01 VA: 0x3D26D00
	|-List<Detail.DataStore.DataStoreChangeMetaParamInt>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3D29F40 Offset: 0x3D2A041 VA: 0x3D29F40
	|-List<Detail.DataStore.DataStoreDeleteParamInt>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3D2D020 Offset: 0x3D2D121 VA: 0x3D2D020
	|-List<Detail.DataStore.DataStoreGetMetaParamInt>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3D30390 Offset: 0x3D30491 VA: 0x3D30390
	|-List<Detail.DataStore.DataStoreMetaInfoInt>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3CF4B50 Offset: 0x3CF4C51 VA: 0x3CF4B50
	|-List<Detail.DataStore.DataStorePasswordInfoInt>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3CF7D30 Offset: 0x3CF7E31 VA: 0x3CF7D30
	|-List<Detail.DataStore.DataStorePersistenceInfoInt>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3CFAF90 Offset: 0x3CFB091 VA: 0x3CFAF90
	|-List<Detail.DataStore.DataStorePreparePostParamInt>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3CFE170 Offset: 0x3CFE271 VA: 0x3CFE170
	|-List<Detail.DataStore.DataStoreRateObjectParamInt>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3D011A0 Offset: 0x3D012A1 VA: 0x3D011A0
	|-List<Detail.DataStore.DataStoreRatingInitParamInt>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3D04240 Offset: 0x3D04341 VA: 0x3D04240
	|-List<Detail.DataStore.DataStoreRatingTargetInt>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3D073C0 Offset: 0x3D074C1 VA: 0x3D073C0
	|-List<Detail.Ranking.RankingCachedResultInt>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3D0A700 Offset: 0x3D0A801 VA: 0x3D0A700
	|-List<Detail.Ranking.RankingOrderParamInt>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3D0D870 Offset: 0x3D0D971 VA: 0x3D0D870
	|-List<Detail.Ranking.RankingRankDataInt>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3D10F80 Offset: 0x3D11081 VA: 0x3D10F80
	|-List<Detail.Ranking2.Ranking2ChartInfoInt>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3D677F0 Offset: 0x3D678F1 VA: 0x3D677F0
	|-List<Detail.Ranking2.Ranking2RankDataInt>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3D6AAE0 Offset: 0x3D6ABE1 VA: 0x3D6AAE0
	|-List<Detail.Ranking2.Ranking2ScoreDataInt>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3D6DB10 Offset: 0x3D6DC11 VA: 0x3D6DB10
	|-List<Detail.Screening.ScreeningContextInfoInt>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3D70F30 Offset: 0x3D71031 VA: 0x3D70F30
	|-List<Detail.Subscriber.SubscriberContentInt>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3D744D0 Offset: 0x3D745D1 VA: 0x3D744D0
	|-List<Detail.Subscriber.SubscriberGetContentParamInt>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3D77760 Offset: 0x3D77861 VA: 0x3D77760
	|-List<Detail.Subscriber.SubscriberUserStatusInfoInt>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3D7AA50 Offset: 0x3D7AB51 VA: 0x3D7AA50
	|-List<Detail.Subscriber.SubscriberUserStatusParamInt>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3D7DA90 Offset: 0x3D7DB91 VA: 0x3D7DA90
	|-List<Detail.Utility.IntegerSettings>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3D808F0 Offset: 0x3D809F1 VA: 0x3D808F0
	|-List<Detail.Utility.UniqueIdInfoInt>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3D83800 Offset: 0x3D83901 VA: 0x3D83800
	|-List<MapHistory.Rewind.LatestInspectorData>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x305FAC0 Offset: 0x305FBC1 VA: 0x305FAC0
	|-List<MapHistory.Rewind.WorkTerrainData>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3062AA0 Offset: 0x3062BA1 VA: 0x3062AA0
	|-List<MapSkill.AroundCalculator.Result>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3065BA0 Offset: 0x3065CA1 VA: 0x3065BA0
	|-List<TargetPositionCache.CacheCurve.Item>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3068F60 Offset: 0x3069061 VA: 0x3068F60
	|-List<TargetPositionCache.CacheEntry.RecordingItem>.System.Collections.ICollection.CopyTo
	*/

	// RVA: -1 Offset: -1
	public void CopyTo(int index, T[] array, int arrayIndex, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3B0B8F0 Offset: 0x3B0B9F1 VA: 0x3B0B8F0
	|-List<IntervalTree.Entry<object>>.CopyTo
	|
	|-RVA: 0x3B0E9C0 Offset: 0x3B0EAC1 VA: 0x3B0E9C0
	|-List<KeyValuePair<DateTime, object>>.CopyTo
	|
	|-RVA: 0x3B118E0 Offset: 0x3B119E1 VA: 0x3B118E0
	|-List<KeyValuePair<int, object>>.CopyTo
	|
	|-RVA: 0x3B14940 Offset: 0x3B14A41 VA: 0x3B14940
	|-List<KeyValuePair<object, ValueTuple<int, DateTime, object>>>.CopyTo
	|
	|-RVA: 0x3B17A20 Offset: 0x3B17B21 VA: 0x3B17A20
	|-List<KeyValuePair<object, object>>.CopyTo
	|
	|-RVA: 0x3B1AA80 Offset: 0x3B1AB81 VA: 0x3B1AA80
	|-List<CommonBattleSequence.Reliance<object>>.CopyTo
	|
	|-RVA: 0x3B1DB50 Offset: 0x3B1DC51 VA: 0x3B1DB50
	|-List<RenderGraphResourcePool.ResourceLogInfo<object>>.CopyTo
	|
	|-RVA: 0x3B20A70 Offset: 0x3B20B71 VA: 0x3B20A70
	|-List<ValueTuple<int, object>>.CopyTo
	|
	|-RVA: 0x3DE1690 Offset: 0x3DE1791 VA: 0x3DE1690
	|-List<ValueTuple<Int32Enum, int>>.CopyTo
	|
	|-RVA: 0x3DE4650 Offset: 0x3DE4751 VA: 0x3DE4650
	|-List<ValueTuple<object, ValueTuple<object, int>>>.CopyTo
	|
	|-RVA: 0x3DE7720 Offset: 0x3DE7821 VA: 0x3DE7720
	|-List<ValueTuple<object, int>>.CopyTo
	|
	|-RVA: 0x3DEA6D0 Offset: 0x3DEA7D1 VA: 0x3DEA6D0
	|-List<ValueTuple<Vector3, float>>.CopyTo
	|
	|-RVA: 0x3DED640 Offset: 0x3DED741 VA: 0x3DED640
	|-List<ValueTuple<object, Int32Enum, int>>.CopyTo
	|
	|-RVA: 0x3DF06A0 Offset: 0x3DF07A1 VA: 0x3DF06A0
	|-List<ValueTuple<object, int, int, int>>.CopyTo
	|
	|-RVA: 0x3DF3700 Offset: 0x3DF3801 VA: 0x3DF3700
	|-List<AnimatorClipInfo>.CopyTo
	|
	|-RVA: 0x3DF66C0 Offset: 0x3DF67C1 VA: 0x3DF66C0
	|-List<AsyncOperationHandle>.CopyTo
	|
	|-RVA: 0x3DF98C0 Offset: 0x3DF99C1 VA: 0x3DF98C0
	|-List<BoneWeight>.CopyTo
	|
	|-RVA: 0x3DFC920 Offset: 0x3DFCA21 VA: 0x3DFC920
	|-List<bool>.CopyTo
	|
	|-RVA: 0x3E79E70 Offset: 0x3E79F71 VA: 0x3E79E70
	|-List<byte>.CopyTo
	|
	|-RVA: 0x3E7CCF0 Offset: 0x3E7CDF1 VA: 0x3E7CCF0
	|-List<CameraInfo>.CopyTo
	|
	|-RVA: 0x3E7FBA0 Offset: 0x3E7FCA1 VA: 0x3E7FBA0
	|-List<char>.CopyTo
	|
	|-RVA: 0x3E82AA0 Offset: 0x3E82BA1 VA: 0x3E82AA0
	|-List<Color>.CopyTo
	|
	|-RVA: 0x3E859A0 Offset: 0x3E85AA1 VA: 0x3E859A0
	|-List<Color32>.CopyTo
	|
	|-RVA: 0x3E88820 Offset: 0x3E88921 VA: 0x3E88820
	|-List<ConstraintSource>.CopyTo
	|
	|-RVA: 0x3E8B880 Offset: 0x3E8B981 VA: 0x3E8B880
	|-List<ContourVertex>.CopyTo
	|
	|-RVA: 0x3E8EA80 Offset: 0x3E8EB81 VA: 0x3E8EA80
	|-List<DataStoreRatingInfo>.CopyTo
	|
	|-RVA: 0x3E91AC0 Offset: 0x3E91BC1 VA: 0x3E91AC0
	|-List<DataStoreResult>.CopyTo
	|
	|-RVA: 0x3E948D0 Offset: 0x3E949D1 VA: 0x3E948D0
	|-List<DateTime>.CopyTo
	|
	|-RVA: 0x3E97730 Offset: 0x3E97831 VA: 0x3E97730
	|-List<DateTimeOffset>.CopyTo
	|
	|-RVA: 0x3E9A610 Offset: 0x3E9A711 VA: 0x3E9A610
	|-List<Decimal>.CopyTo
	|
	|-RVA: 0x3E9D710 Offset: 0x3E9D811 VA: 0x3E9D710
	|-List<DiagnosticEvent>.CopyTo
	|
	|-RVA: 0x3EA08F0 Offset: 0x3EA09F1 VA: 0x3EA08F0
	|-List<double>.CopyTo
	|
	|-RVA: 0x3EA3900 Offset: 0x3EA3A01 VA: 0x3EA3900
	|-List<Friend>.CopyTo
	|
	|-RVA: 0x3EA6AE0 Offset: 0x3EA6BE1 VA: 0x3EA6AE0
	|-List<GlyphRect>.CopyTo
	|
	|-RVA: 0x3EA9970 Offset: 0x3EA9A71 VA: 0x3EA9970
	|-List<short>.CopyTo
	|
	|-RVA: 0x3EAC770 Offset: 0x3EAC871 VA: 0x3EAC770
	|-List<int>.CopyTo
	|
	|-RVA: 0x3EAF570 Offset: 0x3EAF671 VA: 0x3EAF570
	|-List<Int32Enum>.CopyTo
	|
	|-RVA: 0x3EB2370 Offset: 0x3EB2471 VA: 0x3EB2370
	|-List<long>.CopyTo
	|
	|-RVA: 0x3DFF740 Offset: 0x3DFF841 VA: 0x3DFF740
	|-List<IntPtr>.CopyTo
	|
	|-RVA: 0x3E025B0 Offset: 0x3E026B1 VA: 0x3E025B0
	|-List<InterpretedFrameInfo>.CopyTo
	|
	|-RVA: 0x3E05600 Offset: 0x3E05701 VA: 0x3E05600
	|-List<IntervalTreeNode>.CopyTo
	|
	|-RVA: 0x3E08640 Offset: 0x3E08741 VA: 0x3E08640
	|-List<LengthLimitProperties>.CopyTo
	|
	|-RVA: 0x3E0B450 Offset: 0x3E0B551 VA: 0x3E0B450
	|-List<MapPos>.CopyTo
	|
	|-RVA: 0x3E0E540 Offset: 0x3E0E641 VA: 0x3E0E540
	|-List<Matrix4x4>.CopyTo
	|
	|-RVA: 0x3E11780 Offset: 0x3E11881 VA: 0x3E11780
	|-List<object>.CopyTo
	|-List<string>.CopyTo
	|
	|-RVA: 0x3E14810 Offset: 0x3E14911 VA: 0x3E14810
	|-List<ObjectInitializationData>.CopyTo
	|
	|-RVA: 0x3E17B90 Offset: 0x3E17C91 VA: 0x3E17B90
	|-List<PlayableBinding>.CopyTo
	|
	|-RVA: 0x3E1AE60 Offset: 0x3E1AF61 VA: 0x3E1AE60
	|-List<PlayerLoopSystem>.CopyTo
	|
	|-RVA: 0x3DA5300 Offset: 0x3DA5401 VA: 0x3DA5300
	|-List<PlayerLoopSystemInternal>.CopyTo
	|
	|-RVA: 0x3DA84E0 Offset: 0x3DA85E1 VA: 0x3DA84E0
	|-List<RangePositionInfo>.CopyTo
	|
	|-RVA: 0x3DAB390 Offset: 0x3DAB491 VA: 0x3DAB390
	|-List<Ranking2ChartInfoInput>.CopyTo
	|
	|-RVA: 0x3DAE430 Offset: 0x3DAE531 VA: 0x3DAE430
	|-List<RaycastHit2D>.CopyTo
	|
	|-RVA: 0x3DB19A0 Offset: 0x3DB1AA1 VA: 0x3DB19A0
	|-List<RaycastResult>.CopyTo
	|
	|-RVA: 0x3DB4ED0 Offset: 0x3DB4FD1 VA: 0x3DB4ED0
	|-List<Rect>.CopyTo
	|
	|-RVA: 0x3DB7DD0 Offset: 0x3DB7ED1 VA: 0x3DB7DD0
	|-List<RendererListHandle>.CopyTo
	|
	|-RVA: 0x3DBABE0 Offset: 0x3DBACE1 VA: 0x3DBABE0
	|-List<ResourceHandle>.CopyTo
	|
	|-RVA: 0x3DBD9F0 Offset: 0x3DBDAF1 VA: 0x3DBD9F0
	|-List<sbyte>.CopyTo
	|
	|-RVA: 0x3DC0800 Offset: 0x3DC0901 VA: 0x3DC0800
	|-List<ShaderTagId>.CopyTo
	|
	|-RVA: 0x3E3C470 Offset: 0x3E3C571 VA: 0x3E3C470
	|-List<float>.CopyTo
	|
	|-RVA: 0x3E3F850 Offset: 0x3E3F951 VA: 0x3E3F850
	|-List<SphericalHarmonicsL2>.CopyTo
	|
	|-RVA: 0x3E431B0 Offset: 0x3E432B1 VA: 0x3E431B0
	|-List<SubMeshDescriptor>.CopyTo
	|
	|-RVA: 0x3E463C0 Offset: 0x3E464C1 VA: 0x3E463C0
	|-List<TablePair>.CopyTo
	|
	|-RVA: 0x3E49270 Offset: 0x3E49371 VA: 0x3E49270
	|-List<TimeSpan>.CopyTo
	|
	|-RVA: 0x3E4C150 Offset: 0x3E4C251 VA: 0x3E4C150
	|-List<UICharInfo>.CopyTo
	|
	|-RVA: 0x3E4F0B0 Offset: 0x3E4F1B1 VA: 0x3E4F0B0
	|-List<UILineInfo>.CopyTo
	|
	|-RVA: 0x3E52510 Offset: 0x3E52611 VA: 0x3E52510
	|-List<UIVertex>.CopyTo
	|
	|-RVA: 0x3E55C20 Offset: 0x3E55D21 VA: 0x3E55C20
	|-List<ushort>.CopyTo
	|
	|-RVA: 0x3E58A20 Offset: 0x3E58B21 VA: 0x3E58A20
	|-List<uint>.CopyTo
	|
	|-RVA: 0x3DC3610 Offset: 0x3DC3711 VA: 0x3DC3610
	|-List<ulong>.CopyTo
	|
	|-RVA: 0x3DC6450 Offset: 0x3DC6551 VA: 0x3DC6450
	|-List<Vector2>.CopyTo
	|
	|-RVA: 0x3DC93B0 Offset: 0x3DC94B1 VA: 0x3DC93B0
	|-List<Vector3>.CopyTo
	|
	|-RVA: 0x3DCC3C0 Offset: 0x3DCC4C1 VA: 0x3DCC3C0
	|-List<Vector4>.CopyTo
	|
	|-RVA: 0x3DCF310 Offset: 0x3DCF411 VA: 0x3DCF310
	|-List<VertexAttributeDescriptor>.CopyTo
	|
	|-RVA: 0x3DD2210 Offset: 0x3DD2311 VA: 0x3DD2210
	|-List<X509ChainStatus>.CopyTo
	|
	|-RVA: 0x3DD52F0 Offset: 0x3DD53F1 VA: 0x3DD52F0
	|-List<XRView>.CopyTo
	|
	|-RVA: 0x3DD8520 Offset: 0x3DD8621 VA: 0x3DD8520
	|-List<AmiiboSequence.GainItemData>.CopyTo
	|
	|-RVA: 0x3DDB620 Offset: 0x3DDB721 VA: 0x3DDB620
	|-List<AnimationOutputWeightProcessor.WeightInfo>.CopyTo
	|
	|-RVA: 0x3DDE7E0 Offset: 0x3DDE8E1 VA: 0x3DDE7E0
	|-List<ArenaOrderSequence.GodInfo>.CopyTo
	|
	|-RVA: 0x3E1E040 Offset: 0x3E1E141 VA: 0x3E1E040
	|-List<BattleInfo.SupportData>.CopyTo
	|
	|-RVA: 0x3E20F60 Offset: 0x3E21061 VA: 0x3E20F60
	|-List<BeforeRenderHelper.OrderBlock>.CopyTo
	|
	|-RVA: 0x3E23FD0 Offset: 0x3E240D1 VA: 0x3E23FD0
	|-List<Camera.RenderRequest>.CopyTo
	|
	|-RVA: 0x3E270B0 Offset: 0x3E271B1 VA: 0x3E270B0
	|-List<CameraState.CustomBlendable>.CopyTo
	|
	|-RVA: 0x3E29F60 Offset: 0x3E2A061 VA: 0x3E29F60
	|-List<CinemachineClearShot.Pair>.CopyTo
	|
	|-RVA: 0x3E2CD70 Offset: 0x3E2CE71 VA: 0x3E2CD70
	|-List<CinemachineStateDrivenCamera.HashPair>.CopyTo
	|
	|-RVA: 0x3E2FD30 Offset: 0x3E2FE31 VA: 0x3E2FD30
	|-List<DelayedActionManager.DelegateInfo>.CopyTo
	|
	|-RVA: 0x3E32FF0 Offset: 0x3E330F1 VA: 0x3E32FF0
	|-List<Detail.AsyncResultInt>.CopyTo
	|
	|-RVA: 0x3E361E0 Offset: 0x3E362E1 VA: 0x3E361E0
	|-List<Detail.CppArray>.CopyTo
	|
	|-RVA: 0x3E392C0 Offset: 0x3E393C1 VA: 0x3E392C0
	|-List<Detail.NotificationEventInt>.CopyTo
	|
	|-RVA: 0x3E5B890 Offset: 0x3E5B991 VA: 0x3E5B890
	|-List<DragonRideTargetGroup.ChainParam>.CopyTo
	|
	|-RVA: 0x3E5E8F0 Offset: 0x3E5E9F1 VA: 0x3E5E8F0
	|-List<GmapPathAdjuster.TargetModel>.CopyTo
	|
	|-RVA: 0x3E61B00 Offset: 0x3E61C01 VA: 0x3E61B00
	|-List<GmapSpotAdjuster.TargetModel>.CopyTo
	|
	|-RVA: 0x3E64D10 Offset: 0x3E64E11 VA: 0x3E64D10
	|-List<HubFastTravel.Location>.CopyTo
	|
	|-RVA: 0x3E67FE0 Offset: 0x3E680E1 VA: 0x3E67FE0
	|-List<HubLensFlare.Flare>.CopyTo
	|
	|-RVA: 0x3E6B220 Offset: 0x3E6B321 VA: 0x3E6B220
	|-List<InventoryPoolItemMenuContent.KindBgNameClass>.CopyTo
	|
	|-RVA: 0x3E6E0D0 Offset: 0x3E6E1D1 VA: 0x3E6E0D0
	|-List<Map.Pos>.CopyTo
	|
	|-RVA: 0x3E70F30 Offset: 0x3E71031 VA: 0x3E70F30
	|-List<MapImage.BackupTerrain>.CopyTo
	|
	|-RVA: 0x3E73DD0 Offset: 0x3E73ED1 VA: 0x3E73DD0
	|-List<MapImageRange.Pos>.CopyTo
	|
	|-RVA: 0x3E76E10 Offset: 0x3E76F11 VA: 0x3E76E10
	|-List<MapMind.Target>.CopyTo
	|
	|-RVA: 0x3D86A00 Offset: 0x3D86B01 VA: 0x3D86A00
	|-List<MapPanelDebug.Entity>.CopyTo
	|
	|-RVA: 0x3D89A40 Offset: 0x3D89B41 VA: 0x3D89A40
	|-List<NexRanking.Data>.CopyTo
	|
	|-RVA: 0x3D8C8A0 Offset: 0x3D8C9A1 VA: 0x3D8C8A0
	|-List<NexVersus.RatingData>.CopyTo
	|
	|-RVA: 0x3D8F7A0 Offset: 0x3D8F8A1 VA: 0x3D8F7A0
	|-List<PackedPlayModeBuildLogs.RuntimeBuildLog>.CopyTo
	|
	|-RVA: 0x3D92870 Offset: 0x3D92971 VA: 0x3D92870
	|-List<ParticleSystem.Particle>.CopyTo
	|
	|-RVA: 0x3D95A00 Offset: 0x3D95B01 VA: 0x3D95A00
	|-List<RangeData.Offset>.CopyTo
	|
	|-RVA: 0x3D989C0 Offset: 0x3D98AC1 VA: 0x3D989C0
	|-List<RenderGraphDebugData.PassDebugData>.CopyTo
	|
	|-RVA: 0x3D9BC90 Offset: 0x3D9BD91 VA: 0x3D9BC90
	|-List<RenderGraphDebugData.ResourceDebugData>.CopyTo
	|
	|-RVA: 0x3D9EE70 Offset: 0x3D9EF71 VA: 0x3D9EE70
	|-List<RingCleaningUnitSelectMenu.GodParam>.CopyTo
	|
	|-RVA: 0x3DA1F70 Offset: 0x3DA2071 VA: 0x3DA1F70
	|-List<ShadowUtility.Edge>.CopyTo
	|
	|-RVA: 0x3D14570 Offset: 0x3D14671 VA: 0x3D14570
	|-List<SkillArray.Entity>.CopyTo
	|
	|-RVA: 0x3D17670 Offset: 0x3D17771 VA: 0x3D17670
	|-List<TexturePacker_JsonArray.Frame>.CopyTo
	|
	|-RVA: 0x3D1AB00 Offset: 0x3D1AC01 VA: 0x3D1AB00
	|-List<TimeNotificationBehaviour.NotificationEntry>.CopyTo
	|
	|-RVA: 0x3D1DD20 Offset: 0x3D1DE21 VA: 0x3D1DD20
	|-List<UnitySynchronizationContext.WorkRequest>.CopyTo
	|
	|-RVA: 0x3D20DF0 Offset: 0x3D20EF1 VA: 0x3D20DF0
	|-List<XmlSchemaObjectTable.XmlSchemaObjectEntry>.CopyTo
	|
	|-RVA: 0x3D23D10 Offset: 0x3D23E11 VA: 0x3D23D10
	|-List<AssetBundleBuildMap.AssetBundleEntry.AssetPathString>.CopyTo
	|
	|-RVA: 0x3D26DF0 Offset: 0x3D26EF1 VA: 0x3D26DF0
	|-List<Detail.DataStore.DataStoreChangeMetaParamInt>.CopyTo
	|
	|-RVA: 0x3D2A030 Offset: 0x3D2A131 VA: 0x3D2A030
	|-List<Detail.DataStore.DataStoreDeleteParamInt>.CopyTo
	|
	|-RVA: 0x3D2D110 Offset: 0x3D2D211 VA: 0x3D2D110
	|-List<Detail.DataStore.DataStoreGetMetaParamInt>.CopyTo
	|
	|-RVA: 0x3D30480 Offset: 0x3D30581 VA: 0x3D30480
	|-List<Detail.DataStore.DataStoreMetaInfoInt>.CopyTo
	|
	|-RVA: 0x3CF4C40 Offset: 0x3CF4D41 VA: 0x3CF4C40
	|-List<Detail.DataStore.DataStorePasswordInfoInt>.CopyTo
	|
	|-RVA: 0x3CF7E20 Offset: 0x3CF7F21 VA: 0x3CF7E20
	|-List<Detail.DataStore.DataStorePersistenceInfoInt>.CopyTo
	|
	|-RVA: 0x3CFB080 Offset: 0x3CFB181 VA: 0x3CFB080
	|-List<Detail.DataStore.DataStorePreparePostParamInt>.CopyTo
	|
	|-RVA: 0x3CFE260 Offset: 0x3CFE361 VA: 0x3CFE260
	|-List<Detail.DataStore.DataStoreRateObjectParamInt>.CopyTo
	|
	|-RVA: 0x3D01290 Offset: 0x3D01391 VA: 0x3D01290
	|-List<Detail.DataStore.DataStoreRatingInitParamInt>.CopyTo
	|
	|-RVA: 0x3D04330 Offset: 0x3D04431 VA: 0x3D04330
	|-List<Detail.DataStore.DataStoreRatingTargetInt>.CopyTo
	|
	|-RVA: 0x3D074B0 Offset: 0x3D075B1 VA: 0x3D074B0
	|-List<Detail.Ranking.RankingCachedResultInt>.CopyTo
	|
	|-RVA: 0x3D0A7F0 Offset: 0x3D0A8F1 VA: 0x3D0A7F0
	|-List<Detail.Ranking.RankingOrderParamInt>.CopyTo
	|
	|-RVA: 0x3D0D960 Offset: 0x3D0DA61 VA: 0x3D0D960
	|-List<Detail.Ranking.RankingRankDataInt>.CopyTo
	|
	|-RVA: 0x3D11070 Offset: 0x3D11171 VA: 0x3D11070
	|-List<Detail.Ranking2.Ranking2ChartInfoInt>.CopyTo
	|
	|-RVA: 0x3D678E0 Offset: 0x3D679E1 VA: 0x3D678E0
	|-List<Detail.Ranking2.Ranking2RankDataInt>.CopyTo
	|
	|-RVA: 0x3D6ABD0 Offset: 0x3D6ACD1 VA: 0x3D6ABD0
	|-List<Detail.Ranking2.Ranking2ScoreDataInt>.CopyTo
	|
	|-RVA: 0x3D6DC00 Offset: 0x3D6DD01 VA: 0x3D6DC00
	|-List<Detail.Screening.ScreeningContextInfoInt>.CopyTo
	|
	|-RVA: 0x3D71020 Offset: 0x3D71121 VA: 0x3D71020
	|-List<Detail.Subscriber.SubscriberContentInt>.CopyTo
	|
	|-RVA: 0x3D745C0 Offset: 0x3D746C1 VA: 0x3D745C0
	|-List<Detail.Subscriber.SubscriberGetContentParamInt>.CopyTo
	|
	|-RVA: 0x3D77850 Offset: 0x3D77951 VA: 0x3D77850
	|-List<Detail.Subscriber.SubscriberUserStatusInfoInt>.CopyTo
	|
	|-RVA: 0x3D7AB40 Offset: 0x3D7AC41 VA: 0x3D7AB40
	|-List<Detail.Subscriber.SubscriberUserStatusParamInt>.CopyTo
	|
	|-RVA: 0x3D7DB80 Offset: 0x3D7DC81 VA: 0x3D7DB80
	|-List<Detail.Utility.IntegerSettings>.CopyTo
	|
	|-RVA: 0x3D809E0 Offset: 0x3D80AE1 VA: 0x3D809E0
	|-List<Detail.Utility.UniqueIdInfoInt>.CopyTo
	|
	|-RVA: 0x3D838F0 Offset: 0x3D839F1 VA: 0x3D838F0
	|-List<MapHistory.Rewind.LatestInspectorData>.CopyTo
	|
	|-RVA: 0x305FBB0 Offset: 0x305FCB1 VA: 0x305FBB0
	|-List<MapHistory.Rewind.WorkTerrainData>.CopyTo
	|
	|-RVA: 0x3062B90 Offset: 0x3062C91 VA: 0x3062B90
	|-List<MapSkill.AroundCalculator.Result>.CopyTo
	|
	|-RVA: 0x3065C90 Offset: 0x3065D91 VA: 0x3065C90
	|-List<TargetPositionCache.CacheCurve.Item>.CopyTo
	|
	|-RVA: 0x3069050 Offset: 0x3069151 VA: 0x3069050
	|-List<TargetPositionCache.CacheEntry.RecordingItem>.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public void CopyTo(T[] array, int arrayIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3B0B960 Offset: 0x3B0BA61 VA: 0x3B0B960
	|-List<IntervalTree.Entry<object>>.CopyTo
	|
	|-RVA: 0x3B0EA30 Offset: 0x3B0EB31 VA: 0x3B0EA30
	|-List<KeyValuePair<DateTime, object>>.CopyTo
	|
	|-RVA: 0x3B11950 Offset: 0x3B11A51 VA: 0x3B11950
	|-List<KeyValuePair<int, object>>.CopyTo
	|
	|-RVA: 0x3B149B0 Offset: 0x3B14AB1 VA: 0x3B149B0
	|-List<KeyValuePair<object, ValueTuple<int, DateTime, object>>>.CopyTo
	|
	|-RVA: 0x3B17A90 Offset: 0x3B17B91 VA: 0x3B17A90
	|-List<KeyValuePair<object, object>>.CopyTo
	|
	|-RVA: 0x3B1AAF0 Offset: 0x3B1ABF1 VA: 0x3B1AAF0
	|-List<CommonBattleSequence.Reliance<object>>.CopyTo
	|
	|-RVA: 0x3B1DBC0 Offset: 0x3B1DCC1 VA: 0x3B1DBC0
	|-List<RenderGraphResourcePool.ResourceLogInfo<object>>.CopyTo
	|
	|-RVA: 0x3B20AE0 Offset: 0x3B20BE1 VA: 0x3B20AE0
	|-List<ValueTuple<int, object>>.CopyTo
	|
	|-RVA: 0x3DE1700 Offset: 0x3DE1801 VA: 0x3DE1700
	|-List<ValueTuple<Int32Enum, int>>.CopyTo
	|
	|-RVA: 0x3DE46C0 Offset: 0x3DE47C1 VA: 0x3DE46C0
	|-List<ValueTuple<object, ValueTuple<object, int>>>.CopyTo
	|
	|-RVA: 0x3DE7790 Offset: 0x3DE7891 VA: 0x3DE7790
	|-List<ValueTuple<object, int>>.CopyTo
	|
	|-RVA: 0x3DEA740 Offset: 0x3DEA841 VA: 0x3DEA740
	|-List<ValueTuple<Vector3, float>>.CopyTo
	|
	|-RVA: 0x3DED6B0 Offset: 0x3DED7B1 VA: 0x3DED6B0
	|-List<ValueTuple<object, Int32Enum, int>>.CopyTo
	|
	|-RVA: 0x3DF0710 Offset: 0x3DF0811 VA: 0x3DF0710
	|-List<ValueTuple<object, int, int, int>>.CopyTo
	|
	|-RVA: 0x3DF3770 Offset: 0x3DF3871 VA: 0x3DF3770
	|-List<AnimatorClipInfo>.CopyTo
	|
	|-RVA: 0x3DF6730 Offset: 0x3DF6831 VA: 0x3DF6730
	|-List<AsyncOperationHandle>.CopyTo
	|
	|-RVA: 0x3DF9930 Offset: 0x3DF9A31 VA: 0x3DF9930
	|-List<BoneWeight>.CopyTo
	|
	|-RVA: 0x3DFC990 Offset: 0x3DFCA91 VA: 0x3DFC990
	|-List<bool>.CopyTo
	|
	|-RVA: 0x3E79EE0 Offset: 0x3E79FE1 VA: 0x3E79EE0
	|-List<byte>.CopyTo
	|
	|-RVA: 0x3E117F0 Offset: 0x3E118F1 VA: 0x3E117F0
	|-List<Camera>.CopyTo
	|-List<Decorator>.CopyTo
	|-List<DynValue>.CopyTo
	|-List<GameObject>.CopyTo
	|-List<MapBackup>.CopyTo
	|-List<object>.CopyTo
	|-List<Phase>.CopyTo
	|-List<ProfileCard>.CopyTo
	|-List<Unit>.CopyTo
	|-List<AssetTable.Accessory>.CopyTo
	|-List<GameSaveDataHeaderReader.Handle>.CopyTo
	|-List<MapDispos.ActualData>.CopyTo
	|-List<MapDispos.Pos>.CopyTo
	|-List<MapLayer.Data>.CopyTo
	|-List<MapObject.RigidInfo>.CopyTo
	|-List<RingListSequence.PageData>.CopyTo
	|
	|-RVA: 0x3E7CD60 Offset: 0x3E7CE61 VA: 0x3E7CD60
	|-List<CameraInfo>.CopyTo
	|
	|-RVA: 0x3E7FC10 Offset: 0x3E7FD11 VA: 0x3E7FC10
	|-List<char>.CopyTo
	|
	|-RVA: 0x3E82B10 Offset: 0x3E82C11 VA: 0x3E82B10
	|-List<Color>.CopyTo
	|
	|-RVA: 0x3E85A10 Offset: 0x3E85B11 VA: 0x3E85A10
	|-List<Color32>.CopyTo
	|
	|-RVA: 0x3E88890 Offset: 0x3E88991 VA: 0x3E88890
	|-List<ConstraintSource>.CopyTo
	|
	|-RVA: 0x3E8B8F0 Offset: 0x3E8B9F1 VA: 0x3E8B8F0
	|-List<ContourVertex>.CopyTo
	|
	|-RVA: 0x3E8EAF0 Offset: 0x3E8EBF1 VA: 0x3E8EAF0
	|-List<DataStoreRatingInfo>.CopyTo
	|
	|-RVA: 0x3E91B30 Offset: 0x3E91C31 VA: 0x3E91B30
	|-List<DataStoreResult>.CopyTo
	|
	|-RVA: 0x3E94940 Offset: 0x3E94A41 VA: 0x3E94940
	|-List<DateTime>.CopyTo
	|
	|-RVA: 0x3E977A0 Offset: 0x3E978A1 VA: 0x3E977A0
	|-List<DateTimeOffset>.CopyTo
	|
	|-RVA: 0x3E9A680 Offset: 0x3E9A781 VA: 0x3E9A680
	|-List<Decimal>.CopyTo
	|
	|-RVA: 0x3E9D780 Offset: 0x3E9D881 VA: 0x3E9D780
	|-List<DiagnosticEvent>.CopyTo
	|
	|-RVA: 0x3EA0960 Offset: 0x3EA0A61 VA: 0x3EA0960
	|-List<double>.CopyTo
	|
	|-RVA: 0x3EA3970 Offset: 0x3EA3A71 VA: 0x3EA3970
	|-List<Friend>.CopyTo
	|
	|-RVA: 0x3EA6B50 Offset: 0x3EA6C51 VA: 0x3EA6B50
	|-List<GlyphRect>.CopyTo
	|
	|-RVA: 0x3EA99E0 Offset: 0x3EA9AE1 VA: 0x3EA99E0
	|-List<short>.CopyTo
	|
	|-RVA: 0x3EAC7E0 Offset: 0x3EAC8E1 VA: 0x3EAC7E0
	|-List<int>.CopyTo
	|
	|-RVA: 0x3EAF5E0 Offset: 0x3EAF6E1 VA: 0x3EAF5E0
	|-List<Int32Enum>.CopyTo
	|
	|-RVA: 0x3EB23E0 Offset: 0x3EB24E1 VA: 0x3EB23E0
	|-List<long>.CopyTo
	|
	|-RVA: 0x3DFF7B0 Offset: 0x3DFF8B1 VA: 0x3DFF7B0
	|-List<IntPtr>.CopyTo
	|
	|-RVA: 0x3E02620 Offset: 0x3E02721 VA: 0x3E02620
	|-List<InterpretedFrameInfo>.CopyTo
	|
	|-RVA: 0x3E05670 Offset: 0x3E05771 VA: 0x3E05670
	|-List<IntervalTreeNode>.CopyTo
	|
	|-RVA: 0x3E086B0 Offset: 0x3E087B1 VA: 0x3E086B0
	|-List<LengthLimitProperties>.CopyTo
	|
	|-RVA: 0x3E0B4C0 Offset: 0x3E0B5C1 VA: 0x3E0B4C0
	|-List<MapPos>.CopyTo
	|
	|-RVA: 0x3E0E5B0 Offset: 0x3E0E6B1 VA: 0x3E0E5B0
	|-List<Matrix4x4>.CopyTo
	|
	|-RVA: 0x3E14880 Offset: 0x3E14981 VA: 0x3E14880
	|-List<ObjectInitializationData>.CopyTo
	|
	|-RVA: 0x3E17C00 Offset: 0x3E17D01 VA: 0x3E17C00
	|-List<PlayableBinding>.CopyTo
	|
	|-RVA: 0x3E1AED0 Offset: 0x3E1AFD1 VA: 0x3E1AED0
	|-List<PlayerLoopSystem>.CopyTo
	|
	|-RVA: 0x3DA5370 Offset: 0x3DA5471 VA: 0x3DA5370
	|-List<PlayerLoopSystemInternal>.CopyTo
	|
	|-RVA: 0x3DA8550 Offset: 0x3DA8651 VA: 0x3DA8550
	|-List<RangePositionInfo>.CopyTo
	|
	|-RVA: 0x3DAB400 Offset: 0x3DAB501 VA: 0x3DAB400
	|-List<Ranking2ChartInfoInput>.CopyTo
	|
	|-RVA: 0x3DAE4A0 Offset: 0x3DAE5A1 VA: 0x3DAE4A0
	|-List<RaycastHit2D>.CopyTo
	|
	|-RVA: 0x3DB1A10 Offset: 0x3DB1B11 VA: 0x3DB1A10
	|-List<RaycastResult>.CopyTo
	|
	|-RVA: 0x3DB4F40 Offset: 0x3DB5041 VA: 0x3DB4F40
	|-List<Rect>.CopyTo
	|
	|-RVA: 0x3DB7E40 Offset: 0x3DB7F41 VA: 0x3DB7E40
	|-List<RendererListHandle>.CopyTo
	|
	|-RVA: 0x3DBAC50 Offset: 0x3DBAD51 VA: 0x3DBAC50
	|-List<ResourceHandle>.CopyTo
	|
	|-RVA: 0x3DBDA60 Offset: 0x3DBDB61 VA: 0x3DBDA60
	|-List<sbyte>.CopyTo
	|
	|-RVA: 0x3DC0870 Offset: 0x3DC0971 VA: 0x3DC0870
	|-List<ShaderTagId>.CopyTo
	|
	|-RVA: 0x3E3C4E0 Offset: 0x3E3C5E1 VA: 0x3E3C4E0
	|-List<float>.CopyTo
	|
	|-RVA: 0x3E3F8C0 Offset: 0x3E3F9C1 VA: 0x3E3F8C0
	|-List<SphericalHarmonicsL2>.CopyTo
	|
	|-RVA: 0x3E43220 Offset: 0x3E43321 VA: 0x3E43220
	|-List<SubMeshDescriptor>.CopyTo
	|
	|-RVA: 0x3E46430 Offset: 0x3E46531 VA: 0x3E46430
	|-List<TablePair>.CopyTo
	|
	|-RVA: 0x3E492E0 Offset: 0x3E493E1 VA: 0x3E492E0
	|-List<TimeSpan>.CopyTo
	|
	|-RVA: 0x3E4C1C0 Offset: 0x3E4C2C1 VA: 0x3E4C1C0
	|-List<UICharInfo>.CopyTo
	|
	|-RVA: 0x3E4F120 Offset: 0x3E4F221 VA: 0x3E4F120
	|-List<UILineInfo>.CopyTo
	|
	|-RVA: 0x3E52580 Offset: 0x3E52681 VA: 0x3E52580
	|-List<UIVertex>.CopyTo
	|
	|-RVA: 0x3E55C90 Offset: 0x3E55D91 VA: 0x3E55C90
	|-List<ushort>.CopyTo
	|
	|-RVA: 0x3E58A90 Offset: 0x3E58B91 VA: 0x3E58A90
	|-List<uint>.CopyTo
	|
	|-RVA: 0x3DC3680 Offset: 0x3DC3781 VA: 0x3DC3680
	|-List<ulong>.CopyTo
	|
	|-RVA: 0x3DC64C0 Offset: 0x3DC65C1 VA: 0x3DC64C0
	|-List<Vector2>.CopyTo
	|
	|-RVA: 0x3DC9420 Offset: 0x3DC9521 VA: 0x3DC9420
	|-List<Vector3>.CopyTo
	|
	|-RVA: 0x3DCC430 Offset: 0x3DCC531 VA: 0x3DCC430
	|-List<Vector4>.CopyTo
	|
	|-RVA: 0x3DCF380 Offset: 0x3DCF481 VA: 0x3DCF380
	|-List<VertexAttributeDescriptor>.CopyTo
	|
	|-RVA: 0x3DD2280 Offset: 0x3DD2381 VA: 0x3DD2280
	|-List<X509ChainStatus>.CopyTo
	|
	|-RVA: 0x3DD5360 Offset: 0x3DD5461 VA: 0x3DD5360
	|-List<XRView>.CopyTo
	|
	|-RVA: 0x3DD8590 Offset: 0x3DD8691 VA: 0x3DD8590
	|-List<AmiiboSequence.GainItemData>.CopyTo
	|
	|-RVA: 0x3DDB690 Offset: 0x3DDB791 VA: 0x3DDB690
	|-List<AnimationOutputWeightProcessor.WeightInfo>.CopyTo
	|
	|-RVA: 0x3DDE850 Offset: 0x3DDE951 VA: 0x3DDE850
	|-List<ArenaOrderSequence.GodInfo>.CopyTo
	|
	|-RVA: 0x3E1E0B0 Offset: 0x3E1E1B1 VA: 0x3E1E0B0
	|-List<BattleInfo.SupportData>.CopyTo
	|
	|-RVA: 0x3E20FD0 Offset: 0x3E210D1 VA: 0x3E20FD0
	|-List<BeforeRenderHelper.OrderBlock>.CopyTo
	|
	|-RVA: 0x3E24040 Offset: 0x3E24141 VA: 0x3E24040
	|-List<Camera.RenderRequest>.CopyTo
	|
	|-RVA: 0x3E27120 Offset: 0x3E27221 VA: 0x3E27120
	|-List<CameraState.CustomBlendable>.CopyTo
	|
	|-RVA: 0x3E29FD0 Offset: 0x3E2A0D1 VA: 0x3E29FD0
	|-List<CinemachineClearShot.Pair>.CopyTo
	|
	|-RVA: 0x3E2CDE0 Offset: 0x3E2CEE1 VA: 0x3E2CDE0
	|-List<CinemachineStateDrivenCamera.HashPair>.CopyTo
	|
	|-RVA: 0x3E2FDA0 Offset: 0x3E2FEA1 VA: 0x3E2FDA0
	|-List<DelayedActionManager.DelegateInfo>.CopyTo
	|
	|-RVA: 0x3E33060 Offset: 0x3E33161 VA: 0x3E33060
	|-List<Detail.AsyncResultInt>.CopyTo
	|
	|-RVA: 0x3E36250 Offset: 0x3E36351 VA: 0x3E36250
	|-List<Detail.CppArray>.CopyTo
	|
	|-RVA: 0x3E39330 Offset: 0x3E39431 VA: 0x3E39330
	|-List<Detail.NotificationEventInt>.CopyTo
	|
	|-RVA: 0x3E5B900 Offset: 0x3E5BA01 VA: 0x3E5B900
	|-List<DragonRideTargetGroup.ChainParam>.CopyTo
	|
	|-RVA: 0x3E5E960 Offset: 0x3E5EA61 VA: 0x3E5E960
	|-List<GmapPathAdjuster.TargetModel>.CopyTo
	|
	|-RVA: 0x3E61B70 Offset: 0x3E61C71 VA: 0x3E61B70
	|-List<GmapSpotAdjuster.TargetModel>.CopyTo
	|
	|-RVA: 0x3E64D80 Offset: 0x3E64E81 VA: 0x3E64D80
	|-List<HubFastTravel.Location>.CopyTo
	|
	|-RVA: 0x3E68050 Offset: 0x3E68151 VA: 0x3E68050
	|-List<HubLensFlare.Flare>.CopyTo
	|
	|-RVA: 0x3E6B290 Offset: 0x3E6B391 VA: 0x3E6B290
	|-List<InventoryPoolItemMenuContent.KindBgNameClass>.CopyTo
	|
	|-RVA: 0x3E6E140 Offset: 0x3E6E241 VA: 0x3E6E140
	|-List<Map.Pos>.CopyTo
	|
	|-RVA: 0x3E70FA0 Offset: 0x3E710A1 VA: 0x3E70FA0
	|-List<MapImage.BackupTerrain>.CopyTo
	|
	|-RVA: 0x3E73E40 Offset: 0x3E73F41 VA: 0x3E73E40
	|-List<MapImageRange.Pos>.CopyTo
	|
	|-RVA: 0x3E76E80 Offset: 0x3E76F81 VA: 0x3E76E80
	|-List<MapMind.Target>.CopyTo
	|
	|-RVA: 0x3D86A70 Offset: 0x3D86B71 VA: 0x3D86A70
	|-List<MapPanelDebug.Entity>.CopyTo
	|
	|-RVA: 0x3D89AB0 Offset: 0x3D89BB1 VA: 0x3D89AB0
	|-List<NexRanking.Data>.CopyTo
	|
	|-RVA: 0x3D8C910 Offset: 0x3D8CA11 VA: 0x3D8C910
	|-List<NexVersus.RatingData>.CopyTo
	|
	|-RVA: 0x3D8F810 Offset: 0x3D8F911 VA: 0x3D8F810
	|-List<PackedPlayModeBuildLogs.RuntimeBuildLog>.CopyTo
	|
	|-RVA: 0x3D928E0 Offset: 0x3D929E1 VA: 0x3D928E0
	|-List<ParticleSystem.Particle>.CopyTo
	|
	|-RVA: 0x3D95A70 Offset: 0x3D95B71 VA: 0x3D95A70
	|-List<RangeData.Offset>.CopyTo
	|
	|-RVA: 0x3D98A30 Offset: 0x3D98B31 VA: 0x3D98A30
	|-List<RenderGraphDebugData.PassDebugData>.CopyTo
	|
	|-RVA: 0x3D9BD00 Offset: 0x3D9BE01 VA: 0x3D9BD00
	|-List<RenderGraphDebugData.ResourceDebugData>.CopyTo
	|
	|-RVA: 0x3D9EEE0 Offset: 0x3D9EFE1 VA: 0x3D9EEE0
	|-List<RingCleaningUnitSelectMenu.GodParam>.CopyTo
	|
	|-RVA: 0x3DA1FE0 Offset: 0x3DA20E1 VA: 0x3DA1FE0
	|-List<ShadowUtility.Edge>.CopyTo
	|
	|-RVA: 0x3D145E0 Offset: 0x3D146E1 VA: 0x3D145E0
	|-List<SkillArray.Entity>.CopyTo
	|
	|-RVA: 0x3D176E0 Offset: 0x3D177E1 VA: 0x3D176E0
	|-List<TexturePacker_JsonArray.Frame>.CopyTo
	|
	|-RVA: 0x3D1AB70 Offset: 0x3D1AC71 VA: 0x3D1AB70
	|-List<TimeNotificationBehaviour.NotificationEntry>.CopyTo
	|
	|-RVA: 0x3D1DD90 Offset: 0x3D1DE91 VA: 0x3D1DD90
	|-List<UnitySynchronizationContext.WorkRequest>.CopyTo
	|
	|-RVA: 0x3D20E60 Offset: 0x3D20F61 VA: 0x3D20E60
	|-List<XmlSchemaObjectTable.XmlSchemaObjectEntry>.CopyTo
	|
	|-RVA: 0x3D23D80 Offset: 0x3D23E81 VA: 0x3D23D80
	|-List<AssetBundleBuildMap.AssetBundleEntry.AssetPathString>.CopyTo
	|
	|-RVA: 0x3D26E60 Offset: 0x3D26F61 VA: 0x3D26E60
	|-List<Detail.DataStore.DataStoreChangeMetaParamInt>.CopyTo
	|
	|-RVA: 0x3D2A0A0 Offset: 0x3D2A1A1 VA: 0x3D2A0A0
	|-List<Detail.DataStore.DataStoreDeleteParamInt>.CopyTo
	|
	|-RVA: 0x3D2D180 Offset: 0x3D2D281 VA: 0x3D2D180
	|-List<Detail.DataStore.DataStoreGetMetaParamInt>.CopyTo
	|
	|-RVA: 0x3D304F0 Offset: 0x3D305F1 VA: 0x3D304F0
	|-List<Detail.DataStore.DataStoreMetaInfoInt>.CopyTo
	|
	|-RVA: 0x3CF4CB0 Offset: 0x3CF4DB1 VA: 0x3CF4CB0
	|-List<Detail.DataStore.DataStorePasswordInfoInt>.CopyTo
	|
	|-RVA: 0x3CF7E90 Offset: 0x3CF7F91 VA: 0x3CF7E90
	|-List<Detail.DataStore.DataStorePersistenceInfoInt>.CopyTo
	|
	|-RVA: 0x3CFB0F0 Offset: 0x3CFB1F1 VA: 0x3CFB0F0
	|-List<Detail.DataStore.DataStorePreparePostParamInt>.CopyTo
	|
	|-RVA: 0x3CFE2D0 Offset: 0x3CFE3D1 VA: 0x3CFE2D0
	|-List<Detail.DataStore.DataStoreRateObjectParamInt>.CopyTo
	|
	|-RVA: 0x3D01300 Offset: 0x3D01401 VA: 0x3D01300
	|-List<Detail.DataStore.DataStoreRatingInitParamInt>.CopyTo
	|
	|-RVA: 0x3D043A0 Offset: 0x3D044A1 VA: 0x3D043A0
	|-List<Detail.DataStore.DataStoreRatingTargetInt>.CopyTo
	|
	|-RVA: 0x3D07520 Offset: 0x3D07621 VA: 0x3D07520
	|-List<Detail.Ranking.RankingCachedResultInt>.CopyTo
	|
	|-RVA: 0x3D0A860 Offset: 0x3D0A961 VA: 0x3D0A860
	|-List<Detail.Ranking.RankingOrderParamInt>.CopyTo
	|
	|-RVA: 0x3D0D9D0 Offset: 0x3D0DAD1 VA: 0x3D0D9D0
	|-List<Detail.Ranking.RankingRankDataInt>.CopyTo
	|
	|-RVA: 0x3D110E0 Offset: 0x3D111E1 VA: 0x3D110E0
	|-List<Detail.Ranking2.Ranking2ChartInfoInt>.CopyTo
	|
	|-RVA: 0x3D67950 Offset: 0x3D67A51 VA: 0x3D67950
	|-List<Detail.Ranking2.Ranking2RankDataInt>.CopyTo
	|
	|-RVA: 0x3D6AC40 Offset: 0x3D6AD41 VA: 0x3D6AC40
	|-List<Detail.Ranking2.Ranking2ScoreDataInt>.CopyTo
	|
	|-RVA: 0x3D6DC70 Offset: 0x3D6DD71 VA: 0x3D6DC70
	|-List<Detail.Screening.ScreeningContextInfoInt>.CopyTo
	|
	|-RVA: 0x3D71090 Offset: 0x3D71191 VA: 0x3D71090
	|-List<Detail.Subscriber.SubscriberContentInt>.CopyTo
	|
	|-RVA: 0x3D74630 Offset: 0x3D74731 VA: 0x3D74630
	|-List<Detail.Subscriber.SubscriberGetContentParamInt>.CopyTo
	|
	|-RVA: 0x3D778C0 Offset: 0x3D779C1 VA: 0x3D778C0
	|-List<Detail.Subscriber.SubscriberUserStatusInfoInt>.CopyTo
	|
	|-RVA: 0x3D7ABB0 Offset: 0x3D7ACB1 VA: 0x3D7ABB0
	|-List<Detail.Subscriber.SubscriberUserStatusParamInt>.CopyTo
	|
	|-RVA: 0x3D7DBF0 Offset: 0x3D7DCF1 VA: 0x3D7DBF0
	|-List<Detail.Utility.IntegerSettings>.CopyTo
	|
	|-RVA: 0x3D80A50 Offset: 0x3D80B51 VA: 0x3D80A50
	|-List<Detail.Utility.UniqueIdInfoInt>.CopyTo
	|
	|-RVA: 0x3D83960 Offset: 0x3D83A61 VA: 0x3D83960
	|-List<MapHistory.Rewind.LatestInspectorData>.CopyTo
	|
	|-RVA: 0x305FC20 Offset: 0x305FD21 VA: 0x305FC20
	|-List<MapHistory.Rewind.WorkTerrainData>.CopyTo
	|
	|-RVA: 0x3062C00 Offset: 0x3062D01 VA: 0x3062C00
	|-List<MapSkill.AroundCalculator.Result>.CopyTo
	|
	|-RVA: 0x3065D00 Offset: 0x3065E01 VA: 0x3065D00
	|-List<TargetPositionCache.CacheCurve.Item>.CopyTo
	|
	|-RVA: 0x30690C0 Offset: 0x30691C1 VA: 0x30690C0
	|-List<TargetPositionCache.CacheEntry.RecordingItem>.CopyTo
	*/

	// RVA: -1 Offset: -1
	private void EnsureCapacity(int min) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3B0B980 Offset: 0x3B0BA81 VA: 0x3B0B980
	|-List<IntervalTree.Entry<object>>.EnsureCapacity
	|
	|-RVA: 0x3B0EA50 Offset: 0x3B0EB51 VA: 0x3B0EA50
	|-List<KeyValuePair<DateTime, object>>.EnsureCapacity
	|
	|-RVA: 0x3B11970 Offset: 0x3B11A71 VA: 0x3B11970
	|-List<KeyValuePair<int, object>>.EnsureCapacity
	|
	|-RVA: 0x3B149D0 Offset: 0x3B14AD1 VA: 0x3B149D0
	|-List<KeyValuePair<object, ValueTuple<int, DateTime, object>>>.EnsureCapacity
	|
	|-RVA: 0x3B17AB0 Offset: 0x3B17BB1 VA: 0x3B17AB0
	|-List<KeyValuePair<object, object>>.EnsureCapacity
	|
	|-RVA: 0x3B1AB10 Offset: 0x3B1AC11 VA: 0x3B1AB10
	|-List<CommonBattleSequence.Reliance<object>>.EnsureCapacity
	|
	|-RVA: 0x3B1DBE0 Offset: 0x3B1DCE1 VA: 0x3B1DBE0
	|-List<RenderGraphResourcePool.ResourceLogInfo<object>>.EnsureCapacity
	|
	|-RVA: 0x3B20B00 Offset: 0x3B20C01 VA: 0x3B20B00
	|-List<ValueTuple<int, object>>.EnsureCapacity
	|
	|-RVA: 0x3DE1720 Offset: 0x3DE1821 VA: 0x3DE1720
	|-List<ValueTuple<Int32Enum, int>>.EnsureCapacity
	|
	|-RVA: 0x3DE46E0 Offset: 0x3DE47E1 VA: 0x3DE46E0
	|-List<ValueTuple<object, ValueTuple<object, int>>>.EnsureCapacity
	|
	|-RVA: 0x3DE77B0 Offset: 0x3DE78B1 VA: 0x3DE77B0
	|-List<ValueTuple<object, int>>.EnsureCapacity
	|
	|-RVA: 0x3DEA760 Offset: 0x3DEA861 VA: 0x3DEA760
	|-List<ValueTuple<Vector3, float>>.EnsureCapacity
	|
	|-RVA: 0x3DED6D0 Offset: 0x3DED7D1 VA: 0x3DED6D0
	|-List<ValueTuple<object, Int32Enum, int>>.EnsureCapacity
	|
	|-RVA: 0x3DF0730 Offset: 0x3DF0831 VA: 0x3DF0730
	|-List<ValueTuple<object, int, int, int>>.EnsureCapacity
	|
	|-RVA: 0x3DF3790 Offset: 0x3DF3891 VA: 0x3DF3790
	|-List<AnimatorClipInfo>.EnsureCapacity
	|
	|-RVA: 0x3DF6750 Offset: 0x3DF6851 VA: 0x3DF6750
	|-List<AsyncOperationHandle>.EnsureCapacity
	|
	|-RVA: 0x3DF9950 Offset: 0x3DF9A51 VA: 0x3DF9950
	|-List<BoneWeight>.EnsureCapacity
	|
	|-RVA: 0x3DFC9B0 Offset: 0x3DFCAB1 VA: 0x3DFC9B0
	|-List<bool>.EnsureCapacity
	|
	|-RVA: 0x3E79F00 Offset: 0x3E7A001 VA: 0x3E79F00
	|-List<byte>.EnsureCapacity
	|
	|-RVA: 0x3E7CD80 Offset: 0x3E7CE81 VA: 0x3E7CD80
	|-List<CameraInfo>.EnsureCapacity
	|
	|-RVA: 0x3E7FC30 Offset: 0x3E7FD31 VA: 0x3E7FC30
	|-List<char>.EnsureCapacity
	|
	|-RVA: 0x3E82B30 Offset: 0x3E82C31 VA: 0x3E82B30
	|-List<Color>.EnsureCapacity
	|
	|-RVA: 0x3E85A30 Offset: 0x3E85B31 VA: 0x3E85A30
	|-List<Color32>.EnsureCapacity
	|
	|-RVA: 0x3E888B0 Offset: 0x3E889B1 VA: 0x3E888B0
	|-List<ConstraintSource>.EnsureCapacity
	|
	|-RVA: 0x3E8B910 Offset: 0x3E8BA11 VA: 0x3E8B910
	|-List<ContourVertex>.EnsureCapacity
	|
	|-RVA: 0x3E8EB10 Offset: 0x3E8EC11 VA: 0x3E8EB10
	|-List<DataStoreRatingInfo>.EnsureCapacity
	|
	|-RVA: 0x3E91B50 Offset: 0x3E91C51 VA: 0x3E91B50
	|-List<DataStoreResult>.EnsureCapacity
	|
	|-RVA: 0x3E94960 Offset: 0x3E94A61 VA: 0x3E94960
	|-List<DateTime>.EnsureCapacity
	|
	|-RVA: 0x3E977C0 Offset: 0x3E978C1 VA: 0x3E977C0
	|-List<DateTimeOffset>.EnsureCapacity
	|
	|-RVA: 0x3E9A6A0 Offset: 0x3E9A7A1 VA: 0x3E9A6A0
	|-List<Decimal>.EnsureCapacity
	|
	|-RVA: 0x3E9D7A0 Offset: 0x3E9D8A1 VA: 0x3E9D7A0
	|-List<DiagnosticEvent>.EnsureCapacity
	|
	|-RVA: 0x3EA0980 Offset: 0x3EA0A81 VA: 0x3EA0980
	|-List<double>.EnsureCapacity
	|
	|-RVA: 0x3EA3990 Offset: 0x3EA3A91 VA: 0x3EA3990
	|-List<Friend>.EnsureCapacity
	|
	|-RVA: 0x3EA6B70 Offset: 0x3EA6C71 VA: 0x3EA6B70
	|-List<GlyphRect>.EnsureCapacity
	|
	|-RVA: 0x3EA9A00 Offset: 0x3EA9B01 VA: 0x3EA9A00
	|-List<short>.EnsureCapacity
	|
	|-RVA: 0x3EAC800 Offset: 0x3EAC901 VA: 0x3EAC800
	|-List<int>.EnsureCapacity
	|
	|-RVA: 0x3EAF600 Offset: 0x3EAF701 VA: 0x3EAF600
	|-List<Int32Enum>.EnsureCapacity
	|
	|-RVA: 0x3EB2400 Offset: 0x3EB2501 VA: 0x3EB2400
	|-List<long>.EnsureCapacity
	|
	|-RVA: 0x3DFF7D0 Offset: 0x3DFF8D1 VA: 0x3DFF7D0
	|-List<IntPtr>.EnsureCapacity
	|
	|-RVA: 0x3E02640 Offset: 0x3E02741 VA: 0x3E02640
	|-List<InterpretedFrameInfo>.EnsureCapacity
	|
	|-RVA: 0x3E05690 Offset: 0x3E05791 VA: 0x3E05690
	|-List<IntervalTreeNode>.EnsureCapacity
	|
	|-RVA: 0x3E086D0 Offset: 0x3E087D1 VA: 0x3E086D0
	|-List<LengthLimitProperties>.EnsureCapacity
	|
	|-RVA: 0x3E0B4E0 Offset: 0x3E0B5E1 VA: 0x3E0B4E0
	|-List<MapPos>.EnsureCapacity
	|
	|-RVA: 0x3E0E5D0 Offset: 0x3E0E6D1 VA: 0x3E0E5D0
	|-List<Matrix4x4>.EnsureCapacity
	|
	|-RVA: 0x3E11810 Offset: 0x3E11911 VA: 0x3E11810
	|-List<object>.EnsureCapacity
	|
	|-RVA: 0x3E148A0 Offset: 0x3E149A1 VA: 0x3E148A0
	|-List<ObjectInitializationData>.EnsureCapacity
	|
	|-RVA: 0x3E17C20 Offset: 0x3E17D21 VA: 0x3E17C20
	|-List<PlayableBinding>.EnsureCapacity
	|
	|-RVA: 0x3E1AEF0 Offset: 0x3E1AFF1 VA: 0x3E1AEF0
	|-List<PlayerLoopSystem>.EnsureCapacity
	|
	|-RVA: 0x3DA5390 Offset: 0x3DA5491 VA: 0x3DA5390
	|-List<PlayerLoopSystemInternal>.EnsureCapacity
	|
	|-RVA: 0x3DA8570 Offset: 0x3DA8671 VA: 0x3DA8570
	|-List<RangePositionInfo>.EnsureCapacity
	|
	|-RVA: 0x3DAB420 Offset: 0x3DAB521 VA: 0x3DAB420
	|-List<Ranking2ChartInfoInput>.EnsureCapacity
	|
	|-RVA: 0x3DAE4C0 Offset: 0x3DAE5C1 VA: 0x3DAE4C0
	|-List<RaycastHit2D>.EnsureCapacity
	|
	|-RVA: 0x3DB1A30 Offset: 0x3DB1B31 VA: 0x3DB1A30
	|-List<RaycastResult>.EnsureCapacity
	|
	|-RVA: 0x3DB4F60 Offset: 0x3DB5061 VA: 0x3DB4F60
	|-List<Rect>.EnsureCapacity
	|
	|-RVA: 0x3DB7E60 Offset: 0x3DB7F61 VA: 0x3DB7E60
	|-List<RendererListHandle>.EnsureCapacity
	|
	|-RVA: 0x3DBAC70 Offset: 0x3DBAD71 VA: 0x3DBAC70
	|-List<ResourceHandle>.EnsureCapacity
	|
	|-RVA: 0x3DBDA80 Offset: 0x3DBDB81 VA: 0x3DBDA80
	|-List<sbyte>.EnsureCapacity
	|
	|-RVA: 0x3DC0890 Offset: 0x3DC0991 VA: 0x3DC0890
	|-List<ShaderTagId>.EnsureCapacity
	|
	|-RVA: 0x3E3C500 Offset: 0x3E3C601 VA: 0x3E3C500
	|-List<float>.EnsureCapacity
	|
	|-RVA: 0x3E3F8E0 Offset: 0x3E3F9E1 VA: 0x3E3F8E0
	|-List<SphericalHarmonicsL2>.EnsureCapacity
	|
	|-RVA: 0x3E43240 Offset: 0x3E43341 VA: 0x3E43240
	|-List<SubMeshDescriptor>.EnsureCapacity
	|
	|-RVA: 0x3E46450 Offset: 0x3E46551 VA: 0x3E46450
	|-List<TablePair>.EnsureCapacity
	|
	|-RVA: 0x3E49300 Offset: 0x3E49401 VA: 0x3E49300
	|-List<TimeSpan>.EnsureCapacity
	|
	|-RVA: 0x3E4C1E0 Offset: 0x3E4C2E1 VA: 0x3E4C1E0
	|-List<UICharInfo>.EnsureCapacity
	|
	|-RVA: 0x3E4F140 Offset: 0x3E4F241 VA: 0x3E4F140
	|-List<UILineInfo>.EnsureCapacity
	|
	|-RVA: 0x3E525A0 Offset: 0x3E526A1 VA: 0x3E525A0
	|-List<UIVertex>.EnsureCapacity
	|
	|-RVA: 0x3E55CB0 Offset: 0x3E55DB1 VA: 0x3E55CB0
	|-List<ushort>.EnsureCapacity
	|
	|-RVA: 0x3E58AB0 Offset: 0x3E58BB1 VA: 0x3E58AB0
	|-List<uint>.EnsureCapacity
	|
	|-RVA: 0x3DC36A0 Offset: 0x3DC37A1 VA: 0x3DC36A0
	|-List<ulong>.EnsureCapacity
	|
	|-RVA: 0x3DC64E0 Offset: 0x3DC65E1 VA: 0x3DC64E0
	|-List<Vector2>.EnsureCapacity
	|
	|-RVA: 0x3DC9440 Offset: 0x3DC9541 VA: 0x3DC9440
	|-List<Vector3>.EnsureCapacity
	|
	|-RVA: 0x3DCC450 Offset: 0x3DCC551 VA: 0x3DCC450
	|-List<Vector4>.EnsureCapacity
	|
	|-RVA: 0x3DCF3A0 Offset: 0x3DCF4A1 VA: 0x3DCF3A0
	|-List<VertexAttributeDescriptor>.EnsureCapacity
	|
	|-RVA: 0x3DD22A0 Offset: 0x3DD23A1 VA: 0x3DD22A0
	|-List<X509ChainStatus>.EnsureCapacity
	|
	|-RVA: 0x3DD5380 Offset: 0x3DD5481 VA: 0x3DD5380
	|-List<XRView>.EnsureCapacity
	|
	|-RVA: 0x3DD85B0 Offset: 0x3DD86B1 VA: 0x3DD85B0
	|-List<AmiiboSequence.GainItemData>.EnsureCapacity
	|
	|-RVA: 0x3DDB6B0 Offset: 0x3DDB7B1 VA: 0x3DDB6B0
	|-List<AnimationOutputWeightProcessor.WeightInfo>.EnsureCapacity
	|
	|-RVA: 0x3DDE870 Offset: 0x3DDE971 VA: 0x3DDE870
	|-List<ArenaOrderSequence.GodInfo>.EnsureCapacity
	|
	|-RVA: 0x3E1E0D0 Offset: 0x3E1E1D1 VA: 0x3E1E0D0
	|-List<BattleInfo.SupportData>.EnsureCapacity
	|
	|-RVA: 0x3E20FF0 Offset: 0x3E210F1 VA: 0x3E20FF0
	|-List<BeforeRenderHelper.OrderBlock>.EnsureCapacity
	|
	|-RVA: 0x3E24060 Offset: 0x3E24161 VA: 0x3E24060
	|-List<Camera.RenderRequest>.EnsureCapacity
	|
	|-RVA: 0x3E27140 Offset: 0x3E27241 VA: 0x3E27140
	|-List<CameraState.CustomBlendable>.EnsureCapacity
	|
	|-RVA: 0x3E29FF0 Offset: 0x3E2A0F1 VA: 0x3E29FF0
	|-List<CinemachineClearShot.Pair>.EnsureCapacity
	|
	|-RVA: 0x3E2CE00 Offset: 0x3E2CF01 VA: 0x3E2CE00
	|-List<CinemachineStateDrivenCamera.HashPair>.EnsureCapacity
	|
	|-RVA: 0x3E2FDC0 Offset: 0x3E2FEC1 VA: 0x3E2FDC0
	|-List<DelayedActionManager.DelegateInfo>.EnsureCapacity
	|
	|-RVA: 0x3E33080 Offset: 0x3E33181 VA: 0x3E33080
	|-List<Detail.AsyncResultInt>.EnsureCapacity
	|
	|-RVA: 0x3E36270 Offset: 0x3E36371 VA: 0x3E36270
	|-List<Detail.CppArray>.EnsureCapacity
	|
	|-RVA: 0x3E39350 Offset: 0x3E39451 VA: 0x3E39350
	|-List<Detail.NotificationEventInt>.EnsureCapacity
	|
	|-RVA: 0x3E5B920 Offset: 0x3E5BA21 VA: 0x3E5B920
	|-List<DragonRideTargetGroup.ChainParam>.EnsureCapacity
	|
	|-RVA: 0x3E5E980 Offset: 0x3E5EA81 VA: 0x3E5E980
	|-List<GmapPathAdjuster.TargetModel>.EnsureCapacity
	|
	|-RVA: 0x3E61B90 Offset: 0x3E61C91 VA: 0x3E61B90
	|-List<GmapSpotAdjuster.TargetModel>.EnsureCapacity
	|
	|-RVA: 0x3E64DA0 Offset: 0x3E64EA1 VA: 0x3E64DA0
	|-List<HubFastTravel.Location>.EnsureCapacity
	|
	|-RVA: 0x3E68070 Offset: 0x3E68171 VA: 0x3E68070
	|-List<HubLensFlare.Flare>.EnsureCapacity
	|
	|-RVA: 0x3E6B2B0 Offset: 0x3E6B3B1 VA: 0x3E6B2B0
	|-List<InventoryPoolItemMenuContent.KindBgNameClass>.EnsureCapacity
	|
	|-RVA: 0x3E6E160 Offset: 0x3E6E261 VA: 0x3E6E160
	|-List<Map.Pos>.EnsureCapacity
	|
	|-RVA: 0x3E70FC0 Offset: 0x3E710C1 VA: 0x3E70FC0
	|-List<MapImage.BackupTerrain>.EnsureCapacity
	|
	|-RVA: 0x3E73E60 Offset: 0x3E73F61 VA: 0x3E73E60
	|-List<MapImageRange.Pos>.EnsureCapacity
	|
	|-RVA: 0x3E76EA0 Offset: 0x3E76FA1 VA: 0x3E76EA0
	|-List<MapMind.Target>.EnsureCapacity
	|
	|-RVA: 0x3D86A90 Offset: 0x3D86B91 VA: 0x3D86A90
	|-List<MapPanelDebug.Entity>.EnsureCapacity
	|
	|-RVA: 0x3D89AD0 Offset: 0x3D89BD1 VA: 0x3D89AD0
	|-List<NexRanking.Data>.EnsureCapacity
	|
	|-RVA: 0x3D8C930 Offset: 0x3D8CA31 VA: 0x3D8C930
	|-List<NexVersus.RatingData>.EnsureCapacity
	|
	|-RVA: 0x3D8F830 Offset: 0x3D8F931 VA: 0x3D8F830
	|-List<PackedPlayModeBuildLogs.RuntimeBuildLog>.EnsureCapacity
	|
	|-RVA: 0x3D92900 Offset: 0x3D92A01 VA: 0x3D92900
	|-List<ParticleSystem.Particle>.EnsureCapacity
	|
	|-RVA: 0x3D95A90 Offset: 0x3D95B91 VA: 0x3D95A90
	|-List<RangeData.Offset>.EnsureCapacity
	|
	|-RVA: 0x3D98A50 Offset: 0x3D98B51 VA: 0x3D98A50
	|-List<RenderGraphDebugData.PassDebugData>.EnsureCapacity
	|
	|-RVA: 0x3D9BD20 Offset: 0x3D9BE21 VA: 0x3D9BD20
	|-List<RenderGraphDebugData.ResourceDebugData>.EnsureCapacity
	|
	|-RVA: 0x3D9EF00 Offset: 0x3D9F001 VA: 0x3D9EF00
	|-List<RingCleaningUnitSelectMenu.GodParam>.EnsureCapacity
	|
	|-RVA: 0x3DA2000 Offset: 0x3DA2101 VA: 0x3DA2000
	|-List<ShadowUtility.Edge>.EnsureCapacity
	|
	|-RVA: 0x3D14600 Offset: 0x3D14701 VA: 0x3D14600
	|-List<SkillArray.Entity>.EnsureCapacity
	|
	|-RVA: 0x3D17700 Offset: 0x3D17801 VA: 0x3D17700
	|-List<TexturePacker_JsonArray.Frame>.EnsureCapacity
	|
	|-RVA: 0x3D1AB90 Offset: 0x3D1AC91 VA: 0x3D1AB90
	|-List<TimeNotificationBehaviour.NotificationEntry>.EnsureCapacity
	|
	|-RVA: 0x3D1DDB0 Offset: 0x3D1DEB1 VA: 0x3D1DDB0
	|-List<UnitySynchronizationContext.WorkRequest>.EnsureCapacity
	|
	|-RVA: 0x3D20E80 Offset: 0x3D20F81 VA: 0x3D20E80
	|-List<XmlSchemaObjectTable.XmlSchemaObjectEntry>.EnsureCapacity
	|
	|-RVA: 0x3D23DA0 Offset: 0x3D23EA1 VA: 0x3D23DA0
	|-List<AssetBundleBuildMap.AssetBundleEntry.AssetPathString>.EnsureCapacity
	|
	|-RVA: 0x3D26E80 Offset: 0x3D26F81 VA: 0x3D26E80
	|-List<Detail.DataStore.DataStoreChangeMetaParamInt>.EnsureCapacity
	|
	|-RVA: 0x3D2A0C0 Offset: 0x3D2A1C1 VA: 0x3D2A0C0
	|-List<Detail.DataStore.DataStoreDeleteParamInt>.EnsureCapacity
	|
	|-RVA: 0x3D2D1A0 Offset: 0x3D2D2A1 VA: 0x3D2D1A0
	|-List<Detail.DataStore.DataStoreGetMetaParamInt>.EnsureCapacity
	|
	|-RVA: 0x3D30510 Offset: 0x3D30611 VA: 0x3D30510
	|-List<Detail.DataStore.DataStoreMetaInfoInt>.EnsureCapacity
	|
	|-RVA: 0x3CF4CD0 Offset: 0x3CF4DD1 VA: 0x3CF4CD0
	|-List<Detail.DataStore.DataStorePasswordInfoInt>.EnsureCapacity
	|
	|-RVA: 0x3CF7EB0 Offset: 0x3CF7FB1 VA: 0x3CF7EB0
	|-List<Detail.DataStore.DataStorePersistenceInfoInt>.EnsureCapacity
	|
	|-RVA: 0x3CFB110 Offset: 0x3CFB211 VA: 0x3CFB110
	|-List<Detail.DataStore.DataStorePreparePostParamInt>.EnsureCapacity
	|
	|-RVA: 0x3CFE2F0 Offset: 0x3CFE3F1 VA: 0x3CFE2F0
	|-List<Detail.DataStore.DataStoreRateObjectParamInt>.EnsureCapacity
	|
	|-RVA: 0x3D01320 Offset: 0x3D01421 VA: 0x3D01320
	|-List<Detail.DataStore.DataStoreRatingInitParamInt>.EnsureCapacity
	|
	|-RVA: 0x3D043C0 Offset: 0x3D044C1 VA: 0x3D043C0
	|-List<Detail.DataStore.DataStoreRatingTargetInt>.EnsureCapacity
	|
	|-RVA: 0x3D07540 Offset: 0x3D07641 VA: 0x3D07540
	|-List<Detail.Ranking.RankingCachedResultInt>.EnsureCapacity
	|
	|-RVA: 0x3D0A880 Offset: 0x3D0A981 VA: 0x3D0A880
	|-List<Detail.Ranking.RankingOrderParamInt>.EnsureCapacity
	|
	|-RVA: 0x3D0D9F0 Offset: 0x3D0DAF1 VA: 0x3D0D9F0
	|-List<Detail.Ranking.RankingRankDataInt>.EnsureCapacity
	|
	|-RVA: 0x3D11100 Offset: 0x3D11201 VA: 0x3D11100
	|-List<Detail.Ranking2.Ranking2ChartInfoInt>.EnsureCapacity
	|
	|-RVA: 0x3D67970 Offset: 0x3D67A71 VA: 0x3D67970
	|-List<Detail.Ranking2.Ranking2RankDataInt>.EnsureCapacity
	|
	|-RVA: 0x3D6AC60 Offset: 0x3D6AD61 VA: 0x3D6AC60
	|-List<Detail.Ranking2.Ranking2ScoreDataInt>.EnsureCapacity
	|
	|-RVA: 0x3D6DC90 Offset: 0x3D6DD91 VA: 0x3D6DC90
	|-List<Detail.Screening.ScreeningContextInfoInt>.EnsureCapacity
	|
	|-RVA: 0x3D710B0 Offset: 0x3D711B1 VA: 0x3D710B0
	|-List<Detail.Subscriber.SubscriberContentInt>.EnsureCapacity
	|
	|-RVA: 0x3D74650 Offset: 0x3D74751 VA: 0x3D74650
	|-List<Detail.Subscriber.SubscriberGetContentParamInt>.EnsureCapacity
	|
	|-RVA: 0x3D778E0 Offset: 0x3D779E1 VA: 0x3D778E0
	|-List<Detail.Subscriber.SubscriberUserStatusInfoInt>.EnsureCapacity
	|
	|-RVA: 0x3D7ABD0 Offset: 0x3D7ACD1 VA: 0x3D7ABD0
	|-List<Detail.Subscriber.SubscriberUserStatusParamInt>.EnsureCapacity
	|
	|-RVA: 0x3D7DC10 Offset: 0x3D7DD11 VA: 0x3D7DC10
	|-List<Detail.Utility.IntegerSettings>.EnsureCapacity
	|
	|-RVA: 0x3D80A70 Offset: 0x3D80B71 VA: 0x3D80A70
	|-List<Detail.Utility.UniqueIdInfoInt>.EnsureCapacity
	|
	|-RVA: 0x3D83980 Offset: 0x3D83A81 VA: 0x3D83980
	|-List<MapHistory.Rewind.LatestInspectorData>.EnsureCapacity
	|
	|-RVA: 0x305FC40 Offset: 0x305FD41 VA: 0x305FC40
	|-List<MapHistory.Rewind.WorkTerrainData>.EnsureCapacity
	|
	|-RVA: 0x3062C20 Offset: 0x3062D21 VA: 0x3062C20
	|-List<MapSkill.AroundCalculator.Result>.EnsureCapacity
	|
	|-RVA: 0x3065D20 Offset: 0x3065E21 VA: 0x3065D20
	|-List<TargetPositionCache.CacheCurve.Item>.EnsureCapacity
	|
	|-RVA: 0x30690E0 Offset: 0x30691E1 VA: 0x30690E0
	|-List<TargetPositionCache.CacheEntry.RecordingItem>.EnsureCapacity
	*/

	// RVA: -1 Offset: -1
	public bool Exists(Predicate<T> match) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3B0B9D0 Offset: 0x3B0BAD1 VA: 0x3B0B9D0
	|-List<IntervalTree.Entry<object>>.Exists
	|
	|-RVA: 0x3B0EAA0 Offset: 0x3B0EBA1 VA: 0x3B0EAA0
	|-List<KeyValuePair<DateTime, object>>.Exists
	|
	|-RVA: 0x3B119C0 Offset: 0x3B11AC1 VA: 0x3B119C0
	|-List<KeyValuePair<int, object>>.Exists
	|
	|-RVA: 0x3B14A20 Offset: 0x3B14B21 VA: 0x3B14A20
	|-List<KeyValuePair<object, ValueTuple<int, DateTime, object>>>.Exists
	|
	|-RVA: 0x3B17B00 Offset: 0x3B17C01 VA: 0x3B17B00
	|-List<KeyValuePair<object, object>>.Exists
	|
	|-RVA: 0x3B1AB60 Offset: 0x3B1AC61 VA: 0x3B1AB60
	|-List<CommonBattleSequence.Reliance<object>>.Exists
	|
	|-RVA: 0x3B1DC30 Offset: 0x3B1DD31 VA: 0x3B1DC30
	|-List<RenderGraphResourcePool.ResourceLogInfo<object>>.Exists
	|
	|-RVA: 0x3B20B50 Offset: 0x3B20C51 VA: 0x3B20B50
	|-List<ValueTuple<int, object>>.Exists
	|
	|-RVA: 0x3DE1770 Offset: 0x3DE1871 VA: 0x3DE1770
	|-List<ValueTuple<Int32Enum, int>>.Exists
	|
	|-RVA: 0x3DE4730 Offset: 0x3DE4831 VA: 0x3DE4730
	|-List<ValueTuple<object, ValueTuple<object, int>>>.Exists
	|
	|-RVA: 0x3DE7800 Offset: 0x3DE7901 VA: 0x3DE7800
	|-List<ValueTuple<object, int>>.Exists
	|
	|-RVA: 0x3DEA7B0 Offset: 0x3DEA8B1 VA: 0x3DEA7B0
	|-List<ValueTuple<Vector3, float>>.Exists
	|
	|-RVA: 0x3DED720 Offset: 0x3DED821 VA: 0x3DED720
	|-List<ValueTuple<object, Int32Enum, int>>.Exists
	|
	|-RVA: 0x3DF0780 Offset: 0x3DF0881 VA: 0x3DF0780
	|-List<ValueTuple<object, int, int, int>>.Exists
	|
	|-RVA: 0x3DF37E0 Offset: 0x3DF38E1 VA: 0x3DF37E0
	|-List<AnimatorClipInfo>.Exists
	|
	|-RVA: 0x3DF67A0 Offset: 0x3DF68A1 VA: 0x3DF67A0
	|-List<AsyncOperationHandle>.Exists
	|
	|-RVA: 0x3DF99A0 Offset: 0x3DF9AA1 VA: 0x3DF99A0
	|-List<BoneWeight>.Exists
	|
	|-RVA: 0x3DFCA00 Offset: 0x3DFCB01 VA: 0x3DFCA00
	|-List<bool>.Exists
	|
	|-RVA: 0x3E79F50 Offset: 0x3E7A051 VA: 0x3E79F50
	|-List<byte>.Exists
	|
	|-RVA: 0x3E7CDD0 Offset: 0x3E7CED1 VA: 0x3E7CDD0
	|-List<CameraInfo>.Exists
	|
	|-RVA: 0x3E7FC80 Offset: 0x3E7FD81 VA: 0x3E7FC80
	|-List<char>.Exists
	|
	|-RVA: 0x3E82B80 Offset: 0x3E82C81 VA: 0x3E82B80
	|-List<Color>.Exists
	|
	|-RVA: 0x3E85A80 Offset: 0x3E85B81 VA: 0x3E85A80
	|-List<Color32>.Exists
	|
	|-RVA: 0x3E88900 Offset: 0x3E88A01 VA: 0x3E88900
	|-List<ConstraintSource>.Exists
	|
	|-RVA: 0x3E8B960 Offset: 0x3E8BA61 VA: 0x3E8B960
	|-List<ContourVertex>.Exists
	|
	|-RVA: 0x3E8EB60 Offset: 0x3E8EC61 VA: 0x3E8EB60
	|-List<DataStoreRatingInfo>.Exists
	|
	|-RVA: 0x3E91BA0 Offset: 0x3E91CA1 VA: 0x3E91BA0
	|-List<DataStoreResult>.Exists
	|
	|-RVA: 0x3E949B0 Offset: 0x3E94AB1 VA: 0x3E949B0
	|-List<DateTime>.Exists
	|
	|-RVA: 0x3E97810 Offset: 0x3E97911 VA: 0x3E97810
	|-List<DateTimeOffset>.Exists
	|
	|-RVA: 0x3E9A6F0 Offset: 0x3E9A7F1 VA: 0x3E9A6F0
	|-List<Decimal>.Exists
	|
	|-RVA: 0x3E9D7F0 Offset: 0x3E9D8F1 VA: 0x3E9D7F0
	|-List<DiagnosticEvent>.Exists
	|
	|-RVA: 0x3EA09D0 Offset: 0x3EA0AD1 VA: 0x3EA09D0
	|-List<double>.Exists
	|
	|-RVA: 0x3EA39E0 Offset: 0x3EA3AE1 VA: 0x3EA39E0
	|-List<Friend>.Exists
	|
	|-RVA: 0x3EA6BC0 Offset: 0x3EA6CC1 VA: 0x3EA6BC0
	|-List<GlyphRect>.Exists
	|
	|-RVA: 0x3EA9A50 Offset: 0x3EA9B51 VA: 0x3EA9A50
	|-List<short>.Exists
	|
	|-RVA: 0x3EAC850 Offset: 0x3EAC951 VA: 0x3EAC850
	|-List<int>.Exists
	|
	|-RVA: 0x3EAF650 Offset: 0x3EAF751 VA: 0x3EAF650
	|-List<Int32Enum>.Exists
	|
	|-RVA: 0x3EB2450 Offset: 0x3EB2551 VA: 0x3EB2450
	|-List<long>.Exists
	|
	|-RVA: 0x3DFF820 Offset: 0x3DFF921 VA: 0x3DFF820
	|-List<IntPtr>.Exists
	|
	|-RVA: 0x3E02690 Offset: 0x3E02791 VA: 0x3E02690
	|-List<InterpretedFrameInfo>.Exists
	|
	|-RVA: 0x3E056E0 Offset: 0x3E057E1 VA: 0x3E056E0
	|-List<IntervalTreeNode>.Exists
	|
	|-RVA: 0x3E08720 Offset: 0x3E08821 VA: 0x3E08720
	|-List<LengthLimitProperties>.Exists
	|
	|-RVA: 0x3E0B530 Offset: 0x3E0B631 VA: 0x3E0B530
	|-List<MapPos>.Exists
	|
	|-RVA: 0x3E0E620 Offset: 0x3E0E721 VA: 0x3E0E620
	|-List<Matrix4x4>.Exists
	|
	|-RVA: 0x3E11860 Offset: 0x3E11961 VA: 0x3E11860
	|-List<object>.Exists
	|-List<ScriptableObject>.Exists
	|
	|-RVA: 0x3E148F0 Offset: 0x3E149F1 VA: 0x3E148F0
	|-List<ObjectInitializationData>.Exists
	|
	|-RVA: 0x3E17C70 Offset: 0x3E17D71 VA: 0x3E17C70
	|-List<PlayableBinding>.Exists
	|
	|-RVA: 0x3E1AF40 Offset: 0x3E1B041 VA: 0x3E1AF40
	|-List<PlayerLoopSystem>.Exists
	|
	|-RVA: 0x3DA53E0 Offset: 0x3DA54E1 VA: 0x3DA53E0
	|-List<PlayerLoopSystemInternal>.Exists
	|
	|-RVA: 0x3DA85C0 Offset: 0x3DA86C1 VA: 0x3DA85C0
	|-List<RangePositionInfo>.Exists
	|
	|-RVA: 0x3DAB470 Offset: 0x3DAB571 VA: 0x3DAB470
	|-List<Ranking2ChartInfoInput>.Exists
	|
	|-RVA: 0x3DAE510 Offset: 0x3DAE611 VA: 0x3DAE510
	|-List<RaycastHit2D>.Exists
	|
	|-RVA: 0x3DB1A80 Offset: 0x3DB1B81 VA: 0x3DB1A80
	|-List<RaycastResult>.Exists
	|
	|-RVA: 0x3DB4FB0 Offset: 0x3DB50B1 VA: 0x3DB4FB0
	|-List<Rect>.Exists
	|
	|-RVA: 0x3DB7EB0 Offset: 0x3DB7FB1 VA: 0x3DB7EB0
	|-List<RendererListHandle>.Exists
	|
	|-RVA: 0x3DBACC0 Offset: 0x3DBADC1 VA: 0x3DBACC0
	|-List<ResourceHandle>.Exists
	|
	|-RVA: 0x3DBDAD0 Offset: 0x3DBDBD1 VA: 0x3DBDAD0
	|-List<sbyte>.Exists
	|
	|-RVA: 0x3DC08E0 Offset: 0x3DC09E1 VA: 0x3DC08E0
	|-List<ShaderTagId>.Exists
	|
	|-RVA: 0x3E3C550 Offset: 0x3E3C651 VA: 0x3E3C550
	|-List<float>.Exists
	|
	|-RVA: 0x3E3F930 Offset: 0x3E3FA31 VA: 0x3E3F930
	|-List<SphericalHarmonicsL2>.Exists
	|
	|-RVA: 0x3E43290 Offset: 0x3E43391 VA: 0x3E43290
	|-List<SubMeshDescriptor>.Exists
	|
	|-RVA: 0x3E464A0 Offset: 0x3E465A1 VA: 0x3E464A0
	|-List<TablePair>.Exists
	|
	|-RVA: 0x3E49350 Offset: 0x3E49451 VA: 0x3E49350
	|-List<TimeSpan>.Exists
	|
	|-RVA: 0x3E4C230 Offset: 0x3E4C331 VA: 0x3E4C230
	|-List<UICharInfo>.Exists
	|
	|-RVA: 0x3E4F190 Offset: 0x3E4F291 VA: 0x3E4F190
	|-List<UILineInfo>.Exists
	|
	|-RVA: 0x3E525F0 Offset: 0x3E526F1 VA: 0x3E525F0
	|-List<UIVertex>.Exists
	|
	|-RVA: 0x3E55D00 Offset: 0x3E55E01 VA: 0x3E55D00
	|-List<ushort>.Exists
	|
	|-RVA: 0x3E58B00 Offset: 0x3E58C01 VA: 0x3E58B00
	|-List<uint>.Exists
	|
	|-RVA: 0x3DC36F0 Offset: 0x3DC37F1 VA: 0x3DC36F0
	|-List<ulong>.Exists
	|
	|-RVA: 0x3DC6530 Offset: 0x3DC6631 VA: 0x3DC6530
	|-List<Vector2>.Exists
	|
	|-RVA: 0x3DC9490 Offset: 0x3DC9591 VA: 0x3DC9490
	|-List<Vector3>.Exists
	|
	|-RVA: 0x3DCC4A0 Offset: 0x3DCC5A1 VA: 0x3DCC4A0
	|-List<Vector4>.Exists
	|
	|-RVA: 0x3DCF3F0 Offset: 0x3DCF4F1 VA: 0x3DCF3F0
	|-List<VertexAttributeDescriptor>.Exists
	|
	|-RVA: 0x3DD22F0 Offset: 0x3DD23F1 VA: 0x3DD22F0
	|-List<X509ChainStatus>.Exists
	|
	|-RVA: 0x3DD53D0 Offset: 0x3DD54D1 VA: 0x3DD53D0
	|-List<XRView>.Exists
	|
	|-RVA: 0x3DD8600 Offset: 0x3DD8701 VA: 0x3DD8600
	|-List<AmiiboSequence.GainItemData>.Exists
	|
	|-RVA: 0x3DDB700 Offset: 0x3DDB801 VA: 0x3DDB700
	|-List<AnimationOutputWeightProcessor.WeightInfo>.Exists
	|
	|-RVA: 0x3DDE8C0 Offset: 0x3DDE9C1 VA: 0x3DDE8C0
	|-List<ArenaOrderSequence.GodInfo>.Exists
	|
	|-RVA: 0x3E1E120 Offset: 0x3E1E221 VA: 0x3E1E120
	|-List<BattleInfo.SupportData>.Exists
	|
	|-RVA: 0x3E21040 Offset: 0x3E21141 VA: 0x3E21040
	|-List<BeforeRenderHelper.OrderBlock>.Exists
	|
	|-RVA: 0x3E240B0 Offset: 0x3E241B1 VA: 0x3E240B0
	|-List<Camera.RenderRequest>.Exists
	|
	|-RVA: 0x3E27190 Offset: 0x3E27291 VA: 0x3E27190
	|-List<CameraState.CustomBlendable>.Exists
	|
	|-RVA: 0x3E2A040 Offset: 0x3E2A141 VA: 0x3E2A040
	|-List<CinemachineClearShot.Pair>.Exists
	|
	|-RVA: 0x3E2CE50 Offset: 0x3E2CF51 VA: 0x3E2CE50
	|-List<CinemachineStateDrivenCamera.HashPair>.Exists
	|
	|-RVA: 0x3E2FE10 Offset: 0x3E2FF11 VA: 0x3E2FE10
	|-List<DelayedActionManager.DelegateInfo>.Exists
	|
	|-RVA: 0x3E330D0 Offset: 0x3E331D1 VA: 0x3E330D0
	|-List<Detail.AsyncResultInt>.Exists
	|
	|-RVA: 0x3E362C0 Offset: 0x3E363C1 VA: 0x3E362C0
	|-List<Detail.CppArray>.Exists
	|
	|-RVA: 0x3E393A0 Offset: 0x3E394A1 VA: 0x3E393A0
	|-List<Detail.NotificationEventInt>.Exists
	|
	|-RVA: 0x3E5B970 Offset: 0x3E5BA71 VA: 0x3E5B970
	|-List<DragonRideTargetGroup.ChainParam>.Exists
	|
	|-RVA: 0x3E5E9D0 Offset: 0x3E5EAD1 VA: 0x3E5E9D0
	|-List<GmapPathAdjuster.TargetModel>.Exists
	|
	|-RVA: 0x3E61BE0 Offset: 0x3E61CE1 VA: 0x3E61BE0
	|-List<GmapSpotAdjuster.TargetModel>.Exists
	|
	|-RVA: 0x3E64DF0 Offset: 0x3E64EF1 VA: 0x3E64DF0
	|-List<HubFastTravel.Location>.Exists
	|
	|-RVA: 0x3E680C0 Offset: 0x3E681C1 VA: 0x3E680C0
	|-List<HubLensFlare.Flare>.Exists
	|
	|-RVA: 0x3E6B300 Offset: 0x3E6B401 VA: 0x3E6B300
	|-List<InventoryPoolItemMenuContent.KindBgNameClass>.Exists
	|
	|-RVA: 0x3E6E1B0 Offset: 0x3E6E2B1 VA: 0x3E6E1B0
	|-List<Map.Pos>.Exists
	|
	|-RVA: 0x3E71010 Offset: 0x3E71111 VA: 0x3E71010
	|-List<MapImage.BackupTerrain>.Exists
	|
	|-RVA: 0x3E73EB0 Offset: 0x3E73FB1 VA: 0x3E73EB0
	|-List<MapImageRange.Pos>.Exists
	|
	|-RVA: 0x3E76EF0 Offset: 0x3E76FF1 VA: 0x3E76EF0
	|-List<MapMind.Target>.Exists
	|
	|-RVA: 0x3D86AE0 Offset: 0x3D86BE1 VA: 0x3D86AE0
	|-List<MapPanelDebug.Entity>.Exists
	|
	|-RVA: 0x3D89B20 Offset: 0x3D89C21 VA: 0x3D89B20
	|-List<NexRanking.Data>.Exists
	|
	|-RVA: 0x3D8C980 Offset: 0x3D8CA81 VA: 0x3D8C980
	|-List<NexVersus.RatingData>.Exists
	|
	|-RVA: 0x3D8F880 Offset: 0x3D8F981 VA: 0x3D8F880
	|-List<PackedPlayModeBuildLogs.RuntimeBuildLog>.Exists
	|
	|-RVA: 0x3D92950 Offset: 0x3D92A51 VA: 0x3D92950
	|-List<ParticleSystem.Particle>.Exists
	|
	|-RVA: 0x3D95AE0 Offset: 0x3D95BE1 VA: 0x3D95AE0
	|-List<RangeData.Offset>.Exists
	|
	|-RVA: 0x3D98AA0 Offset: 0x3D98BA1 VA: 0x3D98AA0
	|-List<RenderGraphDebugData.PassDebugData>.Exists
	|
	|-RVA: 0x3D9BD70 Offset: 0x3D9BE71 VA: 0x3D9BD70
	|-List<RenderGraphDebugData.ResourceDebugData>.Exists
	|
	|-RVA: 0x3D9EF50 Offset: 0x3D9F051 VA: 0x3D9EF50
	|-List<RingCleaningUnitSelectMenu.GodParam>.Exists
	|
	|-RVA: 0x3DA2050 Offset: 0x3DA2151 VA: 0x3DA2050
	|-List<ShadowUtility.Edge>.Exists
	|
	|-RVA: 0x3D14650 Offset: 0x3D14751 VA: 0x3D14650
	|-List<SkillArray.Entity>.Exists
	|
	|-RVA: 0x3D17750 Offset: 0x3D17851 VA: 0x3D17750
	|-List<TexturePacker_JsonArray.Frame>.Exists
	|
	|-RVA: 0x3D1ABE0 Offset: 0x3D1ACE1 VA: 0x3D1ABE0
	|-List<TimeNotificationBehaviour.NotificationEntry>.Exists
	|
	|-RVA: 0x3D1DE00 Offset: 0x3D1DF01 VA: 0x3D1DE00
	|-List<UnitySynchronizationContext.WorkRequest>.Exists
	|
	|-RVA: 0x3D20ED0 Offset: 0x3D20FD1 VA: 0x3D20ED0
	|-List<XmlSchemaObjectTable.XmlSchemaObjectEntry>.Exists
	|
	|-RVA: 0x3D23DF0 Offset: 0x3D23EF1 VA: 0x3D23DF0
	|-List<AssetBundleBuildMap.AssetBundleEntry.AssetPathString>.Exists
	|
	|-RVA: 0x3D26ED0 Offset: 0x3D26FD1 VA: 0x3D26ED0
	|-List<Detail.DataStore.DataStoreChangeMetaParamInt>.Exists
	|
	|-RVA: 0x3D2A110 Offset: 0x3D2A211 VA: 0x3D2A110
	|-List<Detail.DataStore.DataStoreDeleteParamInt>.Exists
	|
	|-RVA: 0x3D2D1F0 Offset: 0x3D2D2F1 VA: 0x3D2D1F0
	|-List<Detail.DataStore.DataStoreGetMetaParamInt>.Exists
	|
	|-RVA: 0x3D30560 Offset: 0x3D30661 VA: 0x3D30560
	|-List<Detail.DataStore.DataStoreMetaInfoInt>.Exists
	|
	|-RVA: 0x3CF4D20 Offset: 0x3CF4E21 VA: 0x3CF4D20
	|-List<Detail.DataStore.DataStorePasswordInfoInt>.Exists
	|
	|-RVA: 0x3CF7F00 Offset: 0x3CF8001 VA: 0x3CF7F00
	|-List<Detail.DataStore.DataStorePersistenceInfoInt>.Exists
	|
	|-RVA: 0x3CFB160 Offset: 0x3CFB261 VA: 0x3CFB160
	|-List<Detail.DataStore.DataStorePreparePostParamInt>.Exists
	|
	|-RVA: 0x3CFE340 Offset: 0x3CFE441 VA: 0x3CFE340
	|-List<Detail.DataStore.DataStoreRateObjectParamInt>.Exists
	|
	|-RVA: 0x3D01370 Offset: 0x3D01471 VA: 0x3D01370
	|-List<Detail.DataStore.DataStoreRatingInitParamInt>.Exists
	|
	|-RVA: 0x3D04410 Offset: 0x3D04511 VA: 0x3D04410
	|-List<Detail.DataStore.DataStoreRatingTargetInt>.Exists
	|
	|-RVA: 0x3D07590 Offset: 0x3D07691 VA: 0x3D07590
	|-List<Detail.Ranking.RankingCachedResultInt>.Exists
	|
	|-RVA: 0x3D0A8D0 Offset: 0x3D0A9D1 VA: 0x3D0A8D0
	|-List<Detail.Ranking.RankingOrderParamInt>.Exists
	|
	|-RVA: 0x3D0DA40 Offset: 0x3D0DB41 VA: 0x3D0DA40
	|-List<Detail.Ranking.RankingRankDataInt>.Exists
	|
	|-RVA: 0x3D11150 Offset: 0x3D11251 VA: 0x3D11150
	|-List<Detail.Ranking2.Ranking2ChartInfoInt>.Exists
	|
	|-RVA: 0x3D679C0 Offset: 0x3D67AC1 VA: 0x3D679C0
	|-List<Detail.Ranking2.Ranking2RankDataInt>.Exists
	|
	|-RVA: 0x3D6ACB0 Offset: 0x3D6ADB1 VA: 0x3D6ACB0
	|-List<Detail.Ranking2.Ranking2ScoreDataInt>.Exists
	|
	|-RVA: 0x3D6DCE0 Offset: 0x3D6DDE1 VA: 0x3D6DCE0
	|-List<Detail.Screening.ScreeningContextInfoInt>.Exists
	|
	|-RVA: 0x3D71100 Offset: 0x3D71201 VA: 0x3D71100
	|-List<Detail.Subscriber.SubscriberContentInt>.Exists
	|
	|-RVA: 0x3D746A0 Offset: 0x3D747A1 VA: 0x3D746A0
	|-List<Detail.Subscriber.SubscriberGetContentParamInt>.Exists
	|
	|-RVA: 0x3D77930 Offset: 0x3D77A31 VA: 0x3D77930
	|-List<Detail.Subscriber.SubscriberUserStatusInfoInt>.Exists
	|
	|-RVA: 0x3D7AC20 Offset: 0x3D7AD21 VA: 0x3D7AC20
	|-List<Detail.Subscriber.SubscriberUserStatusParamInt>.Exists
	|
	|-RVA: 0x3D7DC60 Offset: 0x3D7DD61 VA: 0x3D7DC60
	|-List<Detail.Utility.IntegerSettings>.Exists
	|
	|-RVA: 0x3D80AC0 Offset: 0x3D80BC1 VA: 0x3D80AC0
	|-List<Detail.Utility.UniqueIdInfoInt>.Exists
	|
	|-RVA: 0x3D839D0 Offset: 0x3D83AD1 VA: 0x3D839D0
	|-List<MapHistory.Rewind.LatestInspectorData>.Exists
	|
	|-RVA: 0x305FC90 Offset: 0x305FD91 VA: 0x305FC90
	|-List<MapHistory.Rewind.WorkTerrainData>.Exists
	|
	|-RVA: 0x3062C70 Offset: 0x3062D71 VA: 0x3062C70
	|-List<MapSkill.AroundCalculator.Result>.Exists
	|
	|-RVA: 0x3065D70 Offset: 0x3065E71 VA: 0x3065D70
	|-List<TargetPositionCache.CacheCurve.Item>.Exists
	|
	|-RVA: 0x3069130 Offset: 0x3069231 VA: 0x3069130
	|-List<TargetPositionCache.CacheEntry.RecordingItem>.Exists
	*/

	// RVA: -1 Offset: -1
	public T Find(Predicate<T> match) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3B0BA00 Offset: 0x3B0BB01 VA: 0x3B0BA00
	|-List<IntervalTree.Entry<object>>.Find
	|
	|-RVA: 0x3B0EAD0 Offset: 0x3B0EBD1 VA: 0x3B0EAD0
	|-List<KeyValuePair<DateTime, object>>.Find
	|
	|-RVA: 0x3B119F0 Offset: 0x3B11AF1 VA: 0x3B119F0
	|-List<KeyValuePair<int, object>>.Find
	|
	|-RVA: 0x3B14A50 Offset: 0x3B14B51 VA: 0x3B14A50
	|-List<KeyValuePair<object, ValueTuple<int, DateTime, object>>>.Find
	|
	|-RVA: 0x3B17B30 Offset: 0x3B17C31 VA: 0x3B17B30
	|-List<KeyValuePair<object, object>>.Find
	|
	|-RVA: 0x3B1AB90 Offset: 0x3B1AC91 VA: 0x3B1AB90
	|-List<CommonBattleSequence.Reliance<object>>.Find
	|
	|-RVA: 0x3B1DC60 Offset: 0x3B1DD61 VA: 0x3B1DC60
	|-List<RenderGraphResourcePool.ResourceLogInfo<object>>.Find
	|
	|-RVA: 0x3B20B80 Offset: 0x3B20C81 VA: 0x3B20B80
	|-List<ValueTuple<int, object>>.Find
	|
	|-RVA: 0x3DE17A0 Offset: 0x3DE18A1 VA: 0x3DE17A0
	|-List<ValueTuple<Int32Enum, int>>.Find
	|
	|-RVA: 0x3DE4760 Offset: 0x3DE4861 VA: 0x3DE4760
	|-List<ValueTuple<object, ValueTuple<object, int>>>.Find
	|
	|-RVA: 0x3DE7830 Offset: 0x3DE7931 VA: 0x3DE7830
	|-List<ValueTuple<object, int>>.Find
	|
	|-RVA: 0x3DEA7E0 Offset: 0x3DEA8E1 VA: 0x3DEA7E0
	|-List<ValueTuple<Vector3, float>>.Find
	|
	|-RVA: 0x3DED750 Offset: 0x3DED851 VA: 0x3DED750
	|-List<ValueTuple<object, Int32Enum, int>>.Find
	|
	|-RVA: 0x3DF07B0 Offset: 0x3DF08B1 VA: 0x3DF07B0
	|-List<ValueTuple<object, int, int, int>>.Find
	|
	|-RVA: 0x3DF3810 Offset: 0x3DF3911 VA: 0x3DF3810
	|-List<AnimatorClipInfo>.Find
	|
	|-RVA: 0x3DF67D0 Offset: 0x3DF68D1 VA: 0x3DF67D0
	|-List<AsyncOperationHandle>.Find
	|
	|-RVA: 0x3DF99D0 Offset: 0x3DF9AD1 VA: 0x3DF99D0
	|-List<BoneWeight>.Find
	|
	|-RVA: 0x3DFCA30 Offset: 0x3DFCB31 VA: 0x3DFCA30
	|-List<bool>.Find
	|
	|-RVA: 0x3E79F80 Offset: 0x3E7A081 VA: 0x3E79F80
	|-List<byte>.Find
	|
	|-RVA: 0x3E7CE00 Offset: 0x3E7CF01 VA: 0x3E7CE00
	|-List<CameraInfo>.Find
	|
	|-RVA: 0x3E7FCB0 Offset: 0x3E7FDB1 VA: 0x3E7FCB0
	|-List<char>.Find
	|
	|-RVA: 0x3E82BB0 Offset: 0x3E82CB1 VA: 0x3E82BB0
	|-List<Color>.Find
	|
	|-RVA: 0x3E85AB0 Offset: 0x3E85BB1 VA: 0x3E85AB0
	|-List<Color32>.Find
	|
	|-RVA: 0x3E88930 Offset: 0x3E88A31 VA: 0x3E88930
	|-List<ConstraintSource>.Find
	|
	|-RVA: 0x3E8B990 Offset: 0x3E8BA91 VA: 0x3E8B990
	|-List<ContourVertex>.Find
	|
	|-RVA: 0x3E8EB90 Offset: 0x3E8EC91 VA: 0x3E8EB90
	|-List<DataStoreRatingInfo>.Find
	|
	|-RVA: 0x3E91BD0 Offset: 0x3E91CD1 VA: 0x3E91BD0
	|-List<DataStoreResult>.Find
	|
	|-RVA: 0x3E949E0 Offset: 0x3E94AE1 VA: 0x3E949E0
	|-List<DateTime>.Find
	|
	|-RVA: 0x3E97840 Offset: 0x3E97941 VA: 0x3E97840
	|-List<DateTimeOffset>.Find
	|
	|-RVA: 0x3E9A720 Offset: 0x3E9A821 VA: 0x3E9A720
	|-List<Decimal>.Find
	|
	|-RVA: 0x3E9D820 Offset: 0x3E9D921 VA: 0x3E9D820
	|-List<DiagnosticEvent>.Find
	|
	|-RVA: 0x3EA0A00 Offset: 0x3EA0B01 VA: 0x3EA0A00
	|-List<double>.Find
	|
	|-RVA: 0x3EA3A10 Offset: 0x3EA3B11 VA: 0x3EA3A10
	|-List<Friend>.Find
	|
	|-RVA: 0x3EA6BF0 Offset: 0x3EA6CF1 VA: 0x3EA6BF0
	|-List<GlyphRect>.Find
	|
	|-RVA: 0x3E11890 Offset: 0x3E11991 VA: 0x3E11890
	|-List<HubDisposData>.Find
	|-List<object>.Find
	|-List<ScriptableRenderPass>.Find
	|-List<Toggle>.Find
	|-List<AssetBundleBuildMap.AssetBundleEntry>.Find
	|-List<DLCManager.MountData>.Find
	|
	|-RVA: 0x3EA9A80 Offset: 0x3EA9B81 VA: 0x3EA9A80
	|-List<short>.Find
	|
	|-RVA: 0x3EAC880 Offset: 0x3EAC981 VA: 0x3EAC880
	|-List<int>.Find
	|
	|-RVA: 0x3EAF680 Offset: 0x3EAF781 VA: 0x3EAF680
	|-List<Int32Enum>.Find
	|
	|-RVA: 0x3EB2480 Offset: 0x3EB2581 VA: 0x3EB2480
	|-List<long>.Find
	|
	|-RVA: 0x3DFF850 Offset: 0x3DFF951 VA: 0x3DFF850
	|-List<IntPtr>.Find
	|
	|-RVA: 0x3E026C0 Offset: 0x3E027C1 VA: 0x3E026C0
	|-List<InterpretedFrameInfo>.Find
	|
	|-RVA: 0x3E05710 Offset: 0x3E05811 VA: 0x3E05710
	|-List<IntervalTreeNode>.Find
	|
	|-RVA: 0x3E08750 Offset: 0x3E08851 VA: 0x3E08750
	|-List<LengthLimitProperties>.Find
	|
	|-RVA: 0x3E0B560 Offset: 0x3E0B661 VA: 0x3E0B560
	|-List<MapPos>.Find
	|
	|-RVA: 0x3E0E650 Offset: 0x3E0E751 VA: 0x3E0E650
	|-List<Matrix4x4>.Find
	|
	|-RVA: 0x3E14920 Offset: 0x3E14A21 VA: 0x3E14920
	|-List<ObjectInitializationData>.Find
	|
	|-RVA: 0x3E17CA0 Offset: 0x3E17DA1 VA: 0x3E17CA0
	|-List<PlayableBinding>.Find
	|
	|-RVA: 0x3E1AF70 Offset: 0x3E1B071 VA: 0x3E1AF70
	|-List<PlayerLoopSystem>.Find
	|
	|-RVA: 0x3DA5410 Offset: 0x3DA5511 VA: 0x3DA5410
	|-List<PlayerLoopSystemInternal>.Find
	|
	|-RVA: 0x3DA85F0 Offset: 0x3DA86F1 VA: 0x3DA85F0
	|-List<RangePositionInfo>.Find
	|
	|-RVA: 0x3DAB4A0 Offset: 0x3DAB5A1 VA: 0x3DAB4A0
	|-List<Ranking2ChartInfoInput>.Find
	|
	|-RVA: 0x3DAE540 Offset: 0x3DAE641 VA: 0x3DAE540
	|-List<RaycastHit2D>.Find
	|
	|-RVA: 0x3DB1AB0 Offset: 0x3DB1BB1 VA: 0x3DB1AB0
	|-List<RaycastResult>.Find
	|
	|-RVA: 0x3DB4FE0 Offset: 0x3DB50E1 VA: 0x3DB4FE0
	|-List<Rect>.Find
	|
	|-RVA: 0x3DB7EE0 Offset: 0x3DB7FE1 VA: 0x3DB7EE0
	|-List<RendererListHandle>.Find
	|
	|-RVA: 0x3DBACF0 Offset: 0x3DBADF1 VA: 0x3DBACF0
	|-List<ResourceHandle>.Find
	|
	|-RVA: 0x3DBDB00 Offset: 0x3DBDC01 VA: 0x3DBDB00
	|-List<sbyte>.Find
	|
	|-RVA: 0x3DC0910 Offset: 0x3DC0A11 VA: 0x3DC0910
	|-List<ShaderTagId>.Find
	|
	|-RVA: 0x3E3C580 Offset: 0x3E3C681 VA: 0x3E3C580
	|-List<float>.Find
	|
	|-RVA: 0x3E3F960 Offset: 0x3E3FA61 VA: 0x3E3F960
	|-List<SphericalHarmonicsL2>.Find
	|
	|-RVA: 0x3E432C0 Offset: 0x3E433C1 VA: 0x3E432C0
	|-List<SubMeshDescriptor>.Find
	|
	|-RVA: 0x3E464D0 Offset: 0x3E465D1 VA: 0x3E464D0
	|-List<TablePair>.Find
	|
	|-RVA: 0x3E49380 Offset: 0x3E49481 VA: 0x3E49380
	|-List<TimeSpan>.Find
	|
	|-RVA: 0x3E4C260 Offset: 0x3E4C361 VA: 0x3E4C260
	|-List<UICharInfo>.Find
	|
	|-RVA: 0x3E4F1C0 Offset: 0x3E4F2C1 VA: 0x3E4F1C0
	|-List<UILineInfo>.Find
	|
	|-RVA: 0x3E52620 Offset: 0x3E52721 VA: 0x3E52620
	|-List<UIVertex>.Find
	|
	|-RVA: 0x3E55D30 Offset: 0x3E55E31 VA: 0x3E55D30
	|-List<ushort>.Find
	|
	|-RVA: 0x3E58B30 Offset: 0x3E58C31 VA: 0x3E58B30
	|-List<uint>.Find
	|
	|-RVA: 0x3DC3720 Offset: 0x3DC3821 VA: 0x3DC3720
	|-List<ulong>.Find
	|
	|-RVA: 0x3DC6560 Offset: 0x3DC6661 VA: 0x3DC6560
	|-List<Vector2>.Find
	|
	|-RVA: 0x3DC94C0 Offset: 0x3DC95C1 VA: 0x3DC94C0
	|-List<Vector3>.Find
	|
	|-RVA: 0x3DCC4D0 Offset: 0x3DCC5D1 VA: 0x3DCC4D0
	|-List<Vector4>.Find
	|
	|-RVA: 0x3DCF420 Offset: 0x3DCF521 VA: 0x3DCF420
	|-List<VertexAttributeDescriptor>.Find
	|
	|-RVA: 0x3DD2320 Offset: 0x3DD2421 VA: 0x3DD2320
	|-List<X509ChainStatus>.Find
	|
	|-RVA: 0x3DD5400 Offset: 0x3DD5501 VA: 0x3DD5400
	|-List<XRView>.Find
	|
	|-RVA: 0x3DD8630 Offset: 0x3DD8731 VA: 0x3DD8630
	|-List<AmiiboSequence.GainItemData>.Find
	|
	|-RVA: 0x3DDB730 Offset: 0x3DDB831 VA: 0x3DDB730
	|-List<AnimationOutputWeightProcessor.WeightInfo>.Find
	|
	|-RVA: 0x3DDE8F0 Offset: 0x3DDE9F1 VA: 0x3DDE8F0
	|-List<ArenaOrderSequence.GodInfo>.Find
	|
	|-RVA: 0x3E1E150 Offset: 0x3E1E251 VA: 0x3E1E150
	|-List<BattleInfo.SupportData>.Find
	|
	|-RVA: 0x3E21070 Offset: 0x3E21171 VA: 0x3E21070
	|-List<BeforeRenderHelper.OrderBlock>.Find
	|
	|-RVA: 0x3E240E0 Offset: 0x3E241E1 VA: 0x3E240E0
	|-List<Camera.RenderRequest>.Find
	|
	|-RVA: 0x3E271C0 Offset: 0x3E272C1 VA: 0x3E271C0
	|-List<CameraState.CustomBlendable>.Find
	|
	|-RVA: 0x3E2A070 Offset: 0x3E2A171 VA: 0x3E2A070
	|-List<CinemachineClearShot.Pair>.Find
	|
	|-RVA: 0x3E2CE80 Offset: 0x3E2CF81 VA: 0x3E2CE80
	|-List<CinemachineStateDrivenCamera.HashPair>.Find
	|
	|-RVA: 0x3E2FE40 Offset: 0x3E2FF41 VA: 0x3E2FE40
	|-List<DelayedActionManager.DelegateInfo>.Find
	|
	|-RVA: 0x3E33100 Offset: 0x3E33201 VA: 0x3E33100
	|-List<Detail.AsyncResultInt>.Find
	|
	|-RVA: 0x3E362F0 Offset: 0x3E363F1 VA: 0x3E362F0
	|-List<Detail.CppArray>.Find
	|
	|-RVA: 0x3E393D0 Offset: 0x3E394D1 VA: 0x3E393D0
	|-List<Detail.NotificationEventInt>.Find
	|
	|-RVA: 0x3E5B9A0 Offset: 0x3E5BAA1 VA: 0x3E5B9A0
	|-List<DragonRideTargetGroup.ChainParam>.Find
	|
	|-RVA: 0x3E5EA00 Offset: 0x3E5EB01 VA: 0x3E5EA00
	|-List<GmapPathAdjuster.TargetModel>.Find
	|
	|-RVA: 0x3E61C10 Offset: 0x3E61D11 VA: 0x3E61C10
	|-List<GmapSpotAdjuster.TargetModel>.Find
	|
	|-RVA: 0x3E64E20 Offset: 0x3E64F21 VA: 0x3E64E20
	|-List<HubFastTravel.Location>.Find
	|
	|-RVA: 0x3E680F0 Offset: 0x3E681F1 VA: 0x3E680F0
	|-List<HubLensFlare.Flare>.Find
	|
	|-RVA: 0x3E6B330 Offset: 0x3E6B431 VA: 0x3E6B330
	|-List<InventoryPoolItemMenuContent.KindBgNameClass>.Find
	|
	|-RVA: 0x3E6E1E0 Offset: 0x3E6E2E1 VA: 0x3E6E1E0
	|-List<Map.Pos>.Find
	|
	|-RVA: 0x3E71040 Offset: 0x3E71141 VA: 0x3E71040
	|-List<MapImage.BackupTerrain>.Find
	|
	|-RVA: 0x3E73EE0 Offset: 0x3E73FE1 VA: 0x3E73EE0
	|-List<MapImageRange.Pos>.Find
	|
	|-RVA: 0x3E76F20 Offset: 0x3E77021 VA: 0x3E76F20
	|-List<MapMind.Target>.Find
	|
	|-RVA: 0x3D86B10 Offset: 0x3D86C11 VA: 0x3D86B10
	|-List<MapPanelDebug.Entity>.Find
	|
	|-RVA: 0x3D89B50 Offset: 0x3D89C51 VA: 0x3D89B50
	|-List<NexRanking.Data>.Find
	|
	|-RVA: 0x3D8C9B0 Offset: 0x3D8CAB1 VA: 0x3D8C9B0
	|-List<NexVersus.RatingData>.Find
	|
	|-RVA: 0x3D8F8B0 Offset: 0x3D8F9B1 VA: 0x3D8F8B0
	|-List<PackedPlayModeBuildLogs.RuntimeBuildLog>.Find
	|
	|-RVA: 0x3D92980 Offset: 0x3D92A81 VA: 0x3D92980
	|-List<ParticleSystem.Particle>.Find
	|
	|-RVA: 0x3D95B10 Offset: 0x3D95C11 VA: 0x3D95B10
	|-List<RangeData.Offset>.Find
	|
	|-RVA: 0x3D98AD0 Offset: 0x3D98BD1 VA: 0x3D98AD0
	|-List<RenderGraphDebugData.PassDebugData>.Find
	|
	|-RVA: 0x3D9BDA0 Offset: 0x3D9BEA1 VA: 0x3D9BDA0
	|-List<RenderGraphDebugData.ResourceDebugData>.Find
	|
	|-RVA: 0x3D9EF80 Offset: 0x3D9F081 VA: 0x3D9EF80
	|-List<RingCleaningUnitSelectMenu.GodParam>.Find
	|
	|-RVA: 0x3DA2080 Offset: 0x3DA2181 VA: 0x3DA2080
	|-List<ShadowUtility.Edge>.Find
	|
	|-RVA: 0x3D14680 Offset: 0x3D14781 VA: 0x3D14680
	|-List<SkillArray.Entity>.Find
	|
	|-RVA: 0x3D17780 Offset: 0x3D17881 VA: 0x3D17780
	|-List<TexturePacker_JsonArray.Frame>.Find
	|
	|-RVA: 0x3D1AC10 Offset: 0x3D1AD11 VA: 0x3D1AC10
	|-List<TimeNotificationBehaviour.NotificationEntry>.Find
	|
	|-RVA: 0x3D1DE30 Offset: 0x3D1DF31 VA: 0x3D1DE30
	|-List<UnitySynchronizationContext.WorkRequest>.Find
	|
	|-RVA: 0x3D20F00 Offset: 0x3D21001 VA: 0x3D20F00
	|-List<XmlSchemaObjectTable.XmlSchemaObjectEntry>.Find
	|
	|-RVA: 0x3D23E20 Offset: 0x3D23F21 VA: 0x3D23E20
	|-List<AssetBundleBuildMap.AssetBundleEntry.AssetPathString>.Find
	|
	|-RVA: 0x3D26F00 Offset: 0x3D27001 VA: 0x3D26F00
	|-List<Detail.DataStore.DataStoreChangeMetaParamInt>.Find
	|
	|-RVA: 0x3D2A140 Offset: 0x3D2A241 VA: 0x3D2A140
	|-List<Detail.DataStore.DataStoreDeleteParamInt>.Find
	|
	|-RVA: 0x3D2D220 Offset: 0x3D2D321 VA: 0x3D2D220
	|-List<Detail.DataStore.DataStoreGetMetaParamInt>.Find
	|
	|-RVA: 0x3D30590 Offset: 0x3D30691 VA: 0x3D30590
	|-List<Detail.DataStore.DataStoreMetaInfoInt>.Find
	|
	|-RVA: 0x3CF4D50 Offset: 0x3CF4E51 VA: 0x3CF4D50
	|-List<Detail.DataStore.DataStorePasswordInfoInt>.Find
	|
	|-RVA: 0x3CF7F30 Offset: 0x3CF8031 VA: 0x3CF7F30
	|-List<Detail.DataStore.DataStorePersistenceInfoInt>.Find
	|
	|-RVA: 0x3CFB190 Offset: 0x3CFB291 VA: 0x3CFB190
	|-List<Detail.DataStore.DataStorePreparePostParamInt>.Find
	|
	|-RVA: 0x3CFE370 Offset: 0x3CFE471 VA: 0x3CFE370
	|-List<Detail.DataStore.DataStoreRateObjectParamInt>.Find
	|
	|-RVA: 0x3D013A0 Offset: 0x3D014A1 VA: 0x3D013A0
	|-List<Detail.DataStore.DataStoreRatingInitParamInt>.Find
	|
	|-RVA: 0x3D04440 Offset: 0x3D04541 VA: 0x3D04440
	|-List<Detail.DataStore.DataStoreRatingTargetInt>.Find
	|
	|-RVA: 0x3D075C0 Offset: 0x3D076C1 VA: 0x3D075C0
	|-List<Detail.Ranking.RankingCachedResultInt>.Find
	|
	|-RVA: 0x3D0A900 Offset: 0x3D0AA01 VA: 0x3D0A900
	|-List<Detail.Ranking.RankingOrderParamInt>.Find
	|
	|-RVA: 0x3D0DA70 Offset: 0x3D0DB71 VA: 0x3D0DA70
	|-List<Detail.Ranking.RankingRankDataInt>.Find
	|
	|-RVA: 0x3D11180 Offset: 0x3D11281 VA: 0x3D11180
	|-List<Detail.Ranking2.Ranking2ChartInfoInt>.Find
	|
	|-RVA: 0x3D679F0 Offset: 0x3D67AF1 VA: 0x3D679F0
	|-List<Detail.Ranking2.Ranking2RankDataInt>.Find
	|
	|-RVA: 0x3D6ACE0 Offset: 0x3D6ADE1 VA: 0x3D6ACE0
	|-List<Detail.Ranking2.Ranking2ScoreDataInt>.Find
	|
	|-RVA: 0x3D6DD10 Offset: 0x3D6DE11 VA: 0x3D6DD10
	|-List<Detail.Screening.ScreeningContextInfoInt>.Find
	|
	|-RVA: 0x3D71130 Offset: 0x3D71231 VA: 0x3D71130
	|-List<Detail.Subscriber.SubscriberContentInt>.Find
	|
	|-RVA: 0x3D746D0 Offset: 0x3D747D1 VA: 0x3D746D0
	|-List<Detail.Subscriber.SubscriberGetContentParamInt>.Find
	|
	|-RVA: 0x3D77960 Offset: 0x3D77A61 VA: 0x3D77960
	|-List<Detail.Subscriber.SubscriberUserStatusInfoInt>.Find
	|
	|-RVA: 0x3D7AC50 Offset: 0x3D7AD51 VA: 0x3D7AC50
	|-List<Detail.Subscriber.SubscriberUserStatusParamInt>.Find
	|
	|-RVA: 0x3D7DC90 Offset: 0x3D7DD91 VA: 0x3D7DC90
	|-List<Detail.Utility.IntegerSettings>.Find
	|
	|-RVA: 0x3D80AF0 Offset: 0x3D80BF1 VA: 0x3D80AF0
	|-List<Detail.Utility.UniqueIdInfoInt>.Find
	|
	|-RVA: 0x3D83A00 Offset: 0x3D83B01 VA: 0x3D83A00
	|-List<MapHistory.Rewind.LatestInspectorData>.Find
	|
	|-RVA: 0x305FCC0 Offset: 0x305FDC1 VA: 0x305FCC0
	|-List<MapHistory.Rewind.WorkTerrainData>.Find
	|
	|-RVA: 0x3062CA0 Offset: 0x3062DA1 VA: 0x3062CA0
	|-List<MapSkill.AroundCalculator.Result>.Find
	|
	|-RVA: 0x3065DA0 Offset: 0x3065EA1 VA: 0x3065DA0
	|-List<TargetPositionCache.CacheCurve.Item>.Find
	|
	|-RVA: 0x3069160 Offset: 0x3069261 VA: 0x3069160
	|-List<TargetPositionCache.CacheEntry.RecordingItem>.Find
	*/

	// RVA: -1 Offset: -1
	public List<T> FindAll(Predicate<T> match) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3B0BB10 Offset: 0x3B0BC11 VA: 0x3B0BB10
	|-List<IntervalTree.Entry<object>>.FindAll
	|
	|-RVA: 0x3B0EBB0 Offset: 0x3B0ECB1 VA: 0x3B0EBB0
	|-List<KeyValuePair<DateTime, object>>.FindAll
	|
	|-RVA: 0x3B11AD0 Offset: 0x3B11BD1 VA: 0x3B11AD0
	|-List<KeyValuePair<int, object>>.FindAll
	|
	|-RVA: 0x3B14B60 Offset: 0x3B14C61 VA: 0x3B14B60
	|-List<KeyValuePair<object, ValueTuple<int, DateTime, object>>>.FindAll
	|
	|-RVA: 0x3B17C10 Offset: 0x3B17D11 VA: 0x3B17C10
	|-List<KeyValuePair<object, object>>.FindAll
	|
	|-RVA: 0x3B1ACA0 Offset: 0x3B1ADA1 VA: 0x3B1ACA0
	|-List<CommonBattleSequence.Reliance<object>>.FindAll
	|
	|-RVA: 0x3B1DD40 Offset: 0x3B1DE41 VA: 0x3B1DD40
	|-List<RenderGraphResourcePool.ResourceLogInfo<object>>.FindAll
	|
	|-RVA: 0x3B20C60 Offset: 0x3B20D61 VA: 0x3B20C60
	|-List<ValueTuple<int, object>>.FindAll
	|
	|-RVA: 0x3DE1880 Offset: 0x3DE1981 VA: 0x3DE1880
	|-List<ValueTuple<Int32Enum, int>>.FindAll
	|
	|-RVA: 0x3DE4870 Offset: 0x3DE4971 VA: 0x3DE4870
	|-List<ValueTuple<object, ValueTuple<object, int>>>.FindAll
	|
	|-RVA: 0x3DE7910 Offset: 0x3DE7A11 VA: 0x3DE7910
	|-List<ValueTuple<object, int>>.FindAll
	|
	|-RVA: 0x3DEA8E0 Offset: 0x3DEA9E1 VA: 0x3DEA8E0
	|-List<ValueTuple<Vector3, float>>.FindAll
	|
	|-RVA: 0x3DED830 Offset: 0x3DED931 VA: 0x3DED830
	|-List<ValueTuple<object, Int32Enum, int>>.FindAll
	|
	|-RVA: 0x3DF08C0 Offset: 0x3DF09C1 VA: 0x3DF08C0
	|-List<ValueTuple<object, int, int, int>>.FindAll
	|
	|-RVA: 0x3DF38F0 Offset: 0x3DF39F1 VA: 0x3DF38F0
	|-List<AnimatorClipInfo>.FindAll
	|
	|-RVA: 0x3DF68E0 Offset: 0x3DF69E1 VA: 0x3DF68E0
	|-List<AsyncOperationHandle>.FindAll
	|
	|-RVA: 0x3DF9AE0 Offset: 0x3DF9BE1 VA: 0x3DF9AE0
	|-List<BoneWeight>.FindAll
	|
	|-RVA: 0x3DFCB10 Offset: 0x3DFCC11 VA: 0x3DFCB10
	|-List<bool>.FindAll
	|
	|-RVA: 0x3E7A060 Offset: 0x3E7A161 VA: 0x3E7A060
	|-List<byte>.FindAll
	|
	|-RVA: 0x3E7CEE0 Offset: 0x3E7CFE1 VA: 0x3E7CEE0
	|-List<CameraInfo>.FindAll
	|
	|-RVA: 0x3E7FD90 Offset: 0x3E7FE91 VA: 0x3E7FD90
	|-List<char>.FindAll
	|
	|-RVA: 0x3E82CB0 Offset: 0x3E82DB1 VA: 0x3E82CB0
	|-List<Color>.FindAll
	|
	|-RVA: 0x3E85B90 Offset: 0x3E85C91 VA: 0x3E85B90
	|-List<Color32>.FindAll
	|
	|-RVA: 0x3E88A10 Offset: 0x3E88B11 VA: 0x3E88A10
	|-List<ConstraintSource>.FindAll
	|
	|-RVA: 0x3E8BAA0 Offset: 0x3E8BBA1 VA: 0x3E8BAA0
	|-List<ContourVertex>.FindAll
	|
	|-RVA: 0x3E8ECA0 Offset: 0x3E8EDA1 VA: 0x3E8ECA0
	|-List<DataStoreRatingInfo>.FindAll
	|
	|-RVA: 0x3E91CB0 Offset: 0x3E91DB1 VA: 0x3E91CB0
	|-List<DataStoreResult>.FindAll
	|
	|-RVA: 0x3E94AC0 Offset: 0x3E94BC1 VA: 0x3E94AC0
	|-List<DateTime>.FindAll
	|
	|-RVA: 0x3E97920 Offset: 0x3E97A21 VA: 0x3E97920
	|-List<DateTimeOffset>.FindAll
	|
	|-RVA: 0x3E9A800 Offset: 0x3E9A901 VA: 0x3E9A800
	|-List<Decimal>.FindAll
	|
	|-RVA: 0x3E9D960 Offset: 0x3E9DA61 VA: 0x3E9D960
	|-List<DiagnosticEvent>.FindAll
	|
	|-RVA: 0x3EA0AE0 Offset: 0x3EA0BE1 VA: 0x3EA0AE0
	|-List<double>.FindAll
	|
	|-RVA: 0x3EA3B40 Offset: 0x3EA3C41 VA: 0x3EA3B40
	|-List<Friend>.FindAll
	|
	|-RVA: 0x3EA6CD0 Offset: 0x3EA6DD1 VA: 0x3EA6CD0
	|-List<GlyphRect>.FindAll
	|
	|-RVA: 0x3E11970 Offset: 0x3E11A71 VA: 0x3E11970
	|-List<HubDisposData>.FindAll
	|-List<ItemData>.FindAll
	|-List<JobData>.FindAll
	|-List<object>.FindAll
	|
	|-RVA: 0x3EA9B60 Offset: 0x3EA9C61 VA: 0x3EA9B60
	|-List<short>.FindAll
	|
	|-RVA: 0x3EAC960 Offset: 0x3EACA61 VA: 0x3EAC960
	|-List<int>.FindAll
	|
	|-RVA: 0x3EAF760 Offset: 0x3EAF861 VA: 0x3EAF760
	|-List<Int32Enum>.FindAll
	|
	|-RVA: 0x3EB2560 Offset: 0x3EB2661 VA: 0x3EB2560
	|-List<long>.FindAll
	|
	|-RVA: 0x3DFF930 Offset: 0x3DFFA31 VA: 0x3DFF930
	|-List<IntPtr>.FindAll
	|
	|-RVA: 0x3E027A0 Offset: 0x3E028A1 VA: 0x3E027A0
	|-List<InterpretedFrameInfo>.FindAll
	|
	|-RVA: 0x3E05820 Offset: 0x3E05921 VA: 0x3E05820
	|-List<IntervalTreeNode>.FindAll
	|
	|-RVA: 0x3E08830 Offset: 0x3E08931 VA: 0x3E08830
	|-List<LengthLimitProperties>.FindAll
	|
	|-RVA: 0x3E0B640 Offset: 0x3E0B741 VA: 0x3E0B640
	|-List<MapPos>.FindAll
	|
	|-RVA: 0x3E0E7A0 Offset: 0x3E0E8A1 VA: 0x3E0E7A0
	|-List<Matrix4x4>.FindAll
	|
	|-RVA: 0x3E14A60 Offset: 0x3E14B61 VA: 0x3E14A60
	|-List<ObjectInitializationData>.FindAll
	|
	|-RVA: 0x3E17DB0 Offset: 0x3E17EB1 VA: 0x3E17DB0
	|-List<PlayableBinding>.FindAll
	|
	|-RVA: 0x3E1B0A0 Offset: 0x3E1B1A1 VA: 0x3E1B0A0
	|-List<PlayerLoopSystem>.FindAll
	|
	|-RVA: 0x3DA5540 Offset: 0x3DA5641 VA: 0x3DA5540
	|-List<PlayerLoopSystemInternal>.FindAll
	|
	|-RVA: 0x3DA86D0 Offset: 0x3DA87D1 VA: 0x3DA86D0
	|-List<RangePositionInfo>.FindAll
	|
	|-RVA: 0x3DAB580 Offset: 0x3DAB681 VA: 0x3DAB580
	|-List<Ranking2ChartInfoInput>.FindAll
	|
	|-RVA: 0x3DAE670 Offset: 0x3DAE771 VA: 0x3DAE670
	|-List<RaycastHit2D>.FindAll
	|
	|-RVA: 0x3DB1C20 Offset: 0x3DB1D21 VA: 0x3DB1C20
	|-List<RaycastResult>.FindAll
	|
	|-RVA: 0x3DB50E0 Offset: 0x3DB51E1 VA: 0x3DB50E0
	|-List<Rect>.FindAll
	|
	|-RVA: 0x3DB7FC0 Offset: 0x3DB80C1 VA: 0x3DB7FC0
	|-List<RendererListHandle>.FindAll
	|
	|-RVA: 0x3DBADD0 Offset: 0x3DBAED1 VA: 0x3DBADD0
	|-List<ResourceHandle>.FindAll
	|
	|-RVA: 0x3DBDBE0 Offset: 0x3DBDCE1 VA: 0x3DBDBE0
	|-List<sbyte>.FindAll
	|
	|-RVA: 0x3DC09F0 Offset: 0x3DC0AF1 VA: 0x3DC09F0
	|-List<ShaderTagId>.FindAll
	|
	|-RVA: 0x3E3C660 Offset: 0x3E3C761 VA: 0x3E3C660
	|-List<float>.FindAll
	|
	|-RVA: 0x3E3FB30 Offset: 0x3E3FC31 VA: 0x3E3FB30
	|-List<SphericalHarmonicsL2>.FindAll
	|
	|-RVA: 0x3E43400 Offset: 0x3E43501 VA: 0x3E43400
	|-List<SubMeshDescriptor>.FindAll
	|
	|-RVA: 0x3E465B0 Offset: 0x3E466B1 VA: 0x3E465B0
	|-List<TablePair>.FindAll
	|
	|-RVA: 0x3E49460 Offset: 0x3E49561 VA: 0x3E49460
	|-List<TimeSpan>.FindAll
	|
	|-RVA: 0x3E4C360 Offset: 0x3E4C461 VA: 0x3E4C360
	|-List<UICharInfo>.FindAll
	|
	|-RVA: 0x3E4F2A0 Offset: 0x3E4F3A1 VA: 0x3E4F2A0
	|-List<UILineInfo>.FindAll
	|
	|-RVA: 0x3E527F0 Offset: 0x3E528F1 VA: 0x3E527F0
	|-List<UIVertex>.FindAll
	|
	|-RVA: 0x3E55E10 Offset: 0x3E55F11 VA: 0x3E55E10
	|-List<ushort>.FindAll
	|
	|-RVA: 0x3E58C10 Offset: 0x3E58D11 VA: 0x3E58C10
	|-List<uint>.FindAll
	|
	|-RVA: 0x3DC3800 Offset: 0x3DC3901 VA: 0x3DC3800
	|-List<ulong>.FindAll
	|
	|-RVA: 0x3DC6650 Offset: 0x3DC6751 VA: 0x3DC6650
	|-List<Vector2>.FindAll
	|
	|-RVA: 0x3DC95C0 Offset: 0x3DC96C1 VA: 0x3DC95C0
	|-List<Vector3>.FindAll
	|
	|-RVA: 0x3DCC5D0 Offset: 0x3DCC6D1 VA: 0x3DCC5D0
	|-List<Vector4>.FindAll
	|
	|-RVA: 0x3DCF500 Offset: 0x3DCF601 VA: 0x3DCF500
	|-List<VertexAttributeDescriptor>.FindAll
	|
	|-RVA: 0x3DD2400 Offset: 0x3DD2501 VA: 0x3DD2400
	|-List<X509ChainStatus>.FindAll
	|
	|-RVA: 0x3DD5550 Offset: 0x3DD5651 VA: 0x3DD5550
	|-List<XRView>.FindAll
	|
	|-RVA: 0x3DD8710 Offset: 0x3DD8811 VA: 0x3DD8710
	|-List<AmiiboSequence.GainItemData>.FindAll
	|
	|-RVA: 0x3DDB860 Offset: 0x3DDB961 VA: 0x3DDB860
	|-List<AnimationOutputWeightProcessor.WeightInfo>.FindAll
	|
	|-RVA: 0x3DDE9D0 Offset: 0x3DDEAD1 VA: 0x3DDE9D0
	|-List<ArenaOrderSequence.GodInfo>.FindAll
	|
	|-RVA: 0x3E1E230 Offset: 0x3E1E331 VA: 0x3E1E230
	|-List<BattleInfo.SupportData>.FindAll
	|
	|-RVA: 0x3E21150 Offset: 0x3E21251 VA: 0x3E21150
	|-List<BeforeRenderHelper.OrderBlock>.FindAll
	|
	|-RVA: 0x3E241F0 Offset: 0x3E242F1 VA: 0x3E241F0
	|-List<Camera.RenderRequest>.FindAll
	|
	|-RVA: 0x3E272A0 Offset: 0x3E273A1 VA: 0x3E272A0
	|-List<CameraState.CustomBlendable>.FindAll
	|
	|-RVA: 0x3E2A150 Offset: 0x3E2A251 VA: 0x3E2A150
	|-List<CinemachineClearShot.Pair>.FindAll
	|
	|-RVA: 0x3E2CF60 Offset: 0x3E2D061 VA: 0x3E2CF60
	|-List<CinemachineStateDrivenCamera.HashPair>.FindAll
	|
	|-RVA: 0x3E2FF50 Offset: 0x3E30051 VA: 0x3E2FF50
	|-List<DelayedActionManager.DelegateInfo>.FindAll
	|
	|-RVA: 0x3E33240 Offset: 0x3E33341 VA: 0x3E33240
	|-List<Detail.AsyncResultInt>.FindAll
	|
	|-RVA: 0x3E363D0 Offset: 0x3E364D1 VA: 0x3E363D0
	|-List<Detail.CppArray>.FindAll
	|
	|-RVA: 0x3E39510 Offset: 0x3E39611 VA: 0x3E39510
	|-List<Detail.NotificationEventInt>.FindAll
	|
	|-RVA: 0x3E5BA80 Offset: 0x3E5BB81 VA: 0x3E5BA80
	|-List<DragonRideTargetGroup.ChainParam>.FindAll
	|
	|-RVA: 0x3E5EB10 Offset: 0x3E5EC11 VA: 0x3E5EB10
	|-List<GmapPathAdjuster.TargetModel>.FindAll
	|
	|-RVA: 0x3E61D20 Offset: 0x3E61E21 VA: 0x3E61D20
	|-List<GmapSpotAdjuster.TargetModel>.FindAll
	|
	|-RVA: 0x3E64F30 Offset: 0x3E65031 VA: 0x3E64F30
	|-List<HubFastTravel.Location>.FindAll
	|
	|-RVA: 0x3E68230 Offset: 0x3E68331 VA: 0x3E68230
	|-List<HubLensFlare.Flare>.FindAll
	|
	|-RVA: 0x3E6B410 Offset: 0x3E6B511 VA: 0x3E6B410
	|-List<InventoryPoolItemMenuContent.KindBgNameClass>.FindAll
	|
	|-RVA: 0x3E6E2C0 Offset: 0x3E6E3C1 VA: 0x3E6E2C0
	|-List<Map.Pos>.FindAll
	|
	|-RVA: 0x3E71120 Offset: 0x3E71221 VA: 0x3E71120
	|-List<MapImage.BackupTerrain>.FindAll
	|
	|-RVA: 0x3E73FC0 Offset: 0x3E740C1 VA: 0x3E73FC0
	|-List<MapImageRange.Pos>.FindAll
	|
	|-RVA: 0x3E77030 Offset: 0x3E77131 VA: 0x3E77030
	|-List<MapMind.Target>.FindAll
	|
	|-RVA: 0x3D86C20 Offset: 0x3D86D21 VA: 0x3D86C20
	|-List<MapPanelDebug.Entity>.FindAll
	|
	|-RVA: 0x3D89C30 Offset: 0x3D89D31 VA: 0x3D89C30
	|-List<NexRanking.Data>.FindAll
	|
	|-RVA: 0x3D8CA90 Offset: 0x3D8CB91 VA: 0x3D8CA90
	|-List<NexVersus.RatingData>.FindAll
	|
	|-RVA: 0x3D8F990 Offset: 0x3D8FA91 VA: 0x3D8F990
	|-List<PackedPlayModeBuildLogs.RuntimeBuildLog>.FindAll
	|
	|-RVA: 0x3D92AC0 Offset: 0x3D92BC1 VA: 0x3D92AC0
	|-List<ParticleSystem.Particle>.FindAll
	|
	|-RVA: 0x3D95BF0 Offset: 0x3D95CF1 VA: 0x3D95BF0
	|-List<RangeData.Offset>.FindAll
	|
	|-RVA: 0x3D98BE0 Offset: 0x3D98CE1 VA: 0x3D98BE0
	|-List<RenderGraphDebugData.PassDebugData>.FindAll
	|
	|-RVA: 0x3D9BED0 Offset: 0x3D9BFD1 VA: 0x3D9BED0
	|-List<RenderGraphDebugData.ResourceDebugData>.FindAll
	|
	|-RVA: 0x3D9F060 Offset: 0x3D9F161 VA: 0x3D9F060
	|-List<RingCleaningUnitSelectMenu.GodParam>.FindAll
	|
	|-RVA: 0x3DA21B0 Offset: 0x3DA22B1 VA: 0x3DA21B0
	|-List<ShadowUtility.Edge>.FindAll
	|
	|-RVA: 0x3D14760 Offset: 0x3D14861 VA: 0x3D14760
	|-List<SkillArray.Entity>.FindAll
	|
	|-RVA: 0x3D178D0 Offset: 0x3D179D1 VA: 0x3D178D0
	|-List<TexturePacker_JsonArray.Frame>.FindAll
	|
	|-RVA: 0x3D1AD20 Offset: 0x3D1AE21 VA: 0x3D1AD20
	|-List<TimeNotificationBehaviour.NotificationEntry>.FindAll
	|
	|-RVA: 0x3D1DF40 Offset: 0x3D1E041 VA: 0x3D1DF40
	|-List<UnitySynchronizationContext.WorkRequest>.FindAll
	|
	|-RVA: 0x3D20FE0 Offset: 0x3D210E1 VA: 0x3D20FE0
	|-List<XmlSchemaObjectTable.XmlSchemaObjectEntry>.FindAll
	|
	|-RVA: 0x3D23F00 Offset: 0x3D24001 VA: 0x3D23F00
	|-List<AssetBundleBuildMap.AssetBundleEntry.AssetPathString>.FindAll
	|
	|-RVA: 0x3D27060 Offset: 0x3D27161 VA: 0x3D27060
	|-List<Detail.DataStore.DataStoreChangeMetaParamInt>.FindAll
	|
	|-RVA: 0x3D2A220 Offset: 0x3D2A321 VA: 0x3D2A220
	|-List<Detail.DataStore.DataStoreDeleteParamInt>.FindAll
	|
	|-RVA: 0x3D2D350 Offset: 0x3D2D451 VA: 0x3D2D350
	|-List<Detail.DataStore.DataStoreGetMetaParamInt>.FindAll
	|
	|-RVA: 0x3D306E0 Offset: 0x3D307E1 VA: 0x3D306E0
	|-List<Detail.DataStore.DataStoreMetaInfoInt>.FindAll
	|
	|-RVA: 0x3CF4E60 Offset: 0x3CF4F61 VA: 0x3CF4E60
	|-List<Detail.DataStore.DataStorePasswordInfoInt>.FindAll
	|
	|-RVA: 0x3CF8040 Offset: 0x3CF8141 VA: 0x3CF8040
	|-List<Detail.DataStore.DataStorePersistenceInfoInt>.FindAll
	|
	|-RVA: 0x3CFB2D0 Offset: 0x3CFB3D1 VA: 0x3CFB2D0
	|-List<Detail.DataStore.DataStorePreparePostParamInt>.FindAll
	|
	|-RVA: 0x3CFE450 Offset: 0x3CFE551 VA: 0x3CFE450
	|-List<Detail.DataStore.DataStoreRateObjectParamInt>.FindAll
	|
	|-RVA: 0x3D014B0 Offset: 0x3D015B1 VA: 0x3D014B0
	|-List<Detail.DataStore.DataStoreRatingInitParamInt>.FindAll
	|
	|-RVA: 0x3D04520 Offset: 0x3D04621 VA: 0x3D04520
	|-List<Detail.DataStore.DataStoreRatingTargetInt>.FindAll
	|
	|-RVA: 0x3D07720 Offset: 0x3D07821 VA: 0x3D07720
	|-List<Detail.Ranking.RankingCachedResultInt>.FindAll
	|
	|-RVA: 0x3D0A9E0 Offset: 0x3D0AAE1 VA: 0x3D0A9E0
	|-List<Detail.Ranking.RankingOrderParamInt>.FindAll
	|
	|-RVA: 0x3D0DBC0 Offset: 0x3D0DCC1 VA: 0x3D0DBC0
	|-List<Detail.Ranking.RankingRankDataInt>.FindAll
	|
	|-RVA: 0x3D11310 Offset: 0x3D11411 VA: 0x3D11310
	|-List<Detail.Ranking2.Ranking2ChartInfoInt>.FindAll
	|
	|-RVA: 0x3D67B40 Offset: 0x3D67C41 VA: 0x3D67B40
	|-List<Detail.Ranking2.Ranking2RankDataInt>.FindAll
	|
	|-RVA: 0x3D6ADC0 Offset: 0x3D6AEC1 VA: 0x3D6ADC0
	|-List<Detail.Ranking2.Ranking2ScoreDataInt>.FindAll
	|
	|-RVA: 0x3D6DE20 Offset: 0x3D6DF21 VA: 0x3D6DE20
	|-List<Detail.Screening.ScreeningContextInfoInt>.FindAll
	|
	|-RVA: 0x3D712A0 Offset: 0x3D713A1 VA: 0x3D712A0
	|-List<Detail.Subscriber.SubscriberContentInt>.FindAll
	|
	|-RVA: 0x3D747E0 Offset: 0x3D748E1 VA: 0x3D747E0
	|-List<Detail.Subscriber.SubscriberGetContentParamInt>.FindAll
	|
	|-RVA: 0x3D77A90 Offset: 0x3D77B91 VA: 0x3D77A90
	|-List<Detail.Subscriber.SubscriberUserStatusInfoInt>.FindAll
	|
	|-RVA: 0x3D7AD60 Offset: 0x3D7AE61 VA: 0x3D7AD60
	|-List<Detail.Subscriber.SubscriberUserStatusParamInt>.FindAll
	|
	|-RVA: 0x3D7DD70 Offset: 0x3D7DE71 VA: 0x3D7DD70
	|-List<Detail.Utility.IntegerSettings>.FindAll
	|
	|-RVA: 0x3D80BD0 Offset: 0x3D80CD1 VA: 0x3D80BD0
	|-List<Detail.Utility.UniqueIdInfoInt>.FindAll
	|
	|-RVA: 0x3D83B00 Offset: 0x3D83C01 VA: 0x3D83B00
	|-List<MapHistory.Rewind.LatestInspectorData>.FindAll
	|
	|-RVA: 0x305FDC0 Offset: 0x305FEC1 VA: 0x305FDC0
	|-List<MapHistory.Rewind.WorkTerrainData>.FindAll
	|
	|-RVA: 0x3062D80 Offset: 0x3062E81 VA: 0x3062D80
	|-List<MapSkill.AroundCalculator.Result>.FindAll
	|
	|-RVA: 0x3065ED0 Offset: 0x3065FD1 VA: 0x3065ED0
	|-List<TargetPositionCache.CacheCurve.Item>.FindAll
	|
	|-RVA: 0x3069290 Offset: 0x3069391 VA: 0x3069290
	|-List<TargetPositionCache.CacheEntry.RecordingItem>.FindAll
	*/

	// RVA: -1 Offset: -1
	public int FindIndex(Predicate<T> match) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3B0BC70 Offset: 0x3B0BD71 VA: 0x3B0BC70
	|-List<IntervalTree.Entry<object>>.FindIndex
	|
	|-RVA: 0x3B0ECD0 Offset: 0x3B0EDD1 VA: 0x3B0ECD0
	|-List<KeyValuePair<DateTime, object>>.FindIndex
	|
	|-RVA: 0x3B11BF0 Offset: 0x3B11CF1 VA: 0x3B11BF0
	|-List<KeyValuePair<int, object>>.FindIndex
	|
	|-RVA: 0x3B14CC0 Offset: 0x3B14DC1 VA: 0x3B14CC0
	|-List<KeyValuePair<object, ValueTuple<int, DateTime, object>>>.FindIndex
	|
	|-RVA: 0x3B17D30 Offset: 0x3B17E31 VA: 0x3B17D30
	|-List<KeyValuePair<object, object>>.FindIndex
	|
	|-RVA: 0x3B1AE00 Offset: 0x3B1AF01 VA: 0x3B1AE00
	|-List<CommonBattleSequence.Reliance<object>>.FindIndex
	|
	|-RVA: 0x3B1DE60 Offset: 0x3B1DF61 VA: 0x3B1DE60
	|-List<RenderGraphResourcePool.ResourceLogInfo<object>>.FindIndex
	|
	|-RVA: 0x3B20D80 Offset: 0x3B20E81 VA: 0x3B20D80
	|-List<ValueTuple<int, object>>.FindIndex
	|
	|-RVA: 0x3DE19A0 Offset: 0x3DE1AA1 VA: 0x3DE19A0
	|-List<ValueTuple<Int32Enum, int>>.FindIndex
	|
	|-RVA: 0x3DE49D0 Offset: 0x3DE4AD1 VA: 0x3DE49D0
	|-List<ValueTuple<object, ValueTuple<object, int>>>.FindIndex
	|
	|-RVA: 0x3DE7A30 Offset: 0x3DE7B31 VA: 0x3DE7A30
	|-List<ValueTuple<object, int>>.FindIndex
	|
	|-RVA: 0x3DEAA10 Offset: 0x3DEAB11 VA: 0x3DEAA10
	|-List<ValueTuple<Vector3, float>>.FindIndex
	|
	|-RVA: 0x3DED950 Offset: 0x3DEDA51 VA: 0x3DED950
	|-List<ValueTuple<object, Int32Enum, int>>.FindIndex
	|
	|-RVA: 0x3DF0A20 Offset: 0x3DF0B21 VA: 0x3DF0A20
	|-List<ValueTuple<object, int, int, int>>.FindIndex
	|
	|-RVA: 0x3DF3A10 Offset: 0x3DF3B11 VA: 0x3DF3A10
	|-List<AnimatorClipInfo>.FindIndex
	|
	|-RVA: 0x3DF6A40 Offset: 0x3DF6B41 VA: 0x3DF6A40
	|-List<AsyncOperationHandle>.FindIndex
	|
	|-RVA: 0x3DF9C40 Offset: 0x3DF9D41 VA: 0x3DF9C40
	|-List<BoneWeight>.FindIndex
	|
	|-RVA: 0x3DFCC30 Offset: 0x3DFCD31 VA: 0x3DFCC30
	|-List<bool>.FindIndex
	|
	|-RVA: 0x3E7A180 Offset: 0x3E7A281 VA: 0x3E7A180
	|-List<byte>.FindIndex
	|
	|-RVA: 0x3E7D000 Offset: 0x3E7D101 VA: 0x3E7D000
	|-List<CameraInfo>.FindIndex
	|
	|-RVA: 0x3E7FEB0 Offset: 0x3E7FFB1 VA: 0x3E7FEB0
	|-List<char>.FindIndex
	|
	|-RVA: 0x3E82DE0 Offset: 0x3E82EE1 VA: 0x3E82DE0
	|-List<Color>.FindIndex
	|
	|-RVA: 0x3E85CB0 Offset: 0x3E85DB1 VA: 0x3E85CB0
	|-List<Color32>.FindIndex
	|
	|-RVA: 0x3E88B30 Offset: 0x3E88C31 VA: 0x3E88B30
	|-List<ConstraintSource>.FindIndex
	|
	|-RVA: 0x3E8BC00 Offset: 0x3E8BD01 VA: 0x3E8BC00
	|-List<ContourVertex>.FindIndex
	|
	|-RVA: 0x3E8EE00 Offset: 0x3E8EF01 VA: 0x3E8EE00
	|-List<DataStoreRatingInfo>.FindIndex
	|
	|-RVA: 0x3E91DD0 Offset: 0x3E91ED1 VA: 0x3E91DD0
	|-List<DataStoreResult>.FindIndex
	|
	|-RVA: 0x3E94BE0 Offset: 0x3E94CE1 VA: 0x3E94BE0
	|-List<DateTime>.FindIndex
	|
	|-RVA: 0x3E97A40 Offset: 0x3E97B41 VA: 0x3E97A40
	|-List<DateTimeOffset>.FindIndex
	|
	|-RVA: 0x3E11A90 Offset: 0x3E11B91 VA: 0x3E11A90
	|-List<DebugUIHandlerValue>.FindIndex
	|-List<KerningPair>.FindIndex
	|-List<object>.FindIndex
	|-List<SimpleAnimationPlayable.StateInfo>.FindIndex
	|-List<TMP_MaterialManager.MaskingMaterial>.FindIndex
	|-List<TextRecordParsing.Record>.FindIndex
	|-List<RelayCompletionAwardData.CalcResult.Item>.FindIndex
	|
	|-RVA: 0x3E9A920 Offset: 0x3E9AA21 VA: 0x3E9A920
	|-List<Decimal>.FindIndex
	|
	|-RVA: 0x3E9DAF0 Offset: 0x3E9DBF1 VA: 0x3E9DAF0
	|-List<DiagnosticEvent>.FindIndex
	|
	|-RVA: 0x3EA0C00 Offset: 0x3EA0D01 VA: 0x3EA0C00
	|-List<double>.FindIndex
	|
	|-RVA: 0x3EA3CC0 Offset: 0x3EA3DC1 VA: 0x3EA3CC0
	|-List<Friend>.FindIndex
	|
	|-RVA: 0x3EA6DF0 Offset: 0x3EA6EF1 VA: 0x3EA6DF0
	|-List<GlyphRect>.FindIndex
	|
	|-RVA: 0x3EA9C80 Offset: 0x3EA9D81 VA: 0x3EA9C80
	|-List<short>.FindIndex
	|
	|-RVA: 0x3EACA80 Offset: 0x3EACB81 VA: 0x3EACA80
	|-List<int>.FindIndex
	|
	|-RVA: 0x3EAF880 Offset: 0x3EAF981 VA: 0x3EAF880
	|-List<Int32Enum>.FindIndex
	|
	|-RVA: 0x3EB2680 Offset: 0x3EB2781 VA: 0x3EB2680
	|-List<long>.FindIndex
	|
	|-RVA: 0x3DFFA50 Offset: 0x3DFFB51 VA: 0x3DFFA50
	|-List<IntPtr>.FindIndex
	|
	|-RVA: 0x3E028C0 Offset: 0x3E029C1 VA: 0x3E028C0
	|-List<InterpretedFrameInfo>.FindIndex
	|
	|-RVA: 0x3E05980 Offset: 0x3E05A81 VA: 0x3E05980
	|-List<IntervalTreeNode>.FindIndex
	|
	|-RVA: 0x3E08950 Offset: 0x3E08A51 VA: 0x3E08950
	|-List<LengthLimitProperties>.FindIndex
	|
	|-RVA: 0x3E0B760 Offset: 0x3E0B861 VA: 0x3E0B760
	|-List<MapPos>.FindIndex
	|
	|-RVA: 0x3E0E950 Offset: 0x3E0EA51 VA: 0x3E0E950
	|-List<Matrix4x4>.FindIndex
	|
	|-RVA: 0x3E14BF0 Offset: 0x3E14CF1 VA: 0x3E14BF0
	|-List<ObjectInitializationData>.FindIndex
	|
	|-RVA: 0x3E17F10 Offset: 0x3E18011 VA: 0x3E17F10
	|-List<PlayableBinding>.FindIndex
	|
	|-RVA: 0x3E1B220 Offset: 0x3E1B321 VA: 0x3E1B220
	|-List<PlayerLoopSystem>.FindIndex
	|
	|-RVA: 0x3DA56C0 Offset: 0x3DA57C1 VA: 0x3DA56C0
	|-List<PlayerLoopSystemInternal>.FindIndex
	|
	|-RVA: 0x3DA87F0 Offset: 0x3DA88F1 VA: 0x3DA87F0
	|-List<RangePositionInfo>.FindIndex
	|
	|-RVA: 0x3DAB6A0 Offset: 0x3DAB7A1 VA: 0x3DAB6A0
	|-List<Ranking2ChartInfoInput>.FindIndex
	|
	|-RVA: 0x3DAE7F0 Offset: 0x3DAE8F1 VA: 0x3DAE7F0
	|-List<RaycastHit2D>.FindIndex
	|
	|-RVA: 0x3DB1E00 Offset: 0x3DB1F01 VA: 0x3DB1E00
	|-List<RaycastResult>.FindIndex
	|
	|-RVA: 0x3DB5210 Offset: 0x3DB5311 VA: 0x3DB5210
	|-List<Rect>.FindIndex
	|
	|-RVA: 0x3DB80E0 Offset: 0x3DB81E1 VA: 0x3DB80E0
	|-List<RendererListHandle>.FindIndex
	|
	|-RVA: 0x3DBAEF0 Offset: 0x3DBAFF1 VA: 0x3DBAEF0
	|-List<ResourceHandle>.FindIndex
	|
	|-RVA: 0x3DBDD00 Offset: 0x3DBDE01 VA: 0x3DBDD00
	|-List<sbyte>.FindIndex
	|
	|-RVA: 0x3DC0B10 Offset: 0x3DC0C11 VA: 0x3DC0B10
	|-List<ShaderTagId>.FindIndex
	|
	|-RVA: 0x3E3C780 Offset: 0x3E3C881 VA: 0x3E3C780
	|-List<float>.FindIndex
	|
	|-RVA: 0x3E3FD60 Offset: 0x3E3FE61 VA: 0x3E3FD60
	|-List<SphericalHarmonicsL2>.FindIndex
	|
	|-RVA: 0x3E43590 Offset: 0x3E43691 VA: 0x3E43590
	|-List<SubMeshDescriptor>.FindIndex
	|
	|-RVA: 0x3E466D0 Offset: 0x3E467D1 VA: 0x3E466D0
	|-List<TablePair>.FindIndex
	|
	|-RVA: 0x3E49580 Offset: 0x3E49681 VA: 0x3E49580
	|-List<TimeSpan>.FindIndex
	|
	|-RVA: 0x3E4C490 Offset: 0x3E4C591 VA: 0x3E4C490
	|-List<UICharInfo>.FindIndex
	|
	|-RVA: 0x3E4F3C0 Offset: 0x3E4F4C1 VA: 0x3E4F3C0
	|-List<UILineInfo>.FindIndex
	|
	|-RVA: 0x3E52A20 Offset: 0x3E52B21 VA: 0x3E52A20
	|-List<UIVertex>.FindIndex
	|
	|-RVA: 0x3E55F30 Offset: 0x3E56031 VA: 0x3E55F30
	|-List<ushort>.FindIndex
	|
	|-RVA: 0x3E58D30 Offset: 0x3E58E31 VA: 0x3E58D30
	|-List<uint>.FindIndex
	|
	|-RVA: 0x3DC3920 Offset: 0x3DC3A21 VA: 0x3DC3920
	|-List<ulong>.FindIndex
	|
	|-RVA: 0x3DC6770 Offset: 0x3DC6871 VA: 0x3DC6770
	|-List<Vector2>.FindIndex
	|
	|-RVA: 0x3DC96F0 Offset: 0x3DC97F1 VA: 0x3DC96F0
	|-List<Vector3>.FindIndex
	|
	|-RVA: 0x3DCC700 Offset: 0x3DCC801 VA: 0x3DCC700
	|-List<Vector4>.FindIndex
	|
	|-RVA: 0x3DCF620 Offset: 0x3DCF721 VA: 0x3DCF620
	|-List<VertexAttributeDescriptor>.FindIndex
	|
	|-RVA: 0x3DD2520 Offset: 0x3DD2621 VA: 0x3DD2520
	|-List<X509ChainStatus>.FindIndex
	|
	|-RVA: 0x3DD56D0 Offset: 0x3DD57D1 VA: 0x3DD56D0
	|-List<XRView>.FindIndex
	|
	|-RVA: 0x3DD8830 Offset: 0x3DD8931 VA: 0x3DD8830
	|-List<AmiiboSequence.GainItemData>.FindIndex
	|
	|-RVA: 0x3DDB9E0 Offset: 0x3DDBAE1 VA: 0x3DDB9E0
	|-List<AnimationOutputWeightProcessor.WeightInfo>.FindIndex
	|
	|-RVA: 0x3DDEAF0 Offset: 0x3DDEBF1 VA: 0x3DDEAF0
	|-List<ArenaOrderSequence.GodInfo>.FindIndex
	|
	|-RVA: 0x3E1E350 Offset: 0x3E1E451 VA: 0x3E1E350
	|-List<BattleInfo.SupportData>.FindIndex
	|
	|-RVA: 0x3E21270 Offset: 0x3E21371 VA: 0x3E21270
	|-List<BeforeRenderHelper.OrderBlock>.FindIndex
	|
	|-RVA: 0x3E24350 Offset: 0x3E24451 VA: 0x3E24350
	|-List<Camera.RenderRequest>.FindIndex
	|
	|-RVA: 0x3E273C0 Offset: 0x3E274C1 VA: 0x3E273C0
	|-List<CameraState.CustomBlendable>.FindIndex
	|
	|-RVA: 0x3E2A270 Offset: 0x3E2A371 VA: 0x3E2A270
	|-List<CinemachineClearShot.Pair>.FindIndex
	|
	|-RVA: 0x3E2D080 Offset: 0x3E2D181 VA: 0x3E2D080
	|-List<CinemachineStateDrivenCamera.HashPair>.FindIndex
	|
	|-RVA: 0x3E300B0 Offset: 0x3E301B1 VA: 0x3E300B0
	|-List<DelayedActionManager.DelegateInfo>.FindIndex
	|
	|-RVA: 0x3E333D0 Offset: 0x3E334D1 VA: 0x3E333D0
	|-List<Detail.AsyncResultInt>.FindIndex
	|
	|-RVA: 0x3E364F0 Offset: 0x3E365F1 VA: 0x3E364F0
	|-List<Detail.CppArray>.FindIndex
	|
	|-RVA: 0x3E396A0 Offset: 0x3E397A1 VA: 0x3E396A0
	|-List<Detail.NotificationEventInt>.FindIndex
	|
	|-RVA: 0x3E5BBA0 Offset: 0x3E5BCA1 VA: 0x3E5BBA0
	|-List<DragonRideTargetGroup.ChainParam>.FindIndex
	|
	|-RVA: 0x3E5EC70 Offset: 0x3E5ED71 VA: 0x3E5EC70
	|-List<GmapPathAdjuster.TargetModel>.FindIndex
	|
	|-RVA: 0x3E61E80 Offset: 0x3E61F81 VA: 0x3E61E80
	|-List<GmapSpotAdjuster.TargetModel>.FindIndex
	|
	|-RVA: 0x3E65090 Offset: 0x3E65191 VA: 0x3E65090
	|-List<HubFastTravel.Location>.FindIndex
	|
	|-RVA: 0x3E683C0 Offset: 0x3E684C1 VA: 0x3E683C0
	|-List<HubLensFlare.Flare>.FindIndex
	|
	|-RVA: 0x3E6B530 Offset: 0x3E6B631 VA: 0x3E6B530
	|-List<InventoryPoolItemMenuContent.KindBgNameClass>.FindIndex
	|
	|-RVA: 0x3E6E3E0 Offset: 0x3E6E4E1 VA: 0x3E6E3E0
	|-List<Map.Pos>.FindIndex
	|
	|-RVA: 0x3E71240 Offset: 0x3E71341 VA: 0x3E71240
	|-List<MapImage.BackupTerrain>.FindIndex
	|
	|-RVA: 0x3E74100 Offset: 0x3E74201 VA: 0x3E74100
	|-List<MapImageRange.Pos>.FindIndex
	|
	|-RVA: 0x3E77190 Offset: 0x3E77291 VA: 0x3E77190
	|-List<MapMind.Target>.FindIndex
	|
	|-RVA: 0x3D86D80 Offset: 0x3D86E81 VA: 0x3D86D80
	|-List<MapPanelDebug.Entity>.FindIndex
	|
	|-RVA: 0x3D89D50 Offset: 0x3D89E51 VA: 0x3D89D50
	|-List<NexRanking.Data>.FindIndex
	|
	|-RVA: 0x3D8CBB0 Offset: 0x3D8CCB1 VA: 0x3D8CBB0
	|-List<NexVersus.RatingData>.FindIndex
	|
	|-RVA: 0x3D8FAB0 Offset: 0x3D8FBB1 VA: 0x3D8FAB0
	|-List<PackedPlayModeBuildLogs.RuntimeBuildLog>.FindIndex
	|
	|-RVA: 0x3D92C40 Offset: 0x3D92D41 VA: 0x3D92C40
	|-List<ParticleSystem.Particle>.FindIndex
	|
	|-RVA: 0x3D95D10 Offset: 0x3D95E11 VA: 0x3D95D10
	|-List<RangeData.Offset>.FindIndex
	|
	|-RVA: 0x3D98D40 Offset: 0x3D98E41 VA: 0x3D98D40
	|-List<RenderGraphDebugData.PassDebugData>.FindIndex
	|
	|-RVA: 0x3D9C050 Offset: 0x3D9C151 VA: 0x3D9C050
	|-List<RenderGraphDebugData.ResourceDebugData>.FindIndex
	|
	|-RVA: 0x3D9F180 Offset: 0x3D9F281 VA: 0x3D9F180
	|-List<RingCleaningUnitSelectMenu.GodParam>.FindIndex
	|
	|-RVA: 0x3DA2330 Offset: 0x3DA2431 VA: 0x3DA2330
	|-List<ShadowUtility.Edge>.FindIndex
	|
	|-RVA: 0x3D14880 Offset: 0x3D14981 VA: 0x3D14880
	|-List<SkillArray.Entity>.FindIndex
	|
	|-RVA: 0x3D17A80 Offset: 0x3D17B81 VA: 0x3D17A80
	|-List<TexturePacker_JsonArray.Frame>.FindIndex
	|
	|-RVA: 0x3D1AE80 Offset: 0x3D1AF81 VA: 0x3D1AE80
	|-List<TimeNotificationBehaviour.NotificationEntry>.FindIndex
	|
	|-RVA: 0x3D1E0A0 Offset: 0x3D1E1A1 VA: 0x3D1E0A0
	|-List<UnitySynchronizationContext.WorkRequest>.FindIndex
	|
	|-RVA: 0x3D21100 Offset: 0x3D21201 VA: 0x3D21100
	|-List<XmlSchemaObjectTable.XmlSchemaObjectEntry>.FindIndex
	|
	|-RVA: 0x3D24020 Offset: 0x3D24121 VA: 0x3D24020
	|-List<AssetBundleBuildMap.AssetBundleEntry.AssetPathString>.FindIndex
	|
	|-RVA: 0x3D271E0 Offset: 0x3D272E1 VA: 0x3D271E0
	|-List<Detail.DataStore.DataStoreChangeMetaParamInt>.FindIndex
	|
	|-RVA: 0x3D2A340 Offset: 0x3D2A441 VA: 0x3D2A340
	|-List<Detail.DataStore.DataStoreDeleteParamInt>.FindIndex
	|
	|-RVA: 0x3D2D4D0 Offset: 0x3D2D5D1 VA: 0x3D2D4D0
	|-List<Detail.DataStore.DataStoreGetMetaParamInt>.FindIndex
	|
	|-RVA: 0x3D30860 Offset: 0x3D30961 VA: 0x3D30860
	|-List<Detail.DataStore.DataStoreMetaInfoInt>.FindIndex
	|
	|-RVA: 0x3CF4FC0 Offset: 0x3CF50C1 VA: 0x3CF4FC0
	|-List<Detail.DataStore.DataStorePasswordInfoInt>.FindIndex
	|
	|-RVA: 0x3CF81A0 Offset: 0x3CF82A1 VA: 0x3CF81A0
	|-List<Detail.DataStore.DataStorePersistenceInfoInt>.FindIndex
	|
	|-RVA: 0x3CFB450 Offset: 0x3CFB551 VA: 0x3CFB450
	|-List<Detail.DataStore.DataStorePreparePostParamInt>.FindIndex
	|
	|-RVA: 0x3CFE570 Offset: 0x3CFE671 VA: 0x3CFE570
	|-List<Detail.DataStore.DataStoreRateObjectParamInt>.FindIndex
	|
	|-RVA: 0x3D01610 Offset: 0x3D01711 VA: 0x3D01610
	|-List<Detail.DataStore.DataStoreRatingInitParamInt>.FindIndex
	|
	|-RVA: 0x3D04640 Offset: 0x3D04741 VA: 0x3D04640
	|-List<Detail.DataStore.DataStoreRatingTargetInt>.FindIndex
	|
	|-RVA: 0x3D078E0 Offset: 0x3D079E1 VA: 0x3D078E0
	|-List<Detail.Ranking.RankingCachedResultInt>.FindIndex
	|
	|-RVA: 0x3D0AB00 Offset: 0x3D0AC01 VA: 0x3D0AB00
	|-List<Detail.Ranking.RankingOrderParamInt>.FindIndex
	|
	|-RVA: 0x3D0DD70 Offset: 0x3D0DE71 VA: 0x3D0DD70
	|-List<Detail.Ranking.RankingRankDataInt>.FindIndex
	|
	|-RVA: 0x3D11500 Offset: 0x3D11601 VA: 0x3D11500
	|-List<Detail.Ranking2.Ranking2ChartInfoInt>.FindIndex
	|
	|-RVA: 0x3D67CF0 Offset: 0x3D67DF1 VA: 0x3D67CF0
	|-List<Detail.Ranking2.Ranking2RankDataInt>.FindIndex
	|
	|-RVA: 0x3D6AEE0 Offset: 0x3D6AFE1 VA: 0x3D6AEE0
	|-List<Detail.Ranking2.Ranking2ScoreDataInt>.FindIndex
	|
	|-RVA: 0x3D6DF80 Offset: 0x3D6E081 VA: 0x3D6DF80
	|-List<Detail.Screening.ScreeningContextInfoInt>.FindIndex
	|
	|-RVA: 0x3D71480 Offset: 0x3D71581 VA: 0x3D71480
	|-List<Detail.Subscriber.SubscriberContentInt>.FindIndex
	|
	|-RVA: 0x3D74940 Offset: 0x3D74A41 VA: 0x3D74940
	|-List<Detail.Subscriber.SubscriberGetContentParamInt>.FindIndex
	|
	|-RVA: 0x3D77C10 Offset: 0x3D77D11 VA: 0x3D77C10
	|-List<Detail.Subscriber.SubscriberUserStatusInfoInt>.FindIndex
	|
	|-RVA: 0x3D7AEC0 Offset: 0x3D7AFC1 VA: 0x3D7AEC0
	|-List<Detail.Subscriber.SubscriberUserStatusParamInt>.FindIndex
	|
	|-RVA: 0x3D7DE90 Offset: 0x3D7DF91 VA: 0x3D7DE90
	|-List<Detail.Utility.IntegerSettings>.FindIndex
	|
	|-RVA: 0x3D80CF0 Offset: 0x3D80DF1 VA: 0x3D80CF0
	|-List<Detail.Utility.UniqueIdInfoInt>.FindIndex
	|
	|-RVA: 0x3D83C50 Offset: 0x3D83D51 VA: 0x3D83C50
	|-List<MapHistory.Rewind.LatestInspectorData>.FindIndex
	|
	|-RVA: 0x305FF10 Offset: 0x3060011 VA: 0x305FF10
	|-List<MapHistory.Rewind.WorkTerrainData>.FindIndex
	|
	|-RVA: 0x3062EA0 Offset: 0x3062FA1 VA: 0x3062EA0
	|-List<MapSkill.AroundCalculator.Result>.FindIndex
	|
	|-RVA: 0x3066050 Offset: 0x3066151 VA: 0x3066050
	|-List<TargetPositionCache.CacheCurve.Item>.FindIndex
	|
	|-RVA: 0x3069410 Offset: 0x3069511 VA: 0x3069410
	|-List<TargetPositionCache.CacheEntry.RecordingItem>.FindIndex
	*/

	// RVA: -1 Offset: -1
	public int FindIndex(int startIndex, int count, Predicate<T> match) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3B0BCA0 Offset: 0x3B0BDA1 VA: 0x3B0BCA0
	|-List<IntervalTree.Entry<object>>.FindIndex
	|
	|-RVA: 0x3B0ED00 Offset: 0x3B0EE01 VA: 0x3B0ED00
	|-List<KeyValuePair<DateTime, object>>.FindIndex
	|
	|-RVA: 0x3B11C20 Offset: 0x3B11D21 VA: 0x3B11C20
	|-List<KeyValuePair<int, object>>.FindIndex
	|
	|-RVA: 0x3B14CF0 Offset: 0x3B14DF1 VA: 0x3B14CF0
	|-List<KeyValuePair<object, ValueTuple<int, DateTime, object>>>.FindIndex
	|
	|-RVA: 0x3B17D60 Offset: 0x3B17E61 VA: 0x3B17D60
	|-List<KeyValuePair<object, object>>.FindIndex
	|
	|-RVA: 0x3B1AE30 Offset: 0x3B1AF31 VA: 0x3B1AE30
	|-List<CommonBattleSequence.Reliance<object>>.FindIndex
	|
	|-RVA: 0x3B1DE90 Offset: 0x3B1DF91 VA: 0x3B1DE90
	|-List<RenderGraphResourcePool.ResourceLogInfo<object>>.FindIndex
	|
	|-RVA: 0x3B20DB0 Offset: 0x3B20EB1 VA: 0x3B20DB0
	|-List<ValueTuple<int, object>>.FindIndex
	|
	|-RVA: 0x3DE19D0 Offset: 0x3DE1AD1 VA: 0x3DE19D0
	|-List<ValueTuple<Int32Enum, int>>.FindIndex
	|
	|-RVA: 0x3DE4A00 Offset: 0x3DE4B01 VA: 0x3DE4A00
	|-List<ValueTuple<object, ValueTuple<object, int>>>.FindIndex
	|
	|-RVA: 0x3DE7A60 Offset: 0x3DE7B61 VA: 0x3DE7A60
	|-List<ValueTuple<object, int>>.FindIndex
	|
	|-RVA: 0x3DEAA40 Offset: 0x3DEAB41 VA: 0x3DEAA40
	|-List<ValueTuple<Vector3, float>>.FindIndex
	|
	|-RVA: 0x3DED980 Offset: 0x3DEDA81 VA: 0x3DED980
	|-List<ValueTuple<object, Int32Enum, int>>.FindIndex
	|
	|-RVA: 0x3DF0A50 Offset: 0x3DF0B51 VA: 0x3DF0A50
	|-List<ValueTuple<object, int, int, int>>.FindIndex
	|
	|-RVA: 0x3DF3A40 Offset: 0x3DF3B41 VA: 0x3DF3A40
	|-List<AnimatorClipInfo>.FindIndex
	|
	|-RVA: 0x3DF6A70 Offset: 0x3DF6B71 VA: 0x3DF6A70
	|-List<AsyncOperationHandle>.FindIndex
	|
	|-RVA: 0x3DF9C70 Offset: 0x3DF9D71 VA: 0x3DF9C70
	|-List<BoneWeight>.FindIndex
	|
	|-RVA: 0x3DFCC60 Offset: 0x3DFCD61 VA: 0x3DFCC60
	|-List<bool>.FindIndex
	|
	|-RVA: 0x3E7A1B0 Offset: 0x3E7A2B1 VA: 0x3E7A1B0
	|-List<byte>.FindIndex
	|
	|-RVA: 0x3E7D030 Offset: 0x3E7D131 VA: 0x3E7D030
	|-List<CameraInfo>.FindIndex
	|
	|-RVA: 0x3E7FEE0 Offset: 0x3E7FFE1 VA: 0x3E7FEE0
	|-List<char>.FindIndex
	|
	|-RVA: 0x3E82E10 Offset: 0x3E82F11 VA: 0x3E82E10
	|-List<Color>.FindIndex
	|
	|-RVA: 0x3E85CE0 Offset: 0x3E85DE1 VA: 0x3E85CE0
	|-List<Color32>.FindIndex
	|
	|-RVA: 0x3E88B60 Offset: 0x3E88C61 VA: 0x3E88B60
	|-List<ConstraintSource>.FindIndex
	|
	|-RVA: 0x3E8BC30 Offset: 0x3E8BD31 VA: 0x3E8BC30
	|-List<ContourVertex>.FindIndex
	|
	|-RVA: 0x3E8EE30 Offset: 0x3E8EF31 VA: 0x3E8EE30
	|-List<DataStoreRatingInfo>.FindIndex
	|
	|-RVA: 0x3E91E00 Offset: 0x3E91F01 VA: 0x3E91E00
	|-List<DataStoreResult>.FindIndex
	|
	|-RVA: 0x3E94C10 Offset: 0x3E94D11 VA: 0x3E94C10
	|-List<DateTime>.FindIndex
	|
	|-RVA: 0x3E97A70 Offset: 0x3E97B71 VA: 0x3E97A70
	|-List<DateTimeOffset>.FindIndex
	|
	|-RVA: 0x3E9A950 Offset: 0x3E9AA51 VA: 0x3E9A950
	|-List<Decimal>.FindIndex
	|
	|-RVA: 0x3E9DB20 Offset: 0x3E9DC21 VA: 0x3E9DB20
	|-List<DiagnosticEvent>.FindIndex
	|
	|-RVA: 0x3EA0C30 Offset: 0x3EA0D31 VA: 0x3EA0C30
	|-List<double>.FindIndex
	|
	|-RVA: 0x3EA3CF0 Offset: 0x3EA3DF1 VA: 0x3EA3CF0
	|-List<Friend>.FindIndex
	|
	|-RVA: 0x3EA6E20 Offset: 0x3EA6F21 VA: 0x3EA6E20
	|-List<GlyphRect>.FindIndex
	|
	|-RVA: 0x3EA9CB0 Offset: 0x3EA9DB1 VA: 0x3EA9CB0
	|-List<short>.FindIndex
	|
	|-RVA: 0x3EACAB0 Offset: 0x3EACBB1 VA: 0x3EACAB0
	|-List<int>.FindIndex
	|
	|-RVA: 0x3EAF8B0 Offset: 0x3EAF9B1 VA: 0x3EAF8B0
	|-List<Int32Enum>.FindIndex
	|
	|-RVA: 0x3EB26B0 Offset: 0x3EB27B1 VA: 0x3EB26B0
	|-List<long>.FindIndex
	|
	|-RVA: 0x3DFFA80 Offset: 0x3DFFB81 VA: 0x3DFFA80
	|-List<IntPtr>.FindIndex
	|
	|-RVA: 0x3E028F0 Offset: 0x3E029F1 VA: 0x3E028F0
	|-List<InterpretedFrameInfo>.FindIndex
	|
	|-RVA: 0x3E059B0 Offset: 0x3E05AB1 VA: 0x3E059B0
	|-List<IntervalTreeNode>.FindIndex
	|
	|-RVA: 0x3E08980 Offset: 0x3E08A81 VA: 0x3E08980
	|-List<LengthLimitProperties>.FindIndex
	|
	|-RVA: 0x3E0B790 Offset: 0x3E0B891 VA: 0x3E0B790
	|-List<MapPos>.FindIndex
	|
	|-RVA: 0x3E0E980 Offset: 0x3E0EA81 VA: 0x3E0E980
	|-List<Matrix4x4>.FindIndex
	|
	|-RVA: 0x3E11AC0 Offset: 0x3E11BC1 VA: 0x3E11AC0
	|-List<object>.FindIndex
	|
	|-RVA: 0x3E14C20 Offset: 0x3E14D21 VA: 0x3E14C20
	|-List<ObjectInitializationData>.FindIndex
	|
	|-RVA: 0x3E17F40 Offset: 0x3E18041 VA: 0x3E17F40
	|-List<PlayableBinding>.FindIndex
	|
	|-RVA: 0x3E1B250 Offset: 0x3E1B351 VA: 0x3E1B250
	|-List<PlayerLoopSystem>.FindIndex
	|
	|-RVA: 0x3DA56F0 Offset: 0x3DA57F1 VA: 0x3DA56F0
	|-List<PlayerLoopSystemInternal>.FindIndex
	|
	|-RVA: 0x3DA8820 Offset: 0x3DA8921 VA: 0x3DA8820
	|-List<RangePositionInfo>.FindIndex
	|
	|-RVA: 0x3DAB6D0 Offset: 0x3DAB7D1 VA: 0x3DAB6D0
	|-List<Ranking2ChartInfoInput>.FindIndex
	|
	|-RVA: 0x3DAE820 Offset: 0x3DAE921 VA: 0x3DAE820
	|-List<RaycastHit2D>.FindIndex
	|
	|-RVA: 0x3DB1E30 Offset: 0x3DB1F31 VA: 0x3DB1E30
	|-List<RaycastResult>.FindIndex
	|
	|-RVA: 0x3DB5240 Offset: 0x3DB5341 VA: 0x3DB5240
	|-List<Rect>.FindIndex
	|
	|-RVA: 0x3DB8110 Offset: 0x3DB8211 VA: 0x3DB8110
	|-List<RendererListHandle>.FindIndex
	|
	|-RVA: 0x3DBAF20 Offset: 0x3DBB021 VA: 0x3DBAF20
	|-List<ResourceHandle>.FindIndex
	|
	|-RVA: 0x3DBDD30 Offset: 0x3DBDE31 VA: 0x3DBDD30
	|-List<sbyte>.FindIndex
	|
	|-RVA: 0x3DC0B40 Offset: 0x3DC0C41 VA: 0x3DC0B40
	|-List<ShaderTagId>.FindIndex
	|
	|-RVA: 0x3E3C7B0 Offset: 0x3E3C8B1 VA: 0x3E3C7B0
	|-List<float>.FindIndex
	|
	|-RVA: 0x3E3FD90 Offset: 0x3E3FE91 VA: 0x3E3FD90
	|-List<SphericalHarmonicsL2>.FindIndex
	|
	|-RVA: 0x3E435C0 Offset: 0x3E436C1 VA: 0x3E435C0
	|-List<SubMeshDescriptor>.FindIndex
	|
	|-RVA: 0x3E46700 Offset: 0x3E46801 VA: 0x3E46700
	|-List<TablePair>.FindIndex
	|
	|-RVA: 0x3E495B0 Offset: 0x3E496B1 VA: 0x3E495B0
	|-List<TimeSpan>.FindIndex
	|
	|-RVA: 0x3E4C4C0 Offset: 0x3E4C5C1 VA: 0x3E4C4C0
	|-List<UICharInfo>.FindIndex
	|
	|-RVA: 0x3E4F3F0 Offset: 0x3E4F4F1 VA: 0x3E4F3F0
	|-List<UILineInfo>.FindIndex
	|
	|-RVA: 0x3E52A50 Offset: 0x3E52B51 VA: 0x3E52A50
	|-List<UIVertex>.FindIndex
	|
	|-RVA: 0x3E55F60 Offset: 0x3E56061 VA: 0x3E55F60
	|-List<ushort>.FindIndex
	|
	|-RVA: 0x3E58D60 Offset: 0x3E58E61 VA: 0x3E58D60
	|-List<uint>.FindIndex
	|
	|-RVA: 0x3DC3950 Offset: 0x3DC3A51 VA: 0x3DC3950
	|-List<ulong>.FindIndex
	|
	|-RVA: 0x3DC67A0 Offset: 0x3DC68A1 VA: 0x3DC67A0
	|-List<Vector2>.FindIndex
	|
	|-RVA: 0x3DC9720 Offset: 0x3DC9821 VA: 0x3DC9720
	|-List<Vector3>.FindIndex
	|
	|-RVA: 0x3DCC730 Offset: 0x3DCC831 VA: 0x3DCC730
	|-List<Vector4>.FindIndex
	|
	|-RVA: 0x3DCF650 Offset: 0x3DCF751 VA: 0x3DCF650
	|-List<VertexAttributeDescriptor>.FindIndex
	|
	|-RVA: 0x3DD2550 Offset: 0x3DD2651 VA: 0x3DD2550
	|-List<X509ChainStatus>.FindIndex
	|
	|-RVA: 0x3DD5700 Offset: 0x3DD5801 VA: 0x3DD5700
	|-List<XRView>.FindIndex
	|
	|-RVA: 0x3DD8860 Offset: 0x3DD8961 VA: 0x3DD8860
	|-List<AmiiboSequence.GainItemData>.FindIndex
	|
	|-RVA: 0x3DDBA10 Offset: 0x3DDBB11 VA: 0x3DDBA10
	|-List<AnimationOutputWeightProcessor.WeightInfo>.FindIndex
	|
	|-RVA: 0x3DDEB20 Offset: 0x3DDEC21 VA: 0x3DDEB20
	|-List<ArenaOrderSequence.GodInfo>.FindIndex
	|
	|-RVA: 0x3E1E380 Offset: 0x3E1E481 VA: 0x3E1E380
	|-List<BattleInfo.SupportData>.FindIndex
	|
	|-RVA: 0x3E212A0 Offset: 0x3E213A1 VA: 0x3E212A0
	|-List<BeforeRenderHelper.OrderBlock>.FindIndex
	|
	|-RVA: 0x3E24380 Offset: 0x3E24481 VA: 0x3E24380
	|-List<Camera.RenderRequest>.FindIndex
	|
	|-RVA: 0x3E273F0 Offset: 0x3E274F1 VA: 0x3E273F0
	|-List<CameraState.CustomBlendable>.FindIndex
	|
	|-RVA: 0x3E2A2A0 Offset: 0x3E2A3A1 VA: 0x3E2A2A0
	|-List<CinemachineClearShot.Pair>.FindIndex
	|
	|-RVA: 0x3E2D0B0 Offset: 0x3E2D1B1 VA: 0x3E2D0B0
	|-List<CinemachineStateDrivenCamera.HashPair>.FindIndex
	|
	|-RVA: 0x3E300E0 Offset: 0x3E301E1 VA: 0x3E300E0
	|-List<DelayedActionManager.DelegateInfo>.FindIndex
	|
	|-RVA: 0x3E33400 Offset: 0x3E33501 VA: 0x3E33400
	|-List<Detail.AsyncResultInt>.FindIndex
	|
	|-RVA: 0x3E36520 Offset: 0x3E36621 VA: 0x3E36520
	|-List<Detail.CppArray>.FindIndex
	|
	|-RVA: 0x3E396D0 Offset: 0x3E397D1 VA: 0x3E396D0
	|-List<Detail.NotificationEventInt>.FindIndex
	|
	|-RVA: 0x3E5BBD0 Offset: 0x3E5BCD1 VA: 0x3E5BBD0
	|-List<DragonRideTargetGroup.ChainParam>.FindIndex
	|
	|-RVA: 0x3E5ECA0 Offset: 0x3E5EDA1 VA: 0x3E5ECA0
	|-List<GmapPathAdjuster.TargetModel>.FindIndex
	|
	|-RVA: 0x3E61EB0 Offset: 0x3E61FB1 VA: 0x3E61EB0
	|-List<GmapSpotAdjuster.TargetModel>.FindIndex
	|
	|-RVA: 0x3E650C0 Offset: 0x3E651C1 VA: 0x3E650C0
	|-List<HubFastTravel.Location>.FindIndex
	|
	|-RVA: 0x3E683F0 Offset: 0x3E684F1 VA: 0x3E683F0
	|-List<HubLensFlare.Flare>.FindIndex
	|
	|-RVA: 0x3E6B560 Offset: 0x3E6B661 VA: 0x3E6B560
	|-List<InventoryPoolItemMenuContent.KindBgNameClass>.FindIndex
	|
	|-RVA: 0x3E6E410 Offset: 0x3E6E511 VA: 0x3E6E410
	|-List<Map.Pos>.FindIndex
	|
	|-RVA: 0x3E71270 Offset: 0x3E71371 VA: 0x3E71270
	|-List<MapImage.BackupTerrain>.FindIndex
	|
	|-RVA: 0x3E74130 Offset: 0x3E74231 VA: 0x3E74130
	|-List<MapImageRange.Pos>.FindIndex
	|
	|-RVA: 0x3E771C0 Offset: 0x3E772C1 VA: 0x3E771C0
	|-List<MapMind.Target>.FindIndex
	|
	|-RVA: 0x3D86DB0 Offset: 0x3D86EB1 VA: 0x3D86DB0
	|-List<MapPanelDebug.Entity>.FindIndex
	|
	|-RVA: 0x3D89D80 Offset: 0x3D89E81 VA: 0x3D89D80
	|-List<NexRanking.Data>.FindIndex
	|
	|-RVA: 0x3D8CBE0 Offset: 0x3D8CCE1 VA: 0x3D8CBE0
	|-List<NexVersus.RatingData>.FindIndex
	|
	|-RVA: 0x3D8FAE0 Offset: 0x3D8FBE1 VA: 0x3D8FAE0
	|-List<PackedPlayModeBuildLogs.RuntimeBuildLog>.FindIndex
	|
	|-RVA: 0x3D92C70 Offset: 0x3D92D71 VA: 0x3D92C70
	|-List<ParticleSystem.Particle>.FindIndex
	|
	|-RVA: 0x3D95D40 Offset: 0x3D95E41 VA: 0x3D95D40
	|-List<RangeData.Offset>.FindIndex
	|
	|-RVA: 0x3D98D70 Offset: 0x3D98E71 VA: 0x3D98D70
	|-List<RenderGraphDebugData.PassDebugData>.FindIndex
	|
	|-RVA: 0x3D9C080 Offset: 0x3D9C181 VA: 0x3D9C080
	|-List<RenderGraphDebugData.ResourceDebugData>.FindIndex
	|
	|-RVA: 0x3D9F1B0 Offset: 0x3D9F2B1 VA: 0x3D9F1B0
	|-List<RingCleaningUnitSelectMenu.GodParam>.FindIndex
	|
	|-RVA: 0x3DA2360 Offset: 0x3DA2461 VA: 0x3DA2360
	|-List<ShadowUtility.Edge>.FindIndex
	|
	|-RVA: 0x3D148B0 Offset: 0x3D149B1 VA: 0x3D148B0
	|-List<SkillArray.Entity>.FindIndex
	|
	|-RVA: 0x3D17AB0 Offset: 0x3D17BB1 VA: 0x3D17AB0
	|-List<TexturePacker_JsonArray.Frame>.FindIndex
	|
	|-RVA: 0x3D1AEB0 Offset: 0x3D1AFB1 VA: 0x3D1AEB0
	|-List<TimeNotificationBehaviour.NotificationEntry>.FindIndex
	|
	|-RVA: 0x3D1E0D0 Offset: 0x3D1E1D1 VA: 0x3D1E0D0
	|-List<UnitySynchronizationContext.WorkRequest>.FindIndex
	|
	|-RVA: 0x3D21130 Offset: 0x3D21231 VA: 0x3D21130
	|-List<XmlSchemaObjectTable.XmlSchemaObjectEntry>.FindIndex
	|
	|-RVA: 0x3D24050 Offset: 0x3D24151 VA: 0x3D24050
	|-List<AssetBundleBuildMap.AssetBundleEntry.AssetPathString>.FindIndex
	|
	|-RVA: 0x3D27210 Offset: 0x3D27311 VA: 0x3D27210
	|-List<Detail.DataStore.DataStoreChangeMetaParamInt>.FindIndex
	|
	|-RVA: 0x3D2A370 Offset: 0x3D2A471 VA: 0x3D2A370
	|-List<Detail.DataStore.DataStoreDeleteParamInt>.FindIndex
	|
	|-RVA: 0x3D2D500 Offset: 0x3D2D601 VA: 0x3D2D500
	|-List<Detail.DataStore.DataStoreGetMetaParamInt>.FindIndex
	|
	|-RVA: 0x3D30890 Offset: 0x3D30991 VA: 0x3D30890
	|-List<Detail.DataStore.DataStoreMetaInfoInt>.FindIndex
	|
	|-RVA: 0x3CF4FF0 Offset: 0x3CF50F1 VA: 0x3CF4FF0
	|-List<Detail.DataStore.DataStorePasswordInfoInt>.FindIndex
	|
	|-RVA: 0x3CF81D0 Offset: 0x3CF82D1 VA: 0x3CF81D0
	|-List<Detail.DataStore.DataStorePersistenceInfoInt>.FindIndex
	|
	|-RVA: 0x3CFB480 Offset: 0x3CFB581 VA: 0x3CFB480
	|-List<Detail.DataStore.DataStorePreparePostParamInt>.FindIndex
	|
	|-RVA: 0x3CFE5A0 Offset: 0x3CFE6A1 VA: 0x3CFE5A0
	|-List<Detail.DataStore.DataStoreRateObjectParamInt>.FindIndex
	|
	|-RVA: 0x3D01640 Offset: 0x3D01741 VA: 0x3D01640
	|-List<Detail.DataStore.DataStoreRatingInitParamInt>.FindIndex
	|
	|-RVA: 0x3D04670 Offset: 0x3D04771 VA: 0x3D04670
	|-List<Detail.DataStore.DataStoreRatingTargetInt>.FindIndex
	|
	|-RVA: 0x3D07910 Offset: 0x3D07A11 VA: 0x3D07910
	|-List<Detail.Ranking.RankingCachedResultInt>.FindIndex
	|
	|-RVA: 0x3D0AB30 Offset: 0x3D0AC31 VA: 0x3D0AB30
	|-List<Detail.Ranking.RankingOrderParamInt>.FindIndex
	|
	|-RVA: 0x3D0DDA0 Offset: 0x3D0DEA1 VA: 0x3D0DDA0
	|-List<Detail.Ranking.RankingRankDataInt>.FindIndex
	|
	|-RVA: 0x3D11530 Offset: 0x3D11631 VA: 0x3D11530
	|-List<Detail.Ranking2.Ranking2ChartInfoInt>.FindIndex
	|
	|-RVA: 0x3D67D20 Offset: 0x3D67E21 VA: 0x3D67D20
	|-List<Detail.Ranking2.Ranking2RankDataInt>.FindIndex
	|
	|-RVA: 0x3D6AF10 Offset: 0x3D6B011 VA: 0x3D6AF10
	|-List<Detail.Ranking2.Ranking2ScoreDataInt>.FindIndex
	|
	|-RVA: 0x3D6DFB0 Offset: 0x3D6E0B1 VA: 0x3D6DFB0
	|-List<Detail.Screening.ScreeningContextInfoInt>.FindIndex
	|
	|-RVA: 0x3D714B0 Offset: 0x3D715B1 VA: 0x3D714B0
	|-List<Detail.Subscriber.SubscriberContentInt>.FindIndex
	|
	|-RVA: 0x3D74970 Offset: 0x3D74A71 VA: 0x3D74970
	|-List<Detail.Subscriber.SubscriberGetContentParamInt>.FindIndex
	|
	|-RVA: 0x3D77C40 Offset: 0x3D77D41 VA: 0x3D77C40
	|-List<Detail.Subscriber.SubscriberUserStatusInfoInt>.FindIndex
	|
	|-RVA: 0x3D7AEF0 Offset: 0x3D7AFF1 VA: 0x3D7AEF0
	|-List<Detail.Subscriber.SubscriberUserStatusParamInt>.FindIndex
	|
	|-RVA: 0x3D7DEC0 Offset: 0x3D7DFC1 VA: 0x3D7DEC0
	|-List<Detail.Utility.IntegerSettings>.FindIndex
	|
	|-RVA: 0x3D80D20 Offset: 0x3D80E21 VA: 0x3D80D20
	|-List<Detail.Utility.UniqueIdInfoInt>.FindIndex
	|
	|-RVA: 0x3D83C80 Offset: 0x3D83D81 VA: 0x3D83C80
	|-List<MapHistory.Rewind.LatestInspectorData>.FindIndex
	|
	|-RVA: 0x305FF40 Offset: 0x3060041 VA: 0x305FF40
	|-List<MapHistory.Rewind.WorkTerrainData>.FindIndex
	|
	|-RVA: 0x3062ED0 Offset: 0x3062FD1 VA: 0x3062ED0
	|-List<MapSkill.AroundCalculator.Result>.FindIndex
	|
	|-RVA: 0x3066080 Offset: 0x3066181 VA: 0x3066080
	|-List<TargetPositionCache.CacheCurve.Item>.FindIndex
	|
	|-RVA: 0x3069440 Offset: 0x3069541 VA: 0x3069440
	|-List<TargetPositionCache.CacheEntry.RecordingItem>.FindIndex
	*/

	// RVA: -1 Offset: -1
	public void ForEach(Action<T> action) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3B0BDF0 Offset: 0x3B0BEF1 VA: 0x3B0BDF0
	|-List<IntervalTree.Entry<object>>.ForEach
	|
	|-RVA: 0x3B0EE30 Offset: 0x3B0EF31 VA: 0x3B0EE30
	|-List<KeyValuePair<DateTime, object>>.ForEach
	|
	|-RVA: 0x3B11D50 Offset: 0x3B11E51 VA: 0x3B11D50
	|-List<KeyValuePair<int, object>>.ForEach
	|
	|-RVA: 0x3B14E40 Offset: 0x3B14F41 VA: 0x3B14E40
	|-List<KeyValuePair<object, ValueTuple<int, DateTime, object>>>.ForEach
	|
	|-RVA: 0x3B17E90 Offset: 0x3B17F91 VA: 0x3B17E90
	|-List<KeyValuePair<object, object>>.ForEach
	|
	|-RVA: 0x3B1AF80 Offset: 0x3B1B081 VA: 0x3B1AF80
	|-List<CommonBattleSequence.Reliance<object>>.ForEach
	|
	|-RVA: 0x3B1DFC0 Offset: 0x3B1E0C1 VA: 0x3B1DFC0
	|-List<RenderGraphResourcePool.ResourceLogInfo<object>>.ForEach
	|
	|-RVA: 0x3B20EE0 Offset: 0x3B20FE1 VA: 0x3B20EE0
	|-List<ValueTuple<int, object>>.ForEach
	|
	|-RVA: 0x3DE1AE0 Offset: 0x3DE1BE1 VA: 0x3DE1AE0
	|-List<ValueTuple<Int32Enum, int>>.ForEach
	|
	|-RVA: 0x3DE4B50 Offset: 0x3DE4C51 VA: 0x3DE4B50
	|-List<ValueTuple<object, ValueTuple<object, int>>>.ForEach
	|
	|-RVA: 0x3DE7B90 Offset: 0x3DE7C91 VA: 0x3DE7B90
	|-List<ValueTuple<object, int>>.ForEach
	|
	|-RVA: 0x3DEAB70 Offset: 0x3DEAC71 VA: 0x3DEAB70
	|-List<ValueTuple<Vector3, float>>.ForEach
	|
	|-RVA: 0x3DEDAB0 Offset: 0x3DEDBB1 VA: 0x3DEDAB0
	|-List<ValueTuple<object, Int32Enum, int>>.ForEach
	|
	|-RVA: 0x3DF0BA0 Offset: 0x3DF0CA1 VA: 0x3DF0BA0
	|-List<ValueTuple<object, int, int, int>>.ForEach
	|
	|-RVA: 0x3DF3B50 Offset: 0x3DF3C51 VA: 0x3DF3B50
	|-List<AnimatorClipInfo>.ForEach
	|
	|-RVA: 0x3DF6BC0 Offset: 0x3DF6CC1 VA: 0x3DF6BC0
	|-List<AsyncOperationHandle>.ForEach
	|
	|-RVA: 0x3DF9DC0 Offset: 0x3DF9EC1 VA: 0x3DF9DC0
	|-List<BoneWeight>.ForEach
	|
	|-RVA: 0x3DFCD70 Offset: 0x3DFCE71 VA: 0x3DFCD70
	|-List<bool>.ForEach
	|
	|-RVA: 0x3E7A2C0 Offset: 0x3E7A3C1 VA: 0x3E7A2C0
	|-List<byte>.ForEach
	|
	|-RVA: 0x3E7D160 Offset: 0x3E7D261 VA: 0x3E7D160
	|-List<CameraInfo>.ForEach
	|
	|-RVA: 0x3E7FFF0 Offset: 0x3E800F1 VA: 0x3E7FFF0
	|-List<char>.ForEach
	|
	|-RVA: 0x3E82F40 Offset: 0x3E83041 VA: 0x3E82F40
	|-List<Color>.ForEach
	|
	|-RVA: 0x3E85DF0 Offset: 0x3E85EF1 VA: 0x3E85DF0
	|-List<Color32>.ForEach
	|
	|-RVA: 0x3E88C90 Offset: 0x3E88D91 VA: 0x3E88C90
	|-List<ConstraintSource>.ForEach
	|
	|-RVA: 0x3E8BD80 Offset: 0x3E8BE81 VA: 0x3E8BD80
	|-List<ContourVertex>.ForEach
	|
	|-RVA: 0x3E8EF80 Offset: 0x3E8F081 VA: 0x3E8EF80
	|-List<DataStoreRatingInfo>.ForEach
	|
	|-RVA: 0x3E91F10 Offset: 0x3E92011 VA: 0x3E91F10
	|-List<DataStoreResult>.ForEach
	|
	|-RVA: 0x3E94D20 Offset: 0x3E94E21 VA: 0x3E94D20
	|-List<DateTime>.ForEach
	|
	|-RVA: 0x3E97BA0 Offset: 0x3E97CA1 VA: 0x3E97BA0
	|-List<DateTimeOffset>.ForEach
	|
	|-RVA: 0x3E11BD0 Offset: 0x3E11CD1 VA: 0x3E11BD0
	|-List<DebugUIHandlerPanel>.ForEach
	|-List<HubUnitController>.ForEach
	|-List<object>.ForEach
	|-List<RingCleaningVoiceData>.ForEach
	|-List<DishAllMenuContent.HistoryObject>.ForEach
	|
	|-RVA: 0x3E9AA80 Offset: 0x3E9AB81 VA: 0x3E9AA80
	|-List<Decimal>.ForEach
	|
	|-RVA: 0x3E9DC90 Offset: 0x3E9DD91 VA: 0x3E9DC90
	|-List<DiagnosticEvent>.ForEach
	|
	|-RVA: 0x3EA0D40 Offset: 0x3EA0E41 VA: 0x3EA0D40
	|-List<double>.ForEach
	|
	|-RVA: 0x3EA3E50 Offset: 0x3EA3F51 VA: 0x3EA3E50
	|-List<Friend>.ForEach
	|
	|-RVA: 0x3EA6F50 Offset: 0x3EA7051 VA: 0x3EA6F50
	|-List<GlyphRect>.ForEach
	|
	|-RVA: 0x3EA9DC0 Offset: 0x3EA9EC1 VA: 0x3EA9DC0
	|-List<short>.ForEach
	|
	|-RVA: 0x3EACBC0 Offset: 0x3EACCC1 VA: 0x3EACBC0
	|-List<int>.ForEach
	|
	|-RVA: 0x3EAF9C0 Offset: 0x3EAFAC1 VA: 0x3EAF9C0
	|-List<Int32Enum>.ForEach
	|
	|-RVA: 0x3EB27C0 Offset: 0x3EB28C1 VA: 0x3EB27C0
	|-List<long>.ForEach
	|
	|-RVA: 0x3DFFB90 Offset: 0x3DFFC91 VA: 0x3DFFB90
	|-List<IntPtr>.ForEach
	|
	|-RVA: 0x3E02A20 Offset: 0x3E02B21 VA: 0x3E02A20
	|-List<InterpretedFrameInfo>.ForEach
	|
	|-RVA: 0x3E05B00 Offset: 0x3E05C01 VA: 0x3E05B00
	|-List<IntervalTreeNode>.ForEach
	|
	|-RVA: 0x3E08A90 Offset: 0x3E08B91 VA: 0x3E08A90
	|-List<LengthLimitProperties>.ForEach
	|
	|-RVA: 0x3E0B8A0 Offset: 0x3E0B9A1 VA: 0x3E0B8A0
	|-List<MapPos>.ForEach
	|
	|-RVA: 0x3E0EAF0 Offset: 0x3E0EBF1 VA: 0x3E0EAF0
	|-List<Matrix4x4>.ForEach
	|
	|-RVA: 0x3E14D90 Offset: 0x3E14E91 VA: 0x3E14D90
	|-List<ObjectInitializationData>.ForEach
	|
	|-RVA: 0x3E18090 Offset: 0x3E18191 VA: 0x3E18090
	|-List<PlayableBinding>.ForEach
	|
	|-RVA: 0x3E1B3B0 Offset: 0x3E1B4B1 VA: 0x3E1B3B0
	|-List<PlayerLoopSystem>.ForEach
	|
	|-RVA: 0x3DA5850 Offset: 0x3DA5951 VA: 0x3DA5850
	|-List<PlayerLoopSystemInternal>.ForEach
	|
	|-RVA: 0x3DA8950 Offset: 0x3DA8A51 VA: 0x3DA8950
	|-List<RangePositionInfo>.ForEach
	|
	|-RVA: 0x3DAB7E0 Offset: 0x3DAB8E1 VA: 0x3DAB7E0
	|-List<Ranking2ChartInfoInput>.ForEach
	|
	|-RVA: 0x3DAE980 Offset: 0x3DAEA81 VA: 0x3DAE980
	|-List<RaycastHit2D>.ForEach
	|
	|-RVA: 0x3DB1FC0 Offset: 0x3DB20C1 VA: 0x3DB1FC0
	|-List<RaycastResult>.ForEach
	|
	|-RVA: 0x3DB5370 Offset: 0x3DB5471 VA: 0x3DB5370
	|-List<Rect>.ForEach
	|
	|-RVA: 0x3DB8220 Offset: 0x3DB8321 VA: 0x3DB8220
	|-List<RendererListHandle>.ForEach
	|
	|-RVA: 0x3DBB030 Offset: 0x3DBB131 VA: 0x3DBB030
	|-List<ResourceHandle>.ForEach
	|
	|-RVA: 0x3DBDE40 Offset: 0x3DBDF41 VA: 0x3DBDE40
	|-List<sbyte>.ForEach
	|
	|-RVA: 0x3DC0C50 Offset: 0x3DC0D51 VA: 0x3DC0C50
	|-List<ShaderTagId>.ForEach
	|
	|-RVA: 0x3E3C8C0 Offset: 0x3E3C9C1 VA: 0x3E3C8C0
	|-List<float>.ForEach
	|
	|-RVA: 0x3E3FF50 Offset: 0x3E40051 VA: 0x3E3FF50
	|-List<SphericalHarmonicsL2>.ForEach
	|
	|-RVA: 0x3E43730 Offset: 0x3E43831 VA: 0x3E43730
	|-List<SubMeshDescriptor>.ForEach
	|
	|-RVA: 0x3E46830 Offset: 0x3E46931 VA: 0x3E46830
	|-List<TablePair>.ForEach
	|
	|-RVA: 0x3E496C0 Offset: 0x3E497C1 VA: 0x3E496C0
	|-List<TimeSpan>.ForEach
	|
	|-RVA: 0x3E4C5F0 Offset: 0x3E4C6F1 VA: 0x3E4C5F0
	|-List<UICharInfo>.ForEach
	|
	|-RVA: 0x3E4F520 Offset: 0x3E4F621 VA: 0x3E4F520
	|-List<UILineInfo>.ForEach
	|
	|-RVA: 0x3E52C10 Offset: 0x3E52D11 VA: 0x3E52C10
	|-List<UIVertex>.ForEach
	|
	|-RVA: 0x3E56070 Offset: 0x3E56171 VA: 0x3E56070
	|-List<ushort>.ForEach
	|
	|-RVA: 0x3E58E70 Offset: 0x3E58F71 VA: 0x3E58E70
	|-List<uint>.ForEach
	|
	|-RVA: 0x3DC3A60 Offset: 0x3DC3B61 VA: 0x3DC3A60
	|-List<ulong>.ForEach
	|
	|-RVA: 0x3DC68D0 Offset: 0x3DC69D1 VA: 0x3DC68D0
	|-List<Vector2>.ForEach
	|
	|-RVA: 0x3DC9850 Offset: 0x3DC9951 VA: 0x3DC9850
	|-List<Vector3>.ForEach
	|
	|-RVA: 0x3DCC860 Offset: 0x3DCC961 VA: 0x3DCC860
	|-List<Vector4>.ForEach
	|
	|-RVA: 0x3DCF780 Offset: 0x3DCF881 VA: 0x3DCF780
	|-List<VertexAttributeDescriptor>.ForEach
	|
	|-RVA: 0x3DD2680 Offset: 0x3DD2781 VA: 0x3DD2680
	|-List<X509ChainStatus>.ForEach
	|
	|-RVA: 0x3DD5860 Offset: 0x3DD5961 VA: 0x3DD5860
	|-List<XRView>.ForEach
	|
	|-RVA: 0x3DD8990 Offset: 0x3DD8A91 VA: 0x3DD8990
	|-List<AmiiboSequence.GainItemData>.ForEach
	|
	|-RVA: 0x3DDBB70 Offset: 0x3DDBC71 VA: 0x3DDBB70
	|-List<AnimationOutputWeightProcessor.WeightInfo>.ForEach
	|
	|-RVA: 0x3DDEC50 Offset: 0x3DDED51 VA: 0x3DDEC50
	|-List<ArenaOrderSequence.GodInfo>.ForEach
	|
	|-RVA: 0x3E1E4B0 Offset: 0x3E1E5B1 VA: 0x3E1E4B0
	|-List<BattleInfo.SupportData>.ForEach
	|
	|-RVA: 0x3E213D0 Offset: 0x3E214D1 VA: 0x3E213D0
	|-List<BeforeRenderHelper.OrderBlock>.ForEach
	|
	|-RVA: 0x3E244D0 Offset: 0x3E245D1 VA: 0x3E244D0
	|-List<Camera.RenderRequest>.ForEach
	|
	|-RVA: 0x3E27520 Offset: 0x3E27621 VA: 0x3E27520
	|-List<CameraState.CustomBlendable>.ForEach
	|
	|-RVA: 0x3E2A3B0 Offset: 0x3E2A4B1 VA: 0x3E2A3B0
	|-List<CinemachineClearShot.Pair>.ForEach
	|
	|-RVA: 0x3E2D1C0 Offset: 0x3E2D2C1 VA: 0x3E2D1C0
	|-List<CinemachineStateDrivenCamera.HashPair>.ForEach
	|
	|-RVA: 0x3E30230 Offset: 0x3E30331 VA: 0x3E30230
	|-List<DelayedActionManager.DelegateInfo>.ForEach
	|
	|-RVA: 0x3E33570 Offset: 0x3E33671 VA: 0x3E33570
	|-List<Detail.AsyncResultInt>.ForEach
	|
	|-RVA: 0x3E36650 Offset: 0x3E36751 VA: 0x3E36650
	|-List<Detail.CppArray>.ForEach
	|
	|-RVA: 0x3E39840 Offset: 0x3E39941 VA: 0x3E39840
	|-List<Detail.NotificationEventInt>.ForEach
	|
	|-RVA: 0x3E5BD00 Offset: 0x3E5BE01 VA: 0x3E5BD00
	|-List<DragonRideTargetGroup.ChainParam>.ForEach
	|
	|-RVA: 0x3E5EDF0 Offset: 0x3E5EEF1 VA: 0x3E5EDF0
	|-List<GmapPathAdjuster.TargetModel>.ForEach
	|
	|-RVA: 0x3E62000 Offset: 0x3E62101 VA: 0x3E62000
	|-List<GmapSpotAdjuster.TargetModel>.ForEach
	|
	|-RVA: 0x3E65210 Offset: 0x3E65311 VA: 0x3E65210
	|-List<HubFastTravel.Location>.ForEach
	|
	|-RVA: 0x3E68560 Offset: 0x3E68661 VA: 0x3E68560
	|-List<HubLensFlare.Flare>.ForEach
	|
	|-RVA: 0x3E6B690 Offset: 0x3E6B791 VA: 0x3E6B690
	|-List<InventoryPoolItemMenuContent.KindBgNameClass>.ForEach
	|
	|-RVA: 0x3E6E520 Offset: 0x3E6E621 VA: 0x3E6E520
	|-List<Map.Pos>.ForEach
	|
	|-RVA: 0x3E713A0 Offset: 0x3E714A1 VA: 0x3E713A0
	|-List<MapImage.BackupTerrain>.ForEach
	|
	|-RVA: 0x3E74260 Offset: 0x3E74361 VA: 0x3E74260
	|-List<MapImageRange.Pos>.ForEach
	|
	|-RVA: 0x3E77310 Offset: 0x3E77411 VA: 0x3E77310
	|-List<MapMind.Target>.ForEach
	|
	|-RVA: 0x3D86F00 Offset: 0x3D87001 VA: 0x3D86F00
	|-List<MapPanelDebug.Entity>.ForEach
	|
	|-RVA: 0x3D89E90 Offset: 0x3D89F91 VA: 0x3D89E90
	|-List<NexRanking.Data>.ForEach
	|
	|-RVA: 0x3D8CD10 Offset: 0x3D8CE11 VA: 0x3D8CD10
	|-List<NexVersus.RatingData>.ForEach
	|
	|-RVA: 0x3D8FC10 Offset: 0x3D8FD11 VA: 0x3D8FC10
	|-List<PackedPlayModeBuildLogs.RuntimeBuildLog>.ForEach
	|
	|-RVA: 0x3D92DD0 Offset: 0x3D92ED1 VA: 0x3D92DD0
	|-List<ParticleSystem.Particle>.ForEach
	|
	|-RVA: 0x3D95E50 Offset: 0x3D95F51 VA: 0x3D95E50
	|-List<RangeData.Offset>.ForEach
	|
	|-RVA: 0x3D98EC0 Offset: 0x3D98FC1 VA: 0x3D98EC0
	|-List<RenderGraphDebugData.PassDebugData>.ForEach
	|
	|-RVA: 0x3D9C1E0 Offset: 0x3D9C2E1 VA: 0x3D9C1E0
	|-List<RenderGraphDebugData.ResourceDebugData>.ForEach
	|
	|-RVA: 0x3D9F2E0 Offset: 0x3D9F3E1 VA: 0x3D9F2E0
	|-List<RingCleaningUnitSelectMenu.GodParam>.ForEach
	|
	|-RVA: 0x3DA24C0 Offset: 0x3DA25C1 VA: 0x3DA24C0
	|-List<ShadowUtility.Edge>.ForEach
	|
	|-RVA: 0x3D149C0 Offset: 0x3D14AC1 VA: 0x3D149C0
	|-List<SkillArray.Entity>.ForEach
	|
	|-RVA: 0x3D17C20 Offset: 0x3D17D21 VA: 0x3D17C20
	|-List<TexturePacker_JsonArray.Frame>.ForEach
	|
	|-RVA: 0x3D1B000 Offset: 0x3D1B101 VA: 0x3D1B000
	|-List<TimeNotificationBehaviour.NotificationEntry>.ForEach
	|
	|-RVA: 0x3D1E220 Offset: 0x3D1E321 VA: 0x3D1E220
	|-List<UnitySynchronizationContext.WorkRequest>.ForEach
	|
	|-RVA: 0x3D21260 Offset: 0x3D21361 VA: 0x3D21260
	|-List<XmlSchemaObjectTable.XmlSchemaObjectEntry>.ForEach
	|
	|-RVA: 0x3D24180 Offset: 0x3D24281 VA: 0x3D24180
	|-List<AssetBundleBuildMap.AssetBundleEntry.AssetPathString>.ForEach
	|
	|-RVA: 0x3D27370 Offset: 0x3D27471 VA: 0x3D27370
	|-List<Detail.DataStore.DataStoreChangeMetaParamInt>.ForEach
	|
	|-RVA: 0x3D2A4A0 Offset: 0x3D2A5A1 VA: 0x3D2A4A0
	|-List<Detail.DataStore.DataStoreDeleteParamInt>.ForEach
	|
	|-RVA: 0x3D2D660 Offset: 0x3D2D761 VA: 0x3D2D660
	|-List<Detail.DataStore.DataStoreGetMetaParamInt>.ForEach
	|
	|-RVA: 0x3D309F0 Offset: 0x3D30AF1 VA: 0x3D309F0
	|-List<Detail.DataStore.DataStoreMetaInfoInt>.ForEach
	|
	|-RVA: 0x3CF5140 Offset: 0x3CF5241 VA: 0x3CF5140
	|-List<Detail.DataStore.DataStorePasswordInfoInt>.ForEach
	|
	|-RVA: 0x3CF8320 Offset: 0x3CF8421 VA: 0x3CF8320
	|-List<Detail.DataStore.DataStorePersistenceInfoInt>.ForEach
	|
	|-RVA: 0x3CFB5E0 Offset: 0x3CFB6E1 VA: 0x3CFB5E0
	|-List<Detail.DataStore.DataStorePreparePostParamInt>.ForEach
	|
	|-RVA: 0x3CFE6D0 Offset: 0x3CFE7D1 VA: 0x3CFE6D0
	|-List<Detail.DataStore.DataStoreRateObjectParamInt>.ForEach
	|
	|-RVA: 0x3D01790 Offset: 0x3D01891 VA: 0x3D01790
	|-List<Detail.DataStore.DataStoreRatingInitParamInt>.ForEach
	|
	|-RVA: 0x3D047A0 Offset: 0x3D048A1 VA: 0x3D047A0
	|-List<Detail.DataStore.DataStoreRatingTargetInt>.ForEach
	|
	|-RVA: 0x3D07A90 Offset: 0x3D07B91 VA: 0x3D07A90
	|-List<Detail.Ranking.RankingCachedResultInt>.ForEach
	|
	|-RVA: 0x3D0AC60 Offset: 0x3D0AD61 VA: 0x3D0AC60
	|-List<Detail.Ranking.RankingOrderParamInt>.ForEach
	|
	|-RVA: 0x3D0DF10 Offset: 0x3D0E011 VA: 0x3D0DF10
	|-List<Detail.Ranking.RankingRankDataInt>.ForEach
	|
	|-RVA: 0x3D116D0 Offset: 0x3D117D1 VA: 0x3D116D0
	|-List<Detail.Ranking2.Ranking2ChartInfoInt>.ForEach
	|
	|-RVA: 0x3D67E90 Offset: 0x3D67F91 VA: 0x3D67E90
	|-List<Detail.Ranking2.Ranking2RankDataInt>.ForEach
	|
	|-RVA: 0x3D6B040 Offset: 0x3D6B141 VA: 0x3D6B040
	|-List<Detail.Ranking2.Ranking2ScoreDataInt>.ForEach
	|
	|-RVA: 0x3D6E100 Offset: 0x3D6E201 VA: 0x3D6E100
	|-List<Detail.Screening.ScreeningContextInfoInt>.ForEach
	|
	|-RVA: 0x3D71640 Offset: 0x3D71741 VA: 0x3D71640
	|-List<Detail.Subscriber.SubscriberContentInt>.ForEach
	|
	|-RVA: 0x3D74AC0 Offset: 0x3D74BC1 VA: 0x3D74AC0
	|-List<Detail.Subscriber.SubscriberGetContentParamInt>.ForEach
	|
	|-RVA: 0x3D77DA0 Offset: 0x3D77EA1 VA: 0x3D77DA0
	|-List<Detail.Subscriber.SubscriberUserStatusInfoInt>.ForEach
	|
	|-RVA: 0x3D7B040 Offset: 0x3D7B141 VA: 0x3D7B040
	|-List<Detail.Subscriber.SubscriberUserStatusParamInt>.ForEach
	|
	|-RVA: 0x3D7DFD0 Offset: 0x3D7E0D1 VA: 0x3D7DFD0
	|-List<Detail.Utility.IntegerSettings>.ForEach
	|
	|-RVA: 0x3D80E50 Offset: 0x3D80F51 VA: 0x3D80E50
	|-List<Detail.Utility.UniqueIdInfoInt>.ForEach
	|
	|-RVA: 0x3D83DC0 Offset: 0x3D83EC1 VA: 0x3D83DC0
	|-List<MapHistory.Rewind.LatestInspectorData>.ForEach
	|
	|-RVA: 0x3060080 Offset: 0x3060181 VA: 0x3060080
	|-List<MapHistory.Rewind.WorkTerrainData>.ForEach
	|
	|-RVA: 0x3063000 Offset: 0x3063101 VA: 0x3063000
	|-List<MapSkill.AroundCalculator.Result>.ForEach
	|
	|-RVA: 0x30661E0 Offset: 0x30662E1 VA: 0x30661E0
	|-List<TargetPositionCache.CacheCurve.Item>.ForEach
	|
	|-RVA: 0x30695A0 Offset: 0x30696A1 VA: 0x30695A0
	|-List<TargetPositionCache.CacheEntry.RecordingItem>.ForEach
	*/

	// RVA: -1 Offset: -1
	public List.Enumerator<T> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3B0BF90 Offset: 0x3B0C091 VA: 0x3B0BF90
	|-List<IntervalTree.Entry<object>>.GetEnumerator
	|
	|-RVA: 0x3B0EFD0 Offset: 0x3B0F0D1 VA: 0x3B0EFD0
	|-List<KeyValuePair<DateTime, object>>.GetEnumerator
	|
	|-RVA: 0x3B18030 Offset: 0x3B18131 VA: 0x3B18030
	|-List<KeyValuePair<Expression, Expression>>.GetEnumerator
	|-List<KeyValuePair<object, object>>.GetEnumerator
	|
	|-RVA: 0x3B11EF0 Offset: 0x3B11FF1 VA: 0x3B11EF0
	|-List<KeyValuePair<int, object>>.GetEnumerator
	|
	|-RVA: 0x3B14FE0 Offset: 0x3B150E1 VA: 0x3B14FE0
	|-List<KeyValuePair<object, ValueTuple<int, DateTime, object>>>.GetEnumerator
	|
	|-RVA: 0x3E11D50 Offset: 0x3E11E51 VA: 0x3E11D50
	|-List<List<int>>.GetEnumerator
	|-List<StructDataArrayList<ChartVariableData>>.GetEnumerator
	|-List<StructDataArrayList<EncountEquipData>>.GetEnumerator
	|-List<StructDataArrayList<JobIntroData>>.GetEnumerator
	|-List<StructDataArrayList<LaterTalkData>>.GetEnumerator
	|-List<string[]>.GetEnumerator
	|-List<AccessoryData>.GetEnumerator
	|-List<AchieveData>.GetEnumerator
	|-List<AnimalData>.GetEnumerator
	|-List<AnimationClip>.GetEnumerator
	|-List<Animator>.GetEnumerator
	|-List<AssetTable>.GetEnumerator
	|-List<BaseConverter>.GetEnumerator
	|-List<BasicMenu>.GetEnumerator
	|-List<BasicMenuItem>.GetEnumerator
	|-List<Behaviour>.GetEnumerator
	|-List<BranchLabel>.GetEnumerator
	|-List<BuildTimeScopeBlock>.GetEnumerator
	|-List<ByRefUpdater>.GetEnumerator
	|-List<CapsuleCollider>.GetEnumerator
	|-List<ChallengeData>.GetEnumerator
	|-List<ChapterData>.GetEnumerator
	|-List<ChartVariableData>.GetEnumerator
	|-List<Collider>.GetEnumerator
	|-List<DataStoreMetaInfo>.GetEnumerator
	|-List<DebugUIHandlerIndirectToggle>.GetEnumerator
	|-List<DebugUIHandlerValue>.GetEnumerator
	|-List<DebugUIPrefabBundle>.GetEnumerator
	|-List<Decorator>.GetEnumerator
	|-List<DisposData>.GetEnumerator
	|-List<EffectData>.GetEnumerator
	|-List<EncountEquipData>.GetEnumerator
	|-List<EncountRareMonayData>.GetEnumerator
	|-List<EncountUnitData>.GetEnumerator
	|-List<EncountWeaponCategoryData>.GetEnumerator
	|-List<EndRollData>.GetEnumerator
	|-List<ExceptionDispatchInfo>.GetEnumerator
	|-List<Expression>.GetEnumerator
	|-List<FileData>.GetEnumerator
	|-List<FoodstuffData>.GetEnumerator
	|-List<ForceTextureSetter>.GetEnumerator
	|-List<ForecastFishData>.GetEnumerator
	|-List<FriendListData>.GetEnumerator
	|-List<GUILayoutEntry>.GetEnumerator
	|-List<GameObject>.GetEnumerator
	|-List<GmapSpot>.GetEnumerator
	|-List<GodData>.GetEnumerator
	|-List<GodGrowthData>.GetEnumerator
	|-List<GodUnit>.GetEnumerator
	|-List<GotoStatement>.GetEnumerator
	|-List<HelpItemList>.GetEnumerator
	|-List<HubAccess>.GetEnumerator
	|-List<HubAccessData>.GetEnumerator
	|-List<HubDisposData>.GetEnumerator
	|-List<HubFacilityData>.GetEnumerator
	|-List<HubInvestmentAnimal>.GetEnumerator
	|-List<HubInvestmentFoodstuff>.GetEnumerator
	|-List<HubMoveData>.GetEnumerator
	|-List<HubMoveState>.GetEnumerator
	|-List<HubNationData>.GetEnumerator
	|-List<HubRandomSet>.GetEnumerator
	|-List<IAsyncLocal>.GetEnumerator
	|-List<IContextProperty>.GetEnumerator
	|-List<IDisposable>.GetEnumerator
	|-List<IOverloadableMemberDescriptor>.GetEnumerator
	|-List<IPAddress>.GetEnumerator
	|-List<IResourceLocation>.GetEnumerator
	|-List<IUpdateReceiver>.GetEnumerator
	|-List<IUserDataDescriptor>.GetEnumerator
	|-List<Image>.GetEnumerator
	|-List<Instruction>.GetEnumerator
	|-List<IntegratedSubsystem>.GetEnumerator
	|-List<IntegratedSubsystemDescriptor>.GetEnumerator
	|-List<ItemData>.GetEnumerator
	|-List<JobData>.GetEnumerator
	|-List<JobIntroData>.GetEnumerator
	|-List<KeyHelpData>.GetEnumerator
	|-List<LabelScopeInfo>.GetEnumerator
	|-List<LaterTalkData>.GetEnumerator
	|-List<Light2D>.GetEnumerator
	|-List<MagicSignal>.GetEnumerator
	|-List<MapBackup>.GetEnumerator
	|-List<MapImageCoreBit>.GetEnumerator
	|-List<MapInfoRoot>.GetEnumerator
	|-List<MapInspector>.GetEnumerator
	|-List<MapObject>.GetEnumerator
	|-List<MascotAccData>.GetEnumerator
	|-List<MascotColorChangeItemContent>.GetEnumerator
	|-List<Material>.GetEnumerator
	|-List<MaterialPropertyBlock>.GetEnumerator
	|-List<MenuItem>.GetEnumerator
	|-List<MethodInfo>.GetEnumerator
	|-List<ModifierSpec>.GetEnumerator
	|-List<MovieDefineData>.GetEnumerator
	|-List<MuscleExerciseScoreData>.GetEnumerator
	|-List<MusclePushUpAreaData>.GetEnumerator
	|-List<MusclePushUpSpeedData>.GetEnumerator
	|-List<MuscleSitUpFallData>.GetEnumerator
	|-List<Note>.GetEnumerator
	|-List<NotificationEvent>.GetEnumerator
	|-List<NotificationEventCB>.GetEnumerator
	|-List<object>.GetEnumerator
	|-List<PersistentCall>.GetEnumerator
	|-List<Phase>.GetEnumerator
	|-List<PhotographDisposInfo>.GetEnumerator
	|-List<PhotographPauseData>.GetEnumerator
	|-List<PlayReportSendBase>.GetEnumerator
	|-List<PrefetchedSignal>.GetEnumerator
	|-List<ProfileCard>.GetEnumerator
	|-List<Ranking2RankData>.GetEnumerator
	|-List<RankingRankData>.GetEnumerator
	|-List<RectTransform>.GetEnumerator
	|-List<RelayStampData>.GetEnumerator
	|-List<RenderGraphPass>.GetEnumerator
	|-List<Renderer>.GetEnumerator
	|-List<ResourceHandle>.GetEnumerator
	|-List<ResourceLocationData>.GetEnumerator
	|-List<RewardData>.GetEnumerator
	|-List<RingData>.GetEnumerator
	|-List<RuntimeElement>.GetEnumerator
	|-List<ScriptableObject>.GetEnumerator
	|-List<ScriptableRendererFeature>.GetEnumerator
	|-List<SkillData>.GetEnumerator
	|-List<SourceCode>.GetEnumerator
	|-List<SourceRef>.GetEnumerator
	|-List<SpringBone>.GetEnumerator
	|-List<Statement>.GetEnumerator
	|-List<string>.GetEnumerator
	|-List<Task>.GetEnumerator
	|-List<TextMeshProUGUI>.GetEnumerator
	|-List<Thread>.GetEnumerator
	|-List<TimelineClip>.GetEnumerator
	|-List<TipsData>.GetEnumerator
	|-List<Transform>.GetEnumerator
	|-List<TypeIdentifier>.GetEnumerator
	|-List<Unit>.GetEnumerator
	|-List<UnitActor>.GetEnumerator
	|-List<UnitInfoCharaImageMaskOffset>.GetEnumerator
	|-List<ValueCountController>.GetEnumerator
	|-List<VersusMapEditCategoryContent>.GetEnumerator
	|-List<VersusServerCasualMetaData>.GetEnumerator
	|-List<VersusServerRankedMetaData>.GetEnumerator
	|-List<VersusServerReplayMetaData>.GetEnumerator
	|-List<Volume>.GetEnumerator
	|-List<VolumeComponent>.GetEnumerator
	|-List<WatchItem>.GetEnumerator
	|-List<WeaponMask>.GetEnumerator
	|-List<X509CertificateImpl>.GetEnumerator
	|-List<XRPass>.GetEnumerator
	|-List<AddressablesImpl.ResourceLocatorInfo>.GetEnumerator
	|-List<AdhocAssetLoader.Asset>.GetEnumerator
	|-List<AssetTable.Accessory>.GetEnumerator
	|-List<BufferedGizmo.Segment>.GetEnumerator
	|-List<CasualMap.ObjectData>.GetEnumerator
	|-List<ChapterRecord.Record>.GetEnumerator
	|-List<CinemachineCollider.VcamExtraState>.GetEnumerator
	|-List<ClassChange.ChangeJobData>.GetEnumerator
	|-List<ClassChangeJobMenuItemContent.WeaponLevelItem>.GetEnumerator
	|-List<CombatViewerSettings.ViewerPhase>.GetEnumerator
	|-List<ConstantBuffer.ConstantBufferBase>.GetEnumerator
	|-List<DLCManager.MountData>.GetEnumerator
	|-List<DebugUI.Panel>.GetEnumerator
	|-List<DishSelectFoodInfoContent.FoodstuffObject>.GetEnumerator
	|-List<DishSelectMenu.DishSelectMenuItem>.GetEnumerator
	|-List<DishSelectMenuCategoryContent.CategoryObject>.GetEnumerator
	|-List<DragonRideTargetGroup.ChainSEManager>.GetEnumerator
	|-List<DynamicsSetup.ParseMessage>.GetEnumerator
	|-List<EmittersConstraint.Pair>.GetEnumerator
	|-List<ExtensionMethodsRegistry.UnresolvedGenericMethod>.GetEnumerator
	|-List<FoodstuffMenu.FoodstuffMenuItem>.GetEnumerator
	|-List<GameSaveDataHeaderReader.Handle>.GetEnumerator
	|-List<GameSound.Handle>.GetEnumerator
	|-List<GrassData.SpriteInfo>.GetEnumerator
	|-List<HelpManager.Item>.GetEnumerator
	|-List<HubMiniMap.IconData>.GetEnumerator
	|-List<HubMiniMapCaptureParam.CaptureParam1>.GetEnumerator
	|-List<IfStatement.IfBlock>.GetEnumerator
	|-List<MapBattleInfoSequence.AttackInfo>.GetEnumerator
	|-List<MapDispos.ActualData>.GetEnumerator
	|-List<MapDispos.Pos>.GetEnumerator
	|-List<MapEditData.UnitInfo>.GetEnumerator
	|-List<MapImageTerrain.MinimapInfo>.GetEnumerator
	|-List<MapMaterial.Node>.GetEnumerator
	|-List<MapPrefab.Entity>.GetEnumerator
	|-List<MapTarget.Data>.GetEnumerator
	|-List<MapTerrain.LayerData>.GetEnumerator
	|-List<MapTerrain.OverlapData>.GetEnumerator
	|-List<MapTerrainInfoAlignment.AlignMember>.GetEnumerator
	|-List<MapTerrainInfoAlignment.InversionMember>.GetEnumerator
	|-List<Mess.ReloadFileInfo>.GetEnumerator
	|-List<MonoChunkStream.Chunk>.GetEnumerator
	|-List<MuscleSquatSequence.RandomPack>.GetEnumerator
	|-List<PhotographTopSequence.UnitAccDataSet>.GetEnumerator
	|-List<ResourceManager.InstanceOperation>.GetEnumerator
	|-List<RingListSequence.GodPageData>.GetEnumerator
	|-List<RingListSequence.PageData>.GetEnumerator
	|-List<RingListSequence.RingPageData>.GetEnumerator
	|-List<SkillStack.Packet>.GetEnumerator
	|-List<SolanelInfoMenuContent.SolanelUnit>.GetEnumerator
	|-List<SoundSystem.ResultSoundLoad>.GetEnumerator
	|-List<SoundSystem.SoundHandle>.GetEnumerator
	|-List<StructHeader.Param>.GetEnumerator
	|-List<TitleSequence.PedestalData>.GetEnumerator
	|-List<UnitSelectMenu.UnitSelectMenuItem>.GetEnumerator
	|-List<UnitStatusSetter.CapabilityValueParam>.GetEnumerator
	|-List<UnitStatusSetter.SkillSetter>.GetEnumerator
	|-List<UnitStatusSetter.WeaponLevelSetter>.GetEnumerator
	|-List<EventDemoSequence.SoundEnv.EventNameData>.GetEnumerator
	|-List<SoundWwise.SoundBankManager.BankHandle>.GetEnumerator
	|-List<TitleSequence.ProcTitleCall.TitleCallData>.GetEnumerator
	|-List<VersusSequence.VersusSequenceLocal.MetaDataPack>.GetEnumerator
	|
	|-RVA: 0x3B1B120 Offset: 0x3B1B221 VA: 0x3B1B120
	|-List<CommonBattleSequence.Reliance<object>>.GetEnumerator
	|
	|-RVA: 0x3B1E160 Offset: 0x3B1E261 VA: 0x3B1E160
	|-List<RenderGraphResourcePool.ResourceLogInfo<object>>.GetEnumerator
	|
	|-RVA: 0x3B21080 Offset: 0x3B21181 VA: 0x3B21080
	|-List<ValueTuple<int, object>>.GetEnumerator
	|
	|-RVA: 0x3DE1C60 Offset: 0x3DE1D61 VA: 0x3DE1C60
	|-List<ValueTuple<Int32Enum, int>>.GetEnumerator
	|
	|-RVA: 0x3DE4CF0 Offset: 0x3DE4DF1 VA: 0x3DE4CF0
	|-List<ValueTuple<object, ValueTuple<object, int>>>.GetEnumerator
	|-List<ValueTuple<object, ValueTuple<Type, int>>>.GetEnumerator
	|
	|-RVA: 0x3DE7D30 Offset: 0x3DE7E31 VA: 0x3DE7D30
	|-List<ValueTuple<object, int>>.GetEnumerator
	|
	|-RVA: 0x3DEAD10 Offset: 0x3DEAE11 VA: 0x3DEAD10
	|-List<ValueTuple<Vector3, float>>.GetEnumerator
	|
	|-RVA: 0x3DEDC50 Offset: 0x3DEDD51 VA: 0x3DEDC50
	|-List<ValueTuple<object, Int32Enum, int>>.GetEnumerator
	|
	|-RVA: 0x3DF0D40 Offset: 0x3DF0E41 VA: 0x3DF0D40
	|-List<ValueTuple<object, int, int, int>>.GetEnumerator
	|
	|-RVA: 0x3DF3CD0 Offset: 0x3DF3DD1 VA: 0x3DF3CD0
	|-List<AnimatorClipInfo>.GetEnumerator
	|
	|-RVA: 0x3DF6D60 Offset: 0x3DF6E61 VA: 0x3DF6D60
	|-List<AsyncOperationHandle>.GetEnumerator
	|
	|-RVA: 0x3DF9F60 Offset: 0x3DFA061 VA: 0x3DF9F60
	|-List<BoneWeight>.GetEnumerator
	|
	|-RVA: 0x3DFCF00 Offset: 0x3DFD001 VA: 0x3DFCF00
	|-List<bool>.GetEnumerator
	|
	|-RVA: 0x3E7A450 Offset: 0x3E7A551 VA: 0x3E7A450
	|-List<byte>.GetEnumerator
	|
	|-RVA: 0x3E7D300 Offset: 0x3E7D401 VA: 0x3E7D300
	|-List<CameraInfo>.GetEnumerator
	|
	|-RVA: 0x3E80170 Offset: 0x3E80271 VA: 0x3E80170
	|-List<char>.GetEnumerator
	|
	|-RVA: 0x3E830E0 Offset: 0x3E831E1 VA: 0x3E830E0
	|-List<Color>.GetEnumerator
	|
	|-RVA: 0x3E85F70 Offset: 0x3E86071 VA: 0x3E85F70
	|-List<Color32>.GetEnumerator
	|
	|-RVA: 0x3E88E30 Offset: 0x3E88F31 VA: 0x3E88E30
	|-List<ConstraintSource>.GetEnumerator
	|
	|-RVA: 0x3E8BF20 Offset: 0x3E8C021 VA: 0x3E8BF20
	|-List<ContourVertex>.GetEnumerator
	|
	|-RVA: 0x3E8F120 Offset: 0x3E8F221 VA: 0x3E8F120
	|-List<DataStoreRatingInfo>.GetEnumerator
	|
	|-RVA: 0x3E92090 Offset: 0x3E92191 VA: 0x3E92090
	|-List<DataStoreResult>.GetEnumerator
	|
	|-RVA: 0x3E94EA0 Offset: 0x3E94FA1 VA: 0x3E94EA0
	|-List<DateTime>.GetEnumerator
	|
	|-RVA: 0x3E97D40 Offset: 0x3E97E41 VA: 0x3E97D40
	|-List<DateTimeOffset>.GetEnumerator
	|
	|-RVA: 0x3E9AC20 Offset: 0x3E9AD21 VA: 0x3E9AC20
	|-List<Decimal>.GetEnumerator
	|
	|-RVA: 0x3E9DE40 Offset: 0x3E9DF41 VA: 0x3E9DE40
	|-List<DiagnosticEvent>.GetEnumerator
	|
	|-RVA: 0x3EA0EC0 Offset: 0x3EA0FC1 VA: 0x3EA0EC0
	|-List<double>.GetEnumerator
	|
	|-RVA: 0x3EA4000 Offset: 0x3EA4101 VA: 0x3EA4000
	|-List<Friend>.GetEnumerator
	|
	|-RVA: 0x3EA70F0 Offset: 0x3EA71F1 VA: 0x3EA70F0
	|-List<GlyphRect>.GetEnumerator
	|
	|-RVA: 0x3EA9F40 Offset: 0x3EAA041 VA: 0x3EA9F40
	|-List<short>.GetEnumerator
	|
	|-RVA: 0x3EACD40 Offset: 0x3EACE41 VA: 0x3EACD40
	|-List<int>.GetEnumerator
	|
	|-RVA: 0x3EAFB40 Offset: 0x3EAFC41 VA: 0x3EAFB40
	|-List<Int32Enum>.GetEnumerator
	|-List<MapPanelActive.MeshIndex>.GetEnumerator
	|
	|-RVA: 0x3EB2940 Offset: 0x3EB2A41 VA: 0x3EB2940
	|-List<long>.GetEnumerator
	|
	|-RVA: 0x3DFFD10 Offset: 0x3DFFE11 VA: 0x3DFFD10
	|-List<IntPtr>.GetEnumerator
	|
	|-RVA: 0x3E02BC0 Offset: 0x3E02CC1 VA: 0x3E02BC0
	|-List<InterpretedFrameInfo>.GetEnumerator
	|
	|-RVA: 0x3E05CA0 Offset: 0x3E05DA1 VA: 0x3E05CA0
	|-List<IntervalTreeNode>.GetEnumerator
	|
	|-RVA: 0x3E08C10 Offset: 0x3E08D11 VA: 0x3E08C10
	|-List<LengthLimitProperties>.GetEnumerator
	|
	|-RVA: 0x3E0BA20 Offset: 0x3E0BB21 VA: 0x3E0BA20
	|-List<MapPos>.GetEnumerator
	|
	|-RVA: 0x3E0ECB0 Offset: 0x3E0EDB1 VA: 0x3E0ECB0
	|-List<Matrix4x4>.GetEnumerator
	|
	|-RVA: 0x3E14F40 Offset: 0x3E15041 VA: 0x3E14F40
	|-List<ObjectInitializationData>.GetEnumerator
	|
	|-RVA: 0x3E18230 Offset: 0x3E18331 VA: 0x3E18230
	|-List<PlayableBinding>.GetEnumerator
	|
	|-RVA: 0x3E1B560 Offset: 0x3E1B661 VA: 0x3E1B560
	|-List<PlayerLoopSystem>.GetEnumerator
	|
	|-RVA: 0x3DA5A00 Offset: 0x3DA5B01 VA: 0x3DA5A00
	|-List<PlayerLoopSystemInternal>.GetEnumerator
	|
	|-RVA: 0x3DA8AF0 Offset: 0x3DA8BF1 VA: 0x3DA8AF0
	|-List<RangePositionInfo>.GetEnumerator
	|
	|-RVA: 0x3DAB960 Offset: 0x3DABA61 VA: 0x3DAB960
	|-List<Ranking2ChartInfoInput>.GetEnumerator
	|
	|-RVA: 0x3DAEB30 Offset: 0x3DAEC31 VA: 0x3DAEB30
	|-List<RaycastHit2D>.GetEnumerator
	|
	|-RVA: 0x3DB2190 Offset: 0x3DB2291 VA: 0x3DB2190
	|-List<RaycastResult>.GetEnumerator
	|
	|-RVA: 0x3DB5510 Offset: 0x3DB5611 VA: 0x3DB5510
	|-List<Rect>.GetEnumerator
	|
	|-RVA: 0x3DB83A0 Offset: 0x3DB84A1 VA: 0x3DB83A0
	|-List<RendererListHandle>.GetEnumerator
	|
	|-RVA: 0x3DBB1B0 Offset: 0x3DBB2B1 VA: 0x3DBB1B0
	|-List<ResourceHandle>.GetEnumerator
	|
	|-RVA: 0x3DBDFD0 Offset: 0x3DBE0D1 VA: 0x3DBDFD0
	|-List<sbyte>.GetEnumerator
	|
	|-RVA: 0x3DC0DD0 Offset: 0x3DC0ED1 VA: 0x3DC0DD0
	|-List<ShaderTagId>.GetEnumerator
	|
	|-RVA: 0x3E3CA40 Offset: 0x3E3CB41 VA: 0x3E3CA40
	|-List<float>.GetEnumerator
	|
	|-RVA: 0x3E40150 Offset: 0x3E40251 VA: 0x3E40150
	|-List<SphericalHarmonicsL2>.GetEnumerator
	|
	|-RVA: 0x3E438E0 Offset: 0x3E439E1 VA: 0x3E438E0
	|-List<SubMeshDescriptor>.GetEnumerator
	|
	|-RVA: 0x3E469D0 Offset: 0x3E46AD1 VA: 0x3E469D0
	|-List<TablePair>.GetEnumerator
	|
	|-RVA: 0x3E49840 Offset: 0x3E49941 VA: 0x3E49840
	|-List<TimeSpan>.GetEnumerator
	|
	|-RVA: 0x3E4C790 Offset: 0x3E4C891 VA: 0x3E4C790
	|-List<UICharInfo>.GetEnumerator
	|
	|-RVA: 0x3E4F6C0 Offset: 0x3E4F7C1 VA: 0x3E4F6C0
	|-List<UILineInfo>.GetEnumerator
	|
	|-RVA: 0x3E52E10 Offset: 0x3E52F11 VA: 0x3E52E10
	|-List<UIVertex>.GetEnumerator
	|
	|-RVA: 0x3E561F0 Offset: 0x3E562F1 VA: 0x3E561F0
	|-List<ushort>.GetEnumerator
	|
	|-RVA: 0x3E58FF0 Offset: 0x3E590F1 VA: 0x3E58FF0
	|-List<uint>.GetEnumerator
	|
	|-RVA: 0x3DC3BE0 Offset: 0x3DC3CE1 VA: 0x3DC3BE0
	|-List<ulong>.GetEnumerator
	|
	|-RVA: 0x3DC6A70 Offset: 0x3DC6B71 VA: 0x3DC6A70
	|-List<Vector2>.GetEnumerator
	|
	|-RVA: 0x3DC99F0 Offset: 0x3DC9AF1 VA: 0x3DC99F0
	|-List<Vector3>.GetEnumerator
	|
	|-RVA: 0x3DCCA00 Offset: 0x3DCCB01 VA: 0x3DCCA00
	|-List<Vector4>.GetEnumerator
	|
	|-RVA: 0x3DCF920 Offset: 0x3DCFA21 VA: 0x3DCF920
	|-List<VertexAttributeDescriptor>.GetEnumerator
	|
	|-RVA: 0x3DD2820 Offset: 0x3DD2921 VA: 0x3DD2820
	|-List<X509ChainStatus>.GetEnumerator
	|
	|-RVA: 0x3DD5A10 Offset: 0x3DD5B11 VA: 0x3DD5A10
	|-List<XRView>.GetEnumerator
	|
	|-RVA: 0x3DD8B30 Offset: 0x3DD8C31 VA: 0x3DD8B30
	|-List<AmiiboSequence.GainItemData>.GetEnumerator
	|
	|-RVA: 0x3DDBD20 Offset: 0x3DDBE21 VA: 0x3DDBD20
	|-List<AnimationOutputWeightProcessor.WeightInfo>.GetEnumerator
	|
	|-RVA: 0x3DDEDF0 Offset: 0x3DDEEF1 VA: 0x3DDEDF0
	|-List<ArenaOrderSequence.GodInfo>.GetEnumerator
	|
	|-RVA: 0x3E1E650 Offset: 0x3E1E751 VA: 0x3E1E650
	|-List<BattleInfo.SupportData>.GetEnumerator
	|
	|-RVA: 0x3E21570 Offset: 0x3E21671 VA: 0x3E21570
	|-List<BeforeRenderHelper.OrderBlock>.GetEnumerator
	|
	|-RVA: 0x3E24670 Offset: 0x3E24771 VA: 0x3E24670
	|-List<Camera.RenderRequest>.GetEnumerator
	|
	|-RVA: 0x3E276C0 Offset: 0x3E277C1 VA: 0x3E276C0
	|-List<CameraState.CustomBlendable>.GetEnumerator
	|
	|-RVA: 0x3E2A530 Offset: 0x3E2A631 VA: 0x3E2A530
	|-List<CinemachineClearShot.Pair>.GetEnumerator
	|
	|-RVA: 0x3E2D340 Offset: 0x3E2D441 VA: 0x3E2D340
	|-List<CinemachineStateDrivenCamera.HashPair>.GetEnumerator
	|
	|-RVA: 0x3E303D0 Offset: 0x3E304D1 VA: 0x3E303D0
	|-List<DelayedActionManager.DelegateInfo>.GetEnumerator
	|
	|-RVA: 0x3E33720 Offset: 0x3E33821 VA: 0x3E33720
	|-List<Detail.AsyncResultInt>.GetEnumerator
	|
	|-RVA: 0x3E367F0 Offset: 0x3E368F1 VA: 0x3E367F0
	|-List<Detail.CppArray>.GetEnumerator
	|
	|-RVA: 0x3E399F0 Offset: 0x3E39AF1 VA: 0x3E399F0
	|-List<Detail.NotificationEventInt>.GetEnumerator
	|
	|-RVA: 0x3E5BEA0 Offset: 0x3E5BFA1 VA: 0x3E5BEA0
	|-List<DragonRideTargetGroup.ChainParam>.GetEnumerator
	|
	|-RVA: 0x3E5EF90 Offset: 0x3E5F091 VA: 0x3E5EF90
	|-List<GmapPathAdjuster.TargetModel>.GetEnumerator
	|
	|-RVA: 0x3E621A0 Offset: 0x3E622A1 VA: 0x3E621A0
	|-List<GmapSpotAdjuster.TargetModel>.GetEnumerator
	|
	|-RVA: 0x3E653B0 Offset: 0x3E654B1 VA: 0x3E653B0
	|-List<HubFastTravel.Location>.GetEnumerator
	|
	|-RVA: 0x3E68710 Offset: 0x3E68811 VA: 0x3E68710
	|-List<HubLensFlare.Flare>.GetEnumerator
	|
	|-RVA: 0x3E6B830 Offset: 0x3E6B931 VA: 0x3E6B830
	|-List<InventoryPoolItemMenuContent.KindBgNameClass>.GetEnumerator
	|
	|-RVA: 0x3E6E6A0 Offset: 0x3E6E7A1 VA: 0x3E6E6A0
	|-List<Map.Pos>.GetEnumerator
	|
	|-RVA: 0x3E71540 Offset: 0x3E71641 VA: 0x3E71540
	|-List<MapImage.BackupTerrain>.GetEnumerator
	|
	|-RVA: 0x3E74400 Offset: 0x3E74501 VA: 0x3E74400
	|-List<MapImageRange.Pos>.GetEnumerator
	|
	|-RVA: 0x3E774B0 Offset: 0x3E775B1 VA: 0x3E774B0
	|-List<MapMind.Target>.GetEnumerator
	|
	|-RVA: 0x3D870A0 Offset: 0x3D871A1 VA: 0x3D870A0
	|-List<MapPanelDebug.Entity>.GetEnumerator
	|
	|-RVA: 0x3D8A010 Offset: 0x3D8A111 VA: 0x3D8A010
	|-List<NexRanking.Data>.GetEnumerator
	|
	|-RVA: 0x3D8CEB0 Offset: 0x3D8CFB1 VA: 0x3D8CEB0
	|-List<NexVersus.RatingData>.GetEnumerator
	|
	|-RVA: 0x3D8FDB0 Offset: 0x3D8FEB1 VA: 0x3D8FDB0
	|-List<PackedPlayModeBuildLogs.RuntimeBuildLog>.GetEnumerator
	|
	|-RVA: 0x3D92F80 Offset: 0x3D93081 VA: 0x3D92F80
	|-List<ParticleSystem.Particle>.GetEnumerator
	|
	|-RVA: 0x3D95FD0 Offset: 0x3D960D1 VA: 0x3D95FD0
	|-List<RangeData.Offset>.GetEnumerator
	|
	|-RVA: 0x3D99060 Offset: 0x3D99161 VA: 0x3D99060
	|-List<RenderGraphDebugData.PassDebugData>.GetEnumerator
	|
	|-RVA: 0x3D9C390 Offset: 0x3D9C491 VA: 0x3D9C390
	|-List<RenderGraphDebugData.ResourceDebugData>.GetEnumerator
	|
	|-RVA: 0x3D9F480 Offset: 0x3D9F581 VA: 0x3D9F480
	|-List<RingCleaningUnitSelectMenu.GodParam>.GetEnumerator
	|
	|-RVA: 0x3DA2670 Offset: 0x3DA2771 VA: 0x3DA2670
	|-List<ShadowUtility.Edge>.GetEnumerator
	|
	|-RVA: 0x3D14B40 Offset: 0x3D14C41 VA: 0x3D14B40
	|-List<SkillArray.Entity>.GetEnumerator
	|
	|-RVA: 0x3D17DE0 Offset: 0x3D17EE1 VA: 0x3D17DE0
	|-List<TexturePacker_JsonArray.Frame>.GetEnumerator
	|
	|-RVA: 0x3D1B1A0 Offset: 0x3D1B2A1 VA: 0x3D1B1A0
	|-List<TimeNotificationBehaviour.NotificationEntry>.GetEnumerator
	|
	|-RVA: 0x3D1E3C0 Offset: 0x3D1E4C1 VA: 0x3D1E3C0
	|-List<UnitySynchronizationContext.WorkRequest>.GetEnumerator
	|
	|-RVA: 0x3D21400 Offset: 0x3D21501 VA: 0x3D21400
	|-List<XmlSchemaObjectTable.XmlSchemaObjectEntry>.GetEnumerator
	|
	|-RVA: 0x3D24320 Offset: 0x3D24421 VA: 0x3D24320
	|-List<AssetBundleBuildMap.AssetBundleEntry.AssetPathString>.GetEnumerator
	|
	|-RVA: 0x3D27520 Offset: 0x3D27621 VA: 0x3D27520
	|-List<Detail.DataStore.DataStoreChangeMetaParamInt>.GetEnumerator
	|
	|-RVA: 0x3D2A640 Offset: 0x3D2A741 VA: 0x3D2A640
	|-List<Detail.DataStore.DataStoreDeleteParamInt>.GetEnumerator
	|
	|-RVA: 0x3D2D810 Offset: 0x3D2D911 VA: 0x3D2D810
	|-List<Detail.DataStore.DataStoreGetMetaParamInt>.GetEnumerator
	|
	|-RVA: 0x3D30BA0 Offset: 0x3D30CA1 VA: 0x3D30BA0
	|-List<Detail.DataStore.DataStoreMetaInfoInt>.GetEnumerator
	|
	|-RVA: 0x3CF52E0 Offset: 0x3CF53E1 VA: 0x3CF52E0
	|-List<Detail.DataStore.DataStorePasswordInfoInt>.GetEnumerator
	|
	|-RVA: 0x3CF84C0 Offset: 0x3CF85C1 VA: 0x3CF84C0
	|-List<Detail.DataStore.DataStorePersistenceInfoInt>.GetEnumerator
	|
	|-RVA: 0x3CFB790 Offset: 0x3CFB891 VA: 0x3CFB790
	|-List<Detail.DataStore.DataStorePreparePostParamInt>.GetEnumerator
	|
	|-RVA: 0x3CFE870 Offset: 0x3CFE971 VA: 0x3CFE870
	|-List<Detail.DataStore.DataStoreRateObjectParamInt>.GetEnumerator
	|
	|-RVA: 0x3D01930 Offset: 0x3D01A31 VA: 0x3D01930
	|-List<Detail.DataStore.DataStoreRatingInitParamInt>.GetEnumerator
	|
	|-RVA: 0x3D04940 Offset: 0x3D04A41 VA: 0x3D04940
	|-List<Detail.DataStore.DataStoreRatingTargetInt>.GetEnumerator
	|
	|-RVA: 0x3D07C60 Offset: 0x3D07D61 VA: 0x3D07C60
	|-List<Detail.Ranking.RankingCachedResultInt>.GetEnumerator
	|
	|-RVA: 0x3D0AE00 Offset: 0x3D0AF01 VA: 0x3D0AE00
	|-List<Detail.Ranking.RankingOrderParamInt>.GetEnumerator
	|
	|-RVA: 0x3D0E0D0 Offset: 0x3D0E1D1 VA: 0x3D0E0D0
	|-List<Detail.Ranking.RankingRankDataInt>.GetEnumerator
	|
	|-RVA: 0x3D118B0 Offset: 0x3D119B1 VA: 0x3D118B0
	|-List<Detail.Ranking2.Ranking2ChartInfoInt>.GetEnumerator
	|
	|-RVA: 0x3D68050 Offset: 0x3D68151 VA: 0x3D68050
	|-List<Detail.Ranking2.Ranking2RankDataInt>.GetEnumerator
	|
	|-RVA: 0x3D6B1E0 Offset: 0x3D6B2E1 VA: 0x3D6B1E0
	|-List<Detail.Ranking2.Ranking2ScoreDataInt>.GetEnumerator
	|
	|-RVA: 0x3D6E2A0 Offset: 0x3D6E3A1 VA: 0x3D6E2A0
	|-List<Detail.Screening.ScreeningContextInfoInt>.GetEnumerator
	|
	|-RVA: 0x3D71810 Offset: 0x3D71911 VA: 0x3D71810
	|-List<Detail.Subscriber.SubscriberContentInt>.GetEnumerator
	|
	|-RVA: 0x3D74C60 Offset: 0x3D74D61 VA: 0x3D74C60
	|-List<Detail.Subscriber.SubscriberGetContentParamInt>.GetEnumerator
	|
	|-RVA: 0x3D77F50 Offset: 0x3D78051 VA: 0x3D77F50
	|-List<Detail.Subscriber.SubscriberUserStatusInfoInt>.GetEnumerator
	|
	|-RVA: 0x3D7B1E0 Offset: 0x3D7B2E1 VA: 0x3D7B1E0
	|-List<Detail.Subscriber.SubscriberUserStatusParamInt>.GetEnumerator
	|
	|-RVA: 0x3D7E150 Offset: 0x3D7E251 VA: 0x3D7E150
	|-List<Detail.Utility.IntegerSettings>.GetEnumerator
	|
	|-RVA: 0x3D80FF0 Offset: 0x3D810F1 VA: 0x3D80FF0
	|-List<Detail.Utility.UniqueIdInfoInt>.GetEnumerator
	|
	|-RVA: 0x3D83F70 Offset: 0x3D84071 VA: 0x3D83F70
	|-List<MapHistory.Rewind.LatestInspectorData>.GetEnumerator
	|
	|-RVA: 0x3060230 Offset: 0x3060331 VA: 0x3060230
	|-List<MapHistory.Rewind.WorkTerrainData>.GetEnumerator
	|
	|-RVA: 0x30631A0 Offset: 0x30632A1 VA: 0x30631A0
	|-List<MapSkill.AroundCalculator.Result>.GetEnumerator
	|
	|-RVA: 0x3066390 Offset: 0x3066491 VA: 0x3066390
	|-List<TargetPositionCache.CacheCurve.Item>.GetEnumerator
	|
	|-RVA: 0x3069750 Offset: 0x3069851 VA: 0x3069750
	|-List<TargetPositionCache.CacheEntry.RecordingItem>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 16
	private IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3B0C000 Offset: 0x3B0C101 VA: 0x3B0C000
	|-List<IntervalTree.Entry<object>>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x3B0F030 Offset: 0x3B0F131 VA: 0x3B0F030
	|-List<KeyValuePair<DateTime, object>>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x3B11F50 Offset: 0x3B12051 VA: 0x3B11F50
	|-List<KeyValuePair<int, object>>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x3B15050 Offset: 0x3B15151 VA: 0x3B15050
	|-List<KeyValuePair<object, ValueTuple<int, DateTime, object>>>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x3B18090 Offset: 0x3B18191 VA: 0x3B18090
	|-List<KeyValuePair<object, object>>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x3B1B190 Offset: 0x3B1B291 VA: 0x3B1B190
	|-List<CommonBattleSequence.Reliance<object>>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x3B1E1C0 Offset: 0x3B1E2C1 VA: 0x3B1E1C0
	|-List<RenderGraphResourcePool.ResourceLogInfo<object>>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x3B210E0 Offset: 0x3B211E1 VA: 0x3B210E0
	|-List<ValueTuple<int, object>>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x3DE1CC0 Offset: 0x3DE1DC1 VA: 0x3DE1CC0
	|-List<ValueTuple<Int32Enum, int>>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x3DE4D60 Offset: 0x3DE4E61 VA: 0x3DE4D60
	|-List<ValueTuple<object, ValueTuple<object, int>>>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x3DE7D90 Offset: 0x3DE7E91 VA: 0x3DE7D90
	|-List<ValueTuple<object, int>>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x3DEAD70 Offset: 0x3DEAE71 VA: 0x3DEAD70
	|-List<ValueTuple<Vector3, float>>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x3DEDCB0 Offset: 0x3DEDDB1 VA: 0x3DEDCB0
	|-List<ValueTuple<object, Int32Enum, int>>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x3DF0DB0 Offset: 0x3DF0EB1 VA: 0x3DF0DB0
	|-List<ValueTuple<object, int, int, int>>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x3DF3D30 Offset: 0x3DF3E31 VA: 0x3DF3D30
	|-List<AnimatorClipInfo>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x3DF6DD0 Offset: 0x3DF6ED1 VA: 0x3DF6DD0
	|-List<AsyncOperationHandle>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x3DF9FD0 Offset: 0x3DFA0D1 VA: 0x3DF9FD0
	|-List<BoneWeight>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x3DFCF60 Offset: 0x3DFD061 VA: 0x3DFCF60
	|-List<bool>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x3E7A4B0 Offset: 0x3E7A5B1 VA: 0x3E7A4B0
	|-List<byte>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x3E11DB0 Offset: 0x3E11EB1 VA: 0x3E11DB0
	|-List<Camera>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-List<Decorator>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-List<DynValue>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-List<GameObject>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-List<MapBackup>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-List<object>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-List<Phase>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-List<ProfileCard>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-List<Unit>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-List<AssetTable.Accessory>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-List<GameSaveDataHeaderReader.Handle>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-List<MapDispos.ActualData>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-List<MapDispos.Pos>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-List<MapLayer.Data>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-List<MapObject.RigidInfo>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-List<RingListSequence.PageData>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x3E7D360 Offset: 0x3E7D461 VA: 0x3E7D360
	|-List<CameraInfo>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x3E801D0 Offset: 0x3E802D1 VA: 0x3E801D0
	|-List<char>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x3E83140 Offset: 0x3E83241 VA: 0x3E83140
	|-List<Color>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x3E85FD0 Offset: 0x3E860D1 VA: 0x3E85FD0
	|-List<Color32>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x3E88E90 Offset: 0x3E88F91 VA: 0x3E88E90
	|-List<ConstraintSource>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x3E8BF90 Offset: 0x3E8C091 VA: 0x3E8BF90
	|-List<ContourVertex>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x3E8F190 Offset: 0x3E8F291 VA: 0x3E8F190
	|-List<DataStoreRatingInfo>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x3E920F0 Offset: 0x3E921F1 VA: 0x3E920F0
	|-List<DataStoreResult>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x3E94F00 Offset: 0x3E95001 VA: 0x3E94F00
	|-List<DateTime>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x3E97DA0 Offset: 0x3E97EA1 VA: 0x3E97DA0
	|-List<DateTimeOffset>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x3E9AC80 Offset: 0x3E9AD81 VA: 0x3E9AC80
	|-List<Decimal>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x3E9DEB0 Offset: 0x3E9DFB1 VA: 0x3E9DEB0
	|-List<DiagnosticEvent>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x3EA0F20 Offset: 0x3EA1021 VA: 0x3EA0F20
	|-List<double>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x3EA4080 Offset: 0x3EA4181 VA: 0x3EA4080
	|-List<Friend>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x3EA7150 Offset: 0x3EA7251 VA: 0x3EA7150
	|-List<GlyphRect>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x3EA9FA0 Offset: 0x3EAA0A1 VA: 0x3EA9FA0
	|-List<short>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x3EACDA0 Offset: 0x3EACEA1 VA: 0x3EACDA0
	|-List<int>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x3EAFBA0 Offset: 0x3EAFCA1 VA: 0x3EAFBA0
	|-List<Int32Enum>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x3EB29A0 Offset: 0x3EB2AA1 VA: 0x3EB29A0
	|-List<long>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x3DFFD70 Offset: 0x3DFFE71 VA: 0x3DFFD70
	|-List<IntPtr>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x3E02C20 Offset: 0x3E02D21 VA: 0x3E02C20
	|-List<InterpretedFrameInfo>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x3E05D10 Offset: 0x3E05E11 VA: 0x3E05D10
	|-List<IntervalTreeNode>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x3E08C70 Offset: 0x3E08D71 VA: 0x3E08C70
	|-List<LengthLimitProperties>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x3E0BA80 Offset: 0x3E0BB81 VA: 0x3E0BA80
	|-List<MapPos>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x3E0ED30 Offset: 0x3E0EE31 VA: 0x3E0ED30
	|-List<Matrix4x4>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x3E14FB0 Offset: 0x3E150B1 VA: 0x3E14FB0
	|-List<ObjectInitializationData>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x3E182A0 Offset: 0x3E183A1 VA: 0x3E182A0
	|-List<PlayableBinding>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x3E1B5D0 Offset: 0x3E1B6D1 VA: 0x3E1B5D0
	|-List<PlayerLoopSystem>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x3DA5A70 Offset: 0x3DA5B71 VA: 0x3DA5A70
	|-List<PlayerLoopSystemInternal>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x3DA8B50 Offset: 0x3DA8C51 VA: 0x3DA8B50
	|-List<RangePositionInfo>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x3DAB9C0 Offset: 0x3DABAC1 VA: 0x3DAB9C0
	|-List<Ranking2ChartInfoInput>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x3DAEBA0 Offset: 0x3DAECA1 VA: 0x3DAEBA0
	|-List<RaycastHit2D>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x3DB2220 Offset: 0x3DB2321 VA: 0x3DB2220
	|-List<RaycastResult>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x3DB5570 Offset: 0x3DB5671 VA: 0x3DB5570
	|-List<Rect>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x3DB8400 Offset: 0x3DB8501 VA: 0x3DB8400
	|-List<RendererListHandle>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x3DBB210 Offset: 0x3DBB311 VA: 0x3DBB210
	|-List<ResourceHandle>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x3DBE030 Offset: 0x3DBE131 VA: 0x3DBE030
	|-List<sbyte>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x3DC0E30 Offset: 0x3DC0F31 VA: 0x3DC0E30
	|-List<ShaderTagId>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x3E3CAA0 Offset: 0x3E3CBA1 VA: 0x3E3CAA0
	|-List<float>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x3E401F0 Offset: 0x3E402F1 VA: 0x3E401F0
	|-List<SphericalHarmonicsL2>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x3E43950 Offset: 0x3E43A51 VA: 0x3E43950
	|-List<SubMeshDescriptor>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x3E46A30 Offset: 0x3E46B31 VA: 0x3E46A30
	|-List<TablePair>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x3E498A0 Offset: 0x3E499A1 VA: 0x3E498A0
	|-List<TimeSpan>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x3E4C7F0 Offset: 0x3E4C8F1 VA: 0x3E4C7F0
	|-List<UICharInfo>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x3E4F720 Offset: 0x3E4F821 VA: 0x3E4F720
	|-List<UILineInfo>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x3E52EB0 Offset: 0x3E52FB1 VA: 0x3E52EB0
	|-List<UIVertex>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x3E56250 Offset: 0x3E56351 VA: 0x3E56250
	|-List<ushort>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x3E59050 Offset: 0x3E59151 VA: 0x3E59050
	|-List<uint>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x3DC3C40 Offset: 0x3DC3D41 VA: 0x3DC3C40
	|-List<ulong>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x3DC6AD0 Offset: 0x3DC6BD1 VA: 0x3DC6AD0
	|-List<Vector2>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x3DC9A50 Offset: 0x3DC9B51 VA: 0x3DC9A50
	|-List<Vector3>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x3DCCA60 Offset: 0x3DCCB61 VA: 0x3DCCA60
	|-List<Vector4>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x3DCF980 Offset: 0x3DCFA81 VA: 0x3DCF980
	|-List<VertexAttributeDescriptor>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x3DD2880 Offset: 0x3DD2981 VA: 0x3DD2880
	|-List<X509ChainStatus>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x3DD5A90 Offset: 0x3DD5B91 VA: 0x3DD5A90
	|-List<XRView>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x3DD8B90 Offset: 0x3DD8C91 VA: 0x3DD8B90
	|-List<AmiiboSequence.GainItemData>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x3DDBD90 Offset: 0x3DDBE91 VA: 0x3DDBD90
	|-List<AnimationOutputWeightProcessor.WeightInfo>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x3DDEE50 Offset: 0x3DDEF51 VA: 0x3DDEE50
	|-List<ArenaOrderSequence.GodInfo>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x3E1E6B0 Offset: 0x3E1E7B1 VA: 0x3E1E6B0
	|-List<BattleInfo.SupportData>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x3E215D0 Offset: 0x3E216D1 VA: 0x3E215D0
	|-List<BeforeRenderHelper.OrderBlock>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x3E246E0 Offset: 0x3E247E1 VA: 0x3E246E0
	|-List<Camera.RenderRequest>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x3E27720 Offset: 0x3E27821 VA: 0x3E27720
	|-List<CameraState.CustomBlendable>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x3E2A590 Offset: 0x3E2A691 VA: 0x3E2A590
	|-List<CinemachineClearShot.Pair>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x3E2D3A0 Offset: 0x3E2D4A1 VA: 0x3E2D3A0
	|-List<CinemachineStateDrivenCamera.HashPair>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x3E30440 Offset: 0x3E30541 VA: 0x3E30440
	|-List<DelayedActionManager.DelegateInfo>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x3E33790 Offset: 0x3E33891 VA: 0x3E33790
	|-List<Detail.AsyncResultInt>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x3E36850 Offset: 0x3E36951 VA: 0x3E36850
	|-List<Detail.CppArray>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x3E39A60 Offset: 0x3E39B61 VA: 0x3E39A60
	|-List<Detail.NotificationEventInt>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x3E5BF00 Offset: 0x3E5C001 VA: 0x3E5BF00
	|-List<DragonRideTargetGroup.ChainParam>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x3E5F000 Offset: 0x3E5F101 VA: 0x3E5F000
	|-List<GmapPathAdjuster.TargetModel>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x3E62210 Offset: 0x3E62311 VA: 0x3E62210
	|-List<GmapSpotAdjuster.TargetModel>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x3E65420 Offset: 0x3E65521 VA: 0x3E65420
	|-List<HubFastTravel.Location>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x3E68780 Offset: 0x3E68881 VA: 0x3E68780
	|-List<HubLensFlare.Flare>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x3E6B890 Offset: 0x3E6B991 VA: 0x3E6B890
	|-List<InventoryPoolItemMenuContent.KindBgNameClass>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x3E6E700 Offset: 0x3E6E801 VA: 0x3E6E700
	|-List<Map.Pos>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x3E715A0 Offset: 0x3E716A1 VA: 0x3E715A0
	|-List<MapImage.BackupTerrain>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x3E74460 Offset: 0x3E74561 VA: 0x3E74460
	|-List<MapImageRange.Pos>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x3E77520 Offset: 0x3E77621 VA: 0x3E77520
	|-List<MapMind.Target>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x3D87110 Offset: 0x3D87211 VA: 0x3D87110
	|-List<MapPanelDebug.Entity>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x3D8A070 Offset: 0x3D8A171 VA: 0x3D8A070
	|-List<NexRanking.Data>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x3D8CF10 Offset: 0x3D8D011 VA: 0x3D8CF10
	|-List<NexVersus.RatingData>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x3D8FE10 Offset: 0x3D8FF11 VA: 0x3D8FE10
	|-List<PackedPlayModeBuildLogs.RuntimeBuildLog>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x3D93000 Offset: 0x3D93101 VA: 0x3D93000
	|-List<ParticleSystem.Particle>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x3D96030 Offset: 0x3D96131 VA: 0x3D96030
	|-List<RangeData.Offset>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x3D990D0 Offset: 0x3D991D1 VA: 0x3D990D0
	|-List<RenderGraphDebugData.PassDebugData>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x3D9C400 Offset: 0x3D9C501 VA: 0x3D9C400
	|-List<RenderGraphDebugData.ResourceDebugData>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x3D9F4E0 Offset: 0x3D9F5E1 VA: 0x3D9F4E0
	|-List<RingCleaningUnitSelectMenu.GodParam>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x3DA26E0 Offset: 0x3DA27E1 VA: 0x3DA26E0
	|-List<ShadowUtility.Edge>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x3D14BA0 Offset: 0x3D14CA1 VA: 0x3D14BA0
	|-List<SkillArray.Entity>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x3D17E60 Offset: 0x3D17F61 VA: 0x3D17E60
	|-List<TexturePacker_JsonArray.Frame>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x3D1B210 Offset: 0x3D1B311 VA: 0x3D1B210
	|-List<TimeNotificationBehaviour.NotificationEntry>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x3D1E430 Offset: 0x3D1E531 VA: 0x3D1E430
	|-List<UnitySynchronizationContext.WorkRequest>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x3D21460 Offset: 0x3D21561 VA: 0x3D21460
	|-List<XmlSchemaObjectTable.XmlSchemaObjectEntry>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x3D24380 Offset: 0x3D24481 VA: 0x3D24380
	|-List<AssetBundleBuildMap.AssetBundleEntry.AssetPathString>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x3D275A0 Offset: 0x3D276A1 VA: 0x3D275A0
	|-List<Detail.DataStore.DataStoreChangeMetaParamInt>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x3D2A6A0 Offset: 0x3D2A7A1 VA: 0x3D2A6A0
	|-List<Detail.DataStore.DataStoreDeleteParamInt>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x3D2D880 Offset: 0x3D2D981 VA: 0x3D2D880
	|-List<Detail.DataStore.DataStoreGetMetaParamInt>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x3D30C20 Offset: 0x3D30D21 VA: 0x3D30C20
	|-List<Detail.DataStore.DataStoreMetaInfoInt>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x3CF5350 Offset: 0x3CF5451 VA: 0x3CF5350
	|-List<Detail.DataStore.DataStorePasswordInfoInt>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x3CF8530 Offset: 0x3CF8631 VA: 0x3CF8530
	|-List<Detail.DataStore.DataStorePersistenceInfoInt>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x3CFB810 Offset: 0x3CFB911 VA: 0x3CFB810
	|-List<Detail.DataStore.DataStorePreparePostParamInt>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x3CFE8D0 Offset: 0x3CFE9D1 VA: 0x3CFE8D0
	|-List<Detail.DataStore.DataStoreRateObjectParamInt>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x3D019A0 Offset: 0x3D01AA1 VA: 0x3D019A0
	|-List<Detail.DataStore.DataStoreRatingInitParamInt>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x3D049A0 Offset: 0x3D04AA1 VA: 0x3D049A0
	|-List<Detail.DataStore.DataStoreRatingTargetInt>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x3D07CE0 Offset: 0x3D07DE1 VA: 0x3D07CE0
	|-List<Detail.Ranking.RankingCachedResultInt>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x3D0AE60 Offset: 0x3D0AF61 VA: 0x3D0AE60
	|-List<Detail.Ranking.RankingOrderParamInt>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x3D0E150 Offset: 0x3D0E251 VA: 0x3D0E150
	|-List<Detail.Ranking.RankingRankDataInt>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x3D11950 Offset: 0x3D11A51 VA: 0x3D11950
	|-List<Detail.Ranking2.Ranking2ChartInfoInt>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x3D680D0 Offset: 0x3D681D1 VA: 0x3D680D0
	|-List<Detail.Ranking2.Ranking2RankDataInt>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x3D6B240 Offset: 0x3D6B341 VA: 0x3D6B240
	|-List<Detail.Ranking2.Ranking2ScoreDataInt>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x3D6E310 Offset: 0x3D6E411 VA: 0x3D6E310
	|-List<Detail.Screening.ScreeningContextInfoInt>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x3D718A0 Offset: 0x3D719A1 VA: 0x3D718A0
	|-List<Detail.Subscriber.SubscriberContentInt>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x3D74CD0 Offset: 0x3D74DD1 VA: 0x3D74CD0
	|-List<Detail.Subscriber.SubscriberGetContentParamInt>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x3D77FC0 Offset: 0x3D780C1 VA: 0x3D77FC0
	|-List<Detail.Subscriber.SubscriberUserStatusInfoInt>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x3D7B250 Offset: 0x3D7B351 VA: 0x3D7B250
	|-List<Detail.Subscriber.SubscriberUserStatusParamInt>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x3D7E1B0 Offset: 0x3D7E2B1 VA: 0x3D7E1B0
	|-List<Detail.Utility.IntegerSettings>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x3D81050 Offset: 0x3D81151 VA: 0x3D81050
	|-List<Detail.Utility.UniqueIdInfoInt>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x3D83FD0 Offset: 0x3D840D1 VA: 0x3D83FD0
	|-List<MapHistory.Rewind.LatestInspectorData>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x3060290 Offset: 0x3060391 VA: 0x3060290
	|-List<MapHistory.Rewind.WorkTerrainData>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x3063200 Offset: 0x3063301 VA: 0x3063200
	|-List<MapSkill.AroundCalculator.Result>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x3066400 Offset: 0x3066501 VA: 0x3066400
	|-List<TargetPositionCache.CacheCurve.Item>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x30697C0 Offset: 0x30698C1 VA: 0x30697C0
	|-List<TargetPositionCache.CacheEntry.RecordingItem>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 17
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3B0C090 Offset: 0x3B0C191 VA: 0x3B0C090
	|-List<IntervalTree.Entry<object>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3B0F0B0 Offset: 0x3B0F1B1 VA: 0x3B0F0B0
	|-List<KeyValuePair<DateTime, object>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3B11FD0 Offset: 0x3B120D1 VA: 0x3B11FD0
	|-List<KeyValuePair<int, object>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3B150E0 Offset: 0x3B151E1 VA: 0x3B150E0
	|-List<KeyValuePair<object, ValueTuple<int, DateTime, object>>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3B18110 Offset: 0x3B18211 VA: 0x3B18110
	|-List<KeyValuePair<object, object>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3B1B220 Offset: 0x3B1B321 VA: 0x3B1B220
	|-List<CommonBattleSequence.Reliance<object>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3B1E240 Offset: 0x3B1E341 VA: 0x3B1E240
	|-List<RenderGraphResourcePool.ResourceLogInfo<object>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3B21160 Offset: 0x3B21261 VA: 0x3B21160
	|-List<ValueTuple<int, object>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3DE1D40 Offset: 0x3DE1E41 VA: 0x3DE1D40
	|-List<ValueTuple<Int32Enum, int>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3DE4DF0 Offset: 0x3DE4EF1 VA: 0x3DE4DF0
	|-List<ValueTuple<object, ValueTuple<object, int>>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3DE7E10 Offset: 0x3DE7F11 VA: 0x3DE7E10
	|-List<ValueTuple<object, int>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3DEADF0 Offset: 0x3DEAEF1 VA: 0x3DEADF0
	|-List<ValueTuple<Vector3, float>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3DEDD30 Offset: 0x3DEDE31 VA: 0x3DEDD30
	|-List<ValueTuple<object, Int32Enum, int>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3DF0E40 Offset: 0x3DF0F41 VA: 0x3DF0E40
	|-List<ValueTuple<object, int, int, int>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3DF3DB0 Offset: 0x3DF3EB1 VA: 0x3DF3DB0
	|-List<AnimatorClipInfo>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3DF6E60 Offset: 0x3DF6F61 VA: 0x3DF6E60
	|-List<AsyncOperationHandle>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3DFA060 Offset: 0x3DFA161 VA: 0x3DFA060
	|-List<BoneWeight>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3DFCFE0 Offset: 0x3DFD0E1 VA: 0x3DFCFE0
	|-List<bool>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3E7A530 Offset: 0x3E7A631 VA: 0x3E7A530
	|-List<byte>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3E11E30 Offset: 0x3E11F31 VA: 0x3E11E30
	|-List<Camera>.System.Collections.IEnumerable.GetEnumerator
	|-List<Decorator>.System.Collections.IEnumerable.GetEnumerator
	|-List<DynValue>.System.Collections.IEnumerable.GetEnumerator
	|-List<GameObject>.System.Collections.IEnumerable.GetEnumerator
	|-List<MapBackup>.System.Collections.IEnumerable.GetEnumerator
	|-List<object>.System.Collections.IEnumerable.GetEnumerator
	|-List<Phase>.System.Collections.IEnumerable.GetEnumerator
	|-List<ProfileCard>.System.Collections.IEnumerable.GetEnumerator
	|-List<Unit>.System.Collections.IEnumerable.GetEnumerator
	|-List<AssetTable.Accessory>.System.Collections.IEnumerable.GetEnumerator
	|-List<GameSaveDataHeaderReader.Handle>.System.Collections.IEnumerable.GetEnumerator
	|-List<MapDispos.ActualData>.System.Collections.IEnumerable.GetEnumerator
	|-List<MapDispos.Pos>.System.Collections.IEnumerable.GetEnumerator
	|-List<MapLayer.Data>.System.Collections.IEnumerable.GetEnumerator
	|-List<MapObject.RigidInfo>.System.Collections.IEnumerable.GetEnumerator
	|-List<RingListSequence.PageData>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3E7D3E0 Offset: 0x3E7D4E1 VA: 0x3E7D3E0
	|-List<CameraInfo>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3E80250 Offset: 0x3E80351 VA: 0x3E80250
	|-List<char>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3E831C0 Offset: 0x3E832C1 VA: 0x3E831C0
	|-List<Color>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3E86050 Offset: 0x3E86151 VA: 0x3E86050
	|-List<Color32>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3E88F10 Offset: 0x3E89011 VA: 0x3E88F10
	|-List<ConstraintSource>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3E8C020 Offset: 0x3E8C121 VA: 0x3E8C020
	|-List<ContourVertex>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3E8F220 Offset: 0x3E8F321 VA: 0x3E8F220
	|-List<DataStoreRatingInfo>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3E92170 Offset: 0x3E92271 VA: 0x3E92170
	|-List<DataStoreResult>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3E94F80 Offset: 0x3E95081 VA: 0x3E94F80
	|-List<DateTime>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3E97E20 Offset: 0x3E97F21 VA: 0x3E97E20
	|-List<DateTimeOffset>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3E9AD00 Offset: 0x3E9AE01 VA: 0x3E9AD00
	|-List<Decimal>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3E9DF50 Offset: 0x3E9E051 VA: 0x3E9DF50
	|-List<DiagnosticEvent>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3EA0FA0 Offset: 0x3EA10A1 VA: 0x3EA0FA0
	|-List<double>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3EA4120 Offset: 0x3EA4221 VA: 0x3EA4120
	|-List<Friend>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3EA71D0 Offset: 0x3EA72D1 VA: 0x3EA71D0
	|-List<GlyphRect>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3EAA020 Offset: 0x3EAA121 VA: 0x3EAA020
	|-List<short>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3EACE20 Offset: 0x3EACF21 VA: 0x3EACE20
	|-List<int>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3EAFC20 Offset: 0x3EAFD21 VA: 0x3EAFC20
	|-List<Int32Enum>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3EB2A20 Offset: 0x3EB2B21 VA: 0x3EB2A20
	|-List<long>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3DFFDF0 Offset: 0x3DFFEF1 VA: 0x3DFFDF0
	|-List<IntPtr>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3E02CA0 Offset: 0x3E02DA1 VA: 0x3E02CA0
	|-List<InterpretedFrameInfo>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3E05DA0 Offset: 0x3E05EA1 VA: 0x3E05DA0
	|-List<IntervalTreeNode>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3E08CF0 Offset: 0x3E08DF1 VA: 0x3E08CF0
	|-List<LengthLimitProperties>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3E0BB00 Offset: 0x3E0BC01 VA: 0x3E0BB00
	|-List<MapPos>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3E0EDD0 Offset: 0x3E0EED1 VA: 0x3E0EDD0
	|-List<Matrix4x4>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3E15050 Offset: 0x3E15151 VA: 0x3E15050
	|-List<ObjectInitializationData>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3E18330 Offset: 0x3E18431 VA: 0x3E18330
	|-List<PlayableBinding>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3E1B670 Offset: 0x3E1B771 VA: 0x3E1B670
	|-List<PlayerLoopSystem>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3DA5B10 Offset: 0x3DA5C11 VA: 0x3DA5B10
	|-List<PlayerLoopSystemInternal>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3DA8BD0 Offset: 0x3DA8CD1 VA: 0x3DA8BD0
	|-List<RangePositionInfo>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3DABA40 Offset: 0x3DABB41 VA: 0x3DABA40
	|-List<Ranking2ChartInfoInput>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3DAEC40 Offset: 0x3DAED41 VA: 0x3DAEC40
	|-List<RaycastHit2D>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3DB22D0 Offset: 0x3DB23D1 VA: 0x3DB22D0
	|-List<RaycastResult>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3DB55F0 Offset: 0x3DB56F1 VA: 0x3DB55F0
	|-List<Rect>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3DB8480 Offset: 0x3DB8581 VA: 0x3DB8480
	|-List<RendererListHandle>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3DBB290 Offset: 0x3DBB391 VA: 0x3DBB290
	|-List<ResourceHandle>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3DBE0B0 Offset: 0x3DBE1B1 VA: 0x3DBE0B0
	|-List<sbyte>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3DC0EB0 Offset: 0x3DC0FB1 VA: 0x3DC0EB0
	|-List<ShaderTagId>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3E3CB20 Offset: 0x3E3CC21 VA: 0x3E3CB20
	|-List<float>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3E402C0 Offset: 0x3E403C1 VA: 0x3E402C0
	|-List<SphericalHarmonicsL2>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3E439F0 Offset: 0x3E43AF1 VA: 0x3E439F0
	|-List<SubMeshDescriptor>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3E46AB0 Offset: 0x3E46BB1 VA: 0x3E46AB0
	|-List<TablePair>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3E49920 Offset: 0x3E49A21 VA: 0x3E49920
	|-List<TimeSpan>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3E4C870 Offset: 0x3E4C971 VA: 0x3E4C870
	|-List<UICharInfo>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3E4F7A0 Offset: 0x3E4F8A1 VA: 0x3E4F7A0
	|-List<UILineInfo>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3E52F80 Offset: 0x3E53081 VA: 0x3E52F80
	|-List<UIVertex>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3E562D0 Offset: 0x3E563D1 VA: 0x3E562D0
	|-List<ushort>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3E590D0 Offset: 0x3E591D1 VA: 0x3E590D0
	|-List<uint>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3DC3CC0 Offset: 0x3DC3DC1 VA: 0x3DC3CC0
	|-List<ulong>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3DC6B50 Offset: 0x3DC6C51 VA: 0x3DC6B50
	|-List<Vector2>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3DC9AD0 Offset: 0x3DC9BD1 VA: 0x3DC9AD0
	|-List<Vector3>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3DCCAE0 Offset: 0x3DCCBE1 VA: 0x3DCCAE0
	|-List<Vector4>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3DCFA00 Offset: 0x3DCFB01 VA: 0x3DCFA00
	|-List<VertexAttributeDescriptor>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3DD2900 Offset: 0x3DD2A01 VA: 0x3DD2900
	|-List<X509ChainStatus>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3DD5B30 Offset: 0x3DD5C31 VA: 0x3DD5B30
	|-List<XRView>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3DD8C10 Offset: 0x3DD8D11 VA: 0x3DD8C10
	|-List<AmiiboSequence.GainItemData>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3DDBE30 Offset: 0x3DDBF31 VA: 0x3DDBE30
	|-List<AnimationOutputWeightProcessor.WeightInfo>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3DDEED0 Offset: 0x3DDEFD1 VA: 0x3DDEED0
	|-List<ArenaOrderSequence.GodInfo>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3E1E730 Offset: 0x3E1E831 VA: 0x3E1E730
	|-List<BattleInfo.SupportData>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3E21650 Offset: 0x3E21751 VA: 0x3E21650
	|-List<BeforeRenderHelper.OrderBlock>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3E24770 Offset: 0x3E24871 VA: 0x3E24770
	|-List<Camera.RenderRequest>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3E277A0 Offset: 0x3E278A1 VA: 0x3E277A0
	|-List<CameraState.CustomBlendable>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3E2A610 Offset: 0x3E2A711 VA: 0x3E2A610
	|-List<CinemachineClearShot.Pair>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3E2D420 Offset: 0x3E2D521 VA: 0x3E2D420
	|-List<CinemachineStateDrivenCamera.HashPair>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3E304D0 Offset: 0x3E305D1 VA: 0x3E304D0
	|-List<DelayedActionManager.DelegateInfo>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3E33830 Offset: 0x3E33931 VA: 0x3E33830
	|-List<Detail.AsyncResultInt>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3E368D0 Offset: 0x3E369D1 VA: 0x3E368D0
	|-List<Detail.CppArray>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3E39B00 Offset: 0x3E39C01 VA: 0x3E39B00
	|-List<Detail.NotificationEventInt>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3E5BF80 Offset: 0x3E5C081 VA: 0x3E5BF80
	|-List<DragonRideTargetGroup.ChainParam>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3E5F090 Offset: 0x3E5F191 VA: 0x3E5F090
	|-List<GmapPathAdjuster.TargetModel>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3E622A0 Offset: 0x3E623A1 VA: 0x3E622A0
	|-List<GmapSpotAdjuster.TargetModel>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3E654B0 Offset: 0x3E655B1 VA: 0x3E654B0
	|-List<HubFastTravel.Location>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3E68820 Offset: 0x3E68921 VA: 0x3E68820
	|-List<HubLensFlare.Flare>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3E6B910 Offset: 0x3E6BA11 VA: 0x3E6B910
	|-List<InventoryPoolItemMenuContent.KindBgNameClass>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3E6E780 Offset: 0x3E6E881 VA: 0x3E6E780
	|-List<Map.Pos>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3E71620 Offset: 0x3E71721 VA: 0x3E71620
	|-List<MapImage.BackupTerrain>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3E744E0 Offset: 0x3E745E1 VA: 0x3E744E0
	|-List<MapImageRange.Pos>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3E775B0 Offset: 0x3E776B1 VA: 0x3E775B0
	|-List<MapMind.Target>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3D871A0 Offset: 0x3D872A1 VA: 0x3D871A0
	|-List<MapPanelDebug.Entity>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3D8A0F0 Offset: 0x3D8A1F1 VA: 0x3D8A0F0
	|-List<NexRanking.Data>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3D8CF90 Offset: 0x3D8D091 VA: 0x3D8CF90
	|-List<NexVersus.RatingData>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3D8FE90 Offset: 0x3D8FF91 VA: 0x3D8FE90
	|-List<PackedPlayModeBuildLogs.RuntimeBuildLog>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3D930A0 Offset: 0x3D931A1 VA: 0x3D930A0
	|-List<ParticleSystem.Particle>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3D960B0 Offset: 0x3D961B1 VA: 0x3D960B0
	|-List<RangeData.Offset>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3D99160 Offset: 0x3D99261 VA: 0x3D99160
	|-List<RenderGraphDebugData.PassDebugData>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3D9C4A0 Offset: 0x3D9C5A1 VA: 0x3D9C4A0
	|-List<RenderGraphDebugData.ResourceDebugData>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3D9F560 Offset: 0x3D9F661 VA: 0x3D9F560
	|-List<RingCleaningUnitSelectMenu.GodParam>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3DA2770 Offset: 0x3DA2871 VA: 0x3DA2770
	|-List<ShadowUtility.Edge>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3D14C20 Offset: 0x3D14D21 VA: 0x3D14C20
	|-List<SkillArray.Entity>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3D17F00 Offset: 0x3D18001 VA: 0x3D17F00
	|-List<TexturePacker_JsonArray.Frame>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3D1B2A0 Offset: 0x3D1B3A1 VA: 0x3D1B2A0
	|-List<TimeNotificationBehaviour.NotificationEntry>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3D1E4C0 Offset: 0x3D1E5C1 VA: 0x3D1E4C0
	|-List<UnitySynchronizationContext.WorkRequest>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3D214E0 Offset: 0x3D215E1 VA: 0x3D214E0
	|-List<XmlSchemaObjectTable.XmlSchemaObjectEntry>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3D24400 Offset: 0x3D24501 VA: 0x3D24400
	|-List<AssetBundleBuildMap.AssetBundleEntry.AssetPathString>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3D27640 Offset: 0x3D27741 VA: 0x3D27640
	|-List<Detail.DataStore.DataStoreChangeMetaParamInt>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3D2A720 Offset: 0x3D2A821 VA: 0x3D2A720
	|-List<Detail.DataStore.DataStoreDeleteParamInt>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3D2D920 Offset: 0x3D2DA21 VA: 0x3D2D920
	|-List<Detail.DataStore.DataStoreGetMetaParamInt>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3D30CD0 Offset: 0x3D30DD1 VA: 0x3D30CD0
	|-List<Detail.DataStore.DataStoreMetaInfoInt>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3CF53E0 Offset: 0x3CF54E1 VA: 0x3CF53E0
	|-List<Detail.DataStore.DataStorePasswordInfoInt>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3CF85C0 Offset: 0x3CF86C1 VA: 0x3CF85C0
	|-List<Detail.DataStore.DataStorePersistenceInfoInt>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3CFB8B0 Offset: 0x3CFB9B1 VA: 0x3CFB8B0
	|-List<Detail.DataStore.DataStorePreparePostParamInt>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3CFE950 Offset: 0x3CFEA51 VA: 0x3CFE950
	|-List<Detail.DataStore.DataStoreRateObjectParamInt>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3D01A30 Offset: 0x3D01B31 VA: 0x3D01A30
	|-List<Detail.DataStore.DataStoreRatingInitParamInt>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3D04A20 Offset: 0x3D04B21 VA: 0x3D04A20
	|-List<Detail.DataStore.DataStoreRatingTargetInt>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3D07D80 Offset: 0x3D07E81 VA: 0x3D07D80
	|-List<Detail.Ranking.RankingCachedResultInt>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3D0AEE0 Offset: 0x3D0AFE1 VA: 0x3D0AEE0
	|-List<Detail.Ranking.RankingOrderParamInt>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3D0E1F0 Offset: 0x3D0E2F1 VA: 0x3D0E1F0
	|-List<Detail.Ranking.RankingRankDataInt>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3D11A10 Offset: 0x3D11B11 VA: 0x3D11A10
	|-List<Detail.Ranking2.Ranking2ChartInfoInt>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3D68170 Offset: 0x3D68271 VA: 0x3D68170
	|-List<Detail.Ranking2.Ranking2RankDataInt>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3D6B2C0 Offset: 0x3D6B3C1 VA: 0x3D6B2C0
	|-List<Detail.Ranking2.Ranking2ScoreDataInt>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3D6E3A0 Offset: 0x3D6E4A1 VA: 0x3D6E3A0
	|-List<Detail.Screening.ScreeningContextInfoInt>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3D71950 Offset: 0x3D71A51 VA: 0x3D71950
	|-List<Detail.Subscriber.SubscriberContentInt>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3D74D60 Offset: 0x3D74E61 VA: 0x3D74D60
	|-List<Detail.Subscriber.SubscriberGetContentParamInt>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3D78060 Offset: 0x3D78161 VA: 0x3D78060
	|-List<Detail.Subscriber.SubscriberUserStatusInfoInt>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3D7B2E0 Offset: 0x3D7B3E1 VA: 0x3D7B2E0
	|-List<Detail.Subscriber.SubscriberUserStatusParamInt>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3D7E230 Offset: 0x3D7E331 VA: 0x3D7E230
	|-List<Detail.Utility.IntegerSettings>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3D810D0 Offset: 0x3D811D1 VA: 0x3D810D0
	|-List<Detail.Utility.UniqueIdInfoInt>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3D84050 Offset: 0x3D84151 VA: 0x3D84050
	|-List<MapHistory.Rewind.LatestInspectorData>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3060310 Offset: 0x3060411 VA: 0x3060310
	|-List<MapHistory.Rewind.WorkTerrainData>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3063280 Offset: 0x3063381 VA: 0x3063280
	|-List<MapSkill.AroundCalculator.Result>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3066490 Offset: 0x3066591 VA: 0x3066490
	|-List<TargetPositionCache.CacheCurve.Item>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3069860 Offset: 0x3069961 VA: 0x3069860
	|-List<TargetPositionCache.CacheEntry.RecordingItem>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public int IndexOf(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3B0C120 Offset: 0x3B0C221 VA: 0x3B0C120
	|-List<IntervalTree.Entry<object>>.IndexOf
	|
	|-RVA: 0x3B0F130 Offset: 0x3B0F231 VA: 0x3B0F130
	|-List<KeyValuePair<DateTime, object>>.IndexOf
	|
	|-RVA: 0x3B12050 Offset: 0x3B12151 VA: 0x3B12050
	|-List<KeyValuePair<int, object>>.IndexOf
	|
	|-RVA: 0x3B15170 Offset: 0x3B15271 VA: 0x3B15170
	|-List<KeyValuePair<object, ValueTuple<int, DateTime, object>>>.IndexOf
	|
	|-RVA: 0x3B18190 Offset: 0x3B18291 VA: 0x3B18190
	|-List<KeyValuePair<object, object>>.IndexOf
	|
	|-RVA: 0x3B1B2B0 Offset: 0x3B1B3B1 VA: 0x3B1B2B0
	|-List<CommonBattleSequence.Reliance<object>>.IndexOf
	|
	|-RVA: 0x3B1E2C0 Offset: 0x3B1E3C1 VA: 0x3B1E2C0
	|-List<RenderGraphResourcePool.ResourceLogInfo<object>>.IndexOf
	|
	|-RVA: 0x3B211E0 Offset: 0x3B212E1 VA: 0x3B211E0
	|-List<ValueTuple<int, object>>.IndexOf
	|
	|-RVA: 0x3DE1DC0 Offset: 0x3DE1EC1 VA: 0x3DE1DC0
	|-List<ValueTuple<Int32Enum, int>>.IndexOf
	|
	|-RVA: 0x3DE4E80 Offset: 0x3DE4F81 VA: 0x3DE4E80
	|-List<ValueTuple<object, ValueTuple<object, int>>>.IndexOf
	|
	|-RVA: 0x3DE7E90 Offset: 0x3DE7F91 VA: 0x3DE7E90
	|-List<ValueTuple<object, int>>.IndexOf
	|
	|-RVA: 0x3DEAE70 Offset: 0x3DEAF71 VA: 0x3DEAE70
	|-List<ValueTuple<Vector3, float>>.IndexOf
	|
	|-RVA: 0x3DEDDB0 Offset: 0x3DEDEB1 VA: 0x3DEDDB0
	|-List<ValueTuple<object, Int32Enum, int>>.IndexOf
	|
	|-RVA: 0x3DF0ED0 Offset: 0x3DF0FD1 VA: 0x3DF0ED0
	|-List<ValueTuple<object, int, int, int>>.IndexOf
	|
	|-RVA: 0x3E11EB0 Offset: 0x3E11FB1 VA: 0x3E11EB0
	|-List<AccessoryData>.IndexOf
	|-List<BasicMenuItem>.IndexOf
	|-List<Camera>.IndexOf
	|-List<ChapterData>.IndexOf
	|-List<Decorator>.IndexOf
	|-List<DynValue>.IndexOf
	|-List<EventSystem>.IndexOf
	|-List<GameObject>.IndexOf
	|-List<GodUnit>.IndexOf
	|-List<IDisposable>.IndexOf
	|-List<ItemData>.IndexOf
	|-List<MapBackup>.IndexOf
	|-List<object>.IndexOf
	|-List<Phase>.IndexOf
	|-List<PhotographCameraParameter>.IndexOf
	|-List<PhotographDisposInfo>.IndexOf
	|-List<PhotographPauseData>.IndexOf
	|-List<ProfileCard>.IndexOf
	|-List<SignalAsset>.IndexOf
	|-List<string>.IndexOf
	|-List<Thread>.IndexOf
	|-List<Unit>.IndexOf
	|-List<UnitItem>.IndexOf
	|-List<AssetTable.Accessory>.IndexOf
	|-List<GameSaveDataHeaderReader.Handle>.IndexOf
	|-List<MapDispos.ActualData>.IndexOf
	|-List<MapDispos.Pos>.IndexOf
	|-List<MapLayer.Data>.IndexOf
	|-List<MapObject.RigidInfo>.IndexOf
	|-List<RingListSequence.PageData>.IndexOf
	|
	|-RVA: 0x3DF3E30 Offset: 0x3DF3F31 VA: 0x3DF3E30
	|-List<AnimatorClipInfo>.IndexOf
	|
	|-RVA: 0x3DF6EF0 Offset: 0x3DF6FF1 VA: 0x3DF6EF0
	|-List<AsyncOperationHandle>.IndexOf
	|
	|-RVA: 0x3DFA0F0 Offset: 0x3DFA1F1 VA: 0x3DFA0F0
	|-List<BoneWeight>.IndexOf
	|
	|-RVA: 0x3DFD060 Offset: 0x3DFD161 VA: 0x3DFD060
	|-List<bool>.IndexOf
	|
	|-RVA: 0x3E7A5B0 Offset: 0x3E7A6B1 VA: 0x3E7A5B0
	|-List<byte>.IndexOf
	|
	|-RVA: 0x3E7D460 Offset: 0x3E7D561 VA: 0x3E7D460
	|-List<CameraInfo>.IndexOf
	|
	|-RVA: 0x3E802D0 Offset: 0x3E803D1 VA: 0x3E802D0
	|-List<char>.IndexOf
	|
	|-RVA: 0x3E83240 Offset: 0x3E83341 VA: 0x3E83240
	|-List<Color>.IndexOf
	|
	|-RVA: 0x3E860D0 Offset: 0x3E861D1 VA: 0x3E860D0
	|-List<Color32>.IndexOf
	|
	|-RVA: 0x3E88F90 Offset: 0x3E89091 VA: 0x3E88F90
	|-List<ConstraintSource>.IndexOf
	|
	|-RVA: 0x3E8C0B0 Offset: 0x3E8C1B1 VA: 0x3E8C0B0
	|-List<ContourVertex>.IndexOf
	|
	|-RVA: 0x3E8F2B0 Offset: 0x3E8F3B1 VA: 0x3E8F2B0
	|-List<DataStoreRatingInfo>.IndexOf
	|
	|-RVA: 0x3E921F0 Offset: 0x3E922F1 VA: 0x3E921F0
	|-List<DataStoreResult>.IndexOf
	|
	|-RVA: 0x3E95000 Offset: 0x3E95101 VA: 0x3E95000
	|-List<DateTime>.IndexOf
	|
	|-RVA: 0x3E97EA0 Offset: 0x3E97FA1 VA: 0x3E97EA0
	|-List<DateTimeOffset>.IndexOf
	|
	|-RVA: 0x3E9AD80 Offset: 0x3E9AE81 VA: 0x3E9AD80
	|-List<Decimal>.IndexOf
	|
	|-RVA: 0x3E9DFF0 Offset: 0x3E9E0F1 VA: 0x3E9DFF0
	|-List<DiagnosticEvent>.IndexOf
	|
	|-RVA: 0x3EA1020 Offset: 0x3EA1121 VA: 0x3EA1020
	|-List<double>.IndexOf
	|
	|-RVA: 0x3EA41C0 Offset: 0x3EA42C1 VA: 0x3EA41C0
	|-List<Friend>.IndexOf
	|
	|-RVA: 0x3EA7250 Offset: 0x3EA7351 VA: 0x3EA7250
	|-List<GlyphRect>.IndexOf
	|
	|-RVA: 0x3EAA0A0 Offset: 0x3EAA1A1 VA: 0x3EAA0A0
	|-List<short>.IndexOf
	|
	|-RVA: 0x3EACEA0 Offset: 0x3EACFA1 VA: 0x3EACEA0
	|-List<int>.IndexOf
	|
	|-RVA: 0x3EAFCA0 Offset: 0x3EAFDA1 VA: 0x3EAFCA0
	|-List<Int32Enum>.IndexOf
	|-List<TutorialListTopMenu.SelectCategoryType>.IndexOf
	|
	|-RVA: 0x3EB2AA0 Offset: 0x3EB2BA1 VA: 0x3EB2AA0
	|-List<long>.IndexOf
	|
	|-RVA: 0x3DFFE70 Offset: 0x3DFFF71 VA: 0x3DFFE70
	|-List<IntPtr>.IndexOf
	|
	|-RVA: 0x3E02D20 Offset: 0x3E02E21 VA: 0x3E02D20
	|-List<InterpretedFrameInfo>.IndexOf
	|
	|-RVA: 0x3E05E30 Offset: 0x3E05F31 VA: 0x3E05E30
	|-List<IntervalTreeNode>.IndexOf
	|
	|-RVA: 0x3E08D70 Offset: 0x3E08E71 VA: 0x3E08D70
	|-List<LengthLimitProperties>.IndexOf
	|
	|-RVA: 0x3E0BB80 Offset: 0x3E0BC81 VA: 0x3E0BB80
	|-List<MapPos>.IndexOf
	|
	|-RVA: 0x3E0EE70 Offset: 0x3E0EF71 VA: 0x3E0EE70
	|-List<Matrix4x4>.IndexOf
	|
	|-RVA: 0x3E150F0 Offset: 0x3E151F1 VA: 0x3E150F0
	|-List<ObjectInitializationData>.IndexOf
	|
	|-RVA: 0x3E183C0 Offset: 0x3E184C1 VA: 0x3E183C0
	|-List<PlayableBinding>.IndexOf
	|
	|-RVA: 0x3E1B710 Offset: 0x3E1B811 VA: 0x3E1B710
	|-List<PlayerLoopSystem>.IndexOf
	|
	|-RVA: 0x3DA5BB0 Offset: 0x3DA5CB1 VA: 0x3DA5BB0
	|-List<PlayerLoopSystemInternal>.IndexOf
	|
	|-RVA: 0x3DA8C50 Offset: 0x3DA8D51 VA: 0x3DA8C50
	|-List<RangePositionInfo>.IndexOf
	|
	|-RVA: 0x3DABAC0 Offset: 0x3DABBC1 VA: 0x3DABAC0
	|-List<Ranking2ChartInfoInput>.IndexOf
	|
	|-RVA: 0x3DAECE0 Offset: 0x3DAEDE1 VA: 0x3DAECE0
	|-List<RaycastHit2D>.IndexOf
	|
	|-RVA: 0x3DB2380 Offset: 0x3DB2481 VA: 0x3DB2380
	|-List<RaycastResult>.IndexOf
	|
	|-RVA: 0x3DB5670 Offset: 0x3DB5771 VA: 0x3DB5670
	|-List<Rect>.IndexOf
	|
	|-RVA: 0x3DB8500 Offset: 0x3DB8601 VA: 0x3DB8500
	|-List<RendererListHandle>.IndexOf
	|
	|-RVA: 0x3DBB310 Offset: 0x3DBB411 VA: 0x3DBB310
	|-List<ResourceHandle>.IndexOf
	|
	|-RVA: 0x3DBE130 Offset: 0x3DBE231 VA: 0x3DBE130
	|-List<sbyte>.IndexOf
	|
	|-RVA: 0x3DC0F30 Offset: 0x3DC1031 VA: 0x3DC0F30
	|-List<ShaderTagId>.IndexOf
	|
	|-RVA: 0x3E3CBA0 Offset: 0x3E3CCA1 VA: 0x3E3CBA0
	|-List<float>.IndexOf
	|
	|-RVA: 0x3E40390 Offset: 0x3E40491 VA: 0x3E40390
	|-List<SphericalHarmonicsL2>.IndexOf
	|
	|-RVA: 0x3E43A90 Offset: 0x3E43B91 VA: 0x3E43A90
	|-List<SubMeshDescriptor>.IndexOf
	|
	|-RVA: 0x3E46B30 Offset: 0x3E46C31 VA: 0x3E46B30
	|-List<TablePair>.IndexOf
	|
	|-RVA: 0x3E499A0 Offset: 0x3E49AA1 VA: 0x3E499A0
	|-List<TimeSpan>.IndexOf
	|
	|-RVA: 0x3E4C8F0 Offset: 0x3E4C9F1 VA: 0x3E4C8F0
	|-List<UICharInfo>.IndexOf
	|
	|-RVA: 0x3E4F820 Offset: 0x3E4F921 VA: 0x3E4F820
	|-List<UILineInfo>.IndexOf
	|
	|-RVA: 0x3E53050 Offset: 0x3E53151 VA: 0x3E53050
	|-List<UIVertex>.IndexOf
	|
	|-RVA: 0x3E56350 Offset: 0x3E56451 VA: 0x3E56350
	|-List<ushort>.IndexOf
	|
	|-RVA: 0x3E59150 Offset: 0x3E59251 VA: 0x3E59150
	|-List<uint>.IndexOf
	|
	|-RVA: 0x3DC3D40 Offset: 0x3DC3E41 VA: 0x3DC3D40
	|-List<ulong>.IndexOf
	|
	|-RVA: 0x3DC6BD0 Offset: 0x3DC6CD1 VA: 0x3DC6BD0
	|-List<Vector2>.IndexOf
	|
	|-RVA: 0x3DC9B50 Offset: 0x3DC9C51 VA: 0x3DC9B50
	|-List<Vector3>.IndexOf
	|
	|-RVA: 0x3DCCB60 Offset: 0x3DCCC61 VA: 0x3DCCB60
	|-List<Vector4>.IndexOf
	|
	|-RVA: 0x3DCFA80 Offset: 0x3DCFB81 VA: 0x3DCFA80
	|-List<VertexAttributeDescriptor>.IndexOf
	|
	|-RVA: 0x3DD2980 Offset: 0x3DD2A81 VA: 0x3DD2980
	|-List<X509ChainStatus>.IndexOf
	|
	|-RVA: 0x3DD5BD0 Offset: 0x3DD5CD1 VA: 0x3DD5BD0
	|-List<XRView>.IndexOf
	|
	|-RVA: 0x3DD8C90 Offset: 0x3DD8D91 VA: 0x3DD8C90
	|-List<AmiiboSequence.GainItemData>.IndexOf
	|
	|-RVA: 0x3DDBED0 Offset: 0x3DDBFD1 VA: 0x3DDBED0
	|-List<AnimationOutputWeightProcessor.WeightInfo>.IndexOf
	|
	|-RVA: 0x3DDEF50 Offset: 0x3DDF051 VA: 0x3DDEF50
	|-List<ArenaOrderSequence.GodInfo>.IndexOf
	|
	|-RVA: 0x3E1E7B0 Offset: 0x3E1E8B1 VA: 0x3E1E7B0
	|-List<BattleInfo.SupportData>.IndexOf
	|
	|-RVA: 0x3E216D0 Offset: 0x3E217D1 VA: 0x3E216D0
	|-List<BeforeRenderHelper.OrderBlock>.IndexOf
	|
	|-RVA: 0x3E24800 Offset: 0x3E24901 VA: 0x3E24800
	|-List<Camera.RenderRequest>.IndexOf
	|
	|-RVA: 0x3E27820 Offset: 0x3E27921 VA: 0x3E27820
	|-List<CameraState.CustomBlendable>.IndexOf
	|
	|-RVA: 0x3E2A690 Offset: 0x3E2A791 VA: 0x3E2A690
	|-List<CinemachineClearShot.Pair>.IndexOf
	|
	|-RVA: 0x3E2D4A0 Offset: 0x3E2D5A1 VA: 0x3E2D4A0
	|-List<CinemachineStateDrivenCamera.HashPair>.IndexOf
	|
	|-RVA: 0x3E30560 Offset: 0x3E30661 VA: 0x3E30560
	|-List<DelayedActionManager.DelegateInfo>.IndexOf
	|
	|-RVA: 0x3E338D0 Offset: 0x3E339D1 VA: 0x3E338D0
	|-List<Detail.AsyncResultInt>.IndexOf
	|
	|-RVA: 0x3E36950 Offset: 0x3E36A51 VA: 0x3E36950
	|-List<Detail.CppArray>.IndexOf
	|
	|-RVA: 0x3E39BA0 Offset: 0x3E39CA1 VA: 0x3E39BA0
	|-List<Detail.NotificationEventInt>.IndexOf
	|
	|-RVA: 0x3E5C000 Offset: 0x3E5C101 VA: 0x3E5C000
	|-List<DragonRideTargetGroup.ChainParam>.IndexOf
	|
	|-RVA: 0x3E5F120 Offset: 0x3E5F221 VA: 0x3E5F120
	|-List<GmapPathAdjuster.TargetModel>.IndexOf
	|
	|-RVA: 0x3E62330 Offset: 0x3E62431 VA: 0x3E62330
	|-List<GmapSpotAdjuster.TargetModel>.IndexOf
	|
	|-RVA: 0x3E65540 Offset: 0x3E65641 VA: 0x3E65540
	|-List<HubFastTravel.Location>.IndexOf
	|
	|-RVA: 0x3E688C0 Offset: 0x3E689C1 VA: 0x3E688C0
	|-List<HubLensFlare.Flare>.IndexOf
	|
	|-RVA: 0x3E6B990 Offset: 0x3E6BA91 VA: 0x3E6B990
	|-List<InventoryPoolItemMenuContent.KindBgNameClass>.IndexOf
	|
	|-RVA: 0x3E6E800 Offset: 0x3E6E901 VA: 0x3E6E800
	|-List<Map.Pos>.IndexOf
	|
	|-RVA: 0x3E716A0 Offset: 0x3E717A1 VA: 0x3E716A0
	|-List<MapImage.BackupTerrain>.IndexOf
	|
	|-RVA: 0x3E74560 Offset: 0x3E74661 VA: 0x3E74560
	|-List<MapImageRange.Pos>.IndexOf
	|
	|-RVA: 0x3E77640 Offset: 0x3E77741 VA: 0x3E77640
	|-List<MapMind.Target>.IndexOf
	|
	|-RVA: 0x3D87230 Offset: 0x3D87331 VA: 0x3D87230
	|-List<MapPanelDebug.Entity>.IndexOf
	|
	|-RVA: 0x3D8A170 Offset: 0x3D8A271 VA: 0x3D8A170
	|-List<NexRanking.Data>.IndexOf
	|
	|-RVA: 0x3D8D010 Offset: 0x3D8D111 VA: 0x3D8D010
	|-List<NexVersus.RatingData>.IndexOf
	|
	|-RVA: 0x3D8FF10 Offset: 0x3D90011 VA: 0x3D8FF10
	|-List<PackedPlayModeBuildLogs.RuntimeBuildLog>.IndexOf
	|
	|-RVA: 0x3D93140 Offset: 0x3D93241 VA: 0x3D93140
	|-List<ParticleSystem.Particle>.IndexOf
	|
	|-RVA: 0x3D96130 Offset: 0x3D96231 VA: 0x3D96130
	|-List<RangeData.Offset>.IndexOf
	|
	|-RVA: 0x3D991F0 Offset: 0x3D992F1 VA: 0x3D991F0
	|-List<RenderGraphDebugData.PassDebugData>.IndexOf
	|
	|-RVA: 0x3D9C540 Offset: 0x3D9C641 VA: 0x3D9C540
	|-List<RenderGraphDebugData.ResourceDebugData>.IndexOf
	|
	|-RVA: 0x3D9F5E0 Offset: 0x3D9F6E1 VA: 0x3D9F5E0
	|-List<RingCleaningUnitSelectMenu.GodParam>.IndexOf
	|
	|-RVA: 0x3DA2800 Offset: 0x3DA2901 VA: 0x3DA2800
	|-List<ShadowUtility.Edge>.IndexOf
	|
	|-RVA: 0x3D14CA0 Offset: 0x3D14DA1 VA: 0x3D14CA0
	|-List<SkillArray.Entity>.IndexOf
	|
	|-RVA: 0x3D17FA0 Offset: 0x3D180A1 VA: 0x3D17FA0
	|-List<TexturePacker_JsonArray.Frame>.IndexOf
	|
	|-RVA: 0x3D1B330 Offset: 0x3D1B431 VA: 0x3D1B330
	|-List<TimeNotificationBehaviour.NotificationEntry>.IndexOf
	|
	|-RVA: 0x3D1E550 Offset: 0x3D1E651 VA: 0x3D1E550
	|-List<UnitySynchronizationContext.WorkRequest>.IndexOf
	|
	|-RVA: 0x3D21560 Offset: 0x3D21661 VA: 0x3D21560
	|-List<XmlSchemaObjectTable.XmlSchemaObjectEntry>.IndexOf
	|
	|-RVA: 0x3D24480 Offset: 0x3D24581 VA: 0x3D24480
	|-List<AssetBundleBuildMap.AssetBundleEntry.AssetPathString>.IndexOf
	|
	|-RVA: 0x3D276E0 Offset: 0x3D277E1 VA: 0x3D276E0
	|-List<Detail.DataStore.DataStoreChangeMetaParamInt>.IndexOf
	|
	|-RVA: 0x3D2A7A0 Offset: 0x3D2A8A1 VA: 0x3D2A7A0
	|-List<Detail.DataStore.DataStoreDeleteParamInt>.IndexOf
	|
	|-RVA: 0x3D2D9C0 Offset: 0x3D2DAC1 VA: 0x3D2D9C0
	|-List<Detail.DataStore.DataStoreGetMetaParamInt>.IndexOf
	|
	|-RVA: 0x3D30D80 Offset: 0x3D30E81 VA: 0x3D30D80
	|-List<Detail.DataStore.DataStoreMetaInfoInt>.IndexOf
	|
	|-RVA: 0x3CF5470 Offset: 0x3CF5571 VA: 0x3CF5470
	|-List<Detail.DataStore.DataStorePasswordInfoInt>.IndexOf
	|
	|-RVA: 0x3CF8650 Offset: 0x3CF8751 VA: 0x3CF8650
	|-List<Detail.DataStore.DataStorePersistenceInfoInt>.IndexOf
	|
	|-RVA: 0x3CFB950 Offset: 0x3CFBA51 VA: 0x3CFB950
	|-List<Detail.DataStore.DataStorePreparePostParamInt>.IndexOf
	|
	|-RVA: 0x3CFE9D0 Offset: 0x3CFEAD1 VA: 0x3CFE9D0
	|-List<Detail.DataStore.DataStoreRateObjectParamInt>.IndexOf
	|
	|-RVA: 0x3D01AC0 Offset: 0x3D01BC1 VA: 0x3D01AC0
	|-List<Detail.DataStore.DataStoreRatingInitParamInt>.IndexOf
	|
	|-RVA: 0x3D04AA0 Offset: 0x3D04BA1 VA: 0x3D04AA0
	|-List<Detail.DataStore.DataStoreRatingTargetInt>.IndexOf
	|
	|-RVA: 0x3D07E20 Offset: 0x3D07F21 VA: 0x3D07E20
	|-List<Detail.Ranking.RankingCachedResultInt>.IndexOf
	|
	|-RVA: 0x3D0AF60 Offset: 0x3D0B061 VA: 0x3D0AF60
	|-List<Detail.Ranking.RankingOrderParamInt>.IndexOf
	|
	|-RVA: 0x3D0E290 Offset: 0x3D0E391 VA: 0x3D0E290
	|-List<Detail.Ranking.RankingRankDataInt>.IndexOf
	|
	|-RVA: 0x3D11AD0 Offset: 0x3D11BD1 VA: 0x3D11AD0
	|-List<Detail.Ranking2.Ranking2ChartInfoInt>.IndexOf
	|
	|-RVA: 0x3D68210 Offset: 0x3D68311 VA: 0x3D68210
	|-List<Detail.Ranking2.Ranking2RankDataInt>.IndexOf
	|
	|-RVA: 0x3D6B340 Offset: 0x3D6B441 VA: 0x3D6B340
	|-List<Detail.Ranking2.Ranking2ScoreDataInt>.IndexOf
	|
	|-RVA: 0x3D6E430 Offset: 0x3D6E531 VA: 0x3D6E430
	|-List<Detail.Screening.ScreeningContextInfoInt>.IndexOf
	|
	|-RVA: 0x3D71A00 Offset: 0x3D71B01 VA: 0x3D71A00
	|-List<Detail.Subscriber.SubscriberContentInt>.IndexOf
	|
	|-RVA: 0x3D74DF0 Offset: 0x3D74EF1 VA: 0x3D74DF0
	|-List<Detail.Subscriber.SubscriberGetContentParamInt>.IndexOf
	|
	|-RVA: 0x3D78100 Offset: 0x3D78201 VA: 0x3D78100
	|-List<Detail.Subscriber.SubscriberUserStatusInfoInt>.IndexOf
	|
	|-RVA: 0x3D7B370 Offset: 0x3D7B471 VA: 0x3D7B370
	|-List<Detail.Subscriber.SubscriberUserStatusParamInt>.IndexOf
	|
	|-RVA: 0x3D7E2B0 Offset: 0x3D7E3B1 VA: 0x3D7E2B0
	|-List<Detail.Utility.IntegerSettings>.IndexOf
	|
	|-RVA: 0x3D81150 Offset: 0x3D81251 VA: 0x3D81150
	|-List<Detail.Utility.UniqueIdInfoInt>.IndexOf
	|
	|-RVA: 0x3D840D0 Offset: 0x3D841D1 VA: 0x3D840D0
	|-List<MapHistory.Rewind.LatestInspectorData>.IndexOf
	|
	|-RVA: 0x3060390 Offset: 0x3060491 VA: 0x3060390
	|-List<MapHistory.Rewind.WorkTerrainData>.IndexOf
	|
	|-RVA: 0x3063300 Offset: 0x3063401 VA: 0x3063300
	|-List<MapSkill.AroundCalculator.Result>.IndexOf
	|
	|-RVA: 0x3066520 Offset: 0x3066621 VA: 0x3066520
	|-List<TargetPositionCache.CacheCurve.Item>.IndexOf
	|
	|-RVA: 0x3069900 Offset: 0x3069A01 VA: 0x3069900
	|-List<TargetPositionCache.CacheEntry.RecordingItem>.IndexOf
	*/

	// RVA: -1 Offset: -1 Slot: 24
	private int System.Collections.IList.IndexOf(object item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3B0C180 Offset: 0x3B0C281 VA: 0x3B0C180
	|-List<IntervalTree.Entry<object>>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3B0F160 Offset: 0x3B0F261 VA: 0x3B0F160
	|-List<KeyValuePair<DateTime, object>>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3B12080 Offset: 0x3B12181 VA: 0x3B12080
	|-List<KeyValuePair<int, object>>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3B151D0 Offset: 0x3B152D1 VA: 0x3B151D0
	|-List<KeyValuePair<object, ValueTuple<int, DateTime, object>>>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3B181C0 Offset: 0x3B182C1 VA: 0x3B181C0
	|-List<KeyValuePair<object, object>>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3B1B310 Offset: 0x3B1B411 VA: 0x3B1B310
	|-List<CommonBattleSequence.Reliance<object>>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3B1E2F0 Offset: 0x3B1E3F1 VA: 0x3B1E2F0
	|-List<RenderGraphResourcePool.ResourceLogInfo<object>>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3B21210 Offset: 0x3B21311 VA: 0x3B21210
	|-List<ValueTuple<int, object>>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3DE1DF0 Offset: 0x3DE1EF1 VA: 0x3DE1DF0
	|-List<ValueTuple<Int32Enum, int>>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3DE4EE0 Offset: 0x3DE4FE1 VA: 0x3DE4EE0
	|-List<ValueTuple<object, ValueTuple<object, int>>>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3DE7EC0 Offset: 0x3DE7FC1 VA: 0x3DE7EC0
	|-List<ValueTuple<object, int>>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3DEAEA0 Offset: 0x3DEAFA1 VA: 0x3DEAEA0
	|-List<ValueTuple<Vector3, float>>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3DEDDE0 Offset: 0x3DEDEE1 VA: 0x3DEDDE0
	|-List<ValueTuple<object, Int32Enum, int>>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3DF0F30 Offset: 0x3DF1031 VA: 0x3DF0F30
	|-List<ValueTuple<object, int, int, int>>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3DF3E60 Offset: 0x3DF3F61 VA: 0x3DF3E60
	|-List<AnimatorClipInfo>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3DF6F50 Offset: 0x3DF7051 VA: 0x3DF6F50
	|-List<AsyncOperationHandle>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3DFA150 Offset: 0x3DFA251 VA: 0x3DFA150
	|-List<BoneWeight>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3DFD090 Offset: 0x3DFD191 VA: 0x3DFD090
	|-List<bool>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3E7A5E0 Offset: 0x3E7A6E1 VA: 0x3E7A5E0
	|-List<byte>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3E11EE0 Offset: 0x3E11FE1 VA: 0x3E11EE0
	|-List<Camera>.System.Collections.IList.IndexOf
	|-List<Decorator>.System.Collections.IList.IndexOf
	|-List<DynValue>.System.Collections.IList.IndexOf
	|-List<GameObject>.System.Collections.IList.IndexOf
	|-List<MapBackup>.System.Collections.IList.IndexOf
	|-List<object>.System.Collections.IList.IndexOf
	|-List<Phase>.System.Collections.IList.IndexOf
	|-List<ProfileCard>.System.Collections.IList.IndexOf
	|-List<Unit>.System.Collections.IList.IndexOf
	|-List<AssetTable.Accessory>.System.Collections.IList.IndexOf
	|-List<GameSaveDataHeaderReader.Handle>.System.Collections.IList.IndexOf
	|-List<MapDispos.ActualData>.System.Collections.IList.IndexOf
	|-List<MapDispos.Pos>.System.Collections.IList.IndexOf
	|-List<MapLayer.Data>.System.Collections.IList.IndexOf
	|-List<MapObject.RigidInfo>.System.Collections.IList.IndexOf
	|-List<RingListSequence.PageData>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3E7D490 Offset: 0x3E7D591 VA: 0x3E7D490
	|-List<CameraInfo>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3E80300 Offset: 0x3E80401 VA: 0x3E80300
	|-List<char>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3E83270 Offset: 0x3E83371 VA: 0x3E83270
	|-List<Color>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3E86100 Offset: 0x3E86201 VA: 0x3E86100
	|-List<Color32>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3E88FC0 Offset: 0x3E890C1 VA: 0x3E88FC0
	|-List<ConstraintSource>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3E8C110 Offset: 0x3E8C211 VA: 0x3E8C110
	|-List<ContourVertex>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3E8F310 Offset: 0x3E8F411 VA: 0x3E8F310
	|-List<DataStoreRatingInfo>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3E92220 Offset: 0x3E92321 VA: 0x3E92220
	|-List<DataStoreResult>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3E95030 Offset: 0x3E95131 VA: 0x3E95030
	|-List<DateTime>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3E97ED0 Offset: 0x3E97FD1 VA: 0x3E97ED0
	|-List<DateTimeOffset>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3E9ADB0 Offset: 0x3E9AEB1 VA: 0x3E9ADB0
	|-List<Decimal>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3E9E070 Offset: 0x3E9E171 VA: 0x3E9E070
	|-List<DiagnosticEvent>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3EA1050 Offset: 0x3EA1151 VA: 0x3EA1050
	|-List<double>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3EA4250 Offset: 0x3EA4351 VA: 0x3EA4250
	|-List<Friend>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3EA7280 Offset: 0x3EA7381 VA: 0x3EA7280
	|-List<GlyphRect>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3EAA0D0 Offset: 0x3EAA1D1 VA: 0x3EAA0D0
	|-List<short>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3EACED0 Offset: 0x3EACFD1 VA: 0x3EACED0
	|-List<int>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3EAFCD0 Offset: 0x3EAFDD1 VA: 0x3EAFCD0
	|-List<Int32Enum>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3EB2AD0 Offset: 0x3EB2BD1 VA: 0x3EB2AD0
	|-List<long>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3DFFEA0 Offset: 0x3DFFFA1 VA: 0x3DFFEA0
	|-List<IntPtr>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3E02D50 Offset: 0x3E02E51 VA: 0x3E02D50
	|-List<InterpretedFrameInfo>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3E05E90 Offset: 0x3E05F91 VA: 0x3E05E90
	|-List<IntervalTreeNode>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3E08DA0 Offset: 0x3E08EA1 VA: 0x3E08DA0
	|-List<LengthLimitProperties>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3E0BBB0 Offset: 0x3E0BCB1 VA: 0x3E0BBB0
	|-List<MapPos>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3E0EF00 Offset: 0x3E0F001 VA: 0x3E0EF00
	|-List<Matrix4x4>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3E15170 Offset: 0x3E15271 VA: 0x3E15170
	|-List<ObjectInitializationData>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3E18420 Offset: 0x3E18521 VA: 0x3E18420
	|-List<PlayableBinding>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3E1B780 Offset: 0x3E1B881 VA: 0x3E1B780
	|-List<PlayerLoopSystem>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3DA5C20 Offset: 0x3DA5D21 VA: 0x3DA5C20
	|-List<PlayerLoopSystemInternal>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3DA8C80 Offset: 0x3DA8D81 VA: 0x3DA8C80
	|-List<RangePositionInfo>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3DABAF0 Offset: 0x3DABBF1 VA: 0x3DABAF0
	|-List<Ranking2ChartInfoInput>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3DAED50 Offset: 0x3DAEE51 VA: 0x3DAED50
	|-List<RaycastHit2D>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3DB2420 Offset: 0x3DB2521 VA: 0x3DB2420
	|-List<RaycastResult>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3DB56A0 Offset: 0x3DB57A1 VA: 0x3DB56A0
	|-List<Rect>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3DB8530 Offset: 0x3DB8631 VA: 0x3DB8530
	|-List<RendererListHandle>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3DBB340 Offset: 0x3DBB441 VA: 0x3DBB340
	|-List<ResourceHandle>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3DBE160 Offset: 0x3DBE261 VA: 0x3DBE160
	|-List<sbyte>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3DC0F60 Offset: 0x3DC1061 VA: 0x3DC0F60
	|-List<ShaderTagId>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3E3CBD0 Offset: 0x3E3CCD1 VA: 0x3E3CBD0
	|-List<float>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3E40460 Offset: 0x3E40561 VA: 0x3E40460
	|-List<SphericalHarmonicsL2>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3E43B10 Offset: 0x3E43C11 VA: 0x3E43B10
	|-List<SubMeshDescriptor>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3E46B60 Offset: 0x3E46C61 VA: 0x3E46B60
	|-List<TablePair>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3E499D0 Offset: 0x3E49AD1 VA: 0x3E499D0
	|-List<TimeSpan>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3E4C920 Offset: 0x3E4CA21 VA: 0x3E4C920
	|-List<UICharInfo>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3E4F850 Offset: 0x3E4F951 VA: 0x3E4F850
	|-List<UILineInfo>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3E53120 Offset: 0x3E53221 VA: 0x3E53120
	|-List<UIVertex>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3E56380 Offset: 0x3E56481 VA: 0x3E56380
	|-List<ushort>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3E59180 Offset: 0x3E59281 VA: 0x3E59180
	|-List<uint>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3DC3D70 Offset: 0x3DC3E71 VA: 0x3DC3D70
	|-List<ulong>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3DC6C00 Offset: 0x3DC6D01 VA: 0x3DC6C00
	|-List<Vector2>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3DC9B80 Offset: 0x3DC9C81 VA: 0x3DC9B80
	|-List<Vector3>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3DCCB90 Offset: 0x3DCCC91 VA: 0x3DCCB90
	|-List<Vector4>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3DCFAB0 Offset: 0x3DCFBB1 VA: 0x3DCFAB0
	|-List<VertexAttributeDescriptor>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3DD29B0 Offset: 0x3DD2AB1 VA: 0x3DD29B0
	|-List<X509ChainStatus>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3DD5C60 Offset: 0x3DD5D61 VA: 0x3DD5C60
	|-List<XRView>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3DD8CC0 Offset: 0x3DD8DC1 VA: 0x3DD8CC0
	|-List<AmiiboSequence.GainItemData>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3DDBF40 Offset: 0x3DDC041 VA: 0x3DDBF40
	|-List<AnimationOutputWeightProcessor.WeightInfo>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3DDEF80 Offset: 0x3DDF081 VA: 0x3DDEF80
	|-List<ArenaOrderSequence.GodInfo>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3E1E7E0 Offset: 0x3E1E8E1 VA: 0x3E1E7E0
	|-List<BattleInfo.SupportData>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3E21700 Offset: 0x3E21801 VA: 0x3E21700
	|-List<BeforeRenderHelper.OrderBlock>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3E24860 Offset: 0x3E24961 VA: 0x3E24860
	|-List<Camera.RenderRequest>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3E27850 Offset: 0x3E27951 VA: 0x3E27850
	|-List<CameraState.CustomBlendable>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3E2A6C0 Offset: 0x3E2A7C1 VA: 0x3E2A6C0
	|-List<CinemachineClearShot.Pair>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3E2D4D0 Offset: 0x3E2D5D1 VA: 0x3E2D4D0
	|-List<CinemachineStateDrivenCamera.HashPair>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3E305C0 Offset: 0x3E306C1 VA: 0x3E305C0
	|-List<DelayedActionManager.DelegateInfo>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3E33950 Offset: 0x3E33A51 VA: 0x3E33950
	|-List<Detail.AsyncResultInt>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3E36980 Offset: 0x3E36A81 VA: 0x3E36980
	|-List<Detail.CppArray>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3E39C20 Offset: 0x3E39D21 VA: 0x3E39C20
	|-List<Detail.NotificationEventInt>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3E5C030 Offset: 0x3E5C131 VA: 0x3E5C030
	|-List<DragonRideTargetGroup.ChainParam>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3E5F180 Offset: 0x3E5F281 VA: 0x3E5F180
	|-List<GmapPathAdjuster.TargetModel>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3E62390 Offset: 0x3E62491 VA: 0x3E62390
	|-List<GmapSpotAdjuster.TargetModel>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3E655A0 Offset: 0x3E656A1 VA: 0x3E655A0
	|-List<HubFastTravel.Location>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3E68940 Offset: 0x3E68A41 VA: 0x3E68940
	|-List<HubLensFlare.Flare>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3E6B9C0 Offset: 0x3E6BAC1 VA: 0x3E6B9C0
	|-List<InventoryPoolItemMenuContent.KindBgNameClass>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3E6E830 Offset: 0x3E6E931 VA: 0x3E6E830
	|-List<Map.Pos>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3E716D0 Offset: 0x3E717D1 VA: 0x3E716D0
	|-List<MapImage.BackupTerrain>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3E74590 Offset: 0x3E74691 VA: 0x3E74590
	|-List<MapImageRange.Pos>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3E776A0 Offset: 0x3E777A1 VA: 0x3E776A0
	|-List<MapMind.Target>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3D87290 Offset: 0x3D87391 VA: 0x3D87290
	|-List<MapPanelDebug.Entity>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3D8A1A0 Offset: 0x3D8A2A1 VA: 0x3D8A1A0
	|-List<NexRanking.Data>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3D8D040 Offset: 0x3D8D141 VA: 0x3D8D040
	|-List<NexVersus.RatingData>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3D8FF40 Offset: 0x3D90041 VA: 0x3D8FF40
	|-List<PackedPlayModeBuildLogs.RuntimeBuildLog>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3D931D0 Offset: 0x3D932D1 VA: 0x3D931D0
	|-List<ParticleSystem.Particle>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3D96160 Offset: 0x3D96261 VA: 0x3D96160
	|-List<RangeData.Offset>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3D99250 Offset: 0x3D99351 VA: 0x3D99250
	|-List<RenderGraphDebugData.PassDebugData>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3D9C5B0 Offset: 0x3D9C6B1 VA: 0x3D9C5B0
	|-List<RenderGraphDebugData.ResourceDebugData>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3D9F610 Offset: 0x3D9F711 VA: 0x3D9F610
	|-List<RingCleaningUnitSelectMenu.GodParam>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3DA2870 Offset: 0x3DA2971 VA: 0x3DA2870
	|-List<ShadowUtility.Edge>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3D14CD0 Offset: 0x3D14DD1 VA: 0x3D14CD0
	|-List<SkillArray.Entity>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3D18030 Offset: 0x3D18131 VA: 0x3D18030
	|-List<TexturePacker_JsonArray.Frame>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3D1B390 Offset: 0x3D1B491 VA: 0x3D1B390
	|-List<TimeNotificationBehaviour.NotificationEntry>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3D1E5B0 Offset: 0x3D1E6B1 VA: 0x3D1E5B0
	|-List<UnitySynchronizationContext.WorkRequest>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3D21590 Offset: 0x3D21691 VA: 0x3D21590
	|-List<XmlSchemaObjectTable.XmlSchemaObjectEntry>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3D244B0 Offset: 0x3D245B1 VA: 0x3D244B0
	|-List<AssetBundleBuildMap.AssetBundleEntry.AssetPathString>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3D27770 Offset: 0x3D27871 VA: 0x3D27770
	|-List<Detail.DataStore.DataStoreChangeMetaParamInt>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3D2A7D0 Offset: 0x3D2A8D1 VA: 0x3D2A7D0
	|-List<Detail.DataStore.DataStoreDeleteParamInt>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3D2DA30 Offset: 0x3D2DB31 VA: 0x3D2DA30
	|-List<Detail.DataStore.DataStoreGetMetaParamInt>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3D30E10 Offset: 0x3D30F11 VA: 0x3D30E10
	|-List<Detail.DataStore.DataStoreMetaInfoInt>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3CF54D0 Offset: 0x3CF55D1 VA: 0x3CF54D0
	|-List<Detail.DataStore.DataStorePasswordInfoInt>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3CF86B0 Offset: 0x3CF87B1 VA: 0x3CF86B0
	|-List<Detail.DataStore.DataStorePersistenceInfoInt>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3CFB9E0 Offset: 0x3CFBAE1 VA: 0x3CFB9E0
	|-List<Detail.DataStore.DataStorePreparePostParamInt>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3CFEA00 Offset: 0x3CFEB01 VA: 0x3CFEA00
	|-List<Detail.DataStore.DataStoreRateObjectParamInt>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3D01B20 Offset: 0x3D01C21 VA: 0x3D01B20
	|-List<Detail.DataStore.DataStoreRatingInitParamInt>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3D04AD0 Offset: 0x3D04BD1 VA: 0x3D04AD0
	|-List<Detail.DataStore.DataStoreRatingTargetInt>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3D07EB0 Offset: 0x3D07FB1 VA: 0x3D07EB0
	|-List<Detail.Ranking.RankingCachedResultInt>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3D0AF90 Offset: 0x3D0B091 VA: 0x3D0AF90
	|-List<Detail.Ranking.RankingOrderParamInt>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3D0E320 Offset: 0x3D0E421 VA: 0x3D0E320
	|-List<Detail.Ranking.RankingRankDataInt>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3D11B80 Offset: 0x3D11C81 VA: 0x3D11B80
	|-List<Detail.Ranking2.Ranking2ChartInfoInt>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3D682A0 Offset: 0x3D683A1 VA: 0x3D682A0
	|-List<Detail.Ranking2.Ranking2RankDataInt>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3D6B370 Offset: 0x3D6B471 VA: 0x3D6B370
	|-List<Detail.Ranking2.Ranking2ScoreDataInt>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3D6E490 Offset: 0x3D6E591 VA: 0x3D6E490
	|-List<Detail.Screening.ScreeningContextInfoInt>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3D71AA0 Offset: 0x3D71BA1 VA: 0x3D71AA0
	|-List<Detail.Subscriber.SubscriberContentInt>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3D74E50 Offset: 0x3D74F51 VA: 0x3D74E50
	|-List<Detail.Subscriber.SubscriberGetContentParamInt>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3D78170 Offset: 0x3D78271 VA: 0x3D78170
	|-List<Detail.Subscriber.SubscriberUserStatusInfoInt>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3D7B3D0 Offset: 0x3D7B4D1 VA: 0x3D7B3D0
	|-List<Detail.Subscriber.SubscriberUserStatusParamInt>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3D7E2E0 Offset: 0x3D7E3E1 VA: 0x3D7E2E0
	|-List<Detail.Utility.IntegerSettings>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3D81180 Offset: 0x3D81281 VA: 0x3D81180
	|-List<Detail.Utility.UniqueIdInfoInt>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3D84100 Offset: 0x3D84201 VA: 0x3D84100
	|-List<MapHistory.Rewind.LatestInspectorData>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x30603C0 Offset: 0x30604C1 VA: 0x30603C0
	|-List<MapHistory.Rewind.WorkTerrainData>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3063330 Offset: 0x3063431 VA: 0x3063330
	|-List<MapSkill.AroundCalculator.Result>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3066590 Offset: 0x3066691 VA: 0x3066590
	|-List<TargetPositionCache.CacheCurve.Item>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3069970 Offset: 0x3069A71 VA: 0x3069970
	|-List<TargetPositionCache.CacheEntry.RecordingItem>.System.Collections.IList.IndexOf
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public void Insert(int index, T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3B0C2D0 Offset: 0x3B0C3D1 VA: 0x3B0C2D0
	|-List<IntervalTree.Entry<object>>.Insert
	|
	|-RVA: 0x3B0F2A0 Offset: 0x3B0F3A1 VA: 0x3B0F2A0
	|-List<KeyValuePair<DateTime, object>>.Insert
	|
	|-RVA: 0x3B121C0 Offset: 0x3B122C1 VA: 0x3B121C0
	|-List<KeyValuePair<int, object>>.Insert
	|
	|-RVA: 0x3B15320 Offset: 0x3B15421 VA: 0x3B15320
	|-List<KeyValuePair<object, ValueTuple<int, DateTime, object>>>.Insert
	|
	|-RVA: 0x3B18300 Offset: 0x3B18401 VA: 0x3B18300
	|-List<KeyValuePair<object, object>>.Insert
	|
	|-RVA: 0x3B1B460 Offset: 0x3B1B561 VA: 0x3B1B460
	|-List<CommonBattleSequence.Reliance<object>>.Insert
	|
	|-RVA: 0x3B1E430 Offset: 0x3B1E531 VA: 0x3B1E430
	|-List<RenderGraphResourcePool.ResourceLogInfo<object>>.Insert
	|
	|-RVA: 0x3B21350 Offset: 0x3B21451 VA: 0x3B21350
	|-List<ValueTuple<int, object>>.Insert
	|
	|-RVA: 0x3DE1F30 Offset: 0x3DE2031 VA: 0x3DE1F30
	|-List<ValueTuple<Int32Enum, int>>.Insert
	|
	|-RVA: 0x3DE5030 Offset: 0x3DE5131 VA: 0x3DE5030
	|-List<ValueTuple<object, ValueTuple<object, int>>>.Insert
	|
	|-RVA: 0x3DE8000 Offset: 0x3DE8101 VA: 0x3DE8000
	|-List<ValueTuple<object, int>>.Insert
	|
	|-RVA: 0x3DEAFF0 Offset: 0x3DEB0F1 VA: 0x3DEAFF0
	|-List<ValueTuple<Vector3, float>>.Insert
	|
	|-RVA: 0x3DEDF20 Offset: 0x3DEE021 VA: 0x3DEDF20
	|-List<ValueTuple<object, Int32Enum, int>>.Insert
	|
	|-RVA: 0x3DF1080 Offset: 0x3DF1181 VA: 0x3DF1080
	|-List<ValueTuple<object, int, int, int>>.Insert
	|
	|-RVA: 0x3E12020 Offset: 0x3E12121 VA: 0x3E12020
	|-List<AkEnvironment>.Insert
	|-List<AkRoom>.Insert
	|-List<BasicMenuItem>.Insert
	|-List<Camera>.Insert
	|-List<CinemachineBrain>.Insert
	|-List<CinemachineVirtualCameraBase>.Insert
	|-List<Decorator>.Insert
	|-List<DynValue>.Insert
	|-List<EventSystem>.Insert
	|-List<GameObject>.Insert
	|-List<GmapSpot>.Insert
	|-List<MapBackup>.Insert
	|-List<object>.Insert
	|-List<Phase>.Insert
	|-List<ProfileCard>.Insert
	|-List<RelayServerMetaData>.Insert
	|-List<ShadowCasterGroup2D>.Insert
	|-List<string>.Insert
	|-List<Unit>.Insert
	|-List<AssetTable.Accessory>.Insert
	|-List<Directory.SearchData>.Insert
	|-List<GameSaveDataHeaderReader.Handle>.Insert
	|-List<HelpManager.Item>.Insert
	|-List<MapDispos.ActualData>.Insert
	|-List<MapDispos.Pos>.Insert
	|-List<MapLayer.Data>.Insert
	|-List<MapObject.RigidInfo>.Insert
	|-List<RingListSequence.PageData>.Insert
	|-List<SimpleAnimationPlayable.StateInfo>.Insert
	|
	|-RVA: 0x3DF3FA0 Offset: 0x3DF40A1 VA: 0x3DF3FA0
	|-List<AnimatorClipInfo>.Insert
	|
	|-RVA: 0x3DF70A0 Offset: 0x3DF71A1 VA: 0x3DF70A0
	|-List<AsyncOperationHandle>.Insert
	|
	|-RVA: 0x3DFA2A0 Offset: 0x3DFA3A1 VA: 0x3DFA2A0
	|-List<BoneWeight>.Insert
	|
	|-RVA: 0x3DFD1D0 Offset: 0x3DFD2D1 VA: 0x3DFD1D0
	|-List<bool>.Insert
	|
	|-RVA: 0x3E7A720 Offset: 0x3E7A821 VA: 0x3E7A720
	|-List<byte>.Insert
	|
	|-RVA: 0x3E7D5D0 Offset: 0x3E7D6D1 VA: 0x3E7D5D0
	|-List<CameraInfo>.Insert
	|
	|-RVA: 0x3E80440 Offset: 0x3E80541 VA: 0x3E80440
	|-List<char>.Insert
	|
	|-RVA: 0x3E833C0 Offset: 0x3E834C1 VA: 0x3E833C0
	|-List<Color>.Insert
	|
	|-RVA: 0x3E86240 Offset: 0x3E86341 VA: 0x3E86240
	|-List<Color32>.Insert
	|
	|-RVA: 0x3E89100 Offset: 0x3E89201 VA: 0x3E89100
	|-List<ConstraintSource>.Insert
	|
	|-RVA: 0x3E8C260 Offset: 0x3E8C361 VA: 0x3E8C260
	|-List<ContourVertex>.Insert
	|
	|-RVA: 0x3E8F460 Offset: 0x3E8F561 VA: 0x3E8F460
	|-List<DataStoreRatingInfo>.Insert
	|
	|-RVA: 0x3E92360 Offset: 0x3E92461 VA: 0x3E92360
	|-List<DataStoreResult>.Insert
	|
	|-RVA: 0x3E95170 Offset: 0x3E95271 VA: 0x3E95170
	|-List<DateTime>.Insert
	|
	|-RVA: 0x3E98010 Offset: 0x3E98111 VA: 0x3E98010
	|-List<DateTimeOffset>.Insert
	|
	|-RVA: 0x3E9AEF0 Offset: 0x3E9AFF1 VA: 0x3E9AEF0
	|-List<Decimal>.Insert
	|
	|-RVA: 0x3E9E1C0 Offset: 0x3E9E2C1 VA: 0x3E9E1C0
	|-List<DiagnosticEvent>.Insert
	|
	|-RVA: 0x3EA1190 Offset: 0x3EA1291 VA: 0x3EA1190
	|-List<double>.Insert
	|
	|-RVA: 0x3EA43A0 Offset: 0x3EA44A1 VA: 0x3EA43A0
	|-List<Friend>.Insert
	|
	|-RVA: 0x3EA73C0 Offset: 0x3EA74C1 VA: 0x3EA73C0
	|-List<GlyphRect>.Insert
	|
	|-RVA: 0x3EAA210 Offset: 0x3EAA311 VA: 0x3EAA210
	|-List<short>.Insert
	|
	|-RVA: 0x3EAD010 Offset: 0x3EAD111 VA: 0x3EAD010
	|-List<int>.Insert
	|
	|-RVA: 0x3EAFE10 Offset: 0x3EAFF11 VA: 0x3EAFE10
	|-List<Int32Enum>.Insert
	|
	|-RVA: 0x3EB2C10 Offset: 0x3EB2D11 VA: 0x3EB2C10
	|-List<long>.Insert
	|
	|-RVA: 0x3DFFFE0 Offset: 0x3E000E1 VA: 0x3DFFFE0
	|-List<IntPtr>.Insert
	|
	|-RVA: 0x3E02E90 Offset: 0x3E02F91 VA: 0x3E02E90
	|-List<InterpretedFrameInfo>.Insert
	|
	|-RVA: 0x3E05FE0 Offset: 0x3E060E1 VA: 0x3E05FE0
	|-List<IntervalTreeNode>.Insert
	|
	|-RVA: 0x3E08EE0 Offset: 0x3E08FE1 VA: 0x3E08EE0
	|-List<LengthLimitProperties>.Insert
	|
	|-RVA: 0x3E0BCF0 Offset: 0x3E0BDF1 VA: 0x3E0BCF0
	|-List<MapPos>.Insert
	|
	|-RVA: 0x3E0F060 Offset: 0x3E0F161 VA: 0x3E0F060
	|-List<Matrix4x4>.Insert
	|
	|-RVA: 0x3E152C0 Offset: 0x3E153C1 VA: 0x3E152C0
	|-List<ObjectInitializationData>.Insert
	|
	|-RVA: 0x3E18570 Offset: 0x3E18671 VA: 0x3E18570
	|-List<PlayableBinding>.Insert
	|
	|-RVA: 0x3E1B8D0 Offset: 0x3E1B9D1 VA: 0x3E1B8D0
	|-List<PlayerLoopSystem>.Insert
	|
	|-RVA: 0x3DA5D70 Offset: 0x3DA5E71 VA: 0x3DA5D70
	|-List<PlayerLoopSystemInternal>.Insert
	|
	|-RVA: 0x3DA8DC0 Offset: 0x3DA8EC1 VA: 0x3DA8DC0
	|-List<RangePositionInfo>.Insert
	|
	|-RVA: 0x3DABC30 Offset: 0x3DABD31 VA: 0x3DABC30
	|-List<Ranking2ChartInfoInput>.Insert
	|
	|-RVA: 0x3DAEEB0 Offset: 0x3DAEFB1 VA: 0x3DAEEB0
	|-List<RaycastHit2D>.Insert
	|
	|-RVA: 0x3DB2580 Offset: 0x3DB2681 VA: 0x3DB2580
	|-List<RaycastResult>.Insert
	|
	|-RVA: 0x3DB57F0 Offset: 0x3DB58F1 VA: 0x3DB57F0
	|-List<Rect>.Insert
	|
	|-RVA: 0x3DB8670 Offset: 0x3DB8771 VA: 0x3DB8670
	|-List<RendererListHandle>.Insert
	|
	|-RVA: 0x3DBB480 Offset: 0x3DBB581 VA: 0x3DBB480
	|-List<ResourceHandle>.Insert
	|
	|-RVA: 0x3DBE2A0 Offset: 0x3DBE3A1 VA: 0x3DBE2A0
	|-List<sbyte>.Insert
	|
	|-RVA: 0x3DC10A0 Offset: 0x3DC11A1 VA: 0x3DC10A0
	|-List<ShaderTagId>.Insert
	|
	|-RVA: 0x3E3CD10 Offset: 0x3E3CE11 VA: 0x3E3CD10
	|-List<float>.Insert
	|
	|-RVA: 0x3E405E0 Offset: 0x3E406E1 VA: 0x3E405E0
	|-List<SphericalHarmonicsL2>.Insert
	|
	|-RVA: 0x3E43C60 Offset: 0x3E43D61 VA: 0x3E43C60
	|-List<SubMeshDescriptor>.Insert
	|
	|-RVA: 0x3E46CA0 Offset: 0x3E46DA1 VA: 0x3E46CA0
	|-List<TablePair>.Insert
	|
	|-RVA: 0x3E49B10 Offset: 0x3E49C11 VA: 0x3E49B10
	|-List<TimeSpan>.Insert
	|
	|-RVA: 0x3E4CA70 Offset: 0x3E4CB71 VA: 0x3E4CA70
	|-List<UICharInfo>.Insert
	|
	|-RVA: 0x3E4F990 Offset: 0x3E4FA91 VA: 0x3E4F990
	|-List<UILineInfo>.Insert
	|
	|-RVA: 0x3E532A0 Offset: 0x3E533A1 VA: 0x3E532A0
	|-List<UIVertex>.Insert
	|
	|-RVA: 0x3E564C0 Offset: 0x3E565C1 VA: 0x3E564C0
	|-List<ushort>.Insert
	|
	|-RVA: 0x3E592C0 Offset: 0x3E593C1 VA: 0x3E592C0
	|-List<uint>.Insert
	|
	|-RVA: 0x3DC3EB0 Offset: 0x3DC3FB1 VA: 0x3DC3EB0
	|-List<ulong>.Insert
	|
	|-RVA: 0x3DC6D40 Offset: 0x3DC6E41 VA: 0x3DC6D40
	|-List<Vector2>.Insert
	|
	|-RVA: 0x3DC9CD0 Offset: 0x3DC9DD1 VA: 0x3DC9CD0
	|-List<Vector3>.Insert
	|
	|-RVA: 0x3DCCCE0 Offset: 0x3DCCDE1 VA: 0x3DCCCE0
	|-List<Vector4>.Insert
	|
	|-RVA: 0x3DCFBF0 Offset: 0x3DCFCF1 VA: 0x3DCFBF0
	|-List<VertexAttributeDescriptor>.Insert
	|
	|-RVA: 0x3DD2AF0 Offset: 0x3DD2BF1 VA: 0x3DD2AF0
	|-List<X509ChainStatus>.Insert
	|
	|-RVA: 0x3DD5DB0 Offset: 0x3DD5EB1 VA: 0x3DD5DB0
	|-List<XRView>.Insert
	|
	|-RVA: 0x3DD8E00 Offset: 0x3DD8F01 VA: 0x3DD8E00
	|-List<AmiiboSequence.GainItemData>.Insert
	|
	|-RVA: 0x3DDC090 Offset: 0x3DDC191 VA: 0x3DDC090
	|-List<AnimationOutputWeightProcessor.WeightInfo>.Insert
	|
	|-RVA: 0x3DDF0C0 Offset: 0x3DDF1C1 VA: 0x3DDF0C0
	|-List<ArenaOrderSequence.GodInfo>.Insert
	|
	|-RVA: 0x3E1E920 Offset: 0x3E1EA21 VA: 0x3E1E920
	|-List<BattleInfo.SupportData>.Insert
	|
	|-RVA: 0x3E21840 Offset: 0x3E21941 VA: 0x3E21840
	|-List<BeforeRenderHelper.OrderBlock>.Insert
	|
	|-RVA: 0x3E249B0 Offset: 0x3E24AB1 VA: 0x3E249B0
	|-List<Camera.RenderRequest>.Insert
	|
	|-RVA: 0x3E27990 Offset: 0x3E27A91 VA: 0x3E27990
	|-List<CameraState.CustomBlendable>.Insert
	|
	|-RVA: 0x3E2A800 Offset: 0x3E2A901 VA: 0x3E2A800
	|-List<CinemachineClearShot.Pair>.Insert
	|
	|-RVA: 0x3E2D610 Offset: 0x3E2D711 VA: 0x3E2D610
	|-List<CinemachineStateDrivenCamera.HashPair>.Insert
	|
	|-RVA: 0x3E30710 Offset: 0x3E30811 VA: 0x3E30710
	|-List<DelayedActionManager.DelegateInfo>.Insert
	|
	|-RVA: 0x3E33AA0 Offset: 0x3E33BA1 VA: 0x3E33AA0
	|-List<Detail.AsyncResultInt>.Insert
	|
	|-RVA: 0x3E36AC0 Offset: 0x3E36BC1 VA: 0x3E36AC0
	|-List<Detail.CppArray>.Insert
	|
	|-RVA: 0x3E39D70 Offset: 0x3E39E71 VA: 0x3E39D70
	|-List<Detail.NotificationEventInt>.Insert
	|
	|-RVA: 0x3E5C170 Offset: 0x3E5C271 VA: 0x3E5C170
	|-List<DragonRideTargetGroup.ChainParam>.Insert
	|
	|-RVA: 0x3E5F2D0 Offset: 0x3E5F3D1 VA: 0x3E5F2D0
	|-List<GmapPathAdjuster.TargetModel>.Insert
	|
	|-RVA: 0x3E624E0 Offset: 0x3E625E1 VA: 0x3E624E0
	|-List<GmapSpotAdjuster.TargetModel>.Insert
	|
	|-RVA: 0x3E656F0 Offset: 0x3E657F1 VA: 0x3E656F0
	|-List<HubFastTravel.Location>.Insert
	|
	|-RVA: 0x3E68A90 Offset: 0x3E68B91 VA: 0x3E68A90
	|-List<HubLensFlare.Flare>.Insert
	|
	|-RVA: 0x3E6BB00 Offset: 0x3E6BC01 VA: 0x3E6BB00
	|-List<InventoryPoolItemMenuContent.KindBgNameClass>.Insert
	|
	|-RVA: 0x3E6E970 Offset: 0x3E6EA71 VA: 0x3E6E970
	|-List<Map.Pos>.Insert
	|
	|-RVA: 0x3E71810 Offset: 0x3E71911 VA: 0x3E71810
	|-List<MapImage.BackupTerrain>.Insert
	|
	|-RVA: 0x3E746D0 Offset: 0x3E747D1 VA: 0x3E746D0
	|-List<MapImageRange.Pos>.Insert
	|
	|-RVA: 0x3E777F0 Offset: 0x3E778F1 VA: 0x3E777F0
	|-List<MapMind.Target>.Insert
	|
	|-RVA: 0x3D873E0 Offset: 0x3D874E1 VA: 0x3D873E0
	|-List<MapPanelDebug.Entity>.Insert
	|
	|-RVA: 0x3D8A2E0 Offset: 0x3D8A3E1 VA: 0x3D8A2E0
	|-List<NexRanking.Data>.Insert
	|
	|-RVA: 0x3D8D180 Offset: 0x3D8D281 VA: 0x3D8D180
	|-List<NexVersus.RatingData>.Insert
	|
	|-RVA: 0x3D90080 Offset: 0x3D90181 VA: 0x3D90080
	|-List<PackedPlayModeBuildLogs.RuntimeBuildLog>.Insert
	|
	|-RVA: 0x3D93320 Offset: 0x3D93421 VA: 0x3D93320
	|-List<ParticleSystem.Particle>.Insert
	|
	|-RVA: 0x3D962A0 Offset: 0x3D963A1 VA: 0x3D962A0
	|-List<RangeData.Offset>.Insert
	|
	|-RVA: 0x3D993A0 Offset: 0x3D994A1 VA: 0x3D993A0
	|-List<RenderGraphDebugData.PassDebugData>.Insert
	|
	|-RVA: 0x3D9C700 Offset: 0x3D9C801 VA: 0x3D9C700
	|-List<RenderGraphDebugData.ResourceDebugData>.Insert
	|
	|-RVA: 0x3D9F750 Offset: 0x3D9F851 VA: 0x3D9F750
	|-List<RingCleaningUnitSelectMenu.GodParam>.Insert
	|
	|-RVA: 0x3DA29C0 Offset: 0x3DA2AC1 VA: 0x3DA29C0
	|-List<ShadowUtility.Edge>.Insert
	|
	|-RVA: 0x3D14E10 Offset: 0x3D14F11 VA: 0x3D14E10
	|-List<SkillArray.Entity>.Insert
	|
	|-RVA: 0x3D18190 Offset: 0x3D18291 VA: 0x3D18190
	|-List<TexturePacker_JsonArray.Frame>.Insert
	|
	|-RVA: 0x3D1B4E0 Offset: 0x3D1B5E1 VA: 0x3D1B4E0
	|-List<TimeNotificationBehaviour.NotificationEntry>.Insert
	|
	|-RVA: 0x3D1E700 Offset: 0x3D1E801 VA: 0x3D1E700
	|-List<UnitySynchronizationContext.WorkRequest>.Insert
	|
	|-RVA: 0x3D216D0 Offset: 0x3D217D1 VA: 0x3D216D0
	|-List<XmlSchemaObjectTable.XmlSchemaObjectEntry>.Insert
	|
	|-RVA: 0x3D245F0 Offset: 0x3D246F1 VA: 0x3D245F0
	|-List<AssetBundleBuildMap.AssetBundleEntry.AssetPathString>.Insert
	|
	|-RVA: 0x3D278C0 Offset: 0x3D279C1 VA: 0x3D278C0
	|-List<Detail.DataStore.DataStoreChangeMetaParamInt>.Insert
	|
	|-RVA: 0x3D2A910 Offset: 0x3D2AA11 VA: 0x3D2A910
	|-List<Detail.DataStore.DataStoreDeleteParamInt>.Insert
	|
	|-RVA: 0x3D2DB80 Offset: 0x3D2DC81 VA: 0x3D2DB80
	|-List<Detail.DataStore.DataStoreGetMetaParamInt>.Insert
	|
	|-RVA: 0x3D30F60 Offset: 0x3D31061 VA: 0x3D30F60
	|-List<Detail.DataStore.DataStoreMetaInfoInt>.Insert
	|
	|-RVA: 0x3CF5620 Offset: 0x3CF5721 VA: 0x3CF5620
	|-List<Detail.DataStore.DataStorePasswordInfoInt>.Insert
	|
	|-RVA: 0x3CF8800 Offset: 0x3CF8901 VA: 0x3CF8800
	|-List<Detail.DataStore.DataStorePersistenceInfoInt>.Insert
	|
	|-RVA: 0x3CFBB30 Offset: 0x3CFBC31 VA: 0x3CFBB30
	|-List<Detail.DataStore.DataStorePreparePostParamInt>.Insert
	|
	|-RVA: 0x3CFEB40 Offset: 0x3CFEC41 VA: 0x3CFEB40
	|-List<Detail.DataStore.DataStoreRateObjectParamInt>.Insert
	|
	|-RVA: 0x3D01C70 Offset: 0x3D01D71 VA: 0x3D01C70
	|-List<Detail.DataStore.DataStoreRatingInitParamInt>.Insert
	|
	|-RVA: 0x3D04C10 Offset: 0x3D04D11 VA: 0x3D04C10
	|-List<Detail.DataStore.DataStoreRatingTargetInt>.Insert
	|
	|-RVA: 0x3D08010 Offset: 0x3D08111 VA: 0x3D08010
	|-List<Detail.Ranking.RankingCachedResultInt>.Insert
	|
	|-RVA: 0x3D0B0D0 Offset: 0x3D0B1D1 VA: 0x3D0B0D0
	|-List<Detail.Ranking.RankingOrderParamInt>.Insert
	|
	|-RVA: 0x3D0E480 Offset: 0x3D0E581 VA: 0x3D0E480
	|-List<Detail.Ranking.RankingRankDataInt>.Insert
	|
	|-RVA: 0x3D11CF0 Offset: 0x3D11DF1 VA: 0x3D11CF0
	|-List<Detail.Ranking2.Ranking2ChartInfoInt>.Insert
	|
	|-RVA: 0x3D68400 Offset: 0x3D68501 VA: 0x3D68400
	|-List<Detail.Ranking2.Ranking2RankDataInt>.Insert
	|
	|-RVA: 0x3D6B4B0 Offset: 0x3D6B5B1 VA: 0x3D6B4B0
	|-List<Detail.Ranking2.Ranking2ScoreDataInt>.Insert
	|
	|-RVA: 0x3D6E5E0 Offset: 0x3D6E6E1 VA: 0x3D6E5E0
	|-List<Detail.Screening.ScreeningContextInfoInt>.Insert
	|
	|-RVA: 0x3D71C00 Offset: 0x3D71D01 VA: 0x3D71C00
	|-List<Detail.Subscriber.SubscriberContentInt>.Insert
	|
	|-RVA: 0x3D74FA0 Offset: 0x3D750A1 VA: 0x3D74FA0
	|-List<Detail.Subscriber.SubscriberGetContentParamInt>.Insert
	|
	|-RVA: 0x3D782C0 Offset: 0x3D783C1 VA: 0x3D782C0
	|-List<Detail.Subscriber.SubscriberUserStatusInfoInt>.Insert
	|
	|-RVA: 0x3D7B520 Offset: 0x3D7B621 VA: 0x3D7B520
	|-List<Detail.Subscriber.SubscriberUserStatusParamInt>.Insert
	|
	|-RVA: 0x3D7E420 Offset: 0x3D7E521 VA: 0x3D7E420
	|-List<Detail.Utility.IntegerSettings>.Insert
	|
	|-RVA: 0x3D812C0 Offset: 0x3D813C1 VA: 0x3D812C0
	|-List<Detail.Utility.UniqueIdInfoInt>.Insert
	|
	|-RVA: 0x3D84250 Offset: 0x3D84351 VA: 0x3D84250
	|-List<MapHistory.Rewind.LatestInspectorData>.Insert
	|
	|-RVA: 0x3060510 Offset: 0x3060611 VA: 0x3060510
	|-List<MapHistory.Rewind.WorkTerrainData>.Insert
	|
	|-RVA: 0x3063470 Offset: 0x3063571 VA: 0x3063470
	|-List<MapSkill.AroundCalculator.Result>.Insert
	|
	|-RVA: 0x30666E0 Offset: 0x30667E1 VA: 0x30666E0
	|-List<TargetPositionCache.CacheCurve.Item>.Insert
	|
	|-RVA: 0x3069AD0 Offset: 0x3069BD1 VA: 0x3069AD0
	|-List<TargetPositionCache.CacheEntry.RecordingItem>.Insert
	*/

	// RVA: -1 Offset: -1 Slot: 25
	private void System.Collections.IList.Insert(int index, object item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3B0C400 Offset: 0x3B0C501 VA: 0x3B0C400
	|-List<IntervalTree.Entry<object>>.System.Collections.IList.Insert
	|
	|-RVA: 0x3B0F3C0 Offset: 0x3B0F4C1 VA: 0x3B0F3C0
	|-List<KeyValuePair<DateTime, object>>.System.Collections.IList.Insert
	|
	|-RVA: 0x3B122E0 Offset: 0x3B123E1 VA: 0x3B122E0
	|-List<KeyValuePair<int, object>>.System.Collections.IList.Insert
	|
	|-RVA: 0x3B15450 Offset: 0x3B15551 VA: 0x3B15450
	|-List<KeyValuePair<object, ValueTuple<int, DateTime, object>>>.System.Collections.IList.Insert
	|
	|-RVA: 0x3B18420 Offset: 0x3B18521 VA: 0x3B18420
	|-List<KeyValuePair<object, object>>.System.Collections.IList.Insert
	|
	|-RVA: 0x3B1B590 Offset: 0x3B1B691 VA: 0x3B1B590
	|-List<CommonBattleSequence.Reliance<object>>.System.Collections.IList.Insert
	|
	|-RVA: 0x3B1E550 Offset: 0x3B1E651 VA: 0x3B1E550
	|-List<RenderGraphResourcePool.ResourceLogInfo<object>>.System.Collections.IList.Insert
	|
	|-RVA: 0x3B21470 Offset: 0x3B21571 VA: 0x3B21470
	|-List<ValueTuple<int, object>>.System.Collections.IList.Insert
	|
	|-RVA: 0x3DE2030 Offset: 0x3DE2131 VA: 0x3DE2030
	|-List<ValueTuple<Int32Enum, int>>.System.Collections.IList.Insert
	|
	|-RVA: 0x3DE5160 Offset: 0x3DE5261 VA: 0x3DE5160
	|-List<ValueTuple<object, ValueTuple<object, int>>>.System.Collections.IList.Insert
	|
	|-RVA: 0x3DE8120 Offset: 0x3DE8221 VA: 0x3DE8120
	|-List<ValueTuple<object, int>>.System.Collections.IList.Insert
	|
	|-RVA: 0x3DEB120 Offset: 0x3DEB221 VA: 0x3DEB120
	|-List<ValueTuple<Vector3, float>>.System.Collections.IList.Insert
	|
	|-RVA: 0x3DEE040 Offset: 0x3DEE141 VA: 0x3DEE040
	|-List<ValueTuple<object, Int32Enum, int>>.System.Collections.IList.Insert
	|
	|-RVA: 0x3DF11B0 Offset: 0x3DF12B1 VA: 0x3DF11B0
	|-List<ValueTuple<object, int, int, int>>.System.Collections.IList.Insert
	|
	|-RVA: 0x3DF40A0 Offset: 0x3DF41A1 VA: 0x3DF40A0
	|-List<AnimatorClipInfo>.System.Collections.IList.Insert
	|
	|-RVA: 0x3DF71D0 Offset: 0x3DF72D1 VA: 0x3DF71D0
	|-List<AsyncOperationHandle>.System.Collections.IList.Insert
	|
	|-RVA: 0x3DFA3C0 Offset: 0x3DFA4C1 VA: 0x3DFA3C0
	|-List<BoneWeight>.System.Collections.IList.Insert
	|
	|-RVA: 0x3DFD2E0 Offset: 0x3DFD3E1 VA: 0x3DFD2E0
	|-List<bool>.System.Collections.IList.Insert
	|
	|-RVA: 0x3E7A820 Offset: 0x3E7A921 VA: 0x3E7A820
	|-List<byte>.System.Collections.IList.Insert
	|
	|-RVA: 0x3E12130 Offset: 0x3E12231 VA: 0x3E12130
	|-List<Camera>.System.Collections.IList.Insert
	|-List<Decorator>.System.Collections.IList.Insert
	|-List<DynValue>.System.Collections.IList.Insert
	|-List<GameObject>.System.Collections.IList.Insert
	|-List<MapBackup>.System.Collections.IList.Insert
	|-List<object>.System.Collections.IList.Insert
	|-List<Phase>.System.Collections.IList.Insert
	|-List<ProfileCard>.System.Collections.IList.Insert
	|-List<Unit>.System.Collections.IList.Insert
	|-List<AssetTable.Accessory>.System.Collections.IList.Insert
	|-List<GameSaveDataHeaderReader.Handle>.System.Collections.IList.Insert
	|-List<MapDispos.ActualData>.System.Collections.IList.Insert
	|-List<MapDispos.Pos>.System.Collections.IList.Insert
	|-List<MapLayer.Data>.System.Collections.IList.Insert
	|-List<MapObject.RigidInfo>.System.Collections.IList.Insert
	|-List<RingListSequence.PageData>.System.Collections.IList.Insert
	|
	|-RVA: 0x3E7D6F0 Offset: 0x3E7D7F1 VA: 0x3E7D6F0
	|-List<CameraInfo>.System.Collections.IList.Insert
	|
	|-RVA: 0x3E80540 Offset: 0x3E80641 VA: 0x3E80540
	|-List<char>.System.Collections.IList.Insert
	|
	|-RVA: 0x3E834F0 Offset: 0x3E835F1 VA: 0x3E834F0
	|-List<Color>.System.Collections.IList.Insert
	|
	|-RVA: 0x3E86340 Offset: 0x3E86441 VA: 0x3E86340
	|-List<Color32>.System.Collections.IList.Insert
	|
	|-RVA: 0x3E89220 Offset: 0x3E89321 VA: 0x3E89220
	|-List<ConstraintSource>.System.Collections.IList.Insert
	|
	|-RVA: 0x3E8C390 Offset: 0x3E8C491 VA: 0x3E8C390
	|-List<ContourVertex>.System.Collections.IList.Insert
	|
	|-RVA: 0x3E8F580 Offset: 0x3E8F681 VA: 0x3E8F580
	|-List<DataStoreRatingInfo>.System.Collections.IList.Insert
	|
	|-RVA: 0x3E92460 Offset: 0x3E92561 VA: 0x3E92460
	|-List<DataStoreResult>.System.Collections.IList.Insert
	|
	|-RVA: 0x3E95270 Offset: 0x3E95371 VA: 0x3E95270
	|-List<DateTime>.System.Collections.IList.Insert
	|
	|-RVA: 0x3E98120 Offset: 0x3E98221 VA: 0x3E98120
	|-List<DateTimeOffset>.System.Collections.IList.Insert
	|
	|-RVA: 0x3E9B000 Offset: 0x3E9B101 VA: 0x3E9B000
	|-List<Decimal>.System.Collections.IList.Insert
	|
	|-RVA: 0x3E9E300 Offset: 0x3E9E401 VA: 0x3E9E300
	|-List<DiagnosticEvent>.System.Collections.IList.Insert
	|
	|-RVA: 0x3EA12A0 Offset: 0x3EA13A1 VA: 0x3EA12A0
	|-List<double>.System.Collections.IList.Insert
	|
	|-RVA: 0x3EA44D0 Offset: 0x3EA45D1 VA: 0x3EA44D0
	|-List<Friend>.System.Collections.IList.Insert
	|
	|-RVA: 0x3EA74D0 Offset: 0x3EA75D1 VA: 0x3EA74D0
	|-List<GlyphRect>.System.Collections.IList.Insert
	|
	|-RVA: 0x3EAA310 Offset: 0x3EAA411 VA: 0x3EAA310
	|-List<short>.System.Collections.IList.Insert
	|
	|-RVA: 0x3EAD110 Offset: 0x3EAD211 VA: 0x3EAD110
	|-List<int>.System.Collections.IList.Insert
	|
	|-RVA: 0x3EAFF10 Offset: 0x3EB0011 VA: 0x3EAFF10
	|-List<Int32Enum>.System.Collections.IList.Insert
	|
	|-RVA: 0x3EB2D10 Offset: 0x3EB2E11 VA: 0x3EB2D10
	|-List<long>.System.Collections.IList.Insert
	|
	|-RVA: 0x3E000E0 Offset: 0x3E001E1 VA: 0x3E000E0
	|-List<IntPtr>.System.Collections.IList.Insert
	|
	|-RVA: 0x3E02FB0 Offset: 0x3E030B1 VA: 0x3E02FB0
	|-List<InterpretedFrameInfo>.System.Collections.IList.Insert
	|
	|-RVA: 0x3E06100 Offset: 0x3E06201 VA: 0x3E06100
	|-List<IntervalTreeNode>.System.Collections.IList.Insert
	|
	|-RVA: 0x3E08FE0 Offset: 0x3E090E1 VA: 0x3E08FE0
	|-List<LengthLimitProperties>.System.Collections.IList.Insert
	|
	|-RVA: 0x3E0BDF0 Offset: 0x3E0BEF1 VA: 0x3E0BDF0
	|-List<MapPos>.System.Collections.IList.Insert
	|
	|-RVA: 0x3E0F1A0 Offset: 0x3E0F2A1 VA: 0x3E0F1A0
	|-List<Matrix4x4>.System.Collections.IList.Insert
	|
	|-RVA: 0x3E15400 Offset: 0x3E15501 VA: 0x3E15400
	|-List<ObjectInitializationData>.System.Collections.IList.Insert
	|
	|-RVA: 0x3E186A0 Offset: 0x3E187A1 VA: 0x3E186A0
	|-List<PlayableBinding>.System.Collections.IList.Insert
	|
	|-RVA: 0x3E1BA10 Offset: 0x3E1BB11 VA: 0x3E1BA10
	|-List<PlayerLoopSystem>.System.Collections.IList.Insert
	|
	|-RVA: 0x3DA5EB0 Offset: 0x3DA5FB1 VA: 0x3DA5EB0
	|-List<PlayerLoopSystemInternal>.System.Collections.IList.Insert
	|
	|-RVA: 0x3DA8EE0 Offset: 0x3DA8FE1 VA: 0x3DA8EE0
	|-List<RangePositionInfo>.System.Collections.IList.Insert
	|
	|-RVA: 0x3DABD30 Offset: 0x3DABE31 VA: 0x3DABD30
	|-List<Ranking2ChartInfoInput>.System.Collections.IList.Insert
	|
	|-RVA: 0x3DAEFF0 Offset: 0x3DAF0F1 VA: 0x3DAEFF0
	|-List<RaycastHit2D>.System.Collections.IList.Insert
	|
	|-RVA: 0x3DB26E0 Offset: 0x3DB27E1 VA: 0x3DB26E0
	|-List<RaycastResult>.System.Collections.IList.Insert
	|
	|-RVA: 0x3DB5920 Offset: 0x3DB5A21 VA: 0x3DB5920
	|-List<Rect>.System.Collections.IList.Insert
	|
	|-RVA: 0x3DB8770 Offset: 0x3DB8871 VA: 0x3DB8770
	|-List<RendererListHandle>.System.Collections.IList.Insert
	|
	|-RVA: 0x3DBB580 Offset: 0x3DBB681 VA: 0x3DBB580
	|-List<ResourceHandle>.System.Collections.IList.Insert
	|
	|-RVA: 0x3DBE3A0 Offset: 0x3DBE4A1 VA: 0x3DBE3A0
	|-List<sbyte>.System.Collections.IList.Insert
	|
	|-RVA: 0x3DC11A0 Offset: 0x3DC12A1 VA: 0x3DC11A0
	|-List<ShaderTagId>.System.Collections.IList.Insert
	|
	|-RVA: 0x3E3CE20 Offset: 0x3E3CF21 VA: 0x3E3CE20
	|-List<float>.System.Collections.IList.Insert
	|
	|-RVA: 0x3E40760 Offset: 0x3E40861 VA: 0x3E40760
	|-List<SphericalHarmonicsL2>.System.Collections.IList.Insert
	|
	|-RVA: 0x3E43D90 Offset: 0x3E43E91 VA: 0x3E43D90
	|-List<SubMeshDescriptor>.System.Collections.IList.Insert
	|
	|-RVA: 0x3E46DC0 Offset: 0x3E46EC1 VA: 0x3E46DC0
	|-List<TablePair>.System.Collections.IList.Insert
	|
	|-RVA: 0x3E49C10 Offset: 0x3E49D11 VA: 0x3E49C10
	|-List<TimeSpan>.System.Collections.IList.Insert
	|
	|-RVA: 0x3E4CBA0 Offset: 0x3E4CCA1 VA: 0x3E4CBA0
	|-List<UICharInfo>.System.Collections.IList.Insert
	|
	|-RVA: 0x3E4FAA0 Offset: 0x3E4FBA1 VA: 0x3E4FAA0
	|-List<UILineInfo>.System.Collections.IList.Insert
	|
	|-RVA: 0x3E53420 Offset: 0x3E53521 VA: 0x3E53420
	|-List<UIVertex>.System.Collections.IList.Insert
	|
	|-RVA: 0x3E565C0 Offset: 0x3E566C1 VA: 0x3E565C0
	|-List<ushort>.System.Collections.IList.Insert
	|
	|-RVA: 0x3E593C0 Offset: 0x3E594C1 VA: 0x3E593C0
	|-List<uint>.System.Collections.IList.Insert
	|
	|-RVA: 0x3DC3FB0 Offset: 0x3DC40B1 VA: 0x3DC3FB0
	|-List<ulong>.System.Collections.IList.Insert
	|
	|-RVA: 0x3DC6E50 Offset: 0x3DC6F51 VA: 0x3DC6E50
	|-List<Vector2>.System.Collections.IList.Insert
	|
	|-RVA: 0x3DC9E00 Offset: 0x3DC9F01 VA: 0x3DC9E00
	|-List<Vector3>.System.Collections.IList.Insert
	|
	|-RVA: 0x3DCCE10 Offset: 0x3DCCF11 VA: 0x3DCCE10
	|-List<Vector4>.System.Collections.IList.Insert
	|
	|-RVA: 0x3DCFD00 Offset: 0x3DCFE01 VA: 0x3DCFD00
	|-List<VertexAttributeDescriptor>.System.Collections.IList.Insert
	|
	|-RVA: 0x3DD2C10 Offset: 0x3DD2D11 VA: 0x3DD2C10
	|-List<X509ChainStatus>.System.Collections.IList.Insert
	|
	|-RVA: 0x3DD5EE0 Offset: 0x3DD5FE1 VA: 0x3DD5EE0
	|-List<XRView>.System.Collections.IList.Insert
	|
	|-RVA: 0x3DD8F20 Offset: 0x3DD9021 VA: 0x3DD8F20
	|-List<AmiiboSequence.GainItemData>.System.Collections.IList.Insert
	|
	|-RVA: 0x3DDC1C0 Offset: 0x3DDC2C1 VA: 0x3DDC1C0
	|-List<AnimationOutputWeightProcessor.WeightInfo>.System.Collections.IList.Insert
	|
	|-RVA: 0x3DDF1E0 Offset: 0x3DDF2E1 VA: 0x3DDF1E0
	|-List<ArenaOrderSequence.GodInfo>.System.Collections.IList.Insert
	|
	|-RVA: 0x3E1EA40 Offset: 0x3E1EB41 VA: 0x3E1EA40
	|-List<BattleInfo.SupportData>.System.Collections.IList.Insert
	|
	|-RVA: 0x3E21960 Offset: 0x3E21A61 VA: 0x3E21960
	|-List<BeforeRenderHelper.OrderBlock>.System.Collections.IList.Insert
	|
	|-RVA: 0x3E24AE0 Offset: 0x3E24BE1 VA: 0x3E24AE0
	|-List<Camera.RenderRequest>.System.Collections.IList.Insert
	|
	|-RVA: 0x3E27AB0 Offset: 0x3E27BB1 VA: 0x3E27AB0
	|-List<CameraState.CustomBlendable>.System.Collections.IList.Insert
	|
	|-RVA: 0x3E2A900 Offset: 0x3E2AA01 VA: 0x3E2A900
	|-List<CinemachineClearShot.Pair>.System.Collections.IList.Insert
	|
	|-RVA: 0x3E2D710 Offset: 0x3E2D811 VA: 0x3E2D710
	|-List<CinemachineStateDrivenCamera.HashPair>.System.Collections.IList.Insert
	|
	|-RVA: 0x3E30840 Offset: 0x3E30941 VA: 0x3E30840
	|-List<DelayedActionManager.DelegateInfo>.System.Collections.IList.Insert
	|
	|-RVA: 0x3E33BD0 Offset: 0x3E33CD1 VA: 0x3E33BD0
	|-List<Detail.AsyncResultInt>.System.Collections.IList.Insert
	|
	|-RVA: 0x3E36BD0 Offset: 0x3E36CD1 VA: 0x3E36BD0
	|-List<Detail.CppArray>.System.Collections.IList.Insert
	|
	|-RVA: 0x3E39EA0 Offset: 0x3E39FA1 VA: 0x3E39EA0
	|-List<Detail.NotificationEventInt>.System.Collections.IList.Insert
	|
	|-RVA: 0x3E5C290 Offset: 0x3E5C391 VA: 0x3E5C290
	|-List<DragonRideTargetGroup.ChainParam>.System.Collections.IList.Insert
	|
	|-RVA: 0x3E5F400 Offset: 0x3E5F501 VA: 0x3E5F400
	|-List<GmapPathAdjuster.TargetModel>.System.Collections.IList.Insert
	|
	|-RVA: 0x3E62610 Offset: 0x3E62711 VA: 0x3E62610
	|-List<GmapSpotAdjuster.TargetModel>.System.Collections.IList.Insert
	|
	|-RVA: 0x3E65820 Offset: 0x3E65921 VA: 0x3E65820
	|-List<HubFastTravel.Location>.System.Collections.IList.Insert
	|
	|-RVA: 0x3E68BD0 Offset: 0x3E68CD1 VA: 0x3E68BD0
	|-List<HubLensFlare.Flare>.System.Collections.IList.Insert
	|
	|-RVA: 0x3E6BC20 Offset: 0x3E6BD21 VA: 0x3E6BC20
	|-List<InventoryPoolItemMenuContent.KindBgNameClass>.System.Collections.IList.Insert
	|
	|-RVA: 0x3E6EA70 Offset: 0x3E6EB71 VA: 0x3E6EA70
	|-List<Map.Pos>.System.Collections.IList.Insert
	|
	|-RVA: 0x3E71920 Offset: 0x3E71A21 VA: 0x3E71920
	|-List<MapImage.BackupTerrain>.System.Collections.IList.Insert
	|
	|-RVA: 0x3E747D0 Offset: 0x3E748D1 VA: 0x3E747D0
	|-List<MapImageRange.Pos>.System.Collections.IList.Insert
	|
	|-RVA: 0x3E77920 Offset: 0x3E77A21 VA: 0x3E77920
	|-List<MapMind.Target>.System.Collections.IList.Insert
	|
	|-RVA: 0x3D87500 Offset: 0x3D87601 VA: 0x3D87500
	|-List<MapPanelDebug.Entity>.System.Collections.IList.Insert
	|
	|-RVA: 0x3D8A3E0 Offset: 0x3D8A4E1 VA: 0x3D8A3E0
	|-List<NexRanking.Data>.System.Collections.IList.Insert
	|
	|-RVA: 0x3D8D290 Offset: 0x3D8D391 VA: 0x3D8D290
	|-List<NexVersus.RatingData>.System.Collections.IList.Insert
	|
	|-RVA: 0x3D901A0 Offset: 0x3D902A1 VA: 0x3D901A0
	|-List<PackedPlayModeBuildLogs.RuntimeBuildLog>.System.Collections.IList.Insert
	|
	|-RVA: 0x3D93450 Offset: 0x3D93551 VA: 0x3D93450
	|-List<ParticleSystem.Particle>.System.Collections.IList.Insert
	|
	|-RVA: 0x3D963A0 Offset: 0x3D964A1 VA: 0x3D963A0
	|-List<RangeData.Offset>.System.Collections.IList.Insert
	|
	|-RVA: 0x3D994D0 Offset: 0x3D995D1 VA: 0x3D994D0
	|-List<RenderGraphDebugData.PassDebugData>.System.Collections.IList.Insert
	|
	|-RVA: 0x3D9C840 Offset: 0x3D9C941 VA: 0x3D9C840
	|-List<RenderGraphDebugData.ResourceDebugData>.System.Collections.IList.Insert
	|
	|-RVA: 0x3D9F870 Offset: 0x3D9F971 VA: 0x3D9F870
	|-List<RingCleaningUnitSelectMenu.GodParam>.System.Collections.IList.Insert
	|
	|-RVA: 0x3DA2AF0 Offset: 0x3DA2BF1 VA: 0x3DA2AF0
	|-List<ShadowUtility.Edge>.System.Collections.IList.Insert
	|
	|-RVA: 0x3D14F10 Offset: 0x3D15011 VA: 0x3D14F10
	|-List<SkillArray.Entity>.System.Collections.IList.Insert
	|
	|-RVA: 0x3D182E0 Offset: 0x3D183E1 VA: 0x3D182E0
	|-List<TexturePacker_JsonArray.Frame>.System.Collections.IList.Insert
	|
	|-RVA: 0x3D1B610 Offset: 0x3D1B711 VA: 0x3D1B610
	|-List<TimeNotificationBehaviour.NotificationEntry>.System.Collections.IList.Insert
	|
	|-RVA: 0x3D1E830 Offset: 0x3D1E931 VA: 0x3D1E830
	|-List<UnitySynchronizationContext.WorkRequest>.System.Collections.IList.Insert
	|
	|-RVA: 0x3D217F0 Offset: 0x3D218F1 VA: 0x3D217F0
	|-List<XmlSchemaObjectTable.XmlSchemaObjectEntry>.System.Collections.IList.Insert
	|
	|-RVA: 0x3D24710 Offset: 0x3D24811 VA: 0x3D24710
	|-List<AssetBundleBuildMap.AssetBundleEntry.AssetPathString>.System.Collections.IList.Insert
	|
	|-RVA: 0x3D279F0 Offset: 0x3D27AF1 VA: 0x3D279F0
	|-List<Detail.DataStore.DataStoreChangeMetaParamInt>.System.Collections.IList.Insert
	|
	|-RVA: 0x3D2AA20 Offset: 0x3D2AB21 VA: 0x3D2AA20
	|-List<Detail.DataStore.DataStoreDeleteParamInt>.System.Collections.IList.Insert
	|
	|-RVA: 0x3D2DCB0 Offset: 0x3D2DDB1 VA: 0x3D2DCB0
	|-List<Detail.DataStore.DataStoreGetMetaParamInt>.System.Collections.IList.Insert
	|
	|-RVA: 0x3D31090 Offset: 0x3D31191 VA: 0x3D31090
	|-List<Detail.DataStore.DataStoreMetaInfoInt>.System.Collections.IList.Insert
	|
	|-RVA: 0x3CF5740 Offset: 0x3CF5841 VA: 0x3CF5740
	|-List<Detail.DataStore.DataStorePasswordInfoInt>.System.Collections.IList.Insert
	|
	|-RVA: 0x3CF8920 Offset: 0x3CF8A21 VA: 0x3CF8920
	|-List<Detail.DataStore.DataStorePersistenceInfoInt>.System.Collections.IList.Insert
	|
	|-RVA: 0x3CFBC60 Offset: 0x3CFBD61 VA: 0x3CFBC60
	|-List<Detail.DataStore.DataStorePreparePostParamInt>.System.Collections.IList.Insert
	|
	|-RVA: 0x3CFEC50 Offset: 0x3CFED51 VA: 0x3CFEC50
	|-List<Detail.DataStore.DataStoreRateObjectParamInt>.System.Collections.IList.Insert
	|
	|-RVA: 0x3D01D90 Offset: 0x3D01E91 VA: 0x3D01D90
	|-List<Detail.DataStore.DataStoreRatingInitParamInt>.System.Collections.IList.Insert
	|
	|-RVA: 0x3D04D20 Offset: 0x3D04E21 VA: 0x3D04D20
	|-List<Detail.DataStore.DataStoreRatingTargetInt>.System.Collections.IList.Insert
	|
	|-RVA: 0x3D08150 Offset: 0x3D08251 VA: 0x3D08150
	|-List<Detail.Ranking.RankingCachedResultInt>.System.Collections.IList.Insert
	|
	|-RVA: 0x3D0B1E0 Offset: 0x3D0B2E1 VA: 0x3D0B1E0
	|-List<Detail.Ranking.RankingOrderParamInt>.System.Collections.IList.Insert
	|
	|-RVA: 0x3D0E5C0 Offset: 0x3D0E6C1 VA: 0x3D0E5C0
	|-List<Detail.Ranking.RankingRankDataInt>.System.Collections.IList.Insert
	|
	|-RVA: 0x3D11E50 Offset: 0x3D11F51 VA: 0x3D11E50
	|-List<Detail.Ranking2.Ranking2ChartInfoInt>.System.Collections.IList.Insert
	|
	|-RVA: 0x3D68540 Offset: 0x3D68641 VA: 0x3D68540
	|-List<Detail.Ranking2.Ranking2RankDataInt>.System.Collections.IList.Insert
	|
	|-RVA: 0x3D6B5C0 Offset: 0x3D6B6C1 VA: 0x3D6B5C0
	|-List<Detail.Ranking2.Ranking2ScoreDataInt>.System.Collections.IList.Insert
	|
	|-RVA: 0x3D6E700 Offset: 0x3D6E801 VA: 0x3D6E700
	|-List<Detail.Screening.ScreeningContextInfoInt>.System.Collections.IList.Insert
	|
	|-RVA: 0x3D71D50 Offset: 0x3D71E51 VA: 0x3D71D50
	|-List<Detail.Subscriber.SubscriberContentInt>.System.Collections.IList.Insert
	|
	|-RVA: 0x3D750C0 Offset: 0x3D751C1 VA: 0x3D750C0
	|-List<Detail.Subscriber.SubscriberGetContentParamInt>.System.Collections.IList.Insert
	|
	|-RVA: 0x3D783F0 Offset: 0x3D784F1 VA: 0x3D783F0
	|-List<Detail.Subscriber.SubscriberUserStatusInfoInt>.System.Collections.IList.Insert
	|
	|-RVA: 0x3D7B640 Offset: 0x3D7B741 VA: 0x3D7B640
	|-List<Detail.Subscriber.SubscriberUserStatusParamInt>.System.Collections.IList.Insert
	|
	|-RVA: 0x3D7E520 Offset: 0x3D7E621 VA: 0x3D7E520
	|-List<Detail.Utility.IntegerSettings>.System.Collections.IList.Insert
	|
	|-RVA: 0x3D813D0 Offset: 0x3D814D1 VA: 0x3D813D0
	|-List<Detail.Utility.UniqueIdInfoInt>.System.Collections.IList.Insert
	|
	|-RVA: 0x3D84360 Offset: 0x3D84461 VA: 0x3D84360
	|-List<MapHistory.Rewind.LatestInspectorData>.System.Collections.IList.Insert
	|
	|-RVA: 0x3060620 Offset: 0x3060721 VA: 0x3060620
	|-List<MapHistory.Rewind.WorkTerrainData>.System.Collections.IList.Insert
	|
	|-RVA: 0x3063590 Offset: 0x3063691 VA: 0x3063590
	|-List<MapSkill.AroundCalculator.Result>.System.Collections.IList.Insert
	|
	|-RVA: 0x3066810 Offset: 0x3066911 VA: 0x3066810
	|-List<TargetPositionCache.CacheCurve.Item>.System.Collections.IList.Insert
	|
	|-RVA: 0x3069C10 Offset: 0x3069D11 VA: 0x3069C10
	|-List<TargetPositionCache.CacheEntry.RecordingItem>.System.Collections.IList.Insert
	*/

	// RVA: -1 Offset: -1
	public void InsertRange(int index, IEnumerable<T> collection) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3B0C5B0 Offset: 0x3B0C6B1 VA: 0x3B0C5B0
	|-List<IntervalTree.Entry<object>>.InsertRange
	|
	|-RVA: 0x3B0F560 Offset: 0x3B0F661 VA: 0x3B0F560
	|-List<KeyValuePair<DateTime, object>>.InsertRange
	|
	|-RVA: 0x3B12480 Offset: 0x3B12581 VA: 0x3B12480
	|-List<KeyValuePair<int, object>>.InsertRange
	|
	|-RVA: 0x3B15600 Offset: 0x3B15701 VA: 0x3B15600
	|-List<KeyValuePair<object, ValueTuple<int, DateTime, object>>>.InsertRange
	|
	|-RVA: 0x3B185C0 Offset: 0x3B186C1 VA: 0x3B185C0
	|-List<KeyValuePair<object, object>>.InsertRange
	|
	|-RVA: 0x3B1B740 Offset: 0x3B1B841 VA: 0x3B1B740
	|-List<CommonBattleSequence.Reliance<object>>.InsertRange
	|
	|-RVA: 0x3B1E6F0 Offset: 0x3B1E7F1 VA: 0x3B1E6F0
	|-List<RenderGraphResourcePool.ResourceLogInfo<object>>.InsertRange
	|
	|-RVA: 0x3B21610 Offset: 0x3B21711 VA: 0x3B21610
	|-List<ValueTuple<int, object>>.InsertRange
	|
	|-RVA: 0x3DE21D0 Offset: 0x3DE22D1 VA: 0x3DE21D0
	|-List<ValueTuple<Int32Enum, int>>.InsertRange
	|
	|-RVA: 0x3DE5310 Offset: 0x3DE5411 VA: 0x3DE5310
	|-List<ValueTuple<object, ValueTuple<object, int>>>.InsertRange
	|
	|-RVA: 0x3DE82C0 Offset: 0x3DE83C1 VA: 0x3DE82C0
	|-List<ValueTuple<object, int>>.InsertRange
	|
	|-RVA: 0x3DEB2D0 Offset: 0x3DEB3D1 VA: 0x3DEB2D0
	|-List<ValueTuple<Vector3, float>>.InsertRange
	|
	|-RVA: 0x3DEE1E0 Offset: 0x3DEE2E1 VA: 0x3DEE1E0
	|-List<ValueTuple<object, Int32Enum, int>>.InsertRange
	|
	|-RVA: 0x3DF1360 Offset: 0x3DF1461 VA: 0x3DF1360
	|-List<ValueTuple<object, int, int, int>>.InsertRange
	|
	|-RVA: 0x3DF4240 Offset: 0x3DF4341 VA: 0x3DF4240
	|-List<AnimatorClipInfo>.InsertRange
	|
	|-RVA: 0x3DF7380 Offset: 0x3DF7481 VA: 0x3DF7380
	|-List<AsyncOperationHandle>.InsertRange
	|
	|-RVA: 0x3DFA570 Offset: 0x3DFA671 VA: 0x3DFA570
	|-List<BoneWeight>.InsertRange
	|
	|-RVA: 0x3DFD480 Offset: 0x3DFD581 VA: 0x3DFD480
	|-List<bool>.InsertRange
	|
	|-RVA: 0x3E7A9C0 Offset: 0x3E7AAC1 VA: 0x3E7A9C0
	|-List<byte>.InsertRange
	|
	|-RVA: 0x3E7D890 Offset: 0x3E7D991 VA: 0x3E7D890
	|-List<CameraInfo>.InsertRange
	|
	|-RVA: 0x3E806E0 Offset: 0x3E807E1 VA: 0x3E806E0
	|-List<char>.InsertRange
	|
	|-RVA: 0x3E836A0 Offset: 0x3E837A1 VA: 0x3E836A0
	|-List<Color>.InsertRange
	|
	|-RVA: 0x3E864E0 Offset: 0x3E865E1 VA: 0x3E864E0
	|-List<Color32>.InsertRange
	|
	|-RVA: 0x3E893C0 Offset: 0x3E894C1 VA: 0x3E893C0
	|-List<ConstraintSource>.InsertRange
	|
	|-RVA: 0x3E8C540 Offset: 0x3E8C641 VA: 0x3E8C540
	|-List<ContourVertex>.InsertRange
	|
	|-RVA: 0x3E8F730 Offset: 0x3E8F831 VA: 0x3E8F730
	|-List<DataStoreRatingInfo>.InsertRange
	|
	|-RVA: 0x3E92600 Offset: 0x3E92701 VA: 0x3E92600
	|-List<DataStoreResult>.InsertRange
	|
	|-RVA: 0x3E95410 Offset: 0x3E95511 VA: 0x3E95410
	|-List<DateTime>.InsertRange
	|
	|-RVA: 0x3E982C0 Offset: 0x3E983C1 VA: 0x3E982C0
	|-List<DateTimeOffset>.InsertRange
	|
	|-RVA: 0x3E9B1A0 Offset: 0x3E9B2A1 VA: 0x3E9B1A0
	|-List<Decimal>.InsertRange
	|
	|-RVA: 0x3E9E4C0 Offset: 0x3E9E5C1 VA: 0x3E9E4C0
	|-List<DiagnosticEvent>.InsertRange
	|
	|-RVA: 0x3EA1440 Offset: 0x3EA1541 VA: 0x3EA1440
	|-List<double>.InsertRange
	|
	|-RVA: 0x3EA4690 Offset: 0x3EA4791 VA: 0x3EA4690
	|-List<Friend>.InsertRange
	|
	|-RVA: 0x3EA7670 Offset: 0x3EA7771 VA: 0x3EA7670
	|-List<GlyphRect>.InsertRange
	|
	|-RVA: 0x3EAA4B0 Offset: 0x3EAA5B1 VA: 0x3EAA4B0
	|-List<short>.InsertRange
	|
	|-RVA: 0x3EAD2B0 Offset: 0x3EAD3B1 VA: 0x3EAD2B0
	|-List<int>.InsertRange
	|
	|-RVA: 0x3EB00B0 Offset: 0x3EB01B1 VA: 0x3EB00B0
	|-List<Int32Enum>.InsertRange
	|
	|-RVA: 0x3EB2EB0 Offset: 0x3EB2FB1 VA: 0x3EB2EB0
	|-List<long>.InsertRange
	|
	|-RVA: 0x3E00280 Offset: 0x3E00381 VA: 0x3E00280
	|-List<IntPtr>.InsertRange
	|
	|-RVA: 0x3E03150 Offset: 0x3E03251 VA: 0x3E03150
	|-List<InterpretedFrameInfo>.InsertRange
	|
	|-RVA: 0x3E062B0 Offset: 0x3E063B1 VA: 0x3E062B0
	|-List<IntervalTreeNode>.InsertRange
	|
	|-RVA: 0x3E09180 Offset: 0x3E09281 VA: 0x3E09180
	|-List<LengthLimitProperties>.InsertRange
	|
	|-RVA: 0x3E0BF90 Offset: 0x3E0C091 VA: 0x3E0BF90
	|-List<MapPos>.InsertRange
	|
	|-RVA: 0x3E0F360 Offset: 0x3E0F461 VA: 0x3E0F360
	|-List<Matrix4x4>.InsertRange
	|
	|-RVA: 0x3E122D0 Offset: 0x3E123D1 VA: 0x3E122D0
	|-List<object>.InsertRange
	|-List<RegexNode>.InsertRange
	|
	|-RVA: 0x3E155C0 Offset: 0x3E156C1 VA: 0x3E155C0
	|-List<ObjectInitializationData>.InsertRange
	|
	|-RVA: 0x3E18850 Offset: 0x3E18951 VA: 0x3E18850
	|-List<PlayableBinding>.InsertRange
	|
	|-RVA: 0x3E1BBD0 Offset: 0x3E1BCD1 VA: 0x3E1BBD0
	|-List<PlayerLoopSystem>.InsertRange
	|
	|-RVA: 0x3DA6070 Offset: 0x3DA6171 VA: 0x3DA6070
	|-List<PlayerLoopSystemInternal>.InsertRange
	|
	|-RVA: 0x3DA9080 Offset: 0x3DA9181 VA: 0x3DA9080
	|-List<RangePositionInfo>.InsertRange
	|
	|-RVA: 0x3DABED0 Offset: 0x3DABFD1 VA: 0x3DABED0
	|-List<Ranking2ChartInfoInput>.InsertRange
	|
	|-RVA: 0x3DAF1B0 Offset: 0x3DAF2B1 VA: 0x3DAF1B0
	|-List<RaycastHit2D>.InsertRange
	|
	|-RVA: 0x3DB28B0 Offset: 0x3DB29B1 VA: 0x3DB28B0
	|-List<RaycastResult>.InsertRange
	|
	|-RVA: 0x3DB5AD0 Offset: 0x3DB5BD1 VA: 0x3DB5AD0
	|-List<Rect>.InsertRange
	|
	|-RVA: 0x3DB8910 Offset: 0x3DB8A11 VA: 0x3DB8910
	|-List<RendererListHandle>.InsertRange
	|
	|-RVA: 0x3DBB720 Offset: 0x3DBB821 VA: 0x3DBB720
	|-List<ResourceHandle>.InsertRange
	|
	|-RVA: 0x3DBE540 Offset: 0x3DBE641 VA: 0x3DBE540
	|-List<sbyte>.InsertRange
	|
	|-RVA: 0x3DC1340 Offset: 0x3DC1441 VA: 0x3DC1340
	|-List<ShaderTagId>.InsertRange
	|
	|-RVA: 0x3E3CFC0 Offset: 0x3E3D0C1 VA: 0x3E3CFC0
	|-List<float>.InsertRange
	|
	|-RVA: 0x3E40940 Offset: 0x3E40A41 VA: 0x3E40940
	|-List<SphericalHarmonicsL2>.InsertRange
	|
	|-RVA: 0x3E43F50 Offset: 0x3E44051 VA: 0x3E43F50
	|-List<SubMeshDescriptor>.InsertRange
	|
	|-RVA: 0x3E46F60 Offset: 0x3E47061 VA: 0x3E46F60
	|-List<TablePair>.InsertRange
	|
	|-RVA: 0x3E49DB0 Offset: 0x3E49EB1 VA: 0x3E49DB0
	|-List<TimeSpan>.InsertRange
	|
	|-RVA: 0x3E4CD50 Offset: 0x3E4CE51 VA: 0x3E4CD50
	|-List<UICharInfo>.InsertRange
	|
	|-RVA: 0x3E4FC40 Offset: 0x3E4FD41 VA: 0x3E4FC40
	|-List<UILineInfo>.InsertRange
	|
	|-RVA: 0x3E53600 Offset: 0x3E53701 VA: 0x3E53600
	|-List<UIVertex>.InsertRange
	|
	|-RVA: 0x3E56760 Offset: 0x3E56861 VA: 0x3E56760
	|-List<ushort>.InsertRange
	|
	|-RVA: 0x3E59560 Offset: 0x3E59661 VA: 0x3E59560
	|-List<uint>.InsertRange
	|
	|-RVA: 0x3DC4150 Offset: 0x3DC4251 VA: 0x3DC4150
	|-List<ulong>.InsertRange
	|
	|-RVA: 0x3DC6FF0 Offset: 0x3DC70F1 VA: 0x3DC6FF0
	|-List<Vector2>.InsertRange
	|
	|-RVA: 0x3DC9FB0 Offset: 0x3DCA0B1 VA: 0x3DC9FB0
	|-List<Vector3>.InsertRange
	|
	|-RVA: 0x3DCCFC0 Offset: 0x3DCD0C1 VA: 0x3DCCFC0
	|-List<Vector4>.InsertRange
	|
	|-RVA: 0x3DCFEA0 Offset: 0x3DCFFA1 VA: 0x3DCFEA0
	|-List<VertexAttributeDescriptor>.InsertRange
	|
	|-RVA: 0x3DD2DB0 Offset: 0x3DD2EB1 VA: 0x3DD2DB0
	|-List<X509ChainStatus>.InsertRange
	|
	|-RVA: 0x3DD6090 Offset: 0x3DD6191 VA: 0x3DD6090
	|-List<XRView>.InsertRange
	|
	|-RVA: 0x3DD90C0 Offset: 0x3DD91C1 VA: 0x3DD90C0
	|-List<AmiiboSequence.GainItemData>.InsertRange
	|
	|-RVA: 0x3DDC380 Offset: 0x3DDC481 VA: 0x3DDC380
	|-List<AnimationOutputWeightProcessor.WeightInfo>.InsertRange
	|
	|-RVA: 0x3DDF380 Offset: 0x3DDF481 VA: 0x3DDF380
	|-List<ArenaOrderSequence.GodInfo>.InsertRange
	|
	|-RVA: 0x3E1EBE0 Offset: 0x3E1ECE1 VA: 0x3E1EBE0
	|-List<BattleInfo.SupportData>.InsertRange
	|
	|-RVA: 0x3E21B00 Offset: 0x3E21C01 VA: 0x3E21B00
	|-List<BeforeRenderHelper.OrderBlock>.InsertRange
	|
	|-RVA: 0x3E24C90 Offset: 0x3E24D91 VA: 0x3E24C90
	|-List<Camera.RenderRequest>.InsertRange
	|
	|-RVA: 0x3E27C50 Offset: 0x3E27D51 VA: 0x3E27C50
	|-List<CameraState.CustomBlendable>.InsertRange
	|
	|-RVA: 0x3E2AAA0 Offset: 0x3E2ABA1 VA: 0x3E2AAA0
	|-List<CinemachineClearShot.Pair>.InsertRange
	|
	|-RVA: 0x3E2D8B0 Offset: 0x3E2D9B1 VA: 0x3E2D8B0
	|-List<CinemachineStateDrivenCamera.HashPair>.InsertRange
	|
	|-RVA: 0x3E309F0 Offset: 0x3E30AF1 VA: 0x3E309F0
	|-List<DelayedActionManager.DelegateInfo>.InsertRange
	|
	|-RVA: 0x3E33D90 Offset: 0x3E33E91 VA: 0x3E33D90
	|-List<Detail.AsyncResultInt>.InsertRange
	|
	|-RVA: 0x3E36D70 Offset: 0x3E36E71 VA: 0x3E36D70
	|-List<Detail.CppArray>.InsertRange
	|
	|-RVA: 0x3E3A060 Offset: 0x3E3A161 VA: 0x3E3A060
	|-List<Detail.NotificationEventInt>.InsertRange
	|
	|-RVA: 0x3E5C430 Offset: 0x3E5C531 VA: 0x3E5C430
	|-List<DragonRideTargetGroup.ChainParam>.InsertRange
	|
	|-RVA: 0x3E5F5B0 Offset: 0x3E5F6B1 VA: 0x3E5F5B0
	|-List<GmapPathAdjuster.TargetModel>.InsertRange
	|
	|-RVA: 0x3E627C0 Offset: 0x3E628C1 VA: 0x3E627C0
	|-List<GmapSpotAdjuster.TargetModel>.InsertRange
	|
	|-RVA: 0x3E659D0 Offset: 0x3E65AD1 VA: 0x3E659D0
	|-List<HubFastTravel.Location>.InsertRange
	|
	|-RVA: 0x3E68D90 Offset: 0x3E68E91 VA: 0x3E68D90
	|-List<HubLensFlare.Flare>.InsertRange
	|
	|-RVA: 0x3E6BDC0 Offset: 0x3E6BEC1 VA: 0x3E6BDC0
	|-List<InventoryPoolItemMenuContent.KindBgNameClass>.InsertRange
	|
	|-RVA: 0x3E6EC10 Offset: 0x3E6ED11 VA: 0x3E6EC10
	|-List<Map.Pos>.InsertRange
	|
	|-RVA: 0x3E71AC0 Offset: 0x3E71BC1 VA: 0x3E71AC0
	|-List<MapImage.BackupTerrain>.InsertRange
	|
	|-RVA: 0x3E74970 Offset: 0x3E74A71 VA: 0x3E74970
	|-List<MapImageRange.Pos>.InsertRange
	|
	|-RVA: 0x3E77AD0 Offset: 0x3E77BD1 VA: 0x3E77AD0
	|-List<MapMind.Target>.InsertRange
	|
	|-RVA: 0x3D876B0 Offset: 0x3D877B1 VA: 0x3D876B0
	|-List<MapPanelDebug.Entity>.InsertRange
	|
	|-RVA: 0x3D8A580 Offset: 0x3D8A681 VA: 0x3D8A580
	|-List<NexRanking.Data>.InsertRange
	|
	|-RVA: 0x3D8D430 Offset: 0x3D8D531 VA: 0x3D8D430
	|-List<NexVersus.RatingData>.InsertRange
	|
	|-RVA: 0x3D90340 Offset: 0x3D90441 VA: 0x3D90340
	|-List<PackedPlayModeBuildLogs.RuntimeBuildLog>.InsertRange
	|
	|-RVA: 0x3D93600 Offset: 0x3D93701 VA: 0x3D93600
	|-List<ParticleSystem.Particle>.InsertRange
	|
	|-RVA: 0x3D96540 Offset: 0x3D96641 VA: 0x3D96540
	|-List<RangeData.Offset>.InsertRange
	|
	|-RVA: 0x3D99680 Offset: 0x3D99781 VA: 0x3D99680
	|-List<RenderGraphDebugData.PassDebugData>.InsertRange
	|
	|-RVA: 0x3D9CA00 Offset: 0x3D9CB01 VA: 0x3D9CA00
	|-List<RenderGraphDebugData.ResourceDebugData>.InsertRange
	|
	|-RVA: 0x3D9FA10 Offset: 0x3D9FB11 VA: 0x3D9FA10
	|-List<RingCleaningUnitSelectMenu.GodParam>.InsertRange
	|
	|-RVA: 0x3DA2CB0 Offset: 0x3DA2DB1 VA: 0x3DA2CB0
	|-List<ShadowUtility.Edge>.InsertRange
	|
	|-RVA: 0x3D150B0 Offset: 0x3D151B1 VA: 0x3D150B0
	|-List<SkillArray.Entity>.InsertRange
	|
	|-RVA: 0x3D184A0 Offset: 0x3D185A1 VA: 0x3D184A0
	|-List<TexturePacker_JsonArray.Frame>.InsertRange
	|
	|-RVA: 0x3D1B7C0 Offset: 0x3D1B8C1 VA: 0x3D1B7C0
	|-List<TimeNotificationBehaviour.NotificationEntry>.InsertRange
	|
	|-RVA: 0x3D1E9E0 Offset: 0x3D1EAE1 VA: 0x3D1E9E0
	|-List<UnitySynchronizationContext.WorkRequest>.InsertRange
	|
	|-RVA: 0x3D21990 Offset: 0x3D21A91 VA: 0x3D21990
	|-List<XmlSchemaObjectTable.XmlSchemaObjectEntry>.InsertRange
	|
	|-RVA: 0x3D248B0 Offset: 0x3D249B1 VA: 0x3D248B0
	|-List<AssetBundleBuildMap.AssetBundleEntry.AssetPathString>.InsertRange
	|
	|-RVA: 0x3D27BB0 Offset: 0x3D27CB1 VA: 0x3D27BB0
	|-List<Detail.DataStore.DataStoreChangeMetaParamInt>.InsertRange
	|
	|-RVA: 0x3D2ABC0 Offset: 0x3D2ACC1 VA: 0x3D2ABC0
	|-List<Detail.DataStore.DataStoreDeleteParamInt>.InsertRange
	|
	|-RVA: 0x3D2DE70 Offset: 0x3D2DF71 VA: 0x3D2DE70
	|-List<Detail.DataStore.DataStoreGetMetaParamInt>.InsertRange
	|
	|-RVA: 0x3D31240 Offset: 0x3D31341 VA: 0x3D31240
	|-List<Detail.DataStore.DataStoreMetaInfoInt>.InsertRange
	|
	|-RVA: 0x3CF58F0 Offset: 0x3CF59F1 VA: 0x3CF58F0
	|-List<Detail.DataStore.DataStorePasswordInfoInt>.InsertRange
	|
	|-RVA: 0x3CF8AD0 Offset: 0x3CF8BD1 VA: 0x3CF8AD0
	|-List<Detail.DataStore.DataStorePersistenceInfoInt>.InsertRange
	|
	|-RVA: 0x3CFBE10 Offset: 0x3CFBF11 VA: 0x3CFBE10
	|-List<Detail.DataStore.DataStorePreparePostParamInt>.InsertRange
	|
	|-RVA: 0x3CFEDF0 Offset: 0x3CFEEF1 VA: 0x3CFEDF0
	|-List<Detail.DataStore.DataStoreRateObjectParamInt>.InsertRange
	|
	|-RVA: 0x3D01F40 Offset: 0x3D02041 VA: 0x3D01F40
	|-List<Detail.DataStore.DataStoreRatingInitParamInt>.InsertRange
	|
	|-RVA: 0x3D04EC0 Offset: 0x3D04FC1 VA: 0x3D04EC0
	|-List<Detail.DataStore.DataStoreRatingTargetInt>.InsertRange
	|
	|-RVA: 0x3D08310 Offset: 0x3D08411 VA: 0x3D08310
	|-List<Detail.Ranking.RankingCachedResultInt>.InsertRange
	|
	|-RVA: 0x3D0B380 Offset: 0x3D0B481 VA: 0x3D0B380
	|-List<Detail.Ranking.RankingOrderParamInt>.InsertRange
	|
	|-RVA: 0x3D0E780 Offset: 0x3D0E881 VA: 0x3D0E780
	|-List<Detail.Ranking.RankingRankDataInt>.InsertRange
	|
	|-RVA: 0x3D12020 Offset: 0x3D12121 VA: 0x3D12020
	|-List<Detail.Ranking2.Ranking2ChartInfoInt>.InsertRange
	|
	|-RVA: 0x3D68700 Offset: 0x3D68801 VA: 0x3D68700
	|-List<Detail.Ranking2.Ranking2RankDataInt>.InsertRange
	|
	|-RVA: 0x3D6B760 Offset: 0x3D6B861 VA: 0x3D6B760
	|-List<Detail.Ranking2.Ranking2ScoreDataInt>.InsertRange
	|
	|-RVA: 0x3D6E8B0 Offset: 0x3D6E9B1 VA: 0x3D6E8B0
	|-List<Detail.Screening.ScreeningContextInfoInt>.InsertRange
	|
	|-RVA: 0x3D71F20 Offset: 0x3D72021 VA: 0x3D71F20
	|-List<Detail.Subscriber.SubscriberContentInt>.InsertRange
	|
	|-RVA: 0x3D75270 Offset: 0x3D75371 VA: 0x3D75270
	|-List<Detail.Subscriber.SubscriberGetContentParamInt>.InsertRange
	|
	|-RVA: 0x3D785B0 Offset: 0x3D786B1 VA: 0x3D785B0
	|-List<Detail.Subscriber.SubscriberUserStatusInfoInt>.InsertRange
	|
	|-RVA: 0x3D7B7F0 Offset: 0x3D7B8F1 VA: 0x3D7B7F0
	|-List<Detail.Subscriber.SubscriberUserStatusParamInt>.InsertRange
	|
	|-RVA: 0x3D7E6C0 Offset: 0x3D7E7C1 VA: 0x3D7E6C0
	|-List<Detail.Utility.IntegerSettings>.InsertRange
	|
	|-RVA: 0x3D81570 Offset: 0x3D81671 VA: 0x3D81570
	|-List<Detail.Utility.UniqueIdInfoInt>.InsertRange
	|
	|-RVA: 0x3D84510 Offset: 0x3D84611 VA: 0x3D84510
	|-List<MapHistory.Rewind.LatestInspectorData>.InsertRange
	|
	|-RVA: 0x30607D0 Offset: 0x30608D1 VA: 0x30607D0
	|-List<MapHistory.Rewind.WorkTerrainData>.InsertRange
	|
	|-RVA: 0x3063730 Offset: 0x3063831 VA: 0x3063730
	|-List<MapSkill.AroundCalculator.Result>.InsertRange
	|
	|-RVA: 0x30669D0 Offset: 0x3066AD1 VA: 0x30669D0
	|-List<TargetPositionCache.CacheCurve.Item>.InsertRange
	|
	|-RVA: 0x3069DD0 Offset: 0x3069ED1 VA: 0x3069DD0
	|-List<TargetPositionCache.CacheEntry.RecordingItem>.InsertRange
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public bool Remove(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3B0CAB0 Offset: 0x3B0CBB1 VA: 0x3B0CAB0
	|-List<IntervalTree.Entry<object>>.Remove
	|
	|-RVA: 0x3B0FA40 Offset: 0x3B0FB41 VA: 0x3B0FA40
	|-List<KeyValuePair<DateTime, object>>.Remove
	|
	|-RVA: 0x3B12960 Offset: 0x3B12A61 VA: 0x3B12960
	|-List<KeyValuePair<int, object>>.Remove
	|
	|-RVA: 0x3B15B00 Offset: 0x3B15C01 VA: 0x3B15B00
	|-List<KeyValuePair<object, ValueTuple<int, DateTime, object>>>.Remove
	|
	|-RVA: 0x3B18AA0 Offset: 0x3B18BA1 VA: 0x3B18AA0
	|-List<KeyValuePair<object, object>>.Remove
	|
	|-RVA: 0x3B1BC40 Offset: 0x3B1BD41 VA: 0x3B1BC40
	|-List<CommonBattleSequence.Reliance<object>>.Remove
	|
	|-RVA: 0x3B1EBD0 Offset: 0x3B1ECD1 VA: 0x3B1EBD0
	|-List<RenderGraphResourcePool.ResourceLogInfo<object>>.Remove
	|
	|-RVA: 0x3B21AF0 Offset: 0x3B21BF1 VA: 0x3B21AF0
	|-List<ValueTuple<int, object>>.Remove
	|
	|-RVA: 0x3DE26B0 Offset: 0x3DE27B1 VA: 0x3DE26B0
	|-List<ValueTuple<Int32Enum, int>>.Remove
	|
	|-RVA: 0x3DE5810 Offset: 0x3DE5911 VA: 0x3DE5810
	|-List<ValueTuple<object, ValueTuple<object, int>>>.Remove
	|
	|-RVA: 0x3DE87A0 Offset: 0x3DE88A1 VA: 0x3DE87A0
	|-List<ValueTuple<object, int>>.Remove
	|
	|-RVA: 0x3DEB7A0 Offset: 0x3DEB8A1 VA: 0x3DEB7A0
	|-List<ValueTuple<Vector3, float>>.Remove
	|
	|-RVA: 0x3DEE6C0 Offset: 0x3DEE7C1 VA: 0x3DEE6C0
	|-List<ValueTuple<object, Int32Enum, int>>.Remove
	|
	|-RVA: 0x3DF1860 Offset: 0x3DF1961 VA: 0x3DF1860
	|-List<ValueTuple<object, int, int, int>>.Remove
	|
	|-RVA: 0x3E127A0 Offset: 0x3E128A1 VA: 0x3E127A0
	|-List<AkAmbient>.Remove
	|-List<AkAudioListener>.Remove
	|-List<AkEnvironment>.Remove
	|-List<AkEnvironmentPortal>.Remove
	|-List<AkGameObj>.Remove
	|-List<AkRoom>.Remove
	|-List<AkRoomAwareObject>.Remove
	|-List<AkRoomPortal>.Remove
	|-List<AkSpatialAudioListener>.Remove
	|-List<AkSurfaceReflector>.Remove
	|-List<AsyncDebugger>.Remove
	|-List<BaseRaycaster>.Remove
	|-List<BasicMenu>.Remove
	|-List<Camera>.Remove
	|-List<CharacterCollision>.Remove
	|-List<CinemachineBrain>.Remove
	|-List<CinemachineExtension>.Remove
	|-List<CinemachineVirtualCameraBase>.Remove
	|-List<Collider>.Remove
	|-List<CustomEnvSet>.Remove
	|-List<Decorator>.Remove
	|-List<DynValue>.Remove
	|-List<EventSystem>.Remove
	|-List<FileData>.Remove
	|-List<FoodstuffData>.Remove
	|-List<ForceProvider>.Remove
	|-List<GameObject>.Remove
	|-List<GodUnit>.Remove
	|-List<HelpItemList>.Remove
	|-List<HubAccess>.Remove
	|-List<HubAccessData>.Remove
	|-List<HubManualCulling>.Remove
	|-List<ICanvasElement>.Remove
	|-List<Image>.Remove
	|-List<InteractionTrigger>.Remove
	|-List<Light2D>.Remove
	|-List<LocalDataStore>.Remove
	|-List<MapBackup>.Remove
	|-List<Note>.Remove
	|-List<NotificationEventCB>.Remove
	|-List<object>.Remove
	|-List<Phase>.Remove
	|-List<ProfileCard>.Remove
	|-List<RenderGraph>.Remove
	|-List<ScriptableObject>.Remove
	|-List<ShadowCaster2D>.Remove
	|-List<ShadowCasterGroup2D>.Remove
	|-List<SourceRef>.Remove
	|-List<string>.Remove
	|-List<TMP_Text>.Remove
	|-List<Thread>.Remove
	|-List<TimelineClip>.Remove
	|-List<Toggle>.Remove
	|-List<Unit>.Remove
	|-List<UnitActor>.Remove
	|-List<UnitItem>.Remove
	|-List<UnityWebRequestAsyncOperation>.Remove
	|-List<VersusServerReplayMetaData>.Remove
	|-List<Volume>.Remove
	|-List<WindActor>.Remove
	|-List<AkBankManager.BankHandle>.Remove
	|-List<AssetTable.Accessory>.Remove
	|-List<DebugUI.Panel>.Remove
	|-List<EventSequence.Coroutine>.Remove
	|-List<GameSaveDataHeaderReader.Handle>.Remove
	|-List<MapDispos.ActualData>.Remove
	|-List<MapDispos.Pos>.Remove
	|-List<MapLayer.Data>.Remove
	|-List<MapObject.RigidInfo>.Remove
	|-List<MapTerrain.OverlapData>.Remove
	|-List<PlayerEditorConnectionEvents.MessageTypeSubscribers>.Remove
	|-List<ProfileCard.FreeStamp>.Remove
	|-List<RingListSequence.PageData>.Remove
	|-List<RingListSequence.RingPageData>.Remove
	|-List<SoundSystem.SoundHandle>.Remove
	|-List<TimeZoneInfo.AdjustmentRule>.Remove
	|
	|-RVA: 0x3DF4720 Offset: 0x3DF4821 VA: 0x3DF4720
	|-List<AnimatorClipInfo>.Remove
	|
	|-RVA: 0x3DF7880 Offset: 0x3DF7981 VA: 0x3DF7880
	|-List<AsyncOperationHandle>.Remove
	|
	|-RVA: 0x3DFAA70 Offset: 0x3DFAB71 VA: 0x3DFAA70
	|-List<BoneWeight>.Remove
	|
	|-RVA: 0x3DFD950 Offset: 0x3DFDA51 VA: 0x3DFD950
	|-List<bool>.Remove
	|
	|-RVA: 0x3E7AE90 Offset: 0x3E7AF91 VA: 0x3E7AE90
	|-List<byte>.Remove
	|
	|-RVA: 0x3E7DD70 Offset: 0x3E7DE71 VA: 0x3E7DD70
	|-List<CameraInfo>.Remove
	|
	|-RVA: 0x3E80BB0 Offset: 0x3E80CB1 VA: 0x3E80BB0
	|-List<char>.Remove
	|
	|-RVA: 0x3E83B70 Offset: 0x3E83C71 VA: 0x3E83B70
	|-List<Color>.Remove
	|
	|-RVA: 0x3E869C0 Offset: 0x3E86AC1 VA: 0x3E869C0
	|-List<Color32>.Remove
	|
	|-RVA: 0x3E898A0 Offset: 0x3E899A1 VA: 0x3E898A0
	|-List<ConstraintSource>.Remove
	|
	|-RVA: 0x3E8CA40 Offset: 0x3E8CB41 VA: 0x3E8CA40
	|-List<ContourVertex>.Remove
	|
	|-RVA: 0x3E8FC30 Offset: 0x3E8FD31 VA: 0x3E8FC30
	|-List<DataStoreRatingInfo>.Remove
	|
	|-RVA: 0x3E92AE0 Offset: 0x3E92BE1 VA: 0x3E92AE0
	|-List<DataStoreResult>.Remove
	|
	|-RVA: 0x3E958F0 Offset: 0x3E959F1 VA: 0x3E958F0
	|-List<DateTime>.Remove
	|
	|-RVA: 0x3E987A0 Offset: 0x3E988A1 VA: 0x3E987A0
	|-List<DateTimeOffset>.Remove
	|
	|-RVA: 0x3E9B680 Offset: 0x3E9B781 VA: 0x3E9B680
	|-List<Decimal>.Remove
	|
	|-RVA: 0x3E9E9D0 Offset: 0x3E9EAD1 VA: 0x3E9E9D0
	|-List<DiagnosticEvent>.Remove
	|
	|-RVA: 0x3EA1910 Offset: 0x3EA1A11 VA: 0x3EA1910
	|-List<double>.Remove
	|
	|-RVA: 0x3EA4BB0 Offset: 0x3EA4CB1 VA: 0x3EA4BB0
	|-List<Friend>.Remove
	|
	|-RVA: 0x3EA7B50 Offset: 0x3EA7C51 VA: 0x3EA7B50
	|-List<GlyphRect>.Remove
	|
	|-RVA: 0x3EAA980 Offset: 0x3EAAA81 VA: 0x3EAA980
	|-List<short>.Remove
	|
	|-RVA: 0x3EAD780 Offset: 0x3EAD881 VA: 0x3EAD780
	|-List<int>.Remove
	|
	|-RVA: 0x3EB0580 Offset: 0x3EB0681 VA: 0x3EB0580
	|-List<Int32Enum>.Remove
	|-List<ParticleSystemVertexStream>.Remove
	|-List<CapabilityDefinition.Type>.Remove
	|-List<ItemData.Kinds>.Remove
	|
	|-RVA: 0x3EB3380 Offset: 0x3EB3481 VA: 0x3EB3380
	|-List<long>.Remove
	|
	|-RVA: 0x3E00750 Offset: 0x3E00851 VA: 0x3E00750
	|-List<IntPtr>.Remove
	|
	|-RVA: 0x3E03630 Offset: 0x3E03731 VA: 0x3E03630
	|-List<InterpretedFrameInfo>.Remove
	|
	|-RVA: 0x3E067B0 Offset: 0x3E068B1 VA: 0x3E067B0
	|-List<IntervalTreeNode>.Remove
	|
	|-RVA: 0x3E09660 Offset: 0x3E09761 VA: 0x3E09660
	|-List<LengthLimitProperties>.Remove
	|
	|-RVA: 0x3E0C470 Offset: 0x3E0C571 VA: 0x3E0C470
	|-List<MapPos>.Remove
	|
	|-RVA: 0x3E0F890 Offset: 0x3E0F991 VA: 0x3E0F890
	|-List<Matrix4x4>.Remove
	|
	|-RVA: 0x3E15AD0 Offset: 0x3E15BD1 VA: 0x3E15AD0
	|-List<ObjectInitializationData>.Remove
	|
	|-RVA: 0x3E18D50 Offset: 0x3E18E51 VA: 0x3E18D50
	|-List<PlayableBinding>.Remove
	|
	|-RVA: 0x3E1C0E0 Offset: 0x3E1C1E1 VA: 0x3E1C0E0
	|-List<PlayerLoopSystem>.Remove
	|
	|-RVA: 0x3DA6580 Offset: 0x3DA6681 VA: 0x3DA6580
	|-List<PlayerLoopSystemInternal>.Remove
	|
	|-RVA: 0x3DA9560 Offset: 0x3DA9661 VA: 0x3DA9560
	|-List<RangePositionInfo>.Remove
	|
	|-RVA: 0x3DAC3B0 Offset: 0x3DAC4B1 VA: 0x3DAC3B0
	|-List<Ranking2ChartInfoInput>.Remove
	|
	|-RVA: 0x3DAF6C0 Offset: 0x3DAF7C1 VA: 0x3DAF6C0
	|-List<RaycastHit2D>.Remove
	|
	|-RVA: 0x3DB2DF0 Offset: 0x3DB2EF1 VA: 0x3DB2DF0
	|-List<RaycastResult>.Remove
	|
	|-RVA: 0x3DB5FA0 Offset: 0x3DB60A1 VA: 0x3DB5FA0
	|-List<Rect>.Remove
	|
	|-RVA: 0x3DB8DF0 Offset: 0x3DB8EF1 VA: 0x3DB8DF0
	|-List<RendererListHandle>.Remove
	|
	|-RVA: 0x3DBBC00 Offset: 0x3DBBD01 VA: 0x3DBBC00
	|-List<ResourceHandle>.Remove
	|
	|-RVA: 0x3DBEA10 Offset: 0x3DBEB11 VA: 0x3DBEA10
	|-List<sbyte>.Remove
	|
	|-RVA: 0x3DC1820 Offset: 0x3DC1921 VA: 0x3DC1820
	|-List<ShaderTagId>.Remove
	|
	|-RVA: 0x3E3D490 Offset: 0x3E3D591 VA: 0x3E3D490
	|-List<float>.Remove
	|
	|-RVA: 0x3E40EC0 Offset: 0x3E40FC1 VA: 0x3E40EC0
	|-List<SphericalHarmonicsL2>.Remove
	|
	|-RVA: 0x3E44460 Offset: 0x3E44561 VA: 0x3E44460
	|-List<SubMeshDescriptor>.Remove
	|
	|-RVA: 0x3E47440 Offset: 0x3E47541 VA: 0x3E47440
	|-List<TablePair>.Remove
	|
	|-RVA: 0x3E4A290 Offset: 0x3E4A391 VA: 0x3E4A290
	|-List<TimeSpan>.Remove
	|
	|-RVA: 0x3E4D220 Offset: 0x3E4D321 VA: 0x3E4D220
	|-List<UICharInfo>.Remove
	|
	|-RVA: 0x3E50120 Offset: 0x3E50221 VA: 0x3E50120
	|-List<UILineInfo>.Remove
	|
	|-RVA: 0x3E53B80 Offset: 0x3E53C81 VA: 0x3E53B80
	|-List<UIVertex>.Remove
	|
	|-RVA: 0x3E56C30 Offset: 0x3E56D31 VA: 0x3E56C30
	|-List<ushort>.Remove
	|
	|-RVA: 0x3E59A30 Offset: 0x3E59B31 VA: 0x3E59A30
	|-List<uint>.Remove
	|
	|-RVA: 0x3DC4620 Offset: 0x3DC4721 VA: 0x3DC4620
	|-List<ulong>.Remove
	|
	|-RVA: 0x3DC74C0 Offset: 0x3DC75C1 VA: 0x3DC74C0
	|-List<Vector2>.Remove
	|
	|-RVA: 0x3DCA480 Offset: 0x3DCA581 VA: 0x3DCA480
	|-List<Vector3>.Remove
	|
	|-RVA: 0x3DCD490 Offset: 0x3DCD591 VA: 0x3DCD490
	|-List<Vector4>.Remove
	|
	|-RVA: 0x3DD0380 Offset: 0x3DD0481 VA: 0x3DD0380
	|-List<VertexAttributeDescriptor>.Remove
	|
	|-RVA: 0x3DD3290 Offset: 0x3DD3391 VA: 0x3DD3290
	|-List<X509ChainStatus>.Remove
	|
	|-RVA: 0x3DD65B0 Offset: 0x3DD66B1 VA: 0x3DD65B0
	|-List<XRView>.Remove
	|
	|-RVA: 0x3DD95A0 Offset: 0x3DD96A1 VA: 0x3DD95A0
	|-List<AmiiboSequence.GainItemData>.Remove
	|
	|-RVA: 0x3DDC890 Offset: 0x3DDC991 VA: 0x3DDC890
	|-List<AnimationOutputWeightProcessor.WeightInfo>.Remove
	|
	|-RVA: 0x3DDF860 Offset: 0x3DDF961 VA: 0x3DDF860
	|-List<ArenaOrderSequence.GodInfo>.Remove
	|
	|-RVA: 0x3E1F0C0 Offset: 0x3E1F1C1 VA: 0x3E1F0C0
	|-List<BattleInfo.SupportData>.Remove
	|
	|-RVA: 0x3E21FE0 Offset: 0x3E220E1 VA: 0x3E21FE0
	|-List<BeforeRenderHelper.OrderBlock>.Remove
	|
	|-RVA: 0x3E25190 Offset: 0x3E25291 VA: 0x3E25190
	|-List<Camera.RenderRequest>.Remove
	|
	|-RVA: 0x3E28130 Offset: 0x3E28231 VA: 0x3E28130
	|-List<CameraState.CustomBlendable>.Remove
	|
	|-RVA: 0x3E2AF80 Offset: 0x3E2B081 VA: 0x3E2AF80
	|-List<CinemachineClearShot.Pair>.Remove
	|
	|-RVA: 0x3E2DD90 Offset: 0x3E2DE91 VA: 0x3E2DD90
	|-List<CinemachineStateDrivenCamera.HashPair>.Remove
	|
	|-RVA: 0x3E30EF0 Offset: 0x3E30FF1 VA: 0x3E30EF0
	|-List<DelayedActionManager.DelegateInfo>.Remove
	|
	|-RVA: 0x3E342A0 Offset: 0x3E343A1 VA: 0x3E342A0
	|-List<Detail.AsyncResultInt>.Remove
	|
	|-RVA: 0x3E37250 Offset: 0x3E37351 VA: 0x3E37250
	|-List<Detail.CppArray>.Remove
	|
	|-RVA: 0x3E3A570 Offset: 0x3E3A671 VA: 0x3E3A570
	|-List<Detail.NotificationEventInt>.Remove
	|
	|-RVA: 0x3E5C910 Offset: 0x3E5CA11 VA: 0x3E5C910
	|-List<DragonRideTargetGroup.ChainParam>.Remove
	|
	|-RVA: 0x3E5FAB0 Offset: 0x3E5FBB1 VA: 0x3E5FAB0
	|-List<GmapPathAdjuster.TargetModel>.Remove
	|
	|-RVA: 0x3E62CC0 Offset: 0x3E62DC1 VA: 0x3E62CC0
	|-List<GmapSpotAdjuster.TargetModel>.Remove
	|
	|-RVA: 0x3E65ED0 Offset: 0x3E65FD1 VA: 0x3E65ED0
	|-List<HubFastTravel.Location>.Remove
	|
	|-RVA: 0x3E692A0 Offset: 0x3E693A1 VA: 0x3E692A0
	|-List<HubLensFlare.Flare>.Remove
	|
	|-RVA: 0x3E6C2A0 Offset: 0x3E6C3A1 VA: 0x3E6C2A0
	|-List<InventoryPoolItemMenuContent.KindBgNameClass>.Remove
	|
	|-RVA: 0x3E6F0F0 Offset: 0x3E6F1F1 VA: 0x3E6F0F0
	|-List<Map.Pos>.Remove
	|
	|-RVA: 0x3E71FA0 Offset: 0x3E720A1 VA: 0x3E71FA0
	|-List<MapImage.BackupTerrain>.Remove
	|
	|-RVA: 0x3E74E50 Offset: 0x3E74F51 VA: 0x3E74E50
	|-List<MapImageRange.Pos>.Remove
	|
	|-RVA: 0x3E77FD0 Offset: 0x3E780D1 VA: 0x3E77FD0
	|-List<MapMind.Target>.Remove
	|
	|-RVA: 0x3D87BB0 Offset: 0x3D87CB1 VA: 0x3D87BB0
	|-List<MapPanelDebug.Entity>.Remove
	|
	|-RVA: 0x3D8AA60 Offset: 0x3D8AB61 VA: 0x3D8AA60
	|-List<NexRanking.Data>.Remove
	|
	|-RVA: 0x3D8D910 Offset: 0x3D8DA11 VA: 0x3D8D910
	|-List<NexVersus.RatingData>.Remove
	|
	|-RVA: 0x3D90820 Offset: 0x3D90921 VA: 0x3D90820
	|-List<PackedPlayModeBuildLogs.RuntimeBuildLog>.Remove
	|
	|-RVA: 0x3D93B20 Offset: 0x3D93C21 VA: 0x3D93B20
	|-List<ParticleSystem.Particle>.Remove
	|
	|-RVA: 0x3D96A20 Offset: 0x3D96B21 VA: 0x3D96A20
	|-List<RangeData.Offset>.Remove
	|
	|-RVA: 0x3D99B80 Offset: 0x3D99C81 VA: 0x3D99B80
	|-List<RenderGraphDebugData.PassDebugData>.Remove
	|
	|-RVA: 0x3D9CF10 Offset: 0x3D9D011 VA: 0x3D9CF10
	|-List<RenderGraphDebugData.ResourceDebugData>.Remove
	|
	|-RVA: 0x3D9FEF0 Offset: 0x3D9FFF1 VA: 0x3D9FEF0
	|-List<RingCleaningUnitSelectMenu.GodParam>.Remove
	|
	|-RVA: 0x3DA31C0 Offset: 0x3DA32C1 VA: 0x3DA31C0
	|-List<ShadowUtility.Edge>.Remove
	|
	|-RVA: 0x3D15590 Offset: 0x3D15691 VA: 0x3D15590
	|-List<SkillArray.Entity>.Remove
	|
	|-RVA: 0x3D189D0 Offset: 0x3D18AD1 VA: 0x3D189D0
	|-List<TexturePacker_JsonArray.Frame>.Remove
	|
	|-RVA: 0x3D1BCC0 Offset: 0x3D1BDC1 VA: 0x3D1BCC0
	|-List<TimeNotificationBehaviour.NotificationEntry>.Remove
	|
	|-RVA: 0x3D1EEE0 Offset: 0x3D1EFE1 VA: 0x3D1EEE0
	|-List<UnitySynchronizationContext.WorkRequest>.Remove
	|
	|-RVA: 0x3D21E70 Offset: 0x3D21F71 VA: 0x3D21E70
	|-List<XmlSchemaObjectTable.XmlSchemaObjectEntry>.Remove
	|
	|-RVA: 0x3D24D90 Offset: 0x3D24E91 VA: 0x3D24D90
	|-List<AssetBundleBuildMap.AssetBundleEntry.AssetPathString>.Remove
	|
	|-RVA: 0x3D280D0 Offset: 0x3D281D1 VA: 0x3D280D0
	|-List<Detail.DataStore.DataStoreChangeMetaParamInt>.Remove
	|
	|-RVA: 0x3D2B0A0 Offset: 0x3D2B1A1 VA: 0x3D2B0A0
	|-List<Detail.DataStore.DataStoreDeleteParamInt>.Remove
	|
	|-RVA: 0x3D2E380 Offset: 0x3D2E481 VA: 0x3D2E380
	|-List<Detail.DataStore.DataStoreGetMetaParamInt>.Remove
	|
	|-RVA: 0x3D31760 Offset: 0x3D31861 VA: 0x3D31760
	|-List<Detail.DataStore.DataStoreMetaInfoInt>.Remove
	|
	|-RVA: 0x3CF5DF0 Offset: 0x3CF5EF1 VA: 0x3CF5DF0
	|-List<Detail.DataStore.DataStorePasswordInfoInt>.Remove
	|
	|-RVA: 0x3CF8FD0 Offset: 0x3CF90D1 VA: 0x3CF8FD0
	|-List<Detail.DataStore.DataStorePersistenceInfoInt>.Remove
	|
	|-RVA: 0x3CFC330 Offset: 0x3CFC431 VA: 0x3CFC330
	|-List<Detail.DataStore.DataStorePreparePostParamInt>.Remove
	|
	|-RVA: 0x3CFF2D0 Offset: 0x3CFF3D1 VA: 0x3CFF2D0
	|-List<Detail.DataStore.DataStoreRateObjectParamInt>.Remove
	|
	|-RVA: 0x3D02440 Offset: 0x3D02541 VA: 0x3D02440
	|-List<Detail.DataStore.DataStoreRatingInitParamInt>.Remove
	|
	|-RVA: 0x3D053A0 Offset: 0x3D054A1 VA: 0x3D053A0
	|-List<Detail.DataStore.DataStoreRatingTargetInt>.Remove
	|
	|-RVA: 0x3D08840 Offset: 0x3D08941 VA: 0x3D08840
	|-List<Detail.Ranking.RankingCachedResultInt>.Remove
	|
	|-RVA: 0x3D0B860 Offset: 0x3D0B961 VA: 0x3D0B860
	|-List<Detail.Ranking.RankingOrderParamInt>.Remove
	|
	|-RVA: 0x3D0ECB0 Offset: 0x3D0EDB1 VA: 0x3D0ECB0
	|-List<Detail.Ranking.RankingRankDataInt>.Remove
	|
	|-RVA: 0x3D12570 Offset: 0x3D12671 VA: 0x3D12570
	|-List<Detail.Ranking2.Ranking2ChartInfoInt>.Remove
	|
	|-RVA: 0x3D68C30 Offset: 0x3D68D31 VA: 0x3D68C30
	|-List<Detail.Ranking2.Ranking2RankDataInt>.Remove
	|
	|-RVA: 0x3D6BC40 Offset: 0x3D6BD41 VA: 0x3D6BC40
	|-List<Detail.Ranking2.Ranking2ScoreDataInt>.Remove
	|
	|-RVA: 0x3D6EDB0 Offset: 0x3D6EEB1 VA: 0x3D6EDB0
	|-List<Detail.Screening.ScreeningContextInfoInt>.Remove
	|
	|-RVA: 0x3D72460 Offset: 0x3D72561 VA: 0x3D72460
	|-List<Detail.Subscriber.SubscriberContentInt>.Remove
	|
	|-RVA: 0x3D75770 Offset: 0x3D75871 VA: 0x3D75770
	|-List<Detail.Subscriber.SubscriberGetContentParamInt>.Remove
	|
	|-RVA: 0x3D78AC0 Offset: 0x3D78BC1 VA: 0x3D78AC0
	|-List<Detail.Subscriber.SubscriberUserStatusInfoInt>.Remove
	|
	|-RVA: 0x3D7BCF0 Offset: 0x3D7BDF1 VA: 0x3D7BCF0
	|-List<Detail.Subscriber.SubscriberUserStatusParamInt>.Remove
	|
	|-RVA: 0x3D7EBA0 Offset: 0x3D7ECA1 VA: 0x3D7EBA0
	|-List<Detail.Utility.IntegerSettings>.Remove
	|
	|-RVA: 0x3D81A50 Offset: 0x3D81B51 VA: 0x3D81A50
	|-List<Detail.Utility.UniqueIdInfoInt>.Remove
	|
	|-RVA: 0x3D849F0 Offset: 0x3D84AF1 VA: 0x3D849F0
	|-List<MapHistory.Rewind.LatestInspectorData>.Remove
	|
	|-RVA: 0x3060CB0 Offset: 0x3060DB1 VA: 0x3060CB0
	|-List<MapHistory.Rewind.WorkTerrainData>.Remove
	|
	|-RVA: 0x3063C10 Offset: 0x3063D11 VA: 0x3063C10
	|-List<MapSkill.AroundCalculator.Result>.Remove
	|
	|-RVA: 0x3066EE0 Offset: 0x3066FE1 VA: 0x3066EE0
	|-List<TargetPositionCache.CacheCurve.Item>.Remove
	|
	|-RVA: 0x306A2E0 Offset: 0x306A3E1 VA: 0x306A2E0
	|-List<TargetPositionCache.CacheEntry.RecordingItem>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 26
	private void System.Collections.IList.Remove(object item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3B0CB40 Offset: 0x3B0CC41 VA: 0x3B0CB40
	|-List<IntervalTree.Entry<object>>.System.Collections.IList.Remove
	|
	|-RVA: 0x3B0FAB0 Offset: 0x3B0FBB1 VA: 0x3B0FAB0
	|-List<KeyValuePair<DateTime, object>>.System.Collections.IList.Remove
	|
	|-RVA: 0x3B129D0 Offset: 0x3B12AD1 VA: 0x3B129D0
	|-List<KeyValuePair<int, object>>.System.Collections.IList.Remove
	|
	|-RVA: 0x3B15BA0 Offset: 0x3B15CA1 VA: 0x3B15BA0
	|-List<KeyValuePair<object, ValueTuple<int, DateTime, object>>>.System.Collections.IList.Remove
	|
	|-RVA: 0x3B18B10 Offset: 0x3B18C11 VA: 0x3B18B10
	|-List<KeyValuePair<object, object>>.System.Collections.IList.Remove
	|
	|-RVA: 0x3B1BCD0 Offset: 0x3B1BDD1 VA: 0x3B1BCD0
	|-List<CommonBattleSequence.Reliance<object>>.System.Collections.IList.Remove
	|
	|-RVA: 0x3B1EC40 Offset: 0x3B1ED41 VA: 0x3B1EC40
	|-List<RenderGraphResourcePool.ResourceLogInfo<object>>.System.Collections.IList.Remove
	|
	|-RVA: 0x3B21B60 Offset: 0x3B21C61 VA: 0x3B21B60
	|-List<ValueTuple<int, object>>.System.Collections.IList.Remove
	|
	|-RVA: 0x3DE2720 Offset: 0x3DE2821 VA: 0x3DE2720
	|-List<ValueTuple<Int32Enum, int>>.System.Collections.IList.Remove
	|
	|-RVA: 0x3DE58A0 Offset: 0x3DE59A1 VA: 0x3DE58A0
	|-List<ValueTuple<object, ValueTuple<object, int>>>.System.Collections.IList.Remove
	|
	|-RVA: 0x3DE8810 Offset: 0x3DE8911 VA: 0x3DE8810
	|-List<ValueTuple<object, int>>.System.Collections.IList.Remove
	|
	|-RVA: 0x3DEB810 Offset: 0x3DEB911 VA: 0x3DEB810
	|-List<ValueTuple<Vector3, float>>.System.Collections.IList.Remove
	|
	|-RVA: 0x3DEE730 Offset: 0x3DEE831 VA: 0x3DEE730
	|-List<ValueTuple<object, Int32Enum, int>>.System.Collections.IList.Remove
	|
	|-RVA: 0x3DF18F0 Offset: 0x3DF19F1 VA: 0x3DF18F0
	|-List<ValueTuple<object, int, int, int>>.System.Collections.IList.Remove
	|
	|-RVA: 0x3DF4790 Offset: 0x3DF4891 VA: 0x3DF4790
	|-List<AnimatorClipInfo>.System.Collections.IList.Remove
	|
	|-RVA: 0x3DF7910 Offset: 0x3DF7A11 VA: 0x3DF7910
	|-List<AsyncOperationHandle>.System.Collections.IList.Remove
	|
	|-RVA: 0x3DFAB10 Offset: 0x3DFAC11 VA: 0x3DFAB10
	|-List<BoneWeight>.System.Collections.IList.Remove
	|
	|-RVA: 0x3DFD9C0 Offset: 0x3DFDAC1 VA: 0x3DFD9C0
	|-List<bool>.System.Collections.IList.Remove
	|
	|-RVA: 0x3E7AF00 Offset: 0x3E7B001 VA: 0x3E7AF00
	|-List<byte>.System.Collections.IList.Remove
	|
	|-RVA: 0x3E12810 Offset: 0x3E12911 VA: 0x3E12810
	|-List<Camera>.System.Collections.IList.Remove
	|-List<Decorator>.System.Collections.IList.Remove
	|-List<DynValue>.System.Collections.IList.Remove
	|-List<GameObject>.System.Collections.IList.Remove
	|-List<MapBackup>.System.Collections.IList.Remove
	|-List<object>.System.Collections.IList.Remove
	|-List<Phase>.System.Collections.IList.Remove
	|-List<ProfileCard>.System.Collections.IList.Remove
	|-List<Unit>.System.Collections.IList.Remove
	|-List<AssetTable.Accessory>.System.Collections.IList.Remove
	|-List<GameSaveDataHeaderReader.Handle>.System.Collections.IList.Remove
	|-List<MapDispos.ActualData>.System.Collections.IList.Remove
	|-List<MapDispos.Pos>.System.Collections.IList.Remove
	|-List<MapLayer.Data>.System.Collections.IList.Remove
	|-List<MapObject.RigidInfo>.System.Collections.IList.Remove
	|-List<RingListSequence.PageData>.System.Collections.IList.Remove
	|
	|-RVA: 0x3E7DDE0 Offset: 0x3E7DEE1 VA: 0x3E7DDE0
	|-List<CameraInfo>.System.Collections.IList.Remove
	|
	|-RVA: 0x3E80C20 Offset: 0x3E80D21 VA: 0x3E80C20
	|-List<char>.System.Collections.IList.Remove
	|
	|-RVA: 0x3E83BE0 Offset: 0x3E83CE1 VA: 0x3E83BE0
	|-List<Color>.System.Collections.IList.Remove
	|
	|-RVA: 0x3E86A30 Offset: 0x3E86B31 VA: 0x3E86A30
	|-List<Color32>.System.Collections.IList.Remove
	|
	|-RVA: 0x3E89910 Offset: 0x3E89A11 VA: 0x3E89910
	|-List<ConstraintSource>.System.Collections.IList.Remove
	|
	|-RVA: 0x3E8CAD0 Offset: 0x3E8CBD1 VA: 0x3E8CAD0
	|-List<ContourVertex>.System.Collections.IList.Remove
	|
	|-RVA: 0x3E8FCC0 Offset: 0x3E8FDC1 VA: 0x3E8FCC0
	|-List<DataStoreRatingInfo>.System.Collections.IList.Remove
	|
	|-RVA: 0x3E92B50 Offset: 0x3E92C51 VA: 0x3E92B50
	|-List<DataStoreResult>.System.Collections.IList.Remove
	|
	|-RVA: 0x3E95960 Offset: 0x3E95A61 VA: 0x3E95960
	|-List<DateTime>.System.Collections.IList.Remove
	|
	|-RVA: 0x3E98810 Offset: 0x3E98911 VA: 0x3E98810
	|-List<DateTimeOffset>.System.Collections.IList.Remove
	|
	|-RVA: 0x3E9B6F0 Offset: 0x3E9B7F1 VA: 0x3E9B6F0
	|-List<Decimal>.System.Collections.IList.Remove
	|
	|-RVA: 0x3E9EA70 Offset: 0x3E9EB71 VA: 0x3E9EA70
	|-List<DiagnosticEvent>.System.Collections.IList.Remove
	|
	|-RVA: 0x3EA1980 Offset: 0x3EA1A81 VA: 0x3EA1980
	|-List<double>.System.Collections.IList.Remove
	|
	|-RVA: 0x3EA4C60 Offset: 0x3EA4D61 VA: 0x3EA4C60
	|-List<Friend>.System.Collections.IList.Remove
	|
	|-RVA: 0x3EA7BC0 Offset: 0x3EA7CC1 VA: 0x3EA7BC0
	|-List<GlyphRect>.System.Collections.IList.Remove
	|
	|-RVA: 0x3EAA9F0 Offset: 0x3EAAAF1 VA: 0x3EAA9F0
	|-List<short>.System.Collections.IList.Remove
	|
	|-RVA: 0x3EAD7F0 Offset: 0x3EAD8F1 VA: 0x3EAD7F0
	|-List<int>.System.Collections.IList.Remove
	|
	|-RVA: 0x3EB05F0 Offset: 0x3EB06F1 VA: 0x3EB05F0
	|-List<Int32Enum>.System.Collections.IList.Remove
	|
	|-RVA: 0x3EB33F0 Offset: 0x3EB34F1 VA: 0x3EB33F0
	|-List<long>.System.Collections.IList.Remove
	|
	|-RVA: 0x3E007C0 Offset: 0x3E008C1 VA: 0x3E007C0
	|-List<IntPtr>.System.Collections.IList.Remove
	|
	|-RVA: 0x3E036A0 Offset: 0x3E037A1 VA: 0x3E036A0
	|-List<InterpretedFrameInfo>.System.Collections.IList.Remove
	|
	|-RVA: 0x3E06840 Offset: 0x3E06941 VA: 0x3E06840
	|-List<IntervalTreeNode>.System.Collections.IList.Remove
	|
	|-RVA: 0x3E096D0 Offset: 0x3E097D1 VA: 0x3E096D0
	|-List<LengthLimitProperties>.System.Collections.IList.Remove
	|
	|-RVA: 0x3E0C4E0 Offset: 0x3E0C5E1 VA: 0x3E0C4E0
	|-List<MapPos>.System.Collections.IList.Remove
	|
	|-RVA: 0x3E0F950 Offset: 0x3E0FA51 VA: 0x3E0F950
	|-List<Matrix4x4>.System.Collections.IList.Remove
	|
	|-RVA: 0x3E15B70 Offset: 0x3E15C71 VA: 0x3E15B70
	|-List<ObjectInitializationData>.System.Collections.IList.Remove
	|
	|-RVA: 0x3E18DF0 Offset: 0x3E18EF1 VA: 0x3E18DF0
	|-List<PlayableBinding>.System.Collections.IList.Remove
	|
	|-RVA: 0x3E1C180 Offset: 0x3E1C281 VA: 0x3E1C180
	|-List<PlayerLoopSystem>.System.Collections.IList.Remove
	|
	|-RVA: 0x3DA6620 Offset: 0x3DA6721 VA: 0x3DA6620
	|-List<PlayerLoopSystemInternal>.System.Collections.IList.Remove
	|
	|-RVA: 0x3DA95D0 Offset: 0x3DA96D1 VA: 0x3DA95D0
	|-List<RangePositionInfo>.System.Collections.IList.Remove
	|
	|-RVA: 0x3DAC420 Offset: 0x3DAC521 VA: 0x3DAC420
	|-List<Ranking2ChartInfoInput>.System.Collections.IList.Remove
	|
	|-RVA: 0x3DAF760 Offset: 0x3DAF861 VA: 0x3DAF760
	|-List<RaycastHit2D>.System.Collections.IList.Remove
	|
	|-RVA: 0x3DB2ED0 Offset: 0x3DB2FD1 VA: 0x3DB2ED0
	|-List<RaycastResult>.System.Collections.IList.Remove
	|
	|-RVA: 0x3DB6010 Offset: 0x3DB6111 VA: 0x3DB6010
	|-List<Rect>.System.Collections.IList.Remove
	|
	|-RVA: 0x3DB8E60 Offset: 0x3DB8F61 VA: 0x3DB8E60
	|-List<RendererListHandle>.System.Collections.IList.Remove
	|
	|-RVA: 0x3DBBC70 Offset: 0x3DBBD71 VA: 0x3DBBC70
	|-List<ResourceHandle>.System.Collections.IList.Remove
	|
	|-RVA: 0x3DBEA80 Offset: 0x3DBEB81 VA: 0x3DBEA80
	|-List<sbyte>.System.Collections.IList.Remove
	|
	|-RVA: 0x3DC1890 Offset: 0x3DC1991 VA: 0x3DC1890
	|-List<ShaderTagId>.System.Collections.IList.Remove
	|
	|-RVA: 0x3E3D500 Offset: 0x3E3D601 VA: 0x3E3D500
	|-List<float>.System.Collections.IList.Remove
	|
	|-RVA: 0x3E40FC0 Offset: 0x3E410C1 VA: 0x3E40FC0
	|-List<SphericalHarmonicsL2>.System.Collections.IList.Remove
	|
	|-RVA: 0x3E44500 Offset: 0x3E44601 VA: 0x3E44500
	|-List<SubMeshDescriptor>.System.Collections.IList.Remove
	|
	|-RVA: 0x3E474B0 Offset: 0x3E475B1 VA: 0x3E474B0
	|-List<TablePair>.System.Collections.IList.Remove
	|
	|-RVA: 0x3E4A300 Offset: 0x3E4A401 VA: 0x3E4A300
	|-List<TimeSpan>.System.Collections.IList.Remove
	|
	|-RVA: 0x3E4D290 Offset: 0x3E4D391 VA: 0x3E4D290
	|-List<UICharInfo>.System.Collections.IList.Remove
	|
	|-RVA: 0x3E50190 Offset: 0x3E50291 VA: 0x3E50190
	|-List<UILineInfo>.System.Collections.IList.Remove
	|
	|-RVA: 0x3E53C80 Offset: 0x3E53D81 VA: 0x3E53C80
	|-List<UIVertex>.System.Collections.IList.Remove
	|
	|-RVA: 0x3E56CA0 Offset: 0x3E56DA1 VA: 0x3E56CA0
	|-List<ushort>.System.Collections.IList.Remove
	|
	|-RVA: 0x3E59AA0 Offset: 0x3E59BA1 VA: 0x3E59AA0
	|-List<uint>.System.Collections.IList.Remove
	|
	|-RVA: 0x3DC4690 Offset: 0x3DC4791 VA: 0x3DC4690
	|-List<ulong>.System.Collections.IList.Remove
	|
	|-RVA: 0x3DC7530 Offset: 0x3DC7631 VA: 0x3DC7530
	|-List<Vector2>.System.Collections.IList.Remove
	|
	|-RVA: 0x3DCA4F0 Offset: 0x3DCA5F1 VA: 0x3DCA4F0
	|-List<Vector3>.System.Collections.IList.Remove
	|
	|-RVA: 0x3DCD500 Offset: 0x3DCD601 VA: 0x3DCD500
	|-List<Vector4>.System.Collections.IList.Remove
	|
	|-RVA: 0x3DD03F0 Offset: 0x3DD04F1 VA: 0x3DD03F0
	|-List<VertexAttributeDescriptor>.System.Collections.IList.Remove
	|
	|-RVA: 0x3DD3300 Offset: 0x3DD3401 VA: 0x3DD3300
	|-List<X509ChainStatus>.System.Collections.IList.Remove
	|
	|-RVA: 0x3DD6660 Offset: 0x3DD6761 VA: 0x3DD6660
	|-List<XRView>.System.Collections.IList.Remove
	|
	|-RVA: 0x3DD9610 Offset: 0x3DD9711 VA: 0x3DD9610
	|-List<AmiiboSequence.GainItemData>.System.Collections.IList.Remove
	|
	|-RVA: 0x3DDC930 Offset: 0x3DDCA31 VA: 0x3DDC930
	|-List<AnimationOutputWeightProcessor.WeightInfo>.System.Collections.IList.Remove
	|
	|-RVA: 0x3DDF8D0 Offset: 0x3DDF9D1 VA: 0x3DDF8D0
	|-List<ArenaOrderSequence.GodInfo>.System.Collections.IList.Remove
	|
	|-RVA: 0x3E1F130 Offset: 0x3E1F231 VA: 0x3E1F130
	|-List<BattleInfo.SupportData>.System.Collections.IList.Remove
	|
	|-RVA: 0x3E22050 Offset: 0x3E22151 VA: 0x3E22050
	|-List<BeforeRenderHelper.OrderBlock>.System.Collections.IList.Remove
	|
	|-RVA: 0x3E25220 Offset: 0x3E25321 VA: 0x3E25220
	|-List<Camera.RenderRequest>.System.Collections.IList.Remove
	|
	|-RVA: 0x3E281A0 Offset: 0x3E282A1 VA: 0x3E281A0
	|-List<CameraState.CustomBlendable>.System.Collections.IList.Remove
	|
	|-RVA: 0x3E2AFF0 Offset: 0x3E2B0F1 VA: 0x3E2AFF0
	|-List<CinemachineClearShot.Pair>.System.Collections.IList.Remove
	|
	|-RVA: 0x3E2DE00 Offset: 0x3E2DF01 VA: 0x3E2DE00
	|-List<CinemachineStateDrivenCamera.HashPair>.System.Collections.IList.Remove
	|
	|-RVA: 0x3E30F90 Offset: 0x3E31091 VA: 0x3E30F90
	|-List<DelayedActionManager.DelegateInfo>.System.Collections.IList.Remove
	|
	|-RVA: 0x3E34340 Offset: 0x3E34441 VA: 0x3E34340
	|-List<Detail.AsyncResultInt>.System.Collections.IList.Remove
	|
	|-RVA: 0x3E372C0 Offset: 0x3E373C1 VA: 0x3E372C0
	|-List<Detail.CppArray>.System.Collections.IList.Remove
	|
	|-RVA: 0x3E3A610 Offset: 0x3E3A711 VA: 0x3E3A610
	|-List<Detail.NotificationEventInt>.System.Collections.IList.Remove
	|
	|-RVA: 0x3E5C980 Offset: 0x3E5CA81 VA: 0x3E5C980
	|-List<DragonRideTargetGroup.ChainParam>.System.Collections.IList.Remove
	|
	|-RVA: 0x3E5FB40 Offset: 0x3E5FC41 VA: 0x3E5FB40
	|-List<GmapPathAdjuster.TargetModel>.System.Collections.IList.Remove
	|
	|-RVA: 0x3E62D50 Offset: 0x3E62E51 VA: 0x3E62D50
	|-List<GmapSpotAdjuster.TargetModel>.System.Collections.IList.Remove
	|
	|-RVA: 0x3E65F60 Offset: 0x3E66061 VA: 0x3E65F60
	|-List<HubFastTravel.Location>.System.Collections.IList.Remove
	|
	|-RVA: 0x3E69340 Offset: 0x3E69441 VA: 0x3E69340
	|-List<HubLensFlare.Flare>.System.Collections.IList.Remove
	|
	|-RVA: 0x3E6C310 Offset: 0x3E6C411 VA: 0x3E6C310
	|-List<InventoryPoolItemMenuContent.KindBgNameClass>.System.Collections.IList.Remove
	|
	|-RVA: 0x3E6F160 Offset: 0x3E6F261 VA: 0x3E6F160
	|-List<Map.Pos>.System.Collections.IList.Remove
	|
	|-RVA: 0x3E72010 Offset: 0x3E72111 VA: 0x3E72010
	|-List<MapImage.BackupTerrain>.System.Collections.IList.Remove
	|
	|-RVA: 0x3E74EC0 Offset: 0x3E74FC1 VA: 0x3E74EC0
	|-List<MapImageRange.Pos>.System.Collections.IList.Remove
	|
	|-RVA: 0x3E78060 Offset: 0x3E78161 VA: 0x3E78060
	|-List<MapMind.Target>.System.Collections.IList.Remove
	|
	|-RVA: 0x3D87C40 Offset: 0x3D87D41 VA: 0x3D87C40
	|-List<MapPanelDebug.Entity>.System.Collections.IList.Remove
	|
	|-RVA: 0x3D8AAD0 Offset: 0x3D8ABD1 VA: 0x3D8AAD0
	|-List<NexRanking.Data>.System.Collections.IList.Remove
	|
	|-RVA: 0x3D8D980 Offset: 0x3D8DA81 VA: 0x3D8D980
	|-List<NexVersus.RatingData>.System.Collections.IList.Remove
	|
	|-RVA: 0x3D90890 Offset: 0x3D90991 VA: 0x3D90890
	|-List<PackedPlayModeBuildLogs.RuntimeBuildLog>.System.Collections.IList.Remove
	|
	|-RVA: 0x3D93BD0 Offset: 0x3D93CD1 VA: 0x3D93BD0
	|-List<ParticleSystem.Particle>.System.Collections.IList.Remove
	|
	|-RVA: 0x3D96A90 Offset: 0x3D96B91 VA: 0x3D96A90
	|-List<RangeData.Offset>.System.Collections.IList.Remove
	|
	|-RVA: 0x3D99C20 Offset: 0x3D99D21 VA: 0x3D99C20
	|-List<RenderGraphDebugData.PassDebugData>.System.Collections.IList.Remove
	|
	|-RVA: 0x3D9CFB0 Offset: 0x3D9D0B1 VA: 0x3D9CFB0
	|-List<RenderGraphDebugData.ResourceDebugData>.System.Collections.IList.Remove
	|
	|-RVA: 0x3D9FF60 Offset: 0x3DA0061 VA: 0x3D9FF60
	|-List<RingCleaningUnitSelectMenu.GodParam>.System.Collections.IList.Remove
	|
	|-RVA: 0x3DA3260 Offset: 0x3DA3361 VA: 0x3DA3260
	|-List<ShadowUtility.Edge>.System.Collections.IList.Remove
	|
	|-RVA: 0x3D15600 Offset: 0x3D15701 VA: 0x3D15600
	|-List<SkillArray.Entity>.System.Collections.IList.Remove
	|
	|-RVA: 0x3D18A90 Offset: 0x3D18B91 VA: 0x3D18A90
	|-List<TexturePacker_JsonArray.Frame>.System.Collections.IList.Remove
	|
	|-RVA: 0x3D1BD50 Offset: 0x3D1BE51 VA: 0x3D1BD50
	|-List<TimeNotificationBehaviour.NotificationEntry>.System.Collections.IList.Remove
	|
	|-RVA: 0x3D1EF70 Offset: 0x3D1F071 VA: 0x3D1EF70
	|-List<UnitySynchronizationContext.WorkRequest>.System.Collections.IList.Remove
	|
	|-RVA: 0x3D21EE0 Offset: 0x3D21FE1 VA: 0x3D21EE0
	|-List<XmlSchemaObjectTable.XmlSchemaObjectEntry>.System.Collections.IList.Remove
	|
	|-RVA: 0x3D24E00 Offset: 0x3D24F01 VA: 0x3D24E00
	|-List<AssetBundleBuildMap.AssetBundleEntry.AssetPathString>.System.Collections.IList.Remove
	|
	|-RVA: 0x3D28180 Offset: 0x3D28281 VA: 0x3D28180
	|-List<Detail.DataStore.DataStoreChangeMetaParamInt>.System.Collections.IList.Remove
	|
	|-RVA: 0x3D2B110 Offset: 0x3D2B211 VA: 0x3D2B110
	|-List<Detail.DataStore.DataStoreDeleteParamInt>.System.Collections.IList.Remove
	|
	|-RVA: 0x3D2E420 Offset: 0x3D2E521 VA: 0x3D2E420
	|-List<Detail.DataStore.DataStoreGetMetaParamInt>.System.Collections.IList.Remove
	|
	|-RVA: 0x3D31810 Offset: 0x3D31911 VA: 0x3D31810
	|-List<Detail.DataStore.DataStoreMetaInfoInt>.System.Collections.IList.Remove
	|
	|-RVA: 0x3CF5E80 Offset: 0x3CF5F81 VA: 0x3CF5E80
	|-List<Detail.DataStore.DataStorePasswordInfoInt>.System.Collections.IList.Remove
	|
	|-RVA: 0x3CF9060 Offset: 0x3CF9161 VA: 0x3CF9060
	|-List<Detail.DataStore.DataStorePersistenceInfoInt>.System.Collections.IList.Remove
	|
	|-RVA: 0x3CFC3E0 Offset: 0x3CFC4E1 VA: 0x3CFC3E0
	|-List<Detail.DataStore.DataStorePreparePostParamInt>.System.Collections.IList.Remove
	|
	|-RVA: 0x3CFF340 Offset: 0x3CFF441 VA: 0x3CFF340
	|-List<Detail.DataStore.DataStoreRateObjectParamInt>.System.Collections.IList.Remove
	|
	|-RVA: 0x3D024E0 Offset: 0x3D025E1 VA: 0x3D024E0
	|-List<Detail.DataStore.DataStoreRatingInitParamInt>.System.Collections.IList.Remove
	|
	|-RVA: 0x3D05410 Offset: 0x3D05511 VA: 0x3D05410
	|-List<Detail.DataStore.DataStoreRatingTargetInt>.System.Collections.IList.Remove
	|
	|-RVA: 0x3D08900 Offset: 0x3D08A01 VA: 0x3D08900
	|-List<Detail.Ranking.RankingCachedResultInt>.System.Collections.IList.Remove
	|
	|-RVA: 0x3D0B8D0 Offset: 0x3D0B9D1 VA: 0x3D0B8D0
	|-List<Detail.Ranking.RankingOrderParamInt>.System.Collections.IList.Remove
	|
	|-RVA: 0x3D0ED70 Offset: 0x3D0EE71 VA: 0x3D0ED70
	|-List<Detail.Ranking.RankingRankDataInt>.System.Collections.IList.Remove
	|
	|-RVA: 0x3D12650 Offset: 0x3D12751 VA: 0x3D12650
	|-List<Detail.Ranking2.Ranking2ChartInfoInt>.System.Collections.IList.Remove
	|
	|-RVA: 0x3D68CF0 Offset: 0x3D68DF1 VA: 0x3D68CF0
	|-List<Detail.Ranking2.Ranking2RankDataInt>.System.Collections.IList.Remove
	|
	|-RVA: 0x3D6BCB0 Offset: 0x3D6BDB1 VA: 0x3D6BCB0
	|-List<Detail.Ranking2.Ranking2ScoreDataInt>.System.Collections.IList.Remove
	|
	|-RVA: 0x3D6EE50 Offset: 0x3D6EF51 VA: 0x3D6EE50
	|-List<Detail.Screening.ScreeningContextInfoInt>.System.Collections.IList.Remove
	|
	|-RVA: 0x3D72540 Offset: 0x3D72641 VA: 0x3D72540
	|-List<Detail.Subscriber.SubscriberContentInt>.System.Collections.IList.Remove
	|
	|-RVA: 0x3D75800 Offset: 0x3D75901 VA: 0x3D75800
	|-List<Detail.Subscriber.SubscriberGetContentParamInt>.System.Collections.IList.Remove
	|
	|-RVA: 0x3D78B60 Offset: 0x3D78C61 VA: 0x3D78B60
	|-List<Detail.Subscriber.SubscriberUserStatusInfoInt>.System.Collections.IList.Remove
	|
	|-RVA: 0x3D7BD80 Offset: 0x3D7BE81 VA: 0x3D7BD80
	|-List<Detail.Subscriber.SubscriberUserStatusParamInt>.System.Collections.IList.Remove
	|
	|-RVA: 0x3D7EC10 Offset: 0x3D7ED11 VA: 0x3D7EC10
	|-List<Detail.Utility.IntegerSettings>.System.Collections.IList.Remove
	|
	|-RVA: 0x3D81AC0 Offset: 0x3D81BC1 VA: 0x3D81AC0
	|-List<Detail.Utility.UniqueIdInfoInt>.System.Collections.IList.Remove
	|
	|-RVA: 0x3D84A60 Offset: 0x3D84B61 VA: 0x3D84A60
	|-List<MapHistory.Rewind.LatestInspectorData>.System.Collections.IList.Remove
	|
	|-RVA: 0x3060D20 Offset: 0x3060E21 VA: 0x3060D20
	|-List<MapHistory.Rewind.WorkTerrainData>.System.Collections.IList.Remove
	|
	|-RVA: 0x3063C80 Offset: 0x3063D81 VA: 0x3063C80
	|-List<MapSkill.AroundCalculator.Result>.System.Collections.IList.Remove
	|
	|-RVA: 0x3066F80 Offset: 0x3067081 VA: 0x3066F80
	|-List<TargetPositionCache.CacheCurve.Item>.System.Collections.IList.Remove
	|
	|-RVA: 0x306A380 Offset: 0x306A481 VA: 0x306A380
	|-List<TargetPositionCache.CacheEntry.RecordingItem>.System.Collections.IList.Remove
	*/

	// RVA: -1 Offset: -1
	public int RemoveAll(Predicate<T> match) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3B0CC80 Offset: 0x3B0CD81 VA: 0x3B0CC80
	|-List<IntervalTree.Entry<object>>.RemoveAll
	|
	|-RVA: 0x3B0FBF0 Offset: 0x3B0FCF1 VA: 0x3B0FBF0
	|-List<KeyValuePair<DateTime, object>>.RemoveAll
	|
	|-RVA: 0x3B12B10 Offset: 0x3B12C11 VA: 0x3B12B10
	|-List<KeyValuePair<int, object>>.RemoveAll
	|
	|-RVA: 0x3B15CE0 Offset: 0x3B15DE1 VA: 0x3B15CE0
	|-List<KeyValuePair<object, ValueTuple<int, DateTime, object>>>.RemoveAll
	|
	|-RVA: 0x3B18C50 Offset: 0x3B18D51 VA: 0x3B18C50
	|-List<KeyValuePair<object, object>>.RemoveAll
	|
	|-RVA: 0x3B1BE10 Offset: 0x3B1BF11 VA: 0x3B1BE10
	|-List<CommonBattleSequence.Reliance<object>>.RemoveAll
	|
	|-RVA: 0x3B1ED80 Offset: 0x3B1EE81 VA: 0x3B1ED80
	|-List<RenderGraphResourcePool.ResourceLogInfo<object>>.RemoveAll
	|
	|-RVA: 0x3DE8950 Offset: 0x3DE8A51 VA: 0x3DE8950
	|-List<ValueTuple<ComputeBuffer, int>>.RemoveAll
	|-List<ValueTuple<object, int>>.RemoveAll
	|-List<ValueTuple<RTHandle, int>>.RemoveAll
	|
	|-RVA: 0x3B21CA0 Offset: 0x3B21DA1 VA: 0x3B21CA0
	|-List<ValueTuple<int, object>>.RemoveAll
	|
	|-RVA: 0x3DE2860 Offset: 0x3DE2961 VA: 0x3DE2860
	|-List<ValueTuple<Int32Enum, int>>.RemoveAll
	|
	|-RVA: 0x3DE59E0 Offset: 0x3DE5AE1 VA: 0x3DE59E0
	|-List<ValueTuple<object, ValueTuple<object, int>>>.RemoveAll
	|
	|-RVA: 0x3DEB950 Offset: 0x3DEBA51 VA: 0x3DEB950
	|-List<ValueTuple<Vector3, float>>.RemoveAll
	|
	|-RVA: 0x3DEE870 Offset: 0x3DEE971 VA: 0x3DEE870
	|-List<ValueTuple<object, Int32Enum, int>>.RemoveAll
	|
	|-RVA: 0x3DF1A30 Offset: 0x3DF1B31 VA: 0x3DF1A30
	|-List<ValueTuple<object, int, int, int>>.RemoveAll
	|
	|-RVA: 0x3DF48D0 Offset: 0x3DF49D1 VA: 0x3DF48D0
	|-List<AnimatorClipInfo>.RemoveAll
	|
	|-RVA: 0x3DF7A50 Offset: 0x3DF7B51 VA: 0x3DF7A50
	|-List<AsyncOperationHandle>.RemoveAll
	|
	|-RVA: 0x3E12950 Offset: 0x3E12A51 VA: 0x3E12950
	|-List<BaseInvokableCall>.RemoveAll
	|-List<Camera>.RemoveAll
	|-List<Collider>.RemoveAll
	|-List<Component>.RemoveAll
	|-List<EncountEquipData>.RemoveAll
	|-List<HubAccessData>.RemoveAll
	|-List<HubDisposData>.RemoveAll
	|-List<object>.RemoveAll
	|-List<string>.RemoveAll
	|-List<Task>.RemoveAll
	|-List<ValueCountController>.RemoveAll
	|-List<VolumeComponent>.RemoveAll
	|-List<AddressablesImpl.ResourceLocatorInfo>.RemoveAll
	|-List<AssetBundleBuildMap.AssetBundleEntry>.RemoveAll
	|
	|-RVA: 0x3DFAC50 Offset: 0x3DFAD51 VA: 0x3DFAC50
	|-List<BoneWeight>.RemoveAll
	|
	|-RVA: 0x3DFDB00 Offset: 0x3DFDC01 VA: 0x3DFDB00
	|-List<bool>.RemoveAll
	|
	|-RVA: 0x3E7B040 Offset: 0x3E7B141 VA: 0x3E7B040
	|-List<byte>.RemoveAll
	|
	|-RVA: 0x3E7DF20 Offset: 0x3E7E021 VA: 0x3E7DF20
	|-List<CameraInfo>.RemoveAll
	|
	|-RVA: 0x3E80D60 Offset: 0x3E80E61 VA: 0x3E80D60
	|-List<char>.RemoveAll
	|
	|-RVA: 0x3E83D20 Offset: 0x3E83E21 VA: 0x3E83D20
	|-List<Color>.RemoveAll
	|
	|-RVA: 0x3E86B70 Offset: 0x3E86C71 VA: 0x3E86B70
	|-List<Color32>.RemoveAll
	|
	|-RVA: 0x3E89A50 Offset: 0x3E89B51 VA: 0x3E89A50
	|-List<ConstraintSource>.RemoveAll
	|
	|-RVA: 0x3E8CC10 Offset: 0x3E8CD11 VA: 0x3E8CC10
	|-List<ContourVertex>.RemoveAll
	|
	|-RVA: 0x3E8FE00 Offset: 0x3E8FF01 VA: 0x3E8FE00
	|-List<DataStoreRatingInfo>.RemoveAll
	|
	|-RVA: 0x3E92C90 Offset: 0x3E92D91 VA: 0x3E92C90
	|-List<DataStoreResult>.RemoveAll
	|
	|-RVA: 0x3E95AA0 Offset: 0x3E95BA1 VA: 0x3E95AA0
	|-List<DateTime>.RemoveAll
	|
	|-RVA: 0x3E98950 Offset: 0x3E98A51 VA: 0x3E98950
	|-List<DateTimeOffset>.RemoveAll
	|
	|-RVA: 0x3E9B830 Offset: 0x3E9B931 VA: 0x3E9B830
	|-List<Decimal>.RemoveAll
	|
	|-RVA: 0x3E9EBC0 Offset: 0x3E9ECC1 VA: 0x3E9EBC0
	|-List<DiagnosticEvent>.RemoveAll
	|
	|-RVA: 0x3EA1AC0 Offset: 0x3EA1BC1 VA: 0x3EA1AC0
	|-List<double>.RemoveAll
	|
	|-RVA: 0x3EA4DA0 Offset: 0x3EA4EA1 VA: 0x3EA4DA0
	|-List<Friend>.RemoveAll
	|
	|-RVA: 0x3EA7D00 Offset: 0x3EA7E01 VA: 0x3EA7D00
	|-List<GlyphRect>.RemoveAll
	|
	|-RVA: 0x3EAAB30 Offset: 0x3EAAC31 VA: 0x3EAAB30
	|-List<short>.RemoveAll
	|
	|-RVA: 0x3EAD930 Offset: 0x3EADA31 VA: 0x3EAD930
	|-List<int>.RemoveAll
	|
	|-RVA: 0x3EB0730 Offset: 0x3EB0831 VA: 0x3EB0730
	|-List<Int32Enum>.RemoveAll
	|
	|-RVA: 0x3EB3530 Offset: 0x3EB3631 VA: 0x3EB3530
	|-List<long>.RemoveAll
	|
	|-RVA: 0x3E00900 Offset: 0x3E00A01 VA: 0x3E00900
	|-List<IntPtr>.RemoveAll
	|
	|-RVA: 0x3E037E0 Offset: 0x3E038E1 VA: 0x3E037E0
	|-List<InterpretedFrameInfo>.RemoveAll
	|
	|-RVA: 0x3E06980 Offset: 0x3E06A81 VA: 0x3E06980
	|-List<IntervalTreeNode>.RemoveAll
	|
	|-RVA: 0x3E09810 Offset: 0x3E09911 VA: 0x3E09810
	|-List<LengthLimitProperties>.RemoveAll
	|
	|-RVA: 0x3E0C620 Offset: 0x3E0C721 VA: 0x3E0C620
	|-List<MapPos>.RemoveAll
	|
	|-RVA: 0x3E0FAA0 Offset: 0x3E0FBA1 VA: 0x3E0FAA0
	|-List<Matrix4x4>.RemoveAll
	|
	|-RVA: 0x3E15CC0 Offset: 0x3E15DC1 VA: 0x3E15CC0
	|-List<ObjectInitializationData>.RemoveAll
	|
	|-RVA: 0x3E18F30 Offset: 0x3E19031 VA: 0x3E18F30
	|-List<PlayableBinding>.RemoveAll
	|
	|-RVA: 0x3E1C2D0 Offset: 0x3E1C3D1 VA: 0x3E1C2D0
	|-List<PlayerLoopSystem>.RemoveAll
	|
	|-RVA: 0x3DA6770 Offset: 0x3DA6871 VA: 0x3DA6770
	|-List<PlayerLoopSystemInternal>.RemoveAll
	|
	|-RVA: 0x3DA9710 Offset: 0x3DA9811 VA: 0x3DA9710
	|-List<RangePositionInfo>.RemoveAll
	|
	|-RVA: 0x3DAC560 Offset: 0x3DAC661 VA: 0x3DAC560
	|-List<Ranking2ChartInfoInput>.RemoveAll
	|
	|-RVA: 0x3DAF8B0 Offset: 0x3DAF9B1 VA: 0x3DAF8B0
	|-List<RaycastHit2D>.RemoveAll
	|
	|-RVA: 0x3DB3030 Offset: 0x3DB3131 VA: 0x3DB3030
	|-List<RaycastResult>.RemoveAll
	|
	|-RVA: 0x3DB6150 Offset: 0x3DB6251 VA: 0x3DB6150
	|-List<Rect>.RemoveAll
	|
	|-RVA: 0x3DB8FA0 Offset: 0x3DB90A1 VA: 0x3DB8FA0
	|-List<RendererListHandle>.RemoveAll
	|
	|-RVA: 0x3DBBDB0 Offset: 0x3DBBEB1 VA: 0x3DBBDB0
	|-List<ResourceHandle>.RemoveAll
	|
	|-RVA: 0x3DBEBC0 Offset: 0x3DBECC1 VA: 0x3DBEBC0
	|-List<sbyte>.RemoveAll
	|
	|-RVA: 0x3DC19D0 Offset: 0x3DC1AD1 VA: 0x3DC19D0
	|-List<ShaderTagId>.RemoveAll
	|
	|-RVA: 0x3E3D640 Offset: 0x3E3D741 VA: 0x3E3D640
	|-List<float>.RemoveAll
	|
	|-RVA: 0x3E41130 Offset: 0x3E41231 VA: 0x3E41130
	|-List<SphericalHarmonicsL2>.RemoveAll
	|
	|-RVA: 0x3E44650 Offset: 0x3E44751 VA: 0x3E44650
	|-List<SubMeshDescriptor>.RemoveAll
	|
	|-RVA: 0x3E475F0 Offset: 0x3E476F1 VA: 0x3E475F0
	|-List<TablePair>.RemoveAll
	|
	|-RVA: 0x3E4A440 Offset: 0x3E4A541 VA: 0x3E4A440
	|-List<TimeSpan>.RemoveAll
	|
	|-RVA: 0x3E4D3D0 Offset: 0x3E4D4D1 VA: 0x3E4D3D0
	|-List<UICharInfo>.RemoveAll
	|
	|-RVA: 0x3E502D0 Offset: 0x3E503D1 VA: 0x3E502D0
	|-List<UILineInfo>.RemoveAll
	|
	|-RVA: 0x3E53DF0 Offset: 0x3E53EF1 VA: 0x3E53DF0
	|-List<UIVertex>.RemoveAll
	|
	|-RVA: 0x3E56DE0 Offset: 0x3E56EE1 VA: 0x3E56DE0
	|-List<ushort>.RemoveAll
	|
	|-RVA: 0x3E59BE0 Offset: 0x3E59CE1 VA: 0x3E59BE0
	|-List<uint>.RemoveAll
	|
	|-RVA: 0x3DC47D0 Offset: 0x3DC48D1 VA: 0x3DC47D0
	|-List<ulong>.RemoveAll
	|
	|-RVA: 0x3DC7670 Offset: 0x3DC7771 VA: 0x3DC7670
	|-List<Vector2>.RemoveAll
	|
	|-RVA: 0x3DCA630 Offset: 0x3DCA731 VA: 0x3DCA630
	|-List<Vector3>.RemoveAll
	|
	|-RVA: 0x3DCD640 Offset: 0x3DCD741 VA: 0x3DCD640
	|-List<Vector4>.RemoveAll
	|
	|-RVA: 0x3DD0530 Offset: 0x3DD0631 VA: 0x3DD0530
	|-List<VertexAttributeDescriptor>.RemoveAll
	|
	|-RVA: 0x3DD3440 Offset: 0x3DD3541 VA: 0x3DD3440
	|-List<X509ChainStatus>.RemoveAll
	|
	|-RVA: 0x3DD67A0 Offset: 0x3DD68A1 VA: 0x3DD67A0
	|-List<XRView>.RemoveAll
	|
	|-RVA: 0x3DD9750 Offset: 0x3DD9851 VA: 0x3DD9750
	|-List<AmiiboSequence.GainItemData>.RemoveAll
	|
	|-RVA: 0x3DDCA80 Offset: 0x3DDCB81 VA: 0x3DDCA80
	|-List<AnimationOutputWeightProcessor.WeightInfo>.RemoveAll
	|
	|-RVA: 0x3DDFA10 Offset: 0x3DDFB11 VA: 0x3DDFA10
	|-List<ArenaOrderSequence.GodInfo>.RemoveAll
	|
	|-RVA: 0x3E1F270 Offset: 0x3E1F371 VA: 0x3E1F270
	|-List<BattleInfo.SupportData>.RemoveAll
	|
	|-RVA: 0x3E22190 Offset: 0x3E22291 VA: 0x3E22190
	|-List<BeforeRenderHelper.OrderBlock>.RemoveAll
	|
	|-RVA: 0x3E25360 Offset: 0x3E25461 VA: 0x3E25360
	|-List<Camera.RenderRequest>.RemoveAll
	|
	|-RVA: 0x3E282E0 Offset: 0x3E283E1 VA: 0x3E282E0
	|-List<CameraState.CustomBlendable>.RemoveAll
	|
	|-RVA: 0x3E2B130 Offset: 0x3E2B231 VA: 0x3E2B130
	|-List<CinemachineClearShot.Pair>.RemoveAll
	|
	|-RVA: 0x3E2DF40 Offset: 0x3E2E041 VA: 0x3E2DF40
	|-List<CinemachineStateDrivenCamera.HashPair>.RemoveAll
	|
	|-RVA: 0x3E310D0 Offset: 0x3E311D1 VA: 0x3E310D0
	|-List<DelayedActionManager.DelegateInfo>.RemoveAll
	|
	|-RVA: 0x3E34490 Offset: 0x3E34591 VA: 0x3E34490
	|-List<Detail.AsyncResultInt>.RemoveAll
	|
	|-RVA: 0x3E37400 Offset: 0x3E37501 VA: 0x3E37400
	|-List<Detail.CppArray>.RemoveAll
	|
	|-RVA: 0x3E3A760 Offset: 0x3E3A861 VA: 0x3E3A760
	|-List<Detail.NotificationEventInt>.RemoveAll
	|
	|-RVA: 0x3E5CAC0 Offset: 0x3E5CBC1 VA: 0x3E5CAC0
	|-List<DragonRideTargetGroup.ChainParam>.RemoveAll
	|
	|-RVA: 0x3E5FC80 Offset: 0x3E5FD81 VA: 0x3E5FC80
	|-List<GmapPathAdjuster.TargetModel>.RemoveAll
	|
	|-RVA: 0x3E62E90 Offset: 0x3E62F91 VA: 0x3E62E90
	|-List<GmapSpotAdjuster.TargetModel>.RemoveAll
	|
	|-RVA: 0x3E660A0 Offset: 0x3E661A1 VA: 0x3E660A0
	|-List<HubFastTravel.Location>.RemoveAll
	|
	|-RVA: 0x3E69490 Offset: 0x3E69591 VA: 0x3E69490
	|-List<HubLensFlare.Flare>.RemoveAll
	|
	|-RVA: 0x3E6C450 Offset: 0x3E6C551 VA: 0x3E6C450
	|-List<InventoryPoolItemMenuContent.KindBgNameClass>.RemoveAll
	|
	|-RVA: 0x3E6F2A0 Offset: 0x3E6F3A1 VA: 0x3E6F2A0
	|-List<Map.Pos>.RemoveAll
	|
	|-RVA: 0x3E72150 Offset: 0x3E72251 VA: 0x3E72150
	|-List<MapImage.BackupTerrain>.RemoveAll
	|
	|-RVA: 0x3E75000 Offset: 0x3E75101 VA: 0x3E75000
	|-List<MapImageRange.Pos>.RemoveAll
	|
	|-RVA: 0x3E781A0 Offset: 0x3E782A1 VA: 0x3E781A0
	|-List<MapMind.Target>.RemoveAll
	|
	|-RVA: 0x3D87D80 Offset: 0x3D87E81 VA: 0x3D87D80
	|-List<MapPanelDebug.Entity>.RemoveAll
	|
	|-RVA: 0x3D8AC10 Offset: 0x3D8AD11 VA: 0x3D8AC10
	|-List<NexRanking.Data>.RemoveAll
	|
	|-RVA: 0x3D8DAC0 Offset: 0x3D8DBC1 VA: 0x3D8DAC0
	|-List<NexVersus.RatingData>.RemoveAll
	|
	|-RVA: 0x3D909D0 Offset: 0x3D90AD1 VA: 0x3D909D0
	|-List<PackedPlayModeBuildLogs.RuntimeBuildLog>.RemoveAll
	|
	|-RVA: 0x3D93D10 Offset: 0x3D93E11 VA: 0x3D93D10
	|-List<ParticleSystem.Particle>.RemoveAll
	|
	|-RVA: 0x3D96BD0 Offset: 0x3D96CD1 VA: 0x3D96BD0
	|-List<RangeData.Offset>.RemoveAll
	|
	|-RVA: 0x3D99D60 Offset: 0x3D99E61 VA: 0x3D99D60
	|-List<RenderGraphDebugData.PassDebugData>.RemoveAll
	|
	|-RVA: 0x3D9D100 Offset: 0x3D9D201 VA: 0x3D9D100
	|-List<RenderGraphDebugData.ResourceDebugData>.RemoveAll
	|
	|-RVA: 0x3DA00A0 Offset: 0x3DA01A1 VA: 0x3DA00A0
	|-List<RingCleaningUnitSelectMenu.GodParam>.RemoveAll
	|
	|-RVA: 0x3DA33B0 Offset: 0x3DA34B1 VA: 0x3DA33B0
	|-List<ShadowUtility.Edge>.RemoveAll
	|
	|-RVA: 0x3D15740 Offset: 0x3D15841 VA: 0x3D15740
	|-List<SkillArray.Entity>.RemoveAll
	|
	|-RVA: 0x3D18BE0 Offset: 0x3D18CE1 VA: 0x3D18BE0
	|-List<TexturePacker_JsonArray.Frame>.RemoveAll
	|
	|-RVA: 0x3D1BE90 Offset: 0x3D1BF91 VA: 0x3D1BE90
	|-List<TimeNotificationBehaviour.NotificationEntry>.RemoveAll
	|
	|-RVA: 0x3D1F0B0 Offset: 0x3D1F1B1 VA: 0x3D1F0B0
	|-List<UnitySynchronizationContext.WorkRequest>.RemoveAll
	|
	|-RVA: 0x3D22020 Offset: 0x3D22121 VA: 0x3D22020
	|-List<XmlSchemaObjectTable.XmlSchemaObjectEntry>.RemoveAll
	|
	|-RVA: 0x3D24F40 Offset: 0x3D25041 VA: 0x3D24F40
	|-List<AssetBundleBuildMap.AssetBundleEntry.AssetPathString>.RemoveAll
	|
	|-RVA: 0x3D282C0 Offset: 0x3D283C1 VA: 0x3D282C0
	|-List<Detail.DataStore.DataStoreChangeMetaParamInt>.RemoveAll
	|
	|-RVA: 0x3D2B250 Offset: 0x3D2B351 VA: 0x3D2B250
	|-List<Detail.DataStore.DataStoreDeleteParamInt>.RemoveAll
	|
	|-RVA: 0x3D2E570 Offset: 0x3D2E671 VA: 0x3D2E570
	|-List<Detail.DataStore.DataStoreGetMetaParamInt>.RemoveAll
	|
	|-RVA: 0x3D31950 Offset: 0x3D31A51 VA: 0x3D31950
	|-List<Detail.DataStore.DataStoreMetaInfoInt>.RemoveAll
	|
	|-RVA: 0x3CF5FC0 Offset: 0x3CF60C1 VA: 0x3CF5FC0
	|-List<Detail.DataStore.DataStorePasswordInfoInt>.RemoveAll
	|
	|-RVA: 0x3CF91A0 Offset: 0x3CF92A1 VA: 0x3CF91A0
	|-List<Detail.DataStore.DataStorePersistenceInfoInt>.RemoveAll
	|
	|-RVA: 0x3CFC520 Offset: 0x3CFC621 VA: 0x3CFC520
	|-List<Detail.DataStore.DataStorePreparePostParamInt>.RemoveAll
	|
	|-RVA: 0x3CFF480 Offset: 0x3CFF581 VA: 0x3CFF480
	|-List<Detail.DataStore.DataStoreRateObjectParamInt>.RemoveAll
	|
	|-RVA: 0x3D02620 Offset: 0x3D02721 VA: 0x3D02620
	|-List<Detail.DataStore.DataStoreRatingInitParamInt>.RemoveAll
	|
	|-RVA: 0x3D05550 Offset: 0x3D05651 VA: 0x3D05550
	|-List<Detail.DataStore.DataStoreRatingTargetInt>.RemoveAll
	|
	|-RVA: 0x3D08A50 Offset: 0x3D08B51 VA: 0x3D08A50
	|-List<Detail.Ranking.RankingCachedResultInt>.RemoveAll
	|
	|-RVA: 0x3D0BA10 Offset: 0x3D0BB11 VA: 0x3D0BA10
	|-List<Detail.Ranking.RankingOrderParamInt>.RemoveAll
	|
	|-RVA: 0x3D0EEC0 Offset: 0x3D0EFC1 VA: 0x3D0EEC0
	|-List<Detail.Ranking.RankingRankDataInt>.RemoveAll
	|
	|-RVA: 0x3D127B0 Offset: 0x3D128B1 VA: 0x3D127B0
	|-List<Detail.Ranking2.Ranking2ChartInfoInt>.RemoveAll
	|
	|-RVA: 0x3D68E40 Offset: 0x3D68F41 VA: 0x3D68E40
	|-List<Detail.Ranking2.Ranking2RankDataInt>.RemoveAll
	|
	|-RVA: 0x3D6BDF0 Offset: 0x3D6BEF1 VA: 0x3D6BDF0
	|-List<Detail.Ranking2.Ranking2ScoreDataInt>.RemoveAll
	|
	|-RVA: 0x3D6EF90 Offset: 0x3D6F091 VA: 0x3D6EF90
	|-List<Detail.Screening.ScreeningContextInfoInt>.RemoveAll
	|
	|-RVA: 0x3D726A0 Offset: 0x3D727A1 VA: 0x3D726A0
	|-List<Detail.Subscriber.SubscriberContentInt>.RemoveAll
	|
	|-RVA: 0x3D75940 Offset: 0x3D75A41 VA: 0x3D75940
	|-List<Detail.Subscriber.SubscriberGetContentParamInt>.RemoveAll
	|
	|-RVA: 0x3D78CB0 Offset: 0x3D78DB1 VA: 0x3D78CB0
	|-List<Detail.Subscriber.SubscriberUserStatusInfoInt>.RemoveAll
	|
	|-RVA: 0x3D7BEC0 Offset: 0x3D7BFC1 VA: 0x3D7BEC0
	|-List<Detail.Subscriber.SubscriberUserStatusParamInt>.RemoveAll
	|
	|-RVA: 0x3D7ED50 Offset: 0x3D7EE51 VA: 0x3D7ED50
	|-List<Detail.Utility.IntegerSettings>.RemoveAll
	|
	|-RVA: 0x3D81C00 Offset: 0x3D81D01 VA: 0x3D81C00
	|-List<Detail.Utility.UniqueIdInfoInt>.RemoveAll
	|
	|-RVA: 0x3D84BB0 Offset: 0x3D84CB1 VA: 0x3D84BB0
	|-List<MapHistory.Rewind.LatestInspectorData>.RemoveAll
	|
	|-RVA: 0x3060E70 Offset: 0x3060F71 VA: 0x3060E70
	|-List<MapHistory.Rewind.WorkTerrainData>.RemoveAll
	|
	|-RVA: 0x3063DC0 Offset: 0x3063EC1 VA: 0x3063DC0
	|-List<MapSkill.AroundCalculator.Result>.RemoveAll
	|
	|-RVA: 0x30670D0 Offset: 0x30671D1 VA: 0x30670D0
	|-List<TargetPositionCache.CacheCurve.Item>.RemoveAll
	|
	|-RVA: 0x306A4D0 Offset: 0x306A5D1 VA: 0x306A4D0
	|-List<TargetPositionCache.CacheEntry.RecordingItem>.RemoveAll
	*/

	// RVA: -1 Offset: -1 Slot: 27
	public void RemoveAt(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3B0CEA0 Offset: 0x3B0CFA1 VA: 0x3B0CEA0
	|-List<IntervalTree.Entry<object>>.RemoveAt
	|
	|-RVA: 0x3B0FDB0 Offset: 0x3B0FEB1 VA: 0x3B0FDB0
	|-List<KeyValuePair<DateTime, object>>.RemoveAt
	|
	|-RVA: 0x3B12CD0 Offset: 0x3B12DD1 VA: 0x3B12CD0
	|-List<KeyValuePair<int, object>>.RemoveAt
	|
	|-RVA: 0x3B15F00 Offset: 0x3B16001 VA: 0x3B15F00
	|-List<KeyValuePair<object, ValueTuple<int, DateTime, object>>>.RemoveAt
	|
	|-RVA: 0x3B18E10 Offset: 0x3B18F11 VA: 0x3B18E10
	|-List<KeyValuePair<object, object>>.RemoveAt
	|
	|-RVA: 0x3E12AF0 Offset: 0x3E12BF1 VA: 0x3E12AF0
	|-List<List<object>>.RemoveAt
	|-List<BaseInputModule>.RemoveAt
	|-List<BuildTimeScopeFrame>.RemoveAt
	|-List<Camera>.RemoveAt
	|-List<CinemachineExtension>.RemoveAt
	|-List<CinemachineVirtualCameraBase>.RemoveAt
	|-List<DebugUIHandlerValue>.RemoveAt
	|-List<Decorator>.RemoveAt
	|-List<DynValue>.RemoveAt
	|-List<EventSystem>.RemoveAt
	|-List<FoodstuffData>.RemoveAt
	|-List<GameObject>.RemoveAt
	|-List<GmapSpot>.RemoveAt
	|-List<IClosureBuilder>.RemoveAt
	|-List<Image>.RemoveAt
	|-List<Instruction>.RemoveAt
	|-List<ItemData>.RemoveAt
	|-List<KerningPair>.RemoveAt
	|-List<MapBackup>.RemoveAt
	|-List<object>.RemoveAt
	|-List<Phase>.RemoveAt
	|-List<Processor>.RemoveAt
	|-List<ProfileCard>.RemoveAt
	|-List<RelayServerMetaData>.RemoveAt
	|-List<RewardData>.RemoveAt
	|-List<ScriptableRenderPass>.RemoveAt
	|-List<SignalAsset>.RemoveAt
	|-List<SourceRef>.RemoveAt
	|-List<string>.RemoveAt
	|-List<StringBuilder>.RemoveAt
	|-List<TMP_Character>.RemoveAt
	|-List<Unit>.RemoveAt
	|-List<UnityEvent>.RemoveAt
	|-List<VersusServerCasualMetaData>.RemoveAt
	|-List<VersusServerRankedMetaData>.RemoveAt
	|-List<VolumeComponent>.RemoveAt
	|-List<AIInterruptAttack.Candidate>.RemoveAt
	|-List<AssetTable.Accessory>.RemoveAt
	|-List<CinemachineBrain.BrainFrame>.RemoveAt
	|-List<CinemachineImpulseManager.ImpulseEvent>.RemoveAt
	|-List<Directory.SearchData>.RemoveAt
	|-List<DragonRideTargetGroup.ChainSEManager>.RemoveAt
	|-List<GameSaveDataHeaderReader.Handle>.RemoveAt
	|-List<MapDispos.ActualData>.RemoveAt
	|-List<MapDispos.Pos>.RemoveAt
	|-List<MapEditHistory.MapEditCommand>.RemoveAt
	|-List<MapLayer.Data>.RemoveAt
	|-List<MapObject.RigidInfo>.RemoveAt
	|-List<MapOverlap.Data>.RemoveAt
	|-List<RelayUserData.EnteredBattle>.RemoveAt
	|-List<RingListSequence.PageData>.RemoveAt
	|-List<StencilMaterial.MatEntry>.RemoveAt
	|-List<TMP_MaterialManager.MaskingMaterial>.RemoveAt
	|
	|-RVA: 0x3B1C030 Offset: 0x3B1C131 VA: 0x3B1C030
	|-List<CommonBattleSequence.Reliance<object>>.RemoveAt
	|
	|-RVA: 0x3B1EF40 Offset: 0x3B1F041 VA: 0x3B1EF40
	|-List<RenderGraphResourcePool.ResourceLogInfo<object>>.RemoveAt
	|
	|-RVA: 0x3B21E60 Offset: 0x3B21F61 VA: 0x3B21E60
	|-List<ValueTuple<int, object>>.RemoveAt
	|
	|-RVA: 0x3DE29F0 Offset: 0x3DE2AF1 VA: 0x3DE29F0
	|-List<ValueTuple<Int32Enum, int>>.RemoveAt
	|
	|-RVA: 0x3DE5C00 Offset: 0x3DE5D01 VA: 0x3DE5C00
	|-List<ValueTuple<object, ValueTuple<object, int>>>.RemoveAt
	|
	|-RVA: 0x3DE8B10 Offset: 0x3DE8C11 VA: 0x3DE8B10
	|-List<ValueTuple<object, int>>.RemoveAt
	|
	|-RVA: 0x3DEBB20 Offset: 0x3DEBC21 VA: 0x3DEBB20
	|-List<ValueTuple<Vector3, float>>.RemoveAt
	|
	|-RVA: 0x3DEEA30 Offset: 0x3DEEB31 VA: 0x3DEEA30
	|-List<ValueTuple<object, Int32Enum, int>>.RemoveAt
	|
	|-RVA: 0x3DF1C50 Offset: 0x3DF1D51 VA: 0x3DF1C50
	|-List<ValueTuple<object, int, int, int>>.RemoveAt
	|
	|-RVA: 0x3DF4A60 Offset: 0x3DF4B61 VA: 0x3DF4A60
	|-List<AnimatorClipInfo>.RemoveAt
	|
	|-RVA: 0x3DF7C70 Offset: 0x3DF7D71 VA: 0x3DF7C70
	|-List<AsyncOperationHandle>.RemoveAt
	|
	|-RVA: 0x3DFAE60 Offset: 0x3DFAF61 VA: 0x3DFAE60
	|-List<BoneWeight>.RemoveAt
	|
	|-RVA: 0x3DFDC90 Offset: 0x3DFDD91 VA: 0x3DFDC90
	|-List<bool>.RemoveAt
	|
	|-RVA: 0x3E7B1D0 Offset: 0x3E7B2D1 VA: 0x3E7B1D0
	|-List<byte>.RemoveAt
	|
	|-RVA: 0x3E7E0E0 Offset: 0x3E7E1E1 VA: 0x3E7E0E0
	|-List<CameraInfo>.RemoveAt
	|
	|-RVA: 0x3E80EF0 Offset: 0x3E80FF1 VA: 0x3E80EF0
	|-List<char>.RemoveAt
	|
	|-RVA: 0x3E83EF0 Offset: 0x3E83FF1 VA: 0x3E83EF0
	|-List<Color>.RemoveAt
	|
	|-RVA: 0x3E86D00 Offset: 0x3E86E01 VA: 0x3E86D00
	|-List<Color32>.RemoveAt
	|
	|-RVA: 0x3E89C10 Offset: 0x3E89D11 VA: 0x3E89C10
	|-List<ConstraintSource>.RemoveAt
	|
	|-RVA: 0x3E8CE30 Offset: 0x3E8CF31 VA: 0x3E8CE30
	|-List<ContourVertex>.RemoveAt
	|
	|-RVA: 0x3E90010 Offset: 0x3E90111 VA: 0x3E90010
	|-List<DataStoreRatingInfo>.RemoveAt
	|
	|-RVA: 0x3E92E20 Offset: 0x3E92F21 VA: 0x3E92E20
	|-List<DataStoreResult>.RemoveAt
	|
	|-RVA: 0x3E95C30 Offset: 0x3E95D31 VA: 0x3E95C30
	|-List<DateTime>.RemoveAt
	|
	|-RVA: 0x3E98B10 Offset: 0x3E98C11 VA: 0x3E98B10
	|-List<DateTimeOffset>.RemoveAt
	|
	|-RVA: 0x3E9B9F0 Offset: 0x3E9BAF1 VA: 0x3E9B9F0
	|-List<Decimal>.RemoveAt
	|
	|-RVA: 0x3E9EE20 Offset: 0x3E9EF21 VA: 0x3E9EE20
	|-List<DiagnosticEvent>.RemoveAt
	|
	|-RVA: 0x3EA1C50 Offset: 0x3EA1D51 VA: 0x3EA1C50
	|-List<double>.RemoveAt
	|
	|-RVA: 0x3EA4FD0 Offset: 0x3EA50D1 VA: 0x3EA4FD0
	|-List<Friend>.RemoveAt
	|
	|-RVA: 0x3EA7EC0 Offset: 0x3EA7FC1 VA: 0x3EA7EC0
	|-List<GlyphRect>.RemoveAt
	|
	|-RVA: 0x3EAACC0 Offset: 0x3EAADC1 VA: 0x3EAACC0
	|-List<short>.RemoveAt
	|
	|-RVA: 0x3EADAC0 Offset: 0x3EADBC1 VA: 0x3EADAC0
	|-List<int>.RemoveAt
	|
	|-RVA: 0x3EB08C0 Offset: 0x3EB09C1 VA: 0x3EB08C0
	|-List<Int32Enum>.RemoveAt
	|-List<RegexOptions>.RemoveAt
	|
	|-RVA: 0x3EB36C0 Offset: 0x3EB37C1 VA: 0x3EB36C0
	|-List<long>.RemoveAt
	|
	|-RVA: 0x3E00A90 Offset: 0x3E00B91 VA: 0x3E00A90
	|-List<IntPtr>.RemoveAt
	|
	|-RVA: 0x3E039A0 Offset: 0x3E03AA1 VA: 0x3E039A0
	|-List<InterpretedFrameInfo>.RemoveAt
	|
	|-RVA: 0x3E06B90 Offset: 0x3E06C91 VA: 0x3E06B90
	|-List<IntervalTreeNode>.RemoveAt
	|
	|-RVA: 0x3E099A0 Offset: 0x3E09AA1 VA: 0x3E099A0
	|-List<LengthLimitProperties>.RemoveAt
	|
	|-RVA: 0x3E0C7B0 Offset: 0x3E0C8B1 VA: 0x3E0C7B0
	|-List<MapPos>.RemoveAt
	|
	|-RVA: 0x3E0FD20 Offset: 0x3E0FE21 VA: 0x3E0FD20
	|-List<Matrix4x4>.RemoveAt
	|
	|-RVA: 0x3E15F20 Offset: 0x3E16021 VA: 0x3E15F20
	|-List<ObjectInitializationData>.RemoveAt
	|
	|-RVA: 0x3E19150 Offset: 0x3E19251 VA: 0x3E19150
	|-List<PlayableBinding>.RemoveAt
	|
	|-RVA: 0x3E1C510 Offset: 0x3E1C611 VA: 0x3E1C510
	|-List<PlayerLoopSystem>.RemoveAt
	|
	|-RVA: 0x3DA69B0 Offset: 0x3DA6AB1 VA: 0x3DA69B0
	|-List<PlayerLoopSystemInternal>.RemoveAt
	|
	|-RVA: 0x3DA98D0 Offset: 0x3DA99D1 VA: 0x3DA98D0
	|-List<RangePositionInfo>.RemoveAt
	|
	|-RVA: 0x3DAC6F0 Offset: 0x3DAC7F1 VA: 0x3DAC6F0
	|-List<Ranking2ChartInfoInput>.RemoveAt
	|
	|-RVA: 0x3DAFB00 Offset: 0x3DAFC01 VA: 0x3DAFB00
	|-List<RaycastHit2D>.RemoveAt
	|
	|-RVA: 0x3DB32F0 Offset: 0x3DB33F1 VA: 0x3DB32F0
	|-List<RaycastResult>.RemoveAt
	|
	|-RVA: 0x3DB6320 Offset: 0x3DB6421 VA: 0x3DB6320
	|-List<Rect>.RemoveAt
	|
	|-RVA: 0x3DB9130 Offset: 0x3DB9231 VA: 0x3DB9130
	|-List<RendererListHandle>.RemoveAt
	|
	|-RVA: 0x3DBBF40 Offset: 0x3DBC041 VA: 0x3DBBF40
	|-List<ResourceHandle>.RemoveAt
	|
	|-RVA: 0x3DBED50 Offset: 0x3DBEE51 VA: 0x3DBED50
	|-List<sbyte>.RemoveAt
	|
	|-RVA: 0x3DC1B60 Offset: 0x3DC1C61 VA: 0x3DC1B60
	|-List<ShaderTagId>.RemoveAt
	|
	|-RVA: 0x3E3D7D0 Offset: 0x3E3D8D1 VA: 0x3E3D7D0
	|-List<float>.RemoveAt
	|
	|-RVA: 0x3E41470 Offset: 0x3E41571 VA: 0x3E41470
	|-List<SphericalHarmonicsL2>.RemoveAt
	|
	|-RVA: 0x3E448A0 Offset: 0x3E449A1 VA: 0x3E448A0
	|-List<SubMeshDescriptor>.RemoveAt
	|
	|-RVA: 0x3E477B0 Offset: 0x3E478B1 VA: 0x3E477B0
	|-List<TablePair>.RemoveAt
	|
	|-RVA: 0x3E4A5D0 Offset: 0x3E4A6D1 VA: 0x3E4A5D0
	|-List<TimeSpan>.RemoveAt
	|
	|-RVA: 0x3E4D5B0 Offset: 0x3E4D6B1 VA: 0x3E4D5B0
	|-List<UICharInfo>.RemoveAt
	|
	|-RVA: 0x3E50490 Offset: 0x3E50591 VA: 0x3E50490
	|-List<UILineInfo>.RemoveAt
	|
	|-RVA: 0x3E54130 Offset: 0x3E54231 VA: 0x3E54130
	|-List<UIVertex>.RemoveAt
	|
	|-RVA: 0x3E56F70 Offset: 0x3E57071 VA: 0x3E56F70
	|-List<ushort>.RemoveAt
	|
	|-RVA: 0x3E59D70 Offset: 0x3E59E71 VA: 0x3E59D70
	|-List<uint>.RemoveAt
	|
	|-RVA: 0x3DC4960 Offset: 0x3DC4A61 VA: 0x3DC4960
	|-List<ulong>.RemoveAt
	|
	|-RVA: 0x3DC7830 Offset: 0x3DC7931 VA: 0x3DC7830
	|-List<Vector2>.RemoveAt
	|
	|-RVA: 0x3DCA810 Offset: 0x3DCA911 VA: 0x3DCA810
	|-List<Vector3>.RemoveAt
	|
	|-RVA: 0x3DCD810 Offset: 0x3DCD911 VA: 0x3DCD810
	|-List<Vector4>.RemoveAt
	|
	|-RVA: 0x3DD06F0 Offset: 0x3DD07F1 VA: 0x3DD06F0
	|-List<VertexAttributeDescriptor>.RemoveAt
	|
	|-RVA: 0x3DD3600 Offset: 0x3DD3701 VA: 0x3DD3600
	|-List<X509ChainStatus>.RemoveAt
	|
	|-RVA: 0x3DD69E0 Offset: 0x3DD6AE1 VA: 0x3DD69E0
	|-List<XRView>.RemoveAt
	|
	|-RVA: 0x3DD9910 Offset: 0x3DD9A11 VA: 0x3DD9910
	|-List<AmiiboSequence.GainItemData>.RemoveAt
	|
	|-RVA: 0x3DDCCC0 Offset: 0x3DDCDC1 VA: 0x3DDCCC0
	|-List<AnimationOutputWeightProcessor.WeightInfo>.RemoveAt
	|
	|-RVA: 0x3DDFBD0 Offset: 0x3DDFCD1 VA: 0x3DDFBD0
	|-List<ArenaOrderSequence.GodInfo>.RemoveAt
	|
	|-RVA: 0x3E1F430 Offset: 0x3E1F531 VA: 0x3E1F430
	|-List<BattleInfo.SupportData>.RemoveAt
	|
	|-RVA: 0x3E22350 Offset: 0x3E22451 VA: 0x3E22350
	|-List<BeforeRenderHelper.OrderBlock>.RemoveAt
	|
	|-RVA: 0x3E25580 Offset: 0x3E25681 VA: 0x3E25580
	|-List<Camera.RenderRequest>.RemoveAt
	|
	|-RVA: 0x3E284A0 Offset: 0x3E285A1 VA: 0x3E284A0
	|-List<CameraState.CustomBlendable>.RemoveAt
	|
	|-RVA: 0x3E2B2C0 Offset: 0x3E2B3C1 VA: 0x3E2B2C0
	|-List<CinemachineClearShot.Pair>.RemoveAt
	|
	|-RVA: 0x3E2E0D0 Offset: 0x3E2E1D1 VA: 0x3E2E0D0
	|-List<CinemachineStateDrivenCamera.HashPair>.RemoveAt
	|
	|-RVA: 0x3E312F0 Offset: 0x3E313F1 VA: 0x3E312F0
	|-List<DelayedActionManager.DelegateInfo>.RemoveAt
	|
	|-RVA: 0x3E346E0 Offset: 0x3E347E1 VA: 0x3E346E0
	|-List<Detail.AsyncResultInt>.RemoveAt
	|
	|-RVA: 0x3E375C0 Offset: 0x3E376C1 VA: 0x3E375C0
	|-List<Detail.CppArray>.RemoveAt
	|
	|-RVA: 0x3E3A9B0 Offset: 0x3E3AAB1 VA: 0x3E3A9B0
	|-List<Detail.NotificationEventInt>.RemoveAt
	|
	|-RVA: 0x3E5CC80 Offset: 0x3E5CD81 VA: 0x3E5CC80
	|-List<DragonRideTargetGroup.ChainParam>.RemoveAt
	|
	|-RVA: 0x3E5FEA0 Offset: 0x3E5FFA1 VA: 0x3E5FEA0
	|-List<GmapPathAdjuster.TargetModel>.RemoveAt
	|
	|-RVA: 0x3E630B0 Offset: 0x3E631B1 VA: 0x3E630B0
	|-List<GmapSpotAdjuster.TargetModel>.RemoveAt
	|
	|-RVA: 0x3E662C0 Offset: 0x3E663C1 VA: 0x3E662C0
	|-List<HubFastTravel.Location>.RemoveAt
	|
	|-RVA: 0x3E696F0 Offset: 0x3E697F1 VA: 0x3E696F0
	|-List<HubLensFlare.Flare>.RemoveAt
	|
	|-RVA: 0x3E6C610 Offset: 0x3E6C711 VA: 0x3E6C610
	|-List<InventoryPoolItemMenuContent.KindBgNameClass>.RemoveAt
	|
	|-RVA: 0x3E6F430 Offset: 0x3E6F531 VA: 0x3E6F430
	|-List<Map.Pos>.RemoveAt
	|
	|-RVA: 0x3E72310 Offset: 0x3E72411 VA: 0x3E72310
	|-List<MapImage.BackupTerrain>.RemoveAt
	|
	|-RVA: 0x3E751B0 Offset: 0x3E752B1 VA: 0x3E751B0
	|-List<MapImageRange.Pos>.RemoveAt
	|
	|-RVA: 0x3E783C0 Offset: 0x3E784C1 VA: 0x3E783C0
	|-List<MapMind.Target>.RemoveAt
	|
	|-RVA: 0x3D87F90 Offset: 0x3D88091 VA: 0x3D87F90
	|-List<MapPanelDebug.Entity>.RemoveAt
	|
	|-RVA: 0x3D8ADA0 Offset: 0x3D8AEA1 VA: 0x3D8ADA0
	|-List<NexRanking.Data>.RemoveAt
	|
	|-RVA: 0x3D8DC80 Offset: 0x3D8DD81 VA: 0x3D8DC80
	|-List<NexVersus.RatingData>.RemoveAt
	|
	|-RVA: 0x3D90B90 Offset: 0x3D90C91 VA: 0x3D90B90
	|-List<PackedPlayModeBuildLogs.RuntimeBuildLog>.RemoveAt
	|
	|-RVA: 0x3D93F40 Offset: 0x3D94041 VA: 0x3D93F40
	|-List<ParticleSystem.Particle>.RemoveAt
	|
	|-RVA: 0x3D96D60 Offset: 0x3D96E61 VA: 0x3D96D60
	|-List<RangeData.Offset>.RemoveAt
	|
	|-RVA: 0x3D99F80 Offset: 0x3D9A081 VA: 0x3D99F80
	|-List<RenderGraphDebugData.PassDebugData>.RemoveAt
	|
	|-RVA: 0x3D9D340 Offset: 0x3D9D441 VA: 0x3D9D340
	|-List<RenderGraphDebugData.ResourceDebugData>.RemoveAt
	|
	|-RVA: 0x3DA0260 Offset: 0x3DA0361 VA: 0x3DA0260
	|-List<RingCleaningUnitSelectMenu.GodParam>.RemoveAt
	|
	|-RVA: 0x3DA35F0 Offset: 0x3DA36F1 VA: 0x3DA35F0
	|-List<ShadowUtility.Edge>.RemoveAt
	|
	|-RVA: 0x3D158D0 Offset: 0x3D159D1 VA: 0x3D158D0
	|-List<SkillArray.Entity>.RemoveAt
	|
	|-RVA: 0x3D18E70 Offset: 0x3D18F71 VA: 0x3D18E70
	|-List<TexturePacker_JsonArray.Frame>.RemoveAt
	|
	|-RVA: 0x3D1C0B0 Offset: 0x3D1C1B1 VA: 0x3D1C0B0
	|-List<TimeNotificationBehaviour.NotificationEntry>.RemoveAt
	|
	|-RVA: 0x3D1F2D0 Offset: 0x3D1F3D1 VA: 0x3D1F2D0
	|-List<UnitySynchronizationContext.WorkRequest>.RemoveAt
	|
	|-RVA: 0x3D221E0 Offset: 0x3D222E1 VA: 0x3D221E0
	|-List<XmlSchemaObjectTable.XmlSchemaObjectEntry>.RemoveAt
	|
	|-RVA: 0x3D25100 Offset: 0x3D25201 VA: 0x3D25100
	|-List<AssetBundleBuildMap.AssetBundleEntry.AssetPathString>.RemoveAt
	|
	|-RVA: 0x3D284F0 Offset: 0x3D285F1 VA: 0x3D284F0
	|-List<Detail.DataStore.DataStoreChangeMetaParamInt>.RemoveAt
	|
	|-RVA: 0x3D2B410 Offset: 0x3D2B511 VA: 0x3D2B410
	|-List<Detail.DataStore.DataStoreDeleteParamInt>.RemoveAt
	|
	|-RVA: 0x3D2E7B0 Offset: 0x3D2E8B1 VA: 0x3D2E7B0
	|-List<Detail.DataStore.DataStoreGetMetaParamInt>.RemoveAt
	|
	|-RVA: 0x3D31B80 Offset: 0x3D31C81 VA: 0x3D31B80
	|-List<Detail.DataStore.DataStoreMetaInfoInt>.RemoveAt
	|
	|-RVA: 0x3CF61D0 Offset: 0x3CF62D1 VA: 0x3CF61D0
	|-List<Detail.DataStore.DataStorePasswordInfoInt>.RemoveAt
	|
	|-RVA: 0x3CF93B0 Offset: 0x3CF94B1 VA: 0x3CF93B0
	|-List<Detail.DataStore.DataStorePersistenceInfoInt>.RemoveAt
	|
	|-RVA: 0x3CFC750 Offset: 0x3CFC851 VA: 0x3CFC750
	|-List<Detail.DataStore.DataStorePreparePostParamInt>.RemoveAt
	|
	|-RVA: 0x3CFF640 Offset: 0x3CFF741 VA: 0x3CFF640
	|-List<Detail.DataStore.DataStoreRateObjectParamInt>.RemoveAt
	|
	|-RVA: 0x3D02830 Offset: 0x3D02931 VA: 0x3D02830
	|-List<Detail.DataStore.DataStoreRatingInitParamInt>.RemoveAt
	|
	|-RVA: 0x3D05710 Offset: 0x3D05811 VA: 0x3D05710
	|-List<Detail.DataStore.DataStoreRatingTargetInt>.RemoveAt
	|
	|-RVA: 0x3D08CE0 Offset: 0x3D08DE1 VA: 0x3D08CE0
	|-List<Detail.Ranking.RankingCachedResultInt>.RemoveAt
	|
	|-RVA: 0x3D0BBD0 Offset: 0x3D0BCD1 VA: 0x3D0BBD0
	|-List<Detail.Ranking.RankingOrderParamInt>.RemoveAt
	|
	|-RVA: 0x3D0F140 Offset: 0x3D0F241 VA: 0x3D0F140
	|-List<Detail.Ranking.RankingRankDataInt>.RemoveAt
	|
	|-RVA: 0x3D12A90 Offset: 0x3D12B91 VA: 0x3D12A90
	|-List<Detail.Ranking2.Ranking2ChartInfoInt>.RemoveAt
	|
	|-RVA: 0x3D690C0 Offset: 0x3D691C1 VA: 0x3D690C0
	|-List<Detail.Ranking2.Ranking2RankDataInt>.RemoveAt
	|
	|-RVA: 0x3D6BFB0 Offset: 0x3D6C0B1 VA: 0x3D6BFB0
	|-List<Detail.Ranking2.Ranking2ScoreDataInt>.RemoveAt
	|
	|-RVA: 0x3D6F1A0 Offset: 0x3D6F2A1 VA: 0x3D6F1A0
	|-List<Detail.Screening.ScreeningContextInfoInt>.RemoveAt
	|
	|-RVA: 0x3D72950 Offset: 0x3D72A51 VA: 0x3D72950
	|-List<Detail.Subscriber.SubscriberContentInt>.RemoveAt
	|
	|-RVA: 0x3D75B50 Offset: 0x3D75C51 VA: 0x3D75B50
	|-List<Detail.Subscriber.SubscriberGetContentParamInt>.RemoveAt
	|
	|-RVA: 0x3D78EF0 Offset: 0x3D78FF1 VA: 0x3D78EF0
	|-List<Detail.Subscriber.SubscriberUserStatusInfoInt>.RemoveAt
	|
	|-RVA: 0x3D7C0D0 Offset: 0x3D7C1D1 VA: 0x3D7C0D0
	|-List<Detail.Subscriber.SubscriberUserStatusParamInt>.RemoveAt
	|
	|-RVA: 0x3D7EEE0 Offset: 0x3D7EFE1 VA: 0x3D7EEE0
	|-List<Detail.Utility.IntegerSettings>.RemoveAt
	|
	|-RVA: 0x3D81DC0 Offset: 0x3D81EC1 VA: 0x3D81DC0
	|-List<Detail.Utility.UniqueIdInfoInt>.RemoveAt
	|
	|-RVA: 0x3D84DB0 Offset: 0x3D84EB1 VA: 0x3D84DB0
	|-List<MapHistory.Rewind.LatestInspectorData>.RemoveAt
	|
	|-RVA: 0x3061070 Offset: 0x3061171 VA: 0x3061070
	|-List<MapHistory.Rewind.WorkTerrainData>.RemoveAt
	|
	|-RVA: 0x3063F80 Offset: 0x3064081 VA: 0x3063F80
	|-List<MapSkill.AroundCalculator.Result>.RemoveAt
	|
	|-RVA: 0x3067310 Offset: 0x3067411 VA: 0x3067310
	|-List<TargetPositionCache.CacheCurve.Item>.RemoveAt
	|
	|-RVA: 0x306A720 Offset: 0x306A821 VA: 0x306A720
	|-List<TargetPositionCache.CacheEntry.RecordingItem>.RemoveAt
	*/

	// RVA: -1 Offset: -1
	public void RemoveRange(int index, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3B0CF60 Offset: 0x3B0D061 VA: 0x3B0CF60
	|-List<IntervalTree.Entry<object>>.RemoveRange
	|
	|-RVA: 0x3B0FE80 Offset: 0x3B0FF81 VA: 0x3B0FE80
	|-List<KeyValuePair<DateTime, object>>.RemoveRange
	|
	|-RVA: 0x3B12DA0 Offset: 0x3B12EA1 VA: 0x3B12DA0
	|-List<KeyValuePair<int, object>>.RemoveRange
	|
	|-RVA: 0x3B15FC0 Offset: 0x3B160C1 VA: 0x3B15FC0
	|-List<KeyValuePair<object, ValueTuple<int, DateTime, object>>>.RemoveRange
	|
	|-RVA: 0x3B18EE0 Offset: 0x3B18FE1 VA: 0x3B18EE0
	|-List<KeyValuePair<object, object>>.RemoveRange
	|
	|-RVA: 0x3B1C0F0 Offset: 0x3B1C1F1 VA: 0x3B1C0F0
	|-List<CommonBattleSequence.Reliance<object>>.RemoveRange
	|
	|-RVA: 0x3B1F010 Offset: 0x3B1F111 VA: 0x3B1F010
	|-List<RenderGraphResourcePool.ResourceLogInfo<object>>.RemoveRange
	|
	|-RVA: 0x3B21F30 Offset: 0x3B22031 VA: 0x3B21F30
	|-List<ValueTuple<int, object>>.RemoveRange
	|
	|-RVA: 0x3DE2AB0 Offset: 0x3DE2BB1 VA: 0x3DE2AB0
	|-List<ValueTuple<Int32Enum, int>>.RemoveRange
	|
	|-RVA: 0x3DE5CC0 Offset: 0x3DE5DC1 VA: 0x3DE5CC0
	|-List<ValueTuple<object, ValueTuple<object, int>>>.RemoveRange
	|
	|-RVA: 0x3DE8BE0 Offset: 0x3DE8CE1 VA: 0x3DE8BE0
	|-List<ValueTuple<object, int>>.RemoveRange
	|
	|-RVA: 0x3DEBBE0 Offset: 0x3DEBCE1 VA: 0x3DEBBE0
	|-List<ValueTuple<Vector3, float>>.RemoveRange
	|
	|-RVA: 0x3DEEB00 Offset: 0x3DEEC01 VA: 0x3DEEB00
	|-List<ValueTuple<object, Int32Enum, int>>.RemoveRange
	|
	|-RVA: 0x3DF1D10 Offset: 0x3DF1E11 VA: 0x3DF1D10
	|-List<ValueTuple<object, int, int, int>>.RemoveRange
	|
	|-RVA: 0x3DF4B20 Offset: 0x3DF4C21 VA: 0x3DF4B20
	|-List<AnimatorClipInfo>.RemoveRange
	|
	|-RVA: 0x3DF7D30 Offset: 0x3DF7E31 VA: 0x3DF7D30
	|-List<AsyncOperationHandle>.RemoveRange
	|
	|-RVA: 0x3DFAF20 Offset: 0x3DFB021 VA: 0x3DFAF20
	|-List<BoneWeight>.RemoveRange
	|
	|-RVA: 0x3DFDD50 Offset: 0x3DFDE51 VA: 0x3DFDD50
	|-List<bool>.RemoveRange
	|
	|-RVA: 0x3E7B290 Offset: 0x3E7B391 VA: 0x3E7B290
	|-List<byte>.RemoveRange
	|
	|-RVA: 0x3E7E1B0 Offset: 0x3E7E2B1 VA: 0x3E7E1B0
	|-List<CameraInfo>.RemoveRange
	|
	|-RVA: 0x3E80FB0 Offset: 0x3E810B1 VA: 0x3E80FB0
	|-List<char>.RemoveRange
	|
	|-RVA: 0x3E83FB0 Offset: 0x3E840B1 VA: 0x3E83FB0
	|-List<Color>.RemoveRange
	|
	|-RVA: 0x3E86DC0 Offset: 0x3E86EC1 VA: 0x3E86DC0
	|-List<Color32>.RemoveRange
	|
	|-RVA: 0x3E89CE0 Offset: 0x3E89DE1 VA: 0x3E89CE0
	|-List<ConstraintSource>.RemoveRange
	|
	|-RVA: 0x3E8CEF0 Offset: 0x3E8CFF1 VA: 0x3E8CEF0
	|-List<ContourVertex>.RemoveRange
	|
	|-RVA: 0x3E900D0 Offset: 0x3E901D1 VA: 0x3E900D0
	|-List<DataStoreRatingInfo>.RemoveRange
	|
	|-RVA: 0x3E92EE0 Offset: 0x3E92FE1 VA: 0x3E92EE0
	|-List<DataStoreResult>.RemoveRange
	|
	|-RVA: 0x3E95CF0 Offset: 0x3E95DF1 VA: 0x3E95CF0
	|-List<DateTime>.RemoveRange
	|
	|-RVA: 0x3E98BD0 Offset: 0x3E98CD1 VA: 0x3E98BD0
	|-List<DateTimeOffset>.RemoveRange
	|
	|-RVA: 0x3E9BAB0 Offset: 0x3E9BBB1 VA: 0x3E9BAB0
	|-List<Decimal>.RemoveRange
	|
	|-RVA: 0x3E9EEF0 Offset: 0x3E9EFF1 VA: 0x3E9EEF0
	|-List<DiagnosticEvent>.RemoveRange
	|
	|-RVA: 0x3EA1D10 Offset: 0x3EA1E11 VA: 0x3EA1D10
	|-List<double>.RemoveRange
	|
	|-RVA: 0x3E12BB0 Offset: 0x3E12CB1 VA: 0x3E12BB0
	|-List<ForecastFishData>.RemoveRange
	|-List<object>.RemoveRange
	|-List<RegexNode>.RemoveRange
	|-List<Texture2D>.RemoveRange
	|-List<RegexCharClass.SingleRange>.RemoveRange
	|
	|-RVA: 0x3EA50A0 Offset: 0x3EA51A1 VA: 0x3EA50A0
	|-List<Friend>.RemoveRange
	|
	|-RVA: 0x3EA7F80 Offset: 0x3EA8081 VA: 0x3EA7F80
	|-List<GlyphRect>.RemoveRange
	|
	|-RVA: 0x3EAAD80 Offset: 0x3EAAE81 VA: 0x3EAAD80
	|-List<short>.RemoveRange
	|
	|-RVA: 0x3EADB80 Offset: 0x3EADC81 VA: 0x3EADB80
	|-List<int>.RemoveRange
	|
	|-RVA: 0x3EB0980 Offset: 0x3EB0A81 VA: 0x3EB0980
	|-List<Int32Enum>.RemoveRange
	|-List<RegexOptions>.RemoveRange
	|
	|-RVA: 0x3EB3780 Offset: 0x3EB3881 VA: 0x3EB3780
	|-List<long>.RemoveRange
	|
	|-RVA: 0x3E00B50 Offset: 0x3E00C51 VA: 0x3E00B50
	|-List<IntPtr>.RemoveRange
	|
	|-RVA: 0x3E03A70 Offset: 0x3E03B71 VA: 0x3E03A70
	|-List<InterpretedFrameInfo>.RemoveRange
	|
	|-RVA: 0x3E06C50 Offset: 0x3E06D51 VA: 0x3E06C50
	|-List<IntervalTreeNode>.RemoveRange
	|
	|-RVA: 0x3E09A60 Offset: 0x3E09B61 VA: 0x3E09A60
	|-List<LengthLimitProperties>.RemoveRange
	|
	|-RVA: 0x3E0C870 Offset: 0x3E0C971 VA: 0x3E0C870
	|-List<MapPos>.RemoveRange
	|
	|-RVA: 0x3E0FDF0 Offset: 0x3E0FEF1 VA: 0x3E0FDF0
	|-List<Matrix4x4>.RemoveRange
	|
	|-RVA: 0x3E15FF0 Offset: 0x3E160F1 VA: 0x3E15FF0
	|-List<ObjectInitializationData>.RemoveRange
	|
	|-RVA: 0x3E19210 Offset: 0x3E19311 VA: 0x3E19210
	|-List<PlayableBinding>.RemoveRange
	|
	|-RVA: 0x3E1C5E0 Offset: 0x3E1C6E1 VA: 0x3E1C5E0
	|-List<PlayerLoopSystem>.RemoveRange
	|
	|-RVA: 0x3DA6A80 Offset: 0x3DA6B81 VA: 0x3DA6A80
	|-List<PlayerLoopSystemInternal>.RemoveRange
	|
	|-RVA: 0x3DA99A0 Offset: 0x3DA9AA1 VA: 0x3DA99A0
	|-List<RangePositionInfo>.RemoveRange
	|
	|-RVA: 0x3DAC7B0 Offset: 0x3DAC8B1 VA: 0x3DAC7B0
	|-List<Ranking2ChartInfoInput>.RemoveRange
	|
	|-RVA: 0x3DAFBD0 Offset: 0x3DAFCD1 VA: 0x3DAFBD0
	|-List<RaycastHit2D>.RemoveRange
	|
	|-RVA: 0x3DB33E0 Offset: 0x3DB34E1 VA: 0x3DB33E0
	|-List<RaycastResult>.RemoveRange
	|
	|-RVA: 0x3DB63E0 Offset: 0x3DB64E1 VA: 0x3DB63E0
	|-List<Rect>.RemoveRange
	|
	|-RVA: 0x3DB91F0 Offset: 0x3DB92F1 VA: 0x3DB91F0
	|-List<RendererListHandle>.RemoveRange
	|
	|-RVA: 0x3DBC000 Offset: 0x3DBC101 VA: 0x3DBC000
	|-List<ResourceHandle>.RemoveRange
	|
	|-RVA: 0x3DBEE10 Offset: 0x3DBEF11 VA: 0x3DBEE10
	|-List<sbyte>.RemoveRange
	|
	|-RVA: 0x3DC1C20 Offset: 0x3DC1D21 VA: 0x3DC1C20
	|-List<ShaderTagId>.RemoveRange
	|
	|-RVA: 0x3E3D890 Offset: 0x3E3D991 VA: 0x3E3D890
	|-List<float>.RemoveRange
	|
	|-RVA: 0x3E41570 Offset: 0x3E41671 VA: 0x3E41570
	|-List<SphericalHarmonicsL2>.RemoveRange
	|
	|-RVA: 0x3E44960 Offset: 0x3E44A61 VA: 0x3E44960
	|-List<SubMeshDescriptor>.RemoveRange
	|
	|-RVA: 0x3E47880 Offset: 0x3E47981 VA: 0x3E47880
	|-List<TablePair>.RemoveRange
	|
	|-RVA: 0x3E4A690 Offset: 0x3E4A791 VA: 0x3E4A690
	|-List<TimeSpan>.RemoveRange
	|
	|-RVA: 0x3E4D670 Offset: 0x3E4D771 VA: 0x3E4D670
	|-List<UICharInfo>.RemoveRange
	|
	|-RVA: 0x3E50550 Offset: 0x3E50651 VA: 0x3E50550
	|-List<UILineInfo>.RemoveRange
	|
	|-RVA: 0x3E54230 Offset: 0x3E54331 VA: 0x3E54230
	|-List<UIVertex>.RemoveRange
	|
	|-RVA: 0x3E57030 Offset: 0x3E57131 VA: 0x3E57030
	|-List<ushort>.RemoveRange
	|
	|-RVA: 0x3E59E30 Offset: 0x3E59F31 VA: 0x3E59E30
	|-List<uint>.RemoveRange
	|
	|-RVA: 0x3DC4A20 Offset: 0x3DC4B21 VA: 0x3DC4A20
	|-List<ulong>.RemoveRange
	|
	|-RVA: 0x3DC78F0 Offset: 0x3DC79F1 VA: 0x3DC78F0
	|-List<Vector2>.RemoveRange
	|
	|-RVA: 0x3DCA8D0 Offset: 0x3DCA9D1 VA: 0x3DCA8D0
	|-List<Vector3>.RemoveRange
	|
	|-RVA: 0x3DCD8D0 Offset: 0x3DCD9D1 VA: 0x3DCD8D0
	|-List<Vector4>.RemoveRange
	|
	|-RVA: 0x3DD07B0 Offset: 0x3DD08B1 VA: 0x3DD07B0
	|-List<VertexAttributeDescriptor>.RemoveRange
	|
	|-RVA: 0x3DD36D0 Offset: 0x3DD37D1 VA: 0x3DD36D0
	|-List<X509ChainStatus>.RemoveRange
	|
	|-RVA: 0x3DD6AC0 Offset: 0x3DD6BC1 VA: 0x3DD6AC0
	|-List<XRView>.RemoveRange
	|
	|-RVA: 0x3DD99E0 Offset: 0x3DD9AE1 VA: 0x3DD99E0
	|-List<AmiiboSequence.GainItemData>.RemoveRange
	|
	|-RVA: 0x3DDCD80 Offset: 0x3DDCE81 VA: 0x3DDCD80
	|-List<AnimationOutputWeightProcessor.WeightInfo>.RemoveRange
	|
	|-RVA: 0x3DDFCA0 Offset: 0x3DDFDA1 VA: 0x3DDFCA0
	|-List<ArenaOrderSequence.GodInfo>.RemoveRange
	|
	|-RVA: 0x3E1F500 Offset: 0x3E1F601 VA: 0x3E1F500
	|-List<BattleInfo.SupportData>.RemoveRange
	|
	|-RVA: 0x3E22420 Offset: 0x3E22521 VA: 0x3E22420
	|-List<BeforeRenderHelper.OrderBlock>.RemoveRange
	|
	|-RVA: 0x3E25650 Offset: 0x3E25751 VA: 0x3E25650
	|-List<Camera.RenderRequest>.RemoveRange
	|
	|-RVA: 0x3E28570 Offset: 0x3E28671 VA: 0x3E28570
	|-List<CameraState.CustomBlendable>.RemoveRange
	|
	|-RVA: 0x3E2B380 Offset: 0x3E2B481 VA: 0x3E2B380
	|-List<CinemachineClearShot.Pair>.RemoveRange
	|
	|-RVA: 0x3E2E190 Offset: 0x3E2E291 VA: 0x3E2E190
	|-List<CinemachineStateDrivenCamera.HashPair>.RemoveRange
	|
	|-RVA: 0x3E313B0 Offset: 0x3E314B1 VA: 0x3E313B0
	|-List<DelayedActionManager.DelegateInfo>.RemoveRange
	|
	|-RVA: 0x3E347A0 Offset: 0x3E348A1 VA: 0x3E347A0
	|-List<Detail.AsyncResultInt>.RemoveRange
	|
	|-RVA: 0x3E37680 Offset: 0x3E37781 VA: 0x3E37680
	|-List<Detail.CppArray>.RemoveRange
	|
	|-RVA: 0x3E3AA70 Offset: 0x3E3AB71 VA: 0x3E3AA70
	|-List<Detail.NotificationEventInt>.RemoveRange
	|
	|-RVA: 0x3E5CD50 Offset: 0x3E5CE51 VA: 0x3E5CD50
	|-List<DragonRideTargetGroup.ChainParam>.RemoveRange
	|
	|-RVA: 0x3E5FF60 Offset: 0x3E60061 VA: 0x3E5FF60
	|-List<GmapPathAdjuster.TargetModel>.RemoveRange
	|
	|-RVA: 0x3E63170 Offset: 0x3E63271 VA: 0x3E63170
	|-List<GmapSpotAdjuster.TargetModel>.RemoveRange
	|
	|-RVA: 0x3E66380 Offset: 0x3E66481 VA: 0x3E66380
	|-List<HubFastTravel.Location>.RemoveRange
	|
	|-RVA: 0x3E697C0 Offset: 0x3E698C1 VA: 0x3E697C0
	|-List<HubLensFlare.Flare>.RemoveRange
	|
	|-RVA: 0x3E6C6E0 Offset: 0x3E6C7E1 VA: 0x3E6C6E0
	|-List<InventoryPoolItemMenuContent.KindBgNameClass>.RemoveRange
	|
	|-RVA: 0x3E6F4F0 Offset: 0x3E6F5F1 VA: 0x3E6F4F0
	|-List<Map.Pos>.RemoveRange
	|
	|-RVA: 0x3E723D0 Offset: 0x3E724D1 VA: 0x3E723D0
	|-List<MapImage.BackupTerrain>.RemoveRange
	|
	|-RVA: 0x3E75270 Offset: 0x3E75371 VA: 0x3E75270
	|-List<MapImageRange.Pos>.RemoveRange
	|
	|-RVA: 0x3E78480 Offset: 0x3E78581 VA: 0x3E78480
	|-List<MapMind.Target>.RemoveRange
	|
	|-RVA: 0x3D88050 Offset: 0x3D88151 VA: 0x3D88050
	|-List<MapPanelDebug.Entity>.RemoveRange
	|
	|-RVA: 0x3D8AE60 Offset: 0x3D8AF61 VA: 0x3D8AE60
	|-List<NexRanking.Data>.RemoveRange
	|
	|-RVA: 0x3D8DD40 Offset: 0x3D8DE41 VA: 0x3D8DD40
	|-List<NexVersus.RatingData>.RemoveRange
	|
	|-RVA: 0x3D90C60 Offset: 0x3D90D61 VA: 0x3D90C60
	|-List<PackedPlayModeBuildLogs.RuntimeBuildLog>.RemoveRange
	|
	|-RVA: 0x3D94010 Offset: 0x3D94111 VA: 0x3D94010
	|-List<ParticleSystem.Particle>.RemoveRange
	|
	|-RVA: 0x3D96E20 Offset: 0x3D96F21 VA: 0x3D96E20
	|-List<RangeData.Offset>.RemoveRange
	|
	|-RVA: 0x3D9A040 Offset: 0x3D9A141 VA: 0x3D9A040
	|-List<RenderGraphDebugData.PassDebugData>.RemoveRange
	|
	|-RVA: 0x3D9D410 Offset: 0x3D9D511 VA: 0x3D9D410
	|-List<RenderGraphDebugData.ResourceDebugData>.RemoveRange
	|
	|-RVA: 0x3DA0330 Offset: 0x3DA0431 VA: 0x3DA0330
	|-List<RingCleaningUnitSelectMenu.GodParam>.RemoveRange
	|
	|-RVA: 0x3DA36B0 Offset: 0x3DA37B1 VA: 0x3DA36B0
	|-List<ShadowUtility.Edge>.RemoveRange
	|
	|-RVA: 0x3D15990 Offset: 0x3D15A91 VA: 0x3D15990
	|-List<SkillArray.Entity>.RemoveRange
	|
	|-RVA: 0x3D18F50 Offset: 0x3D19051 VA: 0x3D18F50
	|-List<TexturePacker_JsonArray.Frame>.RemoveRange
	|
	|-RVA: 0x3D1C180 Offset: 0x3D1C281 VA: 0x3D1C180
	|-List<TimeNotificationBehaviour.NotificationEntry>.RemoveRange
	|
	|-RVA: 0x3D1F390 Offset: 0x3D1F491 VA: 0x3D1F390
	|-List<UnitySynchronizationContext.WorkRequest>.RemoveRange
	|
	|-RVA: 0x3D222B0 Offset: 0x3D223B1 VA: 0x3D222B0
	|-List<XmlSchemaObjectTable.XmlSchemaObjectEntry>.RemoveRange
	|
	|-RVA: 0x3D251D0 Offset: 0x3D252D1 VA: 0x3D251D0
	|-List<AssetBundleBuildMap.AssetBundleEntry.AssetPathString>.RemoveRange
	|
	|-RVA: 0x3D285F0 Offset: 0x3D286F1 VA: 0x3D285F0
	|-List<Detail.DataStore.DataStoreChangeMetaParamInt>.RemoveRange
	|
	|-RVA: 0x3D2B4D0 Offset: 0x3D2B5D1 VA: 0x3D2B4D0
	|-List<Detail.DataStore.DataStoreDeleteParamInt>.RemoveRange
	|
	|-RVA: 0x3D2E870 Offset: 0x3D2E971 VA: 0x3D2E870
	|-List<Detail.DataStore.DataStoreGetMetaParamInt>.RemoveRange
	|
	|-RVA: 0x3D31C60 Offset: 0x3D31D61 VA: 0x3D31C60
	|-List<Detail.DataStore.DataStoreMetaInfoInt>.RemoveRange
	|
	|-RVA: 0x3CF6290 Offset: 0x3CF6391 VA: 0x3CF6290
	|-List<Detail.DataStore.DataStorePasswordInfoInt>.RemoveRange
	|
	|-RVA: 0x3CF9470 Offset: 0x3CF9571 VA: 0x3CF9470
	|-List<Detail.DataStore.DataStorePersistenceInfoInt>.RemoveRange
	|
	|-RVA: 0x3CFC820 Offset: 0x3CFC921 VA: 0x3CFC820
	|-List<Detail.DataStore.DataStorePreparePostParamInt>.RemoveRange
	|
	|-RVA: 0x3CFF700 Offset: 0x3CFF801 VA: 0x3CFF700
	|-List<Detail.DataStore.DataStoreRateObjectParamInt>.RemoveRange
	|
	|-RVA: 0x3D028F0 Offset: 0x3D029F1 VA: 0x3D028F0
	|-List<Detail.DataStore.DataStoreRatingInitParamInt>.RemoveRange
	|
	|-RVA: 0x3D057D0 Offset: 0x3D058D1 VA: 0x3D057D0
	|-List<Detail.DataStore.DataStoreRatingTargetInt>.RemoveRange
	|
	|-RVA: 0x3D08DB0 Offset: 0x3D08EB1 VA: 0x3D08DB0
	|-List<Detail.Ranking.RankingCachedResultInt>.RemoveRange
	|
	|-RVA: 0x3D0BC90 Offset: 0x3D0BD91 VA: 0x3D0BC90
	|-List<Detail.Ranking.RankingOrderParamInt>.RemoveRange
	|
	|-RVA: 0x3D0F210 Offset: 0x3D0F311 VA: 0x3D0F210
	|-List<Detail.Ranking.RankingRankDataInt>.RemoveRange
	|
	|-RVA: 0x3D12B80 Offset: 0x3D12C81 VA: 0x3D12B80
	|-List<Detail.Ranking2.Ranking2ChartInfoInt>.RemoveRange
	|
	|-RVA: 0x3D69190 Offset: 0x3D69291 VA: 0x3D69190
	|-List<Detail.Ranking2.Ranking2RankDataInt>.RemoveRange
	|
	|-RVA: 0x3D6C070 Offset: 0x3D6C171 VA: 0x3D6C070
	|-List<Detail.Ranking2.Ranking2ScoreDataInt>.RemoveRange
	|
	|-RVA: 0x3D6F260 Offset: 0x3D6F361 VA: 0x3D6F260
	|-List<Detail.Screening.ScreeningContextInfoInt>.RemoveRange
	|
	|-RVA: 0x3D72A30 Offset: 0x3D72B31 VA: 0x3D72A30
	|-List<Detail.Subscriber.SubscriberContentInt>.RemoveRange
	|
	|-RVA: 0x3D75C10 Offset: 0x3D75D11 VA: 0x3D75C10
	|-List<Detail.Subscriber.SubscriberGetContentParamInt>.RemoveRange
	|
	|-RVA: 0x3D78FB0 Offset: 0x3D790B1 VA: 0x3D78FB0
	|-List<Detail.Subscriber.SubscriberUserStatusInfoInt>.RemoveRange
	|
	|-RVA: 0x3D7C190 Offset: 0x3D7C291 VA: 0x3D7C190
	|-List<Detail.Subscriber.SubscriberUserStatusParamInt>.RemoveRange
	|
	|-RVA: 0x3D7EFA0 Offset: 0x3D7F0A1 VA: 0x3D7EFA0
	|-List<Detail.Utility.IntegerSettings>.RemoveRange
	|
	|-RVA: 0x3D81E80 Offset: 0x3D81F81 VA: 0x3D81E80
	|-List<Detail.Utility.UniqueIdInfoInt>.RemoveRange
	|
	|-RVA: 0x3D84E70 Offset: 0x3D84F71 VA: 0x3D84E70
	|-List<MapHistory.Rewind.LatestInspectorData>.RemoveRange
	|
	|-RVA: 0x3061130 Offset: 0x3061231 VA: 0x3061130
	|-List<MapHistory.Rewind.WorkTerrainData>.RemoveRange
	|
	|-RVA: 0x3064050 Offset: 0x3064151 VA: 0x3064050
	|-List<MapSkill.AroundCalculator.Result>.RemoveRange
	|
	|-RVA: 0x30673D0 Offset: 0x30674D1 VA: 0x30673D0
	|-List<TargetPositionCache.CacheCurve.Item>.RemoveRange
	|
	|-RVA: 0x306A7F0 Offset: 0x306A8F1 VA: 0x306A7F0
	|-List<TargetPositionCache.CacheEntry.RecordingItem>.RemoveRange
	*/

	// RVA: -1 Offset: -1
	public void Reverse() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3B0D050 Offset: 0x3B0D151 VA: 0x3B0D050
	|-List<IntervalTree.Entry<object>>.Reverse
	|
	|-RVA: 0x3B0FF70 Offset: 0x3B10071 VA: 0x3B0FF70
	|-List<KeyValuePair<DateTime, object>>.Reverse
	|
	|-RVA: 0x3B12E90 Offset: 0x3B12F91 VA: 0x3B12E90
	|-List<KeyValuePair<int, object>>.Reverse
	|
	|-RVA: 0x3B160B0 Offset: 0x3B161B1 VA: 0x3B160B0
	|-List<KeyValuePair<object, ValueTuple<int, DateTime, object>>>.Reverse
	|
	|-RVA: 0x3B18FD0 Offset: 0x3B190D1 VA: 0x3B18FD0
	|-List<KeyValuePair<object, object>>.Reverse
	|
	|-RVA: 0x3B1C1E0 Offset: 0x3B1C2E1 VA: 0x3B1C1E0
	|-List<CommonBattleSequence.Reliance<object>>.Reverse
	|
	|-RVA: 0x3B1F100 Offset: 0x3B1F201 VA: 0x3B1F100
	|-List<RenderGraphResourcePool.ResourceLogInfo<object>>.Reverse
	|
	|-RVA: 0x3B22020 Offset: 0x3B22121 VA: 0x3B22020
	|-List<ValueTuple<int, object>>.Reverse
	|
	|-RVA: 0x3DE2BA0 Offset: 0x3DE2CA1 VA: 0x3DE2BA0
	|-List<ValueTuple<Int32Enum, int>>.Reverse
	|
	|-RVA: 0x3DE5DB0 Offset: 0x3DE5EB1 VA: 0x3DE5DB0
	|-List<ValueTuple<object, ValueTuple<object, int>>>.Reverse
	|
	|-RVA: 0x3DE8CD0 Offset: 0x3DE8DD1 VA: 0x3DE8CD0
	|-List<ValueTuple<object, int>>.Reverse
	|
	|-RVA: 0x3DEBCD0 Offset: 0x3DEBDD1 VA: 0x3DEBCD0
	|-List<ValueTuple<Vector3, float>>.Reverse
	|
	|-RVA: 0x3DEEBF0 Offset: 0x3DEECF1 VA: 0x3DEEBF0
	|-List<ValueTuple<object, Int32Enum, int>>.Reverse
	|
	|-RVA: 0x3DF1E00 Offset: 0x3DF1F01 VA: 0x3DF1E00
	|-List<ValueTuple<object, int, int, int>>.Reverse
	|
	|-RVA: 0x3DF4C10 Offset: 0x3DF4D11 VA: 0x3DF4C10
	|-List<AnimatorClipInfo>.Reverse
	|
	|-RVA: 0x3DF7E20 Offset: 0x3DF7F21 VA: 0x3DF7E20
	|-List<AsyncOperationHandle>.Reverse
	|
	|-RVA: 0x3DFB010 Offset: 0x3DFB111 VA: 0x3DFB010
	|-List<BoneWeight>.Reverse
	|
	|-RVA: 0x3DFDE40 Offset: 0x3DFDF41 VA: 0x3DFDE40
	|-List<bool>.Reverse
	|
	|-RVA: 0x3E7B380 Offset: 0x3E7B481 VA: 0x3E7B380
	|-List<byte>.Reverse
	|
	|-RVA: 0x3E7E2A0 Offset: 0x3E7E3A1 VA: 0x3E7E2A0
	|-List<CameraInfo>.Reverse
	|
	|-RVA: 0x3E810A0 Offset: 0x3E811A1 VA: 0x3E810A0
	|-List<char>.Reverse
	|
	|-RVA: 0x3E840A0 Offset: 0x3E841A1 VA: 0x3E840A0
	|-List<Color>.Reverse
	|
	|-RVA: 0x3E86EB0 Offset: 0x3E86FB1 VA: 0x3E86EB0
	|-List<Color32>.Reverse
	|
	|-RVA: 0x3E89DD0 Offset: 0x3E89ED1 VA: 0x3E89DD0
	|-List<ConstraintSource>.Reverse
	|
	|-RVA: 0x3E8CFE0 Offset: 0x3E8D0E1 VA: 0x3E8CFE0
	|-List<ContourVertex>.Reverse
	|
	|-RVA: 0x3E901C0 Offset: 0x3E902C1 VA: 0x3E901C0
	|-List<DataStoreRatingInfo>.Reverse
	|
	|-RVA: 0x3E92FD0 Offset: 0x3E930D1 VA: 0x3E92FD0
	|-List<DataStoreResult>.Reverse
	|
	|-RVA: 0x3E95DE0 Offset: 0x3E95EE1 VA: 0x3E95DE0
	|-List<DateTime>.Reverse
	|
	|-RVA: 0x3E98CC0 Offset: 0x3E98DC1 VA: 0x3E98CC0
	|-List<DateTimeOffset>.Reverse
	|
	|-RVA: 0x3E9BBA0 Offset: 0x3E9BCA1 VA: 0x3E9BBA0
	|-List<Decimal>.Reverse
	|
	|-RVA: 0x3E9EFE0 Offset: 0x3E9F0E1 VA: 0x3E9EFE0
	|-List<DiagnosticEvent>.Reverse
	|
	|-RVA: 0x3EA1E00 Offset: 0x3EA1F01 VA: 0x3EA1E00
	|-List<double>.Reverse
	|
	|-RVA: 0x3E12CA0 Offset: 0x3E12DA1 VA: 0x3E12CA0
	|-List<ForecastFishData>.Reverse
	|-List<MethodInfo>.Reverse
	|-List<object>.Reverse
	|
	|-RVA: 0x3EA5190 Offset: 0x3EA5291 VA: 0x3EA5190
	|-List<Friend>.Reverse
	|
	|-RVA: 0x3EA8070 Offset: 0x3EA8171 VA: 0x3EA8070
	|-List<GlyphRect>.Reverse
	|
	|-RVA: 0x3EAAE70 Offset: 0x3EAAF71 VA: 0x3EAAE70
	|-List<short>.Reverse
	|
	|-RVA: 0x3EADC70 Offset: 0x3EADD71 VA: 0x3EADC70
	|-List<int>.Reverse
	|
	|-RVA: 0x3EB0A70 Offset: 0x3EB0B71 VA: 0x3EB0A70
	|-List<Int32Enum>.Reverse
	|
	|-RVA: 0x3EB3870 Offset: 0x3EB3971 VA: 0x3EB3870
	|-List<long>.Reverse
	|
	|-RVA: 0x3E00C40 Offset: 0x3E00D41 VA: 0x3E00C40
	|-List<IntPtr>.Reverse
	|
	|-RVA: 0x3E03B60 Offset: 0x3E03C61 VA: 0x3E03B60
	|-List<InterpretedFrameInfo>.Reverse
	|
	|-RVA: 0x3E06D40 Offset: 0x3E06E41 VA: 0x3E06D40
	|-List<IntervalTreeNode>.Reverse
	|
	|-RVA: 0x3E09B50 Offset: 0x3E09C51 VA: 0x3E09B50
	|-List<LengthLimitProperties>.Reverse
	|
	|-RVA: 0x3E0C960 Offset: 0x3E0CA61 VA: 0x3E0C960
	|-List<MapPos>.Reverse
	|
	|-RVA: 0x3E0FEE0 Offset: 0x3E0FFE1 VA: 0x3E0FEE0
	|-List<Matrix4x4>.Reverse
	|
	|-RVA: 0x3E160E0 Offset: 0x3E161E1 VA: 0x3E160E0
	|-List<ObjectInitializationData>.Reverse
	|
	|-RVA: 0x3E19300 Offset: 0x3E19401 VA: 0x3E19300
	|-List<PlayableBinding>.Reverse
	|
	|-RVA: 0x3E1C6D0 Offset: 0x3E1C7D1 VA: 0x3E1C6D0
	|-List<PlayerLoopSystem>.Reverse
	|
	|-RVA: 0x3DA6B70 Offset: 0x3DA6C71 VA: 0x3DA6B70
	|-List<PlayerLoopSystemInternal>.Reverse
	|
	|-RVA: 0x3DA9A90 Offset: 0x3DA9B91 VA: 0x3DA9A90
	|-List<RangePositionInfo>.Reverse
	|
	|-RVA: 0x3DAC8A0 Offset: 0x3DAC9A1 VA: 0x3DAC8A0
	|-List<Ranking2ChartInfoInput>.Reverse
	|
	|-RVA: 0x3DAFCC0 Offset: 0x3DAFDC1 VA: 0x3DAFCC0
	|-List<RaycastHit2D>.Reverse
	|
	|-RVA: 0x3DB34D0 Offset: 0x3DB35D1 VA: 0x3DB34D0
	|-List<RaycastResult>.Reverse
	|
	|-RVA: 0x3DB64D0 Offset: 0x3DB65D1 VA: 0x3DB64D0
	|-List<Rect>.Reverse
	|
	|-RVA: 0x3DB92E0 Offset: 0x3DB93E1 VA: 0x3DB92E0
	|-List<RendererListHandle>.Reverse
	|
	|-RVA: 0x3DBC0F0 Offset: 0x3DBC1F1 VA: 0x3DBC0F0
	|-List<ResourceHandle>.Reverse
	|
	|-RVA: 0x3DBEF00 Offset: 0x3DBF001 VA: 0x3DBEF00
	|-List<sbyte>.Reverse
	|
	|-RVA: 0x3DC1D10 Offset: 0x3DC1E11 VA: 0x3DC1D10
	|-List<ShaderTagId>.Reverse
	|
	|-RVA: 0x3E3D980 Offset: 0x3E3DA81 VA: 0x3E3D980
	|-List<float>.Reverse
	|
	|-RVA: 0x3E41660 Offset: 0x3E41761 VA: 0x3E41660
	|-List<SphericalHarmonicsL2>.Reverse
	|
	|-RVA: 0x3E44A50 Offset: 0x3E44B51 VA: 0x3E44A50
	|-List<SubMeshDescriptor>.Reverse
	|
	|-RVA: 0x3E47970 Offset: 0x3E47A71 VA: 0x3E47970
	|-List<TablePair>.Reverse
	|
	|-RVA: 0x3E4A780 Offset: 0x3E4A881 VA: 0x3E4A780
	|-List<TimeSpan>.Reverse
	|
	|-RVA: 0x3E4D760 Offset: 0x3E4D861 VA: 0x3E4D760
	|-List<UICharInfo>.Reverse
	|
	|-RVA: 0x3E50640 Offset: 0x3E50741 VA: 0x3E50640
	|-List<UILineInfo>.Reverse
	|
	|-RVA: 0x3E54320 Offset: 0x3E54421 VA: 0x3E54320
	|-List<UIVertex>.Reverse
	|
	|-RVA: 0x3E57120 Offset: 0x3E57221 VA: 0x3E57120
	|-List<ushort>.Reverse
	|
	|-RVA: 0x3E59F20 Offset: 0x3E5A021 VA: 0x3E59F20
	|-List<uint>.Reverse
	|
	|-RVA: 0x3DC4B10 Offset: 0x3DC4C11 VA: 0x3DC4B10
	|-List<ulong>.Reverse
	|
	|-RVA: 0x3DC79E0 Offset: 0x3DC7AE1 VA: 0x3DC79E0
	|-List<Vector2>.Reverse
	|
	|-RVA: 0x3DCA9C0 Offset: 0x3DCAAC1 VA: 0x3DCA9C0
	|-List<Vector3>.Reverse
	|
	|-RVA: 0x3DCD9C0 Offset: 0x3DCDAC1 VA: 0x3DCD9C0
	|-List<Vector4>.Reverse
	|
	|-RVA: 0x3DD08A0 Offset: 0x3DD09A1 VA: 0x3DD08A0
	|-List<VertexAttributeDescriptor>.Reverse
	|
	|-RVA: 0x3DD37C0 Offset: 0x3DD38C1 VA: 0x3DD37C0
	|-List<X509ChainStatus>.Reverse
	|
	|-RVA: 0x3DD6BB0 Offset: 0x3DD6CB1 VA: 0x3DD6BB0
	|-List<XRView>.Reverse
	|
	|-RVA: 0x3DD9AD0 Offset: 0x3DD9BD1 VA: 0x3DD9AD0
	|-List<AmiiboSequence.GainItemData>.Reverse
	|
	|-RVA: 0x3DDCE70 Offset: 0x3DDCF71 VA: 0x3DDCE70
	|-List<AnimationOutputWeightProcessor.WeightInfo>.Reverse
	|
	|-RVA: 0x3DDFD90 Offset: 0x3DDFE91 VA: 0x3DDFD90
	|-List<ArenaOrderSequence.GodInfo>.Reverse
	|
	|-RVA: 0x3E1F5F0 Offset: 0x3E1F6F1 VA: 0x3E1F5F0
	|-List<BattleInfo.SupportData>.Reverse
	|
	|-RVA: 0x3E22510 Offset: 0x3E22611 VA: 0x3E22510
	|-List<BeforeRenderHelper.OrderBlock>.Reverse
	|
	|-RVA: 0x3E25740 Offset: 0x3E25841 VA: 0x3E25740
	|-List<Camera.RenderRequest>.Reverse
	|
	|-RVA: 0x3E28660 Offset: 0x3E28761 VA: 0x3E28660
	|-List<CameraState.CustomBlendable>.Reverse
	|
	|-RVA: 0x3E2B470 Offset: 0x3E2B571 VA: 0x3E2B470
	|-List<CinemachineClearShot.Pair>.Reverse
	|
	|-RVA: 0x3E2E280 Offset: 0x3E2E381 VA: 0x3E2E280
	|-List<CinemachineStateDrivenCamera.HashPair>.Reverse
	|
	|-RVA: 0x3E314A0 Offset: 0x3E315A1 VA: 0x3E314A0
	|-List<DelayedActionManager.DelegateInfo>.Reverse
	|
	|-RVA: 0x3E34890 Offset: 0x3E34991 VA: 0x3E34890
	|-List<Detail.AsyncResultInt>.Reverse
	|
	|-RVA: 0x3E37770 Offset: 0x3E37871 VA: 0x3E37770
	|-List<Detail.CppArray>.Reverse
	|
	|-RVA: 0x3E3AB60 Offset: 0x3E3AC61 VA: 0x3E3AB60
	|-List<Detail.NotificationEventInt>.Reverse
	|
	|-RVA: 0x3E5CE40 Offset: 0x3E5CF41 VA: 0x3E5CE40
	|-List<DragonRideTargetGroup.ChainParam>.Reverse
	|
	|-RVA: 0x3E60050 Offset: 0x3E60151 VA: 0x3E60050
	|-List<GmapPathAdjuster.TargetModel>.Reverse
	|
	|-RVA: 0x3E63260 Offset: 0x3E63361 VA: 0x3E63260
	|-List<GmapSpotAdjuster.TargetModel>.Reverse
	|
	|-RVA: 0x3E66470 Offset: 0x3E66571 VA: 0x3E66470
	|-List<HubFastTravel.Location>.Reverse
	|
	|-RVA: 0x3E698B0 Offset: 0x3E699B1 VA: 0x3E698B0
	|-List<HubLensFlare.Flare>.Reverse
	|
	|-RVA: 0x3E6C7D0 Offset: 0x3E6C8D1 VA: 0x3E6C7D0
	|-List<InventoryPoolItemMenuContent.KindBgNameClass>.Reverse
	|
	|-RVA: 0x3E6F5E0 Offset: 0x3E6F6E1 VA: 0x3E6F5E0
	|-List<Map.Pos>.Reverse
	|
	|-RVA: 0x3E724C0 Offset: 0x3E725C1 VA: 0x3E724C0
	|-List<MapImage.BackupTerrain>.Reverse
	|
	|-RVA: 0x3E75360 Offset: 0x3E75461 VA: 0x3E75360
	|-List<MapImageRange.Pos>.Reverse
	|
	|-RVA: 0x3E78570 Offset: 0x3E78671 VA: 0x3E78570
	|-List<MapMind.Target>.Reverse
	|
	|-RVA: 0x3D88140 Offset: 0x3D88241 VA: 0x3D88140
	|-List<MapPanelDebug.Entity>.Reverse
	|
	|-RVA: 0x3D8AF50 Offset: 0x3D8B051 VA: 0x3D8AF50
	|-List<NexRanking.Data>.Reverse
	|
	|-RVA: 0x3D8DE30 Offset: 0x3D8DF31 VA: 0x3D8DE30
	|-List<NexVersus.RatingData>.Reverse
	|
	|-RVA: 0x3D90D50 Offset: 0x3D90E51 VA: 0x3D90D50
	|-List<PackedPlayModeBuildLogs.RuntimeBuildLog>.Reverse
	|
	|-RVA: 0x3D94100 Offset: 0x3D94201 VA: 0x3D94100
	|-List<ParticleSystem.Particle>.Reverse
	|
	|-RVA: 0x3D96F10 Offset: 0x3D97011 VA: 0x3D96F10
	|-List<RangeData.Offset>.Reverse
	|
	|-RVA: 0x3D9A130 Offset: 0x3D9A231 VA: 0x3D9A130
	|-List<RenderGraphDebugData.PassDebugData>.Reverse
	|
	|-RVA: 0x3D9D500 Offset: 0x3D9D601 VA: 0x3D9D500
	|-List<RenderGraphDebugData.ResourceDebugData>.Reverse
	|
	|-RVA: 0x3DA0420 Offset: 0x3DA0521 VA: 0x3DA0420
	|-List<RingCleaningUnitSelectMenu.GodParam>.Reverse
	|
	|-RVA: 0x3DA37A0 Offset: 0x3DA38A1 VA: 0x3DA37A0
	|-List<ShadowUtility.Edge>.Reverse
	|
	|-RVA: 0x3D15A80 Offset: 0x3D15B81 VA: 0x3D15A80
	|-List<SkillArray.Entity>.Reverse
	|
	|-RVA: 0x3D19040 Offset: 0x3D19141 VA: 0x3D19040
	|-List<TexturePacker_JsonArray.Frame>.Reverse
	|
	|-RVA: 0x3D1C270 Offset: 0x3D1C371 VA: 0x3D1C270
	|-List<TimeNotificationBehaviour.NotificationEntry>.Reverse
	|
	|-RVA: 0x3D1F480 Offset: 0x3D1F581 VA: 0x3D1F480
	|-List<UnitySynchronizationContext.WorkRequest>.Reverse
	|
	|-RVA: 0x3D223A0 Offset: 0x3D224A1 VA: 0x3D223A0
	|-List<XmlSchemaObjectTable.XmlSchemaObjectEntry>.Reverse
	|
	|-RVA: 0x3D252C0 Offset: 0x3D253C1 VA: 0x3D252C0
	|-List<AssetBundleBuildMap.AssetBundleEntry.AssetPathString>.Reverse
	|
	|-RVA: 0x3D286E0 Offset: 0x3D287E1 VA: 0x3D286E0
	|-List<Detail.DataStore.DataStoreChangeMetaParamInt>.Reverse
	|
	|-RVA: 0x3D2B5C0 Offset: 0x3D2B6C1 VA: 0x3D2B5C0
	|-List<Detail.DataStore.DataStoreDeleteParamInt>.Reverse
	|
	|-RVA: 0x3D2E960 Offset: 0x3D2EA61 VA: 0x3D2E960
	|-List<Detail.DataStore.DataStoreGetMetaParamInt>.Reverse
	|
	|-RVA: 0x3D31D50 Offset: 0x3D31E51 VA: 0x3D31D50
	|-List<Detail.DataStore.DataStoreMetaInfoInt>.Reverse
	|
	|-RVA: 0x3CF6380 Offset: 0x3CF6481 VA: 0x3CF6380
	|-List<Detail.DataStore.DataStorePasswordInfoInt>.Reverse
	|
	|-RVA: 0x3CF9560 Offset: 0x3CF9661 VA: 0x3CF9560
	|-List<Detail.DataStore.DataStorePersistenceInfoInt>.Reverse
	|
	|-RVA: 0x3CFC910 Offset: 0x3CFCA11 VA: 0x3CFC910
	|-List<Detail.DataStore.DataStorePreparePostParamInt>.Reverse
	|
	|-RVA: 0x3CFF7F0 Offset: 0x3CFF8F1 VA: 0x3CFF7F0
	|-List<Detail.DataStore.DataStoreRateObjectParamInt>.Reverse
	|
	|-RVA: 0x3D029E0 Offset: 0x3D02AE1 VA: 0x3D029E0
	|-List<Detail.DataStore.DataStoreRatingInitParamInt>.Reverse
	|
	|-RVA: 0x3D058C0 Offset: 0x3D059C1 VA: 0x3D058C0
	|-List<Detail.DataStore.DataStoreRatingTargetInt>.Reverse
	|
	|-RVA: 0x3D08EA0 Offset: 0x3D08FA1 VA: 0x3D08EA0
	|-List<Detail.Ranking.RankingCachedResultInt>.Reverse
	|
	|-RVA: 0x3D0BD80 Offset: 0x3D0BE81 VA: 0x3D0BD80
	|-List<Detail.Ranking.RankingOrderParamInt>.Reverse
	|
	|-RVA: 0x3D0F300 Offset: 0x3D0F401 VA: 0x3D0F300
	|-List<Detail.Ranking.RankingRankDataInt>.Reverse
	|
	|-RVA: 0x3D12C70 Offset: 0x3D12D71 VA: 0x3D12C70
	|-List<Detail.Ranking2.Ranking2ChartInfoInt>.Reverse
	|
	|-RVA: 0x3D69280 Offset: 0x3D69381 VA: 0x3D69280
	|-List<Detail.Ranking2.Ranking2RankDataInt>.Reverse
	|
	|-RVA: 0x3D6C160 Offset: 0x3D6C261 VA: 0x3D6C160
	|-List<Detail.Ranking2.Ranking2ScoreDataInt>.Reverse
	|
	|-RVA: 0x3D6F350 Offset: 0x3D6F451 VA: 0x3D6F350
	|-List<Detail.Screening.ScreeningContextInfoInt>.Reverse
	|
	|-RVA: 0x3D72B20 Offset: 0x3D72C21 VA: 0x3D72B20
	|-List<Detail.Subscriber.SubscriberContentInt>.Reverse
	|
	|-RVA: 0x3D75D00 Offset: 0x3D75E01 VA: 0x3D75D00
	|-List<Detail.Subscriber.SubscriberGetContentParamInt>.Reverse
	|
	|-RVA: 0x3D790A0 Offset: 0x3D791A1 VA: 0x3D790A0
	|-List<Detail.Subscriber.SubscriberUserStatusInfoInt>.Reverse
	|
	|-RVA: 0x3D7C280 Offset: 0x3D7C381 VA: 0x3D7C280
	|-List<Detail.Subscriber.SubscriberUserStatusParamInt>.Reverse
	|
	|-RVA: 0x3D7F090 Offset: 0x3D7F191 VA: 0x3D7F090
	|-List<Detail.Utility.IntegerSettings>.Reverse
	|
	|-RVA: 0x3D81F70 Offset: 0x3D82071 VA: 0x3D81F70
	|-List<Detail.Utility.UniqueIdInfoInt>.Reverse
	|
	|-RVA: 0x3D84F60 Offset: 0x3D85061 VA: 0x3D84F60
	|-List<MapHistory.Rewind.LatestInspectorData>.Reverse
	|
	|-RVA: 0x3061220 Offset: 0x3061321 VA: 0x3061220
	|-List<MapHistory.Rewind.WorkTerrainData>.Reverse
	|
	|-RVA: 0x3064140 Offset: 0x3064241 VA: 0x3064140
	|-List<MapSkill.AroundCalculator.Result>.Reverse
	|
	|-RVA: 0x30674C0 Offset: 0x30675C1 VA: 0x30674C0
	|-List<TargetPositionCache.CacheCurve.Item>.Reverse
	|
	|-RVA: 0x306A8E0 Offset: 0x306A9E1 VA: 0x306A8E0
	|-List<TargetPositionCache.CacheEntry.RecordingItem>.Reverse
	*/

	// RVA: -1 Offset: -1
	public void Reverse(int index, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3B0D0A0 Offset: 0x3B0D1A1 VA: 0x3B0D0A0
	|-List<IntervalTree.Entry<object>>.Reverse
	|
	|-RVA: 0x3B0FFC0 Offset: 0x3B100C1 VA: 0x3B0FFC0
	|-List<KeyValuePair<DateTime, object>>.Reverse
	|
	|-RVA: 0x3B12EE0 Offset: 0x3B12FE1 VA: 0x3B12EE0
	|-List<KeyValuePair<int, object>>.Reverse
	|
	|-RVA: 0x3B16100 Offset: 0x3B16201 VA: 0x3B16100
	|-List<KeyValuePair<object, ValueTuple<int, DateTime, object>>>.Reverse
	|
	|-RVA: 0x3B19020 Offset: 0x3B19121 VA: 0x3B19020
	|-List<KeyValuePair<object, object>>.Reverse
	|
	|-RVA: 0x3B1C230 Offset: 0x3B1C331 VA: 0x3B1C230
	|-List<CommonBattleSequence.Reliance<object>>.Reverse
	|
	|-RVA: 0x3B1F150 Offset: 0x3B1F251 VA: 0x3B1F150
	|-List<RenderGraphResourcePool.ResourceLogInfo<object>>.Reverse
	|
	|-RVA: 0x3B22070 Offset: 0x3B22171 VA: 0x3B22070
	|-List<ValueTuple<int, object>>.Reverse
	|
	|-RVA: 0x3DE2BF0 Offset: 0x3DE2CF1 VA: 0x3DE2BF0
	|-List<ValueTuple<Int32Enum, int>>.Reverse
	|
	|-RVA: 0x3DE5E00 Offset: 0x3DE5F01 VA: 0x3DE5E00
	|-List<ValueTuple<object, ValueTuple<object, int>>>.Reverse
	|
	|-RVA: 0x3DE8D20 Offset: 0x3DE8E21 VA: 0x3DE8D20
	|-List<ValueTuple<object, int>>.Reverse
	|
	|-RVA: 0x3DEBD20 Offset: 0x3DEBE21 VA: 0x3DEBD20
	|-List<ValueTuple<Vector3, float>>.Reverse
	|
	|-RVA: 0x3DEEC40 Offset: 0x3DEED41 VA: 0x3DEEC40
	|-List<ValueTuple<object, Int32Enum, int>>.Reverse
	|
	|-RVA: 0x3DF1E50 Offset: 0x3DF1F51 VA: 0x3DF1E50
	|-List<ValueTuple<object, int, int, int>>.Reverse
	|
	|-RVA: 0x3DF4C60 Offset: 0x3DF4D61 VA: 0x3DF4C60
	|-List<AnimatorClipInfo>.Reverse
	|
	|-RVA: 0x3DF7E70 Offset: 0x3DF7F71 VA: 0x3DF7E70
	|-List<AsyncOperationHandle>.Reverse
	|
	|-RVA: 0x3DFB060 Offset: 0x3DFB161 VA: 0x3DFB060
	|-List<BoneWeight>.Reverse
	|
	|-RVA: 0x3DFDE90 Offset: 0x3DFDF91 VA: 0x3DFDE90
	|-List<bool>.Reverse
	|
	|-RVA: 0x3E7B3D0 Offset: 0x3E7B4D1 VA: 0x3E7B3D0
	|-List<byte>.Reverse
	|
	|-RVA: 0x3E7E2F0 Offset: 0x3E7E3F1 VA: 0x3E7E2F0
	|-List<CameraInfo>.Reverse
	|
	|-RVA: 0x3E810F0 Offset: 0x3E811F1 VA: 0x3E810F0
	|-List<char>.Reverse
	|
	|-RVA: 0x3E840F0 Offset: 0x3E841F1 VA: 0x3E840F0
	|-List<Color>.Reverse
	|
	|-RVA: 0x3E86F00 Offset: 0x3E87001 VA: 0x3E86F00
	|-List<Color32>.Reverse
	|
	|-RVA: 0x3E89E20 Offset: 0x3E89F21 VA: 0x3E89E20
	|-List<ConstraintSource>.Reverse
	|
	|-RVA: 0x3E8D030 Offset: 0x3E8D131 VA: 0x3E8D030
	|-List<ContourVertex>.Reverse
	|
	|-RVA: 0x3E90210 Offset: 0x3E90311 VA: 0x3E90210
	|-List<DataStoreRatingInfo>.Reverse
	|
	|-RVA: 0x3E93020 Offset: 0x3E93121 VA: 0x3E93020
	|-List<DataStoreResult>.Reverse
	|
	|-RVA: 0x3E95E30 Offset: 0x3E95F31 VA: 0x3E95E30
	|-List<DateTime>.Reverse
	|
	|-RVA: 0x3E98D10 Offset: 0x3E98E11 VA: 0x3E98D10
	|-List<DateTimeOffset>.Reverse
	|
	|-RVA: 0x3E9BBF0 Offset: 0x3E9BCF1 VA: 0x3E9BBF0
	|-List<Decimal>.Reverse
	|
	|-RVA: 0x3E9F030 Offset: 0x3E9F131 VA: 0x3E9F030
	|-List<DiagnosticEvent>.Reverse
	|
	|-RVA: 0x3EA1E50 Offset: 0x3EA1F51 VA: 0x3EA1E50
	|-List<double>.Reverse
	|
	|-RVA: 0x3EA51E0 Offset: 0x3EA52E1 VA: 0x3EA51E0
	|-List<Friend>.Reverse
	|
	|-RVA: 0x3EA80C0 Offset: 0x3EA81C1 VA: 0x3EA80C0
	|-List<GlyphRect>.Reverse
	|
	|-RVA: 0x3EAAEC0 Offset: 0x3EAAFC1 VA: 0x3EAAEC0
	|-List<short>.Reverse
	|
	|-RVA: 0x3EADCC0 Offset: 0x3EADDC1 VA: 0x3EADCC0
	|-List<int>.Reverse
	|
	|-RVA: 0x3EB0AC0 Offset: 0x3EB0BC1 VA: 0x3EB0AC0
	|-List<Int32Enum>.Reverse
	|
	|-RVA: 0x3EB38C0 Offset: 0x3EB39C1 VA: 0x3EB38C0
	|-List<long>.Reverse
	|
	|-RVA: 0x3E00C90 Offset: 0x3E00D91 VA: 0x3E00C90
	|-List<IntPtr>.Reverse
	|
	|-RVA: 0x3E03BB0 Offset: 0x3E03CB1 VA: 0x3E03BB0
	|-List<InterpretedFrameInfo>.Reverse
	|
	|-RVA: 0x3E06D90 Offset: 0x3E06E91 VA: 0x3E06D90
	|-List<IntervalTreeNode>.Reverse
	|
	|-RVA: 0x3E09BA0 Offset: 0x3E09CA1 VA: 0x3E09BA0
	|-List<LengthLimitProperties>.Reverse
	|
	|-RVA: 0x3E0C9B0 Offset: 0x3E0CAB1 VA: 0x3E0C9B0
	|-List<MapPos>.Reverse
	|
	|-RVA: 0x3E0FF30 Offset: 0x3E10031 VA: 0x3E0FF30
	|-List<Matrix4x4>.Reverse
	|
	|-RVA: 0x3E12CF0 Offset: 0x3E12DF1 VA: 0x3E12CF0
	|-List<object>.Reverse
	|-List<RegexNode>.Reverse
	|
	|-RVA: 0x3E16130 Offset: 0x3E16231 VA: 0x3E16130
	|-List<ObjectInitializationData>.Reverse
	|
	|-RVA: 0x3E19350 Offset: 0x3E19451 VA: 0x3E19350
	|-List<PlayableBinding>.Reverse
	|
	|-RVA: 0x3E1C720 Offset: 0x3E1C821 VA: 0x3E1C720
	|-List<PlayerLoopSystem>.Reverse
	|
	|-RVA: 0x3DA6BC0 Offset: 0x3DA6CC1 VA: 0x3DA6BC0
	|-List<PlayerLoopSystemInternal>.Reverse
	|
	|-RVA: 0x3DA9AE0 Offset: 0x3DA9BE1 VA: 0x3DA9AE0
	|-List<RangePositionInfo>.Reverse
	|
	|-RVA: 0x3DAC8F0 Offset: 0x3DAC9F1 VA: 0x3DAC8F0
	|-List<Ranking2ChartInfoInput>.Reverse
	|
	|-RVA: 0x3DAFD10 Offset: 0x3DAFE11 VA: 0x3DAFD10
	|-List<RaycastHit2D>.Reverse
	|
	|-RVA: 0x3DB3520 Offset: 0x3DB3621 VA: 0x3DB3520
	|-List<RaycastResult>.Reverse
	|
	|-RVA: 0x3DB6520 Offset: 0x3DB6621 VA: 0x3DB6520
	|-List<Rect>.Reverse
	|
	|-RVA: 0x3DB9330 Offset: 0x3DB9431 VA: 0x3DB9330
	|-List<RendererListHandle>.Reverse
	|
	|-RVA: 0x3DBC140 Offset: 0x3DBC241 VA: 0x3DBC140
	|-List<ResourceHandle>.Reverse
	|
	|-RVA: 0x3DBEF50 Offset: 0x3DBF051 VA: 0x3DBEF50
	|-List<sbyte>.Reverse
	|
	|-RVA: 0x3DC1D60 Offset: 0x3DC1E61 VA: 0x3DC1D60
	|-List<ShaderTagId>.Reverse
	|
	|-RVA: 0x3E3D9D0 Offset: 0x3E3DAD1 VA: 0x3E3D9D0
	|-List<float>.Reverse
	|
	|-RVA: 0x3E416B0 Offset: 0x3E417B1 VA: 0x3E416B0
	|-List<SphericalHarmonicsL2>.Reverse
	|
	|-RVA: 0x3E44AA0 Offset: 0x3E44BA1 VA: 0x3E44AA0
	|-List<SubMeshDescriptor>.Reverse
	|
	|-RVA: 0x3E479C0 Offset: 0x3E47AC1 VA: 0x3E479C0
	|-List<TablePair>.Reverse
	|
	|-RVA: 0x3E4A7D0 Offset: 0x3E4A8D1 VA: 0x3E4A7D0
	|-List<TimeSpan>.Reverse
	|
	|-RVA: 0x3E4D7B0 Offset: 0x3E4D8B1 VA: 0x3E4D7B0
	|-List<UICharInfo>.Reverse
	|
	|-RVA: 0x3E50690 Offset: 0x3E50791 VA: 0x3E50690
	|-List<UILineInfo>.Reverse
	|
	|-RVA: 0x3E54370 Offset: 0x3E54471 VA: 0x3E54370
	|-List<UIVertex>.Reverse
	|
	|-RVA: 0x3E57170 Offset: 0x3E57271 VA: 0x3E57170
	|-List<ushort>.Reverse
	|
	|-RVA: 0x3E59F70 Offset: 0x3E5A071 VA: 0x3E59F70
	|-List<uint>.Reverse
	|
	|-RVA: 0x3DC4B60 Offset: 0x3DC4C61 VA: 0x3DC4B60
	|-List<ulong>.Reverse
	|
	|-RVA: 0x3DC7A30 Offset: 0x3DC7B31 VA: 0x3DC7A30
	|-List<Vector2>.Reverse
	|
	|-RVA: 0x3DCAA10 Offset: 0x3DCAB11 VA: 0x3DCAA10
	|-List<Vector3>.Reverse
	|
	|-RVA: 0x3DCDA10 Offset: 0x3DCDB11 VA: 0x3DCDA10
	|-List<Vector4>.Reverse
	|
	|-RVA: 0x3DD08F0 Offset: 0x3DD09F1 VA: 0x3DD08F0
	|-List<VertexAttributeDescriptor>.Reverse
	|
	|-RVA: 0x3DD3810 Offset: 0x3DD3911 VA: 0x3DD3810
	|-List<X509ChainStatus>.Reverse
	|
	|-RVA: 0x3DD6C00 Offset: 0x3DD6D01 VA: 0x3DD6C00
	|-List<XRView>.Reverse
	|
	|-RVA: 0x3DD9B20 Offset: 0x3DD9C21 VA: 0x3DD9B20
	|-List<AmiiboSequence.GainItemData>.Reverse
	|
	|-RVA: 0x3DDCEC0 Offset: 0x3DDCFC1 VA: 0x3DDCEC0
	|-List<AnimationOutputWeightProcessor.WeightInfo>.Reverse
	|
	|-RVA: 0x3DDFDE0 Offset: 0x3DDFEE1 VA: 0x3DDFDE0
	|-List<ArenaOrderSequence.GodInfo>.Reverse
	|
	|-RVA: 0x3E1F640 Offset: 0x3E1F741 VA: 0x3E1F640
	|-List<BattleInfo.SupportData>.Reverse
	|
	|-RVA: 0x3E22560 Offset: 0x3E22661 VA: 0x3E22560
	|-List<BeforeRenderHelper.OrderBlock>.Reverse
	|
	|-RVA: 0x3E25790 Offset: 0x3E25891 VA: 0x3E25790
	|-List<Camera.RenderRequest>.Reverse
	|
	|-RVA: 0x3E286B0 Offset: 0x3E287B1 VA: 0x3E286B0
	|-List<CameraState.CustomBlendable>.Reverse
	|
	|-RVA: 0x3E2B4C0 Offset: 0x3E2B5C1 VA: 0x3E2B4C0
	|-List<CinemachineClearShot.Pair>.Reverse
	|
	|-RVA: 0x3E2E2D0 Offset: 0x3E2E3D1 VA: 0x3E2E2D0
	|-List<CinemachineStateDrivenCamera.HashPair>.Reverse
	|
	|-RVA: 0x3E314F0 Offset: 0x3E315F1 VA: 0x3E314F0
	|-List<DelayedActionManager.DelegateInfo>.Reverse
	|
	|-RVA: 0x3E348E0 Offset: 0x3E349E1 VA: 0x3E348E0
	|-List<Detail.AsyncResultInt>.Reverse
	|
	|-RVA: 0x3E377C0 Offset: 0x3E378C1 VA: 0x3E377C0
	|-List<Detail.CppArray>.Reverse
	|
	|-RVA: 0x3E3ABB0 Offset: 0x3E3ACB1 VA: 0x3E3ABB0
	|-List<Detail.NotificationEventInt>.Reverse
	|
	|-RVA: 0x3E5CE90 Offset: 0x3E5CF91 VA: 0x3E5CE90
	|-List<DragonRideTargetGroup.ChainParam>.Reverse
	|
	|-RVA: 0x3E600A0 Offset: 0x3E601A1 VA: 0x3E600A0
	|-List<GmapPathAdjuster.TargetModel>.Reverse
	|
	|-RVA: 0x3E632B0 Offset: 0x3E633B1 VA: 0x3E632B0
	|-List<GmapSpotAdjuster.TargetModel>.Reverse
	|
	|-RVA: 0x3E664C0 Offset: 0x3E665C1 VA: 0x3E664C0
	|-List<HubFastTravel.Location>.Reverse
	|
	|-RVA: 0x3E69900 Offset: 0x3E69A01 VA: 0x3E69900
	|-List<HubLensFlare.Flare>.Reverse
	|
	|-RVA: 0x3E6C820 Offset: 0x3E6C921 VA: 0x3E6C820
	|-List<InventoryPoolItemMenuContent.KindBgNameClass>.Reverse
	|
	|-RVA: 0x3E6F630 Offset: 0x3E6F731 VA: 0x3E6F630
	|-List<Map.Pos>.Reverse
	|
	|-RVA: 0x3E72510 Offset: 0x3E72611 VA: 0x3E72510
	|-List<MapImage.BackupTerrain>.Reverse
	|
	|-RVA: 0x3E753B0 Offset: 0x3E754B1 VA: 0x3E753B0
	|-List<MapImageRange.Pos>.Reverse
	|
	|-RVA: 0x3E785C0 Offset: 0x3E786C1 VA: 0x3E785C0
	|-List<MapMind.Target>.Reverse
	|
	|-RVA: 0x3D88190 Offset: 0x3D88291 VA: 0x3D88190
	|-List<MapPanelDebug.Entity>.Reverse
	|
	|-RVA: 0x3D8AFA0 Offset: 0x3D8B0A1 VA: 0x3D8AFA0
	|-List<NexRanking.Data>.Reverse
	|
	|-RVA: 0x3D8DE80 Offset: 0x3D8DF81 VA: 0x3D8DE80
	|-List<NexVersus.RatingData>.Reverse
	|
	|-RVA: 0x3D90DA0 Offset: 0x3D90EA1 VA: 0x3D90DA0
	|-List<PackedPlayModeBuildLogs.RuntimeBuildLog>.Reverse
	|
	|-RVA: 0x3D94150 Offset: 0x3D94251 VA: 0x3D94150
	|-List<ParticleSystem.Particle>.Reverse
	|
	|-RVA: 0x3D96F60 Offset: 0x3D97061 VA: 0x3D96F60
	|-List<RangeData.Offset>.Reverse
	|
	|-RVA: 0x3D9A180 Offset: 0x3D9A281 VA: 0x3D9A180
	|-List<RenderGraphDebugData.PassDebugData>.Reverse
	|
	|-RVA: 0x3D9D550 Offset: 0x3D9D651 VA: 0x3D9D550
	|-List<RenderGraphDebugData.ResourceDebugData>.Reverse
	|
	|-RVA: 0x3DA0470 Offset: 0x3DA0571 VA: 0x3DA0470
	|-List<RingCleaningUnitSelectMenu.GodParam>.Reverse
	|
	|-RVA: 0x3DA37F0 Offset: 0x3DA38F1 VA: 0x3DA37F0
	|-List<ShadowUtility.Edge>.Reverse
	|
	|-RVA: 0x3D15AD0 Offset: 0x3D15BD1 VA: 0x3D15AD0
	|-List<SkillArray.Entity>.Reverse
	|
	|-RVA: 0x3D19090 Offset: 0x3D19191 VA: 0x3D19090
	|-List<TexturePacker_JsonArray.Frame>.Reverse
	|
	|-RVA: 0x3D1C2C0 Offset: 0x3D1C3C1 VA: 0x3D1C2C0
	|-List<TimeNotificationBehaviour.NotificationEntry>.Reverse
	|
	|-RVA: 0x3D1F4D0 Offset: 0x3D1F5D1 VA: 0x3D1F4D0
	|-List<UnitySynchronizationContext.WorkRequest>.Reverse
	|
	|-RVA: 0x3D223F0 Offset: 0x3D224F1 VA: 0x3D223F0
	|-List<XmlSchemaObjectTable.XmlSchemaObjectEntry>.Reverse
	|
	|-RVA: 0x3D25310 Offset: 0x3D25411 VA: 0x3D25310
	|-List<AssetBundleBuildMap.AssetBundleEntry.AssetPathString>.Reverse
	|
	|-RVA: 0x3D28730 Offset: 0x3D28831 VA: 0x3D28730
	|-List<Detail.DataStore.DataStoreChangeMetaParamInt>.Reverse
	|
	|-RVA: 0x3D2B610 Offset: 0x3D2B711 VA: 0x3D2B610
	|-List<Detail.DataStore.DataStoreDeleteParamInt>.Reverse
	|
	|-RVA: 0x3D2E9B0 Offset: 0x3D2EAB1 VA: 0x3D2E9B0
	|-List<Detail.DataStore.DataStoreGetMetaParamInt>.Reverse
	|
	|-RVA: 0x3D31DA0 Offset: 0x3D31EA1 VA: 0x3D31DA0
	|-List<Detail.DataStore.DataStoreMetaInfoInt>.Reverse
	|
	|-RVA: 0x3CF63D0 Offset: 0x3CF64D1 VA: 0x3CF63D0
	|-List<Detail.DataStore.DataStorePasswordInfoInt>.Reverse
	|
	|-RVA: 0x3CF95B0 Offset: 0x3CF96B1 VA: 0x3CF95B0
	|-List<Detail.DataStore.DataStorePersistenceInfoInt>.Reverse
	|
	|-RVA: 0x3CFC960 Offset: 0x3CFCA61 VA: 0x3CFC960
	|-List<Detail.DataStore.DataStorePreparePostParamInt>.Reverse
	|
	|-RVA: 0x3CFF840 Offset: 0x3CFF941 VA: 0x3CFF840
	|-List<Detail.DataStore.DataStoreRateObjectParamInt>.Reverse
	|
	|-RVA: 0x3D02A30 Offset: 0x3D02B31 VA: 0x3D02A30
	|-List<Detail.DataStore.DataStoreRatingInitParamInt>.Reverse
	|
	|-RVA: 0x3D05910 Offset: 0x3D05A11 VA: 0x3D05910
	|-List<Detail.DataStore.DataStoreRatingTargetInt>.Reverse
	|
	|-RVA: 0x3D08EF0 Offset: 0x3D08FF1 VA: 0x3D08EF0
	|-List<Detail.Ranking.RankingCachedResultInt>.Reverse
	|
	|-RVA: 0x3D0BDD0 Offset: 0x3D0BED1 VA: 0x3D0BDD0
	|-List<Detail.Ranking.RankingOrderParamInt>.Reverse
	|
	|-RVA: 0x3D0F350 Offset: 0x3D0F451 VA: 0x3D0F350
	|-List<Detail.Ranking.RankingRankDataInt>.Reverse
	|
	|-RVA: 0x3D12CC0 Offset: 0x3D12DC1 VA: 0x3D12CC0
	|-List<Detail.Ranking2.Ranking2ChartInfoInt>.Reverse
	|
	|-RVA: 0x3D692D0 Offset: 0x3D693D1 VA: 0x3D692D0
	|-List<Detail.Ranking2.Ranking2RankDataInt>.Reverse
	|
	|-RVA: 0x3D6C1B0 Offset: 0x3D6C2B1 VA: 0x3D6C1B0
	|-List<Detail.Ranking2.Ranking2ScoreDataInt>.Reverse
	|
	|-RVA: 0x3D6F3A0 Offset: 0x3D6F4A1 VA: 0x3D6F3A0
	|-List<Detail.Screening.ScreeningContextInfoInt>.Reverse
	|
	|-RVA: 0x3D72B70 Offset: 0x3D72C71 VA: 0x3D72B70
	|-List<Detail.Subscriber.SubscriberContentInt>.Reverse
	|
	|-RVA: 0x3D75D50 Offset: 0x3D75E51 VA: 0x3D75D50
	|-List<Detail.Subscriber.SubscriberGetContentParamInt>.Reverse
	|
	|-RVA: 0x3D790F0 Offset: 0x3D791F1 VA: 0x3D790F0
	|-List<Detail.Subscriber.SubscriberUserStatusInfoInt>.Reverse
	|
	|-RVA: 0x3D7C2D0 Offset: 0x3D7C3D1 VA: 0x3D7C2D0
	|-List<Detail.Subscriber.SubscriberUserStatusParamInt>.Reverse
	|
	|-RVA: 0x3D7F0E0 Offset: 0x3D7F1E1 VA: 0x3D7F0E0
	|-List<Detail.Utility.IntegerSettings>.Reverse
	|
	|-RVA: 0x3D81FC0 Offset: 0x3D820C1 VA: 0x3D81FC0
	|-List<Detail.Utility.UniqueIdInfoInt>.Reverse
	|
	|-RVA: 0x3D84FB0 Offset: 0x3D850B1 VA: 0x3D84FB0
	|-List<MapHistory.Rewind.LatestInspectorData>.Reverse
	|
	|-RVA: 0x3061270 Offset: 0x3061371 VA: 0x3061270
	|-List<MapHistory.Rewind.WorkTerrainData>.Reverse
	|
	|-RVA: 0x3064190 Offset: 0x3064291 VA: 0x3064190
	|-List<MapSkill.AroundCalculator.Result>.Reverse
	|
	|-RVA: 0x3067510 Offset: 0x3067611 VA: 0x3067510
	|-List<TargetPositionCache.CacheCurve.Item>.Reverse
	|
	|-RVA: 0x306A930 Offset: 0x306AA31 VA: 0x306A930
	|-List<TargetPositionCache.CacheEntry.RecordingItem>.Reverse
	*/

	// RVA: -1 Offset: -1
	public void Sort() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3B0D160 Offset: 0x3B0D261 VA: 0x3B0D160
	|-List<IntervalTree.Entry<object>>.Sort
	|
	|-RVA: 0x3B10080 Offset: 0x3B10181 VA: 0x3B10080
	|-List<KeyValuePair<DateTime, object>>.Sort
	|
	|-RVA: 0x3B12FA0 Offset: 0x3B130A1 VA: 0x3B12FA0
	|-List<KeyValuePair<int, object>>.Sort
	|
	|-RVA: 0x3B161C0 Offset: 0x3B162C1 VA: 0x3B161C0
	|-List<KeyValuePair<object, ValueTuple<int, DateTime, object>>>.Sort
	|
	|-RVA: 0x3B190E0 Offset: 0x3B191E1 VA: 0x3B190E0
	|-List<KeyValuePair<object, object>>.Sort
	|
	|-RVA: 0x3B1C2F0 Offset: 0x3B1C3F1 VA: 0x3B1C2F0
	|-List<CommonBattleSequence.Reliance<object>>.Sort
	|
	|-RVA: 0x3B1F210 Offset: 0x3B1F311 VA: 0x3B1F210
	|-List<RenderGraphResourcePool.ResourceLogInfo<object>>.Sort
	|
	|-RVA: 0x3B22130 Offset: 0x3B22231 VA: 0x3B22130
	|-List<ValueTuple<int, object>>.Sort
	|
	|-RVA: 0x3DE2CB0 Offset: 0x3DE2DB1 VA: 0x3DE2CB0
	|-List<ValueTuple<Int32Enum, int>>.Sort
	|
	|-RVA: 0x3DE5EC0 Offset: 0x3DE5FC1 VA: 0x3DE5EC0
	|-List<ValueTuple<object, ValueTuple<object, int>>>.Sort
	|
	|-RVA: 0x3DE8DE0 Offset: 0x3DE8EE1 VA: 0x3DE8DE0
	|-List<ValueTuple<object, int>>.Sort
	|
	|-RVA: 0x3DEBDE0 Offset: 0x3DEBEE1 VA: 0x3DEBDE0
	|-List<ValueTuple<Vector3, float>>.Sort
	|
	|-RVA: 0x3DEED00 Offset: 0x3DEEE01 VA: 0x3DEED00
	|-List<ValueTuple<object, Int32Enum, int>>.Sort
	|
	|-RVA: 0x3DF1F10 Offset: 0x3DF2011 VA: 0x3DF1F10
	|-List<ValueTuple<object, int, int, int>>.Sort
	|
	|-RVA: 0x3DF4D20 Offset: 0x3DF4E21 VA: 0x3DF4D20
	|-List<AnimatorClipInfo>.Sort
	|
	|-RVA: 0x3DF7F30 Offset: 0x3DF8031 VA: 0x3DF7F30
	|-List<AsyncOperationHandle>.Sort
	|
	|-RVA: 0x3DFB120 Offset: 0x3DFB221 VA: 0x3DFB120
	|-List<BoneWeight>.Sort
	|
	|-RVA: 0x3DFDF50 Offset: 0x3DFE051 VA: 0x3DFDF50
	|-List<bool>.Sort
	|
	|-RVA: 0x3E7B490 Offset: 0x3E7B591 VA: 0x3E7B490
	|-List<byte>.Sort
	|
	|-RVA: 0x3E7E3B0 Offset: 0x3E7E4B1 VA: 0x3E7E3B0
	|-List<CameraInfo>.Sort
	|
	|-RVA: 0x3E811B0 Offset: 0x3E812B1 VA: 0x3E811B0
	|-List<char>.Sort
	|
	|-RVA: 0x3E841B0 Offset: 0x3E842B1 VA: 0x3E841B0
	|-List<Color>.Sort
	|
	|-RVA: 0x3E86FC0 Offset: 0x3E870C1 VA: 0x3E86FC0
	|-List<Color32>.Sort
	|
	|-RVA: 0x3E89EE0 Offset: 0x3E89FE1 VA: 0x3E89EE0
	|-List<ConstraintSource>.Sort
	|
	|-RVA: 0x3E8D0F0 Offset: 0x3E8D1F1 VA: 0x3E8D0F0
	|-List<ContourVertex>.Sort
	|
	|-RVA: 0x3E902D0 Offset: 0x3E903D1 VA: 0x3E902D0
	|-List<DataStoreRatingInfo>.Sort
	|
	|-RVA: 0x3E930E0 Offset: 0x3E931E1 VA: 0x3E930E0
	|-List<DataStoreResult>.Sort
	|
	|-RVA: 0x3E95EF0 Offset: 0x3E95FF1 VA: 0x3E95EF0
	|-List<DateTime>.Sort
	|
	|-RVA: 0x3E98DD0 Offset: 0x3E98ED1 VA: 0x3E98DD0
	|-List<DateTimeOffset>.Sort
	|
	|-RVA: 0x3E9BCB0 Offset: 0x3E9BDB1 VA: 0x3E9BCB0
	|-List<Decimal>.Sort
	|
	|-RVA: 0x3E9F0F0 Offset: 0x3E9F1F1 VA: 0x3E9F0F0
	|-List<DiagnosticEvent>.Sort
	|
	|-RVA: 0x3EA1F10 Offset: 0x3EA2011 VA: 0x3EA1F10
	|-List<double>.Sort
	|
	|-RVA: 0x3EA52A0 Offset: 0x3EA53A1 VA: 0x3EA52A0
	|-List<Friend>.Sort
	|
	|-RVA: 0x3EA8180 Offset: 0x3EA8281 VA: 0x3EA8180
	|-List<GlyphRect>.Sort
	|
	|-RVA: 0x3EAAF80 Offset: 0x3EAB081 VA: 0x3EAAF80
	|-List<short>.Sort
	|
	|-RVA: 0x3EADD80 Offset: 0x3EADE81 VA: 0x3EADD80
	|-List<int>.Sort
	|
	|-RVA: 0x3EB0B80 Offset: 0x3EB0C81 VA: 0x3EB0B80
	|-List<Int32Enum>.Sort
	|
	|-RVA: 0x3EB3980 Offset: 0x3EB3A81 VA: 0x3EB3980
	|-List<long>.Sort
	|
	|-RVA: 0x3E00D50 Offset: 0x3E00E51 VA: 0x3E00D50
	|-List<IntPtr>.Sort
	|
	|-RVA: 0x3E03C70 Offset: 0x3E03D71 VA: 0x3E03C70
	|-List<InterpretedFrameInfo>.Sort
	|
	|-RVA: 0x3E06E50 Offset: 0x3E06F51 VA: 0x3E06E50
	|-List<IntervalTreeNode>.Sort
	|
	|-RVA: 0x3E09C60 Offset: 0x3E09D61 VA: 0x3E09C60
	|-List<LengthLimitProperties>.Sort
	|
	|-RVA: 0x3E0CA70 Offset: 0x3E0CB71 VA: 0x3E0CA70
	|-List<MapPos>.Sort
	|
	|-RVA: 0x3E0FFF0 Offset: 0x3E100F1 VA: 0x3E0FFF0
	|-List<Matrix4x4>.Sort
	|
	|-RVA: 0x3E12DB0 Offset: 0x3E12EB1 VA: 0x3E12DB0
	|-List<object>.Sort
	|-List<string>.Sort
	|-List<DebugUI.Panel>.Sort
	|
	|-RVA: 0x3E161F0 Offset: 0x3E162F1 VA: 0x3E161F0
	|-List<ObjectInitializationData>.Sort
	|
	|-RVA: 0x3E19410 Offset: 0x3E19511 VA: 0x3E19410
	|-List<PlayableBinding>.Sort
	|
	|-RVA: 0x3E1C7E0 Offset: 0x3E1C8E1 VA: 0x3E1C7E0
	|-List<PlayerLoopSystem>.Sort
	|
	|-RVA: 0x3DA6C80 Offset: 0x3DA6D81 VA: 0x3DA6C80
	|-List<PlayerLoopSystemInternal>.Sort
	|
	|-RVA: 0x3DA9BA0 Offset: 0x3DA9CA1 VA: 0x3DA9BA0
	|-List<RangePositionInfo>.Sort
	|
	|-RVA: 0x3DAC9B0 Offset: 0x3DACAB1 VA: 0x3DAC9B0
	|-List<Ranking2ChartInfoInput>.Sort
	|
	|-RVA: 0x3DAFDD0 Offset: 0x3DAFED1 VA: 0x3DAFDD0
	|-List<RaycastHit2D>.Sort
	|
	|-RVA: 0x3DB35E0 Offset: 0x3DB36E1 VA: 0x3DB35E0
	|-List<RaycastResult>.Sort
	|
	|-RVA: 0x3DB65E0 Offset: 0x3DB66E1 VA: 0x3DB65E0
	|-List<Rect>.Sort
	|
	|-RVA: 0x3DB93F0 Offset: 0x3DB94F1 VA: 0x3DB93F0
	|-List<RendererListHandle>.Sort
	|
	|-RVA: 0x3DBC200 Offset: 0x3DBC301 VA: 0x3DBC200
	|-List<ResourceHandle>.Sort
	|
	|-RVA: 0x3DBF010 Offset: 0x3DBF111 VA: 0x3DBF010
	|-List<sbyte>.Sort
	|
	|-RVA: 0x3DC1E20 Offset: 0x3DC1F21 VA: 0x3DC1E20
	|-List<ShaderTagId>.Sort
	|
	|-RVA: 0x3E3DA90 Offset: 0x3E3DB91 VA: 0x3E3DA90
	|-List<float>.Sort
	|
	|-RVA: 0x3E41770 Offset: 0x3E41871 VA: 0x3E41770
	|-List<SphericalHarmonicsL2>.Sort
	|
	|-RVA: 0x3E44B60 Offset: 0x3E44C61 VA: 0x3E44B60
	|-List<SubMeshDescriptor>.Sort
	|
	|-RVA: 0x3E47A80 Offset: 0x3E47B81 VA: 0x3E47A80
	|-List<TablePair>.Sort
	|
	|-RVA: 0x3E4A890 Offset: 0x3E4A991 VA: 0x3E4A890
	|-List<TimeSpan>.Sort
	|
	|-RVA: 0x3E4D870 Offset: 0x3E4D971 VA: 0x3E4D870
	|-List<UICharInfo>.Sort
	|
	|-RVA: 0x3E50750 Offset: 0x3E50851 VA: 0x3E50750
	|-List<UILineInfo>.Sort
	|
	|-RVA: 0x3E54430 Offset: 0x3E54531 VA: 0x3E54430
	|-List<UIVertex>.Sort
	|
	|-RVA: 0x3E57230 Offset: 0x3E57331 VA: 0x3E57230
	|-List<ushort>.Sort
	|
	|-RVA: 0x3E5A030 Offset: 0x3E5A131 VA: 0x3E5A030
	|-List<uint>.Sort
	|
	|-RVA: 0x3DC4C20 Offset: 0x3DC4D21 VA: 0x3DC4C20
	|-List<ulong>.Sort
	|
	|-RVA: 0x3DC7AF0 Offset: 0x3DC7BF1 VA: 0x3DC7AF0
	|-List<Vector2>.Sort
	|
	|-RVA: 0x3DCAAD0 Offset: 0x3DCABD1 VA: 0x3DCAAD0
	|-List<Vector3>.Sort
	|
	|-RVA: 0x3DCDAD0 Offset: 0x3DCDBD1 VA: 0x3DCDAD0
	|-List<Vector4>.Sort
	|
	|-RVA: 0x3DD09B0 Offset: 0x3DD0AB1 VA: 0x3DD09B0
	|-List<VertexAttributeDescriptor>.Sort
	|
	|-RVA: 0x3DD38D0 Offset: 0x3DD39D1 VA: 0x3DD38D0
	|-List<X509ChainStatus>.Sort
	|
	|-RVA: 0x3DD6CC0 Offset: 0x3DD6DC1 VA: 0x3DD6CC0
	|-List<XRView>.Sort
	|
	|-RVA: 0x3DD9BE0 Offset: 0x3DD9CE1 VA: 0x3DD9BE0
	|-List<AmiiboSequence.GainItemData>.Sort
	|
	|-RVA: 0x3DDCF80 Offset: 0x3DDD081 VA: 0x3DDCF80
	|-List<AnimationOutputWeightProcessor.WeightInfo>.Sort
	|
	|-RVA: 0x3DDFEA0 Offset: 0x3DDFFA1 VA: 0x3DDFEA0
	|-List<ArenaOrderSequence.GodInfo>.Sort
	|
	|-RVA: 0x3E1F700 Offset: 0x3E1F801 VA: 0x3E1F700
	|-List<BattleInfo.SupportData>.Sort
	|
	|-RVA: 0x3E22620 Offset: 0x3E22721 VA: 0x3E22620
	|-List<BeforeRenderHelper.OrderBlock>.Sort
	|
	|-RVA: 0x3E25850 Offset: 0x3E25951 VA: 0x3E25850
	|-List<Camera.RenderRequest>.Sort
	|
	|-RVA: 0x3E28770 Offset: 0x3E28871 VA: 0x3E28770
	|-List<CameraState.CustomBlendable>.Sort
	|
	|-RVA: 0x3E2B580 Offset: 0x3E2B681 VA: 0x3E2B580
	|-List<CinemachineClearShot.Pair>.Sort
	|
	|-RVA: 0x3E2E390 Offset: 0x3E2E491 VA: 0x3E2E390
	|-List<CinemachineStateDrivenCamera.HashPair>.Sort
	|
	|-RVA: 0x3E315B0 Offset: 0x3E316B1 VA: 0x3E315B0
	|-List<DelayedActionManager.DelegateInfo>.Sort
	|
	|-RVA: 0x3E349A0 Offset: 0x3E34AA1 VA: 0x3E349A0
	|-List<Detail.AsyncResultInt>.Sort
	|
	|-RVA: 0x3E37880 Offset: 0x3E37981 VA: 0x3E37880
	|-List<Detail.CppArray>.Sort
	|
	|-RVA: 0x3E3AC70 Offset: 0x3E3AD71 VA: 0x3E3AC70
	|-List<Detail.NotificationEventInt>.Sort
	|
	|-RVA: 0x3E5CF50 Offset: 0x3E5D051 VA: 0x3E5CF50
	|-List<DragonRideTargetGroup.ChainParam>.Sort
	|
	|-RVA: 0x3E60160 Offset: 0x3E60261 VA: 0x3E60160
	|-List<GmapPathAdjuster.TargetModel>.Sort
	|
	|-RVA: 0x3E63370 Offset: 0x3E63471 VA: 0x3E63370
	|-List<GmapSpotAdjuster.TargetModel>.Sort
	|
	|-RVA: 0x3E66580 Offset: 0x3E66681 VA: 0x3E66580
	|-List<HubFastTravel.Location>.Sort
	|
	|-RVA: 0x3E699C0 Offset: 0x3E69AC1 VA: 0x3E699C0
	|-List<HubLensFlare.Flare>.Sort
	|
	|-RVA: 0x3E6C8E0 Offset: 0x3E6C9E1 VA: 0x3E6C8E0
	|-List<InventoryPoolItemMenuContent.KindBgNameClass>.Sort
	|
	|-RVA: 0x3E6F6F0 Offset: 0x3E6F7F1 VA: 0x3E6F6F0
	|-List<Map.Pos>.Sort
	|
	|-RVA: 0x3E725D0 Offset: 0x3E726D1 VA: 0x3E725D0
	|-List<MapImage.BackupTerrain>.Sort
	|
	|-RVA: 0x3E75470 Offset: 0x3E75571 VA: 0x3E75470
	|-List<MapImageRange.Pos>.Sort
	|
	|-RVA: 0x3E78680 Offset: 0x3E78781 VA: 0x3E78680
	|-List<MapMind.Target>.Sort
	|
	|-RVA: 0x3D88250 Offset: 0x3D88351 VA: 0x3D88250
	|-List<MapPanelDebug.Entity>.Sort
	|
	|-RVA: 0x3D8B060 Offset: 0x3D8B161 VA: 0x3D8B060
	|-List<NexRanking.Data>.Sort
	|
	|-RVA: 0x3D8DF40 Offset: 0x3D8E041 VA: 0x3D8DF40
	|-List<NexVersus.RatingData>.Sort
	|
	|-RVA: 0x3D90E60 Offset: 0x3D90F61 VA: 0x3D90E60
	|-List<PackedPlayModeBuildLogs.RuntimeBuildLog>.Sort
	|
	|-RVA: 0x3D94210 Offset: 0x3D94311 VA: 0x3D94210
	|-List<ParticleSystem.Particle>.Sort
	|
	|-RVA: 0x3D97020 Offset: 0x3D97121 VA: 0x3D97020
	|-List<RangeData.Offset>.Sort
	|
	|-RVA: 0x3D9A240 Offset: 0x3D9A341 VA: 0x3D9A240
	|-List<RenderGraphDebugData.PassDebugData>.Sort
	|
	|-RVA: 0x3D9D610 Offset: 0x3D9D711 VA: 0x3D9D610
	|-List<RenderGraphDebugData.ResourceDebugData>.Sort
	|
	|-RVA: 0x3DA0530 Offset: 0x3DA0631 VA: 0x3DA0530
	|-List<RingCleaningUnitSelectMenu.GodParam>.Sort
	|
	|-RVA: 0x3DA38B0 Offset: 0x3DA39B1 VA: 0x3DA38B0
	|-List<ShadowUtility.Edge>.Sort
	|
	|-RVA: 0x3D15B90 Offset: 0x3D15C91 VA: 0x3D15B90
	|-List<SkillArray.Entity>.Sort
	|
	|-RVA: 0x3D19150 Offset: 0x3D19251 VA: 0x3D19150
	|-List<TexturePacker_JsonArray.Frame>.Sort
	|
	|-RVA: 0x3D1C380 Offset: 0x3D1C481 VA: 0x3D1C380
	|-List<TimeNotificationBehaviour.NotificationEntry>.Sort
	|
	|-RVA: 0x3D1F590 Offset: 0x3D1F691 VA: 0x3D1F590
	|-List<UnitySynchronizationContext.WorkRequest>.Sort
	|
	|-RVA: 0x3D224B0 Offset: 0x3D225B1 VA: 0x3D224B0
	|-List<XmlSchemaObjectTable.XmlSchemaObjectEntry>.Sort
	|
	|-RVA: 0x3D253D0 Offset: 0x3D254D1 VA: 0x3D253D0
	|-List<AssetBundleBuildMap.AssetBundleEntry.AssetPathString>.Sort
	|
	|-RVA: 0x3D287F0 Offset: 0x3D288F1 VA: 0x3D287F0
	|-List<Detail.DataStore.DataStoreChangeMetaParamInt>.Sort
	|
	|-RVA: 0x3D2B6D0 Offset: 0x3D2B7D1 VA: 0x3D2B6D0
	|-List<Detail.DataStore.DataStoreDeleteParamInt>.Sort
	|
	|-RVA: 0x3D2EA70 Offset: 0x3D2EB71 VA: 0x3D2EA70
	|-List<Detail.DataStore.DataStoreGetMetaParamInt>.Sort
	|
	|-RVA: 0x3D31E60 Offset: 0x3D31F61 VA: 0x3D31E60
	|-List<Detail.DataStore.DataStoreMetaInfoInt>.Sort
	|
	|-RVA: 0x3CF6490 Offset: 0x3CF6591 VA: 0x3CF6490
	|-List<Detail.DataStore.DataStorePasswordInfoInt>.Sort
	|
	|-RVA: 0x3CF9670 Offset: 0x3CF9771 VA: 0x3CF9670
	|-List<Detail.DataStore.DataStorePersistenceInfoInt>.Sort
	|
	|-RVA: 0x3CFCA20 Offset: 0x3CFCB21 VA: 0x3CFCA20
	|-List<Detail.DataStore.DataStorePreparePostParamInt>.Sort
	|
	|-RVA: 0x3CFF900 Offset: 0x3CFFA01 VA: 0x3CFF900
	|-List<Detail.DataStore.DataStoreRateObjectParamInt>.Sort
	|
	|-RVA: 0x3D02AF0 Offset: 0x3D02BF1 VA: 0x3D02AF0
	|-List<Detail.DataStore.DataStoreRatingInitParamInt>.Sort
	|
	|-RVA: 0x3D059D0 Offset: 0x3D05AD1 VA: 0x3D059D0
	|-List<Detail.DataStore.DataStoreRatingTargetInt>.Sort
	|
	|-RVA: 0x3D08FB0 Offset: 0x3D090B1 VA: 0x3D08FB0
	|-List<Detail.Ranking.RankingCachedResultInt>.Sort
	|
	|-RVA: 0x3D0BE90 Offset: 0x3D0BF91 VA: 0x3D0BE90
	|-List<Detail.Ranking.RankingOrderParamInt>.Sort
	|
	|-RVA: 0x3D0F410 Offset: 0x3D0F511 VA: 0x3D0F410
	|-List<Detail.Ranking.RankingRankDataInt>.Sort
	|
	|-RVA: 0x3D12D80 Offset: 0x3D12E81 VA: 0x3D12D80
	|-List<Detail.Ranking2.Ranking2ChartInfoInt>.Sort
	|
	|-RVA: 0x3D69390 Offset: 0x3D69491 VA: 0x3D69390
	|-List<Detail.Ranking2.Ranking2RankDataInt>.Sort
	|
	|-RVA: 0x3D6C270 Offset: 0x3D6C371 VA: 0x3D6C270
	|-List<Detail.Ranking2.Ranking2ScoreDataInt>.Sort
	|
	|-RVA: 0x3D6F460 Offset: 0x3D6F561 VA: 0x3D6F460
	|-List<Detail.Screening.ScreeningContextInfoInt>.Sort
	|
	|-RVA: 0x3D72C30 Offset: 0x3D72D31 VA: 0x3D72C30
	|-List<Detail.Subscriber.SubscriberContentInt>.Sort
	|
	|-RVA: 0x3D75E10 Offset: 0x3D75F11 VA: 0x3D75E10
	|-List<Detail.Subscriber.SubscriberGetContentParamInt>.Sort
	|
	|-RVA: 0x3D791B0 Offset: 0x3D792B1 VA: 0x3D791B0
	|-List<Detail.Subscriber.SubscriberUserStatusInfoInt>.Sort
	|
	|-RVA: 0x3D7C390 Offset: 0x3D7C491 VA: 0x3D7C390
	|-List<Detail.Subscriber.SubscriberUserStatusParamInt>.Sort
	|
	|-RVA: 0x3D7F1A0 Offset: 0x3D7F2A1 VA: 0x3D7F1A0
	|-List<Detail.Utility.IntegerSettings>.Sort
	|
	|-RVA: 0x3D82080 Offset: 0x3D82181 VA: 0x3D82080
	|-List<Detail.Utility.UniqueIdInfoInt>.Sort
	|
	|-RVA: 0x3D85070 Offset: 0x3D85171 VA: 0x3D85070
	|-List<MapHistory.Rewind.LatestInspectorData>.Sort
	|
	|-RVA: 0x3061330 Offset: 0x3061431 VA: 0x3061330
	|-List<MapHistory.Rewind.WorkTerrainData>.Sort
	|
	|-RVA: 0x3064250 Offset: 0x3064351 VA: 0x3064250
	|-List<MapSkill.AroundCalculator.Result>.Sort
	|
	|-RVA: 0x30675D0 Offset: 0x30676D1 VA: 0x30675D0
	|-List<TargetPositionCache.CacheCurve.Item>.Sort
	|
	|-RVA: 0x306A9F0 Offset: 0x306AAF1 VA: 0x306A9F0
	|-List<TargetPositionCache.CacheEntry.RecordingItem>.Sort
	*/

	// RVA: -1 Offset: -1
	public void Sort(IComparer<T> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3B0D1C0 Offset: 0x3B0D2C1 VA: 0x3B0D1C0
	|-List<IntervalTree.Entry<object>>.Sort
	|
	|-RVA: 0x3B100E0 Offset: 0x3B101E1 VA: 0x3B100E0
	|-List<KeyValuePair<DateTime, object>>.Sort
	|
	|-RVA: 0x3B13000 Offset: 0x3B13101 VA: 0x3B13000
	|-List<KeyValuePair<int, object>>.Sort
	|
	|-RVA: 0x3B16220 Offset: 0x3B16321 VA: 0x3B16220
	|-List<KeyValuePair<object, ValueTuple<int, DateTime, object>>>.Sort
	|
	|-RVA: 0x3B19140 Offset: 0x3B19241 VA: 0x3B19140
	|-List<KeyValuePair<object, object>>.Sort
	|
	|-RVA: 0x3B1C350 Offset: 0x3B1C451 VA: 0x3B1C350
	|-List<CommonBattleSequence.Reliance<object>>.Sort
	|
	|-RVA: 0x3B1F270 Offset: 0x3B1F371 VA: 0x3B1F270
	|-List<RenderGraphResourcePool.ResourceLogInfo<object>>.Sort
	|
	|-RVA: 0x3B22190 Offset: 0x3B22291 VA: 0x3B22190
	|-List<ValueTuple<int, object>>.Sort
	|
	|-RVA: 0x3DE2D10 Offset: 0x3DE2E11 VA: 0x3DE2D10
	|-List<ValueTuple<Int32Enum, int>>.Sort
	|
	|-RVA: 0x3DE5F20 Offset: 0x3DE6021 VA: 0x3DE5F20
	|-List<ValueTuple<object, ValueTuple<object, int>>>.Sort
	|
	|-RVA: 0x3DE8E40 Offset: 0x3DE8F41 VA: 0x3DE8E40
	|-List<ValueTuple<object, int>>.Sort
	|
	|-RVA: 0x3DEBE40 Offset: 0x3DEBF41 VA: 0x3DEBE40
	|-List<ValueTuple<Vector3, float>>.Sort
	|
	|-RVA: 0x3DEED60 Offset: 0x3DEEE61 VA: 0x3DEED60
	|-List<ValueTuple<object, Int32Enum, int>>.Sort
	|
	|-RVA: 0x3DF1F70 Offset: 0x3DF2071 VA: 0x3DF1F70
	|-List<ValueTuple<object, int, int, int>>.Sort
	|
	|-RVA: 0x3DF4D80 Offset: 0x3DF4E81 VA: 0x3DF4D80
	|-List<AnimatorClipInfo>.Sort
	|
	|-RVA: 0x3DF7F90 Offset: 0x3DF8091 VA: 0x3DF7F90
	|-List<AsyncOperationHandle>.Sort
	|
	|-RVA: 0x3E12E10 Offset: 0x3E12F11 VA: 0x3E12E10
	|-List<BasicMenuItem>.Sort
	|-List<Contraction>.Sort
	|-List<IOverloadableMemberDescriptor>.Sort
	|-List<ItemData>.Sort
	|-List<object>.Sort
	|-List<DamageInfo.Info>.Sort
	|-List<RingListSequence.GodPageData>.Sort
	|-List<RelayCompletionAwardData.CalcResult.Item>.Sort
	|
	|-RVA: 0x3DFB180 Offset: 0x3DFB281 VA: 0x3DFB180
	|-List<BoneWeight>.Sort
	|
	|-RVA: 0x3DFDFB0 Offset: 0x3DFE0B1 VA: 0x3DFDFB0
	|-List<bool>.Sort
	|
	|-RVA: 0x3E7B4F0 Offset: 0x3E7B5F1 VA: 0x3E7B4F0
	|-List<byte>.Sort
	|
	|-RVA: 0x3E7E410 Offset: 0x3E7E511 VA: 0x3E7E410
	|-List<CameraInfo>.Sort
	|
	|-RVA: 0x3E81210 Offset: 0x3E81311 VA: 0x3E81210
	|-List<char>.Sort
	|
	|-RVA: 0x3E84210 Offset: 0x3E84311 VA: 0x3E84210
	|-List<Color>.Sort
	|
	|-RVA: 0x3E87020 Offset: 0x3E87121 VA: 0x3E87020
	|-List<Color32>.Sort
	|
	|-RVA: 0x3E89F40 Offset: 0x3E8A041 VA: 0x3E89F40
	|-List<ConstraintSource>.Sort
	|
	|-RVA: 0x3E8D150 Offset: 0x3E8D251 VA: 0x3E8D150
	|-List<ContourVertex>.Sort
	|
	|-RVA: 0x3E90330 Offset: 0x3E90431 VA: 0x3E90330
	|-List<DataStoreRatingInfo>.Sort
	|
	|-RVA: 0x3E93140 Offset: 0x3E93241 VA: 0x3E93140
	|-List<DataStoreResult>.Sort
	|
	|-RVA: 0x3E95F50 Offset: 0x3E96051 VA: 0x3E95F50
	|-List<DateTime>.Sort
	|
	|-RVA: 0x3E98E30 Offset: 0x3E98F31 VA: 0x3E98E30
	|-List<DateTimeOffset>.Sort
	|
	|-RVA: 0x3E9BD10 Offset: 0x3E9BE11 VA: 0x3E9BD10
	|-List<Decimal>.Sort
	|
	|-RVA: 0x3E9F150 Offset: 0x3E9F251 VA: 0x3E9F150
	|-List<DiagnosticEvent>.Sort
	|
	|-RVA: 0x3EA1F70 Offset: 0x3EA2071 VA: 0x3EA1F70
	|-List<double>.Sort
	|
	|-RVA: 0x3EA5300 Offset: 0x3EA5401 VA: 0x3EA5300
	|-List<Friend>.Sort
	|
	|-RVA: 0x3EA81E0 Offset: 0x3EA82E1 VA: 0x3EA81E0
	|-List<GlyphRect>.Sort
	|
	|-RVA: 0x3EAAFE0 Offset: 0x3EAB0E1 VA: 0x3EAAFE0
	|-List<short>.Sort
	|
	|-RVA: 0x3EADDE0 Offset: 0x3EADEE1 VA: 0x3EADDE0
	|-List<int>.Sort
	|
	|-RVA: 0x3EB0BE0 Offset: 0x3EB0CE1 VA: 0x3EB0BE0
	|-List<Int32Enum>.Sort
	|
	|-RVA: 0x3EB39E0 Offset: 0x3EB3AE1 VA: 0x3EB39E0
	|-List<long>.Sort
	|
	|-RVA: 0x3E00DB0 Offset: 0x3E00EB1 VA: 0x3E00DB0
	|-List<IntPtr>.Sort
	|
	|-RVA: 0x3E03CD0 Offset: 0x3E03DD1 VA: 0x3E03CD0
	|-List<InterpretedFrameInfo>.Sort
	|
	|-RVA: 0x3E06EB0 Offset: 0x3E06FB1 VA: 0x3E06EB0
	|-List<IntervalTreeNode>.Sort
	|
	|-RVA: 0x3E09CC0 Offset: 0x3E09DC1 VA: 0x3E09CC0
	|-List<LengthLimitProperties>.Sort
	|
	|-RVA: 0x3E0CAD0 Offset: 0x3E0CBD1 VA: 0x3E0CAD0
	|-List<MapPos>.Sort
	|
	|-RVA: 0x3E10050 Offset: 0x3E10151 VA: 0x3E10050
	|-List<Matrix4x4>.Sort
	|
	|-RVA: 0x3E16250 Offset: 0x3E16351 VA: 0x3E16250
	|-List<ObjectInitializationData>.Sort
	|
	|-RVA: 0x3E19470 Offset: 0x3E19571 VA: 0x3E19470
	|-List<PlayableBinding>.Sort
	|
	|-RVA: 0x3E1C840 Offset: 0x3E1C941 VA: 0x3E1C840
	|-List<PlayerLoopSystem>.Sort
	|
	|-RVA: 0x3DA6CE0 Offset: 0x3DA6DE1 VA: 0x3DA6CE0
	|-List<PlayerLoopSystemInternal>.Sort
	|
	|-RVA: 0x3DA9C00 Offset: 0x3DA9D01 VA: 0x3DA9C00
	|-List<RangePositionInfo>.Sort
	|
	|-RVA: 0x3DACA10 Offset: 0x3DACB11 VA: 0x3DACA10
	|-List<Ranking2ChartInfoInput>.Sort
	|
	|-RVA: 0x3DAFE30 Offset: 0x3DAFF31 VA: 0x3DAFE30
	|-List<RaycastHit2D>.Sort
	|
	|-RVA: 0x3DB3640 Offset: 0x3DB3741 VA: 0x3DB3640
	|-List<RaycastResult>.Sort
	|
	|-RVA: 0x3DB6640 Offset: 0x3DB6741 VA: 0x3DB6640
	|-List<Rect>.Sort
	|
	|-RVA: 0x3DB9450 Offset: 0x3DB9551 VA: 0x3DB9450
	|-List<RendererListHandle>.Sort
	|
	|-RVA: 0x3DBC260 Offset: 0x3DBC361 VA: 0x3DBC260
	|-List<ResourceHandle>.Sort
	|
	|-RVA: 0x3DBF070 Offset: 0x3DBF171 VA: 0x3DBF070
	|-List<sbyte>.Sort
	|
	|-RVA: 0x3DC1E80 Offset: 0x3DC1F81 VA: 0x3DC1E80
	|-List<ShaderTagId>.Sort
	|
	|-RVA: 0x3E3DAF0 Offset: 0x3E3DBF1 VA: 0x3E3DAF0
	|-List<float>.Sort
	|
	|-RVA: 0x3E417D0 Offset: 0x3E418D1 VA: 0x3E417D0
	|-List<SphericalHarmonicsL2>.Sort
	|
	|-RVA: 0x3E44BC0 Offset: 0x3E44CC1 VA: 0x3E44BC0
	|-List<SubMeshDescriptor>.Sort
	|
	|-RVA: 0x3E47AE0 Offset: 0x3E47BE1 VA: 0x3E47AE0
	|-List<TablePair>.Sort
	|
	|-RVA: 0x3E4A8F0 Offset: 0x3E4A9F1 VA: 0x3E4A8F0
	|-List<TimeSpan>.Sort
	|
	|-RVA: 0x3E4D8D0 Offset: 0x3E4D9D1 VA: 0x3E4D8D0
	|-List<UICharInfo>.Sort
	|
	|-RVA: 0x3E507B0 Offset: 0x3E508B1 VA: 0x3E507B0
	|-List<UILineInfo>.Sort
	|
	|-RVA: 0x3E54490 Offset: 0x3E54591 VA: 0x3E54490
	|-List<UIVertex>.Sort
	|
	|-RVA: 0x3E57290 Offset: 0x3E57391 VA: 0x3E57290
	|-List<ushort>.Sort
	|
	|-RVA: 0x3E5A090 Offset: 0x3E5A191 VA: 0x3E5A090
	|-List<uint>.Sort
	|
	|-RVA: 0x3DC4C80 Offset: 0x3DC4D81 VA: 0x3DC4C80
	|-List<ulong>.Sort
	|
	|-RVA: 0x3DC7B50 Offset: 0x3DC7C51 VA: 0x3DC7B50
	|-List<Vector2>.Sort
	|
	|-RVA: 0x3DCAB30 Offset: 0x3DCAC31 VA: 0x3DCAB30
	|-List<Vector3>.Sort
	|
	|-RVA: 0x3DCDB30 Offset: 0x3DCDC31 VA: 0x3DCDB30
	|-List<Vector4>.Sort
	|
	|-RVA: 0x3DD0A10 Offset: 0x3DD0B11 VA: 0x3DD0A10
	|-List<VertexAttributeDescriptor>.Sort
	|
	|-RVA: 0x3DD3930 Offset: 0x3DD3A31 VA: 0x3DD3930
	|-List<X509ChainStatus>.Sort
	|
	|-RVA: 0x3DD6D20 Offset: 0x3DD6E21 VA: 0x3DD6D20
	|-List<XRView>.Sort
	|
	|-RVA: 0x3DD9C40 Offset: 0x3DD9D41 VA: 0x3DD9C40
	|-List<AmiiboSequence.GainItemData>.Sort
	|
	|-RVA: 0x3DDCFE0 Offset: 0x3DDD0E1 VA: 0x3DDCFE0
	|-List<AnimationOutputWeightProcessor.WeightInfo>.Sort
	|
	|-RVA: 0x3DDFF00 Offset: 0x3DE0001 VA: 0x3DDFF00
	|-List<ArenaOrderSequence.GodInfo>.Sort
	|
	|-RVA: 0x3E1F760 Offset: 0x3E1F861 VA: 0x3E1F760
	|-List<BattleInfo.SupportData>.Sort
	|
	|-RVA: 0x3E22680 Offset: 0x3E22781 VA: 0x3E22680
	|-List<BeforeRenderHelper.OrderBlock>.Sort
	|
	|-RVA: 0x3E258B0 Offset: 0x3E259B1 VA: 0x3E258B0
	|-List<Camera.RenderRequest>.Sort
	|
	|-RVA: 0x3E287D0 Offset: 0x3E288D1 VA: 0x3E287D0
	|-List<CameraState.CustomBlendable>.Sort
	|
	|-RVA: 0x3E2B5E0 Offset: 0x3E2B6E1 VA: 0x3E2B5E0
	|-List<CinemachineClearShot.Pair>.Sort
	|
	|-RVA: 0x3E2E3F0 Offset: 0x3E2E4F1 VA: 0x3E2E3F0
	|-List<CinemachineStateDrivenCamera.HashPair>.Sort
	|
	|-RVA: 0x3E31610 Offset: 0x3E31711 VA: 0x3E31610
	|-List<DelayedActionManager.DelegateInfo>.Sort
	|
	|-RVA: 0x3E34A00 Offset: 0x3E34B01 VA: 0x3E34A00
	|-List<Detail.AsyncResultInt>.Sort
	|
	|-RVA: 0x3E378E0 Offset: 0x3E379E1 VA: 0x3E378E0
	|-List<Detail.CppArray>.Sort
	|
	|-RVA: 0x3E3ACD0 Offset: 0x3E3ADD1 VA: 0x3E3ACD0
	|-List<Detail.NotificationEventInt>.Sort
	|
	|-RVA: 0x3E5CFB0 Offset: 0x3E5D0B1 VA: 0x3E5CFB0
	|-List<DragonRideTargetGroup.ChainParam>.Sort
	|
	|-RVA: 0x3E601C0 Offset: 0x3E602C1 VA: 0x3E601C0
	|-List<GmapPathAdjuster.TargetModel>.Sort
	|
	|-RVA: 0x3E633D0 Offset: 0x3E634D1 VA: 0x3E633D0
	|-List<GmapSpotAdjuster.TargetModel>.Sort
	|
	|-RVA: 0x3E665E0 Offset: 0x3E666E1 VA: 0x3E665E0
	|-List<HubFastTravel.Location>.Sort
	|
	|-RVA: 0x3E69A20 Offset: 0x3E69B21 VA: 0x3E69A20
	|-List<HubLensFlare.Flare>.Sort
	|
	|-RVA: 0x3E6C940 Offset: 0x3E6CA41 VA: 0x3E6C940
	|-List<InventoryPoolItemMenuContent.KindBgNameClass>.Sort
	|
	|-RVA: 0x3E6F750 Offset: 0x3E6F851 VA: 0x3E6F750
	|-List<Map.Pos>.Sort
	|
	|-RVA: 0x3E72630 Offset: 0x3E72731 VA: 0x3E72630
	|-List<MapImage.BackupTerrain>.Sort
	|
	|-RVA: 0x3E754D0 Offset: 0x3E755D1 VA: 0x3E754D0
	|-List<MapImageRange.Pos>.Sort
	|
	|-RVA: 0x3E786E0 Offset: 0x3E787E1 VA: 0x3E786E0
	|-List<MapMind.Target>.Sort
	|
	|-RVA: 0x3D882B0 Offset: 0x3D883B1 VA: 0x3D882B0
	|-List<MapPanelDebug.Entity>.Sort
	|
	|-RVA: 0x3D8B0C0 Offset: 0x3D8B1C1 VA: 0x3D8B0C0
	|-List<NexRanking.Data>.Sort
	|
	|-RVA: 0x3D8DFA0 Offset: 0x3D8E0A1 VA: 0x3D8DFA0
	|-List<NexVersus.RatingData>.Sort
	|
	|-RVA: 0x3D90EC0 Offset: 0x3D90FC1 VA: 0x3D90EC0
	|-List<PackedPlayModeBuildLogs.RuntimeBuildLog>.Sort
	|
	|-RVA: 0x3D94270 Offset: 0x3D94371 VA: 0x3D94270
	|-List<ParticleSystem.Particle>.Sort
	|
	|-RVA: 0x3D97080 Offset: 0x3D97181 VA: 0x3D97080
	|-List<RangeData.Offset>.Sort
	|
	|-RVA: 0x3D9A2A0 Offset: 0x3D9A3A1 VA: 0x3D9A2A0
	|-List<RenderGraphDebugData.PassDebugData>.Sort
	|
	|-RVA: 0x3D9D670 Offset: 0x3D9D771 VA: 0x3D9D670
	|-List<RenderGraphDebugData.ResourceDebugData>.Sort
	|
	|-RVA: 0x3DA0590 Offset: 0x3DA0691 VA: 0x3DA0590
	|-List<RingCleaningUnitSelectMenu.GodParam>.Sort
	|
	|-RVA: 0x3DA3910 Offset: 0x3DA3A11 VA: 0x3DA3910
	|-List<ShadowUtility.Edge>.Sort
	|
	|-RVA: 0x3D15BF0 Offset: 0x3D15CF1 VA: 0x3D15BF0
	|-List<SkillArray.Entity>.Sort
	|
	|-RVA: 0x3D191B0 Offset: 0x3D192B1 VA: 0x3D191B0
	|-List<TexturePacker_JsonArray.Frame>.Sort
	|
	|-RVA: 0x3D1C3E0 Offset: 0x3D1C4E1 VA: 0x3D1C3E0
	|-List<TimeNotificationBehaviour.NotificationEntry>.Sort
	|
	|-RVA: 0x3D1F5F0 Offset: 0x3D1F6F1 VA: 0x3D1F5F0
	|-List<UnitySynchronizationContext.WorkRequest>.Sort
	|
	|-RVA: 0x3D22510 Offset: 0x3D22611 VA: 0x3D22510
	|-List<XmlSchemaObjectTable.XmlSchemaObjectEntry>.Sort
	|
	|-RVA: 0x3D25430 Offset: 0x3D25531 VA: 0x3D25430
	|-List<AssetBundleBuildMap.AssetBundleEntry.AssetPathString>.Sort
	|
	|-RVA: 0x3D28850 Offset: 0x3D28951 VA: 0x3D28850
	|-List<Detail.DataStore.DataStoreChangeMetaParamInt>.Sort
	|
	|-RVA: 0x3D2B730 Offset: 0x3D2B831 VA: 0x3D2B730
	|-List<Detail.DataStore.DataStoreDeleteParamInt>.Sort
	|
	|-RVA: 0x3D2EAD0 Offset: 0x3D2EBD1 VA: 0x3D2EAD0
	|-List<Detail.DataStore.DataStoreGetMetaParamInt>.Sort
	|
	|-RVA: 0x3D31EC0 Offset: 0x3D31FC1 VA: 0x3D31EC0
	|-List<Detail.DataStore.DataStoreMetaInfoInt>.Sort
	|
	|-RVA: 0x3CF64F0 Offset: 0x3CF65F1 VA: 0x3CF64F0
	|-List<Detail.DataStore.DataStorePasswordInfoInt>.Sort
	|
	|-RVA: 0x3CF96D0 Offset: 0x3CF97D1 VA: 0x3CF96D0
	|-List<Detail.DataStore.DataStorePersistenceInfoInt>.Sort
	|
	|-RVA: 0x3CFCA80 Offset: 0x3CFCB81 VA: 0x3CFCA80
	|-List<Detail.DataStore.DataStorePreparePostParamInt>.Sort
	|
	|-RVA: 0x3CFF960 Offset: 0x3CFFA61 VA: 0x3CFF960
	|-List<Detail.DataStore.DataStoreRateObjectParamInt>.Sort
	|
	|-RVA: 0x3D02B50 Offset: 0x3D02C51 VA: 0x3D02B50
	|-List<Detail.DataStore.DataStoreRatingInitParamInt>.Sort
	|
	|-RVA: 0x3D05A30 Offset: 0x3D05B31 VA: 0x3D05A30
	|-List<Detail.DataStore.DataStoreRatingTargetInt>.Sort
	|
	|-RVA: 0x3D09010 Offset: 0x3D09111 VA: 0x3D09010
	|-List<Detail.Ranking.RankingCachedResultInt>.Sort
	|
	|-RVA: 0x3D0BEF0 Offset: 0x3D0BFF1 VA: 0x3D0BEF0
	|-List<Detail.Ranking.RankingOrderParamInt>.Sort
	|
	|-RVA: 0x3D0F470 Offset: 0x3D0F571 VA: 0x3D0F470
	|-List<Detail.Ranking.RankingRankDataInt>.Sort
	|
	|-RVA: 0x3D12DE0 Offset: 0x3D12EE1 VA: 0x3D12DE0
	|-List<Detail.Ranking2.Ranking2ChartInfoInt>.Sort
	|
	|-RVA: 0x3D693F0 Offset: 0x3D694F1 VA: 0x3D693F0
	|-List<Detail.Ranking2.Ranking2RankDataInt>.Sort
	|
	|-RVA: 0x3D6C2D0 Offset: 0x3D6C3D1 VA: 0x3D6C2D0
	|-List<Detail.Ranking2.Ranking2ScoreDataInt>.Sort
	|
	|-RVA: 0x3D6F4C0 Offset: 0x3D6F5C1 VA: 0x3D6F4C0
	|-List<Detail.Screening.ScreeningContextInfoInt>.Sort
	|
	|-RVA: 0x3D72C90 Offset: 0x3D72D91 VA: 0x3D72C90
	|-List<Detail.Subscriber.SubscriberContentInt>.Sort
	|
	|-RVA: 0x3D75E70 Offset: 0x3D75F71 VA: 0x3D75E70
	|-List<Detail.Subscriber.SubscriberGetContentParamInt>.Sort
	|
	|-RVA: 0x3D79210 Offset: 0x3D79311 VA: 0x3D79210
	|-List<Detail.Subscriber.SubscriberUserStatusInfoInt>.Sort
	|
	|-RVA: 0x3D7C3F0 Offset: 0x3D7C4F1 VA: 0x3D7C3F0
	|-List<Detail.Subscriber.SubscriberUserStatusParamInt>.Sort
	|
	|-RVA: 0x3D7F200 Offset: 0x3D7F301 VA: 0x3D7F200
	|-List<Detail.Utility.IntegerSettings>.Sort
	|
	|-RVA: 0x3D820E0 Offset: 0x3D821E1 VA: 0x3D820E0
	|-List<Detail.Utility.UniqueIdInfoInt>.Sort
	|
	|-RVA: 0x3D850D0 Offset: 0x3D851D1 VA: 0x3D850D0
	|-List<MapHistory.Rewind.LatestInspectorData>.Sort
	|
	|-RVA: 0x3061390 Offset: 0x3061491 VA: 0x3061390
	|-List<MapHistory.Rewind.WorkTerrainData>.Sort
	|
	|-RVA: 0x30642B0 Offset: 0x30643B1 VA: 0x30642B0
	|-List<MapSkill.AroundCalculator.Result>.Sort
	|
	|-RVA: 0x3067630 Offset: 0x3067731 VA: 0x3067630
	|-List<TargetPositionCache.CacheCurve.Item>.Sort
	|
	|-RVA: 0x306AA50 Offset: 0x306AB51 VA: 0x306AA50
	|-List<TargetPositionCache.CacheEntry.RecordingItem>.Sort
	*/

	// RVA: -1 Offset: -1
	public void Sort(int index, int count, IComparer<T> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3B0D220 Offset: 0x3B0D321 VA: 0x3B0D220
	|-List<IntervalTree.Entry<object>>.Sort
	|
	|-RVA: 0x3B10140 Offset: 0x3B10241 VA: 0x3B10140
	|-List<KeyValuePair<DateTime, object>>.Sort
	|
	|-RVA: 0x3B13060 Offset: 0x3B13161 VA: 0x3B13060
	|-List<KeyValuePair<int, object>>.Sort
	|
	|-RVA: 0x3B16280 Offset: 0x3B16381 VA: 0x3B16280
	|-List<KeyValuePair<object, ValueTuple<int, DateTime, object>>>.Sort
	|
	|-RVA: 0x3B191A0 Offset: 0x3B192A1 VA: 0x3B191A0
	|-List<KeyValuePair<object, object>>.Sort
	|
	|-RVA: 0x3B1C3B0 Offset: 0x3B1C4B1 VA: 0x3B1C3B0
	|-List<CommonBattleSequence.Reliance<object>>.Sort
	|
	|-RVA: 0x3B1F2D0 Offset: 0x3B1F3D1 VA: 0x3B1F2D0
	|-List<RenderGraphResourcePool.ResourceLogInfo<object>>.Sort
	|
	|-RVA: 0x3B221F0 Offset: 0x3B222F1 VA: 0x3B221F0
	|-List<ValueTuple<int, object>>.Sort
	|
	|-RVA: 0x3DE2D70 Offset: 0x3DE2E71 VA: 0x3DE2D70
	|-List<ValueTuple<Int32Enum, int>>.Sort
	|
	|-RVA: 0x3DE5F80 Offset: 0x3DE6081 VA: 0x3DE5F80
	|-List<ValueTuple<object, ValueTuple<object, int>>>.Sort
	|
	|-RVA: 0x3DE8EA0 Offset: 0x3DE8FA1 VA: 0x3DE8EA0
	|-List<ValueTuple<object, int>>.Sort
	|
	|-RVA: 0x3DEBEA0 Offset: 0x3DEBFA1 VA: 0x3DEBEA0
	|-List<ValueTuple<Vector3, float>>.Sort
	|
	|-RVA: 0x3DEEDC0 Offset: 0x3DEEEC1 VA: 0x3DEEDC0
	|-List<ValueTuple<object, Int32Enum, int>>.Sort
	|
	|-RVA: 0x3DF1FD0 Offset: 0x3DF20D1 VA: 0x3DF1FD0
	|-List<ValueTuple<object, int, int, int>>.Sort
	|
	|-RVA: 0x3DF4DE0 Offset: 0x3DF4EE1 VA: 0x3DF4DE0
	|-List<AnimatorClipInfo>.Sort
	|
	|-RVA: 0x3DF7FF0 Offset: 0x3DF80F1 VA: 0x3DF7FF0
	|-List<AsyncOperationHandle>.Sort
	|
	|-RVA: 0x3DFB1E0 Offset: 0x3DFB2E1 VA: 0x3DFB1E0
	|-List<BoneWeight>.Sort
	|
	|-RVA: 0x3DFE010 Offset: 0x3DFE111 VA: 0x3DFE010
	|-List<bool>.Sort
	|
	|-RVA: 0x3E7B550 Offset: 0x3E7B651 VA: 0x3E7B550
	|-List<byte>.Sort
	|
	|-RVA: 0x3E7E470 Offset: 0x3E7E571 VA: 0x3E7E470
	|-List<CameraInfo>.Sort
	|
	|-RVA: 0x3E81270 Offset: 0x3E81371 VA: 0x3E81270
	|-List<char>.Sort
	|
	|-RVA: 0x3E84270 Offset: 0x3E84371 VA: 0x3E84270
	|-List<Color>.Sort
	|
	|-RVA: 0x3E87080 Offset: 0x3E87181 VA: 0x3E87080
	|-List<Color32>.Sort
	|
	|-RVA: 0x3E89FA0 Offset: 0x3E8A0A1 VA: 0x3E89FA0
	|-List<ConstraintSource>.Sort
	|
	|-RVA: 0x3E8D1B0 Offset: 0x3E8D2B1 VA: 0x3E8D1B0
	|-List<ContourVertex>.Sort
	|
	|-RVA: 0x3E90390 Offset: 0x3E90491 VA: 0x3E90390
	|-List<DataStoreRatingInfo>.Sort
	|
	|-RVA: 0x3E931A0 Offset: 0x3E932A1 VA: 0x3E931A0
	|-List<DataStoreResult>.Sort
	|
	|-RVA: 0x3E95FB0 Offset: 0x3E960B1 VA: 0x3E95FB0
	|-List<DateTime>.Sort
	|
	|-RVA: 0x3E98E90 Offset: 0x3E98F91 VA: 0x3E98E90
	|-List<DateTimeOffset>.Sort
	|
	|-RVA: 0x3E9BD70 Offset: 0x3E9BE71 VA: 0x3E9BD70
	|-List<Decimal>.Sort
	|
	|-RVA: 0x3E9F1B0 Offset: 0x3E9F2B1 VA: 0x3E9F1B0
	|-List<DiagnosticEvent>.Sort
	|
	|-RVA: 0x3EA1FD0 Offset: 0x3EA20D1 VA: 0x3EA1FD0
	|-List<double>.Sort
	|
	|-RVA: 0x3EA5360 Offset: 0x3EA5461 VA: 0x3EA5360
	|-List<Friend>.Sort
	|
	|-RVA: 0x3EA8240 Offset: 0x3EA8341 VA: 0x3EA8240
	|-List<GlyphRect>.Sort
	|
	|-RVA: 0x3EAB040 Offset: 0x3EAB141 VA: 0x3EAB040
	|-List<short>.Sort
	|
	|-RVA: 0x3EADE40 Offset: 0x3EADF41 VA: 0x3EADE40
	|-List<int>.Sort
	|
	|-RVA: 0x3EB0C40 Offset: 0x3EB0D41 VA: 0x3EB0C40
	|-List<Int32Enum>.Sort
	|
	|-RVA: 0x3EB3A40 Offset: 0x3EB3B41 VA: 0x3EB3A40
	|-List<long>.Sort
	|
	|-RVA: 0x3E00E10 Offset: 0x3E00F11 VA: 0x3E00E10
	|-List<IntPtr>.Sort
	|
	|-RVA: 0x3E03D30 Offset: 0x3E03E31 VA: 0x3E03D30
	|-List<InterpretedFrameInfo>.Sort
	|
	|-RVA: 0x3E06F10 Offset: 0x3E07011 VA: 0x3E06F10
	|-List<IntervalTreeNode>.Sort
	|
	|-RVA: 0x3E09D20 Offset: 0x3E09E21 VA: 0x3E09D20
	|-List<LengthLimitProperties>.Sort
	|
	|-RVA: 0x3E0CB30 Offset: 0x3E0CC31 VA: 0x3E0CB30
	|-List<MapPos>.Sort
	|
	|-RVA: 0x3E100B0 Offset: 0x3E101B1 VA: 0x3E100B0
	|-List<Matrix4x4>.Sort
	|
	|-RVA: 0x3E12E70 Offset: 0x3E12F71 VA: 0x3E12E70
	|-List<object>.Sort
	|-List<RegexCharClass.SingleRange>.Sort
	|
	|-RVA: 0x3E162B0 Offset: 0x3E163B1 VA: 0x3E162B0
	|-List<ObjectInitializationData>.Sort
	|
	|-RVA: 0x3E194D0 Offset: 0x3E195D1 VA: 0x3E194D0
	|-List<PlayableBinding>.Sort
	|
	|-RVA: 0x3E1C8A0 Offset: 0x3E1C9A1 VA: 0x3E1C8A0
	|-List<PlayerLoopSystem>.Sort
	|
	|-RVA: 0x3DA6D40 Offset: 0x3DA6E41 VA: 0x3DA6D40
	|-List<PlayerLoopSystemInternal>.Sort
	|
	|-RVA: 0x3DA9C60 Offset: 0x3DA9D61 VA: 0x3DA9C60
	|-List<RangePositionInfo>.Sort
	|
	|-RVA: 0x3DACA70 Offset: 0x3DACB71 VA: 0x3DACA70
	|-List<Ranking2ChartInfoInput>.Sort
	|
	|-RVA: 0x3DAFE90 Offset: 0x3DAFF91 VA: 0x3DAFE90
	|-List<RaycastHit2D>.Sort
	|
	|-RVA: 0x3DB36A0 Offset: 0x3DB37A1 VA: 0x3DB36A0
	|-List<RaycastResult>.Sort
	|
	|-RVA: 0x3DB66A0 Offset: 0x3DB67A1 VA: 0x3DB66A0
	|-List<Rect>.Sort
	|
	|-RVA: 0x3DB94B0 Offset: 0x3DB95B1 VA: 0x3DB94B0
	|-List<RendererListHandle>.Sort
	|
	|-RVA: 0x3DBC2C0 Offset: 0x3DBC3C1 VA: 0x3DBC2C0
	|-List<ResourceHandle>.Sort
	|
	|-RVA: 0x3DBF0D0 Offset: 0x3DBF1D1 VA: 0x3DBF0D0
	|-List<sbyte>.Sort
	|
	|-RVA: 0x3DC1EE0 Offset: 0x3DC1FE1 VA: 0x3DC1EE0
	|-List<ShaderTagId>.Sort
	|
	|-RVA: 0x3E3DB50 Offset: 0x3E3DC51 VA: 0x3E3DB50
	|-List<float>.Sort
	|
	|-RVA: 0x3E41830 Offset: 0x3E41931 VA: 0x3E41830
	|-List<SphericalHarmonicsL2>.Sort
	|
	|-RVA: 0x3E44C20 Offset: 0x3E44D21 VA: 0x3E44C20
	|-List<SubMeshDescriptor>.Sort
	|
	|-RVA: 0x3E47B40 Offset: 0x3E47C41 VA: 0x3E47B40
	|-List<TablePair>.Sort
	|
	|-RVA: 0x3E4A950 Offset: 0x3E4AA51 VA: 0x3E4A950
	|-List<TimeSpan>.Sort
	|
	|-RVA: 0x3E4D930 Offset: 0x3E4DA31 VA: 0x3E4D930
	|-List<UICharInfo>.Sort
	|
	|-RVA: 0x3E50810 Offset: 0x3E50911 VA: 0x3E50810
	|-List<UILineInfo>.Sort
	|
	|-RVA: 0x3E544F0 Offset: 0x3E545F1 VA: 0x3E544F0
	|-List<UIVertex>.Sort
	|
	|-RVA: 0x3E572F0 Offset: 0x3E573F1 VA: 0x3E572F0
	|-List<ushort>.Sort
	|
	|-RVA: 0x3E5A0F0 Offset: 0x3E5A1F1 VA: 0x3E5A0F0
	|-List<uint>.Sort
	|
	|-RVA: 0x3DC4CE0 Offset: 0x3DC4DE1 VA: 0x3DC4CE0
	|-List<ulong>.Sort
	|
	|-RVA: 0x3DC7BB0 Offset: 0x3DC7CB1 VA: 0x3DC7BB0
	|-List<Vector2>.Sort
	|
	|-RVA: 0x3DCAB90 Offset: 0x3DCAC91 VA: 0x3DCAB90
	|-List<Vector3>.Sort
	|
	|-RVA: 0x3DCDB90 Offset: 0x3DCDC91 VA: 0x3DCDB90
	|-List<Vector4>.Sort
	|
	|-RVA: 0x3DD0A70 Offset: 0x3DD0B71 VA: 0x3DD0A70
	|-List<VertexAttributeDescriptor>.Sort
	|
	|-RVA: 0x3DD3990 Offset: 0x3DD3A91 VA: 0x3DD3990
	|-List<X509ChainStatus>.Sort
	|
	|-RVA: 0x3DD6D80 Offset: 0x3DD6E81 VA: 0x3DD6D80
	|-List<XRView>.Sort
	|
	|-RVA: 0x3DD9CA0 Offset: 0x3DD9DA1 VA: 0x3DD9CA0
	|-List<AmiiboSequence.GainItemData>.Sort
	|
	|-RVA: 0x3DDD040 Offset: 0x3DDD141 VA: 0x3DDD040
	|-List<AnimationOutputWeightProcessor.WeightInfo>.Sort
	|
	|-RVA: 0x3DDFF60 Offset: 0x3DE0061 VA: 0x3DDFF60
	|-List<ArenaOrderSequence.GodInfo>.Sort
	|
	|-RVA: 0x3E1F7C0 Offset: 0x3E1F8C1 VA: 0x3E1F7C0
	|-List<BattleInfo.SupportData>.Sort
	|
	|-RVA: 0x3E226E0 Offset: 0x3E227E1 VA: 0x3E226E0
	|-List<BeforeRenderHelper.OrderBlock>.Sort
	|
	|-RVA: 0x3E25910 Offset: 0x3E25A11 VA: 0x3E25910
	|-List<Camera.RenderRequest>.Sort
	|
	|-RVA: 0x3E28830 Offset: 0x3E28931 VA: 0x3E28830
	|-List<CameraState.CustomBlendable>.Sort
	|
	|-RVA: 0x3E2B640 Offset: 0x3E2B741 VA: 0x3E2B640
	|-List<CinemachineClearShot.Pair>.Sort
	|
	|-RVA: 0x3E2E450 Offset: 0x3E2E551 VA: 0x3E2E450
	|-List<CinemachineStateDrivenCamera.HashPair>.Sort
	|
	|-RVA: 0x3E31670 Offset: 0x3E31771 VA: 0x3E31670
	|-List<DelayedActionManager.DelegateInfo>.Sort
	|
	|-RVA: 0x3E34A60 Offset: 0x3E34B61 VA: 0x3E34A60
	|-List<Detail.AsyncResultInt>.Sort
	|
	|-RVA: 0x3E37940 Offset: 0x3E37A41 VA: 0x3E37940
	|-List<Detail.CppArray>.Sort
	|
	|-RVA: 0x3E3AD30 Offset: 0x3E3AE31 VA: 0x3E3AD30
	|-List<Detail.NotificationEventInt>.Sort
	|
	|-RVA: 0x3E5D010 Offset: 0x3E5D111 VA: 0x3E5D010
	|-List<DragonRideTargetGroup.ChainParam>.Sort
	|
	|-RVA: 0x3E60220 Offset: 0x3E60321 VA: 0x3E60220
	|-List<GmapPathAdjuster.TargetModel>.Sort
	|
	|-RVA: 0x3E63430 Offset: 0x3E63531 VA: 0x3E63430
	|-List<GmapSpotAdjuster.TargetModel>.Sort
	|
	|-RVA: 0x3E66640 Offset: 0x3E66741 VA: 0x3E66640
	|-List<HubFastTravel.Location>.Sort
	|
	|-RVA: 0x3E69A80 Offset: 0x3E69B81 VA: 0x3E69A80
	|-List<HubLensFlare.Flare>.Sort
	|
	|-RVA: 0x3E6C9A0 Offset: 0x3E6CAA1 VA: 0x3E6C9A0
	|-List<InventoryPoolItemMenuContent.KindBgNameClass>.Sort
	|
	|-RVA: 0x3E6F7B0 Offset: 0x3E6F8B1 VA: 0x3E6F7B0
	|-List<Map.Pos>.Sort
	|
	|-RVA: 0x3E72690 Offset: 0x3E72791 VA: 0x3E72690
	|-List<MapImage.BackupTerrain>.Sort
	|
	|-RVA: 0x3E75530 Offset: 0x3E75631 VA: 0x3E75530
	|-List<MapImageRange.Pos>.Sort
	|
	|-RVA: 0x3E78740 Offset: 0x3E78841 VA: 0x3E78740
	|-List<MapMind.Target>.Sort
	|
	|-RVA: 0x3D88310 Offset: 0x3D88411 VA: 0x3D88310
	|-List<MapPanelDebug.Entity>.Sort
	|
	|-RVA: 0x3D8B120 Offset: 0x3D8B221 VA: 0x3D8B120
	|-List<NexRanking.Data>.Sort
	|
	|-RVA: 0x3D8E000 Offset: 0x3D8E101 VA: 0x3D8E000
	|-List<NexVersus.RatingData>.Sort
	|
	|-RVA: 0x3D90F20 Offset: 0x3D91021 VA: 0x3D90F20
	|-List<PackedPlayModeBuildLogs.RuntimeBuildLog>.Sort
	|
	|-RVA: 0x3D942D0 Offset: 0x3D943D1 VA: 0x3D942D0
	|-List<ParticleSystem.Particle>.Sort
	|
	|-RVA: 0x3D970E0 Offset: 0x3D971E1 VA: 0x3D970E0
	|-List<RangeData.Offset>.Sort
	|
	|-RVA: 0x3D9A300 Offset: 0x3D9A401 VA: 0x3D9A300
	|-List<RenderGraphDebugData.PassDebugData>.Sort
	|
	|-RVA: 0x3D9D6D0 Offset: 0x3D9D7D1 VA: 0x3D9D6D0
	|-List<RenderGraphDebugData.ResourceDebugData>.Sort
	|
	|-RVA: 0x3DA05F0 Offset: 0x3DA06F1 VA: 0x3DA05F0
	|-List<RingCleaningUnitSelectMenu.GodParam>.Sort
	|
	|-RVA: 0x3DA3970 Offset: 0x3DA3A71 VA: 0x3DA3970
	|-List<ShadowUtility.Edge>.Sort
	|
	|-RVA: 0x3D15C50 Offset: 0x3D15D51 VA: 0x3D15C50
	|-List<SkillArray.Entity>.Sort
	|
	|-RVA: 0x3D19210 Offset: 0x3D19311 VA: 0x3D19210
	|-List<TexturePacker_JsonArray.Frame>.Sort
	|
	|-RVA: 0x3D1C440 Offset: 0x3D1C541 VA: 0x3D1C440
	|-List<TimeNotificationBehaviour.NotificationEntry>.Sort
	|
	|-RVA: 0x3D1F650 Offset: 0x3D1F751 VA: 0x3D1F650
	|-List<UnitySynchronizationContext.WorkRequest>.Sort
	|
	|-RVA: 0x3D22570 Offset: 0x3D22671 VA: 0x3D22570
	|-List<XmlSchemaObjectTable.XmlSchemaObjectEntry>.Sort
	|
	|-RVA: 0x3D25490 Offset: 0x3D25591 VA: 0x3D25490
	|-List<AssetBundleBuildMap.AssetBundleEntry.AssetPathString>.Sort
	|
	|-RVA: 0x3D288B0 Offset: 0x3D289B1 VA: 0x3D288B0
	|-List<Detail.DataStore.DataStoreChangeMetaParamInt>.Sort
	|
	|-RVA: 0x3D2B790 Offset: 0x3D2B891 VA: 0x3D2B790
	|-List<Detail.DataStore.DataStoreDeleteParamInt>.Sort
	|
	|-RVA: 0x3D2EB30 Offset: 0x3D2EC31 VA: 0x3D2EB30
	|-List<Detail.DataStore.DataStoreGetMetaParamInt>.Sort
	|
	|-RVA: 0x3D31F20 Offset: 0x3D32021 VA: 0x3D31F20
	|-List<Detail.DataStore.DataStoreMetaInfoInt>.Sort
	|
	|-RVA: 0x3CF6550 Offset: 0x3CF6651 VA: 0x3CF6550
	|-List<Detail.DataStore.DataStorePasswordInfoInt>.Sort
	|
	|-RVA: 0x3CF9730 Offset: 0x3CF9831 VA: 0x3CF9730
	|-List<Detail.DataStore.DataStorePersistenceInfoInt>.Sort
	|
	|-RVA: 0x3CFCAE0 Offset: 0x3CFCBE1 VA: 0x3CFCAE0
	|-List<Detail.DataStore.DataStorePreparePostParamInt>.Sort
	|
	|-RVA: 0x3CFF9C0 Offset: 0x3CFFAC1 VA: 0x3CFF9C0
	|-List<Detail.DataStore.DataStoreRateObjectParamInt>.Sort
	|
	|-RVA: 0x3D02BB0 Offset: 0x3D02CB1 VA: 0x3D02BB0
	|-List<Detail.DataStore.DataStoreRatingInitParamInt>.Sort
	|
	|-RVA: 0x3D05A90 Offset: 0x3D05B91 VA: 0x3D05A90
	|-List<Detail.DataStore.DataStoreRatingTargetInt>.Sort
	|
	|-RVA: 0x3D09070 Offset: 0x3D09171 VA: 0x3D09070
	|-List<Detail.Ranking.RankingCachedResultInt>.Sort
	|
	|-RVA: 0x3D0BF50 Offset: 0x3D0C051 VA: 0x3D0BF50
	|-List<Detail.Ranking.RankingOrderParamInt>.Sort
	|
	|-RVA: 0x3D0F4D0 Offset: 0x3D0F5D1 VA: 0x3D0F4D0
	|-List<Detail.Ranking.RankingRankDataInt>.Sort
	|
	|-RVA: 0x3D12E40 Offset: 0x3D12F41 VA: 0x3D12E40
	|-List<Detail.Ranking2.Ranking2ChartInfoInt>.Sort
	|
	|-RVA: 0x3D69450 Offset: 0x3D69551 VA: 0x3D69450
	|-List<Detail.Ranking2.Ranking2RankDataInt>.Sort
	|
	|-RVA: 0x3D6C330 Offset: 0x3D6C431 VA: 0x3D6C330
	|-List<Detail.Ranking2.Ranking2ScoreDataInt>.Sort
	|
	|-RVA: 0x3D6F520 Offset: 0x3D6F621 VA: 0x3D6F520
	|-List<Detail.Screening.ScreeningContextInfoInt>.Sort
	|
	|-RVA: 0x3D72CF0 Offset: 0x3D72DF1 VA: 0x3D72CF0
	|-List<Detail.Subscriber.SubscriberContentInt>.Sort
	|
	|-RVA: 0x3D75ED0 Offset: 0x3D75FD1 VA: 0x3D75ED0
	|-List<Detail.Subscriber.SubscriberGetContentParamInt>.Sort
	|
	|-RVA: 0x3D79270 Offset: 0x3D79371 VA: 0x3D79270
	|-List<Detail.Subscriber.SubscriberUserStatusInfoInt>.Sort
	|
	|-RVA: 0x3D7C450 Offset: 0x3D7C551 VA: 0x3D7C450
	|-List<Detail.Subscriber.SubscriberUserStatusParamInt>.Sort
	|
	|-RVA: 0x3D7F260 Offset: 0x3D7F361 VA: 0x3D7F260
	|-List<Detail.Utility.IntegerSettings>.Sort
	|
	|-RVA: 0x3D82140 Offset: 0x3D82241 VA: 0x3D82140
	|-List<Detail.Utility.UniqueIdInfoInt>.Sort
	|
	|-RVA: 0x3D85130 Offset: 0x3D85231 VA: 0x3D85130
	|-List<MapHistory.Rewind.LatestInspectorData>.Sort
	|
	|-RVA: 0x30613F0 Offset: 0x30614F1 VA: 0x30613F0
	|-List<MapHistory.Rewind.WorkTerrainData>.Sort
	|
	|-RVA: 0x3064310 Offset: 0x3064411 VA: 0x3064310
	|-List<MapSkill.AroundCalculator.Result>.Sort
	|
	|-RVA: 0x3067690 Offset: 0x3067791 VA: 0x3067690
	|-List<TargetPositionCache.CacheCurve.Item>.Sort
	|
	|-RVA: 0x306AAB0 Offset: 0x306ABB1 VA: 0x306AAB0
	|-List<TargetPositionCache.CacheEntry.RecordingItem>.Sort
	*/

	// RVA: -1 Offset: -1
	public void Sort(Comparison<T> comparison) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3E12F40 Offset: 0x3E13041 VA: 0x3E12F40
	|-List<<>f__AnonymousType0<SpringBone, int>>.Sort
	|-List<StructDataArrayList<TutorialData>>.Sort
	|-List<AnimationClip>.Sort
	|-List<BasicMenuItem>.Sort
	|-List<CinemachineComponentBase>.Sort
	|-List<DataStoreRatingTarget>.Sort
	|-List<DynValue>.Sort
	|-List<ForecastFishData>.Sort
	|-List<GodUnit>.Sort
	|-List<Graphic>.Sort
	|-List<HubAreaFog>.Sort
	|-List<HubDisposData>.Sort
	|-List<ItemData>.Sort
	|-List<Level2Map>.Sort
	|-List<Light2D>.Sort
	|-List<MovieDefineData>.Sort
	|-List<object>.Sort
	|-List<PrefetchedSignal>.Sort
	|-List<RelayCompletionAwardData>.Sort
	|-List<RelayStampData>.Sort
	|-List<RewardData>.Sort
	|-List<SkillData>.Sort
	|-List<string>.Sort
	|-List<TMP_FontAsset>.Sort
	|-List<Unit>.Sort
	|-List<UnitRelianceMapResult>.Sort
	|-List<AIInterruptAttack.Candidate>.Sort
	|-List<MapPrefab.Entity>.Sort
	|-List<MapTarget.Data>.Sort
	|-List<TimeZoneInfo.AdjustmentRule>.Sort
	|
	|-RVA: 0x3B0D2F0 Offset: 0x3B0D3F1 VA: 0x3B0D2F0
	|-List<IntervalTree.Entry<object>>.Sort
	|
	|-RVA: 0x3B10210 Offset: 0x3B10311 VA: 0x3B10210
	|-List<KeyValuePair<DateTime, object>>.Sort
	|
	|-RVA: 0x3B13130 Offset: 0x3B13231 VA: 0x3B13130
	|-List<KeyValuePair<int, object>>.Sort
	|
	|-RVA: 0x3B16350 Offset: 0x3B16451 VA: 0x3B16350
	|-List<KeyValuePair<object, ValueTuple<int, DateTime, object>>>.Sort
	|
	|-RVA: 0x3B19270 Offset: 0x3B19371 VA: 0x3B19270
	|-List<KeyValuePair<object, object>>.Sort
	|
	|-RVA: 0x3B1C480 Offset: 0x3B1C581 VA: 0x3B1C480
	|-List<CommonBattleSequence.Reliance<object>>.Sort
	|
	|-RVA: 0x3B1F3A0 Offset: 0x3B1F4A1 VA: 0x3B1F3A0
	|-List<RenderGraphResourcePool.ResourceLogInfo<object>>.Sort
	|
	|-RVA: 0x3B222C0 Offset: 0x3B223C1 VA: 0x3B222C0
	|-List<ValueTuple<int, object>>.Sort
	|
	|-RVA: 0x3DE2E40 Offset: 0x3DE2F41 VA: 0x3DE2E40
	|-List<ValueTuple<Int32Enum, int>>.Sort
	|
	|-RVA: 0x3DE6050 Offset: 0x3DE6151 VA: 0x3DE6050
	|-List<ValueTuple<object, ValueTuple<object, int>>>.Sort
	|
	|-RVA: 0x3DE8F70 Offset: 0x3DE9071 VA: 0x3DE8F70
	|-List<ValueTuple<object, int>>.Sort
	|
	|-RVA: 0x3DEBF70 Offset: 0x3DEC071 VA: 0x3DEBF70
	|-List<ValueTuple<Vector3, float>>.Sort
	|
	|-RVA: 0x3DEEE90 Offset: 0x3DEEF91 VA: 0x3DEEE90
	|-List<ValueTuple<object, Int32Enum, int>>.Sort
	|
	|-RVA: 0x3DF20A0 Offset: 0x3DF21A1 VA: 0x3DF20A0
	|-List<ValueTuple<object, int, int, int>>.Sort
	|-List<ValueTuple<string, int, int, int>>.Sort
	|
	|-RVA: 0x3DF4EB0 Offset: 0x3DF4FB1 VA: 0x3DF4EB0
	|-List<AnimatorClipInfo>.Sort
	|
	|-RVA: 0x3DF80C0 Offset: 0x3DF81C1 VA: 0x3DF80C0
	|-List<AsyncOperationHandle>.Sort
	|
	|-RVA: 0x3DFB2B0 Offset: 0x3DFB3B1 VA: 0x3DFB2B0
	|-List<BoneWeight>.Sort
	|
	|-RVA: 0x3DFE0E0 Offset: 0x3DFE1E1 VA: 0x3DFE0E0
	|-List<bool>.Sort
	|
	|-RVA: 0x3E7B620 Offset: 0x3E7B721 VA: 0x3E7B620
	|-List<byte>.Sort
	|
	|-RVA: 0x3E7E540 Offset: 0x3E7E641 VA: 0x3E7E540
	|-List<CameraInfo>.Sort
	|
	|-RVA: 0x3E81340 Offset: 0x3E81441 VA: 0x3E81340
	|-List<char>.Sort
	|
	|-RVA: 0x3E84340 Offset: 0x3E84441 VA: 0x3E84340
	|-List<Color>.Sort
	|
	|-RVA: 0x3E87150 Offset: 0x3E87251 VA: 0x3E87150
	|-List<Color32>.Sort
	|
	|-RVA: 0x3E8A070 Offset: 0x3E8A171 VA: 0x3E8A070
	|-List<ConstraintSource>.Sort
	|
	|-RVA: 0x3E8D280 Offset: 0x3E8D381 VA: 0x3E8D280
	|-List<ContourVertex>.Sort
	|
	|-RVA: 0x3E90460 Offset: 0x3E90561 VA: 0x3E90460
	|-List<DataStoreRatingInfo>.Sort
	|
	|-RVA: 0x3E93270 Offset: 0x3E93371 VA: 0x3E93270
	|-List<DataStoreResult>.Sort
	|
	|-RVA: 0x3E96080 Offset: 0x3E96181 VA: 0x3E96080
	|-List<DateTime>.Sort
	|
	|-RVA: 0x3E98F60 Offset: 0x3E99061 VA: 0x3E98F60
	|-List<DateTimeOffset>.Sort
	|
	|-RVA: 0x3E9BE40 Offset: 0x3E9BF41 VA: 0x3E9BE40
	|-List<Decimal>.Sort
	|
	|-RVA: 0x3E9F280 Offset: 0x3E9F381 VA: 0x3E9F280
	|-List<DiagnosticEvent>.Sort
	|
	|-RVA: 0x3EA20A0 Offset: 0x3EA21A1 VA: 0x3EA20A0
	|-List<double>.Sort
	|
	|-RVA: 0x3EA5430 Offset: 0x3EA5531 VA: 0x3EA5430
	|-List<Friend>.Sort
	|
	|-RVA: 0x3EA8310 Offset: 0x3EA8411 VA: 0x3EA8310
	|-List<GlyphRect>.Sort
	|
	|-RVA: 0x3EAB110 Offset: 0x3EAB211 VA: 0x3EAB110
	|-List<short>.Sort
	|
	|-RVA: 0x3EADF10 Offset: 0x3EAE011 VA: 0x3EADF10
	|-List<int>.Sort
	|
	|-RVA: 0x3EB0D10 Offset: 0x3EB0E11 VA: 0x3EB0D10
	|-List<Int32Enum>.Sort
	|
	|-RVA: 0x3EB3B10 Offset: 0x3EB3C11 VA: 0x3EB3B10
	|-List<long>.Sort
	|
	|-RVA: 0x3E00EE0 Offset: 0x3E00FE1 VA: 0x3E00EE0
	|-List<IntPtr>.Sort
	|
	|-RVA: 0x3E03E00 Offset: 0x3E03F01 VA: 0x3E03E00
	|-List<InterpretedFrameInfo>.Sort
	|
	|-RVA: 0x3E06FE0 Offset: 0x3E070E1 VA: 0x3E06FE0
	|-List<IntervalTreeNode>.Sort
	|
	|-RVA: 0x3E09DF0 Offset: 0x3E09EF1 VA: 0x3E09DF0
	|-List<LengthLimitProperties>.Sort
	|
	|-RVA: 0x3E0CC00 Offset: 0x3E0CD01 VA: 0x3E0CC00
	|-List<MapPos>.Sort
	|
	|-RVA: 0x3E10180 Offset: 0x3E10281 VA: 0x3E10180
	|-List<Matrix4x4>.Sort
	|
	|-RVA: 0x3E16380 Offset: 0x3E16481 VA: 0x3E16380
	|-List<ObjectInitializationData>.Sort
	|
	|-RVA: 0x3E195A0 Offset: 0x3E196A1 VA: 0x3E195A0
	|-List<PlayableBinding>.Sort
	|
	|-RVA: 0x3E1C970 Offset: 0x3E1CA71 VA: 0x3E1C970
	|-List<PlayerLoopSystem>.Sort
	|
	|-RVA: 0x3DA6E10 Offset: 0x3DA6F11 VA: 0x3DA6E10
	|-List<PlayerLoopSystemInternal>.Sort
	|
	|-RVA: 0x3DA9D30 Offset: 0x3DA9E31 VA: 0x3DA9D30
	|-List<RangePositionInfo>.Sort
	|
	|-RVA: 0x3DACB40 Offset: 0x3DACC41 VA: 0x3DACB40
	|-List<Ranking2ChartInfoInput>.Sort
	|
	|-RVA: 0x3DAFF60 Offset: 0x3DB0061 VA: 0x3DAFF60
	|-List<RaycastHit2D>.Sort
	|
	|-RVA: 0x3DB3770 Offset: 0x3DB3871 VA: 0x3DB3770
	|-List<RaycastResult>.Sort
	|
	|-RVA: 0x3DB6770 Offset: 0x3DB6871 VA: 0x3DB6770
	|-List<Rect>.Sort
	|
	|-RVA: 0x3DB9580 Offset: 0x3DB9681 VA: 0x3DB9580
	|-List<RendererListHandle>.Sort
	|
	|-RVA: 0x3DBC390 Offset: 0x3DBC491 VA: 0x3DBC390
	|-List<ResourceHandle>.Sort
	|
	|-RVA: 0x3DBF1A0 Offset: 0x3DBF2A1 VA: 0x3DBF1A0
	|-List<sbyte>.Sort
	|
	|-RVA: 0x3DC1FB0 Offset: 0x3DC20B1 VA: 0x3DC1FB0
	|-List<ShaderTagId>.Sort
	|
	|-RVA: 0x3E3DC20 Offset: 0x3E3DD21 VA: 0x3E3DC20
	|-List<float>.Sort
	|
	|-RVA: 0x3E41900 Offset: 0x3E41A01 VA: 0x3E41900
	|-List<SphericalHarmonicsL2>.Sort
	|
	|-RVA: 0x3E44CF0 Offset: 0x3E44DF1 VA: 0x3E44CF0
	|-List<SubMeshDescriptor>.Sort
	|
	|-RVA: 0x3E47C10 Offset: 0x3E47D11 VA: 0x3E47C10
	|-List<TablePair>.Sort
	|
	|-RVA: 0x3E4AA20 Offset: 0x3E4AB21 VA: 0x3E4AA20
	|-List<TimeSpan>.Sort
	|
	|-RVA: 0x3E4DA00 Offset: 0x3E4DB01 VA: 0x3E4DA00
	|-List<UICharInfo>.Sort
	|
	|-RVA: 0x3E508E0 Offset: 0x3E509E1 VA: 0x3E508E0
	|-List<UILineInfo>.Sort
	|
	|-RVA: 0x3E545C0 Offset: 0x3E546C1 VA: 0x3E545C0
	|-List<UIVertex>.Sort
	|
	|-RVA: 0x3E573C0 Offset: 0x3E574C1 VA: 0x3E573C0
	|-List<ushort>.Sort
	|
	|-RVA: 0x3E5A1C0 Offset: 0x3E5A2C1 VA: 0x3E5A1C0
	|-List<uint>.Sort
	|
	|-RVA: 0x3DC4DB0 Offset: 0x3DC4EB1 VA: 0x3DC4DB0
	|-List<ulong>.Sort
	|
	|-RVA: 0x3DC7C80 Offset: 0x3DC7D81 VA: 0x3DC7C80
	|-List<Vector2>.Sort
	|
	|-RVA: 0x3DCAC60 Offset: 0x3DCAD61 VA: 0x3DCAC60
	|-List<Vector3>.Sort
	|
	|-RVA: 0x3DCDC60 Offset: 0x3DCDD61 VA: 0x3DCDC60
	|-List<Vector4>.Sort
	|
	|-RVA: 0x3DD0B40 Offset: 0x3DD0C41 VA: 0x3DD0B40
	|-List<VertexAttributeDescriptor>.Sort
	|
	|-RVA: 0x3DD3A60 Offset: 0x3DD3B61 VA: 0x3DD3A60
	|-List<X509ChainStatus>.Sort
	|
	|-RVA: 0x3DD6E50 Offset: 0x3DD6F51 VA: 0x3DD6E50
	|-List<XRView>.Sort
	|
	|-RVA: 0x3DD9D70 Offset: 0x3DD9E71 VA: 0x3DD9D70
	|-List<AmiiboSequence.GainItemData>.Sort
	|
	|-RVA: 0x3DDD110 Offset: 0x3DDD211 VA: 0x3DDD110
	|-List<AnimationOutputWeightProcessor.WeightInfo>.Sort
	|
	|-RVA: 0x3DE0030 Offset: 0x3DE0131 VA: 0x3DE0030
	|-List<ArenaOrderSequence.GodInfo>.Sort
	|
	|-RVA: 0x3E1F890 Offset: 0x3E1F991 VA: 0x3E1F890
	|-List<BattleInfo.SupportData>.Sort
	|
	|-RVA: 0x3E227B0 Offset: 0x3E228B1 VA: 0x3E227B0
	|-List<BeforeRenderHelper.OrderBlock>.Sort
	|
	|-RVA: 0x3E259E0 Offset: 0x3E25AE1 VA: 0x3E259E0
	|-List<Camera.RenderRequest>.Sort
	|
	|-RVA: 0x3E28900 Offset: 0x3E28A01 VA: 0x3E28900
	|-List<CameraState.CustomBlendable>.Sort
	|
	|-RVA: 0x3E2B710 Offset: 0x3E2B811 VA: 0x3E2B710
	|-List<CinemachineClearShot.Pair>.Sort
	|
	|-RVA: 0x3E2E520 Offset: 0x3E2E621 VA: 0x3E2E520
	|-List<CinemachineStateDrivenCamera.HashPair>.Sort
	|
	|-RVA: 0x3E31740 Offset: 0x3E31841 VA: 0x3E31740
	|-List<DelayedActionManager.DelegateInfo>.Sort
	|
	|-RVA: 0x3E34B30 Offset: 0x3E34C31 VA: 0x3E34B30
	|-List<Detail.AsyncResultInt>.Sort
	|
	|-RVA: 0x3E37A10 Offset: 0x3E37B11 VA: 0x3E37A10
	|-List<Detail.CppArray>.Sort
	|
	|-RVA: 0x3E3AE00 Offset: 0x3E3AF01 VA: 0x3E3AE00
	|-List<Detail.NotificationEventInt>.Sort
	|
	|-RVA: 0x3E5D0E0 Offset: 0x3E5D1E1 VA: 0x3E5D0E0
	|-List<DragonRideTargetGroup.ChainParam>.Sort
	|
	|-RVA: 0x3E602F0 Offset: 0x3E603F1 VA: 0x3E602F0
	|-List<GmapPathAdjuster.TargetModel>.Sort
	|
	|-RVA: 0x3E63500 Offset: 0x3E63601 VA: 0x3E63500
	|-List<GmapSpotAdjuster.TargetModel>.Sort
	|
	|-RVA: 0x3E66710 Offset: 0x3E66811 VA: 0x3E66710
	|-List<HubFastTravel.Location>.Sort
	|
	|-RVA: 0x3E69B50 Offset: 0x3E69C51 VA: 0x3E69B50
	|-List<HubLensFlare.Flare>.Sort
	|
	|-RVA: 0x3E6CA70 Offset: 0x3E6CB71 VA: 0x3E6CA70
	|-List<InventoryPoolItemMenuContent.KindBgNameClass>.Sort
	|
	|-RVA: 0x3E6F880 Offset: 0x3E6F981 VA: 0x3E6F880
	|-List<Map.Pos>.Sort
	|
	|-RVA: 0x3E72760 Offset: 0x3E72861 VA: 0x3E72760
	|-List<MapImage.BackupTerrain>.Sort
	|
	|-RVA: 0x3E75600 Offset: 0x3E75701 VA: 0x3E75600
	|-List<MapImageRange.Pos>.Sort
	|
	|-RVA: 0x3E78810 Offset: 0x3E78911 VA: 0x3E78810
	|-List<MapMind.Target>.Sort
	|
	|-RVA: 0x3D883E0 Offset: 0x3D884E1 VA: 0x3D883E0
	|-List<MapPanelDebug.Entity>.Sort
	|
	|-RVA: 0x3D8B1F0 Offset: 0x3D8B2F1 VA: 0x3D8B1F0
	|-List<NexRanking.Data>.Sort
	|
	|-RVA: 0x3D8E0D0 Offset: 0x3D8E1D1 VA: 0x3D8E0D0
	|-List<NexVersus.RatingData>.Sort
	|
	|-RVA: 0x3D90FF0 Offset: 0x3D910F1 VA: 0x3D90FF0
	|-List<PackedPlayModeBuildLogs.RuntimeBuildLog>.Sort
	|
	|-RVA: 0x3D943A0 Offset: 0x3D944A1 VA: 0x3D943A0
	|-List<ParticleSystem.Particle>.Sort
	|
	|-RVA: 0x3D971B0 Offset: 0x3D972B1 VA: 0x3D971B0
	|-List<RangeData.Offset>.Sort
	|
	|-RVA: 0x3D9A3D0 Offset: 0x3D9A4D1 VA: 0x3D9A3D0
	|-List<RenderGraphDebugData.PassDebugData>.Sort
	|
	|-RVA: 0x3D9D7A0 Offset: 0x3D9D8A1 VA: 0x3D9D7A0
	|-List<RenderGraphDebugData.ResourceDebugData>.Sort
	|
	|-RVA: 0x3DA06C0 Offset: 0x3DA07C1 VA: 0x3DA06C0
	|-List<RingCleaningUnitSelectMenu.GodParam>.Sort
	|
	|-RVA: 0x3DA3A40 Offset: 0x3DA3B41 VA: 0x3DA3A40
	|-List<ShadowUtility.Edge>.Sort
	|
	|-RVA: 0x3D15D20 Offset: 0x3D15E21 VA: 0x3D15D20
	|-List<SkillArray.Entity>.Sort
	|
	|-RVA: 0x3D192E0 Offset: 0x3D193E1 VA: 0x3D192E0
	|-List<TexturePacker_JsonArray.Frame>.Sort
	|
	|-RVA: 0x3D1C510 Offset: 0x3D1C611 VA: 0x3D1C510
	|-List<TimeNotificationBehaviour.NotificationEntry>.Sort
	|
	|-RVA: 0x3D1F720 Offset: 0x3D1F821 VA: 0x3D1F720
	|-List<UnitySynchronizationContext.WorkRequest>.Sort
	|
	|-RVA: 0x3D22640 Offset: 0x3D22741 VA: 0x3D22640
	|-List<XmlSchemaObjectTable.XmlSchemaObjectEntry>.Sort
	|
	|-RVA: 0x3D25560 Offset: 0x3D25661 VA: 0x3D25560
	|-List<AssetBundleBuildMap.AssetBundleEntry.AssetPathString>.Sort
	|
	|-RVA: 0x3D28980 Offset: 0x3D28A81 VA: 0x3D28980
	|-List<Detail.DataStore.DataStoreChangeMetaParamInt>.Sort
	|
	|-RVA: 0x3D2B860 Offset: 0x3D2B961 VA: 0x3D2B860
	|-List<Detail.DataStore.DataStoreDeleteParamInt>.Sort
	|
	|-RVA: 0x3D2EC00 Offset: 0x3D2ED01 VA: 0x3D2EC00
	|-List<Detail.DataStore.DataStoreGetMetaParamInt>.Sort
	|
	|-RVA: 0x3D31FF0 Offset: 0x3D320F1 VA: 0x3D31FF0
	|-List<Detail.DataStore.DataStoreMetaInfoInt>.Sort
	|
	|-RVA: 0x3CF6620 Offset: 0x3CF6721 VA: 0x3CF6620
	|-List<Detail.DataStore.DataStorePasswordInfoInt>.Sort
	|
	|-RVA: 0x3CF9800 Offset: 0x3CF9901 VA: 0x3CF9800
	|-List<Detail.DataStore.DataStorePersistenceInfoInt>.Sort
	|
	|-RVA: 0x3CFCBB0 Offset: 0x3CFCCB1 VA: 0x3CFCBB0
	|-List<Detail.DataStore.DataStorePreparePostParamInt>.Sort
	|
	|-RVA: 0x3CFFA90 Offset: 0x3CFFB91 VA: 0x3CFFA90
	|-List<Detail.DataStore.DataStoreRateObjectParamInt>.Sort
	|
	|-RVA: 0x3D02C80 Offset: 0x3D02D81 VA: 0x3D02C80
	|-List<Detail.DataStore.DataStoreRatingInitParamInt>.Sort
	|
	|-RVA: 0x3D05B60 Offset: 0x3D05C61 VA: 0x3D05B60
	|-List<Detail.DataStore.DataStoreRatingTargetInt>.Sort
	|
	|-RVA: 0x3D09140 Offset: 0x3D09241 VA: 0x3D09140
	|-List<Detail.Ranking.RankingCachedResultInt>.Sort
	|
	|-RVA: 0x3D0C020 Offset: 0x3D0C121 VA: 0x3D0C020
	|-List<Detail.Ranking.RankingOrderParamInt>.Sort
	|
	|-RVA: 0x3D0F5A0 Offset: 0x3D0F6A1 VA: 0x3D0F5A0
	|-List<Detail.Ranking.RankingRankDataInt>.Sort
	|
	|-RVA: 0x3D12F10 Offset: 0x3D13011 VA: 0x3D12F10
	|-List<Detail.Ranking2.Ranking2ChartInfoInt>.Sort
	|
	|-RVA: 0x3D69520 Offset: 0x3D69621 VA: 0x3D69520
	|-List<Detail.Ranking2.Ranking2RankDataInt>.Sort
	|
	|-RVA: 0x3D6C400 Offset: 0x3D6C501 VA: 0x3D6C400
	|-List<Detail.Ranking2.Ranking2ScoreDataInt>.Sort
	|
	|-RVA: 0x3D6F5F0 Offset: 0x3D6F6F1 VA: 0x3D6F5F0
	|-List<Detail.Screening.ScreeningContextInfoInt>.Sort
	|
	|-RVA: 0x3D72DC0 Offset: 0x3D72EC1 VA: 0x3D72DC0
	|-List<Detail.Subscriber.SubscriberContentInt>.Sort
	|
	|-RVA: 0x3D75FA0 Offset: 0x3D760A1 VA: 0x3D75FA0
	|-List<Detail.Subscriber.SubscriberGetContentParamInt>.Sort
	|
	|-RVA: 0x3D79340 Offset: 0x3D79441 VA: 0x3D79340
	|-List<Detail.Subscriber.SubscriberUserStatusInfoInt>.Sort
	|
	|-RVA: 0x3D7C520 Offset: 0x3D7C621 VA: 0x3D7C520
	|-List<Detail.Subscriber.SubscriberUserStatusParamInt>.Sort
	|
	|-RVA: 0x3D7F330 Offset: 0x3D7F431 VA: 0x3D7F330
	|-List<Detail.Utility.IntegerSettings>.Sort
	|
	|-RVA: 0x3D82210 Offset: 0x3D82311 VA: 0x3D82210
	|-List<Detail.Utility.UniqueIdInfoInt>.Sort
	|
	|-RVA: 0x3D85200 Offset: 0x3D85301 VA: 0x3D85200
	|-List<MapHistory.Rewind.LatestInspectorData>.Sort
	|
	|-RVA: 0x30614C0 Offset: 0x30615C1 VA: 0x30614C0
	|-List<MapHistory.Rewind.WorkTerrainData>.Sort
	|
	|-RVA: 0x30643E0 Offset: 0x30644E1 VA: 0x30643E0
	|-List<MapSkill.AroundCalculator.Result>.Sort
	|
	|-RVA: 0x3067760 Offset: 0x3067861 VA: 0x3067760
	|-List<TargetPositionCache.CacheCurve.Item>.Sort
	|
	|-RVA: 0x306AB80 Offset: 0x306AC81 VA: 0x306AB80
	|-List<TargetPositionCache.CacheEntry.RecordingItem>.Sort
	*/

	// RVA: -1 Offset: -1
	public T[] ToArray() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3B0D370 Offset: 0x3B0D471 VA: 0x3B0D370
	|-List<IntervalTree.Entry<object>>.ToArray
	|
	|-RVA: 0x3B10290 Offset: 0x3B10391 VA: 0x3B10290
	|-List<KeyValuePair<DateTime, object>>.ToArray
	|
	|-RVA: 0x3B131B0 Offset: 0x3B132B1 VA: 0x3B131B0
	|-List<KeyValuePair<int, object>>.ToArray
	|
	|-RVA: 0x3B163D0 Offset: 0x3B164D1 VA: 0x3B163D0
	|-List<KeyValuePair<object, ValueTuple<int, DateTime, object>>>.ToArray
	|
	|-RVA: 0x3B192F0 Offset: 0x3B193F1 VA: 0x3B192F0
	|-List<KeyValuePair<object, object>>.ToArray
	|
	|-RVA: 0x3B1C500 Offset: 0x3B1C601 VA: 0x3B1C500
	|-List<CommonBattleSequence.Reliance<object>>.ToArray
	|
	|-RVA: 0x3B1F420 Offset: 0x3B1F521 VA: 0x3B1F420
	|-List<RenderGraphResourcePool.ResourceLogInfo<object>>.ToArray
	|
	|-RVA: 0x3B22340 Offset: 0x3B22441 VA: 0x3B22340
	|-List<ValueTuple<int, object>>.ToArray
	|
	|-RVA: 0x3DE2EC0 Offset: 0x3DE2FC1 VA: 0x3DE2EC0
	|-List<ValueTuple<Int32Enum, int>>.ToArray
	|
	|-RVA: 0x3DE60D0 Offset: 0x3DE61D1 VA: 0x3DE60D0
	|-List<ValueTuple<object, ValueTuple<object, int>>>.ToArray
	|
	|-RVA: 0x3DE8FF0 Offset: 0x3DE90F1 VA: 0x3DE8FF0
	|-List<ValueTuple<object, int>>.ToArray
	|
	|-RVA: 0x3DEBFF0 Offset: 0x3DEC0F1 VA: 0x3DEBFF0
	|-List<ValueTuple<Vector3, float>>.ToArray
	|
	|-RVA: 0x3DEEF10 Offset: 0x3DEF011 VA: 0x3DEEF10
	|-List<ValueTuple<ItemData.Kinds[], WeaponLevel.Kind, int>>.ToArray
	|-List<ValueTuple<object, Int32Enum, int>>.ToArray
	|
	|-RVA: 0x3DF2120 Offset: 0x3DF2221 VA: 0x3DF2120
	|-List<ValueTuple<object, int, int, int>>.ToArray
	|
	|-RVA: 0x3E12FC0 Offset: 0x3E130C1 VA: 0x3E12FC0
	|-List<AnimationClip>.ToArray
	|-List<ByRefUpdater>.ToArray
	|-List<ChapterData>.ToArray
	|-List<CinemachineComponentBase>.ToArray
	|-List<CinemachineVirtualCameraBase>.ToArray
	|-List<Collider>.ToArray
	|-List<Contraction>.ToArray
	|-List<DebugInfo>.ToArray
	|-List<DynValue>.ToArray
	|-List<ExceptionHandler>.ToArray
	|-List<Expression>.ToArray
	|-List<FoodstuffData>.ToArray
	|-List<GameObject>.ToArray
	|-List<GmapSpot>.ToArray
	|-List<IContextProperty>.ToArray
	|-List<IDisposable>.ToArray
	|-List<Instruction>.ToArray
	|-List<InteractionTarget>.ToArray
	|-List<ItemData>.ToArray
	|-List<Level2Map>.ToArray
	|-List<Module>.ToArray
	|-List<object>.ToArray
	|-List<Renderer>.ToArray
	|-List<RuntimeType>.ToArray
	|-List<SpringBone>.ToArray
	|-List<StackFrame>.ToArray
	|-List<string>.ToArray
	|-List<SymbolRef>.ToArray
	|-List<TimelineClip>.ToArray
	|-List<TrackAsset>.ToArray
	|-List<Type>.ToArray
	|-List<Volume>.ToArray
	|-List<DebugUI.Widget>.ToArray
	|-List<SimpleAnimation.EditorState>.ToArray
	|-List<TimeZoneInfo.AdjustmentRule>.ToArray
	|
	|-RVA: 0x3DF4F30 Offset: 0x3DF5031 VA: 0x3DF4F30
	|-List<AnimatorClipInfo>.ToArray
	|
	|-RVA: 0x3DF8140 Offset: 0x3DF8241 VA: 0x3DF8140
	|-List<AsyncOperationHandle>.ToArray
	|
	|-RVA: 0x3DFB330 Offset: 0x3DFB431 VA: 0x3DFB330
	|-List<BoneWeight>.ToArray
	|
	|-RVA: 0x3DFE160 Offset: 0x3DFE261 VA: 0x3DFE160
	|-List<bool>.ToArray
	|
	|-RVA: 0x3E7B6A0 Offset: 0x3E7B7A1 VA: 0x3E7B6A0
	|-List<byte>.ToArray
	|
	|-RVA: 0x3E7E5C0 Offset: 0x3E7E6C1 VA: 0x3E7E5C0
	|-List<CameraInfo>.ToArray
	|
	|-RVA: 0x3E813C0 Offset: 0x3E814C1 VA: 0x3E813C0
	|-List<char>.ToArray
	|
	|-RVA: 0x3E843C0 Offset: 0x3E844C1 VA: 0x3E843C0
	|-List<Color>.ToArray
	|
	|-RVA: 0x3E871D0 Offset: 0x3E872D1 VA: 0x3E871D0
	|-List<Color32>.ToArray
	|
	|-RVA: 0x3E8A0F0 Offset: 0x3E8A1F1 VA: 0x3E8A0F0
	|-List<ConstraintSource>.ToArray
	|
	|-RVA: 0x3E8D300 Offset: 0x3E8D401 VA: 0x3E8D300
	|-List<ContourVertex>.ToArray
	|
	|-RVA: 0x3E904E0 Offset: 0x3E905E1 VA: 0x3E904E0
	|-List<DataStoreRatingInfo>.ToArray
	|
	|-RVA: 0x3E932F0 Offset: 0x3E933F1 VA: 0x3E932F0
	|-List<DataStoreResult>.ToArray
	|
	|-RVA: 0x3E96100 Offset: 0x3E96201 VA: 0x3E96100
	|-List<DateTime>.ToArray
	|
	|-RVA: 0x3E98FE0 Offset: 0x3E990E1 VA: 0x3E98FE0
	|-List<DateTimeOffset>.ToArray
	|
	|-RVA: 0x3E9BEC0 Offset: 0x3E9BFC1 VA: 0x3E9BEC0
	|-List<Decimal>.ToArray
	|
	|-RVA: 0x3E9F300 Offset: 0x3E9F401 VA: 0x3E9F300
	|-List<DiagnosticEvent>.ToArray
	|
	|-RVA: 0x3EA2120 Offset: 0x3EA2221 VA: 0x3EA2120
	|-List<double>.ToArray
	|
	|-RVA: 0x3EA54B0 Offset: 0x3EA55B1 VA: 0x3EA54B0
	|-List<Friend>.ToArray
	|
	|-RVA: 0x3EA8390 Offset: 0x3EA8491 VA: 0x3EA8390
	|-List<GlyphRect>.ToArray
	|
	|-RVA: 0x3EAB190 Offset: 0x3EAB291 VA: 0x3EAB190
	|-List<short>.ToArray
	|
	|-RVA: 0x3EADF90 Offset: 0x3EAE091 VA: 0x3EADF90
	|-List<int>.ToArray
	|
	|-RVA: 0x3EB0D90 Offset: 0x3EB0E91 VA: 0x3EB0D90
	|-List<Int32Enum>.ToArray
	|-List<ItemData.Kinds>.ToArray
	|
	|-RVA: 0x3EB3B90 Offset: 0x3EB3C91 VA: 0x3EB3B90
	|-List<long>.ToArray
	|
	|-RVA: 0x3E00F60 Offset: 0x3E01061 VA: 0x3E00F60
	|-List<IntPtr>.ToArray
	|
	|-RVA: 0x3E03E80 Offset: 0x3E03F81 VA: 0x3E03E80
	|-List<InterpretedFrameInfo>.ToArray
	|
	|-RVA: 0x3E07060 Offset: 0x3E07161 VA: 0x3E07060
	|-List<IntervalTreeNode>.ToArray
	|
	|-RVA: 0x3E09E70 Offset: 0x3E09F71 VA: 0x3E09E70
	|-List<LengthLimitProperties>.ToArray
	|
	|-RVA: 0x3E0CC80 Offset: 0x3E0CD81 VA: 0x3E0CC80
	|-List<MapPos>.ToArray
	|
	|-RVA: 0x3E10200 Offset: 0x3E10301 VA: 0x3E10200
	|-List<Matrix4x4>.ToArray
	|
	|-RVA: 0x3E16400 Offset: 0x3E16501 VA: 0x3E16400
	|-List<ObjectInitializationData>.ToArray
	|
	|-RVA: 0x3E19620 Offset: 0x3E19721 VA: 0x3E19620
	|-List<PlayableBinding>.ToArray
	|
	|-RVA: 0x3E1C9F0 Offset: 0x3E1CAF1 VA: 0x3E1C9F0
	|-List<PlayerLoopSystem>.ToArray
	|
	|-RVA: 0x3DA6E90 Offset: 0x3DA6F91 VA: 0x3DA6E90
	|-List<PlayerLoopSystemInternal>.ToArray
	|
	|-RVA: 0x3DA9DB0 Offset: 0x3DA9EB1 VA: 0x3DA9DB0
	|-List<RangePositionInfo>.ToArray
	|
	|-RVA: 0x3DACBC0 Offset: 0x3DACCC1 VA: 0x3DACBC0
	|-List<Ranking2ChartInfoInput>.ToArray
	|
	|-RVA: 0x3DAFFE0 Offset: 0x3DB00E1 VA: 0x3DAFFE0
	|-List<RaycastHit2D>.ToArray
	|
	|-RVA: 0x3DB37F0 Offset: 0x3DB38F1 VA: 0x3DB37F0
	|-List<RaycastResult>.ToArray
	|
	|-RVA: 0x3DB67F0 Offset: 0x3DB68F1 VA: 0x3DB67F0
	|-List<Rect>.ToArray
	|
	|-RVA: 0x3DB9600 Offset: 0x3DB9701 VA: 0x3DB9600
	|-List<RendererListHandle>.ToArray
	|
	|-RVA: 0x3DBC410 Offset: 0x3DBC511 VA: 0x3DBC410
	|-List<ResourceHandle>.ToArray
	|
	|-RVA: 0x3DBF220 Offset: 0x3DBF321 VA: 0x3DBF220
	|-List<sbyte>.ToArray
	|
	|-RVA: 0x3DC2030 Offset: 0x3DC2131 VA: 0x3DC2030
	|-List<ShaderTagId>.ToArray
	|
	|-RVA: 0x3E3DCA0 Offset: 0x3E3DDA1 VA: 0x3E3DCA0
	|-List<float>.ToArray
	|
	|-RVA: 0x3E41980 Offset: 0x3E41A81 VA: 0x3E41980
	|-List<SphericalHarmonicsL2>.ToArray
	|
	|-RVA: 0x3E44D70 Offset: 0x3E44E71 VA: 0x3E44D70
	|-List<SubMeshDescriptor>.ToArray
	|
	|-RVA: 0x3E47C90 Offset: 0x3E47D91 VA: 0x3E47C90
	|-List<TablePair>.ToArray
	|
	|-RVA: 0x3E4AAA0 Offset: 0x3E4ABA1 VA: 0x3E4AAA0
	|-List<TimeSpan>.ToArray
	|
	|-RVA: 0x3E4DA80 Offset: 0x3E4DB81 VA: 0x3E4DA80
	|-List<UICharInfo>.ToArray
	|
	|-RVA: 0x3E50960 Offset: 0x3E50A61 VA: 0x3E50960
	|-List<UILineInfo>.ToArray
	|
	|-RVA: 0x3E54640 Offset: 0x3E54741 VA: 0x3E54640
	|-List<UIVertex>.ToArray
	|
	|-RVA: 0x3E57440 Offset: 0x3E57541 VA: 0x3E57440
	|-List<ushort>.ToArray
	|
	|-RVA: 0x3E5A240 Offset: 0x3E5A341 VA: 0x3E5A240
	|-List<uint>.ToArray
	|
	|-RVA: 0x3DC4E30 Offset: 0x3DC4F31 VA: 0x3DC4E30
	|-List<ulong>.ToArray
	|
	|-RVA: 0x3DC7D00 Offset: 0x3DC7E01 VA: 0x3DC7D00
	|-List<Vector2>.ToArray
	|
	|-RVA: 0x3DCACE0 Offset: 0x3DCADE1 VA: 0x3DCACE0
	|-List<Vector3>.ToArray
	|
	|-RVA: 0x3DCDCE0 Offset: 0x3DCDDE1 VA: 0x3DCDCE0
	|-List<Vector4>.ToArray
	|
	|-RVA: 0x3DD0BC0 Offset: 0x3DD0CC1 VA: 0x3DD0BC0
	|-List<VertexAttributeDescriptor>.ToArray
	|
	|-RVA: 0x3DD3AE0 Offset: 0x3DD3BE1 VA: 0x3DD3AE0
	|-List<X509ChainStatus>.ToArray
	|
	|-RVA: 0x3DD6ED0 Offset: 0x3DD6FD1 VA: 0x3DD6ED0
	|-List<XRView>.ToArray
	|
	|-RVA: 0x3DD9DF0 Offset: 0x3DD9EF1 VA: 0x3DD9DF0
	|-List<AmiiboSequence.GainItemData>.ToArray
	|
	|-RVA: 0x3DDD190 Offset: 0x3DDD291 VA: 0x3DDD190
	|-List<AnimationOutputWeightProcessor.WeightInfo>.ToArray
	|
	|-RVA: 0x3DE00B0 Offset: 0x3DE01B1 VA: 0x3DE00B0
	|-List<ArenaOrderSequence.GodInfo>.ToArray
	|
	|-RVA: 0x3E1F910 Offset: 0x3E1FA11 VA: 0x3E1F910
	|-List<BattleInfo.SupportData>.ToArray
	|
	|-RVA: 0x3E22830 Offset: 0x3E22931 VA: 0x3E22830
	|-List<BeforeRenderHelper.OrderBlock>.ToArray
	|
	|-RVA: 0x3E25A60 Offset: 0x3E25B61 VA: 0x3E25A60
	|-List<Camera.RenderRequest>.ToArray
	|
	|-RVA: 0x3E28980 Offset: 0x3E28A81 VA: 0x3E28980
	|-List<CameraState.CustomBlendable>.ToArray
	|
	|-RVA: 0x3E2B790 Offset: 0x3E2B891 VA: 0x3E2B790
	|-List<CinemachineClearShot.Pair>.ToArray
	|
	|-RVA: 0x3E2E5A0 Offset: 0x3E2E6A1 VA: 0x3E2E5A0
	|-List<CinemachineStateDrivenCamera.HashPair>.ToArray
	|
	|-RVA: 0x3E317C0 Offset: 0x3E318C1 VA: 0x3E317C0
	|-List<DelayedActionManager.DelegateInfo>.ToArray
	|
	|-RVA: 0x3E34BB0 Offset: 0x3E34CB1 VA: 0x3E34BB0
	|-List<Detail.AsyncResultInt>.ToArray
	|
	|-RVA: 0x3E37A90 Offset: 0x3E37B91 VA: 0x3E37A90
	|-List<Detail.CppArray>.ToArray
	|
	|-RVA: 0x3E3AE80 Offset: 0x3E3AF81 VA: 0x3E3AE80
	|-List<Detail.NotificationEventInt>.ToArray
	|
	|-RVA: 0x3E5D160 Offset: 0x3E5D261 VA: 0x3E5D160
	|-List<DragonRideTargetGroup.ChainParam>.ToArray
	|
	|-RVA: 0x3E60370 Offset: 0x3E60471 VA: 0x3E60370
	|-List<GmapPathAdjuster.TargetModel>.ToArray
	|
	|-RVA: 0x3E63580 Offset: 0x3E63681 VA: 0x3E63580
	|-List<GmapSpotAdjuster.TargetModel>.ToArray
	|
	|-RVA: 0x3E66790 Offset: 0x3E66891 VA: 0x3E66790
	|-List<HubFastTravel.Location>.ToArray
	|
	|-RVA: 0x3E69BD0 Offset: 0x3E69CD1 VA: 0x3E69BD0
	|-List<HubLensFlare.Flare>.ToArray
	|
	|-RVA: 0x3E6CAF0 Offset: 0x3E6CBF1 VA: 0x3E6CAF0
	|-List<InventoryPoolItemMenuContent.KindBgNameClass>.ToArray
	|
	|-RVA: 0x3E6F900 Offset: 0x3E6FA01 VA: 0x3E6F900
	|-List<Map.Pos>.ToArray
	|
	|-RVA: 0x3E727E0 Offset: 0x3E728E1 VA: 0x3E727E0
	|-List<MapImage.BackupTerrain>.ToArray
	|
	|-RVA: 0x3E75680 Offset: 0x3E75781 VA: 0x3E75680
	|-List<MapImageRange.Pos>.ToArray
	|
	|-RVA: 0x3E78890 Offset: 0x3E78991 VA: 0x3E78890
	|-List<MapMind.Target>.ToArray
	|
	|-RVA: 0x3D88460 Offset: 0x3D88561 VA: 0x3D88460
	|-List<MapPanelDebug.Entity>.ToArray
	|
	|-RVA: 0x3D8B270 Offset: 0x3D8B371 VA: 0x3D8B270
	|-List<NexRanking.Data>.ToArray
	|
	|-RVA: 0x3D8E150 Offset: 0x3D8E251 VA: 0x3D8E150
	|-List<NexVersus.RatingData>.ToArray
	|
	|-RVA: 0x3D91070 Offset: 0x3D91171 VA: 0x3D91070
	|-List<PackedPlayModeBuildLogs.RuntimeBuildLog>.ToArray
	|
	|-RVA: 0x3D94420 Offset: 0x3D94521 VA: 0x3D94420
	|-List<ParticleSystem.Particle>.ToArray
	|
	|-RVA: 0x3D97230 Offset: 0x3D97331 VA: 0x3D97230
	|-List<RangeData.Offset>.ToArray
	|
	|-RVA: 0x3D9A450 Offset: 0x3D9A551 VA: 0x3D9A450
	|-List<RenderGraphDebugData.PassDebugData>.ToArray
	|
	|-RVA: 0x3D9D820 Offset: 0x3D9D921 VA: 0x3D9D820
	|-List<RenderGraphDebugData.ResourceDebugData>.ToArray
	|
	|-RVA: 0x3DA0740 Offset: 0x3DA0841 VA: 0x3DA0740
	|-List<RingCleaningUnitSelectMenu.GodParam>.ToArray
	|
	|-RVA: 0x3DA3AC0 Offset: 0x3DA3BC1 VA: 0x3DA3AC0
	|-List<ShadowUtility.Edge>.ToArray
	|
	|-RVA: 0x3D15DA0 Offset: 0x3D15EA1 VA: 0x3D15DA0
	|-List<SkillArray.Entity>.ToArray
	|
	|-RVA: 0x3D19360 Offset: 0x3D19461 VA: 0x3D19360
	|-List<TexturePacker_JsonArray.Frame>.ToArray
	|
	|-RVA: 0x3D1C590 Offset: 0x3D1C691 VA: 0x3D1C590
	|-List<TimeNotificationBehaviour.NotificationEntry>.ToArray
	|
	|-RVA: 0x3D1F7A0 Offset: 0x3D1F8A1 VA: 0x3D1F7A0
	|-List<UnitySynchronizationContext.WorkRequest>.ToArray
	|
	|-RVA: 0x3D226C0 Offset: 0x3D227C1 VA: 0x3D226C0
	|-List<XmlSchemaObjectTable.XmlSchemaObjectEntry>.ToArray
	|
	|-RVA: 0x3D255E0 Offset: 0x3D256E1 VA: 0x3D255E0
	|-List<AssetBundleBuildMap.AssetBundleEntry.AssetPathString>.ToArray
	|
	|-RVA: 0x3D28A00 Offset: 0x3D28B01 VA: 0x3D28A00
	|-List<Detail.DataStore.DataStoreChangeMetaParamInt>.ToArray
	|
	|-RVA: 0x3D2B8E0 Offset: 0x3D2B9E1 VA: 0x3D2B8E0
	|-List<Detail.DataStore.DataStoreDeleteParamInt>.ToArray
	|
	|-RVA: 0x3D2EC80 Offset: 0x3D2ED81 VA: 0x3D2EC80
	|-List<Detail.DataStore.DataStoreGetMetaParamInt>.ToArray
	|
	|-RVA: 0x3D32070 Offset: 0x3D32171 VA: 0x3D32070
	|-List<Detail.DataStore.DataStoreMetaInfoInt>.ToArray
	|
	|-RVA: 0x3CF66A0 Offset: 0x3CF67A1 VA: 0x3CF66A0
	|-List<Detail.DataStore.DataStorePasswordInfoInt>.ToArray
	|
	|-RVA: 0x3CF9880 Offset: 0x3CF9981 VA: 0x3CF9880
	|-List<Detail.DataStore.DataStorePersistenceInfoInt>.ToArray
	|
	|-RVA: 0x3CFCC30 Offset: 0x3CFCD31 VA: 0x3CFCC30
	|-List<Detail.DataStore.DataStorePreparePostParamInt>.ToArray
	|
	|-RVA: 0x3CFFB10 Offset: 0x3CFFC11 VA: 0x3CFFB10
	|-List<Detail.DataStore.DataStoreRateObjectParamInt>.ToArray
	|
	|-RVA: 0x3D02D00 Offset: 0x3D02E01 VA: 0x3D02D00
	|-List<Detail.DataStore.DataStoreRatingInitParamInt>.ToArray
	|
	|-RVA: 0x3D05BE0 Offset: 0x3D05CE1 VA: 0x3D05BE0
	|-List<Detail.DataStore.DataStoreRatingTargetInt>.ToArray
	|
	|-RVA: 0x3D091C0 Offset: 0x3D092C1 VA: 0x3D091C0
	|-List<Detail.Ranking.RankingCachedResultInt>.ToArray
	|
	|-RVA: 0x3D0C0A0 Offset: 0x3D0C1A1 VA: 0x3D0C0A0
	|-List<Detail.Ranking.RankingOrderParamInt>.ToArray
	|
	|-RVA: 0x3D0F620 Offset: 0x3D0F721 VA: 0x3D0F620
	|-List<Detail.Ranking.RankingRankDataInt>.ToArray
	|
	|-RVA: 0x3D12F90 Offset: 0x3D13091 VA: 0x3D12F90
	|-List<Detail.Ranking2.Ranking2ChartInfoInt>.ToArray
	|
	|-RVA: 0x3D695A0 Offset: 0x3D696A1 VA: 0x3D695A0
	|-List<Detail.Ranking2.Ranking2RankDataInt>.ToArray
	|
	|-RVA: 0x3D6C480 Offset: 0x3D6C581 VA: 0x3D6C480
	|-List<Detail.Ranking2.Ranking2ScoreDataInt>.ToArray
	|
	|-RVA: 0x3D6F670 Offset: 0x3D6F771 VA: 0x3D6F670
	|-List<Detail.Screening.ScreeningContextInfoInt>.ToArray
	|
	|-RVA: 0x3D72E40 Offset: 0x3D72F41 VA: 0x3D72E40
	|-List<Detail.Subscriber.SubscriberContentInt>.ToArray
	|
	|-RVA: 0x3D76020 Offset: 0x3D76121 VA: 0x3D76020
	|-List<Detail.Subscriber.SubscriberGetContentParamInt>.ToArray
	|
	|-RVA: 0x3D793C0 Offset: 0x3D794C1 VA: 0x3D793C0
	|-List<Detail.Subscriber.SubscriberUserStatusInfoInt>.ToArray
	|
	|-RVA: 0x3D7C5A0 Offset: 0x3D7C6A1 VA: 0x3D7C5A0
	|-List<Detail.Subscriber.SubscriberUserStatusParamInt>.ToArray
	|
	|-RVA: 0x3D7F3B0 Offset: 0x3D7F4B1 VA: 0x3D7F3B0
	|-List<Detail.Utility.IntegerSettings>.ToArray
	|
	|-RVA: 0x3D82290 Offset: 0x3D82391 VA: 0x3D82290
	|-List<Detail.Utility.UniqueIdInfoInt>.ToArray
	|
	|-RVA: 0x3D85280 Offset: 0x3D85381 VA: 0x3D85280
	|-List<MapHistory.Rewind.LatestInspectorData>.ToArray
	|
	|-RVA: 0x3061540 Offset: 0x3061641 VA: 0x3061540
	|-List<MapHistory.Rewind.WorkTerrainData>.ToArray
	|
	|-RVA: 0x3064460 Offset: 0x3064561 VA: 0x3064460
	|-List<MapSkill.AroundCalculator.Result>.ToArray
	|
	|-RVA: 0x30677E0 Offset: 0x30678E1 VA: 0x30677E0
	|-List<TargetPositionCache.CacheCurve.Item>.ToArray
	|
	|-RVA: 0x306AC00 Offset: 0x306AD01 VA: 0x306AC00
	|-List<TargetPositionCache.CacheEntry.RecordingItem>.ToArray
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3B0D3F0 Offset: 0x3B0D4F1 VA: 0x3B0D3F0
	|-List<IntervalTree.Entry<object>>..cctor
	|
	|-RVA: 0x3B10310 Offset: 0x3B10411 VA: 0x3B10310
	|-List<KeyValuePair<DateTime, object>>..cctor
	|
	|-RVA: 0x3B13230 Offset: 0x3B13331 VA: 0x3B13230
	|-List<KeyValuePair<int, object>>..cctor
	|
	|-RVA: 0x3B16450 Offset: 0x3B16551 VA: 0x3B16450
	|-List<KeyValuePair<object, ValueTuple<int, DateTime, object>>>..cctor
	|
	|-RVA: 0x3B19370 Offset: 0x3B19471 VA: 0x3B19370
	|-List<KeyValuePair<object, object>>..cctor
	|
	|-RVA: 0x3B1C580 Offset: 0x3B1C681 VA: 0x3B1C580
	|-List<CommonBattleSequence.Reliance<object>>..cctor
	|
	|-RVA: 0x3B1F4A0 Offset: 0x3B1F5A1 VA: 0x3B1F4A0
	|-List<RenderGraphResourcePool.ResourceLogInfo<object>>..cctor
	|
	|-RVA: 0x3B223C0 Offset: 0x3B224C1 VA: 0x3B223C0
	|-List<ValueTuple<int, object>>..cctor
	|
	|-RVA: 0x3DE2F40 Offset: 0x3DE3041 VA: 0x3DE2F40
	|-List<ValueTuple<Int32Enum, int>>..cctor
	|
	|-RVA: 0x3DE6150 Offset: 0x3DE6251 VA: 0x3DE6150
	|-List<ValueTuple<object, ValueTuple<object, int>>>..cctor
	|
	|-RVA: 0x3DE9070 Offset: 0x3DE9171 VA: 0x3DE9070
	|-List<ValueTuple<object, int>>..cctor
	|
	|-RVA: 0x3DEC070 Offset: 0x3DEC171 VA: 0x3DEC070
	|-List<ValueTuple<Vector3, float>>..cctor
	|
	|-RVA: 0x3DEEF90 Offset: 0x3DEF091 VA: 0x3DEEF90
	|-List<ValueTuple<object, Int32Enum, int>>..cctor
	|
	|-RVA: 0x3DF21A0 Offset: 0x3DF22A1 VA: 0x3DF21A0
	|-List<ValueTuple<object, int, int, int>>..cctor
	|
	|-RVA: 0x3DF4FB0 Offset: 0x3DF50B1 VA: 0x3DF4FB0
	|-List<AnimatorClipInfo>..cctor
	|
	|-RVA: 0x3DF81C0 Offset: 0x3DF82C1 VA: 0x3DF81C0
	|-List<AsyncOperationHandle>..cctor
	|
	|-RVA: 0x3DFB3B0 Offset: 0x3DFB4B1 VA: 0x3DFB3B0
	|-List<BoneWeight>..cctor
	|
	|-RVA: 0x3DFE1E0 Offset: 0x3DFE2E1 VA: 0x3DFE1E0
	|-List<bool>..cctor
	|
	|-RVA: 0x3E7B720 Offset: 0x3E7B821 VA: 0x3E7B720
	|-List<byte>..cctor
	|
	|-RVA: 0x3E7E640 Offset: 0x3E7E741 VA: 0x3E7E640
	|-List<CameraInfo>..cctor
	|
	|-RVA: 0x3E81440 Offset: 0x3E81541 VA: 0x3E81440
	|-List<char>..cctor
	|
	|-RVA: 0x3E84440 Offset: 0x3E84541 VA: 0x3E84440
	|-List<Color>..cctor
	|
	|-RVA: 0x3E87250 Offset: 0x3E87351 VA: 0x3E87250
	|-List<Color32>..cctor
	|
	|-RVA: 0x3E8A170 Offset: 0x3E8A271 VA: 0x3E8A170
	|-List<ConstraintSource>..cctor
	|
	|-RVA: 0x3E8D380 Offset: 0x3E8D481 VA: 0x3E8D380
	|-List<ContourVertex>..cctor
	|
	|-RVA: 0x3E90560 Offset: 0x3E90661 VA: 0x3E90560
	|-List<DataStoreRatingInfo>..cctor
	|
	|-RVA: 0x3E93370 Offset: 0x3E93471 VA: 0x3E93370
	|-List<DataStoreResult>..cctor
	|
	|-RVA: 0x3E96180 Offset: 0x3E96281 VA: 0x3E96180
	|-List<DateTime>..cctor
	|
	|-RVA: 0x3E99060 Offset: 0x3E99161 VA: 0x3E99060
	|-List<DateTimeOffset>..cctor
	|
	|-RVA: 0x3E9BF40 Offset: 0x3E9C041 VA: 0x3E9BF40
	|-List<Decimal>..cctor
	|
	|-RVA: 0x3E9F380 Offset: 0x3E9F481 VA: 0x3E9F380
	|-List<DiagnosticEvent>..cctor
	|
	|-RVA: 0x3EA21A0 Offset: 0x3EA22A1 VA: 0x3EA21A0
	|-List<double>..cctor
	|
	|-RVA: 0x3EA5530 Offset: 0x3EA5631 VA: 0x3EA5530
	|-List<Friend>..cctor
	|
	|-RVA: 0x3EA8410 Offset: 0x3EA8511 VA: 0x3EA8410
	|-List<GlyphRect>..cctor
	|
	|-RVA: 0x3EAB210 Offset: 0x3EAB311 VA: 0x3EAB210
	|-List<short>..cctor
	|
	|-RVA: 0x3EAE010 Offset: 0x3EAE111 VA: 0x3EAE010
	|-List<int>..cctor
	|
	|-RVA: 0x3EB0E10 Offset: 0x3EB0F11 VA: 0x3EB0E10
	|-List<Int32Enum>..cctor
	|
	|-RVA: 0x3EB3C10 Offset: 0x3EB3D11 VA: 0x3EB3C10
	|-List<long>..cctor
	|
	|-RVA: 0x3E00FE0 Offset: 0x3E010E1 VA: 0x3E00FE0
	|-List<IntPtr>..cctor
	|
	|-RVA: 0x3E03F00 Offset: 0x3E04001 VA: 0x3E03F00
	|-List<InterpretedFrameInfo>..cctor
	|
	|-RVA: 0x3E070E0 Offset: 0x3E071E1 VA: 0x3E070E0
	|-List<IntervalTreeNode>..cctor
	|
	|-RVA: 0x3E09EF0 Offset: 0x3E09FF1 VA: 0x3E09EF0
	|-List<LengthLimitProperties>..cctor
	|
	|-RVA: 0x3E0CD00 Offset: 0x3E0CE01 VA: 0x3E0CD00
	|-List<MapPos>..cctor
	|
	|-RVA: 0x3E10280 Offset: 0x3E10381 VA: 0x3E10280
	|-List<Matrix4x4>..cctor
	|
	|-RVA: 0x3E13040 Offset: 0x3E13141 VA: 0x3E13040
	|-List<object>..cctor
	|
	|-RVA: 0x3E16480 Offset: 0x3E16581 VA: 0x3E16480
	|-List<ObjectInitializationData>..cctor
	|
	|-RVA: 0x3E196A0 Offset: 0x3E197A1 VA: 0x3E196A0
	|-List<PlayableBinding>..cctor
	|
	|-RVA: 0x3E1CA70 Offset: 0x3E1CB71 VA: 0x3E1CA70
	|-List<PlayerLoopSystem>..cctor
	|
	|-RVA: 0x3DA6F10 Offset: 0x3DA7011 VA: 0x3DA6F10
	|-List<PlayerLoopSystemInternal>..cctor
	|
	|-RVA: 0x3DA9E30 Offset: 0x3DA9F31 VA: 0x3DA9E30
	|-List<RangePositionInfo>..cctor
	|
	|-RVA: 0x3DACC40 Offset: 0x3DACD41 VA: 0x3DACC40
	|-List<Ranking2ChartInfoInput>..cctor
	|
	|-RVA: 0x3DB0060 Offset: 0x3DB0161 VA: 0x3DB0060
	|-List<RaycastHit2D>..cctor
	|
	|-RVA: 0x3DB3870 Offset: 0x3DB3971 VA: 0x3DB3870
	|-List<RaycastResult>..cctor
	|
	|-RVA: 0x3DB6870 Offset: 0x3DB6971 VA: 0x3DB6870
	|-List<Rect>..cctor
	|
	|-RVA: 0x3DB9680 Offset: 0x3DB9781 VA: 0x3DB9680
	|-List<RendererListHandle>..cctor
	|
	|-RVA: 0x3DBC490 Offset: 0x3DBC591 VA: 0x3DBC490
	|-List<ResourceHandle>..cctor
	|
	|-RVA: 0x3DBF2A0 Offset: 0x3DBF3A1 VA: 0x3DBF2A0
	|-List<sbyte>..cctor
	|
	|-RVA: 0x3DC20B0 Offset: 0x3DC21B1 VA: 0x3DC20B0
	|-List<ShaderTagId>..cctor
	|
	|-RVA: 0x3E3DD20 Offset: 0x3E3DE21 VA: 0x3E3DD20
	|-List<float>..cctor
	|
	|-RVA: 0x3E41A00 Offset: 0x3E41B01 VA: 0x3E41A00
	|-List<SphericalHarmonicsL2>..cctor
	|
	|-RVA: 0x3E44DF0 Offset: 0x3E44EF1 VA: 0x3E44DF0
	|-List<SubMeshDescriptor>..cctor
	|
	|-RVA: 0x3E47D10 Offset: 0x3E47E11 VA: 0x3E47D10
	|-List<TablePair>..cctor
	|
	|-RVA: 0x3E4AB20 Offset: 0x3E4AC21 VA: 0x3E4AB20
	|-List<TimeSpan>..cctor
	|
	|-RVA: 0x3E4DB00 Offset: 0x3E4DC01 VA: 0x3E4DB00
	|-List<UICharInfo>..cctor
	|
	|-RVA: 0x3E509E0 Offset: 0x3E50AE1 VA: 0x3E509E0
	|-List<UILineInfo>..cctor
	|
	|-RVA: 0x3E546C0 Offset: 0x3E547C1 VA: 0x3E546C0
	|-List<UIVertex>..cctor
	|
	|-RVA: 0x3E574C0 Offset: 0x3E575C1 VA: 0x3E574C0
	|-List<ushort>..cctor
	|
	|-RVA: 0x3E5A2C0 Offset: 0x3E5A3C1 VA: 0x3E5A2C0
	|-List<uint>..cctor
	|
	|-RVA: 0x3DC4EB0 Offset: 0x3DC4FB1 VA: 0x3DC4EB0
	|-List<ulong>..cctor
	|
	|-RVA: 0x3DC7D80 Offset: 0x3DC7E81 VA: 0x3DC7D80
	|-List<Vector2>..cctor
	|
	|-RVA: 0x3DCAD60 Offset: 0x3DCAE61 VA: 0x3DCAD60
	|-List<Vector3>..cctor
	|
	|-RVA: 0x3DCDD60 Offset: 0x3DCDE61 VA: 0x3DCDD60
	|-List<Vector4>..cctor
	|
	|-RVA: 0x3DD0C40 Offset: 0x3DD0D41 VA: 0x3DD0C40
	|-List<VertexAttributeDescriptor>..cctor
	|
	|-RVA: 0x3DD3B60 Offset: 0x3DD3C61 VA: 0x3DD3B60
	|-List<X509ChainStatus>..cctor
	|
	|-RVA: 0x3DD6F50 Offset: 0x3DD7051 VA: 0x3DD6F50
	|-List<XRView>..cctor
	|
	|-RVA: 0x3DD9E70 Offset: 0x3DD9F71 VA: 0x3DD9E70
	|-List<AmiiboSequence.GainItemData>..cctor
	|
	|-RVA: 0x3DDD210 Offset: 0x3DDD311 VA: 0x3DDD210
	|-List<AnimationOutputWeightProcessor.WeightInfo>..cctor
	|
	|-RVA: 0x3DE0130 Offset: 0x3DE0231 VA: 0x3DE0130
	|-List<ArenaOrderSequence.GodInfo>..cctor
	|
	|-RVA: 0x3E1F990 Offset: 0x3E1FA91 VA: 0x3E1F990
	|-List<BattleInfo.SupportData>..cctor
	|
	|-RVA: 0x3E228B0 Offset: 0x3E229B1 VA: 0x3E228B0
	|-List<BeforeRenderHelper.OrderBlock>..cctor
	|
	|-RVA: 0x3E25AE0 Offset: 0x3E25BE1 VA: 0x3E25AE0
	|-List<Camera.RenderRequest>..cctor
	|
	|-RVA: 0x3E28A00 Offset: 0x3E28B01 VA: 0x3E28A00
	|-List<CameraState.CustomBlendable>..cctor
	|
	|-RVA: 0x3E2B810 Offset: 0x3E2B911 VA: 0x3E2B810
	|-List<CinemachineClearShot.Pair>..cctor
	|
	|-RVA: 0x3E2E620 Offset: 0x3E2E721 VA: 0x3E2E620
	|-List<CinemachineStateDrivenCamera.HashPair>..cctor
	|
	|-RVA: 0x3E31840 Offset: 0x3E31941 VA: 0x3E31840
	|-List<DelayedActionManager.DelegateInfo>..cctor
	|
	|-RVA: 0x3E34C30 Offset: 0x3E34D31 VA: 0x3E34C30
	|-List<Detail.AsyncResultInt>..cctor
	|
	|-RVA: 0x3E37B10 Offset: 0x3E37C11 VA: 0x3E37B10
	|-List<Detail.CppArray>..cctor
	|
	|-RVA: 0x3E3AF00 Offset: 0x3E3B001 VA: 0x3E3AF00
	|-List<Detail.NotificationEventInt>..cctor
	|
	|-RVA: 0x3E5D1E0 Offset: 0x3E5D2E1 VA: 0x3E5D1E0
	|-List<DragonRideTargetGroup.ChainParam>..cctor
	|
	|-RVA: 0x3E603F0 Offset: 0x3E604F1 VA: 0x3E603F0
	|-List<GmapPathAdjuster.TargetModel>..cctor
	|
	|-RVA: 0x3E63600 Offset: 0x3E63701 VA: 0x3E63600
	|-List<GmapSpotAdjuster.TargetModel>..cctor
	|
	|-RVA: 0x3E66810 Offset: 0x3E66911 VA: 0x3E66810
	|-List<HubFastTravel.Location>..cctor
	|
	|-RVA: 0x3E69C50 Offset: 0x3E69D51 VA: 0x3E69C50
	|-List<HubLensFlare.Flare>..cctor
	|
	|-RVA: 0x3E6CB70 Offset: 0x3E6CC71 VA: 0x3E6CB70
	|-List<InventoryPoolItemMenuContent.KindBgNameClass>..cctor
	|
	|-RVA: 0x3E6F980 Offset: 0x3E6FA81 VA: 0x3E6F980
	|-List<Map.Pos>..cctor
	|
	|-RVA: 0x3E72860 Offset: 0x3E72961 VA: 0x3E72860
	|-List<MapImage.BackupTerrain>..cctor
	|
	|-RVA: 0x3E75700 Offset: 0x3E75801 VA: 0x3E75700
	|-List<MapImageRange.Pos>..cctor
	|
	|-RVA: 0x3E78910 Offset: 0x3E78A11 VA: 0x3E78910
	|-List<MapMind.Target>..cctor
	|
	|-RVA: 0x3D884E0 Offset: 0x3D885E1 VA: 0x3D884E0
	|-List<MapPanelDebug.Entity>..cctor
	|
	|-RVA: 0x3D8B2F0 Offset: 0x3D8B3F1 VA: 0x3D8B2F0
	|-List<NexRanking.Data>..cctor
	|
	|-RVA: 0x3D8E1D0 Offset: 0x3D8E2D1 VA: 0x3D8E1D0
	|-List<NexVersus.RatingData>..cctor
	|
	|-RVA: 0x3D910F0 Offset: 0x3D911F1 VA: 0x3D910F0
	|-List<PackedPlayModeBuildLogs.RuntimeBuildLog>..cctor
	|
	|-RVA: 0x3D944A0 Offset: 0x3D945A1 VA: 0x3D944A0
	|-List<ParticleSystem.Particle>..cctor
	|
	|-RVA: 0x3D972B0 Offset: 0x3D973B1 VA: 0x3D972B0
	|-List<RangeData.Offset>..cctor
	|
	|-RVA: 0x3D9A4D0 Offset: 0x3D9A5D1 VA: 0x3D9A4D0
	|-List<RenderGraphDebugData.PassDebugData>..cctor
	|
	|-RVA: 0x3D9D8A0 Offset: 0x3D9D9A1 VA: 0x3D9D8A0
	|-List<RenderGraphDebugData.ResourceDebugData>..cctor
	|
	|-RVA: 0x3DA07C0 Offset: 0x3DA08C1 VA: 0x3DA07C0
	|-List<RingCleaningUnitSelectMenu.GodParam>..cctor
	|
	|-RVA: 0x3DA3B40 Offset: 0x3DA3C41 VA: 0x3DA3B40
	|-List<ShadowUtility.Edge>..cctor
	|
	|-RVA: 0x3D15E20 Offset: 0x3D15F21 VA: 0x3D15E20
	|-List<SkillArray.Entity>..cctor
	|
	|-RVA: 0x3D193E0 Offset: 0x3D194E1 VA: 0x3D193E0
	|-List<TexturePacker_JsonArray.Frame>..cctor
	|
	|-RVA: 0x3D1C610 Offset: 0x3D1C711 VA: 0x3D1C610
	|-List<TimeNotificationBehaviour.NotificationEntry>..cctor
	|
	|-RVA: 0x3D1F820 Offset: 0x3D1F921 VA: 0x3D1F820
	|-List<UnitySynchronizationContext.WorkRequest>..cctor
	|
	|-RVA: 0x3D22740 Offset: 0x3D22841 VA: 0x3D22740
	|-List<XmlSchemaObjectTable.XmlSchemaObjectEntry>..cctor
	|
	|-RVA: 0x3D25660 Offset: 0x3D25761 VA: 0x3D25660
	|-List<AssetBundleBuildMap.AssetBundleEntry.AssetPathString>..cctor
	|
	|-RVA: 0x3D28A80 Offset: 0x3D28B81 VA: 0x3D28A80
	|-List<Detail.DataStore.DataStoreChangeMetaParamInt>..cctor
	|
	|-RVA: 0x3D2B960 Offset: 0x3D2BA61 VA: 0x3D2B960
	|-List<Detail.DataStore.DataStoreDeleteParamInt>..cctor
	|
	|-RVA: 0x3D2ED00 Offset: 0x3D2EE01 VA: 0x3D2ED00
	|-List<Detail.DataStore.DataStoreGetMetaParamInt>..cctor
	|
	|-RVA: 0x3D320F0 Offset: 0x3D321F1 VA: 0x3D320F0
	|-List<Detail.DataStore.DataStoreMetaInfoInt>..cctor
	|
	|-RVA: 0x3CF6720 Offset: 0x3CF6821 VA: 0x3CF6720
	|-List<Detail.DataStore.DataStorePasswordInfoInt>..cctor
	|
	|-RVA: 0x3CF9900 Offset: 0x3CF9A01 VA: 0x3CF9900
	|-List<Detail.DataStore.DataStorePersistenceInfoInt>..cctor
	|
	|-RVA: 0x3CFCCB0 Offset: 0x3CFCDB1 VA: 0x3CFCCB0
	|-List<Detail.DataStore.DataStorePreparePostParamInt>..cctor
	|
	|-RVA: 0x3CFFB90 Offset: 0x3CFFC91 VA: 0x3CFFB90
	|-List<Detail.DataStore.DataStoreRateObjectParamInt>..cctor
	|
	|-RVA: 0x3D02D80 Offset: 0x3D02E81 VA: 0x3D02D80
	|-List<Detail.DataStore.DataStoreRatingInitParamInt>..cctor
	|
	|-RVA: 0x3D05C60 Offset: 0x3D05D61 VA: 0x3D05C60
	|-List<Detail.DataStore.DataStoreRatingTargetInt>..cctor
	|
	|-RVA: 0x3D09240 Offset: 0x3D09341 VA: 0x3D09240
	|-List<Detail.Ranking.RankingCachedResultInt>..cctor
	|
	|-RVA: 0x3D0C120 Offset: 0x3D0C221 VA: 0x3D0C120
	|-List<Detail.Ranking.RankingOrderParamInt>..cctor
	|
	|-RVA: 0x3D0F6A0 Offset: 0x3D0F7A1 VA: 0x3D0F6A0
	|-List<Detail.Ranking.RankingRankDataInt>..cctor
	|
	|-RVA: 0x3D13010 Offset: 0x3D13111 VA: 0x3D13010
	|-List<Detail.Ranking2.Ranking2ChartInfoInt>..cctor
	|
	|-RVA: 0x3D69620 Offset: 0x3D69721 VA: 0x3D69620
	|-List<Detail.Ranking2.Ranking2RankDataInt>..cctor
	|
	|-RVA: 0x3D6C500 Offset: 0x3D6C601 VA: 0x3D6C500
	|-List<Detail.Ranking2.Ranking2ScoreDataInt>..cctor
	|
	|-RVA: 0x3D6F6F0 Offset: 0x3D6F7F1 VA: 0x3D6F6F0
	|-List<Detail.Screening.ScreeningContextInfoInt>..cctor
	|
	|-RVA: 0x3D72EC0 Offset: 0x3D72FC1 VA: 0x3D72EC0
	|-List<Detail.Subscriber.SubscriberContentInt>..cctor
	|
	|-RVA: 0x3D760A0 Offset: 0x3D761A1 VA: 0x3D760A0
	|-List<Detail.Subscriber.SubscriberGetContentParamInt>..cctor
	|
	|-RVA: 0x3D79440 Offset: 0x3D79541 VA: 0x3D79440
	|-List<Detail.Subscriber.SubscriberUserStatusInfoInt>..cctor
	|
	|-RVA: 0x3D7C620 Offset: 0x3D7C721 VA: 0x3D7C620
	|-List<Detail.Subscriber.SubscriberUserStatusParamInt>..cctor
	|
	|-RVA: 0x3D7F430 Offset: 0x3D7F531 VA: 0x3D7F430
	|-List<Detail.Utility.IntegerSettings>..cctor
	|
	|-RVA: 0x3D82310 Offset: 0x3D82411 VA: 0x3D82310
	|-List<Detail.Utility.UniqueIdInfoInt>..cctor
	|
	|-RVA: 0x3D85300 Offset: 0x3D85401 VA: 0x3D85300
	|-List<MapHistory.Rewind.LatestInspectorData>..cctor
	|
	|-RVA: 0x30615C0 Offset: 0x30616C1 VA: 0x30615C0
	|-List<MapHistory.Rewind.WorkTerrainData>..cctor
	|
	|-RVA: 0x30644E0 Offset: 0x30645E1 VA: 0x30644E0
	|-List<MapSkill.AroundCalculator.Result>..cctor
	|
	|-RVA: 0x3067860 Offset: 0x3067961 VA: 0x3067860
	|-List<TargetPositionCache.CacheCurve.Item>..cctor
	|
	|-RVA: 0x306AC80 Offset: 0x306AD81 VA: 0x306AC80
	|-List<TargetPositionCache.CacheEntry.RecordingItem>..cctor
	*/
}

