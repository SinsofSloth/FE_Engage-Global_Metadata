// Namespace: 
[Serializable]
public enum IKSolverVR.Arm.ShoulderRotationMode // TypeDefIndex: 14392
{
	// Fields
	public int value__; // 0x0
	public const IKSolverVR.Arm.ShoulderRotationMode YawPitch = 0;
	public const IKSolverVR.Arm.ShoulderRotationMode FromTo = 1;
}

// Namespace: 
[Serializable]
public class IKSolverVR.Arm : IKSolverVR.BodyPart // TypeDefIndex: 14393
{
	// Fields
	[TooltipAttribute] // RVA: 0x2A0FE0 Offset: 0x2A10E1 VA: 0x2A0FE0
	public Transform target; // 0x48
	[TooltipAttribute] // RVA: 0x2A1020 Offset: 0x2A1121 VA: 0x2A1020
	public Transform bendGoal; // 0x50
	[TooltipAttribute] // RVA: 0x2A1060 Offset: 0x2A1161 VA: 0x2A1060
	[RangeAttribute] // RVA: 0x2A1060 Offset: 0x2A1161 VA: 0x2A1060
	public float positionWeight; // 0x58
	[TooltipAttribute] // RVA: 0x2A10C0 Offset: 0x2A11C1 VA: 0x2A10C0
	[RangeAttribute] // RVA: 0x2A10C0 Offset: 0x2A11C1 VA: 0x2A10C0
	public float rotationWeight; // 0x5C
	[TooltipAttribute] // RVA: 0x2A1120 Offset: 0x2A1221 VA: 0x2A1120
	public IKSolverVR.Arm.ShoulderRotationMode shoulderRotationMode; // 0x60
	[TooltipAttribute] // RVA: 0x2A1160 Offset: 0x2A1261 VA: 0x2A1160
	[RangeAttribute] // RVA: 0x2A1160 Offset: 0x2A1261 VA: 0x2A1160
	public float shoulderRotationWeight; // 0x64
	[RangeAttribute] // RVA: 0x2A11C0 Offset: 0x2A12C1 VA: 0x2A11C0
	[TooltipAttribute] // RVA: 0x2A11C0 Offset: 0x2A12C1 VA: 0x2A11C0
	public float shoulderTwistWeight; // 0x68
	[RangeAttribute] // RVA: 0x2A1220 Offset: 0x2A1321 VA: 0x2A1220
	[TooltipAttribute] // RVA: 0x2A1220 Offset: 0x2A1321 VA: 0x2A1220
	public float bendGoalWeight; // 0x6C
	[RangeAttribute] // RVA: 0x2A1280 Offset: 0x2A1381 VA: 0x2A1280
	[TooltipAttribute] // RVA: 0x2A1280 Offset: 0x2A1381 VA: 0x2A1280
	public float swivelOffset; // 0x70
	[TooltipAttribute] // RVA: 0x2A12E0 Offset: 0x2A13E1 VA: 0x2A12E0
	public Vector3 wristToPalmAxis; // 0x74
	[TooltipAttribute] // RVA: 0x2A1320 Offset: 0x2A1421 VA: 0x2A1320
	public Vector3 palmToThumbAxis; // 0x80
	[RangeAttribute] // RVA: 0x2A1360 Offset: 0x2A1461 VA: 0x2A1360
	[TooltipAttribute] // RVA: 0x2A1360 Offset: 0x2A1461 VA: 0x2A1360
	public float armLengthMlp; // 0x8C
	[TooltipAttribute] // RVA: 0x2A13C0 Offset: 0x2A14C1 VA: 0x2A13C0
	public AnimationCurve stretchCurve; // 0x90
	[HideInInspector] // RVA: 0x2A1400 Offset: 0x2A1501 VA: 0x2A1400
	public Vector3 IKPosition; // 0x98
	[HideInInspector] // RVA: 0x2A1410 Offset: 0x2A1511 VA: 0x2A1410
	public Quaternion IKRotation; // 0xA4
	[HideInInspector] // RVA: 0x2A1420 Offset: 0x2A1521 VA: 0x2A1420
	public Vector3 bendDirection; // 0xB4
	[HideInInspector] // RVA: 0x2A1430 Offset: 0x2A1531 VA: 0x2A1430
	public Vector3 handPositionOffset; // 0xC0
	[CompilerGeneratedAttribute] // RVA: 0x2A1440 Offset: 0x2A1541 VA: 0x2A1440
	private Vector3 <position>k__BackingField; // 0xCC
	[CompilerGeneratedAttribute] // RVA: 0x2A1450 Offset: 0x2A1551 VA: 0x2A1450
	private Quaternion <rotation>k__BackingField; // 0xD8
	private bool hasShoulder; // 0xE8
	private Vector3 chestForwardAxis; // 0xEC
	private Vector3 chestUpAxis; // 0xF8
	private Quaternion chestRotation; // 0x104
	private Vector3 chestForward; // 0x114
	private Vector3 chestUp; // 0x120
	private Quaternion forearmRelToUpperArm; // 0x12C
	private Vector3 upperArmBendAxis; // 0x13C
	private const float yawOffsetAngle = 45;
	private const float pitchOffsetAngle = -30;

