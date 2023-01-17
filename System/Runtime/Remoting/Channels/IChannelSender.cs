// Namespace: System.Runtime.Remoting.Channels
[ComVisibleAttribute] // RVA: 0x474EA0 Offset: 0x474FA1 VA: 0x474EA0
public interface IChannelSender : IChannel // TypeDefIndex: 1159
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract IMessageSink CreateMessageSink(string url, object remoteChannelData, out string objectURI);
}

