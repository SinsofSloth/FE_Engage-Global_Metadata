// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x2787A0 Offset: 0x2788A1 VA: 0x2787A0
private sealed class Ranking.<>c__DisplayClass9_0 // TypeDefIndex: 12832
{
	// Fields
	public int netRankingIndex; // 0x10
	public PersonData result; // 0x18

	// Methods

	// RVA: 0x1F2B0B0 Offset: 0x1F2B1B1 VA: 0x1F2B0B0
	public void .ctor() { }

	// RVA: 0x1F2B0C0 Offset: 0x1F2B1C1 VA: 0x1F2B0C0
	internal void <GetPersonDataByNetRankingIndex>b__0(PersonData personData) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x2787B0 Offset: 0x2788B1 VA: 0x2787B0
private sealed class Ranking.<>c__DisplayClass10_0 // TypeDefIndex: 12833
{
	// Fields
	public int netRankingIndex; // 0x10
	public GodData result; // 0x18

	// Methods

	// RVA: 0x1F2B080 Offset: 0x1F2B181 VA: 0x1F2B080
	public void .ctor() { }

	// RVA: 0x1F2B090 Offset: 0x1F2B191 VA: 0x1F2B090
	internal void <GetGodDataByNetRankingIndex>b__0(GodData godData) { }
}

// Namespace: 
public enum Ranking.RankingMode // TypeDefIndex: 14925
{
	// Fields
	public int value__; // 0x0
	public const Ranking.RankingMode RANKING_MODE_RANGE = 0;
	public const Ranking.RankingMode RANKING_MODE_NEAR = 1;
	public const Ranking.RankingMode RANKING_MODE_FRIEND_RANGE = 2;
	public const Ranking.RankingMode RANKING_MODE_FRIEND_NEAR = 3;
	public const Ranking.RankingMode RANKING_MODE_USER = 4;
}

// Namespace: 
public enum Ranking.FilterGroupIndex // TypeDefIndex: 14926
{
	// Fields
	public int value__; // 0x0
	public const Ranking.FilterGroupIndex FILTER_GROUP_INDEX_0 = 0;
	public const Ranking.FilterGroupIndex FILTER_GROUP_INDEX_1 = 1;
	public const Ranking.FilterGroupIndex FILTER_GROUP_INDEX_2 = 2;
	public const Ranking.FilterGroupIndex FILTER_GROUP_INDEX_3 = 3;
	public const Ranking.FilterGroupIndex FILTER_GROUP_INDEX_NONE = 255;
}

// Namespace: 
public enum Ranking.OrderBy // TypeDefIndex: 14927
{
	// Fields
	public int value__; // 0x0
	public const Ranking.OrderBy ORDER_BY_ASC = 0;
	public const Ranking.OrderBy ORDER_BY_DESC = 1;
}

// Namespace: 
public enum Ranking.UpdateMode // TypeDefIndex: 14928
{
	// Fields
	public int value__; // 0x0
	public const Ranking.UpdateMode UPDATE_MODE_NORMAL = 0;
	public const Ranking.UpdateMode UPDATE_MODE_DELETE_OLD = 1;
}

// Namespace: 
public enum Ranking.OrderCalculation // TypeDefIndex: 14929
{
	// Fields
	public int value__; // 0x0
	public const Ranking.OrderCalculation ORDER_CALCULATION_113 = 0;
	public const Ranking.OrderCalculation ORDER_CALCULATION_123 = 1;
}

// Namespace: 
public enum Ranking.TimeScope // TypeDefIndex: 14930
{
	// Fields
	public int value__; // 0x0
	public const Ranking.TimeScope TIME_SCOPE_CUSTOM_0 = 0;
	public const Ranking.TimeScope TIME_SCOPE_CUSTOM_1 = 1;
	public const Ranking.TimeScope TIME_SCOPE_ALL = 2;
}

// Namespace: 
[FlagsAttribute] // RVA: 0x27ACF0 Offset: 0x27ADF1 VA: 0x27ACF0
public enum Ranking.ModificationFlag // TypeDefIndex: 14931
{
	// Fields
	public int value__; // 0x0
	public const Ranking.ModificationFlag MODIFICATION_FLAG_NONE = 0;
	public const Ranking.ModificationFlag MODIFICATION_FLAG_GROUP0 = 1;
	public const Ranking.ModificationFlag MODIFICATION_FLAG_GROUP1 = 2;
	public const Ranking.ModificationFlag MODIFICATION_FLAG_GROUP2 = 4;
	public const Ranking.ModificationFlag MODIFICATION_FLAG_GROUP3 = 8;
	public const Ranking.ModificationFlag MODIFICATION_FLAG_PARAM = 16;
}

// Namespace: 
[FlagsAttribute] // RVA: 0x27AD00 Offset: 0x27AE01 VA: 0x27AD00
public enum Ranking.StatsFlag // TypeDefIndex: 14932
{
	// Fields
	public int value__; // 0x0
	public const Ranking.StatsFlag STATS_FLAG_TOTAL = 1;
	public const Ranking.StatsFlag STATS_FLAG_SUM = 2;
	public const Ranking.StatsFlag STATS_FLAG_MIN = 4;
	public const Ranking.StatsFlag STATS_FLAG_MAX = 8;
	public const Ranking.StatsFlag STATS_FLAG_AVERAGE = 16;
}

// Namespace: 
public sealed class Ranking.GetCommonDataCB : MulticastDelegate // TypeDefIndex: 14933
{
	// Methods

