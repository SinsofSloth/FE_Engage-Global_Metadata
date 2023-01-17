// Namespace: 
private class DebugUnitItemMenu.UnitDebugMenu : DebugMenu // TypeDefIndex: 10154
{
	// Fields
	private Unit m_Unit; // 0xE0

	// Methods

	// RVA: 0x1E1AB80 Offset: 0x1E1AC81 VA: 0x1E1AB80
	public DebugUnitItemMenu.UnitDebugMenu SetUnit(Unit unit) { }

	// RVA: 0x1E1ABB0 Offset: 0x1E1ACB1 VA: 0x1E1ABB0 Slot: 19
	protected override void OnClose() { }

	// RVA: 0x1E1ABC0 Offset: 0x1E1ACC1 VA: 0x1E1ABC0
	public void .ctor() { }
}

// Namespace: 
private class DebugUnitItemMenu.EditItemMenuItem : MenuItem // TypeDefIndex: 10155
{
	// Fields
	private const int MinIndex = 0;
	private Unit m_Unit; // 0x20
	private int m_UnitItemIndex; // 0x28
	private UnitItem m_UnitItem; // 0x30

	// Methods

	// RVA: 0x1E187A0 Offset: 0x1E188A1 VA: 0x1E187A0
	public void .ctor(Unit unit, int unitItemIndex) { }

	// RVA: 0x1E18810 Offset: 0x1E18911 VA: 0x1E18810 Slot: 29
	public override int GetColumnCount() { }

	// RVA: 0x1E18820 Offset: 0x1E18921 VA: 0x1E18820 Slot: 31
	public override float GetColumnWidth0() { }

	// RVA: 0x1E18830 Offset: 0x1E18931 VA: 0x1E18830 Slot: 32
	public override float GetColumnWidth1() { }

	// RVA: 0x1E18840 Offset: 0x1E18941 VA: 0x1E18840 Slot: 27
	public override Color GetFontColor() { }

	// RVA: 0x1E18910 Offset: 0x1E18A11 VA: 0x1E18910 Slot: 42
	public override string GetColumnName0() { }

	// RVA: 0x1E189A0 Offset: 0x1E18AA1 VA: 0x1E189A0 Slot: 43
	public override string GetColumnName1() { }

	// RVA: 0x1E189E0 Offset: 0x1E18AE1 VA: 0x1E189E0 Slot: 22
	public override bool IsEnable() { }

	// RVA: 0x1E18AA0 Offset: 0x1E18BA1 VA: 0x1E18AA0 Slot: 12
	public override MenuItem.Result ACall() { }

	// RVA: 0x1E18CB0 Offset: 0x1E18DB1 VA: 0x1E18CB0 Slot: 14
	public override MenuItem.Result XCall() { }

	// RVA: 0x1E18FA0 Offset: 0x1E190A1 VA: 0x1E18FA0 Slot: 68
	public override void OnTick() { }

	// RVA: 0x1E1A580 Offset: 0x1E1A681 VA: 0x1E1A580 Slot: 7
	public override string GetHelp() { }

	// RVA: 0x1E1A360 Offset: 0x1E1A461 VA: 0x1E1A360
	private int GetPrevIndex(int index, bool isTrigger) { }

	// RVA: 0x1E1A470 Offset: 0x1E1A571 VA: 0x1E1A470
	private int GetNextIndex(int index, bool isTrigger) { }
}

// Namespace: 
private class DebugUnitItemMenu.ItemListMenu.ItemMenuItem : MenuItem // TypeDefIndex: 10156
{
	// Fields
	private Unit m_Unit; // 0x20
	private UnitItem m_UnitItem; // 0x28
	private int m_Index; // 0x30
	private bool m_IsEnable; // 0x34

	// Methods

	// RVA: 0x1DC2440 Offset: 0x1DC2541 VA: 0x1DC2440
	public void .ctor(Unit unit, UnitItem unitItem, int index) { }

	// RVA: 0x1DC3090 Offset: 0x1DC3191 VA: 0x1DC3090 Slot: 29
	public override int GetColumnCount() { }

	// RVA: 0x1DC30A0 Offset: 0x1DC31A1 VA: 0x1DC30A0 Slot: 31
	public override float GetColumnWidth0() { }

	// RVA: 0x1DC30B0 Offset: 0x1DC31B1 VA: 0x1DC30B0 Slot: 32
	public override float GetColumnWidth1() { }

