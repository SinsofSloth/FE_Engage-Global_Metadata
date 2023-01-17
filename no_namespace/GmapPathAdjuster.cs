// Namespace: 
[ExecuteAlways] // RVA: 0x271860 Offset: 0x271961 VA: 0x271860
public class GmapPathAdjuster : MonoBehaviour // TypeDefIndex: 7701
{
	// Fields
	public bool 両端をモデル位置に合わせる; // 0x18
	public bool 移動時に地面に吸着させる; // 0x19
	public List<GmapPathAdjuster.TargetModel> 吸着対象; // 0x20
	private List<Collider> m_TargetColliders; // 0x28
	private CinemachineSmoothPath m_SmoothPath; // 0x30
	private Vector3[] m_LastPositions; // 0x38
	private List<Transform> m_BothSpotTransforms; // 0x40
	private bool m_IsInitialized; // 0x48

	// Methods

	// RVA: 0x2CE2460 Offset: 0x2CE2561 VA: 0x2CE2460
	private void Start() { }

	// RVA: 0x2CE2470 Offset: 0x2CE2571 VA: 0x2CE2470
	private void Setup() { }

	// RVA: 0x2CE2610 Offset: 0x2CE2711 VA: 0x2CE2610
	private bool SetupColliders() { }

	// RVA: 0x2CE2840 Offset: 0x2CE2941 VA: 0x2CE2840
	private bool SetupBothObjects() { }

	// RVA: 0x2CE2A80 Offset: 0x2CE2B81 VA: 0x2CE2A80
	private void OnDisable() { }

	// RVA: 0x2CE2A90 Offset: 0x2CE2B91 VA: 0x2CE2A90
	private void Update() { }

	// RVA: 0x2CE2AA0 Offset: 0x2CE2BA1 VA: 0x2CE2AA0
	private void AdjustGround() { }

	// RVA: 0x2CE2B30 Offset: 0x2CE2C31 VA: 0x2CE2B30
	private int IsChanged() { }

	// RVA: 0x2CE2C40 Offset: 0x2CE2D41 VA: 0x2CE2C40
	private void AdjustGroundPoint(int index) { }

	// RVA: 0x2CE2F60 Offset: 0x2CE3061 VA: 0x2CE2F60
	private void AdjustBothSpots() { }

	// RVA: 0x2CE2DA0 Offset: 0x2CE2EA1 VA: 0x2CE2DA0
	private static bool RaycastToTargets(Vector3 origin, Vector3 direction, out RaycastHit outRaycastHit, Collider[] targets) { }

	// RVA: 0x2CE2FA0 Offset: 0x2CE30A1 VA: 0x2CE2FA0
	public void .ctor() { }
}

