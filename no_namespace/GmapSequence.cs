// Namespace: 
public enum GmapSequence.Label // TypeDefIndex: 10313
{
	// Fields
	public int value__; // 0x0
	public const GmapSequence.Label Init = 0;
	public const GmapSequence.Label EnterFromOtherGmap = 1;
	public const GmapSequence.Label Event = 2;
	public const GmapSequence.Label CheckSpot = 3;
	public const GmapSequence.Label AppearSpot = 4;
	public const GmapSequence.Label CheckDispos = 5;
	public const GmapSequence.Label CheckDisposDebug = 6;
	public const GmapSequence.Label Tick = 7;
	public const GmapSequence.Label TickWithoutCamaraWait = 8;
	public const GmapSequence.Label Move = 9;
	public const GmapSequence.Label MoveToOtherGmap = 10;
	public const GmapSequence.Label SaveDataLoad = 11;
	public const GmapSequence.Label End = 12;
	public const GmapSequence.Label Tail = 13;
}

// Namespace: 
private enum GmapSequence.EnterChapterSequence.Label // TypeDefIndex: 10314
{
	// Fields
	public int value__; // 0x0
	public const GmapSequence.EnterChapterSequence.Label Talk = 0;
	public const GmapSequence.EnterChapterSequence.Label Dialog = 1;
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x276980 Offset: 0x276A81 VA: 0x276980
private sealed class GmapSequence.EnterChapterSequence.<>c__DisplayClass6_0 // TypeDefIndex: 10315
{
	// Fields
	public Action decideEventHandler; // 0x10

	// Methods

	// RVA: 0x1DCC8E0 Offset: 0x1DCC9E1 VA: 0x1DCC8E0
	public void .ctor() { }

	// RVA: 0x1DCC8F0 Offset: 0x1DCC9F1 VA: 0x1DCC8F0
	internal void <.ctor>b__0() { }

	// RVA: 0x1DCC980 Offset: 0x1DCCA81 VA: 0x1DCC980
	internal void <.ctor>b__1() { }

	// RVA: 0x1DCCA10 Offset: 0x1DCCB11 VA: 0x1DCCA10
	internal void <.ctor>b__2() { }

	// RVA: 0x1DCCAA0 Offset: 0x1DCCBA1 VA: 0x1DCCAA0
	internal void <.ctor>b__3() { }

	// RVA: 0x1DCCB30 Offset: 0x1DCCC31 VA: 0x1DCCB30
	internal void <.ctor>b__4() { }
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
private enum GmapSequence.GmapDisposeSequence.Label // TypeDefIndex: 10317
{
	// Fields
	public int value__; // 0x0
	public const GmapSequence.GmapDisposeSequence.Label CheckDispos = 0;
	public const GmapSequence.GmapDisposeSequence.Label UpdateDispos = 1;
	public const GmapSequence.GmapDisposeSequence.Label AppearDispos = 2;
	public const GmapSequence.GmapDisposeSequence.Label AppearDisposEnd = 3;
	public const GmapSequence.GmapDisposeSequence.Label AppearDisposSkip = 4;
	public const GmapSequence.GmapDisposeSequence.Label AppearDisposSkipBegin = 5;
	public const GmapSequence.GmapDisposeSequence.Label AppearDisposSkipEnd = 6;
	public const GmapSequence.GmapDisposeSequence.Label End = 7;
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
[CompilerGeneratedAttribute] // RVA: 0x2769A0 Offset: 0x276AA1 VA: 0x2769A0
private sealed class GmapSequence.GmapDisposeSequence.<DisposMoveCamera>d__5 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 10319
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public GmapSequence.GmapDisposeSequence <>4__this; // 0x20
	private GmapCamera <camera>5__2; // 0x28
	private float <start>5__3; // 0x30

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x2BDB90 Offset: 0x2BDC91 VA: 0x2BDB90
	// RVA: 0x1DCCCD0 Offset: 0x1DCCDD1 VA: 0x1DCCCD0
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x2BDBA0 Offset: 0x2BDCA1 VA: 0x2BDBA0
	// RVA: 0x1DCCD00 Offset: 0x1DCCE01 VA: 0x1DCCD00 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1DCCD10 Offset: 0x1DCCE11 VA: 0x1DCCD10 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x2BDBB0 Offset: 0x2BDCB1 VA: 0x2BDBB0
	// RVA: 0x1DCD0B0 Offset: 0x1DCD1B1 VA: 0x1DCD0B0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x2BDBC0 Offset: 0x2BDCC1 VA: 0x2BDBC0
	// RVA: 0x1DCD0C0 Offset: 0x1DCD1C1 VA: 0x1DCD0C0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x2BDBD0 Offset: 0x2BDCD1 VA: 0x2BDBD0
	// RVA: 0x1DCD100 Offset: 0x1DCD201 VA: 0x1DCD100 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
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
[CompilerGeneratedAttribute] // RVA: 0x2769C0 Offset: 0x276AC1 VA: 0x2769C0
private sealed class GmapSequence.GmapDisposeSequence.<>c__DisplayClass12_0 // TypeDefIndex: 10321
{
	// Fields
	public List<GmapSpot> spotList; // 0x10

