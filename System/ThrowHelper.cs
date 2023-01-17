// Namespace: System
internal static class ThrowHelper // TypeDefIndex: 103
{
	// Methods

	// RVA: 0x1B16D50 Offset: 0x1B16E51 VA: 0x1B16D50
	internal static void ThrowArgumentNullException(ExceptionArgument argument) { }

	// RVA: 0x1B16D80 Offset: 0x1B16E81 VA: 0x1B16D80
	private static Exception CreateArgumentNullException(ExceptionArgument argument) { }

	// RVA: 0x1B16E40 Offset: 0x1B16F41 VA: 0x1B16E40
	internal static void ThrowArgumentOutOfRangeException() { }

	// RVA: 0x1B16F10 Offset: 0x1B17011 VA: 0x1B16F10
	internal static void ThrowWrongValueTypeArgumentException(object value, Type targetType) { }

	// RVA: 0x1B16FE0 Offset: 0x1B170E1 VA: 0x1B16FE0
	internal static void ThrowArgumentException(ExceptionResource resource) { }

	// RVA: 0x1B16E60 Offset: 0x1B16F61 VA: 0x1B16E60
	internal static void ThrowArgumentOutOfRangeException(ExceptionArgument argument, ExceptionResource resource) { }

	// RVA: 0x1B17480 Offset: 0x1B17581 VA: 0x1B17480
	internal static void ThrowInvalidOperationException(ExceptionResource resource) { }

	// RVA: 0x1B174E0 Offset: 0x1B175E1 VA: 0x1B174E0
	internal static void ThrowNotSupportedException(ExceptionResource resource) { }

