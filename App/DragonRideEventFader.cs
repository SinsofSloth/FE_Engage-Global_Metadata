// Namespace: App
[Serializable]
public abstract class DragonRideEventFader : MonoBehaviour // TypeDefIndex: 10510
{
	// Fields
	public Color m_Color; // 0x18
	private GameObject m_Layer; // 0x28
	private Image m_Image; // 0x30
	private float m_Timer; // 0x38
	private float m_FinishTime; // 0x3C
	private bool IsFadeIn; // 0x40
	private bool IsRun; // 0x41
	private float[] m_FadeTimeList; // 0x48

	// Methods

	// RVA: 0x2DC3420 Offset: 0x2DC3521 VA: 0x2DC3420
	public void Create() { }

	// RVA: 0x2DC3660 Offset: 0x2DC3761 VA: 0x2DC3660
	public void Destroy() { }

	// RVA: 0x2DC3710 Offset: 0x2DC3811 VA: 0x2DC3710
	public void BlackIn(FadeType type) { }

	// RVA: 0x2DC3770 Offset: 0x2DC3871 VA: 0x2DC3770
	public void BlackOut(FadeType type) { }

	// RVA: 0x2DC37D0 Offset: 0x2DC38D1 VA: 0x2DC37D0
	public void LateUpdate() { }

	// RVA: 0x2DC3940 Offset: 0x2DC3A41 VA: 0x2DC3940
	protected void .ctor() { }
}

