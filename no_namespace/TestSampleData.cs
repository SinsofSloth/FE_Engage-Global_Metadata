// Namespace: 
[Serializable]
public class TestSampleData.Item // TypeDefIndex: 7603
{
	// Fields
	public string Name; // 0x10
	public int Value; // 0x18

	// Methods

	// RVA: 0x2392CE0 Offset: 0x2392DE1 VA: 0x2392CE0
	public void .ctor() { }
}

// Namespace: 
[FlagsAttribute] // RVA: 0x271380 Offset: 0x271481 VA: 0x271380
public enum TestSampleData.Flags // TypeDefIndex: 7604
{
	// Fields
	public int value__; // 0x0
	public const TestSampleData.Flags FlagA = 1;
	public const TestSampleData.Flags FlagB = 2;
	public const TestSampleData.Flags FlagC = 4;
	public const TestSampleData.Flags FlagD = 8;
	public const TestSampleData.Flags FlagAC = 5;
}

// Namespace: 
[Serializable]
public class TestSampleData : StructScriptableData<TestSampleData> // TypeDefIndex: 7605
{
	// Fields
	public string Pid; // 0x10
	public string Name; // 0x18
	public int Level; // 0x20
	public int Hp; // 0x24
	[EnumFlagsAttribute] // RVA: 0x27AEA0 Offset: 0x27AFA1 VA: 0x27AEA0
	public TestSampleData.Flags Flag; // 0x28
	public List<TestSampleData.Item> Items; // 0x30

	// Methods

	// RVA: 0x25D9D30 Offset: 0x25D9E31 VA: 0x25D9D30 Slot: 4
	public override string GetKey() { }

	// RVA: 0x25D9D40 Offset: 0x25D9E41 VA: 0x25D9D40 Slot: 5
	public override void OnBuild() { }

	// RVA: 0x25D9D50 Offset: 0x25D9E51 VA: 0x25D9D50 Slot: 6
	public override void OnRelease() { }

	// RVA: 0x25D9D60 Offset: 0x25D9E61 VA: 0x25D9D60 Slot: 7
	public override string GetDebugName() { }

	// RVA: 0x25D9DF0 Offset: 0x25D9EF1 VA: 0x25D9DF0
	public static void Load() { }

	// RVA: 0x25D9F00 Offset: 0x25DA001 VA: 0x25D9F00
	public void .ctor() { }
}

