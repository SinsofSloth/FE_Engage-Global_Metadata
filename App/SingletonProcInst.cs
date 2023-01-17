// Namespace: App
public class SingletonProcInst<T> : ProcInst // TypeDefIndex: 9219
{
	// Fields
	private static T s_Instance; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x286D90 Offset: 0x286E91 VA: 0x286D90
	private bool <IsResume>k__BackingField; // 0x0
	private bool m_IsLoaded; // 0x0

	// Properties
	public static T Instance { get; }
	protected bool IsResume { get; set; }
	protected virtual int Version { get; }
	protected virtual string GlobalAssetPath { get; }

	// Methods

	// RVA: -1 Offset: -1
	public static T get_Instance() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x343F8E0 Offset: 0x343F9E1 VA: 0x343F8E0
	|-SingletonProcInst<AmiiboSequence>.get_Instance
	|-SingletonProcInst<AnimalCatchSequence>.get_Instance
	|-SingletonProcInst<AnimalMenuSequence>.get_Instance
	|-SingletonProcInst<AnimalSequence>.get_Instance
	|-SingletonProcInst<ArenaCombatSequence>.get_Instance
	|-SingletonProcInst<ArenaOrderSequence>.get_Instance
	|-SingletonProcInst<CombatSequence>.get_Instance
	|-SingletonProcInst<ConsoleManager>.get_Instance
	|-SingletonProcInst<DamageInfo>.get_Instance
	|-SingletonProcInst<EventDemoSequence>.get_Instance
	|-SingletonProcInst<GmapMenuSequence>.get_Instance
	|-SingletonProcInst<GmapSequence>.get_Instance
	|-SingletonProcInst<HelpProc>.get_Instance
	|-SingletonProcInst<HubAccessoryRoom>.get_Instance
	|-SingletonProcInst<HubMenuSequence>.get_Instance
	|-SingletonProcInst<HubPlayTalkAfter>.get_Instance
	|-SingletonProcInst<HubSequence>.get_Instance
	|-SingletonProcInst<InvestmentNationDataSequence>.get_Instance
	|-SingletonProcInst<JobIntroSequence>.get_Instance
	|-SingletonProcInst<JobIntroStatus>.get_Instance
	|-SingletonProcInst<LaterTalkSequence>.get_Instance
	|-SingletonProcInst<MainMenuSequence>.get_Instance
	|-SingletonProcInst<MainSequence>.get_Instance
	|-SingletonProcInst<MapKeyHelp>.get_Instance
	|-SingletonProcInst<MapMiniMap>.get_Instance
	|-SingletonProcInst<MapSequence>.get_Instance
	|-SingletonProcInst<MapSequenceAI>.get_Instance
	|-SingletonProcInst<MapSequenceAlternateConfirm>.get_Instance
	|-SingletonProcInst<MapSequenceBattle>.get_Instance
	|-SingletonProcInst<MapSequenceBattleAction>.get_Instance
	|-SingletonProcInst<MapSequenceEditor>.get_Instance
	|-SingletonProcInst<MapSequenceEngageConfirm>.get_Instance
	|-SingletonProcInst<MapSequenceHuman>.get_Instance
	|-SingletonProcInst<MapSequenceTargetSelect>.get_Instance
	|-SingletonProcInst<MascotMenuSequence>.get_Instance
	|-SingletonProcInst<MovieSequence>.get_Instance
	|-SingletonProcInst<MyRoomRelianceSequence>.get_Instance
	|-SingletonProcInst<MyRoomWakeupSelectSequence>.get_Instance
	|-SingletonProcInst<MyRoomWakeupSequence>.get_Instance
	|-SingletonProcInst<object>.get_Instance
	|-SingletonProcInst<PhotographTopSequence>.get_Instance
	|-SingletonProcInst<RankingSequence>.get_Instance
	|-SingletonProcInst<RewindSequence>.get_Instance
	|-SingletonProcInst<RingInfo>.get_Instance
	|-SingletonProcInst<RingListSequence>.get_Instance
	|-SingletonProcInst<SortieSequence>.get_Instance
	|-SingletonProcInst<SortieSequenceClassChange>.get_Instance
	|-SingletonProcInst<SortieSequenceInventory>.get_Instance
	|-SingletonProcInst<SortieSequenceReliance>.get_Instance
	|-SingletonProcInst<SortieSequenceRingSelect>.get_Instance
	|-SingletonProcInst<SortieSequenceSkillEdit>.get_Instance
	|-SingletonProcInst<SortieSequenceTrade>.get_Instance
	|-SingletonProcInst<SortieSequenceTroopList>.get_Instance
	|-SingletonProcInst<SortieSequenceUnitSelect>.get_Instance
	|-SingletonProcInst<TalkSequence>.get_Instance
	|-SingletonProcInst<TitleLoopSequence>.get_Instance
	|-SingletonProcInst<TutorialSequence>.get_Instance
	|-SingletonProcInst<UnitHasItemMaxSequence>.get_Instance
	|-SingletonProcInst<UnitInfo>.get_Instance
	|-SingletonProcInst<UnitInfoSequence>.get_Instance
	|-SingletonProcInst<HubSequence.LastChapterSequence>.get_Instance
	|-SingletonProcInst<Nex.AutoLogoutFinalize>.get_Instance
	|-SingletonProcInst<Nex.DispatchHigh>.get_Instance
	|-SingletonProcInst<Nex.DispatchLow>.get_Instance
	|-SingletonProcInst<RelaySequence.RelaySequenceLocal>.get_Instance
	|-SingletonProcInst<RelaySequence.RelaySequenceNet>.get_Instance
	|-SingletonProcInst<SoundWwise.SoundBankManager>.get_Instance
	|-SingletonProcInst<VersusSequence.VersusSequenceLocal>.get_Instance
	|-SingletonProcInst<VersusSequence.VersusSequenceNet>.get_Instance
	*/

