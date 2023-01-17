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
private class TitleBar.TitleBarProc : ProcInst // TypeDefIndex: 13454
{
	// Methods

	// RVA: 0x2394970 Offset: 0x2394A71 VA: 0x2394970
	public void .ctor() { }
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

