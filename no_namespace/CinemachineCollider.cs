// Namespace: 
private class CinemachineCollider.VcamExtraState // TypeDefIndex: 5744
{
	// Fields
	public Vector3 m_previousDisplacement; // 0x10
	public Vector3 m_previousDisplacementCorrection; // 0x1C
	public float colliderDisplacement; // 0x28
	public bool targetObscured; // 0x2C
	public float occlusionStartTime; // 0x30
	public List<Vector3> debugResolutionPath; // 0x38
	private float m_SmoothedDistance; // 0x40
	private float m_SmoothedTime; // 0x44

	// Methods

	// RVA: 0x1A882F0 Offset: 0x1A883F1 VA: 0x1A882F0
	public void AddPointToDebugPath(Vector3 p) { }

	// RVA: 0x1A88300 Offset: 0x1A88401 VA: 0x1A88300
	public float ApplyDistanceSmoothing(float distance, float smoothingTime) { }

	// RVA: 0x1A883D0 Offset: 0x1A884D1 VA: 0x1A883D0
	public void UpdateDistanceSmoothing(float distance, float smoothingTime) { }

	// RVA: 0x1A88460 Offset: 0x1A88561 VA: 0x1A88460
	public void ResetDistanceSmoothing(float smoothingTime) { }

	// RVA: 0x1A884F0 Offset: 0x1A885F1 VA: 0x1A884F0
	public void .ctor() { }
}