	// RVA: 0x1F2BD70 Offset: 0x1F2BE71 VA: 0x1F2BD70
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1F2BD90 Offset: 0x1F2BE91 VA: 0x1F2BD90 Slot: 13
	public virtual void Invoke(AsyncResult asyncResult, List<byte> data) { }

	// RVA: 0x1F2C100 Offset: 0x1F2C201 VA: 0x1F2C100 Slot: 14
	public virtual IAsyncResult BeginInvoke(AsyncResult asyncResult, List<byte> data, AsyncCallback callback, object object) { }

	// RVA: 0x1F2C130 Offset: 0x1F2C231 VA: 0x1F2C130 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
public sealed class Ranking.GetRankingCB : MulticastDelegate // TypeDefIndex: 14934
{
	// Methods

	// RVA: 0x1F2C140 Offset: 0x1F2C241 VA: 0x1F2C140
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1F2C160 Offset: 0x1F2C261 VA: 0x1F2C160 Slot: 13
	public virtual void Invoke(AsyncResult asyncResult, RankingResult info) { }

	// RVA: 0x1F2C4D0 Offset: 0x1F2C5D1 VA: 0x1F2C4D0 Slot: 14
	public virtual IAsyncResult BeginInvoke(AsyncResult asyncResult, RankingResult info, AsyncCallback callback, object object) { }

	// RVA: 0x1F2C500 Offset: 0x1F2C601 VA: 0x1F2C500 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
public sealed class Ranking.GetApproxOrderCB : MulticastDelegate // TypeDefIndex: 14935
{
	// Methods

	// RVA: 0x1F2B190 Offset: 0x1F2B291 VA: 0x1F2B190
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1F2B1B0 Offset: 0x1F2B2B1 VA: 0x1F2B1B0 Slot: 13
	public virtual void Invoke(AsyncResult asyncResult, uint rank) { }

	// RVA: 0x1F2B520 Offset: 0x1F2B621 VA: 0x1F2B520 Slot: 14
	public virtual IAsyncResult BeginInvoke(AsyncResult asyncResult, uint rank, AsyncCallback callback, object object) { }

	// RVA: 0x1F2B5C0 Offset: 0x1F2B6C1 VA: 0x1F2B5C0 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
public sealed class Ranking.GetStatsCB : MulticastDelegate // TypeDefIndex: 14936
{
	// Methods

	// RVA: 0x1F2C510 Offset: 0x1F2C611 VA: 0x1F2C510
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1F2C530 Offset: 0x1F2C631 VA: 0x1F2C530 Slot: 13
	public virtual void Invoke(AsyncResult asyncResult, RankingStats stats) { }

	// RVA: 0x1F2CAF0 Offset: 0x1F2CBF1 VA: 0x1F2CAF0 Slot: 14
	public virtual IAsyncResult BeginInvoke(AsyncResult asyncResult, RankingStats stats, AsyncCallback callback, object object) { }

	// RVA: 0x1F2CB90 Offset: 0x1F2CC91 VA: 0x1F2CB90 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
public sealed class Ranking.GetCachedTopXRankingCB : MulticastDelegate // TypeDefIndex: 14937
{
	// Methods

