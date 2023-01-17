// Namespace: RootMotion.FinalIK
[Serializable]
public class IKSolverVR : IKSolver // TypeDefIndex: 14402
{
	// Fields
	private Transform[] solverTransforms; // 0x58
	private bool hasChest; // 0x60
	private bool hasNeck; // 0x61
	private bool hasShoulders; // 0x62
	private bool hasToes; // 0x63
	private bool hasLegs; // 0x64
	private Vector3[] readPositions; // 0x68
	private Quaternion[] readRotations; // 0x70
	private Vector3[] solvedPositions; // 0x78
	private Quaternion[] solvedRotations; // 0x80
	private Quaternion[] defaultLocalRotations; // 0x88
	private Vector3[] defaultLocalPositions; // 0x90
	private Vector3 rootV; // 0x98
	private Vector3 rootVelocity; // 0xA4
	private Vector3 bodyOffset; // 0xB0
	private int supportLegIndex; // 0xBC
	private int lastLOD; // 0xC0
	[TooltipAttribute] // RVA: 0x2A0D70 Offset: 0x2A0E71 VA: 0x2A0D70
	[RangeAttribute] // RVA: 0x2A0D70 Offset: 0x2A0E71 VA: 0x2A0D70
	public int LOD; // 0xC4
	[TooltipAttribute] // RVA: 0x2A0DD0 Offset: 0x2A0ED1 VA: 0x2A0DD0
	public float scale; // 0xC8
	[TooltipAttribute] // RVA: 0x2A0E10 Offset: 0x2A0F11 VA: 0x2A0E10
	public bool plantFeet; // 0xCC
	[CompilerGeneratedAttribute] // RVA: 0x2A0E50 Offset: 0x2A0F51 VA: 0x2A0E50
	private IKSolverVR.VirtualBone <rootBone>k__BackingField; // 0xD0
	[TooltipAttribute] // RVA: 0x2A0E60 Offset: 0x2A0F61 VA: 0x2A0E60
	public IKSolverVR.Spine spine; // 0xD8
	[TooltipAttribute] // RVA: 0x2A0EA0 Offset: 0x2A0FA1 VA: 0x2A0EA0
	public IKSolverVR.Arm leftArm; // 0xE0
	[TooltipAttribute] // RVA: 0x2A0EE0 Offset: 0x2A0FE1 VA: 0x2A0EE0
	public IKSolverVR.Arm rightArm; // 0xE8
	[TooltipAttribute] // RVA: 0x2A0F20 Offset: 0x2A1021 VA: 0x2A0F20
	public IKSolverVR.Leg leftLeg; // 0xF0
	[TooltipAttribute] // RVA: 0x2A0F60 Offset: 0x2A1061 VA: 0x2A0F60
	public IKSolverVR.Leg rightLeg; // 0xF8
	[TooltipAttribute] // RVA: 0x2A0FA0 Offset: 0x2A10A1 VA: 0x2A0FA0
	public IKSolverVR.Locomotion locomotion; // 0x100
	private IKSolverVR.Leg[] legs; // 0x108
	private IKSolverVR.Arm[] arms; // 0x110
	private Vector3 headPosition; // 0x118
	private Vector3 headDeltaPosition; // 0x124
	private Vector3 raycastOriginPelvis; // 0x130
	private Vector3 lastOffset; // 0x13C
	private Vector3 debugPos1; // 0x148
	private Vector3 debugPos2; // 0x154
	private Vector3 debugPos3; // 0x160
	private Vector3 debugPos4; // 0x16C

	// Properties
	[HideInInspector] // RVA: 0x2D4FA0 Offset: 0x2D50A1 VA: 0x2D4FA0
	public IKSolverVR.VirtualBone rootBone { get; set; }

	// Methods

	// RVA: 0x2C3F2B0 Offset: 0x2C3F3B1 VA: 0x2C3F2B0
	public void SetToReferences(VRIK.References references) { }

	// RVA: 0x2C3F6F0 Offset: 0x2C3F7F1 VA: 0x2C3F6F0
	public void GuessHandOrientations(VRIK.References references, bool onlyIfZero) { }

	// RVA: 0x2C3F580 Offset: 0x2C3F681 VA: 0x2C3F580
	public void DefaultAnimationCurves() { }

