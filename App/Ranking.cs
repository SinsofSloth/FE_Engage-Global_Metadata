// Namespace: App
public class Ranking : SingletonClass<Ranking> // TypeDefIndex: 12834
{
	// Fields
	private const int MaxPersonCount = 45;
	private const int MaxGodCount = 25;
	private const int MaxRankingCount = 100;
	private NexRanking.Data[] m_RankingData; // 0x20

	// Methods

	// RVA: 0x276B2C0 Offset: 0x276B3C1 VA: 0x276B2C0 Slot: 5
	protected override void OnCreate() { }

	// RVA: 0x276B330 Offset: 0x276B431 VA: 0x276B330 Slot: 6
	protected override void OnDispose() { }

	// RVA: 0x276B340 Offset: 0x276B441 VA: 0x276B340
	public void Download(ProcInst super, string cid) { }

	// RVA: 0x276B470 Offset: 0x276B571 VA: 0x276B470
	public void Upload(ProcInst super, string cid, NexRanking.Data[] pairs) { }

	// RVA: 0x276B510 Offset: 0x276B611 VA: 0x276B510
	public NexRanking.Data[] GetRankingData() { }

	// RVA: 0x276B520 Offset: 0x276B621 VA: 0x276B520
	public static PersonData GetPersonDataByNetRankingIndex(int netRankingIndex) { }

	// RVA: 0x276B650 Offset: 0x276B751 VA: 0x276B650
	public static GodData GetGodDataByNetRankingIndex(int netRankingIndex) { }

	// RVA: 0x276B780 Offset: 0x276B881 VA: 0x276B780
	public void .ctor() { }
}