	// RVA: 0x1F2B5D0 Offset: 0x1F2B6D1 VA: 0x1F2B5D0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1F2B5F0 Offset: 0x1F2B6F1 VA: 0x1F2B5F0 Slot: 13
	public virtual void Invoke(AsyncResult asyncResult, RankingCachedResult info) { }

	// RVA: 0x1F2B960 Offset: 0x1F2BA61 VA: 0x1F2B960 Slot: 14
	public virtual IAsyncResult BeginInvoke(AsyncResult asyncResult, RankingCachedResult info, AsyncCallback callback, object object) { }

	// RVA: 0x1F2B990 Offset: 0x1F2BA91 VA: 0x1F2B990 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
public sealed class Ranking.GetCachedTopXRankingsCB : MulticastDelegate // TypeDefIndex: 14938
{
	// Methods

	// RVA: 0x1F2B9A0 Offset: 0x1F2BAA1 VA: 0x1F2B9A0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1F2B9C0 Offset: 0x1F2BAC1 VA: 0x1F2B9C0 Slot: 13
	public virtual void Invoke(AsyncResult asyncResult, List<RankingCachedResult> info) { }

	// RVA: 0x1F2BD30 Offset: 0x1F2BE31 VA: 0x1F2BD30 Slot: 14
	public virtual IAsyncResult BeginInvoke(AsyncResult asyncResult, List<RankingCachedResult> info, AsyncCallback callback, object object) { }

	// RVA: 0x1F2BD60 Offset: 0x1F2BE61 VA: 0x1F2BD60 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
public enum Ranking2.Ranking2SortFlags // TypeDefIndex: 14940
{
	// Fields
	public int value__; // 0x0
	public const Ranking2.Ranking2SortFlags NOTHING = 0;
	public const Ranking2.Ranking2SortFlags MOVE_TO_TOP_IN_TIE = 4;
}

// Namespace: 
public enum Ranking2.Ranking2GetOptionFlags // TypeDefIndex: 14941
{
	// Fields
	public int value__; // 0x0
	public const Ranking2.Ranking2GetOptionFlags NOTHING = 0;
}

// Namespace: 
public enum Ranking2.Ranking2Mode // TypeDefIndex: 14942
{
	// Fields
	public byte value__; // 0x0
	public const Ranking2.Ranking2Mode USER_RANKING = 0;
	public const Ranking2.Ranking2Mode NEAR_RANKING = 1;
	public const Ranking2.Ranking2Mode RANGE_RANKING = 2;
	public const Ranking2.Ranking2Mode FRIEND_RANKING = 3;
	public const Ranking2.Ranking2Mode MIN = 0;
	public const Ranking2.Ranking2Mode MAX = 3;
}

// Namespace: 
public enum Ranking2.Ranking2ResetMode // TypeDefIndex: 14943
{
	// Fields
	public byte value__; // 0x0
	public const Ranking2.Ranking2ResetMode NOTHING = 0;
	public const Ranking2.Ranking2ResetMode EVERYDAY = 1;
	public const Ranking2.Ranking2ResetMode EVERYWEEK = 2;
	public const Ranking2.Ranking2ResetMode MULTI_MONTH = 3;
	public const Ranking2.Ranking2ResetMode MULTI_MONTH_WEEKDAY = 4;
	public const Ranking2.Ranking2ResetMode MIN = 0;
	public const Ranking2.Ranking2ResetMode MAX = 4;
}

// Namespace: 
public sealed class Ranking2.GetCommonDataCB : MulticastDelegate // TypeDefIndex: 14944
{
	// Methods

	// RVA: 0x1F2CF70 Offset: 0x1F2D071 VA: 0x1F2CF70
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1F2CF90 Offset: 0x1F2D091 VA: 0x1F2CF90 Slot: 13
	public virtual void Invoke(AsyncResult asyncResult, Ranking2CommonData data) { }

	// RVA: 0x1F2D300 Offset: 0x1F2D401 VA: 0x1F2D300 Slot: 14
	public virtual IAsyncResult BeginInvoke(AsyncResult asyncResult, Ranking2CommonData data, AsyncCallback callback, object object) { }

