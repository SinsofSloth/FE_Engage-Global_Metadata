// Namespace: App
public class MapSituation : SingletonClass<MapSituation> // TypeDefIndex: 12221
{
	// Fields
	public const int TurnMax = 999;
	private MapSituation.StatusField m_Status; // 0x20
	private MapSituation.Player[] m_Players; // 0x28
	private Force.Type[] m_Groups; // 0x30
	private Force.Type m_CurrentForceType; // 0x38
	private Force.Type m_HumanForceType; // 0x3C
	private MapSituation.ForceCursor[] m_ForceCursors; // 0x40
	private int m_Turn; // 0x48
	private MapSituation.SubPhases m_SubPhase; // 0x4C
	private int m_WinRuleEnemyNumLessThanOrEqualTo; // 0x50
	private int m_WinRuleLimitTurn; // 0x54
	private WinLoseRule m_WinLoseResult; // 0x58
	private UnitEntrust.Type m_Entrust; // 0x5C
	private string m_WinRuleMID; // 0x60
	private string m_WinRuleMIDArg; // 0x68
	private string m_LoseRuleMID; // 0x70
	private string m_LoseRuleMIDArg; // 0x78
	private int m_AverageLevel; // 0x80

	// Properties
	protected override int Version { get; }
	public MapSituation.Player CurrentPlayer { get; }
	public Force.Type CurrentForceType { get; set; }
	public Force.Type HumanForceType { get; set; }
	public Force.Type HeroForceType { get; }
	public int Turn { get; set; }
	public MapSituation.SubPhases SubPhase { get; }
	public int WinRuleEnemyNumLessThanOrEqualTo { get; set; }
	public int WinRuleLimitTurn { get; set; }
	public WinLoseRule WinLoseResult { get; }
	public UnitEntrust.Type Entrust { get; set; }
	public string WinRuleMID { get; set; }
	public string WinRuleMIDArg { get; set; }
	public string LoseRuleMID { get; set; }
	public string LoseRuleMIDArg { get; set; }
	public int AverageLevel { get; set; }

	// Methods

	// RVA: 0x271E2A0 Offset: 0x271E3A1 VA: 0x271E2A0
	public void .ctor() { }

	// RVA: 0x271E5A0 Offset: 0x271E6A1 VA: 0x271E5A0
	public MapSituation.StatusField GetStatus() { }

	// RVA: 0x26FB840 Offset: 0x26FB941 VA: 0x26FB840
	public void SetStatus(MapSituation.Status status) { }

	// RVA: 0x26FF6D0 Offset: 0x26FF7D1 VA: 0x26FF6D0
	public void ClearStatus(MapSituation.Status status) { }

	// RVA: 0x2707640 Offset: 0x2707741 VA: 0x2707640
	public bool CheckStatus(MapSituation.Status status) { }

	// RVA: 0x27075D0 Offset: 0x27076D1 VA: 0x27075D0
	public bool NotStatus(MapSituation.Status status) { }

	// RVA: 0x271E5B0 Offset: 0x271E6B1 VA: 0x271E5B0
	public void SetPlayer(Force.Type forceType, MapSituation.Player player) { }

	// RVA: 0x271E5F0 Offset: 0x271E6F1 VA: 0x271E5F0
	public MapSituation.Player GetPlayer(Force.Type forceType) { }

	// RVA: 0x271E640 Offset: 0x271E741 VA: 0x271E640
	public void SetGroup(Force.Type forceType, Force.Type group) { }

	// RVA: 0x271E680 Offset: 0x271E781 VA: 0x271E680
	public Force.Type GetGroup(Force.Type forceType) { }

	// RVA: 0x271E6D0 Offset: 0x271E7D1 VA: 0x271E6D0
	public bool IsAllide(Force.Type force1, Force.Type force2) { }

	// RVA: 0x26FF680 Offset: 0x26FF781 VA: 0x26FF680
	public MapSituation.Player GetCurrentPlayer() { }

	// RVA: 0x271E760 Offset: 0x271E861 VA: 0x271E760
	public Force GetCurrentForce() { }

	// RVA: 0x271E770 Offset: 0x271E871 VA: 0x271E770
	public bool IsHumanPlayer(Force.Type forceType) { }

	// RVA: 0x271E7C0 Offset: 0x271E8C1 VA: 0x271E7C0
	public bool IsHumanPlayer() { }

	// RVA: 0x271E820 Offset: 0x271E921 VA: 0x271E820
	public MapSituation.ForceCursor GetForceCursor(Force.Type forceType) { }

