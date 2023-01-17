// Namespace: System.Runtime.Remoting.Activation
[Serializable]
internal class ContextLevelActivator : IActivator // TypeDefIndex: 1167
{
	// Fields
	private IActivator m_NextActivator; // 0x10

	// Properties
	public IActivator NextActivator { get; }

	// Methods

	// RVA: 0x33B41C0 Offset: 0x33B42C1 VA: 0x33B41C0
	public void .ctor(IActivator next) { }

	// RVA: 0x33B4200 Offset: 0x33B4301 VA: 0x33B4200 Slot: 4
	public IActivator get_NextActivator() { }

	// RVA: 0x33B4210 Offset: 0x33B4311 VA: 0x33B4210 Slot: 5
	public IConstructionReturnMessage Activate(IConstructionCallMessage ctorCall) { }
}

