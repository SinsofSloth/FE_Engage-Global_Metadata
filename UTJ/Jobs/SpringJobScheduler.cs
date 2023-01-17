// Namespace: UTJ.Jobs
[DefaultExecutionOrder] // RVA: 0x5B520 Offset: 0x5B621 VA: 0x5B520
public class SpringJobScheduler : MonoBehaviour // TypeDefIndex: 6456
{
	// Fields
	[SerializeField] // RVA: 0x5BF20 Offset: 0x5C021 VA: 0x5BF20
	private bool asynchronize; // 0x18
	[SerializeField] // RVA: 0x5BF30 Offset: 0x5C031 VA: 0x5BF30
	private int maxWorkerThreadCount; // 0x1C
	[SerializeField] // RVA: 0x5BF40 Offset: 0x5C041 VA: 0x5BF40
	private int registerCapacity; // 0x20
	[SerializeField] // RVA: 0x5BF50 Offset: 0x5C051 VA: 0x5BF50
	private int boneCapacity; // 0x24
	[SerializeField] // RVA: 0x5BF60 Offset: 0x5C061 VA: 0x5BF60
	private int colliderCapacity; // 0x28
	[SerializeField] // RVA: 0x5BF70 Offset: 0x5C071 VA: 0x5BF70
	private int registedColliderCapacity; // 0x2C
	[SerializeField] // RVA: 0x5BF80 Offset: 0x5C081 VA: 0x5BF80
	private int registeredLengthLimitCapacity; // 0x30
	[SerializeField] // RVA: 0x5BF90 Offset: 0x5C091 VA: 0x5BF90
	private int forceCapacity; // 0x34
	private static SpringJobScheduler instance; // 0x0
	internal NativeArray<SpringForceComponent> forces; // 0x38
	internal NativeContainerPool<SpringBoneProperties> properties; // 0x48
	internal NativeArray<SpringBoneComponents> components; // 0x50
	internal NativeArray<float4x4> parentComponents; // 0x60
	internal NativeArray<float4x4> pivotComponents; // 0x70
	internal NativeContainerPool<SpringColliderProperties> colProperties; // 0x80
	internal NativeArray<SpringColliderComponents> colComponents; // 0x88
	internal NativeContainerPool<int> colNumbers; // 0x98
	internal NativeContainerPool<LengthLimitProperties> lengthProperties; // 0xA0
	internal NativeContainerPool<float3> lengthLimitTargets; // 0xA8
	internal TransformAccessArray boneTransforms; // 0xB0
	internal TransformAccessArray boneParentTransforms; // 0xB8
	internal TransformAccessArray bonePivotTransforms; // 0xC0
	internal TransformAccessArray colliderTransforms; // 0xC8
	internal TransformAccessArray lengthLimitTransforms; // 0xD0
	private TaskSystem<SpringJobManager> managerTasks; // 0xD8
	private NativeArray<SpringJobElement> managers; // 0xE0
	private NativeArray<JobHandle> preHandle; // 0xF0
	private SpringBoneApplyJob applyJob; // 0x100
	private SpringParentJob parentJob; // 0x110
	private SpringPivotJob pivotJob; // 0x130
	private SpringColliderJob colliderJob; // 0x150
	private SpringLengthTargetJob lengthTargetJob; // 0x160
	private SpringJob springJob; // 0x170
	private JobHandle handle; // 0x198
	private bool scheduled; // 0x1A8
	private bool asyncCache; // 0x1A9
	private List<ForceProvider> forceProviderList; // 0x1B0

	// Properties
	public bool enabledAsync { get; set; }

	// Methods

	// RVA: 0x3A70B00 Offset: 0x3A70C01 VA: 0x3A70B00
	public bool get_enabledAsync() { }

	// RVA: 0x3A70B10 Offset: 0x3A70C11 VA: 0x3A70B10
	public void set_enabledAsync(bool value) { }

	// RVA: 0x3A70B20 Offset: 0x3A70C21 VA: 0x3A70B20
	private void Awake() { }

	// RVA: 0x3A70B30 Offset: 0x3A70C31 VA: 0x3A70B30
	private void Initialize() { }

	// RVA: 0x3A71560 Offset: 0x3A71661 VA: 0x3A71560
	private void OnDestroy() { }

	// RVA: 0x3A718A0 Offset: 0x3A719A1 VA: 0x3A718A0
	private void LateUpdate() { }

	// RVA: 0x3A71CD0 Offset: 0x3A71DD1 VA: 0x3A71CD0
	private void UpdateForceProvider() { }

	// RVA: 0x3A71DD0 Offset: 0x3A71ED1 VA: 0x3A71DD0
	public static void InitializeScheduler() { }

	// RVA: 0x3A71F90 Offset: 0x3A72091 VA: 0x3A71F90
	public static bool Entry(SpringJobManager register) { }

	// RVA: 0x3A721F0 Offset: 0x3A722F1 VA: 0x3A721F0
	public static bool Exit(SpringJobManager scheduler) { }

	// RVA: 0x3A72420 Offset: 0x3A72521 VA: 0x3A72420
	public static void AddForceProvider(ForceProvider force) { }

	// RVA: 0x3A72530 Offset: 0x3A72631 VA: 0x3A72530
	public static void RemoveForceProvider(ForceProvider force) { }

	// RVA: 0x3A72640 Offset: 0x3A72741 VA: 0x3A72640
	public static void ClearForceProvider() { }

	// RVA: 0x3A726C0 Offset: 0x3A727C1 VA: 0x3A726C0
	private static bool CollectSpringJobElements(SpringJobManager manager, int no) { }

	// RVA: 0x3A727E0 Offset: 0x3A728E1 VA: 0x3A727E0
	private static int DetachFineshedJob(SpringJobManager manager) { }

	// RVA: 0x3A727F0 Offset: 0x3A728F1 VA: 0x3A727F0
	private static int AllFinishJob(SpringJobManager manager) { }

	// RVA: 0x3A72870 Offset: 0x3A72971 VA: 0x3A72870
	public static void Reset(int no, SpringJobManager manager) { }

	// RVA: 0x3A72BE0 Offset: 0x3A72CE1 VA: 0x3A72BE0
	public void .ctor() { }

	// RVA: 0x3A72C10 Offset: 0x3A72D11 VA: 0x3A72C10
	private static void .cctor() { }
}

