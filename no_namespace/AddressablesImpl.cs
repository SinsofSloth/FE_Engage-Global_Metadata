// Namespace: 
private class AddressablesImpl.LoadResourceLocationKeyOp : AsyncOperationBase<IList<IResourceLocation>> // TypeDefIndex: 7256
{
	// Fields
	private object m_Keys; // 0x88
	private IList<IResourceLocation> m_locations; // 0x90
	private AddressablesImpl m_Addressables; // 0x98
	private Type m_ResourceType; // 0xA0

	// Properties
	protected override string DebugName { get; }

	// Methods

	// RVA: 0x30A1120 Offset: 0x30A1221 VA: 0x30A1120 Slot: 31
	protected override string get_DebugName() { }

	// RVA: 0x30904F0 Offset: 0x30905F1 VA: 0x30904F0
	public void Init(AddressablesImpl aa, Type t, object keys) { }

	// RVA: 0x30A1130 Offset: 0x30A1231 VA: 0x30A1130 Slot: 33
	protected override bool InvokeWaitForCompletion() { }

	// RVA: 0x30A11C0 Offset: 0x30A12C1 VA: 0x30A11C0 Slot: 28
	protected override void Execute() { }

	// RVA: 0x3090490 Offset: 0x3090591 VA: 0x3090490
	public void .ctor() { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x65370 Offset: 0x65471 VA: 0x65370
private sealed class AddressablesImpl.<>c__DisplayClass40_0 // TypeDefIndex: 7258
{
	// Fields
	public AsyncOperationHandle<SceneInstance> op; // 0x10
	public AddressablesImpl <>4__this; // 0x28

	// Methods

	// RVA: 0x308D860 Offset: 0x308D961 VA: 0x308D860
	public void .ctor() { }

	// RVA: 0x30A0C60 Offset: 0x30A0D61 VA: 0x30A0C60
	internal void <OnSceneUnloaded>b__0(AsyncOperationHandle<SceneInstance> handle) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x65390 Offset: 0x65491 VA: 0x65390
private sealed class AddressablesImpl.<>c__DisplayClass60_0 // TypeDefIndex: 7260
{
	// Fields
	public IResourceLocator loc; // 0x10

	// Methods

	// RVA: 0x308DA40 Offset: 0x308DB41 VA: 0x308DA40
	public void .ctor() { }

	// RVA: 0x30A0CD0 Offset: 0x30A0DD1 VA: 0x30A0CD0
	internal bool <RemoveResourceLocator>b__0(AddressablesImpl.ResourceLocatorInfo l) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x653B0 Offset: 0x654B1 VA: 0x653B0
private sealed class AddressablesImpl.<>c__DisplayClass73_0<TObject> // TypeDefIndex: 7262
{
	// Fields
	public AddressablesImpl <>4__this; // 0x0
	public object key; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B3FEB0 Offset: 0x2B3FFB1 VA: 0x2B3FEB0
	|-AddressablesImpl.<>c__DisplayClass73_0<object>..ctor
	*/

	// RVA: -1 Offset: -1
	internal AsyncOperationHandle<TObject> <LoadAssetWithChain>b__0(AsyncOperationHandle op) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B3FEC0 Offset: 0x2B3FFC1 VA: 0x2B3FEC0
	|-AddressablesImpl.<>c__DisplayClass73_0<object>.<LoadAssetWithChain>b__0
	*/
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x653D0 Offset: 0x654D1 VA: 0x653D0
private sealed class AddressablesImpl.<>c__DisplayClass79_0 // TypeDefIndex: 7264
{
	// Fields
	public AddressablesImpl <>4__this; // 0x10
	public object key; // 0x18
	public Type type; // 0x20

	// Methods

	// RVA: 0x3090480 Offset: 0x3090581 VA: 0x3090480
	public void .ctor() { }

	// RVA: 0x30A0E10 Offset: 0x30A0F11 VA: 0x30A0E10
	internal AsyncOperationHandle<IList<IResourceLocation>> <LoadResourceLocationsWithChain>b__0(AsyncOperationHandle op) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x653F0 Offset: 0x654F1 VA: 0x653F0
private sealed class AddressablesImpl.<>c__DisplayClass84_0<TObject> // TypeDefIndex: 7266
{
	// Fields
	public AddressablesImpl <>4__this; // 0x0
	public object key; // 0x0
	public Action<TObject> callback; // 0x0
	public bool releaseDependenciesOnFailure; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B414D0 Offset: 0x2B415D1 VA: 0x2B414D0
	|-AddressablesImpl.<>c__DisplayClass84_0<object>..ctor
	*/

	// RVA: -1 Offset: -1
	internal AsyncOperationHandle<IList<TObject>> <LoadAssetsWithChain>b__0(AsyncOperationHandle op2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B414E0 Offset: 0x2B415E1 VA: 0x2B414E0
	|-AddressablesImpl.<>c__DisplayClass84_0<object>.<LoadAssetsWithChain>b__0
	*/
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x65410 Offset: 0x65511 VA: 0x65410
private sealed class AddressablesImpl.<>c__DisplayClass92_0 // TypeDefIndex: 7268
{
	// Fields
	public AddressablesImpl <>4__this; // 0x10
	public object key; // 0x18

	// Methods

	// RVA: 0x3090980 Offset: 0x3090A81 VA: 0x3090980
	public void .ctor() { }

	// RVA: 0x30A0E60 Offset: 0x30A0F61 VA: 0x30A0E60
	internal AsyncOperationHandle<long> <GetDownloadSizeWithChain>b__0(AsyncOperationHandle op) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x65430 Offset: 0x65531 VA: 0x65430
private sealed class AddressablesImpl.<>c__DisplayClass96_0 // TypeDefIndex: 7270
{
	// Fields
	public AddressablesImpl <>4__this; // 0x10
	public object key; // 0x18

	// Methods

	// RVA: 0x3090DE0 Offset: 0x3090EE1 VA: 0x3090DE0
	public void .ctor() { }

	// RVA: 0x30A0F00 Offset: 0x30A1001 VA: 0x30A0F00
	internal AsyncOperationHandle<IList<IAssetBundleResource>> <DownloadDependenciesAsyncWithChain>b__0(AsyncOperationHandle op) { }

	// RVA: 0x30A0F90 Offset: 0x30A1091 VA: 0x30A0F90
	internal void <DownloadDependenciesAsyncWithChain>b__1(AsyncOperationHandle<IList<IAssetBundleResource>> op) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x65450 Offset: 0x65551 VA: 0x65450
private sealed class AddressablesImpl.<>c__DisplayClass101_0 // TypeDefIndex: 7272
{
	// Fields
	public AddressablesImpl <>4__this; // 0x10
	public IEnumerable keys; // 0x18
	public Addressables.MergeMode mode; // 0x20

	// Methods

	// RVA: 0x3091A40 Offset: 0x3091B41 VA: 0x3091A40
	public void .ctor() { }

	// RVA: 0x30A0750 Offset: 0x30A0851 VA: 0x30A0750
	internal AsyncOperationHandle<IList<IAssetBundleResource>> <DownloadDependenciesAsyncWithChain>b__0(AsyncOperationHandle op) { }

	// RVA: 0x30A07F0 Offset: 0x30A08F1 VA: 0x30A07F0
	internal void <DownloadDependenciesAsyncWithChain>b__1(AsyncOperationHandle<IList<IAssetBundleResource>> op) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x65470 Offset: 0x65571 VA: 0x65470
private sealed class AddressablesImpl.<>c__DisplayClass106_0 // TypeDefIndex: 7274
{
	// Fields
	public AddressablesImpl <>4__this; // 0x10
	public IList<IResourceLocation> locations; // 0x18
	public bool autoReleaseHandle; // 0x20

	// Methods

	// RVA: 0x3091B20 Offset: 0x3091C21 VA: 0x3091B20
	public void .ctor() { }

	// RVA: 0x30A08C0 Offset: 0x30A09C1 VA: 0x30A08C0
	internal AsyncOperationHandle<bool> <ClearDependencyCacheAsync>b__0(AsyncOperationHandle op) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x65490 Offset: 0x65591 VA: 0x65490
private sealed class AddressablesImpl.<>c__DisplayClass112_0 // TypeDefIndex: 7276
{
	// Fields
	public AddressablesImpl <>4__this; // 0x10
	public object key; // 0x18
	public InstantiationParameters instantiateParameters; // 0x20

	// Methods

	// RVA: 0x3091DA0 Offset: 0x3091EA1 VA: 0x3091DA0
	public void .ctor() { }

	// RVA: 0x30A0960 Offset: 0x30A0A61 VA: 0x30A0960
	internal AsyncOperationHandle<GameObject> <InstantiateWithChain>b__0(AsyncOperationHandle op) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x654B0 Offset: 0x655B1 VA: 0x654B0
private sealed class AddressablesImpl.<>c__DisplayClass117_0 // TypeDefIndex: 7278
{
	// Fields
	public AddressablesImpl <>4__this; // 0x10
	public object key; // 0x18
	public LoadSceneMode loadMode; // 0x20
	public bool activateOnLoad; // 0x24
	public int priority; // 0x28

	// Methods

	// RVA: 0x3092130 Offset: 0x3092231 VA: 0x3092130
	public void .ctor() { }

	// RVA: 0x30A0A40 Offset: 0x30A0B41 VA: 0x30A0A40
	internal AsyncOperationHandle<SceneInstance> <LoadSceneWithChain>b__0(AsyncOperationHandle op) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x654D0 Offset: 0x655D1 VA: 0x654D0
private sealed class AddressablesImpl.<>c__DisplayClass124_0 // TypeDefIndex: 7280
{
	// Fields
	public AddressablesImpl <>4__this; // 0x10
	public bool autoReleaseHandle; // 0x18

	// Methods

	// RVA: 0x3092540 Offset: 0x3092641 VA: 0x3092540
	public void .ctor() { }

	// RVA: 0x30A0B50 Offset: 0x30A0C51 VA: 0x30A0B50
	internal AsyncOperationHandle<SceneInstance> <CreateUnloadSceneWithChain>b__0(AsyncOperationHandle<SceneInstance> completedHandle) { }
}

