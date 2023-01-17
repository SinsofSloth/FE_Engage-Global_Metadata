// Namespace: UnityEngine.AddressableAssets
[Serializable]
public class AssetReference : IKeyEvaluator // TypeDefIndex: 7291
{
	// Fields
	[FormerlySerializedAsAttribute] // RVA: 0x65650 Offset: 0x65751 VA: 0x65650
	[SerializeField] // RVA: 0x65650 Offset: 0x65751 VA: 0x65650
	private string m_AssetGUID; // 0x10
	[SerializeField] // RVA: 0x656A0 Offset: 0x657A1 VA: 0x656A0
	private string m_SubObjectName; // 0x18
	[SerializeField] // RVA: 0x656B0 Offset: 0x657B1 VA: 0x656B0
	private string m_SubObjectType; // 0x20
	private AsyncOperationHandle m_Operation; // 0x28

	// Properties
	public AsyncOperationHandle OperationHandle { get; }
	public virtual object RuntimeKey { get; }
	public virtual string AssetGUID { get; }
	public virtual string SubObjectName { get; set; }
	internal virtual Type SubOjbectType { get; }
	public bool IsDone { get; }
	public virtual Object Asset { get; }

	// Methods

	// RVA: 0x3094C90 Offset: 0x3094D91 VA: 0x3094C90
	public AsyncOperationHandle get_OperationHandle() { }

	// RVA: 0x3094CB0 Offset: 0x3094DB1 VA: 0x3094CB0 Slot: 6
	public virtual object get_RuntimeKey() { }

	// RVA: 0x3094D60 Offset: 0x3094E61 VA: 0x3094D60 Slot: 7
	public virtual string get_AssetGUID() { }

	// RVA: 0x3094D70 Offset: 0x3094E71 VA: 0x3094D70 Slot: 8
	public virtual string get_SubObjectName() { }

	// RVA: 0x3094D80 Offset: 0x3094E81 VA: 0x3094D80 Slot: 9
	public virtual void set_SubObjectName(string value) { }

	// RVA: 0x3094D90 Offset: 0x3094E91 VA: 0x3094D90 Slot: 10
	internal virtual Type get_SubOjbectType() { }

	// RVA: 0x3094E50 Offset: 0x3094F51 VA: 0x3094E50
	public bool IsValid() { }

	// RVA: 0x3094E60 Offset: 0x3094F61 VA: 0x3094E60
	public bool get_IsDone() { }

	// RVA: 0x3094E70 Offset: 0x3094F71 VA: 0x3094E70
	public void .ctor() { }

	// RVA: 0x3094EE0 Offset: 0x3094FE1 VA: 0x3094EE0
	public void .ctor(string guid) { }

	// RVA: 0x3094F60 Offset: 0x3095061 VA: 0x3094F60 Slot: 11
	public virtual Object get_Asset() { }

	// RVA: 0x3095010 Offset: 0x3095111 VA: 0x3095010 Slot: 3
	public override string ToString() { }

	// RVA: -1 Offset: -1
	private static AsyncOperationHandle<T> CreateFailedOperation<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2734D10 Offset: 0x2734E11 VA: 0x2734D10
	|-AssetReference.CreateFailedOperation<object>
	*/

	[ObsoleteAttribute] // RVA: 0x662D0 Offset: 0x663D1 VA: 0x662D0
	// RVA: -1 Offset: -1
	public AsyncOperationHandle<TObject> LoadAsset<TObject>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2734E20 Offset: 0x2734F21 VA: 0x2734E20
	|-AssetReference.LoadAsset<object>
	*/

	[ObsoleteAttribute] // RVA: 0x662E0 Offset: 0x663E1 VA: 0x662E0
	// RVA: 0x3095080 Offset: 0x3095181 VA: 0x3095080
	public AsyncOperationHandle<SceneInstance> LoadScene() { }

	[ObsoleteAttribute] // RVA: 0x662F0 Offset: 0x663F1 VA: 0x662F0
	// RVA: 0x30950E0 Offset: 0x30951E1 VA: 0x30950E0
	public AsyncOperationHandle<GameObject> Instantiate(Vector3 position, Quaternion rotation, Transform parent) { }

	[ObsoleteAttribute] // RVA: 0x66300 Offset: 0x66401 VA: 0x66300
	// RVA: 0x3095130 Offset: 0x3095231 VA: 0x3095130
	public AsyncOperationHandle<GameObject> Instantiate(Transform parent, bool instantiateInWorldSpace = False) { }

	// RVA: -1 Offset: -1 Slot: 12
	public virtual AsyncOperationHandle<TObject> LoadAssetAsync<TObject>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2734E90 Offset: 0x2734F91 VA: 0x2734E90
	|-AssetReference.LoadAssetAsync<object>
	*/

	// RVA: 0x3095180 Offset: 0x3095281 VA: 0x3095180 Slot: 13
	public virtual AsyncOperationHandle<SceneInstance> LoadSceneAsync(LoadSceneMode loadMode = 0, bool activateOnLoad = True, int priority = 100) { }

	// RVA: 0x3095310 Offset: 0x3095411 VA: 0x3095310 Slot: 14
	public virtual AsyncOperationHandle<SceneInstance> UnLoadScene() { }

	// RVA: 0x30953C0 Offset: 0x30954C1 VA: 0x30953C0 Slot: 15
	public virtual AsyncOperationHandle<GameObject> InstantiateAsync(Vector3 position, Quaternion rotation, Transform parent) { }

	// RVA: 0x30954D0 Offset: 0x30955D1 VA: 0x30954D0 Slot: 16
	public virtual AsyncOperationHandle<GameObject> InstantiateAsync(Transform parent, bool instantiateInWorldSpace = False) { }

	// RVA: 0x3095590 Offset: 0x3095691 VA: 0x3095590 Slot: 17
	public virtual bool RuntimeKeyIsValid() { }

	// RVA: 0x3095680 Offset: 0x3095781 VA: 0x3095680 Slot: 18
	public virtual void ReleaseAsset() { }

	// RVA: 0x3095780 Offset: 0x3095881 VA: 0x3095780 Slot: 19
	public virtual void ReleaseInstance(GameObject obj) { }

	// RVA: 0x30957F0 Offset: 0x30958F1 VA: 0x30957F0 Slot: 20
	public virtual bool ValidateAsset(Object obj) { }

	// RVA: 0x3095800 Offset: 0x3095901 VA: 0x3095800 Slot: 21
	public virtual bool ValidateAsset(string path) { }
}