	// Properties
	public Vector3 position { get; set; }
	public Quaternion rotation { get; set; }
	private IKSolverVR.VirtualBone shoulder { get; }
	private IKSolverVR.VirtualBone upperArm { get; }
	private IKSolverVR.VirtualBone forearm { get; }
	private IKSolverVR.VirtualBone hand { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2CFA20 Offset: 0x2CFB21 VA: 0x2CFA20
	// RVA: 0x35FD280 Offset: 0x35FD381 VA: 0x35FD280
	public Vector3 get_position() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CFA30 Offset: 0x2CFB31 VA: 0x2CFA30
	// RVA: 0x35FD290 Offset: 0x35FD391 VA: 0x35FD290
	private void set_position(Vector3 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2CFA40 Offset: 0x2CFB41 VA: 0x2CFA40
	// RVA: 0x35FD2A0 Offset: 0x35FD3A1 VA: 0x35FD2A0
	public Quaternion get_rotation() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CFA50 Offset: 0x2CFB51 VA: 0x2CFA50
	// RVA: 0x35FD2B0 Offset: 0x35FD3B1 VA: 0x35FD2B0
	private void set_rotation(Quaternion value) { }

	// RVA: 0x35FD2D0 Offset: 0x35FD3D1 VA: 0x35FD2D0
	private IKSolverVR.VirtualBone get_shoulder() { }

	// RVA: 0x35FD300 Offset: 0x35FD401 VA: 0x35FD300
	private IKSolverVR.VirtualBone get_upperArm() { }

	// RVA: 0x35FD340 Offset: 0x35FD441 VA: 0x35FD340
	private IKSolverVR.VirtualBone get_forearm() { }

	// RVA: 0x35FD390 Offset: 0x35FD491 VA: 0x35FD390
	private IKSolverVR.VirtualBone get_hand() { }

	// RVA: 0x35FD3E0 Offset: 0x35FD4E1 VA: 0x35FD3E0 Slot: 4
	protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index) { }

	// RVA: 0x35FDC20 Offset: 0x35FDD21 VA: 0x35FDC20 Slot: 5
	public override void PreSolve() { }

	// RVA: 0x35FDE10 Offset: 0x35FDF11 VA: 0x35FDE10 Slot: 7
	public override void ApplyOffsets(float scale) { }

	// RVA: 0x35FDE40 Offset: 0x35FDF41 VA: 0x35FDE40
	private void Stretching() { }

	// RVA: 0x35FE130 Offset: 0x35FE231 VA: 0x35FE130
	public void Solve(bool isLeft) { }

	// RVA: 0x35FF7D0 Offset: 0x35FF8D1 VA: 0x35FF7D0 Slot: 8
	public override void ResetOffsets() { }

	// RVA: 0x35FF800 Offset: 0x35FF901 VA: 0x35FF800 Slot: 6
	public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations) { }

	// RVA: 0x35FF230 Offset: 0x35FF331 VA: 0x35FF230
	private float DamperValue(float value, float min, float max, float weight = 1) { }

	// RVA: 0x35FF2B0 Offset: 0x35FF3B1 VA: 0x35FF2B0
	private Vector3 GetBendNormal(Vector3 dir) { }

	// RVA: 0x35FFAA0 Offset: 0x35FFBA1 VA: 0x35FFAA0
	private void Visualize(IKSolverVR.VirtualBone bone1, IKSolverVR.VirtualBone bone2, IKSolverVR.VirtualBone bone3, Color color) { }

	// RVA: 0x35FFAB0 Offset: 0x35FFBB1 VA: 0x35FFAB0
	public void .ctor() { }
}

// Namespace: 
[Serializable]
public abstract class IKSolverVR.BodyPart // TypeDefIndex: 14394
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x2A1460 Offset: 0x2A1561 VA: 0x2A1460
	private float <sqrMag>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x2A1470 Offset: 0x2A1571 VA: 0x2A1470
	private float <mag>k__BackingField; // 0x14
	[HideInInspector] // RVA: 0x2A1480 Offset: 0x2A1581 VA: 0x2A1480
	public IKSolverVR.VirtualBone[] bones; // 0x18
	protected bool initiated; // 0x20
	protected Vector3 rootPosition; // 0x24
	protected Quaternion rootRotation; // 0x30
	protected int index; // 0x40
	protected int LOD; // 0x44

	// Properties
	public float sqrMag { get; set; }
	public float mag { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	protected abstract void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void PreSolve();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations);

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void ApplyOffsets(float scale);

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void ResetOffsets();

	[CompilerGeneratedAttribute] // RVA: 0x2CFA60 Offset: 0x2CFB61 VA: 0x2CFA60
	// RVA: 0x35FFCC0 Offset: 0x35FFDC1 VA: 0x35FFCC0
	public float get_sqrMag() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CFA70 Offset: 0x2CFB71 VA: 0x2CFA70
	// RVA: 0x35FFCD0 Offset: 0x35FFDD1 VA: 0x35FFCD0
	private void set_sqrMag(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2CFA80 Offset: 0x2CFB81 VA: 0x2CFA80
	// RVA: 0x35FFCE0 Offset: 0x35FFDE1 VA: 0x35FFCE0
	public float get_mag() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CFA90 Offset: 0x2CFB91 VA: 0x2CFA90
	// RVA: 0x35FFCF0 Offset: 0x35FFDF1 VA: 0x35FFCF0
	private void set_mag(float value) { }

	// RVA: 0x35FFD00 Offset: 0x35FFE01 VA: 0x35FFD00
	public void SetLOD(int LOD) { }

	// RVA: 0x35FFD10 Offset: 0x35FFE11 VA: 0x35FFD10
	public void Read(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index) { }

	// RVA: 0x35FFDE0 Offset: 0x35FFEE1 VA: 0x35FFDE0
	public void MovePosition(Vector3 position) { }

	// RVA: 0x35FFE70 Offset: 0x35FFF71 VA: 0x35FFE70
	public void MoveRotation(Quaternion rotation) { }

	// RVA: 0x35FFF10 Offset: 0x3600011 VA: 0x35FFF10
	public void Translate(Vector3 position, Quaternion rotation) { }

	// RVA: 0x35FFF70 Offset: 0x3600071 VA: 0x35FFF70
	public void TranslateRoot(Vector3 newRootPos, Quaternion newRootRot) { }

	// RVA: 0x35FF690 Offset: 0x35FF791 VA: 0x35FF690
	public void RotateTo(IKSolverVR.VirtualBone bone, Quaternion rotation, float weight = 1) { }

	// RVA: 0x36000B0 Offset: 0x36001B1 VA: 0x36000B0
	public void Visualize(Color color) { }

	// RVA: 0x36000C0 Offset: 0x36001C1 VA: 0x36000C0
	public void Visualize() { }

	// RVA: 0x35FFC30 Offset: 0x35FFD31 VA: 0x35FFC30
	protected void .ctor() { }
}

// Namespace: 
[Serializable]
public class IKSolverVR.Footstep // TypeDefIndex: 14395
{
	// Fields
	public float stepSpeed; // 0x10
	public Vector3 characterSpaceOffset; // 0x14
	public Vector3 position; // 0x20
	public Quaternion rotation; // 0x2C
	public Quaternion stepToRootRot; // 0x3C
	public bool isSupportLeg; // 0x4C
	public bool relaxFlag; // 0x4D
	[CompilerGeneratedAttribute] // RVA: 0x2A1490 Offset: 0x2A1591 VA: 0x2A1490
	private float <stepProgress>k__BackingField; // 0x50
	public Vector3 stepFrom; // 0x54
	public Vector3 stepTo; // 0x60
	public Quaternion stepFromRot; // 0x6C
	public Quaternion stepToRot; // 0x7C
	private Quaternion footRelativeToRoot; // 0x8C
	private float supportLegW; // 0x9C
	private float supportLegWV; // 0xA0

