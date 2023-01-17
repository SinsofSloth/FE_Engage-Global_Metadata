// Namespace: RootMotion.FinalIK
[Serializable]
public class IKSolverFullBodyBiped : IKSolverFullBody // TypeDefIndex: 14382
{
	// Fields
	public Transform rootNode; // 0xD0
	[RangeAttribute] // RVA: 0x2A0BA0 Offset: 0x2A0CA1 VA: 0x2A0BA0
	public float spineStiffness; // 0xD8
	[RangeAttribute] // RVA: 0x2A0BC0 Offset: 0x2A0CC1 VA: 0x2A0BC0
	public float pullBodyVertical; // 0xDC
	[RangeAttribute] // RVA: 0x2A0BE0 Offset: 0x2A0CE1 VA: 0x2A0BE0
	public float pullBodyHorizontal; // 0xE0
	[CompilerGeneratedAttribute] // RVA: 0x2A0C00 Offset: 0x2A0D01 VA: 0x2A0C00
	private Vector3 <pullBodyOffset>k__BackingField; // 0xE4
	private Vector3 offset; // 0xF0

	// Properties
	public IKEffector bodyEffector { get; }
	public IKEffector leftShoulderEffector { get; }
	public IKEffector rightShoulderEffector { get; }
	public IKEffector leftThighEffector { get; }
	public IKEffector rightThighEffector { get; }
	public IKEffector leftHandEffector { get; }
	public IKEffector rightHandEffector { get; }
	public IKEffector leftFootEffector { get; }
	public IKEffector rightFootEffector { get; }
	public FBIKChain leftArmChain { get; }
	public FBIKChain rightArmChain { get; }
	public FBIKChain leftLegChain { get; }
	public FBIKChain rightLegChain { get; }
	public IKMappingLimb leftArmMapping { get; }
	public IKMappingLimb rightArmMapping { get; }
	public IKMappingLimb leftLegMapping { get; }
	public IKMappingLimb rightLegMapping { get; }
	public IKMappingBone headMapping { get; }
	public Vector3 pullBodyOffset { get; set; }

	// Methods

	// RVA: 0x3C64A70 Offset: 0x3C64B71 VA: 0x3C64A70
	public IKEffector get_bodyEffector() { }

	// RVA: 0x3C64BE0 Offset: 0x3C64CE1 VA: 0x3C64BE0
	public IKEffector get_leftShoulderEffector() { }

	// RVA: 0x3C64C10 Offset: 0x3C64D11 VA: 0x3C64C10
	public IKEffector get_rightShoulderEffector() { }

	// RVA: 0x3C64C40 Offset: 0x3C64D41 VA: 0x3C64C40
	public IKEffector get_leftThighEffector() { }

	// RVA: 0x3C64C70 Offset: 0x3C64D71 VA: 0x3C64C70
	public IKEffector get_rightThighEffector() { }

	// RVA: 0x3C64CA0 Offset: 0x3C64DA1 VA: 0x3C64CA0
	public IKEffector get_leftHandEffector() { }

	// RVA: 0x3C64CD0 Offset: 0x3C64DD1 VA: 0x3C64CD0
	public IKEffector get_rightHandEffector() { }

	// RVA: 0x3C64D00 Offset: 0x3C64E01 VA: 0x3C64D00
	public IKEffector get_leftFootEffector() { }

	// RVA: 0x3C64D30 Offset: 0x3C64E31 VA: 0x3C64D30
	public IKEffector get_rightFootEffector() { }

	// RVA: 0x3C64D60 Offset: 0x3C64E61 VA: 0x3C64D60
	public FBIKChain get_leftArmChain() { }

	// RVA: 0x3C64D90 Offset: 0x3C64E91 VA: 0x3C64D90
	public FBIKChain get_rightArmChain() { }

	// RVA: 0x3C64DC0 Offset: 0x3C64EC1 VA: 0x3C64DC0
	public FBIKChain get_leftLegChain() { }

	// RVA: 0x3C64DF0 Offset: 0x3C64EF1 VA: 0x3C64DF0
	public FBIKChain get_rightLegChain() { }

	// RVA: 0x3C64E20 Offset: 0x3C64F21 VA: 0x3C64E20
	public IKMappingLimb get_leftArmMapping() { }

	// RVA: 0x3C64E50 Offset: 0x3C64F51 VA: 0x3C64E50
	public IKMappingLimb get_rightArmMapping() { }

	// RVA: 0x3C64E80 Offset: 0x3C64F81 VA: 0x3C64E80
	public IKMappingLimb get_leftLegMapping() { }

	// RVA: 0x3C64EB0 Offset: 0x3C64FB1 VA: 0x3C64EB0
	public IKMappingLimb get_rightLegMapping() { }

	// RVA: 0x3C64EE0 Offset: 0x3C64FE1 VA: 0x3C64EE0
	public IKMappingBone get_headMapping() { }

