// Namespace: RootMotion.FinalIK
[Serializable]
public class Grounding // TypeDefIndex: 14338
{
	// Fields
	[TooltipAttribute] // RVA: 0x29F5C0 Offset: 0x29F6C1 VA: 0x29F5C0
	public LayerMask layers; // 0x10
	[TooltipAttribute] // RVA: 0x29F600 Offset: 0x29F701 VA: 0x29F600
	public float maxStep; // 0x14
	[TooltipAttribute] // RVA: 0x29F640 Offset: 0x29F741 VA: 0x29F640
	public float heightOffset; // 0x18
	[TooltipAttribute] // RVA: 0x29F680 Offset: 0x29F781 VA: 0x29F680
	public float footSpeed; // 0x1C
	[TooltipAttribute] // RVA: 0x29F6C0 Offset: 0x29F7C1 VA: 0x29F6C0
	public float footRadius; // 0x20
	[HideInInspector] // RVA: 0x29F700 Offset: 0x29F801 VA: 0x29F700
	[TooltipAttribute] // RVA: 0x29F700 Offset: 0x29F801 VA: 0x29F700
	public float footCenterOffset; // 0x24
	[TooltipAttribute] // RVA: 0x29F750 Offset: 0x29F851 VA: 0x29F750
	public float prediction; // 0x28
	[RangeAttribute] // RVA: 0x29F790 Offset: 0x29F891 VA: 0x29F790
	[TooltipAttribute] // RVA: 0x29F790 Offset: 0x29F891 VA: 0x29F790
	public float footRotationWeight; // 0x2C
	[TooltipAttribute] // RVA: 0x29F7F0 Offset: 0x29F8F1 VA: 0x29F7F0
	public float footRotationSpeed; // 0x30
	[TooltipAttribute] // RVA: 0x29F830 Offset: 0x29F931 VA: 0x29F830
	[RangeAttribute] // RVA: 0x29F830 Offset: 0x29F931 VA: 0x29F830
	public float maxFootRotationAngle; // 0x34
	[TooltipAttribute] // RVA: 0x29F890 Offset: 0x29F991 VA: 0x29F890
	public bool rotateSolver; // 0x38
	[TooltipAttribute] // RVA: 0x29F8D0 Offset: 0x29F9D1 VA: 0x29F8D0
	public float pelvisSpeed; // 0x3C
	[RangeAttribute] // RVA: 0x29F910 Offset: 0x29FA11 VA: 0x29F910
	[TooltipAttribute] // RVA: 0x29F910 Offset: 0x29FA11 VA: 0x29F910
	public float pelvisDamper; // 0x40
	[TooltipAttribute] // RVA: 0x29F970 Offset: 0x29FA71 VA: 0x29F970
	public float lowerPelvisWeight; // 0x44
	[TooltipAttribute] // RVA: 0x29F9B0 Offset: 0x29FAB1 VA: 0x29F9B0
	public float liftPelvisWeight; // 0x48
	[TooltipAttribute] // RVA: 0x29F9F0 Offset: 0x29FAF1 VA: 0x29F9F0
	public float rootSphereCastRadius; // 0x4C
	[TooltipAttribute] // RVA: 0x29FA30 Offset: 0x29FB31 VA: 0x29FA30
	public bool overstepFallsDown; // 0x50
	[TooltipAttribute] // RVA: 0x29FA70 Offset: 0x29FB71 VA: 0x29FA70
	public Grounding.Quality quality; // 0x54
	[CompilerGeneratedAttribute] // RVA: 0x29FAB0 Offset: 0x29FBB1 VA: 0x29FAB0
	private Grounding.Leg[] <legs>k__BackingField; // 0x58
	[CompilerGeneratedAttribute] // RVA: 0x29FAC0 Offset: 0x29FBC1 VA: 0x29FAC0
	private Grounding.Pelvis <pelvis>k__BackingField; // 0x60
	[CompilerGeneratedAttribute] // RVA: 0x29FAD0 Offset: 0x29FBD1 VA: 0x29FAD0
	private bool <isGrounded>k__BackingField; // 0x68
	[CompilerGeneratedAttribute] // RVA: 0x29FAE0 Offset: 0x29FBE1 VA: 0x29FAE0
	private Transform <root>k__BackingField; // 0x70
	[CompilerGeneratedAttribute] // RVA: 0x29FAF0 Offset: 0x29FBF1 VA: 0x29FAF0
	private RaycastHit <rootHit>k__BackingField; // 0x78
	private bool initiated; // 0xA4

