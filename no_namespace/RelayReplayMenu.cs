// Namespace: 
public sealed class RelayReplayMenu.SelectEventHandler : MulticastDelegate // TypeDefIndex: 12893
{
	// Methods

	// RVA: 0x1F41E30 Offset: 0x1F41F31 VA: 0x1F41E30
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1F41830 Offset: 0x1F41931 VA: 0x1F41830 Slot: 13
	public virtual void Invoke(RelayServerMetaData metaData) { }

	// RVA: 0x1F41E50 Offset: 0x1F41F51 VA: 0x1F41E50 Slot: 14
	public virtual IAsyncResult BeginInvoke(RelayServerMetaData metaData, AsyncCallback callback, object object) { }

	// RVA: 0x1F41E80 Offset: 0x1F41F81 VA: 0x1F41E80 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
public sealed class RelayReplayMenu.DecideEventHandler : MulticastDelegate // TypeDefIndex: 12894
{
	// Methods

	// RVA: 0x1F40C70 Offset: 0x1F40D71 VA: 0x1F40C70
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1F40C90 Offset: 0x1F40D91 VA: 0x1F40C90 Slot: 13
	public virtual void Invoke() { }

	// RVA: 0x1F40EA0 Offset: 0x1F40FA1 VA: 0x1F40EA0 Slot: 14
	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

	// RVA: 0x1F40ED0 Offset: 0x1F40FD1 VA: 0x1F40ED0 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
public sealed class RelayReplayMenu.RequestCloseEventHandler : MulticastDelegate // TypeDefIndex: 12895
{
	// Methods

	// RVA: 0x1F41BC0 Offset: 0x1F41CC1 VA: 0x1F41BC0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1F41BE0 Offset: 0x1F41CE1 VA: 0x1F41BE0 Slot: 13
	public virtual void Invoke() { }

	// RVA: 0x1F41DF0 Offset: 0x1F41EF1 VA: 0x1F41DF0 Slot: 14
	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

	// RVA: 0x1F41E20 Offset: 0x1F41F21 VA: 0x1F41E20 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
public class RelayReplayMenu.ReplayMenuItem : BasicMenuItem // TypeDefIndex: 12896
{
	// Fields
	private RelayServerMetaData m_MetaData; // 0x68
	private RelayReplayMenu.SelectEventHandler m_SelectEventHandler; // 0x70
	private RelayReplayMenu.DecideEventHandler m_DecideEventHandler; // 0x78
	private bool m_IsAwarded; // 0x80

	// Methods

	// RVA: 0x1F41400 Offset: 0x1F41501 VA: 0x1F41400
	public void .ctor(RelayServerMetaData metaData, RelayReplayMenu.SelectEventHandler selectEventHandler, RelayReplayMenu.DecideEventHandler decideEventHandler) { }

	// RVA: 0x1F41560 Offset: 0x1F41661 VA: 0x1F41560
	public bool IsEnd() { }

	// RVA: 0x1F41580 Offset: 0x1F41681 VA: 0x1F41580
	public bool IsAwarded() { }

	// RVA: 0x1F41590 Offset: 0x1F41691 VA: 0x1F41590
	public string GetUserName() { }

	// RVA: 0x1F417C0 Offset: 0x1F418C1 VA: 0x1F417C0 Slot: 11
	public override void OnBuildMenuItemContent() { }

	// RVA: 0x1F417D0 Offset: 0x1F418D1 VA: 0x1F417D0 Slot: 8
	public override BasicMenuItem.Attribute BuildAttribute() { }

	// RVA: 0x1F417F0 Offset: 0x1F418F1 VA: 0x1F417F0 Slot: 12
	public override void OnSelect() { }

	// RVA: 0x1F41B90 Offset: 0x1F41C91 VA: 0x1F41B90 Slot: 18
	public override BasicMenu.Result ACall() { }
}

// Namespace: 
public sealed class RelayReplayMenu.RelayConfirmReplayDialog.DialogItem.DialogDecideEventHandler : MulticastDelegate // TypeDefIndex: 12897
{
	// Methods

