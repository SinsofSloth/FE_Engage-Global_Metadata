// Namespace: Combat
[DefaultMemberAttribute] // RVA: 0x274AD0 Offset: 0x274BD1 VA: 0x274AD0
public sealed class Puppet : IDisposable // TypeDefIndex: 8842
{
	// Fields
	private GameObject m_BodyInst; // 0x10
	private GameObject m_RideInst; // 0x18
	private AnimationClip m_BodyAnim; // 0x20
	private AnimationClip m_RideAnim; // 0x28
	private CharacterJoint m_Joint; // 0x30
	private ProportionParameters m_Proportion; // 0x38
	private TR m_InitialTransform; // 0x40
	private float m_LastEvalTime; // 0x5C
	private List<GameObject> m_DestroyableGOs; // 0x60
	private Transform[] m_trailSlots; // 0x68
	[CompilerGeneratedAttribute] // RVA: 0x284A20 Offset: 0x284B21 VA: 0x284A20
	private bool <IsValid>k__BackingField; // 0x70

	// Properties
	public Transform RightRoot { get; }
	public Transform RightTip { get; }
	public Transform LeftRoot { get; }
	public Transform LeftTip { get; }
	public AnimationClip HumanAnimationClip { get; }
	public AnimationClip RideAnimationClip { get; }
	public GameObject HumanGameObject { get; }
	public GameObject BaseGameObject { get; }
	public Transform RootTransform { get; }
	public Transform Item { get; }
	public bool IsRiding { get; }
	public bool IsFlying { get; }
	public bool IsHorse { get; }
	public bool IsValid { get; set; }

	// Methods

	// RVA: 0x2EEFD00 Offset: 0x2EEFE01 VA: 0x2EEFD00
	public Transform get_RightRoot() { }

	// RVA: 0x2EEFD30 Offset: 0x2EEFE31 VA: 0x2EEFD30
	public Transform get_RightTip() { }

	// RVA: 0x2EEFD60 Offset: 0x2EEFE61 VA: 0x2EEFD60
	public Transform get_LeftRoot() { }

	// RVA: 0x2EEFD90 Offset: 0x2EEFE91 VA: 0x2EEFD90
	public Transform get_LeftTip() { }

	// RVA: 0x2EEFDC0 Offset: 0x2EEFEC1 VA: 0x2EEFDC0
	public AnimationClip get_HumanAnimationClip() { }

	// RVA: 0x2EEFDD0 Offset: 0x2EEFED1 VA: 0x2EEFDD0
	public AnimationClip get_RideAnimationClip() { }

	// RVA: 0x2EEFDE0 Offset: 0x2EEFEE1 VA: 0x2EEFDE0
	public GameObject get_HumanGameObject() { }

	// RVA: 0x2EEFDF0 Offset: 0x2EEFEF1 VA: 0x2EEFDF0
	public GameObject get_BaseGameObject() { }

	// RVA: 0x2EEFE80 Offset: 0x2EEFF81 VA: 0x2EEFE80
	public Transform get_RootTransform() { }

	// RVA: 0x2EF0090 Offset: 0x2EF0191 VA: 0x2EF0090
	public Transform get_Item(string jointName) { }

	// RVA: 0x2EF0010 Offset: 0x2EF0111 VA: 0x2EF0010
	public bool get_IsRiding() { }

	// RVA: 0x2EF0260 Offset: 0x2EF0361 VA: 0x2EF0260
	public bool get_IsFlying() { }

	// RVA: 0x2EF0290 Offset: 0x2EF0391 VA: 0x2EF0290
	public bool get_IsHorse() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AD610 Offset: 0x2AD711 VA: 0x2AD610
	// RVA: 0x2EF0340 Offset: 0x2EF0441 VA: 0x2EF0340
	public bool get_IsValid() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AD620 Offset: 0x2AD721 VA: 0x2AD620
	// RVA: 0x2EF0350 Offset: 0x2EF0451 VA: 0x2EF0350
	private void set_IsValid(bool value) { }

	// RVA: 0x2EF0360 Offset: 0x2EF0461 VA: 0x2EF0360
	public void .ctor(GameObject bodyInst, AnimationClip bodyAnim, GameObject rideInst, AnimationClip rideAnim) { }

	// RVA: 0x2EF0820 Offset: 0x2EF0921 VA: 0x2EF0820
	private void CreateWeaponTrailSlots() { }

	// RVA: 0x2EF0C70 Offset: 0x2EF0D71 VA: 0x2EF0C70
	private Transform CreateSlot(Transform parent, Vector3 offset, string name) { }

	// RVA: 0x2EF0D60 Offset: 0x2EF0E61 VA: 0x2EF0D60 Slot: 4
	public void Dispose() { }

	// RVA: 0x2EF0FB0 Offset: 0x2EF10B1 VA: 0x2EF0FB0
	public void Evaluate(float time) { }

	// RVA: 0x2EF1080 Offset: 0x2EF1181 VA: 0x2EF1080
	public void ClearRootMovedAfterEvaluate() { }

	// RVA: 0x2EF10B0 Offset: 0x2EF11B1 VA: 0x2EF10B0
	public void AddDestroyableGOs(GameObject[] gos) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AD630 Offset: 0x2AD731 VA: 0x2AD630
	// RVA: 0x2EF0BF0 Offset: 0x2EF0CF1 VA: 0x2EF0BF0
	internal static string <CreateWeaponTrailSlots>g__RL|42_0(string s, int i) { }
}

