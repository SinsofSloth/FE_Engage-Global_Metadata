// Namespace: System.Runtime.Remoting.Messaging
[ComVisibleAttribute] // RVA: 0x475200 Offset: 0x475301 VA: 0x475200
public interface IMessageSink // TypeDefIndex: 1204
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract IMessage SyncProcessMessage(IMessage msg);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink);
}

