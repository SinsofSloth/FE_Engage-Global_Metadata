// Namespace: UnityEngine.AddressableAssets
internal class DynamicResourceLocator : IResourceLocator // TypeDefIndex: 7297
{
	// Fields
	private AddressablesImpl m_Addressables; // 0x10
	private string m_AtlasSpriteProviderId; // 0x18

	// Properties
	public string LocatorId { get; }
	public virtual IEnumerable<object> Keys { get; }
	private string AtlasSpriteProviderId { get; }

	// Methods

	// RVA: 0x30985C0 Offset: 0x30986C1 VA: 0x30985C0 Slot: 4
	public string get_LocatorId() { }

	// RVA: 0x3098610 Offset: 0x3098711 VA: 0x3098610 Slot: 7
	public virtual IEnumerable<object> get_Keys() { }

	// RVA: 0x3098660 Offset: 0x3098761 VA: 0x3098660
	private string get_AtlasSpriteProviderId() { }

	// RVA: 0x3098A60 Offset: 0x3098B61 VA: 0x3098A60
	public void .ctor(AddressablesImpl addr) { }

	// RVA: 0x3098AA0 Offset: 0x3098BA1 VA: 0x3098AA0 Slot: 6
	public bool Locate(object key, Type type, out IList<IResourceLocation> locations) { }

	// RVA: 0x30990B0 Offset: 0x30991B1 VA: 0x30990B0
	internal void CreateDynamicLocations(Type type, IList<IResourceLocation> locations, string locName, string subKey, IResourceLocation mainLoc) { }
}