	// Properties
	public bool isStepping { get; }
	public float stepProgress { get; set; }

	// Methods

	// RVA: 0x36000D0 Offset: 0x36001D1 VA: 0x36000D0
	public bool get_isStepping() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CFAA0 Offset: 0x2CFBA1 VA: 0x2CFAA0
	// RVA: 0x36000F0 Offset: 0x36001F1 VA: 0x36000F0
	public float get_stepProgress() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CFAB0 Offset: 0x2CFBB1 VA: 0x2CFAB0
	// RVA: 0x3600100 Offset: 0x3600201 VA: 0x3600100
	private void set_stepProgress(float value) { }

	// RVA: 0x3600110 Offset: 0x3600211 VA: 0x3600110
	public void .ctor(Quaternion rootRotation, Vector3 footPosition, Quaternion footRotation, Vector3 characterSpaceOffset) { }

	// RVA: 0x36002C0 Offset: 0x36003C1 VA: 0x36002C0
	public void Reset(Quaternion rootRotation, Vector3 footPosition, Quaternion footRotation) { }

	// RVA: 0x3600340 Offset: 0x3600441 VA: 0x3600340
	public void StepTo(Vector3 p, Quaternion rootRotation, float stepThreshold) { }

	// RVA: 0x3600520 Offset: 0x3600621 VA: 0x3600520
	public void UpdateStepping(Vector3 p, Quaternion rootRotation, float speed) { }

	// RVA: 0x3600690 Offset: 0x3600791 VA: 0x3600690
	public void UpdateStanding(Quaternion rootRotation, float minAngle, float speed) { }

	// RVA: 0x3600800 Offset: 0x3600901 VA: 0x3600800
	public void Update(InterpolationMode interpolation, UnityEvent onStep) { }
}

// Namespace: 
[Serializable]
public class IKSolverVR.Leg : IKSolverVR.BodyPart // TypeDefIndex: 14396
{
	// Fields
	[TooltipAttribute] // RVA: 0x2A14A0 Offset: 0x2A15A1 VA: 0x2A14A0
	public Transform target; // 0x48
	[TooltipAttribute] // RVA: 0x2A14E0 Offset: 0x2A15E1 VA: 0x2A14E0
	public Transform bendGoal; // 0x50
	[RangeAttribute] // RVA: 0x2A1520 Offset: 0x2A1621 VA: 0x2A1520
	[TooltipAttribute] // RVA: 0x2A1520 Offset: 0x2A1621 VA: 0x2A1520
	public float positionWeight; // 0x58
	[RangeAttribute] // RVA: 0x2A1580 Offset: 0x2A1681 VA: 0x2A1580
	[TooltipAttribute] // RVA: 0x2A1580 Offset: 0x2A1681 VA: 0x2A1580
	public float rotationWeight; // 0x5C
	[RangeAttribute] // RVA: 0x2A15E0 Offset: 0x2A16E1 VA: 0x2A15E0
	[TooltipAttribute] // RVA: 0x2A15E0 Offset: 0x2A16E1 VA: 0x2A15E0
	public float bendGoalWeight; // 0x60
	[RangeAttribute] // RVA: 0x2A1640 Offset: 0x2A1741 VA: 0x2A1640
	[TooltipAttribute] // RVA: 0x2A1640 Offset: 0x2A1741 VA: 0x2A1640
	public float swivelOffset; // 0x64
	[RangeAttribute] // RVA: 0x2A16A0 Offset: 0x2A17A1 VA: 0x2A16A0
	[TooltipAttribute] // RVA: 0x2A16A0 Offset: 0x2A17A1 VA: 0x2A16A0
	public float bendToTargetWeight; // 0x68
	[TooltipAttribute] // RVA: 0x2A1700 Offset: 0x2A1801 VA: 0x2A1700
	[RangeAttribute] // RVA: 0x2A1700 Offset: 0x2A1801 VA: 0x2A1700
	public float legLengthMlp; // 0x6C
	[TooltipAttribute] // RVA: 0x2A1760 Offset: 0x2A1861 VA: 0x2A1760
	public AnimationCurve stretchCurve; // 0x70
	[HideInInspector] // RVA: 0x2A17A0 Offset: 0x2A18A1 VA: 0x2A17A0
	public Vector3 IKPosition; // 0x78
	[HideInInspector] // RVA: 0x2A17B0 Offset: 0x2A18B1 VA: 0x2A17B0
	public Quaternion IKRotation; // 0x84
	[HideInInspector] // RVA: 0x2A17C0 Offset: 0x2A18C1 VA: 0x2A17C0
	public Vector3 footPositionOffset; // 0x94
	[HideInInspector] // RVA: 0x2A17D0 Offset: 0x2A18D1 VA: 0x2A17D0
	public Vector3 heelPositionOffset; // 0xA0
	[HideInInspector] // RVA: 0x2A17E0 Offset: 0x2A18E1 VA: 0x2A17E0
	public Quaternion footRotationOffset; // 0xAC
	[HideInInspector] // RVA: 0x2A17F0 Offset: 0x2A18F1 VA: 0x2A17F0
	public float currentMag; // 0xBC
	[HideInInspector] // RVA: 0x2A1800 Offset: 0x2A1901 VA: 0x2A1800
	public bool useAnimatedBendNormal; // 0xC0
	[CompilerGeneratedAttribute] // RVA: 0x2A1810 Offset: 0x2A1911 VA: 0x2A1810
	private Vector3 <position>k__BackingField; // 0xC4
	[CompilerGeneratedAttribute] // RVA: 0x2A1820 Offset: 0x2A1921 VA: 0x2A1820
	private Quaternion <rotation>k__BackingField; // 0xD0
	[CompilerGeneratedAttribute] // RVA: 0x2A1830 Offset: 0x2A1931 VA: 0x2A1830
	private bool <hasToes>k__BackingField; // 0xE0
	[CompilerGeneratedAttribute] // RVA: 0x2A1840 Offset: 0x2A1941 VA: 0x2A1840
	private Vector3 <thighRelativeToPelvis>k__BackingField; // 0xE4
	private Vector3 footPosition; // 0xF0
	private Quaternion footRotation; // 0xFC
	private Vector3 bendNormal; // 0x10C
	private Quaternion calfRelToThigh; // 0x118
	private Quaternion thighRelToFoot; // 0x128
	private Vector3 bendNormalRelToPelvis; // 0x138
	private Vector3 bendNormalRelToTarget; // 0x144