	// RVA: -1 Offset: -1 Slot: 13
	protected sealed override void OnSingletonCreate() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x343FA10 Offset: 0x343FB11 VA: 0x343FA10
	|-SingletonProcInst<AchievementSequence>.OnSingletonCreate
	|-SingletonProcInst<AmiiboSequence>.OnSingletonCreate
	|-SingletonProcInst<AmiiboSoundSequence>.OnSingletonCreate
	|-SingletonProcInst<AmiiboTopSequence>.OnSingletonCreate
	|-SingletonProcInst<AnimalAccessSequence>.OnSingletonCreate
	|-SingletonProcInst<AnimalCatchSequence>.OnSingletonCreate
	|-SingletonProcInst<AnimalMenuSequence>.OnSingletonCreate
	|-SingletonProcInst<AnimalSequence>.OnSingletonCreate
	|-SingletonProcInst<ArenaCombatSequence>.OnSingletonCreate
	|-SingletonProcInst<ArenaOrderSequence>.OnSingletonCreate
	|-SingletonProcInst<BattleRecordSequence>.OnSingletonCreate
	|-SingletonProcInst<ClassChangeSequence>.OnSingletonCreate
	|-SingletonProcInst<CombatSequence>.OnSingletonCreate
	|-SingletonProcInst<ConfigBgmSelectSequence>.OnSingletonCreate
	|-SingletonProcInst<ConsoleManager>.OnSingletonCreate
	|-SingletonProcInst<DamageInfo>.OnSingletonCreate
	|-SingletonProcInst<EndRollSequence>.OnSingletonCreate
	|-SingletonProcInst<EventDemoSequence>.OnSingletonCreate
	|-SingletonProcInst<FortuneTellingResultSequence>.OnSingletonCreate
	|-SingletonProcInst<FriendListSequence>.OnSingletonCreate
	|-SingletonProcInst<GmapMenuSequence>.OnSingletonCreate
	|-SingletonProcInst<GmapSequence>.OnSingletonCreate
	|-SingletonProcInst<HelpProc>.OnSingletonCreate
	|-SingletonProcInst<HubAccessoryRoom>.OnSingletonCreate
	|-SingletonProcInst<HubMenuSequence>.OnSingletonCreate
	|-SingletonProcInst<HubPlayTalkAfter>.OnSingletonCreate
	|-SingletonProcInst<HubSequence>.OnSingletonCreate
	|-SingletonProcInst<InvestmentNationDataSequence>.OnSingletonCreate
	|-SingletonProcInst<InvestmentSequence>.OnSingletonCreate
	|-SingletonProcInst<JobIntroSequence>.OnSingletonCreate
	|-SingletonProcInst<JobIntroStatus>.OnSingletonCreate
	|-SingletonProcInst<JukeboxSequence>.OnSingletonCreate
	|-SingletonProcInst<LaterTalkSequence>.OnSingletonCreate
	|-SingletonProcInst<MainMenuSequence>.OnSingletonCreate
	|-SingletonProcInst<MainSequence>.OnSingletonCreate
	|-SingletonProcInst<MapKeyHelp>.OnSingletonCreate
	|-SingletonProcInst<MapMiniMap>.OnSingletonCreate
	|-SingletonProcInst<MapSequence>.OnSingletonCreate
	|-SingletonProcInst<MapSequenceAI>.OnSingletonCreate
	|-SingletonProcInst<MapSequenceAlternateConfirm>.OnSingletonCreate
	|-SingletonProcInst<MapSequenceBattle>.OnSingletonCreate
	|-SingletonProcInst<MapSequenceBattleAction>.OnSingletonCreate
	|-SingletonProcInst<MapSequenceCommandSkill>.OnSingletonCreate
	|-SingletonProcInst<MapSequenceContract>.OnSingletonCreate
	|-SingletonProcInst<MapSequenceDance>.OnSingletonCreate
	|-SingletonProcInst<MapSequenceEditor>.OnSingletonCreate
	|-SingletonProcInst<MapSequenceEngageConfirm>.OnSingletonCreate
	|-SingletonProcInst<MapSequenceHuman>.OnSingletonCreate
	|-SingletonProcInst<MapSequenceMove>.OnSingletonCreate
	|-SingletonProcInst<MapSequenceReplay>.OnSingletonCreate
	|-SingletonProcInst<MapSequenceSkipReplay>.OnSingletonCreate
	|-SingletonProcInst<MapSequenceTargetSelect>.OnSingletonCreate
	|-SingletonProcInst<MascotFoodEatSequence>.OnSingletonCreate
	|-SingletonProcInst<MascotMenuSequence>.OnSingletonCreate
	|-SingletonProcInst<MovieSequence>.OnSingletonCreate
	|-SingletonProcInst<MyRoomChestSequence>.OnSingletonCreate
	|-SingletonProcInst<MyRoomMovieSequence>.OnSingletonCreate
	|-SingletonProcInst<MyRoomRelianceSequence>.OnSingletonCreate
	|-SingletonProcInst<MyRoomSequence>.OnSingletonCreate
	|-SingletonProcInst<MyRoomSoundSequence>.OnSingletonCreate
	|-SingletonProcInst<MyRoomWakeupSelectSequence>.OnSingletonCreate
	|-SingletonProcInst<MyRoomWakeupSequence>.OnSingletonCreate
	|-SingletonProcInst<object>.OnSingletonCreate
	|-SingletonProcInst<PhotographTopSequence>.OnSingletonCreate
	|-SingletonProcInst<RankingSequence>.OnSingletonCreate
	|-SingletonProcInst<RelayAppearanceSequence>.OnSingletonCreate
	|-SingletonProcInst<RelayAwardSequence>.OnSingletonCreate
	|-SingletonProcInst<RelayReplayToTakeOverSequence>.OnSingletonCreate
	|-SingletonProcInst<RewindSequence>.OnSingletonCreate
	|-SingletonProcInst<RingCleaningSequence>.OnSingletonCreate
	|-SingletonProcInst<RingGachaSequence>.OnSingletonCreate
	|-SingletonProcInst<RingInfo>.OnSingletonCreate
	|-SingletonProcInst<RingListSequence>.OnSingletonCreate
	|-SingletonProcInst<RingSynthesisSequence>.OnSingletonCreate
	|-SingletonProcInst<SaveDataMenuSequence>.OnSingletonCreate
	|-SingletonProcInst<SortieSequence>.OnSingletonCreate
	|-SingletonProcInst<SortieSequenceClassChange>.OnSingletonCreate
	|-SingletonProcInst<SortieSequenceInventory>.OnSingletonCreate
	|-SingletonProcInst<SortieSequenceReliance>.OnSingletonCreate
	|-SingletonProcInst<SortieSequenceRingSelect>.OnSingletonCreate
	|-SingletonProcInst<SortieSequenceSkillEdit>.OnSingletonCreate
	|-SingletonProcInst<SortieSequenceTrade>.OnSingletonCreate
	|-SingletonProcInst<SortieSequenceTroopList>.OnSingletonCreate
	|-SingletonProcInst<SortieSequenceUnitSelect>.OnSingletonCreate
	|-SingletonProcInst<TalkLogSequence>.OnSingletonCreate
	|-SingletonProcInst<TalkSequence>.OnSingletonCreate
	|-SingletonProcInst<TitleLoopSequence>.OnSingletonCreate
	|-SingletonProcInst<TitleSequence>.OnSingletonCreate
	|-SingletonProcInst<TutorialSequence>.OnSingletonCreate
	|-SingletonProcInst<UnitHasItemMaxSequence>.OnSingletonCreate
	|-SingletonProcInst<UnitInfo>.OnSingletonCreate
	|-SingletonProcInst<UnitInfoSequence>.OnSingletonCreate
	|-SingletonProcInst<UnitStatus>.OnSingletonCreate
	|-SingletonProcInst<FieldBgmManager.ProcChangeBgm>.OnSingletonCreate
	|-SingletonProcInst<HubSequence.LastChapterSequence>.OnSingletonCreate
	|-SingletonProcInst<Nex.AutoLogoutFinalize>.OnSingletonCreate
	|-SingletonProcInst<Nex.DispatchHigh>.OnSingletonCreate
	|-SingletonProcInst<Nex.DispatchLow>.OnSingletonCreate
	|-SingletonProcInst<RelaySequence.RelaySequenceLocal>.OnSingletonCreate
	|-SingletonProcInst<RelaySequence.RelaySequenceNet>.OnSingletonCreate
	|-SingletonProcInst<SoundWwise.SoundBankManager>.OnSingletonCreate
	|-SingletonProcInst<TitleSequence.ProcTitleCall>.OnSingletonCreate
	|-SingletonProcInst<VersusSequence.VersusSequenceLocal>.OnSingletonCreate
	|-SingletonProcInst<VersusSequence.VersusSequenceNet>.OnSingletonCreate
	*/

