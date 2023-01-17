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
private static class HubSequence.LastChapterMenu.RankingMenuItem.ConfirmDialog // TypeDefIndex: 10788
{
	// Methods

	// RVA: 0x2D74A40 Offset: 0x2D74B41 VA: 0x2D74A40
	public static void CreateBind(ProcInst super, NetEnableSequence.ResultFunction resultFunc) { }
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

