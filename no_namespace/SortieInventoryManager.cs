// Namespace: 
public enum SortieInventoryManager.Modes // TypeDefIndex: 13170
{
	// Fields
	public int value__; // 0x0
	public const SortieInventoryManager.Modes Sortie = 0;
	public const SortieInventoryManager.Modes Transporter = 1;
}

// Namespace: 
public enum SortieInventoryManager.ActiveWindow // TypeDefIndex: 13171
{
	// Fields
	public int value__; // 0x0
	public const SortieInventoryManager.ActiveWindow None = 0;
	public const SortieInventoryManager.ActiveWindow UnitItem = 1;
	public const SortieInventoryManager.ActiveWindow PoolItem = 2;
}

// Namespace: 
public enum SortieInventoryManager.SelectionInfo.Modes // TypeDefIndex: 13172
{
	// Fields
	public int value__; // 0x0
	public const SortieInventoryManager.SelectionInfo.Modes None = 0;
	public const SortieInventoryManager.SelectionInfo.Modes Trade = 1;
}

// Namespace: 
public class SortieInventoryManager.SelectionInfo // TypeDefIndex: 13173
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x29BAF0 Offset: 0x29BBF1 VA: 0x29BAF0
	private SortieInventoryManager.SelectionInfo.Modes <Mode>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x29BB00 Offset: 0x29BC01 VA: 0x29BB00
	private bool <IsUnit>k__BackingField; // 0x14
	[CompilerGeneratedAttribute] // RVA: 0x29BB10 Offset: 0x29BC11 VA: 0x29BB10
	private Unit <Unit>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x29BB20 Offset: 0x29BC21 VA: 0x29BB20
	private int <OwnerItemIndex>k__BackingField; // 0x20

	// Properties
	public SortieInventoryManager.SelectionInfo.Modes Mode { get; set; }
	public bool IsUnit { get; set; }
	public Unit Unit { get; set; }
	public int OwnerItemIndex { get; set; }

	// Methods

	// RVA: 0x20428C0 Offset: 0x20429C1 VA: 0x20428C0
	public void Reset() { }

	// RVA: 0x2042910 Offset: 0x2042A11 VA: 0x2042910
	public bool IsModeNone() { }

	// RVA: 0x2042920 Offset: 0x2042A21 VA: 0x2042920
	public bool IsModeTrade() { }

	// RVA: 0x2042900 Offset: 0x2042A01 VA: 0x2042900
	public void ResetMode() { }

	// RVA: 0x2042930 Offset: 0x2042A31 VA: 0x2042930
	public UnitItem GetUnitItem() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CB520 Offset: 0x2CB621 VA: 0x2CB520
	// RVA: 0x2042950 Offset: 0x2042A51 VA: 0x2042950
	public SortieInventoryManager.SelectionInfo.Modes get_Mode() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CB530 Offset: 0x2CB631 VA: 0x2CB530
	// RVA: 0x2042960 Offset: 0x2042A61 VA: 0x2042960
	public void set_Mode(SortieInventoryManager.SelectionInfo.Modes value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2CB540 Offset: 0x2CB641 VA: 0x2CB540
	// RVA: 0x2042970 Offset: 0x2042A71 VA: 0x2042970
	public bool get_IsUnit() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CB550 Offset: 0x2CB651 VA: 0x2CB550
	// RVA: 0x2042980 Offset: 0x2042A81 VA: 0x2042980
	public void set_IsUnit(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2CB560 Offset: 0x2CB661 VA: 0x2CB560
	// RVA: 0x2042990 Offset: 0x2042A91 VA: 0x2042990
	public Unit get_Unit() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CB570 Offset: 0x2CB671 VA: 0x2CB570
	// RVA: 0x20429A0 Offset: 0x2042AA1 VA: 0x20429A0
	public void set_Unit(Unit value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2CB580 Offset: 0x2CB681 VA: 0x2CB580
	// RVA: 0x20429B0 Offset: 0x2042AB1 VA: 0x20429B0
	public int get_OwnerItemIndex() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CB590 Offset: 0x2CB691 VA: 0x2CB590
	// RVA: 0x20429C0 Offset: 0x2042AC1 VA: 0x20429C0
	public void set_OwnerItemIndex(int value) { }

	// RVA: 0x20429D0 Offset: 0x2042AD1 VA: 0x20429D0
	public void .ctor() { }
}

