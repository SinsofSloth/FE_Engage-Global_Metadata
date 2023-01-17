// Namespace: 
private enum HubCookingSequence.Label // TypeDefIndex: 10477
{
	// Fields
	public int value__; // 0x0
	public const HubCookingSequence.Label None = 0;
	public const HubCookingSequence.Label Init = 1;
	public const HubCookingSequence.Label SelectDish = 2;
	public const HubCookingSequence.Label SelectWithUnits = 3;
	public const HubCookingSequence.Label SelectFoodstuff = 4;
	public const HubCookingSequence.Label EndSelect = 5;
	public const HubCookingSequence.Label Cook = 6;
	public const HubCookingSequence.Label StartCookPlay = 7;
	public const HubCookingSequence.Label CookingResult = 8;
	public const HubCookingSequence.Label AddAchieve = 9;
	public const HubCookingSequence.Label QuitSelect = 10;
	public const HubCookingSequence.Label Exit = 11;
}

// Namespace: 
private enum HubCookingSequence.LookTarget // TypeDefIndex: 10478
{
	// Fields
	public int value__; // 0x0
	public const HubCookingSequence.LookTarget Camera = 0;
	public const HubCookingSequence.LookTarget Other = 1;
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x276BB0 Offset: 0x276CB1 VA: 0x276BB0
[Serializable]
private sealed class HubCookingSequence.<>c // TypeDefIndex: 10479
{
	// Fields
	public static readonly HubCookingSequence.<>c <>9; // 0x0
	public static Action <>9__32_1; // 0x8

	// Methods

	// RVA: 0x1FACF50 Offset: 0x1FAD051 VA: 0x1FACF50
	private static void .cctor() { }

	// RVA: 0x1FACFC0 Offset: 0x1FAD0C1 VA: 0x1FACFC0
	public void .ctor() { }