	// RVA: 0x271E870 Offset: 0x271E971 VA: 0x271E870
	public void NextSubPhase() { }

	// RVA: 0x271E890 Offset: 0x271E991 VA: 0x271E890
	public void ResetSubPhase() { }

	// RVA: 0x271E8A0 Offset: 0x271E9A1 VA: 0x271E8A0
	public bool IsCasual() { }

	// RVA: 0x2705E00 Offset: 0x2705F01 VA: 0x2705E00
	public bool IsPhoenix() { }

	// RVA: 0x271E920 Offset: 0x271EA21 VA: 0x271E920
	public bool IsVersus() { }

	// RVA: 0x26FD310 Offset: 0x26FD411 VA: 0x26FD310
	public bool IsRelay() { }

	// RVA: 0x271E9D0 Offset: 0x271EAD1 VA: 0x271E9D0
	public bool IsChallenge() { }

	// RVA: 0x271EA80 Offset: 0x271EB81 VA: 0x271EA80
	public bool IsTrial() { }

	// RVA: 0x271EBE0 Offset: 0x271ECE1 VA: 0x271EBE0
	public bool IsResurrect() { }

	// RVA: 0x271EEF0 Offset: 0x271EFF1 VA: 0x271EEF0
	public bool IsRecordKill(Force.Type forceType) { }

	// RVA: 0x271EF60 Offset: 0x271F061 VA: 0x271EF60
	public bool IsRecordDead(Force.Type forceType) { }

	// RVA: 0x271EFD0 Offset: 0x271F0D1 VA: 0x271EFD0
	public bool IsShowOrder() { }

	// RVA: 0x271F1A0 Offset: 0x271F2A1 VA: 0x271F1A0
	public bool CanOrder() { }

	// RVA: 0x271F1B0 Offset: 0x271F2B1 VA: 0x271F1B0
	public bool IsShowEscape() { }

	// RVA: 0x271F1D0 Offset: 0x271F2D1 VA: 0x271F1D0
	public bool CanEscape() { }

	// RVA: 0x271F1F0 Offset: 0x271F2F1 VA: 0x271F1F0
	public bool CanExistenceDie() { }

	// RVA: 0x271F200 Offset: 0x271F301 VA: 0x271F200
	public bool IsShowTurn() { }

	// RVA: 0x26FF580 Offset: 0x26FF681 VA: 0x26FF580
	public bool IsComplete() { }

	// RVA: 0x26FF480 Offset: 0x26FF581 VA: 0x26FF480
	public bool IsGameOver() { }

	// RVA: 0x271F2A0 Offset: 0x271F3A1 VA: 0x271F2A0
	public bool IsRelayUnsettled() { }

	// RVA: 0x271F3A0 Offset: 0x271F4A1 VA: 0x271F3A0
	public bool IsEntrustAI() { }

	// RVA: 0x271F460 Offset: 0x271F561 VA: 0x271F460
	public bool IsNotReturnMap() { }

	// RVA: 0x271F470 Offset: 0x271F571 VA: 0x271F470
	public bool IsCancelOperation() { }

	// RVA: 0x271F480 Offset: 0x271F581 VA: 0x271F480
	public bool IsErrorOperation() { }

	// RVA: 0x271F490 Offset: 0x271F591 VA: 0x271F490
	public int GetMessageWaitFrame() { }

	// RVA: 0x271F4A0 Offset: 0x271F5A1 VA: 0x271F4A0
	public void TurnEnd() { }

	// RVA: 0x2720000 Offset: 0x2720101 VA: 0x2720000
	public void TurnNext() { }

	// RVA: 0x26FDDB0 Offset: 0x26FDEB1 VA: 0x26FDDB0
	public void GameEndCheck() { }

	// RVA: 0x27200B0 Offset: 0x27201B1 VA: 0x27200B0
	private bool IsLoseUnitDead(Unit unit) { }

	// RVA: 0x2700D80 Offset: 0x2700E81 VA: 0x2700D80
	public bool GameEndCheckUnitDead(Unit unit) { }

	// RVA: 0x271FD20 Offset: 0x271FE21 VA: 0x271FD20
	public void SetComplete(WinLoseRule result) { }

	// RVA: 0x271FA40 Offset: 0x271FB41 VA: 0x271FA40
	public void SetGameOver(WinLoseRule result) { }

	// RVA: 0x271F850 Offset: 0x271F951 VA: 0x271F850
	public void SetRelayUnsettled() { }

	// RVA: 0x2720360 Offset: 0x2720461 VA: 0x2720360 Slot: 4
	protected override int get_Version() { }