	// Properties
	public Vector3 position { get; set; }
	public Quaternion rotation { get; set; }
	public bool hasToes { get; set; }
	public IKSolverVR.VirtualBone thigh { get; }
	private IKSolverVR.VirtualBone calf { get; }
	private IKSolverVR.VirtualBone foot { get; }
	private IKSolverVR.VirtualBone toes { get; }
	public IKSolverVR.VirtualBone lastBone { get; }
	public Vector3 thighRelativeToPelvis { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2CFAC0 Offset: 0x2CFBC1 VA: 0x2CFAC0
	// RVA: 0x3600950 Offset: 0x3600A51 VA: 0x3600950
	public Vector3 get_position() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CFAD0 Offset: 0x2CFBD1 VA: 0x2CFAD0
	// RVA: 0x3600960 Offset: 0x3600A61 VA: 0x3600960
	private void set_position(Vector3 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2CFAE0 Offset: 0x2CFBE1 VA: 0x2CFAE0
	// RVA: 0x3600970 Offset: 0x3600A71 VA: 0x3600970
	public Quaternion get_rotation() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CFAF0 Offset: 0x2CFBF1 VA: 0x2CFAF0
	// RVA: 0x3600980 Offset: 0x3600A81 VA: 0x3600980
	private void set_rotation(Quaternion value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2CFB00 Offset: 0x2CFC01 VA: 0x2CFB00
	// RVA: 0x36009A0 Offset: 0x3600AA1 VA: 0x36009A0
	public bool get_hasToes() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CFB10 Offset: 0x2CFC11 VA: 0x2CFB10
	// RVA: 0x36009B0 Offset: 0x3600AB1 VA: 0x36009B0
	private void set_hasToes(bool value) { }

	// RVA: 0x36009C0 Offset: 0x3600AC1 VA: 0x36009C0
	public IKSolverVR.VirtualBone get_thigh() { }

	// RVA: 0x36009F0 Offset: 0x3600AF1 VA: 0x36009F0
	private IKSolverVR.VirtualBone get_calf() { }

	// RVA: 0x3600A20 Offset: 0x3600B21 VA: 0x3600A20
	private IKSolverVR.VirtualBone get_foot() { }

	// RVA: 0x3600A50 Offset: 0x3600B51 VA: 0x3600A50
	private IKSolverVR.VirtualBone get_toes() { }

	// RVA: 0x3600A80 Offset: 0x3600B81 VA: 0x3600A80
	public IKSolverVR.VirtualBone get_lastBone() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CFB20 Offset: 0x2CFC21 VA: 0x2CFB20
	// RVA: 0x3600AC0 Offset: 0x3600BC1 VA: 0x3600AC0
	public Vector3 get_thighRelativeToPelvis() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CFB30 Offset: 0x2CFC31 VA: 0x2CFB30
	// RVA: 0x3600AD0 Offset: 0x3600BD1 VA: 0x3600AD0
	private void set_thighRelativeToPelvis(Vector3 value) { }

	// RVA: 0x3600AE0 Offset: 0x3600BE1 VA: 0x3600AE0 Slot: 4
	protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index) { }

	// RVA: 0x36010A0 Offset: 0x36011A1 VA: 0x36010A0 Slot: 5
	public override void PreSolve() { }

	// RVA: 0x3601690 Offset: 0x3601791 VA: 0x3601690 Slot: 7
	public override void ApplyOffsets(float scale) { }

	// RVA: 0x3601640 Offset: 0x3601741 VA: 0x3601640
	private void ApplyPositionOffset(Vector3 offset, float weight) { }

	// RVA: 0x36014D0 Offset: 0x36015D1 VA: 0x36014D0
	private void ApplyRotationOffset(Quaternion offset, float weight) { }

	// RVA: 0x3601A30 Offset: 0x3601B31 VA: 0x3601A30
	public void Solve(bool stretch) { }

	// RVA: 0x3601E90 Offset: 0x3601F91 VA: 0x3601E90
	private void FixTwistRotations() { }

	// RVA: 0x3601BD0 Offset: 0x3601CD1 VA: 0x3601BD0
	private void Stretching() { }

	// RVA: 0x36020F0 Offset: 0x36021F1 VA: 0x36020F0 Slot: 6
	public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations) { }

	// RVA: 0x3602330 Offset: 0x3602431 VA: 0x3602330 Slot: 8
	public override void ResetOffsets() { }

	// RVA: 0x3602390 Offset: 0x3602491 VA: 0x3602390
	public void .ctor() { }
}

// Namespace: 
[Serializable]
public class IKSolverVR.Locomotion // TypeDefIndex: 14397
{
	// Fields
	[RangeAttribute] // RVA: 0x2A1850 Offset: 0x2A1951 VA: 0x2A1850
	[TooltipAttribute] // RVA: 0x2A1850 Offset: 0x2A1951 VA: 0x2A1850
	public float weight; // 0x10
	[TooltipAttribute] // RVA: 0x2A18B0 Offset: 0x2A19B1 VA: 0x2A18B0
	public float footDistance; // 0x14
	[TooltipAttribute] // RVA: 0x2A18F0 Offset: 0x2A19F1 VA: 0x2A18F0
	public float stepThreshold; // 0x18
	[TooltipAttribute] // RVA: 0x2A1930 Offset: 0x2A1A31 VA: 0x2A1930
	public float angleThreshold; // 0x1C
	[TooltipAttribute] // RVA: 0x2A1970 Offset: 0x2A1A71 VA: 0x2A1970
	public float comAngleMlp; // 0x20
	[TooltipAttribute] // RVA: 0x2A19B0 Offset: 0x2A1AB1 VA: 0x2A19B0
	public float maxVelocity; // 0x24
	[TooltipAttribute] // RVA: 0x2A19F0 Offset: 0x2A1AF1 VA: 0x2A19F0
	public float velocityFactor; // 0x28
	[TooltipAttribute] // RVA: 0x2A1A30 Offset: 0x2A1B31 VA: 0x2A1A30
	[RangeAttribute] // RVA: 0x2A1A30 Offset: 0x2A1B31 VA: 0x2A1A30
	public float maxLegStretch; // 0x2C
	[TooltipAttribute] // RVA: 0x2A1A90 Offset: 0x2A1B91 VA: 0x2A1A90
	public float rootSpeed; // 0x30
	[TooltipAttribute] // RVA: 0x2A1AD0 Offset: 0x2A1BD1 VA: 0x2A1AD0
	public float stepSpeed; // 0x34
	[TooltipAttribute] // RVA: 0x2A1B10 Offset: 0x2A1C11 VA: 0x2A1B10
	public AnimationCurve stepHeight; // 0x38
	[TooltipAttribute] // RVA: 0x2A1B50 Offset: 0x2A1C51 VA: 0x2A1B50
	public float maxBodyYOffset; // 0x40
	[TooltipAttribute] // RVA: 0x2A1B90 Offset: 0x2A1C91 VA: 0x2A1B90
	public AnimationCurve heelHeight; // 0x48
	[RangeAttribute] // RVA: 0x2A1BD0 Offset: 0x2A1CD1 VA: 0x2A1BD0
	[TooltipAttribute] // RVA: 0x2A1BD0 Offset: 0x2A1CD1 VA: 0x2A1BD0
	public float relaxLegTwistMinAngle; // 0x50
	[TooltipAttribute] // RVA: 0x2A1C30 Offset: 0x2A1D31 VA: 0x2A1C30
	public float relaxLegTwistSpeed; // 0x54
	[TooltipAttribute] // RVA: 0x2A1C70 Offset: 0x2A1D71 VA: 0x2A1C70
	public InterpolationMode stepInterpolation; // 0x58
	[TooltipAttribute] // RVA: 0x2A1CB0 Offset: 0x2A1DB1 VA: 0x2A1CB0
	public Vector3 offset; // 0x5C
	[HideInInspector] // RVA: 0x2A1CF0 Offset: 0x2A1DF1 VA: 0x2A1CF0
	public bool blockingEnabled; // 0x68
	[HideInInspector] // RVA: 0x2A1D00 Offset: 0x2A1E01 VA: 0x2A1D00
	public LayerMask blockingLayers; // 0x6C
	[HideInInspector] // RVA: 0x2A1D10 Offset: 0x2A1E11 VA: 0x2A1D10
	public float raycastRadius; // 0x70
	[HideInInspector] // RVA: 0x2A1D20 Offset: 0x2A1E21 VA: 0x2A1D20
	public float raycastHeight; // 0x74
	[TooltipAttribute] // RVA: 0x2A1D30 Offset: 0x2A1E31 VA: 0x2A1D30
	public UnityEvent onLeftFootstep; // 0x78
	[TooltipAttribute] // RVA: 0x2A1D70 Offset: 0x2A1E71 VA: 0x2A1D70
	public UnityEvent onRightFootstep; // 0x80
	[CompilerGeneratedAttribute] // RVA: 0x2A1DB0 Offset: 0x2A1EB1 VA: 0x2A1DB0
	private Vector3 <centerOfMass>k__BackingField; // 0x88
	private IKSolverVR.Footstep[] footsteps; // 0x98
	private Vector3 lastComPosition; // 0xA0
	private Vector3 comVelocity; // 0xAC
	private int leftFootIndex; // 0xB8
	private int rightFootIndex; // 0xBC

