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

