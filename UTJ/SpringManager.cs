// Namespace: UTJ
public class SpringManager : ISpringManager // TypeDefIndex: 6405
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x5B830 Offset: 0x5B931 VA: 0x5B830
	private static readonly Vector3 <DefaultWindPower>k__BackingField; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x5B840 Offset: 0x5B941 VA: 0x5B840
	private static readonly float <DefaultWindSpeed>k__BackingField; // 0xC
	[CompilerGeneratedAttribute] // RVA: 0x5B850 Offset: 0x5B951 VA: 0x5B850
	private static readonly Vector3 <DefaultWindDir>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x5B860 Offset: 0x5B961 VA: 0x5B860
	private bool <RequestResetSpringLength>k__BackingField; // 0x18
	[HeaderAttribute] // RVA: 0x5B870 Offset: 0x5B971 VA: 0x5B870
	public bool automaticUpdates; // 0x19
	public bool isPaused; // 0x1A
	public int simulationFrameRate; // 0x1C
	[RangeAttribute] // RVA: 0x5B8B0 Offset: 0x5B9B1 VA: 0x5B8B0
	public float dynamicRatio; // 0x20
	public Vector3 gravity; // 0x24
	[RangeAttribute] // RVA: 0x5B8D0 Offset: 0x5B9D1 VA: 0x5B8D0
	public float bounce; // 0x30
	[RangeAttribute] // RVA: 0x5B8F0 Offset: 0x5B9F1 VA: 0x5B8F0
	public float friction; // 0x34
	[HeaderAttribute] // RVA: 0x5B910 Offset: 0x5BA11 VA: 0x5B910
	public bool enableAngleLimits; // 0x38
	public bool enableCollision; // 0x39
	public bool enableLengthLimits; // 0x3A
	[HeaderAttribute] // RVA: 0x5B950 Offset: 0x5BA51 VA: 0x5B950
	public bool collideWithGround; // 0x3B
	public float groundHeight; // 0x3C
	[HeaderAttribute] // RVA: 0x5B990 Offset: 0x5BA91 VA: 0x5B990
	public SpringBone[] springBones; // 0x40
	[HeaderAttribute] // RVA: 0x5B9D0 Offset: 0x5BAD1 VA: 0x5B9D0
	[SerializeField] // RVA: 0x5B9D0 Offset: 0x5BAD1 VA: 0x5B9D0
	[TooltipAttribute] // RVA: 0x5B9D0 Offset: 0x5BAD1 VA: 0x5B9D0
	public bool windDisabled; // 0x48
	[SerializeField] // RVA: 0x5BA40 Offset: 0x5BB41 VA: 0x5BA40
	[RangeAttribute] // RVA: 0x5BA40 Offset: 0x5BB41 VA: 0x5BA40
	[TooltipAttribute] // RVA: 0x5BA40 Offset: 0x5BB41 VA: 0x5BA40
	public float windInfluence; // 0x4C
	[SerializeField] // RVA: 0x5BAB0 Offset: 0x5BBB1 VA: 0x5BAB0
	[TooltipAttribute] // RVA: 0x5BAB0 Offset: 0x5BBB1 VA: 0x5BAB0
	public Vector3 distanceRate; // 0x50
	[CompilerGeneratedAttribute] // RVA: 0x5BB00 Offset: 0x5BC01 VA: 0x5BB00
	private Vector3 <WindPower>k__BackingField; // 0x5C
	[CompilerGeneratedAttribute] // RVA: 0x5BB10 Offset: 0x5BC11 VA: 0x5BB10
	private float <WindSpeed>k__BackingField; // 0x68
	[CompilerGeneratedAttribute] // RVA: 0x5BB20 Offset: 0x5BC21 VA: 0x5BB20
	private Vector3 <WindDir>k__BackingField; // 0x6C
	[HeaderAttribute] // RVA: 0x5BB30 Offset: 0x5BC31 VA: 0x5BB30
	public bool automaticReset; // 0x78
	public float resetDistance; // 0x7C
	public float resetAngle; // 0x80
	private bool firstReset; // 0x84
	public bool LodEnable; // 0x85
	private static float[] LodDistance; // 0x20
	private static int LodCount; // 0x28
	private int LodVariation; // 0x88
	private float windTime; // 0x8C
	private Vector3 localWindPower; // 0x90
	private float localWindSpeed; // 0x9C
	private Vector3 localWindDir; // 0xA0
	private float localApplyTime; // 0xAC
	private float localStartTime; // 0xB0
	private float localDurationTime; // 0xB4
	private float localDecayTime; // 0xB8
	private Vector3 prevFramePosition; // 0xBC
	private Quaternion prevFrameRotation; // 0xC8
	private bool[] boneIsAnimatedStates; // 0xD8

	// Properties
	public static Vector3 DefaultWindPower { get; }
	public static float DefaultWindSpeed { get; }
	public static Vector3 DefaultWindDir { get; }
	public bool RequestResetSpringLength { get; set; }
	public Vector3 WindPower { get; set; }
	public float WindSpeed { get; set; }
	public Vector3 WindDir { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x5C260 Offset: 0x5C361 VA: 0x5C260
	// RVA: 0x3A72C80 Offset: 0x3A72D81 VA: 0x3A72C80
	public static Vector3 get_DefaultWindPower() { }

	[CompilerGeneratedAttribute] // RVA: 0x5C270 Offset: 0x5C371 VA: 0x5C270
	// RVA: 0x3A72CF0 Offset: 0x3A72DF1 VA: 0x3A72CF0
	public static float get_DefaultWindSpeed() { }

	[CompilerGeneratedAttribute] // RVA: 0x5C280 Offset: 0x5C381 VA: 0x5C280
	// RVA: 0x3A72D60 Offset: 0x3A72E61 VA: 0x3A72D60
	public static Vector3 get_DefaultWindDir() { }

	[CompilerGeneratedAttribute] // RVA: 0x5C290 Offset: 0x5C391 VA: 0x5C290
	// RVA: 0x3A72DD0 Offset: 0x3A72ED1 VA: 0x3A72DD0
	public bool get_RequestResetSpringLength() { }

	[CompilerGeneratedAttribute] // RVA: 0x5C2A0 Offset: 0x5C3A1 VA: 0x5C2A0
	// RVA: 0x3A72DE0 Offset: 0x3A72EE1 VA: 0x3A72DE0
	public void set_RequestResetSpringLength(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x5C2B0 Offset: 0x5C3B1 VA: 0x5C2B0
	// RVA: 0x3A72DF0 Offset: 0x3A72EF1 VA: 0x3A72DF0
	public Vector3 get_WindPower() { }

	[CompilerGeneratedAttribute] // RVA: 0x5C2C0 Offset: 0x5C3C1 VA: 0x5C2C0
	// RVA: 0x3A72E00 Offset: 0x3A72F01 VA: 0x3A72E00
	public void set_WindPower(Vector3 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x5C2D0 Offset: 0x5C3D1 VA: 0x5C2D0
	// RVA: 0x3A72E10 Offset: 0x3A72F11 VA: 0x3A72E10
	public float get_WindSpeed() { }

	[CompilerGeneratedAttribute] // RVA: 0x5C2E0 Offset: 0x5C3E1 VA: 0x5C2E0
	// RVA: 0x3A72E20 Offset: 0x3A72F21 VA: 0x3A72E20
	public void set_WindSpeed(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x5C2F0 Offset: 0x5C3F1 VA: 0x5C2F0
	// RVA: 0x3A72E30 Offset: 0x3A72F31 VA: 0x3A72E30
	public Vector3 get_WindDir() { }

	[CompilerGeneratedAttribute] // RVA: 0x5C300 Offset: 0x5C401 VA: 0x5C300
	// RVA: 0x3A72E40 Offset: 0x3A72F41 VA: 0x3A72E40
	public void set_WindDir(Vector3 value) { }

	// RVA: 0x3A72E50 Offset: 0x3A72F51 VA: 0x3A72E50
	public void CopyFrom(SpringJobManager jobmanager) { }

	// RVA: 0x3A72F30 Offset: 0x3A73031 VA: 0x3A72F30 Slot: 4
	public override void Stabilize() { }

	// RVA: 0x3A72FA0 Offset: 0x3A730A1 VA: 0x3A72FA0
	public void ResetSpringLengthAndTipPosition() { }

	// RVA: 0x3A73020 Offset: 0x3A73121 VA: 0x3A73020 Slot: 5
	public override void UpdateSimulation() { }

	// RVA: 0x3A734B0 Offset: 0x3A735B1 VA: 0x3A734B0 Slot: 6
	public override void ResetSimulation() { }

	// RVA: 0x3A734C0 Offset: 0x3A735C1 VA: 0x3A734C0 Slot: 7
	public override void SetGravity(Vector3 gravity) { }

	// RVA: 0x3A734D0 Offset: 0x3A735D1 VA: 0x3A734D0 Slot: 8
	public override void SetGroundHeight(float groundHeight) { }

	// RVA: 0x3A734E0 Offset: 0x3A735E1 VA: 0x3A734E0 Slot: 9
	public override void SetDefaultWindParameter() { }

	// RVA: 0x3A73670 Offset: 0x3A73771 VA: 0x3A73670 Slot: 10
	public override void SetWindPower(Vector3 windPower) { }

	// RVA: 0x3A73680 Offset: 0x3A73781 VA: 0x3A73680 Slot: 11
	public override void SetWindSpeed(float windSpeed) { }

	// RVA: 0x3A73690 Offset: 0x3A73791 VA: 0x3A73690 Slot: 12
	public override void SetWindDir(Vector3 windDir) { }

	// RVA: 0x3A736A0 Offset: 0x3A737A1 VA: 0x3A736A0 Slot: 13
	public override void ApplyLocalWind(Vector3 windPower, float windSpeed, Vector3 windDir, float startTime = 0, float durationTime = 1, float decayTime = 0.2) { }

	// RVA: 0x3A736E0 Offset: 0x3A737E1 VA: 0x3A736E0 Slot: 14
	public override void ReplaceJobManager() { }

	// RVA: 0x3A73F80 Offset: 0x3A74081 VA: 0x3A73F80
	private float UpdateLocalWindRate() { }

	// RVA: 0x3A74050 Offset: 0x3A74151 VA: 0x3A74050
	private Vector3 ApplyWindForce(Vector3 pos, float time, float timeAlpha) { }

	// RVA: 0x3A741F0 Offset: 0x3A742F1 VA: 0x3A741F0
	public void CleanUpBoneColliders() { }

	// RVA: 0x3A745F0 Offset: 0x3A746F1 VA: 0x3A745F0
	public void FindSpringBones(bool includeInactive = False) { }

	// RVA: 0x3A74950 Offset: 0x3A74A51 VA: 0x3A74950
	public void UpdateBoneIsAnimatedStates(IList<string> animatedBoneNames) { }

	// RVA: 0x3A73050 Offset: 0x3A73151 VA: 0x3A73050
	public void UpdateDynamics() { }

	// RVA: 0x3A74AE0 Offset: 0x3A74BE1 VA: 0x3A74AE0
	private static int GetObjectDepth(Transform inObject) { }

	// RVA: 0x3A74B90 Offset: 0x3A74C91 VA: 0x3A74B90
	private Vector3 GetSumOfForcesOnBone(SpringBone springBone) { }

	// RVA: 0x3A74BA0 Offset: 0x3A74CA1 VA: 0x3A74BA0
	private void Awake() { }

	// RVA: 0x3A74C90 Offset: 0x3A74D91 VA: 0x3A74C90
	private void Start() { }

	// RVA: 0x3A74DB0 Offset: 0x3A74EB1 VA: 0x3A74DB0
	private void LateUpdate() { }

	// RVA: 0x3A750D0 Offset: 0x3A751D1 VA: 0x3A750D0
	public void .ctor() { }

	// RVA: 0x3A753D0 Offset: 0x3A754D1 VA: 0x3A753D0
	private static void .cctor() { }
}