	// Properties
	public Vector3 centerOfMass { get; set; }
	public Vector3 leftFootstepPosition { get; }
	public Vector3 rightFootstepPosition { get; }
	public Quaternion leftFootstepRotation { get; }
	public Quaternion rightFootstepRotation { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2CFB40 Offset: 0x2CFC41 VA: 0x2CFB40
	// RVA: 0x3602500 Offset: 0x3602601 VA: 0x3602500
	public Vector3 get_centerOfMass() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CFB50 Offset: 0x2CFC51 VA: 0x2CFB50
	// RVA: 0x3602510 Offset: 0x3602611 VA: 0x3602510
	private void set_centerOfMass(Vector3 value) { }

	// RVA: 0x3602520 Offset: 0x3602621 VA: 0x3602520
	public void Initiate(Vector3[] positions, Quaternion[] rotations, bool hasToes, float scale) { }

	// RVA: 0x36027F0 Offset: 0x36028F1 VA: 0x36027F0
	public void Reset(Vector3[] positions, Quaternion[] rotations) { }

	// RVA: 0x3602A00 Offset: 0x3602B01 VA: 0x3602A00
	public void Relax() { }

	// RVA: 0x3602A50 Offset: 0x3602B51 VA: 0x3602A50
	public void AddDeltaRotation(Quaternion delta, Vector3 pivot) { }

	// RVA: 0x3602C90 Offset: 0x3602D91 VA: 0x3602C90
	public void AddDeltaPosition(Vector3 delta) { }

	// RVA: 0x3602D60 Offset: 0x3602E61 VA: 0x3602D60
	public void Solve(IKSolverVR.VirtualBone rootBone, IKSolverVR.Spine spine, IKSolverVR.Leg leftLeg, IKSolverVR.Leg rightLeg, IKSolverVR.Arm leftArm, IKSolverVR.Arm rightArm, int supportLegIndex, out Vector3 leftFootPosition, out Vector3 rightFootPosition, out Quaternion leftFootRotation, out Quaternion rightFootRotation, out float leftFootOffset, out float rightFootOffset, out float leftHeelOffset, out float rightHeelOffset, float scale) { }

	// RVA: 0x36040E0 Offset: 0x36041E1 VA: 0x36040E0
	public Vector3 get_leftFootstepPosition() { }

	// RVA: 0x3604120 Offset: 0x3604221 VA: 0x3604120
	public Vector3 get_rightFootstepPosition() { }

	// RVA: 0x3604160 Offset: 0x3604261 VA: 0x3604160
	public Quaternion get_leftFootstepRotation() { }

	// RVA: 0x36041A0 Offset: 0x36042A1 VA: 0x36041A0
	public Quaternion get_rightFootstepRotation() { }

	// RVA: 0x3603E40 Offset: 0x3603F41 VA: 0x3603E40
	private bool StepBlocked(Vector3 fromPosition, Vector3 toPosition, Vector3 rootPosition) { }

	// RVA: 0x3603F70 Offset: 0x3604071 VA: 0x3603F70
	private bool CanStep() { }

	// RVA: 0x3604000 Offset: 0x3604101 VA: 0x3604000
	private static bool GetLineSphereCollision(Vector3 lineStart, Vector3 lineEnd, Vector3 sphereCenter, float sphereRadius) { }

	// RVA: 0x36041E0 Offset: 0x36042E1 VA: 0x36041E0
	public void .ctor() { }
}

// Namespace: 
[Serializable]
public class IKSolverVR.Spine : IKSolverVR.BodyPart // TypeDefIndex: 14398
{
	// Fields
	[TooltipAttribute] // RVA: 0x2A1DC0 Offset: 0x2A1EC1 VA: 0x2A1DC0
	public Transform headTarget; // 0x48
	[TooltipAttribute] // RVA: 0x2A1E00 Offset: 0x2A1F01 VA: 0x2A1E00
	public Transform pelvisTarget; // 0x50
	[TooltipAttribute] // RVA: 0x2A1E40 Offset: 0x2A1F41 VA: 0x2A1E40
	[RangeAttribute] // RVA: 0x2A1E40 Offset: 0x2A1F41 VA: 0x2A1E40
	public float positionWeight; // 0x58
	[RangeAttribute] // RVA: 0x2A1EA0 Offset: 0x2A1FA1 VA: 0x2A1EA0
	[TooltipAttribute] // RVA: 0x2A1EA0 Offset: 0x2A1FA1 VA: 0x2A1EA0
	public float rotationWeight; // 0x5C
	[TooltipAttribute] // RVA: 0x2A1F00 Offset: 0x2A2001 VA: 0x2A1F00
	[RangeAttribute] // RVA: 0x2A1F00 Offset: 0x2A2001 VA: 0x2A1F00
	public float pelvisPositionWeight; // 0x60
	[RangeAttribute] // RVA: 0x2A1F60 Offset: 0x2A2061 VA: 0x2A1F60
	[TooltipAttribute] // RVA: 0x2A1F60 Offset: 0x2A2061 VA: 0x2A1F60
	public float pelvisRotationWeight; // 0x64
	[TooltipAttribute] // RVA: 0x2A1FC0 Offset: 0x2A20C1 VA: 0x2A1FC0
	public Transform chestGoal; // 0x68
	[TooltipAttribute] // RVA: 0x2A2000 Offset: 0x2A2101 VA: 0x2A2000
	[RangeAttribute] // RVA: 0x2A2000 Offset: 0x2A2101 VA: 0x2A2000
	public float chestGoalWeight; // 0x70
	[TooltipAttribute] // RVA: 0x2A2060 Offset: 0x2A2161 VA: 0x2A2060
	public float minHeadHeight; // 0x74
	[RangeAttribute] // RVA: 0x2A20A0 Offset: 0x2A21A1 VA: 0x2A20A0
	[TooltipAttribute] // RVA: 0x2A20A0 Offset: 0x2A21A1 VA: 0x2A20A0
	public float bodyPosStiffness; // 0x78
	[TooltipAttribute] // RVA: 0x2A2100 Offset: 0x2A2201 VA: 0x2A2100
	[RangeAttribute] // RVA: 0x2A2100 Offset: 0x2A2201 VA: 0x2A2100
	public float bodyRotStiffness; // 0x7C
	[RangeAttribute] // RVA: 0x2A2160 Offset: 0x2A2261 VA: 0x2A2160
	[TooltipAttribute] // RVA: 0x2A2160 Offset: 0x2A2261 VA: 0x2A2160
	[FormerlySerializedAsAttribute] // RVA: 0x2A2160 Offset: 0x2A2261 VA: 0x2A2160
	public float neckStiffness; // 0x80
	[RangeAttribute] // RVA: 0x2A21E0 Offset: 0x2A22E1 VA: 0x2A21E0
	[TooltipAttribute] // RVA: 0x2A21E0 Offset: 0x2A22E1 VA: 0x2A21E0
	public float rotateChestByHands; // 0x84
	[RangeAttribute] // RVA: 0x2A2240 Offset: 0x2A2341 VA: 0x2A2240
	[TooltipAttribute] // RVA: 0x2A2240 Offset: 0x2A2341 VA: 0x2A2240
	public float chestClampWeight; // 0x88
	[RangeAttribute] // RVA: 0x2A22A0 Offset: 0x2A23A1 VA: 0x2A22A0
	[TooltipAttribute] // RVA: 0x2A22A0 Offset: 0x2A23A1 VA: 0x2A22A0
	public float headClampWeight; // 0x8C
	[TooltipAttribute] // RVA: 0x2A2300 Offset: 0x2A2401 VA: 0x2A2300
	public float moveBodyBackWhenCrouching; // 0x90
	[RangeAttribute] // RVA: 0x2A2340 Offset: 0x2A2441 VA: 0x2A2340
	[TooltipAttribute] // RVA: 0x2A2340 Offset: 0x2A2441 VA: 0x2A2340
	public float maintainPelvisPosition; // 0x94
	[TooltipAttribute] // RVA: 0x2A23A0 Offset: 0x2A24A1 VA: 0x2A23A0
	[RangeAttribute] // RVA: 0x2A23A0 Offset: 0x2A24A1 VA: 0x2A23A0
	public float maxRootAngle; // 0x98
	[RangeAttribute] // RVA: 0x2A2400 Offset: 0x2A2501 VA: 0x2A2400
	[TooltipAttribute] // RVA: 0x2A2400 Offset: 0x2A2501 VA: 0x2A2400
	public float rootHeadingOffset; // 0x9C
	[HideInInspector] // RVA: 0x2A2460 Offset: 0x2A2561 VA: 0x2A2460
	public Vector3 IKPositionHead; // 0xA0
	[HideInInspector] // RVA: 0x2A2470 Offset: 0x2A2571 VA: 0x2A2470
	public Quaternion IKRotationHead; // 0xAC
	[HideInInspector] // RVA: 0x2A2480 Offset: 0x2A2581 VA: 0x2A2480
	public Vector3 IKPositionPelvis; // 0xBC
	[HideInInspector] // RVA: 0x2A2490 Offset: 0x2A2591 VA: 0x2A2490
	public Quaternion IKRotationPelvis; // 0xC8
	[HideInInspector] // RVA: 0x2A24A0 Offset: 0x2A25A1 VA: 0x2A24A0
	public Vector3 goalPositionChest; // 0xD8
	[HideInInspector] // RVA: 0x2A24B0 Offset: 0x2A25B1 VA: 0x2A24B0
	public Vector3 pelvisPositionOffset; // 0xE4
	[HideInInspector] // RVA: 0x2A24C0 Offset: 0x2A25C1 VA: 0x2A24C0
	public Vector3 chestPositionOffset; // 0xF0
	[HideInInspector] // RVA: 0x2A24D0 Offset: 0x2A25D1 VA: 0x2A24D0
	public Vector3 headPositionOffset; // 0xFC
	[HideInInspector] // RVA: 0x2A24E0 Offset: 0x2A25E1 VA: 0x2A24E0
	public Quaternion pelvisRotationOffset; // 0x108
	[HideInInspector] // RVA: 0x2A24F0 Offset: 0x2A25F1 VA: 0x2A24F0
	public Quaternion chestRotationOffset; // 0x118
	[HideInInspector] // RVA: 0x2A2500 Offset: 0x2A2601 VA: 0x2A2500
	public Quaternion headRotationOffset; // 0x128
	[HideInInspector] // RVA: 0x2A2510 Offset: 0x2A2611 VA: 0x2A2510
	public Vector3 faceDirection; // 0x138
	[HideInInspector] // RVA: 0x2A2520 Offset: 0x2A2621 VA: 0x2A2520
	public Vector3 locomotionHeadPositionOffset; // 0x144
	[HideInInspector] // RVA: 0x2A2530 Offset: 0x2A2631 VA: 0x2A2530
	public Vector3 headPosition; // 0x150
	[CompilerGeneratedAttribute] // RVA: 0x2A2540 Offset: 0x2A2641 VA: 0x2A2540
	private Quaternion <anchorRotation>k__BackingField; // 0x15C
	[CompilerGeneratedAttribute] // RVA: 0x2A2550 Offset: 0x2A2651 VA: 0x2A2550
	private Quaternion <anchorRelativeToHead>k__BackingField; // 0x16C
	private Quaternion headRotation; // 0x17C
	private Quaternion pelvisRotation; // 0x18C
	private Quaternion anchorRelativeToPelvis; // 0x19C
	private Quaternion pelvisRelativeRotation; // 0x1AC
	private Quaternion chestRelativeRotation; // 0x1BC
	private Vector3 headDeltaPosition; // 0x1CC
	private Quaternion pelvisDeltaRotation; // 0x1D8
	private Quaternion chestTargetRotation; // 0x1E8
	private int pelvisIndex; // 0x1F8
	private int spineIndex; // 0x1FC
	private int chestIndex; // 0x200
	private int neckIndex; // 0x204
	private int headIndex; // 0x208
	private float length; // 0x20C
	private bool hasChest; // 0x210
	private bool hasNeck; // 0x211
	private bool hasLegs; // 0x212
	private float headHeight; // 0x214
	private float sizeMlp; // 0x218
	private Vector3 chestForward; // 0x21C