	// Methods

	// RVA: 0x1DCCBC0 Offset: 0x1DCCCC1 VA: 0x1DCCBC0
	public void .ctor() { }

	// RVA: 0x1DCCBD0 Offset: 0x1DCCCD1 VA: 0x1DCCBD0
	internal void <DisposUpdateOfOtherMode>b__0(GmapSpot spot) { }
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
private class GmapSequence.GmapDisposeSequence : ProcInst // TypeDefIndex: 10323
{
	// Fields
	private GmapSpot m_DisposSpot; // 0x70

	// Methods

	// RVA: 0x22F1020 Offset: 0x22F1121 VA: 0x22F1020
	private void CheckDispos() { }

	// RVA: 0x22F1150 Offset: 0x22F1251 VA: 0x22F1150
	private void DetermineDisposSpot() { }

	// RVA: 0x22F11D0 Offset: 0x22F12D1 VA: 0x22F11D0
	private void CheckAppearDisposSpot() { }

	[IteratorStateMachineAttribute] // RVA: 0x2BDAB0 Offset: 0x2BDBB1 VA: 0x2BDAB0
	// RVA: 0x22F1440 Offset: 0x22F1541 VA: 0x22F1440
	private IEnumerator DisposMoveCamera() { }

	// RVA: 0x22F14C0 Offset: 0x22F15C1 VA: 0x22F14C0
	private void StartDisposEffect() { }

	[IteratorStateMachineAttribute] // RVA: 0x2BDB20 Offset: 0x2BDC21 VA: 0x2BDB20
	// RVA: 0x22F1530 Offset: 0x22F1631 VA: 0x22F1530
	private IEnumerator WaitAppearDispos() { }

	// RVA: 0x22F15B0 Offset: 0x22F16B1 VA: 0x22F15B0
	private void SetReturnCameraPosition() { }

	// RVA: 0x22F1660 Offset: 0x22F1761 VA: 0x22F1660
	private void StartAppearSkip() { }

	// RVA: 0x22F16E0 Offset: 0x22F17E1 VA: 0x22F16E0
	private void EndAppearSkip() { }

	// RVA: 0x22F1760 Offset: 0x22F1861 VA: 0x22F1760
	private void WaitCameraMove() { }

	// RVA: 0x22F1810 Offset: 0x22F1911 VA: 0x22F1810
	private void DisposUpdateOfOtherMode() { }

	// RVA: 0x22F1BC0 Offset: 0x22F1CC1 VA: 0x22F1BC0
	private void SetUpEncountInfo() { }

	// RVA: 0x22F1C40 Offset: 0x22F1D41 VA: 0x22F1C40
	public static void CreateBind(ProcInst super) { }

	// RVA: 0x22F1CD0 Offset: 0x22F1DD1 VA: 0x22F1CD0
	private static ProcDesc[] GetDescs(GmapSequence.GmapDisposeSequence p) { }

