// Namespace: 
public sealed class ArenaBondLevelSelectMenu.DecideEventHandler : MulticastDelegate // TypeDefIndex: 10946
{
	// Methods

	// RVA: 0x1F63DC0 Offset: 0x1F63EC1 VA: 0x1F63DC0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1F62F10 Offset: 0x1F63011 VA: 0x1F62F10 Slot: 13
	public virtual void Invoke(GodUnit god, RingCleaningSequence.GodType type, bool start, int getExp, int useCount) { }

	// RVA: 0x1F63DE0 Offset: 0x1F63EE1 VA: 0x1F63DE0 Slot: 14
	public virtual IAsyncResult BeginInvoke(GodUnit god, RingCleaningSequence.GodType type, bool start, int getExp, int useCount, AsyncCallback callback, object object) { }

	// RVA: 0x1F63EF0 Offset: 0x1F63FF1 VA: 0x1F63EF0 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
public sealed class ArenaBondLevelSelectMenu.SelectEventHandler : MulticastDelegate // TypeDefIndex: 10947
{
	// Methods

	// RVA: 0x1F63F00 Offset: 0x1F64001 VA: 0x1F63F00
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1F63320 Offset: 0x1F63421 VA: 0x1F63320 Slot: 13
	public virtual void Invoke(GodUnit god, int fromLv, int toLv) { }

	// RVA: 0x1F63F20 Offset: 0x1F64021 VA: 0x1F63F20 Slot: 14
	public virtual IAsyncResult BeginInvoke(GodUnit god, int fromLv, int toLv, AsyncCallback callback, object object) { }

	// RVA: 0x1F63FD0 Offset: 0x1F640D1 VA: 0x1F63FD0 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
public sealed class ArenaBondLevelSelectMenu.ChangeGodEventHandle : MulticastDelegate // TypeDefIndex: 10948
{
	// Methods

	// RVA: 0x1F63CC0 Offset: 0x1F63DC1 VA: 0x1F63CC0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1F63A90 Offset: 0x1F63B91 VA: 0x1F63A90 Slot: 13
	public virtual void Invoke() { }

	// RVA: 0x1F63CE0 Offset: 0x1F63DE1 VA: 0x1F63CE0 Slot: 14
	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

	// RVA: 0x1F63D10 Offset: 0x1F63E11 VA: 0x1F63D10 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
public class ArenaBondLevelSelectMenu.ArenaBondLevelSelectMenuItem : BasicMenuItem // TypeDefIndex: 10949
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x295FE0 Offset: 0x2960E1 VA: 0x295FE0
	private Unit <Unit>k__BackingField; // 0x68
	[CompilerGeneratedAttribute] // RVA: 0x295FF0 Offset: 0x2960F1 VA: 0x295FF0
	private GodUnit <God>k__BackingField; // 0x70
	[CompilerGeneratedAttribute] // RVA: 0x296000 Offset: 0x296101 VA: 0x296000
	private RingCleaningSequence.GodType <GodType>k__BackingField; // 0x78
	[CompilerGeneratedAttribute] // RVA: 0x296010 Offset: 0x296111 VA: 0x296010
	private int <LvBefore>k__BackingField; // 0x7C
	[CompilerGeneratedAttribute] // RVA: 0x296020 Offset: 0x296121 VA: 0x296020
	private int <LvAfter>k__BackingField; // 0x80
	[CompilerGeneratedAttribute] // RVA: 0x296030 Offset: 0x296131 VA: 0x296030
	private int <GetExp>k__BackingField; // 0x84
	[CompilerGeneratedAttribute] // RVA: 0x296040 Offset: 0x296141 VA: 0x296040
	private int <UseCount>k__BackingField; // 0x88
	[CompilerGeneratedAttribute] // RVA: 0x296050 Offset: 0x296151 VA: 0x296050
	private bool <IsTalkCap>k__BackingField; // 0x8C
	[CompilerGeneratedAttribute] // RVA: 0x296060 Offset: 0x296161 VA: 0x296060
	private bool <IsNoBond>k__BackingField; // 0x8D
	private ArenaBondLevelSelectMenu.DecideEventHandler m_DecideEventHandler; // 0x90
	private ArenaBondLevelSelectMenu.SelectEventHandler m_SelectEventHandler; // 0x98
	private ArenaBondLevelSelectMenu.ChangeGodEventHandle m_ChangeUnitToPrevEventHandler; // 0xA0
	private ArenaBondLevelSelectMenu.ChangeGodEventHandle m_ChangeUnitToNextEventHandler; // 0xA8

