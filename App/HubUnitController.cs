// Namespace: App
public class HubUnitController : MonoBehaviour // TypeDefIndex: 10816
{
	// Fields
	private float m_HomeDir; // 0x18
	private Vector3 m_HomePosition; // 0x1C
	private Vector3 m_TalkHeadPosition; // 0x28
	private float m_CharacterHeight; // 0x34
	private InterpolatorRotationCurve m_Dir; // 0x38
	private InterpolatorVector3 m_Move; // 0x40
	private HubPlayerController m_PlayerController; // 0x48
	private TalkCharacterController m_TalkCharacterController; // 0x50
	private HubAccess m_Access; // 0x58
	private Character m_Character; // 0x60
	private HubRangeAction m_SoundAction; // 0x68
	private HubRangeAction m_LookAction; // 0x70
	private HubMoveController m_MoveController; // 0x78
	private HubLookAtController m_LookAt; // 0x80
	private Coroutine m_EnableFadeDelay; // 0x88
	private bool m_ReserveReset; // 0x90
	private float m_ReserveResetTime; // 0x94
	private float m_OutRangeTime; // 0x98
	[CompilerGeneratedAttribute] // RVA: 0x295390 Offset: 0x295491 VA: 0x295390
	private readonly float <TurnBlendTime>k__BackingField; // 0x9C
	private string m_WaitAnimName; // 0xA0
	private string m_TalkDefaultAnimName; // 0xA8
	[CompilerGeneratedAttribute] // RVA: 0x2953A0 Offset: 0x2954A1 VA: 0x2953A0
	private bool <IsStop>k__BackingField; // 0xB0
	[CompilerGeneratedAttribute] // RVA: 0x2953B0 Offset: 0x2954B1 VA: 0x2953B0
	private bool <IsPlayer>k__BackingField; // 0xB1
	private Vector3 m_OldHeadPosition; // 0xB4
	private Vector3 m_CenterPosition; // 0xC0
	[CompilerGeneratedAttribute] // RVA: 0x2953C0 Offset: 0x2954C1 VA: 0x2953C0
	private List<GameObject> <BindObject>k__BackingField; // 0xD0
	[CompilerGeneratedAttribute] // RVA: 0x2953D0 Offset: 0x2954D1 VA: 0x2953D0
	private bool <IsLockDir>k__BackingField; // 0xD8

