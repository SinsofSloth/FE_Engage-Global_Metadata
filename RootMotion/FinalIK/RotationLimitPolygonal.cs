// Namespace: RootMotion.FinalIK
[AddComponentMenu] // RVA: 0x27A190 Offset: 0x27A291 VA: 0x27A190
[HelpURLAttribute] // RVA: 0x27A190 Offset: 0x27A291 VA: 0x27A190
public class RotationLimitPolygonal : RotationLimit // TypeDefIndex: 14438
{
	// Fields
	[RangeAttribute] // RVA: 0x2A3B80 Offset: 0x2A3C81 VA: 0x2A3B80
	public float twistLimit; // 0x38
	[RangeAttribute] // RVA: 0x2A3BA0 Offset: 0x2A3CA1 VA: 0x2A3BA0
	public int smoothIterations; // 0x3C
	[SerializeField] // RVA: 0x2A3BC0 Offset: 0x2A3CC1 VA: 0x2A3BC0
	[HideInInspector] // RVA: 0x2A3BC0 Offset: 0x2A3CC1 VA: 0x2A3BC0
	public RotationLimitPolygonal.LimitPoint[] points; // 0x40
	[HideInInspector] // RVA: 0x2A3C00 Offset: 0x2A3D01 VA: 0x2A3C00
	[SerializeField] // RVA: 0x2A3C00 Offset: 0x2A3D01 VA: 0x2A3C00
	public Vector3[] P; // 0x48
	[HideInInspector] // RVA: 0x2A3C40 Offset: 0x2A3D41 VA: 0x2A3C40
	[SerializeField] // RVA: 0x2A3C40 Offset: 0x2A3D41 VA: 0x2A3C40
	public RotationLimitPolygonal.ReachCone[] reachCones; // 0x50

	// Methods

	[ContextMenu] // RVA: 0x2D06E0 Offset: 0x2D07E1 VA: 0x2D06E0
	// RVA: 0x205C860 Offset: 0x205C961 VA: 0x205C860
	private void OpenUserManual() { }

	[ContextMenu] // RVA: 0x2D0720 Offset: 0x2D0821 VA: 0x2D0720
	// RVA: 0x205C8B0 Offset: 0x205C9B1 VA: 0x205C8B0
	private void OpenScriptReference() { }

	[ContextMenu] // RVA: 0x2D0760 Offset: 0x2D0861 VA: 0x2D0760
	// RVA: 0x205C900 Offset: 0x205CA01 VA: 0x205C900
	private void SupportGroup() { }

	[ContextMenu] // RVA: 0x2D07A0 Offset: 0x2D08A1 VA: 0x2D07A0
	// RVA: 0x205C950 Offset: 0x205CA51 VA: 0x205C950
	private void ASThread() { }

	// RVA: 0x205C9A0 Offset: 0x205CAA1 VA: 0x205C9A0
	public void SetLimitPoints(RotationLimitPolygonal.LimitPoint[] points) { }

	// RVA: 0x205CE60 Offset: 0x205CF61 VA: 0x205CE60 Slot: 4
	protected override Quaternion LimitRotation(Quaternion rotation) { }

	// RVA: 0x205CEF0 Offset: 0x205CFF1 VA: 0x205CEF0
	private void Start() { }

	// RVA: 0x205D470 Offset: 0x205D571 VA: 0x205D470
	public void ResetToDefault() { }

	// RVA: 0x205CA40 Offset: 0x205CB41 VA: 0x205CA40
	public void BuildReachCones() { }

	// RVA: 0x205D800 Offset: 0x205D901 VA: 0x205D800
	private Vector3[] SmoothPoints() { }

	// RVA: 0x205DCE0 Offset: 0x205DDE1 VA: 0x205DCE0
	private float GetScalar(int k) { }

	// RVA: 0x205DD30 Offset: 0x205DE31 VA: 0x205DD30
	private Vector3 PointToTangentPlane(Vector3 p, float r) { }

	// RVA: 0x205DD90 Offset: 0x205DE91 VA: 0x205DD90
	private Vector3 TangentPointToSphere(Vector3 q, float r) { }

	// RVA: 0x205D210 Offset: 0x205D311 VA: 0x205D210
	private Quaternion LimitSwing(Quaternion rotation) { }

	// RVA: 0x205DE00 Offset: 0x205DF01 VA: 0x205DE00
	private int GetReachCone(Vector3 L) { }

	// RVA: 0x205DEE0 Offset: 0x205DFE1 VA: 0x205DEE0
	public void .ctor() { }
}

