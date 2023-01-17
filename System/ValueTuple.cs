// Namespace: System
[Serializable]
public struct ValueTuple<T1> : IEquatable<ValueTuple<T1>>, IStructuralEquatable, IStructuralComparable, IComparable, IComparable<ValueTuple<T1>>, IValueTupleInternal, ITuple // TypeDefIndex: 106
{
	// Fields
	public T1 Item1; // 0x0

	// Properties
	private int System.Runtime.CompilerServices.ITuple.Length { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(T1 item1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3391430 Offset: 0x3391531 VA: 0x3391430
	|-ValueTuple<ValueTuple<bool, object>>..ctor
	|
	|-RVA: 0x33921F0 Offset: 0x33922F1 VA: 0x33921F0
	|-ValueTuple<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 0
	public override bool Equals(object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3391440 Offset: 0x3391541 VA: 0x3391440
	|-ValueTuple<ValueTuple<bool, object>>.Equals
	|
	|-RVA: 0x3392200 Offset: 0x3392301 VA: 0x3392200
	|-ValueTuple<object>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public bool Equals(ValueTuple<T1> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x33915D0 Offset: 0x33916D1 VA: 0x33915D0
	|-ValueTuple<ValueTuple<bool, object>>.Equals
	|
	|-RVA: 0x3392390 Offset: 0x3392491 VA: 0x3392390
	|-ValueTuple<object>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private bool System.Collections.IStructuralEquatable.Equals(object other, IEqualityComparer comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3391660 Offset: 0x3391761 VA: 0x3391660
	|-ValueTuple<ValueTuple<bool, object>>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x3392420 Offset: 0x3392521 VA: 0x3392420
	|-ValueTuple<object>.System.Collections.IStructuralEquatable.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private int System.IComparable.CompareTo(object other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3391870 Offset: 0x3391971 VA: 0x3391870
	|-ValueTuple<ValueTuple<bool, object>>.System.IComparable.CompareTo
	|
	|-RVA: 0x33925B0 Offset: 0x33926B1 VA: 0x33925B0
	|-ValueTuple<object>.System.IComparable.CompareTo
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public int CompareTo(ValueTuple<T1> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3391A80 Offset: 0x3391B81 VA: 0x3391A80
	|-ValueTuple<ValueTuple<bool, object>>.CompareTo
	|
	|-RVA: 0x33927B0 Offset: 0x33928B1 VA: 0x33927B0
	|-ValueTuple<object>.CompareTo
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private int System.Collections.IStructuralComparable.CompareTo(object other, IComparer comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3391B10 Offset: 0x3391C11 VA: 0x3391B10
	|-ValueTuple<ValueTuple<bool, object>>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x3392840 Offset: 0x3392941 VA: 0x3392840
	|-ValueTuple<object>.System.Collections.IStructuralComparable.CompareTo
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public override int GetHashCode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3391DC0 Offset: 0x3391EC1 VA: 0x3391DC0
	|-ValueTuple<ValueTuple<bool, object>>.GetHashCode
	|
	|-RVA: 0x3392A80 Offset: 0x3392B81 VA: 0x3392A80
	|-ValueTuple<object>.GetHashCode
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private int System.Collections.IStructuralEquatable.GetHashCode(IEqualityComparer comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3391E40 Offset: 0x3391F41 VA: 0x3391E40
	|-ValueTuple<ValueTuple<bool, object>>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x3392AA0 Offset: 0x3392BA1 VA: 0x3392AA0
	|-ValueTuple<object>.System.Collections.IStructuralEquatable.GetHashCode
	*/

	// RVA: -1 Offset: -1 Slot: 10
	private int System.IValueTupleInternal.GetHashCode(IEqualityComparer comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3391F40 Offset: 0x3392041 VA: 0x3391F40
	|-ValueTuple<ValueTuple<bool, object>>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x3392B50 Offset: 0x3392C51 VA: 0x3392B50
	|-ValueTuple<object>.System.IValueTupleInternal.GetHashCode
	*/

	// RVA: -1 Offset: -1 Slot: 3
	public override string ToString() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3392040 Offset: 0x3392141 VA: 0x3392040
	|-ValueTuple<ValueTuple<bool, object>>.ToString
	|
	|-RVA: 0x3392C00 Offset: 0x3392D01 VA: 0x3392C00
	|-ValueTuple<object>.ToString
	*/

	// RVA: -1 Offset: -1 Slot: 11
	private string System.IValueTupleInternal.ToStringEnd() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3392120 Offset: 0x3392221 VA: 0x3392120
	|-ValueTuple<ValueTuple<bool, object>>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x3392C90 Offset: 0x3392D91 VA: 0x3392C90
	|-ValueTuple<object>.System.IValueTupleInternal.ToStringEnd
	*/

	// RVA: -1 Offset: -1 Slot: 12
	private int System.Runtime.CompilerServices.ITuple.get_Length() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x33921E0 Offset: 0x33922E1 VA: 0x33921E0
	|-ValueTuple<ValueTuple<bool, object>>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x3392CF0 Offset: 0x3392DF1 VA: 0x3392CF0
	|-ValueTuple<object>.System.Runtime.CompilerServices.ITuple.get_Length
	*/
}

// Namespace: System
[Serializable]
public struct ValueTuple<T1, T2, T3> : IEquatable<ValueTuple<T1, T2, T3>>, IStructuralEquatable, IStructuralComparable, IComparable, IComparable<ValueTuple<T1, T2, T3>>, IValueTupleInternal, ITuple // TypeDefIndex: 108
{
	// Fields
	public T1 Item1; // 0x0
	public T2 Item2; // 0x0
	public T3 Item3; // 0x0

	// Properties
	private int System.Runtime.CompilerServices.ITuple.Length { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(T1 item1, T2 item2, T3 item3) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3894750 Offset: 0x3894851 VA: 0x3894750
	|-ValueTuple<UniTask<object>, UniTask<object>, UniTask<object>>..ctor
	|
	|-RVA: 0x3899140 Offset: 0x3899241 VA: 0x3899140
	|-ValueTuple<ItemData.Kinds[], WeaponLevel.Kind, int>..ctor
	|-ValueTuple<object, Int32Enum, int>..ctor
	|
	|-RVA: 0x38961C0 Offset: 0x38962C1 VA: 0x38961C0
	|-ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>..ctor
	|
	|-RVA: 0x3897B20 Offset: 0x3897C21 VA: 0x3897B20
	|-ValueTuple<int, DateTime, object>..ctor
	|-ValueTuple<int, DateTime, string>..ctor
	|
	|-RVA: 0x389A850 Offset: 0x389A951 VA: 0x389A850
	|-ValueTuple<object, object, int>..ctor
	|-ValueTuple<WebHeaderCollection, byte[], int>..ctor
	|
	|-RVA: 0x389BDE0 Offset: 0x389BEE1 VA: 0x389BDE0
	|-ValueTuple<object, object, object>..ctor
	|-ValueTuple<string, string, string>..ctor
	|-ValueTuple<ServicePointScheduler.ConnectionGroup, WebConnection, Task>..ctor
	|
	|-RVA: 0x389D270 Offset: 0x389D371 VA: 0x389D270
	|-ValueTuple<Vector4, Vector4, Vector4>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 0
	public override bool Equals(object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x38947C0 Offset: 0x38948C1 VA: 0x38947C0
	|-ValueTuple<UniTask<object>, UniTask<object>, UniTask<object>>.Equals
	|
	|-RVA: 0x3896210 Offset: 0x3896311 VA: 0x3896210
	|-ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>.Equals
	|
	|-RVA: 0x3897B40 Offset: 0x3897C41 VA: 0x3897B40
	|-ValueTuple<int, DateTime, object>.Equals
	|
	|-RVA: 0x3899180 Offset: 0x3899281 VA: 0x3899180
	|-ValueTuple<object, Int32Enum, int>.Equals
	|
	|-RVA: 0x389A8A0 Offset: 0x389A9A1 VA: 0x389A8A0
	|-ValueTuple<object, object, int>.Equals
	|
	|-RVA: 0x389BE30 Offset: 0x389BF31 VA: 0x389BE30
	|-ValueTuple<object, object, object>.Equals
	|
	|-RVA: 0x389D2B0 Offset: 0x389D3B1 VA: 0x389D2B0
	|-ValueTuple<Vector4, Vector4, Vector4>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public bool Equals(ValueTuple<T1, T2, T3> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3894920 Offset: 0x3894A21 VA: 0x3894920
	|-ValueTuple<UniTask<object>, UniTask<object>, UniTask<object>>.Equals
	|
	|-RVA: 0x3896370 Offset: 0x3896471 VA: 0x3896370
	|-ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>.Equals
	|
	|-RVA: 0x3897C90 Offset: 0x3897D91 VA: 0x3897C90
	|-ValueTuple<int, DateTime, object>.Equals
	|
	|-RVA: 0x38992B0 Offset: 0x38993B1 VA: 0x38992B0
	|-ValueTuple<object, Int32Enum, int>.Equals
	|
	|-RVA: 0x389A9F0 Offset: 0x389AAF1 VA: 0x389A9F0
	|-ValueTuple<object, object, int>.Equals
	|
	|-RVA: 0x389BF80 Offset: 0x389C081 VA: 0x389BF80
	|-ValueTuple<object, object, object>.Equals
	|
	|-RVA: 0x389D410 Offset: 0x389D511 VA: 0x389D410
	|-ValueTuple<Vector4, Vector4, Vector4>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private bool System.Collections.IStructuralEquatable.Equals(object other, IEqualityComparer comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3894A80 Offset: 0x3894B81 VA: 0x3894A80
	|-ValueTuple<UniTask<object>, UniTask<object>, UniTask<object>>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x38964D0 Offset: 0x38965D1 VA: 0x38964D0
	|-ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x3897DF0 Offset: 0x3897EF1 VA: 0x3897DF0
	|-ValueTuple<int, DateTime, object>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x3899410 Offset: 0x3899511 VA: 0x3899410
	|-ValueTuple<object, Int32Enum, int>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x389AB50 Offset: 0x389AC51 VA: 0x389AB50
	|-ValueTuple<object, object, int>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x389C0E0 Offset: 0x389C1E1 VA: 0x389C0E0
	|-ValueTuple<object, object, object>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x389D580 Offset: 0x389D681 VA: 0x389D580
	|-ValueTuple<Vector4, Vector4, Vector4>.System.Collections.IStructuralEquatable.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private int System.IComparable.CompareTo(object other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3894E80 Offset: 0x3894F81 VA: 0x3894E80
	|-ValueTuple<UniTask<object>, UniTask<object>, UniTask<object>>.System.IComparable.CompareTo
	|
	|-RVA: 0x38968D0 Offset: 0x38969D1 VA: 0x38968D0
	|-ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>.System.IComparable.CompareTo
	|
	|-RVA: 0x3898160 Offset: 0x3898261 VA: 0x3898160
	|-ValueTuple<int, DateTime, object>.System.IComparable.CompareTo
	|
	|-RVA: 0x3899780 Offset: 0x3899881 VA: 0x3899780
	|-ValueTuple<object, Int32Enum, int>.System.IComparable.CompareTo
	|
	|-RVA: 0x389AE40 Offset: 0x389AF41 VA: 0x389AE40
	|-ValueTuple<object, object, int>.System.IComparable.CompareTo
	|
	|-RVA: 0x389C350 Offset: 0x389C451 VA: 0x389C350
	|-ValueTuple<object, object, object>.System.IComparable.CompareTo
	|
	|-RVA: 0x389D9F0 Offset: 0x389DAF1 VA: 0x389D9F0
	|-ValueTuple<Vector4, Vector4, Vector4>.System.IComparable.CompareTo
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public int CompareTo(ValueTuple<T1, T2, T3> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3895080 Offset: 0x3895181 VA: 0x3895080
	|-ValueTuple<UniTask<object>, UniTask<object>, UniTask<object>>.CompareTo
	|
	|-RVA: 0x3896AD0 Offset: 0x3896BD1 VA: 0x3896AD0
	|-ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>.CompareTo
	|
	|-RVA: 0x3898340 Offset: 0x3898441 VA: 0x3898340
	|-ValueTuple<int, DateTime, object>.CompareTo
	|
	|-RVA: 0x3899950 Offset: 0x3899A51 VA: 0x3899950
	|-ValueTuple<object, Int32Enum, int>.CompareTo
	|
	|-RVA: 0x389B020 Offset: 0x389B121 VA: 0x389B020
	|-ValueTuple<object, object, int>.CompareTo
	|
	|-RVA: 0x389C530 Offset: 0x389C631 VA: 0x389C530
	|-ValueTuple<object, object, object>.CompareTo
	|
	|-RVA: 0x389DBF0 Offset: 0x389DCF1 VA: 0x389DBF0
	|-ValueTuple<Vector4, Vector4, Vector4>.CompareTo
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private int System.Collections.IStructuralComparable.CompareTo(object other, IComparer comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x38951E0 Offset: 0x38952E1 VA: 0x38951E0
	|-ValueTuple<UniTask<object>, UniTask<object>, UniTask<object>>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x3896C30 Offset: 0x3896D31 VA: 0x3896C30
	|-ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x38984A0 Offset: 0x38985A1 VA: 0x38984A0
	|-ValueTuple<int, DateTime, object>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x3899AB0 Offset: 0x3899BB1 VA: 0x3899AB0
	|-ValueTuple<object, Int32Enum, int>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x389B180 Offset: 0x389B281 VA: 0x389B180
	|-ValueTuple<object, object, int>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x389C690 Offset: 0x389C791 VA: 0x389C690
	|-ValueTuple<object, object, object>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x389DD60 Offset: 0x389DE61 VA: 0x389DD60
	|-ValueTuple<Vector4, Vector4, Vector4>.System.Collections.IStructuralComparable.CompareTo
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public override int GetHashCode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3895690 Offset: 0x3895791 VA: 0x3895690
	|-ValueTuple<UniTask<object>, UniTask<object>, UniTask<object>>.GetHashCode
	|
	|-RVA: 0x38970E0 Offset: 0x38971E1 VA: 0x38970E0
	|-ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>.GetHashCode
	|
	|-RVA: 0x38988B0 Offset: 0x38989B1 VA: 0x38988B0
	|-ValueTuple<int, DateTime, object>.GetHashCode
	|
	|-RVA: 0x3899EC0 Offset: 0x3899FC1 VA: 0x3899EC0
	|-ValueTuple<object, Int32Enum, int>.GetHashCode
	|
	|-RVA: 0x389B520 Offset: 0x389B621 VA: 0x389B520
	|-ValueTuple<object, object, int>.GetHashCode
	|
	|-RVA: 0x389C9C0 Offset: 0x389CAC1 VA: 0x389C9C0
	|-ValueTuple<object, object, object>.GetHashCode
	|
	|-RVA: 0x389E280 Offset: 0x389E381 VA: 0x389E280
	|-ValueTuple<Vector4, Vector4, Vector4>.GetHashCode
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private int System.Collections.IStructuralEquatable.GetHashCode(IEqualityComparer comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x38957E0 Offset: 0x38958E1 VA: 0x38957E0
	|-ValueTuple<UniTask<object>, UniTask<object>, UniTask<object>>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x38971E0 Offset: 0x38972E1 VA: 0x38971E0
	|-ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x3898920 Offset: 0x3898A21 VA: 0x3898920
	|-ValueTuple<int, DateTime, object>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x3899F90 Offset: 0x389A091 VA: 0x3899F90
	|-ValueTuple<object, Int32Enum, int>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x389B5B0 Offset: 0x389B6B1 VA: 0x389B5B0
	|-ValueTuple<object, object, int>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x389CA60 Offset: 0x389CB61 VA: 0x389CA60
	|-ValueTuple<object, object, object>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x389E2E0 Offset: 0x389E3E1 VA: 0x389E2E0
	|-ValueTuple<Vector4, Vector4, Vector4>.System.Collections.IStructuralEquatable.GetHashCode
	*/

	// RVA: -1 Offset: -1
	private int GetHashCodeCore(IEqualityComparer comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3895830 Offset: 0x3895931 VA: 0x3895830
	|-ValueTuple<UniTask<object>, UniTask<object>, UniTask<object>>.GetHashCodeCore
	|
	|-RVA: 0x3897230 Offset: 0x3897331 VA: 0x3897230
	|-ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>.GetHashCodeCore
	|
	|-RVA: 0x3898970 Offset: 0x3898A71 VA: 0x3898970
	|-ValueTuple<int, DateTime, object>.GetHashCodeCore
	|
	|-RVA: 0x3899FE0 Offset: 0x389A0E1 VA: 0x3899FE0
	|-ValueTuple<object, Int32Enum, int>.GetHashCodeCore
	|
	|-RVA: 0x389B600 Offset: 0x389B701 VA: 0x389B600
	|-ValueTuple<object, object, int>.GetHashCodeCore
	|
	|-RVA: 0x389CAA0 Offset: 0x389CBA1 VA: 0x389CAA0
	|-ValueTuple<object, object, object>.GetHashCodeCore
	|
	|-RVA: 0x389E330 Offset: 0x389E431 VA: 0x389E330
	|-ValueTuple<Vector4, Vector4, Vector4>.GetHashCodeCore
	*/

	// RVA: -1 Offset: -1 Slot: 10
	private int System.IValueTupleInternal.GetHashCode(IEqualityComparer comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3895AA0 Offset: 0x3895BA1 VA: 0x3895AA0
	|-ValueTuple<UniTask<object>, UniTask<object>, UniTask<object>>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x38974A0 Offset: 0x38975A1 VA: 0x38974A0
	|-ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x3898BA0 Offset: 0x3898CA1 VA: 0x3898BA0
	|-ValueTuple<int, DateTime, object>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x389A210 Offset: 0x389A311 VA: 0x389A210
	|-ValueTuple<object, Int32Enum, int>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x389B7F0 Offset: 0x389B8F1 VA: 0x389B7F0
	|-ValueTuple<object, object, int>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x389CC40 Offset: 0x389CD41 VA: 0x389CC40
	|-ValueTuple<object, object, object>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x389E5C0 Offset: 0x389E6C1 VA: 0x389E5C0
	|-ValueTuple<Vector4, Vector4, Vector4>.System.IValueTupleInternal.GetHashCode
	*/

	// RVA: -1 Offset: -1 Slot: 3
	public override string ToString() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3895AF0 Offset: 0x3895BF1 VA: 0x3895AF0
	|-ValueTuple<UniTask<object>, UniTask<object>, UniTask<object>>.ToString
	|
	|-RVA: 0x38974F0 Offset: 0x38975F1 VA: 0x38974F0
	|-ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>.ToString
	|
	|-RVA: 0x3898BF0 Offset: 0x3898CF1 VA: 0x3898BF0
	|-ValueTuple<int, DateTime, object>.ToString
	|
	|-RVA: 0x389A260 Offset: 0x389A361 VA: 0x389A260
	|-ValueTuple<object, Int32Enum, int>.ToString
	|
	|-RVA: 0x389B840 Offset: 0x389B941 VA: 0x389B840
	|-ValueTuple<object, object, int>.ToString
	|
	|-RVA: 0x389CC80 Offset: 0x389CD81 VA: 0x389CC80
	|-ValueTuple<object, object, object>.ToString
	|
	|-RVA: 0x389E610 Offset: 0x389E711 VA: 0x389E610
	|-ValueTuple<Vector4, Vector4, Vector4>.ToString
	*/

	// RVA: -1 Offset: -1 Slot: 11
	private string System.IValueTupleInternal.ToStringEnd() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3895E80 Offset: 0x3895F81 VA: 0x3895E80
	|-ValueTuple<UniTask<object>, UniTask<object>, UniTask<object>>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x3897830 Offset: 0x3897931 VA: 0x3897830
	|-ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x3898EC0 Offset: 0x3898FC1 VA: 0x3898EC0
	|-ValueTuple<int, DateTime, object>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x389A580 Offset: 0x389A681 VA: 0x389A580
	|-ValueTuple<object, Int32Enum, int>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x389BB30 Offset: 0x389BC31 VA: 0x389BB30
	|-ValueTuple<object, object, int>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x389CFA0 Offset: 0x389D0A1 VA: 0x389CFA0
	|-ValueTuple<object, object, object>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x389E8B0 Offset: 0x389E9B1 VA: 0x389E8B0
	|-ValueTuple<Vector4, Vector4, Vector4>.System.IValueTupleInternal.ToStringEnd
	*/

	// RVA: -1 Offset: -1 Slot: 12
	private int System.Runtime.CompilerServices.ITuple.get_Length() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x38961B0 Offset: 0x38962B1 VA: 0x38961B0
	|-ValueTuple<UniTask<object>, UniTask<object>, UniTask<object>>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x3897B10 Offset: 0x3897C11 VA: 0x3897B10
	|-ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x3899130 Offset: 0x3899231 VA: 0x3899130
	|-ValueTuple<int, DateTime, object>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x389A840 Offset: 0x389A941 VA: 0x389A840
	|-ValueTuple<object, Int32Enum, int>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x389BDD0 Offset: 0x389BED1 VA: 0x389BDD0
	|-ValueTuple<object, object, int>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x389D260 Offset: 0x389D361 VA: 0x389D260
	|-ValueTuple<object, object, object>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x389EAF0 Offset: 0x389EBF1 VA: 0x389EAF0
	|-ValueTuple<Vector4, Vector4, Vector4>.System.Runtime.CompilerServices.ITuple.get_Length
	*/
}

// Namespace: System
[Serializable]
public struct ValueTuple<T1, T2, T3, T4, T5> : IEquatable<ValueTuple<T1, T2, T3, T4, T5>>, IStructuralEquatable, IStructuralComparable, IComparable, IComparable<ValueTuple<T1, T2, T3, T4, T5>>, IValueTupleInternal, ITuple // TypeDefIndex: 110
{
	// Fields
	public T1 Item1; // 0x0
	public T2 Item2; // 0x0
	public T3 Item3; // 0x0
	public T4 Item4; // 0x0
	public T5 Item5; // 0x0

	// Properties
	private int System.Runtime.CompilerServices.ITuple.Length { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x38A7740 Offset: 0x38A7841 VA: 0x38A7740
	|-ValueTuple<UniTask<object>, UniTask<object>, UniTask<object>, UniTask<object>, UniTask<object>>..ctor
	|
	|-RVA: 0x3A341F0 Offset: 0x3A342F1 VA: 0x3A341F0
	|-ValueTuple<HttpWebResponse, bool, bool, BufferOffsetSize, WebOperation>..ctor
	|-ValueTuple<object, bool, bool, object, object>..ctor
	|
	|-RVA: 0x38A9D00 Offset: 0x38A9E01 VA: 0x38A9D00
	|-ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>..ctor
	|
	|-RVA: 0x3A35FF0 Offset: 0x3A360F1 VA: 0x3A35FF0
	|-ValueTuple<object, object, object, object, object>..ctor
	|
	|-RVA: 0x3A37C20 Offset: 0x3A37D21 VA: 0x3A37C20
	|-ValueTuple<float, float, float, Int32Enum, Int32Enum>..ctor
	|-ValueTuple<float, float, float, LocationParams.UnitType, LocationParams.EmblemType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 0
	public override bool Equals(object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x38A77F0 Offset: 0x38A78F1 VA: 0x38A77F0
	|-ValueTuple<UniTask<object>, UniTask<object>, UniTask<object>, UniTask<object>, UniTask<object>>.Equals
	|
	|-RVA: 0x38A9DA0 Offset: 0x38A9EA1 VA: 0x38A9DA0
	|-ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>.Equals
	|
	|-RVA: 0x3A34260 Offset: 0x3A34361 VA: 0x3A34260
	|-ValueTuple<object, bool, bool, object, object>.Equals
	|
	|-RVA: 0x3A36070 Offset: 0x3A36171 VA: 0x3A36070
	|-ValueTuple<object, object, object, object, object>.Equals
	|
	|-RVA: 0x3A37C40 Offset: 0x3A37D41 VA: 0x3A37C40
	|-ValueTuple<float, float, float, Int32Enum, Int32Enum>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public bool Equals(ValueTuple<T1, T2, T3, T4, T5> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x38A7970 Offset: 0x38A7A71 VA: 0x38A7970
	|-ValueTuple<UniTask<object>, UniTask<object>, UniTask<object>, UniTask<object>, UniTask<object>>.Equals
	|
	|-RVA: 0x38A9F20 Offset: 0x38AA021 VA: 0x38A9F20
	|-ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>.Equals
	|
	|-RVA: 0x3A343B0 Offset: 0x3A344B1 VA: 0x3A343B0
	|-ValueTuple<object, bool, bool, object, object>.Equals
	|
	|-RVA: 0x3A361D0 Offset: 0x3A362D1 VA: 0x3A361D0
	|-ValueTuple<object, object, object, object, object>.Equals
	|
	|-RVA: 0x3A37D90 Offset: 0x3A37E91 VA: 0x3A37D90
	|-ValueTuple<float, float, float, Int32Enum, Int32Enum>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private bool System.Collections.IStructuralEquatable.Equals(object other, IEqualityComparer comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x38A7B80 Offset: 0x38A7C81 VA: 0x38A7B80
	|-ValueTuple<UniTask<object>, UniTask<object>, UniTask<object>, UniTask<object>, UniTask<object>>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x38AA130 Offset: 0x38AA231 VA: 0x38AA130
	|-ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x3A345D0 Offset: 0x3A346D1 VA: 0x3A345D0
	|-ValueTuple<object, bool, bool, object, object>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x3A363E0 Offset: 0x3A364E1 VA: 0x3A363E0
	|-ValueTuple<object, object, object, object, object>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x3A37FA0 Offset: 0x3A380A1 VA: 0x3A37FA0
	|-ValueTuple<float, float, float, Int32Enum, Int32Enum>.System.Collections.IStructuralEquatable.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private int System.IComparable.CompareTo(object other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x38A8180 Offset: 0x38A8281 VA: 0x38A8180
	|-ValueTuple<UniTask<object>, UniTask<object>, UniTask<object>, UniTask<object>, UniTask<object>>.System.IComparable.CompareTo
	|
	|-RVA: 0x38AA730 Offset: 0x38AA831 VA: 0x38AA730
	|-ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>.System.IComparable.CompareTo
	|
	|-RVA: 0x3A34A30 Offset: 0x3A34B31 VA: 0x3A34A30
	|-ValueTuple<object, bool, bool, object, object>.System.IComparable.CompareTo
	|
	|-RVA: 0x3A36730 Offset: 0x3A36831 VA: 0x3A36730
	|-ValueTuple<object, object, object, object, object>.System.IComparable.CompareTo
	|
	|-RVA: 0x3A38570 Offset: 0x3A38671 VA: 0x3A38570
	|-ValueTuple<float, float, float, Int32Enum, Int32Enum>.System.IComparable.CompareTo
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public int CompareTo(ValueTuple<T1, T2, T3, T4, T5> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x38A83B0 Offset: 0x38A84B1 VA: 0x38A83B0
	|-ValueTuple<UniTask<object>, UniTask<object>, UniTask<object>, UniTask<object>, UniTask<object>>.CompareTo
	|
	|-RVA: 0x38AA960 Offset: 0x38AAA61 VA: 0x38AA960
	|-ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>.CompareTo
	|
	|-RVA: 0x3A34C10 Offset: 0x3A34D11 VA: 0x3A34C10
	|-ValueTuple<object, bool, bool, object, object>.CompareTo
	|
	|-RVA: 0x3A36930 Offset: 0x3A36A31 VA: 0x3A36930
	|-ValueTuple<object, object, object, object, object>.CompareTo
	|
	|-RVA: 0x3A38750 Offset: 0x3A38851 VA: 0x3A38750
	|-ValueTuple<float, float, float, Int32Enum, Int32Enum>.CompareTo
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private int System.Collections.IStructuralComparable.CompareTo(object other, IComparer comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x38A85C0 Offset: 0x38A86C1 VA: 0x38A85C0
	|-ValueTuple<UniTask<object>, UniTask<object>, UniTask<object>, UniTask<object>, UniTask<object>>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x38AAB70 Offset: 0x38AAC71 VA: 0x38AAB70
	|-ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x3A34E30 Offset: 0x3A34F31 VA: 0x3A34E30
	|-ValueTuple<object, bool, bool, object, object>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x3A36B40 Offset: 0x3A36C41 VA: 0x3A36B40
	|-ValueTuple<object, object, object, object, object>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x3A38960 Offset: 0x3A38A61 VA: 0x3A38960
	|-ValueTuple<float, float, float, Int32Enum, Int32Enum>.System.Collections.IStructuralComparable.CompareTo
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public override int GetHashCode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x38A8C80 Offset: 0x38A8D81 VA: 0x38A8C80
	|-ValueTuple<UniTask<object>, UniTask<object>, UniTask<object>, UniTask<object>, UniTask<object>>.GetHashCode
	|
	|-RVA: 0x38AB240 Offset: 0x38AB341 VA: 0x38AB240
	|-ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>.GetHashCode
	|
	|-RVA: 0x3A35340 Offset: 0x3A35441 VA: 0x3A35340
	|-ValueTuple<object, bool, bool, object, object>.GetHashCode
	|
	|-RVA: 0x3A36F60 Offset: 0x3A37061 VA: 0x3A36F60
	|-ValueTuple<object, object, object, object, object>.GetHashCode
	|
	|-RVA: 0x3A38FD0 Offset: 0x3A390D1 VA: 0x3A38FD0
	|-ValueTuple<float, float, float, Int32Enum, Int32Enum>.GetHashCode
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private int System.Collections.IStructuralEquatable.GetHashCode(IEqualityComparer comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x38A8E80 Offset: 0x38A8F81 VA: 0x38A8E80
	|-ValueTuple<UniTask<object>, UniTask<object>, UniTask<object>, UniTask<object>, UniTask<object>>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x38AB3F0 Offset: 0x38AB4F1 VA: 0x38AB3F0
	|-ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x3A35410 Offset: 0x3A35511 VA: 0x3A35410
	|-ValueTuple<object, bool, bool, object, object>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x3A37050 Offset: 0x3A37151 VA: 0x3A37050
	|-ValueTuple<object, object, object, object, object>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x3A390F0 Offset: 0x3A391F1 VA: 0x3A390F0
	|-ValueTuple<float, float, float, Int32Enum, Int32Enum>.System.Collections.IStructuralEquatable.GetHashCode
	*/

	// RVA: -1 Offset: -1
	private int GetHashCodeCore(IEqualityComparer comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x38A8ED0 Offset: 0x38A8FD1 VA: 0x38A8ED0
	|-ValueTuple<UniTask<object>, UniTask<object>, UniTask<object>, UniTask<object>, UniTask<object>>.GetHashCodeCore
	|
	|-RVA: 0x38AB440 Offset: 0x38AB541 VA: 0x38AB440
	|-ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>.GetHashCodeCore
	|
	|-RVA: 0x3A35460 Offset: 0x3A35561 VA: 0x3A35460
	|-ValueTuple<object, bool, bool, object, object>.GetHashCodeCore
	|
	|-RVA: 0x3A37090 Offset: 0x3A37191 VA: 0x3A37090
	|-ValueTuple<object, object, object, object, object>.GetHashCodeCore
	|
	|-RVA: 0x3A39140 Offset: 0x3A39241 VA: 0x3A39140
	|-ValueTuple<float, float, float, Int32Enum, Int32Enum>.GetHashCodeCore
	*/

	// RVA: -1 Offset: -1 Slot: 10
	private int System.IValueTupleInternal.GetHashCode(IEqualityComparer comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x38A92A0 Offset: 0x38A93A1 VA: 0x38A92A0
	|-ValueTuple<UniTask<object>, UniTask<object>, UniTask<object>, UniTask<object>, UniTask<object>>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x38AB810 Offset: 0x38AB911 VA: 0x38AB810
	|-ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x3A35770 Offset: 0x3A35871 VA: 0x3A35770
	|-ValueTuple<object, bool, bool, object, object>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x3A37310 Offset: 0x3A37411 VA: 0x3A37310
	|-ValueTuple<object, object, object, object, object>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x3A39510 Offset: 0x3A39611 VA: 0x3A39510
	|-ValueTuple<float, float, float, Int32Enum, Int32Enum>.System.IValueTupleInternal.GetHashCode
	*/

	// RVA: -1 Offset: -1 Slot: 3
	public override string ToString() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x38A92F0 Offset: 0x38A93F1 VA: 0x38A92F0
	|-ValueTuple<UniTask<object>, UniTask<object>, UniTask<object>, UniTask<object>, UniTask<object>>.ToString
	|
	|-RVA: 0x38AB860 Offset: 0x38AB961 VA: 0x38AB860
	|-ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>.ToString
	|
	|-RVA: 0x3A357C0 Offset: 0x3A358C1 VA: 0x3A357C0
	|-ValueTuple<object, bool, bool, object, object>.ToString
	|
	|-RVA: 0x3A37350 Offset: 0x3A37451 VA: 0x3A37350
	|-ValueTuple<object, object, object, object, object>.ToString
	|
	|-RVA: 0x3A39560 Offset: 0x3A39661 VA: 0x3A39560
	|-ValueTuple<float, float, float, Int32Enum, Int32Enum>.ToString
	*/

	// RVA: -1 Offset: -1 Slot: 11
	private string System.IValueTupleInternal.ToStringEnd() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x38A9820 Offset: 0x38A9921 VA: 0x38A9820
	|-ValueTuple<UniTask<object>, UniTask<object>, UniTask<object>, UniTask<object>, UniTask<object>>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x38ABD30 Offset: 0x38ABE31 VA: 0x38ABD30
	|-ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x3A35C00 Offset: 0x3A35D01 VA: 0x3A35C00
	|-ValueTuple<object, bool, bool, object, object>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x3A377E0 Offset: 0x3A378E1 VA: 0x3A377E0
	|-ValueTuple<object, object, object, object, object>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x3A399A0 Offset: 0x3A39AA1 VA: 0x3A399A0
	|-ValueTuple<float, float, float, Int32Enum, Int32Enum>.System.IValueTupleInternal.ToStringEnd
	*/

	// RVA: -1 Offset: -1 Slot: 12
	private int System.Runtime.CompilerServices.ITuple.get_Length() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x38A9CF0 Offset: 0x38A9DF1 VA: 0x38A9CF0
	|-ValueTuple<UniTask<object>, UniTask<object>, UniTask<object>, UniTask<object>, UniTask<object>>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x38AC1B0 Offset: 0x38AC2B1 VA: 0x38AC1B0
	|-ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x3A35FE0 Offset: 0x3A360E1 VA: 0x3A35FE0
	|-ValueTuple<object, bool, bool, object, object>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x3A37C10 Offset: 0x3A37D11 VA: 0x3A37C10
	|-ValueTuple<object, object, object, object, object>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x3A39D90 Offset: 0x3A39E91 VA: 0x3A39D90
	|-ValueTuple<float, float, float, Int32Enum, Int32Enum>.System.Runtime.CompilerServices.ITuple.get_Length
	*/
}

// Namespace: System
[Serializable]
public struct ValueTuple<T1, T2, T3, T4, T5, T6, T7> : IEquatable<ValueTuple<T1, T2, T3, T4, T5, T6, T7>>, IStructuralEquatable, IStructuralComparable, IComparable, IComparable<ValueTuple<T1, T2, T3, T4, T5, T6, T7>>, IValueTupleInternal, ITuple // TypeDefIndex: 112
{
	// Fields
	public T1 Item1; // 0x0
	public T2 Item2; // 0x0
	public T3 Item3; // 0x0
	public T4 Item4; // 0x0
	public T5 Item5; // 0x0
	public T6 Item6; // 0x0
	public T7 Item7; // 0x0

	// Properties
	private int System.Runtime.CompilerServices.ITuple.Length { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3A413B0 Offset: 0x3A414B1 VA: 0x3A413B0
	|-ValueTuple<UniTask<object>, UniTask<object>, UniTask<object>, UniTask<object>, UniTask<object>, UniTask<object>, UniTask<object>>..ctor
	|
	|-RVA: 0x3A44540 Offset: 0x3A44641 VA: 0x3A44540
	|-ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>..ctor
	|
	|-RVA: 0x3A47590 Offset: 0x3A47691 VA: 0x3A47590
	|-ValueTuple<object, object, object, object, object, object, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 0
	public override bool Equals(object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3A414C0 Offset: 0x3A415C1 VA: 0x3A414C0
	|-ValueTuple<UniTask<object>, UniTask<object>, UniTask<object>, UniTask<object>, UniTask<object>, UniTask<object>, UniTask<object>>.Equals
	|
	|-RVA: 0x3A44620 Offset: 0x3A44721 VA: 0x3A44620
	|-ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>.Equals
	|
	|-RVA: 0x3A47640 Offset: 0x3A47741 VA: 0x3A47640
	|-ValueTuple<object, object, object, object, object, object, object>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public bool Equals(ValueTuple<T1, T2, T3, T4, T5, T6, T7> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3A41670 Offset: 0x3A41771 VA: 0x3A41670
	|-ValueTuple<UniTask<object>, UniTask<object>, UniTask<object>, UniTask<object>, UniTask<object>, UniTask<object>, UniTask<object>>.Equals
	|
	|-RVA: 0x3A447C0 Offset: 0x3A448C1 VA: 0x3A447C0
	|-ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>.Equals
	|
	|-RVA: 0x3A477B0 Offset: 0x3A478B1 VA: 0x3A477B0
	|-ValueTuple<object, object, object, object, object, object, object>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private bool System.Collections.IStructuralEquatable.Equals(object other, IEqualityComparer comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3A41940 Offset: 0x3A41A41 VA: 0x3A41940
	|-ValueTuple<UniTask<object>, UniTask<object>, UniTask<object>, UniTask<object>, UniTask<object>, UniTask<object>, UniTask<object>>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x3A44A90 Offset: 0x3A44B91 VA: 0x3A44A90
	|-ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x3A47A80 Offset: 0x3A47B81 VA: 0x3A47A80
	|-ValueTuple<object, object, object, object, object, object, object>.System.Collections.IStructuralEquatable.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private int System.IComparable.CompareTo(object other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3A42150 Offset: 0x3A42251 VA: 0x3A42150
	|-ValueTuple<UniTask<object>, UniTask<object>, UniTask<object>, UniTask<object>, UniTask<object>, UniTask<object>, UniTask<object>>.System.IComparable.CompareTo
	|
	|-RVA: 0x3A452A0 Offset: 0x3A453A1 VA: 0x3A452A0
	|-ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>.System.IComparable.CompareTo
	|
	|-RVA: 0x3A47EC0 Offset: 0x3A47FC1 VA: 0x3A47EC0
	|-ValueTuple<object, object, object, object, object, object, object>.System.IComparable.CompareTo
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public int CompareTo(ValueTuple<T1, T2, T3, T4, T5, T6, T7> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3A423B0 Offset: 0x3A424B1 VA: 0x3A423B0
	|-ValueTuple<UniTask<object>, UniTask<object>, UniTask<object>, UniTask<object>, UniTask<object>, UniTask<object>, UniTask<object>>.CompareTo
	|
	|-RVA: 0x3A45500 Offset: 0x3A45601 VA: 0x3A45500
	|-ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>.CompareTo
	|
	|-RVA: 0x3A480D0 Offset: 0x3A481D1 VA: 0x3A480D0
	|-ValueTuple<object, object, object, object, object, object, object>.CompareTo
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private int System.Collections.IStructuralComparable.CompareTo(object other, IComparer comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3A42680 Offset: 0x3A42781 VA: 0x3A42680
	|-ValueTuple<UniTask<object>, UniTask<object>, UniTask<object>, UniTask<object>, UniTask<object>, UniTask<object>, UniTask<object>>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x3A457D0 Offset: 0x3A458D1 VA: 0x3A457D0
	|-ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x3A483A0 Offset: 0x3A484A1 VA: 0x3A483A0
	|-ValueTuple<object, object, object, object, object, object, object>.System.Collections.IStructuralComparable.CompareTo
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public override int GetHashCode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3A42F60 Offset: 0x3A43061 VA: 0x3A42F60
	|-ValueTuple<UniTask<object>, UniTask<object>, UniTask<object>, UniTask<object>, UniTask<object>, UniTask<object>, UniTask<object>>.GetHashCode
	|
	|-RVA: 0x3A460D0 Offset: 0x3A461D1 VA: 0x3A460D0
	|-ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>.GetHashCode
	|
	|-RVA: 0x3A488A0 Offset: 0x3A489A1 VA: 0x3A488A0
	|-ValueTuple<object, object, object, object, object, object, object>.GetHashCode
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private int System.Collections.IStructuralEquatable.GetHashCode(IEqualityComparer comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3A43220 Offset: 0x3A43321 VA: 0x3A43220
	|-ValueTuple<UniTask<object>, UniTask<object>, UniTask<object>, UniTask<object>, UniTask<object>, UniTask<object>, UniTask<object>>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x3A46330 Offset: 0x3A46431 VA: 0x3A46330
	|-ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x3A489F0 Offset: 0x3A48AF1 VA: 0x3A489F0
	|-ValueTuple<object, object, object, object, object, object, object>.System.Collections.IStructuralEquatable.GetHashCode
	*/

	// RVA: -1 Offset: -1
	private int GetHashCodeCore(IEqualityComparer comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3A43270 Offset: 0x3A43371 VA: 0x3A43270
	|-ValueTuple<UniTask<object>, UniTask<object>, UniTask<object>, UniTask<object>, UniTask<object>, UniTask<object>, UniTask<object>>.GetHashCodeCore
	|
	|-RVA: 0x3A46380 Offset: 0x3A46481 VA: 0x3A46380
	|-ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>.GetHashCodeCore
	|
	|-RVA: 0x3A48A30 Offset: 0x3A48B31 VA: 0x3A48A30
	|-ValueTuple<object, object, object, object, object, object, object>.GetHashCodeCore
	*/

	// RVA: -1 Offset: -1 Slot: 10
	private int System.IValueTupleInternal.GetHashCode(IEqualityComparer comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3A437A0 Offset: 0x3A438A1 VA: 0x3A437A0
	|-ValueTuple<UniTask<object>, UniTask<object>, UniTask<object>, UniTask<object>, UniTask<object>, UniTask<object>, UniTask<object>>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x3A468B0 Offset: 0x3A469B1 VA: 0x3A468B0
	|-ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x3A48D90 Offset: 0x3A48E91 VA: 0x3A48D90
	|-ValueTuple<object, object, object, object, object, object, object>.System.IValueTupleInternal.GetHashCode
	*/

	// RVA: -1 Offset: -1 Slot: 3
	public override string ToString() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3A437F0 Offset: 0x3A438F1 VA: 0x3A437F0
	|-ValueTuple<UniTask<object>, UniTask<object>, UniTask<object>, UniTask<object>, UniTask<object>, UniTask<object>, UniTask<object>>.ToString
	|
	|-RVA: 0x3A46900 Offset: 0x3A46A01 VA: 0x3A46900
	|-ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>.ToString
	|
	|-RVA: 0x3A48DD0 Offset: 0x3A48ED1 VA: 0x3A48DD0
	|-ValueTuple<object, object, object, object, object, object, object>.ToString
	*/

	// RVA: -1 Offset: -1 Slot: 11
	private string System.IValueTupleInternal.ToStringEnd() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3A43EC0 Offset: 0x3A43FC1 VA: 0x3A43EC0
	|-ValueTuple<UniTask<object>, UniTask<object>, UniTask<object>, UniTask<object>, UniTask<object>, UniTask<object>, UniTask<object>>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x3A46F70 Offset: 0x3A47071 VA: 0x3A46F70
	|-ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x3A493D0 Offset: 0x3A494D1 VA: 0x3A493D0
	|-ValueTuple<object, object, object, object, object, object, object>.System.IValueTupleInternal.ToStringEnd
	*/

	// RVA: -1 Offset: -1 Slot: 12
	private int System.Runtime.CompilerServices.ITuple.get_Length() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3A44530 Offset: 0x3A44631 VA: 0x3A44530
	|-ValueTuple<UniTask<object>, UniTask<object>, UniTask<object>, UniTask<object>, UniTask<object>, UniTask<object>, UniTask<object>>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x3A47580 Offset: 0x3A47681 VA: 0x3A47580
	|-ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x3A49970 Offset: 0x3A49A71 VA: 0x3A49970
	|-ValueTuple<object, object, object, object, object, object, object>.System.Runtime.CompilerServices.ITuple.get_Length
	*/
}

