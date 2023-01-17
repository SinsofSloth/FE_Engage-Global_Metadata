// Namespace: App
[DefaultMemberAttribute] // RVA: 0x279350 Offset: 0x279451 VA: 0x279350
public class StringCalculator : CalculatorUtil // TypeDefIndex: 13937
{
	// Fields
	protected List<CalculatorUtil.Entity> m_Entitys; // 0x10
	protected List<int> m_Polishs; // 0x18

	// Properties
	public List<CalculatorUtil.Entity> Entitys { get; }
	public List<int> Polishs { get; }
	public CalculatorUtil.Entity Item { get; }
	public int Count { get; }

	// Methods

	// RVA: 0x2924250 Offset: 0x2924351 VA: 0x2924250
	public List<CalculatorUtil.Entity> get_Entitys() { }

	// RVA: 0x2924260 Offset: 0x2924361 VA: 0x2924260
	public List<int> get_Polishs() { }

	// RVA: 0x2924270 Offset: 0x2924371 VA: 0x2924270
	public void .ctor() { }

	// RVA: 0x2924390 Offset: 0x2924491 VA: 0x2924390
	public void .ctor(string name) { }

	// RVA: 0x2924C70 Offset: 0x2924D71 VA: 0x2924C70
	private CalculatorUtil.Type GetLastType() { }

	// RVA: 0x2924CF0 Offset: 0x2924DF1 VA: 0x2924CF0
	public CalculatorUtil.Entity get_Item(int index) { }

	// RVA: 0x2924D60 Offset: 0x2924E61 VA: 0x2924D60
	public int get_Count() { }

	// RVA: 0x2924DB0 Offset: 0x2924EB1 VA: 0x2924DB0
	private static string TrimString(string name) { }

	// RVA: 0x29244C0 Offset: 0x29245C1 VA: 0x29244C0
	public void Setup(string name) { }

	// RVA: 0x2924FF0 Offset: 0x29250F1 VA: 0x2924FF0
	public void Clear() { }

	// RVA: 0x2924F50 Offset: 0x2925051 VA: 0x2924F50
	private void CalcReversePolish() { }

	// RVA: 0x2925070 Offset: 0x2925171 VA: 0x2925070
	private int CalcReversePolish(int index) { }

	// RVA: 0x2925360 Offset: 0x2925461 VA: 0x2925360 Slot: 3
	public override string ToString() { }
}

