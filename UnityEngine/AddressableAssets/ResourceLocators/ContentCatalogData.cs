// Namespace: UnityEngine.AddressableAssets.ResourceLocators
[Serializable]
public class ContentCatalogData // TypeDefIndex: 7311
{
	// Fields
	internal string localHash; // 0x10
	internal IResourceLocation location; // 0x18
	[SerializeField] // RVA: 0x65730 Offset: 0x65831 VA: 0x65730
	internal string m_LocatorId; // 0x20
	[SerializeField] // RVA: 0x65740 Offset: 0x65841 VA: 0x65740
	private ObjectInitializationData m_InstanceProviderData; // 0x28
	[SerializeField] // RVA: 0x65750 Offset: 0x65851 VA: 0x65750
	private ObjectInitializationData m_SceneProviderData; // 0x58
	[SerializeField] // RVA: 0x65760 Offset: 0x65861 VA: 0x65760
	internal List<ObjectInitializationData> m_ResourceProviderData; // 0x88
	[SerializeField] // RVA: 0x65770 Offset: 0x65871 VA: 0x65770
	[FormerlySerializedAsAttribute] // RVA: 0x65770 Offset: 0x65871 VA: 0x65770
	internal string[] m_ProviderIds; // 0x90
	[FormerlySerializedAsAttribute] // RVA: 0x657C0 Offset: 0x658C1 VA: 0x657C0
	[SerializeField] // RVA: 0x657C0 Offset: 0x658C1 VA: 0x657C0
	internal string[] m_InternalIds; // 0x98
	[FormerlySerializedAsAttribute] // RVA: 0x65810 Offset: 0x65911 VA: 0x65810
	[SerializeField] // RVA: 0x65810 Offset: 0x65911 VA: 0x65810
	internal string m_KeyDataString; // 0xA0
	[FormerlySerializedAsAttribute] // RVA: 0x65860 Offset: 0x65961 VA: 0x65860
	[SerializeField] // RVA: 0x65860 Offset: 0x65961 VA: 0x65860
	internal string m_BucketDataString; // 0xA8
	[FormerlySerializedAsAttribute] // RVA: 0x658B0 Offset: 0x659B1 VA: 0x658B0
	[SerializeField] // RVA: 0x658B0 Offset: 0x659B1 VA: 0x658B0
	internal string m_EntryDataString; // 0xB0
	private const int kBytesPerInt32 = 4;
	private const int k_EntryDataItemPerEntry = 7;
	[FormerlySerializedAsAttribute] // RVA: 0x65900 Offset: 0x65A01 VA: 0x65900
	[SerializeField] // RVA: 0x65900 Offset: 0x65A01 VA: 0x65900
	internal string m_ExtraDataString; // 0xB8
	[SerializeField] // RVA: 0x65950 Offset: 0x65A51 VA: 0x65950
	internal SerializedType[] m_resourceTypes; // 0xC0
	[SerializeField] // RVA: 0x65960 Offset: 0x65A61 VA: 0x65960
	private string[] m_InternalIdPrefixes; // 0xC8

	// Properties
	public string ProviderId { get; set; }
	public ObjectInitializationData InstanceProviderData { get; set; }
	public ObjectInitializationData SceneProviderData { get; set; }
	public List<ObjectInitializationData> ResourceProviderData { get; set; }
	public string[] ProviderIds { get; }
	public string[] InternalIds { get; }

	// Methods

	// RVA: 0x3096930 Offset: 0x3096A31 VA: 0x3096930
	public string get_ProviderId() { }

	// RVA: 0x3096940 Offset: 0x3096A41 VA: 0x3096940
	internal void set_ProviderId(string value) { }

	// RVA: 0x3096950 Offset: 0x3096A51 VA: 0x3096950
	public ObjectInitializationData get_InstanceProviderData() { }

	// RVA: 0x3096970 Offset: 0x3096A71 VA: 0x3096970
	public void set_InstanceProviderData(ObjectInitializationData value) { }

	// RVA: 0x30969A0 Offset: 0x3096AA1 VA: 0x30969A0
	public ObjectInitializationData get_SceneProviderData() { }

	// RVA: 0x30969C0 Offset: 0x3096AC1 VA: 0x30969C0
	public void set_SceneProviderData(ObjectInitializationData value) { }

	// RVA: 0x30969F0 Offset: 0x3096AF1 VA: 0x30969F0
	public List<ObjectInitializationData> get_ResourceProviderData() { }

	// RVA: 0x3096A00 Offset: 0x3096B01 VA: 0x3096A00
	public void set_ResourceProviderData(List<ObjectInitializationData> value) { }

	// RVA: 0x3096A10 Offset: 0x3096B11 VA: 0x3096A10
	public string[] get_ProviderIds() { }

	// RVA: 0x3096A20 Offset: 0x3096B21 VA: 0x3096A20
	public string[] get_InternalIds() { }

	// RVA: 0x3096A30 Offset: 0x3096B31 VA: 0x3096A30
	internal void CleanData() { }

	// RVA: 0x3096B10 Offset: 0x3096C11 VA: 0x3096B10
	internal ResourceLocationMap CreateCustomLocator(string overrideId, string providerSuffix) { }

	// RVA: 0x3096B40 Offset: 0x3096C41 VA: 0x3096B40
	public ResourceLocationMap CreateLocator(string providerSuffix) { }

	// RVA: 0x3097A80 Offset: 0x3097B81 VA: 0x3097A80
	internal static string ExpandInternalId(string[] internalIdPrefixes, string v) { }

	// RVA: 0x3097D60 Offset: 0x3097E61 VA: 0x3097D60
	public void .ctor() { }
}

