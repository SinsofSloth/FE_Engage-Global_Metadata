// Namespace: 
private enum ItemUseSequence.Label // TypeDefIndex: 13002
{
	// Fields
	public int value__; // 0x0
	public const ItemUseSequence.Label Normal = 0;
	public const ItemUseSequence.Label ClassChange = 1;
	public const ItemUseSequence.Label End = 2;
}

// Namespace: 
private class ItemUseSequence.EnchantedUnitList : List<Unit> // TypeDefIndex: 13003
{
	// Methods

	// RVA: 0x222B4D0 Offset: 0x222B5D1 VA: 0x222B4D0
	public void Search() { }

	// RVA: 0x222B740 Offset: 0x222B841 VA: 0x222B740
	public void .ctor() { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x2789B0 Offset: 0x278AB1 VA: 0x2789B0
private sealed class ItemUseSequence.<>c__DisplayClass12_0 // TypeDefIndex: 13004
{
	// Fields
	public int heal; // 0x10
	public SkillData skill; // 0x18
	public bool result; // 0x20

	// Methods

	// RVA: 0x222A8E0 Offset: 0x222A9E1 VA: 0x222A8E0
	public void .ctor() { }

	// RVA: 0x222A8F0 Offset: 0x222A9F1 VA: 0x222A8F0
	internal void <HealHp>b__0(Unit target) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x2789C0 Offset: 0x278AC1 VA: 0x2789C0
private sealed class ItemUseSequence.<HealHp>d__12 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 13005
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public ItemUseSequence <>4__this; // 0x20
	private ItemUseSequence.<>c__DisplayClass12_0 <>8__1; // 0x28
	private Unit <target>5__2; // 0x30

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x2CACF0 Offset: 0x2CADF1 VA: 0x2CACF0
	// RVA: 0x222ADB0 Offset: 0x222AEB1 VA: 0x222ADB0
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x2CAD00 Offset: 0x2CAE01 VA: 0x2CAD00
	// RVA: 0x222ADE0 Offset: 0x222AEE1 VA: 0x222ADE0 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x222ADF0 Offset: 0x222AEF1 VA: 0x222ADF0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x2CAD10 Offset: 0x2CAE11 VA: 0x2CAD10
	// RVA: 0x222B470 Offset: 0x222B571 VA: 0x222B470 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x2CAD20 Offset: 0x2CAE21 VA: 0x2CAD20
	// RVA: 0x222B480 Offset: 0x222B581 VA: 0x222B480 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x2CAD30 Offset: 0x2CAE31 VA: 0x2CAD30
	// RVA: 0x222B4C0 Offset: 0x222B5C1 VA: 0x222B4C0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x2789D0 Offset: 0x278AD1 VA: 0x2789D0
private sealed class ItemUseSequence.<Expend>d__21 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 13006
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public ItemUseSequence <>4__this; // 0x20
	private bool <isExpend>5__2; // 0x28
	private int <unitItemIndex>5__3; // 0x2C
	private UnitItem <unitItem>5__4; // 0x30

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x2CAD40 Offset: 0x2CAE41 VA: 0x2CAD40
	// RVA: 0x222A950 Offset: 0x222AA51 VA: 0x222A950
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x2CAD50 Offset: 0x2CAE51 VA: 0x2CAD50
	// RVA: 0x222A980 Offset: 0x222AA81 VA: 0x222A980 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x222A990 Offset: 0x222AA91 VA: 0x222A990 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x2CAD60 Offset: 0x2CAE61 VA: 0x2CAD60
	// RVA: 0x222AD50 Offset: 0x222AE51 VA: 0x222AD50 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x2CAD70 Offset: 0x2CAE71 VA: 0x2CAD70
	// RVA: 0x222AD60 Offset: 0x222AE61 VA: 0x222AD60 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x2CAD80 Offset: 0x2CAE81 VA: 0x2CAD80
	// RVA: 0x222ADA0 Offset: 0x222AEA1 VA: 0x222ADA0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

