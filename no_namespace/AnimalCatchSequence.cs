// Namespace: 
public enum AnimalCatchSequence.Label // TypeDefIndex: 10430
{
	// Fields
	public int value__; // 0x0
	public const AnimalCatchSequence.Label Init = 0;
	public const AnimalCatchSequence.Label Main = 1;
	public const AnimalCatchSequence.Label End = 2;
}

// Namespace: 
private class AnimalCatchSequence.CatchConfirm.ConfirmDialogItemYes : BasicDialogItemYes // TypeDefIndex: 10431
{
	// Methods

	// RVA: 0x1DC0920 Offset: 0x1DC0A21 VA: 0x1DC0920
	public void .ctor() { }

	// RVA: 0x1DC09B0 Offset: 0x1DC0AB1 VA: 0x1DC09B0 Slot: 18
	public override BasicMenu.Result ACall() { }
}

// Namespace: 
public class AnimalCatchSequence.CatchConfirm.ConfirmDialogItemNo : BasicDialogItemNo // TypeDefIndex: 10432
{
	// Methods

	// RVA: 0x1DC0890 Offset: 0x1DC0991 VA: 0x1DC0890
	public void .ctor() { }
}

// Namespace: 
private class AnimalCatchSequence.CatchConfirm : YesNoDialog // TypeDefIndex: 10433
{
	// Methods

	// RVA: 0x1F5EB70 Offset: 0x1F5EC71 VA: 0x1F5EB70
	private void .ctor(List<BasicMenuItem> menuItemList) { }

	// RVA: 0x1F5EBF0 Offset: 0x1F5ECF1 VA: 0x1F5EBF0
	public static void CreateBind(ProcInst super) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x276B50 Offset: 0x276C51 VA: 0x276B50
private sealed class AnimalCatchSequence.<MainCapture>d__18 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 10434
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public AnimalCatchSequence <>4__this; // 0x20
	private HubUnitController <animal>5__2; // 0x28
	private float <t>5__3; // 0x30

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x2BE120 Offset: 0x2BE221 VA: 0x2BE120
	// RVA: 0x1F5E6A0 Offset: 0x1F5E7A1 VA: 0x1F5E6A0
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x2BE130 Offset: 0x2BE231 VA: 0x2BE130
	// RVA: 0x1F5E6D0 Offset: 0x1F5E7D1 VA: 0x1F5E6D0 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1F5E6E0 Offset: 0x1F5E7E1 VA: 0x1F5E6E0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x2BE140 Offset: 0x2BE241 VA: 0x2BE140
	// RVA: 0x1F5EB10 Offset: 0x1F5EC11 VA: 0x1F5EB10 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x2BE150 Offset: 0x2BE251 VA: 0x2BE150
	// RVA: 0x1F5EB20 Offset: 0x1F5EC21 VA: 0x1F5EB20 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x2BE160 Offset: 0x2BE261 VA: 0x2BE160
	// RVA: 0x1F5EB60 Offset: 0x1F5EC61 VA: 0x1F5EB60 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

