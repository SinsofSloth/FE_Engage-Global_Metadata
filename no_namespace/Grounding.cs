// Namespace: 
public class Grounding.Leg // TypeDefIndex: 14336
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x29FB00 Offset: 0x29FC01 VA: 0x29FB00
	private bool <isGrounded>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x29FB10 Offset: 0x29FC11 VA: 0x29FB10
	private Vector3 <IKPosition>k__BackingField; // 0x14
	public Quaternion rotationOffset; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x29FB20 Offset: 0x29FC21 VA: 0x29FB20
	private bool <initiated>k__BackingField; // 0x30
	[CompilerGeneratedAttribute] // RVA: 0x29FB30 Offset: 0x29FC31 VA: 0x29FB30
	private float <heightFromGround>k__BackingField; // 0x34
	[CompilerGeneratedAttribute] // RVA: 0x29FB40 Offset: 0x29FC41 VA: 0x29FB40
	private Vector3 <velocity>k__BackingField; // 0x38
	[CompilerGeneratedAttribute] // RVA: 0x29FB50 Offset: 0x29FC51 VA: 0x29FB50
	private Transform <transform>k__BackingField; // 0x48
	[CompilerGeneratedAttribute] // RVA: 0x29FB60 Offset: 0x29FC61 VA: 0x29FB60
	private float <IKOffset>k__BackingField; // 0x50
	public bool invertFootCenter; // 0x54
	[CompilerGeneratedAttribute] // RVA: 0x29FB70 Offset: 0x29FC71 VA: 0x29FB70
	private RaycastHit <heelHit>k__BackingField; // 0x58
	[CompilerGeneratedAttribute] // RVA: 0x29FB80 Offset: 0x29FC81 VA: 0x29FB80
	private RaycastHit <capsuleHit>k__BackingField; // 0x84
	private Grounding grounding; // 0xB0
	private double lastTime; // 0xB8
	private double deltaTime; // 0xC0
	private Vector3 lastPosition; // 0xC8
	private Quaternion toHitNormal; // 0xD4
	private Quaternion r; // 0xE4
	private Vector3 up; // 0xF4
	private bool doOverrideFootPosition; // 0x100
	private Vector3 overrideFootPosition; // 0x104
	private Vector3 transformPosition; // 0x110

	// Properties
	public bool isGrounded { get; set; }
	public Vector3 IKPosition { get; set; }
	public bool initiated { get; set; }
	public float heightFromGround { get; set; }
	public Vector3 velocity { get; set; }
	public Transform transform { get; set; }
	public float IKOffset { get; set; }
	public RaycastHit heelHit { get; set; }
	public RaycastHit capsuleHit { get; set; }
	public RaycastHit GetHitPoint { get; }
	public float stepHeightFromGround { get; }
	private float rootYOffset { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2CEB60 Offset: 0x2CEC61 VA: 0x2CEB60
	// RVA: 0x1FA4F00 Offset: 0x1FA5001 VA: 0x1FA4F00
	public bool get_isGrounded() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CEB70 Offset: 0x2CEC71 VA: 0x2CEB70
	// RVA: 0x1FA4F10 Offset: 0x1FA5011 VA: 0x1FA4F10
	private void set_isGrounded(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2CEB80 Offset: 0x2CEC81 VA: 0x2CEB80
	// RVA: 0x1FA4F20 Offset: 0x1FA5021 VA: 0x1FA4F20
	public Vector3 get_IKPosition() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CEB90 Offset: 0x2CEC91 VA: 0x2CEB90
	// RVA: 0x1FA4F30 Offset: 0x1FA5031 VA: 0x1FA4F30
	private void set_IKPosition(Vector3 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2CEBA0 Offset: 0x2CECA1 VA: 0x2CEBA0
	// RVA: 0x1FA4F40 Offset: 0x1FA5041 VA: 0x1FA4F40
	public bool get_initiated() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CEBB0 Offset: 0x2CECB1 VA: 0x2CEBB0
	// RVA: 0x1FA4F50 Offset: 0x1FA5051 VA: 0x1FA4F50
	private void set_initiated(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2CEBC0 Offset: 0x2CECC1 VA: 0x2CEBC0
	// RVA: 0x1FA4F60 Offset: 0x1FA5061 VA: 0x1FA4F60
	public float get_heightFromGround() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CEBD0 Offset: 0x2CECD1 VA: 0x2CEBD0
	// RVA: 0x1FA4F70 Offset: 0x1FA5071 VA: 0x1FA4F70
	private void set_heightFromGround(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2CEBE0 Offset: 0x2CECE1 VA: 0x2CEBE0
	// RVA: 0x1FA4F80 Offset: 0x1FA5081 VA: 0x1FA4F80
	public Vector3 get_velocity() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CEBF0 Offset: 0x2CECF1 VA: 0x2CEBF0
	// RVA: 0x1FA4F90 Offset: 0x1FA5091 VA: 0x1FA4F90
	private void set_velocity(Vector3 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2CEC00 Offset: 0x2CED01 VA: 0x2CEC00
	// RVA: 0x1FA4FA0 Offset: 0x1FA50A1 VA: 0x1FA4FA0
	public Transform get_transform() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CEC10 Offset: 0x2CED11 VA: 0x2CEC10
	// RVA: 0x1FA4FB0 Offset: 0x1FA50B1 VA: 0x1FA4FB0
	private void set_transform(Transform value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2CEC20 Offset: 0x2CED21 VA: 0x2CEC20
	// RVA: 0x1FA4FC0 Offset: 0x1FA50C1 VA: 0x1FA4FC0
	public float get_IKOffset() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CEC30 Offset: 0x2CED31 VA: 0x2CEC30
	// RVA: 0x1FA4FD0 Offset: 0x1FA50D1 VA: 0x1FA4FD0
	private void set_IKOffset(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2CEC40 Offset: 0x2CED41 VA: 0x2CEC40
	// RVA: 0x1FA4FE0 Offset: 0x1FA50E1 VA: 0x1FA4FE0
	public RaycastHit get_heelHit() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CEC50 Offset: 0x2CED51 VA: 0x2CEC50
	// RVA: 0x1FA5010 Offset: 0x1FA5111 VA: 0x1FA5010
	private void set_heelHit(RaycastHit value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2CEC60 Offset: 0x2CED61 VA: 0x2CEC60
	// RVA: 0x1FA5030 Offset: 0x1FA5131 VA: 0x1FA5030
	public RaycastHit get_capsuleHit() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CEC70 Offset: 0x2CED71 VA: 0x2CEC70
	// RVA: 0x1FA5060 Offset: 0x1FA5161 VA: 0x1FA5060
	private void set_capsuleHit(RaycastHit value) { }

	// RVA: 0x1FA5080 Offset: 0x1FA5181 VA: 0x1FA5080
	public RaycastHit get_GetHitPoint() { }

	// RVA: 0x1FA50E0 Offset: 0x1FA51E1 VA: 0x1FA50E0
	public void SetFootPosition(Vector3 position) { }

	// RVA: 0x1FA5100 Offset: 0x1FA5201 VA: 0x1FA5100
	public void Initiate(Grounding grounding, Transform transform) { }

	// RVA: 0x1FA51C0 Offset: 0x1FA52C1 VA: 0x1FA51C0
	public void OnEnable() { }

	// RVA: 0x1FA5210 Offset: 0x1FA5311 VA: 0x1FA5210
	public void Reset() { }

	// RVA: 0x1FA5290 Offset: 0x1FA5391 VA: 0x1FA5290
	public void Process() { }

	// RVA: 0x1FA6570 Offset: 0x1FA6671 VA: 0x1FA6570
	public float get_stepHeightFromGround() { }

	// RVA: 0x1FA6230 Offset: 0x1FA6331 VA: 0x1FA6230
	private RaycastHit GetCapsuleHit(Vector3 offsetFromHeel) { }

	// RVA: 0x1FA5C10 Offset: 0x1FA5D11 VA: 0x1FA5C10
	private RaycastHit GetRaycastHit(Vector3 offsetFromHeel) { }

	// RVA: 0x1FA6600 Offset: 0x1FA6701 VA: 0x1FA6600
	private Vector3 RotateNormal(Vector3 normal) { }

	// RVA: 0x1FA5E70 Offset: 0x1FA5F71 VA: 0x1FA5E70
	private void SetFootToPoint(Vector3 normal, Vector3 point) { }

	// RVA: 0x1FA5FC0 Offset: 0x1FA60C1 VA: 0x1FA5FC0
	private void SetFootToPlane(Vector3 planeNormal, Vector3 planePoint, Vector3 heelHitPoint) { }

	// RVA: 0x1FA6670 Offset: 0x1FA6771 VA: 0x1FA6670
	private float GetHeightFromGround(Vector3 hitPoint) { }

	// RVA: 0x1FA6590 Offset: 0x1FA6691 VA: 0x1FA6590
	private void RotateFoot() { }

	// RVA: 0x1FA67C0 Offset: 0x1FA68C1 VA: 0x1FA67C0
	private Quaternion GetRotationOffsetTarget() { }

	// RVA: 0x1FA6730 Offset: 0x1FA6831 VA: 0x1FA6730
	private float get_rootYOffset() { }

	// RVA: 0x1FA6860 Offset: 0x1FA6961 VA: 0x1FA6860
	public void .ctor() { }
}

