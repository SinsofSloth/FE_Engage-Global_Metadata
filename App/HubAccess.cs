// Namespace: App
public class HubAccess : MonoBehaviour // TypeDefIndex: 10641
{
	// Fields
	[SerializeField] // RVA: 0x293070 Offset: 0x293171 VA: 0x293070
	public string AID; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x293080 Offset: 0x293181 VA: 0x293080
	private Transform <PlayerTransform>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x293090 Offset: 0x293191 VA: 0x293090
	private Transform <TargetTransform>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x2930A0 Offset: 0x2931A1 VA: 0x2930A0
	private Vector3 <HelpOffset>k__BackingField; // 0x30
	[CompilerGeneratedAttribute] // RVA: 0x2930B0 Offset: 0x2931B1 VA: 0x2930B0
	private bool <IsWall>k__BackingField; // 0x3C
	[CompilerGeneratedAttribute] // RVA: 0x2930C0 Offset: 0x2931C1 VA: 0x2930C0
	private Vector3 <OrigPosition>k__BackingField; // 0x40
	[CompilerGeneratedAttribute] // RVA: 0x2930D0 Offset: 0x2931D1 VA: 0x2930D0
	private Quaternion <OrigRotation>k__BackingField; // 0x4C
	private HubAccessData m_accessData; // 0x60
	[CompilerGeneratedAttribute] // RVA: 0x2930E0 Offset: 0x2931E1 VA: 0x2930E0
	private GameObject <ItemEffect>k__BackingField; // 0x68
	[CompilerGeneratedAttribute] // RVA: 0x2930F0 Offset: 0x2931F1 VA: 0x2930F0
	private GameObject <AccessCursorObject>k__BackingField; // 0x70
	[CompilerGeneratedAttribute] // RVA: 0x293100 Offset: 0x293201 VA: 0x293100
	private HubAccessCursor <AccessCursor>k__BackingField; // 0x78

