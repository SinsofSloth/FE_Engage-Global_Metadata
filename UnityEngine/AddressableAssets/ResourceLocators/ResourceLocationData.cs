// Namespace: UnityEngine.AddressableAssets.ResourceLocators
[Serializable]
public class ResourceLocationData // TypeDefIndex: 7314
{
	// Fields
	[FormerlySerializedAsAttribute] // RVA: 0x65970 Offset: 0x65A71 VA: 0x65970
	[SerializeField] // RVA: 0x65970 Offset: 0x65A71 VA: 0x65970
	private string[] m_Keys; // 0x10
	[FormerlySerializedAsAttribute] // RVA: 0x659C0 Offset: 0x65AC1 VA: 0x659C0
	[SerializeField] // RVA: 0x659C0 Offset: 0x65AC1 VA: 0x659C0
	private string m_InternalId; // 0x18
	[FormerlySerializedAsAttribute] // RVA: 0x65A10 Offset: 0x65B11 VA: 0x65A10
	[SerializeField] // RVA: 0x65A10 Offset: 0x65B11 VA: 0x65A10
	private string m_Provider; // 0x20
	[SerializeField] // RVA: 0x65A60 Offset: 0x65B61 VA: 0x65A60
	[FormerlySerializedAsAttribute] // RVA: 0x65A60 Offset: 0x65B61 VA: 0x65A60
	private string[] m_Dependencies; // 0x28
	[SerializeField] // RVA: 0x65AB0 Offset: 0x65BB1 VA: 0x65AB0
	private SerializedType m_ResourceType; // 0x30
	[SerializeField] // RVA: 0x65AC0 Offset: 0x65BC1 VA: 0x65AC0
	private byte[] SerializedData; // 0x50
	private object _Data; // 0x58

	// Properties
	public string[] Keys { get; }
	public string InternalId { get; }
	public string Provider { get; }
	public string[] Dependencies { get; }
	public Type ResourceType { get; }
	public object Data { get; set; }

	// Methods

	// RVA: 0x309E770 Offset: 0x309E871 VA: 0x309E770
	public string[] get_Keys() { }

	// RVA: 0x309E780 Offset: 0x309E881 VA: 0x309E780
	public string get_InternalId() { }

	// RVA: 0x309E790 Offset: 0x309E891 VA: 0x309E790
	public string get_Provider() { }

	// RVA: 0x309E7A0 Offset: 0x309E8A1 VA: 0x309E7A0
	public string[] get_Dependencies() { }

	// RVA: 0x309E7B0 Offset: 0x309E8B1 VA: 0x309E7B0
	public Type get_ResourceType() { }

	// RVA: 0x309B720 Offset: 0x309B821 VA: 0x309B720
	public object get_Data() { }

	// RVA: 0x309E7C0 Offset: 0x309E8C1 VA: 0x309E7C0
	public void set_Data(object value) { }

	// RVA: 0x309F160 Offset: 0x309F261 VA: 0x309F160
	public void .ctor(string[] keys, string id, Type provider, Type t, string[] dependencies) { }
}

