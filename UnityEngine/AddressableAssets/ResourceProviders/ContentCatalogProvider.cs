// Namespace: UnityEngine.AddressableAssets.ResourceProviders
[DisplayNameAttribute] // RVA: 0x65510 Offset: 0x65611 VA: 0x65510
public class ContentCatalogProvider : ResourceProviderBase // TypeDefIndex: 7307
{
	// Fields
	public bool DisableCatalogUpdateOnStart; // 0x1C
	public bool IsLocalCatalogInBundle; // 0x1D
	internal Dictionary<IResourceLocation, ContentCatalogProvider.InternalOp> m_LocationToCatalogLoadOpMap; // 0x20
	private ResourceManager m_RM; // 0x28

	// Methods

	// RVA: 0x3098010 Offset: 0x3098111 VA: 0x3098010
	public void .ctor(ResourceManager resourceManagerInstance) { }

	// RVA: 0x30980D0 Offset: 0x30981D1 VA: 0x30980D0 Slot: 15
	public override void Release(IResourceLocation location, object obj) { }

	// RVA: 0x30981C0 Offset: 0x30982C1 VA: 0x30981C0 Slot: 17
	public override void Provide(ProvideHandle providerInterface) { }
}

