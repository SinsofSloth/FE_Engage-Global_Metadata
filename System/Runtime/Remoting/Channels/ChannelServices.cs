// Namespace: System.Runtime.Remoting.Channels
[ComVisibleAttribute] // RVA: 0x474DB0 Offset: 0x474EB1 VA: 0x474DB0
public sealed class ChannelServices // TypeDefIndex: 1149
{
	// Fields
	private static ArrayList registeredChannels; // 0x0
	private static ArrayList delayedClientChannels; // 0x8
	private static CrossContextChannel _crossContextSink; // 0x10
	internal static string CrossContextUrl; // 0x18
	private static IList oldStartModeTypes; // 0x20

	// Properties
	internal static CrossContextChannel CrossContextChannel { get; }

	// Methods

	// RVA: 0x339A9C0 Offset: 0x339AAC1 VA: 0x339A9C0
	internal static CrossContextChannel get_CrossContextChannel() { }

	// RVA: 0x339AA30 Offset: 0x339AB31 VA: 0x339AA30
	internal static IMessageSink CreateClientChannelSinkChain(string url, object remoteChannelData, out string objectUri) { }

	// RVA: 0x339B250 Offset: 0x339B351 VA: 0x339B250
	internal static IMessageSink CreateClientChannelSinkChain(IChannelSender sender, string url, object[] channelDataArray, out string objectUri) { }

	[ObsoleteAttribute] // RVA: 0x47D260 Offset: 0x47D361 VA: 0x47D260
	// RVA: 0x339B480 Offset: 0x339B581 VA: 0x339B480
	public static void RegisterChannel(IChannel chnl) { }

	// RVA: 0x339B4F0 Offset: 0x339B5F1 VA: 0x339B4F0
	public static void RegisterChannel(IChannel chnl, bool ensureSecurity) { }

	// RVA: 0x339BD60 Offset: 0x339BE61 VA: 0x339BD60
	internal static void RegisterChannelConfig(ChannelData channel) { }

	// RVA: 0x339CA80 Offset: 0x339CB81 VA: 0x339CA80
	private static object CreateProvider(ProviderData prov) { }

	// RVA: 0x339CEE0 Offset: 0x339CFE1 VA: 0x339CEE0
	public static IMessage SyncDispatchMessage(IMessage msg) { }

	// RVA: 0x339CFB0 Offset: 0x339D0B1 VA: 0x339CFB0
	private static ReturnMessage CheckIncomingMessage(IMessage msg) { }

	// RVA: 0x339D280 Offset: 0x339D381 VA: 0x339D280
	internal static IMessage CheckReturnMessage(IMessage callMsg, IMessage retMsg) { }

	// RVA: 0x339D480 Offset: 0x339D581 VA: 0x339D480
	private static bool IsLocalCall(IMessage callMsg) { }

	// RVA: 0x339A4B0 Offset: 0x339A5B1 VA: 0x339A4B0
	internal static object[] GetCurrentChannelInfo() { }

	// RVA: 0x339D490 Offset: 0x339D591 VA: 0x339D490
	private static void .cctor() { }
}