	// RVA: 0x22F1CC0 Offset: 0x22F1DC1 VA: 0x22F1CC0
	public void .ctor() { }
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
[FlagsAttribute] // RVA: 0x2769E0 Offset: 0x276AE1 VA: 0x2769E0
public enum GmapSequence.GmapFreeCameraSequence.DirFlag // TypeDefIndex: 10325
{
	// Fields
	public int value__; // 0x0
	public const GmapSequence.GmapFreeCameraSequence.DirFlag Up = 1;
	public const GmapSequence.GmapFreeCameraSequence.DirFlag Left = 2;
	public const GmapSequence.GmapFreeCameraSequence.DirFlag Right = 4;
	public const GmapSequence.GmapFreeCameraSequence.DirFlag Down = 8;
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
private enum GmapSequence.GmapFreeCameraSequence.Label // TypeDefIndex: 10327
{
	// Fields
	public int value__; // 0x0
	public const GmapSequence.GmapFreeCameraSequence.Label End = 0;
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
public class GmapSequence.GmapFreeCameraSequence : ProcInst // TypeDefIndex: 10329
{
	// Fields
	private const string FreeCameraRootPath = "UI/Gmap/Prefabs/GmapFreeCameraRoot";
	private GameObject m_Root; // 0x70
	private const float MoveSpeedAngle = 0.17;
	private float m_AngleX; // 0x78
	private float m_AngleZ; // 0x7C
	private Vector3 m_StartPosition; // 0x80
	private Vector3 m_CachePosition; // 0x8C
	private GmapSequence.GmapFreeCameraSequence.DirFlagField m_DisableFlag; // 0x98
	private float[] m_AngleLimit; // 0xA0
	private GmapCamera m_Camera; // 0xA8

	// Methods

	// RVA: 0x22F2C40 Offset: 0x22F2D41 VA: 0x22F2C40
	public static void LoadResorces() { }

	// RVA: 0x22F2CE0 Offset: 0x22F2DE1 VA: 0x22F2CE0
	public static bool IsLoading() { }

	// RVA: 0x22F2D60 Offset: 0x22F2E61 VA: 0x22F2D60
	public static void UnloadResources() { }

	// RVA: 0x22F2DE0 Offset: 0x22F2EE1 VA: 0x22F2DE0
	private void Init() { }

	// RVA: 0x22F2FB0 Offset: 0x22F30B1 VA: 0x22F2FB0
	private bool WaitScroll() { }

	// RVA: 0x22F3030 Offset: 0x22F3131 VA: 0x22F3030
	private void Start() { }

	// RVA: 0x22F3250 Offset: 0x22F3351 VA: 0x22F3250
	private void Tick() { }

	// RVA: 0x22F38A0 Offset: 0x22F39A1 VA: 0x22F38A0
	private Vector3 TryLRMove(float moveLStickX) { }

	// RVA: 0x22F3A00 Offset: 0x22F3B01 VA: 0x22F3A00
	private Vector3 TryUDMove(float moveLStickY) { }

	// RVA: 0x22F3CD0 Offset: 0x22F3DD1 VA: 0x22F3CD0
	private static Vector3 CalcLeftRightPos(Vector3 pos, float angle) { }

	// RVA: 0x22F4060 Offset: 0x22F4161 VA: 0x22F4060
	private static Vector3 CalcUDPos(Vector3 pos, float angle) { }

	// RVA: 0x22F31A0 Offset: 0x22F32A1 VA: 0x22F31A0
	private void InitAngleLimit(GmapSequence.GmapFreeCameraSequence.DirFlagField flags) { }

	// RVA: 0x22F3BB0 Offset: 0x22F3CB1 VA: 0x22F3BB0
	private float ClampAngle(float angle, GmapSequence.GmapFreeCameraSequence.Dir dir) { }

	// RVA: 0x22F40F0 Offset: 0x22F41F1 VA: 0x22F40F0
	private bool TryGetAngleLimit(GmapSequence.GmapFreeCameraSequence.Dir dir, out float value) { }

