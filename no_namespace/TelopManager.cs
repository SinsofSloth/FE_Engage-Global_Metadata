// Namespace: 
private enum TelopManager.ProcBondLevelUp.Label2 // TypeDefIndex: 13395
{
	// Fields
	public int value__; // 0x0
	public const TelopManager.ProcBondLevelUp.Label2 Entry = 0;
	public const TelopManager.ProcBondLevelUp.Label2 End = 1;
}

// Namespace: 
private enum TelopManager.ProcBondLevelUp.Sequence // TypeDefIndex: 13396
{
	// Fields
	public int value__; // 0x0
	public const TelopManager.ProcBondLevelUp.Sequence Init = 0;
	public const TelopManager.ProcBondLevelUp.Sequence KeyWait = 1;
}

// Namespace: 
private class TelopManager.ProcBondLevelUp : ProcInst // TypeDefIndex: 13397
{
	// Fields
	private Unit m_Unit; // 0x70
	private GodUnit m_God; // 0x78
	private int m_Level; // 0x80
	private int m_NextLevel; // 0x84
	private GodData m_GodData; // 0x88
	private TelopInstance m_RootTelop; // 0x90
	private TelopInstance m_LevelTelop; // 0x98
	private GameObject m_SkillObj; // 0xA0
	private GameObject m_EffectObj; // 0xA8
	private List<BasicMenuItem> m_MenuItemList; // 0xB0
	private int m_MenuItemIndex; // 0xB8
	private TelopManager.ProcBondLevelUp.Sequence m_Sequence; // 0xBC

	// Methods

	// RVA: 0x2390E40 Offset: 0x2390F41 VA: 0x2390E40
	private void .ctor(Unit unit, GodUnit god, int level, int nextLevel, GodData godData) { }

	// RVA: 0x2390F50 Offset: 0x2391051 VA: 0x2390F50
	private void LoadFace() { }

	// RVA: 0x2391030 Offset: 0x2391131 VA: 0x2391030
	private void PlayTelop() { }

	// RVA: 0x23911F0 Offset: 0x23912F1 VA: 0x23911F0
	private void ReleaseFace() { }

	// RVA: 0x23912B0 Offset: 0x23913B1 VA: 0x23912B0 Slot: 9
	protected override void OnCreate() { }

	// RVA: 0x23912C0 Offset: 0x23913C1 VA: 0x23912C0 Slot: 10
	protected override void OnDispose() { }

	// RVA: 0x23912D0 Offset: 0x23913D1 VA: 0x23912D0
	public static void CrateBind(ProcInst super, Unit unit, GodUnit god, int level, int nextLevel, GodData godData) { }

	[CompilerGeneratedAttribute] // RVA: 0x2CB7F0 Offset: 0x2CB8F1 VA: 0x2CB7F0
	// RVA: 0x23916A0 Offset: 0x23917A1 VA: 0x23916A0
	private void <PlayTelop>b__16_0(GameObject gameObject) { }

	[CompilerGeneratedAttribute] // RVA: 0x2CB800 Offset: 0x2CB901 VA: 0x2CB800
	// RVA: 0x2391A80 Offset: 0x2391B81 VA: 0x2391A80
	private void <PlayTelop>b__16_1(GameObject gameObject) { }
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
protected enum TelopManager.ProcBondEngageBase.Label // TypeDefIndex: 13399
{
	// Fields
	public int value__; // 0x0
	public const TelopManager.ProcBondEngageBase.Label Entry = 0;
	public const TelopManager.ProcBondEngageBase.Label End = 1;
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
public class TelopManager.ProcBondEngagePair : TelopManager.ProcBondEngageBase // TypeDefIndex: 13401
{
	// Fields
	private GodData m_MainGod; // 0x88
	private GodData m_SubGod; // 0x90

	// Methods

	// RVA: 0x238FA60 Offset: 0x238FB61 VA: 0x238FA60
	private void .ctor(GodData mainGod, GodData subGod) { }

	// RVA: 0x238FB10 Offset: 0x238FC11 VA: 0x238FB10
	private void LoadFace() { }

	// RVA: 0x238FBF0 Offset: 0x238FCF1 VA: 0x238FBF0
	private void PlayTelop() { }

	// RVA: 0x238FD30 Offset: 0x238FE31 VA: 0x238FD30
	private void ReleaseFace() { }

	// RVA: 0x238FDF0 Offset: 0x238FEF1 VA: 0x238FDF0
	public static void CreateBind(ProcInst super, GodData mainGod, GodData subGod) { }

	[CompilerGeneratedAttribute] // RVA: 0x2CB810 Offset: 0x2CB911 VA: 0x2CB810
	// RVA: 0x23901A0 Offset: 0x23902A1 VA: 0x23901A0
	private void <PlayTelop>b__4_0(GameObject gameObject) { }

