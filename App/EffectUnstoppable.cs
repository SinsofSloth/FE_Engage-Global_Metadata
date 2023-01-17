// Namespace: App
public abstract class EffectUnstoppable : MonoBehaviour // TypeDefIndex: 14001
{
	// Fields
	[RangeAttribute] // RVA: 0x29D1E0 Offset: 0x29D2E1 VA: 0x29D1E0
	[TooltipAttribute] // RVA: 0x29D1E0 Offset: 0x29D2E1 VA: 0x29D1E0
	public float m_Threshold; // 0x18
	private Vector3 m_Position; // 0x1C
	private ParticleSystem m_ParticleSystem; // 0x28
	private bool m_IsStopped; // 0x30
	public string m_StartSound; // 0x38
	public string m_StopSound; // 0x40

	// Methods

	// RVA: 0x25F4840 Offset: 0x25F4941 VA: 0x25F4840
	private void Start() { }

	// RVA: 0x25F48F0 Offset: 0x25F49F1 VA: 0x25F48F0
	private void LateUpdate() { }

	// RVA: 0x25F4AB0 Offset: 0x25F4BB1 VA: 0x25F4AB0
	protected void .ctor() { }
}

