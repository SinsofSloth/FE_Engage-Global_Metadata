// Namespace: App
[Serializable]
public abstract class FishingEventFader : MonoBehaviour // TypeDefIndex: 10584
{
	// Fields
	public Color m_Color; // 0x18
	private GameObject m_Layer; // 0x28
	private Image m_Image; // 0x30
	private float m_Timer; // 0x38
	private float m_FinishTime; // 0x3C
	private bool IsFadeIn; // 0x40
	[CompilerGeneratedAttribute] // RVA: 0x292AD0 Offset: 0x292BD1 VA: 0x292AD0
	private bool <IsRun>k__BackingField; // 0x41
	private float[] m_FadeTimeList; // 0x48

	// Properties
	public bool IsRun { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2BF5F0 Offset: 0x2BF6F1 VA: 0x2BF5F0
	// RVA: 0x2EF5A20 Offset: 0x2EF5B21 VA: 0x2EF5A20
	public bool get_IsRun() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BF600 Offset: 0x2BF701 VA: 0x2BF600
	// RVA: 0x2EF5A30 Offset: 0x2EF5B31 VA: 0x2EF5A30
	private void set_IsRun(bool value) { }

	// RVA: 0x2EF5A40 Offset: 0x2EF5B41 VA: 0x2EF5A40
	public void Create() { }

	// RVA: 0x2EF5C80 Offset: 0x2EF5D81 VA: 0x2EF5C80
	public void Destroy() { }

	// RVA: 0x2EF5D30 Offset: 0x2EF5E31 VA: 0x2EF5D30
	public void FadeIn(FadeType type) { }

	// RVA: 0x2EF5D90 Offset: 0x2EF5E91 VA: 0x2EF5D90
	public void FadeOut(FadeType type) { }

	// RVA: 0x2EF5DF0 Offset: 0x2EF5EF1 VA: 0x2EF5DF0
	public void SetColor(Color set) { }

	// RVA: 0x2EF5E10 Offset: 0x2EF5F11 VA: 0x2EF5E10
	public float GetFadeTime(FadeType type) { }

	// RVA: 0x2EF5E50 Offset: 0x2EF5F51 VA: 0x2EF5E50
	public void LateUpdate() { }

	// RVA: 0x2EF5FC0 Offset: 0x2EF60C1 VA: 0x2EF5FC0
	protected void .ctor() { }
}

