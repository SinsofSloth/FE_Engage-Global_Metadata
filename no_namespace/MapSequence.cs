// Namespace: 
public enum MapSequence.Label // TypeDefIndex: 12362
{
	// Fields
	public int value__; // 0x0
	public const MapSequence.Label Init = 0;
	public const MapSequence.Label Tick = 1;
	public const MapSequence.Label Sortie = 2;
	public const MapSequence.Label ResumeMap = 3;
	public const MapSequence.Label ResumeSortie = 4;
	public const MapSequence.Label SkipSortie = 5;
	public const MapSequence.Label MapStart = 6;
	public const MapSequence.Label MapBegin = 7;
	public const MapSequence.Label TurnBegin = 8;
	public const MapSequence.Label TurnBeginAfterRewind = 9;
	public const MapSequence.Label TurnBranch = 10;
	public const MapSequence.Label TurnBranchAfterRewind = 11;
	public const MapSequence.Label TurnHuman = 12;
	public const MapSequence.Label TurnAI = 13;
	public const MapSequence.Label TurnLink = 14;
	public const MapSequence.Label TurnReplay = 15;
	public const MapSequence.Label TurnEnd = 16;
	public const MapSequence.Label Complete = 17;
	public const MapSequence.Label GameOver = 18;
	public const MapSequence.Label RelayUnsettled = 19;
	public const MapSequence.Label SaveDataLoad = 20;
	public const MapSequence.Label RestartLoad = 21;
	public const MapSequence.Label RelayLoad = 22;
	public const MapSequence.Label RelayLoadError = 23;
	public const MapSequence.Label RelaySkipReplay = 24;
	public const MapSequence.Label RelayReplayToTakeOver = 25;
	public const MapSequence.Label VersusLoad = 26;
	public const MapSequence.Label VersusEdit = 27;
	public const MapSequence.Label End = 28;
	public const MapSequence.Label Tail = 29;
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x278480 Offset: 0x278581 VA: 0x278480
[Serializable]
private sealed class MapSequence.<>c__27<T> // TypeDefIndex: 12363
{
	// Fields
	public static readonly MapSequence.<>c__27<T> <>9; // 0x0
	public static Action<T> <>9__27_0; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B35CC0 Offset: 0x2B35DC1 VA: 0x2B35CC0
	|-MapSequence.<>c__27<object>..cctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B35DA0 Offset: 0x2B35EA1 VA: 0x2B35DA0
	|-MapSequence.<>c__27<object>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void <AddPreloadCombatAssets>b__27_0(T asset) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B35DB0 Offset: 0x2B35EB1 VA: 0x2B35DB0
	|-MapSequence.<>c__27<object>.<AddPreloadCombatAssets>b__27_0
	*/
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x278490 Offset: 0x278591 VA: 0x278490
private sealed class MapSequence.<TurnBeginMultiChange>d__53 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 12364
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public MapSequence <>4__this; // 0x20

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x2C8320 Offset: 0x2C8421 VA: 0x2C8320
	// RVA: 0x2414110 Offset: 0x2414211 VA: 0x2414110
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x2C8330 Offset: 0x2C8431 VA: 0x2C8330
	// RVA: 0x2414140 Offset: 0x2414241 VA: 0x2414140 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x2414150 Offset: 0x2414251 VA: 0x2414150 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x2C8340 Offset: 0x2C8441 VA: 0x2C8340
	// RVA: 0x24141B0 Offset: 0x24142B1 VA: 0x24141B0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x2C8350 Offset: 0x2C8451 VA: 0x2C8350
	// RVA: 0x24141C0 Offset: 0x24142C1 VA: 0x24141C0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x2C8360 Offset: 0x2C8461 VA: 0x2C8360
	// RVA: 0x2414200 Offset: 0x2414301 VA: 0x2414200 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x2784A0 Offset: 0x2785A1 VA: 0x2784A0
private sealed class MapSequence.<>c__DisplayClass74_0 // TypeDefIndex: 12365
{
	// Fields
	public Dictionary<Unit, int> expDict; // 0x10
	public int exp; // 0x18

	// Methods

	// RVA: 0x2414040 Offset: 0x2414141 VA: 0x2414040
	public void .ctor() { }

	// RVA: 0x2414050 Offset: 0x2414151 VA: 0x2414050
	internal void <GetEncountReward>b__0(Unit unit) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x2784B0 Offset: 0x2785B1 VA: 0x2784B0
[Serializable]
private sealed class MapSequence.<>c // TypeDefIndex: 12366
{
	// Fields
	public static readonly MapSequence.<>c <>9; // 0x0
	public static Action<Unit> <>9__96_0; // 0x8

	// Methods

	// RVA: 0x2413E80 Offset: 0x2413F81 VA: 0x2413E80
	private static void .cctor() { }

	// RVA: 0x2413EF0 Offset: 0x2413FF1 VA: 0x2413EF0
	public void .ctor() { }

	// RVA: 0x2413F00 Offset: 0x2414001 VA: 0x2413F00
	internal void <RelayLoad>b__96_0(Unit unit) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x2784C0 Offset: 0x2785C1 VA: 0x2784C0
private sealed class MapSequence.<>c__DisplayClass100_0 // TypeDefIndex: 12367
{
	// Fields
	public RelayStampData data; // 0x10

	// Methods

	// RVA: 0x2413F10 Offset: 0x2414011 VA: 0x2413F10
	public void .ctor() { }

	// RVA: 0x2413F20 Offset: 0x2414021 VA: 0x2413F20
	internal void <RelayMessageShow>b__0(GameObject go) { }
}

