// Namespace: App
public class ResourceHandle : IDisposable // TypeDefIndex: 13913
{
	// Fields
	private string m_Path; // 0x10
	private AsyncOperationHandle m_Handle; // 0x18

	// Properties
	public string Path { get; }
	public string Name { get; }

	// Methods

	// RVA: 0x24CD370 Offset: 0x24CD471 VA: 0x24CD370
	public void .ctor() { }

	// RVA: 0x24CD650 Offset: 0x24CD751 VA: 0x24CD650 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x24CD6C0 Offset: 0x24CD7C1 VA: 0x24CD6C0
	public void Reset(string path) { }

	// RVA: 0x24CD6D0 Offset: 0x24CD7D1 VA: 0x24CD6D0
	public bool IsLoading() { }

	// RVA: 0x24CD200 Offset: 0x24CD301 VA: 0x24CD200 Slot: 4
	public void Dispose() { }

	// RVA: -1 Offset: -1
	public void LoadAsync<T>(string path, Action<T> completed) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2016D70 Offset: 0x2016E71 VA: 0x2016D70
	|-ResourceHandle.LoadAsync<AnimatorOverrideController>
	|-ResourceHandle.LoadAsync<Cubemap>
	|-ResourceHandle.LoadAsync<GameObject>
	|-ResourceHandle.LoadAsync<Material>
	|-ResourceHandle.LoadAsync<object>
	|-ResourceHandle.LoadAsync<Object>
	|-ResourceHandle.LoadAsync<PlayableAsset>
	|-ResourceHandle.LoadAsync<RenderTexture>
	|-ResourceHandle.LoadAsync<RuntimeAnimatorController>
	|-ResourceHandle.LoadAsync<Sprite>
	|-ResourceHandle.LoadAsync<SpriteAtlas>
	|-ResourceHandle.LoadAsync<TMP_SpriteAsset>
	|-ResourceHandle.LoadAsync<Texture2D>
	*/

	// RVA: 0x24CD800 Offset: 0x24CD901 VA: 0x24CD800
	public void LoadSceneAsync(string path, LoadSceneMode mode = 0) { }

	// RVA: 0x24CDD50 Offset: 0x24CDE51 VA: 0x24CDD50
	public void UnloadSceneAsync() { }

	// RVA: 0x24CD700 Offset: 0x24CD801 VA: 0x24CD700
	public void Release() { }

	// RVA: 0x24CE3A0 Offset: 0x24CE4A1 VA: 0x24CE3A0
	public string get_Path() { }

	// RVA: 0x24CE3B0 Offset: 0x24CE4B1 VA: 0x24CE3B0
	public string get_Name() { }

	// RVA: -1 Offset: -1
	public T GetAsset<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2016A90 Offset: 0x2016B91 VA: 0x2016A90
	|-ResourceHandle.GetAsset<GameObject>
	|-ResourceHandle.GetAsset<Material>
	|-ResourceHandle.GetAsset<object>
	|-ResourceHandle.GetAsset<Sprite>
	|-ResourceHandle.GetAsset<TMP_SpriteAsset>
	*/

	// RVA: -1 Offset: -1
	public T Instantiate<T>(GameObject parent) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2016B60 Offset: 0x2016C61 VA: 0x2016B60
	|-ResourceHandle.Instantiate<GameObject>
	|-ResourceHandle.Instantiate<object>
	*/

	// RVA: -1 Offset: -1
	public T Instantiate<T>(Transform parent) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2016C20 Offset: 0x2016D21 VA: 0x2016C20
	|-ResourceHandle.Instantiate<object>
	*/
}

