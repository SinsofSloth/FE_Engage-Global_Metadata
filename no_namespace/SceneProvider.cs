// Namespace: 
private class SceneProvider.SceneOp : AsyncOperationBase<SceneInstance>, IUpdateReceiver // TypeDefIndex: 5598
{
	// Fields
	private bool m_ActivateOnLoad; // 0x90
	private SceneInstance m_Inst; // 0x98
	private IResourceLocation m_Location; // 0xA8
	private LoadSceneMode m_LoadMode; // 0xB0
	private int m_Priority; // 0xB4
	private AsyncOperationHandle<IList<AsyncOperationHandle>> m_DepOp; // 0xB8
	private ResourceManager m_ResourceManager; // 0xD0

	// Properties
	protected override string DebugName { get; }
	protected override float Progress { get; }

	// Methods

	// RVA: 0x3636620 Offset: 0x3636721 VA: 0x3636620
	public void .ctor(ResourceManager rm) { }

	// RVA: 0x363A330 Offset: 0x363A431 VA: 0x363A330 Slot: 35
	internal override DownloadStatus GetDownloadStatus(HashSet<object> visited) { }

	// RVA: 0x3636690 Offset: 0x3636791 VA: 0x3636690
	public void Init(IResourceLocation location, LoadSceneMode loadMode, bool activateOnLoad, int priority, AsyncOperationHandle<IList<AsyncOperationHandle>> depOp) { }

	// RVA: 0x363A420 Offset: 0x363A521 VA: 0x363A420 Slot: 33
	protected override bool InvokeWaitForCompletion() { }

	// RVA: 0x363A5F0 Offset: 0x363A6F1 VA: 0x363A5F0 Slot: 32
	protected override void GetDependencies(List<AsyncOperationHandle> deps) { }

	// RVA: 0x363A6D0 Offset: 0x363A7D1 VA: 0x363A6D0 Slot: 31
	protected override string get_DebugName() { }

	// RVA: 0x363A780 Offset: 0x363A881 VA: 0x363A780 Slot: 28
	protected override void Execute() { }

	// RVA: 0x363ACE0 Offset: 0x363ADE1 VA: 0x363ACE0
	internal SceneInstance InternalLoadScene(IResourceLocation location, bool loadingFromBundle, LoadSceneMode loadMode, bool activateOnLoad, int priority) { }

	// RVA: 0x363AE30 Offset: 0x363AF31 VA: 0x363AE30
	private AsyncOperation InternalLoad(string path, bool loadingFromBundle, LoadSceneMode mode) { }

	// RVA: 0x363AED0 Offset: 0x363AFD1 VA: 0x363AED0 Slot: 29
	protected override void Destroy() { }

	// RVA: 0x363AF70 Offset: 0x363B071 VA: 0x363AF70 Slot: 30
	protected override float get_Progress() { }

	// RVA: 0x363B050 Offset: 0x363B151 VA: 0x363B050 Slot: 36
	private void UnityEngine.ResourceManagement.IUpdateReceiver.Update(float unscaledDeltaTime) { }
}

