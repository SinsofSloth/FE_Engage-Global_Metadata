// Namespace: UnityEngine.AddressableAssets.Initialization
[Serializable]
public class ResourceManagerRuntimeData // TypeDefIndex: 7325
{
	// Fields
	public const string kCatalogAddress = "AddressablesMainContentCatalog";
	[SerializeField] // RVA: 0x65C80 Offset: 0x65D81 VA: 0x65C80
	private string m_buildTarget; // 0x10
	[FormerlySerializedAsAttribute] // RVA: 0x65C90 Offset: 0x65D91 VA: 0x65C90
	[SerializeField] // RVA: 0x65C90 Offset: 0x65D91 VA: 0x65C90
	private string m_SettingsHash; // 0x18
	[FormerlySerializedAsAttribute] // RVA: 0x65CE0 Offset: 0x65DE1 VA: 0x65CE0
	[SerializeField] // RVA: 0x65CE0 Offset: 0x65DE1 VA: 0x65CE0
	private List<ResourceLocationData> m_CatalogLocations; // 0x20
	[FormerlySerializedAsAttribute] // RVA: 0x65D30 Offset: 0x65E31 VA: 0x65D30
	[SerializeField] // RVA: 0x65D30 Offset: 0x65E31 VA: 0x65D30
	private bool m_ProfileEvents; // 0x28
	[FormerlySerializedAsAttribute] // RVA: 0x65D80 Offset: 0x65E81 VA: 0x65D80
	[SerializeField] // RVA: 0x65D80 Offset: 0x65E81 VA: 0x65D80
	private bool m_LogResourceManagerExceptions; // 0x29
	[FormerlySerializedAsAttribute] // RVA: 0x65DD0 Offset: 0x65ED1 VA: 0x65DD0
	[SerializeField] // RVA: 0x65DD0 Offset: 0x65ED1 VA: 0x65DD0
	private List<ObjectInitializationData> m_ExtraInitializationData; // 0x30
	[SerializeField] // RVA: 0x65E20 Offset: 0x65F21 VA: 0x65E20
	private bool m_DisableCatalogUpdateOnStart; // 0x38
	[SerializeField] // RVA: 0x65E30 Offset: 0x65F31 VA: 0x65E30
	private bool m_IsLocalCatalogInBundle; // 0x39
	[SerializeField] // RVA: 0x65E40 Offset: 0x65F41 VA: 0x65E40
	private SerializedType m_CertificateHandlerType; // 0x40
	[SerializeField] // RVA: 0x65E50 Offset: 0x65F51 VA: 0x65E50
	private string m_AddressablesVersion; // 0x60
	[SerializeField] // RVA: 0x65E60 Offset: 0x65F61 VA: 0x65E60
	private int m_maxConcurrentWebRequests; // 0x68
	[SerializeField] // RVA: 0x65E70 Offset: 0x65F71 VA: 0x65E70
	private int m_CatalogRequestsTimeout; // 0x6C

	// Properties
	public string BuildTarget { get; set; }
	public string SettingsHash { get; set; }
	public List<ResourceLocationData> CatalogLocations { get; }
	public bool ProfileEvents { get; set; }
	public bool LogResourceManagerExceptions { get; set; }
	public List<ObjectInitializationData> InitializationObjects { get; }
	public bool DisableCatalogUpdateOnStartup { get; set; }
	public bool IsLocalCatalogInBundle { get; set; }
	public Type CertificateHandlerType { get; set; }
	public string AddressablesVersion { get; set; }
	public int MaxConcurrentWebRequests { get; set; }
	public int CatalogRequestsTimeout { get; set; }

	// Methods

	// RVA: 0x309FB20 Offset: 0x309FC21 VA: 0x309FB20
	public string get_BuildTarget() { }

	// RVA: 0x309FB30 Offset: 0x309FC31 VA: 0x309FB30
	public void set_BuildTarget(string value) { }

	// RVA: 0x309FB40 Offset: 0x309FC41 VA: 0x309FB40
	public string get_SettingsHash() { }

	// RVA: 0x309FB50 Offset: 0x309FC51 VA: 0x309FB50
	public void set_SettingsHash(string value) { }

	// RVA: 0x309FB60 Offset: 0x309FC61 VA: 0x309FB60
	public List<ResourceLocationData> get_CatalogLocations() { }

	// RVA: 0x309FB70 Offset: 0x309FC71 VA: 0x309FB70
	public bool get_ProfileEvents() { }

	// RVA: 0x309FB80 Offset: 0x309FC81 VA: 0x309FB80
	public void set_ProfileEvents(bool value) { }

	// RVA: 0x309FB90 Offset: 0x309FC91 VA: 0x309FB90
	public bool get_LogResourceManagerExceptions() { }

	// RVA: 0x309FBA0 Offset: 0x309FCA1 VA: 0x309FBA0
	public void set_LogResourceManagerExceptions(bool value) { }

	// RVA: 0x309FBB0 Offset: 0x309FCB1 VA: 0x309FBB0
	public List<ObjectInitializationData> get_InitializationObjects() { }

	// RVA: 0x309FBC0 Offset: 0x309FCC1 VA: 0x309FBC0
	public bool get_DisableCatalogUpdateOnStartup() { }

	// RVA: 0x309FBD0 Offset: 0x309FCD1 VA: 0x309FBD0
	public void set_DisableCatalogUpdateOnStartup(bool value) { }

	// RVA: 0x309FBE0 Offset: 0x309FCE1 VA: 0x309FBE0
	public bool get_IsLocalCatalogInBundle() { }

	// RVA: 0x309FBF0 Offset: 0x309FCF1 VA: 0x309FBF0
	public void set_IsLocalCatalogInBundle(bool value) { }

	// RVA: 0x309B790 Offset: 0x309B891 VA: 0x309B790
	public Type get_CertificateHandlerType() { }

	// RVA: 0x309FC00 Offset: 0x309FD01 VA: 0x309FC00
	public void set_CertificateHandlerType(Type value) { }

	// RVA: 0x309FC10 Offset: 0x309FD11 VA: 0x309FC10
	public string get_AddressablesVersion() { }

	// RVA: 0x309FC20 Offset: 0x309FD21 VA: 0x309FC20
	public void set_AddressablesVersion(string value) { }

	// RVA: 0x309FC30 Offset: 0x309FD31 VA: 0x309FC30
	public int get_MaxConcurrentWebRequests() { }

	// RVA: 0x309FC40 Offset: 0x309FD41 VA: 0x309FC40
	public void set_MaxConcurrentWebRequests(int value) { }

	// RVA: 0x309FC80 Offset: 0x309FD81 VA: 0x309FC80
	public int get_CatalogRequestsTimeout() { }

	// RVA: 0x309FC90 Offset: 0x309FD91 VA: 0x309FC90
	public void set_CatalogRequestsTimeout(int value) { }

	// RVA: 0x309FCA0 Offset: 0x309FDA1 VA: 0x309FCA0
	public void .ctor() { }
}

