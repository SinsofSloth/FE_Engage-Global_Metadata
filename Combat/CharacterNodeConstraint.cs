// Namespace: Combat
[DefaultExecutionOrder] // RVA: 0x273EB0 Offset: 0x273FB1 VA: 0x273EB0
[DisallowMultipleComponent] // RVA: 0x273EB0 Offset: 0x273FB1 VA: 0x273EB0
public abstract class CharacterNodeConstraint : MonoBehaviour // TypeDefIndex: 8623
{
	// Fields
	private CharacterNodeConstraint.State state; // 0x18
	[TooltipAttribute] // RVA: 0x2829D0 Offset: 0x282AD1 VA: 0x2829D0
	public Transform[] SpecialPurposeCameraNodes; // 0x20
	public Transform[] SpecialPurposeParticleNodes; // 0x28
	private Vector3[] specialPurposeParticleNodesOffset; // 0x30
	private Transform _ctr; // 0x38

	// Properties
	private Transform CTR { get; }

	// Methods

	// RVA: 0x29B3F90 Offset: 0x29B4091 VA: 0x29B3F90
	private Transform get_CTR() { }

	// RVA: 0x29B40D0 Offset: 0x29B41D1 VA: 0x29B40D0
	private void AllocOnce() { }

	// RVA: 0x29B4150 Offset: 0x29B4251 VA: 0x29B4150
	public void LateUpdate() { }

	// RVA: 0x29B4420 Offset: 0x29B4521 VA: 0x29B4420
	public void SetNodeOffset(Transform node, Vector3 offset) { }

	// RVA: 0x29B4600 Offset: 0x29B4701 VA: 0x29B4600
	protected void .ctor() { }
}

