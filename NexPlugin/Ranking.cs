// Namespace: NexPlugin
public static class Ranking // TypeDefIndex: 14939
{
	// Fields
	public const byte MAX_COMMON_DATA_SIZE = 255;
	public const uint MAX_RANGE_RANKING_ORDER = 1000;
	public const uint MAX_ACCURATE_ORDER = 5000;

	// Methods

	// RVA: 0x276B800 Offset: 0x276B901 VA: 0x276B800
	public static bool UploadCommonDataAsync(out uint asyncId, IntPtr pNgsFacade, List<byte> commonData, ulong nexUniqueId = 0, int timeOut = 0, AsyncResultCB callback) { }

	// RVA: 0x276B810 Offset: 0x276B911 VA: 0x276B810
	public static bool DeleteCommonDataAsync(out uint asyncId, IntPtr pNgsFacade, ulong nexUniqueId = 0, int timeOut = 0, AsyncResultCB callback) { }

	// RVA: 0x276B820 Offset: 0x276B921 VA: 0x276B820
	public static bool GetCommonDataAsync(out uint asyncId, IntPtr pNgsFacade, ulong nexUniqueId = 0, int timeOut = 0, Ranking.GetCommonDataCB callback) { }

	// RVA: 0x276B830 Offset: 0x276B931 VA: 0x276B830
	public static bool UploadScoreAsync(out uint asyncId, IntPtr pNgsFacade, RankingScoreData scoreData, ulong nexUniqueId = 0, int timeOut = 0, AsyncResultCB callback) { }

	// RVA: 0x276B840 Offset: 0x276B941 VA: 0x276B840
	public static bool DeleteScoreAsync(out uint asyncId, IntPtr pNgsFacade, uint category, ulong nexUniqueId = 0, int timeOut = 0, AsyncResultCB callback) { }

	// RVA: 0x276B860 Offset: 0x276B961 VA: 0x276B860
	public static bool DeleteScoreAsync(out uint asyncId, IntPtr pNgsFacade, ulong nexUniqueId = 0, int timeOut = 0, AsyncResultCB callback) { }

	// RVA: 0x276B880 Offset: 0x276B981 VA: 0x276B880
	public static bool GetRankingAsync(out uint asyncId, IntPtr pNgsFacade, Ranking.RankingMode rankingMode, uint category, RankingOrderParam orderParam, ulong nexUniqueId = 0, ulong principalId = 0, int timeOut = 0, Ranking.GetRankingCB callback) { }

	// RVA: 0x276B890 Offset: 0x276B991 VA: 0x276B890
	public static bool GetRankingByPIDListAsync(out uint asyncId, IntPtr pNgsFacade, List<ulong> principalIdList, Ranking.RankingMode rankingMode, uint category, RankingOrderParam orderParam, ulong nexUniqueId = 0, int timeOut = 0, Ranking.GetRankingCB callback) { }

	// RVA: 0x276B8A0 Offset: 0x276B9A1 VA: 0x276B8A0
	public static bool GetRankingByUIDListAsync(out uint asyncId, IntPtr pNgsFacade, List<ulong> nexUniqueIdList, Ranking.RankingMode rankingMode, uint category, RankingOrderParam orderParam, ulong nexUniqueId = 0, int timeOut = 0, Ranking.GetRankingCB callback) { }

	// RVA: 0x276B8B0 Offset: 0x276B9B1 VA: 0x276B8B0
	public static bool GetApproxOrderAsync(out uint asyncId, IntPtr pNgsFacade, uint category, RankingOrderParam orderParam, uint score, ulong nexUniqueId = 0, ulong principalId = 0, int timeOut = 0, Ranking.GetApproxOrderCB callback) { }

	// RVA: 0x276B8C0 Offset: 0x276B9C1 VA: 0x276B8C0
	public static bool GetStatsAsync(out uint asyncId, IntPtr pNgsFacade, uint category, RankingOrderParam orderParam, Ranking.StatsFlag flags, int timeOut = 0, Ranking.GetStatsCB callback) { }

