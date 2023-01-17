// Namespace: 
public enum SortieTradeManager.SideId // TypeDefIndex: 13183
{
	// Fields
	public int value__; // 0x0
	public const SortieTradeManager.SideId None = 0;
	public const SortieTradeManager.SideId From = 1;
	public const SortieTradeManager.SideId To = 2;
}

// Namespace: 
public class SortieTradeManager.Side // TypeDefIndex: 13184
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x29BB40 Offset: 0x29BC41 VA: 0x29BB40
	private Unit <Unit>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x29BB50 Offset: 0x29BC51 VA: 0x29BB50
	private int <OwnerItemIndex>k__BackingField; // 0x18

	// Properties
	public Unit Unit { get; set; }
	public int OwnerItemIndex { get; set; }

	// Methods

	// RVA: 0x2047C20 Offset: 0x2047D21 VA: 0x2047C20
	public void Reset() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CB5C0 Offset: 0x2CB6C1 VA: 0x2CB5C0
	// RVA: 0x2047C60 Offset: 0x2047D61 VA: 0x2047C60
	public Unit get_Unit() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CB5D0 Offset: 0x2CB6D1 VA: 0x2CB5D0
	// RVA: 0x2047C70 Offset: 0x2047D71 VA: 0x2047C70
	public void set_Unit(Unit value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2CB5E0 Offset: 0x2CB6E1 VA: 0x2CB5E0
	// RVA: 0x2047C80 Offset: 0x2047D81 VA: 0x2047C80
	public int get_OwnerItemIndex() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CB5F0 Offset: 0x2CB6F1 VA: 0x2CB5F0
	// RVA: 0x2047C90 Offset: 0x2047D91 VA: 0x2047C90
	public void set_OwnerItemIndex(int value) { }

	// RVA: 0x2047CA0 Offset: 0x2047DA1 VA: 0x2047CA0
	public void .ctor() { }
}

