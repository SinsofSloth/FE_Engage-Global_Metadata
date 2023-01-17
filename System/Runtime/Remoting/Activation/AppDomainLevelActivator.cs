// Namespace: System.Runtime.Remoting.Activation
internal class AppDomainLevelActivator : IActivator // TypeDefIndex: 1165
{
	// Fields
	private string _activationUrl; // 0x10
	private IActivator _next; // 0x18

	// Properties
	public IActivator NextActivator { get; }

	// Methods

	// RVA: 0x355ABD0 Offset: 0x355ACD1 VA: 0x355ABD0
	public void .ctor(string activationUrl, IActivator next) { }

	// RVA: 0x355E650 Offset: 0x355E751 VA: 0x355E650 Slot: 4
	public IActivator get_NextActivator() { }

	// RVA: 0x355E660 Offset: 0x355E761 VA: 0x355E660 Slot: 5
	public IConstructionReturnMessage Activate(IConstructionCallMessage ctorCall) { }
}

