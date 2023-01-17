// Namespace: UTJ.Jobs
[DefaultExecutionOrder] // RVA: 0x5B4F0 Offset: 0x5B5F1 VA: 0x5B4F0
public class SpringJobManager : ISpringManager // TypeDefIndex: 6453
{
	// Fields
	[HeaderAttribute] // RVA: 0x5BBF0 Offset: 0x5BCF1 VA: 0x5BBF0
	public bool optimizeTransform; // 0x18
	[HeaderAttribute] // RVA: 0x5BC30 Offset: 0x5BD31 VA: 0x5BC30
	public bool isPaused; // 0x19
	public int simulationFrameRate; // 0x1C
	[RangeAttribute] // RVA: 0x5BC70 Offset: 0x5BD71 VA: 0x5BC70
	public float dynamicRatio; // 0x20
	public Vector3 gravity; // 0x24
	[RangeAttribute] // RVA: 0x5BC90 Offset: 0x5BD91 VA: 0x5BC90
	public float bounce; // 0x30
	[RangeAttribute] // RVA: 0x5BCB0 Offset: 0x5BDB1 VA: 0x5BCB0
	public float friction; // 0x34
	public float time; // 0x38
	[HeaderAttribute] // RVA: 0x5BCD0 Offset: 0x5BDD1 VA: 0x5BCD0
	public bool enableAngleLimits; // 0x3C
	public bool enableCollision; // 0x3D
	public bool enableLengthLimits; // 0x3E
	[HeaderAttribute] // RVA: 0x5BD10 Offset: 0x5BE11 VA: 0x5BD10
	public bool collideWithGround; // 0x3F
	public float groundHeight; // 0x40
	public bool windDisabled; // 0x44
	public float windInfluence; // 0x48
	public float3 windPower; // 0x4C
	public float3 windDir; // 0x58
	public float3 distanceRate; // 0x64
	[HeaderAttribute] // RVA: 0x5BD50 Offset: 0x5BE51 VA: 0x5BD50
	public bool automaticReset; // 0x70
	public float resetDistance; // 0x74
	public float resetAngle; // 0x78
	private bool resetRequest; // 0x7C
	private bool firstReset; // 0x7D
	private Vector3 prevFramePosition; // 0x80
	private Quaternion prevFrameRotation; // 0x8C
	private SpringJobElement job; // 0xA0
	private int jobNo; // 0x168
	private int boneIndex; // 0x16C
	private int colIndex; // 0x170
	private int lengthIndex; // 0x174
	private NestedNativeArray<SpringBoneProperties> properties; // 0x178
	private NestedNativeArray<SpringColliderProperties> colProperties; // 0x188
	private NestedNativeArray<float3> lengthLimitTargets; // 0x198
	private bool entryJob; // 0x1A8
	[HideInInspector] // RVA: 0x5BD90 Offset: 0x5BE91 VA: 0x5BD90
	[SerializeField] // RVA: 0x5BD90 Offset: 0x5BE91 VA: 0x5BD90
	public SpringBone[] SortedBones; // 0x1B0
	[HideInInspector] // RVA: 0x5BDD0 Offset: 0x5BED1 VA: 0x5BDD0
	[SerializeField] // RVA: 0x5BDD0 Offset: 0x5BED1 VA: 0x5BDD0
	private SpringCollider[] jobColliders; // 0x1B8
	[HideInInspector] // RVA: 0x5BE10 Offset: 0x5BF11 VA: 0x5BE10
	[SerializeField] // RVA: 0x5BE10 Offset: 0x5BF11 VA: 0x5BE10
	private SpringBoneProperties[] jobProperties; // 0x1C0
	[HideInInspector] // RVA: 0x5BE50 Offset: 0x5BF51 VA: 0x5BE50
	[SerializeField] // RVA: 0x5BE50 Offset: 0x5BF51 VA: 0x5BE50
	private Quaternion[] initLocalRotations; // 0x1C8
	[HideInInspector] // RVA: 0x5BE90 Offset: 0x5BF91 VA: 0x5BE90
	[SerializeField] // RVA: 0x5BE90 Offset: 0x5BF91 VA: 0x5BE90
	private SpringColliderProperties[] jobColProperties; // 0x1D0
	[SerializeField] // RVA: 0x5BED0 Offset: 0x5BFD1 VA: 0x5BED0
	[HideInInspector] // RVA: 0x5BED0 Offset: 0x5BFD1 VA: 0x5BED0
	private LengthLimitProperties[] jobLengthProperties; // 0x1D8
	[CompilerGeneratedAttribute] // RVA: 0x5BF10 Offset: 0x5C011 VA: 0x5BF10
	private bool <initialized>k__BackingField; // 0x1E0