	// Properties
	public IKSolverVR.VirtualBone pelvis { get; }
	public IKSolverVR.VirtualBone firstSpineBone { get; }
	public IKSolverVR.VirtualBone chest { get; }
	private IKSolverVR.VirtualBone neck { get; }
	public IKSolverVR.VirtualBone head { get; }
	public Quaternion anchorRotation { get; set; }
	public Quaternion anchorRelativeToHead { get; set; }

	// Methods

	// RVA: 0x3603DC0 Offset: 0x3603EC1 VA: 0x3603DC0
	public IKSolverVR.VirtualBone get_pelvis() { }

	// RVA: 0x3604330 Offset: 0x3604431 VA: 0x3604330
	public IKSolverVR.VirtualBone get_firstSpineBone() { }

	// RVA: 0x3604370 Offset: 0x3604471 VA: 0x3604370
	public IKSolverVR.VirtualBone get_chest() { }

	// RVA: 0x36043C0 Offset: 0x36044C1 VA: 0x36043C0
	private IKSolverVR.VirtualBone get_neck() { }

	// RVA: 0x3603E00 Offset: 0x3603F01 VA: 0x3603E00
	public IKSolverVR.VirtualBone get_head() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CFB60 Offset: 0x2CFC61 VA: 0x2CFB60
	// RVA: 0x3604400 Offset: 0x3604501 VA: 0x3604400
	public Quaternion get_anchorRotation() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CFB70 Offset: 0x2CFC71 VA: 0x2CFB70
	// RVA: 0x3604420 Offset: 0x3604521 VA: 0x3604420
	private void set_anchorRotation(Quaternion value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2CFB80 Offset: 0x2CFC81 VA: 0x2CFB80
	// RVA: 0x3604440 Offset: 0x3604541 VA: 0x3604440
	public Quaternion get_anchorRelativeToHead() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CFB90 Offset: 0x2CFC91 VA: 0x2CFB90
	// RVA: 0x3604460 Offset: 0x3604561 VA: 0x3604460
	private void set_anchorRelativeToHead(Quaternion value) { }

	// RVA: 0x3604480 Offset: 0x3604581 VA: 0x3604480 Slot: 4
	protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index) { }

