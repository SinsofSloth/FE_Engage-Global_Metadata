// Namespace: App
[ExecuteAlways] // RVA: 0x279400 Offset: 0x279501 VA: 0x279400
public abstract class EffectShoot : MonoBehaviour // TypeDefIndex: 14000
{
	// Fields
	public Vector3 m_Start; // 0x18
	public Vector3 m_Goal; // 0x24
	[RangeAttribute] // RVA: 0x29D1C0 Offset: 0x29D2C1 VA: 0x29D1C0
	public float m_Time; // 0x30
	private float m_TotalTime; // 0x34
	private float m_DeltaTime; // 0x38
	private Vector3 m_Position0; // 0x3C
	private Vector3 m_Position1; // 0x48
	private Vector3 m_Position2; // 0x54
	private Vector3 m_Position3; // 0x60
	private EffectShoot.Callback m_Callback; // 0x70
	private ParticleSystem[] m_ParticleSystems; // 0x78

	// Methods

	// RVA: 0x25F4280 Offset: 0x25F4381 VA: 0x25F4280
	private void Update() { }

	// RVA: 0x25F4590 Offset: 0x25F4691 VA: 0x25F4590
	public void Shoot() { }

	// RVA: 0x25F47C0 Offset: 0x25F48C1 VA: 0x25F47C0
	public void Shoot(Vector3 start, Vector3 goal, float time, EffectShoot.Callback callback) { }

	// RVA: 0x25F44A0 Offset: 0x25F45A1 VA: 0x25F44A0
	private void SetLoop(bool enable) { }

	// RVA: 0x25F4810 Offset: 0x25F4911 VA: 0x25F4810
	public void Stop() { }

	// RVA: 0x25F4820 Offset: 0x25F4921 VA: 0x25F4820
	protected void .ctor() { }
}

