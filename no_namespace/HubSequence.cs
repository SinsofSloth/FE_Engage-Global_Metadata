// Namespace: 
public enum HubSequence.Label // TypeDefIndex: 10780
{
	// Fields
	public int value__; // 0x0
	public const HubSequence.Label None = 0;
	public const HubSequence.Label Init = 1;
	public const HubSequence.Label Reload = 2;
	public const HubSequence.Label Main = 3;
	public const HubSequence.Label Talk = 4;
	public const HubSequence.Label Script = 5;
	public const HubSequence.Label FastTravel = 6;
	public const HubSequence.Label Mascot = 7;
	public const HubSequence.Label Arena = 8;
	public const HubSequence.Label Pedestal = 9;
	public const HubSequence.Label DragonRide = 10;
	public const HubSequence.Label Fishing = 11;
	public const HubSequence.Label MuscleExercise = 12;
	public const HubSequence.Label RingCleaning = 13;
	public const HubSequence.Label FortuneTelling = 14;
	public const HubSequence.Label Signboard = 15;
	public const HubSequence.Label Jukebox = 16;
	public const HubSequence.Label RestPlace = 17;
	public const HubSequence.Label Chest = 18;
	public const HubSequence.Label Amiibo = 19;
	public const HubSequence.Label CapeTower = 20;
	public const HubSequence.Label Animal = 21;
	public const HubSequence.Label Photo = 22;
	public const HubSequence.Label Well = 23;
	public const HubSequence.Label Pool = 24;
	public const HubSequence.Label Fruit = 25;
	public const HubSequence.Label Horse = 26;
	public const HubSequence.Label EndRoll = 27;
	public const HubSequence.Label FleaMarket = 28;
	public const HubSequence.Label CallScript = 29;
	public const HubSequence.Label KizunaExit = 30;
	public const HubSequence.Label LastChapter = 31;
	public const HubSequence.Label Exit = 32;
	public const HubSequence.Label End = 33;
	public const HubSequence.Label Tail = 34;
	public const HubSequence.Label SaveDataLoad = 35;
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x2772A0 Offset: 0x2773A1 VA: 0x2772A0
private sealed class HubSequence.AreaString.<>c__DisplayClass3_0 // TypeDefIndex: 10781
{
	// Fields
	public string value; // 0x10

	// Methods

	// RVA: 0x1DD03F0 Offset: 0x1DD04F1 VA: 0x1DD03F0
	public void .ctor() { }

	// RVA: 0x1DD0400 Offset: 0x1DD0501 VA: 0x1DD0400
	internal bool <Pop>b__0(string a) { }
}

// Namespace: 
public class HubSequence.AreaString // TypeDefIndex: 10782
{
	// Fields
	private List<string> m_value; // 0x10
	private string m_lastValue; // 0x18

	// Methods

	// RVA: 0x35F6A70 Offset: 0x35F6B71 VA: 0x35F6A70
	public void Push(string value) { }

	// RVA: 0x35F6B10 Offset: 0x35F6C11 VA: 0x35F6B10
	public void Pop(string value) { }

	// RVA: 0x35F6C10 Offset: 0x35F6D11 VA: 0x35F6C10
	public void Clear() { }

	// RVA: 0x35F6C70 Offset: 0x35F6D71 VA: 0x35F6C70 Slot: 3
	public override string ToString() { }

	// RVA: 0x35F6CF0 Offset: 0x35F6DF1 VA: 0x35F6CF0
	public void .ctor() { }
}

// Namespace: 
private class HubSequence.ConfirmEndRollDialogItemYes : BasicDialogItemYes // TypeDefIndex: 10783
{
	// Methods

	// RVA: 0x35F6F10 Offset: 0x35F7011 VA: 0x35F6F10
	public void .ctor() { }

	// RVA: 0x35F6FA0 Offset: 0x35F70A1 VA: 0x35F6FA0 Slot: 18
	public override BasicMenu.Result ACall() { }

	// RVA: 0x35F6FB0 Offset: 0x35F70B1 VA: 0x35F6FB0 Slot: 19
	public override BasicMenu.Result BCall() { }
}

// Namespace: 
private class HubSequence.ConfirmEndRollDialogItemNo : BasicDialogItemNo // TypeDefIndex: 10784
{
	// Methods

