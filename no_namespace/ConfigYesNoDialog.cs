// Namespace: 
public sealed class ConfigYesNoDialog.YesEventHandler : MulticastDelegate // TypeDefIndex: 7694
{
	// Methods

	// RVA: 0x1E0AA80 Offset: 0x1E0AB81 VA: 0x1E0AA80
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1E0AAA0 Offset: 0x1E0ABA1 VA: 0x1E0AAA0 Slot: 13
	public virtual void Invoke() { }

	// RVA: 0x1E0ACB0 Offset: 0x1E0ADB1 VA: 0x1E0ACB0 Slot: 14
	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

	// RVA: 0x1E0ACE0 Offset: 0x1E0ADE1 VA: 0x1E0ACE0 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
public class ConfigYesNoDialog : YesNoDialog // TypeDefIndex: 7695
{
	// Methods

	// RVA: 0x23B6900 Offset: 0x23B6A01 VA: 0x23B6900
	public void .ctor(List<BasicMenuItem> menuItemList, BasicDialogContent menuContent) { }

	// RVA: 0x23B4070 Offset: 0x23B4171 VA: 0x23B4070
	public static YesNoDialog CreateBind(ProcInst super, ConfigYesNoDialog.YesEventHandler yesEventHandler) { }
}