	// Properties
	public Unit Unit { get; set; }
	public GodUnit God { get; set; }
	public RingCleaningSequence.GodType GodType { get; set; }
	public int LvBefore { get; set; }
	public int LvAfter { get; set; }
	public int GetExp { get; set; }
	public int UseCount { get; set; }
	public bool IsTalkCap { get; set; }
	public bool IsNoBond { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2C29F0 Offset: 0x2C2AF1 VA: 0x2C29F0
	// RVA: 0x1F62690 Offset: 0x1F62791 VA: 0x1F62690
	public Unit get_Unit() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C2A00 Offset: 0x2C2B01 VA: 0x2C2A00
	// RVA: 0x1F626A0 Offset: 0x1F627A1 VA: 0x1F626A0
	private void set_Unit(Unit value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C2A10 Offset: 0x2C2B11 VA: 0x2C2A10
	// RVA: 0x1F626B0 Offset: 0x1F627B1 VA: 0x1F626B0
	public GodUnit get_God() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C2A20 Offset: 0x2C2B21 VA: 0x2C2A20
	// RVA: 0x1F626C0 Offset: 0x1F627C1 VA: 0x1F626C0
	private void set_God(GodUnit value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C2A30 Offset: 0x2C2B31 VA: 0x2C2A30
	// RVA: 0x1F626D0 Offset: 0x1F627D1 VA: 0x1F626D0
	public RingCleaningSequence.GodType get_GodType() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C2A40 Offset: 0x2C2B41 VA: 0x2C2A40
	// RVA: 0x1F626E0 Offset: 0x1F627E1 VA: 0x1F626E0
	private void set_GodType(RingCleaningSequence.GodType value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C2A50 Offset: 0x2C2B51 VA: 0x2C2A50
	// RVA: 0x1F626F0 Offset: 0x1F627F1 VA: 0x1F626F0
	public int get_LvBefore() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C2A60 Offset: 0x2C2B61 VA: 0x2C2A60
	// RVA: 0x1F62700 Offset: 0x1F62801 VA: 0x1F62700
	public void set_LvBefore(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C2A70 Offset: 0x2C2B71 VA: 0x2C2A70
	// RVA: 0x1F62710 Offset: 0x1F62811 VA: 0x1F62710
	public int get_LvAfter() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C2A80 Offset: 0x2C2B81 VA: 0x2C2A80
	// RVA: 0x1F62720 Offset: 0x1F62821 VA: 0x1F62720
	public void set_LvAfter(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C2A90 Offset: 0x2C2B91 VA: 0x2C2A90
	// RVA: 0x1F62730 Offset: 0x1F62831 VA: 0x1F62730
	public int get_GetExp() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C2AA0 Offset: 0x2C2BA1 VA: 0x2C2AA0
	// RVA: 0x1F62740 Offset: 0x1F62841 VA: 0x1F62740
	public void set_GetExp(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C2AB0 Offset: 0x2C2BB1 VA: 0x2C2AB0
	// RVA: 0x1F62750 Offset: 0x1F62851 VA: 0x1F62750
	public int get_UseCount() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C2AC0 Offset: 0x2C2BC1 VA: 0x2C2AC0
	// RVA: 0x1F62760 Offset: 0x1F62861 VA: 0x1F62760
	public void set_UseCount(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C2AD0 Offset: 0x2C2BD1 VA: 0x2C2AD0
	// RVA: 0x1F62770 Offset: 0x1F62871 VA: 0x1F62770
	public bool get_IsTalkCap() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C2AE0 Offset: 0x2C2BE1 VA: 0x2C2AE0
	// RVA: 0x1F62780 Offset: 0x1F62881 VA: 0x1F62780
	private void set_IsTalkCap(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C2AF0 Offset: 0x2C2BF1 VA: 0x2C2AF0
	// RVA: 0x1F62790 Offset: 0x1F62891 VA: 0x1F62790
	public bool get_IsNoBond() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C2B00 Offset: 0x2C2C01 VA: 0x2C2B00
	// RVA: 0x1F627A0 Offset: 0x1F628A1 VA: 0x1F627A0
	private void set_IsNoBond(bool value) { }

	// RVA: 0x1F627B0 Offset: 0x1F628B1 VA: 0x1F627B0
	public void .ctor(int fromLevel, int toLevel, int getExp, int useCount, Unit trainUnit, GodUnit trainGod, RingCleaningSequence.GodType trainType, ArenaBondLevelSelectMenu.DecideEventHandler decideEventHandler, ArenaBondLevelSelectMenu.SelectEventHandler selectEventHandler, ArenaBondLevelSelectMenu.ChangeGodEventHandle changeUnitToPrevEventHandler, ArenaBondLevelSelectMenu.ChangeGodEventHandle changeUnitToNextEventHandler) { }

	// RVA: 0x1F62990 Offset: 0x1F62A91 VA: 0x1F62990 Slot: 8
	public override BasicMenuItem.Attribute BuildAttribute() { }

	// RVA: 0x1F629B0 Offset: 0x1F62AB1 VA: 0x1F629B0 Slot: 18
	public override BasicMenu.Result ACall() { }

	// RVA: 0x1F62ED0 Offset: 0x1F62FD1 VA: 0x1F62ED0 Slot: 19
	public override BasicMenu.Result BCall() { }

	// RVA: 0x1F632F0 Offset: 0x1F633F1 VA: 0x1F632F0 Slot: 12
	public override void OnSelect() { }

	// RVA: 0x1F636C0 Offset: 0x1F637C1 VA: 0x1F636C0 Slot: 26
	public override BasicMenu.Result CustomCall() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C2B10 Offset: 0x2C2C11 VA: 0x2C2B10
	// RVA: 0x1F63CA0 Offset: 0x1F63DA1 VA: 0x1F63CA0
	private void <ACall>b__42_0() { }
}

// Namespace: 
private class ArenaBondLevelSelectMenu.ConfirmDialog.ConfirmDialogItemYes : BasicDialogItemYes // TypeDefIndex: 10950
{
	// Fields
	public Action m_DecideAction; // 0x70

	// Methods

	// RVA: 0x1DC0C30 Offset: 0x1DC0D31 VA: 0x1DC0C30
	public void .ctor(Action decideAction) { }

	// RVA: 0x1DC0CE0 Offset: 0x1DC0DE1 VA: 0x1DC0CE0 Slot: 18
	public override BasicMenu.Result ACall() { }
}

// Namespace: 
private class ArenaBondLevelSelectMenu.ConfirmDialog.ConfirmDialogItemNo : BasicDialogItemNo // TypeDefIndex: 10951
{
	// Methods

	// RVA: 0x1DC0BA0 Offset: 0x1DC0CA1 VA: 0x1DC0BA0
	public void .ctor() { }
}

// Namespace: 
private class ArenaBondLevelSelectMenu.ConfirmDialog : YesNoDialog // TypeDefIndex: 10952
{
	// Fields
	public Action m_DecideAction; // 0xD8

	// Methods

	// RVA: 0x1F63D20 Offset: 0x1F63E21 VA: 0x1F63D20
	private void .ctor(List<BasicMenuItem> menuItemList, Action decideAction) { }

	// RVA: 0x1F62AE0 Offset: 0x1F62BE1 VA: 0x1F62AE0
	public static void CreateBind(ProcInst super, Unit unit, GodUnit god, RingCleaningSequence.GodType godType, int fromLv, int toLv, int useCount, Action decideAction) { }
}

