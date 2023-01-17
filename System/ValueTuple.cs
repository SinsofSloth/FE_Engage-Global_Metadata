// Namespace: System
[Serializable]
public struct ValueTuple : IEquatable<ValueTuple>, IStructuralEquatable, IStructuralComparable, IComparable, IComparable<ValueTuple>, IValueTupleInternal, ITuple // TypeDefIndex: 105
{
	// Properties
	private int System.Runtime.CompilerServices.ITuple.Length { get; }

	// Methods

	// RVA: 0x34CCEE0 Offset: 0x34CCFE1 VA: 0x34CCEE0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x34CCF50 Offset: 0x34CD051 VA: 0x34CCF50 Slot: 4
	public bool Equals(ValueTuple other) { }

	// RVA: 0x34CCF60 Offset: 0x34CD061 VA: 0x34CCF60 Slot: 5
	private bool System.Collections.IStructuralEquatable.Equals(object other, IEqualityComparer comparer) { }

	// RVA: 0x34CCFD0 Offset: 0x34CD0D1 VA: 0x34CCFD0 Slot: 8
	private int System.IComparable.CompareTo(object other) { }

	// RVA: 0x34CD0F0 Offset: 0x34CD1F1 VA: 0x34CD0F0 Slot: 9
	public int CompareTo(ValueTuple other) { }

	// RVA: 0x34CD100 Offset: 0x34CD201 VA: 0x34CD100 Slot: 7
	private int System.Collections.IStructuralComparable.CompareTo(object other, IComparer comparer) { }

	// RVA: 0x34CD220 Offset: 0x34CD321 VA: 0x34CD220 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x34CD230 Offset: 0x34CD331 VA: 0x34CD230 Slot: 6
	private int System.Collections.IStructuralEquatable.GetHashCode(IEqualityComparer comparer) { }

	// RVA: 0x34CD240 Offset: 0x34CD341 VA: 0x34CD240 Slot: 10
	private int System.IValueTupleInternal.GetHashCode(IEqualityComparer comparer) { }

	// RVA: 0x34CD250 Offset: 0x34CD351 VA: 0x34CD250 Slot: 3
	public override string ToString() { }

	// RVA: 0x34CD2A0 Offset: 0x34CD3A1 VA: 0x34CD2A0 Slot: 11
	private string System.IValueTupleInternal.ToStringEnd() { }

	// RVA: 0x34CD2F0 Offset: 0x34CD3F1 VA: 0x34CD2F0 Slot: 12
	private int System.Runtime.CompilerServices.ITuple.get_Length() { }

	// RVA: 0x34CD300 Offset: 0x34CD401 VA: 0x34CD300
	internal static int CombineHashCodes(int h1, int h2) { }

	// RVA: 0x34CD390 Offset: 0x34CD491 VA: 0x34CD390
	internal static int CombineHashCodes(int h1, int h2, int h3) { }

	// RVA: 0x34CD470 Offset: 0x34CD571 VA: 0x34CD470
	internal static int CombineHashCodes(int h1, int h2, int h3, int h4) { }

	// RVA: 0x34CD510 Offset: 0x34CD611 VA: 0x34CD510
	internal static int CombineHashCodes(int h1, int h2, int h3, int h4, int h5) { }

	// RVA: 0x34CD600 Offset: 0x34CD701 VA: 0x34CD600
	internal static int CombineHashCodes(int h1, int h2, int h3, int h4, int h5, int h6) { }

	// RVA: 0x34CD6B0 Offset: 0x34CD7B1 VA: 0x34CD6B0
	internal static int CombineHashCodes(int h1, int h2, int h3, int h4, int h5, int h6, int h7) { }

	// RVA: 0x34CD7C0 Offset: 0x34CD8C1 VA: 0x34CD7C0
	internal static int CombineHashCodes(int h1, int h2, int h3, int h4, int h5, int h6, int h7, int h8) { }
}

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
public struct ValueTuple<T1, T2> : IEquatable<ValueTuple<T1, T2>>, IStructuralEquatable, IStructuralComparable, IComparable, IComparable<ValueTuple<T1, T2>>, IValueTupleInternal, ITuple // TypeDefIndex: 107
{
	// Fields
	public T1 Item1; // 0x0
	public T2 Item2; // 0x0

	// Properties
	private int System.Runtime.CompilerServices.ITuple.Length { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(T1 item1, T2 item2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x388AA10 Offset: 0x388AB11 VA: 0x388AA10
	|-ValueTuple<Task<BufferOffsetSize>, WebException>..ctor
	|-ValueTuple<AnimAsset, AnimAsset>..ctor
	|-ValueTuple<AnimationEvent, MagicSignal>..ctor
	|-ValueTuple<AnimatorOverrideController, AnimatorOverrideController>..ctor
	|-ValueTuple<Character, GameObject>..ctor
	|-ValueTuple<Character, Phase>..ctor
	|-ValueTuple<object, object>..ctor
	|-ValueTuple<string, List<string>>..ctor
	|-ValueTuple<string, string>..ctor
	|-ValueTuple<ServicePointScheduler.ConnectionGroup, WebOperation>..ctor
	|
	|-RVA: 0x3392D00 Offset: 0x3392E01 VA: 0x3392D00
	|-ValueTuple<UniTask<object>, UniTask<object>>..ctor
	|
	|-RVA: 0x3394090 Offset: 0x3394191 VA: 0x3394090
	|-ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>..ctor
	|
	|-RVA: 0x3395400 Offset: 0x3395501 VA: 0x3395400
	|-ValueTuple<bool, UniTask<object>>..ctor
	|
	|-RVA: 0x33966A0 Offset: 0x33967A1 VA: 0x33966A0
	|-ValueTuple<bool, ValueTuple<bool, UniTask<object>>>..ctor
	|
	|-RVA: 0x3397AA0 Offset: 0x3397BA1 VA: 0x3397AA0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>..ctor
	|
	|-RVA: 0x3398F10 Offset: 0x3399011 VA: 0x3398F10
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>>..ctor
	|
	|-RVA: 0x31F3790 Offset: 0x31F3891 VA: 0x31F3790
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>>>..ctor
	|
	|-RVA: 0x31F4D00 Offset: 0x31F4E01 VA: 0x31F4D00
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>>>..ctor
	|
	|-RVA: 0x31F6010 Offset: 0x31F6111 VA: 0x31F6010
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>>>..ctor
	|
	|-RVA: 0x31F7320 Offset: 0x31F7421 VA: 0x31F7320
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>>>..ctor
	|
	|-RVA: 0x31F8930 Offset: 0x31F8A31 VA: 0x31F8930
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>>>..ctor
	|
	|-RVA: 0x31F9C40 Offset: 0x31F9D41 VA: 0x31F9C40
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>>>..ctor
	|
	|-RVA: 0x31FB1C0 Offset: 0x31FB2C1 VA: 0x31FB1C0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>>>..ctor
	|
	|-RVA: 0x31FC720 Offset: 0x31FC821 VA: 0x31FC720
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>>>..ctor
	|
	|-RVA: 0x31FDB90 Offset: 0x31FDC91 VA: 0x31FDB90
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>>>..ctor
	|
	|-RVA: 0x31FF0F0 Offset: 0x31FF1F1 VA: 0x31FF0F0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>>>..ctor
	|
	|-RVA: 0x3200660 Offset: 0x3200761 VA: 0x3200660
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>>>..ctor
	|
	|-RVA: 0x3201BE0 Offset: 0x3201CE1 VA: 0x3201BE0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>>>..ctor
	|
	|-RVA: 0x3203160 Offset: 0x3203261 VA: 0x3203160
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>>>..ctor
	|
	|-RVA: 0x32045D0 Offset: 0x32046D1 VA: 0x32045D0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>>>..ctor
	|
	|-RVA: 0x3205B40 Offset: 0x3205C41 VA: 0x3205B40
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>>>..ctor
	|
	|-RVA: 0x3206E50 Offset: 0x3206F51 VA: 0x3206E50
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>>>..ctor
	|
	|-RVA: 0x3208310 Offset: 0x3208411 VA: 0x3208310
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>>>..ctor
	|
	|-RVA: 0x3209820 Offset: 0x3209921 VA: 0x3209820
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>>>..ctor
	|
	|-RVA: 0x320ADA0 Offset: 0x320AEA1 VA: 0x320ADA0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>>>..ctor
	|
	|-RVA: 0x320C310 Offset: 0x320C411 VA: 0x320C310
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>>>..ctor
	|
	|-RVA: 0x320D880 Offset: 0x320D981 VA: 0x320D880
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>>>..ctor
	|
	|-RVA: 0x320EEA0 Offset: 0x320EFA1 VA: 0x320EEA0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>>>..ctor
	|
	|-RVA: 0x3210530 Offset: 0x3210631 VA: 0x3210530
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>>>..ctor
	|
	|-RVA: 0x3211C60 Offset: 0x3211D61 VA: 0x3211C60
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>>>..ctor
	|
	|-RVA: 0x32133E0 Offset: 0x32134E1 VA: 0x32133E0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>>>..ctor
	|
	|-RVA: 0x3214C10 Offset: 0x3214D11 VA: 0x3214C10
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>>..ctor
	|
	|-RVA: 0x3215F20 Offset: 0x3216021 VA: 0x3215F20
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>>..ctor
	|
	|-RVA: 0x3217230 Offset: 0x3217331 VA: 0x3217230
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>>..ctor
	|
	|-RVA: 0x32187F0 Offset: 0x32188F1 VA: 0x32187F0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>>..ctor
	|
	|-RVA: 0x3219B00 Offset: 0x3219C01 VA: 0x3219B00
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>>..ctor
	|
	|-RVA: 0x321B010 Offset: 0x321B111 VA: 0x321B010
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>>..ctor
	|
	|-RVA: 0x3252270 Offset: 0x3252371 VA: 0x3252270
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>>..ctor
	|
	|-RVA: 0x3253670 Offset: 0x3253771 VA: 0x3253670
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>>..ctor
	|
	|-RVA: 0x3254B80 Offset: 0x3254C81 VA: 0x3254B80
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>>..ctor
	|
	|-RVA: 0x32560A0 Offset: 0x32561A1 VA: 0x32560A0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>>..ctor
	|
	|-RVA: 0x32575B0 Offset: 0x32576B1 VA: 0x32575B0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>>..ctor
	|
	|-RVA: 0x3258AC0 Offset: 0x3258BC1 VA: 0x3258AC0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>>..ctor
	|
	|-RVA: 0x3259EC0 Offset: 0x3259FC1 VA: 0x3259EC0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>>..ctor
	|
	|-RVA: 0x325B3E0 Offset: 0x325B4E1 VA: 0x325B3E0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>>..ctor
	|
	|-RVA: 0x325C6F0 Offset: 0x325C7F1 VA: 0x325C6F0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>>..ctor
	|
	|-RVA: 0x325DB60 Offset: 0x325DC61 VA: 0x325DB60
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>>..ctor
	|
	|-RVA: 0x325F020 Offset: 0x325F121 VA: 0x325F020
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>>..ctor
	|
	|-RVA: 0x3260530 Offset: 0x3260631 VA: 0x3260530
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>>..ctor
	|
	|-RVA: 0x3261A50 Offset: 0x3261B51 VA: 0x3261A50
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>>..ctor
	|
	|-RVA: 0x3262F70 Offset: 0x3263071 VA: 0x3262F70
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>..ctor
	|
	|-RVA: 0x3264600 Offset: 0x3264701 VA: 0x3264600
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>>..ctor
	|
	|-RVA: 0x3265B70 Offset: 0x3265C71 VA: 0x3265B70
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>..ctor
	|
	|-RVA: 0x32672F0 Offset: 0x32673F1 VA: 0x32672F0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>>..ctor
	|
	|-RVA: 0x3268910 Offset: 0x3268A11 VA: 0x3268910
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>..ctor
	|
	|-RVA: 0x326A1A0 Offset: 0x326A2A1 VA: 0x326A1A0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>>..ctor
	|
	|-RVA: 0x326B830 Offset: 0x326B931 VA: 0x326B830
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>..ctor
	|
	|-RVA: 0x326D1C0 Offset: 0x326D2C1 VA: 0x326D1C0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>>..ctor
	|
	|-RVA: 0x326E8F0 Offset: 0x326E9F1 VA: 0x326E8F0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>..ctor
	|
	|-RVA: 0x32700C0 Offset: 0x32701C1 VA: 0x32700C0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>>..ctor
	|
	|-RVA: 0x3271840 Offset: 0x3271941 VA: 0x3271840
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>..ctor
	|
	|-RVA: 0x3272AA0 Offset: 0x3272BA1 VA: 0x3272AA0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>..ctor
	|
	|-RVA: 0x3273D00 Offset: 0x3273E01 VA: 0x3273D00
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>..ctor
	|
	|-RVA: 0x3275280 Offset: 0x3275381 VA: 0x3275280
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>..ctor
	|
	|-RVA: 0x32764E0 Offset: 0x32765E1 VA: 0x32764E0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>..ctor
	|
	|-RVA: 0x32779A0 Offset: 0x3277AA1 VA: 0x32779A0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>..ctor
	|
	|-RVA: 0x3278E00 Offset: 0x3278F01 VA: 0x3278E00
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>..ctor
	|
	|-RVA: 0x327A0F0 Offset: 0x327A1F1 VA: 0x327A0F0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>..ctor
	|
	|-RVA: 0x32954A0 Offset: 0x32955A1 VA: 0x32954A0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>..ctor
	|
	|-RVA: 0x3296910 Offset: 0x3296A11 VA: 0x3296910
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>..ctor
	|
	|-RVA: 0x3297DD0 Offset: 0x3297ED1 VA: 0x3297DD0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>..ctor
	|
	|-RVA: 0x3299290 Offset: 0x3299391 VA: 0x3299290
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>..ctor
	|
	|-RVA: 0x329A580 Offset: 0x329A681 VA: 0x329A580
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>..ctor
	|
	|-RVA: 0x329B9F0 Offset: 0x329BAF1 VA: 0x329B9F0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>..ctor
	|
	|-RVA: 0x329CC50 Offset: 0x329CD51 VA: 0x329CC50
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>..ctor
	|
	|-RVA: 0x329E050 Offset: 0x329E151 VA: 0x329E050
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>..ctor
	|
	|-RVA: 0x329F4C0 Offset: 0x329F5C1 VA: 0x329F4C0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>..ctor
	|
	|-RVA: 0x32A0980 Offset: 0x32A0A81 VA: 0x32A0980
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>..ctor
	|
	|-RVA: 0x32A1DF0 Offset: 0x32A1EF1 VA: 0x32A1DF0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>..ctor
	|
	|-RVA: 0x32A3260 Offset: 0x32A3361 VA: 0x32A3260
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>..ctor
	|
	|-RVA: 0x32A4880 Offset: 0x32A4981 VA: 0x32A4880
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>..ctor
	|
	|-RVA: 0x32A5DA0 Offset: 0x32A5EA1 VA: 0x32A5DA0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>..ctor
	|
	|-RVA: 0x32A74D0 Offset: 0x32A75D1 VA: 0x32A74D0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>..ctor
	|
	|-RVA: 0x32A8A40 Offset: 0x32A8B41 VA: 0x32A8A40
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>..ctor
	|
	|-RVA: 0x32AA270 Offset: 0x32AA371 VA: 0x32AA270
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>..ctor
	|
	|-RVA: 0x32AB890 Offset: 0x32AB991 VA: 0x32AB890
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>..ctor
	|
	|-RVA: 0x32AD1D0 Offset: 0x32AD2D1 VA: 0x32AD1D0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>..ctor
	|
	|-RVA: 0x32AE860 Offset: 0x32AE961 VA: 0x32AE860
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>..ctor
	|
	|-RVA: 0x32B02A0 Offset: 0x32B03A1 VA: 0x32B02A0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>..ctor
	|
	|-RVA: 0x32B19D0 Offset: 0x32B1AD1 VA: 0x32B19D0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>>>..ctor
	|
	|-RVA: 0x32B2E90 Offset: 0x32B2F91 VA: 0x32B2E90
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>..ctor
	|
	|-RVA: 0x32B4350 Offset: 0x32B4451 VA: 0x32B4350
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>..ctor
	|
	|-RVA: 0x32B5610 Offset: 0x32B5711 VA: 0x32B5610
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>..ctor
	|
	|-RVA: 0x32B68D0 Offset: 0x32B69D1 VA: 0x32B68D0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>..ctor
	|
	|-RVA: 0x32B7DE0 Offset: 0x32B7EE1 VA: 0x32B7DE0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>..ctor
	|
	|-RVA: 0x32B90A0 Offset: 0x32B91A1 VA: 0x32B90A0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>..ctor
	|
	|-RVA: 0x32BA510 Offset: 0x32BA611 VA: 0x32BA510
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>..ctor
	|
	|-RVA: 0x32BB900 Offset: 0x32BBA01 VA: 0x32BB900
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>..ctor
	|
	|-RVA: 0x32BCBF0 Offset: 0x32BCCF1 VA: 0x32BCBF0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>..ctor
	|
	|-RVA: 0x33E4E40 Offset: 0x33E4F41 VA: 0x33E4E40
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>..ctor
	|
	|-RVA: 0x33E6230 Offset: 0x33E6331 VA: 0x33E6230
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>..ctor
	|
	|-RVA: 0x33E76A0 Offset: 0x33E77A1 VA: 0x33E76A0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>..ctor
	|
	|-RVA: 0x33E8B10 Offset: 0x33E8C11 VA: 0x33E8B10
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>..ctor
	|
	|-RVA: 0x33E9E00 Offset: 0x33E9F01 VA: 0x33E9E00
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>..ctor
	|
	|-RVA: 0x33EB1F0 Offset: 0x33EB2F1 VA: 0x33EB1F0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>..ctor
	|
	|-RVA: 0x33EC4B0 Offset: 0x33EC5B1 VA: 0x33EC4B0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>..ctor
	|
	|-RVA: 0x33ED7A0 Offset: 0x33ED8A1 VA: 0x33ED7A0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>..ctor
	|
	|-RVA: 0x33EEBA0 Offset: 0x33EECA1 VA: 0x33EEBA0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>..ctor
	|
	|-RVA: 0x33F0010 Offset: 0x33F0111 VA: 0x33F0010
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>..ctor
	|
	|-RVA: 0x33F1400 Offset: 0x33F1501 VA: 0x33F1400
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>..ctor
	|
	|-RVA: 0x33F2800 Offset: 0x33F2901 VA: 0x33F2800
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>..ctor
	|
	|-RVA: 0x33F3D70 Offset: 0x33F3E71 VA: 0x33F3D70
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>..ctor
	|
	|-RVA: 0x33F51E0 Offset: 0x33F52E1 VA: 0x33F51E0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>..ctor
	|
	|-RVA: 0x33F6870 Offset: 0x33F6971 VA: 0x33F6870
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>..ctor
	|
	|-RVA: 0x33F7D90 Offset: 0x33F7E91 VA: 0x33F7D90
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>..ctor
	|
	|-RVA: 0x33F9510 Offset: 0x33F9611 VA: 0x33F9510
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>..ctor
	|
	|-RVA: 0x33FAA80 Offset: 0x33FAB81 VA: 0x33FAA80
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>..ctor
	|
	|-RVA: 0x33FC310 Offset: 0x33FC411 VA: 0x33FC310
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>..ctor
	|
	|-RVA: 0x33FD930 Offset: 0x33FDA31 VA: 0x33FD930
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>..ctor
	|
	|-RVA: 0x33FF2C0 Offset: 0x33FF3C1 VA: 0x33FF2C0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>..ctor
	|
	|-RVA: 0x3400950 Offset: 0x3400A51 VA: 0x3400950
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>>..ctor
	|
	|-RVA: 0x3402120 Offset: 0x3402221 VA: 0x3402120
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>>..ctor
	|
	|-RVA: 0x34035E0 Offset: 0x34036E1 VA: 0x34035E0
	|-ValueTuple<bool, ValueTuple<bool, AsyncUnit>>..ctor
	|
	|-RVA: 0x3404840 Offset: 0x3404941 VA: 0x3404840
	|-ValueTuple<bool, ValueTuple<bool, bool>>..ctor
	|
	|-RVA: 0x3405AA0 Offset: 0x3405BA1 VA: 0x3405AA0
	|-ValueTuple<bool, ValueTuple<bool, Bounds>>..ctor
	|
	|-RVA: 0x3406F60 Offset: 0x3407061 VA: 0x3406F60
	|-ValueTuple<bool, ValueTuple<bool, byte>>..ctor
	|
	|-RVA: 0x34081C0 Offset: 0x34082C1 VA: 0x34081C0
	|-ValueTuple<bool, ValueTuple<bool, Color>>..ctor
	|
	|-RVA: 0x34095C0 Offset: 0x34096C1 VA: 0x34095C0
	|-ValueTuple<bool, ValueTuple<bool, double>>..ctor
	|
	|-RVA: 0x340A840 Offset: 0x340A941 VA: 0x340A840
	|-ValueTuple<bool, ValueTuple<bool, int>>..ctor
	|
	|-RVA: 0x340BAE0 Offset: 0x340BBE1 VA: 0x340BAE0
	|-ValueTuple<bool, ValueTuple<bool, long>>..ctor
	|
	|-RVA: 0x351A180 Offset: 0x351A281 VA: 0x351A180
	|-ValueTuple<bool, ValueTuple<bool, object>>..ctor
	|
	|-RVA: 0x351B410 Offset: 0x351B511 VA: 0x351B410
	|-ValueTuple<bool, ValueTuple<bool, Quaternion>>..ctor
	|
	|-RVA: 0x351C810 Offset: 0x351C911 VA: 0x351C810
	|-ValueTuple<bool, ValueTuple<bool, Rect>>..ctor
	|
	|-RVA: 0x351DC10 Offset: 0x351DD11 VA: 0x351DC10
	|-ValueTuple<bool, ValueTuple<bool, float>>..ctor
	|
	|-RVA: 0x351EEB0 Offset: 0x351EFB1 VA: 0x351EEB0
	|-ValueTuple<bool, ValueTuple<bool, UniTask>>..ctor
	|
	|-RVA: 0x3520140 Offset: 0x3520241 VA: 0x3520140
	|-ValueTuple<bool, ValueTuple<bool, Unit>>..ctor
	|
	|-RVA: 0x35213A0 Offset: 0x35214A1 VA: 0x35213A0
	|-ValueTuple<bool, ValueTuple<bool, Vector2>>..ctor
	|
	|-RVA: 0x3522690 Offset: 0x3522791 VA: 0x3522690
	|-ValueTuple<bool, ValueTuple<bool, Vector3>>..ctor
	|
	|-RVA: 0x3523980 Offset: 0x3523A81 VA: 0x3523980
	|-ValueTuple<bool, ValueTuple<bool, Vector4>>..ctor
	|
	|-RVA: 0x3524D80 Offset: 0x3524E81 VA: 0x3524D80
	|-ValueTuple<bool, ValueTuple<int, object>>..ctor
	|
	|-RVA: 0x3526020 Offset: 0x3526121 VA: 0x3526020
	|-ValueTuple<bool, ValueTuple<object, object>>..ctor
	|
	|-RVA: 0x35272C0 Offset: 0x35273C1 VA: 0x35272C0
	|-ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>..ctor
	|
	|-RVA: 0x35287F0 Offset: 0x35288F1 VA: 0x35287F0
	|-ValueTuple<bool, ValueTuple<object, object, object>>..ctor
	|
	|-RVA: 0x3529BF0 Offset: 0x3529CF1 VA: 0x3529BF0
	|-ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>..ctor
	|
	|-RVA: 0x352B220 Offset: 0x352B321 VA: 0x352B220
	|-ValueTuple<bool, ValueTuple<object, object, object, object>>..ctor
	|
	|-RVA: 0x352C6A0 Offset: 0x352C7A1 VA: 0x352C6A0
	|-ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>..ctor
	|
	|-RVA: 0x352DDE0 Offset: 0x352DEE1 VA: 0x352DDE0
	|-ValueTuple<bool, ValueTuple<object, object, object, object, object>>..ctor
	|
	|-RVA: 0x352F310 Offset: 0x352F411 VA: 0x352F310
	|-ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>..ctor
	|
	|-RVA: 0x3530B50 Offset: 0x3530C51 VA: 0x3530B50
	|-ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>..ctor
	|
	|-RVA: 0x35320D0 Offset: 0x35321D1 VA: 0x35320D0
	|-ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>..ctor
	|
	|-RVA: 0x3533A20 Offset: 0x3533B21 VA: 0x3533A20
	|-ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>..ctor
	|
	|-RVA: 0x3535050 Offset: 0x3535151 VA: 0x3535050
	|-ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>..ctor
	|
	|-RVA: 0x3536AA0 Offset: 0x3536BA1 VA: 0x3536AA0
	|-ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>..ctor
	|
	|-RVA: 0x3537F60 Offset: 0x3538061 VA: 0x3537F60
	|-ValueTuple<bool, AsyncUnit>..ctor
	|
	|-RVA: 0x3539090 Offset: 0x3539191 VA: 0x3539090
	|-ValueTuple<bool, bool>..ctor
	|
	|-RVA: 0x353A1F0 Offset: 0x353A2F1 VA: 0x353A1F0
	|-ValueTuple<bool, Bounds>..ctor
	|
	|-RVA: 0x353B500 Offset: 0x353B601 VA: 0x353B500
	|-ValueTuple<bool, byte>..ctor
	|
	|-RVA: 0x353C640 Offset: 0x353C741 VA: 0x353C640
	|-ValueTuple<bool, Color>..ctor
	|
	|-RVA: 0x353D820 Offset: 0x353D921 VA: 0x353D820
	|-ValueTuple<bool, double>..ctor
	|
	|-RVA: 0x353E960 Offset: 0x353EA61 VA: 0x353E960
	|-ValueTuple<bool, int>..ctor
	|
	|-RVA: 0x353FA90 Offset: 0x353FB91 VA: 0x353FA90
	|-ValueTuple<bool, long>..ctor
	|
	|-RVA: 0x37B1670 Offset: 0x37B1771 VA: 0x37B1670
	|-ValueTuple<bool, object>..ctor
	|-ValueTuple<bool, WebOperation>..ctor
	|
	|-RVA: 0x37B26C0 Offset: 0x37B27C1 VA: 0x37B26C0
	|-ValueTuple<bool, Quaternion>..ctor
	|
	|-RVA: 0x37B38A0 Offset: 0x37B39A1 VA: 0x37B38A0
	|-ValueTuple<bool, Rect>..ctor
	|
	|-RVA: 0x37B4A80 Offset: 0x37B4B81 VA: 0x37B4A80
	|-ValueTuple<bool, float>..ctor
	|
	|-RVA: 0x37B5BC0 Offset: 0x37B5CC1 VA: 0x37B5BC0
	|-ValueTuple<bool, UniTask>..ctor
	|
	|-RVA: 0x37B6D10 Offset: 0x37B6E11 VA: 0x37B6D10
	|-ValueTuple<bool, Unit>..ctor
	|
	|-RVA: 0x37B7E40 Offset: 0x37B7F41 VA: 0x37B7E40
	|-ValueTuple<bool, Vector2>..ctor
	|
	|-RVA: 0x37B8FC0 Offset: 0x37B90C1 VA: 0x37B8FC0
	|-ValueTuple<bool, Vector3>..ctor
	|
	|-RVA: 0x37BA170 Offset: 0x37BA271 VA: 0x37BA170
	|-ValueTuple<bool, Vector4>..ctor
	|
	|-RVA: 0x37D1110 Offset: 0x37D1211 VA: 0x37D1110
	|-ValueTuple<ExceptionDispatchInfo, bool>..ctor
	|-ValueTuple<object, bool>..ctor
	|-ValueTuple<WebConnection, bool>..ctor
	|-ValueTuple<WebOperation, bool>..ctor
	|
	|-RVA: 0x37BB350 Offset: 0x37BB451 VA: 0x37BB350
	|-ValueTuple<FXZ, int>..ctor
	|
	|-RVA: 0x37BC4C0 Offset: 0x37BC5C1 VA: 0x37BC4C0
	|-ValueTuple<int, bool>..ctor
	|
	|-RVA: 0x37BD5F0 Offset: 0x37BD6F1 VA: 0x37BD5F0
	|-ValueTuple<int, Bounds>..ctor
	|
	|-RVA: 0x37BE890 Offset: 0x37BE991 VA: 0x37BE890
	|-ValueTuple<int, byte>..ctor
	|
	|-RVA: 0x37BF9B0 Offset: 0x37BFAB1 VA: 0x37BF9B0
	|-ValueTuple<int, Color>..ctor
	|
	|-RVA: 0x37C0B60 Offset: 0x37C0C61 VA: 0x37C0B60
	|-ValueTuple<int, double>..ctor
	|
	|-RVA: 0x37C1C80 Offset: 0x37C1D81 VA: 0x37C1C80
	|-ValueTuple<int, int>..ctor
	|
	|-RVA: 0x37C2D90 Offset: 0x37C2E91 VA: 0x37C2D90
	|-ValueTuple<int, long>..ctor
	|
	|-RVA: 0x37C3EB0 Offset: 0x37C3FB1 VA: 0x37C3EB0
	|-ValueTuple<int, Int64Enum>..ctor
	|-ValueTuple<int, PreloadAnims>..ctor
	|
	|-RVA: 0x37C50D0 Offset: 0x37C51D1 VA: 0x37C50D0
	|-ValueTuple<int, object>..ctor
	|
	|-RVA: 0x37C60F0 Offset: 0x37C61F1 VA: 0x37C60F0
	|-ValueTuple<int, Quaternion>..ctor
	|
	|-RVA: 0x37C72A0 Offset: 0x37C73A1 VA: 0x37C72A0
	|-ValueTuple<int, Rect>..ctor
	|
	|-RVA: 0x37C8450 Offset: 0x37C8551 VA: 0x37C8450
	|-ValueTuple<int, float>..ctor
	|
	|-RVA: 0x37C9560 Offset: 0x37C9661 VA: 0x37C9560
	|-ValueTuple<int, Unit>..ctor
	|
	|-RVA: 0x37CA680 Offset: 0x37CA781 VA: 0x37CA680
	|-ValueTuple<int, Vector2>..ctor
	|
	|-RVA: 0x37CB7F0 Offset: 0x37CB8F1 VA: 0x37CB7F0
	|-ValueTuple<int, Vector3>..ctor
	|
	|-RVA: 0x37CC990 Offset: 0x37CCA91 VA: 0x37CC990
	|-ValueTuple<int, Vector4>..ctor
	|
	|-RVA: 0x37CDB40 Offset: 0x37CDC41 VA: 0x37CDB40
	|-ValueTuple<Int32Enum, int>..ctor
	|-ValueTuple<HubAccessManager.MaterialCalculator.Type, int>..ctor
	|
	|-RVA: 0x37CED30 Offset: 0x37CEE31 VA: 0x37CED30
	|-ValueTuple<Int64Enum, int>..ctor
	|-ValueTuple<PreloadAnims, int>..ctor
	|
	|-RVA: 0x37CFF20 Offset: 0x37D0021 VA: 0x37CFF20
	|-ValueTuple<object, ValueTuple<object, int>>..ctor
	|-ValueTuple<object, ValueTuple<Type, int>>..ctor
	|
	|-RVA: 0x37D2180 Offset: 0x37D2281 VA: 0x37D2180
	|-ValueTuple<object, int>..ctor
	|-ValueTuple<string, int>..ctor
	|-ValueTuple<Transform, int>..ctor
	|-ValueTuple<Type, int>..ctor
	|
	|-RVA: 0x388B960 Offset: 0x388BA61 VA: 0x388B960
	|-ValueTuple<object, float>..ctor
	|-ValueTuple<string, float>..ctor
	|
	|-RVA: 0x388C9D0 Offset: 0x388CAD1 VA: 0x388C9D0
	|-ValueTuple<float, int>..ctor
	|
	|-RVA: 0x388DAE0 Offset: 0x388DBE1 VA: 0x388DAE0
	|-ValueTuple<float, Int32Enum>..ctor
	|-ValueTuple<float, WeaponStyle>..ctor
	|
	|-RVA: 0x388ECF0 Offset: 0x388EDF1 VA: 0x388ECF0
	|-ValueTuple<float, float>..ctor
	|
	|-RVA: 0x388FE20 Offset: 0x388FF21 VA: 0x388FE20
	|-ValueTuple<UniTask, CancellationTokenRegistration>..ctor
	|
	|-RVA: 0x3891160 Offset: 0x3891261 VA: 0x3891160
	|-ValueTuple<Vector3, float>..ctor
	|
	|-RVA: 0x3892340 Offset: 0x3892441 VA: 0x3892340
	|-ValueTuple<Vector3, Vector3>..ctor
	|
	|-RVA: 0x3893520 Offset: 0x3893621 VA: 0x3893520
	|-ValueTuple<Vector4, Vector4>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 0
	public override bool Equals(object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3392D50 Offset: 0x3392E51 VA: 0x3392D50
	|-ValueTuple<UniTask<object>, UniTask<object>>.Equals
	|
	|-RVA: 0x33940E0 Offset: 0x33941E1 VA: 0x33940E0
	|-ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>.Equals
	|
	|-RVA: 0x3395420 Offset: 0x3395521 VA: 0x3395420
	|-ValueTuple<bool, UniTask<object>>.Equals
	|
	|-RVA: 0x33966D0 Offset: 0x33967D1 VA: 0x33966D0
	|-ValueTuple<bool, ValueTuple<bool, UniTask<object>>>.Equals
	|
	|-RVA: 0x3397AD0 Offset: 0x3397BD1 VA: 0x3397AD0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>.Equals
	|
	|-RVA: 0x3398F50 Offset: 0x3399051 VA: 0x3398F50
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>>.Equals
	|
	|-RVA: 0x31F37D0 Offset: 0x31F38D1 VA: 0x31F37D0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>>>.Equals
	|
	|-RVA: 0x31F4D20 Offset: 0x31F4E21 VA: 0x31F4D20
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>>>.Equals
	|
	|-RVA: 0x31F6030 Offset: 0x31F6131 VA: 0x31F6030
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>>>.Equals
	|
	|-RVA: 0x31F7350 Offset: 0x31F7451 VA: 0x31F7350
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>>>.Equals
	|
	|-RVA: 0x31F8950 Offset: 0x31F8A51 VA: 0x31F8950
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>>>.Equals
	|
	|-RVA: 0x31F9C70 Offset: 0x31F9D71 VA: 0x31F9C70
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>>>.Equals
	|
	|-RVA: 0x31FB1F0 Offset: 0x31FB2F1 VA: 0x31FB1F0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>>>.Equals
	|
	|-RVA: 0x31FC740 Offset: 0x31FC841 VA: 0x31FC740
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>>>.Equals
	|
	|-RVA: 0x31FDBC0 Offset: 0x31FDCC1 VA: 0x31FDBC0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>>>.Equals
	|
	|-RVA: 0x31FF130 Offset: 0x31FF231 VA: 0x31FF130
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>>>.Equals
	|
	|-RVA: 0x3200690 Offset: 0x3200791 VA: 0x3200690
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>>>.Equals
	|
	|-RVA: 0x3201C10 Offset: 0x3201D11 VA: 0x3201C10
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>>>.Equals
	|
	|-RVA: 0x3203180 Offset: 0x3203281 VA: 0x3203180
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>>>.Equals
	|
	|-RVA: 0x3204610 Offset: 0x3204711 VA: 0x3204610
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>>>.Equals
	|
	|-RVA: 0x3205B60 Offset: 0x3205C61 VA: 0x3205B60
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>>>.Equals
	|
	|-RVA: 0x3206E80 Offset: 0x3206F81 VA: 0x3206E80
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>>>.Equals
	|
	|-RVA: 0x3208340 Offset: 0x3208441 VA: 0x3208340
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>>>.Equals
	|
	|-RVA: 0x3209850 Offset: 0x3209951 VA: 0x3209850
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>>>.Equals
	|
	|-RVA: 0x320ADE0 Offset: 0x320AEE1 VA: 0x320ADE0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>>>.Equals
	|
	|-RVA: 0x320C350 Offset: 0x320C451 VA: 0x320C350
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>>>.Equals
	|
	|-RVA: 0x320D8C0 Offset: 0x320D9C1 VA: 0x320D8C0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>>>.Equals
	|
	|-RVA: 0x320EEE0 Offset: 0x320EFE1 VA: 0x320EEE0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>>>.Equals
	|
	|-RVA: 0x3210570 Offset: 0x3210671 VA: 0x3210570
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>>>.Equals
	|
	|-RVA: 0x3211CA0 Offset: 0x3211DA1 VA: 0x3211CA0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>>>.Equals
	|
	|-RVA: 0x3213420 Offset: 0x3213521 VA: 0x3213420
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>>>.Equals
	|
	|-RVA: 0x3214C30 Offset: 0x3214D31 VA: 0x3214C30
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>>.Equals
	|
	|-RVA: 0x3215F40 Offset: 0x3216041 VA: 0x3215F40
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>>.Equals
	|
	|-RVA: 0x3217260 Offset: 0x3217361 VA: 0x3217260
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>>.Equals
	|
	|-RVA: 0x3218810 Offset: 0x3218911 VA: 0x3218810
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>>.Equals
	|
	|-RVA: 0x3219B30 Offset: 0x3219C31 VA: 0x3219B30
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>>.Equals
	|
	|-RVA: 0x321B040 Offset: 0x321B141 VA: 0x321B040
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>>.Equals
	|
	|-RVA: 0x3252290 Offset: 0x3252391 VA: 0x3252290
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>>.Equals
	|
	|-RVA: 0x32536A0 Offset: 0x32537A1 VA: 0x32536A0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>>.Equals
	|
	|-RVA: 0x3254BC0 Offset: 0x3254CC1 VA: 0x3254BC0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>>.Equals
	|
	|-RVA: 0x32560D0 Offset: 0x32561D1 VA: 0x32560D0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>>.Equals
	|
	|-RVA: 0x32575E0 Offset: 0x32576E1 VA: 0x32575E0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>>.Equals
	|
	|-RVA: 0x3258AE0 Offset: 0x3258BE1 VA: 0x3258AE0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>>.Equals
	|
	|-RVA: 0x3259F00 Offset: 0x325A001 VA: 0x3259F00
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>>.Equals
	|
	|-RVA: 0x325B400 Offset: 0x325B501 VA: 0x325B400
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>>.Equals
	|
	|-RVA: 0x325C710 Offset: 0x325C811 VA: 0x325C710
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>>.Equals
	|
	|-RVA: 0x325DB90 Offset: 0x325DC91 VA: 0x325DB90
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>>.Equals
	|
	|-RVA: 0x325F050 Offset: 0x325F151 VA: 0x325F050
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>>.Equals
	|
	|-RVA: 0x3260570 Offset: 0x3260671 VA: 0x3260570
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>>.Equals
	|
	|-RVA: 0x3261A90 Offset: 0x3261B91 VA: 0x3261A90
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>>.Equals
	|
	|-RVA: 0x3262FB0 Offset: 0x32630B1 VA: 0x3262FB0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.Equals
	|
	|-RVA: 0x3264640 Offset: 0x3264741 VA: 0x3264640
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>>.Equals
	|
	|-RVA: 0x3265BB0 Offset: 0x3265CB1 VA: 0x3265BB0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.Equals
	|
	|-RVA: 0x3267330 Offset: 0x3267431 VA: 0x3267330
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>>.Equals
	|
	|-RVA: 0x3268950 Offset: 0x3268A51 VA: 0x3268950
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.Equals
	|
	|-RVA: 0x326A1E0 Offset: 0x326A2E1 VA: 0x326A1E0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>>.Equals
	|
	|-RVA: 0x326B870 Offset: 0x326B971 VA: 0x326B870
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.Equals
	|
	|-RVA: 0x326D200 Offset: 0x326D301 VA: 0x326D200
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>>.Equals
	|
	|-RVA: 0x326E930 Offset: 0x326EA31 VA: 0x326E930
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.Equals
	|
	|-RVA: 0x3270100 Offset: 0x3270201 VA: 0x3270100
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>>.Equals
	|
	|-RVA: 0x3271850 Offset: 0x3271951 VA: 0x3271850
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>.Equals
	|
	|-RVA: 0x3272AB0 Offset: 0x3272BB1 VA: 0x3272AB0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>.Equals
	|
	|-RVA: 0x3273D30 Offset: 0x3273E31 VA: 0x3273D30
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>.Equals
	|
	|-RVA: 0x3275290 Offset: 0x3275391 VA: 0x3275290
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>.Equals
	|
	|-RVA: 0x3276510 Offset: 0x3276611 VA: 0x3276510
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>.Equals
	|
	|-RVA: 0x32779C0 Offset: 0x3277AC1 VA: 0x32779C0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>.Equals
	|
	|-RVA: 0x3278E20 Offset: 0x3278F21 VA: 0x3278E20
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>.Equals
	|
	|-RVA: 0x327A110 Offset: 0x327A211 VA: 0x327A110
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>.Equals
	|
	|-RVA: 0x32954D0 Offset: 0x32955D1 VA: 0x32954D0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>.Equals
	|
	|-RVA: 0x3296940 Offset: 0x3296A41 VA: 0x3296940
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>.Equals
	|
	|-RVA: 0x3297E00 Offset: 0x3297F01 VA: 0x3297E00
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>.Equals
	|
	|-RVA: 0x32992B0 Offset: 0x32993B1 VA: 0x32992B0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>.Equals
	|
	|-RVA: 0x329A5B0 Offset: 0x329A6B1 VA: 0x329A5B0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>.Equals
	|
	|-RVA: 0x329BA00 Offset: 0x329BB01 VA: 0x329BA00
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>.Equals
	|
	|-RVA: 0x329CC70 Offset: 0x329CD71 VA: 0x329CC70
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>.Equals
	|
	|-RVA: 0x329E070 Offset: 0x329E171 VA: 0x329E070
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>.Equals
	|
	|-RVA: 0x329F4F0 Offset: 0x329F5F1 VA: 0x329F4F0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>.Equals
	|
	|-RVA: 0x32A09B0 Offset: 0x32A0AB1 VA: 0x32A09B0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>.Equals
	|
	|-RVA: 0x32A1E20 Offset: 0x32A1F21 VA: 0x32A1E20
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>.Equals
	|
	|-RVA: 0x32A32A0 Offset: 0x32A33A1 VA: 0x32A32A0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.Equals
	|
	|-RVA: 0x32A48C0 Offset: 0x32A49C1 VA: 0x32A48C0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>.Equals
	|
	|-RVA: 0x32A5DE0 Offset: 0x32A5EE1 VA: 0x32A5DE0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.Equals
	|
	|-RVA: 0x32A7510 Offset: 0x32A7611 VA: 0x32A7510
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>.Equals
	|
	|-RVA: 0x32A8A80 Offset: 0x32A8B81 VA: 0x32A8A80
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.Equals
	|
	|-RVA: 0x32AA2B0 Offset: 0x32AA3B1 VA: 0x32AA2B0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>.Equals
	|
	|-RVA: 0x32AB8D0 Offset: 0x32AB9D1 VA: 0x32AB8D0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.Equals
	|
	|-RVA: 0x32AD210 Offset: 0x32AD311 VA: 0x32AD210
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>.Equals
	|
	|-RVA: 0x32AE8A0 Offset: 0x32AE9A1 VA: 0x32AE8A0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.Equals
	|
	|-RVA: 0x32B02E0 Offset: 0x32B03E1 VA: 0x32B02E0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>.Equals
	|
	|-RVA: 0x32B1A10 Offset: 0x32B1B11 VA: 0x32B1A10
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>>>.Equals
	|
	|-RVA: 0x32B2ED0 Offset: 0x32B2FD1 VA: 0x32B2ED0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.Equals
	|
	|-RVA: 0x32B4370 Offset: 0x32B4471 VA: 0x32B4370
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>.Equals
	|
	|-RVA: 0x32B5630 Offset: 0x32B5731 VA: 0x32B5630
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>.Equals
	|
	|-RVA: 0x32B6900 Offset: 0x32B6A01 VA: 0x32B6900
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>.Equals
	|
	|-RVA: 0x32B7E00 Offset: 0x32B7F01 VA: 0x32B7E00
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>.Equals
	|
	|-RVA: 0x32B90C0 Offset: 0x32B91C1 VA: 0x32B90C0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>.Equals
	|
	|-RVA: 0x32BA530 Offset: 0x32BA631 VA: 0x32BA530
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>.Equals
	|
	|-RVA: 0x32BB920 Offset: 0x32BBA21 VA: 0x32BB920
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>.Equals
	|
	|-RVA: 0x32BCC10 Offset: 0x32BCD11 VA: 0x32BCC10
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>.Equals
	|
	|-RVA: 0x33E4E60 Offset: 0x33E4F61 VA: 0x33E4E60
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>.Equals
	|
	|-RVA: 0x33E6250 Offset: 0x33E6351 VA: 0x33E6250
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>.Equals
	|
	|-RVA: 0x33E76C0 Offset: 0x33E77C1 VA: 0x33E76C0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>.Equals
	|
	|-RVA: 0x33E8B30 Offset: 0x33E8C31 VA: 0x33E8B30
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>.Equals
	|
	|-RVA: 0x33E9E20 Offset: 0x33E9F21 VA: 0x33E9E20
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>.Equals
	|
	|-RVA: 0x33EB210 Offset: 0x33EB311 VA: 0x33EB210
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>.Equals
	|
	|-RVA: 0x33EC4D0 Offset: 0x33EC5D1 VA: 0x33EC4D0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>.Equals
	|
	|-RVA: 0x33ED7C0 Offset: 0x33ED8C1 VA: 0x33ED7C0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>.Equals
	|
	|-RVA: 0x33EEBC0 Offset: 0x33EECC1 VA: 0x33EEBC0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>.Equals
	|
	|-RVA: 0x33F0030 Offset: 0x33F0131 VA: 0x33F0030
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>.Equals
	|
	|-RVA: 0x33F1430 Offset: 0x33F1531 VA: 0x33F1430
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>.Equals
	|
	|-RVA: 0x33F2840 Offset: 0x33F2941 VA: 0x33F2840
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.Equals
	|
	|-RVA: 0x33F3DA0 Offset: 0x33F3EA1 VA: 0x33F3DA0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>.Equals
	|
	|-RVA: 0x33F5220 Offset: 0x33F5321 VA: 0x33F5220
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.Equals
	|
	|-RVA: 0x33F68B0 Offset: 0x33F69B1 VA: 0x33F68B0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>.Equals
	|
	|-RVA: 0x33F7DD0 Offset: 0x33F7ED1 VA: 0x33F7DD0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.Equals
	|
	|-RVA: 0x33F9550 Offset: 0x33F9651 VA: 0x33F9550
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>.Equals
	|
	|-RVA: 0x33FAAC0 Offset: 0x33FABC1 VA: 0x33FAAC0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.Equals
	|
	|-RVA: 0x33FC350 Offset: 0x33FC451 VA: 0x33FC350
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>.Equals
	|
	|-RVA: 0x33FD970 Offset: 0x33FDA71 VA: 0x33FD970
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.Equals
	|
	|-RVA: 0x33FF300 Offset: 0x33FF401 VA: 0x33FF300
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>.Equals
	|
	|-RVA: 0x3400990 Offset: 0x3400A91 VA: 0x3400990
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>>.Equals
	|
	|-RVA: 0x3402160 Offset: 0x3402261 VA: 0x3402160
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.Equals
	|
	|-RVA: 0x34035F0 Offset: 0x34036F1 VA: 0x34035F0
	|-ValueTuple<bool, ValueTuple<bool, AsyncUnit>>.Equals
	|
	|-RVA: 0x3404850 Offset: 0x3404951 VA: 0x3404850
	|-ValueTuple<bool, ValueTuple<bool, bool>>.Equals
	|
	|-RVA: 0x3405AD0 Offset: 0x3405BD1 VA: 0x3405AD0
	|-ValueTuple<bool, ValueTuple<bool, Bounds>>.Equals
	|
	|-RVA: 0x3406F70 Offset: 0x3407071 VA: 0x3406F70
	|-ValueTuple<bool, ValueTuple<bool, byte>>.Equals
	|
	|-RVA: 0x34081E0 Offset: 0x34082E1 VA: 0x34081E0
	|-ValueTuple<bool, ValueTuple<bool, Color>>.Equals
	|
	|-RVA: 0x34095D0 Offset: 0x34096D1 VA: 0x34095D0
	|-ValueTuple<bool, ValueTuple<bool, double>>.Equals
	|
	|-RVA: 0x340A850 Offset: 0x340A951 VA: 0x340A850
	|-ValueTuple<bool, ValueTuple<bool, int>>.Equals
	|
	|-RVA: 0x340BAF0 Offset: 0x340BBF1 VA: 0x340BAF0
	|-ValueTuple<bool, ValueTuple<bool, long>>.Equals
	|
	|-RVA: 0x351A1A0 Offset: 0x351A2A1 VA: 0x351A1A0
	|-ValueTuple<bool, ValueTuple<bool, object>>.Equals
	|
	|-RVA: 0x351B430 Offset: 0x351B531 VA: 0x351B430
	|-ValueTuple<bool, ValueTuple<bool, Quaternion>>.Equals
	|
	|-RVA: 0x351C830 Offset: 0x351C931 VA: 0x351C830
	|-ValueTuple<bool, ValueTuple<bool, Rect>>.Equals
	|
	|-RVA: 0x351DC20 Offset: 0x351DD21 VA: 0x351DC20
	|-ValueTuple<bool, ValueTuple<bool, float>>.Equals
	|
	|-RVA: 0x351EED0 Offset: 0x351EFD1 VA: 0x351EED0
	|-ValueTuple<bool, ValueTuple<bool, UniTask>>.Equals
	|
	|-RVA: 0x3520150 Offset: 0x3520251 VA: 0x3520150
	|-ValueTuple<bool, ValueTuple<bool, Unit>>.Equals
	|
	|-RVA: 0x35213C0 Offset: 0x35214C1 VA: 0x35213C0
	|-ValueTuple<bool, ValueTuple<bool, Vector2>>.Equals
	|
	|-RVA: 0x35226B0 Offset: 0x35227B1 VA: 0x35226B0
	|-ValueTuple<bool, ValueTuple<bool, Vector3>>.Equals
	|
	|-RVA: 0x35239A0 Offset: 0x3523AA1 VA: 0x35239A0
	|-ValueTuple<bool, ValueTuple<bool, Vector4>>.Equals
	|
	|-RVA: 0x3524DA0 Offset: 0x3524EA1 VA: 0x3524DA0
	|-ValueTuple<bool, ValueTuple<int, object>>.Equals
	|
	|-RVA: 0x3526040 Offset: 0x3526141 VA: 0x3526040
	|-ValueTuple<bool, ValueTuple<object, object>>.Equals
	|
	|-RVA: 0x3527300 Offset: 0x3527401 VA: 0x3527300
	|-ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>.Equals
	|
	|-RVA: 0x3528810 Offset: 0x3528911 VA: 0x3528810
	|-ValueTuple<bool, ValueTuple<object, object, object>>.Equals
	|
	|-RVA: 0x3529C30 Offset: 0x3529D31 VA: 0x3529C30
	|-ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.Equals
	|
	|-RVA: 0x352B250 Offset: 0x352B351 VA: 0x352B250
	|-ValueTuple<bool, ValueTuple<object, object, object, object>>.Equals
	|
	|-RVA: 0x352C6E0 Offset: 0x352C7E1 VA: 0x352C6E0
	|-ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.Equals
	|
	|-RVA: 0x352DE20 Offset: 0x352DF21 VA: 0x352DE20
	|-ValueTuple<bool, ValueTuple<object, object, object, object, object>>.Equals
	|
	|-RVA: 0x352F350 Offset: 0x352F451 VA: 0x352F350
	|-ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.Equals
	|
	|-RVA: 0x3530B90 Offset: 0x3530C91 VA: 0x3530B90
	|-ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>.Equals
	|
	|-RVA: 0x3532110 Offset: 0x3532211 VA: 0x3532110
	|-ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.Equals
	|
	|-RVA: 0x3533A60 Offset: 0x3533B61 VA: 0x3533A60
	|-ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>.Equals
	|
	|-RVA: 0x3535090 Offset: 0x3535191 VA: 0x3535090
	|-ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>.Equals
	|
	|-RVA: 0x3536AE0 Offset: 0x3536BE1 VA: 0x3536AE0
	|-ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>.Equals
	|
	|-RVA: 0x3537F70 Offset: 0x3538071 VA: 0x3537F70
	|-ValueTuple<bool, AsyncUnit>.Equals
	|
	|-RVA: 0x35390B0 Offset: 0x35391B1 VA: 0x35390B0
	|-ValueTuple<bool, bool>.Equals
	|
	|-RVA: 0x353A210 Offset: 0x353A311 VA: 0x353A210
	|-ValueTuple<bool, Bounds>.Equals
	|
	|-RVA: 0x353B510 Offset: 0x353B611 VA: 0x353B510
	|-ValueTuple<bool, byte>.Equals
	|
	|-RVA: 0x353C660 Offset: 0x353C761 VA: 0x353C660
	|-ValueTuple<bool, Color>.Equals
	|
	|-RVA: 0x353D830 Offset: 0x353D931 VA: 0x353D830
	|-ValueTuple<bool, double>.Equals
	|
	|-RVA: 0x353E970 Offset: 0x353EA71 VA: 0x353E970
	|-ValueTuple<bool, int>.Equals
	|
	|-RVA: 0x353FAA0 Offset: 0x353FBA1 VA: 0x353FAA0
	|-ValueTuple<bool, long>.Equals
	|
	|-RVA: 0x37B1690 Offset: 0x37B1791 VA: 0x37B1690
	|-ValueTuple<bool, object>.Equals
	|
	|-RVA: 0x37B26E0 Offset: 0x37B27E1 VA: 0x37B26E0
	|-ValueTuple<bool, Quaternion>.Equals
	|
	|-RVA: 0x37B38C0 Offset: 0x37B39C1 VA: 0x37B38C0
	|-ValueTuple<bool, Rect>.Equals
	|
	|-RVA: 0x37B4A90 Offset: 0x37B4B91 VA: 0x37B4A90
	|-ValueTuple<bool, float>.Equals
	|
	|-RVA: 0x37B5BE0 Offset: 0x37B5CE1 VA: 0x37B5BE0
	|-ValueTuple<bool, UniTask>.Equals
	|
	|-RVA: 0x37B6D20 Offset: 0x37B6E21 VA: 0x37B6D20
	|-ValueTuple<bool, Unit>.Equals
	|
	|-RVA: 0x37B7E60 Offset: 0x37B7F61 VA: 0x37B7E60
	|-ValueTuple<bool, Vector2>.Equals
	|
	|-RVA: 0x37B8FE0 Offset: 0x37B90E1 VA: 0x37B8FE0
	|-ValueTuple<bool, Vector3>.Equals
	|
	|-RVA: 0x37BA190 Offset: 0x37BA291 VA: 0x37BA190
	|-ValueTuple<bool, Vector4>.Equals
	|
	|-RVA: 0x37BB360 Offset: 0x37BB461 VA: 0x37BB360
	|-ValueTuple<FXZ, int>.Equals
	|
	|-RVA: 0x37BC4D0 Offset: 0x37BC5D1 VA: 0x37BC4D0
	|-ValueTuple<int, bool>.Equals
	|
	|-RVA: 0x37BD610 Offset: 0x37BD711 VA: 0x37BD610
	|-ValueTuple<int, Bounds>.Equals
	|
	|-RVA: 0x37BE8A0 Offset: 0x37BE9A1 VA: 0x37BE8A0
	|-ValueTuple<int, byte>.Equals
	|
	|-RVA: 0x37BF9D0 Offset: 0x37BFAD1 VA: 0x37BF9D0
	|-ValueTuple<int, Color>.Equals
	|
	|-RVA: 0x37C0B70 Offset: 0x37C0C71 VA: 0x37C0B70
	|-ValueTuple<int, double>.Equals
	|
	|-RVA: 0x37C1C90 Offset: 0x37C1D91 VA: 0x37C1C90
	|-ValueTuple<int, int>.Equals
	|
	|-RVA: 0x37C2DA0 Offset: 0x37C2EA1 VA: 0x37C2DA0
	|-ValueTuple<int, long>.Equals
	|
	|-RVA: 0x37C3EC0 Offset: 0x37C3FC1 VA: 0x37C3EC0
	|-ValueTuple<int, Int64Enum>.Equals
	|
	|-RVA: 0x37C50E0 Offset: 0x37C51E1 VA: 0x37C50E0
	|-ValueTuple<int, object>.Equals
	|
	|-RVA: 0x37C6110 Offset: 0x37C6211 VA: 0x37C6110
	|-ValueTuple<int, Quaternion>.Equals
	|
	|-RVA: 0x37C72C0 Offset: 0x37C73C1 VA: 0x37C72C0
	|-ValueTuple<int, Rect>.Equals
	|
	|-RVA: 0x37C8460 Offset: 0x37C8561 VA: 0x37C8460
	|-ValueTuple<int, float>.Equals
	|
	|-RVA: 0x37C9570 Offset: 0x37C9671 VA: 0x37C9570
	|-ValueTuple<int, Unit>.Equals
	|
	|-RVA: 0x37CA690 Offset: 0x37CA791 VA: 0x37CA690
	|-ValueTuple<int, Vector2>.Equals
	|
	|-RVA: 0x37CB810 Offset: 0x37CB911 VA: 0x37CB810
	|-ValueTuple<int, Vector3>.Equals
	|
	|-RVA: 0x37CC9B0 Offset: 0x37CCAB1 VA: 0x37CC9B0
	|-ValueTuple<int, Vector4>.Equals
	|
	|-RVA: 0x37CDB50 Offset: 0x37CDC51 VA: 0x37CDB50
	|-ValueTuple<Int32Enum, int>.Equals
	|
	|-RVA: 0x37CED40 Offset: 0x37CEE41 VA: 0x37CED40
	|-ValueTuple<Int64Enum, int>.Equals
	|
	|-RVA: 0x37CFF70 Offset: 0x37D0071 VA: 0x37CFF70
	|-ValueTuple<object, ValueTuple<object, int>>.Equals
	|
	|-RVA: 0x37D1140 Offset: 0x37D1241 VA: 0x37D1140
	|-ValueTuple<object, bool>.Equals
	|
	|-RVA: 0x37D21B0 Offset: 0x37D22B1 VA: 0x37D21B0
	|-ValueTuple<object, int>.Equals
	|
	|-RVA: 0x388AA50 Offset: 0x388AB51 VA: 0x388AA50
	|-ValueTuple<object, object>.Equals
	|
	|-RVA: 0x388B9A0 Offset: 0x388BAA1 VA: 0x388B9A0
	|-ValueTuple<object, float>.Equals
	|
	|-RVA: 0x388C9E0 Offset: 0x388CAE1 VA: 0x388C9E0
	|-ValueTuple<float, int>.Equals
	|
	|-RVA: 0x388DAF0 Offset: 0x388DBF1 VA: 0x388DAF0
	|-ValueTuple<float, Int32Enum>.Equals
	|
	|-RVA: 0x388ED00 Offset: 0x388EE01 VA: 0x388ED00
	|-ValueTuple<float, float>.Equals
	|
	|-RVA: 0x388FE70 Offset: 0x388FF71 VA: 0x388FE70
	|-ValueTuple<UniTask, CancellationTokenRegistration>.Equals
	|
	|-RVA: 0x3891180 Offset: 0x3891281 VA: 0x3891180
	|-ValueTuple<Vector3, float>.Equals
	|
	|-RVA: 0x3892360 Offset: 0x3892461 VA: 0x3892360
	|-ValueTuple<Vector3, Vector3>.Equals
	|
	|-RVA: 0x3893550 Offset: 0x3893651 VA: 0x3893550
	|-ValueTuple<Vector4, Vector4>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public bool Equals(ValueTuple<T1, T2> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3392EA0 Offset: 0x3392FA1 VA: 0x3392EA0
	|-ValueTuple<UniTask<object>, UniTask<object>>.Equals
	|
	|-RVA: 0x3394230 Offset: 0x3394331 VA: 0x3394230
	|-ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>.Equals
	|
	|-RVA: 0x3395570 Offset: 0x3395671 VA: 0x3395570
	|-ValueTuple<bool, UniTask<object>>.Equals
	|
	|-RVA: 0x3396820 Offset: 0x3396921 VA: 0x3396820
	|-ValueTuple<bool, ValueTuple<bool, UniTask<object>>>.Equals
	|
	|-RVA: 0x3397C30 Offset: 0x3397D31 VA: 0x3397C30
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>.Equals
	|
	|-RVA: 0x33990B0 Offset: 0x33991B1 VA: 0x33990B0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>>.Equals
	|
	|-RVA: 0x31F3940 Offset: 0x31F3A41 VA: 0x31F3940
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>>>.Equals
	|
	|-RVA: 0x31F4E60 Offset: 0x31F4F61 VA: 0x31F4E60
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>>>.Equals
	|
	|-RVA: 0x31F6170 Offset: 0x31F6271 VA: 0x31F6170
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>>>.Equals
	|
	|-RVA: 0x31F74B0 Offset: 0x31F75B1 VA: 0x31F74B0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>>>.Equals
	|
	|-RVA: 0x31F8A90 Offset: 0x31F8B91 VA: 0x31F8A90
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>>>.Equals
	|
	|-RVA: 0x31F9DD0 Offset: 0x31F9ED1 VA: 0x31F9DD0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>>>.Equals
	|
	|-RVA: 0x31FB360 Offset: 0x31FB461 VA: 0x31FB360
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>>>.Equals
	|
	|-RVA: 0x31FC8A0 Offset: 0x31FC9A1 VA: 0x31FC8A0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>>>.Equals
	|
	|-RVA: 0x31FDD30 Offset: 0x31FDE31 VA: 0x31FDD30
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>>>.Equals
	|
	|-RVA: 0x31FF2A0 Offset: 0x31FF3A1 VA: 0x31FF2A0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>>>.Equals
	|
	|-RVA: 0x32007F0 Offset: 0x32008F1 VA: 0x32007F0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>>>.Equals
	|
	|-RVA: 0x3201D70 Offset: 0x3201E71 VA: 0x3201D70
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>>>.Equals
	|
	|-RVA: 0x32032E0 Offset: 0x32033E1 VA: 0x32032E0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>>>.Equals
	|
	|-RVA: 0x3204780 Offset: 0x3204881 VA: 0x3204780
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>>>.Equals
	|
	|-RVA: 0x3205CA0 Offset: 0x3205DA1 VA: 0x3205CA0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>>>.Equals
	|
	|-RVA: 0x3206FD0 Offset: 0x32070D1 VA: 0x3206FD0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>>>.Equals
	|
	|-RVA: 0x32084B0 Offset: 0x32085B1 VA: 0x32084B0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>>>.Equals
	|
	|-RVA: 0x32099B0 Offset: 0x3209AB1 VA: 0x32099B0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>>>.Equals
	|
	|-RVA: 0x320AF50 Offset: 0x320B051 VA: 0x320AF50
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>>>.Equals
	|
	|-RVA: 0x320C4C0 Offset: 0x320C5C1 VA: 0x320C4C0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>>>.Equals
	|
	|-RVA: 0x320DA30 Offset: 0x320DB31 VA: 0x320DA30
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>>>.Equals
	|
	|-RVA: 0x320F060 Offset: 0x320F161 VA: 0x320F060
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>>>.Equals
	|
	|-RVA: 0x32106F0 Offset: 0x32107F1 VA: 0x32106F0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>>>.Equals
	|
	|-RVA: 0x3211E30 Offset: 0x3211F31 VA: 0x3211E30
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>>>.Equals
	|
	|-RVA: 0x32135B0 Offset: 0x32136B1 VA: 0x32135B0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>>>.Equals
	|
	|-RVA: 0x3214D70 Offset: 0x3214E71 VA: 0x3214D70
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>>.Equals
	|
	|-RVA: 0x3216080 Offset: 0x3216181 VA: 0x3216080
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>>.Equals
	|
	|-RVA: 0x32173D0 Offset: 0x32174D1 VA: 0x32173D0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>>.Equals
	|
	|-RVA: 0x3218950 Offset: 0x3218A51 VA: 0x3218950
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>>.Equals
	|
	|-RVA: 0x3219CA0 Offset: 0x3219DA1 VA: 0x3219CA0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>>.Equals
	|
	|-RVA: 0x321B1A0 Offset: 0x321B2A1 VA: 0x321B1A0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>>.Equals
	|
	|-RVA: 0x32523E0 Offset: 0x32524E1 VA: 0x32523E0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>>.Equals
	|
	|-RVA: 0x3253800 Offset: 0x3253901 VA: 0x3253800
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>>.Equals
	|
	|-RVA: 0x3254D20 Offset: 0x3254E21 VA: 0x3254D20
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>>.Equals
	|
	|-RVA: 0x3256240 Offset: 0x3256341 VA: 0x3256240
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>>.Equals
	|
	|-RVA: 0x3257750 Offset: 0x3257851 VA: 0x3257750
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>>.Equals
	|
	|-RVA: 0x3258C30 Offset: 0x3258D31 VA: 0x3258C30
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>>.Equals
	|
	|-RVA: 0x325A060 Offset: 0x325A161 VA: 0x325A060
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>>.Equals
	|
	|-RVA: 0x325B540 Offset: 0x325B641 VA: 0x325B540
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>>.Equals
	|
	|-RVA: 0x325C870 Offset: 0x325C971 VA: 0x325C870
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>>.Equals
	|
	|-RVA: 0x325DCE0 Offset: 0x325DDE1 VA: 0x325DCE0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>>.Equals
	|
	|-RVA: 0x325F1C0 Offset: 0x325F2C1 VA: 0x325F1C0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>>.Equals
	|
	|-RVA: 0x32606D0 Offset: 0x32607D1 VA: 0x32606D0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>>.Equals
	|
	|-RVA: 0x3261BF0 Offset: 0x3261CF1 VA: 0x3261BF0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>>.Equals
	|
	|-RVA: 0x3263130 Offset: 0x3263231 VA: 0x3263130
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.Equals
	|
	|-RVA: 0x32647B0 Offset: 0x32648B1 VA: 0x32647B0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>>.Equals
	|
	|-RVA: 0x3265D40 Offset: 0x3265E41 VA: 0x3265D40
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.Equals
	|
	|-RVA: 0x32674A0 Offset: 0x32675A1 VA: 0x32674A0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>>.Equals
	|
	|-RVA: 0x3268AF0 Offset: 0x3268BF1 VA: 0x3268AF0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.Equals
	|
	|-RVA: 0x326A360 Offset: 0x326A461 VA: 0x326A360
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>>.Equals
	|
	|-RVA: 0x326BA30 Offset: 0x326BB31 VA: 0x326BA30
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.Equals
	|
	|-RVA: 0x326D380 Offset: 0x326D481 VA: 0x326D380
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>>.Equals
	|
	|-RVA: 0x326EA90 Offset: 0x326EB91 VA: 0x326EA90
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.Equals
	|
	|-RVA: 0x3270290 Offset: 0x3270391 VA: 0x3270290
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>>.Equals
	|
	|-RVA: 0x3271990 Offset: 0x3271A91 VA: 0x3271990
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>.Equals
	|
	|-RVA: 0x3272BF0 Offset: 0x3272CF1 VA: 0x3272BF0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>.Equals
	|
	|-RVA: 0x3273E90 Offset: 0x3273F91 VA: 0x3273E90
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>.Equals
	|
	|-RVA: 0x32753D0 Offset: 0x32754D1 VA: 0x32753D0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>.Equals
	|
	|-RVA: 0x3276660 Offset: 0x3276761 VA: 0x3276660
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>.Equals
	|
	|-RVA: 0x3277B20 Offset: 0x3277C21 VA: 0x3277B20
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>.Equals
	|
	|-RVA: 0x3278F70 Offset: 0x3279071 VA: 0x3278F70
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>.Equals
	|
	|-RVA: 0x327A270 Offset: 0x327A371 VA: 0x327A270
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>.Equals
	|
	|-RVA: 0x3295630 Offset: 0x3295731 VA: 0x3295630
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>.Equals
	|
	|-RVA: 0x3296A90 Offset: 0x3296B91 VA: 0x3296A90
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>.Equals
	|
	|-RVA: 0x3297F50 Offset: 0x3298051 VA: 0x3297F50
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>.Equals
	|
	|-RVA: 0x3299400 Offset: 0x3299501 VA: 0x3299400
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>.Equals
	|
	|-RVA: 0x329A710 Offset: 0x329A811 VA: 0x329A710
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>.Equals
	|
	|-RVA: 0x329BB40 Offset: 0x329BC41 VA: 0x329BB40
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>.Equals
	|
	|-RVA: 0x329CDC0 Offset: 0x329CEC1 VA: 0x329CDC0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>.Equals
	|
	|-RVA: 0x329E1D0 Offset: 0x329E2D1 VA: 0x329E1D0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>.Equals
	|
	|-RVA: 0x329F640 Offset: 0x329F741 VA: 0x329F640
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>.Equals
	|
	|-RVA: 0x32A0B10 Offset: 0x32A0C11 VA: 0x32A0B10
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>.Equals
	|
	|-RVA: 0x32A1F80 Offset: 0x32A2081 VA: 0x32A1F80
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>.Equals
	|
	|-RVA: 0x32A3410 Offset: 0x32A3511 VA: 0x32A3410
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.Equals
	|
	|-RVA: 0x32A4A20 Offset: 0x32A4B21 VA: 0x32A4A20
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>.Equals
	|
	|-RVA: 0x32A5F60 Offset: 0x32A6061 VA: 0x32A5F60
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.Equals
	|
	|-RVA: 0x32A7680 Offset: 0x32A7781 VA: 0x32A7680
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>.Equals
	|
	|-RVA: 0x32A8C10 Offset: 0x32A8D11 VA: 0x32A8C10
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.Equals
	|
	|-RVA: 0x32AA420 Offset: 0x32AA521 VA: 0x32AA420
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>.Equals
	|
	|-RVA: 0x32ABA80 Offset: 0x32ABB81 VA: 0x32ABA80
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.Equals
	|
	|-RVA: 0x32AD390 Offset: 0x32AD491 VA: 0x32AD390
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>.Equals
	|
	|-RVA: 0x32AEA60 Offset: 0x32AEB61 VA: 0x32AEA60
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.Equals
	|
	|-RVA: 0x32B0460 Offset: 0x32B0561 VA: 0x32B0460
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>.Equals
	|
	|-RVA: 0x32B1B70 Offset: 0x32B1C71 VA: 0x32B1B70
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>>>.Equals
	|
	|-RVA: 0x32B3030 Offset: 0x32B3131 VA: 0x32B3030
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.Equals
	|
	|-RVA: 0x32B44A0 Offset: 0x32B45A1 VA: 0x32B44A0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>.Equals
	|
	|-RVA: 0x32B5760 Offset: 0x32B5861 VA: 0x32B5760
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>.Equals
	|
	|-RVA: 0x32B6A70 Offset: 0x32B6B71 VA: 0x32B6A70
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>.Equals
	|
	|-RVA: 0x32B7F30 Offset: 0x32B8031 VA: 0x32B7F30
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>.Equals
	|
	|-RVA: 0x32B9220 Offset: 0x32B9321 VA: 0x32B9220
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>.Equals
	|
	|-RVA: 0x32BA680 Offset: 0x32BA781 VA: 0x32BA680
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>.Equals
	|
	|-RVA: 0x32BBA50 Offset: 0x32BBB51 VA: 0x32BBA50
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>.Equals
	|
	|-RVA: 0x32BCD60 Offset: 0x32BCE61 VA: 0x32BCD60
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>.Equals
	|
	|-RVA: 0x33E4FB0 Offset: 0x33E50B1 VA: 0x33E4FB0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>.Equals
	|
	|-RVA: 0x33E63B0 Offset: 0x33E64B1 VA: 0x33E63B0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>.Equals
	|
	|-RVA: 0x33E7820 Offset: 0x33E7921 VA: 0x33E7820
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>.Equals
	|
	|-RVA: 0x33E8C60 Offset: 0x33E8D61 VA: 0x33E8C60
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>.Equals
	|
	|-RVA: 0x33E9F70 Offset: 0x33EA071 VA: 0x33E9F70
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>.Equals
	|
	|-RVA: 0x33EB340 Offset: 0x33EB441 VA: 0x33EB340
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>.Equals
	|
	|-RVA: 0x33EC620 Offset: 0x33EC721 VA: 0x33EC620
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>.Equals
	|
	|-RVA: 0x33ED910 Offset: 0x33EDA11 VA: 0x33ED910
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>.Equals
	|
	|-RVA: 0x33EED20 Offset: 0x33EEE21 VA: 0x33EED20
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>.Equals
	|
	|-RVA: 0x33F0180 Offset: 0x33F0281 VA: 0x33F0180
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>.Equals
	|
	|-RVA: 0x33F1580 Offset: 0x33F1681 VA: 0x33F1580
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>.Equals
	|
	|-RVA: 0x33F29B0 Offset: 0x33F2AB1 VA: 0x33F29B0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.Equals
	|
	|-RVA: 0x33F3F00 Offset: 0x33F4001 VA: 0x33F3F00
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>.Equals
	|
	|-RVA: 0x33F53A0 Offset: 0x33F54A1 VA: 0x33F53A0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.Equals
	|
	|-RVA: 0x33F6A10 Offset: 0x33F6B11 VA: 0x33F6A10
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>.Equals
	|
	|-RVA: 0x33F7F60 Offset: 0x33F8061 VA: 0x33F7F60
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.Equals
	|
	|-RVA: 0x33F96C0 Offset: 0x33F97C1 VA: 0x33F96C0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>.Equals
	|
	|-RVA: 0x33FAC60 Offset: 0x33FAD61 VA: 0x33FAC60
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.Equals
	|
	|-RVA: 0x33FC4C0 Offset: 0x33FC5C1 VA: 0x33FC4C0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>.Equals
	|
	|-RVA: 0x33FDB30 Offset: 0x33FDC31 VA: 0x33FDB30
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.Equals
	|
	|-RVA: 0x33FF480 Offset: 0x33FF581 VA: 0x33FF480
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>.Equals
	|
	|-RVA: 0x3400AF0 Offset: 0x3400BF1 VA: 0x3400AF0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>>.Equals
	|
	|-RVA: 0x34022C0 Offset: 0x34023C1 VA: 0x34022C0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.Equals
	|
	|-RVA: 0x3403730 Offset: 0x3403831 VA: 0x3403730
	|-ValueTuple<bool, ValueTuple<bool, AsyncUnit>>.Equals
	|
	|-RVA: 0x3404990 Offset: 0x3404A91 VA: 0x3404990
	|-ValueTuple<bool, ValueTuple<bool, bool>>.Equals
	|
	|-RVA: 0x3405C20 Offset: 0x3405D21 VA: 0x3405C20
	|-ValueTuple<bool, ValueTuple<bool, Bounds>>.Equals
	|
	|-RVA: 0x34070B0 Offset: 0x34071B1 VA: 0x34070B0
	|-ValueTuple<bool, ValueTuple<bool, byte>>.Equals
	|
	|-RVA: 0x3408330 Offset: 0x3408431 VA: 0x3408330
	|-ValueTuple<bool, ValueTuple<bool, Color>>.Equals
	|
	|-RVA: 0x3409720 Offset: 0x3409821 VA: 0x3409720
	|-ValueTuple<bool, ValueTuple<bool, double>>.Equals
	|
	|-RVA: 0x340A990 Offset: 0x340AA91 VA: 0x340A990
	|-ValueTuple<bool, ValueTuple<bool, int>>.Equals
	|
	|-RVA: 0x340BC40 Offset: 0x340BD41 VA: 0x340BC40
	|-ValueTuple<bool, ValueTuple<bool, long>>.Equals
	|
	|-RVA: 0x351A2F0 Offset: 0x351A3F1 VA: 0x351A2F0
	|-ValueTuple<bool, ValueTuple<bool, object>>.Equals
	|
	|-RVA: 0x351B580 Offset: 0x351B681 VA: 0x351B580
	|-ValueTuple<bool, ValueTuple<bool, Quaternion>>.Equals
	|
	|-RVA: 0x351C980 Offset: 0x351CA81 VA: 0x351C980
	|-ValueTuple<bool, ValueTuple<bool, Rect>>.Equals
	|
	|-RVA: 0x351DD60 Offset: 0x351DE61 VA: 0x351DD60
	|-ValueTuple<bool, ValueTuple<bool, float>>.Equals
	|
	|-RVA: 0x351F020 Offset: 0x351F121 VA: 0x351F020
	|-ValueTuple<bool, ValueTuple<bool, UniTask>>.Equals
	|
	|-RVA: 0x3520290 Offset: 0x3520391 VA: 0x3520290
	|-ValueTuple<bool, ValueTuple<bool, Unit>>.Equals
	|
	|-RVA: 0x35214F0 Offset: 0x35215F1 VA: 0x35214F0
	|-ValueTuple<bool, ValueTuple<bool, Vector2>>.Equals
	|
	|-RVA: 0x3522800 Offset: 0x3522901 VA: 0x3522800
	|-ValueTuple<bool, ValueTuple<bool, Vector3>>.Equals
	|
	|-RVA: 0x3523AF0 Offset: 0x3523BF1 VA: 0x3523AF0
	|-ValueTuple<bool, ValueTuple<bool, Vector4>>.Equals
	|
	|-RVA: 0x3524EF0 Offset: 0x3524FF1 VA: 0x3524EF0
	|-ValueTuple<bool, ValueTuple<int, object>>.Equals
	|
	|-RVA: 0x3526190 Offset: 0x3526291 VA: 0x3526190
	|-ValueTuple<bool, ValueTuple<object, object>>.Equals
	|
	|-RVA: 0x3527460 Offset: 0x3527561 VA: 0x3527460
	|-ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>.Equals
	|
	|-RVA: 0x3528960 Offset: 0x3528A61 VA: 0x3528960
	|-ValueTuple<bool, ValueTuple<object, object, object>>.Equals
	|
	|-RVA: 0x3529DA0 Offset: 0x3529EA1 VA: 0x3529DA0
	|-ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.Equals
	|
	|-RVA: 0x352B3B0 Offset: 0x352B4B1 VA: 0x352B3B0
	|-ValueTuple<bool, ValueTuple<object, object, object, object>>.Equals
	|
	|-RVA: 0x352C860 Offset: 0x352C961 VA: 0x352C860
	|-ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.Equals
	|
	|-RVA: 0x352DF80 Offset: 0x352E081 VA: 0x352DF80
	|-ValueTuple<bool, ValueTuple<object, object, object, object, object>>.Equals
	|
	|-RVA: 0x352F4E0 Offset: 0x352F5E1 VA: 0x352F4E0
	|-ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.Equals
	|
	|-RVA: 0x3530D00 Offset: 0x3530E01 VA: 0x3530D00
	|-ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>.Equals
	|
	|-RVA: 0x35322C0 Offset: 0x35323C1 VA: 0x35322C0
	|-ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.Equals
	|
	|-RVA: 0x3533BD0 Offset: 0x3533CD1 VA: 0x3533BD0
	|-ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>.Equals
	|
	|-RVA: 0x3535250 Offset: 0x3535351 VA: 0x3535250
	|-ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>.Equals
	|
	|-RVA: 0x3536C40 Offset: 0x3536D41 VA: 0x3536C40
	|-ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>.Equals
	|
	|-RVA: 0x35380A0 Offset: 0x35381A1 VA: 0x35380A0
	|-ValueTuple<bool, AsyncUnit>.Equals
	|
	|-RVA: 0x35391E0 Offset: 0x35392E1 VA: 0x35391E0
	|-ValueTuple<bool, bool>.Equals
	|
	|-RVA: 0x353A370 Offset: 0x353A471 VA: 0x353A370
	|-ValueTuple<bool, Bounds>.Equals
	|
	|-RVA: 0x353B640 Offset: 0x353B741 VA: 0x353B640
	|-ValueTuple<bool, byte>.Equals
	|
	|-RVA: 0x353C7B0 Offset: 0x353C8B1 VA: 0x353C7B0
	|-ValueTuple<bool, Color>.Equals
	|
	|-RVA: 0x353D960 Offset: 0x353DA61 VA: 0x353D960
	|-ValueTuple<bool, double>.Equals
	|
	|-RVA: 0x353EAA0 Offset: 0x353EBA1 VA: 0x353EAA0
	|-ValueTuple<bool, int>.Equals
	|
	|-RVA: 0x353FBD0 Offset: 0x353FCD1 VA: 0x353FBD0
	|-ValueTuple<bool, long>.Equals
	|
	|-RVA: 0x37B17C0 Offset: 0x37B18C1 VA: 0x37B17C0
	|-ValueTuple<bool, object>.Equals
	|
	|-RVA: 0x37B2830 Offset: 0x37B2931 VA: 0x37B2830
	|-ValueTuple<bool, Quaternion>.Equals
	|
	|-RVA: 0x37B3A10 Offset: 0x37B3B11 VA: 0x37B3A10
	|-ValueTuple<bool, Rect>.Equals
	|
	|-RVA: 0x37B4BC0 Offset: 0x37B4CC1 VA: 0x37B4BC0
	|-ValueTuple<bool, float>.Equals
	|
	|-RVA: 0x37B5D10 Offset: 0x37B5E11 VA: 0x37B5D10
	|-ValueTuple<bool, UniTask>.Equals
	|
	|-RVA: 0x37B6E50 Offset: 0x37B6F51 VA: 0x37B6E50
	|-ValueTuple<bool, Unit>.Equals
	|
	|-RVA: 0x37B7FA0 Offset: 0x37B80A1 VA: 0x37B7FA0
	|-ValueTuple<bool, Vector2>.Equals
	|
	|-RVA: 0x37B9110 Offset: 0x37B9211 VA: 0x37B9110
	|-ValueTuple<bool, Vector3>.Equals
	|
	|-RVA: 0x37BA2E0 Offset: 0x37BA3E1 VA: 0x37BA2E0
	|-ValueTuple<bool, Vector4>.Equals
	|
	|-RVA: 0x37BB4A0 Offset: 0x37BB5A1 VA: 0x37BB4A0
	|-ValueTuple<FXZ, int>.Equals
	|
	|-RVA: 0x37BC600 Offset: 0x37BC701 VA: 0x37BC600
	|-ValueTuple<int, bool>.Equals
	|
	|-RVA: 0x37BD770 Offset: 0x37BD871 VA: 0x37BD770
	|-ValueTuple<int, Bounds>.Equals
	|
	|-RVA: 0x37BE9D0 Offset: 0x37BEAD1 VA: 0x37BE9D0
	|-ValueTuple<int, byte>.Equals
	|
	|-RVA: 0x37BFB20 Offset: 0x37BFC21 VA: 0x37BFB20
	|-ValueTuple<int, Color>.Equals
	|
	|-RVA: 0x37C0CA0 Offset: 0x37C0DA1 VA: 0x37C0CA0
	|-ValueTuple<int, double>.Equals
	|
	|-RVA: 0x37C1DC0 Offset: 0x37C1EC1 VA: 0x37C1DC0
	|-ValueTuple<int, int>.Equals
	|
	|-RVA: 0x37C2ED0 Offset: 0x37C2FD1 VA: 0x37C2ED0
	|-ValueTuple<int, long>.Equals
	|
	|-RVA: 0x37C3FF0 Offset: 0x37C40F1 VA: 0x37C3FF0
	|-ValueTuple<int, Int64Enum>.Equals
	|
	|-RVA: 0x37C5210 Offset: 0x37C5311 VA: 0x37C5210
	|-ValueTuple<int, object>.Equals
	|
	|-RVA: 0x37C6260 Offset: 0x37C6361 VA: 0x37C6260
	|-ValueTuple<int, Quaternion>.Equals
	|
	|-RVA: 0x37C7410 Offset: 0x37C7511 VA: 0x37C7410
	|-ValueTuple<int, Rect>.Equals
	|
	|-RVA: 0x37C8590 Offset: 0x37C8691 VA: 0x37C8590
	|-ValueTuple<int, float>.Equals
	|
	|-RVA: 0x37C96A0 Offset: 0x37C97A1 VA: 0x37C96A0
	|-ValueTuple<int, Unit>.Equals
	|
	|-RVA: 0x37CA7D0 Offset: 0x37CA8D1 VA: 0x37CA7D0
	|-ValueTuple<int, Vector2>.Equals
	|
	|-RVA: 0x37CB940 Offset: 0x37CBA41 VA: 0x37CB940
	|-ValueTuple<int, Vector3>.Equals
	|
	|-RVA: 0x37CCB00 Offset: 0x37CCC01 VA: 0x37CCB00
	|-ValueTuple<int, Vector4>.Equals
	|
	|-RVA: 0x37CDC80 Offset: 0x37CDD81 VA: 0x37CDC80
	|-ValueTuple<Int32Enum, int>.Equals
	|
	|-RVA: 0x37CEE70 Offset: 0x37CEF71 VA: 0x37CEE70
	|-ValueTuple<Int64Enum, int>.Equals
	|
	|-RVA: 0x37D00C0 Offset: 0x37D01C1 VA: 0x37D00C0
	|-ValueTuple<object, ValueTuple<object, int>>.Equals
	|
	|-RVA: 0x37D1270 Offset: 0x37D1371 VA: 0x37D1270
	|-ValueTuple<object, bool>.Equals
	|
	|-RVA: 0x37D22E0 Offset: 0x37D23E1 VA: 0x37D22E0
	|-ValueTuple<object, int>.Equals
	|
	|-RVA: 0x388AB80 Offset: 0x388AC81 VA: 0x388AB80
	|-ValueTuple<object, object>.Equals
	|
	|-RVA: 0x388BAD0 Offset: 0x388BBD1 VA: 0x388BAD0
	|-ValueTuple<object, float>.Equals
	|
	|-RVA: 0x388CB10 Offset: 0x388CC11 VA: 0x388CB10
	|-ValueTuple<float, int>.Equals
	|
	|-RVA: 0x388DC20 Offset: 0x388DD21 VA: 0x388DC20
	|-ValueTuple<float, Int32Enum>.Equals
	|
	|-RVA: 0x388EE40 Offset: 0x388EF41 VA: 0x388EE40
	|-ValueTuple<float, float>.Equals
	|
	|-RVA: 0x388FFC0 Offset: 0x38900C1 VA: 0x388FFC0
	|-ValueTuple<UniTask, CancellationTokenRegistration>.Equals
	|
	|-RVA: 0x38912E0 Offset: 0x38913E1 VA: 0x38912E0
	|-ValueTuple<Vector3, float>.Equals
	|
	|-RVA: 0x38924B0 Offset: 0x38925B1 VA: 0x38924B0
	|-ValueTuple<Vector3, Vector3>.Equals
	|
	|-RVA: 0x38936A0 Offset: 0x38937A1 VA: 0x38936A0
	|-ValueTuple<Vector4, Vector4>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private bool System.Collections.IStructuralEquatable.Equals(object other, IEqualityComparer comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3392FA0 Offset: 0x33930A1 VA: 0x3392FA0
	|-ValueTuple<UniTask<object>, UniTask<object>>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x3394330 Offset: 0x3394431 VA: 0x3394330
	|-ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x3395680 Offset: 0x3395781 VA: 0x3395680
	|-ValueTuple<bool, UniTask<object>>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x3396970 Offset: 0x3396A71 VA: 0x3396970
	|-ValueTuple<bool, ValueTuple<bool, UniTask<object>>>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x3397D80 Offset: 0x3397E81 VA: 0x3397D80
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x3399220 Offset: 0x3399321 VA: 0x3399220
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x31F3AB0 Offset: 0x31F3BB1 VA: 0x31F3AB0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>>>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x31F4F70 Offset: 0x31F5071 VA: 0x31F4F70
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>>>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x31F6280 Offset: 0x31F6381 VA: 0x31F6280
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>>>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x31F7640 Offset: 0x31F7741 VA: 0x31F7640
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>>>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x31F8BA0 Offset: 0x31F8CA1 VA: 0x31F8BA0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>>>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x31F9F50 Offset: 0x31FA051 VA: 0x31F9F50
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>>>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x31FB4D0 Offset: 0x31FB5D1 VA: 0x31FB4D0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>>>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x31FCA00 Offset: 0x31FCB01 VA: 0x31FCA00
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>>>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x31FDEA0 Offset: 0x31FDFA1 VA: 0x31FDEA0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>>>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x31FF410 Offset: 0x31FF511 VA: 0x31FF410
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>>>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x3200970 Offset: 0x3200A71 VA: 0x3200970
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>>>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x3201EF0 Offset: 0x3201FF1 VA: 0x3201EF0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>>>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x3203440 Offset: 0x3203541 VA: 0x3203440
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>>>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x32048F0 Offset: 0x32049F1 VA: 0x32048F0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>>>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x3205DB0 Offset: 0x3205EB1 VA: 0x3205DB0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>>>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x3207140 Offset: 0x3207241 VA: 0x3207140
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>>>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x3208620 Offset: 0x3208721 VA: 0x3208620
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>>>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x3209B30 Offset: 0x3209C31 VA: 0x3209B30
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>>>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x320B0C0 Offset: 0x320B1C1 VA: 0x320B0C0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>>>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x320C630 Offset: 0x320C731 VA: 0x320C630
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>>>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x320DBC0 Offset: 0x320DCC1 VA: 0x320DBC0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>>>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x320F1F0 Offset: 0x320F2F1 VA: 0x320F1F0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>>>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x32108A0 Offset: 0x32109A1 VA: 0x32108A0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>>>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x3211FE0 Offset: 0x32120E1 VA: 0x3211FE0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>>>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x3213780 Offset: 0x3213881 VA: 0x3213780
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>>>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x3214E80 Offset: 0x3214F81 VA: 0x3214E80
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x3216190 Offset: 0x3216291 VA: 0x3216190
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x3217550 Offset: 0x3217651 VA: 0x3217550
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x3218A60 Offset: 0x3218B61 VA: 0x3218A60
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x3219E10 Offset: 0x3219F11 VA: 0x3219E10
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x321B310 Offset: 0x321B411 VA: 0x321B310
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x3252530 Offset: 0x3252631 VA: 0x3252530
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x3253970 Offset: 0x3253A71 VA: 0x3253970
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x3254E90 Offset: 0x3254F91 VA: 0x3254E90
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x32563B0 Offset: 0x32564B1 VA: 0x32563B0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x32578C0 Offset: 0x32579C1 VA: 0x32578C0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x3258D80 Offset: 0x3258E81 VA: 0x3258D80
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x325A1D0 Offset: 0x325A2D1 VA: 0x325A1D0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x325B650 Offset: 0x325B751 VA: 0x325B650
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x325C9D0 Offset: 0x325CAD1 VA: 0x325C9D0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x325DE50 Offset: 0x325DF51 VA: 0x325DE50
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x325F330 Offset: 0x325F431 VA: 0x325F330
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x3260840 Offset: 0x3260941 VA: 0x3260840
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x3261D60 Offset: 0x3261E61 VA: 0x3261D60
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x32632C0 Offset: 0x32633C1 VA: 0x32632C0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x3264920 Offset: 0x3264A21 VA: 0x3264920
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x3265EF0 Offset: 0x3265FF1 VA: 0x3265EF0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x3267630 Offset: 0x3267731 VA: 0x3267630
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x3268CC0 Offset: 0x3268DC1 VA: 0x3268CC0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x326A4F0 Offset: 0x326A5F1 VA: 0x326A4F0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x326BC20 Offset: 0x326BD21 VA: 0x326BC20
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x326D530 Offset: 0x326D631 VA: 0x326D530
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x326EC70 Offset: 0x326ED71 VA: 0x326EC70
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x3270440 Offset: 0x3270541 VA: 0x3270440
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x3271A90 Offset: 0x3271B91 VA: 0x3271A90
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x3272CF0 Offset: 0x3272DF1 VA: 0x3272CF0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x3274010 Offset: 0x3274111 VA: 0x3274010
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x32754D0 Offset: 0x32755D1 VA: 0x32754D0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x32767D0 Offset: 0x32768D1 VA: 0x32767D0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x3277C70 Offset: 0x3277D71 VA: 0x3277C70
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x3279080 Offset: 0x3279181 VA: 0x3279080
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x327A3C0 Offset: 0x327A4C1 VA: 0x327A3C0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x3295780 Offset: 0x3295881 VA: 0x3295780
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x3296C00 Offset: 0x3296D01 VA: 0x3296C00
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x32980C0 Offset: 0x32981C1 VA: 0x32980C0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x3299510 Offset: 0x3299611 VA: 0x3299510
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x329A860 Offset: 0x329A961 VA: 0x329A860
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x329BC40 Offset: 0x329BD41 VA: 0x329BC40
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x329CF10 Offset: 0x329D011 VA: 0x329CF10
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x329E330 Offset: 0x329E431 VA: 0x329E330
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x329F7B0 Offset: 0x329F8B1 VA: 0x329F7B0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x32A0C60 Offset: 0x32A0D61 VA: 0x32A0C60
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x32A20D0 Offset: 0x32A21D1 VA: 0x32A20D0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x32A35A0 Offset: 0x32A36A1 VA: 0x32A35A0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x32A4B90 Offset: 0x32A4C91 VA: 0x32A4B90
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x32A6110 Offset: 0x32A6211 VA: 0x32A6110
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x32A77F0 Offset: 0x32A78F1 VA: 0x32A77F0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x32A8DE0 Offset: 0x32A8EE1 VA: 0x32A8DE0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x32AA5B0 Offset: 0x32AA6B1 VA: 0x32AA5B0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x32ABC70 Offset: 0x32ABD71 VA: 0x32ABC70
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x32AD520 Offset: 0x32AD621 VA: 0x32AD520
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x32AEC70 Offset: 0x32AED71 VA: 0x32AEC70
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x32B0610 Offset: 0x32B0711 VA: 0x32B0610
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x32B1CD0 Offset: 0x32B1DD1 VA: 0x32B1CD0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>>>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x32B3190 Offset: 0x32B3291 VA: 0x32B3190
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x32B45B0 Offset: 0x32B46B1 VA: 0x32B45B0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x32B5870 Offset: 0x32B5971 VA: 0x32B5870
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x32B6BE0 Offset: 0x32B6CE1 VA: 0x32B6BE0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x32B8040 Offset: 0x32B8141 VA: 0x32B8040
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x32B9380 Offset: 0x32B9481 VA: 0x32B9380
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x32BA7D0 Offset: 0x32BA8D1 VA: 0x32BA7D0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x32BBB70 Offset: 0x32BBC71 VA: 0x32BBB70
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x32BCEB0 Offset: 0x32BCFB1 VA: 0x32BCEB0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x33E5100 Offset: 0x33E5201 VA: 0x33E5100
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x33E6510 Offset: 0x33E6611 VA: 0x33E6510
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x33E7980 Offset: 0x33E7A81 VA: 0x33E7980
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x33E8D80 Offset: 0x33E8E81 VA: 0x33E8D80
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x33EA0C0 Offset: 0x33EA1C1 VA: 0x33EA0C0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x33EB450 Offset: 0x33EB551 VA: 0x33EB450
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x33EC730 Offset: 0x33EC831 VA: 0x33EC730
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x33EDA60 Offset: 0x33EDB61 VA: 0x33EDA60
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x33EEE80 Offset: 0x33EEF81 VA: 0x33EEE80
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x33F02D0 Offset: 0x33F03D1 VA: 0x33F02D0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x33F16D0 Offset: 0x33F17D1 VA: 0x33F16D0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x33F2B20 Offset: 0x33F2C21 VA: 0x33F2B20
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x33F4050 Offset: 0x33F4151 VA: 0x33F4050
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x33F5530 Offset: 0x33F5631 VA: 0x33F5530
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x33F6B80 Offset: 0x33F6C81 VA: 0x33F6B80
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x33F8110 Offset: 0x33F8211 VA: 0x33F8110
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x33F9830 Offset: 0x33F9931 VA: 0x33F9830
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x33FAE30 Offset: 0x33FAF31 VA: 0x33FAE30
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x33FC650 Offset: 0x33FC751 VA: 0x33FC650
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x33FDD20 Offset: 0x33FDE21 VA: 0x33FDD20
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x33FF610 Offset: 0x33FF711 VA: 0x33FF610
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x3400CD0 Offset: 0x3400DD1 VA: 0x3400CD0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x3402420 Offset: 0x3402521 VA: 0x3402420
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x3403830 Offset: 0x3403931 VA: 0x3403830
	|-ValueTuple<bool, ValueTuple<bool, AsyncUnit>>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x3404A90 Offset: 0x3404B91 VA: 0x3404A90
	|-ValueTuple<bool, ValueTuple<bool, bool>>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x3405D90 Offset: 0x3405E91 VA: 0x3405D90
	|-ValueTuple<bool, ValueTuple<bool, Bounds>>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x34071B0 Offset: 0x34072B1 VA: 0x34071B0
	|-ValueTuple<bool, ValueTuple<bool, byte>>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x3408480 Offset: 0x3408581 VA: 0x3408480
	|-ValueTuple<bool, ValueTuple<bool, Color>>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x3409830 Offset: 0x3409931 VA: 0x3409830
	|-ValueTuple<bool, ValueTuple<bool, double>>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x340AAB0 Offset: 0x340ABB1 VA: 0x340AAB0
	|-ValueTuple<bool, ValueTuple<bool, int>>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x340BD50 Offset: 0x340BE51 VA: 0x340BD50
	|-ValueTuple<bool, ValueTuple<bool, long>>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x351A400 Offset: 0x351A501 VA: 0x351A400
	|-ValueTuple<bool, ValueTuple<bool, object>>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x351B6D0 Offset: 0x351B7D1 VA: 0x351B6D0
	|-ValueTuple<bool, ValueTuple<bool, Quaternion>>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x351CAD0 Offset: 0x351CBD1 VA: 0x351CAD0
	|-ValueTuple<bool, ValueTuple<bool, Rect>>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x351DE80 Offset: 0x351DF81 VA: 0x351DE80
	|-ValueTuple<bool, ValueTuple<bool, float>>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x351F130 Offset: 0x351F231 VA: 0x351F130
	|-ValueTuple<bool, ValueTuple<bool, UniTask>>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x3520390 Offset: 0x3520491 VA: 0x3520390
	|-ValueTuple<bool, ValueTuple<bool, Unit>>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x3521610 Offset: 0x3521711 VA: 0x3521610
	|-ValueTuple<bool, ValueTuple<bool, Vector2>>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x3522910 Offset: 0x3522A11 VA: 0x3522910
	|-ValueTuple<bool, ValueTuple<bool, Vector3>>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x3523C40 Offset: 0x3523D41 VA: 0x3523C40
	|-ValueTuple<bool, ValueTuple<bool, Vector4>>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x3525000 Offset: 0x3525101 VA: 0x3525000
	|-ValueTuple<bool, ValueTuple<int, object>>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x35262A0 Offset: 0x35263A1 VA: 0x35262A0
	|-ValueTuple<bool, ValueTuple<object, object>>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x35275D0 Offset: 0x35276D1 VA: 0x35275D0
	|-ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x3528AB0 Offset: 0x3528BB1 VA: 0x3528AB0
	|-ValueTuple<bool, ValueTuple<object, object, object>>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x3529F30 Offset: 0x352A031 VA: 0x3529F30
	|-ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x352B500 Offset: 0x352B601 VA: 0x352B500
	|-ValueTuple<bool, ValueTuple<object, object, object, object>>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x352CA10 Offset: 0x352CB11 VA: 0x352CA10
	|-ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x352E0F0 Offset: 0x352E1F1 VA: 0x352E0F0
	|-ValueTuple<bool, ValueTuple<object, object, object, object, object>>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x352F6B0 Offset: 0x352F7B1 VA: 0x352F6B0
	|-ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x3530E70 Offset: 0x3530F71 VA: 0x3530E70
	|-ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x35324B0 Offset: 0x35325B1 VA: 0x35324B0
	|-ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x3533D60 Offset: 0x3533E61 VA: 0x3533D60
	|-ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x3535460 Offset: 0x3535561 VA: 0x3535460
	|-ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x3536DA0 Offset: 0x3536EA1 VA: 0x3536DA0
	|-ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x35381A0 Offset: 0x35382A1 VA: 0x35381A0
	|-ValueTuple<bool, AsyncUnit>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x35392F0 Offset: 0x35393F1 VA: 0x35392F0
	|-ValueTuple<bool, bool>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x353A4D0 Offset: 0x353A5D1 VA: 0x353A4D0
	|-ValueTuple<bool, Bounds>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x353B750 Offset: 0x353B851 VA: 0x353B750
	|-ValueTuple<bool, byte>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x353C8C0 Offset: 0x353C9C1 VA: 0x353C8C0
	|-ValueTuple<bool, Color>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x353DA70 Offset: 0x353DB71 VA: 0x353DA70
	|-ValueTuple<bool, double>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x353EBA0 Offset: 0x353ECA1 VA: 0x353EBA0
	|-ValueTuple<bool, int>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x353FCE0 Offset: 0x353FDE1 VA: 0x353FCE0
	|-ValueTuple<bool, long>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x37B18D0 Offset: 0x37B19D1 VA: 0x37B18D0
	|-ValueTuple<bool, object>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x37B2940 Offset: 0x37B2A41 VA: 0x37B2940
	|-ValueTuple<bool, Quaternion>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x37B3B20 Offset: 0x37B3C21 VA: 0x37B3B20
	|-ValueTuple<bool, Rect>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x37B4CD0 Offset: 0x37B4DD1 VA: 0x37B4CD0
	|-ValueTuple<bool, float>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x37B5E20 Offset: 0x37B5F21 VA: 0x37B5E20
	|-ValueTuple<bool, UniTask>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x37B6F50 Offset: 0x37B7051 VA: 0x37B6F50
	|-ValueTuple<bool, Unit>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x37B80B0 Offset: 0x37B81B1 VA: 0x37B80B0
	|-ValueTuple<bool, Vector2>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x37B9230 Offset: 0x37B9331 VA: 0x37B9230
	|-ValueTuple<bool, Vector3>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x37BA3F0 Offset: 0x37BA4F1 VA: 0x37BA3F0
	|-ValueTuple<bool, Vector4>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x37BB5B0 Offset: 0x37BB6B1 VA: 0x37BB5B0
	|-ValueTuple<FXZ, int>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x37BC700 Offset: 0x37BC801 VA: 0x37BC700
	|-ValueTuple<int, bool>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x37BD8C0 Offset: 0x37BD9C1 VA: 0x37BD8C0
	|-ValueTuple<int, Bounds>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x37BEAD0 Offset: 0x37BEBD1 VA: 0x37BEAD0
	|-ValueTuple<int, byte>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x37BFC30 Offset: 0x37BFD31 VA: 0x37BFC30
	|-ValueTuple<int, Color>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x37C0DA0 Offset: 0x37C0EA1 VA: 0x37C0DA0
	|-ValueTuple<int, double>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x37C1EC0 Offset: 0x37C1FC1 VA: 0x37C1EC0
	|-ValueTuple<int, int>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x37C2FD0 Offset: 0x37C30D1 VA: 0x37C2FD0
	|-ValueTuple<int, long>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x37C40F0 Offset: 0x37C41F1 VA: 0x37C40F0
	|-ValueTuple<int, Int64Enum>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x37C5310 Offset: 0x37C5411 VA: 0x37C5310
	|-ValueTuple<int, object>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x37C6370 Offset: 0x37C6471 VA: 0x37C6370
	|-ValueTuple<int, Quaternion>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x37C7520 Offset: 0x37C7621 VA: 0x37C7520
	|-ValueTuple<int, Rect>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x37C8690 Offset: 0x37C8791 VA: 0x37C8690
	|-ValueTuple<int, float>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x37C97A0 Offset: 0x37C98A1 VA: 0x37C97A0
	|-ValueTuple<int, Unit>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x37CA8E0 Offset: 0x37CA9E1 VA: 0x37CA8E0
	|-ValueTuple<int, Vector2>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x37CBA60 Offset: 0x37CBB61 VA: 0x37CBA60
	|-ValueTuple<int, Vector3>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x37CCC10 Offset: 0x37CCD11 VA: 0x37CCC10
	|-ValueTuple<int, Vector4>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x37CDD80 Offset: 0x37CDE81 VA: 0x37CDD80
	|-ValueTuple<Int32Enum, int>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x37CEF70 Offset: 0x37CF071 VA: 0x37CEF70
	|-ValueTuple<Int64Enum, int>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x37D01C0 Offset: 0x37D02C1 VA: 0x37D01C0
	|-ValueTuple<object, ValueTuple<object, int>>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x37D1380 Offset: 0x37D1481 VA: 0x37D1380
	|-ValueTuple<object, bool>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x37D23E0 Offset: 0x37D24E1 VA: 0x37D23E0
	|-ValueTuple<object, int>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x388AC80 Offset: 0x388AD81 VA: 0x388AC80
	|-ValueTuple<object, object>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x388BBD0 Offset: 0x388BCD1 VA: 0x388BBD0
	|-ValueTuple<object, float>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x388CC10 Offset: 0x388CD11 VA: 0x388CC10
	|-ValueTuple<float, int>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x388DD20 Offset: 0x388DE21 VA: 0x388DD20
	|-ValueTuple<float, Int32Enum>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x388EF40 Offset: 0x388F041 VA: 0x388EF40
	|-ValueTuple<float, float>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x3890100 Offset: 0x3890201 VA: 0x3890100
	|-ValueTuple<UniTask, CancellationTokenRegistration>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x3891400 Offset: 0x3891501 VA: 0x3891400
	|-ValueTuple<Vector3, float>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x38925C0 Offset: 0x38926C1 VA: 0x38925C0
	|-ValueTuple<Vector3, Vector3>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x38937B0 Offset: 0x38938B1 VA: 0x38937B0
	|-ValueTuple<Vector4, Vector4>.System.Collections.IStructuralEquatable.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private int System.IComparable.CompareTo(object other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x33932B0 Offset: 0x33933B1 VA: 0x33932B0
	|-ValueTuple<UniTask<object>, UniTask<object>>.System.IComparable.CompareTo
	|
	|-RVA: 0x3394640 Offset: 0x3394741 VA: 0x3394640
	|-ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>.System.IComparable.CompareTo
	|
	|-RVA: 0x3395990 Offset: 0x3395A91 VA: 0x3395990
	|-ValueTuple<bool, UniTask<object>>.System.IComparable.CompareTo
	|
	|-RVA: 0x3396CD0 Offset: 0x3396DD1 VA: 0x3396CD0
	|-ValueTuple<bool, ValueTuple<bool, UniTask<object>>>.System.IComparable.CompareTo
	|
	|-RVA: 0x33980F0 Offset: 0x33981F1 VA: 0x33980F0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>.System.IComparable.CompareTo
	|
	|-RVA: 0x33995B0 Offset: 0x33996B1 VA: 0x33995B0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>>.System.IComparable.CompareTo
	|
	|-RVA: 0x31F3E50 Offset: 0x31F3F51 VA: 0x31F3E50
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>>>.System.IComparable.CompareTo
	|
	|-RVA: 0x31F52A0 Offset: 0x31F53A1 VA: 0x31F52A0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>>>.System.IComparable.CompareTo
	|
	|-RVA: 0x31F65B0 Offset: 0x31F66B1 VA: 0x31F65B0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>>>.System.IComparable.CompareTo
	|
	|-RVA: 0x31F79F0 Offset: 0x31F7AF1 VA: 0x31F79F0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>>>.System.IComparable.CompareTo
	|
	|-RVA: 0x31F8ED0 Offset: 0x31F8FD1 VA: 0x31F8ED0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>>>.System.IComparable.CompareTo
	|
	|-RVA: 0x31FA2E0 Offset: 0x31FA3E1 VA: 0x31FA2E0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>>>.System.IComparable.CompareTo
	|
	|-RVA: 0x31FB870 Offset: 0x31FB971 VA: 0x31FB870
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>>>.System.IComparable.CompareTo
	|
	|-RVA: 0x31FCD60 Offset: 0x31FCE61 VA: 0x31FCD60
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>>>.System.IComparable.CompareTo
	|
	|-RVA: 0x31FE240 Offset: 0x31FE341 VA: 0x31FE240
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>>>.System.IComparable.CompareTo
	|
	|-RVA: 0x31FF7B0 Offset: 0x31FF8B1 VA: 0x31FF7B0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>>>.System.IComparable.CompareTo
	|
	|-RVA: 0x3200D00 Offset: 0x3200E01 VA: 0x3200D00
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>>>.System.IComparable.CompareTo
	|
	|-RVA: 0x3202280 Offset: 0x3202381 VA: 0x3202280
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>>>.System.IComparable.CompareTo
	|
	|-RVA: 0x32037A0 Offset: 0x32038A1 VA: 0x32037A0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>>>.System.IComparable.CompareTo
	|
	|-RVA: 0x3204C90 Offset: 0x3204D91 VA: 0x3204C90
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>>>.System.IComparable.CompareTo
	|
	|-RVA: 0x32060E0 Offset: 0x32061E1 VA: 0x32060E0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>>>.System.IComparable.CompareTo
	|
	|-RVA: 0x32074B0 Offset: 0x32075B1 VA: 0x32074B0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>>>.System.IComparable.CompareTo
	|
	|-RVA: 0x32089A0 Offset: 0x3208AA1 VA: 0x32089A0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>>>.System.IComparable.CompareTo
	|
	|-RVA: 0x3209EC0 Offset: 0x3209FC1 VA: 0x3209EC0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>>>.System.IComparable.CompareTo
	|
	|-RVA: 0x320B460 Offset: 0x320B561 VA: 0x320B460
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>>>.System.IComparable.CompareTo
	|
	|-RVA: 0x320C9D0 Offset: 0x320CAD1 VA: 0x320C9D0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>>>.System.IComparable.CompareTo
	|
	|-RVA: 0x320DF80 Offset: 0x320E081 VA: 0x320DF80
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>>>.System.IComparable.CompareTo
	|
	|-RVA: 0x320F5C0 Offset: 0x320F6C1 VA: 0x320F5C0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>>>.System.IComparable.CompareTo
	|
	|-RVA: 0x3210C90 Offset: 0x3210D91 VA: 0x3210C90
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>>>.System.IComparable.CompareTo
	|
	|-RVA: 0x32123E0 Offset: 0x32124E1 VA: 0x32123E0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>>>.System.IComparable.CompareTo
	|
	|-RVA: 0x3213BA0 Offset: 0x3213CA1 VA: 0x3213BA0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>>>.System.IComparable.CompareTo
	|
	|-RVA: 0x32151B0 Offset: 0x32152B1 VA: 0x32151B0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>>.System.IComparable.CompareTo
	|
	|-RVA: 0x32164C0 Offset: 0x32165C1 VA: 0x32164C0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>>.System.IComparable.CompareTo
	|
	|-RVA: 0x32178F0 Offset: 0x32179F1 VA: 0x32178F0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>>.System.IComparable.CompareTo
	|
	|-RVA: 0x3218D90 Offset: 0x3218E91 VA: 0x3218D90
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>>.System.IComparable.CompareTo
	|
	|-RVA: 0x321A190 Offset: 0x321A291 VA: 0x321A190
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>>.System.IComparable.CompareTo
	|
	|-RVA: 0x321B6A0 Offset: 0x321B7A1 VA: 0x321B6A0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>>.System.IComparable.CompareTo
	|
	|-RVA: 0x3252880 Offset: 0x3252981 VA: 0x3252880
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>>.System.IComparable.CompareTo
	|
	|-RVA: 0x3253D00 Offset: 0x3253E01 VA: 0x3253D00
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>>.System.IComparable.CompareTo
	|
	|-RVA: 0x3255220 Offset: 0x3255321 VA: 0x3255220
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>>.System.IComparable.CompareTo
	|
	|-RVA: 0x3256730 Offset: 0x3256831 VA: 0x3256730
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>>.System.IComparable.CompareTo
	|
	|-RVA: 0x3257C40 Offset: 0x3257D41 VA: 0x3257C40
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>>.System.IComparable.CompareTo
	|
	|-RVA: 0x32590D0 Offset: 0x32591D1 VA: 0x32590D0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>>.System.IComparable.CompareTo
	|
	|-RVA: 0x325A560 Offset: 0x325A661 VA: 0x325A560
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>>.System.IComparable.CompareTo
	|
	|-RVA: 0x325B980 Offset: 0x325BA81 VA: 0x325B980
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>>.System.IComparable.CompareTo
	|
	|-RVA: 0x325CD30 Offset: 0x325CE31 VA: 0x325CD30
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>>.System.IComparable.CompareTo
	|
	|-RVA: 0x325E1C0 Offset: 0x325E2C1 VA: 0x325E1C0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>>.System.IComparable.CompareTo
	|
	|-RVA: 0x325F6B0 Offset: 0x325F7B1 VA: 0x325F6B0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>>.System.IComparable.CompareTo
	|
	|-RVA: 0x3260BD0 Offset: 0x3260CD1 VA: 0x3260BD0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>>.System.IComparable.CompareTo
	|
	|-RVA: 0x32620F0 Offset: 0x32621F1 VA: 0x32620F0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>>.System.IComparable.CompareTo
	|
	|-RVA: 0x3263690 Offset: 0x3263791 VA: 0x3263690
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.System.IComparable.CompareTo
	|
	|-RVA: 0x3264CC0 Offset: 0x3264DC1 VA: 0x3264CC0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>>.System.IComparable.CompareTo
	|
	|-RVA: 0x32662F0 Offset: 0x32663F1 VA: 0x32662F0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.System.IComparable.CompareTo
	|
	|-RVA: 0x32679F0 Offset: 0x3267AF1 VA: 0x32679F0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>>.System.IComparable.CompareTo
	|
	|-RVA: 0x32690F0 Offset: 0x32691F1 VA: 0x32690F0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.System.IComparable.CompareTo
	|
	|-RVA: 0x326A8C0 Offset: 0x326A9C1 VA: 0x326A8C0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>>.System.IComparable.CompareTo
	|
	|-RVA: 0x326C070 Offset: 0x326C171 VA: 0x326C070
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.System.IComparable.CompareTo
	|
	|-RVA: 0x326D920 Offset: 0x326DA21 VA: 0x326D920
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>>.System.IComparable.CompareTo
	|
	|-RVA: 0x326F060 Offset: 0x326F161 VA: 0x326F060
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.System.IComparable.CompareTo
	|
	|-RVA: 0x3270840 Offset: 0x3270941 VA: 0x3270840
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>>.System.IComparable.CompareTo
	|
	|-RVA: 0x3271DA0 Offset: 0x3271EA1 VA: 0x3271DA0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>.System.IComparable.CompareTo
	|
	|-RVA: 0x3273000 Offset: 0x3273101 VA: 0x3273000
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>.System.IComparable.CompareTo
	|
	|-RVA: 0x32743A0 Offset: 0x32744A1 VA: 0x32743A0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>.System.IComparable.CompareTo
	|
	|-RVA: 0x32757E0 Offset: 0x32758E1 VA: 0x32757E0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>.System.IComparable.CompareTo
	|
	|-RVA: 0x3276B40 Offset: 0x3276C41 VA: 0x3276B40
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>.System.IComparable.CompareTo
	|
	|-RVA: 0x3277FE0 Offset: 0x32780E1 VA: 0x3277FE0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>.System.IComparable.CompareTo
	|
	|-RVA: 0x32793A0 Offset: 0x32794A1 VA: 0x32793A0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>.System.IComparable.CompareTo
	|
	|-RVA: 0x327A730 Offset: 0x327A831 VA: 0x327A730
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>.System.IComparable.CompareTo
	|
	|-RVA: 0x3295AF0 Offset: 0x3295BF1 VA: 0x3295AF0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>.System.IComparable.CompareTo
	|
	|-RVA: 0x3296F70 Offset: 0x3297071 VA: 0x3296F70
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>.System.IComparable.CompareTo
	|
	|-RVA: 0x3298430 Offset: 0x3298531 VA: 0x3298430
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>.System.IComparable.CompareTo
	|
	|-RVA: 0x3299830 Offset: 0x3299931 VA: 0x3299830
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>.System.IComparable.CompareTo
	|
	|-RVA: 0x329ABD0 Offset: 0x329ACD1 VA: 0x329ABD0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>.System.IComparable.CompareTo
	|
	|-RVA: 0x329BF50 Offset: 0x329C051 VA: 0x329BF50
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>.System.IComparable.CompareTo
	|
	|-RVA: 0x329D260 Offset: 0x329D361 VA: 0x329D260
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>.System.IComparable.CompareTo
	|
	|-RVA: 0x329E690 Offset: 0x329E791 VA: 0x329E690
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>.System.IComparable.CompareTo
	|
	|-RVA: 0x329FB20 Offset: 0x329FC21 VA: 0x329FB20
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>.System.IComparable.CompareTo
	|
	|-RVA: 0x32A0FD0 Offset: 0x32A10D1 VA: 0x32A0FD0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>.System.IComparable.CompareTo
	|
	|-RVA: 0x32A2440 Offset: 0x32A2541 VA: 0x32A2440
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>.System.IComparable.CompareTo
	|
	|-RVA: 0x32A3960 Offset: 0x32A3A61 VA: 0x32A3960
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.System.IComparable.CompareTo
	|
	|-RVA: 0x32A4F20 Offset: 0x32A5021 VA: 0x32A4F20
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>.System.IComparable.CompareTo
	|
	|-RVA: 0x32A6500 Offset: 0x32A6601 VA: 0x32A6500
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.System.IComparable.CompareTo
	|
	|-RVA: 0x32A7B90 Offset: 0x32A7C91 VA: 0x32A7B90
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>.System.IComparable.CompareTo
	|
	|-RVA: 0x32A9200 Offset: 0x32A9301 VA: 0x32A9200
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.System.IComparable.CompareTo
	|
	|-RVA: 0x32AA970 Offset: 0x32AAA71 VA: 0x32AA970
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>.System.IComparable.CompareTo
	|
	|-RVA: 0x32AC0C0 Offset: 0x32AC1C1 VA: 0x32AC0C0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.System.IComparable.CompareTo
	|
	|-RVA: 0x32AD8F0 Offset: 0x32AD9F1 VA: 0x32AD8F0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>.System.IComparable.CompareTo
	|
	|-RVA: 0x32AF0E0 Offset: 0x32AF1E1 VA: 0x32AF0E0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.System.IComparable.CompareTo
	|
	|-RVA: 0x32B0A00 Offset: 0x32B0B01 VA: 0x32B0A00
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>.System.IComparable.CompareTo
	|
	|-RVA: 0x32B2040 Offset: 0x32B2141 VA: 0x32B2040
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>>>.System.IComparable.CompareTo
	|
	|-RVA: 0x32B3500 Offset: 0x32B3601 VA: 0x32B3500
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.System.IComparable.CompareTo
	|
	|-RVA: 0x32B48D0 Offset: 0x32B49D1 VA: 0x32B48D0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>.System.IComparable.CompareTo
	|
	|-RVA: 0x32B5B90 Offset: 0x32B5C91 VA: 0x32B5B90
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>.System.IComparable.CompareTo
	|
	|-RVA: 0x32B6F60 Offset: 0x32B7061 VA: 0x32B6F60
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>.System.IComparable.CompareTo
	|
	|-RVA: 0x32B8360 Offset: 0x32B8461 VA: 0x32B8360
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>.System.IComparable.CompareTo
	|
	|-RVA: 0x32B96E0 Offset: 0x32B97E1 VA: 0x32B96E0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>.System.IComparable.CompareTo
	|
	|-RVA: 0x32BAB30 Offset: 0x32BAC31 VA: 0x32BAB30
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>.System.IComparable.CompareTo
	|
	|-RVA: 0x32BBE90 Offset: 0x32BBF91 VA: 0x32BBE90
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>.System.IComparable.CompareTo
	|
	|-RVA: 0x32BD210 Offset: 0x32BD311 VA: 0x32BD210
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>.System.IComparable.CompareTo
	|
	|-RVA: 0x33E5460 Offset: 0x33E5561 VA: 0x33E5460
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>.System.IComparable.CompareTo
	|
	|-RVA: 0x33E6870 Offset: 0x33E6971 VA: 0x33E6870
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>.System.IComparable.CompareTo
	|
	|-RVA: 0x33E7CE0 Offset: 0x33E7DE1 VA: 0x33E7CE0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>.System.IComparable.CompareTo
	|
	|-RVA: 0x33E90A0 Offset: 0x33E91A1 VA: 0x33E90A0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>.System.IComparable.CompareTo
	|
	|-RVA: 0x33EA420 Offset: 0x33EA521 VA: 0x33EA420
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>.System.IComparable.CompareTo
	|
	|-RVA: 0x33EB770 Offset: 0x33EB871 VA: 0x33EB770
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>.System.IComparable.CompareTo
	|
	|-RVA: 0x33ECA50 Offset: 0x33ECB51 VA: 0x33ECA50
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>.System.IComparable.CompareTo
	|
	|-RVA: 0x33EDDB0 Offset: 0x33EDEB1 VA: 0x33EDDB0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>.System.IComparable.CompareTo
	|
	|-RVA: 0x33EF1E0 Offset: 0x33EF2E1 VA: 0x33EF1E0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>.System.IComparable.CompareTo
	|
	|-RVA: 0x33F0630 Offset: 0x33F0731 VA: 0x33F0630
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>.System.IComparable.CompareTo
	|
	|-RVA: 0x33F1A30 Offset: 0x33F1B31 VA: 0x33F1A30
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>.System.IComparable.CompareTo
	|
	|-RVA: 0x33F2EC0 Offset: 0x33F2FC1 VA: 0x33F2EC0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.System.IComparable.CompareTo
	|
	|-RVA: 0x33F43C0 Offset: 0x33F44C1 VA: 0x33F43C0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>.System.IComparable.CompareTo
	|
	|-RVA: 0x33F5900 Offset: 0x33F5A01 VA: 0x33F5900
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.System.IComparable.CompareTo
	|
	|-RVA: 0x33F6F10 Offset: 0x33F7011 VA: 0x33F6F10
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>.System.IComparable.CompareTo
	|
	|-RVA: 0x33F8510 Offset: 0x33F8611 VA: 0x33F8510
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.System.IComparable.CompareTo
	|
	|-RVA: 0x33F9BD0 Offset: 0x33F9CD1 VA: 0x33F9BD0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>.System.IComparable.CompareTo
	|
	|-RVA: 0x33FB260 Offset: 0x33FB361 VA: 0x33FB260
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.System.IComparable.CompareTo
	|
	|-RVA: 0x33FCA10 Offset: 0x33FCB11 VA: 0x33FCA10
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>.System.IComparable.CompareTo
	|
	|-RVA: 0x33FE170 Offset: 0x33FE271 VA: 0x33FE170
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.System.IComparable.CompareTo
	|
	|-RVA: 0x33FF9E0 Offset: 0x33FFAE1 VA: 0x33FF9E0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>.System.IComparable.CompareTo
	|
	|-RVA: 0x34010C0 Offset: 0x34011C1 VA: 0x34010C0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>>.System.IComparable.CompareTo
	|
	|-RVA: 0x3402790 Offset: 0x3402891 VA: 0x3402790
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.System.IComparable.CompareTo
	|
	|-RVA: 0x3403B40 Offset: 0x3403C41 VA: 0x3403B40
	|-ValueTuple<bool, ValueTuple<bool, AsyncUnit>>.System.IComparable.CompareTo
	|
	|-RVA: 0x3404DA0 Offset: 0x3404EA1 VA: 0x3404DA0
	|-ValueTuple<bool, ValueTuple<bool, bool>>.System.IComparable.CompareTo
	|
	|-RVA: 0x3406100 Offset: 0x3406201 VA: 0x3406100
	|-ValueTuple<bool, ValueTuple<bool, Bounds>>.System.IComparable.CompareTo
	|
	|-RVA: 0x34074C0 Offset: 0x34075C1 VA: 0x34074C0
	|-ValueTuple<bool, ValueTuple<bool, byte>>.System.IComparable.CompareTo
	|
	|-RVA: 0x34087D0 Offset: 0x34088D1 VA: 0x34087D0
	|-ValueTuple<bool, ValueTuple<bool, Color>>.System.IComparable.CompareTo
	|
	|-RVA: 0x3409B40 Offset: 0x3409C41 VA: 0x3409B40
	|-ValueTuple<bool, ValueTuple<bool, double>>.System.IComparable.CompareTo
	|
	|-RVA: 0x340ADC0 Offset: 0x340AEC1 VA: 0x340ADC0
	|-ValueTuple<bool, ValueTuple<bool, int>>.System.IComparable.CompareTo
	|
	|-RVA: 0x340C060 Offset: 0x340C161 VA: 0x340C060
	|-ValueTuple<bool, ValueTuple<bool, long>>.System.IComparable.CompareTo
	|
	|-RVA: 0x351A710 Offset: 0x351A811 VA: 0x351A710
	|-ValueTuple<bool, ValueTuple<bool, object>>.System.IComparable.CompareTo
	|
	|-RVA: 0x351BA20 Offset: 0x351BB21 VA: 0x351BA20
	|-ValueTuple<bool, ValueTuple<bool, Quaternion>>.System.IComparable.CompareTo
	|
	|-RVA: 0x351CE20 Offset: 0x351CF21 VA: 0x351CE20
	|-ValueTuple<bool, ValueTuple<bool, Rect>>.System.IComparable.CompareTo
	|
	|-RVA: 0x351E190 Offset: 0x351E291 VA: 0x351E190
	|-ValueTuple<bool, ValueTuple<bool, float>>.System.IComparable.CompareTo
	|
	|-RVA: 0x351F440 Offset: 0x351F541 VA: 0x351F440
	|-ValueTuple<bool, ValueTuple<bool, UniTask>>.System.IComparable.CompareTo
	|
	|-RVA: 0x35206A0 Offset: 0x35207A1 VA: 0x35206A0
	|-ValueTuple<bool, ValueTuple<bool, Unit>>.System.IComparable.CompareTo
	|
	|-RVA: 0x3521930 Offset: 0x3521A31 VA: 0x3521930
	|-ValueTuple<bool, ValueTuple<bool, Vector2>>.System.IComparable.CompareTo
	|
	|-RVA: 0x3522C30 Offset: 0x3522D31 VA: 0x3522C30
	|-ValueTuple<bool, ValueTuple<bool, Vector3>>.System.IComparable.CompareTo
	|
	|-RVA: 0x3523F90 Offset: 0x3524091 VA: 0x3523F90
	|-ValueTuple<bool, ValueTuple<bool, Vector4>>.System.IComparable.CompareTo
	|
	|-RVA: 0x3525310 Offset: 0x3525411 VA: 0x3525310
	|-ValueTuple<bool, ValueTuple<int, object>>.System.IComparable.CompareTo
	|
	|-RVA: 0x35265B0 Offset: 0x35266B1 VA: 0x35265B0
	|-ValueTuple<bool, ValueTuple<object, object>>.System.IComparable.CompareTo
	|
	|-RVA: 0x3527960 Offset: 0x3527A61 VA: 0x3527960
	|-ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>.System.IComparable.CompareTo
	|
	|-RVA: 0x3528E10 Offset: 0x3528F11 VA: 0x3528E10
	|-ValueTuple<bool, ValueTuple<object, object, object>>.System.IComparable.CompareTo
	|
	|-RVA: 0x352A2F0 Offset: 0x352A3F1 VA: 0x352A2F0
	|-ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.System.IComparable.CompareTo
	|
	|-RVA: 0x352B870 Offset: 0x352B971 VA: 0x352B870
	|-ValueTuple<bool, ValueTuple<object, object, object, object>>.System.IComparable.CompareTo
	|
	|-RVA: 0x352CE00 Offset: 0x352CF01 VA: 0x352CE00
	|-ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.System.IComparable.CompareTo
	|
	|-RVA: 0x352E480 Offset: 0x352E581 VA: 0x352E480
	|-ValueTuple<bool, ValueTuple<object, object, object, object, object>>.System.IComparable.CompareTo
	|
	|-RVA: 0x352FAD0 Offset: 0x352FBD1 VA: 0x352FAD0
	|-ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.System.IComparable.CompareTo
	|
	|-RVA: 0x3531210 Offset: 0x3531311 VA: 0x3531210
	|-ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>.System.IComparable.CompareTo
	|
	|-RVA: 0x3532900 Offset: 0x3532A01 VA: 0x3532900
	|-ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.System.IComparable.CompareTo
	|
	|-RVA: 0x3534120 Offset: 0x3534221 VA: 0x3534120
	|-ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>.System.IComparable.CompareTo
	|
	|-RVA: 0x35358D0 Offset: 0x35359D1 VA: 0x35358D0
	|-ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>.System.IComparable.CompareTo
	|
	|-RVA: 0x3537110 Offset: 0x3537211 VA: 0x3537110
	|-ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>.System.IComparable.CompareTo
	|
	|-RVA: 0x35384B0 Offset: 0x35385B1 VA: 0x35384B0
	|-ValueTuple<bool, AsyncUnit>.System.IComparable.CompareTo
	|
	|-RVA: 0x3539600 Offset: 0x3539701 VA: 0x3539600
	|-ValueTuple<bool, bool>.System.IComparable.CompareTo
	|
	|-RVA: 0x353A830 Offset: 0x353A931 VA: 0x353A830
	|-ValueTuple<bool, Bounds>.System.IComparable.CompareTo
	|
	|-RVA: 0x353BA60 Offset: 0x353BB61 VA: 0x353BA60
	|-ValueTuple<bool, byte>.System.IComparable.CompareTo
	|
	|-RVA: 0x353CBF0 Offset: 0x353CCF1 VA: 0x353CBF0
	|-ValueTuple<bool, Color>.System.IComparable.CompareTo
	|
	|-RVA: 0x353DD80 Offset: 0x353DE81 VA: 0x353DD80
	|-ValueTuple<bool, double>.System.IComparable.CompareTo
	|
	|-RVA: 0x353EEB0 Offset: 0x353EFB1 VA: 0x353EEB0
	|-ValueTuple<bool, int>.System.IComparable.CompareTo
	|
	|-RVA: 0x353FFF0 Offset: 0x35400F1 VA: 0x353FFF0
	|-ValueTuple<bool, long>.System.IComparable.CompareTo
	|
	|-RVA: 0x37B1B60 Offset: 0x37B1C61 VA: 0x37B1B60
	|-ValueTuple<bool, object>.System.IComparable.CompareTo
	|
	|-RVA: 0x37B2C70 Offset: 0x37B2D71 VA: 0x37B2C70
	|-ValueTuple<bool, Quaternion>.System.IComparable.CompareTo
	|
	|-RVA: 0x37B3E50 Offset: 0x37B3F51 VA: 0x37B3E50
	|-ValueTuple<bool, Rect>.System.IComparable.CompareTo
	|
	|-RVA: 0x37B4FE0 Offset: 0x37B50E1 VA: 0x37B4FE0
	|-ValueTuple<bool, float>.System.IComparable.CompareTo
	|
	|-RVA: 0x37B6130 Offset: 0x37B6231 VA: 0x37B6130
	|-ValueTuple<bool, UniTask>.System.IComparable.CompareTo
	|
	|-RVA: 0x37B7260 Offset: 0x37B7361 VA: 0x37B7260
	|-ValueTuple<bool, Unit>.System.IComparable.CompareTo
	|
	|-RVA: 0x37B83C0 Offset: 0x37B84C1 VA: 0x37B83C0
	|-ValueTuple<bool, Vector2>.System.IComparable.CompareTo
	|
	|-RVA: 0x37B9550 Offset: 0x37B9651 VA: 0x37B9550
	|-ValueTuple<bool, Vector3>.System.IComparable.CompareTo
	|
	|-RVA: 0x37BA720 Offset: 0x37BA821 VA: 0x37BA720
	|-ValueTuple<bool, Vector4>.System.IComparable.CompareTo
	|
	|-RVA: 0x37BB8C0 Offset: 0x37BB9C1 VA: 0x37BB8C0
	|-ValueTuple<FXZ, int>.System.IComparable.CompareTo
	|
	|-RVA: 0x37BCA10 Offset: 0x37BCB11 VA: 0x37BCA10
	|-ValueTuple<int, bool>.System.IComparable.CompareTo
	|
	|-RVA: 0x37BDBF0 Offset: 0x37BDCF1 VA: 0x37BDBF0
	|-ValueTuple<int, Bounds>.System.IComparable.CompareTo
	|
	|-RVA: 0x37BEDE0 Offset: 0x37BEEE1 VA: 0x37BEDE0
	|-ValueTuple<int, byte>.System.IComparable.CompareTo
	|
	|-RVA: 0x37BFF50 Offset: 0x37C0051 VA: 0x37BFF50
	|-ValueTuple<int, Color>.System.IComparable.CompareTo
	|
	|-RVA: 0x37C10B0 Offset: 0x37C11B1 VA: 0x37C10B0
	|-ValueTuple<int, double>.System.IComparable.CompareTo
	|
	|-RVA: 0x37C21C0 Offset: 0x37C22C1 VA: 0x37C21C0
	|-ValueTuple<int, int>.System.IComparable.CompareTo
	|
	|-RVA: 0x37C32E0 Offset: 0x37C33E1 VA: 0x37C32E0
	|-ValueTuple<int, long>.System.IComparable.CompareTo
	|
	|-RVA: 0x37C4400 Offset: 0x37C4501 VA: 0x37C4400
	|-ValueTuple<int, Int64Enum>.System.IComparable.CompareTo
	|
	|-RVA: 0x37C5590 Offset: 0x37C5691 VA: 0x37C5590
	|-ValueTuple<int, object>.System.IComparable.CompareTo
	|
	|-RVA: 0x37C6690 Offset: 0x37C6791 VA: 0x37C6690
	|-ValueTuple<int, Quaternion>.System.IComparable.CompareTo
	|
	|-RVA: 0x37C7840 Offset: 0x37C7941 VA: 0x37C7840
	|-ValueTuple<int, Rect>.System.IComparable.CompareTo
	|
	|-RVA: 0x37C8990 Offset: 0x37C8A91 VA: 0x37C8990
	|-ValueTuple<int, float>.System.IComparable.CompareTo
	|
	|-RVA: 0x37C9AB0 Offset: 0x37C9BB1 VA: 0x37C9AB0
	|-ValueTuple<int, Unit>.System.IComparable.CompareTo
	|
	|-RVA: 0x37CABF0 Offset: 0x37CACF1 VA: 0x37CABF0
	|-ValueTuple<int, Vector2>.System.IComparable.CompareTo
	|
	|-RVA: 0x37CBD80 Offset: 0x37CBE81 VA: 0x37CBD80
	|-ValueTuple<int, Vector3>.System.IComparable.CompareTo
	|
	|-RVA: 0x37CCF30 Offset: 0x37CD031 VA: 0x37CCF30
	|-ValueTuple<int, Vector4>.System.IComparable.CompareTo
	|
	|-RVA: 0x37CE080 Offset: 0x37CE181 VA: 0x37CE080
	|-ValueTuple<Int32Enum, int>.System.IComparable.CompareTo
	|
	|-RVA: 0x37CF270 Offset: 0x37CF371 VA: 0x37CF270
	|-ValueTuple<Int64Enum, int>.System.IComparable.CompareTo
	|
	|-RVA: 0x37D0450 Offset: 0x37D0551 VA: 0x37D0450
	|-ValueTuple<object, ValueTuple<object, int>>.System.IComparable.CompareTo
	|
	|-RVA: 0x37D1600 Offset: 0x37D1701 VA: 0x37D1600
	|-ValueTuple<object, bool>.System.IComparable.CompareTo
	|
	|-RVA: 0x37D2660 Offset: 0x37D2761 VA: 0x37D2660
	|-ValueTuple<object, int>.System.IComparable.CompareTo
	|
	|-RVA: 0x388AE80 Offset: 0x388AF81 VA: 0x388AE80
	|-ValueTuple<object, object>.System.IComparable.CompareTo
	|
	|-RVA: 0x388BE50 Offset: 0x388BF51 VA: 0x388BE50
	|-ValueTuple<object, float>.System.IComparable.CompareTo
	|
	|-RVA: 0x388CF10 Offset: 0x388D011 VA: 0x388CF10
	|-ValueTuple<float, int>.System.IComparable.CompareTo
	|
	|-RVA: 0x388E020 Offset: 0x388E121 VA: 0x388E020
	|-ValueTuple<float, Int32Enum>.System.IComparable.CompareTo
	|
	|-RVA: 0x388F240 Offset: 0x388F341 VA: 0x388F240
	|-ValueTuple<float, float>.System.IComparable.CompareTo
	|
	|-RVA: 0x3890420 Offset: 0x3890521 VA: 0x3890420
	|-ValueTuple<UniTask, CancellationTokenRegistration>.System.IComparable.CompareTo
	|
	|-RVA: 0x3891710 Offset: 0x3891811 VA: 0x3891710
	|-ValueTuple<Vector3, float>.System.IComparable.CompareTo
	|
	|-RVA: 0x38928F0 Offset: 0x38929F1 VA: 0x38928F0
	|-ValueTuple<Vector3, Vector3>.System.IComparable.CompareTo
	|
	|-RVA: 0x3893B00 Offset: 0x3893C01 VA: 0x3893B00
	|-ValueTuple<Vector4, Vector4>.System.IComparable.CompareTo
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public int CompareTo(ValueTuple<T1, T2> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3393490 Offset: 0x3393591 VA: 0x3393490
	|-ValueTuple<UniTask<object>, UniTask<object>>.CompareTo
	|
	|-RVA: 0x3394820 Offset: 0x3394921 VA: 0x3394820
	|-ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>.CompareTo
	|
	|-RVA: 0x3395B70 Offset: 0x3395C71 VA: 0x3395B70
	|-ValueTuple<bool, UniTask<object>>.CompareTo
	|
	|-RVA: 0x3396EB0 Offset: 0x3396FB1 VA: 0x3396EB0
	|-ValueTuple<bool, ValueTuple<bool, UniTask<object>>>.CompareTo
	|
	|-RVA: 0x33982F0 Offset: 0x33983F1 VA: 0x33982F0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>.CompareTo
	|
	|-RVA: 0x33997B0 Offset: 0x33998B1 VA: 0x33997B0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>>.CompareTo
	|
	|-RVA: 0x31F4060 Offset: 0x31F4161 VA: 0x31F4060
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>>>.CompareTo
	|
	|-RVA: 0x31F5480 Offset: 0x31F5581 VA: 0x31F5480
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>>>.CompareTo
	|
	|-RVA: 0x31F6790 Offset: 0x31F6891 VA: 0x31F6790
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>>>.CompareTo
	|
	|-RVA: 0x31F7BF0 Offset: 0x31F7CF1 VA: 0x31F7BF0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>>>.CompareTo
	|
	|-RVA: 0x31F90B0 Offset: 0x31F91B1 VA: 0x31F90B0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>>>.CompareTo
	|
	|-RVA: 0x31FA4E0 Offset: 0x31FA5E1 VA: 0x31FA4E0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>>>.CompareTo
	|
	|-RVA: 0x31FBA80 Offset: 0x31FBB81 VA: 0x31FBA80
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>>>.CompareTo
	|
	|-RVA: 0x31FCF60 Offset: 0x31FD061 VA: 0x31FCF60
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>>>.CompareTo
	|
	|-RVA: 0x31FE450 Offset: 0x31FE551 VA: 0x31FE450
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>>>.CompareTo
	|
	|-RVA: 0x31FF9C0 Offset: 0x31FFAC1 VA: 0x31FF9C0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>>>.CompareTo
	|
	|-RVA: 0x3200F00 Offset: 0x3201001 VA: 0x3200F00
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>>>.CompareTo
	|
	|-RVA: 0x3202480 Offset: 0x3202581 VA: 0x3202480
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>>>.CompareTo
	|
	|-RVA: 0x32039A0 Offset: 0x3203AA1 VA: 0x32039A0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>>>.CompareTo
	|
	|-RVA: 0x3204EA0 Offset: 0x3204FA1 VA: 0x3204EA0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>>>.CompareTo
	|
	|-RVA: 0x32062C0 Offset: 0x32063C1 VA: 0x32062C0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>>>.CompareTo
	|
	|-RVA: 0x3207690 Offset: 0x3207791 VA: 0x3207690
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>>>.CompareTo
	|
	|-RVA: 0x3208BB0 Offset: 0x3208CB1 VA: 0x3208BB0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>>>.CompareTo
	|
	|-RVA: 0x320A0C0 Offset: 0x320A1C1 VA: 0x320A0C0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>>>.CompareTo
	|
	|-RVA: 0x320B670 Offset: 0x320B771 VA: 0x320B670
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>>>.CompareTo
	|
	|-RVA: 0x320CBE0 Offset: 0x320CCE1 VA: 0x320CBE0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>>>.CompareTo
	|
	|-RVA: 0x320E190 Offset: 0x320E291 VA: 0x320E190
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>>>.CompareTo
	|
	|-RVA: 0x320F7F0 Offset: 0x320F8F1 VA: 0x320F7F0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>>>.CompareTo
	|
	|-RVA: 0x3210EC0 Offset: 0x3210FC1 VA: 0x3210EC0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>>>.CompareTo
	|
	|-RVA: 0x3212620 Offset: 0x3212721 VA: 0x3212620
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>>>.CompareTo
	|
	|-RVA: 0x3213DE0 Offset: 0x3213EE1 VA: 0x3213DE0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>>>.CompareTo
	|
	|-RVA: 0x3215390 Offset: 0x3215491 VA: 0x3215390
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>>.CompareTo
	|
	|-RVA: 0x32166A0 Offset: 0x32167A1 VA: 0x32166A0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>>.CompareTo
	|
	|-RVA: 0x3217B00 Offset: 0x3217C01 VA: 0x3217B00
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>>.CompareTo
	|
	|-RVA: 0x3218F70 Offset: 0x3219071 VA: 0x3218F70
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>>.CompareTo
	|
	|-RVA: 0x321A3A0 Offset: 0x321A4A1 VA: 0x321A3A0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>>.CompareTo
	|
	|-RVA: 0x321B8A0 Offset: 0x321B9A1 VA: 0x321B8A0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>>.CompareTo
	|
	|-RVA: 0x3252A60 Offset: 0x3252B61 VA: 0x3252A60
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>>.CompareTo
	|
	|-RVA: 0x3253F00 Offset: 0x3254001 VA: 0x3253F00
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>>.CompareTo
	|
	|-RVA: 0x3255420 Offset: 0x3255521 VA: 0x3255420
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>>.CompareTo
	|
	|-RVA: 0x3256940 Offset: 0x3256A41 VA: 0x3256940
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>>.CompareTo
	|
	|-RVA: 0x3257E50 Offset: 0x3257F51 VA: 0x3257E50
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>>.CompareTo
	|
	|-RVA: 0x32592B0 Offset: 0x32593B1 VA: 0x32592B0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>>.CompareTo
	|
	|-RVA: 0x325A760 Offset: 0x325A861 VA: 0x325A760
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>>.CompareTo
	|
	|-RVA: 0x325BB60 Offset: 0x325BC61 VA: 0x325BB60
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>>.CompareTo
	|
	|-RVA: 0x325CF30 Offset: 0x325D031 VA: 0x325CF30
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>>.CompareTo
	|
	|-RVA: 0x325E3A0 Offset: 0x325E4A1 VA: 0x325E3A0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>>.CompareTo
	|
	|-RVA: 0x325F8C0 Offset: 0x325F9C1 VA: 0x325F8C0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>>.CompareTo
	|
	|-RVA: 0x3260DD0 Offset: 0x3260ED1 VA: 0x3260DD0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>>.CompareTo
	|
	|-RVA: 0x32622F0 Offset: 0x32623F1 VA: 0x32622F0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>>.CompareTo
	|
	|-RVA: 0x32638C0 Offset: 0x32639C1 VA: 0x32638C0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.CompareTo
	|
	|-RVA: 0x3264ED0 Offset: 0x3264FD1 VA: 0x3264ED0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>>.CompareTo
	|
	|-RVA: 0x3266530 Offset: 0x3266631 VA: 0x3266530
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.CompareTo
	|
	|-RVA: 0x3267C00 Offset: 0x3267D01 VA: 0x3267C00
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>>.CompareTo
	|
	|-RVA: 0x3269350 Offset: 0x3269451 VA: 0x3269350
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.CompareTo
	|
	|-RVA: 0x326AAF0 Offset: 0x326ABF1 VA: 0x326AAF0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>>.CompareTo
	|
	|-RVA: 0x326C2F0 Offset: 0x326C3F1 VA: 0x326C2F0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.CompareTo
	|
	|-RVA: 0x326DB50 Offset: 0x326DC51 VA: 0x326DB50
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>>.CompareTo
	|
	|-RVA: 0x326F250 Offset: 0x326F351 VA: 0x326F250
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.CompareTo
	|
	|-RVA: 0x3270A80 Offset: 0x3270B81 VA: 0x3270A80
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>>.CompareTo
	|
	|-RVA: 0x3271F80 Offset: 0x3272081 VA: 0x3271F80
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>.CompareTo
	|
	|-RVA: 0x32731E0 Offset: 0x32732E1 VA: 0x32731E0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>.CompareTo
	|
	|-RVA: 0x32745A0 Offset: 0x32746A1 VA: 0x32745A0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>.CompareTo
	|
	|-RVA: 0x32759C0 Offset: 0x3275AC1 VA: 0x32759C0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>.CompareTo
	|
	|-RVA: 0x3276D20 Offset: 0x3276E21 VA: 0x3276D20
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>.CompareTo
	|
	|-RVA: 0x32781E0 Offset: 0x32782E1 VA: 0x32781E0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>.CompareTo
	|
	|-RVA: 0x3279580 Offset: 0x3279681 VA: 0x3279580
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>.CompareTo
	|
	|-RVA: 0x327A930 Offset: 0x327AA31 VA: 0x327A930
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>.CompareTo
	|
	|-RVA: 0x3295CF0 Offset: 0x3295DF1 VA: 0x3295CF0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>.CompareTo
	|
	|-RVA: 0x3297150 Offset: 0x3297251 VA: 0x3297150
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>.CompareTo
	|
	|-RVA: 0x3298610 Offset: 0x3298711 VA: 0x3298610
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>.CompareTo
	|
	|-RVA: 0x3299A10 Offset: 0x3299B11 VA: 0x3299A10
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>.CompareTo
	|
	|-RVA: 0x329ADD0 Offset: 0x329AED1 VA: 0x329ADD0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>.CompareTo
	|
	|-RVA: 0x329C130 Offset: 0x329C231 VA: 0x329C130
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>.CompareTo
	|
	|-RVA: 0x329D440 Offset: 0x329D541 VA: 0x329D440
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>.CompareTo
	|
	|-RVA: 0x329E890 Offset: 0x329E991 VA: 0x329E890
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>.CompareTo
	|
	|-RVA: 0x329FD00 Offset: 0x329FE01 VA: 0x329FD00
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>.CompareTo
	|
	|-RVA: 0x32A11D0 Offset: 0x32A12D1 VA: 0x32A11D0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>.CompareTo
	|
	|-RVA: 0x32A2640 Offset: 0x32A2741 VA: 0x32A2640
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>.CompareTo
	|
	|-RVA: 0x32A3B70 Offset: 0x32A3C71 VA: 0x32A3B70
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.CompareTo
	|
	|-RVA: 0x32A5120 Offset: 0x32A5221 VA: 0x32A5120
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>.CompareTo
	|
	|-RVA: 0x32A6730 Offset: 0x32A6831 VA: 0x32A6730
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.CompareTo
	|
	|-RVA: 0x32A7DA0 Offset: 0x32A7EA1 VA: 0x32A7DA0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>.CompareTo
	|
	|-RVA: 0x32A9440 Offset: 0x32A9541 VA: 0x32A9440
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.CompareTo
	|
	|-RVA: 0x32AAB80 Offset: 0x32AAC81 VA: 0x32AAB80
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>.CompareTo
	|
	|-RVA: 0x32AC320 Offset: 0x32AC421 VA: 0x32AC320
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.CompareTo
	|
	|-RVA: 0x32ADB20 Offset: 0x32ADC21 VA: 0x32ADB20
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>.CompareTo
	|
	|-RVA: 0x32AF360 Offset: 0x32AF461 VA: 0x32AF360
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.CompareTo
	|
	|-RVA: 0x32B0C30 Offset: 0x32B0D31 VA: 0x32B0C30
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>.CompareTo
	|
	|-RVA: 0x32B2230 Offset: 0x32B2331 VA: 0x32B2230
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>>>.CompareTo
	|
	|-RVA: 0x32B36F0 Offset: 0x32B37F1 VA: 0x32B36F0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.CompareTo
	|
	|-RVA: 0x32B4AA0 Offset: 0x32B4BA1 VA: 0x32B4AA0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>.CompareTo
	|
	|-RVA: 0x32B5D60 Offset: 0x32B5E61 VA: 0x32B5D60
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>.CompareTo
	|
	|-RVA: 0x32B7170 Offset: 0x32B7271 VA: 0x32B7170
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>.CompareTo
	|
	|-RVA: 0x32B8530 Offset: 0x32B8631 VA: 0x32B8530
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>.CompareTo
	|
	|-RVA: 0x32B98E0 Offset: 0x32B99E1 VA: 0x32B98E0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>.CompareTo
	|
	|-RVA: 0x32BAD10 Offset: 0x32BAE11 VA: 0x32BAD10
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>.CompareTo
	|
	|-RVA: 0x32BC060 Offset: 0x32BC161 VA: 0x32BC060
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>.CompareTo
	|
	|-RVA: 0x32BD3F0 Offset: 0x32BD4F1 VA: 0x32BD3F0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>.CompareTo
	|
	|-RVA: 0x33E5640 Offset: 0x33E5741 VA: 0x33E5640
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>.CompareTo
	|
	|-RVA: 0x33E6A70 Offset: 0x33E6B71 VA: 0x33E6A70
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>.CompareTo
	|
	|-RVA: 0x33E7EE0 Offset: 0x33E7FE1 VA: 0x33E7EE0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>.CompareTo
	|
	|-RVA: 0x33E9270 Offset: 0x33E9371 VA: 0x33E9270
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>.CompareTo
	|
	|-RVA: 0x33EA600 Offset: 0x33EA701 VA: 0x33EA600
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>.CompareTo
	|
	|-RVA: 0x33EB940 Offset: 0x33EBA41 VA: 0x33EB940
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>.CompareTo
	|
	|-RVA: 0x33ECC30 Offset: 0x33ECD31 VA: 0x33ECC30
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>.CompareTo
	|
	|-RVA: 0x33EDF90 Offset: 0x33EE091 VA: 0x33EDF90
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>.CompareTo
	|
	|-RVA: 0x33EF3E0 Offset: 0x33EF4E1 VA: 0x33EF3E0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>.CompareTo
	|
	|-RVA: 0x33F0810 Offset: 0x33F0911 VA: 0x33F0810
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>.CompareTo
	|
	|-RVA: 0x33F1C10 Offset: 0x33F1D11 VA: 0x33F1C10
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>.CompareTo
	|
	|-RVA: 0x33F30D0 Offset: 0x33F31D1 VA: 0x33F30D0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.CompareTo
	|
	|-RVA: 0x33F45C0 Offset: 0x33F46C1 VA: 0x33F45C0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>.CompareTo
	|
	|-RVA: 0x33F5B30 Offset: 0x33F5C31 VA: 0x33F5B30
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.CompareTo
	|
	|-RVA: 0x33F7110 Offset: 0x33F7211 VA: 0x33F7110
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>.CompareTo
	|
	|-RVA: 0x33F8750 Offset: 0x33F8851 VA: 0x33F8750
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.CompareTo
	|
	|-RVA: 0x33F9DE0 Offset: 0x33F9EE1 VA: 0x33F9DE0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>.CompareTo
	|
	|-RVA: 0x33FB4C0 Offset: 0x33FB5C1 VA: 0x33FB4C0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.CompareTo
	|
	|-RVA: 0x33FCC20 Offset: 0x33FCD21 VA: 0x33FCC20
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>.CompareTo
	|
	|-RVA: 0x33FE3F0 Offset: 0x33FE4F1 VA: 0x33FE3F0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.CompareTo
	|
	|-RVA: 0x33FFC10 Offset: 0x33FFD11 VA: 0x33FFC10
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>.CompareTo
	|
	|-RVA: 0x34012B0 Offset: 0x34013B1 VA: 0x34012B0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>>.CompareTo
	|
	|-RVA: 0x3402980 Offset: 0x3402A81 VA: 0x3402980
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.CompareTo
	|
	|-RVA: 0x3403D20 Offset: 0x3403E21 VA: 0x3403D20
	|-ValueTuple<bool, ValueTuple<bool, AsyncUnit>>.CompareTo
	|
	|-RVA: 0x3404F80 Offset: 0x3405081 VA: 0x3404F80
	|-ValueTuple<bool, ValueTuple<bool, bool>>.CompareTo
	|
	|-RVA: 0x34062E0 Offset: 0x34063E1 VA: 0x34062E0
	|-ValueTuple<bool, ValueTuple<bool, Bounds>>.CompareTo
	|
	|-RVA: 0x34076A0 Offset: 0x34077A1 VA: 0x34076A0
	|-ValueTuple<bool, ValueTuple<bool, byte>>.CompareTo
	|
	|-RVA: 0x34089B0 Offset: 0x3408AB1 VA: 0x34089B0
	|-ValueTuple<bool, ValueTuple<bool, Color>>.CompareTo
	|
	|-RVA: 0x3409D20 Offset: 0x3409E21 VA: 0x3409D20
	|-ValueTuple<bool, ValueTuple<bool, double>>.CompareTo
	|
	|-RVA: 0x340AFA0 Offset: 0x340B0A1 VA: 0x340AFA0
	|-ValueTuple<bool, ValueTuple<bool, int>>.CompareTo
	|
	|-RVA: 0x340C240 Offset: 0x340C341 VA: 0x340C240
	|-ValueTuple<bool, ValueTuple<bool, long>>.CompareTo
	|
	|-RVA: 0x351A8F0 Offset: 0x351A9F1 VA: 0x351A8F0
	|-ValueTuple<bool, ValueTuple<bool, object>>.CompareTo
	|
	|-RVA: 0x351BC00 Offset: 0x351BD01 VA: 0x351BC00
	|-ValueTuple<bool, ValueTuple<bool, Quaternion>>.CompareTo
	|
	|-RVA: 0x351D000 Offset: 0x351D101 VA: 0x351D000
	|-ValueTuple<bool, ValueTuple<bool, Rect>>.CompareTo
	|
	|-RVA: 0x351E370 Offset: 0x351E471 VA: 0x351E370
	|-ValueTuple<bool, ValueTuple<bool, float>>.CompareTo
	|
	|-RVA: 0x351F620 Offset: 0x351F721 VA: 0x351F620
	|-ValueTuple<bool, ValueTuple<bool, UniTask>>.CompareTo
	|
	|-RVA: 0x3520880 Offset: 0x3520981 VA: 0x3520880
	|-ValueTuple<bool, ValueTuple<bool, Unit>>.CompareTo
	|
	|-RVA: 0x3521B00 Offset: 0x3521C01 VA: 0x3521B00
	|-ValueTuple<bool, ValueTuple<bool, Vector2>>.CompareTo
	|
	|-RVA: 0x3522E10 Offset: 0x3522F11 VA: 0x3522E10
	|-ValueTuple<bool, ValueTuple<bool, Vector3>>.CompareTo
	|
	|-RVA: 0x3524170 Offset: 0x3524271 VA: 0x3524170
	|-ValueTuple<bool, ValueTuple<bool, Vector4>>.CompareTo
	|
	|-RVA: 0x35254F0 Offset: 0x35255F1 VA: 0x35254F0
	|-ValueTuple<bool, ValueTuple<int, object>>.CompareTo
	|
	|-RVA: 0x3526790 Offset: 0x3526891 VA: 0x3526790
	|-ValueTuple<bool, ValueTuple<object, object>>.CompareTo
	|
	|-RVA: 0x3527B60 Offset: 0x3527C61 VA: 0x3527B60
	|-ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>.CompareTo
	|
	|-RVA: 0x3528FF0 Offset: 0x35290F1 VA: 0x3528FF0
	|-ValueTuple<bool, ValueTuple<object, object, object>>.CompareTo
	|
	|-RVA: 0x352A500 Offset: 0x352A601 VA: 0x352A500
	|-ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.CompareTo
	|
	|-RVA: 0x352BA70 Offset: 0x352BB71 VA: 0x352BA70
	|-ValueTuple<bool, ValueTuple<object, object, object, object>>.CompareTo
	|
	|-RVA: 0x352D030 Offset: 0x352D131 VA: 0x352D030
	|-ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.CompareTo
	|
	|-RVA: 0x352E680 Offset: 0x352E781 VA: 0x352E680
	|-ValueTuple<bool, ValueTuple<object, object, object, object, object>>.CompareTo
	|
	|-RVA: 0x352FD10 Offset: 0x352FE11 VA: 0x352FD10
	|-ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.CompareTo
	|
	|-RVA: 0x3531420 Offset: 0x3531521 VA: 0x3531420
	|-ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>.CompareTo
	|
	|-RVA: 0x3532B60 Offset: 0x3532C61 VA: 0x3532B60
	|-ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.CompareTo
	|
	|-RVA: 0x3534330 Offset: 0x3534431 VA: 0x3534330
	|-ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>.CompareTo
	|
	|-RVA: 0x3535B50 Offset: 0x3535C51 VA: 0x3535B50
	|-ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>.CompareTo
	|
	|-RVA: 0x3537300 Offset: 0x3537401 VA: 0x3537300
	|-ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>.CompareTo
	|
	|-RVA: 0x3538680 Offset: 0x3538781 VA: 0x3538680
	|-ValueTuple<bool, AsyncUnit>.CompareTo
	|
	|-RVA: 0x35397D0 Offset: 0x35398D1 VA: 0x35397D0
	|-ValueTuple<bool, bool>.CompareTo
	|
	|-RVA: 0x353AA30 Offset: 0x353AB31 VA: 0x353AA30
	|-ValueTuple<bool, Bounds>.CompareTo
	|
	|-RVA: 0x353BC30 Offset: 0x353BD31 VA: 0x353BC30
	|-ValueTuple<bool, byte>.CompareTo
	|
	|-RVA: 0x353CDD0 Offset: 0x353CED1 VA: 0x353CDD0
	|-ValueTuple<bool, Color>.CompareTo
	|
	|-RVA: 0x353DF50 Offset: 0x353E051 VA: 0x353DF50
	|-ValueTuple<bool, double>.CompareTo
	|
	|-RVA: 0x353F080 Offset: 0x353F181 VA: 0x353F080
	|-ValueTuple<bool, int>.CompareTo
	|
	|-RVA: 0x35401C0 Offset: 0x35402C1 VA: 0x35401C0
	|-ValueTuple<bool, long>.CompareTo
	|
	|-RVA: 0x37B1D30 Offset: 0x37B1E31 VA: 0x37B1D30
	|-ValueTuple<bool, object>.CompareTo
	|
	|-RVA: 0x37B2E50 Offset: 0x37B2F51 VA: 0x37B2E50
	|-ValueTuple<bool, Quaternion>.CompareTo
	|
	|-RVA: 0x37B4030 Offset: 0x37B4131 VA: 0x37B4030
	|-ValueTuple<bool, Rect>.CompareTo
	|
	|-RVA: 0x37B51B0 Offset: 0x37B52B1 VA: 0x37B51B0
	|-ValueTuple<bool, float>.CompareTo
	|
	|-RVA: 0x37B6300 Offset: 0x37B6401 VA: 0x37B6300
	|-ValueTuple<bool, UniTask>.CompareTo
	|
	|-RVA: 0x37B7430 Offset: 0x37B7531 VA: 0x37B7430
	|-ValueTuple<bool, Unit>.CompareTo
	|
	|-RVA: 0x37B85A0 Offset: 0x37B86A1 VA: 0x37B85A0
	|-ValueTuple<bool, Vector2>.CompareTo
	|
	|-RVA: 0x37B9720 Offset: 0x37B9821 VA: 0x37B9720
	|-ValueTuple<bool, Vector3>.CompareTo
	|
	|-RVA: 0x37BA900 Offset: 0x37BAA01 VA: 0x37BA900
	|-ValueTuple<bool, Vector4>.CompareTo
	|
	|-RVA: 0x37BBAA0 Offset: 0x37BBBA1 VA: 0x37BBAA0
	|-ValueTuple<FXZ, int>.CompareTo
	|
	|-RVA: 0x37BCBE0 Offset: 0x37BCCE1 VA: 0x37BCBE0
	|-ValueTuple<int, bool>.CompareTo
	|
	|-RVA: 0x37BDDF0 Offset: 0x37BDEF1 VA: 0x37BDDF0
	|-ValueTuple<int, Bounds>.CompareTo
	|
	|-RVA: 0x37BEFB0 Offset: 0x37BF0B1 VA: 0x37BEFB0
	|-ValueTuple<int, byte>.CompareTo
	|
	|-RVA: 0x37C0130 Offset: 0x37C0231 VA: 0x37C0130
	|-ValueTuple<int, Color>.CompareTo
	|
	|-RVA: 0x37C1280 Offset: 0x37C1381 VA: 0x37C1280
	|-ValueTuple<int, double>.CompareTo
	|
	|-RVA: 0x37C2390 Offset: 0x37C2491 VA: 0x37C2390
	|-ValueTuple<int, int>.CompareTo
	|
	|-RVA: 0x37C34B0 Offset: 0x37C35B1 VA: 0x37C34B0
	|-ValueTuple<int, long>.CompareTo
	|
	|-RVA: 0x37C45D0 Offset: 0x37C46D1 VA: 0x37C45D0
	|-ValueTuple<int, Int64Enum>.CompareTo
	|
	|-RVA: 0x37C5760 Offset: 0x37C5861 VA: 0x37C5760
	|-ValueTuple<int, object>.CompareTo
	|
	|-RVA: 0x37C6870 Offset: 0x37C6971 VA: 0x37C6870
	|-ValueTuple<int, Quaternion>.CompareTo
	|
	|-RVA: 0x37C7A20 Offset: 0x37C7B21 VA: 0x37C7A20
	|-ValueTuple<int, Rect>.CompareTo
	|
	|-RVA: 0x37C8B60 Offset: 0x37C8C61 VA: 0x37C8B60
	|-ValueTuple<int, float>.CompareTo
	|
	|-RVA: 0x37C9C80 Offset: 0x37C9D81 VA: 0x37C9C80
	|-ValueTuple<int, Unit>.CompareTo
	|
	|-RVA: 0x37CADD0 Offset: 0x37CAED1 VA: 0x37CADD0
	|-ValueTuple<int, Vector2>.CompareTo
	|
	|-RVA: 0x37CBF50 Offset: 0x37CC051 VA: 0x37CBF50
	|-ValueTuple<int, Vector3>.CompareTo
	|
	|-RVA: 0x37CD110 Offset: 0x37CD211 VA: 0x37CD110
	|-ValueTuple<int, Vector4>.CompareTo
	|
	|-RVA: 0x37CE250 Offset: 0x37CE351 VA: 0x37CE250
	|-ValueTuple<Int32Enum, int>.CompareTo
	|
	|-RVA: 0x37CF440 Offset: 0x37CF541 VA: 0x37CF440
	|-ValueTuple<Int64Enum, int>.CompareTo
	|
	|-RVA: 0x37D0630 Offset: 0x37D0731 VA: 0x37D0630
	|-ValueTuple<object, ValueTuple<object, int>>.CompareTo
	|
	|-RVA: 0x37D17D0 Offset: 0x37D18D1 VA: 0x37D17D0
	|-ValueTuple<object, bool>.CompareTo
	|
	|-RVA: 0x37D2830 Offset: 0x37D2931 VA: 0x37D2830
	|-ValueTuple<object, int>.CompareTo
	|
	|-RVA: 0x388B050 Offset: 0x388B151 VA: 0x388B050
	|-ValueTuple<object, object>.CompareTo
	|
	|-RVA: 0x388C020 Offset: 0x388C121 VA: 0x388C020
	|-ValueTuple<object, float>.CompareTo
	|
	|-RVA: 0x388D0E0 Offset: 0x388D1E1 VA: 0x388D0E0
	|-ValueTuple<float, int>.CompareTo
	|
	|-RVA: 0x388E1F0 Offset: 0x388E2F1 VA: 0x388E1F0
	|-ValueTuple<float, Int32Enum>.CompareTo
	|
	|-RVA: 0x388F420 Offset: 0x388F521 VA: 0x388F420
	|-ValueTuple<float, float>.CompareTo
	|
	|-RVA: 0x3890600 Offset: 0x3890701 VA: 0x3890600
	|-ValueTuple<UniTask, CancellationTokenRegistration>.CompareTo
	|
	|-RVA: 0x3891900 Offset: 0x3891A01 VA: 0x3891900
	|-ValueTuple<Vector3, float>.CompareTo
	|
	|-RVA: 0x3892AD0 Offset: 0x3892BD1 VA: 0x3892AD0
	|-ValueTuple<Vector3, Vector3>.CompareTo
	|
	|-RVA: 0x3893CE0 Offset: 0x3893DE1 VA: 0x3893CE0
	|-ValueTuple<Vector4, Vector4>.CompareTo
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private int System.Collections.IStructuralComparable.CompareTo(object other, IComparer comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3393590 Offset: 0x3393691 VA: 0x3393590
	|-ValueTuple<UniTask<object>, UniTask<object>>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x3394920 Offset: 0x3394A21 VA: 0x3394920
	|-ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x3395C70 Offset: 0x3395D71 VA: 0x3395C70
	|-ValueTuple<bool, UniTask<object>>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x3396FF0 Offset: 0x33970F1 VA: 0x3396FF0
	|-ValueTuple<bool, ValueTuple<bool, UniTask<object>>>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x3398440 Offset: 0x3398541 VA: 0x3398440
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x3399910 Offset: 0x3399A11 VA: 0x3399910
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x31F41D0 Offset: 0x31F42D1 VA: 0x31F41D0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>>>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x31F5590 Offset: 0x31F5691 VA: 0x31F5590
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>>>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x31F68A0 Offset: 0x31F69A1 VA: 0x31F68A0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>>>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x31F7D80 Offset: 0x31F7E81 VA: 0x31F7D80
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>>>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x31F91C0 Offset: 0x31F92C1 VA: 0x31F91C0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>>>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x31FA650 Offset: 0x31FA751 VA: 0x31FA650
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>>>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x31FBBF0 Offset: 0x31FBCF1 VA: 0x31FBBF0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>>>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x31FD0B0 Offset: 0x31FD1B1 VA: 0x31FD0B0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>>>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x31FE5C0 Offset: 0x31FE6C1 VA: 0x31FE5C0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>>>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x31FFB30 Offset: 0x31FFC31 VA: 0x31FFB30
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>>>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x3201070 Offset: 0x3201171 VA: 0x3201070
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>>>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x32025F0 Offset: 0x32026F1 VA: 0x32025F0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>>>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x3203AF0 Offset: 0x3203BF1 VA: 0x3203AF0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>>>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x3205010 Offset: 0x3205111 VA: 0x3205010
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>>>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x32063D0 Offset: 0x32064D1 VA: 0x32063D0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>>>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x32077F0 Offset: 0x32078F1 VA: 0x32077F0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>>>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x3208D10 Offset: 0x3208E11 VA: 0x3208D10
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>>>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x320A230 Offset: 0x320A331 VA: 0x320A230
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>>>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x320B7E0 Offset: 0x320B8E1 VA: 0x320B7E0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>>>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x320CD50 Offset: 0x320CE51 VA: 0x320CD50
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>>>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x320E310 Offset: 0x320E411 VA: 0x320E310
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>>>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x320F980 Offset: 0x320FA81 VA: 0x320F980
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>>>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x3211060 Offset: 0x3211161 VA: 0x3211060
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>>>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x32127D0 Offset: 0x32128D1 VA: 0x32127D0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>>>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x3213FA0 Offset: 0x32140A1 VA: 0x3213FA0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>>>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x32154A0 Offset: 0x32155A1 VA: 0x32154A0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x32167B0 Offset: 0x32168B1 VA: 0x32167B0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x3217C80 Offset: 0x3217D81 VA: 0x3217C80
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x3219080 Offset: 0x3219181 VA: 0x3219080
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x321A500 Offset: 0x321A601 VA: 0x321A500
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x321BA00 Offset: 0x321BB01 VA: 0x321BA00
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x3252BB0 Offset: 0x3252CB1 VA: 0x3252BB0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x3254060 Offset: 0x3254161 VA: 0x3254060
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x3255580 Offset: 0x3255681 VA: 0x3255580
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x3256AA0 Offset: 0x3256BA1 VA: 0x3256AA0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x3257FB0 Offset: 0x32580B1 VA: 0x3257FB0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x3259400 Offset: 0x3259501 VA: 0x3259400
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x325A8C0 Offset: 0x325A9C1 VA: 0x325A8C0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x325BC70 Offset: 0x325BD71 VA: 0x325BC70
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x325D080 Offset: 0x325D181 VA: 0x325D080
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x325E500 Offset: 0x325E601 VA: 0x325E500
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x325FA20 Offset: 0x325FB21 VA: 0x325FA20
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x3260F30 Offset: 0x3261031 VA: 0x3260F30
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x3262450 Offset: 0x3262551 VA: 0x3262450
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x3263A50 Offset: 0x3263B51 VA: 0x3263A50
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x3265040 Offset: 0x3265141 VA: 0x3265040
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x32666E0 Offset: 0x32667E1 VA: 0x32666E0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x3267D80 Offset: 0x3267E81 VA: 0x3267D80
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x3269520 Offset: 0x3269621 VA: 0x3269520
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x326AC80 Offset: 0x326AD81 VA: 0x326AC80
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x326C4E0 Offset: 0x326C5E1 VA: 0x326C4E0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x326DCF0 Offset: 0x326DDF1 VA: 0x326DCF0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x326F430 Offset: 0x326F531 VA: 0x326F430
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x3270C30 Offset: 0x3270D31 VA: 0x3270C30
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x3272080 Offset: 0x3272181 VA: 0x3272080
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x32732E0 Offset: 0x32733E1 VA: 0x32732E0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x3274710 Offset: 0x3274811 VA: 0x3274710
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x3275AC0 Offset: 0x3275BC1 VA: 0x3275AC0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x3276E80 Offset: 0x3276F81 VA: 0x3276E80
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x3278330 Offset: 0x3278431 VA: 0x3278330
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x3279690 Offset: 0x3279791 VA: 0x3279690
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x327AA80 Offset: 0x327AB81 VA: 0x327AA80
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x3295E40 Offset: 0x3295F41 VA: 0x3295E40
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x32972B0 Offset: 0x32973B1 VA: 0x32972B0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x3298770 Offset: 0x3298871 VA: 0x3298770
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x3299B20 Offset: 0x3299C21 VA: 0x3299B20
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x329AF20 Offset: 0x329B021 VA: 0x329AF20
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x329C230 Offset: 0x329C331 VA: 0x329C230
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x329D590 Offset: 0x329D691 VA: 0x329D590
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x329E9E0 Offset: 0x329EAE1 VA: 0x329E9E0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x329FE60 Offset: 0x329FF61 VA: 0x329FE60
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x32A1320 Offset: 0x32A1421 VA: 0x32A1320
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x32A2790 Offset: 0x32A2891 VA: 0x32A2790
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x32A3CF0 Offset: 0x32A3DF1 VA: 0x32A3CF0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x32A5280 Offset: 0x32A5381 VA: 0x32A5280
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x32A68D0 Offset: 0x32A69D1 VA: 0x32A68D0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x32A7F10 Offset: 0x32A8011 VA: 0x32A7F10
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x32A9600 Offset: 0x32A9701 VA: 0x32A9600
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x32AAD00 Offset: 0x32AAE01 VA: 0x32AAD00
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x32AC500 Offset: 0x32AC601 VA: 0x32AC500
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x32ADCB0 Offset: 0x32ADDB1 VA: 0x32ADCB0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x32AF560 Offset: 0x32AF661 VA: 0x32AF560
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x32B0DD0 Offset: 0x32B0ED1 VA: 0x32B0DD0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x32B2380 Offset: 0x32B2481 VA: 0x32B2380
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>>>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x32B3840 Offset: 0x32B3941 VA: 0x32B3840
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x32B4BB0 Offset: 0x32B4CB1 VA: 0x32B4BB0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x32B5E70 Offset: 0x32B5F71 VA: 0x32B5E70
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x32B72D0 Offset: 0x32B73D1 VA: 0x32B72D0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x32B8640 Offset: 0x32B8741 VA: 0x32B8640
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x32B9A30 Offset: 0x32B9B31 VA: 0x32B9A30
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x32BAE50 Offset: 0x32BAF51 VA: 0x32BAE50
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x32BC180 Offset: 0x32BC281 VA: 0x32BC180
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x32BD530 Offset: 0x32BD631 VA: 0x32BD530
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x33E5780 Offset: 0x33E5881 VA: 0x33E5780
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x33E6BC0 Offset: 0x33E6CC1 VA: 0x33E6BC0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x33E8030 Offset: 0x33E8131 VA: 0x33E8030
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x33E9390 Offset: 0x33E9491 VA: 0x33E9390
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x33EA740 Offset: 0x33EA841 VA: 0x33EA740
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x33EBA50 Offset: 0x33EBB51 VA: 0x33EBA50
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x33ECD40 Offset: 0x33ECE41 VA: 0x33ECD40
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x33EE0E0 Offset: 0x33EE1E1 VA: 0x33EE0E0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x33EF530 Offset: 0x33EF631 VA: 0x33EF530
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x33F0950 Offset: 0x33F0A51 VA: 0x33F0950
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x33F1D50 Offset: 0x33F1E51 VA: 0x33F1D50
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x33F3240 Offset: 0x33F3341 VA: 0x33F3240
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x33F4710 Offset: 0x33F4811 VA: 0x33F4710
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x33F5CC0 Offset: 0x33F5DC1 VA: 0x33F5CC0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x33F7270 Offset: 0x33F7371 VA: 0x33F7270
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x33F8900 Offset: 0x33F8A01 VA: 0x33F8900
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x33F9F50 Offset: 0x33FA051 VA: 0x33F9F50
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x33FB690 Offset: 0x33FB791 VA: 0x33FB690
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x33FCDA0 Offset: 0x33FCEA1 VA: 0x33FCDA0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x33FE5E0 Offset: 0x33FE6E1 VA: 0x33FE5E0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x33FFDA0 Offset: 0x33FFEA1 VA: 0x33FFDA0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x3401490 Offset: 0x3401591 VA: 0x3401490
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x3402AD0 Offset: 0x3402BD1 VA: 0x3402AD0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x3403E20 Offset: 0x3403F21 VA: 0x3403E20
	|-ValueTuple<bool, ValueTuple<bool, AsyncUnit>>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x3405080 Offset: 0x3405181 VA: 0x3405080
	|-ValueTuple<bool, ValueTuple<bool, bool>>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x3406440 Offset: 0x3406541 VA: 0x3406440
	|-ValueTuple<bool, ValueTuple<bool, Bounds>>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x34077A0 Offset: 0x34078A1 VA: 0x34077A0
	|-ValueTuple<bool, ValueTuple<bool, byte>>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x3408B00 Offset: 0x3408C01 VA: 0x3408B00
	|-ValueTuple<bool, ValueTuple<bool, Color>>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x3409E20 Offset: 0x3409F21 VA: 0x3409E20
	|-ValueTuple<bool, ValueTuple<bool, double>>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x340B0C0 Offset: 0x340B1C1 VA: 0x340B0C0
	|-ValueTuple<bool, ValueTuple<bool, int>>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x340C340 Offset: 0x340C441 VA: 0x340C340
	|-ValueTuple<bool, ValueTuple<bool, long>>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x351A9F0 Offset: 0x351AAF1 VA: 0x351A9F0
	|-ValueTuple<bool, ValueTuple<bool, object>>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x351BD50 Offset: 0x351BE51 VA: 0x351BD50
	|-ValueTuple<bool, ValueTuple<bool, Quaternion>>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x351D150 Offset: 0x351D251 VA: 0x351D150
	|-ValueTuple<bool, ValueTuple<bool, Rect>>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x351E490 Offset: 0x351E591 VA: 0x351E490
	|-ValueTuple<bool, ValueTuple<bool, float>>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x351F720 Offset: 0x351F821 VA: 0x351F720
	|-ValueTuple<bool, ValueTuple<bool, UniTask>>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x3520980 Offset: 0x3520A81 VA: 0x3520980
	|-ValueTuple<bool, ValueTuple<bool, Unit>>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x3521C20 Offset: 0x3521D21 VA: 0x3521C20
	|-ValueTuple<bool, ValueTuple<bool, Vector2>>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x3522F20 Offset: 0x3523021 VA: 0x3522F20
	|-ValueTuple<bool, ValueTuple<bool, Vector3>>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x35242C0 Offset: 0x35243C1 VA: 0x35242C0
	|-ValueTuple<bool, ValueTuple<bool, Vector4>>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x35255F0 Offset: 0x35256F1 VA: 0x35255F0
	|-ValueTuple<bool, ValueTuple<int, object>>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x3526890 Offset: 0x3526991 VA: 0x3526890
	|-ValueTuple<bool, ValueTuple<object, object>>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x3527CC0 Offset: 0x3527DC1 VA: 0x3527CC0
	|-ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x3529130 Offset: 0x3529231 VA: 0x3529130
	|-ValueTuple<bool, ValueTuple<object, object, object>>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x352A680 Offset: 0x352A781 VA: 0x352A680
	|-ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x352BBC0 Offset: 0x352BCC1 VA: 0x352BBC0
	|-ValueTuple<bool, ValueTuple<object, object, object, object>>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x352D1D0 Offset: 0x352D2D1 VA: 0x352D1D0
	|-ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x352E7E0 Offset: 0x352E8E1 VA: 0x352E7E0
	|-ValueTuple<bool, ValueTuple<object, object, object, object, object>>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x352FED0 Offset: 0x352FFD1 VA: 0x352FED0
	|-ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x3531590 Offset: 0x3531691 VA: 0x3531590
	|-ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x3532D40 Offset: 0x3532E41 VA: 0x3532D40
	|-ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x35344B0 Offset: 0x35345B1 VA: 0x35344B0
	|-ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x3535D50 Offset: 0x3535E51 VA: 0x3535D50
	|-ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x3537450 Offset: 0x3537551 VA: 0x3537450
	|-ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x3538780 Offset: 0x3538881 VA: 0x3538780
	|-ValueTuple<bool, AsyncUnit>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x35398E0 Offset: 0x35399E1 VA: 0x35398E0
	|-ValueTuple<bool, bool>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x353AB80 Offset: 0x353AC81 VA: 0x353AB80
	|-ValueTuple<bool, Bounds>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x353BD30 Offset: 0x353BE31 VA: 0x353BD30
	|-ValueTuple<bool, byte>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x353CEE0 Offset: 0x353CFE1 VA: 0x353CEE0
	|-ValueTuple<bool, Color>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x353E050 Offset: 0x353E151 VA: 0x353E050
	|-ValueTuple<bool, double>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x353F180 Offset: 0x353F281 VA: 0x353F180
	|-ValueTuple<bool, int>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x35402C0 Offset: 0x35403C1 VA: 0x35402C0
	|-ValueTuple<bool, long>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x37B1E30 Offset: 0x37B1F31 VA: 0x37B1E30
	|-ValueTuple<bool, object>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x37B2F60 Offset: 0x37B3061 VA: 0x37B2F60
	|-ValueTuple<bool, Quaternion>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x37B4140 Offset: 0x37B4241 VA: 0x37B4140
	|-ValueTuple<bool, Rect>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x37B52B0 Offset: 0x37B53B1 VA: 0x37B52B0
	|-ValueTuple<bool, float>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x37B6400 Offset: 0x37B6501 VA: 0x37B6400
	|-ValueTuple<bool, UniTask>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x37B7530 Offset: 0x37B7631 VA: 0x37B7530
	|-ValueTuple<bool, Unit>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x37B86B0 Offset: 0x37B87B1 VA: 0x37B86B0
	|-ValueTuple<bool, Vector2>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x37B9840 Offset: 0x37B9941 VA: 0x37B9840
	|-ValueTuple<bool, Vector3>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x37BAA10 Offset: 0x37BAB11 VA: 0x37BAA10
	|-ValueTuple<bool, Vector4>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x37BBBB0 Offset: 0x37BBCB1 VA: 0x37BBBB0
	|-ValueTuple<FXZ, int>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x37BCCE0 Offset: 0x37BCDE1 VA: 0x37BCCE0
	|-ValueTuple<int, bool>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x37BDF40 Offset: 0x37BE041 VA: 0x37BDF40
	|-ValueTuple<int, Bounds>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x37BF0B0 Offset: 0x37BF1B1 VA: 0x37BF0B0
	|-ValueTuple<int, byte>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x37C0230 Offset: 0x37C0331 VA: 0x37C0230
	|-ValueTuple<int, Color>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x37C1380 Offset: 0x37C1481 VA: 0x37C1380
	|-ValueTuple<int, double>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x37C2490 Offset: 0x37C2591 VA: 0x37C2490
	|-ValueTuple<int, int>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x37C35B0 Offset: 0x37C36B1 VA: 0x37C35B0
	|-ValueTuple<int, long>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x37C46D0 Offset: 0x37C47D1 VA: 0x37C46D0
	|-ValueTuple<int, Int64Enum>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x37C5860 Offset: 0x37C5961 VA: 0x37C5860
	|-ValueTuple<int, object>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x37C6970 Offset: 0x37C6A71 VA: 0x37C6970
	|-ValueTuple<int, Quaternion>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x37C7B20 Offset: 0x37C7C21 VA: 0x37C7B20
	|-ValueTuple<int, Rect>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x37C8C60 Offset: 0x37C8D61 VA: 0x37C8C60
	|-ValueTuple<int, float>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x37C9D80 Offset: 0x37C9E81 VA: 0x37C9D80
	|-ValueTuple<int, Unit>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x37CAEE0 Offset: 0x37CAFE1 VA: 0x37CAEE0
	|-ValueTuple<int, Vector2>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x37CC060 Offset: 0x37CC161 VA: 0x37CC060
	|-ValueTuple<int, Vector3>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x37CD210 Offset: 0x37CD311 VA: 0x37CD210
	|-ValueTuple<int, Vector4>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x37CE350 Offset: 0x37CE451 VA: 0x37CE350
	|-ValueTuple<Int32Enum, int>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x37CF540 Offset: 0x37CF641 VA: 0x37CF540
	|-ValueTuple<Int64Enum, int>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x37D0730 Offset: 0x37D0831 VA: 0x37D0730
	|-ValueTuple<object, ValueTuple<object, int>>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x37D18D0 Offset: 0x37D19D1 VA: 0x37D18D0
	|-ValueTuple<object, bool>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x37D2930 Offset: 0x37D2A31 VA: 0x37D2930
	|-ValueTuple<object, int>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x388B150 Offset: 0x388B251 VA: 0x388B150
	|-ValueTuple<object, object>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x388C120 Offset: 0x388C221 VA: 0x388C120
	|-ValueTuple<object, float>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x388D1E0 Offset: 0x388D2E1 VA: 0x388D1E0
	|-ValueTuple<float, int>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x388E2F0 Offset: 0x388E3F1 VA: 0x388E2F0
	|-ValueTuple<float, Int32Enum>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x388F520 Offset: 0x388F621 VA: 0x388F520
	|-ValueTuple<float, float>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x3890740 Offset: 0x3890841 VA: 0x3890740
	|-ValueTuple<UniTask, CancellationTokenRegistration>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x3891A20 Offset: 0x3891B21 VA: 0x3891A20
	|-ValueTuple<Vector3, float>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x3892BE0 Offset: 0x3892CE1 VA: 0x3892BE0
	|-ValueTuple<Vector3, Vector3>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x3893DF0 Offset: 0x3893EF1 VA: 0x3893DF0
	|-ValueTuple<Vector4, Vector4>.System.Collections.IStructuralComparable.CompareTo
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public override int GetHashCode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3393940 Offset: 0x3393A41 VA: 0x3393940
	|-ValueTuple<UniTask<object>, UniTask<object>>.GetHashCode
	|
	|-RVA: 0x3394CD0 Offset: 0x3394DD1 VA: 0x3394CD0
	|-ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>.GetHashCode
	|
	|-RVA: 0x3396020 Offset: 0x3396121 VA: 0x3396020
	|-ValueTuple<bool, UniTask<object>>.GetHashCode
	|
	|-RVA: 0x33973F0 Offset: 0x33974F1 VA: 0x33973F0
	|-ValueTuple<bool, ValueTuple<bool, UniTask<object>>>.GetHashCode
	|
	|-RVA: 0x3398860 Offset: 0x3398961 VA: 0x3398860
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>.GetHashCode
	|
	|-RVA: 0x3399D50 Offset: 0x3399E51 VA: 0x3399D50
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>>.GetHashCode
	|
	|-RVA: 0x31F4620 Offset: 0x31F4721 VA: 0x31F4620
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>>>.GetHashCode
	|
	|-RVA: 0x31F5960 Offset: 0x31F5A61 VA: 0x31F5960
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>>>.GetHashCode
	|
	|-RVA: 0x31F6C70 Offset: 0x31F6D71 VA: 0x31F6C70
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>>>.GetHashCode
	|
	|-RVA: 0x31F81E0 Offset: 0x31F82E1 VA: 0x31F81E0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>>>.GetHashCode
	|
	|-RVA: 0x31F9590 Offset: 0x31F9691 VA: 0x31F9590
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>>>.GetHashCode
	|
	|-RVA: 0x31FAA90 Offset: 0x31FAB91 VA: 0x31FAA90
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>>>.GetHashCode
	|
	|-RVA: 0x31FC040 Offset: 0x31FC141 VA: 0x31FC040
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>>>.GetHashCode
	|
	|-RVA: 0x31FD4C0 Offset: 0x31FD5C1 VA: 0x31FD4C0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>>>.GetHashCode
	|
	|-RVA: 0x31FEA10 Offset: 0x31FEB11 VA: 0x31FEA10
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>>>.GetHashCode
	|
	|-RVA: 0x31FFF80 Offset: 0x3200081 VA: 0x31FFF80
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>>>.GetHashCode
	|
	|-RVA: 0x32014B0 Offset: 0x32015B1 VA: 0x32014B0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>>>.GetHashCode
	|
	|-RVA: 0x3202A30 Offset: 0x3202B31 VA: 0x3202A30
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>>>.GetHashCode
	|
	|-RVA: 0x3203F00 Offset: 0x3204001 VA: 0x3203F00
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>>>.GetHashCode
	|
	|-RVA: 0x3205460 Offset: 0x3205561 VA: 0x3205460
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>>>.GetHashCode
	|
	|-RVA: 0x32067A0 Offset: 0x32068A1 VA: 0x32067A0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>>>.GetHashCode
	|
	|-RVA: 0x3207C00 Offset: 0x3207D01 VA: 0x3207C00
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>>>.GetHashCode
	|
	|-RVA: 0x3209140 Offset: 0x3209241 VA: 0x3209140
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>>>.GetHashCode
	|
	|-RVA: 0x320A670 Offset: 0x320A771 VA: 0x320A670
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>>>.GetHashCode
	|
	|-RVA: 0x320BC30 Offset: 0x320BD31 VA: 0x320BC30
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>>>.GetHashCode
	|
	|-RVA: 0x320D1A0 Offset: 0x320D2A1 VA: 0x320D1A0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>>>.GetHashCode
	|
	|-RVA: 0x320E780 Offset: 0x320E881 VA: 0x320E780
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>>>.GetHashCode
	|
	|-RVA: 0x320FE10 Offset: 0x320FF11 VA: 0x320FE10
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>>>.GetHashCode
	|
	|-RVA: 0x3211510 Offset: 0x3211611 VA: 0x3211510
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>>>.GetHashCode
	|
	|-RVA: 0x3212C90 Offset: 0x3212D91 VA: 0x3212C90
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>>>.GetHashCode
	|
	|-RVA: 0x3214480 Offset: 0x3214581 VA: 0x3214480
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>>>.GetHashCode
	|
	|-RVA: 0x3215870 Offset: 0x3215971 VA: 0x3215870
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>>.GetHashCode
	|
	|-RVA: 0x3216B80 Offset: 0x3216C81 VA: 0x3216B80
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>>.GetHashCode
	|
	|-RVA: 0x32180D0 Offset: 0x32181D1 VA: 0x32180D0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>>.GetHashCode
	|
	|-RVA: 0x3219450 Offset: 0x3219551 VA: 0x3219450
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>>.GetHashCode
	|
	|-RVA: 0x321A930 Offset: 0x321AA31 VA: 0x321A930
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>>.GetHashCode
	|
	|-RVA: 0x321BE40 Offset: 0x321BF41 VA: 0x321BE40
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>>.GetHashCode
	|
	|-RVA: 0x3252FA0 Offset: 0x32530A1 VA: 0x3252FA0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>>.GetHashCode
	|
	|-RVA: 0x32544A0 Offset: 0x32545A1 VA: 0x32544A0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>>.GetHashCode
	|
	|-RVA: 0x32559C0 Offset: 0x3255AC1 VA: 0x32559C0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>>.GetHashCode
	|
	|-RVA: 0x3256ED0 Offset: 0x3256FD1 VA: 0x3256ED0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>>.GetHashCode
	|
	|-RVA: 0x32583E0 Offset: 0x32584E1 VA: 0x32583E0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>>.GetHashCode
	|
	|-RVA: 0x32597F0 Offset: 0x32598F1 VA: 0x32597F0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>>.GetHashCode
	|
	|-RVA: 0x325AD00 Offset: 0x325AE01 VA: 0x325AD00
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>>.GetHashCode
	|
	|-RVA: 0x325C040 Offset: 0x325C141 VA: 0x325C040
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>>.GetHashCode
	|
	|-RVA: 0x325D490 Offset: 0x325D591 VA: 0x325D490
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>>.GetHashCode
	|
	|-RVA: 0x325E910 Offset: 0x325EA11 VA: 0x325E910
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>>.GetHashCode
	|
	|-RVA: 0x325FE50 Offset: 0x325FF51 VA: 0x325FE50
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>>.GetHashCode
	|
	|-RVA: 0x3261370 Offset: 0x3261471 VA: 0x3261370
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>>.GetHashCode
	|
	|-RVA: 0x3262890 Offset: 0x3262991 VA: 0x3262890
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>>.GetHashCode
	|
	|-RVA: 0x3263EE0 Offset: 0x3263FE1 VA: 0x3263EE0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.GetHashCode
	|
	|-RVA: 0x3265490 Offset: 0x3265591 VA: 0x3265490
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>>.GetHashCode
	|
	|-RVA: 0x3266BA0 Offset: 0x3266CA1 VA: 0x3266BA0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.GetHashCode
	|
	|-RVA: 0x32681F0 Offset: 0x32682F1 VA: 0x32681F0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>>.GetHashCode
	|
	|-RVA: 0x3269A10 Offset: 0x3269B11 VA: 0x3269A10
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.GetHashCode
	|
	|-RVA: 0x326B110 Offset: 0x326B211 VA: 0x326B110
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>>.GetHashCode
	|
	|-RVA: 0x326CA00 Offset: 0x326CB01 VA: 0x326CA00
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.GetHashCode
	|
	|-RVA: 0x326E1A0 Offset: 0x326E2A1 VA: 0x326E1A0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>>.GetHashCode
	|
	|-RVA: 0x326F8C0 Offset: 0x326F9C1 VA: 0x326F8C0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.GetHashCode
	|
	|-RVA: 0x32710F0 Offset: 0x32711F1 VA: 0x32710F0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>>.GetHashCode
	|
	|-RVA: 0x3272430 Offset: 0x3272531 VA: 0x3272430
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>.GetHashCode
	|
	|-RVA: 0x3273690 Offset: 0x3273791 VA: 0x3273690
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>.GetHashCode
	|
	|-RVA: 0x3274B50 Offset: 0x3274C51 VA: 0x3274B50
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>.GetHashCode
	|
	|-RVA: 0x3275E70 Offset: 0x3275F71 VA: 0x3275E70
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>.GetHashCode
	|
	|-RVA: 0x3277290 Offset: 0x3277391 VA: 0x3277290
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>.GetHashCode
	|
	|-RVA: 0x3278750 Offset: 0x3278851 VA: 0x3278750
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>.GetHashCode
	|
	|-RVA: 0x3279A50 Offset: 0x3279B51 VA: 0x3279A50
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>.GetHashCode
	|
	|-RVA: 0x327AEA0 Offset: 0x327AFA1 VA: 0x327AEA0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>.GetHashCode
	|
	|-RVA: 0x3296260 Offset: 0x3296361 VA: 0x3296260
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>.GetHashCode
	|
	|-RVA: 0x32976C0 Offset: 0x32977C1 VA: 0x32976C0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>.GetHashCode
	|
	|-RVA: 0x3298B80 Offset: 0x3298C81 VA: 0x3298B80
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>.GetHashCode
	|
	|-RVA: 0x3299EE0 Offset: 0x3299FE1 VA: 0x3299EE0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>.GetHashCode
	|
	|-RVA: 0x329B340 Offset: 0x329B441 VA: 0x329B340
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>.GetHashCode
	|
	|-RVA: 0x329C5E0 Offset: 0x329C6E1 VA: 0x329C5E0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>.GetHashCode
	|
	|-RVA: 0x329D980 Offset: 0x329DA81 VA: 0x329D980
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>.GetHashCode
	|
	|-RVA: 0x329EDF0 Offset: 0x329EEF1 VA: 0x329EDF0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>.GetHashCode
	|
	|-RVA: 0x32A0270 Offset: 0x32A0371 VA: 0x32A0270
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>.GetHashCode
	|
	|-RVA: 0x32A1740 Offset: 0x32A1841 VA: 0x32A1740
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>.GetHashCode
	|
	|-RVA: 0x32A2BB0 Offset: 0x32A2CB1 VA: 0x32A2BB0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>.GetHashCode
	|
	|-RVA: 0x32A4160 Offset: 0x32A4261 VA: 0x32A4160
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.GetHashCode
	|
	|-RVA: 0x32A56C0 Offset: 0x32A57C1 VA: 0x32A56C0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>.GetHashCode
	|
	|-RVA: 0x32A6D80 Offset: 0x32A6E81 VA: 0x32A6D80
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.GetHashCode
	|
	|-RVA: 0x32A8360 Offset: 0x32A8461 VA: 0x32A8360
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>.GetHashCode
	|
	|-RVA: 0x32A9AE0 Offset: 0x32A9BE1 VA: 0x32A9AE0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.GetHashCode
	|
	|-RVA: 0x32AB170 Offset: 0x32AB271 VA: 0x32AB170
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>.GetHashCode
	|
	|-RVA: 0x32ACA10 Offset: 0x32ACB11 VA: 0x32ACA10
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.GetHashCode
	|
	|-RVA: 0x32AE140 Offset: 0x32AE241 VA: 0x32AE140
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>.GetHashCode
	|
	|-RVA: 0x32AFAA0 Offset: 0x32AFBA1 VA: 0x32AFAA0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.GetHashCode
	|
	|-RVA: 0x32B1280 Offset: 0x32B1381 VA: 0x32B1280
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>.GetHashCode
	|
	|-RVA: 0x32B2790 Offset: 0x32B2891 VA: 0x32B2790
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>>>.GetHashCode
	|
	|-RVA: 0x32B3C50 Offset: 0x32B3D51 VA: 0x32B3C50
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.GetHashCode
	|
	|-RVA: 0x32B4F70 Offset: 0x32B5071 VA: 0x32B4F70
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>.GetHashCode
	|
	|-RVA: 0x32B6230 Offset: 0x32B6331 VA: 0x32B6230
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>.GetHashCode
	|
	|-RVA: 0x32B7700 Offset: 0x32B7801 VA: 0x32B7700
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>.GetHashCode
	|
	|-RVA: 0x32B8A00 Offset: 0x32B8B01 VA: 0x32B8A00
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>.GetHashCode
	|
	|-RVA: 0x32B9E40 Offset: 0x32B9F41 VA: 0x32B9E40
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>.GetHashCode
	|
	|-RVA: 0x32BB250 Offset: 0x32BB351 VA: 0x32BB250
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>.GetHashCode
	|
	|-RVA: 0x32BC540 Offset: 0x32BC641 VA: 0x32BC540
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>.GetHashCode
	|
	|-RVA: 0x32BD930 Offset: 0x32BDA31 VA: 0x32BD930
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>.GetHashCode
	|
	|-RVA: 0x33E5B80 Offset: 0x33E5C81 VA: 0x33E5B80
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>.GetHashCode
	|
	|-RVA: 0x33E6FD0 Offset: 0x33E70D1 VA: 0x33E6FD0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>.GetHashCode
	|
	|-RVA: 0x33E8440 Offset: 0x33E8541 VA: 0x33E8440
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>.GetHashCode
	|
	|-RVA: 0x33E9750 Offset: 0x33E9851 VA: 0x33E9750
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>.GetHashCode
	|
	|-RVA: 0x33EAB40 Offset: 0x33EAC41 VA: 0x33EAB40
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>.GetHashCode
	|
	|-RVA: 0x33EBE10 Offset: 0x33EBF11 VA: 0x33EBE10
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>.GetHashCode
	|
	|-RVA: 0x33ED100 Offset: 0x33ED201 VA: 0x33ED100
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>.GetHashCode
	|
	|-RVA: 0x33EE4D0 Offset: 0x33EE5D1 VA: 0x33EE4D0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>.GetHashCode
	|
	|-RVA: 0x33EF940 Offset: 0x33EFA41 VA: 0x33EF940
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>.GetHashCode
	|
	|-RVA: 0x33F0D50 Offset: 0x33F0E51 VA: 0x33F0D50
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>.GetHashCode
	|
	|-RVA: 0x33F2150 Offset: 0x33F2251 VA: 0x33F2150
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>.GetHashCode
	|
	|-RVA: 0x33F3690 Offset: 0x33F3791 VA: 0x33F3690
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.GetHashCode
	|
	|-RVA: 0x33F4B30 Offset: 0x33F4C31 VA: 0x33F4B30
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>.GetHashCode
	|
	|-RVA: 0x33F6150 Offset: 0x33F6251 VA: 0x33F6150
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.GetHashCode
	|
	|-RVA: 0x33F76B0 Offset: 0x33F77B1 VA: 0x33F76B0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>.GetHashCode
	|
	|-RVA: 0x33F8DC0 Offset: 0x33F8EC1 VA: 0x33F8DC0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.GetHashCode
	|
	|-RVA: 0x33FA3A0 Offset: 0x33FA4A1 VA: 0x33FA3A0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>.GetHashCode
	|
	|-RVA: 0x33FBB80 Offset: 0x33FBC81 VA: 0x33FBB80
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.GetHashCode
	|
	|-RVA: 0x33FD210 Offset: 0x33FD311 VA: 0x33FD210
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>.GetHashCode
	|
	|-RVA: 0x33FEB00 Offset: 0x33FEC01 VA: 0x33FEB00
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.GetHashCode
	|
	|-RVA: 0x3400230 Offset: 0x3400331 VA: 0x3400230
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>.GetHashCode
	|
	|-RVA: 0x3401920 Offset: 0x3401A21 VA: 0x3401920
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>>.GetHashCode
	|
	|-RVA: 0x3402EE0 Offset: 0x3402FE1 VA: 0x3402EE0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.GetHashCode
	|
	|-RVA: 0x34041D0 Offset: 0x34042D1 VA: 0x34041D0
	|-ValueTuple<bool, ValueTuple<bool, AsyncUnit>>.GetHashCode
	|
	|-RVA: 0x3405430 Offset: 0x3405531 VA: 0x3405430
	|-ValueTuple<bool, ValueTuple<bool, bool>>.GetHashCode
	|
	|-RVA: 0x3406850 Offset: 0x3406951 VA: 0x3406850
	|-ValueTuple<bool, ValueTuple<bool, Bounds>>.GetHashCode
	|
	|-RVA: 0x3407B50 Offset: 0x3407C51 VA: 0x3407B50
	|-ValueTuple<bool, ValueTuple<bool, byte>>.GetHashCode
	|
	|-RVA: 0x3408EF0 Offset: 0x3408FF1 VA: 0x3408EF0
	|-ValueTuple<bool, ValueTuple<bool, Color>>.GetHashCode
	|
	|-RVA: 0x340A1D0 Offset: 0x340A2D1 VA: 0x340A1D0
	|-ValueTuple<bool, ValueTuple<bool, double>>.GetHashCode
	|
	|-RVA: 0x340B470 Offset: 0x340B571 VA: 0x340B470
	|-ValueTuple<bool, ValueTuple<bool, int>>.GetHashCode
	|
	|-RVA: 0x340C6F0 Offset: 0x340C7F1 VA: 0x340C6F0
	|-ValueTuple<bool, ValueTuple<bool, long>>.GetHashCode
	|
	|-RVA: 0x351ADA0 Offset: 0x351AEA1 VA: 0x351ADA0
	|-ValueTuple<bool, ValueTuple<bool, object>>.GetHashCode
	|
	|-RVA: 0x351C140 Offset: 0x351C241 VA: 0x351C140
	|-ValueTuple<bool, ValueTuple<bool, Quaternion>>.GetHashCode
	|
	|-RVA: 0x351D540 Offset: 0x351D641 VA: 0x351D540
	|-ValueTuple<bool, ValueTuple<bool, Rect>>.GetHashCode
	|
	|-RVA: 0x351E840 Offset: 0x351E941 VA: 0x351E840
	|-ValueTuple<bool, ValueTuple<bool, float>>.GetHashCode
	|
	|-RVA: 0x351FAD0 Offset: 0x351FBD1 VA: 0x351FAD0
	|-ValueTuple<bool, ValueTuple<bool, UniTask>>.GetHashCode
	|
	|-RVA: 0x3520D30 Offset: 0x3520E31 VA: 0x3520D30
	|-ValueTuple<bool, ValueTuple<bool, Unit>>.GetHashCode
	|
	|-RVA: 0x3521FE0 Offset: 0x35220E1 VA: 0x3521FE0
	|-ValueTuple<bool, ValueTuple<bool, Vector2>>.GetHashCode
	|
	|-RVA: 0x35232E0 Offset: 0x35233E1 VA: 0x35232E0
	|-ValueTuple<bool, ValueTuple<bool, Vector3>>.GetHashCode
	|
	|-RVA: 0x35246B0 Offset: 0x35247B1 VA: 0x35246B0
	|-ValueTuple<bool, ValueTuple<bool, Vector4>>.GetHashCode
	|
	|-RVA: 0x35259A0 Offset: 0x3525AA1 VA: 0x35259A0
	|-ValueTuple<bool, ValueTuple<int, object>>.GetHashCode
	|
	|-RVA: 0x3526C40 Offset: 0x3526D41 VA: 0x3526C40
	|-ValueTuple<bool, ValueTuple<object, object>>.GetHashCode
	|
	|-RVA: 0x3528100 Offset: 0x3528201 VA: 0x3528100
	|-ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>.GetHashCode
	|
	|-RVA: 0x3529530 Offset: 0x3529631 VA: 0x3529530
	|-ValueTuple<bool, ValueTuple<object, object, object>>.GetHashCode
	|
	|-RVA: 0x352AAF0 Offset: 0x352ABF1 VA: 0x352AAF0
	|-ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.GetHashCode
	|
	|-RVA: 0x352BFE0 Offset: 0x352C0E1 VA: 0x352BFE0
	|-ValueTuple<bool, ValueTuple<object, object, object, object>>.GetHashCode
	|
	|-RVA: 0x352D680 Offset: 0x352D781 VA: 0x352D680
	|-ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.GetHashCode
	|
	|-RVA: 0x352EC20 Offset: 0x352ED21 VA: 0x352EC20
	|-ValueTuple<bool, ValueTuple<object, object, object, object, object>>.GetHashCode
	|
	|-RVA: 0x35303B0 Offset: 0x35304B1 VA: 0x35303B0
	|-ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.GetHashCode
	|
	|-RVA: 0x35319E0 Offset: 0x3531AE1 VA: 0x35319E0
	|-ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>.GetHashCode
	|
	|-RVA: 0x3533250 Offset: 0x3533351 VA: 0x3533250
	|-ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.GetHashCode
	|
	|-RVA: 0x3534920 Offset: 0x3534A21 VA: 0x3534920
	|-ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>.GetHashCode
	|
	|-RVA: 0x3536290 Offset: 0x3536391 VA: 0x3536290
	|-ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>.GetHashCode
	|
	|-RVA: 0x3537860 Offset: 0x3537961 VA: 0x3537860
	|-ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>.GetHashCode
	|
	|-RVA: 0x3538B30 Offset: 0x3538C31 VA: 0x3538B30
	|-ValueTuple<bool, AsyncUnit>.GetHashCode
	|
	|-RVA: 0x3539C90 Offset: 0x3539D91 VA: 0x3539C90
	|-ValueTuple<bool, bool>.GetHashCode
	|
	|-RVA: 0x353AF90 Offset: 0x353B091 VA: 0x353AF90
	|-ValueTuple<bool, Bounds>.GetHashCode
	|
	|-RVA: 0x353C0E0 Offset: 0x353C1E1 VA: 0x353C0E0
	|-ValueTuple<bool, byte>.GetHashCode
	|
	|-RVA: 0x353D2B0 Offset: 0x353D3B1 VA: 0x353D2B0
	|-ValueTuple<bool, Color>.GetHashCode
	|
	|-RVA: 0x353E400 Offset: 0x353E501 VA: 0x353E400
	|-ValueTuple<bool, double>.GetHashCode
	|
	|-RVA: 0x353F530 Offset: 0x353F631 VA: 0x353F530
	|-ValueTuple<bool, int>.GetHashCode
	|
	|-RVA: 0x3540670 Offset: 0x3540771 VA: 0x3540670
	|-ValueTuple<bool, long>.GetHashCode
	|
	|-RVA: 0x37B2150 Offset: 0x37B2251 VA: 0x37B2150
	|-ValueTuple<bool, object>.GetHashCode
	|
	|-RVA: 0x37B3330 Offset: 0x37B3431 VA: 0x37B3330
	|-ValueTuple<bool, Quaternion>.GetHashCode
	|
	|-RVA: 0x37B4510 Offset: 0x37B4611 VA: 0x37B4510
	|-ValueTuple<bool, Rect>.GetHashCode
	|
	|-RVA: 0x37B5660 Offset: 0x37B5761 VA: 0x37B5660
	|-ValueTuple<bool, float>.GetHashCode
	|
	|-RVA: 0x37B67B0 Offset: 0x37B68B1 VA: 0x37B67B0
	|-ValueTuple<bool, UniTask>.GetHashCode
	|
	|-RVA: 0x37B78E0 Offset: 0x37B79E1 VA: 0x37B78E0
	|-ValueTuple<bool, Unit>.GetHashCode
	|
	|-RVA: 0x37B8A60 Offset: 0x37B8B61 VA: 0x37B8A60
	|-ValueTuple<bool, Vector2>.GetHashCode
	|
	|-RVA: 0x37B9C00 Offset: 0x37B9D01 VA: 0x37B9C00
	|-ValueTuple<bool, Vector3>.GetHashCode
	|
	|-RVA: 0x37BADE0 Offset: 0x37BAEE1 VA: 0x37BADE0
	|-ValueTuple<bool, Vector4>.GetHashCode
	|
	|-RVA: 0x37BBF60 Offset: 0x37BC061 VA: 0x37BBF60
	|-ValueTuple<FXZ, int>.GetHashCode
	|
	|-RVA: 0x37BD090 Offset: 0x37BD191 VA: 0x37BD090
	|-ValueTuple<int, bool>.GetHashCode
	|
	|-RVA: 0x37BE320 Offset: 0x37BE421 VA: 0x37BE320
	|-ValueTuple<int, Bounds>.GetHashCode
	|
	|-RVA: 0x37BF450 Offset: 0x37BF551 VA: 0x37BF450
	|-ValueTuple<int, byte>.GetHashCode
	|
	|-RVA: 0x37C05F0 Offset: 0x37C06F1 VA: 0x37C05F0
	|-ValueTuple<int, Color>.GetHashCode
	|
	|-RVA: 0x37C1720 Offset: 0x37C1821 VA: 0x37C1720
	|-ValueTuple<int, double>.GetHashCode
	|
	|-RVA: 0x37C2830 Offset: 0x37C2931 VA: 0x37C2830
	|-ValueTuple<int, int>.GetHashCode
	|
	|-RVA: 0x37C3950 Offset: 0x37C3A51 VA: 0x37C3950
	|-ValueTuple<int, long>.GetHashCode
	|
	|-RVA: 0x37C4A70 Offset: 0x37C4B71 VA: 0x37C4A70
	|-ValueTuple<int, Int64Enum>.GetHashCode
	|
	|-RVA: 0x37C5B80 Offset: 0x37C5C81 VA: 0x37C5B80
	|-ValueTuple<int, object>.GetHashCode
	|
	|-RVA: 0x37C6D30 Offset: 0x37C6E31 VA: 0x37C6D30
	|-ValueTuple<int, Quaternion>.GetHashCode
	|
	|-RVA: 0x37C7EE0 Offset: 0x37C7FE1 VA: 0x37C7EE0
	|-ValueTuple<int, Rect>.GetHashCode
	|
	|-RVA: 0x37C9000 Offset: 0x37C9101 VA: 0x37C9000
	|-ValueTuple<int, float>.GetHashCode
	|
	|-RVA: 0x37CA120 Offset: 0x37CA221 VA: 0x37CA120
	|-ValueTuple<int, Unit>.GetHashCode
	|
	|-RVA: 0x37CB290 Offset: 0x37CB391 VA: 0x37CB290
	|-ValueTuple<int, Vector2>.GetHashCode
	|
	|-RVA: 0x37CC420 Offset: 0x37CC521 VA: 0x37CC420
	|-ValueTuple<int, Vector3>.GetHashCode
	|
	|-RVA: 0x37CD5D0 Offset: 0x37CD6D1 VA: 0x37CD5D0
	|-ValueTuple<int, Vector4>.GetHashCode
	|
	|-RVA: 0x37CE6F0 Offset: 0x37CE7F1 VA: 0x37CE6F0
	|-ValueTuple<Int32Enum, int>.GetHashCode
	|
	|-RVA: 0x37CF8E0 Offset: 0x37CF9E1 VA: 0x37CF8E0
	|-ValueTuple<Int64Enum, int>.GetHashCode
	|
	|-RVA: 0x37D0A60 Offset: 0x37D0B61 VA: 0x37D0A60
	|-ValueTuple<object, ValueTuple<object, int>>.GetHashCode
	|
	|-RVA: 0x37D1C00 Offset: 0x37D1D01 VA: 0x37D1C00
	|-ValueTuple<object, bool>.GetHashCode
	|
	|-RVA: 0x37D2C50 Offset: 0x37D2D51 VA: 0x37D2C50
	|-ValueTuple<object, int>.GetHashCode
	|
	|-RVA: 0x388B400 Offset: 0x388B501 VA: 0x388B400
	|-ValueTuple<object, object>.GetHashCode
	|
	|-RVA: 0x388C450 Offset: 0x388C551 VA: 0x388C450
	|-ValueTuple<object, float>.GetHashCode
	|
	|-RVA: 0x388D580 Offset: 0x388D681 VA: 0x388D580
	|-ValueTuple<float, int>.GetHashCode
	|
	|-RVA: 0x388E690 Offset: 0x388E791 VA: 0x388E690
	|-ValueTuple<float, Int32Enum>.GetHashCode
	|
	|-RVA: 0x388F8C0 Offset: 0x388F9C1 VA: 0x388F8C0
	|-ValueTuple<float, float>.GetHashCode
	|
	|-RVA: 0x3890B10 Offset: 0x3890C11 VA: 0x3890B10
	|-ValueTuple<UniTask, CancellationTokenRegistration>.GetHashCode
	|
	|-RVA: 0x3891DD0 Offset: 0x3891ED1 VA: 0x3891DD0
	|-ValueTuple<Vector3, float>.GetHashCode
	|
	|-RVA: 0x3892FB0 Offset: 0x38930B1 VA: 0x3892FB0
	|-ValueTuple<Vector3, Vector3>.GetHashCode
	|
	|-RVA: 0x38941E0 Offset: 0x38942E1 VA: 0x38941E0
	|-ValueTuple<Vector4, Vector4>.GetHashCode
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private int System.Collections.IStructuralEquatable.GetHashCode(IEqualityComparer comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3393A30 Offset: 0x3393B31 VA: 0x3393A30
	|-ValueTuple<UniTask<object>, UniTask<object>>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x3394DB0 Offset: 0x3394EB1 VA: 0x3394DB0
	|-ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x33960C0 Offset: 0x33961C1 VA: 0x33960C0
	|-ValueTuple<bool, UniTask<object>>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x33974A0 Offset: 0x33975A1 VA: 0x33974A0
	|-ValueTuple<bool, ValueTuple<bool, UniTask<object>>>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x3398910 Offset: 0x3398A11 VA: 0x3398910
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x3399E10 Offset: 0x3399F11 VA: 0x3399E10
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x31F46E0 Offset: 0x31F47E1 VA: 0x31F46E0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>>>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x31F5A10 Offset: 0x31F5B11 VA: 0x31F5A10
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>>>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x31F6D20 Offset: 0x31F6E21 VA: 0x31F6D20
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>>>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x31F82C0 Offset: 0x31F83C1 VA: 0x31F82C0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>>>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x31F9640 Offset: 0x31F9741 VA: 0x31F9640
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>>>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x31FAB60 Offset: 0x31FAC61 VA: 0x31FAB60
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>>>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x31FC100 Offset: 0x31FC201 VA: 0x31FC100
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>>>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x31FD580 Offset: 0x31FD681 VA: 0x31FD580
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>>>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x31FEAD0 Offset: 0x31FEBD1 VA: 0x31FEAD0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>>>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x3200040 Offset: 0x3200141 VA: 0x3200040
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>>>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x3201580 Offset: 0x3201681 VA: 0x3201580
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>>>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x3202B00 Offset: 0x3202C01 VA: 0x3202B00
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>>>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x3203FC0 Offset: 0x32040C1 VA: 0x3203FC0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>>>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x3205520 Offset: 0x3205621 VA: 0x3205520
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>>>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x3206850 Offset: 0x3206951 VA: 0x3206850
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>>>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x3207CD0 Offset: 0x3207DD1 VA: 0x3207CD0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>>>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x3209200 Offset: 0x3209301 VA: 0x3209200
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>>>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x320A740 Offset: 0x320A841 VA: 0x320A740
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>>>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x320BCF0 Offset: 0x320BDF1 VA: 0x320BCF0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>>>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x320D260 Offset: 0x320D361 VA: 0x320D260
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>>>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x320E850 Offset: 0x320E951 VA: 0x320E850
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>>>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x320FEE0 Offset: 0x320FFE1 VA: 0x320FEE0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>>>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x32115F0 Offset: 0x32116F1 VA: 0x32115F0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>>>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x3212D70 Offset: 0x3212E71 VA: 0x3212D70
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>>>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x3214570 Offset: 0x3214671 VA: 0x3214570
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>>>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x3215920 Offset: 0x3215A21 VA: 0x3215920
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x3216C30 Offset: 0x3216D31 VA: 0x3216C30
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x32181A0 Offset: 0x32182A1 VA: 0x32181A0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x3219500 Offset: 0x3219601 VA: 0x3219500
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x321A9F0 Offset: 0x321AAF1 VA: 0x321A9F0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x321BF00 Offset: 0x321C001 VA: 0x321BF00
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x3253060 Offset: 0x3253161 VA: 0x3253060
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x3254560 Offset: 0x3254661 VA: 0x3254560
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x3255A80 Offset: 0x3255B81 VA: 0x3255A80
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x3256F90 Offset: 0x3257091 VA: 0x3256F90
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x32584A0 Offset: 0x32585A1 VA: 0x32584A0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x32598B0 Offset: 0x32599B1 VA: 0x32598B0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x325ADC0 Offset: 0x325AEC1 VA: 0x325ADC0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x325C0F0 Offset: 0x325C1F1 VA: 0x325C0F0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x325D550 Offset: 0x325D651 VA: 0x325D550
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x325E9E0 Offset: 0x325EAE1 VA: 0x325E9E0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x325FF10 Offset: 0x3260011 VA: 0x325FF10
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x3261430 Offset: 0x3261531 VA: 0x3261430
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x3262950 Offset: 0x3262A51 VA: 0x3262950
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x3263FB0 Offset: 0x32640B1 VA: 0x3263FB0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x3265550 Offset: 0x3265651 VA: 0x3265550
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x3266C80 Offset: 0x3266D81 VA: 0x3266C80
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x32682C0 Offset: 0x32683C1 VA: 0x32682C0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x3269B00 Offset: 0x3269C01 VA: 0x3269B00
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x326B1E0 Offset: 0x326B2E1 VA: 0x326B1E0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x326CB00 Offset: 0x326CC01 VA: 0x326CB00
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x326E280 Offset: 0x326E381 VA: 0x326E280
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x326F9D0 Offset: 0x326FAD1 VA: 0x326F9D0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x32711D0 Offset: 0x32712D1 VA: 0x32711D0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x32724D0 Offset: 0x32725D1 VA: 0x32724D0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x3273730 Offset: 0x3273831 VA: 0x3273730
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x3274C20 Offset: 0x3274D21 VA: 0x3274C20
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x3275F10 Offset: 0x3276011 VA: 0x3275F10
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x3277360 Offset: 0x3277461 VA: 0x3277360
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x3278800 Offset: 0x3278901 VA: 0x3278800
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x3279B00 Offset: 0x3279C01 VA: 0x3279B00
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x327AF50 Offset: 0x327B051 VA: 0x327AF50
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x3296310 Offset: 0x3296411 VA: 0x3296310
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x3297790 Offset: 0x3297891 VA: 0x3297790
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x3298C50 Offset: 0x3298D51 VA: 0x3298C50
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x3299F90 Offset: 0x329A091 VA: 0x3299F90
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x329B3F0 Offset: 0x329B4F1 VA: 0x329B3F0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x329C680 Offset: 0x329C781 VA: 0x329C680
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x329DA40 Offset: 0x329DB41 VA: 0x329DA40
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x329EEB0 Offset: 0x329EFB1 VA: 0x329EEB0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x32A0340 Offset: 0x32A0441 VA: 0x32A0340
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x32A17F0 Offset: 0x32A18F1 VA: 0x32A17F0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x32A2C60 Offset: 0x32A2D61 VA: 0x32A2C60
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x32A4230 Offset: 0x32A4331 VA: 0x32A4230
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x32A5780 Offset: 0x32A5881 VA: 0x32A5780
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x32A6E60 Offset: 0x32A6F61 VA: 0x32A6E60
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x32A8420 Offset: 0x32A8521 VA: 0x32A8420
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x32A9BD0 Offset: 0x32A9CD1 VA: 0x32A9BD0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x32AB240 Offset: 0x32AB341 VA: 0x32AB240
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x32ACB10 Offset: 0x32ACC11 VA: 0x32ACB10
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x32AE210 Offset: 0x32AE311 VA: 0x32AE210
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x32AFBB0 Offset: 0x32AFCB1 VA: 0x32AFBB0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x32B1360 Offset: 0x32B1461 VA: 0x32B1360
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x32B2860 Offset: 0x32B2961 VA: 0x32B2860
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>>>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x32B3D20 Offset: 0x32B3E21 VA: 0x32B3D20
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x32B5020 Offset: 0x32B5121 VA: 0x32B5020
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x32B62E0 Offset: 0x32B63E1 VA: 0x32B62E0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x32B77C0 Offset: 0x32B78C1 VA: 0x32B77C0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x32B8AB0 Offset: 0x32B8BB1 VA: 0x32B8AB0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x32B9F00 Offset: 0x32BA001 VA: 0x32B9F00
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x32BB300 Offset: 0x32BB401 VA: 0x32BB300
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x32BC5F0 Offset: 0x32BC6F1 VA: 0x32BC5F0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x32BD9E0 Offset: 0x32BDAE1 VA: 0x32BD9E0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x33E5C30 Offset: 0x33E5D31 VA: 0x33E5C30
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x33E7090 Offset: 0x33E7191 VA: 0x33E7090
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x33E8500 Offset: 0x33E8601 VA: 0x33E8500
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x33E9800 Offset: 0x33E9901 VA: 0x33E9800
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x33EABF0 Offset: 0x33EACF1 VA: 0x33EABF0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x33EBEC0 Offset: 0x33EBFC1 VA: 0x33EBEC0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x33ED1B0 Offset: 0x33ED2B1 VA: 0x33ED1B0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x33EE590 Offset: 0x33EE691 VA: 0x33EE590
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x33EFA00 Offset: 0x33EFB01 VA: 0x33EFA00
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x33F0E00 Offset: 0x33F0F01 VA: 0x33F0E00
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x33F2200 Offset: 0x33F2301 VA: 0x33F2200
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x33F3750 Offset: 0x33F3851 VA: 0x33F3750
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x33F4BE0 Offset: 0x33F4CE1 VA: 0x33F4BE0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x33F6220 Offset: 0x33F6321 VA: 0x33F6220
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x33F7770 Offset: 0x33F7871 VA: 0x33F7770
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x33F8EA0 Offset: 0x33F8FA1 VA: 0x33F8EA0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x33FA460 Offset: 0x33FA561 VA: 0x33FA460
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x33FBC70 Offset: 0x33FBD71 VA: 0x33FBC70
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x33FD2E0 Offset: 0x33FD3E1 VA: 0x33FD2E0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x33FEC00 Offset: 0x33FED01 VA: 0x33FEC00
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x3400300 Offset: 0x3400401 VA: 0x3400300
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x3401A30 Offset: 0x3401B31 VA: 0x3401A30
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x3402FB0 Offset: 0x34030B1 VA: 0x3402FB0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x3404270 Offset: 0x3404371 VA: 0x3404270
	|-ValueTuple<bool, ValueTuple<bool, AsyncUnit>>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x34054D0 Offset: 0x34055D1 VA: 0x34054D0
	|-ValueTuple<bool, ValueTuple<bool, bool>>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x3406920 Offset: 0x3406A21 VA: 0x3406920
	|-ValueTuple<bool, ValueTuple<bool, Bounds>>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x3407BF0 Offset: 0x3407CF1 VA: 0x3407BF0
	|-ValueTuple<bool, ValueTuple<bool, byte>>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x3408FB0 Offset: 0x34090B1 VA: 0x3408FB0
	|-ValueTuple<bool, ValueTuple<bool, Color>>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x340A270 Offset: 0x340A371 VA: 0x340A270
	|-ValueTuple<bool, ValueTuple<bool, double>>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x340B510 Offset: 0x340B611 VA: 0x340B510
	|-ValueTuple<bool, ValueTuple<bool, int>>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x340C790 Offset: 0x340C891 VA: 0x340C790
	|-ValueTuple<bool, ValueTuple<bool, long>>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x351AE40 Offset: 0x351AF41 VA: 0x351AE40
	|-ValueTuple<bool, ValueTuple<bool, object>>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x351C200 Offset: 0x351C301 VA: 0x351C200
	|-ValueTuple<bool, ValueTuple<bool, Quaternion>>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x351D600 Offset: 0x351D701 VA: 0x351D600
	|-ValueTuple<bool, ValueTuple<bool, Rect>>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x351E8E0 Offset: 0x351E9E1 VA: 0x351E8E0
	|-ValueTuple<bool, ValueTuple<bool, float>>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x351FB70 Offset: 0x351FC71 VA: 0x351FB70
	|-ValueTuple<bool, ValueTuple<bool, UniTask>>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x3520DD0 Offset: 0x3520ED1 VA: 0x3520DD0
	|-ValueTuple<bool, ValueTuple<bool, Unit>>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x3522090 Offset: 0x3522191 VA: 0x3522090
	|-ValueTuple<bool, ValueTuple<bool, Vector2>>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x3523390 Offset: 0x3523491 VA: 0x3523390
	|-ValueTuple<bool, ValueTuple<bool, Vector3>>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x3524770 Offset: 0x3524871 VA: 0x3524770
	|-ValueTuple<bool, ValueTuple<bool, Vector4>>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x3525A40 Offset: 0x3525B41 VA: 0x3525A40
	|-ValueTuple<bool, ValueTuple<int, object>>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x3526CE0 Offset: 0x3526DE1 VA: 0x3526CE0
	|-ValueTuple<bool, ValueTuple<object, object>>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x35281C0 Offset: 0x35282C1 VA: 0x35281C0
	|-ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x35295E0 Offset: 0x35296E1 VA: 0x35295E0
	|-ValueTuple<bool, ValueTuple<object, object, object>>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x352ABC0 Offset: 0x352ACC1 VA: 0x352ABC0
	|-ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x352C090 Offset: 0x352C191 VA: 0x352C090
	|-ValueTuple<bool, ValueTuple<object, object, object, object>>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x352D760 Offset: 0x352D861 VA: 0x352D760
	|-ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x352ECE0 Offset: 0x352EDE1 VA: 0x352ECE0
	|-ValueTuple<bool, ValueTuple<object, object, object, object, object>>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x35304A0 Offset: 0x35305A1 VA: 0x35304A0
	|-ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x3531AA0 Offset: 0x3531BA1 VA: 0x3531AA0
	|-ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x3533350 Offset: 0x3533451 VA: 0x3533350
	|-ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x35349F0 Offset: 0x3534AF1 VA: 0x35349F0
	|-ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x35363A0 Offset: 0x35364A1 VA: 0x35363A0
	|-ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x3537930 Offset: 0x3537A31 VA: 0x3537930
	|-ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x3538B70 Offset: 0x3538C71 VA: 0x3538B70
	|-ValueTuple<bool, AsyncUnit>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x3539CD0 Offset: 0x3539DD1 VA: 0x3539CD0
	|-ValueTuple<bool, bool>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x353AFD0 Offset: 0x353B0D1 VA: 0x353AFD0
	|-ValueTuple<bool, Bounds>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x353C120 Offset: 0x353C221 VA: 0x353C120
	|-ValueTuple<bool, byte>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x353D2F0 Offset: 0x353D3F1 VA: 0x353D2F0
	|-ValueTuple<bool, Color>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x353E440 Offset: 0x353E541 VA: 0x353E440
	|-ValueTuple<bool, double>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x353F570 Offset: 0x353F671 VA: 0x353F570
	|-ValueTuple<bool, int>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x35406B0 Offset: 0x35407B1 VA: 0x35406B0
	|-ValueTuple<bool, long>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x37B21A0 Offset: 0x37B22A1 VA: 0x37B21A0
	|-ValueTuple<bool, object>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x37B3370 Offset: 0x37B3471 VA: 0x37B3370
	|-ValueTuple<bool, Quaternion>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x37B4550 Offset: 0x37B4651 VA: 0x37B4550
	|-ValueTuple<bool, Rect>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x37B56A0 Offset: 0x37B57A1 VA: 0x37B56A0
	|-ValueTuple<bool, float>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x37B67F0 Offset: 0x37B68F1 VA: 0x37B67F0
	|-ValueTuple<bool, UniTask>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x37B7920 Offset: 0x37B7A21 VA: 0x37B7920
	|-ValueTuple<bool, Unit>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x37B8AA0 Offset: 0x37B8BA1 VA: 0x37B8AA0
	|-ValueTuple<bool, Vector2>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x37B9C40 Offset: 0x37B9D41 VA: 0x37B9C40
	|-ValueTuple<bool, Vector3>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x37BAE20 Offset: 0x37BAF21 VA: 0x37BAE20
	|-ValueTuple<bool, Vector4>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x37BBFA0 Offset: 0x37BC0A1 VA: 0x37BBFA0
	|-ValueTuple<FXZ, int>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x37BD0D0 Offset: 0x37BD1D1 VA: 0x37BD0D0
	|-ValueTuple<int, bool>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x37BE360 Offset: 0x37BE461 VA: 0x37BE360
	|-ValueTuple<int, Bounds>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x37BF490 Offset: 0x37BF591 VA: 0x37BF490
	|-ValueTuple<int, byte>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x37C0630 Offset: 0x37C0731 VA: 0x37C0630
	|-ValueTuple<int, Color>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x37C1760 Offset: 0x37C1861 VA: 0x37C1760
	|-ValueTuple<int, double>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x37C2870 Offset: 0x37C2971 VA: 0x37C2870
	|-ValueTuple<int, int>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x37C3990 Offset: 0x37C3A91 VA: 0x37C3990
	|-ValueTuple<int, long>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x37C4B10 Offset: 0x37C4C11 VA: 0x37C4B10
	|-ValueTuple<int, Int64Enum>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x37C5BD0 Offset: 0x37C5CD1 VA: 0x37C5BD0
	|-ValueTuple<int, object>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x37C6D70 Offset: 0x37C6E71 VA: 0x37C6D70
	|-ValueTuple<int, Quaternion>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x37C7F20 Offset: 0x37C8021 VA: 0x37C7F20
	|-ValueTuple<int, Rect>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x37C9040 Offset: 0x37C9141 VA: 0x37C9040
	|-ValueTuple<int, float>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x37CA160 Offset: 0x37CA261 VA: 0x37CA160
	|-ValueTuple<int, Unit>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x37CB2D0 Offset: 0x37CB3D1 VA: 0x37CB2D0
	|-ValueTuple<int, Vector2>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x37CC460 Offset: 0x37CC561 VA: 0x37CC460
	|-ValueTuple<int, Vector3>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x37CD610 Offset: 0x37CD711 VA: 0x37CD610
	|-ValueTuple<int, Vector4>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x37CE780 Offset: 0x37CE881 VA: 0x37CE780
	|-ValueTuple<Int32Enum, int>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x37CF970 Offset: 0x37CFA71 VA: 0x37CF970
	|-ValueTuple<Int64Enum, int>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x37D0B20 Offset: 0x37D0C21 VA: 0x37D0B20
	|-ValueTuple<object, ValueTuple<object, int>>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x37D1C60 Offset: 0x37D1D61 VA: 0x37D1C60
	|-ValueTuple<object, bool>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x37D2CB0 Offset: 0x37D2DB1 VA: 0x37D2CB0
	|-ValueTuple<object, int>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x388B470 Offset: 0x388B571 VA: 0x388B470
	|-ValueTuple<object, object>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x388C4B0 Offset: 0x388C5B1 VA: 0x388C4B0
	|-ValueTuple<object, float>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x388D5C0 Offset: 0x388D6C1 VA: 0x388D5C0
	|-ValueTuple<float, int>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x388E730 Offset: 0x388E831 VA: 0x388E730
	|-ValueTuple<float, Int32Enum>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x388F900 Offset: 0x388FA01 VA: 0x388F900
	|-ValueTuple<float, float>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x3890B50 Offset: 0x3890C51 VA: 0x3890B50
	|-ValueTuple<UniTask, CancellationTokenRegistration>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x3891E10 Offset: 0x3891F11 VA: 0x3891E10
	|-ValueTuple<Vector3, float>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x3892FF0 Offset: 0x38930F1 VA: 0x3892FF0
	|-ValueTuple<Vector3, Vector3>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x3894220 Offset: 0x3894321 VA: 0x3894220
	|-ValueTuple<Vector4, Vector4>.System.Collections.IStructuralEquatable.GetHashCode
	*/

	// RVA: -1 Offset: -1
	private int GetHashCodeCore(IEqualityComparer comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3393A80 Offset: 0x3393B81 VA: 0x3393A80
	|-ValueTuple<UniTask<object>, UniTask<object>>.GetHashCodeCore
	|
	|-RVA: 0x3394E00 Offset: 0x3394F01 VA: 0x3394E00
	|-ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>.GetHashCodeCore
	|
	|-RVA: 0x3396110 Offset: 0x3396211 VA: 0x3396110
	|-ValueTuple<bool, UniTask<object>>.GetHashCodeCore
	|
	|-RVA: 0x33974F0 Offset: 0x33975F1 VA: 0x33974F0
	|-ValueTuple<bool, ValueTuple<bool, UniTask<object>>>.GetHashCodeCore
	|
	|-RVA: 0x3398960 Offset: 0x3398A61 VA: 0x3398960
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>.GetHashCodeCore
	|
	|-RVA: 0x3399E60 Offset: 0x3399F61 VA: 0x3399E60
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>>.GetHashCodeCore
	|
	|-RVA: 0x31F4730 Offset: 0x31F4831 VA: 0x31F4730
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>>>.GetHashCodeCore
	|
	|-RVA: 0x31F5A60 Offset: 0x31F5B61 VA: 0x31F5A60
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>>>.GetHashCodeCore
	|
	|-RVA: 0x31F6D70 Offset: 0x31F6E71 VA: 0x31F6D70
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>>>.GetHashCodeCore
	|
	|-RVA: 0x31F8310 Offset: 0x31F8411 VA: 0x31F8310
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>>>.GetHashCodeCore
	|
	|-RVA: 0x31F9690 Offset: 0x31F9791 VA: 0x31F9690
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>>>.GetHashCodeCore
	|
	|-RVA: 0x31FABB0 Offset: 0x31FACB1 VA: 0x31FABB0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>>>.GetHashCodeCore
	|
	|-RVA: 0x31FC150 Offset: 0x31FC251 VA: 0x31FC150
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>>>.GetHashCodeCore
	|
	|-RVA: 0x31FD5D0 Offset: 0x31FD6D1 VA: 0x31FD5D0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>>>.GetHashCodeCore
	|
	|-RVA: 0x31FEB20 Offset: 0x31FEC21 VA: 0x31FEB20
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>>>.GetHashCodeCore
	|
	|-RVA: 0x3200090 Offset: 0x3200191 VA: 0x3200090
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>>>.GetHashCodeCore
	|
	|-RVA: 0x32015D0 Offset: 0x32016D1 VA: 0x32015D0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>>>.GetHashCodeCore
	|
	|-RVA: 0x3202B50 Offset: 0x3202C51 VA: 0x3202B50
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>>>.GetHashCodeCore
	|
	|-RVA: 0x3204010 Offset: 0x3204111 VA: 0x3204010
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>>>.GetHashCodeCore
	|
	|-RVA: 0x3205570 Offset: 0x3205671 VA: 0x3205570
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>>>.GetHashCodeCore
	|
	|-RVA: 0x32068A0 Offset: 0x32069A1 VA: 0x32068A0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>>>.GetHashCodeCore
	|
	|-RVA: 0x3207D20 Offset: 0x3207E21 VA: 0x3207D20
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>>>.GetHashCodeCore
	|
	|-RVA: 0x3209250 Offset: 0x3209351 VA: 0x3209250
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>>>.GetHashCodeCore
	|
	|-RVA: 0x320A790 Offset: 0x320A891 VA: 0x320A790
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>>>.GetHashCodeCore
	|
	|-RVA: 0x320BD40 Offset: 0x320BE41 VA: 0x320BD40
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>>>.GetHashCodeCore
	|
	|-RVA: 0x320D2B0 Offset: 0x320D3B1 VA: 0x320D2B0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>>>.GetHashCodeCore
	|
	|-RVA: 0x320E8A0 Offset: 0x320E9A1 VA: 0x320E8A0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>>>.GetHashCodeCore
	|
	|-RVA: 0x320FF30 Offset: 0x3210031 VA: 0x320FF30
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>>>.GetHashCodeCore
	|
	|-RVA: 0x3211640 Offset: 0x3211741 VA: 0x3211640
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>>>.GetHashCodeCore
	|
	|-RVA: 0x3212DC0 Offset: 0x3212EC1 VA: 0x3212DC0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>>>.GetHashCodeCore
	|
	|-RVA: 0x32145C0 Offset: 0x32146C1 VA: 0x32145C0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>>>.GetHashCodeCore
	|
	|-RVA: 0x3215970 Offset: 0x3215A71 VA: 0x3215970
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>>.GetHashCodeCore
	|
	|-RVA: 0x3216C80 Offset: 0x3216D81 VA: 0x3216C80
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>>.GetHashCodeCore
	|
	|-RVA: 0x32181F0 Offset: 0x32182F1 VA: 0x32181F0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>>.GetHashCodeCore
	|
	|-RVA: 0x3219550 Offset: 0x3219651 VA: 0x3219550
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>>.GetHashCodeCore
	|
	|-RVA: 0x321AA40 Offset: 0x321AB41 VA: 0x321AA40
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>>.GetHashCodeCore
	|
	|-RVA: 0x321BF50 Offset: 0x321C051 VA: 0x321BF50
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>>.GetHashCodeCore
	|
	|-RVA: 0x32530B0 Offset: 0x32531B1 VA: 0x32530B0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>>.GetHashCodeCore
	|
	|-RVA: 0x32545B0 Offset: 0x32546B1 VA: 0x32545B0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>>.GetHashCodeCore
	|
	|-RVA: 0x3255AD0 Offset: 0x3255BD1 VA: 0x3255AD0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>>.GetHashCodeCore
	|
	|-RVA: 0x3256FE0 Offset: 0x32570E1 VA: 0x3256FE0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>>.GetHashCodeCore
	|
	|-RVA: 0x32584F0 Offset: 0x32585F1 VA: 0x32584F0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>>.GetHashCodeCore
	|
	|-RVA: 0x3259900 Offset: 0x3259A01 VA: 0x3259900
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>>.GetHashCodeCore
	|
	|-RVA: 0x325AE10 Offset: 0x325AF11 VA: 0x325AE10
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>>.GetHashCodeCore
	|
	|-RVA: 0x325C140 Offset: 0x325C241 VA: 0x325C140
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>>.GetHashCodeCore
	|
	|-RVA: 0x325D5A0 Offset: 0x325D6A1 VA: 0x325D5A0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>>.GetHashCodeCore
	|
	|-RVA: 0x325EA30 Offset: 0x325EB31 VA: 0x325EA30
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>>.GetHashCodeCore
	|
	|-RVA: 0x325FF60 Offset: 0x3260061 VA: 0x325FF60
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>>.GetHashCodeCore
	|
	|-RVA: 0x3261480 Offset: 0x3261581 VA: 0x3261480
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>>.GetHashCodeCore
	|
	|-RVA: 0x32629A0 Offset: 0x3262AA1 VA: 0x32629A0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>>.GetHashCodeCore
	|
	|-RVA: 0x3264000 Offset: 0x3264101 VA: 0x3264000
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.GetHashCodeCore
	|
	|-RVA: 0x32655A0 Offset: 0x32656A1 VA: 0x32655A0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>>.GetHashCodeCore
	|
	|-RVA: 0x3266CD0 Offset: 0x3266DD1 VA: 0x3266CD0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.GetHashCodeCore
	|
	|-RVA: 0x3268310 Offset: 0x3268411 VA: 0x3268310
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>>.GetHashCodeCore
	|
	|-RVA: 0x3269B50 Offset: 0x3269C51 VA: 0x3269B50
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.GetHashCodeCore
	|
	|-RVA: 0x326B230 Offset: 0x326B331 VA: 0x326B230
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>>.GetHashCodeCore
	|
	|-RVA: 0x326CB50 Offset: 0x326CC51 VA: 0x326CB50
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.GetHashCodeCore
	|
	|-RVA: 0x326E2D0 Offset: 0x326E3D1 VA: 0x326E2D0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>>.GetHashCodeCore
	|
	|-RVA: 0x326FA20 Offset: 0x326FB21 VA: 0x326FA20
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.GetHashCodeCore
	|
	|-RVA: 0x3271220 Offset: 0x3271321 VA: 0x3271220
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>>.GetHashCodeCore
	|
	|-RVA: 0x3272520 Offset: 0x3272621 VA: 0x3272520
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>.GetHashCodeCore
	|
	|-RVA: 0x3273780 Offset: 0x3273881 VA: 0x3273780
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>.GetHashCodeCore
	|
	|-RVA: 0x3274C70 Offset: 0x3274D71 VA: 0x3274C70
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>.GetHashCodeCore
	|
	|-RVA: 0x3275F60 Offset: 0x3276061 VA: 0x3275F60
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>.GetHashCodeCore
	|
	|-RVA: 0x32773B0 Offset: 0x32774B1 VA: 0x32773B0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>.GetHashCodeCore
	|
	|-RVA: 0x3278850 Offset: 0x3278951 VA: 0x3278850
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>.GetHashCodeCore
	|
	|-RVA: 0x3279B50 Offset: 0x3279C51 VA: 0x3279B50
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>.GetHashCodeCore
	|
	|-RVA: 0x327AFA0 Offset: 0x327B0A1 VA: 0x327AFA0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>.GetHashCodeCore
	|
	|-RVA: 0x3296360 Offset: 0x3296461 VA: 0x3296360
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>.GetHashCodeCore
	|
	|-RVA: 0x32977E0 Offset: 0x32978E1 VA: 0x32977E0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>.GetHashCodeCore
	|
	|-RVA: 0x3298CA0 Offset: 0x3298DA1 VA: 0x3298CA0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>.GetHashCodeCore
	|
	|-RVA: 0x3299FE0 Offset: 0x329A0E1 VA: 0x3299FE0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>.GetHashCodeCore
	|
	|-RVA: 0x329B440 Offset: 0x329B541 VA: 0x329B440
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>.GetHashCodeCore
	|
	|-RVA: 0x329C6D0 Offset: 0x329C7D1 VA: 0x329C6D0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>.GetHashCodeCore
	|
	|-RVA: 0x329DA90 Offset: 0x329DB91 VA: 0x329DA90
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>.GetHashCodeCore
	|
	|-RVA: 0x329EF00 Offset: 0x329F001 VA: 0x329EF00
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>.GetHashCodeCore
	|
	|-RVA: 0x32A0390 Offset: 0x32A0491 VA: 0x32A0390
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>.GetHashCodeCore
	|
	|-RVA: 0x32A1840 Offset: 0x32A1941 VA: 0x32A1840
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>.GetHashCodeCore
	|
	|-RVA: 0x32A2CB0 Offset: 0x32A2DB1 VA: 0x32A2CB0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>.GetHashCodeCore
	|
	|-RVA: 0x32A4280 Offset: 0x32A4381 VA: 0x32A4280
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.GetHashCodeCore
	|
	|-RVA: 0x32A57D0 Offset: 0x32A58D1 VA: 0x32A57D0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>.GetHashCodeCore
	|
	|-RVA: 0x32A6EB0 Offset: 0x32A6FB1 VA: 0x32A6EB0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.GetHashCodeCore
	|
	|-RVA: 0x32A8470 Offset: 0x32A8571 VA: 0x32A8470
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>.GetHashCodeCore
	|
	|-RVA: 0x32A9C20 Offset: 0x32A9D21 VA: 0x32A9C20
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.GetHashCodeCore
	|
	|-RVA: 0x32AB290 Offset: 0x32AB391 VA: 0x32AB290
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>.GetHashCodeCore
	|
	|-RVA: 0x32ACB60 Offset: 0x32ACC61 VA: 0x32ACB60
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.GetHashCodeCore
	|
	|-RVA: 0x32AE260 Offset: 0x32AE361 VA: 0x32AE260
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>.GetHashCodeCore
	|
	|-RVA: 0x32AFC00 Offset: 0x32AFD01 VA: 0x32AFC00
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.GetHashCodeCore
	|
	|-RVA: 0x32B13B0 Offset: 0x32B14B1 VA: 0x32B13B0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>.GetHashCodeCore
	|
	|-RVA: 0x32B28B0 Offset: 0x32B29B1 VA: 0x32B28B0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>>>.GetHashCodeCore
	|
	|-RVA: 0x32B3D70 Offset: 0x32B3E71 VA: 0x32B3D70
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.GetHashCodeCore
	|
	|-RVA: 0x32B5070 Offset: 0x32B5171 VA: 0x32B5070
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>.GetHashCodeCore
	|
	|-RVA: 0x32B6330 Offset: 0x32B6431 VA: 0x32B6330
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>.GetHashCodeCore
	|
	|-RVA: 0x32B7810 Offset: 0x32B7911 VA: 0x32B7810
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>.GetHashCodeCore
	|
	|-RVA: 0x32B8B00 Offset: 0x32B8C01 VA: 0x32B8B00
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>.GetHashCodeCore
	|
	|-RVA: 0x32B9F50 Offset: 0x32BA051 VA: 0x32B9F50
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>.GetHashCodeCore
	|
	|-RVA: 0x32BB350 Offset: 0x32BB451 VA: 0x32BB350
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>.GetHashCodeCore
	|
	|-RVA: 0x32BC640 Offset: 0x32BC741 VA: 0x32BC640
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>.GetHashCodeCore
	|
	|-RVA: 0x32BDA30 Offset: 0x32BDB31 VA: 0x32BDA30
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>.GetHashCodeCore
	|
	|-RVA: 0x33E5C80 Offset: 0x33E5D81 VA: 0x33E5C80
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>.GetHashCodeCore
	|
	|-RVA: 0x33E70E0 Offset: 0x33E71E1 VA: 0x33E70E0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>.GetHashCodeCore
	|
	|-RVA: 0x33E8550 Offset: 0x33E8651 VA: 0x33E8550
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>.GetHashCodeCore
	|
	|-RVA: 0x33E9850 Offset: 0x33E9951 VA: 0x33E9850
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>.GetHashCodeCore
	|
	|-RVA: 0x33EAC40 Offset: 0x33EAD41 VA: 0x33EAC40
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>.GetHashCodeCore
	|
	|-RVA: 0x33EBF10 Offset: 0x33EC011 VA: 0x33EBF10
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>.GetHashCodeCore
	|
	|-RVA: 0x33ED200 Offset: 0x33ED301 VA: 0x33ED200
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>.GetHashCodeCore
	|
	|-RVA: 0x33EE5E0 Offset: 0x33EE6E1 VA: 0x33EE5E0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>.GetHashCodeCore
	|
	|-RVA: 0x33EFA50 Offset: 0x33EFB51 VA: 0x33EFA50
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>.GetHashCodeCore
	|
	|-RVA: 0x33F0E50 Offset: 0x33F0F51 VA: 0x33F0E50
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>.GetHashCodeCore
	|
	|-RVA: 0x33F2250 Offset: 0x33F2351 VA: 0x33F2250
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>.GetHashCodeCore
	|
	|-RVA: 0x33F37A0 Offset: 0x33F38A1 VA: 0x33F37A0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.GetHashCodeCore
	|
	|-RVA: 0x33F4C30 Offset: 0x33F4D31 VA: 0x33F4C30
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>.GetHashCodeCore
	|
	|-RVA: 0x33F6270 Offset: 0x33F6371 VA: 0x33F6270
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.GetHashCodeCore
	|
	|-RVA: 0x33F77C0 Offset: 0x33F78C1 VA: 0x33F77C0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>.GetHashCodeCore
	|
	|-RVA: 0x33F8EF0 Offset: 0x33F8FF1 VA: 0x33F8EF0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.GetHashCodeCore
	|
	|-RVA: 0x33FA4B0 Offset: 0x33FA5B1 VA: 0x33FA4B0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>.GetHashCodeCore
	|
	|-RVA: 0x33FBCC0 Offset: 0x33FBDC1 VA: 0x33FBCC0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.GetHashCodeCore
	|
	|-RVA: 0x33FD330 Offset: 0x33FD431 VA: 0x33FD330
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>.GetHashCodeCore
	|
	|-RVA: 0x33FEC50 Offset: 0x33FED51 VA: 0x33FEC50
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.GetHashCodeCore
	|
	|-RVA: 0x3400350 Offset: 0x3400451 VA: 0x3400350
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>.GetHashCodeCore
	|
	|-RVA: 0x3401A80 Offset: 0x3401B81 VA: 0x3401A80
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>>.GetHashCodeCore
	|
	|-RVA: 0x3403000 Offset: 0x3403101 VA: 0x3403000
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.GetHashCodeCore
	|
	|-RVA: 0x34042C0 Offset: 0x34043C1 VA: 0x34042C0
	|-ValueTuple<bool, ValueTuple<bool, AsyncUnit>>.GetHashCodeCore
	|
	|-RVA: 0x3405520 Offset: 0x3405621 VA: 0x3405520
	|-ValueTuple<bool, ValueTuple<bool, bool>>.GetHashCodeCore
	|
	|-RVA: 0x3406970 Offset: 0x3406A71 VA: 0x3406970
	|-ValueTuple<bool, ValueTuple<bool, Bounds>>.GetHashCodeCore
	|
	|-RVA: 0x3407C40 Offset: 0x3407D41 VA: 0x3407C40
	|-ValueTuple<bool, ValueTuple<bool, byte>>.GetHashCodeCore
	|
	|-RVA: 0x3409000 Offset: 0x3409101 VA: 0x3409000
	|-ValueTuple<bool, ValueTuple<bool, Color>>.GetHashCodeCore
	|
	|-RVA: 0x340A2C0 Offset: 0x340A3C1 VA: 0x340A2C0
	|-ValueTuple<bool, ValueTuple<bool, double>>.GetHashCodeCore
	|
	|-RVA: 0x340B560 Offset: 0x340B661 VA: 0x340B560
	|-ValueTuple<bool, ValueTuple<bool, int>>.GetHashCodeCore
	|
	|-RVA: 0x340C7E0 Offset: 0x340C8E1 VA: 0x340C7E0
	|-ValueTuple<bool, ValueTuple<bool, long>>.GetHashCodeCore
	|
	|-RVA: 0x351AE90 Offset: 0x351AF91 VA: 0x351AE90
	|-ValueTuple<bool, ValueTuple<bool, object>>.GetHashCodeCore
	|
	|-RVA: 0x351C250 Offset: 0x351C351 VA: 0x351C250
	|-ValueTuple<bool, ValueTuple<bool, Quaternion>>.GetHashCodeCore
	|
	|-RVA: 0x351D650 Offset: 0x351D751 VA: 0x351D650
	|-ValueTuple<bool, ValueTuple<bool, Rect>>.GetHashCodeCore
	|
	|-RVA: 0x351E930 Offset: 0x351EA31 VA: 0x351E930
	|-ValueTuple<bool, ValueTuple<bool, float>>.GetHashCodeCore
	|
	|-RVA: 0x351FBC0 Offset: 0x351FCC1 VA: 0x351FBC0
	|-ValueTuple<bool, ValueTuple<bool, UniTask>>.GetHashCodeCore
	|
	|-RVA: 0x3520E20 Offset: 0x3520F21 VA: 0x3520E20
	|-ValueTuple<bool, ValueTuple<bool, Unit>>.GetHashCodeCore
	|
	|-RVA: 0x35220E0 Offset: 0x35221E1 VA: 0x35220E0
	|-ValueTuple<bool, ValueTuple<bool, Vector2>>.GetHashCodeCore
	|
	|-RVA: 0x35233E0 Offset: 0x35234E1 VA: 0x35233E0
	|-ValueTuple<bool, ValueTuple<bool, Vector3>>.GetHashCodeCore
	|
	|-RVA: 0x35247C0 Offset: 0x35248C1 VA: 0x35247C0
	|-ValueTuple<bool, ValueTuple<bool, Vector4>>.GetHashCodeCore
	|
	|-RVA: 0x3525A90 Offset: 0x3525B91 VA: 0x3525A90
	|-ValueTuple<bool, ValueTuple<int, object>>.GetHashCodeCore
	|
	|-RVA: 0x3526D30 Offset: 0x3526E31 VA: 0x3526D30
	|-ValueTuple<bool, ValueTuple<object, object>>.GetHashCodeCore
	|
	|-RVA: 0x3528210 Offset: 0x3528311 VA: 0x3528210
	|-ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>.GetHashCodeCore
	|
	|-RVA: 0x3529630 Offset: 0x3529731 VA: 0x3529630
	|-ValueTuple<bool, ValueTuple<object, object, object>>.GetHashCodeCore
	|
	|-RVA: 0x352AC10 Offset: 0x352AD11 VA: 0x352AC10
	|-ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.GetHashCodeCore
	|
	|-RVA: 0x352C0E0 Offset: 0x352C1E1 VA: 0x352C0E0
	|-ValueTuple<bool, ValueTuple<object, object, object, object>>.GetHashCodeCore
	|
	|-RVA: 0x352D7B0 Offset: 0x352D8B1 VA: 0x352D7B0
	|-ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.GetHashCodeCore
	|
	|-RVA: 0x352ED30 Offset: 0x352EE31 VA: 0x352ED30
	|-ValueTuple<bool, ValueTuple<object, object, object, object, object>>.GetHashCodeCore
	|
	|-RVA: 0x35304F0 Offset: 0x35305F1 VA: 0x35304F0
	|-ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.GetHashCodeCore
	|
	|-RVA: 0x3531AF0 Offset: 0x3531BF1 VA: 0x3531AF0
	|-ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>.GetHashCodeCore
	|
	|-RVA: 0x35333A0 Offset: 0x35334A1 VA: 0x35333A0
	|-ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.GetHashCodeCore
	|
	|-RVA: 0x3534A40 Offset: 0x3534B41 VA: 0x3534A40
	|-ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>.GetHashCodeCore
	|
	|-RVA: 0x35363F0 Offset: 0x35364F1 VA: 0x35363F0
	|-ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>.GetHashCodeCore
	|
	|-RVA: 0x3537980 Offset: 0x3537A81 VA: 0x3537980
	|-ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>.GetHashCodeCore
	|
	|-RVA: 0x3538BC0 Offset: 0x3538CC1 VA: 0x3538BC0
	|-ValueTuple<bool, AsyncUnit>.GetHashCodeCore
	|
	|-RVA: 0x3539D20 Offset: 0x3539E21 VA: 0x3539D20
	|-ValueTuple<bool, bool>.GetHashCodeCore
	|
	|-RVA: 0x353B020 Offset: 0x353B121 VA: 0x353B020
	|-ValueTuple<bool, Bounds>.GetHashCodeCore
	|
	|-RVA: 0x353C170 Offset: 0x353C271 VA: 0x353C170
	|-ValueTuple<bool, byte>.GetHashCodeCore
	|
	|-RVA: 0x353D340 Offset: 0x353D441 VA: 0x353D340
	|-ValueTuple<bool, Color>.GetHashCodeCore
	|
	|-RVA: 0x353E490 Offset: 0x353E591 VA: 0x353E490
	|-ValueTuple<bool, double>.GetHashCodeCore
	|
	|-RVA: 0x353F5C0 Offset: 0x353F6C1 VA: 0x353F5C0
	|-ValueTuple<bool, int>.GetHashCodeCore
	|
	|-RVA: 0x3540700 Offset: 0x3540801 VA: 0x3540700
	|-ValueTuple<bool, long>.GetHashCodeCore
	|
	|-RVA: 0x37B21F0 Offset: 0x37B22F1 VA: 0x37B21F0
	|-ValueTuple<bool, object>.GetHashCodeCore
	|
	|-RVA: 0x37B33C0 Offset: 0x37B34C1 VA: 0x37B33C0
	|-ValueTuple<bool, Quaternion>.GetHashCodeCore
	|
	|-RVA: 0x37B45A0 Offset: 0x37B46A1 VA: 0x37B45A0
	|-ValueTuple<bool, Rect>.GetHashCodeCore
	|
	|-RVA: 0x37B56F0 Offset: 0x37B57F1 VA: 0x37B56F0
	|-ValueTuple<bool, float>.GetHashCodeCore
	|
	|-RVA: 0x37B6840 Offset: 0x37B6941 VA: 0x37B6840
	|-ValueTuple<bool, UniTask>.GetHashCodeCore
	|
	|-RVA: 0x37B7970 Offset: 0x37B7A71 VA: 0x37B7970
	|-ValueTuple<bool, Unit>.GetHashCodeCore
	|
	|-RVA: 0x37B8AF0 Offset: 0x37B8BF1 VA: 0x37B8AF0
	|-ValueTuple<bool, Vector2>.GetHashCodeCore
	|
	|-RVA: 0x37B9C90 Offset: 0x37B9D91 VA: 0x37B9C90
	|-ValueTuple<bool, Vector3>.GetHashCodeCore
	|
	|-RVA: 0x37BAE70 Offset: 0x37BAF71 VA: 0x37BAE70
	|-ValueTuple<bool, Vector4>.GetHashCodeCore
	|
	|-RVA: 0x37BBFF0 Offset: 0x37BC0F1 VA: 0x37BBFF0
	|-ValueTuple<FXZ, int>.GetHashCodeCore
	|
	|-RVA: 0x37BD120 Offset: 0x37BD221 VA: 0x37BD120
	|-ValueTuple<int, bool>.GetHashCodeCore
	|
	|-RVA: 0x37BE3B0 Offset: 0x37BE4B1 VA: 0x37BE3B0
	|-ValueTuple<int, Bounds>.GetHashCodeCore
	|
	|-RVA: 0x37BF4E0 Offset: 0x37BF5E1 VA: 0x37BF4E0
	|-ValueTuple<int, byte>.GetHashCodeCore
	|
	|-RVA: 0x37C0680 Offset: 0x37C0781 VA: 0x37C0680
	|-ValueTuple<int, Color>.GetHashCodeCore
	|
	|-RVA: 0x37C17B0 Offset: 0x37C18B1 VA: 0x37C17B0
	|-ValueTuple<int, double>.GetHashCodeCore
	|
	|-RVA: 0x37C28C0 Offset: 0x37C29C1 VA: 0x37C28C0
	|-ValueTuple<int, int>.GetHashCodeCore
	|
	|-RVA: 0x37C39E0 Offset: 0x37C3AE1 VA: 0x37C39E0
	|-ValueTuple<int, long>.GetHashCodeCore
	|
	|-RVA: 0x37C4B60 Offset: 0x37C4C61 VA: 0x37C4B60
	|-ValueTuple<int, Int64Enum>.GetHashCodeCore
	|
	|-RVA: 0x37C5C20 Offset: 0x37C5D21 VA: 0x37C5C20
	|-ValueTuple<int, object>.GetHashCodeCore
	|
	|-RVA: 0x37C6DC0 Offset: 0x37C6EC1 VA: 0x37C6DC0
	|-ValueTuple<int, Quaternion>.GetHashCodeCore
	|
	|-RVA: 0x37C7F70 Offset: 0x37C8071 VA: 0x37C7F70
	|-ValueTuple<int, Rect>.GetHashCodeCore
	|
	|-RVA: 0x37C9090 Offset: 0x37C9191 VA: 0x37C9090
	|-ValueTuple<int, float>.GetHashCodeCore
	|
	|-RVA: 0x37CA1B0 Offset: 0x37CA2B1 VA: 0x37CA1B0
	|-ValueTuple<int, Unit>.GetHashCodeCore
	|
	|-RVA: 0x37CB320 Offset: 0x37CB421 VA: 0x37CB320
	|-ValueTuple<int, Vector2>.GetHashCodeCore
	|
	|-RVA: 0x37CC4B0 Offset: 0x37CC5B1 VA: 0x37CC4B0
	|-ValueTuple<int, Vector3>.GetHashCodeCore
	|
	|-RVA: 0x37CD660 Offset: 0x37CD761 VA: 0x37CD660
	|-ValueTuple<int, Vector4>.GetHashCodeCore
	|
	|-RVA: 0x37CE7D0 Offset: 0x37CE8D1 VA: 0x37CE7D0
	|-ValueTuple<Int32Enum, int>.GetHashCodeCore
	|
	|-RVA: 0x37CF9C0 Offset: 0x37CFAC1 VA: 0x37CF9C0
	|-ValueTuple<Int64Enum, int>.GetHashCodeCore
	|
	|-RVA: 0x37D0B70 Offset: 0x37D0C71 VA: 0x37D0B70
	|-ValueTuple<object, ValueTuple<object, int>>.GetHashCodeCore
	|
	|-RVA: 0x37D1CB0 Offset: 0x37D1DB1 VA: 0x37D1CB0
	|-ValueTuple<object, bool>.GetHashCodeCore
	|
	|-RVA: 0x37D2D00 Offset: 0x37D2E01 VA: 0x37D2D00
	|-ValueTuple<object, int>.GetHashCodeCore
	|
	|-RVA: 0x388B4B0 Offset: 0x388B5B1 VA: 0x388B4B0
	|-ValueTuple<object, object>.GetHashCodeCore
	|
	|-RVA: 0x388C500 Offset: 0x388C601 VA: 0x388C500
	|-ValueTuple<object, float>.GetHashCodeCore
	|
	|-RVA: 0x388D610 Offset: 0x388D711 VA: 0x388D610
	|-ValueTuple<float, int>.GetHashCodeCore
	|
	|-RVA: 0x388E780 Offset: 0x388E881 VA: 0x388E780
	|-ValueTuple<float, Int32Enum>.GetHashCodeCore
	|
	|-RVA: 0x388F950 Offset: 0x388FA51 VA: 0x388F950
	|-ValueTuple<float, float>.GetHashCodeCore
	|
	|-RVA: 0x3890BA0 Offset: 0x3890CA1 VA: 0x3890BA0
	|-ValueTuple<UniTask, CancellationTokenRegistration>.GetHashCodeCore
	|
	|-RVA: 0x3891E60 Offset: 0x3891F61 VA: 0x3891E60
	|-ValueTuple<Vector3, float>.GetHashCodeCore
	|
	|-RVA: 0x3893040 Offset: 0x3893141 VA: 0x3893040
	|-ValueTuple<Vector3, Vector3>.GetHashCodeCore
	|
	|-RVA: 0x3894270 Offset: 0x3894371 VA: 0x3894270
	|-ValueTuple<Vector4, Vector4>.GetHashCodeCore
	*/

	// RVA: -1 Offset: -1 Slot: 10
	private int System.IValueTupleInternal.GetHashCode(IEqualityComparer comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3393C40 Offset: 0x3393D41 VA: 0x3393C40
	|-ValueTuple<UniTask<object>, UniTask<object>>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x3394FC0 Offset: 0x33950C1 VA: 0x3394FC0
	|-ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x33962D0 Offset: 0x33963D1 VA: 0x33962D0
	|-ValueTuple<bool, UniTask<object>>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x33976C0 Offset: 0x33977C1 VA: 0x33976C0
	|-ValueTuple<bool, ValueTuple<bool, UniTask<object>>>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x3398B30 Offset: 0x3398C31 VA: 0x3398B30
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x339A030 Offset: 0x339A131 VA: 0x339A030
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x31F4900 Offset: 0x31F4A01 VA: 0x31F4900
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>>>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x31F5C30 Offset: 0x31F5D31 VA: 0x31F5C30
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>>>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x31F6F40 Offset: 0x31F7041 VA: 0x31F6F40
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>>>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x31F84F0 Offset: 0x31F85F1 VA: 0x31F84F0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>>>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x31F9860 Offset: 0x31F9961 VA: 0x31F9860
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>>>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x31FAD90 Offset: 0x31FAE91 VA: 0x31FAD90
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>>>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x31FC320 Offset: 0x31FC421 VA: 0x31FC320
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>>>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x31FD7A0 Offset: 0x31FD8A1 VA: 0x31FD7A0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>>>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x31FECF0 Offset: 0x31FEDF1 VA: 0x31FECF0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>>>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x3200260 Offset: 0x3200361 VA: 0x3200260
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>>>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x32017B0 Offset: 0x32018B1 VA: 0x32017B0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>>>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x3202D30 Offset: 0x3202E31 VA: 0x3202D30
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>>>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x32041E0 Offset: 0x32042E1 VA: 0x32041E0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>>>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x3205740 Offset: 0x3205841 VA: 0x3205740
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>>>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x3206A70 Offset: 0x3206B71 VA: 0x3206A70
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>>>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x3207F00 Offset: 0x3208001 VA: 0x3207F00
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>>>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x3209420 Offset: 0x3209521 VA: 0x3209420
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>>>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x320A970 Offset: 0x320AA71 VA: 0x320A970
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>>>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x320BF10 Offset: 0x320C011 VA: 0x320BF10
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>>>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x320D480 Offset: 0x320D581 VA: 0x320D480
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>>>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x320EA80 Offset: 0x320EB81 VA: 0x320EA80
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>>>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x3210110 Offset: 0x3210211 VA: 0x3210110
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>>>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x3211820 Offset: 0x3211921 VA: 0x3211820
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>>>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x3212FA0 Offset: 0x32130A1 VA: 0x3212FA0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>>>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x32147B0 Offset: 0x32148B1 VA: 0x32147B0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>>>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x3215B40 Offset: 0x3215C41 VA: 0x3215B40
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x3216E50 Offset: 0x3216F51 VA: 0x3216E50
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x32183D0 Offset: 0x32184D1 VA: 0x32183D0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x3219720 Offset: 0x3219821 VA: 0x3219720
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x321AC10 Offset: 0x321AD11 VA: 0x321AC10
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x321C120 Offset: 0x321C221 VA: 0x321C120
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x3253280 Offset: 0x3253381 VA: 0x3253280
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x3254780 Offset: 0x3254881 VA: 0x3254780
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x3255CA0 Offset: 0x3255DA1 VA: 0x3255CA0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x32571B0 Offset: 0x32572B1 VA: 0x32571B0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x32586C0 Offset: 0x32587C1 VA: 0x32586C0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x3259AD0 Offset: 0x3259BD1 VA: 0x3259AD0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x325AFE0 Offset: 0x325B0E1 VA: 0x325AFE0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x325C310 Offset: 0x325C411 VA: 0x325C310
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x325D770 Offset: 0x325D871 VA: 0x325D770
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x325EC10 Offset: 0x325ED11 VA: 0x325EC10
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x3260130 Offset: 0x3260231 VA: 0x3260130
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x3261650 Offset: 0x3261751 VA: 0x3261650
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x3262B70 Offset: 0x3262C71 VA: 0x3262B70
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x32641E0 Offset: 0x32642E1 VA: 0x32641E0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x3265770 Offset: 0x3265871 VA: 0x3265770
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x3266EB0 Offset: 0x3266FB1 VA: 0x3266EB0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x32684F0 Offset: 0x32685F1 VA: 0x32684F0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x3269D40 Offset: 0x3269E41 VA: 0x3269D40
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x326B410 Offset: 0x326B511 VA: 0x326B410
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x326CD40 Offset: 0x326CE41 VA: 0x326CD40
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x326E4B0 Offset: 0x326E5B1 VA: 0x326E4B0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x326FC20 Offset: 0x326FD21 VA: 0x326FC20
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x3271400 Offset: 0x3271501 VA: 0x3271400
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x32726E0 Offset: 0x32727E1 VA: 0x32726E0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x3273940 Offset: 0x3273A41 VA: 0x3273940
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x3274E50 Offset: 0x3274F51 VA: 0x3274E50
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x3276120 Offset: 0x3276221 VA: 0x3276120
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x3277590 Offset: 0x3277691 VA: 0x3277590
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x3278A20 Offset: 0x3278B21 VA: 0x3278A20
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x3279D20 Offset: 0x3279E21 VA: 0x3279D20
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x327B170 Offset: 0x327B271 VA: 0x327B170
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x3296530 Offset: 0x3296631 VA: 0x3296530
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x32979C0 Offset: 0x3297AC1 VA: 0x32979C0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x3298E80 Offset: 0x3298F81 VA: 0x3298E80
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x329A1B0 Offset: 0x329A2B1 VA: 0x329A1B0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x329B610 Offset: 0x329B711 VA: 0x329B610
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x329C890 Offset: 0x329C991 VA: 0x329C890
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x329DC60 Offset: 0x329DD61 VA: 0x329DC60
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x329F0D0 Offset: 0x329F1D1 VA: 0x329F0D0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x32A0570 Offset: 0x32A0671 VA: 0x32A0570
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x32A1A10 Offset: 0x32A1B11 VA: 0x32A1A10
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x32A2E80 Offset: 0x32A2F81 VA: 0x32A2E80
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x32A4460 Offset: 0x32A4561 VA: 0x32A4460
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x32A59A0 Offset: 0x32A5AA1 VA: 0x32A59A0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x32A7090 Offset: 0x32A7191 VA: 0x32A7090
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x32A8640 Offset: 0x32A8741 VA: 0x32A8640
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x32A9E10 Offset: 0x32A9F11 VA: 0x32A9E10
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x32AB470 Offset: 0x32AB571 VA: 0x32AB470
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x32ACD50 Offset: 0x32ACE51 VA: 0x32ACD50
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x32AE440 Offset: 0x32AE541 VA: 0x32AE440
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x32AFE00 Offset: 0x32AFF01 VA: 0x32AFE00
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x32B1590 Offset: 0x32B1691 VA: 0x32B1590
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x32B2A80 Offset: 0x32B2B81 VA: 0x32B2A80
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>>>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x32B3F40 Offset: 0x32B4041 VA: 0x32B3F40
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x32B5230 Offset: 0x32B5331 VA: 0x32B5230
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x32B64F0 Offset: 0x32B65F1 VA: 0x32B64F0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x32B79E0 Offset: 0x32B7AE1 VA: 0x32B79E0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x32B8CC0 Offset: 0x32B8DC1 VA: 0x32B8CC0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x32BA120 Offset: 0x32BA221 VA: 0x32BA120
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x32BB520 Offset: 0x32BB621 VA: 0x32BB520
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x32BC810 Offset: 0x32BC911 VA: 0x32BC810
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x32BDC00 Offset: 0x32BDD01 VA: 0x32BDC00
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x33E5E50 Offset: 0x33E5F51 VA: 0x33E5E50
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x33E72B0 Offset: 0x33E73B1 VA: 0x33E72B0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x33E8720 Offset: 0x33E8821 VA: 0x33E8720
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x33E9A20 Offset: 0x33E9B21 VA: 0x33E9A20
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x33EAE10 Offset: 0x33EAF11 VA: 0x33EAE10
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x33EC0D0 Offset: 0x33EC1D1 VA: 0x33EC0D0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x33ED3D0 Offset: 0x33ED4D1 VA: 0x33ED3D0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x33EE7B0 Offset: 0x33EE8B1 VA: 0x33EE7B0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x33EFC20 Offset: 0x33EFD21 VA: 0x33EFC20
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x33F1020 Offset: 0x33F1121 VA: 0x33F1020
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x33F2420 Offset: 0x33F2521 VA: 0x33F2420
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x33F3970 Offset: 0x33F3A71 VA: 0x33F3970
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x33F4E00 Offset: 0x33F4F01 VA: 0x33F4E00
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x33F6450 Offset: 0x33F6551 VA: 0x33F6450
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x33F7990 Offset: 0x33F7A91 VA: 0x33F7990
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x33F90D0 Offset: 0x33F91D1 VA: 0x33F90D0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x33FA680 Offset: 0x33FA781 VA: 0x33FA680
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x33FBEB0 Offset: 0x33FBFB1 VA: 0x33FBEB0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x33FD510 Offset: 0x33FD611 VA: 0x33FD510
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x33FEE40 Offset: 0x33FEF41 VA: 0x33FEE40
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x3400530 Offset: 0x3400631 VA: 0x3400530
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x3401C80 Offset: 0x3401D81 VA: 0x3401C80
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x34031D0 Offset: 0x34032D1 VA: 0x34031D0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x3404480 Offset: 0x3404581 VA: 0x3404480
	|-ValueTuple<bool, ValueTuple<bool, AsyncUnit>>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x34056E0 Offset: 0x34057E1 VA: 0x34056E0
	|-ValueTuple<bool, ValueTuple<bool, bool>>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x3406B50 Offset: 0x3406C51 VA: 0x3406B50
	|-ValueTuple<bool, ValueTuple<bool, Bounds>>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x3407E00 Offset: 0x3407F01 VA: 0x3407E00
	|-ValueTuple<bool, ValueTuple<bool, byte>>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x34091D0 Offset: 0x34092D1 VA: 0x34091D0
	|-ValueTuple<bool, ValueTuple<bool, Color>>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x340A480 Offset: 0x340A581 VA: 0x340A480
	|-ValueTuple<bool, ValueTuple<bool, double>>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x340B720 Offset: 0x340B821 VA: 0x340B720
	|-ValueTuple<bool, ValueTuple<bool, int>>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x340C9A0 Offset: 0x340CAA1 VA: 0x340C9A0
	|-ValueTuple<bool, ValueTuple<bool, long>>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x351B050 Offset: 0x351B151 VA: 0x351B050
	|-ValueTuple<bool, ValueTuple<bool, object>>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x351C420 Offset: 0x351C521 VA: 0x351C420
	|-ValueTuple<bool, ValueTuple<bool, Quaternion>>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x351D820 Offset: 0x351D921 VA: 0x351D820
	|-ValueTuple<bool, ValueTuple<bool, Rect>>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x351EAF0 Offset: 0x351EBF1 VA: 0x351EAF0
	|-ValueTuple<bool, ValueTuple<bool, float>>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x351FD80 Offset: 0x351FE81 VA: 0x351FD80
	|-ValueTuple<bool, ValueTuple<bool, UniTask>>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x3520FE0 Offset: 0x35210E1 VA: 0x3520FE0
	|-ValueTuple<bool, ValueTuple<bool, Unit>>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x35222B0 Offset: 0x35223B1 VA: 0x35222B0
	|-ValueTuple<bool, ValueTuple<bool, Vector2>>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x35235B0 Offset: 0x35236B1 VA: 0x35235B0
	|-ValueTuple<bool, ValueTuple<bool, Vector3>>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x3524990 Offset: 0x3524A91 VA: 0x3524990
	|-ValueTuple<bool, ValueTuple<bool, Vector4>>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x3525C50 Offset: 0x3525D51 VA: 0x3525C50
	|-ValueTuple<bool, ValueTuple<int, object>>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x3526EF0 Offset: 0x3526FF1 VA: 0x3526EF0
	|-ValueTuple<bool, ValueTuple<object, object>>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x35283E0 Offset: 0x35284E1 VA: 0x35283E0
	|-ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x3529800 Offset: 0x3529901 VA: 0x3529800
	|-ValueTuple<bool, ValueTuple<object, object, object>>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x352ADF0 Offset: 0x352AEF1 VA: 0x352ADF0
	|-ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x352C2B0 Offset: 0x352C3B1 VA: 0x352C2B0
	|-ValueTuple<bool, ValueTuple<object, object, object, object>>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x352D990 Offset: 0x352DA91 VA: 0x352D990
	|-ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x352EF00 Offset: 0x352F001 VA: 0x352EF00
	|-ValueTuple<bool, ValueTuple<object, object, object, object, object>>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x35306E0 Offset: 0x35307E1 VA: 0x35306E0
	|-ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x3531CC0 Offset: 0x3531DC1 VA: 0x3531CC0
	|-ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x3533590 Offset: 0x3533691 VA: 0x3533590
	|-ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x3534C20 Offset: 0x3534D21 VA: 0x3534C20
	|-ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x35365F0 Offset: 0x35366F1 VA: 0x35365F0
	|-ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x3537B50 Offset: 0x3537C51 VA: 0x3537B50
	|-ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x3538D80 Offset: 0x3538E81 VA: 0x3538D80
	|-ValueTuple<bool, AsyncUnit>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x3539EE0 Offset: 0x3539FE1 VA: 0x3539EE0
	|-ValueTuple<bool, bool>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x353B1F0 Offset: 0x353B2F1 VA: 0x353B1F0
	|-ValueTuple<bool, Bounds>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x353C330 Offset: 0x353C431 VA: 0x353C330
	|-ValueTuple<bool, byte>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x353D510 Offset: 0x353D611 VA: 0x353D510
	|-ValueTuple<bool, Color>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x353E650 Offset: 0x353E751 VA: 0x353E650
	|-ValueTuple<bool, double>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x353F780 Offset: 0x353F881 VA: 0x353F780
	|-ValueTuple<bool, int>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x35408C0 Offset: 0x35409C1 VA: 0x35408C0
	|-ValueTuple<bool, long>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x37B2370 Offset: 0x37B2471 VA: 0x37B2370
	|-ValueTuple<bool, object>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x37B3590 Offset: 0x37B3691 VA: 0x37B3590
	|-ValueTuple<bool, Quaternion>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x37B4770 Offset: 0x37B4871 VA: 0x37B4770
	|-ValueTuple<bool, Rect>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x37B58B0 Offset: 0x37B59B1 VA: 0x37B58B0
	|-ValueTuple<bool, float>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x37B6A00 Offset: 0x37B6B01 VA: 0x37B6A00
	|-ValueTuple<bool, UniTask>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x37B7B30 Offset: 0x37B7C31 VA: 0x37B7B30
	|-ValueTuple<bool, Unit>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x37B8CB0 Offset: 0x37B8DB1 VA: 0x37B8CB0
	|-ValueTuple<bool, Vector2>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x37B9E60 Offset: 0x37B9F61 VA: 0x37B9E60
	|-ValueTuple<bool, Vector3>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x37BB040 Offset: 0x37BB141 VA: 0x37BB040
	|-ValueTuple<bool, Vector4>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x37BC1B0 Offset: 0x37BC2B1 VA: 0x37BC1B0
	|-ValueTuple<FXZ, int>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x37BD2E0 Offset: 0x37BD3E1 VA: 0x37BD2E0
	|-ValueTuple<int, bool>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x37BE580 Offset: 0x37BE681 VA: 0x37BE580
	|-ValueTuple<int, Bounds>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x37BF6A0 Offset: 0x37BF7A1 VA: 0x37BF6A0
	|-ValueTuple<int, byte>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x37C0850 Offset: 0x37C0951 VA: 0x37C0850
	|-ValueTuple<int, Color>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x37C1970 Offset: 0x37C1A71 VA: 0x37C1970
	|-ValueTuple<int, double>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x37C2A80 Offset: 0x37C2B81 VA: 0x37C2A80
	|-ValueTuple<int, int>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x37C3BA0 Offset: 0x37C3CA1 VA: 0x37C3BA0
	|-ValueTuple<int, long>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x37C4D20 Offset: 0x37C4E21 VA: 0x37C4D20
	|-ValueTuple<int, Int64Enum>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x37C5DA0 Offset: 0x37C5EA1 VA: 0x37C5DA0
	|-ValueTuple<int, object>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x37C6F90 Offset: 0x37C7091 VA: 0x37C6F90
	|-ValueTuple<int, Quaternion>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x37C8140 Offset: 0x37C8241 VA: 0x37C8140
	|-ValueTuple<int, Rect>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x37C9250 Offset: 0x37C9351 VA: 0x37C9250
	|-ValueTuple<int, float>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x37CA370 Offset: 0x37CA471 VA: 0x37CA370
	|-ValueTuple<int, Unit>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x37CB4E0 Offset: 0x37CB5E1 VA: 0x37CB4E0
	|-ValueTuple<int, Vector2>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x37CC680 Offset: 0x37CC781 VA: 0x37CC680
	|-ValueTuple<int, Vector3>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x37CD830 Offset: 0x37CD931 VA: 0x37CD830
	|-ValueTuple<int, Vector4>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x37CE990 Offset: 0x37CEA91 VA: 0x37CE990
	|-ValueTuple<Int32Enum, int>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x37CFB80 Offset: 0x37CFC81 VA: 0x37CFB80
	|-ValueTuple<Int64Enum, int>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x37D0CF0 Offset: 0x37D0DF1 VA: 0x37D0CF0
	|-ValueTuple<object, ValueTuple<object, int>>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x37D1E30 Offset: 0x37D1F31 VA: 0x37D1E30
	|-ValueTuple<object, bool>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x37D2E80 Offset: 0x37D2F81 VA: 0x37D2E80
	|-ValueTuple<object, int>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x388B5E0 Offset: 0x388B6E1 VA: 0x388B5E0
	|-ValueTuple<object, object>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x388C680 Offset: 0x388C781 VA: 0x388C680
	|-ValueTuple<object, float>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x388D7D0 Offset: 0x388D8D1 VA: 0x388D7D0
	|-ValueTuple<float, int>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x388E940 Offset: 0x388EA41 VA: 0x388E940
	|-ValueTuple<float, Int32Enum>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x388FB10 Offset: 0x388FC11 VA: 0x388FB10
	|-ValueTuple<float, float>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x3890D70 Offset: 0x3890E71 VA: 0x3890D70
	|-ValueTuple<UniTask, CancellationTokenRegistration>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x3892030 Offset: 0x3892131 VA: 0x3892030
	|-ValueTuple<Vector3, float>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x3893210 Offset: 0x3893311 VA: 0x3893210
	|-ValueTuple<Vector3, Vector3>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x3894440 Offset: 0x3894541 VA: 0x3894440
	|-ValueTuple<Vector4, Vector4>.System.IValueTupleInternal.GetHashCode
	*/

	// RVA: -1 Offset: -1 Slot: 3
	public override string ToString() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3393C90 Offset: 0x3393D91 VA: 0x3393C90
	|-ValueTuple<UniTask<object>, UniTask<object>>.ToString
	|
	|-RVA: 0x3395010 Offset: 0x3395111 VA: 0x3395010
	|-ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>.ToString
	|
	|-RVA: 0x3396320 Offset: 0x3396421 VA: 0x3396320
	|-ValueTuple<bool, UniTask<object>>.ToString
	|
	|-RVA: 0x3397710 Offset: 0x3397811 VA: 0x3397710
	|-ValueTuple<bool, ValueTuple<bool, UniTask<object>>>.ToString
	|
	|-RVA: 0x3398B80 Offset: 0x3398C81 VA: 0x3398B80
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>.ToString
	|
	|-RVA: 0x339A080 Offset: 0x339A181 VA: 0x339A080
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>>.ToString
	|
	|-RVA: 0x31F4950 Offset: 0x31F4A51 VA: 0x31F4950
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>>>.ToString
	|
	|-RVA: 0x31F5C80 Offset: 0x31F5D81 VA: 0x31F5C80
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>>>.ToString
	|
	|-RVA: 0x31F6F90 Offset: 0x31F7091 VA: 0x31F6F90
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>>>.ToString
	|
	|-RVA: 0x31F8540 Offset: 0x31F8641 VA: 0x31F8540
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>>>.ToString
	|
	|-RVA: 0x31F98B0 Offset: 0x31F99B1 VA: 0x31F98B0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>>>.ToString
	|
	|-RVA: 0x31FADE0 Offset: 0x31FAEE1 VA: 0x31FADE0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>>>.ToString
	|
	|-RVA: 0x31FC370 Offset: 0x31FC471 VA: 0x31FC370
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>>>.ToString
	|
	|-RVA: 0x31FD7F0 Offset: 0x31FD8F1 VA: 0x31FD7F0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>>>.ToString
	|
	|-RVA: 0x31FED40 Offset: 0x31FEE41 VA: 0x31FED40
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>>>.ToString
	|
	|-RVA: 0x32002B0 Offset: 0x32003B1 VA: 0x32002B0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>>>.ToString
	|
	|-RVA: 0x3201800 Offset: 0x3201901 VA: 0x3201800
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>>>.ToString
	|
	|-RVA: 0x3202D80 Offset: 0x3202E81 VA: 0x3202D80
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>>>.ToString
	|
	|-RVA: 0x3204230 Offset: 0x3204331 VA: 0x3204230
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>>>.ToString
	|
	|-RVA: 0x3205790 Offset: 0x3205891 VA: 0x3205790
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>>>.ToString
	|
	|-RVA: 0x3206AC0 Offset: 0x3206BC1 VA: 0x3206AC0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>>>.ToString
	|
	|-RVA: 0x3207F50 Offset: 0x3208051 VA: 0x3207F50
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>>>.ToString
	|
	|-RVA: 0x3209470 Offset: 0x3209571 VA: 0x3209470
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>>>.ToString
	|
	|-RVA: 0x320A9C0 Offset: 0x320AAC1 VA: 0x320A9C0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>>>.ToString
	|
	|-RVA: 0x320BF60 Offset: 0x320C061 VA: 0x320BF60
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>>>.ToString
	|
	|-RVA: 0x320D4D0 Offset: 0x320D5D1 VA: 0x320D4D0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>>>.ToString
	|
	|-RVA: 0x320EAD0 Offset: 0x320EBD1 VA: 0x320EAD0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>>>.ToString
	|
	|-RVA: 0x3210160 Offset: 0x3210261 VA: 0x3210160
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>>>.ToString
	|
	|-RVA: 0x3211870 Offset: 0x3211971 VA: 0x3211870
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>>>.ToString
	|
	|-RVA: 0x3212FF0 Offset: 0x32130F1 VA: 0x3212FF0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>>>.ToString
	|
	|-RVA: 0x3214800 Offset: 0x3214901 VA: 0x3214800
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>>>.ToString
	|
	|-RVA: 0x3215B90 Offset: 0x3215C91 VA: 0x3215B90
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>>.ToString
	|
	|-RVA: 0x3216EA0 Offset: 0x3216FA1 VA: 0x3216EA0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>>.ToString
	|
	|-RVA: 0x3218420 Offset: 0x3218521 VA: 0x3218420
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>>.ToString
	|
	|-RVA: 0x3219770 Offset: 0x3219871 VA: 0x3219770
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>>.ToString
	|
	|-RVA: 0x321AC60 Offset: 0x321AD61 VA: 0x321AC60
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>>.ToString
	|
	|-RVA: 0x321C170 Offset: 0x321C271 VA: 0x321C170
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>>.ToString
	|
	|-RVA: 0x32532D0 Offset: 0x32533D1 VA: 0x32532D0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>>.ToString
	|
	|-RVA: 0x32547D0 Offset: 0x32548D1 VA: 0x32547D0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>>.ToString
	|
	|-RVA: 0x3255CF0 Offset: 0x3255DF1 VA: 0x3255CF0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>>.ToString
	|
	|-RVA: 0x3257200 Offset: 0x3257301 VA: 0x3257200
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>>.ToString
	|
	|-RVA: 0x3258710 Offset: 0x3258811 VA: 0x3258710
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>>.ToString
	|
	|-RVA: 0x3259B20 Offset: 0x3259C21 VA: 0x3259B20
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>>.ToString
	|
	|-RVA: 0x325B030 Offset: 0x325B131 VA: 0x325B030
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>>.ToString
	|
	|-RVA: 0x325C360 Offset: 0x325C461 VA: 0x325C360
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>>.ToString
	|
	|-RVA: 0x325D7C0 Offset: 0x325D8C1 VA: 0x325D7C0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>>.ToString
	|
	|-RVA: 0x325EC60 Offset: 0x325ED61 VA: 0x325EC60
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>>.ToString
	|
	|-RVA: 0x3260180 Offset: 0x3260281 VA: 0x3260180
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>>.ToString
	|
	|-RVA: 0x32616A0 Offset: 0x32617A1 VA: 0x32616A0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>>.ToString
	|
	|-RVA: 0x3262BC0 Offset: 0x3262CC1 VA: 0x3262BC0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>>.ToString
	|
	|-RVA: 0x3264230 Offset: 0x3264331 VA: 0x3264230
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.ToString
	|
	|-RVA: 0x32657C0 Offset: 0x32658C1 VA: 0x32657C0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>>.ToString
	|
	|-RVA: 0x3266F00 Offset: 0x3267001 VA: 0x3266F00
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.ToString
	|
	|-RVA: 0x3268540 Offset: 0x3268641 VA: 0x3268540
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>>.ToString
	|
	|-RVA: 0x3269D90 Offset: 0x3269E91 VA: 0x3269D90
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.ToString
	|
	|-RVA: 0x326B460 Offset: 0x326B561 VA: 0x326B460
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>>.ToString
	|
	|-RVA: 0x326CD90 Offset: 0x326CE91 VA: 0x326CD90
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.ToString
	|
	|-RVA: 0x326E500 Offset: 0x326E601 VA: 0x326E500
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>>.ToString
	|
	|-RVA: 0x326FC70 Offset: 0x326FD71 VA: 0x326FC70
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.ToString
	|
	|-RVA: 0x3271450 Offset: 0x3271551 VA: 0x3271450
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>>.ToString
	|
	|-RVA: 0x3272730 Offset: 0x3272831 VA: 0x3272730
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>.ToString
	|
	|-RVA: 0x3273990 Offset: 0x3273A91 VA: 0x3273990
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>.ToString
	|
	|-RVA: 0x3274EA0 Offset: 0x3274FA1 VA: 0x3274EA0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>.ToString
	|
	|-RVA: 0x3276170 Offset: 0x3276271 VA: 0x3276170
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>.ToString
	|
	|-RVA: 0x32775E0 Offset: 0x32776E1 VA: 0x32775E0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>.ToString
	|
	|-RVA: 0x3278A70 Offset: 0x3278B71 VA: 0x3278A70
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>.ToString
	|
	|-RVA: 0x3279D70 Offset: 0x3279E71 VA: 0x3279D70
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>.ToString
	|
	|-RVA: 0x327B1C0 Offset: 0x327B2C1 VA: 0x327B1C0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>.ToString
	|
	|-RVA: 0x3296580 Offset: 0x3296681 VA: 0x3296580
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>.ToString
	|
	|-RVA: 0x3297A10 Offset: 0x3297B11 VA: 0x3297A10
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>.ToString
	|
	|-RVA: 0x3298ED0 Offset: 0x3298FD1 VA: 0x3298ED0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>.ToString
	|
	|-RVA: 0x329A200 Offset: 0x329A301 VA: 0x329A200
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>.ToString
	|
	|-RVA: 0x329B660 Offset: 0x329B761 VA: 0x329B660
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>.ToString
	|
	|-RVA: 0x329C8E0 Offset: 0x329C9E1 VA: 0x329C8E0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>.ToString
	|
	|-RVA: 0x329DCB0 Offset: 0x329DDB1 VA: 0x329DCB0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>.ToString
	|
	|-RVA: 0x329F120 Offset: 0x329F221 VA: 0x329F120
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>.ToString
	|
	|-RVA: 0x32A05C0 Offset: 0x32A06C1 VA: 0x32A05C0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>.ToString
	|
	|-RVA: 0x32A1A60 Offset: 0x32A1B61 VA: 0x32A1A60
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>.ToString
	|
	|-RVA: 0x32A2ED0 Offset: 0x32A2FD1 VA: 0x32A2ED0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>.ToString
	|
	|-RVA: 0x32A44B0 Offset: 0x32A45B1 VA: 0x32A44B0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.ToString
	|
	|-RVA: 0x32A59F0 Offset: 0x32A5AF1 VA: 0x32A59F0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>.ToString
	|
	|-RVA: 0x32A70E0 Offset: 0x32A71E1 VA: 0x32A70E0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.ToString
	|
	|-RVA: 0x32A8690 Offset: 0x32A8791 VA: 0x32A8690
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>.ToString
	|
	|-RVA: 0x32A9E60 Offset: 0x32A9F61 VA: 0x32A9E60
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.ToString
	|
	|-RVA: 0x32AB4C0 Offset: 0x32AB5C1 VA: 0x32AB4C0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>.ToString
	|
	|-RVA: 0x32ACDA0 Offset: 0x32ACEA1 VA: 0x32ACDA0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.ToString
	|
	|-RVA: 0x32AE490 Offset: 0x32AE591 VA: 0x32AE490
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>.ToString
	|
	|-RVA: 0x32AFE50 Offset: 0x32AFF51 VA: 0x32AFE50
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.ToString
	|
	|-RVA: 0x32B15E0 Offset: 0x32B16E1 VA: 0x32B15E0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>.ToString
	|
	|-RVA: 0x32B2AD0 Offset: 0x32B2BD1 VA: 0x32B2AD0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>>>.ToString
	|
	|-RVA: 0x32B3F90 Offset: 0x32B4091 VA: 0x32B3F90
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.ToString
	|
	|-RVA: 0x32B5280 Offset: 0x32B5381 VA: 0x32B5280
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>.ToString
	|
	|-RVA: 0x32B6540 Offset: 0x32B6641 VA: 0x32B6540
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>.ToString
	|
	|-RVA: 0x32B7A30 Offset: 0x32B7B31 VA: 0x32B7A30
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>.ToString
	|
	|-RVA: 0x32B8D10 Offset: 0x32B8E11 VA: 0x32B8D10
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>.ToString
	|
	|-RVA: 0x32BA170 Offset: 0x32BA271 VA: 0x32BA170
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>.ToString
	|
	|-RVA: 0x32BB570 Offset: 0x32BB671 VA: 0x32BB570
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>.ToString
	|
	|-RVA: 0x32BC860 Offset: 0x32BC961 VA: 0x32BC860
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>.ToString
	|
	|-RVA: 0x32BDC50 Offset: 0x32BDD51 VA: 0x32BDC50
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>.ToString
	|
	|-RVA: 0x33E5EA0 Offset: 0x33E5FA1 VA: 0x33E5EA0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>.ToString
	|
	|-RVA: 0x33E7300 Offset: 0x33E7401 VA: 0x33E7300
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>.ToString
	|
	|-RVA: 0x33E8770 Offset: 0x33E8871 VA: 0x33E8770
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>.ToString
	|
	|-RVA: 0x33E9A70 Offset: 0x33E9B71 VA: 0x33E9A70
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>.ToString
	|
	|-RVA: 0x33EAE60 Offset: 0x33EAF61 VA: 0x33EAE60
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>.ToString
	|
	|-RVA: 0x33EC120 Offset: 0x33EC221 VA: 0x33EC120
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>.ToString
	|
	|-RVA: 0x33ED420 Offset: 0x33ED521 VA: 0x33ED420
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>.ToString
	|
	|-RVA: 0x33EE800 Offset: 0x33EE901 VA: 0x33EE800
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>.ToString
	|
	|-RVA: 0x33EFC70 Offset: 0x33EFD71 VA: 0x33EFC70
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>.ToString
	|
	|-RVA: 0x33F1070 Offset: 0x33F1171 VA: 0x33F1070
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>.ToString
	|
	|-RVA: 0x33F2470 Offset: 0x33F2571 VA: 0x33F2470
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>.ToString
	|
	|-RVA: 0x33F39C0 Offset: 0x33F3AC1 VA: 0x33F39C0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.ToString
	|
	|-RVA: 0x33F4E50 Offset: 0x33F4F51 VA: 0x33F4E50
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>.ToString
	|
	|-RVA: 0x33F64A0 Offset: 0x33F65A1 VA: 0x33F64A0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.ToString
	|
	|-RVA: 0x33F79E0 Offset: 0x33F7AE1 VA: 0x33F79E0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>.ToString
	|
	|-RVA: 0x33F9120 Offset: 0x33F9221 VA: 0x33F9120
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.ToString
	|
	|-RVA: 0x33FA6D0 Offset: 0x33FA7D1 VA: 0x33FA6D0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>.ToString
	|
	|-RVA: 0x33FBF00 Offset: 0x33FC001 VA: 0x33FBF00
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.ToString
	|
	|-RVA: 0x33FD560 Offset: 0x33FD661 VA: 0x33FD560
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>.ToString
	|
	|-RVA: 0x33FEE90 Offset: 0x33FEF91 VA: 0x33FEE90
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.ToString
	|
	|-RVA: 0x3400580 Offset: 0x3400681 VA: 0x3400580
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>.ToString
	|
	|-RVA: 0x3401CD0 Offset: 0x3401DD1 VA: 0x3401CD0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>>.ToString
	|
	|-RVA: 0x3403220 Offset: 0x3403321 VA: 0x3403220
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.ToString
	|
	|-RVA: 0x34044D0 Offset: 0x34045D1 VA: 0x34044D0
	|-ValueTuple<bool, ValueTuple<bool, AsyncUnit>>.ToString
	|
	|-RVA: 0x3405730 Offset: 0x3405831 VA: 0x3405730
	|-ValueTuple<bool, ValueTuple<bool, bool>>.ToString
	|
	|-RVA: 0x3406BA0 Offset: 0x3406CA1 VA: 0x3406BA0
	|-ValueTuple<bool, ValueTuple<bool, Bounds>>.ToString
	|
	|-RVA: 0x3407E50 Offset: 0x3407F51 VA: 0x3407E50
	|-ValueTuple<bool, ValueTuple<bool, byte>>.ToString
	|
	|-RVA: 0x3409220 Offset: 0x3409321 VA: 0x3409220
	|-ValueTuple<bool, ValueTuple<bool, Color>>.ToString
	|
	|-RVA: 0x340A4D0 Offset: 0x340A5D1 VA: 0x340A4D0
	|-ValueTuple<bool, ValueTuple<bool, double>>.ToString
	|
	|-RVA: 0x340B770 Offset: 0x340B871 VA: 0x340B770
	|-ValueTuple<bool, ValueTuple<bool, int>>.ToString
	|
	|-RVA: 0x340C9F0 Offset: 0x340CAF1 VA: 0x340C9F0
	|-ValueTuple<bool, ValueTuple<bool, long>>.ToString
	|
	|-RVA: 0x351B0A0 Offset: 0x351B1A1 VA: 0x351B0A0
	|-ValueTuple<bool, ValueTuple<bool, object>>.ToString
	|
	|-RVA: 0x351C470 Offset: 0x351C571 VA: 0x351C470
	|-ValueTuple<bool, ValueTuple<bool, Quaternion>>.ToString
	|
	|-RVA: 0x351D870 Offset: 0x351D971 VA: 0x351D870
	|-ValueTuple<bool, ValueTuple<bool, Rect>>.ToString
	|
	|-RVA: 0x351EB40 Offset: 0x351EC41 VA: 0x351EB40
	|-ValueTuple<bool, ValueTuple<bool, float>>.ToString
	|
	|-RVA: 0x351FDD0 Offset: 0x351FED1 VA: 0x351FDD0
	|-ValueTuple<bool, ValueTuple<bool, UniTask>>.ToString
	|
	|-RVA: 0x3521030 Offset: 0x3521131 VA: 0x3521030
	|-ValueTuple<bool, ValueTuple<bool, Unit>>.ToString
	|
	|-RVA: 0x3522300 Offset: 0x3522401 VA: 0x3522300
	|-ValueTuple<bool, ValueTuple<bool, Vector2>>.ToString
	|
	|-RVA: 0x3523600 Offset: 0x3523701 VA: 0x3523600
	|-ValueTuple<bool, ValueTuple<bool, Vector3>>.ToString
	|
	|-RVA: 0x35249E0 Offset: 0x3524AE1 VA: 0x35249E0
	|-ValueTuple<bool, ValueTuple<bool, Vector4>>.ToString
	|
	|-RVA: 0x3525CA0 Offset: 0x3525DA1 VA: 0x3525CA0
	|-ValueTuple<bool, ValueTuple<int, object>>.ToString
	|
	|-RVA: 0x3526F40 Offset: 0x3527041 VA: 0x3526F40
	|-ValueTuple<bool, ValueTuple<object, object>>.ToString
	|
	|-RVA: 0x3528430 Offset: 0x3528531 VA: 0x3528430
	|-ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>.ToString
	|
	|-RVA: 0x3529850 Offset: 0x3529951 VA: 0x3529850
	|-ValueTuple<bool, ValueTuple<object, object, object>>.ToString
	|
	|-RVA: 0x352AE40 Offset: 0x352AF41 VA: 0x352AE40
	|-ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.ToString
	|
	|-RVA: 0x352C300 Offset: 0x352C401 VA: 0x352C300
	|-ValueTuple<bool, ValueTuple<object, object, object, object>>.ToString
	|
	|-RVA: 0x352D9E0 Offset: 0x352DAE1 VA: 0x352D9E0
	|-ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.ToString
	|
	|-RVA: 0x352EF50 Offset: 0x352F051 VA: 0x352EF50
	|-ValueTuple<bool, ValueTuple<object, object, object, object, object>>.ToString
	|
	|-RVA: 0x3530730 Offset: 0x3530831 VA: 0x3530730
	|-ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.ToString
	|
	|-RVA: 0x3531D10 Offset: 0x3531E11 VA: 0x3531D10
	|-ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>.ToString
	|
	|-RVA: 0x35335E0 Offset: 0x35336E1 VA: 0x35335E0
	|-ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.ToString
	|
	|-RVA: 0x3534C70 Offset: 0x3534D71 VA: 0x3534C70
	|-ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>.ToString
	|
	|-RVA: 0x3536640 Offset: 0x3536741 VA: 0x3536640
	|-ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>.ToString
	|
	|-RVA: 0x3537BA0 Offset: 0x3537CA1 VA: 0x3537BA0
	|-ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>.ToString
	|
	|-RVA: 0x3538DD0 Offset: 0x3538ED1 VA: 0x3538DD0
	|-ValueTuple<bool, AsyncUnit>.ToString
	|
	|-RVA: 0x3539F30 Offset: 0x353A031 VA: 0x3539F30
	|-ValueTuple<bool, bool>.ToString
	|
	|-RVA: 0x353B240 Offset: 0x353B341 VA: 0x353B240
	|-ValueTuple<bool, Bounds>.ToString
	|
	|-RVA: 0x353C380 Offset: 0x353C481 VA: 0x353C380
	|-ValueTuple<bool, byte>.ToString
	|
	|-RVA: 0x353D560 Offset: 0x353D661 VA: 0x353D560
	|-ValueTuple<bool, Color>.ToString
	|
	|-RVA: 0x353E6A0 Offset: 0x353E7A1 VA: 0x353E6A0
	|-ValueTuple<bool, double>.ToString
	|
	|-RVA: 0x353F7D0 Offset: 0x353F8D1 VA: 0x353F7D0
	|-ValueTuple<bool, int>.ToString
	|
	|-RVA: 0x3540910 Offset: 0x3540A11 VA: 0x3540910
	|-ValueTuple<bool, long>.ToString
	|
	|-RVA: 0x37B23C0 Offset: 0x37B24C1 VA: 0x37B23C0
	|-ValueTuple<bool, object>.ToString
	|
	|-RVA: 0x37B35E0 Offset: 0x37B36E1 VA: 0x37B35E0
	|-ValueTuple<bool, Quaternion>.ToString
	|
	|-RVA: 0x37B47C0 Offset: 0x37B48C1 VA: 0x37B47C0
	|-ValueTuple<bool, Rect>.ToString
	|
	|-RVA: 0x37B5900 Offset: 0x37B5A01 VA: 0x37B5900
	|-ValueTuple<bool, float>.ToString
	|
	|-RVA: 0x37B6A50 Offset: 0x37B6B51 VA: 0x37B6A50
	|-ValueTuple<bool, UniTask>.ToString
	|
	|-RVA: 0x37B7B80 Offset: 0x37B7C81 VA: 0x37B7B80
	|-ValueTuple<bool, Unit>.ToString
	|
	|-RVA: 0x37B8D00 Offset: 0x37B8E01 VA: 0x37B8D00
	|-ValueTuple<bool, Vector2>.ToString
	|
	|-RVA: 0x37B9EB0 Offset: 0x37B9FB1 VA: 0x37B9EB0
	|-ValueTuple<bool, Vector3>.ToString
	|
	|-RVA: 0x37BB090 Offset: 0x37BB191 VA: 0x37BB090
	|-ValueTuple<bool, Vector4>.ToString
	|
	|-RVA: 0x37BC200 Offset: 0x37BC301 VA: 0x37BC200
	|-ValueTuple<FXZ, int>.ToString
	|
	|-RVA: 0x37BD330 Offset: 0x37BD431 VA: 0x37BD330
	|-ValueTuple<int, bool>.ToString
	|
	|-RVA: 0x37BE5D0 Offset: 0x37BE6D1 VA: 0x37BE5D0
	|-ValueTuple<int, Bounds>.ToString
	|
	|-RVA: 0x37BF6F0 Offset: 0x37BF7F1 VA: 0x37BF6F0
	|-ValueTuple<int, byte>.ToString
	|
	|-RVA: 0x37C08A0 Offset: 0x37C09A1 VA: 0x37C08A0
	|-ValueTuple<int, Color>.ToString
	|
	|-RVA: 0x37C19C0 Offset: 0x37C1AC1 VA: 0x37C19C0
	|-ValueTuple<int, double>.ToString
	|
	|-RVA: 0x37C2AD0 Offset: 0x37C2BD1 VA: 0x37C2AD0
	|-ValueTuple<int, int>.ToString
	|
	|-RVA: 0x37C3BF0 Offset: 0x37C3CF1 VA: 0x37C3BF0
	|-ValueTuple<int, long>.ToString
	|
	|-RVA: 0x37C4D70 Offset: 0x37C4E71 VA: 0x37C4D70
	|-ValueTuple<int, Int64Enum>.ToString
	|
	|-RVA: 0x37C5DF0 Offset: 0x37C5EF1 VA: 0x37C5DF0
	|-ValueTuple<int, object>.ToString
	|
	|-RVA: 0x37C6FE0 Offset: 0x37C70E1 VA: 0x37C6FE0
	|-ValueTuple<int, Quaternion>.ToString
	|
	|-RVA: 0x37C8190 Offset: 0x37C8291 VA: 0x37C8190
	|-ValueTuple<int, Rect>.ToString
	|
	|-RVA: 0x37C92A0 Offset: 0x37C93A1 VA: 0x37C92A0
	|-ValueTuple<int, float>.ToString
	|
	|-RVA: 0x37CA3C0 Offset: 0x37CA4C1 VA: 0x37CA3C0
	|-ValueTuple<int, Unit>.ToString
	|
	|-RVA: 0x37CB530 Offset: 0x37CB631 VA: 0x37CB530
	|-ValueTuple<int, Vector2>.ToString
	|
	|-RVA: 0x37CC6D0 Offset: 0x37CC7D1 VA: 0x37CC6D0
	|-ValueTuple<int, Vector3>.ToString
	|
	|-RVA: 0x37CD880 Offset: 0x37CD981 VA: 0x37CD880
	|-ValueTuple<int, Vector4>.ToString
	|
	|-RVA: 0x37CE9E0 Offset: 0x37CEAE1 VA: 0x37CE9E0
	|-ValueTuple<Int32Enum, int>.ToString
	|
	|-RVA: 0x37CFBD0 Offset: 0x37CFCD1 VA: 0x37CFBD0
	|-ValueTuple<Int64Enum, int>.ToString
	|
	|-RVA: 0x37D0D40 Offset: 0x37D0E41 VA: 0x37D0D40
	|-ValueTuple<object, ValueTuple<object, int>>.ToString
	|
	|-RVA: 0x37D1E80 Offset: 0x37D1F81 VA: 0x37D1E80
	|-ValueTuple<object, bool>.ToString
	|
	|-RVA: 0x37D2ED0 Offset: 0x37D2FD1 VA: 0x37D2ED0
	|-ValueTuple<object, int>.ToString
	|
	|-RVA: 0x388B620 Offset: 0x388B721 VA: 0x388B620
	|-ValueTuple<object, object>.ToString
	|
	|-RVA: 0x388C6D0 Offset: 0x388C7D1 VA: 0x388C6D0
	|-ValueTuple<object, float>.ToString
	|
	|-RVA: 0x388D820 Offset: 0x388D921 VA: 0x388D820
	|-ValueTuple<float, int>.ToString
	|
	|-RVA: 0x388E990 Offset: 0x388EA91 VA: 0x388E990
	|-ValueTuple<float, Int32Enum>.ToString
	|
	|-RVA: 0x388FB60 Offset: 0x388FC61 VA: 0x388FB60
	|-ValueTuple<float, float>.ToString
	|
	|-RVA: 0x3890DC0 Offset: 0x3890EC1 VA: 0x3890DC0
	|-ValueTuple<UniTask, CancellationTokenRegistration>.ToString
	|
	|-RVA: 0x3892080 Offset: 0x3892181 VA: 0x3892080
	|-ValueTuple<Vector3, float>.ToString
	|
	|-RVA: 0x3893260 Offset: 0x3893361 VA: 0x3893260
	|-ValueTuple<Vector3, Vector3>.ToString
	|
	|-RVA: 0x3894490 Offset: 0x3894591 VA: 0x3894490
	|-ValueTuple<Vector4, Vector4>.ToString
	*/

	// RVA: -1 Offset: -1 Slot: 11
	private string System.IValueTupleInternal.ToStringEnd() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3393F40 Offset: 0x3394041 VA: 0x3393F40
	|-ValueTuple<UniTask<object>, UniTask<object>>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x33952C0 Offset: 0x33953C1 VA: 0x33952C0
	|-ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x3396590 Offset: 0x3396691 VA: 0x3396590
	|-ValueTuple<bool, UniTask<object>>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x3397990 Offset: 0x3397A91 VA: 0x3397990
	|-ValueTuple<bool, ValueTuple<bool, UniTask<object>>>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x3398E00 Offset: 0x3398F01 VA: 0x3398E00
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x339A310 Offset: 0x339A411 VA: 0x339A310
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x31F4BE0 Offset: 0x31F4CE1 VA: 0x31F4BE0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>>>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x31F5F00 Offset: 0x31F6001 VA: 0x31F5F00
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>>>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x31F7210 Offset: 0x31F7311 VA: 0x31F7210
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>>>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x31F87F0 Offset: 0x31F88F1 VA: 0x31F87F0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>>>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x31F9B30 Offset: 0x31F9C31 VA: 0x31F9B30
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>>>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x31FB080 Offset: 0x31FB181 VA: 0x31FB080
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>>>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x31FC600 Offset: 0x31FC701 VA: 0x31FC600
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>>>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x31FDA70 Offset: 0x31FDB71 VA: 0x31FDA70
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>>>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x31FEFD0 Offset: 0x31FF0D1 VA: 0x31FEFD0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>>>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x3200540 Offset: 0x3200641 VA: 0x3200540
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>>>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x3201AA0 Offset: 0x3201BA1 VA: 0x3201AA0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>>>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x3203020 Offset: 0x3203121 VA: 0x3203020
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>>>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x32044B0 Offset: 0x32045B1 VA: 0x32044B0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>>>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x3205A20 Offset: 0x3205B21 VA: 0x3205A20
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>>>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x3206D40 Offset: 0x3206E41 VA: 0x3206D40
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>>>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x32081E0 Offset: 0x32082E1 VA: 0x32081E0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>>>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x3209700 Offset: 0x3209801 VA: 0x3209700
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>>>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x320AC60 Offset: 0x320AD61 VA: 0x320AC60
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>>>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x320C1F0 Offset: 0x320C2F1 VA: 0x320C1F0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>>>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x320D760 Offset: 0x320D861 VA: 0x320D760
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>>>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x320ED70 Offset: 0x320EE71 VA: 0x320ED70
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>>>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x3210400 Offset: 0x3210501 VA: 0x3210400
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>>>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x3211B20 Offset: 0x3211C21 VA: 0x3211B20
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>>>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x32132A0 Offset: 0x32133A1 VA: 0x32132A0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>>>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x3214AC0 Offset: 0x3214BC1 VA: 0x3214AC0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>>>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x3215E10 Offset: 0x3215F11 VA: 0x3215E10
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x3217120 Offset: 0x3217221 VA: 0x3217120
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x32186C0 Offset: 0x32187C1 VA: 0x32186C0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x32199F0 Offset: 0x3219AF1 VA: 0x32199F0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x321AEF0 Offset: 0x321AFF1 VA: 0x321AEF0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x321C400 Offset: 0x321C501 VA: 0x321C400
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x3253550 Offset: 0x3253651 VA: 0x3253550
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x3254A60 Offset: 0x3254B61 VA: 0x3254A60
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x3255F80 Offset: 0x3256081 VA: 0x3255F80
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x3257490 Offset: 0x3257591 VA: 0x3257490
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x32589A0 Offset: 0x3258AA1 VA: 0x32589A0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x3259DA0 Offset: 0x3259EA1 VA: 0x3259DA0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x325B2C0 Offset: 0x325B3C1 VA: 0x325B2C0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x325C5E0 Offset: 0x325C6E1 VA: 0x325C5E0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x325DA40 Offset: 0x325DB41 VA: 0x325DA40
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x325EEF0 Offset: 0x325EFF1 VA: 0x325EEF0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x3260410 Offset: 0x3260511 VA: 0x3260410
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x3261930 Offset: 0x3261A31 VA: 0x3261930
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x3262E50 Offset: 0x3262F51 VA: 0x3262E50
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x32644D0 Offset: 0x32645D1 VA: 0x32644D0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x3265A50 Offset: 0x3265B51 VA: 0x3265A50
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x32671B0 Offset: 0x32672B1 VA: 0x32671B0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x32687E0 Offset: 0x32688E1 VA: 0x32687E0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x326A050 Offset: 0x326A151 VA: 0x326A050
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x326B700 Offset: 0x326B801 VA: 0x326B700
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x326D060 Offset: 0x326D161 VA: 0x326D060
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x326E7B0 Offset: 0x326E8B1 VA: 0x326E7B0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x326FF50 Offset: 0x3270051 VA: 0x326FF50
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x3271700 Offset: 0x3271801 VA: 0x3271700
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x32729A0 Offset: 0x3272AA1 VA: 0x32729A0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x3273C00 Offset: 0x3273D01 VA: 0x3273C00
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x3275140 Offset: 0x3275241 VA: 0x3275140
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x32763E0 Offset: 0x32764E1 VA: 0x32763E0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x3277870 Offset: 0x3277971 VA: 0x3277870
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x3278CF0 Offset: 0x3278DF1 VA: 0x3278CF0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x3279FE0 Offset: 0x327A0E1 VA: 0x3279FE0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x327B440 Offset: 0x327B541 VA: 0x327B440
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x3296800 Offset: 0x3296901 VA: 0x3296800
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x3297CA0 Offset: 0x3297DA1 VA: 0x3297CA0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x3299160 Offset: 0x3299261 VA: 0x3299160
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x329A470 Offset: 0x329A571 VA: 0x329A470
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x329B8E0 Offset: 0x329B9E1 VA: 0x329B8E0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x329CB50 Offset: 0x329CC51 VA: 0x329CB50
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x329DF30 Offset: 0x329E031 VA: 0x329DF30
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x329F3A0 Offset: 0x329F4A1 VA: 0x329F3A0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x32A0850 Offset: 0x32A0951 VA: 0x32A0850
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x32A1CE0 Offset: 0x32A1DE1 VA: 0x32A1CE0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x32A3150 Offset: 0x32A3251 VA: 0x32A3150
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x32A4750 Offset: 0x32A4851 VA: 0x32A4750
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x32A5C80 Offset: 0x32A5D81 VA: 0x32A5C80
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x32A7390 Offset: 0x32A7491 VA: 0x32A7390
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x32A8920 Offset: 0x32A8A21 VA: 0x32A8920
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x32AA120 Offset: 0x32AA221 VA: 0x32AA120
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x32AB760 Offset: 0x32AB861 VA: 0x32AB760
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x32AD070 Offset: 0x32AD171 VA: 0x32AD070
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x32AE730 Offset: 0x32AE831 VA: 0x32AE730
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x32B0130 Offset: 0x32B0231 VA: 0x32B0130
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x32B1890 Offset: 0x32B1991 VA: 0x32B1890
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x32B2D60 Offset: 0x32B2E61 VA: 0x32B2D60
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>>>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x32B4220 Offset: 0x32B4321 VA: 0x32B4220
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x32B5500 Offset: 0x32B5601 VA: 0x32B5500
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x32B67C0 Offset: 0x32B68C1 VA: 0x32B67C0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x32B7CC0 Offset: 0x32B7DC1 VA: 0x32B7CC0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x32B8F90 Offset: 0x32B9091 VA: 0x32B8F90
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x32BA3F0 Offset: 0x32BA4F1 VA: 0x32BA3F0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x32BB7F0 Offset: 0x32BB8F1 VA: 0x32BB7F0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x32BCAE0 Offset: 0x32BCBE1 VA: 0x32BCAE0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x32BDED0 Offset: 0x32BDFD1 VA: 0x32BDED0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x33E6120 Offset: 0x33E6221 VA: 0x33E6120
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x33E7580 Offset: 0x33E7681 VA: 0x33E7580
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x33E89F0 Offset: 0x33E8AF1 VA: 0x33E89F0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x33E9CF0 Offset: 0x33E9DF1 VA: 0x33E9CF0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x33EB0E0 Offset: 0x33EB1E1 VA: 0x33EB0E0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x33EC3A0 Offset: 0x33EC4A1 VA: 0x33EC3A0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x33ED690 Offset: 0x33ED791 VA: 0x33ED690
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x33EEA80 Offset: 0x33EEB81 VA: 0x33EEA80
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x33EFEF0 Offset: 0x33EFFF1 VA: 0x33EFEF0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x33F12F0 Offset: 0x33F13F1 VA: 0x33F12F0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x33F26F0 Offset: 0x33F27F1 VA: 0x33F26F0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x33F3C50 Offset: 0x33F3D51 VA: 0x33F3C50
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x33F50D0 Offset: 0x33F51D1 VA: 0x33F50D0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x33F6740 Offset: 0x33F6841 VA: 0x33F6740
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x33F7C70 Offset: 0x33F7D71 VA: 0x33F7C70
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x33F93D0 Offset: 0x33F94D1 VA: 0x33F93D0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x33FA960 Offset: 0x33FAA61 VA: 0x33FA960
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x33FC1C0 Offset: 0x33FC2C1 VA: 0x33FC1C0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x33FD800 Offset: 0x33FD901 VA: 0x33FD800
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x33FF160 Offset: 0x33FF261 VA: 0x33FF160
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x3400820 Offset: 0x3400921 VA: 0x3400820
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x3401FB0 Offset: 0x34020B1 VA: 0x3401FB0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x34034B0 Offset: 0x34035B1 VA: 0x34034B0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x3404740 Offset: 0x3404841 VA: 0x3404740
	|-ValueTuple<bool, ValueTuple<bool, AsyncUnit>>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x34059A0 Offset: 0x3405AA1 VA: 0x34059A0
	|-ValueTuple<bool, ValueTuple<bool, bool>>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x3406E30 Offset: 0x3406F31 VA: 0x3406E30
	|-ValueTuple<bool, ValueTuple<bool, Bounds>>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x34080C0 Offset: 0x34081C1 VA: 0x34080C0
	|-ValueTuple<bool, ValueTuple<bool, byte>>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x34094A0 Offset: 0x34095A1 VA: 0x34094A0
	|-ValueTuple<bool, ValueTuple<bool, Color>>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x340A740 Offset: 0x340A841 VA: 0x340A740
	|-ValueTuple<bool, ValueTuple<bool, double>>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x340B9E0 Offset: 0x340BAE1 VA: 0x340B9E0
	|-ValueTuple<bool, ValueTuple<bool, int>>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x340CC60 Offset: 0x340CD61 VA: 0x340CC60
	|-ValueTuple<bool, ValueTuple<bool, long>>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x351B310 Offset: 0x351B411 VA: 0x351B310
	|-ValueTuple<bool, ValueTuple<bool, object>>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x351C6F0 Offset: 0x351C7F1 VA: 0x351C6F0
	|-ValueTuple<bool, ValueTuple<bool, Quaternion>>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x351DAF0 Offset: 0x351DBF1 VA: 0x351DAF0
	|-ValueTuple<bool, ValueTuple<bool, Rect>>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x351EDB0 Offset: 0x351EEB1 VA: 0x351EDB0
	|-ValueTuple<bool, ValueTuple<bool, float>>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x3520040 Offset: 0x3520141 VA: 0x3520040
	|-ValueTuple<bool, ValueTuple<bool, UniTask>>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x35212A0 Offset: 0x35213A1 VA: 0x35212A0
	|-ValueTuple<bool, ValueTuple<bool, Unit>>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x3522580 Offset: 0x3522681 VA: 0x3522580
	|-ValueTuple<bool, ValueTuple<bool, Vector2>>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x3523870 Offset: 0x3523971 VA: 0x3523870
	|-ValueTuple<bool, ValueTuple<bool, Vector3>>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x3524C60 Offset: 0x3524D61 VA: 0x3524C60
	|-ValueTuple<bool, ValueTuple<bool, Vector4>>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x3525F10 Offset: 0x3526011 VA: 0x3525F10
	|-ValueTuple<bool, ValueTuple<int, object>>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x35271B0 Offset: 0x35272B1 VA: 0x35271B0
	|-ValueTuple<bool, ValueTuple<object, object>>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x35286C0 Offset: 0x35287C1 VA: 0x35286C0
	|-ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x3529AD0 Offset: 0x3529BD1 VA: 0x3529AD0
	|-ValueTuple<bool, ValueTuple<object, object, object>>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x352B0E0 Offset: 0x352B1E1 VA: 0x352B0E0
	|-ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x352C580 Offset: 0x352C681 VA: 0x352C580
	|-ValueTuple<bool, ValueTuple<object, object, object, object>>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x352DC90 Offset: 0x352DD91 VA: 0x352DC90
	|-ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x352F1E0 Offset: 0x352F2E1 VA: 0x352F1E0
	|-ValueTuple<bool, ValueTuple<object, object, object, object, object>>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x35309F0 Offset: 0x3530AF1 VA: 0x35309F0
	|-ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x3531FA0 Offset: 0x35320A1 VA: 0x3531FA0
	|-ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x35338B0 Offset: 0x35339B1 VA: 0x35338B0
	|-ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x3534F10 Offset: 0x3535011 VA: 0x3534F10
	|-ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x3536920 Offset: 0x3536A21 VA: 0x3536920
	|-ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x3537E30 Offset: 0x3537F31 VA: 0x3537E30
	|-ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x3538FE0 Offset: 0x35390E1 VA: 0x3538FE0
	|-ValueTuple<bool, AsyncUnit>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x353A140 Offset: 0x353A241 VA: 0x353A140
	|-ValueTuple<bool, bool>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x353B450 Offset: 0x353B551 VA: 0x353B450
	|-ValueTuple<bool, Bounds>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x353C590 Offset: 0x353C691 VA: 0x353C590
	|-ValueTuple<bool, byte>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x353D770 Offset: 0x353D871 VA: 0x353D770
	|-ValueTuple<bool, Color>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x353E8B0 Offset: 0x353E9B1 VA: 0x353E8B0
	|-ValueTuple<bool, double>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x353F9E0 Offset: 0x353FAE1 VA: 0x353F9E0
	|-ValueTuple<bool, int>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x3540B20 Offset: 0x3540C21 VA: 0x3540B20
	|-ValueTuple<bool, long>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x37B2600 Offset: 0x37B2701 VA: 0x37B2600
	|-ValueTuple<bool, object>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x37B37F0 Offset: 0x37B38F1 VA: 0x37B37F0
	|-ValueTuple<bool, Quaternion>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x37B49D0 Offset: 0x37B4AD1 VA: 0x37B49D0
	|-ValueTuple<bool, Rect>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x37B5B10 Offset: 0x37B5C11 VA: 0x37B5B10
	|-ValueTuple<bool, float>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x37B6C60 Offset: 0x37B6D61 VA: 0x37B6C60
	|-ValueTuple<bool, UniTask>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x37B7D90 Offset: 0x37B7E91 VA: 0x37B7D90
	|-ValueTuple<bool, Unit>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x37B8F10 Offset: 0x37B9011 VA: 0x37B8F10
	|-ValueTuple<bool, Vector2>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x37BA0C0 Offset: 0x37BA1C1 VA: 0x37BA0C0
	|-ValueTuple<bool, Vector3>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x37BB2A0 Offset: 0x37BB3A1 VA: 0x37BB2A0
	|-ValueTuple<bool, Vector4>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x37BC410 Offset: 0x37BC511 VA: 0x37BC410
	|-ValueTuple<FXZ, int>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x37BD540 Offset: 0x37BD641 VA: 0x37BD540
	|-ValueTuple<int, bool>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x37BE7E0 Offset: 0x37BE8E1 VA: 0x37BE7E0
	|-ValueTuple<int, Bounds>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x37BF900 Offset: 0x37BFA01 VA: 0x37BF900
	|-ValueTuple<int, byte>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x37C0AB0 Offset: 0x37C0BB1 VA: 0x37C0AB0
	|-ValueTuple<int, Color>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x37C1BD0 Offset: 0x37C1CD1 VA: 0x37C1BD0
	|-ValueTuple<int, double>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x37C2CE0 Offset: 0x37C2DE1 VA: 0x37C2CE0
	|-ValueTuple<int, int>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x37C3E00 Offset: 0x37C3F01 VA: 0x37C3E00
	|-ValueTuple<int, long>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x37C4FD0 Offset: 0x37C50D1 VA: 0x37C4FD0
	|-ValueTuple<int, Int64Enum>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x37C6030 Offset: 0x37C6131 VA: 0x37C6030
	|-ValueTuple<int, object>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x37C71F0 Offset: 0x37C72F1 VA: 0x37C71F0
	|-ValueTuple<int, Quaternion>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x37C83A0 Offset: 0x37C84A1 VA: 0x37C83A0
	|-ValueTuple<int, Rect>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x37C94B0 Offset: 0x37C95B1 VA: 0x37C94B0
	|-ValueTuple<int, float>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x37CA5D0 Offset: 0x37CA6D1 VA: 0x37CA5D0
	|-ValueTuple<int, Unit>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x37CB740 Offset: 0x37CB841 VA: 0x37CB740
	|-ValueTuple<int, Vector2>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x37CC8E0 Offset: 0x37CC9E1 VA: 0x37CC8E0
	|-ValueTuple<int, Vector3>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x37CDA90 Offset: 0x37CDB91 VA: 0x37CDA90
	|-ValueTuple<int, Vector4>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x37CEC40 Offset: 0x37CED41 VA: 0x37CEC40
	|-ValueTuple<Int32Enum, int>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x37CFE30 Offset: 0x37CFF31 VA: 0x37CFE30
	|-ValueTuple<Int64Enum, int>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x37D0FE0 Offset: 0x37D10E1 VA: 0x37D0FE0
	|-ValueTuple<object, ValueTuple<object, int>>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x37D20C0 Offset: 0x37D21C1 VA: 0x37D20C0
	|-ValueTuple<object, bool>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x37D3110 Offset: 0x37D3211 VA: 0x37D3110
	|-ValueTuple<object, int>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x388B890 Offset: 0x388B991 VA: 0x388B890
	|-ValueTuple<object, object>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x388C910 Offset: 0x388CA11 VA: 0x388C910
	|-ValueTuple<object, float>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x388DA30 Offset: 0x388DB31 VA: 0x388DA30
	|-ValueTuple<float, int>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x388EBF0 Offset: 0x388ECF1 VA: 0x388EBF0
	|-ValueTuple<float, Int32Enum>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x388FD70 Offset: 0x388FE71 VA: 0x388FD70
	|-ValueTuple<float, float>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x3891040 Offset: 0x3891141 VA: 0x3891040
	|-ValueTuple<UniTask, CancellationTokenRegistration>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x3892290 Offset: 0x3892391 VA: 0x3892290
	|-ValueTuple<Vector3, float>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x3893470 Offset: 0x3893571 VA: 0x3893470
	|-ValueTuple<Vector3, Vector3>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x38946A0 Offset: 0x38947A1 VA: 0x38946A0
	|-ValueTuple<Vector4, Vector4>.System.IValueTupleInternal.ToStringEnd
	*/

	// RVA: -1 Offset: -1 Slot: 12
	private int System.Runtime.CompilerServices.ITuple.get_Length() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3394080 Offset: 0x3394181 VA: 0x3394080
	|-ValueTuple<UniTask<object>, UniTask<object>>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x33953F0 Offset: 0x33954F1 VA: 0x33953F0
	|-ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x3396690 Offset: 0x3396791 VA: 0x3396690
	|-ValueTuple<bool, UniTask<object>>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x3397A90 Offset: 0x3397B91 VA: 0x3397A90
	|-ValueTuple<bool, ValueTuple<bool, UniTask<object>>>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x3398F00 Offset: 0x3399001 VA: 0x3398F00
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x339A420 Offset: 0x339A521 VA: 0x339A420
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x31F4CF0 Offset: 0x31F4DF1 VA: 0x31F4CF0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>>>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x31F6000 Offset: 0x31F6101 VA: 0x31F6000
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>>>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x31F7310 Offset: 0x31F7411 VA: 0x31F7310
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>>>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x31F8920 Offset: 0x31F8A21 VA: 0x31F8920
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>>>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x31F9C30 Offset: 0x31F9D31 VA: 0x31F9C30
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>>>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x31FB1B0 Offset: 0x31FB2B1 VA: 0x31FB1B0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>>>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x31FC710 Offset: 0x31FC811 VA: 0x31FC710
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>>>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x31FDB80 Offset: 0x31FDC81 VA: 0x31FDB80
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>>>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x31FF0E0 Offset: 0x31FF1E1 VA: 0x31FF0E0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>>>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x3200650 Offset: 0x3200751 VA: 0x3200650
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>>>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x3201BD0 Offset: 0x3201CD1 VA: 0x3201BD0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>>>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x3203150 Offset: 0x3203251 VA: 0x3203150
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>>>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x32045C0 Offset: 0x32046C1 VA: 0x32045C0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>>>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x3205B30 Offset: 0x3205C31 VA: 0x3205B30
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>>>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x3206E40 Offset: 0x3206F41 VA: 0x3206E40
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>>>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x3208300 Offset: 0x3208401 VA: 0x3208300
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>>>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x3209810 Offset: 0x3209911 VA: 0x3209810
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>>>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x320AD90 Offset: 0x320AE91 VA: 0x320AD90
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>>>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x320C300 Offset: 0x320C401 VA: 0x320C300
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>>>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x320D870 Offset: 0x320D971 VA: 0x320D870
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>>>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x320EE90 Offset: 0x320EF91 VA: 0x320EE90
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>>>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x3210520 Offset: 0x3210621 VA: 0x3210520
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>>>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x3211C50 Offset: 0x3211D51 VA: 0x3211C50
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>>>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x32133D0 Offset: 0x32134D1 VA: 0x32133D0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>>>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x3214C00 Offset: 0x3214D01 VA: 0x3214C00
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>>>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x3215F10 Offset: 0x3216011 VA: 0x3215F10
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x3217220 Offset: 0x3217321 VA: 0x3217220
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x32187E0 Offset: 0x32188E1 VA: 0x32187E0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x3219AF0 Offset: 0x3219BF1 VA: 0x3219AF0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x321B000 Offset: 0x321B101 VA: 0x321B000
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x321C510 Offset: 0x321C611 VA: 0x321C510
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x3253660 Offset: 0x3253761 VA: 0x3253660
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x3254B70 Offset: 0x3254C71 VA: 0x3254B70
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x3256090 Offset: 0x3256191 VA: 0x3256090
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x32575A0 Offset: 0x32576A1 VA: 0x32575A0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x3258AB0 Offset: 0x3258BB1 VA: 0x3258AB0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x3259EB0 Offset: 0x3259FB1 VA: 0x3259EB0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x325B3D0 Offset: 0x325B4D1 VA: 0x325B3D0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x325C6E0 Offset: 0x325C7E1 VA: 0x325C6E0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x325DB50 Offset: 0x325DC51 VA: 0x325DB50
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x325F010 Offset: 0x325F111 VA: 0x325F010
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x3260520 Offset: 0x3260621 VA: 0x3260520
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x3261A40 Offset: 0x3261B41 VA: 0x3261A40
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x3262F60 Offset: 0x3263061 VA: 0x3262F60
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x32645F0 Offset: 0x32646F1 VA: 0x32645F0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x3265B60 Offset: 0x3265C61 VA: 0x3265B60
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x32672E0 Offset: 0x32673E1 VA: 0x32672E0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x3268900 Offset: 0x3268A01 VA: 0x3268900
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x326A190 Offset: 0x326A291 VA: 0x326A190
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x326B820 Offset: 0x326B921 VA: 0x326B820
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x326D1B0 Offset: 0x326D2B1 VA: 0x326D1B0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x326E8E0 Offset: 0x326E9E1 VA: 0x326E8E0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x32700B0 Offset: 0x32701B1 VA: 0x32700B0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x3271830 Offset: 0x3271931 VA: 0x3271830
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x3272A90 Offset: 0x3272B91 VA: 0x3272A90
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x3273CF0 Offset: 0x3273DF1 VA: 0x3273CF0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x3275270 Offset: 0x3275371 VA: 0x3275270
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x32764D0 Offset: 0x32765D1 VA: 0x32764D0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x3277990 Offset: 0x3277A91 VA: 0x3277990
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x3278DF0 Offset: 0x3278EF1 VA: 0x3278DF0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x327A0E0 Offset: 0x327A1E1 VA: 0x327A0E0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x327B540 Offset: 0x327B641 VA: 0x327B540
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x3296900 Offset: 0x3296A01 VA: 0x3296900
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x3297DC0 Offset: 0x3297EC1 VA: 0x3297DC0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x3299280 Offset: 0x3299381 VA: 0x3299280
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x329A570 Offset: 0x329A671 VA: 0x329A570
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x329B9E0 Offset: 0x329BAE1 VA: 0x329B9E0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x329CC40 Offset: 0x329CD41 VA: 0x329CC40
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x329E040 Offset: 0x329E141 VA: 0x329E040
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x329F4B0 Offset: 0x329F5B1 VA: 0x329F4B0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x32A0970 Offset: 0x32A0A71 VA: 0x32A0970
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x32A1DE0 Offset: 0x32A1EE1 VA: 0x32A1DE0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x32A3250 Offset: 0x32A3351 VA: 0x32A3250
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x32A4870 Offset: 0x32A4971 VA: 0x32A4870
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x32A5D90 Offset: 0x32A5E91 VA: 0x32A5D90
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x32A74C0 Offset: 0x32A75C1 VA: 0x32A74C0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x32A8A30 Offset: 0x32A8B31 VA: 0x32A8A30
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x32AA260 Offset: 0x32AA361 VA: 0x32AA260
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x32AB880 Offset: 0x32AB981 VA: 0x32AB880
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x32AD1C0 Offset: 0x32AD2C1 VA: 0x32AD1C0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x32AE850 Offset: 0x32AE951 VA: 0x32AE850
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x32B0290 Offset: 0x32B0391 VA: 0x32B0290
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x32B19C0 Offset: 0x32B1AC1 VA: 0x32B19C0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x32B2E80 Offset: 0x32B2F81 VA: 0x32B2E80
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>>>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x32B4340 Offset: 0x32B4441 VA: 0x32B4340
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x32B5600 Offset: 0x32B5701 VA: 0x32B5600
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x32B68C0 Offset: 0x32B69C1 VA: 0x32B68C0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x32B7DD0 Offset: 0x32B7ED1 VA: 0x32B7DD0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x32B9090 Offset: 0x32B9191 VA: 0x32B9090
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x32BA500 Offset: 0x32BA601 VA: 0x32BA500
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x32BB8F0 Offset: 0x32BB9F1 VA: 0x32BB8F0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x32BCBE0 Offset: 0x32BCCE1 VA: 0x32BCBE0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x32BDFD0 Offset: 0x32BE0D1 VA: 0x32BDFD0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x33E6220 Offset: 0x33E6321 VA: 0x33E6220
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x33E7690 Offset: 0x33E7791 VA: 0x33E7690
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x33E8B00 Offset: 0x33E8C01 VA: 0x33E8B00
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x33E9DF0 Offset: 0x33E9EF1 VA: 0x33E9DF0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x33EB1E0 Offset: 0x33EB2E1 VA: 0x33EB1E0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x33EC4A0 Offset: 0x33EC5A1 VA: 0x33EC4A0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x33ED790 Offset: 0x33ED891 VA: 0x33ED790
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x33EEB90 Offset: 0x33EEC91 VA: 0x33EEB90
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x33F0000 Offset: 0x33F0101 VA: 0x33F0000
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x33F13F0 Offset: 0x33F14F1 VA: 0x33F13F0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x33F27F0 Offset: 0x33F28F1 VA: 0x33F27F0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x33F3D60 Offset: 0x33F3E61 VA: 0x33F3D60
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x33F51D0 Offset: 0x33F52D1 VA: 0x33F51D0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x33F6860 Offset: 0x33F6961 VA: 0x33F6860
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x33F7D80 Offset: 0x33F7E81 VA: 0x33F7D80
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x33F9500 Offset: 0x33F9601 VA: 0x33F9500
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x33FAA70 Offset: 0x33FAB71 VA: 0x33FAA70
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x33FC300 Offset: 0x33FC401 VA: 0x33FC300
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x33FD920 Offset: 0x33FDA21 VA: 0x33FD920
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x33FF2B0 Offset: 0x33FF3B1 VA: 0x33FF2B0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x3400940 Offset: 0x3400A41 VA: 0x3400940
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x3402110 Offset: 0x3402211 VA: 0x3402110
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x34035D0 Offset: 0x34036D1 VA: 0x34035D0
	|-ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x3404830 Offset: 0x3404931 VA: 0x3404830
	|-ValueTuple<bool, ValueTuple<bool, AsyncUnit>>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x3405A90 Offset: 0x3405B91 VA: 0x3405A90
	|-ValueTuple<bool, ValueTuple<bool, bool>>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x3406F50 Offset: 0x3407051 VA: 0x3406F50
	|-ValueTuple<bool, ValueTuple<bool, Bounds>>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x34081B0 Offset: 0x34082B1 VA: 0x34081B0
	|-ValueTuple<bool, ValueTuple<bool, byte>>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x34095B0 Offset: 0x34096B1 VA: 0x34095B0
	|-ValueTuple<bool, ValueTuple<bool, Color>>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x340A830 Offset: 0x340A931 VA: 0x340A830
	|-ValueTuple<bool, ValueTuple<bool, double>>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x340BAD0 Offset: 0x340BBD1 VA: 0x340BAD0
	|-ValueTuple<bool, ValueTuple<bool, int>>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x340CD50 Offset: 0x340CE51 VA: 0x340CD50
	|-ValueTuple<bool, ValueTuple<bool, long>>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x351B400 Offset: 0x351B501 VA: 0x351B400
	|-ValueTuple<bool, ValueTuple<bool, object>>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x351C800 Offset: 0x351C901 VA: 0x351C800
	|-ValueTuple<bool, ValueTuple<bool, Quaternion>>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x351DC00 Offset: 0x351DD01 VA: 0x351DC00
	|-ValueTuple<bool, ValueTuple<bool, Rect>>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x351EEA0 Offset: 0x351EFA1 VA: 0x351EEA0
	|-ValueTuple<bool, ValueTuple<bool, float>>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x3520130 Offset: 0x3520231 VA: 0x3520130
	|-ValueTuple<bool, ValueTuple<bool, UniTask>>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x3521390 Offset: 0x3521491 VA: 0x3521390
	|-ValueTuple<bool, ValueTuple<bool, Unit>>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x3522680 Offset: 0x3522781 VA: 0x3522680
	|-ValueTuple<bool, ValueTuple<bool, Vector2>>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x3523970 Offset: 0x3523A71 VA: 0x3523970
	|-ValueTuple<bool, ValueTuple<bool, Vector3>>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x3524D70 Offset: 0x3524E71 VA: 0x3524D70
	|-ValueTuple<bool, ValueTuple<bool, Vector4>>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x3526010 Offset: 0x3526111 VA: 0x3526010
	|-ValueTuple<bool, ValueTuple<int, object>>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x35272B0 Offset: 0x35273B1 VA: 0x35272B0
	|-ValueTuple<bool, ValueTuple<object, object>>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x35287E0 Offset: 0x35288E1 VA: 0x35287E0
	|-ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x3529BE0 Offset: 0x3529CE1 VA: 0x3529BE0
	|-ValueTuple<bool, ValueTuple<object, object, object>>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x352B210 Offset: 0x352B311 VA: 0x352B210
	|-ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x352C690 Offset: 0x352C791 VA: 0x352C690
	|-ValueTuple<bool, ValueTuple<object, object, object, object>>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x352DDD0 Offset: 0x352DED1 VA: 0x352DDD0
	|-ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x352F300 Offset: 0x352F401 VA: 0x352F300
	|-ValueTuple<bool, ValueTuple<object, object, object, object, object>>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x3530B40 Offset: 0x3530C41 VA: 0x3530B40
	|-ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x35320C0 Offset: 0x35321C1 VA: 0x35320C0
	|-ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x3533A10 Offset: 0x3533B11 VA: 0x3533A10
	|-ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x3535040 Offset: 0x3535141 VA: 0x3535040
	|-ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x3536A90 Offset: 0x3536B91 VA: 0x3536A90
	|-ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x3537F50 Offset: 0x3538051 VA: 0x3537F50
	|-ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x3539080 Offset: 0x3539181 VA: 0x3539080
	|-ValueTuple<bool, AsyncUnit>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x353A1E0 Offset: 0x353A2E1 VA: 0x353A1E0
	|-ValueTuple<bool, bool>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x353B4F0 Offset: 0x353B5F1 VA: 0x353B4F0
	|-ValueTuple<bool, Bounds>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x353C630 Offset: 0x353C731 VA: 0x353C630
	|-ValueTuple<bool, byte>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x353D810 Offset: 0x353D911 VA: 0x353D810
	|-ValueTuple<bool, Color>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x353E950 Offset: 0x353EA51 VA: 0x353E950
	|-ValueTuple<bool, double>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x353FA80 Offset: 0x353FB81 VA: 0x353FA80
	|-ValueTuple<bool, int>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x3540BC0 Offset: 0x3540CC1 VA: 0x3540BC0
	|-ValueTuple<bool, long>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x37B26B0 Offset: 0x37B27B1 VA: 0x37B26B0
	|-ValueTuple<bool, object>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x37B3890 Offset: 0x37B3991 VA: 0x37B3890
	|-ValueTuple<bool, Quaternion>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x37B4A70 Offset: 0x37B4B71 VA: 0x37B4A70
	|-ValueTuple<bool, Rect>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x37B5BB0 Offset: 0x37B5CB1 VA: 0x37B5BB0
	|-ValueTuple<bool, float>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x37B6D00 Offset: 0x37B6E01 VA: 0x37B6D00
	|-ValueTuple<bool, UniTask>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x37B7E30 Offset: 0x37B7F31 VA: 0x37B7E30
	|-ValueTuple<bool, Unit>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x37B8FB0 Offset: 0x37B90B1 VA: 0x37B8FB0
	|-ValueTuple<bool, Vector2>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x37BA160 Offset: 0x37BA261 VA: 0x37BA160
	|-ValueTuple<bool, Vector3>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x37BB340 Offset: 0x37BB441 VA: 0x37BB340
	|-ValueTuple<bool, Vector4>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x37BC4B0 Offset: 0x37BC5B1 VA: 0x37BC4B0
	|-ValueTuple<FXZ, int>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x37BD5E0 Offset: 0x37BD6E1 VA: 0x37BD5E0
	|-ValueTuple<int, bool>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x37BE880 Offset: 0x37BE981 VA: 0x37BE880
	|-ValueTuple<int, Bounds>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x37BF9A0 Offset: 0x37BFAA1 VA: 0x37BF9A0
	|-ValueTuple<int, byte>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x37C0B50 Offset: 0x37C0C51 VA: 0x37C0B50
	|-ValueTuple<int, Color>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x37C1C70 Offset: 0x37C1D71 VA: 0x37C1C70
	|-ValueTuple<int, double>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x37C2D80 Offset: 0x37C2E81 VA: 0x37C2D80
	|-ValueTuple<int, int>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x37C3EA0 Offset: 0x37C3FA1 VA: 0x37C3EA0
	|-ValueTuple<int, long>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x37C50C0 Offset: 0x37C51C1 VA: 0x37C50C0
	|-ValueTuple<int, Int64Enum>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x37C60E0 Offset: 0x37C61E1 VA: 0x37C60E0
	|-ValueTuple<int, object>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x37C7290 Offset: 0x37C7391 VA: 0x37C7290
	|-ValueTuple<int, Quaternion>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x37C8440 Offset: 0x37C8541 VA: 0x37C8440
	|-ValueTuple<int, Rect>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x37C9550 Offset: 0x37C9651 VA: 0x37C9550
	|-ValueTuple<int, float>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x37CA670 Offset: 0x37CA771 VA: 0x37CA670
	|-ValueTuple<int, Unit>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x37CB7E0 Offset: 0x37CB8E1 VA: 0x37CB7E0
	|-ValueTuple<int, Vector2>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x37CC980 Offset: 0x37CCA81 VA: 0x37CC980
	|-ValueTuple<int, Vector3>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x37CDB30 Offset: 0x37CDC31 VA: 0x37CDB30
	|-ValueTuple<int, Vector4>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x37CED20 Offset: 0x37CEE21 VA: 0x37CED20
	|-ValueTuple<Int32Enum, int>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x37CFF10 Offset: 0x37D0011 VA: 0x37CFF10
	|-ValueTuple<Int64Enum, int>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x37D1100 Offset: 0x37D1201 VA: 0x37D1100
	|-ValueTuple<object, ValueTuple<object, int>>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x37D2170 Offset: 0x37D2271 VA: 0x37D2170
	|-ValueTuple<object, bool>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x37D31C0 Offset: 0x37D32C1 VA: 0x37D31C0
	|-ValueTuple<object, int>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x388B950 Offset: 0x388BA51 VA: 0x388B950
	|-ValueTuple<object, object>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x388C9C0 Offset: 0x388CAC1 VA: 0x388C9C0
	|-ValueTuple<object, float>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x388DAD0 Offset: 0x388DBD1 VA: 0x388DAD0
	|-ValueTuple<float, int>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x388ECE0 Offset: 0x388EDE1 VA: 0x388ECE0
	|-ValueTuple<float, Int32Enum>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x388FE10 Offset: 0x388FF11 VA: 0x388FE10
	|-ValueTuple<float, float>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x3891150 Offset: 0x3891251 VA: 0x3891150
	|-ValueTuple<UniTask, CancellationTokenRegistration>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x3892330 Offset: 0x3892431 VA: 0x3892330
	|-ValueTuple<Vector3, float>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x3893510 Offset: 0x3893611 VA: 0x3893510
	|-ValueTuple<Vector3, Vector3>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x3894740 Offset: 0x3894841 VA: 0x3894740
	|-ValueTuple<Vector4, Vector4>.System.Runtime.CompilerServices.ITuple.get_Length
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
public struct ValueTuple<T1, T2, T3, T4> : IEquatable<ValueTuple<T1, T2, T3, T4>>, IStructuralEquatable, IStructuralComparable, IComparable, IComparable<ValueTuple<T1, T2, T3, T4>>, IValueTupleInternal, ITuple // TypeDefIndex: 109
{
	// Fields
	public T1 Item1; // 0x0
	public T2 Item2; // 0x0
	public T3 Item3; // 0x0
	public T4 Item4; // 0x0

	// Properties
	private int System.Runtime.CompilerServices.ITuple.Length { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(T1 item1, T2 item2, T3 item3, T4 item4) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x389EB00 Offset: 0x389EC01 VA: 0x389EB00
	|-ValueTuple<UniTask<object>, UniTask<object>, UniTask<object>, UniTask<object>>..ctor
	|
	|-RVA: 0x38A0B10 Offset: 0x38A0C11 VA: 0x38A0B10
	|-ValueTuple<bool, bool, Task<BufferOffsetSize>, WebException>..ctor
	|-ValueTuple<bool, bool, object, object>..ctor
	|
	|-RVA: 0x38A2540 Offset: 0x38A2641 VA: 0x38A2540
	|-ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>..ctor
	|
	|-RVA: 0x38A4430 Offset: 0x38A4531 VA: 0x38A4430
	|-ValueTuple<object, int, int, int>..ctor
	|-ValueTuple<string, int, int, int>..ctor
	|
	|-RVA: 0x38A5EF0 Offset: 0x38A5FF1 VA: 0x38A5EF0
	|-ValueTuple<object, object, object, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 0
	public override bool Equals(object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x389EB90 Offset: 0x389EC91 VA: 0x389EB90
	|-ValueTuple<UniTask<object>, UniTask<object>, UniTask<object>, UniTask<object>>.Equals
	|
	|-RVA: 0x38A0B60 Offset: 0x38A0C61 VA: 0x38A0B60
	|-ValueTuple<bool, bool, object, object>.Equals
	|
	|-RVA: 0x38A25C0 Offset: 0x38A26C1 VA: 0x38A25C0
	|-ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>.Equals
	|
	|-RVA: 0x38A4470 Offset: 0x38A4571 VA: 0x38A4470
	|-ValueTuple<object, int, int, int>.Equals
	|
	|-RVA: 0x38A5F60 Offset: 0x38A6061 VA: 0x38A5F60
	|-ValueTuple<object, object, object, object>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public bool Equals(ValueTuple<T1, T2, T3, T4> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x389ED00 Offset: 0x389EE01 VA: 0x389ED00
	|-ValueTuple<UniTask<object>, UniTask<object>, UniTask<object>, UniTask<object>>.Equals
	|
	|-RVA: 0x38A0CB0 Offset: 0x38A0DB1 VA: 0x38A0CB0
	|-ValueTuple<bool, bool, object, object>.Equals
	|
	|-RVA: 0x38A2730 Offset: 0x38A2831 VA: 0x38A2730
	|-ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>.Equals
	|
	|-RVA: 0x38A45C0 Offset: 0x38A46C1 VA: 0x38A45C0
	|-ValueTuple<object, int, int, int>.Equals
	|
	|-RVA: 0x38A60B0 Offset: 0x38A61B1 VA: 0x38A60B0
	|-ValueTuple<object, object, object, object>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private bool System.Collections.IStructuralEquatable.Equals(object other, IEqualityComparer comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x389EEC0 Offset: 0x389EFC1 VA: 0x389EEC0
	|-ValueTuple<UniTask<object>, UniTask<object>, UniTask<object>, UniTask<object>>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x38A0E80 Offset: 0x38A0F81 VA: 0x38A0E80
	|-ValueTuple<bool, bool, object, object>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x38A28F0 Offset: 0x38A29F1 VA: 0x38A28F0
	|-ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x38A4780 Offset: 0x38A4881 VA: 0x38A4780
	|-ValueTuple<object, int, int, int>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x38A6270 Offset: 0x38A6371 VA: 0x38A6270
	|-ValueTuple<object, object, object, object>.System.Collections.IStructuralEquatable.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private int System.IComparable.CompareTo(object other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x389F3C0 Offset: 0x389F4C1 VA: 0x389F3C0
	|-ValueTuple<UniTask<object>, UniTask<object>, UniTask<object>, UniTask<object>>.System.IComparable.CompareTo
	|
	|-RVA: 0x38A1270 Offset: 0x38A1371 VA: 0x38A1270
	|-ValueTuple<bool, bool, object, object>.System.IComparable.CompareTo
	|
	|-RVA: 0x38A2DF0 Offset: 0x38A2EF1 VA: 0x38A2DF0
	|-ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>.System.IComparable.CompareTo
	|
	|-RVA: 0x38A4BE0 Offset: 0x38A4CE1 VA: 0x38A4BE0
	|-ValueTuple<object, int, int, int>.System.IComparable.CompareTo
	|
	|-RVA: 0x38A6550 Offset: 0x38A6651 VA: 0x38A6550
	|-ValueTuple<object, object, object, object>.System.IComparable.CompareTo
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public int CompareTo(ValueTuple<T1, T2, T3, T4> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x389F5D0 Offset: 0x389F6D1 VA: 0x389F5D0
	|-ValueTuple<UniTask<object>, UniTask<object>, UniTask<object>, UniTask<object>>.CompareTo
	|
	|-RVA: 0x38A1450 Offset: 0x38A1551 VA: 0x38A1450
	|-ValueTuple<bool, bool, object, object>.CompareTo
	|
	|-RVA: 0x38A3000 Offset: 0x38A3101 VA: 0x38A3000
	|-ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>.CompareTo
	|
	|-RVA: 0x38A4DC0 Offset: 0x38A4EC1 VA: 0x38A4DC0
	|-ValueTuple<object, int, int, int>.CompareTo
	|
	|-RVA: 0x38A6730 Offset: 0x38A6831 VA: 0x38A6730
	|-ValueTuple<object, object, object, object>.CompareTo
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private int System.Collections.IStructuralComparable.CompareTo(object other, IComparer comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x389F780 Offset: 0x389F881 VA: 0x389F780
	|-ValueTuple<UniTask<object>, UniTask<object>, UniTask<object>, UniTask<object>>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x38A1610 Offset: 0x38A1711 VA: 0x38A1610
	|-ValueTuple<bool, bool, object, object>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x38A31B0 Offset: 0x38A32B1 VA: 0x38A31B0
	|-ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x38A4F70 Offset: 0x38A5071 VA: 0x38A4F70
	|-ValueTuple<object, int, int, int>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x38A68E0 Offset: 0x38A69E1 VA: 0x38A68E0
	|-ValueTuple<object, object, object, object>.System.Collections.IStructuralComparable.CompareTo
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public override int GetHashCode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x389FD30 Offset: 0x389FE31 VA: 0x389FD30
	|-ValueTuple<UniTask<object>, UniTask<object>, UniTask<object>, UniTask<object>>.GetHashCode
	|
	|-RVA: 0x38A1AA0 Offset: 0x38A1BA1 VA: 0x38A1AA0
	|-ValueTuple<bool, bool, object, object>.GetHashCode
	|
	|-RVA: 0x38A3760 Offset: 0x38A3861 VA: 0x38A3760
	|-ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>.GetHashCode
	|
	|-RVA: 0x38A5480 Offset: 0x38A5581 VA: 0x38A5480
	|-ValueTuple<object, int, int, int>.GetHashCode
	|
	|-RVA: 0x38A6C80 Offset: 0x38A6D81 VA: 0x38A6C80
	|-ValueTuple<object, object, object, object>.GetHashCode
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private int System.Collections.IStructuralEquatable.GetHashCode(IEqualityComparer comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x389FEE0 Offset: 0x389FFE1 VA: 0x389FEE0
	|-ValueTuple<UniTask<object>, UniTask<object>, UniTask<object>, UniTask<object>>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x38A1B40 Offset: 0x38A1C41 VA: 0x38A1B40
	|-ValueTuple<bool, bool, object, object>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x38A38B0 Offset: 0x38A39B1 VA: 0x38A38B0
	|-ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x38A5510 Offset: 0x38A5611 VA: 0x38A5510
	|-ValueTuple<object, int, int, int>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x38A6D40 Offset: 0x38A6E41 VA: 0x38A6D40
	|-ValueTuple<object, object, object, object>.System.Collections.IStructuralEquatable.GetHashCode
	*/

	// RVA: -1 Offset: -1
	private int GetHashCodeCore(IEqualityComparer comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x389FF30 Offset: 0x38A0031 VA: 0x389FF30
	|-ValueTuple<UniTask<object>, UniTask<object>, UniTask<object>, UniTask<object>>.GetHashCodeCore
	|
	|-RVA: 0x38A1B90 Offset: 0x38A1C91 VA: 0x38A1B90
	|-ValueTuple<bool, bool, object, object>.GetHashCodeCore
	|
	|-RVA: 0x38A3900 Offset: 0x38A3A01 VA: 0x38A3900
	|-ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>.GetHashCodeCore
	|
	|-RVA: 0x38A5560 Offset: 0x38A5661 VA: 0x38A5560
	|-ValueTuple<object, int, int, int>.GetHashCodeCore
	|
	|-RVA: 0x38A6D80 Offset: 0x38A6E81 VA: 0x38A6D80
	|-ValueTuple<object, object, object, object>.GetHashCodeCore
	*/

	// RVA: -1 Offset: -1 Slot: 10
	private int System.IValueTupleInternal.GetHashCode(IEqualityComparer comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x38A0250 Offset: 0x38A0351 VA: 0x38A0250
	|-ValueTuple<UniTask<object>, UniTask<object>, UniTask<object>, UniTask<object>>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x38A1E30 Offset: 0x38A1F31 VA: 0x38A1E30
	|-ValueTuple<bool, bool, object, object>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x38A3C20 Offset: 0x38A3D21 VA: 0x38A3C20
	|-ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x38A5840 Offset: 0x38A5941 VA: 0x38A5840
	|-ValueTuple<object, int, int, int>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x38A6F90 Offset: 0x38A7091 VA: 0x38A6F90
	|-ValueTuple<object, object, object, object>.System.IValueTupleInternal.GetHashCode
	*/

	// RVA: -1 Offset: -1 Slot: 3
	public override string ToString() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x38A02A0 Offset: 0x38A03A1 VA: 0x38A02A0
	|-ValueTuple<UniTask<object>, UniTask<object>, UniTask<object>, UniTask<object>>.ToString
	|
	|-RVA: 0x38A1E80 Offset: 0x38A1F81 VA: 0x38A1E80
	|-ValueTuple<bool, bool, object, object>.ToString
	|
	|-RVA: 0x38A3C70 Offset: 0x38A3D71 VA: 0x38A3C70
	|-ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>.ToString
	|
	|-RVA: 0x38A5890 Offset: 0x38A5991 VA: 0x38A5890
	|-ValueTuple<object, int, int, int>.ToString
	|
	|-RVA: 0x38A6FD0 Offset: 0x38A70D1 VA: 0x38A6FD0
	|-ValueTuple<object, object, object, object>.ToString
	*/

	// RVA: -1 Offset: -1 Slot: 11
	private string System.IValueTupleInternal.ToStringEnd() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x38A0700 Offset: 0x38A0801 VA: 0x38A0700
	|-ValueTuple<UniTask<object>, UniTask<object>, UniTask<object>, UniTask<object>>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x38A2200 Offset: 0x38A2301 VA: 0x38A2200
	|-ValueTuple<bool, bool, object, object>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x38A4070 Offset: 0x38A4171 VA: 0x38A4070
	|-ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x38A5BE0 Offset: 0x38A5CE1 VA: 0x38A5BE0
	|-ValueTuple<object, int, int, int>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x38A73B0 Offset: 0x38A74B1 VA: 0x38A73B0
	|-ValueTuple<object, object, object, object>.System.IValueTupleInternal.ToStringEnd
	*/

	// RVA: -1 Offset: -1 Slot: 12
	private int System.Runtime.CompilerServices.ITuple.get_Length() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x38A0B00 Offset: 0x38A0C01 VA: 0x38A0B00
	|-ValueTuple<UniTask<object>, UniTask<object>, UniTask<object>, UniTask<object>>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x38A2530 Offset: 0x38A2631 VA: 0x38A2530
	|-ValueTuple<bool, bool, object, object>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x38A4420 Offset: 0x38A4521 VA: 0x38A4420
	|-ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x38A5EE0 Offset: 0x38A5FE1 VA: 0x38A5EE0
	|-ValueTuple<object, int, int, int>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x38A7730 Offset: 0x38A7831 VA: 0x38A7730
	|-ValueTuple<object, object, object, object>.System.Runtime.CompilerServices.ITuple.get_Length
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
public struct ValueTuple<T1, T2, T3, T4, T5, T6> : IEquatable<ValueTuple<T1, T2, T3, T4, T5, T6>>, IStructuralEquatable, IStructuralComparable, IComparable, IComparable<ValueTuple<T1, T2, T3, T4, T5, T6>>, IValueTupleInternal, ITuple // TypeDefIndex: 111
{
	// Fields
	public T1 Item1; // 0x0
	public T2 Item2; // 0x0
	public T3 Item3; // 0x0
	public T4 Item4; // 0x0
	public T5 Item5; // 0x0
	public T6 Item6; // 0x0

	// Properties
	private int System.Runtime.CompilerServices.ITuple.Length { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3A39DA0 Offset: 0x3A39EA1 VA: 0x3A39DA0
	|-ValueTuple<UniTask<object>, UniTask<object>, UniTask<object>, UniTask<object>, UniTask<object>, UniTask<object>>..ctor
	|
	|-RVA: 0x3A3C940 Offset: 0x3A3CA41 VA: 0x3A3C940
	|-ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>..ctor
	|
	|-RVA: 0x3A3F3B0 Offset: 0x3A3F4B1 VA: 0x3A3F3B0
	|-ValueTuple<object, object, object, object, object, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 0
	public override bool Equals(object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3A39E80 Offset: 0x3A39F81 VA: 0x3A39E80
	|-ValueTuple<UniTask<object>, UniTask<object>, UniTask<object>, UniTask<object>, UniTask<object>, UniTask<object>>.Equals
	|
	|-RVA: 0x3A3CA00 Offset: 0x3A3CB01 VA: 0x3A3CA00
	|-ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>.Equals
	|
	|-RVA: 0x3A3F450 Offset: 0x3A3F551 VA: 0x3A3F450
	|-ValueTuple<object, object, object, object, object, object>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public bool Equals(ValueTuple<T1, T2, T3, T4, T5, T6> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3A3A010 Offset: 0x3A3A111 VA: 0x3A3A010
	|-ValueTuple<UniTask<object>, UniTask<object>, UniTask<object>, UniTask<object>, UniTask<object>, UniTask<object>>.Equals
	|
	|-RVA: 0x3A3CB90 Offset: 0x3A3CC91 VA: 0x3A3CB90
	|-ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>.Equals
	|
	|-RVA: 0x3A3F5B0 Offset: 0x3A3F6B1 VA: 0x3A3F5B0
	|-ValueTuple<object, object, object, object, object, object>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private bool System.Collections.IStructuralEquatable.Equals(object other, IEqualityComparer comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3A3A280 Offset: 0x3A3A381 VA: 0x3A3A280
	|-ValueTuple<UniTask<object>, UniTask<object>, UniTask<object>, UniTask<object>, UniTask<object>, UniTask<object>>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x3A3CE00 Offset: 0x3A3CF01 VA: 0x3A3CE00
	|-ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x3A3F820 Offset: 0x3A3F921 VA: 0x3A3F820
	|-ValueTuple<object, object, object, object, object, object>.System.Collections.IStructuralEquatable.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private int System.IComparable.CompareTo(object other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3A3A990 Offset: 0x3A3AA91 VA: 0x3A3A990
	|-ValueTuple<UniTask<object>, UniTask<object>, UniTask<object>, UniTask<object>, UniTask<object>, UniTask<object>>.System.IComparable.CompareTo
	|
	|-RVA: 0x3A3D510 Offset: 0x3A3D611 VA: 0x3A3D510
	|-ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>.System.IComparable.CompareTo
	|
	|-RVA: 0x3A3FBE0 Offset: 0x3A3FCE1 VA: 0x3A3FBE0
	|-ValueTuple<object, object, object, object, object, object>.System.IComparable.CompareTo
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public int CompareTo(ValueTuple<T1, T2, T3, T4, T5, T6> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3A3ABD0 Offset: 0x3A3ACD1 VA: 0x3A3ABD0
	|-ValueTuple<UniTask<object>, UniTask<object>, UniTask<object>, UniTask<object>, UniTask<object>, UniTask<object>>.CompareTo
	|
	|-RVA: 0x3A3D750 Offset: 0x3A3D851 VA: 0x3A3D750
	|-ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>.CompareTo
	|
	|-RVA: 0x3A3FDE0 Offset: 0x3A3FEE1 VA: 0x3A3FDE0
	|-ValueTuple<object, object, object, object, object, object>.CompareTo
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private int System.Collections.IStructuralComparable.CompareTo(object other, IComparer comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3A3AE40 Offset: 0x3A3AF41 VA: 0x3A3AE40
	|-ValueTuple<UniTask<object>, UniTask<object>, UniTask<object>, UniTask<object>, UniTask<object>, UniTask<object>>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x3A3D9C0 Offset: 0x3A3DAC1 VA: 0x3A3D9C0
	|-ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x3A40050 Offset: 0x3A40151 VA: 0x3A40050
	|-ValueTuple<object, object, object, object, object, object>.System.Collections.IStructuralComparable.CompareTo
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public override int GetHashCode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3A3B610 Offset: 0x3A3B711 VA: 0x3A3B610
	|-ValueTuple<UniTask<object>, UniTask<object>, UniTask<object>, UniTask<object>, UniTask<object>, UniTask<object>>.GetHashCode
	|
	|-RVA: 0x3A3E1A0 Offset: 0x3A3E2A1 VA: 0x3A3E1A0
	|-ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>.GetHashCode
	|
	|-RVA: 0x3A404D0 Offset: 0x3A405D1 VA: 0x3A404D0
	|-ValueTuple<object, object, object, object, object, object>.GetHashCode
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private int System.Collections.IStructuralEquatable.GetHashCode(IEqualityComparer comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3A3B870 Offset: 0x3A3B971 VA: 0x3A3B870
	|-ValueTuple<UniTask<object>, UniTask<object>, UniTask<object>, UniTask<object>, UniTask<object>, UniTask<object>>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x3A3E3A0 Offset: 0x3A3E4A1 VA: 0x3A3E3A0
	|-ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x3A405F0 Offset: 0x3A406F1 VA: 0x3A405F0
	|-ValueTuple<object, object, object, object, object, object>.System.Collections.IStructuralEquatable.GetHashCode
	*/

	// RVA: -1 Offset: -1
	private int GetHashCodeCore(IEqualityComparer comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3A3B8C0 Offset: 0x3A3B9C1 VA: 0x3A3B8C0
	|-ValueTuple<UniTask<object>, UniTask<object>, UniTask<object>, UniTask<object>, UniTask<object>, UniTask<object>>.GetHashCodeCore
	|
	|-RVA: 0x3A3E3F0 Offset: 0x3A3E4F1 VA: 0x3A3E3F0
	|-ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>.GetHashCodeCore
	|
	|-RVA: 0x3A40630 Offset: 0x3A40731 VA: 0x3A40630
	|-ValueTuple<object, object, object, object, object, object>.GetHashCodeCore
	*/

	// RVA: -1 Offset: -1 Slot: 10
	private int System.IValueTupleInternal.GetHashCode(IEqualityComparer comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3A3BD40 Offset: 0x3A3BE41 VA: 0x3A3BD40
	|-ValueTuple<UniTask<object>, UniTask<object>, UniTask<object>, UniTask<object>, UniTask<object>, UniTask<object>>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x3A3E870 Offset: 0x3A3E971 VA: 0x3A3E870
	|-ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x3A40920 Offset: 0x3A40A21 VA: 0x3A40920
	|-ValueTuple<object, object, object, object, object, object>.System.IValueTupleInternal.GetHashCode
	*/

	// RVA: -1 Offset: -1 Slot: 3
	public override string ToString() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3A3BD90 Offset: 0x3A3BE91 VA: 0x3A3BD90
	|-ValueTuple<UniTask<object>, UniTask<object>, UniTask<object>, UniTask<object>, UniTask<object>, UniTask<object>>.ToString
	|
	|-RVA: 0x3A3E8C0 Offset: 0x3A3E9C1 VA: 0x3A3E8C0
	|-ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>.ToString
	|
	|-RVA: 0x3A40960 Offset: 0x3A40A61 VA: 0x3A40960
	|-ValueTuple<object, object, object, object, object, object>.ToString
	*/

	// RVA: -1 Offset: -1 Slot: 11
	private string System.IValueTupleInternal.ToStringEnd() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3A3C390 Offset: 0x3A3C491 VA: 0x3A3C390
	|-ValueTuple<UniTask<object>, UniTask<object>, UniTask<object>, UniTask<object>, UniTask<object>, UniTask<object>>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x3A3EE60 Offset: 0x3A3EF61 VA: 0x3A3EE60
	|-ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x3A40EB0 Offset: 0x3A40FB1 VA: 0x3A40EB0
	|-ValueTuple<object, object, object, object, object, object>.System.IValueTupleInternal.ToStringEnd
	*/

	// RVA: -1 Offset: -1 Slot: 12
	private int System.Runtime.CompilerServices.ITuple.get_Length() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3A3C930 Offset: 0x3A3CA31 VA: 0x3A3C930
	|-ValueTuple<UniTask<object>, UniTask<object>, UniTask<object>, UniTask<object>, UniTask<object>, UniTask<object>>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x3A3F3A0 Offset: 0x3A3F4A1 VA: 0x3A3F3A0
	|-ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x3A413A0 Offset: 0x3A414A1 VA: 0x3A413A0
	|-ValueTuple<object, object, object, object, object, object>.System.Runtime.CompilerServices.ITuple.get_Length
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

