// Namespace: App
public class HubAccessCursor : MonoBehaviour // TypeDefIndex: 10642
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x293110 Offset: 0x293211 VA: 0x293110
	private HubAccess <TargetAccess>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x293120 Offset: 0x293221 VA: 0x293120
	private Iron19CharacterFader <CharaFader>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x293130 Offset: 0x293231 VA: 0x293130
	private float <FadeDistance>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x293140 Offset: 0x293241 VA: 0x293140
	private HubPlayerController <PlayerController>k__BackingField; // 0x30
	private int m_propetyToID; // 0x38
	private Renderer[] m_renderer; // 0x40
	private Material[] m_materials; // 0x48
	private float m_alpha; // 0x50

	// Properties
	public HubAccess TargetAccess { get; set; }
	public Iron19CharacterFader CharaFader { get; set; }
	public float FadeDistance { get; set; }
	public HubPlayerController PlayerController { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2C0100 Offset: 0x2C0201 VA: 0x2C0100
	// RVA: 0x266C250 Offset: 0x266C351 VA: 0x266C250
	public HubAccess get_TargetAccess() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C0110 Offset: 0x2C0211 VA: 0x2C0110
	// RVA: 0x266C260 Offset: 0x266C361 VA: 0x266C260
	public void set_TargetAccess(HubAccess value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C0120 Offset: 0x2C0221 VA: 0x2C0120
	// RVA: 0x266C270 Offset: 0x266C371 VA: 0x266C270
	public Iron19CharacterFader get_CharaFader() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C0130 Offset: 0x2C0231 VA: 0x2C0130
	// RVA: 0x266C280 Offset: 0x266C381 VA: 0x266C280
	public void set_CharaFader(Iron19CharacterFader value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C0140 Offset: 0x2C0241 VA: 0x2C0140
	// RVA: 0x266C290 Offset: 0x266C391 VA: 0x266C290
	public float get_FadeDistance() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C0150 Offset: 0x2C0251 VA: 0x2C0150
	// RVA: 0x266C2A0 Offset: 0x266C3A1 VA: 0x266C2A0
	public void set_FadeDistance(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C0160 Offset: 0x2C0261 VA: 0x2C0160
	// RVA: 0x266C2B0 Offset: 0x266C3B1 VA: 0x266C2B0
	public HubPlayerController get_PlayerController() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C0170 Offset: 0x2C0271 VA: 0x2C0170
	// RVA: 0x266C2C0 Offset: 0x266C3C1 VA: 0x266C2C0
	public void set_PlayerController(HubPlayerController value) { }

	// RVA: 0x266C2D0 Offset: 0x266C3D1 VA: 0x266C2D0
	private void Start() { }

	// RVA: 0x266C550 Offset: 0x266C651 VA: 0x266C550
	private void Update() { }

	// RVA: 0x266C7C0 Offset: 0x266C8C1 VA: 0x266C7C0
	private bool IsFade() { }

	// RVA: 0x266CB80 Offset: 0x266CC81 VA: 0x266CB80
	private bool IsInRange() { }

	// RVA: 0x266CC00 Offset: 0x266CD01 VA: 0x266CC00
	private bool IsOutRange() { }

	// RVA: 0x266CCA0 Offset: 0x266CDA1 VA: 0x266CCA0
	private bool IsFadeAlpha() { }

	// RVA: 0x266CAE0 Offset: 0x266CBE1 VA: 0x266CAE0
	private bool IsActiveAccess() { }

	// RVA: 0x266CD50 Offset: 0x266CE51 VA: 0x266CD50
	private void LateUpdate() { }

	// RVA: 0x266C9D0 Offset: 0x266CAD1 VA: 0x266C9D0
	private void UpdateAlpha(float gain) { }

	// RVA: 0x266CE50 Offset: 0x266CF51 VA: 0x266CE50
	private void OnDestroy() { }

	// RVA: 0x266CF20 Offset: 0x266D021 VA: 0x266CF20
	public void .ctor() { }
}