	// RVA: -1 Offset: -1
	internal static void IfNullAndNullsAreIllegalThenThrow<T>(object value, ExceptionArgument argName) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2026BB0 Offset: 0x2026CB1 VA: 0x2026BB0
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<IntervalTree.Entry<object>>
	|
	|-RVA: 0x2026BD0 Offset: 0x2026CD1 VA: 0x2026BD0
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<KeyValuePair<DateTime, object>>
	|
	|-RVA: 0x2026BF0 Offset: 0x2026CF1 VA: 0x2026BF0
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<KeyValuePair<int, object>>
	|
	|-RVA: 0x2026C10 Offset: 0x2026D11 VA: 0x2026C10
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<KeyValuePair<object, ValueTuple<int, DateTime, object>>>
	|
	|-RVA: 0x2026C30 Offset: 0x2026D31 VA: 0x2026C30
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<KeyValuePair<object, object>>
	|
	|-RVA: 0x2026C50 Offset: 0x2026D51 VA: 0x2026C50
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<CommonBattleSequence.Reliance<object>>
	|
	|-RVA: 0x2026C70 Offset: 0x2026D71 VA: 0x2026C70
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<RenderGraphResourcePool.ResourceLogInfo<object>>
	|
	|-RVA: 0x2026C90 Offset: 0x2026D91 VA: 0x2026C90
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<ValueTuple<int, object>>
	|
	|-RVA: 0x2026CB0 Offset: 0x2026DB1 VA: 0x2026CB0
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<ValueTuple<Int32Enum, int>>
	|
	|-RVA: 0x2026CD0 Offset: 0x2026DD1 VA: 0x2026CD0
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<ValueTuple<object, ValueTuple<object, int>>>
	|
	|-RVA: 0x2026CF0 Offset: 0x2026DF1 VA: 0x2026CF0
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<ValueTuple<object, int>>
	|
	|-RVA: 0x2026D10 Offset: 0x2026E11 VA: 0x2026D10
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<ValueTuple<Vector3, float>>
	|
	|-RVA: 0x2026D30 Offset: 0x2026E31 VA: 0x2026D30
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<ValueTuple<object, Int32Enum, int>>
	|
	|-RVA: 0x2026D50 Offset: 0x2026E51 VA: 0x2026D50
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<ValueTuple<object, int, int, int>>
	|
	|-RVA: 0x2026D70 Offset: 0x2026E71 VA: 0x2026D70
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<AnimatorClipInfo>
	|
	|-RVA: 0x2026D90 Offset: 0x2026E91 VA: 0x2026D90
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<AsyncOperationHandle>
	|
	|-RVA: 0x2026DB0 Offset: 0x2026EB1 VA: 0x2026DB0
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<BoneWeight>
	|
	|-RVA: 0x2026DD0 Offset: 0x2026ED1 VA: 0x2026DD0
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<bool>
	|
	|-RVA: 0x2026DF0 Offset: 0x2026EF1 VA: 0x2026DF0
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<byte>
	|
	|-RVA: 0x2026E10 Offset: 0x2026F11 VA: 0x2026E10
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<CameraInfo>
	|
	|-RVA: 0x2026E30 Offset: 0x2026F31 VA: 0x2026E30
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<char>
	|
	|-RVA: 0x2026E50 Offset: 0x2026F51 VA: 0x2026E50
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<Color>
	|
	|-RVA: 0x2026E70 Offset: 0x2026F71 VA: 0x2026E70
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<Color32>
	|
	|-RVA: 0x2026E90 Offset: 0x2026F91 VA: 0x2026E90
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<ConstraintSource>
	|
	|-RVA: 0x2026EB0 Offset: 0x2026FB1 VA: 0x2026EB0
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<ContourVertex>
	|
	|-RVA: 0x2026ED0 Offset: 0x2026FD1 VA: 0x2026ED0
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<DataStoreRatingInfo>
	|
	|-RVA: 0x2026EF0 Offset: 0x2026FF1 VA: 0x2026EF0
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<DataStoreResult>
	|
	|-RVA: 0x2026F10 Offset: 0x2027011 VA: 0x2026F10
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<DateTime>
	|
	|-RVA: 0x2026F30 Offset: 0x2027031 VA: 0x2026F30
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<DateTimeOffset>
	|
	|-RVA: 0x2026F50 Offset: 0x2027051 VA: 0x2026F50
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<Decimal>
	|
	|-RVA: 0x2026F70 Offset: 0x2027071 VA: 0x2026F70
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<DiagnosticEvent>
	|
	|-RVA: 0x2026F90 Offset: 0x2027091 VA: 0x2026F90
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<double>
	|
	|-RVA: 0x2026FB0 Offset: 0x20270B1 VA: 0x2026FB0
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<Friend>
	|
	|-RVA: 0x2026FD0 Offset: 0x20270D1 VA: 0x2026FD0
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<GlyphRect>
	|
	|-RVA: 0x2026FF0 Offset: 0x20270F1 VA: 0x2026FF0
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<short>
	|
	|-RVA: 0x2027010 Offset: 0x2027111 VA: 0x2027010
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<int>
	|
	|-RVA: 0x2027030 Offset: 0x2027131 VA: 0x2027030
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<Int32Enum>
	|
	|-RVA: 0x2027050 Offset: 0x2027151 VA: 0x2027050
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<long>
	|
	|-RVA: 0x2027070 Offset: 0x2027171 VA: 0x2027070
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<IntPtr>
	|
	|-RVA: 0x2027090 Offset: 0x2027191 VA: 0x2027090
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<InterpretedFrameInfo>
	|
	|-RVA: 0x20270B0 Offset: 0x20271B1 VA: 0x20270B0
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<IntervalTreeNode>
	|
	|-RVA: 0x20270D0 Offset: 0x20271D1 VA: 0x20270D0
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<LengthLimitProperties>
	|
	|-RVA: 0x20270F0 Offset: 0x20271F1 VA: 0x20270F0
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<MapPos>
	|
	|-RVA: 0x2027110 Offset: 0x2027211 VA: 0x2027110
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<Matrix4x4>
	|
	|-RVA: 0x2027130 Offset: 0x2027231 VA: 0x2027130
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<object>
	|
	|-RVA: 0x2027140 Offset: 0x2027241 VA: 0x2027140
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<ObjectInitializationData>
	|
	|-RVA: 0x2027160 Offset: 0x2027261 VA: 0x2027160
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<PlayableBinding>
	|
	|-RVA: 0x2027180 Offset: 0x2027281 VA: 0x2027180
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<PlayerLoopSystem>
	|
	|-RVA: 0x20271A0 Offset: 0x20272A1 VA: 0x20271A0
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<PlayerLoopSystemInternal>
	|
	|-RVA: 0x20271C0 Offset: 0x20272C1 VA: 0x20271C0
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<RangePositionInfo>
	|
	|-RVA: 0x20271E0 Offset: 0x20272E1 VA: 0x20271E0
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<Ranking2ChartInfoInput>
	|
	|-RVA: 0x2027200 Offset: 0x2027301 VA: 0x2027200
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<RaycastHit2D>
	|
	|-RVA: 0x2027220 Offset: 0x2027321 VA: 0x2027220
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<RaycastResult>
	|
	|-RVA: 0x2027240 Offset: 0x2027341 VA: 0x2027240
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<Rect>
	|
	|-RVA: 0x2027260 Offset: 0x2027361 VA: 0x2027260
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<RendererListHandle>
	|
	|-RVA: 0x2027280 Offset: 0x2027381 VA: 0x2027280
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<ResourceHandle>
	|
	|-RVA: 0x20272A0 Offset: 0x20273A1 VA: 0x20272A0
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<sbyte>
	|
	|-RVA: 0x20272C0 Offset: 0x20273C1 VA: 0x20272C0
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<ShaderTagId>
	|
	|-RVA: 0x20272E0 Offset: 0x20273E1 VA: 0x20272E0
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<float>
	|
	|-RVA: 0x2027300 Offset: 0x2027401 VA: 0x2027300
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<SphericalHarmonicsL2>
	|
	|-RVA: 0x2027320 Offset: 0x2027421 VA: 0x2027320
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<SubMeshDescriptor>
	|
	|-RVA: 0x2027340 Offset: 0x2027441 VA: 0x2027340
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<TablePair>
	|
	|-RVA: 0x2027360 Offset: 0x2027461 VA: 0x2027360
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<TimeSpan>
	|
	|-RVA: 0x2027380 Offset: 0x2027481 VA: 0x2027380
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<UICharInfo>
	|
	|-RVA: 0x20273A0 Offset: 0x20274A1 VA: 0x20273A0
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<UILineInfo>
	|
	|-RVA: 0x20273C0 Offset: 0x20274C1 VA: 0x20273C0
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<UIVertex>
	|
	|-RVA: 0x20273E0 Offset: 0x20274E1 VA: 0x20273E0
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<ushort>
	|
	|-RVA: 0x2027400 Offset: 0x2027501 VA: 0x2027400
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<uint>
	|
	|-RVA: 0x2027420 Offset: 0x2027521 VA: 0x2027420
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<ulong>
	|
	|-RVA: 0x2027440 Offset: 0x2027541 VA: 0x2027440
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<Vector2>
	|
	|-RVA: 0x2027460 Offset: 0x2027561 VA: 0x2027460
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<Vector3>
	|
	|-RVA: 0x2027480 Offset: 0x2027581 VA: 0x2027480
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<Vector4>
	|
	|-RVA: 0x20274A0 Offset: 0x20275A1 VA: 0x20274A0
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<VertexAttributeDescriptor>
	|
	|-RVA: 0x20274C0 Offset: 0x20275C1 VA: 0x20274C0
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<X509ChainStatus>
	|
	|-RVA: 0x20274E0 Offset: 0x20275E1 VA: 0x20274E0
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<XRView>
	|
	|-RVA: 0x2027500 Offset: 0x2027601 VA: 0x2027500
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<AmiiboSequence.GainItemData>
	|
	|-RVA: 0x2027520 Offset: 0x2027621 VA: 0x2027520
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<AnimationOutputWeightProcessor.WeightInfo>
	|
	|-RVA: 0x2027540 Offset: 0x2027641 VA: 0x2027540
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<ArenaOrderSequence.GodInfo>
	|
	|-RVA: 0x2027560 Offset: 0x2027661 VA: 0x2027560
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<BattleInfo.SupportData>
	|
	|-RVA: 0x2027580 Offset: 0x2027681 VA: 0x2027580
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<BeforeRenderHelper.OrderBlock>
	|
	|-RVA: 0x20275A0 Offset: 0x20276A1 VA: 0x20275A0
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<Camera.RenderRequest>
	|
	|-RVA: 0x20275C0 Offset: 0x20276C1 VA: 0x20275C0
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<CameraState.CustomBlendable>
	|
	|-RVA: 0x20275E0 Offset: 0x20276E1 VA: 0x20275E0
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<CinemachineClearShot.Pair>
	|
	|-RVA: 0x2027600 Offset: 0x2027701 VA: 0x2027600
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<CinemachineStateDrivenCamera.HashPair>
	|
	|-RVA: 0x2027620 Offset: 0x2027721 VA: 0x2027620
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<DelayedActionManager.DelegateInfo>
	|
	|-RVA: 0x2027640 Offset: 0x2027741 VA: 0x2027640
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<Detail.AsyncResultInt>
	|
	|-RVA: 0x2027660 Offset: 0x2027761 VA: 0x2027660
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<Detail.CppArray>
	|
	|-RVA: 0x2027680 Offset: 0x2027781 VA: 0x2027680
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<Detail.NotificationEventInt>
	|
	|-RVA: 0x20276A0 Offset: 0x20277A1 VA: 0x20276A0
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<DragonRideTargetGroup.ChainParam>
	|
	|-RVA: 0x20276C0 Offset: 0x20277C1 VA: 0x20276C0
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<GmapPathAdjuster.TargetModel>
	|
	|-RVA: 0x20276E0 Offset: 0x20277E1 VA: 0x20276E0
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<GmapSpotAdjuster.TargetModel>
	|
	|-RVA: 0x2027700 Offset: 0x2027801 VA: 0x2027700
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<HubFastTravel.Location>
	|
	|-RVA: 0x2027720 Offset: 0x2027821 VA: 0x2027720
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<HubLensFlare.Flare>
	|
	|-RVA: 0x2027740 Offset: 0x2027841 VA: 0x2027740
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<InventoryPoolItemMenuContent.KindBgNameClass>
	|
	|-RVA: 0x2027760 Offset: 0x2027861 VA: 0x2027760
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<Map.Pos>
	|
	|-RVA: 0x2027780 Offset: 0x2027881 VA: 0x2027780
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<MapImage.BackupTerrain>
	|
	|-RVA: 0x20277A0 Offset: 0x20278A1 VA: 0x20277A0
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<MapImageRange.Pos>
	|
	|-RVA: 0x20277C0 Offset: 0x20278C1 VA: 0x20277C0
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<MapMind.Target>
	|
	|-RVA: 0x20277E0 Offset: 0x20278E1 VA: 0x20277E0
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<MapPanelDebug.Entity>
	|
	|-RVA: 0x2027800 Offset: 0x2027901 VA: 0x2027800
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<NexRanking.Data>
	|
	|-RVA: 0x2027820 Offset: 0x2027921 VA: 0x2027820
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<NexVersus.RatingData>
	|
	|-RVA: 0x2027840 Offset: 0x2027941 VA: 0x2027840
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<PackedPlayModeBuildLogs.RuntimeBuildLog>
	|
	|-RVA: 0x2027860 Offset: 0x2027961 VA: 0x2027860
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<ParticleSystem.Particle>
	|
	|-RVA: 0x2027880 Offset: 0x2027981 VA: 0x2027880
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<RangeData.Offset>
	|
	|-RVA: 0x20278A0 Offset: 0x20279A1 VA: 0x20278A0
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<RenderGraphDebugData.PassDebugData>
	|
	|-RVA: 0x20278C0 Offset: 0x20279C1 VA: 0x20278C0
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<RenderGraphDebugData.ResourceDebugData>
	|
	|-RVA: 0x20278E0 Offset: 0x20279E1 VA: 0x20278E0
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<RingCleaningUnitSelectMenu.GodParam>
	|
	|-RVA: 0x2027900 Offset: 0x2027A01 VA: 0x2027900
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<ShadowUtility.Edge>
	|
	|-RVA: 0x2027920 Offset: 0x2027A21 VA: 0x2027920
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<SkillArray.Entity>
	|
	|-RVA: 0x2027940 Offset: 0x2027A41 VA: 0x2027940
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<TexturePacker_JsonArray.Frame>
	|
	|-RVA: 0x2027960 Offset: 0x2027A61 VA: 0x2027960
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<TimeNotificationBehaviour.NotificationEntry>
	|
	|-RVA: 0x2027980 Offset: 0x2027A81 VA: 0x2027980
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<UnitySynchronizationContext.WorkRequest>
	|
	|-RVA: 0x20279A0 Offset: 0x2027AA1 VA: 0x20279A0
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<XmlSchemaObjectTable.XmlSchemaObjectEntry>
	|
	|-RVA: 0x20279C0 Offset: 0x2027AC1 VA: 0x20279C0
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<AssetBundleBuildMap.AssetBundleEntry.AssetPathString>
	|
	|-RVA: 0x20279E0 Offset: 0x2027AE1 VA: 0x20279E0
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<Detail.DataStore.DataStoreChangeMetaParamInt>
	|
	|-RVA: 0x2027A00 Offset: 0x2027B01 VA: 0x2027A00
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<Detail.DataStore.DataStoreDeleteParamInt>
	|
	|-RVA: 0x2027A20 Offset: 0x2027B21 VA: 0x2027A20
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<Detail.DataStore.DataStoreGetMetaParamInt>
	|
	|-RVA: 0x2027A40 Offset: 0x2027B41 VA: 0x2027A40
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<Detail.DataStore.DataStoreMetaInfoInt>
	|
	|-RVA: 0x2027A60 Offset: 0x2027B61 VA: 0x2027A60
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<Detail.DataStore.DataStorePasswordInfoInt>
	|
	|-RVA: 0x2027A80 Offset: 0x2027B81 VA: 0x2027A80
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<Detail.DataStore.DataStorePersistenceInfoInt>
	|
	|-RVA: 0x2027AA0 Offset: 0x2027BA1 VA: 0x2027AA0
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<Detail.DataStore.DataStorePreparePostParamInt>
	|
	|-RVA: 0x2027AC0 Offset: 0x2027BC1 VA: 0x2027AC0
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<Detail.DataStore.DataStoreRateObjectParamInt>
	|
	|-RVA: 0x2027AE0 Offset: 0x2027BE1 VA: 0x2027AE0
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<Detail.DataStore.DataStoreRatingInitParamInt>
	|
	|-RVA: 0x2027B00 Offset: 0x2027C01 VA: 0x2027B00
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<Detail.DataStore.DataStoreRatingTargetInt>
	|
	|-RVA: 0x2027B20 Offset: 0x2027C21 VA: 0x2027B20
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<Detail.Ranking.RankingCachedResultInt>
	|
	|-RVA: 0x2027B40 Offset: 0x2027C41 VA: 0x2027B40
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<Detail.Ranking.RankingOrderParamInt>
	|
	|-RVA: 0x2027B60 Offset: 0x2027C61 VA: 0x2027B60
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<Detail.Ranking.RankingRankDataInt>
	|
	|-RVA: 0x2027B80 Offset: 0x2027C81 VA: 0x2027B80
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<Detail.Ranking2.Ranking2ChartInfoInt>
	|
	|-RVA: 0x2027BA0 Offset: 0x2027CA1 VA: 0x2027BA0
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<Detail.Ranking2.Ranking2RankDataInt>
	|
	|-RVA: 0x2027BC0 Offset: 0x2027CC1 VA: 0x2027BC0
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<Detail.Ranking2.Ranking2ScoreDataInt>
	|
	|-RVA: 0x2027BE0 Offset: 0x2027CE1 VA: 0x2027BE0
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<Detail.Screening.ScreeningContextInfoInt>
	|
	|-RVA: 0x2027C00 Offset: 0x2027D01 VA: 0x2027C00
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<Detail.Subscriber.SubscriberContentInt>
	|
	|-RVA: 0x2027C20 Offset: 0x2027D21 VA: 0x2027C20
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<Detail.Subscriber.SubscriberGetContentParamInt>
	|
	|-RVA: 0x2027C40 Offset: 0x2027D41 VA: 0x2027C40
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<Detail.Subscriber.SubscriberUserStatusInfoInt>
	|
	|-RVA: 0x2027C60 Offset: 0x2027D61 VA: 0x2027C60
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<Detail.Subscriber.SubscriberUserStatusParamInt>
	|
	|-RVA: 0x2027C80 Offset: 0x2027D81 VA: 0x2027C80
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<Detail.Utility.IntegerSettings>
	|
	|-RVA: 0x2027CA0 Offset: 0x2027DA1 VA: 0x2027CA0
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<Detail.Utility.UniqueIdInfoInt>
	|
	|-RVA: 0x2027CC0 Offset: 0x2027DC1 VA: 0x2027CC0
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<MapHistory.Rewind.LatestInspectorData>
	|
	|-RVA: 0x2027CE0 Offset: 0x2027DE1 VA: 0x2027CE0
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<MapHistory.Rewind.WorkTerrainData>
	|
	|-RVA: 0x2027D00 Offset: 0x2027E01 VA: 0x2027D00
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<MapSkill.AroundCalculator.Result>
	|
	|-RVA: 0x2027D20 Offset: 0x2027E21 VA: 0x2027D20
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<TargetPositionCache.CacheCurve.Item>
	|
	|-RVA: 0x2027D40 Offset: 0x2027E41 VA: 0x2027D40
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<TargetPositionCache.CacheEntry.RecordingItem>
	*/

	// RVA: 0x1B172E0 Offset: 0x1B173E1 VA: 0x1B172E0
	internal static string GetArgumentName(ExceptionArgument argument) { }

	// RVA: 0x1B17040 Offset: 0x1B17141 VA: 0x1B17040
	internal static string GetResourceName(ExceptionResource resource) { }
}

