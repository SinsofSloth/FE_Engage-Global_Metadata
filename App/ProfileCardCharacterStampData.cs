// Namespace: App
public class ProfileCardCharacterStampData : StructData<ProfileCardCharacterStampData> // TypeDefIndex: 10004
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x28C7E0 Offset: 0x28C8E1 VA: 0x28C7E0
	private string <Id>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x28C7F0 Offset: 0x28C8F1 VA: 0x28C7F0
	private string <Image>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x28C800 Offset: 0x28C901 VA: 0x28C800
	private ProfileCardCondition <Condition>k__BackingField; // 0x30
	[CompilerGeneratedAttribute] // RVA: 0x28C810 Offset: 0x28C911 VA: 0x28C810
	private string <Arg>k__BackingField; // 0x38

	// Properties
	public string Id { get; set; }
	public string Image { get; set; }
	public ProfileCardCondition Condition { get; set; }
	public string Arg { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2BAE70 Offset: 0x2BAF71 VA: 0x2BAE70
	// RVA: 0x28095F0 Offset: 0x28096F1 VA: 0x28095F0
	public string get_Id() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BAE80 Offset: 0x2BAF81 VA: 0x2BAE80
	// RVA: 0x2809600 Offset: 0x2809701 VA: 0x2809600
	private void set_Id(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BAE90 Offset: 0x2BAF91 VA: 0x2BAE90
	// RVA: 0x2809610 Offset: 0x2809711 VA: 0x2809610
	public string get_Image() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BAEA0 Offset: 0x2BAFA1 VA: 0x2BAEA0
	// RVA: 0x2809620 Offset: 0x2809721 VA: 0x2809620
	private void set_Image(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BAEB0 Offset: 0x2BAFB1 VA: 0x2BAEB0
	// RVA: 0x2809630 Offset: 0x2809731 VA: 0x2809630
	public ProfileCardCondition get_Condition() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BAEC0 Offset: 0x2BAFC1 VA: 0x2BAEC0
	// RVA: 0x2809640 Offset: 0x2809741 VA: 0x2809640
	private void set_Condition(ProfileCardCondition value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BAED0 Offset: 0x2BAFD1 VA: 0x2BAED0
	// RVA: 0x2809650 Offset: 0x2809751 VA: 0x2809650
	public string get_Arg() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BAEE0 Offset: 0x2BAFE1 VA: 0x2BAEE0
	// RVA: 0x2809660 Offset: 0x2809761 VA: 0x2809660
	private void set_Arg(string value) { }

	// RVA: 0x2809670 Offset: 0x2809771 VA: 0x2809670
	public static void Load() { }

	// RVA: 0x2809720 Offset: 0x2809821 VA: 0x2809720 Slot: 8
	public override string GetDebugName() { }

	// RVA: 0x2809730 Offset: 0x2809831 VA: 0x2809730
	public static ProfileCardCharacterStampData TryGetFromImage(string image) { }

	// RVA: 0x2809860 Offset: 0x2809961 VA: 0x2809860
	public void .ctor() { }
}

