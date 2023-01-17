// Namespace: 
public enum RefreshUnitSetDecideMenu.Result2 // TypeDefIndex: 11720
{
	// Fields
	public int value__; // 0x0
	public const RefreshUnitSetDecideMenu.Result2 Ok = 0;
	public const RefreshUnitSetDecideMenu.Result2 Cancel = 1;
}

// Namespace: 
public sealed class RefreshUnitSetDecideMenu.KeyUpEventHandler : MulticastDelegate // TypeDefIndex: 11721
{
	// Methods

	// RVA: 0x1F3B600 Offset: 0x1F3B701 VA: 0x1F3B600
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1F3B620 Offset: 0x1F3B721 VA: 0x1F3B620 Slot: 13
	public virtual void Invoke() { }

	// RVA: 0x1F3B830 Offset: 0x1F3B931 VA: 0x1F3B830 Slot: 14
	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

	// RVA: 0x1F3B860 Offset: 0x1F3B961 VA: 0x1F3B860 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
public sealed class RefreshUnitSetDecideMenu.KeyDownEventHandler : MulticastDelegate // TypeDefIndex: 11722
{
	// Methods

	// RVA: 0x1F3B390 Offset: 0x1F3B491 VA: 0x1F3B390
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1F3B3B0 Offset: 0x1F3B4B1 VA: 0x1F3B3B0 Slot: 13
	public virtual void Invoke() { }

	// RVA: 0x1F3B5C0 Offset: 0x1F3B6C1 VA: 0x1F3B5C0 Slot: 14
	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

	// RVA: 0x1F3B5F0 Offset: 0x1F3B6F1 VA: 0x1F3B5F0 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
public sealed class RefreshUnitSetDecideMenu.DecideEventHandler : MulticastDelegate // TypeDefIndex: 11723
{
	// Methods

	// RVA: 0x1F3B070 Offset: 0x1F3B171 VA: 0x1F3B070
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1F3B090 Offset: 0x1F3B191 VA: 0x1F3B090 Slot: 13
	public virtual void Invoke(RefreshUnitSetDecideMenu.Result2 result) { }

	// RVA: 0x1F3B2F0 Offset: 0x1F3B3F1 VA: 0x1F3B2F0 Slot: 14
	public virtual IAsyncResult BeginInvoke(RefreshUnitSetDecideMenu.Result2 result, AsyncCallback callback, object object) { }

	// RVA: 0x1F3B380 Offset: 0x1F3B481 VA: 0x1F3B380 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
private class RefreshUnitSetDecideMenu.RefreshUnitSetDecideMenuItem : BasicMenuItem // TypeDefIndex: 11724
{
	// Fields
	private bool m_Enabled; // 0x64
	private bool m_Usabled; // 0x65
	private RefreshUnitSetDecideMenu.DecideEventHandler m_DecideEventHandler; // 0x68

	// Methods

	// RVA: 0x1F3B870 Offset: 0x1F3B971 VA: 0x1F3B870
	public void .ctor(bool enabled, bool usabled, RefreshUnitSetDecideMenu.DecideEventHandler decideEventHandler) { }

	// RVA: 0x1F3B8D0 Offset: 0x1F3B9D1 VA: 0x1F3B8D0 Slot: 10
	public override void OnBuild() { }

	// RVA: 0x1F3B8E0 Offset: 0x1F3B9E1 VA: 0x1F3B8E0 Slot: 11
	public override void OnBuildMenuItemContent() { }

	// RVA: 0x1F3B8F0 Offset: 0x1F3B9F1 VA: 0x1F3B8F0
	public void SetInitialColor() { }

	// RVA: 0x1F3B9F0 Offset: 0x1F3BAF1 VA: 0x1F3B9F0 Slot: 4
	public override string GetName() { }

	// RVA: 0x1F3BA40 Offset: 0x1F3BB41 VA: 0x1F3BA40 Slot: 8
	public override BasicMenuItem.Attribute BuildAttribute() { }

	// RVA: 0x1F3BA60 Offset: 0x1F3BB61 VA: 0x1F3BA60
	public void UpdateEnabled(bool enabled, bool usabled) { }

	// RVA: 0x1F3BB50 Offset: 0x1F3BC51 VA: 0x1F3BB50 Slot: 13
	public override void OnDeselect() { }

	// RVA: 0x1F3BBE0 Offset: 0x1F3BCE1 VA: 0x1F3BBE0 Slot: 14
	public override void OnCursorMoveEnd() { }

	// RVA: 0x1F3BC90 Offset: 0x1F3BD91 VA: 0x1F3BC90 Slot: 18
	public override BasicMenu.Result ACall() { }

	// RVA: 0x1F3BD70 Offset: 0x1F3BE71 VA: 0x1F3BD70 Slot: 19
	public override BasicMenu.Result BCall() { }
}

