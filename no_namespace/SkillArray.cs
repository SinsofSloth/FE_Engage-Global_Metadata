// Namespace: 
public struct SkillArray.Entity // TypeDefIndex: 13476
{
	// Fields
	private uint Value; // 0x0

	// Properties
	public int Index { get; set; }
	public int Group { get; set; }
	public int Age { get; set; }
	public SkillData.Categorys Category { get; set; }
	public SkillData Skill { get; }

	// Methods

	// RVA: 0x203B7F0 Offset: 0x203B8F1 VA: 0x203B7F0
	public void .ctor(int index, int group, SkillData.Categorys category, int age = 0) { }

	// RVA: 0x203B810 Offset: 0x203B911 VA: 0x203B810
	public int get_Index() { }

	// RVA: 0x203B820 Offset: 0x203B921 VA: 0x203B820
	public void set_Index(int value) { }

	// RVA: 0x203B830 Offset: 0x203B931 VA: 0x203B830
	public int get_Group() { }

	// RVA: 0x203B840 Offset: 0x203B941 VA: 0x203B840
	public void set_Group(int value) { }

	// RVA: 0x203B850 Offset: 0x203B951 VA: 0x203B850
	public int get_Age() { }

	// RVA: 0x203B860 Offset: 0x203B961 VA: 0x203B860
	public void set_Age(int value) { }

	// RVA: 0x203B870 Offset: 0x203B971 VA: 0x203B870
	public SkillData.Categorys get_Category() { }

	// RVA: 0x203B880 Offset: 0x203B981 VA: 0x203B880
	public void set_Category(SkillData.Categorys value) { }

	// RVA: 0x203B890 Offset: 0x203B991 VA: 0x203B890
	public SkillData get_Skill() { }
}

// Namespace: 
public struct SkillArray.Enumerator : IEnumerator<SkillData>, IEnumerator, IDisposable // TypeDefIndex: 13477
{
	// Fields
	private SkillArray m_Array; // 0x0
	private SkillData m_Current; // 0x8
	private int m_Index; // 0x10

	// Properties
	private object System.Collections.IEnumerator.Current { get; }
	public SkillData Current { get; }

	// Methods

	// RVA: 0x203B920 Offset: 0x203BA21 VA: 0x203B920
	public void .ctor(SkillArray skillArray) { }

	// RVA: 0x203B960 Offset: 0x203BA61 VA: 0x203B960 Slot: 5
	public void Dispose() { }

	// RVA: 0x203B9A0 Offset: 0x203BAA1 VA: 0x203B9A0 Slot: 6
	public bool MoveNext() { }

	// RVA: 0x203BAF0 Offset: 0x203BBF1 VA: 0x203BAF0 Slot: 8
	public void Reset() { }

	// RVA: 0x203BB00 Offset: 0x203BC01 VA: 0x203BB00 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x203BB10 Offset: 0x203BC11 VA: 0x203BB10 Slot: 4
	public SkillData get_Current() { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x278DE0 Offset: 0x278EE1 VA: 0x278DE0
[Serializable]
private sealed class SkillArray.<>c // TypeDefIndex: 13478
{
	// Fields
	public static readonly SkillArray.<>c <>9; // 0x0
	public static Comparison<SkillArray.Entity> <>9__40_0; // 0x8

	// Methods

	// RVA: 0x203B660 Offset: 0x203B761 VA: 0x203B660
	private static void .cctor() { }

	// RVA: 0x203B6D0 Offset: 0x203B7D1 VA: 0x203B6D0
	public void .ctor() { }

	// RVA: 0x203B6E0 Offset: 0x203B7E1 VA: 0x203B6E0
	internal int <Sort>b__40_0(SkillArray.Entity a, SkillArray.Entity b) { }
}

