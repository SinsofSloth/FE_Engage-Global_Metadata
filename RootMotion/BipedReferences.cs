// Namespace: RootMotion
[Serializable]
public class BipedReferences // TypeDefIndex: 14298
{
	// Fields
	public Transform root; // 0x10
	public Transform pelvis; // 0x18
	public Transform leftThigh; // 0x20
	public Transform leftCalf; // 0x28
	public Transform leftFoot; // 0x30
	public Transform rightThigh; // 0x38
	public Transform rightCalf; // 0x40
	public Transform rightFoot; // 0x48
	public Transform leftUpperArm; // 0x50
	public Transform leftForearm; // 0x58
	public Transform leftHand; // 0x60
	public Transform rightUpperArm; // 0x68
	public Transform rightForearm; // 0x70
	public Transform rightHand; // 0x78
	public Transform head; // 0x80
	public Transform[] spine; // 0x88
	public Transform[] eyes; // 0x90

	// Properties
	public virtual bool isFilled { get; }
	public bool isEmpty { get; }

	// Methods

	// RVA: 0x2C72C90 Offset: 0x2C72D91 VA: 0x2C72C90 Slot: 4
	public virtual bool get_isFilled() { }

	// RVA: 0x2C73070 Offset: 0x2C73171 VA: 0x2C73070
	public bool get_isEmpty() { }

	// RVA: 0x2C73080 Offset: 0x2C73181 VA: 0x2C73080 Slot: 5
	public virtual bool IsEmpty(bool includeRoot) { }

	// RVA: 0x2C734A0 Offset: 0x2C735A1 VA: 0x2C734A0 Slot: 6
	public virtual bool Contains(Transform t, bool ignoreRoot = False) { }

	// RVA: 0x2C738C0 Offset: 0x2C739C1 VA: 0x2C738C0
	public static bool AutoDetectReferences(ref BipedReferences references, Transform root, BipedReferences.AutoDetectParams autoDetectParams) { }

	// RVA: 0x2C740B0 Offset: 0x2C741B1 VA: 0x2C740B0
	public static void DetectReferencesByNaming(ref BipedReferences references, Transform root, BipedReferences.AutoDetectParams autoDetectParams) { }

	// RVA: 0x2C73BE0 Offset: 0x2C73CE1 VA: 0x2C73BE0
	public static void AssignHumanoidReferences(ref BipedReferences references, Animator animator, BipedReferences.AutoDetectParams autoDetectParams) { }

	// RVA: 0x2C74910 Offset: 0x2C74A11 VA: 0x2C74910
	public static bool SetupError(BipedReferences references, ref string errorMessage) { }

	// RVA: 0x2C74A10 Offset: 0x2C74B11 VA: 0x2C74A10
	public static bool SetupWarning(BipedReferences references, ref string warningMessage) { }

	// RVA: 0x2C74FC0 Offset: 0x2C750C1 VA: 0x2C74FC0
	private static bool IsNeckBone(Transform bone, Transform leftUpperArm) { }

	// RVA: 0x2C74DA0 Offset: 0x2C74EA1 VA: 0x2C74DA0
	private static bool AddBoneToEyes(Transform bone, ref BipedReferences references, BipedReferences.AutoDetectParams autoDetectParams) { }

	// RVA: 0x2C74C30 Offset: 0x2C74D31 VA: 0x2C74C30
	private static bool AddBoneToSpine(Transform bone, ref BipedReferences references, BipedReferences.AutoDetectParams autoDetectParams) { }

	// RVA: 0x2C74AB0 Offset: 0x2C74BB1 VA: 0x2C74AB0
	private static void DetectLimb(BipedNaming.BoneType boneType, BipedNaming.BoneSide boneSide, ref Transform firstBone, ref Transform secondBone, ref Transform lastBone, Transform[] transforms) { }

	// RVA: 0x2C74EB0 Offset: 0x2C74FB1 VA: 0x2C74EB0
	private static void AddBoneToHierarchy(ref Transform[] bones, Transform transform) { }

	// RVA: 0x2C750C0 Offset: 0x2C751C1 VA: 0x2C750C0
	private static bool LimbError(Transform bone1, Transform bone2, Transform bone3, ref string errorMessage) { }

	// RVA: 0x2C75C70 Offset: 0x2C75D71 VA: 0x2C75C70
	private static bool LimbWarning(Transform bone1, Transform bone2, Transform bone3, ref string warningMessage) { }

	// RVA: 0x2C75710 Offset: 0x2C75811 VA: 0x2C75710
	private static bool SpineError(BipedReferences references, ref string errorMessage) { }

	// RVA: 0x2C75F80 Offset: 0x2C76081 VA: 0x2C75F80
	private static bool SpineWarning(BipedReferences references, ref string warningMessage) { }

	// RVA: 0x2C75A70 Offset: 0x2C75B71 VA: 0x2C75A70
	private static bool EyesError(BipedReferences references, ref string errorMessage) { }

	// RVA: 0x2C75F90 Offset: 0x2C76091 VA: 0x2C75F90
	private static bool EyesWarning(BipedReferences references, ref string warningMessage) { }

	// RVA: 0x2C75FA0 Offset: 0x2C760A1 VA: 0x2C75FA0
	private static bool RootHeightWarning(BipedReferences references, ref string warningMessage) { }

	// RVA: 0x2C76140 Offset: 0x2C76241 VA: 0x2C76140
	private static bool FacingAxisWarning(BipedReferences references, ref string warningMessage) { }

	// RVA: 0x2C762C0 Offset: 0x2C763C1 VA: 0x2C762C0
	private static float GetVerticalOffset(Vector3 p1, Vector3 p2, Quaternion rotation) { }

	// RVA: 0x2C73B50 Offset: 0x2C73C51 VA: 0x2C73B50
	public void .ctor() { }
}

