// Namespace: 
[Serializable]
internal sealed class SortedSet.Node<T> // TypeDefIndex: 2434
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x31610 Offset: 0x31711 VA: 0x31610
	private T <Item>k__BackingField; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x31620 Offset: 0x31721 VA: 0x31620
	private SortedSet.Node<T> <Left>k__BackingField; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x31630 Offset: 0x31731 VA: 0x31630
	private SortedSet.Node<T> <Right>k__BackingField; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x31640 Offset: 0x31741 VA: 0x31640
	private NodeColor <Color>k__BackingField; // 0x0

	// Properties
	public T Item { get; set; }
	public SortedSet.Node<T> Left { get; set; }
	public SortedSet.Node<T> Right { get; set; }
	public NodeColor Color { get; set; }
	public bool IsBlack { get; }
	public bool IsRed { get; }
	public bool Is2Node { get; }
	public bool Is4Node { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(T item, NodeColor color) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x31A5290 Offset: 0x31A5391 VA: 0x31A5290
	|-SortedSet.Node<KeyValuePair<int, bool>>..ctor
	|
	|-RVA: 0x31A5D50 Offset: 0x31A5E51 VA: 0x31A5D50
	|-SortedSet.Node<KeyValuePair<int, int>>..ctor
	|
	|-RVA: 0x31A6810 Offset: 0x31A6911 VA: 0x31A6810
	|-SortedSet.Node<KeyValuePair<object, object>>..ctor
	|
	|-RVA: 0x31A7320 Offset: 0x31A7421 VA: 0x31A7320
	|-SortedSet.Node<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public static bool IsNonNullRed(SortedSet.Node<T> node) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x31A5300 Offset: 0x31A5401 VA: 0x31A5300
	|-SortedSet.Node<KeyValuePair<int, bool>>.IsNonNullRed
	|
	|-RVA: 0x31A5DC0 Offset: 0x31A5EC1 VA: 0x31A5DC0
	|-SortedSet.Node<KeyValuePair<int, int>>.IsNonNullRed
	|
	|-RVA: 0x31A6890 Offset: 0x31A6991 VA: 0x31A6890
	|-SortedSet.Node<KeyValuePair<object, object>>.IsNonNullRed
	|
	|-RVA: 0x31A7390 Offset: 0x31A7491 VA: 0x31A7390
	|-SortedSet.Node<object>.IsNonNullRed
	*/

	// RVA: -1 Offset: -1
	public static bool IsNullOrBlack(SortedSet.Node<T> node) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x31A5390 Offset: 0x31A5491 VA: 0x31A5390
	|-SortedSet.Node<KeyValuePair<int, bool>>.IsNullOrBlack
	|
	|-RVA: 0x31A5E50 Offset: 0x31A5F51 VA: 0x31A5E50
	|-SortedSet.Node<KeyValuePair<int, int>>.IsNullOrBlack
	|
	|-RVA: 0x31A6920 Offset: 0x31A6A21 VA: 0x31A6920
	|-SortedSet.Node<KeyValuePair<object, object>>.IsNullOrBlack
	|
	|-RVA: 0x31A7420 Offset: 0x31A7521 VA: 0x31A7420
	|-SortedSet.Node<object>.IsNullOrBlack
	*/

	[CompilerGeneratedAttribute] // RVA: 0x32330 Offset: 0x32431 VA: 0x32330
	// RVA: -1 Offset: -1
	public T get_Item() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x31A5420 Offset: 0x31A5521 VA: 0x31A5420
	|-SortedSet.Node<KeyValuePair<int, bool>>.get_Item
	|
	|-RVA: 0x31A5EE0 Offset: 0x31A5FE1 VA: 0x31A5EE0
	|-SortedSet.Node<KeyValuePair<int, int>>.get_Item
	|
	|-RVA: 0x31A69B0 Offset: 0x31A6AB1 VA: 0x31A69B0
	|-SortedSet.Node<KeyValuePair<object, object>>.get_Item
	|
	|-RVA: 0x31A74B0 Offset: 0x31A75B1 VA: 0x31A74B0
	|-SortedSet.Node<object>.get_Item
	*/

	[CompilerGeneratedAttribute] // RVA: 0x32340 Offset: 0x32441 VA: 0x32340
	// RVA: -1 Offset: -1
	public void set_Item(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x31A5430 Offset: 0x31A5531 VA: 0x31A5430
	|-SortedSet.Node<KeyValuePair<int, bool>>.set_Item
	|
	|-RVA: 0x31A5EF0 Offset: 0x31A5FF1 VA: 0x31A5EF0
	|-SortedSet.Node<KeyValuePair<int, int>>.set_Item
	|
	|-RVA: 0x31A69C0 Offset: 0x31A6AC1 VA: 0x31A69C0
	|-SortedSet.Node<KeyValuePair<object, object>>.set_Item
	|
	|-RVA: 0x31A74C0 Offset: 0x31A75C1 VA: 0x31A74C0
	|-SortedSet.Node<object>.set_Item
	*/

	[CompilerGeneratedAttribute] // RVA: 0x32350 Offset: 0x32451 VA: 0x32350
	// RVA: -1 Offset: -1
	public SortedSet.Node<T> get_Left() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x31A5440 Offset: 0x31A5541 VA: 0x31A5440
	|-SortedSet.Node<KeyValuePair<int, bool>>.get_Left
	|
	|-RVA: 0x31A5F00 Offset: 0x31A6001 VA: 0x31A5F00
	|-SortedSet.Node<KeyValuePair<int, int>>.get_Left
	|
	|-RVA: 0x31A69D0 Offset: 0x31A6AD1 VA: 0x31A69D0
	|-SortedSet.Node<KeyValuePair<object, object>>.get_Left
	|
	|-RVA: 0x31A74D0 Offset: 0x31A75D1 VA: 0x31A74D0
	|-SortedSet.Node<object>.get_Left
	*/

	[CompilerGeneratedAttribute] // RVA: 0x32360 Offset: 0x32461 VA: 0x32360
	// RVA: -1 Offset: -1
	public void set_Left(SortedSet.Node<T> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x31A5450 Offset: 0x31A5551 VA: 0x31A5450
	|-SortedSet.Node<KeyValuePair<int, bool>>.set_Left
	|
	|-RVA: 0x31A5F10 Offset: 0x31A6011 VA: 0x31A5F10
	|-SortedSet.Node<KeyValuePair<int, int>>.set_Left
	|
	|-RVA: 0x31A69E0 Offset: 0x31A6AE1 VA: 0x31A69E0
	|-SortedSet.Node<KeyValuePair<object, object>>.set_Left
	|
	|-RVA: 0x31A74E0 Offset: 0x31A75E1 VA: 0x31A74E0
	|-SortedSet.Node<object>.set_Left
	*/

	[CompilerGeneratedAttribute] // RVA: 0x32370 Offset: 0x32471 VA: 0x32370
	// RVA: -1 Offset: -1
	public SortedSet.Node<T> get_Right() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x31A5460 Offset: 0x31A5561 VA: 0x31A5460
	|-SortedSet.Node<KeyValuePair<int, bool>>.get_Right
	|
	|-RVA: 0x31A5F20 Offset: 0x31A6021 VA: 0x31A5F20
	|-SortedSet.Node<KeyValuePair<int, int>>.get_Right
	|
	|-RVA: 0x31A69F0 Offset: 0x31A6AF1 VA: 0x31A69F0
	|-SortedSet.Node<KeyValuePair<object, object>>.get_Right
	|
	|-RVA: 0x31A74F0 Offset: 0x31A75F1 VA: 0x31A74F0
	|-SortedSet.Node<object>.get_Right
	*/

	[CompilerGeneratedAttribute] // RVA: 0x32380 Offset: 0x32481 VA: 0x32380
	// RVA: -1 Offset: -1
	public void set_Right(SortedSet.Node<T> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x31A5470 Offset: 0x31A5571 VA: 0x31A5470
	|-SortedSet.Node<KeyValuePair<int, bool>>.set_Right
	|
	|-RVA: 0x31A5F30 Offset: 0x31A6031 VA: 0x31A5F30
	|-SortedSet.Node<KeyValuePair<int, int>>.set_Right
	|
	|-RVA: 0x31A6A00 Offset: 0x31A6B01 VA: 0x31A6A00
	|-SortedSet.Node<KeyValuePair<object, object>>.set_Right
	|
	|-RVA: 0x31A7500 Offset: 0x31A7601 VA: 0x31A7500
	|-SortedSet.Node<object>.set_Right
	*/

	[CompilerGeneratedAttribute] // RVA: 0x32390 Offset: 0x32491 VA: 0x32390
	// RVA: -1 Offset: -1
	public NodeColor get_Color() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x31A5480 Offset: 0x31A5581 VA: 0x31A5480
	|-SortedSet.Node<KeyValuePair<int, bool>>.get_Color
	|
	|-RVA: 0x31A5F40 Offset: 0x31A6041 VA: 0x31A5F40
	|-SortedSet.Node<KeyValuePair<int, int>>.get_Color
	|
	|-RVA: 0x31A6A10 Offset: 0x31A6B11 VA: 0x31A6A10
	|-SortedSet.Node<KeyValuePair<object, object>>.get_Color
	|
	|-RVA: 0x31A7510 Offset: 0x31A7611 VA: 0x31A7510
	|-SortedSet.Node<object>.get_Color
	*/

	[CompilerGeneratedAttribute] // RVA: 0x323A0 Offset: 0x324A1 VA: 0x323A0
	// RVA: -1 Offset: -1
	public void set_Color(NodeColor value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x31A5490 Offset: 0x31A5591 VA: 0x31A5490
	|-SortedSet.Node<KeyValuePair<int, bool>>.set_Color
	|
	|-RVA: 0x31A5F50 Offset: 0x31A6051 VA: 0x31A5F50
	|-SortedSet.Node<KeyValuePair<int, int>>.set_Color
	|
	|-RVA: 0x31A6A20 Offset: 0x31A6B21 VA: 0x31A6A20
	|-SortedSet.Node<KeyValuePair<object, object>>.set_Color
	|
	|-RVA: 0x31A7520 Offset: 0x31A7621 VA: 0x31A7520
	|-SortedSet.Node<object>.set_Color
	*/

	// RVA: -1 Offset: -1
	public bool get_IsBlack() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x31A54A0 Offset: 0x31A55A1 VA: 0x31A54A0
	|-SortedSet.Node<KeyValuePair<int, bool>>.get_IsBlack
	|
	|-RVA: 0x31A5F60 Offset: 0x31A6061 VA: 0x31A5F60
	|-SortedSet.Node<KeyValuePair<int, int>>.get_IsBlack
	|
	|-RVA: 0x31A6A30 Offset: 0x31A6B31 VA: 0x31A6A30
	|-SortedSet.Node<KeyValuePair<object, object>>.get_IsBlack
	|
	|-RVA: 0x31A7530 Offset: 0x31A7631 VA: 0x31A7530
	|-SortedSet.Node<object>.get_IsBlack
	*/

	// RVA: -1 Offset: -1
	public bool get_IsRed() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x31A54D0 Offset: 0x31A55D1 VA: 0x31A54D0
	|-SortedSet.Node<KeyValuePair<int, bool>>.get_IsRed
	|
	|-RVA: 0x31A5F90 Offset: 0x31A6091 VA: 0x31A5F90
	|-SortedSet.Node<KeyValuePair<int, int>>.get_IsRed
	|
	|-RVA: 0x31A6A60 Offset: 0x31A6B61 VA: 0x31A6A60
	|-SortedSet.Node<KeyValuePair<object, object>>.get_IsRed
	|
	|-RVA: 0x31A7560 Offset: 0x31A7661 VA: 0x31A7560
	|-SortedSet.Node<object>.get_IsRed
	*/

	// RVA: -1 Offset: -1
	public bool get_Is2Node() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x31A5500 Offset: 0x31A5601 VA: 0x31A5500
	|-SortedSet.Node<KeyValuePair<int, bool>>.get_Is2Node
	|
	|-RVA: 0x31A5FC0 Offset: 0x31A60C1 VA: 0x31A5FC0
	|-SortedSet.Node<KeyValuePair<int, int>>.get_Is2Node
	|
	|-RVA: 0x31A6A90 Offset: 0x31A6B91 VA: 0x31A6A90
	|-SortedSet.Node<KeyValuePair<object, object>>.get_Is2Node
	|
	|-RVA: 0x31A7590 Offset: 0x31A7691 VA: 0x31A7590
	|-SortedSet.Node<object>.get_Is2Node
	*/

	// RVA: -1 Offset: -1
	public bool get_Is4Node() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x31A55A0 Offset: 0x31A56A1 VA: 0x31A55A0
	|-SortedSet.Node<KeyValuePair<int, bool>>.get_Is4Node
	|
	|-RVA: 0x31A6060 Offset: 0x31A6161 VA: 0x31A6060
	|-SortedSet.Node<KeyValuePair<int, int>>.get_Is4Node
	|
	|-RVA: 0x31A6B30 Offset: 0x31A6C31 VA: 0x31A6B30
	|-SortedSet.Node<KeyValuePair<object, object>>.get_Is4Node
	|
	|-RVA: 0x31A7630 Offset: 0x31A7731 VA: 0x31A7630
	|-SortedSet.Node<object>.get_Is4Node
	*/

	// RVA: -1 Offset: -1
	public void ColorBlack() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x31A5630 Offset: 0x31A5731 VA: 0x31A5630
	|-SortedSet.Node<KeyValuePair<int, bool>>.ColorBlack
	|
	|-RVA: 0x31A60F0 Offset: 0x31A61F1 VA: 0x31A60F0
	|-SortedSet.Node<KeyValuePair<int, int>>.ColorBlack
	|
	|-RVA: 0x31A6BC0 Offset: 0x31A6CC1 VA: 0x31A6BC0
	|-SortedSet.Node<KeyValuePair<object, object>>.ColorBlack
	|
	|-RVA: 0x31A76C0 Offset: 0x31A77C1 VA: 0x31A76C0
	|-SortedSet.Node<object>.ColorBlack
	*/

	// RVA: -1 Offset: -1
	public void ColorRed() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x31A5650 Offset: 0x31A5751 VA: 0x31A5650
	|-SortedSet.Node<KeyValuePair<int, bool>>.ColorRed
	|
	|-RVA: 0x31A6110 Offset: 0x31A6211 VA: 0x31A6110
	|-SortedSet.Node<KeyValuePair<int, int>>.ColorRed
	|
	|-RVA: 0x31A6BE0 Offset: 0x31A6CE1 VA: 0x31A6BE0
	|-SortedSet.Node<KeyValuePair<object, object>>.ColorRed
	|
	|-RVA: 0x31A76E0 Offset: 0x31A77E1 VA: 0x31A76E0
	|-SortedSet.Node<object>.ColorRed
	*/

	// RVA: -1 Offset: -1
	public TreeRotation GetRotation(SortedSet.Node<T> current, SortedSet.Node<T> sibling) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x31A5670 Offset: 0x31A5771 VA: 0x31A5670
	|-SortedSet.Node<KeyValuePair<int, bool>>.GetRotation
	|
	|-RVA: 0x31A6130 Offset: 0x31A6231 VA: 0x31A6130
	|-SortedSet.Node<KeyValuePair<int, int>>.GetRotation
	|
	|-RVA: 0x31A6C00 Offset: 0x31A6D01 VA: 0x31A6C00
	|-SortedSet.Node<KeyValuePair<object, object>>.GetRotation
	|
	|-RVA: 0x31A7700 Offset: 0x31A7801 VA: 0x31A7700
	|-SortedSet.Node<object>.GetRotation
	*/

	// RVA: -1 Offset: -1
	public SortedSet.Node<T> GetSibling(SortedSet.Node<T> node) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x31A5710 Offset: 0x31A5811 VA: 0x31A5710
	|-SortedSet.Node<KeyValuePair<int, bool>>.GetSibling
	|
	|-RVA: 0x31A61D0 Offset: 0x31A62D1 VA: 0x31A61D0
	|-SortedSet.Node<KeyValuePair<int, int>>.GetSibling
	|
	|-RVA: 0x31A6CA0 Offset: 0x31A6DA1 VA: 0x31A6CA0
	|-SortedSet.Node<KeyValuePair<object, object>>.GetSibling
	|
	|-RVA: 0x31A77A0 Offset: 0x31A78A1 VA: 0x31A77A0
	|-SortedSet.Node<object>.GetSibling
	*/

	// RVA: -1 Offset: -1
	public void Split4Node() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x31A5780 Offset: 0x31A5881 VA: 0x31A5780
	|-SortedSet.Node<KeyValuePair<int, bool>>.Split4Node
	|
	|-RVA: 0x31A6240 Offset: 0x31A6341 VA: 0x31A6240
	|-SortedSet.Node<KeyValuePair<int, int>>.Split4Node
	|
	|-RVA: 0x31A6D10 Offset: 0x31A6E11 VA: 0x31A6D10
	|-SortedSet.Node<KeyValuePair<object, object>>.Split4Node
	|
	|-RVA: 0x31A7810 Offset: 0x31A7911 VA: 0x31A7810
	|-SortedSet.Node<object>.Split4Node
	*/

	// RVA: -1 Offset: -1
	public SortedSet.Node<T> Rotate(TreeRotation rotation) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x31A5810 Offset: 0x31A5911 VA: 0x31A5810
	|-SortedSet.Node<KeyValuePair<int, bool>>.Rotate
	|
	|-RVA: 0x31A62D0 Offset: 0x31A63D1 VA: 0x31A62D0
	|-SortedSet.Node<KeyValuePair<int, int>>.Rotate
	|
	|-RVA: 0x31A6DA0 Offset: 0x31A6EA1 VA: 0x31A6DA0
	|-SortedSet.Node<KeyValuePair<object, object>>.Rotate
	|
	|-RVA: 0x31A78A0 Offset: 0x31A79A1 VA: 0x31A78A0
	|-SortedSet.Node<object>.Rotate
	*/

	// RVA: -1 Offset: -1
	public SortedSet.Node<T> RotateLeft() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x31A5930 Offset: 0x31A5A31 VA: 0x31A5930
	|-SortedSet.Node<KeyValuePair<int, bool>>.RotateLeft
	|
	|-RVA: 0x31A63F0 Offset: 0x31A64F1 VA: 0x31A63F0
	|-SortedSet.Node<KeyValuePair<int, int>>.RotateLeft
	|
	|-RVA: 0x31A6EC0 Offset: 0x31A6FC1 VA: 0x31A6EC0
	|-SortedSet.Node<KeyValuePair<object, object>>.RotateLeft
	|
	|-RVA: 0x31A79C0 Offset: 0x31A7AC1 VA: 0x31A79C0
	|-SortedSet.Node<object>.RotateLeft
	*/

	// RVA: -1 Offset: -1
	public SortedSet.Node<T> RotateLeftRight() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x31A59C0 Offset: 0x31A5AC1 VA: 0x31A59C0
	|-SortedSet.Node<KeyValuePair<int, bool>>.RotateLeftRight
	|
	|-RVA: 0x31A6480 Offset: 0x31A6581 VA: 0x31A6480
	|-SortedSet.Node<KeyValuePair<int, int>>.RotateLeftRight
	|
	|-RVA: 0x31A6F50 Offset: 0x31A7051 VA: 0x31A6F50
	|-SortedSet.Node<KeyValuePair<object, object>>.RotateLeftRight
	|
	|-RVA: 0x31A7A50 Offset: 0x31A7B51 VA: 0x31A7A50
	|-SortedSet.Node<object>.RotateLeftRight
	*/

	// RVA: -1 Offset: -1
	public SortedSet.Node<T> RotateRight() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x31A5AC0 Offset: 0x31A5BC1 VA: 0x31A5AC0
	|-SortedSet.Node<KeyValuePair<int, bool>>.RotateRight
	|
	|-RVA: 0x31A6580 Offset: 0x31A6681 VA: 0x31A6580
	|-SortedSet.Node<KeyValuePair<int, int>>.RotateRight
	|
	|-RVA: 0x31A7050 Offset: 0x31A7151 VA: 0x31A7050
	|-SortedSet.Node<KeyValuePair<object, object>>.RotateRight
	|
	|-RVA: 0x31A7B50 Offset: 0x31A7C51 VA: 0x31A7B50
	|-SortedSet.Node<object>.RotateRight
	*/

	// RVA: -1 Offset: -1
	public SortedSet.Node<T> RotateRightLeft() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x31A5B50 Offset: 0x31A5C51 VA: 0x31A5B50
	|-SortedSet.Node<KeyValuePair<int, bool>>.RotateRightLeft
	|
	|-RVA: 0x31A6610 Offset: 0x31A6711 VA: 0x31A6610
	|-SortedSet.Node<KeyValuePair<int, int>>.RotateRightLeft
	|
	|-RVA: 0x31A70E0 Offset: 0x31A71E1 VA: 0x31A70E0
	|-SortedSet.Node<KeyValuePair<object, object>>.RotateRightLeft
	|
	|-RVA: 0x31A7BE0 Offset: 0x31A7CE1 VA: 0x31A7BE0
	|-SortedSet.Node<object>.RotateRightLeft
	*/

	// RVA: -1 Offset: -1
	public void Merge2Nodes() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x31A5C50 Offset: 0x31A5D51 VA: 0x31A5C50
	|-SortedSet.Node<KeyValuePair<int, bool>>.Merge2Nodes
	|
	|-RVA: 0x31A6710 Offset: 0x31A6811 VA: 0x31A6710
	|-SortedSet.Node<KeyValuePair<int, int>>.Merge2Nodes
	|
	|-RVA: 0x31A71E0 Offset: 0x31A72E1 VA: 0x31A71E0
	|-SortedSet.Node<KeyValuePair<object, object>>.Merge2Nodes
	|
	|-RVA: 0x31A7CE0 Offset: 0x31A7DE1 VA: 0x31A7CE0
	|-SortedSet.Node<object>.Merge2Nodes
	*/

	// RVA: -1 Offset: -1
	public void ReplaceChild(SortedSet.Node<T> child, SortedSet.Node<T> newChild) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x31A5CE0 Offset: 0x31A5DE1 VA: 0x31A5CE0
	|-SortedSet.Node<KeyValuePair<int, bool>>.ReplaceChild
	|
	|-RVA: 0x31A67A0 Offset: 0x31A68A1 VA: 0x31A67A0
	|-SortedSet.Node<KeyValuePair<int, int>>.ReplaceChild
	|
	|-RVA: 0x31A7270 Offset: 0x31A7371 VA: 0x31A7270
	|-SortedSet.Node<KeyValuePair<object, object>>.ReplaceChild
	|
	|-RVA: 0x31A7D70 Offset: 0x31A7E71 VA: 0x31A7D70
	|-SortedSet.Node<object>.ReplaceChild
	*/
}

// Namespace: 
[Serializable]
public struct SortedSet.Enumerator<T> : IEnumerator<T>, IDisposable, IEnumerator, ISerializable, IDeserializationCallback // TypeDefIndex: 2435
{
	// Fields
	private static readonly SortedSet.Node<T> s_dummyNode; // 0x0
	private SortedSet<T> _tree; // 0x0
	private int _version; // 0x0
	private Stack<SortedSet.Node<T>> _stack; // 0x0
	private SortedSet.Node<T> _current; // 0x0
	private bool _reverse; // 0x0

	// Properties
	public T Current { get; }
	private object System.Collections.IEnumerator.Current { get; }
	internal bool NotStartedOrEnded { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(SortedSet<T> set) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1D2C030 Offset: 0x1D2C131 VA: 0x1D2C030
	|-SortedSet.Enumerator<KeyValuePair<int, bool>>..ctor
	|
	|-RVA: 0x1D2CD80 Offset: 0x1D2CE81 VA: 0x1D2CD80
	|-SortedSet.Enumerator<KeyValuePair<int, int>>..ctor
	|
	|-RVA: 0x1D2E340 Offset: 0x1D2E441 VA: 0x1D2E340
	|-SortedSet.Enumerator<KeyValuePair<object, object>>..ctor
	|
	|-RVA: 0x2EB9CF0 Offset: 0x2EB9DF1 VA: 0x2EB9CF0
	|-SortedSet.Enumerator<object>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void .ctor(SortedSet<T> set, bool reverse) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1D2C080 Offset: 0x1D2C181 VA: 0x1D2C080
	|-SortedSet.Enumerator<KeyValuePair<int, bool>>..ctor
	|
	|-RVA: 0x1D2CDD0 Offset: 0x1D2CED1 VA: 0x1D2CDD0
	|-SortedSet.Enumerator<KeyValuePair<int, int>>..ctor
	|
	|-RVA: 0x1D2E390 Offset: 0x1D2E491 VA: 0x1D2E390
	|-SortedSet.Enumerator<KeyValuePair<object, object>>..ctor
	|
	|-RVA: 0x2EB9D40 Offset: 0x2EB9E41 VA: 0x2EB9D40
	|-SortedSet.Enumerator<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 9
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1D2C260 Offset: 0x1D2C361 VA: 0x1D2C260
	|-SortedSet.Enumerator<KeyValuePair<int, bool>>.System.Runtime.Serialization.ISerializable.GetObjectData
	|
	|-RVA: 0x1D2CFB0 Offset: 0x1D2D0B1 VA: 0x1D2CFB0
	|-SortedSet.Enumerator<KeyValuePair<int, int>>.System.Runtime.Serialization.ISerializable.GetObjectData
	|
	|-RVA: 0x1D2E570 Offset: 0x1D2E671 VA: 0x1D2E570
	|-SortedSet.Enumerator<KeyValuePair<object, object>>.System.Runtime.Serialization.ISerializable.GetObjectData
	|
	|-RVA: 0x2EB9F20 Offset: 0x2EBA021 VA: 0x2EB9F20
	|-SortedSet.Enumerator<object>.System.Runtime.Serialization.ISerializable.GetObjectData
	*/

	// RVA: -1 Offset: -1 Slot: 10
	private void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1D2C2A0 Offset: 0x1D2C3A1 VA: 0x1D2C2A0
	|-SortedSet.Enumerator<KeyValuePair<int, bool>>.System.Runtime.Serialization.IDeserializationCallback.OnDeserialization
	|
	|-RVA: 0x1D2CFF0 Offset: 0x1D2D0F1 VA: 0x1D2CFF0
	|-SortedSet.Enumerator<KeyValuePair<int, int>>.System.Runtime.Serialization.IDeserializationCallback.OnDeserialization
	|
	|-RVA: 0x1D2E5B0 Offset: 0x1D2E6B1 VA: 0x1D2E5B0
	|-SortedSet.Enumerator<KeyValuePair<object, object>>.System.Runtime.Serialization.IDeserializationCallback.OnDeserialization
	|
	|-RVA: 0x2EB9F60 Offset: 0x2EBA061 VA: 0x2EB9F60
	|-SortedSet.Enumerator<object>.System.Runtime.Serialization.IDeserializationCallback.OnDeserialization
	*/

	// RVA: -1 Offset: -1
	private void Initialize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1D2C2E0 Offset: 0x1D2C3E1 VA: 0x1D2C2E0
	|-SortedSet.Enumerator<KeyValuePair<int, bool>>.Initialize
	|
	|-RVA: 0x1D2D030 Offset: 0x1D2D131 VA: 0x1D2D030
	|-SortedSet.Enumerator<KeyValuePair<int, int>>.Initialize
	|
	|-RVA: 0x1D2E5F0 Offset: 0x1D2E6F1 VA: 0x1D2E5F0
	|-SortedSet.Enumerator<KeyValuePair<object, object>>.Initialize
	|
	|-RVA: 0x2EB9FA0 Offset: 0x2EBA0A1 VA: 0x2EB9FA0
	|-SortedSet.Enumerator<object>.Initialize
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1D2C560 Offset: 0x1D2C661 VA: 0x1D2C560
	|-SortedSet.Enumerator<KeyValuePair<int, bool>>.MoveNext
	|
	|-RVA: 0x1D2D2B0 Offset: 0x1D2D3B1 VA: 0x1D2D2B0
	|-SortedSet.Enumerator<KeyValuePair<int, int>>.MoveNext
	|
	|-RVA: 0x1D2E880 Offset: 0x1D2E981 VA: 0x1D2E880
	|-SortedSet.Enumerator<KeyValuePair<object, object>>.MoveNext
	|
	|-RVA: 0x2EBA220 Offset: 0x2EBA321 VA: 0x2EBA220
	|-SortedSet.Enumerator<object>.MoveNext
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1D2C990 Offset: 0x1D2CA91 VA: 0x1D2C990
	|-SortedSet.Enumerator<KeyValuePair<int, bool>>.Dispose
	|
	|-RVA: 0x1D2D6E0 Offset: 0x1D2D7E1 VA: 0x1D2D6E0
	|-SortedSet.Enumerator<KeyValuePair<int, int>>.Dispose
	|
	|-RVA: 0x1D2ECD0 Offset: 0x1D2EDD1 VA: 0x1D2ECD0
	|-SortedSet.Enumerator<KeyValuePair<object, object>>.Dispose
	|
	|-RVA: 0x2EBA650 Offset: 0x2EBA751 VA: 0x2EBA650
	|-SortedSet.Enumerator<object>.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public T get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1D2C9A0 Offset: 0x1D2CAA1 VA: 0x1D2C9A0
	|-SortedSet.Enumerator<KeyValuePair<int, bool>>.get_Current
	|
	|-RVA: 0x1D2D6F0 Offset: 0x1D2D7F1 VA: 0x1D2D6F0
	|-SortedSet.Enumerator<KeyValuePair<int, int>>.get_Current
	|
	|-RVA: 0x1D2ECE0 Offset: 0x1D2EDE1 VA: 0x1D2ECE0
	|-SortedSet.Enumerator<KeyValuePair<object, object>>.get_Current
	|
	|-RVA: 0x2EBA660 Offset: 0x2EBA761 VA: 0x2EBA660
	|-SortedSet.Enumerator<object>.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1D2CA40 Offset: 0x1D2CB41 VA: 0x1D2CA40
	|-SortedSet.Enumerator<KeyValuePair<int, bool>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D2D790 Offset: 0x1D2D891 VA: 0x1D2D790
	|-SortedSet.Enumerator<KeyValuePair<int, int>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D2ED70 Offset: 0x1D2EE71 VA: 0x1D2ED70
	|-SortedSet.Enumerator<KeyValuePair<object, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2EBA700 Offset: 0x2EBA801 VA: 0x2EBA700
	|-SortedSet.Enumerator<object>.System.Collections.IEnumerator.get_Current
	*/

	// RVA: -1 Offset: -1
	internal bool get_NotStartedOrEnded() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1D2CB40 Offset: 0x1D2CC41 VA: 0x1D2CB40
	|-SortedSet.Enumerator<KeyValuePair<int, bool>>.get_NotStartedOrEnded
	|
	|-RVA: 0x1D2D890 Offset: 0x1D2D991 VA: 0x1D2D890
	|-SortedSet.Enumerator<KeyValuePair<int, int>>.get_NotStartedOrEnded
	|
	|-RVA: 0x1D2EE70 Offset: 0x1D2EF71 VA: 0x1D2EE70
	|-SortedSet.Enumerator<KeyValuePair<object, object>>.get_NotStartedOrEnded
	|
	|-RVA: 0x2EBA7D0 Offset: 0x2EBA8D1 VA: 0x2EBA7D0
	|-SortedSet.Enumerator<object>.get_NotStartedOrEnded
	*/

	// RVA: -1 Offset: -1
	internal void Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1D2CB50 Offset: 0x1D2CC51 VA: 0x1D2CB50
	|-SortedSet.Enumerator<KeyValuePair<int, bool>>.Reset
	|
	|-RVA: 0x1D2D8A0 Offset: 0x1D2D9A1 VA: 0x1D2D8A0
	|-SortedSet.Enumerator<KeyValuePair<int, int>>.Reset
	|
	|-RVA: 0x1D2EE80 Offset: 0x1D2EF81 VA: 0x1D2EE80
	|-SortedSet.Enumerator<KeyValuePair<object, object>>.Reset
	|
	|-RVA: 0x2EBA7E0 Offset: 0x2EBA8E1 VA: 0x2EBA7E0
	|-SortedSet.Enumerator<object>.Reset
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1D2CC50 Offset: 0x1D2CD51 VA: 0x1D2CC50
	|-SortedSet.Enumerator<KeyValuePair<int, bool>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D2D9A0 Offset: 0x1D2DAA1 VA: 0x1D2D9A0
	|-SortedSet.Enumerator<KeyValuePair<int, int>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D2EF80 Offset: 0x1D2F081 VA: 0x1D2EF80
	|-SortedSet.Enumerator<KeyValuePair<object, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2EBA8E0 Offset: 0x2EBA9E1 VA: 0x2EBA8E0
	|-SortedSet.Enumerator<object>.System.Collections.IEnumerator.Reset
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1D2CC90 Offset: 0x1D2CD91 VA: 0x1D2CC90
	|-SortedSet.Enumerator<KeyValuePair<int, bool>>..cctor
	|
	|-RVA: 0x1D2D9E0 Offset: 0x1D2DAE1 VA: 0x1D2D9E0
	|-SortedSet.Enumerator<KeyValuePair<int, int>>..cctor
	|
	|-RVA: 0x1D2EFC0 Offset: 0x1D2F0C1 VA: 0x1D2EFC0
	|-SortedSet.Enumerator<KeyValuePair<object, object>>..cctor
	|
	|-RVA: 0x2EBA920 Offset: 0x2EBAA21 VA: 0x2EBA920
	|-SortedSet.Enumerator<object>..cctor
	*/
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x30D50 Offset: 0x30E51 VA: 0x30D50
private sealed class SortedSet.<>c__DisplayClass52_0<T> // TypeDefIndex: 2436
{
	// Fields
	public int index; // 0x0
	public int count; // 0x0
	public T[] array; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B3DEE0 Offset: 0x2B3DFE1 VA: 0x2B3DEE0
	|-SortedSet.<>c__DisplayClass52_0<KeyValuePair<int, bool>>..ctor
	|
	|-RVA: 0x2B3DF80 Offset: 0x2B3E081 VA: 0x2B3DF80
	|-SortedSet.<>c__DisplayClass52_0<KeyValuePair<int, int>>..ctor
	|
	|-RVA: 0x2B3E020 Offset: 0x2B3E121 VA: 0x2B3E020
	|-SortedSet.<>c__DisplayClass52_0<KeyValuePair<object, object>>..ctor
	|
	|-RVA: 0x2B3E0D0 Offset: 0x2B3E1D1 VA: 0x2B3E0D0
	|-SortedSet.<>c__DisplayClass52_0<object>..ctor
	*/

	// RVA: -1 Offset: -1
	internal bool <CopyTo>b__0(SortedSet.Node<T> node) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B3DEF0 Offset: 0x2B3DFF1 VA: 0x2B3DEF0
	|-SortedSet.<>c__DisplayClass52_0<KeyValuePair<int, bool>>.<CopyTo>b__0
	|
	|-RVA: 0x2B3DF90 Offset: 0x2B3E091 VA: 0x2B3DF90
	|-SortedSet.<>c__DisplayClass52_0<KeyValuePair<int, int>>.<CopyTo>b__0
	|
	|-RVA: 0x2B3E030 Offset: 0x2B3E131 VA: 0x2B3E030
	|-SortedSet.<>c__DisplayClass52_0<KeyValuePair<object, object>>.<CopyTo>b__0
	|
	|-RVA: 0x2B3E0E0 Offset: 0x2B3E1E1 VA: 0x2B3E0E0
	|-SortedSet.<>c__DisplayClass52_0<object>.<CopyTo>b__0
	*/
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x30D60 Offset: 0x30E61 VA: 0x30D60
private sealed class SortedSet.<>c__DisplayClass53_0<T> // TypeDefIndex: 2437
{
	// Fields
	public int index; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B3E170 Offset: 0x2B3E271 VA: 0x2B3E170
	|-SortedSet.<>c__DisplayClass53_0<KeyValuePair<int, bool>>..ctor
	|
	|-RVA: 0x2B3E180 Offset: 0x2B3E281 VA: 0x2B3E180
	|-SortedSet.<>c__DisplayClass53_0<KeyValuePair<int, int>>..ctor
	|
	|-RVA: 0x2B3E190 Offset: 0x2B3E291 VA: 0x2B3E190
	|-SortedSet.<>c__DisplayClass53_0<KeyValuePair<object, object>>..ctor
	|
	|-RVA: 0x2B3E1A0 Offset: 0x2B3E2A1 VA: 0x2B3E1A0
	|-SortedSet.<>c__DisplayClass53_0<object>..ctor
	*/
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x30D70 Offset: 0x30E71 VA: 0x30D70
private sealed class SortedSet.<>c__DisplayClass53_1<T> // TypeDefIndex: 2438
{
	// Fields
	public object[] objects; // 0x0
	public SortedSet.<>c__DisplayClass53_0<T> CS$<>8__locals1; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B3E1B0 Offset: 0x2B3E2B1 VA: 0x2B3E1B0
	|-SortedSet.<>c__DisplayClass53_1<KeyValuePair<int, bool>>..ctor
	|
	|-RVA: 0x2B3E290 Offset: 0x2B3E391 VA: 0x2B3E290
	|-SortedSet.<>c__DisplayClass53_1<KeyValuePair<int, int>>..ctor
	|
	|-RVA: 0x2B3E370 Offset: 0x2B3E471 VA: 0x2B3E370
	|-SortedSet.<>c__DisplayClass53_1<KeyValuePair<object, object>>..ctor
	|
	|-RVA: 0x2B3E460 Offset: 0x2B3E561 VA: 0x2B3E460
	|-SortedSet.<>c__DisplayClass53_1<object>..ctor
	*/

	// RVA: -1 Offset: -1
	internal bool <System.Collections.ICollection.CopyTo>b__0(SortedSet.Node<T> node) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B3E1C0 Offset: 0x2B3E2C1 VA: 0x2B3E1C0
	|-SortedSet.<>c__DisplayClass53_1<KeyValuePair<int, bool>>.<System.Collections.ICollection.CopyTo>b__0
	|
	|-RVA: 0x2B3E2A0 Offset: 0x2B3E3A1 VA: 0x2B3E2A0
	|-SortedSet.<>c__DisplayClass53_1<KeyValuePair<int, int>>.<System.Collections.ICollection.CopyTo>b__0
	|
	|-RVA: 0x2B3E380 Offset: 0x2B3E481 VA: 0x2B3E380
	|-SortedSet.<>c__DisplayClass53_1<KeyValuePair<object, object>>.<System.Collections.ICollection.CopyTo>b__0
	|
	|-RVA: 0x2B3E470 Offset: 0x2B3E571 VA: 0x2B3E470
	|-SortedSet.<>c__DisplayClass53_1<object>.<System.Collections.ICollection.CopyTo>b__0
	*/
}

