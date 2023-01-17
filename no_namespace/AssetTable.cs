// Namespace: 
public enum AssetTable.Modes // TypeDefIndex: 9802
{
	// Fields
	public int value__; // 0x0
	public const AssetTable.Modes Common = 0;
	public const AssetTable.Modes Onmap = 1;
	public const AssetTable.Modes Combat = 2;
	public const AssetTable.Modes Gmap = 3;
	public const AssetTable.Modes Num = 4;
}

// Namespace: 
public class AssetTable.Accessory // TypeDefIndex: 9804
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x2882E0 Offset: 0x2883E1 VA: 0x2882E0
	private string <Locator>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x2882F0 Offset: 0x2883F1 VA: 0x2882F0
	private string <Model>k__BackingField; // 0x18

	// Properties
	public string Locator { get; set; }
	public string Model { get; set; }
	public bool Exist { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2B2410 Offset: 0x2B2511 VA: 0x2B2410
	// RVA: 0x1F688B0 Offset: 0x1F689B1 VA: 0x1F688B0
	public string get_Locator() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B2420 Offset: 0x2B2521 VA: 0x2B2420
	// RVA: 0x1F688C0 Offset: 0x1F689C1 VA: 0x1F688C0
	private void set_Locator(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B2430 Offset: 0x2B2531 VA: 0x2B2430
	// RVA: 0x1F688D0 Offset: 0x1F689D1 VA: 0x1F688D0
	public string get_Model() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B2440 Offset: 0x2B2541 VA: 0x2B2440
	// RVA: 0x1F688E0 Offset: 0x1F689E1 VA: 0x1F688E0
	private void set_Model(string value) { }

	// RVA: 0x1F688F0 Offset: 0x1F689F1 VA: 0x1F688F0 Slot: 3
	public override string ToString() { }

	// RVA: 0x1F68950 Offset: 0x1F68A51 VA: 0x1F68950
	public bool get_Exist() { }

	// RVA: 0x1F68980 Offset: 0x1F68A81 VA: 0x1F68980
	public void .ctor() { }
}

// Namespace: 
private class AssetTable.ConditionIndexes // TypeDefIndex: 9806
{
	// Fields
	private List<List<int>> m_List; // 0x10

	// Methods

	// RVA: 0x1F6AC80 Offset: 0x1F6AD81 VA: 0x1F6AC80
	public void Clear() { }

	// RVA: 0x1F6ACE0 Offset: 0x1F6ADE1 VA: 0x1F6ACE0
	public void Add(List<int> indexes) { }

	// RVA: 0x1F6AD40 Offset: 0x1F6AE41 VA: 0x1F6AD40
	public void Commit() { }

	// RVA: 0x1F6AD50 Offset: 0x1F6AE51 VA: 0x1F6AD50
	public bool Test(AssetTable.ConditionFlags flags) { }

	// RVA: 0x1F6AE90 Offset: 0x1F6AF91 VA: 0x1F6AE90
	public void .ctor() { }
}

// Namespace: 
public struct AssetTable.Sound // TypeDefIndex: 9808
{
	// Fields
	public string VoiceID; // 0x0
	public string FootstepID; // 0x8
	public string MaterialID; // 0x10

	// Methods

	// RVA: 0x1F71730 Offset: 0x1F71831 VA: 0x1F71730 Slot: 3
	public override string ToString() { }
}