	// RVA: 0x35F6D80 Offset: 0x35F6E81 VA: 0x35F6D80 Slot: 18
	public override BasicMenu.Result ACall() { }

	// RVA: 0x35F6E40 Offset: 0x35F6F41 VA: 0x35F6E40 Slot: 19
	public override BasicMenu.Result BCall() { }

	// RVA: 0x35F6F00 Offset: 0x35F7001 VA: 0x35F6F00
	public void .ctor() { }
}

// Namespace: 
private class HubSequence.LastChapterMenu.GoToMenuItem : BasicMenuItem // TypeDefIndex: 10785
{
	// Methods

	// RVA: 0x1DD0420 Offset: 0x1DD0521 VA: 0x1DD0420 Slot: 4
	public override string GetName() { }

	// RVA: 0x1DD04A0 Offset: 0x1DD05A1 VA: 0x1DD04A0 Slot: 18
	public override BasicMenu.Result ACall() { }

	// RVA: 0x1DD0600 Offset: 0x1DD0701 VA: 0x1DD0600
	public void .ctor() { }
}

// Namespace: 
private class HubSequence.LastChapterMenu.RankingMenuItem.ConfirmDialog.YesMenuItem : BasicDialogItemYes // TypeDefIndex: 10786
{
	// Fields
	private NetEnableSequence.ResultFunction m_ResultFunc; // 0x70

	// Methods

	// RVA: 0x2D74B50 Offset: 0x2D74C51 VA: 0x2D74B50
	public void .ctor(NetEnableSequence.ResultFunction resultFunc) { }

	// RVA: 0x2D7F2D0 Offset: 0x2D7F3D1 VA: 0x2D7F2D0 Slot: 4
	public override string GetName() { }

	// RVA: 0x2D7F350 Offset: 0x2D7F451 VA: 0x2D7F350 Slot: 18
	public override BasicMenu.Result ACall() { }
}

// Namespace: 
private class HubSequence.LastChapterMenu.RankingMenuItem.ConfirmDialog.NoMenuItem : BasicDialogItemNo // TypeDefIndex: 10787
{
	// Methods

	// RVA: 0x2D7F250 Offset: 0x2D7F351 VA: 0x2D7F250 Slot: 4
	public override string GetName() { }

	// RVA: 0x2D74B90 Offset: 0x2D74C91 VA: 0x2D74B90
	public void .ctor() { }
}

// Namespace: 
private static class HubSequence.LastChapterMenu.RankingMenuItem.ConfirmDialog // TypeDefIndex: 10788
{
	// Methods

	// RVA: 0x2D74A40 Offset: 0x2D74B41 VA: 0x2D74A40
	public static void CreateBind(ProcInst super, NetEnableSequence.ResultFunction resultFunc) { }
}

// Namespace: 
private class HubSequence.LastChapterMenu.RankingMenuItem : BasicMenuItem // TypeDefIndex: 10789
{
	// Methods

	// RVA: 0x1DD0610 Offset: 0x1DD0711 VA: 0x1DD0610 Slot: 4
	public override string GetName() { }

	// RVA: 0x1DD0690 Offset: 0x1DD0791 VA: 0x1DD0690 Slot: 18
	public override BasicMenu.Result ACall() { }

	// RVA: 0x1DD08A0 Offset: 0x1DD09A1 VA: 0x1DD08A0
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C15F0 Offset: 0x2C16F1 VA: 0x2C15F0
	// RVA: 0x1DD08B0 Offset: 0x1DD09B1 VA: 0x1DD08B0
	private void <ACall>b__1_0(bool isEnable) { }
}

// Namespace: 
private class HubSequence.LastChapterMenu : BasicMenu // TypeDefIndex: 10790
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x2951B0 Offset: 0x2952B1 VA: 0x2951B0
	private static readonly BasicMenuSelect <CurrentMenuSelect>k__BackingField; // 0x0

