// Namespace: App
public class SingletonClass<T> // TypeDefIndex: 9221
{
	// Fields
	private static T s_Instance; // 0x0
	private BindHolder m_Binder; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x286DA0 Offset: 0x286EA1 VA: 0x286DA0
	private bool <IsResume>k__BackingField; // 0x0

	// Properties
	public static T Instance { get; }
	protected bool IsResume { get; set; }
	protected virtual int Version { get; }

	// Methods

	// RVA: -1 Offset: -1
	public static T get_Instance() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3437CD0 Offset: 0x3437DD1 VA: 0x3437CD0
	|-SingletonClass<AI>.get_Instance
	|-SingletonClass<AIDeploy>.get_Instance
	|-SingletonClass<AmiiboManager>.get_Instance
	|-SingletonClass<DragonRideEffectManager>.get_Instance
	|-SingletonClass<DragonRideShotManager>.get_Instance
	|-SingletonClass<DragonRideTargetManager>.get_Instance
	|-SingletonClass<EncountDataManager>.get_Instance
	|-SingletonClass<GameConfig>.get_Instance
	|-SingletonClass<GameSkip>.get_Instance
	|-SingletonClass<GameUserData>.get_Instance
	|-SingletonClass<GameUserGlobalData>.get_Instance
	|-SingletonClass<GameUserRestartData>.get_Instance
	|-SingletonClass<GmapMenuManager>.get_Instance
	|-SingletonClass<GmapPlayerUnit>.get_Instance
	|-SingletonClass<GmapSpotManager>.get_Instance
	|-SingletonClass<GodBondHolderPool>.get_Instance
	|-SingletonClass<GodPool>.get_Instance
	|-SingletonClass<HubResource>.get_Instance
	|-SingletonClass<KeyHelp>.get_Instance
	|-SingletonClass<MapBattleInfoWindow>.get_Instance
	|-SingletonClass<MapCamera>.get_Instance
	|-SingletonClass<MapCursor>.get_Instance
	|-SingletonClass<MapDeploy>.get_Instance
	|-SingletonClass<MapEditHistory>.get_Instance
	|-SingletonClass<MapEffect>.get_Instance
	|-SingletonClass<MapGodExp>.get_Instance
	|-SingletonClass<MapHeight>.get_Instance
	|-SingletonClass<MapImage>.get_Instance
	|-SingletonClass<MapInspectors>.get_Instance
	|-SingletonClass<MapKillBonus>.get_Instance
	|-SingletonClass<MapLayer>.get_Instance
	|-SingletonClass<MapMind>.get_Instance
	|-SingletonClass<MapOverlap>.get_Instance
	|-SingletonClass<MapRanking>.get_Instance
	|-SingletonClass<MapRoute>.get_Instance
	|-SingletonClass<MapSight>.get_Instance
	|-SingletonClass<MapSimpleBattle>.get_Instance
	|-SingletonClass<MapSituation>.get_Instance
	|-SingletonClass<MapSortiePosition>.get_Instance
	|-SingletonClass<MapTarget>.get_Instance
	|-SingletonClass<MapTerrainInfo>.get_Instance
	|-SingletonClass<NexKillBonus>.get_Instance
	|-SingletonClass<NexProfile>.get_Instance
	|-SingletonClass<NexRanking>.get_Instance
	|-SingletonClass<NexRelay>.get_Instance
	|-SingletonClass<NexVersus>.get_Instance
	|-SingletonClass<object>.get_Instance
	|-SingletonClass<Pad>.get_Instance
	|-SingletonClass<ProfileCardFlags>.get_Instance
	|-SingletonClass<ProfileCardListData>.get_Instance
	|-SingletonClass<ProfileCardMyData>.get_Instance
	|-SingletonClass<QualitySettingsStack>.get_Instance
	|-SingletonClass<Ranking>.get_Instance
	|-SingletonClass<Relay>.get_Instance
	|-SingletonClass<RelayUserGlobalData>.get_Instance
	|-SingletonClass<SortieClassChangeManager>.get_Instance
	|-SingletonClass<SortieInventoryManager>.get_Instance
	|-SingletonClass<SortieRelianceManager>.get_Instance
	|-SingletonClass<SortieSelectionUnitManager>.get_Instance
	|-SingletonClass<SortieSkillEditManager>.get_Instance
	|-SingletonClass<SortieTopMenuManager>.get_Instance
	|-SingletonClass<SortieTradeManager>.get_Instance
	|-SingletonClass<UnitInfoParamManager>.get_Instance
	|-SingletonClass<UnitRingPool>.get_Instance
	|-SingletonClass<Versus>.get_Instance
	|-SingletonClass<VersusUserGlobalData>.get_Instance
	|-SingletonClass<DishSelectMenu.DishSelectMenuManager>.get_Instance
	|-SingletonClass<FoodstuffMenu.FoodstuffSelectMenuManager>.get_Instance
	|-SingletonClass<MapHistory.EffectNameMap>.get_Instance
	|-SingletonClass<MapHistory.GidMap>.get_Instance
	|-SingletonClass<MapHistory.IidMap>.get_Instance
	|-SingletonClass<MapHistory.JidMap>.get_Instance
	|-SingletonClass<MapHistory.MaterialStringMap>.get_Instance
	|-SingletonClass<MapHistory.PidMap>.get_Instance
	|-SingletonClass<MapHistory.ReplayAppearanceMap>.get_Instance
	|-SingletonClass<MapHistory.ReplayUnitMap>.get_Instance
	|-SingletonClass<MapHistory.RewindNameMap>.get_Instance
	|-SingletonClass<MapHistory.RewindRelianceMap>.get_Instance
	|-SingletonClass<MapHistory.RewindUnitMap>.get_Instance
	|-SingletonClass<MapHistory.RnidMap>.get_Instance
	|-SingletonClass<MapHistory.SidMap>.get_Instance
	|-SingletonClass<MapHistory.TidMap>.get_Instance
	|-SingletonClass<MapHistory.VariableMap>.get_Instance
	|-SingletonClass<Nex.DispatchKeepAlive>.get_Instance
	|-SingletonClass<Nex.SystemImpl>.get_Instance
	|-SingletonClass<SaveData.Manager>.get_Instance
	|-SingletonClass<MapHistory.Replay.TurnSave>.get_Instance
	|-SingletonClass<Nex.DataStore.Impl>.get_Instance
	|-SingletonClass<Nex.GameServer.Impl>.get_Instance
	|-SingletonClass<Nex.Screening.Impl>.get_Instance
	|-SingletonClass<Nex.Utility.Impl>.get_Instance
	*/