	// RVA: -1 Offset: -1 Slot: 14
	protected sealed override void OnSingletonDispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x343FBD0 Offset: 0x343FCD1 VA: 0x343FBD0
	|-SingletonProcInst<AchievementSequence>.OnSingletonDispose
	|-SingletonProcInst<AmiiboSequence>.OnSingletonDispose
	|-SingletonProcInst<AmiiboSoundSequence>.OnSingletonDispose
	|-SingletonProcInst<AmiiboTopSequence>.OnSingletonDispose
	|-SingletonProcInst<AnimalAccessSequence>.OnSingletonDispose
	|-SingletonProcInst<AnimalCatchSequence>.OnSingletonDispose
	|-SingletonProcInst<AnimalMenuSequence>.OnSingletonDispose
	|-SingletonProcInst<AnimalSequence>.OnSingletonDispose
	|-SingletonProcInst<ArenaCombatSequence>.OnSingletonDispose
	|-SingletonProcInst<ArenaOrderSequence>.OnSingletonDispose
	|-SingletonProcInst<BattleRecordSequence>.OnSingletonDispose
	|-SingletonProcInst<ClassChangeSequence>.OnSingletonDispose
	|-SingletonProcInst<CombatSequence>.OnSingletonDispose
	|-SingletonProcInst<ConfigBgmSelectSequence>.OnSingletonDispose
	|-SingletonProcInst<ConsoleManager>.OnSingletonDispose
	|-SingletonProcInst<DamageInfo>.OnSingletonDispose
	|-SingletonProcInst<EndRollSequence>.OnSingletonDispose
	|-SingletonProcInst<EventDemoSequence>.OnSingletonDispose
	|-SingletonProcInst<FortuneTellingResultSequence>.OnSingletonDispose
	|-SingletonProcInst<FriendListSequence>.OnSingletonDispose
	|-SingletonProcInst<GmapMenuSequence>.OnSingletonDispose
	|-SingletonProcInst<GmapSequence>.OnSingletonDispose
	|-SingletonProcInst<HelpProc>.OnSingletonDispose
	|-SingletonProcInst<HubAccessoryRoom>.OnSingletonDispose
	|-SingletonProcInst<HubMenuSequence>.OnSingletonDispose
	|-SingletonProcInst<HubPlayTalkAfter>.OnSingletonDispose
	|-SingletonProcInst<HubSequence>.OnSingletonDispose
	|-SingletonProcInst<InvestmentNationDataSequence>.OnSingletonDispose
	|-SingletonProcInst<InvestmentSequence>.OnSingletonDispose
	|-SingletonProcInst<JobIntroSequence>.OnSingletonDispose
	|-SingletonProcInst<JobIntroStatus>.OnSingletonDispose
	|-SingletonProcInst<JukeboxSequence>.OnSingletonDispose
	|-SingletonProcInst<LaterTalkSequence>.OnSingletonDispose
	|-SingletonProcInst<MainMenuSequence>.OnSingletonDispose
	|-SingletonProcInst<MainSequence>.OnSingletonDispose
	|-SingletonProcInst<MapKeyHelp>.OnSingletonDispose
	|-SingletonProcInst<MapMiniMap>.OnSingletonDispose
	|-SingletonProcInst<MapSequence>.OnSingletonDispose
	|-SingletonProcInst<MapSequenceAI>.OnSingletonDispose
	|-SingletonProcInst<MapSequenceAlternateConfirm>.OnSingletonDispose
	|-SingletonProcInst<MapSequenceBattle>.OnSingletonDispose
	|-SingletonProcInst<MapSequenceBattleAction>.OnSingletonDispose
	|-SingletonProcInst<MapSequenceCommandSkill>.OnSingletonDispose
	|-SingletonProcInst<MapSequenceContract>.OnSingletonDispose
	|-SingletonProcInst<MapSequenceDance>.OnSingletonDispose
	|-SingletonProcInst<MapSequenceEditor>.OnSingletonDispose
	|-SingletonProcInst<MapSequenceEngageConfirm>.OnSingletonDispose
	|-SingletonProcInst<MapSequenceHuman>.OnSingletonDispose
	|-SingletonProcInst<MapSequenceMove>.OnSingletonDispose
	|-SingletonProcInst<MapSequenceReplay>.OnSingletonDispose
	|-SingletonProcInst<MapSequenceSkipReplay>.OnSingletonDispose
	|-SingletonProcInst<MapSequenceTargetSelect>.OnSingletonDispose
	|-SingletonProcInst<MascotFoodEatSequence>.OnSingletonDispose
	|-SingletonProcInst<MascotMenuSequence>.OnSingletonDispose
	|-SingletonProcInst<MovieSequence>.OnSingletonDispose
	|-SingletonProcInst<MyRoomChestSequence>.OnSingletonDispose
	|-SingletonProcInst<MyRoomMovieSequence>.OnSingletonDispose
	|-SingletonProcInst<MyRoomRelianceSequence>.OnSingletonDispose
	|-SingletonProcInst<MyRoomSequence>.OnSingletonDispose
	|-SingletonProcInst<MyRoomSoundSequence>.OnSingletonDispose
	|-SingletonProcInst<MyRoomWakeupSelectSequence>.OnSingletonDispose
	|-SingletonProcInst<MyRoomWakeupSequence>.OnSingletonDispose
	|-SingletonProcInst<object>.OnSingletonDispose
	|-SingletonProcInst<PhotographTopSequence>.OnSingletonDispose
	|-SingletonProcInst<RankingSequence>.OnSingletonDispose
	|-SingletonProcInst<RelayAppearanceSequence>.OnSingletonDispose
	|-SingletonProcInst<RelayAwardSequence>.OnSingletonDispose
	|-SingletonProcInst<RelayReplayToTakeOverSequence>.OnSingletonDispose
	|-SingletonProcInst<RewindSequence>.OnSingletonDispose
	|-SingletonProcInst<RingCleaningSequence>.OnSingletonDispose
	|-SingletonProcInst<RingGachaSequence>.OnSingletonDispose
	|-SingletonProcInst<RingInfo>.OnSingletonDispose
	|-SingletonProcInst<RingListSequence>.OnSingletonDispose
	|-SingletonProcInst<RingSynthesisSequence>.OnSingletonDispose
	|-SingletonProcInst<SaveDataMenuSequence>.OnSingletonDispose
	|-SingletonProcInst<SortieSequence>.OnSingletonDispose
	|-SingletonProcInst<SortieSequenceClassChange>.OnSingletonDispose
	|-SingletonProcInst<SortieSequenceInventory>.OnSingletonDispose
	|-SingletonProcInst<SortieSequenceReliance>.OnSingletonDispose
	|-SingletonProcInst<SortieSequenceRingSelect>.OnSingletonDispose
	|-SingletonProcInst<SortieSequenceSkillEdit>.OnSingletonDispose
	|-SingletonProcInst<SortieSequenceTrade>.OnSingletonDispose
	|-SingletonProcInst<SortieSequenceTroopList>.OnSingletonDispose
	|-SingletonProcInst<SortieSequenceUnitSelect>.OnSingletonDispose
	|-SingletonProcInst<TalkLogSequence>.OnSingletonDispose
	|-SingletonProcInst<TalkSequence>.OnSingletonDispose
	|-SingletonProcInst<TitleLoopSequence>.OnSingletonDispose
	|-SingletonProcInst<TitleSequence>.OnSingletonDispose
	|-SingletonProcInst<TutorialSequence>.OnSingletonDispose
	|-SingletonProcInst<UnitHasItemMaxSequence>.OnSingletonDispose
	|-SingletonProcInst<UnitInfo>.OnSingletonDispose
	|-SingletonProcInst<UnitInfoSequence>.OnSingletonDispose
	|-SingletonProcInst<UnitStatus>.OnSingletonDispose
	|-SingletonProcInst<FieldBgmManager.ProcChangeBgm>.OnSingletonDispose
	|-SingletonProcInst<HubSequence.LastChapterSequence>.OnSingletonDispose
	|-SingletonProcInst<Nex.AutoLogoutFinalize>.OnSingletonDispose
	|-SingletonProcInst<Nex.DispatchHigh>.OnSingletonDispose
	|-SingletonProcInst<Nex.DispatchLow>.OnSingletonDispose
	|-SingletonProcInst<RelaySequence.RelaySequenceLocal>.OnSingletonDispose
	|-SingletonProcInst<RelaySequence.RelaySequenceNet>.OnSingletonDispose
	|-SingletonProcInst<SoundWwise.SoundBankManager>.OnSingletonDispose
	|-SingletonProcInst<TitleSequence.ProcTitleCall>.OnSingletonDispose
	|-SingletonProcInst<VersusSequence.VersusSequenceLocal>.OnSingletonDispose
	|-SingletonProcInst<VersusSequence.VersusSequenceNet>.OnSingletonDispose
	*/

	[CompilerGeneratedAttribute] // RVA: 0x2AE780 Offset: 0x2AE881 VA: 0x2AE780
	// RVA: -1 Offset: -1
	protected bool get_IsResume() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x343FD40 Offset: 0x343FE41 VA: 0x343FD40
	|-SingletonProcInst<HubSequence>.get_IsResume
	|-SingletonProcInst<MapSequence>.get_IsResume
	|-SingletonProcInst<object>.get_IsResume
	*/