	// RVA: 0x3604E40 Offset: 0x3604F41 VA: 0x3604E40 Slot: 5
	public override void PreSolve() { }

	// RVA: 0x3605070 Offset: 0x3605171 VA: 0x3605070 Slot: 7
	public override void ApplyOffsets(float scale) { }

	// RVA: 0x36054F0 Offset: 0x36055F1 VA: 0x36054F0
	private void CalculateChestTargetRotation(IKSolverVR.VirtualBone rootBone, IKSolverVR.Arm[] arms) { }

	// RVA: 0x3605920 Offset: 0x3605A21 VA: 0x3605920
	public void Solve(IKSolverVR.VirtualBone rootBone, IKSolverVR.Leg[] legs, IKSolverVR.Arm[] arms, float scale) { }

	// RVA: 0x36060D0 Offset: 0x36061D1 VA: 0x36060D0
	private void FABRIKPass(Vector3 animatedPelvisPos, Vector3 rootUp, float weight) { }

	// RVA: 0x36068D0 Offset: 0x36069D1 VA: 0x36068D0
	private void SolvePelvis() { }

	// RVA: 0x3606B00 Offset: 0x3606C01 VA: 0x3606B00 Slot: 6
	public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations) { }

	// RVA: 0x3606CD0 Offset: 0x3606DD1 VA: 0x3606CD0 Slot: 8
	public override void ResetOffsets() { }

