// Namespace: Cinemachine
[DocumentationSortingAttribute] // RVA: 0x1B0A0 Offset: 0x1B1A1 VA: 0x1B0A0
[SaveDuringPlayAttribute] // RVA: 0x1B0A0 Offset: 0x1B1A1 VA: 0x1B0A0
[ExecuteAlways] // RVA: 0x1B0A0 Offset: 0x1B1A1 VA: 0x1B0A0
[DisallowMultipleComponent] // RVA: 0x1B0A0 Offset: 0x1B1A1 VA: 0x1B0A0
[HelpURLAttribute] // RVA: 0x1B0A0 Offset: 0x1B1A1 VA: 0x1B0A0
[AddComponentMenu] // RVA: 0x1B0A0 Offset: 0x1B1A1 VA: 0x1B0A0
public class CinemachineTargetGroup : MonoBehaviour, ICinemachineTargetGroup // TypeDefIndex: 5777
{
	// Fields
	[TooltipAttribute] // RVA: 0x1E600 Offset: 0x1E701 VA: 0x1E600
	public CinemachineTargetGroup.PositionMode m_PositionMode; // 0x18
	[TooltipAttribute] // RVA: 0x1E640 Offset: 0x1E741 VA: 0x1E640
	public CinemachineTargetGroup.RotationMode m_RotationMode; // 0x1C
	[TooltipAttribute] // RVA: 0x1E680 Offset: 0x1E781 VA: 0x1E680
	public CinemachineTargetGroup.UpdateMethod m_UpdateMethod; // 0x20
	[NoSaveDuringPlayAttribute] // RVA: 0x1E6C0 Offset: 0x1E7C1 VA: 0x1E6C0
	[TooltipAttribute] // RVA: 0x1E6C0 Offset: 0x1E7C1 VA: 0x1E6C0
	public CinemachineTargetGroup.Target[] m_Targets; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x1E710 Offset: 0x1E811 VA: 0x1E710
	private Bounds <BoundingBox>k__BackingField; // 0x30
	private float mMaxWeight; // 0x48
	private Vector3 mAveragePos; // 0x4C

	// Properties
	public Transform Transform { get; }
	public Bounds BoundingBox { get; set; }
	public BoundingSphere Sphere { get; }
	public bool IsEmpty { get; }

	// Methods

	// RVA: 0x1A749D0 Offset: 0x1A74AD1 VA: 0x1A749D0 Slot: 4
	public Transform get_Transform() { }

	[CompilerGeneratedAttribute] // RVA: 0x236B0 Offset: 0x237B1 VA: 0x236B0
	// RVA: 0x1A749E0 Offset: 0x1A74AE1 VA: 0x1A749E0 Slot: 5
	public Bounds get_BoundingBox() { }

	[CompilerGeneratedAttribute] // RVA: 0x236C0 Offset: 0x237C1 VA: 0x236C0
	// RVA: 0x1A74A00 Offset: 0x1A74B01 VA: 0x1A74A00
	private void set_BoundingBox(Bounds value) { }

	// RVA: 0x1A74A20 Offset: 0x1A74B21 VA: 0x1A74A20 Slot: 6
	public BoundingSphere get_Sphere() { }

	// RVA: 0x1A74B00 Offset: 0x1A74C01 VA: 0x1A74B00 Slot: 7
	public bool get_IsEmpty() { }

	// RVA: 0x1A74C10 Offset: 0x1A74D11 VA: 0x1A74C10
	public void AddMember(Transform t, float weight, float radius) { }

	// RVA: 0x1A74D40 Offset: 0x1A74E41 VA: 0x1A74D40
	public void RemoveMember(Transform t) { }

	// RVA: 0x1A74E20 Offset: 0x1A74F21 VA: 0x1A74E20
	public int FindMember(Transform t) { }

	// RVA: 0x1A74F00 Offset: 0x1A75001 VA: 0x1A74F00
	public BoundingSphere GetWeightedBoundsForMember(int index) { }

	// RVA: 0x1A751C0 Offset: 0x1A752C1 VA: 0x1A751C0 Slot: 8
	public Bounds GetViewSpaceBoundingBox(Matrix4x4 observer) { }

	// RVA: 0x1A75020 Offset: 0x1A75121 VA: 0x1A75020
	private static BoundingSphere WeightedMemberBounds(CinemachineTargetGroup.Target t, Vector3 avgPos, float maxWeight) { }

	// RVA: 0x1A75A40 Offset: 0x1A75B41 VA: 0x1A75A40
	public void DoUpdate() { }

	// RVA: 0x1A75B40 Offset: 0x1A75C41 VA: 0x1A75B40
	private Vector3 CalculateAveragePosition(out float maxWeight) { }

	// RVA: 0x1A75F20 Offset: 0x1A76021 VA: 0x1A75F20
	private Quaternion CalculateAverageOrientation() { }

	// RVA: 0x1A75D30 Offset: 0x1A75E31 VA: 0x1A75D30
	private Bounds CalculateBoundingBox(Vector3 avgPos, float maxWeight) { }

	// RVA: 0x1A768B0 Offset: 0x1A769B1 VA: 0x1A768B0
	private void OnValidate() { }

	// RVA: 0x1A76990 Offset: 0x1A76A91 VA: 0x1A76990
	private void FixedUpdate() { }

	// RVA: 0x1A769B0 Offset: 0x1A76AB1 VA: 0x1A769B0
	private void Update() { }

	// RVA: 0x1A769F0 Offset: 0x1A76AF1 VA: 0x1A769F0
	private void LateUpdate() { }

	// RVA: 0x1A76A10 Offset: 0x1A76B11 VA: 0x1A76A10 Slot: 9
	public void GetViewSpaceAngularBounds(Matrix4x4 observer, out Vector2 minAngles, out Vector2 maxAngles, out Vector2 zRange) { }

	// RVA: 0x1A76D60 Offset: 0x1A76E61 VA: 0x1A76D60
	public void .ctor() { }
}

