// Namespace: UnityEngine.ResourceManagement.AsyncOperations
internal class GroupOperation : AsyncOperationBase<IList<AsyncOperationHandle>>, ICachable // TypeDefIndex: 5620
{
	// Fields
	private Action<AsyncOperationHandle> m_InternalOnComplete; // 0x88
	private int m_LoadedCount; // 0x90
	private GroupOperation.GroupOperationSettings m_Settings; // 0x94
	private string debugName; // 0x98
	private const int k_MaxDisplayedLocationLength = 45;
	[CompilerGeneratedAttribute] // RVA: 0x72AF0 Offset: 0x72BF1 VA: 0x72AF0
	private IOperationCacheKey <UnityEngine.ResourceManagement.AsyncOperations.ICachable.Key>k__BackingField; // 0xA0
	private HashSet<string> m_CachedDependencyLocations; // 0xA8

	// Properties
	private IOperationCacheKey UnityEngine.ResourceManagement.AsyncOperations.ICachable.Key { get; set; }
	protected override string DebugName { get; }
	protected override float Progress { get; }

	// Methods

	// RVA: 0x362BBB0 Offset: 0x362BCB1 VA: 0x362BBB0
	public void .ctor() { }

	// RVA: 0x362BD30 Offset: 0x362BE31 VA: 0x362BD30 Slot: 33
	protected override bool InvokeWaitForCompletion() { }

	[CompilerGeneratedAttribute] // RVA: 0x72FF0 Offset: 0x730F1 VA: 0x72FF0
	// RVA: 0x362C380 Offset: 0x362C481 VA: 0x362C380 Slot: 36
	private IOperationCacheKey UnityEngine.ResourceManagement.AsyncOperations.ICachable.get_Key() { }

	[CompilerGeneratedAttribute] // RVA: 0x73000 Offset: 0x73101 VA: 0x73000
	// RVA: 0x362C390 Offset: 0x362C491 VA: 0x362C390 Slot: 37
	private void UnityEngine.ResourceManagement.AsyncOperations.ICachable.set_Key(IOperationCacheKey value) { }

	// RVA: 0x362C3A0 Offset: 0x362C4A1 VA: 0x362C3A0
	internal IList<AsyncOperationHandle> GetDependentOps() { }

	// RVA: 0x362C3E0 Offset: 0x362C4E1 VA: 0x362C3E0 Slot: 32
	protected override void GetDependencies(List<AsyncOperationHandle> deps) { }

	// RVA: 0x362C450 Offset: 0x362C551 VA: 0x362C450 Slot: 34
	internal override void ReleaseDependencies() { }

	// RVA: 0x362C730 Offset: 0x362C831 VA: 0x362C730 Slot: 35
	internal override DownloadStatus GetDownloadStatus(HashSet<object> visited) { }

	// RVA: 0x362CA30 Offset: 0x362CB31 VA: 0x362CA30
	private bool DependenciesAreUnchanged(List<AsyncOperationHandle> deps) { }

	// RVA: 0x362CBF0 Offset: 0x362CCF1 VA: 0x362CBF0 Slot: 31
	protected override string get_DebugName() { }

	// RVA: 0x362CED0 Offset: 0x362CFD1 VA: 0x362CED0 Slot: 28
	protected override void Execute() { }

	// RVA: 0x362D180 Offset: 0x362D281 VA: 0x362D180
	private void CompleteIfDependenciesComplete() { }

	// RVA: 0x362D700 Offset: 0x362D801 VA: 0x362D700 Slot: 29
	protected override void Destroy() { }

	// RVA: 0x362D710 Offset: 0x362D811 VA: 0x362D710 Slot: 30
	protected override float get_Progress() { }

	// RVA: 0x362D9A0 Offset: 0x362DAA1 VA: 0x362D9A0
	public void Init(List<AsyncOperationHandle> operations, bool releaseDependenciesOnFailure = True, bool allowFailedDependencies = False) { }

	// RVA: 0x362DA70 Offset: 0x362DB71 VA: 0x362DA70
	public void Init(List<AsyncOperationHandle> operations, GroupOperation.GroupOperationSettings settings) { }

	// RVA: 0x362DB20 Offset: 0x362DC21 VA: 0x362DB20
	private void OnOperationCompleted(AsyncOperationHandle op) { }
}

