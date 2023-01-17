// Namespace: 
public enum Relay.Modes // TypeDefIndex: 12923
{
	// Fields
	public int value__; // 0x0
	public const Relay.Modes New = 0;
	public const Relay.Modes TakeOver = 1;
	public const Relay.Modes Replay = 2;
}

// Namespace: 
public enum Relay.TakeOverModes // TypeDefIndex: 12924
{
	// Fields
	public int value__; // 0x0
	public const Relay.TakeOverModes Random = 0;
	public const Relay.TakeOverModes DataCode = 1;
}

// Namespace: 
public enum Relay.CstoResult // TypeDefIndex: 12925
{
	// Fields
	public int value__; // 0x0
	public const Relay.CstoResult Ok = 0;
	public const Relay.CstoResult NgEnd = 1;
	public const Relay.CstoResult NgOtherPlaying = 2;
	public const Relay.CstoResult NgAlreadyPlayed = 3;
	public const Relay.CstoResult NgLackOfUnit = 4;
	public const Relay.CstoResult NgUnknown = 5;
}

// Namespace: 
public enum Relay.TrfrResult // TypeDefIndex: 12926
{
	// Fields
	public int value__; // 0x0
	public const Relay.TrfrResult NoChanged = 0;
	public const Relay.TrfrResult Done = 1;
	public const Relay.TrfrResult Failed = 2;
}

// Namespace: 
[FlagsAttribute] // RVA: 0x278820 Offset: 0x278921 VA: 0x278820
public enum Relay.Flags // TypeDefIndex: 12927
{
	// Fields
	public int value__; // 0x0
	public const Relay.Flags NeedToUpload = 1;
	public const Relay.Flags Uploaded = 2;
	public const Relay.Flags GlobalSaved = 4;
	public const Relay.Flags ShowWinRule = 8;
}

// Namespace: 
public sealed class Relay.FlagsField : BitFieldTemplate32<Relay.Flags> // TypeDefIndex: 12928
{
	// Methods

	// RVA: 0x1F3D9B0 Offset: 0x1F3DAB1 VA: 0x1F3D9B0 Slot: 5
	protected override int ToInt(Relay.Flags value) { }

	// RVA: 0x1F3D9C0 Offset: 0x1F3DAC1 VA: 0x1F3D9C0
	public void .ctor() { }
}

// Namespace: 
private struct Relay.ChooseAwardeeData // TypeDefIndex: 12929
{
	// Fields
	public Unit unit; // 0x0
	public RelayLeavingUnitData leavingUnitData; // 0x8
	public int count; // 0x10

	// Methods

	// RVA: 0x1F3CCD0 Offset: 0x1F3CDD1 VA: 0x1F3CCD0
	public void CompareAndSwap(Unit unit, int count, RelayAwardData.CompareOp op) { }

	// RVA: 0x1F3D090 Offset: 0x1F3D191 VA: 0x1F3D090
	public void CompareAndSwap(RelayLeavingUnitData leavingUnitData, int count, RelayAwardData.CompareOp op) { }

	// RVA: 0x1F3CFD0 Offset: 0x1F3D0D1 VA: 0x1F3CFD0
	private bool Compare(int count, RelayAwardData.CompareOp op) { }

	// RVA: 0x1F3D110 Offset: 0x1F3D211 VA: 0x1F3D110
	private bool CompareGreater(int count) { }

	// RVA: 0x1F3D170 Offset: 0x1F3D271 VA: 0x1F3D170
	private bool CompareLess(int count) { }

	// RVA: 0x1F3D1D0 Offset: 0x1F3D2D1 VA: 0x1F3D1D0
	private bool CompareZero(int count) { }

	// RVA: 0x1F3D240 Offset: 0x1F3D341 VA: 0x1F3D240
	private bool IsRandom() { }

	// RVA: 0x1F3D220 Offset: 0x1F3D321 VA: 0x1F3D220
	public bool IsValid() { }
}

// Namespace: 
private enum Relay.DisposPlayerCountsSequence.Label // TypeDefIndex: 12930
{
	// Fields
	public int value__; // 0x0
	public const Relay.DisposPlayerCountsSequence.Label Loading = 0;
	public const Relay.DisposPlayerCountsSequence.Label End = 1;
}

// Namespace: 
private class Relay.DisposPlayerCountsSequence : ProcInst // TypeDefIndex: 12931
{
	// Fields
	private int m_Index; // 0x70
	private string m_Cid; // 0x78

	// Methods

	// RVA: 0x1F3D270 Offset: 0x1F3D371 VA: 0x1F3D270
	private void LoadFirst() { }

