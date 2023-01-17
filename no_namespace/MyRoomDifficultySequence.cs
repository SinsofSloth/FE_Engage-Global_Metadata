// Namespace: 
public sealed class MyRoomDifficultySequence.YesMenuItem.YesEventHandler : MulticastDelegate // TypeDefIndex: 11297
{
	// Methods

	// RVA: 0x21ED170 Offset: 0x21ED271 VA: 0x21ED170
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x21ED190 Offset: 0x21ED291 VA: 0x21ED190 Slot: 13
	public virtual void Invoke() { }

	// RVA: 0x21ED3A0 Offset: 0x21ED4A1 VA: 0x21ED3A0 Slot: 14
	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

	// RVA: 0x21ED3D0 Offset: 0x21ED4D1 VA: 0x21ED3D0 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
private class MyRoomDifficultySequence.YesMenuItem : BasicDialogItemYes // TypeDefIndex: 11298
{
	// Fields
	private MyRoomDifficultySequence.YesMenuItem.YesEventHandler m_YesEventHandler; // 0x70

	// Methods

	// RVA: 0x26DD680 Offset: 0x26DD781 VA: 0x26DD680
	public void .ctor(string message, MyRoomDifficultySequence.YesMenuItem.YesEventHandler yesEventHandler) { }

	// RVA: 0x26DD6C0 Offset: 0x26DD7C1 VA: 0x26DD6C0 Slot: 8
	public override BasicMenuItem.Attribute BuildAttribute() { }

	// RVA: 0x26DD6D0 Offset: 0x26DD7D1 VA: 0x26DD6D0 Slot: 18
	public override BasicMenu.Result ACall() { }
}

// Namespace: 
private class MyRoomDifficultySequence.NoMenuItem : BasicDialogItemNo // TypeDefIndex: 11299
{
	// Methods

	// RVA: 0x26DD660 Offset: 0x26DD761 VA: 0x26DD660 Slot: 8
	public override BasicMenuItem.Attribute BuildAttribute() { }

	// RVA: 0x26DD670 Offset: 0x26DD771 VA: 0x26DD670
	public void .ctor() { }
}

