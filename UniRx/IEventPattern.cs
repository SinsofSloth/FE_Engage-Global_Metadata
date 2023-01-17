// Namespace: UniRx
public interface IEventPattern<TSender, TEventArgs> // TypeDefIndex: 6546
{
	// Properties
	public abstract TSender Sender { get; }
	public abstract TEventArgs EventArgs { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract TSender get_Sender();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IEventPattern<object, object>.get_Sender
	*/

	// RVA: -1 Offset: -1 Slot: 1
	public abstract TEventArgs get_EventArgs();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IEventPattern<object, object>.get_EventArgs
	*/
}