	// RVA: 0x1F3D380 Offset: 0x1F3D481 VA: 0x1F3D380
	private void LoadDone() { }

	// RVA: 0x1F3D570 Offset: 0x1F3D671 VA: 0x1F3D570
	private ChapterData GetChapter() { }

	// RVA: 0x1F3D330 Offset: 0x1F3D431 VA: 0x1F3D330
	private bool Load() { }

	// RVA: 0x1F3D680 Offset: 0x1F3D781 VA: 0x1F3D680
	public static void CreateBind(ProcInst super) { }

	// RVA: 0x1F3D9A0 Offset: 0x1F3DAA1 VA: 0x1F3D9A0
	public void .ctor() { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x278830 Offset: 0x278931 VA: 0x278830
private sealed class Relay.<>c__DisplayClass42_0 // TypeDefIndex: 12932
{
	// Fields
	public int workUnitCount; // 0x10
	public List<string> pids; // 0x18
	public int workNoSortieUnitCount; // 0x20

	// Methods

	// RVA: 0x1F3CD50 Offset: 0x1F3CE51 VA: 0x1F3CD50
	public void .ctor() { }

	// RVA: 0x1F3CD60 Offset: 0x1F3CE61 VA: 0x1F3CD60
	internal void <GetPlayerUnitCount>b__0(Unit unit) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x278840 Offset: 0x278941 VA: 0x278840
[Serializable]
private sealed class Relay.<>c // TypeDefIndex: 12933
{
	// Fields
	public static readonly Relay.<>c <>9; // 0x0
	public static Comparison<Unit> <>9__43_2; // 0x8
	public static Comparison<Unit> <>9__43_1; // 0x10
	public static Action<Unit> <>9__44_0; // 0x18
	public static Action<Unit> <>9__99_0; // 0x20

	// Methods

	// RVA: 0x1F3C7F0 Offset: 0x1F3C8F1 VA: 0x1F3C7F0
	private static void .cctor() { }

	// RVA: 0x1F3C860 Offset: 0x1F3C961 VA: 0x1F3C860
	public void .ctor() { }

	// RVA: 0x1F3C870 Offset: 0x1F3C971 VA: 0x1F3C870
	internal int <DecideToBattle>b__43_2(Unit a, Unit b) { }

	// RVA: 0x1F3C8B0 Offset: 0x1F3C9B1 VA: 0x1F3C8B0
	internal int <DecideToBattle>b__43_1(Unit a, Unit b) { }

	// RVA: 0x1F3C970 Offset: 0x1F3CA71 VA: 0x1F3C970
	internal void <MapBegin>b__44_0(Unit unit) { }

	// RVA: 0x1F3C980 Offset: 0x1F3CA81 VA: 0x1F3C980
	internal void <DeleteUnneededUnits>b__99_0(Unit unit) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x278850 Offset: 0x278951 VA: 0x278850
private sealed class Relay.<>c__DisplayClass56_0 // TypeDefIndex: 12934
{
	// Fields
	public Dictionary<string, RelayAwardeeData> awardees; // 0x10
	public RelayAwardData.Kinds kind; // 0x18

	// Methods

	// RVA: 0x1F3CE00 Offset: 0x1F3CF01 VA: 0x1F3CE00
	public void .ctor() { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x278860 Offset: 0x278961 VA: 0x278860
private sealed class Relay.<>c__DisplayClass56_1 // TypeDefIndex: 12935
{
	// Fields
	public bool isAdded; // 0x10
	public int index; // 0x14
	public Relay.<>c__DisplayClass56_0 CS$<>8__locals1; // 0x18

	// Methods

	// RVA: 0x1F3CE10 Offset: 0x1F3CF11 VA: 0x1F3CE10
	public void .ctor() { }

	// RVA: 0x1F3CE20 Offset: 0x1F3CF21 VA: 0x1F3CE20
	internal void <DbgFakeAwardee>b__0(Unit unit) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x278870 Offset: 0x278971 VA: 0x278870
private sealed class Relay.<>c__DisplayClass102_0 // TypeDefIndex: 12936
{
	// Fields
	public Relay.ChooseAwardeeData[] data; // 0x10

	// Methods

	// RVA: 0x1F3CA40 Offset: 0x1F3CB41 VA: 0x1F3CA40
	public void .ctor() { }

	// RVA: 0x1F3CA50 Offset: 0x1F3CB51 VA: 0x1F3CA50
	internal void <ChooseAwardee>b__0(Unit unit) { }
}

