// Namespace: UnityEngine.UI.CoroutineTween
internal struct ColorTween : ITweenValue // TypeDefIndex: 4379
{
	// Fields
	private ColorTween.ColorTweenCallback m_Target; // 0x0
	private Color m_StartColor; // 0x8
	private Color m_TargetColor; // 0x18
	private ColorTween.ColorTweenMode m_TweenMode; // 0x28
	private float m_Duration; // 0x2C
	private bool m_IgnoreTimeScale; // 0x30

	// Properties
	public Color startColor { get; set; }
	public Color targetColor { get; set; }
	public ColorTween.ColorTweenMode tweenMode { get; set; }
	public float duration { get; set; }
	public bool ignoreTimeScale { get; set; }

	// Methods

	// RVA: 0x1A434E0 Offset: 0x1A435E1 VA: 0x1A434E0
	public Color get_startColor() { }

	// RVA: 0x1A434F0 Offset: 0x1A435F1 VA: 0x1A434F0
	public void set_startColor(Color value) { }

	// RVA: 0x1A43510 Offset: 0x1A43611 VA: 0x1A43510
	public Color get_targetColor() { }

	// RVA: 0x1A43520 Offset: 0x1A43621 VA: 0x1A43520
	public void set_targetColor(Color value) { }

	// RVA: 0x1A43540 Offset: 0x1A43641 VA: 0x1A43540
	public ColorTween.ColorTweenMode get_tweenMode() { }

	// RVA: 0x1A43550 Offset: 0x1A43651 VA: 0x1A43550
	public void set_tweenMode(ColorTween.ColorTweenMode value) { }

	// RVA: 0x1A43560 Offset: 0x1A43661 VA: 0x1A43560 Slot: 6
	public float get_duration() { }

	// RVA: 0x1A43570 Offset: 0x1A43671 VA: 0x1A43570
	public void set_duration(float value) { }

	// RVA: 0x1A43580 Offset: 0x1A43681 VA: 0x1A43580 Slot: 5
	public bool get_ignoreTimeScale() { }

	// RVA: 0x1A43590 Offset: 0x1A43691 VA: 0x1A43590
	public void set_ignoreTimeScale(bool value) { }

	// RVA: 0x1A435A0 Offset: 0x1A436A1 VA: 0x1A435A0 Slot: 4
	public void TweenValue(float floatPercentage) { }

	// RVA: 0x1A43670 Offset: 0x1A43771 VA: 0x1A43670
	public void AddOnChangedCallback(UnityAction<Color> callback) { }

	// RVA: 0x1A43710 Offset: 0x1A43811 VA: 0x1A43710
	public bool GetIgnoreTimescale() { }

	// RVA: 0x1A43720 Offset: 0x1A43821 VA: 0x1A43720
	public float GetDuration() { }

	// RVA: 0x1A43660 Offset: 0x1A43761 VA: 0x1A43660 Slot: 7
	public bool ValidTarget() { }
}

