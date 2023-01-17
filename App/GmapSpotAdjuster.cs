// Namespace: App
[ExecuteAlways] // RVA: 0x276B10 Offset: 0x276C11 VA: 0x276B10
public abstract class GmapSpotAdjuster : MonoBehaviour // TypeDefIndex: 10367
{
	// Fields
	public bool 移動時に地面に吸着させる; // 0x18
	public List<GmapSpotAdjuster.TargetModel> 吸着対象; // 0x20
	private List<Collider> m_TargetColliders; // 0x28
	private bool m_OldCheck; // 0x30
	private Transform m_Transform; // 0x38
	private Vector3 m_LastPosition; // 0x40

	// Methods

	// RVA: 0x2CF37C0 Offset: 0x2CF38C1 VA: 0x2CF37C0
	private void Start() { }

	// RVA: 0x2CF3AC0 Offset: 0x2CF3BC1 VA: 0x2CF3AC0
	private void OnValidate() { }

	// RVA: 0x2CF3B00 Offset: 0x2CF3C01 VA: 0x2CF3B00
	private void Update() { }

	// RVA: 0x2CF3800 Offset: 0x2CF3901 VA: 0x2CF3800
	private void SetupColliders() { }

	// RVA: 0x2CF3B80 Offset: 0x2CF3C81 VA: 0x2CF3B80
	private void AdjustGround(Vector3 diff) { }

	// RVA: 0x2CF3CB0 Offset: 0x2CF3DB1 VA: 0x2CF3CB0
	private static bool RaycastToTargets(Vector3 origin, Vector3 direction, out RaycastHit outRaycastHit, Collider[] targets) { }

	// RVA: 0x2CF3E70 Offset: 0x2CF3F71 VA: 0x2CF3E70
	protected void .ctor() { }
}

