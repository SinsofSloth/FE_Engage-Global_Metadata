// Namespace: App
public class InvestmentNationDataSequence : SingletonProcInst<InvestmentNationDataSequence> // TypeDefIndex: 11437
{
	// Fields
	private const string ResNameC = "UI/Hub/CafeTerrace/NoticeBoard/Prefabs/WdwItemList";
	private InvestmentNationDataMenu m_window; // 0x78
	private static int m_nationIndex; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x2982B0 Offset: 0x2983B1 VA: 0x2982B0
	private InvestmentNationDataSequence.DecideEventHandler <m_DecideEventHandler>k__BackingField; // 0x80

	// Properties
	public InvestmentNationDataSequence.DecideEventHandler m_DecideEventHandler { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2C5790 Offset: 0x2C5891 VA: 0x2C5790
	// RVA: 0x2B5ECC0 Offset: 0x2B5EDC1 VA: 0x2B5ECC0
	public InvestmentNationDataSequence.DecideEventHandler get_m_DecideEventHandler() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C57A0 Offset: 0x2C58A1 VA: 0x2C57A0
	// RVA: 0x2B5ECD0 Offset: 0x2B5EDD1 VA: 0x2B5ECD0
	public void set_m_DecideEventHandler(InvestmentNationDataSequence.DecideEventHandler value) { }

	// RVA: 0x2B5ECE0 Offset: 0x2B5EDE1 VA: 0x2B5ECE0
	public static void CreateBind(ProcInst super, int nationIndex, InvestmentNationDataSequence.DecideEventHandler eventHandler) { }

	// RVA: 0x2B5EE00 Offset: 0x2B5EF01 VA: 0x2B5EE00
	private void .ctor(InvestmentNationDataSequence.DecideEventHandler eventHandler) { }

	// RVA: 0x2B5EEA0 Offset: 0x2B5EFA1 VA: 0x2B5EEA0
	private ProcDesc[] CreateDesc() { }

	// RVA: 0x2B5F3F0 Offset: 0x2B5F4F1 VA: 0x2B5F3F0
	private void LoadRes() { }

	// RVA: 0x2B5F490 Offset: 0x2B5F591 VA: 0x2B5F490
	private void Open() { }

	// RVA: 0x2B5F630 Offset: 0x2B5F731 VA: 0x2B5F630
	private void CloseEvent() { }

	// RVA: 0x2B5F650 Offset: 0x2B5F751 VA: 0x2B5F650
	private bool IsClosed() { }

	// RVA: 0x2B5F740 Offset: 0x2B5F841 VA: 0x2B5F740
	private void Close() { }

	// RVA: 0x2B5F810 Offset: 0x2B5F911 VA: 0x2B5F810
	private static void .cctor() { }
}

