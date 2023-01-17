// Namespace: 
public enum HubMiniMap.MapMode // TypeDefIndex: 10732
{
	// Fields
	public int value__; // 0x0
	public const HubMiniMap.MapMode None = 0;
	public const HubMiniMap.MapMode Small = 1;
	public const HubMiniMap.MapMode Large = 2;
}

// Namespace: 
private class HubMiniMap.IconData // TypeDefIndex: 10733
{
	// Fields
	public HubAccess access; // 0x10
	public GameObject iconS; // 0x18
	public GameObject iconL; // 0x20
	public RectTransform iconSRect; // 0x28
	public RectTransform iconLRect; // 0x30
	public Image imageS; // 0x38
	public Image imageL; // 0x40
	public Image talkS; // 0x48
	public Image talkL; // 0x50
	public bool m_active; // 0x58

	// Methods

	// RVA: 0x1FB4630 Offset: 0x1FB4731 VA: 0x1FB4630
	public void SetActive(bool active) { }

	// RVA: 0x1FB4690 Offset: 0x1FB4791 VA: 0x1FB4690
	public void .ctor() { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x277220 Offset: 0x277321 VA: 0x277220
private sealed class HubMiniMap.<Load>d__67 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 10734
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public HubMiniMap <>4__this; // 0x20
	private string <prefixlessCid>5__2; // 0x28

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x2C0B00 Offset: 0x2C0C01 VA: 0x2C0B00
	// RVA: 0x1FB4180 Offset: 0x1FB4281 VA: 0x1FB4180
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x2C0B10 Offset: 0x2C0C11 VA: 0x2C0B10
	// RVA: 0x1FB41B0 Offset: 0x1FB42B1 VA: 0x1FB41B0 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1FB41C0 Offset: 0x1FB42C1 VA: 0x1FB41C0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x2C0B20 Offset: 0x2C0C21 VA: 0x2C0B20
	// RVA: 0x1FB45D0 Offset: 0x1FB46D1 VA: 0x1FB45D0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x2C0B30 Offset: 0x2C0C31 VA: 0x2C0B30
	// RVA: 0x1FB45E0 Offset: 0x1FB46E1 VA: 0x1FB45E0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x2C0B40 Offset: 0x2C0C41 VA: 0x2C0B40
	// RVA: 0x1FB4620 Offset: 0x1FB4721 VA: 0x1FB4620 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

