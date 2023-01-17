// Namespace: 
private enum TelopManager.ProcBondLevelUp.Sequence // TypeDefIndex: 13396
{
	// Fields
	public int value__; // 0x0
	public const TelopManager.ProcBondLevelUp.Sequence Init = 0;
	public const TelopManager.ProcBondLevelUp.Sequence KeyWait = 1;
}

// Namespace: 
protected enum TelopManager.ProcBondEngageBase.Sequence // TypeDefIndex: 13398
{
	// Fields
	public int value__; // 0x0
	public const TelopManager.ProcBondEngageBase.Sequence Idle = 0;
	public const TelopManager.ProcBondEngageBase.Sequence PlayMainVoice = 1;
	public const TelopManager.ProcBondEngageBase.Sequence WaitMainVoice = 2;
	public const TelopManager.ProcBondEngageBase.Sequence Interval = 3;
	public const TelopManager.ProcBondEngageBase.Sequence PlaySubVoice = 4;
	public const TelopManager.ProcBondEngageBase.Sequence WaitSubVoice = 5;
	public const TelopManager.ProcBondEngageBase.Sequence Release = 6;
}

// Namespace: 
public class TelopManager.ProcBondEngageBase : ProcInst // TypeDefIndex: 13400
{
	// Fields
	private const string EventName = "V_LinkEngage";
	private const int WaitFrame = 5;
	protected TelopInstance m_RootTelop; // 0x70
	private AssetTable.Result m_AssetTableResult; // 0x78
	protected TelopManager.ProcBondEngageBase.Sequence m_Sequence; // 0x80
	protected int m_WaitFrame; // 0x84

	// Methods

	// RVA: 0x238F640 Offset: 0x238F741 VA: 0x238F640
	protected void ExecuteAudioPlaybackSequence(GodData mainData, GodData subData, GameObject gameObject) { }

	// RVA: 0x238F900 Offset: 0x238FA01 VA: 0x238F900
	private void PlayVoice(GodData godData) { }

	// RVA: 0x238F9E0 Offset: 0x238FAE1 VA: 0x238F9E0
	public void .ctor() { }
}

// Namespace: 
public class TelopManager.ProcBondEngageQuartette : TelopManager.ProcBondEngageBase // TypeDefIndex: 13402
{
	// Fields
	private GodData m_1stMainGod; // 0x88
	private GodData m_2ndMainGod; // 0x90
	private GodData m_3rdMainGod; // 0x98
	private GodData m_SubGod; // 0xA0

	// Methods

	// RVA: 0x23903E0 Offset: 0x23904E1 VA: 0x23903E0
	private void .ctor(GodData firstMainGod, GodData secondMainGod, GodData thirdMainGod, GodData subGod) { }

	// RVA: 0x23904C0 Offset: 0x23905C1 VA: 0x23904C0
	private void LoadFace() { }

	// RVA: 0x23905D0 Offset: 0x23906D1 VA: 0x23905D0
	private void PlayTelop() { }

	// RVA: 0x2390710 Offset: 0x2390811 VA: 0x2390710
	private void ReleaseFace() { }

	// RVA: 0x2390800 Offset: 0x2390901 VA: 0x2390800
	public static void CreateBind(ProcInst super, GodData firstMainGod, GodData secondMainGod, GodData thirdMainGod, GodData subGod) { }

	[CompilerGeneratedAttribute] // RVA: 0x2CB830 Offset: 0x2CB931 VA: 0x2CB830
	// RVA: 0x2390BD0 Offset: 0x2390CD1 VA: 0x2390BD0
	private void <PlayTelop>b__6_0(GameObject gameObject) { }

	[CompilerGeneratedAttribute] // RVA: 0x2CB840 Offset: 0x2CB941 VA: 0x2CB840
	// RVA: 0x2390E30 Offset: 0x2390F31 VA: 0x2390E30
	private void <PlayTelop>b__6_1(GameObject gameObject) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x278C30 Offset: 0x278D31 VA: 0x278C30
private sealed class TelopManager.ProcRelayResult.<>c__DisplayClass1_0 // TypeDefIndex: 13404
{
	// Fields
	public TelopManager.ProcRelayResult p; // 0x10

