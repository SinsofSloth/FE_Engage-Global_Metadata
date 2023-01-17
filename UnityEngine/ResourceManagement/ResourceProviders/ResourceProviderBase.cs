// Namespace: UnityEngine.ResourceManagement.ResourceProviders
public abstract class ResourceProviderBase : IResourceProvider, IInitializableObject // TypeDefIndex: 5596
{
	// Fields
	protected string m_ProviderId; // 0x10
	protected ProviderBehaviourFlags m_BehaviourFlags; // 0x18

	// Properties
	public virtual string ProviderId { get; }
	private ProviderBehaviourFlags UnityEngine.ResourceManagement.ResourceProviders.IResourceProvider.BehaviourFlags { get; }

	// Methods

	// RVA: 0x3635CB0 Offset: 0x3635DB1 VA: 0x3635CB0 Slot: 12
	public virtual string get_ProviderId() { }

	// RVA: 0x3635D10 Offset: 0x3635E11 VA: 0x3635D10 Slot: 13
	public virtual bool Initialize(string id, string data) { }

	// RVA: 0x3635D50 Offset: 0x3635E51 VA: 0x3635D50 Slot: 14
	public virtual bool CanProvide(Type t, IResourceLocation location) { }

	// RVA: 0x3635DA0 Offset: 0x3635EA1 VA: 0x3635DA0 Slot: 3
	public override string ToString() { }

	// RVA: 0x3635DB0 Offset: 0x3635EB1 VA: 0x3635DB0 Slot: 15
	public virtual void Release(IResourceLocation location, object obj) { }

	// RVA: 0x3635DC0 Offset: 0x3635EC1 VA: 0x3635DC0 Slot: 16
	public virtual Type GetDefaultType(IResourceLocation location) { }

	// RVA: -1 Offset: -1 Slot: 17
	public abstract void Provide(ProvideHandle provideHandle);

	// RVA: 0x3635E40 Offset: 0x3635F41 VA: 0x3635E40 Slot: 18
	public virtual AsyncOperationHandle<bool> InitializeAsync(ResourceManager rm, string id, string data) { }

	// RVA: 0x3636070 Offset: 0x3636171 VA: 0x3636070 Slot: 9
	private ProviderBehaviourFlags UnityEngine.ResourceManagement.ResourceProviders.IResourceProvider.get_BehaviourFlags() { }

	// RVA: 0x3623D70 Offset: 0x3623E71 VA: 0x3623D70
	protected void .ctor() { }
}

