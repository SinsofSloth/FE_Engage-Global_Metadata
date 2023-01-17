// Namespace: 
public enum RingCleaningSequence.Label // TypeDefIndex: 11757
{
	// Fields
	public int value__; // 0x0
	public const RingCleaningSequence.Label Init = 0;
	public const RingCleaningSequence.Label Tick = 1;
	public const RingCleaningSequence.Label TickContinue = 2;
	public const RingCleaningSequence.Label FinishCleaning = 3;
	public const RingCleaningSequence.Label ResetRotation = 4;
	public const RingCleaningSequence.Label PlayTelop = 5;
	public const RingCleaningSequence.Label End = 6;
}

// Namespace: 
public enum RingCleaningSequence.Strength // TypeDefIndex: 11758
{
	// Fields
	public int value__; // 0x0
	public const RingCleaningSequence.Strength Strong = 0;
	public const RingCleaningSequence.Strength Weak = 1;
}

// Namespace: 
public enum RingCleaningSequence.HitResult // TypeDefIndex: 11759
{
	// Fields
	public int value__; // 0x0
	public const RingCleaningSequence.HitResult NotHit = 0;
	public const RingCleaningSequence.HitResult Near = 1;
	public const RingCleaningSequence.HitResult Hit = 2;
}

// Namespace: 
public enum RingCleaningSequence.GodType // TypeDefIndex: 11760
{
	// Fields
	public int value__; // 0x0
	public const RingCleaningSequence.GodType None = -1;
}

// Namespace: 
private enum RingCleaningSequence.RButtonHoldSequence.Label // TypeDefIndex: 11761
{
	// Fields
	public int value__; // 0x0
	public const RingCleaningSequence.RButtonHoldSequence.Label End = 0;
}

// Namespace: 
private class RingCleaningSequence.RButtonHoldSequence : ProcInst // TypeDefIndex: 11762
{
	// Fields
	private RingCleaningCloth m_Cloth; // 0x70
	private Action m_Callback; // 0x78
	private int m_HoldCounter; // 0x80
	private readonly int HoldCounterThreshold; // 0x84
	private bool m_IsTrigger; // 0x88
	private readonly float GapSize; // 0x8C

	// Methods

	// RVA: 0x1F49620 Offset: 0x1F49721 VA: 0x1F49620
	private void .ctor(RingCleaningCloth cloth, Action callback) { }

	// RVA: 0x1F49690 Offset: 0x1F49791 VA: 0x1F49690
	private void Start() { }

	// RVA: 0x1F49710 Offset: 0x1F49811 VA: 0x1F49710
	private void Tick() { }

	// RVA: 0x1F49E30 Offset: 0x1F49F31 VA: 0x1F49E30
	private void PlayRubEffect() { }

	// RVA: 0x1F49E90 Offset: 0x1F49F91 VA: 0x1F49E90
	private void End() { }

	// RVA: 0x1F49F30 Offset: 0x1F4A031 VA: 0x1F49F30
	public static void CreateBind(ProcInst super, RingCleaningCloth cloth, Action callback) { }
}

// Namespace: 
private class RingCleaningSequence.ExitConfirmDialog : YesNoDialog // TypeDefIndex: 11763
{
	// Methods

	// RVA: 0x1F492E0 Offset: 0x1F493E1 VA: 0x1F492E0
	private void .ctor(List<BasicMenuItem> menuItemList) { }

	// RVA: 0x1F49380 Offset: 0x1F49481 VA: 0x1F49380
	public static void CreateBind(ProcInst super, Action action) { }
}

// Namespace: 
private class RingCleaningSequence.ConfirmDialogItemYes : BasicDialogItemYes // TypeDefIndex: 11764
{
	// Fields
	private Action m_Action; // 0x70

	// Methods

	// RVA: 0x1F49270 Offset: 0x1F49371 VA: 0x1F49270
	public void .ctor(Action action, string text) { }

	// RVA: 0x1F492B0 Offset: 0x1F493B1 VA: 0x1F492B0 Slot: 18
	public override BasicMenu.Result ACall() { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x277AC0 Offset: 0x277BC1 VA: 0x277AC0
private sealed class RingCleaningSequence.<>c__DisplayClass57_0 // TypeDefIndex: 11765
{
	// Fields
	public RingColliderPart part; // 0x10
	public RingCleaningSequence <>4__this; // 0x18

	// Methods

	// RVA: 0x1F48EB0 Offset: 0x1F48FB1 VA: 0x1F48EB0
	public void .ctor() { }

	// RVA: 0x1F48EC0 Offset: 0x1F48FC1 VA: 0x1F48EC0
	internal void <Tick>b__1() { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x277AD0 Offset: 0x277BD1 VA: 0x277AD0
private sealed class RingCleaningSequence.<ResetRotation>d__67 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 11766
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public RingCleaningSequence <>4__this; // 0x20

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x2C6790 Offset: 0x2C6891 VA: 0x2C6790
	// RVA: 0x1F49120 Offset: 0x1F49221 VA: 0x1F49120
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x2C67A0 Offset: 0x2C68A1 VA: 0x2C67A0
	// RVA: 0x1F49150 Offset: 0x1F49251 VA: 0x1F49150 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1F49160 Offset: 0x1F49261 VA: 0x1F49160 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x2C67B0 Offset: 0x2C68B1 VA: 0x2C67B0
	// RVA: 0x1F49210 Offset: 0x1F49311 VA: 0x1F49210 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x2C67C0 Offset: 0x2C68C1 VA: 0x2C67C0
	// RVA: 0x1F49220 Offset: 0x1F49321 VA: 0x1F49220 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x2C67D0 Offset: 0x2C68D1 VA: 0x2C67D0
	// RVA: 0x1F49260 Offset: 0x1F49361 VA: 0x1F49260 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x277AE0 Offset: 0x277BE1 VA: 0x277AE0
private sealed class RingCleaningSequence.<PlayTelop>d__68 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 11767
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public RingCleaningSequence <>4__this; // 0x20
	private GameObject <finishTelop>5__2; // 0x28

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x2C67E0 Offset: 0x2C68E1 VA: 0x2C67E0
	// RVA: 0x1F48F00 Offset: 0x1F49001 VA: 0x1F48F00
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x2C67F0 Offset: 0x2C68F1 VA: 0x2C67F0
	// RVA: 0x1F48F30 Offset: 0x1F49031 VA: 0x1F48F30 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1F48F40 Offset: 0x1F49041 VA: 0x1F48F40 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x2C6800 Offset: 0x2C6901 VA: 0x2C6800
	// RVA: 0x1F490C0 Offset: 0x1F491C1 VA: 0x1F490C0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x2C6810 Offset: 0x2C6911 VA: 0x2C6810
	// RVA: 0x1F490D0 Offset: 0x1F491D1 VA: 0x1F490D0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x2C6820 Offset: 0x2C6921 VA: 0x2C6820
	// RVA: 0x1F49110 Offset: 0x1F49211 VA: 0x1F49110 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

