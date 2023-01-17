// Namespace: TMPro
internal struct ColorTween : ITweenValue // TypeDefIndex: 7348
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

	// RVA: 0x192CCD0 Offset: 0x192CDD1 VA: 0x192CCD0
	public Color get_startColor() { }

	// RVA: 0x192CCE0 Offset: 0x192CDE1 VA: 0x192CCE0
	public void set_startColor(Color value) { }

	// RVA: 0x192CD00 Offset: 0x192CE01 VA: 0x192CD00
	public Color get_targetColor() { }

	// RVA: 0x192CD10 Offset: 0x192CE11 VA: 0x192CD10
	public void set_targetColor(Color value) { }

	// RVA: 0x192CD30 Offset: 0x192CE31 VA: 0x192CD30
	public ColorTween.ColorTweenMode get_tweenMode() { }

	// RVA: 0x192CD40 Offset: 0x192CE41 VA: 0x192CD40
	public void set_tweenMode(ColorTween.ColorTweenMode value) { }

	// RVA: 0x192CD50 Offset: 0x192CE51 VA: 0x192CD50 Slot: 6
	public float get_duration() { }

	// RVA: 0x192CD60 Offset: 0x192CE61 VA: 0x192CD60
	public void set_duration(float value) { }

	// RVA: 0x192CD70 Offset: 0x192CE71 VA: 0x192CD70 Slot: 5
	public bool get_ignoreTimeScale() { }

	// RVA: 0x192CD80 Offset: 0x192CE81 VA: 0x192CD80
	public void set_ignoreTimeScale(bool value) { }

	// RVA: 0x192CD90 Offset: 0x192CE91 VA: 0x192CD90 Slot: 4
	public void TweenValue(float floatPercentage) { }

	// RVA: 0x192CE60 Offset: 0x192CF61 VA: 0x192CE60
	public void AddOnChangedCallback(UnityAction<Color> callback) { }

	// RVA: 0x192CF00 Offset: 0x192D001 VA: 0x192CF00
	public bool GetIgnoreTimescale() { }

	// RVA: 0x192CF10 Offset: 0x192D011 VA: 0x192CF10
	public float GetDuration() { }

	// RVA: 0x192CE50 Offset: 0x192CF51 VA: 0x192CE50 Slot: 7
	public bool ValidTarget() { }
}

