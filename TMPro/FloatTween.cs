// Namespace: TMPro
internal struct FloatTween : ITweenValue // TypeDefIndex: 7350
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

	// RVA: 0x192D6E0 Offset: 0x192D7E1 VA: 0x192D6E0
	public float get_startValue() { }

	// RVA: 0x192D6F0 Offset: 0x192D7F1 VA: 0x192D6F0
	public void set_startValue(float value) { }

	// RVA: 0x192D700 Offset: 0x192D801 VA: 0x192D700
	public float get_targetValue() { }

	// RVA: 0x192D710 Offset: 0x192D811 VA: 0x192D710
	public void set_targetValue(float value) { }

	// RVA: 0x192D720 Offset: 0x192D821 VA: 0x192D720 Slot: 6
	public float get_duration() { }

	// RVA: 0x192D730 Offset: 0x192D831 VA: 0x192D730
	public void set_duration(float value) { }

	// RVA: 0x192D740 Offset: 0x192D841 VA: 0x192D740 Slot: 5
	public bool get_ignoreTimeScale() { }

	// RVA: 0x192D750 Offset: 0x192D851 VA: 0x192D750
	public void set_ignoreTimeScale(bool value) { }

	// RVA: 0x192D760 Offset: 0x192D861 VA: 0x192D760 Slot: 4
	public void TweenValue(float floatPercentage) { }

	// RVA: 0x192D7F0 Offset: 0x192D8F1 VA: 0x192D7F0
	public void AddOnChangedCallback(UnityAction<float> callback) { }

	// RVA: 0x192D890 Offset: 0x192D991 VA: 0x192D890
	public bool GetIgnoreTimescale() { }

	// RVA: 0x192D8A0 Offset: 0x192D9A1 VA: 0x192D8A0
	public float GetDuration() { }

	// RVA: 0x192D7E0 Offset: 0x192D8E1 VA: 0x192D7E0 Slot: 7
	public bool ValidTarget() { }
}

