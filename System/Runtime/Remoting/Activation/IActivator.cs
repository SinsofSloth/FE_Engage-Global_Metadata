// Namespace: System.Runtime.Remoting.Activation
[ComVisibleAttribute] // RVA: 0x474F20 Offset: 0x475021 VA: 0x474F20
public interface IActivator // TypeDefIndex: 1168
{
	// Properties
	public abstract IActivator NextActivator { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract IActivator get_NextActivator();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract IConstructionReturnMessage Activate(IConstructionCallMessage msg);
}

