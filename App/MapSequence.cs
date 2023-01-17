// Namespace: App
internal class MapSequence : ProcSceneSequence<MapSequence> // TypeDefIndex: 12368
{
	// Fields
	private bool m_IsCompleted; // 0x84
	private bool m_IsSortieCancel; // 0x85
	private bool m_IsCallangeFailer; // 0x86
	private List<ResourceHandle> m_PreloadHandles; // 0x88
	private double m_Time; // 0x90

	// Properties
	protected override LoadingManager.Modes LoadingMode { get; }
	protected override int Version { get; }

	// Methods

	// RVA: 0x2794150 Offset: 0x2794251 VA: 0x2794150 Slot: 26
	protected override LoadingManager.Modes get_LoadingMode() { }

	// RVA: 0x2794160 Offset: 0x2794261 VA: 0x2794160 Slot: 9
	protected override void OnCreate() { }

	// RVA: 0x2794980 Offset: 0x2794A81 VA: 0x2794980 Slot: 10
	protected override void OnDispose() { }

	// RVA: 0x2794DA0 Offset: 0x2794EA1 VA: 0x2794DA0 Slot: 15
	protected override void OnShutdown() { }

	// RVA: 0x2794E10 Offset: 0x2794F11 VA: 0x2794E10
	public bool CanAutoSave() { }

	// RVA: 0x2794F40 Offset: 0x2795041 VA: 0x2794F40
	private void TryRestartChapterSave() { }

	// RVA: 0x2795030 Offset: 0x2795131 VA: 0x2795030
	private void TryRestartSortieSave() { }

	// RVA: 0x2795120 Offset: 0x2795221 VA: 0x2795120
	private void Init() { }

	// RVA: 0x2795330 Offset: 0x2795431 VA: 0x2795330
	private void SetupChapter() { }

	// RVA: 0x27956E0 Offset: 0x27957E1 VA: 0x27956E0
	private void LoadScript() { }

	// RVA: 0x2795840 Offset: 0x2795941 VA: 0x2795840
	private void UnloadScript() { }

	// RVA: 0x2795940 Offset: 0x2795A41 VA: 0x2795940
	private void OpeningEvent() { }

	// RVA: 0x2795A10 Offset: 0x2795B11 VA: 0x2795A10
	private void MapOpeningEventForReplay() { }

	// RVA: 0x2795AB0 Offset: 0x2795BB1 VA: 0x2795AB0
	private void SetupFieldA() { }

	// RVA: 0x27960F0 Offset: 0x27961F1 VA: 0x27960F0
	private void SetupFieldB() { }

	// RVA: 0x27963C0 Offset: 0x27964C1 VA: 0x27963C0
	private void PostSetupField() { }

	// RVA: 0x2796990 Offset: 0x2796A91 VA: 0x2796990
	private void LoadDispos() { }

	// RVA: 0x2796D60 Offset: 0x2796E61 VA: 0x2796D60
	private void UnloadDispos() { }

	// RVA: 0x2796D70 Offset: 0x2796E71 VA: 0x2796D70
	private void DisposEvent() { }

	// RVA: 0x2796D80 Offset: 0x2796E81 VA: 0x2796D80
	private void DisposUnit() { }

	// RVA: 0x2796FD0 Offset: 0x27970D1 VA: 0x2796FD0
	private void LoadAsyncActor() { }

	// RVA: -1 Offset: -1
	private void AddPreloadCombatAssets<T>(string name) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x295CEA0 Offset: 0x295CFA1 VA: 0x295CEA0
	|-MapSequence.AddPreloadCombatAssets<object>
	|-MapSequence.AddPreloadCombatAssets<Object>
	*/

	// RVA: 0x2797280 Offset: 0x2797381 VA: 0x2797280
	private void AddPreloadCombatAssets(AssetTable.Result result) { }

	// RVA: 0x2797400 Offset: 0x2797501 VA: 0x2797400
	private void PreloadCombatAssets() { }

	// RVA: 0x2797640 Offset: 0x2797741 VA: 0x2797640
	private void LoadMenu() { }

	// RVA: 0x27977B0 Offset: 0x27978B1 VA: 0x27977B0
	private bool IsLoadingMenu() { }