	// RVA: 0x276B8D0 Offset: 0x276B9D1 VA: 0x276B8D0
	public static bool ChangeAttributesAsync(out uint asyncId, IntPtr pNgsFacade, uint category, RankingChangeAttributesParam changeParam, ulong nexUniqueId = 0, int timeOut = 0, AsyncResultCB callback) { }

	// RVA: 0x276B910 Offset: 0x276BA11 VA: 0x276B910
	public static bool ChangeAttributesAsync(out uint asyncId, IntPtr pNgsFacade, RankingChangeAttributesParam changeParam, ulong nexUniqueId = 0, int timeOut = 0, AsyncResultCB callback) { }

	// RVA: 0x276B950 Offset: 0x276BA51 VA: 0x276B950
	public static bool GetCachedTopXRankingAsync(out uint asyncId, IntPtr pNgsFacade, uint category, RankingOrderParam orderParam, int timeOut = 0, Ranking.GetCachedTopXRankingCB callback) { }

	// RVA: 0x276B960 Offset: 0x276BA61 VA: 0x276B960
	public static bool GetCachedTopXRankingsAsync(out uint asyncId, IntPtr pNgsFacade, List<uint> categories, RankingOrderParam orderParam, int timeOut = 0, Ranking.GetCachedTopXRankingsCB callback) { }

	// RVA: 0x276BA50 Offset: 0x276BB51 VA: 0x276BA50
	public static bool GetCachedTopXRankingsAsync(out uint asyncId, IntPtr pNgsFacade, List<uint> categories, List<RankingOrderParam> orderParams, int timeOut = 0, Ranking.GetCachedTopXRankingsCB callback) { }
}

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
public class Ranking2RankData // TypeDefIndex: 14993
{
	// Fields
	internal ulong misc; // 0x10
	internal ulong nexUniqueId; // 0x18
	internal ulong principalId; // 0x20
	internal uint rank; // 0x28
	internal uint score; // 0x2C
	internal Ranking2CommonData commonData; // 0x30

	// Methods

	// RVA: 0x276DAC0 Offset: 0x276DBC1 VA: 0x276DAC0
	public void .ctor() { }

	// RVA: 0x276DB40 Offset: 0x276DC41 VA: 0x276DB40
	public uint GetRank() { }

	// RVA: 0x276DB50 Offset: 0x276DC51 VA: 0x276DB50
	public uint GetScore() { }

	// RVA: 0x276DB60 Offset: 0x276DC61 VA: 0x276DB60
	public ulong GetPrincipalId() { }

	// RVA: 0x276DB70 Offset: 0x276DC71 VA: 0x276DB70
	public ulong GetNexUniqueId() { }

	// RVA: 0x276DB80 Offset: 0x276DC81 VA: 0x276DB80
	public Ranking2CommonData GetCommonData() { }

	// RVA: 0x276DB90 Offset: 0x276DC91 VA: 0x276DB90
	public ulong GetMisc() { }

	// RVA: 0x276DBA0 Offset: 0x276DCA1 VA: 0x276DBA0
	public void Trace() { }

	// RVA: 0x276DBB0 Offset: 0x276DCB1 VA: 0x276DBB0 Slot: 3
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
public class Ranking2CategorySetting // TypeDefIndex: 14995
{
	// Fields
	internal uint minScore; // 0x10
	internal uint maxScore; // 0x14
	internal ushort lowestRank; // 0x18
	internal byte maxSeasonsToGoBack; // 0x1A
	internal byte resetMode; // 0x1B
	internal byte resetHour; // 0x1C
	internal byte resetDay; // 0x1D
	internal ushort resetMonth; // 0x1E
	internal bool scoreOrder; // 0x20

	// Methods

	// RVA: 0x276BB20 Offset: 0x276BC21 VA: 0x276BB20
	public void .ctor() { }