	// RVA: 0x22F3ED0 Offset: 0x22F3FD1 VA: 0x22F3ED0
	private void SetAngleLimit(GmapSequence.GmapFreeCameraSequence.DirFlagField flag, float angle, GmapSequence.GmapFreeCameraSequence.Dir dir) { }

	// RVA: 0x22F3D40 Offset: 0x22F3E41 VA: 0x22F3D40
	private GmapSequence.GmapFreeCameraSequence.DirFlagField GetRecalcIgnoreFlag() { }

	// RVA: 0x22F4140 Offset: 0x22F4241 VA: 0x22F4140
	private void End() { }

	// RVA: 0x22F4300 Offset: 0x22F4401 VA: 0x22F4300
	public static void CreateBind(ProcInst super) { }

	// RVA: 0x22F47A0 Offset: 0x22F48A1 VA: 0x22F47A0
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
[CompilerGeneratedAttribute] // RVA: 0x2769F0 Offset: 0x276AF1 VA: 0x2769F0
private sealed class GmapSequence.GmapTeleportSequence.<StartTeleport>d__6 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 10331
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public GmapSequence.GmapTeleportSequence <>4__this; // 0x20

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x2BDCC0 Offset: 0x2BDDC1 VA: 0x2BDCC0
	// RVA: 0x1DCD810 Offset: 0x1DCD911 VA: 0x1DCD810
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x2BDCD0 Offset: 0x2BDDD1 VA: 0x2BDCD0
	// RVA: 0x1DCD840 Offset: 0x1DCD941 VA: 0x1DCD840 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1DCD850 Offset: 0x1DCD951 VA: 0x1DCD850 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x2BDCE0 Offset: 0x2BDDE1 VA: 0x2BDCE0
	// RVA: 0x1DCD910 Offset: 0x1DCDA11 VA: 0x1DCD910 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x2BDCF0 Offset: 0x2BDDF1 VA: 0x2BDCF0
	// RVA: 0x1DCD920 Offset: 0x1DCDA21 VA: 0x1DCD920 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x2BDD00 Offset: 0x2BDE01 VA: 0x2BDD00
	// RVA: 0x1DCD960 Offset: 0x1DCDA61 VA: 0x1DCD960 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
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
private enum GmapSequence.GmapWholeMapSequence.Label // TypeDefIndex: 10333
{
	// Fields
	public int value__; // 0x0
	public const GmapSequence.GmapWholeMapSequence.Label End = 0;
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
[CompilerGeneratedAttribute] // RVA: 0x276A00 Offset: 0x276B01 VA: 0x276A00
private sealed class GmapSequence.<AppearPathTick>d__69 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 10335
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public GmapSequence <>4__this; // 0x20
	private GmapLineRenderer <renderer>5__2; // 0x28
	private Vector3 <up>5__3; // 0x30
	private GameObject <spotEffect>5__4; // 0x40
	private GameObject <symbolEffect>5__5; // 0x48

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x2BDD10 Offset: 0x2BDE11 VA: 0x2BDD10
	// RVA: 0x22EFA90 Offset: 0x22EFB91 VA: 0x22EFA90
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x2BDD20 Offset: 0x2BDE21 VA: 0x2BDD20
	// RVA: 0x22EFAC0 Offset: 0x22EFBC1 VA: 0x22EFAC0 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x22EFAD0 Offset: 0x22EFBD1 VA: 0x22EFAD0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x2BDD30 Offset: 0x2BDE31 VA: 0x2BDD30
	// RVA: 0x22EFE90 Offset: 0x22EFF91 VA: 0x22EFE90 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x2BDD40 Offset: 0x2BDE41 VA: 0x2BDD40
	// RVA: 0x22EFEA0 Offset: 0x22EFFA1 VA: 0x22EFEA0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x2BDD50 Offset: 0x2BDE51 VA: 0x2BDD50
	// RVA: 0x22EFEE0 Offset: 0x22EFFE1 VA: 0x22EFEE0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
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

