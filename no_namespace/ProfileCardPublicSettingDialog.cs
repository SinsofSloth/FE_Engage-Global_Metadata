// Namespace: 
public sealed class ProfileCardPublicSettingDialog.DecideEventHandler : MulticastDelegate // TypeDefIndex: 11601
{
	// Methods

	// RVA: 0x1F25540 Offset: 0x1F25641 VA: 0x1F25540
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1F25560 Offset: 0x1F25661 VA: 0x1F25560 Slot: 13
	public virtual void Invoke() { }

	// RVA: 0x1F25770 Offset: 0x1F25871 VA: 0x1F25770 Slot: 14
	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

	// RVA: 0x1F257A0 Offset: 0x1F258A1 VA: 0x1F257A0 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
private class ProfileCardPublicSettingDialog.DialogMenuItem : BasicDialogItem // TypeDefIndex: 11602
{
	// Fields
	private ProfileCardPublicSettingDialog.DecideEventHandler m_DecideEventHandler; // 0x70

	// Methods

	// RVA: 0x1F257B0 Offset: 0x1F258B1 VA: 0x1F257B0
	public void .ctor(string message, ProfileCardPublicSettingDialog.DecideEventHandler decideEventHandler) { }

	// RVA: 0x1F257F0 Offset: 0x1F258F1 VA: 0x1F257F0 Slot: 18
	public override BasicMenu.Result ACall() { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x2779D0 Offset: 0x277AD1 VA: 0x2779D0
[Serializable]
private sealed class ProfileCardPublicSettingDialog.<>c // TypeDefIndex: 11603
{
	// Fields
	public static readonly ProfileCardPublicSettingDialog.<>c <>9; // 0x0
	public static ProfileCardPublicSettingDialog.DecideEventHandler <>9__1_0; // 0x8
	public static ProfileCardPublicSettingDialog.DecideEventHandler <>9__1_1; // 0x10

	// Methods

	// RVA: 0x1F253C0 Offset: 0x1F254C1 VA: 0x1F253C0
	private static void .cctor() { }

	// RVA: 0x1F25430 Offset: 0x1F25531 VA: 0x1F25430
	public void .ctor() { }

	// RVA: 0x1F25440 Offset: 0x1F25541 VA: 0x1F25440
	internal void <CreateBind>b__1_0() { }

	// RVA: 0x1F254C0 Offset: 0x1F255C1 VA: 0x1F254C0
	internal void <CreateBind>b__1_1() { }
}

