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
[DefaultMemberAttribute] // RVA: 0x275DA0 Offset: 0x275EA1 VA: 0x275DA0
public class BattleSide.StructArray<T> // TypeDefIndex: 9523
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
	|-RVA: 0x36C4DA0 Offset: 0x36C4EA1 VA: 0x36C4DA0
	|-BattleSide.StructArray<short>..ctor
	|
	|-RVA: 0x36C4F00 Offset: 0x36C5001 VA: 0x36C4F00
	|-BattleSide.StructArray<int>..ctor
	|
	|-RVA: 0x36C5060 Offset: 0x36C5161 VA: 0x36C5060
	|-BattleSide.StructArray<sbyte>..ctor
	|
	|-RVA: 0x36C51C0 Offset: 0x36C52C1 VA: 0x36C51C0
	|-BattleSide.StructArray<float>..ctor
	*/

	// RVA: -1 Offset: -1
	public T get_Item(int i) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36C4E00 Offset: 0x36C4F01 VA: 0x36C4E00
	|-BattleSide.StructArray<short>.get_Item
	|
	|-RVA: 0x36C4F60 Offset: 0x36C5061 VA: 0x36C4F60
	|-BattleSide.StructArray<int>.get_Item
	|
	|-RVA: 0x36C50C0 Offset: 0x36C51C1 VA: 0x36C50C0
	|-BattleSide.StructArray<sbyte>.get_Item
	|
	|-RVA: 0x36C5220 Offset: 0x36C5321 VA: 0x36C5220
	|-BattleSide.StructArray<float>.get_Item
	*/

	// RVA: -1 Offset: -1
	public void set_Item(int i, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36C4E40 Offset: 0x36C4F41 VA: 0x36C4E40
	|-BattleSide.StructArray<short>.set_Item
	|
	|-RVA: 0x36C4FA0 Offset: 0x36C50A1 VA: 0x36C4FA0
	|-BattleSide.StructArray<int>.set_Item
	|
	|-RVA: 0x36C5100 Offset: 0x36C5201 VA: 0x36C5100
	|-BattleSide.StructArray<sbyte>.set_Item
	|
	|-RVA: 0x36C5260 Offset: 0x36C5361 VA: 0x36C5260
	|-BattleSide.StructArray<float>.set_Item
	*/

	// RVA: -1 Offset: -1
	public T get_Item(BattleSide.Type type) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36C4E80 Offset: 0x36C4F81 VA: 0x36C4E80
	|-BattleSide.StructArray<short>.get_Item
	|
	|-RVA: 0x36C4FE0 Offset: 0x36C50E1 VA: 0x36C4FE0
	|-BattleSide.StructArray<int>.get_Item
	|
	|-RVA: 0x36C5140 Offset: 0x36C5241 VA: 0x36C5140
	|-BattleSide.StructArray<sbyte>.get_Item
	|
	|-RVA: 0x36C52A0 Offset: 0x36C53A1 VA: 0x36C52A0
	|-BattleSide.StructArray<float>.get_Item
	*/

	// RVA: -1 Offset: -1
	public void set_Item(BattleSide.Type type, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36C4EC0 Offset: 0x36C4FC1 VA: 0x36C4EC0
	|-BattleSide.StructArray<short>.set_Item
	|
	|-RVA: 0x36C5020 Offset: 0x36C5121 VA: 0x36C5020
	|-BattleSide.StructArray<int>.set_Item
	|
	|-RVA: 0x36C5180 Offset: 0x36C5281 VA: 0x36C5180
	|-BattleSide.StructArray<sbyte>.set_Item
	|
	|-RVA: 0x36C52E0 Offset: 0x36C53E1 VA: 0x36C52E0
	|-BattleSide.StructArray<float>.set_Item
	*/
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
public class BattleSide.ClassArray<T> : BattleSide.ContainerArray<T> // TypeDefIndex: 9525
{
	// Methods

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30D91C0 Offset: 0x30D92C1 VA: 0x30D91C0
	|-BattleSide.ClassArray<object>..ctor
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
public class BattleSide.FloatArray : BattleSide.StructArray<float> // TypeDefIndex: 9527
{
	// Methods

	// RVA: 0x1F792D0 Offset: 0x1F793D1 VA: 0x1F792D0
	public void .ctor() { }
}

// Namespace: 
public class BattleSide.ShortArray : BattleSide.StructArray<short> // TypeDefIndex: 9528
{
	// Methods

	// RVA: 0x1F793F0 Offset: 0x1F794F1 VA: 0x1F793F0
	public void .ctor() { }
}

// Namespace: 
public class BattleSide.SbyteArray : BattleSide.StructArray<sbyte> // TypeDefIndex: 9529
{
	// Methods

	// RVA: 0x1F79390 Offset: 0x1F79491 VA: 0x1F79390
	public void .ctor() { }
}

