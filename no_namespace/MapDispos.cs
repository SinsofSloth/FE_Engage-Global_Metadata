// Namespace: 
public class MapDispos.FlagField : BitField32 // TypeDefIndex: 11952
{
	// Methods

	// RVA: 0x1D3B590 Offset: 0x1D3B691 VA: 0x1D3B590
	public void Set(MapDispos.Flag f) { }

	// RVA: 0x1D3B5A0 Offset: 0x1D3B6A1 VA: 0x1D3B5A0
	public bool Test(MapDispos.Flag f) { }

	// RVA: 0x1D3B5B0 Offset: 0x1D3B6B1 VA: 0x1D3B5B0
	public bool Not(MapDispos.Flag f) { }

	// RVA: 0x1D3B5C0 Offset: 0x1D3B6C1 VA: 0x1D3B5C0
	public void Clear(MapDispos.Flag f) { }

	// RVA: 0x1D3B5D0 Offset: 0x1D3B6D1 VA: 0x1D3B5D0
	public void Reset(MapDispos.Flag f) { }

	// RVA: 0x1D3B5E0 Offset: 0x1D3B6E1 VA: 0x1D3B5E0
	public void .ctor() { }
}

// Namespace: 
private class MapDispos.PosList : List<MapDispos.Pos> // TypeDefIndex: 11954
{
	// Methods

	// RVA: 0x1D3B660 Offset: 0x1D3B761 VA: 0x1D3B660
	public void .ctor() { }

	// RVA: 0x1D3B6F0 Offset: 0x1D3B7F1 VA: 0x1D3B6F0
	public void Register(List<DisposData> dataList, int limit) { }

	// RVA: 0x1D38DE0 Offset: 0x1D38EE1 VA: 0x1D38DE0
	public MapDispos.Pos PopFront() { }

	// RVA: 0x1D3B820 Offset: 0x1D3B921 VA: 0x1D3B820
	public bool TryRemove(DisposData data) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x277CF0 Offset: 0x277DF1 VA: 0x277CF0
[Serializable]
private sealed class MapDispos.ActualData.<>c // TypeDefIndex: 11956
{
	// Fields
	public static readonly MapDispos.ActualData.<>c <>9; // 0x0
	public static Predicate<Unit> <>9__38_0; // 0x8

	// Methods

	// RVA: 0x21E2D60 Offset: 0x21E2E61 VA: 0x21E2D60
	private static void .cctor() { }

	// RVA: 0x21E2DD0 Offset: 0x21E2ED1 VA: 0x21E2DD0
	public void .ctor() { }

	// RVA: 0x21E2DE0 Offset: 0x21E2EE1 VA: 0x21E2DE0
	internal bool <GetUnit>b__38_0(Unit u) { }
}

// Namespace: 
private class MapDispos.ActualDataList : List<MapDispos.ActualData> // TypeDefIndex: 11958
{
	// Methods

	// RVA: 0x1D3ADB0 Offset: 0x1D3AEB1 VA: 0x1D3ADB0
	public void .ctor(List<DisposData> dataList) { }

	// RVA: 0x1D3B160 Offset: 0x1D3B261 VA: 0x1D3B160
	public void .ctor(List<DisposData> dataList, List<DisposData> positionDataList) { }

	// RVA: 0x1D3B350 Offset: 0x1D3B451 VA: 0x1D3B350
	public bool Calc(MapDispos.Flag disposFlag) { }

	// RVA: 0x1D3AFC0 Offset: 0x1D3B0C1 VA: 0x1D3AFC0
	private List<DisposData> Filter(List<DisposData> dataList) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x277D00 Offset: 0x277E01 VA: 0x277D00
private sealed class MapDispos.<>c__DisplayClass15_0 // TypeDefIndex: 11960
{
	// Fields
	public MapEditData editData; // 0x10

	// Methods

	// RVA: 0x1D38A20 Offset: 0x1D38B21 VA: 0x1D38A20
	public void .ctor() { }

	// RVA: 0x1D38A30 Offset: 0x1D38B31 VA: 0x1D38A30
	internal void <CreateFirstVersusRanked>b__0(Unit unit) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x277D20 Offset: 0x277E21 VA: 0x277D20
private sealed class MapDispos.<>c__DisplayClass20_0 // TypeDefIndex: 11962
{
	// Fields
	public Stack<MapDispos.Pos> posStack; // 0x10
	public MapEditData editData; // 0x18

	// Methods

	// RVA: 0x1D38B10 Offset: 0x1D38C11 VA: 0x1D38B10
	public void .ctor() { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x277D40 Offset: 0x277E41 VA: 0x277D40
private sealed class MapDispos.<>c__DisplayClass20_2 // TypeDefIndex: 11964
{
	// Fields
	public int count; // 0x10
	public int sortieCount; // 0x14
	public MapDispos.<>c__DisplayClass20_0 CS$<>8__locals2; // 0x18

	// Methods

	// RVA: 0x1D38BE0 Offset: 0x1D38CE1 VA: 0x1D38BE0
	public void .ctor() { }

	// RVA: 0x1D38BF0 Offset: 0x1D38CF1 VA: 0x1D38BF0
	internal void <CreateVersusEditTeam>b__4(Unit unit) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x277D60 Offset: 0x277E61 VA: 0x277D60
private sealed class MapDispos.<>c__DisplayClass37_0 // TypeDefIndex: 11966
{
	// Fields
	public int count; // 0x10

	// Methods

	// RVA: 0x1D38F60 Offset: 0x1D39061 VA: 0x1D38F60
	public void .ctor() { }

	// RVA: 0x1D38F70 Offset: 0x1D39071 VA: 0x1D38F70
	internal void <GetSortieLimit>b__0(Unit unit) { }

	// RVA: 0x1D39000 Offset: 0x1D39101 VA: 0x1D39000
	internal void <GetSortieLimit>b__1(Unit unit) { }
}