	[CompilerGeneratedAttribute] // RVA: 0x2CB820 Offset: 0x2CB921 VA: 0x2CB820
	// RVA: 0x23903D0 Offset: 0x23904D1 VA: 0x23903D0
	private void <PlayTelop>b__4_1(GameObject gameObject) { }
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
private enum TelopManager.ProcRelayResult.Label2 // TypeDefIndex: 13403
{
	// Fields
	public int value__; // 0x0
	public const TelopManager.ProcRelayResult.Label2 PlayTelop = 0;
	public const TelopManager.ProcRelayResult.Label2 End = 1;
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
[CompilerGeneratedAttribute] // RVA: 0x278C40 Offset: 0x278D41 VA: 0x278C40
private sealed class TelopManager.ProcRelayResult.<>c__DisplayClass7_0 // TypeDefIndex: 13405
{
	// Fields
	public RelayAwardData award; // 0x10
	public RelayAwardeeData awardee; // 0x18
	public bool isNegative; // 0x20
	public TelopManager.ProcRelayResult <>4__this; // 0x28

	// Methods

	// RVA: 0x21FC920 Offset: 0x21FCA21 VA: 0x21FC920
	public void .ctor() { }

	// RVA: 0x21FC930 Offset: 0x21FCA31 VA: 0x21FC930
	internal void <PlayTelop>b__0(GameObject gameObject) { }

	// RVA: 0x21FD0C0 Offset: 0x21FD1C1 VA: 0x21FD0C0
	internal void <PlayTelop>b__1(GameObject gameObject) { }
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
private class TelopManager.ProcRelayResult : ProcInst // TypeDefIndex: 13407
{
	// Fields
	private string[] m_Raids; // 0x70
	private int m_AwardeeIndex; // 0x78
	private bool m_IsAwarded; // 0x7C
	private bool m_IsLookAtIKSet; // 0x7D

	// Methods

	// RVA: 0x2391F40 Offset: 0x2392041 VA: 0x2391F40
	public static void CrateBind(ProcInst super, string[] raids, bool isAwarded) { }

	// RVA: 0x23922D0 Offset: 0x23923D1 VA: 0x23922D0
	private void .ctor(string[] raids, bool isAwarded) { }

	// RVA: 0x2392330 Offset: 0x2392431 VA: 0x2392330
	private void PlayTelop() { }

	// RVA: 0x2392710 Offset: 0x2392811 VA: 0x2392710
	private bool IsHaveNext() { }
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
[CompilerGeneratedAttribute] // RVA: 0x278C70 Offset: 0x278D71 VA: 0x278C70
private sealed class TelopManager.<>c__DisplayClass11_0 // TypeDefIndex: 13409
{
	// Fields
	public int limitTurn; // 0x10
	public int nowTurn; // 0x14
	public Force.Type forceType; // 0x18

	// Methods

	// RVA: 0x238EB40 Offset: 0x238EC41 VA: 0x238EB40
	public void .ctor() { }

	// RVA: 0x238EB50 Offset: 0x238EC51 VA: 0x238EB50
	internal void <CreatePhaseChange>b__0(GameObject gameObject) { }
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
[CompilerGeneratedAttribute] // RVA: 0x278C90 Offset: 0x278D91 VA: 0x278C90
[Serializable]
private sealed class TelopManager.<>c // TypeDefIndex: 13411
{
	// Fields
	public static readonly TelopManager.<>c <>9; // 0x0
	public static ResourceObject.Callback <>9__13_0; // 0x8
	public static ResourceObject.Callback <>9__14_0; // 0x10

	// Methods

	// RVA: 0x238E6A0 Offset: 0x238E7A1 VA: 0x238E6A0
	private static void .cctor() { }

	// RVA: 0x238E710 Offset: 0x238E811 VA: 0x238E710
	public void .ctor() { }

	// RVA: 0x238E720 Offset: 0x238E821 VA: 0x238E720
	internal void <CreateComplete>b__13_0(GameObject gameObject) { }

	// RVA: 0x238E8A0 Offset: 0x238E9A1 VA: 0x238E8A0
	internal void <CreateGameOver>b__14_0(GameObject gameObject) { }
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
[CompilerGeneratedAttribute] // RVA: 0x278CB0 Offset: 0x278DB1 VA: 0x278CB0
private sealed class TelopManager.<>c__DisplayClass24_0 // TypeDefIndex: 13413
{
	// Fields
	public JobData before; // 0x10
	public JobData after; // 0x18

	// Methods

	// RVA: 0x238F0C0 Offset: 0x238F1C1 VA: 0x238F0C0
	public void .ctor() { }

	// RVA: 0x238F0D0 Offset: 0x238F1D1 VA: 0x238F0D0
	internal void <CreateClassChange>b__0(GameObject gameObject) { }
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

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x278CD0 Offset: 0x278DD1 VA: 0x278CD0
private sealed class TelopManager.<>c__DisplayClass27_0 // TypeDefIndex: 13415
{
	// Fields
	public int level; // 0x10
	public int nextLevel; // 0x14

	// Methods

	// RVA: 0x238F340 Offset: 0x238F441 VA: 0x238F340
	public void .ctor() { }

	// RVA: 0x238F350 Offset: 0x238F451 VA: 0x238F350
	internal void <CreateNationLevelUp>b__0(GameObject gameObject) { }
}

