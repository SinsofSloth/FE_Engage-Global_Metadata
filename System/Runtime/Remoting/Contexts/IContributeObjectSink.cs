// Namespace: System.Runtime.Remoting.Contexts
[ComVisibleAttribute] // RVA: 0x474D30 Offset: 0x474E31 VA: 0x474D30
public interface IContributeObjectSink // TypeDefIndex: 1145
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract IMessageSink GetObjectSink(MarshalByRefObject obj, IMessageSink nextSink);
}

