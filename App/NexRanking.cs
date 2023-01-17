// Namespace: App
public class NexRanking : SingletonClass<NexRanking> // TypeDefIndex: 12747
{
	// Fields
	private const uint MaxRatingSlot = 16;
	public const int MaxPerson = 45;
	public const int MaxGod = 25;
	public const int InvalidIndex = 0;
	private bool m_IsSucceeded; // 0x19

	// Properties
	public bool IsSucceeded { get; }

	// Methods

	// RVA: 0x2357350 Offset: 0x2357451 VA: 0x2357350 Slot: 5
	protected override void OnCreate() { }

	// RVA: 0x23573F0 Offset: 0x23574F1 VA: 0x23573F0
	public bool Download(ProcInst super, string cid, NexRanking.Data[] ranking) { }

	// RVA: 0x23574B0 Offset: 0x23575B1 VA: 0x23574B0
	public bool Upload(ProcInst super, string cid, NexRanking.Data[] pairs) { }

	// RVA: 0x23574A0 Offset: 0x23575A1 VA: 0x23574A0
	public void ClearSucceeded() { }

	// RVA: 0x23574E0 Offset: 0x23575E1 VA: 0x23574E0
	public bool get_IsSucceeded() { }

	// RVA: 0x23574F0 Offset: 0x23575F1 VA: 0x23574F0
	private static bool GetIdAndSlot(int chapterIndex, ref NexRanking.Data data, out ulong dataId, out int slot) { }

	// RVA: 0x2357560 Offset: 0x2357661 VA: 0x2357560
	private static bool GetIdAndSlot(int chapterIndex, int personIndex, int godIndex, out ulong dataId, out int slot) { }

	// RVA: 0x23575D0 Offset: 0x23576D1 VA: 0x23575D0
	private static bool GetPersonAndGodIndex(ulong dataId, int slot, int chapterIndex, out int personIndex, out int godIndex) { }

	// RVA: 0x2357650 Offset: 0x2357751 VA: 0x2357650
	public void .ctor() { }
}