	// RVA: 0x3C64F10 Offset: 0x3C65011 VA: 0x3C64F10
	public void SetChainWeights(FullBodyBipedChain c, float pull, float reach = 0) { }

	// RVA: 0x3C65020 Offset: 0x3C65121 VA: 0x3C65020
	public void SetEffectorWeights(FullBodyBipedEffector effector, float positionWeight, float rotationWeight) { }

	// RVA: 0x3C64F60 Offset: 0x3C65061 VA: 0x3C64F60
	public FBIKChain GetChain(FullBodyBipedChain c) { }

	// RVA: 0x3C650B0 Offset: 0x3C651B1 VA: 0x3C650B0
	public FBIKChain GetChain(FullBodyBipedEffector effector) { }

	// RVA: 0x3C64AA0 Offset: 0x3C64BA1 VA: 0x3C64AA0
	public IKEffector GetEffector(FullBodyBipedEffector effector) { }

	// RVA: 0x3C651D0 Offset: 0x3C652D1 VA: 0x3C651D0
	public IKEffector GetEndEffector(FullBodyBipedChain c) { }

	// RVA: 0x3C65290 Offset: 0x3C65391 VA: 0x3C65290
	public IKMappingLimb GetLimbMapping(FullBodyBipedChain chain) { }

	// RVA: 0x3C65340 Offset: 0x3C65441 VA: 0x3C65340
	public IKMappingLimb GetLimbMapping(FullBodyBipedEffector effector) { }

	// RVA: 0x3C65440 Offset: 0x3C65541 VA: 0x3C65440
	public IKMappingSpine GetSpineMapping() { }

	// RVA: 0x3C65450 Offset: 0x3C65551 VA: 0x3C65450
	public IKMappingBone GetHeadMapping() { }

	// RVA: 0x3C65480 Offset: 0x3C65581 VA: 0x3C65480
	public IKConstraintBend GetBendConstraint(FullBodyBipedChain limb) { }

	// RVA: 0x3C65560 Offset: 0x3C65661 VA: 0x3C65560 Slot: 4
	public override bool IsValid(ref string message) { }

	// RVA: 0x3C656D0 Offset: 0x3C657D1 VA: 0x3C656D0
	public void SetToReferences(BipedReferences references, Transform rootNode) { }

	// RVA: 0x3C66A20 Offset: 0x3C66B21 VA: 0x3C66A20
	public static Transform DetectRootNodeBone(BipedReferences references) { }

	// RVA: 0x3C66E20 Offset: 0x3C66F21 VA: 0x3C66E20
	public void SetLimbOrientations(BipedLimbOrientations o) { }

	[CompilerGeneratedAttribute] // RVA: 0x2CF9E0 Offset: 0x2CFAE1 VA: 0x2CF9E0
	// RVA: 0x3C67170 Offset: 0x3C67271 VA: 0x3C67170
	public Vector3 get_pullBodyOffset() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CF9F0 Offset: 0x2CFAF1 VA: 0x2CF9F0
	// RVA: 0x3C67180 Offset: 0x3C67281 VA: 0x3C67180
	private void set_pullBodyOffset(Vector3 value) { }

	// RVA: 0x3C67070 Offset: 0x3C67171 VA: 0x3C67070
	private void SetLimbOrientation(FullBodyBipedChain chain, BipedLimbOrientations.LimbOrientation limbOrientation) { }

	// RVA: 0x3C66CA0 Offset: 0x3C66DA1 VA: 0x3C66CA0
	private static Transform GetLeftClavicle(BipedReferences references) { }

	// RVA: 0x3C66D60 Offset: 0x3C66E61 VA: 0x3C66D60
	private static Transform GetRightClavicle(BipedReferences references) { }

	// RVA: 0x3C67190 Offset: 0x3C67291 VA: 0x3C67190
	private static bool Contains(Transform[] array, Transform transform) { }

	// RVA: 0x3C67260 Offset: 0x3C67361 VA: 0x3C67260 Slot: 12
	protected override void ReadPose() { }

	// RVA: 0x3C67340 Offset: 0x3C67441 VA: 0x3C67340
	private void PullBody() { }

	// RVA: 0x3C67470 Offset: 0x3C67571 VA: 0x3C67470
	private Vector3 GetBodyOffset() { }

	// RVA: 0x3C675E0 Offset: 0x3C676E1 VA: 0x3C675E0
	private Vector3 GetHandBodyPull(IKEffector effector, FBIKChain arm, Vector3 offset) { }

	// RVA: 0x3C676F0 Offset: 0x3C677F1 VA: 0x3C676F0 Slot: 14
	protected override void ApplyBendConstraints() { }

	// RVA: 0x3C67A40 Offset: 0x3C67B41 VA: 0x3C67A40 Slot: 15
	protected override void WritePose() { }

	// RVA: 0x3C67AD0 Offset: 0x3C67BD1 VA: 0x3C67AD0
	public void .ctor() { }
}

