// Namespace: 
public sealed class ProfileCardStampVisibilitySettingDialog.DecideEventHandler : MulticastDelegate // TypeDefIndex: 11641
{
	// Methods

	// RVA: 0x1F282B0 Offset: 0x1F283B1 VA: 0x1F282B0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1F282D0 Offset: 0x1F283D1 VA: 0x1F282D0 Slot: 13
	public virtual void Invoke() { }

	// RVA: 0x1F284E0 Offset: 0x1F285E1 VA: 0x1F284E0 Slot: 14
	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

	// RVA: 0x1F28510 Offset: 0x1F28611 VA: 0x1F28510 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
private class ProfileCardStampVisibilitySettingDialog.DialogMenuItem : BasicDialogItem // TypeDefIndex: 11642
{
	// Fields
	private ProfileCardStampVisibilitySettingDialog.DecideEventHandler m_DecideEventHandler; // 0x70

	// Methods

	// RVA: 0x1F28520 Offset: 0x1F28621 VA: 0x1F28520
	public void .ctor(string message, ProfileCardStampVisibilitySettingDialog.DecideEventHandler decideEventHandler) { }

	// RVA: 0x1F28560 Offset: 0x1F28661 VA: 0x1F28560 Slot: 18
	public override BasicMenu.Result ACall() { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x277A30 Offset: 0x277B31 VA: 0x277A30
[Serializable]
private sealed class ProfileCardStampVisibilitySettingDialog.<>c // TypeDefIndex: 11643
{
	// Fields
	public static readonly ProfileCardStampVisibilitySettingDialog.<>c <>9; // 0x0
	public static ProfileCardStampVisibilitySettingDialog.DecideEventHandler <>9__1_0; // 0x8
	public static ProfileCardStampVisibilitySettingDialog.DecideEventHandler <>9__1_1; // 0x10

	// Methods

	// RVA: 0x1F28170 Offset: 0x1F28271 VA: 0x1F28170
	private static void .cctor() { }

	// RVA: 0x1F281E0 Offset: 0x1F282E1 VA: 0x1F281E0
	public void .ctor() { }

	// RVA: 0x1F281F0 Offset: 0x1F282F1 VA: 0x1F281F0
	internal void <CreateBind>b__1_0() { }

	// RVA: 0x1F28250 Offset: 0x1F28351 VA: 0x1F28250
	internal void <CreateBind>b__1_1() { }
}

