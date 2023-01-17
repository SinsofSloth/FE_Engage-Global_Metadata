// Namespace: 
[FlagsAttribute] // RVA: 0x2778D0 Offset: 0x2779D1 VA: 0x2778D0
public enum PhotographDisposInfo.Flags // TypeDefIndex: 11469
{
	// Fields
	public int value__; // 0x0
	public const PhotographDisposInfo.Flags Training = 1;
	public const PhotographDisposInfo.Flags PoolSide = 2;
	public const PhotographDisposInfo.Flags InPool = 4;
	public const PhotographDisposInfo.Flags CanDisposGod = 8;
	public const PhotographDisposInfo.Flags Mascot = 16;
	public const PhotographDisposInfo.Flags Sitting = 32;
}

// Namespace: 
public class PhotographDisposInfo.FlagField : BitFieldTemplate32<PhotographDisposInfo.Flags> // TypeDefIndex: 11470
{
	// Methods

	// RVA: 0x1F1D480 Offset: 0x1F1D581 VA: 0x1F1D480 Slot: 5
	protected override int ToInt(PhotographDisposInfo.Flags value) { }

	// RVA: 0x1F1D490 Offset: 0x1F1D591 VA: 0x1F1D490
	public void .ctor() { }
}

// Namespace: 
public enum PhotographDisposInfo.CharacterType // TypeDefIndex: 11471
{
	// Fields
	public int value__; // 0x0
	public const PhotographDisposInfo.CharacterType None = 0;
	public const PhotographDisposInfo.CharacterType UnitM = 1;
	public const PhotographDisposInfo.CharacterType UnitF = 2;
	public const PhotographDisposInfo.CharacterType GodM = 3;
	public const PhotographDisposInfo.CharacterType GodF = 4;
	public const PhotographDisposInfo.CharacterType Mascot = 5;
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x2778E0 Offset: 0x2779E1 VA: 0x2778E0
private sealed class PhotographDisposInfo.<>c__DisplayClass77_0 // TypeDefIndex: 11472
{
	// Fields
	public PhotographDisposInfo <>4__this; // 0x10
	public string characterId; // 0x18
	public AccessoryData bodyAcc; // 0x20
	public AccessoryData faceAcc; // 0x28
	public Character characterCmp; // 0x30

	// Methods

	// RVA: 0x1F1C9A0 Offset: 0x1F1CAA1 VA: 0x1F1C9A0
	public void .ctor() { }

	// RVA: 0x1F1C9B0 Offset: 0x1F1CAB1 VA: 0x1F1C9B0
	internal void <SetUpCharacter>b__0() { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x2778F0 Offset: 0x2779F1 VA: 0x2778F0
private sealed class PhotographDisposInfo.<>c__DisplayClass79_0 // TypeDefIndex: 11473
{
	// Fields
	public PhotographDisposInfo <>4__this; // 0x10
	public ItemData.Kinds kind; // 0x18

	// Methods

	// RVA: 0x1F1D180 Offset: 0x1F1D281 VA: 0x1F1D180
	public void .ctor() { }

	// RVA: 0x1F1D190 Offset: 0x1F1D291 VA: 0x1F1D190
	internal void <InitCharacter>b__0(Unit unit) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x277900 Offset: 0x277A01 VA: 0x277900
[Serializable]
private sealed class PhotographDisposInfo.<>c // TypeDefIndex: 11474
{
	// Fields
	public static readonly PhotographDisposInfo.<>c <>9; // 0x0
	public static Comparison<ItemData> <>9__79_1; // 0x8

	// Methods

	// RVA: 0x1F1C910 Offset: 0x1F1CA11 VA: 0x1F1C910
	private static void .cctor() { }

	// RVA: 0x1F1C980 Offset: 0x1F1CA81 VA: 0x1F1C980
	public void .ctor() { }

	// RVA: 0x1F1C990 Offset: 0x1F1CA91 VA: 0x1F1C990
	internal int <InitCharacter>b__79_1(ItemData a, ItemData b) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x277910 Offset: 0x277A11 VA: 0x277910
private sealed class PhotographDisposInfo.<>c__DisplayClass84_0 // TypeDefIndex: 11475
{
	// Fields
	public PhotographDisposInfo <>4__this; // 0x10
	public ItemData holdWeaponData; // 0x18
	public string path; // 0x20

	// Methods

	// RVA: 0x1F1D350 Offset: 0x1F1D451 VA: 0x1F1D350
	public void .ctor() { }

	// RVA: 0x1F1D360 Offset: 0x1F1D461 VA: 0x1F1D360
	internal void <SetupWeapon>b__0(GameObject obj) { }
}