	// RVA: 0x2797980 Offset: 0x2797A81 VA: 0x2797980
	private void UnloadMenu() { }

	// RVA: 0x2797AF0 Offset: 0x2797BF1 VA: 0x2797AF0
	private bool IsLoading() { }

	// RVA: 0x2797CA0 Offset: 0x2797DA1 VA: 0x2797CA0
	private void SetupViewMode() { }

	// RVA: 0x2797D00 Offset: 0x2797E01 VA: 0x2797D00
	private void SetupMap() { }

	// RVA: 0x2798830 Offset: 0x2798931 VA: 0x2798830
	private void CommitTemporary() { }

	// RVA: 0x2798890 Offset: 0x2798991 VA: 0x2798890
	private void ResumeBranch() { }

	// RVA: 0x27989C0 Offset: 0x2798AC1 VA: 0x27989C0
	private void UnloadActor() { }

	// RVA: 0x2798BC0 Offset: 0x2798CC1 VA: 0x2798BC0
	private void UnloadCombatAssets() { }

	// RVA: 0x2798CF0 Offset: 0x2798DF1 VA: 0x2798CF0
	private void CleanupField() { }

	// RVA: 0x2799250 Offset: 0x2799351 VA: 0x2799250
	private void CleanupUnits() { }

	// RVA: 0x2799310 Offset: 0x2799411 VA: 0x2799310
	private void Sortie() { }

	// RVA: 0x2799880 Offset: 0x2799981 VA: 0x2799880
	private void SortieBranch() { }

	// RVA: 0x27994C0 Offset: 0x27995C1 VA: 0x27994C0
	private void PreSortie() { }

	// RVA: 0x279A160 Offset: 0x279A261 VA: 0x279A160
	private void PostSortie() { }

	// RVA: 0x279A940 Offset: 0x279AA41 VA: 0x279A940
	private void MapBegin() { }

	// RVA: 0x279B6A0 Offset: 0x279B7A1 VA: 0x279B6A0
	private void MapHistoryBegin() { }

	// RVA: 0x279B710 Offset: 0x279B811 VA: 0x279B710
	private void PostMapBegin() { }

	// RVA: 0x279B860 Offset: 0x279B961 VA: 0x279B860
	private void MapEnd() { }

	// RVA: 0x279CC80 Offset: 0x279CD81 VA: 0x279CC80
	private void TurnBegin() { }

	// RVA: 0x279D0B0 Offset: 0x279D1B1 VA: 0x279D0B0
	private void TurnEvent() { }

	// RVA: 0x279D150 Offset: 0x279D251 VA: 0x279D150
	private void TurnBeginAfter() { }

	[IteratorStateMachineAttribute] // RVA: 0x2C82B0 Offset: 0x2C83B1 VA: 0x2C82B0
	// RVA: 0x279D570 Offset: 0x279D671 VA: 0x279D570
	private IEnumerator TurnBeginMultiChange() { }

	// RVA: 0x279D5F0 Offset: 0x279D6F1 VA: 0x279D5F0
	private void TryWaitTime(float time) { }

	// RVA: 0x279D630 Offset: 0x279D731 VA: 0x279D630
	private void TurnAfterEvent() { }

	// RVA: 0x279D6D0 Offset: 0x279D7D1 VA: 0x279D6D0
	private void TurnEndEvent() { }

	// RVA: 0x279D770 Offset: 0x279D871 VA: 0x279D770
	private int GetUnderRoofUnitCount(Force.Type force) { }

	// RVA: 0x279DAE0 Offset: 0x279DBE1 VA: 0x279DAE0
	private void TurnSkip() { }

	// RVA: 0x2798390 Offset: 0x2798491 VA: 0x2798390
	private Unit GetFirstUnit() { }

	// RVA: 0x279DD90 Offset: 0x279DE91 VA: 0x279DD90
	private void TurnAction() { }

	// RVA: 0x279DE70 Offset: 0x279DF71 VA: 0x279DE70
	private void TurnEffect() { }

	// RVA: 0x279DF90 Offset: 0x279E091 VA: 0x279DF90
	private void TurnEntrust() { }

	// RVA: 0x279E070 Offset: 0x279E171 VA: 0x279E070
	private void AutoSave() { }

