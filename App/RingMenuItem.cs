// Namespace: App
public class RingMenuItem : BasicMenuItem // TypeDefIndex: 11175
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x296E50 Offset: 0x296F51 VA: 0x296E50
	private RingData <m_RingData>k__BackingField; // 0x68
	[CompilerGeneratedAttribute] // RVA: 0x296E60 Offset: 0x296F61 VA: 0x296E60
	private bool <m_IsEquipped>k__BackingField; // 0x70
	[CompilerGeneratedAttribute] // RVA: 0x296E70 Offset: 0x296F71 VA: 0x296E70
	private int <m_Count>k__BackingField; // 0x74
	[CompilerGeneratedAttribute] // RVA: 0x296E80 Offset: 0x296F81 VA: 0x296E80
	private int <m_NeededCountToNext>k__BackingField; // 0x78
	[CompilerGeneratedAttribute] // RVA: 0x296E90 Offset: 0x296F91 VA: 0x296E90
	private int <m_NeededPieceOfBondsToNext>k__BackingField; // 0x7C
	[CompilerGeneratedAttribute] // RVA: 0x296EA0 Offset: 0x296FA1 VA: 0x296EA0
	private bool <m_IsEnoughCount>k__BackingField; // 0x80
	[CompilerGeneratedAttribute] // RVA: 0x296EB0 Offset: 0x296FB1 VA: 0x296EB0
	private bool <m_IsEnoughPieceOfBond>k__BackingField; // 0x81
	protected RingMenuItem.SelectEventHandler m_SelectEventHandler; // 0x88
	protected RingMenuItem.DecideEventHandler m_DecideEventHandler; // 0x90

	// Properties
	public RingData m_RingData { get; set; }
	public bool m_IsEquipped { get; set; }
	public int m_Count { get; set; }
	public int m_NeededCountToNext { get; set; }
	public int m_NeededPieceOfBondsToNext { get; set; }
	public bool m_IsEnoughCount { get; set; }
	public bool m_IsEnoughPieceOfBond { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2C3B90 Offset: 0x2C3C91 VA: 0x2C3B90
	// RVA: 0x2691A80 Offset: 0x2691B81 VA: 0x2691A80
	public RingData get_m_RingData() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C3BA0 Offset: 0x2C3CA1 VA: 0x2C3BA0
	// RVA: 0x2691A90 Offset: 0x2691B91 VA: 0x2691A90
	private void set_m_RingData(RingData value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C3BB0 Offset: 0x2C3CB1 VA: 0x2C3BB0
	// RVA: 0x2691AA0 Offset: 0x2691BA1 VA: 0x2691AA0
	public bool get_m_IsEquipped() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C3BC0 Offset: 0x2C3CC1 VA: 0x2C3BC0
	// RVA: 0x2691AB0 Offset: 0x2691BB1 VA: 0x2691AB0
	private void set_m_IsEquipped(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C3BD0 Offset: 0x2C3CD1 VA: 0x2C3BD0
	// RVA: 0x2691AC0 Offset: 0x2691BC1 VA: 0x2691AC0
	public int get_m_Count() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C3BE0 Offset: 0x2C3CE1 VA: 0x2C3BE0
	// RVA: 0x2691AD0 Offset: 0x2691BD1 VA: 0x2691AD0
	private void set_m_Count(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C3BF0 Offset: 0x2C3CF1 VA: 0x2C3BF0
	// RVA: 0x2691AE0 Offset: 0x2691BE1 VA: 0x2691AE0
	public int get_m_NeededCountToNext() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C3C00 Offset: 0x2C3D01 VA: 0x2C3C00
	// RVA: 0x2691AF0 Offset: 0x2691BF1 VA: 0x2691AF0
	private void set_m_NeededCountToNext(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C3C10 Offset: 0x2C3D11 VA: 0x2C3C10
	// RVA: 0x2691B00 Offset: 0x2691C01 VA: 0x2691B00
	public int get_m_NeededPieceOfBondsToNext() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C3C20 Offset: 0x2C3D21 VA: 0x2C3C20
	// RVA: 0x2691B10 Offset: 0x2691C11 VA: 0x2691B10
	private void set_m_NeededPieceOfBondsToNext(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C3C30 Offset: 0x2C3D31 VA: 0x2C3C30
	// RVA: 0x2691B20 Offset: 0x2691C21 VA: 0x2691B20
	public bool get_m_IsEnoughCount() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C3C40 Offset: 0x2C3D41 VA: 0x2C3C40
	// RVA: 0x2691B30 Offset: 0x2691C31 VA: 0x2691B30
	private void set_m_IsEnoughCount(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C3C50 Offset: 0x2C3D51 VA: 0x2C3C50
	// RVA: 0x2691B40 Offset: 0x2691C41 VA: 0x2691B40
	public bool get_m_IsEnoughPieceOfBond() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C3C60 Offset: 0x2C3D61 VA: 0x2C3C60
	// RVA: 0x2691B50 Offset: 0x2691C51 VA: 0x2691B50
	private void set_m_IsEnoughPieceOfBond(bool value) { }

	// RVA: 0x2691B60 Offset: 0x2691C61 VA: 0x2691B60
	public bool IsEmpty() { }

	// RVA: 0x26879F0 Offset: 0x2687AF1 VA: 0x26879F0
	public void .ctor(RingData ringData, bool isEquipped, int count, RingMenuItem.SelectEventHandler selectEventHandler, RingMenuItem.DecideEventHandler decideEventHandler) { }

	// RVA: 0x2691B70 Offset: 0x2691C71 VA: 0x2691B70 Slot: 4
	public override string GetName() { }

	// RVA: 0x2691C40 Offset: 0x2691D41 VA: 0x2691C40 Slot: 8
	public override BasicMenuItem.Attribute BuildAttribute() { }

	// RVA: 0x2691C80 Offset: 0x2691D81 VA: 0x2691C80 Slot: 10
	public override void OnBuild() { }

	// RVA: 0x2691E70 Offset: 0x2691F71 VA: 0x2691E70 Slot: 11
	public override void OnBuildMenuItemContent() { }

	// RVA: 0x2691C90 Offset: 0x2691D91 VA: 0x2691C90
	public void SetInitialColor() { }

	// RVA: 0x2691E80 Offset: 0x2691F81 VA: 0x2691E80 Slot: 12
	public override void OnSelect() { }

	// RVA: 0x2691EC0 Offset: 0x2691FC1 VA: 0x2691EC0 Slot: 18
	public override BasicMenu.Result ACall() { }
}

