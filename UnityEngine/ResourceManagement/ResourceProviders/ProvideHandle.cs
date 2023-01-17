// Namespace: UnityEngine.ResourceManagement.ResourceProviders
public struct ProvideHandle // TypeDefIndex: 5586
{
	// Fields
	private int m_Version; // 0x0
	private IGenericProviderOperation m_InternalOp; // 0x8
	private ResourceManager m_ResourceManager; // 0x10

	// Properties
	private IGenericProviderOperation InternalOp { get; }
	public ResourceManager ResourceManager { get; }
	public Type Type { get; }
	public IResourceLocation Location { get; }
	public int DependencyCount { get; }

	// Methods

	// RVA: 0x36308B0 Offset: 0x36309B1 VA: 0x36308B0
	internal void .ctor(ResourceManager rm, IGenericProviderOperation op) { }

	// RVA: 0x3630990 Offset: 0x3630A91 VA: 0x3630990
	private IGenericProviderOperation get_InternalOp() { }

	// RVA: 0x3630AA0 Offset: 0x3630BA1 VA: 0x3630AA0
	public ResourceManager get_ResourceManager() { }

	// RVA: 0x362EDD0 Offset: 0x362EED1 VA: 0x362EDD0
	public Type get_Type() { }

	// RVA: 0x3624660 Offset: 0x3624761 VA: 0x3624660
	public IResourceLocation get_Location() { }

	// RVA: 0x3630AB0 Offset: 0x3630BB1 VA: 0x3630AB0
	public int get_DependencyCount() { }

	// RVA: -1 Offset: -1
	public TDepObject GetDependency<TDepObject>(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2014C60 Offset: 0x2014D61 VA: 0x2014C60
	|-ProvideHandle.GetDependency<object>
	|-ProvideHandle.GetDependency<SpriteAtlas>
	*/

	// RVA: 0x3630B60 Offset: 0x3630C61 VA: 0x3630B60
	public void GetDependencies(IList<object> list) { }

	// RVA: 0x3624710 Offset: 0x3624811 VA: 0x3624710
	public void SetProgressCallback(Func<float> callback) { }

	// RVA: 0x36247D0 Offset: 0x36248D1 VA: 0x36247D0
	public void SetDownloadProgressCallbacks(Func<DownloadStatus> callback) { }

	// RVA: 0x3624890 Offset: 0x3624991 VA: 0x3624890
	public void SetWaitForCompletionCallback(Func<bool> callback) { }

	// RVA: -1 Offset: -1
	public void Complete<T>(T result, bool status, Exception exception) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2014BA0 Offset: 0x2014CA1 VA: 0x2014BA0
	|-ProvideHandle.Complete<AssetBundle>
	|-ProvideHandle.Complete<AssetBundleLocalResource>
	|-ProvideHandle.Complete<AssetBundleResource>
	|-ProvideHandle.Complete<ContentCatalogData>
	|-ProvideHandle.Complete<object>
	|-ProvideHandle.Complete<Sprite>
	*/
}