	// Properties
	public static BasicMenuSelect CurrentMenuSelect { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2C15E0 Offset: 0x2C16E1 VA: 0x2C15E0
	// RVA: 0x35F7290 Offset: 0x35F7391 VA: 0x35F7290
	public static BasicMenuSelect get_CurrentMenuSelect() { }

	// RVA: 0x35F7300 Offset: 0x35F7401 VA: 0x35F7300
	protected void .ctor(List<BasicMenuItem> menuItemList, ProcInst super) { }

	// RVA: 0x35F7340 Offset: 0x35F7441 VA: 0x35F7340 Slot: 30
	public override string GetName() { }

	// RVA: 0x35F7390 Offset: 0x35F7491 VA: 0x35F7390
	public static void CreateBind(ProcInst super) { }

	// RVA: 0x35F75B0 Offset: 0x35F76B1 VA: 0x35F75B0
	private static void .cctor() { }
}

// Namespace: 
private class HubSequence.LastChapterGoToMenuItem : BasicMenuItem // TypeDefIndex: 10791
{
	// Methods

	// RVA: 0x35F7070 Offset: 0x35F7171 VA: 0x35F7070 Slot: 4
	public override string GetName() { }

	// RVA: 0x35F70F0 Offset: 0x35F71F1 VA: 0x35F70F0 Slot: 18
	public override BasicMenu.Result ACall() { }

	// RVA: 0x35F7280 Offset: 0x35F7381 VA: 0x35F7280
	public void .ctor() { }
}

// Namespace: 
private class HubSequence.LastChapterRankingMenuItem : BasicMenuItem // TypeDefIndex: 10792
{
	// Methods

	// RVA: 0x35F7630 Offset: 0x35F7731 VA: 0x35F7630 Slot: 4
	public override string GetName() { }

	// RVA: 0x35F76B0 Offset: 0x35F77B1 VA: 0x35F76B0 Slot: 18
	public override BasicMenu.Result ACall() { }

	// RVA: 0x35F7840 Offset: 0x35F7941 VA: 0x35F7840
	public void .ctor() { }
}

// Namespace: 
public enum HubSequence.LastChapterSequence.Label // TypeDefIndex: 10793
{
	// Fields
	public int value__; // 0x0
	public const HubSequence.LastChapterSequence.Label Menu = 0;
	public const HubSequence.LastChapterSequence.Label GoTo = 1;
	public const HubSequence.LastChapterSequence.Label Ranking = 2;
	public const HubSequence.LastChapterSequence.Label End = 3;
}

// Namespace: 
private class HubSequence.LastChapterSequence.ConfirmGotoLastDialogItemYes : BasicDialogItemYes // TypeDefIndex: 10794
{
	// Methods

	// RVA: 0x1DD0BC0 Offset: 0x1DD0CC1 VA: 0x1DD0BC0
	public void .ctor() { }

	// RVA: 0x1DD0C50 Offset: 0x1DD0D51 VA: 0x1DD0C50 Slot: 18
	public override BasicMenu.Result ACall() { }

	// RVA: 0x1DD0CC0 Offset: 0x1DD0DC1 VA: 0x1DD0CC0 Slot: 19
	public override BasicMenu.Result BCall() { }
}

// Namespace: 
private class HubSequence.LastChapterSequence.ConfirmDialogItemNo : BasicDialogItemNo // TypeDefIndex: 10795
{
	// Methods

	// RVA: 0x1DD0B20 Offset: 0x1DD0C21 VA: 0x1DD0B20
	public void .ctor() { }

