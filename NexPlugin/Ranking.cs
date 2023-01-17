// Namespace: NexPlugin
public static class Ranking2 // TypeDefIndex: 14950
{
	// Fields
	public const int MAX_BINARY_DATA_LENGTH = 100;
	public const uint MAX_CHART_GET_LENGTH = 20;
	public const uint MAX_PUT_MULTI_SCORES = 20;
	public const uint MAX_RANKING_LENGTH = 100;
	public const int MAX_USERNAME_LENGTH = 20;
	public const bool SCORE_ORDER_ASC = False;
	public const bool SCORE_ORDER_DESC = True;

	// Methods

	// RVA: 0x276BA70 Offset: 0x276BB71 VA: 0x276BA70
	public static bool PutScoreAsync(out uint asyncId, IntPtr pNgsFacade, Ranking2ScoreData scoreData, ulong nexUniqueId = 0, int timeOut = 0, AsyncResultCB callback) { }

	// RVA: 0x276BA80 Offset: 0x276BB81 VA: 0x276BA80
	public static bool PutScoreAsync(out uint asyncId, IntPtr pNgsFacade, List<Ranking2ScoreData> scoreDataList, ulong nexUniqueId = 0, int timeOut = 0, AsyncResultCB callback) { }

	// RVA: 0x276BA90 Offset: 0x276BB91 VA: 0x276BA90
	public static bool PutCommonDataAsync(out uint asyncId, IntPtr pNgsFacade, Ranking2CommonData commonData, ulong nexUniqueId = 0, int timeOut = 0, AsyncResultCB callback) { }

	// RVA: 0x276BAA0 Offset: 0x276BBA1 VA: 0x276BAA0
	public static bool GetCommonDataAsync(out uint asyncId, IntPtr pNgsFacade, Ranking2.Ranking2GetOptionFlags optionFlags = 0, ulong principalId = 0, ulong nexUniqueId = 0, int timeOut = 0, Ranking2.GetCommonDataCB callback) { }

	// RVA: 0x276BAB0 Offset: 0x276BBB1 VA: 0x276BAB0
	public static bool DeleteCommonDataAsync(out uint asyncId, IntPtr pNgsFacade, ulong nexUniqueId = 0, int timeOut = 0, AsyncResultCB callback) { }

	// RVA: 0x276BAC0 Offset: 0x276BBC1 VA: 0x276BAC0
	public static bool GetRankingAsync(out uint asyncId, IntPtr pNgsFacade, Ranking2GetParam getParam, int timeOut = 0, Ranking2.GetRankingCB callback) { }

	// RVA: 0x276BAD0 Offset: 0x276BBD1 VA: 0x276BAD0
	public static bool GetRankingAsync(out uint asyncId, IntPtr pNgsFacade, Ranking2GetByListParam getParam, List<ulong> principalIdList, int timeOut = 0, Ranking2.GetRankingCB callback) { }

	// RVA: 0x276BAE0 Offset: 0x276BBE1 VA: 0x276BAE0
	public static bool GetCategorySettingAsync(out uint asyncId, IntPtr pNgsFacade, uint category, int timeOut = 0, Ranking2.GetCategorySettingCB callback) { }

	// RVA: 0x276BAF0 Offset: 0x276BBF1 VA: 0x276BAF0
	public static bool GetRankingChartAsync(out uint asyncId, IntPtr pNgsFacade, Ranking2ChartInfoInput info, int timeOut = 0, Ranking2.GetRanking2ChartInfoCB callback) { }

	// RVA: 0x276BB00 Offset: 0x276BC01 VA: 0x276BB00
	public static bool GetRankingChartAsync(out uint asyncId, IntPtr pNgsFacade, List<Ranking2ChartInfoInput> info, int timeOut = 0, Ranking2.GetRanking2ChartInfoListCB callback) { }

	// RVA: 0x276BB10 Offset: 0x276BC11 VA: 0x276BB10
	public static bool GetEstimateScoreRankAsync(out uint asyncId, IntPtr pNgsFacade, Ranking2EstimateScoreRankInput info, int timeOut = 0, Ranking2.GetRanking2EstimateScoreRankCB callback) { }
}