	// RVA: 0x1DC30C0 Offset: 0x1DC31C1 VA: 0x1DC30C0 Slot: 42
	public override string GetColumnName0() { }

	// RVA: 0x1DC30D0 Offset: 0x1DC31D1 VA: 0x1DC30D0 Slot: 43
	public override string GetColumnName1() { }

	// RVA: 0x1DC3160 Offset: 0x1DC3261 VA: 0x1DC3160 Slot: 22
	public override bool IsEnable() { }

	// RVA: 0x1DC3170 Offset: 0x1DC3271 VA: 0x1DC3170 Slot: 12
	public override MenuItem.Result ACall() { }
}

// Namespace: 
private class DebugUnitItemMenu.ItemListMenu // TypeDefIndex: 10157
{
	// Methods

	// RVA: 0x1E18AE0 Offset: 0x1E18BE1 VA: 0x1E18AE0
	public static void CreateBind(ProcInst super, Unit unit, UnitItem unitItem) { }

	// RVA: 0x1E1A8C0 Offset: 0x1E1A9C1 VA: 0x1E1A8C0
	public void .ctor() { }
}

// Namespace: 
private class DebugUnitItemMenu.SubMenu.BaseMenuItem : MenuItem // TypeDefIndex: 10158
{
	// Fields
	protected Unit m_Unit; // 0x20
	protected int m_UnitItemIndex; // 0x28
	protected UnitItem m_UnitItem; // 0x30

	// Methods

	// RVA: 0x1DC3EE0 Offset: 0x1DC3FE1 VA: 0x1DC3EE0
	public void .ctor(Unit unit, int unitItemIndex) { }

	// RVA: 0x1DC3F50 Offset: 0x1DC4051 VA: 0x1DC3F50 Slot: 25
	public override float GetWidth() { }
}

// Namespace: 
private class DebugUnitItemMenu.SubMenu.NameMenuItem : DebugUnitItemMenu.SubMenu.BaseMenuItem // TypeDefIndex: 10159
{
	// Methods

	// RVA: 0x1DC4740 Offset: 0x1DC4841 VA: 0x1DC4740
	public void .ctor(Unit unit, int unitItemIndex) { }

	// RVA: 0x1DC47B0 Offset: 0x1DC48B1 VA: 0x1DC47B0 Slot: 5
	public override string GetName() { }
}

// Namespace: 
private abstract class DebugUnitItemMenu.SubMenu.FlagMenuItem : DebugUnitItemMenu.SubMenu.BaseMenuItem // TypeDefIndex: 10160
{
	// Methods

	// RVA: 0x1DC3FD0 Offset: 0x1DC40D1 VA: 0x1DC3FD0
	protected void .ctor(Unit unit, int unitItemIndex) { }

	// RVA: 0x1DC45B0 Offset: 0x1DC46B1 VA: 0x1DC45B0 Slot: 5
	public override string GetName() { }

	// RVA: -1 Offset: -1 Slot: 72
	protected abstract string GetLabel();

	// RVA: -1 Offset: -1 Slot: 73
	protected abstract void SetFlag(bool enable);

	// RVA: -1 Offset: -1 Slot: 74
	protected abstract bool IsFlag();

	// RVA: 0x1DC4680 Offset: 0x1DC4781 VA: 0x1DC4680 Slot: 22
	public override bool IsEnable() { }

	// RVA: 0x1DC46A0 Offset: 0x1DC47A1 VA: 0x1DC46A0 Slot: 12
	public override MenuItem.Result ACall() { }
}

// Namespace: 
private class DebugUnitItemMenu.SubMenu.DropMenuItem : DebugUnitItemMenu.SubMenu.FlagMenuItem // TypeDefIndex: 10161
{
	// Methods

	// RVA: 0x1DC3F60 Offset: 0x1DC4061 VA: 0x1DC3F60
	public void .ctor(Unit unit, int unitItemIndex) { }

	// RVA: 0x1DC4040 Offset: 0x1DC4141 VA: 0x1DC4040 Slot: 72
	protected override string GetLabel() { }

	// RVA: 0x1DC4090 Offset: 0x1DC4191 VA: 0x1DC4090 Slot: 73
	protected override void SetFlag(bool enable) { }

