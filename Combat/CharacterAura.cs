// Namespace: Combat
public sealed class CharacterAura : MonoBehaviour // TypeDefIndex: 8590
{
	// Fields
	private GameObject m_AppearEffect; // 0x18
	private GameObject m_DisappearEffect; // 0x20
	[RangeAttribute] // RVA: 0x2822B0 Offset: 0x2823B1 VA: 0x2822B0
	[HeaderAttribute] // RVA: 0x2822B0 Offset: 0x2823B1 VA: 0x2822B0
	public float AppearDuration; // 0x28
	[RangeAttribute] // RVA: 0x282310 Offset: 0x282411 VA: 0x282310
	[HeaderAttribute] // RVA: 0x282310 Offset: 0x282411 VA: 0x282310
	public float DisappearDuration; // 0x2C
	private Character _cp; // 0x30
	private IDisposable m_FadeDisposable; // 0x38
	private bool m_IsAppear; // 0x40
	private float m_DisappearDelayTime; // 0x44
	[CompilerGeneratedAttribute] // RVA: 0x282370 Offset: 0x282471 VA: 0x282370
	private FXZ <LastDisappearPosition>k__BackingField; // 0x48

	// Properties
	private Character CP { get; }
	private Iron19CharacterFader fader { get; }
	public bool IsVisible { get; }
	public FXZ LastDisappearPosition { get; set; }

	// Methods

	// RVA: 0x2B69EF0 Offset: 0x2B69FF1 VA: 0x2B69EF0
	private Character get_CP() { }

	// RVA: 0x2B69FB0 Offset: 0x2B6A0B1 VA: 0x2B69FB0
	private Iron19CharacterFader get_fader() { }

	// RVA: 0x2B69FD0 Offset: 0x2B6A0D1 VA: 0x2B69FD0
	public bool get_IsVisible() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AA620 Offset: 0x2AA721 VA: 0x2AA620
	// RVA: 0x2B69FE0 Offset: 0x2B6A0E1 VA: 0x2B69FE0
	public FXZ get_LastDisappearPosition() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AA630 Offset: 0x2AA731 VA: 0x2AA630
	// RVA: 0x2B69FF0 Offset: 0x2B6A0F1 VA: 0x2B69FF0
	private void set_LastDisappearPosition(FXZ value) { }

	// RVA: 0x2B6A000 Offset: 0x2B6A101 VA: 0x2B6A000
	private void Start() { }

	// RVA: 0x2B6A0A0 Offset: 0x2B6A1A1 VA: 0x2B6A0A0
	private void MyStart() { }

	// RVA: 0x2B6A160 Offset: 0x2B6A261 VA: 0x2B6A160
	public void SetAppear(bool visible) { }

	// RVA: 0x2B6A2C0 Offset: 0x2B6A3C1 VA: 0x2B6A2C0
	public void Appear(bool isEndOfCombat = False) { }

	// RVA: 0x2B6A6A0 Offset: 0x2B6A7A1 VA: 0x2B6A6A0
	private void RelocateToSpace() { }

	// RVA: 0x2B6A960 Offset: 0x2B6AA61 VA: 0x2B6A960
	private void RelocateForCombatEnd() { }

	// RVA: 0x2B6AAD0 Offset: 0x2B6ABD1 VA: 0x2B6AAD0
	public void Disappear(float delayTime = 0, bool silent = False) { }

	// RVA: 0x2B6A480 Offset: 0x2B6A581 VA: 0x2B6A480
	private void PlayTriggerEffect(GameObject fx) { }

	// RVA: 0x2B6AFA0 Offset: 0x2B6B0A1 VA: 0x2B6AFA0
	private void Update() { }

	// RVA: 0x2B6B020 Offset: 0x2B6B121 VA: 0x2B6B020
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AA640 Offset: 0x2AA741 VA: 0x2AA640
	// RVA: 0x2B6B040 Offset: 0x2B6B141 VA: 0x2B6B040
	private void <Start>b__18_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AA650 Offset: 0x2AA751 VA: 0x2AA650
	// RVA: 0x2B6B050 Offset: 0x2B6B151 VA: 0x2B6B050
	private bool <Appear>b__21_0(float progress) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AA660 Offset: 0x2AA761 VA: 0x2AA660
	// RVA: 0x2B6B110 Offset: 0x2B6B211 VA: 0x2B6B110
	private bool <Disappear>b__24_0(float progress) { }
}

