// Namespace: System.Threading
public struct CancellationTokenRegistration : IEquatable<CancellationTokenRegistration>, IDisposable // TypeDefIndex: 732
{
	// Fields
	private readonly CancellationCallbackInfo m_callbackInfo; // 0x0
	private readonly SparselyPopulatedArrayAddInfo<CancellationCallbackInfo> m_registrationInfo; // 0x8

	// Methods

	// RVA: 0x35172C0 Offset: 0x35173C1 VA: 0x35172C0
	internal void .ctor(CancellationCallbackInfo callbackInfo, SparselyPopulatedArrayAddInfo<CancellationCallbackInfo> registrationInfo) { }

	[FriendAccessAllowedAttribute] // RVA: 0x47C4D0 Offset: 0x47C5D1 VA: 0x47C4D0
	// RVA: 0x3517310 Offset: 0x3517411 VA: 0x3517310
	internal bool TryDeregister() { }

	// RVA: 0x3517390 Offset: 0x3517491 VA: 0x3517390 Slot: 5
	public void Dispose() { }

	// RVA: 0x3517580 Offset: 0x3517681 VA: 0x3517580 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x3517660 Offset: 0x3517761 VA: 0x3517660 Slot: 4
	public bool Equals(CancellationTokenRegistration other) { }

	// RVA: 0x3517700 Offset: 0x3517801 VA: 0x3517700 Slot: 2
	public override int GetHashCode() { }
}

