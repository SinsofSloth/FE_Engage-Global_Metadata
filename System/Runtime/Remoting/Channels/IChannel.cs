// Namespace: System.Runtime.Remoting.Channels
[ComVisibleAttribute] // RVA: 0x474E10 Offset: 0x474F11 VA: 0x474E10
public interface IChannel // TypeDefIndex: 1156
{
	// Properties
	public abstract string ChannelName { get; }
	public abstract int ChannelPriority { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract string get_ChannelName();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract int get_ChannelPriority();
}

