// Namespace: App
public class FieldBgmManager // TypeDefIndex: 13791
{
	// Fields
	public const string GameObjectName = "FieldBgmSndObj";
	private const int FadeInMsec_ChangeBgm = 1000;
	private const int FadeOutMsec_ChangeBgm = 750;
	private const int FadeInMsec_ReturnToNormalBgm = 2000;
	private const int FadeInMsec_SpecialBattleBgm = 1000;
	private const int FadeOutMsec_SpecialBattleBgm = 1000;
	private const int SpecialBattleBgmContinueTurnMax = 2;
	private bool m_isSetPhaseBgm; // 0x10
	private bool[] m_isFirstPhaseChanged; // 0x18
	private SoundManager m_sndMgr; // 0x20
	private GameObject m_gameObject; // 0x28
	private string[] m_handleNameArray; // 0x30
	private string m_prevBgmHandleName; // 0x38
	private string m_curBgmHandleName; // 0x40
	private Dictionary<string, FieldBgmManager.BgmHandle> m_bgmHandleList; // 0x48
	private Dictionary<string, FieldBgmManager.BgmHandle> m_specialCombatBgmHandleList; // 0x50
	private string m_warSituationStateName; // 0x58
	private FieldBgmManager.VolumeFader m_volume; // 0x60
	private string[] m_restoreEventNameArray; // 0x68
	private string m_restoreWarSituationStateName; // 0x70
	private int m_BattleBgmContinueTurn; // 0x78
	private const int NowStreamVersion = 1;

	// Methods

	// RVA: 0x2A1AC10 Offset: 0x2A1AD11 VA: 0x2A1AC10
	public void .ctor(SoundManager sndMgr) { }

	// RVA: 0x2A1B040 Offset: 0x2A1B141 VA: 0x2A1B040
	public bool IsSetPhaseBgm() { }

	// RVA: 0x2A1B050 Offset: 0x2A1B151 VA: 0x2A1B050
	public void Init() { }

	// RVA: 0x2A1B060 Offset: 0x2A1B161 VA: 0x2A1B060
	public void Final(int fadeMsec) { }

	// RVA: 0x2A1ADF0 Offset: 0x2A1AEF1 VA: 0x2A1ADF0
	public void Reset(int fadeMsec, bool isResetRestoreData) { }

	// RVA: 0x2A1B490 Offset: 0x2A1B591 VA: 0x2A1B490
	public void StartSpecialBattleBgmContinueTurn() { }

	// RVA: 0x2A1B510 Offset: 0x2A1B611 VA: 0x2A1B510
	public void SetSpecialBattleBgmContinueTurnForRewind(int turn) { }

	// RVA: 0x2A1B520 Offset: 0x2A1B621 VA: 0x2A1B520
	public void SetPhaseBgm(ChapterData chapter, bool isEncount) { }

	// RVA: 0x2A1BAC0 Offset: 0x2A1BBC1 VA: 0x2A1BAC0
	public void RestorePhaseBgm() { }

	// RVA: 0x2A1B6E0 Offset: 0x2A1B7E1 VA: 0x2A1B6E0
	public bool SetPhaseBgm(string playerBgmEventName, string enemyBgmEventName, string allyBgmEventName) { }

	// RVA: 0x2A1BB00 Offset: 0x2A1BC01 VA: 0x2A1BB00
	public void Serialize(Stream stream) { }

	// RVA: 0x2A1BBB0 Offset: 0x2A1BCB1 VA: 0x2A1BBB0
	public void Deserialize(Stream stream) { }

	// RVA: 0x2A1C570 Offset: 0x2A1C671 VA: 0x2A1C570
	public void Tick() { }

	// RVA: 0x2A1C620 Offset: 0x2A1C721 VA: 0x2A1C620
	public void PlayBgm(Force.Type forceType) { }

	// RVA: 0x2A1C910 Offset: 0x2A1CA11 VA: 0x2A1C910
	public void StopBgm(int fadeMsec) { }

	// RVA: 0x2A1C700 Offset: 0x2A1C801 VA: 0x2A1C700
	public void PauseBgm(int fadeMsec) { }

	// RVA: 0x2A1CAF0 Offset: 0x2A1CBF1 VA: 0x2A1CAF0
	public void ResumeBgm(int fadeMsec) { }

	// RVA: 0x2A1CBD0 Offset: 0x2A1CCD1 VA: 0x2A1CBD0
	public void SetBgmVolume(float vol, int fadeMsec) { }

	// RVA: 0x2A1CBE0 Offset: 0x2A1CCE1 VA: 0x2A1CBE0
	public void ChangeForceType(Force.Type forceType, ProcInst super, bool isTurnElapsed) { }

	// RVA: 0x2A1CE10 Offset: 0x2A1CF11 VA: 0x2A1CE10
	public void ChangeForceTypeImm(Force.Type forceType) { }

	// RVA: 0x2A1CF40 Offset: 0x2A1D041 VA: 0x2A1CF40
	public void PlaySpecialBattleBgm(string eventName) { }

	// RVA: 0x2A1D060 Offset: 0x2A1D161 VA: 0x2A1D060
	public void PauseSpecialBattleBgm(string eventName) { }

	// RVA: 0x2A1D0F0 Offset: 0x2A1D1F1 VA: 0x2A1D0F0
	public void StopSpecialBattleBgm(string eventName) { }

	// RVA: 0x2A1D180 Offset: 0x2A1D281 VA: 0x2A1D180
	public bool IsSpecialBattleBgmExist(string eventName) { }

	// RVA: 0x2A1D210 Offset: 0x2A1D311 VA: 0x2A1D210
	public void SetWarSituationParam(string valueName) { }

	// RVA: 0x2A1D3D0 Offset: 0x2A1D4D1 VA: 0x2A1D3D0
	public void RestoreWarSituationParam() { }

	// RVA: 0x2A1D440 Offset: 0x2A1D541 VA: 0x2A1D440
	public void SetFirstPlayedFlag() { }

	// RVA: 0x2A1B070 Offset: 0x2A1B171 VA: 0x2A1B070
	private void ClearBgm(int fadeMsec) { }

	// RVA: 0x2A1B3A0 Offset: 0x2A1B4A1 VA: 0x2A1B3A0
	private string GetStateGroupName() { }

	// RVA: 0x2A1C7A0 Offset: 0x2A1C8A1 VA: 0x2A1C7A0
	private void PlayBgm(string bgmHandleName) { }

	// RVA: 0x2A1C9B0 Offset: 0x2A1CAB1 VA: 0x2A1C9B0
	private void StopBgm(string bgmHandleName, int fadeMsec) { }

	// RVA: 0x2A1CA50 Offset: 0x2A1CB51 VA: 0x2A1CA50
	private void PauseBgm(string bgmHandleName, int fadeMsec) { }

	// RVA: 0x2A1CB00 Offset: 0x2A1CC01 VA: 0x2A1CB00
	private void ResumeBgm(string bgmHandleName, int fadeMsec, bool isfadeMsecByManual) { }
}