	// Properties
	public Transform PlayerTransform { get; set; }
	public Transform TargetTransform { get; set; }
	public Vector3 HelpOffset { get; set; }
	public string MID { get; }
	public HubDisposData DisposData { get; }
	public bool IsAvailable { get; }
	public bool IsStory { get; }
	public bool IsReliance { get; }
	public bool IsGod { get; }
	public bool IsUnit { get; }
	public bool IsPerson { get; }
	public bool IsAnimal { get; }
	public bool IsAccessEnabled { get; }
	public bool IsAccessed { get; }
	public bool IsDone { get; }
	public bool IsWall { get; set; }
	public int ResultTalkIndex { get; }
	public bool IsHeroBirthday { get; }
	public int AccessCount { get; }
	public string TalkItem { get; }
	public int ItemCount { get; }
	public Vector3 OrigPosition { get; set; }
	public Quaternion OrigRotation { get; set; }
	private GameObject ItemEffect { get; set; }
	private GameObject AccessCursorObject { get; set; }
	private HubAccessCursor AccessCursor { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2BFFD0 Offset: 0x2C00D1 VA: 0x2BFFD0
	// RVA: 0x2668230 Offset: 0x2668331 VA: 0x2668230
	public Transform get_PlayerTransform() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BFFE0 Offset: 0x2C00E1 VA: 0x2BFFE0
	// RVA: 0x2668240 Offset: 0x2668341 VA: 0x2668240
	public void set_PlayerTransform(Transform value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BFFF0 Offset: 0x2C00F1 VA: 0x2BFFF0
	// RVA: 0x2668250 Offset: 0x2668351 VA: 0x2668250
	public Transform get_TargetTransform() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C0000 Offset: 0x2C0101 VA: 0x2C0000
	// RVA: 0x2668260 Offset: 0x2668361 VA: 0x2668260
	public void set_TargetTransform(Transform value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C0010 Offset: 0x2C0111 VA: 0x2C0010
	// RVA: 0x2668270 Offset: 0x2668371 VA: 0x2668270
	public Vector3 get_HelpOffset() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C0020 Offset: 0x2C0121 VA: 0x2C0020
	// RVA: 0x2668280 Offset: 0x2668381 VA: 0x2668280
	public void set_HelpOffset(Vector3 value) { }

	// RVA: 0x2668290 Offset: 0x2668391 VA: 0x2668290
	public string get_MID() { }

	// RVA: 0x26683F0 Offset: 0x26684F1 VA: 0x26683F0
	public HubDisposData get_DisposData() { }

	// RVA: 0x2668410 Offset: 0x2668511 VA: 0x2668410
	public bool get_IsAvailable() { }

	// RVA: 0x2668420 Offset: 0x2668521 VA: 0x2668420
	public bool get_IsStory() { }

	// RVA: 0x2668430 Offset: 0x2668531 VA: 0x2668430
	public bool get_IsReliance() { }

	// RVA: 0x2668440 Offset: 0x2668541 VA: 0x2668440
	public bool get_IsGod() { }

	// RVA: 0x2668450 Offset: 0x2668551 VA: 0x2668450
	public bool get_IsUnit() { }

	// RVA: 0x2668460 Offset: 0x2668561 VA: 0x2668460
	public bool get_IsPerson() { }

	// RVA: 0x2668470 Offset: 0x2668571 VA: 0x2668470
	public bool get_IsAnimal() { }

	// RVA: 0x2668480 Offset: 0x2668581 VA: 0x2668480
	public bool get_IsAccessEnabled() { }

	// RVA: 0x2668520 Offset: 0x2668621 VA: 0x2668520
	public bool get_IsAccessed() { }

	// RVA: 0x2668730 Offset: 0x2668831 VA: 0x2668730
	public bool get_IsDone() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C0030 Offset: 0x2C0131 VA: 0x2C0030
	// RVA: 0x2668860 Offset: 0x2668961 VA: 0x2668860
	public bool get_IsWall() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C0040 Offset: 0x2C0141 VA: 0x2C0040
	// RVA: 0x2668870 Offset: 0x2668971 VA: 0x2668870
	public void set_IsWall(bool value) { }

	// RVA: 0x2668880 Offset: 0x2668981 VA: 0x2668880
	public int get_ResultTalkIndex() { }

	// RVA: 0x2668890 Offset: 0x2668991 VA: 0x2668890
	public bool get_IsHeroBirthday() { }

	// RVA: 0x26688A0 Offset: 0x26689A1 VA: 0x26688A0
	public int get_AccessCount() { }

	// RVA: 0x2668A90 Offset: 0x2668B91 VA: 0x2668A90
	public string get_TalkItem() { }

	// RVA: 0x2668AA0 Offset: 0x2668BA1 VA: 0x2668AA0
	public int get_ItemCount() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C0050 Offset: 0x2C0151 VA: 0x2C0050
	// RVA: 0x2668AB0 Offset: 0x2668BB1 VA: 0x2668AB0
	public Vector3 get_OrigPosition() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C0060 Offset: 0x2C0161 VA: 0x2C0060
	// RVA: 0x2668AC0 Offset: 0x2668BC1 VA: 0x2668AC0
	public void set_OrigPosition(Vector3 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C0070 Offset: 0x2C0171 VA: 0x2C0070
	// RVA: 0x2668AD0 Offset: 0x2668BD1 VA: 0x2668AD0
	public Quaternion get_OrigRotation() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C0080 Offset: 0x2C0181 VA: 0x2C0080
	// RVA: 0x2668AE0 Offset: 0x2668BE1 VA: 0x2668AE0
	public void set_OrigRotation(Quaternion value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C0090 Offset: 0x2C0191 VA: 0x2C0090
	// RVA: 0x2668B00 Offset: 0x2668C01 VA: 0x2668B00
	private GameObject get_ItemEffect() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C00A0 Offset: 0x2C01A1 VA: 0x2C00A0
	// RVA: 0x2668B10 Offset: 0x2668C11 VA: 0x2668B10
	private void set_ItemEffect(GameObject value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C00B0 Offset: 0x2C01B1 VA: 0x2C00B0
	// RVA: 0x2668B20 Offset: 0x2668C21 VA: 0x2668B20
	private GameObject get_AccessCursorObject() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C00C0 Offset: 0x2C01C1 VA: 0x2C00C0
	// RVA: 0x2668B30 Offset: 0x2668C31 VA: 0x2668B30
	private void set_AccessCursorObject(GameObject value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C00D0 Offset: 0x2C01D1 VA: 0x2C00D0
	// RVA: 0x2668B40 Offset: 0x2668C41 VA: 0x2668B40
	private HubAccessCursor get_AccessCursor() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C00E0 Offset: 0x2C01E1 VA: 0x2C00E0
	// RVA: 0x2668B50 Offset: 0x2668C51 VA: 0x2668B50
	private void set_AccessCursor(HubAccessCursor value) { }

	// RVA: 0x2668B60 Offset: 0x2668C61 VA: 0x2668B60
	public int GetMessageCount() { }

	// RVA: 0x2668C10 Offset: 0x2668D11 VA: 0x2668C10
	public string GetMessage(int index) { }

	// RVA: 0x2668D30 Offset: 0x2668E31 VA: 0x2668D30
	public void UpdateAccessCount() { }

	// RVA: 0x2669550 Offset: 0x2669651 VA: 0x2669550
	private void Awake() { }

	// RVA: 0x2669C60 Offset: 0x2669D61 VA: 0x2669C60
	private void OnDrawGizmos() { }

	// RVA: 0x2669F50 Offset: 0x266A051 VA: 0x2669F50
	private void OnDestroy() { }

	// RVA: 0x266A080 Offset: 0x266A181 VA: 0x266A080
	public Vector3 GetHelpPosition() { }

	// RVA: 0x26698E0 Offset: 0x26699E1 VA: 0x26698E0
	public void Locate(string locator) { }

	// RVA: 0x266A630 Offset: 0x266A731 VA: 0x266A630
	public void Clear() { }

	// RVA: 0x266A670 Offset: 0x266A771 VA: 0x266A670
	public void DoneAccess() { }

	// RVA: 0x266A830 Offset: 0x266A931 VA: 0x266A830
	public bool Execute(HubSequence hubSequence) { }

	// RVA: 0x266ADA0 Offset: 0x266AEA1 VA: 0x266ADA0
	public void Refresh() { }

	// RVA: 0x266AEA0 Offset: 0x266AFA1 VA: 0x266AEA0
	public void SetupHelp(GameObject helpObject) { }

	// RVA: 0x266BBB0 Offset: 0x266BCB1 VA: 0x266BBB0
	public string GetHelpTitle() { }

	// RVA: 0x266B610 Offset: 0x266B711 VA: 0x266B610
	public string GetMainText() { }

	// RVA: 0x266BA20 Offset: 0x266BB21 VA: 0x266BA20
	public string GetButtonName() { }

	// RVA: 0x266BE00 Offset: 0x266BF01 VA: 0x266BE00
	private string GetAnimalButtonName() { }

	// RVA: 0x266BFB0 Offset: 0x266C0B1 VA: 0x266BFB0
	public bool IsCollideFront() { }

	// RVA: 0x266BFC0 Offset: 0x266C0C1 VA: 0x266BFC0
	public bool IsAccessAngle(Vector3 pos) { }

	// RVA: 0x266C0A0 Offset: 0x266C1A1 VA: 0x266C0A0
	public string TryGetPID() { }

	// RVA: 0x266A260 Offset: 0x266A361 VA: 0x266A260
	private void CreateItemEffect() { }

	// RVA: 0x266A3C0 Offset: 0x266A4C1 VA: 0x266A3C0
	private void CreateAccessCursor() { }

	// RVA: 0x266AC50 Offset: 0x266AD51 VA: 0x266AC50
	private bool CanAccessDoor() { }

	// RVA: 0x266C1F0 Offset: 0x266C2F1 VA: 0x266C1F0
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C00F0 Offset: 0x2C01F1 VA: 0x2C00F0
	// RVA: 0x266C210 Offset: 0x266C311 VA: 0x266C210
	private bool <Awake>b__75_0(HubDisposData data) { }
}

