// Namespace: UnityEngine.AddressableAssets.ResourceLocators
public class ResourceLocationMap : IResourceLocator // TypeDefIndex: 7315
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x65AD0 Offset: 0x65BD1 VA: 0x65AD0
	private string <LocatorId>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x65AE0 Offset: 0x65BE1 VA: 0x65AE0
	private Dictionary<object, IList<IResourceLocation>> <Locations>k__BackingField; // 0x18

	// Properties
	public string LocatorId { get; set; }
	public Dictionary<object, IList<IResourceLocation>> Locations { get; set; }
	public IEnumerable<object> Keys { get; }

	// Methods

	// RVA: 0x30979C0 Offset: 0x3097AC1 VA: 0x30979C0
	public void .ctor(string id, int capacity = 0) { }

	[CompilerGeneratedAttribute] // RVA: 0x66450 Offset: 0x66551 VA: 0x66450
	// RVA: 0x309F300 Offset: 0x309F401 VA: 0x309F300 Slot: 4
	public string get_LocatorId() { }

	[CompilerGeneratedAttribute] // RVA: 0x66460 Offset: 0x66561 VA: 0x66460
	// RVA: 0x309F310 Offset: 0x309F411 VA: 0x309F310
	private void set_LocatorId(string value) { }

	// RVA: 0x309B8A0 Offset: 0x309B9A1 VA: 0x309B8A0
	public void .ctor(string id, IList<ResourceLocationData> locations) { }

	[CompilerGeneratedAttribute] // RVA: 0x66470 Offset: 0x66571 VA: 0x66470
	// RVA: 0x309F480 Offset: 0x309F581 VA: 0x309F480
	public Dictionary<object, IList<IResourceLocation>> get_Locations() { }

	[CompilerGeneratedAttribute] // RVA: 0x66480 Offset: 0x66581 VA: 0x66480
	// RVA: 0x309F490 Offset: 0x309F591 VA: 0x309F490
	private void set_Locations(Dictionary<object, IList<IResourceLocation>> value) { }

	// RVA: 0x309F4A0 Offset: 0x309F5A1 VA: 0x309F4A0 Slot: 5
	public IEnumerable<object> get_Keys() { }

	// RVA: 0x309C290 Offset: 0x309C391 VA: 0x309C290 Slot: 6
	public bool Locate(object key, Type type, out IList<IResourceLocation> locations) { }

	// RVA: 0x309F320 Offset: 0x309F421 VA: 0x309F320
	public void Add(object key, IResourceLocation location) { }

	// RVA: 0x3097CF0 Offset: 0x3097DF1 VA: 0x3097CF0
	public void Add(object key, IList<IResourceLocation> locations) { }
}

