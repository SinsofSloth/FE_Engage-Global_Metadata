// Namespace: App
public class InterpolatorTime // TypeDefIndex: 9182
{
	// Fields
	protected float m_Time; // 0x10
	protected float m_Tick; // 0x14
	protected Curve.Type m_Type; // 0x18
	protected int m_Num; // 0x1C
	protected bool m_IsFirst; // 0x20
	protected bool m_IsDirty; // 0x21

	// Properties
	public float Time { get; }
	public bool IsFirst { get; }
	public bool IsStability { get; }
	public bool IsNextStability { get; }
	public bool IsRunning { get; }
	private float NextTick { get; }

	// Methods

	// RVA: 0x2B4F2A0 Offset: 0x2B4F3A1 VA: 0x2B4F2A0
	public void .ctor(Curve.Type type = 0, int num = 0) { }

	// RVA: 0x2B4F300 Offset: 0x2B4F401 VA: 0x2B4F300
	public float get_Time() { }

	// RVA: 0x2B4F310 Offset: 0x2B4F411 VA: 0x2B4F310
	public bool get_IsFirst() { }

	// RVA: 0x2B4F320 Offset: 0x2B4F421 VA: 0x2B4F320
	public bool get_IsStability() { }

	// RVA: 0x2B4F330 Offset: 0x2B4F431 VA: 0x2B4F330
	public bool get_IsNextStability() { }

	// RVA: 0x2B4F3F0 Offset: 0x2B4F4F1 VA: 0x2B4F3F0
	public bool get_IsRunning() { }

	// RVA: 0x2B4F2F0 Offset: 0x2B4F3F1 VA: 0x2B4F2F0
	public void Reset() { }

	// RVA: 0x2B4F400 Offset: 0x2B4F501 VA: 0x2B4F400
	public void Instant() { }

	// RVA: 0x2B4F410 Offset: 0x2B4F511 VA: 0x2B4F410
	public void SetCurve(Curve.Type type, int num) { }

	// RVA: 0x2B4F420 Offset: 0x2B4F521 VA: 0x2B4F420
	public void SetCurve(Curve.Type type) { }

	// RVA: 0x2B4F430 Offset: 0x2B4F531 VA: 0x2B4F430
	public float GetRate() { }

	// RVA: 0x2B4ED10 Offset: 0x2B4EE11 VA: 0x2B4ED10
	protected float GetValue(float prev, float next) { }

	// RVA: 0x2B4F450 Offset: 0x2B4F551 VA: 0x2B4F450
	protected void SetTime(float time) { }

	// RVA: 0x2B4F480 Offset: 0x2B4F581 VA: 0x2B4F480
	private float get_NextTick() { }

	// RVA: 0x2B4F530 Offset: 0x2B4F631 VA: 0x2B4F530
	public bool Tick(bool isFadeSkip = True) { }
}

