// Namespace: App
public class GodUnitMenuItem : BasicMenuItem // TypeDefIndex: 11736
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x298E30 Offset: 0x298F31 VA: 0x298E30
	private GodUnit <God>k__BackingField; // 0x68
	private GodUnitSelectMenu.SelectEventHandler m_SelectEventHandler; // 0x70
	private GodUnitSelectMenu.DecideEventHandler m_DecideEventHandler; // 0x78
	private bool m_IsSelected; // 0x80
	private bool m_IsShowRingDirtyIcon; // 0x81
	private RingCleaningSequence.GodType m_GodType; // 0x84

	// Properties
	public GodUnit God { get; set; }
	public RingCleaningSequence.GodType Type { get; }
	public bool IsShowRingIcon { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2C6460 Offset: 0x2C6561 VA: 0x2C6460
	// RVA: 0x27B9E60 Offset: 0x27B9F61 VA: 0x27B9E60
	public GodUnit get_God() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C6470 Offset: 0x2C6571 VA: 0x2C6470
	// RVA: 0x27B9E70 Offset: 0x27B9F71 VA: 0x27B9E70
	private void set_God(GodUnit value) { }

	// RVA: 0x27B9DA0 Offset: 0x27B9EA1 VA: 0x27B9DA0
	public void .ctor(GodUnit god, GodUnitSelectMenu.SelectEventHandler selectEventHandler, GodUnitSelectMenu.DecideEventHandler decideEventHandler, bool isSelected, bool isShowRingDirtyIcon = False, RingCleaningSequence.GodType type = -1) { }

	// RVA: 0x27B9E80 Offset: 0x27B9F81 VA: 0x27B9E80 Slot: 8
	public override BasicMenuItem.Attribute BuildAttribute() { }

	// RVA: 0x27B9EA0 Offset: 0x27B9FA1 VA: 0x27B9EA0 Slot: 18
	public override BasicMenu.Result ACall() { }

	// RVA: 0x27B9EE0 Offset: 0x27B9FE1 VA: 0x27B9EE0 Slot: 19
	public override BasicMenu.Result BCall() { }

	// RVA: 0x27B9F10 Offset: 0x27BA011 VA: 0x27B9F10 Slot: 12
	public override void OnSelect() { }

	// RVA: 0x27B9F60 Offset: 0x27BA061 VA: 0x27B9F60
	public string GetGodName() { }

	// RVA: 0x27B9F70 Offset: 0x27BA071 VA: 0x27B9F70
	public GodData GetOptionalGodData() { }

	// RVA: 0x27BA010 Offset: 0x27BA111 VA: 0x27BA010
	public RingCleaningSequence.GodType get_Type() { }

	// RVA: 0x27BA020 Offset: 0x27BA121 VA: 0x27BA020
	public bool get_IsShowRingIcon() { }
}