	// Properties
	public bool initialized { get; set; }

	// Methods

	// RVA: 0x3120E70 Offset: 0x3120F71 VA: 0x3120E70
	public void CopyFrom(SpringManager manager) { }

	[CompilerGeneratedAttribute] // RVA: 0x5C480 Offset: 0x5C581 VA: 0x5C480
	// RVA: 0x3120F50 Offset: 0x3121051 VA: 0x3120F50
	public bool get_initialized() { }

	[CompilerGeneratedAttribute] // RVA: 0x5C490 Offset: 0x5C591 VA: 0x5C490
	// RVA: 0x3120F60 Offset: 0x3121061 VA: 0x3120F60
	private void set_initialized(bool value) { }

	// RVA: 0x3120F70 Offset: 0x3121071 VA: 0x3120F70 Slot: 4
	public override void Stabilize() { }

	// RVA: 0x3120F80 Offset: 0x3121081 VA: 0x3120F80 Slot: 5
	public override void UpdateSimulation() { }

	// RVA: 0x3120F90 Offset: 0x3121091 VA: 0x3120F90 Slot: 6
	public override void ResetSimulation() { }

	// RVA: 0x3120FA0 Offset: 0x31210A1 VA: 0x3120FA0 Slot: 7
	public override void SetGravity(Vector3 gravity) { }

	// RVA: 0x3120FB0 Offset: 0x31210B1 VA: 0x3120FB0 Slot: 8
	public override void SetGroundHeight(float groundHeight) { }

	// RVA: 0x3120FC0 Offset: 0x31210C1 VA: 0x3120FC0 Slot: 9
	public override void SetDefaultWindParameter() { }

	// RVA: 0x3120FD0 Offset: 0x31210D1 VA: 0x3120FD0 Slot: 10
	public override void SetWindPower(Vector3 windPower) { }

	// RVA: 0x3120FE0 Offset: 0x31210E1 VA: 0x3120FE0 Slot: 11
	public override void SetWindSpeed(float windSpeed) { }

	// RVA: 0x3120FF0 Offset: 0x31210F1 VA: 0x3120FF0 Slot: 12
	public override void SetWindDir(Vector3 windDir) { }

	// RVA: 0x3121000 Offset: 0x3121101 VA: 0x3121000 Slot: 13
	public override void ApplyLocalWind(Vector3 windPower, float windSpeed, Vector3 windDir, float startTime = 0.2, float durationTime = 1, float decayTime = 0.2) { }

	// RVA: 0x3121010 Offset: 0x3121111 VA: 0x3121010 Slot: 14
	public override void ReplaceJobManager() { }

	// RVA: 0x3121020 Offset: 0x3121121 VA: 0x3121020
	private void LateUpdate() { }

	// RVA: 0x3121320 Offset: 0x3121421 VA: 0x3121320
	private static int GetObjectDepth(Transform inObject) { }

	// RVA: 0x31213D0 Offset: 0x31214D1 VA: 0x31213D0
	public SpringBone[] FindSpringBones(bool includeInactive = False) { }

	// RVA: 0x3121710 Offset: 0x3121811 VA: 0x3121710
	public void CachedJobParam() { }

	// RVA: 0x31221B0 Offset: 0x31222B1 VA: 0x31221B0
	internal bool Initialize(SpringJobScheduler scheduler) { }

	// RVA: 0x3122CE0 Offset: 0x3122DE1 VA: 0x3122CE0
	internal void Final(SpringJobScheduler scheduler) { }

	// RVA: 0x3122F50 Offset: 0x3123051 VA: 0x3122F50
	public SpringJobElement GetElement(int no) { }

	// RVA: 0x3123030 Offset: 0x3123131 VA: 0x3123030
	private void OnEnable() { }

	// RVA: 0x31230C0 Offset: 0x31231C1 VA: 0x31230C0
	private void OnDisable() { }

	// RVA: 0x3123140 Offset: 0x3123241 VA: 0x3123140
	private void OnDestroy() { }

	// RVA: 0x31231C0 Offset: 0x31232C1 VA: 0x31231C0
	public void .ctor() { }
}

