// Namespace: 
public sealed class ArenaTopMenu.DecideEventHandler : MulticastDelegate // TypeDefIndex: 10925
{
	// Methods

	// RVA: 0x1F67A00 Offset: 0x1F67B01 VA: 0x1F67A00
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1F67A20 Offset: 0x1F67B21 VA: 0x1F67A20 Slot: 13
	public virtual void Invoke(bool goNext, int index) { }

	// RVA: 0x1F67C60 Offset: 0x1F67D61 VA: 0x1F67C60 Slot: 14
	public virtual IAsyncResult BeginInvoke(bool goNext, int index, AsyncCallback callback, object object) { }

	// RVA: 0x1F67D20 Offset: 0x1F67E21 VA: 0x1F67D20 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
private class ArenaTopMenu.TrainingMenuItem : BasicMenuItem // TypeDefIndex: 10926
{
	// Fields
	public ArenaTopMenu.DecideEventHandler m_DecideEventHandler; // 0x68
	private int m_Index; // 0x70
	private bool m_IsActive; // 0x74

	// Methods

	// RVA: 0x1F67D30 Offset: 0x1F67E31 VA: 0x1F67D30
	public void .ctor(ArenaTopMenu.DecideEventHandler decideEventHandler, int index, bool isActive) { }

	// RVA: 0x1F67F00 Offset: 0x1F68001 VA: 0x1F67F00 Slot: 8
	public override BasicMenuItem.Attribute BuildAttribute() { }

	// RVA: 0x1F67F20 Offset: 0x1F68021 VA: 0x1F67F20 Slot: 12
	public override void OnSelect() { }

	// RVA: 0x1F67FC0 Offset: 0x1F680C1 VA: 0x1F67FC0 Slot: 18
	public override BasicMenu.Result ACall() { }
}

