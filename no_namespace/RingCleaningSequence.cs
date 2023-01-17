// Namespace: 
public enum RingCleaningSequence.Strength // TypeDefIndex: 11758
{
	// Fields
	public int value__; // 0x0
	public const RingCleaningSequence.Strength Strong = 0;
	public const RingCleaningSequence.Strength Weak = 1;
}

// Namespace: 
public enum RingCleaningSequence.GodType // TypeDefIndex: 11760
{
	// Fields
	public int value__; // 0x0
	public const RingCleaningSequence.GodType None = -1;
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

