// Namespace: App
public class ProfileCardCommentData : StructData<ProfileCardCommentData> // TypeDefIndex: 10011
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x28C930 Offset: 0x28CA31 VA: 0x28C930
	private string <Id>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x28C940 Offset: 0x28CA41 VA: 0x28C940
	private string <Name>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x28C950 Offset: 0x28CA51 VA: 0x28C950
	private ProfileCardCommentData.Categories <Category>k__BackingField; // 0x30
	[CompilerGeneratedAttribute] // RVA: 0x28C960 Offset: 0x28CA61 VA: 0x28C960
	private ProfileCardCondition <Condition>k__BackingField; // 0x34
	[CompilerGeneratedAttribute] // RVA: 0x28C970 Offset: 0x28CA71 VA: 0x28C970
	private string <Arg>k__BackingField; // 0x38
	private static readonly string[] CategoryMid; // 0x0

	// Properties
	public string Id { get; set; }
	public string Name { get; set; }
	public ProfileCardCommentData.Categories Category { get; set; }
	public ProfileCardCondition Condition { get; set; }
	public string Arg { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2BB110 Offset: 0x2BB211 VA: 0x2BB110
	// RVA: 0x2809F70 Offset: 0x280A071 VA: 0x2809F70
	public string get_Id() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BB120 Offset: 0x2BB221 VA: 0x2BB120
	// RVA: 0x2809F80 Offset: 0x280A081 VA: 0x2809F80
	private void set_Id(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BB130 Offset: 0x2BB231 VA: 0x2BB130
	// RVA: 0x2809F90 Offset: 0x280A091 VA: 0x2809F90
	public string get_Name() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BB140 Offset: 0x2BB241 VA: 0x2BB140
	// RVA: 0x2809FA0 Offset: 0x280A0A1 VA: 0x2809FA0
	private void set_Name(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BB150 Offset: 0x2BB251 VA: 0x2BB150
	// RVA: 0x2809FB0 Offset: 0x280A0B1 VA: 0x2809FB0
	public ProfileCardCommentData.Categories get_Category() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BB160 Offset: 0x2BB261 VA: 0x2BB160
	// RVA: 0x2809FC0 Offset: 0x280A0C1 VA: 0x2809FC0
	private void set_Category(ProfileCardCommentData.Categories value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BB170 Offset: 0x2BB271 VA: 0x2BB170
	// RVA: 0x2809FD0 Offset: 0x280A0D1 VA: 0x2809FD0
	public ProfileCardCondition get_Condition() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BB180 Offset: 0x2BB281 VA: 0x2BB180
	// RVA: 0x2809FE0 Offset: 0x280A0E1 VA: 0x2809FE0
	private void set_Condition(ProfileCardCondition value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BB190 Offset: 0x2BB291 VA: 0x2BB190
	// RVA: 0x2809FF0 Offset: 0x280A0F1 VA: 0x2809FF0
	public string get_Arg() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BB1A0 Offset: 0x2BB2A1 VA: 0x2BB1A0
	// RVA: 0x280A000 Offset: 0x280A101 VA: 0x280A000
	private void set_Arg(string value) { }

	// RVA: 0x280A010 Offset: 0x280A111 VA: 0x280A010
	public static void Load() { }

	// RVA: 0x280A0C0 Offset: 0x280A1C1 VA: 0x280A0C0 Slot: 8
	public override string GetDebugName() { }

	// RVA: 0x280A0D0 Offset: 0x280A1D1 VA: 0x280A0D0
	public string GetName() { }

	// RVA: 0x280A140 Offset: 0x280A241 VA: 0x280A140
	public static void GenerateComment(ProfileCardCommentData[] comments, StringBuilder messageBuffer) { }

	// RVA: 0x280A650 Offset: 0x280A751 VA: 0x280A650
	public static string GetCategoryMid(ProfileCardCommentData.Categories category) { }

	// RVA: 0x280A710 Offset: 0x280A811 VA: 0x280A710
	public void .ctor() { }

	// RVA: 0x280A790 Offset: 0x280A891 VA: 0x280A790
	private static void .cctor() { }
}