	// RVA: 0x279E0C0 Offset: 0x279E1C1 VA: 0x279E0C0
	private void TurnBranch() { }

	// RVA: 0x279E200 Offset: 0x279E301 VA: 0x279E200
	private void HumanStart() { }

	// RVA: 0x279E270 Offset: 0x279E371 VA: 0x279E270
	private void PostHumanAIBranch() { }

	// RVA: 0x279E7A0 Offset: 0x279E8A1 VA: 0x279E7A0
	private void ReplayStart() { }

	// RVA: 0x279E800 Offset: 0x279E901 VA: 0x279E800
	private void TurnEnd() { }

	// RVA: 0x279EB90 Offset: 0x279EC91 VA: 0x279EB90
	private void TurnNext() { }

	// RVA: 0x279EC10 Offset: 0x279ED11 VA: 0x279EC10
	private void GameEndBranch() { }

	// RVA: 0x279EE70 Offset: 0x279EF71 VA: 0x279EE70
	private void UpdateReliance() { }

	// RVA: 0x279EE80 Offset: 0x279EF81 VA: 0x279EE80
	private void CreateCompleteTelop() { }

	// RVA: 0x279EF50 Offset: 0x279F051 VA: 0x279EF50
	private void Complete() { }

	// RVA: 0x279F4E0 Offset: 0x279F5E1 VA: 0x279F4E0
	private void GetEncountReward() { }

	// RVA: 0x279F710 Offset: 0x279F811 VA: 0x279F710
	private void TryEnding() { }

	// RVA: 0x279F800 Offset: 0x279F901 VA: 0x279F800
	private void TryChallengeResult() { }

	// RVA: 0x279FFB0 Offset: 0x27A00B1 VA: 0x279FFB0
	private void TryRestartMapResult() { }

	// RVA: 0x27A0280 Offset: 0x27A0381 VA: 0x27A0280
	private void GameOver() { }

	// RVA: 0x27A05E0 Offset: 0x27A06E1 VA: 0x27A05E0
	private void TryRestart() { }

	// RVA: 0x27A07A0 Offset: 0x27A08A1 VA: 0x27A07A0
	private void SaveDataLoad() { }

	// RVA: 0x27A0880 Offset: 0x27A0981 VA: 0x27A0880
	private void SaveDataLoadResult() { }

	// RVA: 0x27A0A50 Offset: 0x27A0B51 VA: 0x27A0A50
	private void SaveDataRelease() { }

	// RVA: 0x27A0B20 Offset: 0x27A0C21 VA: 0x27A0B20
	private void SaveDataNormalize() { }

	// RVA: 0x27A0B30 Offset: 0x27A0C31 VA: 0x27A0B30
	private bool TryRestart(GameUserRestartData.Targtes target) { }

	// RVA: 0x27A0BE0 Offset: 0x27A0CE1 VA: 0x27A0BE0
	private void SaveDataAfter() { }

	// RVA: 0x27A0D50 Offset: 0x27A0E51 VA: 0x27A0D50
	private void RestartLoad() { }

	// RVA: 0x279C0A0 Offset: 0x279C1A1 VA: 0x279C0A0
	private void UnitContienud() { }

	// RVA: 0x279C570 Offset: 0x279C671 VA: 0x279C570
	private void UnitResurrect() { }

	// RVA: 0x27A0DA0 Offset: 0x27A0EA1 VA: 0x27A0DA0
	private void BeginSilentEnv() { }

	// RVA: 0x27A0E10 Offset: 0x27A0F11 VA: 0x27A0E10
	private void EndSilentEnv() { }

	// RVA: 0x27A0E80 Offset: 0x27A0F81 VA: 0x27A0E80
	private void Download() { }

	// RVA: 0x27A0ED0 Offset: 0x27A0FD1 VA: 0x27A0ED0
	private void PutBonus() { }

	// RVA: 0x27A1150 Offset: 0x27A1251 VA: 0x27A1150
	private void Upload() { }

	// RVA: 0x27A1160 Offset: 0x27A1261 VA: 0x27A1160
	private void RankingRegisterUnit() { }

	// RVA: 0x27A1200 Offset: 0x27A1301 VA: 0x27A1200
	private void VersusRegisterUnit() { }

