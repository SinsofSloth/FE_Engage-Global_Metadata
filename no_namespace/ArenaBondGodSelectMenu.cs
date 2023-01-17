// Namespace: 
public sealed class ArenaBondGodSelectMenu.DecideEventHandler : MulticastDelegate // TypeDefIndex: 10930
{
	// Methods

	// RVA: 0x1F61C00 Offset: 0x1F61D01 VA: 0x1F61C00
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1F604C0 Offset: 0x1F605C1 VA: 0x1F604C0 Slot: 13
	public virtual void Invoke(GodUnit god, RingCleaningSequence.GodType type) { }

	// RVA: 0x1F61C20 Offset: 0x1F61D21 VA: 0x1F61C20 Slot: 14
	public virtual IAsyncResult BeginInvoke(GodUnit god, RingCleaningSequence.GodType type, AsyncCallback callback, object object) { }

	// RVA: 0x1F61CC0 Offset: 0x1F61DC1 VA: 0x1F61CC0 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
public sealed class ArenaBondGodSelectMenu.SelectEventHandler : MulticastDelegate // TypeDefIndex: 10931
{
	// Methods

	// RVA: 0x1F61CD0 Offset: 0x1F61DD1 VA: 0x1F61CD0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1F61360 Offset: 0x1F61461 VA: 0x1F61360 Slot: 13
	public virtual void Invoke(GodUnit god, RingCleaningSequence.GodType type) { }

	// RVA: 0x1F61CF0 Offset: 0x1F61DF1 VA: 0x1F61CF0 Slot: 14
	public virtual IAsyncResult BeginInvoke(GodUnit god, RingCleaningSequence.GodType type, AsyncCallback callback, object object) { }

	// RVA: 0x1F61D90 Offset: 0x1F61E91 VA: 0x1F61D90 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
public sealed class ArenaBondGodSelectMenu.ChangeUnitEventHandle : MulticastDelegate // TypeDefIndex: 10932
{
	// Methods

	// RVA: 0x1F61B20 Offset: 0x1F61C21 VA: 0x1F61B20
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1F61120 Offset: 0x1F61221 VA: 0x1F61120 Slot: 13
	public virtual void Invoke() { }

	// RVA: 0x1F61B40 Offset: 0x1F61C41 VA: 0x1F61B40 Slot: 14
	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

	// RVA: 0x1F61B70 Offset: 0x1F61C71 VA: 0x1F61B70 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
public sealed class ArenaBondGodSelectMenu.StartHelpEventHandler : MulticastDelegate // TypeDefIndex: 10933
{
	// Methods

	// RVA: 0x1F61DA0 Offset: 0x1F61EA1 VA: 0x1F61DA0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1F60D80 Offset: 0x1F60E81 VA: 0x1F60D80 Slot: 13
	public virtual void Invoke(ProcInst super, GodData god, int bondLv) { }

	// RVA: 0x1F61DC0 Offset: 0x1F61EC1 VA: 0x1F61DC0 Slot: 14
	public virtual IAsyncResult BeginInvoke(ProcInst super, GodData god, int bondLv, AsyncCallback callback, object object) { }

	// RVA: 0x1F61E70 Offset: 0x1F61F71 VA: 0x1F61E70 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
public class ArenaBondGodSelectMenu.ArenaBondEmblemSelectMenuItem : BasicMenuItem // TypeDefIndex: 10934
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x295F00 Offset: 0x296001 VA: 0x295F00
	private GodUnit <God>k__BackingField; // 0x68
	[CompilerGeneratedAttribute] // RVA: 0x295F10 Offset: 0x296011 VA: 0x295F10
	private RingCleaningSequence.GodType <ChangeType>k__BackingField; // 0x70
	[CompilerGeneratedAttribute] // RVA: 0x295F20 Offset: 0x296021 VA: 0x295F20
	private bool <IsSelectable>k__BackingField; // 0x74
	[CompilerGeneratedAttribute] // RVA: 0x295F30 Offset: 0x296031 VA: 0x295F30
	private bool <IsTalkable>k__BackingField; // 0x75
	private Unit Unit; // 0x78
	private int BondLv; // 0x80
	private int MaxBondLv; // 0x84
	private ArenaBondGodSelectMenu.DecideEventHandler m_DecideEventHandler; // 0x88
	private ArenaBondGodSelectMenu.SelectEventHandler m_SelectEventHandler; // 0x90
	private ArenaBondGodSelectMenu.ChangeUnitEventHandle m_ChangeUnitToPrevEventHandler; // 0x98
	private ArenaBondGodSelectMenu.ChangeUnitEventHandle m_ChangeUnitToNextEventHandler; // 0xA0
	private ArenaBondGodSelectMenu.StartHelpEventHandler m_StartHelpEventHandler; // 0xA8

