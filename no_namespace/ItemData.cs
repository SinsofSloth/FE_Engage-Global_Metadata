// Namespace: 
public enum ItemData.Kinds // TypeDefIndex: 9948
{
	// Fields
	public int value__; // 0x0
	public const ItemData.Kinds None = 0;
	public const ItemData.Kinds Sword = 1;
	public const ItemData.Kinds Lance = 2;
	public const ItemData.Kinds Axe = 3;
	public const ItemData.Kinds Bow = 4;
	public const ItemData.Kinds Dagger = 5;
	public const ItemData.Kinds Magic = 6;
	public const ItemData.Kinds Rod = 7;
	public const ItemData.Kinds Fist = 8;
	public const ItemData.Kinds Special = 9;
	public const ItemData.Kinds Tool = 10;
	public const ItemData.Kinds Shield = 11;
	public const ItemData.Kinds Accessory = 12;
	public const ItemData.Kinds Precious = 13;
	public const ItemData.Kinds RefineIron = 14;
	public const ItemData.Kinds RefineSteel = 15;
	public const ItemData.Kinds RefineSilver = 16;
	public const ItemData.Kinds PieceOfBond = 17;
	public const ItemData.Kinds Gold = 18;
	public const ItemData.Kinds Num = 19;
	public const ItemData.Kinds WeaponNum = 10;
}

// Namespace: 
public enum ItemData.Attrs // TypeDefIndex: 9949
{
	// Fields
	public int value__; // 0x0
	public const ItemData.Attrs None = 0;
	public const ItemData.Attrs Physical = 1;
	public const ItemData.Attrs Magic = 2;
}

// Namespace: 
public enum ItemData.WeaponAttrs // TypeDefIndex: 9950
{
	// Fields
	public int value__; // 0x0
	public const ItemData.WeaponAttrs None = 0;
	public const ItemData.WeaponAttrs Fire = 1;
	public const ItemData.WeaponAttrs Thunder = 2;
	public const ItemData.WeaponAttrs Wind = 3;
	public const ItemData.WeaponAttrs Ice = 4;
	public const ItemData.WeaponAttrs Light = 5;
	public const ItemData.WeaponAttrs Dark = 6;
}

// Namespace: 
[FlagsAttribute] // RVA: 0x276260 Offset: 0x276361 VA: 0x276260
public enum ItemData.Flags // TypeDefIndex: 9951
{
	// Fields
	public int value__; // 0x0
	public const ItemData.Flags Rarity = 1;
	public const ItemData.Flags NotTrade = 2;
	public const ItemData.Flags CanUse = 4;
	public const ItemData.Flags OnlyChapter = 8;
	public const ItemData.Flags OnlyEnemy = 16;
	public const ItemData.Flags OnlyMale = 32;
	public const ItemData.Flags OnlyFemale = 64;
	public const ItemData.Flags Engage = 128;
	public const ItemData.Flags IgnoreWeaponLevel = 256;
	public const ItemData.Flags Unpublic = 512;
	public const ItemData.Flags NotEntrust = 1024;
	public const ItemData.Flags InvertInteract = 2048;
	public const ItemData.Flags Download = 4096;
	public const ItemData.Flags KeyDoor = 8192;
	public const ItemData.Flags KeyTreasureBox = 16384;
	public const ItemData.Flags AIUnequipable = 32768;
	public const ItemData.Flags ReverseAttribute = 65536;
	public const ItemData.Flags LunchBox = 131072;
	public const ItemData.Flags SimpleHelp = 262144;
	public const ItemData.Flags RangeTarget = 524288;
	public const ItemData.Flags IgnoreCombat = 1048576;
	public const ItemData.Flags ForcedCombat = 2097152;
	public const ItemData.Flags Bless = 16777216;
	public const ItemData.Flags Breath = 33554432;
	public const ItemData.Flags Dragon = 67108864;
	public const ItemData.Flags Bullet = 134217728;
}

// Namespace: 
public sealed class ItemData.FlagField : BitFieldTemplate32<ItemData.Flags> // TypeDefIndex: 9952
{
	// Methods

	// RVA: 0x22288C0 Offset: 0x22289C1 VA: 0x22288C0
	public void .ctor(int f) { }