// Namespace: NexPlugin
public class Ranking2CommonData // TypeDefIndex: 14992
{
	// Fields
	internal List<byte> binaryData; // 0x10
	internal string userName; // 0x18

	// Methods

	// RVA: 0x276C7B0 Offset: 0x276C8B1 VA: 0x276C7B0
	public void .ctor() { }

	// RVA: 0x276C890 Offset: 0x276C991 VA: 0x276C890
	public string GetUserName() { }

	// RVA: 0x276C8A0 Offset: 0x276C9A1 VA: 0x276C8A0
	public void SetUserName(string userName_) { }

	// RVA: 0x276C8B0 Offset: 0x276C9B1 VA: 0x276C8B0
	public List<byte> GetBinaryData() { }

	// RVA: 0x276C8C0 Offset: 0x276C9C1 VA: 0x276C8C0
	public void SetBinaryData(List<byte> binaryData_) { }

	// RVA: 0x276C7E0 Offset: 0x276C8E1 VA: 0x276C7E0
	public void Reset() { }

	// RVA: 0x276C950 Offset: 0x276CA51 VA: 0x276C950
	public void Trace() { }

	// RVA: 0x276C960 Offset: 0x276CA61 VA: 0x276C960 Slot: 3
	public override string ToString() { }
}

// Namespace: NexPlugin
public class Ranking2Info // TypeDefIndex: 14994
{
	// Fields
	internal uint numRankedIn; // 0x10
	internal uint lowestRank; // 0x14
	internal int season; // 0x18
	internal List<Ranking2RankData> rankDataList; // 0x20

	// Methods

	// RVA: 0x276D7C0 Offset: 0x276D8C1 VA: 0x276D7C0
	public void .ctor() { }

	// RVA: 0x276D850 Offset: 0x276D951 VA: 0x276D850
	public List<Ranking2RankData> GetRankDataList() { }

	// RVA: 0x276D860 Offset: 0x276D961 VA: 0x276D860
	public uint GetLowestRank() { }

	// RVA: 0x276D870 Offset: 0x276D971 VA: 0x276D870
	public uint GetNumRankedIn() { }

	// RVA: 0x276D880 Offset: 0x276D981 VA: 0x276D880
	public int GetSeason() { }

	// RVA: 0x276D890 Offset: 0x276D991 VA: 0x276D890
	public void Trace() { }

	// RVA: 0x276D8A0 Offset: 0x276D9A1 VA: 0x276D8A0 Slot: 3
	public override string ToString() { }
}

// Namespace: NexPlugin
public class Ranking2ChartInfo // TypeDefIndex: 14996
{
	// Fields
	internal uint index; // 0x10
	internal uint category; // 0x14
	internal uint season; // 0x18
	internal uint samplingRate; // 0x1C
	internal bool scoreOrder; // 0x20
	internal uint estimateLength; // 0x24
	internal uint estimateHighestScore; // 0x28
	internal uint estimateLowestScore; // 0x2C
	internal uint estimateMedianScore; // 0x30
	internal uint highestBinsScore; // 0x34
	internal uint lowestBinsScore; // 0x38
	internal uint binsWidth; // 0x3C
	internal uint attribute1; // 0x40
	internal uint attribute2; // 0x44
	internal NpDateTime createTime; // 0x48
	internal double estimateAverageScore; // 0x50
	internal List<uint> quantities; // 0x58
	internal byte binsSize; // 0x60

	// Methods

	// RVA: 0x276BF70 Offset: 0x276C071 VA: 0x276BF70
	public NpDateTime GetCreateTime() { }

	// RVA: 0x276BF80 Offset: 0x276C081 VA: 0x276BF80
	public uint GetIndex() { }

	// RVA: 0x276BF90 Offset: 0x276C091 VA: 0x276BF90
	public uint GetCategory() { }

	// RVA: 0x276BFA0 Offset: 0x276C0A1 VA: 0x276BFA0
	public uint GetSeason() { }

