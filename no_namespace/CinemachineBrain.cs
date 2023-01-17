// Namespace: 
[DocumentationSortingAttribute] // RVA: 0x1A700 Offset: 0x1A801 VA: 0x1A700
public enum CinemachineBrain.UpdateMethod // TypeDefIndex: 5733
{
	// Fields
	public int value__; // 0x0
	public const CinemachineBrain.UpdateMethod FixedUpdate = 0;
	public const CinemachineBrain.UpdateMethod LateUpdate = 1;
	public const CinemachineBrain.UpdateMethod SmartUpdate = 2;
	public const CinemachineBrain.UpdateMethod ManualUpdate = 3;
}

// Namespace: 
[DocumentationSortingAttribute] // RVA: 0x1A720 Offset: 0x1A821 VA: 0x1A720
public enum CinemachineBrain.BrainUpdateMethod // TypeDefIndex: 5734
{
	// Fields
	public int value__; // 0x0
	public const CinemachineBrain.BrainUpdateMethod FixedUpdate = 0;
	public const CinemachineBrain.BrainUpdateMethod LateUpdate = 1;
}

// Namespace: 
[Serializable]
public class CinemachineBrain.BrainEvent : UnityEvent<CinemachineBrain> // TypeDefIndex: 5735
{
	// Methods

	// RVA: 0x1A88040 Offset: 0x1A88141 VA: 0x1A88040
	public void .ctor() { }
}

// Namespace: 
[Serializable]
public class CinemachineBrain.VcamActivatedEvent : UnityEvent<ICinemachineCamera, ICinemachineCamera> // TypeDefIndex: 5736
{
	// Methods

	// RVA: 0x1A881C0 Offset: 0x1A882C1 VA: 0x1A881C0
	public void .ctor() { }
}

// Namespace: 
private class CinemachineBrain.BrainFrame // TypeDefIndex: 5737
{
	// Fields
	public int id; // 0x10
	public CinemachineBlend blend; // 0x18
	public CinemachineBlend workingBlend; // 0x20
	public BlendSourceVirtualCamera workingBlendSource; // 0x28
	public float deltaTimeOverride; // 0x30

	// Properties
	public bool Active { get; }

	// Methods

	// RVA: 0x1A880A0 Offset: 0x1A881A1 VA: 0x1A880A0
	public bool get_Active() { }

	// RVA: 0x1A880B0 Offset: 0x1A881B1 VA: 0x1A880B0
	public void .ctor() { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x1A740 Offset: 0x1A841 VA: 0x1A740
private sealed class CinemachineBrain.<AfterPhysics>d__32 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 5738
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public CinemachineBrain <>4__this; // 0x20

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x23530 Offset: 0x23631 VA: 0x23530
	// RVA: 0x1A87E70 Offset: 0x1A87F71 VA: 0x1A87E70
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x23540 Offset: 0x23641 VA: 0x23540
	// RVA: 0x1A87EA0 Offset: 0x1A87FA1 VA: 0x1A87EA0 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1A87EB0 Offset: 0x1A87FB1 VA: 0x1A87EB0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x23550 Offset: 0x23651 VA: 0x23550
	// RVA: 0x1A87FE0 Offset: 0x1A880E1 VA: 0x1A87FE0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x23560 Offset: 0x23661 VA: 0x23560
	// RVA: 0x1A87FF0 Offset: 0x1A880F1 VA: 0x1A87FF0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x23570 Offset: 0x23671 VA: 0x23570
	// RVA: 0x1A88030 Offset: 0x1A88131 VA: 0x1A88030 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