	// RVA: 0x2228920 Offset: 0x2228A21 VA: 0x2228920
	public void .ctor(ItemData.Flags f) { }

	// RVA: 0x2228980 Offset: 0x2228A81 VA: 0x2228980 Slot: 5
	protected override int ToInt(ItemData.Flags value) { }
}

// Namespace: 
public enum ItemData.UseTypes // TypeDefIndex: 9953
{
	// Fields
	public int value__; // 0x0
	public const ItemData.UseTypes None = 0;
	public const ItemData.UseTypes Attack = 1;
	public const ItemData.UseTypes Heal = 2;
	public const ItemData.UseTypes RestHeal = 3;
	public const ItemData.UseTypes Revive = 4;
	public const ItemData.UseTypes Warp = 5;
	public const ItemData.UseTypes Rescue = 6;
	public const ItemData.UseTypes EngageAdd = 7;
	public const ItemData.UseTypes Rewarp = 8;
	public const ItemData.UseTypes Freeze = 9;
	public const ItemData.UseTypes Sleep = 10;
	public const ItemData.UseTypes Silence = 11;
	public const ItemData.UseTypes Charm = 12;
	public const ItemData.UseTypes Berserk = 13;
	public const ItemData.UseTypes Weakness = 14;
	public const ItemData.UseTypes Again = 15;
	public const ItemData.UseTypes Torch = 16;
	public const ItemData.UseTypes Food = 17;
	public const ItemData.UseTypes Rest = 18;
	public const ItemData.UseTypes SightUp = 19;
	public const ItemData.UseTypes WeaponLevelUp = 20;
	public const ItemData.UseTypes GrowUp = 21;
	public const ItemData.UseTypes Enhance = 22;
	public const ItemData.UseTypes CCMaster = 23;
	public const ItemData.UseTypes CCChange = 24;
	public const ItemData.UseTypes CCExtra = 25;
	public const ItemData.UseTypes Creation = 26;
	public const ItemData.UseTypes Draw = 27;
	public const ItemData.UseTypes GainExp = 28;
	public const ItemData.UseTypes Stun = 29;
	public const ItemData.UseTypes Detox = 30;
	public const ItemData.UseTypes GiveSkill = 31;
	public const ItemData.UseTypes Foodstuff = 32;
	public const ItemData.UseTypes Gift = 33;
	public const ItemData.UseTypes Material = 34;
	public const ItemData.UseTypes FishingRod = 35;
	public const ItemData.UseTypes Bless = 36;
	public const ItemData.UseTypes BlessRest = 37;
	public const ItemData.UseTypes BlessPlus = 38;
	public const ItemData.UseTypes BlessRestPlus = 39;
	public const ItemData.UseTypes CCEnchant = 40;
	public const ItemData.UseTypes CCGunner = 41;
	public const ItemData.UseTypes GainSkillPoint = 42;
}

// Namespace: 
public enum ItemData.RodTypes // TypeDefIndex: 9954
{
	// Fields
	public int value__; // 0x0
	public const ItemData.RodTypes None = 0;
	public const ItemData.RodTypes Basic = 1;
	public const ItemData.RodTypes Heal = 2;
	public const ItemData.RodTypes Interference = 3;
}

// Namespace: 
public enum ItemData.AddTargets // TypeDefIndex: 9955
{
	// Fields
	public int value__; // 0x0
	public const ItemData.AddTargets None = 0;
	public const ItemData.AddTargets Self = 1;
	public const ItemData.AddTargets Around = 2;
	public const ItemData.AddTargets Whole = 3;
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x276270 Offset: 0x276371 VA: 0x276270
[Serializable]
private sealed class ItemData.<>c // TypeDefIndex: 9956
{
	// Fields
	public static readonly ItemData.<>c <>9; // 0x0
	public static Func<string, string> <>9__294_0; // 0x8

	// Methods

	// RVA: 0x22287A0 Offset: 0x22288A1 VA: 0x22287A0
	private static void .cctor() { }

	// RVA: 0x2228810 Offset: 0x2228911 VA: 0x2228810
	public void .ctor() { }

	// RVA: 0x2228820 Offset: 0x2228921 VA: 0x2228820
	internal string <ReplaceHighRank>b__294_0(string iid) { }
}