	// Properties
	private float TurnBlendTime { get; }
	public bool IsStop { get; set; }
	public bool IsPlayer { get; set; }
	public bool IsMoveType { get; }
	public Character Character { get; }
	public TalkCharacterController TalkCharacter { get; }
	public HubAccess Access { get; }
	public string PID { get; }
	public string VoiceID { get; }
	public InterpolatorRotationCurve Dir { get; }
	public HubLookAtController LookAt { get; }
	public HubRangeAction LookAction { get; }
	public List<GameObject> BindObject { get; set; }
	public bool IsLockDir { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2C1990 Offset: 0x2C1A91 VA: 0x2C1990
	// RVA: 0x2D47060 Offset: 0x2D47161 VA: 0x2D47060
	private float get_TurnBlendTime() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C19A0 Offset: 0x2C1AA1 VA: 0x2C19A0
	// RVA: 0x2D47070 Offset: 0x2D47171 VA: 0x2D47070
	public bool get_IsStop() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C19B0 Offset: 0x2C1AB1 VA: 0x2C19B0
	// RVA: 0x2D47080 Offset: 0x2D47181 VA: 0x2D47080
	public void set_IsStop(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C19C0 Offset: 0x2C1AC1 VA: 0x2C19C0
	// RVA: 0x2D47090 Offset: 0x2D47191 VA: 0x2D47090
	public bool get_IsPlayer() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C19D0 Offset: 0x2C1AD1 VA: 0x2C19D0
	// RVA: 0x2D470A0 Offset: 0x2D471A1 VA: 0x2D470A0
	public void set_IsPlayer(bool value) { }

	// RVA: 0x2D470B0 Offset: 0x2D471B1 VA: 0x2D470B0
	public bool get_IsMoveType() { }

	// RVA: 0x2D470C0 Offset: 0x2D471C1 VA: 0x2D470C0
	public Character get_Character() { }

	// RVA: 0x2D470D0 Offset: 0x2D471D1 VA: 0x2D470D0
	public TalkCharacterController get_TalkCharacter() { }

	// RVA: 0x2D470E0 Offset: 0x2D471E1 VA: 0x2D470E0
	public HubAccess get_Access() { }

	// RVA: 0x2D470F0 Offset: 0x2D471F1 VA: 0x2D470F0
	public string get_PID() { }

	// RVA: 0x2D47100 Offset: 0x2D47201 VA: 0x2D47100
	public string get_VoiceID() { }

	// RVA: 0x2D47130 Offset: 0x2D47231 VA: 0x2D47130
	public InterpolatorRotationCurve get_Dir() { }

	// RVA: 0x2D47140 Offset: 0x2D47241 VA: 0x2D47140
	public HubLookAtController get_LookAt() { }

	// RVA: 0x2D47150 Offset: 0x2D47251 VA: 0x2D47150
	public HubRangeAction get_LookAction() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C19E0 Offset: 0x2C1AE1 VA: 0x2C19E0
	// RVA: 0x2D47160 Offset: 0x2D47261 VA: 0x2D47160
	public List<GameObject> get_BindObject() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C19F0 Offset: 0x2C1AF1 VA: 0x2C19F0
	// RVA: 0x2D47170 Offset: 0x2D47271 VA: 0x2D47170
	public void set_BindObject(List<GameObject> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C1A00 Offset: 0x2C1B01 VA: 0x2C1A00
	// RVA: 0x2D47180 Offset: 0x2D47281 VA: 0x2D47180
	public bool get_IsLockDir() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C1A10 Offset: 0x2C1B11 VA: 0x2C1A10
	// RVA: 0x2D47190 Offset: 0x2D47291 VA: 0x2D47190
	public void set_IsLockDir(bool value) { }

	// RVA: 0x2D471A0 Offset: 0x2D472A1 VA: 0x2D471A0
	public bool IsTurnEnd(float marginAngle = 0.1) { }

	// RVA: 0x2D471E0 Offset: 0x2D472E1 VA: 0x2D471E0
	public bool InPlayerRange(float range = 3) { }

	// RVA: 0x2D472F0 Offset: 0x2D473F1 VA: 0x2D472F0
	public void SetPlayerController(HubPlayerController playerController) { }

	// RVA: 0x2D47300 Offset: 0x2D47401 VA: 0x2D47300
	public void SetTalkCharaController(TalkCharacterController talkCharaController) { }

	// RVA: 0x2D47460 Offset: 0x2D47561 VA: 0x2D47460
	public void SetCharacter(Character chara) { }

	// RVA: 0x2D47470 Offset: 0x2D47571 VA: 0x2D47470
	public void SetAccess(HubAccess access) { }

	// RVA: 0x2D47480 Offset: 0x2D47581 VA: 0x2D47480
	public void SetDir(float dir) { }

	// RVA: 0x2D47490 Offset: 0x2D47591 VA: 0x2D47490
	public float GetNowDir() { }

	// RVA: 0x2D474E0 Offset: 0x2D475E1 VA: 0x2D474E0
	public void SetHomeDir(float homeDir) { }

	// RVA: 0x2D474F0 Offset: 0x2D475F1 VA: 0x2D474F0
	public float GetHomeDir() { }

	// RVA: 0x2D47500 Offset: 0x2D47601 VA: 0x2D47500
	public void SetHomePosition(Vector3 homePosition) { }

	// RVA: 0x2D47510 Offset: 0x2D47611 VA: 0x2D47510
	public Vector3 GetHomePosition() { }

	// RVA: 0x2D47520 Offset: 0x2D47621 VA: 0x2D47520
	public void Stop() { }

	// RVA: 0x2D47530 Offset: 0x2D47631 VA: 0x2D47530
	public void Restart() { }

	// RVA: 0x2D47540 Offset: 0x2D47641 VA: 0x2D47540
	public void SetActiveBind(bool active) { }

	// RVA: 0x2D47660 Offset: 0x2D47761 VA: 0x2D47660
	public void LookTo(Vector3 target, float time = 0, bool withTurnAnim = False) { }

	// RVA: 0x2D47840 Offset: 0x2D47941 VA: 0x2D47840
	public bool LookTo(float dir, float time = 0, bool withTurnAnim = False) { }

	// RVA: 0x2D47890 Offset: 0x2D47991 VA: 0x2D47890
	public void ResetLook(float time = 0) { }

	// RVA: 0x2D478B0 Offset: 0x2D479B1 VA: 0x2D478B0
	public void ReserveReset(float time = 0) { }

	// RVA: 0x2D478D0 Offset: 0x2D479D1 VA: 0x2D478D0
	public void CancelReserveReset() { }

	// RVA: 0x2D47730 Offset: 0x2D47831 VA: 0x2D47730
	public bool PlayTurn() { }

	// RVA: 0x2D478E0 Offset: 0x2D479E1 VA: 0x2D478E0
	public void MoveTo(Vector3 pos, float time = 0) { }

	// RVA: 0x2D479B0 Offset: 0x2D47AB1 VA: 0x2D479B0
	public void ResetAnimatoin() { }

	// RVA: 0x2D47350 Offset: 0x2D47451 VA: 0x2D47350
	public string GetWaitAnimationName() { }

	// RVA: 0x2D47A00 Offset: 0x2D47B01 VA: 0x2D47A00
	public void SetWaitAnimationName(string animName) { }

	// RVA: 0x2D47A10 Offset: 0x2D47B11 VA: 0x2D47A10
	public string GetWaitFaceAnimationName() { }

	// RVA: 0x2D47AF0 Offset: 0x2D47BF1 VA: 0x2D47AF0
	public void WaitAnimation(float transitionDuration = 1) { }

	// RVA: 0x2D47B70 Offset: 0x2D47C71 VA: 0x2D47B70
	public Transform GetHeadTransform() { }

	// RVA: 0x2D47BB0 Offset: 0x2D47CB1 VA: 0x2D47BB0
	public Vector3 GetTalkHeadPosition() { }

	// RVA: 0x2D47C80 Offset: 0x2D47D81 VA: 0x2D47C80
	public void PlayVoice(string eventName) { }

	// RVA: 0x2D47E40 Offset: 0x2D47F41 VA: 0x2D47E40
	public float GetPlayerDistance() { }

	// RVA: 0x2D47EE0 Offset: 0x2D47FE1 VA: 0x2D47EE0
	public Vector3 GetPlayerDirection() { }

	// RVA: 0x2D47F80 Offset: 0x2D48081 VA: 0x2D47F80
	public void StartTalk(Vector3 target) { }

	// RVA: 0x2D483F0 Offset: 0x2D484F1 VA: 0x2D483F0
	public void EndTalk() { }

	// RVA: 0x2D48340 Offset: 0x2D48441 VA: 0x2D48340
	public void DisableFade() { }

	// RVA: 0x2D48670 Offset: 0x2D48771 VA: 0x2D48670
	public void EnableFade() { }

	[IteratorStateMachineAttribute] // RVA: 0x2C1A20 Offset: 0x2C1B21 VA: 0x2C1A20
	// RVA: 0x2D485F0 Offset: 0x2D486F1 VA: 0x2D485F0
	private IEnumerator EnableFadeDelay() { }

	// RVA: 0x2D48740 Offset: 0x2D48841 VA: 0x2D48740
	public void PlayBody(string name, float transitionDuration = 1, bool soon = False, bool force = False) { }

	// RVA: 0x2D48900 Offset: 0x2D48A01 VA: 0x2D48900
	public void PlayFace(string name, bool isFastForward = False) { }

	// RVA: 0x2D48910 Offset: 0x2D48A11 VA: 0x2D48910
	public void ResetBody() { }

	// RVA: 0x2D489E0 Offset: 0x2D48AE1 VA: 0x2D489E0
	private bool IsEnableVoice() { }

	// RVA: 0x2D48B00 Offset: 0x2D48C01 VA: 0x2D48B00
	private void Start() { }

	// RVA: 0x2D48F80 Offset: 0x2D49081 VA: 0x2D48F80
	private void Update() { }

	// RVA: 0x2D493F0 Offset: 0x2D494F1 VA: 0x2D493F0
	private void LateUpdate() { }

	// RVA: 0x2D494D0 Offset: 0x2D495D1 VA: 0x2D494D0
	private void OnDrawGizmos() { }

	// RVA: 0x2D495E0 Offset: 0x2D496E1 VA: 0x2D495E0
	public void ResetLookAt() { }

	// RVA: 0x2D496A0 Offset: 0x2D497A1 VA: 0x2D496A0
	public void SetupIdle() { }

	// RVA: 0x2D49210 Offset: 0x2D49311 VA: 0x2D49210
	private void UpdateRange() { }

	// RVA: 0x2D492C0 Offset: 0x2D493C1 VA: 0x2D492C0
	private void UpdateMove(bool force) { }

	// RVA: 0x2D49EA0 Offset: 0x2D49FA1 VA: 0x2D49EA0
	public void .ctor() { }
}