	[CompilerGeneratedAttribute] // RVA: 0x2AE7A0 Offset: 0x2AE8A1 VA: 0x2AE7A0
	// RVA: -1 Offset: -1
	protected void set_IsResume(bool value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3437E00 Offset: 0x3437F01 VA: 0x3437E00
	|-SingletonClass<object>.set_IsResume
	*/

	[CompilerGeneratedAttribute] // RVA: 0x2AE7B0 Offset: 0x2AE8B1 VA: 0x2AE7B0
	// RVA: -1 Offset: -1
	protected bool get_IsResume() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3437E10 Offset: 0x3437F11 VA: 0x3437E10
	|-SingletonClass<object>.get_IsResume
	*/

	// RVA: -1 Offset: -1 Slot: 4
	protected virtual int get_Version() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3437E20 Offset: 0x3437F21 VA: 0x3437E20
	|-SingletonClass<AI>.get_Version
	|-SingletonClass<AIDeploy>.get_Version
	|-SingletonClass<AmiiboManager>.get_Version
	|-SingletonClass<BattleDebugManager>.get_Version
	|-SingletonClass<DebugProfile>.get_Version
	|-SingletonClass<DebugUIRebuildChecker>.get_Version
	|-SingletonClass<DragonRideEffectManager>.get_Version
	|-SingletonClass<DragonRideShotManager>.get_Version
	|-SingletonClass<DragonRideTargetManager>.get_Version
	|-SingletonClass<EncountDataManager>.get_Version
	|-SingletonClass<FoodstuffPool>.get_Version
	|-SingletonClass<GameSkip>.get_Version
	|-SingletonClass<GmapMenuManager>.get_Version
	|-SingletonClass<GmapPlayerUnit>.get_Version
	|-SingletonClass<GmapSpotManager>.get_Version
	|-SingletonClass<HubResource>.get_Version
	|-SingletonClass<KeyHelp>.get_Version
	|-SingletonClass<MapBattleInfoWindow>.get_Version
	|-SingletonClass<MapBinder>.get_Version
	|-SingletonClass<MapDeploy>.get_Version
	|-SingletonClass<MapDnagerDeploy>.get_Version
	|-SingletonClass<MapEditHistory>.get_Version
	|-SingletonClass<MapGodExp>.get_Version
	|-SingletonClass<MapHeight>.get_Version
	|-SingletonClass<MapMind>.get_Version
	|-SingletonClass<MapRoute>.get_Version
	|-SingletonClass<MapSimpleBattle>.get_Version
	|-SingletonClass<MapTarget>.get_Version
	|-SingletonClass<MapTerrainInfo>.get_Version
	|-SingletonClass<NexProfile>.get_Version
	|-SingletonClass<NexRanking>.get_Version
	|-SingletonClass<NexRelay>.get_Version
	|-SingletonClass<NexVersus>.get_Version
	|-SingletonClass<object>.get_Version
	|-SingletonClass<Pad>.get_Version
	|-SingletonClass<QualitySettingsStack>.get_Version
	|-SingletonClass<Ranking>.get_Version
	|-SingletonClass<Relay>.get_Version
	|-SingletonClass<SortieClassChangeManager>.get_Version
	|-SingletonClass<SortieInventoryManager>.get_Version
	|-SingletonClass<SortieRelianceManager>.get_Version
	|-SingletonClass<SortieSelectionUnitManager>.get_Version
	|-SingletonClass<SortieSkillEditManager>.get_Version
	|-SingletonClass<SortieTopMenuManager>.get_Version
	|-SingletonClass<SortieTradeManager>.get_Version
	|-SingletonClass<UnitInfoParamManager>.get_Version
	|-SingletonClass<Versus>.get_Version
	|-SingletonClass<DishSelectMenu.DishSelectMenuManager>.get_Version
	|-SingletonClass<FoodstuffMenu.FoodstuffSelectMenuManager>.get_Version
	|-SingletonClass<MapHistory.ReplayUnitMap>.get_Version
	|-SingletonClass<Nex.DispatchKeepAlive>.get_Version
	|-SingletonClass<Nex.SystemImpl>.get_Version
	|-SingletonClass<SaveData.Manager>.get_Version
	|-SingletonClass<Nex.DataStore.Impl>.get_Version
	|-SingletonClass<Nex.GameServer.Impl>.get_Version
	|-SingletonClass<Nex.Screening.Impl>.get_Version
	|-SingletonClass<Nex.Utility.Impl>.get_Version
	*/

	// RVA: -1 Offset: -1
	public static T CreateInstance() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3437E30 Offset: 0x3437F31 VA: 0x3437E30
	|-SingletonClass<AI>.CreateInstance
	|-SingletonClass<AIDeploy>.CreateInstance
	|-SingletonClass<AmiiboManager>.CreateInstance
	|-SingletonClass<DragonRideEffectManager>.CreateInstance
	|-SingletonClass<DragonRideShotManager>.CreateInstance
	|-SingletonClass<DragonRideTargetManager>.CreateInstance
	|-SingletonClass<EncountDataManager>.CreateInstance
	|-SingletonClass<GameConfig>.CreateInstance
	|-SingletonClass<GameSkip>.CreateInstance
	|-SingletonClass<GameUserData>.CreateInstance
	|-SingletonClass<GameUserGlobalData>.CreateInstance
	|-SingletonClass<GameUserRestartData>.CreateInstance
	|-SingletonClass<GmapMenuManager>.CreateInstance
	|-SingletonClass<GmapPlayerUnit>.CreateInstance
	|-SingletonClass<GmapSpotManager>.CreateInstance
	|-SingletonClass<GodBondHolderPool>.CreateInstance
	|-SingletonClass<GodPool>.CreateInstance
	|-SingletonClass<HubResource>.CreateInstance
	|-SingletonClass<KeyHelp>.CreateInstance
	|-SingletonClass<MapBattleInfoWindow>.CreateInstance
	|-SingletonClass<MapBinder>.CreateInstance
	|-SingletonClass<MapCamera>.CreateInstance
	|-SingletonClass<MapCursor>.CreateInstance
	|-SingletonClass<MapDeploy>.CreateInstance
	|-SingletonClass<MapEditHistory>.CreateInstance
	|-SingletonClass<MapEffect>.CreateInstance
	|-SingletonClass<MapGodExp>.CreateInstance
	|-SingletonClass<MapHeight>.CreateInstance
	|-SingletonClass<MapImage>.CreateInstance
	|-SingletonClass<MapInspectors>.CreateInstance
	|-SingletonClass<MapKillBonus>.CreateInstance
	|-SingletonClass<MapLayer>.CreateInstance
	|-SingletonClass<MapMind>.CreateInstance
	|-SingletonClass<MapOverlap>.CreateInstance
	|-SingletonClass<MapRanking>.CreateInstance
	|-SingletonClass<MapRoute>.CreateInstance
	|-SingletonClass<MapSight>.CreateInstance
	|-SingletonClass<MapSimpleBattle>.CreateInstance
	|-SingletonClass<MapSituation>.CreateInstance
	|-SingletonClass<MapSortiePosition>.CreateInstance
	|-SingletonClass<MapTarget>.CreateInstance
	|-SingletonClass<MapTerrainInfo>.CreateInstance
	|-SingletonClass<NexKillBonus>.CreateInstance
	|-SingletonClass<NexProfile>.CreateInstance
	|-SingletonClass<NexRanking>.CreateInstance
	|-SingletonClass<NexRelay>.CreateInstance
	|-SingletonClass<NexVersus>.CreateInstance
	|-SingletonClass<object>.CreateInstance
	|-SingletonClass<Pad>.CreateInstance
	|-SingletonClass<ProfileCardFlags>.CreateInstance
	|-SingletonClass<ProfileCardListData>.CreateInstance
	|-SingletonClass<ProfileCardMyData>.CreateInstance
	|-SingletonClass<QualitySettingsStack>.CreateInstance
	|-SingletonClass<Ranking>.CreateInstance
	|-SingletonClass<RelayUserGlobalData>.CreateInstance
	|-SingletonClass<SortieClassChangeManager>.CreateInstance
	|-SingletonClass<SortieInventoryManager>.CreateInstance
	|-SingletonClass<SortieRelianceManager>.CreateInstance
	|-SingletonClass<SortieSelectionUnitManager>.CreateInstance
	|-SingletonClass<SortieSkillEditManager>.CreateInstance
	|-SingletonClass<SortieTopMenuManager>.CreateInstance
	|-SingletonClass<SortieTradeManager>.CreateInstance
	|-SingletonClass<UnitInfoParamManager>.CreateInstance
	|-SingletonClass<UnitRingPool>.CreateInstance
	|-SingletonClass<VersusUserGlobalData>.CreateInstance
	|-SingletonClass<FoodstuffMenu.FoodstuffSelectMenuManager>.CreateInstance
	|-SingletonClass<SaveData.Manager>.CreateInstance
	*/

	// RVA: -1 Offset: -1
	public static void DeleteInstance() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3438240 Offset: 0x3438341 VA: 0x3438240
	|-SingletonClass<AI>.DeleteInstance
	|-SingletonClass<AmiiboManager>.DeleteInstance
	|-SingletonClass<DragonRideEffectManager>.DeleteInstance
	|-SingletonClass<DragonRideShotManager>.DeleteInstance
	|-SingletonClass<DragonRideTargetManager>.DeleteInstance
	|-SingletonClass<EncountDataManager>.DeleteInstance
	|-SingletonClass<GmapMenuManager>.DeleteInstance
	|-SingletonClass<GmapPlayerUnit>.DeleteInstance
	|-SingletonClass<HubResource>.DeleteInstance
	|-SingletonClass<KeyHelp>.DeleteInstance
	|-SingletonClass<MapCamera>.DeleteInstance
	|-SingletonClass<MapCursor>.DeleteInstance
	|-SingletonClass<MapEditHistory>.DeleteInstance
	|-SingletonClass<MapEffect>.DeleteInstance
	|-SingletonClass<MapImage>.DeleteInstance
	|-SingletonClass<MapInspectors>.DeleteInstance
	|-SingletonClass<MapKillBonus>.DeleteInstance
	|-SingletonClass<MapRanking>.DeleteInstance
	|-SingletonClass<MapSight>.DeleteInstance
	|-SingletonClass<MapSituation>.DeleteInstance
	|-SingletonClass<MapSortiePosition>.DeleteInstance
	|-SingletonClass<NexKillBonus>.DeleteInstance
	|-SingletonClass<NexProfile>.DeleteInstance
	|-SingletonClass<NexRanking>.DeleteInstance
	|-SingletonClass<NexRelay>.DeleteInstance
	|-SingletonClass<NexVersus>.DeleteInstance
	|-SingletonClass<object>.DeleteInstance
	|-SingletonClass<Ranking>.DeleteInstance
	|-SingletonClass<SortieClassChangeManager>.DeleteInstance
	|-SingletonClass<SortieInventoryManager>.DeleteInstance
	|-SingletonClass<SortieRelianceManager>.DeleteInstance
	|-SingletonClass<SortieSelectionUnitManager>.DeleteInstance
	|-SingletonClass<SortieSkillEditManager>.DeleteInstance
	|-SingletonClass<SortieTopMenuManager>.DeleteInstance
	|-SingletonClass<SortieTradeManager>.DeleteInstance
	|-SingletonClass<Versus>.DeleteInstance
	|-SingletonClass<SaveData.Manager>.DeleteInstance
	*/

	// RVA: -1 Offset: -1
	public static bool TryCreateInstance() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34384F0 Offset: 0x34385F1 VA: 0x34384F0
	|-SingletonClass<MapInspectors>.TryCreateInstance
	|-SingletonClass<NexProfile>.TryCreateInstance
	|-SingletonClass<object>.TryCreateInstance
	|-SingletonClass<Relay>.TryCreateInstance
	|-SingletonClass<Versus>.TryCreateInstance
	|-SingletonClass<DishSelectMenu.DishSelectMenuManager>.TryCreateInstance
	|-SingletonClass<MapHistory.EffectNameMap>.TryCreateInstance
	|-SingletonClass<MapHistory.GidMap>.TryCreateInstance
	|-SingletonClass<MapHistory.IidMap>.TryCreateInstance
	|-SingletonClass<MapHistory.JidMap>.TryCreateInstance
	|-SingletonClass<MapHistory.MaterialStringMap>.TryCreateInstance
	|-SingletonClass<MapHistory.PidMap>.TryCreateInstance
	|-SingletonClass<MapHistory.ReplayAppearanceMap>.TryCreateInstance
	|-SingletonClass<MapHistory.ReplayUnitMap>.TryCreateInstance
	|-SingletonClass<MapHistory.RewindNameMap>.TryCreateInstance
	|-SingletonClass<MapHistory.RewindRelianceMap>.TryCreateInstance
	|-SingletonClass<MapHistory.RewindUnitMap>.TryCreateInstance
	|-SingletonClass<MapHistory.RnidMap>.TryCreateInstance
	|-SingletonClass<MapHistory.SidMap>.TryCreateInstance
	|-SingletonClass<MapHistory.TidMap>.TryCreateInstance
	|-SingletonClass<MapHistory.VariableMap>.TryCreateInstance
	|-SingletonClass<Nex.DispatchKeepAlive>.TryCreateInstance
	|-SingletonClass<Nex.SystemImpl>.TryCreateInstance
	|-SingletonClass<MapHistory.Replay.TurnSave>.TryCreateInstance
	|-SingletonClass<Nex.DataStore.Impl>.TryCreateInstance
	|-SingletonClass<Nex.GameServer.Impl>.TryCreateInstance
	|-SingletonClass<Nex.Screening.Impl>.TryCreateInstance
	|-SingletonClass<Nex.Utility.Impl>.TryCreateInstance
	*/

	// RVA: -1 Offset: -1
	public static bool TryDeleteInstance() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34387A0 Offset: 0x34388A1 VA: 0x34387A0
	|-SingletonClass<AIDeploy>.TryDeleteInstance
	|-SingletonClass<MapBattleInfoWindow>.TryDeleteInstance
	|-SingletonClass<MapBinder>.TryDeleteInstance
	|-SingletonClass<MapDeploy>.TryDeleteInstance
	|-SingletonClass<MapGodExp>.TryDeleteInstance
	|-SingletonClass<MapHeight>.TryDeleteInstance
	|-SingletonClass<MapInspectors>.TryDeleteInstance
	|-SingletonClass<MapLayer>.TryDeleteInstance
	|-SingletonClass<MapMind>.TryDeleteInstance
	|-SingletonClass<MapOverlap>.TryDeleteInstance
	|-SingletonClass<MapRoute>.TryDeleteInstance
	|-SingletonClass<MapSimpleBattle>.TryDeleteInstance
	|-SingletonClass<MapTarget>.TryDeleteInstance
	|-SingletonClass<MapTerrainInfo>.TryDeleteInstance
	|-SingletonClass<NexProfile>.TryDeleteInstance
	|-SingletonClass<object>.TryDeleteInstance
	|-SingletonClass<Relay>.TryDeleteInstance
	|-SingletonClass<DishSelectMenu.DishSelectMenuManager>.TryDeleteInstance
	|-SingletonClass<FoodstuffMenu.FoodstuffSelectMenuManager>.TryDeleteInstance
	|-SingletonClass<MapHistory.EffectNameMap>.TryDeleteInstance
	|-SingletonClass<MapHistory.GidMap>.TryDeleteInstance
	|-SingletonClass<MapHistory.IidMap>.TryDeleteInstance
	|-SingletonClass<MapHistory.JidMap>.TryDeleteInstance
	|-SingletonClass<MapHistory.MaterialStringMap>.TryDeleteInstance
	|-SingletonClass<MapHistory.PidMap>.TryDeleteInstance
	|-SingletonClass<MapHistory.ReplayAppearanceMap>.TryDeleteInstance
	|-SingletonClass<MapHistory.ReplayUnitMap>.TryDeleteInstance
	|-SingletonClass<MapHistory.RewindNameMap>.TryDeleteInstance
	|-SingletonClass<MapHistory.RewindRelianceMap>.TryDeleteInstance
	|-SingletonClass<MapHistory.RewindUnitMap>.TryDeleteInstance
	|-SingletonClass<MapHistory.RnidMap>.TryDeleteInstance
	|-SingletonClass<MapHistory.SidMap>.TryDeleteInstance
	|-SingletonClass<MapHistory.TidMap>.TryDeleteInstance
	|-SingletonClass<MapHistory.VariableMap>.TryDeleteInstance
	|-SingletonClass<Nex.DispatchKeepAlive>.TryDeleteInstance
	|-SingletonClass<Nex.SystemImpl>.TryDeleteInstance
	|-SingletonClass<MapHistory.Replay.TurnSave>.TryDeleteInstance
	|-SingletonClass<Nex.DataStore.Impl>.TryDeleteInstance
	|-SingletonClass<Nex.GameServer.Impl>.TryDeleteInstance
	|-SingletonClass<Nex.Screening.Impl>.TryDeleteInstance
	|-SingletonClass<Nex.Utility.Impl>.TryDeleteInstance
	*/

	// RVA: -1 Offset: -1
	public static void Tick() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3438A40 Offset: 0x3438B41 VA: 0x3438A40
	|-SingletonClass<GameSkip>.Tick
	|-SingletonClass<GmapPlayerUnit>.Tick
	|-SingletonClass<object>.Tick
	*/

	// RVA: -1 Offset: -1
	public static void Update() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3438CF0 Offset: 0x3438DF1 VA: 0x3438CF0
	|-SingletonClass<MapCamera>.Update
	|-SingletonClass<MapCursor>.Update
	|-SingletonClass<MapEffect>.Update
	|-SingletonClass<MapHeight>.Update
	|-SingletonClass<object>.Update
	|-SingletonClass<Pad>.Update
	*/

	// RVA: -1 Offset: -1
	public static void Bind() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3438FA0 Offset: 0x34390A1 VA: 0x3438FA0
	|-SingletonClass<MapBinder>.Bind
	|-SingletonClass<MapCamera>.Bind
	|-SingletonClass<MapCursor>.Bind
	|-SingletonClass<object>.Bind
	*/

	// RVA: -1 Offset: -1
	public static void Unbind() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3439380 Offset: 0x3439481 VA: 0x3439380
	|-SingletonClass<MapBinder>.Unbind
	|-SingletonClass<MapCamera>.Unbind
	|-SingletonClass<MapCursor>.Unbind
	|-SingletonClass<object>.Unbind
	*/

	// RVA: -1 Offset: -1
	public static bool IsBind() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3439760 Offset: 0x3439861 VA: 0x3439760
	|-SingletonClass<MapBinder>.IsBind
	|-SingletonClass<MapCamera>.IsBind
	|-SingletonClass<MapCursor>.IsBind
	|-SingletonClass<object>.IsBind
	*/

	// RVA: -1 Offset: -1
	public static int GetBindCount() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3439A10 Offset: 0x3439B11 VA: 0x3439A10
	|-SingletonClass<object>.GetBindCount
	*/

	// RVA: -1 Offset: -1
	public static void Serialize(Stream stream) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3439CC0 Offset: 0x3439DC1 VA: 0x3439CC0
	|-SingletonClass<GameConfig>.Serialize
	|-SingletonClass<GameUserData>.Serialize
	|-SingletonClass<GameUserGlobalData>.Serialize
	|-SingletonClass<GameUserRestartData>.Serialize
	|-SingletonClass<GodBondHolderPool>.Serialize
	|-SingletonClass<GodPool>.Serialize
	|-SingletonClass<MapCamera>.Serialize
	|-SingletonClass<MapCursor>.Serialize
	|-SingletonClass<MapEffect>.Serialize
	|-SingletonClass<MapImage>.Serialize
	|-SingletonClass<MapInspectors>.Serialize
	|-SingletonClass<MapKillBonus>.Serialize
	|-SingletonClass<MapLayer>.Serialize
	|-SingletonClass<MapOverlap>.Serialize
	|-SingletonClass<MapRanking>.Serialize
	|-SingletonClass<MapSight>.Serialize
	|-SingletonClass<MapSituation>.Serialize
	|-SingletonClass<MapSortiePosition>.Serialize
	|-SingletonClass<object>.Serialize
	|-SingletonClass<ProfileCardFlags>.Serialize
	|-SingletonClass<ProfileCardListData>.Serialize
	|-SingletonClass<ProfileCardMyData>.Serialize
	|-SingletonClass<RelayUserGlobalData>.Serialize
	|-SingletonClass<UnitRingPool>.Serialize
	|-SingletonClass<VersusUserGlobalData>.Serialize
	|-SingletonClass<MapHistory.EffectNameMap>.Serialize
	|-SingletonClass<MapHistory.GidMap>.Serialize
	|-SingletonClass<MapHistory.IidMap>.Serialize
	|-SingletonClass<MapHistory.JidMap>.Serialize
	|-SingletonClass<MapHistory.MaterialStringMap>.Serialize
	|-SingletonClass<MapHistory.PidMap>.Serialize
	|-SingletonClass<MapHistory.ReplayAppearanceMap>.Serialize
	|-SingletonClass<MapHistory.RewindNameMap>.Serialize
	|-SingletonClass<MapHistory.RewindRelianceMap>.Serialize
	|-SingletonClass<MapHistory.RewindUnitMap>.Serialize
	|-SingletonClass<MapHistory.RnidMap>.Serialize
	|-SingletonClass<MapHistory.SidMap>.Serialize
	|-SingletonClass<MapHistory.TidMap>.Serialize
	|-SingletonClass<MapHistory.VariableMap>.Serialize
	|-SingletonClass<MapHistory.Replay.TurnSave>.Serialize
	*/

	// RVA: -1 Offset: -1
	public static void Deserialize(Stream stream) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3439FE0 Offset: 0x343A0E1 VA: 0x3439FE0
	|-SingletonClass<GameConfig>.Deserialize
	|-SingletonClass<GameUserData>.Deserialize
	|-SingletonClass<GameUserGlobalData>.Deserialize
	|-SingletonClass<GameUserRestartData>.Deserialize
	|-SingletonClass<GodBondHolderPool>.Deserialize
	|-SingletonClass<GodPool>.Deserialize
	|-SingletonClass<MapCamera>.Deserialize
	|-SingletonClass<MapCursor>.Deserialize
	|-SingletonClass<MapEffect>.Deserialize
	|-SingletonClass<MapImage>.Deserialize
	|-SingletonClass<MapInspectors>.Deserialize
	|-SingletonClass<MapKillBonus>.Deserialize
	|-SingletonClass<MapLayer>.Deserialize
	|-SingletonClass<MapOverlap>.Deserialize
	|-SingletonClass<MapRanking>.Deserialize
	|-SingletonClass<MapSight>.Deserialize
	|-SingletonClass<MapSituation>.Deserialize
	|-SingletonClass<MapSortiePosition>.Deserialize
	|-SingletonClass<object>.Deserialize
	|-SingletonClass<ProfileCardFlags>.Deserialize
	|-SingletonClass<ProfileCardListData>.Deserialize
	|-SingletonClass<ProfileCardMyData>.Deserialize
	|-SingletonClass<RelayUserGlobalData>.Deserialize
	|-SingletonClass<UnitRingPool>.Deserialize
	|-SingletonClass<VersusUserGlobalData>.Deserialize
	|-SingletonClass<MapHistory.EffectNameMap>.Deserialize
	|-SingletonClass<MapHistory.GidMap>.Deserialize
	|-SingletonClass<MapHistory.IidMap>.Deserialize
	|-SingletonClass<MapHistory.JidMap>.Deserialize
	|-SingletonClass<MapHistory.MaterialStringMap>.Deserialize
	|-SingletonClass<MapHistory.PidMap>.Deserialize
	|-SingletonClass<MapHistory.ReplayAppearanceMap>.Deserialize
	|-SingletonClass<MapHistory.RewindNameMap>.Deserialize
	|-SingletonClass<MapHistory.RewindRelianceMap>.Deserialize
	|-SingletonClass<MapHistory.RewindUnitMap>.Deserialize
	|-SingletonClass<MapHistory.RnidMap>.Deserialize
	|-SingletonClass<MapHistory.SidMap>.Deserialize
	|-SingletonClass<MapHistory.TidMap>.Deserialize
	|-SingletonClass<MapHistory.VariableMap>.Deserialize
	|-SingletonClass<MapHistory.Replay.TurnSave>.Deserialize
	*/

	// RVA: -1 Offset: -1 Slot: 5
	protected virtual void OnCreate() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x343A360 Offset: 0x343A461 VA: 0x343A360
	|-SingletonClass<AI>.OnCreate
	|-SingletonClass<AIDeploy>.OnCreate
	|-SingletonClass<AmiiboManager>.OnCreate
	|-SingletonClass<BattleDebugManager>.OnCreate
	|-SingletonClass<DebugProfile>.OnCreate
	|-SingletonClass<DebugUIRebuildChecker>.OnCreate
	|-SingletonClass<DragonRideEffectManager>.OnCreate
	|-SingletonClass<DragonRideShotManager>.OnCreate
	|-SingletonClass<DragonRideTargetManager>.OnCreate
	|-SingletonClass<FoodstuffPool>.OnCreate
	|-SingletonClass<GameSkip>.OnCreate
	|-SingletonClass<GameUserData>.OnCreate
	|-SingletonClass<GameUserGlobalData>.OnCreate
	|-SingletonClass<GmapMenuManager>.OnCreate
	|-SingletonClass<GodBondHolderPool>.OnCreate
	|-SingletonClass<GodPool>.OnCreate
	|-SingletonClass<MapBinder>.OnCreate
	|-SingletonClass<MapCamera>.OnCreate
	|-SingletonClass<MapCursor>.OnCreate
	|-SingletonClass<MapDeploy>.OnCreate
	|-SingletonClass<MapDnagerDeploy>.OnCreate
	|-SingletonClass<MapGodExp>.OnCreate
	|-SingletonClass<MapHeight>.OnCreate
	|-SingletonClass<MapImage>.OnCreate
	|-SingletonClass<MapInspectors>.OnCreate
	|-SingletonClass<MapLayer>.OnCreate
	|-SingletonClass<MapMind>.OnCreate
	|-SingletonClass<MapOverlap>.OnCreate
	|-SingletonClass<MapRoute>.OnCreate
	|-SingletonClass<MapSight>.OnCreate
	|-SingletonClass<MapSituation>.OnCreate
	|-SingletonClass<MapSortiePosition>.OnCreate
	|-SingletonClass<MapTarget>.OnCreate
	|-SingletonClass<object>.OnCreate
	|-SingletonClass<Pad>.OnCreate
	|-SingletonClass<ProfileCardFlags>.OnCreate
	|-SingletonClass<ProfileCardListData>.OnCreate
	|-SingletonClass<ProfileCardMyData>.OnCreate
	|-SingletonClass<QualitySettingsStack>.OnCreate
	|-SingletonClass<RelayUserGlobalData>.OnCreate
	|-SingletonClass<SortieClassChangeManager>.OnCreate
	|-SingletonClass<SortieInventoryManager>.OnCreate
	|-SingletonClass<SortieRelianceManager>.OnCreate
	|-SingletonClass<SortieSelectionUnitManager>.OnCreate
	|-SingletonClass<SortieSkillEditManager>.OnCreate
	|-SingletonClass<SortieTopMenuManager>.OnCreate
	|-SingletonClass<SortieTradeManager>.OnCreate
	|-SingletonClass<UnitInfoParamManager>.OnCreate
	|-SingletonClass<UnitRingPool>.OnCreate
	|-SingletonClass<VersusUserGlobalData>.OnCreate
	|-SingletonClass<MapHistory.EffectNameMap>.OnCreate
	|-SingletonClass<MapHistory.GidMap>.OnCreate
	|-SingletonClass<MapHistory.IidMap>.OnCreate
	|-SingletonClass<MapHistory.JidMap>.OnCreate
	|-SingletonClass<MapHistory.MaterialStringMap>.OnCreate
	|-SingletonClass<MapHistory.PidMap>.OnCreate
	|-SingletonClass<MapHistory.ReplayUnitMap>.OnCreate
	|-SingletonClass<MapHistory.RewindNameMap>.OnCreate
	|-SingletonClass<MapHistory.RewindRelianceMap>.OnCreate
	|-SingletonClass<MapHistory.RewindUnitMap>.OnCreate
	|-SingletonClass<MapHistory.RnidMap>.OnCreate
	|-SingletonClass<MapHistory.SidMap>.OnCreate
	|-SingletonClass<MapHistory.TidMap>.OnCreate
	|-SingletonClass<MapHistory.VariableMap>.OnCreate
	|-SingletonClass<Nex.DispatchKeepAlive>.OnCreate
	|-SingletonClass<SaveData.Manager>.OnCreate
	|-SingletonClass<Nex.DataStore.Impl>.OnCreate
	|-SingletonClass<Nex.GameServer.Impl>.OnCreate
	|-SingletonClass<Nex.Screening.Impl>.OnCreate
	|-SingletonClass<Nex.Utility.Impl>.OnCreate
	*/

	// RVA: -1 Offset: -1 Slot: 6
	protected virtual void OnDispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x343A370 Offset: 0x343A471 VA: 0x343A370
	|-SingletonClass<AI>.OnDispose
	|-SingletonClass<AIDeploy>.OnDispose
	|-SingletonClass<AmiiboManager>.OnDispose
	|-SingletonClass<BattleDebugManager>.OnDispose
	|-SingletonClass<DebugProfile>.OnDispose
	|-SingletonClass<DebugUIRebuildChecker>.OnDispose
	|-SingletonClass<DragonRideEffectManager>.OnDispose
	|-SingletonClass<DragonRideShotManager>.OnDispose
	|-SingletonClass<DragonRideTargetManager>.OnDispose
	|-SingletonClass<FoodstuffPool>.OnDispose
	|-SingletonClass<GameSkip>.OnDispose
	|-SingletonClass<GameUserData>.OnDispose
	|-SingletonClass<GameUserGlobalData>.OnDispose
	|-SingletonClass<GmapMenuManager>.OnDispose
	|-SingletonClass<GmapPlayerUnit>.OnDispose
	|-SingletonClass<GmapSpotManager>.OnDispose
	|-SingletonClass<GodBondHolderPool>.OnDispose
	|-SingletonClass<GodPool>.OnDispose
	|-SingletonClass<KeyHelp>.OnDispose
	|-SingletonClass<MapBinder>.OnDispose
	|-SingletonClass<MapCamera>.OnDispose
	|-SingletonClass<MapCursor>.OnDispose
	|-SingletonClass<MapDeploy>.OnDispose
	|-SingletonClass<MapDnagerDeploy>.OnDispose
	|-SingletonClass<MapGodExp>.OnDispose
	|-SingletonClass<MapHeight>.OnDispose
	|-SingletonClass<MapImage>.OnDispose
	|-SingletonClass<MapInspectors>.OnDispose
	|-SingletonClass<MapLayer>.OnDispose
	|-SingletonClass<MapMind>.OnDispose
	|-SingletonClass<MapOverlap>.OnDispose
	|-SingletonClass<MapRoute>.OnDispose
	|-SingletonClass<MapSight>.OnDispose
	|-SingletonClass<MapSituation>.OnDispose
	|-SingletonClass<MapSortiePosition>.OnDispose
	|-SingletonClass<MapTarget>.OnDispose
	|-SingletonClass<NexKillBonus>.OnDispose
	|-SingletonClass<NexRanking>.OnDispose
	|-SingletonClass<NexRelay>.OnDispose
	|-SingletonClass<object>.OnDispose
	|-SingletonClass<Pad>.OnDispose
	|-SingletonClass<ProfileCardFlags>.OnDispose
	|-SingletonClass<ProfileCardListData>.OnDispose
	|-SingletonClass<ProfileCardMyData>.OnDispose
	|-SingletonClass<QualitySettingsStack>.OnDispose
	|-SingletonClass<Relay>.OnDispose
	|-SingletonClass<RelayUserGlobalData>.OnDispose
	|-SingletonClass<SortieClassChangeManager>.OnDispose
	|-SingletonClass<SortieInventoryManager>.OnDispose
	|-SingletonClass<SortieRelianceManager>.OnDispose
	|-SingletonClass<SortieSelectionUnitManager>.OnDispose
	|-SingletonClass<SortieSkillEditManager>.OnDispose
	|-SingletonClass<SortieTopMenuManager>.OnDispose
	|-SingletonClass<SortieTradeManager>.OnDispose
	|-SingletonClass<UnitInfoParamManager>.OnDispose
	|-SingletonClass<UnitRingPool>.OnDispose
	|-SingletonClass<Versus>.OnDispose
	|-SingletonClass<VersusUserGlobalData>.OnDispose
	|-SingletonClass<DishSelectMenu.DishSelectMenuManager>.OnDispose
	|-SingletonClass<FoodstuffMenu.FoodstuffSelectMenuManager>.OnDispose
	|-SingletonClass<MapHistory.EffectNameMap>.OnDispose
	|-SingletonClass<MapHistory.GidMap>.OnDispose
	|-SingletonClass<MapHistory.IidMap>.OnDispose
	|-SingletonClass<MapHistory.JidMap>.OnDispose
	|-SingletonClass<MapHistory.MaterialStringMap>.OnDispose
	|-SingletonClass<MapHistory.PidMap>.OnDispose
	|-SingletonClass<MapHistory.ReplayAppearanceMap>.OnDispose
	|-SingletonClass<MapHistory.ReplayUnitMap>.OnDispose
	|-SingletonClass<MapHistory.RewindNameMap>.OnDispose
	|-SingletonClass<MapHistory.RewindRelianceMap>.OnDispose
	|-SingletonClass<MapHistory.RewindUnitMap>.OnDispose
	|-SingletonClass<MapHistory.RnidMap>.OnDispose
	|-SingletonClass<MapHistory.SidMap>.OnDispose
	|-SingletonClass<MapHistory.TidMap>.OnDispose
	|-SingletonClass<MapHistory.VariableMap>.OnDispose
	|-SingletonClass<SaveData.Manager>.OnDispose
	|-SingletonClass<MapHistory.Replay.TurnSave>.OnDispose
	|-SingletonClass<Nex.DataStore.Impl>.OnDispose
	|-SingletonClass<Nex.GameServer.Impl>.OnDispose
	|-SingletonClass<Nex.Screening.Impl>.OnDispose
	|-SingletonClass<Nex.Utility.Impl>.OnDispose
	*/

	// RVA: -1 Offset: -1 Slot: 7
	protected virtual void OnTick() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x343A380 Offset: 0x343A481 VA: 0x343A380
	|-SingletonClass<AI>.OnTick
	|-SingletonClass<AIDeploy>.OnTick
	|-SingletonClass<AmiiboManager>.OnTick
	|-SingletonClass<BattleDebugManager>.OnTick
	|-SingletonClass<DebugProfile>.OnTick
	|-SingletonClass<DebugUIRebuildChecker>.OnTick
	|-SingletonClass<DragonRideEffectManager>.OnTick
	|-SingletonClass<DragonRideShotManager>.OnTick
	|-SingletonClass<DragonRideTargetManager>.OnTick
	|-SingletonClass<EncountDataManager>.OnTick
	|-SingletonClass<FoodstuffPool>.OnTick
	|-SingletonClass<GameConfig>.OnTick
	|-SingletonClass<GameUserData>.OnTick
	|-SingletonClass<GameUserGlobalData>.OnTick
	|-SingletonClass<GameUserRestartData>.OnTick
	|-SingletonClass<GmapMenuManager>.OnTick
	|-SingletonClass<GmapPlayerUnit>.OnTick
	|-SingletonClass<GmapSpotManager>.OnTick
	|-SingletonClass<GodBondHolderPool>.OnTick
	|-SingletonClass<GodPool>.OnTick
	|-SingletonClass<HubResource>.OnTick
	|-SingletonClass<KeyHelp>.OnTick
	|-SingletonClass<MapBattleInfoWindow>.OnTick
	|-SingletonClass<MapBinder>.OnTick
	|-SingletonClass<MapDeploy>.OnTick
	|-SingletonClass<MapDnagerDeploy>.OnTick
	|-SingletonClass<MapEditHistory>.OnTick
	|-SingletonClass<MapEffect>.OnTick
	|-SingletonClass<MapGodExp>.OnTick
	|-SingletonClass<MapHeight>.OnTick
	|-SingletonClass<MapImage>.OnTick
	|-SingletonClass<MapInspectors>.OnTick
	|-SingletonClass<MapKillBonus>.OnTick
	|-SingletonClass<MapLayer>.OnTick
	|-SingletonClass<MapMind>.OnTick
	|-SingletonClass<MapOverlap>.OnTick
	|-SingletonClass<MapRanking>.OnTick
	|-SingletonClass<MapRoute>.OnTick
	|-SingletonClass<MapSight>.OnTick
	|-SingletonClass<MapSimpleBattle>.OnTick
	|-SingletonClass<MapSituation>.OnTick
	|-SingletonClass<MapSortiePosition>.OnTick
	|-SingletonClass<MapTarget>.OnTick
	|-SingletonClass<MapTerrainInfo>.OnTick
	|-SingletonClass<NexKillBonus>.OnTick
	|-SingletonClass<NexProfile>.OnTick
	|-SingletonClass<NexRanking>.OnTick
	|-SingletonClass<NexRelay>.OnTick
	|-SingletonClass<NexVersus>.OnTick
	|-SingletonClass<object>.OnTick
	|-SingletonClass<Pad>.OnTick
	|-SingletonClass<ProfileCardFlags>.OnTick
	|-SingletonClass<ProfileCardListData>.OnTick
	|-SingletonClass<ProfileCardMyData>.OnTick
	|-SingletonClass<QualitySettingsStack>.OnTick
	|-SingletonClass<Ranking>.OnTick
	|-SingletonClass<Relay>.OnTick
	|-SingletonClass<RelayUserGlobalData>.OnTick
	|-SingletonClass<SortieClassChangeManager>.OnTick
	|-SingletonClass<SortieInventoryManager>.OnTick
	|-SingletonClass<SortieRelianceManager>.OnTick
	|-SingletonClass<SortieSelectionUnitManager>.OnTick
	|-SingletonClass<SortieSkillEditManager>.OnTick
	|-SingletonClass<SortieTopMenuManager>.OnTick
	|-SingletonClass<SortieTradeManager>.OnTick
	|-SingletonClass<UnitInfoParamManager>.OnTick
	|-SingletonClass<UnitRingPool>.OnTick
	|-SingletonClass<Versus>.OnTick
	|-SingletonClass<VersusUserGlobalData>.OnTick
	|-SingletonClass<DishSelectMenu.DishSelectMenuManager>.OnTick
	|-SingletonClass<FoodstuffMenu.FoodstuffSelectMenuManager>.OnTick
	|-SingletonClass<MapHistory.EffectNameMap>.OnTick
	|-SingletonClass<MapHistory.GidMap>.OnTick
	|-SingletonClass<MapHistory.IidMap>.OnTick
	|-SingletonClass<MapHistory.JidMap>.OnTick
	|-SingletonClass<MapHistory.MaterialStringMap>.OnTick
	|-SingletonClass<MapHistory.PidMap>.OnTick
	|-SingletonClass<MapHistory.ReplayAppearanceMap>.OnTick
	|-SingletonClass<MapHistory.ReplayUnitMap>.OnTick
	|-SingletonClass<MapHistory.RewindNameMap>.OnTick
	|-SingletonClass<MapHistory.RewindRelianceMap>.OnTick
	|-SingletonClass<MapHistory.RewindUnitMap>.OnTick
	|-SingletonClass<MapHistory.RnidMap>.OnTick
	|-SingletonClass<MapHistory.SidMap>.OnTick
	|-SingletonClass<MapHistory.TidMap>.OnTick
	|-SingletonClass<MapHistory.VariableMap>.OnTick
	|-SingletonClass<Nex.DispatchKeepAlive>.OnTick
	|-SingletonClass<Nex.SystemImpl>.OnTick
	|-SingletonClass<SaveData.Manager>.OnTick
	|-SingletonClass<MapHistory.Replay.TurnSave>.OnTick
	|-SingletonClass<Nex.DataStore.Impl>.OnTick
	|-SingletonClass<Nex.GameServer.Impl>.OnTick
	|-SingletonClass<Nex.Screening.Impl>.OnTick
	|-SingletonClass<Nex.Utility.Impl>.OnTick
	*/

	// RVA: -1 Offset: -1 Slot: 8
	protected virtual void OnUpdate() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x343A390 Offset: 0x343A491 VA: 0x343A390
	|-SingletonClass<AI>.OnUpdate
	|-SingletonClass<AIDeploy>.OnUpdate
	|-SingletonClass<AmiiboManager>.OnUpdate
	|-SingletonClass<BattleDebugManager>.OnUpdate
	|-SingletonClass<DebugProfile>.OnUpdate
	|-SingletonClass<DebugUIRebuildChecker>.OnUpdate
	|-SingletonClass<DragonRideEffectManager>.OnUpdate
	|-SingletonClass<DragonRideShotManager>.OnUpdate
	|-SingletonClass<DragonRideTargetManager>.OnUpdate
	|-SingletonClass<EncountDataManager>.OnUpdate
	|-SingletonClass<FoodstuffPool>.OnUpdate
	|-SingletonClass<GameConfig>.OnUpdate
	|-SingletonClass<GameSkip>.OnUpdate
	|-SingletonClass<GameUserData>.OnUpdate
	|-SingletonClass<GameUserGlobalData>.OnUpdate
	|-SingletonClass<GameUserRestartData>.OnUpdate
	|-SingletonClass<GmapMenuManager>.OnUpdate
	|-SingletonClass<GmapPlayerUnit>.OnUpdate
	|-SingletonClass<GmapSpotManager>.OnUpdate
	|-SingletonClass<GodBondHolderPool>.OnUpdate
	|-SingletonClass<GodPool>.OnUpdate
	|-SingletonClass<HubResource>.OnUpdate
	|-SingletonClass<KeyHelp>.OnUpdate
	|-SingletonClass<MapBattleInfoWindow>.OnUpdate
	|-SingletonClass<MapBinder>.OnUpdate
	|-SingletonClass<MapDeploy>.OnUpdate
	|-SingletonClass<MapDnagerDeploy>.OnUpdate
	|-SingletonClass<MapEditHistory>.OnUpdate
	|-SingletonClass<MapGodExp>.OnUpdate
	|-SingletonClass<MapImage>.OnUpdate
	|-SingletonClass<MapInspectors>.OnUpdate
	|-SingletonClass<MapKillBonus>.OnUpdate
	|-SingletonClass<MapLayer>.OnUpdate
	|-SingletonClass<MapMind>.OnUpdate
	|-SingletonClass<MapOverlap>.OnUpdate
	|-SingletonClass<MapRanking>.OnUpdate
	|-SingletonClass<MapRoute>.OnUpdate
	|-SingletonClass<MapSight>.OnUpdate
	|-SingletonClass<MapSimpleBattle>.OnUpdate
	|-SingletonClass<MapSituation>.OnUpdate
	|-SingletonClass<MapSortiePosition>.OnUpdate
	|-SingletonClass<MapTarget>.OnUpdate
	|-SingletonClass<MapTerrainInfo>.OnUpdate
	|-SingletonClass<NexKillBonus>.OnUpdate
	|-SingletonClass<NexProfile>.OnUpdate
	|-SingletonClass<NexRanking>.OnUpdate
	|-SingletonClass<NexRelay>.OnUpdate
	|-SingletonClass<NexVersus>.OnUpdate
	|-SingletonClass<object>.OnUpdate
	|-SingletonClass<ProfileCardFlags>.OnUpdate
	|-SingletonClass<ProfileCardListData>.OnUpdate
	|-SingletonClass<ProfileCardMyData>.OnUpdate
	|-SingletonClass<QualitySettingsStack>.OnUpdate
	|-SingletonClass<Ranking>.OnUpdate
	|-SingletonClass<Relay>.OnUpdate
	|-SingletonClass<RelayUserGlobalData>.OnUpdate
	|-SingletonClass<SortieClassChangeManager>.OnUpdate
	|-SingletonClass<SortieInventoryManager>.OnUpdate
	|-SingletonClass<SortieRelianceManager>.OnUpdate
	|-SingletonClass<SortieSelectionUnitManager>.OnUpdate
	|-SingletonClass<SortieSkillEditManager>.OnUpdate
	|-SingletonClass<SortieTopMenuManager>.OnUpdate
	|-SingletonClass<SortieTradeManager>.OnUpdate
	|-SingletonClass<UnitInfoParamManager>.OnUpdate
	|-SingletonClass<UnitRingPool>.OnUpdate
	|-SingletonClass<Versus>.OnUpdate
	|-SingletonClass<VersusUserGlobalData>.OnUpdate
	|-SingletonClass<DishSelectMenu.DishSelectMenuManager>.OnUpdate
	|-SingletonClass<FoodstuffMenu.FoodstuffSelectMenuManager>.OnUpdate
	|-SingletonClass<MapHistory.EffectNameMap>.OnUpdate
	|-SingletonClass<MapHistory.GidMap>.OnUpdate
	|-SingletonClass<MapHistory.IidMap>.OnUpdate
	|-SingletonClass<MapHistory.JidMap>.OnUpdate
	|-SingletonClass<MapHistory.MaterialStringMap>.OnUpdate
	|-SingletonClass<MapHistory.PidMap>.OnUpdate
	|-SingletonClass<MapHistory.ReplayAppearanceMap>.OnUpdate
	|-SingletonClass<MapHistory.ReplayUnitMap>.OnUpdate
	|-SingletonClass<MapHistory.RewindNameMap>.OnUpdate
	|-SingletonClass<MapHistory.RewindRelianceMap>.OnUpdate
	|-SingletonClass<MapHistory.RewindUnitMap>.OnUpdate
	|-SingletonClass<MapHistory.RnidMap>.OnUpdate
	|-SingletonClass<MapHistory.SidMap>.OnUpdate
	|-SingletonClass<MapHistory.TidMap>.OnUpdate
	|-SingletonClass<MapHistory.VariableMap>.OnUpdate
	|-SingletonClass<Nex.DispatchKeepAlive>.OnUpdate
	|-SingletonClass<Nex.SystemImpl>.OnUpdate
	|-SingletonClass<SaveData.Manager>.OnUpdate
	|-SingletonClass<MapHistory.Replay.TurnSave>.OnUpdate
	|-SingletonClass<Nex.DataStore.Impl>.OnUpdate
	|-SingletonClass<Nex.GameServer.Impl>.OnUpdate
	|-SingletonClass<Nex.Screening.Impl>.OnUpdate
	|-SingletonClass<Nex.Utility.Impl>.OnUpdate
	*/

	// RVA: -1 Offset: -1 Slot: 9
	protected virtual void OnBind() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x343A3A0 Offset: 0x343A4A1 VA: 0x343A3A0
	|-SingletonClass<AI>.OnBind
	|-SingletonClass<AIDeploy>.OnBind
	|-SingletonClass<AmiiboManager>.OnBind
	|-SingletonClass<BattleDebugManager>.OnBind
	|-SingletonClass<DebugProfile>.OnBind
	|-SingletonClass<DebugUIRebuildChecker>.OnBind
	|-SingletonClass<DragonRideEffectManager>.OnBind
	|-SingletonClass<DragonRideShotManager>.OnBind
	|-SingletonClass<DragonRideTargetManager>.OnBind
	|-SingletonClass<EncountDataManager>.OnBind
	|-SingletonClass<FoodstuffPool>.OnBind
	|-SingletonClass<GameConfig>.OnBind
	|-SingletonClass<GameSkip>.OnBind
	|-SingletonClass<GameUserData>.OnBind
	|-SingletonClass<GameUserGlobalData>.OnBind
	|-SingletonClass<GameUserRestartData>.OnBind
	|-SingletonClass<GmapMenuManager>.OnBind
	|-SingletonClass<GmapPlayerUnit>.OnBind
	|-SingletonClass<GmapSpotManager>.OnBind
	|-SingletonClass<GodBondHolderPool>.OnBind
	|-SingletonClass<GodPool>.OnBind
	|-SingletonClass<HubResource>.OnBind
	|-SingletonClass<KeyHelp>.OnBind
	|-SingletonClass<MapBattleInfoWindow>.OnBind
	|-SingletonClass<MapCamera>.OnBind
	|-SingletonClass<MapDeploy>.OnBind
	|-SingletonClass<MapDnagerDeploy>.OnBind
	|-SingletonClass<MapEditHistory>.OnBind
	|-SingletonClass<MapEffect>.OnBind
	|-SingletonClass<MapGodExp>.OnBind
	|-SingletonClass<MapHeight>.OnBind
	|-SingletonClass<MapImage>.OnBind
	|-SingletonClass<MapInspectors>.OnBind
	|-SingletonClass<MapKillBonus>.OnBind
	|-SingletonClass<MapLayer>.OnBind
	|-SingletonClass<MapMind>.OnBind
	|-SingletonClass<MapOverlap>.OnBind
	|-SingletonClass<MapRanking>.OnBind
	|-SingletonClass<MapRoute>.OnBind
	|-SingletonClass<MapSight>.OnBind
	|-SingletonClass<MapSimpleBattle>.OnBind
	|-SingletonClass<MapSituation>.OnBind
	|-SingletonClass<MapSortiePosition>.OnBind
	|-SingletonClass<MapTarget>.OnBind
	|-SingletonClass<MapTerrainInfo>.OnBind
	|-SingletonClass<NexKillBonus>.OnBind
	|-SingletonClass<NexProfile>.OnBind
	|-SingletonClass<NexRanking>.OnBind
	|-SingletonClass<NexRelay>.OnBind
	|-SingletonClass<NexVersus>.OnBind
	|-SingletonClass<object>.OnBind
	|-SingletonClass<Pad>.OnBind
	|-SingletonClass<ProfileCardFlags>.OnBind
	|-SingletonClass<ProfileCardListData>.OnBind
	|-SingletonClass<ProfileCardMyData>.OnBind
	|-SingletonClass<QualitySettingsStack>.OnBind
	|-SingletonClass<Ranking>.OnBind
	|-SingletonClass<Relay>.OnBind
	|-SingletonClass<RelayUserGlobalData>.OnBind
	|-SingletonClass<SortieClassChangeManager>.OnBind
	|-SingletonClass<SortieInventoryManager>.OnBind
	|-SingletonClass<SortieRelianceManager>.OnBind
	|-SingletonClass<SortieSelectionUnitManager>.OnBind
	|-SingletonClass<SortieSkillEditManager>.OnBind
	|-SingletonClass<SortieTopMenuManager>.OnBind
	|-SingletonClass<SortieTradeManager>.OnBind
	|-SingletonClass<UnitInfoParamManager>.OnBind
	|-SingletonClass<UnitRingPool>.OnBind
	|-SingletonClass<Versus>.OnBind
	|-SingletonClass<VersusUserGlobalData>.OnBind
	|-SingletonClass<DishSelectMenu.DishSelectMenuManager>.OnBind
	|-SingletonClass<FoodstuffMenu.FoodstuffSelectMenuManager>.OnBind
	|-SingletonClass<MapHistory.EffectNameMap>.OnBind
	|-SingletonClass<MapHistory.GidMap>.OnBind
	|-SingletonClass<MapHistory.IidMap>.OnBind
	|-SingletonClass<MapHistory.JidMap>.OnBind
	|-SingletonClass<MapHistory.MaterialStringMap>.OnBind
	|-SingletonClass<MapHistory.PidMap>.OnBind
	|-SingletonClass<MapHistory.ReplayAppearanceMap>.OnBind
	|-SingletonClass<MapHistory.ReplayUnitMap>.OnBind
	|-SingletonClass<MapHistory.RewindNameMap>.OnBind
	|-SingletonClass<MapHistory.RewindRelianceMap>.OnBind
	|-SingletonClass<MapHistory.RewindUnitMap>.OnBind
	|-SingletonClass<MapHistory.RnidMap>.OnBind
	|-SingletonClass<MapHistory.SidMap>.OnBind
	|-SingletonClass<MapHistory.TidMap>.OnBind
	|-SingletonClass<MapHistory.VariableMap>.OnBind
	|-SingletonClass<Nex.DispatchKeepAlive>.OnBind
	|-SingletonClass<Nex.SystemImpl>.OnBind
	|-SingletonClass<SaveData.Manager>.OnBind
	|-SingletonClass<MapHistory.Replay.TurnSave>.OnBind
	|-SingletonClass<Nex.DataStore.Impl>.OnBind
	|-SingletonClass<Nex.GameServer.Impl>.OnBind
	|-SingletonClass<Nex.Screening.Impl>.OnBind
	|-SingletonClass<Nex.Utility.Impl>.OnBind
	*/

	// RVA: -1 Offset: -1 Slot: 10
	protected virtual void OnUnbind() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x343A3B0 Offset: 0x343A4B1 VA: 0x343A3B0
	|-SingletonClass<AI>.OnUnbind
	|-SingletonClass<AIDeploy>.OnUnbind
	|-SingletonClass<AmiiboManager>.OnUnbind
	|-SingletonClass<BattleDebugManager>.OnUnbind
	|-SingletonClass<DebugProfile>.OnUnbind
	|-SingletonClass<DebugUIRebuildChecker>.OnUnbind
	|-SingletonClass<DragonRideEffectManager>.OnUnbind
	|-SingletonClass<DragonRideShotManager>.OnUnbind
	|-SingletonClass<DragonRideTargetManager>.OnUnbind
	|-SingletonClass<EncountDataManager>.OnUnbind
	|-SingletonClass<FoodstuffPool>.OnUnbind
	|-SingletonClass<GameConfig>.OnUnbind
	|-SingletonClass<GameSkip>.OnUnbind
	|-SingletonClass<GameUserData>.OnUnbind
	|-SingletonClass<GameUserGlobalData>.OnUnbind
	|-SingletonClass<GameUserRestartData>.OnUnbind
	|-SingletonClass<GmapMenuManager>.OnUnbind
	|-SingletonClass<GmapPlayerUnit>.OnUnbind
	|-SingletonClass<GmapSpotManager>.OnUnbind
	|-SingletonClass<GodBondHolderPool>.OnUnbind
	|-SingletonClass<GodPool>.OnUnbind
	|-SingletonClass<HubResource>.OnUnbind
	|-SingletonClass<KeyHelp>.OnUnbind
	|-SingletonClass<MapBattleInfoWindow>.OnUnbind
	|-SingletonClass<MapCamera>.OnUnbind
	|-SingletonClass<MapDeploy>.OnUnbind
	|-SingletonClass<MapDnagerDeploy>.OnUnbind
	|-SingletonClass<MapEditHistory>.OnUnbind
	|-SingletonClass<MapEffect>.OnUnbind
	|-SingletonClass<MapGodExp>.OnUnbind
	|-SingletonClass<MapHeight>.OnUnbind
	|-SingletonClass<MapImage>.OnUnbind
	|-SingletonClass<MapInspectors>.OnUnbind
	|-SingletonClass<MapKillBonus>.OnUnbind
	|-SingletonClass<MapLayer>.OnUnbind
	|-SingletonClass<MapMind>.OnUnbind
	|-SingletonClass<MapOverlap>.OnUnbind
	|-SingletonClass<MapRanking>.OnUnbind
	|-SingletonClass<MapRoute>.OnUnbind
	|-SingletonClass<MapSight>.OnUnbind
	|-SingletonClass<MapSimpleBattle>.OnUnbind
	|-SingletonClass<MapSituation>.OnUnbind
	|-SingletonClass<MapSortiePosition>.OnUnbind
	|-SingletonClass<MapTarget>.OnUnbind
	|-SingletonClass<MapTerrainInfo>.OnUnbind
	|-SingletonClass<NexKillBonus>.OnUnbind
	|-SingletonClass<NexProfile>.OnUnbind
	|-SingletonClass<NexRanking>.OnUnbind
	|-SingletonClass<NexRelay>.OnUnbind
	|-SingletonClass<NexVersus>.OnUnbind
	|-SingletonClass<object>.OnUnbind
	|-SingletonClass<Pad>.OnUnbind
	|-SingletonClass<ProfileCardFlags>.OnUnbind
	|-SingletonClass<ProfileCardListData>.OnUnbind
	|-SingletonClass<ProfileCardMyData>.OnUnbind
	|-SingletonClass<QualitySettingsStack>.OnUnbind
	|-SingletonClass<Ranking>.OnUnbind
	|-SingletonClass<Relay>.OnUnbind
	|-SingletonClass<RelayUserGlobalData>.OnUnbind
	|-SingletonClass<SortieClassChangeManager>.OnUnbind
	|-SingletonClass<SortieInventoryManager>.OnUnbind
	|-SingletonClass<SortieRelianceManager>.OnUnbind
	|-SingletonClass<SortieSelectionUnitManager>.OnUnbind
	|-SingletonClass<SortieSkillEditManager>.OnUnbind
	|-SingletonClass<SortieTopMenuManager>.OnUnbind
	|-SingletonClass<SortieTradeManager>.OnUnbind
	|-SingletonClass<UnitInfoParamManager>.OnUnbind
	|-SingletonClass<UnitRingPool>.OnUnbind
	|-SingletonClass<Versus>.OnUnbind
	|-SingletonClass<VersusUserGlobalData>.OnUnbind
	|-SingletonClass<DishSelectMenu.DishSelectMenuManager>.OnUnbind
	|-SingletonClass<FoodstuffMenu.FoodstuffSelectMenuManager>.OnUnbind
	|-SingletonClass<MapHistory.EffectNameMap>.OnUnbind
	|-SingletonClass<MapHistory.GidMap>.OnUnbind
	|-SingletonClass<MapHistory.IidMap>.OnUnbind
	|-SingletonClass<MapHistory.JidMap>.OnUnbind
	|-SingletonClass<MapHistory.MaterialStringMap>.OnUnbind
	|-SingletonClass<MapHistory.PidMap>.OnUnbind
	|-SingletonClass<MapHistory.ReplayAppearanceMap>.OnUnbind
	|-SingletonClass<MapHistory.ReplayUnitMap>.OnUnbind
	|-SingletonClass<MapHistory.RewindNameMap>.OnUnbind
	|-SingletonClass<MapHistory.RewindRelianceMap>.OnUnbind
	|-SingletonClass<MapHistory.RewindUnitMap>.OnUnbind
	|-SingletonClass<MapHistory.RnidMap>.OnUnbind
	|-SingletonClass<MapHistory.SidMap>.OnUnbind
	|-SingletonClass<MapHistory.TidMap>.OnUnbind
	|-SingletonClass<MapHistory.VariableMap>.OnUnbind
	|-SingletonClass<Nex.DispatchKeepAlive>.OnUnbind
	|-SingletonClass<Nex.SystemImpl>.OnUnbind
	|-SingletonClass<SaveData.Manager>.OnUnbind
	|-SingletonClass<MapHistory.Replay.TurnSave>.OnUnbind
	|-SingletonClass<Nex.DataStore.Impl>.OnUnbind
	|-SingletonClass<Nex.GameServer.Impl>.OnUnbind
	|-SingletonClass<Nex.Screening.Impl>.OnUnbind
	|-SingletonClass<Nex.Utility.Impl>.OnUnbind
	*/

	// RVA: -1 Offset: -1 Slot: 11
	protected virtual void OnSerialize(Stream stream) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x343A3C0 Offset: 0x343A4C1 VA: 0x343A3C0
	|-SingletonClass<AI>.OnSerialize
	|-SingletonClass<AIDeploy>.OnSerialize
	|-SingletonClass<AmiiboManager>.OnSerialize
	|-SingletonClass<BattleDebugManager>.OnSerialize
	|-SingletonClass<DebugProfile>.OnSerialize
	|-SingletonClass<DebugUIRebuildChecker>.OnSerialize
	|-SingletonClass<DragonRideEffectManager>.OnSerialize
	|-SingletonClass<DragonRideShotManager>.OnSerialize
	|-SingletonClass<DragonRideTargetManager>.OnSerialize
	|-SingletonClass<EncountDataManager>.OnSerialize
	|-SingletonClass<FoodstuffPool>.OnSerialize
	|-SingletonClass<GameSkip>.OnSerialize
	|-SingletonClass<GmapMenuManager>.OnSerialize
	|-SingletonClass<GmapPlayerUnit>.OnSerialize
	|-SingletonClass<HubResource>.OnSerialize
	|-SingletonClass<KeyHelp>.OnSerialize
	|-SingletonClass<MapBattleInfoWindow>.OnSerialize
	|-SingletonClass<MapBinder>.OnSerialize
	|-SingletonClass<MapDeploy>.OnSerialize
	|-SingletonClass<MapDnagerDeploy>.OnSerialize
	|-SingletonClass<MapEditHistory>.OnSerialize
	|-SingletonClass<MapGodExp>.OnSerialize
	|-SingletonClass<MapHeight>.OnSerialize
	|-SingletonClass<MapMind>.OnSerialize
	|-SingletonClass<MapRoute>.OnSerialize
	|-SingletonClass<MapSimpleBattle>.OnSerialize
	|-SingletonClass<MapTarget>.OnSerialize
	|-SingletonClass<MapTerrainInfo>.OnSerialize
	|-SingletonClass<NexKillBonus>.OnSerialize
	|-SingletonClass<NexProfile>.OnSerialize
	|-SingletonClass<NexRanking>.OnSerialize
	|-SingletonClass<NexRelay>.OnSerialize
	|-SingletonClass<NexVersus>.OnSerialize
	|-SingletonClass<object>.OnSerialize
	|-SingletonClass<Pad>.OnSerialize
	|-SingletonClass<QualitySettingsStack>.OnSerialize
	|-SingletonClass<Ranking>.OnSerialize
	|-SingletonClass<Relay>.OnSerialize
	|-SingletonClass<SortieClassChangeManager>.OnSerialize
	|-SingletonClass<SortieInventoryManager>.OnSerialize
	|-SingletonClass<SortieRelianceManager>.OnSerialize
	|-SingletonClass<SortieSelectionUnitManager>.OnSerialize
	|-SingletonClass<SortieSkillEditManager>.OnSerialize
	|-SingletonClass<SortieTopMenuManager>.OnSerialize
	|-SingletonClass<SortieTradeManager>.OnSerialize
	|-SingletonClass<UnitInfoParamManager>.OnSerialize
	|-SingletonClass<Versus>.OnSerialize
	|-SingletonClass<DishSelectMenu.DishSelectMenuManager>.OnSerialize
	|-SingletonClass<FoodstuffMenu.FoodstuffSelectMenuManager>.OnSerialize
	|-SingletonClass<MapHistory.ReplayUnitMap>.OnSerialize
	|-SingletonClass<Nex.DispatchKeepAlive>.OnSerialize
	|-SingletonClass<Nex.SystemImpl>.OnSerialize
	|-SingletonClass<SaveData.Manager>.OnSerialize
	|-SingletonClass<Nex.DataStore.Impl>.OnSerialize
	|-SingletonClass<Nex.GameServer.Impl>.OnSerialize
	|-SingletonClass<Nex.Screening.Impl>.OnSerialize
	|-SingletonClass<Nex.Utility.Impl>.OnSerialize
	*/

	// RVA: -1 Offset: -1 Slot: 12
	protected virtual void OnDeserialize(Stream stream, int version) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x343A3D0 Offset: 0x343A4D1 VA: 0x343A3D0
	|-SingletonClass<AI>.OnDeserialize
	|-SingletonClass<AIDeploy>.OnDeserialize
	|-SingletonClass<AmiiboManager>.OnDeserialize
	|-SingletonClass<BattleDebugManager>.OnDeserialize
	|-SingletonClass<DebugProfile>.OnDeserialize
	|-SingletonClass<DebugUIRebuildChecker>.OnDeserialize
	|-SingletonClass<DragonRideEffectManager>.OnDeserialize
	|-SingletonClass<DragonRideShotManager>.OnDeserialize
	|-SingletonClass<DragonRideTargetManager>.OnDeserialize
	|-SingletonClass<EncountDataManager>.OnDeserialize
	|-SingletonClass<FoodstuffPool>.OnDeserialize
	|-SingletonClass<GameSkip>.OnDeserialize
	|-SingletonClass<GmapMenuManager>.OnDeserialize
	|-SingletonClass<GmapPlayerUnit>.OnDeserialize
	|-SingletonClass<HubResource>.OnDeserialize
	|-SingletonClass<KeyHelp>.OnDeserialize
	|-SingletonClass<MapBattleInfoWindow>.OnDeserialize
	|-SingletonClass<MapBinder>.OnDeserialize
	|-SingletonClass<MapDeploy>.OnDeserialize
	|-SingletonClass<MapDnagerDeploy>.OnDeserialize
	|-SingletonClass<MapEditHistory>.OnDeserialize
	|-SingletonClass<MapGodExp>.OnDeserialize
	|-SingletonClass<MapHeight>.OnDeserialize
	|-SingletonClass<MapMind>.OnDeserialize
	|-SingletonClass<MapRoute>.OnDeserialize
	|-SingletonClass<MapSimpleBattle>.OnDeserialize
	|-SingletonClass<MapTarget>.OnDeserialize
	|-SingletonClass<MapTerrainInfo>.OnDeserialize
	|-SingletonClass<NexKillBonus>.OnDeserialize
	|-SingletonClass<NexProfile>.OnDeserialize
	|-SingletonClass<NexRanking>.OnDeserialize
	|-SingletonClass<NexRelay>.OnDeserialize
	|-SingletonClass<NexVersus>.OnDeserialize
	|-SingletonClass<object>.OnDeserialize
	|-SingletonClass<Pad>.OnDeserialize
	|-SingletonClass<QualitySettingsStack>.OnDeserialize
	|-SingletonClass<Ranking>.OnDeserialize
	|-SingletonClass<Relay>.OnDeserialize
	|-SingletonClass<SortieClassChangeManager>.OnDeserialize
	|-SingletonClass<SortieInventoryManager>.OnDeserialize
	|-SingletonClass<SortieRelianceManager>.OnDeserialize
	|-SingletonClass<SortieSelectionUnitManager>.OnDeserialize
	|-SingletonClass<SortieSkillEditManager>.OnDeserialize
	|-SingletonClass<SortieTopMenuManager>.OnDeserialize
	|-SingletonClass<SortieTradeManager>.OnDeserialize
	|-SingletonClass<UnitInfoParamManager>.OnDeserialize
	|-SingletonClass<Versus>.OnDeserialize
	|-SingletonClass<DishSelectMenu.DishSelectMenuManager>.OnDeserialize
	|-SingletonClass<FoodstuffMenu.FoodstuffSelectMenuManager>.OnDeserialize
	|-SingletonClass<MapHistory.ReplayUnitMap>.OnDeserialize
	|-SingletonClass<Nex.DispatchKeepAlive>.OnDeserialize
	|-SingletonClass<Nex.SystemImpl>.OnDeserialize
	|-SingletonClass<SaveData.Manager>.OnDeserialize
	|-SingletonClass<Nex.DataStore.Impl>.OnDeserialize
	|-SingletonClass<Nex.GameServer.Impl>.OnDeserialize
	|-SingletonClass<Nex.Screening.Impl>.OnDeserialize
	|-SingletonClass<Nex.Utility.Impl>.OnDeserialize
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x343A3E0 Offset: 0x343A4E1 VA: 0x343A3E0
	|-SingletonClass<AI>..ctor
	|-SingletonClass<AmiiboManager>..ctor
	|-SingletonClass<BattleDebugManager>..ctor
	|-SingletonClass<DebugProfile>..ctor
	|-SingletonClass<DebugUIRebuildChecker>..ctor
	|-SingletonClass<DragonRideEffectManager>..ctor
	|-SingletonClass<DragonRideShotManager>..ctor
	|-SingletonClass<DragonRideTargetManager>..ctor
	|-SingletonClass<EncountDataManager>..ctor
	|-SingletonClass<FoodstuffPool>..ctor
	|-SingletonClass<GameConfig>..ctor
	|-SingletonClass<GameSkip>..ctor
	|-SingletonClass<GameUserData>..ctor
	|-SingletonClass<GameUserGlobalData>..ctor
	|-SingletonClass<GameUserRestartData>..ctor
	|-SingletonClass<GmapMenuManager>..ctor
	|-SingletonClass<GmapPlayerUnit>..ctor
	|-SingletonClass<GmapSpotManager>..ctor
	|-SingletonClass<HubResource>..ctor
	|-SingletonClass<KeyHelp>..ctor
	|-SingletonClass<MapBattleInfoWindow>..ctor
	|-SingletonClass<MapBinder>..ctor
	|-SingletonClass<MapCamera>..ctor
	|-SingletonClass<MapCursor>..ctor
	|-SingletonClass<MapEditHistory>..ctor
	|-SingletonClass<MapEffect>..ctor
	|-SingletonClass<MapGodExp>..ctor
	|-SingletonClass<MapHeight>..ctor
	|-SingletonClass<MapImage>..ctor
	|-SingletonClass<MapInspectors>..ctor
	|-SingletonClass<MapKillBonus>..ctor
	|-SingletonClass<MapLayer>..ctor
	|-SingletonClass<MapMind>..ctor
	|-SingletonClass<MapOverlap>..ctor
	|-SingletonClass<MapRanking>..ctor
	|-SingletonClass<MapRoute>..ctor
	|-SingletonClass<MapSight>..ctor
	|-SingletonClass<MapSimpleBattle>..ctor
	|-SingletonClass<MapSituation>..ctor
	|-SingletonClass<MapSortiePosition>..ctor
	|-SingletonClass<MapTarget>..ctor
	|-SingletonClass<MapTerrainInfo>..ctor
	|-SingletonClass<NexKillBonus>..ctor
	|-SingletonClass<NexProfile>..ctor
	|-SingletonClass<NexRanking>..ctor
	|-SingletonClass<NexRelay>..ctor
	|-SingletonClass<NexVersus>..ctor
	|-SingletonClass<object>..ctor
	|-SingletonClass<Pad>..ctor
	|-SingletonClass<ProfileCardFlags>..ctor
	|-SingletonClass<ProfileCardListData>..ctor
	|-SingletonClass<ProfileCardMyData>..ctor
	|-SingletonClass<QualitySettingsStack>..ctor
	|-SingletonClass<Ranking>..ctor
	|-SingletonClass<Relay>..ctor
	|-SingletonClass<RelayUserGlobalData>..ctor
	|-SingletonClass<SortieClassChangeManager>..ctor
	|-SingletonClass<SortieInventoryManager>..ctor
	|-SingletonClass<SortieRelianceManager>..ctor
	|-SingletonClass<SortieSelectionUnitManager>..ctor
	|-SingletonClass<SortieSkillEditManager>..ctor
	|-SingletonClass<SortieTopMenuManager>..ctor
	|-SingletonClass<SortieTradeManager>..ctor
	|-SingletonClass<UnitInfoParamManager>..ctor
	|-SingletonClass<Versus>..ctor
	|-SingletonClass<VersusUserGlobalData>..ctor
	|-SingletonClass<DishSelectMenu.DishSelectMenuManager>..ctor
	|-SingletonClass<FoodstuffMenu.FoodstuffSelectMenuManager>..ctor
	|-SingletonClass<MapHistory.ReplayAppearanceMap>..ctor
	|-SingletonClass<MapHistory.RewindRelianceMap>..ctor
	|-SingletonClass<Nex.DispatchKeepAlive>..ctor
	|-SingletonClass<Nex.SystemImpl>..ctor
	|-SingletonClass<SaveData.Manager>..ctor
	|-SingletonClass<MapHistory.Replay.TurnSave>..ctor
	|-SingletonClass<Nex.DataStore.Impl>..ctor
	|-SingletonClass<Nex.GameServer.Impl>..ctor
	|-SingletonClass<Nex.Screening.Impl>..ctor
	|-SingletonClass<Nex.Utility.Impl>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 1
	protected override void Finalize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x343A460 Offset: 0x343A561 VA: 0x343A460
	|-SingletonClass<AI>.Finalize
	|-SingletonClass<AIDeploy>.Finalize
	|-SingletonClass<AmiiboManager>.Finalize
	|-SingletonClass<BattleDebugManager>.Finalize
	|-SingletonClass<DebugProfile>.Finalize
	|-SingletonClass<DebugUIRebuildChecker>.Finalize
	|-SingletonClass<DragonRideEffectManager>.Finalize
	|-SingletonClass<DragonRideShotManager>.Finalize
	|-SingletonClass<DragonRideTargetManager>.Finalize
	|-SingletonClass<EncountDataManager>.Finalize
	|-SingletonClass<FoodstuffPool>.Finalize
	|-SingletonClass<GameConfig>.Finalize
	|-SingletonClass<GameSkip>.Finalize
	|-SingletonClass<GameUserData>.Finalize
	|-SingletonClass<GameUserGlobalData>.Finalize
	|-SingletonClass<GameUserRestartData>.Finalize
	|-SingletonClass<GmapMenuManager>.Finalize
	|-SingletonClass<GmapPlayerUnit>.Finalize
	|-SingletonClass<GmapSpotManager>.Finalize
	|-SingletonClass<GodBondHolderPool>.Finalize
	|-SingletonClass<GodPool>.Finalize
	|-SingletonClass<HubResource>.Finalize
	|-SingletonClass<KeyHelp>.Finalize
	|-SingletonClass<MapBattleInfoWindow>.Finalize
	|-SingletonClass<MapBinder>.Finalize
	|-SingletonClass<MapCamera>.Finalize
	|-SingletonClass<MapCursor>.Finalize
	|-SingletonClass<MapDeploy>.Finalize
	|-SingletonClass<MapDnagerDeploy>.Finalize
	|-SingletonClass<MapEditHistory>.Finalize
	|-SingletonClass<MapEffect>.Finalize
	|-SingletonClass<MapGodExp>.Finalize
	|-SingletonClass<MapHeight>.Finalize
	|-SingletonClass<MapImage>.Finalize
	|-SingletonClass<MapInspectors>.Finalize
	|-SingletonClass<MapKillBonus>.Finalize
	|-SingletonClass<MapLayer>.Finalize
	|-SingletonClass<MapMind>.Finalize
	|-SingletonClass<MapOverlap>.Finalize
	|-SingletonClass<MapRanking>.Finalize
	|-SingletonClass<MapRoute>.Finalize
	|-SingletonClass<MapSight>.Finalize
	|-SingletonClass<MapSimpleBattle>.Finalize
	|-SingletonClass<MapSituation>.Finalize
	|-SingletonClass<MapSortiePosition>.Finalize
	|-SingletonClass<MapTarget>.Finalize
	|-SingletonClass<MapTerrainInfo>.Finalize
	|-SingletonClass<NexKillBonus>.Finalize
	|-SingletonClass<NexProfile>.Finalize
	|-SingletonClass<NexRanking>.Finalize
	|-SingletonClass<NexRelay>.Finalize
	|-SingletonClass<NexVersus>.Finalize
	|-SingletonClass<object>.Finalize
	|-SingletonClass<Pad>.Finalize
	|-SingletonClass<ProfileCardFlags>.Finalize
	|-SingletonClass<ProfileCardListData>.Finalize
	|-SingletonClass<ProfileCardMyData>.Finalize
	|-SingletonClass<QualitySettingsStack>.Finalize
	|-SingletonClass<Ranking>.Finalize
	|-SingletonClass<Relay>.Finalize
	|-SingletonClass<RelayUserGlobalData>.Finalize
	|-SingletonClass<SortieClassChangeManager>.Finalize
	|-SingletonClass<SortieInventoryManager>.Finalize
	|-SingletonClass<SortieRelianceManager>.Finalize
	|-SingletonClass<SortieSelectionUnitManager>.Finalize
	|-SingletonClass<SortieSkillEditManager>.Finalize
	|-SingletonClass<SortieTopMenuManager>.Finalize
	|-SingletonClass<SortieTradeManager>.Finalize
	|-SingletonClass<UnitInfoParamManager>.Finalize
	|-SingletonClass<UnitRingPool>.Finalize
	|-SingletonClass<Versus>.Finalize
	|-SingletonClass<VersusUserGlobalData>.Finalize
	|-SingletonClass<DishSelectMenu.DishSelectMenuManager>.Finalize
	|-SingletonClass<FoodstuffMenu.FoodstuffSelectMenuManager>.Finalize
	|-SingletonClass<MapHistory.EffectNameMap>.Finalize
	|-SingletonClass<MapHistory.GidMap>.Finalize
	|-SingletonClass<MapHistory.IidMap>.Finalize
	|-SingletonClass<MapHistory.JidMap>.Finalize
	|-SingletonClass<MapHistory.MaterialStringMap>.Finalize
	|-SingletonClass<MapHistory.PidMap>.Finalize
	|-SingletonClass<MapHistory.ReplayAppearanceMap>.Finalize
	|-SingletonClass<MapHistory.ReplayUnitMap>.Finalize
	|-SingletonClass<MapHistory.RewindNameMap>.Finalize
	|-SingletonClass<MapHistory.RewindRelianceMap>.Finalize
	|-SingletonClass<MapHistory.RewindUnitMap>.Finalize
	|-SingletonClass<MapHistory.RnidMap>.Finalize
	|-SingletonClass<MapHistory.SidMap>.Finalize
	|-SingletonClass<MapHistory.TidMap>.Finalize
	|-SingletonClass<MapHistory.VariableMap>.Finalize
	|-SingletonClass<Nex.DispatchKeepAlive>.Finalize
	|-SingletonClass<Nex.SystemImpl>.Finalize
	|-SingletonClass<SaveData.Manager>.Finalize
	|-SingletonClass<MapHistory.Replay.TurnSave>.Finalize
	|-SingletonClass<Nex.DataStore.Impl>.Finalize
	|-SingletonClass<Nex.GameServer.Impl>.Finalize
	|-SingletonClass<Nex.Screening.Impl>.Finalize
	|-SingletonClass<Nex.Utility.Impl>.Finalize
	*/

	// RVA: -1 Offset: -1
	public static bool op_Implicit(SingletonClass<T> exists) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x343A470 Offset: 0x343A571 VA: 0x343A470
	|-SingletonClass<GameConfig>.op_Implicit
	|-SingletonClass<GameUserData>.op_Implicit
	|-SingletonClass<GodPool>.op_Implicit
	|-SingletonClass<MapImage>.op_Implicit
	|-SingletonClass<MapLayer>.op_Implicit
	|-SingletonClass<MapOverlap>.op_Implicit
	|-SingletonClass<MapSight>.op_Implicit
	|-SingletonClass<MapSituation>.op_Implicit
	|-SingletonClass<MapTerrainInfo>.op_Implicit
	|-SingletonClass<object>.op_Implicit
	|-SingletonClass<SortieSelectionUnitManager>.op_Implicit
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x343A480 Offset: 0x343A581 VA: 0x343A480
	|-SingletonClass<object>..cctor
	*/
}