	// RVA: 0x2720370 Offset: 0x2720471 VA: 0x2720370 Slot: 11
	protected override void OnSerialize(Stream stream) { }

	// RVA: 0x2720650 Offset: 0x2720751 VA: 0x2720650 Slot: 12
	protected override void OnDeserialize(Stream stream, int version) { }

	// RVA: 0x27216C0 Offset: 0x27217C1 VA: 0x27216C0
	public MapSituation.Player get_CurrentPlayer() { }

	// RVA: 0x2721710 Offset: 0x2721811 VA: 0x2721710
	public Force.Type get_CurrentForceType() { }

	// RVA: 0x2721720 Offset: 0x2721821 VA: 0x2721720
	public void set_CurrentForceType(Force.Type value) { }

	// RVA: 0x2721730 Offset: 0x2721831 VA: 0x2721730
	public Force.Type get_HumanForceType() { }

	// RVA: 0x2721740 Offset: 0x2721841 VA: 0x2721740
	public void set_HumanForceType(Force.Type value) { }

	// RVA: 0x2721750 Offset: 0x2721851 VA: 0x2721750
	public Force.Type get_HeroForceType() { }

	// RVA: 0x2721760 Offset: 0x2721861 VA: 0x2721760
	public int get_Turn() { }

	// RVA: 0x2721770 Offset: 0x2721871 VA: 0x2721770
	public void set_Turn(int value) { }

	// RVA: 0x2721780 Offset: 0x2721881 VA: 0x2721780
	public MapSituation.SubPhases get_SubPhase() { }

	// RVA: 0x2721790 Offset: 0x2721891 VA: 0x2721790
	public int get_WinRuleEnemyNumLessThanOrEqualTo() { }

	// RVA: 0x27217A0 Offset: 0x27218A1 VA: 0x27217A0
	public void set_WinRuleEnemyNumLessThanOrEqualTo(int value) { }

	// RVA: 0x27217B0 Offset: 0x27218B1 VA: 0x27217B0
	public int get_WinRuleLimitTurn() { }

	// RVA: 0x27217C0 Offset: 0x27218C1 VA: 0x27217C0
	public void set_WinRuleLimitTurn(int value) { }

	// RVA: 0x27217D0 Offset: 0x27218D1 VA: 0x27217D0
	public WinLoseRule get_WinLoseResult() { }

	// RVA: 0x27217E0 Offset: 0x27218E1 VA: 0x27217E0
	public UnitEntrust.Type get_Entrust() { }

	// RVA: 0x27217F0 Offset: 0x27218F1 VA: 0x27217F0
	public void set_Entrust(UnitEntrust.Type value) { }

	// RVA: 0x2721800 Offset: 0x2721901 VA: 0x2721800
	public string get_WinRuleMID() { }

	// RVA: 0x2721810 Offset: 0x2721911 VA: 0x2721810
	public void set_WinRuleMID(string value) { }

	// RVA: 0x2721820 Offset: 0x2721921 VA: 0x2721820
	public string get_WinRuleMIDArg() { }

	// RVA: 0x2721830 Offset: 0x2721931 VA: 0x2721830
	public void set_WinRuleMIDArg(string value) { }

	// RVA: 0x2721840 Offset: 0x2721941 VA: 0x2721840
	public string get_LoseRuleMID() { }

	// RVA: 0x2721850 Offset: 0x2721951 VA: 0x2721850
	public void set_LoseRuleMID(string value) { }

	// RVA: 0x2721860 Offset: 0x2721961 VA: 0x2721860
	public string get_LoseRuleMIDArg() { }

	// RVA: 0x2721870 Offset: 0x2721971 VA: 0x2721870
	public void set_LoseRuleMIDArg(string value) { }

	// RVA: 0x2721880 Offset: 0x2721981 VA: 0x2721880
	public int get_AverageLevel() { }

	// RVA: 0x2721890 Offset: 0x2721991 VA: 0x2721890
	public void set_AverageLevel(int value) { }

	// RVA: 0x27218A0 Offset: 0x27219A1 VA: 0x27218A0
	public static string GetWinRuleString() { }

	// RVA: 0x2721B30 Offset: 0x2721C31 VA: 0x2721B30
	public static string GetLoseRuleString() { }

	// RVA: 0x2721D10 Offset: 0x2721E11 VA: 0x2721D10
	private static bool IsHeroLose() { }

	// RVA: 0x2721E00 Offset: 0x2721F01 VA: 0x2721E00
	private static Unit GetHeroUnitForLoseRuleString() { }
}

