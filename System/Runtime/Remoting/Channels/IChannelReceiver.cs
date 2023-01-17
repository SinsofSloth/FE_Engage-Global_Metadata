// Namespace: System.Runtime.Remoting.Channels
[ComVisibleAttribute] // RVA: 0x474E80 Offset: 0x474F81 VA: 0x474E80
public interface IChannelReceiver : IChannel // TypeDefIndex: 1158
{
	// Properties
	public abstract object ChannelData { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract object get_ChannelData();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void StartListening(object data);
}