	// RVA: 0x276BFB0 Offset: 0x276C0B1 VA: 0x276BFB0
	public uint GetBinsSize() { }

	// RVA: 0x276BFC0 Offset: 0x276C0C1 VA: 0x276BFC0
	public bool IsValid() { }

	// RVA: 0x276BFD0 Offset: 0x276C0D1 VA: 0x276BFD0
	public uint GetSamplingRate() { }

	// RVA: 0x276BFE0 Offset: 0x276C0E1 VA: 0x276BFE0
	public bool GetScoreOrder() { }

	// RVA: 0x276BFF0 Offset: 0x276C0F1 VA: 0x276BFF0
	public uint GetEstimateLength() { }

	// RVA: 0x276C000 Offset: 0x276C101 VA: 0x276C000
	public uint GetEstimateHighestScore() { }

	// RVA: 0x276C010 Offset: 0x276C111 VA: 0x276C010
	public uint GetEstimateLowestScore() { }

	// RVA: 0x276C020 Offset: 0x276C121 VA: 0x276C020
	public uint GetEstimateMedianScore() { }

	// RVA: 0x276C030 Offset: 0x276C131 VA: 0x276C030
	public double GetEstimateAverageScore() { }

	// RVA: 0x276C040 Offset: 0x276C141 VA: 0x276C040
	public uint GetHighestBinsScore() { }

	// RVA: 0x276C050 Offset: 0x276C151 VA: 0x276C050
	public uint GetLowestBinsScore() { }

	// RVA: 0x276C060 Offset: 0x276C161 VA: 0x276C060
	public uint GetBinsWidth() { }

	// RVA: 0x276C070 Offset: 0x276C171 VA: 0x276C070
	public uint GetAttribute1() { }

	// RVA: 0x276C080 Offset: 0x276C181 VA: 0x276C080
	public uint GetAttribute2() { }

	// RVA: 0x276C090 Offset: 0x276C191 VA: 0x276C090
	public List<uint> GetQuantities() { }

	// RVA: 0x276C110 Offset: 0x276C211 VA: 0x276C110
	public void Trace() { }

	// RVA: 0x276C120 Offset: 0x276C221 VA: 0x276C120 Slot: 3
	public override string ToString() { }

	// RVA: 0x276C680 Offset: 0x276C781 VA: 0x276C680
	public void .ctor() { }
}

// Namespace: NexPlugin
public class Ranking2ScoreData // TypeDefIndex: 14998
{
	// Fields
	internal uint category; // 0x10
	internal uint score; // 0x14
	internal ulong misc; // 0x18

	// Methods

	// RVA: 0x276DE40 Offset: 0x276DF41 VA: 0x276DE40
	public void .ctor() { }

	// RVA: 0x276DE80 Offset: 0x276DF81 VA: 0x276DE80
	public uint GetCategory() { }

	// RVA: 0x276DE90 Offset: 0x276DF91 VA: 0x276DE90
	public void SetCategory(uint category_) { }

	// RVA: 0x276DEA0 Offset: 0x276DFA1 VA: 0x276DEA0
	public uint GetScore() { }

	// RVA: 0x276DEB0 Offset: 0x276DFB1 VA: 0x276DEB0
	public void SetScore(uint score_) { }

	// RVA: 0x276DEC0 Offset: 0x276DFC1 VA: 0x276DEC0
	public ulong GetMisc() { }

	// RVA: 0x276DED0 Offset: 0x276DFD1 VA: 0x276DED0
	public void SetMisc(ulong misc_) { }

	// RVA: 0x276DE70 Offset: 0x276DF71 VA: 0x276DE70
	public void Reset() { }

	// RVA: 0x276DEE0 Offset: 0x276DFE1 VA: 0x276DEE0
	public void Trace() { }

	// RVA: 0x276DEF0 Offset: 0x276DFF1 VA: 0x276DEF0 Slot: 3
	public override string ToString() { }
}

// Namespace: NexPlugin
public class Ranking2GetByListParam // TypeDefIndex: 15000
{
	// Fields
	internal uint category; // 0x10
	internal uint offset; // 0x14
	internal uint length; // 0x18
	internal Ranking2.Ranking2GetOptionFlags optionFlags; // 0x1C
	internal Ranking2.Ranking2SortFlags sortFlags; // 0x20
	internal byte numSeasonsToGoBack; // 0x24

