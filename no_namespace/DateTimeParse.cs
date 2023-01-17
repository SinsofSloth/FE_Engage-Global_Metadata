// Namespace: 
internal sealed class DateTimeParse.MatchNumberDelegate : MulticastDelegate // TypeDefIndex: 226
{
	// Methods

	// RVA: 0x35E88B0 Offset: 0x35E89B1 VA: 0x35E88B0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x35E88D0 Offset: 0x35E89D1 VA: 0x35E88D0 Slot: 13
	public virtual bool Invoke(ref __DTString str, int digitLen, out int result) { }

	// RVA: 0x35E8B40 Offset: 0x35E8C41 VA: 0x35E8B40 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref __DTString str, int digitLen, out int result, AsyncCallback callback, object object) { }

	// RVA: 0x35E8C20 Offset: 0x35E8D21 VA: 0x35E8C20 Slot: 15
	public virtual bool EndInvoke(ref __DTString str, out int result, IAsyncResult __result) { }
}

// Namespace: 
internal enum DateTimeParse.DTT // TypeDefIndex: 227
{
	// Fields
	public int value__; // 0x0
	public const DateTimeParse.DTT End = 0;
	public const DateTimeParse.DTT NumEnd = 1;
	public const DateTimeParse.DTT NumAmpm = 2;
	public const DateTimeParse.DTT NumSpace = 3;
	public const DateTimeParse.DTT NumDatesep = 4;
	public const DateTimeParse.DTT NumTimesep = 5;
	public const DateTimeParse.DTT MonthEnd = 6;
	public const DateTimeParse.DTT MonthSpace = 7;
	public const DateTimeParse.DTT MonthDatesep = 8;
	public const DateTimeParse.DTT NumDatesuff = 9;
	public const DateTimeParse.DTT NumTimesuff = 10;
	public const DateTimeParse.DTT DayOfWeek = 11;
	public const DateTimeParse.DTT YearSpace = 12;
	public const DateTimeParse.DTT YearDateSep = 13;
	public const DateTimeParse.DTT YearEnd = 14;
	public const DateTimeParse.DTT TimeZone = 15;
	public const DateTimeParse.DTT Era = 16;
	public const DateTimeParse.DTT NumUTCTimeMark = 17;
	public const DateTimeParse.DTT Unk = 18;
	public const DateTimeParse.DTT NumLocalTimeMark = 19;
	public const DateTimeParse.DTT Max = 20;
}

// Namespace: 
internal enum DateTimeParse.TM // TypeDefIndex: 228
{
	// Fields
	public int value__; // 0x0
	public const DateTimeParse.TM NotSet = -1;
	public const DateTimeParse.TM AM = 0;
	public const DateTimeParse.TM PM = 1;
}

// Namespace: 
internal enum DateTimeParse.DS // TypeDefIndex: 229
{
	// Fields
	public int value__; // 0x0
	public const DateTimeParse.DS BEGIN = 0;
	public const DateTimeParse.DS N = 1;
	public const DateTimeParse.DS NN = 2;
	public const DateTimeParse.DS D_Nd = 3;
	public const DateTimeParse.DS D_NN = 4;
	public const DateTimeParse.DS D_NNd = 5;
	public const DateTimeParse.DS D_M = 6;
	public const DateTimeParse.DS D_MN = 7;
	public const DateTimeParse.DS D_NM = 8;
	public const DateTimeParse.DS D_MNd = 9;
	public const DateTimeParse.DS D_NDS = 10;
	public const DateTimeParse.DS D_Y = 11;
	public const DateTimeParse.DS D_YN = 12;
	public const DateTimeParse.DS D_YNd = 13;
	public const DateTimeParse.DS D_YM = 14;
	public const DateTimeParse.DS D_YMd = 15;
	public const DateTimeParse.DS D_S = 16;
	public const DateTimeParse.DS T_S = 17;
	public const DateTimeParse.DS T_Nt = 18;
	public const DateTimeParse.DS T_NNt = 19;
	public const DateTimeParse.DS ERROR = 20;
	public const DateTimeParse.DS DX_NN = 21;
	public const DateTimeParse.DS DX_NNN = 22;
	public const DateTimeParse.DS DX_MN = 23;
	public const DateTimeParse.DS DX_NM = 24;
	public const DateTimeParse.DS DX_MNN = 25;
	public const DateTimeParse.DS DX_DS = 26;
	public const DateTimeParse.DS DX_DSN = 27;
	public const DateTimeParse.DS DX_NDS = 28;
	public const DateTimeParse.DS DX_NNDS = 29;
	public const DateTimeParse.DS DX_YNN = 30;
	public const DateTimeParse.DS DX_YMN = 31;
	public const DateTimeParse.DS DX_YN = 32;
	public const DateTimeParse.DS DX_YM = 33;
	public const DateTimeParse.DS TX_N = 34;
	public const DateTimeParse.DS TX_NN = 35;
	public const DateTimeParse.DS TX_NNN = 36;
	public const DateTimeParse.DS TX_TS = 37;
	public const DateTimeParse.DS DX_NNY = 38;
}