	// RVA: 0x27A12D0 Offset: 0x27A13D1 VA: 0x27A12D0
	private void RelayLoad() { }

	// RVA: 0x27A1530 Offset: 0x27A1631 VA: 0x27A1530
	private void RelayLoadError() { }

	// RVA: 0x27A15C0 Offset: 0x27A16C1 VA: 0x27A15C0
	private void RelayShowReplayPlayerName() { }

	// RVA: 0x27A1690 Offset: 0x27A1791 VA: 0x27A1690
	private void RelayHideReplayPlayerName() { }

	// RVA: 0x27A16A0 Offset: 0x27A17A1 VA: 0x27A16A0
	private void RelayMessageShow() { }

	// RVA: 0x27A18C0 Offset: 0x27A19C1 VA: 0x27A18C0
	private void RelayShowWinRuleForTakeOver() { }

	// RVA: 0x27A1A90 Offset: 0x27A1B91 VA: 0x27A1A90
	private void RelaySkipReplay() { }

	// RVA: 0x27A1BB0 Offset: 0x27A1CB1 VA: 0x27A1BB0
	private void RelayReplayToTakeOver() { }

	// RVA: 0x2794880 Offset: 0x2794981 VA: 0x2794880
	private bool IsRelay() { }

	// RVA: 0x279A890 Offset: 0x279A991 VA: 0x279A890
	private bool IsChallenge() { }

	// RVA: 0x27A1C60 Offset: 0x27A1D61 VA: 0x27A1C60
	private void VersusLoad() { }

	// RVA: 0x27A1DB0 Offset: 0x27A1EB1 VA: 0x27A1DB0
	private void VersusBranch() { }

	// RVA: 0x27A2060 Offset: 0x27A2161 VA: 0x27A2060
	private void StartMapEdit() { }

	// RVA: 0x2794900 Offset: 0x2794A01 VA: 0x2794900
	private bool IsVersus() { }

	// RVA: 0x27A20D0 Offset: 0x27A21D1 VA: 0x27A20D0 Slot: 8
	protected override void OnPersistent() { }

	// RVA: 0x27A21D0 Offset: 0x27A22D1 VA: 0x27A21D0 Slot: 17
	public override string GetDebugLog() { }

	// RVA: 0x27A22A0 Offset: 0x27A23A1 VA: 0x27A22A0 Slot: 18
	protected override int get_Version() { }

	// RVA: 0x27A22B0 Offset: 0x27A23B1 VA: 0x27A22B0 Slot: 20
	protected override void OnSerialize(Stream stream) { }

	// RVA: 0x27A2690 Offset: 0x27A2791 VA: 0x27A2690 Slot: 21
	protected override void OnDeserialize(Stream stream, int version) { }

	// RVA: 0x27A2AE0 Offset: 0x27A2BE1 VA: 0x27A2AE0
	public static void CreateBind(ProcInst super) { }

	// RVA: 0x27A2B40 Offset: 0x27A2C41 VA: 0x27A2B40
	private void TimerStart() { }

	// RVA: 0x27A2BB0 Offset: 0x27A2CB1 VA: 0x27A2BB0
	private void TimerStopActor() { }

	// RVA: 0x27A2C00 Offset: 0x27A2D01 VA: 0x27A2C00
	private void TimerStopCharacter() { }

	// RVA: 0x27A2BF0 Offset: 0x27A2CF1 VA: 0x27A2BF0
	private void TimerStop(string name) { }

	// RVA: 0x27A2C40 Offset: 0x27A2D41 VA: 0x27A2C40
	private void TryGameOverRewind() { }

	// RVA: 0x27A2CE0 Offset: 0x27A2DE1 VA: 0x27A2CE0
	private void StopBgm() { }

	// RVA: -1 Offset: -1
	public static void CreateBind<T>(ProcInst super) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x295D110 Offset: 0x295D211 VA: 0x295D110
	|-MapSequence.CreateBind<MapSequence>
	|-MapSequence.CreateBind<object>
	*/

	// RVA: 0x27A2D50 Offset: 0x27A2E51 VA: 0x27A2D50
	private static void TryResume(ProcInst p) { }

	// RVA: 0x27A2FC0 Offset: 0x27A30C1 VA: 0x27A2FC0
	public void .ctor() { }
}

