// Namespace: System
[Serializable]
public struct ValueTuple<T1, T2, T3, T4, T5, T6, T7, TRest> : IEquatable<ValueTuple<T1, T2, T3, T4, T5, T6, T7, TRest>>, IStructuralEquatable, IStructuralComparable, IComparable, IComparable<ValueTuple<T1, T2, T3, T4, T5, T6, T7, TRest>>, IValueTupleInternal, ITuple // TypeDefIndex: 113
{
	// Fields
	public T1 Item1; // 0x0
	public T2 Item2; // 0x0
	public T3 Item3; // 0x0
	public T4 Item4; // 0x0
	public T5 Item5; // 0x0
	public T6 Item6; // 0x0
	public T7 Item7; // 0x0
	public TRest Rest; // 0x0

	// Properties
	private int System.Runtime.CompilerServices.ITuple.Length { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7, TRest rest) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3A49980 Offset: 0x3A49A81 VA: 0x3A49980
	|-ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>..ctor
	|
	|-RVA: 0x3A50040 Offset: 0x3A50141 VA: 0x3A50040
	|-ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 0
	public override bool Equals(object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3A49B40 Offset: 0x3A49C41 VA: 0x3A49B40
	|-ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>.Equals
	|
	|-RVA: 0x3A50210 Offset: 0x3A50311 VA: 0x3A50210
	|-ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public bool Equals(ValueTuple<T1, T2, T3, T4, T5, T6, T7, TRest> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3A49D00 Offset: 0x3A49E01 VA: 0x3A49D00
	|-ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>.Equals
	|
	|-RVA: 0x3A50370 Offset: 0x3A50471 VA: 0x3A50370
	|-ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private bool System.Collections.IStructuralEquatable.Equals(object other, IEqualityComparer comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3A4A030 Offset: 0x3A4A131 VA: 0x3A4A030
	|-ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x3A506E0 Offset: 0x3A507E1 VA: 0x3A506E0
	|-ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>.System.Collections.IStructuralEquatable.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private int System.IComparable.CompareTo(object other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3A4A940 Offset: 0x3A4AA41 VA: 0x3A4A940
	|-ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>.System.IComparable.CompareTo
	|
	|-RVA: 0x3A51000 Offset: 0x3A51101 VA: 0x3A51000
	|-ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>.System.IComparable.CompareTo
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public int CompareTo(ValueTuple<T1, T2, T3, T4, T5, T6, T7, TRest> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3A4ABC0 Offset: 0x3A4ACC1 VA: 0x3A4ABC0
	|-ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>.CompareTo
	|
	|-RVA: 0x3A511F0 Offset: 0x3A512F1 VA: 0x3A511F0
	|-ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>.CompareTo
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private int System.Collections.IStructuralComparable.CompareTo(object other, IComparer comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3A4AEE0 Offset: 0x3A4AFE1 VA: 0x3A4AEE0
	|-ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x3A51560 Offset: 0x3A51661 VA: 0x3A51560
	|-ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>.System.Collections.IStructuralComparable.CompareTo
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public override int GetHashCode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3A4B8F0 Offset: 0x3A4B9F1 VA: 0x3A4B8F0
	|-ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>.GetHashCode
	|
	|-RVA: 0x3A51F50 Offset: 0x3A52051 VA: 0x3A51F50
	|-ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>.GetHashCode
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private int System.Collections.IStructuralEquatable.GetHashCode(IEqualityComparer comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3A4C670 Offset: 0x3A4C771 VA: 0x3A4C670
	|-ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x3A52CD0 Offset: 0x3A52DD1 VA: 0x3A52CD0
	|-ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>.System.Collections.IStructuralEquatable.GetHashCode
	*/

	// RVA: -1 Offset: -1
	private int GetHashCodeCore(IEqualityComparer comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3A4C6C0 Offset: 0x3A4C7C1 VA: 0x3A4C6C0
	|-ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>.GetHashCodeCore
	|
	|-RVA: 0x3A52D20 Offset: 0x3A52E21 VA: 0x3A52D20
	|-ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>.GetHashCodeCore
	*/

	// RVA: -1 Offset: -1 Slot: 10
	private int System.IValueTupleInternal.GetHashCode(IEqualityComparer comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3A4E3A0 Offset: 0x3A4E4A1 VA: 0x3A4E3A0
	|-ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x3A54A10 Offset: 0x3A54B11 VA: 0x3A54A10
	|-ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>.System.IValueTupleInternal.GetHashCode
	*/

	// RVA: -1 Offset: -1 Slot: 3
	public override string ToString() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3A4E3F0 Offset: 0x3A4E4F1 VA: 0x3A4E3F0
	|-ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>.ToString
	|
	|-RVA: 0x3A54A60 Offset: 0x3A54B61 VA: 0x3A54A60
	|-ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>.ToString
	*/

	// RVA: -1 Offset: -1 Slot: 11
	private string System.IValueTupleInternal.ToStringEnd() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3A4F1D0 Offset: 0x3A4F2D1 VA: 0x3A4F1D0
	|-ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x3A55850 Offset: 0x3A55951 VA: 0x3A55850
	|-ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>.System.IValueTupleInternal.ToStringEnd
	*/

	// RVA: -1 Offset: -1 Slot: 12
	private int System.Runtime.CompilerServices.ITuple.get_Length() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3A4FF10 Offset: 0x3A50011 VA: 0x3A4FF10
	|-ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x3A565A0 Offset: 0x3A566A1 VA: 0x3A565A0
	|-ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>.System.Runtime.CompilerServices.ITuple.get_Length
	*/
}