	// RVA: 0x2D7DBD0 Offset: 0x2D7DCD1 VA: 0x2D7DBD0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x2D7DBF0 Offset: 0x2D7DCF1 VA: 0x2D7DBF0 Slot: 13
	public virtual BasicMenu.Result Invoke() { }

	// RVA: 0x2D7DE00 Offset: 0x2D7DF01 VA: 0x2D7DE00 Slot: 14
	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

	// RVA: 0x2D7DE30 Offset: 0x2D7DF31 VA: 0x2D7DE30 Slot: 15
	public virtual BasicMenu.Result EndInvoke(IAsyncResult result) { }
}

// Namespace: 
private class RelayReplayMenu.RelayConfirmReplayDialog.DialogItem : BasicDialogItem // TypeDefIndex: 12898
{
	// Fields
	private RelayReplayMenu.RelayConfirmReplayDialog.DialogItem.DialogDecideEventHandler m_DecideEventHandler; // 0x70

	// Methods

	// RVA: 0x21F4F30 Offset: 0x21F5031 VA: 0x21F4F30
	public void .ctor(string text, RelayReplayMenu.RelayConfirmReplayDialog.DialogItem.DialogDecideEventHandler decide) { }

	// RVA: 0x21F4F70 Offset: 0x21F5071 VA: 0x21F4F70 Slot: 18
	public override BasicMenu.Result ACall() { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x2787F0 Offset: 0x2788F1 VA: 0x2787F0
private sealed class RelayReplayMenu.RelayConfirmReplayDialog.<>c__DisplayClass1_0 // TypeDefIndex: 12899
{
	// Fields
	public RelayServerMetaData metaData; // 0x10
	public RelayReplayMenu.DecideEventHandler decide; // 0x18

	// Methods

	// RVA: 0x21F4D10 Offset: 0x21F4E11 VA: 0x21F4D10
	public void .ctor() { }

	// RVA: 0x21F4D20 Offset: 0x21F4E21 VA: 0x21F4D20
	internal BasicMenu.Result <CreateBind>b__0() { }

	// RVA: 0x21F4DD0 Offset: 0x21F4ED1 VA: 0x21F4DD0
	internal BasicMenu.Result <CreateBind>b__1() { }

	// RVA: 0x21F4E80 Offset: 0x21F4F81 VA: 0x21F4E80
	internal BasicMenu.Result <CreateBind>b__2() { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x278800 Offset: 0x278901 VA: 0x278800
[Serializable]
private sealed class RelayReplayMenu.RelayConfirmReplayDialog.<>c // TypeDefIndex: 12900
{
	// Fields
	public static readonly RelayReplayMenu.RelayConfirmReplayDialog.<>c <>9; // 0x0
	public static RelayReplayMenu.RelayConfirmReplayDialog.DialogItem.DialogDecideEventHandler <>9__1_3; // 0x8

	// Methods

	// RVA: 0x21F4C80 Offset: 0x21F4D81 VA: 0x21F4C80
	private static void .cctor() { }

	// RVA: 0x21F4CF0 Offset: 0x21F4DF1 VA: 0x21F4CF0
	public void .ctor() { }

	// RVA: 0x21F4D00 Offset: 0x21F4E01 VA: 0x21F4D00
	internal BasicMenu.Result <CreateBind>b__1_3() { }
}

// Namespace: 
private class RelayReplayMenu.RelayConfirmReplayDialog : BasicDialog // TypeDefIndex: 12901
{
	// Methods

	// RVA: 0x1F40EE0 Offset: 0x1F40FE1 VA: 0x1F40EE0
	public void .ctor(List<BasicMenuItem> menuItemList, BasicDialogContent menuContent) { }

	// RVA: 0x1F40EF0 Offset: 0x1F40FF1 VA: 0x1F40EF0
	public static void CreateBind(ProcInst super, RelayServerMetaData metaData, RelayReplayMenu.DecideEventHandler decide) { }
}