	// Properties
	public GodUnit God { get; set; }
	public RingCleaningSequence.GodType ChangeType { get; set; }
	public bool IsSelectable { get; set; }
	public bool IsTalkable { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2C2940 Offset: 0x2C2A41 VA: 0x2C2940
	// RVA: 0x1F5FF40 Offset: 0x1F60041 VA: 0x1F5FF40
	public GodUnit get_God() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C2950 Offset: 0x2C2A51 VA: 0x2C2950
	// RVA: 0x1F5FF50 Offset: 0x1F60051 VA: 0x1F5FF50
	private void set_God(GodUnit value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C2960 Offset: 0x2C2A61 VA: 0x2C2960
	// RVA: 0x1F5FF60 Offset: 0x1F60061 VA: 0x1F5FF60
	public RingCleaningSequence.GodType get_ChangeType() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C2970 Offset: 0x2C2A71 VA: 0x2C2970
	// RVA: 0x1F5FF70 Offset: 0x1F60071 VA: 0x1F5FF70
	private void set_ChangeType(RingCleaningSequence.GodType value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C2980 Offset: 0x2C2A81 VA: 0x2C2980
	// RVA: 0x1F5FF80 Offset: 0x1F60081 VA: 0x1F5FF80
	public bool get_IsSelectable() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C2990 Offset: 0x2C2A91 VA: 0x2C2990
	// RVA: 0x1F5FF90 Offset: 0x1F60091 VA: 0x1F5FF90
	private void set_IsSelectable(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C29A0 Offset: 0x2C2AA1 VA: 0x2C29A0
	// RVA: 0x1F5FFA0 Offset: 0x1F600A1 VA: 0x1F5FFA0
	public bool get_IsTalkable() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C29B0 Offset: 0x2C2AB1 VA: 0x2C29B0
	// RVA: 0x1F5FFB0 Offset: 0x1F600B1 VA: 0x1F5FFB0
	private void set_IsTalkable(bool value) { }

	// RVA: 0x1F5FFC0 Offset: 0x1F600C1 VA: 0x1F5FFC0
	public void .ctor(Unit unit, GodUnit god, RingCleaningSequence.GodType type, ArenaBondGodSelectMenu.DecideEventHandler decideEventHandler, ArenaBondGodSelectMenu.SelectEventHandler selectEventHandler, ArenaBondGodSelectMenu.ChangeUnitEventHandle changeUnitToPrevEventHandler, ArenaBondGodSelectMenu.ChangeUnitEventHandle changeUnitToNextEventHandler, ArenaBondGodSelectMenu.StartHelpEventHandler startHelpEventHandler) { }

	// RVA: 0x1F60190 Offset: 0x1F60291 VA: 0x1F60190 Slot: 8
	public override BasicMenuItem.Attribute BuildAttribute() { }

	// RVA: 0x1F601B0 Offset: 0x1F602B1 VA: 0x1F601B0 Slot: 18
	public override BasicMenu.Result ACall() { }

	// RVA: 0x1F60830 Offset: 0x1F60931 VA: 0x1F60830 Slot: 19
	public override BasicMenu.Result BCall() { }

	// RVA: 0x1F60860 Offset: 0x1F60961 VA: 0x1F60860 Slot: 26
	public override BasicMenu.Result CustomCall() { }

	// RVA: 0x1F61330 Offset: 0x1F61431 VA: 0x1F61330 Slot: 12
	public override void OnSelect() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C29C0 Offset: 0x2C2AC1 VA: 0x2C29C0
	// RVA: 0x1F616D0 Offset: 0x1F617D1 VA: 0x1F616D0
	private void <ACall>b__26_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C29D0 Offset: 0x2C2AD1 VA: 0x2C29D0
	// RVA: 0x1F619E0 Offset: 0x1F61AE1 VA: 0x1F619E0
	private void <ACall>b__26_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C29E0 Offset: 0x2C2AE1 VA: 0x2C29E0
	// RVA: 0x1F61A80 Offset: 0x1F61B81 VA: 0x1F61A80
	private void <ACall>b__26_2() { }
}

// Namespace: 
private class ArenaBondGodSelectMenu.ConfirmDialog.ConfirmDialogItemYes : BasicDialogItemYes // TypeDefIndex: 10935
{
	// Fields
	public Action m_DecideAction; // 0x70

	// Methods

	// RVA: 0x1DC0AC0 Offset: 0x1DC0BC1 VA: 0x1DC0AC0
	public void .ctor(Action decideAction) { }

	// RVA: 0x1DC0B70 Offset: 0x1DC0C71 VA: 0x1DC0B70 Slot: 18
	public override BasicMenu.Result ACall() { }
}

// Namespace: 
private class ArenaBondGodSelectMenu.ConfirmDialog.ConfirmDialogItemNo : BasicDialogItemNo // TypeDefIndex: 10936
{
	// Methods

	// RVA: 0x1DC0A30 Offset: 0x1DC0B31 VA: 0x1DC0A30
	public void .ctor() { }
}

// Namespace: 
private class ArenaBondGodSelectMenu.ConfirmDialog : YesNoDialog // TypeDefIndex: 10937
{
	// Methods

	// RVA: 0x1F60290 Offset: 0x1F60391 VA: 0x1F60290
	public static void CreateBind(ProcInst super, Action decideAction) { }

	// RVA: 0x1F61B80 Offset: 0x1F61C81 VA: 0x1F61B80
	private void .ctor(List<BasicMenuItem> menuItemList) { }
}

