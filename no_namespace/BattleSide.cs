// Namespace: 
public enum BattleSide.Type // TypeDefIndex: 9522
{
	// Fields
	public int value__; // 0x0
	public const BattleSide.Type None = -1;
	public const BattleSide.Type Offense = 0;
	public const BattleSide.Type Defense = 1;
	public const BattleSide.Type ChainOffense1 = 2;
	public const BattleSide.Type ChainOffense2 = 3;
	public const BattleSide.Type ChainOffense3 = 4;
	public const BattleSide.Type ChainOffense4 = 5;
	public const BattleSide.Type ChainOffense5 = 6;
	public const BattleSide.Type ChainOffense6 = 7;
	public const BattleSide.Type ChainOffense7 = 8;
	public const BattleSide.Type ChainOffense8 = 9;
	public const BattleSide.Type ChainOffense9 = 10;
	public const BattleSide.Type ChainOffense10 = 11;
	public const BattleSide.Type ChainOffense11 = 12;
	public const BattleSide.Type ChainOffense12 = 13;
	public const BattleSide.Type ChainOffense13 = 14;
	public const BattleSide.Type ChainOffense14 = 15;
	public const BattleSide.Type ChainOffense15 = 16;
	public const BattleSide.Type ChainOffense16 = 17;
	public const BattleSide.Type ChainOffense17 = 18;
	public const BattleSide.Type ChainOffense18 = 19;
	public const BattleSide.Type ChainOffense19 = 20;
	public const BattleSide.Type ChainOffense20 = 21;
	public const BattleSide.Type ChainOffense21 = 22;
	public const BattleSide.Type ChainOffense22 = 23;
	public const BattleSide.Type ChainOffense23 = 24;
	public const BattleSide.Type ChainOffense24 = 25;
	public const BattleSide.Type ChainDefense1 = 26;
	public const BattleSide.Type ChainDefense2 = 27;
	public const BattleSide.Type ChainDefense3 = 28;
	public const BattleSide.Type ChainDefense4 = 29;
}

// Namespace: 
[DefaultMemberAttribute] // RVA: 0x275DE0 Offset: 0x275EE1 VA: 0x275DE0
public class BattleSide.ContainerArray<T> // TypeDefIndex: 9524
{
	// Fields
	private T[] m_Array; // 0x0

	// Properties
	public T Item { get; set; }
	public T Item { get; set; }

	// Methods

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x250B0A0 Offset: 0x250B1A1 VA: 0x250B0A0
	|-BattleSide.ContainerArray<BattleInfoSide>..ctor
	|-BattleSide.ContainerArray<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public T get_Item(int i) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x250B150 Offset: 0x250B251 VA: 0x250B150
	|-BattleSide.ContainerArray<BattleInfoSide>.get_Item
	|-BattleSide.ContainerArray<object>.get_Item
	*/

	// RVA: -1 Offset: -1
	public void set_Item(int i, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x250B190 Offset: 0x250B291 VA: 0x250B190
	|-BattleSide.ContainerArray<BattleInfoSide>.set_Item
	|-BattleSide.ContainerArray<object>.set_Item
	*/

	// RVA: -1 Offset: -1
	public T get_Item(BattleSide.Type type) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x250B1D0 Offset: 0x250B2D1 VA: 0x250B1D0
	|-BattleSide.ContainerArray<BattleInfoSide>.get_Item
	|-BattleSide.ContainerArray<object>.get_Item
	*/

	// RVA: -1 Offset: -1
	public void set_Item(BattleSide.Type type, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x250B210 Offset: 0x250B311 VA: 0x250B210
	|-BattleSide.ContainerArray<object>.set_Item
	*/
}

// Namespace: 
public class BattleSide.IntArray : BattleSide.StructArray<int> // TypeDefIndex: 9526
{
	// Methods

	// RVA: 0x1F79330 Offset: 0x1F79431 VA: 0x1F79330
	public void .ctor() { }
}

// Namespace: 
public class BattleSide.ShortArray : BattleSide.StructArray<short> // TypeDefIndex: 9528
{
	// Methods

	// RVA: 0x1F793F0 Offset: 0x1F794F1 VA: 0x1F793F0
	public void .ctor() { }
}

