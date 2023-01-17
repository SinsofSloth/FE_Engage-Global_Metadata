// Namespace: 
[FlagsAttribute] // RVA: 0x2760A0 Offset: 0x2761A1 VA: 0x2760A0
public enum DisposData.Flags // TypeDefIndex: 9866
{
	// Fields
	public int value__; // 0x0
	public const DisposData.Flags Normal = 1;
	public const DisposData.Flags Hard = 2;
	public const DisposData.Flags Lunatic = 4;
	public const DisposData.Flags Create = 8;
	public const DisposData.Flags Leader = 16;
	public const DisposData.Flags NotMove = 32;
	public const DisposData.Flags Edge = 64;
	public const DisposData.Flags Pos = 128;
	public const DisposData.Flags Must = 256;
	public const DisposData.Flags Fix = 512;
	public const DisposData.Flags Guest = 1024;
	public const DisposData.Flags MaskSortie = 896;
	public const DisposData.Flags MaskDifficulty = 7;
}

// Namespace: 
[FlagsAttribute] // RVA: 0x2760B0 Offset: 0x2761B1 VA: 0x2760B0
public enum DisposData.AIFlags // TypeDefIndex: 9868
{
	// Fields
	public int value__; // 0x0
	public const DisposData.AIFlags NotActivateByAttacked = 1;
	public const DisposData.AIFlags Dummy = 2;
	public const DisposData.AIFlags ZeroAttack = 4;
	public const DisposData.AIFlags Heal = 8;
	public const DisposData.AIFlags Break = 16;
	public const DisposData.AIFlags Chain = 32;
	public const DisposData.AIFlags EquipShortAfterLongRange = 64;
	public const DisposData.AIFlags MoveBreak = 128;
	public const DisposData.AIFlags EngageAttackOnce = 256;
}

// Namespace: 
public enum DisposData.State // TypeDefIndex: 9870
{
	// Fields
	public int value__; // 0x0
	public const DisposData.State Normal = 0;
	public const DisposData.State Rampage = 1;
	public const DisposData.State Keep = -1;
}

// Namespace: 
public class DisposData.Item // TypeDefIndex: 9872
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x289C30 Offset: 0x289D31 VA: 0x289C30
	private string <Iid>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x289C40 Offset: 0x289D41 VA: 0x289C40
	private int <Drop>k__BackingField; // 0x18

	// Properties
	public string Iid { get; set; }
	public int Drop { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2B56F0 Offset: 0x2B57F1 VA: 0x2B56F0
	// RVA: 0x1EFFF40 Offset: 0x1F00041 VA: 0x1EFFF40
	public string get_Iid() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B5700 Offset: 0x2B5801 VA: 0x2B5700
	// RVA: 0x1EFFF50 Offset: 0x1F00051 VA: 0x1EFFF50
	private void set_Iid(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B5710 Offset: 0x2B5811 VA: 0x2B5710
	// RVA: 0x1EFFF60 Offset: 0x1F00061 VA: 0x1EFFF60
	public int get_Drop() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B5720 Offset: 0x2B5821 VA: 0x2B5720
	// RVA: 0x1EFFF70 Offset: 0x1F00071 VA: 0x1EFFF70
	private void set_Drop(int value) { }

	// RVA: 0x1EFFF80 Offset: 0x1F00081 VA: 0x1EFFF80
	public void .ctor() { }
}

