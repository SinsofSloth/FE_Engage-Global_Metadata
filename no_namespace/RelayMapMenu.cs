// Namespace: 
public sealed class RelayMapMenu.SelectEventHandler : MulticastDelegate // TypeDefIndex: 12873
{
	// Methods

	// RVA: 0x1F3EB80 Offset: 0x1F3EC81 VA: 0x1F3EB80
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1F3E580 Offset: 0x1F3E681 VA: 0x1F3E580 Slot: 13
	public virtual void Invoke(RelayData relayData) { }

	// RVA: 0x1F3EBA0 Offset: 0x1F3ECA1 VA: 0x1F3EBA0 Slot: 14
	public virtual IAsyncResult BeginInvoke(RelayData relayData, AsyncCallback callback, object object) { }

	// RVA: 0x1F3EBD0 Offset: 0x1F3ECD1 VA: 0x1F3EBD0 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
public sealed class RelayMapMenu.DecideEventHandler : MulticastDelegate // TypeDefIndex: 12874
{
	// Methods

	// RVA: 0x1F3E1E0 Offset: 0x1F3E2E1 VA: 0x1F3E1E0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1F3E200 Offset: 0x1F3E301 VA: 0x1F3E200 Slot: 13
	public virtual void Invoke() { }

	// RVA: 0x1F3E410 Offset: 0x1F3E511 VA: 0x1F3E410 Slot: 14
	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

	// RVA: 0x1F3E440 Offset: 0x1F3E541 VA: 0x1F3E440 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
public sealed class RelayMapMenu.RequestCloseEventHandler : MulticastDelegate // TypeDefIndex: 12875
{
	// Methods

	// RVA: 0x1F3E910 Offset: 0x1F3EA11 VA: 0x1F3E910
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1F3E930 Offset: 0x1F3EA31 VA: 0x1F3E930 Slot: 13
	public virtual void Invoke() { }

	// RVA: 0x1F3EB40 Offset: 0x1F3EC41 VA: 0x1F3EB40 Slot: 14
	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

	// RVA: 0x1F3EB70 Offset: 0x1F3EC71 VA: 0x1F3EB70 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
private class RelayMapMenu.MapMenuItem : BasicMenuItem // TypeDefIndex: 12876
{
	// Fields
	private RelayData m_Rdata; // 0x68
	private RelayMapMenu.SelectEventHandler m_SelectEventHandler; // 0x70

	// Methods

	// RVA: 0x1F3E450 Offset: 0x1F3E551 VA: 0x1F3E450
	public void .ctor(ChapterData cdata, RelayMapMenu.SelectEventHandler selectEventHandler) { }

	// RVA: 0x1F3E530 Offset: 0x1F3E631 VA: 0x1F3E530 Slot: 11
	public override void OnBuildMenuItemContent() { }

	// RVA: 0x1F3E540 Offset: 0x1F3E641 VA: 0x1F3E540 Slot: 12
	public override void OnSelect() { }

	// RVA: 0x1F3E8E0 Offset: 0x1F3E9E1 VA: 0x1F3E8E0 Slot: 18
	public override BasicMenu.Result ACall() { }
}

