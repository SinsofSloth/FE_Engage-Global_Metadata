// Namespace: System.Runtime.Remoting.Channels
[Serializable]
internal class CrossAppDomainChannel : IChannel, IChannelSender, IChannelReceiver // TypeDefIndex: 1151
{
	// Fields
	private static object s_lock; // 0x0

	// Properties
	public virtual string ChannelName { get; }
	public virtual int ChannelPriority { get; }
	public virtual object ChannelData { get; }

	// Methods

	// RVA: 0x37D5AE0 Offset: 0x37D5BE1 VA: 0x37D5AE0
	internal static void RegisterCrossAppDomainChannel() { }

	// RVA: 0x37D5C50 Offset: 0x37D5D51 VA: 0x37D5C50 Slot: 9
	public virtual string get_ChannelName() { }

	// RVA: 0x37D5CA0 Offset: 0x37D5DA1 VA: 0x37D5CA0 Slot: 10
	public virtual int get_ChannelPriority() { }

	// RVA: 0x37D5CB0 Offset: 0x37D5DB1 VA: 0x37D5CB0 Slot: 11
	public virtual object get_ChannelData() { }

	// RVA: 0x37D5DF0 Offset: 0x37D5EF1 VA: 0x37D5DF0 Slot: 12
	public virtual void StartListening(object data) { }

	// RVA: 0x37D5E00 Offset: 0x37D5F01 VA: 0x37D5E00 Slot: 13
	public virtual IMessageSink CreateMessageSink(string url, object data, out string uri) { }

	// RVA: 0x37D5C40 Offset: 0x37D5D41 VA: 0x37D5C40
	public void .ctor() { }

	// RVA: 0x37D6250 Offset: 0x37D6351 VA: 0x37D6250
	private static void .cctor() { }
}

