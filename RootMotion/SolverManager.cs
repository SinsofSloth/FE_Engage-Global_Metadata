// Namespace: RootMotion
public class SolverManager : MonoBehaviour // TypeDefIndex: 14309
{
	// Fields
	[TooltipAttribute] // RVA: 0x29EA20 Offset: 0x29EB21 VA: 0x29EA20
	public bool fixTransforms; // 0x18
	private Animator animator; // 0x20
	private Animation legacy; // 0x28
	private bool updateFrame; // 0x30
	private bool componentInitiated; // 0x31
	private bool skipSolverUpdate; // 0x32

	// Properties
	private bool animatePhysics { get; }
	private bool isAnimated { get; }

	// Methods

	// RVA: 0x27EADB0 Offset: 0x27EAEB1 VA: 0x27EADB0
	public void Disable() { }

	// RVA: 0x27EADC0 Offset: 0x27EAEC1 VA: 0x27EADC0 Slot: 4
	protected virtual void InitiateSolver() { }

	// RVA: 0x27EADD0 Offset: 0x27EAED1 VA: 0x27EADD0 Slot: 5
	protected virtual void UpdateSolver() { }

	// RVA: 0x27EADE0 Offset: 0x27EAEE1 VA: 0x27EADE0 Slot: 6
	protected virtual void FixTransforms() { }

	// RVA: 0x27EADF0 Offset: 0x27EAEF1 VA: 0x27EADF0
	private void OnDisable() { }

	// RVA: 0x27EAEC0 Offset: 0x27EAFC1 VA: 0x27EAEC0
	private void Start() { }

	// RVA: 0x27EAF20 Offset: 0x27EB021 VA: 0x27EAF20
	private bool get_animatePhysics() { }

	// RVA: 0x27EAE60 Offset: 0x27EAF61 VA: 0x27EAE60
	private void Initiate() { }

	// RVA: 0x27EB220 Offset: 0x27EB321 VA: 0x27EB220
	private void Update() { }

	// RVA: 0x27EB010 Offset: 0x27EB111 VA: 0x27EB010
	private void FindAnimatorRecursive(Transform t, bool findInChildren) { }

	// RVA: 0x27EB270 Offset: 0x27EB371 VA: 0x27EB270
	private bool get_isAnimated() { }

	// RVA: 0x27EB330 Offset: 0x27EB431 VA: 0x27EB330
	private void FixedUpdate() { }

	// RVA: 0x27EB390 Offset: 0x27EB491 VA: 0x27EB390
	private void LateUpdate() { }

	// RVA: 0x27EB3F0 Offset: 0x27EB4F1 VA: 0x27EB3F0
	public void UpdateSolverExternal() { }

	// RVA: 0x27EB440 Offset: 0x27EB541 VA: 0x27EB440
	public void .ctor() { }
}

