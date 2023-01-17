// Namespace: 
public sealed class ProfileCardStampMenu.DisposeEventHandler : MulticastDelegate // TypeDefIndex: 11631
{
	// Methods

	// RVA: 0x1F27F00 Offset: 0x1F28001 VA: 0x1F27F00
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1F27F20 Offset: 0x1F28021 VA: 0x1F27F20 Slot: 13
	public virtual void Invoke() { }

	// RVA: 0x1F28130 Offset: 0x1F28231 VA: 0x1F28130 Slot: 14
	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

	// RVA: 0x1F28160 Offset: 0x1F28261 VA: 0x1F28160 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
private enum ProfileCardStampMenu.EditMode // TypeDefIndex: 11632
{
	// Fields
	public int value__; // 0x0
	public const ProfileCardStampMenu.EditMode Stamp = 0;
	public const ProfileCardStampMenu.EditMode HoldHand = 1;
	public const ProfileCardStampMenu.EditMode FreeHand = 2;
	public const ProfileCardStampMenu.EditMode Eraser = 3;
}

// Namespace: 
public sealed class ProfileCardStampMenu.ConfirmToCloseDialog.DecideEventHandler : MulticastDelegate // TypeDefIndex: 11633
{
	// Methods

	// RVA: 0x21F26E0 Offset: 0x21F27E1 VA: 0x21F26E0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x21F2700 Offset: 0x21F2801 VA: 0x21F2700 Slot: 13
	public virtual void Invoke() { }

	// RVA: 0x21F2910 Offset: 0x21F2A11 VA: 0x21F2910 Slot: 14
	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

	// RVA: 0x21F2940 Offset: 0x21F2A41 VA: 0x21F2940 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
private class ProfileCardStampMenu.ConfirmToCloseDialog // TypeDefIndex: 11634
{
	// Methods

	// RVA: 0x1F27BF0 Offset: 0x1F27CF1 VA: 0x1F27BF0
	public static BasicDialog CreateBind(ProcInst super, ProfileCardStampMenu.ConfirmToCloseDialog.DecideEventHandler saveAndCloseEventHandler, ProfileCardStampMenu.ConfirmToCloseDialog.DecideEventHandler noSaveAndCloseEventHandler) { }

	// RVA: 0x1F27EC0 Offset: 0x1F27FC1 VA: 0x1F27EC0
	public void .ctor() { }
}

// Namespace: 
public sealed class ProfileCardStampMenu.ConfirmToClearDialog.DecideEventHandler : MulticastDelegate // TypeDefIndex: 11635
{
	// Methods

	// RVA: 0x21F2470 Offset: 0x21F2571 VA: 0x21F2470
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x21F2490 Offset: 0x21F2591 VA: 0x21F2490 Slot: 13
	public virtual void Invoke() { }

	// RVA: 0x21F26A0 Offset: 0x21F27A1 VA: 0x21F26A0 Slot: 14
	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

	// RVA: 0x21F26D0 Offset: 0x21F27D1 VA: 0x21F26D0 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
private class ProfileCardStampMenu.ConfirmToClearDialog // TypeDefIndex: 11636
{
	// Methods

	// RVA: 0x1F27950 Offset: 0x1F27A51 VA: 0x1F27950
	public static BasicDialog CreateBind(ProcInst super, ProfileCardStampMenu.ConfirmToCloseDialog.DecideEventHandler yesEventHandler) { }

	// RVA: 0x1F27BE0 Offset: 0x1F27CE1 VA: 0x1F27BE0
	public void .ctor() { }
}

// Namespace: 
private class ProfileCardStampMenu.DialogMenuItem : BasicDialogItem // TypeDefIndex: 11637
{
	// Fields
	private ProfileCardStampMenu.ConfirmToCloseDialog.DecideEventHandler m_DecideEventHandler; // 0x70

	// Methods

	// RVA: 0x1F27BA0 Offset: 0x1F27CA1 VA: 0x1F27BA0
	public void .ctor(string message, ProfileCardStampMenu.ConfirmToCloseDialog.DecideEventHandler decideEventHandler) { }

	// RVA: 0x1F27ED0 Offset: 0x1F27FD1 VA: 0x1F27ED0 Slot: 18
	public override BasicMenu.Result ACall() { }
}

