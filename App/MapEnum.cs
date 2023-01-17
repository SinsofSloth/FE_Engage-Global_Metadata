// Namespace: App
public class MapEnum // TypeDefIndex: 12005
{
	// Fields
	private static readonly MapEnum.AreaEnumerator s_AreaEnumerator; // 0x0
	private static readonly MapEnum.RangeEnumerator s_RangeEnumerator; // 0x18
	private static readonly MapEnum.MoveEnumerator s_MoveEnumerator; // 0x44
	private static readonly MapEnum.CellEnumerator s_CellEnumerator; // 0x60

	// Methods

	// RVA: 0x21BE400 Offset: 0x21BE501 VA: 0x21BE400
	public static MapEnum.AreaEnumerator GetFull() { }

	// RVA: 0x21BE520 Offset: 0x21BE621 VA: 0x21BE520
	public static MapEnum.AreaEnumerator GetPlayArea() { }

	// RVA: 0x21BE660 Offset: 0x21BE761 VA: 0x21BE660
	public static MapEnum.AreaEnumerator GetArea(int x, int z, int w, int h) { }

	// RVA: 0x21BE740 Offset: 0x21BE841 VA: 0x21BE740
	public static MapEnum.RangeEnumerator GetRange(int x, int z, int range) { }

	// RVA: 0x21BE8D0 Offset: 0x21BE9D1 VA: 0x21BE8D0
	public static MapEnum.RangeEnumerator GetRange(int x, int z, int near, int far) { }

	// RVA: 0x21BEA60 Offset: 0x21BEB61 VA: 0x21BEA60
	public static MapEnum.RangeEnumerator GetAround(int x, int z) { }

	// RVA: 0x21BEBE0 Offset: 0x21BECE1 VA: 0x21BEBE0
	public static MapEnum.MoveEnumerator GetMove() { }

	// RVA: 0x21BECD0 Offset: 0x21BEDD1 VA: 0x21BECD0
	public static MapEnum.CellEnumerator GetCell(Unit unit) { }

	// RVA: 0x21BED50 Offset: 0x21BEE51 VA: 0x21BED50
	public static MapEnum.CellEnumerator GetCell(Unit unit, int x, int z) { }

	// RVA: 0x21BEDD0 Offset: 0x21BEED1 VA: 0x21BEDD0
	public void .ctor() { }
}

