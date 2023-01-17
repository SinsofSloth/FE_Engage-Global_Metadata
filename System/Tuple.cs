// Namespace: System
[Serializable]
public class Tuple<T1, T2> : IStructuralEquatable, IStructuralComparable, IComparable, ITupleInternal, ITuple // TypeDefIndex: 122
{
	// Fields
	private readonly T1 m_Item1; // 0x0
	private readonly T2 m_Item2; // 0x0

	// Properties
	public T1 Item1 { get; }
	public T2 Item2 { get; }
	private int System.Runtime.CompilerServices.ITuple.Length { get; }

	// Methods

	// RVA: -1 Offset: -1
	public T1 get_Item1() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3574030 Offset: 0x3574131 VA: 0x3574030
	|-Tuple<BooleanDisposable, Action>.get_Item1
	|-Tuple<ICancellationTokenKeyDictionary, ICancelablePromise>.get_Item1
	|-Tuple<object, object>.get_Item1
	|-Tuple<Stream, Stream.ReadWriteTask>.get_Item1
	|-Tuple<TextWriter, string>.get_Item1
	|
	|-RVA: 0x3572A90 Offset: 0x3572B91 VA: 0x3572A90
	|-Tuple<Guid, object>.get_Item1
	|-Tuple<Guid, string>.get_Item1
	|
	|-RVA: 0x3573560 Offset: 0x3573661 VA: 0x3573560
	|-Tuple<object, char>.get_Item1
	|-Tuple<TextWriter, char>.get_Item1
	*/

	// RVA: -1 Offset: -1
	public T2 get_Item2() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3574040 Offset: 0x3574141 VA: 0x3574040
	|-Tuple<BooleanDisposable, Action>.get_Item2
	|-Tuple<ICancellationTokenKeyDictionary, ICancelablePromise>.get_Item2
	|-Tuple<object, object>.get_Item2
	|-Tuple<Stream, Stream.ReadWriteTask>.get_Item2
	|-Tuple<TextWriter, string>.get_Item2
	|
	|-RVA: 0x3572AA0 Offset: 0x3572BA1 VA: 0x3572AA0
	|-Tuple<Guid, object>.get_Item2
	|-Tuple<Guid, string>.get_Item2
	|
	|-RVA: 0x3573570 Offset: 0x3573671 VA: 0x3573570
	|-Tuple<object, char>.get_Item2
	|-Tuple<TextWriter, char>.get_Item2
	*/

