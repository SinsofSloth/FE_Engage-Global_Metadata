// Namespace: 
[Serializable]
public struct List.Enumerator<T> : IEnumerator<T>, IDisposable, IEnumerator // TypeDefIndex: 1440
{
	// Fields
	private List<T> list; // 0x0
	private int index; // 0x0
	private int version; // 0x0
	private T current; // 0x0

	// Properties
	public T Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(List<T> list) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1D2BA90 Offset: 0x1D2BB91 VA: 0x1D2BA90
	|-List.Enumerator<IntervalTree.Entry<object>>..ctor
	|
	|-RVA: 0x1D2BD60 Offset: 0x1D2BE61 VA: 0x1D2BD60
	|-List.Enumerator<KeyValuePair<DateTime, object>>..ctor
	|
	|-RVA: 0x1D2DAD0 Offset: 0x1D2DBD1 VA: 0x1D2DAD0
	|-List.Enumerator<KeyValuePair<int, object>>..ctor
	|
	|-RVA: 0x1D2DDA0 Offset: 0x1D2DEA1 VA: 0x1D2DDA0
	|-List.Enumerator<KeyValuePair<object, ValueTuple<int, DateTime, object>>>..ctor
	|
	|-RVA: 0x1D2E070 Offset: 0x1D2E171 VA: 0x1D2E070
	|-List.Enumerator<KeyValuePair<object, object>>..ctor
	|
	|-RVA: 0x1D2F0B0 Offset: 0x1D2F1B1 VA: 0x1D2F0B0
	|-List.Enumerator<CommonBattleSequence.Reliance<object>>..ctor
	|
	|-RVA: 0x2EAE820 Offset: 0x2EAE921 VA: 0x2EAE820
	|-List.Enumerator<RenderGraphResourcePool.ResourceLogInfo<object>>..ctor
	|
	|-RVA: 0x2EAF1D0 Offset: 0x2EAF2D1 VA: 0x2EAF1D0
	|-List.Enumerator<ValueTuple<int, object>>..ctor
	|
	|-RVA: 0x2EAF4A0 Offset: 0x2EAF5A1 VA: 0x2EAF4A0
	|-List.Enumerator<ValueTuple<Int32Enum, int>>..ctor
	|
	|-RVA: 0x2EAF750 Offset: 0x2EAF851 VA: 0x2EAF750
	|-List.Enumerator<ValueTuple<object, ValueTuple<object, int>>>..ctor
	|
	|-RVA: 0x2EAFD30 Offset: 0x2EAFE31 VA: 0x2EAFD30
	|-List.Enumerator<ValueTuple<object, int>>..ctor
	|
	|-RVA: 0x2EB0780 Offset: 0x2EB0881 VA: 0x2EB0780
	|-List.Enumerator<ValueTuple<Vector3, float>>..ctor
	|
	|-RVA: 0x2EB0A20 Offset: 0x2EB0B21 VA: 0x2EB0A20
	|-List.Enumerator<ValueTuple<object, Int32Enum, int>>..ctor
	|
	|-RVA: 0x2EB1160 Offset: 0x2EB1261 VA: 0x2EB1160
	|-List.Enumerator<ValueTuple<object, int, int, int>>..ctor
	|
	|-RVA: 0x2EB1430 Offset: 0x2EB1531 VA: 0x2EB1430
	|-List.Enumerator<AnimatorClipInfo>..ctor
	|
	|-RVA: 0x2EB1E50 Offset: 0x2EB1F51 VA: 0x2EB1E50
	|-List.Enumerator<AsyncOperationHandle>..ctor
	|
	|-RVA: 0x2EB25D0 Offset: 0x2EB26D1 VA: 0x2EB25D0
	|-List.Enumerator<BoneWeight>..ctor
	|
	|-RVA: 0x2EB2990 Offset: 0x2EB2A91 VA: 0x2EB2990
	|-List.Enumerator<bool>..ctor
	|
	|-RVA: 0x2EB2C40 Offset: 0x2EB2D41 VA: 0x2EB2C40
	|-List.Enumerator<byte>..ctor
	|
	|-RVA: 0x2EB2FF0 Offset: 0x2EB30F1 VA: 0x2EB2FF0
	|-List.Enumerator<CameraInfo>..ctor
	|
	|-RVA: 0x2EB32C0 Offset: 0x2EB33C1 VA: 0x2EB32C0
	|-List.Enumerator<char>..ctor
	|
	|-RVA: 0x2EB3570 Offset: 0x2EB3671 VA: 0x2EB3570
	|-List.Enumerator<Color>..ctor
	|
	|-RVA: 0x2EB3B50 Offset: 0x2EB3C51 VA: 0x2EB3B50
	|-List.Enumerator<Color32>..ctor
	|
	|-RVA: 0x2EB3E00 Offset: 0x2EB3F01 VA: 0x2EB3E00
	|-List.Enumerator<ConstraintSource>..ctor
	|
	|-RVA: 0x2EB40D0 Offset: 0x2EB41D1 VA: 0x2EB40D0
	|-List.Enumerator<ContourVertex>..ctor
	|
	|-RVA: 0x2EB43A0 Offset: 0x2EB44A1 VA: 0x2EB43A0
	|-List.Enumerator<DataStoreRatingInfo>..ctor
	|
	|-RVA: 0x2EB4660 Offset: 0x2EB4761 VA: 0x2EB4660
	|-List.Enumerator<DataStoreResult>..ctor
	|
	|-RVA: 0x2EB4910 Offset: 0x2EB4A11 VA: 0x2EB4910
	|-List.Enumerator<DateTime>..ctor
	|
	|-RVA: 0x2EB4BC0 Offset: 0x2EB4CC1 VA: 0x2EB4BC0
	|-List.Enumerator<DateTimeOffset>..ctor
	|
	|-RVA: 0x2EB4E80 Offset: 0x2EB4F81 VA: 0x2EB4E80
	|-List.Enumerator<Decimal>..ctor
	|
	|-RVA: 0x2EB5140 Offset: 0x2EB5241 VA: 0x2EB5140
	|-List.Enumerator<DiagnosticEvent>..ctor
	|
	|-RVA: 0x2EB5410 Offset: 0x2EB5511 VA: 0x2EB5410
	|-List.Enumerator<double>..ctor
	|
	|-RVA: 0x2EB56C0 Offset: 0x2EB57C1 VA: 0x2EB56C0
	|-List.Enumerator<Friend>..ctor
	|
	|-RVA: 0x2EB5980 Offset: 0x2EB5A81 VA: 0x2EB5980
	|-List.Enumerator<GlyphRect>..ctor
	|
	|-RVA: 0x2EB5C40 Offset: 0x2EB5D41 VA: 0x2EB5C40
	|-List.Enumerator<short>..ctor
	|
	|-RVA: 0x2EB61E0 Offset: 0x2EB62E1 VA: 0x2EB61E0
	|-List.Enumerator<int>..ctor
	|
	|-RVA: 0x2EB6ED0 Offset: 0x2EB6FD1 VA: 0x2EB6ED0
	|-List.Enumerator<Int32Enum>..ctor
	|
	|-RVA: 0x2EB75A0 Offset: 0x2EB76A1 VA: 0x2EB75A0
	|-List.Enumerator<long>..ctor
	|
	|-RVA: 0x2EB7850 Offset: 0x2EB7951 VA: 0x2EB7850
	|-List.Enumerator<IntPtr>..ctor
	|
	|-RVA: 0x2EB7B00 Offset: 0x2EB7C01 VA: 0x2EB7B00
	|-List.Enumerator<InterpretedFrameInfo>..ctor
	|
	|-RVA: 0x2EB7DD0 Offset: 0x2EB7ED1 VA: 0x2EB7DD0
	|-List.Enumerator<IntervalTreeNode>..ctor
	|
	|-RVA: 0x2EB81A0 Offset: 0x2EB82A1 VA: 0x2EB81A0
	|-List.Enumerator<LengthLimitProperties>..ctor
	|
	|-RVA: 0x2EB8980 Offset: 0x2EB8A81 VA: 0x2EB8980
	|-List.Enumerator<MapPos>..ctor
	|
	|-RVA: 0x2EB8C30 Offset: 0x2EB8D31 VA: 0x2EB8C30
	|-List.Enumerator<Matrix4x4>..ctor
	|
	|-RVA: 0x2EB95A0 Offset: 0x2EB96A1 VA: 0x2EB95A0
	|-List.Enumerator<object>..ctor
	|
	|-RVA: 0x2EBAD00 Offset: 0x2EBAE01 VA: 0x2EBAD00
	|-List.Enumerator<ObjectInitializationData>..ctor
	|
	|-RVA: 0x2EBB0F0 Offset: 0x2EBB1F1 VA: 0x2EBB0F0
	|-List.Enumerator<PlayableBinding>..ctor
	|
	|-RVA: 0x2EBB3C0 Offset: 0x2EBB4C1 VA: 0x2EBB3C0
	|-List.Enumerator<PlayerLoopSystem>..ctor
	|
	|-RVA: 0x2EBB690 Offset: 0x2EBB791 VA: 0x2EBB690
	|-List.Enumerator<PlayerLoopSystemInternal>..ctor
	|
	|-RVA: 0x2EBBDD0 Offset: 0x2EBBED1 VA: 0x2EBBDD0
	|-List.Enumerator<RangePositionInfo>..ctor
	|
	|-RVA: 0x2EBC0A0 Offset: 0x2EBC1A1 VA: 0x2EBC0A0
	|-List.Enumerator<Ranking2ChartInfoInput>..ctor
	|
	|-RVA: 0x2EBC350 Offset: 0x2EBC451 VA: 0x2EBC350
	|-List.Enumerator<RaycastHit2D>..ctor
	|
	|-RVA: 0x2EBC630 Offset: 0x2EBC731 VA: 0x2EBC630
	|-List.Enumerator<RaycastResult>..ctor
	|
	|-RVA: 0x2EBC960 Offset: 0x2EBCA61 VA: 0x2EBC960
	|-List.Enumerator<Rect>..ctor
	|
	|-RVA: 0x2EBCD60 Offset: 0x2EBCE61 VA: 0x2EBCD60
	|-List.Enumerator<RendererListHandle>..ctor
	|
	|-RVA: 0x2EBD010 Offset: 0x2EBD111 VA: 0x2EBD010
	|-List.Enumerator<ResourceHandle>..ctor
	|
	|-RVA: 0x2EBD2C0 Offset: 0x2EBD3C1 VA: 0x2EBD2C0
	|-List.Enumerator<sbyte>..ctor
	|
	|-RVA: 0x2EBD570 Offset: 0x2EBD671 VA: 0x2EBD570
	|-List.Enumerator<ShaderTagId>..ctor
	|
	|-RVA: 0x2EBD920 Offset: 0x2EBDA21 VA: 0x2EBD920
	|-List.Enumerator<float>..ctor
	|
	|-RVA: 0x2EBDEF0 Offset: 0x2EBDFF1 VA: 0x2EBDEF0
	|-List.Enumerator<SphericalHarmonicsL2>..ctor
	|
	|-RVA: 0x2EBE9A0 Offset: 0x2EBEAA1 VA: 0x2EBE9A0
	|-List.Enumerator<SubMeshDescriptor>..ctor
	|
	|-RVA: 0x2EBF090 Offset: 0x2EBF191 VA: 0x2EBF090
	|-List.Enumerator<TablePair>..ctor
	|
	|-RVA: 0x2E02A70 Offset: 0x2E02B71 VA: 0x2E02A70
	|-List.Enumerator<TimeSpan>..ctor
	|
	|-RVA: 0x2E02D20 Offset: 0x2E02E21 VA: 0x2E02D20
	|-List.Enumerator<UICharInfo>..ctor
	|
	|-RVA: 0x2E02FD0 Offset: 0x2E030D1 VA: 0x2E02FD0
	|-List.Enumerator<UILineInfo>..ctor
	|
	|-RVA: 0x2E03290 Offset: 0x2E03391 VA: 0x2E03290
	|-List.Enumerator<UIVertex>..ctor
	|
	|-RVA: 0x2E03600 Offset: 0x2E03701 VA: 0x2E03600
	|-List.Enumerator<ushort>..ctor
	|
	|-RVA: 0x2E03CA0 Offset: 0x2E03DA1 VA: 0x2E03CA0
	|-List.Enumerator<uint>..ctor
	|
	|-RVA: 0x2E04650 Offset: 0x2E04751 VA: 0x2E04650
	|-List.Enumerator<ulong>..ctor
	|
	|-RVA: 0x2E04900 Offset: 0x2E04A01 VA: 0x2E04900
	|-List.Enumerator<Vector2>..ctor
	|
	|-RVA: 0x2E04E70 Offset: 0x2E04F71 VA: 0x2E04E70
	|-List.Enumerator<Vector3>..ctor
	|
	|-RVA: 0x2E053F0 Offset: 0x2E054F1 VA: 0x2E053F0
	|-List.Enumerator<Vector4>..ctor
	|
	|-RVA: 0x2E05690 Offset: 0x2E05791 VA: 0x2E05690
	|-List.Enumerator<VertexAttributeDescriptor>..ctor
	|
	|-RVA: 0x2E05BC0 Offset: 0x2E05CC1 VA: 0x2E05BC0
	|-List.Enumerator<X509ChainStatus>..ctor
	|
	|-RVA: 0x2E05E90 Offset: 0x2E05F91 VA: 0x2E05E90
	|-List.Enumerator<XRView>..ctor
	|
	|-RVA: 0x2E06540 Offset: 0x2E06641 VA: 0x2E06540
	|-List.Enumerator<AmiiboSequence.GainItemData>..ctor
	|
	|-RVA: 0x2E06810 Offset: 0x2E06911 VA: 0x2E06810
	|-List.Enumerator<AnimationOutputWeightProcessor.WeightInfo>..ctor
	|
	|-RVA: 0x2E06AD0 Offset: 0x2E06BD1 VA: 0x2E06AD0
	|-List.Enumerator<ArenaOrderSequence.GodInfo>..ctor
	|
	|-RVA: 0x2E06DA0 Offset: 0x2E06EA1 VA: 0x2E06DA0
	|-List.Enumerator<BattleInfo.SupportData>..ctor
	|
	|-RVA: 0x2E07070 Offset: 0x2E07171 VA: 0x2E07070
	|-List.Enumerator<BeforeRenderHelper.OrderBlock>..ctor
	|
	|-RVA: 0x2E07340 Offset: 0x2E07441 VA: 0x2E07340
	|-List.Enumerator<Camera.RenderRequest>..ctor
	|
	|-RVA: 0x2E07610 Offset: 0x2E07711 VA: 0x2E07610
	|-List.Enumerator<CameraState.CustomBlendable>..ctor
	|
	|-RVA: 0x2E078E0 Offset: 0x2E079E1 VA: 0x2E078E0
	|-List.Enumerator<CinemachineClearShot.Pair>..ctor
	|
	|-RVA: 0x2E07B90 Offset: 0x2E07C91 VA: 0x2E07B90
	|-List.Enumerator<CinemachineStateDrivenCamera.HashPair>..ctor
	|
	|-RVA: 0x2E083D0 Offset: 0x2E084D1 VA: 0x2E083D0
	|-List.Enumerator<DelayedActionManager.DelegateInfo>..ctor
	|
	|-RVA: 0x2E086A0 Offset: 0x2E087A1 VA: 0x2E086A0
	|-List.Enumerator<Detail.AsyncResultInt>..ctor
	|
	|-RVA: 0x2E08960 Offset: 0x2E08A61 VA: 0x2E08960
	|-List.Enumerator<Detail.CppArray>..ctor
	|
	|-RVA: 0x2E08C20 Offset: 0x2E08D21 VA: 0x2E08C20
	|-List.Enumerator<Detail.NotificationEventInt>..ctor
	|
	|-RVA: 0x2E08EE0 Offset: 0x2E08FE1 VA: 0x2E08EE0
	|-List.Enumerator<DragonRideTargetGroup.ChainParam>..ctor
	|
	|-RVA: 0x2E094D0 Offset: 0x2E095D1 VA: 0x2E094D0
	|-List.Enumerator<GmapPathAdjuster.TargetModel>..ctor
	|
	|-RVA: 0x2E097A0 Offset: 0x2E098A1 VA: 0x2E097A0
	|-List.Enumerator<GmapSpotAdjuster.TargetModel>..ctor
	|
	|-RVA: 0x2E09A70 Offset: 0x2E09B71 VA: 0x2E09A70
	|-List.Enumerator<HubFastTravel.Location>..ctor
	|
	|-RVA: 0x2E09D40 Offset: 0x2E09E41 VA: 0x2E09D40
	|-List.Enumerator<HubLensFlare.Flare>..ctor
	|
	|-RVA: 0x2E0A010 Offset: 0x2E0A111 VA: 0x2E0A010
	|-List.Enumerator<InventoryPoolItemMenuContent.KindBgNameClass>..ctor
	|
	|-RVA: 0x2E0A550 Offset: 0x2E0A651 VA: 0x2E0A550
	|-List.Enumerator<Map.Pos>..ctor
	|
	|-RVA: 0x2E0A800 Offset: 0x2E0A901 VA: 0x2E0A800
	|-List.Enumerator<MapImage.BackupTerrain>..ctor
	|
	|-RVA: 0x2E0AAC0 Offset: 0x2E0ABC1 VA: 0x2E0AAC0
	|-List.Enumerator<MapImageRange.Pos>..ctor
	|
	|-RVA: 0x2E0B120 Offset: 0x2E0B221 VA: 0x2E0B120
	|-List.Enumerator<MapMind.Target>..ctor
	|
	|-RVA: 0x2E0B3F0 Offset: 0x2E0B4F1 VA: 0x2E0B3F0
	|-List.Enumerator<MapPanelDebug.Entity>..ctor
	|
	|-RVA: 0x2E0B6B0 Offset: 0x2E0B7B1 VA: 0x2E0B6B0
	|-List.Enumerator<NexRanking.Data>..ctor
	|
	|-RVA: 0x2E0B960 Offset: 0x2E0BA61 VA: 0x2E0B960
	|-List.Enumerator<NexVersus.RatingData>..ctor
	|
	|-RVA: 0x2E0BC20 Offset: 0x2E0BD21 VA: 0x2E0BC20
	|-List.Enumerator<PackedPlayModeBuildLogs.RuntimeBuildLog>..ctor
	|
	|-RVA: 0x2E0BEF0 Offset: 0x2E0BFF1 VA: 0x2E0BEF0
	|-List.Enumerator<ParticleSystem.Particle>..ctor
	|
	|-RVA: 0x2E0C6D0 Offset: 0x2E0C7D1 VA: 0x2E0C6D0
	|-List.Enumerator<RangeData.Offset>..ctor
	|
	|-RVA: 0x2E0C980 Offset: 0x2E0CA81 VA: 0x2E0C980
	|-List.Enumerator<RenderGraphDebugData.PassDebugData>..ctor
	|
	|-RVA: 0x2E0CC50 Offset: 0x2E0CD51 VA: 0x2E0CC50
	|-List.Enumerator<RenderGraphDebugData.ResourceDebugData>..ctor
	|
	|-RVA: 0x2E0CF20 Offset: 0x2E0D021 VA: 0x2E0CF20
	|-List.Enumerator<RingCleaningUnitSelectMenu.GodParam>..ctor
	|
	|-RVA: 0x2E0D7F0 Offset: 0x2E0D8F1 VA: 0x2E0D7F0
	|-List.Enumerator<ShadowUtility.Edge>..ctor
	|
	|-RVA: 0x2E0DEF0 Offset: 0x2E0DFF1 VA: 0x2E0DEF0
	|-List.Enumerator<SkillArray.Entity>..ctor
	|
	|-RVA: 0x2E0E510 Offset: 0x2E0E611 VA: 0x2E0E510
	|-List.Enumerator<TexturePacker_JsonArray.Frame>..ctor
	|
	|-RVA: 0x2E0E810 Offset: 0x2E0E911 VA: 0x2E0E810
	|-List.Enumerator<TimeNotificationBehaviour.NotificationEntry>..ctor
	|
	|-RVA: 0x2E0EAE0 Offset: 0x2E0EBE1 VA: 0x2E0EAE0
	|-List.Enumerator<UnitySynchronizationContext.WorkRequest>..ctor
	|
	|-RVA: 0x2E0EDB0 Offset: 0x2E0EEB1 VA: 0x2E0EDB0
	|-List.Enumerator<XmlSchemaObjectTable.XmlSchemaObjectEntry>..ctor
	|
	|-RVA: 0x2E0F080 Offset: 0x2E0F181 VA: 0x2E0F080
	|-List.Enumerator<AssetBundleBuildMap.AssetBundleEntry.AssetPathString>..ctor
	|
	|-RVA: 0x2E0F350 Offset: 0x2E0F451 VA: 0x2E0F350
	|-List.Enumerator<Detail.DataStore.DataStoreChangeMetaParamInt>..ctor
	|
	|-RVA: 0x2E0F6E0 Offset: 0x2E0F7E1 VA: 0x2E0F6E0
	|-List.Enumerator<Detail.DataStore.DataStoreDeleteParamInt>..ctor
	|
	|-RVA: 0x2E0F9A0 Offset: 0x2E0FAA1 VA: 0x2E0F9A0
	|-List.Enumerator<Detail.DataStore.DataStoreGetMetaParamInt>..ctor
	|
	|-RVA: 0x2E0FC60 Offset: 0x2E0FD61 VA: 0x2E0FC60
	|-List.Enumerator<Detail.DataStore.DataStoreMetaInfoInt>..ctor
	|
	|-RVA: 0x2E0FFA0 Offset: 0x2E100A1 VA: 0x2E0FFA0
	|-List.Enumerator<Detail.DataStore.DataStorePasswordInfoInt>..ctor
	|
	|-RVA: 0x2E10260 Offset: 0x2E10361 VA: 0x2E10260
	|-List.Enumerator<Detail.DataStore.DataStorePersistenceInfoInt>..ctor
	|
	|-RVA: 0x2E10520 Offset: 0x2E10621 VA: 0x2E10520
	|-List.Enumerator<Detail.DataStore.DataStorePreparePostParamInt>..ctor
	|
	|-RVA: 0x2E10850 Offset: 0x2E10951 VA: 0x2E10850
	|-List.Enumerator<Detail.DataStore.DataStoreRateObjectParamInt>..ctor
	|
	|-RVA: 0x2E10B10 Offset: 0x2E10C11 VA: 0x2E10B10
	|-List.Enumerator<Detail.DataStore.DataStoreRatingInitParamInt>..ctor
	|
	|-RVA: 0x2E10DD0 Offset: 0x2E10ED1 VA: 0x2E10DD0
	|-List.Enumerator<Detail.DataStore.DataStoreRatingTargetInt>..ctor
	|
	|-RVA: 0x2E11090 Offset: 0x2E11191 VA: 0x2E11090
	|-List.Enumerator<Detail.Ranking.RankingCachedResultInt>..ctor
	|
	|-RVA: 0x2E11380 Offset: 0x2E11481 VA: 0x2E11380
	|-List.Enumerator<Detail.Ranking.RankingOrderParamInt>..ctor
	|
	|-RVA: 0x2E11640 Offset: 0x2E11741 VA: 0x2E11640
	|-List.Enumerator<Detail.Ranking.RankingRankDataInt>..ctor
	|
	|-RVA: 0x2E11930 Offset: 0x2E11A31 VA: 0x2E11930
	|-List.Enumerator<Detail.Ranking2.Ranking2ChartInfoInt>..ctor
	|
	|-RVA: 0x2E11C70 Offset: 0x2E11D71 VA: 0x2E11C70
	|-List.Enumerator<Detail.Ranking2.Ranking2RankDataInt>..ctor
	|
	|-RVA: 0x2E11F60 Offset: 0x2E12061 VA: 0x2E11F60
	|-List.Enumerator<Detail.Ranking2.Ranking2ScoreDataInt>..ctor
	|
	|-RVA: 0x2E12220 Offset: 0x2E12321 VA: 0x2E12220
	|-List.Enumerator<Detail.Screening.ScreeningContextInfoInt>..ctor
	|
	|-RVA: 0x2E124E0 Offset: 0x2E125E1 VA: 0x2E124E0
	|-List.Enumerator<Detail.Subscriber.SubscriberContentInt>..ctor
	|
	|-RVA: 0x2E127F0 Offset: 0x2E128F1 VA: 0x2E127F0
	|-List.Enumerator<Detail.Subscriber.SubscriberGetContentParamInt>..ctor
	|
	|-RVA: 0x2E12AB0 Offset: 0x2E12BB1 VA: 0x2E12AB0
	|-List.Enumerator<Detail.Subscriber.SubscriberUserStatusInfoInt>..ctor
	|
	|-RVA: 0x2E12D70 Offset: 0x2E12E71 VA: 0x2E12D70
	|-List.Enumerator<Detail.Subscriber.SubscriberUserStatusParamInt>..ctor
	|
	|-RVA: 0x2E13030 Offset: 0x2E13131 VA: 0x2E13030
	|-List.Enumerator<Detail.Utility.IntegerSettings>..ctor
	|
	|-RVA: 0x2E132E0 Offset: 0x2E133E1 VA: 0x2E132E0
	|-List.Enumerator<Detail.Utility.UniqueIdInfoInt>..ctor
	|
	|-RVA: 0x3499240 Offset: 0x3499341 VA: 0x3499240
	|-List.Enumerator<MapHistory.Rewind.LatestInspectorData>..ctor
	|
	|-RVA: 0x34994E0 Offset: 0x34995E1 VA: 0x34994E0
	|-List.Enumerator<MapHistory.Rewind.WorkTerrainData>..ctor
	|
	|-RVA: 0x3499780 Offset: 0x3499881 VA: 0x3499780
	|-List.Enumerator<MapSkill.AroundCalculator.Result>..ctor
	|
	|-RVA: 0x3499A50 Offset: 0x3499B51 VA: 0x3499A50
	|-List.Enumerator<TargetPositionCache.CacheCurve.Item>..ctor
	|
	|-RVA: 0x3499D20 Offset: 0x3499E21 VA: 0x3499D20
	|-List.Enumerator<TargetPositionCache.CacheEntry.RecordingItem>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1D2BAD0 Offset: 0x1D2BBD1 VA: 0x1D2BAD0
	|-List.Enumerator<IntervalTree.Entry<object>>.Dispose
	|
	|-RVA: 0x1D2BDA0 Offset: 0x1D2BEA1 VA: 0x1D2BDA0
	|-List.Enumerator<KeyValuePair<DateTime, object>>.Dispose
	|
	|-RVA: 0x1D2E0B0 Offset: 0x1D2E1B1 VA: 0x1D2E0B0
	|-List.Enumerator<KeyValuePair<Expression, Expression>>.Dispose
	|-List.Enumerator<KeyValuePair<object, object>>.Dispose
	|
	|-RVA: 0x1D2DB10 Offset: 0x1D2DC11 VA: 0x1D2DB10
	|-List.Enumerator<KeyValuePair<int, object>>.Dispose
	|
	|-RVA: 0x1D2DDE0 Offset: 0x1D2DEE1 VA: 0x1D2DDE0
	|-List.Enumerator<KeyValuePair<object, ValueTuple<int, DateTime, object>>>.Dispose
	|
	|-RVA: 0x2EB95E0 Offset: 0x2EB96E1 VA: 0x2EB95E0
	|-List.Enumerator<List<int>>.Dispose
	|-List.Enumerator<StructDataArrayList<ChartVariableData>>.Dispose
	|-List.Enumerator<StructDataArrayList<EncountEquipData>>.Dispose
	|-List.Enumerator<StructDataArrayList<JobIntroData>>.Dispose
	|-List.Enumerator<StructDataArrayList<LaterTalkData>>.Dispose
	|-List.Enumerator<string[]>.Dispose
	|-List.Enumerator<AccessoryData>.Dispose
	|-List.Enumerator<AchieveData>.Dispose
	|-List.Enumerator<AnimalData>.Dispose
	|-List.Enumerator<AnimationClip>.Dispose
	|-List.Enumerator<Animator>.Dispose
	|-List.Enumerator<AssetTable>.Dispose
	|-List.Enumerator<BaseConverter>.Dispose
	|-List.Enumerator<BasicMenu>.Dispose
	|-List.Enumerator<BasicMenuItem>.Dispose
	|-List.Enumerator<Behaviour>.Dispose
	|-List.Enumerator<BranchLabel>.Dispose
	|-List.Enumerator<BuildTimeScopeBlock>.Dispose
	|-List.Enumerator<ByRefUpdater>.Dispose
	|-List.Enumerator<CapsuleCollider>.Dispose
	|-List.Enumerator<ChallengeData>.Dispose
	|-List.Enumerator<ChapterData>.Dispose
	|-List.Enumerator<ChartVariableData>.Dispose
	|-List.Enumerator<Collider>.Dispose
	|-List.Enumerator<DataStoreMetaInfo>.Dispose
	|-List.Enumerator<DebugUIHandlerIndirectToggle>.Dispose
	|-List.Enumerator<DebugUIHandlerValue>.Dispose
	|-List.Enumerator<DebugUIPrefabBundle>.Dispose
	|-List.Enumerator<Decorator>.Dispose
	|-List.Enumerator<DisposData>.Dispose
	|-List.Enumerator<EffectData>.Dispose
	|-List.Enumerator<EncountEquipData>.Dispose
	|-List.Enumerator<EncountRareMonayData>.Dispose
	|-List.Enumerator<EncountUnitData>.Dispose
	|-List.Enumerator<EncountWeaponCategoryData>.Dispose
	|-List.Enumerator<EndRollData>.Dispose
	|-List.Enumerator<ExceptionDispatchInfo>.Dispose
	|-List.Enumerator<Expression>.Dispose
	|-List.Enumerator<FileData>.Dispose
	|-List.Enumerator<FoodstuffData>.Dispose
	|-List.Enumerator<ForceTextureSetter>.Dispose
	|-List.Enumerator<ForecastFishData>.Dispose
	|-List.Enumerator<FriendListData>.Dispose
	|-List.Enumerator<GUILayoutEntry>.Dispose
	|-List.Enumerator<GameObject>.Dispose
	|-List.Enumerator<GmapSpot>.Dispose
	|-List.Enumerator<GodBondHolder>.Dispose
	|-List.Enumerator<GodData>.Dispose
	|-List.Enumerator<GodGrowthData>.Dispose
	|-List.Enumerator<GodUnit>.Dispose
	|-List.Enumerator<GotoStatement>.Dispose
	|-List.Enumerator<HelpItemList>.Dispose
	|-List.Enumerator<HubAccess>.Dispose
	|-List.Enumerator<HubAccessData>.Dispose
	|-List.Enumerator<HubDisposData>.Dispose
	|-List.Enumerator<HubFacilityData>.Dispose
	|-List.Enumerator<HubInvestmentAnimal>.Dispose
	|-List.Enumerator<HubInvestmentFoodstuff>.Dispose
	|-List.Enumerator<HubMoveData>.Dispose
	|-List.Enumerator<HubMoveState>.Dispose
	|-List.Enumerator<HubNationData>.Dispose
	|-List.Enumerator<HubRandomSet>.Dispose
	|-List.Enumerator<IAsyncLocal>.Dispose
	|-List.Enumerator<IContextProperty>.Dispose
	|-List.Enumerator<IDisposable>.Dispose
	|-List.Enumerator<IOverloadableMemberDescriptor>.Dispose
	|-List.Enumerator<IPAddress>.Dispose
	|-List.Enumerator<IResourceLocation>.Dispose
	|-List.Enumerator<IUpdateReceiver>.Dispose
	|-List.Enumerator<IUserDataDescriptor>.Dispose
	|-List.Enumerator<Image>.Dispose
	|-List.Enumerator<Instruction>.Dispose
	|-List.Enumerator<IntegratedSubsystem>.Dispose
	|-List.Enumerator<IntegratedSubsystemDescriptor>.Dispose
	|-List.Enumerator<ItemData>.Dispose
	|-List.Enumerator<JobData>.Dispose
	|-List.Enumerator<JobIntroData>.Dispose
	|-List.Enumerator<KeyHelpData>.Dispose
	|-List.Enumerator<LabelScopeInfo>.Dispose
	|-List.Enumerator<LaterTalkData>.Dispose
	|-List.Enumerator<Light2D>.Dispose
	|-List.Enumerator<MagicSignal>.Dispose
	|-List.Enumerator<MapBackup>.Dispose
	|-List.Enumerator<MapImageCoreBit>.Dispose
	|-List.Enumerator<MapInfoRoot>.Dispose
	|-List.Enumerator<MapInspector>.Dispose
	|-List.Enumerator<MapObject>.Dispose
	|-List.Enumerator<MascotAccData>.Dispose
	|-List.Enumerator<MascotColorChangeItemContent>.Dispose
	|-List.Enumerator<Material>.Dispose
	|-List.Enumerator<MaterialPropertyBlock>.Dispose
	|-List.Enumerator<MenuItem>.Dispose
	|-List.Enumerator<MethodInfo>.Dispose
	|-List.Enumerator<ModifierSpec>.Dispose
	|-List.Enumerator<MovieDefineData>.Dispose
	|-List.Enumerator<MuscleExerciseScoreData>.Dispose
	|-List.Enumerator<MusclePushUpAreaData>.Dispose
	|-List.Enumerator<MusclePushUpSpeedData>.Dispose
	|-List.Enumerator<MuscleSitUpFallData>.Dispose
	|-List.Enumerator<Note>.Dispose
	|-List.Enumerator<NotificationEvent>.Dispose
	|-List.Enumerator<NotificationEventCB>.Dispose
	|-List.Enumerator<object>.Dispose
	|-List.Enumerator<PersistentCall>.Dispose
	|-List.Enumerator<Phase>.Dispose
	|-List.Enumerator<PhotographDisposInfo>.Dispose
	|-List.Enumerator<PhotographPauseData>.Dispose
	|-List.Enumerator<PlayReportSendBase>.Dispose
	|-List.Enumerator<PrefetchedSignal>.Dispose
	|-List.Enumerator<ProfileCard>.Dispose
	|-List.Enumerator<Ranking2RankData>.Dispose
	|-List.Enumerator<RankingRankData>.Dispose
	|-List.Enumerator<RectTransform>.Dispose
	|-List.Enumerator<RelayStampData>.Dispose
	|-List.Enumerator<RenderGraphPass>.Dispose
	|-List.Enumerator<Renderer>.Dispose
	|-List.Enumerator<ResourceHandle>.Dispose
	|-List.Enumerator<ResourceLocationData>.Dispose
	|-List.Enumerator<RewardData>.Dispose
	|-List.Enumerator<RingData>.Dispose
	|-List.Enumerator<RuntimeElement>.Dispose
	|-List.Enumerator<ScriptableObject>.Dispose
	|-List.Enumerator<ScriptableRendererFeature>.Dispose
	|-List.Enumerator<SkillData>.Dispose
	|-List.Enumerator<SourceCode>.Dispose
	|-List.Enumerator<SourceRef>.Dispose
	|-List.Enumerator<SpringBone>.Dispose
	|-List.Enumerator<Statement>.Dispose
	|-List.Enumerator<string>.Dispose
	|-List.Enumerator<Task>.Dispose
	|-List.Enumerator<TextMeshProUGUI>.Dispose
	|-List.Enumerator<Thread>.Dispose
	|-List.Enumerator<TimelineClip>.Dispose
	|-List.Enumerator<TipsData>.Dispose
	|-List.Enumerator<Transform>.Dispose
	|-List.Enumerator<TypeIdentifier>.Dispose
	|-List.Enumerator<Unit>.Dispose
	|-List.Enumerator<UnitActor>.Dispose
	|-List.Enumerator<UnitInfoCharaImageMaskOffset>.Dispose
	|-List.Enumerator<UnitRing>.Dispose
	|-List.Enumerator<ValueCountController>.Dispose
	|-List.Enumerator<VersusMapEditCategoryContent>.Dispose
	|-List.Enumerator<VersusServerCasualMetaData>.Dispose
	|-List.Enumerator<VersusServerRankedMetaData>.Dispose
	|-List.Enumerator<VersusServerReplayMetaData>.Dispose
	|-List.Enumerator<Volume>.Dispose
	|-List.Enumerator<VolumeComponent>.Dispose
	|-List.Enumerator<WatchItem>.Dispose
	|-List.Enumerator<WeaponMask>.Dispose
	|-List.Enumerator<X509CertificateImpl>.Dispose
	|-List.Enumerator<XRPass>.Dispose
	|-List.Enumerator<AddressablesImpl.ResourceLocatorInfo>.Dispose
	|-List.Enumerator<AdhocAssetLoader.Asset>.Dispose
	|-List.Enumerator<AssetTable.Accessory>.Dispose
	|-List.Enumerator<BufferedGizmo.Segment>.Dispose
	|-List.Enumerator<CasualMap.ObjectData>.Dispose
	|-List.Enumerator<ChapterRecord.Record>.Dispose
	|-List.Enumerator<CinemachineCollider.VcamExtraState>.Dispose
	|-List.Enumerator<ClassChange.ChangeJobData>.Dispose
	|-List.Enumerator<ClassChangeJobMenuItemContent.WeaponLevelItem>.Dispose
	|-List.Enumerator<CombatViewerSettings.ViewerPhase>.Dispose
	|-List.Enumerator<ConstantBuffer.ConstantBufferBase>.Dispose
	|-List.Enumerator<DLCManager.MountData>.Dispose
	|-List.Enumerator<DebugUI.Panel>.Dispose
	|-List.Enumerator<DishSelectFoodInfoContent.FoodstuffObject>.Dispose
	|-List.Enumerator<DishSelectMenu.DishSelectMenuItem>.Dispose
	|-List.Enumerator<DishSelectMenuCategoryContent.CategoryObject>.Dispose
	|-List.Enumerator<DragonRideTargetGroup.ChainSEManager>.Dispose
	|-List.Enumerator<DynamicsSetup.ParseMessage>.Dispose
	|-List.Enumerator<EmittersConstraint.Pair>.Dispose
	|-List.Enumerator<ExtensionMethodsRegistry.UnresolvedGenericMethod>.Dispose
	|-List.Enumerator<FoodstuffMenu.FoodstuffMenuItem>.Dispose
	|-List.Enumerator<GameSaveDataHeaderReader.Handle>.Dispose
	|-List.Enumerator<GameSound.Handle>.Dispose
	|-List.Enumerator<GrassData.SpriteInfo>.Dispose
	|-List.Enumerator<HelpManager.Item>.Dispose
	|-List.Enumerator<HubMiniMap.IconData>.Dispose
	|-List.Enumerator<HubMiniMapCaptureParam.CaptureParam1>.Dispose
	|-List.Enumerator<IfStatement.IfBlock>.Dispose
	|-List.Enumerator<MapBattleInfoSequence.AttackInfo>.Dispose
	|-List.Enumerator<MapDispos.ActualData>.Dispose
	|-List.Enumerator<MapDispos.Pos>.Dispose
	|-List.Enumerator<MapEditData.UnitInfo>.Dispose
	|-List.Enumerator<MapImageTerrain.MinimapInfo>.Dispose
	|-List.Enumerator<MapPrefab.Entity>.Dispose
	|-List.Enumerator<MapTarget.Data>.Dispose
	|-List.Enumerator<MapTerrain.LayerData>.Dispose
	|-List.Enumerator<MapTerrain.OverlapData>.Dispose
	|-List.Enumerator<MapTerrainInfoAlignment.AlignMember>.Dispose
	|-List.Enumerator<MapTerrainInfoAlignment.InversionMember>.Dispose
	|-List.Enumerator<Mess.ReloadFileInfo>.Dispose
	|-List.Enumerator<MonoChunkStream.Chunk>.Dispose
	|-List.Enumerator<MuscleSquatSequence.RandomPack>.Dispose
	|-List.Enumerator<PhotographTopSequence.UnitAccDataSet>.Dispose
	|-List.Enumerator<ResourceManager.InstanceOperation>.Dispose
	|-List.Enumerator<RingListSequence.GodPageData>.Dispose
	|-List.Enumerator<RingListSequence.PageData>.Dispose
	|-List.Enumerator<RingListSequence.RingPageData>.Dispose
	|-List.Enumerator<SkillStack.Packet>.Dispose
	|-List.Enumerator<SolanelInfoMenuContent.SolanelUnit>.Dispose
	|-List.Enumerator<SoundSystem.ResultSoundLoad>.Dispose
	|-List.Enumerator<SoundSystem.SoundHandle>.Dispose
	|-List.Enumerator<StructHeader.Param>.Dispose
	|-List.Enumerator<TitleSequence.PedestalData>.Dispose
	|-List.Enumerator<UnitSelectMenu.UnitSelectMenuItem>.Dispose
	|-List.Enumerator<UnitStatusSetter.CapabilityValueParam>.Dispose
	|-List.Enumerator<UnitStatusSetter.SkillSetter>.Dispose
	|-List.Enumerator<UnitStatusSetter.WeaponLevelSetter>.Dispose
	|-List.Enumerator<EventDemoSequence.SoundEnv.EventNameData>.Dispose
	|-List.Enumerator<SoundWwise.SoundBankManager.BankHandle>.Dispose
	|-List.Enumerator<TitleSequence.ProcTitleCall.TitleCallData>.Dispose
	|-List.Enumerator<VersusSequence.VersusSequenceLocal.MetaDataPack>.Dispose
	|
	|-RVA: 0x1D2F0F0 Offset: 0x1D2F1F1 VA: 0x1D2F0F0
	|-List.Enumerator<CommonBattleSequence.Reliance<object>>.Dispose
	|
	|-RVA: 0x2EAE860 Offset: 0x2EAE961 VA: 0x2EAE860
	|-List.Enumerator<RenderGraphResourcePool.ResourceLogInfo<object>>.Dispose
	|
	|-RVA: 0x2EAF210 Offset: 0x2EAF311 VA: 0x2EAF210
	|-List.Enumerator<ValueTuple<int, object>>.Dispose
	|
	|-RVA: 0x2EAF4E0 Offset: 0x2EAF5E1 VA: 0x2EAF4E0
	|-List.Enumerator<ValueTuple<Int32Enum, int>>.Dispose
	|
	|-RVA: 0x2EAF790 Offset: 0x2EAF891 VA: 0x2EAF790
	|-List.Enumerator<ValueTuple<object, ValueTuple<object, int>>>.Dispose
	|-List.Enumerator<ValueTuple<object, ValueTuple<Type, int>>>.Dispose
	|
	|-RVA: 0x2EAFD70 Offset: 0x2EAFE71 VA: 0x2EAFD70
	|-List.Enumerator<ValueTuple<object, int>>.Dispose
	|
	|-RVA: 0x2EB07C0 Offset: 0x2EB08C1 VA: 0x2EB07C0
	|-List.Enumerator<ValueTuple<Vector3, float>>.Dispose
	|
	|-RVA: 0x2EB0A60 Offset: 0x2EB0B61 VA: 0x2EB0A60
	|-List.Enumerator<ValueTuple<object, Int32Enum, int>>.Dispose
	|
	|-RVA: 0x2EB11A0 Offset: 0x2EB12A1 VA: 0x2EB11A0
	|-List.Enumerator<ValueTuple<object, int, int, int>>.Dispose
	|
	|-RVA: 0x2EB1470 Offset: 0x2EB1571 VA: 0x2EB1470
	|-List.Enumerator<AnimatorClipInfo>.Dispose
	|
	|-RVA: 0x2EB1E90 Offset: 0x2EB1F91 VA: 0x2EB1E90
	|-List.Enumerator<AsyncOperationHandle>.Dispose
	|
	|-RVA: 0x2EB2610 Offset: 0x2EB2711 VA: 0x2EB2610
	|-List.Enumerator<BoneWeight>.Dispose
	|
	|-RVA: 0x2EB29D0 Offset: 0x2EB2AD1 VA: 0x2EB29D0
	|-List.Enumerator<bool>.Dispose
	|
	|-RVA: 0x2EB2C80 Offset: 0x2EB2D81 VA: 0x2EB2C80
	|-List.Enumerator<byte>.Dispose
	|
	|-RVA: 0x2EB3030 Offset: 0x2EB3131 VA: 0x2EB3030
	|-List.Enumerator<CameraInfo>.Dispose
	|
	|-RVA: 0x2EB3300 Offset: 0x2EB3401 VA: 0x2EB3300
	|-List.Enumerator<char>.Dispose
	|
	|-RVA: 0x2EB35B0 Offset: 0x2EB36B1 VA: 0x2EB35B0
	|-List.Enumerator<Color>.Dispose
	|
	|-RVA: 0x2EB3B90 Offset: 0x2EB3C91 VA: 0x2EB3B90
	|-List.Enumerator<Color32>.Dispose
	|
	|-RVA: 0x2EB3E40 Offset: 0x2EB3F41 VA: 0x2EB3E40
	|-List.Enumerator<ConstraintSource>.Dispose
	|
	|-RVA: 0x2EB4110 Offset: 0x2EB4211 VA: 0x2EB4110
	|-List.Enumerator<ContourVertex>.Dispose
	|
	|-RVA: 0x2EB43E0 Offset: 0x2EB44E1 VA: 0x2EB43E0
	|-List.Enumerator<DataStoreRatingInfo>.Dispose
	|
	|-RVA: 0x2EB46A0 Offset: 0x2EB47A1 VA: 0x2EB46A0
	|-List.Enumerator<DataStoreResult>.Dispose
	|
	|-RVA: 0x2EB4950 Offset: 0x2EB4A51 VA: 0x2EB4950
	|-List.Enumerator<DateTime>.Dispose
	|
	|-RVA: 0x2EB4C00 Offset: 0x2EB4D01 VA: 0x2EB4C00
	|-List.Enumerator<DateTimeOffset>.Dispose
	|
	|-RVA: 0x2EB4EC0 Offset: 0x2EB4FC1 VA: 0x2EB4EC0
	|-List.Enumerator<Decimal>.Dispose
	|
	|-RVA: 0x2EB5180 Offset: 0x2EB5281 VA: 0x2EB5180
	|-List.Enumerator<DiagnosticEvent>.Dispose
	|
	|-RVA: 0x2EB5450 Offset: 0x2EB5551 VA: 0x2EB5450
	|-List.Enumerator<double>.Dispose
	|
	|-RVA: 0x2EB5700 Offset: 0x2EB5801 VA: 0x2EB5700
	|-List.Enumerator<Friend>.Dispose
	|
	|-RVA: 0x2EB59C0 Offset: 0x2EB5AC1 VA: 0x2EB59C0
	|-List.Enumerator<GlyphRect>.Dispose
	|
	|-RVA: 0x2EB5C80 Offset: 0x2EB5D81 VA: 0x2EB5C80
	|-List.Enumerator<short>.Dispose
	|
	|-RVA: 0x2EB6220 Offset: 0x2EB6321 VA: 0x2EB6220
	|-List.Enumerator<int>.Dispose
	|
	|-RVA: 0x2EB6F10 Offset: 0x2EB7011 VA: 0x2EB6F10
	|-List.Enumerator<Int32Enum>.Dispose
	|-List.Enumerator<MapPanelActive.MeshIndex>.Dispose
	|
	|-RVA: 0x2EB75E0 Offset: 0x2EB76E1 VA: 0x2EB75E0
	|-List.Enumerator<long>.Dispose
	|
	|-RVA: 0x2EB7890 Offset: 0x2EB7991 VA: 0x2EB7890
	|-List.Enumerator<IntPtr>.Dispose
	|
	|-RVA: 0x2EB7B40 Offset: 0x2EB7C41 VA: 0x2EB7B40
	|-List.Enumerator<InterpretedFrameInfo>.Dispose
	|
	|-RVA: 0x2EB7E10 Offset: 0x2EB7F11 VA: 0x2EB7E10
	|-List.Enumerator<IntervalTreeNode>.Dispose
	|
	|-RVA: 0x2EB81E0 Offset: 0x2EB82E1 VA: 0x2EB81E0
	|-List.Enumerator<LengthLimitProperties>.Dispose
	|
	|-RVA: 0x2EB89C0 Offset: 0x2EB8AC1 VA: 0x2EB89C0
	|-List.Enumerator<MapPos>.Dispose
	|
	|-RVA: 0x2EB8C80 Offset: 0x2EB8D81 VA: 0x2EB8C80
	|-List.Enumerator<Matrix4x4>.Dispose
	|
	|-RVA: 0x2EBAD40 Offset: 0x2EBAE41 VA: 0x2EBAD40
	|-List.Enumerator<ObjectInitializationData>.Dispose
	|
	|-RVA: 0x2EBB130 Offset: 0x2EBB231 VA: 0x2EBB130
	|-List.Enumerator<PlayableBinding>.Dispose
	|
	|-RVA: 0x2EBB400 Offset: 0x2EBB501 VA: 0x2EBB400
	|-List.Enumerator<PlayerLoopSystem>.Dispose
	|
	|-RVA: 0x2EBB6D0 Offset: 0x2EBB7D1 VA: 0x2EBB6D0
	|-List.Enumerator<PlayerLoopSystemInternal>.Dispose
	|
	|-RVA: 0x2EBBE10 Offset: 0x2EBBF11 VA: 0x2EBBE10
	|-List.Enumerator<RangePositionInfo>.Dispose
	|
	|-RVA: 0x2EBC0E0 Offset: 0x2EBC1E1 VA: 0x2EBC0E0
	|-List.Enumerator<Ranking2ChartInfoInput>.Dispose
	|
	|-RVA: 0x2EBC390 Offset: 0x2EBC491 VA: 0x2EBC390
	|-List.Enumerator<RaycastHit2D>.Dispose
	|
	|-RVA: 0x2EBC680 Offset: 0x2EBC781 VA: 0x2EBC680
	|-List.Enumerator<RaycastResult>.Dispose
	|
	|-RVA: 0x2EBC9A0 Offset: 0x2EBCAA1 VA: 0x2EBC9A0
	|-List.Enumerator<Rect>.Dispose
	|
	|-RVA: 0x2EBCDA0 Offset: 0x2EBCEA1 VA: 0x2EBCDA0
	|-List.Enumerator<RendererListHandle>.Dispose
	|
	|-RVA: 0x2EBD050 Offset: 0x2EBD151 VA: 0x2EBD050
	|-List.Enumerator<ResourceHandle>.Dispose
	|
	|-RVA: 0x2EBD300 Offset: 0x2EBD401 VA: 0x2EBD300
	|-List.Enumerator<sbyte>.Dispose
	|
	|-RVA: 0x2EBD5B0 Offset: 0x2EBD6B1 VA: 0x2EBD5B0
	|-List.Enumerator<ShaderTagId>.Dispose
	|
	|-RVA: 0x2EBD960 Offset: 0x2EBDA61 VA: 0x2EBD960
	|-List.Enumerator<float>.Dispose
	|
	|-RVA: 0x2EBDF50 Offset: 0x2EBE051 VA: 0x2EBDF50
	|-List.Enumerator<SphericalHarmonicsL2>.Dispose
	|
	|-RVA: 0x2EBE9E0 Offset: 0x2EBEAE1 VA: 0x2EBE9E0
	|-List.Enumerator<SubMeshDescriptor>.Dispose
	|
	|-RVA: 0x2EBF0D0 Offset: 0x2EBF1D1 VA: 0x2EBF0D0
	|-List.Enumerator<TablePair>.Dispose
	|
	|-RVA: 0x2E02AB0 Offset: 0x2E02BB1 VA: 0x2E02AB0
	|-List.Enumerator<TimeSpan>.Dispose
	|
	|-RVA: 0x2E02D60 Offset: 0x2E02E61 VA: 0x2E02D60
	|-List.Enumerator<UICharInfo>.Dispose
	|
	|-RVA: 0x2E03010 Offset: 0x2E03111 VA: 0x2E03010
	|-List.Enumerator<UILineInfo>.Dispose
	|
	|-RVA: 0x2E032F0 Offset: 0x2E033F1 VA: 0x2E032F0
	|-List.Enumerator<UIVertex>.Dispose
	|
	|-RVA: 0x2E03640 Offset: 0x2E03741 VA: 0x2E03640
	|-List.Enumerator<ushort>.Dispose
	|
	|-RVA: 0x2E03CE0 Offset: 0x2E03DE1 VA: 0x2E03CE0
	|-List.Enumerator<uint>.Dispose
	|
	|-RVA: 0x2E04690 Offset: 0x2E04791 VA: 0x2E04690
	|-List.Enumerator<ulong>.Dispose
	|
	|-RVA: 0x2E04940 Offset: 0x2E04A41 VA: 0x2E04940
	|-List.Enumerator<Vector2>.Dispose
	|
	|-RVA: 0x2E04EB0 Offset: 0x2E04FB1 VA: 0x2E04EB0
	|-List.Enumerator<Vector3>.Dispose
	|
	|-RVA: 0x2E05430 Offset: 0x2E05531 VA: 0x2E05430
	|-List.Enumerator<Vector4>.Dispose
	|
	|-RVA: 0x2E056D0 Offset: 0x2E057D1 VA: 0x2E056D0
	|-List.Enumerator<VertexAttributeDescriptor>.Dispose
	|
	|-RVA: 0x2E05C00 Offset: 0x2E05D01 VA: 0x2E05C00
	|-List.Enumerator<X509ChainStatus>.Dispose
	|
	|-RVA: 0x2E05EF0 Offset: 0x2E05FF1 VA: 0x2E05EF0
	|-List.Enumerator<XRView>.Dispose
	|
	|-RVA: 0x2E06580 Offset: 0x2E06681 VA: 0x2E06580
	|-List.Enumerator<AmiiboSequence.GainItemData>.Dispose
	|
	|-RVA: 0x2E06850 Offset: 0x2E06951 VA: 0x2E06850
	|-List.Enumerator<AnimationOutputWeightProcessor.WeightInfo>.Dispose
	|
	|-RVA: 0x2E06B10 Offset: 0x2E06C11 VA: 0x2E06B10
	|-List.Enumerator<ArenaOrderSequence.GodInfo>.Dispose
	|
	|-RVA: 0x2E06DE0 Offset: 0x2E06EE1 VA: 0x2E06DE0
	|-List.Enumerator<BattleInfo.SupportData>.Dispose
	|
	|-RVA: 0x2E070B0 Offset: 0x2E071B1 VA: 0x2E070B0
	|-List.Enumerator<BeforeRenderHelper.OrderBlock>.Dispose
	|
	|-RVA: 0x2E07380 Offset: 0x2E07481 VA: 0x2E07380
	|-List.Enumerator<Camera.RenderRequest>.Dispose
	|
	|-RVA: 0x2E07650 Offset: 0x2E07751 VA: 0x2E07650
	|-List.Enumerator<CameraState.CustomBlendable>.Dispose
	|
	|-RVA: 0x2E07920 Offset: 0x2E07A21 VA: 0x2E07920
	|-List.Enumerator<CinemachineClearShot.Pair>.Dispose
	|
	|-RVA: 0x2E07BD0 Offset: 0x2E07CD1 VA: 0x2E07BD0
	|-List.Enumerator<CinemachineStateDrivenCamera.HashPair>.Dispose
	|
	|-RVA: 0x2E08410 Offset: 0x2E08511 VA: 0x2E08410
	|-List.Enumerator<DelayedActionManager.DelegateInfo>.Dispose
	|
	|-RVA: 0x2E086E0 Offset: 0x2E087E1 VA: 0x2E086E0
	|-List.Enumerator<Detail.AsyncResultInt>.Dispose
	|
	|-RVA: 0x2E089A0 Offset: 0x2E08AA1 VA: 0x2E089A0
	|-List.Enumerator<Detail.CppArray>.Dispose
	|
	|-RVA: 0x2E08C60 Offset: 0x2E08D61 VA: 0x2E08C60
	|-List.Enumerator<Detail.NotificationEventInt>.Dispose
	|
	|-RVA: 0x2E08F20 Offset: 0x2E09021 VA: 0x2E08F20
	|-List.Enumerator<DragonRideTargetGroup.ChainParam>.Dispose
	|
	|-RVA: 0x2E09510 Offset: 0x2E09611 VA: 0x2E09510
	|-List.Enumerator<GmapPathAdjuster.TargetModel>.Dispose
	|
	|-RVA: 0x2E097E0 Offset: 0x2E098E1 VA: 0x2E097E0
	|-List.Enumerator<GmapSpotAdjuster.TargetModel>.Dispose
	|
	|-RVA: 0x2E09AB0 Offset: 0x2E09BB1 VA: 0x2E09AB0
	|-List.Enumerator<HubFastTravel.Location>.Dispose
	|
	|-RVA: 0x2E09D80 Offset: 0x2E09E81 VA: 0x2E09D80
	|-List.Enumerator<HubLensFlare.Flare>.Dispose
	|
	|-RVA: 0x2E0A050 Offset: 0x2E0A151 VA: 0x2E0A050
	|-List.Enumerator<InventoryPoolItemMenuContent.KindBgNameClass>.Dispose
	|
	|-RVA: 0x2E0A590 Offset: 0x2E0A691 VA: 0x2E0A590
	|-List.Enumerator<Map.Pos>.Dispose
	|
	|-RVA: 0x2E0A840 Offset: 0x2E0A941 VA: 0x2E0A840
	|-List.Enumerator<MapImage.BackupTerrain>.Dispose
	|
	|-RVA: 0x2E0AB00 Offset: 0x2E0AC01 VA: 0x2E0AB00
	|-List.Enumerator<MapImageRange.Pos>.Dispose
	|
	|-RVA: 0x2E0B160 Offset: 0x2E0B261 VA: 0x2E0B160
	|-List.Enumerator<MapMind.Target>.Dispose
	|
	|-RVA: 0x2E0B430 Offset: 0x2E0B531 VA: 0x2E0B430
	|-List.Enumerator<MapPanelDebug.Entity>.Dispose
	|
	|-RVA: 0x2E0B6F0 Offset: 0x2E0B7F1 VA: 0x2E0B6F0
	|-List.Enumerator<NexRanking.Data>.Dispose
	|
	|-RVA: 0x2E0B9A0 Offset: 0x2E0BAA1 VA: 0x2E0B9A0
	|-List.Enumerator<NexVersus.RatingData>.Dispose
	|
	|-RVA: 0x2E0BC60 Offset: 0x2E0BD61 VA: 0x2E0BC60
	|-List.Enumerator<PackedPlayModeBuildLogs.RuntimeBuildLog>.Dispose
	|
	|-RVA: 0x2E0BF50 Offset: 0x2E0C051 VA: 0x2E0BF50
	|-List.Enumerator<ParticleSystem.Particle>.Dispose
	|
	|-RVA: 0x2E0C710 Offset: 0x2E0C811 VA: 0x2E0C710
	|-List.Enumerator<RangeData.Offset>.Dispose
	|
	|-RVA: 0x2E0C9C0 Offset: 0x2E0CAC1 VA: 0x2E0C9C0
	|-List.Enumerator<RenderGraphDebugData.PassDebugData>.Dispose
	|
	|-RVA: 0x2E0CC90 Offset: 0x2E0CD91 VA: 0x2E0CC90
	|-List.Enumerator<RenderGraphDebugData.ResourceDebugData>.Dispose
	|
	|-RVA: 0x2E0CF60 Offset: 0x2E0D061 VA: 0x2E0CF60
	|-List.Enumerator<RingCleaningUnitSelectMenu.GodParam>.Dispose
	|
	|-RVA: 0x2E0D830 Offset: 0x2E0D931 VA: 0x2E0D830
	|-List.Enumerator<ShadowUtility.Edge>.Dispose
	|
	|-RVA: 0x2E0DF30 Offset: 0x2E0E031 VA: 0x2E0DF30
	|-List.Enumerator<SkillArray.Entity>.Dispose
	|
	|-RVA: 0x2E0E560 Offset: 0x2E0E661 VA: 0x2E0E560
	|-List.Enumerator<TexturePacker_JsonArray.Frame>.Dispose
	|
	|-RVA: 0x2E0E850 Offset: 0x2E0E951 VA: 0x2E0E850
	|-List.Enumerator<TimeNotificationBehaviour.NotificationEntry>.Dispose
	|
	|-RVA: 0x2E0EB20 Offset: 0x2E0EC21 VA: 0x2E0EB20
	|-List.Enumerator<UnitySynchronizationContext.WorkRequest>.Dispose
	|
	|-RVA: 0x2E0EDF0 Offset: 0x2E0EEF1 VA: 0x2E0EDF0
	|-List.Enumerator<XmlSchemaObjectTable.XmlSchemaObjectEntry>.Dispose
	|
	|-RVA: 0x2E0F0C0 Offset: 0x2E0F1C1 VA: 0x2E0F0C0
	|-List.Enumerator<AssetBundleBuildMap.AssetBundleEntry.AssetPathString>.Dispose
	|
	|-RVA: 0x2E0F3D0 Offset: 0x2E0F4D1 VA: 0x2E0F3D0
	|-List.Enumerator<Detail.DataStore.DataStoreChangeMetaParamInt>.Dispose
	|
	|-RVA: 0x2E0F720 Offset: 0x2E0F821 VA: 0x2E0F720
	|-List.Enumerator<Detail.DataStore.DataStoreDeleteParamInt>.Dispose
	|
	|-RVA: 0x2E0F9E0 Offset: 0x2E0FAE1 VA: 0x2E0F9E0
	|-List.Enumerator<Detail.DataStore.DataStoreGetMetaParamInt>.Dispose
	|
	|-RVA: 0x2E0FCC0 Offset: 0x2E0FDC1 VA: 0x2E0FCC0
	|-List.Enumerator<Detail.DataStore.DataStoreMetaInfoInt>.Dispose
	|
	|-RVA: 0x2E0FFE0 Offset: 0x2E100E1 VA: 0x2E0FFE0
	|-List.Enumerator<Detail.DataStore.DataStorePasswordInfoInt>.Dispose
	|
	|-RVA: 0x2E102A0 Offset: 0x2E103A1 VA: 0x2E102A0
	|-List.Enumerator<Detail.DataStore.DataStorePersistenceInfoInt>.Dispose
	|
	|-RVA: 0x2E10580 Offset: 0x2E10681 VA: 0x2E10580
	|-List.Enumerator<Detail.DataStore.DataStorePreparePostParamInt>.Dispose
	|
	|-RVA: 0x2E10890 Offset: 0x2E10991 VA: 0x2E10890
	|-List.Enumerator<Detail.DataStore.DataStoreRateObjectParamInt>.Dispose
	|
	|-RVA: 0x2E10B50 Offset: 0x2E10C51 VA: 0x2E10B50
	|-List.Enumerator<Detail.DataStore.DataStoreRatingInitParamInt>.Dispose
	|
	|-RVA: 0x2E10E10 Offset: 0x2E10F11 VA: 0x2E10E10
	|-List.Enumerator<Detail.DataStore.DataStoreRatingTargetInt>.Dispose
	|
	|-RVA: 0x2E110E0 Offset: 0x2E111E1 VA: 0x2E110E0
	|-List.Enumerator<Detail.Ranking.RankingCachedResultInt>.Dispose
	|
	|-RVA: 0x2E113C0 Offset: 0x2E114C1 VA: 0x2E113C0
	|-List.Enumerator<Detail.Ranking.RankingOrderParamInt>.Dispose
	|
	|-RVA: 0x2E11690 Offset: 0x2E11791 VA: 0x2E11690
	|-List.Enumerator<Detail.Ranking.RankingRankDataInt>.Dispose
	|
	|-RVA: 0x2E11980 Offset: 0x2E11A81 VA: 0x2E11980
	|-List.Enumerator<Detail.Ranking2.Ranking2ChartInfoInt>.Dispose
	|
	|-RVA: 0x2E11CC0 Offset: 0x2E11DC1 VA: 0x2E11CC0
	|-List.Enumerator<Detail.Ranking2.Ranking2RankDataInt>.Dispose
	|
	|-RVA: 0x2E11FA0 Offset: 0x2E120A1 VA: 0x2E11FA0
	|-List.Enumerator<Detail.Ranking2.Ranking2ScoreDataInt>.Dispose
	|
	|-RVA: 0x2E12260 Offset: 0x2E12361 VA: 0x2E12260
	|-List.Enumerator<Detail.Screening.ScreeningContextInfoInt>.Dispose
	|
	|-RVA: 0x2E12530 Offset: 0x2E12631 VA: 0x2E12530
	|-List.Enumerator<Detail.Subscriber.SubscriberContentInt>.Dispose
	|
	|-RVA: 0x2E12830 Offset: 0x2E12931 VA: 0x2E12830
	|-List.Enumerator<Detail.Subscriber.SubscriberGetContentParamInt>.Dispose
	|
	|-RVA: 0x2E12AF0 Offset: 0x2E12BF1 VA: 0x2E12AF0
	|-List.Enumerator<Detail.Subscriber.SubscriberUserStatusInfoInt>.Dispose
	|
	|-RVA: 0x2E12DB0 Offset: 0x2E12EB1 VA: 0x2E12DB0
	|-List.Enumerator<Detail.Subscriber.SubscriberUserStatusParamInt>.Dispose
	|
	|-RVA: 0x2E13070 Offset: 0x2E13171 VA: 0x2E13070
	|-List.Enumerator<Detail.Utility.IntegerSettings>.Dispose
	|
	|-RVA: 0x2E13320 Offset: 0x2E13421 VA: 0x2E13320
	|-List.Enumerator<Detail.Utility.UniqueIdInfoInt>.Dispose
	|
	|-RVA: 0x3499280 Offset: 0x3499381 VA: 0x3499280
	|-List.Enumerator<MapHistory.Rewind.LatestInspectorData>.Dispose
	|
	|-RVA: 0x3499520 Offset: 0x3499621 VA: 0x3499520
	|-List.Enumerator<MapHistory.Rewind.WorkTerrainData>.Dispose
	|
	|-RVA: 0x34997C0 Offset: 0x34998C1 VA: 0x34997C0
	|-List.Enumerator<MapSkill.AroundCalculator.Result>.Dispose
	|
	|-RVA: 0x3499A90 Offset: 0x3499B91 VA: 0x3499A90
	|-List.Enumerator<TargetPositionCache.CacheCurve.Item>.Dispose
	|
	|-RVA: 0x3499D60 Offset: 0x3499E61 VA: 0x3499D60
	|-List.Enumerator<TargetPositionCache.CacheEntry.RecordingItem>.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1D2BAE0 Offset: 0x1D2BBE1 VA: 0x1D2BAE0
	|-List.Enumerator<IntervalTree.Entry<object>>.MoveNext
	|
	|-RVA: 0x1D2BDB0 Offset: 0x1D2BEB1 VA: 0x1D2BDB0
	|-List.Enumerator<KeyValuePair<DateTime, object>>.MoveNext
	|
	|-RVA: 0x1D2E0C0 Offset: 0x1D2E1C1 VA: 0x1D2E0C0
	|-List.Enumerator<KeyValuePair<Expression, Expression>>.MoveNext
	|-List.Enumerator<KeyValuePair<object, object>>.MoveNext
	|
	|-RVA: 0x1D2DB20 Offset: 0x1D2DC21 VA: 0x1D2DB20
	|-List.Enumerator<KeyValuePair<int, object>>.MoveNext
	|
	|-RVA: 0x1D2DDF0 Offset: 0x1D2DEF1 VA: 0x1D2DDF0
	|-List.Enumerator<KeyValuePair<object, ValueTuple<int, DateTime, object>>>.MoveNext
	|
	|-RVA: 0x2EB95F0 Offset: 0x2EB96F1 VA: 0x2EB95F0
	|-List.Enumerator<List<int>>.MoveNext
	|-List.Enumerator<StructDataArrayList<ChartVariableData>>.MoveNext
	|-List.Enumerator<StructDataArrayList<EncountEquipData>>.MoveNext
	|-List.Enumerator<StructDataArrayList<JobIntroData>>.MoveNext
	|-List.Enumerator<StructDataArrayList<LaterTalkData>>.MoveNext
	|-List.Enumerator<string[]>.MoveNext
	|-List.Enumerator<AccessoryData>.MoveNext
	|-List.Enumerator<AchieveData>.MoveNext
	|-List.Enumerator<AnimalData>.MoveNext
	|-List.Enumerator<AnimationClip>.MoveNext
	|-List.Enumerator<Animator>.MoveNext
	|-List.Enumerator<AssetTable>.MoveNext
	|-List.Enumerator<BaseConverter>.MoveNext
	|-List.Enumerator<BasicMenu>.MoveNext
	|-List.Enumerator<BasicMenuItem>.MoveNext
	|-List.Enumerator<Behaviour>.MoveNext
	|-List.Enumerator<BranchLabel>.MoveNext
	|-List.Enumerator<BuildTimeScopeBlock>.MoveNext
	|-List.Enumerator<ByRefUpdater>.MoveNext
	|-List.Enumerator<CapsuleCollider>.MoveNext
	|-List.Enumerator<ChallengeData>.MoveNext
	|-List.Enumerator<ChapterData>.MoveNext
	|-List.Enumerator<ChartVariableData>.MoveNext
	|-List.Enumerator<Collider>.MoveNext
	|-List.Enumerator<DataStoreMetaInfo>.MoveNext
	|-List.Enumerator<DebugUIHandlerIndirectToggle>.MoveNext
	|-List.Enumerator<DebugUIHandlerValue>.MoveNext
	|-List.Enumerator<DebugUIPrefabBundle>.MoveNext
	|-List.Enumerator<Decorator>.MoveNext
	|-List.Enumerator<DisposData>.MoveNext
	|-List.Enumerator<EffectData>.MoveNext
	|-List.Enumerator<EncountEquipData>.MoveNext
	|-List.Enumerator<EncountRareMonayData>.MoveNext
	|-List.Enumerator<EncountUnitData>.MoveNext
	|-List.Enumerator<EncountWeaponCategoryData>.MoveNext
	|-List.Enumerator<EndRollData>.MoveNext
	|-List.Enumerator<ExceptionDispatchInfo>.MoveNext
	|-List.Enumerator<Expression>.MoveNext
	|-List.Enumerator<FileData>.MoveNext
	|-List.Enumerator<FoodstuffData>.MoveNext
	|-List.Enumerator<ForceTextureSetter>.MoveNext
	|-List.Enumerator<ForecastFishData>.MoveNext
	|-List.Enumerator<FriendListData>.MoveNext
	|-List.Enumerator<GUILayoutEntry>.MoveNext
	|-List.Enumerator<GameObject>.MoveNext
	|-List.Enumerator<GmapSpot>.MoveNext
	|-List.Enumerator<GodBondHolder>.MoveNext
	|-List.Enumerator<GodData>.MoveNext
	|-List.Enumerator<GodGrowthData>.MoveNext
	|-List.Enumerator<GodUnit>.MoveNext
	|-List.Enumerator<GotoStatement>.MoveNext
	|-List.Enumerator<HelpItemList>.MoveNext
	|-List.Enumerator<HubAccess>.MoveNext
	|-List.Enumerator<HubAccessData>.MoveNext
	|-List.Enumerator<HubDisposData>.MoveNext
	|-List.Enumerator<HubFacilityData>.MoveNext
	|-List.Enumerator<HubInvestmentAnimal>.MoveNext
	|-List.Enumerator<HubInvestmentFoodstuff>.MoveNext
	|-List.Enumerator<HubMoveData>.MoveNext
	|-List.Enumerator<HubMoveState>.MoveNext
	|-List.Enumerator<HubNationData>.MoveNext
	|-List.Enumerator<HubRandomSet>.MoveNext
	|-List.Enumerator<IAsyncLocal>.MoveNext
	|-List.Enumerator<IContextProperty>.MoveNext
	|-List.Enumerator<IDisposable>.MoveNext
	|-List.Enumerator<IOverloadableMemberDescriptor>.MoveNext
	|-List.Enumerator<IPAddress>.MoveNext
	|-List.Enumerator<IResourceLocation>.MoveNext
	|-List.Enumerator<IUpdateReceiver>.MoveNext
	|-List.Enumerator<IUserDataDescriptor>.MoveNext
	|-List.Enumerator<Image>.MoveNext
	|-List.Enumerator<Instruction>.MoveNext
	|-List.Enumerator<IntegratedSubsystem>.MoveNext
	|-List.Enumerator<IntegratedSubsystemDescriptor>.MoveNext
	|-List.Enumerator<ItemData>.MoveNext
	|-List.Enumerator<JobData>.MoveNext
	|-List.Enumerator<JobIntroData>.MoveNext
	|-List.Enumerator<KeyHelpData>.MoveNext
	|-List.Enumerator<LabelScopeInfo>.MoveNext
	|-List.Enumerator<LaterTalkData>.MoveNext
	|-List.Enumerator<Light2D>.MoveNext
	|-List.Enumerator<MagicSignal>.MoveNext
	|-List.Enumerator<MapBackup>.MoveNext
	|-List.Enumerator<MapImageCoreBit>.MoveNext
	|-List.Enumerator<MapInfoRoot>.MoveNext
	|-List.Enumerator<MapInspector>.MoveNext
	|-List.Enumerator<MapObject>.MoveNext
	|-List.Enumerator<MascotAccData>.MoveNext
	|-List.Enumerator<MascotColorChangeItemContent>.MoveNext
	|-List.Enumerator<Material>.MoveNext
	|-List.Enumerator<MaterialPropertyBlock>.MoveNext
	|-List.Enumerator<MenuItem>.MoveNext
	|-List.Enumerator<MethodInfo>.MoveNext
	|-List.Enumerator<ModifierSpec>.MoveNext
	|-List.Enumerator<MovieDefineData>.MoveNext
	|-List.Enumerator<MuscleExerciseScoreData>.MoveNext
	|-List.Enumerator<MusclePushUpAreaData>.MoveNext
	|-List.Enumerator<MusclePushUpSpeedData>.MoveNext
	|-List.Enumerator<MuscleSitUpFallData>.MoveNext
	|-List.Enumerator<Note>.MoveNext
	|-List.Enumerator<NotificationEvent>.MoveNext
	|-List.Enumerator<NotificationEventCB>.MoveNext
	|-List.Enumerator<object>.MoveNext
	|-List.Enumerator<PersistentCall>.MoveNext
	|-List.Enumerator<Phase>.MoveNext
	|-List.Enumerator<PhotographDisposInfo>.MoveNext
	|-List.Enumerator<PhotographPauseData>.MoveNext
	|-List.Enumerator<PlayReportSendBase>.MoveNext
	|-List.Enumerator<PrefetchedSignal>.MoveNext
	|-List.Enumerator<ProfileCard>.MoveNext
	|-List.Enumerator<Ranking2RankData>.MoveNext
	|-List.Enumerator<RankingRankData>.MoveNext
	|-List.Enumerator<RectTransform>.MoveNext
	|-List.Enumerator<RelayStampData>.MoveNext
	|-List.Enumerator<RenderGraphPass>.MoveNext
	|-List.Enumerator<Renderer>.MoveNext
	|-List.Enumerator<ResourceHandle>.MoveNext
	|-List.Enumerator<ResourceLocationData>.MoveNext
	|-List.Enumerator<RewardData>.MoveNext
	|-List.Enumerator<RingData>.MoveNext
	|-List.Enumerator<RuntimeElement>.MoveNext
	|-List.Enumerator<ScriptableObject>.MoveNext
	|-List.Enumerator<ScriptableRendererFeature>.MoveNext
	|-List.Enumerator<SkillData>.MoveNext
	|-List.Enumerator<SourceCode>.MoveNext
	|-List.Enumerator<SourceRef>.MoveNext
	|-List.Enumerator<SpringBone>.MoveNext
	|-List.Enumerator<Statement>.MoveNext
	|-List.Enumerator<string>.MoveNext
	|-List.Enumerator<Task>.MoveNext
	|-List.Enumerator<TextMeshProUGUI>.MoveNext
	|-List.Enumerator<Thread>.MoveNext
	|-List.Enumerator<TimelineClip>.MoveNext
	|-List.Enumerator<TipsData>.MoveNext
	|-List.Enumerator<Transform>.MoveNext
	|-List.Enumerator<TypeIdentifier>.MoveNext
	|-List.Enumerator<Unit>.MoveNext
	|-List.Enumerator<UnitActor>.MoveNext
	|-List.Enumerator<UnitInfoCharaImageMaskOffset>.MoveNext
	|-List.Enumerator<UnitRing>.MoveNext
	|-List.Enumerator<ValueCountController>.MoveNext
	|-List.Enumerator<VersusMapEditCategoryContent>.MoveNext
	|-List.Enumerator<VersusServerCasualMetaData>.MoveNext
	|-List.Enumerator<VersusServerRankedMetaData>.MoveNext
	|-List.Enumerator<VersusServerReplayMetaData>.MoveNext
	|-List.Enumerator<Volume>.MoveNext
	|-List.Enumerator<VolumeComponent>.MoveNext
	|-List.Enumerator<WatchItem>.MoveNext
	|-List.Enumerator<WeaponMask>.MoveNext
	|-List.Enumerator<X509CertificateImpl>.MoveNext
	|-List.Enumerator<XRPass>.MoveNext
	|-List.Enumerator<AddressablesImpl.ResourceLocatorInfo>.MoveNext
	|-List.Enumerator<AdhocAssetLoader.Asset>.MoveNext
	|-List.Enumerator<AssetTable.Accessory>.MoveNext
	|-List.Enumerator<BufferedGizmo.Segment>.MoveNext
	|-List.Enumerator<CasualMap.ObjectData>.MoveNext
	|-List.Enumerator<ChapterRecord.Record>.MoveNext
	|-List.Enumerator<CinemachineCollider.VcamExtraState>.MoveNext
	|-List.Enumerator<ClassChange.ChangeJobData>.MoveNext
	|-List.Enumerator<ClassChangeJobMenuItemContent.WeaponLevelItem>.MoveNext
	|-List.Enumerator<CombatViewerSettings.ViewerPhase>.MoveNext
	|-List.Enumerator<ConstantBuffer.ConstantBufferBase>.MoveNext
	|-List.Enumerator<DLCManager.MountData>.MoveNext
	|-List.Enumerator<DebugUI.Panel>.MoveNext
	|-List.Enumerator<DishSelectFoodInfoContent.FoodstuffObject>.MoveNext
	|-List.Enumerator<DishSelectMenu.DishSelectMenuItem>.MoveNext
	|-List.Enumerator<DishSelectMenuCategoryContent.CategoryObject>.MoveNext
	|-List.Enumerator<DragonRideTargetGroup.ChainSEManager>.MoveNext
	|-List.Enumerator<DynamicsSetup.ParseMessage>.MoveNext
	|-List.Enumerator<EmittersConstraint.Pair>.MoveNext
	|-List.Enumerator<ExtensionMethodsRegistry.UnresolvedGenericMethod>.MoveNext
	|-List.Enumerator<FoodstuffMenu.FoodstuffMenuItem>.MoveNext
	|-List.Enumerator<GameSaveDataHeaderReader.Handle>.MoveNext
	|-List.Enumerator<GameSound.Handle>.MoveNext
	|-List.Enumerator<GrassData.SpriteInfo>.MoveNext
	|-List.Enumerator<HelpManager.Item>.MoveNext
	|-List.Enumerator<HubMiniMap.IconData>.MoveNext
	|-List.Enumerator<HubMiniMapCaptureParam.CaptureParam1>.MoveNext
	|-List.Enumerator<IfStatement.IfBlock>.MoveNext
	|-List.Enumerator<MapBattleInfoSequence.AttackInfo>.MoveNext
	|-List.Enumerator<MapDispos.ActualData>.MoveNext
	|-List.Enumerator<MapDispos.Pos>.MoveNext
	|-List.Enumerator<MapEditData.UnitInfo>.MoveNext
	|-List.Enumerator<MapImageTerrain.MinimapInfo>.MoveNext
	|-List.Enumerator<MapPrefab.Entity>.MoveNext
	|-List.Enumerator<MapTarget.Data>.MoveNext
	|-List.Enumerator<MapTerrain.LayerData>.MoveNext
	|-List.Enumerator<MapTerrain.OverlapData>.MoveNext
	|-List.Enumerator<MapTerrainInfoAlignment.AlignMember>.MoveNext
	|-List.Enumerator<MapTerrainInfoAlignment.InversionMember>.MoveNext
	|-List.Enumerator<Mess.ReloadFileInfo>.MoveNext
	|-List.Enumerator<MonoChunkStream.Chunk>.MoveNext
	|-List.Enumerator<MuscleSquatSequence.RandomPack>.MoveNext
	|-List.Enumerator<PhotographTopSequence.UnitAccDataSet>.MoveNext
	|-List.Enumerator<ResourceManager.InstanceOperation>.MoveNext
	|-List.Enumerator<RingListSequence.GodPageData>.MoveNext
	|-List.Enumerator<RingListSequence.PageData>.MoveNext
	|-List.Enumerator<RingListSequence.RingPageData>.MoveNext
	|-List.Enumerator<SkillStack.Packet>.MoveNext
	|-List.Enumerator<SolanelInfoMenuContent.SolanelUnit>.MoveNext
	|-List.Enumerator<SoundSystem.ResultSoundLoad>.MoveNext
	|-List.Enumerator<SoundSystem.SoundHandle>.MoveNext
	|-List.Enumerator<StructHeader.Param>.MoveNext
	|-List.Enumerator<TitleSequence.PedestalData>.MoveNext
	|-List.Enumerator<UnitSelectMenu.UnitSelectMenuItem>.MoveNext
	|-List.Enumerator<UnitStatusSetter.CapabilityValueParam>.MoveNext
	|-List.Enumerator<UnitStatusSetter.SkillSetter>.MoveNext
	|-List.Enumerator<UnitStatusSetter.WeaponLevelSetter>.MoveNext
	|-List.Enumerator<EventDemoSequence.SoundEnv.EventNameData>.MoveNext
	|-List.Enumerator<SoundWwise.SoundBankManager.BankHandle>.MoveNext
	|-List.Enumerator<TitleSequence.ProcTitleCall.TitleCallData>.MoveNext
	|-List.Enumerator<VersusSequence.VersusSequenceLocal.MetaDataPack>.MoveNext
	|
	|-RVA: 0x1D2F100 Offset: 0x1D2F201 VA: 0x1D2F100
	|-List.Enumerator<CommonBattleSequence.Reliance<object>>.MoveNext
	|
	|-RVA: 0x2EAE870 Offset: 0x2EAE971 VA: 0x2EAE870
	|-List.Enumerator<RenderGraphResourcePool.ResourceLogInfo<object>>.MoveNext
	|
	|-RVA: 0x2EAF220 Offset: 0x2EAF321 VA: 0x2EAF220
	|-List.Enumerator<ValueTuple<int, object>>.MoveNext
	|
	|-RVA: 0x2EAF4F0 Offset: 0x2EAF5F1 VA: 0x2EAF4F0
	|-List.Enumerator<ValueTuple<Int32Enum, int>>.MoveNext
	|
	|-RVA: 0x2EAF7A0 Offset: 0x2EAF8A1 VA: 0x2EAF7A0
	|-List.Enumerator<ValueTuple<object, ValueTuple<object, int>>>.MoveNext
	|-List.Enumerator<ValueTuple<object, ValueTuple<Type, int>>>.MoveNext
	|
	|-RVA: 0x2EAFD80 Offset: 0x2EAFE81 VA: 0x2EAFD80
	|-List.Enumerator<ValueTuple<object, int>>.MoveNext
	|
	|-RVA: 0x2EB07D0 Offset: 0x2EB08D1 VA: 0x2EB07D0
	|-List.Enumerator<ValueTuple<Vector3, float>>.MoveNext
	|
	|-RVA: 0x2EB0A70 Offset: 0x2EB0B71 VA: 0x2EB0A70
	|-List.Enumerator<ValueTuple<object, Int32Enum, int>>.MoveNext
	|
	|-RVA: 0x2EB11B0 Offset: 0x2EB12B1 VA: 0x2EB11B0
	|-List.Enumerator<ValueTuple<object, int, int, int>>.MoveNext
	|
	|-RVA: 0x2EB1480 Offset: 0x2EB1581 VA: 0x2EB1480
	|-List.Enumerator<AnimatorClipInfo>.MoveNext
	|
	|-RVA: 0x2EB1EA0 Offset: 0x2EB1FA1 VA: 0x2EB1EA0
	|-List.Enumerator<AsyncOperationHandle>.MoveNext
	|
	|-RVA: 0x2EB2620 Offset: 0x2EB2721 VA: 0x2EB2620
	|-List.Enumerator<BoneWeight>.MoveNext
	|
	|-RVA: 0x2EB29E0 Offset: 0x2EB2AE1 VA: 0x2EB29E0
	|-List.Enumerator<bool>.MoveNext
	|
	|-RVA: 0x2EB2C90 Offset: 0x2EB2D91 VA: 0x2EB2C90
	|-List.Enumerator<byte>.MoveNext
	|
	|-RVA: 0x2EB3040 Offset: 0x2EB3141 VA: 0x2EB3040
	|-List.Enumerator<CameraInfo>.MoveNext
	|
	|-RVA: 0x2EB3310 Offset: 0x2EB3411 VA: 0x2EB3310
	|-List.Enumerator<char>.MoveNext
	|
	|-RVA: 0x2EB35C0 Offset: 0x2EB36C1 VA: 0x2EB35C0
	|-List.Enumerator<Color>.MoveNext
	|
	|-RVA: 0x2EB3BA0 Offset: 0x2EB3CA1 VA: 0x2EB3BA0
	|-List.Enumerator<Color32>.MoveNext
	|
	|-RVA: 0x2EB3E50 Offset: 0x2EB3F51 VA: 0x2EB3E50
	|-List.Enumerator<ConstraintSource>.MoveNext
	|
	|-RVA: 0x2EB4120 Offset: 0x2EB4221 VA: 0x2EB4120
	|-List.Enumerator<ContourVertex>.MoveNext
	|
	|-RVA: 0x2EB43F0 Offset: 0x2EB44F1 VA: 0x2EB43F0
	|-List.Enumerator<DataStoreRatingInfo>.MoveNext
	|
	|-RVA: 0x2EB46B0 Offset: 0x2EB47B1 VA: 0x2EB46B0
	|-List.Enumerator<DataStoreResult>.MoveNext
	|
	|-RVA: 0x2EB4960 Offset: 0x2EB4A61 VA: 0x2EB4960
	|-List.Enumerator<DateTime>.MoveNext
	|
	|-RVA: 0x2EB4C10 Offset: 0x2EB4D11 VA: 0x2EB4C10
	|-List.Enumerator<DateTimeOffset>.MoveNext
	|
	|-RVA: 0x2EB4ED0 Offset: 0x2EB4FD1 VA: 0x2EB4ED0
	|-List.Enumerator<Decimal>.MoveNext
	|
	|-RVA: 0x2EB5190 Offset: 0x2EB5291 VA: 0x2EB5190
	|-List.Enumerator<DiagnosticEvent>.MoveNext
	|
	|-RVA: 0x2EB5460 Offset: 0x2EB5561 VA: 0x2EB5460
	|-List.Enumerator<double>.MoveNext
	|
	|-RVA: 0x2EB5710 Offset: 0x2EB5811 VA: 0x2EB5710
	|-List.Enumerator<Friend>.MoveNext
	|
	|-RVA: 0x2EB59D0 Offset: 0x2EB5AD1 VA: 0x2EB59D0
	|-List.Enumerator<GlyphRect>.MoveNext
	|
	|-RVA: 0x2EB5C90 Offset: 0x2EB5D91 VA: 0x2EB5C90
	|-List.Enumerator<short>.MoveNext
	|
	|-RVA: 0x2EB6230 Offset: 0x2EB6331 VA: 0x2EB6230
	|-List.Enumerator<int>.MoveNext
	|
	|-RVA: 0x2EB6F20 Offset: 0x2EB7021 VA: 0x2EB6F20
	|-List.Enumerator<Int32Enum>.MoveNext
	|-List.Enumerator<MapPanelActive.MeshIndex>.MoveNext
	|
	|-RVA: 0x2EB75F0 Offset: 0x2EB76F1 VA: 0x2EB75F0
	|-List.Enumerator<long>.MoveNext
	|
	|-RVA: 0x2EB78A0 Offset: 0x2EB79A1 VA: 0x2EB78A0
	|-List.Enumerator<IntPtr>.MoveNext
	|
	|-RVA: 0x2EB7B50 Offset: 0x2EB7C51 VA: 0x2EB7B50
	|-List.Enumerator<InterpretedFrameInfo>.MoveNext
	|
	|-RVA: 0x2EB7E20 Offset: 0x2EB7F21 VA: 0x2EB7E20
	|-List.Enumerator<IntervalTreeNode>.MoveNext
	|
	|-RVA: 0x2EB81F0 Offset: 0x2EB82F1 VA: 0x2EB81F0
	|-List.Enumerator<LengthLimitProperties>.MoveNext
	|
	|-RVA: 0x2EB89D0 Offset: 0x2EB8AD1 VA: 0x2EB89D0
	|-List.Enumerator<MapPos>.MoveNext
	|
	|-RVA: 0x2EB8C90 Offset: 0x2EB8D91 VA: 0x2EB8C90
	|-List.Enumerator<Matrix4x4>.MoveNext
	|
	|-RVA: 0x2EBAD50 Offset: 0x2EBAE51 VA: 0x2EBAD50
	|-List.Enumerator<ObjectInitializationData>.MoveNext
	|
	|-RVA: 0x2EBB140 Offset: 0x2EBB241 VA: 0x2EBB140
	|-List.Enumerator<PlayableBinding>.MoveNext
	|
	|-RVA: 0x2EBB410 Offset: 0x2EBB511 VA: 0x2EBB410
	|-List.Enumerator<PlayerLoopSystem>.MoveNext
	|
	|-RVA: 0x2EBB6E0 Offset: 0x2EBB7E1 VA: 0x2EBB6E0
	|-List.Enumerator<PlayerLoopSystemInternal>.MoveNext
	|
	|-RVA: 0x2EBBE20 Offset: 0x2EBBF21 VA: 0x2EBBE20
	|-List.Enumerator<RangePositionInfo>.MoveNext
	|
	|-RVA: 0x2EBC0F0 Offset: 0x2EBC1F1 VA: 0x2EBC0F0
	|-List.Enumerator<Ranking2ChartInfoInput>.MoveNext
	|
	|-RVA: 0x2EBC3A0 Offset: 0x2EBC4A1 VA: 0x2EBC3A0
	|-List.Enumerator<RaycastHit2D>.MoveNext
	|
	|-RVA: 0x2EBC690 Offset: 0x2EBC791 VA: 0x2EBC690
	|-List.Enumerator<RaycastResult>.MoveNext
	|
	|-RVA: 0x2EBC9B0 Offset: 0x2EBCAB1 VA: 0x2EBC9B0
	|-List.Enumerator<Rect>.MoveNext
	|
	|-RVA: 0x2EBCDB0 Offset: 0x2EBCEB1 VA: 0x2EBCDB0
	|-List.Enumerator<RendererListHandle>.MoveNext
	|
	|-RVA: 0x2EBD060 Offset: 0x2EBD161 VA: 0x2EBD060
	|-List.Enumerator<ResourceHandle>.MoveNext
	|
	|-RVA: 0x2EBD310 Offset: 0x2EBD411 VA: 0x2EBD310
	|-List.Enumerator<sbyte>.MoveNext
	|
	|-RVA: 0x2EBD5C0 Offset: 0x2EBD6C1 VA: 0x2EBD5C0
	|-List.Enumerator<ShaderTagId>.MoveNext
	|
	|-RVA: 0x2EBD970 Offset: 0x2EBDA71 VA: 0x2EBD970
	|-List.Enumerator<float>.MoveNext
	|
	|-RVA: 0x2EBDF60 Offset: 0x2EBE061 VA: 0x2EBDF60
	|-List.Enumerator<SphericalHarmonicsL2>.MoveNext
	|
	|-RVA: 0x2EBE9F0 Offset: 0x2EBEAF1 VA: 0x2EBE9F0
	|-List.Enumerator<SubMeshDescriptor>.MoveNext
	|
	|-RVA: 0x2EBF0E0 Offset: 0x2EBF1E1 VA: 0x2EBF0E0
	|-List.Enumerator<TablePair>.MoveNext
	|
	|-RVA: 0x2E02AC0 Offset: 0x2E02BC1 VA: 0x2E02AC0
	|-List.Enumerator<TimeSpan>.MoveNext
	|
	|-RVA: 0x2E02D70 Offset: 0x2E02E71 VA: 0x2E02D70
	|-List.Enumerator<UICharInfo>.MoveNext
	|
	|-RVA: 0x2E03020 Offset: 0x2E03121 VA: 0x2E03020
	|-List.Enumerator<UILineInfo>.MoveNext
	|
	|-RVA: 0x2E03300 Offset: 0x2E03401 VA: 0x2E03300
	|-List.Enumerator<UIVertex>.MoveNext
	|
	|-RVA: 0x2E03650 Offset: 0x2E03751 VA: 0x2E03650
	|-List.Enumerator<ushort>.MoveNext
	|
	|-RVA: 0x2E03CF0 Offset: 0x2E03DF1 VA: 0x2E03CF0
	|-List.Enumerator<uint>.MoveNext
	|
	|-RVA: 0x2E046A0 Offset: 0x2E047A1 VA: 0x2E046A0
	|-List.Enumerator<ulong>.MoveNext
	|
	|-RVA: 0x2E04950 Offset: 0x2E04A51 VA: 0x2E04950
	|-List.Enumerator<Vector2>.MoveNext
	|
	|-RVA: 0x2E04EC0 Offset: 0x2E04FC1 VA: 0x2E04EC0
	|-List.Enumerator<Vector3>.MoveNext
	|
	|-RVA: 0x2E05440 Offset: 0x2E05541 VA: 0x2E05440
	|-List.Enumerator<Vector4>.MoveNext
	|
	|-RVA: 0x2E056E0 Offset: 0x2E057E1 VA: 0x2E056E0
	|-List.Enumerator<VertexAttributeDescriptor>.MoveNext
	|
	|-RVA: 0x2E05C10 Offset: 0x2E05D11 VA: 0x2E05C10
	|-List.Enumerator<X509ChainStatus>.MoveNext
	|
	|-RVA: 0x2E05F00 Offset: 0x2E06001 VA: 0x2E05F00
	|-List.Enumerator<XRView>.MoveNext
	|
	|-RVA: 0x2E06590 Offset: 0x2E06691 VA: 0x2E06590
	|-List.Enumerator<AmiiboSequence.GainItemData>.MoveNext
	|
	|-RVA: 0x2E06860 Offset: 0x2E06961 VA: 0x2E06860
	|-List.Enumerator<AnimationOutputWeightProcessor.WeightInfo>.MoveNext
	|
	|-RVA: 0x2E06B20 Offset: 0x2E06C21 VA: 0x2E06B20
	|-List.Enumerator<ArenaOrderSequence.GodInfo>.MoveNext
	|
	|-RVA: 0x2E06DF0 Offset: 0x2E06EF1 VA: 0x2E06DF0
	|-List.Enumerator<BattleInfo.SupportData>.MoveNext
	|
	|-RVA: 0x2E070C0 Offset: 0x2E071C1 VA: 0x2E070C0
	|-List.Enumerator<BeforeRenderHelper.OrderBlock>.MoveNext
	|
	|-RVA: 0x2E07390 Offset: 0x2E07491 VA: 0x2E07390
	|-List.Enumerator<Camera.RenderRequest>.MoveNext
	|
	|-RVA: 0x2E07660 Offset: 0x2E07761 VA: 0x2E07660
	|-List.Enumerator<CameraState.CustomBlendable>.MoveNext
	|
	|-RVA: 0x2E07930 Offset: 0x2E07A31 VA: 0x2E07930
	|-List.Enumerator<CinemachineClearShot.Pair>.MoveNext
	|
	|-RVA: 0x2E07BE0 Offset: 0x2E07CE1 VA: 0x2E07BE0
	|-List.Enumerator<CinemachineStateDrivenCamera.HashPair>.MoveNext
	|
	|-RVA: 0x2E08420 Offset: 0x2E08521 VA: 0x2E08420
	|-List.Enumerator<DelayedActionManager.DelegateInfo>.MoveNext
	|
	|-RVA: 0x2E086F0 Offset: 0x2E087F1 VA: 0x2E086F0
	|-List.Enumerator<Detail.AsyncResultInt>.MoveNext
	|
	|-RVA: 0x2E089B0 Offset: 0x2E08AB1 VA: 0x2E089B0
	|-List.Enumerator<Detail.CppArray>.MoveNext
	|
	|-RVA: 0x2E08C70 Offset: 0x2E08D71 VA: 0x2E08C70
	|-List.Enumerator<Detail.NotificationEventInt>.MoveNext
	|
	|-RVA: 0x2E08F30 Offset: 0x2E09031 VA: 0x2E08F30
	|-List.Enumerator<DragonRideTargetGroup.ChainParam>.MoveNext
	|
	|-RVA: 0x2E09520 Offset: 0x2E09621 VA: 0x2E09520
	|-List.Enumerator<GmapPathAdjuster.TargetModel>.MoveNext
	|
	|-RVA: 0x2E097F0 Offset: 0x2E098F1 VA: 0x2E097F0
	|-List.Enumerator<GmapSpotAdjuster.TargetModel>.MoveNext
	|
	|-RVA: 0x2E09AC0 Offset: 0x2E09BC1 VA: 0x2E09AC0
	|-List.Enumerator<HubFastTravel.Location>.MoveNext
	|
	|-RVA: 0x2E09D90 Offset: 0x2E09E91 VA: 0x2E09D90
	|-List.Enumerator<HubLensFlare.Flare>.MoveNext
	|
	|-RVA: 0x2E0A060 Offset: 0x2E0A161 VA: 0x2E0A060
	|-List.Enumerator<InventoryPoolItemMenuContent.KindBgNameClass>.MoveNext
	|
	|-RVA: 0x2E0A5A0 Offset: 0x2E0A6A1 VA: 0x2E0A5A0
	|-List.Enumerator<Map.Pos>.MoveNext
	|
	|-RVA: 0x2E0A850 Offset: 0x2E0A951 VA: 0x2E0A850
	|-List.Enumerator<MapImage.BackupTerrain>.MoveNext
	|
	|-RVA: 0x2E0AB10 Offset: 0x2E0AC11 VA: 0x2E0AB10
	|-List.Enumerator<MapImageRange.Pos>.MoveNext
	|
	|-RVA: 0x2E0B170 Offset: 0x2E0B271 VA: 0x2E0B170
	|-List.Enumerator<MapMind.Target>.MoveNext
	|
	|-RVA: 0x2E0B440 Offset: 0x2E0B541 VA: 0x2E0B440
	|-List.Enumerator<MapPanelDebug.Entity>.MoveNext
	|
	|-RVA: 0x2E0B700 Offset: 0x2E0B801 VA: 0x2E0B700
	|-List.Enumerator<NexRanking.Data>.MoveNext
	|
	|-RVA: 0x2E0B9B0 Offset: 0x2E0BAB1 VA: 0x2E0B9B0
	|-List.Enumerator<NexVersus.RatingData>.MoveNext
	|
	|-RVA: 0x2E0BC70 Offset: 0x2E0BD71 VA: 0x2E0BC70
	|-List.Enumerator<PackedPlayModeBuildLogs.RuntimeBuildLog>.MoveNext
	|
	|-RVA: 0x2E0BF60 Offset: 0x2E0C061 VA: 0x2E0BF60
	|-List.Enumerator<ParticleSystem.Particle>.MoveNext
	|
	|-RVA: 0x2E0C720 Offset: 0x2E0C821 VA: 0x2E0C720
	|-List.Enumerator<RangeData.Offset>.MoveNext
	|
	|-RVA: 0x2E0C9D0 Offset: 0x2E0CAD1 VA: 0x2E0C9D0
	|-List.Enumerator<RenderGraphDebugData.PassDebugData>.MoveNext
	|
	|-RVA: 0x2E0CCA0 Offset: 0x2E0CDA1 VA: 0x2E0CCA0
	|-List.Enumerator<RenderGraphDebugData.ResourceDebugData>.MoveNext
	|
	|-RVA: 0x2E0CF70 Offset: 0x2E0D071 VA: 0x2E0CF70
	|-List.Enumerator<RingCleaningUnitSelectMenu.GodParam>.MoveNext
	|
	|-RVA: 0x2E0D840 Offset: 0x2E0D941 VA: 0x2E0D840
	|-List.Enumerator<ShadowUtility.Edge>.MoveNext
	|
	|-RVA: 0x2E0DF40 Offset: 0x2E0E041 VA: 0x2E0DF40
	|-List.Enumerator<SkillArray.Entity>.MoveNext
	|
	|-RVA: 0x2E0E570 Offset: 0x2E0E671 VA: 0x2E0E570
	|-List.Enumerator<TexturePacker_JsonArray.Frame>.MoveNext
	|
	|-RVA: 0x2E0E860 Offset: 0x2E0E961 VA: 0x2E0E860
	|-List.Enumerator<TimeNotificationBehaviour.NotificationEntry>.MoveNext
	|
	|-RVA: 0x2E0EB30 Offset: 0x2E0EC31 VA: 0x2E0EB30
	|-List.Enumerator<UnitySynchronizationContext.WorkRequest>.MoveNext
	|
	|-RVA: 0x2E0EE00 Offset: 0x2E0EF01 VA: 0x2E0EE00
	|-List.Enumerator<XmlSchemaObjectTable.XmlSchemaObjectEntry>.MoveNext
	|
	|-RVA: 0x2E0F0D0 Offset: 0x2E0F1D1 VA: 0x2E0F0D0
	|-List.Enumerator<AssetBundleBuildMap.AssetBundleEntry.AssetPathString>.MoveNext
	|
	|-RVA: 0x2E0F3E0 Offset: 0x2E0F4E1 VA: 0x2E0F3E0
	|-List.Enumerator<Detail.DataStore.DataStoreChangeMetaParamInt>.MoveNext
	|
	|-RVA: 0x2E0F730 Offset: 0x2E0F831 VA: 0x2E0F730
	|-List.Enumerator<Detail.DataStore.DataStoreDeleteParamInt>.MoveNext
	|
	|-RVA: 0x2E0F9F0 Offset: 0x2E0FAF1 VA: 0x2E0F9F0
	|-List.Enumerator<Detail.DataStore.DataStoreGetMetaParamInt>.MoveNext
	|
	|-RVA: 0x2E0FCD0 Offset: 0x2E0FDD1 VA: 0x2E0FCD0
	|-List.Enumerator<Detail.DataStore.DataStoreMetaInfoInt>.MoveNext
	|
	|-RVA: 0x2E0FFF0 Offset: 0x2E100F1 VA: 0x2E0FFF0
	|-List.Enumerator<Detail.DataStore.DataStorePasswordInfoInt>.MoveNext
	|
	|-RVA: 0x2E102B0 Offset: 0x2E103B1 VA: 0x2E102B0
	|-List.Enumerator<Detail.DataStore.DataStorePersistenceInfoInt>.MoveNext
	|
	|-RVA: 0x2E10590 Offset: 0x2E10691 VA: 0x2E10590
	|-List.Enumerator<Detail.DataStore.DataStorePreparePostParamInt>.MoveNext
	|
	|-RVA: 0x2E108A0 Offset: 0x2E109A1 VA: 0x2E108A0
	|-List.Enumerator<Detail.DataStore.DataStoreRateObjectParamInt>.MoveNext
	|
	|-RVA: 0x2E10B60 Offset: 0x2E10C61 VA: 0x2E10B60
	|-List.Enumerator<Detail.DataStore.DataStoreRatingInitParamInt>.MoveNext
	|
	|-RVA: 0x2E10E20 Offset: 0x2E10F21 VA: 0x2E10E20
	|-List.Enumerator<Detail.DataStore.DataStoreRatingTargetInt>.MoveNext
	|
	|-RVA: 0x2E110F0 Offset: 0x2E111F1 VA: 0x2E110F0
	|-List.Enumerator<Detail.Ranking.RankingCachedResultInt>.MoveNext
	|
	|-RVA: 0x2E113D0 Offset: 0x2E114D1 VA: 0x2E113D0
	|-List.Enumerator<Detail.Ranking.RankingOrderParamInt>.MoveNext
	|
	|-RVA: 0x2E116A0 Offset: 0x2E117A1 VA: 0x2E116A0
	|-List.Enumerator<Detail.Ranking.RankingRankDataInt>.MoveNext
	|
	|-RVA: 0x2E11990 Offset: 0x2E11A91 VA: 0x2E11990
	|-List.Enumerator<Detail.Ranking2.Ranking2ChartInfoInt>.MoveNext
	|
	|-RVA: 0x2E11CD0 Offset: 0x2E11DD1 VA: 0x2E11CD0
	|-List.Enumerator<Detail.Ranking2.Ranking2RankDataInt>.MoveNext
	|
	|-RVA: 0x2E11FB0 Offset: 0x2E120B1 VA: 0x2E11FB0
	|-List.Enumerator<Detail.Ranking2.Ranking2ScoreDataInt>.MoveNext
	|
	|-RVA: 0x2E12270 Offset: 0x2E12371 VA: 0x2E12270
	|-List.Enumerator<Detail.Screening.ScreeningContextInfoInt>.MoveNext
	|
	|-RVA: 0x2E12540 Offset: 0x2E12641 VA: 0x2E12540
	|-List.Enumerator<Detail.Subscriber.SubscriberContentInt>.MoveNext
	|
	|-RVA: 0x2E12840 Offset: 0x2E12941 VA: 0x2E12840
	|-List.Enumerator<Detail.Subscriber.SubscriberGetContentParamInt>.MoveNext
	|
	|-RVA: 0x2E12B00 Offset: 0x2E12C01 VA: 0x2E12B00
	|-List.Enumerator<Detail.Subscriber.SubscriberUserStatusInfoInt>.MoveNext
	|
	|-RVA: 0x2E12DC0 Offset: 0x2E12EC1 VA: 0x2E12DC0
	|-List.Enumerator<Detail.Subscriber.SubscriberUserStatusParamInt>.MoveNext
	|
	|-RVA: 0x2E13080 Offset: 0x2E13181 VA: 0x2E13080
	|-List.Enumerator<Detail.Utility.IntegerSettings>.MoveNext
	|
	|-RVA: 0x2E13330 Offset: 0x2E13431 VA: 0x2E13330
	|-List.Enumerator<Detail.Utility.UniqueIdInfoInt>.MoveNext
	|
	|-RVA: 0x3499290 Offset: 0x3499391 VA: 0x3499290
	|-List.Enumerator<MapHistory.Rewind.LatestInspectorData>.MoveNext
	|
	|-RVA: 0x3499530 Offset: 0x3499631 VA: 0x3499530
	|-List.Enumerator<MapHistory.Rewind.WorkTerrainData>.MoveNext
	|
	|-RVA: 0x34997D0 Offset: 0x34998D1 VA: 0x34997D0
	|-List.Enumerator<MapSkill.AroundCalculator.Result>.MoveNext
	|
	|-RVA: 0x3499AA0 Offset: 0x3499BA1 VA: 0x3499AA0
	|-List.Enumerator<TargetPositionCache.CacheCurve.Item>.MoveNext
	|
	|-RVA: 0x3499D70 Offset: 0x3499E71 VA: 0x3499D70
	|-List.Enumerator<TargetPositionCache.CacheEntry.RecordingItem>.MoveNext
	*/