	// RVA: 0x1DD0BB0 Offset: 0x1DD0CB1 VA: 0x1DD0BB0 Slot: 19
	public override BasicMenu.Result BCall() { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x2772B0 Offset: 0x2773B1 VA: 0x2772B0
[Serializable]
private sealed class HubSequence.LastChapterSequence.<>c // TypeDefIndex: 10796
{
	// Fields
	public static readonly HubSequence.LastChapterSequence.<>c <>9; // 0x0
	public static ProcBoolMethod <>9__10_0; // 0x8

	// Methods

	// RVA: 0x1DD0A30 Offset: 0x1DD0B31 VA: 0x1DD0A30
	private static void .cctor() { }

	// RVA: 0x1DD0AA0 Offset: 0x1DD0BA1 VA: 0x1DD0AA0
	public void .ctor() { }

	// RVA: 0x1DD0AB0 Offset: 0x1DD0BB1 VA: 0x1DD0AB0
	internal bool <CreateBind>b__10_0() { }
}

// Namespace: 
private class HubSequence.LastChapterSequence : SingletonProcInst<HubSequence.LastChapterSequence> // TypeDefIndex: 10797
{
	// Fields
	private static bool isGotoLastConfirm; // 0x0

	// Methods

	// RVA: 0x35F7850 Offset: 0x35F7951 VA: 0x35F7850
	private void Init() { }

	// RVA: 0x35F7980 Offset: 0x35F7A81 VA: 0x35F7980
	private void Exit() { }

	// RVA: 0x35F7A20 Offset: 0x35F7B21 VA: 0x35F7A20
	private void CreateMenu() { }

	// RVA: 0x35F7A90 Offset: 0x35F7B91 VA: 0x35F7A90
	private void CallLastChapterDemo() { }

	// RVA: 0x35F7C00 Offset: 0x35F7D01 VA: 0x35F7C00
	private void CreateConfirmDialog() { }

	// RVA: 0x35F7D30 Offset: 0x35F7E31 VA: 0x35F7D30
	private void CallLastChapter() { }

	// RVA: 0x35F7DD0 Offset: 0x35F7ED1 VA: 0x35F7DD0
	public static void CreateBind(ProcInst super) { }

	// RVA: 0x35F86D0 Offset: 0x35F87D1 VA: 0x35F86D0
	public void .ctor() { }

	// RVA: 0x35F8750 Offset: 0x35F8851 VA: 0x35F8750
	private static void .cctor() { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x2772C0 Offset: 0x2773C1 VA: 0x2772C0
private sealed class HubSequence.<SetupDispos>d__81 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 10798
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public HubSequence <>4__this; // 0x20
	private HubUtil.TimezoneType <timezoneType>5__2; // 0x28
	private IEnumerator <loadCharacters>5__3; // 0x30
	private GameObject <sound>5__4; // 0x38
	private GameObject <morning>5__5; // 0x40
	private GameObject <day>5__6; // 0x48
	private GameObject <evening>5__7; // 0x50
	private GameObject <night>5__8; // 0x58

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x2C1600 Offset: 0x2C1701 VA: 0x2C1600
	// RVA: 0x35F51E0 Offset: 0x35F52E1 VA: 0x35F51E0
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x2C1610 Offset: 0x2C1711 VA: 0x2C1610
	// RVA: 0x35F5210 Offset: 0x35F5311 VA: 0x35F5210 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x35F5220 Offset: 0x35F5321 VA: 0x35F5220 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x2C1620 Offset: 0x2C1721 VA: 0x2C1620
	// RVA: 0x35F5A40 Offset: 0x35F5B41 VA: 0x35F5A40 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x2C1630 Offset: 0x2C1731 VA: 0x2C1630
	// RVA: 0x35F5A50 Offset: 0x35F5B51 VA: 0x35F5A50 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x2C1640 Offset: 0x2C1741 VA: 0x2C1640
	// RVA: 0x35F5A90 Offset: 0x35F5B91 VA: 0x35F5A90 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x2772D0 Offset: 0x2773D1 VA: 0x2772D0
private sealed class HubSequence.<SetupEnv>d__82 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 10799
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public HubSequence <>4__this; // 0x20
	private IEnumerator <func>5__2; // 0x28

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x2C1650 Offset: 0x2C1751 VA: 0x2C1650
	// RVA: 0x35F5AA0 Offset: 0x35F5BA1 VA: 0x35F5AA0
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x2C1660 Offset: 0x2C1761 VA: 0x2C1660
	// RVA: 0x35F5AD0 Offset: 0x35F5BD1 VA: 0x35F5AD0 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x35F5AE0 Offset: 0x35F5BE1 VA: 0x35F5AE0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x2C1670 Offset: 0x2C1771 VA: 0x2C1670
	// RVA: 0x35F5D90 Offset: 0x35F5E91 VA: 0x35F5D90 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x2C1680 Offset: 0x2C1781 VA: 0x2C1680
	// RVA: 0x35F5DA0 Offset: 0x35F5EA1 VA: 0x35F5DA0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x2C1690 Offset: 0x2C1791 VA: 0x2C1690
	// RVA: 0x35F5DE0 Offset: 0x35F5EE1 VA: 0x35F5DE0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x2772E0 Offset: 0x2773E1 VA: 0x2772E0
private sealed class HubSequence.<SetupPlayer>d__83 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 10800
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public HubSequence <>4__this; // 0x20

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x2C16A0 Offset: 0x2C17A1 VA: 0x2C16A0
	// RVA: 0x35F5DF0 Offset: 0x35F5EF1 VA: 0x35F5DF0
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x2C16B0 Offset: 0x2C17B1 VA: 0x2C16B0
	// RVA: 0x35F5E20 Offset: 0x35F5F21 VA: 0x35F5E20 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x35F5E30 Offset: 0x35F5F31 VA: 0x35F5E30 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x2C16C0 Offset: 0x2C17C1 VA: 0x2C16C0
	// RVA: 0x35F6360 Offset: 0x35F6461 VA: 0x35F6360 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x2C16D0 Offset: 0x2C17D1 VA: 0x2C16D0
	// RVA: 0x35F6370 Offset: 0x35F6471 VA: 0x35F6370 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x2C16E0 Offset: 0x2C17E1 VA: 0x2C16E0
	// RVA: 0x35F63B0 Offset: 0x35F64B1 VA: 0x35F63B0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x2772F0 Offset: 0x2773F1 VA: 0x2772F0
private sealed class HubSequence.<SetupAccess>d__92 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 10801
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public HubSequence <>4__this; // 0x20

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x2C16F0 Offset: 0x2C17F1 VA: 0x2C16F0
	// RVA: 0x35F5060 Offset: 0x35F5161 VA: 0x35F5060
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x2C1700 Offset: 0x2C1801 VA: 0x2C1700
	// RVA: 0x35F5090 Offset: 0x35F5191 VA: 0x35F5090 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x35F50A0 Offset: 0x35F51A1 VA: 0x35F50A0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x2C1710 Offset: 0x2C1811 VA: 0x2C1710
	// RVA: 0x35F5180 Offset: 0x35F5281 VA: 0x35F5180 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x2C1720 Offset: 0x2C1821 VA: 0x2C1720
	// RVA: 0x35F5190 Offset: 0x35F5291 VA: 0x35F5190 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x2C1730 Offset: 0x2C1831 VA: 0x2C1730
	// RVA: 0x35F51D0 Offset: 0x35F52D1 VA: 0x35F51D0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x277300 Offset: 0x277401 VA: 0x277300
private sealed class HubSequence.<>c__DisplayClass93_0 // TypeDefIndex: 10802
{
	// Fields
	public HubSequence <>4__this; // 0x10
	public GameObject parent; // 0x18

	// Methods

	// RVA: 0x35F4790 Offset: 0x35F4891 VA: 0x35F4790
	public void .ctor() { }

	// RVA: 0x35F47A0 Offset: 0x35F48A1 VA: 0x35F47A0
	internal void <LoadAPlusGift>b__0(GameObject go) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x277310 Offset: 0x277411 VA: 0x277310
private sealed class HubSequence.<LoadMinimap>d__96 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 10803
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public HubSequence <>4__this; // 0x20
	private IEnumerator <func>5__2; // 0x28

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x2C1740 Offset: 0x2C1841 VA: 0x2C1740
	// RVA: 0x35F4E40 Offset: 0x35F4F41 VA: 0x35F4E40
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x2C1750 Offset: 0x2C1851 VA: 0x2C1750
	// RVA: 0x35F4E70 Offset: 0x35F4F71 VA: 0x35F4E70 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x35F4E80 Offset: 0x35F4F81 VA: 0x35F4E80 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x2C1760 Offset: 0x2C1861 VA: 0x2C1760
	// RVA: 0x35F5000 Offset: 0x35F5101 VA: 0x35F5000 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x2C1770 Offset: 0x2C1871 VA: 0x2C1770
	// RVA: 0x35F5010 Offset: 0x35F5111 VA: 0x35F5010 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x2C1780 Offset: 0x2C1881 VA: 0x2C1780
	// RVA: 0x35F5050 Offset: 0x35F5151 VA: 0x35F5050 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x277320 Offset: 0x277421 VA: 0x277320
[Serializable]
private sealed class HubSequence.<>c // TypeDefIndex: 10804
{
	// Fields
	public static readonly HubSequence.<>c <>9; // 0x0
	public static Func<GameObject, Transform> <>9__143_0; // 0x8

	// Methods

	// RVA: 0x35F45A0 Offset: 0x35F46A1 VA: 0x35F45A0
	private static void .cctor() { }

	// RVA: 0x35F4610 Offset: 0x35F4711 VA: 0x35F4610
	public void .ctor() { }

	// RVA: 0x35F4620 Offset: 0x35F4721 VA: 0x35F4620
	internal Transform <GetSunPosition>b__143_0(GameObject env) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x277330 Offset: 0x277431 VA: 0x277330
private sealed class HubSequence.<StartPedestal>d__163 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 10805
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public HubSequence <>4__this; // 0x20
	private float <sec>5__2; // 0x28

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x2C1790 Offset: 0x2C1891 VA: 0x2C1790
	// RVA: 0x35F63C0 Offset: 0x35F64C1 VA: 0x35F63C0
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x2C17A0 Offset: 0x2C18A1 VA: 0x2C17A0
	// RVA: 0x35F63F0 Offset: 0x35F64F1 VA: 0x35F63F0 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x35F6400 Offset: 0x35F6501 VA: 0x35F6400 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x2C17B0 Offset: 0x2C18B1 VA: 0x2C17B0
	// RVA: 0x35F6A10 Offset: 0x35F6B11 VA: 0x35F6A10 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x2C17C0 Offset: 0x2C18C1 VA: 0x2C17C0
	// RVA: 0x35F6A20 Offset: 0x35F6B21 VA: 0x35F6A20 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x2C17D0 Offset: 0x2C18D1 VA: 0x2C17D0
	// RVA: 0x35F6A60 Offset: 0x35F6B61 VA: 0x35F6A60 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x277340 Offset: 0x277441 VA: 0x277340
private sealed class HubSequence.<EndPedestal>d__165 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 10806
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public HubSequence <>4__this; // 0x20
	private float <sec>5__2; // 0x28

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x2C17E0 Offset: 0x2C18E1 VA: 0x2C17E0
	// RVA: 0x35F4890 Offset: 0x35F4991 VA: 0x35F4890
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x2C17F0 Offset: 0x2C18F1 VA: 0x2C17F0
	// RVA: 0x35F48C0 Offset: 0x35F49C1 VA: 0x35F48C0 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x35F48D0 Offset: 0x35F49D1 VA: 0x35F48D0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x2C1800 Offset: 0x2C1901 VA: 0x2C1800
	// RVA: 0x35F4AF0 Offset: 0x35F4BF1 VA: 0x35F4AF0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x2C1810 Offset: 0x2C1911 VA: 0x2C1810
	// RVA: 0x35F4B00 Offset: 0x35F4C01 VA: 0x35F4B00 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x2C1820 Offset: 0x2C1921 VA: 0x2C1820
	// RVA: 0x35F4B40 Offset: 0x35F4C41 VA: 0x35F4B40 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x277350 Offset: 0x277451 VA: 0x277350
private sealed class HubSequence.<EnterEvent>d__200 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 10807
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public HubSequence <>4__this; // 0x20

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x2C1830 Offset: 0x2C1931 VA: 0x2C1830
	// RVA: 0x35F4B50 Offset: 0x35F4C51 VA: 0x35F4B50
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x2C1840 Offset: 0x2C1941 VA: 0x2C1840
	// RVA: 0x35F4B80 Offset: 0x35F4C81 VA: 0x35F4B80 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x35F4B90 Offset: 0x35F4C91 VA: 0x35F4B90 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x2C1850 Offset: 0x2C1951 VA: 0x2C1850
	// RVA: 0x35F4DE0 Offset: 0x35F4EE1 VA: 0x35F4DE0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x2C1860 Offset: 0x2C1961 VA: 0x2C1860
	// RVA: 0x35F4DF0 Offset: 0x35F4EF1 VA: 0x35F4DF0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x2C1870 Offset: 0x2C1971 VA: 0x2C1870
	// RVA: 0x35F4E30 Offset: 0x35F4F31 VA: 0x35F4E30 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

