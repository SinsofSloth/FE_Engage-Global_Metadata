// Namespace: Combat
[DefaultMemberAttribute] // RVA: 0x273EF0 Offset: 0x273FF1 VA: 0x273EF0
public sealed class PrefetchedSignalStore // TypeDefIndex: 8625
{
	// Fields
	private Dictionary<int, PrefetchedSignal> dic; // 0x10
	public int lastHash; // 0x18
	public PrefetchedSignal lastSignal; // 0x20
	private static PrefetchedSignalStore s_null; // 0x0
	private static readonly int[] attackHashes; // 0x8
	private PrefetchedSignal[] items; // 0x28

	// Properties
	public PrefetchedSignal Item { get; }
	public static PrefetchedSignalStore Null { get; }
	public bool HasKnockoffAttack { get; }
	public IReadOnlyCollection<PrefetchedSignal> LotteryItems { get; }

	// Methods

	// RVA: 0x29DCF30 Offset: 0x29DD031 VA: 0x29DCF30
	public bool Has(int hash) { }

	// RVA: 0x29DCF90 Offset: 0x29DD091 VA: 0x29DCF90
	public PrefetchedSignal get_Item(int hash) { }

	// RVA: 0x29DD080 Offset: 0x29DD181 VA: 0x29DD080
	public static PrefetchedSignalStore get_Null() { }

	// RVA: 0x29DD1E0 Offset: 0x29DD2E1 VA: 0x29DD1E0
	private void .ctor() { }

	// RVA: 0x29DD270 Offset: 0x29DD371 VA: 0x29DD270
	public void .ctor(Character chr, Animator bodyAni, Animator rideAni) { }

	// RVA: 0x29DD840 Offset: 0x29DD941 VA: 0x29DD840
	public bool get_HasKnockoffAttack() { }

	// RVA: 0x29DD940 Offset: 0x29DDA41 VA: 0x29DD940
	public IReadOnlyCollection<PrefetchedSignal> get_LotteryItems() { }

	// RVA: 0x29DD950 Offset: 0x29DDA51 VA: 0x29DD950
	public void Booking(int[] hashes) { }

	// RVA: 0x29DDAA0 Offset: 0x29DDBA1 VA: 0x29DDAA0
	public PrefetchedSignal Lottery() { }

	// RVA: 0x29DDBB0 Offset: 0x29DDCB1 VA: 0x29DDBB0
	public PrefetchedSignal GetBest() { }

	// RVA: 0x29DDD10 Offset: 0x29DDE11 VA: 0x29DDD10
	public PrefetchedSignal SelectRandomOne() { }

	// RVA: 0x29DD720 Offset: 0x29DD821 VA: 0x29DD720
	private static string ClipNameToStateName(string clipName) { }

	// RVA: 0x29DDDB0 Offset: 0x29DDEB1 VA: 0x29DDDB0
	private static void .cctor() { }
}