	// RVA: -1 Offset: -1
	private bool MoveNextRare() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1D2BBD0 Offset: 0x1D2BCD1 VA: 0x1D2BBD0
	|-List.Enumerator<IntervalTree.Entry<object>>.MoveNextRare
	|
	|-RVA: 0x1D2BE90 Offset: 0x1D2BF91 VA: 0x1D2BE90
	|-List.Enumerator<KeyValuePair<DateTime, object>>.MoveNextRare
	|
	|-RVA: 0x1D2DC00 Offset: 0x1D2DD01 VA: 0x1D2DC00
	|-List.Enumerator<KeyValuePair<int, object>>.MoveNextRare
	|
	|-RVA: 0x1D2DEE0 Offset: 0x1D2DFE1 VA: 0x1D2DEE0
	|-List.Enumerator<KeyValuePair<object, ValueTuple<int, DateTime, object>>>.MoveNextRare
	|
	|-RVA: 0x1D2E1A0 Offset: 0x1D2E2A1 VA: 0x1D2E1A0
	|-List.Enumerator<KeyValuePair<object, object>>.MoveNextRare
	|
	|-RVA: 0x1D2F1F0 Offset: 0x1D2F2F1 VA: 0x1D2F1F0
	|-List.Enumerator<CommonBattleSequence.Reliance<object>>.MoveNextRare
	|
	|-RVA: 0x2EAE950 Offset: 0x2EAEA51 VA: 0x2EAE950
	|-List.Enumerator<RenderGraphResourcePool.ResourceLogInfo<object>>.MoveNextRare
	|
	|-RVA: 0x2EAF300 Offset: 0x2EAF401 VA: 0x2EAF300
	|-List.Enumerator<ValueTuple<int, object>>.MoveNextRare
	|
	|-RVA: 0x2EAF5C0 Offset: 0x2EAF6C1 VA: 0x2EAF5C0
	|-List.Enumerator<ValueTuple<Int32Enum, int>>.MoveNextRare
	|
	|-RVA: 0x2EAF890 Offset: 0x2EAF991 VA: 0x2EAF890
	|-List.Enumerator<ValueTuple<object, ValueTuple<object, int>>>.MoveNextRare
	|
	|-RVA: 0x2EAFE60 Offset: 0x2EAFF61 VA: 0x2EAFE60
	|-List.Enumerator<ValueTuple<object, int>>.MoveNextRare
	|
	|-RVA: 0x2EB08A0 Offset: 0x2EB09A1 VA: 0x2EB08A0
	|-List.Enumerator<ValueTuple<Vector3, float>>.MoveNextRare
	|
	|-RVA: 0x2EB0B50 Offset: 0x2EB0C51 VA: 0x2EB0B50
	|-List.Enumerator<ValueTuple<object, Int32Enum, int>>.MoveNextRare
	|
	|-RVA: 0x2EB12A0 Offset: 0x2EB13A1 VA: 0x2EB12A0
	|-List.Enumerator<ValueTuple<object, int, int, int>>.MoveNextRare
	|
	|-RVA: 0x2EB1550 Offset: 0x2EB1651 VA: 0x2EB1550
	|-List.Enumerator<AnimatorClipInfo>.MoveNextRare
	|
	|-RVA: 0x2EB1F90 Offset: 0x2EB2091 VA: 0x2EB1F90
	|-List.Enumerator<AsyncOperationHandle>.MoveNextRare
	|
	|-RVA: 0x2EB2700 Offset: 0x2EB2801 VA: 0x2EB2700
	|-List.Enumerator<BoneWeight>.MoveNextRare
	|
	|-RVA: 0x2EB2AB0 Offset: 0x2EB2BB1 VA: 0x2EB2AB0
	|-List.Enumerator<bool>.MoveNextRare
	|
	|-RVA: 0x2EB2D60 Offset: 0x2EB2E61 VA: 0x2EB2D60
	|-List.Enumerator<byte>.MoveNextRare
	|
	|-RVA: 0x2EB3120 Offset: 0x2EB3221 VA: 0x2EB3120
	|-List.Enumerator<CameraInfo>.MoveNextRare
	|
	|-RVA: 0x2EB33E0 Offset: 0x2EB34E1 VA: 0x2EB33E0
	|-List.Enumerator<char>.MoveNextRare
	|
	|-RVA: 0x2EB3690 Offset: 0x2EB3791 VA: 0x2EB3690
	|-List.Enumerator<Color>.MoveNextRare
	|
	|-RVA: 0x2EB3C70 Offset: 0x2EB3D71 VA: 0x2EB3C70
	|-List.Enumerator<Color32>.MoveNextRare
	|
	|-RVA: 0x2EB3F30 Offset: 0x2EB4031 VA: 0x2EB3F30
	|-List.Enumerator<ConstraintSource>.MoveNextRare
	|
	|-RVA: 0x2EB4210 Offset: 0x2EB4311 VA: 0x2EB4210
	|-List.Enumerator<ContourVertex>.MoveNextRare
	|
	|-RVA: 0x2EB44D0 Offset: 0x2EB45D1 VA: 0x2EB44D0
	|-List.Enumerator<DataStoreRatingInfo>.MoveNextRare
	|
	|-RVA: 0x2EB4780 Offset: 0x2EB4881 VA: 0x2EB4780
	|-List.Enumerator<DataStoreResult>.MoveNextRare
	|
	|-RVA: 0x2EB4A30 Offset: 0x2EB4B31 VA: 0x2EB4A30
	|-List.Enumerator<DateTime>.MoveNextRare
	|
	|-RVA: 0x2EB4CE0 Offset: 0x2EB4DE1 VA: 0x2EB4CE0
	|-List.Enumerator<DateTimeOffset>.MoveNextRare
	|
	|-RVA: 0x2EB4FA0 Offset: 0x2EB50A1 VA: 0x2EB4FA0
	|-List.Enumerator<Decimal>.MoveNextRare
	|
	|-RVA: 0x2EB5280 Offset: 0x2EB5381 VA: 0x2EB5280
	|-List.Enumerator<DiagnosticEvent>.MoveNextRare
	|
	|-RVA: 0x2EB5530 Offset: 0x2EB5631 VA: 0x2EB5530
	|-List.Enumerator<double>.MoveNextRare
	|
	|-RVA: 0x2EB57F0 Offset: 0x2EB58F1 VA: 0x2EB57F0
	|-List.Enumerator<Friend>.MoveNextRare
	|
	|-RVA: 0x2EB5AA0 Offset: 0x2EB5BA1 VA: 0x2EB5AA0
	|-List.Enumerator<GlyphRect>.MoveNextRare
	|
	|-RVA: 0x2EB5D60 Offset: 0x2EB5E61 VA: 0x2EB5D60
	|-List.Enumerator<short>.MoveNextRare
	|
	|-RVA: 0x2EB6300 Offset: 0x2EB6401 VA: 0x2EB6300
	|-List.Enumerator<int>.MoveNextRare
	|
	|-RVA: 0x2EB6FF0 Offset: 0x2EB70F1 VA: 0x2EB6FF0
	|-List.Enumerator<Int32Enum>.MoveNextRare
	|
	|-RVA: 0x2EB76C0 Offset: 0x2EB77C1 VA: 0x2EB76C0
	|-List.Enumerator<long>.MoveNextRare
	|
	|-RVA: 0x2EB7970 Offset: 0x2EB7A71 VA: 0x2EB7970
	|-List.Enumerator<IntPtr>.MoveNextRare
	|
	|-RVA: 0x2EB7C30 Offset: 0x2EB7D31 VA: 0x2EB7C30
	|-List.Enumerator<InterpretedFrameInfo>.MoveNextRare
	|
	|-RVA: 0x2EB7F00 Offset: 0x2EB8001 VA: 0x2EB7F00
	|-List.Enumerator<IntervalTreeNode>.MoveNextRare
	|
	|-RVA: 0x2EB82C0 Offset: 0x2EB83C1 VA: 0x2EB82C0
	|-List.Enumerator<LengthLimitProperties>.MoveNextRare
	|
	|-RVA: 0x2EB8AA0 Offset: 0x2EB8BA1 VA: 0x2EB8AA0
	|-List.Enumerator<MapPos>.MoveNextRare
	|
	|-RVA: 0x2EB8D70 Offset: 0x2EB8E71 VA: 0x2EB8D70
	|-List.Enumerator<Matrix4x4>.MoveNextRare
	|
	|-RVA: 0x2EB96D0 Offset: 0x2EB97D1 VA: 0x2EB96D0
	|-List.Enumerator<object>.MoveNextRare
	|
	|-RVA: 0x2EBAE40 Offset: 0x2EBAF41 VA: 0x2EBAE40
	|-List.Enumerator<ObjectInitializationData>.MoveNextRare
	|
	|-RVA: 0x2EBB230 Offset: 0x2EBB331 VA: 0x2EBB230
	|-List.Enumerator<PlayableBinding>.MoveNextRare
	|
	|-RVA: 0x2EBB500 Offset: 0x2EBB601 VA: 0x2EBB500
	|-List.Enumerator<PlayerLoopSystem>.MoveNextRare
	|
	|-RVA: 0x2EBB7D0 Offset: 0x2EBB8D1 VA: 0x2EBB7D0
	|-List.Enumerator<PlayerLoopSystemInternal>.MoveNextRare
	|
	|-RVA: 0x2EBBF00 Offset: 0x2EBC001 VA: 0x2EBBF00
	|-List.Enumerator<RangePositionInfo>.MoveNextRare
	|
	|-RVA: 0x2EBC1C0 Offset: 0x2EBC2C1 VA: 0x2EBC1C0
	|-List.Enumerator<Ranking2ChartInfoInput>.MoveNextRare
	|
	|-RVA: 0x2EBC480 Offset: 0x2EBC581 VA: 0x2EBC480
	|-List.Enumerator<RaycastHit2D>.MoveNextRare
	|
	|-RVA: 0x2EBC790 Offset: 0x2EBC891 VA: 0x2EBC790
	|-List.Enumerator<RaycastResult>.MoveNextRare
	|
	|-RVA: 0x2EBCA80 Offset: 0x2EBCB81 VA: 0x2EBCA80
	|-List.Enumerator<Rect>.MoveNextRare
	|
	|-RVA: 0x2EBCE80 Offset: 0x2EBCF81 VA: 0x2EBCE80
	|-List.Enumerator<RendererListHandle>.MoveNextRare
	|
	|-RVA: 0x2EBD130 Offset: 0x2EBD231 VA: 0x2EBD130
	|-List.Enumerator<ResourceHandle>.MoveNextRare
	|
	|-RVA: 0x2EBD3E0 Offset: 0x2EBD4E1 VA: 0x2EBD3E0
	|-List.Enumerator<sbyte>.MoveNextRare
	|
	|-RVA: 0x2EBD690 Offset: 0x2EBD791 VA: 0x2EBD690
	|-List.Enumerator<ShaderTagId>.MoveNextRare
	|
	|-RVA: 0x2EBDA40 Offset: 0x2EBDB41 VA: 0x2EBDA40
	|-List.Enumerator<float>.MoveNextRare
	|
	|-RVA: 0x2EBE050 Offset: 0x2EBE151 VA: 0x2EBE050
	|-List.Enumerator<SphericalHarmonicsL2>.MoveNextRare
	|
	|-RVA: 0x2EBEAD0 Offset: 0x2EBEBD1 VA: 0x2EBEAD0
	|-List.Enumerator<SubMeshDescriptor>.MoveNextRare
	|
	|-RVA: 0x2EBF1C0 Offset: 0x2EBF2C1 VA: 0x2EBF1C0
	|-List.Enumerator<TablePair>.MoveNextRare
	|
	|-RVA: 0x2E02B90 Offset: 0x2E02C91 VA: 0x2E02B90
	|-List.Enumerator<TimeSpan>.MoveNextRare
	|
	|-RVA: 0x2E02E50 Offset: 0x2E02F51 VA: 0x2E02E50
	|-List.Enumerator<UICharInfo>.MoveNextRare
	|
	|-RVA: 0x2E030F0 Offset: 0x2E031F1 VA: 0x2E030F0
	|-List.Enumerator<UILineInfo>.MoveNextRare
	|
	|-RVA: 0x2E033F0 Offset: 0x2E034F1 VA: 0x2E033F0
	|-List.Enumerator<UIVertex>.MoveNextRare
	|
	|-RVA: 0x2E03720 Offset: 0x2E03821 VA: 0x2E03720
	|-List.Enumerator<ushort>.MoveNextRare
	|
	|-RVA: 0x2E03DC0 Offset: 0x2E03EC1 VA: 0x2E03DC0
	|-List.Enumerator<uint>.MoveNextRare
	|
	|-RVA: 0x2E04770 Offset: 0x2E04871 VA: 0x2E04770
	|-List.Enumerator<ulong>.MoveNextRare
	|
	|-RVA: 0x2E04A20 Offset: 0x2E04B21 VA: 0x2E04A20
	|-List.Enumerator<Vector2>.MoveNextRare
	|
	|-RVA: 0x2E04FA0 Offset: 0x2E050A1 VA: 0x2E04FA0
	|-List.Enumerator<Vector3>.MoveNextRare
	|
	|-RVA: 0x2E05510 Offset: 0x2E05611 VA: 0x2E05510
	|-List.Enumerator<Vector4>.MoveNextRare
	|
	|-RVA: 0x2E057B0 Offset: 0x2E058B1 VA: 0x2E057B0
	|-List.Enumerator<VertexAttributeDescriptor>.MoveNextRare
	|
	|-RVA: 0x2E05CF0 Offset: 0x2E05DF1 VA: 0x2E05CF0
	|-List.Enumerator<X509ChainStatus>.MoveNextRare
	|
	|-RVA: 0x2E06010 Offset: 0x2E06111 VA: 0x2E06010
	|-List.Enumerator<XRView>.MoveNextRare
	|
	|-RVA: 0x2E06670 Offset: 0x2E06771 VA: 0x2E06670
	|-List.Enumerator<AmiiboSequence.GainItemData>.MoveNextRare
	|
	|-RVA: 0x2E06940 Offset: 0x2E06A41 VA: 0x2E06940
	|-List.Enumerator<AnimationOutputWeightProcessor.WeightInfo>.MoveNextRare
	|
	|-RVA: 0x2E06C00 Offset: 0x2E06D01 VA: 0x2E06C00
	|-List.Enumerator<ArenaOrderSequence.GodInfo>.MoveNextRare
	|
	|-RVA: 0x2E06ED0 Offset: 0x2E06FD1 VA: 0x2E06ED0
	|-List.Enumerator<BattleInfo.SupportData>.MoveNextRare
	|
	|-RVA: 0x2E071A0 Offset: 0x2E072A1 VA: 0x2E071A0
	|-List.Enumerator<BeforeRenderHelper.OrderBlock>.MoveNextRare
	|
	|-RVA: 0x2E07480 Offset: 0x2E07581 VA: 0x2E07480
	|-List.Enumerator<Camera.RenderRequest>.MoveNextRare
	|
	|-RVA: 0x2E07740 Offset: 0x2E07841 VA: 0x2E07740
	|-List.Enumerator<CameraState.CustomBlendable>.MoveNextRare
	|
	|-RVA: 0x2E07A00 Offset: 0x2E07B01 VA: 0x2E07A00
	|-List.Enumerator<CinemachineClearShot.Pair>.MoveNextRare
	|
	|-RVA: 0x2E07CB0 Offset: 0x2E07DB1 VA: 0x2E07CB0
	|-List.Enumerator<CinemachineStateDrivenCamera.HashPair>.MoveNextRare
	|
	|-RVA: 0x2E08510 Offset: 0x2E08611 VA: 0x2E08510
	|-List.Enumerator<DelayedActionManager.DelegateInfo>.MoveNextRare
	|
	|-RVA: 0x2E087D0 Offset: 0x2E088D1 VA: 0x2E087D0
	|-List.Enumerator<Detail.AsyncResultInt>.MoveNextRare
	|
	|-RVA: 0x2E08A80 Offset: 0x2E08B81 VA: 0x2E08A80
	|-List.Enumerator<Detail.CppArray>.MoveNextRare
	|
	|-RVA: 0x2E08D50 Offset: 0x2E08E51 VA: 0x2E08D50
	|-List.Enumerator<Detail.NotificationEventInt>.MoveNextRare
	|
	|-RVA: 0x2E09010 Offset: 0x2E09111 VA: 0x2E09010
	|-List.Enumerator<DragonRideTargetGroup.ChainParam>.MoveNextRare
	|
	|-RVA: 0x2E09610 Offset: 0x2E09711 VA: 0x2E09610
	|-List.Enumerator<GmapPathAdjuster.TargetModel>.MoveNextRare
	|
	|-RVA: 0x2E098E0 Offset: 0x2E099E1 VA: 0x2E098E0
	|-List.Enumerator<GmapSpotAdjuster.TargetModel>.MoveNextRare
	|
	|-RVA: 0x2E09BB0 Offset: 0x2E09CB1 VA: 0x2E09BB0
	|-List.Enumerator<HubFastTravel.Location>.MoveNextRare
	|
	|-RVA: 0x2E09E80 Offset: 0x2E09F81 VA: 0x2E09E80
	|-List.Enumerator<HubLensFlare.Flare>.MoveNextRare
	|
	|-RVA: 0x2E0A140 Offset: 0x2E0A241 VA: 0x2E0A140
	|-List.Enumerator<InventoryPoolItemMenuContent.KindBgNameClass>.MoveNextRare
	|
	|-RVA: 0x2E0A670 Offset: 0x2E0A771 VA: 0x2E0A670
	|-List.Enumerator<Map.Pos>.MoveNextRare
	|
	|-RVA: 0x2E0A920 Offset: 0x2E0AA21 VA: 0x2E0A920
	|-List.Enumerator<MapImage.BackupTerrain>.MoveNextRare
	|
	|-RVA: 0x2E0ABE0 Offset: 0x2E0ACE1 VA: 0x2E0ABE0
	|-List.Enumerator<MapImageRange.Pos>.MoveNextRare
	|
	|-RVA: 0x2E0B260 Offset: 0x2E0B361 VA: 0x2E0B260
	|-List.Enumerator<MapMind.Target>.MoveNextRare
	|
	|-RVA: 0x2E0B520 Offset: 0x2E0B621 VA: 0x2E0B520
	|-List.Enumerator<MapPanelDebug.Entity>.MoveNextRare
	|
	|-RVA: 0x2E0B7D0 Offset: 0x2E0B8D1 VA: 0x2E0B7D0
	|-List.Enumerator<NexRanking.Data>.MoveNextRare
	|
	|-RVA: 0x2E0BA80 Offset: 0x2E0BB81 VA: 0x2E0BA80
	|-List.Enumerator<NexVersus.RatingData>.MoveNextRare
	|
	|-RVA: 0x2E0BD50 Offset: 0x2E0BE51 VA: 0x2E0BD50
	|-List.Enumerator<PackedPlayModeBuildLogs.RuntimeBuildLog>.MoveNextRare
	|
	|-RVA: 0x2E0C050 Offset: 0x2E0C151 VA: 0x2E0C050
	|-List.Enumerator<ParticleSystem.Particle>.MoveNextRare
	|
	|-RVA: 0x2E0C7F0 Offset: 0x2E0C8F1 VA: 0x2E0C7F0
	|-List.Enumerator<RangeData.Offset>.MoveNextRare
	|
	|-RVA: 0x2E0CAC0 Offset: 0x2E0CBC1 VA: 0x2E0CAC0
	|-List.Enumerator<RenderGraphDebugData.PassDebugData>.MoveNextRare
	|
	|-RVA: 0x2E0CD90 Offset: 0x2E0CE91 VA: 0x2E0CD90
	|-List.Enumerator<RenderGraphDebugData.ResourceDebugData>.MoveNextRare
	|
	|-RVA: 0x2E0D050 Offset: 0x2E0D151 VA: 0x2E0D050
	|-List.Enumerator<RingCleaningUnitSelectMenu.GodParam>.MoveNextRare
	|
	|-RVA: 0x2E0D930 Offset: 0x2E0DA31 VA: 0x2E0D930
	|-List.Enumerator<ShadowUtility.Edge>.MoveNextRare
	|
	|-RVA: 0x2E0E010 Offset: 0x2E0E111 VA: 0x2E0E010
	|-List.Enumerator<SkillArray.Entity>.MoveNextRare
	|
	|-RVA: 0x2E0E660 Offset: 0x2E0E761 VA: 0x2E0E660
	|-List.Enumerator<TexturePacker_JsonArray.Frame>.MoveNextRare
	|
	|-RVA: 0x2E0E950 Offset: 0x2E0EA51 VA: 0x2E0E950
	|-List.Enumerator<TimeNotificationBehaviour.NotificationEntry>.MoveNextRare
	|
	|-RVA: 0x2E0EC20 Offset: 0x2E0ED21 VA: 0x2E0EC20
	|-List.Enumerator<UnitySynchronizationContext.WorkRequest>.MoveNextRare
	|
	|-RVA: 0x2E0EEE0 Offset: 0x2E0EFE1 VA: 0x2E0EEE0
	|-List.Enumerator<XmlSchemaObjectTable.XmlSchemaObjectEntry>.MoveNextRare
	|
	|-RVA: 0x2E0F1B0 Offset: 0x2E0F2B1 VA: 0x2E0F1B0
	|-List.Enumerator<AssetBundleBuildMap.AssetBundleEntry.AssetPathString>.MoveNextRare
	|
	|-RVA: 0x2E0F4F0 Offset: 0x2E0F5F1 VA: 0x2E0F4F0
	|-List.Enumerator<Detail.DataStore.DataStoreChangeMetaParamInt>.MoveNextRare
	|
	|-RVA: 0x2E0F800 Offset: 0x2E0F901 VA: 0x2E0F800
	|-List.Enumerator<Detail.DataStore.DataStoreDeleteParamInt>.MoveNextRare
	|
	|-RVA: 0x2E0FAD0 Offset: 0x2E0FBD1 VA: 0x2E0FAD0
	|-List.Enumerator<Detail.DataStore.DataStoreGetMetaParamInt>.MoveNextRare
	|
	|-RVA: 0x2E0FDD0 Offset: 0x2E0FED1 VA: 0x2E0FDD0
	|-List.Enumerator<Detail.DataStore.DataStoreMetaInfoInt>.MoveNextRare
	|
	|-RVA: 0x2E100D0 Offset: 0x2E101D1 VA: 0x2E100D0
	|-List.Enumerator<Detail.DataStore.DataStorePasswordInfoInt>.MoveNextRare
	|
	|-RVA: 0x2E10390 Offset: 0x2E10491 VA: 0x2E10390
	|-List.Enumerator<Detail.DataStore.DataStorePersistenceInfoInt>.MoveNextRare
	|
	|-RVA: 0x2E10680 Offset: 0x2E10781 VA: 0x2E10680
	|-List.Enumerator<Detail.DataStore.DataStorePreparePostParamInt>.MoveNextRare
	|
	|-RVA: 0x2E10970 Offset: 0x2E10A71 VA: 0x2E10970
	|-List.Enumerator<Detail.DataStore.DataStoreRateObjectParamInt>.MoveNextRare
	|
	|-RVA: 0x2E10C40 Offset: 0x2E10D41 VA: 0x2E10C40
	|-List.Enumerator<Detail.DataStore.DataStoreRatingInitParamInt>.MoveNextRare
	|
	|-RVA: 0x2E10EF0 Offset: 0x2E10FF1 VA: 0x2E10EF0
	|-List.Enumerator<Detail.DataStore.DataStoreRatingTargetInt>.MoveNextRare
	|
	|-RVA: 0x2E111D0 Offset: 0x2E112D1 VA: 0x2E111D0
	|-List.Enumerator<Detail.Ranking.RankingCachedResultInt>.MoveNextRare
	|
	|-RVA: 0x2E114A0 Offset: 0x2E115A1 VA: 0x2E114A0
	|-List.Enumerator<Detail.Ranking.RankingOrderParamInt>.MoveNextRare
	|
	|-RVA: 0x2E11780 Offset: 0x2E11881 VA: 0x2E11780
	|-List.Enumerator<Detail.Ranking.RankingRankDataInt>.MoveNextRare
	|
	|-RVA: 0x2E11A80 Offset: 0x2E11B81 VA: 0x2E11A80
	|-List.Enumerator<Detail.Ranking2.Ranking2ChartInfoInt>.MoveNextRare
	|
	|-RVA: 0x2E11DB0 Offset: 0x2E11EB1 VA: 0x2E11DB0
	|-List.Enumerator<Detail.Ranking2.Ranking2RankDataInt>.MoveNextRare
	|
	|-RVA: 0x2E12080 Offset: 0x2E12181 VA: 0x2E12080
	|-List.Enumerator<Detail.Ranking2.Ranking2ScoreDataInt>.MoveNextRare
	|
	|-RVA: 0x2E12350 Offset: 0x2E12451 VA: 0x2E12350
	|-List.Enumerator<Detail.Screening.ScreeningContextInfoInt>.MoveNextRare
	|
	|-RVA: 0x2E12620 Offset: 0x2E12721 VA: 0x2E12620
	|-List.Enumerator<Detail.Subscriber.SubscriberContentInt>.MoveNextRare
	|
	|-RVA: 0x2E12920 Offset: 0x2E12A21 VA: 0x2E12920
	|-List.Enumerator<Detail.Subscriber.SubscriberGetContentParamInt>.MoveNextRare
	|
	|-RVA: 0x2E12BE0 Offset: 0x2E12CE1 VA: 0x2E12BE0
	|-List.Enumerator<Detail.Subscriber.SubscriberUserStatusInfoInt>.MoveNextRare
	|
	|-RVA: 0x2E12EA0 Offset: 0x2E12FA1 VA: 0x2E12EA0
	|-List.Enumerator<Detail.Subscriber.SubscriberUserStatusParamInt>.MoveNextRare
	|
	|-RVA: 0x2E13150 Offset: 0x2E13251 VA: 0x2E13150
	|-List.Enumerator<Detail.Utility.IntegerSettings>.MoveNextRare
	|
	|-RVA: 0x2E13400 Offset: 0x2E13501 VA: 0x2E13400
	|-List.Enumerator<Detail.Utility.UniqueIdInfoInt>.MoveNextRare
	|
	|-RVA: 0x3499370 Offset: 0x3499471 VA: 0x3499370
	|-List.Enumerator<MapHistory.Rewind.LatestInspectorData>.MoveNextRare
	|
	|-RVA: 0x3499610 Offset: 0x3499711 VA: 0x3499610
	|-List.Enumerator<MapHistory.Rewind.WorkTerrainData>.MoveNextRare
	|
	|-RVA: 0x34998B0 Offset: 0x34999B1 VA: 0x34998B0
	|-List.Enumerator<MapSkill.AroundCalculator.Result>.MoveNextRare
	|
	|-RVA: 0x3499B90 Offset: 0x3499C91 VA: 0x3499B90
	|-List.Enumerator<TargetPositionCache.CacheCurve.Item>.MoveNextRare
	|
	|-RVA: 0x3499E50 Offset: 0x3499F51 VA: 0x3499E50
	|-List.Enumerator<TargetPositionCache.CacheEntry.RecordingItem>.MoveNextRare
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public T get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1D2BC30 Offset: 0x1D2BD31 VA: 0x1D2BC30
	|-List.Enumerator<IntervalTree.Entry<object>>.get_Current
	|
	|-RVA: 0x1D2BEF0 Offset: 0x1D2BFF1 VA: 0x1D2BEF0
	|-List.Enumerator<KeyValuePair<DateTime, object>>.get_Current
	|
	|-RVA: 0x1D2E200 Offset: 0x1D2E301 VA: 0x1D2E200
	|-List.Enumerator<KeyValuePair<Expression, Expression>>.get_Current
	|-List.Enumerator<KeyValuePair<object, object>>.get_Current
	|
	|-RVA: 0x1D2DC60 Offset: 0x1D2DD61 VA: 0x1D2DC60
	|-List.Enumerator<KeyValuePair<int, object>>.get_Current
	|
	|-RVA: 0x1D2DF40 Offset: 0x1D2E041 VA: 0x1D2DF40
	|-List.Enumerator<KeyValuePair<object, ValueTuple<int, DateTime, object>>>.get_Current
	|
	|-RVA: 0x2EB9730 Offset: 0x2EB9831 VA: 0x2EB9730
	|-List.Enumerator<List<int>>.get_Current
	|-List.Enumerator<StructDataArrayList<ChartVariableData>>.get_Current
	|-List.Enumerator<StructDataArrayList<EncountEquipData>>.get_Current
	|-List.Enumerator<StructDataArrayList<JobIntroData>>.get_Current
	|-List.Enumerator<StructDataArrayList<LaterTalkData>>.get_Current
	|-List.Enumerator<string[]>.get_Current
	|-List.Enumerator<AccessoryData>.get_Current
	|-List.Enumerator<AchieveData>.get_Current
	|-List.Enumerator<AnimalData>.get_Current
	|-List.Enumerator<AnimationClip>.get_Current
	|-List.Enumerator<Animator>.get_Current
	|-List.Enumerator<AssetTable>.get_Current
	|-List.Enumerator<BaseConverter>.get_Current
	|-List.Enumerator<BasicMenu>.get_Current
	|-List.Enumerator<BasicMenuItem>.get_Current
	|-List.Enumerator<Behaviour>.get_Current
	|-List.Enumerator<BranchLabel>.get_Current
	|-List.Enumerator<BuildTimeScopeBlock>.get_Current
	|-List.Enumerator<ByRefUpdater>.get_Current
	|-List.Enumerator<CapsuleCollider>.get_Current
	|-List.Enumerator<ChallengeData>.get_Current
	|-List.Enumerator<ChapterData>.get_Current
	|-List.Enumerator<ChartVariableData>.get_Current
	|-List.Enumerator<Collider>.get_Current
	|-List.Enumerator<DataStoreMetaInfo>.get_Current
	|-List.Enumerator<DebugUIHandlerIndirectToggle>.get_Current
	|-List.Enumerator<DebugUIHandlerValue>.get_Current
	|-List.Enumerator<DebugUIPrefabBundle>.get_Current
	|-List.Enumerator<Decorator>.get_Current
	|-List.Enumerator<DisposData>.get_Current
	|-List.Enumerator<EffectData>.get_Current
	|-List.Enumerator<EncountEquipData>.get_Current
	|-List.Enumerator<EncountRareMonayData>.get_Current
	|-List.Enumerator<EncountUnitData>.get_Current
	|-List.Enumerator<EncountWeaponCategoryData>.get_Current
	|-List.Enumerator<EndRollData>.get_Current
	|-List.Enumerator<ExceptionDispatchInfo>.get_Current
	|-List.Enumerator<Expression>.get_Current
	|-List.Enumerator<FileData>.get_Current
	|-List.Enumerator<FoodstuffData>.get_Current
	|-List.Enumerator<ForceTextureSetter>.get_Current
	|-List.Enumerator<ForecastFishData>.get_Current
	|-List.Enumerator<FriendListData>.get_Current
	|-List.Enumerator<GUILayoutEntry>.get_Current
	|-List.Enumerator<GameObject>.get_Current
	|-List.Enumerator<GmapSpot>.get_Current
	|-List.Enumerator<GodBondHolder>.get_Current
	|-List.Enumerator<GodData>.get_Current
	|-List.Enumerator<GodGrowthData>.get_Current
	|-List.Enumerator<GodUnit>.get_Current
	|-List.Enumerator<GotoStatement>.get_Current
	|-List.Enumerator<HelpItemList>.get_Current
	|-List.Enumerator<HubAccess>.get_Current
	|-List.Enumerator<HubAccessData>.get_Current
	|-List.Enumerator<HubDisposData>.get_Current
	|-List.Enumerator<HubFacilityData>.get_Current
	|-List.Enumerator<HubInvestmentAnimal>.get_Current
	|-List.Enumerator<HubInvestmentFoodstuff>.get_Current
	|-List.Enumerator<HubMoveData>.get_Current
	|-List.Enumerator<HubMoveState>.get_Current
	|-List.Enumerator<HubNationData>.get_Current
	|-List.Enumerator<HubRandomSet>.get_Current
	|-List.Enumerator<IAsyncLocal>.get_Current
	|-List.Enumerator<IContextProperty>.get_Current
	|-List.Enumerator<IDisposable>.get_Current
	|-List.Enumerator<IOverloadableMemberDescriptor>.get_Current
	|-List.Enumerator<IPAddress>.get_Current
	|-List.Enumerator<IResourceLocation>.get_Current
	|-List.Enumerator<IUpdateReceiver>.get_Current
	|-List.Enumerator<IUserDataDescriptor>.get_Current
	|-List.Enumerator<Image>.get_Current
	|-List.Enumerator<Instruction>.get_Current
	|-List.Enumerator<IntegratedSubsystem>.get_Current
	|-List.Enumerator<IntegratedSubsystemDescriptor>.get_Current
	|-List.Enumerator<ItemData>.get_Current
	|-List.Enumerator<JobData>.get_Current
	|-List.Enumerator<JobIntroData>.get_Current
	|-List.Enumerator<KeyHelpData>.get_Current
	|-List.Enumerator<LabelScopeInfo>.get_Current
	|-List.Enumerator<LaterTalkData>.get_Current
	|-List.Enumerator<Light2D>.get_Current
	|-List.Enumerator<MagicSignal>.get_Current
	|-List.Enumerator<MapBackup>.get_Current
	|-List.Enumerator<MapImageCoreBit>.get_Current
	|-List.Enumerator<MapInfoRoot>.get_Current
	|-List.Enumerator<MapInspector>.get_Current
	|-List.Enumerator<MapObject>.get_Current
	|-List.Enumerator<MascotAccData>.get_Current
	|-List.Enumerator<MascotColorChangeItemContent>.get_Current
	|-List.Enumerator<Material>.get_Current
	|-List.Enumerator<MaterialPropertyBlock>.get_Current
	|-List.Enumerator<MenuItem>.get_Current
	|-List.Enumerator<MethodInfo>.get_Current
	|-List.Enumerator<ModifierSpec>.get_Current
	|-List.Enumerator<MovieDefineData>.get_Current
	|-List.Enumerator<MuscleExerciseScoreData>.get_Current
	|-List.Enumerator<MusclePushUpAreaData>.get_Current
	|-List.Enumerator<MusclePushUpSpeedData>.get_Current
	|-List.Enumerator<MuscleSitUpFallData>.get_Current
	|-List.Enumerator<Note>.get_Current
	|-List.Enumerator<NotificationEvent>.get_Current
	|-List.Enumerator<NotificationEventCB>.get_Current
	|-List.Enumerator<object>.get_Current
	|-List.Enumerator<PersistentCall>.get_Current
	|-List.Enumerator<Phase>.get_Current
	|-List.Enumerator<PhotographDisposInfo>.get_Current
	|-List.Enumerator<PhotographPauseData>.get_Current
	|-List.Enumerator<PlayReportSendBase>.get_Current
	|-List.Enumerator<PrefetchedSignal>.get_Current
	|-List.Enumerator<ProfileCard>.get_Current
	|-List.Enumerator<Ranking2RankData>.get_Current
	|-List.Enumerator<RankingRankData>.get_Current
	|-List.Enumerator<RectTransform>.get_Current
	|-List.Enumerator<RelayStampData>.get_Current
	|-List.Enumerator<RenderGraphPass>.get_Current
	|-List.Enumerator<Renderer>.get_Current
	|-List.Enumerator<ResourceHandle>.get_Current
	|-List.Enumerator<ResourceLocationData>.get_Current
	|-List.Enumerator<RewardData>.get_Current
	|-List.Enumerator<RingData>.get_Current
	|-List.Enumerator<RuntimeElement>.get_Current
	|-List.Enumerator<ScriptableObject>.get_Current
	|-List.Enumerator<ScriptableRendererFeature>.get_Current
	|-List.Enumerator<SkillData>.get_Current
	|-List.Enumerator<SourceCode>.get_Current
	|-List.Enumerator<SourceRef>.get_Current
	|-List.Enumerator<SpringBone>.get_Current
	|-List.Enumerator<Statement>.get_Current
	|-List.Enumerator<string>.get_Current
	|-List.Enumerator<Task>.get_Current
	|-List.Enumerator<TextMeshProUGUI>.get_Current
	|-List.Enumerator<Thread>.get_Current
	|-List.Enumerator<TimelineClip>.get_Current
	|-List.Enumerator<TipsData>.get_Current
	|-List.Enumerator<Transform>.get_Current
	|-List.Enumerator<TypeIdentifier>.get_Current
	|-List.Enumerator<Unit>.get_Current
	|-List.Enumerator<UnitActor>.get_Current
	|-List.Enumerator<UnitInfoCharaImageMaskOffset>.get_Current
	|-List.Enumerator<UnitRing>.get_Current
	|-List.Enumerator<ValueCountController>.get_Current
	|-List.Enumerator<VersusMapEditCategoryContent>.get_Current
	|-List.Enumerator<VersusServerCasualMetaData>.get_Current
	|-List.Enumerator<VersusServerRankedMetaData>.get_Current
	|-List.Enumerator<VersusServerReplayMetaData>.get_Current
	|-List.Enumerator<Volume>.get_Current
	|-List.Enumerator<VolumeComponent>.get_Current
	|-List.Enumerator<WatchItem>.get_Current
	|-List.Enumerator<WeaponMask>.get_Current
	|-List.Enumerator<X509CertificateImpl>.get_Current
	|-List.Enumerator<XRPass>.get_Current
	|-List.Enumerator<AddressablesImpl.ResourceLocatorInfo>.get_Current
	|-List.Enumerator<AdhocAssetLoader.Asset>.get_Current
	|-List.Enumerator<AssetTable.Accessory>.get_Current
	|-List.Enumerator<BufferedGizmo.Segment>.get_Current
	|-List.Enumerator<CasualMap.ObjectData>.get_Current
	|-List.Enumerator<ChapterRecord.Record>.get_Current
	|-List.Enumerator<CinemachineCollider.VcamExtraState>.get_Current
	|-List.Enumerator<ClassChange.ChangeJobData>.get_Current
	|-List.Enumerator<ClassChangeJobMenuItemContent.WeaponLevelItem>.get_Current
	|-List.Enumerator<CombatViewerSettings.ViewerPhase>.get_Current
	|-List.Enumerator<ConstantBuffer.ConstantBufferBase>.get_Current
	|-List.Enumerator<DLCManager.MountData>.get_Current
	|-List.Enumerator<DebugUI.Panel>.get_Current
	|-List.Enumerator<DishSelectFoodInfoContent.FoodstuffObject>.get_Current
	|-List.Enumerator<DishSelectMenu.DishSelectMenuItem>.get_Current
	|-List.Enumerator<DishSelectMenuCategoryContent.CategoryObject>.get_Current
	|-List.Enumerator<DragonRideTargetGroup.ChainSEManager>.get_Current
	|-List.Enumerator<DynamicsSetup.ParseMessage>.get_Current
	|-List.Enumerator<EmittersConstraint.Pair>.get_Current
	|-List.Enumerator<ExtensionMethodsRegistry.UnresolvedGenericMethod>.get_Current
	|-List.Enumerator<FoodstuffMenu.FoodstuffMenuItem>.get_Current
	|-List.Enumerator<GameSaveDataHeaderReader.Handle>.get_Current
	|-List.Enumerator<GameSound.Handle>.get_Current
	|-List.Enumerator<GrassData.SpriteInfo>.get_Current
	|-List.Enumerator<HelpManager.Item>.get_Current
	|-List.Enumerator<HubMiniMap.IconData>.get_Current
	|-List.Enumerator<HubMiniMapCaptureParam.CaptureParam1>.get_Current
	|-List.Enumerator<IfStatement.IfBlock>.get_Current
	|-List.Enumerator<MapBattleInfoSequence.AttackInfo>.get_Current
	|-List.Enumerator<MapDispos.ActualData>.get_Current
	|-List.Enumerator<MapDispos.Pos>.get_Current
	|-List.Enumerator<MapEditData.UnitInfo>.get_Current
	|-List.Enumerator<MapImageTerrain.MinimapInfo>.get_Current
	|-List.Enumerator<MapPrefab.Entity>.get_Current
	|-List.Enumerator<MapTarget.Data>.get_Current
	|-List.Enumerator<MapTerrain.LayerData>.get_Current
	|-List.Enumerator<MapTerrain.OverlapData>.get_Current
	|-List.Enumerator<MapTerrainInfoAlignment.AlignMember>.get_Current
	|-List.Enumerator<MapTerrainInfoAlignment.InversionMember>.get_Current
	|-List.Enumerator<Mess.ReloadFileInfo>.get_Current
	|-List.Enumerator<MonoChunkStream.Chunk>.get_Current
	|-List.Enumerator<MuscleSquatSequence.RandomPack>.get_Current
	|-List.Enumerator<PhotographTopSequence.UnitAccDataSet>.get_Current
	|-List.Enumerator<ResourceManager.InstanceOperation>.get_Current
	|-List.Enumerator<RingListSequence.GodPageData>.get_Current
	|-List.Enumerator<RingListSequence.PageData>.get_Current
	|-List.Enumerator<RingListSequence.RingPageData>.get_Current
	|-List.Enumerator<SkillStack.Packet>.get_Current
	|-List.Enumerator<SolanelInfoMenuContent.SolanelUnit>.get_Current
	|-List.Enumerator<SoundSystem.ResultSoundLoad>.get_Current
	|-List.Enumerator<SoundSystem.SoundHandle>.get_Current
	|-List.Enumerator<StructHeader.Param>.get_Current
	|-List.Enumerator<TitleSequence.PedestalData>.get_Current
	|-List.Enumerator<UnitSelectMenu.UnitSelectMenuItem>.get_Current
	|-List.Enumerator<UnitStatusSetter.CapabilityValueParam>.get_Current
	|-List.Enumerator<UnitStatusSetter.SkillSetter>.get_Current
	|-List.Enumerator<UnitStatusSetter.WeaponLevelSetter>.get_Current
	|-List.Enumerator<EventDemoSequence.SoundEnv.EventNameData>.get_Current
	|-List.Enumerator<SoundWwise.SoundBankManager.BankHandle>.get_Current
	|-List.Enumerator<TitleSequence.ProcTitleCall.TitleCallData>.get_Current
	|-List.Enumerator<VersusSequence.VersusSequenceLocal.MetaDataPack>.get_Current
	|
	|-RVA: 0x1D2F250 Offset: 0x1D2F351 VA: 0x1D2F250
	|-List.Enumerator<CommonBattleSequence.Reliance<object>>.get_Current
	|
	|-RVA: 0x2EAE9B0 Offset: 0x2EAEAB1 VA: 0x2EAE9B0
	|-List.Enumerator<RenderGraphResourcePool.ResourceLogInfo<object>>.get_Current
	|
	|-RVA: 0x2EAF360 Offset: 0x2EAF461 VA: 0x2EAF360
	|-List.Enumerator<ValueTuple<int, object>>.get_Current
	|
	|-RVA: 0x2EAF620 Offset: 0x2EAF721 VA: 0x2EAF620
	|-List.Enumerator<ValueTuple<Int32Enum, int>>.get_Current
	|
	|-RVA: 0x2EAF8F0 Offset: 0x2EAF9F1 VA: 0x2EAF8F0
	|-List.Enumerator<ValueTuple<object, ValueTuple<object, int>>>.get_Current
	|-List.Enumerator<ValueTuple<object, ValueTuple<Type, int>>>.get_Current
	|
	|-RVA: 0x2EAFEC0 Offset: 0x2EAFFC1 VA: 0x2EAFEC0
	|-List.Enumerator<ValueTuple<object, int>>.get_Current
	|
	|-RVA: 0x2EB0900 Offset: 0x2EB0A01 VA: 0x2EB0900
	|-List.Enumerator<ValueTuple<Vector3, float>>.get_Current
	|
	|-RVA: 0x2EB0BB0 Offset: 0x2EB0CB1 VA: 0x2EB0BB0
	|-List.Enumerator<ValueTuple<object, Int32Enum, int>>.get_Current
	|
	|-RVA: 0x2EB1300 Offset: 0x2EB1401 VA: 0x2EB1300
	|-List.Enumerator<ValueTuple<object, int, int, int>>.get_Current
	|
	|-RVA: 0x2EB15B0 Offset: 0x2EB16B1 VA: 0x2EB15B0
	|-List.Enumerator<AnimatorClipInfo>.get_Current
	|
	|-RVA: 0x2EB1FF0 Offset: 0x2EB20F1 VA: 0x2EB1FF0
	|-List.Enumerator<AsyncOperationHandle>.get_Current
	|
	|-RVA: 0x2EB2760 Offset: 0x2EB2861 VA: 0x2EB2760
	|-List.Enumerator<BoneWeight>.get_Current
	|
	|-RVA: 0x2EB2B10 Offset: 0x2EB2C11 VA: 0x2EB2B10
	|-List.Enumerator<bool>.get_Current
	|
	|-RVA: 0x2EB2DC0 Offset: 0x2EB2EC1 VA: 0x2EB2DC0
	|-List.Enumerator<byte>.get_Current
	|
	|-RVA: 0x2EB3180 Offset: 0x2EB3281 VA: 0x2EB3180
	|-List.Enumerator<CameraInfo>.get_Current
	|
	|-RVA: 0x2EB3440 Offset: 0x2EB3541 VA: 0x2EB3440
	|-List.Enumerator<char>.get_Current
	|
	|-RVA: 0x2EB36F0 Offset: 0x2EB37F1 VA: 0x2EB36F0
	|-List.Enumerator<Color>.get_Current
	|
	|-RVA: 0x2EB3CD0 Offset: 0x2EB3DD1 VA: 0x2EB3CD0
	|-List.Enumerator<Color32>.get_Current
	|
	|-RVA: 0x2EB3F90 Offset: 0x2EB4091 VA: 0x2EB3F90
	|-List.Enumerator<ConstraintSource>.get_Current
	|
	|-RVA: 0x2EB4270 Offset: 0x2EB4371 VA: 0x2EB4270
	|-List.Enumerator<ContourVertex>.get_Current
	|
	|-RVA: 0x2EB4530 Offset: 0x2EB4631 VA: 0x2EB4530
	|-List.Enumerator<DataStoreRatingInfo>.get_Current
	|
	|-RVA: 0x2EB47E0 Offset: 0x2EB48E1 VA: 0x2EB47E0
	|-List.Enumerator<DataStoreResult>.get_Current
	|
	|-RVA: 0x2EB4A90 Offset: 0x2EB4B91 VA: 0x2EB4A90
	|-List.Enumerator<DateTime>.get_Current
	|
	|-RVA: 0x2EB4D40 Offset: 0x2EB4E41 VA: 0x2EB4D40
	|-List.Enumerator<DateTimeOffset>.get_Current
	|
	|-RVA: 0x2EB5000 Offset: 0x2EB5101 VA: 0x2EB5000
	|-List.Enumerator<Decimal>.get_Current
	|
	|-RVA: 0x2EB52E0 Offset: 0x2EB53E1 VA: 0x2EB52E0
	|-List.Enumerator<DiagnosticEvent>.get_Current
	|
	|-RVA: 0x2EB5590 Offset: 0x2EB5691 VA: 0x2EB5590
	|-List.Enumerator<double>.get_Current
	|
	|-RVA: 0x2EB5850 Offset: 0x2EB5951 VA: 0x2EB5850
	|-List.Enumerator<Friend>.get_Current
	|
	|-RVA: 0x2EB5B00 Offset: 0x2EB5C01 VA: 0x2EB5B00
	|-List.Enumerator<GlyphRect>.get_Current
	|
	|-RVA: 0x2EB5DC0 Offset: 0x2EB5EC1 VA: 0x2EB5DC0
	|-List.Enumerator<short>.get_Current
	|
	|-RVA: 0x2EB6360 Offset: 0x2EB6461 VA: 0x2EB6360
	|-List.Enumerator<int>.get_Current
	|
	|-RVA: 0x2EB7050 Offset: 0x2EB7151 VA: 0x2EB7050
	|-List.Enumerator<Int32Enum>.get_Current
	|-List.Enumerator<MapPanelActive.MeshIndex>.get_Current
	|
	|-RVA: 0x2EB7720 Offset: 0x2EB7821 VA: 0x2EB7720
	|-List.Enumerator<long>.get_Current
	|
	|-RVA: 0x2EB79D0 Offset: 0x2EB7AD1 VA: 0x2EB79D0
	|-List.Enumerator<IntPtr>.get_Current
	|
	|-RVA: 0x2EB7C90 Offset: 0x2EB7D91 VA: 0x2EB7C90
	|-List.Enumerator<InterpretedFrameInfo>.get_Current
	|
	|-RVA: 0x2EB7F60 Offset: 0x2EB8061 VA: 0x2EB7F60
	|-List.Enumerator<IntervalTreeNode>.get_Current
	|
	|-RVA: 0x2EB8320 Offset: 0x2EB8421 VA: 0x2EB8320
	|-List.Enumerator<LengthLimitProperties>.get_Current
	|
	|-RVA: 0x2EB8B00 Offset: 0x2EB8C01 VA: 0x2EB8B00
	|-List.Enumerator<MapPos>.get_Current
	|
	|-RVA: 0x2EB8DD0 Offset: 0x2EB8ED1 VA: 0x2EB8DD0
	|-List.Enumerator<Matrix4x4>.get_Current
	|
	|-RVA: 0x2EBAEA0 Offset: 0x2EBAFA1 VA: 0x2EBAEA0
	|-List.Enumerator<ObjectInitializationData>.get_Current
	|
	|-RVA: 0x2EBB290 Offset: 0x2EBB391 VA: 0x2EBB290
	|-List.Enumerator<PlayableBinding>.get_Current
	|
	|-RVA: 0x2EBB560 Offset: 0x2EBB661 VA: 0x2EBB560
	|-List.Enumerator<PlayerLoopSystem>.get_Current
	|
	|-RVA: 0x2EBB830 Offset: 0x2EBB931 VA: 0x2EBB830
	|-List.Enumerator<PlayerLoopSystemInternal>.get_Current
	|
	|-RVA: 0x2EBBF60 Offset: 0x2EBC061 VA: 0x2EBBF60
	|-List.Enumerator<RangePositionInfo>.get_Current
	|
	|-RVA: 0x2EBC220 Offset: 0x2EBC321 VA: 0x2EBC220
	|-List.Enumerator<Ranking2ChartInfoInput>.get_Current
	|
	|-RVA: 0x2EBC4E0 Offset: 0x2EBC5E1 VA: 0x2EBC4E0
	|-List.Enumerator<RaycastHit2D>.get_Current
	|
	|-RVA: 0x2EBC800 Offset: 0x2EBC901 VA: 0x2EBC800
	|-List.Enumerator<RaycastResult>.get_Current
	|
	|-RVA: 0x2EBCAE0 Offset: 0x2EBCBE1 VA: 0x2EBCAE0
	|-List.Enumerator<Rect>.get_Current
	|
	|-RVA: 0x2EBCEE0 Offset: 0x2EBCFE1 VA: 0x2EBCEE0
	|-List.Enumerator<RendererListHandle>.get_Current
	|
	|-RVA: 0x2EBD190 Offset: 0x2EBD291 VA: 0x2EBD190
	|-List.Enumerator<ResourceHandle>.get_Current
	|
	|-RVA: 0x2EBD440 Offset: 0x2EBD541 VA: 0x2EBD440
	|-List.Enumerator<sbyte>.get_Current
	|
	|-RVA: 0x2EBD6F0 Offset: 0x2EBD7F1 VA: 0x2EBD6F0
	|-List.Enumerator<ShaderTagId>.get_Current
	|
	|-RVA: 0x2EBDAA0 Offset: 0x2EBDBA1 VA: 0x2EBDAA0
	|-List.Enumerator<float>.get_Current
	|
	|-RVA: 0x2EBE0C0 Offset: 0x2EBE1C1 VA: 0x2EBE0C0
	|-List.Enumerator<SphericalHarmonicsL2>.get_Current
	|
	|-RVA: 0x2EBEB30 Offset: 0x2EBEC31 VA: 0x2EBEB30
	|-List.Enumerator<SubMeshDescriptor>.get_Current
	|
	|-RVA: 0x2EBF220 Offset: 0x2EBF321 VA: 0x2EBF220
	|-List.Enumerator<TablePair>.get_Current
	|
	|-RVA: 0x2E02BF0 Offset: 0x2E02CF1 VA: 0x2E02BF0
	|-List.Enumerator<TimeSpan>.get_Current
	|
	|-RVA: 0x2E02EB0 Offset: 0x2E02FB1 VA: 0x2E02EB0
	|-List.Enumerator<UICharInfo>.get_Current
	|
	|-RVA: 0x2E03150 Offset: 0x2E03251 VA: 0x2E03150
	|-List.Enumerator<UILineInfo>.get_Current
	|
	|-RVA: 0x2E03460 Offset: 0x2E03561 VA: 0x2E03460
	|-List.Enumerator<UIVertex>.get_Current
	|
	|-RVA: 0x2E03780 Offset: 0x2E03881 VA: 0x2E03780
	|-List.Enumerator<ushort>.get_Current
	|
	|-RVA: 0x2E03E20 Offset: 0x2E03F21 VA: 0x2E03E20
	|-List.Enumerator<uint>.get_Current
	|
	|-RVA: 0x2E047D0 Offset: 0x2E048D1 VA: 0x2E047D0
	|-List.Enumerator<ulong>.get_Current
	|
	|-RVA: 0x2E04A80 Offset: 0x2E04B81 VA: 0x2E04A80
	|-List.Enumerator<Vector2>.get_Current
	|
	|-RVA: 0x2E05000 Offset: 0x2E05101 VA: 0x2E05000
	|-List.Enumerator<Vector3>.get_Current
	|
	|-RVA: 0x2E05570 Offset: 0x2E05671 VA: 0x2E05570
	|-List.Enumerator<Vector4>.get_Current
	|
	|-RVA: 0x2E05810 Offset: 0x2E05911 VA: 0x2E05810
	|-List.Enumerator<VertexAttributeDescriptor>.get_Current
	|
	|-RVA: 0x2E05D50 Offset: 0x2E05E51 VA: 0x2E05D50
	|-List.Enumerator<X509ChainStatus>.get_Current
	|
	|-RVA: 0x2E06090 Offset: 0x2E06191 VA: 0x2E06090
	|-List.Enumerator<XRView>.get_Current
	|
	|-RVA: 0x2E066D0 Offset: 0x2E067D1 VA: 0x2E066D0
	|-List.Enumerator<AmiiboSequence.GainItemData>.get_Current
	|
	|-RVA: 0x2E069A0 Offset: 0x2E06AA1 VA: 0x2E069A0
	|-List.Enumerator<AnimationOutputWeightProcessor.WeightInfo>.get_Current
	|
	|-RVA: 0x2E06C60 Offset: 0x2E06D61 VA: 0x2E06C60
	|-List.Enumerator<ArenaOrderSequence.GodInfo>.get_Current
	|
	|-RVA: 0x2E06F30 Offset: 0x2E07031 VA: 0x2E06F30
	|-List.Enumerator<BattleInfo.SupportData>.get_Current
	|
	|-RVA: 0x2E07200 Offset: 0x2E07301 VA: 0x2E07200
	|-List.Enumerator<BeforeRenderHelper.OrderBlock>.get_Current
	|
	|-RVA: 0x2E074E0 Offset: 0x2E075E1 VA: 0x2E074E0
	|-List.Enumerator<Camera.RenderRequest>.get_Current
	|
	|-RVA: 0x2E077A0 Offset: 0x2E078A1 VA: 0x2E077A0
	|-List.Enumerator<CameraState.CustomBlendable>.get_Current
	|
	|-RVA: 0x2E07A60 Offset: 0x2E07B61 VA: 0x2E07A60
	|-List.Enumerator<CinemachineClearShot.Pair>.get_Current
	|
	|-RVA: 0x2E07D10 Offset: 0x2E07E11 VA: 0x2E07D10
	|-List.Enumerator<CinemachineStateDrivenCamera.HashPair>.get_Current
	|
	|-RVA: 0x2E08570 Offset: 0x2E08671 VA: 0x2E08570
	|-List.Enumerator<DelayedActionManager.DelegateInfo>.get_Current
	|
	|-RVA: 0x2E08830 Offset: 0x2E08931 VA: 0x2E08830
	|-List.Enumerator<Detail.AsyncResultInt>.get_Current
	|
	|-RVA: 0x2E08AE0 Offset: 0x2E08BE1 VA: 0x2E08AE0
	|-List.Enumerator<Detail.CppArray>.get_Current
	|
	|-RVA: 0x2E08DB0 Offset: 0x2E08EB1 VA: 0x2E08DB0
	|-List.Enumerator<Detail.NotificationEventInt>.get_Current
	|
	|-RVA: 0x2E09070 Offset: 0x2E09171 VA: 0x2E09070
	|-List.Enumerator<DragonRideTargetGroup.ChainParam>.get_Current
	|
	|-RVA: 0x2E09670 Offset: 0x2E09771 VA: 0x2E09670
	|-List.Enumerator<GmapPathAdjuster.TargetModel>.get_Current
	|
	|-RVA: 0x2E09940 Offset: 0x2E09A41 VA: 0x2E09940
	|-List.Enumerator<GmapSpotAdjuster.TargetModel>.get_Current
	|
	|-RVA: 0x2E09C10 Offset: 0x2E09D11 VA: 0x2E09C10
	|-List.Enumerator<HubFastTravel.Location>.get_Current
	|
	|-RVA: 0x2E09EE0 Offset: 0x2E09FE1 VA: 0x2E09EE0
	|-List.Enumerator<HubLensFlare.Flare>.get_Current
	|
	|-RVA: 0x2E0A1A0 Offset: 0x2E0A2A1 VA: 0x2E0A1A0
	|-List.Enumerator<InventoryPoolItemMenuContent.KindBgNameClass>.get_Current
	|
	|-RVA: 0x2E0A6D0 Offset: 0x2E0A7D1 VA: 0x2E0A6D0
	|-List.Enumerator<Map.Pos>.get_Current
	|
	|-RVA: 0x2E0A980 Offset: 0x2E0AA81 VA: 0x2E0A980
	|-List.Enumerator<MapImage.BackupTerrain>.get_Current
	|
	|-RVA: 0x2E0AC40 Offset: 0x2E0AD41 VA: 0x2E0AC40
	|-List.Enumerator<MapImageRange.Pos>.get_Current
	|
	|-RVA: 0x2E0B2C0 Offset: 0x2E0B3C1 VA: 0x2E0B2C0
	|-List.Enumerator<MapMind.Target>.get_Current
	|
	|-RVA: 0x2E0B580 Offset: 0x2E0B681 VA: 0x2E0B580
	|-List.Enumerator<MapPanelDebug.Entity>.get_Current
	|
	|-RVA: 0x2E0B830 Offset: 0x2E0B931 VA: 0x2E0B830
	|-List.Enumerator<NexRanking.Data>.get_Current
	|
	|-RVA: 0x2E0BAE0 Offset: 0x2E0BBE1 VA: 0x2E0BAE0
	|-List.Enumerator<NexVersus.RatingData>.get_Current
	|
	|-RVA: 0x2E0BDB0 Offset: 0x2E0BEB1 VA: 0x2E0BDB0
	|-List.Enumerator<PackedPlayModeBuildLogs.RuntimeBuildLog>.get_Current
	|
	|-RVA: 0x2E0C0D0 Offset: 0x2E0C1D1 VA: 0x2E0C0D0
	|-List.Enumerator<ParticleSystem.Particle>.get_Current
	|
	|-RVA: 0x2E0C850 Offset: 0x2E0C951 VA: 0x2E0C850
	|-List.Enumerator<RangeData.Offset>.get_Current
	|
	|-RVA: 0x2E0CB20 Offset: 0x2E0CC21 VA: 0x2E0CB20
	|-List.Enumerator<RenderGraphDebugData.PassDebugData>.get_Current
	|
	|-RVA: 0x2E0CDF0 Offset: 0x2E0CEF1 VA: 0x2E0CDF0
	|-List.Enumerator<RenderGraphDebugData.ResourceDebugData>.get_Current
	|
	|-RVA: 0x2E0D0B0 Offset: 0x2E0D1B1 VA: 0x2E0D0B0
	|-List.Enumerator<RingCleaningUnitSelectMenu.GodParam>.get_Current
	|
	|-RVA: 0x2E0D990 Offset: 0x2E0DA91 VA: 0x2E0D990
	|-List.Enumerator<ShadowUtility.Edge>.get_Current
	|
	|-RVA: 0x2E0E070 Offset: 0x2E0E171 VA: 0x2E0E070
	|-List.Enumerator<SkillArray.Entity>.get_Current
	|
	|-RVA: 0x2E0E6C0 Offset: 0x2E0E7C1 VA: 0x2E0E6C0
	|-List.Enumerator<TexturePacker_JsonArray.Frame>.get_Current
	|
	|-RVA: 0x2E0E9B0 Offset: 0x2E0EAB1 VA: 0x2E0E9B0
	|-List.Enumerator<TimeNotificationBehaviour.NotificationEntry>.get_Current
	|
	|-RVA: 0x2E0EC80 Offset: 0x2E0ED81 VA: 0x2E0EC80
	|-List.Enumerator<UnitySynchronizationContext.WorkRequest>.get_Current
	|
	|-RVA: 0x2E0EF40 Offset: 0x2E0F041 VA: 0x2E0EF40
	|-List.Enumerator<XmlSchemaObjectTable.XmlSchemaObjectEntry>.get_Current
	|
	|-RVA: 0x2E0F210 Offset: 0x2E0F311 VA: 0x2E0F210
	|-List.Enumerator<AssetBundleBuildMap.AssetBundleEntry.AssetPathString>.get_Current
	|
	|-RVA: 0x2E0F580 Offset: 0x2E0F681 VA: 0x2E0F580
	|-List.Enumerator<Detail.DataStore.DataStoreChangeMetaParamInt>.get_Current
	|
	|-RVA: 0x2E0F860 Offset: 0x2E0F961 VA: 0x2E0F860
	|-List.Enumerator<Detail.DataStore.DataStoreDeleteParamInt>.get_Current
	|
	|-RVA: 0x2E0FB30 Offset: 0x2E0FC31 VA: 0x2E0FB30
	|-List.Enumerator<Detail.DataStore.DataStoreGetMetaParamInt>.get_Current
	|
	|-RVA: 0x2E0FE50 Offset: 0x2E0FF51 VA: 0x2E0FE50
	|-List.Enumerator<Detail.DataStore.DataStoreMetaInfoInt>.get_Current
	|
	|-RVA: 0x2E10130 Offset: 0x2E10231 VA: 0x2E10130
	|-List.Enumerator<Detail.DataStore.DataStorePasswordInfoInt>.get_Current
	|
	|-RVA: 0x2E103F0 Offset: 0x2E104F1 VA: 0x2E103F0
	|-List.Enumerator<Detail.DataStore.DataStorePersistenceInfoInt>.get_Current
	|
	|-RVA: 0x2E10700 Offset: 0x2E10801 VA: 0x2E10700
	|-List.Enumerator<Detail.DataStore.DataStorePreparePostParamInt>.get_Current
	|
	|-RVA: 0x2E109D0 Offset: 0x2E10AD1 VA: 0x2E109D0
	|-List.Enumerator<Detail.DataStore.DataStoreRateObjectParamInt>.get_Current
	|
	|-RVA: 0x2E10CA0 Offset: 0x2E10DA1 VA: 0x2E10CA0
	|-List.Enumerator<Detail.DataStore.DataStoreRatingInitParamInt>.get_Current
	|
	|-RVA: 0x2E10F50 Offset: 0x2E11051 VA: 0x2E10F50
	|-List.Enumerator<Detail.DataStore.DataStoreRatingTargetInt>.get_Current
	|
	|-RVA: 0x2E11230 Offset: 0x2E11331 VA: 0x2E11230
	|-List.Enumerator<Detail.Ranking.RankingCachedResultInt>.get_Current
	|
	|-RVA: 0x2E11500 Offset: 0x2E11601 VA: 0x2E11500
	|-List.Enumerator<Detail.Ranking.RankingOrderParamInt>.get_Current
	|
	|-RVA: 0x2E117E0 Offset: 0x2E118E1 VA: 0x2E117E0
	|-List.Enumerator<Detail.Ranking.RankingRankDataInt>.get_Current
	|
	|-RVA: 0x2E11AF0 Offset: 0x2E11BF1 VA: 0x2E11AF0
	|-List.Enumerator<Detail.Ranking2.Ranking2ChartInfoInt>.get_Current
	|
	|-RVA: 0x2E11E10 Offset: 0x2E11F11 VA: 0x2E11E10
	|-List.Enumerator<Detail.Ranking2.Ranking2RankDataInt>.get_Current
	|
	|-RVA: 0x2E120E0 Offset: 0x2E121E1 VA: 0x2E120E0
	|-List.Enumerator<Detail.Ranking2.Ranking2ScoreDataInt>.get_Current
	|
	|-RVA: 0x2E123B0 Offset: 0x2E124B1 VA: 0x2E123B0
	|-List.Enumerator<Detail.Screening.ScreeningContextInfoInt>.get_Current
	|
	|-RVA: 0x2E12690 Offset: 0x2E12791 VA: 0x2E12690
	|-List.Enumerator<Detail.Subscriber.SubscriberContentInt>.get_Current
	|
	|-RVA: 0x2E12980 Offset: 0x2E12A81 VA: 0x2E12980
	|-List.Enumerator<Detail.Subscriber.SubscriberGetContentParamInt>.get_Current
	|
	|-RVA: 0x2E12C40 Offset: 0x2E12D41 VA: 0x2E12C40
	|-List.Enumerator<Detail.Subscriber.SubscriberUserStatusInfoInt>.get_Current
	|
	|-RVA: 0x2E12F00 Offset: 0x2E13001 VA: 0x2E12F00
	|-List.Enumerator<Detail.Subscriber.SubscriberUserStatusParamInt>.get_Current
	|
	|-RVA: 0x2E131B0 Offset: 0x2E132B1 VA: 0x2E131B0
	|-List.Enumerator<Detail.Utility.IntegerSettings>.get_Current
	|
	|-RVA: 0x2E13460 Offset: 0x2E13561 VA: 0x2E13460
	|-List.Enumerator<Detail.Utility.UniqueIdInfoInt>.get_Current
	|
	|-RVA: 0x34993D0 Offset: 0x34994D1 VA: 0x34993D0
	|-List.Enumerator<MapHistory.Rewind.LatestInspectorData>.get_Current
	|
	|-RVA: 0x3499670 Offset: 0x3499771 VA: 0x3499670
	|-List.Enumerator<MapHistory.Rewind.WorkTerrainData>.get_Current
	|
	|-RVA: 0x3499910 Offset: 0x3499A11 VA: 0x3499910
	|-List.Enumerator<MapSkill.AroundCalculator.Result>.get_Current
	|
	|-RVA: 0x3499BF0 Offset: 0x3499CF1 VA: 0x3499BF0
	|-List.Enumerator<TargetPositionCache.CacheCurve.Item>.get_Current
	|
	|-RVA: 0x3499EB0 Offset: 0x3499FB1 VA: 0x3499EB0
	|-List.Enumerator<TargetPositionCache.CacheEntry.RecordingItem>.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1D2BC50 Offset: 0x1D2BD51 VA: 0x1D2BC50
	|-List.Enumerator<IntervalTree.Entry<object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D2BF00 Offset: 0x1D2C001 VA: 0x1D2BF00
	|-List.Enumerator<KeyValuePair<DateTime, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D2DC70 Offset: 0x1D2DD71 VA: 0x1D2DC70
	|-List.Enumerator<KeyValuePair<int, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D2DF60 Offset: 0x1D2E061 VA: 0x1D2DF60
	|-List.Enumerator<KeyValuePair<object, ValueTuple<int, DateTime, object>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D2E210 Offset: 0x1D2E311 VA: 0x1D2E210
	|-List.Enumerator<KeyValuePair<object, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D2F270 Offset: 0x1D2F371 VA: 0x1D2F270
	|-List.Enumerator<CommonBattleSequence.Reliance<object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2EAE9C0 Offset: 0x2EAEAC1 VA: 0x2EAE9C0
	|-List.Enumerator<RenderGraphResourcePool.ResourceLogInfo<object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2EAF370 Offset: 0x2EAF471 VA: 0x2EAF370
	|-List.Enumerator<ValueTuple<int, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2EAF630 Offset: 0x2EAF731 VA: 0x2EAF630
	|-List.Enumerator<ValueTuple<Int32Enum, int>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2EAF910 Offset: 0x2EAFA11 VA: 0x2EAF910
	|-List.Enumerator<ValueTuple<object, ValueTuple<object, int>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2EAFED0 Offset: 0x2EAFFD1 VA: 0x2EAFED0
	|-List.Enumerator<ValueTuple<object, int>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2EB0910 Offset: 0x2EB0A11 VA: 0x2EB0910
	|-List.Enumerator<ValueTuple<Vector3, float>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2EB0BC0 Offset: 0x2EB0CC1 VA: 0x2EB0BC0
	|-List.Enumerator<ValueTuple<object, Int32Enum, int>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2EB1320 Offset: 0x2EB1421 VA: 0x2EB1320
	|-List.Enumerator<ValueTuple<object, int, int, int>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2EB15C0 Offset: 0x2EB16C1 VA: 0x2EB15C0
	|-List.Enumerator<AnimatorClipInfo>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2EB2010 Offset: 0x2EB2111 VA: 0x2EB2010
	|-List.Enumerator<AsyncOperationHandle>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2EB2780 Offset: 0x2EB2881 VA: 0x2EB2780
	|-List.Enumerator<BoneWeight>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2EB2B20 Offset: 0x2EB2C21 VA: 0x2EB2B20
	|-List.Enumerator<bool>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2EB2DD0 Offset: 0x2EB2ED1 VA: 0x2EB2DD0
	|-List.Enumerator<byte>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2EB3190 Offset: 0x2EB3291 VA: 0x2EB3190
	|-List.Enumerator<CameraInfo>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2EB3450 Offset: 0x2EB3551 VA: 0x2EB3450
	|-List.Enumerator<char>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2EB3700 Offset: 0x2EB3801 VA: 0x2EB3700
	|-List.Enumerator<Color>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2EB3CE0 Offset: 0x2EB3DE1 VA: 0x2EB3CE0
	|-List.Enumerator<Color32>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2EB3FA0 Offset: 0x2EB40A1 VA: 0x2EB3FA0
	|-List.Enumerator<ConstraintSource>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2EB4290 Offset: 0x2EB4391 VA: 0x2EB4290
	|-List.Enumerator<ContourVertex>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2EB4550 Offset: 0x2EB4651 VA: 0x2EB4550
	|-List.Enumerator<DataStoreRatingInfo>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2EB47F0 Offset: 0x2EB48F1 VA: 0x2EB47F0
	|-List.Enumerator<DataStoreResult>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2EB4AA0 Offset: 0x2EB4BA1 VA: 0x2EB4AA0
	|-List.Enumerator<DateTime>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2EB4D50 Offset: 0x2EB4E51 VA: 0x2EB4D50
	|-List.Enumerator<DateTimeOffset>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2EB5010 Offset: 0x2EB5111 VA: 0x2EB5010
	|-List.Enumerator<Decimal>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2EB5300 Offset: 0x2EB5401 VA: 0x2EB5300
	|-List.Enumerator<DiagnosticEvent>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2EB55A0 Offset: 0x2EB56A1 VA: 0x2EB55A0
	|-List.Enumerator<double>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2EB5870 Offset: 0x2EB5971 VA: 0x2EB5870
	|-List.Enumerator<Friend>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2EB5B10 Offset: 0x2EB5C11 VA: 0x2EB5B10
	|-List.Enumerator<GlyphRect>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2EB5DD0 Offset: 0x2EB5ED1 VA: 0x2EB5DD0
	|-List.Enumerator<short>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2EB6370 Offset: 0x2EB6471 VA: 0x2EB6370
	|-List.Enumerator<int>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2EB7060 Offset: 0x2EB7161 VA: 0x2EB7060
	|-List.Enumerator<Int32Enum>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2EB7730 Offset: 0x2EB7831 VA: 0x2EB7730
	|-List.Enumerator<long>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2EB79E0 Offset: 0x2EB7AE1 VA: 0x2EB79E0
	|-List.Enumerator<IntPtr>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2EB7CA0 Offset: 0x2EB7DA1 VA: 0x2EB7CA0
	|-List.Enumerator<InterpretedFrameInfo>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2EB7F80 Offset: 0x2EB8081 VA: 0x2EB7F80
	|-List.Enumerator<IntervalTreeNode>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2EB8330 Offset: 0x2EB8431 VA: 0x2EB8330
	|-List.Enumerator<LengthLimitProperties>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2EB8B10 Offset: 0x2EB8C11 VA: 0x2EB8B10
	|-List.Enumerator<MapPos>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2EB8E00 Offset: 0x2EB8F01 VA: 0x2EB8E00
	|-List.Enumerator<Matrix4x4>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2EB9740 Offset: 0x2EB9841 VA: 0x2EB9740
	|-List.Enumerator<object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2EBAEC0 Offset: 0x2EBAFC1 VA: 0x2EBAEC0
	|-List.Enumerator<ObjectInitializationData>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2EBB2B0 Offset: 0x2EBB3B1 VA: 0x2EBB2B0
	|-List.Enumerator<PlayableBinding>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2EBB580 Offset: 0x2EBB681 VA: 0x2EBB580
	|-List.Enumerator<PlayerLoopSystem>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2EBB850 Offset: 0x2EBB951 VA: 0x2EBB850
	|-List.Enumerator<PlayerLoopSystemInternal>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2EBBF70 Offset: 0x2EBC071 VA: 0x2EBBF70
	|-List.Enumerator<RangePositionInfo>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2EBC230 Offset: 0x2EBC331 VA: 0x2EBC230
	|-List.Enumerator<Ranking2ChartInfoInput>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2EBC510 Offset: 0x2EBC611 VA: 0x2EBC510
	|-List.Enumerator<RaycastHit2D>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2EBC830 Offset: 0x2EBC931 VA: 0x2EBC830
	|-List.Enumerator<RaycastResult>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2EBCAF0 Offset: 0x2EBCBF1 VA: 0x2EBCAF0
	|-List.Enumerator<Rect>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2EBCEF0 Offset: 0x2EBCFF1 VA: 0x2EBCEF0
	|-List.Enumerator<RendererListHandle>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2EBD1A0 Offset: 0x2EBD2A1 VA: 0x2EBD1A0
	|-List.Enumerator<ResourceHandle>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2EBD450 Offset: 0x2EBD551 VA: 0x2EBD450
	|-List.Enumerator<sbyte>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2EBD700 Offset: 0x2EBD801 VA: 0x2EBD700
	|-List.Enumerator<ShaderTagId>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2EBDAB0 Offset: 0x2EBDBB1 VA: 0x2EBDAB0
	|-List.Enumerator<float>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2EBE110 Offset: 0x2EBE211 VA: 0x2EBE110
	|-List.Enumerator<SphericalHarmonicsL2>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2EBEB50 Offset: 0x2EBEC51 VA: 0x2EBEB50
	|-List.Enumerator<SubMeshDescriptor>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2EBF230 Offset: 0x2EBF331 VA: 0x2EBF230
	|-List.Enumerator<TablePair>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2E02C00 Offset: 0x2E02D01 VA: 0x2E02C00
	|-List.Enumerator<TimeSpan>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2E02EC0 Offset: 0x2E02FC1 VA: 0x2E02EC0
	|-List.Enumerator<UICharInfo>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2E03160 Offset: 0x2E03261 VA: 0x2E03160
	|-List.Enumerator<UILineInfo>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2E034B0 Offset: 0x2E035B1 VA: 0x2E034B0
	|-List.Enumerator<UIVertex>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2E03790 Offset: 0x2E03891 VA: 0x2E03790
	|-List.Enumerator<ushort>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2E03E30 Offset: 0x2E03F31 VA: 0x2E03E30
	|-List.Enumerator<uint>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2E047E0 Offset: 0x2E048E1 VA: 0x2E047E0
	|-List.Enumerator<ulong>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2E04A90 Offset: 0x2E04B91 VA: 0x2E04A90
	|-List.Enumerator<Vector2>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2E05010 Offset: 0x2E05111 VA: 0x2E05010
	|-List.Enumerator<Vector3>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2E05580 Offset: 0x2E05681 VA: 0x2E05580
	|-List.Enumerator<Vector4>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2E05820 Offset: 0x2E05921 VA: 0x2E05820
	|-List.Enumerator<VertexAttributeDescriptor>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2E05D60 Offset: 0x2E05E61 VA: 0x2E05D60
	|-List.Enumerator<X509ChainStatus>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2E060B0 Offset: 0x2E061B1 VA: 0x2E060B0
	|-List.Enumerator<XRView>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2E066E0 Offset: 0x2E067E1 VA: 0x2E066E0
	|-List.Enumerator<AmiiboSequence.GainItemData>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2E069C0 Offset: 0x2E06AC1 VA: 0x2E069C0
	|-List.Enumerator<AnimationOutputWeightProcessor.WeightInfo>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2E06C70 Offset: 0x2E06D71 VA: 0x2E06C70
	|-List.Enumerator<ArenaOrderSequence.GodInfo>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2E06F40 Offset: 0x2E07041 VA: 0x2E06F40
	|-List.Enumerator<BattleInfo.SupportData>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2E07210 Offset: 0x2E07311 VA: 0x2E07210
	|-List.Enumerator<BeforeRenderHelper.OrderBlock>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2E07500 Offset: 0x2E07601 VA: 0x2E07500
	|-List.Enumerator<Camera.RenderRequest>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2E077B0 Offset: 0x2E078B1 VA: 0x2E077B0
	|-List.Enumerator<CameraState.CustomBlendable>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2E07A70 Offset: 0x2E07B71 VA: 0x2E07A70
	|-List.Enumerator<CinemachineClearShot.Pair>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2E07D20 Offset: 0x2E07E21 VA: 0x2E07D20
	|-List.Enumerator<CinemachineStateDrivenCamera.HashPair>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2E08590 Offset: 0x2E08691 VA: 0x2E08590
	|-List.Enumerator<DelayedActionManager.DelegateInfo>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2E08850 Offset: 0x2E08951 VA: 0x2E08850
	|-List.Enumerator<Detail.AsyncResultInt>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2E08AF0 Offset: 0x2E08BF1 VA: 0x2E08AF0
	|-List.Enumerator<Detail.CppArray>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2E08DD0 Offset: 0x2E08ED1 VA: 0x2E08DD0
	|-List.Enumerator<Detail.NotificationEventInt>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2E09080 Offset: 0x2E09181 VA: 0x2E09080
	|-List.Enumerator<DragonRideTargetGroup.ChainParam>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2E09690 Offset: 0x2E09791 VA: 0x2E09690
	|-List.Enumerator<GmapPathAdjuster.TargetModel>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2E09960 Offset: 0x2E09A61 VA: 0x2E09960
	|-List.Enumerator<GmapSpotAdjuster.TargetModel>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2E09C30 Offset: 0x2E09D31 VA: 0x2E09C30
	|-List.Enumerator<HubFastTravel.Location>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2E09F00 Offset: 0x2E0A001 VA: 0x2E09F00
	|-List.Enumerator<HubLensFlare.Flare>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2E0A1B0 Offset: 0x2E0A2B1 VA: 0x2E0A1B0
	|-List.Enumerator<InventoryPoolItemMenuContent.KindBgNameClass>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2E0A6E0 Offset: 0x2E0A7E1 VA: 0x2E0A6E0
	|-List.Enumerator<Map.Pos>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2E0A990 Offset: 0x2E0AA91 VA: 0x2E0A990
	|-List.Enumerator<MapImage.BackupTerrain>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2E0AC50 Offset: 0x2E0AD51 VA: 0x2E0AC50
	|-List.Enumerator<MapImageRange.Pos>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2E0B2E0 Offset: 0x2E0B3E1 VA: 0x2E0B2E0
	|-List.Enumerator<MapMind.Target>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2E0B5A0 Offset: 0x2E0B6A1 VA: 0x2E0B5A0
	|-List.Enumerator<MapPanelDebug.Entity>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2E0B840 Offset: 0x2E0B941 VA: 0x2E0B840
	|-List.Enumerator<NexRanking.Data>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2E0BAF0 Offset: 0x2E0BBF1 VA: 0x2E0BAF0
	|-List.Enumerator<NexVersus.RatingData>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2E0BDC0 Offset: 0x2E0BEC1 VA: 0x2E0BDC0
	|-List.Enumerator<PackedPlayModeBuildLogs.RuntimeBuildLog>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2E0C0F0 Offset: 0x2E0C1F1 VA: 0x2E0C0F0
	|-List.Enumerator<ParticleSystem.Particle>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2E0C860 Offset: 0x2E0C961 VA: 0x2E0C860
	|-List.Enumerator<RangeData.Offset>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2E0CB40 Offset: 0x2E0CC41 VA: 0x2E0CB40
	|-List.Enumerator<RenderGraphDebugData.PassDebugData>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2E0CE10 Offset: 0x2E0CF11 VA: 0x2E0CE10
	|-List.Enumerator<RenderGraphDebugData.ResourceDebugData>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2E0D0C0 Offset: 0x2E0D1C1 VA: 0x2E0D0C0
	|-List.Enumerator<RingCleaningUnitSelectMenu.GodParam>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2E0D9B0 Offset: 0x2E0DAB1 VA: 0x2E0D9B0
	|-List.Enumerator<ShadowUtility.Edge>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2E0E080 Offset: 0x2E0E181 VA: 0x2E0E080
	|-List.Enumerator<SkillArray.Entity>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2E0E6F0 Offset: 0x2E0E7F1 VA: 0x2E0E6F0
	|-List.Enumerator<TexturePacker_JsonArray.Frame>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2E0E9D0 Offset: 0x2E0EAD1 VA: 0x2E0E9D0
	|-List.Enumerator<TimeNotificationBehaviour.NotificationEntry>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2E0ECA0 Offset: 0x2E0EDA1 VA: 0x2E0ECA0
	|-List.Enumerator<UnitySynchronizationContext.WorkRequest>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2E0EF50 Offset: 0x2E0F051 VA: 0x2E0EF50
	|-List.Enumerator<XmlSchemaObjectTable.XmlSchemaObjectEntry>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2E0F220 Offset: 0x2E0F321 VA: 0x2E0F220
	|-List.Enumerator<AssetBundleBuildMap.AssetBundleEntry.AssetPathString>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2E0F5A0 Offset: 0x2E0F6A1 VA: 0x2E0F5A0
	|-List.Enumerator<Detail.DataStore.DataStoreChangeMetaParamInt>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2E0F870 Offset: 0x2E0F971 VA: 0x2E0F870
	|-List.Enumerator<Detail.DataStore.DataStoreDeleteParamInt>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2E0FB50 Offset: 0x2E0FC51 VA: 0x2E0FB50
	|-List.Enumerator<Detail.DataStore.DataStoreGetMetaParamInt>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2E0FE70 Offset: 0x2E0FF71 VA: 0x2E0FE70
	|-List.Enumerator<Detail.DataStore.DataStoreMetaInfoInt>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2E10150 Offset: 0x2E10251 VA: 0x2E10150
	|-List.Enumerator<Detail.DataStore.DataStorePasswordInfoInt>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2E10410 Offset: 0x2E10511 VA: 0x2E10410
	|-List.Enumerator<Detail.DataStore.DataStorePersistenceInfoInt>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2E10720 Offset: 0x2E10821 VA: 0x2E10720
	|-List.Enumerator<Detail.DataStore.DataStorePreparePostParamInt>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2E109E0 Offset: 0x2E10AE1 VA: 0x2E109E0
	|-List.Enumerator<Detail.DataStore.DataStoreRateObjectParamInt>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2E10CC0 Offset: 0x2E10DC1 VA: 0x2E10CC0
	|-List.Enumerator<Detail.DataStore.DataStoreRatingInitParamInt>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2E10F60 Offset: 0x2E11061 VA: 0x2E10F60
	|-List.Enumerator<Detail.DataStore.DataStoreRatingTargetInt>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2E11260 Offset: 0x2E11361 VA: 0x2E11260
	|-List.Enumerator<Detail.Ranking.RankingCachedResultInt>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2E11510 Offset: 0x2E11611 VA: 0x2E11510
	|-List.Enumerator<Detail.Ranking.RankingOrderParamInt>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2E11810 Offset: 0x2E11911 VA: 0x2E11810
	|-List.Enumerator<Detail.Ranking.RankingRankDataInt>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2E11B30 Offset: 0x2E11C31 VA: 0x2E11B30
	|-List.Enumerator<Detail.Ranking2.Ranking2ChartInfoInt>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2E11E40 Offset: 0x2E11F41 VA: 0x2E11E40
	|-List.Enumerator<Detail.Ranking2.Ranking2RankDataInt>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2E120F0 Offset: 0x2E121F1 VA: 0x2E120F0
	|-List.Enumerator<Detail.Ranking2.Ranking2ScoreDataInt>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2E123D0 Offset: 0x2E124D1 VA: 0x2E123D0
	|-List.Enumerator<Detail.Screening.ScreeningContextInfoInt>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2E126C0 Offset: 0x2E127C1 VA: 0x2E126C0
	|-List.Enumerator<Detail.Subscriber.SubscriberContentInt>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2E129A0 Offset: 0x2E12AA1 VA: 0x2E129A0
	|-List.Enumerator<Detail.Subscriber.SubscriberGetContentParamInt>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2E12C60 Offset: 0x2E12D61 VA: 0x2E12C60
	|-List.Enumerator<Detail.Subscriber.SubscriberUserStatusInfoInt>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2E12F20 Offset: 0x2E13021 VA: 0x2E12F20
	|-List.Enumerator<Detail.Subscriber.SubscriberUserStatusParamInt>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2E131C0 Offset: 0x2E132C1 VA: 0x2E131C0
	|-List.Enumerator<Detail.Utility.IntegerSettings>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2E13470 Offset: 0x2E13571 VA: 0x2E13470
	|-List.Enumerator<Detail.Utility.UniqueIdInfoInt>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x34993E0 Offset: 0x34994E1 VA: 0x34993E0
	|-List.Enumerator<MapHistory.Rewind.LatestInspectorData>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x3499680 Offset: 0x3499781 VA: 0x3499680
	|-List.Enumerator<MapHistory.Rewind.WorkTerrainData>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x3499920 Offset: 0x3499A21 VA: 0x3499920
	|-List.Enumerator<MapSkill.AroundCalculator.Result>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x3499C10 Offset: 0x3499D11 VA: 0x3499C10
	|-List.Enumerator<TargetPositionCache.CacheCurve.Item>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x3499EE0 Offset: 0x3499FE1 VA: 0x3499EE0
	|-List.Enumerator<TargetPositionCache.CacheEntry.RecordingItem>.System.Collections.IEnumerator.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1D2BD10 Offset: 0x1D2BE11 VA: 0x1D2BD10
	|-List.Enumerator<IntervalTree.Entry<object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D2BFE0 Offset: 0x1D2C0E1 VA: 0x1D2BFE0
	|-List.Enumerator<KeyValuePair<DateTime, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D2DD50 Offset: 0x1D2DE51 VA: 0x1D2DD50
	|-List.Enumerator<KeyValuePair<int, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D2E020 Offset: 0x1D2E121 VA: 0x1D2E020
	|-List.Enumerator<KeyValuePair<object, ValueTuple<int, DateTime, object>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D2E2F0 Offset: 0x1D2E3F1 VA: 0x1D2E2F0
	|-List.Enumerator<KeyValuePair<object, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D2F330 Offset: 0x1D2F431 VA: 0x1D2F330
	|-List.Enumerator<CommonBattleSequence.Reliance<object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2EAEAA0 Offset: 0x2EAEBA1 VA: 0x2EAEAA0
	|-List.Enumerator<RenderGraphResourcePool.ResourceLogInfo<object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2EAF450 Offset: 0x2EAF551 VA: 0x2EAF450
	|-List.Enumerator<ValueTuple<int, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2EAF700 Offset: 0x2EAF801 VA: 0x2EAF700
	|-List.Enumerator<ValueTuple<Int32Enum, int>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2EAF9D0 Offset: 0x2EAFAD1 VA: 0x2EAF9D0
	|-List.Enumerator<ValueTuple<object, ValueTuple<object, int>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2EAFFB0 Offset: 0x2EB00B1 VA: 0x2EAFFB0
	|-List.Enumerator<ValueTuple<object, int>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2EB09D0 Offset: 0x2EB0AD1 VA: 0x2EB09D0
	|-List.Enumerator<ValueTuple<Vector3, float>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2EB0CA0 Offset: 0x2EB0DA1 VA: 0x2EB0CA0
	|-List.Enumerator<ValueTuple<object, Int32Enum, int>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2EB13E0 Offset: 0x2EB14E1 VA: 0x2EB13E0
	|-List.Enumerator<ValueTuple<object, int, int, int>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2EB1690 Offset: 0x2EB1791 VA: 0x2EB1690
	|-List.Enumerator<AnimatorClipInfo>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2EB20D0 Offset: 0x2EB21D1 VA: 0x2EB20D0
	|-List.Enumerator<AsyncOperationHandle>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2EB2840 Offset: 0x2EB2941 VA: 0x2EB2840
	|-List.Enumerator<BoneWeight>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2EB2BF0 Offset: 0x2EB2CF1 VA: 0x2EB2BF0
	|-List.Enumerator<bool>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2EB2EA0 Offset: 0x2EB2FA1 VA: 0x2EB2EA0
	|-List.Enumerator<byte>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2EB3270 Offset: 0x2EB3371 VA: 0x2EB3270
	|-List.Enumerator<CameraInfo>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2EB3520 Offset: 0x2EB3621 VA: 0x2EB3520
	|-List.Enumerator<char>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2EB37C0 Offset: 0x2EB38C1 VA: 0x2EB37C0
	|-List.Enumerator<Color>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2EB3DB0 Offset: 0x2EB3EB1 VA: 0x2EB3DB0
	|-List.Enumerator<Color32>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2EB4080 Offset: 0x2EB4181 VA: 0x2EB4080
	|-List.Enumerator<ConstraintSource>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2EB4350 Offset: 0x2EB4451 VA: 0x2EB4350
	|-List.Enumerator<ContourVertex>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2EB4610 Offset: 0x2EB4711 VA: 0x2EB4610
	|-List.Enumerator<DataStoreRatingInfo>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2EB48C0 Offset: 0x2EB49C1 VA: 0x2EB48C0
	|-List.Enumerator<DataStoreResult>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2EB4B70 Offset: 0x2EB4C71 VA: 0x2EB4B70
	|-List.Enumerator<DateTime>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2EB4E30 Offset: 0x2EB4F31 VA: 0x2EB4E30
	|-List.Enumerator<DateTimeOffset>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2EB50F0 Offset: 0x2EB51F1 VA: 0x2EB50F0
	|-List.Enumerator<Decimal>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2EB53C0 Offset: 0x2EB54C1 VA: 0x2EB53C0
	|-List.Enumerator<DiagnosticEvent>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2EB5670 Offset: 0x2EB5771 VA: 0x2EB5670
	|-List.Enumerator<double>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2EB5930 Offset: 0x2EB5A31 VA: 0x2EB5930
	|-List.Enumerator<Friend>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2EB5BF0 Offset: 0x2EB5CF1 VA: 0x2EB5BF0
	|-List.Enumerator<GlyphRect>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2EB5EA0 Offset: 0x2EB5FA1 VA: 0x2EB5EA0
	|-List.Enumerator<short>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2EB6440 Offset: 0x2EB6541 VA: 0x2EB6440
	|-List.Enumerator<int>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2EB7130 Offset: 0x2EB7231 VA: 0x2EB7130
	|-List.Enumerator<Int32Enum>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2EB7800 Offset: 0x2EB7901 VA: 0x2EB7800
	|-List.Enumerator<long>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2EB7AB0 Offset: 0x2EB7BB1 VA: 0x2EB7AB0
	|-List.Enumerator<IntPtr>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2EB7D80 Offset: 0x2EB7E81 VA: 0x2EB7D80
	|-List.Enumerator<InterpretedFrameInfo>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2EB8040 Offset: 0x2EB8141 VA: 0x2EB8040
	|-List.Enumerator<IntervalTreeNode>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2EB8400 Offset: 0x2EB8501 VA: 0x2EB8400
	|-List.Enumerator<LengthLimitProperties>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2EB8BE0 Offset: 0x2EB8CE1 VA: 0x2EB8BE0
	|-List.Enumerator<MapPos>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2EB8ED0 Offset: 0x2EB8FD1 VA: 0x2EB8ED0
	|-List.Enumerator<Matrix4x4>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2EB97C0 Offset: 0x2EB98C1 VA: 0x2EB97C0
	|-List.Enumerator<object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2EBAF80 Offset: 0x2EBB081 VA: 0x2EBAF80
	|-List.Enumerator<ObjectInitializationData>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2EBB370 Offset: 0x2EBB471 VA: 0x2EBB370
	|-List.Enumerator<PlayableBinding>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2EBB640 Offset: 0x2EBB741 VA: 0x2EBB640
	|-List.Enumerator<PlayerLoopSystem>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2EBB910 Offset: 0x2EBBA11 VA: 0x2EBB910
	|-List.Enumerator<PlayerLoopSystemInternal>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2EBC050 Offset: 0x2EBC151 VA: 0x2EBC050
	|-List.Enumerator<RangePositionInfo>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2EBC300 Offset: 0x2EBC401 VA: 0x2EBC300
	|-List.Enumerator<Ranking2ChartInfoInput>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2EBC5E0 Offset: 0x2EBC6E1 VA: 0x2EBC5E0
	|-List.Enumerator<RaycastHit2D>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2EBC900 Offset: 0x2EBCA01 VA: 0x2EBC900
	|-List.Enumerator<RaycastResult>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2EBCBB0 Offset: 0x2EBCCB1 VA: 0x2EBCBB0
	|-List.Enumerator<Rect>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2EBCFC0 Offset: 0x2EBD0C1 VA: 0x2EBCFC0
	|-List.Enumerator<RendererListHandle>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2EBD270 Offset: 0x2EBD371 VA: 0x2EBD270
	|-List.Enumerator<ResourceHandle>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2EBD520 Offset: 0x2EBD621 VA: 0x2EBD520
	|-List.Enumerator<sbyte>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2EBD7D0 Offset: 0x2EBD8D1 VA: 0x2EBD7D0
	|-List.Enumerator<ShaderTagId>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2EBDB80 Offset: 0x2EBDC81 VA: 0x2EBDB80
	|-List.Enumerator<float>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2EBE200 Offset: 0x2EBE301 VA: 0x2EBE200
	|-List.Enumerator<SphericalHarmonicsL2>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2EBEC10 Offset: 0x2EBED11 VA: 0x2EBEC10
	|-List.Enumerator<SubMeshDescriptor>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2EBF310 Offset: 0x2EBF411 VA: 0x2EBF310
	|-List.Enumerator<TablePair>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2E02CD0 Offset: 0x2E02DD1 VA: 0x2E02CD0
	|-List.Enumerator<TimeSpan>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2E02F80 Offset: 0x2E03081 VA: 0x2E02F80
	|-List.Enumerator<UICharInfo>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2E03240 Offset: 0x2E03341 VA: 0x2E03240
	|-List.Enumerator<UILineInfo>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2E035A0 Offset: 0x2E036A1 VA: 0x2E035A0
	|-List.Enumerator<UIVertex>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2E03860 Offset: 0x2E03961 VA: 0x2E03860
	|-List.Enumerator<ushort>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2E03F00 Offset: 0x2E04001 VA: 0x2E03F00
	|-List.Enumerator<uint>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2E048B0 Offset: 0x2E049B1 VA: 0x2E048B0
	|-List.Enumerator<ulong>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2E04B60 Offset: 0x2E04C61 VA: 0x2E04B60
	|-List.Enumerator<Vector2>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2E050D0 Offset: 0x2E051D1 VA: 0x2E050D0
	|-List.Enumerator<Vector3>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2E05640 Offset: 0x2E05741 VA: 0x2E05640
	|-List.Enumerator<Vector4>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2E05900 Offset: 0x2E05A01 VA: 0x2E05900
	|-List.Enumerator<VertexAttributeDescriptor>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2E05E40 Offset: 0x2E05F41 VA: 0x2E05E40
	|-List.Enumerator<X509ChainStatus>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2E06170 Offset: 0x2E06271 VA: 0x2E06170
	|-List.Enumerator<XRView>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2E067C0 Offset: 0x2E068C1 VA: 0x2E067C0
	|-List.Enumerator<AmiiboSequence.GainItemData>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2E06A80 Offset: 0x2E06B81 VA: 0x2E06A80
	|-List.Enumerator<AnimationOutputWeightProcessor.WeightInfo>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2E06D50 Offset: 0x2E06E51 VA: 0x2E06D50
	|-List.Enumerator<ArenaOrderSequence.GodInfo>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2E07020 Offset: 0x2E07121 VA: 0x2E07020
	|-List.Enumerator<BattleInfo.SupportData>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2E072F0 Offset: 0x2E073F1 VA: 0x2E072F0
	|-List.Enumerator<BeforeRenderHelper.OrderBlock>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2E075C0 Offset: 0x2E076C1 VA: 0x2E075C0
	|-List.Enumerator<Camera.RenderRequest>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2E07890 Offset: 0x2E07991 VA: 0x2E07890
	|-List.Enumerator<CameraState.CustomBlendable>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2E07B40 Offset: 0x2E07C41 VA: 0x2E07B40
	|-List.Enumerator<CinemachineClearShot.Pair>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2E07DF0 Offset: 0x2E07EF1 VA: 0x2E07DF0
	|-List.Enumerator<CinemachineStateDrivenCamera.HashPair>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2E08650 Offset: 0x2E08751 VA: 0x2E08650
	|-List.Enumerator<DelayedActionManager.DelegateInfo>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2E08910 Offset: 0x2E08A11 VA: 0x2E08910
	|-List.Enumerator<Detail.AsyncResultInt>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2E08BD0 Offset: 0x2E08CD1 VA: 0x2E08BD0
	|-List.Enumerator<Detail.CppArray>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2E08E90 Offset: 0x2E08F91 VA: 0x2E08E90
	|-List.Enumerator<Detail.NotificationEventInt>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2E09160 Offset: 0x2E09261 VA: 0x2E09160
	|-List.Enumerator<DragonRideTargetGroup.ChainParam>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2E09750 Offset: 0x2E09851 VA: 0x2E09750
	|-List.Enumerator<GmapPathAdjuster.TargetModel>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2E09A20 Offset: 0x2E09B21 VA: 0x2E09A20
	|-List.Enumerator<GmapSpotAdjuster.TargetModel>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2E09CF0 Offset: 0x2E09DF1 VA: 0x2E09CF0
	|-List.Enumerator<HubFastTravel.Location>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2E09FC0 Offset: 0x2E0A0C1 VA: 0x2E09FC0
	|-List.Enumerator<HubLensFlare.Flare>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2E0A290 Offset: 0x2E0A391 VA: 0x2E0A290
	|-List.Enumerator<InventoryPoolItemMenuContent.KindBgNameClass>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2E0A7B0 Offset: 0x2E0A8B1 VA: 0x2E0A7B0
	|-List.Enumerator<Map.Pos>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2E0AA70 Offset: 0x2E0AB71 VA: 0x2E0AA70
	|-List.Enumerator<MapImage.BackupTerrain>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2E0AD20 Offset: 0x2E0AE21 VA: 0x2E0AD20
	|-List.Enumerator<MapImageRange.Pos>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2E0B3A0 Offset: 0x2E0B4A1 VA: 0x2E0B3A0
	|-List.Enumerator<MapMind.Target>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2E0B660 Offset: 0x2E0B761 VA: 0x2E0B660
	|-List.Enumerator<MapPanelDebug.Entity>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2E0B910 Offset: 0x2E0BA11 VA: 0x2E0B910
	|-List.Enumerator<NexRanking.Data>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2E0BBD0 Offset: 0x2E0BCD1 VA: 0x2E0BBD0
	|-List.Enumerator<NexVersus.RatingData>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2E0BEA0 Offset: 0x2E0BFA1 VA: 0x2E0BEA0
	|-List.Enumerator<PackedPlayModeBuildLogs.RuntimeBuildLog>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2E0C1B0 Offset: 0x2E0C2B1 VA: 0x2E0C1B0
	|-List.Enumerator<ParticleSystem.Particle>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2E0C930 Offset: 0x2E0CA31 VA: 0x2E0C930
	|-List.Enumerator<RangeData.Offset>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2E0CC00 Offset: 0x2E0CD01 VA: 0x2E0CC00
	|-List.Enumerator<RenderGraphDebugData.PassDebugData>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2E0CED0 Offset: 0x2E0CFD1 VA: 0x2E0CED0
	|-List.Enumerator<RenderGraphDebugData.ResourceDebugData>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2E0D1A0 Offset: 0x2E0D2A1 VA: 0x2E0D1A0
	|-List.Enumerator<RingCleaningUnitSelectMenu.GodParam>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2E0DA70 Offset: 0x2E0DB71 VA: 0x2E0DA70
	|-List.Enumerator<ShadowUtility.Edge>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2E0E150 Offset: 0x2E0E251 VA: 0x2E0E150
	|-List.Enumerator<SkillArray.Entity>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2E0E7C0 Offset: 0x2E0E8C1 VA: 0x2E0E7C0
	|-List.Enumerator<TexturePacker_JsonArray.Frame>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2E0EA90 Offset: 0x2E0EB91 VA: 0x2E0EA90
	|-List.Enumerator<TimeNotificationBehaviour.NotificationEntry>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2E0ED60 Offset: 0x2E0EE61 VA: 0x2E0ED60
	|-List.Enumerator<UnitySynchronizationContext.WorkRequest>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2E0F030 Offset: 0x2E0F131 VA: 0x2E0F030
	|-List.Enumerator<XmlSchemaObjectTable.XmlSchemaObjectEntry>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2E0F300 Offset: 0x2E0F401 VA: 0x2E0F300
	|-List.Enumerator<AssetBundleBuildMap.AssetBundleEntry.AssetPathString>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2E0F660 Offset: 0x2E0F761 VA: 0x2E0F660
	|-List.Enumerator<Detail.DataStore.DataStoreChangeMetaParamInt>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2E0F950 Offset: 0x2E0FA51 VA: 0x2E0F950
	|-List.Enumerator<Detail.DataStore.DataStoreDeleteParamInt>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2E0FC10 Offset: 0x2E0FD11 VA: 0x2E0FC10
	|-List.Enumerator<Detail.DataStore.DataStoreGetMetaParamInt>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2E0FF30 Offset: 0x2E10031 VA: 0x2E0FF30
	|-List.Enumerator<Detail.DataStore.DataStoreMetaInfoInt>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2E10210 Offset: 0x2E10311 VA: 0x2E10210
	|-List.Enumerator<Detail.DataStore.DataStorePasswordInfoInt>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2E104D0 Offset: 0x2E105D1 VA: 0x2E104D0
	|-List.Enumerator<Detail.DataStore.DataStorePersistenceInfoInt>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2E107E0 Offset: 0x2E108E1 VA: 0x2E107E0
	|-List.Enumerator<Detail.DataStore.DataStorePreparePostParamInt>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2E10AC0 Offset: 0x2E10BC1 VA: 0x2E10AC0
	|-List.Enumerator<Detail.DataStore.DataStoreRateObjectParamInt>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2E10D80 Offset: 0x2E10E81 VA: 0x2E10D80
	|-List.Enumerator<Detail.DataStore.DataStoreRatingInitParamInt>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2E11040 Offset: 0x2E11141 VA: 0x2E11040
	|-List.Enumerator<Detail.DataStore.DataStoreRatingTargetInt>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2E11330 Offset: 0x2E11431 VA: 0x2E11330
	|-List.Enumerator<Detail.Ranking.RankingCachedResultInt>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2E115F0 Offset: 0x2E116F1 VA: 0x2E115F0
	|-List.Enumerator<Detail.Ranking.RankingOrderParamInt>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2E118E0 Offset: 0x2E119E1 VA: 0x2E118E0
	|-List.Enumerator<Detail.Ranking.RankingRankDataInt>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2E11C10 Offset: 0x2E11D11 VA: 0x2E11C10
	|-List.Enumerator<Detail.Ranking2.Ranking2ChartInfoInt>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2E11F10 Offset: 0x2E12011 VA: 0x2E11F10
	|-List.Enumerator<Detail.Ranking2.Ranking2RankDataInt>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2E121D0 Offset: 0x2E122D1 VA: 0x2E121D0
	|-List.Enumerator<Detail.Ranking2.Ranking2ScoreDataInt>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2E12490 Offset: 0x2E12591 VA: 0x2E12490
	|-List.Enumerator<Detail.Screening.ScreeningContextInfoInt>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2E12790 Offset: 0x2E12891 VA: 0x2E12790
	|-List.Enumerator<Detail.Subscriber.SubscriberContentInt>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2E12A60 Offset: 0x2E12B61 VA: 0x2E12A60
	|-List.Enumerator<Detail.Subscriber.SubscriberGetContentParamInt>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2E12D20 Offset: 0x2E12E21 VA: 0x2E12D20
	|-List.Enumerator<Detail.Subscriber.SubscriberUserStatusInfoInt>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2E12FE0 Offset: 0x2E130E1 VA: 0x2E12FE0
	|-List.Enumerator<Detail.Subscriber.SubscriberUserStatusParamInt>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2E13290 Offset: 0x2E13391 VA: 0x2E13290
	|-List.Enumerator<Detail.Utility.IntegerSettings>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2E13550 Offset: 0x2E13651 VA: 0x2E13550
	|-List.Enumerator<Detail.Utility.UniqueIdInfoInt>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x3499490 Offset: 0x3499591 VA: 0x3499490
	|-List.Enumerator<MapHistory.Rewind.LatestInspectorData>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x3499730 Offset: 0x3499831 VA: 0x3499730
	|-List.Enumerator<MapHistory.Rewind.WorkTerrainData>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x3499A00 Offset: 0x3499B01 VA: 0x3499A00
	|-List.Enumerator<MapSkill.AroundCalculator.Result>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x3499CD0 Offset: 0x3499DD1 VA: 0x3499CD0
	|-List.Enumerator<TargetPositionCache.CacheCurve.Item>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x3499FB0 Offset: 0x349A0B1 VA: 0x3499FB0
	|-List.Enumerator<TargetPositionCache.CacheEntry.RecordingItem>.System.Collections.IEnumerator.Reset
	*/
}

