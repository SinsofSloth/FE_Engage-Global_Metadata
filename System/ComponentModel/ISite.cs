// Namespace: System.ComponentModel
[ComVisibleAttribute] // RVA: 0x30350 Offset: 0x30451 VA: 0x30350
public interface ISite : IServiceProvider // TypeDefIndex: 2317
{
	// Properties
	public abstract IContainer Container { get; }
	public abstract bool DesignMode { get; }
	public abstract string Name { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract IContainer get_Container();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool get_DesignMode();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract string get_Name();
}

