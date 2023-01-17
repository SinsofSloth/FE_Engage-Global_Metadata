// Namespace: 
internal class ResourceManager.InstanceOperation : AsyncOperationBase<GameObject> // TypeDefIndex: 5543
{
	// Fields
	private AsyncOperationHandle<GameObject> m_dependency; // 0x88
	private InstantiationParameters m_instantiationParams; // 0xA0
	private IInstanceProvider m_instanceProvider; // 0xD0
	private GameObject m_instance; // 0xD8
	private Scene m_scene; // 0xE0

	// Properties
	protected override string DebugName { get; }
	protected override float Progress { get; }

	// Methods

	// RVA: 0x36350C0 Offset: 0x36351C1 VA: 0x36350C0
	public void Init(ResourceManager rm, IInstanceProvider instanceProvider, InstantiationParameters instantiationParams, AsyncOperationHandle<GameObject> dependency) { }

	// RVA: 0x36399D0 Offset: 0x3639AD1 VA: 0x36399D0 Slot: 35
	internal override DownloadStatus GetDownloadStatus(HashSet<object> visited) { }

	// RVA: 0x3639AC0 Offset: 0x3639BC1 VA: 0x3639AC0 Slot: 32
	protected override void GetDependencies(List<AsyncOperationHandle> deps) { }

	// RVA: 0x3639B80 Offset: 0x3639C81 VA: 0x3639B80 Slot: 31
	protected override string get_DebugName() { }

	// RVA: 0x3639CA0 Offset: 0x3639DA1 VA: 0x3639CA0
	public Scene InstanceScene() { }

	// RVA: 0x3639CB0 Offset: 0x3639DB1 VA: 0x3639CB0 Slot: 29
	protected override void Destroy() { }

	// RVA: 0x3639D70 Offset: 0x3639E71 VA: 0x3639D70 Slot: 30
	protected override float get_Progress() { }

	// RVA: 0x3639DD0 Offset: 0x3639ED1 VA: 0x3639DD0 Slot: 33
	protected override bool InvokeWaitForCompletion() { }

	// RVA: 0x3639F20 Offset: 0x363A021 VA: 0x3639F20 Slot: 28
	protected override void Execute() { }

	// RVA: 0x363A170 Offset: 0x363A271 VA: 0x363A170
	public void .ctor() { }
}

