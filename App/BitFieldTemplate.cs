// Namespace: App
public abstract class BitFieldTemplate64<T> : BitField64 // TypeDefIndex: 9177
{
	// Properties
	protected override Type ValueType { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	protected override Type get_ValueType() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30BC370 Offset: 0x30BC471 VA: 0x30BC370
	|-BitFieldTemplate64<MapDeployTemplate.Flag<MapDeploy>>.get_ValueType
	|-BitFieldTemplate64<Int64Enum>.get_ValueType
	|-BitFieldTemplate64<Unit.Status>.get_ValueType
	*/

	// RVA: -1 Offset: -1 Slot: 5
	protected abstract long ToLong(T value);

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30BC3F0 Offset: 0x30BC4F1 VA: 0x30BC3F0
	|-BitFieldTemplate64<MapDeployTemplate.Flag<MapDeploy>>..ctor
	|-BitFieldTemplate64<Int64Enum>..ctor
	|-BitFieldTemplate64<Unit.Status>..ctor
	*/

	// RVA: -1 Offset: -1
	public void Set(T f) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30BC420 Offset: 0x30BC521 VA: 0x30BC420
	|-BitFieldTemplate64<Int64Enum>.Set
	|-BitFieldTemplate64<Unit.Status>.Set
	*/

	// RVA: -1 Offset: -1
	public void Clear(T f) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30BC460 Offset: 0x30BC561 VA: 0x30BC460
	|-BitFieldTemplate64<Int64Enum>.Clear
	|-BitFieldTemplate64<Unit.Status>.Clear
	*/

	// RVA: -1 Offset: -1
	public void Change(T f) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30BC4A0 Offset: 0x30BC5A1 VA: 0x30BC4A0
	|-BitFieldTemplate64<Int64Enum>.Change
	|-BitFieldTemplate64<Unit.Status>.Change
	*/

	// RVA: -1 Offset: -1
	public long Mask(T f) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30BC4E0 Offset: 0x30BC5E1 VA: 0x30BC4E0
	|-BitFieldTemplate64<Int64Enum>.Mask
	|-BitFieldTemplate64<Unit.Status>.Mask
	*/

	// RVA: -1 Offset: -1
	public bool Test(T f) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30BC510 Offset: 0x30BC611 VA: 0x30BC510
	|-BitFieldTemplate64<Int64Enum>.Test
	|-BitFieldTemplate64<Unit.Status>.Test
	*/

	// RVA: -1 Offset: -1
	public bool Not(T f) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30BC550 Offset: 0x30BC651 VA: 0x30BC550
	|-BitFieldTemplate64<Int64Enum>.Not
	|-BitFieldTemplate64<Unit.Status>.Not
	*/

	// RVA: -1 Offset: -1
	public void Reset(T f) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30BC590 Offset: 0x30BC691 VA: 0x30BC590
	|-BitFieldTemplate64<Int64Enum>.Reset
	*/

	// RVA: -1 Offset: -1
	public void SetOrClear(bool isSet, T f) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30BC5C0 Offset: 0x30BC6C1 VA: 0x30BC5C0
	|-BitFieldTemplate64<Int64Enum>.SetOrClear
	|-BitFieldTemplate64<Unit.Status>.SetOrClear
	*/

	// RVA: -1 Offset: -1
	public bool Exclusive(T n, T m) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30BC610 Offset: 0x30BC711 VA: 0x30BC610
	|-BitFieldTemplate64<Int64Enum>.Exclusive
	*/

	// RVA: -1 Offset: -1
	public void Serialize(Stream stream) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30BC670 Offset: 0x30BC771 VA: 0x30BC670
	|-BitFieldTemplate64<Int64Enum>.Serialize
	*/

	// RVA: -1 Offset: -1
	public void Deserialize(Stream stream) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30BC690 Offset: 0x30BC791 VA: 0x30BC690
	|-BitFieldTemplate64<Int64Enum>.Deserialize
	*/
}