	// RVA: 0x276BB30 Offset: 0x276BC31 VA: 0x276BB30
	public uint GetMinScore() { }

	// RVA: 0x276BB40 Offset: 0x276BC41 VA: 0x276BB40
	public uint GetMaxScore() { }

	// RVA: 0x276BB50 Offset: 0x276BC51 VA: 0x276BB50
	public bool GetScoreOrder() { }

	// RVA: 0x276BB60 Offset: 0x276BC61 VA: 0x276BB60
	public uint GetLowestRank() { }

	// RVA: 0x276BB70 Offset: 0x276BC71 VA: 0x276BB70
	public byte GetMaxSeasonsToGoBack() { }

	// RVA: 0x276BB80 Offset: 0x276BC81 VA: 0x276BB80
	public byte GetResetMode() { }

	// RVA: 0x276BB90 Offset: 0x276BC91 VA: 0x276BB90
	public byte GetResetHour() { }

	// RVA: 0x276BBA0 Offset: 0x276BCA1 VA: 0x276BBA0
	public byte GetResetDay() { }

	// RVA: 0x276BBB0 Offset: 0x276BCB1 VA: 0x276BBB0
	public ushort GetResetMonth() { }

	// RVA: 0x276BBC0 Offset: 0x276BCC1 VA: 0x276BBC0
	public void Trace() { }

	// RVA: 0x276BBD0 Offset: 0x276BCD1 VA: 0x276BBD0 Slot: 3
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
public struct Ranking2EstimateScoreRankOutput // TypeDefIndex: 14997
{
	// Fields
	internal uint rank; // 0x0
	internal uint score; // 0x4
	internal uint category; // 0x8
	internal uint season; // 0xC
	internal uint samplingRate; // 0x10
	internal uint length; // 0x14

	// Methods

	// RVA: 0x276CB80 Offset: 0x276CC81 VA: 0x276CB80
	public uint GetRank() { }

	// RVA: 0x276CB90 Offset: 0x276CC91 VA: 0x276CB90
	public uint GetScore() { }

	// RVA: 0x276CBA0 Offset: 0x276CCA1 VA: 0x276CBA0
	public uint GetCategory() { }

	// RVA: 0x276CBB0 Offset: 0x276CCB1 VA: 0x276CBB0
	public uint GetSeason() { }

	// RVA: 0x276CBC0 Offset: 0x276CCC1 VA: 0x276CBC0
	public uint GetSamplingRate() { }

	// RVA: 0x276CBD0 Offset: 0x276CCD1 VA: 0x276CBD0
	public uint GetLength() { }

	// RVA: 0x276CBE0 Offset: 0x276CCE1 VA: 0x276CBE0
	public void Trace() { }

	// RVA: 0x276CBF0 Offset: 0x276CCF1 VA: 0x276CBF0 Slot: 3
	public override string ToString() { }
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
public class Ranking2GetParam // TypeDefIndex: 14999
{
	// Fields
	internal ulong nexUniqueId; // 0x10
	internal uint category; // 0x18
	internal uint offset; // 0x1C
	internal uint length; // 0x20
	internal ulong principalId; // 0x28
	internal Ranking2.Ranking2GetOptionFlags optionFlags; // 0x30
	internal Ranking2.Ranking2SortFlags sortFlags; // 0x34
	internal Ranking2.Ranking2Mode mode; // 0x38
	internal byte numSeasonsToGoBack; // 0x39

	// Methods

	// RVA: 0x276D260 Offset: 0x276D361 VA: 0x276D260
	public void .ctor() { }

	// RVA: 0x276D2C0 Offset: 0x276D3C1 VA: 0x276D2C0
	public Ranking2.Ranking2Mode GetMode() { }

	// RVA: 0x276D2D0 Offset: 0x276D3D1 VA: 0x276D2D0
	public void SetMode(Ranking2.Ranking2Mode mode_) { }

