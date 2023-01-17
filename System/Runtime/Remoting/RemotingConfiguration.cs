// Namespace: System.Runtime.Remoting
[ComVisibleAttribute] // RVA: 0x474A30 Offset: 0x474B31 VA: 0x474A30
public static class RemotingConfiguration // TypeDefIndex: 1099
{
	// Fields
	private static string applicationID; // 0x0
	private static string applicationName; // 0x8
	private static string processGuid; // 0x10
	private static bool defaultConfigRead; // 0x18
	private static bool defaultDelayedConfigRead; // 0x19
	private static string _errorMode; // 0x20
	private static Hashtable wellKnownClientEntries; // 0x28
	private static Hashtable activatedClientEntries; // 0x30
	private static Hashtable wellKnownServiceEntries; // 0x38
	private static Hashtable activatedServiceEntries; // 0x40
	private static Hashtable channelTemplates; // 0x48
	private static Hashtable clientProviderTemplates; // 0x50
	private static Hashtable serverProviderTemplates; // 0x58

	// Properties
	public static string ApplicationName { get; set; }
	public static string ProcessId { get; }

	// Methods

	// RVA: 0x3B76470 Offset: 0x3B76571 VA: 0x3B76470
	public static string get_ApplicationName() { }

	// RVA: 0x3B764E0 Offset: 0x3B765E1 VA: 0x3B764E0
	public static void set_ApplicationName(string value) { }

	// RVA: 0x3B76560 Offset: 0x3B76661 VA: 0x3B76560
	public static string get_ProcessId() { }

	// RVA: 0x3B76640 Offset: 0x3B76741 VA: 0x3B76640
	internal static void LoadDefaultDelayedChannels() { }

	// RVA: 0x3B769A0 Offset: 0x3B76AA1 VA: 0x3B769A0
	public static ActivatedClientTypeEntry IsRemotelyActivatedClientType(Type svrType) { }

	// RVA: 0x3B76B40 Offset: 0x3B76C41 VA: 0x3B76B40
	public static WellKnownClientTypeEntry IsWellKnownClientType(Type svrType) { }

	// RVA: 0x3B76CE0 Offset: 0x3B76DE1 VA: 0x3B76CE0
	public static void RegisterActivatedClientType(ActivatedClientTypeEntry entry) { }

	// RVA: 0x3B76F60 Offset: 0x3B77061 VA: 0x3B76F60
	public static void RegisterActivatedServiceType(ActivatedServiceTypeEntry entry) { }

	// RVA: 0x3B770B0 Offset: 0x3B771B1 VA: 0x3B770B0
	public static void RegisterWellKnownClientType(WellKnownClientTypeEntry entry) { }

	// RVA: 0x3B77330 Offset: 0x3B77431 VA: 0x3B77330
	public static void RegisterWellKnownServiceType(WellKnownServiceTypeEntry entry) { }

	// RVA: 0x3B774D0 Offset: 0x3B775D1 VA: 0x3B774D0
	internal static void RegisterChannelTemplate(ChannelData channel) { }

	// RVA: 0x3B77560 Offset: 0x3B77661 VA: 0x3B77560
	internal static void RegisterClientProviderTemplate(ProviderData prov) { }

	// RVA: 0x3B775F0 Offset: 0x3B776F1 VA: 0x3B775F0
	internal static void RegisterServerProviderTemplate(ProviderData prov) { }

	// RVA: 0x3B77680 Offset: 0x3B77781 VA: 0x3B77680
	internal static void RegisterChannels(ArrayList channels, bool onlyDelayed) { }

	// RVA: 0x3B781E0 Offset: 0x3B782E1 VA: 0x3B781E0
	internal static void RegisterTypes(ArrayList types) { }

	// RVA: 0x3B786E0 Offset: 0x3B787E1 VA: 0x3B786E0
	public static bool CustomErrorsEnabled(bool isLocalRequest) { }

	// RVA: 0x3B787E0 Offset: 0x3B788E1 VA: 0x3B787E0
	internal static void SetCustomErrorsMode(string mode) { }

	// RVA: 0x3B78980 Offset: 0x3B78A81 VA: 0x3B78980
	private static void .cctor() { }
}

