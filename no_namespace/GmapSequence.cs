// Namespace: 
private enum GmapSequence.EnterChapterSequence.Label // TypeDefIndex: 10314
{
	// Fields
	public int value__; // 0x0
	public const GmapSequence.EnterChapterSequence.Label Talk = 0;
	public const GmapSequence.EnterChapterSequence.Label Dialog = 1;
}

// Namespace: 
public class GmapSequence.EnterChapterSequence : ProcInst // TypeDefIndex: 10316
{
	// Fields
	private const string TalkFlagNameM010 = "G_GmapSpot_会話イベント_M010";
	private GmapSpot m_NowSpot; // 0x70
	private EnterChapterYesNoDialog.Type m_Type; // 0x78
	private Action m_DecideEventHandler; // 0x80
	private Action m_DecideEventHandler2; // 0x88

	// Methods

	// RVA: 0x22F05D0 Offset: 0x22F06D1 VA: 0x22F05D0
	private void .ctor(GmapSpot nowSpot, EnterChapterYesNoDialog.Type type, Action decideEventHandler) { }

	// RVA: 0x22F07D0 Offset: 0x22F08D1 VA: 0x22F07D0
	private void Branch() { }

	// RVA: 0x22F09A0 Offset: 0x22F0AA1 VA: 0x22F09A0
	private void Talk() { }

	// RVA: 0x22F0A50 Offset: 0x22F0B51 VA: 0x22F0A50
	private void OpenDialog() { }

	// RVA: 0x22F0B70 Offset: 0x22F0C71 VA: 0x22F0B70
	private void Final() { }

	// RVA: 0x22F0C30 Offset: 0x22F0D31 VA: 0x22F0C30
	public static void CreateBind(ProcInst super, GmapSpot nowSpot, EnterChapterYesNoDialog.Type type, Action decideEventHandler) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x276990 Offset: 0x276A91 VA: 0x276990
private sealed class GmapSequence.GmapDisposeSequence.<>c__DisplayClass4_0 // TypeDefIndex: 10318
{
	// Fields
	public GmapSpot reserveSpot; // 0x10

	// Methods

	// RVA: 0x1DCCC80 Offset: 0x1DCCD81 VA: 0x1DCCC80
	public void .ctor() { }

	// RVA: 0x1DCCC90 Offset: 0x1DCCD91 VA: 0x1DCCC90
	internal void <CheckAppearDisposSpot>b__0(GmapSpot spot) { }

	// RVA: 0x1DCCCB0 Offset: 0x1DCCDB1 VA: 0x1DCCCB0
	internal void <CheckAppearDisposSpot>b__1(GmapSpot spot) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x2769B0 Offset: 0x276AB1 VA: 0x2769B0
private sealed class GmapSequence.GmapDisposeSequence.<WaitAppearDispos>d__7 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 10320
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public GmapSequence.GmapDisposeSequence <>4__this; // 0x20
	private float <start>5__2; // 0x28

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x2BDBE0 Offset: 0x2BDCE1 VA: 0x2BDBE0
	// RVA: 0x1DCD110 Offset: 0x1DCD211 VA: 0x1DCD110
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x2BDBF0 Offset: 0x2BDCF1 VA: 0x2BDBF0
	// RVA: 0x1DCD140 Offset: 0x1DCD241 VA: 0x1DCD140 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1DCD150 Offset: 0x1DCD251 VA: 0x1DCD150 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x2BDC00 Offset: 0x2BDD01 VA: 0x2BDC00
	// RVA: 0x1DCD300 Offset: 0x1DCD401 VA: 0x1DCD300 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x2BDC10 Offset: 0x2BDD11 VA: 0x2BDC10
	// RVA: 0x1DCD310 Offset: 0x1DCD411 VA: 0x1DCD310 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x2BDC20 Offset: 0x2BDD21 VA: 0x2BDC20
	// RVA: 0x1DCD350 Offset: 0x1DCD451 VA: 0x1DCD350 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x2769D0 Offset: 0x276AD1 VA: 0x2769D0
private sealed class GmapSequence.GmapDisposeSequence.<>c__DisplayClass15_0 // TypeDefIndex: 10322
{
	// Fields
	public GmapSequence.GmapDisposeSequence p; // 0x10

