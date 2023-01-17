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
public enum Ranking.UpdateMode // TypeDefIndex: 14928
{
	// Fields
	public int value__; // 0x0
	public const Ranking.UpdateMode UPDATE_MODE_NORMAL = 0;
	public const Ranking.UpdateMode UPDATE_MODE_DELETE_OLD = 1;
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