	// RVA: 0x2C3F9B0 Offset: 0x2C3FAB1 VA: 0x2C3F9B0
	public void AddPositionOffset(IKSolverVR.PositionOffset positionOffset, Vector3 value) { }

	// RVA: 0x2C3FAD0 Offset: 0x2C3FBD1 VA: 0x2C3FAD0
	public void AddRotationOffset(IKSolverVR.RotationOffset rotationOffset, Vector3 value) { }

	// RVA: 0x2C3FB00 Offset: 0x2C3FC01 VA: 0x2C3FB00
	public void AddRotationOffset(IKSolverVR.RotationOffset rotationOffset, Quaternion value) { }

	// RVA: 0x2C3FBA0 Offset: 0x2C3FCA1 VA: 0x2C3FBA0
	public void AddPlatformMotion(Vector3 deltaPosition, Quaternion deltaRotation, Vector3 platformPivot) { }

	// RVA: 0x2C3FCA0 Offset: 0x2C3FDA1 VA: 0x2C3FCA0
	public void Reset() { }

	// RVA: 0x2C403F0 Offset: 0x2C404F1 VA: 0x2C403F0 Slot: 9
	public override void StoreDefaultLocalState() { }

	// RVA: 0x2C40560 Offset: 0x2C40661 VA: 0x2C40560 Slot: 8
	public override void FixTransforms() { }

	// RVA: 0x2C407A0 Offset: 0x2C408A1 VA: 0x2C407A0 Slot: 6
	public override IKSolver.Point[] GetPoints() { }

	// RVA: 0x2C407B0 Offset: 0x2C408B1 VA: 0x2C407B0 Slot: 7
	public override IKSolver.Point GetPoint(Transform transform) { }

	// RVA: 0x2C407C0 Offset: 0x2C408C1 VA: 0x2C407C0 Slot: 4
	public override bool IsValid(ref string message) { }

	// RVA: 0x2C40990 Offset: 0x2C40A91 VA: 0x2C40990
	private Vector3 GetNormal(Transform[] transforms) { }

	// RVA: 0x2C3F890 Offset: 0x2C3F991 VA: 0x2C3F890
	private static Keyframe[] GetSineKeyframes(float mag) { }

	// RVA: 0x2C3FD80 Offset: 0x2C3FE81 VA: 0x2C3FD80
	private void UpdateSolverTransforms() { }

	// RVA: 0x2C40B50 Offset: 0x2C40C51 VA: 0x2C40B50 Slot: 10
	protected override void OnInitiate() { }

	// RVA: 0x2C40BA0 Offset: 0x2C40CA1 VA: 0x2C40BA0 Slot: 11
	protected override void OnUpdate() { }

	// RVA: 0x2C41F40 Offset: 0x2C42041 VA: 0x2C41F40
	private void WriteTransforms() { }

	// RVA: 0x2C3FEE0 Offset: 0x2C3FFE1 VA: 0x2C3FEE0
	private void Read(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs) { }

	// RVA: 0x2C40EB0 Offset: 0x2C40FB1 VA: 0x2C40EB0
	private void Solve() { }

	// RVA: 0x2C42290 Offset: 0x2C42391 VA: 0x2C42290
	private Vector3 GetPosition(int index) { }

	// RVA: 0x2C422D0 Offset: 0x2C423D1 VA: 0x2C422D0
	private Quaternion GetRotation(int index) { }

	[CompilerGeneratedAttribute] // RVA: 0x2CFA00 Offset: 0x2CFB01 VA: 0x2CFA00
	// RVA: 0x2C42730 Offset: 0x2C42831 VA: 0x2C42730
	public IKSolverVR.VirtualBone get_rootBone() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CFA10 Offset: 0x2CFB11 VA: 0x2CFA10
	// RVA: 0x2C42740 Offset: 0x2C42841 VA: 0x2C42740
	private void set_rootBone(IKSolverVR.VirtualBone value) { }

	// RVA: 0x2C41E00 Offset: 0x2C41F01 VA: 0x2C41E00
	private void Write() { }

	// RVA: 0x2C42310 Offset: 0x2C42411 VA: 0x2C42310
	private Vector3 GetPelvisOffset() { }

	// RVA: 0x2C42750 Offset: 0x2C42851 VA: 0x2C42750
	public void .ctor() { }
}

