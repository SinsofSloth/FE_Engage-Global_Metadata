// Namespace: App.Talk3D
public class TalkCharacterManager : SingletonMonoBehaviour<TalkCharacterManager> // TypeDefIndex: 14124
{
	// Fields
	private const string PositionLocatorName = "Position";
	public float m_FadeTime; // 0x20
	public float m_ChangeLookAtTime; // 0x24
	public bool m_IsPlayFirstTransition; // 0x28
	[RangeAttribute] // RVA: 0x29D9C0 Offset: 0x29DAC1 VA: 0x29D9C0
	[TooltipAttribute] // RVA: 0x29D9C0 Offset: 0x29DAC1 VA: 0x29D9C0
	public float m_VoiceThresholdToLip; // 0x2C
	[RangeAttribute] // RVA: 0x29DA20 Offset: 0x29DB21 VA: 0x29DA20
	[TooltipAttribute] // RVA: 0x29DA20 Offset: 0x29DB21 VA: 0x29DA20
	public float m_VoiceMagnificationToLip; // 0x30
	public float m_PauseChangeCrossFadeTime; // 0x34
	private GameObject m_ModelPoolObject; // 0x38
	private GameObject m_StandPositions; // 0x40
	private GameObject m_StandRoot; // 0x48
	private GameObject m_StandPositionRoot; // 0x50
	private GameObject m_FaceRoot; // 0x58
	private GameObject m_DirectRoot; // 0x60
	private GameObject m_FrameCanvas; // 0x68
	private GameObject m_LookAtTargetRoot; // 0x70
	private GameObject m_TopFaceCameraObject; // 0x78
	private GameObject m_BottomFaceCameraObject; // 0x80
	private List<string> m_LoadPidList; // 0x88

	// Properties
	private Talk.TalkType TalkType { get; }
	private string ActivePid { get; }
	public bool IsPlayFirstTransition { get; }

	// Methods

	// RVA: 0x2C24F10 Offset: 0x2C25011 VA: 0x2C24F10
	private Talk.TalkType get_TalkType() { }

	// RVA: 0x2C24F90 Offset: 0x2C25091 VA: 0x2C24F90
	private string get_ActivePid() { }

	// RVA: 0x2C25010 Offset: 0x2C25111 VA: 0x2C25010
	public bool get_IsPlayFirstTransition() { }

	// RVA: 0x2C25020 Offset: 0x2C25121 VA: 0x2C25020
	private void Start() { }

	// RVA: 0x2C25360 Offset: 0x2C25461 VA: 0x2C25360
	public void SetActiveToChildren(GameObject root, bool isActive) { }

	// RVA: 0x2C25400 Offset: 0x2C25501 VA: 0x2C25400
	public void SetTalkType(Talk.TalkType talkType, string positionsRootName) { }

	// RVA: 0x2C256E0 Offset: 0x2C257E1 VA: 0x2C256E0
	public void PreLoadCharacter(string pid, string pidForCreate) { }

	// RVA: 0x2C259B0 Offset: 0x2C25AB1 VA: 0x2C259B0
	public void CreateCharacter(string pid, string locationName, TalkCharacterManager.onLoad callback) { }

	// RVA: 0x2C262A0 Offset: 0x2C263A1 VA: 0x2C262A0
	private void CreateCharacterImpl(string pid, string locationName, TalkCharacterManager.onLoad callback) { }

	// RVA: 0x2C26900 Offset: 0x2C26A01 VA: 0x2C26900
	private void SetupCharactorForDisplay(string pid, string locationName, Character chara, GameObject locator) { }

	// RVA: 0x2C26CD0 Offset: 0x2C26DD1 VA: 0x2C26CD0
	private void EnableFaceCamera(string locationName) { }

	// RVA: 0x2C26790 Offset: 0x2C26891 VA: 0x2C26790
	private Character SearchFromPool(string pid) { }

	// RVA: 0x2C26E50 Offset: 0x2C26F51 VA: 0x2C26E50
	public void FadeInCharacter(string pid) { }

	// RVA: 0x2C270A0 Offset: 0x2C271A1 VA: 0x2C270A0
	public void FadeOutCharacter(string pid) { }

	// RVA: 0x2C272F0 Offset: 0x2C273F1 VA: 0x2C272F0
	public void DeleteCharacter(string pid) { }

	// RVA: 0x2C276B0 Offset: 0x2C277B1 VA: 0x2C276B0
	public void DeleteAllCharacter() { }

	// RVA: 0x2C274E0 Offset: 0x2C275E1 VA: 0x2C274E0
	private void MoveModelToPool(GameObject charaObj) { }

	// RVA: 0x2C27780 Offset: 0x2C27881 VA: 0x2C27780
	public void Show(string pid) { }

	// RVA: 0x2C279D0 Offset: 0x2C27AD1 VA: 0x2C279D0
	public void Hide(string pid) { }

	// RVA: 0x2C27B00 Offset: 0x2C27C01 VA: 0x2C27B00
	public void ChangeAnimeBody(string pid, string animeName) { }

	// RVA: 0x2C27D60 Offset: 0x2C27E61 VA: 0x2C27D60
	public void ChangeAnimeFace(string pid, string animeName) { }

	// RVA: 0x2C278B0 Offset: 0x2C279B1 VA: 0x2C278B0
	public Character FindCharacter(string pid) { }

	// RVA: 0x2C243B0 Offset: 0x2C244B1 VA: 0x2C243B0
	public string GetCharaLocationName(string pid) { }

	// RVA: 0x2C25DE0 Offset: 0x2C25EE1 VA: 0x2C25DE0
	private GameObject FindLocatorByPID(string pid) { }

	// RVA: 0x2C25C40 Offset: 0x2C25D41 VA: 0x2C25C40
	private GameObject FindLocatorByLocationName(string locationName) { }

	// RVA: 0x2C28030 Offset: 0x2C28131 VA: 0x2C28030
	public static bool IsFading() { }

	// RVA: 0x2C26780 Offset: 0x2C26881 VA: 0x2C26780
	public static string PidToPidForCreate(string pid) { }

	// RVA: 0x2C282A0 Offset: 0x2C283A1 VA: 0x2C282A0
	public void .ctor() { }
}

