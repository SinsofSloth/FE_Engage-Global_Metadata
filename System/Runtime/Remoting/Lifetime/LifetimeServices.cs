// Namespace: System.Runtime.Remoting.Lifetime
[ComVisibleAttribute] // RVA: 0x474C30 Offset: 0x474D31 VA: 0x474C30
public sealed class LifetimeServices // TypeDefIndex: 1132
{
	// Fields
	private static TimeSpan _leaseManagerPollTime; // 0x0
	private static TimeSpan _leaseTime; // 0x8
	private static TimeSpan _renewOnCallTime; // 0x10
	private static TimeSpan _sponsorshipTimeout; // 0x18
	private static LeaseManager _leaseManager; // 0x20

	// Properties
	public static TimeSpan LeaseManagerPollTime { get; set; }
	public static TimeSpan LeaseTime { get; set; }
	public static TimeSpan RenewOnCallTime { get; set; }
	public static TimeSpan SponsorshipTimeout { get; set; }

	// Methods

	// RVA: 0x341DD20 Offset: 0x341DE21 VA: 0x341DD20
	private static void .cctor() { }

	// RVA: 0x341DEA0 Offset: 0x341DFA1 VA: 0x341DEA0
	public static TimeSpan get_LeaseManagerPollTime() { }

	// RVA: 0x341DF10 Offset: 0x341E011 VA: 0x341DF10
	public static void set_LeaseManagerPollTime(TimeSpan value) { }

	// RVA: 0x341DF90 Offset: 0x341E091 VA: 0x341DF90
	public static TimeSpan get_LeaseTime() { }

	// RVA: 0x341E000 Offset: 0x341E101 VA: 0x341E000
	public static void set_LeaseTime(TimeSpan value) { }

	// RVA: 0x341E070 Offset: 0x341E171 VA: 0x341E070
	public static TimeSpan get_RenewOnCallTime() { }

	// RVA: 0x341E0E0 Offset: 0x341E1E1 VA: 0x341E0E0
	public static void set_RenewOnCallTime(TimeSpan value) { }

	// RVA: 0x341E150 Offset: 0x341E251 VA: 0x341E150
	public static TimeSpan get_SponsorshipTimeout() { }

	// RVA: 0x341E1C0 Offset: 0x341E2C1 VA: 0x341E1C0
	public static void set_SponsorshipTimeout(TimeSpan value) { }

	// RVA: 0x341E230 Offset: 0x341E331 VA: 0x341E230
	internal static void TrackLifetime(ServerIdentity identity) { }
}

