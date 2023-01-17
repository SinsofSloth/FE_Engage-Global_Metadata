// Namespace: RootMotion.FinalIK
public class RagdollUtility : MonoBehaviour // TypeDefIndex: 14432
{
	// Fields
	[TooltipAttribute] // RVA: 0x2A39D0 Offset: 0x2A3AD1 VA: 0x2A39D0
	public IK ik; // 0x18
	[TooltipAttribute] // RVA: 0x2A3A10 Offset: 0x2A3B11 VA: 0x2A3A10
	public float ragdollToAnimationTime; // 0x20
	[TooltipAttribute] // RVA: 0x2A3A50 Offset: 0x2A3B51 VA: 0x2A3A50
	public bool applyIkOnRagdoll; // 0x24
	[TooltipAttribute] // RVA: 0x2A3A90 Offset: 0x2A3B91 VA: 0x2A3A90
	public float applyVelocity; // 0x28
	[TooltipAttribute] // RVA: 0x2A3AD0 Offset: 0x2A3BD1 VA: 0x2A3AD0
	public float applyAngularVelocity; // 0x2C
	private Animator animator; // 0x30
	private RagdollUtility.Rigidbone[] rigidbones; // 0x38
	private RagdollUtility.Child[] children; // 0x40
	private bool enableRagdollFlag; // 0x48
	private AnimatorUpdateMode animatorUpdateMode; // 0x4C
	private IK[] allIKComponents; // 0x50
	private bool[] fixTransforms; // 0x58
	private float ragdollWeight; // 0x60
	private float ragdollWeightV; // 0x64
	private bool fixedFrame; // 0x68
	private bool[] disabledIKComponents; // 0x70

	// Properties
	private bool isRagdoll { get; }
	private bool ikUsed { get; }

	// Methods

	// RVA: 0x2766D10 Offset: 0x2766E11 VA: 0x2766D10
	public void EnableRagdoll() { }

	// RVA: 0x2766DF0 Offset: 0x2766EF1 VA: 0x2766DF0
	public void DisableRagdoll() { }

	// RVA: 0x2767000 Offset: 0x2767101 VA: 0x2767000
	public void Start() { }

	[IteratorStateMachineAttribute] // RVA: 0x2D0400 Offset: 0x2D0501 VA: 0x2D0400
	// RVA: 0x2766F80 Offset: 0x2767081 VA: 0x2766F80
	private IEnumerator DisableRagdollSmooth() { }

	// RVA: 0x2767470 Offset: 0x2767571 VA: 0x2767470
	private void Update() { }

	// RVA: 0x27676B0 Offset: 0x27677B1 VA: 0x27676B0
	private void FixedUpdate() { }

	// RVA: 0x27677F0 Offset: 0x27678F1 VA: 0x27677F0
	private void LateUpdate() { }

	// RVA: 0x2767B70 Offset: 0x2767C71 VA: 0x2767B70
	private void AfterLastIK() { }

	// RVA: 0x2767870 Offset: 0x2767971 VA: 0x2767870
	private void AfterAnimation() { }

	// RVA: 0x2767AB0 Offset: 0x2767BB1 VA: 0x2767AB0
	private void OnFinalPose() { }

	// RVA: 0x2767C20 Offset: 0x2767D21 VA: 0x2767C20
	private void RagdollEnabler() { }

	// RVA: 0x2766D80 Offset: 0x2766E81 VA: 0x2766D80
	private bool get_isRagdoll() { }

	// RVA: 0x2767BB0 Offset: 0x2767CB1 VA: 0x2767BB0
	private void RecordVelocities() { }

	// RVA: 0x2767970 Offset: 0x2767A71 VA: 0x2767970
	private bool get_ikUsed() { }

	// RVA: 0x2766F10 Offset: 0x2767011 VA: 0x2766F10
	private void StoreLocalState() { }

	// RVA: 0x2767770 Offset: 0x2767871 VA: 0x2767770
	private void FixTransforms(float weight) { }

	// RVA: 0x2767E70 Offset: 0x2767F71 VA: 0x2767E70
	private void OnDestroy() { }

	// RVA: 0x2766BD0 Offset: 0x2766CD1 VA: 0x2766BD0
	public void .ctor() { }
}

