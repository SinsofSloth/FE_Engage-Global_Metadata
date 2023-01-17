// Namespace: 
public class RewindMenu.ExecuteConfirmDialog.ItemNo : BasicDialogItemNo // TypeDefIndex: 12602
{
	// Methods

	// RVA: 0x21F5380 Offset: 0x21F5481 VA: 0x21F5380
	public void .ctor() { }
}

// Namespace: 
public class RewindMenu.CancelConfirmDialog.ItemYes : BasicDialogItemYes // TypeDefIndex: 12604
{
	// Methods

	// RVA: 0x21F5170 Offset: 0x21F5271 VA: 0x21F5170
	public void .ctor() { }

	// RVA: 0x21F5200 Offset: 0x21F5301 VA: 0x21F5200 Slot: 18
	public override BasicMenu.Result ACall() { }
}

// Namespace: 
public class RewindMenu.CancelConfirmDialog.ItemNo : BasicDialogItemNo // TypeDefIndex: 12606
{
	// Methods

	// RVA: 0x21F50E0 Offset: 0x21F51E1 VA: 0x21F50E0
	public void .ctor() { }
}

// Namespace: 
public class RewindMenu.MenuItem.UnitIconInfo // TypeDefIndex: 12608
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x29B340 Offset: 0x29B441 VA: 0x29B340
	private PersonData <Person>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x29B350 Offset: 0x29B451 VA: 0x29B350
	private JobData <Job>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x29B360 Offset: 0x29B461 VA: 0x29B360
	private bool <IsFemale>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x29B370 Offset: 0x29B471 VA: 0x29B370
	private ItemData.Kinds <ItemKind>k__BackingField; // 0x24
	[CompilerGeneratedAttribute] // RVA: 0x29B380 Offset: 0x29B481 VA: 0x29B380
	private bool <IsEngage>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x29B390 Offset: 0x29B491 VA: 0x29B390
	private GodData <God>k__BackingField; // 0x30

	// Properties
	public PersonData Person { get; set; }
	public JobData Job { get; set; }
	public bool IsFemale { get; set; }
	public ItemData.Kinds ItemKind { get; set; }
	public bool IsEngage { get; set; }
	public GodData God { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2C9B80 Offset: 0x2C9C81 VA: 0x2C9B80
	// RVA: 0x21F55F0 Offset: 0x21F56F1 VA: 0x21F55F0
	public PersonData get_Person() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C9B90 Offset: 0x2C9C91 VA: 0x2C9B90
	// RVA: 0x21F5600 Offset: 0x21F5701 VA: 0x21F5600
	private void set_Person(PersonData value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C9BA0 Offset: 0x2C9CA1 VA: 0x2C9BA0
	// RVA: 0x21F5610 Offset: 0x21F5711 VA: 0x21F5610
	public JobData get_Job() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C9BB0 Offset: 0x2C9CB1 VA: 0x2C9BB0
	// RVA: 0x21F5620 Offset: 0x21F5721 VA: 0x21F5620
	private void set_Job(JobData value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C9BC0 Offset: 0x2C9CC1 VA: 0x2C9BC0
	// RVA: 0x21F5630 Offset: 0x21F5731 VA: 0x21F5630
	public bool get_IsFemale() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C9BD0 Offset: 0x2C9CD1 VA: 0x2C9BD0
	// RVA: 0x21F5640 Offset: 0x21F5741 VA: 0x21F5640
	private void set_IsFemale(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C9BE0 Offset: 0x2C9CE1 VA: 0x2C9BE0
	// RVA: 0x21F5650 Offset: 0x21F5751 VA: 0x21F5650
	public ItemData.Kinds get_ItemKind() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C9BF0 Offset: 0x2C9CF1 VA: 0x2C9BF0
	// RVA: 0x21F5660 Offset: 0x21F5761 VA: 0x21F5660
	private void set_ItemKind(ItemData.Kinds value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C9C00 Offset: 0x2C9D01 VA: 0x2C9C00
	// RVA: 0x21F5670 Offset: 0x21F5771 VA: 0x21F5670
	public bool get_IsEngage() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C9C10 Offset: 0x2C9D11 VA: 0x2C9C10
	// RVA: 0x21F5680 Offset: 0x21F5781 VA: 0x21F5680
	private void set_IsEngage(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C9C20 Offset: 0x2C9D21 VA: 0x2C9C20
	// RVA: 0x21F5690 Offset: 0x21F5791 VA: 0x21F5690
	public GodData get_God() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C9C30 Offset: 0x2C9D31 VA: 0x2C9C30
	// RVA: 0x21F56A0 Offset: 0x21F57A1 VA: 0x21F56A0
	private void set_God(GodData value) { }

	// RVA: 0x21F56B0 Offset: 0x21F57B1 VA: 0x21F56B0
	public void .ctor(MapHistory.RewindLog.UnitIcon rewindLogUnitIcon) { }
}

// Namespace: 
public class RewindMenu.MenuItem : BasicMenuItem // TypeDefIndex: 12610
{
	// Fields
	private int m_LogIndex; // 0x64
	private string m_LogText; // 0x68
	private int m_CursorX; // 0x70
	private int m_CursorZ; // 0x74
	private int m_ActorMapHistoryIndex; // 0x78
	private RewindMenu.MenuItem.UnitIconInfo m_UnitIconInfo; // 0x80
	private RewindMenu.MenuItem.UnitIconInfo m_DieUnitIconInfo; // 0x88
	private Force.Type m_ForceType; // 0x90
	private bool m_IsPlayerPhaseBegin; // 0x94
	private RewindMenu.MenuItem m_prev; // 0x98
	private RewindMenu.MenuItem m_next; // 0xA0

	// Methods

	// RVA: 0x1F47D60 Offset: 0x1F47E61 VA: 0x1F47D60
	public void .ctor(int logIndex, string logText, int cursorX, int cursorZ, int actorMapHistoryIndex, RewindMenu.MenuItem.UnitIconInfo unitIconInfo, RewindMenu.MenuItem.UnitIconInfo dieUnitIconInfo, Force.Type forceType, bool isPlayerPhaseBegin) { }

	// RVA: 0x1F47E70 Offset: 0x1F47F71 VA: 0x1F47E70
	public void SetLink(RewindMenu.MenuItem prev, RewindMenu.MenuItem next) { }

	// RVA: 0x1F47EB0 Offset: 0x1F47FB1 VA: 0x1F47EB0
	public RewindMenu.MenuItem GetPrev() { }

	// RVA: 0x1F47EC0 Offset: 0x1F47FC1 VA: 0x1F47EC0
	public RewindMenu.MenuItem GetNext() { }

	// RVA: 0x1F47ED0 Offset: 0x1F47FD1 VA: 0x1F47ED0 Slot: 4
	public override string GetName() { }

	// RVA: 0x1F47EE0 Offset: 0x1F47FE1 VA: 0x1F47EE0 Slot: 5
	public override float GetWidth() { }

	// RVA: 0x1F47EF0 Offset: 0x1F47FF1 VA: 0x1F47EF0 Slot: 6
	public override float GetHeight() { }

	// RVA: 0x1F47F00 Offset: 0x1F48001 VA: 0x1F47F00 Slot: 8
	public override BasicMenuItem.Attribute BuildAttribute() { }

	// RVA: 0x1F47F10 Offset: 0x1F48011 VA: 0x1F47F10
	public RewindMenu.MenuItem.UnitIconInfo GetUnitIconInfo() { }

	// RVA: 0x1F47F20 Offset: 0x1F48021 VA: 0x1F47F20
	public RewindMenu.MenuItem.UnitIconInfo GetDieUnitIconInfo() { }

	// RVA: 0x1F47F30 Offset: 0x1F48031 VA: 0x1F47F30
	public Force.Type GetForceType() { }

	// RVA: 0x1F47F40 Offset: 0x1F48041 VA: 0x1F47F40
	public bool IsPlayerPhaseBegin() { }

	// RVA: 0x1F47F50 Offset: 0x1F48051 VA: 0x1F47F50 Slot: 12
	public override void OnSelect() { }

	// RVA: 0x1F48220 Offset: 0x1F48321 VA: 0x1F48220 Slot: 13
	public override void OnDeselect() { }

	// RVA: 0x1F48230 Offset: 0x1F48331 VA: 0x1F48230 Slot: 14
	public override void OnCursorMoveEnd() { }

	// RVA: 0x1F48240 Offset: 0x1F48341 VA: 0x1F48240 Slot: 18
	public override BasicMenu.Result ACall() { }
}