	// RVA: 0x1DC40A0 Offset: 0x1DC41A1 VA: 0x1DC40A0 Slot: 74
	protected override bool IsFlag() { }
}

// Namespace: 
private class DebugUnitItemMenu.SubMenu.EnchantMenuItem : DebugUnitItemMenu.SubMenu.FlagMenuItem // TypeDefIndex: 10162
{
	// Methods

	// RVA: 0x1DC4250 Offset: 0x1DC4351 VA: 0x1DC4250
	public void .ctor(Unit unit, int unitItemIndex) { }

	// RVA: 0x1DC42C0 Offset: 0x1DC43C1 VA: 0x1DC42C0 Slot: 72
	protected override string GetLabel() { }

	// RVA: 0x1DC4310 Offset: 0x1DC4411 VA: 0x1DC4310 Slot: 73
	protected override void SetFlag(bool enable) { }

	// RVA: 0x1DC43C0 Offset: 0x1DC44C1 VA: 0x1DC43C0 Slot: 74
	protected override bool IsFlag() { }
}

// Namespace: 
private class DebugUnitItemMenu.SubMenu.RefineMenuItem : DebugUnitItemMenu.SubMenu.BaseMenuItem // TypeDefIndex: 10163
{
	// Methods

	// RVA: 0x1DC48D0 Offset: 0x1DC49D1 VA: 0x1DC48D0
	public void .ctor(Unit unit, int unitItemIndex) { }

	// RVA: 0x1DC4940 Offset: 0x1DC4A41 VA: 0x1DC4940 Slot: 5
	public override string GetName() { }

	// RVA: 0x1DC4990 Offset: 0x1DC4A91 VA: 0x1DC4990 Slot: 22
	public override bool IsEnable() { }

	// RVA: 0x1DC49E0 Offset: 0x1DC4AE1 VA: 0x1DC49E0 Slot: 12
	public override MenuItem.Result ACall() { }
}

// Namespace: 
private class DebugUnitItemMenu.SubMenu.EngraveMenuItem : DebugUnitItemMenu.SubMenu.BaseMenuItem // TypeDefIndex: 10164
{
	// Methods

	// RVA: 0x1DC4490 Offset: 0x1DC4591 VA: 0x1DC4490
	public void .ctor(Unit unit, int unitItemIndex) { }

	// RVA: 0x1DC4500 Offset: 0x1DC4601 VA: 0x1DC4500 Slot: 5
	public override string GetName() { }

	// RVA: 0x1DC4550 Offset: 0x1DC4651 VA: 0x1DC4550 Slot: 22
	public override bool IsEnable() { }

	// RVA: 0x1DC4560 Offset: 0x1DC4661 VA: 0x1DC4560 Slot: 12
	public override MenuItem.Result ACall() { }
}

// Namespace: 
private class DebugUnitItemMenu.SubMenu.ItemBaseMenuItem : DebugUnitItemMenu.SubMenu.BaseMenuItem // TypeDefIndex: 10165
{
	// Methods

	// RVA: 0x1DC4120 Offset: 0x1DC4221 VA: 0x1DC4120
	public void .ctor(Unit unit, int unitItemIndex) { }

	// RVA: 0x1DC4710 Offset: 0x1DC4811 VA: 0x1DC4710 Slot: 29
	public override int GetColumnCount() { }

	// RVA: 0x1DC4720 Offset: 0x1DC4821 VA: 0x1DC4720 Slot: 31
	public override float GetColumnWidth0() { }

	// RVA: 0x1DC4730 Offset: 0x1DC4831 VA: 0x1DC4730 Slot: 32
	public override float GetColumnWidth1() { }
}

// Namespace: 
private class DebugUnitItemMenu.SubMenu.PriceMenuItem : DebugUnitItemMenu.SubMenu.ItemBaseMenuItem // TypeDefIndex: 10166
{
	// Methods

	// RVA: 0x1DC47D0 Offset: 0x1DC48D1 VA: 0x1DC47D0
	public void .ctor(Unit unit, int unitItemIndex) { }

	// RVA: 0x1DC4840 Offset: 0x1DC4941 VA: 0x1DC4840 Slot: 42
	public override string GetColumnName0() { }

	// RVA: 0x1DC4890 Offset: 0x1DC4991 VA: 0x1DC4890 Slot: 43
	public override string GetColumnName1() { }
}