	// Methods

	// RVA: 0x21FC900 Offset: 0x21FCA01 VA: 0x21FC900
	public void .ctor() { }

	// RVA: 0x21FC910 Offset: 0x21FCA11 VA: 0x21FC910
	internal bool <CrateBind>b__0() { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x278C50 Offset: 0x278D51 VA: 0x278C50
[Serializable]
private sealed class TelopManager.ProcRelayResult.<>c // TypeDefIndex: 13406
{
	// Fields
	public static readonly TelopManager.ProcRelayResult.<>c <>9; // 0x0
	public static ResourceObject.Callback <>9__7_2; // 0x8

	// Methods

	// RVA: 0x21FC7E0 Offset: 0x21FC8E1 VA: 0x21FC7E0
	private static void .cctor() { }

	// RVA: 0x21FC850 Offset: 0x21FC951 VA: 0x21FC850
	public void .ctor() { }

	// RVA: 0x21FC860 Offset: 0x21FC961 VA: 0x21FC860
	internal void <PlayTelop>b__7_2(GameObject gameObject) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x278C60 Offset: 0x278D61 VA: 0x278C60
private sealed class TelopManager.<>c__DisplayClass10_0 // TypeDefIndex: 13408
{
	// Fields
	public string textWin; // 0x10
	public string textLose; // 0x18

	// Methods

	// RVA: 0x238EA70 Offset: 0x238EB71 VA: 0x238EA70
	public void .ctor() { }

	// RVA: 0x238EA80 Offset: 0x238EB81 VA: 0x238EA80
	internal void <CreatePurpose>b__0(GameObject gameObject) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x278C80 Offset: 0x278D81 VA: 0x278C80
private sealed class TelopManager.<Coroutine>d__12 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 13410
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public GameObject go; // 0x20
	private Animator <animator>5__2; // 0x28

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x2CB850 Offset: 0x2CB951 VA: 0x2CB850
	// RVA: 0x238F410 Offset: 0x238F511 VA: 0x238F410
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x2CB860 Offset: 0x2CB961 VA: 0x2CB860
	// RVA: 0x238F440 Offset: 0x238F541 VA: 0x238F440 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x238F450 Offset: 0x238F551 VA: 0x238F450 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x2CB870 Offset: 0x2CB971 VA: 0x2CB870
	// RVA: 0x238F5E0 Offset: 0x238F6E1 VA: 0x238F5E0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x2CB880 Offset: 0x2CB981 VA: 0x2CB880
	// RVA: 0x238F5F0 Offset: 0x238F6F1 VA: 0x238F5F0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x2CB890 Offset: 0x2CB991 VA: 0x2CB890
	// RVA: 0x238F630 Offset: 0x238F731 VA: 0x238F630 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x278CA0 Offset: 0x278DA1 VA: 0x278CA0
private sealed class TelopManager.<>c__DisplayClass15_0 // TypeDefIndex: 13412
{
	// Fields
	public int level; // 0x10
	public int nextLevel; // 0x14
	public bool isShowCharaImage; // 0x18
	public Unit unit; // 0x20

	// Methods

	// RVA: 0x238EE00 Offset: 0x238EF01 VA: 0x238EE00
	public void .ctor() { }

	// RVA: 0x238EE10 Offset: 0x238EF11 VA: 0x238EE10
	internal void <CreateLevelUp>b__0(GameObject gameObject) { }

	// RVA: 0x238F020 Offset: 0x238F121 VA: 0x238F020
	internal void <CreateLevelUp>b__1(GameObject gameObject) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x278CC0 Offset: 0x278DC1 VA: 0x278CC0
private sealed class TelopManager.<>c__DisplayClass26_0 // TypeDefIndex: 13414
{
	// Fields
	public ChapterData chapter; // 0x10

	// Methods

	// RVA: 0x238F1B0 Offset: 0x238F2B1 VA: 0x238F1B0
	public void .ctor() { }

	// RVA: 0x238F1C0 Offset: 0x238F2C1 VA: 0x238F1C0
	internal void <CreateChapterTitle>b__0(GameObject go) { }
}