	// RVA: 0x3605680 Offset: 0x3605781 VA: 0x3605680
	private void AdjustChestByHands(ref Quaternion chestTargetRotation, IKSolverVR.Arm[] arms) { }

	// RVA: 0x36065A0 Offset: 0x36066A1 VA: 0x36065A0
	public void InverseTranslateToHead(IKSolverVR.Leg[] legs, bool limited, bool useCurrentLegMag, Vector3 offset, float w) { }

	// RVA: 0x3605D30 Offset: 0x3605E31 VA: 0x3605D30
	private void TranslatePelvis(IKSolverVR.Leg[] legs, Vector3 deltaPosition, Quaternion deltaRotation, float scale) { }

	// RVA: 0x3606D70 Offset: 0x3606E71 VA: 0x3606D70
	private Vector3 LimitPelvisPosition(IKSolverVR.Leg[] legs, Vector3 pelvisPosition, bool useCurrentLegMag, int it = 2) { }

	// RVA: 0x3606660 Offset: 0x3606761 VA: 0x3606660
	private void Bend(IKSolverVR.VirtualBone[] bones, int firstIndex, int lastIndex, Quaternion targetRotation, float clampWeight, bool uniformWeight, float w) { }

	// RVA: 0x3606280 Offset: 0x3606381 VA: 0x3606280
	private void Bend(IKSolverVR.VirtualBone[] bones, int firstIndex, int lastIndex, Quaternion targetRotation, Quaternion rotationOffset, float clampWeight, bool uniformWeight, float w) { }

	// RVA: 0x3607040 Offset: 0x3607141 VA: 0x3607040
	public void .ctor() { }
}

// Namespace: 
[Serializable]
public enum IKSolverVR.PositionOffset // TypeDefIndex: 14399
{
	// Fields
	public int value__; // 0x0
	public const IKSolverVR.PositionOffset Pelvis = 0;
	public const IKSolverVR.PositionOffset Chest = 1;
	public const IKSolverVR.PositionOffset Head = 2;
	public const IKSolverVR.PositionOffset LeftHand = 3;
	public const IKSolverVR.PositionOffset RightHand = 4;
	public const IKSolverVR.PositionOffset LeftFoot = 5;
	public const IKSolverVR.PositionOffset RightFoot = 6;
	public const IKSolverVR.PositionOffset LeftHeel = 7;
	public const IKSolverVR.PositionOffset RightHeel = 8;
}

// Namespace: 
[Serializable]
public enum IKSolverVR.RotationOffset // TypeDefIndex: 14400
{
	// Fields
	public int value__; // 0x0
	public const IKSolverVR.RotationOffset Pelvis = 0;
	public const IKSolverVR.RotationOffset Chest = 1;
	public const IKSolverVR.RotationOffset Head = 2;
}

// Namespace: 
[Serializable]
public class IKSolverVR.VirtualBone // TypeDefIndex: 14401
{
	// Fields
	public Vector3 readPosition; // 0x10
	public Quaternion readRotation; // 0x1C
	public Vector3 solverPosition; // 0x2C
	public Quaternion solverRotation; // 0x38
	public float length; // 0x48
	public float sqrMag; // 0x4C
	public Vector3 axis; // 0x50

	// Methods

	// RVA: 0x221F240 Offset: 0x221F341 VA: 0x221F240
	public void .ctor(Vector3 position, Quaternion rotation) { }

	// RVA: 0x221F2E0 Offset: 0x221F3E1 VA: 0x221F2E0
	public void Read(Vector3 position, Quaternion rotation) { }

	// RVA: 0x221F320 Offset: 0x221F421 VA: 0x221F320
	public static void SwingRotation(IKSolverVR.VirtualBone[] bones, int index, Vector3 swingTarget, float weight = 1) { }

	// RVA: 0x221F490 Offset: 0x221F591 VA: 0x221F490
	public static float PreSolve(ref IKSolverVR.VirtualBone[] bones) { }

	// RVA: 0x221F670 Offset: 0x221F771 VA: 0x221F670
	public static void RotateAroundPoint(IKSolverVR.VirtualBone[] bones, int index, Vector3 point, Quaternion rotation) { }

	// RVA: 0x221F790 Offset: 0x221F891 VA: 0x221F790
	public static void RotateBy(IKSolverVR.VirtualBone[] bones, int index, Quaternion rotation) { }

	// RVA: 0x221F8E0 Offset: 0x221F9E1 VA: 0x221F8E0
	public static void RotateBy(IKSolverVR.VirtualBone[] bones, Quaternion rotation) { }

	// RVA: 0x221FA10 Offset: 0x221FB11 VA: 0x221FA10
	public static void RotateTo(IKSolverVR.VirtualBone[] bones, int index, Quaternion rotation) { }

	// RVA: 0x221FAC0 Offset: 0x221FBC1 VA: 0x221FAC0
	public static void SolveTrigonometric(IKSolverVR.VirtualBone[] bones, int first, int second, int third, Vector3 targetPosition, Vector3 bendNormal, float weight) { }

	// RVA: 0x221FEA0 Offset: 0x221FFA1 VA: 0x221FEA0
	private static Vector3 GetDirectionToBendPoint(Vector3 direction, float directionMag, Vector3 bendDirection, float sqrMag1, float sqrMag2) { }

	// RVA: 0x2220020 Offset: 0x2220121 VA: 0x2220020
	public static void SolveFABRIK(IKSolverVR.VirtualBone[] bones, Vector3 startPosition, Vector3 targetPosition, float weight, float minNormalizedTargetDistance, int iterations, float length, Vector3 startOffset) { }

	// RVA: 0x2220410 Offset: 0x2220511 VA: 0x2220410
	private static Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length) { }

	// RVA: 0x2220480 Offset: 0x2220581 VA: 0x2220480
	public static void SolveCCD(IKSolverVR.VirtualBone[] bones, Vector3 targetPosition, float weight, int iterations) { }
}

