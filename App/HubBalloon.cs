// Namespace: App
public abstract class HubBalloon : MonoBehaviour // TypeDefIndex: 10664
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x294200 Offset: 0x294301 VA: 0x294200
	private HubBalloon.Type <BalloonType>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x294210 Offset: 0x294311 VA: 0x294210
	private bool <UseUpIcon>k__BackingField; // 0x1C
	[CompilerGeneratedAttribute] // RVA: 0x294220 Offset: 0x294321 VA: 0x294220
	private HubAccess <TargetAccess>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x294230 Offset: 0x294331 VA: 0x294230
	private Iron19CharacterFader <CharaFader>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x294240 Offset: 0x294341 VA: 0x294240
	private float <FadeDistance>k__BackingField; // 0x30
	[CompilerGeneratedAttribute] // RVA: 0x294250 Offset: 0x294351 VA: 0x294250
	private HubPlayerController <PlayerController>k__BackingField; // 0x38
	private int m_propetyToID; // 0x40
	private GameObject m_talkDefault; // 0x48
	private GameObject m_talkChapter; // 0x50
	private GameObject m_talkReliance; // 0x58
	private Renderer[] m_rendererList; // 0x60
	private Material[] m_materials; // 0x68
	private float m_alpha; // 0x70
	private bool m_talkDefaultActive; // 0x74
	private bool m_talkChapterActive; // 0x75
	private bool m_talkRelianceActive; // 0x76

	// Properties
	public HubBalloon.Type BalloonType { get; set; }
	public bool UseUpIcon { get; set; }
	public HubAccess TargetAccess { get; set; }
	public Iron19CharacterFader CharaFader { get; set; }
	public float FadeDistance { get; set; }
	public HubPlayerController PlayerController { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2C0660 Offset: 0x2C0761 VA: 0x2C0660
	// RVA: 0x304A8E0 Offset: 0x304A9E1 VA: 0x304A8E0
	public HubBalloon.Type get_BalloonType() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C0670 Offset: 0x2C0771 VA: 0x2C0670
	// RVA: 0x304A8F0 Offset: 0x304A9F1 VA: 0x304A8F0
	public void set_BalloonType(HubBalloon.Type value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C0680 Offset: 0x2C0781 VA: 0x2C0680
	// RVA: 0x304A900 Offset: 0x304AA01 VA: 0x304A900
	public bool get_UseUpIcon() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C0690 Offset: 0x2C0791 VA: 0x2C0690
	// RVA: 0x304A910 Offset: 0x304AA11 VA: 0x304A910
	public void set_UseUpIcon(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C06A0 Offset: 0x2C07A1 VA: 0x2C06A0
	// RVA: 0x304A920 Offset: 0x304AA21 VA: 0x304A920
	public HubAccess get_TargetAccess() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C06B0 Offset: 0x2C07B1 VA: 0x2C06B0
	// RVA: 0x304A930 Offset: 0x304AA31 VA: 0x304A930
	public void set_TargetAccess(HubAccess value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C06C0 Offset: 0x2C07C1 VA: 0x2C06C0
	// RVA: 0x304A940 Offset: 0x304AA41 VA: 0x304A940
	public Iron19CharacterFader get_CharaFader() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C06D0 Offset: 0x2C07D1 VA: 0x2C06D0
	// RVA: 0x304A950 Offset: 0x304AA51 VA: 0x304A950
	public void set_CharaFader(Iron19CharacterFader value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C06E0 Offset: 0x2C07E1 VA: 0x2C06E0
	// RVA: 0x304A960 Offset: 0x304AA61 VA: 0x304A960
	public float get_FadeDistance() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C06F0 Offset: 0x2C07F1 VA: 0x2C06F0
	// RVA: 0x304A970 Offset: 0x304AA71 VA: 0x304A970
	public void set_FadeDistance(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C0700 Offset: 0x2C0801 VA: 0x2C0700
	// RVA: 0x304A980 Offset: 0x304AA81 VA: 0x304A980
	public HubPlayerController get_PlayerController() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C0710 Offset: 0x2C0811 VA: 0x2C0710
	// RVA: 0x304A990 Offset: 0x304AA91 VA: 0x304A990
	public void set_PlayerController(HubPlayerController value) { }

	// RVA: 0x304A9A0 Offset: 0x304AAA1 VA: 0x304A9A0
	private void SetActiveTalkDefault(bool value) { }

	// RVA: 0x304A9D0 Offset: 0x304AAD1 VA: 0x304A9D0
	private void SetActiveTalkChapter(bool value) { }

	// RVA: 0x304AA00 Offset: 0x304AB01 VA: 0x304AA00
	private void SetActiveTalkReliance(bool value) { }

	// RVA: 0x304AA30 Offset: 0x304AB31 VA: 0x304AA30
	private void Start() { }

	// RVA: 0x304AF40 Offset: 0x304B041 VA: 0x304AF40
	private void Update() { }

	// RVA: 0x304B590 Offset: 0x304B691 VA: 0x304B590
	private bool IsActive() { }

	// RVA: 0x304B7A0 Offset: 0x304B8A1 VA: 0x304B7A0
	private bool IsOutRange() { }

	// RVA: 0x304B840 Offset: 0x304B941 VA: 0x304B840
	private bool IsFadeAlpha() { }

	// RVA: 0x304B8F0 Offset: 0x304B9F1 VA: 0x304B8F0
	private bool IsActiveAccess() { }

	// RVA: 0x304B990 Offset: 0x304BA91 VA: 0x304B990
	private void LateUpdate() { }

	// RVA: 0x304AE80 Offset: 0x304AF81 VA: 0x304AE80
	private void UpdateAlpha(float gain) { }

	// RVA: 0x304B430 Offset: 0x304B531 VA: 0x304B430
	private void SetMaterialDark() { }

	// RVA: 0x304B4E0 Offset: 0x304B5E1 VA: 0x304B4E0
	private void SetMaterialLight() { }

	// RVA: 0x304BA90 Offset: 0x304BB91 VA: 0x304BA90
	private void OnDestroy() { }

	// RVA: 0x304BB60 Offset: 0x304BC61 VA: 0x304BB60
	protected void .ctor() { }
}