	[CompilerGeneratedAttribute] // RVA: 0x2AE790 Offset: 0x2AE891 VA: 0x2AE790
	// RVA: -1 Offset: -1
	private void set_IsResume(bool value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x343FD50 Offset: 0x343FE51 VA: 0x343FD50
	|-SingletonProcInst<object>.set_IsResume
	*/

	// RVA: -1 Offset: -1 Slot: 18
	protected virtual int get_Version() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x343FD60 Offset: 0x343FE61 VA: 0x343FD60
	|-SingletonProcInst<AchievementSequence>.get_Version
	|-SingletonProcInst<AmiiboSequence>.get_Version
	|-SingletonProcInst<AmiiboSoundSequence>.get_Version
	|-SingletonProcInst<AmiiboTopSequence>.get_Version
	|-SingletonProcInst<AnimalAccessSequence>.get_Version
	|-SingletonProcInst<AnimalCatchSequence>.get_Version
	|-SingletonProcInst<AnimalMenuSequence>.get_Version
	|-SingletonProcInst<AnimalSequence>.get_Version
	|-SingletonProcInst<ArenaCombatSequence>.get_Version
	|-SingletonProcInst<ArenaOrderSequence>.get_Version
	|-SingletonProcInst<BattleRecordSequence>.get_Version
	|-SingletonProcInst<ClassChangeSequence>.get_Version
	|-SingletonProcInst<CombatSequence>.get_Version
	|-SingletonProcInst<ConfigBgmSelectSequence>.get_Version
	|-SingletonProcInst<ConsoleManager>.get_Version
	|-SingletonProcInst<DamageInfo>.get_Version
	|-SingletonProcInst<EndRollSequence>.get_Version
	|-SingletonProcInst<EventDemoSequence>.get_Version
	|-SingletonProcInst<FortuneTellingResultSequence>.get_Version
	|-SingletonProcInst<FriendListSequence>.get_Version
	|-SingletonProcInst<GmapMenuSequence>.get_Version
	|-SingletonProcInst<HelpProc>.get_Version
	|-SingletonProcInst<HubAccessoryRoom>.get_Version
	|-SingletonProcInst<HubMenuSequence>.get_Version
	|-SingletonProcInst<HubPlayTalkAfter>.get_Version
	|-SingletonProcInst<HubSequence>.get_Version
	|-SingletonProcInst<InvestmentNationDataSequence>.get_Version
	|-SingletonProcInst<InvestmentSequence>.get_Version
	|-SingletonProcInst<JobIntroSequence>.get_Version
	|-SingletonProcInst<JobIntroStatus>.get_Version
	|-SingletonProcInst<JukeboxSequence>.get_Version
	|-SingletonProcInst<LaterTalkSequence>.get_Version
	|-SingletonProcInst<MainMenuSequence>.get_Version
	|-SingletonProcInst<MainSequence>.get_Version
	|-SingletonProcInst<MapKeyHelp>.get_Version
	|-SingletonProcInst<MapMiniMap>.get_Version
	|-SingletonProcInst<MapSequenceAI>.get_Version
	|-SingletonProcInst<MapSequenceAlternateConfirm>.get_Version
	|-SingletonProcInst<MapSequenceBattle>.get_Version
	|-SingletonProcInst<MapSequenceBattleAction>.get_Version
	|-SingletonProcInst<MapSequenceCommandSkill>.get_Version
	|-SingletonProcInst<MapSequenceContract>.get_Version
	|-SingletonProcInst<MapSequenceDance>.get_Version
	|-SingletonProcInst<MapSequenceEditor>.get_Version
	|-SingletonProcInst<MapSequenceEngageConfirm>.get_Version
	|-SingletonProcInst<MapSequenceHuman>.get_Version
	|-SingletonProcInst<MapSequenceMove>.get_Version
	|-SingletonProcInst<MapSequenceReplay>.get_Version
	|-SingletonProcInst<MapSequenceSkipReplay>.get_Version
	|-SingletonProcInst<MapSequenceTargetSelect>.get_Version
	|-SingletonProcInst<MascotFoodEatSequence>.get_Version
	|-SingletonProcInst<MascotMenuSequence>.get_Version
	|-SingletonProcInst<MovieSequence>.get_Version
	|-SingletonProcInst<MyRoomChestSequence>.get_Version
	|-SingletonProcInst<MyRoomMovieSequence>.get_Version
	|-SingletonProcInst<MyRoomRelianceSequence>.get_Version
	|-SingletonProcInst<MyRoomSequence>.get_Version
	|-SingletonProcInst<MyRoomSoundSequence>.get_Version
	|-SingletonProcInst<MyRoomWakeupSelectSequence>.get_Version
	|-SingletonProcInst<MyRoomWakeupSequence>.get_Version
	|-SingletonProcInst<object>.get_Version
	|-SingletonProcInst<PhotographTopSequence>.get_Version
	|-SingletonProcInst<RankingSequence>.get_Version
	|-SingletonProcInst<RelayAppearanceSequence>.get_Version
	|-SingletonProcInst<RelayAwardSequence>.get_Version
	|-SingletonProcInst<RelayReplayToTakeOverSequence>.get_Version
	|-SingletonProcInst<RewindSequence>.get_Version
	|-SingletonProcInst<RingCleaningSequence>.get_Version
	|-SingletonProcInst<RingGachaSequence>.get_Version
	|-SingletonProcInst<RingInfo>.get_Version
	|-SingletonProcInst<RingListSequence>.get_Version
	|-SingletonProcInst<RingSynthesisSequence>.get_Version
	|-SingletonProcInst<SaveDataMenuSequence>.get_Version
	|-SingletonProcInst<SortieSequence>.get_Version
	|-SingletonProcInst<SortieSequenceClassChange>.get_Version
	|-SingletonProcInst<SortieSequenceInventory>.get_Version
	|-SingletonProcInst<SortieSequenceReliance>.get_Version
	|-SingletonProcInst<SortieSequenceRingSelect>.get_Version
	|-SingletonProcInst<SortieSequenceSkillEdit>.get_Version
	|-SingletonProcInst<SortieSequenceTrade>.get_Version
	|-SingletonProcInst<SortieSequenceTroopList>.get_Version
	|-SingletonProcInst<SortieSequenceUnitSelect>.get_Version
	|-SingletonProcInst<TalkLogSequence>.get_Version
	|-SingletonProcInst<TalkSequence>.get_Version
	|-SingletonProcInst<TitleLoopSequence>.get_Version
	|-SingletonProcInst<TitleSequence>.get_Version
	|-SingletonProcInst<TutorialSequence>.get_Version
	|-SingletonProcInst<UnitHasItemMaxSequence>.get_Version
	|-SingletonProcInst<UnitInfo>.get_Version
	|-SingletonProcInst<UnitInfoSequence>.get_Version
	|-SingletonProcInst<UnitStatus>.get_Version
	|-SingletonProcInst<FieldBgmManager.ProcChangeBgm>.get_Version
	|-SingletonProcInst<HubSequence.LastChapterSequence>.get_Version
	|-SingletonProcInst<Nex.AutoLogoutFinalize>.get_Version
	|-SingletonProcInst<Nex.DispatchHigh>.get_Version
	|-SingletonProcInst<Nex.DispatchLow>.get_Version
	|-SingletonProcInst<RelaySequence.RelaySequenceLocal>.get_Version
	|-SingletonProcInst<RelaySequence.RelaySequenceNet>.get_Version
	|-SingletonProcInst<SoundWwise.SoundBankManager>.get_Version
	|-SingletonProcInst<TitleSequence.ProcTitleCall>.get_Version
	|-SingletonProcInst<VersusSequence.VersusSequenceLocal>.get_Version
	|-SingletonProcInst<VersusSequence.VersusSequenceNet>.get_Version
	*/

	// RVA: -1 Offset: -1
	protected void ResumeStart() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x343FD70 Offset: 0x343FE71 VA: 0x343FD70
	|-SingletonProcInst<MapSequence>.ResumeStart
	|-SingletonProcInst<object>.ResumeStart
	*/

	// RVA: -1 Offset: -1
	protected void ResumeEnd() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x343FD90 Offset: 0x343FE91 VA: 0x343FD90
	|-SingletonProcInst<HubSequence>.ResumeEnd
	|-SingletonProcInst<MapSequence>.ResumeEnd
	|-SingletonProcInst<object>.ResumeEnd
	*/

	// RVA: -1 Offset: -1
	public static void Serialize(Stream stream) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x343FDB0 Offset: 0x343FEB1 VA: 0x343FDB0
	|-SingletonProcInst<GmapSequence>.Serialize
	|-SingletonProcInst<HubSequence>.Serialize
	|-SingletonProcInst<MapSequence>.Serialize
	|-SingletonProcInst<object>.Serialize
	*/

	// RVA: -1 Offset: -1
	public static void Deserialize(Stream stream) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34400D0 Offset: 0x34401D1 VA: 0x34400D0
	|-SingletonProcInst<GmapSequence>.Deserialize
	|-SingletonProcInst<HubSequence>.Deserialize
	|-SingletonProcInst<MapSequence>.Deserialize
	|-SingletonProcInst<object>.Deserialize
	*/

	// RVA: -1 Offset: -1 Slot: 19
	protected virtual string get_GlobalAssetPath() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3440450 Offset: 0x3440551 VA: 0x3440450
	|-SingletonProcInst<AchievementSequence>.get_GlobalAssetPath
	|-SingletonProcInst<AmiiboSequence>.get_GlobalAssetPath
	|-SingletonProcInst<AmiiboSoundSequence>.get_GlobalAssetPath
	|-SingletonProcInst<AmiiboTopSequence>.get_GlobalAssetPath
	|-SingletonProcInst<AnimalAccessSequence>.get_GlobalAssetPath
	|-SingletonProcInst<AnimalCatchSequence>.get_GlobalAssetPath
	|-SingletonProcInst<AnimalMenuSequence>.get_GlobalAssetPath
	|-SingletonProcInst<AnimalSequence>.get_GlobalAssetPath
	|-SingletonProcInst<ArenaCombatSequence>.get_GlobalAssetPath
	|-SingletonProcInst<ArenaOrderSequence>.get_GlobalAssetPath
	|-SingletonProcInst<BattleRecordSequence>.get_GlobalAssetPath
	|-SingletonProcInst<CombatSequence>.get_GlobalAssetPath
	|-SingletonProcInst<ConfigBgmSelectSequence>.get_GlobalAssetPath
	|-SingletonProcInst<ConsoleManager>.get_GlobalAssetPath
	|-SingletonProcInst<EndRollSequence>.get_GlobalAssetPath
	|-SingletonProcInst<EventDemoSequence>.get_GlobalAssetPath
	|-SingletonProcInst<FortuneTellingResultSequence>.get_GlobalAssetPath
	|-SingletonProcInst<FriendListSequence>.get_GlobalAssetPath
	|-SingletonProcInst<GmapMenuSequence>.get_GlobalAssetPath
	|-SingletonProcInst<GmapSequence>.get_GlobalAssetPath
	|-SingletonProcInst<HelpProc>.get_GlobalAssetPath
	|-SingletonProcInst<HubAccessoryRoom>.get_GlobalAssetPath
	|-SingletonProcInst<HubMenuSequence>.get_GlobalAssetPath
	|-SingletonProcInst<HubPlayTalkAfter>.get_GlobalAssetPath
	|-SingletonProcInst<HubSequence>.get_GlobalAssetPath
	|-SingletonProcInst<InvestmentNationDataSequence>.get_GlobalAssetPath
	|-SingletonProcInst<InvestmentSequence>.get_GlobalAssetPath
	|-SingletonProcInst<JobIntroSequence>.get_GlobalAssetPath
	|-SingletonProcInst<JobIntroStatus>.get_GlobalAssetPath
	|-SingletonProcInst<JukeboxSequence>.get_GlobalAssetPath
	|-SingletonProcInst<LaterTalkSequence>.get_GlobalAssetPath
	|-SingletonProcInst<MainMenuSequence>.get_GlobalAssetPath
	|-SingletonProcInst<MainSequence>.get_GlobalAssetPath
	|-SingletonProcInst<MapKeyHelp>.get_GlobalAssetPath
	|-SingletonProcInst<MapMiniMap>.get_GlobalAssetPath
	|-SingletonProcInst<MapSequence>.get_GlobalAssetPath
	|-SingletonProcInst<MapSequenceAI>.get_GlobalAssetPath
	|-SingletonProcInst<MapSequenceBattle>.get_GlobalAssetPath
	|-SingletonProcInst<MapSequenceBattleAction>.get_GlobalAssetPath
	|-SingletonProcInst<MapSequenceCommandSkill>.get_GlobalAssetPath
	|-SingletonProcInst<MapSequenceContract>.get_GlobalAssetPath
	|-SingletonProcInst<MapSequenceDance>.get_GlobalAssetPath
	|-SingletonProcInst<MapSequenceEditor>.get_GlobalAssetPath
	|-SingletonProcInst<MapSequenceHuman>.get_GlobalAssetPath
	|-SingletonProcInst<MapSequenceMove>.get_GlobalAssetPath
	|-SingletonProcInst<MapSequenceReplay>.get_GlobalAssetPath
	|-SingletonProcInst<MapSequenceSkipReplay>.get_GlobalAssetPath
	|-SingletonProcInst<MascotFoodEatSequence>.get_GlobalAssetPath
	|-SingletonProcInst<MascotMenuSequence>.get_GlobalAssetPath
	|-SingletonProcInst<MovieSequence>.get_GlobalAssetPath
	|-SingletonProcInst<MyRoomChestSequence>.get_GlobalAssetPath
	|-SingletonProcInst<MyRoomMovieSequence>.get_GlobalAssetPath
	|-SingletonProcInst<MyRoomRelianceSequence>.get_GlobalAssetPath
	|-SingletonProcInst<MyRoomSequence>.get_GlobalAssetPath
	|-SingletonProcInst<MyRoomSoundSequence>.get_GlobalAssetPath
	|-SingletonProcInst<MyRoomWakeupSelectSequence>.get_GlobalAssetPath
	|-SingletonProcInst<MyRoomWakeupSequence>.get_GlobalAssetPath
	|-SingletonProcInst<object>.get_GlobalAssetPath
	|-SingletonProcInst<PhotographTopSequence>.get_GlobalAssetPath
	|-SingletonProcInst<RankingSequence>.get_GlobalAssetPath
	|-SingletonProcInst<RelayAppearanceSequence>.get_GlobalAssetPath
	|-SingletonProcInst<RelayAwardSequence>.get_GlobalAssetPath
	|-SingletonProcInst<RelayReplayToTakeOverSequence>.get_GlobalAssetPath
	|-SingletonProcInst<RewindSequence>.get_GlobalAssetPath
	|-SingletonProcInst<RingCleaningSequence>.get_GlobalAssetPath
	|-SingletonProcInst<RingGachaSequence>.get_GlobalAssetPath
	|-SingletonProcInst<RingInfo>.get_GlobalAssetPath
	|-SingletonProcInst<RingListSequence>.get_GlobalAssetPath
	|-SingletonProcInst<RingSynthesisSequence>.get_GlobalAssetPath
	|-SingletonProcInst<SaveDataMenuSequence>.get_GlobalAssetPath
	|-SingletonProcInst<SortieSequence>.get_GlobalAssetPath
	|-SingletonProcInst<SortieSequenceClassChange>.get_GlobalAssetPath
	|-SingletonProcInst<SortieSequenceInventory>.get_GlobalAssetPath
	|-SingletonProcInst<SortieSequenceReliance>.get_GlobalAssetPath
	|-SingletonProcInst<SortieSequenceRingSelect>.get_GlobalAssetPath
	|-SingletonProcInst<SortieSequenceSkillEdit>.get_GlobalAssetPath
	|-SingletonProcInst<SortieSequenceTrade>.get_GlobalAssetPath
	|-SingletonProcInst<SortieSequenceTroopList>.get_GlobalAssetPath
	|-SingletonProcInst<SortieSequenceUnitSelect>.get_GlobalAssetPath
	|-SingletonProcInst<TalkLogSequence>.get_GlobalAssetPath
	|-SingletonProcInst<TalkSequence>.get_GlobalAssetPath
	|-SingletonProcInst<TitleLoopSequence>.get_GlobalAssetPath
	|-SingletonProcInst<TitleSequence>.get_GlobalAssetPath
	|-SingletonProcInst<TutorialSequence>.get_GlobalAssetPath
	|-SingletonProcInst<UnitHasItemMaxSequence>.get_GlobalAssetPath
	|-SingletonProcInst<UnitInfo>.get_GlobalAssetPath
	|-SingletonProcInst<UnitInfoSequence>.get_GlobalAssetPath
	|-SingletonProcInst<UnitStatus>.get_GlobalAssetPath
	|-SingletonProcInst<FieldBgmManager.ProcChangeBgm>.get_GlobalAssetPath
	|-SingletonProcInst<HubSequence.LastChapterSequence>.get_GlobalAssetPath
	|-SingletonProcInst<Nex.AutoLogoutFinalize>.get_GlobalAssetPath
	|-SingletonProcInst<Nex.DispatchHigh>.get_GlobalAssetPath
	|-SingletonProcInst<Nex.DispatchLow>.get_GlobalAssetPath
	|-SingletonProcInst<RelaySequence.RelaySequenceLocal>.get_GlobalAssetPath
	|-SingletonProcInst<RelaySequence.RelaySequenceNet>.get_GlobalAssetPath
	|-SingletonProcInst<SoundWwise.SoundBankManager>.get_GlobalAssetPath
	|-SingletonProcInst<TitleSequence.ProcTitleCall>.get_GlobalAssetPath
	|-SingletonProcInst<VersusSequence.VersusSequenceLocal>.get_GlobalAssetPath
	|-SingletonProcInst<VersusSequence.VersusSequenceNet>.get_GlobalAssetPath
	*/

	// RVA: -1 Offset: -1
	protected void LoadGlobalAssetAsync<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2555100 Offset: 0x2555201 VA: 0x2555100
	|-SingletonProcInst<DamageInfo>.LoadGlobalAssetAsync<GameObject>
	|-SingletonProcInst<MapSequenceAlternateConfirm>.LoadGlobalAssetAsync<GameObject>
	|-SingletonProcInst<MapSequenceEngageConfirm>.LoadGlobalAssetAsync<GameObject>
	|-SingletonProcInst<MapSequenceTargetSelect>.LoadGlobalAssetAsync<GameObject>
	|-SingletonProcInst<object>.LoadGlobalAssetAsync<object>
	*/

	// RVA: -1 Offset: -1
	protected void LoadGlobalAssetAsync() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3440460 Offset: 0x3440561 VA: 0x3440460
	|-SingletonProcInst<ClassChangeSequence>.LoadGlobalAssetAsync
	|-SingletonProcInst<object>.LoadGlobalAssetAsync
	*/

	// RVA: -1 Offset: -1
	protected bool IsLoadingGlobalAsset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3440480 Offset: 0x3440581 VA: 0x3440480
	|-SingletonProcInst<ClassChangeSequence>.IsLoadingGlobalAsset
	|-SingletonProcInst<DamageInfo>.IsLoadingGlobalAsset
	|-SingletonProcInst<MapSequenceAlternateConfirm>.IsLoadingGlobalAsset
	|-SingletonProcInst<MapSequenceEngageConfirm>.IsLoadingGlobalAsset
	|-SingletonProcInst<MapSequenceTargetSelect>.IsLoadingGlobalAsset
	|-SingletonProcInst<object>.IsLoadingGlobalAsset
	*/

	// RVA: -1 Offset: -1
	protected void ReleaseGlobalAsset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3440520 Offset: 0x3440621 VA: 0x3440520
	|-SingletonProcInst<object>.ReleaseGlobalAsset
	*/

	// RVA: -1 Offset: -1
	protected GameObject InstantiateGlobalAsset(GameObject parent) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34405C0 Offset: 0x34406C1 VA: 0x34405C0
	|-SingletonProcInst<DamageInfo>.InstantiateGlobalAsset
	|-SingletonProcInst<MapSequenceAlternateConfirm>.InstantiateGlobalAsset
	|-SingletonProcInst<MapSequenceEngageConfirm>.InstantiateGlobalAsset
	|-SingletonProcInst<MapSequenceTargetSelect>.InstantiateGlobalAsset
	|-SingletonProcInst<object>.InstantiateGlobalAsset
	*/

	// RVA: -1 Offset: -1
	protected GameObject InstantiateGlobalAsset(Transform parent) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3440610 Offset: 0x3440711 VA: 0x3440610
	|-SingletonProcInst<ClassChangeSequence>.InstantiateGlobalAsset
	|-SingletonProcInst<object>.InstantiateGlobalAsset
	*/

	// RVA: -1 Offset: -1 Slot: 20
	protected virtual void OnSerialize(Stream stream) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34406C0 Offset: 0x34407C1 VA: 0x34406C0
	|-SingletonProcInst<AchievementSequence>.OnSerialize
	|-SingletonProcInst<AmiiboSequence>.OnSerialize
	|-SingletonProcInst<AmiiboSoundSequence>.OnSerialize
	|-SingletonProcInst<AmiiboTopSequence>.OnSerialize
	|-SingletonProcInst<AnimalAccessSequence>.OnSerialize
	|-SingletonProcInst<AnimalCatchSequence>.OnSerialize
	|-SingletonProcInst<AnimalMenuSequence>.OnSerialize
	|-SingletonProcInst<AnimalSequence>.OnSerialize
	|-SingletonProcInst<ArenaCombatSequence>.OnSerialize
	|-SingletonProcInst<ArenaOrderSequence>.OnSerialize
	|-SingletonProcInst<BattleRecordSequence>.OnSerialize
	|-SingletonProcInst<ClassChangeSequence>.OnSerialize
	|-SingletonProcInst<CombatSequence>.OnSerialize
	|-SingletonProcInst<ConfigBgmSelectSequence>.OnSerialize
	|-SingletonProcInst<ConsoleManager>.OnSerialize
	|-SingletonProcInst<DamageInfo>.OnSerialize
	|-SingletonProcInst<EndRollSequence>.OnSerialize
	|-SingletonProcInst<EventDemoSequence>.OnSerialize
	|-SingletonProcInst<FortuneTellingResultSequence>.OnSerialize
	|-SingletonProcInst<FriendListSequence>.OnSerialize
	|-SingletonProcInst<GmapMenuSequence>.OnSerialize
	|-SingletonProcInst<HelpProc>.OnSerialize
	|-SingletonProcInst<HubAccessoryRoom>.OnSerialize
	|-SingletonProcInst<HubMenuSequence>.OnSerialize
	|-SingletonProcInst<HubPlayTalkAfter>.OnSerialize
	|-SingletonProcInst<HubSequence>.OnSerialize
	|-SingletonProcInst<InvestmentNationDataSequence>.OnSerialize
	|-SingletonProcInst<InvestmentSequence>.OnSerialize
	|-SingletonProcInst<JobIntroSequence>.OnSerialize
	|-SingletonProcInst<JobIntroStatus>.OnSerialize
	|-SingletonProcInst<JukeboxSequence>.OnSerialize
	|-SingletonProcInst<LaterTalkSequence>.OnSerialize
	|-SingletonProcInst<MainMenuSequence>.OnSerialize
	|-SingletonProcInst<MainSequence>.OnSerialize
	|-SingletonProcInst<MapKeyHelp>.OnSerialize
	|-SingletonProcInst<MapMiniMap>.OnSerialize
	|-SingletonProcInst<MapSequenceAI>.OnSerialize
	|-SingletonProcInst<MapSequenceAlternateConfirm>.OnSerialize
	|-SingletonProcInst<MapSequenceBattle>.OnSerialize
	|-SingletonProcInst<MapSequenceBattleAction>.OnSerialize
	|-SingletonProcInst<MapSequenceCommandSkill>.OnSerialize
	|-SingletonProcInst<MapSequenceContract>.OnSerialize
	|-SingletonProcInst<MapSequenceDance>.OnSerialize
	|-SingletonProcInst<MapSequenceEditor>.OnSerialize
	|-SingletonProcInst<MapSequenceEngageConfirm>.OnSerialize
	|-SingletonProcInst<MapSequenceHuman>.OnSerialize
	|-SingletonProcInst<MapSequenceMove>.OnSerialize
	|-SingletonProcInst<MapSequenceReplay>.OnSerialize
	|-SingletonProcInst<MapSequenceSkipReplay>.OnSerialize
	|-SingletonProcInst<MapSequenceTargetSelect>.OnSerialize
	|-SingletonProcInst<MascotFoodEatSequence>.OnSerialize
	|-SingletonProcInst<MascotMenuSequence>.OnSerialize
	|-SingletonProcInst<MovieSequence>.OnSerialize
	|-SingletonProcInst<MyRoomChestSequence>.OnSerialize
	|-SingletonProcInst<MyRoomMovieSequence>.OnSerialize
	|-SingletonProcInst<MyRoomRelianceSequence>.OnSerialize
	|-SingletonProcInst<MyRoomSequence>.OnSerialize
	|-SingletonProcInst<MyRoomSoundSequence>.OnSerialize
	|-SingletonProcInst<MyRoomWakeupSelectSequence>.OnSerialize
	|-SingletonProcInst<MyRoomWakeupSequence>.OnSerialize
	|-SingletonProcInst<object>.OnSerialize
	|-SingletonProcInst<PhotographTopSequence>.OnSerialize
	|-SingletonProcInst<RankingSequence>.OnSerialize
	|-SingletonProcInst<RelayAppearanceSequence>.OnSerialize
	|-SingletonProcInst<RelayAwardSequence>.OnSerialize
	|-SingletonProcInst<RelayReplayToTakeOverSequence>.OnSerialize
	|-SingletonProcInst<RewindSequence>.OnSerialize
	|-SingletonProcInst<RingCleaningSequence>.OnSerialize
	|-SingletonProcInst<RingGachaSequence>.OnSerialize
	|-SingletonProcInst<RingInfo>.OnSerialize
	|-SingletonProcInst<RingListSequence>.OnSerialize
	|-SingletonProcInst<RingSynthesisSequence>.OnSerialize
	|-SingletonProcInst<SaveDataMenuSequence>.OnSerialize
	|-SingletonProcInst<SortieSequence>.OnSerialize
	|-SingletonProcInst<SortieSequenceClassChange>.OnSerialize
	|-SingletonProcInst<SortieSequenceInventory>.OnSerialize
	|-SingletonProcInst<SortieSequenceReliance>.OnSerialize
	|-SingletonProcInst<SortieSequenceRingSelect>.OnSerialize
	|-SingletonProcInst<SortieSequenceSkillEdit>.OnSerialize
	|-SingletonProcInst<SortieSequenceTrade>.OnSerialize
	|-SingletonProcInst<SortieSequenceTroopList>.OnSerialize
	|-SingletonProcInst<SortieSequenceUnitSelect>.OnSerialize
	|-SingletonProcInst<TalkLogSequence>.OnSerialize
	|-SingletonProcInst<TalkSequence>.OnSerialize
	|-SingletonProcInst<TitleLoopSequence>.OnSerialize
	|-SingletonProcInst<TitleSequence>.OnSerialize
	|-SingletonProcInst<TutorialSequence>.OnSerialize
	|-SingletonProcInst<UnitHasItemMaxSequence>.OnSerialize
	|-SingletonProcInst<UnitInfo>.OnSerialize
	|-SingletonProcInst<UnitInfoSequence>.OnSerialize
	|-SingletonProcInst<UnitStatus>.OnSerialize
	|-SingletonProcInst<FieldBgmManager.ProcChangeBgm>.OnSerialize
	|-SingletonProcInst<HubSequence.LastChapterSequence>.OnSerialize
	|-SingletonProcInst<Nex.AutoLogoutFinalize>.OnSerialize
	|-SingletonProcInst<Nex.DispatchHigh>.OnSerialize
	|-SingletonProcInst<Nex.DispatchLow>.OnSerialize
	|-SingletonProcInst<RelaySequence.RelaySequenceLocal>.OnSerialize
	|-SingletonProcInst<RelaySequence.RelaySequenceNet>.OnSerialize
	|-SingletonProcInst<SoundWwise.SoundBankManager>.OnSerialize
	|-SingletonProcInst<TitleSequence.ProcTitleCall>.OnSerialize
	|-SingletonProcInst<VersusSequence.VersusSequenceLocal>.OnSerialize
	|-SingletonProcInst<VersusSequence.VersusSequenceNet>.OnSerialize
	*/

	// RVA: -1 Offset: -1 Slot: 21
	protected virtual void OnDeserialize(Stream stream, int version) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34406D0 Offset: 0x34407D1 VA: 0x34406D0
	|-SingletonProcInst<AchievementSequence>.OnDeserialize
	|-SingletonProcInst<AmiiboSequence>.OnDeserialize
	|-SingletonProcInst<AmiiboSoundSequence>.OnDeserialize
	|-SingletonProcInst<AmiiboTopSequence>.OnDeserialize
	|-SingletonProcInst<AnimalAccessSequence>.OnDeserialize
	|-SingletonProcInst<AnimalCatchSequence>.OnDeserialize
	|-SingletonProcInst<AnimalMenuSequence>.OnDeserialize
	|-SingletonProcInst<AnimalSequence>.OnDeserialize
	|-SingletonProcInst<ArenaCombatSequence>.OnDeserialize
	|-SingletonProcInst<ArenaOrderSequence>.OnDeserialize
	|-SingletonProcInst<BattleRecordSequence>.OnDeserialize
	|-SingletonProcInst<ClassChangeSequence>.OnDeserialize
	|-SingletonProcInst<CombatSequence>.OnDeserialize
	|-SingletonProcInst<ConfigBgmSelectSequence>.OnDeserialize
	|-SingletonProcInst<ConsoleManager>.OnDeserialize
	|-SingletonProcInst<DamageInfo>.OnDeserialize
	|-SingletonProcInst<EndRollSequence>.OnDeserialize
	|-SingletonProcInst<EventDemoSequence>.OnDeserialize
	|-SingletonProcInst<FortuneTellingResultSequence>.OnDeserialize
	|-SingletonProcInst<FriendListSequence>.OnDeserialize
	|-SingletonProcInst<GmapMenuSequence>.OnDeserialize
	|-SingletonProcInst<HelpProc>.OnDeserialize
	|-SingletonProcInst<HubAccessoryRoom>.OnDeserialize
	|-SingletonProcInst<HubMenuSequence>.OnDeserialize
	|-SingletonProcInst<HubPlayTalkAfter>.OnDeserialize
	|-SingletonProcInst<HubSequence>.OnDeserialize
	|-SingletonProcInst<InvestmentNationDataSequence>.OnDeserialize
	|-SingletonProcInst<InvestmentSequence>.OnDeserialize
	|-SingletonProcInst<JobIntroSequence>.OnDeserialize
	|-SingletonProcInst<JobIntroStatus>.OnDeserialize
	|-SingletonProcInst<JukeboxSequence>.OnDeserialize
	|-SingletonProcInst<LaterTalkSequence>.OnDeserialize
	|-SingletonProcInst<MainMenuSequence>.OnDeserialize
	|-SingletonProcInst<MainSequence>.OnDeserialize
	|-SingletonProcInst<MapKeyHelp>.OnDeserialize
	|-SingletonProcInst<MapMiniMap>.OnDeserialize
	|-SingletonProcInst<MapSequenceAI>.OnDeserialize
	|-SingletonProcInst<MapSequenceAlternateConfirm>.OnDeserialize
	|-SingletonProcInst<MapSequenceBattle>.OnDeserialize
	|-SingletonProcInst<MapSequenceBattleAction>.OnDeserialize
	|-SingletonProcInst<MapSequenceCommandSkill>.OnDeserialize
	|-SingletonProcInst<MapSequenceContract>.OnDeserialize
	|-SingletonProcInst<MapSequenceDance>.OnDeserialize
	|-SingletonProcInst<MapSequenceEditor>.OnDeserialize
	|-SingletonProcInst<MapSequenceEngageConfirm>.OnDeserialize
	|-SingletonProcInst<MapSequenceHuman>.OnDeserialize
	|-SingletonProcInst<MapSequenceMove>.OnDeserialize
	|-SingletonProcInst<MapSequenceReplay>.OnDeserialize
	|-SingletonProcInst<MapSequenceSkipReplay>.OnDeserialize
	|-SingletonProcInst<MapSequenceTargetSelect>.OnDeserialize
	|-SingletonProcInst<MascotFoodEatSequence>.OnDeserialize
	|-SingletonProcInst<MascotMenuSequence>.OnDeserialize
	|-SingletonProcInst<MovieSequence>.OnDeserialize
	|-SingletonProcInst<MyRoomChestSequence>.OnDeserialize
	|-SingletonProcInst<MyRoomMovieSequence>.OnDeserialize
	|-SingletonProcInst<MyRoomRelianceSequence>.OnDeserialize
	|-SingletonProcInst<MyRoomSequence>.OnDeserialize
	|-SingletonProcInst<MyRoomSoundSequence>.OnDeserialize
	|-SingletonProcInst<MyRoomWakeupSelectSequence>.OnDeserialize
	|-SingletonProcInst<MyRoomWakeupSequence>.OnDeserialize
	|-SingletonProcInst<object>.OnDeserialize
	|-SingletonProcInst<PhotographTopSequence>.OnDeserialize
	|-SingletonProcInst<RankingSequence>.OnDeserialize
	|-SingletonProcInst<RelayAppearanceSequence>.OnDeserialize
	|-SingletonProcInst<RelayAwardSequence>.OnDeserialize
	|-SingletonProcInst<RelayReplayToTakeOverSequence>.OnDeserialize
	|-SingletonProcInst<RewindSequence>.OnDeserialize
	|-SingletonProcInst<RingCleaningSequence>.OnDeserialize
	|-SingletonProcInst<RingGachaSequence>.OnDeserialize
	|-SingletonProcInst<RingInfo>.OnDeserialize
	|-SingletonProcInst<RingListSequence>.OnDeserialize
	|-SingletonProcInst<RingSynthesisSequence>.OnDeserialize
	|-SingletonProcInst<SaveDataMenuSequence>.OnDeserialize
	|-SingletonProcInst<SortieSequence>.OnDeserialize
	|-SingletonProcInst<SortieSequenceClassChange>.OnDeserialize
	|-SingletonProcInst<SortieSequenceInventory>.OnDeserialize
	|-SingletonProcInst<SortieSequenceReliance>.OnDeserialize
	|-SingletonProcInst<SortieSequenceRingSelect>.OnDeserialize
	|-SingletonProcInst<SortieSequenceSkillEdit>.OnDeserialize
	|-SingletonProcInst<SortieSequenceTrade>.OnDeserialize
	|-SingletonProcInst<SortieSequenceTroopList>.OnDeserialize
	|-SingletonProcInst<SortieSequenceUnitSelect>.OnDeserialize
	|-SingletonProcInst<TalkLogSequence>.OnDeserialize
	|-SingletonProcInst<TalkSequence>.OnDeserialize
	|-SingletonProcInst<TitleLoopSequence>.OnDeserialize
	|-SingletonProcInst<TitleSequence>.OnDeserialize
	|-SingletonProcInst<TutorialSequence>.OnDeserialize
	|-SingletonProcInst<UnitHasItemMaxSequence>.OnDeserialize
	|-SingletonProcInst<UnitInfo>.OnDeserialize
	|-SingletonProcInst<UnitInfoSequence>.OnDeserialize
	|-SingletonProcInst<UnitStatus>.OnDeserialize
	|-SingletonProcInst<FieldBgmManager.ProcChangeBgm>.OnDeserialize
	|-SingletonProcInst<HubSequence.LastChapterSequence>.OnDeserialize
	|-SingletonProcInst<Nex.AutoLogoutFinalize>.OnDeserialize
	|-SingletonProcInst<Nex.DispatchHigh>.OnDeserialize
	|-SingletonProcInst<Nex.DispatchLow>.OnDeserialize
	|-SingletonProcInst<RelaySequence.RelaySequenceLocal>.OnDeserialize
	|-SingletonProcInst<RelaySequence.RelaySequenceNet>.OnDeserialize
	|-SingletonProcInst<SoundWwise.SoundBankManager>.OnDeserialize
	|-SingletonProcInst<TitleSequence.ProcTitleCall>.OnDeserialize
	|-SingletonProcInst<VersusSequence.VersusSequenceLocal>.OnDeserialize
	|-SingletonProcInst<VersusSequence.VersusSequenceNet>.OnDeserialize
	*/

	// RVA: -1 Offset: -1
	public static bool op_Implicit(SingletonProcInst<T> exists) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34406E0 Offset: 0x34407E1 VA: 0x34406E0
	|-SingletonProcInst<CombatSequence>.op_Implicit
	|-SingletonProcInst<EventDemoSequence>.op_Implicit
	|-SingletonProcInst<HubSequence>.op_Implicit
	|-SingletonProcInst<MapSequenceBattle>.op_Implicit
	|-SingletonProcInst<MapSequenceBattleAction>.op_Implicit
	|-SingletonProcInst<MapSequenceHuman>.op_Implicit
	|-SingletonProcInst<object>.op_Implicit
	|-SingletonProcInst<SortieSequence>.op_Implicit
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34406F0 Offset: 0x34407F1 VA: 0x34406F0
	|-SingletonProcInst<AchievementSequence>..ctor
	|-SingletonProcInst<AmiiboSequence>..ctor
	|-SingletonProcInst<AmiiboSoundSequence>..ctor
	|-SingletonProcInst<AmiiboTopSequence>..ctor
	|-SingletonProcInst<AnimalAccessSequence>..ctor
	|-SingletonProcInst<AnimalCatchSequence>..ctor
	|-SingletonProcInst<AnimalMenuSequence>..ctor
	|-SingletonProcInst<AnimalSequence>..ctor
	|-SingletonProcInst<ArenaCombatSequence>..ctor
	|-SingletonProcInst<ArenaOrderSequence>..ctor
	|-SingletonProcInst<BattleRecordSequence>..ctor
	|-SingletonProcInst<ClassChangeSequence>..ctor
	|-SingletonProcInst<CombatSequence>..ctor
	|-SingletonProcInst<ConfigBgmSelectSequence>..ctor
	|-SingletonProcInst<ConsoleManager>..ctor
	|-SingletonProcInst<DamageInfo>..ctor
	|-SingletonProcInst<EndRollSequence>..ctor
	|-SingletonProcInst<FortuneTellingResultSequence>..ctor
	|-SingletonProcInst<FriendListSequence>..ctor
	|-SingletonProcInst<GmapMenuSequence>..ctor
	|-SingletonProcInst<HelpProc>..ctor
	|-SingletonProcInst<HubMenuSequence>..ctor
	|-SingletonProcInst<HubPlayTalkAfter>..ctor
	|-SingletonProcInst<InvestmentNationDataSequence>..ctor
	|-SingletonProcInst<InvestmentSequence>..ctor
	|-SingletonProcInst<JobIntroStatus>..ctor
	|-SingletonProcInst<JukeboxSequence>..ctor
	|-SingletonProcInst<LaterTalkSequence>..ctor
	|-SingletonProcInst<MainMenuSequence>..ctor
	|-SingletonProcInst<MapKeyHelp>..ctor
	|-SingletonProcInst<MapMiniMap>..ctor
	|-SingletonProcInst<MapSequenceAI>..ctor
	|-SingletonProcInst<MapSequenceAlternateConfirm>..ctor
	|-SingletonProcInst<MapSequenceBattleAction>..ctor
	|-SingletonProcInst<MapSequenceCommandSkill>..ctor
	|-SingletonProcInst<MapSequenceEditor>..ctor
	|-SingletonProcInst<MapSequenceEngageConfirm>..ctor
	|-SingletonProcInst<MapSequenceHuman>..ctor
	|-SingletonProcInst<MapSequenceMove>..ctor
	|-SingletonProcInst<MapSequenceReplay>..ctor
	|-SingletonProcInst<MapSequenceSkipReplay>..ctor
	|-SingletonProcInst<MapSequenceTargetSelect>..ctor
	|-SingletonProcInst<MascotFoodEatSequence>..ctor
	|-SingletonProcInst<MascotMenuSequence>..ctor
	|-SingletonProcInst<MovieSequence>..ctor
	|-SingletonProcInst<MyRoomChestSequence>..ctor
	|-SingletonProcInst<MyRoomMovieSequence>..ctor
	|-SingletonProcInst<MyRoomRelianceSequence>..ctor
	|-SingletonProcInst<MyRoomSequence>..ctor
	|-SingletonProcInst<MyRoomSoundSequence>..ctor
	|-SingletonProcInst<MyRoomWakeupSelectSequence>..ctor
	|-SingletonProcInst<MyRoomWakeupSequence>..ctor
	|-SingletonProcInst<object>..ctor
	|-SingletonProcInst<PhotographTopSequence>..ctor
	|-SingletonProcInst<RankingSequence>..ctor
	|-SingletonProcInst<RelayAppearanceSequence>..ctor
	|-SingletonProcInst<RelayAwardSequence>..ctor
	|-SingletonProcInst<RelayReplayToTakeOverSequence>..ctor
	|-SingletonProcInst<RewindSequence>..ctor
	|-SingletonProcInst<RingCleaningSequence>..ctor
	|-SingletonProcInst<RingGachaSequence>..ctor
	|-SingletonProcInst<RingInfo>..ctor
	|-SingletonProcInst<RingListSequence>..ctor
	|-SingletonProcInst<RingSynthesisSequence>..ctor
	|-SingletonProcInst<SaveDataMenuSequence>..ctor
	|-SingletonProcInst<SortieSequence>..ctor
	|-SingletonProcInst<SortieSequenceClassChange>..ctor
	|-SingletonProcInst<SortieSequenceInventory>..ctor
	|-SingletonProcInst<SortieSequenceReliance>..ctor
	|-SingletonProcInst<SortieSequenceRingSelect>..ctor
	|-SingletonProcInst<SortieSequenceSkillEdit>..ctor
	|-SingletonProcInst<SortieSequenceTrade>..ctor
	|-SingletonProcInst<SortieSequenceTroopList>..ctor
	|-SingletonProcInst<SortieSequenceUnitSelect>..ctor
	|-SingletonProcInst<TalkLogSequence>..ctor
	|-SingletonProcInst<TalkSequence>..ctor
	|-SingletonProcInst<TitleSequence>..ctor
	|-SingletonProcInst<TutorialSequence>..ctor
	|-SingletonProcInst<UnitHasItemMaxSequence>..ctor
	|-SingletonProcInst<UnitInfo>..ctor
	|-SingletonProcInst<UnitInfoSequence>..ctor
	|-SingletonProcInst<UnitStatus>..ctor
	|-SingletonProcInst<FieldBgmManager.ProcChangeBgm>..ctor
	|-SingletonProcInst<HubSequence.LastChapterSequence>..ctor
	|-SingletonProcInst<Nex.AutoLogoutFinalize>..ctor
	|-SingletonProcInst<SoundWwise.SoundBankManager>..ctor
	|-SingletonProcInst<TitleSequence.ProcTitleCall>..ctor
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3440700 Offset: 0x3440801 VA: 0x3440700
	|-SingletonProcInst<object>..cctor
	*/
}

