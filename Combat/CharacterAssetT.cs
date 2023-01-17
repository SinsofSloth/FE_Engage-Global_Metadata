// Namespace: Combat
[DebuggerDisplayAttribute] // RVA: 0x273C70 Offset: 0x273D71 VA: 0x273C70
public class CharacterAssetT<T> : IDisposable // TypeDefIndex: 8585
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x2821D0 Offset: 0x2822D1 VA: 0x2821D0
	private AssetType <AssetType>k__BackingField; // 0x0
	public static int TotalAllocCount; // 0x0
	[FormerlySerializedAsAttribute] // RVA: 0x2821E0 Offset: 0x2822E1 VA: 0x2821E0
	[SerializeField] // RVA: 0x2821E0 Offset: 0x2822E1 VA: 0x2821E0
	private string name; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x282230 Offset: 0x282331 VA: 0x282230
	private string <m_AddrPath>k__BackingField; // 0x0
	private TResourceHandle<T> m_FileHandle; // 0x0
	private T m_Object; // 0x0
	private T m_InstancedObject; // 0x0

	// Properties
	public string DebuggerDisplay { get; }
	public AssetType AssetType { get; set; }
	public string Name { get; set; }
	protected string m_AddrPath { get; set; }
	public string AddressablesPath { get; }
	public T Asset { get; }
	public T Instanced { get; }
	public GameObject InstanceAsGo { get; }
	public bool IsLoadable { get; }

	// Methods

	// RVA: -1 Offset: -1
	public string get_DebuggerDisplay() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30D7DD0 Offset: 0x30D7ED1 VA: 0x30D7DD0
	|-CharacterAssetT<object>.get_DebuggerDisplay
	|-CharacterAssetT<Object>.get_DebuggerDisplay
	*/

	// RVA: -1 Offset: -1
	public static bool op_Implicit(CharacterAssetT<T> a) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30D81C0 Offset: 0x30D82C1 VA: 0x30D81C0
	|-CharacterAssetT<AnimationClip>.op_Implicit
	|-CharacterAssetT<object>.op_Implicit
	|-CharacterAssetT<Object>.op_Implicit
	*/

	[CompilerGeneratedAttribute] // RVA: 0x2AA330 Offset: 0x2AA431 VA: 0x2AA330
	// RVA: -1 Offset: -1
	public AssetType get_AssetType() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30D81D0 Offset: 0x30D82D1 VA: 0x30D81D0
	|-CharacterAssetT<object>.get_AssetType
	|-CharacterAssetT<Object>.get_AssetType
	*/

	[CompilerGeneratedAttribute] // RVA: 0x2AA340 Offset: 0x2AA441 VA: 0x2AA340
	// RVA: -1 Offset: -1
	private void set_AssetType(AssetType value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30D81E0 Offset: 0x30D82E1 VA: 0x30D81E0
	|-CharacterAssetT<object>.set_AssetType
	*/

	// RVA: -1 Offset: -1
	public string get_Name() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30D81F0 Offset: 0x30D82F1 VA: 0x30D81F0
	|-CharacterAssetT<AnimationClip>.get_Name
	|-CharacterAssetT<object>.get_Name
	|-CharacterAssetT<Object>.get_Name
	*/

	// RVA: -1 Offset: -1
	public void set_Name(string value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30D8200 Offset: 0x30D8301 VA: 0x30D8200
	|-CharacterAssetT<AnimationClip>.set_Name
	|-CharacterAssetT<object>.set_Name
	|-CharacterAssetT<Object>.set_Name
	*/

	[CompilerGeneratedAttribute] // RVA: 0x2AA350 Offset: 0x2AA451 VA: 0x2AA350
	// RVA: -1 Offset: -1
	protected string get_m_AddrPath() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30D8240 Offset: 0x30D8341 VA: 0x30D8240
	|-CharacterAssetT<object>.get_m_AddrPath
	*/

	[CompilerGeneratedAttribute] // RVA: 0x2AA360 Offset: 0x2AA461 VA: 0x2AA360
	// RVA: -1 Offset: -1
	protected void set_m_AddrPath(string value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30D8250 Offset: 0x30D8351 VA: 0x30D8250
	|-CharacterAssetT<object>.set_m_AddrPath
	|-CharacterAssetT<Object>.set_m_AddrPath
	*/

	// RVA: -1 Offset: -1
	public string get_AddressablesPath() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30D8260 Offset: 0x30D8361 VA: 0x30D8260
	|-CharacterAssetT<object>.get_AddressablesPath
	|-CharacterAssetT<Object>.get_AddressablesPath
	*/

	// RVA: -1 Offset: -1
	public T get_Asset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30D8380 Offset: 0x30D8481 VA: 0x30D8380
	|-CharacterAssetT<AnimationClip>.get_Asset
	|-CharacterAssetT<object>.get_Asset
	|-CharacterAssetT<Object>.get_Asset
	*/

	// RVA: -1 Offset: -1
	public T get_Instanced() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30D8440 Offset: 0x30D8541 VA: 0x30D8440
	|-CharacterAssetT<object>.get_Instanced
	*/

	// RVA: -1 Offset: -1
	public T Instantiate(Transform parent) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30D85E0 Offset: 0x30D86E1 VA: 0x30D85E0
	|-CharacterAssetT<object>.Instantiate
	|-CharacterAssetT<Object>.Instantiate
	*/

	// RVA: -1 Offset: -1
	public bool IsReady() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30D8780 Offset: 0x30D8881 VA: 0x30D8780
	|-CharacterAssetT<AnimationClip>.IsReady
	|-CharacterAssetT<object>.IsReady
	|-CharacterAssetT<Object>.IsReady
	*/

	// RVA: -1 Offset: -1
	public bool IsLoading() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30D8810 Offset: 0x30D8911 VA: 0x30D8810
	|-CharacterAssetT<AnimationClip>.IsLoading
	|-CharacterAssetT<object>.IsLoading
	|-CharacterAssetT<Object>.IsLoading
	*/

	// RVA: -1 Offset: -1
	public GameObject get_InstanceAsGo() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30D8880 Offset: 0x30D8981 VA: 0x30D8880
	|-CharacterAssetT<object>.get_InstanceAsGo
	|-CharacterAssetT<Object>.get_InstanceAsGo
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30D88F0 Offset: 0x30D89F1 VA: 0x30D88F0
	|-CharacterAssetT<AnimationClip>..ctor
	|-CharacterAssetT<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(AssetType assetType) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30D8900 Offset: 0x30D8A01 VA: 0x30D8900
	|-CharacterAssetT<object>..ctor
	|-CharacterAssetT<Object>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(CharacterAssetT<T> rhs) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30D8950 Offset: 0x30D8A51 VA: 0x30D8950
	|-CharacterAssetT<object>..ctor
	|-CharacterAssetT<Object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 1
	protected override void Finalize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30D8A60 Offset: 0x30D8B61 VA: 0x30D8A60
	|-CharacterAssetT<AnimationClip>.Finalize
	|-CharacterAssetT<object>.Finalize
	|-CharacterAssetT<Object>.Finalize
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30D8AE0 Offset: 0x30D8BE1 VA: 0x30D8AE0
	|-CharacterAssetT<AnimationClip>.Dispose
	|-CharacterAssetT<object>.Dispose
	|-CharacterAssetT<Object>.Dispose
	*/

	// RVA: -1 Offset: -1
	public bool get_IsLoadable() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30D8C50 Offset: 0x30D8D51 VA: 0x30D8C50
	|-CharacterAssetT<object>.get_IsLoadable
	|-CharacterAssetT<Object>.get_IsLoadable
	*/

	// RVA: -1 Offset: -1
	public void LoadAsync(Action callback) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30D8D90 Offset: 0x30D8E91 VA: 0x30D8D90
	|-CharacterAssetT<AnimationClip>.LoadAsync
	|-CharacterAssetT<object>.LoadAsync
	|-CharacterAssetT<Object>.LoadAsync
	*/

	// RVA: -1 Offset: -1
	public bool FileExists() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30D9040 Offset: 0x30D9141 VA: 0x30D9040
	|-CharacterAssetT<AnimationClip>.FileExists
	|-CharacterAssetT<object>.FileExists
	|-CharacterAssetT<Object>.FileExists
	*/

	// RVA: -1 Offset: -1
	public void LoadForEditor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30D9170 Offset: 0x30D9271 VA: 0x30D9170
	|-CharacterAssetT<object>.LoadForEditor
	*/

	// RVA: -1 Offset: -1
	public void Replace(string name, T asset) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30D9180 Offset: 0x30D9281 VA: 0x30D9180
	|-CharacterAssetT<object>.Replace
	|-CharacterAssetT<Object>.Replace
	*/
}

