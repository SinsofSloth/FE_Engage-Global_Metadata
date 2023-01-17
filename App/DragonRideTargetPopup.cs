// Namespace: App
public abstract class DragonRideTargetPopup : MonoBehaviour // TypeDefIndex: 10549
{
	// Fields
	private RectTransform m_RectTransform; // 0x18
	private DragonRideCamera m_Camera; // 0x20
	private Vector3 m_WorldPos; // 0x28
	private DragonRideConfig m_Config; // 0x38
	private float m_AliveTimer; // 0x40

	// Properties
	private bool IsAlive { get; }

	// Methods

	// RVA: 0x2DDD480 Offset: 0x2DDD581 VA: 0x2DDD480
	private bool get_IsAlive() { }

	// RVA: 0x2DDD4F0 Offset: 0x2DDD5F1 VA: 0x2DDD4F0
	public void Update() { }

	// RVA: 0x2DDB1A0 Offset: 0x2DDB2A1 VA: 0x2DDB1A0
	public void Init(Vector3 pos, ref DragonRideCamera camera, ref DragonRideConfig config) { }

	// RVA: 0x2DDD920 Offset: 0x2DDDA21 VA: 0x2DDD920
	protected void .ctor() { }
}

