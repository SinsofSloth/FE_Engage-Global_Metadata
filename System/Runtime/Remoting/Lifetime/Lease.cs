// Namespace: System.Runtime.Remoting.Lifetime
internal class Lease : MarshalByRefObject, ILease // TypeDefIndex: 1128
{
	// Fields
	private DateTime _leaseExpireTime; // 0x18
	private LeaseState _currentState; // 0x20
	private TimeSpan _initialLeaseTime; // 0x28
	private TimeSpan _renewOnCallTime; // 0x30
	private TimeSpan _sponsorshipTimeout; // 0x38
	private ArrayList _sponsors; // 0x40
	private Queue _renewingSponsors; // 0x48
	private Lease.RenewalDelegate _renewalDelegate; // 0x50

	// Properties
	public TimeSpan CurrentLeaseTime { get; }
	public LeaseState CurrentState { get; }
	public TimeSpan RenewOnCallTime { get; }

	// Methods

	// RVA: 0x341C670 Offset: 0x341C771 VA: 0x341C670
	public void .ctor() { }

	// RVA: 0x341C850 Offset: 0x341C951 VA: 0x341C850 Slot: 6
	public TimeSpan get_CurrentLeaseTime() { }

	// RVA: 0x341C8D0 Offset: 0x341C9D1 VA: 0x341C8D0 Slot: 7
	public LeaseState get_CurrentState() { }

	// RVA: 0x341C8E0 Offset: 0x341C9E1 VA: 0x341C8E0
	public void Activate() { }

	// RVA: 0x341C8F0 Offset: 0x341C9F1 VA: 0x341C8F0 Slot: 8
	public TimeSpan get_RenewOnCallTime() { }

	// RVA: 0x341C900 Offset: 0x341CA01 VA: 0x341C900 Slot: 9
	public TimeSpan Renew(TimeSpan renewalTime) { }

	// RVA: 0x341CA10 Offset: 0x341CB11 VA: 0x341CA10 Slot: 10
	public void Unregister(ISponsor obj) { }

	// RVA: 0x341CB50 Offset: 0x341CC51 VA: 0x341CB50
	internal void UpdateState() { }

	// RVA: 0x341CD50 Offset: 0x341CE51 VA: 0x341CD50
	private void CheckNextSponsor() { }

	// RVA: 0x341CFB0 Offset: 0x341D0B1 VA: 0x341CFB0
	private void ProcessSponsorResponse(object state, bool timedOut) { }
}

