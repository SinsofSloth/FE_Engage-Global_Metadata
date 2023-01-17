// Namespace: 
private abstract class DebugTransporterMenu.BaseMenuItem : MenuItem // TypeDefIndex: 10142
{
	// Methods

	// RVA: 0x1E178B0 Offset: 0x1E179B1 VA: 0x1E178B0
	protected bool CanAddToTransport(ItemData item) { }

	// RVA: 0x1E173F0 Offset: 0x1E174F1 VA: 0x1E173F0
	protected void AddItems() { }

	// RVA: 0x1E17530 Offset: 0x1E17631 VA: 0x1E17530
	protected void .ctor() { }
}

// Namespace: 
private class DebugTransporterMenu.FillAllMenuItem : DebugTransporterMenu.BaseMenuItem // TypeDefIndex: 10144
{
	// Methods

	// RVA: 0x1E17AC0 Offset: 0x1E17BC1 VA: 0x1E17AC0 Slot: 5
	public override string GetName() { }

	// RVA: 0x1E17B10 Offset: 0x1E17C11 VA: 0x1E17B10 Slot: 12
	public override MenuItem.Result ACall() { }

	// RVA: 0x1E17BF0 Offset: 0x1E17CF1 VA: 0x1E17BF0
	public void .ctor() { }
}

// Namespace: 
private class DebugTransporterMenu.AddByKindMenuItem : DebugTransporterMenu.BaseMenuItem // TypeDefIndex: 10146
{
	// Fields
	private ItemData.Kinds m_Kind; // 0x20
	private string m_Name; // 0x28

	// Methods

	// RVA: 0x1E17540 Offset: 0x1E17641 VA: 0x1E17540
	public void .ctor(ItemData.Kinds kind) { }

	// RVA: 0x1E17760 Offset: 0x1E17861 VA: 0x1E17760 Slot: 5
	public override string GetName() { }

	// RVA: 0x1E17770 Offset: 0x1E17871 VA: 0x1E17770 Slot: 12
	public override MenuItem.Result ACall() { }
}

