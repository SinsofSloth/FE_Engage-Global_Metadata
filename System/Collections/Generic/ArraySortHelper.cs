// Namespace: System.Collections.Generic
internal class ArraySortHelper<T> // TypeDefIndex: 1398
{
	// Methods

	// RVA: -1 Offset: -1
	public static void Sort(T[] keys, int index, int length, IComparer<T> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FFCD70 Offset: 0x1FFCE71 VA: 0x1FFCD70
	|-ArraySortHelper<IntervalTree.Entry<object>>.Sort
	|
	|-RVA: 0x1FFE7B0 Offset: 0x1FFE8B1 VA: 0x1FFE7B0
	|-ArraySortHelper<KeyValuePair<DateTime, object>>.Sort
	|
	|-RVA: 0x2000020 Offset: 0x2000121 VA: 0x2000020
	|-ArraySortHelper<KeyValuePair<int, object>>.Sort
	|
	|-RVA: 0x2001890 Offset: 0x2001991 VA: 0x2001890
	|-ArraySortHelper<KeyValuePair<object, ValueTuple<int, DateTime, object>>>.Sort
	|
	|-RVA: 0x20032D0 Offset: 0x20033D1 VA: 0x20032D0
	|-ArraySortHelper<KeyValuePair<object, object>>.Sort
	|
	|-RVA: 0x2004B70 Offset: 0x2004C71 VA: 0x2004B70
	|-ArraySortHelper<CommonBattleSequence.Reliance<object>>.Sort
	|
	|-RVA: 0x20065B0 Offset: 0x20066B1 VA: 0x20065B0
	|-ArraySortHelper<RenderGraphResourcePool.ResourceLogInfo<object>>.Sort
	|
	|-RVA: 0x2007E50 Offset: 0x2007F51 VA: 0x2007E50
	|-ArraySortHelper<ValueTuple<int, object>>.Sort
	|
	|-RVA: 0x20096C0 Offset: 0x20097C1 VA: 0x20096C0
	|-ArraySortHelper<ValueTuple<Int32Enum, int>>.Sort
	|
	|-RVA: 0x200AD50 Offset: 0x200AE51 VA: 0x200AD50
	|-ArraySortHelper<ValueTuple<object, ValueTuple<object, int>>>.Sort
	|
	|-RVA: 0x200C790 Offset: 0x200C891 VA: 0x200C790
	|-ArraySortHelper<ValueTuple<object, int>>.Sort
	|
	|-RVA: 0x200E030 Offset: 0x200E131 VA: 0x200E030
	|-ArraySortHelper<ValueTuple<Vector3, float>>.Sort
	|
	|-RVA: 0x200F9F0 Offset: 0x200FAF1 VA: 0x200F9F0
	|-ArraySortHelper<ValueTuple<object, Int32Enum, int>>.Sort
	|
	|-RVA: 0x3A7FBE0 Offset: 0x3A7FCE1 VA: 0x3A7FBE0
	|-ArraySortHelper<ValueTuple<object, int, int, int>>.Sort
	|
	|-RVA: 0x3A81620 Offset: 0x3A81721 VA: 0x3A81620
	|-ArraySortHelper<AnimatorClipInfo>.Sort
	|
	|-RVA: 0x3A82CB0 Offset: 0x3A82DB1 VA: 0x3A82CB0
	|-ArraySortHelper<AsyncOperationHandle>.Sort
	|
	|-RVA: 0x3A846F0 Offset: 0x3A847F1 VA: 0x3A846F0
	|-ArraySortHelper<BoneWeight>.Sort
	|
	|-RVA: 0x3A860B0 Offset: 0x3A861B1 VA: 0x3A860B0
	|-ArraySortHelper<bool>.Sort
	|
	|-RVA: 0x3A87790 Offset: 0x3A87891 VA: 0x3A87790
	|-ArraySortHelper<byte>.Sort
	|
	|-RVA: 0x3A88E20 Offset: 0x3A88F21 VA: 0x3A88E20
	|-ArraySortHelper<CameraInfo>.Sort
	|
	|-RVA: 0x3A8A690 Offset: 0x3A8A791 VA: 0x3A8A690
	|-ArraySortHelper<char>.Sort
	|
	|-RVA: 0x3A8BD20 Offset: 0x3A8BE21 VA: 0x3A8BD20
	|-ArraySortHelper<Color>.Sort
	|
	|-RVA: 0x3A8D6E0 Offset: 0x3A8D7E1 VA: 0x3A8D6E0
	|-ArraySortHelper<Color32>.Sort
	|
	|-RVA: 0x3A8ED70 Offset: 0x3A8EE71 VA: 0x3A8ED70
	|-ArraySortHelper<ConstraintSource>.Sort
	|
	|-RVA: 0x3A90610 Offset: 0x3A90711 VA: 0x3A90610
	|-ArraySortHelper<ContourVertex>.Sort
	|
	|-RVA: 0x3A92050 Offset: 0x3A92151 VA: 0x3A92050
	|-ArraySortHelper<DataStoreRatingInfo>.Sort
	|
	|-RVA: 0x3A939D0 Offset: 0x3A93AD1 VA: 0x3A939D0
	|-ArraySortHelper<DataStoreResult>.Sort
	|
	|-RVA: 0x3A95060 Offset: 0x3A95161 VA: 0x3A95060
	|-ArraySortHelper<DateTime>.Sort
	|
	|-RVA: 0x3A966F0 Offset: 0x3A967F1 VA: 0x3A966F0
	|-ArraySortHelper<DateTimeOffset>.Sort
	|
	|-RVA: 0x3A97ED0 Offset: 0x3A97FD1 VA: 0x3A97ED0
	|-ArraySortHelper<Decimal>.Sort
	|
	|-RVA: 0x3A996B0 Offset: 0x3A997B1 VA: 0x3A996B0
	|-ArraySortHelper<DiagnosticEvent>.Sort
	|
	|-RVA: 0x3A9B2B0 Offset: 0x3A9B3B1 VA: 0x3A9B2B0
	|-ArraySortHelper<double>.Sort
	|
	|-RVA: 0x3A9C950 Offset: 0x3A9CA51 VA: 0x3A9C950
	|-ArraySortHelper<Friend>.Sort
	|
	|-RVA: 0x3A9E360 Offset: 0x3A9E461 VA: 0x3A9E360
	|-ArraySortHelper<GlyphRect>.Sort
	|
	|-RVA: 0x3A9FB40 Offset: 0x3A9FC41 VA: 0x3A9FB40
	|-ArraySortHelper<short>.Sort
	|
	|-RVA: 0x3AA11D0 Offset: 0x3AA12D1 VA: 0x3AA11D0
	|-ArraySortHelper<int>.Sort
	|
	|-RVA: 0x3AA2860 Offset: 0x3AA2961 VA: 0x3AA2860
	|-ArraySortHelper<Int32Enum>.Sort
	|
	|-RVA: 0x3AA3EF0 Offset: 0x3AA3FF1 VA: 0x3AA3EF0
	|-ArraySortHelper<long>.Sort
	|
	|-RVA: 0x3AA5580 Offset: 0x3AA5681 VA: 0x3AA5580
	|-ArraySortHelper<IntPtr>.Sort
	|
	|-RVA: 0x3AA6C10 Offset: 0x3AA6D11 VA: 0x3AA6C10
	|-ArraySortHelper<InterpretedFrameInfo>.Sort
	|
	|-RVA: 0x3AA84B0 Offset: 0x3AA85B1 VA: 0x3AA84B0
	|-ArraySortHelper<IntervalTreeNode>.Sort
	|
	|-RVA: 0x3AA9E30 Offset: 0x3AA9F31 VA: 0x3AA9E30
	|-ArraySortHelper<LengthLimitProperties>.Sort
	|
	|-RVA: 0x3AAB4C0 Offset: 0x3AAB5C1 VA: 0x3AAB4C0
	|-ArraySortHelper<MapPos>.Sort
	|
	|-RVA: 0x3AACB50 Offset: 0x3AACC51 VA: 0x3AACB50
	|-ArraySortHelper<Matrix4x4>.Sort
	|
	|-RVA: 0x394EFD0 Offset: 0x394F0D1 VA: 0x394EFD0
	|-ArraySortHelper<object>.Sort
	|
	|-RVA: 0x39506C0 Offset: 0x39507C1 VA: 0x39506C0
	|-ArraySortHelper<ObjectInitializationData>.Sort
	|
	|-RVA: 0x39522C0 Offset: 0x39523C1 VA: 0x39522C0
	|-ArraySortHelper<PlayableBinding>.Sort
	|
	|-RVA: 0x3953D00 Offset: 0x3953E01 VA: 0x3953D00
	|-ArraySortHelper<PlayerLoopSystem>.Sort
	|
	|-RVA: 0x39558D0 Offset: 0x39559D1 VA: 0x39558D0
	|-ArraySortHelper<PlayerLoopSystemInternal>.Sort
	|
	|-RVA: 0x39574A0 Offset: 0x39575A1 VA: 0x39574A0
	|-ArraySortHelper<RangePositionInfo>.Sort
	|
	|-RVA: 0x3958D40 Offset: 0x3958E41 VA: 0x3958D40
	|-ArraySortHelper<Ranking2ChartInfoInput>.Sort
	|
	|-RVA: 0x395A3D0 Offset: 0x395A4D1 VA: 0x395A3D0
	|-ArraySortHelper<RaycastHit>.Sort
	|
	|-RVA: 0x395C0D0 Offset: 0x395C1D1 VA: 0x395C0D0
	|-ArraySortHelper<RaycastHit2D>.Sort
	|
	|-RVA: 0x395DCE0 Offset: 0x395DDE1 VA: 0x395DCE0
	|-ArraySortHelper<RaycastResult>.Sort
	|
	|-RVA: 0x395FC10 Offset: 0x395FD11 VA: 0x395FC10
	|-ArraySortHelper<Rect>.Sort
	|
	|-RVA: 0x39615D0 Offset: 0x39616D1 VA: 0x39615D0
	|-ArraySortHelper<RendererListHandle>.Sort
	|
	|-RVA: 0x3962C60 Offset: 0x3962D61 VA: 0x3962C60
	|-ArraySortHelper<ResourceHandle>.Sort
	|
	|-RVA: 0x39642F0 Offset: 0x39643F1 VA: 0x39642F0
	|-ArraySortHelper<sbyte>.Sort
	|
	|-RVA: 0x3965980 Offset: 0x3965A81 VA: 0x3965980
	|-ArraySortHelper<ShaderTagId>.Sort
	|
	|-RVA: 0x3967010 Offset: 0x3967111 VA: 0x3967010
	|-ArraySortHelper<float>.Sort
	|
	|-RVA: 0x39686B0 Offset: 0x39687B1 VA: 0x39686B0
	|-ArraySortHelper<SphericalHarmonicsL2>.Sort
	|
	|-RVA: 0x396AB00 Offset: 0x396AC01 VA: 0x396AB00
	|-ArraySortHelper<SubMeshDescriptor>.Sort
	|
	|-RVA: 0x396C640 Offset: 0x396C741 VA: 0x396C640
	|-ArraySortHelper<TablePair>.Sort
	|
	|-RVA: 0x396DEE0 Offset: 0x396DFE1 VA: 0x396DEE0
	|-ArraySortHelper<TimeSpan>.Sort
	|
	|-RVA: 0x396F570 Offset: 0x396F671 VA: 0x396F570
	|-ArraySortHelper<UICharInfo>.Sort
	|
	|-RVA: 0x3970EA0 Offset: 0x3970FA1 VA: 0x3970EA0
	|-ArraySortHelper<UILineInfo>.Sort
	|
	|-RVA: 0x3972680 Offset: 0x3972781 VA: 0x3972680
	|-ArraySortHelper<UIVertex>.Sort
	|
	|-RVA: 0x3974AD0 Offset: 0x3974BD1 VA: 0x3974AD0
	|-ArraySortHelper<ushort>.Sort
	|
	|-RVA: 0x3976160 Offset: 0x3976261 VA: 0x3976160
	|-ArraySortHelper<uint>.Sort
	|
	|-RVA: 0x39777F0 Offset: 0x39778F1 VA: 0x39777F0
	|-ArraySortHelper<ulong>.Sort
	|
	|-RVA: 0x3978E80 Offset: 0x3978F81 VA: 0x3978E80
	|-ArraySortHelper<Vector2>.Sort
	|
	|-RVA: 0x397A650 Offset: 0x397A751 VA: 0x397A650
	|-ArraySortHelper<Vector3>.Sort
	|
	|-RVA: 0x397BF80 Offset: 0x397C081 VA: 0x397BF80
	|-ArraySortHelper<Vector4>.Sort
	|
	|-RVA: 0x397D940 Offset: 0x397DA41 VA: 0x397D940
	|-ArraySortHelper<VertexAttributeDescriptor>.Sort
	|
	|-RVA: 0x397F120 Offset: 0x397F221 VA: 0x397F120
	|-ArraySortHelper<X509ChainStatus>.Sort
	|
	|-RVA: 0x391E3C0 Offset: 0x391E4C1 VA: 0x391E3C0
	|-ArraySortHelper<XRView>.Sort
	|
	|-RVA: 0x391FEE0 Offset: 0x391FFE1 VA: 0x391FEE0
	|-ArraySortHelper<AmiiboSequence.GainItemData>.Sort
	|
	|-RVA: 0x3921780 Offset: 0x3921881 VA: 0x3921780
	|-ArraySortHelper<AnimationOutputWeightProcessor.WeightInfo>.Sort
	|
	|-RVA: 0x39232C0 Offset: 0x39233C1 VA: 0x39232C0
	|-ArraySortHelper<ArenaOrderSequence.GodInfo>.Sort
	|
	|-RVA: 0x3924B60 Offset: 0x3924C61 VA: 0x3924B60
	|-ArraySortHelper<BattleInfo.SupportData>.Sort
	|
	|-RVA: 0x3926400 Offset: 0x3926501 VA: 0x3926400
	|-ArraySortHelper<BeforeRenderHelper.OrderBlock>.Sort
	|
	|-RVA: 0x3927C70 Offset: 0x3927D71 VA: 0x3927C70
	|-ArraySortHelper<Camera.RenderRequest>.Sort
	|
	|-RVA: 0x39296C0 Offset: 0x39297C1 VA: 0x39296C0
	|-ArraySortHelper<CameraState.CustomBlendable>.Sort
	|
	|-RVA: 0x392AF60 Offset: 0x392B061 VA: 0x392AF60
	|-ArraySortHelper<CinemachineClearShot.Pair>.Sort
	|
	|-RVA: 0x392C5F0 Offset: 0x392C6F1 VA: 0x392C5F0
	|-ArraySortHelper<CinemachineStateDrivenCamera.HashPair>.Sort
	|
	|-RVA: 0x392DC80 Offset: 0x392DD81 VA: 0x392DC80
	|-ArraySortHelper<DeferredTiler.PrePunctualLight>.Sort
	|
	|-RVA: 0x392F640 Offset: 0x392F741 VA: 0x392F640
	|-ArraySortHelper<DelayedActionManager.DelegateInfo>.Sort
	|
	|-RVA: 0x3931090 Offset: 0x3931191 VA: 0x3931090
	|-ArraySortHelper<Detail.AsyncResultInt>.Sort
	|
	|-RVA: 0x3932BD0 Offset: 0x3932CD1 VA: 0x3932BD0
	|-ArraySortHelper<Detail.CppArray>.Sort
	|
	|-RVA: 0x39343B0 Offset: 0x39344B1 VA: 0x39343B0
	|-ArraySortHelper<Detail.NotificationEventInt>.Sort
	|
	|-RVA: 0x3935EF0 Offset: 0x3935FF1 VA: 0x3935EF0
	|-ArraySortHelper<DragonRideTargetGroup.ChainParam>.Sort
	|
	|-RVA: 0x3937790 Offset: 0x3937891 VA: 0x3937790
	|-ArraySortHelper<GmapPathAdjuster.TargetModel>.Sort
	|
	|-RVA: 0x39391D0 Offset: 0x39392D1 VA: 0x39391D0
	|-ArraySortHelper<GmapSpotAdjuster.TargetModel>.Sort
	|
	|-RVA: 0x393AC10 Offset: 0x393AD11 VA: 0x393AC10
	|-ArraySortHelper<HubFastTravel.Location>.Sort
	|
	|-RVA: 0x393C650 Offset: 0x393C751 VA: 0x393C650
	|-ArraySortHelper<HubLensFlare.Flare>.Sort
	|
	|-RVA: 0x393E250 Offset: 0x393E351 VA: 0x393E250
	|-ArraySortHelper<InventoryPoolItemMenuContent.KindBgNameClass>.Sort
	|
	|-RVA: 0x393FAC0 Offset: 0x393FBC1 VA: 0x393FAC0
	|-ArraySortHelper<Map.Pos>.Sort
	|
	|-RVA: 0x3941150 Offset: 0x3941251 VA: 0x3941150
	|-ArraySortHelper<MapImage.BackupTerrain>.Sort
	|
	|-RVA: 0x3942930 Offset: 0x3942A31 VA: 0x3942930
	|-ArraySortHelper<MapImageRange.Pos>.Sort
	|
	|-RVA: 0x3944080 Offset: 0x3944181 VA: 0x3944080
	|-ArraySortHelper<MapMind.Target>.Sort
	|
	|-RVA: 0x3945AC0 Offset: 0x3945BC1 VA: 0x3945AC0
	|-ArraySortHelper<MapPanelDebug.Entity>.Sort
	|
	|-RVA: 0x3947440 Offset: 0x3947541 VA: 0x3947440
	|-ArraySortHelper<NexRanking.Data>.Sort
	|
	|-RVA: 0x3948AD0 Offset: 0x3948BD1 VA: 0x3948AD0
	|-ArraySortHelper<NexVersus.RatingData>.Sort
	|
	|-RVA: 0x394A2B0 Offset: 0x394A3B1 VA: 0x394A2B0
	|-ArraySortHelper<PackedPlayModeBuildLogs.RuntimeBuildLog>.Sort
	|
	|-RVA: 0x394BB20 Offset: 0x394BC21 VA: 0x394BB20
	|-ArraySortHelper<ParticleSystem.Particle>.Sort
	|
	|-RVA: 0x394D590 Offset: 0x394D691 VA: 0x394D590
	|-ArraySortHelper<ProfileCard.SortieCount>.Sort
	|
	|-RVA: 0x377EB20 Offset: 0x377EC21 VA: 0x377EB20
	|-ArraySortHelper<RangeData.Offset>.Sort
	|
	|-RVA: 0x37801B0 Offset: 0x37802B1 VA: 0x37801B0
	|-ArraySortHelper<RenderGraphDebugData.PassDebugData>.Sort
	|
	|-RVA: 0x3781BF0 Offset: 0x3781CF1 VA: 0x3781BF0
	|-ArraySortHelper<RenderGraphDebugData.ResourceDebugData>.Sort
	|
	|-RVA: 0x37837C0 Offset: 0x37838C1 VA: 0x37837C0
	|-ArraySortHelper<RingCleaningUnitSelectMenu.GodParam>.Sort
	|
	|-RVA: 0x3785060 Offset: 0x3785161 VA: 0x3785060
	|-ArraySortHelper<ShadowUtility.Edge>.Sort
	|
	|-RVA: 0x3786B90 Offset: 0x3786C91 VA: 0x3786B90
	|-ArraySortHelper<SkillArray.Entity>.Sort
	|
	|-RVA: 0x3788220 Offset: 0x3788321 VA: 0x3788220
	|-ArraySortHelper<TexturePacker_JsonArray.Frame>.Sort
	|
	|-RVA: 0x3789FA0 Offset: 0x378A0A1 VA: 0x3789FA0
	|-ArraySortHelper<TimeNotificationBehaviour.NotificationEntry>.Sort
	|
	|-RVA: 0x378B9F0 Offset: 0x378BAF1 VA: 0x378B9F0
	|-ArraySortHelper<UnitySynchronizationContext.WorkRequest>.Sort
	|
	|-RVA: 0x378D430 Offset: 0x378D531 VA: 0x378D430
	|-ArraySortHelper<XmlSchemaObjectTable.XmlSchemaObjectEntry>.Sort
	|
	|-RVA: 0x378ECD0 Offset: 0x378EDD1 VA: 0x378ECD0
	|-ArraySortHelper<AIThink.EnchantThink.ItemInfo>.Sort
	|
	|-RVA: 0x3790420 Offset: 0x3790521 VA: 0x3790420
	|-ArraySortHelper<AssetBundleBuildMap.AssetBundleEntry.AssetPathString>.Sort
	|
	|-RVA: 0x3791CC0 Offset: 0x3791DC1 VA: 0x3791CC0
	|-ArraySortHelper<Detail.DataStore.DataStoreChangeMetaParamInt>.Sort
	|
	|-RVA: 0x3793880 Offset: 0x3793981 VA: 0x3793880
	|-ArraySortHelper<Detail.DataStore.DataStoreDeleteParamInt>.Sort
	|
	|-RVA: 0x3795060 Offset: 0x3795161 VA: 0x3795060
	|-ArraySortHelper<Detail.DataStore.DataStoreGetMetaParamInt>.Sort
	|
	|-RVA: 0x3796BA0 Offset: 0x3796CA1 VA: 0x3796BA0
	|-ArraySortHelper<Detail.DataStore.DataStoreMetaInfoInt>.Sort
	|
	|-RVA: 0x3798640 Offset: 0x3798741 VA: 0x3798640
	|-ArraySortHelper<Detail.DataStore.DataStorePasswordInfoInt>.Sort
	|
	|-RVA: 0x3799FC0 Offset: 0x379A0C1 VA: 0x3799FC0
	|-ArraySortHelper<Detail.DataStore.DataStorePersistenceInfoInt>.Sort
	|
	|-RVA: 0x379B940 Offset: 0x379BA41 VA: 0x379B940
	|-ArraySortHelper<Detail.DataStore.DataStorePreparePostParamInt>.Sort
	|
	|-RVA: 0x379D3B0 Offset: 0x379D4B1 VA: 0x379D3B0
	|-ArraySortHelper<Detail.DataStore.DataStoreRateObjectParamInt>.Sort
	|
	|-RVA: 0x379EB90 Offset: 0x379EC91 VA: 0x379EB90
	|-ArraySortHelper<Detail.DataStore.DataStoreRatingInitParamInt>.Sort
	|
	|-RVA: 0x37A0550 Offset: 0x37A0651 VA: 0x37A0550
	|-ArraySortHelper<Detail.DataStore.DataStoreRatingTargetInt>.Sort
	|
	|-RVA: 0x37A1D30 Offset: 0x37A1E31 VA: 0x37A1D30
	|-ArraySortHelper<Detail.Ranking.RankingCachedResultInt>.Sort
	|
	|-RVA: 0x37A3A00 Offset: 0x37A3B01 VA: 0x37A3A00
	|-ArraySortHelper<Detail.Ranking.RankingOrderParamInt>.Sort
	|
	|-RVA: 0x37A51E0 Offset: 0x37A52E1 VA: 0x37A51E0
	|-ArraySortHelper<Detail.Ranking.RankingRankDataInt>.Sort
	|
	|-RVA: 0x37A6EF0 Offset: 0x37A6FF1 VA: 0x37A6EF0
	|-ArraySortHelper<Detail.Ranking2.Ranking2ChartInfoInt>.Sort
	|
	|-RVA: 0x37A8FA0 Offset: 0x37A90A1 VA: 0x37A8FA0
	|-ArraySortHelper<Detail.Ranking2.Ranking2RankDataInt>.Sort
	|
	|-RVA: 0x37AACB0 Offset: 0x37AADB1 VA: 0x37AACB0
	|-ArraySortHelper<Detail.Ranking2.Ranking2ScoreDataInt>.Sort
	|
	|-RVA: 0x37AC490 Offset: 0x37AC591 VA: 0x37AC490
	|-ArraySortHelper<Detail.Screening.ScreeningContextInfoInt>.Sort
	|
	|-RVA: 0x37ADE50 Offset: 0x37ADF51 VA: 0x37ADE50
	|-ArraySortHelper<Detail.Subscriber.SubscriberContentInt>.Sort
	|
	|-RVA: 0x37AFCF0 Offset: 0x37AFDF1 VA: 0x37AFCF0
	|-ArraySortHelper<Detail.Subscriber.SubscriberGetContentParamInt>.Sort
	|
	|-RVA: 0x32BDFE0 Offset: 0x32BE0E1 VA: 0x32BDFE0
	|-ArraySortHelper<Detail.Subscriber.SubscriberUserStatusInfoInt>.Sort
	|
	|-RVA: 0x32BFB20 Offset: 0x32BFC21 VA: 0x32BFB20
	|-ArraySortHelper<Detail.Subscriber.SubscriberUserStatusParamInt>.Sort
	|
	|-RVA: 0x32C14A0 Offset: 0x32C15A1 VA: 0x32C14A0
	|-ArraySortHelper<Detail.Utility.IntegerSettings>.Sort
	|
	|-RVA: 0x32C2B30 Offset: 0x32C2C31 VA: 0x32C2B30
	|-ArraySortHelper<Detail.Utility.UniqueIdInfoInt>.Sort
	|
	|-RVA: 0x32C4310 Offset: 0x32C4411 VA: 0x32C4310
	|-ArraySortHelper<MapHistory.Rewind.LatestInspectorData>.Sort
	|
	|-RVA: 0x32C5B80 Offset: 0x32C5C81 VA: 0x32C5B80
	|-ArraySortHelper<MapHistory.Rewind.WorkTerrainData>.Sort
	|
	|-RVA: 0x32C73F0 Offset: 0x32C74F1 VA: 0x32C73F0
	|-ArraySortHelper<MapKillBonus.Work.Pos>.Sort
	|
	|-RVA: 0x32C8B40 Offset: 0x32C8C41 VA: 0x32C8B40
	|-ArraySortHelper<MapSkill.AroundCalculator.Result>.Sort
	|
	|-RVA: 0x32CA3E0 Offset: 0x32CA4E1 VA: 0x32CA3E0
	|-ArraySortHelper<TargetPositionCache.CacheCurve.Item>.Sort
	|
	|-RVA: 0x32CBF10 Offset: 0x32CC011 VA: 0x32CBF10
	|-ArraySortHelper<TargetPositionCache.CacheEntry.RecordingItem>.Sort
	*/

	// RVA: -1 Offset: -1
	public static int BinarySearch(T[] array, int index, int length, T value, IComparer<T> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FFD0A0 Offset: 0x1FFD1A1 VA: 0x1FFD0A0
	|-ArraySortHelper<IntervalTree.Entry<object>>.BinarySearch
	|
	|-RVA: 0x1FFEAE0 Offset: 0x1FFEBE1 VA: 0x1FFEAE0
	|-ArraySortHelper<KeyValuePair<DateTime, object>>.BinarySearch
	|
	|-RVA: 0x2000350 Offset: 0x2000451 VA: 0x2000350
	|-ArraySortHelper<KeyValuePair<int, object>>.BinarySearch
	|
	|-RVA: 0x2001BC0 Offset: 0x2001CC1 VA: 0x2001BC0
	|-ArraySortHelper<KeyValuePair<object, ValueTuple<int, DateTime, object>>>.BinarySearch
	|
	|-RVA: 0x2003600 Offset: 0x2003701 VA: 0x2003600
	|-ArraySortHelper<KeyValuePair<object, object>>.BinarySearch
	|
	|-RVA: 0x2004EA0 Offset: 0x2004FA1 VA: 0x2004EA0
	|-ArraySortHelper<CommonBattleSequence.Reliance<object>>.BinarySearch
	|
	|-RVA: 0x20068E0 Offset: 0x20069E1 VA: 0x20068E0
	|-ArraySortHelper<RenderGraphResourcePool.ResourceLogInfo<object>>.BinarySearch
	|
	|-RVA: 0x2008180 Offset: 0x2008281 VA: 0x2008180
	|-ArraySortHelper<ValueTuple<int, object>>.BinarySearch
	|
	|-RVA: 0x20099F0 Offset: 0x2009AF1 VA: 0x20099F0
	|-ArraySortHelper<ValueTuple<Int32Enum, int>>.BinarySearch
	|
	|-RVA: 0x200B080 Offset: 0x200B181 VA: 0x200B080
	|-ArraySortHelper<ValueTuple<object, ValueTuple<object, int>>>.BinarySearch
	|
	|-RVA: 0x200CAC0 Offset: 0x200CBC1 VA: 0x200CAC0
	|-ArraySortHelper<ValueTuple<object, int>>.BinarySearch
	|
	|-RVA: 0x200E360 Offset: 0x200E461 VA: 0x200E360
	|-ArraySortHelper<ValueTuple<Vector3, float>>.BinarySearch
	|
	|-RVA: 0x200FD20 Offset: 0x200FE21 VA: 0x200FD20
	|-ArraySortHelper<ValueTuple<object, Int32Enum, int>>.BinarySearch
	|
	|-RVA: 0x3A7FF10 Offset: 0x3A80011 VA: 0x3A7FF10
	|-ArraySortHelper<ValueTuple<object, int, int, int>>.BinarySearch
	|
	|-RVA: 0x3A81950 Offset: 0x3A81A51 VA: 0x3A81950
	|-ArraySortHelper<AnimatorClipInfo>.BinarySearch
	|
	|-RVA: 0x3A82FE0 Offset: 0x3A830E1 VA: 0x3A82FE0
	|-ArraySortHelper<AsyncOperationHandle>.BinarySearch
	|
	|-RVA: 0x3A84A20 Offset: 0x3A84B21 VA: 0x3A84A20
	|-ArraySortHelper<BoneWeight>.BinarySearch
	|
	|-RVA: 0x3A863E0 Offset: 0x3A864E1 VA: 0x3A863E0
	|-ArraySortHelper<bool>.BinarySearch
	|
	|-RVA: 0x3A87AC0 Offset: 0x3A87BC1 VA: 0x3A87AC0
	|-ArraySortHelper<byte>.BinarySearch
	|
	|-RVA: 0x3A89150 Offset: 0x3A89251 VA: 0x3A89150
	|-ArraySortHelper<CameraInfo>.BinarySearch
	|
	|-RVA: 0x3A8A9C0 Offset: 0x3A8AAC1 VA: 0x3A8A9C0
	|-ArraySortHelper<char>.BinarySearch
	|
	|-RVA: 0x3A8C050 Offset: 0x3A8C151 VA: 0x3A8C050
	|-ArraySortHelper<Color>.BinarySearch
	|
	|-RVA: 0x3A8DA10 Offset: 0x3A8DB11 VA: 0x3A8DA10
	|-ArraySortHelper<Color32>.BinarySearch
	|
	|-RVA: 0x3A8F0A0 Offset: 0x3A8F1A1 VA: 0x3A8F0A0
	|-ArraySortHelper<ConstraintSource>.BinarySearch
	|
	|-RVA: 0x3A90940 Offset: 0x3A90A41 VA: 0x3A90940
	|-ArraySortHelper<ContourVertex>.BinarySearch
	|
	|-RVA: 0x3A92380 Offset: 0x3A92481 VA: 0x3A92380
	|-ArraySortHelper<DataStoreRatingInfo>.BinarySearch
	|
	|-RVA: 0x3A93D00 Offset: 0x3A93E01 VA: 0x3A93D00
	|-ArraySortHelper<DataStoreResult>.BinarySearch
	|
	|-RVA: 0x3A95390 Offset: 0x3A95491 VA: 0x3A95390
	|-ArraySortHelper<DateTime>.BinarySearch
	|
	|-RVA: 0x3A96A20 Offset: 0x3A96B21 VA: 0x3A96A20
	|-ArraySortHelper<DateTimeOffset>.BinarySearch
	|
	|-RVA: 0x3A98200 Offset: 0x3A98301 VA: 0x3A98200
	|-ArraySortHelper<Decimal>.BinarySearch
	|
	|-RVA: 0x3A999E0 Offset: 0x3A99AE1 VA: 0x3A999E0
	|-ArraySortHelper<DiagnosticEvent>.BinarySearch
	|
	|-RVA: 0x3A9B5E0 Offset: 0x3A9B6E1 VA: 0x3A9B5E0
	|-ArraySortHelper<double>.BinarySearch
	|
	|-RVA: 0x3A9CC80 Offset: 0x3A9CD81 VA: 0x3A9CC80
	|-ArraySortHelper<Friend>.BinarySearch
	|
	|-RVA: 0x3A9E690 Offset: 0x3A9E791 VA: 0x3A9E690
	|-ArraySortHelper<GlyphRect>.BinarySearch
	|
	|-RVA: 0x3A9FE70 Offset: 0x3A9FF71 VA: 0x3A9FE70
	|-ArraySortHelper<short>.BinarySearch
	|
	|-RVA: 0x3AA1500 Offset: 0x3AA1601 VA: 0x3AA1500
	|-ArraySortHelper<int>.BinarySearch
	|
	|-RVA: 0x3AA2B90 Offset: 0x3AA2C91 VA: 0x3AA2B90
	|-ArraySortHelper<Int32Enum>.BinarySearch
	|
	|-RVA: 0x3AA4220 Offset: 0x3AA4321 VA: 0x3AA4220
	|-ArraySortHelper<long>.BinarySearch
	|
	|-RVA: 0x3AA58B0 Offset: 0x3AA59B1 VA: 0x3AA58B0
	|-ArraySortHelper<IntPtr>.BinarySearch
	|
	|-RVA: 0x3AA6F40 Offset: 0x3AA7041 VA: 0x3AA6F40
	|-ArraySortHelper<InterpretedFrameInfo>.BinarySearch
	|
	|-RVA: 0x3AA87E0 Offset: 0x3AA88E1 VA: 0x3AA87E0
	|-ArraySortHelper<IntervalTreeNode>.BinarySearch
	|
	|-RVA: 0x3AAA160 Offset: 0x3AAA261 VA: 0x3AAA160
	|-ArraySortHelper<LengthLimitProperties>.BinarySearch
	|
	|-RVA: 0x3AAB7F0 Offset: 0x3AAB8F1 VA: 0x3AAB7F0
	|-ArraySortHelper<MapPos>.BinarySearch
	|
	|-RVA: 0x3AACE80 Offset: 0x3AACF81 VA: 0x3AACE80
	|-ArraySortHelper<Matrix4x4>.BinarySearch
	|
	|-RVA: 0x394F300 Offset: 0x394F401 VA: 0x394F300
	|-ArraySortHelper<object>.BinarySearch
	|
	|-RVA: 0x39509F0 Offset: 0x3950AF1 VA: 0x39509F0
	|-ArraySortHelper<ObjectInitializationData>.BinarySearch
	|
	|-RVA: 0x39525F0 Offset: 0x39526F1 VA: 0x39525F0
	|-ArraySortHelper<PlayableBinding>.BinarySearch
	|
	|-RVA: 0x3954030 Offset: 0x3954131 VA: 0x3954030
	|-ArraySortHelper<PlayerLoopSystem>.BinarySearch
	|
	|-RVA: 0x3955C00 Offset: 0x3955D01 VA: 0x3955C00
	|-ArraySortHelper<PlayerLoopSystemInternal>.BinarySearch
	|
	|-RVA: 0x39577D0 Offset: 0x39578D1 VA: 0x39577D0
	|-ArraySortHelper<RangePositionInfo>.BinarySearch
	|
	|-RVA: 0x3959070 Offset: 0x3959171 VA: 0x3959070
	|-ArraySortHelper<Ranking2ChartInfoInput>.BinarySearch
	|
	|-RVA: 0x395A700 Offset: 0x395A801 VA: 0x395A700
	|-ArraySortHelper<RaycastHit>.BinarySearch
	|
	|-RVA: 0x395C400 Offset: 0x395C501 VA: 0x395C400
	|-ArraySortHelper<RaycastHit2D>.BinarySearch
	|
	|-RVA: 0x395E010 Offset: 0x395E111 VA: 0x395E010
	|-ArraySortHelper<RaycastResult>.BinarySearch
	|
	|-RVA: 0x395FF40 Offset: 0x3960041 VA: 0x395FF40
	|-ArraySortHelper<Rect>.BinarySearch
	|
	|-RVA: 0x3961900 Offset: 0x3961A01 VA: 0x3961900
	|-ArraySortHelper<RendererListHandle>.BinarySearch
	|
	|-RVA: 0x3962F90 Offset: 0x3963091 VA: 0x3962F90
	|-ArraySortHelper<ResourceHandle>.BinarySearch
	|
	|-RVA: 0x3964620 Offset: 0x3964721 VA: 0x3964620
	|-ArraySortHelper<sbyte>.BinarySearch
	|
	|-RVA: 0x3965CB0 Offset: 0x3965DB1 VA: 0x3965CB0
	|-ArraySortHelper<ShaderTagId>.BinarySearch
	|
	|-RVA: 0x3967340 Offset: 0x3967441 VA: 0x3967340
	|-ArraySortHelper<float>.BinarySearch
	|
	|-RVA: 0x39689E0 Offset: 0x3968AE1 VA: 0x39689E0
	|-ArraySortHelper<SphericalHarmonicsL2>.BinarySearch
	|
	|-RVA: 0x396AE30 Offset: 0x396AF31 VA: 0x396AE30
	|-ArraySortHelper<SubMeshDescriptor>.BinarySearch
	|
	|-RVA: 0x396C970 Offset: 0x396CA71 VA: 0x396C970
	|-ArraySortHelper<TablePair>.BinarySearch
	|
	|-RVA: 0x396E210 Offset: 0x396E311 VA: 0x396E210
	|-ArraySortHelper<TimeSpan>.BinarySearch
	|
	|-RVA: 0x396F8A0 Offset: 0x396F9A1 VA: 0x396F8A0
	|-ArraySortHelper<UICharInfo>.BinarySearch
	|
	|-RVA: 0x39711D0 Offset: 0x39712D1 VA: 0x39711D0
	|-ArraySortHelper<UILineInfo>.BinarySearch
	|
	|-RVA: 0x39729B0 Offset: 0x3972AB1 VA: 0x39729B0
	|-ArraySortHelper<UIVertex>.BinarySearch
	|
	|-RVA: 0x3974E00 Offset: 0x3974F01 VA: 0x3974E00
	|-ArraySortHelper<ushort>.BinarySearch
	|
	|-RVA: 0x3976490 Offset: 0x3976591 VA: 0x3976490
	|-ArraySortHelper<uint>.BinarySearch
	|
	|-RVA: 0x3977B20 Offset: 0x3977C21 VA: 0x3977B20
	|-ArraySortHelper<ulong>.BinarySearch
	|
	|-RVA: 0x39791B0 Offset: 0x39792B1 VA: 0x39791B0
	|-ArraySortHelper<Vector2>.BinarySearch
	|
	|-RVA: 0x397A980 Offset: 0x397AA81 VA: 0x397A980
	|-ArraySortHelper<Vector3>.BinarySearch
	|
	|-RVA: 0x397C2B0 Offset: 0x397C3B1 VA: 0x397C2B0
	|-ArraySortHelper<Vector4>.BinarySearch
	|
	|-RVA: 0x397DC70 Offset: 0x397DD71 VA: 0x397DC70
	|-ArraySortHelper<VertexAttributeDescriptor>.BinarySearch
	|
	|-RVA: 0x397F450 Offset: 0x397F551 VA: 0x397F450
	|-ArraySortHelper<X509ChainStatus>.BinarySearch
	|
	|-RVA: 0x391E6F0 Offset: 0x391E7F1 VA: 0x391E6F0
	|-ArraySortHelper<XRView>.BinarySearch
	|
	|-RVA: 0x3920210 Offset: 0x3920311 VA: 0x3920210
	|-ArraySortHelper<AmiiboSequence.GainItemData>.BinarySearch
	|
	|-RVA: 0x3921AB0 Offset: 0x3921BB1 VA: 0x3921AB0
	|-ArraySortHelper<AnimationOutputWeightProcessor.WeightInfo>.BinarySearch
	|
	|-RVA: 0x39235F0 Offset: 0x39236F1 VA: 0x39235F0
	|-ArraySortHelper<ArenaOrderSequence.GodInfo>.BinarySearch
	|
	|-RVA: 0x3924E90 Offset: 0x3924F91 VA: 0x3924E90
	|-ArraySortHelper<BattleInfo.SupportData>.BinarySearch
	|
	|-RVA: 0x3926730 Offset: 0x3926831 VA: 0x3926730
	|-ArraySortHelper<BeforeRenderHelper.OrderBlock>.BinarySearch
	|
	|-RVA: 0x3927FA0 Offset: 0x39280A1 VA: 0x3927FA0
	|-ArraySortHelper<Camera.RenderRequest>.BinarySearch
	|
	|-RVA: 0x39299F0 Offset: 0x3929AF1 VA: 0x39299F0
	|-ArraySortHelper<CameraState.CustomBlendable>.BinarySearch
	|
	|-RVA: 0x392B290 Offset: 0x392B391 VA: 0x392B290
	|-ArraySortHelper<CinemachineClearShot.Pair>.BinarySearch
	|
	|-RVA: 0x392C920 Offset: 0x392CA21 VA: 0x392C920
	|-ArraySortHelper<CinemachineStateDrivenCamera.HashPair>.BinarySearch
	|
	|-RVA: 0x392DFB0 Offset: 0x392E0B1 VA: 0x392DFB0
	|-ArraySortHelper<DeferredTiler.PrePunctualLight>.BinarySearch
	|
	|-RVA: 0x392F970 Offset: 0x392FA71 VA: 0x392F970
	|-ArraySortHelper<DelayedActionManager.DelegateInfo>.BinarySearch
	|
	|-RVA: 0x39313C0 Offset: 0x39314C1 VA: 0x39313C0
	|-ArraySortHelper<Detail.AsyncResultInt>.BinarySearch
	|
	|-RVA: 0x3932F00 Offset: 0x3933001 VA: 0x3932F00
	|-ArraySortHelper<Detail.CppArray>.BinarySearch
	|
	|-RVA: 0x39346E0 Offset: 0x39347E1 VA: 0x39346E0
	|-ArraySortHelper<Detail.NotificationEventInt>.BinarySearch
	|
	|-RVA: 0x3936220 Offset: 0x3936321 VA: 0x3936220
	|-ArraySortHelper<DragonRideTargetGroup.ChainParam>.BinarySearch
	|
	|-RVA: 0x3937AC0 Offset: 0x3937BC1 VA: 0x3937AC0
	|-ArraySortHelper<GmapPathAdjuster.TargetModel>.BinarySearch
	|
	|-RVA: 0x3939500 Offset: 0x3939601 VA: 0x3939500
	|-ArraySortHelper<GmapSpotAdjuster.TargetModel>.BinarySearch
	|
	|-RVA: 0x393AF40 Offset: 0x393B041 VA: 0x393AF40
	|-ArraySortHelper<HubFastTravel.Location>.BinarySearch
	|
	|-RVA: 0x393C980 Offset: 0x393CA81 VA: 0x393C980
	|-ArraySortHelper<HubLensFlare.Flare>.BinarySearch
	|
	|-RVA: 0x393E580 Offset: 0x393E681 VA: 0x393E580
	|-ArraySortHelper<InventoryPoolItemMenuContent.KindBgNameClass>.BinarySearch
	|
	|-RVA: 0x393FDF0 Offset: 0x393FEF1 VA: 0x393FDF0
	|-ArraySortHelper<Map.Pos>.BinarySearch
	|
	|-RVA: 0x3941480 Offset: 0x3941581 VA: 0x3941480
	|-ArraySortHelper<MapImage.BackupTerrain>.BinarySearch
	|
	|-RVA: 0x3942C60 Offset: 0x3942D61 VA: 0x3942C60
	|-ArraySortHelper<MapImageRange.Pos>.BinarySearch
	|
	|-RVA: 0x39443B0 Offset: 0x39444B1 VA: 0x39443B0
	|-ArraySortHelper<MapMind.Target>.BinarySearch
	|
	|-RVA: 0x3945DF0 Offset: 0x3945EF1 VA: 0x3945DF0
	|-ArraySortHelper<MapPanelDebug.Entity>.BinarySearch
	|
	|-RVA: 0x3947770 Offset: 0x3947871 VA: 0x3947770
	|-ArraySortHelper<NexRanking.Data>.BinarySearch
	|
	|-RVA: 0x3948E00 Offset: 0x3948F01 VA: 0x3948E00
	|-ArraySortHelper<NexVersus.RatingData>.BinarySearch
	|
	|-RVA: 0x394A5E0 Offset: 0x394A6E1 VA: 0x394A5E0
	|-ArraySortHelper<PackedPlayModeBuildLogs.RuntimeBuildLog>.BinarySearch
	|
	|-RVA: 0x394BE50 Offset: 0x394BF51 VA: 0x394BE50
	|-ArraySortHelper<ParticleSystem.Particle>.BinarySearch
	|
	|-RVA: 0x394D8C0 Offset: 0x394D9C1 VA: 0x394D8C0
	|-ArraySortHelper<ProfileCard.SortieCount>.BinarySearch
	|
	|-RVA: 0x377EE50 Offset: 0x377EF51 VA: 0x377EE50
	|-ArraySortHelper<RangeData.Offset>.BinarySearch
	|
	|-RVA: 0x37804E0 Offset: 0x37805E1 VA: 0x37804E0
	|-ArraySortHelper<RenderGraphDebugData.PassDebugData>.BinarySearch
	|
	|-RVA: 0x3781F20 Offset: 0x3782021 VA: 0x3781F20
	|-ArraySortHelper<RenderGraphDebugData.ResourceDebugData>.BinarySearch
	|
	|-RVA: 0x3783AF0 Offset: 0x3783BF1 VA: 0x3783AF0
	|-ArraySortHelper<RingCleaningUnitSelectMenu.GodParam>.BinarySearch
	|
	|-RVA: 0x3785390 Offset: 0x3785491 VA: 0x3785390
	|-ArraySortHelper<ShadowUtility.Edge>.BinarySearch
	|
	|-RVA: 0x3786EC0 Offset: 0x3786FC1 VA: 0x3786EC0
	|-ArraySortHelper<SkillArray.Entity>.BinarySearch
	|
	|-RVA: 0x3788550 Offset: 0x3788651 VA: 0x3788550
	|-ArraySortHelper<TexturePacker_JsonArray.Frame>.BinarySearch
	|
	|-RVA: 0x378A2D0 Offset: 0x378A3D1 VA: 0x378A2D0
	|-ArraySortHelper<TimeNotificationBehaviour.NotificationEntry>.BinarySearch
	|
	|-RVA: 0x378BD20 Offset: 0x378BE21 VA: 0x378BD20
	|-ArraySortHelper<UnitySynchronizationContext.WorkRequest>.BinarySearch
	|
	|-RVA: 0x378D760 Offset: 0x378D861 VA: 0x378D760
	|-ArraySortHelper<XmlSchemaObjectTable.XmlSchemaObjectEntry>.BinarySearch
	|
	|-RVA: 0x378F000 Offset: 0x378F101 VA: 0x378F000
	|-ArraySortHelper<AIThink.EnchantThink.ItemInfo>.BinarySearch
	|
	|-RVA: 0x3790750 Offset: 0x3790851 VA: 0x3790750
	|-ArraySortHelper<AssetBundleBuildMap.AssetBundleEntry.AssetPathString>.BinarySearch
	|
	|-RVA: 0x3791FF0 Offset: 0x37920F1 VA: 0x3791FF0
	|-ArraySortHelper<Detail.DataStore.DataStoreChangeMetaParamInt>.BinarySearch
	|
	|-RVA: 0x3793BB0 Offset: 0x3793CB1 VA: 0x3793BB0
	|-ArraySortHelper<Detail.DataStore.DataStoreDeleteParamInt>.BinarySearch
	|
	|-RVA: 0x3795390 Offset: 0x3795491 VA: 0x3795390
	|-ArraySortHelper<Detail.DataStore.DataStoreGetMetaParamInt>.BinarySearch
	|
	|-RVA: 0x3796ED0 Offset: 0x3796FD1 VA: 0x3796ED0
	|-ArraySortHelper<Detail.DataStore.DataStoreMetaInfoInt>.BinarySearch
	|
	|-RVA: 0x3798970 Offset: 0x3798A71 VA: 0x3798970
	|-ArraySortHelper<Detail.DataStore.DataStorePasswordInfoInt>.BinarySearch
	|
	|-RVA: 0x379A2F0 Offset: 0x379A3F1 VA: 0x379A2F0
	|-ArraySortHelper<Detail.DataStore.DataStorePersistenceInfoInt>.BinarySearch
	|
	|-RVA: 0x379BC70 Offset: 0x379BD71 VA: 0x379BC70
	|-ArraySortHelper<Detail.DataStore.DataStorePreparePostParamInt>.BinarySearch
	|
	|-RVA: 0x379D6E0 Offset: 0x379D7E1 VA: 0x379D6E0
	|-ArraySortHelper<Detail.DataStore.DataStoreRateObjectParamInt>.BinarySearch
	|
	|-RVA: 0x379EEC0 Offset: 0x379EFC1 VA: 0x379EEC0
	|-ArraySortHelper<Detail.DataStore.DataStoreRatingInitParamInt>.BinarySearch
	|
	|-RVA: 0x37A0880 Offset: 0x37A0981 VA: 0x37A0880
	|-ArraySortHelper<Detail.DataStore.DataStoreRatingTargetInt>.BinarySearch
	|
	|-RVA: 0x37A2060 Offset: 0x37A2161 VA: 0x37A2060
	|-ArraySortHelper<Detail.Ranking.RankingCachedResultInt>.BinarySearch
	|
	|-RVA: 0x37A3D30 Offset: 0x37A3E31 VA: 0x37A3D30
	|-ArraySortHelper<Detail.Ranking.RankingOrderParamInt>.BinarySearch
	|
	|-RVA: 0x37A5510 Offset: 0x37A5611 VA: 0x37A5510
	|-ArraySortHelper<Detail.Ranking.RankingRankDataInt>.BinarySearch
	|
	|-RVA: 0x37A7220 Offset: 0x37A7321 VA: 0x37A7220
	|-ArraySortHelper<Detail.Ranking2.Ranking2ChartInfoInt>.BinarySearch
	|
	|-RVA: 0x37A92D0 Offset: 0x37A93D1 VA: 0x37A92D0
	|-ArraySortHelper<Detail.Ranking2.Ranking2RankDataInt>.BinarySearch
	|
	|-RVA: 0x37AAFE0 Offset: 0x37AB0E1 VA: 0x37AAFE0
	|-ArraySortHelper<Detail.Ranking2.Ranking2ScoreDataInt>.BinarySearch
	|
	|-RVA: 0x37AC7C0 Offset: 0x37AC8C1 VA: 0x37AC7C0
	|-ArraySortHelper<Detail.Screening.ScreeningContextInfoInt>.BinarySearch
	|
	|-RVA: 0x37AE180 Offset: 0x37AE281 VA: 0x37AE180
	|-ArraySortHelper<Detail.Subscriber.SubscriberContentInt>.BinarySearch
	|
	|-RVA: 0x37B0020 Offset: 0x37B0121 VA: 0x37B0020
	|-ArraySortHelper<Detail.Subscriber.SubscriberGetContentParamInt>.BinarySearch
	|
	|-RVA: 0x32BE310 Offset: 0x32BE411 VA: 0x32BE310
	|-ArraySortHelper<Detail.Subscriber.SubscriberUserStatusInfoInt>.BinarySearch
	|
	|-RVA: 0x32BFE50 Offset: 0x32BFF51 VA: 0x32BFE50
	|-ArraySortHelper<Detail.Subscriber.SubscriberUserStatusParamInt>.BinarySearch
	|
	|-RVA: 0x32C17D0 Offset: 0x32C18D1 VA: 0x32C17D0
	|-ArraySortHelper<Detail.Utility.IntegerSettings>.BinarySearch
	|
	|-RVA: 0x32C2E60 Offset: 0x32C2F61 VA: 0x32C2E60
	|-ArraySortHelper<Detail.Utility.UniqueIdInfoInt>.BinarySearch
	|
	|-RVA: 0x32C4640 Offset: 0x32C4741 VA: 0x32C4640
	|-ArraySortHelper<MapHistory.Rewind.LatestInspectorData>.BinarySearch
	|
	|-RVA: 0x32C5EB0 Offset: 0x32C5FB1 VA: 0x32C5EB0
	|-ArraySortHelper<MapHistory.Rewind.WorkTerrainData>.BinarySearch
	|
	|-RVA: 0x32C7720 Offset: 0x32C7821 VA: 0x32C7720
	|-ArraySortHelper<MapKillBonus.Work.Pos>.BinarySearch
	|
	|-RVA: 0x32C8E70 Offset: 0x32C8F71 VA: 0x32C8E70
	|-ArraySortHelper<MapSkill.AroundCalculator.Result>.BinarySearch
	|
	|-RVA: 0x32CA710 Offset: 0x32CA811 VA: 0x32CA710
	|-ArraySortHelper<TargetPositionCache.CacheCurve.Item>.BinarySearch
	|
	|-RVA: 0x32CC240 Offset: 0x32CC341 VA: 0x32CC240
	|-ArraySortHelper<TargetPositionCache.CacheEntry.RecordingItem>.BinarySearch
	*/

	// RVA: -1 Offset: -1
	internal static void Sort(T[] keys, int index, int length, Comparison<T> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FFD280 Offset: 0x1FFD381 VA: 0x1FFD280
	|-ArraySortHelper<IntervalTree.Entry<object>>.Sort
	|
	|-RVA: 0x1FFECC0 Offset: 0x1FFEDC1 VA: 0x1FFECC0
	|-ArraySortHelper<KeyValuePair<DateTime, object>>.Sort
	|
	|-RVA: 0x2000530 Offset: 0x2000631 VA: 0x2000530
	|-ArraySortHelper<KeyValuePair<int, object>>.Sort
	|
	|-RVA: 0x2001DA0 Offset: 0x2001EA1 VA: 0x2001DA0
	|-ArraySortHelper<KeyValuePair<object, ValueTuple<int, DateTime, object>>>.Sort
	|
	|-RVA: 0x20037E0 Offset: 0x20038E1 VA: 0x20037E0
	|-ArraySortHelper<KeyValuePair<object, object>>.Sort
	|
	|-RVA: 0x2005080 Offset: 0x2005181 VA: 0x2005080
	|-ArraySortHelper<CommonBattleSequence.Reliance<object>>.Sort
	|
	|-RVA: 0x2006AC0 Offset: 0x2006BC1 VA: 0x2006AC0
	|-ArraySortHelper<RenderGraphResourcePool.ResourceLogInfo<object>>.Sort
	|
	|-RVA: 0x2008360 Offset: 0x2008461 VA: 0x2008360
	|-ArraySortHelper<ValueTuple<int, object>>.Sort
	|
	|-RVA: 0x2009BC0 Offset: 0x2009CC1 VA: 0x2009BC0
	|-ArraySortHelper<ValueTuple<Int32Enum, int>>.Sort
	|
	|-RVA: 0x200B260 Offset: 0x200B361 VA: 0x200B260
	|-ArraySortHelper<ValueTuple<object, ValueTuple<object, int>>>.Sort
	|
	|-RVA: 0x200CCA0 Offset: 0x200CDA1 VA: 0x200CCA0
	|-ArraySortHelper<ValueTuple<object, int>>.Sort
	|
	|-RVA: 0x200E560 Offset: 0x200E661 VA: 0x200E560
	|-ArraySortHelper<ValueTuple<Vector3, float>>.Sort
	|
	|-RVA: 0x200FF00 Offset: 0x2010001 VA: 0x200FF00
	|-ArraySortHelper<ValueTuple<object, Int32Enum, int>>.Sort
	|
	|-RVA: 0x3A800F0 Offset: 0x3A801F1 VA: 0x3A800F0
	|-ArraySortHelper<ValueTuple<object, int, int, int>>.Sort
	|
	|-RVA: 0x3A81B20 Offset: 0x3A81C21 VA: 0x3A81B20
	|-ArraySortHelper<AnimatorClipInfo>.Sort
	|
	|-RVA: 0x3A831C0 Offset: 0x3A832C1 VA: 0x3A831C0
	|-ArraySortHelper<AsyncOperationHandle>.Sort
	|
	|-RVA: 0x3A84C00 Offset: 0x3A84D01 VA: 0x3A84C00
	|-ArraySortHelper<BoneWeight>.Sort
	|
	|-RVA: 0x3A865B0 Offset: 0x3A866B1 VA: 0x3A865B0
	|-ArraySortHelper<bool>.Sort
	|
	|-RVA: 0x3A87C90 Offset: 0x3A87D91 VA: 0x3A87C90
	|-ArraySortHelper<byte>.Sort
	|
	|-RVA: 0x3A89330 Offset: 0x3A89431 VA: 0x3A89330
	|-ArraySortHelper<CameraInfo>.Sort
	|
	|-RVA: 0x3A8AB90 Offset: 0x3A8AC91 VA: 0x3A8AB90
	|-ArraySortHelper<char>.Sort
	|
	|-RVA: 0x3A8C250 Offset: 0x3A8C351 VA: 0x3A8C250
	|-ArraySortHelper<Color>.Sort
	|
	|-RVA: 0x3A8DBE0 Offset: 0x3A8DCE1 VA: 0x3A8DBE0
	|-ArraySortHelper<Color32>.Sort
	|
	|-RVA: 0x3A8F280 Offset: 0x3A8F381 VA: 0x3A8F280
	|-ArraySortHelper<ConstraintSource>.Sort
	|
	|-RVA: 0x3A90B20 Offset: 0x3A90C21 VA: 0x3A90B20
	|-ArraySortHelper<ContourVertex>.Sort
	|
	|-RVA: 0x3A92560 Offset: 0x3A92661 VA: 0x3A92560
	|-ArraySortHelper<DataStoreRatingInfo>.Sort
	|
	|-RVA: 0x3A93ED0 Offset: 0x3A93FD1 VA: 0x3A93ED0
	|-ArraySortHelper<DataStoreResult>.Sort
	|
	|-RVA: 0x3A95560 Offset: 0x3A95661 VA: 0x3A95560
	|-ArraySortHelper<DateTime>.Sort
	|
	|-RVA: 0x3A96C00 Offset: 0x3A96D01 VA: 0x3A96C00
	|-ArraySortHelper<DateTimeOffset>.Sort
	|
	|-RVA: 0x3A983E0 Offset: 0x3A984E1 VA: 0x3A983E0
	|-ArraySortHelper<Decimal>.Sort
	|
	|-RVA: 0x3A99BD0 Offset: 0x3A99CD1 VA: 0x3A99BD0
	|-ArraySortHelper<DiagnosticEvent>.Sort
	|
	|-RVA: 0x3A9B7C0 Offset: 0x3A9B8C1 VA: 0x3A9B7C0
	|-ArraySortHelper<double>.Sort
	|
	|-RVA: 0x3A9CE60 Offset: 0x3A9CF61 VA: 0x3A9CE60
	|-ArraySortHelper<Friend>.Sort
	|
	|-RVA: 0x3A9E870 Offset: 0x3A9E971 VA: 0x3A9E870
	|-ArraySortHelper<GlyphRect>.Sort
	|
	|-RVA: 0x3AA0040 Offset: 0x3AA0141 VA: 0x3AA0040
	|-ArraySortHelper<short>.Sort
	|
	|-RVA: 0x3AA16D0 Offset: 0x3AA17D1 VA: 0x3AA16D0
	|-ArraySortHelper<int>.Sort
	|
	|-RVA: 0x3AA2D60 Offset: 0x3AA2E61 VA: 0x3AA2D60
	|-ArraySortHelper<Int32Enum>.Sort
	|
	|-RVA: 0x3AA43F0 Offset: 0x3AA44F1 VA: 0x3AA43F0
	|-ArraySortHelper<long>.Sort
	|
	|-RVA: 0x3AA5A80 Offset: 0x3AA5B81 VA: 0x3AA5A80
	|-ArraySortHelper<IntPtr>.Sort
	|
	|-RVA: 0x3AA7120 Offset: 0x3AA7221 VA: 0x3AA7120
	|-ArraySortHelper<InterpretedFrameInfo>.Sort
	|
	|-RVA: 0x3AA89C0 Offset: 0x3AA8AC1 VA: 0x3AA89C0
	|-ArraySortHelper<IntervalTreeNode>.Sort
	|
	|-RVA: 0x3AAA330 Offset: 0x3AAA431 VA: 0x3AAA330
	|-ArraySortHelper<LengthLimitProperties>.Sort
	|
	|-RVA: 0x3AAB9C0 Offset: 0x3AABAC1 VA: 0x3AAB9C0
	|-ArraySortHelper<MapPos>.Sort
	|
	|-RVA: 0x3AAD080 Offset: 0x3AAD181 VA: 0x3AAD080
	|-ArraySortHelper<Matrix4x4>.Sort
	|
	|-RVA: 0x394F4D0 Offset: 0x394F5D1 VA: 0x394F4D0
	|-ArraySortHelper<object>.Sort
	|
	|-RVA: 0x3950BE0 Offset: 0x3950CE1 VA: 0x3950BE0
	|-ArraySortHelper<ObjectInitializationData>.Sort
	|
	|-RVA: 0x39527D0 Offset: 0x39528D1 VA: 0x39527D0
	|-ArraySortHelper<PlayableBinding>.Sort
	|
	|-RVA: 0x3954220 Offset: 0x3954321 VA: 0x3954220
	|-ArraySortHelper<PlayerLoopSystem>.Sort
	|
	|-RVA: 0x3955DF0 Offset: 0x3955EF1 VA: 0x3955DF0
	|-ArraySortHelper<PlayerLoopSystemInternal>.Sort
	|
	|-RVA: 0x39579B0 Offset: 0x3957AB1 VA: 0x39579B0
	|-ArraySortHelper<RangePositionInfo>.Sort
	|
	|-RVA: 0x3959240 Offset: 0x3959341 VA: 0x3959240
	|-ArraySortHelper<Ranking2ChartInfoInput>.Sort
	|
	|-RVA: 0x395A900 Offset: 0x395AA01 VA: 0x395A900
	|-ArraySortHelper<RaycastHit>.Sort
	|
	|-RVA: 0x395C5F0 Offset: 0x395C6F1 VA: 0x395C5F0
	|-ArraySortHelper<RaycastHit2D>.Sort
	|
	|-RVA: 0x395E220 Offset: 0x395E321 VA: 0x395E220
	|-ArraySortHelper<RaycastResult>.Sort
	|
	|-RVA: 0x3960140 Offset: 0x3960241 VA: 0x3960140
	|-ArraySortHelper<Rect>.Sort
	|
	|-RVA: 0x3961AD0 Offset: 0x3961BD1 VA: 0x3961AD0
	|-ArraySortHelper<RendererListHandle>.Sort
	|
	|-RVA: 0x3963160 Offset: 0x3963261 VA: 0x3963160
	|-ArraySortHelper<ResourceHandle>.Sort
	|
	|-RVA: 0x39647F0 Offset: 0x39648F1 VA: 0x39647F0
	|-ArraySortHelper<sbyte>.Sort
	|
	|-RVA: 0x3965E80 Offset: 0x3965F81 VA: 0x3965E80
	|-ArraySortHelper<ShaderTagId>.Sort
	|
	|-RVA: 0x3967520 Offset: 0x3967621 VA: 0x3967520
	|-ArraySortHelper<float>.Sort
	|
	|-RVA: 0x3968C20 Offset: 0x3968D21 VA: 0x3968C20
	|-ArraySortHelper<SphericalHarmonicsL2>.Sort
	|
	|-RVA: 0x396B020 Offset: 0x396B121 VA: 0x396B020
	|-ArraySortHelper<SubMeshDescriptor>.Sort
	|
	|-RVA: 0x396CB50 Offset: 0x396CC51 VA: 0x396CB50
	|-ArraySortHelper<TablePair>.Sort
	|
	|-RVA: 0x396E3E0 Offset: 0x396E4E1 VA: 0x396E3E0
	|-ArraySortHelper<TimeSpan>.Sort
	|
	|-RVA: 0x396FA90 Offset: 0x396FB91 VA: 0x396FA90
	|-ArraySortHelper<UICharInfo>.Sort
	|
	|-RVA: 0x39713B0 Offset: 0x39714B1 VA: 0x39713B0
	|-ArraySortHelper<UILineInfo>.Sort
	|
	|-RVA: 0x3972BF0 Offset: 0x3972CF1 VA: 0x3972BF0
	|-ArraySortHelper<UIVertex>.Sort
	|
	|-RVA: 0x3974FD0 Offset: 0x39750D1 VA: 0x3974FD0
	|-ArraySortHelper<ushort>.Sort
	|
	|-RVA: 0x3976660 Offset: 0x3976761 VA: 0x3976660
	|-ArraySortHelper<uint>.Sort
	|
	|-RVA: 0x3977CF0 Offset: 0x3977DF1 VA: 0x3977CF0
	|-ArraySortHelper<ulong>.Sort
	|
	|-RVA: 0x3979390 Offset: 0x3979491 VA: 0x3979390
	|-ArraySortHelper<Vector2>.Sort
	|
	|-RVA: 0x397AB70 Offset: 0x397AC71 VA: 0x397AB70
	|-ArraySortHelper<Vector3>.Sort
	|
	|-RVA: 0x397C4B0 Offset: 0x397C5B1 VA: 0x397C4B0
	|-ArraySortHelper<Vector4>.Sort
	|
	|-RVA: 0x397DE50 Offset: 0x397DF51 VA: 0x397DE50
	|-ArraySortHelper<VertexAttributeDescriptor>.Sort
	|
	|-RVA: 0x397F630 Offset: 0x397F731 VA: 0x397F630
	|-ArraySortHelper<X509ChainStatus>.Sort
	|
	|-RVA: 0x391E8D0 Offset: 0x391E9D1 VA: 0x391E8D0
	|-ArraySortHelper<XRView>.Sort
	|
	|-RVA: 0x39203F0 Offset: 0x39204F1 VA: 0x39203F0
	|-ArraySortHelper<AmiiboSequence.GainItemData>.Sort
	|
	|-RVA: 0x3921CA0 Offset: 0x3921DA1 VA: 0x3921CA0
	|-ArraySortHelper<AnimationOutputWeightProcessor.WeightInfo>.Sort
	|
	|-RVA: 0x39237D0 Offset: 0x39238D1 VA: 0x39237D0
	|-ArraySortHelper<ArenaOrderSequence.GodInfo>.Sort
	|
	|-RVA: 0x3925070 Offset: 0x3925171 VA: 0x3925070
	|-ArraySortHelper<BattleInfo.SupportData>.Sort
	|
	|-RVA: 0x3926910 Offset: 0x3926A11 VA: 0x3926910
	|-ArraySortHelper<BeforeRenderHelper.OrderBlock>.Sort
	|
	|-RVA: 0x3928180 Offset: 0x3928281 VA: 0x3928180
	|-ArraySortHelper<Camera.RenderRequest>.Sort
	|
	|-RVA: 0x3929BD0 Offset: 0x3929CD1 VA: 0x3929BD0
	|-ArraySortHelper<CameraState.CustomBlendable>.Sort
	|
	|-RVA: 0x392B460 Offset: 0x392B561 VA: 0x392B460
	|-ArraySortHelper<CinemachineClearShot.Pair>.Sort
	|
	|-RVA: 0x392CAF0 Offset: 0x392CBF1 VA: 0x392CAF0
	|-ArraySortHelper<CinemachineStateDrivenCamera.HashPair>.Sort
	|
	|-RVA: 0x392E190 Offset: 0x392E291 VA: 0x392E190
	|-ArraySortHelper<DeferredTiler.PrePunctualLight>.Sort
	|
	|-RVA: 0x392FB50 Offset: 0x392FC51 VA: 0x392FB50
	|-ArraySortHelper<DelayedActionManager.DelegateInfo>.Sort
	|
	|-RVA: 0x39315B0 Offset: 0x39316B1 VA: 0x39315B0
	|-ArraySortHelper<Detail.AsyncResultInt>.Sort
	|
	|-RVA: 0x39330E0 Offset: 0x39331E1 VA: 0x39330E0
	|-ArraySortHelper<Detail.CppArray>.Sort
	|
	|-RVA: 0x39348D0 Offset: 0x39349D1 VA: 0x39348D0
	|-ArraySortHelper<Detail.NotificationEventInt>.Sort
	|
	|-RVA: 0x3936400 Offset: 0x3936501 VA: 0x3936400
	|-ArraySortHelper<DragonRideTargetGroup.ChainParam>.Sort
	|
	|-RVA: 0x3937CA0 Offset: 0x3937DA1 VA: 0x3937CA0
	|-ArraySortHelper<GmapPathAdjuster.TargetModel>.Sort
	|
	|-RVA: 0x39396E0 Offset: 0x39397E1 VA: 0x39396E0
	|-ArraySortHelper<GmapSpotAdjuster.TargetModel>.Sort
	|
	|-RVA: 0x393B120 Offset: 0x393B221 VA: 0x393B120
	|-ArraySortHelper<HubFastTravel.Location>.Sort
	|
	|-RVA: 0x393CB70 Offset: 0x393CC71 VA: 0x393CB70
	|-ArraySortHelper<HubLensFlare.Flare>.Sort
	|
	|-RVA: 0x393E760 Offset: 0x393E861 VA: 0x393E760
	|-ArraySortHelper<InventoryPoolItemMenuContent.KindBgNameClass>.Sort
	|
	|-RVA: 0x393FFC0 Offset: 0x39400C1 VA: 0x393FFC0
	|-ArraySortHelper<Map.Pos>.Sort
	|
	|-RVA: 0x3941660 Offset: 0x3941761 VA: 0x3941660
	|-ArraySortHelper<MapImage.BackupTerrain>.Sort
	|
	|-RVA: 0x3942E30 Offset: 0x3942F31 VA: 0x3942E30
	|-ArraySortHelper<MapImageRange.Pos>.Sort
	|
	|-RVA: 0x3944590 Offset: 0x3944691 VA: 0x3944590
	|-ArraySortHelper<MapMind.Target>.Sort
	|
	|-RVA: 0x3945FD0 Offset: 0x39460D1 VA: 0x3945FD0
	|-ArraySortHelper<MapPanelDebug.Entity>.Sort
	|
	|-RVA: 0x3947940 Offset: 0x3947A41 VA: 0x3947940
	|-ArraySortHelper<NexRanking.Data>.Sort
	|
	|-RVA: 0x3948FE0 Offset: 0x39490E1 VA: 0x3948FE0
	|-ArraySortHelper<NexVersus.RatingData>.Sort
	|
	|-RVA: 0x394A7C0 Offset: 0x394A8C1 VA: 0x394A7C0
	|-ArraySortHelper<PackedPlayModeBuildLogs.RuntimeBuildLog>.Sort
	|
	|-RVA: 0x394C030 Offset: 0x394C131 VA: 0x394C030
	|-ArraySortHelper<ParticleSystem.Particle>.Sort
	|
	|-RVA: 0x394DAA0 Offset: 0x394DBA1 VA: 0x394DAA0
	|-ArraySortHelper<ProfileCard.SortieCount>.Sort
	|
	|-RVA: 0x377F020 Offset: 0x377F121 VA: 0x377F020
	|-ArraySortHelper<RangeData.Offset>.Sort
	|
	|-RVA: 0x37806C0 Offset: 0x37807C1 VA: 0x37806C0
	|-ArraySortHelper<RenderGraphDebugData.PassDebugData>.Sort
	|
	|-RVA: 0x3782110 Offset: 0x3782211 VA: 0x3782110
	|-ArraySortHelper<RenderGraphDebugData.ResourceDebugData>.Sort
	|
	|-RVA: 0x3783CD0 Offset: 0x3783DD1 VA: 0x3783CD0
	|-ArraySortHelper<RingCleaningUnitSelectMenu.GodParam>.Sort
	|
	|-RVA: 0x3785580 Offset: 0x3785681 VA: 0x3785580
	|-ArraySortHelper<ShadowUtility.Edge>.Sort
	|
	|-RVA: 0x3787090 Offset: 0x3787191 VA: 0x3787090
	|-ArraySortHelper<SkillArray.Entity>.Sort
	|
	|-RVA: 0x3788750 Offset: 0x3788851 VA: 0x3788750
	|-ArraySortHelper<TexturePacker_JsonArray.Frame>.Sort
	|
	|-RVA: 0x378A4B0 Offset: 0x378A5B1 VA: 0x378A4B0
	|-ArraySortHelper<TimeNotificationBehaviour.NotificationEntry>.Sort
	|
	|-RVA: 0x378BF00 Offset: 0x378C001 VA: 0x378BF00
	|-ArraySortHelper<UnitySynchronizationContext.WorkRequest>.Sort
	|
	|-RVA: 0x378D940 Offset: 0x378DA41 VA: 0x378D940
	|-ArraySortHelper<XmlSchemaObjectTable.XmlSchemaObjectEntry>.Sort
	|
	|-RVA: 0x378F1D0 Offset: 0x378F2D1 VA: 0x378F1D0
	|-ArraySortHelper<AIThink.EnchantThink.ItemInfo>.Sort
	|
	|-RVA: 0x3790930 Offset: 0x3790A31 VA: 0x3790930
	|-ArraySortHelper<AssetBundleBuildMap.AssetBundleEntry.AssetPathString>.Sort
	|
	|-RVA: 0x37921D0 Offset: 0x37922D1 VA: 0x37921D0
	|-ArraySortHelper<Detail.DataStore.DataStoreChangeMetaParamInt>.Sort
	|
	|-RVA: 0x3793D90 Offset: 0x3793E91 VA: 0x3793D90
	|-ArraySortHelper<Detail.DataStore.DataStoreDeleteParamInt>.Sort
	|
	|-RVA: 0x3795580 Offset: 0x3795681 VA: 0x3795580
	|-ArraySortHelper<Detail.DataStore.DataStoreGetMetaParamInt>.Sort
	|
	|-RVA: 0x37970B0 Offset: 0x37971B1 VA: 0x37970B0
	|-ArraySortHelper<Detail.DataStore.DataStoreMetaInfoInt>.Sort
	|
	|-RVA: 0x3798B50 Offset: 0x3798C51 VA: 0x3798B50
	|-ArraySortHelper<Detail.DataStore.DataStorePasswordInfoInt>.Sort
	|
	|-RVA: 0x379A4D0 Offset: 0x379A5D1 VA: 0x379A4D0
	|-ArraySortHelper<Detail.DataStore.DataStorePersistenceInfoInt>.Sort
	|
	|-RVA: 0x379BE50 Offset: 0x379BF51 VA: 0x379BE50
	|-ArraySortHelper<Detail.DataStore.DataStorePreparePostParamInt>.Sort
	|
	|-RVA: 0x379D8C0 Offset: 0x379D9C1 VA: 0x379D8C0
	|-ArraySortHelper<Detail.DataStore.DataStoreRateObjectParamInt>.Sort
	|
	|-RVA: 0x379F0A0 Offset: 0x379F1A1 VA: 0x379F0A0
	|-ArraySortHelper<Detail.DataStore.DataStoreRatingInitParamInt>.Sort
	|
	|-RVA: 0x37A0A60 Offset: 0x37A0B61 VA: 0x37A0A60
	|-ArraySortHelper<Detail.DataStore.DataStoreRatingTargetInt>.Sort
	|
	|-RVA: 0x37A2260 Offset: 0x37A2361 VA: 0x37A2260
	|-ArraySortHelper<Detail.Ranking.RankingCachedResultInt>.Sort
	|
	|-RVA: 0x37A3F10 Offset: 0x37A4011 VA: 0x37A3F10
	|-ArraySortHelper<Detail.Ranking.RankingOrderParamInt>.Sort
	|
	|-RVA: 0x37A5710 Offset: 0x37A5811 VA: 0x37A5710
	|-ArraySortHelper<Detail.Ranking.RankingRankDataInt>.Sort
	|
	|-RVA: 0x37A7440 Offset: 0x37A7541 VA: 0x37A7440
	|-ArraySortHelper<Detail.Ranking2.Ranking2ChartInfoInt>.Sort
	|
	|-RVA: 0x37A94D0 Offset: 0x37A95D1 VA: 0x37A94D0
	|-ArraySortHelper<Detail.Ranking2.Ranking2RankDataInt>.Sort
	|
	|-RVA: 0x37AB1C0 Offset: 0x37AB2C1 VA: 0x37AB1C0
	|-ArraySortHelper<Detail.Ranking2.Ranking2ScoreDataInt>.Sort
	|
	|-RVA: 0x37AC9A0 Offset: 0x37ACAA1 VA: 0x37AC9A0
	|-ArraySortHelper<Detail.Screening.ScreeningContextInfoInt>.Sort
	|
	|-RVA: 0x37AE390 Offset: 0x37AE491 VA: 0x37AE390
	|-ArraySortHelper<Detail.Subscriber.SubscriberContentInt>.Sort
	|
	|-RVA: 0x37B0200 Offset: 0x37B0301 VA: 0x37B0200
	|-ArraySortHelper<Detail.Subscriber.SubscriberGetContentParamInt>.Sort
	|
	|-RVA: 0x32BE500 Offset: 0x32BE601 VA: 0x32BE500
	|-ArraySortHelper<Detail.Subscriber.SubscriberUserStatusInfoInt>.Sort
	|
	|-RVA: 0x32C0030 Offset: 0x32C0131 VA: 0x32C0030
	|-ArraySortHelper<Detail.Subscriber.SubscriberUserStatusParamInt>.Sort
	|
	|-RVA: 0x32C19A0 Offset: 0x32C1AA1 VA: 0x32C19A0
	|-ArraySortHelper<Detail.Utility.IntegerSettings>.Sort
	|
	|-RVA: 0x32C3040 Offset: 0x32C3141 VA: 0x32C3040
	|-ArraySortHelper<Detail.Utility.UniqueIdInfoInt>.Sort
	|
	|-RVA: 0x32C4810 Offset: 0x32C4911 VA: 0x32C4810
	|-ArraySortHelper<MapHistory.Rewind.LatestInspectorData>.Sort
	|
	|-RVA: 0x32C6080 Offset: 0x32C6181 VA: 0x32C6080
	|-ArraySortHelper<MapHistory.Rewind.WorkTerrainData>.Sort
	|
	|-RVA: 0x32C78F0 Offset: 0x32C79F1 VA: 0x32C78F0
	|-ArraySortHelper<MapKillBonus.Work.Pos>.Sort
	|
	|-RVA: 0x32C9050 Offset: 0x32C9151 VA: 0x32C9050
	|-ArraySortHelper<MapSkill.AroundCalculator.Result>.Sort
	|
	|-RVA: 0x32CA900 Offset: 0x32CAA01 VA: 0x32CA900
	|-ArraySortHelper<TargetPositionCache.CacheCurve.Item>.Sort
	|
	|-RVA: 0x32CC430 Offset: 0x32CC531 VA: 0x32CC430
	|-ArraySortHelper<TargetPositionCache.CacheEntry.RecordingItem>.Sort
	*/

	// RVA: -1 Offset: -1
	internal static int InternalBinarySearch(T[] array, int index, int length, T value, IComparer<T> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FFD420 Offset: 0x1FFD521 VA: 0x1FFD420
	|-ArraySortHelper<IntervalTree.Entry<object>>.InternalBinarySearch
	|
	|-RVA: 0x1FFEE60 Offset: 0x1FFEF61 VA: 0x1FFEE60
	|-ArraySortHelper<KeyValuePair<DateTime, object>>.InternalBinarySearch
	|
	|-RVA: 0x20006D0 Offset: 0x20007D1 VA: 0x20006D0
	|-ArraySortHelper<KeyValuePair<int, object>>.InternalBinarySearch
	|
	|-RVA: 0x2001F40 Offset: 0x2002041 VA: 0x2001F40
	|-ArraySortHelper<KeyValuePair<object, ValueTuple<int, DateTime, object>>>.InternalBinarySearch
	|
	|-RVA: 0x2003980 Offset: 0x2003A81 VA: 0x2003980
	|-ArraySortHelper<KeyValuePair<object, object>>.InternalBinarySearch
	|
	|-RVA: 0x2005220 Offset: 0x2005321 VA: 0x2005220
	|-ArraySortHelper<CommonBattleSequence.Reliance<object>>.InternalBinarySearch
	|
	|-RVA: 0x2006C60 Offset: 0x2006D61 VA: 0x2006C60
	|-ArraySortHelper<RenderGraphResourcePool.ResourceLogInfo<object>>.InternalBinarySearch
	|
	|-RVA: 0x2008500 Offset: 0x2008601 VA: 0x2008500
	|-ArraySortHelper<ValueTuple<int, object>>.InternalBinarySearch
	|
	|-RVA: 0x2009D60 Offset: 0x2009E61 VA: 0x2009D60
	|-ArraySortHelper<ValueTuple<Int32Enum, int>>.InternalBinarySearch
	|
	|-RVA: 0x200B400 Offset: 0x200B501 VA: 0x200B400
	|-ArraySortHelper<ValueTuple<object, ValueTuple<object, int>>>.InternalBinarySearch
	|
	|-RVA: 0x200CE40 Offset: 0x200CF41 VA: 0x200CE40
	|-ArraySortHelper<ValueTuple<object, int>>.InternalBinarySearch
	|
	|-RVA: 0x200E700 Offset: 0x200E801 VA: 0x200E700
	|-ArraySortHelper<ValueTuple<Vector3, float>>.InternalBinarySearch
	|
	|-RVA: 0x20100A0 Offset: 0x20101A1 VA: 0x20100A0
	|-ArraySortHelper<ValueTuple<object, Int32Enum, int>>.InternalBinarySearch
	|
	|-RVA: 0x3A80290 Offset: 0x3A80391 VA: 0x3A80290
	|-ArraySortHelper<ValueTuple<object, int, int, int>>.InternalBinarySearch
	|
	|-RVA: 0x3A81CC0 Offset: 0x3A81DC1 VA: 0x3A81CC0
	|-ArraySortHelper<AnimatorClipInfo>.InternalBinarySearch
	|
	|-RVA: 0x3A83360 Offset: 0x3A83461 VA: 0x3A83360
	|-ArraySortHelper<AsyncOperationHandle>.InternalBinarySearch
	|
	|-RVA: 0x3A84DA0 Offset: 0x3A84EA1 VA: 0x3A84DA0
	|-ArraySortHelper<BoneWeight>.InternalBinarySearch
	|
	|-RVA: 0x3A86750 Offset: 0x3A86851 VA: 0x3A86750
	|-ArraySortHelper<bool>.InternalBinarySearch
	|
	|-RVA: 0x3A87E30 Offset: 0x3A87F31 VA: 0x3A87E30
	|-ArraySortHelper<byte>.InternalBinarySearch
	|
	|-RVA: 0x3A894D0 Offset: 0x3A895D1 VA: 0x3A894D0
	|-ArraySortHelper<CameraInfo>.InternalBinarySearch
	|
	|-RVA: 0x3A8AD30 Offset: 0x3A8AE31 VA: 0x3A8AD30
	|-ArraySortHelper<char>.InternalBinarySearch
	|
	|-RVA: 0x3A8C3F0 Offset: 0x3A8C4F1 VA: 0x3A8C3F0
	|-ArraySortHelper<Color>.InternalBinarySearch
	|
	|-RVA: 0x3A8DD80 Offset: 0x3A8DE81 VA: 0x3A8DD80
	|-ArraySortHelper<Color32>.InternalBinarySearch
	|
	|-RVA: 0x3A8F420 Offset: 0x3A8F521 VA: 0x3A8F420
	|-ArraySortHelper<ConstraintSource>.InternalBinarySearch
	|
	|-RVA: 0x3A90CC0 Offset: 0x3A90DC1 VA: 0x3A90CC0
	|-ArraySortHelper<ContourVertex>.InternalBinarySearch
	|
	|-RVA: 0x3A92700 Offset: 0x3A92801 VA: 0x3A92700
	|-ArraySortHelper<DataStoreRatingInfo>.InternalBinarySearch
	|
	|-RVA: 0x3A94070 Offset: 0x3A94171 VA: 0x3A94070
	|-ArraySortHelper<DataStoreResult>.InternalBinarySearch
	|
	|-RVA: 0x3A95700 Offset: 0x3A95801 VA: 0x3A95700
	|-ArraySortHelper<DateTime>.InternalBinarySearch
	|
	|-RVA: 0x3A96DA0 Offset: 0x3A96EA1 VA: 0x3A96DA0
	|-ArraySortHelper<DateTimeOffset>.InternalBinarySearch
	|
	|-RVA: 0x3A98580 Offset: 0x3A98681 VA: 0x3A98580
	|-ArraySortHelper<Decimal>.InternalBinarySearch
	|
	|-RVA: 0x3A99D70 Offset: 0x3A99E71 VA: 0x3A99D70
	|-ArraySortHelper<DiagnosticEvent>.InternalBinarySearch
	|
	|-RVA: 0x3A9B960 Offset: 0x3A9BA61 VA: 0x3A9B960
	|-ArraySortHelper<double>.InternalBinarySearch
	|
	|-RVA: 0x3A9D000 Offset: 0x3A9D101 VA: 0x3A9D000
	|-ArraySortHelper<Friend>.InternalBinarySearch
	|
	|-RVA: 0x3A9EA10 Offset: 0x3A9EB11 VA: 0x3A9EA10
	|-ArraySortHelper<GlyphRect>.InternalBinarySearch
	|
	|-RVA: 0x3AA01E0 Offset: 0x3AA02E1 VA: 0x3AA01E0
	|-ArraySortHelper<short>.InternalBinarySearch
	|
	|-RVA: 0x3AA1870 Offset: 0x3AA1971 VA: 0x3AA1870
	|-ArraySortHelper<int>.InternalBinarySearch
	|
	|-RVA: 0x3AA2F00 Offset: 0x3AA3001 VA: 0x3AA2F00
	|-ArraySortHelper<Int32Enum>.InternalBinarySearch
	|
	|-RVA: 0x3AA4590 Offset: 0x3AA4691 VA: 0x3AA4590
	|-ArraySortHelper<long>.InternalBinarySearch
	|
	|-RVA: 0x3AA5C20 Offset: 0x3AA5D21 VA: 0x3AA5C20
	|-ArraySortHelper<IntPtr>.InternalBinarySearch
	|
	|-RVA: 0x3AA72C0 Offset: 0x3AA73C1 VA: 0x3AA72C0
	|-ArraySortHelper<InterpretedFrameInfo>.InternalBinarySearch
	|
	|-RVA: 0x3AA8B60 Offset: 0x3AA8C61 VA: 0x3AA8B60
	|-ArraySortHelper<IntervalTreeNode>.InternalBinarySearch
	|
	|-RVA: 0x3AAA4D0 Offset: 0x3AAA5D1 VA: 0x3AAA4D0
	|-ArraySortHelper<LengthLimitProperties>.InternalBinarySearch
	|
	|-RVA: 0x3AABB60 Offset: 0x3AABC61 VA: 0x3AABB60
	|-ArraySortHelper<MapPos>.InternalBinarySearch
	|
	|-RVA: 0x3AAD220 Offset: 0x3AAD321 VA: 0x3AAD220
	|-ArraySortHelper<Matrix4x4>.InternalBinarySearch
	|
	|-RVA: 0x394F670 Offset: 0x394F771 VA: 0x394F670
	|-ArraySortHelper<object>.InternalBinarySearch
	|
	|-RVA: 0x3950D80 Offset: 0x3950E81 VA: 0x3950D80
	|-ArraySortHelper<ObjectInitializationData>.InternalBinarySearch
	|
	|-RVA: 0x3952970 Offset: 0x3952A71 VA: 0x3952970
	|-ArraySortHelper<PlayableBinding>.InternalBinarySearch
	|
	|-RVA: 0x39543C0 Offset: 0x39544C1 VA: 0x39543C0
	|-ArraySortHelper<PlayerLoopSystem>.InternalBinarySearch
	|
	|-RVA: 0x3955F90 Offset: 0x3956091 VA: 0x3955F90
	|-ArraySortHelper<PlayerLoopSystemInternal>.InternalBinarySearch
	|
	|-RVA: 0x3957B50 Offset: 0x3957C51 VA: 0x3957B50
	|-ArraySortHelper<RangePositionInfo>.InternalBinarySearch
	|
	|-RVA: 0x39593E0 Offset: 0x39594E1 VA: 0x39593E0
	|-ArraySortHelper<Ranking2ChartInfoInput>.InternalBinarySearch
	|
	|-RVA: 0x395AAA0 Offset: 0x395ABA1 VA: 0x395AAA0
	|-ArraySortHelper<RaycastHit>.InternalBinarySearch
	|
	|-RVA: 0x395C790 Offset: 0x395C891 VA: 0x395C790
	|-ArraySortHelper<RaycastHit2D>.InternalBinarySearch
	|
	|-RVA: 0x395E3C0 Offset: 0x395E4C1 VA: 0x395E3C0
	|-ArraySortHelper<RaycastResult>.InternalBinarySearch
	|
	|-RVA: 0x39602E0 Offset: 0x39603E1 VA: 0x39602E0
	|-ArraySortHelper<Rect>.InternalBinarySearch
	|
	|-RVA: 0x3961C70 Offset: 0x3961D71 VA: 0x3961C70
	|-ArraySortHelper<RendererListHandle>.InternalBinarySearch
	|
	|-RVA: 0x3963300 Offset: 0x3963401 VA: 0x3963300
	|-ArraySortHelper<ResourceHandle>.InternalBinarySearch
	|
	|-RVA: 0x3964990 Offset: 0x3964A91 VA: 0x3964990
	|-ArraySortHelper<sbyte>.InternalBinarySearch
	|
	|-RVA: 0x3966020 Offset: 0x3966121 VA: 0x3966020
	|-ArraySortHelper<ShaderTagId>.InternalBinarySearch
	|
	|-RVA: 0x39676C0 Offset: 0x39677C1 VA: 0x39676C0
	|-ArraySortHelper<float>.InternalBinarySearch
	|
	|-RVA: 0x3968DC0 Offset: 0x3968EC1 VA: 0x3968DC0
	|-ArraySortHelper<SphericalHarmonicsL2>.InternalBinarySearch
	|
	|-RVA: 0x396B1C0 Offset: 0x396B2C1 VA: 0x396B1C0
	|-ArraySortHelper<SubMeshDescriptor>.InternalBinarySearch
	|
	|-RVA: 0x396CCF0 Offset: 0x396CDF1 VA: 0x396CCF0
	|-ArraySortHelper<TablePair>.InternalBinarySearch
	|
	|-RVA: 0x396E580 Offset: 0x396E681 VA: 0x396E580
	|-ArraySortHelper<TimeSpan>.InternalBinarySearch
	|
	|-RVA: 0x396FC30 Offset: 0x396FD31 VA: 0x396FC30
	|-ArraySortHelper<UICharInfo>.InternalBinarySearch
	|
	|-RVA: 0x3971550 Offset: 0x3971651 VA: 0x3971550
	|-ArraySortHelper<UILineInfo>.InternalBinarySearch
	|
	|-RVA: 0x3972D90 Offset: 0x3972E91 VA: 0x3972D90
	|-ArraySortHelper<UIVertex>.InternalBinarySearch
	|
	|-RVA: 0x3975170 Offset: 0x3975271 VA: 0x3975170
	|-ArraySortHelper<ushort>.InternalBinarySearch
	|
	|-RVA: 0x3976800 Offset: 0x3976901 VA: 0x3976800
	|-ArraySortHelper<uint>.InternalBinarySearch
	|
	|-RVA: 0x3977E90 Offset: 0x3977F91 VA: 0x3977E90
	|-ArraySortHelper<ulong>.InternalBinarySearch
	|
	|-RVA: 0x3979530 Offset: 0x3979631 VA: 0x3979530
	|-ArraySortHelper<Vector2>.InternalBinarySearch
	|
	|-RVA: 0x397AD10 Offset: 0x397AE11 VA: 0x397AD10
	|-ArraySortHelper<Vector3>.InternalBinarySearch
	|
	|-RVA: 0x397C650 Offset: 0x397C751 VA: 0x397C650
	|-ArraySortHelper<Vector4>.InternalBinarySearch
	|
	|-RVA: 0x397DFF0 Offset: 0x397E0F1 VA: 0x397DFF0
	|-ArraySortHelper<VertexAttributeDescriptor>.InternalBinarySearch
	|
	|-RVA: 0x397F7D0 Offset: 0x397F8D1 VA: 0x397F7D0
	|-ArraySortHelper<X509ChainStatus>.InternalBinarySearch
	|
	|-RVA: 0x391EA70 Offset: 0x391EB71 VA: 0x391EA70
	|-ArraySortHelper<XRView>.InternalBinarySearch
	|
	|-RVA: 0x3920590 Offset: 0x3920691 VA: 0x3920590
	|-ArraySortHelper<AmiiboSequence.GainItemData>.InternalBinarySearch
	|
	|-RVA: 0x3921E40 Offset: 0x3921F41 VA: 0x3921E40
	|-ArraySortHelper<AnimationOutputWeightProcessor.WeightInfo>.InternalBinarySearch
	|
	|-RVA: 0x3923970 Offset: 0x3923A71 VA: 0x3923970
	|-ArraySortHelper<ArenaOrderSequence.GodInfo>.InternalBinarySearch
	|
	|-RVA: 0x3925210 Offset: 0x3925311 VA: 0x3925210
	|-ArraySortHelper<BattleInfo.SupportData>.InternalBinarySearch
	|
	|-RVA: 0x3926AB0 Offset: 0x3926BB1 VA: 0x3926AB0
	|-ArraySortHelper<BeforeRenderHelper.OrderBlock>.InternalBinarySearch
	|
	|-RVA: 0x3928320 Offset: 0x3928421 VA: 0x3928320
	|-ArraySortHelper<Camera.RenderRequest>.InternalBinarySearch
	|
	|-RVA: 0x3929D70 Offset: 0x3929E71 VA: 0x3929D70
	|-ArraySortHelper<CameraState.CustomBlendable>.InternalBinarySearch
	|
	|-RVA: 0x392B600 Offset: 0x392B701 VA: 0x392B600
	|-ArraySortHelper<CinemachineClearShot.Pair>.InternalBinarySearch
	|
	|-RVA: 0x392CC90 Offset: 0x392CD91 VA: 0x392CC90
	|-ArraySortHelper<CinemachineStateDrivenCamera.HashPair>.InternalBinarySearch
	|
	|-RVA: 0x392E330 Offset: 0x392E431 VA: 0x392E330
	|-ArraySortHelper<DeferredTiler.PrePunctualLight>.InternalBinarySearch
	|
	|-RVA: 0x392FCF0 Offset: 0x392FDF1 VA: 0x392FCF0
	|-ArraySortHelper<DelayedActionManager.DelegateInfo>.InternalBinarySearch
	|
	|-RVA: 0x3931750 Offset: 0x3931851 VA: 0x3931750
	|-ArraySortHelper<Detail.AsyncResultInt>.InternalBinarySearch
	|
	|-RVA: 0x3933280 Offset: 0x3933381 VA: 0x3933280
	|-ArraySortHelper<Detail.CppArray>.InternalBinarySearch
	|
	|-RVA: 0x3934A70 Offset: 0x3934B71 VA: 0x3934A70
	|-ArraySortHelper<Detail.NotificationEventInt>.InternalBinarySearch
	|
	|-RVA: 0x39365A0 Offset: 0x39366A1 VA: 0x39365A0
	|-ArraySortHelper<DragonRideTargetGroup.ChainParam>.InternalBinarySearch
	|
	|-RVA: 0x3937E40 Offset: 0x3937F41 VA: 0x3937E40
	|-ArraySortHelper<GmapPathAdjuster.TargetModel>.InternalBinarySearch
	|
	|-RVA: 0x3939880 Offset: 0x3939981 VA: 0x3939880
	|-ArraySortHelper<GmapSpotAdjuster.TargetModel>.InternalBinarySearch
	|
	|-RVA: 0x393B2C0 Offset: 0x393B3C1 VA: 0x393B2C0
	|-ArraySortHelper<HubFastTravel.Location>.InternalBinarySearch
	|
	|-RVA: 0x393CD10 Offset: 0x393CE11 VA: 0x393CD10
	|-ArraySortHelper<HubLensFlare.Flare>.InternalBinarySearch
	|
	|-RVA: 0x393E900 Offset: 0x393EA01 VA: 0x393E900
	|-ArraySortHelper<InventoryPoolItemMenuContent.KindBgNameClass>.InternalBinarySearch
	|
	|-RVA: 0x3940160 Offset: 0x3940261 VA: 0x3940160
	|-ArraySortHelper<Map.Pos>.InternalBinarySearch
	|
	|-RVA: 0x3941800 Offset: 0x3941901 VA: 0x3941800
	|-ArraySortHelper<MapImage.BackupTerrain>.InternalBinarySearch
	|
	|-RVA: 0x3942FD0 Offset: 0x39430D1 VA: 0x3942FD0
	|-ArraySortHelper<MapImageRange.Pos>.InternalBinarySearch
	|
	|-RVA: 0x3944730 Offset: 0x3944831 VA: 0x3944730
	|-ArraySortHelper<MapMind.Target>.InternalBinarySearch
	|
	|-RVA: 0x3946170 Offset: 0x3946271 VA: 0x3946170
	|-ArraySortHelper<MapPanelDebug.Entity>.InternalBinarySearch
	|
	|-RVA: 0x3947AE0 Offset: 0x3947BE1 VA: 0x3947AE0
	|-ArraySortHelper<NexRanking.Data>.InternalBinarySearch
	|
	|-RVA: 0x3949180 Offset: 0x3949281 VA: 0x3949180
	|-ArraySortHelper<NexVersus.RatingData>.InternalBinarySearch
	|
	|-RVA: 0x394A960 Offset: 0x394AA61 VA: 0x394A960
	|-ArraySortHelper<PackedPlayModeBuildLogs.RuntimeBuildLog>.InternalBinarySearch
	|
	|-RVA: 0x394C1D0 Offset: 0x394C2D1 VA: 0x394C1D0
	|-ArraySortHelper<ParticleSystem.Particle>.InternalBinarySearch
	|
	|-RVA: 0x394DC40 Offset: 0x394DD41 VA: 0x394DC40
	|-ArraySortHelper<ProfileCard.SortieCount>.InternalBinarySearch
	|
	|-RVA: 0x377F1C0 Offset: 0x377F2C1 VA: 0x377F1C0
	|-ArraySortHelper<RangeData.Offset>.InternalBinarySearch
	|
	|-RVA: 0x3780860 Offset: 0x3780961 VA: 0x3780860
	|-ArraySortHelper<RenderGraphDebugData.PassDebugData>.InternalBinarySearch
	|
	|-RVA: 0x37822B0 Offset: 0x37823B1 VA: 0x37822B0
	|-ArraySortHelper<RenderGraphDebugData.ResourceDebugData>.InternalBinarySearch
	|
	|-RVA: 0x3783E70 Offset: 0x3783F71 VA: 0x3783E70
	|-ArraySortHelper<RingCleaningUnitSelectMenu.GodParam>.InternalBinarySearch
	|
	|-RVA: 0x3785720 Offset: 0x3785821 VA: 0x3785720
	|-ArraySortHelper<ShadowUtility.Edge>.InternalBinarySearch
	|
	|-RVA: 0x3787230 Offset: 0x3787331 VA: 0x3787230
	|-ArraySortHelper<SkillArray.Entity>.InternalBinarySearch
	|
	|-RVA: 0x37888F0 Offset: 0x37889F1 VA: 0x37888F0
	|-ArraySortHelper<TexturePacker_JsonArray.Frame>.InternalBinarySearch
	|
	|-RVA: 0x378A650 Offset: 0x378A751 VA: 0x378A650
	|-ArraySortHelper<TimeNotificationBehaviour.NotificationEntry>.InternalBinarySearch
	|
	|-RVA: 0x378C0A0 Offset: 0x378C1A1 VA: 0x378C0A0
	|-ArraySortHelper<UnitySynchronizationContext.WorkRequest>.InternalBinarySearch
	|
	|-RVA: 0x378DAE0 Offset: 0x378DBE1 VA: 0x378DAE0
	|-ArraySortHelper<XmlSchemaObjectTable.XmlSchemaObjectEntry>.InternalBinarySearch
	|
	|-RVA: 0x378F370 Offset: 0x378F471 VA: 0x378F370
	|-ArraySortHelper<AIThink.EnchantThink.ItemInfo>.InternalBinarySearch
	|
	|-RVA: 0x3790AD0 Offset: 0x3790BD1 VA: 0x3790AD0
	|-ArraySortHelper<AssetBundleBuildMap.AssetBundleEntry.AssetPathString>.InternalBinarySearch
	|
	|-RVA: 0x3792370 Offset: 0x3792471 VA: 0x3792370
	|-ArraySortHelper<Detail.DataStore.DataStoreChangeMetaParamInt>.InternalBinarySearch
	|
	|-RVA: 0x3793F30 Offset: 0x3794031 VA: 0x3793F30
	|-ArraySortHelper<Detail.DataStore.DataStoreDeleteParamInt>.InternalBinarySearch
	|
	|-RVA: 0x3795720 Offset: 0x3795821 VA: 0x3795720
	|-ArraySortHelper<Detail.DataStore.DataStoreGetMetaParamInt>.InternalBinarySearch
	|
	|-RVA: 0x3797250 Offset: 0x3797351 VA: 0x3797250
	|-ArraySortHelper<Detail.DataStore.DataStoreMetaInfoInt>.InternalBinarySearch
	|
	|-RVA: 0x3798CF0 Offset: 0x3798DF1 VA: 0x3798CF0
	|-ArraySortHelper<Detail.DataStore.DataStorePasswordInfoInt>.InternalBinarySearch
	|
	|-RVA: 0x379A670 Offset: 0x379A771 VA: 0x379A670
	|-ArraySortHelper<Detail.DataStore.DataStorePersistenceInfoInt>.InternalBinarySearch
	|
	|-RVA: 0x379BFF0 Offset: 0x379C0F1 VA: 0x379BFF0
	|-ArraySortHelper<Detail.DataStore.DataStorePreparePostParamInt>.InternalBinarySearch
	|
	|-RVA: 0x379DA60 Offset: 0x379DB61 VA: 0x379DA60
	|-ArraySortHelper<Detail.DataStore.DataStoreRateObjectParamInt>.InternalBinarySearch
	|
	|-RVA: 0x379F240 Offset: 0x379F341 VA: 0x379F240
	|-ArraySortHelper<Detail.DataStore.DataStoreRatingInitParamInt>.InternalBinarySearch
	|
	|-RVA: 0x37A0C00 Offset: 0x37A0D01 VA: 0x37A0C00
	|-ArraySortHelper<Detail.DataStore.DataStoreRatingTargetInt>.InternalBinarySearch
	|
	|-RVA: 0x37A2400 Offset: 0x37A2501 VA: 0x37A2400
	|-ArraySortHelper<Detail.Ranking.RankingCachedResultInt>.InternalBinarySearch
	|
	|-RVA: 0x37A40B0 Offset: 0x37A41B1 VA: 0x37A40B0
	|-ArraySortHelper<Detail.Ranking.RankingOrderParamInt>.InternalBinarySearch
	|
	|-RVA: 0x37A58B0 Offset: 0x37A59B1 VA: 0x37A58B0
	|-ArraySortHelper<Detail.Ranking.RankingRankDataInt>.InternalBinarySearch
	|
	|-RVA: 0x37A75E0 Offset: 0x37A76E1 VA: 0x37A75E0
	|-ArraySortHelper<Detail.Ranking2.Ranking2ChartInfoInt>.InternalBinarySearch
	|
	|-RVA: 0x37A9670 Offset: 0x37A9771 VA: 0x37A9670
	|-ArraySortHelper<Detail.Ranking2.Ranking2RankDataInt>.InternalBinarySearch
	|
	|-RVA: 0x37AB360 Offset: 0x37AB461 VA: 0x37AB360
	|-ArraySortHelper<Detail.Ranking2.Ranking2ScoreDataInt>.InternalBinarySearch
	|
	|-RVA: 0x37ACB40 Offset: 0x37ACC41 VA: 0x37ACB40
	|-ArraySortHelper<Detail.Screening.ScreeningContextInfoInt>.InternalBinarySearch
	|
	|-RVA: 0x37AE530 Offset: 0x37AE631 VA: 0x37AE530
	|-ArraySortHelper<Detail.Subscriber.SubscriberContentInt>.InternalBinarySearch
	|
	|-RVA: 0x37B03A0 Offset: 0x37B04A1 VA: 0x37B03A0
	|-ArraySortHelper<Detail.Subscriber.SubscriberGetContentParamInt>.InternalBinarySearch
	|
	|-RVA: 0x32BE6A0 Offset: 0x32BE7A1 VA: 0x32BE6A0
	|-ArraySortHelper<Detail.Subscriber.SubscriberUserStatusInfoInt>.InternalBinarySearch
	|
	|-RVA: 0x32C01D0 Offset: 0x32C02D1 VA: 0x32C01D0
	|-ArraySortHelper<Detail.Subscriber.SubscriberUserStatusParamInt>.InternalBinarySearch
	|
	|-RVA: 0x32C1B40 Offset: 0x32C1C41 VA: 0x32C1B40
	|-ArraySortHelper<Detail.Utility.IntegerSettings>.InternalBinarySearch
	|
	|-RVA: 0x32C31E0 Offset: 0x32C32E1 VA: 0x32C31E0
	|-ArraySortHelper<Detail.Utility.UniqueIdInfoInt>.InternalBinarySearch
	|
	|-RVA: 0x32C49B0 Offset: 0x32C4AB1 VA: 0x32C49B0
	|-ArraySortHelper<MapHistory.Rewind.LatestInspectorData>.InternalBinarySearch
	|
	|-RVA: 0x32C6220 Offset: 0x32C6321 VA: 0x32C6220
	|-ArraySortHelper<MapHistory.Rewind.WorkTerrainData>.InternalBinarySearch
	|
	|-RVA: 0x32C7A90 Offset: 0x32C7B91 VA: 0x32C7A90
	|-ArraySortHelper<MapKillBonus.Work.Pos>.InternalBinarySearch
	|
	|-RVA: 0x32C91F0 Offset: 0x32C92F1 VA: 0x32C91F0
	|-ArraySortHelper<MapSkill.AroundCalculator.Result>.InternalBinarySearch
	|
	|-RVA: 0x32CAAA0 Offset: 0x32CABA1 VA: 0x32CAAA0
	|-ArraySortHelper<TargetPositionCache.CacheCurve.Item>.InternalBinarySearch
	|
	|-RVA: 0x32CC5D0 Offset: 0x32CC6D1 VA: 0x32CC5D0
	|-ArraySortHelper<TargetPositionCache.CacheEntry.RecordingItem>.InternalBinarySearch
	*/

	// RVA: -1 Offset: -1
	private static void SwapIfGreater(T[] keys, Comparison<T> comparer, int a, int b) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FFD5D0 Offset: 0x1FFD6D1 VA: 0x1FFD5D0
	|-ArraySortHelper<IntervalTree.Entry<object>>.SwapIfGreater
	|
	|-RVA: 0x1FFEFE0 Offset: 0x1FFF0E1 VA: 0x1FFEFE0
	|-ArraySortHelper<KeyValuePair<DateTime, object>>.SwapIfGreater
	|
	|-RVA: 0x2000850 Offset: 0x2000951 VA: 0x2000850
	|-ArraySortHelper<KeyValuePair<int, object>>.SwapIfGreater
	|
	|-RVA: 0x20020F0 Offset: 0x20021F1 VA: 0x20020F0
	|-ArraySortHelper<KeyValuePair<object, ValueTuple<int, DateTime, object>>>.SwapIfGreater
	|
	|-RVA: 0x2003B00 Offset: 0x2003C01 VA: 0x2003B00
	|-ArraySortHelper<KeyValuePair<object, object>>.SwapIfGreater
	|
	|-RVA: 0x20053D0 Offset: 0x20054D1 VA: 0x20053D0
	|-ArraySortHelper<CommonBattleSequence.Reliance<object>>.SwapIfGreater
	|
	|-RVA: 0x2006DE0 Offset: 0x2006EE1 VA: 0x2006DE0
	|-ArraySortHelper<RenderGraphResourcePool.ResourceLogInfo<object>>.SwapIfGreater
	|
	|-RVA: 0x2008680 Offset: 0x2008781 VA: 0x2008680
	|-ArraySortHelper<ValueTuple<int, object>>.SwapIfGreater
	|
	|-RVA: 0x2009EC0 Offset: 0x2009FC1 VA: 0x2009EC0
	|-ArraySortHelper<ValueTuple<Int32Enum, int>>.SwapIfGreater
	|
	|-RVA: 0x200B5B0 Offset: 0x200B6B1 VA: 0x200B5B0
	|-ArraySortHelper<ValueTuple<object, ValueTuple<object, int>>>.SwapIfGreater
	|
	|-RVA: 0x200CFC0 Offset: 0x200D0C1 VA: 0x200CFC0
	|-ArraySortHelper<ValueTuple<object, int>>.SwapIfGreater
	|
	|-RVA: 0x200E8B0 Offset: 0x200E9B1 VA: 0x200E8B0
	|-ArraySortHelper<ValueTuple<Vector3, float>>.SwapIfGreater
	|
	|-RVA: 0x2010220 Offset: 0x2010321 VA: 0x2010220
	|-ArraySortHelper<ValueTuple<object, Int32Enum, int>>.SwapIfGreater
	|
	|-RVA: 0x3A80440 Offset: 0x3A80541 VA: 0x3A80440
	|-ArraySortHelper<ValueTuple<object, int, int, int>>.SwapIfGreater
	|
	|-RVA: 0x3A81E20 Offset: 0x3A81F21 VA: 0x3A81E20
	|-ArraySortHelper<AnimatorClipInfo>.SwapIfGreater
	|
	|-RVA: 0x3A83510 Offset: 0x3A83611 VA: 0x3A83510
	|-ArraySortHelper<AsyncOperationHandle>.SwapIfGreater
	|
	|-RVA: 0x3A84F50 Offset: 0x3A85051 VA: 0x3A84F50
	|-ArraySortHelper<BoneWeight>.SwapIfGreater
	|
	|-RVA: 0x3A868C0 Offset: 0x3A869C1 VA: 0x3A868C0
	|-ArraySortHelper<bool>.SwapIfGreater
	|
	|-RVA: 0x3A87F90 Offset: 0x3A88091 VA: 0x3A87F90
	|-ArraySortHelper<byte>.SwapIfGreater
	|
	|-RVA: 0x3A89650 Offset: 0x3A89751 VA: 0x3A89650
	|-ArraySortHelper<CameraInfo>.SwapIfGreater
	|
	|-RVA: 0x3A8AE90 Offset: 0x3A8AF91 VA: 0x3A8AE90
	|-ArraySortHelper<char>.SwapIfGreater
	|
	|-RVA: 0x3A8C5A0 Offset: 0x3A8C6A1 VA: 0x3A8C5A0
	|-ArraySortHelper<Color>.SwapIfGreater
	|
	|-RVA: 0x3A8DEE0 Offset: 0x3A8DFE1 VA: 0x3A8DEE0
	|-ArraySortHelper<Color32>.SwapIfGreater
	|
	|-RVA: 0x3A8F5A0 Offset: 0x3A8F6A1 VA: 0x3A8F5A0
	|-ArraySortHelper<ConstraintSource>.SwapIfGreater
	|
	|-RVA: 0x3A90E70 Offset: 0x3A90F71 VA: 0x3A90E70
	|-ArraySortHelper<ContourVertex>.SwapIfGreater
	|
	|-RVA: 0x3A928B0 Offset: 0x3A929B1 VA: 0x3A928B0
	|-ArraySortHelper<DataStoreRatingInfo>.SwapIfGreater
	|
	|-RVA: 0x3A941D0 Offset: 0x3A942D1 VA: 0x3A941D0
	|-ArraySortHelper<DataStoreResult>.SwapIfGreater
	|
	|-RVA: 0x3A95860 Offset: 0x3A95961 VA: 0x3A95860
	|-ArraySortHelper<DateTime>.SwapIfGreater
	|
	|-RVA: 0x3A96F20 Offset: 0x3A97021 VA: 0x3A96F20
	|-ArraySortHelper<DateTimeOffset>.SwapIfGreater
	|
	|-RVA: 0x3A98700 Offset: 0x3A98801 VA: 0x3A98700
	|-ArraySortHelper<Decimal>.SwapIfGreater
	|
	|-RVA: 0x3A99F50 Offset: 0x3A9A051 VA: 0x3A99F50
	|-ArraySortHelper<DiagnosticEvent>.SwapIfGreater
	|
	|-RVA: 0x3A9BAC0 Offset: 0x3A9BBC1 VA: 0x3A9BAC0
	|-ArraySortHelper<double>.SwapIfGreater
	|
	|-RVA: 0x3A9D1B0 Offset: 0x3A9D2B1 VA: 0x3A9D1B0
	|-ArraySortHelper<Friend>.SwapIfGreater
	|
	|-RVA: 0x3A9EB90 Offset: 0x3A9EC91 VA: 0x3A9EB90
	|-ArraySortHelper<GlyphRect>.SwapIfGreater
	|
	|-RVA: 0x3AA0340 Offset: 0x3AA0441 VA: 0x3AA0340
	|-ArraySortHelper<short>.SwapIfGreater
	|
	|-RVA: 0x3AA19D0 Offset: 0x3AA1AD1 VA: 0x3AA19D0
	|-ArraySortHelper<int>.SwapIfGreater
	|
	|-RVA: 0x3AA3060 Offset: 0x3AA3161 VA: 0x3AA3060
	|-ArraySortHelper<Int32Enum>.SwapIfGreater
	|
	|-RVA: 0x3AA46F0 Offset: 0x3AA47F1 VA: 0x3AA46F0
	|-ArraySortHelper<long>.SwapIfGreater
	|
	|-RVA: 0x3AA5D80 Offset: 0x3AA5E81 VA: 0x3AA5D80
	|-ArraySortHelper<IntPtr>.SwapIfGreater
	|
	|-RVA: 0x3AA7440 Offset: 0x3AA7541 VA: 0x3AA7440
	|-ArraySortHelper<InterpretedFrameInfo>.SwapIfGreater
	|
	|-RVA: 0x3AA8D10 Offset: 0x3AA8E11 VA: 0x3AA8D10
	|-ArraySortHelper<IntervalTreeNode>.SwapIfGreater
	|
	|-RVA: 0x3AAA630 Offset: 0x3AAA731 VA: 0x3AAA630
	|-ArraySortHelper<LengthLimitProperties>.SwapIfGreater
	|
	|-RVA: 0x3AABCC0 Offset: 0x3AABDC1 VA: 0x3AABCC0
	|-ArraySortHelper<MapPos>.SwapIfGreater
	|
	|-RVA: 0x3AAD430 Offset: 0x3AAD531 VA: 0x3AAD430
	|-ArraySortHelper<Matrix4x4>.SwapIfGreater
	|
	|-RVA: 0x394F7D0 Offset: 0x394F8D1 VA: 0x394F7D0
	|-ArraySortHelper<object>.SwapIfGreater
	|
	|-RVA: 0x3950F60 Offset: 0x3951061 VA: 0x3950F60
	|-ArraySortHelper<ObjectInitializationData>.SwapIfGreater
	|
	|-RVA: 0x3952B20 Offset: 0x3952C21 VA: 0x3952B20
	|-ArraySortHelper<PlayableBinding>.SwapIfGreater
	|
	|-RVA: 0x39545A0 Offset: 0x39546A1 VA: 0x39545A0
	|-ArraySortHelper<PlayerLoopSystem>.SwapIfGreater
	|
	|-RVA: 0x3956170 Offset: 0x3956271 VA: 0x3956170
	|-ArraySortHelper<PlayerLoopSystemInternal>.SwapIfGreater
	|
	|-RVA: 0x3957CD0 Offset: 0x3957DD1 VA: 0x3957CD0
	|-ArraySortHelper<RangePositionInfo>.SwapIfGreater
	|
	|-RVA: 0x3959540 Offset: 0x3959641 VA: 0x3959540
	|-ArraySortHelper<Ranking2ChartInfoInput>.SwapIfGreater
	|
	|-RVA: 0x395ACB0 Offset: 0x395ADB1 VA: 0x395ACB0
	|-ArraySortHelper<RaycastHit>.SwapIfGreater
	|
	|-RVA: 0x395C980 Offset: 0x395CA81 VA: 0x395C980
	|-ArraySortHelper<RaycastHit2D>.SwapIfGreater
	|
	|-RVA: 0x395E600 Offset: 0x395E701 VA: 0x395E600
	|-ArraySortHelper<RaycastResult>.SwapIfGreater
	|
	|-RVA: 0x3960490 Offset: 0x3960591 VA: 0x3960490
	|-ArraySortHelper<Rect>.SwapIfGreater
	|
	|-RVA: 0x3961DD0 Offset: 0x3961ED1 VA: 0x3961DD0
	|-ArraySortHelper<RendererListHandle>.SwapIfGreater
	|
	|-RVA: 0x3963460 Offset: 0x3963561 VA: 0x3963460
	|-ArraySortHelper<ResourceHandle>.SwapIfGreater
	|
	|-RVA: 0x3964AF0 Offset: 0x3964BF1 VA: 0x3964AF0
	|-ArraySortHelper<sbyte>.SwapIfGreater
	|
	|-RVA: 0x3966180 Offset: 0x3966281 VA: 0x3966180
	|-ArraySortHelper<ShaderTagId>.SwapIfGreater
	|
	|-RVA: 0x3967820 Offset: 0x3967921 VA: 0x3967820
	|-ArraySortHelper<float>.SwapIfGreater
	|
	|-RVA: 0x3969090 Offset: 0x3969191 VA: 0x3969090
	|-ArraySortHelper<SphericalHarmonicsL2>.SwapIfGreater
	|
	|-RVA: 0x396B3A0 Offset: 0x396B4A1 VA: 0x396B3A0
	|-ArraySortHelper<SubMeshDescriptor>.SwapIfGreater
	|
	|-RVA: 0x396CE70 Offset: 0x396CF71 VA: 0x396CE70
	|-ArraySortHelper<TablePair>.SwapIfGreater
	|
	|-RVA: 0x396E6E0 Offset: 0x396E7E1 VA: 0x396E6E0
	|-ArraySortHelper<TimeSpan>.SwapIfGreater
	|
	|-RVA: 0x396FDD0 Offset: 0x396FED1 VA: 0x396FDD0
	|-ArraySortHelper<UICharInfo>.SwapIfGreater
	|
	|-RVA: 0x39716D0 Offset: 0x39717D1 VA: 0x39716D0
	|-ArraySortHelper<UILineInfo>.SwapIfGreater
	|
	|-RVA: 0x3973060 Offset: 0x3973161 VA: 0x3973060
	|-ArraySortHelper<UIVertex>.SwapIfGreater
	|
	|-RVA: 0x39752D0 Offset: 0x39753D1 VA: 0x39752D0
	|-ArraySortHelper<ushort>.SwapIfGreater
	|
	|-RVA: 0x3976960 Offset: 0x3976A61 VA: 0x3976960
	|-ArraySortHelper<uint>.SwapIfGreater
	|
	|-RVA: 0x3977FF0 Offset: 0x39780F1 VA: 0x3977FF0
	|-ArraySortHelper<ulong>.SwapIfGreater
	|
	|-RVA: 0x39796B0 Offset: 0x39797B1 VA: 0x39796B0
	|-ArraySortHelper<Vector2>.SwapIfGreater
	|
	|-RVA: 0x397AEB0 Offset: 0x397AFB1 VA: 0x397AEB0
	|-ArraySortHelper<Vector3>.SwapIfGreater
	|
	|-RVA: 0x397C800 Offset: 0x397C901 VA: 0x397C800
	|-ArraySortHelper<Vector4>.SwapIfGreater
	|
	|-RVA: 0x397E170 Offset: 0x397E271 VA: 0x397E170
	|-ArraySortHelper<VertexAttributeDescriptor>.SwapIfGreater
	|
	|-RVA: 0x397F950 Offset: 0x397FA51 VA: 0x397F950
	|-ArraySortHelper<X509ChainStatus>.SwapIfGreater
	|
	|-RVA: 0x391EC20 Offset: 0x391ED21 VA: 0x391EC20
	|-ArraySortHelper<XRView>.SwapIfGreater
	|
	|-RVA: 0x3920710 Offset: 0x3920811 VA: 0x3920710
	|-ArraySortHelper<AmiiboSequence.GainItemData>.SwapIfGreater
	|
	|-RVA: 0x3922020 Offset: 0x3922121 VA: 0x3922020
	|-ArraySortHelper<AnimationOutputWeightProcessor.WeightInfo>.SwapIfGreater
	|
	|-RVA: 0x3923AF0 Offset: 0x3923BF1 VA: 0x3923AF0
	|-ArraySortHelper<ArenaOrderSequence.GodInfo>.SwapIfGreater
	|
	|-RVA: 0x3925390 Offset: 0x3925491 VA: 0x3925390
	|-ArraySortHelper<BattleInfo.SupportData>.SwapIfGreater
	|
	|-RVA: 0x3926C30 Offset: 0x3926D31 VA: 0x3926C30
	|-ArraySortHelper<BeforeRenderHelper.OrderBlock>.SwapIfGreater
	|
	|-RVA: 0x39284D0 Offset: 0x39285D1 VA: 0x39284D0
	|-ArraySortHelper<Camera.RenderRequest>.SwapIfGreater
	|
	|-RVA: 0x3929EF0 Offset: 0x3929FF1 VA: 0x3929EF0
	|-ArraySortHelper<CameraState.CustomBlendable>.SwapIfGreater
	|
	|-RVA: 0x392B760 Offset: 0x392B861 VA: 0x392B760
	|-ArraySortHelper<CinemachineClearShot.Pair>.SwapIfGreater
	|
	|-RVA: 0x392CDF0 Offset: 0x392CEF1 VA: 0x392CDF0
	|-ArraySortHelper<CinemachineStateDrivenCamera.HashPair>.SwapIfGreater
	|
	|-RVA: 0x392E4E0 Offset: 0x392E5E1 VA: 0x392E4E0
	|-ArraySortHelper<DeferredTiler.PrePunctualLight>.SwapIfGreater
	|
	|-RVA: 0x392FEA0 Offset: 0x392FFA1 VA: 0x392FEA0
	|-ArraySortHelper<DelayedActionManager.DelegateInfo>.SwapIfGreater
	|
	|-RVA: 0x3931930 Offset: 0x3931A31 VA: 0x3931930
	|-ArraySortHelper<Detail.AsyncResultInt>.SwapIfGreater
	|
	|-RVA: 0x3933400 Offset: 0x3933501 VA: 0x3933400
	|-ArraySortHelper<Detail.CppArray>.SwapIfGreater
	|
	|-RVA: 0x3934C50 Offset: 0x3934D51 VA: 0x3934C50
	|-ArraySortHelper<Detail.NotificationEventInt>.SwapIfGreater
	|
	|-RVA: 0x3936720 Offset: 0x3936821 VA: 0x3936720
	|-ArraySortHelper<DragonRideTargetGroup.ChainParam>.SwapIfGreater
	|
	|-RVA: 0x3937FF0 Offset: 0x39380F1 VA: 0x3937FF0
	|-ArraySortHelper<GmapPathAdjuster.TargetModel>.SwapIfGreater
	|
	|-RVA: 0x3939A30 Offset: 0x3939B31 VA: 0x3939A30
	|-ArraySortHelper<GmapSpotAdjuster.TargetModel>.SwapIfGreater
	|
	|-RVA: 0x393B470 Offset: 0x393B571 VA: 0x393B470
	|-ArraySortHelper<HubFastTravel.Location>.SwapIfGreater
	|
	|-RVA: 0x393CEF0 Offset: 0x393CFF1 VA: 0x393CEF0
	|-ArraySortHelper<HubLensFlare.Flare>.SwapIfGreater
	|
	|-RVA: 0x393EA80 Offset: 0x393EB81 VA: 0x393EA80
	|-ArraySortHelper<InventoryPoolItemMenuContent.KindBgNameClass>.SwapIfGreater
	|
	|-RVA: 0x39402C0 Offset: 0x39403C1 VA: 0x39402C0
	|-ArraySortHelper<Map.Pos>.SwapIfGreater
	|
	|-RVA: 0x3941980 Offset: 0x3941A81 VA: 0x3941980
	|-ArraySortHelper<MapImage.BackupTerrain>.SwapIfGreater
	|
	|-RVA: 0x3943130 Offset: 0x3943231 VA: 0x3943130
	|-ArraySortHelper<MapImageRange.Pos>.SwapIfGreater
	|
	|-RVA: 0x39448E0 Offset: 0x39449E1 VA: 0x39448E0
	|-ArraySortHelper<MapMind.Target>.SwapIfGreater
	|
	|-RVA: 0x3946320 Offset: 0x3946421 VA: 0x3946320
	|-ArraySortHelper<MapPanelDebug.Entity>.SwapIfGreater
	|
	|-RVA: 0x3947C40 Offset: 0x3947D41 VA: 0x3947C40
	|-ArraySortHelper<NexRanking.Data>.SwapIfGreater
	|
	|-RVA: 0x3949300 Offset: 0x3949401 VA: 0x3949300
	|-ArraySortHelper<NexVersus.RatingData>.SwapIfGreater
	|
	|-RVA: 0x394AAE0 Offset: 0x394ABE1 VA: 0x394AAE0
	|-ArraySortHelper<PackedPlayModeBuildLogs.RuntimeBuildLog>.SwapIfGreater
	|
	|-RVA: 0x394C380 Offset: 0x394C481 VA: 0x394C380
	|-ArraySortHelper<ParticleSystem.Particle>.SwapIfGreater
	|
	|-RVA: 0x394DDF0 Offset: 0x394DEF1 VA: 0x394DDF0
	|-ArraySortHelper<ProfileCard.SortieCount>.SwapIfGreater
	|
	|-RVA: 0x377F320 Offset: 0x377F421 VA: 0x377F320
	|-ArraySortHelper<RangeData.Offset>.SwapIfGreater
	|
	|-RVA: 0x3780A10 Offset: 0x3780B11 VA: 0x3780A10
	|-ArraySortHelper<RenderGraphDebugData.PassDebugData>.SwapIfGreater
	|
	|-RVA: 0x3782490 Offset: 0x3782591 VA: 0x3782490
	|-ArraySortHelper<RenderGraphDebugData.ResourceDebugData>.SwapIfGreater
	|
	|-RVA: 0x3783FF0 Offset: 0x37840F1 VA: 0x3783FF0
	|-ArraySortHelper<RingCleaningUnitSelectMenu.GodParam>.SwapIfGreater
	|
	|-RVA: 0x3785900 Offset: 0x3785A01 VA: 0x3785900
	|-ArraySortHelper<ShadowUtility.Edge>.SwapIfGreater
	|
	|-RVA: 0x3787390 Offset: 0x3787491 VA: 0x3787390
	|-ArraySortHelper<SkillArray.Entity>.SwapIfGreater
	|
	|-RVA: 0x3788B00 Offset: 0x3788C01 VA: 0x3788B00
	|-ArraySortHelper<TexturePacker_JsonArray.Frame>.SwapIfGreater
	|
	|-RVA: 0x378A800 Offset: 0x378A901 VA: 0x378A800
	|-ArraySortHelper<TimeNotificationBehaviour.NotificationEntry>.SwapIfGreater
	|
	|-RVA: 0x378C250 Offset: 0x378C351 VA: 0x378C250
	|-ArraySortHelper<UnitySynchronizationContext.WorkRequest>.SwapIfGreater
	|
	|-RVA: 0x378DC60 Offset: 0x378DD61 VA: 0x378DC60
	|-ArraySortHelper<XmlSchemaObjectTable.XmlSchemaObjectEntry>.SwapIfGreater
	|
	|-RVA: 0x378F4D0 Offset: 0x378F5D1 VA: 0x378F4D0
	|-ArraySortHelper<AIThink.EnchantThink.ItemInfo>.SwapIfGreater
	|
	|-RVA: 0x3790C50 Offset: 0x3790D51 VA: 0x3790C50
	|-ArraySortHelper<AssetBundleBuildMap.AssetBundleEntry.AssetPathString>.SwapIfGreater
	|
	|-RVA: 0x3792520 Offset: 0x3792621 VA: 0x3792520
	|-ArraySortHelper<Detail.DataStore.DataStoreChangeMetaParamInt>.SwapIfGreater
	|
	|-RVA: 0x37940B0 Offset: 0x37941B1 VA: 0x37940B0
	|-ArraySortHelper<Detail.DataStore.DataStoreDeleteParamInt>.SwapIfGreater
	|
	|-RVA: 0x3795900 Offset: 0x3795A01 VA: 0x3795900
	|-ArraySortHelper<Detail.DataStore.DataStoreGetMetaParamInt>.SwapIfGreater
	|
	|-RVA: 0x3797400 Offset: 0x3797501 VA: 0x3797400
	|-ArraySortHelper<Detail.DataStore.DataStoreMetaInfoInt>.SwapIfGreater
	|
	|-RVA: 0x3798EA0 Offset: 0x3798FA1 VA: 0x3798EA0
	|-ArraySortHelper<Detail.DataStore.DataStorePasswordInfoInt>.SwapIfGreater
	|
	|-RVA: 0x379A820 Offset: 0x379A921 VA: 0x379A820
	|-ArraySortHelper<Detail.DataStore.DataStorePersistenceInfoInt>.SwapIfGreater
	|
	|-RVA: 0x379C1A0 Offset: 0x379C2A1 VA: 0x379C1A0
	|-ArraySortHelper<Detail.DataStore.DataStorePreparePostParamInt>.SwapIfGreater
	|
	|-RVA: 0x379DBE0 Offset: 0x379DCE1 VA: 0x379DBE0
	|-ArraySortHelper<Detail.DataStore.DataStoreRateObjectParamInt>.SwapIfGreater
	|
	|-RVA: 0x379F3F0 Offset: 0x379F4F1 VA: 0x379F3F0
	|-ArraySortHelper<Detail.DataStore.DataStoreRatingInitParamInt>.SwapIfGreater
	|
	|-RVA: 0x37A0D80 Offset: 0x37A0E81 VA: 0x37A0D80
	|-ArraySortHelper<Detail.DataStore.DataStoreRatingTargetInt>.SwapIfGreater
	|
	|-RVA: 0x37A2610 Offset: 0x37A2711 VA: 0x37A2610
	|-ArraySortHelper<Detail.Ranking.RankingCachedResultInt>.SwapIfGreater
	|
	|-RVA: 0x37A4230 Offset: 0x37A4331 VA: 0x37A4230
	|-ArraySortHelper<Detail.Ranking.RankingOrderParamInt>.SwapIfGreater
	|
	|-RVA: 0x37A5AC0 Offset: 0x37A5BC1 VA: 0x37A5AC0
	|-ArraySortHelper<Detail.Ranking.RankingRankDataInt>.SwapIfGreater
	|
	|-RVA: 0x37A7850 Offset: 0x37A7951 VA: 0x37A7850
	|-ArraySortHelper<Detail.Ranking2.Ranking2ChartInfoInt>.SwapIfGreater
	|
	|-RVA: 0x37A9880 Offset: 0x37A9981 VA: 0x37A9880
	|-ArraySortHelper<Detail.Ranking2.Ranking2RankDataInt>.SwapIfGreater
	|
	|-RVA: 0x37AB4E0 Offset: 0x37AB5E1 VA: 0x37AB4E0
	|-ArraySortHelper<Detail.Ranking2.Ranking2ScoreDataInt>.SwapIfGreater
	|
	|-RVA: 0x37ACCF0 Offset: 0x37ACDF1 VA: 0x37ACCF0
	|-ArraySortHelper<Detail.Screening.ScreeningContextInfoInt>.SwapIfGreater
	|
	|-RVA: 0x37AE770 Offset: 0x37AE871 VA: 0x37AE770
	|-ArraySortHelper<Detail.Subscriber.SubscriberContentInt>.SwapIfGreater
	|
	|-RVA: 0x37B0550 Offset: 0x37B0651 VA: 0x37B0550
	|-ArraySortHelper<Detail.Subscriber.SubscriberGetContentParamInt>.SwapIfGreater
	|
	|-RVA: 0x32BE880 Offset: 0x32BE981 VA: 0x32BE880
	|-ArraySortHelper<Detail.Subscriber.SubscriberUserStatusInfoInt>.SwapIfGreater
	|
	|-RVA: 0x32C0380 Offset: 0x32C0481 VA: 0x32C0380
	|-ArraySortHelper<Detail.Subscriber.SubscriberUserStatusParamInt>.SwapIfGreater
	|
	|-RVA: 0x32C1CA0 Offset: 0x32C1DA1 VA: 0x32C1CA0
	|-ArraySortHelper<Detail.Utility.IntegerSettings>.SwapIfGreater
	|
	|-RVA: 0x32C3360 Offset: 0x32C3461 VA: 0x32C3360
	|-ArraySortHelper<Detail.Utility.UniqueIdInfoInt>.SwapIfGreater
	|
	|-RVA: 0x32C4B00 Offset: 0x32C4C01 VA: 0x32C4B00
	|-ArraySortHelper<MapHistory.Rewind.LatestInspectorData>.SwapIfGreater
	|
	|-RVA: 0x32C6370 Offset: 0x32C6471 VA: 0x32C6370
	|-ArraySortHelper<MapHistory.Rewind.WorkTerrainData>.SwapIfGreater
	|
	|-RVA: 0x32C7BF0 Offset: 0x32C7CF1 VA: 0x32C7BF0
	|-ArraySortHelper<MapKillBonus.Work.Pos>.SwapIfGreater
	|
	|-RVA: 0x32C9370 Offset: 0x32C9471 VA: 0x32C9370
	|-ArraySortHelper<MapSkill.AroundCalculator.Result>.SwapIfGreater
	|
	|-RVA: 0x32CAC80 Offset: 0x32CAD81 VA: 0x32CAC80
	|-ArraySortHelper<TargetPositionCache.CacheCurve.Item>.SwapIfGreater
	|
	|-RVA: 0x32CC7C0 Offset: 0x32CC8C1 VA: 0x32CC7C0
	|-ArraySortHelper<TargetPositionCache.CacheEntry.RecordingItem>.SwapIfGreater
	*/

	// RVA: -1 Offset: -1
	private static void Swap(T[] a, int i, int j) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FFD7A0 Offset: 0x1FFD8A1 VA: 0x1FFD7A0
	|-ArraySortHelper<IntervalTree.Entry<object>>.Swap
	|
	|-RVA: 0x1FFF180 Offset: 0x1FFF281 VA: 0x1FFF180
	|-ArraySortHelper<KeyValuePair<DateTime, object>>.Swap
	|
	|-RVA: 0x20009F0 Offset: 0x2000AF1 VA: 0x20009F0
	|-ArraySortHelper<KeyValuePair<int, object>>.Swap
	|
	|-RVA: 0x20022B0 Offset: 0x20023B1 VA: 0x20022B0
	|-ArraySortHelper<KeyValuePair<object, ValueTuple<int, DateTime, object>>>.Swap
	|
	|-RVA: 0x2003CB0 Offset: 0x2003DB1 VA: 0x2003CB0
	|-ArraySortHelper<KeyValuePair<object, object>>.Swap
	|
	|-RVA: 0x20055A0 Offset: 0x20056A1 VA: 0x20055A0
	|-ArraySortHelper<CommonBattleSequence.Reliance<object>>.Swap
	|
	|-RVA: 0x2006F90 Offset: 0x2007091 VA: 0x2006F90
	|-ArraySortHelper<RenderGraphResourcePool.ResourceLogInfo<object>>.Swap
	|
	|-RVA: 0x2008820 Offset: 0x2008921 VA: 0x2008820
	|-ArraySortHelper<ValueTuple<int, object>>.Swap
	|
	|-RVA: 0x2009FE0 Offset: 0x200A0E1 VA: 0x2009FE0
	|-ArraySortHelper<ValueTuple<Int32Enum, int>>.Swap
	|
	|-RVA: 0x200B780 Offset: 0x200B881 VA: 0x200B780
	|-ArraySortHelper<ValueTuple<object, ValueTuple<object, int>>>.Swap
	|
	|-RVA: 0x200D170 Offset: 0x200D271 VA: 0x200D170
	|-ArraySortHelper<ValueTuple<object, int>>.Swap
	|
	|-RVA: 0x200EA80 Offset: 0x200EB81 VA: 0x200EA80
	|-ArraySortHelper<ValueTuple<Vector3, float>>.Swap
	|
	|-RVA: 0x20103D0 Offset: 0x20104D1 VA: 0x20103D0
	|-ArraySortHelper<ValueTuple<object, Int32Enum, int>>.Swap
	|
	|-RVA: 0x3A80610 Offset: 0x3A80711 VA: 0x3A80610
	|-ArraySortHelper<ValueTuple<object, int, int, int>>.Swap
	|
	|-RVA: 0x3A81F40 Offset: 0x3A82041 VA: 0x3A81F40
	|-ArraySortHelper<AnimatorClipInfo>.Swap
	|
	|-RVA: 0x3A836E0 Offset: 0x3A837E1 VA: 0x3A836E0
	|-ArraySortHelper<AsyncOperationHandle>.Swap
	|
	|-RVA: 0x3A850F0 Offset: 0x3A851F1 VA: 0x3A850F0
	|-ArraySortHelper<BoneWeight>.Swap
	|
	|-RVA: 0x3A869F0 Offset: 0x3A86AF1 VA: 0x3A869F0
	|-ArraySortHelper<bool>.Swap
	|
	|-RVA: 0x3A880B0 Offset: 0x3A881B1 VA: 0x3A880B0
	|-ArraySortHelper<byte>.Swap
	|
	|-RVA: 0x3A897F0 Offset: 0x3A898F1 VA: 0x3A897F0
	|-ArraySortHelper<CameraInfo>.Swap
	|
	|-RVA: 0x3A8AFB0 Offset: 0x3A8B0B1 VA: 0x3A8AFB0
	|-ArraySortHelper<char>.Swap
	|
	|-RVA: 0x3A8C770 Offset: 0x3A8C871 VA: 0x3A8C770
	|-ArraySortHelper<Color>.Swap
	|
	|-RVA: 0x3A8E000 Offset: 0x3A8E101 VA: 0x3A8E000
	|-ArraySortHelper<Color32>.Swap
	|
	|-RVA: 0x3A8F750 Offset: 0x3A8F851 VA: 0x3A8F750
	|-ArraySortHelper<ConstraintSource>.Swap
	|
	|-RVA: 0x3A91040 Offset: 0x3A91141 VA: 0x3A91040
	|-ArraySortHelper<ContourVertex>.Swap
	|
	|-RVA: 0x3A92A40 Offset: 0x3A92B41 VA: 0x3A92A40
	|-ArraySortHelper<DataStoreRatingInfo>.Swap
	|
	|-RVA: 0x3A942F0 Offset: 0x3A943F1 VA: 0x3A942F0
	|-ArraySortHelper<DataStoreResult>.Swap
	|
	|-RVA: 0x3A95980 Offset: 0x3A95A81 VA: 0x3A95980
	|-ArraySortHelper<DateTime>.Swap
	|
	|-RVA: 0x3A97090 Offset: 0x3A97191 VA: 0x3A97090
	|-ArraySortHelper<DateTimeOffset>.Swap
	|
	|-RVA: 0x3A98870 Offset: 0x3A98971 VA: 0x3A98870
	|-ArraySortHelper<Decimal>.Swap
	|
	|-RVA: 0x3A9A160 Offset: 0x3A9A261 VA: 0x3A9A160
	|-ArraySortHelper<DiagnosticEvent>.Swap
	|
	|-RVA: 0x3A9BBE0 Offset: 0x3A9BCE1 VA: 0x3A9BBE0
	|-ArraySortHelper<double>.Swap
	|
	|-RVA: 0x3A9D350 Offset: 0x3A9D451 VA: 0x3A9D350
	|-ArraySortHelper<Friend>.Swap
	|
	|-RVA: 0x3A9ED00 Offset: 0x3A9EE01 VA: 0x3A9ED00
	|-ArraySortHelper<GlyphRect>.Swap
	|
	|-RVA: 0x3AA0460 Offset: 0x3AA0561 VA: 0x3AA0460
	|-ArraySortHelper<short>.Swap
	|
	|-RVA: 0x3AA1AF0 Offset: 0x3AA1BF1 VA: 0x3AA1AF0
	|-ArraySortHelper<int>.Swap
	|
	|-RVA: 0x3AA3180 Offset: 0x3AA3281 VA: 0x3AA3180
	|-ArraySortHelper<Int32Enum>.Swap
	|
	|-RVA: 0x3AA4810 Offset: 0x3AA4911 VA: 0x3AA4810
	|-ArraySortHelper<long>.Swap
	|
	|-RVA: 0x3AA5EA0 Offset: 0x3AA5FA1 VA: 0x3AA5EA0
	|-ArraySortHelper<IntPtr>.Swap
	|
	|-RVA: 0x3AA75F0 Offset: 0x3AA76F1 VA: 0x3AA75F0
	|-ArraySortHelper<InterpretedFrameInfo>.Swap
	|
	|-RVA: 0x3AA8EA0 Offset: 0x3AA8FA1 VA: 0x3AA8EA0
	|-ArraySortHelper<IntervalTreeNode>.Swap
	|
	|-RVA: 0x3AAA750 Offset: 0x3AAA851 VA: 0x3AAA750
	|-ArraySortHelper<LengthLimitProperties>.Swap
	|
	|-RVA: 0x3AABDE0 Offset: 0x3AABEE1 VA: 0x3AABDE0
	|-ArraySortHelper<MapPos>.Swap
	|
	|-RVA: 0x3AAD640 Offset: 0x3AAD741 VA: 0x3AAD640
	|-ArraySortHelper<Matrix4x4>.Swap
	|
	|-RVA: 0x394F920 Offset: 0x394FA21 VA: 0x394F920
	|-ArraySortHelper<object>.Swap
	|
	|-RVA: 0x3951170 Offset: 0x3951271 VA: 0x3951170
	|-ArraySortHelper<ObjectInitializationData>.Swap
	|
	|-RVA: 0x3952CE0 Offset: 0x3952DE1 VA: 0x3952CE0
	|-ArraySortHelper<PlayableBinding>.Swap
	|
	|-RVA: 0x39547A0 Offset: 0x39548A1 VA: 0x39547A0
	|-ArraySortHelper<PlayerLoopSystem>.Swap
	|
	|-RVA: 0x3956370 Offset: 0x3956471 VA: 0x3956370
	|-ArraySortHelper<PlayerLoopSystemInternal>.Swap
	|
	|-RVA: 0x3957E80 Offset: 0x3957F81 VA: 0x3957E80
	|-ArraySortHelper<RangePositionInfo>.Swap
	|
	|-RVA: 0x3959660 Offset: 0x3959761 VA: 0x3959660
	|-ArraySortHelper<Ranking2ChartInfoInput>.Swap
	|
	|-RVA: 0x395AEC0 Offset: 0x395AFC1 VA: 0x395AEC0
	|-ArraySortHelper<RaycastHit>.Swap
	|
	|-RVA: 0x395CB70 Offset: 0x395CC71 VA: 0x395CB70
	|-ArraySortHelper<RaycastHit2D>.Swap
	|
	|-RVA: 0x395E880 Offset: 0x395E981 VA: 0x395E880
	|-ArraySortHelper<RaycastResult>.Swap
	|
	|-RVA: 0x3960660 Offset: 0x3960761 VA: 0x3960660
	|-ArraySortHelper<Rect>.Swap
	|
	|-RVA: 0x3961EF0 Offset: 0x3961FF1 VA: 0x3961EF0
	|-ArraySortHelper<RendererListHandle>.Swap
	|
	|-RVA: 0x3963580 Offset: 0x3963681 VA: 0x3963580
	|-ArraySortHelper<ResourceHandle>.Swap
	|
	|-RVA: 0x3964C10 Offset: 0x3964D11 VA: 0x3964C10
	|-ArraySortHelper<sbyte>.Swap
	|
	|-RVA: 0x39662A0 Offset: 0x39663A1 VA: 0x39662A0
	|-ArraySortHelper<ShaderTagId>.Swap
	|
	|-RVA: 0x3967940 Offset: 0x3967A41 VA: 0x3967940
	|-ArraySortHelper<float>.Swap
	|
	|-RVA: 0x3969390 Offset: 0x3969491 VA: 0x3969390
	|-ArraySortHelper<SphericalHarmonicsL2>.Swap
	|
	|-RVA: 0x396B570 Offset: 0x396B671 VA: 0x396B570
	|-ArraySortHelper<SubMeshDescriptor>.Swap
	|
	|-RVA: 0x396D020 Offset: 0x396D121 VA: 0x396D020
	|-ArraySortHelper<TablePair>.Swap
	|
	|-RVA: 0x396E800 Offset: 0x396E901 VA: 0x396E800
	|-ArraySortHelper<TimeSpan>.Swap
	|
	|-RVA: 0x396FF80 Offset: 0x3970081 VA: 0x396FF80
	|-ArraySortHelper<UICharInfo>.Swap
	|
	|-RVA: 0x3971840 Offset: 0x3971941 VA: 0x3971840
	|-ArraySortHelper<UILineInfo>.Swap
	|
	|-RVA: 0x3973360 Offset: 0x3973461 VA: 0x3973360
	|-ArraySortHelper<UIVertex>.Swap
	|
	|-RVA: 0x39753F0 Offset: 0x39754F1 VA: 0x39753F0
	|-ArraySortHelper<ushort>.Swap
	|
	|-RVA: 0x3976A80 Offset: 0x3976B81 VA: 0x3976A80
	|-ArraySortHelper<uint>.Swap
	|
	|-RVA: 0x3978110 Offset: 0x3978211 VA: 0x3978110
	|-ArraySortHelper<ulong>.Swap
	|
	|-RVA: 0x3979810 Offset: 0x3979911 VA: 0x3979810
	|-ArraySortHelper<Vector2>.Swap
	|
	|-RVA: 0x397B060 Offset: 0x397B161 VA: 0x397B060
	|-ArraySortHelper<Vector3>.Swap
	|
	|-RVA: 0x397C9D0 Offset: 0x397CAD1 VA: 0x397C9D0
	|-ArraySortHelper<Vector4>.Swap
	|
	|-RVA: 0x397E2E0 Offset: 0x397E3E1 VA: 0x397E2E0
	|-ArraySortHelper<VertexAttributeDescriptor>.Swap
	|
	|-RVA: 0x397FAF0 Offset: 0x397FBF1 VA: 0x397FAF0
	|-ArraySortHelper<X509ChainStatus>.Swap
	|
	|-RVA: 0x391EE10 Offset: 0x391EF11 VA: 0x391EE10
	|-ArraySortHelper<XRView>.Swap
	|
	|-RVA: 0x39208C0 Offset: 0x39209C1 VA: 0x39208C0
	|-ArraySortHelper<AmiiboSequence.GainItemData>.Swap
	|
	|-RVA: 0x39221F0 Offset: 0x39222F1 VA: 0x39221F0
	|-ArraySortHelper<AnimationOutputWeightProcessor.WeightInfo>.Swap
	|
	|-RVA: 0x3923CA0 Offset: 0x3923DA1 VA: 0x3923CA0
	|-ArraySortHelper<ArenaOrderSequence.GodInfo>.Swap
	|
	|-RVA: 0x3925540 Offset: 0x3925641 VA: 0x3925540
	|-ArraySortHelper<BattleInfo.SupportData>.Swap
	|
	|-RVA: 0x3926DD0 Offset: 0x3926ED1 VA: 0x3926DD0
	|-ArraySortHelper<BeforeRenderHelper.OrderBlock>.Swap
	|
	|-RVA: 0x39286A0 Offset: 0x39287A1 VA: 0x39286A0
	|-ArraySortHelper<Camera.RenderRequest>.Swap
	|
	|-RVA: 0x392A0A0 Offset: 0x392A1A1 VA: 0x392A0A0
	|-ArraySortHelper<CameraState.CustomBlendable>.Swap
	|
	|-RVA: 0x392B880 Offset: 0x392B981 VA: 0x392B880
	|-ArraySortHelper<CinemachineClearShot.Pair>.Swap
	|
	|-RVA: 0x392CF10 Offset: 0x392D011 VA: 0x392CF10
	|-ArraySortHelper<CinemachineStateDrivenCamera.HashPair>.Swap
	|
	|-RVA: 0x392E680 Offset: 0x392E781 VA: 0x392E680
	|-ArraySortHelper<DeferredTiler.PrePunctualLight>.Swap
	|
	|-RVA: 0x3930060 Offset: 0x3930161 VA: 0x3930060
	|-ArraySortHelper<DelayedActionManager.DelegateInfo>.Swap
	|
	|-RVA: 0x3931B00 Offset: 0x3931C01 VA: 0x3931B00
	|-ArraySortHelper<Detail.AsyncResultInt>.Swap
	|
	|-RVA: 0x3933570 Offset: 0x3933671 VA: 0x3933570
	|-ArraySortHelper<Detail.CppArray>.Swap
	|
	|-RVA: 0x3934E20 Offset: 0x3934F21 VA: 0x3934E20
	|-ArraySortHelper<Detail.NotificationEventInt>.Swap
	|
	|-RVA: 0x39368D0 Offset: 0x39369D1 VA: 0x39368D0
	|-ArraySortHelper<DragonRideTargetGroup.ChainParam>.Swap
	|
	|-RVA: 0x39381C0 Offset: 0x39382C1 VA: 0x39381C0
	|-ArraySortHelper<GmapPathAdjuster.TargetModel>.Swap
	|
	|-RVA: 0x3939C00 Offset: 0x3939D01 VA: 0x3939C00
	|-ArraySortHelper<GmapSpotAdjuster.TargetModel>.Swap
	|
	|-RVA: 0x393B640 Offset: 0x393B741 VA: 0x393B640
	|-ArraySortHelper<HubFastTravel.Location>.Swap
	|
	|-RVA: 0x393D100 Offset: 0x393D201 VA: 0x393D100
	|-ArraySortHelper<HubLensFlare.Flare>.Swap
	|
	|-RVA: 0x393EC20 Offset: 0x393ED21 VA: 0x393EC20
	|-ArraySortHelper<InventoryPoolItemMenuContent.KindBgNameClass>.Swap
	|
	|-RVA: 0x39403E0 Offset: 0x39404E1 VA: 0x39403E0
	|-ArraySortHelper<Map.Pos>.Swap
	|
	|-RVA: 0x3941AF0 Offset: 0x3941BF1 VA: 0x3941AF0
	|-ArraySortHelper<MapImage.BackupTerrain>.Swap
	|
	|-RVA: 0x3943250 Offset: 0x3943351 VA: 0x3943250
	|-ArraySortHelper<MapImageRange.Pos>.Swap
	|
	|-RVA: 0x3944AB0 Offset: 0x3944BB1 VA: 0x3944AB0
	|-ArraySortHelper<MapMind.Target>.Swap
	|
	|-RVA: 0x39464B0 Offset: 0x39465B1 VA: 0x39464B0
	|-ArraySortHelper<MapPanelDebug.Entity>.Swap
	|
	|-RVA: 0x3947D60 Offset: 0x3947E61 VA: 0x3947D60
	|-ArraySortHelper<NexRanking.Data>.Swap
	|
	|-RVA: 0x3949470 Offset: 0x3949571 VA: 0x3949470
	|-ArraySortHelper<NexVersus.RatingData>.Swap
	|
	|-RVA: 0x394AC80 Offset: 0x394AD81 VA: 0x394AC80
	|-ArraySortHelper<PackedPlayModeBuildLogs.RuntimeBuildLog>.Swap
	|
	|-RVA: 0x394C540 Offset: 0x394C641 VA: 0x394C540
	|-ArraySortHelper<ParticleSystem.Particle>.Swap
	|
	|-RVA: 0x394DFC0 Offset: 0x394E0C1 VA: 0x394DFC0
	|-ArraySortHelper<ProfileCard.SortieCount>.Swap
	|
	|-RVA: 0x377F440 Offset: 0x377F541 VA: 0x377F440
	|-ArraySortHelper<RangeData.Offset>.Swap
	|
	|-RVA: 0x3780BD0 Offset: 0x3780CD1 VA: 0x3780BD0
	|-ArraySortHelper<RenderGraphDebugData.PassDebugData>.Swap
	|
	|-RVA: 0x3782690 Offset: 0x3782791 VA: 0x3782690
	|-ArraySortHelper<RenderGraphDebugData.ResourceDebugData>.Swap
	|
	|-RVA: 0x37841A0 Offset: 0x37842A1 VA: 0x37841A0
	|-ArraySortHelper<RingCleaningUnitSelectMenu.GodParam>.Swap
	|
	|-RVA: 0x3785AD0 Offset: 0x3785BD1 VA: 0x3785AD0
	|-ArraySortHelper<ShadowUtility.Edge>.Swap
	|
	|-RVA: 0x37874B0 Offset: 0x37875B1 VA: 0x37874B0
	|-ArraySortHelper<SkillArray.Entity>.Swap
	|
	|-RVA: 0x3788D30 Offset: 0x3788E31 VA: 0x3788D30
	|-ArraySortHelper<TexturePacker_JsonArray.Frame>.Swap
	|
	|-RVA: 0x378A9D0 Offset: 0x378AAD1 VA: 0x378A9D0
	|-ArraySortHelper<TimeNotificationBehaviour.NotificationEntry>.Swap
	|
	|-RVA: 0x378C420 Offset: 0x378C521 VA: 0x378C420
	|-ArraySortHelper<UnitySynchronizationContext.WorkRequest>.Swap
	|
	|-RVA: 0x378DE10 Offset: 0x378DF11 VA: 0x378DE10
	|-ArraySortHelper<XmlSchemaObjectTable.XmlSchemaObjectEntry>.Swap
	|
	|-RVA: 0x378F5F0 Offset: 0x378F6F1 VA: 0x378F5F0
	|-ArraySortHelper<AIThink.EnchantThink.ItemInfo>.Swap
	|
	|-RVA: 0x3790E00 Offset: 0x3790F01 VA: 0x3790E00
	|-ArraySortHelper<AssetBundleBuildMap.AssetBundleEntry.AssetPathString>.Swap
	|
	|-RVA: 0x3792730 Offset: 0x3792831 VA: 0x3792730
	|-ArraySortHelper<Detail.DataStore.DataStoreChangeMetaParamInt>.Swap
	|
	|-RVA: 0x3794220 Offset: 0x3794321 VA: 0x3794220
	|-ArraySortHelper<Detail.DataStore.DataStoreDeleteParamInt>.Swap
	|
	|-RVA: 0x3795AD0 Offset: 0x3795BD1 VA: 0x3795AD0
	|-ArraySortHelper<Detail.DataStore.DataStoreGetMetaParamInt>.Swap
	|
	|-RVA: 0x37975C0 Offset: 0x37976C1 VA: 0x37975C0
	|-ArraySortHelper<Detail.DataStore.DataStoreMetaInfoInt>.Swap
	|
	|-RVA: 0x3799030 Offset: 0x3799131 VA: 0x3799030
	|-ArraySortHelper<Detail.DataStore.DataStorePasswordInfoInt>.Swap
	|
	|-RVA: 0x379A9B0 Offset: 0x379AAB1 VA: 0x379A9B0
	|-ArraySortHelper<Detail.DataStore.DataStorePersistenceInfoInt>.Swap
	|
	|-RVA: 0x379C360 Offset: 0x379C461 VA: 0x379C360
	|-ArraySortHelper<Detail.DataStore.DataStorePreparePostParamInt>.Swap
	|
	|-RVA: 0x379DD50 Offset: 0x379DE51 VA: 0x379DD50
	|-ArraySortHelper<Detail.DataStore.DataStoreRateObjectParamInt>.Swap
	|
	|-RVA: 0x379F590 Offset: 0x379F691 VA: 0x379F590
	|-ArraySortHelper<Detail.DataStore.DataStoreRatingInitParamInt>.Swap
	|
	|-RVA: 0x37A0EF0 Offset: 0x37A0FF1 VA: 0x37A0EF0
	|-ArraySortHelper<Detail.DataStore.DataStoreRatingTargetInt>.Swap
	|
	|-RVA: 0x37A2810 Offset: 0x37A2911 VA: 0x37A2810
	|-ArraySortHelper<Detail.Ranking.RankingCachedResultInt>.Swap
	|
	|-RVA: 0x37A43A0 Offset: 0x37A44A1 VA: 0x37A43A0
	|-ArraySortHelper<Detail.Ranking.RankingOrderParamInt>.Swap
	|
	|-RVA: 0x37A5CD0 Offset: 0x37A5DD1 VA: 0x37A5CD0
	|-ArraySortHelper<Detail.Ranking.RankingRankDataInt>.Swap
	|
	|-RVA: 0x37A7AD0 Offset: 0x37A7BD1 VA: 0x37A7AD0
	|-ArraySortHelper<Detail.Ranking2.Ranking2ChartInfoInt>.Swap
	|
	|-RVA: 0x37A9A90 Offset: 0x37A9B91 VA: 0x37A9A90
	|-ArraySortHelper<Detail.Ranking2.Ranking2RankDataInt>.Swap
	|
	|-RVA: 0x37AB650 Offset: 0x37AB751 VA: 0x37AB650
	|-ArraySortHelper<Detail.Ranking2.Ranking2ScoreDataInt>.Swap
	|
	|-RVA: 0x37ACE90 Offset: 0x37ACF91 VA: 0x37ACE90
	|-ArraySortHelper<Detail.Screening.ScreeningContextInfoInt>.Swap
	|
	|-RVA: 0x37AE9B0 Offset: 0x37AEAB1 VA: 0x37AE9B0
	|-ArraySortHelper<Detail.Subscriber.SubscriberContentInt>.Swap
	|
	|-RVA: 0x37B06E0 Offset: 0x37B07E1 VA: 0x37B06E0
	|-ArraySortHelper<Detail.Subscriber.SubscriberGetContentParamInt>.Swap
	|
	|-RVA: 0x32BEA50 Offset: 0x32BEB51 VA: 0x32BEA50
	|-ArraySortHelper<Detail.Subscriber.SubscriberUserStatusInfoInt>.Swap
	|
	|-RVA: 0x32C0510 Offset: 0x32C0611 VA: 0x32C0510
	|-ArraySortHelper<Detail.Subscriber.SubscriberUserStatusParamInt>.Swap
	|
	|-RVA: 0x32C1DC0 Offset: 0x32C1EC1 VA: 0x32C1DC0
	|-ArraySortHelper<Detail.Utility.IntegerSettings>.Swap
	|
	|-RVA: 0x32C34D0 Offset: 0x32C35D1 VA: 0x32C34D0
	|-ArraySortHelper<Detail.Utility.UniqueIdInfoInt>.Swap
	|
	|-RVA: 0x32C4C50 Offset: 0x32C4D51 VA: 0x32C4C50
	|-ArraySortHelper<MapHistory.Rewind.LatestInspectorData>.Swap
	|
	|-RVA: 0x32C64C0 Offset: 0x32C65C1 VA: 0x32C64C0
	|-ArraySortHelper<MapHistory.Rewind.WorkTerrainData>.Swap
	|
	|-RVA: 0x32C7D10 Offset: 0x32C7E11 VA: 0x32C7D10
	|-ArraySortHelper<MapKillBonus.Work.Pos>.Swap
	|
	|-RVA: 0x32C9520 Offset: 0x32C9621 VA: 0x32C9520
	|-ArraySortHelper<MapSkill.AroundCalculator.Result>.Swap
	|
	|-RVA: 0x32CAE50 Offset: 0x32CAF51 VA: 0x32CAE50
	|-ArraySortHelper<TargetPositionCache.CacheCurve.Item>.Swap
	|
	|-RVA: 0x32CC9B0 Offset: 0x32CCAB1 VA: 0x32CC9B0
	|-ArraySortHelper<TargetPositionCache.CacheEntry.RecordingItem>.Swap
	*/

	// RVA: -1 Offset: -1
	internal static void IntrospectiveSort(T[] keys, int left, int length, Comparison<T> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FFD890 Offset: 0x1FFD991 VA: 0x1FFD890
	|-ArraySortHelper<IntervalTree.Entry<object>>.IntrospectiveSort
	|
	|-RVA: 0x1FFF240 Offset: 0x1FFF341 VA: 0x1FFF240
	|-ArraySortHelper<KeyValuePair<DateTime, object>>.IntrospectiveSort
	|
	|-RVA: 0x2000AB0 Offset: 0x2000BB1 VA: 0x2000AB0
	|-ArraySortHelper<KeyValuePair<int, object>>.IntrospectiveSort
	|
	|-RVA: 0x2002390 Offset: 0x2002491 VA: 0x2002390
	|-ArraySortHelper<KeyValuePair<object, ValueTuple<int, DateTime, object>>>.IntrospectiveSort
	|
	|-RVA: 0x2003D90 Offset: 0x2003E91 VA: 0x2003D90
	|-ArraySortHelper<KeyValuePair<object, object>>.IntrospectiveSort
	|
	|-RVA: 0x2005690 Offset: 0x2005791 VA: 0x2005690
	|-ArraySortHelper<CommonBattleSequence.Reliance<object>>.IntrospectiveSort
	|
	|-RVA: 0x2007070 Offset: 0x2007171 VA: 0x2007070
	|-ArraySortHelper<RenderGraphResourcePool.ResourceLogInfo<object>>.IntrospectiveSort
	|
	|-RVA: 0x20088E0 Offset: 0x20089E1 VA: 0x20088E0
	|-ArraySortHelper<ValueTuple<int, object>>.IntrospectiveSort
	|
	|-RVA: 0x200A040 Offset: 0x200A141 VA: 0x200A040
	|-ArraySortHelper<ValueTuple<Int32Enum, int>>.IntrospectiveSort
	|
	|-RVA: 0x200B870 Offset: 0x200B971 VA: 0x200B870
	|-ArraySortHelper<ValueTuple<object, ValueTuple<object, int>>>.IntrospectiveSort
	|
	|-RVA: 0x200D250 Offset: 0x200D351 VA: 0x200D250
	|-ArraySortHelper<ValueTuple<object, int>>.IntrospectiveSort
	|
	|-RVA: 0x200EB30 Offset: 0x200EC31 VA: 0x200EB30
	|-ArraySortHelper<ValueTuple<Vector3, float>>.IntrospectiveSort
	|
	|-RVA: 0x20104B0 Offset: 0x20105B1 VA: 0x20104B0
	|-ArraySortHelper<ValueTuple<object, Int32Enum, int>>.IntrospectiveSort
	|
	|-RVA: 0x3A80700 Offset: 0x3A80801 VA: 0x3A80700
	|-ArraySortHelper<ValueTuple<object, int, int, int>>.IntrospectiveSort
	|
	|-RVA: 0x3A81FA0 Offset: 0x3A820A1 VA: 0x3A81FA0
	|-ArraySortHelper<AnimatorClipInfo>.IntrospectiveSort
	|
	|-RVA: 0x3A837D0 Offset: 0x3A838D1 VA: 0x3A837D0
	|-ArraySortHelper<AsyncOperationHandle>.IntrospectiveSort
	|
	|-RVA: 0x3A851A0 Offset: 0x3A852A1 VA: 0x3A851A0
	|-ArraySortHelper<BoneWeight>.IntrospectiveSort
	|
	|-RVA: 0x3A86A50 Offset: 0x3A86B51 VA: 0x3A86A50
	|-ArraySortHelper<bool>.IntrospectiveSort
	|
	|-RVA: 0x3A88110 Offset: 0x3A88211 VA: 0x3A88110
	|-ArraySortHelper<byte>.IntrospectiveSort
	|
	|-RVA: 0x3A898B0 Offset: 0x3A899B1 VA: 0x3A898B0
	|-ArraySortHelper<CameraInfo>.IntrospectiveSort
	|
	|-RVA: 0x3A8B010 Offset: 0x3A8B111 VA: 0x3A8B010
	|-ArraySortHelper<char>.IntrospectiveSort
	|
	|-RVA: 0x3A8C820 Offset: 0x3A8C921 VA: 0x3A8C820
	|-ArraySortHelper<Color>.IntrospectiveSort
	|
	|-RVA: 0x3A8E060 Offset: 0x3A8E161 VA: 0x3A8E060
	|-ArraySortHelper<Color32>.IntrospectiveSort
	|
	|-RVA: 0x3A8F830 Offset: 0x3A8F931 VA: 0x3A8F830
	|-ArraySortHelper<ConstraintSource>.IntrospectiveSort
	|
	|-RVA: 0x3A91130 Offset: 0x3A91231 VA: 0x3A91130
	|-ArraySortHelper<ContourVertex>.IntrospectiveSort
	|
	|-RVA: 0x3A92AE0 Offset: 0x3A92BE1 VA: 0x3A92AE0
	|-ArraySortHelper<DataStoreRatingInfo>.IntrospectiveSort
	|
	|-RVA: 0x3A94350 Offset: 0x3A94451 VA: 0x3A94350
	|-ArraySortHelper<DataStoreResult>.IntrospectiveSort
	|
	|-RVA: 0x3A959E0 Offset: 0x3A95AE1 VA: 0x3A959E0
	|-ArraySortHelper<DateTime>.IntrospectiveSort
	|
	|-RVA: 0x3A97110 Offset: 0x3A97211 VA: 0x3A97110
	|-ArraySortHelper<DateTimeOffset>.IntrospectiveSort
	|
	|-RVA: 0x3A988F0 Offset: 0x3A989F1 VA: 0x3A988F0
	|-ArraySortHelper<Decimal>.IntrospectiveSort
	|
	|-RVA: 0x3A9A280 Offset: 0x3A9A381 VA: 0x3A9A280
	|-ArraySortHelper<DiagnosticEvent>.IntrospectiveSort
	|
	|-RVA: 0x3A9BC40 Offset: 0x3A9BD41 VA: 0x3A9BC40
	|-ArraySortHelper<double>.IntrospectiveSort
	|
	|-RVA: 0x3A9D430 Offset: 0x3A9D531 VA: 0x3A9D430
	|-ArraySortHelper<Friend>.IntrospectiveSort
	|
	|-RVA: 0x3A9ED80 Offset: 0x3A9EE81 VA: 0x3A9ED80
	|-ArraySortHelper<GlyphRect>.IntrospectiveSort
	|
	|-RVA: 0x3AA04C0 Offset: 0x3AA05C1 VA: 0x3AA04C0
	|-ArraySortHelper<short>.IntrospectiveSort
	|
	|-RVA: 0x3AA1B50 Offset: 0x3AA1C51 VA: 0x3AA1B50
	|-ArraySortHelper<int>.IntrospectiveSort
	|
	|-RVA: 0x3AA31E0 Offset: 0x3AA32E1 VA: 0x3AA31E0
	|-ArraySortHelper<Int32Enum>.IntrospectiveSort
	|
	|-RVA: 0x3AA4870 Offset: 0x3AA4971 VA: 0x3AA4870
	|-ArraySortHelper<long>.IntrospectiveSort
	|
	|-RVA: 0x3AA5F00 Offset: 0x3AA6001 VA: 0x3AA5F00
	|-ArraySortHelper<IntPtr>.IntrospectiveSort
	|
	|-RVA: 0x3AA76D0 Offset: 0x3AA77D1 VA: 0x3AA76D0
	|-ArraySortHelper<InterpretedFrameInfo>.IntrospectiveSort
	|
	|-RVA: 0x3AA8F40 Offset: 0x3AA9041 VA: 0x3AA8F40
	|-ArraySortHelper<IntervalTreeNode>.IntrospectiveSort
	|
	|-RVA: 0x3AAA7B0 Offset: 0x3AAA8B1 VA: 0x3AAA7B0
	|-ArraySortHelper<LengthLimitProperties>.IntrospectiveSort
	|
	|-RVA: 0x3AABE40 Offset: 0x3AABF41 VA: 0x3AABE40
	|-ArraySortHelper<MapPos>.IntrospectiveSort
	|
	|-RVA: 0x3AAD740 Offset: 0x3AAD841 VA: 0x3AAD740
	|-ArraySortHelper<Matrix4x4>.IntrospectiveSort
	|
	|-RVA: 0x394F9B0 Offset: 0x394FAB1 VA: 0x394F9B0
	|-ArraySortHelper<object>.IntrospectiveSort
	|
	|-RVA: 0x3951290 Offset: 0x3951391 VA: 0x3951290
	|-ArraySortHelper<ObjectInitializationData>.IntrospectiveSort
	|
	|-RVA: 0x3952DC0 Offset: 0x3952EC1 VA: 0x3952DC0
	|-ArraySortHelper<PlayableBinding>.IntrospectiveSort
	|
	|-RVA: 0x39548B0 Offset: 0x39549B1 VA: 0x39548B0
	|-ArraySortHelper<PlayerLoopSystem>.IntrospectiveSort
	|
	|-RVA: 0x3956480 Offset: 0x3956581 VA: 0x3956480
	|-ArraySortHelper<PlayerLoopSystemInternal>.IntrospectiveSort
	|
	|-RVA: 0x3957F60 Offset: 0x3958061 VA: 0x3957F60
	|-ArraySortHelper<RangePositionInfo>.IntrospectiveSort
	|
	|-RVA: 0x39596C0 Offset: 0x39597C1 VA: 0x39596C0
	|-ArraySortHelper<Ranking2ChartInfoInput>.IntrospectiveSort
	|
	|-RVA: 0x395AFB0 Offset: 0x395B0B1 VA: 0x395AFB0
	|-ArraySortHelper<RaycastHit>.IntrospectiveSort
	|
	|-RVA: 0x395CC50 Offset: 0x395CD51 VA: 0x395CC50
	|-ArraySortHelper<RaycastHit2D>.IntrospectiveSort
	|
	|-RVA: 0x395E9D0 Offset: 0x395EAD1 VA: 0x395E9D0
	|-ArraySortHelper<RaycastResult>.IntrospectiveSort
	|
	|-RVA: 0x3960710 Offset: 0x3960811 VA: 0x3960710
	|-ArraySortHelper<Rect>.IntrospectiveSort
	|
	|-RVA: 0x3961F50 Offset: 0x3962051 VA: 0x3961F50
	|-ArraySortHelper<RendererListHandle>.IntrospectiveSort
	|
	|-RVA: 0x39635E0 Offset: 0x39636E1 VA: 0x39635E0
	|-ArraySortHelper<ResourceHandle>.IntrospectiveSort
	|
	|-RVA: 0x3964C70 Offset: 0x3964D71 VA: 0x3964C70
	|-ArraySortHelper<sbyte>.IntrospectiveSort
	|
	|-RVA: 0x3966300 Offset: 0x3966401 VA: 0x3966300
	|-ArraySortHelper<ShaderTagId>.IntrospectiveSort
	|
	|-RVA: 0x39679A0 Offset: 0x3967AA1 VA: 0x39679A0
	|-ArraySortHelper<float>.IntrospectiveSort
	|
	|-RVA: 0x39694F0 Offset: 0x39695F1 VA: 0x39694F0
	|-ArraySortHelper<SphericalHarmonicsL2>.IntrospectiveSort
	|
	|-RVA: 0x396B650 Offset: 0x396B751 VA: 0x396B650
	|-ArraySortHelper<SubMeshDescriptor>.IntrospectiveSort
	|
	|-RVA: 0x396D100 Offset: 0x396D201 VA: 0x396D100
	|-ArraySortHelper<TablePair>.IntrospectiveSort
	|
	|-RVA: 0x396E860 Offset: 0x396E961 VA: 0x396E860
	|-ArraySortHelper<TimeSpan>.IntrospectiveSort
	|
	|-RVA: 0x3970020 Offset: 0x3970121 VA: 0x3970020
	|-ArraySortHelper<UICharInfo>.IntrospectiveSort
	|
	|-RVA: 0x39718C0 Offset: 0x39719C1 VA: 0x39718C0
	|-ArraySortHelper<UILineInfo>.IntrospectiveSort
	|
	|-RVA: 0x39734C0 Offset: 0x39735C1 VA: 0x39734C0
	|-ArraySortHelper<UIVertex>.IntrospectiveSort
	|
	|-RVA: 0x3975450 Offset: 0x3975551 VA: 0x3975450
	|-ArraySortHelper<ushort>.IntrospectiveSort
	|
	|-RVA: 0x3976AE0 Offset: 0x3976BE1 VA: 0x3976AE0
	|-ArraySortHelper<uint>.IntrospectiveSort
	|
	|-RVA: 0x3978170 Offset: 0x3978271 VA: 0x3978170
	|-ArraySortHelper<ulong>.IntrospectiveSort
	|
	|-RVA: 0x3979890 Offset: 0x3979991 VA: 0x3979890
	|-ArraySortHelper<Vector2>.IntrospectiveSort
	|
	|-RVA: 0x397B100 Offset: 0x397B201 VA: 0x397B100
	|-ArraySortHelper<Vector3>.IntrospectiveSort
	|
	|-RVA: 0x397CA80 Offset: 0x397CB81 VA: 0x397CA80
	|-ArraySortHelper<Vector4>.IntrospectiveSort
	|
	|-RVA: 0x397E360 Offset: 0x397E461 VA: 0x397E360
	|-ArraySortHelper<VertexAttributeDescriptor>.IntrospectiveSort
	|
	|-RVA: 0x397FBB0 Offset: 0x397FCB1 VA: 0x397FBB0
	|-ArraySortHelper<X509ChainStatus>.IntrospectiveSort
	|
	|-RVA: 0x391EF40 Offset: 0x391F041 VA: 0x391EF40
	|-ArraySortHelper<XRView>.IntrospectiveSort
	|
	|-RVA: 0x39209A0 Offset: 0x3920AA1 VA: 0x39209A0
	|-ArraySortHelper<AmiiboSequence.GainItemData>.IntrospectiveSort
	|
	|-RVA: 0x39222C0 Offset: 0x39223C1 VA: 0x39222C0
	|-ArraySortHelper<AnimationOutputWeightProcessor.WeightInfo>.IntrospectiveSort
	|
	|-RVA: 0x3923D80 Offset: 0x3923E81 VA: 0x3923D80
	|-ArraySortHelper<ArenaOrderSequence.GodInfo>.IntrospectiveSort
	|
	|-RVA: 0x3925620 Offset: 0x3925721 VA: 0x3925620
	|-ArraySortHelper<BattleInfo.SupportData>.IntrospectiveSort
	|
	|-RVA: 0x3926E90 Offset: 0x3926F91 VA: 0x3926E90
	|-ArraySortHelper<BeforeRenderHelper.OrderBlock>.IntrospectiveSort
	|
	|-RVA: 0x3928790 Offset: 0x3928891 VA: 0x3928790
	|-ArraySortHelper<Camera.RenderRequest>.IntrospectiveSort
	|
	|-RVA: 0x392A180 Offset: 0x392A281 VA: 0x392A180
	|-ArraySortHelper<CameraState.CustomBlendable>.IntrospectiveSort
	|
	|-RVA: 0x392B8E0 Offset: 0x392B9E1 VA: 0x392B8E0
	|-ArraySortHelper<CinemachineClearShot.Pair>.IntrospectiveSort
	|
	|-RVA: 0x392CF70 Offset: 0x392D071 VA: 0x392CF70
	|-ArraySortHelper<CinemachineStateDrivenCamera.HashPair>.IntrospectiveSort
	|
	|-RVA: 0x392E730 Offset: 0x392E831 VA: 0x392E730
	|-ArraySortHelper<DeferredTiler.PrePunctualLight>.IntrospectiveSort
	|
	|-RVA: 0x3930150 Offset: 0x3930251 VA: 0x3930150
	|-ArraySortHelper<DelayedActionManager.DelegateInfo>.IntrospectiveSort
	|
	|-RVA: 0x3931BE0 Offset: 0x3931CE1 VA: 0x3931BE0
	|-ArraySortHelper<Detail.AsyncResultInt>.IntrospectiveSort
	|
	|-RVA: 0x39335F0 Offset: 0x39336F1 VA: 0x39335F0
	|-ArraySortHelper<Detail.CppArray>.IntrospectiveSort
	|
	|-RVA: 0x3934F00 Offset: 0x3935001 VA: 0x3934F00
	|-ArraySortHelper<Detail.NotificationEventInt>.IntrospectiveSort
	|
	|-RVA: 0x39369B0 Offset: 0x3936AB1 VA: 0x39369B0
	|-ArraySortHelper<DragonRideTargetGroup.ChainParam>.IntrospectiveSort
	|
	|-RVA: 0x39382B0 Offset: 0x39383B1 VA: 0x39382B0
	|-ArraySortHelper<GmapPathAdjuster.TargetModel>.IntrospectiveSort
	|
	|-RVA: 0x3939CF0 Offset: 0x3939DF1 VA: 0x3939CF0
	|-ArraySortHelper<GmapSpotAdjuster.TargetModel>.IntrospectiveSort
	|
	|-RVA: 0x393B730 Offset: 0x393B831 VA: 0x393B730
	|-ArraySortHelper<HubFastTravel.Location>.IntrospectiveSort
	|
	|-RVA: 0x393D220 Offset: 0x393D321 VA: 0x393D220
	|-ArraySortHelper<HubLensFlare.Flare>.IntrospectiveSort
	|
	|-RVA: 0x393ECE0 Offset: 0x393EDE1 VA: 0x393ECE0
	|-ArraySortHelper<InventoryPoolItemMenuContent.KindBgNameClass>.IntrospectiveSort
	|
	|-RVA: 0x3940440 Offset: 0x3940541 VA: 0x3940440
	|-ArraySortHelper<Map.Pos>.IntrospectiveSort
	|
	|-RVA: 0x3941B70 Offset: 0x3941C71 VA: 0x3941B70
	|-ArraySortHelper<MapImage.BackupTerrain>.IntrospectiveSort
	|
	|-RVA: 0x39432B0 Offset: 0x39433B1 VA: 0x39432B0
	|-ArraySortHelper<MapImageRange.Pos>.IntrospectiveSort
	|
	|-RVA: 0x3944BA0 Offset: 0x3944CA1 VA: 0x3944BA0
	|-ArraySortHelper<MapMind.Target>.IntrospectiveSort
	|
	|-RVA: 0x3946550 Offset: 0x3946651 VA: 0x3946550
	|-ArraySortHelper<MapPanelDebug.Entity>.IntrospectiveSort
	|
	|-RVA: 0x3947DC0 Offset: 0x3947EC1 VA: 0x3947DC0
	|-ArraySortHelper<NexRanking.Data>.IntrospectiveSort
	|
	|-RVA: 0x39494F0 Offset: 0x39495F1 VA: 0x39494F0
	|-ArraySortHelper<NexVersus.RatingData>.IntrospectiveSort
	|
	|-RVA: 0x394AD40 Offset: 0x394AE41 VA: 0x394AD40
	|-ArraySortHelper<PackedPlayModeBuildLogs.RuntimeBuildLog>.IntrospectiveSort
	|
	|-RVA: 0x394C630 Offset: 0x394C731 VA: 0x394C630
	|-ArraySortHelper<ParticleSystem.Particle>.IntrospectiveSort
	|
	|-RVA: 0x394E0B0 Offset: 0x394E1B1 VA: 0x394E0B0
	|-ArraySortHelper<ProfileCard.SortieCount>.IntrospectiveSort
	|
	|-RVA: 0x377F4A0 Offset: 0x377F5A1 VA: 0x377F4A0
	|-ArraySortHelper<RangeData.Offset>.IntrospectiveSort
	|
	|-RVA: 0x3780CB0 Offset: 0x3780DB1 VA: 0x3780CB0
	|-ArraySortHelper<RenderGraphDebugData.PassDebugData>.IntrospectiveSort
	|
	|-RVA: 0x37827A0 Offset: 0x37828A1 VA: 0x37827A0
	|-ArraySortHelper<RenderGraphDebugData.ResourceDebugData>.IntrospectiveSort
	|
	|-RVA: 0x3784280 Offset: 0x3784381 VA: 0x3784280
	|-ArraySortHelper<RingCleaningUnitSelectMenu.GodParam>.IntrospectiveSort
	|
	|-RVA: 0x3785BA0 Offset: 0x3785CA1 VA: 0x3785BA0
	|-ArraySortHelper<ShadowUtility.Edge>.IntrospectiveSort
	|
	|-RVA: 0x3787510 Offset: 0x3787611 VA: 0x3787510
	|-ArraySortHelper<SkillArray.Entity>.IntrospectiveSort
	|
	|-RVA: 0x3788E50 Offset: 0x3788F51 VA: 0x3788E50
	|-ArraySortHelper<TexturePacker_JsonArray.Frame>.IntrospectiveSort
	|
	|-RVA: 0x378AAC0 Offset: 0x378ABC1 VA: 0x378AAC0
	|-ArraySortHelper<TimeNotificationBehaviour.NotificationEntry>.IntrospectiveSort
	|
	|-RVA: 0x378C510 Offset: 0x378C611 VA: 0x378C510
	|-ArraySortHelper<UnitySynchronizationContext.WorkRequest>.IntrospectiveSort
	|
	|-RVA: 0x378DEF0 Offset: 0x378DFF1 VA: 0x378DEF0
	|-ArraySortHelper<XmlSchemaObjectTable.XmlSchemaObjectEntry>.IntrospectiveSort
	|
	|-RVA: 0x378F650 Offset: 0x378F751 VA: 0x378F650
	|-ArraySortHelper<AIThink.EnchantThink.ItemInfo>.IntrospectiveSort
	|
	|-RVA: 0x3790EE0 Offset: 0x3790FE1 VA: 0x3790EE0
	|-ArraySortHelper<AssetBundleBuildMap.AssetBundleEntry.AssetPathString>.IntrospectiveSort
	|
	|-RVA: 0x3792840 Offset: 0x3792941 VA: 0x3792840
	|-ArraySortHelper<Detail.DataStore.DataStoreChangeMetaParamInt>.IntrospectiveSort
	|
	|-RVA: 0x37942A0 Offset: 0x37943A1 VA: 0x37942A0
	|-ArraySortHelper<Detail.DataStore.DataStoreDeleteParamInt>.IntrospectiveSort
	|
	|-RVA: 0x3795BA0 Offset: 0x3795CA1 VA: 0x3795BA0
	|-ArraySortHelper<Detail.DataStore.DataStoreGetMetaParamInt>.IntrospectiveSort
	|
	|-RVA: 0x37976B0 Offset: 0x37977B1 VA: 0x37976B0
	|-ArraySortHelper<Detail.DataStore.DataStoreMetaInfoInt>.IntrospectiveSort
	|
	|-RVA: 0x37990D0 Offset: 0x37991D1 VA: 0x37990D0
	|-ArraySortHelper<Detail.DataStore.DataStorePasswordInfoInt>.IntrospectiveSort
	|
	|-RVA: 0x379AA50 Offset: 0x379AB51 VA: 0x379AA50
	|-ArraySortHelper<Detail.DataStore.DataStorePersistenceInfoInt>.IntrospectiveSort
	|
	|-RVA: 0x379C450 Offset: 0x379C551 VA: 0x379C450
	|-ArraySortHelper<Detail.DataStore.DataStorePreparePostParamInt>.IntrospectiveSort
	|
	|-RVA: 0x379DDD0 Offset: 0x379DED1 VA: 0x379DDD0
	|-ArraySortHelper<Detail.DataStore.DataStoreRateObjectParamInt>.IntrospectiveSort
	|
	|-RVA: 0x379F640 Offset: 0x379F741 VA: 0x379F640
	|-ArraySortHelper<Detail.DataStore.DataStoreRatingInitParamInt>.IntrospectiveSort
	|
	|-RVA: 0x37A0F70 Offset: 0x37A1071 VA: 0x37A0F70
	|-ArraySortHelper<Detail.DataStore.DataStoreRatingTargetInt>.IntrospectiveSort
	|
	|-RVA: 0x37A2900 Offset: 0x37A2A01 VA: 0x37A2900
	|-ArraySortHelper<Detail.Ranking.RankingCachedResultInt>.IntrospectiveSort
	|
	|-RVA: 0x37A4420 Offset: 0x37A4521 VA: 0x37A4420
	|-ArraySortHelper<Detail.Ranking.RankingOrderParamInt>.IntrospectiveSort
	|
	|-RVA: 0x37A5DD0 Offset: 0x37A5ED1 VA: 0x37A5DD0
	|-ArraySortHelper<Detail.Ranking.RankingRankDataInt>.IntrospectiveSort
	|
	|-RVA: 0x37A7C00 Offset: 0x37A7D01 VA: 0x37A7C00
	|-ArraySortHelper<Detail.Ranking2.Ranking2ChartInfoInt>.IntrospectiveSort
	|
	|-RVA: 0x37A9B90 Offset: 0x37A9C91 VA: 0x37A9B90
	|-ArraySortHelper<Detail.Ranking2.Ranking2RankDataInt>.IntrospectiveSort
	|
	|-RVA: 0x37AB6D0 Offset: 0x37AB7D1 VA: 0x37AB6D0
	|-ArraySortHelper<Detail.Ranking2.Ranking2ScoreDataInt>.IntrospectiveSort
	|
	|-RVA: 0x37ACF40 Offset: 0x37AD041 VA: 0x37ACF40
	|-ArraySortHelper<Detail.Screening.ScreeningContextInfoInt>.IntrospectiveSort
	|
	|-RVA: 0x37AEAC0 Offset: 0x37AEBC1 VA: 0x37AEAC0
	|-ArraySortHelper<Detail.Subscriber.SubscriberContentInt>.IntrospectiveSort
	|
	|-RVA: 0x37B0780 Offset: 0x37B0881 VA: 0x37B0780
	|-ArraySortHelper<Detail.Subscriber.SubscriberGetContentParamInt>.IntrospectiveSort
	|
	|-RVA: 0x32BEB20 Offset: 0x32BEC21 VA: 0x32BEB20
	|-ArraySortHelper<Detail.Subscriber.SubscriberUserStatusInfoInt>.IntrospectiveSort
	|
	|-RVA: 0x32C05B0 Offset: 0x32C06B1 VA: 0x32C05B0
	|-ArraySortHelper<Detail.Subscriber.SubscriberUserStatusParamInt>.IntrospectiveSort
	|
	|-RVA: 0x32C1E20 Offset: 0x32C1F21 VA: 0x32C1E20
	|-ArraySortHelper<Detail.Utility.IntegerSettings>.IntrospectiveSort
	|
	|-RVA: 0x32C3550 Offset: 0x32C3651 VA: 0x32C3550
	|-ArraySortHelper<Detail.Utility.UniqueIdInfoInt>.IntrospectiveSort
	|
	|-RVA: 0x32C4CE0 Offset: 0x32C4DE1 VA: 0x32C4CE0
	|-ArraySortHelper<MapHistory.Rewind.LatestInspectorData>.IntrospectiveSort
	|
	|-RVA: 0x32C6550 Offset: 0x32C6651 VA: 0x32C6550
	|-ArraySortHelper<MapHistory.Rewind.WorkTerrainData>.IntrospectiveSort
	|
	|-RVA: 0x32C7D70 Offset: 0x32C7E71 VA: 0x32C7D70
	|-ArraySortHelper<MapKillBonus.Work.Pos>.IntrospectiveSort
	|
	|-RVA: 0x32C9600 Offset: 0x32C9701 VA: 0x32C9600
	|-ArraySortHelper<MapSkill.AroundCalculator.Result>.IntrospectiveSort
	|
	|-RVA: 0x32CAF20 Offset: 0x32CB021 VA: 0x32CAF20
	|-ArraySortHelper<TargetPositionCache.CacheCurve.Item>.IntrospectiveSort
	|
	|-RVA: 0x32CCA90 Offset: 0x32CCB91 VA: 0x32CCA90
	|-ArraySortHelper<TargetPositionCache.CacheEntry.RecordingItem>.IntrospectiveSort
	*/

	// RVA: -1 Offset: -1
	private static void IntroSort(T[] keys, int lo, int hi, int depthLimit, Comparison<T> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FFD960 Offset: 0x1FFDA61 VA: 0x1FFD960
	|-ArraySortHelper<IntervalTree.Entry<object>>.IntroSort
	|
	|-RVA: 0x1FFF310 Offset: 0x1FFF411 VA: 0x1FFF310
	|-ArraySortHelper<KeyValuePair<DateTime, object>>.IntroSort
	|
	|-RVA: 0x2000B80 Offset: 0x2000C81 VA: 0x2000B80
	|-ArraySortHelper<KeyValuePair<int, object>>.IntroSort
	|
	|-RVA: 0x2002460 Offset: 0x2002561 VA: 0x2002460
	|-ArraySortHelper<KeyValuePair<object, ValueTuple<int, DateTime, object>>>.IntroSort
	|
	|-RVA: 0x2003E60 Offset: 0x2003F61 VA: 0x2003E60
	|-ArraySortHelper<KeyValuePair<object, object>>.IntroSort
	|
	|-RVA: 0x2005760 Offset: 0x2005861 VA: 0x2005760
	|-ArraySortHelper<CommonBattleSequence.Reliance<object>>.IntroSort
	|
	|-RVA: 0x2007140 Offset: 0x2007241 VA: 0x2007140
	|-ArraySortHelper<RenderGraphResourcePool.ResourceLogInfo<object>>.IntroSort
	|
	|-RVA: 0x20089B0 Offset: 0x2008AB1 VA: 0x20089B0
	|-ArraySortHelper<ValueTuple<int, object>>.IntroSort
	|
	|-RVA: 0x200A110 Offset: 0x200A211 VA: 0x200A110
	|-ArraySortHelper<ValueTuple<Int32Enum, int>>.IntroSort
	|
	|-RVA: 0x200B940 Offset: 0x200BA41 VA: 0x200B940
	|-ArraySortHelper<ValueTuple<object, ValueTuple<object, int>>>.IntroSort
	|
	|-RVA: 0x200D320 Offset: 0x200D421 VA: 0x200D320
	|-ArraySortHelper<ValueTuple<object, int>>.IntroSort
	|
	|-RVA: 0x200EC00 Offset: 0x200ED01 VA: 0x200EC00
	|-ArraySortHelper<ValueTuple<Vector3, float>>.IntroSort
	|
	|-RVA: 0x2010580 Offset: 0x2010681 VA: 0x2010580
	|-ArraySortHelper<ValueTuple<object, Int32Enum, int>>.IntroSort
	|
	|-RVA: 0x3A807D0 Offset: 0x3A808D1 VA: 0x3A807D0
	|-ArraySortHelper<ValueTuple<object, int, int, int>>.IntroSort
	|
	|-RVA: 0x3A82070 Offset: 0x3A82171 VA: 0x3A82070
	|-ArraySortHelper<AnimatorClipInfo>.IntroSort
	|
	|-RVA: 0x3A838A0 Offset: 0x3A839A1 VA: 0x3A838A0
	|-ArraySortHelper<AsyncOperationHandle>.IntroSort
	|
	|-RVA: 0x3A85270 Offset: 0x3A85371 VA: 0x3A85270
	|-ArraySortHelper<BoneWeight>.IntroSort
	|
	|-RVA: 0x3A86B20 Offset: 0x3A86C21 VA: 0x3A86B20
	|-ArraySortHelper<bool>.IntroSort
	|
	|-RVA: 0x3A881E0 Offset: 0x3A882E1 VA: 0x3A881E0
	|-ArraySortHelper<byte>.IntroSort
	|
	|-RVA: 0x3A89980 Offset: 0x3A89A81 VA: 0x3A89980
	|-ArraySortHelper<CameraInfo>.IntroSort
	|
	|-RVA: 0x3A8B0E0 Offset: 0x3A8B1E1 VA: 0x3A8B0E0
	|-ArraySortHelper<char>.IntroSort
	|
	|-RVA: 0x3A8C8F0 Offset: 0x3A8C9F1 VA: 0x3A8C8F0
	|-ArraySortHelper<Color>.IntroSort
	|
	|-RVA: 0x3A8E130 Offset: 0x3A8E231 VA: 0x3A8E130
	|-ArraySortHelper<Color32>.IntroSort
	|
	|-RVA: 0x3A8F900 Offset: 0x3A8FA01 VA: 0x3A8F900
	|-ArraySortHelper<ConstraintSource>.IntroSort
	|
	|-RVA: 0x3A91200 Offset: 0x3A91301 VA: 0x3A91200
	|-ArraySortHelper<ContourVertex>.IntroSort
	|
	|-RVA: 0x3A92BB0 Offset: 0x3A92CB1 VA: 0x3A92BB0
	|-ArraySortHelper<DataStoreRatingInfo>.IntroSort
	|
	|-RVA: 0x3A94420 Offset: 0x3A94521 VA: 0x3A94420
	|-ArraySortHelper<DataStoreResult>.IntroSort
	|
	|-RVA: 0x3A95AB0 Offset: 0x3A95BB1 VA: 0x3A95AB0
	|-ArraySortHelper<DateTime>.IntroSort
	|
	|-RVA: 0x3A971E0 Offset: 0x3A972E1 VA: 0x3A971E0
	|-ArraySortHelper<DateTimeOffset>.IntroSort
	|
	|-RVA: 0x3A989C0 Offset: 0x3A98AC1 VA: 0x3A989C0
	|-ArraySortHelper<Decimal>.IntroSort
	|
	|-RVA: 0x3A9A350 Offset: 0x3A9A451 VA: 0x3A9A350
	|-ArraySortHelper<DiagnosticEvent>.IntroSort
	|
	|-RVA: 0x3A9BD10 Offset: 0x3A9BE11 VA: 0x3A9BD10
	|-ArraySortHelper<double>.IntroSort
	|
	|-RVA: 0x3A9D500 Offset: 0x3A9D601 VA: 0x3A9D500
	|-ArraySortHelper<Friend>.IntroSort
	|
	|-RVA: 0x3A9EE50 Offset: 0x3A9EF51 VA: 0x3A9EE50
	|-ArraySortHelper<GlyphRect>.IntroSort
	|
	|-RVA: 0x3AA0590 Offset: 0x3AA0691 VA: 0x3AA0590
	|-ArraySortHelper<short>.IntroSort
	|
	|-RVA: 0x3AA1C20 Offset: 0x3AA1D21 VA: 0x3AA1C20
	|-ArraySortHelper<int>.IntroSort
	|
	|-RVA: 0x3AA32B0 Offset: 0x3AA33B1 VA: 0x3AA32B0
	|-ArraySortHelper<Int32Enum>.IntroSort
	|
	|-RVA: 0x3AA4940 Offset: 0x3AA4A41 VA: 0x3AA4940
	|-ArraySortHelper<long>.IntroSort
	|
	|-RVA: 0x3AA5FD0 Offset: 0x3AA60D1 VA: 0x3AA5FD0
	|-ArraySortHelper<IntPtr>.IntroSort
	|
	|-RVA: 0x3AA77A0 Offset: 0x3AA78A1 VA: 0x3AA77A0
	|-ArraySortHelper<InterpretedFrameInfo>.IntroSort
	|
	|-RVA: 0x3AA9010 Offset: 0x3AA9111 VA: 0x3AA9010
	|-ArraySortHelper<IntervalTreeNode>.IntroSort
	|
	|-RVA: 0x3AAA880 Offset: 0x3AAA981 VA: 0x3AAA880
	|-ArraySortHelper<LengthLimitProperties>.IntroSort
	|
	|-RVA: 0x3AABF10 Offset: 0x3AAC011 VA: 0x3AABF10
	|-ArraySortHelper<MapPos>.IntroSort
	|
	|-RVA: 0x3AAD810 Offset: 0x3AAD911 VA: 0x3AAD810
	|-ArraySortHelper<Matrix4x4>.IntroSort
	|
	|-RVA: 0x394FA80 Offset: 0x394FB81 VA: 0x394FA80
	|-ArraySortHelper<object>.IntroSort
	|
	|-RVA: 0x3951360 Offset: 0x3951461 VA: 0x3951360
	|-ArraySortHelper<ObjectInitializationData>.IntroSort
	|
	|-RVA: 0x3952E90 Offset: 0x3952F91 VA: 0x3952E90
	|-ArraySortHelper<PlayableBinding>.IntroSort
	|
	|-RVA: 0x3954980 Offset: 0x3954A81 VA: 0x3954980
	|-ArraySortHelper<PlayerLoopSystem>.IntroSort
	|
	|-RVA: 0x3956550 Offset: 0x3956651 VA: 0x3956550
	|-ArraySortHelper<PlayerLoopSystemInternal>.IntroSort
	|
	|-RVA: 0x3958030 Offset: 0x3958131 VA: 0x3958030
	|-ArraySortHelper<RangePositionInfo>.IntroSort
	|
	|-RVA: 0x3959790 Offset: 0x3959891 VA: 0x3959790
	|-ArraySortHelper<Ranking2ChartInfoInput>.IntroSort
	|
	|-RVA: 0x395B080 Offset: 0x395B181 VA: 0x395B080
	|-ArraySortHelper<RaycastHit>.IntroSort
	|
	|-RVA: 0x395CD20 Offset: 0x395CE21 VA: 0x395CD20
	|-ArraySortHelper<RaycastHit2D>.IntroSort
	|
	|-RVA: 0x395EAA0 Offset: 0x395EBA1 VA: 0x395EAA0
	|-ArraySortHelper<RaycastResult>.IntroSort
	|
	|-RVA: 0x39607E0 Offset: 0x39608E1 VA: 0x39607E0
	|-ArraySortHelper<Rect>.IntroSort
	|
	|-RVA: 0x3962020 Offset: 0x3962121 VA: 0x3962020
	|-ArraySortHelper<RendererListHandle>.IntroSort
	|
	|-RVA: 0x39636B0 Offset: 0x39637B1 VA: 0x39636B0
	|-ArraySortHelper<ResourceHandle>.IntroSort
	|
	|-RVA: 0x3964D40 Offset: 0x3964E41 VA: 0x3964D40
	|-ArraySortHelper<sbyte>.IntroSort
	|
	|-RVA: 0x39663D0 Offset: 0x39664D1 VA: 0x39663D0
	|-ArraySortHelper<ShaderTagId>.IntroSort
	|
	|-RVA: 0x3967A70 Offset: 0x3967B71 VA: 0x3967A70
	|-ArraySortHelper<float>.IntroSort
	|
	|-RVA: 0x39695C0 Offset: 0x39696C1 VA: 0x39695C0
	|-ArraySortHelper<SphericalHarmonicsL2>.IntroSort
	|
	|-RVA: 0x396B720 Offset: 0x396B821 VA: 0x396B720
	|-ArraySortHelper<SubMeshDescriptor>.IntroSort
	|
	|-RVA: 0x396D1D0 Offset: 0x396D2D1 VA: 0x396D1D0
	|-ArraySortHelper<TablePair>.IntroSort
	|
	|-RVA: 0x396E930 Offset: 0x396EA31 VA: 0x396E930
	|-ArraySortHelper<TimeSpan>.IntroSort
	|
	|-RVA: 0x39700F0 Offset: 0x39701F1 VA: 0x39700F0
	|-ArraySortHelper<UICharInfo>.IntroSort
	|
	|-RVA: 0x3971990 Offset: 0x3971A91 VA: 0x3971990
	|-ArraySortHelper<UILineInfo>.IntroSort
	|
	|-RVA: 0x3973590 Offset: 0x3973691 VA: 0x3973590
	|-ArraySortHelper<UIVertex>.IntroSort
	|
	|-RVA: 0x3975520 Offset: 0x3975621 VA: 0x3975520
	|-ArraySortHelper<ushort>.IntroSort
	|
	|-RVA: 0x3976BB0 Offset: 0x3976CB1 VA: 0x3976BB0
	|-ArraySortHelper<uint>.IntroSort
	|
	|-RVA: 0x3978240 Offset: 0x3978341 VA: 0x3978240
	|-ArraySortHelper<ulong>.IntroSort
	|
	|-RVA: 0x3979960 Offset: 0x3979A61 VA: 0x3979960
	|-ArraySortHelper<Vector2>.IntroSort
	|
	|-RVA: 0x397B1D0 Offset: 0x397B2D1 VA: 0x397B1D0
	|-ArraySortHelper<Vector3>.IntroSort
	|
	|-RVA: 0x397CB50 Offset: 0x397CC51 VA: 0x397CB50
	|-ArraySortHelper<Vector4>.IntroSort
	|
	|-RVA: 0x397E430 Offset: 0x397E531 VA: 0x397E430
	|-ArraySortHelper<VertexAttributeDescriptor>.IntroSort
	|
	|-RVA: 0x397FC80 Offset: 0x397FD81 VA: 0x397FC80
	|-ArraySortHelper<X509ChainStatus>.IntroSort
	|
	|-RVA: 0x391F010 Offset: 0x391F111 VA: 0x391F010
	|-ArraySortHelper<XRView>.IntroSort
	|
	|-RVA: 0x3920A70 Offset: 0x3920B71 VA: 0x3920A70
	|-ArraySortHelper<AmiiboSequence.GainItemData>.IntroSort
	|
	|-RVA: 0x3922390 Offset: 0x3922491 VA: 0x3922390
	|-ArraySortHelper<AnimationOutputWeightProcessor.WeightInfo>.IntroSort
	|
	|-RVA: 0x3923E50 Offset: 0x3923F51 VA: 0x3923E50
	|-ArraySortHelper<ArenaOrderSequence.GodInfo>.IntroSort
	|
	|-RVA: 0x39256F0 Offset: 0x39257F1 VA: 0x39256F0
	|-ArraySortHelper<BattleInfo.SupportData>.IntroSort
	|
	|-RVA: 0x3926F60 Offset: 0x3927061 VA: 0x3926F60
	|-ArraySortHelper<BeforeRenderHelper.OrderBlock>.IntroSort
	|
	|-RVA: 0x3928860 Offset: 0x3928961 VA: 0x3928860
	|-ArraySortHelper<Camera.RenderRequest>.IntroSort
	|
	|-RVA: 0x392A250 Offset: 0x392A351 VA: 0x392A250
	|-ArraySortHelper<CameraState.CustomBlendable>.IntroSort
	|
	|-RVA: 0x392B9B0 Offset: 0x392BAB1 VA: 0x392B9B0
	|-ArraySortHelper<CinemachineClearShot.Pair>.IntroSort
	|
	|-RVA: 0x392D040 Offset: 0x392D141 VA: 0x392D040
	|-ArraySortHelper<CinemachineStateDrivenCamera.HashPair>.IntroSort
	|
	|-RVA: 0x392E800 Offset: 0x392E901 VA: 0x392E800
	|-ArraySortHelper<DeferredTiler.PrePunctualLight>.IntroSort
	|
	|-RVA: 0x3930220 Offset: 0x3930321 VA: 0x3930220
	|-ArraySortHelper<DelayedActionManager.DelegateInfo>.IntroSort
	|
	|-RVA: 0x3931CB0 Offset: 0x3931DB1 VA: 0x3931CB0
	|-ArraySortHelper<Detail.AsyncResultInt>.IntroSort
	|
	|-RVA: 0x39336C0 Offset: 0x39337C1 VA: 0x39336C0
	|-ArraySortHelper<Detail.CppArray>.IntroSort
	|
	|-RVA: 0x3934FD0 Offset: 0x39350D1 VA: 0x3934FD0
	|-ArraySortHelper<Detail.NotificationEventInt>.IntroSort
	|
	|-RVA: 0x3936A80 Offset: 0x3936B81 VA: 0x3936A80
	|-ArraySortHelper<DragonRideTargetGroup.ChainParam>.IntroSort
	|
	|-RVA: 0x3938380 Offset: 0x3938481 VA: 0x3938380
	|-ArraySortHelper<GmapPathAdjuster.TargetModel>.IntroSort
	|
	|-RVA: 0x3939DC0 Offset: 0x3939EC1 VA: 0x3939DC0
	|-ArraySortHelper<GmapSpotAdjuster.TargetModel>.IntroSort
	|
	|-RVA: 0x393B800 Offset: 0x393B901 VA: 0x393B800
	|-ArraySortHelper<HubFastTravel.Location>.IntroSort
	|
	|-RVA: 0x393D2F0 Offset: 0x393D3F1 VA: 0x393D2F0
	|-ArraySortHelper<HubLensFlare.Flare>.IntroSort
	|
	|-RVA: 0x393EDB0 Offset: 0x393EEB1 VA: 0x393EDB0
	|-ArraySortHelper<InventoryPoolItemMenuContent.KindBgNameClass>.IntroSort
	|
	|-RVA: 0x3940510 Offset: 0x3940611 VA: 0x3940510
	|-ArraySortHelper<Map.Pos>.IntroSort
	|
	|-RVA: 0x3941C40 Offset: 0x3941D41 VA: 0x3941C40
	|-ArraySortHelper<MapImage.BackupTerrain>.IntroSort
	|
	|-RVA: 0x3943380 Offset: 0x3943481 VA: 0x3943380
	|-ArraySortHelper<MapImageRange.Pos>.IntroSort
	|
	|-RVA: 0x3944C70 Offset: 0x3944D71 VA: 0x3944C70
	|-ArraySortHelper<MapMind.Target>.IntroSort
	|
	|-RVA: 0x3946620 Offset: 0x3946721 VA: 0x3946620
	|-ArraySortHelper<MapPanelDebug.Entity>.IntroSort
	|
	|-RVA: 0x3947E90 Offset: 0x3947F91 VA: 0x3947E90
	|-ArraySortHelper<NexRanking.Data>.IntroSort
	|
	|-RVA: 0x39495C0 Offset: 0x39496C1 VA: 0x39495C0
	|-ArraySortHelper<NexVersus.RatingData>.IntroSort
	|
	|-RVA: 0x394AE10 Offset: 0x394AF11 VA: 0x394AE10
	|-ArraySortHelper<PackedPlayModeBuildLogs.RuntimeBuildLog>.IntroSort
	|
	|-RVA: 0x394C700 Offset: 0x394C801 VA: 0x394C700
	|-ArraySortHelper<ParticleSystem.Particle>.IntroSort
	|
	|-RVA: 0x394E180 Offset: 0x394E281 VA: 0x394E180
	|-ArraySortHelper<ProfileCard.SortieCount>.IntroSort
	|
	|-RVA: 0x377F570 Offset: 0x377F671 VA: 0x377F570
	|-ArraySortHelper<RangeData.Offset>.IntroSort
	|
	|-RVA: 0x3780D80 Offset: 0x3780E81 VA: 0x3780D80
	|-ArraySortHelper<RenderGraphDebugData.PassDebugData>.IntroSort
	|
	|-RVA: 0x3782870 Offset: 0x3782971 VA: 0x3782870
	|-ArraySortHelper<RenderGraphDebugData.ResourceDebugData>.IntroSort
	|
	|-RVA: 0x3784350 Offset: 0x3784451 VA: 0x3784350
	|-ArraySortHelper<RingCleaningUnitSelectMenu.GodParam>.IntroSort
	|
	|-RVA: 0x3785C70 Offset: 0x3785D71 VA: 0x3785C70
	|-ArraySortHelper<ShadowUtility.Edge>.IntroSort
	|
	|-RVA: 0x37875E0 Offset: 0x37876E1 VA: 0x37875E0
	|-ArraySortHelper<SkillArray.Entity>.IntroSort
	|
	|-RVA: 0x3788F20 Offset: 0x3789021 VA: 0x3788F20
	|-ArraySortHelper<TexturePacker_JsonArray.Frame>.IntroSort
	|
	|-RVA: 0x378AB90 Offset: 0x378AC91 VA: 0x378AB90
	|-ArraySortHelper<TimeNotificationBehaviour.NotificationEntry>.IntroSort
	|
	|-RVA: 0x378C5E0 Offset: 0x378C6E1 VA: 0x378C5E0
	|-ArraySortHelper<UnitySynchronizationContext.WorkRequest>.IntroSort
	|
	|-RVA: 0x378DFC0 Offset: 0x378E0C1 VA: 0x378DFC0
	|-ArraySortHelper<XmlSchemaObjectTable.XmlSchemaObjectEntry>.IntroSort
	|
	|-RVA: 0x378F720 Offset: 0x378F821 VA: 0x378F720
	|-ArraySortHelper<AIThink.EnchantThink.ItemInfo>.IntroSort
	|
	|-RVA: 0x3790FB0 Offset: 0x37910B1 VA: 0x3790FB0
	|-ArraySortHelper<AssetBundleBuildMap.AssetBundleEntry.AssetPathString>.IntroSort
	|
	|-RVA: 0x3792910 Offset: 0x3792A11 VA: 0x3792910
	|-ArraySortHelper<Detail.DataStore.DataStoreChangeMetaParamInt>.IntroSort
	|
	|-RVA: 0x3794370 Offset: 0x3794471 VA: 0x3794370
	|-ArraySortHelper<Detail.DataStore.DataStoreDeleteParamInt>.IntroSort
	|
	|-RVA: 0x3795C70 Offset: 0x3795D71 VA: 0x3795C70
	|-ArraySortHelper<Detail.DataStore.DataStoreGetMetaParamInt>.IntroSort
	|
	|-RVA: 0x3797780 Offset: 0x3797881 VA: 0x3797780
	|-ArraySortHelper<Detail.DataStore.DataStoreMetaInfoInt>.IntroSort
	|
	|-RVA: 0x37991A0 Offset: 0x37992A1 VA: 0x37991A0
	|-ArraySortHelper<Detail.DataStore.DataStorePasswordInfoInt>.IntroSort
	|
	|-RVA: 0x379AB20 Offset: 0x379AC21 VA: 0x379AB20
	|-ArraySortHelper<Detail.DataStore.DataStorePersistenceInfoInt>.IntroSort
	|
	|-RVA: 0x379C520 Offset: 0x379C621 VA: 0x379C520
	|-ArraySortHelper<Detail.DataStore.DataStorePreparePostParamInt>.IntroSort
	|
	|-RVA: 0x379DEA0 Offset: 0x379DFA1 VA: 0x379DEA0
	|-ArraySortHelper<Detail.DataStore.DataStoreRateObjectParamInt>.IntroSort
	|
	|-RVA: 0x379F710 Offset: 0x379F811 VA: 0x379F710
	|-ArraySortHelper<Detail.DataStore.DataStoreRatingInitParamInt>.IntroSort
	|
	|-RVA: 0x37A1040 Offset: 0x37A1141 VA: 0x37A1040
	|-ArraySortHelper<Detail.DataStore.DataStoreRatingTargetInt>.IntroSort
	|
	|-RVA: 0x37A29D0 Offset: 0x37A2AD1 VA: 0x37A29D0
	|-ArraySortHelper<Detail.Ranking.RankingCachedResultInt>.IntroSort
	|
	|-RVA: 0x37A44F0 Offset: 0x37A45F1 VA: 0x37A44F0
	|-ArraySortHelper<Detail.Ranking.RankingOrderParamInt>.IntroSort
	|
	|-RVA: 0x37A5EA0 Offset: 0x37A5FA1 VA: 0x37A5EA0
	|-ArraySortHelper<Detail.Ranking.RankingRankDataInt>.IntroSort
	|
	|-RVA: 0x37A7CD0 Offset: 0x37A7DD1 VA: 0x37A7CD0
	|-ArraySortHelper<Detail.Ranking2.Ranking2ChartInfoInt>.IntroSort
	|
	|-RVA: 0x37A9C60 Offset: 0x37A9D61 VA: 0x37A9C60
	|-ArraySortHelper<Detail.Ranking2.Ranking2RankDataInt>.IntroSort
	|
	|-RVA: 0x37AB7A0 Offset: 0x37AB8A1 VA: 0x37AB7A0
	|-ArraySortHelper<Detail.Ranking2.Ranking2ScoreDataInt>.IntroSort
	|
	|-RVA: 0x37AD010 Offset: 0x37AD111 VA: 0x37AD010
	|-ArraySortHelper<Detail.Screening.ScreeningContextInfoInt>.IntroSort
	|
	|-RVA: 0x37AEB90 Offset: 0x37AEC91 VA: 0x37AEB90
	|-ArraySortHelper<Detail.Subscriber.SubscriberContentInt>.IntroSort
	|
	|-RVA: 0x37B0850 Offset: 0x37B0951 VA: 0x37B0850
	|-ArraySortHelper<Detail.Subscriber.SubscriberGetContentParamInt>.IntroSort
	|
	|-RVA: 0x32BEBF0 Offset: 0x32BECF1 VA: 0x32BEBF0
	|-ArraySortHelper<Detail.Subscriber.SubscriberUserStatusInfoInt>.IntroSort
	|
	|-RVA: 0x32C0680 Offset: 0x32C0781 VA: 0x32C0680
	|-ArraySortHelper<Detail.Subscriber.SubscriberUserStatusParamInt>.IntroSort
	|
	|-RVA: 0x32C1EF0 Offset: 0x32C1FF1 VA: 0x32C1EF0
	|-ArraySortHelper<Detail.Utility.IntegerSettings>.IntroSort
	|
	|-RVA: 0x32C3620 Offset: 0x32C3721 VA: 0x32C3620
	|-ArraySortHelper<Detail.Utility.UniqueIdInfoInt>.IntroSort
	|
	|-RVA: 0x32C4DB0 Offset: 0x32C4EB1 VA: 0x32C4DB0
	|-ArraySortHelper<MapHistory.Rewind.LatestInspectorData>.IntroSort
	|
	|-RVA: 0x32C6620 Offset: 0x32C6721 VA: 0x32C6620
	|-ArraySortHelper<MapHistory.Rewind.WorkTerrainData>.IntroSort
	|
	|-RVA: 0x32C7E40 Offset: 0x32C7F41 VA: 0x32C7E40
	|-ArraySortHelper<MapKillBonus.Work.Pos>.IntroSort
	|
	|-RVA: 0x32C96D0 Offset: 0x32C97D1 VA: 0x32C96D0
	|-ArraySortHelper<MapSkill.AroundCalculator.Result>.IntroSort
	|
	|-RVA: 0x32CAFF0 Offset: 0x32CB0F1 VA: 0x32CAFF0
	|-ArraySortHelper<TargetPositionCache.CacheCurve.Item>.IntroSort
	|
	|-RVA: 0x32CCB60 Offset: 0x32CCC61 VA: 0x32CCB60
	|-ArraySortHelper<TargetPositionCache.CacheEntry.RecordingItem>.IntroSort
	*/

	// RVA: -1 Offset: -1
	private static int PickPivotAndPartition(T[] keys, int lo, int hi, Comparison<T> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FFDD00 Offset: 0x1FFDE01 VA: 0x1FFDD00
	|-ArraySortHelper<IntervalTree.Entry<object>>.PickPivotAndPartition
	|
	|-RVA: 0x1FFF6B0 Offset: 0x1FFF7B1 VA: 0x1FFF6B0
	|-ArraySortHelper<KeyValuePair<DateTime, object>>.PickPivotAndPartition
	|
	|-RVA: 0x2000F20 Offset: 0x2001021 VA: 0x2000F20
	|-ArraySortHelper<KeyValuePair<int, object>>.PickPivotAndPartition
	|
	|-RVA: 0x2002800 Offset: 0x2002901 VA: 0x2002800
	|-ArraySortHelper<KeyValuePair<object, ValueTuple<int, DateTime, object>>>.PickPivotAndPartition
	|
	|-RVA: 0x2004200 Offset: 0x2004301 VA: 0x2004200
	|-ArraySortHelper<KeyValuePair<object, object>>.PickPivotAndPartition
	|
	|-RVA: 0x2005B00 Offset: 0x2005C01 VA: 0x2005B00
	|-ArraySortHelper<CommonBattleSequence.Reliance<object>>.PickPivotAndPartition
	|
	|-RVA: 0x20074E0 Offset: 0x20075E1 VA: 0x20074E0
	|-ArraySortHelper<RenderGraphResourcePool.ResourceLogInfo<object>>.PickPivotAndPartition
	|
	|-RVA: 0x2008D50 Offset: 0x2008E51 VA: 0x2008D50
	|-ArraySortHelper<ValueTuple<int, object>>.PickPivotAndPartition
	|
	|-RVA: 0x200A4B0 Offset: 0x200A5B1 VA: 0x200A4B0
	|-ArraySortHelper<ValueTuple<Int32Enum, int>>.PickPivotAndPartition
	|
	|-RVA: 0x200BCE0 Offset: 0x200BDE1 VA: 0x200BCE0
	|-ArraySortHelper<ValueTuple<object, ValueTuple<object, int>>>.PickPivotAndPartition
	|
	|-RVA: 0x200D6C0 Offset: 0x200D7C1 VA: 0x200D6C0
	|-ArraySortHelper<ValueTuple<object, int>>.PickPivotAndPartition
	|
	|-RVA: 0x200EFA0 Offset: 0x200F0A1 VA: 0x200EFA0
	|-ArraySortHelper<ValueTuple<Vector3, float>>.PickPivotAndPartition
	|
	|-RVA: 0x2010920 Offset: 0x2010A21 VA: 0x2010920
	|-ArraySortHelper<ValueTuple<object, Int32Enum, int>>.PickPivotAndPartition
	|
	|-RVA: 0x3A80B70 Offset: 0x3A80C71 VA: 0x3A80B70
	|-ArraySortHelper<ValueTuple<object, int, int, int>>.PickPivotAndPartition
	|
	|-RVA: 0x3A82410 Offset: 0x3A82511 VA: 0x3A82410
	|-ArraySortHelper<AnimatorClipInfo>.PickPivotAndPartition
	|
	|-RVA: 0x3A83C40 Offset: 0x3A83D41 VA: 0x3A83C40
	|-ArraySortHelper<AsyncOperationHandle>.PickPivotAndPartition
	|
	|-RVA: 0x3A85610 Offset: 0x3A85711 VA: 0x3A85610
	|-ArraySortHelper<BoneWeight>.PickPivotAndPartition
	|
	|-RVA: 0x3A86EC0 Offset: 0x3A86FC1 VA: 0x3A86EC0
	|-ArraySortHelper<bool>.PickPivotAndPartition
	|
	|-RVA: 0x3A88580 Offset: 0x3A88681 VA: 0x3A88580
	|-ArraySortHelper<byte>.PickPivotAndPartition
	|
	|-RVA: 0x3A89D20 Offset: 0x3A89E21 VA: 0x3A89D20
	|-ArraySortHelper<CameraInfo>.PickPivotAndPartition
	|
	|-RVA: 0x3A8B480 Offset: 0x3A8B581 VA: 0x3A8B480
	|-ArraySortHelper<char>.PickPivotAndPartition
	|
	|-RVA: 0x3A8CC90 Offset: 0x3A8CD91 VA: 0x3A8CC90
	|-ArraySortHelper<Color>.PickPivotAndPartition
	|
	|-RVA: 0x3A8E4D0 Offset: 0x3A8E5D1 VA: 0x3A8E4D0
	|-ArraySortHelper<Color32>.PickPivotAndPartition
	|
	|-RVA: 0x3A8FCA0 Offset: 0x3A8FDA1 VA: 0x3A8FCA0
	|-ArraySortHelper<ConstraintSource>.PickPivotAndPartition
	|
	|-RVA: 0x3A915A0 Offset: 0x3A916A1 VA: 0x3A915A0
	|-ArraySortHelper<ContourVertex>.PickPivotAndPartition
	|
	|-RVA: 0x3A92F50 Offset: 0x3A93051 VA: 0x3A92F50
	|-ArraySortHelper<DataStoreRatingInfo>.PickPivotAndPartition
	|
	|-RVA: 0x3A947C0 Offset: 0x3A948C1 VA: 0x3A947C0
	|-ArraySortHelper<DataStoreResult>.PickPivotAndPartition
	|
	|-RVA: 0x3A95E50 Offset: 0x3A95F51 VA: 0x3A95E50
	|-ArraySortHelper<DateTime>.PickPivotAndPartition
	|
	|-RVA: 0x3A97580 Offset: 0x3A97681 VA: 0x3A97580
	|-ArraySortHelper<DateTimeOffset>.PickPivotAndPartition
	|
	|-RVA: 0x3A98D60 Offset: 0x3A98E61 VA: 0x3A98D60
	|-ArraySortHelper<Decimal>.PickPivotAndPartition
	|
	|-RVA: 0x3A9A6F0 Offset: 0x3A9A7F1 VA: 0x3A9A6F0
	|-ArraySortHelper<DiagnosticEvent>.PickPivotAndPartition
	|
	|-RVA: 0x3A9C0B0 Offset: 0x3A9C1B1 VA: 0x3A9C0B0
	|-ArraySortHelper<double>.PickPivotAndPartition
	|
	|-RVA: 0x3A9D8A0 Offset: 0x3A9D9A1 VA: 0x3A9D8A0
	|-ArraySortHelper<Friend>.PickPivotAndPartition
	|
	|-RVA: 0x3A9F1F0 Offset: 0x3A9F2F1 VA: 0x3A9F1F0
	|-ArraySortHelper<GlyphRect>.PickPivotAndPartition
	|
	|-RVA: 0x3AA0930 Offset: 0x3AA0A31 VA: 0x3AA0930
	|-ArraySortHelper<short>.PickPivotAndPartition
	|
	|-RVA: 0x3AA1FC0 Offset: 0x3AA20C1 VA: 0x3AA1FC0
	|-ArraySortHelper<int>.PickPivotAndPartition
	|
	|-RVA: 0x3AA3650 Offset: 0x3AA3751 VA: 0x3AA3650
	|-ArraySortHelper<Int32Enum>.PickPivotAndPartition
	|
	|-RVA: 0x3AA4CE0 Offset: 0x3AA4DE1 VA: 0x3AA4CE0
	|-ArraySortHelper<long>.PickPivotAndPartition
	|
	|-RVA: 0x3AA6370 Offset: 0x3AA6471 VA: 0x3AA6370
	|-ArraySortHelper<IntPtr>.PickPivotAndPartition
	|
	|-RVA: 0x3AA7B40 Offset: 0x3AA7C41 VA: 0x3AA7B40
	|-ArraySortHelper<InterpretedFrameInfo>.PickPivotAndPartition
	|
	|-RVA: 0x3AA93B0 Offset: 0x3AA94B1 VA: 0x3AA93B0
	|-ArraySortHelper<IntervalTreeNode>.PickPivotAndPartition
	|
	|-RVA: 0x3AAAC20 Offset: 0x3AAAD21 VA: 0x3AAAC20
	|-ArraySortHelper<LengthLimitProperties>.PickPivotAndPartition
	|
	|-RVA: 0x3AAC2B0 Offset: 0x3AAC3B1 VA: 0x3AAC2B0
	|-ArraySortHelper<MapPos>.PickPivotAndPartition
	|
	|-RVA: 0x3AADBB0 Offset: 0x3AADCB1 VA: 0x3AADBB0
	|-ArraySortHelper<Matrix4x4>.PickPivotAndPartition
	|
	|-RVA: 0x394FE20 Offset: 0x394FF21 VA: 0x394FE20
	|-ArraySortHelper<object>.PickPivotAndPartition
	|
	|-RVA: 0x3951700 Offset: 0x3951801 VA: 0x3951700
	|-ArraySortHelper<ObjectInitializationData>.PickPivotAndPartition
	|
	|-RVA: 0x3953230 Offset: 0x3953331 VA: 0x3953230
	|-ArraySortHelper<PlayableBinding>.PickPivotAndPartition
	|
	|-RVA: 0x3954D20 Offset: 0x3954E21 VA: 0x3954D20
	|-ArraySortHelper<PlayerLoopSystem>.PickPivotAndPartition
	|
	|-RVA: 0x39568F0 Offset: 0x39569F1 VA: 0x39568F0
	|-ArraySortHelper<PlayerLoopSystemInternal>.PickPivotAndPartition
	|
	|-RVA: 0x39583D0 Offset: 0x39584D1 VA: 0x39583D0
	|-ArraySortHelper<RangePositionInfo>.PickPivotAndPartition
	|
	|-RVA: 0x3959B30 Offset: 0x3959C31 VA: 0x3959B30
	|-ArraySortHelper<Ranking2ChartInfoInput>.PickPivotAndPartition
	|
	|-RVA: 0x395B420 Offset: 0x395B521 VA: 0x395B420
	|-ArraySortHelper<RaycastHit>.PickPivotAndPartition
	|
	|-RVA: 0x395D0C0 Offset: 0x395D1C1 VA: 0x395D0C0
	|-ArraySortHelper<RaycastHit2D>.PickPivotAndPartition
	|
	|-RVA: 0x395EE40 Offset: 0x395EF41 VA: 0x395EE40
	|-ArraySortHelper<RaycastResult>.PickPivotAndPartition
	|
	|-RVA: 0x3960B80 Offset: 0x3960C81 VA: 0x3960B80
	|-ArraySortHelper<Rect>.PickPivotAndPartition
	|
	|-RVA: 0x39623C0 Offset: 0x39624C1 VA: 0x39623C0
	|-ArraySortHelper<RendererListHandle>.PickPivotAndPartition
	|
	|-RVA: 0x3963A50 Offset: 0x3963B51 VA: 0x3963A50
	|-ArraySortHelper<ResourceHandle>.PickPivotAndPartition
	|
	|-RVA: 0x39650E0 Offset: 0x39651E1 VA: 0x39650E0
	|-ArraySortHelper<sbyte>.PickPivotAndPartition
	|
	|-RVA: 0x3966770 Offset: 0x3966871 VA: 0x3966770
	|-ArraySortHelper<ShaderTagId>.PickPivotAndPartition
	|
	|-RVA: 0x3967E10 Offset: 0x3967F11 VA: 0x3967E10
	|-ArraySortHelper<float>.PickPivotAndPartition
	|
	|-RVA: 0x3969960 Offset: 0x3969A61 VA: 0x3969960
	|-ArraySortHelper<SphericalHarmonicsL2>.PickPivotAndPartition
	|
	|-RVA: 0x396BAC0 Offset: 0x396BBC1 VA: 0x396BAC0
	|-ArraySortHelper<SubMeshDescriptor>.PickPivotAndPartition
	|
	|-RVA: 0x396D570 Offset: 0x396D671 VA: 0x396D570
	|-ArraySortHelper<TablePair>.PickPivotAndPartition
	|
	|-RVA: 0x396ECD0 Offset: 0x396EDD1 VA: 0x396ECD0
	|-ArraySortHelper<TimeSpan>.PickPivotAndPartition
	|
	|-RVA: 0x3970490 Offset: 0x3970591 VA: 0x3970490
	|-ArraySortHelper<UICharInfo>.PickPivotAndPartition
	|
	|-RVA: 0x3971D30 Offset: 0x3971E31 VA: 0x3971D30
	|-ArraySortHelper<UILineInfo>.PickPivotAndPartition
	|
	|-RVA: 0x3973930 Offset: 0x3973A31 VA: 0x3973930
	|-ArraySortHelper<UIVertex>.PickPivotAndPartition
	|
	|-RVA: 0x39758C0 Offset: 0x39759C1 VA: 0x39758C0
	|-ArraySortHelper<ushort>.PickPivotAndPartition
	|
	|-RVA: 0x3976F50 Offset: 0x3977051 VA: 0x3976F50
	|-ArraySortHelper<uint>.PickPivotAndPartition
	|
	|-RVA: 0x39785E0 Offset: 0x39786E1 VA: 0x39785E0
	|-ArraySortHelper<ulong>.PickPivotAndPartition
	|
	|-RVA: 0x3979D00 Offset: 0x3979E01 VA: 0x3979D00
	|-ArraySortHelper<Vector2>.PickPivotAndPartition
	|
	|-RVA: 0x397B570 Offset: 0x397B671 VA: 0x397B570
	|-ArraySortHelper<Vector3>.PickPivotAndPartition
	|
	|-RVA: 0x397CEF0 Offset: 0x397CFF1 VA: 0x397CEF0
	|-ArraySortHelper<Vector4>.PickPivotAndPartition
	|
	|-RVA: 0x397E7D0 Offset: 0x397E8D1 VA: 0x397E7D0
	|-ArraySortHelper<VertexAttributeDescriptor>.PickPivotAndPartition
	|
	|-RVA: 0x3980020 Offset: 0x3980121 VA: 0x3980020
	|-ArraySortHelper<X509ChainStatus>.PickPivotAndPartition
	|
	|-RVA: 0x391F3B0 Offset: 0x391F4B1 VA: 0x391F3B0
	|-ArraySortHelper<XRView>.PickPivotAndPartition
	|
	|-RVA: 0x3920E10 Offset: 0x3920F11 VA: 0x3920E10
	|-ArraySortHelper<AmiiboSequence.GainItemData>.PickPivotAndPartition
	|
	|-RVA: 0x3922730 Offset: 0x3922831 VA: 0x3922730
	|-ArraySortHelper<AnimationOutputWeightProcessor.WeightInfo>.PickPivotAndPartition
	|
	|-RVA: 0x39241F0 Offset: 0x39242F1 VA: 0x39241F0
	|-ArraySortHelper<ArenaOrderSequence.GodInfo>.PickPivotAndPartition
	|
	|-RVA: 0x3925A90 Offset: 0x3925B91 VA: 0x3925A90
	|-ArraySortHelper<BattleInfo.SupportData>.PickPivotAndPartition
	|
	|-RVA: 0x3927300 Offset: 0x3927401 VA: 0x3927300
	|-ArraySortHelper<BeforeRenderHelper.OrderBlock>.PickPivotAndPartition
	|
	|-RVA: 0x3928C00 Offset: 0x3928D01 VA: 0x3928C00
	|-ArraySortHelper<Camera.RenderRequest>.PickPivotAndPartition
	|
	|-RVA: 0x392A5F0 Offset: 0x392A6F1 VA: 0x392A5F0
	|-ArraySortHelper<CameraState.CustomBlendable>.PickPivotAndPartition
	|
	|-RVA: 0x392BD50 Offset: 0x392BE51 VA: 0x392BD50
	|-ArraySortHelper<CinemachineClearShot.Pair>.PickPivotAndPartition
	|
	|-RVA: 0x392D3E0 Offset: 0x392D4E1 VA: 0x392D3E0
	|-ArraySortHelper<CinemachineStateDrivenCamera.HashPair>.PickPivotAndPartition
	|
	|-RVA: 0x392EBA0 Offset: 0x392ECA1 VA: 0x392EBA0
	|-ArraySortHelper<DeferredTiler.PrePunctualLight>.PickPivotAndPartition
	|
	|-RVA: 0x39305C0 Offset: 0x39306C1 VA: 0x39305C0
	|-ArraySortHelper<DelayedActionManager.DelegateInfo>.PickPivotAndPartition
	|
	|-RVA: 0x3932050 Offset: 0x3932151 VA: 0x3932050
	|-ArraySortHelper<Detail.AsyncResultInt>.PickPivotAndPartition
	|
	|-RVA: 0x3933A60 Offset: 0x3933B61 VA: 0x3933A60
	|-ArraySortHelper<Detail.CppArray>.PickPivotAndPartition
	|
	|-RVA: 0x3935370 Offset: 0x3935471 VA: 0x3935370
	|-ArraySortHelper<Detail.NotificationEventInt>.PickPivotAndPartition
	|
	|-RVA: 0x3936E20 Offset: 0x3936F21 VA: 0x3936E20
	|-ArraySortHelper<DragonRideTargetGroup.ChainParam>.PickPivotAndPartition
	|
	|-RVA: 0x3938720 Offset: 0x3938821 VA: 0x3938720
	|-ArraySortHelper<GmapPathAdjuster.TargetModel>.PickPivotAndPartition
	|
	|-RVA: 0x393A160 Offset: 0x393A261 VA: 0x393A160
	|-ArraySortHelper<GmapSpotAdjuster.TargetModel>.PickPivotAndPartition
	|
	|-RVA: 0x393BBA0 Offset: 0x393BCA1 VA: 0x393BBA0
	|-ArraySortHelper<HubFastTravel.Location>.PickPivotAndPartition
	|
	|-RVA: 0x393D690 Offset: 0x393D791 VA: 0x393D690
	|-ArraySortHelper<HubLensFlare.Flare>.PickPivotAndPartition
	|
	|-RVA: 0x393F150 Offset: 0x393F251 VA: 0x393F150
	|-ArraySortHelper<InventoryPoolItemMenuContent.KindBgNameClass>.PickPivotAndPartition
	|
	|-RVA: 0x39408B0 Offset: 0x39409B1 VA: 0x39408B0
	|-ArraySortHelper<Map.Pos>.PickPivotAndPartition
	|
	|-RVA: 0x3941FE0 Offset: 0x39420E1 VA: 0x3941FE0
	|-ArraySortHelper<MapImage.BackupTerrain>.PickPivotAndPartition
	|
	|-RVA: 0x3943720 Offset: 0x3943821 VA: 0x3943720
	|-ArraySortHelper<MapImageRange.Pos>.PickPivotAndPartition
	|
	|-RVA: 0x3945010 Offset: 0x3945111 VA: 0x3945010
	|-ArraySortHelper<MapMind.Target>.PickPivotAndPartition
	|
	|-RVA: 0x39469C0 Offset: 0x3946AC1 VA: 0x39469C0
	|-ArraySortHelper<MapPanelDebug.Entity>.PickPivotAndPartition
	|
	|-RVA: 0x3948230 Offset: 0x3948331 VA: 0x3948230
	|-ArraySortHelper<NexRanking.Data>.PickPivotAndPartition
	|
	|-RVA: 0x3949960 Offset: 0x3949A61 VA: 0x3949960
	|-ArraySortHelper<NexVersus.RatingData>.PickPivotAndPartition
	|
	|-RVA: 0x394B1B0 Offset: 0x394B2B1 VA: 0x394B1B0
	|-ArraySortHelper<PackedPlayModeBuildLogs.RuntimeBuildLog>.PickPivotAndPartition
	|
	|-RVA: 0x394CAA0 Offset: 0x394CBA1 VA: 0x394CAA0
	|-ArraySortHelper<ParticleSystem.Particle>.PickPivotAndPartition
	|
	|-RVA: 0x394E520 Offset: 0x394E621 VA: 0x394E520
	|-ArraySortHelper<ProfileCard.SortieCount>.PickPivotAndPartition
	|
	|-RVA: 0x377F910 Offset: 0x377FA11 VA: 0x377F910
	|-ArraySortHelper<RangeData.Offset>.PickPivotAndPartition
	|
	|-RVA: 0x3781120 Offset: 0x3781221 VA: 0x3781120
	|-ArraySortHelper<RenderGraphDebugData.PassDebugData>.PickPivotAndPartition
	|
	|-RVA: 0x3782C10 Offset: 0x3782D11 VA: 0x3782C10
	|-ArraySortHelper<RenderGraphDebugData.ResourceDebugData>.PickPivotAndPartition
	|
	|-RVA: 0x37846F0 Offset: 0x37847F1 VA: 0x37846F0
	|-ArraySortHelper<RingCleaningUnitSelectMenu.GodParam>.PickPivotAndPartition
	|
	|-RVA: 0x3786010 Offset: 0x3786111 VA: 0x3786010
	|-ArraySortHelper<ShadowUtility.Edge>.PickPivotAndPartition
	|
	|-RVA: 0x3787980 Offset: 0x3787A81 VA: 0x3787980
	|-ArraySortHelper<SkillArray.Entity>.PickPivotAndPartition
	|
	|-RVA: 0x37892C0 Offset: 0x37893C1 VA: 0x37892C0
	|-ArraySortHelper<TexturePacker_JsonArray.Frame>.PickPivotAndPartition
	|
	|-RVA: 0x378AF30 Offset: 0x378B031 VA: 0x378AF30
	|-ArraySortHelper<TimeNotificationBehaviour.NotificationEntry>.PickPivotAndPartition
	|
	|-RVA: 0x378C980 Offset: 0x378CA81 VA: 0x378C980
	|-ArraySortHelper<UnitySynchronizationContext.WorkRequest>.PickPivotAndPartition
	|
	|-RVA: 0x378E360 Offset: 0x378E461 VA: 0x378E360
	|-ArraySortHelper<XmlSchemaObjectTable.XmlSchemaObjectEntry>.PickPivotAndPartition
	|
	|-RVA: 0x378FAC0 Offset: 0x378FBC1 VA: 0x378FAC0
	|-ArraySortHelper<AIThink.EnchantThink.ItemInfo>.PickPivotAndPartition
	|
	|-RVA: 0x3791350 Offset: 0x3791451 VA: 0x3791350
	|-ArraySortHelper<AssetBundleBuildMap.AssetBundleEntry.AssetPathString>.PickPivotAndPartition
	|
	|-RVA: 0x3792CB0 Offset: 0x3792DB1 VA: 0x3792CB0
	|-ArraySortHelper<Detail.DataStore.DataStoreChangeMetaParamInt>.PickPivotAndPartition
	|
	|-RVA: 0x3794710 Offset: 0x3794811 VA: 0x3794710
	|-ArraySortHelper<Detail.DataStore.DataStoreDeleteParamInt>.PickPivotAndPartition
	|
	|-RVA: 0x3796010 Offset: 0x3796111 VA: 0x3796010
	|-ArraySortHelper<Detail.DataStore.DataStoreGetMetaParamInt>.PickPivotAndPartition
	|
	|-RVA: 0x3797B20 Offset: 0x3797C21 VA: 0x3797B20
	|-ArraySortHelper<Detail.DataStore.DataStoreMetaInfoInt>.PickPivotAndPartition
	|
	|-RVA: 0x3799540 Offset: 0x3799641 VA: 0x3799540
	|-ArraySortHelper<Detail.DataStore.DataStorePasswordInfoInt>.PickPivotAndPartition
	|
	|-RVA: 0x379AEC0 Offset: 0x379AFC1 VA: 0x379AEC0
	|-ArraySortHelper<Detail.DataStore.DataStorePersistenceInfoInt>.PickPivotAndPartition
	|
	|-RVA: 0x379C8C0 Offset: 0x379C9C1 VA: 0x379C8C0
	|-ArraySortHelper<Detail.DataStore.DataStorePreparePostParamInt>.PickPivotAndPartition
	|
	|-RVA: 0x379E240 Offset: 0x379E341 VA: 0x379E240
	|-ArraySortHelper<Detail.DataStore.DataStoreRateObjectParamInt>.PickPivotAndPartition
	|
	|-RVA: 0x379FAB0 Offset: 0x379FBB1 VA: 0x379FAB0
	|-ArraySortHelper<Detail.DataStore.DataStoreRatingInitParamInt>.PickPivotAndPartition
	|
	|-RVA: 0x37A13E0 Offset: 0x37A14E1 VA: 0x37A13E0
	|-ArraySortHelper<Detail.DataStore.DataStoreRatingTargetInt>.PickPivotAndPartition
	|
	|-RVA: 0x37A2D70 Offset: 0x37A2E71 VA: 0x37A2D70
	|-ArraySortHelper<Detail.Ranking.RankingCachedResultInt>.PickPivotAndPartition
	|
	|-RVA: 0x37A4890 Offset: 0x37A4991 VA: 0x37A4890
	|-ArraySortHelper<Detail.Ranking.RankingOrderParamInt>.PickPivotAndPartition
	|
	|-RVA: 0x37A6240 Offset: 0x37A6341 VA: 0x37A6240
	|-ArraySortHelper<Detail.Ranking.RankingRankDataInt>.PickPivotAndPartition
	|
	|-RVA: 0x37A8070 Offset: 0x37A8171 VA: 0x37A8070
	|-ArraySortHelper<Detail.Ranking2.Ranking2ChartInfoInt>.PickPivotAndPartition
	|
	|-RVA: 0x37AA000 Offset: 0x37AA101 VA: 0x37AA000
	|-ArraySortHelper<Detail.Ranking2.Ranking2RankDataInt>.PickPivotAndPartition
	|
	|-RVA: 0x37ABB40 Offset: 0x37ABC41 VA: 0x37ABB40
	|-ArraySortHelper<Detail.Ranking2.Ranking2ScoreDataInt>.PickPivotAndPartition
	|
	|-RVA: 0x37AD3B0 Offset: 0x37AD4B1 VA: 0x37AD3B0
	|-ArraySortHelper<Detail.Screening.ScreeningContextInfoInt>.PickPivotAndPartition
	|
	|-RVA: 0x37AEF30 Offset: 0x37AF031 VA: 0x37AEF30
	|-ArraySortHelper<Detail.Subscriber.SubscriberContentInt>.PickPivotAndPartition
	|
	|-RVA: 0x37B0BF0 Offset: 0x37B0CF1 VA: 0x37B0BF0
	|-ArraySortHelper<Detail.Subscriber.SubscriberGetContentParamInt>.PickPivotAndPartition
	|
	|-RVA: 0x32BEF90 Offset: 0x32BF091 VA: 0x32BEF90
	|-ArraySortHelper<Detail.Subscriber.SubscriberUserStatusInfoInt>.PickPivotAndPartition
	|
	|-RVA: 0x32C0A20 Offset: 0x32C0B21 VA: 0x32C0A20
	|-ArraySortHelper<Detail.Subscriber.SubscriberUserStatusParamInt>.PickPivotAndPartition
	|
	|-RVA: 0x32C2290 Offset: 0x32C2391 VA: 0x32C2290
	|-ArraySortHelper<Detail.Utility.IntegerSettings>.PickPivotAndPartition
	|
	|-RVA: 0x32C39C0 Offset: 0x32C3AC1 VA: 0x32C39C0
	|-ArraySortHelper<Detail.Utility.UniqueIdInfoInt>.PickPivotAndPartition
	|
	|-RVA: 0x32C5150 Offset: 0x32C5251 VA: 0x32C5150
	|-ArraySortHelper<MapHistory.Rewind.LatestInspectorData>.PickPivotAndPartition
	|
	|-RVA: 0x32C69C0 Offset: 0x32C6AC1 VA: 0x32C69C0
	|-ArraySortHelper<MapHistory.Rewind.WorkTerrainData>.PickPivotAndPartition
	|
	|-RVA: 0x32C81E0 Offset: 0x32C82E1 VA: 0x32C81E0
	|-ArraySortHelper<MapKillBonus.Work.Pos>.PickPivotAndPartition
	|
	|-RVA: 0x32C9A70 Offset: 0x32C9B71 VA: 0x32C9A70
	|-ArraySortHelper<MapSkill.AroundCalculator.Result>.PickPivotAndPartition
	|
	|-RVA: 0x32CB390 Offset: 0x32CB491 VA: 0x32CB390
	|-ArraySortHelper<TargetPositionCache.CacheCurve.Item>.PickPivotAndPartition
	|
	|-RVA: 0x32CCF00 Offset: 0x32CD001 VA: 0x32CCF00
	|-ArraySortHelper<TargetPositionCache.CacheEntry.RecordingItem>.PickPivotAndPartition
	*/

	// RVA: -1 Offset: -1
	private static void Heapsort(T[] keys, int lo, int hi, Comparison<T> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FFE130 Offset: 0x1FFE231 VA: 0x1FFE130
	|-ArraySortHelper<IntervalTree.Entry<object>>.Heapsort
	|
	|-RVA: 0x1FFFA60 Offset: 0x1FFFB61 VA: 0x1FFFA60
	|-ArraySortHelper<KeyValuePair<DateTime, object>>.Heapsort
	|
	|-RVA: 0x20012D0 Offset: 0x20013D1 VA: 0x20012D0
	|-ArraySortHelper<KeyValuePair<int, object>>.Heapsort
	|
	|-RVA: 0x2002C30 Offset: 0x2002D31 VA: 0x2002C30
	|-ArraySortHelper<KeyValuePair<object, ValueTuple<int, DateTime, object>>>.Heapsort
	|
	|-RVA: 0x20045B0 Offset: 0x20046B1 VA: 0x20045B0
	|-ArraySortHelper<KeyValuePair<object, object>>.Heapsort
	|
	|-RVA: 0x2005F30 Offset: 0x2006031 VA: 0x2005F30
	|-ArraySortHelper<CommonBattleSequence.Reliance<object>>.Heapsort
	|
	|-RVA: 0x2007890 Offset: 0x2007991 VA: 0x2007890
	|-ArraySortHelper<RenderGraphResourcePool.ResourceLogInfo<object>>.Heapsort
	|
	|-RVA: 0x2009100 Offset: 0x2009201 VA: 0x2009100
	|-ArraySortHelper<ValueTuple<int, object>>.Heapsort
	|
	|-RVA: 0x200A840 Offset: 0x200A941 VA: 0x200A840
	|-ArraySortHelper<ValueTuple<Int32Enum, int>>.Heapsort
	|
	|-RVA: 0x200C110 Offset: 0x200C211 VA: 0x200C110
	|-ArraySortHelper<ValueTuple<object, ValueTuple<object, int>>>.Heapsort
	|
	|-RVA: 0x200DA70 Offset: 0x200DB71 VA: 0x200DA70
	|-ArraySortHelper<ValueTuple<object, int>>.Heapsort
	|
	|-RVA: 0x200F390 Offset: 0x200F491 VA: 0x200F390
	|-ArraySortHelper<ValueTuple<Vector3, float>>.Heapsort
	|
	|-RVA: 0x2010CD0 Offset: 0x2010DD1 VA: 0x2010CD0
	|-ArraySortHelper<ValueTuple<object, Int32Enum, int>>.Heapsort
	|
	|-RVA: 0x3A80FA0 Offset: 0x3A810A1 VA: 0x3A80FA0
	|-ArraySortHelper<ValueTuple<object, int, int, int>>.Heapsort
	|
	|-RVA: 0x3A827A0 Offset: 0x3A828A1 VA: 0x3A827A0
	|-ArraySortHelper<AnimatorClipInfo>.Heapsort
	|
	|-RVA: 0x3A84070 Offset: 0x3A84171 VA: 0x3A84070
	|-ArraySortHelper<AsyncOperationHandle>.Heapsort
	|
	|-RVA: 0x3A85A40 Offset: 0x3A85B41 VA: 0x3A85A40
	|-ArraySortHelper<BoneWeight>.Heapsort
	|
	|-RVA: 0x3A87260 Offset: 0x3A87361 VA: 0x3A87260
	|-ArraySortHelper<bool>.Heapsort
	|
	|-RVA: 0x3A88910 Offset: 0x3A88A11 VA: 0x3A88910
	|-ArraySortHelper<byte>.Heapsort
	|
	|-RVA: 0x3A8A0D0 Offset: 0x3A8A1D1 VA: 0x3A8A0D0
	|-ArraySortHelper<CameraInfo>.Heapsort
	|
	|-RVA: 0x3A8B810 Offset: 0x3A8B911 VA: 0x3A8B810
	|-ArraySortHelper<char>.Heapsort
	|
	|-RVA: 0x3A8D080 Offset: 0x3A8D181 VA: 0x3A8D080
	|-ArraySortHelper<Color>.Heapsort
	|
	|-RVA: 0x3A8E860 Offset: 0x3A8E961 VA: 0x3A8E860
	|-ArraySortHelper<Color32>.Heapsort
	|
	|-RVA: 0x3A90050 Offset: 0x3A90151 VA: 0x3A90050
	|-ArraySortHelper<ConstraintSource>.Heapsort
	|
	|-RVA: 0x3A919D0 Offset: 0x3A91AD1 VA: 0x3A919D0
	|-ArraySortHelper<ContourVertex>.Heapsort
	|
	|-RVA: 0x3A93380 Offset: 0x3A93481 VA: 0x3A93380
	|-ArraySortHelper<DataStoreRatingInfo>.Heapsort
	|
	|-RVA: 0x3A94B50 Offset: 0x3A94C51 VA: 0x3A94B50
	|-ArraySortHelper<DataStoreResult>.Heapsort
	|
	|-RVA: 0x3A961E0 Offset: 0x3A962E1 VA: 0x3A961E0
	|-ArraySortHelper<DateTime>.Heapsort
	|
	|-RVA: 0x3A97930 Offset: 0x3A97A31 VA: 0x3A97930
	|-ArraySortHelper<DateTimeOffset>.Heapsort
	|
	|-RVA: 0x3A99110 Offset: 0x3A99211 VA: 0x3A99110
	|-ArraySortHelper<Decimal>.Heapsort
	|
	|-RVA: 0x3A9AB60 Offset: 0x3A9AC61 VA: 0x3A9AB60
	|-ArraySortHelper<DiagnosticEvent>.Heapsort
	|
	|-RVA: 0x3A9C440 Offset: 0x3A9C541 VA: 0x3A9C440
	|-ArraySortHelper<double>.Heapsort
	|
	|-RVA: 0x3A9DCD0 Offset: 0x3A9DDD1 VA: 0x3A9DCD0
	|-ArraySortHelper<Friend>.Heapsort
	|
	|-RVA: 0x3A9F5A0 Offset: 0x3A9F6A1 VA: 0x3A9F5A0
	|-ArraySortHelper<GlyphRect>.Heapsort
	|
	|-RVA: 0x3AA0CC0 Offset: 0x3AA0DC1 VA: 0x3AA0CC0
	|-ArraySortHelper<short>.Heapsort
	|
	|-RVA: 0x3AA2350 Offset: 0x3AA2451 VA: 0x3AA2350
	|-ArraySortHelper<int>.Heapsort
	|
	|-RVA: 0x3AA39E0 Offset: 0x3AA3AE1 VA: 0x3AA39E0
	|-ArraySortHelper<Int32Enum>.Heapsort
	|
	|-RVA: 0x3AA5070 Offset: 0x3AA5171 VA: 0x3AA5070
	|-ArraySortHelper<long>.Heapsort
	|
	|-RVA: 0x3AA6700 Offset: 0x3AA6801 VA: 0x3AA6700
	|-ArraySortHelper<IntPtr>.Heapsort
	|
	|-RVA: 0x3AA7EF0 Offset: 0x3AA7FF1 VA: 0x3AA7EF0
	|-ArraySortHelper<InterpretedFrameInfo>.Heapsort
	|
	|-RVA: 0x3AA97E0 Offset: 0x3AA98E1 VA: 0x3AA97E0
	|-ArraySortHelper<IntervalTreeNode>.Heapsort
	|
	|-RVA: 0x3AAAFB0 Offset: 0x3AAB0B1 VA: 0x3AAAFB0
	|-ArraySortHelper<LengthLimitProperties>.Heapsort
	|
	|-RVA: 0x3AAC640 Offset: 0x3AAC741 VA: 0x3AAC640
	|-ArraySortHelper<MapPos>.Heapsort
	|
	|-RVA: 0x3AAE070 Offset: 0x3AAE171 VA: 0x3AAE070
	|-ArraySortHelper<Matrix4x4>.Heapsort
	|
	|-RVA: 0x39501B0 Offset: 0x39502B1 VA: 0x39501B0
	|-ArraySortHelper<object>.Heapsort
	|
	|-RVA: 0x3951B70 Offset: 0x3951C71 VA: 0x3951B70
	|-ArraySortHelper<ObjectInitializationData>.Heapsort
	|
	|-RVA: 0x3953660 Offset: 0x3953761 VA: 0x3953660
	|-ArraySortHelper<PlayableBinding>.Heapsort
	|
	|-RVA: 0x3955190 Offset: 0x3955291 VA: 0x3955190
	|-ArraySortHelper<PlayerLoopSystem>.Heapsort
	|
	|-RVA: 0x3956D60 Offset: 0x3956E61 VA: 0x3956D60
	|-ArraySortHelper<PlayerLoopSystemInternal>.Heapsort
	|
	|-RVA: 0x3958780 Offset: 0x3958881 VA: 0x3958780
	|-ArraySortHelper<RangePositionInfo>.Heapsort
	|
	|-RVA: 0x3959EC0 Offset: 0x3959FC1 VA: 0x3959EC0
	|-ArraySortHelper<Ranking2ChartInfoInput>.Heapsort
	|
	|-RVA: 0x395B8E0 Offset: 0x395B9E1 VA: 0x395B8E0
	|-ArraySortHelper<RaycastHit>.Heapsort
	|
	|-RVA: 0x395D550 Offset: 0x395D651 VA: 0x395D550
	|-ArraySortHelper<RaycastHit2D>.Heapsort
	|
	|-RVA: 0x395F350 Offset: 0x395F451 VA: 0x395F350
	|-ArraySortHelper<RaycastResult>.Heapsort
	|
	|-RVA: 0x3960F70 Offset: 0x3961071 VA: 0x3960F70
	|-ArraySortHelper<Rect>.Heapsort
	|
	|-RVA: 0x3962750 Offset: 0x3962851 VA: 0x3962750
	|-ArraySortHelper<RendererListHandle>.Heapsort
	|
	|-RVA: 0x3963DE0 Offset: 0x3963EE1 VA: 0x3963DE0
	|-ArraySortHelper<ResourceHandle>.Heapsort
	|
	|-RVA: 0x3965470 Offset: 0x3965571 VA: 0x3965470
	|-ArraySortHelper<sbyte>.Heapsort
	|
	|-RVA: 0x3966B00 Offset: 0x3966C01 VA: 0x3966B00
	|-ArraySortHelper<ShaderTagId>.Heapsort
	|
	|-RVA: 0x39681A0 Offset: 0x39682A1 VA: 0x39681A0
	|-ArraySortHelper<float>.Heapsort
	|
	|-RVA: 0x3969F70 Offset: 0x396A071 VA: 0x3969F70
	|-ArraySortHelper<SphericalHarmonicsL2>.Heapsort
	|
	|-RVA: 0x396BF30 Offset: 0x396C031 VA: 0x396BF30
	|-ArraySortHelper<SubMeshDescriptor>.Heapsort
	|
	|-RVA: 0x396D920 Offset: 0x396DA21 VA: 0x396D920
	|-ArraySortHelper<TablePair>.Heapsort
	|
	|-RVA: 0x396F060 Offset: 0x396F161 VA: 0x396F060
	|-ArraySortHelper<TimeSpan>.Heapsort
	|
	|-RVA: 0x3970870 Offset: 0x3970971 VA: 0x3970870
	|-ArraySortHelper<UICharInfo>.Heapsort
	|
	|-RVA: 0x39720E0 Offset: 0x39721E1 VA: 0x39720E0
	|-ArraySortHelper<UILineInfo>.Heapsort
	|
	|-RVA: 0x3973F40 Offset: 0x3974041 VA: 0x3973F40
	|-ArraySortHelper<UIVertex>.Heapsort
	|
	|-RVA: 0x3975C50 Offset: 0x3975D51 VA: 0x3975C50
	|-ArraySortHelper<ushort>.Heapsort
	|
	|-RVA: 0x39772E0 Offset: 0x39773E1 VA: 0x39772E0
	|-ArraySortHelper<uint>.Heapsort
	|
	|-RVA: 0x3978970 Offset: 0x3978A71 VA: 0x3978970
	|-ArraySortHelper<ulong>.Heapsort
	|
	|-RVA: 0x397A0B0 Offset: 0x397A1B1 VA: 0x397A0B0
	|-ArraySortHelper<Vector2>.Heapsort
	|
	|-RVA: 0x397B950 Offset: 0x397BA51 VA: 0x397B950
	|-ArraySortHelper<Vector3>.Heapsort
	|
	|-RVA: 0x397D2E0 Offset: 0x397D3E1 VA: 0x397D2E0
	|-ArraySortHelper<Vector4>.Heapsort
	|
	|-RVA: 0x397EB80 Offset: 0x397EC81 VA: 0x397EB80
	|-ArraySortHelper<VertexAttributeDescriptor>.Heapsort
	|
	|-RVA: 0x39803D0 Offset: 0x39804D1 VA: 0x39803D0
	|-ArraySortHelper<X509ChainStatus>.Heapsort
	|
	|-RVA: 0x391F7F0 Offset: 0x391F8F1 VA: 0x391F7F0
	|-ArraySortHelper<XRView>.Heapsort
	|
	|-RVA: 0x39211C0 Offset: 0x39212C1 VA: 0x39211C0
	|-ArraySortHelper<AmiiboSequence.GainItemData>.Heapsort
	|
	|-RVA: 0x3922BA0 Offset: 0x3922CA1 VA: 0x3922BA0
	|-ArraySortHelper<AnimationOutputWeightProcessor.WeightInfo>.Heapsort
	|
	|-RVA: 0x39245A0 Offset: 0x39246A1 VA: 0x39245A0
	|-ArraySortHelper<ArenaOrderSequence.GodInfo>.Heapsort
	|
	|-RVA: 0x3925E40 Offset: 0x3925F41 VA: 0x3925E40
	|-ArraySortHelper<BattleInfo.SupportData>.Heapsort
	|
	|-RVA: 0x39276B0 Offset: 0x39277B1 VA: 0x39276B0
	|-ArraySortHelper<BeforeRenderHelper.OrderBlock>.Heapsort
	|
	|-RVA: 0x3929030 Offset: 0x3929131 VA: 0x3929030
	|-ArraySortHelper<Camera.RenderRequest>.Heapsort
	|
	|-RVA: 0x392A9A0 Offset: 0x392AAA1 VA: 0x392A9A0
	|-ArraySortHelper<CameraState.CustomBlendable>.Heapsort
	|
	|-RVA: 0x392C0E0 Offset: 0x392C1E1 VA: 0x392C0E0
	|-ArraySortHelper<CinemachineClearShot.Pair>.Heapsort
	|
	|-RVA: 0x392D770 Offset: 0x392D871 VA: 0x392D770
	|-ArraySortHelper<CinemachineStateDrivenCamera.HashPair>.Heapsort
	|
	|-RVA: 0x392EFD0 Offset: 0x392F0D1 VA: 0x392EFD0
	|-ArraySortHelper<DeferredTiler.PrePunctualLight>.Heapsort
	|
	|-RVA: 0x39309F0 Offset: 0x3930AF1 VA: 0x39309F0
	|-ArraySortHelper<DelayedActionManager.DelegateInfo>.Heapsort
	|
	|-RVA: 0x39324C0 Offset: 0x39325C1 VA: 0x39324C0
	|-ArraySortHelper<Detail.AsyncResultInt>.Heapsort
	|
	|-RVA: 0x3933E10 Offset: 0x3933F11 VA: 0x3933E10
	|-ArraySortHelper<Detail.CppArray>.Heapsort
	|
	|-RVA: 0x39357E0 Offset: 0x39358E1 VA: 0x39357E0
	|-ArraySortHelper<Detail.NotificationEventInt>.Heapsort
	|
	|-RVA: 0x39371D0 Offset: 0x39372D1 VA: 0x39371D0
	|-ArraySortHelper<DragonRideTargetGroup.ChainParam>.Heapsort
	|
	|-RVA: 0x3938B50 Offset: 0x3938C51 VA: 0x3938B50
	|-ArraySortHelper<GmapPathAdjuster.TargetModel>.Heapsort
	|
	|-RVA: 0x393A590 Offset: 0x393A691 VA: 0x393A590
	|-ArraySortHelper<GmapSpotAdjuster.TargetModel>.Heapsort
	|
	|-RVA: 0x393BFD0 Offset: 0x393C0D1 VA: 0x393BFD0
	|-ArraySortHelper<HubFastTravel.Location>.Heapsort
	|
	|-RVA: 0x393DB00 Offset: 0x393DC01 VA: 0x393DB00
	|-ArraySortHelper<HubLensFlare.Flare>.Heapsort
	|
	|-RVA: 0x393F500 Offset: 0x393F601 VA: 0x393F500
	|-ArraySortHelper<InventoryPoolItemMenuContent.KindBgNameClass>.Heapsort
	|
	|-RVA: 0x3940C40 Offset: 0x3940D41 VA: 0x3940C40
	|-ArraySortHelper<Map.Pos>.Heapsort
	|
	|-RVA: 0x3942390 Offset: 0x3942491 VA: 0x3942390
	|-ArraySortHelper<MapImage.BackupTerrain>.Heapsort
	|
	|-RVA: 0x3943B20 Offset: 0x3943C21 VA: 0x3943B20
	|-ArraySortHelper<MapImageRange.Pos>.Heapsort
	|
	|-RVA: 0x3945440 Offset: 0x3945541 VA: 0x3945440
	|-ArraySortHelper<MapMind.Target>.Heapsort
	|
	|-RVA: 0x3946DF0 Offset: 0x3946EF1 VA: 0x3946DF0
	|-ArraySortHelper<MapPanelDebug.Entity>.Heapsort
	|
	|-RVA: 0x39485C0 Offset: 0x39486C1 VA: 0x39485C0
	|-ArraySortHelper<NexRanking.Data>.Heapsort
	|
	|-RVA: 0x3949D10 Offset: 0x3949E11 VA: 0x3949D10
	|-ArraySortHelper<NexVersus.RatingData>.Heapsort
	|
	|-RVA: 0x394B560 Offset: 0x394B661 VA: 0x394B560
	|-ArraySortHelper<PackedPlayModeBuildLogs.RuntimeBuildLog>.Heapsort
	|
	|-RVA: 0x394CEE0 Offset: 0x394CFE1 VA: 0x394CEE0
	|-ArraySortHelper<ParticleSystem.Particle>.Heapsort
	|
	|-RVA: 0x394E950 Offset: 0x394EA51 VA: 0x394E950
	|-ArraySortHelper<ProfileCard.SortieCount>.Heapsort
	|
	|-RVA: 0x377FCA0 Offset: 0x377FDA1 VA: 0x377FCA0
	|-ArraySortHelper<RangeData.Offset>.Heapsort
	|
	|-RVA: 0x3781550 Offset: 0x3781651 VA: 0x3781550
	|-ArraySortHelper<RenderGraphDebugData.PassDebugData>.Heapsort
	|
	|-RVA: 0x3783080 Offset: 0x3783181 VA: 0x3783080
	|-ArraySortHelper<RenderGraphDebugData.ResourceDebugData>.Heapsort
	|
	|-RVA: 0x3784AA0 Offset: 0x3784BA1 VA: 0x3784AA0
	|-ArraySortHelper<RingCleaningUnitSelectMenu.GodParam>.Heapsort
	|
	|-RVA: 0x3786480 Offset: 0x3786581 VA: 0x3786480
	|-ArraySortHelper<ShadowUtility.Edge>.Heapsort
	|
	|-RVA: 0x3787D10 Offset: 0x3787E11 VA: 0x3787D10
	|-ArraySortHelper<SkillArray.Entity>.Heapsort
	|
	|-RVA: 0x3789780 Offset: 0x3789881 VA: 0x3789780
	|-ArraySortHelper<TexturePacker_JsonArray.Frame>.Heapsort
	|
	|-RVA: 0x378B360 Offset: 0x378B461 VA: 0x378B360
	|-ArraySortHelper<TimeNotificationBehaviour.NotificationEntry>.Heapsort
	|
	|-RVA: 0x378CDB0 Offset: 0x378CEB1 VA: 0x378CDB0
	|-ArraySortHelper<UnitySynchronizationContext.WorkRequest>.Heapsort
	|
	|-RVA: 0x378E710 Offset: 0x378E811 VA: 0x378E710
	|-ArraySortHelper<XmlSchemaObjectTable.XmlSchemaObjectEntry>.Heapsort
	|
	|-RVA: 0x378FEC0 Offset: 0x378FFC1 VA: 0x378FEC0
	|-ArraySortHelper<AIThink.EnchantThink.ItemInfo>.Heapsort
	|
	|-RVA: 0x3791700 Offset: 0x3791801 VA: 0x3791700
	|-ArraySortHelper<AssetBundleBuildMap.AssetBundleEntry.AssetPathString>.Heapsort
	|
	|-RVA: 0x3793110 Offset: 0x3793211 VA: 0x3793110
	|-ArraySortHelper<Detail.DataStore.DataStoreChangeMetaParamInt>.Heapsort
	|
	|-RVA: 0x3794AC0 Offset: 0x3794BC1 VA: 0x3794AC0
	|-ArraySortHelper<Detail.DataStore.DataStoreDeleteParamInt>.Heapsort
	|
	|-RVA: 0x3796480 Offset: 0x3796581 VA: 0x3796480
	|-ArraySortHelper<Detail.DataStore.DataStoreGetMetaParamInt>.Heapsort
	|
	|-RVA: 0x3797F70 Offset: 0x3798071 VA: 0x3797F70
	|-ArraySortHelper<Detail.DataStore.DataStoreMetaInfoInt>.Heapsort
	|
	|-RVA: 0x3799970 Offset: 0x3799A71 VA: 0x3799970
	|-ArraySortHelper<Detail.DataStore.DataStorePasswordInfoInt>.Heapsort
	|
	|-RVA: 0x379B2F0 Offset: 0x379B3F1 VA: 0x379B2F0
	|-ArraySortHelper<Detail.DataStore.DataStorePersistenceInfoInt>.Heapsort
	|
	|-RVA: 0x379CD00 Offset: 0x379CE01 VA: 0x379CD00
	|-ArraySortHelper<Detail.DataStore.DataStorePreparePostParamInt>.Heapsort
	|
	|-RVA: 0x379E5F0 Offset: 0x379E6F1 VA: 0x379E5F0
	|-ArraySortHelper<Detail.DataStore.DataStoreRateObjectParamInt>.Heapsort
	|
	|-RVA: 0x379FEE0 Offset: 0x379FFE1 VA: 0x379FEE0
	|-ArraySortHelper<Detail.DataStore.DataStoreRatingInitParamInt>.Heapsort
	|
	|-RVA: 0x37A1790 Offset: 0x37A1891 VA: 0x37A1790
	|-ArraySortHelper<Detail.DataStore.DataStoreRatingTargetInt>.Heapsort
	|
	|-RVA: 0x37A3230 Offset: 0x37A3331 VA: 0x37A3230
	|-ArraySortHelper<Detail.Ranking.RankingCachedResultInt>.Heapsort
	|
	|-RVA: 0x37A4C40 Offset: 0x37A4D41 VA: 0x37A4C40
	|-ArraySortHelper<Detail.Ranking.RankingOrderParamInt>.Heapsort
	|
	|-RVA: 0x37A6700 Offset: 0x37A6801 VA: 0x37A6700
	|-ArraySortHelper<Detail.Ranking.RankingRankDataInt>.Heapsort
	|
	|-RVA: 0x37A85D0 Offset: 0x37A86D1 VA: 0x37A85D0
	|-ArraySortHelper<Detail.Ranking2.Ranking2ChartInfoInt>.Heapsort
	|
	|-RVA: 0x37AA4C0 Offset: 0x37AA5C1 VA: 0x37AA4C0
	|-ArraySortHelper<Detail.Ranking2.Ranking2RankDataInt>.Heapsort
	|
	|-RVA: 0x37ABEF0 Offset: 0x37ABFF1 VA: 0x37ABEF0
	|-ArraySortHelper<Detail.Ranking2.Ranking2ScoreDataInt>.Heapsort
	|
	|-RVA: 0x37AD7E0 Offset: 0x37AD8E1 VA: 0x37AD7E0
	|-ArraySortHelper<Detail.Screening.ScreeningContextInfoInt>.Heapsort
	|
	|-RVA: 0x37AF440 Offset: 0x37AF541 VA: 0x37AF440
	|-ArraySortHelper<Detail.Subscriber.SubscriberContentInt>.Heapsort
	|
	|-RVA: 0x37B1020 Offset: 0x37B1121 VA: 0x37B1020
	|-ArraySortHelper<Detail.Subscriber.SubscriberGetContentParamInt>.Heapsort
	|
	|-RVA: 0x32BF400 Offset: 0x32BF501 VA: 0x32BF400
	|-ArraySortHelper<Detail.Subscriber.SubscriberUserStatusInfoInt>.Heapsort
	|
	|-RVA: 0x32C0E50 Offset: 0x32C0F51 VA: 0x32C0E50
	|-ArraySortHelper<Detail.Subscriber.SubscriberUserStatusParamInt>.Heapsort
	|
	|-RVA: 0x32C2620 Offset: 0x32C2721 VA: 0x32C2620
	|-ArraySortHelper<Detail.Utility.IntegerSettings>.Heapsort
	|
	|-RVA: 0x32C3D70 Offset: 0x32C3E71 VA: 0x32C3D70
	|-ArraySortHelper<Detail.Utility.UniqueIdInfoInt>.Heapsort
	|
	|-RVA: 0x32C5580 Offset: 0x32C5681 VA: 0x32C5580
	|-ArraySortHelper<MapHistory.Rewind.LatestInspectorData>.Heapsort
	|
	|-RVA: 0x32C6DF0 Offset: 0x32C6EF1 VA: 0x32C6DF0
	|-ArraySortHelper<MapHistory.Rewind.WorkTerrainData>.Heapsort
	|
	|-RVA: 0x32C85E0 Offset: 0x32C86E1 VA: 0x32C85E0
	|-ArraySortHelper<MapKillBonus.Work.Pos>.Heapsort
	|
	|-RVA: 0x32C9E20 Offset: 0x32C9F21 VA: 0x32C9E20
	|-ArraySortHelper<MapSkill.AroundCalculator.Result>.Heapsort
	|
	|-RVA: 0x32CB800 Offset: 0x32CB901 VA: 0x32CB800
	|-ArraySortHelper<TargetPositionCache.CacheCurve.Item>.Heapsort
	|
	|-RVA: 0x32CD390 Offset: 0x32CD491 VA: 0x32CD390
	|-ArraySortHelper<TargetPositionCache.CacheEntry.RecordingItem>.Heapsort
	*/

	// RVA: -1 Offset: -1
	private static void DownHeap(T[] keys, int i, int n, int lo, Comparison<T> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FFE2D0 Offset: 0x1FFE3D1 VA: 0x1FFE2D0
	|-ArraySortHelper<IntervalTree.Entry<object>>.DownHeap
	|
	|-RVA: 0x1FFFC00 Offset: 0x1FFFD01 VA: 0x1FFFC00
	|-ArraySortHelper<KeyValuePair<DateTime, object>>.DownHeap
	|
	|-RVA: 0x2001470 Offset: 0x2001571 VA: 0x2001470
	|-ArraySortHelper<KeyValuePair<int, object>>.DownHeap
	|
	|-RVA: 0x2002DD0 Offset: 0x2002ED1 VA: 0x2002DD0
	|-ArraySortHelper<KeyValuePair<object, ValueTuple<int, DateTime, object>>>.DownHeap
	|
	|-RVA: 0x2004750 Offset: 0x2004851 VA: 0x2004750
	|-ArraySortHelper<KeyValuePair<object, object>>.DownHeap
	|
	|-RVA: 0x20060D0 Offset: 0x20061D1 VA: 0x20060D0
	|-ArraySortHelper<CommonBattleSequence.Reliance<object>>.DownHeap
	|
	|-RVA: 0x2007A30 Offset: 0x2007B31 VA: 0x2007A30
	|-ArraySortHelper<RenderGraphResourcePool.ResourceLogInfo<object>>.DownHeap
	|
	|-RVA: 0x20092A0 Offset: 0x20093A1 VA: 0x20092A0
	|-ArraySortHelper<ValueTuple<int, object>>.DownHeap
	|
	|-RVA: 0x200A9E0 Offset: 0x200AAE1 VA: 0x200A9E0
	|-ArraySortHelper<ValueTuple<Int32Enum, int>>.DownHeap
	|
	|-RVA: 0x200C2B0 Offset: 0x200C3B1 VA: 0x200C2B0
	|-ArraySortHelper<ValueTuple<object, ValueTuple<object, int>>>.DownHeap
	|
	|-RVA: 0x200DC10 Offset: 0x200DD11 VA: 0x200DC10
	|-ArraySortHelper<ValueTuple<object, int>>.DownHeap
	|
	|-RVA: 0x200F530 Offset: 0x200F631 VA: 0x200F530
	|-ArraySortHelper<ValueTuple<Vector3, float>>.DownHeap
	|
	|-RVA: 0x2010E70 Offset: 0x2010F71 VA: 0x2010E70
	|-ArraySortHelper<ValueTuple<object, Int32Enum, int>>.DownHeap
	|
	|-RVA: 0x3A81140 Offset: 0x3A81241 VA: 0x3A81140
	|-ArraySortHelper<ValueTuple<object, int, int, int>>.DownHeap
	|
	|-RVA: 0x3A82940 Offset: 0x3A82A41 VA: 0x3A82940
	|-ArraySortHelper<AnimatorClipInfo>.DownHeap
	|
	|-RVA: 0x3A84210 Offset: 0x3A84311 VA: 0x3A84210
	|-ArraySortHelper<AsyncOperationHandle>.DownHeap
	|
	|-RVA: 0x3A85BE0 Offset: 0x3A85CE1 VA: 0x3A85BE0
	|-ArraySortHelper<BoneWeight>.DownHeap
	|
	|-RVA: 0x3A87400 Offset: 0x3A87501 VA: 0x3A87400
	|-ArraySortHelper<bool>.DownHeap
	|
	|-RVA: 0x3A88AB0 Offset: 0x3A88BB1 VA: 0x3A88AB0
	|-ArraySortHelper<byte>.DownHeap
	|
	|-RVA: 0x3A8A270 Offset: 0x3A8A371 VA: 0x3A8A270
	|-ArraySortHelper<CameraInfo>.DownHeap
	|
	|-RVA: 0x3A8B9B0 Offset: 0x3A8BAB1 VA: 0x3A8B9B0
	|-ArraySortHelper<char>.DownHeap
	|
	|-RVA: 0x3A8D220 Offset: 0x3A8D321 VA: 0x3A8D220
	|-ArraySortHelper<Color>.DownHeap
	|
	|-RVA: 0x3A8EA00 Offset: 0x3A8EB01 VA: 0x3A8EA00
	|-ArraySortHelper<Color32>.DownHeap
	|
	|-RVA: 0x3A901F0 Offset: 0x3A902F1 VA: 0x3A901F0
	|-ArraySortHelper<ConstraintSource>.DownHeap
	|
	|-RVA: 0x3A91B70 Offset: 0x3A91C71 VA: 0x3A91B70
	|-ArraySortHelper<ContourVertex>.DownHeap
	|
	|-RVA: 0x3A93520 Offset: 0x3A93621 VA: 0x3A93520
	|-ArraySortHelper<DataStoreRatingInfo>.DownHeap
	|
	|-RVA: 0x3A94CF0 Offset: 0x3A94DF1 VA: 0x3A94CF0
	|-ArraySortHelper<DataStoreResult>.DownHeap
	|
	|-RVA: 0x3A96380 Offset: 0x3A96481 VA: 0x3A96380
	|-ArraySortHelper<DateTime>.DownHeap
	|
	|-RVA: 0x3A97AD0 Offset: 0x3A97BD1 VA: 0x3A97AD0
	|-ArraySortHelper<DateTimeOffset>.DownHeap
	|
	|-RVA: 0x3A992B0 Offset: 0x3A993B1 VA: 0x3A992B0
	|-ArraySortHelper<Decimal>.DownHeap
	|
	|-RVA: 0x3A9AD00 Offset: 0x3A9AE01 VA: 0x3A9AD00
	|-ArraySortHelper<DiagnosticEvent>.DownHeap
	|
	|-RVA: 0x3A9C5E0 Offset: 0x3A9C6E1 VA: 0x3A9C5E0
	|-ArraySortHelper<double>.DownHeap
	|
	|-RVA: 0x3A9DE70 Offset: 0x3A9DF71 VA: 0x3A9DE70
	|-ArraySortHelper<Friend>.DownHeap
	|
	|-RVA: 0x3A9F740 Offset: 0x3A9F841 VA: 0x3A9F740
	|-ArraySortHelper<GlyphRect>.DownHeap
	|
	|-RVA: 0x3AA0E60 Offset: 0x3AA0F61 VA: 0x3AA0E60
	|-ArraySortHelper<short>.DownHeap
	|
	|-RVA: 0x3AA24F0 Offset: 0x3AA25F1 VA: 0x3AA24F0
	|-ArraySortHelper<int>.DownHeap
	|
	|-RVA: 0x3AA3B80 Offset: 0x3AA3C81 VA: 0x3AA3B80
	|-ArraySortHelper<Int32Enum>.DownHeap
	|
	|-RVA: 0x3AA5210 Offset: 0x3AA5311 VA: 0x3AA5210
	|-ArraySortHelper<long>.DownHeap
	|
	|-RVA: 0x3AA68A0 Offset: 0x3AA69A1 VA: 0x3AA68A0
	|-ArraySortHelper<IntPtr>.DownHeap
	|
	|-RVA: 0x3AA8090 Offset: 0x3AA8191 VA: 0x3AA8090
	|-ArraySortHelper<InterpretedFrameInfo>.DownHeap
	|
	|-RVA: 0x3AA9980 Offset: 0x3AA9A81 VA: 0x3AA9980
	|-ArraySortHelper<IntervalTreeNode>.DownHeap
	|
	|-RVA: 0x3AAB150 Offset: 0x3AAB251 VA: 0x3AAB150
	|-ArraySortHelper<LengthLimitProperties>.DownHeap
	|
	|-RVA: 0x3AAC7E0 Offset: 0x3AAC8E1 VA: 0x3AAC7E0
	|-ArraySortHelper<MapPos>.DownHeap
	|
	|-RVA: 0x3AAE210 Offset: 0x3AAE311 VA: 0x3AAE210
	|-ArraySortHelper<Matrix4x4>.DownHeap
	|
	|-RVA: 0x3950350 Offset: 0x3950451 VA: 0x3950350
	|-ArraySortHelper<object>.DownHeap
	|
	|-RVA: 0x3951D10 Offset: 0x3951E11 VA: 0x3951D10
	|-ArraySortHelper<ObjectInitializationData>.DownHeap
	|
	|-RVA: 0x3953800 Offset: 0x3953901 VA: 0x3953800
	|-ArraySortHelper<PlayableBinding>.DownHeap
	|
	|-RVA: 0x3955330 Offset: 0x3955431 VA: 0x3955330
	|-ArraySortHelper<PlayerLoopSystem>.DownHeap
	|
	|-RVA: 0x3956F00 Offset: 0x3957001 VA: 0x3956F00
	|-ArraySortHelper<PlayerLoopSystemInternal>.DownHeap
	|
	|-RVA: 0x3958920 Offset: 0x3958A21 VA: 0x3958920
	|-ArraySortHelper<RangePositionInfo>.DownHeap
	|
	|-RVA: 0x395A060 Offset: 0x395A161 VA: 0x395A060
	|-ArraySortHelper<Ranking2ChartInfoInput>.DownHeap
	|
	|-RVA: 0x395BA80 Offset: 0x395BB81 VA: 0x395BA80
	|-ArraySortHelper<RaycastHit>.DownHeap
	|
	|-RVA: 0x395D6F0 Offset: 0x395D7F1 VA: 0x395D6F0
	|-ArraySortHelper<RaycastHit2D>.DownHeap
	|
	|-RVA: 0x395F4F0 Offset: 0x395F5F1 VA: 0x395F4F0
	|-ArraySortHelper<RaycastResult>.DownHeap
	|
	|-RVA: 0x3961110 Offset: 0x3961211 VA: 0x3961110
	|-ArraySortHelper<Rect>.DownHeap
	|
	|-RVA: 0x39628F0 Offset: 0x39629F1 VA: 0x39628F0
	|-ArraySortHelper<RendererListHandle>.DownHeap
	|
	|-RVA: 0x3963F80 Offset: 0x3964081 VA: 0x3963F80
	|-ArraySortHelper<ResourceHandle>.DownHeap
	|
	|-RVA: 0x3965610 Offset: 0x3965711 VA: 0x3965610
	|-ArraySortHelper<sbyte>.DownHeap
	|
	|-RVA: 0x3966CA0 Offset: 0x3966DA1 VA: 0x3966CA0
	|-ArraySortHelper<ShaderTagId>.DownHeap
	|
	|-RVA: 0x3968340 Offset: 0x3968441 VA: 0x3968340
	|-ArraySortHelper<float>.DownHeap
	|
	|-RVA: 0x396A110 Offset: 0x396A211 VA: 0x396A110
	|-ArraySortHelper<SphericalHarmonicsL2>.DownHeap
	|
	|-RVA: 0x396C0D0 Offset: 0x396C1D1 VA: 0x396C0D0
	|-ArraySortHelper<SubMeshDescriptor>.DownHeap
	|
	|-RVA: 0x396DAC0 Offset: 0x396DBC1 VA: 0x396DAC0
	|-ArraySortHelper<TablePair>.DownHeap
	|
	|-RVA: 0x396F200 Offset: 0x396F301 VA: 0x396F200
	|-ArraySortHelper<TimeSpan>.DownHeap
	|
	|-RVA: 0x3970A10 Offset: 0x3970B11 VA: 0x3970A10
	|-ArraySortHelper<UICharInfo>.DownHeap
	|
	|-RVA: 0x3972280 Offset: 0x3972381 VA: 0x3972280
	|-ArraySortHelper<UILineInfo>.DownHeap
	|
	|-RVA: 0x39740E0 Offset: 0x39741E1 VA: 0x39740E0
	|-ArraySortHelper<UIVertex>.DownHeap
	|
	|-RVA: 0x3975DF0 Offset: 0x3975EF1 VA: 0x3975DF0
	|-ArraySortHelper<ushort>.DownHeap
	|
	|-RVA: 0x3977480 Offset: 0x3977581 VA: 0x3977480
	|-ArraySortHelper<uint>.DownHeap
	|
	|-RVA: 0x3978B10 Offset: 0x3978C11 VA: 0x3978B10
	|-ArraySortHelper<ulong>.DownHeap
	|
	|-RVA: 0x397A250 Offset: 0x397A351 VA: 0x397A250
	|-ArraySortHelper<Vector2>.DownHeap
	|
	|-RVA: 0x397BAF0 Offset: 0x397BBF1 VA: 0x397BAF0
	|-ArraySortHelper<Vector3>.DownHeap
	|
	|-RVA: 0x397D480 Offset: 0x397D581 VA: 0x397D480
	|-ArraySortHelper<Vector4>.DownHeap
	|
	|-RVA: 0x397ED20 Offset: 0x397EE21 VA: 0x397ED20
	|-ArraySortHelper<VertexAttributeDescriptor>.DownHeap
	|
	|-RVA: 0x3980570 Offset: 0x3980671 VA: 0x3980570
	|-ArraySortHelper<X509ChainStatus>.DownHeap
	|
	|-RVA: 0x391F990 Offset: 0x391FA91 VA: 0x391F990
	|-ArraySortHelper<XRView>.DownHeap
	|
	|-RVA: 0x3921360 Offset: 0x3921461 VA: 0x3921360
	|-ArraySortHelper<AmiiboSequence.GainItemData>.DownHeap
	|
	|-RVA: 0x3922D40 Offset: 0x3922E41 VA: 0x3922D40
	|-ArraySortHelper<AnimationOutputWeightProcessor.WeightInfo>.DownHeap
	|
	|-RVA: 0x3924740 Offset: 0x3924841 VA: 0x3924740
	|-ArraySortHelper<ArenaOrderSequence.GodInfo>.DownHeap
	|
	|-RVA: 0x3925FE0 Offset: 0x39260E1 VA: 0x3925FE0
	|-ArraySortHelper<BattleInfo.SupportData>.DownHeap
	|
	|-RVA: 0x3927850 Offset: 0x3927951 VA: 0x3927850
	|-ArraySortHelper<BeforeRenderHelper.OrderBlock>.DownHeap
	|
	|-RVA: 0x39291D0 Offset: 0x39292D1 VA: 0x39291D0
	|-ArraySortHelper<Camera.RenderRequest>.DownHeap
	|
	|-RVA: 0x392AB40 Offset: 0x392AC41 VA: 0x392AB40
	|-ArraySortHelper<CameraState.CustomBlendable>.DownHeap
	|
	|-RVA: 0x392C280 Offset: 0x392C381 VA: 0x392C280
	|-ArraySortHelper<CinemachineClearShot.Pair>.DownHeap
	|
	|-RVA: 0x392D910 Offset: 0x392DA11 VA: 0x392D910
	|-ArraySortHelper<CinemachineStateDrivenCamera.HashPair>.DownHeap
	|
	|-RVA: 0x392F170 Offset: 0x392F271 VA: 0x392F170
	|-ArraySortHelper<DeferredTiler.PrePunctualLight>.DownHeap
	|
	|-RVA: 0x3930B90 Offset: 0x3930C91 VA: 0x3930B90
	|-ArraySortHelper<DelayedActionManager.DelegateInfo>.DownHeap
	|
	|-RVA: 0x3932660 Offset: 0x3932761 VA: 0x3932660
	|-ArraySortHelper<Detail.AsyncResultInt>.DownHeap
	|
	|-RVA: 0x3933FB0 Offset: 0x39340B1 VA: 0x3933FB0
	|-ArraySortHelper<Detail.CppArray>.DownHeap
	|
	|-RVA: 0x3935980 Offset: 0x3935A81 VA: 0x3935980
	|-ArraySortHelper<Detail.NotificationEventInt>.DownHeap
	|
	|-RVA: 0x3937370 Offset: 0x3937471 VA: 0x3937370
	|-ArraySortHelper<DragonRideTargetGroup.ChainParam>.DownHeap
	|
	|-RVA: 0x3938CF0 Offset: 0x3938DF1 VA: 0x3938CF0
	|-ArraySortHelper<GmapPathAdjuster.TargetModel>.DownHeap
	|
	|-RVA: 0x393A730 Offset: 0x393A831 VA: 0x393A730
	|-ArraySortHelper<GmapSpotAdjuster.TargetModel>.DownHeap
	|
	|-RVA: 0x393C170 Offset: 0x393C271 VA: 0x393C170
	|-ArraySortHelper<HubFastTravel.Location>.DownHeap
	|
	|-RVA: 0x393DCA0 Offset: 0x393DDA1 VA: 0x393DCA0
	|-ArraySortHelper<HubLensFlare.Flare>.DownHeap
	|
	|-RVA: 0x393F6A0 Offset: 0x393F7A1 VA: 0x393F6A0
	|-ArraySortHelper<InventoryPoolItemMenuContent.KindBgNameClass>.DownHeap
	|
	|-RVA: 0x3940DE0 Offset: 0x3940EE1 VA: 0x3940DE0
	|-ArraySortHelper<Map.Pos>.DownHeap
	|
	|-RVA: 0x3942530 Offset: 0x3942631 VA: 0x3942530
	|-ArraySortHelper<MapImage.BackupTerrain>.DownHeap
	|
	|-RVA: 0x3943CC0 Offset: 0x3943DC1 VA: 0x3943CC0
	|-ArraySortHelper<MapImageRange.Pos>.DownHeap
	|
	|-RVA: 0x39455E0 Offset: 0x39456E1 VA: 0x39455E0
	|-ArraySortHelper<MapMind.Target>.DownHeap
	|
	|-RVA: 0x3946F90 Offset: 0x3947091 VA: 0x3946F90
	|-ArraySortHelper<MapPanelDebug.Entity>.DownHeap
	|
	|-RVA: 0x3948760 Offset: 0x3948861 VA: 0x3948760
	|-ArraySortHelper<NexRanking.Data>.DownHeap
	|
	|-RVA: 0x3949EB0 Offset: 0x3949FB1 VA: 0x3949EB0
	|-ArraySortHelper<NexVersus.RatingData>.DownHeap
	|
	|-RVA: 0x394B700 Offset: 0x394B801 VA: 0x394B700
	|-ArraySortHelper<PackedPlayModeBuildLogs.RuntimeBuildLog>.DownHeap
	|
	|-RVA: 0x394D080 Offset: 0x394D181 VA: 0x394D080
	|-ArraySortHelper<ParticleSystem.Particle>.DownHeap
	|
	|-RVA: 0x394EAF0 Offset: 0x394EBF1 VA: 0x394EAF0
	|-ArraySortHelper<ProfileCard.SortieCount>.DownHeap
	|
	|-RVA: 0x377FE40 Offset: 0x377FF41 VA: 0x377FE40
	|-ArraySortHelper<RangeData.Offset>.DownHeap
	|
	|-RVA: 0x37816F0 Offset: 0x37817F1 VA: 0x37816F0
	|-ArraySortHelper<RenderGraphDebugData.PassDebugData>.DownHeap
	|
	|-RVA: 0x3783220 Offset: 0x3783321 VA: 0x3783220
	|-ArraySortHelper<RenderGraphDebugData.ResourceDebugData>.DownHeap
	|
	|-RVA: 0x3784C40 Offset: 0x3784D41 VA: 0x3784C40
	|-ArraySortHelper<RingCleaningUnitSelectMenu.GodParam>.DownHeap
	|
	|-RVA: 0x3786620 Offset: 0x3786721 VA: 0x3786620
	|-ArraySortHelper<ShadowUtility.Edge>.DownHeap
	|
	|-RVA: 0x3787EB0 Offset: 0x3787FB1 VA: 0x3787EB0
	|-ArraySortHelper<SkillArray.Entity>.DownHeap
	|
	|-RVA: 0x3789920 Offset: 0x3789A21 VA: 0x3789920
	|-ArraySortHelper<TexturePacker_JsonArray.Frame>.DownHeap
	|
	|-RVA: 0x378B500 Offset: 0x378B601 VA: 0x378B500
	|-ArraySortHelper<TimeNotificationBehaviour.NotificationEntry>.DownHeap
	|
	|-RVA: 0x378CF50 Offset: 0x378D051 VA: 0x378CF50
	|-ArraySortHelper<UnitySynchronizationContext.WorkRequest>.DownHeap
	|
	|-RVA: 0x378E8B0 Offset: 0x378E9B1 VA: 0x378E8B0
	|-ArraySortHelper<XmlSchemaObjectTable.XmlSchemaObjectEntry>.DownHeap
	|
	|-RVA: 0x3790060 Offset: 0x3790161 VA: 0x3790060
	|-ArraySortHelper<AIThink.EnchantThink.ItemInfo>.DownHeap
	|
	|-RVA: 0x37918A0 Offset: 0x37919A1 VA: 0x37918A0
	|-ArraySortHelper<AssetBundleBuildMap.AssetBundleEntry.AssetPathString>.DownHeap
	|
	|-RVA: 0x37932B0 Offset: 0x37933B1 VA: 0x37932B0
	|-ArraySortHelper<Detail.DataStore.DataStoreChangeMetaParamInt>.DownHeap
	|
	|-RVA: 0x3794C60 Offset: 0x3794D61 VA: 0x3794C60
	|-ArraySortHelper<Detail.DataStore.DataStoreDeleteParamInt>.DownHeap
	|
	|-RVA: 0x3796620 Offset: 0x3796721 VA: 0x3796620
	|-ArraySortHelper<Detail.DataStore.DataStoreGetMetaParamInt>.DownHeap
	|
	|-RVA: 0x3798110 Offset: 0x3798211 VA: 0x3798110
	|-ArraySortHelper<Detail.DataStore.DataStoreMetaInfoInt>.DownHeap
	|
	|-RVA: 0x3799B10 Offset: 0x3799C11 VA: 0x3799B10
	|-ArraySortHelper<Detail.DataStore.DataStorePasswordInfoInt>.DownHeap
	|
	|-RVA: 0x379B490 Offset: 0x379B591 VA: 0x379B490
	|-ArraySortHelper<Detail.DataStore.DataStorePersistenceInfoInt>.DownHeap
	|
	|-RVA: 0x379CEA0 Offset: 0x379CFA1 VA: 0x379CEA0
	|-ArraySortHelper<Detail.DataStore.DataStorePreparePostParamInt>.DownHeap
	|
	|-RVA: 0x379E790 Offset: 0x379E891 VA: 0x379E790
	|-ArraySortHelper<Detail.DataStore.DataStoreRateObjectParamInt>.DownHeap
	|
	|-RVA: 0x37A0080 Offset: 0x37A0181 VA: 0x37A0080
	|-ArraySortHelper<Detail.DataStore.DataStoreRatingInitParamInt>.DownHeap
	|
	|-RVA: 0x37A1930 Offset: 0x37A1A31 VA: 0x37A1930
	|-ArraySortHelper<Detail.DataStore.DataStoreRatingTargetInt>.DownHeap
	|
	|-RVA: 0x37A33D0 Offset: 0x37A34D1 VA: 0x37A33D0
	|-ArraySortHelper<Detail.Ranking.RankingCachedResultInt>.DownHeap
	|
	|-RVA: 0x37A4DE0 Offset: 0x37A4EE1 VA: 0x37A4DE0
	|-ArraySortHelper<Detail.Ranking.RankingOrderParamInt>.DownHeap
	|
	|-RVA: 0x37A68A0 Offset: 0x37A69A1 VA: 0x37A68A0
	|-ArraySortHelper<Detail.Ranking.RankingRankDataInt>.DownHeap
	|
	|-RVA: 0x37A8770 Offset: 0x37A8871 VA: 0x37A8770
	|-ArraySortHelper<Detail.Ranking2.Ranking2ChartInfoInt>.DownHeap
	|
	|-RVA: 0x37AA660 Offset: 0x37AA761 VA: 0x37AA660
	|-ArraySortHelper<Detail.Ranking2.Ranking2RankDataInt>.DownHeap
	|
	|-RVA: 0x37AC090 Offset: 0x37AC191 VA: 0x37AC090
	|-ArraySortHelper<Detail.Ranking2.Ranking2ScoreDataInt>.DownHeap
	|
	|-RVA: 0x37AD980 Offset: 0x37ADA81 VA: 0x37AD980
	|-ArraySortHelper<Detail.Screening.ScreeningContextInfoInt>.DownHeap
	|
	|-RVA: 0x37AF5E0 Offset: 0x37AF6E1 VA: 0x37AF5E0
	|-ArraySortHelper<Detail.Subscriber.SubscriberContentInt>.DownHeap
	|
	|-RVA: 0x37B11C0 Offset: 0x37B12C1 VA: 0x37B11C0
	|-ArraySortHelper<Detail.Subscriber.SubscriberGetContentParamInt>.DownHeap
	|
	|-RVA: 0x32BF5A0 Offset: 0x32BF6A1 VA: 0x32BF5A0
	|-ArraySortHelper<Detail.Subscriber.SubscriberUserStatusInfoInt>.DownHeap
	|
	|-RVA: 0x32C0FF0 Offset: 0x32C10F1 VA: 0x32C0FF0
	|-ArraySortHelper<Detail.Subscriber.SubscriberUserStatusParamInt>.DownHeap
	|
	|-RVA: 0x32C27C0 Offset: 0x32C28C1 VA: 0x32C27C0
	|-ArraySortHelper<Detail.Utility.IntegerSettings>.DownHeap
	|
	|-RVA: 0x32C3F10 Offset: 0x32C4011 VA: 0x32C3F10
	|-ArraySortHelper<Detail.Utility.UniqueIdInfoInt>.DownHeap
	|
	|-RVA: 0x32C5720 Offset: 0x32C5821 VA: 0x32C5720
	|-ArraySortHelper<MapHistory.Rewind.LatestInspectorData>.DownHeap
	|
	|-RVA: 0x32C6F90 Offset: 0x32C7091 VA: 0x32C6F90
	|-ArraySortHelper<MapHistory.Rewind.WorkTerrainData>.DownHeap
	|
	|-RVA: 0x32C8780 Offset: 0x32C8881 VA: 0x32C8780
	|-ArraySortHelper<MapKillBonus.Work.Pos>.DownHeap
	|
	|-RVA: 0x32C9FC0 Offset: 0x32CA0C1 VA: 0x32C9FC0
	|-ArraySortHelper<MapSkill.AroundCalculator.Result>.DownHeap
	|
	|-RVA: 0x32CB9A0 Offset: 0x32CBAA1 VA: 0x32CB9A0
	|-ArraySortHelper<TargetPositionCache.CacheCurve.Item>.DownHeap
	|
	|-RVA: 0x32CD530 Offset: 0x32CD631 VA: 0x32CD530
	|-ArraySortHelper<TargetPositionCache.CacheEntry.RecordingItem>.DownHeap
	*/

	// RVA: -1 Offset: -1
	private static void InsertionSort(T[] keys, int lo, int hi, Comparison<T> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FFE5A0 Offset: 0x1FFE6A1 VA: 0x1FFE5A0
	|-ArraySortHelper<IntervalTree.Entry<object>>.InsertionSort
	|
	|-RVA: 0x1FFFE70 Offset: 0x1FFFF71 VA: 0x1FFFE70
	|-ArraySortHelper<KeyValuePair<DateTime, object>>.InsertionSort
	|
	|-RVA: 0x20016E0 Offset: 0x20017E1 VA: 0x20016E0
	|-ArraySortHelper<KeyValuePair<int, object>>.InsertionSort
	|
	|-RVA: 0x20030B0 Offset: 0x20031B1 VA: 0x20030B0
	|-ArraySortHelper<KeyValuePair<object, ValueTuple<int, DateTime, object>>>.InsertionSort
	|
	|-RVA: 0x20049C0 Offset: 0x2004AC1 VA: 0x20049C0
	|-ArraySortHelper<KeyValuePair<object, object>>.InsertionSort
	|
	|-RVA: 0x20063A0 Offset: 0x20064A1 VA: 0x20063A0
	|-ArraySortHelper<CommonBattleSequence.Reliance<object>>.InsertionSort
	|
	|-RVA: 0x2007CA0 Offset: 0x2007DA1 VA: 0x2007CA0
	|-ArraySortHelper<RenderGraphResourcePool.ResourceLogInfo<object>>.InsertionSort
	|
	|-RVA: 0x2009510 Offset: 0x2009611 VA: 0x2009510
	|-ArraySortHelper<ValueTuple<int, object>>.InsertionSort
	|
	|-RVA: 0x200ABE0 Offset: 0x200ACE1 VA: 0x200ABE0
	|-ArraySortHelper<ValueTuple<Int32Enum, int>>.InsertionSort
	|
	|-RVA: 0x200C580 Offset: 0x200C681 VA: 0x200C580
	|-ArraySortHelper<ValueTuple<object, ValueTuple<object, int>>>.InsertionSort
	|
	|-RVA: 0x200DE80 Offset: 0x200DF81 VA: 0x200DE80
	|-ArraySortHelper<ValueTuple<object, int>>.InsertionSort
	|
	|-RVA: 0x200F800 Offset: 0x200F901 VA: 0x200F800
	|-ArraySortHelper<ValueTuple<Vector3, float>>.InsertionSort
	|
	|-RVA: 0x20110E0 Offset: 0x20111E1 VA: 0x20110E0
	|-ArraySortHelper<ValueTuple<object, Int32Enum, int>>.InsertionSort
	|
	|-RVA: 0x3A81410 Offset: 0x3A81511 VA: 0x3A81410
	|-ArraySortHelper<ValueTuple<object, int, int, int>>.InsertionSort
	|
	|-RVA: 0x3A82B40 Offset: 0x3A82C41 VA: 0x3A82B40
	|-ArraySortHelper<AnimatorClipInfo>.InsertionSort
	|
	|-RVA: 0x3A844E0 Offset: 0x3A845E1 VA: 0x3A844E0
	|-ArraySortHelper<AsyncOperationHandle>.InsertionSort
	|
	|-RVA: 0x3A85EA0 Offset: 0x3A85FA1 VA: 0x3A85EA0
	|-ArraySortHelper<BoneWeight>.InsertionSort
	|
	|-RVA: 0x3A87620 Offset: 0x3A87721 VA: 0x3A87620
	|-ArraySortHelper<bool>.InsertionSort
	|
	|-RVA: 0x3A88CB0 Offset: 0x3A88DB1 VA: 0x3A88CB0
	|-ArraySortHelper<byte>.InsertionSort
	|
	|-RVA: 0x3A8A4E0 Offset: 0x3A8A5E1 VA: 0x3A8A4E0
	|-ArraySortHelper<CameraInfo>.InsertionSort
	|
	|-RVA: 0x3A8BBB0 Offset: 0x3A8BCB1 VA: 0x3A8BBB0
	|-ArraySortHelper<char>.InsertionSort
	|
	|-RVA: 0x3A8D4F0 Offset: 0x3A8D5F1 VA: 0x3A8D4F0
	|-ArraySortHelper<Color>.InsertionSort
	|
	|-RVA: 0x3A8EC00 Offset: 0x3A8ED01 VA: 0x3A8EC00
	|-ArraySortHelper<Color32>.InsertionSort
	|
	|-RVA: 0x3A90460 Offset: 0x3A90561 VA: 0x3A90460
	|-ArraySortHelper<ConstraintSource>.InsertionSort
	|
	|-RVA: 0x3A91E40 Offset: 0x3A91F41 VA: 0x3A91E40
	|-ArraySortHelper<ContourVertex>.InsertionSort
	|
	|-RVA: 0x3A937D0 Offset: 0x3A938D1 VA: 0x3A937D0
	|-ArraySortHelper<DataStoreRatingInfo>.InsertionSort
	|
	|-RVA: 0x3A94EF0 Offset: 0x3A94FF1 VA: 0x3A94EF0
	|-ArraySortHelper<DataStoreResult>.InsertionSort
	|
	|-RVA: 0x3A96580 Offset: 0x3A96681 VA: 0x3A96580
	|-ArraySortHelper<DateTime>.InsertionSort
	|
	|-RVA: 0x3A97D30 Offset: 0x3A97E31 VA: 0x3A97D30
	|-ArraySortHelper<DateTimeOffset>.InsertionSort
	|
	|-RVA: 0x3A99510 Offset: 0x3A99611 VA: 0x3A99510
	|-ArraySortHelper<Decimal>.InsertionSort
	|
	|-RVA: 0x3A9B040 Offset: 0x3A9B141 VA: 0x3A9B040
	|-ArraySortHelper<DiagnosticEvent>.InsertionSort
	|
	|-RVA: 0x3A9C7E0 Offset: 0x3A9C8E1 VA: 0x3A9C7E0
	|-ArraySortHelper<double>.InsertionSort
	|
	|-RVA: 0x3A9E150 Offset: 0x3A9E251 VA: 0x3A9E150
	|-ArraySortHelper<Friend>.InsertionSort
	|
	|-RVA: 0x3A9F9A0 Offset: 0x3A9FAA1 VA: 0x3A9F9A0
	|-ArraySortHelper<GlyphRect>.InsertionSort
	|
	|-RVA: 0x3AA1060 Offset: 0x3AA1161 VA: 0x3AA1060
	|-ArraySortHelper<short>.InsertionSort
	|
	|-RVA: 0x3AA26F0 Offset: 0x3AA27F1 VA: 0x3AA26F0
	|-ArraySortHelper<int>.InsertionSort
	|
	|-RVA: 0x3AA3D80 Offset: 0x3AA3E81 VA: 0x3AA3D80
	|-ArraySortHelper<Int32Enum>.InsertionSort
	|
	|-RVA: 0x3AA5410 Offset: 0x3AA5511 VA: 0x3AA5410
	|-ArraySortHelper<long>.InsertionSort
	|
	|-RVA: 0x3AA6AA0 Offset: 0x3AA6BA1 VA: 0x3AA6AA0
	|-ArraySortHelper<IntPtr>.InsertionSort
	|
	|-RVA: 0x3AA8300 Offset: 0x3AA8401 VA: 0x3AA8300
	|-ArraySortHelper<InterpretedFrameInfo>.InsertionSort
	|
	|-RVA: 0x3AA9C30 Offset: 0x3AA9D31 VA: 0x3AA9C30
	|-ArraySortHelper<IntervalTreeNode>.InsertionSort
	|
	|-RVA: 0x3AAB350 Offset: 0x3AAB451 VA: 0x3AAB350
	|-ArraySortHelper<LengthLimitProperties>.InsertionSort
	|
	|-RVA: 0x3AAC9E0 Offset: 0x3AACAE1 VA: 0x3AAC9E0
	|-ArraySortHelper<MapPos>.InsertionSort
	|
	|-RVA: 0x3AAE5B0 Offset: 0x3AAE6B1 VA: 0x3AAE5B0
	|-ArraySortHelper<Matrix4x4>.InsertionSort
	|
	|-RVA: 0x3950540 Offset: 0x3950641 VA: 0x3950540
	|-ArraySortHelper<object>.InsertionSort
	|
	|-RVA: 0x3952050 Offset: 0x3952151 VA: 0x3952050
	|-ArraySortHelper<ObjectInitializationData>.InsertionSort
	|
	|-RVA: 0x3953AE0 Offset: 0x3953BE1 VA: 0x3953AE0
	|-ArraySortHelper<PlayableBinding>.InsertionSort
	|
	|-RVA: 0x3955660 Offset: 0x3955761 VA: 0x3955660
	|-ArraySortHelper<PlayerLoopSystem>.InsertionSort
	|
	|-RVA: 0x3957230 Offset: 0x3957331 VA: 0x3957230
	|-ArraySortHelper<PlayerLoopSystemInternal>.InsertionSort
	|
	|-RVA: 0x3958B90 Offset: 0x3958C91 VA: 0x3958B90
	|-ArraySortHelper<RangePositionInfo>.InsertionSort
	|
	|-RVA: 0x395A260 Offset: 0x395A361 VA: 0x395A260
	|-ArraySortHelper<Ranking2ChartInfoInput>.InsertionSort
	|
	|-RVA: 0x395BE20 Offset: 0x395BF21 VA: 0x395BE20
	|-ArraySortHelper<RaycastHit>.InsertionSort
	|
	|-RVA: 0x395DA60 Offset: 0x395DB61 VA: 0x395DA60
	|-ArraySortHelper<RaycastHit2D>.InsertionSort
	|
	|-RVA: 0x395F900 Offset: 0x395FA01 VA: 0x395F900
	|-ArraySortHelper<RaycastResult>.InsertionSort
	|
	|-RVA: 0x39613E0 Offset: 0x39614E1 VA: 0x39613E0
	|-ArraySortHelper<Rect>.InsertionSort
	|
	|-RVA: 0x3962AF0 Offset: 0x3962BF1 VA: 0x3962AF0
	|-ArraySortHelper<RendererListHandle>.InsertionSort
	|
	|-RVA: 0x3964180 Offset: 0x3964281 VA: 0x3964180
	|-ArraySortHelper<ResourceHandle>.InsertionSort
	|
	|-RVA: 0x3965810 Offset: 0x3965911 VA: 0x3965810
	|-ArraySortHelper<sbyte>.InsertionSort
	|
	|-RVA: 0x3966EA0 Offset: 0x3966FA1 VA: 0x3966EA0
	|-ArraySortHelper<ShaderTagId>.InsertionSort
	|
	|-RVA: 0x3968540 Offset: 0x3968641 VA: 0x3968540
	|-ArraySortHelper<float>.InsertionSort
	|
	|-RVA: 0x396A6E0 Offset: 0x396A7E1 VA: 0x396A6E0
	|-ArraySortHelper<SphericalHarmonicsL2>.InsertionSort
	|
	|-RVA: 0x396C3F0 Offset: 0x396C4F1 VA: 0x396C3F0
	|-ArraySortHelper<SubMeshDescriptor>.InsertionSort
	|
	|-RVA: 0x396DD30 Offset: 0x396DE31 VA: 0x396DD30
	|-ArraySortHelper<TablePair>.InsertionSort
	|
	|-RVA: 0x396F400 Offset: 0x396F501 VA: 0x396F400
	|-ArraySortHelper<TimeSpan>.InsertionSort
	|
	|-RVA: 0x3970CC0 Offset: 0x3970DC1 VA: 0x3970CC0
	|-ArraySortHelper<UICharInfo>.InsertionSort
	|
	|-RVA: 0x39724E0 Offset: 0x39725E1 VA: 0x39724E0
	|-ArraySortHelper<UILineInfo>.InsertionSort
	|
	|-RVA: 0x39746B0 Offset: 0x39747B1 VA: 0x39746B0
	|-ArraySortHelper<UIVertex>.InsertionSort
	|
	|-RVA: 0x3975FF0 Offset: 0x39760F1 VA: 0x3975FF0
	|-ArraySortHelper<ushort>.InsertionSort
	|
	|-RVA: 0x3977680 Offset: 0x3977781 VA: 0x3977680
	|-ArraySortHelper<uint>.InsertionSort
	|
	|-RVA: 0x3978D10 Offset: 0x3978E11 VA: 0x3978D10
	|-ArraySortHelper<ulong>.InsertionSort
	|
	|-RVA: 0x397A4B0 Offset: 0x397A5B1 VA: 0x397A4B0
	|-ArraySortHelper<Vector2>.InsertionSort
	|
	|-RVA: 0x397BDA0 Offset: 0x397BEA1 VA: 0x397BDA0
	|-ArraySortHelper<Vector3>.InsertionSort
	|
	|-RVA: 0x397D750 Offset: 0x397D851 VA: 0x397D750
	|-ArraySortHelper<Vector4>.InsertionSort
	|
	|-RVA: 0x397EF80 Offset: 0x397F081 VA: 0x397EF80
	|-ArraySortHelper<VertexAttributeDescriptor>.InsertionSort
	|
	|-RVA: 0x39807E0 Offset: 0x39808E1 VA: 0x39807E0
	|-ArraySortHelper<X509ChainStatus>.InsertionSort
	|
	|-RVA: 0x391FCA0 Offset: 0x391FDA1 VA: 0x391FCA0
	|-ArraySortHelper<XRView>.InsertionSort
	|
	|-RVA: 0x39215D0 Offset: 0x39216D1 VA: 0x39215D0
	|-ArraySortHelper<AmiiboSequence.GainItemData>.InsertionSort
	|
	|-RVA: 0x3923070 Offset: 0x3923171 VA: 0x3923070
	|-ArraySortHelper<AnimationOutputWeightProcessor.WeightInfo>.InsertionSort
	|
	|-RVA: 0x39249B0 Offset: 0x3924AB1 VA: 0x39249B0
	|-ArraySortHelper<ArenaOrderSequence.GodInfo>.InsertionSort
	|
	|-RVA: 0x3926250 Offset: 0x3926351 VA: 0x3926250
	|-ArraySortHelper<BattleInfo.SupportData>.InsertionSort
	|
	|-RVA: 0x3927AC0 Offset: 0x3927BC1 VA: 0x3927AC0
	|-ArraySortHelper<BeforeRenderHelper.OrderBlock>.InsertionSort
	|
	|-RVA: 0x39294A0 Offset: 0x39295A1 VA: 0x39294A0
	|-ArraySortHelper<Camera.RenderRequest>.InsertionSort
	|
	|-RVA: 0x392ADB0 Offset: 0x392AEB1 VA: 0x392ADB0
	|-ArraySortHelper<CameraState.CustomBlendable>.InsertionSort
	|
	|-RVA: 0x392C480 Offset: 0x392C581 VA: 0x392C480
	|-ArraySortHelper<CinemachineClearShot.Pair>.InsertionSort
	|
	|-RVA: 0x392DB10 Offset: 0x392DC11 VA: 0x392DB10
	|-ArraySortHelper<CinemachineStateDrivenCamera.HashPair>.InsertionSort
	|
	|-RVA: 0x392F430 Offset: 0x392F531 VA: 0x392F430
	|-ArraySortHelper<DeferredTiler.PrePunctualLight>.InsertionSort
	|
	|-RVA: 0x3930E70 Offset: 0x3930F71 VA: 0x3930E70
	|-ArraySortHelper<DelayedActionManager.DelegateInfo>.InsertionSort
	|
	|-RVA: 0x3932980 Offset: 0x3932A81 VA: 0x3932980
	|-ArraySortHelper<Detail.AsyncResultInt>.InsertionSort
	|
	|-RVA: 0x3934210 Offset: 0x3934311 VA: 0x3934210
	|-ArraySortHelper<Detail.CppArray>.InsertionSort
	|
	|-RVA: 0x3935CA0 Offset: 0x3935DA1 VA: 0x3935CA0
	|-ArraySortHelper<Detail.NotificationEventInt>.InsertionSort
	|
	|-RVA: 0x39375E0 Offset: 0x39376E1 VA: 0x39375E0
	|-ArraySortHelper<DragonRideTargetGroup.ChainParam>.InsertionSort
	|
	|-RVA: 0x3938FC0 Offset: 0x39390C1 VA: 0x3938FC0
	|-ArraySortHelper<GmapPathAdjuster.TargetModel>.InsertionSort
	|
	|-RVA: 0x393AA00 Offset: 0x393AB01 VA: 0x393AA00
	|-ArraySortHelper<GmapSpotAdjuster.TargetModel>.InsertionSort
	|
	|-RVA: 0x393C440 Offset: 0x393C541 VA: 0x393C440
	|-ArraySortHelper<HubFastTravel.Location>.InsertionSort
	|
	|-RVA: 0x393DFE0 Offset: 0x393E0E1 VA: 0x393DFE0
	|-ArraySortHelper<HubLensFlare.Flare>.InsertionSort
	|
	|-RVA: 0x393F910 Offset: 0x393FA11 VA: 0x393F910
	|-ArraySortHelper<InventoryPoolItemMenuContent.KindBgNameClass>.InsertionSort
	|
	|-RVA: 0x3940FE0 Offset: 0x39410E1 VA: 0x3940FE0
	|-ArraySortHelper<Map.Pos>.InsertionSort
	|
	|-RVA: 0x3942790 Offset: 0x3942891 VA: 0x3942790
	|-ArraySortHelper<MapImage.BackupTerrain>.InsertionSort
	|
	|-RVA: 0x3943F00 Offset: 0x3944001 VA: 0x3943F00
	|-ArraySortHelper<MapImageRange.Pos>.InsertionSort
	|
	|-RVA: 0x39458B0 Offset: 0x39459B1 VA: 0x39458B0
	|-ArraySortHelper<MapMind.Target>.InsertionSort
	|
	|-RVA: 0x3947240 Offset: 0x3947341 VA: 0x3947240
	|-ArraySortHelper<MapPanelDebug.Entity>.InsertionSort
	|
	|-RVA: 0x3948960 Offset: 0x3948A61 VA: 0x3948960
	|-ArraySortHelper<NexRanking.Data>.InsertionSort
	|
	|-RVA: 0x394A110 Offset: 0x394A211 VA: 0x394A110
	|-ArraySortHelper<NexVersus.RatingData>.InsertionSort
	|
	|-RVA: 0x394B970 Offset: 0x394BA71 VA: 0x394B970
	|-ArraySortHelper<PackedPlayModeBuildLogs.RuntimeBuildLog>.InsertionSort
	|
	|-RVA: 0x394D370 Offset: 0x394D471 VA: 0x394D370
	|-ArraySortHelper<ParticleSystem.Particle>.InsertionSort
	|
	|-RVA: 0x394EDC0 Offset: 0x394EEC1 VA: 0x394EDC0
	|-ArraySortHelper<ProfileCard.SortieCount>.InsertionSort
	|
	|-RVA: 0x3780040 Offset: 0x3780141 VA: 0x3780040
	|-ArraySortHelper<RangeData.Offset>.InsertionSort
	|
	|-RVA: 0x37819D0 Offset: 0x3781AD1 VA: 0x37819D0
	|-ArraySortHelper<RenderGraphDebugData.PassDebugData>.InsertionSort
	|
	|-RVA: 0x3783550 Offset: 0x3783651 VA: 0x3783550
	|-ArraySortHelper<RenderGraphDebugData.ResourceDebugData>.InsertionSort
	|
	|-RVA: 0x3784EB0 Offset: 0x3784FB1 VA: 0x3784EB0
	|-ArraySortHelper<RingCleaningUnitSelectMenu.GodParam>.InsertionSort
	|
	|-RVA: 0x3786940 Offset: 0x3786A41 VA: 0x3786940
	|-ArraySortHelper<ShadowUtility.Edge>.InsertionSort
	|
	|-RVA: 0x37880B0 Offset: 0x37881B1 VA: 0x37880B0
	|-ArraySortHelper<SkillArray.Entity>.InsertionSort
	|
	|-RVA: 0x3789CD0 Offset: 0x3789DD1 VA: 0x3789CD0
	|-ArraySortHelper<TexturePacker_JsonArray.Frame>.InsertionSort
	|
	|-RVA: 0x378B7D0 Offset: 0x378B8D1 VA: 0x378B7D0
	|-ArraySortHelper<TimeNotificationBehaviour.NotificationEntry>.InsertionSort
	|
	|-RVA: 0x378D220 Offset: 0x378D321 VA: 0x378D220
	|-ArraySortHelper<UnitySynchronizationContext.WorkRequest>.InsertionSort
	|
	|-RVA: 0x378EB20 Offset: 0x378EC21 VA: 0x378EB20
	|-ArraySortHelper<XmlSchemaObjectTable.XmlSchemaObjectEntry>.InsertionSort
	|
	|-RVA: 0x37902A0 Offset: 0x37903A1 VA: 0x37902A0
	|-ArraySortHelper<AIThink.EnchantThink.ItemInfo>.InsertionSort
	|
	|-RVA: 0x3791B10 Offset: 0x3791C11 VA: 0x3791B10
	|-ArraySortHelper<AssetBundleBuildMap.AssetBundleEntry.AssetPathString>.InsertionSort
	|
	|-RVA: 0x3793600 Offset: 0x3793701 VA: 0x3793600
	|-ArraySortHelper<Detail.DataStore.DataStoreChangeMetaParamInt>.InsertionSort
	|
	|-RVA: 0x3794EC0 Offset: 0x3794FC1 VA: 0x3794EC0
	|-ArraySortHelper<Detail.DataStore.DataStoreDeleteParamInt>.InsertionSort
	|
	|-RVA: 0x3796950 Offset: 0x3796A51 VA: 0x3796950
	|-ArraySortHelper<Detail.DataStore.DataStoreGetMetaParamInt>.InsertionSort
	|
	|-RVA: 0x3798410 Offset: 0x3798511 VA: 0x3798410
	|-ArraySortHelper<Detail.DataStore.DataStoreMetaInfoInt>.InsertionSort
	|
	|-RVA: 0x3799DC0 Offset: 0x3799EC1 VA: 0x3799DC0
	|-ArraySortHelper<Detail.DataStore.DataStorePasswordInfoInt>.InsertionSort
	|
	|-RVA: 0x379B740 Offset: 0x379B841 VA: 0x379B740
	|-ArraySortHelper<Detail.DataStore.DataStorePersistenceInfoInt>.InsertionSort
	|
	|-RVA: 0x379D190 Offset: 0x379D291 VA: 0x379D190
	|-ArraySortHelper<Detail.DataStore.DataStorePreparePostParamInt>.InsertionSort
	|
	|-RVA: 0x379E9F0 Offset: 0x379EAF1 VA: 0x379E9F0
	|-ArraySortHelper<Detail.DataStore.DataStoreRateObjectParamInt>.InsertionSort
	|
	|-RVA: 0x37A0340 Offset: 0x37A0441 VA: 0x37A0340
	|-ArraySortHelper<Detail.DataStore.DataStoreRatingInitParamInt>.InsertionSort
	|
	|-RVA: 0x37A1B90 Offset: 0x37A1C91 VA: 0x37A1B90
	|-ArraySortHelper<Detail.DataStore.DataStoreRatingTargetInt>.InsertionSort
	|
	|-RVA: 0x37A3760 Offset: 0x37A3861 VA: 0x37A3760
	|-ArraySortHelper<Detail.Ranking.RankingCachedResultInt>.InsertionSort
	|
	|-RVA: 0x37A5040 Offset: 0x37A5141 VA: 0x37A5040
	|-ArraySortHelper<Detail.Ranking.RankingOrderParamInt>.InsertionSort
	|
	|-RVA: 0x37A6C40 Offset: 0x37A6D41 VA: 0x37A6C40
	|-ArraySortHelper<Detail.Ranking.RankingRankDataInt>.InsertionSort
	|
	|-RVA: 0x37A8C50 Offset: 0x37A8D51 VA: 0x37A8C50
	|-ArraySortHelper<Detail.Ranking2.Ranking2ChartInfoInt>.InsertionSort
	|
	|-RVA: 0x37AAA00 Offset: 0x37AAB01 VA: 0x37AAA00
	|-ArraySortHelper<Detail.Ranking2.Ranking2RankDataInt>.InsertionSort
	|
	|-RVA: 0x37AC2F0 Offset: 0x37AC3F1 VA: 0x37AC2F0
	|-ArraySortHelper<Detail.Ranking2.Ranking2ScoreDataInt>.InsertionSort
	|
	|-RVA: 0x37ADC40 Offset: 0x37ADD41 VA: 0x37ADC40
	|-ArraySortHelper<Detail.Screening.ScreeningContextInfoInt>.InsertionSort
	|
	|-RVA: 0x37AF9F0 Offset: 0x37AFAF1 VA: 0x37AF9F0
	|-ArraySortHelper<Detail.Subscriber.SubscriberContentInt>.InsertionSort
	|
	|-RVA: 0x37B1470 Offset: 0x37B1571 VA: 0x37B1470
	|-ArraySortHelper<Detail.Subscriber.SubscriberGetContentParamInt>.InsertionSort
	|
	|-RVA: 0x32BF8D0 Offset: 0x32BF9D1 VA: 0x32BF8D0
	|-ArraySortHelper<Detail.Subscriber.SubscriberUserStatusInfoInt>.InsertionSort
	|
	|-RVA: 0x32C12A0 Offset: 0x32C13A1 VA: 0x32C12A0
	|-ArraySortHelper<Detail.Subscriber.SubscriberUserStatusParamInt>.InsertionSort
	|
	|-RVA: 0x32C29C0 Offset: 0x32C2AC1 VA: 0x32C29C0
	|-ArraySortHelper<Detail.Utility.IntegerSettings>.InsertionSort
	|
	|-RVA: 0x32C4170 Offset: 0x32C4271 VA: 0x32C4170
	|-ArraySortHelper<Detail.Utility.UniqueIdInfoInt>.InsertionSort
	|
	|-RVA: 0x32C59C0 Offset: 0x32C5AC1 VA: 0x32C59C0
	|-ArraySortHelper<MapHistory.Rewind.LatestInspectorData>.InsertionSort
	|
	|-RVA: 0x32C7230 Offset: 0x32C7331 VA: 0x32C7230
	|-ArraySortHelper<MapHistory.Rewind.WorkTerrainData>.InsertionSort
	|
	|-RVA: 0x32C89C0 Offset: 0x32C8AC1 VA: 0x32C89C0
	|-ArraySortHelper<MapKillBonus.Work.Pos>.InsertionSort
	|
	|-RVA: 0x32CA230 Offset: 0x32CA331 VA: 0x32CA230
	|-ArraySortHelper<MapSkill.AroundCalculator.Result>.InsertionSort
	|
	|-RVA: 0x32CBCC0 Offset: 0x32CBDC1 VA: 0x32CBCC0
	|-ArraySortHelper<TargetPositionCache.CacheCurve.Item>.InsertionSort
	|
	|-RVA: 0x32CD8A0 Offset: 0x32CD9A1 VA: 0x32CD8A0
	|-ArraySortHelper<TargetPositionCache.CacheEntry.RecordingItem>.InsertionSort
	*/
}

// Namespace: System.Collections.Generic
internal class ArraySortHelper<TKey, TValue> // TypeDefIndex: 1399
{
	// Fields
	private static ArraySortHelper<TKey, TValue> s_defaultArraySortHelper; // 0x0

	// Properties
	public static ArraySortHelper<TKey, TValue> Default { get; }

	// Methods

	// RVA: -1 Offset: -1
	public static ArraySortHelper<TKey, TValue> get_Default() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x32CDB20 Offset: 0x32CDC21 VA: 0x32CDB20
	|-ArraySortHelper<object, object>.get_Default
	|
	|-RVA: 0x32CF390 Offset: 0x32CF491 VA: 0x32CF390
	|-ArraySortHelper<ulong, object>.get_Default
	*/

	// RVA: -1 Offset: -1
	private static ArraySortHelper<TKey, TValue> CreateArraySortHelper() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x32CDC00 Offset: 0x32CDD01 VA: 0x32CDC00
	|-ArraySortHelper<object, object>.CreateArraySortHelper
	|
	|-RVA: 0x32CF470 Offset: 0x32CF571 VA: 0x32CF470
	|-ArraySortHelper<ulong, object>.CreateArraySortHelper
	*/

	// RVA: -1 Offset: -1
	public void Sort(TKey[] keys, TValue[] values, int index, int length, IComparer<TKey> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x32CDD20 Offset: 0x32CDE21 VA: 0x32CDD20
	|-ArraySortHelper<object, object>.Sort
	|
	|-RVA: 0x32CF590 Offset: 0x32CF691 VA: 0x32CF590
	|-ArraySortHelper<ulong, object>.Sort
	*/

	// RVA: -1 Offset: -1
	private static void SwapIfGreaterWithItems(TKey[] keys, TValue[] values, IComparer<TKey> comparer, int a, int b) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x32CDEC0 Offset: 0x32CDFC1 VA: 0x32CDEC0
	|-ArraySortHelper<object, object>.SwapIfGreaterWithItems
	|
	|-RVA: 0x32CF730 Offset: 0x32CF831 VA: 0x32CF730
	|-ArraySortHelper<ulong, object>.SwapIfGreaterWithItems
	*/

	// RVA: -1 Offset: -1
	private static void Swap(TKey[] keys, TValue[] values, int i, int j) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x32CE0D0 Offset: 0x32CE1D1 VA: 0x32CE0D0
	|-ArraySortHelper<object, object>.Swap
	|
	|-RVA: 0x32CF920 Offset: 0x32CFA21 VA: 0x32CF920
	|-ArraySortHelper<ulong, object>.Swap
	*/

	// RVA: -1 Offset: -1
	internal static void IntrospectiveSort(TKey[] keys, TValue[] values, int left, int length, IComparer<TKey> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x32CE1E0 Offset: 0x32CE2E1 VA: 0x32CE1E0
	|-ArraySortHelper<object, object>.IntrospectiveSort
	|
	|-RVA: 0x32CFA00 Offset: 0x32CFB01 VA: 0x32CFA00
	|-ArraySortHelper<ulong, object>.IntrospectiveSort
	*/

	// RVA: -1 Offset: -1
	private static void IntroSort(TKey[] keys, TValue[] values, int lo, int hi, int depthLimit, IComparer<TKey> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x32CE2C0 Offset: 0x32CE3C1 VA: 0x32CE2C0
	|-ArraySortHelper<object, object>.IntroSort
	|
	|-RVA: 0x32CFAE0 Offset: 0x32CFBE1 VA: 0x32CFAE0
	|-ArraySortHelper<ulong, object>.IntroSort
	*/

	// RVA: -1 Offset: -1
	private static int PickPivotAndPartition(TKey[] keys, TValue[] values, int lo, int hi, IComparer<TKey> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x32CE680 Offset: 0x32CE781 VA: 0x32CE680
	|-ArraySortHelper<object, object>.PickPivotAndPartition
	|
	|-RVA: 0x32CFEA0 Offset: 0x32CFFA1 VA: 0x32CFEA0
	|-ArraySortHelper<ulong, object>.PickPivotAndPartition
	*/

	// RVA: -1 Offset: -1
	private static void Heapsort(TKey[] keys, TValue[] values, int lo, int hi, IComparer<TKey> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x32CEAE0 Offset: 0x32CEBE1 VA: 0x32CEAE0
	|-ArraySortHelper<object, object>.Heapsort
	|
	|-RVA: 0x32D0300 Offset: 0x32D0401 VA: 0x32D0300
	|-ArraySortHelper<ulong, object>.Heapsort
	*/

	// RVA: -1 Offset: -1
	private static void DownHeap(TKey[] keys, TValue[] values, int i, int n, int lo, IComparer<TKey> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x32CEC90 Offset: 0x32CED91 VA: 0x32CEC90
	|-ArraySortHelper<object, object>.DownHeap
	|
	|-RVA: 0x32D04B0 Offset: 0x32D05B1 VA: 0x32D04B0
	|-ArraySortHelper<ulong, object>.DownHeap
	*/

	// RVA: -1 Offset: -1
	private static void InsertionSort(TKey[] keys, TValue[] values, int lo, int hi, IComparer<TKey> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x32CF010 Offset: 0x32CF111 VA: 0x32CF010
	|-ArraySortHelper<object, object>.InsertionSort
	|
	|-RVA: 0x32D0820 Offset: 0x32D0921 VA: 0x32D0820
	|-ArraySortHelper<ulong, object>.InsertionSort
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x32CF380 Offset: 0x32CF481 VA: 0x32CF380
	|-ArraySortHelper<object, object>..ctor
	|
	|-RVA: 0x32D0B80 Offset: 0x32D0C81 VA: 0x32D0B80
	|-ArraySortHelper<ulong, object>..ctor
	*/
}

