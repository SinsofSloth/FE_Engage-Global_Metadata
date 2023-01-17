// Namespace: 
public struct SkillEnum.Enumerator : IEnumerator<SkillData>, IEnumerator, IDisposable // TypeDefIndex: 13480
{
	// Fields
	private int m_Index; // 0x0
	private int m_Count; // 0x4
	private SkillArray m_Array; // 0x8
	private SkillData m_Current; // 0x10
	private SkillData.TimingMasks m_Mask; // 0x18

	// Properties
	private object System.Collections.IEnumerator.Current { get; }
	public SkillData Current { get; }

	// Methods

	// RVA: 0x203C310 Offset: 0x203C411 VA: 0x203C310
	public void .ctor(SkillArray array, SkillData.TimingMasks mask, int count) { }

	// RVA: 0x203C360 Offset: 0x203C461 VA: 0x203C360 Slot: 5
	public void Dispose() { }

	// RVA: 0x203C3A0 Offset: 0x203C4A1 VA: 0x203C3A0 Slot: 6
	public bool MoveNext() { }

	// RVA: 0x203C520 Offset: 0x203C621 VA: 0x203C520 Slot: 8
	public void Reset() { }

	// RVA: 0x203C530 Offset: 0x203C631 VA: 0x203C530 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x203C540 Offset: 0x203C641 VA: 0x203C540 Slot: 4
	public SkillData get_Current() { }
}

