// Namespace: UnityEngine.UI.CoroutineTween
internal struct FloatTween : ITweenValue // TypeDefIndex: 4381
{
	// Fields
	private FloatTween.FloatTweenCallback m_Target; // 0x0
	private float m_StartValue; // 0x8
	private float m_TargetValue; // 0xC
	private float m_Duration; // 0x10
	private bool m_IgnoreTimeScale; // 0x14

	// Properties
	public float startValue { get; set; }
	public float targetValue { get; set; }
	public float duration { get; set; }
	public bool ignoreTimeScale { get; set; }

	// Methods

	// RVA: 0x1A4F0F0 Offset: 0x1A4F1F1 VA: 0x1A4F0F0
	public float get_startValue() { }

	// RVA: 0x1A4F100 Offset: 0x1A4F201 VA: 0x1A4F100
	public void set_startValue(float value) { }

	// RVA: 0x1A4F110 Offset: 0x1A4F211 VA: 0x1A4F110
	public float get_targetValue() { }

	// RVA: 0x1A4F120 Offset: 0x1A4F221 VA: 0x1A4F120
	public void set_targetValue(float value) { }

	// RVA: 0x1A4F130 Offset: 0x1A4F231 VA: 0x1A4F130 Slot: 6
	public float get_duration() { }

	// RVA: 0x1A4F140 Offset: 0x1A4F241 VA: 0x1A4F140
	public void set_duration(float value) { }

	// RVA: 0x1A4F150 Offset: 0x1A4F251 VA: 0x1A4F150 Slot: 5
	public bool get_ignoreTimeScale() { }

	// RVA: 0x1A4F160 Offset: 0x1A4F261 VA: 0x1A4F160
	public void set_ignoreTimeScale(bool value) { }

	// RVA: 0x1A4F170 Offset: 0x1A4F271 VA: 0x1A4F170 Slot: 4
	public void TweenValue(float floatPercentage) { }

	// RVA: 0x1A4B230 Offset: 0x1A4B331 VA: 0x1A4B230
	public void AddOnChangedCallback(UnityAction<float> callback) { }

	// RVA: 0x1A4F200 Offset: 0x1A4F301 VA: 0x1A4F200
	public bool GetIgnoreTimescale() { }

	// RVA: 0x1A4F210 Offset: 0x1A4F311 VA: 0x1A4F210
	public float GetDuration() { }

	// RVA: 0x1A4F1F0 Offset: 0x1A4F2F1 VA: 0x1A4F1F0 Slot: 7
	public bool ValidTarget() { }
}

