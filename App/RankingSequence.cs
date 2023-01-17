// Namespace: App
public class RankingSequence : SingletonProcInst<RankingSequence> // TypeDefIndex: 12855
{
	// Fields
	private const int MaxRankingCount = 100;
	private bool m_IsLastChapter; // 0x72
	private string m_Cid; // 0x78
	private int m_ChapterIndex; // 0x80
	private int m_SelectNetRankingIndex; // 0x84
	private int m_PersonIndex; // 0x88
	private int m_GodIndex; // 0x8C
	private int m_RandomAddNum; // 0x90
	private List<NexRanking.Data> m_Pairs; // 0x98

	// Methods

	// RVA: 0x27707C0 Offset: 0x27708C1 VA: 0x27707C0 Slot: 9
	protected override void OnCreate() { }

	// RVA: 0x2770A00 Offset: 0x2770B01 VA: 0x2770A00 Slot: 10
	protected override void OnDispose() { }

	// RVA: 0x2770910 Offset: 0x2770A11 VA: 0x2770910
	private ChapterData GetChapter() { }

	// RVA: 0x2770AC0 Offset: 0x2770BC1 VA: 0x2770AC0
	private void Menu() { }

	// RVA: 0x2770AD0 Offset: 0x2770BD1 VA: 0x2770AD0
	private void ErrorDialog() { }

	// RVA: 0x2770B60 Offset: 0x2770C61 VA: 0x2770B60
	private void DownloadRanking() { }

	// RVA: 0x2770BF0 Offset: 0x2770CF1 VA: 0x2770BF0
	private bool IsDownloadSuccess() { }

	// RVA: 0x2770D00 Offset: 0x2770E01 VA: 0x2770D00
	private void OpenRankingMenu() { }

	// RVA: 0x2770E50 Offset: 0x2770F51 VA: 0x2770E50
	private void CloseRankingMenu() { }

	// RVA: 0x2770F20 Offset: 0x2771021 VA: 0x2770F20
	private void UploadMenu() { }

	// RVA: 0x2770F30 Offset: 0x2771031 VA: 0x2770F30
	private void UploadData() { }

	// RVA: 0x2771050 Offset: 0x2771151 VA: 0x2771050
	private void UploadPairsList() { }

	// RVA: 0x2771190 Offset: 0x2771291 VA: 0x2771190
	private void AddUploadPairs() { }

	// RVA: 0x2771230 Offset: 0x2771331 VA: 0x2771230
	private void RandomAddUploadPairs() { }

	// RVA: 0x27715F0 Offset: 0x27716F1 VA: 0x27715F0
	private void ClearUploadPairs() { }

	// RVA: 0x2771650 Offset: 0x2771751 VA: 0x2771650
	public static void CreateBind(ProcInst super) { }

	// RVA: 0x2771DE0 Offset: 0x2771EE1 VA: 0x2771DE0
	public static void CreateBindLastChapter(ProcInst super) { }

	// RVA: 0x2771740 Offset: 0x2771841 VA: 0x2771740
	private void .ctor(bool isLastChapter) { }

	// RVA: 0x27717F0 Offset: 0x27718F1 VA: 0x27717F0
	private ProcDesc[] CreateDesc() { }

	// RVA: 0x2771EE0 Offset: 0x2771FE1 VA: 0x2771EE0
	private void LoadRes() { }

	// RVA: 0x2771F80 Offset: 0x2772081 VA: 0x2771F80
	private bool IsLoadingRes() { }

	// RVA: 0x2771FF0 Offset: 0x27720F1 VA: 0x2771FF0
	private void UnloadRes() { }

	// RVA: 0x2772070 Offset: 0x2772171 VA: 0x2772070
	public static string GetPersonDebugNameByNetRankingIndex(int netRankingIndex) { }

	// RVA: 0x27720E0 Offset: 0x27721E1 VA: 0x27720E0
	public static string GetGodDebugNameByNetRankingIndex(int netRankingIndex) { }

	[CompilerGeneratedAttribute] // RVA: 0x2CA0B0 Offset: 0x2CA1B1 VA: 0x2CA0B0
	// RVA: 0x2772180 Offset: 0x2772281 VA: 0x2772180
	private bool <CreateDesc>b__28_0() { }
}