	// Methods

	// RVA: 0x1DCCC30 Offset: 0x1DCCD31 VA: 0x1DCCC30
	public void .ctor() { }

	// RVA: 0x1DCCC40 Offset: 0x1DCCD41 VA: 0x1DCCC40
	internal bool <GetDescs>b__0() { }

	// RVA: 0x1DCCC60 Offset: 0x1DCCD61 VA: 0x1DCCC60
	internal bool <GetDescs>b__1() { }
}

// Namespace: 
public enum GmapSequence.GmapFreeCameraSequence.Dir // TypeDefIndex: 10324
{
	// Fields
	public int value__; // 0x0
	public const GmapSequence.GmapFreeCameraSequence.Dir Up = 0;
	public const GmapSequence.GmapFreeCameraSequence.Dir Down = 1;
	public const GmapSequence.GmapFreeCameraSequence.Dir Left = 2;
	public const GmapSequence.GmapFreeCameraSequence.Dir Right = 3;
	public const GmapSequence.GmapFreeCameraSequence.Dir Num = 4;
}

// Namespace: 
public sealed class GmapSequence.GmapFreeCameraSequence.DirFlagField : BitFieldTemplate32<GmapSequence.GmapFreeCameraSequence.DirFlag> // TypeDefIndex: 10326
{
	// Methods

	// RVA: 0x1DCD360 Offset: 0x1DCD461 VA: 0x1DCD360
	public void .ctor(int f) { }

	// RVA: 0x1DCD3C0 Offset: 0x1DCD4C1 VA: 0x1DCD3C0
	public void .ctor(GmapSequence.GmapFreeCameraSequence.DirFlag f) { }

	// RVA: 0x1DCD420 Offset: 0x1DCD521 VA: 0x1DCD420 Slot: 5
	protected override int ToInt(GmapSequence.GmapFreeCameraSequence.DirFlag value) { }

	// RVA: 0x1DCD430 Offset: 0x1DCD531 VA: 0x1DCD430
	public bool TestUp() { }

	// RVA: 0x1DCD490 Offset: 0x1DCD591 VA: 0x1DCD490
	public bool TestDown() { }

	// RVA: 0x1DCD4F0 Offset: 0x1DCD5F1 VA: 0x1DCD4F0
	public bool TestLeft() { }

	// RVA: 0x1DCD550 Offset: 0x1DCD651 VA: 0x1DCD550
	public bool TestRight() { }

	// RVA: 0x1DCD5B0 Offset: 0x1DCD6B1 VA: 0x1DCD5B0
	public bool Test(GmapSequence.GmapFreeCameraSequence.Dir dir) { }
}

// Namespace: 
private class GmapSequence.GmapFreeCameraSequence.SelfDestroy : MonoBehaviour // TypeDefIndex: 10328
{
	// Fields
	private Animator m_Animator; // 0x18

	// Methods

	// RVA: 0x1DCD6D0 Offset: 0x1DCD7D1 VA: 0x1DCD6D0
	private void Start() { }

	// RVA: 0x1DCD740 Offset: 0x1DCD841 VA: 0x1DCD740
	private void Update() { }

	// RVA: 0x1DCD800 Offset: 0x1DCD901 VA: 0x1DCD800
	public void .ctor() { }
}

// Namespace: 
private enum GmapSequence.GmapTeleportSequence.Label // TypeDefIndex: 10330
{
	// Fields
	public int value__; // 0x0
	public const GmapSequence.GmapTeleportSequence.Label End = 0;
}

// Namespace: 
public class GmapSequence.GmapTeleportSequence : ProcInst // TypeDefIndex: 10332
{
	// Fields
	private GmapSpot m_Destination; // 0x70
	private bool m_IsClosed; // 0x78

	// Methods

	// RVA: 0x22F4810 Offset: 0x22F4911 VA: 0x22F4810
	public static void LoadResources() { }

	// RVA: 0x22F4880 Offset: 0x22F4981 VA: 0x22F4880
	public static bool IsLoading() { }

