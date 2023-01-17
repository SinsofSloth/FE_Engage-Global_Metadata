// Namespace: 
private class EngageSequence.Cast : IDisposable // TypeDefIndex: 8735
{
	// Fields
	public Unit Unit; // 0x10
	public GodUnit God; // 0x18
	public CharacterGameStatus GameStatus; // 0x20
	public Character Character; // 0x28

	// Methods

	// RVA: 0x1F049C0 Offset: 0x1F04AC1 VA: 0x1F049C0
	public void .ctor(Unit unit) { }

	// RVA: 0x1F04A50 Offset: 0x1F04B51 VA: 0x1F04A50
	public void .ctor(GodUnit god) { }

	// RVA: 0x1F04510 Offset: 0x1F04611 VA: 0x1F04510
	public void Import(string[] conditions) { }

	// RVA: 0x1F03B00 Offset: 0x1F03C01 VA: 0x1F03B00 Slot: 4
	public void Dispose() { }
}

// Namespace: 
public enum EngageSequence.Mode // TypeDefIndex: 8736
{
	// Fields
	public int value__; // 0x0
	public const EngageSequence.Mode NotWork = 0;
	public const EngageSequence.Mode Engage = 1;
	public const EngageSequence.Mode EngagePlus = 2;
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x274560 Offset: 0x274661 VA: 0x274560
[Serializable]
private sealed class EngageSequence.<>c // TypeDefIndex: 8737
{
	// Fields
	public static readonly EngageSequence.<>c <>9; // 0x0
	public static ProcVoidFunction <>9__4_0; // 0x8

	// Methods

	// RVA: 0x1F035E0 Offset: 0x1F036E1 VA: 0x1F035E0
	private static void .cctor() { }

	// RVA: 0x1F03650 Offset: 0x1F03751 VA: 0x1F03650
	public void .ctor() { }

	// RVA: 0x1F03660 Offset: 0x1F03761 VA: 0x1F03660
	internal void <CreateBind>b__4_0(ProcInst _) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x274570 Offset: 0x274671 VA: 0x274570
private sealed class EngageSequence.<WaitFinish>d__14 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 8738
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public EngageSequence <>4__this; // 0x20

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x2AC720 Offset: 0x2AC821 VA: 0x2AC720
	// RVA: 0x1F045B0 Offset: 0x1F046B1 VA: 0x1F045B0
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x2AC730 Offset: 0x2AC831 VA: 0x2AC730
	// RVA: 0x1F045E0 Offset: 0x1F046E1 VA: 0x1F045E0 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1F045F0 Offset: 0x1F046F1 VA: 0x1F045F0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x2AC740 Offset: 0x2AC841 VA: 0x2AC740
	// RVA: 0x1F04960 Offset: 0x1F04A61 VA: 0x1F04960 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x2AC750 Offset: 0x2AC851 VA: 0x2AC750
	// RVA: 0x1F04970 Offset: 0x1F04A71 VA: 0x1F04970 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x2AC760 Offset: 0x2AC861 VA: 0x2AC760
	// RVA: 0x1F049B0 Offset: 0x1F04AB1 VA: 0x1F049B0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x274580 Offset: 0x274681 VA: 0x274580
private sealed class EngageSequence.<LoadAndSetupAndRun>d__16 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 8739
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public EngageSequence <>4__this; // 0x20
	private Character <chr>5__2; // 0x28
	private Character <ghr>5__3; // 0x30

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x2AC770 Offset: 0x2AC871 VA: 0x2AC770
	// RVA: 0x1F03C40 Offset: 0x1F03D41 VA: 0x1F03C40
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x2AC780 Offset: 0x2AC881 VA: 0x2AC780
	// RVA: 0x1F03C70 Offset: 0x1F03D71 VA: 0x1F03C70 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1F03C80 Offset: 0x1F03D81 VA: 0x1F03C80 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x2AC790 Offset: 0x2AC891 VA: 0x2AC790
	// RVA: 0x1F04550 Offset: 0x1F04651 VA: 0x1F04550 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x2AC7A0 Offset: 0x2AC8A1 VA: 0x2AC7A0
	// RVA: 0x1F04560 Offset: 0x1F04661 VA: 0x1F04560 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x2AC7B0 Offset: 0x2AC8B1 VA: 0x2AC7B0
	// RVA: 0x1F045A0 Offset: 0x1F046A1 VA: 0x1F045A0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x274590 Offset: 0x274691 VA: 0x274590
private sealed class EngageSequence.<Exit>d__18 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 8740
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public EngageSequence <>4__this; // 0x20

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x2AC7C0 Offset: 0x2AC8C1 VA: 0x2AC7C0
	// RVA: 0x1F036D0 Offset: 0x1F037D1 VA: 0x1F036D0
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x2AC7D0 Offset: 0x2AC8D1 VA: 0x2AC7D0
	// RVA: 0x1F03700 Offset: 0x1F03801 VA: 0x1F03700 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1F03710 Offset: 0x1F03811 VA: 0x1F03710 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x2AC7E0 Offset: 0x2AC8E1 VA: 0x2AC7E0
	// RVA: 0x1F03BE0 Offset: 0x1F03CE1 VA: 0x1F03BE0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x2AC7F0 Offset: 0x2AC8F1 VA: 0x2AC7F0
	// RVA: 0x1F03BF0 Offset: 0x1F03CF1 VA: 0x1F03BF0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x2AC800 Offset: 0x2AC901 VA: 0x2AC800
	// RVA: 0x1F03C30 Offset: 0x1F03D31 VA: 0x1F03C30 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

