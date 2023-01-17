// Namespace: 
public enum Relay.TakeOverModes // TypeDefIndex: 12924
{
	// Fields
	public int value__; // 0x0
	public const Relay.TakeOverModes Random = 0;
	public const Relay.TakeOverModes DataCode = 1;
}

// Namespace: 
public enum Relay.TrfrResult // TypeDefIndex: 12926
{
	// Fields
	public int value__; // 0x0
	public const Relay.TrfrResult NoChanged = 0;
	public const Relay.TrfrResult Done = 1;
	public const Relay.TrfrResult Failed = 2;
}

// Namespace: 
public sealed class Relay.FlagsField : BitFieldTemplate32<Relay.Flags> // TypeDefIndex: 12928
{
	// Methods

	// RVA: 0x1F3D9B0 Offset: 0x1F3DAB1 VA: 0x1F3D9B0 Slot: 5
	protected override int ToInt(Relay.Flags value) { }

	// RVA: 0x1F3D9C0 Offset: 0x1F3DAC1 VA: 0x1F3D9C0
	public void .ctor() { }
}

// Namespace: 
private enum Relay.DisposPlayerCountsSequence.Label // TypeDefIndex: 12930
{
	// Fields
	public int value__; // 0x0
	public const Relay.DisposPlayerCountsSequence.Label Loading = 0;
	public const Relay.DisposPlayerCountsSequence.Label End = 1;
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x278830 Offset: 0x278931 VA: 0x278830
private sealed class Relay.<>c__DisplayClass42_0 // TypeDefIndex: 12932
{
	// Fields
	public int workUnitCount; // 0x10
	public List<string> pids; // 0x18
	public int workNoSortieUnitCount; // 0x20

	// Methods

	// RVA: 0x1F3CD50 Offset: 0x1F3CE51 VA: 0x1F3CD50
	public void .ctor() { }

	// RVA: 0x1F3CD60 Offset: 0x1F3CE61 VA: 0x1F3CD60
	internal void <GetPlayerUnitCount>b__0(Unit unit) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x278850 Offset: 0x278951 VA: 0x278850
private sealed class Relay.<>c__DisplayClass56_0 // TypeDefIndex: 12934
{
	// Fields
	public Dictionary<string, RelayAwardeeData> awardees; // 0x10
	public RelayAwardData.Kinds kind; // 0x18

	// Methods

	// RVA: 0x1F3CE00 Offset: 0x1F3CF01 VA: 0x1F3CE00
	public void .ctor() { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x278870 Offset: 0x278971 VA: 0x278870
private sealed class Relay.<>c__DisplayClass102_0 // TypeDefIndex: 12936
{
	// Fields
	public Relay.ChooseAwardeeData[] data; // 0x10

	// Methods

	// RVA: 0x1F3CA40 Offset: 0x1F3CB41 VA: 0x1F3CA40
	public void .ctor() { }

	// RVA: 0x1F3CA50 Offset: 0x1F3CB51 VA: 0x1F3CA50
	internal void <ChooseAwardee>b__0(Unit unit) { }
}

