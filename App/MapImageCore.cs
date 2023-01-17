// Namespace: App
public abstract class MapImageCore<T> : MapImageIndex // TypeDefIndex: 12099
{
	// Fields
	public const int ImageSize = 1024;
	protected T[] m_Images; // 0x0

	// Properties
	public T[] Images { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2933D70 Offset: 0x2933E71 VA: 0x2933D70
	|-MapImageCore<byte>..ctor
	|
	|-RVA: 0x2933F50 Offset: 0x2934051 VA: 0x2933F50
	|-MapImageCore<short>..ctor
	|
	|-RVA: 0x2934130 Offset: 0x2934231 VA: 0x2934130
	|-MapImageCore<object>..ctor
	|
	|-RVA: 0x2934330 Offset: 0x2934431 VA: 0x2934330
	|-MapImageCore<sbyte>..ctor
	|
	|-RVA: 0x2934510 Offset: 0x2934611 VA: 0x2934510
	|-MapImageCore<ushort>..ctor
	|
	|-RVA: 0x29346F0 Offset: 0x29347F1 VA: 0x29346F0
	|-MapImageCore<uint>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public virtual void Clear(T v) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2933DE0 Offset: 0x2933EE1 VA: 0x2933DE0
	|-MapImageCore<byte>.Clear
	|
	|-RVA: 0x2933FC0 Offset: 0x29340C1 VA: 0x2933FC0
	|-MapImageCore<short>.Clear
	|
	|-RVA: 0x29341A0 Offset: 0x29342A1 VA: 0x29341A0
	|-MapImageCore<object>.Clear
	|
	|-RVA: 0x29343A0 Offset: 0x29344A1 VA: 0x29343A0
	|-MapImageCore<sbyte>.Clear
	|
	|-RVA: 0x2934580 Offset: 0x2934681 VA: 0x2934580
	|-MapImageCore<ushort>.Clear
	|
	|-RVA: 0x2934760 Offset: 0x2934861 VA: 0x2934760
	|-MapImageCore<uint>.Clear
	*/

	// RVA: -1 Offset: -1
	public void CopyFrom(MapImageCore<T> src) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2933E30 Offset: 0x2933F31 VA: 0x2933E30
	|-MapImageCore<byte>.CopyFrom
	|
	|-RVA: 0x2934010 Offset: 0x2934111 VA: 0x2934010
	|-MapImageCore<short>.CopyFrom
	|
	|-RVA: 0x2934210 Offset: 0x2934311 VA: 0x2934210
	|-MapImageCore<object>.CopyFrom
	|
	|-RVA: 0x29343F0 Offset: 0x29344F1 VA: 0x29343F0
	|-MapImageCore<sbyte>.CopyFrom
	|
	|-RVA: 0x29345D0 Offset: 0x29346D1 VA: 0x29345D0
	|-MapImageCore<ushort>.CopyFrom
	|
	|-RVA: 0x29347B0 Offset: 0x29348B1 VA: 0x29347B0
	|-MapImageCore<uint>.CopyFrom
	*/

	// RVA: -1 Offset: -1
	public void Set(int index, T v) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2933E50 Offset: 0x2933F51 VA: 0x2933E50
	|-MapImageCore<byte>.Set
	|
	|-RVA: 0x2934030 Offset: 0x2934131 VA: 0x2934030
	|-MapImageCore<short>.Set
	|
	|-RVA: 0x2934230 Offset: 0x2934331 VA: 0x2934230
	|-MapImageCore<object>.Set
	|
	|-RVA: 0x2934410 Offset: 0x2934511 VA: 0x2934410
	|-MapImageCore<sbyte>.Set
	|
	|-RVA: 0x29345F0 Offset: 0x29346F1 VA: 0x29345F0
	|-MapImageCore<ushort>.Set
	|
	|-RVA: 0x29347D0 Offset: 0x29348D1 VA: 0x29347D0
	|-MapImageCore<uint>.Set
	*/

	// RVA: -1 Offset: -1
	public void Set(int x, int z, T v) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2933E90 Offset: 0x2933F91 VA: 0x2933E90
	|-MapImageCore<byte>.Set
	|
	|-RVA: 0x2934070 Offset: 0x2934171 VA: 0x2934070
	|-MapImageCore<short>.Set
	|
	|-RVA: 0x2934270 Offset: 0x2934371 VA: 0x2934270
	|-MapImageCore<object>.Set
	|
	|-RVA: 0x2934450 Offset: 0x2934551 VA: 0x2934450
	|-MapImageCore<sbyte>.Set
	|
	|-RVA: 0x2934630 Offset: 0x2934731 VA: 0x2934630
	|-MapImageCore<ushort>.Set
	|
	|-RVA: 0x2934810 Offset: 0x2934911 VA: 0x2934810
	|-MapImageCore<uint>.Set
	*/

	// RVA: -1 Offset: -1
	public T Get(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2933EB0 Offset: 0x2933FB1 VA: 0x2933EB0
	|-MapImageCore<byte>.Get
	|
	|-RVA: 0x2934090 Offset: 0x2934191 VA: 0x2934090
	|-MapImageCore<short>.Get
	|
	|-RVA: 0x2934290 Offset: 0x2934391 VA: 0x2934290
	|-MapImageCore<object>.Get
	|
	|-RVA: 0x2934470 Offset: 0x2934571 VA: 0x2934470
	|-MapImageCore<sbyte>.Get
	|
	|-RVA: 0x2934650 Offset: 0x2934751 VA: 0x2934650
	|-MapImageCore<ushort>.Get
	|
	|-RVA: 0x2934830 Offset: 0x2934931 VA: 0x2934830
	|-MapImageCore<uint>.Get
	*/

	// RVA: -1 Offset: -1
	public T Get(int x, int z) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2933EF0 Offset: 0x2933FF1 VA: 0x2933EF0
	|-MapImageCore<byte>.Get
	|
	|-RVA: 0x29340D0 Offset: 0x29341D1 VA: 0x29340D0
	|-MapImageCore<short>.Get
	|
	|-RVA: 0x29342D0 Offset: 0x29343D1 VA: 0x29342D0
	|-MapImageCore<object>.Get
	|
	|-RVA: 0x29344B0 Offset: 0x29345B1 VA: 0x29344B0
	|-MapImageCore<sbyte>.Get
	|
	|-RVA: 0x2934690 Offset: 0x2934791 VA: 0x2934690
	|-MapImageCore<ushort>.Get
	|
	|-RVA: 0x2934870 Offset: 0x2934971 VA: 0x2934870
	|-MapImageCore<uint>.Get
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void Add(int index, T v);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-MapImageCore<object>.Add
	*/

	// RVA: -1 Offset: -1
	public void Add(int x, int z, T v) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2933F10 Offset: 0x2934011 VA: 0x2933F10
	|-MapImageCore<byte>.Add
	|
	|-RVA: 0x29340F0 Offset: 0x29341F1 VA: 0x29340F0
	|-MapImageCore<short>.Add
	|
	|-RVA: 0x29342F0 Offset: 0x29343F1 VA: 0x29342F0
	|-MapImageCore<object>.Add
	|
	|-RVA: 0x29344D0 Offset: 0x29345D1 VA: 0x29344D0
	|-MapImageCore<sbyte>.Add
	|
	|-RVA: 0x29346B0 Offset: 0x29347B1 VA: 0x29346B0
	|-MapImageCore<ushort>.Add
	|
	|-RVA: 0x2934890 Offset: 0x2934991 VA: 0x2934890
	|-MapImageCore<uint>.Add
	*/

	// RVA: -1 Offset: -1
	public void Dump() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2933F30 Offset: 0x2934031 VA: 0x2933F30
	|-MapImageCore<byte>.Dump
	|
	|-RVA: 0x2934110 Offset: 0x2934211 VA: 0x2934110
	|-MapImageCore<short>.Dump
	|
	|-RVA: 0x2934310 Offset: 0x2934411 VA: 0x2934310
	|-MapImageCore<object>.Dump
	|
	|-RVA: 0x29344F0 Offset: 0x29345F1 VA: 0x29344F0
	|-MapImageCore<sbyte>.Dump
	|
	|-RVA: 0x29346D0 Offset: 0x29347D1 VA: 0x29346D0
	|-MapImageCore<ushort>.Dump
	|
	|-RVA: 0x29348B0 Offset: 0x29349B1 VA: 0x29348B0
	|-MapImageCore<uint>.Dump
	*/

	// RVA: -1 Offset: -1
	public T[] get_Images() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2933F40 Offset: 0x2934041 VA: 0x2933F40
	|-MapImageCore<byte>.get_Images
	|
	|-RVA: 0x2934120 Offset: 0x2934221 VA: 0x2934120
	|-MapImageCore<short>.get_Images
	|
	|-RVA: 0x2934320 Offset: 0x2934421 VA: 0x2934320
	|-MapImageCore<object>.get_Images
	|
	|-RVA: 0x2934500 Offset: 0x2934601 VA: 0x2934500
	|-MapImageCore<sbyte>.get_Images
	|
	|-RVA: 0x29346E0 Offset: 0x29347E1 VA: 0x29346E0
	|-MapImageCore<ushort>.get_Images
	|
	|-RVA: 0x29348C0 Offset: 0x29349C1 VA: 0x29348C0
	|-MapImageCore<uint>.get_Images
	*/
}

