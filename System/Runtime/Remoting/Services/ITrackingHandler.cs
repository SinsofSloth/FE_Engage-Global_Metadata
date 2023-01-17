// Namespace: System.Runtime.Remoting.Services
[ComVisibleAttribute] // RVA: 0x474B30 Offset: 0x474C31 VA: 0x474B30
public interface ITrackingHandler // TypeDefIndex: 1119
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void DisconnectedObject(object obj);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void MarshaledObject(object obj, ObjRef or);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void UnmarshaledObject(object obj, ObjRef or);
}