	// Properties
	public Grounding.Leg[] legs { get; set; }
	public Grounding.Pelvis pelvis { get; set; }
	public bool isGrounded { get; set; }
	public Transform root { get; set; }
	public RaycastHit rootHit { get; set; }
	public bool rootGrounded { get; }
	public Vector3 up { get; }
	private bool useRootRotation { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2CEAC0 Offset: 0x2CEBC1 VA: 0x2CEAC0
	// RVA: 0x2DB6AE0 Offset: 0x2DB6BE1 VA: 0x2DB6AE0
	public Grounding.Leg[] get_legs() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CEAD0 Offset: 0x2CEBD1 VA: 0x2CEAD0
	// RVA: 0x2DB6AF0 Offset: 0x2DB6BF1 VA: 0x2DB6AF0
	private void set_legs(Grounding.Leg[] value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2CEAE0 Offset: 0x2CEBE1 VA: 0x2CEAE0
	// RVA: 0x2DB6B00 Offset: 0x2DB6C01 VA: 0x2DB6B00
	public Grounding.Pelvis get_pelvis() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CEAF0 Offset: 0x2CEBF1 VA: 0x2CEAF0
	// RVA: 0x2DB6B10 Offset: 0x2DB6C11 VA: 0x2DB6B10
	private void set_pelvis(Grounding.Pelvis value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2CEB00 Offset: 0x2CEC01 VA: 0x2CEB00
	// RVA: 0x2DB6B20 Offset: 0x2DB6C21 VA: 0x2DB6B20
	public bool get_isGrounded() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CEB10 Offset: 0x2CEC11 VA: 0x2CEB10
	// RVA: 0x2DB6B30 Offset: 0x2DB6C31 VA: 0x2DB6B30
	private void set_isGrounded(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2CEB20 Offset: 0x2CEC21 VA: 0x2CEB20
	// RVA: 0x2DB6B40 Offset: 0x2DB6C41 VA: 0x2DB6B40
	public Transform get_root() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CEB30 Offset: 0x2CEC31 VA: 0x2CEB30
	// RVA: 0x2DB6B50 Offset: 0x2DB6C51 VA: 0x2DB6B50
	private void set_root(Transform value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2CEB40 Offset: 0x2CEC41 VA: 0x2CEB40
	// RVA: 0x2DB6B60 Offset: 0x2DB6C61 VA: 0x2DB6B60
	public RaycastHit get_rootHit() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CEB50 Offset: 0x2CEC51 VA: 0x2CEB50
	// RVA: 0x2DB6B90 Offset: 0x2DB6C91 VA: 0x2DB6B90
	private void set_rootHit(RaycastHit value) { }

	// RVA: 0x2DB6BB0 Offset: 0x2DB6CB1 VA: 0x2DB6BB0
	public bool get_rootGrounded() { }

	// RVA: 0x2DB6C10 Offset: 0x2DB6D11 VA: 0x2DB6C10
	public RaycastHit GetRootHit(float maxDistanceMlp = 10) { }

	// RVA: 0x2DB6E70 Offset: 0x2DB6F71 VA: 0x2DB6E70
	public bool IsValid(ref string errorMessage) { }

	// RVA: 0x2DB0B80 Offset: 0x2DB0C81 VA: 0x2DB0B80
	public void Initiate(Transform root, Transform[] feet) { }

	// RVA: 0x2DB1230 Offset: 0x2DB1331 VA: 0x2DB1230
	public void Update() { }

	// RVA: 0x2DB3030 Offset: 0x2DB3131 VA: 0x2DB3030
	public Vector3 GetLegsPlaneNormal() { }

	// RVA: 0x2DB0690 Offset: 0x2DB0791 VA: 0x2DB0690
	public void Reset() { }

	// RVA: 0x2DB6F90 Offset: 0x2DB7091 VA: 0x2DB6F90
	public void LogWarning(string message) { }

	// RVA: 0x2DB1580 Offset: 0x2DB1681 VA: 0x2DB1580
	public Vector3 get_up() { }

	// RVA: 0x2DB7040 Offset: 0x2DB7141 VA: 0x2DB7040
	public float GetVerticalOffset(Vector3 p1, Vector3 p2) { }

	// RVA: 0x2DB7120 Offset: 0x2DB7221 VA: 0x2DB7120
	public Vector3 Flatten(Vector3 v) { }

	// RVA: 0x2DB6FB0 Offset: 0x2DB70B1 VA: 0x2DB6FB0
	private bool get_useRootRotation() { }

	// RVA: 0x2DB7230 Offset: 0x2DB7331 VA: 0x2DB7230
	public Vector3 GetFootCenterOffset() { }

	// RVA: 0x2DB04E0 Offset: 0x2DB05E1 VA: 0x2DB04E0
	public void .ctor() { }
}