	// RVA: 0x1F2D330 Offset: 0x1F2D431 VA: 0x1F2D330 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
public sealed class Ranking2.GetRankingCB : MulticastDelegate // TypeDefIndex: 14945
{
	// Methods

	// RVA: 0x1F2E0D0 Offset: 0x1F2E1D1 VA: 0x1F2E0D0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1F2E0F0 Offset: 0x1F2E1F1 VA: 0x1F2E0F0 Slot: 13
	public virtual void Invoke(AsyncResult asyncResult, Ranking2Info info) { }

	// RVA: 0x1F2E460 Offset: 0x1F2E561 VA: 0x1F2E460 Slot: 14
	public virtual IAsyncResult BeginInvoke(AsyncResult asyncResult, Ranking2Info info, AsyncCallback callback, object object) { }

	// RVA: 0x1F2E490 Offset: 0x1F2E591 VA: 0x1F2E490 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
public sealed class Ranking2.GetCategorySettingCB : MulticastDelegate // TypeDefIndex: 14946
{
	// Methods

	// RVA: 0x1F2CBA0 Offset: 0x1F2CCA1 VA: 0x1F2CBA0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1F2CBC0 Offset: 0x1F2CCC1 VA: 0x1F2CBC0 Slot: 13
	public virtual void Invoke(AsyncResult asyncResult, Ranking2CategorySetting setting) { }

	// RVA: 0x1F2CF30 Offset: 0x1F2D031 VA: 0x1F2CF30 Slot: 14
	public virtual IAsyncResult BeginInvoke(AsyncResult asyncResult, Ranking2CategorySetting setting, AsyncCallback callback, object object) { }

	// RVA: 0x1F2CF60 Offset: 0x1F2D061 VA: 0x1F2CF60 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
public sealed class Ranking2.GetRanking2ChartInfoCB : MulticastDelegate // TypeDefIndex: 14947
{
	// Methods

	// RVA: 0x1F2D340 Offset: 0x1F2D441 VA: 0x1F2D340
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1F2D360 Offset: 0x1F2D461 VA: 0x1F2D360 Slot: 13
	public virtual void Invoke(AsyncResult asyncResult, Ranking2ChartInfo info) { }

	// RVA: 0x1F2D6D0 Offset: 0x1F2D7D1 VA: 0x1F2D6D0 Slot: 14
	public virtual IAsyncResult BeginInvoke(AsyncResult asyncResult, Ranking2ChartInfo info, AsyncCallback callback, object object) { }

	// RVA: 0x1F2D700 Offset: 0x1F2D801 VA: 0x1F2D700 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
public sealed class Ranking2.GetRanking2ChartInfoListCB : MulticastDelegate // TypeDefIndex: 14948
{
	// Methods

	// RVA: 0x1F2D710 Offset: 0x1F2D811 VA: 0x1F2D710
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1F2D730 Offset: 0x1F2D831 VA: 0x1F2D730 Slot: 13
	public virtual void Invoke(AsyncResult asyncResult, List<Ranking2ChartInfo> info) { }

	// RVA: 0x1F2DAA0 Offset: 0x1F2DBA1 VA: 0x1F2DAA0 Slot: 14
	public virtual IAsyncResult BeginInvoke(AsyncResult asyncResult, List<Ranking2ChartInfo> info, AsyncCallback callback, object object) { }

	// RVA: 0x1F2DAD0 Offset: 0x1F2DBD1 VA: 0x1F2DAD0 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
public sealed class Ranking2.GetRanking2EstimateScoreRankCB : MulticastDelegate // TypeDefIndex: 14949
{
	// Methods

	// RVA: 0x1F2DAE0 Offset: 0x1F2DBE1 VA: 0x1F2DAE0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1F2DB00 Offset: 0x1F2DC01 VA: 0x1F2DB00 Slot: 13
	public virtual void Invoke(AsyncResult asyncResult, Ranking2EstimateScoreRankOutput info) { }

	// RVA: 0x1F2E020 Offset: 0x1F2E121 VA: 0x1F2E020 Slot: 14
	public virtual IAsyncResult BeginInvoke(AsyncResult asyncResult, Ranking2EstimateScoreRankOutput info, AsyncCallback callback, object object) { }

	// RVA: 0x1F2E0C0 Offset: 0x1F2E1C1 VA: 0x1F2E0C0 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

