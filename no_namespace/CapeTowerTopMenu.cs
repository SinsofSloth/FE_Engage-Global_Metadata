// Namespace: 
public enum CapeTowerTopMenu.Result2 // TypeDefIndex: 10469
{
	// Fields
	public int value__; // 0x0
	public const CapeTowerTopMenu.Result2 Challenge = 0;
	public const CapeTowerTopMenu.Result2 Relay = 1;
	public const CapeTowerTopMenu.Result2 Versus = 2;
	public const CapeTowerTopMenu.Result2 End = 3;
}

// Namespace: 
public sealed class CapeTowerTopMenu.DecideEventHandler : MulticastDelegate // TypeDefIndex: 10470
{
	// Methods

	// RVA: 0x1DFD1D0 Offset: 0x1DFD2D1 VA: 0x1DFD1D0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1DFCF70 Offset: 0x1DFD071 VA: 0x1DFCF70 Slot: 13
	public virtual void Invoke(CapeTowerTopMenu.Result2 result) { }

	// RVA: 0x1DFD1F0 Offset: 0x1DFD2F1 VA: 0x1DFD1F0 Slot: 14
	public virtual IAsyncResult BeginInvoke(CapeTowerTopMenu.Result2 result, AsyncCallback callback, object object) { }

	// RVA: 0x1DFD280 Offset: 0x1DFD381 VA: 0x1DFD280 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
private class CapeTowerTopMenu.ChallengeMenuItem : BasicMenuItem // TypeDefIndex: 10471
{
	// Fields
	public CapeTowerTopMenu.DecideEventHandler m_DecideEventHandler; // 0x68

	// Methods

	// RVA: 0x1DFC990 Offset: 0x1DFCA91 VA: 0x1DFC990
	public void .ctor(CapeTowerTopMenu.DecideEventHandler decideEventHandler) { }

	// RVA: 0x1DFCA40 Offset: 0x1DFCB41 VA: 0x1DFCA40 Slot: 8
	public override BasicMenuItem.Attribute BuildAttribute() { }

	// RVA: 0x1DFCB80 Offset: 0x1DFCC81 VA: 0x1DFCB80 Slot: 12
	public override void OnSelect() { }

	// RVA: 0x1DFCC40 Offset: 0x1DFCD41 VA: 0x1DFCC40 Slot: 10
	public override void OnBuild() { }

	// RVA: 0x1DFCEA0 Offset: 0x1DFCFA1 VA: 0x1DFCEA0 Slot: 18
	public override BasicMenu.Result ACall() { }
}

// Namespace: 
private class CapeTowerTopMenu.RelayMenuItem : BasicMenuItem // TypeDefIndex: 10472
{
	// Fields
	public CapeTowerTopMenu.DecideEventHandler m_DecideEventHandler; // 0x68

	// Methods

	// RVA: 0x1DFD290 Offset: 0x1DFD391 VA: 0x1DFD290
	public void .ctor(CapeTowerTopMenu.DecideEventHandler decideEventHandler) { }

	// RVA: 0x1DFD340 Offset: 0x1DFD441 VA: 0x1DFD340 Slot: 12
	public override void OnSelect() { }

	// RVA: 0x1DFD400 Offset: 0x1DFD501 VA: 0x1DFD400 Slot: 10
	public override void OnBuild() { }

	// RVA: 0x1DFD4F0 Offset: 0x1DFD5F1 VA: 0x1DFD4F0 Slot: 18
	public override BasicMenu.Result ACall() { }
}

// Namespace: 
private class CapeTowerTopMenu.VersusMenuItem : BasicMenuItem // TypeDefIndex: 10473
{
	// Fields
	public CapeTowerTopMenu.DecideEventHandler m_DecideEventHandler; // 0x68

	// Methods

	// RVA: 0x1DFD520 Offset: 0x1DFD621 VA: 0x1DFD520
	public void .ctor(CapeTowerTopMenu.DecideEventHandler decideEventHandler) { }

	// RVA: 0x1DFD5D0 Offset: 0x1DFD6D1 VA: 0x1DFD5D0 Slot: 12
	public override void OnSelect() { }

	// RVA: 0x1DFD690 Offset: 0x1DFD791 VA: 0x1DFD690 Slot: 10
	public override void OnBuild() { }

	// RVA: 0x1DFD780 Offset: 0x1DFD881 VA: 0x1DFD780 Slot: 18
	public override BasicMenu.Result ACall() { }
}

