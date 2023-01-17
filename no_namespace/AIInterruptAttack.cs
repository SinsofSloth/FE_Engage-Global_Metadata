// Namespace: 
[DefaultMemberAttribute] // RVA: 0x275340 Offset: 0x275441 VA: 0x275340
private class AIInterruptAttack.CandidateList // TypeDefIndex: 9261
{
	// Fields
	private List<AIInterruptAttack.Candidate> m_Pool; // 0x10
	private List<AIInterruptAttack.Candidate> m_List; // 0x18

	// Properties
	public int Count { get; }
	public AIInterruptAttack.Candidate Item { get; }

	// Methods

	// RVA: 0x2F313D0 Offset: 0x2F314D1 VA: 0x2F313D0
	public void .ctor() { }

	// RVA: 0x2F30F30 Offset: 0x2F31031 VA: 0x2F30F30
	public void Add(Unit unit, bool isThinkBreak, bool isThinkChain, int dist) { }

	// RVA: 0x2F31610 Offset: 0x2F31711 VA: 0x2F31610
	public void Sort() { }

	// RVA: 0x2F31740 Offset: 0x2F31841 VA: 0x2F31740
	public void Clear() { }

	// RVA: 0x2F31810 Offset: 0x2F31911 VA: 0x2F31810
	public bool HasAttacker() { }

	// RVA: 0x2F31890 Offset: 0x2F31991 VA: 0x2F31890
	public AIInterruptAttack.Candidate GetAttacker() { }

	// RVA: 0x2F31950 Offset: 0x2F31A51 VA: 0x2F31950
	public int get_Count() { }

	// RVA: 0x2F319A0 Offset: 0x2F31AA1 VA: 0x2F319A0
	public AIInterruptAttack.Candidate get_Item(int index) { }
}

