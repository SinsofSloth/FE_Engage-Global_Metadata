// Namespace: RootMotion.FinalIK
[HelpURLAttribute] // RVA: 0x279900 Offset: 0x279A01 VA: 0x279900
[AddComponentMenu] // RVA: 0x279900 Offset: 0x279A01 VA: 0x279900
public class BipedIK : SolverManager // TypeDefIndex: 14315
{
	// Fields
	public BipedReferences references; // 0x38
	public BipedIKSolvers solvers; // 0x40

	// Methods

	[ContextMenu] // RVA: 0x2CE620 Offset: 0x2CE721 VA: 0x2CE620
	// RVA: 0x2266A70 Offset: 0x2266B71 VA: 0x2266A70
	private void OpenUserManual() { }

	[ContextMenu] // RVA: 0x2CE660 Offset: 0x2CE761 VA: 0x2CE660
	// RVA: 0x2266AC0 Offset: 0x2266BC1 VA: 0x2266AC0
	private void OpenScriptReference() { }

	[ContextMenu] // RVA: 0x2CE6A0 Offset: 0x2CE7A1 VA: 0x2CE6A0
	// RVA: 0x2266B10 Offset: 0x2266C11 VA: 0x2266B10
	private void SupportGroup() { }

	[ContextMenu] // RVA: 0x2CE6E0 Offset: 0x2CE7E1 VA: 0x2CE6E0
	// RVA: 0x2266B60 Offset: 0x2266C61 VA: 0x2266B60
	private void ASThread() { }

	// RVA: 0x2266BB0 Offset: 0x2266CB1 VA: 0x2266BB0
	public float GetIKPositionWeight(AvatarIKGoal goal) { }

	// RVA: 0x2266C90 Offset: 0x2266D91 VA: 0x2266C90
	public float GetIKRotationWeight(AvatarIKGoal goal) { }

	// RVA: 0x2266D10 Offset: 0x2266E11 VA: 0x2266D10
	public void SetIKPositionWeight(AvatarIKGoal goal, float weight) { }

	// RVA: 0x2266D80 Offset: 0x2266E81 VA: 0x2266D80
	public void SetIKRotationWeight(AvatarIKGoal goal, float weight) { }

	// RVA: 0x2266DF0 Offset: 0x2266EF1 VA: 0x2266DF0
	public void SetIKPosition(AvatarIKGoal goal, Vector3 IKPosition) { }

	// RVA: 0x2266E70 Offset: 0x2266F71 VA: 0x2266E70
	public void SetIKRotation(AvatarIKGoal goal, Quaternion IKRotation) { }

	// RVA: 0x2266EE0 Offset: 0x2266FE1 VA: 0x2266EE0
	public Vector3 GetIKPosition(AvatarIKGoal goal) { }

	// RVA: 0x2266F70 Offset: 0x2267071 VA: 0x2266F70
	public Quaternion GetIKRotation(AvatarIKGoal goal) { }

	// RVA: 0x2267010 Offset: 0x2267111 VA: 0x2267010
	public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight, float clampWeightHead, float clampWeightEyes) { }

	// RVA: 0x2267020 Offset: 0x2267121 VA: 0x2267020
	public void SetLookAtPosition(Vector3 lookAtPosition) { }

	// RVA: 0x2267040 Offset: 0x2267141 VA: 0x2267040
	public void SetSpinePosition(Vector3 spinePosition) { }

	// RVA: 0x2267060 Offset: 0x2267161 VA: 0x2267060
	public void SetSpineWeight(float weight) { }

	// RVA: 0x2266C30 Offset: 0x2266D31 VA: 0x2266C30
	public IKSolverLimb GetGoalIK(AvatarIKGoal goal) { }

	// RVA: 0x2267070 Offset: 0x2267171 VA: 0x2267070
	public void InitiateBipedIK() { }

	// RVA: 0x2267080 Offset: 0x2267181 VA: 0x2267080
	public void UpdateBipedIK() { }

	// RVA: 0x2267090 Offset: 0x2267191 VA: 0x2267090
	public void SetToDefaults() { }

	// RVA: 0x2267380 Offset: 0x2267481 VA: 0x2267380 Slot: 6
	protected override void FixTransforms() { }

	// RVA: 0x2267420 Offset: 0x2267521 VA: 0x2267420 Slot: 4
	protected override void InitiateSolver() { }

	// RVA: 0x22676A0 Offset: 0x22677A1 VA: 0x22676A0 Slot: 5
	protected override void UpdateSolver() { }

	// RVA: 0x22677F0 Offset: 0x22678F1 VA: 0x22677F0
	public void LogWarning(string message) { }

	// RVA: 0x2267830 Offset: 0x2267931 VA: 0x2267830
	public void .ctor() { }
}

