// Namespace: UnityEngine.ResourceManagement.Util
[Serializable]
public struct ObjectInitializationData // TypeDefIndex: 5571
{
	// Fields
	[SerializeField] // RVA: 0x726D0 Offset: 0x727D1 VA: 0x726D0
	[FormerlySerializedAsAttribute] // RVA: 0x726D0 Offset: 0x727D1 VA: 0x726D0
	private string m_Id; // 0x0
	[SerializeField] // RVA: 0x72720 Offset: 0x72821 VA: 0x72720
	[FormerlySerializedAsAttribute] // RVA: 0x72720 Offset: 0x72821 VA: 0x72720
	private SerializedType m_ObjectType; // 0x8
	[FormerlySerializedAsAttribute] // RVA: 0x72770 Offset: 0x72871 VA: 0x72770
	[SerializeField] // RVA: 0x72770 Offset: 0x72871 VA: 0x72770
	private string m_Data; // 0x28

	// Properties
	public string Id { get; }
	public SerializedType ObjectType { get; }
	public string Data { get; }

	// Methods

	// RVA: 0x3630260 Offset: 0x3630361 VA: 0x3630260
	public string get_Id() { }

	// RVA: 0x3630270 Offset: 0x3630371 VA: 0x3630270
	public SerializedType get_ObjectType() { }

	// RVA: 0x3630290 Offset: 0x3630391 VA: 0x3630290
	public string get_Data() { }

	// RVA: 0x36302A0 Offset: 0x36303A1 VA: 0x36302A0 Slot: 3
	public override string ToString() { }

	// RVA: -1 Offset: -1
	public TObject CreateInstance<TObject>(string idOverride) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x296A4D0 Offset: 0x296A5D1 VA: 0x296A4D0
	|-ObjectInitializationData.CreateInstance<IInstanceProvider>
	|-ObjectInitializationData.CreateInstance<IResourceProvider>
	|-ObjectInitializationData.CreateInstance<ISceneProvider>
	|-ObjectInitializationData.CreateInstance<object>
	*/

	// RVA: 0x3630340 Offset: 0x3630441 VA: 0x3630340
	public AsyncOperationHandle GetAsyncInitHandle(ResourceManager rm, string idOverride) { }
}

