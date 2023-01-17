// Namespace: 
private class HelpManager.Item // TypeDefIndex: 11812
{
	// Fields
	public HelpItemBase self; // 0x10
	public Vector2 pos; // 0x18
	public Vector2[][] dirLine; // 0x20
	public bool[] isMoveToNoTouchItem; // 0x28

	// Properties
	public float Up { get; }
	public float Down { get; }
	public float Left { get; }
	public float Right { get; }

	// Methods

	// RVA: 0x1FAA340 Offset: 0x1FAA441 VA: 0x1FAA340
	public void .ctor(HelpItemBase item) { }

	// RVA: 0x1FAA8F0 Offset: 0x1FAA9F1 VA: 0x1FAA8F0
	public float get_Up() { }

	// RVA: 0x1FAA930 Offset: 0x1FAAA31 VA: 0x1FAA930
	public float get_Down() { }

	// RVA: 0x1FAA970 Offset: 0x1FAAA71 VA: 0x1FAA970
	public float get_Left() { }

	// RVA: 0x1FAA9B0 Offset: 0x1FAAAB1 VA: 0x1FAA9B0
	public float get_Right() { }
}

// Namespace: 
public enum HelpManager.HelpItemType // TypeDefIndex: 11814
{
	// Fields
	public int value__; // 0x0
	public const HelpManager.HelpItemType None = 0;
	public const HelpManager.HelpItemType UnitName = 1;
	public const HelpManager.HelpItemType GodName = 2;
	public const HelpManager.HelpItemType BondLv = 3;
	public const HelpManager.HelpItemType JobTitle = 4;
	public const HelpManager.HelpItemType Efficacy = 5;
	public const HelpManager.HelpItemType BattleType = 6;
	public const HelpManager.HelpItemType UnitLv = 7;
	public const HelpManager.HelpItemType Move = 8;
	public const HelpManager.HelpItemType WeaponLv = 9;
	public const HelpManager.HelpItemType Parameter = 10;
	public const HelpManager.HelpItemType Hp = 11;
	public const HelpManager.HelpItemType HpStock = 12;
	public const HelpManager.HelpItemType WeaponItem = 13;
	public const HelpManager.HelpItemType GodWeaponItem = 14;
	public const HelpManager.HelpItemType Skill = 15;
	public const HelpManager.HelpItemType GodSkill = 16;
	public const HelpManager.HelpItemType TerrainInfoSkill = 17;
	public const HelpManager.HelpItemType Enchantment = 18;
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x277B20 Offset: 0x277C21 VA: 0x277B20
[Serializable]
private sealed class HelpManager.<>c // TypeDefIndex: 11816
{
	// Fields
	public static readonly HelpManager.<>c <>9; // 0x0
	public static Action<HelpManager.Item, float> <>9__12_0; // 0x8
	public static Action<HelpManager.Item, float> <>9__12_1; // 0x10
	public static Action<HelpManager.Item, float> <>9__12_2; // 0x18
	public static Action<HelpManager.Item, float> <>9__12_3; // 0x20

	// Methods

	// RVA: 0x1FA9D00 Offset: 0x1FA9E01 VA: 0x1FA9D00
	private static void .cctor() { }

	// RVA: 0x1FA9D70 Offset: 0x1FA9E71 VA: 0x1FA9D70
	public void .ctor() { }

	// RVA: 0x1FA9D80 Offset: 0x1FA9E81 VA: 0x1FA9D80
	internal void <Setup>b__12_0(HelpManager.Item item, float up) { }

	// RVA: 0x1FA9E70 Offset: 0x1FA9F71 VA: 0x1FA9E70
	internal void <Setup>b__12_1(HelpManager.Item item, float down) { }

	// RVA: 0x1FA9F70 Offset: 0x1FAA071 VA: 0x1FA9F70
	internal void <Setup>b__12_2(HelpManager.Item item, float left) { }

	// RVA: 0x1FAA060 Offset: 0x1FAA161 VA: 0x1FAA060
	internal void <Setup>b__12_3(HelpManager.Item item, float right) { }
}