	// RVA: 0x22F48F0 Offset: 0x22F49F1 VA: 0x22F48F0
	public static void UnloadResources() { }

	[IteratorStateMachineAttribute] // RVA: 0x2BDC30 Offset: 0x2BDD31 VA: 0x2BDC30
	// RVA: 0x22F4960 Offset: 0x22F4A61 VA: 0x22F4960
	private IEnumerator StartTeleport() { }

	// RVA: 0x22F49E0 Offset: 0x22F4AE1 VA: 0x22F49E0
	private void OpenMenu() { }

	// RVA: 0x22F4D20 Offset: 0x22F4E21 VA: 0x22F4D20
	private void Teleport() { }

	// RVA: 0x22F4E90 Offset: 0x22F4F91 VA: 0x22F4E90
	private void End() { }

	// RVA: 0x22F4EA0 Offset: 0x22F4FA1 VA: 0x22F4EA0
	private void CloseMapAndTitleBar() { }

	// RVA: 0x22F5050 Offset: 0x22F5151 VA: 0x22F5050
	public static void CreateBind(ProcInst super) { }

	// RVA: 0x22F53E0 Offset: 0x22F54E1 VA: 0x22F53E0
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BDCA0 Offset: 0x2BDDA1 VA: 0x2BDCA0
	// RVA: 0x22F53F0 Offset: 0x22F54F1 VA: 0x22F53F0
	private void <OpenMenu>b__7_0(GmapSpot spot) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BDCB0 Offset: 0x2BDDB1 VA: 0x2BDCB0
	// RVA: 0x22F5400 Offset: 0x22F5501 VA: 0x22F5400
	private void <OpenMenu>b__7_1() { }
}

// Namespace: 
private class GmapSequence.GmapWholeMapSequence : ProcInst // TypeDefIndex: 10334
{
	// Fields
	private GmapWholeMapController m_WholeMap; // 0x70
	private GmapCamera m_GmapCamera; // 0x78
	private GmapMapInfoContent m_MapInfo; // 0x80

	// Methods

	// RVA: 0x1F9DD10 Offset: 0x1F9DE11 VA: 0x1F9DD10
	private void .ctor() { }

	// RVA: 0x1F9DDE0 Offset: 0x1F9DEE1 VA: 0x1F9DDE0
	private void Start() { }

	// RVA: 0x1F9DFA0 Offset: 0x1F9E0A1 VA: 0x1F9DFA0
	private void Tick() { }

	// RVA: 0x1F9E210 Offset: 0x1F9E311 VA: 0x1F9E210
	private void End() { }

	// RVA: 0x1F9E300 Offset: 0x1F9E401 VA: 0x1F9E300
	private void WaitCameraMoveStrictly() { }

	// RVA: 0x1F9E340 Offset: 0x1F9E441 VA: 0x1F9E340
	public static void CreateBind(ProcInst super) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x276A10 Offset: 0x276B11 VA: 0x276A10
private sealed class GmapSequence.<GmapHelpEvent>d__74 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 10336
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public GmapSequence <>4__this; // 0x20

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x2BDD60 Offset: 0x2BDE61 VA: 0x2BDD60
	// RVA: 0x22EFEF0 Offset: 0x22EFFF1 VA: 0x22EFEF0
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x2BDD70 Offset: 0x2BDE71 VA: 0x2BDD70
	// RVA: 0x22EFF20 Offset: 0x22F0021 VA: 0x22EFF20 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x22EFF30 Offset: 0x22F0031 VA: 0x22EFF30 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x2BDD80 Offset: 0x2BDE81 VA: 0x2BDD80
	// RVA: 0x22F0570 Offset: 0x22F0671 VA: 0x22F0570 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x2BDD90 Offset: 0x2BDE91 VA: 0x2BDD90
	// RVA: 0x22F0580 Offset: 0x22F0681 VA: 0x22F0580 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x2BDDA0 Offset: 0x2BDEA1 VA: 0x2BDDA0
	// RVA: 0x22F05C0 Offset: 0x22F06C1 VA: 0x22F05C0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

