// Namespace: 
public class AddressablesImpl.ResourceLocatorInfo // TypeDefIndex: 7255
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x655C0 Offset: 0x656C1 VA: 0x655C0
	private IResourceLocator <Locator>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x655D0 Offset: 0x656D1 VA: 0x655D0
	private string <LocalHash>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x655E0 Offset: 0x656E1 VA: 0x655E0
	private IResourceLocation <CatalogLocation>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x655F0 Offset: 0x656F1 VA: 0x655F0
	private bool <ContentUpdateAvailable>k__BackingField; // 0x28

	// Properties
	public IResourceLocator Locator { get; set; }
	public string LocalHash { get; set; }
	public IResourceLocation CatalogLocation { get; set; }
	public bool ContentUpdateAvailable { get; set; }
	public IResourceLocation HashLocation { get; }
	public bool CanUpdateContent { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x66240 Offset: 0x66341 VA: 0x66240
	// RVA: 0x30A1480 Offset: 0x30A1581 VA: 0x30A1480
	public IResourceLocator get_Locator() { }

	[CompilerGeneratedAttribute] // RVA: 0x66250 Offset: 0x66351 VA: 0x66250
	// RVA: 0x30A1490 Offset: 0x30A1591 VA: 0x30A1490
	private void set_Locator(IResourceLocator value) { }

	[CompilerGeneratedAttribute] // RVA: 0x66260 Offset: 0x66361 VA: 0x66260
	// RVA: 0x30A14A0 Offset: 0x30A15A1 VA: 0x30A14A0
	public string get_LocalHash() { }

	[CompilerGeneratedAttribute] // RVA: 0x66270 Offset: 0x66371 VA: 0x66270
	// RVA: 0x30A14B0 Offset: 0x30A15B1 VA: 0x30A14B0
	private void set_LocalHash(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x66280 Offset: 0x66381 VA: 0x66280
	// RVA: 0x30A14C0 Offset: 0x30A15C1 VA: 0x30A14C0
	public IResourceLocation get_CatalogLocation() { }

	[CompilerGeneratedAttribute] // RVA: 0x66290 Offset: 0x66391 VA: 0x66290
	// RVA: 0x30A14D0 Offset: 0x30A15D1 VA: 0x30A14D0
	private void set_CatalogLocation(IResourceLocation value) { }

	[CompilerGeneratedAttribute] // RVA: 0x662A0 Offset: 0x663A1 VA: 0x662A0
	// RVA: 0x30A14E0 Offset: 0x30A15E1 VA: 0x30A14E0
	public bool get_ContentUpdateAvailable() { }

	[CompilerGeneratedAttribute] // RVA: 0x662B0 Offset: 0x663B1 VA: 0x662B0
	// RVA: 0x30A14F0 Offset: 0x30A15F1 VA: 0x30A14F0
	internal void set_ContentUpdateAvailable(bool value) { }

	// RVA: 0x308D9D0 Offset: 0x308DAD1 VA: 0x308D9D0
	public void .ctor(IResourceLocator loc, string localHash, IResourceLocation remoteCatalogLocation) { }

	// RVA: 0x30961E0 Offset: 0x30962E1 VA: 0x30961E0
	public IResourceLocation get_HashLocation() { }

	// RVA: 0x3096020 Offset: 0x3096121 VA: 0x3096020
	public bool get_CanUpdateContent() { }

	// RVA: 0x30A05A0 Offset: 0x30A06A1 VA: 0x30A05A0
	internal void UpdateContent(IResourceLocator locator, string hash, IResourceLocation loc) { }
}

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
private class AddressablesImpl.LoadResourceLocationKeysOp : AsyncOperationBase<IList<IResourceLocation>> // TypeDefIndex: 7257
{
	// Fields
	private IEnumerable m_Key; // 0x88
	private Addressables.MergeMode m_MergeMode; // 0x90
	private IList<IResourceLocation> m_locations; // 0x98
	private AddressablesImpl m_Addressables; // 0xA0
	private Type m_ResourceType; // 0xA8

	// Properties
	protected override string DebugName { get; }

	// Methods

	// RVA: 0x30A12B0 Offset: 0x30A13B1 VA: 0x30A12B0 Slot: 31
	protected override string get_DebugName() { }

	// RVA: 0x30902A0 Offset: 0x30903A1 VA: 0x30902A0
	public void Init(AddressablesImpl aa, Type t, IEnumerable key, Addressables.MergeMode mergeMode) { }

	// RVA: 0x30A1300 Offset: 0x30A1401 VA: 0x30A1300 Slot: 28
	protected override void Execute() { }

	// RVA: 0x30A13F0 Offset: 0x30A14F1 VA: 0x30A13F0 Slot: 33
	protected override bool InvokeWaitForCompletion() { }

	// RVA: 0x3090240 Offset: 0x3090341 VA: 0x3090240
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
[CompilerGeneratedAttribute] // RVA: 0x65380 Offset: 0x65481 VA: 0x65380
[Serializable]
private sealed class AddressablesImpl.<>c // TypeDefIndex: 7259
{
	// Fields
	public static readonly AddressablesImpl.<>c <>9; // 0x0
	public static Func<AddressablesImpl.ResourceLocatorInfo, IResourceLocator> <>9__58_0; // 0x8
	public static Func<AddressablesImpl.ResourceLocatorInfo, bool> <>9__130_0; // 0x10
	public static Func<AddressablesImpl.ResourceLocatorInfo, string> <>9__130_1; // 0x18

	// Methods

	// RVA: 0x30A0600 Offset: 0x30A0701 VA: 0x30A0600
	private static void .cctor() { }

	// RVA: 0x30A0670 Offset: 0x30A0771 VA: 0x30A0670
	public void .ctor() { }

	// RVA: 0x30A0680 Offset: 0x30A0781 VA: 0x30A0680
	internal IResourceLocator <get_ResourceLocators>b__58_0(AddressablesImpl.ResourceLocatorInfo l) { }

	// RVA: 0x30A0690 Offset: 0x30A0791 VA: 0x30A0690
	internal bool <get_CatalogsWithAvailableUpdates>b__130_0(AddressablesImpl.ResourceLocatorInfo s) { }

	// RVA: 0x30A06A0 Offset: 0x30A07A1 VA: 0x30A06A0
	internal string <get_CatalogsWithAvailableUpdates>b__130_1(AddressablesImpl.ResourceLocatorInfo s) { }
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
[CompilerGeneratedAttribute] // RVA: 0x653A0 Offset: 0x654A1 VA: 0x653A0
private sealed class AddressablesImpl.<>c__DisplayClass67_0 // TypeDefIndex: 7261
{
	// Fields
	public AddressablesImpl <>4__this; // 0x10
	public string catalogPath; // 0x18
	public bool autoReleaseHandle; // 0x20
	public string providerSuffix; // 0x28
	public AsyncOperationHandle<IResourceLocator> handle; // 0x30

	// Methods

	// RVA: 0x308F890 Offset: 0x308F991 VA: 0x308F890
	public void .ctor() { }

	// RVA: 0x30A0CF0 Offset: 0x30A0DF1 VA: 0x30A0CF0
	internal AsyncOperationHandle<IResourceLocator> <LoadContentCatalogAsync>b__0(AsyncOperationHandle op) { }

	// RVA: 0x30A0D40 Offset: 0x30A0E41 VA: 0x30A0D40
	internal void <LoadContentCatalogAsync>b__1(AsyncOperationHandle<IResourceLocator> obj) { }
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
[CompilerGeneratedAttribute] // RVA: 0x653C0 Offset: 0x654C1 VA: 0x653C0
private sealed class AddressablesImpl.<>c__DisplayClass77_0 // TypeDefIndex: 7263
{
	// Fields
	public AddressablesImpl <>4__this; // 0x10
	public IEnumerable keys; // 0x18
	public Addressables.MergeMode mode; // 0x20
	public Type type; // 0x28

	// Methods

	// RVA: 0x3090230 Offset: 0x3090331 VA: 0x3090230
	public void .ctor() { }

	// RVA: 0x30A0DC0 Offset: 0x30A0EC1 VA: 0x30A0DC0
	internal AsyncOperationHandle<IList<IResourceLocation>> <LoadResourceLocationsWithChain>b__0(AsyncOperationHandle op) { }
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
[CompilerGeneratedAttribute] // RVA: 0x653E0 Offset: 0x654E1 VA: 0x653E0
private sealed class AddressablesImpl.<>c__DisplayClass82_0<TObject> // TypeDefIndex: 7265
{
	// Fields
	public AddressablesImpl <>4__this; // 0x0
	public IEnumerable keys; // 0x0
	public Action<TObject> callback; // 0x0
	public Addressables.MergeMode mode; // 0x0
	public bool releaseDependenciesOnFailure; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B41450 Offset: 0x2B41551 VA: 0x2B41450
	|-AddressablesImpl.<>c__DisplayClass82_0<object>..ctor
	*/

	// RVA: -1 Offset: -1
	internal AsyncOperationHandle<IList<TObject>> <LoadAssetsWithChain>b__0(AsyncOperationHandle op) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B41460 Offset: 0x2B41561 VA: 0x2B41460
	|-AddressablesImpl.<>c__DisplayClass82_0<object>.<LoadAssetsWithChain>b__0
	*/
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
[CompilerGeneratedAttribute] // RVA: 0x65400 Offset: 0x65501 VA: 0x65400
private sealed class AddressablesImpl.<>c__DisplayClass90_0<TObject> // TypeDefIndex: 7267
{
	// Fields
	public AddressablesImpl <>4__this; // 0x0
	public AsyncOperationHandle<TObject> handle; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B42090 Offset: 0x2B42191 VA: 0x2B42090
	|-AddressablesImpl.<>c__DisplayClass90_0<object>..ctor
	|
	|-RVA: 0x2B420F0 Offset: 0x2B421F1 VA: 0x2B420F0
	|-AddressablesImpl.<>c__DisplayClass90_0<SceneInstance>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void <Release>b__0(AsyncOperationHandle<TObject> s) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B420A0 Offset: 0x2B421A1 VA: 0x2B420A0
	|-AddressablesImpl.<>c__DisplayClass90_0<object>.<Release>b__0
	|
	|-RVA: 0x2B42100 Offset: 0x2B42201 VA: 0x2B42100
	|-AddressablesImpl.<>c__DisplayClass90_0<SceneInstance>.<Release>b__0
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
[CompilerGeneratedAttribute] // RVA: 0x65420 Offset: 0x65521 VA: 0x65420
private sealed class AddressablesImpl.<>c__DisplayClass93_0 // TypeDefIndex: 7269
{
	// Fields
	public AddressablesImpl <>4__this; // 0x10
	public IEnumerable keys; // 0x18

	// Methods

	// RVA: 0x3090B00 Offset: 0x3090C01 VA: 0x3090B00
	public void .ctor() { }

	// RVA: 0x30A0EB0 Offset: 0x30A0FB1 VA: 0x30A0EB0
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
[CompilerGeneratedAttribute] // RVA: 0x65440 Offset: 0x65541 VA: 0x65440
private sealed class AddressablesImpl.<>c__DisplayClass99_0 // TypeDefIndex: 7271
{
	// Fields
	public AddressablesImpl <>4__this; // 0x10
	public IList<IResourceLocation> locations; // 0x18

	// Methods

	// RVA: 0x30917F0 Offset: 0x30918F1 VA: 0x30917F0
	public void .ctor() { }

	// RVA: 0x30A1010 Offset: 0x30A1111 VA: 0x30A1010
	internal AsyncOperationHandle<IList<IAssetBundleResource>> <DownloadDependenciesAsyncWithChain>b__0(AsyncOperationHandle op) { }

	// RVA: 0x30A10A0 Offset: 0x30A11A1 VA: 0x30A10A0
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
[CompilerGeneratedAttribute] // RVA: 0x65460 Offset: 0x65561 VA: 0x65460
private sealed class AddressablesImpl.<>c__DisplayClass105_0 // TypeDefIndex: 7273
{
	// Fields
	public AddressablesImpl <>4__this; // 0x10
	public object key; // 0x18
	public bool autoReleaseHandle; // 0x20

	// Methods

	// RVA: 0x3091B10 Offset: 0x3091C11 VA: 0x3091B10
	public void .ctor() { }

	// RVA: 0x30A0870 Offset: 0x30A0971 VA: 0x30A0870
	internal AsyncOperationHandle<bool> <ClearDependencyCacheAsync>b__0(AsyncOperationHandle op) { }
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
[CompilerGeneratedAttribute] // RVA: 0x65480 Offset: 0x65581 VA: 0x65480
private sealed class AddressablesImpl.<>c__DisplayClass107_0 // TypeDefIndex: 7275
{
	// Fields
	public AddressablesImpl <>4__this; // 0x10
	public IEnumerable keys; // 0x18
	public bool autoReleaseHandle; // 0x20

	// Methods

	// RVA: 0x3091B30 Offset: 0x3091C31 VA: 0x3091B30
	public void .ctor() { }

	// RVA: 0x30A0910 Offset: 0x30A0A11 VA: 0x30A0910
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
[CompilerGeneratedAttribute] // RVA: 0x654A0 Offset: 0x655A1 VA: 0x654A0
private sealed class AddressablesImpl.<>c__DisplayClass114_0 // TypeDefIndex: 7277
{
	// Fields
	public AddressablesImpl <>4__this; // 0x10
	public IResourceLocation location; // 0x18
	public InstantiationParameters instantiateParameters; // 0x20

	// Methods

	// RVA: 0x3091F70 Offset: 0x3092071 VA: 0x3091F70
	public void .ctor() { }

	// RVA: 0x30A09D0 Offset: 0x30A0AD1 VA: 0x30A09D0
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
[CompilerGeneratedAttribute] // RVA: 0x654C0 Offset: 0x655C1 VA: 0x654C0
private sealed class AddressablesImpl.<>c__DisplayClass123_0 // TypeDefIndex: 7279
{
	// Fields
	public AddressablesImpl <>4__this; // 0x10
	public bool autoReleaseHandle; // 0x18

	// Methods

	// RVA: 0x3092530 Offset: 0x3092631 VA: 0x3092530
	public void .ctor() { }

	// RVA: 0x30A0AA0 Offset: 0x30A0BA1 VA: 0x30A0AA0
	internal AsyncOperationHandle<SceneInstance> <CreateUnloadSceneWithChain>b__0(AsyncOperationHandle completedHandle) { }
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

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x654E0 Offset: 0x655E1 VA: 0x654E0
private sealed class AddressablesImpl.<>c__DisplayClass131_0 // TypeDefIndex: 7281
{
	// Fields
	public AddressablesImpl <>4__this; // 0x10
	public bool autoReleaseHandle; // 0x18

	// Methods

	// RVA: 0x3092EA0 Offset: 0x3092FA1 VA: 0x3092EA0
	public void .ctor() { }

	// RVA: 0x30A0BB0 Offset: 0x30A0CB1 VA: 0x30A0BB0
	internal AsyncOperationHandle<List<IResourceLocator>> <UpdateCatalogs>b__0(AsyncOperationHandle<List<string>> depOp) { }

	// RVA: 0x30A0C10 Offset: 0x30A0D11 VA: 0x30A0C10
	internal void <UpdateCatalogs>b__1(AsyncOperationHandle o) { }
}

