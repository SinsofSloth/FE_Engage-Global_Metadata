// Namespace: System.Collections.ObjectModel
[DebuggerDisplayAttribute] // RVA: 0x477320 Offset: 0x477421 VA: 0x477320
[DebuggerTypeProxyAttribute] // RVA: 0x477320 Offset: 0x477421 VA: 0x477320
[DefaultMemberAttribute] // RVA: 0x477320 Offset: 0x477421 VA: 0x477320
[ComVisibleAttribute] // RVA: 0x477320 Offset: 0x477421 VA: 0x477320
[Serializable]
public class ReadOnlyCollection<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IList, ICollection, IReadOnlyList<T>, IReadOnlyCollection<T> // TypeDefIndex: 1386
{
	// Fields
	private IList<T> list; // 0x0
	private object _syncRoot; // 0x0

	// Properties
	public int Count { get; }
	public T Item { get; }
	private bool System.Collections.Generic.ICollection<T>.IsReadOnly { get; }
	private T System.Collections.Generic.IList<T>.Item { get; set; }
	private bool System.Collections.ICollection.IsSynchronized { get; }
	private object System.Collections.ICollection.SyncRoot { get; }
	private bool System.Collections.IList.IsReadOnly { get; }
	private object System.Collections.IList.Item { get; set; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(IList<T> list) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3467380 Offset: 0x3467481 VA: 0x3467380
	|-ReadOnlyCollection<IntervalTree.Entry<object>>..ctor
	|
	|-RVA: 0x3468440 Offset: 0x3468541 VA: 0x3468440
	|-ReadOnlyCollection<KeyValuePair<DateTime, object>>..ctor
	|
	|-RVA: 0x3469430 Offset: 0x3469531 VA: 0x3469430
	|-ReadOnlyCollection<KeyValuePair<int, object>>..ctor
	|
	|-RVA: 0x346A420 Offset: 0x346A521 VA: 0x346A420
	|-ReadOnlyCollection<KeyValuePair<object, ValueTuple<int, DateTime, object>>>..ctor
	|
	|-RVA: 0x346B4E0 Offset: 0x346B5E1 VA: 0x346B4E0
	|-ReadOnlyCollection<KeyValuePair<object, object>>..ctor
	|
	|-RVA: 0x346C4D0 Offset: 0x346C5D1 VA: 0x346C4D0
	|-ReadOnlyCollection<CommonBattleSequence.Reliance<object>>..ctor
	|
	|-RVA: 0x346D590 Offset: 0x346D691 VA: 0x346D590
	|-ReadOnlyCollection<RenderGraphResourcePool.ResourceLogInfo<object>>..ctor
	|
	|-RVA: 0x346E580 Offset: 0x346E681 VA: 0x346E580
	|-ReadOnlyCollection<ValueTuple<int, object>>..ctor
	|
	|-RVA: 0x346F570 Offset: 0x346F671 VA: 0x346F570
	|-ReadOnlyCollection<ValueTuple<Int32Enum, int>>..ctor
	|
	|-RVA: 0x3470550 Offset: 0x3470651 VA: 0x3470550
	|-ReadOnlyCollection<ValueTuple<object, ValueTuple<object, int>>>..ctor
	|
	|-RVA: 0x3471610 Offset: 0x3471711 VA: 0x3471610
	|-ReadOnlyCollection<ValueTuple<object, int>>..ctor
	|
	|-RVA: 0x3472600 Offset: 0x3472701 VA: 0x3472600
	|-ReadOnlyCollection<ValueTuple<Vector3, float>>..ctor
	|
	|-RVA: 0x3473620 Offset: 0x3473721 VA: 0x3473620
	|-ReadOnlyCollection<ValueTuple<object, Int32Enum, int>>..ctor
	|
	|-RVA: 0x3474610 Offset: 0x3474711 VA: 0x3474610
	|-ReadOnlyCollection<ValueTuple<object, int, int, int>>..ctor
	|
	|-RVA: 0x34756D0 Offset: 0x34757D1 VA: 0x34756D0
	|-ReadOnlyCollection<AnimatorClipInfo>..ctor
	|
	|-RVA: 0x3B22450 Offset: 0x3B22551 VA: 0x3B22450
	|-ReadOnlyCollection<AsyncOperationHandle>..ctor
	|
	|-RVA: 0x3B23510 Offset: 0x3B23611 VA: 0x3B23510
	|-ReadOnlyCollection<BoneWeight>..ctor
	|
	|-RVA: 0x3B245D0 Offset: 0x3B246D1 VA: 0x3B245D0
	|-ReadOnlyCollection<bool>..ctor
	|
	|-RVA: 0x3B255C0 Offset: 0x3B256C1 VA: 0x3B255C0
	|-ReadOnlyCollection<byte>..ctor
	|
	|-RVA: 0x3B265A0 Offset: 0x3B266A1 VA: 0x3B265A0
	|-ReadOnlyCollection<CameraInfo>..ctor
	|
	|-RVA: 0x3B27590 Offset: 0x3B27691 VA: 0x3B27590
	|-ReadOnlyCollection<char>..ctor
	|
	|-RVA: 0x3B28570 Offset: 0x3B28671 VA: 0x3B28570
	|-ReadOnlyCollection<Color>..ctor
	|
	|-RVA: 0x3B29590 Offset: 0x3B29691 VA: 0x3B29590
	|-ReadOnlyCollection<Color32>..ctor
	|
	|-RVA: 0x3B2A5B0 Offset: 0x3B2A6B1 VA: 0x3B2A5B0
	|-ReadOnlyCollection<ConstraintSource>..ctor
	|
	|-RVA: 0x3B2B5A0 Offset: 0x3B2B6A1 VA: 0x3B2B5A0
	|-ReadOnlyCollection<ContourVertex>..ctor
	|
	|-RVA: 0x3B2C660 Offset: 0x3B2C761 VA: 0x3B2C660
	|-ReadOnlyCollection<CustomAttributeNamedArgument>..ctor
	|
	|-RVA: 0x3B2D720 Offset: 0x3B2D821 VA: 0x3B2D720
	|-ReadOnlyCollection<CustomAttributeTypedArgument>..ctor
	|
	|-RVA: 0x3B2E710 Offset: 0x3B2E811 VA: 0x3B2E710
	|-ReadOnlyCollection<DataStoreRatingInfo>..ctor
	|
	|-RVA: 0x3B2F7D0 Offset: 0x3B2F8D1 VA: 0x3B2F7D0
	|-ReadOnlyCollection<DataStoreResult>..ctor
	|
	|-RVA: 0x3B307B0 Offset: 0x3B308B1 VA: 0x3B307B0
	|-ReadOnlyCollection<DateTime>..ctor
	|
	|-RVA: 0x3B31790 Offset: 0x3B31891 VA: 0x3B31790
	|-ReadOnlyCollection<DateTimeOffset>..ctor
	|
	|-RVA: 0x3B32780 Offset: 0x3B32881 VA: 0x3B32780
	|-ReadOnlyCollection<Decimal>..ctor
	|
	|-RVA: 0x3B33770 Offset: 0x3B33871 VA: 0x3B33770
	|-ReadOnlyCollection<DiagnosticEvent>..ctor
	|
	|-RVA: 0x3B348A0 Offset: 0x3B349A1 VA: 0x3B348A0
	|-ReadOnlyCollection<double>..ctor
	|
	|-RVA: 0x3B41B00 Offset: 0x3B41C01 VA: 0x3B41B00
	|-ReadOnlyCollection<Exception>..ctor
	|-ReadOnlyCollection<ExceptionDispatchInfo>..ctor
	|-ReadOnlyCollection<Expression>..ctor
	|-ReadOnlyCollection<object>..ctor
	|-ReadOnlyCollection<TimeZoneInfo>..ctor
	|
	|-RVA: 0x3B35880 Offset: 0x3B35981 VA: 0x3B35880
	|-ReadOnlyCollection<Friend>..ctor
	|
	|-RVA: 0x3B369B0 Offset: 0x3B36AB1 VA: 0x3B369B0
	|-ReadOnlyCollection<GlyphRect>..ctor
	|
	|-RVA: 0x3B379A0 Offset: 0x3B37AA1 VA: 0x3B379A0
	|-ReadOnlyCollection<short>..ctor
	|
	|-RVA: 0x3B38980 Offset: 0x3B38A81 VA: 0x3B38980
	|-ReadOnlyCollection<int>..ctor
	|
	|-RVA: 0x3B39960 Offset: 0x3B39A61 VA: 0x3B39960
	|-ReadOnlyCollection<Int32Enum>..ctor
	|
	|-RVA: 0x3B3A940 Offset: 0x3B3AA41 VA: 0x3B3A940
	|-ReadOnlyCollection<long>..ctor
	|
	|-RVA: 0x3B3B920 Offset: 0x3B3BA21 VA: 0x3B3B920
	|-ReadOnlyCollection<IntPtr>..ctor
	|
	|-RVA: 0x3B3C900 Offset: 0x3B3CA01 VA: 0x3B3C900
	|-ReadOnlyCollection<InterpretedFrameInfo>..ctor
	|
	|-RVA: 0x3B3D8F0 Offset: 0x3B3D9F1 VA: 0x3B3D8F0
	|-ReadOnlyCollection<IntervalTreeNode>..ctor
	|
	|-RVA: 0x3B3E9B0 Offset: 0x3B3EAB1 VA: 0x3B3E9B0
	|-ReadOnlyCollection<LengthLimitProperties>..ctor
	|
	|-RVA: 0x3B3F990 Offset: 0x3B3FA91 VA: 0x3B3F990
	|-ReadOnlyCollection<MapPos>..ctor
	|
	|-RVA: 0x3B40970 Offset: 0x3B40A71 VA: 0x3B40970
	|-ReadOnlyCollection<Matrix4x4>..ctor
	|
	|-RVA: 0x3B429F0 Offset: 0x3B42AF1 VA: 0x3B429F0
	|-ReadOnlyCollection<ObjectInitializationData>..ctor
	|
	|-RVA: 0x3B43B20 Offset: 0x3B43C21 VA: 0x3B43B20
	|-ReadOnlyCollection<PlayableBinding>..ctor
	|
	|-RVA: 0x3B44BE0 Offset: 0x3B44CE1 VA: 0x3B44BE0
	|-ReadOnlyCollection<PlayerLoopSystem>..ctor
	|
	|-RVA: 0x3B45D00 Offset: 0x3B45E01 VA: 0x3B45D00
	|-ReadOnlyCollection<PlayerLoopSystemInternal>..ctor
	|
	|-RVA: 0x3B46E20 Offset: 0x3B46F21 VA: 0x3B46E20
	|-ReadOnlyCollection<RangePositionInfo>..ctor
	|
	|-RVA: 0x3B47E10 Offset: 0x3B47F11 VA: 0x3B47E10
	|-ReadOnlyCollection<Ranking2ChartInfoInput>..ctor
	|
	|-RVA: 0x3B48DF0 Offset: 0x3B48EF1 VA: 0x3B48DF0
	|-ReadOnlyCollection<RaycastHit2D>..ctor
	|
	|-RVA: 0x3B49F50 Offset: 0x3B4A051 VA: 0x3B49F50
	|-ReadOnlyCollection<RaycastResult>..ctor
	|
	|-RVA: 0x3B4B1A0 Offset: 0x3B4B2A1 VA: 0x3B4B1A0
	|-ReadOnlyCollection<Rect>..ctor
	|
	|-RVA: 0x3B4C1C0 Offset: 0x3B4C2C1 VA: 0x3B4C1C0
	|-ReadOnlyCollection<RendererListHandle>..ctor
	|
	|-RVA: 0x3B4D1A0 Offset: 0x3B4D2A1 VA: 0x3B4D1A0
	|-ReadOnlyCollection<ResourceHandle>..ctor
	|
	|-RVA: 0x3AAE860 Offset: 0x3AAE961 VA: 0x3AAE860
	|-ReadOnlyCollection<sbyte>..ctor
	|
	|-RVA: 0x3AAF840 Offset: 0x3AAF941 VA: 0x3AAF840
	|-ReadOnlyCollection<ShaderTagId>..ctor
	|
	|-RVA: 0x3AB0860 Offset: 0x3AB0961 VA: 0x3AB0860
	|-ReadOnlyCollection<float>..ctor
	|
	|-RVA: 0x3AB1840 Offset: 0x3AB1941 VA: 0x3AB1840
	|-ReadOnlyCollection<SphericalHarmonicsL2>..ctor
	|
	|-RVA: 0x3AB2C30 Offset: 0x3AB2D31 VA: 0x3AB2C30
	|-ReadOnlyCollection<SubMeshDescriptor>..ctor
	|
	|-RVA: 0x3AB3D60 Offset: 0x3AB3E61 VA: 0x3AB3D60
	|-ReadOnlyCollection<TablePair>..ctor
	|
	|-RVA: 0x3AB4D50 Offset: 0x3AB4E51 VA: 0x3AB4D50
	|-ReadOnlyCollection<TimeSpan>..ctor
	|
	|-RVA: 0x3AB5D30 Offset: 0x3AB5E31 VA: 0x3AB5D30
	|-ReadOnlyCollection<UICharInfo>..ctor
	|
	|-RVA: 0x3AB6D50 Offset: 0x3AB6E51 VA: 0x3AB6D50
	|-ReadOnlyCollection<UILineInfo>..ctor
	|
	|-RVA: 0x3AB7D40 Offset: 0x3AB7E41 VA: 0x3AB7D40
	|-ReadOnlyCollection<UIVertex>..ctor
	|
	|-RVA: 0x3AB9130 Offset: 0x3AB9231 VA: 0x3AB9130
	|-ReadOnlyCollection<ushort>..ctor
	|
	|-RVA: 0x3ABA110 Offset: 0x3ABA211 VA: 0x3ABA110
	|-ReadOnlyCollection<uint>..ctor
	|
	|-RVA: 0x3ABB0F0 Offset: 0x3ABB1F1 VA: 0x3ABB0F0
	|-ReadOnlyCollection<ulong>..ctor
	|
	|-RVA: 0x3ABC0D0 Offset: 0x3ABC1D1 VA: 0x3ABC0D0
	|-ReadOnlyCollection<Vector2>..ctor
	|
	|-RVA: 0x3ABD0D0 Offset: 0x3ABD1D1 VA: 0x3ABD0D0
	|-ReadOnlyCollection<Vector3>..ctor
	|
	|-RVA: 0x3ABE0F0 Offset: 0x3ABE1F1 VA: 0x3ABE0F0
	|-ReadOnlyCollection<Vector4>..ctor
	|
	|-RVA: 0x3ABF110 Offset: 0x3ABF211 VA: 0x3ABF110
	|-ReadOnlyCollection<VertexAttributeDescriptor>..ctor
	|
	|-RVA: 0x3AC0100 Offset: 0x3AC0201 VA: 0x3AC0100
	|-ReadOnlyCollection<X509ChainStatus>..ctor
	|
	|-RVA: 0x3AC10F0 Offset: 0x3AC11F1 VA: 0x3AC10F0
	|-ReadOnlyCollection<XRView>..ctor
	|
	|-RVA: 0x3AC2210 Offset: 0x3AC2311 VA: 0x3AC2210
	|-ReadOnlyCollection<AICrossfire.PositionTable>..ctor
	|
	|-RVA: 0x3AC3240 Offset: 0x3AC3341 VA: 0x3AC3240
	|-ReadOnlyCollection<AmiiboSequence.GainItemData>..ctor
	|
	|-RVA: 0x3AC4230 Offset: 0x3AC4331 VA: 0x3AC4230
	|-ReadOnlyCollection<AnimationOutputWeightProcessor.WeightInfo>..ctor
	|
	|-RVA: 0x3AC5350 Offset: 0x3AC5451 VA: 0x3AC5350
	|-ReadOnlyCollection<ArenaOrderSequence.GodInfo>..ctor
	|
	|-RVA: 0x3AC6340 Offset: 0x3AC6441 VA: 0x3AC6340
	|-ReadOnlyCollection<BattleInfo.SupportData>..ctor
	|
	|-RVA: 0x3AC7330 Offset: 0x3AC7431 VA: 0x3AC7330
	|-ReadOnlyCollection<BeforeRenderHelper.OrderBlock>..ctor
	|
	|-RVA: 0x3AC8320 Offset: 0x3AC8421 VA: 0x3AC8320
	|-ReadOnlyCollection<Camera.RenderRequest>..ctor
	|
	|-RVA: 0x3AC93E0 Offset: 0x3AC94E1 VA: 0x3AC93E0
	|-ReadOnlyCollection<CameraState.CustomBlendable>..ctor
	|
	|-RVA: 0x3ACA3D0 Offset: 0x3ACA4D1 VA: 0x3ACA3D0
	|-ReadOnlyCollection<CinemachineClearShot.Pair>..ctor
	|
	|-RVA: 0x3ACB3B0 Offset: 0x3ACB4B1 VA: 0x3ACB3B0
	|-ReadOnlyCollection<CinemachineStateDrivenCamera.HashPair>..ctor
	|
	|-RVA: 0x3ACC390 Offset: 0x3ACC491 VA: 0x3ACC390
	|-ReadOnlyCollection<DelayedActionManager.DelegateInfo>..ctor
	|
	|-RVA: 0x3ACD450 Offset: 0x3ACD551 VA: 0x3ACD450
	|-ReadOnlyCollection<Detail.AsyncResultInt>..ctor
	|
	|-RVA: 0x3ACE580 Offset: 0x3ACE681 VA: 0x3ACE580
	|-ReadOnlyCollection<Detail.CppArray>..ctor
	|
	|-RVA: 0x3ACF570 Offset: 0x3ACF671 VA: 0x3ACF570
	|-ReadOnlyCollection<Detail.NotificationEventInt>..ctor
	|
	|-RVA: 0x3AD06A0 Offset: 0x3AD07A1 VA: 0x3AD06A0
	|-ReadOnlyCollection<DragonRideTargetGroup.ChainParam>..ctor
	|
	|-RVA: 0x3AD1690 Offset: 0x3AD1791 VA: 0x3AD1690
	|-ReadOnlyCollection<GmapPathAdjuster.TargetModel>..ctor
	|
	|-RVA: 0x3AD2750 Offset: 0x3AD2851 VA: 0x3AD2750
	|-ReadOnlyCollection<GmapSpotAdjuster.TargetModel>..ctor
	|
	|-RVA: 0x3AD3810 Offset: 0x3AD3911 VA: 0x3AD3810
	|-ReadOnlyCollection<HubFastTravel.Location>..ctor
	|
	|-RVA: 0x3AD48D0 Offset: 0x3AD49D1 VA: 0x3AD48D0
	|-ReadOnlyCollection<HubLensFlare.Flare>..ctor
	|
	|-RVA: 0x3AD5A00 Offset: 0x3AD5B01 VA: 0x3AD5A00
	|-ReadOnlyCollection<InventoryPoolItemMenuContent.KindBgNameClass>..ctor
	|
	|-RVA: 0x3AD69F0 Offset: 0x3AD6AF1 VA: 0x3AD69F0
	|-ReadOnlyCollection<Map.Pos>..ctor
	|
	|-RVA: 0x3AD79D0 Offset: 0x3AD7AD1 VA: 0x3AD79D0
	|-ReadOnlyCollection<MapImage.BackupTerrain>..ctor
	|
	|-RVA: 0x3AD89C0 Offset: 0x3AD8AC1 VA: 0x3AD89C0
	|-ReadOnlyCollection<MapImageRange.Pos>..ctor
	|
	|-RVA: 0x3AD99E0 Offset: 0x3AD9AE1 VA: 0x3AD99E0
	|-ReadOnlyCollection<MapMind.Target>..ctor
	|
	|-RVA: 0x38C43C0 Offset: 0x38C44C1 VA: 0x38C43C0
	|-ReadOnlyCollection<MapPanelDebug.Entity>..ctor
	|
	|-RVA: 0x38C5480 Offset: 0x38C5581 VA: 0x38C5480
	|-ReadOnlyCollection<NexRanking.Data>..ctor
	|
	|-RVA: 0x38C6460 Offset: 0x38C6561 VA: 0x38C6460
	|-ReadOnlyCollection<NexVersus.RatingData>..ctor
	|
	|-RVA: 0x38C7450 Offset: 0x38C7551 VA: 0x38C7450
	|-ReadOnlyCollection<PackedPlayModeBuildLogs.RuntimeBuildLog>..ctor
	|
	|-RVA: 0x38C8440 Offset: 0x38C8541 VA: 0x38C8440
	|-ReadOnlyCollection<ParticleSystem.Particle>..ctor
	|
	|-RVA: 0x38C9560 Offset: 0x38C9661 VA: 0x38C9560
	|-ReadOnlyCollection<RangeData.Offset>..ctor
	|
	|-RVA: 0x38CA540 Offset: 0x38CA641 VA: 0x38CA540
	|-ReadOnlyCollection<RenderGraphDebugData.PassDebugData>..ctor
	|
	|-RVA: 0x38CB600 Offset: 0x38CB701 VA: 0x38CB600
	|-ReadOnlyCollection<RenderGraphDebugData.ResourceDebugData>..ctor
	|
	|-RVA: 0x38CC720 Offset: 0x38CC821 VA: 0x38CC720
	|-ReadOnlyCollection<RingCleaningUnitSelectMenu.GodParam>..ctor
	|
	|-RVA: 0x38CD710 Offset: 0x38CD811 VA: 0x38CD710
	|-ReadOnlyCollection<ShadowUtility.Edge>..ctor
	|
	|-RVA: 0x38CE840 Offset: 0x38CE941 VA: 0x38CE840
	|-ReadOnlyCollection<SkillArray.Entity>..ctor
	|
	|-RVA: 0x38CF860 Offset: 0x38CF961 VA: 0x38CF860
	|-ReadOnlyCollection<TexturePacker_JsonArray.Frame>..ctor
	|
	|-RVA: 0x38D09F0 Offset: 0x38D0AF1 VA: 0x38D09F0
	|-ReadOnlyCollection<TimeNotificationBehaviour.NotificationEntry>..ctor
	|
	|-RVA: 0x38D1AB0 Offset: 0x38D1BB1 VA: 0x38D1AB0
	|-ReadOnlyCollection<UnitySynchronizationContext.WorkRequest>..ctor
	|
	|-RVA: 0x38D2B70 Offset: 0x38D2C71 VA: 0x38D2B70
	|-ReadOnlyCollection<XmlSchemaObjectTable.XmlSchemaObjectEntry>..ctor
	|
	|-RVA: 0x38D3B60 Offset: 0x38D3C61 VA: 0x38D3B60
	|-ReadOnlyCollection<AssetBundleBuildMap.AssetBundleEntry.AssetPathString>..ctor
	|
	|-RVA: 0x38D4B50 Offset: 0x38D4C51 VA: 0x38D4B50
	|-ReadOnlyCollection<Detail.DataStore.DataStoreChangeMetaParamInt>..ctor
	|
	|-RVA: 0x38D5C90 Offset: 0x38D5D91 VA: 0x38D5C90
	|-ReadOnlyCollection<Detail.DataStore.DataStoreDeleteParamInt>..ctor
	|
	|-RVA: 0x38D6C80 Offset: 0x38D6D81 VA: 0x38D6C80
	|-ReadOnlyCollection<Detail.DataStore.DataStoreGetMetaParamInt>..ctor
	|
	|-RVA: 0x38D7DA0 Offset: 0x38D7EA1 VA: 0x38D7DA0
	|-ReadOnlyCollection<Detail.DataStore.DataStoreMetaInfoInt>..ctor
	|
	|-RVA: 0x38D8EC0 Offset: 0x38D8FC1 VA: 0x38D8EC0
	|-ReadOnlyCollection<Detail.DataStore.DataStorePasswordInfoInt>..ctor
	|
	|-RVA: 0x38D9F80 Offset: 0x38DA081 VA: 0x38D9F80
	|-ReadOnlyCollection<Detail.DataStore.DataStorePersistenceInfoInt>..ctor
	|
	|-RVA: 0x38DB040 Offset: 0x38DB141 VA: 0x38DB040
	|-ReadOnlyCollection<Detail.DataStore.DataStorePreparePostParamInt>..ctor
	|
	|-RVA: 0x38DC160 Offset: 0x38DC261 VA: 0x38DC160
	|-ReadOnlyCollection<Detail.DataStore.DataStoreRateObjectParamInt>..ctor
	|
	|-RVA: 0x38DD150 Offset: 0x38DD251 VA: 0x38DD150
	|-ReadOnlyCollection<Detail.DataStore.DataStoreRatingInitParamInt>..ctor
	|
	|-RVA: 0x38DE210 Offset: 0x38DE311 VA: 0x38DE210
	|-ReadOnlyCollection<Detail.DataStore.DataStoreRatingTargetInt>..ctor
	|
	|-RVA: 0x38DF200 Offset: 0x38DF301 VA: 0x38DF200
	|-ReadOnlyCollection<Detail.Ranking.RankingCachedResultInt>..ctor
	|
	|-RVA: 0x38E0390 Offset: 0x38E0491 VA: 0x38E0390
	|-ReadOnlyCollection<Detail.Ranking.RankingOrderParamInt>..ctor
	|
	|-RVA: 0x38E1380 Offset: 0x38E1481 VA: 0x38E1380
	|-ReadOnlyCollection<Detail.Ranking.RankingRankDataInt>..ctor
	|
	|-RVA: 0x38E2510 Offset: 0x38E2611 VA: 0x38E2510
	|-ReadOnlyCollection<Detail.Ranking2.Ranking2ChartInfoInt>..ctor
	|
	|-RVA: 0x38E3820 Offset: 0x38E3921 VA: 0x38E3820
	|-ReadOnlyCollection<Detail.Ranking2.Ranking2RankDataInt>..ctor
	|
	|-RVA: 0x38E49B0 Offset: 0x38E4AB1 VA: 0x38E49B0
	|-ReadOnlyCollection<Detail.Ranking2.Ranking2ScoreDataInt>..ctor
	|
	|-RVA: 0x38E59A0 Offset: 0x38E5AA1 VA: 0x38E59A0
	|-ReadOnlyCollection<Detail.Screening.ScreeningContextInfoInt>..ctor
	|
	|-RVA: 0x38E6A60 Offset: 0x38E6B61 VA: 0x38E6A60
	|-ReadOnlyCollection<Detail.Subscriber.SubscriberContentInt>..ctor
	|
	|-RVA: 0x38E7CB0 Offset: 0x38E7DB1 VA: 0x38E7CB0
	|-ReadOnlyCollection<Detail.Subscriber.SubscriberGetContentParamInt>..ctor
	|
	|-RVA: 0x38E8D70 Offset: 0x38E8E71 VA: 0x38E8D70
	|-ReadOnlyCollection<Detail.Subscriber.SubscriberUserStatusInfoInt>..ctor
	|
	|-RVA: 0x38E9E90 Offset: 0x38E9F91 VA: 0x38E9E90
	|-ReadOnlyCollection<Detail.Subscriber.SubscriberUserStatusParamInt>..ctor
	|
	|-RVA: 0x38EAF50 Offset: 0x38EB051 VA: 0x38EAF50
	|-ReadOnlyCollection<Detail.Utility.IntegerSettings>..ctor
	|
	|-RVA: 0x38EBF30 Offset: 0x38EC031 VA: 0x38EBF30
	|-ReadOnlyCollection<Detail.Utility.UniqueIdInfoInt>..ctor
	|
	|-RVA: 0x38ECF20 Offset: 0x38ED021 VA: 0x38ECF20
	|-ReadOnlyCollection<MapHistory.Rewind.LatestInspectorData>..ctor
	|
	|-RVA: 0x38EDF50 Offset: 0x38EE051 VA: 0x38EDF50
	|-ReadOnlyCollection<MapHistory.Rewind.WorkTerrainData>..ctor
	|
	|-RVA: 0x38EEF80 Offset: 0x38EF081 VA: 0x38EEF80
	|-ReadOnlyCollection<MapSkill.AroundCalculator.Result>..ctor
	|
	|-RVA: 0x38EFF70 Offset: 0x38F0071 VA: 0x38EFF70
	|-ReadOnlyCollection<TargetPositionCache.CacheCurve.Item>..ctor
	|
	|-RVA: 0x2FE54F0 Offset: 0x2FE55F1 VA: 0x2FE54F0
	|-ReadOnlyCollection<TargetPositionCache.CacheEntry.RecordingItem>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 33
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34673D0 Offset: 0x34674D1 VA: 0x34673D0
	|-ReadOnlyCollection<IntervalTree.Entry<object>>.get_Count
	|
	|-RVA: 0x3468490 Offset: 0x3468591 VA: 0x3468490
	|-ReadOnlyCollection<KeyValuePair<DateTime, object>>.get_Count
	|
	|-RVA: 0x3469480 Offset: 0x3469581 VA: 0x3469480
	|-ReadOnlyCollection<KeyValuePair<int, object>>.get_Count
	|
	|-RVA: 0x346A470 Offset: 0x346A571 VA: 0x346A470
	|-ReadOnlyCollection<KeyValuePair<object, ValueTuple<int, DateTime, object>>>.get_Count
	|
	|-RVA: 0x346B530 Offset: 0x346B631 VA: 0x346B530
	|-ReadOnlyCollection<KeyValuePair<object, object>>.get_Count
	|
	|-RVA: 0x346C520 Offset: 0x346C621 VA: 0x346C520
	|-ReadOnlyCollection<CommonBattleSequence.Reliance<object>>.get_Count
	|
	|-RVA: 0x346D5E0 Offset: 0x346D6E1 VA: 0x346D5E0
	|-ReadOnlyCollection<RenderGraphResourcePool.ResourceLogInfo<object>>.get_Count
	|
	|-RVA: 0x346E5D0 Offset: 0x346E6D1 VA: 0x346E5D0
	|-ReadOnlyCollection<ValueTuple<int, object>>.get_Count
	|
	|-RVA: 0x346F5C0 Offset: 0x346F6C1 VA: 0x346F5C0
	|-ReadOnlyCollection<ValueTuple<Int32Enum, int>>.get_Count
	|
	|-RVA: 0x34705A0 Offset: 0x34706A1 VA: 0x34705A0
	|-ReadOnlyCollection<ValueTuple<object, ValueTuple<object, int>>>.get_Count
	|
	|-RVA: 0x3471660 Offset: 0x3471761 VA: 0x3471660
	|-ReadOnlyCollection<ValueTuple<object, int>>.get_Count
	|
	|-RVA: 0x3472650 Offset: 0x3472751 VA: 0x3472650
	|-ReadOnlyCollection<ValueTuple<Vector3, float>>.get_Count
	|
	|-RVA: 0x3473670 Offset: 0x3473771 VA: 0x3473670
	|-ReadOnlyCollection<ValueTuple<object, Int32Enum, int>>.get_Count
	|
	|-RVA: 0x3474660 Offset: 0x3474761 VA: 0x3474660
	|-ReadOnlyCollection<ValueTuple<object, int, int, int>>.get_Count
	|
	|-RVA: 0x3475720 Offset: 0x3475821 VA: 0x3475720
	|-ReadOnlyCollection<AnimatorClipInfo>.get_Count
	|
	|-RVA: 0x3B224A0 Offset: 0x3B225A1 VA: 0x3B224A0
	|-ReadOnlyCollection<AsyncOperationHandle>.get_Count
	|
	|-RVA: 0x3B23560 Offset: 0x3B23661 VA: 0x3B23560
	|-ReadOnlyCollection<BoneWeight>.get_Count
	|
	|-RVA: 0x3B24620 Offset: 0x3B24721 VA: 0x3B24620
	|-ReadOnlyCollection<bool>.get_Count
	|
	|-RVA: 0x3B25610 Offset: 0x3B25711 VA: 0x3B25610
	|-ReadOnlyCollection<byte>.get_Count
	|
	|-RVA: 0x3B265F0 Offset: 0x3B266F1 VA: 0x3B265F0
	|-ReadOnlyCollection<CameraInfo>.get_Count
	|
	|-RVA: 0x3B41B50 Offset: 0x3B41C51 VA: 0x3B41B50
	|-ReadOnlyCollection<CatchBlock>.get_Count
	|-ReadOnlyCollection<ElementInit>.get_Count
	|-ReadOnlyCollection<Exception>.get_Count
	|-ReadOnlyCollection<ExceptionDispatchInfo>.get_Count
	|-ReadOnlyCollection<Expression>.get_Count
	|-ReadOnlyCollection<object>.get_Count
	|-ReadOnlyCollection<ParameterExpression>.get_Count
	|-ReadOnlyCollection<SwitchCase>.get_Count
	|-ReadOnlyCollection<VolumeParameter>.get_Count
	|
	|-RVA: 0x3B275E0 Offset: 0x3B276E1 VA: 0x3B275E0
	|-ReadOnlyCollection<char>.get_Count
	|
	|-RVA: 0x3B285C0 Offset: 0x3B286C1 VA: 0x3B285C0
	|-ReadOnlyCollection<Color>.get_Count
	|
	|-RVA: 0x3B295E0 Offset: 0x3B296E1 VA: 0x3B295E0
	|-ReadOnlyCollection<Color32>.get_Count
	|
	|-RVA: 0x3B2A600 Offset: 0x3B2A701 VA: 0x3B2A600
	|-ReadOnlyCollection<ConstraintSource>.get_Count
	|
	|-RVA: 0x3B2B5F0 Offset: 0x3B2B6F1 VA: 0x3B2B5F0
	|-ReadOnlyCollection<ContourVertex>.get_Count
	|
	|-RVA: 0x3B2C6B0 Offset: 0x3B2C7B1 VA: 0x3B2C6B0
	|-ReadOnlyCollection<CustomAttributeNamedArgument>.get_Count
	|
	|-RVA: 0x3B2D770 Offset: 0x3B2D871 VA: 0x3B2D770
	|-ReadOnlyCollection<CustomAttributeTypedArgument>.get_Count
	|
	|-RVA: 0x3B2E760 Offset: 0x3B2E861 VA: 0x3B2E760
	|-ReadOnlyCollection<DataStoreRatingInfo>.get_Count
	|
	|-RVA: 0x3B2F820 Offset: 0x3B2F921 VA: 0x3B2F820
	|-ReadOnlyCollection<DataStoreResult>.get_Count
	|
	|-RVA: 0x3B30800 Offset: 0x3B30901 VA: 0x3B30800
	|-ReadOnlyCollection<DateTime>.get_Count
	|
	|-RVA: 0x3B317E0 Offset: 0x3B318E1 VA: 0x3B317E0
	|-ReadOnlyCollection<DateTimeOffset>.get_Count
	|
	|-RVA: 0x3B327D0 Offset: 0x3B328D1 VA: 0x3B327D0
	|-ReadOnlyCollection<Decimal>.get_Count
	|
	|-RVA: 0x3B337C0 Offset: 0x3B338C1 VA: 0x3B337C0
	|-ReadOnlyCollection<DiagnosticEvent>.get_Count
	|
	|-RVA: 0x3B348F0 Offset: 0x3B349F1 VA: 0x3B348F0
	|-ReadOnlyCollection<double>.get_Count
	|
	|-RVA: 0x3B358D0 Offset: 0x3B359D1 VA: 0x3B358D0
	|-ReadOnlyCollection<Friend>.get_Count
	|
	|-RVA: 0x3B36A00 Offset: 0x3B36B01 VA: 0x3B36A00
	|-ReadOnlyCollection<GlyphRect>.get_Count
	|
	|-RVA: 0x3B379F0 Offset: 0x3B37AF1 VA: 0x3B379F0
	|-ReadOnlyCollection<short>.get_Count
	|
	|-RVA: 0x3B389D0 Offset: 0x3B38AD1 VA: 0x3B389D0
	|-ReadOnlyCollection<int>.get_Count
	|
	|-RVA: 0x3B399B0 Offset: 0x3B39AB1 VA: 0x3B399B0
	|-ReadOnlyCollection<Int32Enum>.get_Count
	|
	|-RVA: 0x3B3A990 Offset: 0x3B3AA91 VA: 0x3B3A990
	|-ReadOnlyCollection<long>.get_Count
	|
	|-RVA: 0x3B3B970 Offset: 0x3B3BA71 VA: 0x3B3B970
	|-ReadOnlyCollection<IntPtr>.get_Count
	|
	|-RVA: 0x3B3C950 Offset: 0x3B3CA51 VA: 0x3B3C950
	|-ReadOnlyCollection<InterpretedFrameInfo>.get_Count
	|
	|-RVA: 0x3B3D940 Offset: 0x3B3DA41 VA: 0x3B3D940
	|-ReadOnlyCollection<IntervalTreeNode>.get_Count
	|
	|-RVA: 0x3B3EA00 Offset: 0x3B3EB01 VA: 0x3B3EA00
	|-ReadOnlyCollection<LengthLimitProperties>.get_Count
	|
	|-RVA: 0x3B3F9E0 Offset: 0x3B3FAE1 VA: 0x3B3F9E0
	|-ReadOnlyCollection<MapPos>.get_Count
	|
	|-RVA: 0x3B409C0 Offset: 0x3B40AC1 VA: 0x3B409C0
	|-ReadOnlyCollection<Matrix4x4>.get_Count
	|
	|-RVA: 0x3B42A40 Offset: 0x3B42B41 VA: 0x3B42A40
	|-ReadOnlyCollection<ObjectInitializationData>.get_Count
	|
	|-RVA: 0x3B43B70 Offset: 0x3B43C71 VA: 0x3B43B70
	|-ReadOnlyCollection<PlayableBinding>.get_Count
	|
	|-RVA: 0x3B44C30 Offset: 0x3B44D31 VA: 0x3B44C30
	|-ReadOnlyCollection<PlayerLoopSystem>.get_Count
	|
	|-RVA: 0x3B45D50 Offset: 0x3B45E51 VA: 0x3B45D50
	|-ReadOnlyCollection<PlayerLoopSystemInternal>.get_Count
	|
	|-RVA: 0x3B46E70 Offset: 0x3B46F71 VA: 0x3B46E70
	|-ReadOnlyCollection<RangePositionInfo>.get_Count
	|
	|-RVA: 0x3B47E60 Offset: 0x3B47F61 VA: 0x3B47E60
	|-ReadOnlyCollection<Ranking2ChartInfoInput>.get_Count
	|
	|-RVA: 0x3B48E40 Offset: 0x3B48F41 VA: 0x3B48E40
	|-ReadOnlyCollection<RaycastHit2D>.get_Count
	|
	|-RVA: 0x3B49FA0 Offset: 0x3B4A0A1 VA: 0x3B49FA0
	|-ReadOnlyCollection<RaycastResult>.get_Count
	|
	|-RVA: 0x3B4B1F0 Offset: 0x3B4B2F1 VA: 0x3B4B1F0
	|-ReadOnlyCollection<Rect>.get_Count
	|
	|-RVA: 0x3B4C210 Offset: 0x3B4C311 VA: 0x3B4C210
	|-ReadOnlyCollection<RendererListHandle>.get_Count
	|
	|-RVA: 0x3B4D1F0 Offset: 0x3B4D2F1 VA: 0x3B4D1F0
	|-ReadOnlyCollection<ResourceHandle>.get_Count
	|
	|-RVA: 0x3AAE8B0 Offset: 0x3AAE9B1 VA: 0x3AAE8B0
	|-ReadOnlyCollection<sbyte>.get_Count
	|
	|-RVA: 0x3AAF890 Offset: 0x3AAF991 VA: 0x3AAF890
	|-ReadOnlyCollection<ShaderTagId>.get_Count
	|
	|-RVA: 0x3AB08B0 Offset: 0x3AB09B1 VA: 0x3AB08B0
	|-ReadOnlyCollection<float>.get_Count
	|
	|-RVA: 0x3AB1890 Offset: 0x3AB1991 VA: 0x3AB1890
	|-ReadOnlyCollection<SphericalHarmonicsL2>.get_Count
	|
	|-RVA: 0x3AB2C80 Offset: 0x3AB2D81 VA: 0x3AB2C80
	|-ReadOnlyCollection<SubMeshDescriptor>.get_Count
	|
	|-RVA: 0x3AB3DB0 Offset: 0x3AB3EB1 VA: 0x3AB3DB0
	|-ReadOnlyCollection<TablePair>.get_Count
	|
	|-RVA: 0x3AB4DA0 Offset: 0x3AB4EA1 VA: 0x3AB4DA0
	|-ReadOnlyCollection<TimeSpan>.get_Count
	|
	|-RVA: 0x3AB5D80 Offset: 0x3AB5E81 VA: 0x3AB5D80
	|-ReadOnlyCollection<UICharInfo>.get_Count
	|
	|-RVA: 0x3AB6DA0 Offset: 0x3AB6EA1 VA: 0x3AB6DA0
	|-ReadOnlyCollection<UILineInfo>.get_Count
	|
	|-RVA: 0x3AB7D90 Offset: 0x3AB7E91 VA: 0x3AB7D90
	|-ReadOnlyCollection<UIVertex>.get_Count
	|
	|-RVA: 0x3AB9180 Offset: 0x3AB9281 VA: 0x3AB9180
	|-ReadOnlyCollection<ushort>.get_Count
	|
	|-RVA: 0x3ABA160 Offset: 0x3ABA261 VA: 0x3ABA160
	|-ReadOnlyCollection<uint>.get_Count
	|
	|-RVA: 0x3ABB140 Offset: 0x3ABB241 VA: 0x3ABB140
	|-ReadOnlyCollection<ulong>.get_Count
	|
	|-RVA: 0x3ABC120 Offset: 0x3ABC221 VA: 0x3ABC120
	|-ReadOnlyCollection<Vector2>.get_Count
	|
	|-RVA: 0x3ABD120 Offset: 0x3ABD221 VA: 0x3ABD120
	|-ReadOnlyCollection<Vector3>.get_Count
	|
	|-RVA: 0x3ABE140 Offset: 0x3ABE241 VA: 0x3ABE140
	|-ReadOnlyCollection<Vector4>.get_Count
	|
	|-RVA: 0x3ABF160 Offset: 0x3ABF261 VA: 0x3ABF160
	|-ReadOnlyCollection<VertexAttributeDescriptor>.get_Count
	|
	|-RVA: 0x3AC0150 Offset: 0x3AC0251 VA: 0x3AC0150
	|-ReadOnlyCollection<X509ChainStatus>.get_Count
	|
	|-RVA: 0x3AC1140 Offset: 0x3AC1241 VA: 0x3AC1140
	|-ReadOnlyCollection<XRView>.get_Count
	|
	|-RVA: 0x3AC2260 Offset: 0x3AC2361 VA: 0x3AC2260
	|-ReadOnlyCollection<AICrossfire.PositionTable>.get_Count
	|
	|-RVA: 0x3AC3290 Offset: 0x3AC3391 VA: 0x3AC3290
	|-ReadOnlyCollection<AmiiboSequence.GainItemData>.get_Count
	|
	|-RVA: 0x3AC4280 Offset: 0x3AC4381 VA: 0x3AC4280
	|-ReadOnlyCollection<AnimationOutputWeightProcessor.WeightInfo>.get_Count
	|
	|-RVA: 0x3AC53A0 Offset: 0x3AC54A1 VA: 0x3AC53A0
	|-ReadOnlyCollection<ArenaOrderSequence.GodInfo>.get_Count
	|
	|-RVA: 0x3AC6390 Offset: 0x3AC6491 VA: 0x3AC6390
	|-ReadOnlyCollection<BattleInfo.SupportData>.get_Count
	|
	|-RVA: 0x3AC7380 Offset: 0x3AC7481 VA: 0x3AC7380
	|-ReadOnlyCollection<BeforeRenderHelper.OrderBlock>.get_Count
	|
	|-RVA: 0x3AC8370 Offset: 0x3AC8471 VA: 0x3AC8370
	|-ReadOnlyCollection<Camera.RenderRequest>.get_Count
	|
	|-RVA: 0x3AC9430 Offset: 0x3AC9531 VA: 0x3AC9430
	|-ReadOnlyCollection<CameraState.CustomBlendable>.get_Count
	|
	|-RVA: 0x3ACA420 Offset: 0x3ACA521 VA: 0x3ACA420
	|-ReadOnlyCollection<CinemachineClearShot.Pair>.get_Count
	|
	|-RVA: 0x3ACB400 Offset: 0x3ACB501 VA: 0x3ACB400
	|-ReadOnlyCollection<CinemachineStateDrivenCamera.HashPair>.get_Count
	|
	|-RVA: 0x3ACC3E0 Offset: 0x3ACC4E1 VA: 0x3ACC3E0
	|-ReadOnlyCollection<DelayedActionManager.DelegateInfo>.get_Count
	|
	|-RVA: 0x3ACD4A0 Offset: 0x3ACD5A1 VA: 0x3ACD4A0
	|-ReadOnlyCollection<Detail.AsyncResultInt>.get_Count
	|
	|-RVA: 0x3ACE5D0 Offset: 0x3ACE6D1 VA: 0x3ACE5D0
	|-ReadOnlyCollection<Detail.CppArray>.get_Count
	|
	|-RVA: 0x3ACF5C0 Offset: 0x3ACF6C1 VA: 0x3ACF5C0
	|-ReadOnlyCollection<Detail.NotificationEventInt>.get_Count
	|
	|-RVA: 0x3AD06F0 Offset: 0x3AD07F1 VA: 0x3AD06F0
	|-ReadOnlyCollection<DragonRideTargetGroup.ChainParam>.get_Count
	|
	|-RVA: 0x3AD16E0 Offset: 0x3AD17E1 VA: 0x3AD16E0
	|-ReadOnlyCollection<GmapPathAdjuster.TargetModel>.get_Count
	|
	|-RVA: 0x3AD27A0 Offset: 0x3AD28A1 VA: 0x3AD27A0
	|-ReadOnlyCollection<GmapSpotAdjuster.TargetModel>.get_Count
	|
	|-RVA: 0x3AD3860 Offset: 0x3AD3961 VA: 0x3AD3860
	|-ReadOnlyCollection<HubFastTravel.Location>.get_Count
	|
	|-RVA: 0x3AD4920 Offset: 0x3AD4A21 VA: 0x3AD4920
	|-ReadOnlyCollection<HubLensFlare.Flare>.get_Count
	|
	|-RVA: 0x3AD5A50 Offset: 0x3AD5B51 VA: 0x3AD5A50
	|-ReadOnlyCollection<InventoryPoolItemMenuContent.KindBgNameClass>.get_Count
	|
	|-RVA: 0x3AD6A40 Offset: 0x3AD6B41 VA: 0x3AD6A40
	|-ReadOnlyCollection<Map.Pos>.get_Count
	|
	|-RVA: 0x3AD7A20 Offset: 0x3AD7B21 VA: 0x3AD7A20
	|-ReadOnlyCollection<MapImage.BackupTerrain>.get_Count
	|
	|-RVA: 0x3AD8A10 Offset: 0x3AD8B11 VA: 0x3AD8A10
	|-ReadOnlyCollection<MapImageRange.Pos>.get_Count
	|
	|-RVA: 0x3AD9A30 Offset: 0x3AD9B31 VA: 0x3AD9A30
	|-ReadOnlyCollection<MapMind.Target>.get_Count
	|
	|-RVA: 0x38C4410 Offset: 0x38C4511 VA: 0x38C4410
	|-ReadOnlyCollection<MapPanelDebug.Entity>.get_Count
	|
	|-RVA: 0x38C54D0 Offset: 0x38C55D1 VA: 0x38C54D0
	|-ReadOnlyCollection<NexRanking.Data>.get_Count
	|
	|-RVA: 0x38C64B0 Offset: 0x38C65B1 VA: 0x38C64B0
	|-ReadOnlyCollection<NexVersus.RatingData>.get_Count
	|
	|-RVA: 0x38C74A0 Offset: 0x38C75A1 VA: 0x38C74A0
	|-ReadOnlyCollection<PackedPlayModeBuildLogs.RuntimeBuildLog>.get_Count
	|
	|-RVA: 0x38C8490 Offset: 0x38C8591 VA: 0x38C8490
	|-ReadOnlyCollection<ParticleSystem.Particle>.get_Count
	|
	|-RVA: 0x38C95B0 Offset: 0x38C96B1 VA: 0x38C95B0
	|-ReadOnlyCollection<RangeData.Offset>.get_Count
	|
	|-RVA: 0x38CA590 Offset: 0x38CA691 VA: 0x38CA590
	|-ReadOnlyCollection<RenderGraphDebugData.PassDebugData>.get_Count
	|
	|-RVA: 0x38CB650 Offset: 0x38CB751 VA: 0x38CB650
	|-ReadOnlyCollection<RenderGraphDebugData.ResourceDebugData>.get_Count
	|
	|-RVA: 0x38CC770 Offset: 0x38CC871 VA: 0x38CC770
	|-ReadOnlyCollection<RingCleaningUnitSelectMenu.GodParam>.get_Count
	|
	|-RVA: 0x38CD760 Offset: 0x38CD861 VA: 0x38CD760
	|-ReadOnlyCollection<ShadowUtility.Edge>.get_Count
	|
	|-RVA: 0x38CE890 Offset: 0x38CE991 VA: 0x38CE890
	|-ReadOnlyCollection<SkillArray.Entity>.get_Count
	|
	|-RVA: 0x38CF8B0 Offset: 0x38CF9B1 VA: 0x38CF8B0
	|-ReadOnlyCollection<TexturePacker_JsonArray.Frame>.get_Count
	|
	|-RVA: 0x38D0A40 Offset: 0x38D0B41 VA: 0x38D0A40
	|-ReadOnlyCollection<TimeNotificationBehaviour.NotificationEntry>.get_Count
	|
	|-RVA: 0x38D1B00 Offset: 0x38D1C01 VA: 0x38D1B00
	|-ReadOnlyCollection<UnitySynchronizationContext.WorkRequest>.get_Count
	|
	|-RVA: 0x38D2BC0 Offset: 0x38D2CC1 VA: 0x38D2BC0
	|-ReadOnlyCollection<XmlSchemaObjectTable.XmlSchemaObjectEntry>.get_Count
	|
	|-RVA: 0x38D3BB0 Offset: 0x38D3CB1 VA: 0x38D3BB0
	|-ReadOnlyCollection<AssetBundleBuildMap.AssetBundleEntry.AssetPathString>.get_Count
	|
	|-RVA: 0x38D4BA0 Offset: 0x38D4CA1 VA: 0x38D4BA0
	|-ReadOnlyCollection<Detail.DataStore.DataStoreChangeMetaParamInt>.get_Count
	|
	|-RVA: 0x38D5CE0 Offset: 0x38D5DE1 VA: 0x38D5CE0
	|-ReadOnlyCollection<Detail.DataStore.DataStoreDeleteParamInt>.get_Count
	|
	|-RVA: 0x38D6CD0 Offset: 0x38D6DD1 VA: 0x38D6CD0
	|-ReadOnlyCollection<Detail.DataStore.DataStoreGetMetaParamInt>.get_Count
	|
	|-RVA: 0x38D7DF0 Offset: 0x38D7EF1 VA: 0x38D7DF0
	|-ReadOnlyCollection<Detail.DataStore.DataStoreMetaInfoInt>.get_Count
	|
	|-RVA: 0x38D8F10 Offset: 0x38D9011 VA: 0x38D8F10
	|-ReadOnlyCollection<Detail.DataStore.DataStorePasswordInfoInt>.get_Count
	|
	|-RVA: 0x38D9FD0 Offset: 0x38DA0D1 VA: 0x38D9FD0
	|-ReadOnlyCollection<Detail.DataStore.DataStorePersistenceInfoInt>.get_Count
	|
	|-RVA: 0x38DB090 Offset: 0x38DB191 VA: 0x38DB090
	|-ReadOnlyCollection<Detail.DataStore.DataStorePreparePostParamInt>.get_Count
	|
	|-RVA: 0x38DC1B0 Offset: 0x38DC2B1 VA: 0x38DC1B0
	|-ReadOnlyCollection<Detail.DataStore.DataStoreRateObjectParamInt>.get_Count
	|
	|-RVA: 0x38DD1A0 Offset: 0x38DD2A1 VA: 0x38DD1A0
	|-ReadOnlyCollection<Detail.DataStore.DataStoreRatingInitParamInt>.get_Count
	|
	|-RVA: 0x38DE260 Offset: 0x38DE361 VA: 0x38DE260
	|-ReadOnlyCollection<Detail.DataStore.DataStoreRatingTargetInt>.get_Count
	|
	|-RVA: 0x38DF250 Offset: 0x38DF351 VA: 0x38DF250
	|-ReadOnlyCollection<Detail.Ranking.RankingCachedResultInt>.get_Count
	|
	|-RVA: 0x38E03E0 Offset: 0x38E04E1 VA: 0x38E03E0
	|-ReadOnlyCollection<Detail.Ranking.RankingOrderParamInt>.get_Count
	|
	|-RVA: 0x38E13D0 Offset: 0x38E14D1 VA: 0x38E13D0
	|-ReadOnlyCollection<Detail.Ranking.RankingRankDataInt>.get_Count
	|
	|-RVA: 0x38E2560 Offset: 0x38E2661 VA: 0x38E2560
	|-ReadOnlyCollection<Detail.Ranking2.Ranking2ChartInfoInt>.get_Count
	|
	|-RVA: 0x38E3870 Offset: 0x38E3971 VA: 0x38E3870
	|-ReadOnlyCollection<Detail.Ranking2.Ranking2RankDataInt>.get_Count
	|
	|-RVA: 0x38E4A00 Offset: 0x38E4B01 VA: 0x38E4A00
	|-ReadOnlyCollection<Detail.Ranking2.Ranking2ScoreDataInt>.get_Count
	|
	|-RVA: 0x38E59F0 Offset: 0x38E5AF1 VA: 0x38E59F0
	|-ReadOnlyCollection<Detail.Screening.ScreeningContextInfoInt>.get_Count
	|
	|-RVA: 0x38E6AB0 Offset: 0x38E6BB1 VA: 0x38E6AB0
	|-ReadOnlyCollection<Detail.Subscriber.SubscriberContentInt>.get_Count
	|
	|-RVA: 0x38E7D00 Offset: 0x38E7E01 VA: 0x38E7D00
	|-ReadOnlyCollection<Detail.Subscriber.SubscriberGetContentParamInt>.get_Count
	|
	|-RVA: 0x38E8DC0 Offset: 0x38E8EC1 VA: 0x38E8DC0
	|-ReadOnlyCollection<Detail.Subscriber.SubscriberUserStatusInfoInt>.get_Count
	|
	|-RVA: 0x38E9EE0 Offset: 0x38E9FE1 VA: 0x38E9EE0
	|-ReadOnlyCollection<Detail.Subscriber.SubscriberUserStatusParamInt>.get_Count
	|
	|-RVA: 0x38EAFA0 Offset: 0x38EB0A1 VA: 0x38EAFA0
	|-ReadOnlyCollection<Detail.Utility.IntegerSettings>.get_Count
	|
	|-RVA: 0x38EBF80 Offset: 0x38EC081 VA: 0x38EBF80
	|-ReadOnlyCollection<Detail.Utility.UniqueIdInfoInt>.get_Count
	|
	|-RVA: 0x38ECF70 Offset: 0x38ED071 VA: 0x38ECF70
	|-ReadOnlyCollection<MapHistory.Rewind.LatestInspectorData>.get_Count
	|
	|-RVA: 0x38EDFA0 Offset: 0x38EE0A1 VA: 0x38EDFA0
	|-ReadOnlyCollection<MapHistory.Rewind.WorkTerrainData>.get_Count
	|
	|-RVA: 0x38EEFD0 Offset: 0x38EF0D1 VA: 0x38EEFD0
	|-ReadOnlyCollection<MapSkill.AroundCalculator.Result>.get_Count
	|
	|-RVA: 0x38EFFC0 Offset: 0x38F00C1 VA: 0x38EFFC0
	|-ReadOnlyCollection<TargetPositionCache.CacheCurve.Item>.get_Count
	|
	|-RVA: 0x2FE5540 Offset: 0x2FE5641 VA: 0x2FE5540
	|-ReadOnlyCollection<TargetPositionCache.CacheEntry.RecordingItem>.get_Count
	*/

	// RVA: -1 Offset: -1 Slot: 32
	public T get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3467460 Offset: 0x3467561 VA: 0x3467460
	|-ReadOnlyCollection<IntervalTree.Entry<object>>.get_Item
	|
	|-RVA: 0x3468520 Offset: 0x3468621 VA: 0x3468520
	|-ReadOnlyCollection<KeyValuePair<DateTime, object>>.get_Item
	|
	|-RVA: 0x3469510 Offset: 0x3469611 VA: 0x3469510
	|-ReadOnlyCollection<KeyValuePair<int, object>>.get_Item
	|
	|-RVA: 0x346A500 Offset: 0x346A601 VA: 0x346A500
	|-ReadOnlyCollection<KeyValuePair<object, ValueTuple<int, DateTime, object>>>.get_Item
	|
	|-RVA: 0x346B5C0 Offset: 0x346B6C1 VA: 0x346B5C0
	|-ReadOnlyCollection<KeyValuePair<object, object>>.get_Item
	|
	|-RVA: 0x346C5B0 Offset: 0x346C6B1 VA: 0x346C5B0
	|-ReadOnlyCollection<CommonBattleSequence.Reliance<object>>.get_Item
	|
	|-RVA: 0x346D670 Offset: 0x346D771 VA: 0x346D670
	|-ReadOnlyCollection<RenderGraphResourcePool.ResourceLogInfo<object>>.get_Item
	|
	|-RVA: 0x346E660 Offset: 0x346E761 VA: 0x346E660
	|-ReadOnlyCollection<ValueTuple<int, object>>.get_Item
	|
	|-RVA: 0x346F650 Offset: 0x346F751 VA: 0x346F650
	|-ReadOnlyCollection<ValueTuple<Int32Enum, int>>.get_Item
	|
	|-RVA: 0x3470630 Offset: 0x3470731 VA: 0x3470630
	|-ReadOnlyCollection<ValueTuple<object, ValueTuple<object, int>>>.get_Item
	|
	|-RVA: 0x34716F0 Offset: 0x34717F1 VA: 0x34716F0
	|-ReadOnlyCollection<ValueTuple<object, int>>.get_Item
	|
	|-RVA: 0x34726E0 Offset: 0x34727E1 VA: 0x34726E0
	|-ReadOnlyCollection<ValueTuple<Vector3, float>>.get_Item
	|
	|-RVA: 0x3473700 Offset: 0x3473801 VA: 0x3473700
	|-ReadOnlyCollection<ValueTuple<object, Int32Enum, int>>.get_Item
	|
	|-RVA: 0x34746F0 Offset: 0x34747F1 VA: 0x34746F0
	|-ReadOnlyCollection<ValueTuple<object, int, int, int>>.get_Item
	|
	|-RVA: 0x34757B0 Offset: 0x34758B1 VA: 0x34757B0
	|-ReadOnlyCollection<AnimatorClipInfo>.get_Item
	|
	|-RVA: 0x3B22530 Offset: 0x3B22631 VA: 0x3B22530
	|-ReadOnlyCollection<AsyncOperationHandle>.get_Item
	|
	|-RVA: 0x3B235F0 Offset: 0x3B236F1 VA: 0x3B235F0
	|-ReadOnlyCollection<BoneWeight>.get_Item
	|
	|-RVA: 0x3B246B0 Offset: 0x3B247B1 VA: 0x3B246B0
	|-ReadOnlyCollection<bool>.get_Item
	|
	|-RVA: 0x3B256A0 Offset: 0x3B257A1 VA: 0x3B256A0
	|-ReadOnlyCollection<byte>.get_Item
	|
	|-RVA: 0x3B26680 Offset: 0x3B26781 VA: 0x3B26680
	|-ReadOnlyCollection<CameraInfo>.get_Item
	|
	|-RVA: 0x3B27670 Offset: 0x3B27771 VA: 0x3B27670
	|-ReadOnlyCollection<char>.get_Item
	|
	|-RVA: 0x3B28650 Offset: 0x3B28751 VA: 0x3B28650
	|-ReadOnlyCollection<Color>.get_Item
	|
	|-RVA: 0x3B29670 Offset: 0x3B29771 VA: 0x3B29670
	|-ReadOnlyCollection<Color32>.get_Item
	|
	|-RVA: 0x3B2A690 Offset: 0x3B2A791 VA: 0x3B2A690
	|-ReadOnlyCollection<ConstraintSource>.get_Item
	|
	|-RVA: 0x3B2B680 Offset: 0x3B2B781 VA: 0x3B2B680
	|-ReadOnlyCollection<ContourVertex>.get_Item
	|
	|-RVA: 0x3B2C740 Offset: 0x3B2C841 VA: 0x3B2C740
	|-ReadOnlyCollection<CustomAttributeNamedArgument>.get_Item
	|
	|-RVA: 0x3B2D800 Offset: 0x3B2D901 VA: 0x3B2D800
	|-ReadOnlyCollection<CustomAttributeTypedArgument>.get_Item
	|
	|-RVA: 0x3B2E7F0 Offset: 0x3B2E8F1 VA: 0x3B2E7F0
	|-ReadOnlyCollection<DataStoreRatingInfo>.get_Item
	|
	|-RVA: 0x3B2F8B0 Offset: 0x3B2F9B1 VA: 0x3B2F8B0
	|-ReadOnlyCollection<DataStoreResult>.get_Item
	|
	|-RVA: 0x3B30890 Offset: 0x3B30991 VA: 0x3B30890
	|-ReadOnlyCollection<DateTime>.get_Item
	|
	|-RVA: 0x3B31870 Offset: 0x3B31971 VA: 0x3B31870
	|-ReadOnlyCollection<DateTimeOffset>.get_Item
	|
	|-RVA: 0x3B32860 Offset: 0x3B32961 VA: 0x3B32860
	|-ReadOnlyCollection<Decimal>.get_Item
	|
	|-RVA: 0x3B33850 Offset: 0x3B33951 VA: 0x3B33850
	|-ReadOnlyCollection<DiagnosticEvent>.get_Item
	|
	|-RVA: 0x3B34980 Offset: 0x3B34A81 VA: 0x3B34980
	|-ReadOnlyCollection<double>.get_Item
	|
	|-RVA: 0x3B41BE0 Offset: 0x3B41CE1 VA: 0x3B41BE0
	|-ReadOnlyCollection<ElementInit>.get_Item
	|-ReadOnlyCollection<Exception>.get_Item
	|-ReadOnlyCollection<ExceptionDispatchInfo>.get_Item
	|-ReadOnlyCollection<Expression>.get_Item
	|-ReadOnlyCollection<object>.get_Item
	|-ReadOnlyCollection<ParameterExpression>.get_Item
	|-ReadOnlyCollection<SwitchCase>.get_Item
	|-ReadOnlyCollection<VolumeParameter>.get_Item
	|-ReadOnlyCollection<AIOrder.Func>.get_Item
	|
	|-RVA: 0x3B35960 Offset: 0x3B35A61 VA: 0x3B35960
	|-ReadOnlyCollection<Friend>.get_Item
	|
	|-RVA: 0x3B36A90 Offset: 0x3B36B91 VA: 0x3B36A90
	|-ReadOnlyCollection<GlyphRect>.get_Item
	|
	|-RVA: 0x3B37A80 Offset: 0x3B37B81 VA: 0x3B37A80
	|-ReadOnlyCollection<short>.get_Item
	|
	|-RVA: 0x3B38A60 Offset: 0x3B38B61 VA: 0x3B38A60
	|-ReadOnlyCollection<int>.get_Item
	|
	|-RVA: 0x3B39A40 Offset: 0x3B39B41 VA: 0x3B39A40
	|-ReadOnlyCollection<Int32Enum>.get_Item
	|
	|-RVA: 0x3B3AA20 Offset: 0x3B3AB21 VA: 0x3B3AA20
	|-ReadOnlyCollection<long>.get_Item
	|
	|-RVA: 0x3B3BA00 Offset: 0x3B3BB01 VA: 0x3B3BA00
	|-ReadOnlyCollection<IntPtr>.get_Item
	|
	|-RVA: 0x3B3C9E0 Offset: 0x3B3CAE1 VA: 0x3B3C9E0
	|-ReadOnlyCollection<InterpretedFrameInfo>.get_Item
	|
	|-RVA: 0x3B3D9D0 Offset: 0x3B3DAD1 VA: 0x3B3D9D0
	|-ReadOnlyCollection<IntervalTreeNode>.get_Item
	|
	|-RVA: 0x3B3EA90 Offset: 0x3B3EB91 VA: 0x3B3EA90
	|-ReadOnlyCollection<LengthLimitProperties>.get_Item
	|
	|-RVA: 0x3B3FA70 Offset: 0x3B3FB71 VA: 0x3B3FA70
	|-ReadOnlyCollection<MapPos>.get_Item
	|
	|-RVA: 0x3B40A50 Offset: 0x3B40B51 VA: 0x3B40A50
	|-ReadOnlyCollection<Matrix4x4>.get_Item
	|
	|-RVA: 0x3B42AD0 Offset: 0x3B42BD1 VA: 0x3B42AD0
	|-ReadOnlyCollection<ObjectInitializationData>.get_Item
	|
	|-RVA: 0x3B43C00 Offset: 0x3B43D01 VA: 0x3B43C00
	|-ReadOnlyCollection<PlayableBinding>.get_Item
	|
	|-RVA: 0x3B44CC0 Offset: 0x3B44DC1 VA: 0x3B44CC0
	|-ReadOnlyCollection<PlayerLoopSystem>.get_Item
	|
	|-RVA: 0x3B45DE0 Offset: 0x3B45EE1 VA: 0x3B45DE0
	|-ReadOnlyCollection<PlayerLoopSystemInternal>.get_Item
	|
	|-RVA: 0x3B46F00 Offset: 0x3B47001 VA: 0x3B46F00
	|-ReadOnlyCollection<RangePositionInfo>.get_Item
	|
	|-RVA: 0x3B47EF0 Offset: 0x3B47FF1 VA: 0x3B47EF0
	|-ReadOnlyCollection<Ranking2ChartInfoInput>.get_Item
	|
	|-RVA: 0x3B48ED0 Offset: 0x3B48FD1 VA: 0x3B48ED0
	|-ReadOnlyCollection<RaycastHit2D>.get_Item
	|
	|-RVA: 0x3B4A030 Offset: 0x3B4A131 VA: 0x3B4A030
	|-ReadOnlyCollection<RaycastResult>.get_Item
	|
	|-RVA: 0x3B4B280 Offset: 0x3B4B381 VA: 0x3B4B280
	|-ReadOnlyCollection<Rect>.get_Item
	|
	|-RVA: 0x3B4C2A0 Offset: 0x3B4C3A1 VA: 0x3B4C2A0
	|-ReadOnlyCollection<RendererListHandle>.get_Item
	|
	|-RVA: 0x3B4D280 Offset: 0x3B4D381 VA: 0x3B4D280
	|-ReadOnlyCollection<ResourceHandle>.get_Item
	|
	|-RVA: 0x3AAE940 Offset: 0x3AAEA41 VA: 0x3AAE940
	|-ReadOnlyCollection<sbyte>.get_Item
	|
	|-RVA: 0x3AAF920 Offset: 0x3AAFA21 VA: 0x3AAF920
	|-ReadOnlyCollection<ShaderTagId>.get_Item
	|
	|-RVA: 0x3AB0940 Offset: 0x3AB0A41 VA: 0x3AB0940
	|-ReadOnlyCollection<float>.get_Item
	|
	|-RVA: 0x3AB1920 Offset: 0x3AB1A21 VA: 0x3AB1920
	|-ReadOnlyCollection<SphericalHarmonicsL2>.get_Item
	|
	|-RVA: 0x3AB2D10 Offset: 0x3AB2E11 VA: 0x3AB2D10
	|-ReadOnlyCollection<SubMeshDescriptor>.get_Item
	|
	|-RVA: 0x3AB3E40 Offset: 0x3AB3F41 VA: 0x3AB3E40
	|-ReadOnlyCollection<TablePair>.get_Item
	|
	|-RVA: 0x3AB4E30 Offset: 0x3AB4F31 VA: 0x3AB4E30
	|-ReadOnlyCollection<TimeSpan>.get_Item
	|
	|-RVA: 0x3AB5E10 Offset: 0x3AB5F11 VA: 0x3AB5E10
	|-ReadOnlyCollection<UICharInfo>.get_Item
	|
	|-RVA: 0x3AB6E30 Offset: 0x3AB6F31 VA: 0x3AB6E30
	|-ReadOnlyCollection<UILineInfo>.get_Item
	|
	|-RVA: 0x3AB7E20 Offset: 0x3AB7F21 VA: 0x3AB7E20
	|-ReadOnlyCollection<UIVertex>.get_Item
	|
	|-RVA: 0x3AB9210 Offset: 0x3AB9311 VA: 0x3AB9210
	|-ReadOnlyCollection<ushort>.get_Item
	|
	|-RVA: 0x3ABA1F0 Offset: 0x3ABA2F1 VA: 0x3ABA1F0
	|-ReadOnlyCollection<uint>.get_Item
	|
	|-RVA: 0x3ABB1D0 Offset: 0x3ABB2D1 VA: 0x3ABB1D0
	|-ReadOnlyCollection<ulong>.get_Item
	|
	|-RVA: 0x3ABC1B0 Offset: 0x3ABC2B1 VA: 0x3ABC1B0
	|-ReadOnlyCollection<Vector2>.get_Item
	|
	|-RVA: 0x3ABD1B0 Offset: 0x3ABD2B1 VA: 0x3ABD1B0
	|-ReadOnlyCollection<Vector3>.get_Item
	|
	|-RVA: 0x3ABE1D0 Offset: 0x3ABE2D1 VA: 0x3ABE1D0
	|-ReadOnlyCollection<Vector4>.get_Item
	|
	|-RVA: 0x3ABF1F0 Offset: 0x3ABF2F1 VA: 0x3ABF1F0
	|-ReadOnlyCollection<VertexAttributeDescriptor>.get_Item
	|
	|-RVA: 0x3AC01E0 Offset: 0x3AC02E1 VA: 0x3AC01E0
	|-ReadOnlyCollection<X509ChainStatus>.get_Item
	|
	|-RVA: 0x3AC11D0 Offset: 0x3AC12D1 VA: 0x3AC11D0
	|-ReadOnlyCollection<XRView>.get_Item
	|
	|-RVA: 0x3AC22F0 Offset: 0x3AC23F1 VA: 0x3AC22F0
	|-ReadOnlyCollection<AICrossfire.PositionTable>.get_Item
	|
	|-RVA: 0x3AC3320 Offset: 0x3AC3421 VA: 0x3AC3320
	|-ReadOnlyCollection<AmiiboSequence.GainItemData>.get_Item
	|
	|-RVA: 0x3AC4310 Offset: 0x3AC4411 VA: 0x3AC4310
	|-ReadOnlyCollection<AnimationOutputWeightProcessor.WeightInfo>.get_Item
	|
	|-RVA: 0x3AC5430 Offset: 0x3AC5531 VA: 0x3AC5430
	|-ReadOnlyCollection<ArenaOrderSequence.GodInfo>.get_Item
	|
	|-RVA: 0x3AC6420 Offset: 0x3AC6521 VA: 0x3AC6420
	|-ReadOnlyCollection<BattleInfo.SupportData>.get_Item
	|
	|-RVA: 0x3AC7410 Offset: 0x3AC7511 VA: 0x3AC7410
	|-ReadOnlyCollection<BeforeRenderHelper.OrderBlock>.get_Item
	|
	|-RVA: 0x3AC8400 Offset: 0x3AC8501 VA: 0x3AC8400
	|-ReadOnlyCollection<Camera.RenderRequest>.get_Item
	|
	|-RVA: 0x3AC94C0 Offset: 0x3AC95C1 VA: 0x3AC94C0
	|-ReadOnlyCollection<CameraState.CustomBlendable>.get_Item
	|
	|-RVA: 0x3ACA4B0 Offset: 0x3ACA5B1 VA: 0x3ACA4B0
	|-ReadOnlyCollection<CinemachineClearShot.Pair>.get_Item
	|
	|-RVA: 0x3ACB490 Offset: 0x3ACB591 VA: 0x3ACB490
	|-ReadOnlyCollection<CinemachineStateDrivenCamera.HashPair>.get_Item
	|
	|-RVA: 0x3ACC470 Offset: 0x3ACC571 VA: 0x3ACC470
	|-ReadOnlyCollection<DelayedActionManager.DelegateInfo>.get_Item
	|
	|-RVA: 0x3ACD530 Offset: 0x3ACD631 VA: 0x3ACD530
	|-ReadOnlyCollection<Detail.AsyncResultInt>.get_Item
	|
	|-RVA: 0x3ACE660 Offset: 0x3ACE761 VA: 0x3ACE660
	|-ReadOnlyCollection<Detail.CppArray>.get_Item
	|
	|-RVA: 0x3ACF650 Offset: 0x3ACF751 VA: 0x3ACF650
	|-ReadOnlyCollection<Detail.NotificationEventInt>.get_Item
	|
	|-RVA: 0x3AD0780 Offset: 0x3AD0881 VA: 0x3AD0780
	|-ReadOnlyCollection<DragonRideTargetGroup.ChainParam>.get_Item
	|
	|-RVA: 0x3AD1770 Offset: 0x3AD1871 VA: 0x3AD1770
	|-ReadOnlyCollection<GmapPathAdjuster.TargetModel>.get_Item
	|
	|-RVA: 0x3AD2830 Offset: 0x3AD2931 VA: 0x3AD2830
	|-ReadOnlyCollection<GmapSpotAdjuster.TargetModel>.get_Item
	|
	|-RVA: 0x3AD38F0 Offset: 0x3AD39F1 VA: 0x3AD38F0
	|-ReadOnlyCollection<HubFastTravel.Location>.get_Item
	|
	|-RVA: 0x3AD49B0 Offset: 0x3AD4AB1 VA: 0x3AD49B0
	|-ReadOnlyCollection<HubLensFlare.Flare>.get_Item
	|
	|-RVA: 0x3AD5AE0 Offset: 0x3AD5BE1 VA: 0x3AD5AE0
	|-ReadOnlyCollection<InventoryPoolItemMenuContent.KindBgNameClass>.get_Item
	|
	|-RVA: 0x3AD6AD0 Offset: 0x3AD6BD1 VA: 0x3AD6AD0
	|-ReadOnlyCollection<Map.Pos>.get_Item
	|
	|-RVA: 0x3AD7AB0 Offset: 0x3AD7BB1 VA: 0x3AD7AB0
	|-ReadOnlyCollection<MapImage.BackupTerrain>.get_Item
	|
	|-RVA: 0x3AD8AA0 Offset: 0x3AD8BA1 VA: 0x3AD8AA0
	|-ReadOnlyCollection<MapImageRange.Pos>.get_Item
	|
	|-RVA: 0x3AD9AC0 Offset: 0x3AD9BC1 VA: 0x3AD9AC0
	|-ReadOnlyCollection<MapMind.Target>.get_Item
	|
	|-RVA: 0x38C44A0 Offset: 0x38C45A1 VA: 0x38C44A0
	|-ReadOnlyCollection<MapPanelDebug.Entity>.get_Item
	|
	|-RVA: 0x38C5560 Offset: 0x38C5661 VA: 0x38C5560
	|-ReadOnlyCollection<NexRanking.Data>.get_Item
	|
	|-RVA: 0x38C6540 Offset: 0x38C6641 VA: 0x38C6540
	|-ReadOnlyCollection<NexVersus.RatingData>.get_Item
	|
	|-RVA: 0x38C7530 Offset: 0x38C7631 VA: 0x38C7530
	|-ReadOnlyCollection<PackedPlayModeBuildLogs.RuntimeBuildLog>.get_Item
	|
	|-RVA: 0x38C8520 Offset: 0x38C8621 VA: 0x38C8520
	|-ReadOnlyCollection<ParticleSystem.Particle>.get_Item
	|
	|-RVA: 0x38C9640 Offset: 0x38C9741 VA: 0x38C9640
	|-ReadOnlyCollection<RangeData.Offset>.get_Item
	|
	|-RVA: 0x38CA620 Offset: 0x38CA721 VA: 0x38CA620
	|-ReadOnlyCollection<RenderGraphDebugData.PassDebugData>.get_Item
	|
	|-RVA: 0x38CB6E0 Offset: 0x38CB7E1 VA: 0x38CB6E0
	|-ReadOnlyCollection<RenderGraphDebugData.ResourceDebugData>.get_Item
	|
	|-RVA: 0x38CC800 Offset: 0x38CC901 VA: 0x38CC800
	|-ReadOnlyCollection<RingCleaningUnitSelectMenu.GodParam>.get_Item
	|
	|-RVA: 0x38CD7F0 Offset: 0x38CD8F1 VA: 0x38CD7F0
	|-ReadOnlyCollection<ShadowUtility.Edge>.get_Item
	|
	|-RVA: 0x38CE920 Offset: 0x38CEA21 VA: 0x38CE920
	|-ReadOnlyCollection<SkillArray.Entity>.get_Item
	|
	|-RVA: 0x38CF940 Offset: 0x38CFA41 VA: 0x38CF940
	|-ReadOnlyCollection<TexturePacker_JsonArray.Frame>.get_Item
	|
	|-RVA: 0x38D0AD0 Offset: 0x38D0BD1 VA: 0x38D0AD0
	|-ReadOnlyCollection<TimeNotificationBehaviour.NotificationEntry>.get_Item
	|
	|-RVA: 0x38D1B90 Offset: 0x38D1C91 VA: 0x38D1B90
	|-ReadOnlyCollection<UnitySynchronizationContext.WorkRequest>.get_Item
	|
	|-RVA: 0x38D2C50 Offset: 0x38D2D51 VA: 0x38D2C50
	|-ReadOnlyCollection<XmlSchemaObjectTable.XmlSchemaObjectEntry>.get_Item
	|
	|-RVA: 0x38D3C40 Offset: 0x38D3D41 VA: 0x38D3C40
	|-ReadOnlyCollection<AssetBundleBuildMap.AssetBundleEntry.AssetPathString>.get_Item
	|
	|-RVA: 0x38D4C30 Offset: 0x38D4D31 VA: 0x38D4C30
	|-ReadOnlyCollection<Detail.DataStore.DataStoreChangeMetaParamInt>.get_Item
	|
	|-RVA: 0x38D5D70 Offset: 0x38D5E71 VA: 0x38D5D70
	|-ReadOnlyCollection<Detail.DataStore.DataStoreDeleteParamInt>.get_Item
	|
	|-RVA: 0x38D6D60 Offset: 0x38D6E61 VA: 0x38D6D60
	|-ReadOnlyCollection<Detail.DataStore.DataStoreGetMetaParamInt>.get_Item
	|
	|-RVA: 0x38D7E80 Offset: 0x38D7F81 VA: 0x38D7E80
	|-ReadOnlyCollection<Detail.DataStore.DataStoreMetaInfoInt>.get_Item
	|
	|-RVA: 0x38D8FA0 Offset: 0x38D90A1 VA: 0x38D8FA0
	|-ReadOnlyCollection<Detail.DataStore.DataStorePasswordInfoInt>.get_Item
	|
	|-RVA: 0x38DA060 Offset: 0x38DA161 VA: 0x38DA060
	|-ReadOnlyCollection<Detail.DataStore.DataStorePersistenceInfoInt>.get_Item
	|
	|-RVA: 0x38DB120 Offset: 0x38DB221 VA: 0x38DB120
	|-ReadOnlyCollection<Detail.DataStore.DataStorePreparePostParamInt>.get_Item
	|
	|-RVA: 0x38DC240 Offset: 0x38DC341 VA: 0x38DC240
	|-ReadOnlyCollection<Detail.DataStore.DataStoreRateObjectParamInt>.get_Item
	|
	|-RVA: 0x38DD230 Offset: 0x38DD331 VA: 0x38DD230
	|-ReadOnlyCollection<Detail.DataStore.DataStoreRatingInitParamInt>.get_Item
	|
	|-RVA: 0x38DE2F0 Offset: 0x38DE3F1 VA: 0x38DE2F0
	|-ReadOnlyCollection<Detail.DataStore.DataStoreRatingTargetInt>.get_Item
	|
	|-RVA: 0x38DF2E0 Offset: 0x38DF3E1 VA: 0x38DF2E0
	|-ReadOnlyCollection<Detail.Ranking.RankingCachedResultInt>.get_Item
	|
	|-RVA: 0x38E0470 Offset: 0x38E0571 VA: 0x38E0470
	|-ReadOnlyCollection<Detail.Ranking.RankingOrderParamInt>.get_Item
	|
	|-RVA: 0x38E1460 Offset: 0x38E1561 VA: 0x38E1460
	|-ReadOnlyCollection<Detail.Ranking.RankingRankDataInt>.get_Item
	|
	|-RVA: 0x38E25F0 Offset: 0x38E26F1 VA: 0x38E25F0
	|-ReadOnlyCollection<Detail.Ranking2.Ranking2ChartInfoInt>.get_Item
	|
	|-RVA: 0x38E3900 Offset: 0x38E3A01 VA: 0x38E3900
	|-ReadOnlyCollection<Detail.Ranking2.Ranking2RankDataInt>.get_Item
	|
	|-RVA: 0x38E4A90 Offset: 0x38E4B91 VA: 0x38E4A90
	|-ReadOnlyCollection<Detail.Ranking2.Ranking2ScoreDataInt>.get_Item
	|
	|-RVA: 0x38E5A80 Offset: 0x38E5B81 VA: 0x38E5A80
	|-ReadOnlyCollection<Detail.Screening.ScreeningContextInfoInt>.get_Item
	|
	|-RVA: 0x38E6B40 Offset: 0x38E6C41 VA: 0x38E6B40
	|-ReadOnlyCollection<Detail.Subscriber.SubscriberContentInt>.get_Item
	|
	|-RVA: 0x38E7D90 Offset: 0x38E7E91 VA: 0x38E7D90
	|-ReadOnlyCollection<Detail.Subscriber.SubscriberGetContentParamInt>.get_Item
	|
	|-RVA: 0x38E8E50 Offset: 0x38E8F51 VA: 0x38E8E50
	|-ReadOnlyCollection<Detail.Subscriber.SubscriberUserStatusInfoInt>.get_Item
	|
	|-RVA: 0x38E9F70 Offset: 0x38EA071 VA: 0x38E9F70
	|-ReadOnlyCollection<Detail.Subscriber.SubscriberUserStatusParamInt>.get_Item
	|
	|-RVA: 0x38EB030 Offset: 0x38EB131 VA: 0x38EB030
	|-ReadOnlyCollection<Detail.Utility.IntegerSettings>.get_Item
	|
	|-RVA: 0x38EC010 Offset: 0x38EC111 VA: 0x38EC010
	|-ReadOnlyCollection<Detail.Utility.UniqueIdInfoInt>.get_Item
	|
	|-RVA: 0x38ED000 Offset: 0x38ED101 VA: 0x38ED000
	|-ReadOnlyCollection<MapHistory.Rewind.LatestInspectorData>.get_Item
	|
	|-RVA: 0x38EE030 Offset: 0x38EE131 VA: 0x38EE030
	|-ReadOnlyCollection<MapHistory.Rewind.WorkTerrainData>.get_Item
	|
	|-RVA: 0x38EF060 Offset: 0x38EF161 VA: 0x38EF060
	|-ReadOnlyCollection<MapSkill.AroundCalculator.Result>.get_Item
	|
	|-RVA: 0x38F0050 Offset: 0x38F0151 VA: 0x38F0050
	|-ReadOnlyCollection<TargetPositionCache.CacheCurve.Item>.get_Item
	|
	|-RVA: 0x2FE55D0 Offset: 0x2FE56D1 VA: 0x2FE55D0
	|-ReadOnlyCollection<TargetPositionCache.CacheEntry.RecordingItem>.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public bool Contains(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3467520 Offset: 0x3467621 VA: 0x3467520
	|-ReadOnlyCollection<IntervalTree.Entry<object>>.Contains
	|
	|-RVA: 0x34685C0 Offset: 0x34686C1 VA: 0x34685C0
	|-ReadOnlyCollection<KeyValuePair<DateTime, object>>.Contains
	|
	|-RVA: 0x34695B0 Offset: 0x34696B1 VA: 0x34695B0
	|-ReadOnlyCollection<KeyValuePair<int, object>>.Contains
	|
	|-RVA: 0x346A5C0 Offset: 0x346A6C1 VA: 0x346A5C0
	|-ReadOnlyCollection<KeyValuePair<object, ValueTuple<int, DateTime, object>>>.Contains
	|
	|-RVA: 0x346B660 Offset: 0x346B761 VA: 0x346B660
	|-ReadOnlyCollection<KeyValuePair<object, object>>.Contains
	|
	|-RVA: 0x346C670 Offset: 0x346C771 VA: 0x346C670
	|-ReadOnlyCollection<CommonBattleSequence.Reliance<object>>.Contains
	|
	|-RVA: 0x346D710 Offset: 0x346D811 VA: 0x346D710
	|-ReadOnlyCollection<RenderGraphResourcePool.ResourceLogInfo<object>>.Contains
	|
	|-RVA: 0x346E700 Offset: 0x346E801 VA: 0x346E700
	|-ReadOnlyCollection<ValueTuple<int, object>>.Contains
	|
	|-RVA: 0x346F6F0 Offset: 0x346F7F1 VA: 0x346F6F0
	|-ReadOnlyCollection<ValueTuple<Int32Enum, int>>.Contains
	|
	|-RVA: 0x34706F0 Offset: 0x34707F1 VA: 0x34706F0
	|-ReadOnlyCollection<ValueTuple<object, ValueTuple<object, int>>>.Contains
	|
	|-RVA: 0x3471790 Offset: 0x3471891 VA: 0x3471790
	|-ReadOnlyCollection<ValueTuple<object, int>>.Contains
	|
	|-RVA: 0x3472780 Offset: 0x3472881 VA: 0x3472780
	|-ReadOnlyCollection<ValueTuple<Vector3, float>>.Contains
	|
	|-RVA: 0x34737A0 Offset: 0x34738A1 VA: 0x34737A0
	|-ReadOnlyCollection<ValueTuple<object, Int32Enum, int>>.Contains
	|
	|-RVA: 0x34747B0 Offset: 0x34748B1 VA: 0x34747B0
	|-ReadOnlyCollection<ValueTuple<object, int, int, int>>.Contains
	|
	|-RVA: 0x3475850 Offset: 0x3475951 VA: 0x3475850
	|-ReadOnlyCollection<AnimatorClipInfo>.Contains
	|
	|-RVA: 0x3B225F0 Offset: 0x3B226F1 VA: 0x3B225F0
	|-ReadOnlyCollection<AsyncOperationHandle>.Contains
	|
	|-RVA: 0x3B236B0 Offset: 0x3B237B1 VA: 0x3B236B0
	|-ReadOnlyCollection<BoneWeight>.Contains
	|
	|-RVA: 0x3B24750 Offset: 0x3B24851 VA: 0x3B24750
	|-ReadOnlyCollection<bool>.Contains
	|
	|-RVA: 0x3B25740 Offset: 0x3B25841 VA: 0x3B25740
	|-ReadOnlyCollection<byte>.Contains
	|
	|-RVA: 0x3B26720 Offset: 0x3B26821 VA: 0x3B26720
	|-ReadOnlyCollection<CameraInfo>.Contains
	|
	|-RVA: 0x3B27710 Offset: 0x3B27811 VA: 0x3B27710
	|-ReadOnlyCollection<char>.Contains
	|
	|-RVA: 0x3B286F0 Offset: 0x3B287F1 VA: 0x3B286F0
	|-ReadOnlyCollection<Color>.Contains
	|
	|-RVA: 0x3B29720 Offset: 0x3B29821 VA: 0x3B29720
	|-ReadOnlyCollection<Color32>.Contains
	|
	|-RVA: 0x3B2A730 Offset: 0x3B2A831 VA: 0x3B2A730
	|-ReadOnlyCollection<ConstraintSource>.Contains
	|
	|-RVA: 0x3B2B740 Offset: 0x3B2B841 VA: 0x3B2B740
	|-ReadOnlyCollection<ContourVertex>.Contains
	|
	|-RVA: 0x3B2C800 Offset: 0x3B2C901 VA: 0x3B2C800
	|-ReadOnlyCollection<CustomAttributeNamedArgument>.Contains
	|
	|-RVA: 0x3B2D8A0 Offset: 0x3B2D9A1 VA: 0x3B2D8A0
	|-ReadOnlyCollection<CustomAttributeTypedArgument>.Contains
	|
	|-RVA: 0x3B2E8B0 Offset: 0x3B2E9B1 VA: 0x3B2E8B0
	|-ReadOnlyCollection<DataStoreRatingInfo>.Contains
	|
	|-RVA: 0x3B2F950 Offset: 0x3B2FA51 VA: 0x3B2F950
	|-ReadOnlyCollection<DataStoreResult>.Contains
	|
	|-RVA: 0x3B30930 Offset: 0x3B30A31 VA: 0x3B30930
	|-ReadOnlyCollection<DateTime>.Contains
	|
	|-RVA: 0x3B31910 Offset: 0x3B31A11 VA: 0x3B31910
	|-ReadOnlyCollection<DateTimeOffset>.Contains
	|
	|-RVA: 0x3B32900 Offset: 0x3B32A01 VA: 0x3B32900
	|-ReadOnlyCollection<Decimal>.Contains
	|
	|-RVA: 0x3B33920 Offset: 0x3B33A21 VA: 0x3B33920
	|-ReadOnlyCollection<DiagnosticEvent>.Contains
	|
	|-RVA: 0x3B34A20 Offset: 0x3B34B21 VA: 0x3B34A20
	|-ReadOnlyCollection<double>.Contains
	|
	|-RVA: 0x3B35A40 Offset: 0x3B35B41 VA: 0x3B35A40
	|-ReadOnlyCollection<Friend>.Contains
	|
	|-RVA: 0x3B36B30 Offset: 0x3B36C31 VA: 0x3B36B30
	|-ReadOnlyCollection<GlyphRect>.Contains
	|
	|-RVA: 0x3B37B20 Offset: 0x3B37C21 VA: 0x3B37B20
	|-ReadOnlyCollection<short>.Contains
	|
	|-RVA: 0x3B38B00 Offset: 0x3B38C01 VA: 0x3B38B00
	|-ReadOnlyCollection<int>.Contains
	|
	|-RVA: 0x3B39AE0 Offset: 0x3B39BE1 VA: 0x3B39AE0
	|-ReadOnlyCollection<Int32Enum>.Contains
	|
	|-RVA: 0x3B3AAC0 Offset: 0x3B3ABC1 VA: 0x3B3AAC0
	|-ReadOnlyCollection<long>.Contains
	|
	|-RVA: 0x3B3BAA0 Offset: 0x3B3BBA1 VA: 0x3B3BAA0
	|-ReadOnlyCollection<IntPtr>.Contains
	|
	|-RVA: 0x3B3CA80 Offset: 0x3B3CB81 VA: 0x3B3CA80
	|-ReadOnlyCollection<InterpretedFrameInfo>.Contains
	|
	|-RVA: 0x3B3DA90 Offset: 0x3B3DB91 VA: 0x3B3DA90
	|-ReadOnlyCollection<IntervalTreeNode>.Contains
	|
	|-RVA: 0x3B3EB30 Offset: 0x3B3EC31 VA: 0x3B3EB30
	|-ReadOnlyCollection<LengthLimitProperties>.Contains
	|
	|-RVA: 0x3B3FB10 Offset: 0x3B3FC11 VA: 0x3B3FB10
	|-ReadOnlyCollection<MapPos>.Contains
	|
	|-RVA: 0x3B40B20 Offset: 0x3B40C21 VA: 0x3B40B20
	|-ReadOnlyCollection<Matrix4x4>.Contains
	|
	|-RVA: 0x3B41C80 Offset: 0x3B41D81 VA: 0x3B41C80
	|-ReadOnlyCollection<object>.Contains
	|
	|-RVA: 0x3B42BA0 Offset: 0x3B42CA1 VA: 0x3B42BA0
	|-ReadOnlyCollection<ObjectInitializationData>.Contains
	|
	|-RVA: 0x3B43CC0 Offset: 0x3B43DC1 VA: 0x3B43CC0
	|-ReadOnlyCollection<PlayableBinding>.Contains
	|
	|-RVA: 0x3B44D90 Offset: 0x3B44E91 VA: 0x3B44D90
	|-ReadOnlyCollection<PlayerLoopSystem>.Contains
	|
	|-RVA: 0x3B45EB0 Offset: 0x3B45FB1 VA: 0x3B45EB0
	|-ReadOnlyCollection<PlayerLoopSystemInternal>.Contains
	|
	|-RVA: 0x3B46FA0 Offset: 0x3B470A1 VA: 0x3B46FA0
	|-ReadOnlyCollection<RangePositionInfo>.Contains
	|
	|-RVA: 0x3B47F90 Offset: 0x3B48091 VA: 0x3B47F90
	|-ReadOnlyCollection<Ranking2ChartInfoInput>.Contains
	|
	|-RVA: 0x3B48FA0 Offset: 0x3B490A1 VA: 0x3B48FA0
	|-ReadOnlyCollection<RaycastHit2D>.Contains
	|
	|-RVA: 0x3B4A110 Offset: 0x3B4A211 VA: 0x3B4A110
	|-ReadOnlyCollection<RaycastResult>.Contains
	|
	|-RVA: 0x3B4B320 Offset: 0x3B4B421 VA: 0x3B4B320
	|-ReadOnlyCollection<Rect>.Contains
	|
	|-RVA: 0x3B4C340 Offset: 0x3B4C441 VA: 0x3B4C340
	|-ReadOnlyCollection<RendererListHandle>.Contains
	|
	|-RVA: 0x3B4D320 Offset: 0x3B4D421 VA: 0x3B4D320
	|-ReadOnlyCollection<ResourceHandle>.Contains
	|
	|-RVA: 0x3AAE9E0 Offset: 0x3AAEAE1 VA: 0x3AAE9E0
	|-ReadOnlyCollection<sbyte>.Contains
	|
	|-RVA: 0x3AAF9D0 Offset: 0x3AAFAD1 VA: 0x3AAF9D0
	|-ReadOnlyCollection<ShaderTagId>.Contains
	|
	|-RVA: 0x3AB09E0 Offset: 0x3AB0AE1 VA: 0x3AB09E0
	|-ReadOnlyCollection<float>.Contains
	|
	|-RVA: 0x3AB1A10 Offset: 0x3AB1B11 VA: 0x3AB1A10
	|-ReadOnlyCollection<SphericalHarmonicsL2>.Contains
	|
	|-RVA: 0x3AB2DE0 Offset: 0x3AB2EE1 VA: 0x3AB2DE0
	|-ReadOnlyCollection<SubMeshDescriptor>.Contains
	|
	|-RVA: 0x3AB3EE0 Offset: 0x3AB3FE1 VA: 0x3AB3EE0
	|-ReadOnlyCollection<TablePair>.Contains
	|
	|-RVA: 0x3AB4ED0 Offset: 0x3AB4FD1 VA: 0x3AB4ED0
	|-ReadOnlyCollection<TimeSpan>.Contains
	|
	|-RVA: 0x3AB5EB0 Offset: 0x3AB5FB1 VA: 0x3AB5EB0
	|-ReadOnlyCollection<UICharInfo>.Contains
	|
	|-RVA: 0x3AB6ED0 Offset: 0x3AB6FD1 VA: 0x3AB6ED0
	|-ReadOnlyCollection<UILineInfo>.Contains
	|
	|-RVA: 0x3AB7F10 Offset: 0x3AB8011 VA: 0x3AB7F10
	|-ReadOnlyCollection<UIVertex>.Contains
	|
	|-RVA: 0x3AB92B0 Offset: 0x3AB93B1 VA: 0x3AB92B0
	|-ReadOnlyCollection<ushort>.Contains
	|
	|-RVA: 0x3ABA290 Offset: 0x3ABA391 VA: 0x3ABA290
	|-ReadOnlyCollection<uint>.Contains
	|
	|-RVA: 0x3ABB270 Offset: 0x3ABB371 VA: 0x3ABB270
	|-ReadOnlyCollection<ulong>.Contains
	|
	|-RVA: 0x3ABC250 Offset: 0x3ABC351 VA: 0x3ABC250
	|-ReadOnlyCollection<Vector2>.Contains
	|
	|-RVA: 0x3ABD250 Offset: 0x3ABD351 VA: 0x3ABD250
	|-ReadOnlyCollection<Vector3>.Contains
	|
	|-RVA: 0x3ABE270 Offset: 0x3ABE371 VA: 0x3ABE270
	|-ReadOnlyCollection<Vector4>.Contains
	|
	|-RVA: 0x3ABF290 Offset: 0x3ABF391 VA: 0x3ABF290
	|-ReadOnlyCollection<VertexAttributeDescriptor>.Contains
	|
	|-RVA: 0x3AC0280 Offset: 0x3AC0381 VA: 0x3AC0280
	|-ReadOnlyCollection<X509ChainStatus>.Contains
	|
	|-RVA: 0x3AC1290 Offset: 0x3AC1391 VA: 0x3AC1290
	|-ReadOnlyCollection<XRView>.Contains
	|
	|-RVA: 0x3AC23A0 Offset: 0x3AC24A1 VA: 0x3AC23A0
	|-ReadOnlyCollection<AICrossfire.PositionTable>.Contains
	|
	|-RVA: 0x3AC33C0 Offset: 0x3AC34C1 VA: 0x3AC33C0
	|-ReadOnlyCollection<AmiiboSequence.GainItemData>.Contains
	|
	|-RVA: 0x3AC43E0 Offset: 0x3AC44E1 VA: 0x3AC43E0
	|-ReadOnlyCollection<AnimationOutputWeightProcessor.WeightInfo>.Contains
	|
	|-RVA: 0x3AC54D0 Offset: 0x3AC55D1 VA: 0x3AC54D0
	|-ReadOnlyCollection<ArenaOrderSequence.GodInfo>.Contains
	|
	|-RVA: 0x3AC64C0 Offset: 0x3AC65C1 VA: 0x3AC64C0
	|-ReadOnlyCollection<BattleInfo.SupportData>.Contains
	|
	|-RVA: 0x3AC74B0 Offset: 0x3AC75B1 VA: 0x3AC74B0
	|-ReadOnlyCollection<BeforeRenderHelper.OrderBlock>.Contains
	|
	|-RVA: 0x3AC84C0 Offset: 0x3AC85C1 VA: 0x3AC84C0
	|-ReadOnlyCollection<Camera.RenderRequest>.Contains
	|
	|-RVA: 0x3AC9560 Offset: 0x3AC9661 VA: 0x3AC9560
	|-ReadOnlyCollection<CameraState.CustomBlendable>.Contains
	|
	|-RVA: 0x3ACA550 Offset: 0x3ACA651 VA: 0x3ACA550
	|-ReadOnlyCollection<CinemachineClearShot.Pair>.Contains
	|
	|-RVA: 0x3ACB530 Offset: 0x3ACB631 VA: 0x3ACB530
	|-ReadOnlyCollection<CinemachineStateDrivenCamera.HashPair>.Contains
	|
	|-RVA: 0x3ACC530 Offset: 0x3ACC631 VA: 0x3ACC530
	|-ReadOnlyCollection<DelayedActionManager.DelegateInfo>.Contains
	|
	|-RVA: 0x3ACD600 Offset: 0x3ACD701 VA: 0x3ACD600
	|-ReadOnlyCollection<Detail.AsyncResultInt>.Contains
	|
	|-RVA: 0x3ACE700 Offset: 0x3ACE801 VA: 0x3ACE700
	|-ReadOnlyCollection<Detail.CppArray>.Contains
	|
	|-RVA: 0x3ACF720 Offset: 0x3ACF821 VA: 0x3ACF720
	|-ReadOnlyCollection<Detail.NotificationEventInt>.Contains
	|
	|-RVA: 0x3AD0820 Offset: 0x3AD0921 VA: 0x3AD0820
	|-ReadOnlyCollection<DragonRideTargetGroup.ChainParam>.Contains
	|
	|-RVA: 0x3AD1830 Offset: 0x3AD1931 VA: 0x3AD1830
	|-ReadOnlyCollection<GmapPathAdjuster.TargetModel>.Contains
	|
	|-RVA: 0x3AD28F0 Offset: 0x3AD29F1 VA: 0x3AD28F0
	|-ReadOnlyCollection<GmapSpotAdjuster.TargetModel>.Contains
	|
	|-RVA: 0x3AD39B0 Offset: 0x3AD3AB1 VA: 0x3AD39B0
	|-ReadOnlyCollection<HubFastTravel.Location>.Contains
	|
	|-RVA: 0x3AD4A80 Offset: 0x3AD4B81 VA: 0x3AD4A80
	|-ReadOnlyCollection<HubLensFlare.Flare>.Contains
	|
	|-RVA: 0x3AD5B80 Offset: 0x3AD5C81 VA: 0x3AD5B80
	|-ReadOnlyCollection<InventoryPoolItemMenuContent.KindBgNameClass>.Contains
	|
	|-RVA: 0x3AD6B70 Offset: 0x3AD6C71 VA: 0x3AD6B70
	|-ReadOnlyCollection<Map.Pos>.Contains
	|
	|-RVA: 0x3AD7B50 Offset: 0x3AD7C51 VA: 0x3AD7B50
	|-ReadOnlyCollection<MapImage.BackupTerrain>.Contains
	|
	|-RVA: 0x3AD8B50 Offset: 0x3AD8C51 VA: 0x3AD8B50
	|-ReadOnlyCollection<MapImageRange.Pos>.Contains
	|
	|-RVA: 0x3AD9B80 Offset: 0x3AD9C81 VA: 0x3AD9B80
	|-ReadOnlyCollection<MapMind.Target>.Contains
	|
	|-RVA: 0x38C4560 Offset: 0x38C4661 VA: 0x38C4560
	|-ReadOnlyCollection<MapPanelDebug.Entity>.Contains
	|
	|-RVA: 0x38C5600 Offset: 0x38C5701 VA: 0x38C5600
	|-ReadOnlyCollection<NexRanking.Data>.Contains
	|
	|-RVA: 0x38C65E0 Offset: 0x38C66E1 VA: 0x38C65E0
	|-ReadOnlyCollection<NexVersus.RatingData>.Contains
	|
	|-RVA: 0x38C75D0 Offset: 0x38C76D1 VA: 0x38C75D0
	|-ReadOnlyCollection<PackedPlayModeBuildLogs.RuntimeBuildLog>.Contains
	|
	|-RVA: 0x38C85E0 Offset: 0x38C86E1 VA: 0x38C85E0
	|-ReadOnlyCollection<ParticleSystem.Particle>.Contains
	|
	|-RVA: 0x38C96E0 Offset: 0x38C97E1 VA: 0x38C96E0
	|-ReadOnlyCollection<RangeData.Offset>.Contains
	|
	|-RVA: 0x38CA6E0 Offset: 0x38CA7E1 VA: 0x38CA6E0
	|-ReadOnlyCollection<RenderGraphDebugData.PassDebugData>.Contains
	|
	|-RVA: 0x38CB7B0 Offset: 0x38CB8B1 VA: 0x38CB7B0
	|-ReadOnlyCollection<RenderGraphDebugData.ResourceDebugData>.Contains
	|
	|-RVA: 0x38CC8A0 Offset: 0x38CC9A1 VA: 0x38CC8A0
	|-ReadOnlyCollection<RingCleaningUnitSelectMenu.GodParam>.Contains
	|
	|-RVA: 0x38CD8C0 Offset: 0x38CD9C1 VA: 0x38CD8C0
	|-ReadOnlyCollection<ShadowUtility.Edge>.Contains
	|
	|-RVA: 0x38CE9D0 Offset: 0x38CEAD1 VA: 0x38CE9D0
	|-ReadOnlyCollection<SkillArray.Entity>.Contains
	|
	|-RVA: 0x38CFA10 Offset: 0x38CFB11 VA: 0x38CFA10
	|-ReadOnlyCollection<TexturePacker_JsonArray.Frame>.Contains
	|
	|-RVA: 0x38D0B90 Offset: 0x38D0C91 VA: 0x38D0B90
	|-ReadOnlyCollection<TimeNotificationBehaviour.NotificationEntry>.Contains
	|
	|-RVA: 0x38D1C50 Offset: 0x38D1D51 VA: 0x38D1C50
	|-ReadOnlyCollection<UnitySynchronizationContext.WorkRequest>.Contains
	|
	|-RVA: 0x38D2CF0 Offset: 0x38D2DF1 VA: 0x38D2CF0
	|-ReadOnlyCollection<XmlSchemaObjectTable.XmlSchemaObjectEntry>.Contains
	|
	|-RVA: 0x38D3CE0 Offset: 0x38D3DE1 VA: 0x38D3CE0
	|-ReadOnlyCollection<AssetBundleBuildMap.AssetBundleEntry.AssetPathString>.Contains
	|
	|-RVA: 0x38D4D00 Offset: 0x38D4E01 VA: 0x38D4D00
	|-ReadOnlyCollection<Detail.DataStore.DataStoreChangeMetaParamInt>.Contains
	|
	|-RVA: 0x38D5E10 Offset: 0x38D5F11 VA: 0x38D5E10
	|-ReadOnlyCollection<Detail.DataStore.DataStoreDeleteParamInt>.Contains
	|
	|-RVA: 0x38D6E30 Offset: 0x38D6F31 VA: 0x38D6E30
	|-ReadOnlyCollection<Detail.DataStore.DataStoreGetMetaParamInt>.Contains
	|
	|-RVA: 0x38D7F40 Offset: 0x38D8041 VA: 0x38D7F40
	|-ReadOnlyCollection<Detail.DataStore.DataStoreMetaInfoInt>.Contains
	|
	|-RVA: 0x38D9060 Offset: 0x38D9161 VA: 0x38D9060
	|-ReadOnlyCollection<Detail.DataStore.DataStorePasswordInfoInt>.Contains
	|
	|-RVA: 0x38DA120 Offset: 0x38DA221 VA: 0x38DA120
	|-ReadOnlyCollection<Detail.DataStore.DataStorePersistenceInfoInt>.Contains
	|
	|-RVA: 0x38DB1E0 Offset: 0x38DB2E1 VA: 0x38DB1E0
	|-ReadOnlyCollection<Detail.DataStore.DataStorePreparePostParamInt>.Contains
	|
	|-RVA: 0x38DC2E0 Offset: 0x38DC3E1 VA: 0x38DC2E0
	|-ReadOnlyCollection<Detail.DataStore.DataStoreRateObjectParamInt>.Contains
	|
	|-RVA: 0x38DD2F0 Offset: 0x38DD3F1 VA: 0x38DD2F0
	|-ReadOnlyCollection<Detail.DataStore.DataStoreRatingInitParamInt>.Contains
	|
	|-RVA: 0x38DE390 Offset: 0x38DE491 VA: 0x38DE390
	|-ReadOnlyCollection<Detail.DataStore.DataStoreRatingTargetInt>.Contains
	|
	|-RVA: 0x38DF3B0 Offset: 0x38DF4B1 VA: 0x38DF3B0
	|-ReadOnlyCollection<Detail.Ranking.RankingCachedResultInt>.Contains
	|
	|-RVA: 0x38E0510 Offset: 0x38E0611 VA: 0x38E0510
	|-ReadOnlyCollection<Detail.Ranking.RankingOrderParamInt>.Contains
	|
	|-RVA: 0x38E1530 Offset: 0x38E1631 VA: 0x38E1530
	|-ReadOnlyCollection<Detail.Ranking.RankingRankDataInt>.Contains
	|
	|-RVA: 0x38E26D0 Offset: 0x38E27D1 VA: 0x38E26D0
	|-ReadOnlyCollection<Detail.Ranking2.Ranking2ChartInfoInt>.Contains
	|
	|-RVA: 0x38E39D0 Offset: 0x38E3AD1 VA: 0x38E39D0
	|-ReadOnlyCollection<Detail.Ranking2.Ranking2RankDataInt>.Contains
	|
	|-RVA: 0x38E4B30 Offset: 0x38E4C31 VA: 0x38E4B30
	|-ReadOnlyCollection<Detail.Ranking2.Ranking2ScoreDataInt>.Contains
	|
	|-RVA: 0x38E5B40 Offset: 0x38E5C41 VA: 0x38E5B40
	|-ReadOnlyCollection<Detail.Screening.ScreeningContextInfoInt>.Contains
	|
	|-RVA: 0x38E6C20 Offset: 0x38E6D21 VA: 0x38E6C20
	|-ReadOnlyCollection<Detail.Subscriber.SubscriberContentInt>.Contains
	|
	|-RVA: 0x38E7E50 Offset: 0x38E7F51 VA: 0x38E7E50
	|-ReadOnlyCollection<Detail.Subscriber.SubscriberGetContentParamInt>.Contains
	|
	|-RVA: 0x38E8F20 Offset: 0x38E9021 VA: 0x38E8F20
	|-ReadOnlyCollection<Detail.Subscriber.SubscriberUserStatusInfoInt>.Contains
	|
	|-RVA: 0x38EA030 Offset: 0x38EA131 VA: 0x38EA030
	|-ReadOnlyCollection<Detail.Subscriber.SubscriberUserStatusParamInt>.Contains
	|
	|-RVA: 0x38EB0D0 Offset: 0x38EB1D1 VA: 0x38EB0D0
	|-ReadOnlyCollection<Detail.Utility.IntegerSettings>.Contains
	|
	|-RVA: 0x38EC0B0 Offset: 0x38EC1B1 VA: 0x38EC0B0
	|-ReadOnlyCollection<Detail.Utility.UniqueIdInfoInt>.Contains
	|
	|-RVA: 0x38ED0B0 Offset: 0x38ED1B1 VA: 0x38ED0B0
	|-ReadOnlyCollection<MapHistory.Rewind.LatestInspectorData>.Contains
	|
	|-RVA: 0x38EE0E0 Offset: 0x38EE1E1 VA: 0x38EE0E0
	|-ReadOnlyCollection<MapHistory.Rewind.WorkTerrainData>.Contains
	|
	|-RVA: 0x38EF100 Offset: 0x38EF201 VA: 0x38EF100
	|-ReadOnlyCollection<MapSkill.AroundCalculator.Result>.Contains
	|
	|-RVA: 0x38F0120 Offset: 0x38F0221 VA: 0x38F0120
	|-ReadOnlyCollection<TargetPositionCache.CacheCurve.Item>.Contains
	|
	|-RVA: 0x2FE56A0 Offset: 0x2FE57A1 VA: 0x2FE56A0
	|-ReadOnlyCollection<TargetPositionCache.CacheEntry.RecordingItem>.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public void CopyTo(T[] array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3467600 Offset: 0x3467701 VA: 0x3467600
	|-ReadOnlyCollection<IntervalTree.Entry<object>>.CopyTo
	|
	|-RVA: 0x3468670 Offset: 0x3468771 VA: 0x3468670
	|-ReadOnlyCollection<KeyValuePair<DateTime, object>>.CopyTo
	|
	|-RVA: 0x3469660 Offset: 0x3469761 VA: 0x3469660
	|-ReadOnlyCollection<KeyValuePair<int, object>>.CopyTo
	|
	|-RVA: 0x346A6A0 Offset: 0x346A7A1 VA: 0x346A6A0
	|-ReadOnlyCollection<KeyValuePair<object, ValueTuple<int, DateTime, object>>>.CopyTo
	|
	|-RVA: 0x346B710 Offset: 0x346B811 VA: 0x346B710
	|-ReadOnlyCollection<KeyValuePair<object, object>>.CopyTo
	|
	|-RVA: 0x346C750 Offset: 0x346C851 VA: 0x346C750
	|-ReadOnlyCollection<CommonBattleSequence.Reliance<object>>.CopyTo
	|
	|-RVA: 0x346D7C0 Offset: 0x346D8C1 VA: 0x346D7C0
	|-ReadOnlyCollection<RenderGraphResourcePool.ResourceLogInfo<object>>.CopyTo
	|
	|-RVA: 0x346E7B0 Offset: 0x346E8B1 VA: 0x346E7B0
	|-ReadOnlyCollection<ValueTuple<int, object>>.CopyTo
	|
	|-RVA: 0x346F790 Offset: 0x346F891 VA: 0x346F790
	|-ReadOnlyCollection<ValueTuple<Int32Enum, int>>.CopyTo
	|
	|-RVA: 0x34707D0 Offset: 0x34708D1 VA: 0x34707D0
	|-ReadOnlyCollection<ValueTuple<object, ValueTuple<object, int>>>.CopyTo
	|
	|-RVA: 0x3471840 Offset: 0x3471941 VA: 0x3471840
	|-ReadOnlyCollection<ValueTuple<object, int>>.CopyTo
	|
	|-RVA: 0x3472840 Offset: 0x3472941 VA: 0x3472840
	|-ReadOnlyCollection<ValueTuple<Vector3, float>>.CopyTo
	|
	|-RVA: 0x3473850 Offset: 0x3473951 VA: 0x3473850
	|-ReadOnlyCollection<ValueTuple<object, Int32Enum, int>>.CopyTo
	|
	|-RVA: 0x3474890 Offset: 0x3474991 VA: 0x3474890
	|-ReadOnlyCollection<ValueTuple<object, int, int, int>>.CopyTo
	|
	|-RVA: 0x34758F0 Offset: 0x34759F1 VA: 0x34758F0
	|-ReadOnlyCollection<AnimatorClipInfo>.CopyTo
	|
	|-RVA: 0x3B226D0 Offset: 0x3B227D1 VA: 0x3B226D0
	|-ReadOnlyCollection<AsyncOperationHandle>.CopyTo
	|
	|-RVA: 0x3B23790 Offset: 0x3B23891 VA: 0x3B23790
	|-ReadOnlyCollection<BoneWeight>.CopyTo
	|
	|-RVA: 0x3B247F0 Offset: 0x3B248F1 VA: 0x3B247F0
	|-ReadOnlyCollection<bool>.CopyTo
	|
	|-RVA: 0x3B257E0 Offset: 0x3B258E1 VA: 0x3B257E0
	|-ReadOnlyCollection<byte>.CopyTo
	|
	|-RVA: 0x3B267D0 Offset: 0x3B268D1 VA: 0x3B267D0
	|-ReadOnlyCollection<CameraInfo>.CopyTo
	|
	|-RVA: 0x3B277B0 Offset: 0x3B278B1 VA: 0x3B277B0
	|-ReadOnlyCollection<char>.CopyTo
	|
	|-RVA: 0x3B287B0 Offset: 0x3B288B1 VA: 0x3B287B0
	|-ReadOnlyCollection<Color>.CopyTo
	|
	|-RVA: 0x3B297D0 Offset: 0x3B298D1 VA: 0x3B297D0
	|-ReadOnlyCollection<Color32>.CopyTo
	|
	|-RVA: 0x3B2A7E0 Offset: 0x3B2A8E1 VA: 0x3B2A7E0
	|-ReadOnlyCollection<ConstraintSource>.CopyTo
	|
	|-RVA: 0x3B2B820 Offset: 0x3B2B921 VA: 0x3B2B820
	|-ReadOnlyCollection<ContourVertex>.CopyTo
	|
	|-RVA: 0x3B2C8E0 Offset: 0x3B2C9E1 VA: 0x3B2C8E0
	|-ReadOnlyCollection<CustomAttributeNamedArgument>.CopyTo
	|
	|-RVA: 0x3B2D950 Offset: 0x3B2DA51 VA: 0x3B2D950
	|-ReadOnlyCollection<CustomAttributeTypedArgument>.CopyTo
	|
	|-RVA: 0x3B2E990 Offset: 0x3B2EA91 VA: 0x3B2E990
	|-ReadOnlyCollection<DataStoreRatingInfo>.CopyTo
	|
	|-RVA: 0x3B2F9F0 Offset: 0x3B2FAF1 VA: 0x3B2F9F0
	|-ReadOnlyCollection<DataStoreResult>.CopyTo
	|
	|-RVA: 0x3B309D0 Offset: 0x3B30AD1 VA: 0x3B309D0
	|-ReadOnlyCollection<DateTime>.CopyTo
	|
	|-RVA: 0x3B319C0 Offset: 0x3B31AC1 VA: 0x3B319C0
	|-ReadOnlyCollection<DateTimeOffset>.CopyTo
	|
	|-RVA: 0x3B329B0 Offset: 0x3B32AB1 VA: 0x3B329B0
	|-ReadOnlyCollection<Decimal>.CopyTo
	|
	|-RVA: 0x3B33A10 Offset: 0x3B33B11 VA: 0x3B33A10
	|-ReadOnlyCollection<DiagnosticEvent>.CopyTo
	|
	|-RVA: 0x3B34AC0 Offset: 0x3B34BC1 VA: 0x3B34AC0
	|-ReadOnlyCollection<double>.CopyTo
	|
	|-RVA: 0x3B41D20 Offset: 0x3B41E21 VA: 0x3B41D20
	|-ReadOnlyCollection<Exception>.CopyTo
	|-ReadOnlyCollection<object>.CopyTo
	|
	|-RVA: 0x3B35B30 Offset: 0x3B35C31 VA: 0x3B35B30
	|-ReadOnlyCollection<Friend>.CopyTo
	|
	|-RVA: 0x3B36BE0 Offset: 0x3B36CE1 VA: 0x3B36BE0
	|-ReadOnlyCollection<GlyphRect>.CopyTo
	|
	|-RVA: 0x3B37BC0 Offset: 0x3B37CC1 VA: 0x3B37BC0
	|-ReadOnlyCollection<short>.CopyTo
	|
	|-RVA: 0x3B38BA0 Offset: 0x3B38CA1 VA: 0x3B38BA0
	|-ReadOnlyCollection<int>.CopyTo
	|
	|-RVA: 0x3B39B80 Offset: 0x3B39C81 VA: 0x3B39B80
	|-ReadOnlyCollection<Int32Enum>.CopyTo
	|
	|-RVA: 0x3B3AB60 Offset: 0x3B3AC61 VA: 0x3B3AB60
	|-ReadOnlyCollection<long>.CopyTo
	|
	|-RVA: 0x3B3BB40 Offset: 0x3B3BC41 VA: 0x3B3BB40
	|-ReadOnlyCollection<IntPtr>.CopyTo
	|
	|-RVA: 0x3B3CB30 Offset: 0x3B3CC31 VA: 0x3B3CB30
	|-ReadOnlyCollection<InterpretedFrameInfo>.CopyTo
	|
	|-RVA: 0x3B3DB70 Offset: 0x3B3DC71 VA: 0x3B3DB70
	|-ReadOnlyCollection<IntervalTreeNode>.CopyTo
	|
	|-RVA: 0x3B3EBD0 Offset: 0x3B3ECD1 VA: 0x3B3EBD0
	|-ReadOnlyCollection<LengthLimitProperties>.CopyTo
	|
	|-RVA: 0x3B3FBB0 Offset: 0x3B3FCB1 VA: 0x3B3FBB0
	|-ReadOnlyCollection<MapPos>.CopyTo
	|
	|-RVA: 0x3B40C30 Offset: 0x3B40D31 VA: 0x3B40C30
	|-ReadOnlyCollection<Matrix4x4>.CopyTo
	|
	|-RVA: 0x3B42C90 Offset: 0x3B42D91 VA: 0x3B42C90
	|-ReadOnlyCollection<ObjectInitializationData>.CopyTo
	|
	|-RVA: 0x3B43DA0 Offset: 0x3B43EA1 VA: 0x3B43DA0
	|-ReadOnlyCollection<PlayableBinding>.CopyTo
	|
	|-RVA: 0x3B44E80 Offset: 0x3B44F81 VA: 0x3B44E80
	|-ReadOnlyCollection<PlayerLoopSystem>.CopyTo
	|
	|-RVA: 0x3B45FA0 Offset: 0x3B460A1 VA: 0x3B45FA0
	|-ReadOnlyCollection<PlayerLoopSystemInternal>.CopyTo
	|
	|-RVA: 0x3B47050 Offset: 0x3B47151 VA: 0x3B47050
	|-ReadOnlyCollection<RangePositionInfo>.CopyTo
	|
	|-RVA: 0x3B48030 Offset: 0x3B48131 VA: 0x3B48030
	|-ReadOnlyCollection<Ranking2ChartInfoInput>.CopyTo
	|
	|-RVA: 0x3B490A0 Offset: 0x3B491A1 VA: 0x3B490A0
	|-ReadOnlyCollection<RaycastHit2D>.CopyTo
	|
	|-RVA: 0x3B4A230 Offset: 0x3B4A331 VA: 0x3B4A230
	|-ReadOnlyCollection<RaycastResult>.CopyTo
	|
	|-RVA: 0x3B4B3E0 Offset: 0x3B4B4E1 VA: 0x3B4B3E0
	|-ReadOnlyCollection<Rect>.CopyTo
	|
	|-RVA: 0x3B4C3E0 Offset: 0x3B4C4E1 VA: 0x3B4C3E0
	|-ReadOnlyCollection<RendererListHandle>.CopyTo
	|
	|-RVA: 0x3B4D3C0 Offset: 0x3B4D4C1 VA: 0x3B4D3C0
	|-ReadOnlyCollection<ResourceHandle>.CopyTo
	|
	|-RVA: 0x3AAEA80 Offset: 0x3AAEB81 VA: 0x3AAEA80
	|-ReadOnlyCollection<sbyte>.CopyTo
	|
	|-RVA: 0x3AAFA80 Offset: 0x3AAFB81 VA: 0x3AAFA80
	|-ReadOnlyCollection<ShaderTagId>.CopyTo
	|
	|-RVA: 0x3AB0A80 Offset: 0x3AB0B81 VA: 0x3AB0A80
	|-ReadOnlyCollection<float>.CopyTo
	|
	|-RVA: 0x3AB1B80 Offset: 0x3AB1C81 VA: 0x3AB1B80
	|-ReadOnlyCollection<SphericalHarmonicsL2>.CopyTo
	|
	|-RVA: 0x3AB2ED0 Offset: 0x3AB2FD1 VA: 0x3AB2ED0
	|-ReadOnlyCollection<SubMeshDescriptor>.CopyTo
	|
	|-RVA: 0x3AB3F90 Offset: 0x3AB4091 VA: 0x3AB3F90
	|-ReadOnlyCollection<TablePair>.CopyTo
	|
	|-RVA: 0x3AB4F70 Offset: 0x3AB5071 VA: 0x3AB4F70
	|-ReadOnlyCollection<TimeSpan>.CopyTo
	|
	|-RVA: 0x3AB5F70 Offset: 0x3AB6071 VA: 0x3AB5F70
	|-ReadOnlyCollection<UICharInfo>.CopyTo
	|
	|-RVA: 0x3AB6F80 Offset: 0x3AB7081 VA: 0x3AB6F80
	|-ReadOnlyCollection<UILineInfo>.CopyTo
	|
	|-RVA: 0x3AB8080 Offset: 0x3AB8181 VA: 0x3AB8080
	|-ReadOnlyCollection<UIVertex>.CopyTo
	|
	|-RVA: 0x3AB9350 Offset: 0x3AB9451 VA: 0x3AB9350
	|-ReadOnlyCollection<ushort>.CopyTo
	|
	|-RVA: 0x3ABA330 Offset: 0x3ABA431 VA: 0x3ABA330
	|-ReadOnlyCollection<uint>.CopyTo
	|
	|-RVA: 0x3ABB310 Offset: 0x3ABB411 VA: 0x3ABB310
	|-ReadOnlyCollection<ulong>.CopyTo
	|
	|-RVA: 0x3ABC300 Offset: 0x3ABC401 VA: 0x3ABC300
	|-ReadOnlyCollection<Vector2>.CopyTo
	|
	|-RVA: 0x3ABD310 Offset: 0x3ABD411 VA: 0x3ABD310
	|-ReadOnlyCollection<Vector3>.CopyTo
	|
	|-RVA: 0x3ABE330 Offset: 0x3ABE431 VA: 0x3ABE330
	|-ReadOnlyCollection<Vector4>.CopyTo
	|
	|-RVA: 0x3ABF340 Offset: 0x3ABF441 VA: 0x3ABF340
	|-ReadOnlyCollection<VertexAttributeDescriptor>.CopyTo
	|
	|-RVA: 0x3AC0330 Offset: 0x3AC0431 VA: 0x3AC0330
	|-ReadOnlyCollection<X509ChainStatus>.CopyTo
	|
	|-RVA: 0x3AC1380 Offset: 0x3AC1481 VA: 0x3AC1380
	|-ReadOnlyCollection<XRView>.CopyTo
	|
	|-RVA: 0x3AC2450 Offset: 0x3AC2551 VA: 0x3AC2450
	|-ReadOnlyCollection<AICrossfire.PositionTable>.CopyTo
	|
	|-RVA: 0x3AC3470 Offset: 0x3AC3571 VA: 0x3AC3470
	|-ReadOnlyCollection<AmiiboSequence.GainItemData>.CopyTo
	|
	|-RVA: 0x3AC44D0 Offset: 0x3AC45D1 VA: 0x3AC44D0
	|-ReadOnlyCollection<AnimationOutputWeightProcessor.WeightInfo>.CopyTo
	|
	|-RVA: 0x3AC5580 Offset: 0x3AC5681 VA: 0x3AC5580
	|-ReadOnlyCollection<ArenaOrderSequence.GodInfo>.CopyTo
	|
	|-RVA: 0x3AC6570 Offset: 0x3AC6671 VA: 0x3AC6570
	|-ReadOnlyCollection<BattleInfo.SupportData>.CopyTo
	|
	|-RVA: 0x3AC7560 Offset: 0x3AC7661 VA: 0x3AC7560
	|-ReadOnlyCollection<BeforeRenderHelper.OrderBlock>.CopyTo
	|
	|-RVA: 0x3AC85A0 Offset: 0x3AC86A1 VA: 0x3AC85A0
	|-ReadOnlyCollection<Camera.RenderRequest>.CopyTo
	|
	|-RVA: 0x3AC9610 Offset: 0x3AC9711 VA: 0x3AC9610
	|-ReadOnlyCollection<CameraState.CustomBlendable>.CopyTo
	|
	|-RVA: 0x3ACA5F0 Offset: 0x3ACA6F1 VA: 0x3ACA5F0
	|-ReadOnlyCollection<CinemachineClearShot.Pair>.CopyTo
	|
	|-RVA: 0x3ACB5D0 Offset: 0x3ACB6D1 VA: 0x3ACB5D0
	|-ReadOnlyCollection<CinemachineStateDrivenCamera.HashPair>.CopyTo
	|
	|-RVA: 0x3ACC610 Offset: 0x3ACC711 VA: 0x3ACC610
	|-ReadOnlyCollection<DelayedActionManager.DelegateInfo>.CopyTo
	|
	|-RVA: 0x3ACD6F0 Offset: 0x3ACD7F1 VA: 0x3ACD6F0
	|-ReadOnlyCollection<Detail.AsyncResultInt>.CopyTo
	|
	|-RVA: 0x3ACE7B0 Offset: 0x3ACE8B1 VA: 0x3ACE7B0
	|-ReadOnlyCollection<Detail.CppArray>.CopyTo
	|
	|-RVA: 0x3ACF810 Offset: 0x3ACF911 VA: 0x3ACF810
	|-ReadOnlyCollection<Detail.NotificationEventInt>.CopyTo
	|
	|-RVA: 0x3AD08D0 Offset: 0x3AD09D1 VA: 0x3AD08D0
	|-ReadOnlyCollection<DragonRideTargetGroup.ChainParam>.CopyTo
	|
	|-RVA: 0x3AD1910 Offset: 0x3AD1A11 VA: 0x3AD1910
	|-ReadOnlyCollection<GmapPathAdjuster.TargetModel>.CopyTo
	|
	|-RVA: 0x3AD29D0 Offset: 0x3AD2AD1 VA: 0x3AD29D0
	|-ReadOnlyCollection<GmapSpotAdjuster.TargetModel>.CopyTo
	|
	|-RVA: 0x3AD3A90 Offset: 0x3AD3B91 VA: 0x3AD3A90
	|-ReadOnlyCollection<HubFastTravel.Location>.CopyTo
	|
	|-RVA: 0x3AD4B70 Offset: 0x3AD4C71 VA: 0x3AD4B70
	|-ReadOnlyCollection<HubLensFlare.Flare>.CopyTo
	|
	|-RVA: 0x3AD5C30 Offset: 0x3AD5D31 VA: 0x3AD5C30
	|-ReadOnlyCollection<InventoryPoolItemMenuContent.KindBgNameClass>.CopyTo
	|
	|-RVA: 0x3AD6C10 Offset: 0x3AD6D11 VA: 0x3AD6C10
	|-ReadOnlyCollection<Map.Pos>.CopyTo
	|
	|-RVA: 0x3AD7C00 Offset: 0x3AD7D01 VA: 0x3AD7C00
	|-ReadOnlyCollection<MapImage.BackupTerrain>.CopyTo
	|
	|-RVA: 0x3AD8C00 Offset: 0x3AD8D01 VA: 0x3AD8C00
	|-ReadOnlyCollection<MapImageRange.Pos>.CopyTo
	|
	|-RVA: 0x3AD9C60 Offset: 0x3AD9D61 VA: 0x3AD9C60
	|-ReadOnlyCollection<MapMind.Target>.CopyTo
	|
	|-RVA: 0x38C4640 Offset: 0x38C4741 VA: 0x38C4640
	|-ReadOnlyCollection<MapPanelDebug.Entity>.CopyTo
	|
	|-RVA: 0x38C56A0 Offset: 0x38C57A1 VA: 0x38C56A0
	|-ReadOnlyCollection<NexRanking.Data>.CopyTo
	|
	|-RVA: 0x38C6690 Offset: 0x38C6791 VA: 0x38C6690
	|-ReadOnlyCollection<NexVersus.RatingData>.CopyTo
	|
	|-RVA: 0x38C7680 Offset: 0x38C7781 VA: 0x38C7680
	|-ReadOnlyCollection<PackedPlayModeBuildLogs.RuntimeBuildLog>.CopyTo
	|
	|-RVA: 0x38C86D0 Offset: 0x38C87D1 VA: 0x38C86D0
	|-ReadOnlyCollection<ParticleSystem.Particle>.CopyTo
	|
	|-RVA: 0x38C9780 Offset: 0x38C9881 VA: 0x38C9780
	|-ReadOnlyCollection<RangeData.Offset>.CopyTo
	|
	|-RVA: 0x38CA7C0 Offset: 0x38CA8C1 VA: 0x38CA7C0
	|-ReadOnlyCollection<RenderGraphDebugData.PassDebugData>.CopyTo
	|
	|-RVA: 0x38CB8A0 Offset: 0x38CB9A1 VA: 0x38CB8A0
	|-ReadOnlyCollection<RenderGraphDebugData.ResourceDebugData>.CopyTo
	|
	|-RVA: 0x38CC950 Offset: 0x38CCA51 VA: 0x38CC950
	|-ReadOnlyCollection<RingCleaningUnitSelectMenu.GodParam>.CopyTo
	|
	|-RVA: 0x38CD9B0 Offset: 0x38CDAB1 VA: 0x38CD9B0
	|-ReadOnlyCollection<ShadowUtility.Edge>.CopyTo
	|
	|-RVA: 0x38CEA80 Offset: 0x38CEB81 VA: 0x38CEA80
	|-ReadOnlyCollection<SkillArray.Entity>.CopyTo
	|
	|-RVA: 0x38CFB20 Offset: 0x38CFC21 VA: 0x38CFB20
	|-ReadOnlyCollection<TexturePacker_JsonArray.Frame>.CopyTo
	|
	|-RVA: 0x38D0C70 Offset: 0x38D0D71 VA: 0x38D0C70
	|-ReadOnlyCollection<TimeNotificationBehaviour.NotificationEntry>.CopyTo
	|
	|-RVA: 0x38D1D30 Offset: 0x38D1E31 VA: 0x38D1D30
	|-ReadOnlyCollection<UnitySynchronizationContext.WorkRequest>.CopyTo
	|
	|-RVA: 0x38D2DA0 Offset: 0x38D2EA1 VA: 0x38D2DA0
	|-ReadOnlyCollection<XmlSchemaObjectTable.XmlSchemaObjectEntry>.CopyTo
	|
	|-RVA: 0x38D3D90 Offset: 0x38D3E91 VA: 0x38D3D90
	|-ReadOnlyCollection<AssetBundleBuildMap.AssetBundleEntry.AssetPathString>.CopyTo
	|
	|-RVA: 0x38D4DF0 Offset: 0x38D4EF1 VA: 0x38D4DF0
	|-ReadOnlyCollection<Detail.DataStore.DataStoreChangeMetaParamInt>.CopyTo
	|
	|-RVA: 0x38D5EC0 Offset: 0x38D5FC1 VA: 0x38D5EC0
	|-ReadOnlyCollection<Detail.DataStore.DataStoreDeleteParamInt>.CopyTo
	|
	|-RVA: 0x38D6F20 Offset: 0x38D7021 VA: 0x38D6F20
	|-ReadOnlyCollection<Detail.DataStore.DataStoreGetMetaParamInt>.CopyTo
	|
	|-RVA: 0x38D8030 Offset: 0x38D8131 VA: 0x38D8030
	|-ReadOnlyCollection<Detail.DataStore.DataStoreMetaInfoInt>.CopyTo
	|
	|-RVA: 0x38D9140 Offset: 0x38D9241 VA: 0x38D9140
	|-ReadOnlyCollection<Detail.DataStore.DataStorePasswordInfoInt>.CopyTo
	|
	|-RVA: 0x38DA200 Offset: 0x38DA301 VA: 0x38DA200
	|-ReadOnlyCollection<Detail.DataStore.DataStorePersistenceInfoInt>.CopyTo
	|
	|-RVA: 0x38DB2D0 Offset: 0x38DB3D1 VA: 0x38DB2D0
	|-ReadOnlyCollection<Detail.DataStore.DataStorePreparePostParamInt>.CopyTo
	|
	|-RVA: 0x38DC390 Offset: 0x38DC491 VA: 0x38DC390
	|-ReadOnlyCollection<Detail.DataStore.DataStoreRateObjectParamInt>.CopyTo
	|
	|-RVA: 0x38DD3D0 Offset: 0x38DD4D1 VA: 0x38DD3D0
	|-ReadOnlyCollection<Detail.DataStore.DataStoreRatingInitParamInt>.CopyTo
	|
	|-RVA: 0x38DE440 Offset: 0x38DE541 VA: 0x38DE440
	|-ReadOnlyCollection<Detail.DataStore.DataStoreRatingTargetInt>.CopyTo
	|
	|-RVA: 0x38DF4C0 Offset: 0x38DF5C1 VA: 0x38DF4C0
	|-ReadOnlyCollection<Detail.Ranking.RankingCachedResultInt>.CopyTo
	|
	|-RVA: 0x38E05C0 Offset: 0x38E06C1 VA: 0x38E05C0
	|-ReadOnlyCollection<Detail.Ranking.RankingOrderParamInt>.CopyTo
	|
	|-RVA: 0x38E1640 Offset: 0x38E1741 VA: 0x38E1640
	|-ReadOnlyCollection<Detail.Ranking.RankingRankDataInt>.CopyTo
	|
	|-RVA: 0x38E2810 Offset: 0x38E2911 VA: 0x38E2810
	|-ReadOnlyCollection<Detail.Ranking2.Ranking2ChartInfoInt>.CopyTo
	|
	|-RVA: 0x38E3AE0 Offset: 0x38E3BE1 VA: 0x38E3AE0
	|-ReadOnlyCollection<Detail.Ranking2.Ranking2RankDataInt>.CopyTo
	|
	|-RVA: 0x38E4BE0 Offset: 0x38E4CE1 VA: 0x38E4BE0
	|-ReadOnlyCollection<Detail.Ranking2.Ranking2ScoreDataInt>.CopyTo
	|
	|-RVA: 0x38E5C20 Offset: 0x38E5D21 VA: 0x38E5C20
	|-ReadOnlyCollection<Detail.Screening.ScreeningContextInfoInt>.CopyTo
	|
	|-RVA: 0x38E6D40 Offset: 0x38E6E41 VA: 0x38E6D40
	|-ReadOnlyCollection<Detail.Subscriber.SubscriberContentInt>.CopyTo
	|
	|-RVA: 0x38E7F30 Offset: 0x38E8031 VA: 0x38E7F30
	|-ReadOnlyCollection<Detail.Subscriber.SubscriberGetContentParamInt>.CopyTo
	|
	|-RVA: 0x38E9010 Offset: 0x38E9111 VA: 0x38E9010
	|-ReadOnlyCollection<Detail.Subscriber.SubscriberUserStatusInfoInt>.CopyTo
	|
	|-RVA: 0x38EA110 Offset: 0x38EA211 VA: 0x38EA110
	|-ReadOnlyCollection<Detail.Subscriber.SubscriberUserStatusParamInt>.CopyTo
	|
	|-RVA: 0x38EB170 Offset: 0x38EB271 VA: 0x38EB170
	|-ReadOnlyCollection<Detail.Utility.IntegerSettings>.CopyTo
	|
	|-RVA: 0x38EC160 Offset: 0x38EC261 VA: 0x38EC160
	|-ReadOnlyCollection<Detail.Utility.UniqueIdInfoInt>.CopyTo
	|
	|-RVA: 0x38ED160 Offset: 0x38ED261 VA: 0x38ED160
	|-ReadOnlyCollection<MapHistory.Rewind.LatestInspectorData>.CopyTo
	|
	|-RVA: 0x38EE190 Offset: 0x38EE291 VA: 0x38EE190
	|-ReadOnlyCollection<MapHistory.Rewind.WorkTerrainData>.CopyTo
	|
	|-RVA: 0x38EF1B0 Offset: 0x38EF2B1 VA: 0x38EF1B0
	|-ReadOnlyCollection<MapSkill.AroundCalculator.Result>.CopyTo
	|
	|-RVA: 0x38F0210 Offset: 0x38F0311 VA: 0x38F0210
	|-ReadOnlyCollection<TargetPositionCache.CacheCurve.Item>.CopyTo
	|
	|-RVA: 0x2FE57A0 Offset: 0x2FE58A1 VA: 0x2FE57A0
	|-ReadOnlyCollection<TargetPositionCache.CacheEntry.RecordingItem>.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 16
	public IEnumerator<T> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34676B0 Offset: 0x34677B1 VA: 0x34676B0
	|-ReadOnlyCollection<IntervalTree.Entry<object>>.GetEnumerator
	|
	|-RVA: 0x3468720 Offset: 0x3468821 VA: 0x3468720
	|-ReadOnlyCollection<KeyValuePair<DateTime, object>>.GetEnumerator
	|
	|-RVA: 0x3469710 Offset: 0x3469811 VA: 0x3469710
	|-ReadOnlyCollection<KeyValuePair<int, object>>.GetEnumerator
	|
	|-RVA: 0x346A750 Offset: 0x346A851 VA: 0x346A750
	|-ReadOnlyCollection<KeyValuePair<object, ValueTuple<int, DateTime, object>>>.GetEnumerator
	|
	|-RVA: 0x346B7C0 Offset: 0x346B8C1 VA: 0x346B7C0
	|-ReadOnlyCollection<KeyValuePair<object, object>>.GetEnumerator
	|
	|-RVA: 0x346C800 Offset: 0x346C901 VA: 0x346C800
	|-ReadOnlyCollection<CommonBattleSequence.Reliance<object>>.GetEnumerator
	|
	|-RVA: 0x346D870 Offset: 0x346D971 VA: 0x346D870
	|-ReadOnlyCollection<RenderGraphResourcePool.ResourceLogInfo<object>>.GetEnumerator
	|
	|-RVA: 0x346E860 Offset: 0x346E961 VA: 0x346E860
	|-ReadOnlyCollection<ValueTuple<int, object>>.GetEnumerator
	|
	|-RVA: 0x346F840 Offset: 0x346F941 VA: 0x346F840
	|-ReadOnlyCollection<ValueTuple<Int32Enum, int>>.GetEnumerator
	|
	|-RVA: 0x3470880 Offset: 0x3470981 VA: 0x3470880
	|-ReadOnlyCollection<ValueTuple<object, ValueTuple<object, int>>>.GetEnumerator
	|
	|-RVA: 0x34718F0 Offset: 0x34719F1 VA: 0x34718F0
	|-ReadOnlyCollection<ValueTuple<object, int>>.GetEnumerator
	|
	|-RVA: 0x34728F0 Offset: 0x34729F1 VA: 0x34728F0
	|-ReadOnlyCollection<ValueTuple<Vector3, float>>.GetEnumerator
	|
	|-RVA: 0x3473900 Offset: 0x3473A01 VA: 0x3473900
	|-ReadOnlyCollection<ValueTuple<object, Int32Enum, int>>.GetEnumerator
	|
	|-RVA: 0x3474940 Offset: 0x3474A41 VA: 0x3474940
	|-ReadOnlyCollection<ValueTuple<object, int, int, int>>.GetEnumerator
	|
	|-RVA: 0x34759A0 Offset: 0x3475AA1 VA: 0x34759A0
	|-ReadOnlyCollection<AnimatorClipInfo>.GetEnumerator
	|
	|-RVA: 0x3B22780 Offset: 0x3B22881 VA: 0x3B22780
	|-ReadOnlyCollection<AsyncOperationHandle>.GetEnumerator
	|
	|-RVA: 0x3B23840 Offset: 0x3B23941 VA: 0x3B23840
	|-ReadOnlyCollection<BoneWeight>.GetEnumerator
	|
	|-RVA: 0x3B248A0 Offset: 0x3B249A1 VA: 0x3B248A0
	|-ReadOnlyCollection<bool>.GetEnumerator
	|
	|-RVA: 0x3B25890 Offset: 0x3B25991 VA: 0x3B25890
	|-ReadOnlyCollection<byte>.GetEnumerator
	|
	|-RVA: 0x3B26880 Offset: 0x3B26981 VA: 0x3B26880
	|-ReadOnlyCollection<CameraInfo>.GetEnumerator
	|
	|-RVA: 0x3B41DD0 Offset: 0x3B41ED1 VA: 0x3B41DD0
	|-ReadOnlyCollection<CatchBlock>.GetEnumerator
	|-ReadOnlyCollection<Exception>.GetEnumerator
	|-ReadOnlyCollection<Expression>.GetEnumerator
	|-ReadOnlyCollection<MemberBinding>.GetEnumerator
	|-ReadOnlyCollection<object>.GetEnumerator
	|-ReadOnlyCollection<ParameterExpression>.GetEnumerator
	|-ReadOnlyCollection<SwitchCase>.GetEnumerator
	|-ReadOnlyCollection<TimeZoneInfo>.GetEnumerator
	|-ReadOnlyCollection<VolumeParameter>.GetEnumerator
	|-ReadOnlyCollection<DebugUI.Panel>.GetEnumerator
	|
	|-RVA: 0x3B27860 Offset: 0x3B27961 VA: 0x3B27860
	|-ReadOnlyCollection<char>.GetEnumerator
	|
	|-RVA: 0x3B28860 Offset: 0x3B28961 VA: 0x3B28860
	|-ReadOnlyCollection<Color>.GetEnumerator
	|
	|-RVA: 0x3B29880 Offset: 0x3B29981 VA: 0x3B29880
	|-ReadOnlyCollection<Color32>.GetEnumerator
	|
	|-RVA: 0x3B2A890 Offset: 0x3B2A991 VA: 0x3B2A890
	|-ReadOnlyCollection<ConstraintSource>.GetEnumerator
	|
	|-RVA: 0x3B2B8D0 Offset: 0x3B2B9D1 VA: 0x3B2B8D0
	|-ReadOnlyCollection<ContourVertex>.GetEnumerator
	|
	|-RVA: 0x3B2C990 Offset: 0x3B2CA91 VA: 0x3B2C990
	|-ReadOnlyCollection<CustomAttributeNamedArgument>.GetEnumerator
	|
	|-RVA: 0x3B2DA00 Offset: 0x3B2DB01 VA: 0x3B2DA00
	|-ReadOnlyCollection<CustomAttributeTypedArgument>.GetEnumerator
	|
	|-RVA: 0x3B2EA40 Offset: 0x3B2EB41 VA: 0x3B2EA40
	|-ReadOnlyCollection<DataStoreRatingInfo>.GetEnumerator
	|
	|-RVA: 0x3B2FAA0 Offset: 0x3B2FBA1 VA: 0x3B2FAA0
	|-ReadOnlyCollection<DataStoreResult>.GetEnumerator
	|
	|-RVA: 0x3B30A80 Offset: 0x3B30B81 VA: 0x3B30A80
	|-ReadOnlyCollection<DateTime>.GetEnumerator
	|
	|-RVA: 0x3B31A70 Offset: 0x3B31B71 VA: 0x3B31A70
	|-ReadOnlyCollection<DateTimeOffset>.GetEnumerator
	|
	|-RVA: 0x3B32A60 Offset: 0x3B32B61 VA: 0x3B32A60
	|-ReadOnlyCollection<Decimal>.GetEnumerator
	|
	|-RVA: 0x3B33AC0 Offset: 0x3B33BC1 VA: 0x3B33AC0
	|-ReadOnlyCollection<DiagnosticEvent>.GetEnumerator
	|
	|-RVA: 0x3B34B70 Offset: 0x3B34C71 VA: 0x3B34B70
	|-ReadOnlyCollection<double>.GetEnumerator
	|
	|-RVA: 0x3B35BE0 Offset: 0x3B35CE1 VA: 0x3B35BE0
	|-ReadOnlyCollection<Friend>.GetEnumerator
	|
	|-RVA: 0x3B36C90 Offset: 0x3B36D91 VA: 0x3B36C90
	|-ReadOnlyCollection<GlyphRect>.GetEnumerator
	|
	|-RVA: 0x3B37C70 Offset: 0x3B37D71 VA: 0x3B37C70
	|-ReadOnlyCollection<short>.GetEnumerator
	|
	|-RVA: 0x3B38C50 Offset: 0x3B38D51 VA: 0x3B38C50
	|-ReadOnlyCollection<int>.GetEnumerator
	|
	|-RVA: 0x3B39C30 Offset: 0x3B39D31 VA: 0x3B39C30
	|-ReadOnlyCollection<Int32Enum>.GetEnumerator
	|
	|-RVA: 0x3B3AC10 Offset: 0x3B3AD11 VA: 0x3B3AC10
	|-ReadOnlyCollection<long>.GetEnumerator
	|
	|-RVA: 0x3B3BBF0 Offset: 0x3B3BCF1 VA: 0x3B3BBF0
	|-ReadOnlyCollection<IntPtr>.GetEnumerator
	|
	|-RVA: 0x3B3CBE0 Offset: 0x3B3CCE1 VA: 0x3B3CBE0
	|-ReadOnlyCollection<InterpretedFrameInfo>.GetEnumerator
	|
	|-RVA: 0x3B3DC20 Offset: 0x3B3DD21 VA: 0x3B3DC20
	|-ReadOnlyCollection<IntervalTreeNode>.GetEnumerator
	|
	|-RVA: 0x3B3EC80 Offset: 0x3B3ED81 VA: 0x3B3EC80
	|-ReadOnlyCollection<LengthLimitProperties>.GetEnumerator
	|
	|-RVA: 0x3B3FC60 Offset: 0x3B3FD61 VA: 0x3B3FC60
	|-ReadOnlyCollection<MapPos>.GetEnumerator
	|
	|-RVA: 0x3B40CE0 Offset: 0x3B40DE1 VA: 0x3B40CE0
	|-ReadOnlyCollection<Matrix4x4>.GetEnumerator
	|
	|-RVA: 0x3B42D40 Offset: 0x3B42E41 VA: 0x3B42D40
	|-ReadOnlyCollection<ObjectInitializationData>.GetEnumerator
	|
	|-RVA: 0x3B43E50 Offset: 0x3B43F51 VA: 0x3B43E50
	|-ReadOnlyCollection<PlayableBinding>.GetEnumerator
	|
	|-RVA: 0x3B44F30 Offset: 0x3B45031 VA: 0x3B44F30
	|-ReadOnlyCollection<PlayerLoopSystem>.GetEnumerator
	|
	|-RVA: 0x3B46050 Offset: 0x3B46151 VA: 0x3B46050
	|-ReadOnlyCollection<PlayerLoopSystemInternal>.GetEnumerator
	|
	|-RVA: 0x3B47100 Offset: 0x3B47201 VA: 0x3B47100
	|-ReadOnlyCollection<RangePositionInfo>.GetEnumerator
	|
	|-RVA: 0x3B480E0 Offset: 0x3B481E1 VA: 0x3B480E0
	|-ReadOnlyCollection<Ranking2ChartInfoInput>.GetEnumerator
	|
	|-RVA: 0x3B49150 Offset: 0x3B49251 VA: 0x3B49150
	|-ReadOnlyCollection<RaycastHit2D>.GetEnumerator
	|
	|-RVA: 0x3B4A2E0 Offset: 0x3B4A3E1 VA: 0x3B4A2E0
	|-ReadOnlyCollection<RaycastResult>.GetEnumerator
	|
	|-RVA: 0x3B4B490 Offset: 0x3B4B591 VA: 0x3B4B490
	|-ReadOnlyCollection<Rect>.GetEnumerator
	|
	|-RVA: 0x3B4C490 Offset: 0x3B4C591 VA: 0x3B4C490
	|-ReadOnlyCollection<RendererListHandle>.GetEnumerator
	|
	|-RVA: 0x3B4D470 Offset: 0x3B4D571 VA: 0x3B4D470
	|-ReadOnlyCollection<ResourceHandle>.GetEnumerator
	|
	|-RVA: 0x3AAEB30 Offset: 0x3AAEC31 VA: 0x3AAEB30
	|-ReadOnlyCollection<sbyte>.GetEnumerator
	|
	|-RVA: 0x3AAFB30 Offset: 0x3AAFC31 VA: 0x3AAFB30
	|-ReadOnlyCollection<ShaderTagId>.GetEnumerator
	|
	|-RVA: 0x3AB0B30 Offset: 0x3AB0C31 VA: 0x3AB0B30
	|-ReadOnlyCollection<float>.GetEnumerator
	|
	|-RVA: 0x3AB1C30 Offset: 0x3AB1D31 VA: 0x3AB1C30
	|-ReadOnlyCollection<SphericalHarmonicsL2>.GetEnumerator
	|
	|-RVA: 0x3AB2F80 Offset: 0x3AB3081 VA: 0x3AB2F80
	|-ReadOnlyCollection<SubMeshDescriptor>.GetEnumerator
	|
	|-RVA: 0x3AB4040 Offset: 0x3AB4141 VA: 0x3AB4040
	|-ReadOnlyCollection<TablePair>.GetEnumerator
	|
	|-RVA: 0x3AB5020 Offset: 0x3AB5121 VA: 0x3AB5020
	|-ReadOnlyCollection<TimeSpan>.GetEnumerator
	|
	|-RVA: 0x3AB6020 Offset: 0x3AB6121 VA: 0x3AB6020
	|-ReadOnlyCollection<UICharInfo>.GetEnumerator
	|
	|-RVA: 0x3AB7030 Offset: 0x3AB7131 VA: 0x3AB7030
	|-ReadOnlyCollection<UILineInfo>.GetEnumerator
	|
	|-RVA: 0x3AB8130 Offset: 0x3AB8231 VA: 0x3AB8130
	|-ReadOnlyCollection<UIVertex>.GetEnumerator
	|
	|-RVA: 0x3AB9400 Offset: 0x3AB9501 VA: 0x3AB9400
	|-ReadOnlyCollection<ushort>.GetEnumerator
	|
	|-RVA: 0x3ABA3E0 Offset: 0x3ABA4E1 VA: 0x3ABA3E0
	|-ReadOnlyCollection<uint>.GetEnumerator
	|
	|-RVA: 0x3ABB3C0 Offset: 0x3ABB4C1 VA: 0x3ABB3C0
	|-ReadOnlyCollection<ulong>.GetEnumerator
	|
	|-RVA: 0x3ABC3B0 Offset: 0x3ABC4B1 VA: 0x3ABC3B0
	|-ReadOnlyCollection<Vector2>.GetEnumerator
	|
	|-RVA: 0x3ABD3C0 Offset: 0x3ABD4C1 VA: 0x3ABD3C0
	|-ReadOnlyCollection<Vector3>.GetEnumerator
	|
	|-RVA: 0x3ABE3E0 Offset: 0x3ABE4E1 VA: 0x3ABE3E0
	|-ReadOnlyCollection<Vector4>.GetEnumerator
	|
	|-RVA: 0x3ABF3F0 Offset: 0x3ABF4F1 VA: 0x3ABF3F0
	|-ReadOnlyCollection<VertexAttributeDescriptor>.GetEnumerator
	|
	|-RVA: 0x3AC03E0 Offset: 0x3AC04E1 VA: 0x3AC03E0
	|-ReadOnlyCollection<X509ChainStatus>.GetEnumerator
	|
	|-RVA: 0x3AC1430 Offset: 0x3AC1531 VA: 0x3AC1430
	|-ReadOnlyCollection<XRView>.GetEnumerator
	|
	|-RVA: 0x3AC2500 Offset: 0x3AC2601 VA: 0x3AC2500
	|-ReadOnlyCollection<AICrossfire.PositionTable>.GetEnumerator
	|
	|-RVA: 0x3AC3520 Offset: 0x3AC3621 VA: 0x3AC3520
	|-ReadOnlyCollection<AmiiboSequence.GainItemData>.GetEnumerator
	|
	|-RVA: 0x3AC4580 Offset: 0x3AC4681 VA: 0x3AC4580
	|-ReadOnlyCollection<AnimationOutputWeightProcessor.WeightInfo>.GetEnumerator
	|
	|-RVA: 0x3AC5630 Offset: 0x3AC5731 VA: 0x3AC5630
	|-ReadOnlyCollection<ArenaOrderSequence.GodInfo>.GetEnumerator
	|
	|-RVA: 0x3AC6620 Offset: 0x3AC6721 VA: 0x3AC6620
	|-ReadOnlyCollection<BattleInfo.SupportData>.GetEnumerator
	|
	|-RVA: 0x3AC7610 Offset: 0x3AC7711 VA: 0x3AC7610
	|-ReadOnlyCollection<BeforeRenderHelper.OrderBlock>.GetEnumerator
	|
	|-RVA: 0x3AC8650 Offset: 0x3AC8751 VA: 0x3AC8650
	|-ReadOnlyCollection<Camera.RenderRequest>.GetEnumerator
	|
	|-RVA: 0x3AC96C0 Offset: 0x3AC97C1 VA: 0x3AC96C0
	|-ReadOnlyCollection<CameraState.CustomBlendable>.GetEnumerator
	|
	|-RVA: 0x3ACA6A0 Offset: 0x3ACA7A1 VA: 0x3ACA6A0
	|-ReadOnlyCollection<CinemachineClearShot.Pair>.GetEnumerator
	|
	|-RVA: 0x3ACB680 Offset: 0x3ACB781 VA: 0x3ACB680
	|-ReadOnlyCollection<CinemachineStateDrivenCamera.HashPair>.GetEnumerator
	|
	|-RVA: 0x3ACC6C0 Offset: 0x3ACC7C1 VA: 0x3ACC6C0
	|-ReadOnlyCollection<DelayedActionManager.DelegateInfo>.GetEnumerator
	|
	|-RVA: 0x3ACD7A0 Offset: 0x3ACD8A1 VA: 0x3ACD7A0
	|-ReadOnlyCollection<Detail.AsyncResultInt>.GetEnumerator
	|
	|-RVA: 0x3ACE860 Offset: 0x3ACE961 VA: 0x3ACE860
	|-ReadOnlyCollection<Detail.CppArray>.GetEnumerator
	|
	|-RVA: 0x3ACF8C0 Offset: 0x3ACF9C1 VA: 0x3ACF8C0
	|-ReadOnlyCollection<Detail.NotificationEventInt>.GetEnumerator
	|
	|-RVA: 0x3AD0980 Offset: 0x3AD0A81 VA: 0x3AD0980
	|-ReadOnlyCollection<DragonRideTargetGroup.ChainParam>.GetEnumerator
	|
	|-RVA: 0x3AD19C0 Offset: 0x3AD1AC1 VA: 0x3AD19C0
	|-ReadOnlyCollection<GmapPathAdjuster.TargetModel>.GetEnumerator
	|
	|-RVA: 0x3AD2A80 Offset: 0x3AD2B81 VA: 0x3AD2A80
	|-ReadOnlyCollection<GmapSpotAdjuster.TargetModel>.GetEnumerator
	|
	|-RVA: 0x3AD3B40 Offset: 0x3AD3C41 VA: 0x3AD3B40
	|-ReadOnlyCollection<HubFastTravel.Location>.GetEnumerator
	|
	|-RVA: 0x3AD4C20 Offset: 0x3AD4D21 VA: 0x3AD4C20
	|-ReadOnlyCollection<HubLensFlare.Flare>.GetEnumerator
	|
	|-RVA: 0x3AD5CE0 Offset: 0x3AD5DE1 VA: 0x3AD5CE0
	|-ReadOnlyCollection<InventoryPoolItemMenuContent.KindBgNameClass>.GetEnumerator
	|
	|-RVA: 0x3AD6CC0 Offset: 0x3AD6DC1 VA: 0x3AD6CC0
	|-ReadOnlyCollection<Map.Pos>.GetEnumerator
	|
	|-RVA: 0x3AD7CB0 Offset: 0x3AD7DB1 VA: 0x3AD7CB0
	|-ReadOnlyCollection<MapImage.BackupTerrain>.GetEnumerator
	|
	|-RVA: 0x3AD8CB0 Offset: 0x3AD8DB1 VA: 0x3AD8CB0
	|-ReadOnlyCollection<MapImageRange.Pos>.GetEnumerator
	|
	|-RVA: 0x3AD9D10 Offset: 0x3AD9E11 VA: 0x3AD9D10
	|-ReadOnlyCollection<MapMind.Target>.GetEnumerator
	|
	|-RVA: 0x38C46F0 Offset: 0x38C47F1 VA: 0x38C46F0
	|-ReadOnlyCollection<MapPanelDebug.Entity>.GetEnumerator
	|
	|-RVA: 0x38C5750 Offset: 0x38C5851 VA: 0x38C5750
	|-ReadOnlyCollection<NexRanking.Data>.GetEnumerator
	|
	|-RVA: 0x38C6740 Offset: 0x38C6841 VA: 0x38C6740
	|-ReadOnlyCollection<NexVersus.RatingData>.GetEnumerator
	|
	|-RVA: 0x38C7730 Offset: 0x38C7831 VA: 0x38C7730
	|-ReadOnlyCollection<PackedPlayModeBuildLogs.RuntimeBuildLog>.GetEnumerator
	|
	|-RVA: 0x38C8780 Offset: 0x38C8881 VA: 0x38C8780
	|-ReadOnlyCollection<ParticleSystem.Particle>.GetEnumerator
	|
	|-RVA: 0x38C9830 Offset: 0x38C9931 VA: 0x38C9830
	|-ReadOnlyCollection<RangeData.Offset>.GetEnumerator
	|
	|-RVA: 0x38CA870 Offset: 0x38CA971 VA: 0x38CA870
	|-ReadOnlyCollection<RenderGraphDebugData.PassDebugData>.GetEnumerator
	|
	|-RVA: 0x38CB950 Offset: 0x38CBA51 VA: 0x38CB950
	|-ReadOnlyCollection<RenderGraphDebugData.ResourceDebugData>.GetEnumerator
	|
	|-RVA: 0x38CCA00 Offset: 0x38CCB01 VA: 0x38CCA00
	|-ReadOnlyCollection<RingCleaningUnitSelectMenu.GodParam>.GetEnumerator
	|
	|-RVA: 0x38CDA60 Offset: 0x38CDB61 VA: 0x38CDA60
	|-ReadOnlyCollection<ShadowUtility.Edge>.GetEnumerator
	|
	|-RVA: 0x38CEB30 Offset: 0x38CEC31 VA: 0x38CEB30
	|-ReadOnlyCollection<SkillArray.Entity>.GetEnumerator
	|
	|-RVA: 0x38CFBD0 Offset: 0x38CFCD1 VA: 0x38CFBD0
	|-ReadOnlyCollection<TexturePacker_JsonArray.Frame>.GetEnumerator
	|
	|-RVA: 0x38D0D20 Offset: 0x38D0E21 VA: 0x38D0D20
	|-ReadOnlyCollection<TimeNotificationBehaviour.NotificationEntry>.GetEnumerator
	|
	|-RVA: 0x38D1DE0 Offset: 0x38D1EE1 VA: 0x38D1DE0
	|-ReadOnlyCollection<UnitySynchronizationContext.WorkRequest>.GetEnumerator
	|
	|-RVA: 0x38D2E50 Offset: 0x38D2F51 VA: 0x38D2E50
	|-ReadOnlyCollection<XmlSchemaObjectTable.XmlSchemaObjectEntry>.GetEnumerator
	|
	|-RVA: 0x38D3E40 Offset: 0x38D3F41 VA: 0x38D3E40
	|-ReadOnlyCollection<AssetBundleBuildMap.AssetBundleEntry.AssetPathString>.GetEnumerator
	|
	|-RVA: 0x38D4EA0 Offset: 0x38D4FA1 VA: 0x38D4EA0
	|-ReadOnlyCollection<Detail.DataStore.DataStoreChangeMetaParamInt>.GetEnumerator
	|
	|-RVA: 0x38D5F70 Offset: 0x38D6071 VA: 0x38D5F70
	|-ReadOnlyCollection<Detail.DataStore.DataStoreDeleteParamInt>.GetEnumerator
	|
	|-RVA: 0x38D6FD0 Offset: 0x38D70D1 VA: 0x38D6FD0
	|-ReadOnlyCollection<Detail.DataStore.DataStoreGetMetaParamInt>.GetEnumerator
	|
	|-RVA: 0x38D80E0 Offset: 0x38D81E1 VA: 0x38D80E0
	|-ReadOnlyCollection<Detail.DataStore.DataStoreMetaInfoInt>.GetEnumerator
	|
	|-RVA: 0x38D91F0 Offset: 0x38D92F1 VA: 0x38D91F0
	|-ReadOnlyCollection<Detail.DataStore.DataStorePasswordInfoInt>.GetEnumerator
	|
	|-RVA: 0x38DA2B0 Offset: 0x38DA3B1 VA: 0x38DA2B0
	|-ReadOnlyCollection<Detail.DataStore.DataStorePersistenceInfoInt>.GetEnumerator
	|
	|-RVA: 0x38DB380 Offset: 0x38DB481 VA: 0x38DB380
	|-ReadOnlyCollection<Detail.DataStore.DataStorePreparePostParamInt>.GetEnumerator
	|
	|-RVA: 0x38DC440 Offset: 0x38DC541 VA: 0x38DC440
	|-ReadOnlyCollection<Detail.DataStore.DataStoreRateObjectParamInt>.GetEnumerator
	|
	|-RVA: 0x38DD480 Offset: 0x38DD581 VA: 0x38DD480
	|-ReadOnlyCollection<Detail.DataStore.DataStoreRatingInitParamInt>.GetEnumerator
	|
	|-RVA: 0x38DE4F0 Offset: 0x38DE5F1 VA: 0x38DE4F0
	|-ReadOnlyCollection<Detail.DataStore.DataStoreRatingTargetInt>.GetEnumerator
	|
	|-RVA: 0x38DF570 Offset: 0x38DF671 VA: 0x38DF570
	|-ReadOnlyCollection<Detail.Ranking.RankingCachedResultInt>.GetEnumerator
	|
	|-RVA: 0x38E0670 Offset: 0x38E0771 VA: 0x38E0670
	|-ReadOnlyCollection<Detail.Ranking.RankingOrderParamInt>.GetEnumerator
	|
	|-RVA: 0x38E16F0 Offset: 0x38E17F1 VA: 0x38E16F0
	|-ReadOnlyCollection<Detail.Ranking.RankingRankDataInt>.GetEnumerator
	|
	|-RVA: 0x38E28C0 Offset: 0x38E29C1 VA: 0x38E28C0
	|-ReadOnlyCollection<Detail.Ranking2.Ranking2ChartInfoInt>.GetEnumerator
	|
	|-RVA: 0x38E3B90 Offset: 0x38E3C91 VA: 0x38E3B90
	|-ReadOnlyCollection<Detail.Ranking2.Ranking2RankDataInt>.GetEnumerator
	|
	|-RVA: 0x38E4C90 Offset: 0x38E4D91 VA: 0x38E4C90
	|-ReadOnlyCollection<Detail.Ranking2.Ranking2ScoreDataInt>.GetEnumerator
	|
	|-RVA: 0x38E5CD0 Offset: 0x38E5DD1 VA: 0x38E5CD0
	|-ReadOnlyCollection<Detail.Screening.ScreeningContextInfoInt>.GetEnumerator
	|
	|-RVA: 0x38E6DF0 Offset: 0x38E6EF1 VA: 0x38E6DF0
	|-ReadOnlyCollection<Detail.Subscriber.SubscriberContentInt>.GetEnumerator
	|
	|-RVA: 0x38E7FE0 Offset: 0x38E80E1 VA: 0x38E7FE0
	|-ReadOnlyCollection<Detail.Subscriber.SubscriberGetContentParamInt>.GetEnumerator
	|
	|-RVA: 0x38E90C0 Offset: 0x38E91C1 VA: 0x38E90C0
	|-ReadOnlyCollection<Detail.Subscriber.SubscriberUserStatusInfoInt>.GetEnumerator
	|
	|-RVA: 0x38EA1C0 Offset: 0x38EA2C1 VA: 0x38EA1C0
	|-ReadOnlyCollection<Detail.Subscriber.SubscriberUserStatusParamInt>.GetEnumerator
	|
	|-RVA: 0x38EB220 Offset: 0x38EB321 VA: 0x38EB220
	|-ReadOnlyCollection<Detail.Utility.IntegerSettings>.GetEnumerator
	|
	|-RVA: 0x38EC210 Offset: 0x38EC311 VA: 0x38EC210
	|-ReadOnlyCollection<Detail.Utility.UniqueIdInfoInt>.GetEnumerator
	|
	|-RVA: 0x38ED210 Offset: 0x38ED311 VA: 0x38ED210
	|-ReadOnlyCollection<MapHistory.Rewind.LatestInspectorData>.GetEnumerator
	|
	|-RVA: 0x38EE240 Offset: 0x38EE341 VA: 0x38EE240
	|-ReadOnlyCollection<MapHistory.Rewind.WorkTerrainData>.GetEnumerator
	|
	|-RVA: 0x38EF260 Offset: 0x38EF361 VA: 0x38EF260
	|-ReadOnlyCollection<MapSkill.AroundCalculator.Result>.GetEnumerator
	|
	|-RVA: 0x38F02C0 Offset: 0x38F03C1 VA: 0x38F02C0
	|-ReadOnlyCollection<TargetPositionCache.CacheCurve.Item>.GetEnumerator
	|
	|-RVA: 0x2FE5850 Offset: 0x2FE5951 VA: 0x2FE5850
	|-ReadOnlyCollection<TargetPositionCache.CacheEntry.RecordingItem>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public int IndexOf(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3467740 Offset: 0x3467841 VA: 0x3467740
	|-ReadOnlyCollection<IntervalTree.Entry<object>>.IndexOf
	|
	|-RVA: 0x34687B0 Offset: 0x34688B1 VA: 0x34687B0
	|-ReadOnlyCollection<KeyValuePair<DateTime, object>>.IndexOf
	|
	|-RVA: 0x34697A0 Offset: 0x34698A1 VA: 0x34697A0
	|-ReadOnlyCollection<KeyValuePair<int, object>>.IndexOf
	|
	|-RVA: 0x346A7E0 Offset: 0x346A8E1 VA: 0x346A7E0
	|-ReadOnlyCollection<KeyValuePair<object, ValueTuple<int, DateTime, object>>>.IndexOf
	|
	|-RVA: 0x346B850 Offset: 0x346B951 VA: 0x346B850
	|-ReadOnlyCollection<KeyValuePair<object, object>>.IndexOf
	|
	|-RVA: 0x346C890 Offset: 0x346C991 VA: 0x346C890
	|-ReadOnlyCollection<CommonBattleSequence.Reliance<object>>.IndexOf
	|
	|-RVA: 0x346D900 Offset: 0x346DA01 VA: 0x346D900
	|-ReadOnlyCollection<RenderGraphResourcePool.ResourceLogInfo<object>>.IndexOf
	|
	|-RVA: 0x346E8F0 Offset: 0x346E9F1 VA: 0x346E8F0
	|-ReadOnlyCollection<ValueTuple<int, object>>.IndexOf
	|
	|-RVA: 0x346F8D0 Offset: 0x346F9D1 VA: 0x346F8D0
	|-ReadOnlyCollection<ValueTuple<Int32Enum, int>>.IndexOf
	|
	|-RVA: 0x3470910 Offset: 0x3470A11 VA: 0x3470910
	|-ReadOnlyCollection<ValueTuple<object, ValueTuple<object, int>>>.IndexOf
	|
	|-RVA: 0x3471980 Offset: 0x3471A81 VA: 0x3471980
	|-ReadOnlyCollection<ValueTuple<object, int>>.IndexOf
	|
	|-RVA: 0x3472980 Offset: 0x3472A81 VA: 0x3472980
	|-ReadOnlyCollection<ValueTuple<Vector3, float>>.IndexOf
	|
	|-RVA: 0x3473990 Offset: 0x3473A91 VA: 0x3473990
	|-ReadOnlyCollection<ValueTuple<object, Int32Enum, int>>.IndexOf
	|
	|-RVA: 0x34749D0 Offset: 0x3474AD1 VA: 0x34749D0
	|-ReadOnlyCollection<ValueTuple<object, int, int, int>>.IndexOf
	|
	|-RVA: 0x3475A30 Offset: 0x3475B31 VA: 0x3475A30
	|-ReadOnlyCollection<AnimatorClipInfo>.IndexOf
	|
	|-RVA: 0x3B22810 Offset: 0x3B22911 VA: 0x3B22810
	|-ReadOnlyCollection<AsyncOperationHandle>.IndexOf
	|
	|-RVA: 0x3B238D0 Offset: 0x3B239D1 VA: 0x3B238D0
	|-ReadOnlyCollection<BoneWeight>.IndexOf
	|
	|-RVA: 0x3B24930 Offset: 0x3B24A31 VA: 0x3B24930
	|-ReadOnlyCollection<bool>.IndexOf
	|
	|-RVA: 0x3B25920 Offset: 0x3B25A21 VA: 0x3B25920
	|-ReadOnlyCollection<byte>.IndexOf
	|
	|-RVA: 0x3B26910 Offset: 0x3B26A11 VA: 0x3B26910
	|-ReadOnlyCollection<CameraInfo>.IndexOf
	|
	|-RVA: 0x3B278F0 Offset: 0x3B279F1 VA: 0x3B278F0
	|-ReadOnlyCollection<char>.IndexOf
	|
	|-RVA: 0x3B288F0 Offset: 0x3B289F1 VA: 0x3B288F0
	|-ReadOnlyCollection<Color>.IndexOf
	|
	|-RVA: 0x3B29910 Offset: 0x3B29A11 VA: 0x3B29910
	|-ReadOnlyCollection<Color32>.IndexOf
	|
	|-RVA: 0x3B2A920 Offset: 0x3B2AA21 VA: 0x3B2A920
	|-ReadOnlyCollection<ConstraintSource>.IndexOf
	|
	|-RVA: 0x3B2B960 Offset: 0x3B2BA61 VA: 0x3B2B960
	|-ReadOnlyCollection<ContourVertex>.IndexOf
	|
	|-RVA: 0x3B2CA20 Offset: 0x3B2CB21 VA: 0x3B2CA20
	|-ReadOnlyCollection<CustomAttributeNamedArgument>.IndexOf
	|
	|-RVA: 0x3B2DA90 Offset: 0x3B2DB91 VA: 0x3B2DA90
	|-ReadOnlyCollection<CustomAttributeTypedArgument>.IndexOf
	|
	|-RVA: 0x3B2EAD0 Offset: 0x3B2EBD1 VA: 0x3B2EAD0
	|-ReadOnlyCollection<DataStoreRatingInfo>.IndexOf
	|
	|-RVA: 0x3B2FB30 Offset: 0x3B2FC31 VA: 0x3B2FB30
	|-ReadOnlyCollection<DataStoreResult>.IndexOf
	|
	|-RVA: 0x3B30B10 Offset: 0x3B30C11 VA: 0x3B30B10
	|-ReadOnlyCollection<DateTime>.IndexOf
	|
	|-RVA: 0x3B31B00 Offset: 0x3B31C01 VA: 0x3B31B00
	|-ReadOnlyCollection<DateTimeOffset>.IndexOf
	|
	|-RVA: 0x3B32AF0 Offset: 0x3B32BF1 VA: 0x3B32AF0
	|-ReadOnlyCollection<Decimal>.IndexOf
	|
	|-RVA: 0x3B33B50 Offset: 0x3B33C51 VA: 0x3B33B50
	|-ReadOnlyCollection<DiagnosticEvent>.IndexOf
	|
	|-RVA: 0x3B34C00 Offset: 0x3B34D01 VA: 0x3B34C00
	|-ReadOnlyCollection<double>.IndexOf
	|
	|-RVA: 0x3B35C70 Offset: 0x3B35D71 VA: 0x3B35C70
	|-ReadOnlyCollection<Friend>.IndexOf
	|
	|-RVA: 0x3B36D20 Offset: 0x3B36E21 VA: 0x3B36D20
	|-ReadOnlyCollection<GlyphRect>.IndexOf
	|
	|-RVA: 0x3B37D00 Offset: 0x3B37E01 VA: 0x3B37D00
	|-ReadOnlyCollection<short>.IndexOf
	|
	|-RVA: 0x3B38CE0 Offset: 0x3B38DE1 VA: 0x3B38CE0
	|-ReadOnlyCollection<int>.IndexOf
	|
	|-RVA: 0x3B39CC0 Offset: 0x3B39DC1 VA: 0x3B39CC0
	|-ReadOnlyCollection<Int32Enum>.IndexOf
	|
	|-RVA: 0x3B3ACA0 Offset: 0x3B3ADA1 VA: 0x3B3ACA0
	|-ReadOnlyCollection<long>.IndexOf
	|
	|-RVA: 0x3B3BC80 Offset: 0x3B3BD81 VA: 0x3B3BC80
	|-ReadOnlyCollection<IntPtr>.IndexOf
	|
	|-RVA: 0x3B3CC70 Offset: 0x3B3CD71 VA: 0x3B3CC70
	|-ReadOnlyCollection<InterpretedFrameInfo>.IndexOf
	|
	|-RVA: 0x3B3DCB0 Offset: 0x3B3DDB1 VA: 0x3B3DCB0
	|-ReadOnlyCollection<IntervalTreeNode>.IndexOf
	|
	|-RVA: 0x3B3ED10 Offset: 0x3B3EE11 VA: 0x3B3ED10
	|-ReadOnlyCollection<LengthLimitProperties>.IndexOf
	|
	|-RVA: 0x3B3FCF0 Offset: 0x3B3FDF1 VA: 0x3B3FCF0
	|-ReadOnlyCollection<MapPos>.IndexOf
	|
	|-RVA: 0x3B40D70 Offset: 0x3B40E71 VA: 0x3B40D70
	|-ReadOnlyCollection<Matrix4x4>.IndexOf
	|
	|-RVA: 0x3B41E60 Offset: 0x3B41F61 VA: 0x3B41E60
	|-ReadOnlyCollection<object>.IndexOf
	|
	|-RVA: 0x3B42DD0 Offset: 0x3B42ED1 VA: 0x3B42DD0
	|-ReadOnlyCollection<ObjectInitializationData>.IndexOf
	|
	|-RVA: 0x3B43EE0 Offset: 0x3B43FE1 VA: 0x3B43EE0
	|-ReadOnlyCollection<PlayableBinding>.IndexOf
	|
	|-RVA: 0x3B44FC0 Offset: 0x3B450C1 VA: 0x3B44FC0
	|-ReadOnlyCollection<PlayerLoopSystem>.IndexOf
	|
	|-RVA: 0x3B460E0 Offset: 0x3B461E1 VA: 0x3B460E0
	|-ReadOnlyCollection<PlayerLoopSystemInternal>.IndexOf
	|
	|-RVA: 0x3B47190 Offset: 0x3B47291 VA: 0x3B47190
	|-ReadOnlyCollection<RangePositionInfo>.IndexOf
	|
	|-RVA: 0x3B48170 Offset: 0x3B48271 VA: 0x3B48170
	|-ReadOnlyCollection<Ranking2ChartInfoInput>.IndexOf
	|
	|-RVA: 0x3B491E0 Offset: 0x3B492E1 VA: 0x3B491E0
	|-ReadOnlyCollection<RaycastHit2D>.IndexOf
	|
	|-RVA: 0x3B4A370 Offset: 0x3B4A471 VA: 0x3B4A370
	|-ReadOnlyCollection<RaycastResult>.IndexOf
	|
	|-RVA: 0x3B4B520 Offset: 0x3B4B621 VA: 0x3B4B520
	|-ReadOnlyCollection<Rect>.IndexOf
	|
	|-RVA: 0x3B4C520 Offset: 0x3B4C621 VA: 0x3B4C520
	|-ReadOnlyCollection<RendererListHandle>.IndexOf
	|
	|-RVA: 0x3B4D500 Offset: 0x3B4D601 VA: 0x3B4D500
	|-ReadOnlyCollection<ResourceHandle>.IndexOf
	|
	|-RVA: 0x3AAEBC0 Offset: 0x3AAECC1 VA: 0x3AAEBC0
	|-ReadOnlyCollection<sbyte>.IndexOf
	|
	|-RVA: 0x3AAFBC0 Offset: 0x3AAFCC1 VA: 0x3AAFBC0
	|-ReadOnlyCollection<ShaderTagId>.IndexOf
	|
	|-RVA: 0x3AB0BC0 Offset: 0x3AB0CC1 VA: 0x3AB0BC0
	|-ReadOnlyCollection<float>.IndexOf
	|
	|-RVA: 0x3AB1CC0 Offset: 0x3AB1DC1 VA: 0x3AB1CC0
	|-ReadOnlyCollection<SphericalHarmonicsL2>.IndexOf
	|
	|-RVA: 0x3AB3010 Offset: 0x3AB3111 VA: 0x3AB3010
	|-ReadOnlyCollection<SubMeshDescriptor>.IndexOf
	|
	|-RVA: 0x3AB40D0 Offset: 0x3AB41D1 VA: 0x3AB40D0
	|-ReadOnlyCollection<TablePair>.IndexOf
	|
	|-RVA: 0x3AB50B0 Offset: 0x3AB51B1 VA: 0x3AB50B0
	|-ReadOnlyCollection<TimeSpan>.IndexOf
	|
	|-RVA: 0x3AB60B0 Offset: 0x3AB61B1 VA: 0x3AB60B0
	|-ReadOnlyCollection<UICharInfo>.IndexOf
	|
	|-RVA: 0x3AB70C0 Offset: 0x3AB71C1 VA: 0x3AB70C0
	|-ReadOnlyCollection<UILineInfo>.IndexOf
	|
	|-RVA: 0x3AB81C0 Offset: 0x3AB82C1 VA: 0x3AB81C0
	|-ReadOnlyCollection<UIVertex>.IndexOf
	|
	|-RVA: 0x3AB9490 Offset: 0x3AB9591 VA: 0x3AB9490
	|-ReadOnlyCollection<ushort>.IndexOf
	|
	|-RVA: 0x3ABA470 Offset: 0x3ABA571 VA: 0x3ABA470
	|-ReadOnlyCollection<uint>.IndexOf
	|
	|-RVA: 0x3ABB450 Offset: 0x3ABB551 VA: 0x3ABB450
	|-ReadOnlyCollection<ulong>.IndexOf
	|
	|-RVA: 0x3ABC440 Offset: 0x3ABC541 VA: 0x3ABC440
	|-ReadOnlyCollection<Vector2>.IndexOf
	|
	|-RVA: 0x3ABD450 Offset: 0x3ABD551 VA: 0x3ABD450
	|-ReadOnlyCollection<Vector3>.IndexOf
	|
	|-RVA: 0x3ABE470 Offset: 0x3ABE571 VA: 0x3ABE470
	|-ReadOnlyCollection<Vector4>.IndexOf
	|
	|-RVA: 0x3ABF480 Offset: 0x3ABF581 VA: 0x3ABF480
	|-ReadOnlyCollection<VertexAttributeDescriptor>.IndexOf
	|
	|-RVA: 0x3AC0470 Offset: 0x3AC0571 VA: 0x3AC0470
	|-ReadOnlyCollection<X509ChainStatus>.IndexOf
	|
	|-RVA: 0x3AC14C0 Offset: 0x3AC15C1 VA: 0x3AC14C0
	|-ReadOnlyCollection<XRView>.IndexOf
	|
	|-RVA: 0x3AC2590 Offset: 0x3AC2691 VA: 0x3AC2590
	|-ReadOnlyCollection<AICrossfire.PositionTable>.IndexOf
	|
	|-RVA: 0x3AC35B0 Offset: 0x3AC36B1 VA: 0x3AC35B0
	|-ReadOnlyCollection<AmiiboSequence.GainItemData>.IndexOf
	|
	|-RVA: 0x3AC4610 Offset: 0x3AC4711 VA: 0x3AC4610
	|-ReadOnlyCollection<AnimationOutputWeightProcessor.WeightInfo>.IndexOf
	|
	|-RVA: 0x3AC56C0 Offset: 0x3AC57C1 VA: 0x3AC56C0
	|-ReadOnlyCollection<ArenaOrderSequence.GodInfo>.IndexOf
	|
	|-RVA: 0x3AC66B0 Offset: 0x3AC67B1 VA: 0x3AC66B0
	|-ReadOnlyCollection<BattleInfo.SupportData>.IndexOf
	|
	|-RVA: 0x3AC76A0 Offset: 0x3AC77A1 VA: 0x3AC76A0
	|-ReadOnlyCollection<BeforeRenderHelper.OrderBlock>.IndexOf
	|
	|-RVA: 0x3AC86E0 Offset: 0x3AC87E1 VA: 0x3AC86E0
	|-ReadOnlyCollection<Camera.RenderRequest>.IndexOf
	|
	|-RVA: 0x3AC9750 Offset: 0x3AC9851 VA: 0x3AC9750
	|-ReadOnlyCollection<CameraState.CustomBlendable>.IndexOf
	|
	|-RVA: 0x3ACA730 Offset: 0x3ACA831 VA: 0x3ACA730
	|-ReadOnlyCollection<CinemachineClearShot.Pair>.IndexOf
	|
	|-RVA: 0x3ACB710 Offset: 0x3ACB811 VA: 0x3ACB710
	|-ReadOnlyCollection<CinemachineStateDrivenCamera.HashPair>.IndexOf
	|
	|-RVA: 0x3ACC750 Offset: 0x3ACC851 VA: 0x3ACC750
	|-ReadOnlyCollection<DelayedActionManager.DelegateInfo>.IndexOf
	|
	|-RVA: 0x3ACD830 Offset: 0x3ACD931 VA: 0x3ACD830
	|-ReadOnlyCollection<Detail.AsyncResultInt>.IndexOf
	|
	|-RVA: 0x3ACE8F0 Offset: 0x3ACE9F1 VA: 0x3ACE8F0
	|-ReadOnlyCollection<Detail.CppArray>.IndexOf
	|
	|-RVA: 0x3ACF950 Offset: 0x3ACFA51 VA: 0x3ACF950
	|-ReadOnlyCollection<Detail.NotificationEventInt>.IndexOf
	|
	|-RVA: 0x3AD0A10 Offset: 0x3AD0B11 VA: 0x3AD0A10
	|-ReadOnlyCollection<DragonRideTargetGroup.ChainParam>.IndexOf
	|
	|-RVA: 0x3AD1A50 Offset: 0x3AD1B51 VA: 0x3AD1A50
	|-ReadOnlyCollection<GmapPathAdjuster.TargetModel>.IndexOf
	|
	|-RVA: 0x3AD2B10 Offset: 0x3AD2C11 VA: 0x3AD2B10
	|-ReadOnlyCollection<GmapSpotAdjuster.TargetModel>.IndexOf
	|
	|-RVA: 0x3AD3BD0 Offset: 0x3AD3CD1 VA: 0x3AD3BD0
	|-ReadOnlyCollection<HubFastTravel.Location>.IndexOf
	|
	|-RVA: 0x3AD4CB0 Offset: 0x3AD4DB1 VA: 0x3AD4CB0
	|-ReadOnlyCollection<HubLensFlare.Flare>.IndexOf
	|
	|-RVA: 0x3AD5D70 Offset: 0x3AD5E71 VA: 0x3AD5D70
	|-ReadOnlyCollection<InventoryPoolItemMenuContent.KindBgNameClass>.IndexOf
	|
	|-RVA: 0x3AD6D50 Offset: 0x3AD6E51 VA: 0x3AD6D50
	|-ReadOnlyCollection<Map.Pos>.IndexOf
	|
	|-RVA: 0x3AD7D40 Offset: 0x3AD7E41 VA: 0x3AD7D40
	|-ReadOnlyCollection<MapImage.BackupTerrain>.IndexOf
	|
	|-RVA: 0x3AD8D40 Offset: 0x3AD8E41 VA: 0x3AD8D40
	|-ReadOnlyCollection<MapImageRange.Pos>.IndexOf
	|
	|-RVA: 0x3AD9DA0 Offset: 0x3AD9EA1 VA: 0x3AD9DA0
	|-ReadOnlyCollection<MapMind.Target>.IndexOf
	|
	|-RVA: 0x38C4780 Offset: 0x38C4881 VA: 0x38C4780
	|-ReadOnlyCollection<MapPanelDebug.Entity>.IndexOf
	|
	|-RVA: 0x38C57E0 Offset: 0x38C58E1 VA: 0x38C57E0
	|-ReadOnlyCollection<NexRanking.Data>.IndexOf
	|
	|-RVA: 0x38C67D0 Offset: 0x38C68D1 VA: 0x38C67D0
	|-ReadOnlyCollection<NexVersus.RatingData>.IndexOf
	|
	|-RVA: 0x38C77C0 Offset: 0x38C78C1 VA: 0x38C77C0
	|-ReadOnlyCollection<PackedPlayModeBuildLogs.RuntimeBuildLog>.IndexOf
	|
	|-RVA: 0x38C8810 Offset: 0x38C8911 VA: 0x38C8810
	|-ReadOnlyCollection<ParticleSystem.Particle>.IndexOf
	|
	|-RVA: 0x38C98C0 Offset: 0x38C99C1 VA: 0x38C98C0
	|-ReadOnlyCollection<RangeData.Offset>.IndexOf
	|
	|-RVA: 0x38CA900 Offset: 0x38CAA01 VA: 0x38CA900
	|-ReadOnlyCollection<RenderGraphDebugData.PassDebugData>.IndexOf
	|
	|-RVA: 0x38CB9E0 Offset: 0x38CBAE1 VA: 0x38CB9E0
	|-ReadOnlyCollection<RenderGraphDebugData.ResourceDebugData>.IndexOf
	|
	|-RVA: 0x38CCA90 Offset: 0x38CCB91 VA: 0x38CCA90
	|-ReadOnlyCollection<RingCleaningUnitSelectMenu.GodParam>.IndexOf
	|
	|-RVA: 0x38CDAF0 Offset: 0x38CDBF1 VA: 0x38CDAF0
	|-ReadOnlyCollection<ShadowUtility.Edge>.IndexOf
	|
	|-RVA: 0x38CEBC0 Offset: 0x38CECC1 VA: 0x38CEBC0
	|-ReadOnlyCollection<SkillArray.Entity>.IndexOf
	|
	|-RVA: 0x38CFC60 Offset: 0x38CFD61 VA: 0x38CFC60
	|-ReadOnlyCollection<TexturePacker_JsonArray.Frame>.IndexOf
	|
	|-RVA: 0x38D0DB0 Offset: 0x38D0EB1 VA: 0x38D0DB0
	|-ReadOnlyCollection<TimeNotificationBehaviour.NotificationEntry>.IndexOf
	|
	|-RVA: 0x38D1E70 Offset: 0x38D1F71 VA: 0x38D1E70
	|-ReadOnlyCollection<UnitySynchronizationContext.WorkRequest>.IndexOf
	|
	|-RVA: 0x38D2EE0 Offset: 0x38D2FE1 VA: 0x38D2EE0
	|-ReadOnlyCollection<XmlSchemaObjectTable.XmlSchemaObjectEntry>.IndexOf
	|
	|-RVA: 0x38D3ED0 Offset: 0x38D3FD1 VA: 0x38D3ED0
	|-ReadOnlyCollection<AssetBundleBuildMap.AssetBundleEntry.AssetPathString>.IndexOf
	|
	|-RVA: 0x38D4F30 Offset: 0x38D5031 VA: 0x38D4F30
	|-ReadOnlyCollection<Detail.DataStore.DataStoreChangeMetaParamInt>.IndexOf
	|
	|-RVA: 0x38D6000 Offset: 0x38D6101 VA: 0x38D6000
	|-ReadOnlyCollection<Detail.DataStore.DataStoreDeleteParamInt>.IndexOf
	|
	|-RVA: 0x38D7060 Offset: 0x38D7161 VA: 0x38D7060
	|-ReadOnlyCollection<Detail.DataStore.DataStoreGetMetaParamInt>.IndexOf
	|
	|-RVA: 0x38D8170 Offset: 0x38D8271 VA: 0x38D8170
	|-ReadOnlyCollection<Detail.DataStore.DataStoreMetaInfoInt>.IndexOf
	|
	|-RVA: 0x38D9280 Offset: 0x38D9381 VA: 0x38D9280
	|-ReadOnlyCollection<Detail.DataStore.DataStorePasswordInfoInt>.IndexOf
	|
	|-RVA: 0x38DA340 Offset: 0x38DA441 VA: 0x38DA340
	|-ReadOnlyCollection<Detail.DataStore.DataStorePersistenceInfoInt>.IndexOf
	|
	|-RVA: 0x38DB410 Offset: 0x38DB511 VA: 0x38DB410
	|-ReadOnlyCollection<Detail.DataStore.DataStorePreparePostParamInt>.IndexOf
	|
	|-RVA: 0x38DC4D0 Offset: 0x38DC5D1 VA: 0x38DC4D0
	|-ReadOnlyCollection<Detail.DataStore.DataStoreRateObjectParamInt>.IndexOf
	|
	|-RVA: 0x38DD510 Offset: 0x38DD611 VA: 0x38DD510
	|-ReadOnlyCollection<Detail.DataStore.DataStoreRatingInitParamInt>.IndexOf
	|
	|-RVA: 0x38DE580 Offset: 0x38DE681 VA: 0x38DE580
	|-ReadOnlyCollection<Detail.DataStore.DataStoreRatingTargetInt>.IndexOf
	|
	|-RVA: 0x38DF600 Offset: 0x38DF701 VA: 0x38DF600
	|-ReadOnlyCollection<Detail.Ranking.RankingCachedResultInt>.IndexOf
	|
	|-RVA: 0x38E0700 Offset: 0x38E0801 VA: 0x38E0700
	|-ReadOnlyCollection<Detail.Ranking.RankingOrderParamInt>.IndexOf
	|
	|-RVA: 0x38E1780 Offset: 0x38E1881 VA: 0x38E1780
	|-ReadOnlyCollection<Detail.Ranking.RankingRankDataInt>.IndexOf
	|
	|-RVA: 0x38E2950 Offset: 0x38E2A51 VA: 0x38E2950
	|-ReadOnlyCollection<Detail.Ranking2.Ranking2ChartInfoInt>.IndexOf
	|
	|-RVA: 0x38E3C20 Offset: 0x38E3D21 VA: 0x38E3C20
	|-ReadOnlyCollection<Detail.Ranking2.Ranking2RankDataInt>.IndexOf
	|
	|-RVA: 0x38E4D20 Offset: 0x38E4E21 VA: 0x38E4D20
	|-ReadOnlyCollection<Detail.Ranking2.Ranking2ScoreDataInt>.IndexOf
	|
	|-RVA: 0x38E5D60 Offset: 0x38E5E61 VA: 0x38E5D60
	|-ReadOnlyCollection<Detail.Screening.ScreeningContextInfoInt>.IndexOf
	|
	|-RVA: 0x38E6E80 Offset: 0x38E6F81 VA: 0x38E6E80
	|-ReadOnlyCollection<Detail.Subscriber.SubscriberContentInt>.IndexOf
	|
	|-RVA: 0x38E8070 Offset: 0x38E8171 VA: 0x38E8070
	|-ReadOnlyCollection<Detail.Subscriber.SubscriberGetContentParamInt>.IndexOf
	|
	|-RVA: 0x38E9150 Offset: 0x38E9251 VA: 0x38E9150
	|-ReadOnlyCollection<Detail.Subscriber.SubscriberUserStatusInfoInt>.IndexOf
	|
	|-RVA: 0x38EA250 Offset: 0x38EA351 VA: 0x38EA250
	|-ReadOnlyCollection<Detail.Subscriber.SubscriberUserStatusParamInt>.IndexOf
	|
	|-RVA: 0x38EB2B0 Offset: 0x38EB3B1 VA: 0x38EB2B0
	|-ReadOnlyCollection<Detail.Utility.IntegerSettings>.IndexOf
	|
	|-RVA: 0x38EC2A0 Offset: 0x38EC3A1 VA: 0x38EC2A0
	|-ReadOnlyCollection<Detail.Utility.UniqueIdInfoInt>.IndexOf
	|
	|-RVA: 0x38ED2A0 Offset: 0x38ED3A1 VA: 0x38ED2A0
	|-ReadOnlyCollection<MapHistory.Rewind.LatestInspectorData>.IndexOf
	|
	|-RVA: 0x38EE2D0 Offset: 0x38EE3D1 VA: 0x38EE2D0
	|-ReadOnlyCollection<MapHistory.Rewind.WorkTerrainData>.IndexOf
	|
	|-RVA: 0x38EF2F0 Offset: 0x38EF3F1 VA: 0x38EF2F0
	|-ReadOnlyCollection<MapSkill.AroundCalculator.Result>.IndexOf
	|
	|-RVA: 0x38F0350 Offset: 0x38F0451 VA: 0x38F0350
	|-ReadOnlyCollection<TargetPositionCache.CacheCurve.Item>.IndexOf
	|
	|-RVA: 0x2FE58E0 Offset: 0x2FE59E1 VA: 0x2FE58E0
	|-ReadOnlyCollection<TargetPositionCache.CacheEntry.RecordingItem>.IndexOf
	*/

	// RVA: -1 Offset: -1 Slot: 10
	private bool System.Collections.Generic.ICollection<T>.get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3467820 Offset: 0x3467921 VA: 0x3467820
	|-ReadOnlyCollection<IntervalTree.Entry<object>>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3468860 Offset: 0x3468961 VA: 0x3468860
	|-ReadOnlyCollection<KeyValuePair<DateTime, object>>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3469850 Offset: 0x3469951 VA: 0x3469850
	|-ReadOnlyCollection<KeyValuePair<int, object>>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x346A8C0 Offset: 0x346A9C1 VA: 0x346A8C0
	|-ReadOnlyCollection<KeyValuePair<object, ValueTuple<int, DateTime, object>>>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x346B900 Offset: 0x346BA01 VA: 0x346B900
	|-ReadOnlyCollection<KeyValuePair<object, object>>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x346C970 Offset: 0x346CA71 VA: 0x346C970
	|-ReadOnlyCollection<CommonBattleSequence.Reliance<object>>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x346D9B0 Offset: 0x346DAB1 VA: 0x346D9B0
	|-ReadOnlyCollection<RenderGraphResourcePool.ResourceLogInfo<object>>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x346E9A0 Offset: 0x346EAA1 VA: 0x346E9A0
	|-ReadOnlyCollection<ValueTuple<int, object>>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x346F970 Offset: 0x346FA71 VA: 0x346F970
	|-ReadOnlyCollection<ValueTuple<Int32Enum, int>>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x34709F0 Offset: 0x3470AF1 VA: 0x34709F0
	|-ReadOnlyCollection<ValueTuple<object, ValueTuple<object, int>>>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3471A30 Offset: 0x3471B31 VA: 0x3471A30
	|-ReadOnlyCollection<ValueTuple<object, int>>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3472A40 Offset: 0x3472B41 VA: 0x3472A40
	|-ReadOnlyCollection<ValueTuple<Vector3, float>>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3473A40 Offset: 0x3473B41 VA: 0x3473A40
	|-ReadOnlyCollection<ValueTuple<object, Int32Enum, int>>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3474AB0 Offset: 0x3474BB1 VA: 0x3474AB0
	|-ReadOnlyCollection<ValueTuple<object, int, int, int>>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3475AD0 Offset: 0x3475BD1 VA: 0x3475AD0
	|-ReadOnlyCollection<AnimatorClipInfo>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3B228F0 Offset: 0x3B229F1 VA: 0x3B228F0
	|-ReadOnlyCollection<AsyncOperationHandle>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3B239B0 Offset: 0x3B23AB1 VA: 0x3B239B0
	|-ReadOnlyCollection<BoneWeight>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3B249D0 Offset: 0x3B24AD1 VA: 0x3B249D0
	|-ReadOnlyCollection<bool>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3B259C0 Offset: 0x3B25AC1 VA: 0x3B259C0
	|-ReadOnlyCollection<byte>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3B269C0 Offset: 0x3B26AC1 VA: 0x3B269C0
	|-ReadOnlyCollection<CameraInfo>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3B27990 Offset: 0x3B27A91 VA: 0x3B27990
	|-ReadOnlyCollection<char>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3B289B0 Offset: 0x3B28AB1 VA: 0x3B289B0
	|-ReadOnlyCollection<Color>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3B299C0 Offset: 0x3B29AC1 VA: 0x3B299C0
	|-ReadOnlyCollection<Color32>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3B2A9D0 Offset: 0x3B2AAD1 VA: 0x3B2A9D0
	|-ReadOnlyCollection<ConstraintSource>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3B2BA40 Offset: 0x3B2BB41 VA: 0x3B2BA40
	|-ReadOnlyCollection<ContourVertex>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3B2CB00 Offset: 0x3B2CC01 VA: 0x3B2CB00
	|-ReadOnlyCollection<CustomAttributeNamedArgument>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3B2DB40 Offset: 0x3B2DC41 VA: 0x3B2DB40
	|-ReadOnlyCollection<CustomAttributeTypedArgument>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3B2EBB0 Offset: 0x3B2ECB1 VA: 0x3B2EBB0
	|-ReadOnlyCollection<DataStoreRatingInfo>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3B2FBD0 Offset: 0x3B2FCD1 VA: 0x3B2FBD0
	|-ReadOnlyCollection<DataStoreResult>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3B30BB0 Offset: 0x3B30CB1 VA: 0x3B30BB0
	|-ReadOnlyCollection<DateTime>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3B31BB0 Offset: 0x3B31CB1 VA: 0x3B31BB0
	|-ReadOnlyCollection<DateTimeOffset>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3B32BA0 Offset: 0x3B32CA1 VA: 0x3B32BA0
	|-ReadOnlyCollection<Decimal>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3B33C40 Offset: 0x3B33D41 VA: 0x3B33C40
	|-ReadOnlyCollection<DiagnosticEvent>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3B34CA0 Offset: 0x3B34DA1 VA: 0x3B34CA0
	|-ReadOnlyCollection<double>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3B35D50 Offset: 0x3B35E51 VA: 0x3B35D50
	|-ReadOnlyCollection<Friend>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3B36DD0 Offset: 0x3B36ED1 VA: 0x3B36DD0
	|-ReadOnlyCollection<GlyphRect>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3B37DA0 Offset: 0x3B37EA1 VA: 0x3B37DA0
	|-ReadOnlyCollection<short>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3B38D80 Offset: 0x3B38E81 VA: 0x3B38D80
	|-ReadOnlyCollection<int>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3B39D60 Offset: 0x3B39E61 VA: 0x3B39D60
	|-ReadOnlyCollection<Int32Enum>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3B3AD40 Offset: 0x3B3AE41 VA: 0x3B3AD40
	|-ReadOnlyCollection<long>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3B3BD20 Offset: 0x3B3BE21 VA: 0x3B3BD20
	|-ReadOnlyCollection<IntPtr>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3B3CD20 Offset: 0x3B3CE21 VA: 0x3B3CD20
	|-ReadOnlyCollection<InterpretedFrameInfo>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3B3DD90 Offset: 0x3B3DE91 VA: 0x3B3DD90
	|-ReadOnlyCollection<IntervalTreeNode>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3B3EDB0 Offset: 0x3B3EEB1 VA: 0x3B3EDB0
	|-ReadOnlyCollection<LengthLimitProperties>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3B3FD90 Offset: 0x3B3FE91 VA: 0x3B3FD90
	|-ReadOnlyCollection<MapPos>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3B40E80 Offset: 0x3B40F81 VA: 0x3B40E80
	|-ReadOnlyCollection<Matrix4x4>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3B41F00 Offset: 0x3B42001 VA: 0x3B41F00
	|-ReadOnlyCollection<object>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3B42EC0 Offset: 0x3B42FC1 VA: 0x3B42EC0
	|-ReadOnlyCollection<ObjectInitializationData>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3B43FC0 Offset: 0x3B440C1 VA: 0x3B43FC0
	|-ReadOnlyCollection<PlayableBinding>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3B450B0 Offset: 0x3B451B1 VA: 0x3B450B0
	|-ReadOnlyCollection<PlayerLoopSystem>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3B461D0 Offset: 0x3B462D1 VA: 0x3B461D0
	|-ReadOnlyCollection<PlayerLoopSystemInternal>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3B47240 Offset: 0x3B47341 VA: 0x3B47240
	|-ReadOnlyCollection<RangePositionInfo>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3B48210 Offset: 0x3B48311 VA: 0x3B48210
	|-ReadOnlyCollection<Ranking2ChartInfoInput>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3B492E0 Offset: 0x3B493E1 VA: 0x3B492E0
	|-ReadOnlyCollection<RaycastHit2D>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3B4A490 Offset: 0x3B4A591 VA: 0x3B4A490
	|-ReadOnlyCollection<RaycastResult>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3B4B5E0 Offset: 0x3B4B6E1 VA: 0x3B4B5E0
	|-ReadOnlyCollection<Rect>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3B4C5C0 Offset: 0x3B4C6C1 VA: 0x3B4C5C0
	|-ReadOnlyCollection<RendererListHandle>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3B4D5A0 Offset: 0x3B4D6A1 VA: 0x3B4D5A0
	|-ReadOnlyCollection<ResourceHandle>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3AAEC60 Offset: 0x3AAED61 VA: 0x3AAEC60
	|-ReadOnlyCollection<sbyte>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3AAFC70 Offset: 0x3AAFD71 VA: 0x3AAFC70
	|-ReadOnlyCollection<ShaderTagId>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3AB0C60 Offset: 0x3AB0D61 VA: 0x3AB0C60
	|-ReadOnlyCollection<float>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3AB1E30 Offset: 0x3AB1F31 VA: 0x3AB1E30
	|-ReadOnlyCollection<SphericalHarmonicsL2>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3AB3100 Offset: 0x3AB3201 VA: 0x3AB3100
	|-ReadOnlyCollection<SubMeshDescriptor>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3AB4180 Offset: 0x3AB4281 VA: 0x3AB4180
	|-ReadOnlyCollection<TablePair>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3AB5150 Offset: 0x3AB5251 VA: 0x3AB5150
	|-ReadOnlyCollection<TimeSpan>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3AB6170 Offset: 0x3AB6271 VA: 0x3AB6170
	|-ReadOnlyCollection<UICharInfo>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3AB7170 Offset: 0x3AB7271 VA: 0x3AB7170
	|-ReadOnlyCollection<UILineInfo>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3AB8330 Offset: 0x3AB8431 VA: 0x3AB8330
	|-ReadOnlyCollection<UIVertex>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3AB9530 Offset: 0x3AB9631 VA: 0x3AB9530
	|-ReadOnlyCollection<ushort>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3ABA510 Offset: 0x3ABA611 VA: 0x3ABA510
	|-ReadOnlyCollection<uint>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3ABB4F0 Offset: 0x3ABB5F1 VA: 0x3ABB4F0
	|-ReadOnlyCollection<ulong>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3ABC4F0 Offset: 0x3ABC5F1 VA: 0x3ABC4F0
	|-ReadOnlyCollection<Vector2>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3ABD510 Offset: 0x3ABD611 VA: 0x3ABD510
	|-ReadOnlyCollection<Vector3>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3ABE530 Offset: 0x3ABE631 VA: 0x3ABE530
	|-ReadOnlyCollection<Vector4>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3ABF530 Offset: 0x3ABF631 VA: 0x3ABF530
	|-ReadOnlyCollection<VertexAttributeDescriptor>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3AC0520 Offset: 0x3AC0621 VA: 0x3AC0520
	|-ReadOnlyCollection<X509ChainStatus>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3AC15A0 Offset: 0x3AC16A1 VA: 0x3AC15A0
	|-ReadOnlyCollection<XRView>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3AC2640 Offset: 0x3AC2741 VA: 0x3AC2640
	|-ReadOnlyCollection<AICrossfire.PositionTable>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3AC3660 Offset: 0x3AC3761 VA: 0x3AC3660
	|-ReadOnlyCollection<AmiiboSequence.GainItemData>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3AC4700 Offset: 0x3AC4801 VA: 0x3AC4700
	|-ReadOnlyCollection<AnimationOutputWeightProcessor.WeightInfo>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3AC5770 Offset: 0x3AC5871 VA: 0x3AC5770
	|-ReadOnlyCollection<ArenaOrderSequence.GodInfo>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3AC6760 Offset: 0x3AC6861 VA: 0x3AC6760
	|-ReadOnlyCollection<BattleInfo.SupportData>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3AC7750 Offset: 0x3AC7851 VA: 0x3AC7750
	|-ReadOnlyCollection<BeforeRenderHelper.OrderBlock>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3AC87C0 Offset: 0x3AC88C1 VA: 0x3AC87C0
	|-ReadOnlyCollection<Camera.RenderRequest>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3AC9800 Offset: 0x3AC9901 VA: 0x3AC9800
	|-ReadOnlyCollection<CameraState.CustomBlendable>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3ACA7D0 Offset: 0x3ACA8D1 VA: 0x3ACA7D0
	|-ReadOnlyCollection<CinemachineClearShot.Pair>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3ACB7B0 Offset: 0x3ACB8B1 VA: 0x3ACB7B0
	|-ReadOnlyCollection<CinemachineStateDrivenCamera.HashPair>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3ACC830 Offset: 0x3ACC931 VA: 0x3ACC830
	|-ReadOnlyCollection<DelayedActionManager.DelegateInfo>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3ACD920 Offset: 0x3ACDA21 VA: 0x3ACD920
	|-ReadOnlyCollection<Detail.AsyncResultInt>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3ACE9A0 Offset: 0x3ACEAA1 VA: 0x3ACE9A0
	|-ReadOnlyCollection<Detail.CppArray>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3ACFA40 Offset: 0x3ACFB41 VA: 0x3ACFA40
	|-ReadOnlyCollection<Detail.NotificationEventInt>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3AD0AC0 Offset: 0x3AD0BC1 VA: 0x3AD0AC0
	|-ReadOnlyCollection<DragonRideTargetGroup.ChainParam>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3AD1B30 Offset: 0x3AD1C31 VA: 0x3AD1B30
	|-ReadOnlyCollection<GmapPathAdjuster.TargetModel>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3AD2BF0 Offset: 0x3AD2CF1 VA: 0x3AD2BF0
	|-ReadOnlyCollection<GmapSpotAdjuster.TargetModel>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3AD3CB0 Offset: 0x3AD3DB1 VA: 0x3AD3CB0
	|-ReadOnlyCollection<HubFastTravel.Location>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3AD4DA0 Offset: 0x3AD4EA1 VA: 0x3AD4DA0
	|-ReadOnlyCollection<HubLensFlare.Flare>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3AD5E20 Offset: 0x3AD5F21 VA: 0x3AD5E20
	|-ReadOnlyCollection<InventoryPoolItemMenuContent.KindBgNameClass>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3AD6DF0 Offset: 0x3AD6EF1 VA: 0x3AD6DF0
	|-ReadOnlyCollection<Map.Pos>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3AD7DF0 Offset: 0x3AD7EF1 VA: 0x3AD7DF0
	|-ReadOnlyCollection<MapImage.BackupTerrain>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3AD8DF0 Offset: 0x3AD8EF1 VA: 0x3AD8DF0
	|-ReadOnlyCollection<MapImageRange.Pos>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3AD9E80 Offset: 0x3AD9F81 VA: 0x3AD9E80
	|-ReadOnlyCollection<MapMind.Target>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x38C4860 Offset: 0x38C4961 VA: 0x38C4860
	|-ReadOnlyCollection<MapPanelDebug.Entity>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x38C5880 Offset: 0x38C5981 VA: 0x38C5880
	|-ReadOnlyCollection<NexRanking.Data>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x38C6880 Offset: 0x38C6981 VA: 0x38C6880
	|-ReadOnlyCollection<NexVersus.RatingData>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x38C7870 Offset: 0x38C7971 VA: 0x38C7870
	|-ReadOnlyCollection<PackedPlayModeBuildLogs.RuntimeBuildLog>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x38C88F0 Offset: 0x38C89F1 VA: 0x38C88F0
	|-ReadOnlyCollection<ParticleSystem.Particle>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x38C9960 Offset: 0x38C9A61 VA: 0x38C9960
	|-ReadOnlyCollection<RangeData.Offset>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x38CA9E0 Offset: 0x38CAAE1 VA: 0x38CA9E0
	|-ReadOnlyCollection<RenderGraphDebugData.PassDebugData>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x38CBAD0 Offset: 0x38CBBD1 VA: 0x38CBAD0
	|-ReadOnlyCollection<RenderGraphDebugData.ResourceDebugData>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x38CCB40 Offset: 0x38CCC41 VA: 0x38CCB40
	|-ReadOnlyCollection<RingCleaningUnitSelectMenu.GodParam>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x38CDBE0 Offset: 0x38CDCE1 VA: 0x38CDBE0
	|-ReadOnlyCollection<ShadowUtility.Edge>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x38CEC70 Offset: 0x38CED71 VA: 0x38CEC70
	|-ReadOnlyCollection<SkillArray.Entity>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x38CFD70 Offset: 0x38CFE71 VA: 0x38CFD70
	|-ReadOnlyCollection<TexturePacker_JsonArray.Frame>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x38D0E90 Offset: 0x38D0F91 VA: 0x38D0E90
	|-ReadOnlyCollection<TimeNotificationBehaviour.NotificationEntry>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x38D1F50 Offset: 0x38D2051 VA: 0x38D1F50
	|-ReadOnlyCollection<UnitySynchronizationContext.WorkRequest>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x38D2F90 Offset: 0x38D3091 VA: 0x38D2F90
	|-ReadOnlyCollection<XmlSchemaObjectTable.XmlSchemaObjectEntry>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x38D3F80 Offset: 0x38D4081 VA: 0x38D3F80
	|-ReadOnlyCollection<AssetBundleBuildMap.AssetBundleEntry.AssetPathString>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x38D5010 Offset: 0x38D5111 VA: 0x38D5010
	|-ReadOnlyCollection<Detail.DataStore.DataStoreChangeMetaParamInt>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x38D60B0 Offset: 0x38D61B1 VA: 0x38D60B0
	|-ReadOnlyCollection<Detail.DataStore.DataStoreDeleteParamInt>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x38D7150 Offset: 0x38D7251 VA: 0x38D7150
	|-ReadOnlyCollection<Detail.DataStore.DataStoreGetMetaParamInt>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x38D8250 Offset: 0x38D8351 VA: 0x38D8250
	|-ReadOnlyCollection<Detail.DataStore.DataStoreMetaInfoInt>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x38D9360 Offset: 0x38D9461 VA: 0x38D9360
	|-ReadOnlyCollection<Detail.DataStore.DataStorePasswordInfoInt>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x38DA420 Offset: 0x38DA521 VA: 0x38DA420
	|-ReadOnlyCollection<Detail.DataStore.DataStorePersistenceInfoInt>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x38DB4F0 Offset: 0x38DB5F1 VA: 0x38DB4F0
	|-ReadOnlyCollection<Detail.DataStore.DataStorePreparePostParamInt>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x38DC580 Offset: 0x38DC681 VA: 0x38DC580
	|-ReadOnlyCollection<Detail.DataStore.DataStoreRateObjectParamInt>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x38DD5F0 Offset: 0x38DD6F1 VA: 0x38DD5F0
	|-ReadOnlyCollection<Detail.DataStore.DataStoreRatingInitParamInt>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x38DE630 Offset: 0x38DE731 VA: 0x38DE630
	|-ReadOnlyCollection<Detail.DataStore.DataStoreRatingTargetInt>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x38DF710 Offset: 0x38DF811 VA: 0x38DF710
	|-ReadOnlyCollection<Detail.Ranking.RankingCachedResultInt>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x38E07B0 Offset: 0x38E08B1 VA: 0x38E07B0
	|-ReadOnlyCollection<Detail.Ranking.RankingOrderParamInt>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x38E1890 Offset: 0x38E1991 VA: 0x38E1890
	|-ReadOnlyCollection<Detail.Ranking.RankingRankDataInt>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x38E2A90 Offset: 0x38E2B91 VA: 0x38E2A90
	|-ReadOnlyCollection<Detail.Ranking2.Ranking2ChartInfoInt>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x38E3D30 Offset: 0x38E3E31 VA: 0x38E3D30
	|-ReadOnlyCollection<Detail.Ranking2.Ranking2RankDataInt>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x38E4DD0 Offset: 0x38E4ED1 VA: 0x38E4DD0
	|-ReadOnlyCollection<Detail.Ranking2.Ranking2ScoreDataInt>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x38E5E40 Offset: 0x38E5F41 VA: 0x38E5E40
	|-ReadOnlyCollection<Detail.Screening.ScreeningContextInfoInt>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x38E6FA0 Offset: 0x38E70A1 VA: 0x38E6FA0
	|-ReadOnlyCollection<Detail.Subscriber.SubscriberContentInt>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x38E8150 Offset: 0x38E8251 VA: 0x38E8150
	|-ReadOnlyCollection<Detail.Subscriber.SubscriberGetContentParamInt>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x38E9240 Offset: 0x38E9341 VA: 0x38E9240
	|-ReadOnlyCollection<Detail.Subscriber.SubscriberUserStatusInfoInt>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x38EA330 Offset: 0x38EA431 VA: 0x38EA330
	|-ReadOnlyCollection<Detail.Subscriber.SubscriberUserStatusParamInt>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x38EB350 Offset: 0x38EB451 VA: 0x38EB350
	|-ReadOnlyCollection<Detail.Utility.IntegerSettings>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x38EC350 Offset: 0x38EC451 VA: 0x38EC350
	|-ReadOnlyCollection<Detail.Utility.UniqueIdInfoInt>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x38ED350 Offset: 0x38ED451 VA: 0x38ED350
	|-ReadOnlyCollection<MapHistory.Rewind.LatestInspectorData>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x38EE380 Offset: 0x38EE481 VA: 0x38EE380
	|-ReadOnlyCollection<MapHistory.Rewind.WorkTerrainData>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x38EF3A0 Offset: 0x38EF4A1 VA: 0x38EF3A0
	|-ReadOnlyCollection<MapSkill.AroundCalculator.Result>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x38F0440 Offset: 0x38F0541 VA: 0x38F0440
	|-ReadOnlyCollection<TargetPositionCache.CacheCurve.Item>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2FE59E0 Offset: 0x2FE5AE1 VA: 0x2FE59E0
	|-ReadOnlyCollection<TargetPositionCache.CacheEntry.RecordingItem>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 4
	private T System.Collections.Generic.IList<T>.get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3467830 Offset: 0x3467931 VA: 0x3467830
	|-ReadOnlyCollection<IntervalTree.Entry<object>>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x3468870 Offset: 0x3468971 VA: 0x3468870
	|-ReadOnlyCollection<KeyValuePair<DateTime, object>>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x3469860 Offset: 0x3469961 VA: 0x3469860
	|-ReadOnlyCollection<KeyValuePair<int, object>>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x346A8D0 Offset: 0x346A9D1 VA: 0x346A8D0
	|-ReadOnlyCollection<KeyValuePair<object, ValueTuple<int, DateTime, object>>>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x346B910 Offset: 0x346BA11 VA: 0x346B910
	|-ReadOnlyCollection<KeyValuePair<object, object>>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x346C980 Offset: 0x346CA81 VA: 0x346C980
	|-ReadOnlyCollection<CommonBattleSequence.Reliance<object>>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x346D9C0 Offset: 0x346DAC1 VA: 0x346D9C0
	|-ReadOnlyCollection<RenderGraphResourcePool.ResourceLogInfo<object>>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x346E9B0 Offset: 0x346EAB1 VA: 0x346E9B0
	|-ReadOnlyCollection<ValueTuple<int, object>>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x346F980 Offset: 0x346FA81 VA: 0x346F980
	|-ReadOnlyCollection<ValueTuple<Int32Enum, int>>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x3470A00 Offset: 0x3470B01 VA: 0x3470A00
	|-ReadOnlyCollection<ValueTuple<object, ValueTuple<object, int>>>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x3471A40 Offset: 0x3471B41 VA: 0x3471A40
	|-ReadOnlyCollection<ValueTuple<object, int>>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x3472A50 Offset: 0x3472B51 VA: 0x3472A50
	|-ReadOnlyCollection<ValueTuple<Vector3, float>>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x3473A50 Offset: 0x3473B51 VA: 0x3473A50
	|-ReadOnlyCollection<ValueTuple<object, Int32Enum, int>>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x3474AC0 Offset: 0x3474BC1 VA: 0x3474AC0
	|-ReadOnlyCollection<ValueTuple<object, int, int, int>>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x3475AE0 Offset: 0x3475BE1 VA: 0x3475AE0
	|-ReadOnlyCollection<AnimatorClipInfo>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x3B22900 Offset: 0x3B22A01 VA: 0x3B22900
	|-ReadOnlyCollection<AsyncOperationHandle>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x3B239C0 Offset: 0x3B23AC1 VA: 0x3B239C0
	|-ReadOnlyCollection<BoneWeight>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x3B249E0 Offset: 0x3B24AE1 VA: 0x3B249E0
	|-ReadOnlyCollection<bool>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x3B259D0 Offset: 0x3B25AD1 VA: 0x3B259D0
	|-ReadOnlyCollection<byte>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x3B269D0 Offset: 0x3B26AD1 VA: 0x3B269D0
	|-ReadOnlyCollection<CameraInfo>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x3B279A0 Offset: 0x3B27AA1 VA: 0x3B279A0
	|-ReadOnlyCollection<char>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x3B289C0 Offset: 0x3B28AC1 VA: 0x3B289C0
	|-ReadOnlyCollection<Color>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x3B299D0 Offset: 0x3B29AD1 VA: 0x3B299D0
	|-ReadOnlyCollection<Color32>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x3B2A9E0 Offset: 0x3B2AAE1 VA: 0x3B2A9E0
	|-ReadOnlyCollection<ConstraintSource>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x3B2BA50 Offset: 0x3B2BB51 VA: 0x3B2BA50
	|-ReadOnlyCollection<ContourVertex>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x3B2CB10 Offset: 0x3B2CC11 VA: 0x3B2CB10
	|-ReadOnlyCollection<CustomAttributeNamedArgument>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x3B2DB50 Offset: 0x3B2DC51 VA: 0x3B2DB50
	|-ReadOnlyCollection<CustomAttributeTypedArgument>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x3B2EBC0 Offset: 0x3B2ECC1 VA: 0x3B2EBC0
	|-ReadOnlyCollection<DataStoreRatingInfo>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x3B2FBE0 Offset: 0x3B2FCE1 VA: 0x3B2FBE0
	|-ReadOnlyCollection<DataStoreResult>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x3B30BC0 Offset: 0x3B30CC1 VA: 0x3B30BC0
	|-ReadOnlyCollection<DateTime>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x3B31BC0 Offset: 0x3B31CC1 VA: 0x3B31BC0
	|-ReadOnlyCollection<DateTimeOffset>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x3B32BB0 Offset: 0x3B32CB1 VA: 0x3B32BB0
	|-ReadOnlyCollection<Decimal>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x3B33C50 Offset: 0x3B33D51 VA: 0x3B33C50
	|-ReadOnlyCollection<DiagnosticEvent>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x3B34CB0 Offset: 0x3B34DB1 VA: 0x3B34CB0
	|-ReadOnlyCollection<double>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x3B35D60 Offset: 0x3B35E61 VA: 0x3B35D60
	|-ReadOnlyCollection<Friend>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x3B36DE0 Offset: 0x3B36EE1 VA: 0x3B36DE0
	|-ReadOnlyCollection<GlyphRect>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x3B37DB0 Offset: 0x3B37EB1 VA: 0x3B37DB0
	|-ReadOnlyCollection<short>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x3B38D90 Offset: 0x3B38E91 VA: 0x3B38D90
	|-ReadOnlyCollection<int>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x3B39D70 Offset: 0x3B39E71 VA: 0x3B39D70
	|-ReadOnlyCollection<Int32Enum>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x3B3AD50 Offset: 0x3B3AE51 VA: 0x3B3AD50
	|-ReadOnlyCollection<long>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x3B3BD30 Offset: 0x3B3BE31 VA: 0x3B3BD30
	|-ReadOnlyCollection<IntPtr>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x3B3CD30 Offset: 0x3B3CE31 VA: 0x3B3CD30
	|-ReadOnlyCollection<InterpretedFrameInfo>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x3B3DDA0 Offset: 0x3B3DEA1 VA: 0x3B3DDA0
	|-ReadOnlyCollection<IntervalTreeNode>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x3B3EDC0 Offset: 0x3B3EEC1 VA: 0x3B3EDC0
	|-ReadOnlyCollection<LengthLimitProperties>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x3B3FDA0 Offset: 0x3B3FEA1 VA: 0x3B3FDA0
	|-ReadOnlyCollection<MapPos>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x3B40E90 Offset: 0x3B40F91 VA: 0x3B40E90
	|-ReadOnlyCollection<Matrix4x4>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x3B41F10 Offset: 0x3B42011 VA: 0x3B41F10
	|-ReadOnlyCollection<object>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x3B42ED0 Offset: 0x3B42FD1 VA: 0x3B42ED0
	|-ReadOnlyCollection<ObjectInitializationData>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x3B43FD0 Offset: 0x3B440D1 VA: 0x3B43FD0
	|-ReadOnlyCollection<PlayableBinding>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x3B450C0 Offset: 0x3B451C1 VA: 0x3B450C0
	|-ReadOnlyCollection<PlayerLoopSystem>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x3B461E0 Offset: 0x3B462E1 VA: 0x3B461E0
	|-ReadOnlyCollection<PlayerLoopSystemInternal>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x3B47250 Offset: 0x3B47351 VA: 0x3B47250
	|-ReadOnlyCollection<RangePositionInfo>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x3B48220 Offset: 0x3B48321 VA: 0x3B48220
	|-ReadOnlyCollection<Ranking2ChartInfoInput>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x3B492F0 Offset: 0x3B493F1 VA: 0x3B492F0
	|-ReadOnlyCollection<RaycastHit2D>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x3B4A4A0 Offset: 0x3B4A5A1 VA: 0x3B4A4A0
	|-ReadOnlyCollection<RaycastResult>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x3B4B5F0 Offset: 0x3B4B6F1 VA: 0x3B4B5F0
	|-ReadOnlyCollection<Rect>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x3B4C5D0 Offset: 0x3B4C6D1 VA: 0x3B4C5D0
	|-ReadOnlyCollection<RendererListHandle>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x3B4D5B0 Offset: 0x3B4D6B1 VA: 0x3B4D5B0
	|-ReadOnlyCollection<ResourceHandle>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x3AAEC70 Offset: 0x3AAED71 VA: 0x3AAEC70
	|-ReadOnlyCollection<sbyte>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x3AAFC80 Offset: 0x3AAFD81 VA: 0x3AAFC80
	|-ReadOnlyCollection<ShaderTagId>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x3AB0C70 Offset: 0x3AB0D71 VA: 0x3AB0C70
	|-ReadOnlyCollection<float>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x3AB1E40 Offset: 0x3AB1F41 VA: 0x3AB1E40
	|-ReadOnlyCollection<SphericalHarmonicsL2>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x3AB3110 Offset: 0x3AB3211 VA: 0x3AB3110
	|-ReadOnlyCollection<SubMeshDescriptor>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x3AB4190 Offset: 0x3AB4291 VA: 0x3AB4190
	|-ReadOnlyCollection<TablePair>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x3AB5160 Offset: 0x3AB5261 VA: 0x3AB5160
	|-ReadOnlyCollection<TimeSpan>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x3AB6180 Offset: 0x3AB6281 VA: 0x3AB6180
	|-ReadOnlyCollection<UICharInfo>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x3AB7180 Offset: 0x3AB7281 VA: 0x3AB7180
	|-ReadOnlyCollection<UILineInfo>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x3AB8340 Offset: 0x3AB8441 VA: 0x3AB8340
	|-ReadOnlyCollection<UIVertex>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x3AB9540 Offset: 0x3AB9641 VA: 0x3AB9540
	|-ReadOnlyCollection<ushort>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x3ABA520 Offset: 0x3ABA621 VA: 0x3ABA520
	|-ReadOnlyCollection<uint>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x3ABB500 Offset: 0x3ABB601 VA: 0x3ABB500
	|-ReadOnlyCollection<ulong>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x3ABC500 Offset: 0x3ABC601 VA: 0x3ABC500
	|-ReadOnlyCollection<Vector2>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x3ABD520 Offset: 0x3ABD621 VA: 0x3ABD520
	|-ReadOnlyCollection<Vector3>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x3ABE540 Offset: 0x3ABE641 VA: 0x3ABE540
	|-ReadOnlyCollection<Vector4>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x3ABF540 Offset: 0x3ABF641 VA: 0x3ABF540
	|-ReadOnlyCollection<VertexAttributeDescriptor>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x3AC0530 Offset: 0x3AC0631 VA: 0x3AC0530
	|-ReadOnlyCollection<X509ChainStatus>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x3AC15B0 Offset: 0x3AC16B1 VA: 0x3AC15B0
	|-ReadOnlyCollection<XRView>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x3AC2650 Offset: 0x3AC2751 VA: 0x3AC2650
	|-ReadOnlyCollection<AICrossfire.PositionTable>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x3AC3670 Offset: 0x3AC3771 VA: 0x3AC3670
	|-ReadOnlyCollection<AmiiboSequence.GainItemData>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x3AC4710 Offset: 0x3AC4811 VA: 0x3AC4710
	|-ReadOnlyCollection<AnimationOutputWeightProcessor.WeightInfo>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x3AC5780 Offset: 0x3AC5881 VA: 0x3AC5780
	|-ReadOnlyCollection<ArenaOrderSequence.GodInfo>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x3AC6770 Offset: 0x3AC6871 VA: 0x3AC6770
	|-ReadOnlyCollection<BattleInfo.SupportData>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x3AC7760 Offset: 0x3AC7861 VA: 0x3AC7760
	|-ReadOnlyCollection<BeforeRenderHelper.OrderBlock>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x3AC87D0 Offset: 0x3AC88D1 VA: 0x3AC87D0
	|-ReadOnlyCollection<Camera.RenderRequest>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x3AC9810 Offset: 0x3AC9911 VA: 0x3AC9810
	|-ReadOnlyCollection<CameraState.CustomBlendable>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x3ACA7E0 Offset: 0x3ACA8E1 VA: 0x3ACA7E0
	|-ReadOnlyCollection<CinemachineClearShot.Pair>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x3ACB7C0 Offset: 0x3ACB8C1 VA: 0x3ACB7C0
	|-ReadOnlyCollection<CinemachineStateDrivenCamera.HashPair>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x3ACC840 Offset: 0x3ACC941 VA: 0x3ACC840
	|-ReadOnlyCollection<DelayedActionManager.DelegateInfo>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x3ACD930 Offset: 0x3ACDA31 VA: 0x3ACD930
	|-ReadOnlyCollection<Detail.AsyncResultInt>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x3ACE9B0 Offset: 0x3ACEAB1 VA: 0x3ACE9B0
	|-ReadOnlyCollection<Detail.CppArray>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x3ACFA50 Offset: 0x3ACFB51 VA: 0x3ACFA50
	|-ReadOnlyCollection<Detail.NotificationEventInt>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x3AD0AD0 Offset: 0x3AD0BD1 VA: 0x3AD0AD0
	|-ReadOnlyCollection<DragonRideTargetGroup.ChainParam>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x3AD1B40 Offset: 0x3AD1C41 VA: 0x3AD1B40
	|-ReadOnlyCollection<GmapPathAdjuster.TargetModel>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x3AD2C00 Offset: 0x3AD2D01 VA: 0x3AD2C00
	|-ReadOnlyCollection<GmapSpotAdjuster.TargetModel>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x3AD3CC0 Offset: 0x3AD3DC1 VA: 0x3AD3CC0
	|-ReadOnlyCollection<HubFastTravel.Location>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x3AD4DB0 Offset: 0x3AD4EB1 VA: 0x3AD4DB0
	|-ReadOnlyCollection<HubLensFlare.Flare>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x3AD5E30 Offset: 0x3AD5F31 VA: 0x3AD5E30
	|-ReadOnlyCollection<InventoryPoolItemMenuContent.KindBgNameClass>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x3AD6E00 Offset: 0x3AD6F01 VA: 0x3AD6E00
	|-ReadOnlyCollection<Map.Pos>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x3AD7E00 Offset: 0x3AD7F01 VA: 0x3AD7E00
	|-ReadOnlyCollection<MapImage.BackupTerrain>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x3AD8E00 Offset: 0x3AD8F01 VA: 0x3AD8E00
	|-ReadOnlyCollection<MapImageRange.Pos>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x3AD9E90 Offset: 0x3AD9F91 VA: 0x3AD9E90
	|-ReadOnlyCollection<MapMind.Target>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x38C4870 Offset: 0x38C4971 VA: 0x38C4870
	|-ReadOnlyCollection<MapPanelDebug.Entity>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x38C5890 Offset: 0x38C5991 VA: 0x38C5890
	|-ReadOnlyCollection<NexRanking.Data>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x38C6890 Offset: 0x38C6991 VA: 0x38C6890
	|-ReadOnlyCollection<NexVersus.RatingData>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x38C7880 Offset: 0x38C7981 VA: 0x38C7880
	|-ReadOnlyCollection<PackedPlayModeBuildLogs.RuntimeBuildLog>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x38C8900 Offset: 0x38C8A01 VA: 0x38C8900
	|-ReadOnlyCollection<ParticleSystem.Particle>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x38C9970 Offset: 0x38C9A71 VA: 0x38C9970
	|-ReadOnlyCollection<RangeData.Offset>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x38CA9F0 Offset: 0x38CAAF1 VA: 0x38CA9F0
	|-ReadOnlyCollection<RenderGraphDebugData.PassDebugData>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x38CBAE0 Offset: 0x38CBBE1 VA: 0x38CBAE0
	|-ReadOnlyCollection<RenderGraphDebugData.ResourceDebugData>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x38CCB50 Offset: 0x38CCC51 VA: 0x38CCB50
	|-ReadOnlyCollection<RingCleaningUnitSelectMenu.GodParam>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x38CDBF0 Offset: 0x38CDCF1 VA: 0x38CDBF0
	|-ReadOnlyCollection<ShadowUtility.Edge>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x38CEC80 Offset: 0x38CED81 VA: 0x38CEC80
	|-ReadOnlyCollection<SkillArray.Entity>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x38CFD80 Offset: 0x38CFE81 VA: 0x38CFD80
	|-ReadOnlyCollection<TexturePacker_JsonArray.Frame>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x38D0EA0 Offset: 0x38D0FA1 VA: 0x38D0EA0
	|-ReadOnlyCollection<TimeNotificationBehaviour.NotificationEntry>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x38D1F60 Offset: 0x38D2061 VA: 0x38D1F60
	|-ReadOnlyCollection<UnitySynchronizationContext.WorkRequest>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x38D2FA0 Offset: 0x38D30A1 VA: 0x38D2FA0
	|-ReadOnlyCollection<XmlSchemaObjectTable.XmlSchemaObjectEntry>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x38D3F90 Offset: 0x38D4091 VA: 0x38D3F90
	|-ReadOnlyCollection<AssetBundleBuildMap.AssetBundleEntry.AssetPathString>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x38D5020 Offset: 0x38D5121 VA: 0x38D5020
	|-ReadOnlyCollection<Detail.DataStore.DataStoreChangeMetaParamInt>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x38D60C0 Offset: 0x38D61C1 VA: 0x38D60C0
	|-ReadOnlyCollection<Detail.DataStore.DataStoreDeleteParamInt>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x38D7160 Offset: 0x38D7261 VA: 0x38D7160
	|-ReadOnlyCollection<Detail.DataStore.DataStoreGetMetaParamInt>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x38D8260 Offset: 0x38D8361 VA: 0x38D8260
	|-ReadOnlyCollection<Detail.DataStore.DataStoreMetaInfoInt>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x38D9370 Offset: 0x38D9471 VA: 0x38D9370
	|-ReadOnlyCollection<Detail.DataStore.DataStorePasswordInfoInt>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x38DA430 Offset: 0x38DA531 VA: 0x38DA430
	|-ReadOnlyCollection<Detail.DataStore.DataStorePersistenceInfoInt>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x38DB500 Offset: 0x38DB601 VA: 0x38DB500
	|-ReadOnlyCollection<Detail.DataStore.DataStorePreparePostParamInt>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x38DC590 Offset: 0x38DC691 VA: 0x38DC590
	|-ReadOnlyCollection<Detail.DataStore.DataStoreRateObjectParamInt>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x38DD600 Offset: 0x38DD701 VA: 0x38DD600
	|-ReadOnlyCollection<Detail.DataStore.DataStoreRatingInitParamInt>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x38DE640 Offset: 0x38DE741 VA: 0x38DE640
	|-ReadOnlyCollection<Detail.DataStore.DataStoreRatingTargetInt>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x38DF720 Offset: 0x38DF821 VA: 0x38DF720
	|-ReadOnlyCollection<Detail.Ranking.RankingCachedResultInt>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x38E07C0 Offset: 0x38E08C1 VA: 0x38E07C0
	|-ReadOnlyCollection<Detail.Ranking.RankingOrderParamInt>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x38E18A0 Offset: 0x38E19A1 VA: 0x38E18A0
	|-ReadOnlyCollection<Detail.Ranking.RankingRankDataInt>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x38E2AA0 Offset: 0x38E2BA1 VA: 0x38E2AA0
	|-ReadOnlyCollection<Detail.Ranking2.Ranking2ChartInfoInt>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x38E3D40 Offset: 0x38E3E41 VA: 0x38E3D40
	|-ReadOnlyCollection<Detail.Ranking2.Ranking2RankDataInt>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x38E4DE0 Offset: 0x38E4EE1 VA: 0x38E4DE0
	|-ReadOnlyCollection<Detail.Ranking2.Ranking2ScoreDataInt>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x38E5E50 Offset: 0x38E5F51 VA: 0x38E5E50
	|-ReadOnlyCollection<Detail.Screening.ScreeningContextInfoInt>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x38E6FB0 Offset: 0x38E70B1 VA: 0x38E6FB0
	|-ReadOnlyCollection<Detail.Subscriber.SubscriberContentInt>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x38E8160 Offset: 0x38E8261 VA: 0x38E8160
	|-ReadOnlyCollection<Detail.Subscriber.SubscriberGetContentParamInt>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x38E9250 Offset: 0x38E9351 VA: 0x38E9250
	|-ReadOnlyCollection<Detail.Subscriber.SubscriberUserStatusInfoInt>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x38EA340 Offset: 0x38EA441 VA: 0x38EA340
	|-ReadOnlyCollection<Detail.Subscriber.SubscriberUserStatusParamInt>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x38EB360 Offset: 0x38EB461 VA: 0x38EB360
	|-ReadOnlyCollection<Detail.Utility.IntegerSettings>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x38EC360 Offset: 0x38EC461 VA: 0x38EC360
	|-ReadOnlyCollection<Detail.Utility.UniqueIdInfoInt>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x38ED360 Offset: 0x38ED461 VA: 0x38ED360
	|-ReadOnlyCollection<MapHistory.Rewind.LatestInspectorData>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x38EE390 Offset: 0x38EE491 VA: 0x38EE390
	|-ReadOnlyCollection<MapHistory.Rewind.WorkTerrainData>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x38EF3B0 Offset: 0x38EF4B1 VA: 0x38EF3B0
	|-ReadOnlyCollection<MapSkill.AroundCalculator.Result>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x38F0450 Offset: 0x38F0551 VA: 0x38F0450
	|-ReadOnlyCollection<TargetPositionCache.CacheCurve.Item>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x2FE59F0 Offset: 0x2FE5AF1 VA: 0x2FE59F0
	|-ReadOnlyCollection<TargetPositionCache.CacheEntry.RecordingItem>.System.Collections.Generic.IList<T>.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private void System.Collections.Generic.IList<T>.set_Item(int index, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34678F0 Offset: 0x34679F1 VA: 0x34678F0
	|-ReadOnlyCollection<IntervalTree.Entry<object>>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x3468910 Offset: 0x3468A11 VA: 0x3468910
	|-ReadOnlyCollection<KeyValuePair<DateTime, object>>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x3469900 Offset: 0x3469A01 VA: 0x3469900
	|-ReadOnlyCollection<KeyValuePair<int, object>>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x346A990 Offset: 0x346AA91 VA: 0x346A990
	|-ReadOnlyCollection<KeyValuePair<object, ValueTuple<int, DateTime, object>>>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x346B9B0 Offset: 0x346BAB1 VA: 0x346B9B0
	|-ReadOnlyCollection<KeyValuePair<object, object>>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x346CA40 Offset: 0x346CB41 VA: 0x346CA40
	|-ReadOnlyCollection<CommonBattleSequence.Reliance<object>>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x346DA60 Offset: 0x346DB61 VA: 0x346DA60
	|-ReadOnlyCollection<RenderGraphResourcePool.ResourceLogInfo<object>>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x346EA50 Offset: 0x346EB51 VA: 0x346EA50
	|-ReadOnlyCollection<ValueTuple<int, object>>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x346FA20 Offset: 0x346FB21 VA: 0x346FA20
	|-ReadOnlyCollection<ValueTuple<Int32Enum, int>>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x3470AC0 Offset: 0x3470BC1 VA: 0x3470AC0
	|-ReadOnlyCollection<ValueTuple<object, ValueTuple<object, int>>>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x3471AE0 Offset: 0x3471BE1 VA: 0x3471AE0
	|-ReadOnlyCollection<ValueTuple<object, int>>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x3472AF0 Offset: 0x3472BF1 VA: 0x3472AF0
	|-ReadOnlyCollection<ValueTuple<Vector3, float>>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x3473AF0 Offset: 0x3473BF1 VA: 0x3473AF0
	|-ReadOnlyCollection<ValueTuple<object, Int32Enum, int>>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x3474B80 Offset: 0x3474C81 VA: 0x3474B80
	|-ReadOnlyCollection<ValueTuple<object, int, int, int>>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x3475B80 Offset: 0x3475C81 VA: 0x3475B80
	|-ReadOnlyCollection<AnimatorClipInfo>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x3B229C0 Offset: 0x3B22AC1 VA: 0x3B229C0
	|-ReadOnlyCollection<AsyncOperationHandle>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x3B23A80 Offset: 0x3B23B81 VA: 0x3B23A80
	|-ReadOnlyCollection<BoneWeight>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x3B24A80 Offset: 0x3B24B81 VA: 0x3B24A80
	|-ReadOnlyCollection<bool>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x3B25A70 Offset: 0x3B25B71 VA: 0x3B25A70
	|-ReadOnlyCollection<byte>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x3B26A70 Offset: 0x3B26B71 VA: 0x3B26A70
	|-ReadOnlyCollection<CameraInfo>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x3B27A40 Offset: 0x3B27B41 VA: 0x3B27A40
	|-ReadOnlyCollection<char>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x3B28A60 Offset: 0x3B28B61 VA: 0x3B28A60
	|-ReadOnlyCollection<Color>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x3B29A80 Offset: 0x3B29B81 VA: 0x3B29A80
	|-ReadOnlyCollection<Color32>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x3B2AA80 Offset: 0x3B2AB81 VA: 0x3B2AA80
	|-ReadOnlyCollection<ConstraintSource>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x3B2BB10 Offset: 0x3B2BC11 VA: 0x3B2BB10
	|-ReadOnlyCollection<ContourVertex>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x3B2CBD0 Offset: 0x3B2CCD1 VA: 0x3B2CBD0
	|-ReadOnlyCollection<CustomAttributeNamedArgument>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x3B2DBF0 Offset: 0x3B2DCF1 VA: 0x3B2DBF0
	|-ReadOnlyCollection<CustomAttributeTypedArgument>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x3B2EC80 Offset: 0x3B2ED81 VA: 0x3B2EC80
	|-ReadOnlyCollection<DataStoreRatingInfo>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x3B2FC80 Offset: 0x3B2FD81 VA: 0x3B2FC80
	|-ReadOnlyCollection<DataStoreResult>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x3B30C60 Offset: 0x3B30D61 VA: 0x3B30C60
	|-ReadOnlyCollection<DateTime>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x3B31C60 Offset: 0x3B31D61 VA: 0x3B31C60
	|-ReadOnlyCollection<DateTimeOffset>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x3B32C50 Offset: 0x3B32D51 VA: 0x3B32C50
	|-ReadOnlyCollection<Decimal>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x3B33D20 Offset: 0x3B33E21 VA: 0x3B33D20
	|-ReadOnlyCollection<DiagnosticEvent>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x3B34D50 Offset: 0x3B34E51 VA: 0x3B34D50
	|-ReadOnlyCollection<double>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x3B35E40 Offset: 0x3B35F41 VA: 0x3B35E40
	|-ReadOnlyCollection<Friend>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x3B36E80 Offset: 0x3B36F81 VA: 0x3B36E80
	|-ReadOnlyCollection<GlyphRect>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x3B37E50 Offset: 0x3B37F51 VA: 0x3B37E50
	|-ReadOnlyCollection<short>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x3B38E30 Offset: 0x3B38F31 VA: 0x3B38E30
	|-ReadOnlyCollection<int>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x3B39E10 Offset: 0x3B39F11 VA: 0x3B39E10
	|-ReadOnlyCollection<Int32Enum>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x3B3ADF0 Offset: 0x3B3AEF1 VA: 0x3B3ADF0
	|-ReadOnlyCollection<long>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x3B3BDD0 Offset: 0x3B3BED1 VA: 0x3B3BDD0
	|-ReadOnlyCollection<IntPtr>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x3B3CDD0 Offset: 0x3B3CED1 VA: 0x3B3CDD0
	|-ReadOnlyCollection<InterpretedFrameInfo>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x3B3DE60 Offset: 0x3B3DF61 VA: 0x3B3DE60
	|-ReadOnlyCollection<IntervalTreeNode>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x3B3EE60 Offset: 0x3B3EF61 VA: 0x3B3EE60
	|-ReadOnlyCollection<LengthLimitProperties>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x3B3FE40 Offset: 0x3B3FF41 VA: 0x3B3FE40
	|-ReadOnlyCollection<MapPos>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x3B40F60 Offset: 0x3B41061 VA: 0x3B40F60
	|-ReadOnlyCollection<Matrix4x4>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x3B41FB0 Offset: 0x3B420B1 VA: 0x3B41FB0
	|-ReadOnlyCollection<object>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x3B42FA0 Offset: 0x3B430A1 VA: 0x3B42FA0
	|-ReadOnlyCollection<ObjectInitializationData>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x3B44090 Offset: 0x3B44191 VA: 0x3B44090
	|-ReadOnlyCollection<PlayableBinding>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x3B45190 Offset: 0x3B45291 VA: 0x3B45190
	|-ReadOnlyCollection<PlayerLoopSystem>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x3B462B0 Offset: 0x3B463B1 VA: 0x3B462B0
	|-ReadOnlyCollection<PlayerLoopSystemInternal>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x3B472F0 Offset: 0x3B473F1 VA: 0x3B472F0
	|-ReadOnlyCollection<RangePositionInfo>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x3B482C0 Offset: 0x3B483C1 VA: 0x3B482C0
	|-ReadOnlyCollection<Ranking2ChartInfoInput>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x3B493C0 Offset: 0x3B494C1 VA: 0x3B493C0
	|-ReadOnlyCollection<RaycastHit2D>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x3B4A580 Offset: 0x3B4A681 VA: 0x3B4A580
	|-ReadOnlyCollection<RaycastResult>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x3B4B690 Offset: 0x3B4B791 VA: 0x3B4B690
	|-ReadOnlyCollection<Rect>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x3B4C670 Offset: 0x3B4C771 VA: 0x3B4C670
	|-ReadOnlyCollection<RendererListHandle>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x3B4D650 Offset: 0x3B4D751 VA: 0x3B4D650
	|-ReadOnlyCollection<ResourceHandle>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x3AAED10 Offset: 0x3AAEE11 VA: 0x3AAED10
	|-ReadOnlyCollection<sbyte>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x3AAFD30 Offset: 0x3AAFE31 VA: 0x3AAFD30
	|-ReadOnlyCollection<ShaderTagId>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x3AB0D10 Offset: 0x3AB0E11 VA: 0x3AB0D10
	|-ReadOnlyCollection<float>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x3AB1F30 Offset: 0x3AB2031 VA: 0x3AB1F30
	|-ReadOnlyCollection<SphericalHarmonicsL2>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x3AB31E0 Offset: 0x3AB32E1 VA: 0x3AB31E0
	|-ReadOnlyCollection<SubMeshDescriptor>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x3AB4230 Offset: 0x3AB4331 VA: 0x3AB4230
	|-ReadOnlyCollection<TablePair>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x3AB5200 Offset: 0x3AB5301 VA: 0x3AB5200
	|-ReadOnlyCollection<TimeSpan>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x3AB6220 Offset: 0x3AB6321 VA: 0x3AB6220
	|-ReadOnlyCollection<UICharInfo>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x3AB7220 Offset: 0x3AB7321 VA: 0x3AB7220
	|-ReadOnlyCollection<UILineInfo>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x3AB8430 Offset: 0x3AB8531 VA: 0x3AB8430
	|-ReadOnlyCollection<UIVertex>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x3AB95E0 Offset: 0x3AB96E1 VA: 0x3AB95E0
	|-ReadOnlyCollection<ushort>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x3ABA5C0 Offset: 0x3ABA6C1 VA: 0x3ABA5C0
	|-ReadOnlyCollection<uint>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x3ABB5A0 Offset: 0x3ABB6A1 VA: 0x3ABB5A0
	|-ReadOnlyCollection<ulong>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x3ABC5A0 Offset: 0x3ABC6A1 VA: 0x3ABC5A0
	|-ReadOnlyCollection<Vector2>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x3ABD5C0 Offset: 0x3ABD6C1 VA: 0x3ABD5C0
	|-ReadOnlyCollection<Vector3>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x3ABE5E0 Offset: 0x3ABE6E1 VA: 0x3ABE5E0
	|-ReadOnlyCollection<Vector4>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x3ABF5E0 Offset: 0x3ABF6E1 VA: 0x3ABF5E0
	|-ReadOnlyCollection<VertexAttributeDescriptor>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x3AC05D0 Offset: 0x3AC06D1 VA: 0x3AC05D0
	|-ReadOnlyCollection<X509ChainStatus>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x3AC1670 Offset: 0x3AC1771 VA: 0x3AC1670
	|-ReadOnlyCollection<XRView>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x3AC2700 Offset: 0x3AC2801 VA: 0x3AC2700
	|-ReadOnlyCollection<AICrossfire.PositionTable>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x3AC3710 Offset: 0x3AC3811 VA: 0x3AC3710
	|-ReadOnlyCollection<AmiiboSequence.GainItemData>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x3AC47E0 Offset: 0x3AC48E1 VA: 0x3AC47E0
	|-ReadOnlyCollection<AnimationOutputWeightProcessor.WeightInfo>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x3AC5820 Offset: 0x3AC5921 VA: 0x3AC5820
	|-ReadOnlyCollection<ArenaOrderSequence.GodInfo>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x3AC6810 Offset: 0x3AC6911 VA: 0x3AC6810
	|-ReadOnlyCollection<BattleInfo.SupportData>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x3AC7800 Offset: 0x3AC7901 VA: 0x3AC7800
	|-ReadOnlyCollection<BeforeRenderHelper.OrderBlock>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x3AC8890 Offset: 0x3AC8991 VA: 0x3AC8890
	|-ReadOnlyCollection<Camera.RenderRequest>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x3AC98B0 Offset: 0x3AC99B1 VA: 0x3AC98B0
	|-ReadOnlyCollection<CameraState.CustomBlendable>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x3ACA880 Offset: 0x3ACA981 VA: 0x3ACA880
	|-ReadOnlyCollection<CinemachineClearShot.Pair>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x3ACB860 Offset: 0x3ACB961 VA: 0x3ACB860
	|-ReadOnlyCollection<CinemachineStateDrivenCamera.HashPair>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x3ACC900 Offset: 0x3ACCA01 VA: 0x3ACC900
	|-ReadOnlyCollection<DelayedActionManager.DelegateInfo>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x3ACDA00 Offset: 0x3ACDB01 VA: 0x3ACDA00
	|-ReadOnlyCollection<Detail.AsyncResultInt>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x3ACEA50 Offset: 0x3ACEB51 VA: 0x3ACEA50
	|-ReadOnlyCollection<Detail.CppArray>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x3ACFB20 Offset: 0x3ACFC21 VA: 0x3ACFB20
	|-ReadOnlyCollection<Detail.NotificationEventInt>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x3AD0B70 Offset: 0x3AD0C71 VA: 0x3AD0B70
	|-ReadOnlyCollection<DragonRideTargetGroup.ChainParam>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x3AD1C00 Offset: 0x3AD1D01 VA: 0x3AD1C00
	|-ReadOnlyCollection<GmapPathAdjuster.TargetModel>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x3AD2CC0 Offset: 0x3AD2DC1 VA: 0x3AD2CC0
	|-ReadOnlyCollection<GmapSpotAdjuster.TargetModel>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x3AD3D80 Offset: 0x3AD3E81 VA: 0x3AD3D80
	|-ReadOnlyCollection<HubFastTravel.Location>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x3AD4E80 Offset: 0x3AD4F81 VA: 0x3AD4E80
	|-ReadOnlyCollection<HubLensFlare.Flare>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x3AD5ED0 Offset: 0x3AD5FD1 VA: 0x3AD5ED0
	|-ReadOnlyCollection<InventoryPoolItemMenuContent.KindBgNameClass>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x3AD6EA0 Offset: 0x3AD6FA1 VA: 0x3AD6EA0
	|-ReadOnlyCollection<Map.Pos>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x3AD7EA0 Offset: 0x3AD7FA1 VA: 0x3AD7EA0
	|-ReadOnlyCollection<MapImage.BackupTerrain>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x3AD8EB0 Offset: 0x3AD8FB1 VA: 0x3AD8EB0
	|-ReadOnlyCollection<MapImageRange.Pos>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x3AD9F50 Offset: 0x3ADA051 VA: 0x3AD9F50
	|-ReadOnlyCollection<MapMind.Target>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x38C4930 Offset: 0x38C4A31 VA: 0x38C4930
	|-ReadOnlyCollection<MapPanelDebug.Entity>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x38C5930 Offset: 0x38C5A31 VA: 0x38C5930
	|-ReadOnlyCollection<NexRanking.Data>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x38C6930 Offset: 0x38C6A31 VA: 0x38C6930
	|-ReadOnlyCollection<NexVersus.RatingData>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x38C7920 Offset: 0x38C7A21 VA: 0x38C7920
	|-ReadOnlyCollection<PackedPlayModeBuildLogs.RuntimeBuildLog>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x38C89C0 Offset: 0x38C8AC1 VA: 0x38C89C0
	|-ReadOnlyCollection<ParticleSystem.Particle>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x38C9A10 Offset: 0x38C9B11 VA: 0x38C9A10
	|-ReadOnlyCollection<RangeData.Offset>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x38CAAB0 Offset: 0x38CABB1 VA: 0x38CAAB0
	|-ReadOnlyCollection<RenderGraphDebugData.PassDebugData>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x38CBBB0 Offset: 0x38CBCB1 VA: 0x38CBBB0
	|-ReadOnlyCollection<RenderGraphDebugData.ResourceDebugData>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x38CCBF0 Offset: 0x38CCCF1 VA: 0x38CCBF0
	|-ReadOnlyCollection<RingCleaningUnitSelectMenu.GodParam>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x38CDCC0 Offset: 0x38CDDC1 VA: 0x38CDCC0
	|-ReadOnlyCollection<ShadowUtility.Edge>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x38CED30 Offset: 0x38CEE31 VA: 0x38CED30
	|-ReadOnlyCollection<SkillArray.Entity>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x38CFE50 Offset: 0x38CFF51 VA: 0x38CFE50
	|-ReadOnlyCollection<TexturePacker_JsonArray.Frame>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x38D0F60 Offset: 0x38D1061 VA: 0x38D0F60
	|-ReadOnlyCollection<TimeNotificationBehaviour.NotificationEntry>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x38D2020 Offset: 0x38D2121 VA: 0x38D2020
	|-ReadOnlyCollection<UnitySynchronizationContext.WorkRequest>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x38D3040 Offset: 0x38D3141 VA: 0x38D3040
	|-ReadOnlyCollection<XmlSchemaObjectTable.XmlSchemaObjectEntry>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x38D4030 Offset: 0x38D4131 VA: 0x38D4030
	|-ReadOnlyCollection<AssetBundleBuildMap.AssetBundleEntry.AssetPathString>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x38D50F0 Offset: 0x38D51F1 VA: 0x38D50F0
	|-ReadOnlyCollection<Detail.DataStore.DataStoreChangeMetaParamInt>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x38D6160 Offset: 0x38D6261 VA: 0x38D6160
	|-ReadOnlyCollection<Detail.DataStore.DataStoreDeleteParamInt>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x38D7230 Offset: 0x38D7331 VA: 0x38D7230
	|-ReadOnlyCollection<Detail.DataStore.DataStoreGetMetaParamInt>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x38D8320 Offset: 0x38D8421 VA: 0x38D8320
	|-ReadOnlyCollection<Detail.DataStore.DataStoreMetaInfoInt>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x38D9430 Offset: 0x38D9531 VA: 0x38D9430
	|-ReadOnlyCollection<Detail.DataStore.DataStorePasswordInfoInt>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x38DA4F0 Offset: 0x38DA5F1 VA: 0x38DA4F0
	|-ReadOnlyCollection<Detail.DataStore.DataStorePersistenceInfoInt>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x38DB5C0 Offset: 0x38DB6C1 VA: 0x38DB5C0
	|-ReadOnlyCollection<Detail.DataStore.DataStorePreparePostParamInt>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x38DC630 Offset: 0x38DC731 VA: 0x38DC630
	|-ReadOnlyCollection<Detail.DataStore.DataStoreRateObjectParamInt>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x38DD6C0 Offset: 0x38DD7C1 VA: 0x38DD6C0
	|-ReadOnlyCollection<Detail.DataStore.DataStoreRatingInitParamInt>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x38DE6E0 Offset: 0x38DE7E1 VA: 0x38DE6E0
	|-ReadOnlyCollection<Detail.DataStore.DataStoreRatingTargetInt>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x38DF7F0 Offset: 0x38DF8F1 VA: 0x38DF7F0
	|-ReadOnlyCollection<Detail.Ranking.RankingCachedResultInt>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x38E0860 Offset: 0x38E0961 VA: 0x38E0860
	|-ReadOnlyCollection<Detail.Ranking.RankingOrderParamInt>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x38E1970 Offset: 0x38E1A71 VA: 0x38E1970
	|-ReadOnlyCollection<Detail.Ranking.RankingRankDataInt>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x38E2B80 Offset: 0x38E2C81 VA: 0x38E2B80
	|-ReadOnlyCollection<Detail.Ranking2.Ranking2ChartInfoInt>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x38E3E10 Offset: 0x38E3F11 VA: 0x38E3E10
	|-ReadOnlyCollection<Detail.Ranking2.Ranking2RankDataInt>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x38E4E80 Offset: 0x38E4F81 VA: 0x38E4E80
	|-ReadOnlyCollection<Detail.Ranking2.Ranking2ScoreDataInt>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x38E5F10 Offset: 0x38E6011 VA: 0x38E5F10
	|-ReadOnlyCollection<Detail.Screening.ScreeningContextInfoInt>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x38E7090 Offset: 0x38E7191 VA: 0x38E7090
	|-ReadOnlyCollection<Detail.Subscriber.SubscriberContentInt>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x38E8220 Offset: 0x38E8321 VA: 0x38E8220
	|-ReadOnlyCollection<Detail.Subscriber.SubscriberGetContentParamInt>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x38E9320 Offset: 0x38E9421 VA: 0x38E9320
	|-ReadOnlyCollection<Detail.Subscriber.SubscriberUserStatusInfoInt>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x38EA400 Offset: 0x38EA501 VA: 0x38EA400
	|-ReadOnlyCollection<Detail.Subscriber.SubscriberUserStatusParamInt>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x38EB400 Offset: 0x38EB501 VA: 0x38EB400
	|-ReadOnlyCollection<Detail.Utility.IntegerSettings>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x38EC400 Offset: 0x38EC501 VA: 0x38EC400
	|-ReadOnlyCollection<Detail.Utility.UniqueIdInfoInt>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x38ED410 Offset: 0x38ED511 VA: 0x38ED410
	|-ReadOnlyCollection<MapHistory.Rewind.LatestInspectorData>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x38EE440 Offset: 0x38EE541 VA: 0x38EE440
	|-ReadOnlyCollection<MapHistory.Rewind.WorkTerrainData>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x38EF450 Offset: 0x38EF551 VA: 0x38EF450
	|-ReadOnlyCollection<MapSkill.AroundCalculator.Result>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x38F0520 Offset: 0x38F0621 VA: 0x38F0520
	|-ReadOnlyCollection<TargetPositionCache.CacheCurve.Item>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x2FE5AC0 Offset: 0x2FE5BC1 VA: 0x2FE5AC0
	|-ReadOnlyCollection<TargetPositionCache.CacheEntry.RecordingItem>.System.Collections.Generic.IList<T>.set_Item
	*/

	// RVA: -1 Offset: -1 Slot: 11
	private void System.Collections.Generic.ICollection<T>.Add(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3467900 Offset: 0x3467A01 VA: 0x3467900
	|-ReadOnlyCollection<IntervalTree.Entry<object>>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x3468920 Offset: 0x3468A21 VA: 0x3468920
	|-ReadOnlyCollection<KeyValuePair<DateTime, object>>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x3469910 Offset: 0x3469A11 VA: 0x3469910
	|-ReadOnlyCollection<KeyValuePair<int, object>>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x346A9A0 Offset: 0x346AAA1 VA: 0x346A9A0
	|-ReadOnlyCollection<KeyValuePair<object, ValueTuple<int, DateTime, object>>>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x346B9C0 Offset: 0x346BAC1 VA: 0x346B9C0
	|-ReadOnlyCollection<KeyValuePair<object, object>>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x346CA50 Offset: 0x346CB51 VA: 0x346CA50
	|-ReadOnlyCollection<CommonBattleSequence.Reliance<object>>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x346DA70 Offset: 0x346DB71 VA: 0x346DA70
	|-ReadOnlyCollection<RenderGraphResourcePool.ResourceLogInfo<object>>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x346EA60 Offset: 0x346EB61 VA: 0x346EA60
	|-ReadOnlyCollection<ValueTuple<int, object>>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x346FA30 Offset: 0x346FB31 VA: 0x346FA30
	|-ReadOnlyCollection<ValueTuple<Int32Enum, int>>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x3470AD0 Offset: 0x3470BD1 VA: 0x3470AD0
	|-ReadOnlyCollection<ValueTuple<object, ValueTuple<object, int>>>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x3471AF0 Offset: 0x3471BF1 VA: 0x3471AF0
	|-ReadOnlyCollection<ValueTuple<object, int>>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x3472B00 Offset: 0x3472C01 VA: 0x3472B00
	|-ReadOnlyCollection<ValueTuple<Vector3, float>>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x3473B00 Offset: 0x3473C01 VA: 0x3473B00
	|-ReadOnlyCollection<ValueTuple<object, Int32Enum, int>>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x3474B90 Offset: 0x3474C91 VA: 0x3474B90
	|-ReadOnlyCollection<ValueTuple<object, int, int, int>>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x3475B90 Offset: 0x3475C91 VA: 0x3475B90
	|-ReadOnlyCollection<AnimatorClipInfo>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x3B229D0 Offset: 0x3B22AD1 VA: 0x3B229D0
	|-ReadOnlyCollection<AsyncOperationHandle>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x3B23A90 Offset: 0x3B23B91 VA: 0x3B23A90
	|-ReadOnlyCollection<BoneWeight>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x3B24A90 Offset: 0x3B24B91 VA: 0x3B24A90
	|-ReadOnlyCollection<bool>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x3B25A80 Offset: 0x3B25B81 VA: 0x3B25A80
	|-ReadOnlyCollection<byte>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x3B26A80 Offset: 0x3B26B81 VA: 0x3B26A80
	|-ReadOnlyCollection<CameraInfo>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x3B27A50 Offset: 0x3B27B51 VA: 0x3B27A50
	|-ReadOnlyCollection<char>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x3B28A70 Offset: 0x3B28B71 VA: 0x3B28A70
	|-ReadOnlyCollection<Color>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x3B29A90 Offset: 0x3B29B91 VA: 0x3B29A90
	|-ReadOnlyCollection<Color32>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x3B2AA90 Offset: 0x3B2AB91 VA: 0x3B2AA90
	|-ReadOnlyCollection<ConstraintSource>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x3B2BB20 Offset: 0x3B2BC21 VA: 0x3B2BB20
	|-ReadOnlyCollection<ContourVertex>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x3B2CBE0 Offset: 0x3B2CCE1 VA: 0x3B2CBE0
	|-ReadOnlyCollection<CustomAttributeNamedArgument>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x3B2DC00 Offset: 0x3B2DD01 VA: 0x3B2DC00
	|-ReadOnlyCollection<CustomAttributeTypedArgument>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x3B2EC90 Offset: 0x3B2ED91 VA: 0x3B2EC90
	|-ReadOnlyCollection<DataStoreRatingInfo>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x3B2FC90 Offset: 0x3B2FD91 VA: 0x3B2FC90
	|-ReadOnlyCollection<DataStoreResult>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x3B30C70 Offset: 0x3B30D71 VA: 0x3B30C70
	|-ReadOnlyCollection<DateTime>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x3B31C70 Offset: 0x3B31D71 VA: 0x3B31C70
	|-ReadOnlyCollection<DateTimeOffset>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x3B32C60 Offset: 0x3B32D61 VA: 0x3B32C60
	|-ReadOnlyCollection<Decimal>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x3B33D30 Offset: 0x3B33E31 VA: 0x3B33D30
	|-ReadOnlyCollection<DiagnosticEvent>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x3B34D60 Offset: 0x3B34E61 VA: 0x3B34D60
	|-ReadOnlyCollection<double>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x3B35E50 Offset: 0x3B35F51 VA: 0x3B35E50
	|-ReadOnlyCollection<Friend>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x3B36E90 Offset: 0x3B36F91 VA: 0x3B36E90
	|-ReadOnlyCollection<GlyphRect>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x3B37E60 Offset: 0x3B37F61 VA: 0x3B37E60
	|-ReadOnlyCollection<short>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x3B38E40 Offset: 0x3B38F41 VA: 0x3B38E40
	|-ReadOnlyCollection<int>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x3B39E20 Offset: 0x3B39F21 VA: 0x3B39E20
	|-ReadOnlyCollection<Int32Enum>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x3B3AE00 Offset: 0x3B3AF01 VA: 0x3B3AE00
	|-ReadOnlyCollection<long>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x3B3BDE0 Offset: 0x3B3BEE1 VA: 0x3B3BDE0
	|-ReadOnlyCollection<IntPtr>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x3B3CDE0 Offset: 0x3B3CEE1 VA: 0x3B3CDE0
	|-ReadOnlyCollection<InterpretedFrameInfo>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x3B3DE70 Offset: 0x3B3DF71 VA: 0x3B3DE70
	|-ReadOnlyCollection<IntervalTreeNode>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x3B3EE70 Offset: 0x3B3EF71 VA: 0x3B3EE70
	|-ReadOnlyCollection<LengthLimitProperties>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x3B3FE50 Offset: 0x3B3FF51 VA: 0x3B3FE50
	|-ReadOnlyCollection<MapPos>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x3B40F70 Offset: 0x3B41071 VA: 0x3B40F70
	|-ReadOnlyCollection<Matrix4x4>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x3B41FC0 Offset: 0x3B420C1 VA: 0x3B41FC0
	|-ReadOnlyCollection<object>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x3B42FB0 Offset: 0x3B430B1 VA: 0x3B42FB0
	|-ReadOnlyCollection<ObjectInitializationData>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x3B440A0 Offset: 0x3B441A1 VA: 0x3B440A0
	|-ReadOnlyCollection<PlayableBinding>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x3B451A0 Offset: 0x3B452A1 VA: 0x3B451A0
	|-ReadOnlyCollection<PlayerLoopSystem>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x3B462C0 Offset: 0x3B463C1 VA: 0x3B462C0
	|-ReadOnlyCollection<PlayerLoopSystemInternal>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x3B47300 Offset: 0x3B47401 VA: 0x3B47300
	|-ReadOnlyCollection<RangePositionInfo>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x3B482D0 Offset: 0x3B483D1 VA: 0x3B482D0
	|-ReadOnlyCollection<Ranking2ChartInfoInput>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x3B493D0 Offset: 0x3B494D1 VA: 0x3B493D0
	|-ReadOnlyCollection<RaycastHit2D>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x3B4A590 Offset: 0x3B4A691 VA: 0x3B4A590
	|-ReadOnlyCollection<RaycastResult>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x3B4B6A0 Offset: 0x3B4B7A1 VA: 0x3B4B6A0
	|-ReadOnlyCollection<Rect>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x3B4C680 Offset: 0x3B4C781 VA: 0x3B4C680
	|-ReadOnlyCollection<RendererListHandle>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x3B4D660 Offset: 0x3B4D761 VA: 0x3B4D660
	|-ReadOnlyCollection<ResourceHandle>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x3AAED20 Offset: 0x3AAEE21 VA: 0x3AAED20
	|-ReadOnlyCollection<sbyte>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x3AAFD40 Offset: 0x3AAFE41 VA: 0x3AAFD40
	|-ReadOnlyCollection<ShaderTagId>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x3AB0D20 Offset: 0x3AB0E21 VA: 0x3AB0D20
	|-ReadOnlyCollection<float>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x3AB1F40 Offset: 0x3AB2041 VA: 0x3AB1F40
	|-ReadOnlyCollection<SphericalHarmonicsL2>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x3AB31F0 Offset: 0x3AB32F1 VA: 0x3AB31F0
	|-ReadOnlyCollection<SubMeshDescriptor>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x3AB4240 Offset: 0x3AB4341 VA: 0x3AB4240
	|-ReadOnlyCollection<TablePair>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x3AB5210 Offset: 0x3AB5311 VA: 0x3AB5210
	|-ReadOnlyCollection<TimeSpan>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x3AB6230 Offset: 0x3AB6331 VA: 0x3AB6230
	|-ReadOnlyCollection<UICharInfo>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x3AB7230 Offset: 0x3AB7331 VA: 0x3AB7230
	|-ReadOnlyCollection<UILineInfo>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x3AB8440 Offset: 0x3AB8541 VA: 0x3AB8440
	|-ReadOnlyCollection<UIVertex>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x3AB95F0 Offset: 0x3AB96F1 VA: 0x3AB95F0
	|-ReadOnlyCollection<ushort>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x3ABA5D0 Offset: 0x3ABA6D1 VA: 0x3ABA5D0
	|-ReadOnlyCollection<uint>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x3ABB5B0 Offset: 0x3ABB6B1 VA: 0x3ABB5B0
	|-ReadOnlyCollection<ulong>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x3ABC5B0 Offset: 0x3ABC6B1 VA: 0x3ABC5B0
	|-ReadOnlyCollection<Vector2>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x3ABD5D0 Offset: 0x3ABD6D1 VA: 0x3ABD5D0
	|-ReadOnlyCollection<Vector3>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x3ABE5F0 Offset: 0x3ABE6F1 VA: 0x3ABE5F0
	|-ReadOnlyCollection<Vector4>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x3ABF5F0 Offset: 0x3ABF6F1 VA: 0x3ABF5F0
	|-ReadOnlyCollection<VertexAttributeDescriptor>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x3AC05E0 Offset: 0x3AC06E1 VA: 0x3AC05E0
	|-ReadOnlyCollection<X509ChainStatus>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x3AC1680 Offset: 0x3AC1781 VA: 0x3AC1680
	|-ReadOnlyCollection<XRView>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x3AC2710 Offset: 0x3AC2811 VA: 0x3AC2710
	|-ReadOnlyCollection<AICrossfire.PositionTable>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x3AC3720 Offset: 0x3AC3821 VA: 0x3AC3720
	|-ReadOnlyCollection<AmiiboSequence.GainItemData>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x3AC47F0 Offset: 0x3AC48F1 VA: 0x3AC47F0
	|-ReadOnlyCollection<AnimationOutputWeightProcessor.WeightInfo>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x3AC5830 Offset: 0x3AC5931 VA: 0x3AC5830
	|-ReadOnlyCollection<ArenaOrderSequence.GodInfo>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x3AC6820 Offset: 0x3AC6921 VA: 0x3AC6820
	|-ReadOnlyCollection<BattleInfo.SupportData>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x3AC7810 Offset: 0x3AC7911 VA: 0x3AC7810
	|-ReadOnlyCollection<BeforeRenderHelper.OrderBlock>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x3AC88A0 Offset: 0x3AC89A1 VA: 0x3AC88A0
	|-ReadOnlyCollection<Camera.RenderRequest>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x3AC98C0 Offset: 0x3AC99C1 VA: 0x3AC98C0
	|-ReadOnlyCollection<CameraState.CustomBlendable>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x3ACA890 Offset: 0x3ACA991 VA: 0x3ACA890
	|-ReadOnlyCollection<CinemachineClearShot.Pair>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x3ACB870 Offset: 0x3ACB971 VA: 0x3ACB870
	|-ReadOnlyCollection<CinemachineStateDrivenCamera.HashPair>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x3ACC910 Offset: 0x3ACCA11 VA: 0x3ACC910
	|-ReadOnlyCollection<DelayedActionManager.DelegateInfo>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x3ACDA10 Offset: 0x3ACDB11 VA: 0x3ACDA10
	|-ReadOnlyCollection<Detail.AsyncResultInt>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x3ACEA60 Offset: 0x3ACEB61 VA: 0x3ACEA60
	|-ReadOnlyCollection<Detail.CppArray>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x3ACFB30 Offset: 0x3ACFC31 VA: 0x3ACFB30
	|-ReadOnlyCollection<Detail.NotificationEventInt>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x3AD0B80 Offset: 0x3AD0C81 VA: 0x3AD0B80
	|-ReadOnlyCollection<DragonRideTargetGroup.ChainParam>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x3AD1C10 Offset: 0x3AD1D11 VA: 0x3AD1C10
	|-ReadOnlyCollection<GmapPathAdjuster.TargetModel>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x3AD2CD0 Offset: 0x3AD2DD1 VA: 0x3AD2CD0
	|-ReadOnlyCollection<GmapSpotAdjuster.TargetModel>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x3AD3D90 Offset: 0x3AD3E91 VA: 0x3AD3D90
	|-ReadOnlyCollection<HubFastTravel.Location>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x3AD4E90 Offset: 0x3AD4F91 VA: 0x3AD4E90
	|-ReadOnlyCollection<HubLensFlare.Flare>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x3AD5EE0 Offset: 0x3AD5FE1 VA: 0x3AD5EE0
	|-ReadOnlyCollection<InventoryPoolItemMenuContent.KindBgNameClass>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x3AD6EB0 Offset: 0x3AD6FB1 VA: 0x3AD6EB0
	|-ReadOnlyCollection<Map.Pos>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x3AD7EB0 Offset: 0x3AD7FB1 VA: 0x3AD7EB0
	|-ReadOnlyCollection<MapImage.BackupTerrain>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x3AD8EC0 Offset: 0x3AD8FC1 VA: 0x3AD8EC0
	|-ReadOnlyCollection<MapImageRange.Pos>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x3AD9F60 Offset: 0x3ADA061 VA: 0x3AD9F60
	|-ReadOnlyCollection<MapMind.Target>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x38C4940 Offset: 0x38C4A41 VA: 0x38C4940
	|-ReadOnlyCollection<MapPanelDebug.Entity>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x38C5940 Offset: 0x38C5A41 VA: 0x38C5940
	|-ReadOnlyCollection<NexRanking.Data>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x38C6940 Offset: 0x38C6A41 VA: 0x38C6940
	|-ReadOnlyCollection<NexVersus.RatingData>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x38C7930 Offset: 0x38C7A31 VA: 0x38C7930
	|-ReadOnlyCollection<PackedPlayModeBuildLogs.RuntimeBuildLog>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x38C89D0 Offset: 0x38C8AD1 VA: 0x38C89D0
	|-ReadOnlyCollection<ParticleSystem.Particle>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x38C9A20 Offset: 0x38C9B21 VA: 0x38C9A20
	|-ReadOnlyCollection<RangeData.Offset>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x38CAAC0 Offset: 0x38CABC1 VA: 0x38CAAC0
	|-ReadOnlyCollection<RenderGraphDebugData.PassDebugData>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x38CBBC0 Offset: 0x38CBCC1 VA: 0x38CBBC0
	|-ReadOnlyCollection<RenderGraphDebugData.ResourceDebugData>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x38CCC00 Offset: 0x38CCD01 VA: 0x38CCC00
	|-ReadOnlyCollection<RingCleaningUnitSelectMenu.GodParam>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x38CDCD0 Offset: 0x38CDDD1 VA: 0x38CDCD0
	|-ReadOnlyCollection<ShadowUtility.Edge>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x38CED40 Offset: 0x38CEE41 VA: 0x38CED40
	|-ReadOnlyCollection<SkillArray.Entity>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x38CFE60 Offset: 0x38CFF61 VA: 0x38CFE60
	|-ReadOnlyCollection<TexturePacker_JsonArray.Frame>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x38D0F70 Offset: 0x38D1071 VA: 0x38D0F70
	|-ReadOnlyCollection<TimeNotificationBehaviour.NotificationEntry>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x38D2030 Offset: 0x38D2131 VA: 0x38D2030
	|-ReadOnlyCollection<UnitySynchronizationContext.WorkRequest>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x38D3050 Offset: 0x38D3151 VA: 0x38D3050
	|-ReadOnlyCollection<XmlSchemaObjectTable.XmlSchemaObjectEntry>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x38D4040 Offset: 0x38D4141 VA: 0x38D4040
	|-ReadOnlyCollection<AssetBundleBuildMap.AssetBundleEntry.AssetPathString>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x38D5100 Offset: 0x38D5201 VA: 0x38D5100
	|-ReadOnlyCollection<Detail.DataStore.DataStoreChangeMetaParamInt>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x38D6170 Offset: 0x38D6271 VA: 0x38D6170
	|-ReadOnlyCollection<Detail.DataStore.DataStoreDeleteParamInt>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x38D7240 Offset: 0x38D7341 VA: 0x38D7240
	|-ReadOnlyCollection<Detail.DataStore.DataStoreGetMetaParamInt>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x38D8330 Offset: 0x38D8431 VA: 0x38D8330
	|-ReadOnlyCollection<Detail.DataStore.DataStoreMetaInfoInt>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x38D9440 Offset: 0x38D9541 VA: 0x38D9440
	|-ReadOnlyCollection<Detail.DataStore.DataStorePasswordInfoInt>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x38DA500 Offset: 0x38DA601 VA: 0x38DA500
	|-ReadOnlyCollection<Detail.DataStore.DataStorePersistenceInfoInt>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x38DB5D0 Offset: 0x38DB6D1 VA: 0x38DB5D0
	|-ReadOnlyCollection<Detail.DataStore.DataStorePreparePostParamInt>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x38DC640 Offset: 0x38DC741 VA: 0x38DC640
	|-ReadOnlyCollection<Detail.DataStore.DataStoreRateObjectParamInt>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x38DD6D0 Offset: 0x38DD7D1 VA: 0x38DD6D0
	|-ReadOnlyCollection<Detail.DataStore.DataStoreRatingInitParamInt>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x38DE6F0 Offset: 0x38DE7F1 VA: 0x38DE6F0
	|-ReadOnlyCollection<Detail.DataStore.DataStoreRatingTargetInt>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x38DF800 Offset: 0x38DF901 VA: 0x38DF800
	|-ReadOnlyCollection<Detail.Ranking.RankingCachedResultInt>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x38E0870 Offset: 0x38E0971 VA: 0x38E0870
	|-ReadOnlyCollection<Detail.Ranking.RankingOrderParamInt>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x38E1980 Offset: 0x38E1A81 VA: 0x38E1980
	|-ReadOnlyCollection<Detail.Ranking.RankingRankDataInt>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x38E2B90 Offset: 0x38E2C91 VA: 0x38E2B90
	|-ReadOnlyCollection<Detail.Ranking2.Ranking2ChartInfoInt>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x38E3E20 Offset: 0x38E3F21 VA: 0x38E3E20
	|-ReadOnlyCollection<Detail.Ranking2.Ranking2RankDataInt>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x38E4E90 Offset: 0x38E4F91 VA: 0x38E4E90
	|-ReadOnlyCollection<Detail.Ranking2.Ranking2ScoreDataInt>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x38E5F20 Offset: 0x38E6021 VA: 0x38E5F20
	|-ReadOnlyCollection<Detail.Screening.ScreeningContextInfoInt>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x38E70A0 Offset: 0x38E71A1 VA: 0x38E70A0
	|-ReadOnlyCollection<Detail.Subscriber.SubscriberContentInt>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x38E8230 Offset: 0x38E8331 VA: 0x38E8230
	|-ReadOnlyCollection<Detail.Subscriber.SubscriberGetContentParamInt>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x38E9330 Offset: 0x38E9431 VA: 0x38E9330
	|-ReadOnlyCollection<Detail.Subscriber.SubscriberUserStatusInfoInt>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x38EA410 Offset: 0x38EA511 VA: 0x38EA410
	|-ReadOnlyCollection<Detail.Subscriber.SubscriberUserStatusParamInt>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x38EB410 Offset: 0x38EB511 VA: 0x38EB410
	|-ReadOnlyCollection<Detail.Utility.IntegerSettings>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x38EC410 Offset: 0x38EC511 VA: 0x38EC410
	|-ReadOnlyCollection<Detail.Utility.UniqueIdInfoInt>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x38ED420 Offset: 0x38ED521 VA: 0x38ED420
	|-ReadOnlyCollection<MapHistory.Rewind.LatestInspectorData>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x38EE450 Offset: 0x38EE551 VA: 0x38EE450
	|-ReadOnlyCollection<MapHistory.Rewind.WorkTerrainData>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x38EF460 Offset: 0x38EF561 VA: 0x38EF460
	|-ReadOnlyCollection<MapSkill.AroundCalculator.Result>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x38F0530 Offset: 0x38F0631 VA: 0x38F0530
	|-ReadOnlyCollection<TargetPositionCache.CacheCurve.Item>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x2FE5AD0 Offset: 0x2FE5BD1 VA: 0x2FE5AD0
	|-ReadOnlyCollection<TargetPositionCache.CacheEntry.RecordingItem>.System.Collections.Generic.ICollection<T>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 12
	private void System.Collections.Generic.ICollection<T>.Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3467910 Offset: 0x3467A11 VA: 0x3467910
	|-ReadOnlyCollection<IntervalTree.Entry<object>>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x3468930 Offset: 0x3468A31 VA: 0x3468930
	|-ReadOnlyCollection<KeyValuePair<DateTime, object>>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x3469920 Offset: 0x3469A21 VA: 0x3469920
	|-ReadOnlyCollection<KeyValuePair<int, object>>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x346A9B0 Offset: 0x346AAB1 VA: 0x346A9B0
	|-ReadOnlyCollection<KeyValuePair<object, ValueTuple<int, DateTime, object>>>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x346B9D0 Offset: 0x346BAD1 VA: 0x346B9D0
	|-ReadOnlyCollection<KeyValuePair<object, object>>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x346CA60 Offset: 0x346CB61 VA: 0x346CA60
	|-ReadOnlyCollection<CommonBattleSequence.Reliance<object>>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x346DA80 Offset: 0x346DB81 VA: 0x346DA80
	|-ReadOnlyCollection<RenderGraphResourcePool.ResourceLogInfo<object>>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x346EA70 Offset: 0x346EB71 VA: 0x346EA70
	|-ReadOnlyCollection<ValueTuple<int, object>>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x346FA40 Offset: 0x346FB41 VA: 0x346FA40
	|-ReadOnlyCollection<ValueTuple<Int32Enum, int>>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x3470AE0 Offset: 0x3470BE1 VA: 0x3470AE0
	|-ReadOnlyCollection<ValueTuple<object, ValueTuple<object, int>>>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x3471B00 Offset: 0x3471C01 VA: 0x3471B00
	|-ReadOnlyCollection<ValueTuple<object, int>>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x3472B10 Offset: 0x3472C11 VA: 0x3472B10
	|-ReadOnlyCollection<ValueTuple<Vector3, float>>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x3473B10 Offset: 0x3473C11 VA: 0x3473B10
	|-ReadOnlyCollection<ValueTuple<object, Int32Enum, int>>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x3474BA0 Offset: 0x3474CA1 VA: 0x3474BA0
	|-ReadOnlyCollection<ValueTuple<object, int, int, int>>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x3475BA0 Offset: 0x3475CA1 VA: 0x3475BA0
	|-ReadOnlyCollection<AnimatorClipInfo>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x3B229E0 Offset: 0x3B22AE1 VA: 0x3B229E0
	|-ReadOnlyCollection<AsyncOperationHandle>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x3B23AA0 Offset: 0x3B23BA1 VA: 0x3B23AA0
	|-ReadOnlyCollection<BoneWeight>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x3B24AA0 Offset: 0x3B24BA1 VA: 0x3B24AA0
	|-ReadOnlyCollection<bool>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x3B25A90 Offset: 0x3B25B91 VA: 0x3B25A90
	|-ReadOnlyCollection<byte>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x3B26A90 Offset: 0x3B26B91 VA: 0x3B26A90
	|-ReadOnlyCollection<CameraInfo>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x3B27A60 Offset: 0x3B27B61 VA: 0x3B27A60
	|-ReadOnlyCollection<char>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x3B28A80 Offset: 0x3B28B81 VA: 0x3B28A80
	|-ReadOnlyCollection<Color>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x3B29AA0 Offset: 0x3B29BA1 VA: 0x3B29AA0
	|-ReadOnlyCollection<Color32>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x3B2AAA0 Offset: 0x3B2ABA1 VA: 0x3B2AAA0
	|-ReadOnlyCollection<ConstraintSource>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x3B2BB30 Offset: 0x3B2BC31 VA: 0x3B2BB30
	|-ReadOnlyCollection<ContourVertex>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x3B2CBF0 Offset: 0x3B2CCF1 VA: 0x3B2CBF0
	|-ReadOnlyCollection<CustomAttributeNamedArgument>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x3B2DC10 Offset: 0x3B2DD11 VA: 0x3B2DC10
	|-ReadOnlyCollection<CustomAttributeTypedArgument>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x3B2ECA0 Offset: 0x3B2EDA1 VA: 0x3B2ECA0
	|-ReadOnlyCollection<DataStoreRatingInfo>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x3B2FCA0 Offset: 0x3B2FDA1 VA: 0x3B2FCA0
	|-ReadOnlyCollection<DataStoreResult>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x3B30C80 Offset: 0x3B30D81 VA: 0x3B30C80
	|-ReadOnlyCollection<DateTime>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x3B31C80 Offset: 0x3B31D81 VA: 0x3B31C80
	|-ReadOnlyCollection<DateTimeOffset>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x3B32C70 Offset: 0x3B32D71 VA: 0x3B32C70
	|-ReadOnlyCollection<Decimal>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x3B33D40 Offset: 0x3B33E41 VA: 0x3B33D40
	|-ReadOnlyCollection<DiagnosticEvent>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x3B34D70 Offset: 0x3B34E71 VA: 0x3B34D70
	|-ReadOnlyCollection<double>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x3B35E60 Offset: 0x3B35F61 VA: 0x3B35E60
	|-ReadOnlyCollection<Friend>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x3B36EA0 Offset: 0x3B36FA1 VA: 0x3B36EA0
	|-ReadOnlyCollection<GlyphRect>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x3B37E70 Offset: 0x3B37F71 VA: 0x3B37E70
	|-ReadOnlyCollection<short>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x3B38E50 Offset: 0x3B38F51 VA: 0x3B38E50
	|-ReadOnlyCollection<int>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x3B39E30 Offset: 0x3B39F31 VA: 0x3B39E30
	|-ReadOnlyCollection<Int32Enum>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x3B3AE10 Offset: 0x3B3AF11 VA: 0x3B3AE10
	|-ReadOnlyCollection<long>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x3B3BDF0 Offset: 0x3B3BEF1 VA: 0x3B3BDF0
	|-ReadOnlyCollection<IntPtr>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x3B3CDF0 Offset: 0x3B3CEF1 VA: 0x3B3CDF0
	|-ReadOnlyCollection<InterpretedFrameInfo>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x3B3DE80 Offset: 0x3B3DF81 VA: 0x3B3DE80
	|-ReadOnlyCollection<IntervalTreeNode>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x3B3EE80 Offset: 0x3B3EF81 VA: 0x3B3EE80
	|-ReadOnlyCollection<LengthLimitProperties>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x3B3FE60 Offset: 0x3B3FF61 VA: 0x3B3FE60
	|-ReadOnlyCollection<MapPos>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x3B40F80 Offset: 0x3B41081 VA: 0x3B40F80
	|-ReadOnlyCollection<Matrix4x4>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x3B41FD0 Offset: 0x3B420D1 VA: 0x3B41FD0
	|-ReadOnlyCollection<object>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x3B42FC0 Offset: 0x3B430C1 VA: 0x3B42FC0
	|-ReadOnlyCollection<ObjectInitializationData>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x3B440B0 Offset: 0x3B441B1 VA: 0x3B440B0
	|-ReadOnlyCollection<PlayableBinding>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x3B451B0 Offset: 0x3B452B1 VA: 0x3B451B0
	|-ReadOnlyCollection<PlayerLoopSystem>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x3B462D0 Offset: 0x3B463D1 VA: 0x3B462D0
	|-ReadOnlyCollection<PlayerLoopSystemInternal>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x3B47310 Offset: 0x3B47411 VA: 0x3B47310
	|-ReadOnlyCollection<RangePositionInfo>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x3B482E0 Offset: 0x3B483E1 VA: 0x3B482E0
	|-ReadOnlyCollection<Ranking2ChartInfoInput>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x3B493E0 Offset: 0x3B494E1 VA: 0x3B493E0
	|-ReadOnlyCollection<RaycastHit2D>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x3B4A5A0 Offset: 0x3B4A6A1 VA: 0x3B4A5A0
	|-ReadOnlyCollection<RaycastResult>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x3B4B6B0 Offset: 0x3B4B7B1 VA: 0x3B4B6B0
	|-ReadOnlyCollection<Rect>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x3B4C690 Offset: 0x3B4C791 VA: 0x3B4C690
	|-ReadOnlyCollection<RendererListHandle>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x3B4D670 Offset: 0x3B4D771 VA: 0x3B4D670
	|-ReadOnlyCollection<ResourceHandle>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x3AAED30 Offset: 0x3AAEE31 VA: 0x3AAED30
	|-ReadOnlyCollection<sbyte>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x3AAFD50 Offset: 0x3AAFE51 VA: 0x3AAFD50
	|-ReadOnlyCollection<ShaderTagId>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x3AB0D30 Offset: 0x3AB0E31 VA: 0x3AB0D30
	|-ReadOnlyCollection<float>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x3AB1F50 Offset: 0x3AB2051 VA: 0x3AB1F50
	|-ReadOnlyCollection<SphericalHarmonicsL2>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x3AB3200 Offset: 0x3AB3301 VA: 0x3AB3200
	|-ReadOnlyCollection<SubMeshDescriptor>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x3AB4250 Offset: 0x3AB4351 VA: 0x3AB4250
	|-ReadOnlyCollection<TablePair>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x3AB5220 Offset: 0x3AB5321 VA: 0x3AB5220
	|-ReadOnlyCollection<TimeSpan>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x3AB6240 Offset: 0x3AB6341 VA: 0x3AB6240
	|-ReadOnlyCollection<UICharInfo>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x3AB7240 Offset: 0x3AB7341 VA: 0x3AB7240
	|-ReadOnlyCollection<UILineInfo>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x3AB8450 Offset: 0x3AB8551 VA: 0x3AB8450
	|-ReadOnlyCollection<UIVertex>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x3AB9600 Offset: 0x3AB9701 VA: 0x3AB9600
	|-ReadOnlyCollection<ushort>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x3ABA5E0 Offset: 0x3ABA6E1 VA: 0x3ABA5E0
	|-ReadOnlyCollection<uint>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x3ABB5C0 Offset: 0x3ABB6C1 VA: 0x3ABB5C0
	|-ReadOnlyCollection<ulong>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x3ABC5C0 Offset: 0x3ABC6C1 VA: 0x3ABC5C0
	|-ReadOnlyCollection<Vector2>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x3ABD5E0 Offset: 0x3ABD6E1 VA: 0x3ABD5E0
	|-ReadOnlyCollection<Vector3>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x3ABE600 Offset: 0x3ABE701 VA: 0x3ABE600
	|-ReadOnlyCollection<Vector4>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x3ABF600 Offset: 0x3ABF701 VA: 0x3ABF600
	|-ReadOnlyCollection<VertexAttributeDescriptor>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x3AC05F0 Offset: 0x3AC06F1 VA: 0x3AC05F0
	|-ReadOnlyCollection<X509ChainStatus>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x3AC1690 Offset: 0x3AC1791 VA: 0x3AC1690
	|-ReadOnlyCollection<XRView>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x3AC2720 Offset: 0x3AC2821 VA: 0x3AC2720
	|-ReadOnlyCollection<AICrossfire.PositionTable>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x3AC3730 Offset: 0x3AC3831 VA: 0x3AC3730
	|-ReadOnlyCollection<AmiiboSequence.GainItemData>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x3AC4800 Offset: 0x3AC4901 VA: 0x3AC4800
	|-ReadOnlyCollection<AnimationOutputWeightProcessor.WeightInfo>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x3AC5840 Offset: 0x3AC5941 VA: 0x3AC5840
	|-ReadOnlyCollection<ArenaOrderSequence.GodInfo>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x3AC6830 Offset: 0x3AC6931 VA: 0x3AC6830
	|-ReadOnlyCollection<BattleInfo.SupportData>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x3AC7820 Offset: 0x3AC7921 VA: 0x3AC7820
	|-ReadOnlyCollection<BeforeRenderHelper.OrderBlock>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x3AC88B0 Offset: 0x3AC89B1 VA: 0x3AC88B0
	|-ReadOnlyCollection<Camera.RenderRequest>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x3AC98D0 Offset: 0x3AC99D1 VA: 0x3AC98D0
	|-ReadOnlyCollection<CameraState.CustomBlendable>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x3ACA8A0 Offset: 0x3ACA9A1 VA: 0x3ACA8A0
	|-ReadOnlyCollection<CinemachineClearShot.Pair>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x3ACB880 Offset: 0x3ACB981 VA: 0x3ACB880
	|-ReadOnlyCollection<CinemachineStateDrivenCamera.HashPair>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x3ACC920 Offset: 0x3ACCA21 VA: 0x3ACC920
	|-ReadOnlyCollection<DelayedActionManager.DelegateInfo>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x3ACDA20 Offset: 0x3ACDB21 VA: 0x3ACDA20
	|-ReadOnlyCollection<Detail.AsyncResultInt>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x3ACEA70 Offset: 0x3ACEB71 VA: 0x3ACEA70
	|-ReadOnlyCollection<Detail.CppArray>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x3ACFB40 Offset: 0x3ACFC41 VA: 0x3ACFB40
	|-ReadOnlyCollection<Detail.NotificationEventInt>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x3AD0B90 Offset: 0x3AD0C91 VA: 0x3AD0B90
	|-ReadOnlyCollection<DragonRideTargetGroup.ChainParam>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x3AD1C20 Offset: 0x3AD1D21 VA: 0x3AD1C20
	|-ReadOnlyCollection<GmapPathAdjuster.TargetModel>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x3AD2CE0 Offset: 0x3AD2DE1 VA: 0x3AD2CE0
	|-ReadOnlyCollection<GmapSpotAdjuster.TargetModel>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x3AD3DA0 Offset: 0x3AD3EA1 VA: 0x3AD3DA0
	|-ReadOnlyCollection<HubFastTravel.Location>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x3AD4EA0 Offset: 0x3AD4FA1 VA: 0x3AD4EA0
	|-ReadOnlyCollection<HubLensFlare.Flare>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x3AD5EF0 Offset: 0x3AD5FF1 VA: 0x3AD5EF0
	|-ReadOnlyCollection<InventoryPoolItemMenuContent.KindBgNameClass>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x3AD6EC0 Offset: 0x3AD6FC1 VA: 0x3AD6EC0
	|-ReadOnlyCollection<Map.Pos>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x3AD7EC0 Offset: 0x3AD7FC1 VA: 0x3AD7EC0
	|-ReadOnlyCollection<MapImage.BackupTerrain>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x3AD8ED0 Offset: 0x3AD8FD1 VA: 0x3AD8ED0
	|-ReadOnlyCollection<MapImageRange.Pos>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x3AD9F70 Offset: 0x3ADA071 VA: 0x3AD9F70
	|-ReadOnlyCollection<MapMind.Target>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x38C4950 Offset: 0x38C4A51 VA: 0x38C4950
	|-ReadOnlyCollection<MapPanelDebug.Entity>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x38C5950 Offset: 0x38C5A51 VA: 0x38C5950
	|-ReadOnlyCollection<NexRanking.Data>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x38C6950 Offset: 0x38C6A51 VA: 0x38C6950
	|-ReadOnlyCollection<NexVersus.RatingData>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x38C7940 Offset: 0x38C7A41 VA: 0x38C7940
	|-ReadOnlyCollection<PackedPlayModeBuildLogs.RuntimeBuildLog>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x38C89E0 Offset: 0x38C8AE1 VA: 0x38C89E0
	|-ReadOnlyCollection<ParticleSystem.Particle>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x38C9A30 Offset: 0x38C9B31 VA: 0x38C9A30
	|-ReadOnlyCollection<RangeData.Offset>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x38CAAD0 Offset: 0x38CABD1 VA: 0x38CAAD0
	|-ReadOnlyCollection<RenderGraphDebugData.PassDebugData>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x38CBBD0 Offset: 0x38CBCD1 VA: 0x38CBBD0
	|-ReadOnlyCollection<RenderGraphDebugData.ResourceDebugData>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x38CCC10 Offset: 0x38CCD11 VA: 0x38CCC10
	|-ReadOnlyCollection<RingCleaningUnitSelectMenu.GodParam>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x38CDCE0 Offset: 0x38CDDE1 VA: 0x38CDCE0
	|-ReadOnlyCollection<ShadowUtility.Edge>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x38CED50 Offset: 0x38CEE51 VA: 0x38CED50
	|-ReadOnlyCollection<SkillArray.Entity>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x38CFE70 Offset: 0x38CFF71 VA: 0x38CFE70
	|-ReadOnlyCollection<TexturePacker_JsonArray.Frame>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x38D0F80 Offset: 0x38D1081 VA: 0x38D0F80
	|-ReadOnlyCollection<TimeNotificationBehaviour.NotificationEntry>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x38D2040 Offset: 0x38D2141 VA: 0x38D2040
	|-ReadOnlyCollection<UnitySynchronizationContext.WorkRequest>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x38D3060 Offset: 0x38D3161 VA: 0x38D3060
	|-ReadOnlyCollection<XmlSchemaObjectTable.XmlSchemaObjectEntry>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x38D4050 Offset: 0x38D4151 VA: 0x38D4050
	|-ReadOnlyCollection<AssetBundleBuildMap.AssetBundleEntry.AssetPathString>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x38D5110 Offset: 0x38D5211 VA: 0x38D5110
	|-ReadOnlyCollection<Detail.DataStore.DataStoreChangeMetaParamInt>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x38D6180 Offset: 0x38D6281 VA: 0x38D6180
	|-ReadOnlyCollection<Detail.DataStore.DataStoreDeleteParamInt>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x38D7250 Offset: 0x38D7351 VA: 0x38D7250
	|-ReadOnlyCollection<Detail.DataStore.DataStoreGetMetaParamInt>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x38D8340 Offset: 0x38D8441 VA: 0x38D8340
	|-ReadOnlyCollection<Detail.DataStore.DataStoreMetaInfoInt>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x38D9450 Offset: 0x38D9551 VA: 0x38D9450
	|-ReadOnlyCollection<Detail.DataStore.DataStorePasswordInfoInt>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x38DA510 Offset: 0x38DA611 VA: 0x38DA510
	|-ReadOnlyCollection<Detail.DataStore.DataStorePersistenceInfoInt>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x38DB5E0 Offset: 0x38DB6E1 VA: 0x38DB5E0
	|-ReadOnlyCollection<Detail.DataStore.DataStorePreparePostParamInt>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x38DC650 Offset: 0x38DC751 VA: 0x38DC650
	|-ReadOnlyCollection<Detail.DataStore.DataStoreRateObjectParamInt>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x38DD6E0 Offset: 0x38DD7E1 VA: 0x38DD6E0
	|-ReadOnlyCollection<Detail.DataStore.DataStoreRatingInitParamInt>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x38DE700 Offset: 0x38DE801 VA: 0x38DE700
	|-ReadOnlyCollection<Detail.DataStore.DataStoreRatingTargetInt>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x38DF810 Offset: 0x38DF911 VA: 0x38DF810
	|-ReadOnlyCollection<Detail.Ranking.RankingCachedResultInt>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x38E0880 Offset: 0x38E0981 VA: 0x38E0880
	|-ReadOnlyCollection<Detail.Ranking.RankingOrderParamInt>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x38E1990 Offset: 0x38E1A91 VA: 0x38E1990
	|-ReadOnlyCollection<Detail.Ranking.RankingRankDataInt>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x38E2BA0 Offset: 0x38E2CA1 VA: 0x38E2BA0
	|-ReadOnlyCollection<Detail.Ranking2.Ranking2ChartInfoInt>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x38E3E30 Offset: 0x38E3F31 VA: 0x38E3E30
	|-ReadOnlyCollection<Detail.Ranking2.Ranking2RankDataInt>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x38E4EA0 Offset: 0x38E4FA1 VA: 0x38E4EA0
	|-ReadOnlyCollection<Detail.Ranking2.Ranking2ScoreDataInt>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x38E5F30 Offset: 0x38E6031 VA: 0x38E5F30
	|-ReadOnlyCollection<Detail.Screening.ScreeningContextInfoInt>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x38E70B0 Offset: 0x38E71B1 VA: 0x38E70B0
	|-ReadOnlyCollection<Detail.Subscriber.SubscriberContentInt>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x38E8240 Offset: 0x38E8341 VA: 0x38E8240
	|-ReadOnlyCollection<Detail.Subscriber.SubscriberGetContentParamInt>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x38E9340 Offset: 0x38E9441 VA: 0x38E9340
	|-ReadOnlyCollection<Detail.Subscriber.SubscriberUserStatusInfoInt>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x38EA420 Offset: 0x38EA521 VA: 0x38EA420
	|-ReadOnlyCollection<Detail.Subscriber.SubscriberUserStatusParamInt>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x38EB420 Offset: 0x38EB521 VA: 0x38EB420
	|-ReadOnlyCollection<Detail.Utility.IntegerSettings>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x38EC420 Offset: 0x38EC521 VA: 0x38EC420
	|-ReadOnlyCollection<Detail.Utility.UniqueIdInfoInt>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x38ED430 Offset: 0x38ED531 VA: 0x38ED430
	|-ReadOnlyCollection<MapHistory.Rewind.LatestInspectorData>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x38EE460 Offset: 0x38EE561 VA: 0x38EE460
	|-ReadOnlyCollection<MapHistory.Rewind.WorkTerrainData>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x38EF470 Offset: 0x38EF571 VA: 0x38EF470
	|-ReadOnlyCollection<MapSkill.AroundCalculator.Result>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x38F0540 Offset: 0x38F0641 VA: 0x38F0540
	|-ReadOnlyCollection<TargetPositionCache.CacheCurve.Item>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x2FE5AE0 Offset: 0x2FE5BE1 VA: 0x2FE5AE0
	|-ReadOnlyCollection<TargetPositionCache.CacheEntry.RecordingItem>.System.Collections.Generic.ICollection<T>.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private void System.Collections.Generic.IList<T>.Insert(int index, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3467920 Offset: 0x3467A21 VA: 0x3467920
	|-ReadOnlyCollection<IntervalTree.Entry<object>>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x3468940 Offset: 0x3468A41 VA: 0x3468940
	|-ReadOnlyCollection<KeyValuePair<DateTime, object>>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x3469930 Offset: 0x3469A31 VA: 0x3469930
	|-ReadOnlyCollection<KeyValuePair<int, object>>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x346A9C0 Offset: 0x346AAC1 VA: 0x346A9C0
	|-ReadOnlyCollection<KeyValuePair<object, ValueTuple<int, DateTime, object>>>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x346B9E0 Offset: 0x346BAE1 VA: 0x346B9E0
	|-ReadOnlyCollection<KeyValuePair<object, object>>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x346CA70 Offset: 0x346CB71 VA: 0x346CA70
	|-ReadOnlyCollection<CommonBattleSequence.Reliance<object>>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x346DA90 Offset: 0x346DB91 VA: 0x346DA90
	|-ReadOnlyCollection<RenderGraphResourcePool.ResourceLogInfo<object>>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x346EA80 Offset: 0x346EB81 VA: 0x346EA80
	|-ReadOnlyCollection<ValueTuple<int, object>>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x346FA50 Offset: 0x346FB51 VA: 0x346FA50
	|-ReadOnlyCollection<ValueTuple<Int32Enum, int>>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x3470AF0 Offset: 0x3470BF1 VA: 0x3470AF0
	|-ReadOnlyCollection<ValueTuple<object, ValueTuple<object, int>>>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x3471B10 Offset: 0x3471C11 VA: 0x3471B10
	|-ReadOnlyCollection<ValueTuple<object, int>>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x3472B20 Offset: 0x3472C21 VA: 0x3472B20
	|-ReadOnlyCollection<ValueTuple<Vector3, float>>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x3473B20 Offset: 0x3473C21 VA: 0x3473B20
	|-ReadOnlyCollection<ValueTuple<object, Int32Enum, int>>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x3474BB0 Offset: 0x3474CB1 VA: 0x3474BB0
	|-ReadOnlyCollection<ValueTuple<object, int, int, int>>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x3475BB0 Offset: 0x3475CB1 VA: 0x3475BB0
	|-ReadOnlyCollection<AnimatorClipInfo>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x3B229F0 Offset: 0x3B22AF1 VA: 0x3B229F0
	|-ReadOnlyCollection<AsyncOperationHandle>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x3B23AB0 Offset: 0x3B23BB1 VA: 0x3B23AB0
	|-ReadOnlyCollection<BoneWeight>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x3B24AB0 Offset: 0x3B24BB1 VA: 0x3B24AB0
	|-ReadOnlyCollection<bool>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x3B25AA0 Offset: 0x3B25BA1 VA: 0x3B25AA0
	|-ReadOnlyCollection<byte>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x3B26AA0 Offset: 0x3B26BA1 VA: 0x3B26AA0
	|-ReadOnlyCollection<CameraInfo>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x3B27A70 Offset: 0x3B27B71 VA: 0x3B27A70
	|-ReadOnlyCollection<char>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x3B28A90 Offset: 0x3B28B91 VA: 0x3B28A90
	|-ReadOnlyCollection<Color>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x3B29AB0 Offset: 0x3B29BB1 VA: 0x3B29AB0
	|-ReadOnlyCollection<Color32>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x3B2AAB0 Offset: 0x3B2ABB1 VA: 0x3B2AAB0
	|-ReadOnlyCollection<ConstraintSource>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x3B2BB40 Offset: 0x3B2BC41 VA: 0x3B2BB40
	|-ReadOnlyCollection<ContourVertex>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x3B2CC00 Offset: 0x3B2CD01 VA: 0x3B2CC00
	|-ReadOnlyCollection<CustomAttributeNamedArgument>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x3B2DC20 Offset: 0x3B2DD21 VA: 0x3B2DC20
	|-ReadOnlyCollection<CustomAttributeTypedArgument>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x3B2ECB0 Offset: 0x3B2EDB1 VA: 0x3B2ECB0
	|-ReadOnlyCollection<DataStoreRatingInfo>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x3B2FCB0 Offset: 0x3B2FDB1 VA: 0x3B2FCB0
	|-ReadOnlyCollection<DataStoreResult>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x3B30C90 Offset: 0x3B30D91 VA: 0x3B30C90
	|-ReadOnlyCollection<DateTime>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x3B31C90 Offset: 0x3B31D91 VA: 0x3B31C90
	|-ReadOnlyCollection<DateTimeOffset>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x3B32C80 Offset: 0x3B32D81 VA: 0x3B32C80
	|-ReadOnlyCollection<Decimal>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x3B33D50 Offset: 0x3B33E51 VA: 0x3B33D50
	|-ReadOnlyCollection<DiagnosticEvent>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x3B34D80 Offset: 0x3B34E81 VA: 0x3B34D80
	|-ReadOnlyCollection<double>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x3B35E70 Offset: 0x3B35F71 VA: 0x3B35E70
	|-ReadOnlyCollection<Friend>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x3B36EB0 Offset: 0x3B36FB1 VA: 0x3B36EB0
	|-ReadOnlyCollection<GlyphRect>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x3B37E80 Offset: 0x3B37F81 VA: 0x3B37E80
	|-ReadOnlyCollection<short>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x3B38E60 Offset: 0x3B38F61 VA: 0x3B38E60
	|-ReadOnlyCollection<int>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x3B39E40 Offset: 0x3B39F41 VA: 0x3B39E40
	|-ReadOnlyCollection<Int32Enum>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x3B3AE20 Offset: 0x3B3AF21 VA: 0x3B3AE20
	|-ReadOnlyCollection<long>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x3B3BE00 Offset: 0x3B3BF01 VA: 0x3B3BE00
	|-ReadOnlyCollection<IntPtr>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x3B3CE00 Offset: 0x3B3CF01 VA: 0x3B3CE00
	|-ReadOnlyCollection<InterpretedFrameInfo>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x3B3DE90 Offset: 0x3B3DF91 VA: 0x3B3DE90
	|-ReadOnlyCollection<IntervalTreeNode>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x3B3EE90 Offset: 0x3B3EF91 VA: 0x3B3EE90
	|-ReadOnlyCollection<LengthLimitProperties>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x3B3FE70 Offset: 0x3B3FF71 VA: 0x3B3FE70
	|-ReadOnlyCollection<MapPos>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x3B40F90 Offset: 0x3B41091 VA: 0x3B40F90
	|-ReadOnlyCollection<Matrix4x4>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x3B41FE0 Offset: 0x3B420E1 VA: 0x3B41FE0
	|-ReadOnlyCollection<object>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x3B42FD0 Offset: 0x3B430D1 VA: 0x3B42FD0
	|-ReadOnlyCollection<ObjectInitializationData>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x3B440C0 Offset: 0x3B441C1 VA: 0x3B440C0
	|-ReadOnlyCollection<PlayableBinding>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x3B451C0 Offset: 0x3B452C1 VA: 0x3B451C0
	|-ReadOnlyCollection<PlayerLoopSystem>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x3B462E0 Offset: 0x3B463E1 VA: 0x3B462E0
	|-ReadOnlyCollection<PlayerLoopSystemInternal>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x3B47320 Offset: 0x3B47421 VA: 0x3B47320
	|-ReadOnlyCollection<RangePositionInfo>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x3B482F0 Offset: 0x3B483F1 VA: 0x3B482F0
	|-ReadOnlyCollection<Ranking2ChartInfoInput>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x3B493F0 Offset: 0x3B494F1 VA: 0x3B493F0
	|-ReadOnlyCollection<RaycastHit2D>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x3B4A5B0 Offset: 0x3B4A6B1 VA: 0x3B4A5B0
	|-ReadOnlyCollection<RaycastResult>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x3B4B6C0 Offset: 0x3B4B7C1 VA: 0x3B4B6C0
	|-ReadOnlyCollection<Rect>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x3B4C6A0 Offset: 0x3B4C7A1 VA: 0x3B4C6A0
	|-ReadOnlyCollection<RendererListHandle>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x3B4D680 Offset: 0x3B4D781 VA: 0x3B4D680
	|-ReadOnlyCollection<ResourceHandle>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x3AAED40 Offset: 0x3AAEE41 VA: 0x3AAED40
	|-ReadOnlyCollection<sbyte>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x3AAFD60 Offset: 0x3AAFE61 VA: 0x3AAFD60
	|-ReadOnlyCollection<ShaderTagId>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x3AB0D40 Offset: 0x3AB0E41 VA: 0x3AB0D40
	|-ReadOnlyCollection<float>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x3AB1F60 Offset: 0x3AB2061 VA: 0x3AB1F60
	|-ReadOnlyCollection<SphericalHarmonicsL2>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x3AB3210 Offset: 0x3AB3311 VA: 0x3AB3210
	|-ReadOnlyCollection<SubMeshDescriptor>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x3AB4260 Offset: 0x3AB4361 VA: 0x3AB4260
	|-ReadOnlyCollection<TablePair>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x3AB5230 Offset: 0x3AB5331 VA: 0x3AB5230
	|-ReadOnlyCollection<TimeSpan>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x3AB6250 Offset: 0x3AB6351 VA: 0x3AB6250
	|-ReadOnlyCollection<UICharInfo>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x3AB7250 Offset: 0x3AB7351 VA: 0x3AB7250
	|-ReadOnlyCollection<UILineInfo>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x3AB8460 Offset: 0x3AB8561 VA: 0x3AB8460
	|-ReadOnlyCollection<UIVertex>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x3AB9610 Offset: 0x3AB9711 VA: 0x3AB9610
	|-ReadOnlyCollection<ushort>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x3ABA5F0 Offset: 0x3ABA6F1 VA: 0x3ABA5F0
	|-ReadOnlyCollection<uint>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x3ABB5D0 Offset: 0x3ABB6D1 VA: 0x3ABB5D0
	|-ReadOnlyCollection<ulong>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x3ABC5D0 Offset: 0x3ABC6D1 VA: 0x3ABC5D0
	|-ReadOnlyCollection<Vector2>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x3ABD5F0 Offset: 0x3ABD6F1 VA: 0x3ABD5F0
	|-ReadOnlyCollection<Vector3>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x3ABE610 Offset: 0x3ABE711 VA: 0x3ABE610
	|-ReadOnlyCollection<Vector4>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x3ABF610 Offset: 0x3ABF711 VA: 0x3ABF610
	|-ReadOnlyCollection<VertexAttributeDescriptor>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x3AC0600 Offset: 0x3AC0701 VA: 0x3AC0600
	|-ReadOnlyCollection<X509ChainStatus>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x3AC16A0 Offset: 0x3AC17A1 VA: 0x3AC16A0
	|-ReadOnlyCollection<XRView>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x3AC2730 Offset: 0x3AC2831 VA: 0x3AC2730
	|-ReadOnlyCollection<AICrossfire.PositionTable>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x3AC3740 Offset: 0x3AC3841 VA: 0x3AC3740
	|-ReadOnlyCollection<AmiiboSequence.GainItemData>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x3AC4810 Offset: 0x3AC4911 VA: 0x3AC4810
	|-ReadOnlyCollection<AnimationOutputWeightProcessor.WeightInfo>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x3AC5850 Offset: 0x3AC5951 VA: 0x3AC5850
	|-ReadOnlyCollection<ArenaOrderSequence.GodInfo>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x3AC6840 Offset: 0x3AC6941 VA: 0x3AC6840
	|-ReadOnlyCollection<BattleInfo.SupportData>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x3AC7830 Offset: 0x3AC7931 VA: 0x3AC7830
	|-ReadOnlyCollection<BeforeRenderHelper.OrderBlock>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x3AC88C0 Offset: 0x3AC89C1 VA: 0x3AC88C0
	|-ReadOnlyCollection<Camera.RenderRequest>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x3AC98E0 Offset: 0x3AC99E1 VA: 0x3AC98E0
	|-ReadOnlyCollection<CameraState.CustomBlendable>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x3ACA8B0 Offset: 0x3ACA9B1 VA: 0x3ACA8B0
	|-ReadOnlyCollection<CinemachineClearShot.Pair>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x3ACB890 Offset: 0x3ACB991 VA: 0x3ACB890
	|-ReadOnlyCollection<CinemachineStateDrivenCamera.HashPair>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x3ACC930 Offset: 0x3ACCA31 VA: 0x3ACC930
	|-ReadOnlyCollection<DelayedActionManager.DelegateInfo>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x3ACDA30 Offset: 0x3ACDB31 VA: 0x3ACDA30
	|-ReadOnlyCollection<Detail.AsyncResultInt>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x3ACEA80 Offset: 0x3ACEB81 VA: 0x3ACEA80
	|-ReadOnlyCollection<Detail.CppArray>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x3ACFB50 Offset: 0x3ACFC51 VA: 0x3ACFB50
	|-ReadOnlyCollection<Detail.NotificationEventInt>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x3AD0BA0 Offset: 0x3AD0CA1 VA: 0x3AD0BA0
	|-ReadOnlyCollection<DragonRideTargetGroup.ChainParam>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x3AD1C30 Offset: 0x3AD1D31 VA: 0x3AD1C30
	|-ReadOnlyCollection<GmapPathAdjuster.TargetModel>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x3AD2CF0 Offset: 0x3AD2DF1 VA: 0x3AD2CF0
	|-ReadOnlyCollection<GmapSpotAdjuster.TargetModel>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x3AD3DB0 Offset: 0x3AD3EB1 VA: 0x3AD3DB0
	|-ReadOnlyCollection<HubFastTravel.Location>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x3AD4EB0 Offset: 0x3AD4FB1 VA: 0x3AD4EB0
	|-ReadOnlyCollection<HubLensFlare.Flare>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x3AD5F00 Offset: 0x3AD6001 VA: 0x3AD5F00
	|-ReadOnlyCollection<InventoryPoolItemMenuContent.KindBgNameClass>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x3AD6ED0 Offset: 0x3AD6FD1 VA: 0x3AD6ED0
	|-ReadOnlyCollection<Map.Pos>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x3AD7ED0 Offset: 0x3AD7FD1 VA: 0x3AD7ED0
	|-ReadOnlyCollection<MapImage.BackupTerrain>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x3AD8EE0 Offset: 0x3AD8FE1 VA: 0x3AD8EE0
	|-ReadOnlyCollection<MapImageRange.Pos>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x3AD9F80 Offset: 0x3ADA081 VA: 0x3AD9F80
	|-ReadOnlyCollection<MapMind.Target>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x38C4960 Offset: 0x38C4A61 VA: 0x38C4960
	|-ReadOnlyCollection<MapPanelDebug.Entity>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x38C5960 Offset: 0x38C5A61 VA: 0x38C5960
	|-ReadOnlyCollection<NexRanking.Data>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x38C6960 Offset: 0x38C6A61 VA: 0x38C6960
	|-ReadOnlyCollection<NexVersus.RatingData>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x38C7950 Offset: 0x38C7A51 VA: 0x38C7950
	|-ReadOnlyCollection<PackedPlayModeBuildLogs.RuntimeBuildLog>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x38C89F0 Offset: 0x38C8AF1 VA: 0x38C89F0
	|-ReadOnlyCollection<ParticleSystem.Particle>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x38C9A40 Offset: 0x38C9B41 VA: 0x38C9A40
	|-ReadOnlyCollection<RangeData.Offset>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x38CAAE0 Offset: 0x38CABE1 VA: 0x38CAAE0
	|-ReadOnlyCollection<RenderGraphDebugData.PassDebugData>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x38CBBE0 Offset: 0x38CBCE1 VA: 0x38CBBE0
	|-ReadOnlyCollection<RenderGraphDebugData.ResourceDebugData>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x38CCC20 Offset: 0x38CCD21 VA: 0x38CCC20
	|-ReadOnlyCollection<RingCleaningUnitSelectMenu.GodParam>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x38CDCF0 Offset: 0x38CDDF1 VA: 0x38CDCF0
	|-ReadOnlyCollection<ShadowUtility.Edge>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x38CED60 Offset: 0x38CEE61 VA: 0x38CED60
	|-ReadOnlyCollection<SkillArray.Entity>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x38CFE80 Offset: 0x38CFF81 VA: 0x38CFE80
	|-ReadOnlyCollection<TexturePacker_JsonArray.Frame>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x38D0F90 Offset: 0x38D1091 VA: 0x38D0F90
	|-ReadOnlyCollection<TimeNotificationBehaviour.NotificationEntry>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x38D2050 Offset: 0x38D2151 VA: 0x38D2050
	|-ReadOnlyCollection<UnitySynchronizationContext.WorkRequest>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x38D3070 Offset: 0x38D3171 VA: 0x38D3070
	|-ReadOnlyCollection<XmlSchemaObjectTable.XmlSchemaObjectEntry>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x38D4060 Offset: 0x38D4161 VA: 0x38D4060
	|-ReadOnlyCollection<AssetBundleBuildMap.AssetBundleEntry.AssetPathString>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x38D5120 Offset: 0x38D5221 VA: 0x38D5120
	|-ReadOnlyCollection<Detail.DataStore.DataStoreChangeMetaParamInt>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x38D6190 Offset: 0x38D6291 VA: 0x38D6190
	|-ReadOnlyCollection<Detail.DataStore.DataStoreDeleteParamInt>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x38D7260 Offset: 0x38D7361 VA: 0x38D7260
	|-ReadOnlyCollection<Detail.DataStore.DataStoreGetMetaParamInt>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x38D8350 Offset: 0x38D8451 VA: 0x38D8350
	|-ReadOnlyCollection<Detail.DataStore.DataStoreMetaInfoInt>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x38D9460 Offset: 0x38D9561 VA: 0x38D9460
	|-ReadOnlyCollection<Detail.DataStore.DataStorePasswordInfoInt>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x38DA520 Offset: 0x38DA621 VA: 0x38DA520
	|-ReadOnlyCollection<Detail.DataStore.DataStorePersistenceInfoInt>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x38DB5F0 Offset: 0x38DB6F1 VA: 0x38DB5F0
	|-ReadOnlyCollection<Detail.DataStore.DataStorePreparePostParamInt>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x38DC660 Offset: 0x38DC761 VA: 0x38DC660
	|-ReadOnlyCollection<Detail.DataStore.DataStoreRateObjectParamInt>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x38DD6F0 Offset: 0x38DD7F1 VA: 0x38DD6F0
	|-ReadOnlyCollection<Detail.DataStore.DataStoreRatingInitParamInt>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x38DE710 Offset: 0x38DE811 VA: 0x38DE710
	|-ReadOnlyCollection<Detail.DataStore.DataStoreRatingTargetInt>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x38DF820 Offset: 0x38DF921 VA: 0x38DF820
	|-ReadOnlyCollection<Detail.Ranking.RankingCachedResultInt>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x38E0890 Offset: 0x38E0991 VA: 0x38E0890
	|-ReadOnlyCollection<Detail.Ranking.RankingOrderParamInt>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x38E19A0 Offset: 0x38E1AA1 VA: 0x38E19A0
	|-ReadOnlyCollection<Detail.Ranking.RankingRankDataInt>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x38E2BB0 Offset: 0x38E2CB1 VA: 0x38E2BB0
	|-ReadOnlyCollection<Detail.Ranking2.Ranking2ChartInfoInt>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x38E3E40 Offset: 0x38E3F41 VA: 0x38E3E40
	|-ReadOnlyCollection<Detail.Ranking2.Ranking2RankDataInt>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x38E4EB0 Offset: 0x38E4FB1 VA: 0x38E4EB0
	|-ReadOnlyCollection<Detail.Ranking2.Ranking2ScoreDataInt>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x38E5F40 Offset: 0x38E6041 VA: 0x38E5F40
	|-ReadOnlyCollection<Detail.Screening.ScreeningContextInfoInt>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x38E70C0 Offset: 0x38E71C1 VA: 0x38E70C0
	|-ReadOnlyCollection<Detail.Subscriber.SubscriberContentInt>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x38E8250 Offset: 0x38E8351 VA: 0x38E8250
	|-ReadOnlyCollection<Detail.Subscriber.SubscriberGetContentParamInt>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x38E9350 Offset: 0x38E9451 VA: 0x38E9350
	|-ReadOnlyCollection<Detail.Subscriber.SubscriberUserStatusInfoInt>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x38EA430 Offset: 0x38EA531 VA: 0x38EA430
	|-ReadOnlyCollection<Detail.Subscriber.SubscriberUserStatusParamInt>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x38EB430 Offset: 0x38EB531 VA: 0x38EB430
	|-ReadOnlyCollection<Detail.Utility.IntegerSettings>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x38EC430 Offset: 0x38EC531 VA: 0x38EC430
	|-ReadOnlyCollection<Detail.Utility.UniqueIdInfoInt>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x38ED440 Offset: 0x38ED541 VA: 0x38ED440
	|-ReadOnlyCollection<MapHistory.Rewind.LatestInspectorData>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x38EE470 Offset: 0x38EE571 VA: 0x38EE470
	|-ReadOnlyCollection<MapHistory.Rewind.WorkTerrainData>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x38EF480 Offset: 0x38EF581 VA: 0x38EF480
	|-ReadOnlyCollection<MapSkill.AroundCalculator.Result>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x38F0550 Offset: 0x38F0651 VA: 0x38F0550
	|-ReadOnlyCollection<TargetPositionCache.CacheCurve.Item>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x2FE5AF0 Offset: 0x2FE5BF1 VA: 0x2FE5AF0
	|-ReadOnlyCollection<TargetPositionCache.CacheEntry.RecordingItem>.System.Collections.Generic.IList<T>.Insert
	*/

	// RVA: -1 Offset: -1 Slot: 15
	private bool System.Collections.Generic.ICollection<T>.Remove(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3467930 Offset: 0x3467A31 VA: 0x3467930
	|-ReadOnlyCollection<IntervalTree.Entry<object>>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x3468950 Offset: 0x3468A51 VA: 0x3468950
	|-ReadOnlyCollection<KeyValuePair<DateTime, object>>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x3469940 Offset: 0x3469A41 VA: 0x3469940
	|-ReadOnlyCollection<KeyValuePair<int, object>>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x346A9D0 Offset: 0x346AAD1 VA: 0x346A9D0
	|-ReadOnlyCollection<KeyValuePair<object, ValueTuple<int, DateTime, object>>>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x346B9F0 Offset: 0x346BAF1 VA: 0x346B9F0
	|-ReadOnlyCollection<KeyValuePair<object, object>>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x346CA80 Offset: 0x346CB81 VA: 0x346CA80
	|-ReadOnlyCollection<CommonBattleSequence.Reliance<object>>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x346DAA0 Offset: 0x346DBA1 VA: 0x346DAA0
	|-ReadOnlyCollection<RenderGraphResourcePool.ResourceLogInfo<object>>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x346EA90 Offset: 0x346EB91 VA: 0x346EA90
	|-ReadOnlyCollection<ValueTuple<int, object>>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x346FA60 Offset: 0x346FB61 VA: 0x346FA60
	|-ReadOnlyCollection<ValueTuple<Int32Enum, int>>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x3470B00 Offset: 0x3470C01 VA: 0x3470B00
	|-ReadOnlyCollection<ValueTuple<object, ValueTuple<object, int>>>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x3471B20 Offset: 0x3471C21 VA: 0x3471B20
	|-ReadOnlyCollection<ValueTuple<object, int>>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x3472B30 Offset: 0x3472C31 VA: 0x3472B30
	|-ReadOnlyCollection<ValueTuple<Vector3, float>>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x3473B30 Offset: 0x3473C31 VA: 0x3473B30
	|-ReadOnlyCollection<ValueTuple<object, Int32Enum, int>>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x3474BC0 Offset: 0x3474CC1 VA: 0x3474BC0
	|-ReadOnlyCollection<ValueTuple<object, int, int, int>>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x3475BC0 Offset: 0x3475CC1 VA: 0x3475BC0
	|-ReadOnlyCollection<AnimatorClipInfo>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x3B22A00 Offset: 0x3B22B01 VA: 0x3B22A00
	|-ReadOnlyCollection<AsyncOperationHandle>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x3B23AC0 Offset: 0x3B23BC1 VA: 0x3B23AC0
	|-ReadOnlyCollection<BoneWeight>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x3B24AC0 Offset: 0x3B24BC1 VA: 0x3B24AC0
	|-ReadOnlyCollection<bool>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x3B25AB0 Offset: 0x3B25BB1 VA: 0x3B25AB0
	|-ReadOnlyCollection<byte>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x3B26AB0 Offset: 0x3B26BB1 VA: 0x3B26AB0
	|-ReadOnlyCollection<CameraInfo>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x3B27A80 Offset: 0x3B27B81 VA: 0x3B27A80
	|-ReadOnlyCollection<char>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x3B28AA0 Offset: 0x3B28BA1 VA: 0x3B28AA0
	|-ReadOnlyCollection<Color>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x3B29AC0 Offset: 0x3B29BC1 VA: 0x3B29AC0
	|-ReadOnlyCollection<Color32>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x3B2AAC0 Offset: 0x3B2ABC1 VA: 0x3B2AAC0
	|-ReadOnlyCollection<ConstraintSource>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x3B2BB50 Offset: 0x3B2BC51 VA: 0x3B2BB50
	|-ReadOnlyCollection<ContourVertex>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x3B2CC10 Offset: 0x3B2CD11 VA: 0x3B2CC10
	|-ReadOnlyCollection<CustomAttributeNamedArgument>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x3B2DC30 Offset: 0x3B2DD31 VA: 0x3B2DC30
	|-ReadOnlyCollection<CustomAttributeTypedArgument>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x3B2ECC0 Offset: 0x3B2EDC1 VA: 0x3B2ECC0
	|-ReadOnlyCollection<DataStoreRatingInfo>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x3B2FCC0 Offset: 0x3B2FDC1 VA: 0x3B2FCC0
	|-ReadOnlyCollection<DataStoreResult>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x3B30CA0 Offset: 0x3B30DA1 VA: 0x3B30CA0
	|-ReadOnlyCollection<DateTime>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x3B31CA0 Offset: 0x3B31DA1 VA: 0x3B31CA0
	|-ReadOnlyCollection<DateTimeOffset>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x3B32C90 Offset: 0x3B32D91 VA: 0x3B32C90
	|-ReadOnlyCollection<Decimal>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x3B33D60 Offset: 0x3B33E61 VA: 0x3B33D60
	|-ReadOnlyCollection<DiagnosticEvent>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x3B34D90 Offset: 0x3B34E91 VA: 0x3B34D90
	|-ReadOnlyCollection<double>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x3B35E80 Offset: 0x3B35F81 VA: 0x3B35E80
	|-ReadOnlyCollection<Friend>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x3B36EC0 Offset: 0x3B36FC1 VA: 0x3B36EC0
	|-ReadOnlyCollection<GlyphRect>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x3B37E90 Offset: 0x3B37F91 VA: 0x3B37E90
	|-ReadOnlyCollection<short>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x3B38E70 Offset: 0x3B38F71 VA: 0x3B38E70
	|-ReadOnlyCollection<int>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x3B39E50 Offset: 0x3B39F51 VA: 0x3B39E50
	|-ReadOnlyCollection<Int32Enum>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x3B3AE30 Offset: 0x3B3AF31 VA: 0x3B3AE30
	|-ReadOnlyCollection<long>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x3B3BE10 Offset: 0x3B3BF11 VA: 0x3B3BE10
	|-ReadOnlyCollection<IntPtr>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x3B3CE10 Offset: 0x3B3CF11 VA: 0x3B3CE10
	|-ReadOnlyCollection<InterpretedFrameInfo>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x3B3DEA0 Offset: 0x3B3DFA1 VA: 0x3B3DEA0
	|-ReadOnlyCollection<IntervalTreeNode>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x3B3EEA0 Offset: 0x3B3EFA1 VA: 0x3B3EEA0
	|-ReadOnlyCollection<LengthLimitProperties>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x3B3FE80 Offset: 0x3B3FF81 VA: 0x3B3FE80
	|-ReadOnlyCollection<MapPos>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x3B40FA0 Offset: 0x3B410A1 VA: 0x3B40FA0
	|-ReadOnlyCollection<Matrix4x4>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x3B41FF0 Offset: 0x3B420F1 VA: 0x3B41FF0
	|-ReadOnlyCollection<object>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x3B42FE0 Offset: 0x3B430E1 VA: 0x3B42FE0
	|-ReadOnlyCollection<ObjectInitializationData>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x3B440D0 Offset: 0x3B441D1 VA: 0x3B440D0
	|-ReadOnlyCollection<PlayableBinding>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x3B451D0 Offset: 0x3B452D1 VA: 0x3B451D0
	|-ReadOnlyCollection<PlayerLoopSystem>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x3B462F0 Offset: 0x3B463F1 VA: 0x3B462F0
	|-ReadOnlyCollection<PlayerLoopSystemInternal>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x3B47330 Offset: 0x3B47431 VA: 0x3B47330
	|-ReadOnlyCollection<RangePositionInfo>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x3B48300 Offset: 0x3B48401 VA: 0x3B48300
	|-ReadOnlyCollection<Ranking2ChartInfoInput>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x3B49400 Offset: 0x3B49501 VA: 0x3B49400
	|-ReadOnlyCollection<RaycastHit2D>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x3B4A5C0 Offset: 0x3B4A6C1 VA: 0x3B4A5C0
	|-ReadOnlyCollection<RaycastResult>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x3B4B6D0 Offset: 0x3B4B7D1 VA: 0x3B4B6D0
	|-ReadOnlyCollection<Rect>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x3B4C6B0 Offset: 0x3B4C7B1 VA: 0x3B4C6B0
	|-ReadOnlyCollection<RendererListHandle>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x3B4D690 Offset: 0x3B4D791 VA: 0x3B4D690
	|-ReadOnlyCollection<ResourceHandle>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x3AAED50 Offset: 0x3AAEE51 VA: 0x3AAED50
	|-ReadOnlyCollection<sbyte>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x3AAFD70 Offset: 0x3AAFE71 VA: 0x3AAFD70
	|-ReadOnlyCollection<ShaderTagId>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x3AB0D50 Offset: 0x3AB0E51 VA: 0x3AB0D50
	|-ReadOnlyCollection<float>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x3AB1F70 Offset: 0x3AB2071 VA: 0x3AB1F70
	|-ReadOnlyCollection<SphericalHarmonicsL2>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x3AB3220 Offset: 0x3AB3321 VA: 0x3AB3220
	|-ReadOnlyCollection<SubMeshDescriptor>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x3AB4270 Offset: 0x3AB4371 VA: 0x3AB4270
	|-ReadOnlyCollection<TablePair>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x3AB5240 Offset: 0x3AB5341 VA: 0x3AB5240
	|-ReadOnlyCollection<TimeSpan>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x3AB6260 Offset: 0x3AB6361 VA: 0x3AB6260
	|-ReadOnlyCollection<UICharInfo>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x3AB7260 Offset: 0x3AB7361 VA: 0x3AB7260
	|-ReadOnlyCollection<UILineInfo>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x3AB8470 Offset: 0x3AB8571 VA: 0x3AB8470
	|-ReadOnlyCollection<UIVertex>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x3AB9620 Offset: 0x3AB9721 VA: 0x3AB9620
	|-ReadOnlyCollection<ushort>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x3ABA600 Offset: 0x3ABA701 VA: 0x3ABA600
	|-ReadOnlyCollection<uint>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x3ABB5E0 Offset: 0x3ABB6E1 VA: 0x3ABB5E0
	|-ReadOnlyCollection<ulong>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x3ABC5E0 Offset: 0x3ABC6E1 VA: 0x3ABC5E0
	|-ReadOnlyCollection<Vector2>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x3ABD600 Offset: 0x3ABD701 VA: 0x3ABD600
	|-ReadOnlyCollection<Vector3>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x3ABE620 Offset: 0x3ABE721 VA: 0x3ABE620
	|-ReadOnlyCollection<Vector4>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x3ABF620 Offset: 0x3ABF721 VA: 0x3ABF620
	|-ReadOnlyCollection<VertexAttributeDescriptor>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x3AC0610 Offset: 0x3AC0711 VA: 0x3AC0610
	|-ReadOnlyCollection<X509ChainStatus>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x3AC16B0 Offset: 0x3AC17B1 VA: 0x3AC16B0
	|-ReadOnlyCollection<XRView>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x3AC2740 Offset: 0x3AC2841 VA: 0x3AC2740
	|-ReadOnlyCollection<AICrossfire.PositionTable>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x3AC3750 Offset: 0x3AC3851 VA: 0x3AC3750
	|-ReadOnlyCollection<AmiiboSequence.GainItemData>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x3AC4820 Offset: 0x3AC4921 VA: 0x3AC4820
	|-ReadOnlyCollection<AnimationOutputWeightProcessor.WeightInfo>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x3AC5860 Offset: 0x3AC5961 VA: 0x3AC5860
	|-ReadOnlyCollection<ArenaOrderSequence.GodInfo>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x3AC6850 Offset: 0x3AC6951 VA: 0x3AC6850
	|-ReadOnlyCollection<BattleInfo.SupportData>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x3AC7840 Offset: 0x3AC7941 VA: 0x3AC7840
	|-ReadOnlyCollection<BeforeRenderHelper.OrderBlock>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x3AC88D0 Offset: 0x3AC89D1 VA: 0x3AC88D0
	|-ReadOnlyCollection<Camera.RenderRequest>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x3AC98F0 Offset: 0x3AC99F1 VA: 0x3AC98F0
	|-ReadOnlyCollection<CameraState.CustomBlendable>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x3ACA8C0 Offset: 0x3ACA9C1 VA: 0x3ACA8C0
	|-ReadOnlyCollection<CinemachineClearShot.Pair>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x3ACB8A0 Offset: 0x3ACB9A1 VA: 0x3ACB8A0
	|-ReadOnlyCollection<CinemachineStateDrivenCamera.HashPair>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x3ACC940 Offset: 0x3ACCA41 VA: 0x3ACC940
	|-ReadOnlyCollection<DelayedActionManager.DelegateInfo>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x3ACDA40 Offset: 0x3ACDB41 VA: 0x3ACDA40
	|-ReadOnlyCollection<Detail.AsyncResultInt>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x3ACEA90 Offset: 0x3ACEB91 VA: 0x3ACEA90
	|-ReadOnlyCollection<Detail.CppArray>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x3ACFB60 Offset: 0x3ACFC61 VA: 0x3ACFB60
	|-ReadOnlyCollection<Detail.NotificationEventInt>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x3AD0BB0 Offset: 0x3AD0CB1 VA: 0x3AD0BB0
	|-ReadOnlyCollection<DragonRideTargetGroup.ChainParam>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x3AD1C40 Offset: 0x3AD1D41 VA: 0x3AD1C40
	|-ReadOnlyCollection<GmapPathAdjuster.TargetModel>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x3AD2D00 Offset: 0x3AD2E01 VA: 0x3AD2D00
	|-ReadOnlyCollection<GmapSpotAdjuster.TargetModel>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x3AD3DC0 Offset: 0x3AD3EC1 VA: 0x3AD3DC0
	|-ReadOnlyCollection<HubFastTravel.Location>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x3AD4EC0 Offset: 0x3AD4FC1 VA: 0x3AD4EC0
	|-ReadOnlyCollection<HubLensFlare.Flare>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x3AD5F10 Offset: 0x3AD6011 VA: 0x3AD5F10
	|-ReadOnlyCollection<InventoryPoolItemMenuContent.KindBgNameClass>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x3AD6EE0 Offset: 0x3AD6FE1 VA: 0x3AD6EE0
	|-ReadOnlyCollection<Map.Pos>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x3AD7EE0 Offset: 0x3AD7FE1 VA: 0x3AD7EE0
	|-ReadOnlyCollection<MapImage.BackupTerrain>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x3AD8EF0 Offset: 0x3AD8FF1 VA: 0x3AD8EF0
	|-ReadOnlyCollection<MapImageRange.Pos>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x3AD9F90 Offset: 0x3ADA091 VA: 0x3AD9F90
	|-ReadOnlyCollection<MapMind.Target>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x38C4970 Offset: 0x38C4A71 VA: 0x38C4970
	|-ReadOnlyCollection<MapPanelDebug.Entity>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x38C5970 Offset: 0x38C5A71 VA: 0x38C5970
	|-ReadOnlyCollection<NexRanking.Data>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x38C6970 Offset: 0x38C6A71 VA: 0x38C6970
	|-ReadOnlyCollection<NexVersus.RatingData>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x38C7960 Offset: 0x38C7A61 VA: 0x38C7960
	|-ReadOnlyCollection<PackedPlayModeBuildLogs.RuntimeBuildLog>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x38C8A00 Offset: 0x38C8B01 VA: 0x38C8A00
	|-ReadOnlyCollection<ParticleSystem.Particle>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x38C9A50 Offset: 0x38C9B51 VA: 0x38C9A50
	|-ReadOnlyCollection<RangeData.Offset>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x38CAAF0 Offset: 0x38CABF1 VA: 0x38CAAF0
	|-ReadOnlyCollection<RenderGraphDebugData.PassDebugData>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x38CBBF0 Offset: 0x38CBCF1 VA: 0x38CBBF0
	|-ReadOnlyCollection<RenderGraphDebugData.ResourceDebugData>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x38CCC30 Offset: 0x38CCD31 VA: 0x38CCC30
	|-ReadOnlyCollection<RingCleaningUnitSelectMenu.GodParam>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x38CDD00 Offset: 0x38CDE01 VA: 0x38CDD00
	|-ReadOnlyCollection<ShadowUtility.Edge>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x38CED70 Offset: 0x38CEE71 VA: 0x38CED70
	|-ReadOnlyCollection<SkillArray.Entity>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x38CFE90 Offset: 0x38CFF91 VA: 0x38CFE90
	|-ReadOnlyCollection<TexturePacker_JsonArray.Frame>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x38D0FA0 Offset: 0x38D10A1 VA: 0x38D0FA0
	|-ReadOnlyCollection<TimeNotificationBehaviour.NotificationEntry>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x38D2060 Offset: 0x38D2161 VA: 0x38D2060
	|-ReadOnlyCollection<UnitySynchronizationContext.WorkRequest>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x38D3080 Offset: 0x38D3181 VA: 0x38D3080
	|-ReadOnlyCollection<XmlSchemaObjectTable.XmlSchemaObjectEntry>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x38D4070 Offset: 0x38D4171 VA: 0x38D4070
	|-ReadOnlyCollection<AssetBundleBuildMap.AssetBundleEntry.AssetPathString>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x38D5130 Offset: 0x38D5231 VA: 0x38D5130
	|-ReadOnlyCollection<Detail.DataStore.DataStoreChangeMetaParamInt>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x38D61A0 Offset: 0x38D62A1 VA: 0x38D61A0
	|-ReadOnlyCollection<Detail.DataStore.DataStoreDeleteParamInt>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x38D7270 Offset: 0x38D7371 VA: 0x38D7270
	|-ReadOnlyCollection<Detail.DataStore.DataStoreGetMetaParamInt>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x38D8360 Offset: 0x38D8461 VA: 0x38D8360
	|-ReadOnlyCollection<Detail.DataStore.DataStoreMetaInfoInt>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x38D9470 Offset: 0x38D9571 VA: 0x38D9470
	|-ReadOnlyCollection<Detail.DataStore.DataStorePasswordInfoInt>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x38DA530 Offset: 0x38DA631 VA: 0x38DA530
	|-ReadOnlyCollection<Detail.DataStore.DataStorePersistenceInfoInt>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x38DB600 Offset: 0x38DB701 VA: 0x38DB600
	|-ReadOnlyCollection<Detail.DataStore.DataStorePreparePostParamInt>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x38DC670 Offset: 0x38DC771 VA: 0x38DC670
	|-ReadOnlyCollection<Detail.DataStore.DataStoreRateObjectParamInt>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x38DD700 Offset: 0x38DD801 VA: 0x38DD700
	|-ReadOnlyCollection<Detail.DataStore.DataStoreRatingInitParamInt>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x38DE720 Offset: 0x38DE821 VA: 0x38DE720
	|-ReadOnlyCollection<Detail.DataStore.DataStoreRatingTargetInt>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x38DF830 Offset: 0x38DF931 VA: 0x38DF830
	|-ReadOnlyCollection<Detail.Ranking.RankingCachedResultInt>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x38E08A0 Offset: 0x38E09A1 VA: 0x38E08A0
	|-ReadOnlyCollection<Detail.Ranking.RankingOrderParamInt>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x38E19B0 Offset: 0x38E1AB1 VA: 0x38E19B0
	|-ReadOnlyCollection<Detail.Ranking.RankingRankDataInt>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x38E2BC0 Offset: 0x38E2CC1 VA: 0x38E2BC0
	|-ReadOnlyCollection<Detail.Ranking2.Ranking2ChartInfoInt>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x38E3E50 Offset: 0x38E3F51 VA: 0x38E3E50
	|-ReadOnlyCollection<Detail.Ranking2.Ranking2RankDataInt>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x38E4EC0 Offset: 0x38E4FC1 VA: 0x38E4EC0
	|-ReadOnlyCollection<Detail.Ranking2.Ranking2ScoreDataInt>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x38E5F50 Offset: 0x38E6051 VA: 0x38E5F50
	|-ReadOnlyCollection<Detail.Screening.ScreeningContextInfoInt>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x38E70D0 Offset: 0x38E71D1 VA: 0x38E70D0
	|-ReadOnlyCollection<Detail.Subscriber.SubscriberContentInt>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x38E8260 Offset: 0x38E8361 VA: 0x38E8260
	|-ReadOnlyCollection<Detail.Subscriber.SubscriberGetContentParamInt>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x38E9360 Offset: 0x38E9461 VA: 0x38E9360
	|-ReadOnlyCollection<Detail.Subscriber.SubscriberUserStatusInfoInt>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x38EA440 Offset: 0x38EA541 VA: 0x38EA440
	|-ReadOnlyCollection<Detail.Subscriber.SubscriberUserStatusParamInt>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x38EB440 Offset: 0x38EB541 VA: 0x38EB440
	|-ReadOnlyCollection<Detail.Utility.IntegerSettings>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x38EC440 Offset: 0x38EC541 VA: 0x38EC440
	|-ReadOnlyCollection<Detail.Utility.UniqueIdInfoInt>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x38ED450 Offset: 0x38ED551 VA: 0x38ED450
	|-ReadOnlyCollection<MapHistory.Rewind.LatestInspectorData>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x38EE480 Offset: 0x38EE581 VA: 0x38EE480
	|-ReadOnlyCollection<MapHistory.Rewind.WorkTerrainData>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x38EF490 Offset: 0x38EF591 VA: 0x38EF490
	|-ReadOnlyCollection<MapSkill.AroundCalculator.Result>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x38F0560 Offset: 0x38F0661 VA: 0x38F0560
	|-ReadOnlyCollection<TargetPositionCache.CacheCurve.Item>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x2FE5B00 Offset: 0x2FE5C01 VA: 0x2FE5B00
	|-ReadOnlyCollection<TargetPositionCache.CacheEntry.RecordingItem>.System.Collections.Generic.ICollection<T>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private void System.Collections.Generic.IList<T>.RemoveAt(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3467950 Offset: 0x3467A51 VA: 0x3467950
	|-ReadOnlyCollection<IntervalTree.Entry<object>>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x3468970 Offset: 0x3468A71 VA: 0x3468970
	|-ReadOnlyCollection<KeyValuePair<DateTime, object>>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x3469960 Offset: 0x3469A61 VA: 0x3469960
	|-ReadOnlyCollection<KeyValuePair<int, object>>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x346A9F0 Offset: 0x346AAF1 VA: 0x346A9F0
	|-ReadOnlyCollection<KeyValuePair<object, ValueTuple<int, DateTime, object>>>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x346BA10 Offset: 0x346BB11 VA: 0x346BA10
	|-ReadOnlyCollection<KeyValuePair<object, object>>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x346CAA0 Offset: 0x346CBA1 VA: 0x346CAA0
	|-ReadOnlyCollection<CommonBattleSequence.Reliance<object>>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x346DAC0 Offset: 0x346DBC1 VA: 0x346DAC0
	|-ReadOnlyCollection<RenderGraphResourcePool.ResourceLogInfo<object>>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x346EAB0 Offset: 0x346EBB1 VA: 0x346EAB0
	|-ReadOnlyCollection<ValueTuple<int, object>>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x346FA80 Offset: 0x346FB81 VA: 0x346FA80
	|-ReadOnlyCollection<ValueTuple<Int32Enum, int>>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x3470B20 Offset: 0x3470C21 VA: 0x3470B20
	|-ReadOnlyCollection<ValueTuple<object, ValueTuple<object, int>>>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x3471B40 Offset: 0x3471C41 VA: 0x3471B40
	|-ReadOnlyCollection<ValueTuple<object, int>>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x3472B50 Offset: 0x3472C51 VA: 0x3472B50
	|-ReadOnlyCollection<ValueTuple<Vector3, float>>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x3473B50 Offset: 0x3473C51 VA: 0x3473B50
	|-ReadOnlyCollection<ValueTuple<object, Int32Enum, int>>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x3474BE0 Offset: 0x3474CE1 VA: 0x3474BE0
	|-ReadOnlyCollection<ValueTuple<object, int, int, int>>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x3475BE0 Offset: 0x3475CE1 VA: 0x3475BE0
	|-ReadOnlyCollection<AnimatorClipInfo>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x3B22A20 Offset: 0x3B22B21 VA: 0x3B22A20
	|-ReadOnlyCollection<AsyncOperationHandle>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x3B23AE0 Offset: 0x3B23BE1 VA: 0x3B23AE0
	|-ReadOnlyCollection<BoneWeight>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x3B24AE0 Offset: 0x3B24BE1 VA: 0x3B24AE0
	|-ReadOnlyCollection<bool>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x3B25AD0 Offset: 0x3B25BD1 VA: 0x3B25AD0
	|-ReadOnlyCollection<byte>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x3B26AD0 Offset: 0x3B26BD1 VA: 0x3B26AD0
	|-ReadOnlyCollection<CameraInfo>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x3B27AA0 Offset: 0x3B27BA1 VA: 0x3B27AA0
	|-ReadOnlyCollection<char>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x3B28AC0 Offset: 0x3B28BC1 VA: 0x3B28AC0
	|-ReadOnlyCollection<Color>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x3B29AE0 Offset: 0x3B29BE1 VA: 0x3B29AE0
	|-ReadOnlyCollection<Color32>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x3B2AAE0 Offset: 0x3B2ABE1 VA: 0x3B2AAE0
	|-ReadOnlyCollection<ConstraintSource>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x3B2BB70 Offset: 0x3B2BC71 VA: 0x3B2BB70
	|-ReadOnlyCollection<ContourVertex>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x3B2CC30 Offset: 0x3B2CD31 VA: 0x3B2CC30
	|-ReadOnlyCollection<CustomAttributeNamedArgument>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x3B2DC50 Offset: 0x3B2DD51 VA: 0x3B2DC50
	|-ReadOnlyCollection<CustomAttributeTypedArgument>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x3B2ECE0 Offset: 0x3B2EDE1 VA: 0x3B2ECE0
	|-ReadOnlyCollection<DataStoreRatingInfo>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x3B2FCE0 Offset: 0x3B2FDE1 VA: 0x3B2FCE0
	|-ReadOnlyCollection<DataStoreResult>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x3B30CC0 Offset: 0x3B30DC1 VA: 0x3B30CC0
	|-ReadOnlyCollection<DateTime>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x3B31CC0 Offset: 0x3B31DC1 VA: 0x3B31CC0
	|-ReadOnlyCollection<DateTimeOffset>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x3B32CB0 Offset: 0x3B32DB1 VA: 0x3B32CB0
	|-ReadOnlyCollection<Decimal>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x3B33D80 Offset: 0x3B33E81 VA: 0x3B33D80
	|-ReadOnlyCollection<DiagnosticEvent>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x3B34DB0 Offset: 0x3B34EB1 VA: 0x3B34DB0
	|-ReadOnlyCollection<double>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x3B35EA0 Offset: 0x3B35FA1 VA: 0x3B35EA0
	|-ReadOnlyCollection<Friend>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x3B36EE0 Offset: 0x3B36FE1 VA: 0x3B36EE0
	|-ReadOnlyCollection<GlyphRect>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x3B37EB0 Offset: 0x3B37FB1 VA: 0x3B37EB0
	|-ReadOnlyCollection<short>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x3B38E90 Offset: 0x3B38F91 VA: 0x3B38E90
	|-ReadOnlyCollection<int>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x3B39E70 Offset: 0x3B39F71 VA: 0x3B39E70
	|-ReadOnlyCollection<Int32Enum>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x3B3AE50 Offset: 0x3B3AF51 VA: 0x3B3AE50
	|-ReadOnlyCollection<long>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x3B3BE30 Offset: 0x3B3BF31 VA: 0x3B3BE30
	|-ReadOnlyCollection<IntPtr>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x3B3CE30 Offset: 0x3B3CF31 VA: 0x3B3CE30
	|-ReadOnlyCollection<InterpretedFrameInfo>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x3B3DEC0 Offset: 0x3B3DFC1 VA: 0x3B3DEC0
	|-ReadOnlyCollection<IntervalTreeNode>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x3B3EEC0 Offset: 0x3B3EFC1 VA: 0x3B3EEC0
	|-ReadOnlyCollection<LengthLimitProperties>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x3B3FEA0 Offset: 0x3B3FFA1 VA: 0x3B3FEA0
	|-ReadOnlyCollection<MapPos>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x3B40FC0 Offset: 0x3B410C1 VA: 0x3B40FC0
	|-ReadOnlyCollection<Matrix4x4>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x3B42010 Offset: 0x3B42111 VA: 0x3B42010
	|-ReadOnlyCollection<object>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x3B43000 Offset: 0x3B43101 VA: 0x3B43000
	|-ReadOnlyCollection<ObjectInitializationData>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x3B440F0 Offset: 0x3B441F1 VA: 0x3B440F0
	|-ReadOnlyCollection<PlayableBinding>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x3B451F0 Offset: 0x3B452F1 VA: 0x3B451F0
	|-ReadOnlyCollection<PlayerLoopSystem>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x3B46310 Offset: 0x3B46411 VA: 0x3B46310
	|-ReadOnlyCollection<PlayerLoopSystemInternal>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x3B47350 Offset: 0x3B47451 VA: 0x3B47350
	|-ReadOnlyCollection<RangePositionInfo>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x3B48320 Offset: 0x3B48421 VA: 0x3B48320
	|-ReadOnlyCollection<Ranking2ChartInfoInput>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x3B49420 Offset: 0x3B49521 VA: 0x3B49420
	|-ReadOnlyCollection<RaycastHit2D>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x3B4A5E0 Offset: 0x3B4A6E1 VA: 0x3B4A5E0
	|-ReadOnlyCollection<RaycastResult>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x3B4B6F0 Offset: 0x3B4B7F1 VA: 0x3B4B6F0
	|-ReadOnlyCollection<Rect>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x3B4C6D0 Offset: 0x3B4C7D1 VA: 0x3B4C6D0
	|-ReadOnlyCollection<RendererListHandle>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x3B4D6B0 Offset: 0x3B4D7B1 VA: 0x3B4D6B0
	|-ReadOnlyCollection<ResourceHandle>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x3AAED70 Offset: 0x3AAEE71 VA: 0x3AAED70
	|-ReadOnlyCollection<sbyte>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x3AAFD90 Offset: 0x3AAFE91 VA: 0x3AAFD90
	|-ReadOnlyCollection<ShaderTagId>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x3AB0D70 Offset: 0x3AB0E71 VA: 0x3AB0D70
	|-ReadOnlyCollection<float>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x3AB1F90 Offset: 0x3AB2091 VA: 0x3AB1F90
	|-ReadOnlyCollection<SphericalHarmonicsL2>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x3AB3240 Offset: 0x3AB3341 VA: 0x3AB3240
	|-ReadOnlyCollection<SubMeshDescriptor>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x3AB4290 Offset: 0x3AB4391 VA: 0x3AB4290
	|-ReadOnlyCollection<TablePair>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x3AB5260 Offset: 0x3AB5361 VA: 0x3AB5260
	|-ReadOnlyCollection<TimeSpan>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x3AB6280 Offset: 0x3AB6381 VA: 0x3AB6280
	|-ReadOnlyCollection<UICharInfo>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x3AB7280 Offset: 0x3AB7381 VA: 0x3AB7280
	|-ReadOnlyCollection<UILineInfo>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x3AB8490 Offset: 0x3AB8591 VA: 0x3AB8490
	|-ReadOnlyCollection<UIVertex>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x3AB9640 Offset: 0x3AB9741 VA: 0x3AB9640
	|-ReadOnlyCollection<ushort>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x3ABA620 Offset: 0x3ABA721 VA: 0x3ABA620
	|-ReadOnlyCollection<uint>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x3ABB600 Offset: 0x3ABB701 VA: 0x3ABB600
	|-ReadOnlyCollection<ulong>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x3ABC600 Offset: 0x3ABC701 VA: 0x3ABC600
	|-ReadOnlyCollection<Vector2>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x3ABD620 Offset: 0x3ABD721 VA: 0x3ABD620
	|-ReadOnlyCollection<Vector3>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x3ABE640 Offset: 0x3ABE741 VA: 0x3ABE640
	|-ReadOnlyCollection<Vector4>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x3ABF640 Offset: 0x3ABF741 VA: 0x3ABF640
	|-ReadOnlyCollection<VertexAttributeDescriptor>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x3AC0630 Offset: 0x3AC0731 VA: 0x3AC0630
	|-ReadOnlyCollection<X509ChainStatus>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x3AC16D0 Offset: 0x3AC17D1 VA: 0x3AC16D0
	|-ReadOnlyCollection<XRView>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x3AC2760 Offset: 0x3AC2861 VA: 0x3AC2760
	|-ReadOnlyCollection<AICrossfire.PositionTable>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x3AC3770 Offset: 0x3AC3871 VA: 0x3AC3770
	|-ReadOnlyCollection<AmiiboSequence.GainItemData>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x3AC4840 Offset: 0x3AC4941 VA: 0x3AC4840
	|-ReadOnlyCollection<AnimationOutputWeightProcessor.WeightInfo>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x3AC5880 Offset: 0x3AC5981 VA: 0x3AC5880
	|-ReadOnlyCollection<ArenaOrderSequence.GodInfo>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x3AC6870 Offset: 0x3AC6971 VA: 0x3AC6870
	|-ReadOnlyCollection<BattleInfo.SupportData>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x3AC7860 Offset: 0x3AC7961 VA: 0x3AC7860
	|-ReadOnlyCollection<BeforeRenderHelper.OrderBlock>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x3AC88F0 Offset: 0x3AC89F1 VA: 0x3AC88F0
	|-ReadOnlyCollection<Camera.RenderRequest>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x3AC9910 Offset: 0x3AC9A11 VA: 0x3AC9910
	|-ReadOnlyCollection<CameraState.CustomBlendable>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x3ACA8E0 Offset: 0x3ACA9E1 VA: 0x3ACA8E0
	|-ReadOnlyCollection<CinemachineClearShot.Pair>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x3ACB8C0 Offset: 0x3ACB9C1 VA: 0x3ACB8C0
	|-ReadOnlyCollection<CinemachineStateDrivenCamera.HashPair>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x3ACC960 Offset: 0x3ACCA61 VA: 0x3ACC960
	|-ReadOnlyCollection<DelayedActionManager.DelegateInfo>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x3ACDA60 Offset: 0x3ACDB61 VA: 0x3ACDA60
	|-ReadOnlyCollection<Detail.AsyncResultInt>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x3ACEAB0 Offset: 0x3ACEBB1 VA: 0x3ACEAB0
	|-ReadOnlyCollection<Detail.CppArray>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x3ACFB80 Offset: 0x3ACFC81 VA: 0x3ACFB80
	|-ReadOnlyCollection<Detail.NotificationEventInt>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x3AD0BD0 Offset: 0x3AD0CD1 VA: 0x3AD0BD0
	|-ReadOnlyCollection<DragonRideTargetGroup.ChainParam>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x3AD1C60 Offset: 0x3AD1D61 VA: 0x3AD1C60
	|-ReadOnlyCollection<GmapPathAdjuster.TargetModel>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x3AD2D20 Offset: 0x3AD2E21 VA: 0x3AD2D20
	|-ReadOnlyCollection<GmapSpotAdjuster.TargetModel>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x3AD3DE0 Offset: 0x3AD3EE1 VA: 0x3AD3DE0
	|-ReadOnlyCollection<HubFastTravel.Location>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x3AD4EE0 Offset: 0x3AD4FE1 VA: 0x3AD4EE0
	|-ReadOnlyCollection<HubLensFlare.Flare>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x3AD5F30 Offset: 0x3AD6031 VA: 0x3AD5F30
	|-ReadOnlyCollection<InventoryPoolItemMenuContent.KindBgNameClass>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x3AD6F00 Offset: 0x3AD7001 VA: 0x3AD6F00
	|-ReadOnlyCollection<Map.Pos>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x3AD7F00 Offset: 0x3AD8001 VA: 0x3AD7F00
	|-ReadOnlyCollection<MapImage.BackupTerrain>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x3AD8F10 Offset: 0x3AD9011 VA: 0x3AD8F10
	|-ReadOnlyCollection<MapImageRange.Pos>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x3AD9FB0 Offset: 0x3ADA0B1 VA: 0x3AD9FB0
	|-ReadOnlyCollection<MapMind.Target>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x38C4990 Offset: 0x38C4A91 VA: 0x38C4990
	|-ReadOnlyCollection<MapPanelDebug.Entity>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x38C5990 Offset: 0x38C5A91 VA: 0x38C5990
	|-ReadOnlyCollection<NexRanking.Data>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x38C6990 Offset: 0x38C6A91 VA: 0x38C6990
	|-ReadOnlyCollection<NexVersus.RatingData>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x38C7980 Offset: 0x38C7A81 VA: 0x38C7980
	|-ReadOnlyCollection<PackedPlayModeBuildLogs.RuntimeBuildLog>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x38C8A20 Offset: 0x38C8B21 VA: 0x38C8A20
	|-ReadOnlyCollection<ParticleSystem.Particle>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x38C9A70 Offset: 0x38C9B71 VA: 0x38C9A70
	|-ReadOnlyCollection<RangeData.Offset>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x38CAB10 Offset: 0x38CAC11 VA: 0x38CAB10
	|-ReadOnlyCollection<RenderGraphDebugData.PassDebugData>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x38CBC10 Offset: 0x38CBD11 VA: 0x38CBC10
	|-ReadOnlyCollection<RenderGraphDebugData.ResourceDebugData>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x38CCC50 Offset: 0x38CCD51 VA: 0x38CCC50
	|-ReadOnlyCollection<RingCleaningUnitSelectMenu.GodParam>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x38CDD20 Offset: 0x38CDE21 VA: 0x38CDD20
	|-ReadOnlyCollection<ShadowUtility.Edge>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x38CED90 Offset: 0x38CEE91 VA: 0x38CED90
	|-ReadOnlyCollection<SkillArray.Entity>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x38CFEB0 Offset: 0x38CFFB1 VA: 0x38CFEB0
	|-ReadOnlyCollection<TexturePacker_JsonArray.Frame>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x38D0FC0 Offset: 0x38D10C1 VA: 0x38D0FC0
	|-ReadOnlyCollection<TimeNotificationBehaviour.NotificationEntry>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x38D2080 Offset: 0x38D2181 VA: 0x38D2080
	|-ReadOnlyCollection<UnitySynchronizationContext.WorkRequest>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x38D30A0 Offset: 0x38D31A1 VA: 0x38D30A0
	|-ReadOnlyCollection<XmlSchemaObjectTable.XmlSchemaObjectEntry>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x38D4090 Offset: 0x38D4191 VA: 0x38D4090
	|-ReadOnlyCollection<AssetBundleBuildMap.AssetBundleEntry.AssetPathString>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x38D5150 Offset: 0x38D5251 VA: 0x38D5150
	|-ReadOnlyCollection<Detail.DataStore.DataStoreChangeMetaParamInt>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x38D61C0 Offset: 0x38D62C1 VA: 0x38D61C0
	|-ReadOnlyCollection<Detail.DataStore.DataStoreDeleteParamInt>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x38D7290 Offset: 0x38D7391 VA: 0x38D7290
	|-ReadOnlyCollection<Detail.DataStore.DataStoreGetMetaParamInt>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x38D8380 Offset: 0x38D8481 VA: 0x38D8380
	|-ReadOnlyCollection<Detail.DataStore.DataStoreMetaInfoInt>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x38D9490 Offset: 0x38D9591 VA: 0x38D9490
	|-ReadOnlyCollection<Detail.DataStore.DataStorePasswordInfoInt>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x38DA550 Offset: 0x38DA651 VA: 0x38DA550
	|-ReadOnlyCollection<Detail.DataStore.DataStorePersistenceInfoInt>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x38DB620 Offset: 0x38DB721 VA: 0x38DB620
	|-ReadOnlyCollection<Detail.DataStore.DataStorePreparePostParamInt>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x38DC690 Offset: 0x38DC791 VA: 0x38DC690
	|-ReadOnlyCollection<Detail.DataStore.DataStoreRateObjectParamInt>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x38DD720 Offset: 0x38DD821 VA: 0x38DD720
	|-ReadOnlyCollection<Detail.DataStore.DataStoreRatingInitParamInt>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x38DE740 Offset: 0x38DE841 VA: 0x38DE740
	|-ReadOnlyCollection<Detail.DataStore.DataStoreRatingTargetInt>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x38DF850 Offset: 0x38DF951 VA: 0x38DF850
	|-ReadOnlyCollection<Detail.Ranking.RankingCachedResultInt>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x38E08C0 Offset: 0x38E09C1 VA: 0x38E08C0
	|-ReadOnlyCollection<Detail.Ranking.RankingOrderParamInt>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x38E19D0 Offset: 0x38E1AD1 VA: 0x38E19D0
	|-ReadOnlyCollection<Detail.Ranking.RankingRankDataInt>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x38E2BE0 Offset: 0x38E2CE1 VA: 0x38E2BE0
	|-ReadOnlyCollection<Detail.Ranking2.Ranking2ChartInfoInt>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x38E3E70 Offset: 0x38E3F71 VA: 0x38E3E70
	|-ReadOnlyCollection<Detail.Ranking2.Ranking2RankDataInt>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x38E4EE0 Offset: 0x38E4FE1 VA: 0x38E4EE0
	|-ReadOnlyCollection<Detail.Ranking2.Ranking2ScoreDataInt>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x38E5F70 Offset: 0x38E6071 VA: 0x38E5F70
	|-ReadOnlyCollection<Detail.Screening.ScreeningContextInfoInt>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x38E70F0 Offset: 0x38E71F1 VA: 0x38E70F0
	|-ReadOnlyCollection<Detail.Subscriber.SubscriberContentInt>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x38E8280 Offset: 0x38E8381 VA: 0x38E8280
	|-ReadOnlyCollection<Detail.Subscriber.SubscriberGetContentParamInt>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x38E9380 Offset: 0x38E9481 VA: 0x38E9380
	|-ReadOnlyCollection<Detail.Subscriber.SubscriberUserStatusInfoInt>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x38EA460 Offset: 0x38EA561 VA: 0x38EA460
	|-ReadOnlyCollection<Detail.Subscriber.SubscriberUserStatusParamInt>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x38EB460 Offset: 0x38EB561 VA: 0x38EB460
	|-ReadOnlyCollection<Detail.Utility.IntegerSettings>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x38EC460 Offset: 0x38EC561 VA: 0x38EC460
	|-ReadOnlyCollection<Detail.Utility.UniqueIdInfoInt>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x38ED470 Offset: 0x38ED571 VA: 0x38ED470
	|-ReadOnlyCollection<MapHistory.Rewind.LatestInspectorData>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x38EE4A0 Offset: 0x38EE5A1 VA: 0x38EE4A0
	|-ReadOnlyCollection<MapHistory.Rewind.WorkTerrainData>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x38EF4B0 Offset: 0x38EF5B1 VA: 0x38EF4B0
	|-ReadOnlyCollection<MapSkill.AroundCalculator.Result>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x38F0580 Offset: 0x38F0681 VA: 0x38F0580
	|-ReadOnlyCollection<TargetPositionCache.CacheCurve.Item>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x2FE5B20 Offset: 0x2FE5C21 VA: 0x2FE5B20
	|-ReadOnlyCollection<TargetPositionCache.CacheEntry.RecordingItem>.System.Collections.Generic.IList<T>.RemoveAt
	*/

	// RVA: -1 Offset: -1 Slot: 17
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3467960 Offset: 0x3467A61 VA: 0x3467960
	|-ReadOnlyCollection<IntervalTree.Entry<object>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3468980 Offset: 0x3468A81 VA: 0x3468980
	|-ReadOnlyCollection<KeyValuePair<DateTime, object>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3469970 Offset: 0x3469A71 VA: 0x3469970
	|-ReadOnlyCollection<KeyValuePair<int, object>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x346AA00 Offset: 0x346AB01 VA: 0x346AA00
	|-ReadOnlyCollection<KeyValuePair<object, ValueTuple<int, DateTime, object>>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x346BA20 Offset: 0x346BB21 VA: 0x346BA20
	|-ReadOnlyCollection<KeyValuePair<object, object>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x346CAB0 Offset: 0x346CBB1 VA: 0x346CAB0
	|-ReadOnlyCollection<CommonBattleSequence.Reliance<object>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x346DAD0 Offset: 0x346DBD1 VA: 0x346DAD0
	|-ReadOnlyCollection<RenderGraphResourcePool.ResourceLogInfo<object>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x346EAC0 Offset: 0x346EBC1 VA: 0x346EAC0
	|-ReadOnlyCollection<ValueTuple<int, object>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x346FA90 Offset: 0x346FB91 VA: 0x346FA90
	|-ReadOnlyCollection<ValueTuple<Int32Enum, int>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3470B30 Offset: 0x3470C31 VA: 0x3470B30
	|-ReadOnlyCollection<ValueTuple<object, ValueTuple<object, int>>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3471B50 Offset: 0x3471C51 VA: 0x3471B50
	|-ReadOnlyCollection<ValueTuple<object, int>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3472B60 Offset: 0x3472C61 VA: 0x3472B60
	|-ReadOnlyCollection<ValueTuple<Vector3, float>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3473B60 Offset: 0x3473C61 VA: 0x3473B60
	|-ReadOnlyCollection<ValueTuple<object, Int32Enum, int>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3474BF0 Offset: 0x3474CF1 VA: 0x3474BF0
	|-ReadOnlyCollection<ValueTuple<object, int, int, int>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3475BF0 Offset: 0x3475CF1 VA: 0x3475BF0
	|-ReadOnlyCollection<AnimatorClipInfo>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3B22A30 Offset: 0x3B22B31 VA: 0x3B22A30
	|-ReadOnlyCollection<AsyncOperationHandle>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3B23AF0 Offset: 0x3B23BF1 VA: 0x3B23AF0
	|-ReadOnlyCollection<BoneWeight>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3B24AF0 Offset: 0x3B24BF1 VA: 0x3B24AF0
	|-ReadOnlyCollection<bool>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3B25AE0 Offset: 0x3B25BE1 VA: 0x3B25AE0
	|-ReadOnlyCollection<byte>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3B26AE0 Offset: 0x3B26BE1 VA: 0x3B26AE0
	|-ReadOnlyCollection<CameraInfo>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3B27AB0 Offset: 0x3B27BB1 VA: 0x3B27AB0
	|-ReadOnlyCollection<char>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3B28AD0 Offset: 0x3B28BD1 VA: 0x3B28AD0
	|-ReadOnlyCollection<Color>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3B29AF0 Offset: 0x3B29BF1 VA: 0x3B29AF0
	|-ReadOnlyCollection<Color32>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3B2AAF0 Offset: 0x3B2ABF1 VA: 0x3B2AAF0
	|-ReadOnlyCollection<ConstraintSource>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3B2BB80 Offset: 0x3B2BC81 VA: 0x3B2BB80
	|-ReadOnlyCollection<ContourVertex>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3B2CC40 Offset: 0x3B2CD41 VA: 0x3B2CC40
	|-ReadOnlyCollection<CustomAttributeNamedArgument>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3B2DC60 Offset: 0x3B2DD61 VA: 0x3B2DC60
	|-ReadOnlyCollection<CustomAttributeTypedArgument>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3B2ECF0 Offset: 0x3B2EDF1 VA: 0x3B2ECF0
	|-ReadOnlyCollection<DataStoreRatingInfo>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3B2FCF0 Offset: 0x3B2FDF1 VA: 0x3B2FCF0
	|-ReadOnlyCollection<DataStoreResult>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3B30CD0 Offset: 0x3B30DD1 VA: 0x3B30CD0
	|-ReadOnlyCollection<DateTime>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3B31CD0 Offset: 0x3B31DD1 VA: 0x3B31CD0
	|-ReadOnlyCollection<DateTimeOffset>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3B32CC0 Offset: 0x3B32DC1 VA: 0x3B32CC0
	|-ReadOnlyCollection<Decimal>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3B33D90 Offset: 0x3B33E91 VA: 0x3B33D90
	|-ReadOnlyCollection<DiagnosticEvent>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3B34DC0 Offset: 0x3B34EC1 VA: 0x3B34DC0
	|-ReadOnlyCollection<double>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3B35EB0 Offset: 0x3B35FB1 VA: 0x3B35EB0
	|-ReadOnlyCollection<Friend>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3B36EF0 Offset: 0x3B36FF1 VA: 0x3B36EF0
	|-ReadOnlyCollection<GlyphRect>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3B37EC0 Offset: 0x3B37FC1 VA: 0x3B37EC0
	|-ReadOnlyCollection<short>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3B38EA0 Offset: 0x3B38FA1 VA: 0x3B38EA0
	|-ReadOnlyCollection<int>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3B39E80 Offset: 0x3B39F81 VA: 0x3B39E80
	|-ReadOnlyCollection<Int32Enum>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3B3AE60 Offset: 0x3B3AF61 VA: 0x3B3AE60
	|-ReadOnlyCollection<long>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3B3BE40 Offset: 0x3B3BF41 VA: 0x3B3BE40
	|-ReadOnlyCollection<IntPtr>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3B3CE40 Offset: 0x3B3CF41 VA: 0x3B3CE40
	|-ReadOnlyCollection<InterpretedFrameInfo>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3B3DED0 Offset: 0x3B3DFD1 VA: 0x3B3DED0
	|-ReadOnlyCollection<IntervalTreeNode>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3B3EED0 Offset: 0x3B3EFD1 VA: 0x3B3EED0
	|-ReadOnlyCollection<LengthLimitProperties>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3B3FEB0 Offset: 0x3B3FFB1 VA: 0x3B3FEB0
	|-ReadOnlyCollection<MapPos>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3B40FD0 Offset: 0x3B410D1 VA: 0x3B40FD0
	|-ReadOnlyCollection<Matrix4x4>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3B42020 Offset: 0x3B42121 VA: 0x3B42020
	|-ReadOnlyCollection<object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3B43010 Offset: 0x3B43111 VA: 0x3B43010
	|-ReadOnlyCollection<ObjectInitializationData>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3B44100 Offset: 0x3B44201 VA: 0x3B44100
	|-ReadOnlyCollection<PlayableBinding>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3B45200 Offset: 0x3B45301 VA: 0x3B45200
	|-ReadOnlyCollection<PlayerLoopSystem>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3B46320 Offset: 0x3B46421 VA: 0x3B46320
	|-ReadOnlyCollection<PlayerLoopSystemInternal>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3B47360 Offset: 0x3B47461 VA: 0x3B47360
	|-ReadOnlyCollection<RangePositionInfo>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3B48330 Offset: 0x3B48431 VA: 0x3B48330
	|-ReadOnlyCollection<Ranking2ChartInfoInput>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3B49430 Offset: 0x3B49531 VA: 0x3B49430
	|-ReadOnlyCollection<RaycastHit2D>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3B4A5F0 Offset: 0x3B4A6F1 VA: 0x3B4A5F0
	|-ReadOnlyCollection<RaycastResult>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3B4B700 Offset: 0x3B4B801 VA: 0x3B4B700
	|-ReadOnlyCollection<Rect>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3B4C6E0 Offset: 0x3B4C7E1 VA: 0x3B4C6E0
	|-ReadOnlyCollection<RendererListHandle>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3B4D6C0 Offset: 0x3B4D7C1 VA: 0x3B4D6C0
	|-ReadOnlyCollection<ResourceHandle>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3AAED80 Offset: 0x3AAEE81 VA: 0x3AAED80
	|-ReadOnlyCollection<sbyte>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3AAFDA0 Offset: 0x3AAFEA1 VA: 0x3AAFDA0
	|-ReadOnlyCollection<ShaderTagId>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3AB0D80 Offset: 0x3AB0E81 VA: 0x3AB0D80
	|-ReadOnlyCollection<float>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3AB1FA0 Offset: 0x3AB20A1 VA: 0x3AB1FA0
	|-ReadOnlyCollection<SphericalHarmonicsL2>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3AB3250 Offset: 0x3AB3351 VA: 0x3AB3250
	|-ReadOnlyCollection<SubMeshDescriptor>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3AB42A0 Offset: 0x3AB43A1 VA: 0x3AB42A0
	|-ReadOnlyCollection<TablePair>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3AB5270 Offset: 0x3AB5371 VA: 0x3AB5270
	|-ReadOnlyCollection<TimeSpan>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3AB6290 Offset: 0x3AB6391 VA: 0x3AB6290
	|-ReadOnlyCollection<UICharInfo>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3AB7290 Offset: 0x3AB7391 VA: 0x3AB7290
	|-ReadOnlyCollection<UILineInfo>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3AB84A0 Offset: 0x3AB85A1 VA: 0x3AB84A0
	|-ReadOnlyCollection<UIVertex>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3AB9650 Offset: 0x3AB9751 VA: 0x3AB9650
	|-ReadOnlyCollection<ushort>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3ABA630 Offset: 0x3ABA731 VA: 0x3ABA630
	|-ReadOnlyCollection<uint>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3ABB610 Offset: 0x3ABB711 VA: 0x3ABB610
	|-ReadOnlyCollection<ulong>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3ABC610 Offset: 0x3ABC711 VA: 0x3ABC610
	|-ReadOnlyCollection<Vector2>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3ABD630 Offset: 0x3ABD731 VA: 0x3ABD630
	|-ReadOnlyCollection<Vector3>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3ABE650 Offset: 0x3ABE751 VA: 0x3ABE650
	|-ReadOnlyCollection<Vector4>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3ABF650 Offset: 0x3ABF751 VA: 0x3ABF650
	|-ReadOnlyCollection<VertexAttributeDescriptor>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3AC0640 Offset: 0x3AC0741 VA: 0x3AC0640
	|-ReadOnlyCollection<X509ChainStatus>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3AC16E0 Offset: 0x3AC17E1 VA: 0x3AC16E0
	|-ReadOnlyCollection<XRView>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3AC2770 Offset: 0x3AC2871 VA: 0x3AC2770
	|-ReadOnlyCollection<AICrossfire.PositionTable>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3AC3780 Offset: 0x3AC3881 VA: 0x3AC3780
	|-ReadOnlyCollection<AmiiboSequence.GainItemData>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3AC4850 Offset: 0x3AC4951 VA: 0x3AC4850
	|-ReadOnlyCollection<AnimationOutputWeightProcessor.WeightInfo>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3AC5890 Offset: 0x3AC5991 VA: 0x3AC5890
	|-ReadOnlyCollection<ArenaOrderSequence.GodInfo>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3AC6880 Offset: 0x3AC6981 VA: 0x3AC6880
	|-ReadOnlyCollection<BattleInfo.SupportData>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3AC7870 Offset: 0x3AC7971 VA: 0x3AC7870
	|-ReadOnlyCollection<BeforeRenderHelper.OrderBlock>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3AC8900 Offset: 0x3AC8A01 VA: 0x3AC8900
	|-ReadOnlyCollection<Camera.RenderRequest>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3AC9920 Offset: 0x3AC9A21 VA: 0x3AC9920
	|-ReadOnlyCollection<CameraState.CustomBlendable>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3ACA8F0 Offset: 0x3ACA9F1 VA: 0x3ACA8F0
	|-ReadOnlyCollection<CinemachineClearShot.Pair>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3ACB8D0 Offset: 0x3ACB9D1 VA: 0x3ACB8D0
	|-ReadOnlyCollection<CinemachineStateDrivenCamera.HashPair>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3ACC970 Offset: 0x3ACCA71 VA: 0x3ACC970
	|-ReadOnlyCollection<DelayedActionManager.DelegateInfo>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3ACDA70 Offset: 0x3ACDB71 VA: 0x3ACDA70
	|-ReadOnlyCollection<Detail.AsyncResultInt>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3ACEAC0 Offset: 0x3ACEBC1 VA: 0x3ACEAC0
	|-ReadOnlyCollection<Detail.CppArray>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3ACFB90 Offset: 0x3ACFC91 VA: 0x3ACFB90
	|-ReadOnlyCollection<Detail.NotificationEventInt>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3AD0BE0 Offset: 0x3AD0CE1 VA: 0x3AD0BE0
	|-ReadOnlyCollection<DragonRideTargetGroup.ChainParam>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3AD1C70 Offset: 0x3AD1D71 VA: 0x3AD1C70
	|-ReadOnlyCollection<GmapPathAdjuster.TargetModel>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3AD2D30 Offset: 0x3AD2E31 VA: 0x3AD2D30
	|-ReadOnlyCollection<GmapSpotAdjuster.TargetModel>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3AD3DF0 Offset: 0x3AD3EF1 VA: 0x3AD3DF0
	|-ReadOnlyCollection<HubFastTravel.Location>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3AD4EF0 Offset: 0x3AD4FF1 VA: 0x3AD4EF0
	|-ReadOnlyCollection<HubLensFlare.Flare>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3AD5F40 Offset: 0x3AD6041 VA: 0x3AD5F40
	|-ReadOnlyCollection<InventoryPoolItemMenuContent.KindBgNameClass>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3AD6F10 Offset: 0x3AD7011 VA: 0x3AD6F10
	|-ReadOnlyCollection<Map.Pos>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3AD7F10 Offset: 0x3AD8011 VA: 0x3AD7F10
	|-ReadOnlyCollection<MapImage.BackupTerrain>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3AD8F20 Offset: 0x3AD9021 VA: 0x3AD8F20
	|-ReadOnlyCollection<MapImageRange.Pos>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3AD9FC0 Offset: 0x3ADA0C1 VA: 0x3AD9FC0
	|-ReadOnlyCollection<MapMind.Target>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x38C49A0 Offset: 0x38C4AA1 VA: 0x38C49A0
	|-ReadOnlyCollection<MapPanelDebug.Entity>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x38C59A0 Offset: 0x38C5AA1 VA: 0x38C59A0
	|-ReadOnlyCollection<NexRanking.Data>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x38C69A0 Offset: 0x38C6AA1 VA: 0x38C69A0
	|-ReadOnlyCollection<NexVersus.RatingData>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x38C7990 Offset: 0x38C7A91 VA: 0x38C7990
	|-ReadOnlyCollection<PackedPlayModeBuildLogs.RuntimeBuildLog>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x38C8A30 Offset: 0x38C8B31 VA: 0x38C8A30
	|-ReadOnlyCollection<ParticleSystem.Particle>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x38C9A80 Offset: 0x38C9B81 VA: 0x38C9A80
	|-ReadOnlyCollection<RangeData.Offset>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x38CAB20 Offset: 0x38CAC21 VA: 0x38CAB20
	|-ReadOnlyCollection<RenderGraphDebugData.PassDebugData>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x38CBC20 Offset: 0x38CBD21 VA: 0x38CBC20
	|-ReadOnlyCollection<RenderGraphDebugData.ResourceDebugData>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x38CCC60 Offset: 0x38CCD61 VA: 0x38CCC60
	|-ReadOnlyCollection<RingCleaningUnitSelectMenu.GodParam>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x38CDD30 Offset: 0x38CDE31 VA: 0x38CDD30
	|-ReadOnlyCollection<ShadowUtility.Edge>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x38CEDA0 Offset: 0x38CEEA1 VA: 0x38CEDA0
	|-ReadOnlyCollection<SkillArray.Entity>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x38CFEC0 Offset: 0x38CFFC1 VA: 0x38CFEC0
	|-ReadOnlyCollection<TexturePacker_JsonArray.Frame>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x38D0FD0 Offset: 0x38D10D1 VA: 0x38D0FD0
	|-ReadOnlyCollection<TimeNotificationBehaviour.NotificationEntry>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x38D2090 Offset: 0x38D2191 VA: 0x38D2090
	|-ReadOnlyCollection<UnitySynchronizationContext.WorkRequest>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x38D30B0 Offset: 0x38D31B1 VA: 0x38D30B0
	|-ReadOnlyCollection<XmlSchemaObjectTable.XmlSchemaObjectEntry>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x38D40A0 Offset: 0x38D41A1 VA: 0x38D40A0
	|-ReadOnlyCollection<AssetBundleBuildMap.AssetBundleEntry.AssetPathString>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x38D5160 Offset: 0x38D5261 VA: 0x38D5160
	|-ReadOnlyCollection<Detail.DataStore.DataStoreChangeMetaParamInt>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x38D61D0 Offset: 0x38D62D1 VA: 0x38D61D0
	|-ReadOnlyCollection<Detail.DataStore.DataStoreDeleteParamInt>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x38D72A0 Offset: 0x38D73A1 VA: 0x38D72A0
	|-ReadOnlyCollection<Detail.DataStore.DataStoreGetMetaParamInt>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x38D8390 Offset: 0x38D8491 VA: 0x38D8390
	|-ReadOnlyCollection<Detail.DataStore.DataStoreMetaInfoInt>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x38D94A0 Offset: 0x38D95A1 VA: 0x38D94A0
	|-ReadOnlyCollection<Detail.DataStore.DataStorePasswordInfoInt>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x38DA560 Offset: 0x38DA661 VA: 0x38DA560
	|-ReadOnlyCollection<Detail.DataStore.DataStorePersistenceInfoInt>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x38DB630 Offset: 0x38DB731 VA: 0x38DB630
	|-ReadOnlyCollection<Detail.DataStore.DataStorePreparePostParamInt>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x38DC6A0 Offset: 0x38DC7A1 VA: 0x38DC6A0
	|-ReadOnlyCollection<Detail.DataStore.DataStoreRateObjectParamInt>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x38DD730 Offset: 0x38DD831 VA: 0x38DD730
	|-ReadOnlyCollection<Detail.DataStore.DataStoreRatingInitParamInt>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x38DE750 Offset: 0x38DE851 VA: 0x38DE750
	|-ReadOnlyCollection<Detail.DataStore.DataStoreRatingTargetInt>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x38DF860 Offset: 0x38DF961 VA: 0x38DF860
	|-ReadOnlyCollection<Detail.Ranking.RankingCachedResultInt>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x38E08D0 Offset: 0x38E09D1 VA: 0x38E08D0
	|-ReadOnlyCollection<Detail.Ranking.RankingOrderParamInt>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x38E19E0 Offset: 0x38E1AE1 VA: 0x38E19E0
	|-ReadOnlyCollection<Detail.Ranking.RankingRankDataInt>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x38E2BF0 Offset: 0x38E2CF1 VA: 0x38E2BF0
	|-ReadOnlyCollection<Detail.Ranking2.Ranking2ChartInfoInt>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x38E3E80 Offset: 0x38E3F81 VA: 0x38E3E80
	|-ReadOnlyCollection<Detail.Ranking2.Ranking2RankDataInt>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x38E4EF0 Offset: 0x38E4FF1 VA: 0x38E4EF0
	|-ReadOnlyCollection<Detail.Ranking2.Ranking2ScoreDataInt>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x38E5F80 Offset: 0x38E6081 VA: 0x38E5F80
	|-ReadOnlyCollection<Detail.Screening.ScreeningContextInfoInt>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x38E7100 Offset: 0x38E7201 VA: 0x38E7100
	|-ReadOnlyCollection<Detail.Subscriber.SubscriberContentInt>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x38E8290 Offset: 0x38E8391 VA: 0x38E8290
	|-ReadOnlyCollection<Detail.Subscriber.SubscriberGetContentParamInt>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x38E9390 Offset: 0x38E9491 VA: 0x38E9390
	|-ReadOnlyCollection<Detail.Subscriber.SubscriberUserStatusInfoInt>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x38EA470 Offset: 0x38EA571 VA: 0x38EA470
	|-ReadOnlyCollection<Detail.Subscriber.SubscriberUserStatusParamInt>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x38EB470 Offset: 0x38EB571 VA: 0x38EB470
	|-ReadOnlyCollection<Detail.Utility.IntegerSettings>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x38EC470 Offset: 0x38EC571 VA: 0x38EC470
	|-ReadOnlyCollection<Detail.Utility.UniqueIdInfoInt>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x38ED480 Offset: 0x38ED581 VA: 0x38ED480
	|-ReadOnlyCollection<MapHistory.Rewind.LatestInspectorData>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x38EE4B0 Offset: 0x38EE5B1 VA: 0x38EE4B0
	|-ReadOnlyCollection<MapHistory.Rewind.WorkTerrainData>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x38EF4C0 Offset: 0x38EF5C1 VA: 0x38EF4C0
	|-ReadOnlyCollection<MapSkill.AroundCalculator.Result>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x38F0590 Offset: 0x38F0691 VA: 0x38F0590
	|-ReadOnlyCollection<TargetPositionCache.CacheCurve.Item>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2FE5B30 Offset: 0x2FE5C31 VA: 0x2FE5B30
	|-ReadOnlyCollection<TargetPositionCache.CacheEntry.RecordingItem>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 31
	private bool System.Collections.ICollection.get_IsSynchronized() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3467A10 Offset: 0x3467B11 VA: 0x3467A10
	|-ReadOnlyCollection<IntervalTree.Entry<object>>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3468A30 Offset: 0x3468B31 VA: 0x3468A30
	|-ReadOnlyCollection<KeyValuePair<DateTime, object>>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3469A20 Offset: 0x3469B21 VA: 0x3469A20
	|-ReadOnlyCollection<KeyValuePair<int, object>>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x346AAB0 Offset: 0x346ABB1 VA: 0x346AAB0
	|-ReadOnlyCollection<KeyValuePair<object, ValueTuple<int, DateTime, object>>>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x346BAD0 Offset: 0x346BBD1 VA: 0x346BAD0
	|-ReadOnlyCollection<KeyValuePair<object, object>>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x346CB60 Offset: 0x346CC61 VA: 0x346CB60
	|-ReadOnlyCollection<CommonBattleSequence.Reliance<object>>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x346DB80 Offset: 0x346DC81 VA: 0x346DB80
	|-ReadOnlyCollection<RenderGraphResourcePool.ResourceLogInfo<object>>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x346EB70 Offset: 0x346EC71 VA: 0x346EB70
	|-ReadOnlyCollection<ValueTuple<int, object>>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x346FB40 Offset: 0x346FC41 VA: 0x346FB40
	|-ReadOnlyCollection<ValueTuple<Int32Enum, int>>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3470BE0 Offset: 0x3470CE1 VA: 0x3470BE0
	|-ReadOnlyCollection<ValueTuple<object, ValueTuple<object, int>>>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3471C00 Offset: 0x3471D01 VA: 0x3471C00
	|-ReadOnlyCollection<ValueTuple<object, int>>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3472C10 Offset: 0x3472D11 VA: 0x3472C10
	|-ReadOnlyCollection<ValueTuple<Vector3, float>>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3473C10 Offset: 0x3473D11 VA: 0x3473C10
	|-ReadOnlyCollection<ValueTuple<object, Int32Enum, int>>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3474CA0 Offset: 0x3474DA1 VA: 0x3474CA0
	|-ReadOnlyCollection<ValueTuple<object, int, int, int>>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3475CA0 Offset: 0x3475DA1 VA: 0x3475CA0
	|-ReadOnlyCollection<AnimatorClipInfo>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3B22AE0 Offset: 0x3B22BE1 VA: 0x3B22AE0
	|-ReadOnlyCollection<AsyncOperationHandle>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3B23BA0 Offset: 0x3B23CA1 VA: 0x3B23BA0
	|-ReadOnlyCollection<BoneWeight>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3B24BA0 Offset: 0x3B24CA1 VA: 0x3B24BA0
	|-ReadOnlyCollection<bool>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3B25B90 Offset: 0x3B25C91 VA: 0x3B25B90
	|-ReadOnlyCollection<byte>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3B26B90 Offset: 0x3B26C91 VA: 0x3B26B90
	|-ReadOnlyCollection<CameraInfo>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3B27B60 Offset: 0x3B27C61 VA: 0x3B27B60
	|-ReadOnlyCollection<char>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3B28B80 Offset: 0x3B28C81 VA: 0x3B28B80
	|-ReadOnlyCollection<Color>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3B29BA0 Offset: 0x3B29CA1 VA: 0x3B29BA0
	|-ReadOnlyCollection<Color32>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3B2ABA0 Offset: 0x3B2ACA1 VA: 0x3B2ABA0
	|-ReadOnlyCollection<ConstraintSource>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3B2BC30 Offset: 0x3B2BD31 VA: 0x3B2BC30
	|-ReadOnlyCollection<ContourVertex>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3B2CCF0 Offset: 0x3B2CDF1 VA: 0x3B2CCF0
	|-ReadOnlyCollection<CustomAttributeNamedArgument>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3B2DD10 Offset: 0x3B2DE11 VA: 0x3B2DD10
	|-ReadOnlyCollection<CustomAttributeTypedArgument>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3B2EDA0 Offset: 0x3B2EEA1 VA: 0x3B2EDA0
	|-ReadOnlyCollection<DataStoreRatingInfo>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3B2FDA0 Offset: 0x3B2FEA1 VA: 0x3B2FDA0
	|-ReadOnlyCollection<DataStoreResult>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3B30D80 Offset: 0x3B30E81 VA: 0x3B30D80
	|-ReadOnlyCollection<DateTime>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3B31D80 Offset: 0x3B31E81 VA: 0x3B31D80
	|-ReadOnlyCollection<DateTimeOffset>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3B32D70 Offset: 0x3B32E71 VA: 0x3B32D70
	|-ReadOnlyCollection<Decimal>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3B33E40 Offset: 0x3B33F41 VA: 0x3B33E40
	|-ReadOnlyCollection<DiagnosticEvent>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3B34E70 Offset: 0x3B34F71 VA: 0x3B34E70
	|-ReadOnlyCollection<double>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3B35F60 Offset: 0x3B36061 VA: 0x3B35F60
	|-ReadOnlyCollection<Friend>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3B36FA0 Offset: 0x3B370A1 VA: 0x3B36FA0
	|-ReadOnlyCollection<GlyphRect>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3B37F70 Offset: 0x3B38071 VA: 0x3B37F70
	|-ReadOnlyCollection<short>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3B38F50 Offset: 0x3B39051 VA: 0x3B38F50
	|-ReadOnlyCollection<int>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3B39F30 Offset: 0x3B3A031 VA: 0x3B39F30
	|-ReadOnlyCollection<Int32Enum>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3B3AF10 Offset: 0x3B3B011 VA: 0x3B3AF10
	|-ReadOnlyCollection<long>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3B3BEF0 Offset: 0x3B3BFF1 VA: 0x3B3BEF0
	|-ReadOnlyCollection<IntPtr>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3B3CEF0 Offset: 0x3B3CFF1 VA: 0x3B3CEF0
	|-ReadOnlyCollection<InterpretedFrameInfo>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3B3DF80 Offset: 0x3B3E081 VA: 0x3B3DF80
	|-ReadOnlyCollection<IntervalTreeNode>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3B3EF80 Offset: 0x3B3F081 VA: 0x3B3EF80
	|-ReadOnlyCollection<LengthLimitProperties>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3B3FF60 Offset: 0x3B40061 VA: 0x3B3FF60
	|-ReadOnlyCollection<MapPos>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3B41080 Offset: 0x3B41181 VA: 0x3B41080
	|-ReadOnlyCollection<Matrix4x4>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3B420D0 Offset: 0x3B421D1 VA: 0x3B420D0
	|-ReadOnlyCollection<object>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3B430C0 Offset: 0x3B431C1 VA: 0x3B430C0
	|-ReadOnlyCollection<ObjectInitializationData>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3B441B0 Offset: 0x3B442B1 VA: 0x3B441B0
	|-ReadOnlyCollection<PlayableBinding>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3B452B0 Offset: 0x3B453B1 VA: 0x3B452B0
	|-ReadOnlyCollection<PlayerLoopSystem>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3B463D0 Offset: 0x3B464D1 VA: 0x3B463D0
	|-ReadOnlyCollection<PlayerLoopSystemInternal>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3B47410 Offset: 0x3B47511 VA: 0x3B47410
	|-ReadOnlyCollection<RangePositionInfo>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3B483E0 Offset: 0x3B484E1 VA: 0x3B483E0
	|-ReadOnlyCollection<Ranking2ChartInfoInput>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3B494E0 Offset: 0x3B495E1 VA: 0x3B494E0
	|-ReadOnlyCollection<RaycastHit2D>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3B4A6A0 Offset: 0x3B4A7A1 VA: 0x3B4A6A0
	|-ReadOnlyCollection<RaycastResult>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3B4B7B0 Offset: 0x3B4B8B1 VA: 0x3B4B7B0
	|-ReadOnlyCollection<Rect>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3B4C790 Offset: 0x3B4C891 VA: 0x3B4C790
	|-ReadOnlyCollection<RendererListHandle>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3B4D770 Offset: 0x3B4D871 VA: 0x3B4D770
	|-ReadOnlyCollection<ResourceHandle>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3AAEE30 Offset: 0x3AAEF31 VA: 0x3AAEE30
	|-ReadOnlyCollection<sbyte>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3AAFE50 Offset: 0x3AAFF51 VA: 0x3AAFE50
	|-ReadOnlyCollection<ShaderTagId>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3AB0E30 Offset: 0x3AB0F31 VA: 0x3AB0E30
	|-ReadOnlyCollection<float>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3AB2050 Offset: 0x3AB2151 VA: 0x3AB2050
	|-ReadOnlyCollection<SphericalHarmonicsL2>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3AB3300 Offset: 0x3AB3401 VA: 0x3AB3300
	|-ReadOnlyCollection<SubMeshDescriptor>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3AB4350 Offset: 0x3AB4451 VA: 0x3AB4350
	|-ReadOnlyCollection<TablePair>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3AB5320 Offset: 0x3AB5421 VA: 0x3AB5320
	|-ReadOnlyCollection<TimeSpan>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3AB6340 Offset: 0x3AB6441 VA: 0x3AB6340
	|-ReadOnlyCollection<UICharInfo>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3AB7340 Offset: 0x3AB7441 VA: 0x3AB7340
	|-ReadOnlyCollection<UILineInfo>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3AB8550 Offset: 0x3AB8651 VA: 0x3AB8550
	|-ReadOnlyCollection<UIVertex>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3AB9700 Offset: 0x3AB9801 VA: 0x3AB9700
	|-ReadOnlyCollection<ushort>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3ABA6E0 Offset: 0x3ABA7E1 VA: 0x3ABA6E0
	|-ReadOnlyCollection<uint>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3ABB6C0 Offset: 0x3ABB7C1 VA: 0x3ABB6C0
	|-ReadOnlyCollection<ulong>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3ABC6C0 Offset: 0x3ABC7C1 VA: 0x3ABC6C0
	|-ReadOnlyCollection<Vector2>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3ABD6E0 Offset: 0x3ABD7E1 VA: 0x3ABD6E0
	|-ReadOnlyCollection<Vector3>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3ABE700 Offset: 0x3ABE801 VA: 0x3ABE700
	|-ReadOnlyCollection<Vector4>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3ABF700 Offset: 0x3ABF801 VA: 0x3ABF700
	|-ReadOnlyCollection<VertexAttributeDescriptor>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3AC06F0 Offset: 0x3AC07F1 VA: 0x3AC06F0
	|-ReadOnlyCollection<X509ChainStatus>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3AC1790 Offset: 0x3AC1891 VA: 0x3AC1790
	|-ReadOnlyCollection<XRView>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3AC2820 Offset: 0x3AC2921 VA: 0x3AC2820
	|-ReadOnlyCollection<AICrossfire.PositionTable>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3AC3830 Offset: 0x3AC3931 VA: 0x3AC3830
	|-ReadOnlyCollection<AmiiboSequence.GainItemData>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3AC4900 Offset: 0x3AC4A01 VA: 0x3AC4900
	|-ReadOnlyCollection<AnimationOutputWeightProcessor.WeightInfo>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3AC5940 Offset: 0x3AC5A41 VA: 0x3AC5940
	|-ReadOnlyCollection<ArenaOrderSequence.GodInfo>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3AC6930 Offset: 0x3AC6A31 VA: 0x3AC6930
	|-ReadOnlyCollection<BattleInfo.SupportData>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3AC7920 Offset: 0x3AC7A21 VA: 0x3AC7920
	|-ReadOnlyCollection<BeforeRenderHelper.OrderBlock>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3AC89B0 Offset: 0x3AC8AB1 VA: 0x3AC89B0
	|-ReadOnlyCollection<Camera.RenderRequest>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3AC99D0 Offset: 0x3AC9AD1 VA: 0x3AC99D0
	|-ReadOnlyCollection<CameraState.CustomBlendable>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3ACA9A0 Offset: 0x3ACAAA1 VA: 0x3ACA9A0
	|-ReadOnlyCollection<CinemachineClearShot.Pair>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3ACB980 Offset: 0x3ACBA81 VA: 0x3ACB980
	|-ReadOnlyCollection<CinemachineStateDrivenCamera.HashPair>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3ACCA20 Offset: 0x3ACCB21 VA: 0x3ACCA20
	|-ReadOnlyCollection<DelayedActionManager.DelegateInfo>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3ACDB20 Offset: 0x3ACDC21 VA: 0x3ACDB20
	|-ReadOnlyCollection<Detail.AsyncResultInt>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3ACEB70 Offset: 0x3ACEC71 VA: 0x3ACEB70
	|-ReadOnlyCollection<Detail.CppArray>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3ACFC40 Offset: 0x3ACFD41 VA: 0x3ACFC40
	|-ReadOnlyCollection<Detail.NotificationEventInt>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3AD0C90 Offset: 0x3AD0D91 VA: 0x3AD0C90
	|-ReadOnlyCollection<DragonRideTargetGroup.ChainParam>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3AD1D20 Offset: 0x3AD1E21 VA: 0x3AD1D20
	|-ReadOnlyCollection<GmapPathAdjuster.TargetModel>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3AD2DE0 Offset: 0x3AD2EE1 VA: 0x3AD2DE0
	|-ReadOnlyCollection<GmapSpotAdjuster.TargetModel>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3AD3EA0 Offset: 0x3AD3FA1 VA: 0x3AD3EA0
	|-ReadOnlyCollection<HubFastTravel.Location>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3AD4FA0 Offset: 0x3AD50A1 VA: 0x3AD4FA0
	|-ReadOnlyCollection<HubLensFlare.Flare>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3AD5FF0 Offset: 0x3AD60F1 VA: 0x3AD5FF0
	|-ReadOnlyCollection<InventoryPoolItemMenuContent.KindBgNameClass>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3AD6FC0 Offset: 0x3AD70C1 VA: 0x3AD6FC0
	|-ReadOnlyCollection<Map.Pos>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3AD7FC0 Offset: 0x3AD80C1 VA: 0x3AD7FC0
	|-ReadOnlyCollection<MapImage.BackupTerrain>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3AD8FD0 Offset: 0x3AD90D1 VA: 0x3AD8FD0
	|-ReadOnlyCollection<MapImageRange.Pos>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3ADA070 Offset: 0x3ADA171 VA: 0x3ADA070
	|-ReadOnlyCollection<MapMind.Target>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x38C4A50 Offset: 0x38C4B51 VA: 0x38C4A50
	|-ReadOnlyCollection<MapPanelDebug.Entity>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x38C5A50 Offset: 0x38C5B51 VA: 0x38C5A50
	|-ReadOnlyCollection<NexRanking.Data>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x38C6A50 Offset: 0x38C6B51 VA: 0x38C6A50
	|-ReadOnlyCollection<NexVersus.RatingData>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x38C7A40 Offset: 0x38C7B41 VA: 0x38C7A40
	|-ReadOnlyCollection<PackedPlayModeBuildLogs.RuntimeBuildLog>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x38C8AE0 Offset: 0x38C8BE1 VA: 0x38C8AE0
	|-ReadOnlyCollection<ParticleSystem.Particle>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x38C9B30 Offset: 0x38C9C31 VA: 0x38C9B30
	|-ReadOnlyCollection<RangeData.Offset>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x38CABD0 Offset: 0x38CACD1 VA: 0x38CABD0
	|-ReadOnlyCollection<RenderGraphDebugData.PassDebugData>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x38CBCD0 Offset: 0x38CBDD1 VA: 0x38CBCD0
	|-ReadOnlyCollection<RenderGraphDebugData.ResourceDebugData>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x38CCD10 Offset: 0x38CCE11 VA: 0x38CCD10
	|-ReadOnlyCollection<RingCleaningUnitSelectMenu.GodParam>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x38CDDE0 Offset: 0x38CDEE1 VA: 0x38CDDE0
	|-ReadOnlyCollection<ShadowUtility.Edge>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x38CEE50 Offset: 0x38CEF51 VA: 0x38CEE50
	|-ReadOnlyCollection<SkillArray.Entity>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x38CFF70 Offset: 0x38D0071 VA: 0x38CFF70
	|-ReadOnlyCollection<TexturePacker_JsonArray.Frame>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x38D1080 Offset: 0x38D1181 VA: 0x38D1080
	|-ReadOnlyCollection<TimeNotificationBehaviour.NotificationEntry>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x38D2140 Offset: 0x38D2241 VA: 0x38D2140
	|-ReadOnlyCollection<UnitySynchronizationContext.WorkRequest>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x38D3160 Offset: 0x38D3261 VA: 0x38D3160
	|-ReadOnlyCollection<XmlSchemaObjectTable.XmlSchemaObjectEntry>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x38D4150 Offset: 0x38D4251 VA: 0x38D4150
	|-ReadOnlyCollection<AssetBundleBuildMap.AssetBundleEntry.AssetPathString>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x38D5210 Offset: 0x38D5311 VA: 0x38D5210
	|-ReadOnlyCollection<Detail.DataStore.DataStoreChangeMetaParamInt>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x38D6280 Offset: 0x38D6381 VA: 0x38D6280
	|-ReadOnlyCollection<Detail.DataStore.DataStoreDeleteParamInt>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x38D7350 Offset: 0x38D7451 VA: 0x38D7350
	|-ReadOnlyCollection<Detail.DataStore.DataStoreGetMetaParamInt>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x38D8440 Offset: 0x38D8541 VA: 0x38D8440
	|-ReadOnlyCollection<Detail.DataStore.DataStoreMetaInfoInt>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x38D9550 Offset: 0x38D9651 VA: 0x38D9550
	|-ReadOnlyCollection<Detail.DataStore.DataStorePasswordInfoInt>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x38DA610 Offset: 0x38DA711 VA: 0x38DA610
	|-ReadOnlyCollection<Detail.DataStore.DataStorePersistenceInfoInt>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x38DB6E0 Offset: 0x38DB7E1 VA: 0x38DB6E0
	|-ReadOnlyCollection<Detail.DataStore.DataStorePreparePostParamInt>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x38DC750 Offset: 0x38DC851 VA: 0x38DC750
	|-ReadOnlyCollection<Detail.DataStore.DataStoreRateObjectParamInt>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x38DD7E0 Offset: 0x38DD8E1 VA: 0x38DD7E0
	|-ReadOnlyCollection<Detail.DataStore.DataStoreRatingInitParamInt>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x38DE800 Offset: 0x38DE901 VA: 0x38DE800
	|-ReadOnlyCollection<Detail.DataStore.DataStoreRatingTargetInt>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x38DF910 Offset: 0x38DFA11 VA: 0x38DF910
	|-ReadOnlyCollection<Detail.Ranking.RankingCachedResultInt>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x38E0980 Offset: 0x38E0A81 VA: 0x38E0980
	|-ReadOnlyCollection<Detail.Ranking.RankingOrderParamInt>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x38E1A90 Offset: 0x38E1B91 VA: 0x38E1A90
	|-ReadOnlyCollection<Detail.Ranking.RankingRankDataInt>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x38E2CA0 Offset: 0x38E2DA1 VA: 0x38E2CA0
	|-ReadOnlyCollection<Detail.Ranking2.Ranking2ChartInfoInt>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x38E3F30 Offset: 0x38E4031 VA: 0x38E3F30
	|-ReadOnlyCollection<Detail.Ranking2.Ranking2RankDataInt>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x38E4FA0 Offset: 0x38E50A1 VA: 0x38E4FA0
	|-ReadOnlyCollection<Detail.Ranking2.Ranking2ScoreDataInt>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x38E6030 Offset: 0x38E6131 VA: 0x38E6030
	|-ReadOnlyCollection<Detail.Screening.ScreeningContextInfoInt>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x38E71B0 Offset: 0x38E72B1 VA: 0x38E71B0
	|-ReadOnlyCollection<Detail.Subscriber.SubscriberContentInt>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x38E8340 Offset: 0x38E8441 VA: 0x38E8340
	|-ReadOnlyCollection<Detail.Subscriber.SubscriberGetContentParamInt>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x38E9440 Offset: 0x38E9541 VA: 0x38E9440
	|-ReadOnlyCollection<Detail.Subscriber.SubscriberUserStatusInfoInt>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x38EA520 Offset: 0x38EA621 VA: 0x38EA520
	|-ReadOnlyCollection<Detail.Subscriber.SubscriberUserStatusParamInt>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x38EB520 Offset: 0x38EB621 VA: 0x38EB520
	|-ReadOnlyCollection<Detail.Utility.IntegerSettings>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x38EC520 Offset: 0x38EC621 VA: 0x38EC520
	|-ReadOnlyCollection<Detail.Utility.UniqueIdInfoInt>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x38ED530 Offset: 0x38ED631 VA: 0x38ED530
	|-ReadOnlyCollection<MapHistory.Rewind.LatestInspectorData>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x38EE560 Offset: 0x38EE661 VA: 0x38EE560
	|-ReadOnlyCollection<MapHistory.Rewind.WorkTerrainData>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x38EF570 Offset: 0x38EF671 VA: 0x38EF570
	|-ReadOnlyCollection<MapSkill.AroundCalculator.Result>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x38F0640 Offset: 0x38F0741 VA: 0x38F0640
	|-ReadOnlyCollection<TargetPositionCache.CacheCurve.Item>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2FE5BE0 Offset: 0x2FE5CE1 VA: 0x2FE5BE0
	|-ReadOnlyCollection<TargetPositionCache.CacheEntry.RecordingItem>.System.Collections.ICollection.get_IsSynchronized
	*/

	// RVA: -1 Offset: -1 Slot: 30
	private object System.Collections.ICollection.get_SyncRoot() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3467A20 Offset: 0x3467B21 VA: 0x3467A20
	|-ReadOnlyCollection<IntervalTree.Entry<object>>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3468A40 Offset: 0x3468B41 VA: 0x3468A40
	|-ReadOnlyCollection<KeyValuePair<DateTime, object>>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3469A30 Offset: 0x3469B31 VA: 0x3469A30
	|-ReadOnlyCollection<KeyValuePair<int, object>>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x346AAC0 Offset: 0x346ABC1 VA: 0x346AAC0
	|-ReadOnlyCollection<KeyValuePair<object, ValueTuple<int, DateTime, object>>>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x346BAE0 Offset: 0x346BBE1 VA: 0x346BAE0
	|-ReadOnlyCollection<KeyValuePair<object, object>>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x346CB70 Offset: 0x346CC71 VA: 0x346CB70
	|-ReadOnlyCollection<CommonBattleSequence.Reliance<object>>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x346DB90 Offset: 0x346DC91 VA: 0x346DB90
	|-ReadOnlyCollection<RenderGraphResourcePool.ResourceLogInfo<object>>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x346EB80 Offset: 0x346EC81 VA: 0x346EB80
	|-ReadOnlyCollection<ValueTuple<int, object>>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x346FB50 Offset: 0x346FC51 VA: 0x346FB50
	|-ReadOnlyCollection<ValueTuple<Int32Enum, int>>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3470BF0 Offset: 0x3470CF1 VA: 0x3470BF0
	|-ReadOnlyCollection<ValueTuple<object, ValueTuple<object, int>>>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3471C10 Offset: 0x3471D11 VA: 0x3471C10
	|-ReadOnlyCollection<ValueTuple<object, int>>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3472C20 Offset: 0x3472D21 VA: 0x3472C20
	|-ReadOnlyCollection<ValueTuple<Vector3, float>>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3473C20 Offset: 0x3473D21 VA: 0x3473C20
	|-ReadOnlyCollection<ValueTuple<object, Int32Enum, int>>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3474CB0 Offset: 0x3474DB1 VA: 0x3474CB0
	|-ReadOnlyCollection<ValueTuple<object, int, int, int>>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3475CB0 Offset: 0x3475DB1 VA: 0x3475CB0
	|-ReadOnlyCollection<AnimatorClipInfo>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3B22AF0 Offset: 0x3B22BF1 VA: 0x3B22AF0
	|-ReadOnlyCollection<AsyncOperationHandle>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3B23BB0 Offset: 0x3B23CB1 VA: 0x3B23BB0
	|-ReadOnlyCollection<BoneWeight>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3B24BB0 Offset: 0x3B24CB1 VA: 0x3B24BB0
	|-ReadOnlyCollection<bool>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3B25BA0 Offset: 0x3B25CA1 VA: 0x3B25BA0
	|-ReadOnlyCollection<byte>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3B26BA0 Offset: 0x3B26CA1 VA: 0x3B26BA0
	|-ReadOnlyCollection<CameraInfo>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3B27B70 Offset: 0x3B27C71 VA: 0x3B27B70
	|-ReadOnlyCollection<char>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3B28B90 Offset: 0x3B28C91 VA: 0x3B28B90
	|-ReadOnlyCollection<Color>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3B29BB0 Offset: 0x3B29CB1 VA: 0x3B29BB0
	|-ReadOnlyCollection<Color32>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3B2ABB0 Offset: 0x3B2ACB1 VA: 0x3B2ABB0
	|-ReadOnlyCollection<ConstraintSource>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3B2BC40 Offset: 0x3B2BD41 VA: 0x3B2BC40
	|-ReadOnlyCollection<ContourVertex>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3B2CD00 Offset: 0x3B2CE01 VA: 0x3B2CD00
	|-ReadOnlyCollection<CustomAttributeNamedArgument>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3B2DD20 Offset: 0x3B2DE21 VA: 0x3B2DD20
	|-ReadOnlyCollection<CustomAttributeTypedArgument>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3B2EDB0 Offset: 0x3B2EEB1 VA: 0x3B2EDB0
	|-ReadOnlyCollection<DataStoreRatingInfo>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3B2FDB0 Offset: 0x3B2FEB1 VA: 0x3B2FDB0
	|-ReadOnlyCollection<DataStoreResult>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3B30D90 Offset: 0x3B30E91 VA: 0x3B30D90
	|-ReadOnlyCollection<DateTime>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3B31D90 Offset: 0x3B31E91 VA: 0x3B31D90
	|-ReadOnlyCollection<DateTimeOffset>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3B32D80 Offset: 0x3B32E81 VA: 0x3B32D80
	|-ReadOnlyCollection<Decimal>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3B33E50 Offset: 0x3B33F51 VA: 0x3B33E50
	|-ReadOnlyCollection<DiagnosticEvent>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3B34E80 Offset: 0x3B34F81 VA: 0x3B34E80
	|-ReadOnlyCollection<double>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3B35F70 Offset: 0x3B36071 VA: 0x3B35F70
	|-ReadOnlyCollection<Friend>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3B36FB0 Offset: 0x3B370B1 VA: 0x3B36FB0
	|-ReadOnlyCollection<GlyphRect>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3B37F80 Offset: 0x3B38081 VA: 0x3B37F80
	|-ReadOnlyCollection<short>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3B38F60 Offset: 0x3B39061 VA: 0x3B38F60
	|-ReadOnlyCollection<int>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3B39F40 Offset: 0x3B3A041 VA: 0x3B39F40
	|-ReadOnlyCollection<Int32Enum>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3B3AF20 Offset: 0x3B3B021 VA: 0x3B3AF20
	|-ReadOnlyCollection<long>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3B3BF00 Offset: 0x3B3C001 VA: 0x3B3BF00
	|-ReadOnlyCollection<IntPtr>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3B3CF00 Offset: 0x3B3D001 VA: 0x3B3CF00
	|-ReadOnlyCollection<InterpretedFrameInfo>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3B3DF90 Offset: 0x3B3E091 VA: 0x3B3DF90
	|-ReadOnlyCollection<IntervalTreeNode>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3B3EF90 Offset: 0x3B3F091 VA: 0x3B3EF90
	|-ReadOnlyCollection<LengthLimitProperties>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3B3FF70 Offset: 0x3B40071 VA: 0x3B3FF70
	|-ReadOnlyCollection<MapPos>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3B41090 Offset: 0x3B41191 VA: 0x3B41090
	|-ReadOnlyCollection<Matrix4x4>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3B420E0 Offset: 0x3B421E1 VA: 0x3B420E0
	|-ReadOnlyCollection<object>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3B430D0 Offset: 0x3B431D1 VA: 0x3B430D0
	|-ReadOnlyCollection<ObjectInitializationData>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3B441C0 Offset: 0x3B442C1 VA: 0x3B441C0
	|-ReadOnlyCollection<PlayableBinding>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3B452C0 Offset: 0x3B453C1 VA: 0x3B452C0
	|-ReadOnlyCollection<PlayerLoopSystem>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3B463E0 Offset: 0x3B464E1 VA: 0x3B463E0
	|-ReadOnlyCollection<PlayerLoopSystemInternal>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3B47420 Offset: 0x3B47521 VA: 0x3B47420
	|-ReadOnlyCollection<RangePositionInfo>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3B483F0 Offset: 0x3B484F1 VA: 0x3B483F0
	|-ReadOnlyCollection<Ranking2ChartInfoInput>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3B494F0 Offset: 0x3B495F1 VA: 0x3B494F0
	|-ReadOnlyCollection<RaycastHit2D>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3B4A6B0 Offset: 0x3B4A7B1 VA: 0x3B4A6B0
	|-ReadOnlyCollection<RaycastResult>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3B4B7C0 Offset: 0x3B4B8C1 VA: 0x3B4B7C0
	|-ReadOnlyCollection<Rect>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3B4C7A0 Offset: 0x3B4C8A1 VA: 0x3B4C7A0
	|-ReadOnlyCollection<RendererListHandle>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3B4D780 Offset: 0x3B4D881 VA: 0x3B4D780
	|-ReadOnlyCollection<ResourceHandle>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3AAEE40 Offset: 0x3AAEF41 VA: 0x3AAEE40
	|-ReadOnlyCollection<sbyte>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3AAFE60 Offset: 0x3AAFF61 VA: 0x3AAFE60
	|-ReadOnlyCollection<ShaderTagId>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3AB0E40 Offset: 0x3AB0F41 VA: 0x3AB0E40
	|-ReadOnlyCollection<float>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3AB2060 Offset: 0x3AB2161 VA: 0x3AB2060
	|-ReadOnlyCollection<SphericalHarmonicsL2>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3AB3310 Offset: 0x3AB3411 VA: 0x3AB3310
	|-ReadOnlyCollection<SubMeshDescriptor>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3AB4360 Offset: 0x3AB4461 VA: 0x3AB4360
	|-ReadOnlyCollection<TablePair>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3AB5330 Offset: 0x3AB5431 VA: 0x3AB5330
	|-ReadOnlyCollection<TimeSpan>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3AB6350 Offset: 0x3AB6451 VA: 0x3AB6350
	|-ReadOnlyCollection<UICharInfo>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3AB7350 Offset: 0x3AB7451 VA: 0x3AB7350
	|-ReadOnlyCollection<UILineInfo>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3AB8560 Offset: 0x3AB8661 VA: 0x3AB8560
	|-ReadOnlyCollection<UIVertex>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3AB9710 Offset: 0x3AB9811 VA: 0x3AB9710
	|-ReadOnlyCollection<ushort>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3ABA6F0 Offset: 0x3ABA7F1 VA: 0x3ABA6F0
	|-ReadOnlyCollection<uint>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3ABB6D0 Offset: 0x3ABB7D1 VA: 0x3ABB6D0
	|-ReadOnlyCollection<ulong>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3ABC6D0 Offset: 0x3ABC7D1 VA: 0x3ABC6D0
	|-ReadOnlyCollection<Vector2>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3ABD6F0 Offset: 0x3ABD7F1 VA: 0x3ABD6F0
	|-ReadOnlyCollection<Vector3>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3ABE710 Offset: 0x3ABE811 VA: 0x3ABE710
	|-ReadOnlyCollection<Vector4>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3ABF710 Offset: 0x3ABF811 VA: 0x3ABF710
	|-ReadOnlyCollection<VertexAttributeDescriptor>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3AC0700 Offset: 0x3AC0801 VA: 0x3AC0700
	|-ReadOnlyCollection<X509ChainStatus>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3AC17A0 Offset: 0x3AC18A1 VA: 0x3AC17A0
	|-ReadOnlyCollection<XRView>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3AC2830 Offset: 0x3AC2931 VA: 0x3AC2830
	|-ReadOnlyCollection<AICrossfire.PositionTable>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3AC3840 Offset: 0x3AC3941 VA: 0x3AC3840
	|-ReadOnlyCollection<AmiiboSequence.GainItemData>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3AC4910 Offset: 0x3AC4A11 VA: 0x3AC4910
	|-ReadOnlyCollection<AnimationOutputWeightProcessor.WeightInfo>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3AC5950 Offset: 0x3AC5A51 VA: 0x3AC5950
	|-ReadOnlyCollection<ArenaOrderSequence.GodInfo>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3AC6940 Offset: 0x3AC6A41 VA: 0x3AC6940
	|-ReadOnlyCollection<BattleInfo.SupportData>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3AC7930 Offset: 0x3AC7A31 VA: 0x3AC7930
	|-ReadOnlyCollection<BeforeRenderHelper.OrderBlock>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3AC89C0 Offset: 0x3AC8AC1 VA: 0x3AC89C0
	|-ReadOnlyCollection<Camera.RenderRequest>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3AC99E0 Offset: 0x3AC9AE1 VA: 0x3AC99E0
	|-ReadOnlyCollection<CameraState.CustomBlendable>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3ACA9B0 Offset: 0x3ACAAB1 VA: 0x3ACA9B0
	|-ReadOnlyCollection<CinemachineClearShot.Pair>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3ACB990 Offset: 0x3ACBA91 VA: 0x3ACB990
	|-ReadOnlyCollection<CinemachineStateDrivenCamera.HashPair>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3ACCA30 Offset: 0x3ACCB31 VA: 0x3ACCA30
	|-ReadOnlyCollection<DelayedActionManager.DelegateInfo>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3ACDB30 Offset: 0x3ACDC31 VA: 0x3ACDB30
	|-ReadOnlyCollection<Detail.AsyncResultInt>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3ACEB80 Offset: 0x3ACEC81 VA: 0x3ACEB80
	|-ReadOnlyCollection<Detail.CppArray>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3ACFC50 Offset: 0x3ACFD51 VA: 0x3ACFC50
	|-ReadOnlyCollection<Detail.NotificationEventInt>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3AD0CA0 Offset: 0x3AD0DA1 VA: 0x3AD0CA0
	|-ReadOnlyCollection<DragonRideTargetGroup.ChainParam>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3AD1D30 Offset: 0x3AD1E31 VA: 0x3AD1D30
	|-ReadOnlyCollection<GmapPathAdjuster.TargetModel>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3AD2DF0 Offset: 0x3AD2EF1 VA: 0x3AD2DF0
	|-ReadOnlyCollection<GmapSpotAdjuster.TargetModel>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3AD3EB0 Offset: 0x3AD3FB1 VA: 0x3AD3EB0
	|-ReadOnlyCollection<HubFastTravel.Location>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3AD4FB0 Offset: 0x3AD50B1 VA: 0x3AD4FB0
	|-ReadOnlyCollection<HubLensFlare.Flare>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3AD6000 Offset: 0x3AD6101 VA: 0x3AD6000
	|-ReadOnlyCollection<InventoryPoolItemMenuContent.KindBgNameClass>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3AD6FD0 Offset: 0x3AD70D1 VA: 0x3AD6FD0
	|-ReadOnlyCollection<Map.Pos>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3AD7FD0 Offset: 0x3AD80D1 VA: 0x3AD7FD0
	|-ReadOnlyCollection<MapImage.BackupTerrain>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3AD8FE0 Offset: 0x3AD90E1 VA: 0x3AD8FE0
	|-ReadOnlyCollection<MapImageRange.Pos>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3ADA080 Offset: 0x3ADA181 VA: 0x3ADA080
	|-ReadOnlyCollection<MapMind.Target>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x38C4A60 Offset: 0x38C4B61 VA: 0x38C4A60
	|-ReadOnlyCollection<MapPanelDebug.Entity>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x38C5A60 Offset: 0x38C5B61 VA: 0x38C5A60
	|-ReadOnlyCollection<NexRanking.Data>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x38C6A60 Offset: 0x38C6B61 VA: 0x38C6A60
	|-ReadOnlyCollection<NexVersus.RatingData>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x38C7A50 Offset: 0x38C7B51 VA: 0x38C7A50
	|-ReadOnlyCollection<PackedPlayModeBuildLogs.RuntimeBuildLog>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x38C8AF0 Offset: 0x38C8BF1 VA: 0x38C8AF0
	|-ReadOnlyCollection<ParticleSystem.Particle>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x38C9B40 Offset: 0x38C9C41 VA: 0x38C9B40
	|-ReadOnlyCollection<RangeData.Offset>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x38CABE0 Offset: 0x38CACE1 VA: 0x38CABE0
	|-ReadOnlyCollection<RenderGraphDebugData.PassDebugData>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x38CBCE0 Offset: 0x38CBDE1 VA: 0x38CBCE0
	|-ReadOnlyCollection<RenderGraphDebugData.ResourceDebugData>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x38CCD20 Offset: 0x38CCE21 VA: 0x38CCD20
	|-ReadOnlyCollection<RingCleaningUnitSelectMenu.GodParam>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x38CDDF0 Offset: 0x38CDEF1 VA: 0x38CDDF0
	|-ReadOnlyCollection<ShadowUtility.Edge>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x38CEE60 Offset: 0x38CEF61 VA: 0x38CEE60
	|-ReadOnlyCollection<SkillArray.Entity>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x38CFF80 Offset: 0x38D0081 VA: 0x38CFF80
	|-ReadOnlyCollection<TexturePacker_JsonArray.Frame>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x38D1090 Offset: 0x38D1191 VA: 0x38D1090
	|-ReadOnlyCollection<TimeNotificationBehaviour.NotificationEntry>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x38D2150 Offset: 0x38D2251 VA: 0x38D2150
	|-ReadOnlyCollection<UnitySynchronizationContext.WorkRequest>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x38D3170 Offset: 0x38D3271 VA: 0x38D3170
	|-ReadOnlyCollection<XmlSchemaObjectTable.XmlSchemaObjectEntry>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x38D4160 Offset: 0x38D4261 VA: 0x38D4160
	|-ReadOnlyCollection<AssetBundleBuildMap.AssetBundleEntry.AssetPathString>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x38D5220 Offset: 0x38D5321 VA: 0x38D5220
	|-ReadOnlyCollection<Detail.DataStore.DataStoreChangeMetaParamInt>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x38D6290 Offset: 0x38D6391 VA: 0x38D6290
	|-ReadOnlyCollection<Detail.DataStore.DataStoreDeleteParamInt>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x38D7360 Offset: 0x38D7461 VA: 0x38D7360
	|-ReadOnlyCollection<Detail.DataStore.DataStoreGetMetaParamInt>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x38D8450 Offset: 0x38D8551 VA: 0x38D8450
	|-ReadOnlyCollection<Detail.DataStore.DataStoreMetaInfoInt>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x38D9560 Offset: 0x38D9661 VA: 0x38D9560
	|-ReadOnlyCollection<Detail.DataStore.DataStorePasswordInfoInt>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x38DA620 Offset: 0x38DA721 VA: 0x38DA620
	|-ReadOnlyCollection<Detail.DataStore.DataStorePersistenceInfoInt>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x38DB6F0 Offset: 0x38DB7F1 VA: 0x38DB6F0
	|-ReadOnlyCollection<Detail.DataStore.DataStorePreparePostParamInt>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x38DC760 Offset: 0x38DC861 VA: 0x38DC760
	|-ReadOnlyCollection<Detail.DataStore.DataStoreRateObjectParamInt>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x38DD7F0 Offset: 0x38DD8F1 VA: 0x38DD7F0
	|-ReadOnlyCollection<Detail.DataStore.DataStoreRatingInitParamInt>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x38DE810 Offset: 0x38DE911 VA: 0x38DE810
	|-ReadOnlyCollection<Detail.DataStore.DataStoreRatingTargetInt>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x38DF920 Offset: 0x38DFA21 VA: 0x38DF920
	|-ReadOnlyCollection<Detail.Ranking.RankingCachedResultInt>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x38E0990 Offset: 0x38E0A91 VA: 0x38E0990
	|-ReadOnlyCollection<Detail.Ranking.RankingOrderParamInt>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x38E1AA0 Offset: 0x38E1BA1 VA: 0x38E1AA0
	|-ReadOnlyCollection<Detail.Ranking.RankingRankDataInt>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x38E2CB0 Offset: 0x38E2DB1 VA: 0x38E2CB0
	|-ReadOnlyCollection<Detail.Ranking2.Ranking2ChartInfoInt>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x38E3F40 Offset: 0x38E4041 VA: 0x38E3F40
	|-ReadOnlyCollection<Detail.Ranking2.Ranking2RankDataInt>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x38E4FB0 Offset: 0x38E50B1 VA: 0x38E4FB0
	|-ReadOnlyCollection<Detail.Ranking2.Ranking2ScoreDataInt>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x38E6040 Offset: 0x38E6141 VA: 0x38E6040
	|-ReadOnlyCollection<Detail.Screening.ScreeningContextInfoInt>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x38E71C0 Offset: 0x38E72C1 VA: 0x38E71C0
	|-ReadOnlyCollection<Detail.Subscriber.SubscriberContentInt>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x38E8350 Offset: 0x38E8451 VA: 0x38E8350
	|-ReadOnlyCollection<Detail.Subscriber.SubscriberGetContentParamInt>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x38E9450 Offset: 0x38E9551 VA: 0x38E9450
	|-ReadOnlyCollection<Detail.Subscriber.SubscriberUserStatusInfoInt>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x38EA530 Offset: 0x38EA631 VA: 0x38EA530
	|-ReadOnlyCollection<Detail.Subscriber.SubscriberUserStatusParamInt>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x38EB530 Offset: 0x38EB631 VA: 0x38EB530
	|-ReadOnlyCollection<Detail.Utility.IntegerSettings>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x38EC530 Offset: 0x38EC631 VA: 0x38EC530
	|-ReadOnlyCollection<Detail.Utility.UniqueIdInfoInt>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x38ED540 Offset: 0x38ED641 VA: 0x38ED540
	|-ReadOnlyCollection<MapHistory.Rewind.LatestInspectorData>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x38EE570 Offset: 0x38EE671 VA: 0x38EE570
	|-ReadOnlyCollection<MapHistory.Rewind.WorkTerrainData>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x38EF580 Offset: 0x38EF681 VA: 0x38EF580
	|-ReadOnlyCollection<MapSkill.AroundCalculator.Result>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x38F0650 Offset: 0x38F0751 VA: 0x38F0650
	|-ReadOnlyCollection<TargetPositionCache.CacheCurve.Item>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2FE5BF0 Offset: 0x2FE5CF1 VA: 0x2FE5BF0
	|-ReadOnlyCollection<TargetPositionCache.CacheEntry.RecordingItem>.System.Collections.ICollection.get_SyncRoot
	*/

	// RVA: -1 Offset: -1 Slot: 28
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3467B40 Offset: 0x3467C41 VA: 0x3467B40
	|-ReadOnlyCollection<IntervalTree.Entry<object>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3468B60 Offset: 0x3468C61 VA: 0x3468B60
	|-ReadOnlyCollection<KeyValuePair<DateTime, object>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3469B50 Offset: 0x3469C51 VA: 0x3469B50
	|-ReadOnlyCollection<KeyValuePair<int, object>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x346ABE0 Offset: 0x346ACE1 VA: 0x346ABE0
	|-ReadOnlyCollection<KeyValuePair<object, ValueTuple<int, DateTime, object>>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x346BC00 Offset: 0x346BD01 VA: 0x346BC00
	|-ReadOnlyCollection<KeyValuePair<object, object>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x346CC90 Offset: 0x346CD91 VA: 0x346CC90
	|-ReadOnlyCollection<CommonBattleSequence.Reliance<object>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x346DCB0 Offset: 0x346DDB1 VA: 0x346DCB0
	|-ReadOnlyCollection<RenderGraphResourcePool.ResourceLogInfo<object>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x346ECA0 Offset: 0x346EDA1 VA: 0x346ECA0
	|-ReadOnlyCollection<ValueTuple<int, object>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x346FC70 Offset: 0x346FD71 VA: 0x346FC70
	|-ReadOnlyCollection<ValueTuple<Int32Enum, int>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3470D10 Offset: 0x3470E11 VA: 0x3470D10
	|-ReadOnlyCollection<ValueTuple<object, ValueTuple<object, int>>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3471D30 Offset: 0x3471E31 VA: 0x3471D30
	|-ReadOnlyCollection<ValueTuple<object, int>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3472D40 Offset: 0x3472E41 VA: 0x3472D40
	|-ReadOnlyCollection<ValueTuple<Vector3, float>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3473D40 Offset: 0x3473E41 VA: 0x3473D40
	|-ReadOnlyCollection<ValueTuple<object, Int32Enum, int>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3474DD0 Offset: 0x3474ED1 VA: 0x3474DD0
	|-ReadOnlyCollection<ValueTuple<object, int, int, int>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3475DD0 Offset: 0x3475ED1 VA: 0x3475DD0
	|-ReadOnlyCollection<AnimatorClipInfo>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3B22C10 Offset: 0x3B22D11 VA: 0x3B22C10
	|-ReadOnlyCollection<AsyncOperationHandle>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3B23CD0 Offset: 0x3B23DD1 VA: 0x3B23CD0
	|-ReadOnlyCollection<BoneWeight>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3B24CD0 Offset: 0x3B24DD1 VA: 0x3B24CD0
	|-ReadOnlyCollection<bool>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3B25CC0 Offset: 0x3B25DC1 VA: 0x3B25CC0
	|-ReadOnlyCollection<byte>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3B26CC0 Offset: 0x3B26DC1 VA: 0x3B26CC0
	|-ReadOnlyCollection<CameraInfo>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3B27C90 Offset: 0x3B27D91 VA: 0x3B27C90
	|-ReadOnlyCollection<char>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3B28CB0 Offset: 0x3B28DB1 VA: 0x3B28CB0
	|-ReadOnlyCollection<Color>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3B29CD0 Offset: 0x3B29DD1 VA: 0x3B29CD0
	|-ReadOnlyCollection<Color32>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3B2ACD0 Offset: 0x3B2ADD1 VA: 0x3B2ACD0
	|-ReadOnlyCollection<ConstraintSource>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3B2BD60 Offset: 0x3B2BE61 VA: 0x3B2BD60
	|-ReadOnlyCollection<ContourVertex>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3B2CE20 Offset: 0x3B2CF21 VA: 0x3B2CE20
	|-ReadOnlyCollection<CustomAttributeNamedArgument>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3B2DE40 Offset: 0x3B2DF41 VA: 0x3B2DE40
	|-ReadOnlyCollection<CustomAttributeTypedArgument>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3B2EED0 Offset: 0x3B2EFD1 VA: 0x3B2EED0
	|-ReadOnlyCollection<DataStoreRatingInfo>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3B2FED0 Offset: 0x3B2FFD1 VA: 0x3B2FED0
	|-ReadOnlyCollection<DataStoreResult>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3B30EB0 Offset: 0x3B30FB1 VA: 0x3B30EB0
	|-ReadOnlyCollection<DateTime>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3B31EB0 Offset: 0x3B31FB1 VA: 0x3B31EB0
	|-ReadOnlyCollection<DateTimeOffset>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3B32EA0 Offset: 0x3B32FA1 VA: 0x3B32EA0
	|-ReadOnlyCollection<Decimal>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3B33F70 Offset: 0x3B34071 VA: 0x3B33F70
	|-ReadOnlyCollection<DiagnosticEvent>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3B34FA0 Offset: 0x3B350A1 VA: 0x3B34FA0
	|-ReadOnlyCollection<double>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3B36090 Offset: 0x3B36191 VA: 0x3B36090
	|-ReadOnlyCollection<Friend>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3B370D0 Offset: 0x3B371D1 VA: 0x3B370D0
	|-ReadOnlyCollection<GlyphRect>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3B380A0 Offset: 0x3B381A1 VA: 0x3B380A0
	|-ReadOnlyCollection<short>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3B39080 Offset: 0x3B39181 VA: 0x3B39080
	|-ReadOnlyCollection<int>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3B3A060 Offset: 0x3B3A161 VA: 0x3B3A060
	|-ReadOnlyCollection<Int32Enum>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3B3B040 Offset: 0x3B3B141 VA: 0x3B3B040
	|-ReadOnlyCollection<long>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3B3C020 Offset: 0x3B3C121 VA: 0x3B3C020
	|-ReadOnlyCollection<IntPtr>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3B3D020 Offset: 0x3B3D121 VA: 0x3B3D020
	|-ReadOnlyCollection<InterpretedFrameInfo>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3B3E0B0 Offset: 0x3B3E1B1 VA: 0x3B3E0B0
	|-ReadOnlyCollection<IntervalTreeNode>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3B3F0B0 Offset: 0x3B3F1B1 VA: 0x3B3F0B0
	|-ReadOnlyCollection<LengthLimitProperties>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3B40090 Offset: 0x3B40191 VA: 0x3B40090
	|-ReadOnlyCollection<MapPos>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3B411B0 Offset: 0x3B412B1 VA: 0x3B411B0
	|-ReadOnlyCollection<Matrix4x4>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3B42200 Offset: 0x3B42301 VA: 0x3B42200
	|-ReadOnlyCollection<object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3B431F0 Offset: 0x3B432F1 VA: 0x3B431F0
	|-ReadOnlyCollection<ObjectInitializationData>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3B442E0 Offset: 0x3B443E1 VA: 0x3B442E0
	|-ReadOnlyCollection<PlayableBinding>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3B453E0 Offset: 0x3B454E1 VA: 0x3B453E0
	|-ReadOnlyCollection<PlayerLoopSystem>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3B46500 Offset: 0x3B46601 VA: 0x3B46500
	|-ReadOnlyCollection<PlayerLoopSystemInternal>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3B47540 Offset: 0x3B47641 VA: 0x3B47540
	|-ReadOnlyCollection<RangePositionInfo>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3B48510 Offset: 0x3B48611 VA: 0x3B48510
	|-ReadOnlyCollection<Ranking2ChartInfoInput>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3B49610 Offset: 0x3B49711 VA: 0x3B49610
	|-ReadOnlyCollection<RaycastHit2D>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3B4A7D0 Offset: 0x3B4A8D1 VA: 0x3B4A7D0
	|-ReadOnlyCollection<RaycastResult>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3B4B8E0 Offset: 0x3B4B9E1 VA: 0x3B4B8E0
	|-ReadOnlyCollection<Rect>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3B4C8C0 Offset: 0x3B4C9C1 VA: 0x3B4C8C0
	|-ReadOnlyCollection<RendererListHandle>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3B4D8A0 Offset: 0x3B4D9A1 VA: 0x3B4D8A0
	|-ReadOnlyCollection<ResourceHandle>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3AAEF60 Offset: 0x3AAF061 VA: 0x3AAEF60
	|-ReadOnlyCollection<sbyte>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3AAFF80 Offset: 0x3AB0081 VA: 0x3AAFF80
	|-ReadOnlyCollection<ShaderTagId>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3AB0F60 Offset: 0x3AB1061 VA: 0x3AB0F60
	|-ReadOnlyCollection<float>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3AB2180 Offset: 0x3AB2281 VA: 0x3AB2180
	|-ReadOnlyCollection<SphericalHarmonicsL2>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3AB3430 Offset: 0x3AB3531 VA: 0x3AB3430
	|-ReadOnlyCollection<SubMeshDescriptor>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3AB4480 Offset: 0x3AB4581 VA: 0x3AB4480
	|-ReadOnlyCollection<TablePair>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3AB5450 Offset: 0x3AB5551 VA: 0x3AB5450
	|-ReadOnlyCollection<TimeSpan>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3AB6470 Offset: 0x3AB6571 VA: 0x3AB6470
	|-ReadOnlyCollection<UICharInfo>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3AB7470 Offset: 0x3AB7571 VA: 0x3AB7470
	|-ReadOnlyCollection<UILineInfo>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3AB8680 Offset: 0x3AB8781 VA: 0x3AB8680
	|-ReadOnlyCollection<UIVertex>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3AB9830 Offset: 0x3AB9931 VA: 0x3AB9830
	|-ReadOnlyCollection<ushort>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3ABA810 Offset: 0x3ABA911 VA: 0x3ABA810
	|-ReadOnlyCollection<uint>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3ABB7F0 Offset: 0x3ABB8F1 VA: 0x3ABB7F0
	|-ReadOnlyCollection<ulong>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3ABC7F0 Offset: 0x3ABC8F1 VA: 0x3ABC7F0
	|-ReadOnlyCollection<Vector2>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3ABD810 Offset: 0x3ABD911 VA: 0x3ABD810
	|-ReadOnlyCollection<Vector3>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3ABE830 Offset: 0x3ABE931 VA: 0x3ABE830
	|-ReadOnlyCollection<Vector4>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3ABF830 Offset: 0x3ABF931 VA: 0x3ABF830
	|-ReadOnlyCollection<VertexAttributeDescriptor>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3AC0820 Offset: 0x3AC0921 VA: 0x3AC0820
	|-ReadOnlyCollection<X509ChainStatus>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3AC18C0 Offset: 0x3AC19C1 VA: 0x3AC18C0
	|-ReadOnlyCollection<XRView>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3AC2950 Offset: 0x3AC2A51 VA: 0x3AC2950
	|-ReadOnlyCollection<AICrossfire.PositionTable>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3AC3960 Offset: 0x3AC3A61 VA: 0x3AC3960
	|-ReadOnlyCollection<AmiiboSequence.GainItemData>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3AC4A30 Offset: 0x3AC4B31 VA: 0x3AC4A30
	|-ReadOnlyCollection<AnimationOutputWeightProcessor.WeightInfo>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3AC5A70 Offset: 0x3AC5B71 VA: 0x3AC5A70
	|-ReadOnlyCollection<ArenaOrderSequence.GodInfo>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3AC6A60 Offset: 0x3AC6B61 VA: 0x3AC6A60
	|-ReadOnlyCollection<BattleInfo.SupportData>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3AC7A50 Offset: 0x3AC7B51 VA: 0x3AC7A50
	|-ReadOnlyCollection<BeforeRenderHelper.OrderBlock>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3AC8AE0 Offset: 0x3AC8BE1 VA: 0x3AC8AE0
	|-ReadOnlyCollection<Camera.RenderRequest>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3AC9B00 Offset: 0x3AC9C01 VA: 0x3AC9B00
	|-ReadOnlyCollection<CameraState.CustomBlendable>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3ACAAD0 Offset: 0x3ACABD1 VA: 0x3ACAAD0
	|-ReadOnlyCollection<CinemachineClearShot.Pair>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3ACBAB0 Offset: 0x3ACBBB1 VA: 0x3ACBAB0
	|-ReadOnlyCollection<CinemachineStateDrivenCamera.HashPair>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3ACCB50 Offset: 0x3ACCC51 VA: 0x3ACCB50
	|-ReadOnlyCollection<DelayedActionManager.DelegateInfo>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3ACDC50 Offset: 0x3ACDD51 VA: 0x3ACDC50
	|-ReadOnlyCollection<Detail.AsyncResultInt>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3ACECA0 Offset: 0x3ACEDA1 VA: 0x3ACECA0
	|-ReadOnlyCollection<Detail.CppArray>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3ACFD70 Offset: 0x3ACFE71 VA: 0x3ACFD70
	|-ReadOnlyCollection<Detail.NotificationEventInt>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3AD0DC0 Offset: 0x3AD0EC1 VA: 0x3AD0DC0
	|-ReadOnlyCollection<DragonRideTargetGroup.ChainParam>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3AD1E50 Offset: 0x3AD1F51 VA: 0x3AD1E50
	|-ReadOnlyCollection<GmapPathAdjuster.TargetModel>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3AD2F10 Offset: 0x3AD3011 VA: 0x3AD2F10
	|-ReadOnlyCollection<GmapSpotAdjuster.TargetModel>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3AD3FD0 Offset: 0x3AD40D1 VA: 0x3AD3FD0
	|-ReadOnlyCollection<HubFastTravel.Location>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3AD50D0 Offset: 0x3AD51D1 VA: 0x3AD50D0
	|-ReadOnlyCollection<HubLensFlare.Flare>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3AD6120 Offset: 0x3AD6221 VA: 0x3AD6120
	|-ReadOnlyCollection<InventoryPoolItemMenuContent.KindBgNameClass>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3AD70F0 Offset: 0x3AD71F1 VA: 0x3AD70F0
	|-ReadOnlyCollection<Map.Pos>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3AD80F0 Offset: 0x3AD81F1 VA: 0x3AD80F0
	|-ReadOnlyCollection<MapImage.BackupTerrain>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3AD9100 Offset: 0x3AD9201 VA: 0x3AD9100
	|-ReadOnlyCollection<MapImageRange.Pos>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3ADA1A0 Offset: 0x3ADA2A1 VA: 0x3ADA1A0
	|-ReadOnlyCollection<MapMind.Target>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x38C4B80 Offset: 0x38C4C81 VA: 0x38C4B80
	|-ReadOnlyCollection<MapPanelDebug.Entity>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x38C5B80 Offset: 0x38C5C81 VA: 0x38C5B80
	|-ReadOnlyCollection<NexRanking.Data>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x38C6B80 Offset: 0x38C6C81 VA: 0x38C6B80
	|-ReadOnlyCollection<NexVersus.RatingData>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x38C7B70 Offset: 0x38C7C71 VA: 0x38C7B70
	|-ReadOnlyCollection<PackedPlayModeBuildLogs.RuntimeBuildLog>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x38C8C10 Offset: 0x38C8D11 VA: 0x38C8C10
	|-ReadOnlyCollection<ParticleSystem.Particle>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x38C9C60 Offset: 0x38C9D61 VA: 0x38C9C60
	|-ReadOnlyCollection<RangeData.Offset>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x38CAD00 Offset: 0x38CAE01 VA: 0x38CAD00
	|-ReadOnlyCollection<RenderGraphDebugData.PassDebugData>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x38CBE00 Offset: 0x38CBF01 VA: 0x38CBE00
	|-ReadOnlyCollection<RenderGraphDebugData.ResourceDebugData>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x38CCE40 Offset: 0x38CCF41 VA: 0x38CCE40
	|-ReadOnlyCollection<RingCleaningUnitSelectMenu.GodParam>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x38CDF10 Offset: 0x38CE011 VA: 0x38CDF10
	|-ReadOnlyCollection<ShadowUtility.Edge>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x38CEF80 Offset: 0x38CF081 VA: 0x38CEF80
	|-ReadOnlyCollection<SkillArray.Entity>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x38D00A0 Offset: 0x38D01A1 VA: 0x38D00A0
	|-ReadOnlyCollection<TexturePacker_JsonArray.Frame>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x38D11B0 Offset: 0x38D12B1 VA: 0x38D11B0
	|-ReadOnlyCollection<TimeNotificationBehaviour.NotificationEntry>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x38D2270 Offset: 0x38D2371 VA: 0x38D2270
	|-ReadOnlyCollection<UnitySynchronizationContext.WorkRequest>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x38D3290 Offset: 0x38D3391 VA: 0x38D3290
	|-ReadOnlyCollection<XmlSchemaObjectTable.XmlSchemaObjectEntry>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x38D4280 Offset: 0x38D4381 VA: 0x38D4280
	|-ReadOnlyCollection<AssetBundleBuildMap.AssetBundleEntry.AssetPathString>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x38D5340 Offset: 0x38D5441 VA: 0x38D5340
	|-ReadOnlyCollection<Detail.DataStore.DataStoreChangeMetaParamInt>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x38D63B0 Offset: 0x38D64B1 VA: 0x38D63B0
	|-ReadOnlyCollection<Detail.DataStore.DataStoreDeleteParamInt>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x38D7480 Offset: 0x38D7581 VA: 0x38D7480
	|-ReadOnlyCollection<Detail.DataStore.DataStoreGetMetaParamInt>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x38D8570 Offset: 0x38D8671 VA: 0x38D8570
	|-ReadOnlyCollection<Detail.DataStore.DataStoreMetaInfoInt>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x38D9680 Offset: 0x38D9781 VA: 0x38D9680
	|-ReadOnlyCollection<Detail.DataStore.DataStorePasswordInfoInt>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x38DA740 Offset: 0x38DA841 VA: 0x38DA740
	|-ReadOnlyCollection<Detail.DataStore.DataStorePersistenceInfoInt>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x38DB810 Offset: 0x38DB911 VA: 0x38DB810
	|-ReadOnlyCollection<Detail.DataStore.DataStorePreparePostParamInt>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x38DC880 Offset: 0x38DC981 VA: 0x38DC880
	|-ReadOnlyCollection<Detail.DataStore.DataStoreRateObjectParamInt>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x38DD910 Offset: 0x38DDA11 VA: 0x38DD910
	|-ReadOnlyCollection<Detail.DataStore.DataStoreRatingInitParamInt>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x38DE930 Offset: 0x38DEA31 VA: 0x38DE930
	|-ReadOnlyCollection<Detail.DataStore.DataStoreRatingTargetInt>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x38DFA40 Offset: 0x38DFB41 VA: 0x38DFA40
	|-ReadOnlyCollection<Detail.Ranking.RankingCachedResultInt>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x38E0AB0 Offset: 0x38E0BB1 VA: 0x38E0AB0
	|-ReadOnlyCollection<Detail.Ranking.RankingOrderParamInt>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x38E1BC0 Offset: 0x38E1CC1 VA: 0x38E1BC0
	|-ReadOnlyCollection<Detail.Ranking.RankingRankDataInt>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x38E2DD0 Offset: 0x38E2ED1 VA: 0x38E2DD0
	|-ReadOnlyCollection<Detail.Ranking2.Ranking2ChartInfoInt>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x38E4060 Offset: 0x38E4161 VA: 0x38E4060
	|-ReadOnlyCollection<Detail.Ranking2.Ranking2RankDataInt>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x38E50D0 Offset: 0x38E51D1 VA: 0x38E50D0
	|-ReadOnlyCollection<Detail.Ranking2.Ranking2ScoreDataInt>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x38E6160 Offset: 0x38E6261 VA: 0x38E6160
	|-ReadOnlyCollection<Detail.Screening.ScreeningContextInfoInt>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x38E72E0 Offset: 0x38E73E1 VA: 0x38E72E0
	|-ReadOnlyCollection<Detail.Subscriber.SubscriberContentInt>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x38E8470 Offset: 0x38E8571 VA: 0x38E8470
	|-ReadOnlyCollection<Detail.Subscriber.SubscriberGetContentParamInt>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x38E9570 Offset: 0x38E9671 VA: 0x38E9570
	|-ReadOnlyCollection<Detail.Subscriber.SubscriberUserStatusInfoInt>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x38EA650 Offset: 0x38EA751 VA: 0x38EA650
	|-ReadOnlyCollection<Detail.Subscriber.SubscriberUserStatusParamInt>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x38EB650 Offset: 0x38EB751 VA: 0x38EB650
	|-ReadOnlyCollection<Detail.Utility.IntegerSettings>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x38EC650 Offset: 0x38EC751 VA: 0x38EC650
	|-ReadOnlyCollection<Detail.Utility.UniqueIdInfoInt>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x38ED660 Offset: 0x38ED761 VA: 0x38ED660
	|-ReadOnlyCollection<MapHistory.Rewind.LatestInspectorData>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x38EE690 Offset: 0x38EE791 VA: 0x38EE690
	|-ReadOnlyCollection<MapHistory.Rewind.WorkTerrainData>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x38EF6A0 Offset: 0x38EF7A1 VA: 0x38EF6A0
	|-ReadOnlyCollection<MapSkill.AroundCalculator.Result>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x38F0770 Offset: 0x38F0871 VA: 0x38F0770
	|-ReadOnlyCollection<TargetPositionCache.CacheCurve.Item>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2FE5D10 Offset: 0x2FE5E11 VA: 0x2FE5D10
	|-ReadOnlyCollection<TargetPositionCache.CacheEntry.RecordingItem>.System.Collections.ICollection.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 23
	private bool System.Collections.IList.get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3468020 Offset: 0x3468121 VA: 0x3468020
	|-ReadOnlyCollection<IntervalTree.Entry<object>>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3469020 Offset: 0x3469121 VA: 0x3469020
	|-ReadOnlyCollection<KeyValuePair<DateTime, object>>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x346A010 Offset: 0x346A111 VA: 0x346A010
	|-ReadOnlyCollection<KeyValuePair<int, object>>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x346B0C0 Offset: 0x346B1C1 VA: 0x346B0C0
	|-ReadOnlyCollection<KeyValuePair<object, ValueTuple<int, DateTime, object>>>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x346C0C0 Offset: 0x346C1C1 VA: 0x346C0C0
	|-ReadOnlyCollection<KeyValuePair<object, object>>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x346D170 Offset: 0x346D271 VA: 0x346D170
	|-ReadOnlyCollection<CommonBattleSequence.Reliance<object>>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x346E170 Offset: 0x346E271 VA: 0x346E170
	|-ReadOnlyCollection<RenderGraphResourcePool.ResourceLogInfo<object>>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x346F160 Offset: 0x346F261 VA: 0x346F160
	|-ReadOnlyCollection<ValueTuple<int, object>>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3470130 Offset: 0x3470231 VA: 0x3470130
	|-ReadOnlyCollection<ValueTuple<Int32Enum, int>>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x34711F0 Offset: 0x34712F1 VA: 0x34711F0
	|-ReadOnlyCollection<ValueTuple<object, ValueTuple<object, int>>>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x34721F0 Offset: 0x34722F1 VA: 0x34721F0
	|-ReadOnlyCollection<ValueTuple<object, int>>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3473210 Offset: 0x3473311 VA: 0x3473210
	|-ReadOnlyCollection<ValueTuple<Vector3, float>>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3474200 Offset: 0x3474301 VA: 0x3474200
	|-ReadOnlyCollection<ValueTuple<object, Int32Enum, int>>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x34752B0 Offset: 0x34753B1 VA: 0x34752B0
	|-ReadOnlyCollection<ValueTuple<object, int, int, int>>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3476290 Offset: 0x3476391 VA: 0x3476290
	|-ReadOnlyCollection<AnimatorClipInfo>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3B230F0 Offset: 0x3B231F1 VA: 0x3B230F0
	|-ReadOnlyCollection<AsyncOperationHandle>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3B241B0 Offset: 0x3B242B1 VA: 0x3B241B0
	|-ReadOnlyCollection<BoneWeight>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3B251A0 Offset: 0x3B252A1 VA: 0x3B251A0
	|-ReadOnlyCollection<bool>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3B26180 Offset: 0x3B26281 VA: 0x3B26180
	|-ReadOnlyCollection<byte>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3B27180 Offset: 0x3B27281 VA: 0x3B27180
	|-ReadOnlyCollection<CameraInfo>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3B28150 Offset: 0x3B28251 VA: 0x3B28150
	|-ReadOnlyCollection<char>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3B29180 Offset: 0x3B29281 VA: 0x3B29180
	|-ReadOnlyCollection<Color>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3B2A190 Offset: 0x3B2A291 VA: 0x3B2A190
	|-ReadOnlyCollection<Color32>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3B2B190 Offset: 0x3B2B291 VA: 0x3B2B190
	|-ReadOnlyCollection<ConstraintSource>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3B2C240 Offset: 0x3B2C341 VA: 0x3B2C240
	|-ReadOnlyCollection<ContourVertex>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3B2D300 Offset: 0x3B2D401 VA: 0x3B2D300
	|-ReadOnlyCollection<CustomAttributeNamedArgument>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3B2E300 Offset: 0x3B2E401 VA: 0x3B2E300
	|-ReadOnlyCollection<CustomAttributeTypedArgument>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3B2F3B0 Offset: 0x3B2F4B1 VA: 0x3B2F3B0
	|-ReadOnlyCollection<DataStoreRatingInfo>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3B30390 Offset: 0x3B30491 VA: 0x3B30390
	|-ReadOnlyCollection<DataStoreResult>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3B31370 Offset: 0x3B31471 VA: 0x3B31370
	|-ReadOnlyCollection<DateTime>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3B32370 Offset: 0x3B32471 VA: 0x3B32370
	|-ReadOnlyCollection<DateTimeOffset>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3B33360 Offset: 0x3B33461 VA: 0x3B33360
	|-ReadOnlyCollection<Decimal>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3B34460 Offset: 0x3B34561 VA: 0x3B34460
	|-ReadOnlyCollection<DiagnosticEvent>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3B35460 Offset: 0x3B35561 VA: 0x3B35460
	|-ReadOnlyCollection<double>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3B36580 Offset: 0x3B36681 VA: 0x3B36580
	|-ReadOnlyCollection<Friend>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3B37590 Offset: 0x3B37691 VA: 0x3B37590
	|-ReadOnlyCollection<GlyphRect>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3B38560 Offset: 0x3B38661 VA: 0x3B38560
	|-ReadOnlyCollection<short>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3B39540 Offset: 0x3B39641 VA: 0x3B39540
	|-ReadOnlyCollection<int>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3B3A520 Offset: 0x3B3A621 VA: 0x3B3A520
	|-ReadOnlyCollection<Int32Enum>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3B3B500 Offset: 0x3B3B601 VA: 0x3B3B500
	|-ReadOnlyCollection<long>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3B3C4E0 Offset: 0x3B3C5E1 VA: 0x3B3C4E0
	|-ReadOnlyCollection<IntPtr>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3B3D4E0 Offset: 0x3B3D5E1 VA: 0x3B3D4E0
	|-ReadOnlyCollection<InterpretedFrameInfo>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3B3E590 Offset: 0x3B3E691 VA: 0x3B3E590
	|-ReadOnlyCollection<IntervalTreeNode>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3B3F570 Offset: 0x3B3F671 VA: 0x3B3F570
	|-ReadOnlyCollection<LengthLimitProperties>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3B40550 Offset: 0x3B40651 VA: 0x3B40550
	|-ReadOnlyCollection<MapPos>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3B416A0 Offset: 0x3B417A1 VA: 0x3B416A0
	|-ReadOnlyCollection<Matrix4x4>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3B426A0 Offset: 0x3B427A1 VA: 0x3B426A0
	|-ReadOnlyCollection<object>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3B436E0 Offset: 0x3B437E1 VA: 0x3B436E0
	|-ReadOnlyCollection<ObjectInitializationData>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3B447C0 Offset: 0x3B448C1 VA: 0x3B447C0
	|-ReadOnlyCollection<PlayableBinding>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3B458C0 Offset: 0x3B459C1 VA: 0x3B458C0
	|-ReadOnlyCollection<PlayerLoopSystem>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3B469E0 Offset: 0x3B46AE1 VA: 0x3B469E0
	|-ReadOnlyCollection<PlayerLoopSystemInternal>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3B47A00 Offset: 0x3B47B01 VA: 0x3B47A00
	|-ReadOnlyCollection<RangePositionInfo>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3B489D0 Offset: 0x3B48AD1 VA: 0x3B489D0
	|-ReadOnlyCollection<Ranking2ChartInfoInput>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3B49B00 Offset: 0x3B49C01 VA: 0x3B49B00
	|-ReadOnlyCollection<RaycastHit2D>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3B4ACF0 Offset: 0x3B4ADF1 VA: 0x3B4ACF0
	|-ReadOnlyCollection<RaycastResult>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3B4BDB0 Offset: 0x3B4BEB1 VA: 0x3B4BDB0
	|-ReadOnlyCollection<Rect>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3B4CD80 Offset: 0x3B4CE81 VA: 0x3B4CD80
	|-ReadOnlyCollection<RendererListHandle>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3B4DD60 Offset: 0x3B4DE61 VA: 0x3B4DD60
	|-ReadOnlyCollection<ResourceHandle>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3AAF420 Offset: 0x3AAF521 VA: 0x3AAF420
	|-ReadOnlyCollection<sbyte>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3AB0440 Offset: 0x3AB0541 VA: 0x3AB0440
	|-ReadOnlyCollection<ShaderTagId>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3AB1420 Offset: 0x3AB1521 VA: 0x3AB1420
	|-ReadOnlyCollection<float>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3AB2700 Offset: 0x3AB2801 VA: 0x3AB2700
	|-ReadOnlyCollection<SphericalHarmonicsL2>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3AB3920 Offset: 0x3AB3A21 VA: 0x3AB3920
	|-ReadOnlyCollection<SubMeshDescriptor>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3AB4940 Offset: 0x3AB4A41 VA: 0x3AB4940
	|-ReadOnlyCollection<TablePair>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3AB5910 Offset: 0x3AB5A11 VA: 0x3AB5910
	|-ReadOnlyCollection<TimeSpan>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3AB6940 Offset: 0x3AB6A41 VA: 0x3AB6940
	|-ReadOnlyCollection<UICharInfo>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3AB7930 Offset: 0x3AB7A31 VA: 0x3AB7930
	|-ReadOnlyCollection<UILineInfo>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3AB8C00 Offset: 0x3AB8D01 VA: 0x3AB8C00
	|-ReadOnlyCollection<UIVertex>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3AB9CF0 Offset: 0x3AB9DF1 VA: 0x3AB9CF0
	|-ReadOnlyCollection<ushort>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3ABACD0 Offset: 0x3ABADD1 VA: 0x3ABACD0
	|-ReadOnlyCollection<uint>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3ABBCB0 Offset: 0x3ABBDB1 VA: 0x3ABBCB0
	|-ReadOnlyCollection<ulong>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3ABCCB0 Offset: 0x3ABCDB1 VA: 0x3ABCCB0
	|-ReadOnlyCollection<Vector2>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3ABDCE0 Offset: 0x3ABDDE1 VA: 0x3ABDCE0
	|-ReadOnlyCollection<Vector3>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3ABED00 Offset: 0x3ABEE01 VA: 0x3ABED00
	|-ReadOnlyCollection<Vector4>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3ABFCF0 Offset: 0x3ABFDF1 VA: 0x3ABFCF0
	|-ReadOnlyCollection<VertexAttributeDescriptor>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3AC0CE0 Offset: 0x3AC0DE1 VA: 0x3AC0CE0
	|-ReadOnlyCollection<X509ChainStatus>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3AC1DB0 Offset: 0x3AC1EB1 VA: 0x3AC1DB0
	|-ReadOnlyCollection<XRView>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3AC2E20 Offset: 0x3AC2F21 VA: 0x3AC2E20
	|-ReadOnlyCollection<AICrossfire.PositionTable>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3AC3E20 Offset: 0x3AC3F21 VA: 0x3AC3E20
	|-ReadOnlyCollection<AmiiboSequence.GainItemData>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3AC4F10 Offset: 0x3AC5011 VA: 0x3AC4F10
	|-ReadOnlyCollection<AnimationOutputWeightProcessor.WeightInfo>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3AC5F30 Offset: 0x3AC6031 VA: 0x3AC5F30
	|-ReadOnlyCollection<ArenaOrderSequence.GodInfo>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3AC6F20 Offset: 0x3AC7021 VA: 0x3AC6F20
	|-ReadOnlyCollection<BattleInfo.SupportData>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3AC7F10 Offset: 0x3AC8011 VA: 0x3AC7F10
	|-ReadOnlyCollection<BeforeRenderHelper.OrderBlock>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3AC8FC0 Offset: 0x3AC90C1 VA: 0x3AC8FC0
	|-ReadOnlyCollection<Camera.RenderRequest>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3AC9FC0 Offset: 0x3ACA0C1 VA: 0x3AC9FC0
	|-ReadOnlyCollection<CameraState.CustomBlendable>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3ACAF90 Offset: 0x3ACB091 VA: 0x3ACAF90
	|-ReadOnlyCollection<CinemachineClearShot.Pair>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3ACBF70 Offset: 0x3ACC071 VA: 0x3ACBF70
	|-ReadOnlyCollection<CinemachineStateDrivenCamera.HashPair>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3ACD030 Offset: 0x3ACD131 VA: 0x3ACD030
	|-ReadOnlyCollection<DelayedActionManager.DelegateInfo>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3ACE140 Offset: 0x3ACE241 VA: 0x3ACE140
	|-ReadOnlyCollection<Detail.AsyncResultInt>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3ACF160 Offset: 0x3ACF261 VA: 0x3ACF160
	|-ReadOnlyCollection<Detail.CppArray>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3AD0260 Offset: 0x3AD0361 VA: 0x3AD0260
	|-ReadOnlyCollection<Detail.NotificationEventInt>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3AD1280 Offset: 0x3AD1381 VA: 0x3AD1280
	|-ReadOnlyCollection<DragonRideTargetGroup.ChainParam>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3AD2330 Offset: 0x3AD2431 VA: 0x3AD2330
	|-ReadOnlyCollection<GmapPathAdjuster.TargetModel>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3AD33F0 Offset: 0x3AD34F1 VA: 0x3AD33F0
	|-ReadOnlyCollection<GmapSpotAdjuster.TargetModel>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3AD44B0 Offset: 0x3AD45B1 VA: 0x3AD44B0
	|-ReadOnlyCollection<HubFastTravel.Location>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3AD55C0 Offset: 0x3AD56C1 VA: 0x3AD55C0
	|-ReadOnlyCollection<HubLensFlare.Flare>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3AD65E0 Offset: 0x3AD66E1 VA: 0x3AD65E0
	|-ReadOnlyCollection<InventoryPoolItemMenuContent.KindBgNameClass>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3AD75B0 Offset: 0x3AD76B1 VA: 0x3AD75B0
	|-ReadOnlyCollection<Map.Pos>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3AD85B0 Offset: 0x3AD86B1 VA: 0x3AD85B0
	|-ReadOnlyCollection<MapImage.BackupTerrain>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3AD95C0 Offset: 0x3AD96C1 VA: 0x3AD95C0
	|-ReadOnlyCollection<MapImageRange.Pos>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3ADA680 Offset: 0x3ADA781 VA: 0x3ADA680
	|-ReadOnlyCollection<MapMind.Target>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x38C5060 Offset: 0x38C5161 VA: 0x38C5060
	|-ReadOnlyCollection<MapPanelDebug.Entity>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x38C6040 Offset: 0x38C6141 VA: 0x38C6040
	|-ReadOnlyCollection<NexRanking.Data>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x38C7040 Offset: 0x38C7141 VA: 0x38C7040
	|-ReadOnlyCollection<NexVersus.RatingData>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x38C8030 Offset: 0x38C8131 VA: 0x38C8030
	|-ReadOnlyCollection<PackedPlayModeBuildLogs.RuntimeBuildLog>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x38C9100 Offset: 0x38C9201 VA: 0x38C9100
	|-ReadOnlyCollection<ParticleSystem.Particle>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x38CA120 Offset: 0x38CA221 VA: 0x38CA120
	|-ReadOnlyCollection<RangeData.Offset>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x38CB1E0 Offset: 0x38CB2E1 VA: 0x38CB1E0
	|-ReadOnlyCollection<RenderGraphDebugData.PassDebugData>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x38CC2E0 Offset: 0x38CC3E1 VA: 0x38CC2E0
	|-ReadOnlyCollection<RenderGraphDebugData.ResourceDebugData>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x38CD300 Offset: 0x38CD401 VA: 0x38CD300
	|-ReadOnlyCollection<RingCleaningUnitSelectMenu.GodParam>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x38CE400 Offset: 0x38CE501 VA: 0x38CE400
	|-ReadOnlyCollection<ShadowUtility.Edge>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x38CF440 Offset: 0x38CF541 VA: 0x38CF440
	|-ReadOnlyCollection<SkillArray.Entity>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x38D0590 Offset: 0x38D0691 VA: 0x38D0590
	|-ReadOnlyCollection<TexturePacker_JsonArray.Frame>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x38D1690 Offset: 0x38D1791 VA: 0x38D1690
	|-ReadOnlyCollection<TimeNotificationBehaviour.NotificationEntry>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x38D2750 Offset: 0x38D2851 VA: 0x38D2750
	|-ReadOnlyCollection<UnitySynchronizationContext.WorkRequest>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x38D3750 Offset: 0x38D3851 VA: 0x38D3750
	|-ReadOnlyCollection<XmlSchemaObjectTable.XmlSchemaObjectEntry>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x38D4740 Offset: 0x38D4841 VA: 0x38D4740
	|-ReadOnlyCollection<AssetBundleBuildMap.AssetBundleEntry.AssetPathString>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x38D5830 Offset: 0x38D5931 VA: 0x38D5830
	|-ReadOnlyCollection<Detail.DataStore.DataStoreChangeMetaParamInt>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x38D6870 Offset: 0x38D6971 VA: 0x38D6870
	|-ReadOnlyCollection<Detail.DataStore.DataStoreDeleteParamInt>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x38D7960 Offset: 0x38D7A61 VA: 0x38D7960
	|-ReadOnlyCollection<Detail.DataStore.DataStoreGetMetaParamInt>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x38D8A60 Offset: 0x38D8B61 VA: 0x38D8A60
	|-ReadOnlyCollection<Detail.DataStore.DataStoreMetaInfoInt>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x38D9B60 Offset: 0x38D9C61 VA: 0x38D9B60
	|-ReadOnlyCollection<Detail.DataStore.DataStorePasswordInfoInt>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x38DAC20 Offset: 0x38DAD21 VA: 0x38DAC20
	|-ReadOnlyCollection<Detail.DataStore.DataStorePersistenceInfoInt>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x38DBD00 Offset: 0x38DBE01 VA: 0x38DBD00
	|-ReadOnlyCollection<Detail.DataStore.DataStorePreparePostParamInt>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x38DCD40 Offset: 0x38DCE41 VA: 0x38DCD40
	|-ReadOnlyCollection<Detail.DataStore.DataStoreRateObjectParamInt>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x38DDDF0 Offset: 0x38DDEF1 VA: 0x38DDDF0
	|-ReadOnlyCollection<Detail.DataStore.DataStoreRatingInitParamInt>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x38DEDF0 Offset: 0x38DEEF1 VA: 0x38DEDF0
	|-ReadOnlyCollection<Detail.DataStore.DataStoreRatingTargetInt>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x38DFF30 Offset: 0x38E0031 VA: 0x38DFF30
	|-ReadOnlyCollection<Detail.Ranking.RankingCachedResultInt>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x38E0F70 Offset: 0x38E1071 VA: 0x38E0F70
	|-ReadOnlyCollection<Detail.Ranking.RankingOrderParamInt>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x38E20B0 Offset: 0x38E21B1 VA: 0x38E20B0
	|-ReadOnlyCollection<Detail.Ranking.RankingRankDataInt>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x38E3330 Offset: 0x38E3431 VA: 0x38E3330
	|-ReadOnlyCollection<Detail.Ranking2.Ranking2ChartInfoInt>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x38E4550 Offset: 0x38E4651 VA: 0x38E4550
	|-ReadOnlyCollection<Detail.Ranking2.Ranking2RankDataInt>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x38E5590 Offset: 0x38E5691 VA: 0x38E5590
	|-ReadOnlyCollection<Detail.Ranking2.Ranking2ScoreDataInt>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x38E6640 Offset: 0x38E6741 VA: 0x38E6640
	|-ReadOnlyCollection<Detail.Screening.ScreeningContextInfoInt>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x38E7800 Offset: 0x38E7901 VA: 0x38E7800
	|-ReadOnlyCollection<Detail.Subscriber.SubscriberContentInt>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x38E8950 Offset: 0x38E8A51 VA: 0x38E8950
	|-ReadOnlyCollection<Detail.Subscriber.SubscriberGetContentParamInt>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x38E9A50 Offset: 0x38E9B51 VA: 0x38E9A50
	|-ReadOnlyCollection<Detail.Subscriber.SubscriberUserStatusInfoInt>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x38EAB30 Offset: 0x38EAC31 VA: 0x38EAB30
	|-ReadOnlyCollection<Detail.Subscriber.SubscriberUserStatusParamInt>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x38EBB10 Offset: 0x38EBC11 VA: 0x38EBB10
	|-ReadOnlyCollection<Detail.Utility.IntegerSettings>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x38ECB10 Offset: 0x38ECC11 VA: 0x38ECB10
	|-ReadOnlyCollection<Detail.Utility.UniqueIdInfoInt>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x38EDB30 Offset: 0x38EDC31 VA: 0x38EDB30
	|-ReadOnlyCollection<MapHistory.Rewind.LatestInspectorData>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x38EEB60 Offset: 0x38EEC61 VA: 0x38EEB60
	|-ReadOnlyCollection<MapHistory.Rewind.WorkTerrainData>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x38EFB60 Offset: 0x38EFC61 VA: 0x38EFB60
	|-ReadOnlyCollection<MapSkill.AroundCalculator.Result>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x38F0C60 Offset: 0x38F0D61 VA: 0x38F0C60
	|-ReadOnlyCollection<TargetPositionCache.CacheCurve.Item>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x2FE6200 Offset: 0x2FE6301 VA: 0x2FE6200
	|-ReadOnlyCollection<TargetPositionCache.CacheEntry.RecordingItem>.System.Collections.IList.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 18
	private object System.Collections.IList.get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3468030 Offset: 0x3468131 VA: 0x3468030
	|-ReadOnlyCollection<IntervalTree.Entry<object>>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3469030 Offset: 0x3469131 VA: 0x3469030
	|-ReadOnlyCollection<KeyValuePair<DateTime, object>>.System.Collections.IList.get_Item
	|
	|-RVA: 0x346A020 Offset: 0x346A121 VA: 0x346A020
	|-ReadOnlyCollection<KeyValuePair<int, object>>.System.Collections.IList.get_Item
	|
	|-RVA: 0x346B0D0 Offset: 0x346B1D1 VA: 0x346B0D0
	|-ReadOnlyCollection<KeyValuePair<object, ValueTuple<int, DateTime, object>>>.System.Collections.IList.get_Item
	|
	|-RVA: 0x346C0D0 Offset: 0x346C1D1 VA: 0x346C0D0
	|-ReadOnlyCollection<KeyValuePair<object, object>>.System.Collections.IList.get_Item
	|
	|-RVA: 0x346D180 Offset: 0x346D281 VA: 0x346D180
	|-ReadOnlyCollection<CommonBattleSequence.Reliance<object>>.System.Collections.IList.get_Item
	|
	|-RVA: 0x346E180 Offset: 0x346E281 VA: 0x346E180
	|-ReadOnlyCollection<RenderGraphResourcePool.ResourceLogInfo<object>>.System.Collections.IList.get_Item
	|
	|-RVA: 0x346F170 Offset: 0x346F271 VA: 0x346F170
	|-ReadOnlyCollection<ValueTuple<int, object>>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3470140 Offset: 0x3470241 VA: 0x3470140
	|-ReadOnlyCollection<ValueTuple<Int32Enum, int>>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3471200 Offset: 0x3471301 VA: 0x3471200
	|-ReadOnlyCollection<ValueTuple<object, ValueTuple<object, int>>>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3472200 Offset: 0x3472301 VA: 0x3472200
	|-ReadOnlyCollection<ValueTuple<object, int>>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3473220 Offset: 0x3473321 VA: 0x3473220
	|-ReadOnlyCollection<ValueTuple<Vector3, float>>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3474210 Offset: 0x3474311 VA: 0x3474210
	|-ReadOnlyCollection<ValueTuple<object, Int32Enum, int>>.System.Collections.IList.get_Item
	|
	|-RVA: 0x34752C0 Offset: 0x34753C1 VA: 0x34752C0
	|-ReadOnlyCollection<ValueTuple<object, int, int, int>>.System.Collections.IList.get_Item
	|
	|-RVA: 0x34762A0 Offset: 0x34763A1 VA: 0x34762A0
	|-ReadOnlyCollection<AnimatorClipInfo>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3B23100 Offset: 0x3B23201 VA: 0x3B23100
	|-ReadOnlyCollection<AsyncOperationHandle>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3B241C0 Offset: 0x3B242C1 VA: 0x3B241C0
	|-ReadOnlyCollection<BoneWeight>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3B251B0 Offset: 0x3B252B1 VA: 0x3B251B0
	|-ReadOnlyCollection<bool>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3B26190 Offset: 0x3B26291 VA: 0x3B26190
	|-ReadOnlyCollection<byte>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3B27190 Offset: 0x3B27291 VA: 0x3B27190
	|-ReadOnlyCollection<CameraInfo>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3B28160 Offset: 0x3B28261 VA: 0x3B28160
	|-ReadOnlyCollection<char>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3B29190 Offset: 0x3B29291 VA: 0x3B29190
	|-ReadOnlyCollection<Color>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3B2A1A0 Offset: 0x3B2A2A1 VA: 0x3B2A1A0
	|-ReadOnlyCollection<Color32>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3B2B1A0 Offset: 0x3B2B2A1 VA: 0x3B2B1A0
	|-ReadOnlyCollection<ConstraintSource>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3B2C250 Offset: 0x3B2C351 VA: 0x3B2C250
	|-ReadOnlyCollection<ContourVertex>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3B2D310 Offset: 0x3B2D411 VA: 0x3B2D310
	|-ReadOnlyCollection<CustomAttributeNamedArgument>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3B2E310 Offset: 0x3B2E411 VA: 0x3B2E310
	|-ReadOnlyCollection<CustomAttributeTypedArgument>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3B2F3C0 Offset: 0x3B2F4C1 VA: 0x3B2F3C0
	|-ReadOnlyCollection<DataStoreRatingInfo>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3B303A0 Offset: 0x3B304A1 VA: 0x3B303A0
	|-ReadOnlyCollection<DataStoreResult>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3B31380 Offset: 0x3B31481 VA: 0x3B31380
	|-ReadOnlyCollection<DateTime>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3B32380 Offset: 0x3B32481 VA: 0x3B32380
	|-ReadOnlyCollection<DateTimeOffset>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3B33370 Offset: 0x3B33471 VA: 0x3B33370
	|-ReadOnlyCollection<Decimal>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3B34470 Offset: 0x3B34571 VA: 0x3B34470
	|-ReadOnlyCollection<DiagnosticEvent>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3B35470 Offset: 0x3B35571 VA: 0x3B35470
	|-ReadOnlyCollection<double>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3B36590 Offset: 0x3B36691 VA: 0x3B36590
	|-ReadOnlyCollection<Friend>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3B375A0 Offset: 0x3B376A1 VA: 0x3B375A0
	|-ReadOnlyCollection<GlyphRect>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3B38570 Offset: 0x3B38671 VA: 0x3B38570
	|-ReadOnlyCollection<short>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3B39550 Offset: 0x3B39651 VA: 0x3B39550
	|-ReadOnlyCollection<int>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3B3A530 Offset: 0x3B3A631 VA: 0x3B3A530
	|-ReadOnlyCollection<Int32Enum>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3B3B510 Offset: 0x3B3B611 VA: 0x3B3B510
	|-ReadOnlyCollection<long>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3B3C4F0 Offset: 0x3B3C5F1 VA: 0x3B3C4F0
	|-ReadOnlyCollection<IntPtr>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3B3D4F0 Offset: 0x3B3D5F1 VA: 0x3B3D4F0
	|-ReadOnlyCollection<InterpretedFrameInfo>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3B3E5A0 Offset: 0x3B3E6A1 VA: 0x3B3E5A0
	|-ReadOnlyCollection<IntervalTreeNode>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3B3F580 Offset: 0x3B3F681 VA: 0x3B3F580
	|-ReadOnlyCollection<LengthLimitProperties>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3B40560 Offset: 0x3B40661 VA: 0x3B40560
	|-ReadOnlyCollection<MapPos>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3B416B0 Offset: 0x3B417B1 VA: 0x3B416B0
	|-ReadOnlyCollection<Matrix4x4>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3B426B0 Offset: 0x3B427B1 VA: 0x3B426B0
	|-ReadOnlyCollection<object>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3B436F0 Offset: 0x3B437F1 VA: 0x3B436F0
	|-ReadOnlyCollection<ObjectInitializationData>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3B447D0 Offset: 0x3B448D1 VA: 0x3B447D0
	|-ReadOnlyCollection<PlayableBinding>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3B458D0 Offset: 0x3B459D1 VA: 0x3B458D0
	|-ReadOnlyCollection<PlayerLoopSystem>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3B469F0 Offset: 0x3B46AF1 VA: 0x3B469F0
	|-ReadOnlyCollection<PlayerLoopSystemInternal>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3B47A10 Offset: 0x3B47B11 VA: 0x3B47A10
	|-ReadOnlyCollection<RangePositionInfo>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3B489E0 Offset: 0x3B48AE1 VA: 0x3B489E0
	|-ReadOnlyCollection<Ranking2ChartInfoInput>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3B49B10 Offset: 0x3B49C11 VA: 0x3B49B10
	|-ReadOnlyCollection<RaycastHit2D>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3B4AD00 Offset: 0x3B4AE01 VA: 0x3B4AD00
	|-ReadOnlyCollection<RaycastResult>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3B4BDC0 Offset: 0x3B4BEC1 VA: 0x3B4BDC0
	|-ReadOnlyCollection<Rect>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3B4CD90 Offset: 0x3B4CE91 VA: 0x3B4CD90
	|-ReadOnlyCollection<RendererListHandle>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3B4DD70 Offset: 0x3B4DE71 VA: 0x3B4DD70
	|-ReadOnlyCollection<ResourceHandle>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3AAF430 Offset: 0x3AAF531 VA: 0x3AAF430
	|-ReadOnlyCollection<sbyte>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3AB0450 Offset: 0x3AB0551 VA: 0x3AB0450
	|-ReadOnlyCollection<ShaderTagId>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3AB1430 Offset: 0x3AB1531 VA: 0x3AB1430
	|-ReadOnlyCollection<float>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3AB2710 Offset: 0x3AB2811 VA: 0x3AB2710
	|-ReadOnlyCollection<SphericalHarmonicsL2>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3AB3930 Offset: 0x3AB3A31 VA: 0x3AB3930
	|-ReadOnlyCollection<SubMeshDescriptor>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3AB4950 Offset: 0x3AB4A51 VA: 0x3AB4950
	|-ReadOnlyCollection<TablePair>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3AB5920 Offset: 0x3AB5A21 VA: 0x3AB5920
	|-ReadOnlyCollection<TimeSpan>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3AB6950 Offset: 0x3AB6A51 VA: 0x3AB6950
	|-ReadOnlyCollection<UICharInfo>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3AB7940 Offset: 0x3AB7A41 VA: 0x3AB7940
	|-ReadOnlyCollection<UILineInfo>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3AB8C10 Offset: 0x3AB8D11 VA: 0x3AB8C10
	|-ReadOnlyCollection<UIVertex>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3AB9D00 Offset: 0x3AB9E01 VA: 0x3AB9D00
	|-ReadOnlyCollection<ushort>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3ABACE0 Offset: 0x3ABADE1 VA: 0x3ABACE0
	|-ReadOnlyCollection<uint>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3ABBCC0 Offset: 0x3ABBDC1 VA: 0x3ABBCC0
	|-ReadOnlyCollection<ulong>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3ABCCC0 Offset: 0x3ABCDC1 VA: 0x3ABCCC0
	|-ReadOnlyCollection<Vector2>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3ABDCF0 Offset: 0x3ABDDF1 VA: 0x3ABDCF0
	|-ReadOnlyCollection<Vector3>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3ABED10 Offset: 0x3ABEE11 VA: 0x3ABED10
	|-ReadOnlyCollection<Vector4>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3ABFD00 Offset: 0x3ABFE01 VA: 0x3ABFD00
	|-ReadOnlyCollection<VertexAttributeDescriptor>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3AC0CF0 Offset: 0x3AC0DF1 VA: 0x3AC0CF0
	|-ReadOnlyCollection<X509ChainStatus>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3AC1DC0 Offset: 0x3AC1EC1 VA: 0x3AC1DC0
	|-ReadOnlyCollection<XRView>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3AC2E30 Offset: 0x3AC2F31 VA: 0x3AC2E30
	|-ReadOnlyCollection<AICrossfire.PositionTable>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3AC3E30 Offset: 0x3AC3F31 VA: 0x3AC3E30
	|-ReadOnlyCollection<AmiiboSequence.GainItemData>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3AC4F20 Offset: 0x3AC5021 VA: 0x3AC4F20
	|-ReadOnlyCollection<AnimationOutputWeightProcessor.WeightInfo>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3AC5F40 Offset: 0x3AC6041 VA: 0x3AC5F40
	|-ReadOnlyCollection<ArenaOrderSequence.GodInfo>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3AC6F30 Offset: 0x3AC7031 VA: 0x3AC6F30
	|-ReadOnlyCollection<BattleInfo.SupportData>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3AC7F20 Offset: 0x3AC8021 VA: 0x3AC7F20
	|-ReadOnlyCollection<BeforeRenderHelper.OrderBlock>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3AC8FD0 Offset: 0x3AC90D1 VA: 0x3AC8FD0
	|-ReadOnlyCollection<Camera.RenderRequest>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3AC9FD0 Offset: 0x3ACA0D1 VA: 0x3AC9FD0
	|-ReadOnlyCollection<CameraState.CustomBlendable>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3ACAFA0 Offset: 0x3ACB0A1 VA: 0x3ACAFA0
	|-ReadOnlyCollection<CinemachineClearShot.Pair>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3ACBF80 Offset: 0x3ACC081 VA: 0x3ACBF80
	|-ReadOnlyCollection<CinemachineStateDrivenCamera.HashPair>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3ACD040 Offset: 0x3ACD141 VA: 0x3ACD040
	|-ReadOnlyCollection<DelayedActionManager.DelegateInfo>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3ACE150 Offset: 0x3ACE251 VA: 0x3ACE150
	|-ReadOnlyCollection<Detail.AsyncResultInt>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3ACF170 Offset: 0x3ACF271 VA: 0x3ACF170
	|-ReadOnlyCollection<Detail.CppArray>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3AD0270 Offset: 0x3AD0371 VA: 0x3AD0270
	|-ReadOnlyCollection<Detail.NotificationEventInt>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3AD1290 Offset: 0x3AD1391 VA: 0x3AD1290
	|-ReadOnlyCollection<DragonRideTargetGroup.ChainParam>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3AD2340 Offset: 0x3AD2441 VA: 0x3AD2340
	|-ReadOnlyCollection<GmapPathAdjuster.TargetModel>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3AD3400 Offset: 0x3AD3501 VA: 0x3AD3400
	|-ReadOnlyCollection<GmapSpotAdjuster.TargetModel>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3AD44C0 Offset: 0x3AD45C1 VA: 0x3AD44C0
	|-ReadOnlyCollection<HubFastTravel.Location>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3AD55D0 Offset: 0x3AD56D1 VA: 0x3AD55D0
	|-ReadOnlyCollection<HubLensFlare.Flare>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3AD65F0 Offset: 0x3AD66F1 VA: 0x3AD65F0
	|-ReadOnlyCollection<InventoryPoolItemMenuContent.KindBgNameClass>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3AD75C0 Offset: 0x3AD76C1 VA: 0x3AD75C0
	|-ReadOnlyCollection<Map.Pos>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3AD85C0 Offset: 0x3AD86C1 VA: 0x3AD85C0
	|-ReadOnlyCollection<MapImage.BackupTerrain>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3AD95D0 Offset: 0x3AD96D1 VA: 0x3AD95D0
	|-ReadOnlyCollection<MapImageRange.Pos>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3ADA690 Offset: 0x3ADA791 VA: 0x3ADA690
	|-ReadOnlyCollection<MapMind.Target>.System.Collections.IList.get_Item
	|
	|-RVA: 0x38C5070 Offset: 0x38C5171 VA: 0x38C5070
	|-ReadOnlyCollection<MapPanelDebug.Entity>.System.Collections.IList.get_Item
	|
	|-RVA: 0x38C6050 Offset: 0x38C6151 VA: 0x38C6050
	|-ReadOnlyCollection<NexRanking.Data>.System.Collections.IList.get_Item
	|
	|-RVA: 0x38C7050 Offset: 0x38C7151 VA: 0x38C7050
	|-ReadOnlyCollection<NexVersus.RatingData>.System.Collections.IList.get_Item
	|
	|-RVA: 0x38C8040 Offset: 0x38C8141 VA: 0x38C8040
	|-ReadOnlyCollection<PackedPlayModeBuildLogs.RuntimeBuildLog>.System.Collections.IList.get_Item
	|
	|-RVA: 0x38C9110 Offset: 0x38C9211 VA: 0x38C9110
	|-ReadOnlyCollection<ParticleSystem.Particle>.System.Collections.IList.get_Item
	|
	|-RVA: 0x38CA130 Offset: 0x38CA231 VA: 0x38CA130
	|-ReadOnlyCollection<RangeData.Offset>.System.Collections.IList.get_Item
	|
	|-RVA: 0x38CB1F0 Offset: 0x38CB2F1 VA: 0x38CB1F0
	|-ReadOnlyCollection<RenderGraphDebugData.PassDebugData>.System.Collections.IList.get_Item
	|
	|-RVA: 0x38CC2F0 Offset: 0x38CC3F1 VA: 0x38CC2F0
	|-ReadOnlyCollection<RenderGraphDebugData.ResourceDebugData>.System.Collections.IList.get_Item
	|
	|-RVA: 0x38CD310 Offset: 0x38CD411 VA: 0x38CD310
	|-ReadOnlyCollection<RingCleaningUnitSelectMenu.GodParam>.System.Collections.IList.get_Item
	|
	|-RVA: 0x38CE410 Offset: 0x38CE511 VA: 0x38CE410
	|-ReadOnlyCollection<ShadowUtility.Edge>.System.Collections.IList.get_Item
	|
	|-RVA: 0x38CF450 Offset: 0x38CF551 VA: 0x38CF450
	|-ReadOnlyCollection<SkillArray.Entity>.System.Collections.IList.get_Item
	|
	|-RVA: 0x38D05A0 Offset: 0x38D06A1 VA: 0x38D05A0
	|-ReadOnlyCollection<TexturePacker_JsonArray.Frame>.System.Collections.IList.get_Item
	|
	|-RVA: 0x38D16A0 Offset: 0x38D17A1 VA: 0x38D16A0
	|-ReadOnlyCollection<TimeNotificationBehaviour.NotificationEntry>.System.Collections.IList.get_Item
	|
	|-RVA: 0x38D2760 Offset: 0x38D2861 VA: 0x38D2760
	|-ReadOnlyCollection<UnitySynchronizationContext.WorkRequest>.System.Collections.IList.get_Item
	|
	|-RVA: 0x38D3760 Offset: 0x38D3861 VA: 0x38D3760
	|-ReadOnlyCollection<XmlSchemaObjectTable.XmlSchemaObjectEntry>.System.Collections.IList.get_Item
	|
	|-RVA: 0x38D4750 Offset: 0x38D4851 VA: 0x38D4750
	|-ReadOnlyCollection<AssetBundleBuildMap.AssetBundleEntry.AssetPathString>.System.Collections.IList.get_Item
	|
	|-RVA: 0x38D5840 Offset: 0x38D5941 VA: 0x38D5840
	|-ReadOnlyCollection<Detail.DataStore.DataStoreChangeMetaParamInt>.System.Collections.IList.get_Item
	|
	|-RVA: 0x38D6880 Offset: 0x38D6981 VA: 0x38D6880
	|-ReadOnlyCollection<Detail.DataStore.DataStoreDeleteParamInt>.System.Collections.IList.get_Item
	|
	|-RVA: 0x38D7970 Offset: 0x38D7A71 VA: 0x38D7970
	|-ReadOnlyCollection<Detail.DataStore.DataStoreGetMetaParamInt>.System.Collections.IList.get_Item
	|
	|-RVA: 0x38D8A70 Offset: 0x38D8B71 VA: 0x38D8A70
	|-ReadOnlyCollection<Detail.DataStore.DataStoreMetaInfoInt>.System.Collections.IList.get_Item
	|
	|-RVA: 0x38D9B70 Offset: 0x38D9C71 VA: 0x38D9B70
	|-ReadOnlyCollection<Detail.DataStore.DataStorePasswordInfoInt>.System.Collections.IList.get_Item
	|
	|-RVA: 0x38DAC30 Offset: 0x38DAD31 VA: 0x38DAC30
	|-ReadOnlyCollection<Detail.DataStore.DataStorePersistenceInfoInt>.System.Collections.IList.get_Item
	|
	|-RVA: 0x38DBD10 Offset: 0x38DBE11 VA: 0x38DBD10
	|-ReadOnlyCollection<Detail.DataStore.DataStorePreparePostParamInt>.System.Collections.IList.get_Item
	|
	|-RVA: 0x38DCD50 Offset: 0x38DCE51 VA: 0x38DCD50
	|-ReadOnlyCollection<Detail.DataStore.DataStoreRateObjectParamInt>.System.Collections.IList.get_Item
	|
	|-RVA: 0x38DDE00 Offset: 0x38DDF01 VA: 0x38DDE00
	|-ReadOnlyCollection<Detail.DataStore.DataStoreRatingInitParamInt>.System.Collections.IList.get_Item
	|
	|-RVA: 0x38DEE00 Offset: 0x38DEF01 VA: 0x38DEE00
	|-ReadOnlyCollection<Detail.DataStore.DataStoreRatingTargetInt>.System.Collections.IList.get_Item
	|
	|-RVA: 0x38DFF40 Offset: 0x38E0041 VA: 0x38DFF40
	|-ReadOnlyCollection<Detail.Ranking.RankingCachedResultInt>.System.Collections.IList.get_Item
	|
	|-RVA: 0x38E0F80 Offset: 0x38E1081 VA: 0x38E0F80
	|-ReadOnlyCollection<Detail.Ranking.RankingOrderParamInt>.System.Collections.IList.get_Item
	|
	|-RVA: 0x38E20C0 Offset: 0x38E21C1 VA: 0x38E20C0
	|-ReadOnlyCollection<Detail.Ranking.RankingRankDataInt>.System.Collections.IList.get_Item
	|
	|-RVA: 0x38E3340 Offset: 0x38E3441 VA: 0x38E3340
	|-ReadOnlyCollection<Detail.Ranking2.Ranking2ChartInfoInt>.System.Collections.IList.get_Item
	|
	|-RVA: 0x38E4560 Offset: 0x38E4661 VA: 0x38E4560
	|-ReadOnlyCollection<Detail.Ranking2.Ranking2RankDataInt>.System.Collections.IList.get_Item
	|
	|-RVA: 0x38E55A0 Offset: 0x38E56A1 VA: 0x38E55A0
	|-ReadOnlyCollection<Detail.Ranking2.Ranking2ScoreDataInt>.System.Collections.IList.get_Item
	|
	|-RVA: 0x38E6650 Offset: 0x38E6751 VA: 0x38E6650
	|-ReadOnlyCollection<Detail.Screening.ScreeningContextInfoInt>.System.Collections.IList.get_Item
	|
	|-RVA: 0x38E7810 Offset: 0x38E7911 VA: 0x38E7810
	|-ReadOnlyCollection<Detail.Subscriber.SubscriberContentInt>.System.Collections.IList.get_Item
	|
	|-RVA: 0x38E8960 Offset: 0x38E8A61 VA: 0x38E8960
	|-ReadOnlyCollection<Detail.Subscriber.SubscriberGetContentParamInt>.System.Collections.IList.get_Item
	|
	|-RVA: 0x38E9A60 Offset: 0x38E9B61 VA: 0x38E9A60
	|-ReadOnlyCollection<Detail.Subscriber.SubscriberUserStatusInfoInt>.System.Collections.IList.get_Item
	|
	|-RVA: 0x38EAB40 Offset: 0x38EAC41 VA: 0x38EAB40
	|-ReadOnlyCollection<Detail.Subscriber.SubscriberUserStatusParamInt>.System.Collections.IList.get_Item
	|
	|-RVA: 0x38EBB20 Offset: 0x38EBC21 VA: 0x38EBB20
	|-ReadOnlyCollection<Detail.Utility.IntegerSettings>.System.Collections.IList.get_Item
	|
	|-RVA: 0x38ECB20 Offset: 0x38ECC21 VA: 0x38ECB20
	|-ReadOnlyCollection<Detail.Utility.UniqueIdInfoInt>.System.Collections.IList.get_Item
	|
	|-RVA: 0x38EDB40 Offset: 0x38EDC41 VA: 0x38EDB40
	|-ReadOnlyCollection<MapHistory.Rewind.LatestInspectorData>.System.Collections.IList.get_Item
	|
	|-RVA: 0x38EEB70 Offset: 0x38EEC71 VA: 0x38EEB70
	|-ReadOnlyCollection<MapHistory.Rewind.WorkTerrainData>.System.Collections.IList.get_Item
	|
	|-RVA: 0x38EFB70 Offset: 0x38EFC71 VA: 0x38EFB70
	|-ReadOnlyCollection<MapSkill.AroundCalculator.Result>.System.Collections.IList.get_Item
	|
	|-RVA: 0x38F0C70 Offset: 0x38F0D71 VA: 0x38F0C70
	|-ReadOnlyCollection<TargetPositionCache.CacheCurve.Item>.System.Collections.IList.get_Item
	|
	|-RVA: 0x2FE6210 Offset: 0x2FE6311 VA: 0x2FE6210
	|-ReadOnlyCollection<TargetPositionCache.CacheEntry.RecordingItem>.System.Collections.IList.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 19
	private void System.Collections.IList.set_Item(int index, object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3468120 Offset: 0x3468221 VA: 0x3468120
	|-ReadOnlyCollection<IntervalTree.Entry<object>>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3469110 Offset: 0x3469211 VA: 0x3469110
	|-ReadOnlyCollection<KeyValuePair<DateTime, object>>.System.Collections.IList.set_Item
	|
	|-RVA: 0x346A100 Offset: 0x346A201 VA: 0x346A100
	|-ReadOnlyCollection<KeyValuePair<int, object>>.System.Collections.IList.set_Item
	|
	|-RVA: 0x346B1C0 Offset: 0x346B2C1 VA: 0x346B1C0
	|-ReadOnlyCollection<KeyValuePair<object, ValueTuple<int, DateTime, object>>>.System.Collections.IList.set_Item
	|
	|-RVA: 0x346C1B0 Offset: 0x346C2B1 VA: 0x346C1B0
	|-ReadOnlyCollection<KeyValuePair<object, object>>.System.Collections.IList.set_Item
	|
	|-RVA: 0x346D270 Offset: 0x346D371 VA: 0x346D270
	|-ReadOnlyCollection<CommonBattleSequence.Reliance<object>>.System.Collections.IList.set_Item
	|
	|-RVA: 0x346E260 Offset: 0x346E361 VA: 0x346E260
	|-ReadOnlyCollection<RenderGraphResourcePool.ResourceLogInfo<object>>.System.Collections.IList.set_Item
	|
	|-RVA: 0x346F250 Offset: 0x346F351 VA: 0x346F250
	|-ReadOnlyCollection<ValueTuple<int, object>>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3470220 Offset: 0x3470321 VA: 0x3470220
	|-ReadOnlyCollection<ValueTuple<Int32Enum, int>>.System.Collections.IList.set_Item
	|
	|-RVA: 0x34712F0 Offset: 0x34713F1 VA: 0x34712F0
	|-ReadOnlyCollection<ValueTuple<object, ValueTuple<object, int>>>.System.Collections.IList.set_Item
	|
	|-RVA: 0x34722E0 Offset: 0x34723E1 VA: 0x34722E0
	|-ReadOnlyCollection<ValueTuple<object, int>>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3473300 Offset: 0x3473401 VA: 0x3473300
	|-ReadOnlyCollection<ValueTuple<Vector3, float>>.System.Collections.IList.set_Item
	|
	|-RVA: 0x34742F0 Offset: 0x34743F1 VA: 0x34742F0
	|-ReadOnlyCollection<ValueTuple<object, Int32Enum, int>>.System.Collections.IList.set_Item
	|
	|-RVA: 0x34753B0 Offset: 0x34754B1 VA: 0x34753B0
	|-ReadOnlyCollection<ValueTuple<object, int, int, int>>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3476380 Offset: 0x3476481 VA: 0x3476380
	|-ReadOnlyCollection<AnimatorClipInfo>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3B231F0 Offset: 0x3B232F1 VA: 0x3B231F0
	|-ReadOnlyCollection<AsyncOperationHandle>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3B242B0 Offset: 0x3B243B1 VA: 0x3B242B0
	|-ReadOnlyCollection<BoneWeight>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3B25290 Offset: 0x3B25391 VA: 0x3B25290
	|-ReadOnlyCollection<bool>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3B26270 Offset: 0x3B26371 VA: 0x3B26270
	|-ReadOnlyCollection<byte>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3B27270 Offset: 0x3B27371 VA: 0x3B27270
	|-ReadOnlyCollection<CameraInfo>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3B28240 Offset: 0x3B28341 VA: 0x3B28240
	|-ReadOnlyCollection<char>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3B29270 Offset: 0x3B29371 VA: 0x3B29270
	|-ReadOnlyCollection<Color>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3B2A280 Offset: 0x3B2A381 VA: 0x3B2A280
	|-ReadOnlyCollection<Color32>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3B2B280 Offset: 0x3B2B381 VA: 0x3B2B280
	|-ReadOnlyCollection<ConstraintSource>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3B2C340 Offset: 0x3B2C441 VA: 0x3B2C340
	|-ReadOnlyCollection<ContourVertex>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3B2D400 Offset: 0x3B2D501 VA: 0x3B2D400
	|-ReadOnlyCollection<CustomAttributeNamedArgument>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3B2E3F0 Offset: 0x3B2E4F1 VA: 0x3B2E3F0
	|-ReadOnlyCollection<CustomAttributeTypedArgument>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3B2F4B0 Offset: 0x3B2F5B1 VA: 0x3B2F4B0
	|-ReadOnlyCollection<DataStoreRatingInfo>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3B30480 Offset: 0x3B30581 VA: 0x3B30480
	|-ReadOnlyCollection<DataStoreResult>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3B31460 Offset: 0x3B31561 VA: 0x3B31460
	|-ReadOnlyCollection<DateTime>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3B32460 Offset: 0x3B32561 VA: 0x3B32460
	|-ReadOnlyCollection<DateTimeOffset>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3B33450 Offset: 0x3B33551 VA: 0x3B33450
	|-ReadOnlyCollection<Decimal>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3B34570 Offset: 0x3B34671 VA: 0x3B34570
	|-ReadOnlyCollection<DiagnosticEvent>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3B35550 Offset: 0x3B35651 VA: 0x3B35550
	|-ReadOnlyCollection<double>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3B36690 Offset: 0x3B36791 VA: 0x3B36690
	|-ReadOnlyCollection<Friend>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3B37680 Offset: 0x3B37781 VA: 0x3B37680
	|-ReadOnlyCollection<GlyphRect>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3B38650 Offset: 0x3B38751 VA: 0x3B38650
	|-ReadOnlyCollection<short>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3B39630 Offset: 0x3B39731 VA: 0x3B39630
	|-ReadOnlyCollection<int>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3B3A610 Offset: 0x3B3A711 VA: 0x3B3A610
	|-ReadOnlyCollection<Int32Enum>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3B3B5F0 Offset: 0x3B3B6F1 VA: 0x3B3B5F0
	|-ReadOnlyCollection<long>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3B3C5D0 Offset: 0x3B3C6D1 VA: 0x3B3C5D0
	|-ReadOnlyCollection<IntPtr>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3B3D5D0 Offset: 0x3B3D6D1 VA: 0x3B3D5D0
	|-ReadOnlyCollection<InterpretedFrameInfo>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3B3E690 Offset: 0x3B3E791 VA: 0x3B3E690
	|-ReadOnlyCollection<IntervalTreeNode>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3B3F660 Offset: 0x3B3F761 VA: 0x3B3F660
	|-ReadOnlyCollection<LengthLimitProperties>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3B40640 Offset: 0x3B40741 VA: 0x3B40640
	|-ReadOnlyCollection<MapPos>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3B417C0 Offset: 0x3B418C1 VA: 0x3B417C0
	|-ReadOnlyCollection<Matrix4x4>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3B42750 Offset: 0x3B42851 VA: 0x3B42750
	|-ReadOnlyCollection<object>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3B437F0 Offset: 0x3B438F1 VA: 0x3B437F0
	|-ReadOnlyCollection<ObjectInitializationData>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3B448C0 Offset: 0x3B449C1 VA: 0x3B448C0
	|-ReadOnlyCollection<PlayableBinding>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3B459D0 Offset: 0x3B45AD1 VA: 0x3B459D0
	|-ReadOnlyCollection<PlayerLoopSystem>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3B46AF0 Offset: 0x3B46BF1 VA: 0x3B46AF0
	|-ReadOnlyCollection<PlayerLoopSystemInternal>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3B47AF0 Offset: 0x3B47BF1 VA: 0x3B47AF0
	|-ReadOnlyCollection<RangePositionInfo>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3B48AC0 Offset: 0x3B48BC1 VA: 0x3B48AC0
	|-ReadOnlyCollection<Ranking2ChartInfoInput>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3B49C10 Offset: 0x3B49D11 VA: 0x3B49C10
	|-ReadOnlyCollection<RaycastHit2D>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3B4AE40 Offset: 0x3B4AF41 VA: 0x3B4AE40
	|-ReadOnlyCollection<RaycastResult>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3B4BEA0 Offset: 0x3B4BFA1 VA: 0x3B4BEA0
	|-ReadOnlyCollection<Rect>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3B4CE70 Offset: 0x3B4CF71 VA: 0x3B4CE70
	|-ReadOnlyCollection<RendererListHandle>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3B4DE50 Offset: 0x3B4DF51 VA: 0x3B4DE50
	|-ReadOnlyCollection<ResourceHandle>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3AAF510 Offset: 0x3AAF611 VA: 0x3AAF510
	|-ReadOnlyCollection<sbyte>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3AB0530 Offset: 0x3AB0631 VA: 0x3AB0530
	|-ReadOnlyCollection<ShaderTagId>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3AB1510 Offset: 0x3AB1611 VA: 0x3AB1510
	|-ReadOnlyCollection<float>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3AB28A0 Offset: 0x3AB29A1 VA: 0x3AB28A0
	|-ReadOnlyCollection<SphericalHarmonicsL2>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3AB3A30 Offset: 0x3AB3B31 VA: 0x3AB3A30
	|-ReadOnlyCollection<SubMeshDescriptor>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3AB4A30 Offset: 0x3AB4B31 VA: 0x3AB4A30
	|-ReadOnlyCollection<TablePair>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3AB5A00 Offset: 0x3AB5B01 VA: 0x3AB5A00
	|-ReadOnlyCollection<TimeSpan>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3AB6A30 Offset: 0x3AB6B31 VA: 0x3AB6A30
	|-ReadOnlyCollection<UICharInfo>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3AB7A20 Offset: 0x3AB7B21 VA: 0x3AB7A20
	|-ReadOnlyCollection<UILineInfo>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3AB8DA0 Offset: 0x3AB8EA1 VA: 0x3AB8DA0
	|-ReadOnlyCollection<UIVertex>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3AB9DE0 Offset: 0x3AB9EE1 VA: 0x3AB9DE0
	|-ReadOnlyCollection<ushort>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3ABADC0 Offset: 0x3ABAEC1 VA: 0x3ABADC0
	|-ReadOnlyCollection<uint>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3ABBDA0 Offset: 0x3ABBEA1 VA: 0x3ABBDA0
	|-ReadOnlyCollection<ulong>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3ABCDA0 Offset: 0x3ABCEA1 VA: 0x3ABCDA0
	|-ReadOnlyCollection<Vector2>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3ABDDD0 Offset: 0x3ABDED1 VA: 0x3ABDDD0
	|-ReadOnlyCollection<Vector3>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3ABEDF0 Offset: 0x3ABEEF1 VA: 0x3ABEDF0
	|-ReadOnlyCollection<Vector4>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3ABFDE0 Offset: 0x3ABFEE1 VA: 0x3ABFDE0
	|-ReadOnlyCollection<VertexAttributeDescriptor>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3AC0DD0 Offset: 0x3AC0ED1 VA: 0x3AC0DD0
	|-ReadOnlyCollection<X509ChainStatus>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3AC1ED0 Offset: 0x3AC1FD1 VA: 0x3AC1ED0
	|-ReadOnlyCollection<XRView>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3AC2F10 Offset: 0x3AC3011 VA: 0x3AC2F10
	|-ReadOnlyCollection<AICrossfire.PositionTable>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3AC3F10 Offset: 0x3AC4011 VA: 0x3AC3F10
	|-ReadOnlyCollection<AmiiboSequence.GainItemData>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3AC5020 Offset: 0x3AC5121 VA: 0x3AC5020
	|-ReadOnlyCollection<AnimationOutputWeightProcessor.WeightInfo>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3AC6020 Offset: 0x3AC6121 VA: 0x3AC6020
	|-ReadOnlyCollection<ArenaOrderSequence.GodInfo>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3AC7010 Offset: 0x3AC7111 VA: 0x3AC7010
	|-ReadOnlyCollection<BattleInfo.SupportData>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3AC8000 Offset: 0x3AC8101 VA: 0x3AC8000
	|-ReadOnlyCollection<BeforeRenderHelper.OrderBlock>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3AC90C0 Offset: 0x3AC91C1 VA: 0x3AC90C0
	|-ReadOnlyCollection<Camera.RenderRequest>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3ACA0B0 Offset: 0x3ACA1B1 VA: 0x3ACA0B0
	|-ReadOnlyCollection<CameraState.CustomBlendable>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3ACB080 Offset: 0x3ACB181 VA: 0x3ACB080
	|-ReadOnlyCollection<CinemachineClearShot.Pair>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3ACC060 Offset: 0x3ACC161 VA: 0x3ACC060
	|-ReadOnlyCollection<CinemachineStateDrivenCamera.HashPair>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3ACD130 Offset: 0x3ACD231 VA: 0x3ACD130
	|-ReadOnlyCollection<DelayedActionManager.DelegateInfo>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3ACE250 Offset: 0x3ACE351 VA: 0x3ACE250
	|-ReadOnlyCollection<Detail.AsyncResultInt>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3ACF250 Offset: 0x3ACF351 VA: 0x3ACF250
	|-ReadOnlyCollection<Detail.CppArray>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3AD0370 Offset: 0x3AD0471 VA: 0x3AD0370
	|-ReadOnlyCollection<Detail.NotificationEventInt>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3AD1370 Offset: 0x3AD1471 VA: 0x3AD1370
	|-ReadOnlyCollection<DragonRideTargetGroup.ChainParam>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3AD2430 Offset: 0x3AD2531 VA: 0x3AD2430
	|-ReadOnlyCollection<GmapPathAdjuster.TargetModel>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3AD34F0 Offset: 0x3AD35F1 VA: 0x3AD34F0
	|-ReadOnlyCollection<GmapSpotAdjuster.TargetModel>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3AD45B0 Offset: 0x3AD46B1 VA: 0x3AD45B0
	|-ReadOnlyCollection<HubFastTravel.Location>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3AD56D0 Offset: 0x3AD57D1 VA: 0x3AD56D0
	|-ReadOnlyCollection<HubLensFlare.Flare>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3AD66D0 Offset: 0x3AD67D1 VA: 0x3AD66D0
	|-ReadOnlyCollection<InventoryPoolItemMenuContent.KindBgNameClass>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3AD76A0 Offset: 0x3AD77A1 VA: 0x3AD76A0
	|-ReadOnlyCollection<Map.Pos>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3AD86A0 Offset: 0x3AD87A1 VA: 0x3AD86A0
	|-ReadOnlyCollection<MapImage.BackupTerrain>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3AD96B0 Offset: 0x3AD97B1 VA: 0x3AD96B0
	|-ReadOnlyCollection<MapImageRange.Pos>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3ADA780 Offset: 0x3ADA881 VA: 0x3ADA780
	|-ReadOnlyCollection<MapMind.Target>.System.Collections.IList.set_Item
	|
	|-RVA: 0x38C5160 Offset: 0x38C5261 VA: 0x38C5160
	|-ReadOnlyCollection<MapPanelDebug.Entity>.System.Collections.IList.set_Item
	|
	|-RVA: 0x38C6130 Offset: 0x38C6231 VA: 0x38C6130
	|-ReadOnlyCollection<NexRanking.Data>.System.Collections.IList.set_Item
	|
	|-RVA: 0x38C7130 Offset: 0x38C7231 VA: 0x38C7130
	|-ReadOnlyCollection<NexVersus.RatingData>.System.Collections.IList.set_Item
	|
	|-RVA: 0x38C8120 Offset: 0x38C8221 VA: 0x38C8120
	|-ReadOnlyCollection<PackedPlayModeBuildLogs.RuntimeBuildLog>.System.Collections.IList.set_Item
	|
	|-RVA: 0x38C9220 Offset: 0x38C9321 VA: 0x38C9220
	|-ReadOnlyCollection<ParticleSystem.Particle>.System.Collections.IList.set_Item
	|
	|-RVA: 0x38CA210 Offset: 0x38CA311 VA: 0x38CA210
	|-ReadOnlyCollection<RangeData.Offset>.System.Collections.IList.set_Item
	|
	|-RVA: 0x38CB2E0 Offset: 0x38CB3E1 VA: 0x38CB2E0
	|-ReadOnlyCollection<RenderGraphDebugData.PassDebugData>.System.Collections.IList.set_Item
	|
	|-RVA: 0x38CC3F0 Offset: 0x38CC4F1 VA: 0x38CC3F0
	|-ReadOnlyCollection<RenderGraphDebugData.ResourceDebugData>.System.Collections.IList.set_Item
	|
	|-RVA: 0x38CD3F0 Offset: 0x38CD4F1 VA: 0x38CD3F0
	|-ReadOnlyCollection<RingCleaningUnitSelectMenu.GodParam>.System.Collections.IList.set_Item
	|
	|-RVA: 0x38CE510 Offset: 0x38CE611 VA: 0x38CE510
	|-ReadOnlyCollection<ShadowUtility.Edge>.System.Collections.IList.set_Item
	|
	|-RVA: 0x38CF530 Offset: 0x38CF631 VA: 0x38CF530
	|-ReadOnlyCollection<SkillArray.Entity>.System.Collections.IList.set_Item
	|
	|-RVA: 0x38D06B0 Offset: 0x38D07B1 VA: 0x38D06B0
	|-ReadOnlyCollection<TexturePacker_JsonArray.Frame>.System.Collections.IList.set_Item
	|
	|-RVA: 0x38D1790 Offset: 0x38D1891 VA: 0x38D1790
	|-ReadOnlyCollection<TimeNotificationBehaviour.NotificationEntry>.System.Collections.IList.set_Item
	|
	|-RVA: 0x38D2850 Offset: 0x38D2951 VA: 0x38D2850
	|-ReadOnlyCollection<UnitySynchronizationContext.WorkRequest>.System.Collections.IList.set_Item
	|
	|-RVA: 0x38D3840 Offset: 0x38D3941 VA: 0x38D3840
	|-ReadOnlyCollection<XmlSchemaObjectTable.XmlSchemaObjectEntry>.System.Collections.IList.set_Item
	|
	|-RVA: 0x38D4830 Offset: 0x38D4931 VA: 0x38D4830
	|-ReadOnlyCollection<AssetBundleBuildMap.AssetBundleEntry.AssetPathString>.System.Collections.IList.set_Item
	|
	|-RVA: 0x38D5940 Offset: 0x38D5A41 VA: 0x38D5940
	|-ReadOnlyCollection<Detail.DataStore.DataStoreChangeMetaParamInt>.System.Collections.IList.set_Item
	|
	|-RVA: 0x38D6960 Offset: 0x38D6A61 VA: 0x38D6960
	|-ReadOnlyCollection<Detail.DataStore.DataStoreDeleteParamInt>.System.Collections.IList.set_Item
	|
	|-RVA: 0x38D7A70 Offset: 0x38D7B71 VA: 0x38D7A70
	|-ReadOnlyCollection<Detail.DataStore.DataStoreGetMetaParamInt>.System.Collections.IList.set_Item
	|
	|-RVA: 0x38D8B80 Offset: 0x38D8C81 VA: 0x38D8B80
	|-ReadOnlyCollection<Detail.DataStore.DataStoreMetaInfoInt>.System.Collections.IList.set_Item
	|
	|-RVA: 0x38D9C60 Offset: 0x38D9D61 VA: 0x38D9C60
	|-ReadOnlyCollection<Detail.DataStore.DataStorePasswordInfoInt>.System.Collections.IList.set_Item
	|
	|-RVA: 0x38DAD20 Offset: 0x38DAE21 VA: 0x38DAD20
	|-ReadOnlyCollection<Detail.DataStore.DataStorePersistenceInfoInt>.System.Collections.IList.set_Item
	|
	|-RVA: 0x38DBE20 Offset: 0x38DBF21 VA: 0x38DBE20
	|-ReadOnlyCollection<Detail.DataStore.DataStorePreparePostParamInt>.System.Collections.IList.set_Item
	|
	|-RVA: 0x38DCE30 Offset: 0x38DCF31 VA: 0x38DCE30
	|-ReadOnlyCollection<Detail.DataStore.DataStoreRateObjectParamInt>.System.Collections.IList.set_Item
	|
	|-RVA: 0x38DDEF0 Offset: 0x38DDFF1 VA: 0x38DDEF0
	|-ReadOnlyCollection<Detail.DataStore.DataStoreRatingInitParamInt>.System.Collections.IList.set_Item
	|
	|-RVA: 0x38DEEE0 Offset: 0x38DEFE1 VA: 0x38DEEE0
	|-ReadOnlyCollection<Detail.DataStore.DataStoreRatingTargetInt>.System.Collections.IList.set_Item
	|
	|-RVA: 0x38E0050 Offset: 0x38E0151 VA: 0x38E0050
	|-ReadOnlyCollection<Detail.Ranking.RankingCachedResultInt>.System.Collections.IList.set_Item
	|
	|-RVA: 0x38E1060 Offset: 0x38E1161 VA: 0x38E1060
	|-ReadOnlyCollection<Detail.Ranking.RankingOrderParamInt>.System.Collections.IList.set_Item
	|
	|-RVA: 0x38E21D0 Offset: 0x38E22D1 VA: 0x38E21D0
	|-ReadOnlyCollection<Detail.Ranking.RankingRankDataInt>.System.Collections.IList.set_Item
	|
	|-RVA: 0x38E34B0 Offset: 0x38E35B1 VA: 0x38E34B0
	|-ReadOnlyCollection<Detail.Ranking2.Ranking2ChartInfoInt>.System.Collections.IList.set_Item
	|
	|-RVA: 0x38E4670 Offset: 0x38E4771 VA: 0x38E4670
	|-ReadOnlyCollection<Detail.Ranking2.Ranking2RankDataInt>.System.Collections.IList.set_Item
	|
	|-RVA: 0x38E5680 Offset: 0x38E5781 VA: 0x38E5680
	|-ReadOnlyCollection<Detail.Ranking2.Ranking2ScoreDataInt>.System.Collections.IList.set_Item
	|
	|-RVA: 0x38E6740 Offset: 0x38E6841 VA: 0x38E6740
	|-ReadOnlyCollection<Detail.Screening.ScreeningContextInfoInt>.System.Collections.IList.set_Item
	|
	|-RVA: 0x38E7950 Offset: 0x38E7A51 VA: 0x38E7950
	|-ReadOnlyCollection<Detail.Subscriber.SubscriberContentInt>.System.Collections.IList.set_Item
	|
	|-RVA: 0x38E8A50 Offset: 0x38E8B51 VA: 0x38E8A50
	|-ReadOnlyCollection<Detail.Subscriber.SubscriberGetContentParamInt>.System.Collections.IList.set_Item
	|
	|-RVA: 0x38E9B60 Offset: 0x38E9C61 VA: 0x38E9B60
	|-ReadOnlyCollection<Detail.Subscriber.SubscriberUserStatusInfoInt>.System.Collections.IList.set_Item
	|
	|-RVA: 0x38EAC30 Offset: 0x38EAD31 VA: 0x38EAC30
	|-ReadOnlyCollection<Detail.Subscriber.SubscriberUserStatusParamInt>.System.Collections.IList.set_Item
	|
	|-RVA: 0x38EBC00 Offset: 0x38EBD01 VA: 0x38EBC00
	|-ReadOnlyCollection<Detail.Utility.IntegerSettings>.System.Collections.IList.set_Item
	|
	|-RVA: 0x38ECC00 Offset: 0x38ECD01 VA: 0x38ECC00
	|-ReadOnlyCollection<Detail.Utility.UniqueIdInfoInt>.System.Collections.IList.set_Item
	|
	|-RVA: 0x38EDC20 Offset: 0x38EDD21 VA: 0x38EDC20
	|-ReadOnlyCollection<MapHistory.Rewind.LatestInspectorData>.System.Collections.IList.set_Item
	|
	|-RVA: 0x38EEC50 Offset: 0x38EED51 VA: 0x38EEC50
	|-ReadOnlyCollection<MapHistory.Rewind.WorkTerrainData>.System.Collections.IList.set_Item
	|
	|-RVA: 0x38EFC50 Offset: 0x38EFD51 VA: 0x38EFC50
	|-ReadOnlyCollection<MapSkill.AroundCalculator.Result>.System.Collections.IList.set_Item
	|
	|-RVA: 0x38F0D70 Offset: 0x38F0E71 VA: 0x38F0D70
	|-ReadOnlyCollection<TargetPositionCache.CacheCurve.Item>.System.Collections.IList.set_Item
	|
	|-RVA: 0x2FE6310 Offset: 0x2FE6411 VA: 0x2FE6310
	|-ReadOnlyCollection<TargetPositionCache.CacheEntry.RecordingItem>.System.Collections.IList.set_Item
	*/

	// RVA: -1 Offset: -1 Slot: 20
	private int System.Collections.IList.Add(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3468130 Offset: 0x3468231 VA: 0x3468130
	|-ReadOnlyCollection<IntervalTree.Entry<object>>.System.Collections.IList.Add
	|
	|-RVA: 0x3469120 Offset: 0x3469221 VA: 0x3469120
	|-ReadOnlyCollection<KeyValuePair<DateTime, object>>.System.Collections.IList.Add
	|
	|-RVA: 0x346A110 Offset: 0x346A211 VA: 0x346A110
	|-ReadOnlyCollection<KeyValuePair<int, object>>.System.Collections.IList.Add
	|
	|-RVA: 0x346B1D0 Offset: 0x346B2D1 VA: 0x346B1D0
	|-ReadOnlyCollection<KeyValuePair<object, ValueTuple<int, DateTime, object>>>.System.Collections.IList.Add
	|
	|-RVA: 0x346C1C0 Offset: 0x346C2C1 VA: 0x346C1C0
	|-ReadOnlyCollection<KeyValuePair<object, object>>.System.Collections.IList.Add
	|
	|-RVA: 0x346D280 Offset: 0x346D381 VA: 0x346D280
	|-ReadOnlyCollection<CommonBattleSequence.Reliance<object>>.System.Collections.IList.Add
	|
	|-RVA: 0x346E270 Offset: 0x346E371 VA: 0x346E270
	|-ReadOnlyCollection<RenderGraphResourcePool.ResourceLogInfo<object>>.System.Collections.IList.Add
	|
	|-RVA: 0x346F260 Offset: 0x346F361 VA: 0x346F260
	|-ReadOnlyCollection<ValueTuple<int, object>>.System.Collections.IList.Add
	|
	|-RVA: 0x3470230 Offset: 0x3470331 VA: 0x3470230
	|-ReadOnlyCollection<ValueTuple<Int32Enum, int>>.System.Collections.IList.Add
	|
	|-RVA: 0x3471300 Offset: 0x3471401 VA: 0x3471300
	|-ReadOnlyCollection<ValueTuple<object, ValueTuple<object, int>>>.System.Collections.IList.Add
	|
	|-RVA: 0x34722F0 Offset: 0x34723F1 VA: 0x34722F0
	|-ReadOnlyCollection<ValueTuple<object, int>>.System.Collections.IList.Add
	|
	|-RVA: 0x3473310 Offset: 0x3473411 VA: 0x3473310
	|-ReadOnlyCollection<ValueTuple<Vector3, float>>.System.Collections.IList.Add
	|
	|-RVA: 0x3474300 Offset: 0x3474401 VA: 0x3474300
	|-ReadOnlyCollection<ValueTuple<object, Int32Enum, int>>.System.Collections.IList.Add
	|
	|-RVA: 0x34753C0 Offset: 0x34754C1 VA: 0x34753C0
	|-ReadOnlyCollection<ValueTuple<object, int, int, int>>.System.Collections.IList.Add
	|
	|-RVA: 0x3476390 Offset: 0x3476491 VA: 0x3476390
	|-ReadOnlyCollection<AnimatorClipInfo>.System.Collections.IList.Add
	|
	|-RVA: 0x3B23200 Offset: 0x3B23301 VA: 0x3B23200
	|-ReadOnlyCollection<AsyncOperationHandle>.System.Collections.IList.Add
	|
	|-RVA: 0x3B242C0 Offset: 0x3B243C1 VA: 0x3B242C0
	|-ReadOnlyCollection<BoneWeight>.System.Collections.IList.Add
	|
	|-RVA: 0x3B252A0 Offset: 0x3B253A1 VA: 0x3B252A0
	|-ReadOnlyCollection<bool>.System.Collections.IList.Add
	|
	|-RVA: 0x3B26280 Offset: 0x3B26381 VA: 0x3B26280
	|-ReadOnlyCollection<byte>.System.Collections.IList.Add
	|
	|-RVA: 0x3B27280 Offset: 0x3B27381 VA: 0x3B27280
	|-ReadOnlyCollection<CameraInfo>.System.Collections.IList.Add
	|
	|-RVA: 0x3B28250 Offset: 0x3B28351 VA: 0x3B28250
	|-ReadOnlyCollection<char>.System.Collections.IList.Add
	|
	|-RVA: 0x3B29280 Offset: 0x3B29381 VA: 0x3B29280
	|-ReadOnlyCollection<Color>.System.Collections.IList.Add
	|
	|-RVA: 0x3B2A290 Offset: 0x3B2A391 VA: 0x3B2A290
	|-ReadOnlyCollection<Color32>.System.Collections.IList.Add
	|
	|-RVA: 0x3B2B290 Offset: 0x3B2B391 VA: 0x3B2B290
	|-ReadOnlyCollection<ConstraintSource>.System.Collections.IList.Add
	|
	|-RVA: 0x3B2C350 Offset: 0x3B2C451 VA: 0x3B2C350
	|-ReadOnlyCollection<ContourVertex>.System.Collections.IList.Add
	|
	|-RVA: 0x3B2D410 Offset: 0x3B2D511 VA: 0x3B2D410
	|-ReadOnlyCollection<CustomAttributeNamedArgument>.System.Collections.IList.Add
	|
	|-RVA: 0x3B2E400 Offset: 0x3B2E501 VA: 0x3B2E400
	|-ReadOnlyCollection<CustomAttributeTypedArgument>.System.Collections.IList.Add
	|
	|-RVA: 0x3B2F4C0 Offset: 0x3B2F5C1 VA: 0x3B2F4C0
	|-ReadOnlyCollection<DataStoreRatingInfo>.System.Collections.IList.Add
	|
	|-RVA: 0x3B30490 Offset: 0x3B30591 VA: 0x3B30490
	|-ReadOnlyCollection<DataStoreResult>.System.Collections.IList.Add
	|
	|-RVA: 0x3B31470 Offset: 0x3B31571 VA: 0x3B31470
	|-ReadOnlyCollection<DateTime>.System.Collections.IList.Add
	|
	|-RVA: 0x3B32470 Offset: 0x3B32571 VA: 0x3B32470
	|-ReadOnlyCollection<DateTimeOffset>.System.Collections.IList.Add
	|
	|-RVA: 0x3B33460 Offset: 0x3B33561 VA: 0x3B33460
	|-ReadOnlyCollection<Decimal>.System.Collections.IList.Add
	|
	|-RVA: 0x3B34580 Offset: 0x3B34681 VA: 0x3B34580
	|-ReadOnlyCollection<DiagnosticEvent>.System.Collections.IList.Add
	|
	|-RVA: 0x3B35560 Offset: 0x3B35661 VA: 0x3B35560
	|-ReadOnlyCollection<double>.System.Collections.IList.Add
	|
	|-RVA: 0x3B366A0 Offset: 0x3B367A1 VA: 0x3B366A0
	|-ReadOnlyCollection<Friend>.System.Collections.IList.Add
	|
	|-RVA: 0x3B37690 Offset: 0x3B37791 VA: 0x3B37690
	|-ReadOnlyCollection<GlyphRect>.System.Collections.IList.Add
	|
	|-RVA: 0x3B38660 Offset: 0x3B38761 VA: 0x3B38660
	|-ReadOnlyCollection<short>.System.Collections.IList.Add
	|
	|-RVA: 0x3B39640 Offset: 0x3B39741 VA: 0x3B39640
	|-ReadOnlyCollection<int>.System.Collections.IList.Add
	|
	|-RVA: 0x3B3A620 Offset: 0x3B3A721 VA: 0x3B3A620
	|-ReadOnlyCollection<Int32Enum>.System.Collections.IList.Add
	|
	|-RVA: 0x3B3B600 Offset: 0x3B3B701 VA: 0x3B3B600
	|-ReadOnlyCollection<long>.System.Collections.IList.Add
	|
	|-RVA: 0x3B3C5E0 Offset: 0x3B3C6E1 VA: 0x3B3C5E0
	|-ReadOnlyCollection<IntPtr>.System.Collections.IList.Add
	|
	|-RVA: 0x3B3D5E0 Offset: 0x3B3D6E1 VA: 0x3B3D5E0
	|-ReadOnlyCollection<InterpretedFrameInfo>.System.Collections.IList.Add
	|
	|-RVA: 0x3B3E6A0 Offset: 0x3B3E7A1 VA: 0x3B3E6A0
	|-ReadOnlyCollection<IntervalTreeNode>.System.Collections.IList.Add
	|
	|-RVA: 0x3B3F670 Offset: 0x3B3F771 VA: 0x3B3F670
	|-ReadOnlyCollection<LengthLimitProperties>.System.Collections.IList.Add
	|
	|-RVA: 0x3B40650 Offset: 0x3B40751 VA: 0x3B40650
	|-ReadOnlyCollection<MapPos>.System.Collections.IList.Add
	|
	|-RVA: 0x3B417D0 Offset: 0x3B418D1 VA: 0x3B417D0
	|-ReadOnlyCollection<Matrix4x4>.System.Collections.IList.Add
	|
	|-RVA: 0x3B42760 Offset: 0x3B42861 VA: 0x3B42760
	|-ReadOnlyCollection<object>.System.Collections.IList.Add
	|
	|-RVA: 0x3B43800 Offset: 0x3B43901 VA: 0x3B43800
	|-ReadOnlyCollection<ObjectInitializationData>.System.Collections.IList.Add
	|
	|-RVA: 0x3B448D0 Offset: 0x3B449D1 VA: 0x3B448D0
	|-ReadOnlyCollection<PlayableBinding>.System.Collections.IList.Add
	|
	|-RVA: 0x3B459E0 Offset: 0x3B45AE1 VA: 0x3B459E0
	|-ReadOnlyCollection<PlayerLoopSystem>.System.Collections.IList.Add
	|
	|-RVA: 0x3B46B00 Offset: 0x3B46C01 VA: 0x3B46B00
	|-ReadOnlyCollection<PlayerLoopSystemInternal>.System.Collections.IList.Add
	|
	|-RVA: 0x3B47B00 Offset: 0x3B47C01 VA: 0x3B47B00
	|-ReadOnlyCollection<RangePositionInfo>.System.Collections.IList.Add
	|
	|-RVA: 0x3B48AD0 Offset: 0x3B48BD1 VA: 0x3B48AD0
	|-ReadOnlyCollection<Ranking2ChartInfoInput>.System.Collections.IList.Add
	|
	|-RVA: 0x3B49C20 Offset: 0x3B49D21 VA: 0x3B49C20
	|-ReadOnlyCollection<RaycastHit2D>.System.Collections.IList.Add
	|
	|-RVA: 0x3B4AE50 Offset: 0x3B4AF51 VA: 0x3B4AE50
	|-ReadOnlyCollection<RaycastResult>.System.Collections.IList.Add
	|
	|-RVA: 0x3B4BEB0 Offset: 0x3B4BFB1 VA: 0x3B4BEB0
	|-ReadOnlyCollection<Rect>.System.Collections.IList.Add
	|
	|-RVA: 0x3B4CE80 Offset: 0x3B4CF81 VA: 0x3B4CE80
	|-ReadOnlyCollection<RendererListHandle>.System.Collections.IList.Add
	|
	|-RVA: 0x3B4DE60 Offset: 0x3B4DF61 VA: 0x3B4DE60
	|-ReadOnlyCollection<ResourceHandle>.System.Collections.IList.Add
	|
	|-RVA: 0x3AAF520 Offset: 0x3AAF621 VA: 0x3AAF520
	|-ReadOnlyCollection<sbyte>.System.Collections.IList.Add
	|
	|-RVA: 0x3AB0540 Offset: 0x3AB0641 VA: 0x3AB0540
	|-ReadOnlyCollection<ShaderTagId>.System.Collections.IList.Add
	|
	|-RVA: 0x3AB1520 Offset: 0x3AB1621 VA: 0x3AB1520
	|-ReadOnlyCollection<float>.System.Collections.IList.Add
	|
	|-RVA: 0x3AB28B0 Offset: 0x3AB29B1 VA: 0x3AB28B0
	|-ReadOnlyCollection<SphericalHarmonicsL2>.System.Collections.IList.Add
	|
	|-RVA: 0x3AB3A40 Offset: 0x3AB3B41 VA: 0x3AB3A40
	|-ReadOnlyCollection<SubMeshDescriptor>.System.Collections.IList.Add
	|
	|-RVA: 0x3AB4A40 Offset: 0x3AB4B41 VA: 0x3AB4A40
	|-ReadOnlyCollection<TablePair>.System.Collections.IList.Add
	|
	|-RVA: 0x3AB5A10 Offset: 0x3AB5B11 VA: 0x3AB5A10
	|-ReadOnlyCollection<TimeSpan>.System.Collections.IList.Add
	|
	|-RVA: 0x3AB6A40 Offset: 0x3AB6B41 VA: 0x3AB6A40
	|-ReadOnlyCollection<UICharInfo>.System.Collections.IList.Add
	|
	|-RVA: 0x3AB7A30 Offset: 0x3AB7B31 VA: 0x3AB7A30
	|-ReadOnlyCollection<UILineInfo>.System.Collections.IList.Add
	|
	|-RVA: 0x3AB8DB0 Offset: 0x3AB8EB1 VA: 0x3AB8DB0
	|-ReadOnlyCollection<UIVertex>.System.Collections.IList.Add
	|
	|-RVA: 0x3AB9DF0 Offset: 0x3AB9EF1 VA: 0x3AB9DF0
	|-ReadOnlyCollection<ushort>.System.Collections.IList.Add
	|
	|-RVA: 0x3ABADD0 Offset: 0x3ABAED1 VA: 0x3ABADD0
	|-ReadOnlyCollection<uint>.System.Collections.IList.Add
	|
	|-RVA: 0x3ABBDB0 Offset: 0x3ABBEB1 VA: 0x3ABBDB0
	|-ReadOnlyCollection<ulong>.System.Collections.IList.Add
	|
	|-RVA: 0x3ABCDB0 Offset: 0x3ABCEB1 VA: 0x3ABCDB0
	|-ReadOnlyCollection<Vector2>.System.Collections.IList.Add
	|
	|-RVA: 0x3ABDDE0 Offset: 0x3ABDEE1 VA: 0x3ABDDE0
	|-ReadOnlyCollection<Vector3>.System.Collections.IList.Add
	|
	|-RVA: 0x3ABEE00 Offset: 0x3ABEF01 VA: 0x3ABEE00
	|-ReadOnlyCollection<Vector4>.System.Collections.IList.Add
	|
	|-RVA: 0x3ABFDF0 Offset: 0x3ABFEF1 VA: 0x3ABFDF0
	|-ReadOnlyCollection<VertexAttributeDescriptor>.System.Collections.IList.Add
	|
	|-RVA: 0x3AC0DE0 Offset: 0x3AC0EE1 VA: 0x3AC0DE0
	|-ReadOnlyCollection<X509ChainStatus>.System.Collections.IList.Add
	|
	|-RVA: 0x3AC1EE0 Offset: 0x3AC1FE1 VA: 0x3AC1EE0
	|-ReadOnlyCollection<XRView>.System.Collections.IList.Add
	|
	|-RVA: 0x3AC2F20 Offset: 0x3AC3021 VA: 0x3AC2F20
	|-ReadOnlyCollection<AICrossfire.PositionTable>.System.Collections.IList.Add
	|
	|-RVA: 0x3AC3F20 Offset: 0x3AC4021 VA: 0x3AC3F20
	|-ReadOnlyCollection<AmiiboSequence.GainItemData>.System.Collections.IList.Add
	|
	|-RVA: 0x3AC5030 Offset: 0x3AC5131 VA: 0x3AC5030
	|-ReadOnlyCollection<AnimationOutputWeightProcessor.WeightInfo>.System.Collections.IList.Add
	|
	|-RVA: 0x3AC6030 Offset: 0x3AC6131 VA: 0x3AC6030
	|-ReadOnlyCollection<ArenaOrderSequence.GodInfo>.System.Collections.IList.Add
	|
	|-RVA: 0x3AC7020 Offset: 0x3AC7121 VA: 0x3AC7020
	|-ReadOnlyCollection<BattleInfo.SupportData>.System.Collections.IList.Add
	|
	|-RVA: 0x3AC8010 Offset: 0x3AC8111 VA: 0x3AC8010
	|-ReadOnlyCollection<BeforeRenderHelper.OrderBlock>.System.Collections.IList.Add
	|
	|-RVA: 0x3AC90D0 Offset: 0x3AC91D1 VA: 0x3AC90D0
	|-ReadOnlyCollection<Camera.RenderRequest>.System.Collections.IList.Add
	|
	|-RVA: 0x3ACA0C0 Offset: 0x3ACA1C1 VA: 0x3ACA0C0
	|-ReadOnlyCollection<CameraState.CustomBlendable>.System.Collections.IList.Add
	|
	|-RVA: 0x3ACB090 Offset: 0x3ACB191 VA: 0x3ACB090
	|-ReadOnlyCollection<CinemachineClearShot.Pair>.System.Collections.IList.Add
	|
	|-RVA: 0x3ACC070 Offset: 0x3ACC171 VA: 0x3ACC070
	|-ReadOnlyCollection<CinemachineStateDrivenCamera.HashPair>.System.Collections.IList.Add
	|
	|-RVA: 0x3ACD140 Offset: 0x3ACD241 VA: 0x3ACD140
	|-ReadOnlyCollection<DelayedActionManager.DelegateInfo>.System.Collections.IList.Add
	|
	|-RVA: 0x3ACE260 Offset: 0x3ACE361 VA: 0x3ACE260
	|-ReadOnlyCollection<Detail.AsyncResultInt>.System.Collections.IList.Add
	|
	|-RVA: 0x3ACF260 Offset: 0x3ACF361 VA: 0x3ACF260
	|-ReadOnlyCollection<Detail.CppArray>.System.Collections.IList.Add
	|
	|-RVA: 0x3AD0380 Offset: 0x3AD0481 VA: 0x3AD0380
	|-ReadOnlyCollection<Detail.NotificationEventInt>.System.Collections.IList.Add
	|
	|-RVA: 0x3AD1380 Offset: 0x3AD1481 VA: 0x3AD1380
	|-ReadOnlyCollection<DragonRideTargetGroup.ChainParam>.System.Collections.IList.Add
	|
	|-RVA: 0x3AD2440 Offset: 0x3AD2541 VA: 0x3AD2440
	|-ReadOnlyCollection<GmapPathAdjuster.TargetModel>.System.Collections.IList.Add
	|
	|-RVA: 0x3AD3500 Offset: 0x3AD3601 VA: 0x3AD3500
	|-ReadOnlyCollection<GmapSpotAdjuster.TargetModel>.System.Collections.IList.Add
	|
	|-RVA: 0x3AD45C0 Offset: 0x3AD46C1 VA: 0x3AD45C0
	|-ReadOnlyCollection<HubFastTravel.Location>.System.Collections.IList.Add
	|
	|-RVA: 0x3AD56E0 Offset: 0x3AD57E1 VA: 0x3AD56E0
	|-ReadOnlyCollection<HubLensFlare.Flare>.System.Collections.IList.Add
	|
	|-RVA: 0x3AD66E0 Offset: 0x3AD67E1 VA: 0x3AD66E0
	|-ReadOnlyCollection<InventoryPoolItemMenuContent.KindBgNameClass>.System.Collections.IList.Add
	|
	|-RVA: 0x3AD76B0 Offset: 0x3AD77B1 VA: 0x3AD76B0
	|-ReadOnlyCollection<Map.Pos>.System.Collections.IList.Add
	|
	|-RVA: 0x3AD86B0 Offset: 0x3AD87B1 VA: 0x3AD86B0
	|-ReadOnlyCollection<MapImage.BackupTerrain>.System.Collections.IList.Add
	|
	|-RVA: 0x3AD96C0 Offset: 0x3AD97C1 VA: 0x3AD96C0
	|-ReadOnlyCollection<MapImageRange.Pos>.System.Collections.IList.Add
	|
	|-RVA: 0x3ADA790 Offset: 0x3ADA891 VA: 0x3ADA790
	|-ReadOnlyCollection<MapMind.Target>.System.Collections.IList.Add
	|
	|-RVA: 0x38C5170 Offset: 0x38C5271 VA: 0x38C5170
	|-ReadOnlyCollection<MapPanelDebug.Entity>.System.Collections.IList.Add
	|
	|-RVA: 0x38C6140 Offset: 0x38C6241 VA: 0x38C6140
	|-ReadOnlyCollection<NexRanking.Data>.System.Collections.IList.Add
	|
	|-RVA: 0x38C7140 Offset: 0x38C7241 VA: 0x38C7140
	|-ReadOnlyCollection<NexVersus.RatingData>.System.Collections.IList.Add
	|
	|-RVA: 0x38C8130 Offset: 0x38C8231 VA: 0x38C8130
	|-ReadOnlyCollection<PackedPlayModeBuildLogs.RuntimeBuildLog>.System.Collections.IList.Add
	|
	|-RVA: 0x38C9230 Offset: 0x38C9331 VA: 0x38C9230
	|-ReadOnlyCollection<ParticleSystem.Particle>.System.Collections.IList.Add
	|
	|-RVA: 0x38CA220 Offset: 0x38CA321 VA: 0x38CA220
	|-ReadOnlyCollection<RangeData.Offset>.System.Collections.IList.Add
	|
	|-RVA: 0x38CB2F0 Offset: 0x38CB3F1 VA: 0x38CB2F0
	|-ReadOnlyCollection<RenderGraphDebugData.PassDebugData>.System.Collections.IList.Add
	|
	|-RVA: 0x38CC400 Offset: 0x38CC501 VA: 0x38CC400
	|-ReadOnlyCollection<RenderGraphDebugData.ResourceDebugData>.System.Collections.IList.Add
	|
	|-RVA: 0x38CD400 Offset: 0x38CD501 VA: 0x38CD400
	|-ReadOnlyCollection<RingCleaningUnitSelectMenu.GodParam>.System.Collections.IList.Add
	|
	|-RVA: 0x38CE520 Offset: 0x38CE621 VA: 0x38CE520
	|-ReadOnlyCollection<ShadowUtility.Edge>.System.Collections.IList.Add
	|
	|-RVA: 0x38CF540 Offset: 0x38CF641 VA: 0x38CF540
	|-ReadOnlyCollection<SkillArray.Entity>.System.Collections.IList.Add
	|
	|-RVA: 0x38D06C0 Offset: 0x38D07C1 VA: 0x38D06C0
	|-ReadOnlyCollection<TexturePacker_JsonArray.Frame>.System.Collections.IList.Add
	|
	|-RVA: 0x38D17A0 Offset: 0x38D18A1 VA: 0x38D17A0
	|-ReadOnlyCollection<TimeNotificationBehaviour.NotificationEntry>.System.Collections.IList.Add
	|
	|-RVA: 0x38D2860 Offset: 0x38D2961 VA: 0x38D2860
	|-ReadOnlyCollection<UnitySynchronizationContext.WorkRequest>.System.Collections.IList.Add
	|
	|-RVA: 0x38D3850 Offset: 0x38D3951 VA: 0x38D3850
	|-ReadOnlyCollection<XmlSchemaObjectTable.XmlSchemaObjectEntry>.System.Collections.IList.Add
	|
	|-RVA: 0x38D4840 Offset: 0x38D4941 VA: 0x38D4840
	|-ReadOnlyCollection<AssetBundleBuildMap.AssetBundleEntry.AssetPathString>.System.Collections.IList.Add
	|
	|-RVA: 0x38D5950 Offset: 0x38D5A51 VA: 0x38D5950
	|-ReadOnlyCollection<Detail.DataStore.DataStoreChangeMetaParamInt>.System.Collections.IList.Add
	|
	|-RVA: 0x38D6970 Offset: 0x38D6A71 VA: 0x38D6970
	|-ReadOnlyCollection<Detail.DataStore.DataStoreDeleteParamInt>.System.Collections.IList.Add
	|
	|-RVA: 0x38D7A80 Offset: 0x38D7B81 VA: 0x38D7A80
	|-ReadOnlyCollection<Detail.DataStore.DataStoreGetMetaParamInt>.System.Collections.IList.Add
	|
	|-RVA: 0x38D8B90 Offset: 0x38D8C91 VA: 0x38D8B90
	|-ReadOnlyCollection<Detail.DataStore.DataStoreMetaInfoInt>.System.Collections.IList.Add
	|
	|-RVA: 0x38D9C70 Offset: 0x38D9D71 VA: 0x38D9C70
	|-ReadOnlyCollection<Detail.DataStore.DataStorePasswordInfoInt>.System.Collections.IList.Add
	|
	|-RVA: 0x38DAD30 Offset: 0x38DAE31 VA: 0x38DAD30
	|-ReadOnlyCollection<Detail.DataStore.DataStorePersistenceInfoInt>.System.Collections.IList.Add
	|
	|-RVA: 0x38DBE30 Offset: 0x38DBF31 VA: 0x38DBE30
	|-ReadOnlyCollection<Detail.DataStore.DataStorePreparePostParamInt>.System.Collections.IList.Add
	|
	|-RVA: 0x38DCE40 Offset: 0x38DCF41 VA: 0x38DCE40
	|-ReadOnlyCollection<Detail.DataStore.DataStoreRateObjectParamInt>.System.Collections.IList.Add
	|
	|-RVA: 0x38DDF00 Offset: 0x38DE001 VA: 0x38DDF00
	|-ReadOnlyCollection<Detail.DataStore.DataStoreRatingInitParamInt>.System.Collections.IList.Add
	|
	|-RVA: 0x38DEEF0 Offset: 0x38DEFF1 VA: 0x38DEEF0
	|-ReadOnlyCollection<Detail.DataStore.DataStoreRatingTargetInt>.System.Collections.IList.Add
	|
	|-RVA: 0x38E0060 Offset: 0x38E0161 VA: 0x38E0060
	|-ReadOnlyCollection<Detail.Ranking.RankingCachedResultInt>.System.Collections.IList.Add
	|
	|-RVA: 0x38E1070 Offset: 0x38E1171 VA: 0x38E1070
	|-ReadOnlyCollection<Detail.Ranking.RankingOrderParamInt>.System.Collections.IList.Add
	|
	|-RVA: 0x38E21E0 Offset: 0x38E22E1 VA: 0x38E21E0
	|-ReadOnlyCollection<Detail.Ranking.RankingRankDataInt>.System.Collections.IList.Add
	|
	|-RVA: 0x38E34C0 Offset: 0x38E35C1 VA: 0x38E34C0
	|-ReadOnlyCollection<Detail.Ranking2.Ranking2ChartInfoInt>.System.Collections.IList.Add
	|
	|-RVA: 0x38E4680 Offset: 0x38E4781 VA: 0x38E4680
	|-ReadOnlyCollection<Detail.Ranking2.Ranking2RankDataInt>.System.Collections.IList.Add
	|
	|-RVA: 0x38E5690 Offset: 0x38E5791 VA: 0x38E5690
	|-ReadOnlyCollection<Detail.Ranking2.Ranking2ScoreDataInt>.System.Collections.IList.Add
	|
	|-RVA: 0x38E6750 Offset: 0x38E6851 VA: 0x38E6750
	|-ReadOnlyCollection<Detail.Screening.ScreeningContextInfoInt>.System.Collections.IList.Add
	|
	|-RVA: 0x38E7960 Offset: 0x38E7A61 VA: 0x38E7960
	|-ReadOnlyCollection<Detail.Subscriber.SubscriberContentInt>.System.Collections.IList.Add
	|
	|-RVA: 0x38E8A60 Offset: 0x38E8B61 VA: 0x38E8A60
	|-ReadOnlyCollection<Detail.Subscriber.SubscriberGetContentParamInt>.System.Collections.IList.Add
	|
	|-RVA: 0x38E9B70 Offset: 0x38E9C71 VA: 0x38E9B70
	|-ReadOnlyCollection<Detail.Subscriber.SubscriberUserStatusInfoInt>.System.Collections.IList.Add
	|
	|-RVA: 0x38EAC40 Offset: 0x38EAD41 VA: 0x38EAC40
	|-ReadOnlyCollection<Detail.Subscriber.SubscriberUserStatusParamInt>.System.Collections.IList.Add
	|
	|-RVA: 0x38EBC10 Offset: 0x38EBD11 VA: 0x38EBC10
	|-ReadOnlyCollection<Detail.Utility.IntegerSettings>.System.Collections.IList.Add
	|
	|-RVA: 0x38ECC10 Offset: 0x38ECD11 VA: 0x38ECC10
	|-ReadOnlyCollection<Detail.Utility.UniqueIdInfoInt>.System.Collections.IList.Add
	|
	|-RVA: 0x38EDC30 Offset: 0x38EDD31 VA: 0x38EDC30
	|-ReadOnlyCollection<MapHistory.Rewind.LatestInspectorData>.System.Collections.IList.Add
	|
	|-RVA: 0x38EEC60 Offset: 0x38EED61 VA: 0x38EEC60
	|-ReadOnlyCollection<MapHistory.Rewind.WorkTerrainData>.System.Collections.IList.Add
	|
	|-RVA: 0x38EFC60 Offset: 0x38EFD61 VA: 0x38EFC60
	|-ReadOnlyCollection<MapSkill.AroundCalculator.Result>.System.Collections.IList.Add
	|
	|-RVA: 0x38F0D80 Offset: 0x38F0E81 VA: 0x38F0D80
	|-ReadOnlyCollection<TargetPositionCache.CacheCurve.Item>.System.Collections.IList.Add
	|
	|-RVA: 0x2FE6320 Offset: 0x2FE6421 VA: 0x2FE6320
	|-ReadOnlyCollection<TargetPositionCache.CacheEntry.RecordingItem>.System.Collections.IList.Add
	*/

	// RVA: -1 Offset: -1 Slot: 22
	private void System.Collections.IList.Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3468150 Offset: 0x3468251 VA: 0x3468150
	|-ReadOnlyCollection<IntervalTree.Entry<object>>.System.Collections.IList.Clear
	|
	|-RVA: 0x3469140 Offset: 0x3469241 VA: 0x3469140
	|-ReadOnlyCollection<KeyValuePair<DateTime, object>>.System.Collections.IList.Clear
	|
	|-RVA: 0x346A130 Offset: 0x346A231 VA: 0x346A130
	|-ReadOnlyCollection<KeyValuePair<int, object>>.System.Collections.IList.Clear
	|
	|-RVA: 0x346B1F0 Offset: 0x346B2F1 VA: 0x346B1F0
	|-ReadOnlyCollection<KeyValuePair<object, ValueTuple<int, DateTime, object>>>.System.Collections.IList.Clear
	|
	|-RVA: 0x346C1E0 Offset: 0x346C2E1 VA: 0x346C1E0
	|-ReadOnlyCollection<KeyValuePair<object, object>>.System.Collections.IList.Clear
	|
	|-RVA: 0x346D2A0 Offset: 0x346D3A1 VA: 0x346D2A0
	|-ReadOnlyCollection<CommonBattleSequence.Reliance<object>>.System.Collections.IList.Clear
	|
	|-RVA: 0x346E290 Offset: 0x346E391 VA: 0x346E290
	|-ReadOnlyCollection<RenderGraphResourcePool.ResourceLogInfo<object>>.System.Collections.IList.Clear
	|
	|-RVA: 0x346F280 Offset: 0x346F381 VA: 0x346F280
	|-ReadOnlyCollection<ValueTuple<int, object>>.System.Collections.IList.Clear
	|
	|-RVA: 0x3470250 Offset: 0x3470351 VA: 0x3470250
	|-ReadOnlyCollection<ValueTuple<Int32Enum, int>>.System.Collections.IList.Clear
	|
	|-RVA: 0x3471320 Offset: 0x3471421 VA: 0x3471320
	|-ReadOnlyCollection<ValueTuple<object, ValueTuple<object, int>>>.System.Collections.IList.Clear
	|
	|-RVA: 0x3472310 Offset: 0x3472411 VA: 0x3472310
	|-ReadOnlyCollection<ValueTuple<object, int>>.System.Collections.IList.Clear
	|
	|-RVA: 0x3473330 Offset: 0x3473431 VA: 0x3473330
	|-ReadOnlyCollection<ValueTuple<Vector3, float>>.System.Collections.IList.Clear
	|
	|-RVA: 0x3474320 Offset: 0x3474421 VA: 0x3474320
	|-ReadOnlyCollection<ValueTuple<object, Int32Enum, int>>.System.Collections.IList.Clear
	|
	|-RVA: 0x34753E0 Offset: 0x34754E1 VA: 0x34753E0
	|-ReadOnlyCollection<ValueTuple<object, int, int, int>>.System.Collections.IList.Clear
	|
	|-RVA: 0x34763B0 Offset: 0x34764B1 VA: 0x34763B0
	|-ReadOnlyCollection<AnimatorClipInfo>.System.Collections.IList.Clear
	|
	|-RVA: 0x3B23220 Offset: 0x3B23321 VA: 0x3B23220
	|-ReadOnlyCollection<AsyncOperationHandle>.System.Collections.IList.Clear
	|
	|-RVA: 0x3B242E0 Offset: 0x3B243E1 VA: 0x3B242E0
	|-ReadOnlyCollection<BoneWeight>.System.Collections.IList.Clear
	|
	|-RVA: 0x3B252C0 Offset: 0x3B253C1 VA: 0x3B252C0
	|-ReadOnlyCollection<bool>.System.Collections.IList.Clear
	|
	|-RVA: 0x3B262A0 Offset: 0x3B263A1 VA: 0x3B262A0
	|-ReadOnlyCollection<byte>.System.Collections.IList.Clear
	|
	|-RVA: 0x3B272A0 Offset: 0x3B273A1 VA: 0x3B272A0
	|-ReadOnlyCollection<CameraInfo>.System.Collections.IList.Clear
	|
	|-RVA: 0x3B28270 Offset: 0x3B28371 VA: 0x3B28270
	|-ReadOnlyCollection<char>.System.Collections.IList.Clear
	|
	|-RVA: 0x3B292A0 Offset: 0x3B293A1 VA: 0x3B292A0
	|-ReadOnlyCollection<Color>.System.Collections.IList.Clear
	|
	|-RVA: 0x3B2A2B0 Offset: 0x3B2A3B1 VA: 0x3B2A2B0
	|-ReadOnlyCollection<Color32>.System.Collections.IList.Clear
	|
	|-RVA: 0x3B2B2B0 Offset: 0x3B2B3B1 VA: 0x3B2B2B0
	|-ReadOnlyCollection<ConstraintSource>.System.Collections.IList.Clear
	|
	|-RVA: 0x3B2C370 Offset: 0x3B2C471 VA: 0x3B2C370
	|-ReadOnlyCollection<ContourVertex>.System.Collections.IList.Clear
	|
	|-RVA: 0x3B2D430 Offset: 0x3B2D531 VA: 0x3B2D430
	|-ReadOnlyCollection<CustomAttributeNamedArgument>.System.Collections.IList.Clear
	|
	|-RVA: 0x3B2E420 Offset: 0x3B2E521 VA: 0x3B2E420
	|-ReadOnlyCollection<CustomAttributeTypedArgument>.System.Collections.IList.Clear
	|
	|-RVA: 0x3B2F4E0 Offset: 0x3B2F5E1 VA: 0x3B2F4E0
	|-ReadOnlyCollection<DataStoreRatingInfo>.System.Collections.IList.Clear
	|
	|-RVA: 0x3B304B0 Offset: 0x3B305B1 VA: 0x3B304B0
	|-ReadOnlyCollection<DataStoreResult>.System.Collections.IList.Clear
	|
	|-RVA: 0x3B31490 Offset: 0x3B31591 VA: 0x3B31490
	|-ReadOnlyCollection<DateTime>.System.Collections.IList.Clear
	|
	|-RVA: 0x3B32490 Offset: 0x3B32591 VA: 0x3B32490
	|-ReadOnlyCollection<DateTimeOffset>.System.Collections.IList.Clear
	|
	|-RVA: 0x3B33480 Offset: 0x3B33581 VA: 0x3B33480
	|-ReadOnlyCollection<Decimal>.System.Collections.IList.Clear
	|
	|-RVA: 0x3B345A0 Offset: 0x3B346A1 VA: 0x3B345A0
	|-ReadOnlyCollection<DiagnosticEvent>.System.Collections.IList.Clear
	|
	|-RVA: 0x3B35580 Offset: 0x3B35681 VA: 0x3B35580
	|-ReadOnlyCollection<double>.System.Collections.IList.Clear
	|
	|-RVA: 0x3B366C0 Offset: 0x3B367C1 VA: 0x3B366C0
	|-ReadOnlyCollection<Friend>.System.Collections.IList.Clear
	|
	|-RVA: 0x3B376B0 Offset: 0x3B377B1 VA: 0x3B376B0
	|-ReadOnlyCollection<GlyphRect>.System.Collections.IList.Clear
	|
	|-RVA: 0x3B38680 Offset: 0x3B38781 VA: 0x3B38680
	|-ReadOnlyCollection<short>.System.Collections.IList.Clear
	|
	|-RVA: 0x3B39660 Offset: 0x3B39761 VA: 0x3B39660
	|-ReadOnlyCollection<int>.System.Collections.IList.Clear
	|
	|-RVA: 0x3B3A640 Offset: 0x3B3A741 VA: 0x3B3A640
	|-ReadOnlyCollection<Int32Enum>.System.Collections.IList.Clear
	|
	|-RVA: 0x3B3B620 Offset: 0x3B3B721 VA: 0x3B3B620
	|-ReadOnlyCollection<long>.System.Collections.IList.Clear
	|
	|-RVA: 0x3B3C600 Offset: 0x3B3C701 VA: 0x3B3C600
	|-ReadOnlyCollection<IntPtr>.System.Collections.IList.Clear
	|
	|-RVA: 0x3B3D600 Offset: 0x3B3D701 VA: 0x3B3D600
	|-ReadOnlyCollection<InterpretedFrameInfo>.System.Collections.IList.Clear
	|
	|-RVA: 0x3B3E6C0 Offset: 0x3B3E7C1 VA: 0x3B3E6C0
	|-ReadOnlyCollection<IntervalTreeNode>.System.Collections.IList.Clear
	|
	|-RVA: 0x3B3F690 Offset: 0x3B3F791 VA: 0x3B3F690
	|-ReadOnlyCollection<LengthLimitProperties>.System.Collections.IList.Clear
	|
	|-RVA: 0x3B40670 Offset: 0x3B40771 VA: 0x3B40670
	|-ReadOnlyCollection<MapPos>.System.Collections.IList.Clear
	|
	|-RVA: 0x3B417F0 Offset: 0x3B418F1 VA: 0x3B417F0
	|-ReadOnlyCollection<Matrix4x4>.System.Collections.IList.Clear
	|
	|-RVA: 0x3B42780 Offset: 0x3B42881 VA: 0x3B42780
	|-ReadOnlyCollection<object>.System.Collections.IList.Clear
	|
	|-RVA: 0x3B43820 Offset: 0x3B43921 VA: 0x3B43820
	|-ReadOnlyCollection<ObjectInitializationData>.System.Collections.IList.Clear
	|
	|-RVA: 0x3B448F0 Offset: 0x3B449F1 VA: 0x3B448F0
	|-ReadOnlyCollection<PlayableBinding>.System.Collections.IList.Clear
	|
	|-RVA: 0x3B45A00 Offset: 0x3B45B01 VA: 0x3B45A00
	|-ReadOnlyCollection<PlayerLoopSystem>.System.Collections.IList.Clear
	|
	|-RVA: 0x3B46B20 Offset: 0x3B46C21 VA: 0x3B46B20
	|-ReadOnlyCollection<PlayerLoopSystemInternal>.System.Collections.IList.Clear
	|
	|-RVA: 0x3B47B20 Offset: 0x3B47C21 VA: 0x3B47B20
	|-ReadOnlyCollection<RangePositionInfo>.System.Collections.IList.Clear
	|
	|-RVA: 0x3B48AF0 Offset: 0x3B48BF1 VA: 0x3B48AF0
	|-ReadOnlyCollection<Ranking2ChartInfoInput>.System.Collections.IList.Clear
	|
	|-RVA: 0x3B49C40 Offset: 0x3B49D41 VA: 0x3B49C40
	|-ReadOnlyCollection<RaycastHit2D>.System.Collections.IList.Clear
	|
	|-RVA: 0x3B4AE70 Offset: 0x3B4AF71 VA: 0x3B4AE70
	|-ReadOnlyCollection<RaycastResult>.System.Collections.IList.Clear
	|
	|-RVA: 0x3B4BED0 Offset: 0x3B4BFD1 VA: 0x3B4BED0
	|-ReadOnlyCollection<Rect>.System.Collections.IList.Clear
	|
	|-RVA: 0x3B4CEA0 Offset: 0x3B4CFA1 VA: 0x3B4CEA0
	|-ReadOnlyCollection<RendererListHandle>.System.Collections.IList.Clear
	|
	|-RVA: 0x3B4DE80 Offset: 0x3B4DF81 VA: 0x3B4DE80
	|-ReadOnlyCollection<ResourceHandle>.System.Collections.IList.Clear
	|
	|-RVA: 0x3AAF540 Offset: 0x3AAF641 VA: 0x3AAF540
	|-ReadOnlyCollection<sbyte>.System.Collections.IList.Clear
	|
	|-RVA: 0x3AB0560 Offset: 0x3AB0661 VA: 0x3AB0560
	|-ReadOnlyCollection<ShaderTagId>.System.Collections.IList.Clear
	|
	|-RVA: 0x3AB1540 Offset: 0x3AB1641 VA: 0x3AB1540
	|-ReadOnlyCollection<float>.System.Collections.IList.Clear
	|
	|-RVA: 0x3AB28D0 Offset: 0x3AB29D1 VA: 0x3AB28D0
	|-ReadOnlyCollection<SphericalHarmonicsL2>.System.Collections.IList.Clear
	|
	|-RVA: 0x3AB3A60 Offset: 0x3AB3B61 VA: 0x3AB3A60
	|-ReadOnlyCollection<SubMeshDescriptor>.System.Collections.IList.Clear
	|
	|-RVA: 0x3AB4A60 Offset: 0x3AB4B61 VA: 0x3AB4A60
	|-ReadOnlyCollection<TablePair>.System.Collections.IList.Clear
	|
	|-RVA: 0x3AB5A30 Offset: 0x3AB5B31 VA: 0x3AB5A30
	|-ReadOnlyCollection<TimeSpan>.System.Collections.IList.Clear
	|
	|-RVA: 0x3AB6A60 Offset: 0x3AB6B61 VA: 0x3AB6A60
	|-ReadOnlyCollection<UICharInfo>.System.Collections.IList.Clear
	|
	|-RVA: 0x3AB7A50 Offset: 0x3AB7B51 VA: 0x3AB7A50
	|-ReadOnlyCollection<UILineInfo>.System.Collections.IList.Clear
	|
	|-RVA: 0x3AB8DD0 Offset: 0x3AB8ED1 VA: 0x3AB8DD0
	|-ReadOnlyCollection<UIVertex>.System.Collections.IList.Clear
	|
	|-RVA: 0x3AB9E10 Offset: 0x3AB9F11 VA: 0x3AB9E10
	|-ReadOnlyCollection<ushort>.System.Collections.IList.Clear
	|
	|-RVA: 0x3ABADF0 Offset: 0x3ABAEF1 VA: 0x3ABADF0
	|-ReadOnlyCollection<uint>.System.Collections.IList.Clear
	|
	|-RVA: 0x3ABBDD0 Offset: 0x3ABBED1 VA: 0x3ABBDD0
	|-ReadOnlyCollection<ulong>.System.Collections.IList.Clear
	|
	|-RVA: 0x3ABCDD0 Offset: 0x3ABCED1 VA: 0x3ABCDD0
	|-ReadOnlyCollection<Vector2>.System.Collections.IList.Clear
	|
	|-RVA: 0x3ABDE00 Offset: 0x3ABDF01 VA: 0x3ABDE00
	|-ReadOnlyCollection<Vector3>.System.Collections.IList.Clear
	|
	|-RVA: 0x3ABEE20 Offset: 0x3ABEF21 VA: 0x3ABEE20
	|-ReadOnlyCollection<Vector4>.System.Collections.IList.Clear
	|
	|-RVA: 0x3ABFE10 Offset: 0x3ABFF11 VA: 0x3ABFE10
	|-ReadOnlyCollection<VertexAttributeDescriptor>.System.Collections.IList.Clear
	|
	|-RVA: 0x3AC0E00 Offset: 0x3AC0F01 VA: 0x3AC0E00
	|-ReadOnlyCollection<X509ChainStatus>.System.Collections.IList.Clear
	|
	|-RVA: 0x3AC1F00 Offset: 0x3AC2001 VA: 0x3AC1F00
	|-ReadOnlyCollection<XRView>.System.Collections.IList.Clear
	|
	|-RVA: 0x3AC2F40 Offset: 0x3AC3041 VA: 0x3AC2F40
	|-ReadOnlyCollection<AICrossfire.PositionTable>.System.Collections.IList.Clear
	|
	|-RVA: 0x3AC3F40 Offset: 0x3AC4041 VA: 0x3AC3F40
	|-ReadOnlyCollection<AmiiboSequence.GainItemData>.System.Collections.IList.Clear
	|
	|-RVA: 0x3AC5050 Offset: 0x3AC5151 VA: 0x3AC5050
	|-ReadOnlyCollection<AnimationOutputWeightProcessor.WeightInfo>.System.Collections.IList.Clear
	|
	|-RVA: 0x3AC6050 Offset: 0x3AC6151 VA: 0x3AC6050
	|-ReadOnlyCollection<ArenaOrderSequence.GodInfo>.System.Collections.IList.Clear
	|
	|-RVA: 0x3AC7040 Offset: 0x3AC7141 VA: 0x3AC7040
	|-ReadOnlyCollection<BattleInfo.SupportData>.System.Collections.IList.Clear
	|
	|-RVA: 0x3AC8030 Offset: 0x3AC8131 VA: 0x3AC8030
	|-ReadOnlyCollection<BeforeRenderHelper.OrderBlock>.System.Collections.IList.Clear
	|
	|-RVA: 0x3AC90F0 Offset: 0x3AC91F1 VA: 0x3AC90F0
	|-ReadOnlyCollection<Camera.RenderRequest>.System.Collections.IList.Clear
	|
	|-RVA: 0x3ACA0E0 Offset: 0x3ACA1E1 VA: 0x3ACA0E0
	|-ReadOnlyCollection<CameraState.CustomBlendable>.System.Collections.IList.Clear
	|
	|-RVA: 0x3ACB0B0 Offset: 0x3ACB1B1 VA: 0x3ACB0B0
	|-ReadOnlyCollection<CinemachineClearShot.Pair>.System.Collections.IList.Clear
	|
	|-RVA: 0x3ACC090 Offset: 0x3ACC191 VA: 0x3ACC090
	|-ReadOnlyCollection<CinemachineStateDrivenCamera.HashPair>.System.Collections.IList.Clear
	|
	|-RVA: 0x3ACD160 Offset: 0x3ACD261 VA: 0x3ACD160
	|-ReadOnlyCollection<DelayedActionManager.DelegateInfo>.System.Collections.IList.Clear
	|
	|-RVA: 0x3ACE280 Offset: 0x3ACE381 VA: 0x3ACE280
	|-ReadOnlyCollection<Detail.AsyncResultInt>.System.Collections.IList.Clear
	|
	|-RVA: 0x3ACF280 Offset: 0x3ACF381 VA: 0x3ACF280
	|-ReadOnlyCollection<Detail.CppArray>.System.Collections.IList.Clear
	|
	|-RVA: 0x3AD03A0 Offset: 0x3AD04A1 VA: 0x3AD03A0
	|-ReadOnlyCollection<Detail.NotificationEventInt>.System.Collections.IList.Clear
	|
	|-RVA: 0x3AD13A0 Offset: 0x3AD14A1 VA: 0x3AD13A0
	|-ReadOnlyCollection<DragonRideTargetGroup.ChainParam>.System.Collections.IList.Clear
	|
	|-RVA: 0x3AD2460 Offset: 0x3AD2561 VA: 0x3AD2460
	|-ReadOnlyCollection<GmapPathAdjuster.TargetModel>.System.Collections.IList.Clear
	|
	|-RVA: 0x3AD3520 Offset: 0x3AD3621 VA: 0x3AD3520
	|-ReadOnlyCollection<GmapSpotAdjuster.TargetModel>.System.Collections.IList.Clear
	|
	|-RVA: 0x3AD45E0 Offset: 0x3AD46E1 VA: 0x3AD45E0
	|-ReadOnlyCollection<HubFastTravel.Location>.System.Collections.IList.Clear
	|
	|-RVA: 0x3AD5700 Offset: 0x3AD5801 VA: 0x3AD5700
	|-ReadOnlyCollection<HubLensFlare.Flare>.System.Collections.IList.Clear
	|
	|-RVA: 0x3AD6700 Offset: 0x3AD6801 VA: 0x3AD6700
	|-ReadOnlyCollection<InventoryPoolItemMenuContent.KindBgNameClass>.System.Collections.IList.Clear
	|
	|-RVA: 0x3AD76D0 Offset: 0x3AD77D1 VA: 0x3AD76D0
	|-ReadOnlyCollection<Map.Pos>.System.Collections.IList.Clear
	|
	|-RVA: 0x3AD86D0 Offset: 0x3AD87D1 VA: 0x3AD86D0
	|-ReadOnlyCollection<MapImage.BackupTerrain>.System.Collections.IList.Clear
	|
	|-RVA: 0x3AD96E0 Offset: 0x3AD97E1 VA: 0x3AD96E0
	|-ReadOnlyCollection<MapImageRange.Pos>.System.Collections.IList.Clear
	|
	|-RVA: 0x3ADA7B0 Offset: 0x3ADA8B1 VA: 0x3ADA7B0
	|-ReadOnlyCollection<MapMind.Target>.System.Collections.IList.Clear
	|
	|-RVA: 0x38C5190 Offset: 0x38C5291 VA: 0x38C5190
	|-ReadOnlyCollection<MapPanelDebug.Entity>.System.Collections.IList.Clear
	|
	|-RVA: 0x38C6160 Offset: 0x38C6261 VA: 0x38C6160
	|-ReadOnlyCollection<NexRanking.Data>.System.Collections.IList.Clear
	|
	|-RVA: 0x38C7160 Offset: 0x38C7261 VA: 0x38C7160
	|-ReadOnlyCollection<NexVersus.RatingData>.System.Collections.IList.Clear
	|
	|-RVA: 0x38C8150 Offset: 0x38C8251 VA: 0x38C8150
	|-ReadOnlyCollection<PackedPlayModeBuildLogs.RuntimeBuildLog>.System.Collections.IList.Clear
	|
	|-RVA: 0x38C9250 Offset: 0x38C9351 VA: 0x38C9250
	|-ReadOnlyCollection<ParticleSystem.Particle>.System.Collections.IList.Clear
	|
	|-RVA: 0x38CA240 Offset: 0x38CA341 VA: 0x38CA240
	|-ReadOnlyCollection<RangeData.Offset>.System.Collections.IList.Clear
	|
	|-RVA: 0x38CB310 Offset: 0x38CB411 VA: 0x38CB310
	|-ReadOnlyCollection<RenderGraphDebugData.PassDebugData>.System.Collections.IList.Clear
	|
	|-RVA: 0x38CC420 Offset: 0x38CC521 VA: 0x38CC420
	|-ReadOnlyCollection<RenderGraphDebugData.ResourceDebugData>.System.Collections.IList.Clear
	|
	|-RVA: 0x38CD420 Offset: 0x38CD521 VA: 0x38CD420
	|-ReadOnlyCollection<RingCleaningUnitSelectMenu.GodParam>.System.Collections.IList.Clear
	|
	|-RVA: 0x38CE540 Offset: 0x38CE641 VA: 0x38CE540
	|-ReadOnlyCollection<ShadowUtility.Edge>.System.Collections.IList.Clear
	|
	|-RVA: 0x38CF560 Offset: 0x38CF661 VA: 0x38CF560
	|-ReadOnlyCollection<SkillArray.Entity>.System.Collections.IList.Clear
	|
	|-RVA: 0x38D06E0 Offset: 0x38D07E1 VA: 0x38D06E0
	|-ReadOnlyCollection<TexturePacker_JsonArray.Frame>.System.Collections.IList.Clear
	|
	|-RVA: 0x38D17C0 Offset: 0x38D18C1 VA: 0x38D17C0
	|-ReadOnlyCollection<TimeNotificationBehaviour.NotificationEntry>.System.Collections.IList.Clear
	|
	|-RVA: 0x38D2880 Offset: 0x38D2981 VA: 0x38D2880
	|-ReadOnlyCollection<UnitySynchronizationContext.WorkRequest>.System.Collections.IList.Clear
	|
	|-RVA: 0x38D3870 Offset: 0x38D3971 VA: 0x38D3870
	|-ReadOnlyCollection<XmlSchemaObjectTable.XmlSchemaObjectEntry>.System.Collections.IList.Clear
	|
	|-RVA: 0x38D4860 Offset: 0x38D4961 VA: 0x38D4860
	|-ReadOnlyCollection<AssetBundleBuildMap.AssetBundleEntry.AssetPathString>.System.Collections.IList.Clear
	|
	|-RVA: 0x38D5970 Offset: 0x38D5A71 VA: 0x38D5970
	|-ReadOnlyCollection<Detail.DataStore.DataStoreChangeMetaParamInt>.System.Collections.IList.Clear
	|
	|-RVA: 0x38D6990 Offset: 0x38D6A91 VA: 0x38D6990
	|-ReadOnlyCollection<Detail.DataStore.DataStoreDeleteParamInt>.System.Collections.IList.Clear
	|
	|-RVA: 0x38D7AA0 Offset: 0x38D7BA1 VA: 0x38D7AA0
	|-ReadOnlyCollection<Detail.DataStore.DataStoreGetMetaParamInt>.System.Collections.IList.Clear
	|
	|-RVA: 0x38D8BB0 Offset: 0x38D8CB1 VA: 0x38D8BB0
	|-ReadOnlyCollection<Detail.DataStore.DataStoreMetaInfoInt>.System.Collections.IList.Clear
	|
	|-RVA: 0x38D9C90 Offset: 0x38D9D91 VA: 0x38D9C90
	|-ReadOnlyCollection<Detail.DataStore.DataStorePasswordInfoInt>.System.Collections.IList.Clear
	|
	|-RVA: 0x38DAD50 Offset: 0x38DAE51 VA: 0x38DAD50
	|-ReadOnlyCollection<Detail.DataStore.DataStorePersistenceInfoInt>.System.Collections.IList.Clear
	|
	|-RVA: 0x38DBE50 Offset: 0x38DBF51 VA: 0x38DBE50
	|-ReadOnlyCollection<Detail.DataStore.DataStorePreparePostParamInt>.System.Collections.IList.Clear
	|
	|-RVA: 0x38DCE60 Offset: 0x38DCF61 VA: 0x38DCE60
	|-ReadOnlyCollection<Detail.DataStore.DataStoreRateObjectParamInt>.System.Collections.IList.Clear
	|
	|-RVA: 0x38DDF20 Offset: 0x38DE021 VA: 0x38DDF20
	|-ReadOnlyCollection<Detail.DataStore.DataStoreRatingInitParamInt>.System.Collections.IList.Clear
	|
	|-RVA: 0x38DEF10 Offset: 0x38DF011 VA: 0x38DEF10
	|-ReadOnlyCollection<Detail.DataStore.DataStoreRatingTargetInt>.System.Collections.IList.Clear
	|
	|-RVA: 0x38E0080 Offset: 0x38E0181 VA: 0x38E0080
	|-ReadOnlyCollection<Detail.Ranking.RankingCachedResultInt>.System.Collections.IList.Clear
	|
	|-RVA: 0x38E1090 Offset: 0x38E1191 VA: 0x38E1090
	|-ReadOnlyCollection<Detail.Ranking.RankingOrderParamInt>.System.Collections.IList.Clear
	|
	|-RVA: 0x38E2200 Offset: 0x38E2301 VA: 0x38E2200
	|-ReadOnlyCollection<Detail.Ranking.RankingRankDataInt>.System.Collections.IList.Clear
	|
	|-RVA: 0x38E34E0 Offset: 0x38E35E1 VA: 0x38E34E0
	|-ReadOnlyCollection<Detail.Ranking2.Ranking2ChartInfoInt>.System.Collections.IList.Clear
	|
	|-RVA: 0x38E46A0 Offset: 0x38E47A1 VA: 0x38E46A0
	|-ReadOnlyCollection<Detail.Ranking2.Ranking2RankDataInt>.System.Collections.IList.Clear
	|
	|-RVA: 0x38E56B0 Offset: 0x38E57B1 VA: 0x38E56B0
	|-ReadOnlyCollection<Detail.Ranking2.Ranking2ScoreDataInt>.System.Collections.IList.Clear
	|
	|-RVA: 0x38E6770 Offset: 0x38E6871 VA: 0x38E6770
	|-ReadOnlyCollection<Detail.Screening.ScreeningContextInfoInt>.System.Collections.IList.Clear
	|
	|-RVA: 0x38E7980 Offset: 0x38E7A81 VA: 0x38E7980
	|-ReadOnlyCollection<Detail.Subscriber.SubscriberContentInt>.System.Collections.IList.Clear
	|
	|-RVA: 0x38E8A80 Offset: 0x38E8B81 VA: 0x38E8A80
	|-ReadOnlyCollection<Detail.Subscriber.SubscriberGetContentParamInt>.System.Collections.IList.Clear
	|
	|-RVA: 0x38E9B90 Offset: 0x38E9C91 VA: 0x38E9B90
	|-ReadOnlyCollection<Detail.Subscriber.SubscriberUserStatusInfoInt>.System.Collections.IList.Clear
	|
	|-RVA: 0x38EAC60 Offset: 0x38EAD61 VA: 0x38EAC60
	|-ReadOnlyCollection<Detail.Subscriber.SubscriberUserStatusParamInt>.System.Collections.IList.Clear
	|
	|-RVA: 0x38EBC30 Offset: 0x38EBD31 VA: 0x38EBC30
	|-ReadOnlyCollection<Detail.Utility.IntegerSettings>.System.Collections.IList.Clear
	|
	|-RVA: 0x38ECC30 Offset: 0x38ECD31 VA: 0x38ECC30
	|-ReadOnlyCollection<Detail.Utility.UniqueIdInfoInt>.System.Collections.IList.Clear
	|
	|-RVA: 0x38EDC50 Offset: 0x38EDD51 VA: 0x38EDC50
	|-ReadOnlyCollection<MapHistory.Rewind.LatestInspectorData>.System.Collections.IList.Clear
	|
	|-RVA: 0x38EEC80 Offset: 0x38EED81 VA: 0x38EEC80
	|-ReadOnlyCollection<MapHistory.Rewind.WorkTerrainData>.System.Collections.IList.Clear
	|
	|-RVA: 0x38EFC80 Offset: 0x38EFD81 VA: 0x38EFC80
	|-ReadOnlyCollection<MapSkill.AroundCalculator.Result>.System.Collections.IList.Clear
	|
	|-RVA: 0x38F0DA0 Offset: 0x38F0EA1 VA: 0x38F0DA0
	|-ReadOnlyCollection<TargetPositionCache.CacheCurve.Item>.System.Collections.IList.Clear
	|
	|-RVA: 0x2FE6340 Offset: 0x2FE6441 VA: 0x2FE6340
	|-ReadOnlyCollection<TargetPositionCache.CacheEntry.RecordingItem>.System.Collections.IList.Clear
	*/

	// RVA: -1 Offset: -1
	private static bool IsCompatibleObject(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3468160 Offset: 0x3468261 VA: 0x3468160
	|-ReadOnlyCollection<IntervalTree.Entry<object>>.IsCompatibleObject
	|
	|-RVA: 0x3469150 Offset: 0x3469251 VA: 0x3469150
	|-ReadOnlyCollection<KeyValuePair<DateTime, object>>.IsCompatibleObject
	|
	|-RVA: 0x346A140 Offset: 0x346A241 VA: 0x346A140
	|-ReadOnlyCollection<KeyValuePair<int, object>>.IsCompatibleObject
	|
	|-RVA: 0x346B200 Offset: 0x346B301 VA: 0x346B200
	|-ReadOnlyCollection<KeyValuePair<object, ValueTuple<int, DateTime, object>>>.IsCompatibleObject
	|
	|-RVA: 0x346C1F0 Offset: 0x346C2F1 VA: 0x346C1F0
	|-ReadOnlyCollection<KeyValuePair<object, object>>.IsCompatibleObject
	|
	|-RVA: 0x346D2B0 Offset: 0x346D3B1 VA: 0x346D2B0
	|-ReadOnlyCollection<CommonBattleSequence.Reliance<object>>.IsCompatibleObject
	|
	|-RVA: 0x346E2A0 Offset: 0x346E3A1 VA: 0x346E2A0
	|-ReadOnlyCollection<RenderGraphResourcePool.ResourceLogInfo<object>>.IsCompatibleObject
	|
	|-RVA: 0x346F290 Offset: 0x346F391 VA: 0x346F290
	|-ReadOnlyCollection<ValueTuple<int, object>>.IsCompatibleObject
	|
	|-RVA: 0x3470260 Offset: 0x3470361 VA: 0x3470260
	|-ReadOnlyCollection<ValueTuple<Int32Enum, int>>.IsCompatibleObject
	|
	|-RVA: 0x3471330 Offset: 0x3471431 VA: 0x3471330
	|-ReadOnlyCollection<ValueTuple<object, ValueTuple<object, int>>>.IsCompatibleObject
	|
	|-RVA: 0x3472320 Offset: 0x3472421 VA: 0x3472320
	|-ReadOnlyCollection<ValueTuple<object, int>>.IsCompatibleObject
	|
	|-RVA: 0x3473340 Offset: 0x3473441 VA: 0x3473340
	|-ReadOnlyCollection<ValueTuple<Vector3, float>>.IsCompatibleObject
	|
	|-RVA: 0x3474330 Offset: 0x3474431 VA: 0x3474330
	|-ReadOnlyCollection<ValueTuple<object, Int32Enum, int>>.IsCompatibleObject
	|
	|-RVA: 0x34753F0 Offset: 0x34754F1 VA: 0x34753F0
	|-ReadOnlyCollection<ValueTuple<object, int, int, int>>.IsCompatibleObject
	|
	|-RVA: 0x34763C0 Offset: 0x34764C1 VA: 0x34763C0
	|-ReadOnlyCollection<AnimatorClipInfo>.IsCompatibleObject
	|
	|-RVA: 0x3B23230 Offset: 0x3B23331 VA: 0x3B23230
	|-ReadOnlyCollection<AsyncOperationHandle>.IsCompatibleObject
	|
	|-RVA: 0x3B242F0 Offset: 0x3B243F1 VA: 0x3B242F0
	|-ReadOnlyCollection<BoneWeight>.IsCompatibleObject
	|
	|-RVA: 0x3B252D0 Offset: 0x3B253D1 VA: 0x3B252D0
	|-ReadOnlyCollection<bool>.IsCompatibleObject
	|
	|-RVA: 0x3B262B0 Offset: 0x3B263B1 VA: 0x3B262B0
	|-ReadOnlyCollection<byte>.IsCompatibleObject
	|
	|-RVA: 0x3B272B0 Offset: 0x3B273B1 VA: 0x3B272B0
	|-ReadOnlyCollection<CameraInfo>.IsCompatibleObject
	|
	|-RVA: 0x3B28280 Offset: 0x3B28381 VA: 0x3B28280
	|-ReadOnlyCollection<char>.IsCompatibleObject
	|
	|-RVA: 0x3B292B0 Offset: 0x3B293B1 VA: 0x3B292B0
	|-ReadOnlyCollection<Color>.IsCompatibleObject
	|
	|-RVA: 0x3B2A2C0 Offset: 0x3B2A3C1 VA: 0x3B2A2C0
	|-ReadOnlyCollection<Color32>.IsCompatibleObject
	|
	|-RVA: 0x3B2B2C0 Offset: 0x3B2B3C1 VA: 0x3B2B2C0
	|-ReadOnlyCollection<ConstraintSource>.IsCompatibleObject
	|
	|-RVA: 0x3B2C380 Offset: 0x3B2C481 VA: 0x3B2C380
	|-ReadOnlyCollection<ContourVertex>.IsCompatibleObject
	|
	|-RVA: 0x3B2D440 Offset: 0x3B2D541 VA: 0x3B2D440
	|-ReadOnlyCollection<CustomAttributeNamedArgument>.IsCompatibleObject
	|
	|-RVA: 0x3B2E430 Offset: 0x3B2E531 VA: 0x3B2E430
	|-ReadOnlyCollection<CustomAttributeTypedArgument>.IsCompatibleObject
	|
	|-RVA: 0x3B2F4F0 Offset: 0x3B2F5F1 VA: 0x3B2F4F0
	|-ReadOnlyCollection<DataStoreRatingInfo>.IsCompatibleObject
	|
	|-RVA: 0x3B304C0 Offset: 0x3B305C1 VA: 0x3B304C0
	|-ReadOnlyCollection<DataStoreResult>.IsCompatibleObject
	|
	|-RVA: 0x3B314A0 Offset: 0x3B315A1 VA: 0x3B314A0
	|-ReadOnlyCollection<DateTime>.IsCompatibleObject
	|
	|-RVA: 0x3B324A0 Offset: 0x3B325A1 VA: 0x3B324A0
	|-ReadOnlyCollection<DateTimeOffset>.IsCompatibleObject
	|
	|-RVA: 0x3B33490 Offset: 0x3B33591 VA: 0x3B33490
	|-ReadOnlyCollection<Decimal>.IsCompatibleObject
	|
	|-RVA: 0x3B345B0 Offset: 0x3B346B1 VA: 0x3B345B0
	|-ReadOnlyCollection<DiagnosticEvent>.IsCompatibleObject
	|
	|-RVA: 0x3B35590 Offset: 0x3B35691 VA: 0x3B35590
	|-ReadOnlyCollection<double>.IsCompatibleObject
	|
	|-RVA: 0x3B366D0 Offset: 0x3B367D1 VA: 0x3B366D0
	|-ReadOnlyCollection<Friend>.IsCompatibleObject
	|
	|-RVA: 0x3B376C0 Offset: 0x3B377C1 VA: 0x3B376C0
	|-ReadOnlyCollection<GlyphRect>.IsCompatibleObject
	|
	|-RVA: 0x3B38690 Offset: 0x3B38791 VA: 0x3B38690
	|-ReadOnlyCollection<short>.IsCompatibleObject
	|
	|-RVA: 0x3B39670 Offset: 0x3B39771 VA: 0x3B39670
	|-ReadOnlyCollection<int>.IsCompatibleObject
	|
	|-RVA: 0x3B3A650 Offset: 0x3B3A751 VA: 0x3B3A650
	|-ReadOnlyCollection<Int32Enum>.IsCompatibleObject
	|
	|-RVA: 0x3B3B630 Offset: 0x3B3B731 VA: 0x3B3B630
	|-ReadOnlyCollection<long>.IsCompatibleObject
	|
	|-RVA: 0x3B3C610 Offset: 0x3B3C711 VA: 0x3B3C610
	|-ReadOnlyCollection<IntPtr>.IsCompatibleObject
	|
	|-RVA: 0x3B3D610 Offset: 0x3B3D711 VA: 0x3B3D610
	|-ReadOnlyCollection<InterpretedFrameInfo>.IsCompatibleObject
	|
	|-RVA: 0x3B3E6D0 Offset: 0x3B3E7D1 VA: 0x3B3E6D0
	|-ReadOnlyCollection<IntervalTreeNode>.IsCompatibleObject
	|
	|-RVA: 0x3B3F6A0 Offset: 0x3B3F7A1 VA: 0x3B3F6A0
	|-ReadOnlyCollection<LengthLimitProperties>.IsCompatibleObject
	|
	|-RVA: 0x3B40680 Offset: 0x3B40781 VA: 0x3B40680
	|-ReadOnlyCollection<MapPos>.IsCompatibleObject
	|
	|-RVA: 0x3B41800 Offset: 0x3B41901 VA: 0x3B41800
	|-ReadOnlyCollection<Matrix4x4>.IsCompatibleObject
	|
	|-RVA: 0x3B42790 Offset: 0x3B42891 VA: 0x3B42790
	|-ReadOnlyCollection<object>.IsCompatibleObject
	|
	|-RVA: 0x3B43830 Offset: 0x3B43931 VA: 0x3B43830
	|-ReadOnlyCollection<ObjectInitializationData>.IsCompatibleObject
	|
	|-RVA: 0x3B44900 Offset: 0x3B44A01 VA: 0x3B44900
	|-ReadOnlyCollection<PlayableBinding>.IsCompatibleObject
	|
	|-RVA: 0x3B45A10 Offset: 0x3B45B11 VA: 0x3B45A10
	|-ReadOnlyCollection<PlayerLoopSystem>.IsCompatibleObject
	|
	|-RVA: 0x3B46B30 Offset: 0x3B46C31 VA: 0x3B46B30
	|-ReadOnlyCollection<PlayerLoopSystemInternal>.IsCompatibleObject
	|
	|-RVA: 0x3B47B30 Offset: 0x3B47C31 VA: 0x3B47B30
	|-ReadOnlyCollection<RangePositionInfo>.IsCompatibleObject
	|
	|-RVA: 0x3B48B00 Offset: 0x3B48C01 VA: 0x3B48B00
	|-ReadOnlyCollection<Ranking2ChartInfoInput>.IsCompatibleObject
	|
	|-RVA: 0x3B49C50 Offset: 0x3B49D51 VA: 0x3B49C50
	|-ReadOnlyCollection<RaycastHit2D>.IsCompatibleObject
	|
	|-RVA: 0x3B4AE80 Offset: 0x3B4AF81 VA: 0x3B4AE80
	|-ReadOnlyCollection<RaycastResult>.IsCompatibleObject
	|
	|-RVA: 0x3B4BEE0 Offset: 0x3B4BFE1 VA: 0x3B4BEE0
	|-ReadOnlyCollection<Rect>.IsCompatibleObject
	|
	|-RVA: 0x3B4CEB0 Offset: 0x3B4CFB1 VA: 0x3B4CEB0
	|-ReadOnlyCollection<RendererListHandle>.IsCompatibleObject
	|
	|-RVA: 0x3B4DE90 Offset: 0x3B4DF91 VA: 0x3B4DE90
	|-ReadOnlyCollection<ResourceHandle>.IsCompatibleObject
	|
	|-RVA: 0x3AAF550 Offset: 0x3AAF651 VA: 0x3AAF550
	|-ReadOnlyCollection<sbyte>.IsCompatibleObject
	|
	|-RVA: 0x3AB0570 Offset: 0x3AB0671 VA: 0x3AB0570
	|-ReadOnlyCollection<ShaderTagId>.IsCompatibleObject
	|
	|-RVA: 0x3AB1550 Offset: 0x3AB1651 VA: 0x3AB1550
	|-ReadOnlyCollection<float>.IsCompatibleObject
	|
	|-RVA: 0x3AB28E0 Offset: 0x3AB29E1 VA: 0x3AB28E0
	|-ReadOnlyCollection<SphericalHarmonicsL2>.IsCompatibleObject
	|
	|-RVA: 0x3AB3A70 Offset: 0x3AB3B71 VA: 0x3AB3A70
	|-ReadOnlyCollection<SubMeshDescriptor>.IsCompatibleObject
	|
	|-RVA: 0x3AB4A70 Offset: 0x3AB4B71 VA: 0x3AB4A70
	|-ReadOnlyCollection<TablePair>.IsCompatibleObject
	|
	|-RVA: 0x3AB5A40 Offset: 0x3AB5B41 VA: 0x3AB5A40
	|-ReadOnlyCollection<TimeSpan>.IsCompatibleObject
	|
	|-RVA: 0x3AB6A70 Offset: 0x3AB6B71 VA: 0x3AB6A70
	|-ReadOnlyCollection<UICharInfo>.IsCompatibleObject
	|
	|-RVA: 0x3AB7A60 Offset: 0x3AB7B61 VA: 0x3AB7A60
	|-ReadOnlyCollection<UILineInfo>.IsCompatibleObject
	|
	|-RVA: 0x3AB8DE0 Offset: 0x3AB8EE1 VA: 0x3AB8DE0
	|-ReadOnlyCollection<UIVertex>.IsCompatibleObject
	|
	|-RVA: 0x3AB9E20 Offset: 0x3AB9F21 VA: 0x3AB9E20
	|-ReadOnlyCollection<ushort>.IsCompatibleObject
	|
	|-RVA: 0x3ABAE00 Offset: 0x3ABAF01 VA: 0x3ABAE00
	|-ReadOnlyCollection<uint>.IsCompatibleObject
	|
	|-RVA: 0x3ABBDE0 Offset: 0x3ABBEE1 VA: 0x3ABBDE0
	|-ReadOnlyCollection<ulong>.IsCompatibleObject
	|
	|-RVA: 0x3ABCDE0 Offset: 0x3ABCEE1 VA: 0x3ABCDE0
	|-ReadOnlyCollection<Vector2>.IsCompatibleObject
	|
	|-RVA: 0x3ABDE10 Offset: 0x3ABDF11 VA: 0x3ABDE10
	|-ReadOnlyCollection<Vector3>.IsCompatibleObject
	|
	|-RVA: 0x3ABEE30 Offset: 0x3ABEF31 VA: 0x3ABEE30
	|-ReadOnlyCollection<Vector4>.IsCompatibleObject
	|
	|-RVA: 0x3ABFE20 Offset: 0x3ABFF21 VA: 0x3ABFE20
	|-ReadOnlyCollection<VertexAttributeDescriptor>.IsCompatibleObject
	|
	|-RVA: 0x3AC0E10 Offset: 0x3AC0F11 VA: 0x3AC0E10
	|-ReadOnlyCollection<X509ChainStatus>.IsCompatibleObject
	|
	|-RVA: 0x3AC1F10 Offset: 0x3AC2011 VA: 0x3AC1F10
	|-ReadOnlyCollection<XRView>.IsCompatibleObject
	|
	|-RVA: 0x3AC2F50 Offset: 0x3AC3051 VA: 0x3AC2F50
	|-ReadOnlyCollection<AICrossfire.PositionTable>.IsCompatibleObject
	|
	|-RVA: 0x3AC3F50 Offset: 0x3AC4051 VA: 0x3AC3F50
	|-ReadOnlyCollection<AmiiboSequence.GainItemData>.IsCompatibleObject
	|
	|-RVA: 0x3AC5060 Offset: 0x3AC5161 VA: 0x3AC5060
	|-ReadOnlyCollection<AnimationOutputWeightProcessor.WeightInfo>.IsCompatibleObject
	|
	|-RVA: 0x3AC6060 Offset: 0x3AC6161 VA: 0x3AC6060
	|-ReadOnlyCollection<ArenaOrderSequence.GodInfo>.IsCompatibleObject
	|
	|-RVA: 0x3AC7050 Offset: 0x3AC7151 VA: 0x3AC7050
	|-ReadOnlyCollection<BattleInfo.SupportData>.IsCompatibleObject
	|
	|-RVA: 0x3AC8040 Offset: 0x3AC8141 VA: 0x3AC8040
	|-ReadOnlyCollection<BeforeRenderHelper.OrderBlock>.IsCompatibleObject
	|
	|-RVA: 0x3AC9100 Offset: 0x3AC9201 VA: 0x3AC9100
	|-ReadOnlyCollection<Camera.RenderRequest>.IsCompatibleObject
	|
	|-RVA: 0x3ACA0F0 Offset: 0x3ACA1F1 VA: 0x3ACA0F0
	|-ReadOnlyCollection<CameraState.CustomBlendable>.IsCompatibleObject
	|
	|-RVA: 0x3ACB0C0 Offset: 0x3ACB1C1 VA: 0x3ACB0C0
	|-ReadOnlyCollection<CinemachineClearShot.Pair>.IsCompatibleObject
	|
	|-RVA: 0x3ACC0A0 Offset: 0x3ACC1A1 VA: 0x3ACC0A0
	|-ReadOnlyCollection<CinemachineStateDrivenCamera.HashPair>.IsCompatibleObject
	|
	|-RVA: 0x3ACD170 Offset: 0x3ACD271 VA: 0x3ACD170
	|-ReadOnlyCollection<DelayedActionManager.DelegateInfo>.IsCompatibleObject
	|
	|-RVA: 0x3ACE290 Offset: 0x3ACE391 VA: 0x3ACE290
	|-ReadOnlyCollection<Detail.AsyncResultInt>.IsCompatibleObject
	|
	|-RVA: 0x3ACF290 Offset: 0x3ACF391 VA: 0x3ACF290
	|-ReadOnlyCollection<Detail.CppArray>.IsCompatibleObject
	|
	|-RVA: 0x3AD03B0 Offset: 0x3AD04B1 VA: 0x3AD03B0
	|-ReadOnlyCollection<Detail.NotificationEventInt>.IsCompatibleObject
	|
	|-RVA: 0x3AD13B0 Offset: 0x3AD14B1 VA: 0x3AD13B0
	|-ReadOnlyCollection<DragonRideTargetGroup.ChainParam>.IsCompatibleObject
	|
	|-RVA: 0x3AD2470 Offset: 0x3AD2571 VA: 0x3AD2470
	|-ReadOnlyCollection<GmapPathAdjuster.TargetModel>.IsCompatibleObject
	|
	|-RVA: 0x3AD3530 Offset: 0x3AD3631 VA: 0x3AD3530
	|-ReadOnlyCollection<GmapSpotAdjuster.TargetModel>.IsCompatibleObject
	|
	|-RVA: 0x3AD45F0 Offset: 0x3AD46F1 VA: 0x3AD45F0
	|-ReadOnlyCollection<HubFastTravel.Location>.IsCompatibleObject
	|
	|-RVA: 0x3AD5710 Offset: 0x3AD5811 VA: 0x3AD5710
	|-ReadOnlyCollection<HubLensFlare.Flare>.IsCompatibleObject
	|
	|-RVA: 0x3AD6710 Offset: 0x3AD6811 VA: 0x3AD6710
	|-ReadOnlyCollection<InventoryPoolItemMenuContent.KindBgNameClass>.IsCompatibleObject
	|
	|-RVA: 0x3AD76E0 Offset: 0x3AD77E1 VA: 0x3AD76E0
	|-ReadOnlyCollection<Map.Pos>.IsCompatibleObject
	|
	|-RVA: 0x3AD86E0 Offset: 0x3AD87E1 VA: 0x3AD86E0
	|-ReadOnlyCollection<MapImage.BackupTerrain>.IsCompatibleObject
	|
	|-RVA: 0x3AD96F0 Offset: 0x3AD97F1 VA: 0x3AD96F0
	|-ReadOnlyCollection<MapImageRange.Pos>.IsCompatibleObject
	|
	|-RVA: 0x3ADA7C0 Offset: 0x3ADA8C1 VA: 0x3ADA7C0
	|-ReadOnlyCollection<MapMind.Target>.IsCompatibleObject
	|
	|-RVA: 0x38C51A0 Offset: 0x38C52A1 VA: 0x38C51A0
	|-ReadOnlyCollection<MapPanelDebug.Entity>.IsCompatibleObject
	|
	|-RVA: 0x38C6170 Offset: 0x38C6271 VA: 0x38C6170
	|-ReadOnlyCollection<NexRanking.Data>.IsCompatibleObject
	|
	|-RVA: 0x38C7170 Offset: 0x38C7271 VA: 0x38C7170
	|-ReadOnlyCollection<NexVersus.RatingData>.IsCompatibleObject
	|
	|-RVA: 0x38C8160 Offset: 0x38C8261 VA: 0x38C8160
	|-ReadOnlyCollection<PackedPlayModeBuildLogs.RuntimeBuildLog>.IsCompatibleObject
	|
	|-RVA: 0x38C9260 Offset: 0x38C9361 VA: 0x38C9260
	|-ReadOnlyCollection<ParticleSystem.Particle>.IsCompatibleObject
	|
	|-RVA: 0x38CA250 Offset: 0x38CA351 VA: 0x38CA250
	|-ReadOnlyCollection<RangeData.Offset>.IsCompatibleObject
	|
	|-RVA: 0x38CB320 Offset: 0x38CB421 VA: 0x38CB320
	|-ReadOnlyCollection<RenderGraphDebugData.PassDebugData>.IsCompatibleObject
	|
	|-RVA: 0x38CC430 Offset: 0x38CC531 VA: 0x38CC430
	|-ReadOnlyCollection<RenderGraphDebugData.ResourceDebugData>.IsCompatibleObject
	|
	|-RVA: 0x38CD430 Offset: 0x38CD531 VA: 0x38CD430
	|-ReadOnlyCollection<RingCleaningUnitSelectMenu.GodParam>.IsCompatibleObject
	|
	|-RVA: 0x38CE550 Offset: 0x38CE651 VA: 0x38CE550
	|-ReadOnlyCollection<ShadowUtility.Edge>.IsCompatibleObject
	|
	|-RVA: 0x38CF570 Offset: 0x38CF671 VA: 0x38CF570
	|-ReadOnlyCollection<SkillArray.Entity>.IsCompatibleObject
	|
	|-RVA: 0x38D06F0 Offset: 0x38D07F1 VA: 0x38D06F0
	|-ReadOnlyCollection<TexturePacker_JsonArray.Frame>.IsCompatibleObject
	|
	|-RVA: 0x38D17D0 Offset: 0x38D18D1 VA: 0x38D17D0
	|-ReadOnlyCollection<TimeNotificationBehaviour.NotificationEntry>.IsCompatibleObject
	|
	|-RVA: 0x38D2890 Offset: 0x38D2991 VA: 0x38D2890
	|-ReadOnlyCollection<UnitySynchronizationContext.WorkRequest>.IsCompatibleObject
	|
	|-RVA: 0x38D3880 Offset: 0x38D3981 VA: 0x38D3880
	|-ReadOnlyCollection<XmlSchemaObjectTable.XmlSchemaObjectEntry>.IsCompatibleObject
	|
	|-RVA: 0x38D4870 Offset: 0x38D4971 VA: 0x38D4870
	|-ReadOnlyCollection<AssetBundleBuildMap.AssetBundleEntry.AssetPathString>.IsCompatibleObject
	|
	|-RVA: 0x38D5980 Offset: 0x38D5A81 VA: 0x38D5980
	|-ReadOnlyCollection<Detail.DataStore.DataStoreChangeMetaParamInt>.IsCompatibleObject
	|
	|-RVA: 0x38D69A0 Offset: 0x38D6AA1 VA: 0x38D69A0
	|-ReadOnlyCollection<Detail.DataStore.DataStoreDeleteParamInt>.IsCompatibleObject
	|
	|-RVA: 0x38D7AB0 Offset: 0x38D7BB1 VA: 0x38D7AB0
	|-ReadOnlyCollection<Detail.DataStore.DataStoreGetMetaParamInt>.IsCompatibleObject
	|
	|-RVA: 0x38D8BC0 Offset: 0x38D8CC1 VA: 0x38D8BC0
	|-ReadOnlyCollection<Detail.DataStore.DataStoreMetaInfoInt>.IsCompatibleObject
	|
	|-RVA: 0x38D9CA0 Offset: 0x38D9DA1 VA: 0x38D9CA0
	|-ReadOnlyCollection<Detail.DataStore.DataStorePasswordInfoInt>.IsCompatibleObject
	|
	|-RVA: 0x38DAD60 Offset: 0x38DAE61 VA: 0x38DAD60
	|-ReadOnlyCollection<Detail.DataStore.DataStorePersistenceInfoInt>.IsCompatibleObject
	|
	|-RVA: 0x38DBE60 Offset: 0x38DBF61 VA: 0x38DBE60
	|-ReadOnlyCollection<Detail.DataStore.DataStorePreparePostParamInt>.IsCompatibleObject
	|
	|-RVA: 0x38DCE70 Offset: 0x38DCF71 VA: 0x38DCE70
	|-ReadOnlyCollection<Detail.DataStore.DataStoreRateObjectParamInt>.IsCompatibleObject
	|
	|-RVA: 0x38DDF30 Offset: 0x38DE031 VA: 0x38DDF30
	|-ReadOnlyCollection<Detail.DataStore.DataStoreRatingInitParamInt>.IsCompatibleObject
	|
	|-RVA: 0x38DEF20 Offset: 0x38DF021 VA: 0x38DEF20
	|-ReadOnlyCollection<Detail.DataStore.DataStoreRatingTargetInt>.IsCompatibleObject
	|
	|-RVA: 0x38E0090 Offset: 0x38E0191 VA: 0x38E0090
	|-ReadOnlyCollection<Detail.Ranking.RankingCachedResultInt>.IsCompatibleObject
	|
	|-RVA: 0x38E10A0 Offset: 0x38E11A1 VA: 0x38E10A0
	|-ReadOnlyCollection<Detail.Ranking.RankingOrderParamInt>.IsCompatibleObject
	|
	|-RVA: 0x38E2210 Offset: 0x38E2311 VA: 0x38E2210
	|-ReadOnlyCollection<Detail.Ranking.RankingRankDataInt>.IsCompatibleObject
	|
	|-RVA: 0x38E34F0 Offset: 0x38E35F1 VA: 0x38E34F0
	|-ReadOnlyCollection<Detail.Ranking2.Ranking2ChartInfoInt>.IsCompatibleObject
	|
	|-RVA: 0x38E46B0 Offset: 0x38E47B1 VA: 0x38E46B0
	|-ReadOnlyCollection<Detail.Ranking2.Ranking2RankDataInt>.IsCompatibleObject
	|
	|-RVA: 0x38E56C0 Offset: 0x38E57C1 VA: 0x38E56C0
	|-ReadOnlyCollection<Detail.Ranking2.Ranking2ScoreDataInt>.IsCompatibleObject
	|
	|-RVA: 0x38E6780 Offset: 0x38E6881 VA: 0x38E6780
	|-ReadOnlyCollection<Detail.Screening.ScreeningContextInfoInt>.IsCompatibleObject
	|
	|-RVA: 0x38E7990 Offset: 0x38E7A91 VA: 0x38E7990
	|-ReadOnlyCollection<Detail.Subscriber.SubscriberContentInt>.IsCompatibleObject
	|
	|-RVA: 0x38E8A90 Offset: 0x38E8B91 VA: 0x38E8A90
	|-ReadOnlyCollection<Detail.Subscriber.SubscriberGetContentParamInt>.IsCompatibleObject
	|
	|-RVA: 0x38E9BA0 Offset: 0x38E9CA1 VA: 0x38E9BA0
	|-ReadOnlyCollection<Detail.Subscriber.SubscriberUserStatusInfoInt>.IsCompatibleObject
	|
	|-RVA: 0x38EAC70 Offset: 0x38EAD71 VA: 0x38EAC70
	|-ReadOnlyCollection<Detail.Subscriber.SubscriberUserStatusParamInt>.IsCompatibleObject
	|
	|-RVA: 0x38EBC40 Offset: 0x38EBD41 VA: 0x38EBC40
	|-ReadOnlyCollection<Detail.Utility.IntegerSettings>.IsCompatibleObject
	|
	|-RVA: 0x38ECC40 Offset: 0x38ECD41 VA: 0x38ECC40
	|-ReadOnlyCollection<Detail.Utility.UniqueIdInfoInt>.IsCompatibleObject
	|
	|-RVA: 0x38EDC60 Offset: 0x38EDD61 VA: 0x38EDC60
	|-ReadOnlyCollection<MapHistory.Rewind.LatestInspectorData>.IsCompatibleObject
	|
	|-RVA: 0x38EEC90 Offset: 0x38EED91 VA: 0x38EEC90
	|-ReadOnlyCollection<MapHistory.Rewind.WorkTerrainData>.IsCompatibleObject
	|
	|-RVA: 0x38EFC90 Offset: 0x38EFD91 VA: 0x38EFC90
	|-ReadOnlyCollection<MapSkill.AroundCalculator.Result>.IsCompatibleObject
	|
	|-RVA: 0x38F0DB0 Offset: 0x38F0EB1 VA: 0x38F0DB0
	|-ReadOnlyCollection<TargetPositionCache.CacheCurve.Item>.IsCompatibleObject
	|
	|-RVA: 0x2FE6350 Offset: 0x2FE6451 VA: 0x2FE6350
	|-ReadOnlyCollection<TargetPositionCache.CacheEntry.RecordingItem>.IsCompatibleObject
	*/

	// RVA: -1 Offset: -1 Slot: 21
	private bool System.Collections.IList.Contains(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3468250 Offset: 0x3468351 VA: 0x3468250
	|-ReadOnlyCollection<IntervalTree.Entry<object>>.System.Collections.IList.Contains
	|
	|-RVA: 0x3469240 Offset: 0x3469341 VA: 0x3469240
	|-ReadOnlyCollection<KeyValuePair<DateTime, object>>.System.Collections.IList.Contains
	|
	|-RVA: 0x346A230 Offset: 0x346A331 VA: 0x346A230
	|-ReadOnlyCollection<KeyValuePair<int, object>>.System.Collections.IList.Contains
	|
	|-RVA: 0x346B2F0 Offset: 0x346B3F1 VA: 0x346B2F0
	|-ReadOnlyCollection<KeyValuePair<object, ValueTuple<int, DateTime, object>>>.System.Collections.IList.Contains
	|
	|-RVA: 0x346C2E0 Offset: 0x346C3E1 VA: 0x346C2E0
	|-ReadOnlyCollection<KeyValuePair<object, object>>.System.Collections.IList.Contains
	|
	|-RVA: 0x346D3A0 Offset: 0x346D4A1 VA: 0x346D3A0
	|-ReadOnlyCollection<CommonBattleSequence.Reliance<object>>.System.Collections.IList.Contains
	|
	|-RVA: 0x346E390 Offset: 0x346E491 VA: 0x346E390
	|-ReadOnlyCollection<RenderGraphResourcePool.ResourceLogInfo<object>>.System.Collections.IList.Contains
	|
	|-RVA: 0x346F380 Offset: 0x346F481 VA: 0x346F380
	|-ReadOnlyCollection<ValueTuple<int, object>>.System.Collections.IList.Contains
	|
	|-RVA: 0x3470360 Offset: 0x3470461 VA: 0x3470360
	|-ReadOnlyCollection<ValueTuple<Int32Enum, int>>.System.Collections.IList.Contains
	|
	|-RVA: 0x3471420 Offset: 0x3471521 VA: 0x3471420
	|-ReadOnlyCollection<ValueTuple<object, ValueTuple<object, int>>>.System.Collections.IList.Contains
	|
	|-RVA: 0x3472410 Offset: 0x3472511 VA: 0x3472410
	|-ReadOnlyCollection<ValueTuple<object, int>>.System.Collections.IList.Contains
	|
	|-RVA: 0x3473430 Offset: 0x3473531 VA: 0x3473430
	|-ReadOnlyCollection<ValueTuple<Vector3, float>>.System.Collections.IList.Contains
	|
	|-RVA: 0x3474420 Offset: 0x3474521 VA: 0x3474420
	|-ReadOnlyCollection<ValueTuple<object, Int32Enum, int>>.System.Collections.IList.Contains
	|
	|-RVA: 0x34754E0 Offset: 0x34755E1 VA: 0x34754E0
	|-ReadOnlyCollection<ValueTuple<object, int, int, int>>.System.Collections.IList.Contains
	|
	|-RVA: 0x34764C0 Offset: 0x34765C1 VA: 0x34764C0
	|-ReadOnlyCollection<AnimatorClipInfo>.System.Collections.IList.Contains
	|
	|-RVA: 0x3B23320 Offset: 0x3B23421 VA: 0x3B23320
	|-ReadOnlyCollection<AsyncOperationHandle>.System.Collections.IList.Contains
	|
	|-RVA: 0x3B243E0 Offset: 0x3B244E1 VA: 0x3B243E0
	|-ReadOnlyCollection<BoneWeight>.System.Collections.IList.Contains
	|
	|-RVA: 0x3B253D0 Offset: 0x3B254D1 VA: 0x3B253D0
	|-ReadOnlyCollection<bool>.System.Collections.IList.Contains
	|
	|-RVA: 0x3B263B0 Offset: 0x3B264B1 VA: 0x3B263B0
	|-ReadOnlyCollection<byte>.System.Collections.IList.Contains
	|
	|-RVA: 0x3B273A0 Offset: 0x3B274A1 VA: 0x3B273A0
	|-ReadOnlyCollection<CameraInfo>.System.Collections.IList.Contains
	|
	|-RVA: 0x3B28380 Offset: 0x3B28481 VA: 0x3B28380
	|-ReadOnlyCollection<char>.System.Collections.IList.Contains
	|
	|-RVA: 0x3B293A0 Offset: 0x3B294A1 VA: 0x3B293A0
	|-ReadOnlyCollection<Color>.System.Collections.IList.Contains
	|
	|-RVA: 0x3B2A3C0 Offset: 0x3B2A4C1 VA: 0x3B2A3C0
	|-ReadOnlyCollection<Color32>.System.Collections.IList.Contains
	|
	|-RVA: 0x3B2B3B0 Offset: 0x3B2B4B1 VA: 0x3B2B3B0
	|-ReadOnlyCollection<ConstraintSource>.System.Collections.IList.Contains
	|
	|-RVA: 0x3B2C470 Offset: 0x3B2C571 VA: 0x3B2C470
	|-ReadOnlyCollection<ContourVertex>.System.Collections.IList.Contains
	|
	|-RVA: 0x3B2D530 Offset: 0x3B2D631 VA: 0x3B2D530
	|-ReadOnlyCollection<CustomAttributeNamedArgument>.System.Collections.IList.Contains
	|
	|-RVA: 0x3B2E520 Offset: 0x3B2E621 VA: 0x3B2E520
	|-ReadOnlyCollection<CustomAttributeTypedArgument>.System.Collections.IList.Contains
	|
	|-RVA: 0x3B2F5E0 Offset: 0x3B2F6E1 VA: 0x3B2F5E0
	|-ReadOnlyCollection<DataStoreRatingInfo>.System.Collections.IList.Contains
	|
	|-RVA: 0x3B305C0 Offset: 0x3B306C1 VA: 0x3B305C0
	|-ReadOnlyCollection<DataStoreResult>.System.Collections.IList.Contains
	|
	|-RVA: 0x3B315A0 Offset: 0x3B316A1 VA: 0x3B315A0
	|-ReadOnlyCollection<DateTime>.System.Collections.IList.Contains
	|
	|-RVA: 0x3B32590 Offset: 0x3B32691 VA: 0x3B32590
	|-ReadOnlyCollection<DateTimeOffset>.System.Collections.IList.Contains
	|
	|-RVA: 0x3B33580 Offset: 0x3B33681 VA: 0x3B33580
	|-ReadOnlyCollection<Decimal>.System.Collections.IList.Contains
	|
	|-RVA: 0x3B346A0 Offset: 0x3B347A1 VA: 0x3B346A0
	|-ReadOnlyCollection<DiagnosticEvent>.System.Collections.IList.Contains
	|
	|-RVA: 0x3B35690 Offset: 0x3B35791 VA: 0x3B35690
	|-ReadOnlyCollection<double>.System.Collections.IList.Contains
	|
	|-RVA: 0x3B367C0 Offset: 0x3B368C1 VA: 0x3B367C0
	|-ReadOnlyCollection<Friend>.System.Collections.IList.Contains
	|
	|-RVA: 0x3B377B0 Offset: 0x3B378B1 VA: 0x3B377B0
	|-ReadOnlyCollection<GlyphRect>.System.Collections.IList.Contains
	|
	|-RVA: 0x3B38790 Offset: 0x3B38891 VA: 0x3B38790
	|-ReadOnlyCollection<short>.System.Collections.IList.Contains
	|
	|-RVA: 0x3B39770 Offset: 0x3B39871 VA: 0x3B39770
	|-ReadOnlyCollection<int>.System.Collections.IList.Contains
	|
	|-RVA: 0x3B3A750 Offset: 0x3B3A851 VA: 0x3B3A750
	|-ReadOnlyCollection<Int32Enum>.System.Collections.IList.Contains
	|
	|-RVA: 0x3B3B730 Offset: 0x3B3B831 VA: 0x3B3B730
	|-ReadOnlyCollection<long>.System.Collections.IList.Contains
	|
	|-RVA: 0x3B3C710 Offset: 0x3B3C811 VA: 0x3B3C710
	|-ReadOnlyCollection<IntPtr>.System.Collections.IList.Contains
	|
	|-RVA: 0x3B3D700 Offset: 0x3B3D801 VA: 0x3B3D700
	|-ReadOnlyCollection<InterpretedFrameInfo>.System.Collections.IList.Contains
	|
	|-RVA: 0x3B3E7C0 Offset: 0x3B3E8C1 VA: 0x3B3E7C0
	|-ReadOnlyCollection<IntervalTreeNode>.System.Collections.IList.Contains
	|
	|-RVA: 0x3B3F7A0 Offset: 0x3B3F8A1 VA: 0x3B3F7A0
	|-ReadOnlyCollection<LengthLimitProperties>.System.Collections.IList.Contains
	|
	|-RVA: 0x3B40780 Offset: 0x3B40881 VA: 0x3B40780
	|-ReadOnlyCollection<MapPos>.System.Collections.IList.Contains
	|
	|-RVA: 0x3B418F0 Offset: 0x3B419F1 VA: 0x3B418F0
	|-ReadOnlyCollection<Matrix4x4>.System.Collections.IList.Contains
	|
	|-RVA: 0x3B42820 Offset: 0x3B42921 VA: 0x3B42820
	|-ReadOnlyCollection<object>.System.Collections.IList.Contains
	|
	|-RVA: 0x3B43920 Offset: 0x3B43A21 VA: 0x3B43920
	|-ReadOnlyCollection<ObjectInitializationData>.System.Collections.IList.Contains
	|
	|-RVA: 0x3B449F0 Offset: 0x3B44AF1 VA: 0x3B449F0
	|-ReadOnlyCollection<PlayableBinding>.System.Collections.IList.Contains
	|
	|-RVA: 0x3B45B00 Offset: 0x3B45C01 VA: 0x3B45B00
	|-ReadOnlyCollection<PlayerLoopSystem>.System.Collections.IList.Contains
	|
	|-RVA: 0x3B46C20 Offset: 0x3B46D21 VA: 0x3B46C20
	|-ReadOnlyCollection<PlayerLoopSystemInternal>.System.Collections.IList.Contains
	|
	|-RVA: 0x3B47C20 Offset: 0x3B47D21 VA: 0x3B47C20
	|-ReadOnlyCollection<RangePositionInfo>.System.Collections.IList.Contains
	|
	|-RVA: 0x3B48C00 Offset: 0x3B48D01 VA: 0x3B48C00
	|-ReadOnlyCollection<Ranking2ChartInfoInput>.System.Collections.IList.Contains
	|
	|-RVA: 0x3B49D40 Offset: 0x3B49E41 VA: 0x3B49D40
	|-ReadOnlyCollection<RaycastHit2D>.System.Collections.IList.Contains
	|
	|-RVA: 0x3B4AF80 Offset: 0x3B4B081 VA: 0x3B4AF80
	|-ReadOnlyCollection<RaycastResult>.System.Collections.IList.Contains
	|
	|-RVA: 0x3B4BFD0 Offset: 0x3B4C0D1 VA: 0x3B4BFD0
	|-ReadOnlyCollection<Rect>.System.Collections.IList.Contains
	|
	|-RVA: 0x3B4CFB0 Offset: 0x3B4D0B1 VA: 0x3B4CFB0
	|-ReadOnlyCollection<RendererListHandle>.System.Collections.IList.Contains
	|
	|-RVA: 0x3B4DF90 Offset: 0x3B4E091 VA: 0x3B4DF90
	|-ReadOnlyCollection<ResourceHandle>.System.Collections.IList.Contains
	|
	|-RVA: 0x3AAF650 Offset: 0x3AAF751 VA: 0x3AAF650
	|-ReadOnlyCollection<sbyte>.System.Collections.IList.Contains
	|
	|-RVA: 0x3AB0670 Offset: 0x3AB0771 VA: 0x3AB0670
	|-ReadOnlyCollection<ShaderTagId>.System.Collections.IList.Contains
	|
	|-RVA: 0x3AB1650 Offset: 0x3AB1751 VA: 0x3AB1650
	|-ReadOnlyCollection<float>.System.Collections.IList.Contains
	|
	|-RVA: 0x3AB29E0 Offset: 0x3AB2AE1 VA: 0x3AB29E0
	|-ReadOnlyCollection<SphericalHarmonicsL2>.System.Collections.IList.Contains
	|
	|-RVA: 0x3AB3B60 Offset: 0x3AB3C61 VA: 0x3AB3B60
	|-ReadOnlyCollection<SubMeshDescriptor>.System.Collections.IList.Contains
	|
	|-RVA: 0x3AB4B60 Offset: 0x3AB4C61 VA: 0x3AB4B60
	|-ReadOnlyCollection<TablePair>.System.Collections.IList.Contains
	|
	|-RVA: 0x3AB5B40 Offset: 0x3AB5C41 VA: 0x3AB5B40
	|-ReadOnlyCollection<TimeSpan>.System.Collections.IList.Contains
	|
	|-RVA: 0x3AB6B60 Offset: 0x3AB6C61 VA: 0x3AB6B60
	|-ReadOnlyCollection<UICharInfo>.System.Collections.IList.Contains
	|
	|-RVA: 0x3AB7B50 Offset: 0x3AB7C51 VA: 0x3AB7B50
	|-ReadOnlyCollection<UILineInfo>.System.Collections.IList.Contains
	|
	|-RVA: 0x3AB8EE0 Offset: 0x3AB8FE1 VA: 0x3AB8EE0
	|-ReadOnlyCollection<UIVertex>.System.Collections.IList.Contains
	|
	|-RVA: 0x3AB9F20 Offset: 0x3ABA021 VA: 0x3AB9F20
	|-ReadOnlyCollection<ushort>.System.Collections.IList.Contains
	|
	|-RVA: 0x3ABAF00 Offset: 0x3ABB001 VA: 0x3ABAF00
	|-ReadOnlyCollection<uint>.System.Collections.IList.Contains
	|
	|-RVA: 0x3ABBEE0 Offset: 0x3ABBFE1 VA: 0x3ABBEE0
	|-ReadOnlyCollection<ulong>.System.Collections.IList.Contains
	|
	|-RVA: 0x3ABCEE0 Offset: 0x3ABCFE1 VA: 0x3ABCEE0
	|-ReadOnlyCollection<Vector2>.System.Collections.IList.Contains
	|
	|-RVA: 0x3ABDF00 Offset: 0x3ABE001 VA: 0x3ABDF00
	|-ReadOnlyCollection<Vector3>.System.Collections.IList.Contains
	|
	|-RVA: 0x3ABEF20 Offset: 0x3ABF021 VA: 0x3ABEF20
	|-ReadOnlyCollection<Vector4>.System.Collections.IList.Contains
	|
	|-RVA: 0x3ABFF10 Offset: 0x3AC0011 VA: 0x3ABFF10
	|-ReadOnlyCollection<VertexAttributeDescriptor>.System.Collections.IList.Contains
	|
	|-RVA: 0x3AC0F00 Offset: 0x3AC1001 VA: 0x3AC0F00
	|-ReadOnlyCollection<X509ChainStatus>.System.Collections.IList.Contains
	|
	|-RVA: 0x3AC2020 Offset: 0x3AC2121 VA: 0x3AC2020
	|-ReadOnlyCollection<XRView>.System.Collections.IList.Contains
	|
	|-RVA: 0x3AC3050 Offset: 0x3AC3151 VA: 0x3AC3050
	|-ReadOnlyCollection<AICrossfire.PositionTable>.System.Collections.IList.Contains
	|
	|-RVA: 0x3AC4040 Offset: 0x3AC4141 VA: 0x3AC4040
	|-ReadOnlyCollection<AmiiboSequence.GainItemData>.System.Collections.IList.Contains
	|
	|-RVA: 0x3AC5150 Offset: 0x3AC5251 VA: 0x3AC5150
	|-ReadOnlyCollection<AnimationOutputWeightProcessor.WeightInfo>.System.Collections.IList.Contains
	|
	|-RVA: 0x3AC6150 Offset: 0x3AC6251 VA: 0x3AC6150
	|-ReadOnlyCollection<ArenaOrderSequence.GodInfo>.System.Collections.IList.Contains
	|
	|-RVA: 0x3AC7140 Offset: 0x3AC7241 VA: 0x3AC7140
	|-ReadOnlyCollection<BattleInfo.SupportData>.System.Collections.IList.Contains
	|
	|-RVA: 0x3AC8130 Offset: 0x3AC8231 VA: 0x3AC8130
	|-ReadOnlyCollection<BeforeRenderHelper.OrderBlock>.System.Collections.IList.Contains
	|
	|-RVA: 0x3AC91F0 Offset: 0x3AC92F1 VA: 0x3AC91F0
	|-ReadOnlyCollection<Camera.RenderRequest>.System.Collections.IList.Contains
	|
	|-RVA: 0x3ACA1E0 Offset: 0x3ACA2E1 VA: 0x3ACA1E0
	|-ReadOnlyCollection<CameraState.CustomBlendable>.System.Collections.IList.Contains
	|
	|-RVA: 0x3ACB1C0 Offset: 0x3ACB2C1 VA: 0x3ACB1C0
	|-ReadOnlyCollection<CinemachineClearShot.Pair>.System.Collections.IList.Contains
	|
	|-RVA: 0x3ACC1A0 Offset: 0x3ACC2A1 VA: 0x3ACC1A0
	|-ReadOnlyCollection<CinemachineStateDrivenCamera.HashPair>.System.Collections.IList.Contains
	|
	|-RVA: 0x3ACD260 Offset: 0x3ACD361 VA: 0x3ACD260
	|-ReadOnlyCollection<DelayedActionManager.DelegateInfo>.System.Collections.IList.Contains
	|
	|-RVA: 0x3ACE380 Offset: 0x3ACE481 VA: 0x3ACE380
	|-ReadOnlyCollection<Detail.AsyncResultInt>.System.Collections.IList.Contains
	|
	|-RVA: 0x3ACF380 Offset: 0x3ACF481 VA: 0x3ACF380
	|-ReadOnlyCollection<Detail.CppArray>.System.Collections.IList.Contains
	|
	|-RVA: 0x3AD04A0 Offset: 0x3AD05A1 VA: 0x3AD04A0
	|-ReadOnlyCollection<Detail.NotificationEventInt>.System.Collections.IList.Contains
	|
	|-RVA: 0x3AD14A0 Offset: 0x3AD15A1 VA: 0x3AD14A0
	|-ReadOnlyCollection<DragonRideTargetGroup.ChainParam>.System.Collections.IList.Contains
	|
	|-RVA: 0x3AD2560 Offset: 0x3AD2661 VA: 0x3AD2560
	|-ReadOnlyCollection<GmapPathAdjuster.TargetModel>.System.Collections.IList.Contains
	|
	|-RVA: 0x3AD3620 Offset: 0x3AD3721 VA: 0x3AD3620
	|-ReadOnlyCollection<GmapSpotAdjuster.TargetModel>.System.Collections.IList.Contains
	|
	|-RVA: 0x3AD46E0 Offset: 0x3AD47E1 VA: 0x3AD46E0
	|-ReadOnlyCollection<HubFastTravel.Location>.System.Collections.IList.Contains
	|
	|-RVA: 0x3AD5800 Offset: 0x3AD5901 VA: 0x3AD5800
	|-ReadOnlyCollection<HubLensFlare.Flare>.System.Collections.IList.Contains
	|
	|-RVA: 0x3AD6800 Offset: 0x3AD6901 VA: 0x3AD6800
	|-ReadOnlyCollection<InventoryPoolItemMenuContent.KindBgNameClass>.System.Collections.IList.Contains
	|
	|-RVA: 0x3AD77E0 Offset: 0x3AD78E1 VA: 0x3AD77E0
	|-ReadOnlyCollection<Map.Pos>.System.Collections.IList.Contains
	|
	|-RVA: 0x3AD87D0 Offset: 0x3AD88D1 VA: 0x3AD87D0
	|-ReadOnlyCollection<MapImage.BackupTerrain>.System.Collections.IList.Contains
	|
	|-RVA: 0x3AD97F0 Offset: 0x3AD98F1 VA: 0x3AD97F0
	|-ReadOnlyCollection<MapImageRange.Pos>.System.Collections.IList.Contains
	|
	|-RVA: 0x3ADA8B0 Offset: 0x3ADA9B1 VA: 0x3ADA8B0
	|-ReadOnlyCollection<MapMind.Target>.System.Collections.IList.Contains
	|
	|-RVA: 0x38C5290 Offset: 0x38C5391 VA: 0x38C5290
	|-ReadOnlyCollection<MapPanelDebug.Entity>.System.Collections.IList.Contains
	|
	|-RVA: 0x38C6270 Offset: 0x38C6371 VA: 0x38C6270
	|-ReadOnlyCollection<NexRanking.Data>.System.Collections.IList.Contains
	|
	|-RVA: 0x38C7260 Offset: 0x38C7361 VA: 0x38C7260
	|-ReadOnlyCollection<NexVersus.RatingData>.System.Collections.IList.Contains
	|
	|-RVA: 0x38C8250 Offset: 0x38C8351 VA: 0x38C8250
	|-ReadOnlyCollection<PackedPlayModeBuildLogs.RuntimeBuildLog>.System.Collections.IList.Contains
	|
	|-RVA: 0x38C9370 Offset: 0x38C9471 VA: 0x38C9370
	|-ReadOnlyCollection<ParticleSystem.Particle>.System.Collections.IList.Contains
	|
	|-RVA: 0x38CA350 Offset: 0x38CA451 VA: 0x38CA350
	|-ReadOnlyCollection<RangeData.Offset>.System.Collections.IList.Contains
	|
	|-RVA: 0x38CB410 Offset: 0x38CB511 VA: 0x38CB410
	|-ReadOnlyCollection<RenderGraphDebugData.PassDebugData>.System.Collections.IList.Contains
	|
	|-RVA: 0x38CC520 Offset: 0x38CC621 VA: 0x38CC520
	|-ReadOnlyCollection<RenderGraphDebugData.ResourceDebugData>.System.Collections.IList.Contains
	|
	|-RVA: 0x38CD520 Offset: 0x38CD621 VA: 0x38CD520
	|-ReadOnlyCollection<RingCleaningUnitSelectMenu.GodParam>.System.Collections.IList.Contains
	|
	|-RVA: 0x38CE640 Offset: 0x38CE741 VA: 0x38CE640
	|-ReadOnlyCollection<ShadowUtility.Edge>.System.Collections.IList.Contains
	|
	|-RVA: 0x38CF670 Offset: 0x38CF771 VA: 0x38CF670
	|-ReadOnlyCollection<SkillArray.Entity>.System.Collections.IList.Contains
	|
	|-RVA: 0x38D07E0 Offset: 0x38D08E1 VA: 0x38D07E0
	|-ReadOnlyCollection<TexturePacker_JsonArray.Frame>.System.Collections.IList.Contains
	|
	|-RVA: 0x38D18C0 Offset: 0x38D19C1 VA: 0x38D18C0
	|-ReadOnlyCollection<TimeNotificationBehaviour.NotificationEntry>.System.Collections.IList.Contains
	|
	|-RVA: 0x38D2980 Offset: 0x38D2A81 VA: 0x38D2980
	|-ReadOnlyCollection<UnitySynchronizationContext.WorkRequest>.System.Collections.IList.Contains
	|
	|-RVA: 0x38D3970 Offset: 0x38D3A71 VA: 0x38D3970
	|-ReadOnlyCollection<XmlSchemaObjectTable.XmlSchemaObjectEntry>.System.Collections.IList.Contains
	|
	|-RVA: 0x38D4960 Offset: 0x38D4A61 VA: 0x38D4960
	|-ReadOnlyCollection<AssetBundleBuildMap.AssetBundleEntry.AssetPathString>.System.Collections.IList.Contains
	|
	|-RVA: 0x38D5AA0 Offset: 0x38D5BA1 VA: 0x38D5AA0
	|-ReadOnlyCollection<Detail.DataStore.DataStoreChangeMetaParamInt>.System.Collections.IList.Contains
	|
	|-RVA: 0x38D6A90 Offset: 0x38D6B91 VA: 0x38D6A90
	|-ReadOnlyCollection<Detail.DataStore.DataStoreDeleteParamInt>.System.Collections.IList.Contains
	|
	|-RVA: 0x38D7BA0 Offset: 0x38D7CA1 VA: 0x38D7BA0
	|-ReadOnlyCollection<Detail.DataStore.DataStoreGetMetaParamInt>.System.Collections.IList.Contains
	|
	|-RVA: 0x38D8CD0 Offset: 0x38D8DD1 VA: 0x38D8CD0
	|-ReadOnlyCollection<Detail.DataStore.DataStoreMetaInfoInt>.System.Collections.IList.Contains
	|
	|-RVA: 0x38D9D90 Offset: 0x38D9E91 VA: 0x38D9D90
	|-ReadOnlyCollection<Detail.DataStore.DataStorePasswordInfoInt>.System.Collections.IList.Contains
	|
	|-RVA: 0x38DAE50 Offset: 0x38DAF51 VA: 0x38DAE50
	|-ReadOnlyCollection<Detail.DataStore.DataStorePersistenceInfoInt>.System.Collections.IList.Contains
	|
	|-RVA: 0x38DBF70 Offset: 0x38DC071 VA: 0x38DBF70
	|-ReadOnlyCollection<Detail.DataStore.DataStorePreparePostParamInt>.System.Collections.IList.Contains
	|
	|-RVA: 0x38DCF60 Offset: 0x38DD061 VA: 0x38DCF60
	|-ReadOnlyCollection<Detail.DataStore.DataStoreRateObjectParamInt>.System.Collections.IList.Contains
	|
	|-RVA: 0x38DE020 Offset: 0x38DE121 VA: 0x38DE020
	|-ReadOnlyCollection<Detail.DataStore.DataStoreRatingInitParamInt>.System.Collections.IList.Contains
	|
	|-RVA: 0x38DF010 Offset: 0x38DF111 VA: 0x38DF010
	|-ReadOnlyCollection<Detail.DataStore.DataStoreRatingTargetInt>.System.Collections.IList.Contains
	|
	|-RVA: 0x38E0180 Offset: 0x38E0281 VA: 0x38E0180
	|-ReadOnlyCollection<Detail.Ranking.RankingCachedResultInt>.System.Collections.IList.Contains
	|
	|-RVA: 0x38E1190 Offset: 0x38E1291 VA: 0x38E1190
	|-ReadOnlyCollection<Detail.Ranking.RankingOrderParamInt>.System.Collections.IList.Contains
	|
	|-RVA: 0x38E2300 Offset: 0x38E2401 VA: 0x38E2300
	|-ReadOnlyCollection<Detail.Ranking.RankingRankDataInt>.System.Collections.IList.Contains
	|
	|-RVA: 0x38E35F0 Offset: 0x38E36F1 VA: 0x38E35F0
	|-ReadOnlyCollection<Detail.Ranking2.Ranking2ChartInfoInt>.System.Collections.IList.Contains
	|
	|-RVA: 0x38E47A0 Offset: 0x38E48A1 VA: 0x38E47A0
	|-ReadOnlyCollection<Detail.Ranking2.Ranking2RankDataInt>.System.Collections.IList.Contains
	|
	|-RVA: 0x38E57B0 Offset: 0x38E58B1 VA: 0x38E57B0
	|-ReadOnlyCollection<Detail.Ranking2.Ranking2ScoreDataInt>.System.Collections.IList.Contains
	|
	|-RVA: 0x38E6870 Offset: 0x38E6971 VA: 0x38E6870
	|-ReadOnlyCollection<Detail.Screening.ScreeningContextInfoInt>.System.Collections.IList.Contains
	|
	|-RVA: 0x38E7A90 Offset: 0x38E7B91 VA: 0x38E7A90
	|-ReadOnlyCollection<Detail.Subscriber.SubscriberContentInt>.System.Collections.IList.Contains
	|
	|-RVA: 0x38E8B80 Offset: 0x38E8C81 VA: 0x38E8B80
	|-ReadOnlyCollection<Detail.Subscriber.SubscriberGetContentParamInt>.System.Collections.IList.Contains
	|
	|-RVA: 0x38E9C90 Offset: 0x38E9D91 VA: 0x38E9C90
	|-ReadOnlyCollection<Detail.Subscriber.SubscriberUserStatusInfoInt>.System.Collections.IList.Contains
	|
	|-RVA: 0x38EAD60 Offset: 0x38EAE61 VA: 0x38EAD60
	|-ReadOnlyCollection<Detail.Subscriber.SubscriberUserStatusParamInt>.System.Collections.IList.Contains
	|
	|-RVA: 0x38EBD40 Offset: 0x38EBE41 VA: 0x38EBD40
	|-ReadOnlyCollection<Detail.Utility.IntegerSettings>.System.Collections.IList.Contains
	|
	|-RVA: 0x38ECD30 Offset: 0x38ECE31 VA: 0x38ECD30
	|-ReadOnlyCollection<Detail.Utility.UniqueIdInfoInt>.System.Collections.IList.Contains
	|
	|-RVA: 0x38EDD60 Offset: 0x38EDE61 VA: 0x38EDD60
	|-ReadOnlyCollection<MapHistory.Rewind.LatestInspectorData>.System.Collections.IList.Contains
	|
	|-RVA: 0x38EED90 Offset: 0x38EEE91 VA: 0x38EED90
	|-ReadOnlyCollection<MapHistory.Rewind.WorkTerrainData>.System.Collections.IList.Contains
	|
	|-RVA: 0x38EFD80 Offset: 0x38EFE81 VA: 0x38EFD80
	|-ReadOnlyCollection<MapSkill.AroundCalculator.Result>.System.Collections.IList.Contains
	|
	|-RVA: 0x38F0EA0 Offset: 0x38F0FA1 VA: 0x38F0EA0
	|-ReadOnlyCollection<TargetPositionCache.CacheCurve.Item>.System.Collections.IList.Contains
	|
	|-RVA: 0x2FE6440 Offset: 0x2FE6541 VA: 0x2FE6440
	|-ReadOnlyCollection<TargetPositionCache.CacheEntry.RecordingItem>.System.Collections.IList.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 24
	private int System.Collections.IList.IndexOf(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3468330 Offset: 0x3468431 VA: 0x3468330
	|-ReadOnlyCollection<IntervalTree.Entry<object>>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3469320 Offset: 0x3469421 VA: 0x3469320
	|-ReadOnlyCollection<KeyValuePair<DateTime, object>>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x346A310 Offset: 0x346A411 VA: 0x346A310
	|-ReadOnlyCollection<KeyValuePair<int, object>>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x346B3D0 Offset: 0x346B4D1 VA: 0x346B3D0
	|-ReadOnlyCollection<KeyValuePair<object, ValueTuple<int, DateTime, object>>>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x346C3C0 Offset: 0x346C4C1 VA: 0x346C3C0
	|-ReadOnlyCollection<KeyValuePair<object, object>>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x346D480 Offset: 0x346D581 VA: 0x346D480
	|-ReadOnlyCollection<CommonBattleSequence.Reliance<object>>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x346E470 Offset: 0x346E571 VA: 0x346E470
	|-ReadOnlyCollection<RenderGraphResourcePool.ResourceLogInfo<object>>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x346F460 Offset: 0x346F561 VA: 0x346F460
	|-ReadOnlyCollection<ValueTuple<int, object>>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3470440 Offset: 0x3470541 VA: 0x3470440
	|-ReadOnlyCollection<ValueTuple<Int32Enum, int>>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3471500 Offset: 0x3471601 VA: 0x3471500
	|-ReadOnlyCollection<ValueTuple<object, ValueTuple<object, int>>>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x34724F0 Offset: 0x34725F1 VA: 0x34724F0
	|-ReadOnlyCollection<ValueTuple<object, int>>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3473510 Offset: 0x3473611 VA: 0x3473510
	|-ReadOnlyCollection<ValueTuple<Vector3, float>>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3474500 Offset: 0x3474601 VA: 0x3474500
	|-ReadOnlyCollection<ValueTuple<object, Int32Enum, int>>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x34755C0 Offset: 0x34756C1 VA: 0x34755C0
	|-ReadOnlyCollection<ValueTuple<object, int, int, int>>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x34765A0 Offset: 0x34766A1 VA: 0x34765A0
	|-ReadOnlyCollection<AnimatorClipInfo>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3B23400 Offset: 0x3B23501 VA: 0x3B23400
	|-ReadOnlyCollection<AsyncOperationHandle>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3B244C0 Offset: 0x3B245C1 VA: 0x3B244C0
	|-ReadOnlyCollection<BoneWeight>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3B254B0 Offset: 0x3B255B1 VA: 0x3B254B0
	|-ReadOnlyCollection<bool>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3B26490 Offset: 0x3B26591 VA: 0x3B26490
	|-ReadOnlyCollection<byte>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3B27480 Offset: 0x3B27581 VA: 0x3B27480
	|-ReadOnlyCollection<CameraInfo>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3B28460 Offset: 0x3B28561 VA: 0x3B28460
	|-ReadOnlyCollection<char>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3B29480 Offset: 0x3B29581 VA: 0x3B29480
	|-ReadOnlyCollection<Color>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3B2A4A0 Offset: 0x3B2A5A1 VA: 0x3B2A4A0
	|-ReadOnlyCollection<Color32>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3B2B490 Offset: 0x3B2B591 VA: 0x3B2B490
	|-ReadOnlyCollection<ConstraintSource>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3B2C550 Offset: 0x3B2C651 VA: 0x3B2C550
	|-ReadOnlyCollection<ContourVertex>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3B2D610 Offset: 0x3B2D711 VA: 0x3B2D610
	|-ReadOnlyCollection<CustomAttributeNamedArgument>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3B2E600 Offset: 0x3B2E701 VA: 0x3B2E600
	|-ReadOnlyCollection<CustomAttributeTypedArgument>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3B2F6C0 Offset: 0x3B2F7C1 VA: 0x3B2F6C0
	|-ReadOnlyCollection<DataStoreRatingInfo>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3B306A0 Offset: 0x3B307A1 VA: 0x3B306A0
	|-ReadOnlyCollection<DataStoreResult>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3B31680 Offset: 0x3B31781 VA: 0x3B31680
	|-ReadOnlyCollection<DateTime>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3B32670 Offset: 0x3B32771 VA: 0x3B32670
	|-ReadOnlyCollection<DateTimeOffset>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3B33660 Offset: 0x3B33761 VA: 0x3B33660
	|-ReadOnlyCollection<Decimal>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3B34790 Offset: 0x3B34891 VA: 0x3B34790
	|-ReadOnlyCollection<DiagnosticEvent>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3B35770 Offset: 0x3B35871 VA: 0x3B35770
	|-ReadOnlyCollection<double>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3B368A0 Offset: 0x3B369A1 VA: 0x3B368A0
	|-ReadOnlyCollection<Friend>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3B37890 Offset: 0x3B37991 VA: 0x3B37890
	|-ReadOnlyCollection<GlyphRect>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3B38870 Offset: 0x3B38971 VA: 0x3B38870
	|-ReadOnlyCollection<short>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3B39850 Offset: 0x3B39951 VA: 0x3B39850
	|-ReadOnlyCollection<int>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3B3A830 Offset: 0x3B3A931 VA: 0x3B3A830
	|-ReadOnlyCollection<Int32Enum>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3B3B810 Offset: 0x3B3B911 VA: 0x3B3B810
	|-ReadOnlyCollection<long>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3B3C7F0 Offset: 0x3B3C8F1 VA: 0x3B3C7F0
	|-ReadOnlyCollection<IntPtr>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3B3D7E0 Offset: 0x3B3D8E1 VA: 0x3B3D7E0
	|-ReadOnlyCollection<InterpretedFrameInfo>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3B3E8A0 Offset: 0x3B3E9A1 VA: 0x3B3E8A0
	|-ReadOnlyCollection<IntervalTreeNode>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3B3F880 Offset: 0x3B3F981 VA: 0x3B3F880
	|-ReadOnlyCollection<LengthLimitProperties>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3B40860 Offset: 0x3B40961 VA: 0x3B40860
	|-ReadOnlyCollection<MapPos>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3B419E0 Offset: 0x3B41AE1 VA: 0x3B419E0
	|-ReadOnlyCollection<Matrix4x4>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3B428F0 Offset: 0x3B429F1 VA: 0x3B428F0
	|-ReadOnlyCollection<object>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3B43A10 Offset: 0x3B43B11 VA: 0x3B43A10
	|-ReadOnlyCollection<ObjectInitializationData>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3B44AD0 Offset: 0x3B44BD1 VA: 0x3B44AD0
	|-ReadOnlyCollection<PlayableBinding>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3B45BF0 Offset: 0x3B45CF1 VA: 0x3B45BF0
	|-ReadOnlyCollection<PlayerLoopSystem>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3B46D10 Offset: 0x3B46E11 VA: 0x3B46D10
	|-ReadOnlyCollection<PlayerLoopSystemInternal>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3B47D00 Offset: 0x3B47E01 VA: 0x3B47D00
	|-ReadOnlyCollection<RangePositionInfo>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3B48CE0 Offset: 0x3B48DE1 VA: 0x3B48CE0
	|-ReadOnlyCollection<Ranking2ChartInfoInput>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3B49E30 Offset: 0x3B49F31 VA: 0x3B49E30
	|-ReadOnlyCollection<RaycastHit2D>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3B4B080 Offset: 0x3B4B181 VA: 0x3B4B080
	|-ReadOnlyCollection<RaycastResult>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3B4C0B0 Offset: 0x3B4C1B1 VA: 0x3B4C0B0
	|-ReadOnlyCollection<Rect>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3B4D090 Offset: 0x3B4D191 VA: 0x3B4D090
	|-ReadOnlyCollection<RendererListHandle>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3B4E070 Offset: 0x3B4E171 VA: 0x3B4E070
	|-ReadOnlyCollection<ResourceHandle>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3AAF730 Offset: 0x3AAF831 VA: 0x3AAF730
	|-ReadOnlyCollection<sbyte>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3AB0750 Offset: 0x3AB0851 VA: 0x3AB0750
	|-ReadOnlyCollection<ShaderTagId>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3AB1730 Offset: 0x3AB1831 VA: 0x3AB1730
	|-ReadOnlyCollection<float>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3AB2AF0 Offset: 0x3AB2BF1 VA: 0x3AB2AF0
	|-ReadOnlyCollection<SphericalHarmonicsL2>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3AB3C50 Offset: 0x3AB3D51 VA: 0x3AB3C50
	|-ReadOnlyCollection<SubMeshDescriptor>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3AB4C40 Offset: 0x3AB4D41 VA: 0x3AB4C40
	|-ReadOnlyCollection<TablePair>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3AB5C20 Offset: 0x3AB5D21 VA: 0x3AB5C20
	|-ReadOnlyCollection<TimeSpan>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3AB6C40 Offset: 0x3AB6D41 VA: 0x3AB6C40
	|-ReadOnlyCollection<UICharInfo>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3AB7C30 Offset: 0x3AB7D31 VA: 0x3AB7C30
	|-ReadOnlyCollection<UILineInfo>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3AB8FF0 Offset: 0x3AB90F1 VA: 0x3AB8FF0
	|-ReadOnlyCollection<UIVertex>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3ABA000 Offset: 0x3ABA101 VA: 0x3ABA000
	|-ReadOnlyCollection<ushort>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3ABAFE0 Offset: 0x3ABB0E1 VA: 0x3ABAFE0
	|-ReadOnlyCollection<uint>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3ABBFC0 Offset: 0x3ABC0C1 VA: 0x3ABBFC0
	|-ReadOnlyCollection<ulong>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3ABCFC0 Offset: 0x3ABD0C1 VA: 0x3ABCFC0
	|-ReadOnlyCollection<Vector2>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3ABDFE0 Offset: 0x3ABE0E1 VA: 0x3ABDFE0
	|-ReadOnlyCollection<Vector3>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3ABF000 Offset: 0x3ABF101 VA: 0x3ABF000
	|-ReadOnlyCollection<Vector4>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3ABFFF0 Offset: 0x3AC00F1 VA: 0x3ABFFF0
	|-ReadOnlyCollection<VertexAttributeDescriptor>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3AC0FE0 Offset: 0x3AC10E1 VA: 0x3AC0FE0
	|-ReadOnlyCollection<X509ChainStatus>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3AC2100 Offset: 0x3AC2201 VA: 0x3AC2100
	|-ReadOnlyCollection<XRView>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3AC3130 Offset: 0x3AC3231 VA: 0x3AC3130
	|-ReadOnlyCollection<AICrossfire.PositionTable>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3AC4120 Offset: 0x3AC4221 VA: 0x3AC4120
	|-ReadOnlyCollection<AmiiboSequence.GainItemData>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3AC5240 Offset: 0x3AC5341 VA: 0x3AC5240
	|-ReadOnlyCollection<AnimationOutputWeightProcessor.WeightInfo>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3AC6230 Offset: 0x3AC6331 VA: 0x3AC6230
	|-ReadOnlyCollection<ArenaOrderSequence.GodInfo>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3AC7220 Offset: 0x3AC7321 VA: 0x3AC7220
	|-ReadOnlyCollection<BattleInfo.SupportData>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3AC8210 Offset: 0x3AC8311 VA: 0x3AC8210
	|-ReadOnlyCollection<BeforeRenderHelper.OrderBlock>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3AC92D0 Offset: 0x3AC93D1 VA: 0x3AC92D0
	|-ReadOnlyCollection<Camera.RenderRequest>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3ACA2C0 Offset: 0x3ACA3C1 VA: 0x3ACA2C0
	|-ReadOnlyCollection<CameraState.CustomBlendable>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3ACB2A0 Offset: 0x3ACB3A1 VA: 0x3ACB2A0
	|-ReadOnlyCollection<CinemachineClearShot.Pair>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3ACC280 Offset: 0x3ACC381 VA: 0x3ACC280
	|-ReadOnlyCollection<CinemachineStateDrivenCamera.HashPair>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3ACD340 Offset: 0x3ACD441 VA: 0x3ACD340
	|-ReadOnlyCollection<DelayedActionManager.DelegateInfo>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3ACE470 Offset: 0x3ACE571 VA: 0x3ACE470
	|-ReadOnlyCollection<Detail.AsyncResultInt>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3ACF460 Offset: 0x3ACF561 VA: 0x3ACF460
	|-ReadOnlyCollection<Detail.CppArray>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3AD0590 Offset: 0x3AD0691 VA: 0x3AD0590
	|-ReadOnlyCollection<Detail.NotificationEventInt>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3AD1580 Offset: 0x3AD1681 VA: 0x3AD1580
	|-ReadOnlyCollection<DragonRideTargetGroup.ChainParam>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3AD2640 Offset: 0x3AD2741 VA: 0x3AD2640
	|-ReadOnlyCollection<GmapPathAdjuster.TargetModel>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3AD3700 Offset: 0x3AD3801 VA: 0x3AD3700
	|-ReadOnlyCollection<GmapSpotAdjuster.TargetModel>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3AD47C0 Offset: 0x3AD48C1 VA: 0x3AD47C0
	|-ReadOnlyCollection<HubFastTravel.Location>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3AD58F0 Offset: 0x3AD59F1 VA: 0x3AD58F0
	|-ReadOnlyCollection<HubLensFlare.Flare>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3AD68E0 Offset: 0x3AD69E1 VA: 0x3AD68E0
	|-ReadOnlyCollection<InventoryPoolItemMenuContent.KindBgNameClass>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3AD78C0 Offset: 0x3AD79C1 VA: 0x3AD78C0
	|-ReadOnlyCollection<Map.Pos>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3AD88B0 Offset: 0x3AD89B1 VA: 0x3AD88B0
	|-ReadOnlyCollection<MapImage.BackupTerrain>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3AD98D0 Offset: 0x3AD99D1 VA: 0x3AD98D0
	|-ReadOnlyCollection<MapImageRange.Pos>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3ADA990 Offset: 0x3ADAA91 VA: 0x3ADA990
	|-ReadOnlyCollection<MapMind.Target>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x38C5370 Offset: 0x38C5471 VA: 0x38C5370
	|-ReadOnlyCollection<MapPanelDebug.Entity>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x38C6350 Offset: 0x38C6451 VA: 0x38C6350
	|-ReadOnlyCollection<NexRanking.Data>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x38C7340 Offset: 0x38C7441 VA: 0x38C7340
	|-ReadOnlyCollection<NexVersus.RatingData>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x38C8330 Offset: 0x38C8431 VA: 0x38C8330
	|-ReadOnlyCollection<PackedPlayModeBuildLogs.RuntimeBuildLog>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x38C9450 Offset: 0x38C9551 VA: 0x38C9450
	|-ReadOnlyCollection<ParticleSystem.Particle>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x38CA430 Offset: 0x38CA531 VA: 0x38CA430
	|-ReadOnlyCollection<RangeData.Offset>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x38CB4F0 Offset: 0x38CB5F1 VA: 0x38CB4F0
	|-ReadOnlyCollection<RenderGraphDebugData.PassDebugData>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x38CC610 Offset: 0x38CC711 VA: 0x38CC610
	|-ReadOnlyCollection<RenderGraphDebugData.ResourceDebugData>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x38CD600 Offset: 0x38CD701 VA: 0x38CD600
	|-ReadOnlyCollection<RingCleaningUnitSelectMenu.GodParam>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x38CE730 Offset: 0x38CE831 VA: 0x38CE730
	|-ReadOnlyCollection<ShadowUtility.Edge>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x38CF750 Offset: 0x38CF851 VA: 0x38CF750
	|-ReadOnlyCollection<SkillArray.Entity>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x38D08D0 Offset: 0x38D09D1 VA: 0x38D08D0
	|-ReadOnlyCollection<TexturePacker_JsonArray.Frame>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x38D19A0 Offset: 0x38D1AA1 VA: 0x38D19A0
	|-ReadOnlyCollection<TimeNotificationBehaviour.NotificationEntry>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x38D2A60 Offset: 0x38D2B61 VA: 0x38D2A60
	|-ReadOnlyCollection<UnitySynchronizationContext.WorkRequest>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x38D3A50 Offset: 0x38D3B51 VA: 0x38D3A50
	|-ReadOnlyCollection<XmlSchemaObjectTable.XmlSchemaObjectEntry>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x38D4A40 Offset: 0x38D4B41 VA: 0x38D4A40
	|-ReadOnlyCollection<AssetBundleBuildMap.AssetBundleEntry.AssetPathString>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x38D5B80 Offset: 0x38D5C81 VA: 0x38D5B80
	|-ReadOnlyCollection<Detail.DataStore.DataStoreChangeMetaParamInt>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x38D6B70 Offset: 0x38D6C71 VA: 0x38D6B70
	|-ReadOnlyCollection<Detail.DataStore.DataStoreDeleteParamInt>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x38D7C90 Offset: 0x38D7D91 VA: 0x38D7C90
	|-ReadOnlyCollection<Detail.DataStore.DataStoreGetMetaParamInt>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x38D8DB0 Offset: 0x38D8EB1 VA: 0x38D8DB0
	|-ReadOnlyCollection<Detail.DataStore.DataStoreMetaInfoInt>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x38D9E70 Offset: 0x38D9F71 VA: 0x38D9E70
	|-ReadOnlyCollection<Detail.DataStore.DataStorePasswordInfoInt>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x38DAF30 Offset: 0x38DB031 VA: 0x38DAF30
	|-ReadOnlyCollection<Detail.DataStore.DataStorePersistenceInfoInt>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x38DC050 Offset: 0x38DC151 VA: 0x38DC050
	|-ReadOnlyCollection<Detail.DataStore.DataStorePreparePostParamInt>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x38DD040 Offset: 0x38DD141 VA: 0x38DD040
	|-ReadOnlyCollection<Detail.DataStore.DataStoreRateObjectParamInt>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x38DE100 Offset: 0x38DE201 VA: 0x38DE100
	|-ReadOnlyCollection<Detail.DataStore.DataStoreRatingInitParamInt>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x38DF0F0 Offset: 0x38DF1F1 VA: 0x38DF0F0
	|-ReadOnlyCollection<Detail.DataStore.DataStoreRatingTargetInt>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x38E0270 Offset: 0x38E0371 VA: 0x38E0270
	|-ReadOnlyCollection<Detail.Ranking.RankingCachedResultInt>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x38E1270 Offset: 0x38E1371 VA: 0x38E1270
	|-ReadOnlyCollection<Detail.Ranking.RankingOrderParamInt>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x38E23F0 Offset: 0x38E24F1 VA: 0x38E23F0
	|-ReadOnlyCollection<Detail.Ranking.RankingRankDataInt>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x38E36F0 Offset: 0x38E37F1 VA: 0x38E36F0
	|-ReadOnlyCollection<Detail.Ranking2.Ranking2ChartInfoInt>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x38E4890 Offset: 0x38E4991 VA: 0x38E4890
	|-ReadOnlyCollection<Detail.Ranking2.Ranking2RankDataInt>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x38E5890 Offset: 0x38E5991 VA: 0x38E5890
	|-ReadOnlyCollection<Detail.Ranking2.Ranking2ScoreDataInt>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x38E6950 Offset: 0x38E6A51 VA: 0x38E6950
	|-ReadOnlyCollection<Detail.Screening.ScreeningContextInfoInt>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x38E7B90 Offset: 0x38E7C91 VA: 0x38E7B90
	|-ReadOnlyCollection<Detail.Subscriber.SubscriberContentInt>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x38E8C60 Offset: 0x38E8D61 VA: 0x38E8C60
	|-ReadOnlyCollection<Detail.Subscriber.SubscriberGetContentParamInt>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x38E9D80 Offset: 0x38E9E81 VA: 0x38E9D80
	|-ReadOnlyCollection<Detail.Subscriber.SubscriberUserStatusInfoInt>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x38EAE40 Offset: 0x38EAF41 VA: 0x38EAE40
	|-ReadOnlyCollection<Detail.Subscriber.SubscriberUserStatusParamInt>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x38EBE20 Offset: 0x38EBF21 VA: 0x38EBE20
	|-ReadOnlyCollection<Detail.Utility.IntegerSettings>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x38ECE10 Offset: 0x38ECF11 VA: 0x38ECE10
	|-ReadOnlyCollection<Detail.Utility.UniqueIdInfoInt>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x38EDE40 Offset: 0x38EDF41 VA: 0x38EDE40
	|-ReadOnlyCollection<MapHistory.Rewind.LatestInspectorData>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x38EEE70 Offset: 0x38EEF71 VA: 0x38EEE70
	|-ReadOnlyCollection<MapHistory.Rewind.WorkTerrainData>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x38EFE60 Offset: 0x38EFF61 VA: 0x38EFE60
	|-ReadOnlyCollection<MapSkill.AroundCalculator.Result>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x38F0F90 Offset: 0x38F1091 VA: 0x38F0F90
	|-ReadOnlyCollection<TargetPositionCache.CacheCurve.Item>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x2FE6530 Offset: 0x2FE6631 VA: 0x2FE6530
	|-ReadOnlyCollection<TargetPositionCache.CacheEntry.RecordingItem>.System.Collections.IList.IndexOf
	*/

	// RVA: -1 Offset: -1 Slot: 25
	private void System.Collections.IList.Insert(int index, object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3468410 Offset: 0x3468511 VA: 0x3468410
	|-ReadOnlyCollection<IntervalTree.Entry<object>>.System.Collections.IList.Insert
	|
	|-RVA: 0x3469400 Offset: 0x3469501 VA: 0x3469400
	|-ReadOnlyCollection<KeyValuePair<DateTime, object>>.System.Collections.IList.Insert
	|
	|-RVA: 0x346A3F0 Offset: 0x346A4F1 VA: 0x346A3F0
	|-ReadOnlyCollection<KeyValuePair<int, object>>.System.Collections.IList.Insert
	|
	|-RVA: 0x346B4B0 Offset: 0x346B5B1 VA: 0x346B4B0
	|-ReadOnlyCollection<KeyValuePair<object, ValueTuple<int, DateTime, object>>>.System.Collections.IList.Insert
	|
	|-RVA: 0x346C4A0 Offset: 0x346C5A1 VA: 0x346C4A0
	|-ReadOnlyCollection<KeyValuePair<object, object>>.System.Collections.IList.Insert
	|
	|-RVA: 0x346D560 Offset: 0x346D661 VA: 0x346D560
	|-ReadOnlyCollection<CommonBattleSequence.Reliance<object>>.System.Collections.IList.Insert
	|
	|-RVA: 0x346E550 Offset: 0x346E651 VA: 0x346E550
	|-ReadOnlyCollection<RenderGraphResourcePool.ResourceLogInfo<object>>.System.Collections.IList.Insert
	|
	|-RVA: 0x346F540 Offset: 0x346F641 VA: 0x346F540
	|-ReadOnlyCollection<ValueTuple<int, object>>.System.Collections.IList.Insert
	|
	|-RVA: 0x3470520 Offset: 0x3470621 VA: 0x3470520
	|-ReadOnlyCollection<ValueTuple<Int32Enum, int>>.System.Collections.IList.Insert
	|
	|-RVA: 0x34715E0 Offset: 0x34716E1 VA: 0x34715E0
	|-ReadOnlyCollection<ValueTuple<object, ValueTuple<object, int>>>.System.Collections.IList.Insert
	|
	|-RVA: 0x34725D0 Offset: 0x34726D1 VA: 0x34725D0
	|-ReadOnlyCollection<ValueTuple<object, int>>.System.Collections.IList.Insert
	|
	|-RVA: 0x34735F0 Offset: 0x34736F1 VA: 0x34735F0
	|-ReadOnlyCollection<ValueTuple<Vector3, float>>.System.Collections.IList.Insert
	|
	|-RVA: 0x34745E0 Offset: 0x34746E1 VA: 0x34745E0
	|-ReadOnlyCollection<ValueTuple<object, Int32Enum, int>>.System.Collections.IList.Insert
	|
	|-RVA: 0x34756A0 Offset: 0x34757A1 VA: 0x34756A0
	|-ReadOnlyCollection<ValueTuple<object, int, int, int>>.System.Collections.IList.Insert
	|
	|-RVA: 0x3476680 Offset: 0x3476781 VA: 0x3476680
	|-ReadOnlyCollection<AnimatorClipInfo>.System.Collections.IList.Insert
	|
	|-RVA: 0x3B234E0 Offset: 0x3B235E1 VA: 0x3B234E0
	|-ReadOnlyCollection<AsyncOperationHandle>.System.Collections.IList.Insert
	|
	|-RVA: 0x3B245A0 Offset: 0x3B246A1 VA: 0x3B245A0
	|-ReadOnlyCollection<BoneWeight>.System.Collections.IList.Insert
	|
	|-RVA: 0x3B25590 Offset: 0x3B25691 VA: 0x3B25590
	|-ReadOnlyCollection<bool>.System.Collections.IList.Insert
	|
	|-RVA: 0x3B26570 Offset: 0x3B26671 VA: 0x3B26570
	|-ReadOnlyCollection<byte>.System.Collections.IList.Insert
	|
	|-RVA: 0x3B27560 Offset: 0x3B27661 VA: 0x3B27560
	|-ReadOnlyCollection<CameraInfo>.System.Collections.IList.Insert
	|
	|-RVA: 0x3B28540 Offset: 0x3B28641 VA: 0x3B28540
	|-ReadOnlyCollection<char>.System.Collections.IList.Insert
	|
	|-RVA: 0x3B29560 Offset: 0x3B29661 VA: 0x3B29560
	|-ReadOnlyCollection<Color>.System.Collections.IList.Insert
	|
	|-RVA: 0x3B2A580 Offset: 0x3B2A681 VA: 0x3B2A580
	|-ReadOnlyCollection<Color32>.System.Collections.IList.Insert
	|
	|-RVA: 0x3B2B570 Offset: 0x3B2B671 VA: 0x3B2B570
	|-ReadOnlyCollection<ConstraintSource>.System.Collections.IList.Insert
	|
	|-RVA: 0x3B2C630 Offset: 0x3B2C731 VA: 0x3B2C630
	|-ReadOnlyCollection<ContourVertex>.System.Collections.IList.Insert
	|
	|-RVA: 0x3B2D6F0 Offset: 0x3B2D7F1 VA: 0x3B2D6F0
	|-ReadOnlyCollection<CustomAttributeNamedArgument>.System.Collections.IList.Insert
	|
	|-RVA: 0x3B2E6E0 Offset: 0x3B2E7E1 VA: 0x3B2E6E0
	|-ReadOnlyCollection<CustomAttributeTypedArgument>.System.Collections.IList.Insert
	|
	|-RVA: 0x3B2F7A0 Offset: 0x3B2F8A1 VA: 0x3B2F7A0
	|-ReadOnlyCollection<DataStoreRatingInfo>.System.Collections.IList.Insert
	|
	|-RVA: 0x3B30780 Offset: 0x3B30881 VA: 0x3B30780
	|-ReadOnlyCollection<DataStoreResult>.System.Collections.IList.Insert
	|
	|-RVA: 0x3B31760 Offset: 0x3B31861 VA: 0x3B31760
	|-ReadOnlyCollection<DateTime>.System.Collections.IList.Insert
	|
	|-RVA: 0x3B32750 Offset: 0x3B32851 VA: 0x3B32750
	|-ReadOnlyCollection<DateTimeOffset>.System.Collections.IList.Insert
	|
	|-RVA: 0x3B33740 Offset: 0x3B33841 VA: 0x3B33740
	|-ReadOnlyCollection<Decimal>.System.Collections.IList.Insert
	|
	|-RVA: 0x3B34870 Offset: 0x3B34971 VA: 0x3B34870
	|-ReadOnlyCollection<DiagnosticEvent>.System.Collections.IList.Insert
	|
	|-RVA: 0x3B35850 Offset: 0x3B35951 VA: 0x3B35850
	|-ReadOnlyCollection<double>.System.Collections.IList.Insert
	|
	|-RVA: 0x3B36980 Offset: 0x3B36A81 VA: 0x3B36980
	|-ReadOnlyCollection<Friend>.System.Collections.IList.Insert
	|
	|-RVA: 0x3B37970 Offset: 0x3B37A71 VA: 0x3B37970
	|-ReadOnlyCollection<GlyphRect>.System.Collections.IList.Insert
	|
	|-RVA: 0x3B38950 Offset: 0x3B38A51 VA: 0x3B38950
	|-ReadOnlyCollection<short>.System.Collections.IList.Insert
	|
	|-RVA: 0x3B39930 Offset: 0x3B39A31 VA: 0x3B39930
	|-ReadOnlyCollection<int>.System.Collections.IList.Insert
	|
	|-RVA: 0x3B3A910 Offset: 0x3B3AA11 VA: 0x3B3A910
	|-ReadOnlyCollection<Int32Enum>.System.Collections.IList.Insert
	|
	|-RVA: 0x3B3B8F0 Offset: 0x3B3B9F1 VA: 0x3B3B8F0
	|-ReadOnlyCollection<long>.System.Collections.IList.Insert
	|
	|-RVA: 0x3B3C8D0 Offset: 0x3B3C9D1 VA: 0x3B3C8D0
	|-ReadOnlyCollection<IntPtr>.System.Collections.IList.Insert
	|
	|-RVA: 0x3B3D8C0 Offset: 0x3B3D9C1 VA: 0x3B3D8C0
	|-ReadOnlyCollection<InterpretedFrameInfo>.System.Collections.IList.Insert
	|
	|-RVA: 0x3B3E980 Offset: 0x3B3EA81 VA: 0x3B3E980
	|-ReadOnlyCollection<IntervalTreeNode>.System.Collections.IList.Insert
	|
	|-RVA: 0x3B3F960 Offset: 0x3B3FA61 VA: 0x3B3F960
	|-ReadOnlyCollection<LengthLimitProperties>.System.Collections.IList.Insert
	|
	|-RVA: 0x3B40940 Offset: 0x3B40A41 VA: 0x3B40940
	|-ReadOnlyCollection<MapPos>.System.Collections.IList.Insert
	|
	|-RVA: 0x3B41AD0 Offset: 0x3B41BD1 VA: 0x3B41AD0
	|-ReadOnlyCollection<Matrix4x4>.System.Collections.IList.Insert
	|
	|-RVA: 0x3B429C0 Offset: 0x3B42AC1 VA: 0x3B429C0
	|-ReadOnlyCollection<object>.System.Collections.IList.Insert
	|
	|-RVA: 0x3B43AF0 Offset: 0x3B43BF1 VA: 0x3B43AF0
	|-ReadOnlyCollection<ObjectInitializationData>.System.Collections.IList.Insert
	|
	|-RVA: 0x3B44BB0 Offset: 0x3B44CB1 VA: 0x3B44BB0
	|-ReadOnlyCollection<PlayableBinding>.System.Collections.IList.Insert
	|
	|-RVA: 0x3B45CD0 Offset: 0x3B45DD1 VA: 0x3B45CD0
	|-ReadOnlyCollection<PlayerLoopSystem>.System.Collections.IList.Insert
	|
	|-RVA: 0x3B46DF0 Offset: 0x3B46EF1 VA: 0x3B46DF0
	|-ReadOnlyCollection<PlayerLoopSystemInternal>.System.Collections.IList.Insert
	|
	|-RVA: 0x3B47DE0 Offset: 0x3B47EE1 VA: 0x3B47DE0
	|-ReadOnlyCollection<RangePositionInfo>.System.Collections.IList.Insert
	|
	|-RVA: 0x3B48DC0 Offset: 0x3B48EC1 VA: 0x3B48DC0
	|-ReadOnlyCollection<Ranking2ChartInfoInput>.System.Collections.IList.Insert
	|
	|-RVA: 0x3B49F20 Offset: 0x3B4A021 VA: 0x3B49F20
	|-ReadOnlyCollection<RaycastHit2D>.System.Collections.IList.Insert
	|
	|-RVA: 0x3B4B170 Offset: 0x3B4B271 VA: 0x3B4B170
	|-ReadOnlyCollection<RaycastResult>.System.Collections.IList.Insert
	|
	|-RVA: 0x3B4C190 Offset: 0x3B4C291 VA: 0x3B4C190
	|-ReadOnlyCollection<Rect>.System.Collections.IList.Insert
	|
	|-RVA: 0x3B4D170 Offset: 0x3B4D271 VA: 0x3B4D170
	|-ReadOnlyCollection<RendererListHandle>.System.Collections.IList.Insert
	|
	|-RVA: 0x3B4E150 Offset: 0x3B4E251 VA: 0x3B4E150
	|-ReadOnlyCollection<ResourceHandle>.System.Collections.IList.Insert
	|
	|-RVA: 0x3AAF810 Offset: 0x3AAF911 VA: 0x3AAF810
	|-ReadOnlyCollection<sbyte>.System.Collections.IList.Insert
	|
	|-RVA: 0x3AB0830 Offset: 0x3AB0931 VA: 0x3AB0830
	|-ReadOnlyCollection<ShaderTagId>.System.Collections.IList.Insert
	|
	|-RVA: 0x3AB1810 Offset: 0x3AB1911 VA: 0x3AB1810
	|-ReadOnlyCollection<float>.System.Collections.IList.Insert
	|
	|-RVA: 0x3AB2C00 Offset: 0x3AB2D01 VA: 0x3AB2C00
	|-ReadOnlyCollection<SphericalHarmonicsL2>.System.Collections.IList.Insert
	|
	|-RVA: 0x3AB3D30 Offset: 0x3AB3E31 VA: 0x3AB3D30
	|-ReadOnlyCollection<SubMeshDescriptor>.System.Collections.IList.Insert
	|
	|-RVA: 0x3AB4D20 Offset: 0x3AB4E21 VA: 0x3AB4D20
	|-ReadOnlyCollection<TablePair>.System.Collections.IList.Insert
	|
	|-RVA: 0x3AB5D00 Offset: 0x3AB5E01 VA: 0x3AB5D00
	|-ReadOnlyCollection<TimeSpan>.System.Collections.IList.Insert
	|
	|-RVA: 0x3AB6D20 Offset: 0x3AB6E21 VA: 0x3AB6D20
	|-ReadOnlyCollection<UICharInfo>.System.Collections.IList.Insert
	|
	|-RVA: 0x3AB7D10 Offset: 0x3AB7E11 VA: 0x3AB7D10
	|-ReadOnlyCollection<UILineInfo>.System.Collections.IList.Insert
	|
	|-RVA: 0x3AB9100 Offset: 0x3AB9201 VA: 0x3AB9100
	|-ReadOnlyCollection<UIVertex>.System.Collections.IList.Insert
	|
	|-RVA: 0x3ABA0E0 Offset: 0x3ABA1E1 VA: 0x3ABA0E0
	|-ReadOnlyCollection<ushort>.System.Collections.IList.Insert
	|
	|-RVA: 0x3ABB0C0 Offset: 0x3ABB1C1 VA: 0x3ABB0C0
	|-ReadOnlyCollection<uint>.System.Collections.IList.Insert
	|
	|-RVA: 0x3ABC0A0 Offset: 0x3ABC1A1 VA: 0x3ABC0A0
	|-ReadOnlyCollection<ulong>.System.Collections.IList.Insert
	|
	|-RVA: 0x3ABD0A0 Offset: 0x3ABD1A1 VA: 0x3ABD0A0
	|-ReadOnlyCollection<Vector2>.System.Collections.IList.Insert
	|
	|-RVA: 0x3ABE0C0 Offset: 0x3ABE1C1 VA: 0x3ABE0C0
	|-ReadOnlyCollection<Vector3>.System.Collections.IList.Insert
	|
	|-RVA: 0x3ABF0E0 Offset: 0x3ABF1E1 VA: 0x3ABF0E0
	|-ReadOnlyCollection<Vector4>.System.Collections.IList.Insert
	|
	|-RVA: 0x3AC00D0 Offset: 0x3AC01D1 VA: 0x3AC00D0
	|-ReadOnlyCollection<VertexAttributeDescriptor>.System.Collections.IList.Insert
	|
	|-RVA: 0x3AC10C0 Offset: 0x3AC11C1 VA: 0x3AC10C0
	|-ReadOnlyCollection<X509ChainStatus>.System.Collections.IList.Insert
	|
	|-RVA: 0x3AC21E0 Offset: 0x3AC22E1 VA: 0x3AC21E0
	|-ReadOnlyCollection<XRView>.System.Collections.IList.Insert
	|
	|-RVA: 0x3AC3210 Offset: 0x3AC3311 VA: 0x3AC3210
	|-ReadOnlyCollection<AICrossfire.PositionTable>.System.Collections.IList.Insert
	|
	|-RVA: 0x3AC4200 Offset: 0x3AC4301 VA: 0x3AC4200
	|-ReadOnlyCollection<AmiiboSequence.GainItemData>.System.Collections.IList.Insert
	|
	|-RVA: 0x3AC5320 Offset: 0x3AC5421 VA: 0x3AC5320
	|-ReadOnlyCollection<AnimationOutputWeightProcessor.WeightInfo>.System.Collections.IList.Insert
	|
	|-RVA: 0x3AC6310 Offset: 0x3AC6411 VA: 0x3AC6310
	|-ReadOnlyCollection<ArenaOrderSequence.GodInfo>.System.Collections.IList.Insert
	|
	|-RVA: 0x3AC7300 Offset: 0x3AC7401 VA: 0x3AC7300
	|-ReadOnlyCollection<BattleInfo.SupportData>.System.Collections.IList.Insert
	|
	|-RVA: 0x3AC82F0 Offset: 0x3AC83F1 VA: 0x3AC82F0
	|-ReadOnlyCollection<BeforeRenderHelper.OrderBlock>.System.Collections.IList.Insert
	|
	|-RVA: 0x3AC93B0 Offset: 0x3AC94B1 VA: 0x3AC93B0
	|-ReadOnlyCollection<Camera.RenderRequest>.System.Collections.IList.Insert
	|
	|-RVA: 0x3ACA3A0 Offset: 0x3ACA4A1 VA: 0x3ACA3A0
	|-ReadOnlyCollection<CameraState.CustomBlendable>.System.Collections.IList.Insert
	|
	|-RVA: 0x3ACB380 Offset: 0x3ACB481 VA: 0x3ACB380
	|-ReadOnlyCollection<CinemachineClearShot.Pair>.System.Collections.IList.Insert
	|
	|-RVA: 0x3ACC360 Offset: 0x3ACC461 VA: 0x3ACC360
	|-ReadOnlyCollection<CinemachineStateDrivenCamera.HashPair>.System.Collections.IList.Insert
	|
	|-RVA: 0x3ACD420 Offset: 0x3ACD521 VA: 0x3ACD420
	|-ReadOnlyCollection<DelayedActionManager.DelegateInfo>.System.Collections.IList.Insert
	|
	|-RVA: 0x3ACE550 Offset: 0x3ACE651 VA: 0x3ACE550
	|-ReadOnlyCollection<Detail.AsyncResultInt>.System.Collections.IList.Insert
	|
	|-RVA: 0x3ACF540 Offset: 0x3ACF641 VA: 0x3ACF540
	|-ReadOnlyCollection<Detail.CppArray>.System.Collections.IList.Insert
	|
	|-RVA: 0x3AD0670 Offset: 0x3AD0771 VA: 0x3AD0670
	|-ReadOnlyCollection<Detail.NotificationEventInt>.System.Collections.IList.Insert
	|
	|-RVA: 0x3AD1660 Offset: 0x3AD1761 VA: 0x3AD1660
	|-ReadOnlyCollection<DragonRideTargetGroup.ChainParam>.System.Collections.IList.Insert
	|
	|-RVA: 0x3AD2720 Offset: 0x3AD2821 VA: 0x3AD2720
	|-ReadOnlyCollection<GmapPathAdjuster.TargetModel>.System.Collections.IList.Insert
	|
	|-RVA: 0x3AD37E0 Offset: 0x3AD38E1 VA: 0x3AD37E0
	|-ReadOnlyCollection<GmapSpotAdjuster.TargetModel>.System.Collections.IList.Insert
	|
	|-RVA: 0x3AD48A0 Offset: 0x3AD49A1 VA: 0x3AD48A0
	|-ReadOnlyCollection<HubFastTravel.Location>.System.Collections.IList.Insert
	|
	|-RVA: 0x3AD59D0 Offset: 0x3AD5AD1 VA: 0x3AD59D0
	|-ReadOnlyCollection<HubLensFlare.Flare>.System.Collections.IList.Insert
	|
	|-RVA: 0x3AD69C0 Offset: 0x3AD6AC1 VA: 0x3AD69C0
	|-ReadOnlyCollection<InventoryPoolItemMenuContent.KindBgNameClass>.System.Collections.IList.Insert
	|
	|-RVA: 0x3AD79A0 Offset: 0x3AD7AA1 VA: 0x3AD79A0
	|-ReadOnlyCollection<Map.Pos>.System.Collections.IList.Insert
	|
	|-RVA: 0x3AD8990 Offset: 0x3AD8A91 VA: 0x3AD8990
	|-ReadOnlyCollection<MapImage.BackupTerrain>.System.Collections.IList.Insert
	|
	|-RVA: 0x3AD99B0 Offset: 0x3AD9AB1 VA: 0x3AD99B0
	|-ReadOnlyCollection<MapImageRange.Pos>.System.Collections.IList.Insert
	|
	|-RVA: 0x3ADAA70 Offset: 0x3ADAB71 VA: 0x3ADAA70
	|-ReadOnlyCollection<MapMind.Target>.System.Collections.IList.Insert
	|
	|-RVA: 0x38C5450 Offset: 0x38C5551 VA: 0x38C5450
	|-ReadOnlyCollection<MapPanelDebug.Entity>.System.Collections.IList.Insert
	|
	|-RVA: 0x38C6430 Offset: 0x38C6531 VA: 0x38C6430
	|-ReadOnlyCollection<NexRanking.Data>.System.Collections.IList.Insert
	|
	|-RVA: 0x38C7420 Offset: 0x38C7521 VA: 0x38C7420
	|-ReadOnlyCollection<NexVersus.RatingData>.System.Collections.IList.Insert
	|
	|-RVA: 0x38C8410 Offset: 0x38C8511 VA: 0x38C8410
	|-ReadOnlyCollection<PackedPlayModeBuildLogs.RuntimeBuildLog>.System.Collections.IList.Insert
	|
	|-RVA: 0x38C9530 Offset: 0x38C9631 VA: 0x38C9530
	|-ReadOnlyCollection<ParticleSystem.Particle>.System.Collections.IList.Insert
	|
	|-RVA: 0x38CA510 Offset: 0x38CA611 VA: 0x38CA510
	|-ReadOnlyCollection<RangeData.Offset>.System.Collections.IList.Insert
	|
	|-RVA: 0x38CB5D0 Offset: 0x38CB6D1 VA: 0x38CB5D0
	|-ReadOnlyCollection<RenderGraphDebugData.PassDebugData>.System.Collections.IList.Insert
	|
	|-RVA: 0x38CC6F0 Offset: 0x38CC7F1 VA: 0x38CC6F0
	|-ReadOnlyCollection<RenderGraphDebugData.ResourceDebugData>.System.Collections.IList.Insert
	|
	|-RVA: 0x38CD6E0 Offset: 0x38CD7E1 VA: 0x38CD6E0
	|-ReadOnlyCollection<RingCleaningUnitSelectMenu.GodParam>.System.Collections.IList.Insert
	|
	|-RVA: 0x38CE810 Offset: 0x38CE911 VA: 0x38CE810
	|-ReadOnlyCollection<ShadowUtility.Edge>.System.Collections.IList.Insert
	|
	|-RVA: 0x38CF830 Offset: 0x38CF931 VA: 0x38CF830
	|-ReadOnlyCollection<SkillArray.Entity>.System.Collections.IList.Insert
	|
	|-RVA: 0x38D09C0 Offset: 0x38D0AC1 VA: 0x38D09C0
	|-ReadOnlyCollection<TexturePacker_JsonArray.Frame>.System.Collections.IList.Insert
	|
	|-RVA: 0x38D1A80 Offset: 0x38D1B81 VA: 0x38D1A80
	|-ReadOnlyCollection<TimeNotificationBehaviour.NotificationEntry>.System.Collections.IList.Insert
	|
	|-RVA: 0x38D2B40 Offset: 0x38D2C41 VA: 0x38D2B40
	|-ReadOnlyCollection<UnitySynchronizationContext.WorkRequest>.System.Collections.IList.Insert
	|
	|-RVA: 0x38D3B30 Offset: 0x38D3C31 VA: 0x38D3B30
	|-ReadOnlyCollection<XmlSchemaObjectTable.XmlSchemaObjectEntry>.System.Collections.IList.Insert
	|
	|-RVA: 0x38D4B20 Offset: 0x38D4C21 VA: 0x38D4B20
	|-ReadOnlyCollection<AssetBundleBuildMap.AssetBundleEntry.AssetPathString>.System.Collections.IList.Insert
	|
	|-RVA: 0x38D5C60 Offset: 0x38D5D61 VA: 0x38D5C60
	|-ReadOnlyCollection<Detail.DataStore.DataStoreChangeMetaParamInt>.System.Collections.IList.Insert
	|
	|-RVA: 0x38D6C50 Offset: 0x38D6D51 VA: 0x38D6C50
	|-ReadOnlyCollection<Detail.DataStore.DataStoreDeleteParamInt>.System.Collections.IList.Insert
	|
	|-RVA: 0x38D7D70 Offset: 0x38D7E71 VA: 0x38D7D70
	|-ReadOnlyCollection<Detail.DataStore.DataStoreGetMetaParamInt>.System.Collections.IList.Insert
	|
	|-RVA: 0x38D8E90 Offset: 0x38D8F91 VA: 0x38D8E90
	|-ReadOnlyCollection<Detail.DataStore.DataStoreMetaInfoInt>.System.Collections.IList.Insert
	|
	|-RVA: 0x38D9F50 Offset: 0x38DA051 VA: 0x38D9F50
	|-ReadOnlyCollection<Detail.DataStore.DataStorePasswordInfoInt>.System.Collections.IList.Insert
	|
	|-RVA: 0x38DB010 Offset: 0x38DB111 VA: 0x38DB010
	|-ReadOnlyCollection<Detail.DataStore.DataStorePersistenceInfoInt>.System.Collections.IList.Insert
	|
	|-RVA: 0x38DC130 Offset: 0x38DC231 VA: 0x38DC130
	|-ReadOnlyCollection<Detail.DataStore.DataStorePreparePostParamInt>.System.Collections.IList.Insert
	|
	|-RVA: 0x38DD120 Offset: 0x38DD221 VA: 0x38DD120
	|-ReadOnlyCollection<Detail.DataStore.DataStoreRateObjectParamInt>.System.Collections.IList.Insert
	|
	|-RVA: 0x38DE1E0 Offset: 0x38DE2E1 VA: 0x38DE1E0
	|-ReadOnlyCollection<Detail.DataStore.DataStoreRatingInitParamInt>.System.Collections.IList.Insert
	|
	|-RVA: 0x38DF1D0 Offset: 0x38DF2D1 VA: 0x38DF1D0
	|-ReadOnlyCollection<Detail.DataStore.DataStoreRatingTargetInt>.System.Collections.IList.Insert
	|
	|-RVA: 0x38E0360 Offset: 0x38E0461 VA: 0x38E0360
	|-ReadOnlyCollection<Detail.Ranking.RankingCachedResultInt>.System.Collections.IList.Insert
	|
	|-RVA: 0x38E1350 Offset: 0x38E1451 VA: 0x38E1350
	|-ReadOnlyCollection<Detail.Ranking.RankingOrderParamInt>.System.Collections.IList.Insert
	|
	|-RVA: 0x38E24E0 Offset: 0x38E25E1 VA: 0x38E24E0
	|-ReadOnlyCollection<Detail.Ranking.RankingRankDataInt>.System.Collections.IList.Insert
	|
	|-RVA: 0x38E37F0 Offset: 0x38E38F1 VA: 0x38E37F0
	|-ReadOnlyCollection<Detail.Ranking2.Ranking2ChartInfoInt>.System.Collections.IList.Insert
	|
	|-RVA: 0x38E4980 Offset: 0x38E4A81 VA: 0x38E4980
	|-ReadOnlyCollection<Detail.Ranking2.Ranking2RankDataInt>.System.Collections.IList.Insert
	|
	|-RVA: 0x38E5970 Offset: 0x38E5A71 VA: 0x38E5970
	|-ReadOnlyCollection<Detail.Ranking2.Ranking2ScoreDataInt>.System.Collections.IList.Insert
	|
	|-RVA: 0x38E6A30 Offset: 0x38E6B31 VA: 0x38E6A30
	|-ReadOnlyCollection<Detail.Screening.ScreeningContextInfoInt>.System.Collections.IList.Insert
	|
	|-RVA: 0x38E7C80 Offset: 0x38E7D81 VA: 0x38E7C80
	|-ReadOnlyCollection<Detail.Subscriber.SubscriberContentInt>.System.Collections.IList.Insert
	|
	|-RVA: 0x38E8D40 Offset: 0x38E8E41 VA: 0x38E8D40
	|-ReadOnlyCollection<Detail.Subscriber.SubscriberGetContentParamInt>.System.Collections.IList.Insert
	|
	|-RVA: 0x38E9E60 Offset: 0x38E9F61 VA: 0x38E9E60
	|-ReadOnlyCollection<Detail.Subscriber.SubscriberUserStatusInfoInt>.System.Collections.IList.Insert
	|
	|-RVA: 0x38EAF20 Offset: 0x38EB021 VA: 0x38EAF20
	|-ReadOnlyCollection<Detail.Subscriber.SubscriberUserStatusParamInt>.System.Collections.IList.Insert
	|
	|-RVA: 0x38EBF00 Offset: 0x38EC001 VA: 0x38EBF00
	|-ReadOnlyCollection<Detail.Utility.IntegerSettings>.System.Collections.IList.Insert
	|
	|-RVA: 0x38ECEF0 Offset: 0x38ECFF1 VA: 0x38ECEF0
	|-ReadOnlyCollection<Detail.Utility.UniqueIdInfoInt>.System.Collections.IList.Insert
	|
	|-RVA: 0x38EDF20 Offset: 0x38EE021 VA: 0x38EDF20
	|-ReadOnlyCollection<MapHistory.Rewind.LatestInspectorData>.System.Collections.IList.Insert
	|
	|-RVA: 0x38EEF50 Offset: 0x38EF051 VA: 0x38EEF50
	|-ReadOnlyCollection<MapHistory.Rewind.WorkTerrainData>.System.Collections.IList.Insert
	|
	|-RVA: 0x38EFF40 Offset: 0x38F0041 VA: 0x38EFF40
	|-ReadOnlyCollection<MapSkill.AroundCalculator.Result>.System.Collections.IList.Insert
	|
	|-RVA: 0x38F1070 Offset: 0x38F1171 VA: 0x38F1070
	|-ReadOnlyCollection<TargetPositionCache.CacheCurve.Item>.System.Collections.IList.Insert
	|
	|-RVA: 0x2FE6620 Offset: 0x2FE6721 VA: 0x2FE6620
	|-ReadOnlyCollection<TargetPositionCache.CacheEntry.RecordingItem>.System.Collections.IList.Insert
	*/

	// RVA: -1 Offset: -1 Slot: 26
	private void System.Collections.IList.Remove(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3468420 Offset: 0x3468521 VA: 0x3468420
	|-ReadOnlyCollection<IntervalTree.Entry<object>>.System.Collections.IList.Remove
	|
	|-RVA: 0x3469410 Offset: 0x3469511 VA: 0x3469410
	|-ReadOnlyCollection<KeyValuePair<DateTime, object>>.System.Collections.IList.Remove
	|
	|-RVA: 0x346A400 Offset: 0x346A501 VA: 0x346A400
	|-ReadOnlyCollection<KeyValuePair<int, object>>.System.Collections.IList.Remove
	|
	|-RVA: 0x346B4C0 Offset: 0x346B5C1 VA: 0x346B4C0
	|-ReadOnlyCollection<KeyValuePair<object, ValueTuple<int, DateTime, object>>>.System.Collections.IList.Remove
	|
	|-RVA: 0x346C4B0 Offset: 0x346C5B1 VA: 0x346C4B0
	|-ReadOnlyCollection<KeyValuePair<object, object>>.System.Collections.IList.Remove
	|
	|-RVA: 0x346D570 Offset: 0x346D671 VA: 0x346D570
	|-ReadOnlyCollection<CommonBattleSequence.Reliance<object>>.System.Collections.IList.Remove
	|
	|-RVA: 0x346E560 Offset: 0x346E661 VA: 0x346E560
	|-ReadOnlyCollection<RenderGraphResourcePool.ResourceLogInfo<object>>.System.Collections.IList.Remove
	|
	|-RVA: 0x346F550 Offset: 0x346F651 VA: 0x346F550
	|-ReadOnlyCollection<ValueTuple<int, object>>.System.Collections.IList.Remove
	|
	|-RVA: 0x3470530 Offset: 0x3470631 VA: 0x3470530
	|-ReadOnlyCollection<ValueTuple<Int32Enum, int>>.System.Collections.IList.Remove
	|
	|-RVA: 0x34715F0 Offset: 0x34716F1 VA: 0x34715F0
	|-ReadOnlyCollection<ValueTuple<object, ValueTuple<object, int>>>.System.Collections.IList.Remove
	|
	|-RVA: 0x34725E0 Offset: 0x34726E1 VA: 0x34725E0
	|-ReadOnlyCollection<ValueTuple<object, int>>.System.Collections.IList.Remove
	|
	|-RVA: 0x3473600 Offset: 0x3473701 VA: 0x3473600
	|-ReadOnlyCollection<ValueTuple<Vector3, float>>.System.Collections.IList.Remove
	|
	|-RVA: 0x34745F0 Offset: 0x34746F1 VA: 0x34745F0
	|-ReadOnlyCollection<ValueTuple<object, Int32Enum, int>>.System.Collections.IList.Remove
	|
	|-RVA: 0x34756B0 Offset: 0x34757B1 VA: 0x34756B0
	|-ReadOnlyCollection<ValueTuple<object, int, int, int>>.System.Collections.IList.Remove
	|
	|-RVA: 0x3476690 Offset: 0x3476791 VA: 0x3476690
	|-ReadOnlyCollection<AnimatorClipInfo>.System.Collections.IList.Remove
	|
	|-RVA: 0x3B234F0 Offset: 0x3B235F1 VA: 0x3B234F0
	|-ReadOnlyCollection<AsyncOperationHandle>.System.Collections.IList.Remove
	|
	|-RVA: 0x3B245B0 Offset: 0x3B246B1 VA: 0x3B245B0
	|-ReadOnlyCollection<BoneWeight>.System.Collections.IList.Remove
	|
	|-RVA: 0x3B255A0 Offset: 0x3B256A1 VA: 0x3B255A0
	|-ReadOnlyCollection<bool>.System.Collections.IList.Remove
	|
	|-RVA: 0x3B26580 Offset: 0x3B26681 VA: 0x3B26580
	|-ReadOnlyCollection<byte>.System.Collections.IList.Remove
	|
	|-RVA: 0x3B27570 Offset: 0x3B27671 VA: 0x3B27570
	|-ReadOnlyCollection<CameraInfo>.System.Collections.IList.Remove
	|
	|-RVA: 0x3B28550 Offset: 0x3B28651 VA: 0x3B28550
	|-ReadOnlyCollection<char>.System.Collections.IList.Remove
	|
	|-RVA: 0x3B29570 Offset: 0x3B29671 VA: 0x3B29570
	|-ReadOnlyCollection<Color>.System.Collections.IList.Remove
	|
	|-RVA: 0x3B2A590 Offset: 0x3B2A691 VA: 0x3B2A590
	|-ReadOnlyCollection<Color32>.System.Collections.IList.Remove
	|
	|-RVA: 0x3B2B580 Offset: 0x3B2B681 VA: 0x3B2B580
	|-ReadOnlyCollection<ConstraintSource>.System.Collections.IList.Remove
	|
	|-RVA: 0x3B2C640 Offset: 0x3B2C741 VA: 0x3B2C640
	|-ReadOnlyCollection<ContourVertex>.System.Collections.IList.Remove
	|
	|-RVA: 0x3B2D700 Offset: 0x3B2D801 VA: 0x3B2D700
	|-ReadOnlyCollection<CustomAttributeNamedArgument>.System.Collections.IList.Remove
	|
	|-RVA: 0x3B2E6F0 Offset: 0x3B2E7F1 VA: 0x3B2E6F0
	|-ReadOnlyCollection<CustomAttributeTypedArgument>.System.Collections.IList.Remove
	|
	|-RVA: 0x3B2F7B0 Offset: 0x3B2F8B1 VA: 0x3B2F7B0
	|-ReadOnlyCollection<DataStoreRatingInfo>.System.Collections.IList.Remove
	|
	|-RVA: 0x3B30790 Offset: 0x3B30891 VA: 0x3B30790
	|-ReadOnlyCollection<DataStoreResult>.System.Collections.IList.Remove
	|
	|-RVA: 0x3B31770 Offset: 0x3B31871 VA: 0x3B31770
	|-ReadOnlyCollection<DateTime>.System.Collections.IList.Remove
	|
	|-RVA: 0x3B32760 Offset: 0x3B32861 VA: 0x3B32760
	|-ReadOnlyCollection<DateTimeOffset>.System.Collections.IList.Remove
	|
	|-RVA: 0x3B33750 Offset: 0x3B33851 VA: 0x3B33750
	|-ReadOnlyCollection<Decimal>.System.Collections.IList.Remove
	|
	|-RVA: 0x3B34880 Offset: 0x3B34981 VA: 0x3B34880
	|-ReadOnlyCollection<DiagnosticEvent>.System.Collections.IList.Remove
	|
	|-RVA: 0x3B35860 Offset: 0x3B35961 VA: 0x3B35860
	|-ReadOnlyCollection<double>.System.Collections.IList.Remove
	|
	|-RVA: 0x3B36990 Offset: 0x3B36A91 VA: 0x3B36990
	|-ReadOnlyCollection<Friend>.System.Collections.IList.Remove
	|
	|-RVA: 0x3B37980 Offset: 0x3B37A81 VA: 0x3B37980
	|-ReadOnlyCollection<GlyphRect>.System.Collections.IList.Remove
	|
	|-RVA: 0x3B38960 Offset: 0x3B38A61 VA: 0x3B38960
	|-ReadOnlyCollection<short>.System.Collections.IList.Remove
	|
	|-RVA: 0x3B39940 Offset: 0x3B39A41 VA: 0x3B39940
	|-ReadOnlyCollection<int>.System.Collections.IList.Remove
	|
	|-RVA: 0x3B3A920 Offset: 0x3B3AA21 VA: 0x3B3A920
	|-ReadOnlyCollection<Int32Enum>.System.Collections.IList.Remove
	|
	|-RVA: 0x3B3B900 Offset: 0x3B3BA01 VA: 0x3B3B900
	|-ReadOnlyCollection<long>.System.Collections.IList.Remove
	|
	|-RVA: 0x3B3C8E0 Offset: 0x3B3C9E1 VA: 0x3B3C8E0
	|-ReadOnlyCollection<IntPtr>.System.Collections.IList.Remove
	|
	|-RVA: 0x3B3D8D0 Offset: 0x3B3D9D1 VA: 0x3B3D8D0
	|-ReadOnlyCollection<InterpretedFrameInfo>.System.Collections.IList.Remove
	|
	|-RVA: 0x3B3E990 Offset: 0x3B3EA91 VA: 0x3B3E990
	|-ReadOnlyCollection<IntervalTreeNode>.System.Collections.IList.Remove
	|
	|-RVA: 0x3B3F970 Offset: 0x3B3FA71 VA: 0x3B3F970
	|-ReadOnlyCollection<LengthLimitProperties>.System.Collections.IList.Remove
	|
	|-RVA: 0x3B40950 Offset: 0x3B40A51 VA: 0x3B40950
	|-ReadOnlyCollection<MapPos>.System.Collections.IList.Remove
	|
	|-RVA: 0x3B41AE0 Offset: 0x3B41BE1 VA: 0x3B41AE0
	|-ReadOnlyCollection<Matrix4x4>.System.Collections.IList.Remove
	|
	|-RVA: 0x3B429D0 Offset: 0x3B42AD1 VA: 0x3B429D0
	|-ReadOnlyCollection<object>.System.Collections.IList.Remove
	|
	|-RVA: 0x3B43B00 Offset: 0x3B43C01 VA: 0x3B43B00
	|-ReadOnlyCollection<ObjectInitializationData>.System.Collections.IList.Remove
	|
	|-RVA: 0x3B44BC0 Offset: 0x3B44CC1 VA: 0x3B44BC0
	|-ReadOnlyCollection<PlayableBinding>.System.Collections.IList.Remove
	|
	|-RVA: 0x3B45CE0 Offset: 0x3B45DE1 VA: 0x3B45CE0
	|-ReadOnlyCollection<PlayerLoopSystem>.System.Collections.IList.Remove
	|
	|-RVA: 0x3B46E00 Offset: 0x3B46F01 VA: 0x3B46E00
	|-ReadOnlyCollection<PlayerLoopSystemInternal>.System.Collections.IList.Remove
	|
	|-RVA: 0x3B47DF0 Offset: 0x3B47EF1 VA: 0x3B47DF0
	|-ReadOnlyCollection<RangePositionInfo>.System.Collections.IList.Remove
	|
	|-RVA: 0x3B48DD0 Offset: 0x3B48ED1 VA: 0x3B48DD0
	|-ReadOnlyCollection<Ranking2ChartInfoInput>.System.Collections.IList.Remove
	|
	|-RVA: 0x3B49F30 Offset: 0x3B4A031 VA: 0x3B49F30
	|-ReadOnlyCollection<RaycastHit2D>.System.Collections.IList.Remove
	|
	|-RVA: 0x3B4B180 Offset: 0x3B4B281 VA: 0x3B4B180
	|-ReadOnlyCollection<RaycastResult>.System.Collections.IList.Remove
	|
	|-RVA: 0x3B4C1A0 Offset: 0x3B4C2A1 VA: 0x3B4C1A0
	|-ReadOnlyCollection<Rect>.System.Collections.IList.Remove
	|
	|-RVA: 0x3B4D180 Offset: 0x3B4D281 VA: 0x3B4D180
	|-ReadOnlyCollection<RendererListHandle>.System.Collections.IList.Remove
	|
	|-RVA: 0x3B4E160 Offset: 0x3B4E261 VA: 0x3B4E160
	|-ReadOnlyCollection<ResourceHandle>.System.Collections.IList.Remove
	|
	|-RVA: 0x3AAF820 Offset: 0x3AAF921 VA: 0x3AAF820
	|-ReadOnlyCollection<sbyte>.System.Collections.IList.Remove
	|
	|-RVA: 0x3AB0840 Offset: 0x3AB0941 VA: 0x3AB0840
	|-ReadOnlyCollection<ShaderTagId>.System.Collections.IList.Remove
	|
	|-RVA: 0x3AB1820 Offset: 0x3AB1921 VA: 0x3AB1820
	|-ReadOnlyCollection<float>.System.Collections.IList.Remove
	|
	|-RVA: 0x3AB2C10 Offset: 0x3AB2D11 VA: 0x3AB2C10
	|-ReadOnlyCollection<SphericalHarmonicsL2>.System.Collections.IList.Remove
	|
	|-RVA: 0x3AB3D40 Offset: 0x3AB3E41 VA: 0x3AB3D40
	|-ReadOnlyCollection<SubMeshDescriptor>.System.Collections.IList.Remove
	|
	|-RVA: 0x3AB4D30 Offset: 0x3AB4E31 VA: 0x3AB4D30
	|-ReadOnlyCollection<TablePair>.System.Collections.IList.Remove
	|
	|-RVA: 0x3AB5D10 Offset: 0x3AB5E11 VA: 0x3AB5D10
	|-ReadOnlyCollection<TimeSpan>.System.Collections.IList.Remove
	|
	|-RVA: 0x3AB6D30 Offset: 0x3AB6E31 VA: 0x3AB6D30
	|-ReadOnlyCollection<UICharInfo>.System.Collections.IList.Remove
	|
	|-RVA: 0x3AB7D20 Offset: 0x3AB7E21 VA: 0x3AB7D20
	|-ReadOnlyCollection<UILineInfo>.System.Collections.IList.Remove
	|
	|-RVA: 0x3AB9110 Offset: 0x3AB9211 VA: 0x3AB9110
	|-ReadOnlyCollection<UIVertex>.System.Collections.IList.Remove
	|
	|-RVA: 0x3ABA0F0 Offset: 0x3ABA1F1 VA: 0x3ABA0F0
	|-ReadOnlyCollection<ushort>.System.Collections.IList.Remove
	|
	|-RVA: 0x3ABB0D0 Offset: 0x3ABB1D1 VA: 0x3ABB0D0
	|-ReadOnlyCollection<uint>.System.Collections.IList.Remove
	|
	|-RVA: 0x3ABC0B0 Offset: 0x3ABC1B1 VA: 0x3ABC0B0
	|-ReadOnlyCollection<ulong>.System.Collections.IList.Remove
	|
	|-RVA: 0x3ABD0B0 Offset: 0x3ABD1B1 VA: 0x3ABD0B0
	|-ReadOnlyCollection<Vector2>.System.Collections.IList.Remove
	|
	|-RVA: 0x3ABE0D0 Offset: 0x3ABE1D1 VA: 0x3ABE0D0
	|-ReadOnlyCollection<Vector3>.System.Collections.IList.Remove
	|
	|-RVA: 0x3ABF0F0 Offset: 0x3ABF1F1 VA: 0x3ABF0F0
	|-ReadOnlyCollection<Vector4>.System.Collections.IList.Remove
	|
	|-RVA: 0x3AC00E0 Offset: 0x3AC01E1 VA: 0x3AC00E0
	|-ReadOnlyCollection<VertexAttributeDescriptor>.System.Collections.IList.Remove
	|
	|-RVA: 0x3AC10D0 Offset: 0x3AC11D1 VA: 0x3AC10D0
	|-ReadOnlyCollection<X509ChainStatus>.System.Collections.IList.Remove
	|
	|-RVA: 0x3AC21F0 Offset: 0x3AC22F1 VA: 0x3AC21F0
	|-ReadOnlyCollection<XRView>.System.Collections.IList.Remove
	|
	|-RVA: 0x3AC3220 Offset: 0x3AC3321 VA: 0x3AC3220
	|-ReadOnlyCollection<AICrossfire.PositionTable>.System.Collections.IList.Remove
	|
	|-RVA: 0x3AC4210 Offset: 0x3AC4311 VA: 0x3AC4210
	|-ReadOnlyCollection<AmiiboSequence.GainItemData>.System.Collections.IList.Remove
	|
	|-RVA: 0x3AC5330 Offset: 0x3AC5431 VA: 0x3AC5330
	|-ReadOnlyCollection<AnimationOutputWeightProcessor.WeightInfo>.System.Collections.IList.Remove
	|
	|-RVA: 0x3AC6320 Offset: 0x3AC6421 VA: 0x3AC6320
	|-ReadOnlyCollection<ArenaOrderSequence.GodInfo>.System.Collections.IList.Remove
	|
	|-RVA: 0x3AC7310 Offset: 0x3AC7411 VA: 0x3AC7310
	|-ReadOnlyCollection<BattleInfo.SupportData>.System.Collections.IList.Remove
	|
	|-RVA: 0x3AC8300 Offset: 0x3AC8401 VA: 0x3AC8300
	|-ReadOnlyCollection<BeforeRenderHelper.OrderBlock>.System.Collections.IList.Remove
	|
	|-RVA: 0x3AC93C0 Offset: 0x3AC94C1 VA: 0x3AC93C0
	|-ReadOnlyCollection<Camera.RenderRequest>.System.Collections.IList.Remove
	|
	|-RVA: 0x3ACA3B0 Offset: 0x3ACA4B1 VA: 0x3ACA3B0
	|-ReadOnlyCollection<CameraState.CustomBlendable>.System.Collections.IList.Remove
	|
	|-RVA: 0x3ACB390 Offset: 0x3ACB491 VA: 0x3ACB390
	|-ReadOnlyCollection<CinemachineClearShot.Pair>.System.Collections.IList.Remove
	|
	|-RVA: 0x3ACC370 Offset: 0x3ACC471 VA: 0x3ACC370
	|-ReadOnlyCollection<CinemachineStateDrivenCamera.HashPair>.System.Collections.IList.Remove
	|
	|-RVA: 0x3ACD430 Offset: 0x3ACD531 VA: 0x3ACD430
	|-ReadOnlyCollection<DelayedActionManager.DelegateInfo>.System.Collections.IList.Remove
	|
	|-RVA: 0x3ACE560 Offset: 0x3ACE661 VA: 0x3ACE560
	|-ReadOnlyCollection<Detail.AsyncResultInt>.System.Collections.IList.Remove
	|
	|-RVA: 0x3ACF550 Offset: 0x3ACF651 VA: 0x3ACF550
	|-ReadOnlyCollection<Detail.CppArray>.System.Collections.IList.Remove
	|
	|-RVA: 0x3AD0680 Offset: 0x3AD0781 VA: 0x3AD0680
	|-ReadOnlyCollection<Detail.NotificationEventInt>.System.Collections.IList.Remove
	|
	|-RVA: 0x3AD1670 Offset: 0x3AD1771 VA: 0x3AD1670
	|-ReadOnlyCollection<DragonRideTargetGroup.ChainParam>.System.Collections.IList.Remove
	|
	|-RVA: 0x3AD2730 Offset: 0x3AD2831 VA: 0x3AD2730
	|-ReadOnlyCollection<GmapPathAdjuster.TargetModel>.System.Collections.IList.Remove
	|
	|-RVA: 0x3AD37F0 Offset: 0x3AD38F1 VA: 0x3AD37F0
	|-ReadOnlyCollection<GmapSpotAdjuster.TargetModel>.System.Collections.IList.Remove
	|
	|-RVA: 0x3AD48B0 Offset: 0x3AD49B1 VA: 0x3AD48B0
	|-ReadOnlyCollection<HubFastTravel.Location>.System.Collections.IList.Remove
	|
	|-RVA: 0x3AD59E0 Offset: 0x3AD5AE1 VA: 0x3AD59E0
	|-ReadOnlyCollection<HubLensFlare.Flare>.System.Collections.IList.Remove
	|
	|-RVA: 0x3AD69D0 Offset: 0x3AD6AD1 VA: 0x3AD69D0
	|-ReadOnlyCollection<InventoryPoolItemMenuContent.KindBgNameClass>.System.Collections.IList.Remove
	|
	|-RVA: 0x3AD79B0 Offset: 0x3AD7AB1 VA: 0x3AD79B0
	|-ReadOnlyCollection<Map.Pos>.System.Collections.IList.Remove
	|
	|-RVA: 0x3AD89A0 Offset: 0x3AD8AA1 VA: 0x3AD89A0
	|-ReadOnlyCollection<MapImage.BackupTerrain>.System.Collections.IList.Remove
	|
	|-RVA: 0x3AD99C0 Offset: 0x3AD9AC1 VA: 0x3AD99C0
	|-ReadOnlyCollection<MapImageRange.Pos>.System.Collections.IList.Remove
	|
	|-RVA: 0x3ADAA80 Offset: 0x3ADAB81 VA: 0x3ADAA80
	|-ReadOnlyCollection<MapMind.Target>.System.Collections.IList.Remove
	|
	|-RVA: 0x38C5460 Offset: 0x38C5561 VA: 0x38C5460
	|-ReadOnlyCollection<MapPanelDebug.Entity>.System.Collections.IList.Remove
	|
	|-RVA: 0x38C6440 Offset: 0x38C6541 VA: 0x38C6440
	|-ReadOnlyCollection<NexRanking.Data>.System.Collections.IList.Remove
	|
	|-RVA: 0x38C7430 Offset: 0x38C7531 VA: 0x38C7430
	|-ReadOnlyCollection<NexVersus.RatingData>.System.Collections.IList.Remove
	|
	|-RVA: 0x38C8420 Offset: 0x38C8521 VA: 0x38C8420
	|-ReadOnlyCollection<PackedPlayModeBuildLogs.RuntimeBuildLog>.System.Collections.IList.Remove
	|
	|-RVA: 0x38C9540 Offset: 0x38C9641 VA: 0x38C9540
	|-ReadOnlyCollection<ParticleSystem.Particle>.System.Collections.IList.Remove
	|
	|-RVA: 0x38CA520 Offset: 0x38CA621 VA: 0x38CA520
	|-ReadOnlyCollection<RangeData.Offset>.System.Collections.IList.Remove
	|
	|-RVA: 0x38CB5E0 Offset: 0x38CB6E1 VA: 0x38CB5E0
	|-ReadOnlyCollection<RenderGraphDebugData.PassDebugData>.System.Collections.IList.Remove
	|
	|-RVA: 0x38CC700 Offset: 0x38CC801 VA: 0x38CC700
	|-ReadOnlyCollection<RenderGraphDebugData.ResourceDebugData>.System.Collections.IList.Remove
	|
	|-RVA: 0x38CD6F0 Offset: 0x38CD7F1 VA: 0x38CD6F0
	|-ReadOnlyCollection<RingCleaningUnitSelectMenu.GodParam>.System.Collections.IList.Remove
	|
	|-RVA: 0x38CE820 Offset: 0x38CE921 VA: 0x38CE820
	|-ReadOnlyCollection<ShadowUtility.Edge>.System.Collections.IList.Remove
	|
	|-RVA: 0x38CF840 Offset: 0x38CF941 VA: 0x38CF840
	|-ReadOnlyCollection<SkillArray.Entity>.System.Collections.IList.Remove
	|
	|-RVA: 0x38D09D0 Offset: 0x38D0AD1 VA: 0x38D09D0
	|-ReadOnlyCollection<TexturePacker_JsonArray.Frame>.System.Collections.IList.Remove
	|
	|-RVA: 0x38D1A90 Offset: 0x38D1B91 VA: 0x38D1A90
	|-ReadOnlyCollection<TimeNotificationBehaviour.NotificationEntry>.System.Collections.IList.Remove
	|
	|-RVA: 0x38D2B50 Offset: 0x38D2C51 VA: 0x38D2B50
	|-ReadOnlyCollection<UnitySynchronizationContext.WorkRequest>.System.Collections.IList.Remove
	|
	|-RVA: 0x38D3B40 Offset: 0x38D3C41 VA: 0x38D3B40
	|-ReadOnlyCollection<XmlSchemaObjectTable.XmlSchemaObjectEntry>.System.Collections.IList.Remove
	|
	|-RVA: 0x38D4B30 Offset: 0x38D4C31 VA: 0x38D4B30
	|-ReadOnlyCollection<AssetBundleBuildMap.AssetBundleEntry.AssetPathString>.System.Collections.IList.Remove
	|
	|-RVA: 0x38D5C70 Offset: 0x38D5D71 VA: 0x38D5C70
	|-ReadOnlyCollection<Detail.DataStore.DataStoreChangeMetaParamInt>.System.Collections.IList.Remove
	|
	|-RVA: 0x38D6C60 Offset: 0x38D6D61 VA: 0x38D6C60
	|-ReadOnlyCollection<Detail.DataStore.DataStoreDeleteParamInt>.System.Collections.IList.Remove
	|
	|-RVA: 0x38D7D80 Offset: 0x38D7E81 VA: 0x38D7D80
	|-ReadOnlyCollection<Detail.DataStore.DataStoreGetMetaParamInt>.System.Collections.IList.Remove
	|
	|-RVA: 0x38D8EA0 Offset: 0x38D8FA1 VA: 0x38D8EA0
	|-ReadOnlyCollection<Detail.DataStore.DataStoreMetaInfoInt>.System.Collections.IList.Remove
	|
	|-RVA: 0x38D9F60 Offset: 0x38DA061 VA: 0x38D9F60
	|-ReadOnlyCollection<Detail.DataStore.DataStorePasswordInfoInt>.System.Collections.IList.Remove
	|
	|-RVA: 0x38DB020 Offset: 0x38DB121 VA: 0x38DB020
	|-ReadOnlyCollection<Detail.DataStore.DataStorePersistenceInfoInt>.System.Collections.IList.Remove
	|
	|-RVA: 0x38DC140 Offset: 0x38DC241 VA: 0x38DC140
	|-ReadOnlyCollection<Detail.DataStore.DataStorePreparePostParamInt>.System.Collections.IList.Remove
	|
	|-RVA: 0x38DD130 Offset: 0x38DD231 VA: 0x38DD130
	|-ReadOnlyCollection<Detail.DataStore.DataStoreRateObjectParamInt>.System.Collections.IList.Remove
	|
	|-RVA: 0x38DE1F0 Offset: 0x38DE2F1 VA: 0x38DE1F0
	|-ReadOnlyCollection<Detail.DataStore.DataStoreRatingInitParamInt>.System.Collections.IList.Remove
	|
	|-RVA: 0x38DF1E0 Offset: 0x38DF2E1 VA: 0x38DF1E0
	|-ReadOnlyCollection<Detail.DataStore.DataStoreRatingTargetInt>.System.Collections.IList.Remove
	|
	|-RVA: 0x38E0370 Offset: 0x38E0471 VA: 0x38E0370
	|-ReadOnlyCollection<Detail.Ranking.RankingCachedResultInt>.System.Collections.IList.Remove
	|
	|-RVA: 0x38E1360 Offset: 0x38E1461 VA: 0x38E1360
	|-ReadOnlyCollection<Detail.Ranking.RankingOrderParamInt>.System.Collections.IList.Remove
	|
	|-RVA: 0x38E24F0 Offset: 0x38E25F1 VA: 0x38E24F0
	|-ReadOnlyCollection<Detail.Ranking.RankingRankDataInt>.System.Collections.IList.Remove
	|
	|-RVA: 0x38E3800 Offset: 0x38E3901 VA: 0x38E3800
	|-ReadOnlyCollection<Detail.Ranking2.Ranking2ChartInfoInt>.System.Collections.IList.Remove
	|
	|-RVA: 0x38E4990 Offset: 0x38E4A91 VA: 0x38E4990
	|-ReadOnlyCollection<Detail.Ranking2.Ranking2RankDataInt>.System.Collections.IList.Remove
	|
	|-RVA: 0x38E5980 Offset: 0x38E5A81 VA: 0x38E5980
	|-ReadOnlyCollection<Detail.Ranking2.Ranking2ScoreDataInt>.System.Collections.IList.Remove
	|
	|-RVA: 0x38E6A40 Offset: 0x38E6B41 VA: 0x38E6A40
	|-ReadOnlyCollection<Detail.Screening.ScreeningContextInfoInt>.System.Collections.IList.Remove
	|
	|-RVA: 0x38E7C90 Offset: 0x38E7D91 VA: 0x38E7C90
	|-ReadOnlyCollection<Detail.Subscriber.SubscriberContentInt>.System.Collections.IList.Remove
	|
	|-RVA: 0x38E8D50 Offset: 0x38E8E51 VA: 0x38E8D50
	|-ReadOnlyCollection<Detail.Subscriber.SubscriberGetContentParamInt>.System.Collections.IList.Remove
	|
	|-RVA: 0x38E9E70 Offset: 0x38E9F71 VA: 0x38E9E70
	|-ReadOnlyCollection<Detail.Subscriber.SubscriberUserStatusInfoInt>.System.Collections.IList.Remove
	|
	|-RVA: 0x38EAF30 Offset: 0x38EB031 VA: 0x38EAF30
	|-ReadOnlyCollection<Detail.Subscriber.SubscriberUserStatusParamInt>.System.Collections.IList.Remove
	|
	|-RVA: 0x38EBF10 Offset: 0x38EC011 VA: 0x38EBF10
	|-ReadOnlyCollection<Detail.Utility.IntegerSettings>.System.Collections.IList.Remove
	|
	|-RVA: 0x38ECF00 Offset: 0x38ED001 VA: 0x38ECF00
	|-ReadOnlyCollection<Detail.Utility.UniqueIdInfoInt>.System.Collections.IList.Remove
	|
	|-RVA: 0x38EDF30 Offset: 0x38EE031 VA: 0x38EDF30
	|-ReadOnlyCollection<MapHistory.Rewind.LatestInspectorData>.System.Collections.IList.Remove
	|
	|-RVA: 0x38EEF60 Offset: 0x38EF061 VA: 0x38EEF60
	|-ReadOnlyCollection<MapHistory.Rewind.WorkTerrainData>.System.Collections.IList.Remove
	|
	|-RVA: 0x38EFF50 Offset: 0x38F0051 VA: 0x38EFF50
	|-ReadOnlyCollection<MapSkill.AroundCalculator.Result>.System.Collections.IList.Remove
	|
	|-RVA: 0x38F1080 Offset: 0x38F1181 VA: 0x38F1080
	|-ReadOnlyCollection<TargetPositionCache.CacheCurve.Item>.System.Collections.IList.Remove
	|
	|-RVA: 0x2FE6630 Offset: 0x2FE6731 VA: 0x2FE6630
	|-ReadOnlyCollection<TargetPositionCache.CacheEntry.RecordingItem>.System.Collections.IList.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 27
	private void System.Collections.IList.RemoveAt(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3468430 Offset: 0x3468531 VA: 0x3468430
	|-ReadOnlyCollection<IntervalTree.Entry<object>>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x3469420 Offset: 0x3469521 VA: 0x3469420
	|-ReadOnlyCollection<KeyValuePair<DateTime, object>>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x346A410 Offset: 0x346A511 VA: 0x346A410
	|-ReadOnlyCollection<KeyValuePair<int, object>>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x346B4D0 Offset: 0x346B5D1 VA: 0x346B4D0
	|-ReadOnlyCollection<KeyValuePair<object, ValueTuple<int, DateTime, object>>>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x346C4C0 Offset: 0x346C5C1 VA: 0x346C4C0
	|-ReadOnlyCollection<KeyValuePair<object, object>>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x346D580 Offset: 0x346D681 VA: 0x346D580
	|-ReadOnlyCollection<CommonBattleSequence.Reliance<object>>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x346E570 Offset: 0x346E671 VA: 0x346E570
	|-ReadOnlyCollection<RenderGraphResourcePool.ResourceLogInfo<object>>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x346F560 Offset: 0x346F661 VA: 0x346F560
	|-ReadOnlyCollection<ValueTuple<int, object>>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x3470540 Offset: 0x3470641 VA: 0x3470540
	|-ReadOnlyCollection<ValueTuple<Int32Enum, int>>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x3471600 Offset: 0x3471701 VA: 0x3471600
	|-ReadOnlyCollection<ValueTuple<object, ValueTuple<object, int>>>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x34725F0 Offset: 0x34726F1 VA: 0x34725F0
	|-ReadOnlyCollection<ValueTuple<object, int>>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x3473610 Offset: 0x3473711 VA: 0x3473610
	|-ReadOnlyCollection<ValueTuple<Vector3, float>>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x3474600 Offset: 0x3474701 VA: 0x3474600
	|-ReadOnlyCollection<ValueTuple<object, Int32Enum, int>>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x34756C0 Offset: 0x34757C1 VA: 0x34756C0
	|-ReadOnlyCollection<ValueTuple<object, int, int, int>>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x34766A0 Offset: 0x34767A1 VA: 0x34766A0
	|-ReadOnlyCollection<AnimatorClipInfo>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x3B23500 Offset: 0x3B23601 VA: 0x3B23500
	|-ReadOnlyCollection<AsyncOperationHandle>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x3B245C0 Offset: 0x3B246C1 VA: 0x3B245C0
	|-ReadOnlyCollection<BoneWeight>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x3B255B0 Offset: 0x3B256B1 VA: 0x3B255B0
	|-ReadOnlyCollection<bool>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x3B26590 Offset: 0x3B26691 VA: 0x3B26590
	|-ReadOnlyCollection<byte>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x3B27580 Offset: 0x3B27681 VA: 0x3B27580
	|-ReadOnlyCollection<CameraInfo>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x3B28560 Offset: 0x3B28661 VA: 0x3B28560
	|-ReadOnlyCollection<char>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x3B29580 Offset: 0x3B29681 VA: 0x3B29580
	|-ReadOnlyCollection<Color>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x3B2A5A0 Offset: 0x3B2A6A1 VA: 0x3B2A5A0
	|-ReadOnlyCollection<Color32>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x3B2B590 Offset: 0x3B2B691 VA: 0x3B2B590
	|-ReadOnlyCollection<ConstraintSource>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x3B2C650 Offset: 0x3B2C751 VA: 0x3B2C650
	|-ReadOnlyCollection<ContourVertex>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x3B2D710 Offset: 0x3B2D811 VA: 0x3B2D710
	|-ReadOnlyCollection<CustomAttributeNamedArgument>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x3B2E700 Offset: 0x3B2E801 VA: 0x3B2E700
	|-ReadOnlyCollection<CustomAttributeTypedArgument>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x3B2F7C0 Offset: 0x3B2F8C1 VA: 0x3B2F7C0
	|-ReadOnlyCollection<DataStoreRatingInfo>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x3B307A0 Offset: 0x3B308A1 VA: 0x3B307A0
	|-ReadOnlyCollection<DataStoreResult>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x3B31780 Offset: 0x3B31881 VA: 0x3B31780
	|-ReadOnlyCollection<DateTime>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x3B32770 Offset: 0x3B32871 VA: 0x3B32770
	|-ReadOnlyCollection<DateTimeOffset>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x3B33760 Offset: 0x3B33861 VA: 0x3B33760
	|-ReadOnlyCollection<Decimal>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x3B34890 Offset: 0x3B34991 VA: 0x3B34890
	|-ReadOnlyCollection<DiagnosticEvent>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x3B35870 Offset: 0x3B35971 VA: 0x3B35870
	|-ReadOnlyCollection<double>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x3B369A0 Offset: 0x3B36AA1 VA: 0x3B369A0
	|-ReadOnlyCollection<Friend>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x3B37990 Offset: 0x3B37A91 VA: 0x3B37990
	|-ReadOnlyCollection<GlyphRect>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x3B38970 Offset: 0x3B38A71 VA: 0x3B38970
	|-ReadOnlyCollection<short>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x3B39950 Offset: 0x3B39A51 VA: 0x3B39950
	|-ReadOnlyCollection<int>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x3B3A930 Offset: 0x3B3AA31 VA: 0x3B3A930
	|-ReadOnlyCollection<Int32Enum>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x3B3B910 Offset: 0x3B3BA11 VA: 0x3B3B910
	|-ReadOnlyCollection<long>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x3B3C8F0 Offset: 0x3B3C9F1 VA: 0x3B3C8F0
	|-ReadOnlyCollection<IntPtr>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x3B3D8E0 Offset: 0x3B3D9E1 VA: 0x3B3D8E0
	|-ReadOnlyCollection<InterpretedFrameInfo>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x3B3E9A0 Offset: 0x3B3EAA1 VA: 0x3B3E9A0
	|-ReadOnlyCollection<IntervalTreeNode>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x3B3F980 Offset: 0x3B3FA81 VA: 0x3B3F980
	|-ReadOnlyCollection<LengthLimitProperties>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x3B40960 Offset: 0x3B40A61 VA: 0x3B40960
	|-ReadOnlyCollection<MapPos>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x3B41AF0 Offset: 0x3B41BF1 VA: 0x3B41AF0
	|-ReadOnlyCollection<Matrix4x4>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x3B429E0 Offset: 0x3B42AE1 VA: 0x3B429E0
	|-ReadOnlyCollection<object>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x3B43B10 Offset: 0x3B43C11 VA: 0x3B43B10
	|-ReadOnlyCollection<ObjectInitializationData>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x3B44BD0 Offset: 0x3B44CD1 VA: 0x3B44BD0
	|-ReadOnlyCollection<PlayableBinding>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x3B45CF0 Offset: 0x3B45DF1 VA: 0x3B45CF0
	|-ReadOnlyCollection<PlayerLoopSystem>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x3B46E10 Offset: 0x3B46F11 VA: 0x3B46E10
	|-ReadOnlyCollection<PlayerLoopSystemInternal>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x3B47E00 Offset: 0x3B47F01 VA: 0x3B47E00
	|-ReadOnlyCollection<RangePositionInfo>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x3B48DE0 Offset: 0x3B48EE1 VA: 0x3B48DE0
	|-ReadOnlyCollection<Ranking2ChartInfoInput>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x3B49F40 Offset: 0x3B4A041 VA: 0x3B49F40
	|-ReadOnlyCollection<RaycastHit2D>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x3B4B190 Offset: 0x3B4B291 VA: 0x3B4B190
	|-ReadOnlyCollection<RaycastResult>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x3B4C1B0 Offset: 0x3B4C2B1 VA: 0x3B4C1B0
	|-ReadOnlyCollection<Rect>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x3B4D190 Offset: 0x3B4D291 VA: 0x3B4D190
	|-ReadOnlyCollection<RendererListHandle>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x3B4E170 Offset: 0x3B4E271 VA: 0x3B4E170
	|-ReadOnlyCollection<ResourceHandle>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x3AAF830 Offset: 0x3AAF931 VA: 0x3AAF830
	|-ReadOnlyCollection<sbyte>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x3AB0850 Offset: 0x3AB0951 VA: 0x3AB0850
	|-ReadOnlyCollection<ShaderTagId>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x3AB1830 Offset: 0x3AB1931 VA: 0x3AB1830
	|-ReadOnlyCollection<float>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x3AB2C20 Offset: 0x3AB2D21 VA: 0x3AB2C20
	|-ReadOnlyCollection<SphericalHarmonicsL2>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x3AB3D50 Offset: 0x3AB3E51 VA: 0x3AB3D50
	|-ReadOnlyCollection<SubMeshDescriptor>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x3AB4D40 Offset: 0x3AB4E41 VA: 0x3AB4D40
	|-ReadOnlyCollection<TablePair>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x3AB5D20 Offset: 0x3AB5E21 VA: 0x3AB5D20
	|-ReadOnlyCollection<TimeSpan>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x3AB6D40 Offset: 0x3AB6E41 VA: 0x3AB6D40
	|-ReadOnlyCollection<UICharInfo>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x3AB7D30 Offset: 0x3AB7E31 VA: 0x3AB7D30
	|-ReadOnlyCollection<UILineInfo>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x3AB9120 Offset: 0x3AB9221 VA: 0x3AB9120
	|-ReadOnlyCollection<UIVertex>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x3ABA100 Offset: 0x3ABA201 VA: 0x3ABA100
	|-ReadOnlyCollection<ushort>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x3ABB0E0 Offset: 0x3ABB1E1 VA: 0x3ABB0E0
	|-ReadOnlyCollection<uint>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x3ABC0C0 Offset: 0x3ABC1C1 VA: 0x3ABC0C0
	|-ReadOnlyCollection<ulong>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x3ABD0C0 Offset: 0x3ABD1C1 VA: 0x3ABD0C0
	|-ReadOnlyCollection<Vector2>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x3ABE0E0 Offset: 0x3ABE1E1 VA: 0x3ABE0E0
	|-ReadOnlyCollection<Vector3>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x3ABF100 Offset: 0x3ABF201 VA: 0x3ABF100
	|-ReadOnlyCollection<Vector4>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x3AC00F0 Offset: 0x3AC01F1 VA: 0x3AC00F0
	|-ReadOnlyCollection<VertexAttributeDescriptor>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x3AC10E0 Offset: 0x3AC11E1 VA: 0x3AC10E0
	|-ReadOnlyCollection<X509ChainStatus>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x3AC2200 Offset: 0x3AC2301 VA: 0x3AC2200
	|-ReadOnlyCollection<XRView>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x3AC3230 Offset: 0x3AC3331 VA: 0x3AC3230
	|-ReadOnlyCollection<AICrossfire.PositionTable>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x3AC4220 Offset: 0x3AC4321 VA: 0x3AC4220
	|-ReadOnlyCollection<AmiiboSequence.GainItemData>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x3AC5340 Offset: 0x3AC5441 VA: 0x3AC5340
	|-ReadOnlyCollection<AnimationOutputWeightProcessor.WeightInfo>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x3AC6330 Offset: 0x3AC6431 VA: 0x3AC6330
	|-ReadOnlyCollection<ArenaOrderSequence.GodInfo>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x3AC7320 Offset: 0x3AC7421 VA: 0x3AC7320
	|-ReadOnlyCollection<BattleInfo.SupportData>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x3AC8310 Offset: 0x3AC8411 VA: 0x3AC8310
	|-ReadOnlyCollection<BeforeRenderHelper.OrderBlock>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x3AC93D0 Offset: 0x3AC94D1 VA: 0x3AC93D0
	|-ReadOnlyCollection<Camera.RenderRequest>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x3ACA3C0 Offset: 0x3ACA4C1 VA: 0x3ACA3C0
	|-ReadOnlyCollection<CameraState.CustomBlendable>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x3ACB3A0 Offset: 0x3ACB4A1 VA: 0x3ACB3A0
	|-ReadOnlyCollection<CinemachineClearShot.Pair>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x3ACC380 Offset: 0x3ACC481 VA: 0x3ACC380
	|-ReadOnlyCollection<CinemachineStateDrivenCamera.HashPair>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x3ACD440 Offset: 0x3ACD541 VA: 0x3ACD440
	|-ReadOnlyCollection<DelayedActionManager.DelegateInfo>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x3ACE570 Offset: 0x3ACE671 VA: 0x3ACE570
	|-ReadOnlyCollection<Detail.AsyncResultInt>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x3ACF560 Offset: 0x3ACF661 VA: 0x3ACF560
	|-ReadOnlyCollection<Detail.CppArray>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x3AD0690 Offset: 0x3AD0791 VA: 0x3AD0690
	|-ReadOnlyCollection<Detail.NotificationEventInt>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x3AD1680 Offset: 0x3AD1781 VA: 0x3AD1680
	|-ReadOnlyCollection<DragonRideTargetGroup.ChainParam>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x3AD2740 Offset: 0x3AD2841 VA: 0x3AD2740
	|-ReadOnlyCollection<GmapPathAdjuster.TargetModel>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x3AD3800 Offset: 0x3AD3901 VA: 0x3AD3800
	|-ReadOnlyCollection<GmapSpotAdjuster.TargetModel>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x3AD48C0 Offset: 0x3AD49C1 VA: 0x3AD48C0
	|-ReadOnlyCollection<HubFastTravel.Location>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x3AD59F0 Offset: 0x3AD5AF1 VA: 0x3AD59F0
	|-ReadOnlyCollection<HubLensFlare.Flare>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x3AD69E0 Offset: 0x3AD6AE1 VA: 0x3AD69E0
	|-ReadOnlyCollection<InventoryPoolItemMenuContent.KindBgNameClass>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x3AD79C0 Offset: 0x3AD7AC1 VA: 0x3AD79C0
	|-ReadOnlyCollection<Map.Pos>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x3AD89B0 Offset: 0x3AD8AB1 VA: 0x3AD89B0
	|-ReadOnlyCollection<MapImage.BackupTerrain>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x3AD99D0 Offset: 0x3AD9AD1 VA: 0x3AD99D0
	|-ReadOnlyCollection<MapImageRange.Pos>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x3ADAA90 Offset: 0x3ADAB91 VA: 0x3ADAA90
	|-ReadOnlyCollection<MapMind.Target>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x38C5470 Offset: 0x38C5571 VA: 0x38C5470
	|-ReadOnlyCollection<MapPanelDebug.Entity>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x38C6450 Offset: 0x38C6551 VA: 0x38C6450
	|-ReadOnlyCollection<NexRanking.Data>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x38C7440 Offset: 0x38C7541 VA: 0x38C7440
	|-ReadOnlyCollection<NexVersus.RatingData>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x38C8430 Offset: 0x38C8531 VA: 0x38C8430
	|-ReadOnlyCollection<PackedPlayModeBuildLogs.RuntimeBuildLog>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x38C9550 Offset: 0x38C9651 VA: 0x38C9550
	|-ReadOnlyCollection<ParticleSystem.Particle>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x38CA530 Offset: 0x38CA631 VA: 0x38CA530
	|-ReadOnlyCollection<RangeData.Offset>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x38CB5F0 Offset: 0x38CB6F1 VA: 0x38CB5F0
	|-ReadOnlyCollection<RenderGraphDebugData.PassDebugData>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x38CC710 Offset: 0x38CC811 VA: 0x38CC710
	|-ReadOnlyCollection<RenderGraphDebugData.ResourceDebugData>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x38CD700 Offset: 0x38CD801 VA: 0x38CD700
	|-ReadOnlyCollection<RingCleaningUnitSelectMenu.GodParam>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x38CE830 Offset: 0x38CE931 VA: 0x38CE830
	|-ReadOnlyCollection<ShadowUtility.Edge>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x38CF850 Offset: 0x38CF951 VA: 0x38CF850
	|-ReadOnlyCollection<SkillArray.Entity>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x38D09E0 Offset: 0x38D0AE1 VA: 0x38D09E0
	|-ReadOnlyCollection<TexturePacker_JsonArray.Frame>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x38D1AA0 Offset: 0x38D1BA1 VA: 0x38D1AA0
	|-ReadOnlyCollection<TimeNotificationBehaviour.NotificationEntry>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x38D2B60 Offset: 0x38D2C61 VA: 0x38D2B60
	|-ReadOnlyCollection<UnitySynchronizationContext.WorkRequest>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x38D3B50 Offset: 0x38D3C51 VA: 0x38D3B50
	|-ReadOnlyCollection<XmlSchemaObjectTable.XmlSchemaObjectEntry>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x38D4B40 Offset: 0x38D4C41 VA: 0x38D4B40
	|-ReadOnlyCollection<AssetBundleBuildMap.AssetBundleEntry.AssetPathString>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x38D5C80 Offset: 0x38D5D81 VA: 0x38D5C80
	|-ReadOnlyCollection<Detail.DataStore.DataStoreChangeMetaParamInt>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x38D6C70 Offset: 0x38D6D71 VA: 0x38D6C70
	|-ReadOnlyCollection<Detail.DataStore.DataStoreDeleteParamInt>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x38D7D90 Offset: 0x38D7E91 VA: 0x38D7D90
	|-ReadOnlyCollection<Detail.DataStore.DataStoreGetMetaParamInt>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x38D8EB0 Offset: 0x38D8FB1 VA: 0x38D8EB0
	|-ReadOnlyCollection<Detail.DataStore.DataStoreMetaInfoInt>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x38D9F70 Offset: 0x38DA071 VA: 0x38D9F70
	|-ReadOnlyCollection<Detail.DataStore.DataStorePasswordInfoInt>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x38DB030 Offset: 0x38DB131 VA: 0x38DB030
	|-ReadOnlyCollection<Detail.DataStore.DataStorePersistenceInfoInt>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x38DC150 Offset: 0x38DC251 VA: 0x38DC150
	|-ReadOnlyCollection<Detail.DataStore.DataStorePreparePostParamInt>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x38DD140 Offset: 0x38DD241 VA: 0x38DD140
	|-ReadOnlyCollection<Detail.DataStore.DataStoreRateObjectParamInt>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x38DE200 Offset: 0x38DE301 VA: 0x38DE200
	|-ReadOnlyCollection<Detail.DataStore.DataStoreRatingInitParamInt>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x38DF1F0 Offset: 0x38DF2F1 VA: 0x38DF1F0
	|-ReadOnlyCollection<Detail.DataStore.DataStoreRatingTargetInt>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x38E0380 Offset: 0x38E0481 VA: 0x38E0380
	|-ReadOnlyCollection<Detail.Ranking.RankingCachedResultInt>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x38E1370 Offset: 0x38E1471 VA: 0x38E1370
	|-ReadOnlyCollection<Detail.Ranking.RankingOrderParamInt>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x38E2500 Offset: 0x38E2601 VA: 0x38E2500
	|-ReadOnlyCollection<Detail.Ranking.RankingRankDataInt>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x38E3810 Offset: 0x38E3911 VA: 0x38E3810
	|-ReadOnlyCollection<Detail.Ranking2.Ranking2ChartInfoInt>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x38E49A0 Offset: 0x38E4AA1 VA: 0x38E49A0
	|-ReadOnlyCollection<Detail.Ranking2.Ranking2RankDataInt>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x38E5990 Offset: 0x38E5A91 VA: 0x38E5990
	|-ReadOnlyCollection<Detail.Ranking2.Ranking2ScoreDataInt>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x38E6A50 Offset: 0x38E6B51 VA: 0x38E6A50
	|-ReadOnlyCollection<Detail.Screening.ScreeningContextInfoInt>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x38E7CA0 Offset: 0x38E7DA1 VA: 0x38E7CA0
	|-ReadOnlyCollection<Detail.Subscriber.SubscriberContentInt>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x38E8D60 Offset: 0x38E8E61 VA: 0x38E8D60
	|-ReadOnlyCollection<Detail.Subscriber.SubscriberGetContentParamInt>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x38E9E80 Offset: 0x38E9F81 VA: 0x38E9E80
	|-ReadOnlyCollection<Detail.Subscriber.SubscriberUserStatusInfoInt>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x38EAF40 Offset: 0x38EB041 VA: 0x38EAF40
	|-ReadOnlyCollection<Detail.Subscriber.SubscriberUserStatusParamInt>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x38EBF20 Offset: 0x38EC021 VA: 0x38EBF20
	|-ReadOnlyCollection<Detail.Utility.IntegerSettings>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x38ECF10 Offset: 0x38ED011 VA: 0x38ECF10
	|-ReadOnlyCollection<Detail.Utility.UniqueIdInfoInt>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x38EDF40 Offset: 0x38EE041 VA: 0x38EDF40
	|-ReadOnlyCollection<MapHistory.Rewind.LatestInspectorData>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x38EEF70 Offset: 0x38EF071 VA: 0x38EEF70
	|-ReadOnlyCollection<MapHistory.Rewind.WorkTerrainData>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x38EFF60 Offset: 0x38F0061 VA: 0x38EFF60
	|-ReadOnlyCollection<MapSkill.AroundCalculator.Result>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x38F1090 Offset: 0x38F1191 VA: 0x38F1090
	|-ReadOnlyCollection<TargetPositionCache.CacheCurve.Item>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x2FE6640 Offset: 0x2FE6741 VA: 0x2FE6640
	|-ReadOnlyCollection<TargetPositionCache.CacheEntry.RecordingItem>.System.Collections.IList.RemoveAt
	*/
}