	// Methods

	// RVA: 0x276CE70 Offset: 0x276CF71 VA: 0x276CE70
	public void .ctor() { }

	// RVA: 0x276CED0 Offset: 0x276CFD1 VA: 0x276CED0
	public uint GetCategory() { }

	// RVA: 0x276CEE0 Offset: 0x276CFE1 VA: 0x276CEE0
	public void SetCategory(uint category_) { }

	// RVA: 0x276CEF0 Offset: 0x276CFF1 VA: 0x276CEF0
	public byte GetNumSeasonsToGoBack() { }

	// RVA: 0x276CF00 Offset: 0x276D001 VA: 0x276CF00
	public void SetNumSeasonsToGoBack(byte numSeasonsToGoBack_) { }

	// RVA: 0x276CF10 Offset: 0x276D011 VA: 0x276CF10
	public uint GetOffset() { }

	// RVA: 0x276CF20 Offset: 0x276D021 VA: 0x276CF20
	public void SetOffset(uint offset_) { }

	// RVA: 0x276CF30 Offset: 0x276D031 VA: 0x276CF30
	public uint GetLength() { }

	// RVA: 0x276CF40 Offset: 0x276D041 VA: 0x276CF40
	public void SetLength(uint length_) { }

	// RVA: 0x276CF50 Offset: 0x276D051 VA: 0x276CF50
	public Ranking2.Ranking2SortFlags GetSortFlags() { }

	// RVA: 0x276CF60 Offset: 0x276D061 VA: 0x276CF60
	public void SetSortFlags(Ranking2.Ranking2SortFlags sortFlags_) { }

	// RVA: 0x276CF70 Offset: 0x276D071 VA: 0x276CF70
	public Ranking2.Ranking2GetOptionFlags GetOptionFlags() { }

	// RVA: 0x276CF80 Offset: 0x276D081 VA: 0x276CF80
	public void SetOptionFlags(Ranking2.Ranking2GetOptionFlags optionFlags_) { }

	// RVA: 0x276CEB0 Offset: 0x276CFB1 VA: 0x276CEB0
	public void Reset() { }

	// RVA: 0x276CF90 Offset: 0x276D091 VA: 0x276CF90
	public void Trace() { }

	// RVA: 0x276CFA0 Offset: 0x276D0A1 VA: 0x276CFA0 Slot: 3
	public override string ToString() { }
}

// Namespace: NexPlugin
public struct Ranking2EstimateScoreRankInput // TypeDefIndex: 15002
{
	// Fields
	internal uint category; // 0x0
	internal uint score; // 0x4
	internal byte numSeasonsToGoBack; // 0x8

	// Methods

	// RVA: 0x276CA20 Offset: 0x276CB21 VA: 0x276CA20
	public uint GetCategory() { }

	// RVA: 0x276CA30 Offset: 0x276CB31 VA: 0x276CA30
	public void SetCategory(uint category_) { }

	// RVA: 0x276CA40 Offset: 0x276CB41 VA: 0x276CA40
	public byte GetNumSeasonsToGoBack() { }

	// RVA: 0x276CA50 Offset: 0x276CB51 VA: 0x276CA50
	public void SetNumSeasonsToGoBack(byte numSeasonsToGoBack_) { }

	// RVA: 0x276CA60 Offset: 0x276CB61 VA: 0x276CA60
	public uint GetScore() { }

	// RVA: 0x276CA70 Offset: 0x276CB71 VA: 0x276CA70
	public void SetScore(uint score_) { }

	// RVA: 0x276CA80 Offset: 0x276CB81 VA: 0x276CA80
	public void Reset() { }

	// RVA: 0x276CA90 Offset: 0x276CB91 VA: 0x276CA90
	public void Trace() { }

	// RVA: 0x276CAA0 Offset: 0x276CBA1 VA: 0x276CAA0 Slot: 3
	public override string ToString() { }
}