	// RVA: 0x1FACFD0 Offset: 0x1FAD0D1 VA: 0x1FACFD0
	internal void <OpenStartMenu>b__32_1() { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x276BC0 Offset: 0x276CC1 VA: 0x276BC0
private sealed class HubCookingSequence.<FightVoice>d__34 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 10480
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public HubCookingSequence <>4__this; // 0x20

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x2BE9C0 Offset: 0x2BEAC1 VA: 0x2BE9C0
	// RVA: 0x1FAD5B0 Offset: 0x1FAD6B1 VA: 0x1FAD5B0
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x2BE9D0 Offset: 0x2BEAD1 VA: 0x2BE9D0
	// RVA: 0x1FAD5E0 Offset: 0x1FAD6E1 VA: 0x1FAD5E0 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1FAD5F0 Offset: 0x1FAD6F1 VA: 0x1FAD5F0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x2BE9E0 Offset: 0x2BEAE1 VA: 0x2BE9E0
	// RVA: 0x1FAD790 Offset: 0x1FAD891 VA: 0x1FAD790 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x2BE9F0 Offset: 0x2BEAF1 VA: 0x2BE9F0
	// RVA: 0x1FAD7A0 Offset: 0x1FAD8A1 VA: 0x1FAD7A0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x2BEA00 Offset: 0x2BEB01 VA: 0x2BEA00
	// RVA: 0x1FAD7E0 Offset: 0x1FAD8E1 VA: 0x1FAD7E0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x276BD0 Offset: 0x276CD1 VA: 0x276BD0
private sealed class HubCookingSequence.<DoCooking>d__43 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 10481
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public HubCookingSequence <>4__this; // 0x20
	private string <voiceEvent>5__2; // 0x28
	private float <time>5__3; // 0x30

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x2BEA10 Offset: 0x2BEB11 VA: 0x2BEA10
	// RVA: 0x1FAD2E0 Offset: 0x1FAD3E1 VA: 0x1FAD2E0
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x2BEA20 Offset: 0x2BEB21 VA: 0x2BEA20
	// RVA: 0x1FAD310 Offset: 0x1FAD411 VA: 0x1FAD310 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1FAD320 Offset: 0x1FAD421 VA: 0x1FAD320 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x2BEA30 Offset: 0x2BEB31 VA: 0x2BEA30
	// RVA: 0x1FAD550 Offset: 0x1FAD651 VA: 0x1FAD550 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x2BEA40 Offset: 0x2BEB41 VA: 0x2BEA40
	// RVA: 0x1FAD560 Offset: 0x1FAD661 VA: 0x1FAD560 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x2BEA50 Offset: 0x2BEB51 VA: 0x2BEA50
	// RVA: 0x1FAD5A0 Offset: 0x1FAD6A1 VA: 0x1FAD5A0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x276BE0 Offset: 0x276CE1 VA: 0x276BE0
private sealed class HubCookingSequence.<>c__DisplayClass45_0 // TypeDefIndex: 10482
{
	// Fields
	public GameObject locator1; // 0x10
	public Transform cameraTransform; // 0x18
	public HubCookingSequence <>4__this; // 0x20

	// Methods

	// RVA: 0x1FAD080 Offset: 0x1FAD181 VA: 0x1FAD080
	public void .ctor() { }

	// RVA: 0x1FAD090 Offset: 0x1FAD191 VA: 0x1FAD090
	internal void <SetupSelectUnit>b__0(HubUnitController hubUnit) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x276BF0 Offset: 0x276CF1 VA: 0x276BF0
private sealed class HubCookingSequence.<RelianceUpWait>d__51 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 10483
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public HubCookingSequence <>4__this; // 0x20
	private bool <isTriggerA>5__2; // 0x28

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x2BEA60 Offset: 0x2BEB61 VA: 0x2BEA60
	// RVA: 0x1FADC50 Offset: 0x1FADD51 VA: 0x1FADC50
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x2BEA70 Offset: 0x2BEB71 VA: 0x2BEA70
	// RVA: 0x1FADC80 Offset: 0x1FADD81 VA: 0x1FADC80 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1FADC90 Offset: 0x1FADD91 VA: 0x1FADC90 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x2BEA80 Offset: 0x2BEB81 VA: 0x2BEA80
	// RVA: 0x1FADFB0 Offset: 0x1FAE0B1 VA: 0x1FADFB0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x2BEA90 Offset: 0x2BEB91 VA: 0x2BEA90
	// RVA: 0x1FADFC0 Offset: 0x1FAE0C1 VA: 0x1FADFC0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x2BEAA0 Offset: 0x2BEBA1 VA: 0x2BEAA0
	// RVA: 0x1FAE000 Offset: 0x1FAE101 VA: 0x1FAE000 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x276C00 Offset: 0x276D01 VA: 0x276C00
private sealed class HubCookingSequence.<PanCamera>d__58 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 10484
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public HubCookingSequence <>4__this; // 0x20

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x2BEAB0 Offset: 0x2BEBB1 VA: 0x2BEAB0
	// RVA: 0x1FAD7F0 Offset: 0x1FAD8F1 VA: 0x1FAD7F0
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x2BEAC0 Offset: 0x2BEBC1 VA: 0x2BEAC0
	// RVA: 0x1FAD820 Offset: 0x1FAD921 VA: 0x1FAD820 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1FAD830 Offset: 0x1FAD931 VA: 0x1FAD830 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x2BEAD0 Offset: 0x2BEBD1 VA: 0x2BEAD0
	// RVA: 0x1FADBF0 Offset: 0x1FADCF1 VA: 0x1FADBF0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x2BEAE0 Offset: 0x2BEBE1 VA: 0x2BEAE0
	// RVA: 0x1FADC00 Offset: 0x1FADD01 VA: 0x1FADC00 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x2BEAF0 Offset: 0x2BEBF1 VA: 0x2BEAF0
	// RVA: 0x1FADC40 Offset: 0x1FADD41 VA: 0x1FADC40 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x276C10 Offset: 0x276D11 VA: 0x276C10
private sealed class HubCookingSequence.<ShowBentoResult>d__66 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 10485
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public HubCookingSequence <>4__this; // 0x20

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x2BEB00 Offset: 0x2BEC01 VA: 0x2BEB00
	// RVA: 0x1FAE010 Offset: 0x1FAE111 VA: 0x1FAE010
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x2BEB10 Offset: 0x2BEC11 VA: 0x2BEB10
	// RVA: 0x1FAE040 Offset: 0x1FAE141 VA: 0x1FAE040 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1FAE050 Offset: 0x1FAE151 VA: 0x1FAE050 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x2BEB20 Offset: 0x2BEC21 VA: 0x2BEB20
	// RVA: 0x1FAE1C0 Offset: 0x1FAE2C1 VA: 0x1FAE1C0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x2BEB30 Offset: 0x2BEC31 VA: 0x2BEB30
	// RVA: 0x1FAE1D0 Offset: 0x1FAE2D1 VA: 0x1FAE1D0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x2BEB40 Offset: 0x2BEC41 VA: 0x2BEB40
	// RVA: 0x1FAE210 Offset: 0x1FAE311 VA: 0x1FAE210 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x276C20 Offset: 0x276D21 VA: 0x276C20
private sealed class HubCookingSequence.<>c__DisplayClass76_0 // TypeDefIndex: 10486
{
	// Fields
	public HubCookingSequence p; // 0x10

	// Methods

	// RVA: 0x1FAD250 Offset: 0x1FAD351 VA: 0x1FAD250
	public void .ctor() { }

	// RVA: 0x1FAD260 Offset: 0x1FAD361 VA: 0x1FAD260
	internal bool <CreateBind>b__0() { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x276C30 Offset: 0x276D31 VA: 0x276C30
private sealed class HubCookingSequence.<>c__DisplayClass77_0 // TypeDefIndex: 10487
{
	// Fields
	public HubCookingSequence <>4__this; // 0x10
	public Unit cookUnit; // 0x18

	// Methods

	// RVA: 0x1FAD270 Offset: 0x1FAD371 VA: 0x1FAD270
	public void .ctor() { }

	// RVA: 0x1FAD280 Offset: 0x1FAD381 VA: 0x1FAD280
	internal void <GetCurrentCookUnit>b__0(Unit unit) { }
}

