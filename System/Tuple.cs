// Namespace: System
[Serializable]
public class Tuple<T1, T2, T3> : IStructuralEquatable, IStructuralComparable, IComparable, ITupleInternal, ITuple // TypeDefIndex: 123
{
	// Fields
	private readonly T1 m_Item1; // 0x0
	private readonly T2 m_Item2; // 0x0
	private readonly T3 m_Item3; // 0x0

	// Properties
	public T1 Item1 { get; }
	public T2 Item2 { get; }
	public T3 Item3 { get; }
	private int System.Runtime.CompilerServices.ITuple.Length { get; }

	// Methods

	// RVA: -1 Offset: -1
	public T1 get_Item1() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x35749D0 Offset: 0x3574AD1 VA: 0x35749D0
	|-Tuple<object, object, object>.get_Item1
	|-Tuple<Task, Task, TaskContinuation>.get_Item1
	|
	|-RVA: 0x3575500 Offset: 0x3575601 VA: 0x3575500
	|-Tuple<object, Unit, object>.get_Item1
	*/

	// RVA: -1 Offset: -1
	public T2 get_Item2() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x35749E0 Offset: 0x3574AE1 VA: 0x35749E0
	|-Tuple<object, object, object>.get_Item2
	|-Tuple<Task, Task, TaskContinuation>.get_Item2
	|
	|-RVA: 0x3575510 Offset: 0x3575611 VA: 0x3575510
	|-Tuple<object, Unit, object>.get_Item2
	*/

	// RVA: -1 Offset: -1
	public T3 get_Item3() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x35749F0 Offset: 0x3574AF1 VA: 0x35749F0
	|-Tuple<object, object, object>.get_Item3
	|-Tuple<Task, Task, TaskContinuation>.get_Item3
	|
	|-RVA: 0x3575520 Offset: 0x3575621 VA: 0x3575520
	|-Tuple<object, Unit, object>.get_Item3
	*/

	// RVA: -1 Offset: -1
	public void .ctor(T1 item1, T2 item2, T3 item3) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3574A00 Offset: 0x3574B01 VA: 0x3574A00
	|-Tuple<object, object, object>..ctor
	|-Tuple<Task, Task, TaskContinuation>..ctor
	|
	|-RVA: 0x3575530 Offset: 0x3575631 VA: 0x3575530
	|-Tuple<object, Unit, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 0
	public override bool Equals(object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3574A70 Offset: 0x3574B71 VA: 0x3574A70
	|-Tuple<object, object, object>.Equals
	|
	|-RVA: 0x3575590 Offset: 0x3575691 VA: 0x3575590
	|-Tuple<object, Unit, object>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 4
	private bool System.Collections.IStructuralEquatable.Equals(object other, IEqualityComparer comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3574B60 Offset: 0x3574C61 VA: 0x3574B60
	|-Tuple<object, object, object>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x3575680 Offset: 0x3575781 VA: 0x3575680
	|-Tuple<object, Unit, object>.System.Collections.IStructuralEquatable.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private int System.IComparable.CompareTo(object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3574D50 Offset: 0x3574E51 VA: 0x3574D50
	|-Tuple<object, object, object>.System.IComparable.CompareTo
	|
	|-RVA: 0x35758D0 Offset: 0x35759D1 VA: 0x35758D0
	|-Tuple<object, Unit, object>.System.IComparable.CompareTo
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private int System.Collections.IStructuralComparable.CompareTo(object other, IComparer comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3574E40 Offset: 0x3574F41 VA: 0x3574E40
	|-Tuple<object, object, object>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x35759C0 Offset: 0x3575AC1 VA: 0x35759C0
	|-Tuple<object, Unit, object>.System.Collections.IStructuralComparable.CompareTo
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public override int GetHashCode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x35750B0 Offset: 0x35751B1 VA: 0x35750B0
	|-Tuple<object, object, object>.GetHashCode
	|
	|-RVA: 0x3575C90 Offset: 0x3575D91 VA: 0x3575C90
	|-Tuple<object, Unit, object>.GetHashCode
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private int System.Collections.IStructuralEquatable.GetHashCode(IEqualityComparer comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3575190 Offset: 0x3575291 VA: 0x3575190
	|-Tuple<object, object, object>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x3575D70 Offset: 0x3575E71 VA: 0x3575D70
	|-Tuple<object, Unit, object>.System.Collections.IStructuralEquatable.GetHashCode
	*/

	// RVA: -1 Offset: -1 Slot: 3
	public override string ToString() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3575330 Offset: 0x3575431 VA: 0x3575330
	|-Tuple<object, object, object>.ToString
	|
	|-RVA: 0x3575F50 Offset: 0x3576051 VA: 0x3575F50
	|-Tuple<object, Unit, object>.ToString
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private string System.ITupleInternal.ToString(StringBuilder sb) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3575430 Offset: 0x3575531 VA: 0x3575430
	|-Tuple<object, object, object>.System.ITupleInternal.ToString
	|
	|-RVA: 0x3576050 Offset: 0x3576151 VA: 0x3576050
	|-Tuple<object, Unit, object>.System.ITupleInternal.ToString
	*/

	// RVA: -1 Offset: -1 Slot: 9
	private int System.Runtime.CompilerServices.ITuple.get_Length() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x35754F0 Offset: 0x35755F1 VA: 0x35754F0
	|-Tuple<object, object, object>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x3576150 Offset: 0x3576251 VA: 0x3576150
	|-Tuple<object, Unit, object>.System.Runtime.CompilerServices.ITuple.get_Length
	*/
}

