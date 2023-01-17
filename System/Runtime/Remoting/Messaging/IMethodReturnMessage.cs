// Namespace: System.Runtime.Remoting.Messaging
[ComVisibleAttribute] // RVA: 0x475260 Offset: 0x475361 VA: 0x475260
public interface IMethodReturnMessage : IMethodMessage, IMessage // TypeDefIndex: 1207
{
	// Properties
	public abstract Exception Exception { get; }
	public abstract object[] OutArgs { get; }
	public abstract object ReturnValue { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract Exception get_Exception();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract object[] get_OutArgs();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract object get_ReturnValue();
}

