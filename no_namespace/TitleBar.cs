// Namespace: 
[Serializable]
public class TitleBar.Title // TypeDefIndex: 13449
{
	// Fields
	public GameObject Root; // 0x10
	public Animator Animator; // 0x18
	public TextMeshProUGUI TitleText; // 0x20
	public TextMeshProUGUI HelpText; // 0x28
	public GameObject UnitObj; // 0x30
	public TextMeshProUGUI UnitValue; // 0x38
	public TextMeshProUGUI UnitMaxValue; // 0x40
	public KeyHelpTitleBarController KeyHelp; // 0x48

	// Methods

	// RVA: 0x2394960 Offset: 0x2394A61 VA: 0x2394960
	public void .ctor() { }
}

// Namespace: 
[Serializable]
public class TitleBar.Values // TypeDefIndex: 13450
{
	// Fields
	public GameObject Root; // 0x10
	public Animator Animator; // 0x18
	public List<GameObject> MaterialObjList; // 0x20
	public GameObject PieceOfBondObject; // 0x28
	public TextMeshProUGUI PieceOfBondValue; // 0x30
	public GameObject MoneyObject; // 0x38
	public TextMeshProUGUI MoneyValue; // 0x40

	// Methods

	// RVA: 0x2394980 Offset: 0x2394A81 VA: 0x2394980
	public void .ctor() { }
}

// Namespace: 
public enum TitleBar.FooterType // TypeDefIndex: 13451
{
	// Fields
	public int value__; // 0x0
	public const TitleBar.FooterType Gold = 1;
	public const TitleBar.FooterType PieceOfBond = 2;
	public const TitleBar.FooterType Refine = 4;
	public const TitleBar.FooterType RefineGod = 8;
	public const TitleBar.FooterType Proof = 16;
	public const TitleBar.FooterType RelayTicket = 32;
	public const TitleBar.FooterType None = 0;
	public const TitleBar.FooterType GoldAndBond = 3;
	public const TitleBar.FooterType GoldAndRefine = 5;
	public const TitleBar.FooterType GoldAndBondAndRefine = 7;
	public const TitleBar.FooterType GoldAndBondAndRelayTicket = 35;
}

// Namespace: 
private enum TitleBar.AnimType // TypeDefIndex: 13452
{
	// Fields
	public int value__; // 0x0
	public const TitleBar.AnimType None = 0;
	public const TitleBar.AnimType Open = 1;
	public const TitleBar.AnimType Close = 2;
	public const TitleBar.AnimType Invalid = 3;
}

// Namespace: 
public class TitleBar.Num // TypeDefIndex: 13453
{
	// Fields
	public int Gold; // 0x10
	public int PieceOfBond; // 0x14
	public int RefineSilver; // 0x18
	public int RefineSteel; // 0x1C
	public int RefineIron; // 0x20
	public int[] RefineGodList; // 0x28
	public int ProofMaster; // 0x30
	public int ProofChange; // 0x34
	public int ProofEnchant; // 0x38
	public int ProofGunner; // 0x3C
	public int RelayTicket; // 0x40

	// Methods

	// RVA: 0x2394270 Offset: 0x2394371 VA: 0x2394270
	public void Clear() { }

	// RVA: 0x23943C0 Offset: 0x23944C1 VA: 0x23943C0
	public void SetValue(TitleBar.Num value) { }

	// RVA: 0x2394680 Offset: 0x2394781 VA: 0x2394680
	public void SetValueCurrent() { }

	// RVA: 0x23948F0 Offset: 0x23949F1 VA: 0x23948F0
	public void .ctor() { }
}

// Namespace: 
private class TitleBar.TitleBarProc : ProcInst // TypeDefIndex: 13454
{
	// Methods

	// RVA: 0x2394970 Offset: 0x2394A71 VA: 0x2394970
	public void .ctor() { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x278D00 Offset: 0x278E01 VA: 0x278D00
[Serializable]
private sealed class TitleBar.<>c // TypeDefIndex: 13455
{
	// Fields
	public static readonly TitleBar.<>c <>9; // 0x0
	public static Predicate<ValueCountController> <>9__50_0; // 0x8
	public static Predicate<ValueCountController> <>9__69_0; // 0x10

	// Methods

	// RVA: 0x2393C80 Offset: 0x2393D81 VA: 0x2393C80
	private static void .cctor() { }

	// RVA: 0x2393CF0 Offset: 0x2393DF1 VA: 0x2393CF0
	public void .ctor() { }

	// RVA: 0x2393D00 Offset: 0x2393E01 VA: 0x2393D00
	internal bool <OpenFooter>b__50_0(ValueCountController item) { }

	// RVA: 0x2393D70 Offset: 0x2393E71 VA: 0x2393D70
	internal bool <SetFooterCountValue>b__69_0(ValueCountController item) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x278D10 Offset: 0x278E11 VA: 0x278D10
private sealed class TitleBar.<>c__DisplayClass54_0 // TypeDefIndex: 13456
{
	// Fields
	public int num; // 0x10
	public int maxNum; // 0x14

	// Methods

	// RVA: 0x2393DE0 Offset: 0x2393EE1 VA: 0x2393DE0
	public void .ctor() { }

	// RVA: 0x2393DF0 Offset: 0x2393EF1 VA: 0x2393DF0
	internal void <SetUnitNum>b__0(TitleBar.Title title) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x278D20 Offset: 0x278E21 VA: 0x278D20
private sealed class TitleBar.<>c__DisplayClass67_0 // TypeDefIndex: 13457
{
	// Fields
	public TitleBar <>4__this; // 0x10
	public TitleBar.Values values; // 0x18
	public int index; // 0x20

	// Methods

	// RVA: 0x2393F80 Offset: 0x2394081 VA: 0x2393F80
	public void .ctor() { }

	// RVA: 0x2393F90 Offset: 0x2394091 VA: 0x2393F90
	internal void <InitFooterValue>b__0(ItemData data) { }

	// RVA: 0x2393FF0 Offset: 0x23940F1 VA: 0x2393FF0
	internal void <InitFooterValue>b__1(ItemRefineExchangeData data) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x278D30 Offset: 0x278E31 VA: 0x278D30
private sealed class TitleBar.<>c__DisplayClass69_0 // TypeDefIndex: 13458
{
	// Fields
	public TitleBar <>4__this; // 0x10
	public int frame; // 0x18

	// Methods

	// RVA: 0x23940C0 Offset: 0x23941C1 VA: 0x23940C0
	public void .ctor() { }

	// RVA: 0x23940D0 Offset: 0x23941D1 VA: 0x23940D0
	internal void <SetFooterCountValue>b__1(GameObject root, int diff) { }

	// RVA: 0x2394210 Offset: 0x2394311 VA: 0x2394210
	internal int <SetFooterCountValue>b__2(int diff) { }
}

