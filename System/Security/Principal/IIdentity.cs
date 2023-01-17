// Namespace: System.Security.Principal
[ComVisibleAttribute] // RVA: 0x473B10 Offset: 0x473C11 VA: 0x473B10
public interface IIdentity // TypeDefIndex: 891
{
	// Properties
	public abstract string AuthenticationType { get; }
	public abstract string Name { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract string get_AuthenticationType();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract string get_Name();
}

