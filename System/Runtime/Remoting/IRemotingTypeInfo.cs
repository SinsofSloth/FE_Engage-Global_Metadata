// Namespace: System.Runtime.Remoting
[ComVisibleAttribute] // RVA: 0x4749D0 Offset: 0x474AD1 VA: 0x4749D0
public interface IRemotingTypeInfo // TypeDefIndex: 1094
{
	// Properties
	public abstract string TypeName { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract string get_TypeName();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool CanCastTo(Type fromType, object o);
}