// Namespace: 
private class DebugUnitItemMenu.SubMenu.SellingMenuItem : DebugUnitItemMenu.SubMenu.ItemBaseMenuItem // TypeDefIndex: 10167
{
	// Methods

	// RVA: 0x1DC4A30 Offset: 0x1DC4B31 VA: 0x1DC4A30
	public void .ctor(Unit unit, int unitItemIndex) { }

	// RVA: 0x1DC4AA0 Offset: 0x1DC4BA1 VA: 0x1DC4AA0 Slot: 42
	public override string GetColumnName0() { }

	// RVA: 0x1DC4AF0 Offset: 0x1DC4BF1 VA: 0x1DC4AF0 Slot: 43
	public override string GetColumnName1() { }
}

// Namespace: 
private class DebugUnitItemMenu.SubMenu.EnchantHashMenuItem : DebugUnitItemMenu.SubMenu.ItemBaseMenuItem // TypeDefIndex: 10168
{
	// Methods

	// RVA: 0x1DC40B0 Offset: 0x1DC41B1 VA: 0x1DC40B0
	public void .ctor(Unit unit, int unitItemIndex) { }

	// RVA: 0x1DC4190 Offset: 0x1DC4291 VA: 0x1DC4190 Slot: 42
	public override string GetColumnName0() { }

	// RVA: 0x1DC41E0 Offset: 0x1DC42E1 VA: 0x1DC41E0 Slot: 43
	public override string GetColumnName1() { }
}

// Namespace: 
private class DebugUnitItemMenu.SubMenu // TypeDefIndex: 10169
{
	// Methods

	// RVA: 0x1E18CF0 Offset: 0x1E18DF1 VA: 0x1E18CF0
	public static void CreateBind(ProcInst super, Unit unit, int unitItemIndex) { }

	// RVA: 0x1E1AB70 Offset: 0x1E1AC71 VA: 0x1E1AB70
	public void .ctor() { }
}

// Namespace: 
private class DebugUnitItemMenu.RefineMenu.BaseMenuItem : MenuItem // TypeDefIndex: 10170
{
	// Fields
	protected Unit m_Unit; // 0x20
	protected int m_UnitItemIndex; // 0x28
	protected UnitItem m_UnitItem; // 0x30

	// Methods

	// RVA: 0x1DC3300 Offset: 0x1DC3401 VA: 0x1DC3300
	public void .ctor(Unit unit, int unitItemIndex) { }

	// RVA: 0x1DC3370 Offset: 0x1DC3471 VA: 0x1DC3370 Slot: 29
	public override int GetColumnCount() { }

	// RVA: 0x1DC3380 Offset: 0x1DC3481 VA: 0x1DC3380 Slot: 31
	public override float GetColumnWidth0() { }

	// RVA: 0x1DC3390 Offset: 0x1DC3491 VA: 0x1DC3390 Slot: 32
	public override float GetColumnWidth1() { }

	// RVA: 0x1DC33A0 Offset: 0x1DC34A1 VA: 0x1DC33A0 Slot: 33
	public override float GetColumnWidth2() { }
}

// Namespace: 
private class DebugUnitItemMenu.RefineMenu.RefineMenuItem : DebugUnitItemMenu.RefineMenu.BaseMenuItem // TypeDefIndex: 10171
{
	// Fields
	private int m_Level; // 0x38
	private ItemRefineData m_Data; // 0x40

	// Methods

	// RVA: 0x1DC3830 Offset: 0x1DC3931 VA: 0x1DC3830
	public void .ctor(Unit unit, int unitItemIndex, int refineLevel, ItemRefineData refineData) { }

	// RVA: 0x1DC38C0 Offset: 0x1DC39C1 VA: 0x1DC38C0 Slot: 42
	public override string GetColumnName0() { }

	// RVA: 0x1DC39A0 Offset: 0x1DC3AA1 VA: 0x1DC39A0 Slot: 43
	public override string GetColumnName1() { }

	// RVA: 0x1DC3C90 Offset: 0x1DC3D91 VA: 0x1DC3C90 Slot: 44
	public override string GetColumnName2() { }

	// RVA: 0x1DC3EB0 Offset: 0x1DC3FB1 VA: 0x1DC3EB0 Slot: 12
	public override MenuItem.Result ACall() { }

	// RVA: 0x1DC3BD0 Offset: 0x1DC3CD1 VA: 0x1DC3BD0
	private string GetParameterText(int value) { }
}