	// RVA: 0x276D2E0 Offset: 0x276D3E1 VA: 0x276D2E0
	public uint GetCategory() { }

	// RVA: 0x276D2F0 Offset: 0x276D3F1 VA: 0x276D2F0
	public void SetCategory(uint category_) { }

	// RVA: 0x276D300 Offset: 0x276D401 VA: 0x276D300
	public byte GetNumSeasonsToGoBack() { }

	// RVA: 0x276D310 Offset: 0x276D411 VA: 0x276D310
	public void SetNumSeasonsToGoBack(byte numSeasonsToGoBack_) { }

	// RVA: 0x276D320 Offset: 0x276D421 VA: 0x276D320
	public uint GetOffset() { }

	// RVA: 0x276D330 Offset: 0x276D431 VA: 0x276D330
	public void SetOffset(uint offset_) { }

	// RVA: 0x276D340 Offset: 0x276D441 VA: 0x276D340
	public uint GetLength() { }

	// RVA: 0x276D350 Offset: 0x276D451 VA: 0x276D350
	public void SetLength(uint length_) { }

	// RVA: 0x276D360 Offset: 0x276D461 VA: 0x276D360
	public ulong GetPrincipalId() { }

	// RVA: 0x276D370 Offset: 0x276D471 VA: 0x276D370
	public void SetPrincipalId(ulong principalId_) { }

	// RVA: 0x276D380 Offset: 0x276D481 VA: 0x276D380
	public ulong GetNexUniqueId() { }

	// RVA: 0x276D390 Offset: 0x276D491 VA: 0x276D390
	public void SetNexUniqueId(ulong nexUniqueId_) { }

	// RVA: 0x276D3A0 Offset: 0x276D4A1 VA: 0x276D3A0
	public Ranking2.Ranking2SortFlags GetSortFlags() { }

	// RVA: 0x276D3B0 Offset: 0x276D4B1 VA: 0x276D3B0
	public void SetSortFlags(Ranking2.Ranking2SortFlags sortFlags_) { }

	// RVA: 0x276D3C0 Offset: 0x276D4C1 VA: 0x276D3C0
	public Ranking2.Ranking2GetOptionFlags GetOptionFlags() { }

	// RVA: 0x276D3D0 Offset: 0x276D4D1 VA: 0x276D3D0
	public void SetOptionFlags(Ranking2.Ranking2GetOptionFlags optionFlags_) { }

	// RVA: 0x276D2A0 Offset: 0x276D3A1 VA: 0x276D2A0
	public void Reset() { }

	// RVA: 0x276D3E0 Offset: 0x276D4E1 VA: 0x276D3E0
	public void Trace() { }

	// RVA: 0x276D3F0 Offset: 0x276D4F1 VA: 0x276D3F0 Slot: 3
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
public struct Ranking2ChartInfoInput // TypeDefIndex: 15001
{
	// Fields
	internal uint chartIndex; // 0x0
	internal byte numSeasonsToGoBack; // 0x4

	// Methods

	// RVA: 0x276C690 Offset: 0x276C791 VA: 0x276C690
	public uint GetChartIndex() { }

	// RVA: 0x276C6A0 Offset: 0x276C7A1 VA: 0x276C6A0
	public void SetChartIndex(uint index) { }

	// RVA: 0x276C6B0 Offset: 0x276C7B1 VA: 0x276C6B0
	public byte GetNumSeasonsToGoBack() { }

	// RVA: 0x276C6C0 Offset: 0x276C7C1 VA: 0x276C6C0
	public void SetNumSeasonsToGoBack(byte numSeasonsToGoBack_) { }

	// RVA: 0x276C6D0 Offset: 0x276C7D1 VA: 0x276C6D0
	public void Reset() { }

	// RVA: 0x276C6E0 Offset: 0x276C7E1 VA: 0x276C6E0
	public void Trace() { }

	// RVA: 0x276C6F0 Offset: 0x276C7F1 VA: 0x276C6F0 Slot: 3
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

