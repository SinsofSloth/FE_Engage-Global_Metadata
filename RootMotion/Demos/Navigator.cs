// Namespace: RootMotion.Demos
[Serializable]
public class Navigator // TypeDefIndex: 14491
{
	// Fields
	[TooltipAttribute] // RVA: 0x2A62A0 Offset: 0x2A63A1 VA: 0x2A62A0
	public bool activeTargetSeeking; // 0x10
	[TooltipAttribute] // RVA: 0x2A62E0 Offset: 0x2A63E1 VA: 0x2A62E0
	public float cornerRadius; // 0x14
	[TooltipAttribute] // RVA: 0x2A6320 Offset: 0x2A6421 VA: 0x2A6320
	public float recalculateOnPathDistance; // 0x18
	[TooltipAttribute] // RVA: 0x2A6360 Offset: 0x2A6461 VA: 0x2A6360
	public float maxSampleDistance; // 0x1C
	[TooltipAttribute] // RVA: 0x2A63A0 Offset: 0x2A64A1 VA: 0x2A63A0
	public float nextPathInterval; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x2A63E0 Offset: 0x2A64E1 VA: 0x2A63E0
	private Vector3 <normalizedDeltaPosition>k__BackingField; // 0x24
	[CompilerGeneratedAttribute] // RVA: 0x2A63F0 Offset: 0x2A64F1 VA: 0x2A63F0
	private Navigator.State <state>k__BackingField; // 0x30
	private Transform transform; // 0x38
	private int cornerIndex; // 0x40
	private Vector3[] corners; // 0x48
	private NavMeshPath path; // 0x50
	private Vector3 lastTargetPosition; // 0x58
	private bool initiated; // 0x64
	private float nextPathTime; // 0x68

	// Properties
	public Vector3 normalizedDeltaPosition { get; set; }
	public Navigator.State state { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2D0C60 Offset: 0x2D0D61 VA: 0x2D0C60
	// RVA: 0x2351BF0 Offset: 0x2351CF1 VA: 0x2351BF0
	public Vector3 get_normalizedDeltaPosition() { }

	[CompilerGeneratedAttribute] // RVA: 0x2D0C70 Offset: 0x2D0D71 VA: 0x2D0C70
	// RVA: 0x2351C00 Offset: 0x2351D01 VA: 0x2351C00
	private void set_normalizedDeltaPosition(Vector3 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2D0C80 Offset: 0x2D0D81 VA: 0x2D0C80
	// RVA: 0x2351C10 Offset: 0x2351D11 VA: 0x2351C10
	public Navigator.State get_state() { }

	[CompilerGeneratedAttribute] // RVA: 0x2D0C90 Offset: 0x2D0D91 VA: 0x2D0C90
	// RVA: 0x2351C20 Offset: 0x2351D21 VA: 0x2351C20
	private void set_state(Navigator.State value) { }

	// RVA: 0x2351C30 Offset: 0x2351D31 VA: 0x2351C30
	public void Initiate(Transform transform) { }

	// RVA: 0x2351D10 Offset: 0x2351E11 VA: 0x2351D10
	public void Update(Vector3 targetPosition) { }

	// RVA: 0x2352000 Offset: 0x2352101 VA: 0x2352000
	private void CalculatePath(Vector3 targetPosition) { }

	// RVA: 0x2352090 Offset: 0x2352191 VA: 0x2352090
	private bool Find(Vector3 targetPosition) { }

	// RVA: 0x2351FA0 Offset: 0x23520A1 VA: 0x2351FA0
	private void Stop() { }

	// RVA: 0x2351FE0 Offset: 0x23520E1 VA: 0x2351FE0
	private float HorDistance(Vector3 p1, Vector3 p2) { }

	// RVA: 0x23521D0 Offset: 0x23522D1 VA: 0x23521D0
	public void Visualize() { }

	// RVA: 0x2352390 Offset: 0x2352491 VA: 0x2352390
	public void .ctor() { }
}

