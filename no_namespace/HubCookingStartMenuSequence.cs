// Namespace: 
public sealed class HubCookingStartMenuSequence.DecideEventHandler : MulticastDelegate // TypeDefIndex: 14213
{
	// Methods

	// RVA: 0x1FAE360 Offset: 0x1FAE461 VA: 0x1FAE360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1FAE380 Offset: 0x1FAE481 VA: 0x1FAE380 Slot: 13
	public virtual void Invoke(List<Unit> units, FoodData food, List<FoodstuffData> foodstuffs, Action addAction) { }

	// RVA: 0x1FAE740 Offset: 0x1FAE841 VA: 0x1FAE740 Slot: 14
	public virtual IAsyncResult BeginInvoke(List<Unit> units, FoodData food, List<FoodstuffData> foodstuffs, Action addAction, AsyncCallback callback, object object) { }

	// RVA: 0x1FAE780 Offset: 0x1FAE881 VA: 0x1FAE780 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
private enum HubCookingStartMenuSequence.Label // TypeDefIndex: 14214
{
	// Fields
	public int value__; // 0x0
	public const HubCookingStartMenuSequence.Label SelectUnit = 0;
	public const HubCookingStartMenuSequence.Label SelectFood = 1;
	public const HubCookingStartMenuSequence.Label SelectFoodstuff = 2;
	public const HubCookingStartMenuSequence.Label Confirm = 3;
	public const HubCookingStartMenuSequence.Label Decide = 4;
	public const HubCookingStartMenuSequence.Label End = 5;
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x279820 Offset: 0x279921 VA: 0x279820
private sealed class HubCookingStartMenuSequence.<DeleteHistory>d__22 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 14215
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public HubCookingStartMenuSequence <>4__this; // 0x20

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x2CE390 Offset: 0x2CE491 VA: 0x2CE390
	// RVA: 0x1FAE220 Offset: 0x1FAE321 VA: 0x1FAE220
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x2CE3A0 Offset: 0x2CE4A1 VA: 0x2CE3A0
	// RVA: 0x1FAE250 Offset: 0x1FAE351 VA: 0x1FAE250 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1FAE260 Offset: 0x1FAE361 VA: 0x1FAE260 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x2CE3B0 Offset: 0x2CE4B1 VA: 0x2CE3B0
	// RVA: 0x1FAE300 Offset: 0x1FAE401 VA: 0x1FAE300 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x2CE3C0 Offset: 0x2CE4C1 VA: 0x2CE3C0
	// RVA: 0x1FAE310 Offset: 0x1FAE411 VA: 0x1FAE310 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x2CE3D0 Offset: 0x2CE4D1 VA: 0x2CE3D0
	// RVA: 0x1FAE350 Offset: 0x1FAE451 VA: 0x1FAE350 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

