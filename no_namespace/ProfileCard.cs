// Namespace: 
public class ProfileCard.FreeStamp // TypeDefIndex: 13631
{
	// Fields
	public ProfileCardStampData m_Stamp; // 0x10
	public int m_X; // 0x18
	public int m_Y; // 0x1C
	public float m_Rotation; // 0x20
	public float m_ScaleX; // 0x24
	public float m_ScaleY; // 0x28

	// Methods

	// RVA: 0x1F20720 Offset: 0x1F20821 VA: 0x1F20720
	public void .ctor() { }

	// RVA: 0x1F207B0 Offset: 0x1F208B1 VA: 0x1F207B0
	public void .ctor(ProfileCard.FreeStamp freeStamp) { }

	// RVA: 0x1F20770 Offset: 0x1F20871 VA: 0x1F20770
	public void Clear() { }

	// RVA: 0x1F20810 Offset: 0x1F20911 VA: 0x1F20810
	public static ProfileCard.FreeStamp Add(List<ProfileCard.FreeStamp> freeStampList, ProfileCardStampData stampData, int x, int y, float rotation, float scaleX, float scaleY) { }

	// RVA: 0x1F20930 Offset: 0x1F20A31 VA: 0x1F20930
	public static bool Add(List<ProfileCard.FreeStamp> freeStampList, ProfileCard.FreeStamp freeStamp) { }

	// RVA: 0x1F209C0 Offset: 0x1F20AC1 VA: 0x1F209C0
	public void Serialize(Stream stream) { }

	// RVA: 0x1F20A70 Offset: 0x1F20B71 VA: 0x1F20A70
	public void Deserialize(Stream stream, int version) { }
}

// Namespace: 
public struct ProfileCard.SortieCount // TypeDefIndex: 13632
{
	// Fields
	public PersonData m_Person; // 0x0
	public JobData m_Job; // 0x8
	public int m_Count; // 0x10

	// Methods

	// RVA: 0x1F20E10 Offset: 0x1F20F11 VA: 0x1F20E10
	public void Clear() { }

	// RVA: 0x1F20E50 Offset: 0x1F20F51 VA: 0x1F20E50
	public void Serialize(Stream stream) { }

	// RVA: 0x1F20EF0 Offset: 0x1F20FF1 VA: 0x1F20EF0
	public void Deserialize(Stream stream, int version) { }
}

// Namespace: 
public struct ProfileCard.Achievement // TypeDefIndex: 13633
{
	// Fields
	public AchieveData.Categories m_AcheveCatetory; // 0x0
	public int m_Count; // 0x4

	// Methods

	// RVA: 0x1F205A0 Offset: 0x1F206A1 VA: 0x1F205A0
	public void Clear() { }

	// RVA: 0x1F205B0 Offset: 0x1F206B1 VA: 0x1F205B0
	public void Serialize(Stream stream) { }

	// RVA: 0x1F205F0 Offset: 0x1F206F1 VA: 0x1F205F0
	public void Deserialize(Stream stream) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x2790E0 Offset: 0x2791E1 VA: 0x2790E0
[Serializable]
private sealed class ProfileCard.<>c // TypeDefIndex: 13634
{
	// Fields
	public static readonly ProfileCard.<>c <>9; // 0x0
	public static Comparison<ProfileCard.SortieCount> <>9__139_0; // 0x8

	// Methods

	// RVA: 0x1F20510 Offset: 0x1F20611 VA: 0x1F20510
	private static void .cctor() { }

	// RVA: 0x1F20580 Offset: 0x1F20681 VA: 0x1F20580
	public void .ctor() { }

	// RVA: 0x1F20590 Offset: 0x1F20691 VA: 0x1F20590
	internal int <SortSortieCount>b__139_0(ProfileCard.SortieCount lhs, ProfileCard.SortieCount rhs) { }
}