	// RVA: -1 Offset: -1
	public void .ctor(T1 item1, T2 item2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3572AB0 Offset: 0x3572BB1 VA: 0x3572AB0
	|-Tuple<Guid, object>..ctor
	|-Tuple<Guid, string>..ctor
	|
	|-RVA: 0x3573580 Offset: 0x3573681 VA: 0x3573580
	|-Tuple<object, char>..ctor
	|
	|-RVA: 0x3574050 Offset: 0x3574151 VA: 0x3574050
	|-Tuple<object, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 0
	public override bool Equals(object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3572B00 Offset: 0x3572C01 VA: 0x3572B00
	|-Tuple<Guid, object>.Equals
	|
	|-RVA: 0x35735D0 Offset: 0x35736D1 VA: 0x35735D0
	|-Tuple<object, char>.Equals
	|
	|-RVA: 0x35740A0 Offset: 0x35741A1 VA: 0x35740A0
	|-Tuple<object, object>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 4
	private bool System.Collections.IStructuralEquatable.Equals(object other, IEqualityComparer comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3572BF0 Offset: 0x3572CF1 VA: 0x3572BF0
	|-Tuple<Guid, object>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x35736C0 Offset: 0x35737C1 VA: 0x35736C0
	|-Tuple<object, char>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x3574190 Offset: 0x3574291 VA: 0x3574190
	|-Tuple<object, object>.System.Collections.IStructuralEquatable.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private int System.IComparable.CompareTo(object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3572DD0 Offset: 0x3572ED1 VA: 0x3572DD0
	|-Tuple<Guid, object>.System.IComparable.CompareTo
	|
	|-RVA: 0x35738A0 Offset: 0x35739A1 VA: 0x35738A0
	|-Tuple<object, char>.System.IComparable.CompareTo
	|
	|-RVA: 0x3574310 Offset: 0x3574411 VA: 0x3574310
	|-Tuple<object, object>.System.IComparable.CompareTo
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private int System.Collections.IStructuralComparable.CompareTo(object other, IComparer comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3572EC0 Offset: 0x3572FC1 VA: 0x3572EC0
	|-Tuple<Guid, object>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x3573990 Offset: 0x3573A91 VA: 0x3573990
	|-Tuple<object, char>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x3574400 Offset: 0x3574501 VA: 0x3574400
	|-Tuple<object, object>.System.Collections.IStructuralComparable.CompareTo
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public override int GetHashCode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3573120 Offset: 0x3573221 VA: 0x3573120
	|-Tuple<Guid, object>.GetHashCode
	|
	|-RVA: 0x3573BF0 Offset: 0x3573CF1 VA: 0x3573BF0
	|-Tuple<object, char>.GetHashCode
	|
	|-RVA: 0x3574610 Offset: 0x3574711 VA: 0x3574610
	|-Tuple<object, object>.GetHashCode
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private int System.Collections.IStructuralEquatable.GetHashCode(IEqualityComparer comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3573200 Offset: 0x3573301 VA: 0x3573200
	|-Tuple<Guid, object>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x3573CD0 Offset: 0x3573DD1 VA: 0x3573CD0
	|-Tuple<object, char>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x35746F0 Offset: 0x35747F1 VA: 0x35746F0
	|-Tuple<object, object>.System.Collections.IStructuralEquatable.GetHashCode
	*/

	// RVA: -1 Offset: -1 Slot: 3
	public override string ToString() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3573370 Offset: 0x3573471 VA: 0x3573370
	|-Tuple<Guid, object>.ToString
	|
	|-RVA: 0x3573E40 Offset: 0x3573F41 VA: 0x3573E40
	|-Tuple<object, char>.ToString
	|
	|-RVA: 0x3574820 Offset: 0x3574921 VA: 0x3574820
	|-Tuple<object, object>.ToString
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private string System.ITupleInternal.ToString(StringBuilder sb) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3573470 Offset: 0x3573571 VA: 0x3573470
	|-Tuple<Guid, object>.System.ITupleInternal.ToString
	|
	|-RVA: 0x3573F40 Offset: 0x3574041 VA: 0x3573F40
	|-Tuple<object, char>.System.ITupleInternal.ToString
	|
	|-RVA: 0x3574920 Offset: 0x3574A21 VA: 0x3574920
	|-Tuple<object, object>.System.ITupleInternal.ToString
	*/

	// RVA: -1 Offset: -1 Slot: 9
	private int System.Runtime.CompilerServices.ITuple.get_Length() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3573550 Offset: 0x3573651 VA: 0x3573550
	|-Tuple<Guid, object>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x3574020 Offset: 0x3574121 VA: 0x3574020
	|-Tuple<object, char>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x35749C0 Offset: 0x3574AC1 VA: 0x35749C0
	|-Tuple<object, object>.System.Runtime.CompilerServices.ITuple.get_Length
	*/
}

// Namespace: System
[Serializable]
public class Tuple<T1, T2, T3, T4> : IStructuralEquatable, IStructuralComparable, IComparable, ITupleInternal, ITuple // TypeDefIndex: 124
{
	// Fields
	private readonly T1 m_Item1; // 0x0
	private readonly T2 m_Item2; // 0x0
	private readonly T3 m_Item3; // 0x0
	private readonly T4 m_Item4; // 0x0

	// Properties
	public T1 Item1 { get; }
	public T2 Item2 { get; }
	public T3 Item3 { get; }
	public T4 Item4 { get; }
	private int System.Runtime.CompilerServices.ITuple.Length { get; }

	// Methods

	// RVA: -1 Offset: -1
	public T1 get_Item1() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3576160 Offset: 0x3576261 VA: 0x3576160
	|-Tuple<int, int, int, bool>.get_Item1
	|
	|-RVA: 0x35772B0 Offset: 0x35773B1 VA: 0x35772B0
	|-Tuple<object, object, int, int>.get_Item1
	|-Tuple<TextReader, char[], int, int>.get_Item1
	|-Tuple<TextWriter, char[], int, int>.get_Item1
	|
	|-RVA: 0x35781C0 Offset: 0x35782C1 VA: 0x35781C0
	|-Tuple<object, object, object, object>.get_Item1
	*/

	// RVA: -1 Offset: -1
	public T2 get_Item2() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3576170 Offset: 0x3576271 VA: 0x3576170
	|-Tuple<int, int, int, bool>.get_Item2
	|
	|-RVA: 0x35772C0 Offset: 0x35773C1 VA: 0x35772C0
	|-Tuple<object, object, int, int>.get_Item2
	|-Tuple<TextReader, char[], int, int>.get_Item2
	|-Tuple<TextWriter, char[], int, int>.get_Item2
	|
	|-RVA: 0x35781D0 Offset: 0x35782D1 VA: 0x35781D0
	|-Tuple<object, object, object, object>.get_Item2
	*/

	// RVA: -1 Offset: -1
	public T3 get_Item3() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3576180 Offset: 0x3576281 VA: 0x3576180
	|-Tuple<int, int, int, bool>.get_Item3
	|
	|-RVA: 0x35772D0 Offset: 0x35773D1 VA: 0x35772D0
	|-Tuple<object, object, int, int>.get_Item3
	|-Tuple<TextReader, char[], int, int>.get_Item3
	|-Tuple<TextWriter, char[], int, int>.get_Item3
	|
	|-RVA: 0x35781E0 Offset: 0x35782E1 VA: 0x35781E0
	|-Tuple<object, object, object, object>.get_Item3
	*/

	// RVA: -1 Offset: -1
	public T4 get_Item4() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3576190 Offset: 0x3576291 VA: 0x3576190
	|-Tuple<int, int, int, bool>.get_Item4
	|
	|-RVA: 0x35772E0 Offset: 0x35773E1 VA: 0x35772E0
	|-Tuple<object, object, int, int>.get_Item4
	|-Tuple<TextReader, char[], int, int>.get_Item4
	|-Tuple<TextWriter, char[], int, int>.get_Item4
	|
	|-RVA: 0x35781F0 Offset: 0x35782F1 VA: 0x35781F0
	|-Tuple<object, object, object, object>.get_Item4
	*/

	// RVA: -1 Offset: -1
	public void .ctor(T1 item1, T2 item2, T3 item3, T4 item4) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x35761A0 Offset: 0x35762A1 VA: 0x35761A0
	|-Tuple<int, int, int, bool>..ctor
	|
	|-RVA: 0x35772F0 Offset: 0x35773F1 VA: 0x35772F0
	|-Tuple<object, object, int, int>..ctor
	|
	|-RVA: 0x3578200 Offset: 0x3578301 VA: 0x3578200
	|-Tuple<object, object, object, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 0
	public override bool Equals(object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3576200 Offset: 0x3576301 VA: 0x3576200
	|-Tuple<int, int, int, bool>.Equals
	|
	|-RVA: 0x3577360 Offset: 0x3577461 VA: 0x3577360
	|-Tuple<object, object, int, int>.Equals
	|
	|-RVA: 0x3578280 Offset: 0x3578381 VA: 0x3578280
	|-Tuple<object, object, object, object>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 4
	private bool System.Collections.IStructuralEquatable.Equals(object other, IEqualityComparer comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x35762F0 Offset: 0x35763F1 VA: 0x35762F0
	|-Tuple<int, int, int, bool>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x3577450 Offset: 0x3577551 VA: 0x3577450
	|-Tuple<object, object, int, int>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x3578370 Offset: 0x3578471 VA: 0x3578370
	|-Tuple<object, object, object, object>.System.Collections.IStructuralEquatable.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private int System.IComparable.CompareTo(object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x35766D0 Offset: 0x35767D1 VA: 0x35766D0
	|-Tuple<int, int, int, bool>.System.IComparable.CompareTo
	|
	|-RVA: 0x3577770 Offset: 0x3577871 VA: 0x3577770
	|-Tuple<object, object, int, int>.System.IComparable.CompareTo
	|
	|-RVA: 0x35785D0 Offset: 0x35786D1 VA: 0x35785D0
	|-Tuple<object, object, object, object>.System.IComparable.CompareTo
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private int System.Collections.IStructuralComparable.CompareTo(object other, IComparer comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x35767C0 Offset: 0x35768C1 VA: 0x35767C0
	|-Tuple<int, int, int, bool>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x3577860 Offset: 0x3577961 VA: 0x3577860
	|-Tuple<object, object, int, int>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x35786C0 Offset: 0x35787C1 VA: 0x35786C0
	|-Tuple<object, object, object, object>.System.Collections.IStructuralComparable.CompareTo
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public override int GetHashCode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3576C20 Offset: 0x3576D21 VA: 0x3576C20
	|-Tuple<int, int, int, bool>.GetHashCode
	|
	|-RVA: 0x3577C00 Offset: 0x3577D01 VA: 0x3577C00
	|-Tuple<object, object, int, int>.GetHashCode
	|
	|-RVA: 0x35789A0 Offset: 0x3578AA1 VA: 0x35789A0
	|-Tuple<object, object, object, object>.GetHashCode
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private int System.Collections.IStructuralEquatable.GetHashCode(IEqualityComparer comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3576D00 Offset: 0x3576E01 VA: 0x3576D00
	|-Tuple<int, int, int, bool>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x3577CE0 Offset: 0x3577DE1 VA: 0x3577CE0
	|-Tuple<object, object, int, int>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x3578A80 Offset: 0x3578B81 VA: 0x3578A80
	|-Tuple<object, object, object, object>.System.Collections.IStructuralEquatable.GetHashCode
	*/

	// RVA: -1 Offset: -1 Slot: 3
	public override string ToString() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3576FE0 Offset: 0x35770E1 VA: 0x3576FE0
	|-Tuple<int, int, int, bool>.ToString
	|
	|-RVA: 0x3577F60 Offset: 0x3578061 VA: 0x3577F60
	|-Tuple<object, object, int, int>.ToString
	|
	|-RVA: 0x3578C90 Offset: 0x3578D91 VA: 0x3578C90
	|-Tuple<object, object, object, object>.ToString
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private string System.ITupleInternal.ToString(StringBuilder sb) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x35770E0 Offset: 0x35771E1 VA: 0x35770E0
	|-Tuple<int, int, int, bool>.System.ITupleInternal.ToString
	|
	|-RVA: 0x3578060 Offset: 0x3578161 VA: 0x3578060
	|-Tuple<object, object, int, int>.System.ITupleInternal.ToString
	|
	|-RVA: 0x3578D90 Offset: 0x3578E91 VA: 0x3578D90
	|-Tuple<object, object, object, object>.System.ITupleInternal.ToString
	*/

	// RVA: -1 Offset: -1 Slot: 9
	private int System.Runtime.CompilerServices.ITuple.get_Length() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x35772A0 Offset: 0x35773A1 VA: 0x35772A0
	|-Tuple<int, int, int, bool>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x35781B0 Offset: 0x35782B1 VA: 0x35781B0
	|-Tuple<object, object, int, int>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x3578E70 Offset: 0x3578F71 VA: 0x3578E70
	|-Tuple<object, object, object, object>.System.Runtime.CompilerServices.ITuple.get_Length
	*/
}