// Namespace: 
private class DebugUnitItemMenu.RefineMenu.EvolveMenuItem : DebugUnitItemMenu.RefineMenu.BaseMenuItem // TypeDefIndex: 10172
{
	// Fields
	private int m_DataIndex; // 0x38
	private ItemEvolveData m_Data; // 0x40

	// Methods

	// RVA: 0x1DC33B0 Offset: 0x1DC34B1 VA: 0x1DC33B0
	public void .ctor(Unit unit, int unitItemIndex, int dataIndex, ItemEvolveData evolveData) { }

	// RVA: 0x1DC3440 Offset: 0x1DC3541 VA: 0x1DC3440 Slot: 42
	public override string GetColumnName0() { }

	// RVA: 0x1DC34D0 Offset: 0x1DC35D1 VA: 0x1DC34D0 Slot: 43
	public override string GetColumnName1() { }

	// RVA: 0x1DC35A0 Offset: 0x1DC36A1 VA: 0x1DC35A0 Slot: 44
	public override string GetColumnName2() { }

	// RVA: 0x1DC3800 Offset: 0x1DC3901 VA: 0x1DC3800 Slot: 12
	public override MenuItem.Result ACall() { }
}

// Namespace: 
private class DebugUnitItemMenu.RefineMenu // TypeDefIndex: 10173
{
	// Methods

	// RVA: 0x1E1A8D0 Offset: 0x1E1A9D1 VA: 0x1E1A8D0
	public static void CreateBind(ProcInst super, Unit unit, int unitItemIndex) { }

	// RVA: 0x1E1AB60 Offset: 0x1E1AC61 VA: 0x1E1AB60
	public void .ctor() { }
}

// Namespace: 
private class DebugUnitItemMenu.EngraveMenu.BaseMenuItem : MenuItem // TypeDefIndex: 10174
{
	// Fields
	protected Unit m_Unit; // 0x20
	protected int m_UnitItemIndex; // 0x28
	protected UnitItem m_UnitItem; // 0x30

	// Methods

	// RVA: 0x1DC2140 Offset: 0x1DC2241 VA: 0x1DC2140
	public void .ctor(Unit unit, int unitItemIndex) { }
}

// Namespace: 
private class DebugUnitItemMenu.EngraveMenu.EngraveMenuItem : DebugUnitItemMenu.EngraveMenu.BaseMenuItem // TypeDefIndex: 10175
{
	// Fields
	private GodData m_GodData; // 0x38

	// Methods

	// RVA: 0x1DC22E0 Offset: 0x1DC23E1 VA: 0x1DC22E0
	public void .ctor(Unit unit, int unitItemIndex, GodData godData) { }

	// RVA: 0x1DC2360 Offset: 0x1DC2461 VA: 0x1DC2360 Slot: 5
	public override string GetName() { }

	// RVA: 0x1DC2410 Offset: 0x1DC2511 VA: 0x1DC2410 Slot: 12
	public override MenuItem.Result ACall() { }
}

// Namespace: 
private class DebugUnitItemMenu.EngraveMenu.ClearEngraveMenuItem : DebugUnitItemMenu.EngraveMenu.BaseMenuItem // TypeDefIndex: 10176
{
	// Methods

	// RVA: 0x1DC21B0 Offset: 0x1DC22B1 VA: 0x1DC21B0
	public void .ctor(Unit unit, int unitItemIndex) { }

	// RVA: 0x1DC2220 Offset: 0x1DC2321 VA: 0x1DC2220 Slot: 5
	public override string GetName() { }

	// RVA: 0x1DC2270 Offset: 0x1DC2371 VA: 0x1DC2270 Slot: 22
	public override bool IsEnable() { }

	// RVA: 0x1DC2280 Offset: 0x1DC2381 VA: 0x1DC2280 Slot: 12
	public override MenuItem.Result ACall() { }
}

// Namespace: 
private class DebugUnitItemMenu.EngraveMenu // TypeDefIndex: 10177
{
	// Methods

	// RVA: 0x1E1A5F0 Offset: 0x1E1A6F1 VA: 0x1E1A5F0
	public static void CreateBind(ProcInst super, Unit unit, int unitItemIndex) { }

	// RVA: 0x1E1A8B0 Offset: 0x1E1A9B1 VA: 0x1E1A8B0
	public void .ctor() { }
}

