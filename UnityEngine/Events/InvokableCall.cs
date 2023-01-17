// Namespace: UnityEngine.Events
internal class InvokableCall : BaseInvokableCall // TypeDefIndex: 3684
{
	// Fields
	[DebuggerBrowsableAttribute] // RVA: 0x444080 Offset: 0x444181 VA: 0x444080
	[CompilerGeneratedAttribute] // RVA: 0x444080 Offset: 0x444181 VA: 0x444080
	private UnityAction Delegate; // 0x10

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x452860 Offset: 0x452961 VA: 0x452860
	// RVA: 0x2F25AE0 Offset: 0x2F25BE1 VA: 0x2F25AE0
	private void add_Delegate(UnityAction value) { }

	[CompilerGeneratedAttribute] // RVA: 0x452870 Offset: 0x452971 VA: 0x452870
	// RVA: 0x2F25B90 Offset: 0x2F25C91 VA: 0x2F25B90
	private void remove_Delegate(UnityAction value) { }

	// RVA: 0x2F25C40 Offset: 0x2F25D41 VA: 0x2F25C40
	public void .ctor(object target, MethodInfo theFunction) { }

	// RVA: 0x2F25DA0 Offset: 0x2F25EA1 VA: 0x2F25DA0
	public void .ctor(UnityAction action) { }

	// RVA: 0x2F25E50 Offset: 0x2F25F51 VA: 0x2F25E50 Slot: 4
	public override void Invoke(object[] args) { }

	// RVA: 0x2F25F20 Offset: 0x2F26021 VA: 0x2F25F20
	public void Invoke() { }

	// RVA: 0x2F25FF0 Offset: 0x2F260F1 VA: 0x2F25FF0 Slot: 5
	public override bool Find(object targetObj, MethodInfo method) { }
}

// Namespace: UnityEngine.Events
internal class InvokableCall<T1> : BaseInvokableCall // TypeDefIndex: 3685
{
	// Fields
	[DebuggerBrowsableAttribute] // RVA: 0x4440C0 Offset: 0x4441C1 VA: 0x4440C0
	[CompilerGeneratedAttribute] // RVA: 0x4440C0 Offset: 0x4441C1 VA: 0x4440C0
	private UnityAction<T1> Delegate; // 0x0

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x452880 Offset: 0x452981 VA: 0x452880
	// RVA: -1 Offset: -1
	protected void add_Delegate(UnityAction<T1> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D88D30 Offset: 0x2D88E31 VA: 0x2D88D30
	|-InvokableCall<bool>.add_Delegate
	|
	|-RVA: 0x2D89220 Offset: 0x2D89321 VA: 0x2D89220
	|-InvokableCall<Color>.add_Delegate
	|
	|-RVA: 0x2D89730 Offset: 0x2D89831 VA: 0x2D89730
	|-InvokableCall<int>.add_Delegate
	|
	|-RVA: 0x2D89C20 Offset: 0x2D89D21 VA: 0x2D89C20
	|-InvokableCall<Int32Enum>.add_Delegate
	|
	|-RVA: 0x2D8A110 Offset: 0x2D8A211 VA: 0x2D8A110
	|-InvokableCall<object>.add_Delegate
	|
	|-RVA: 0x2D8A5F0 Offset: 0x2D8A6F1 VA: 0x2D8A5F0
	|-InvokableCall<float>.add_Delegate
	|
	|-RVA: 0x2D8AAE0 Offset: 0x2D8ABE1 VA: 0x2D8AAE0
	|-InvokableCall<Vector2>.add_Delegate
	*/

	[CompilerGeneratedAttribute] // RVA: 0x452890 Offset: 0x452991 VA: 0x452890
	// RVA: -1 Offset: -1
	protected void remove_Delegate(UnityAction<T1> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D88DE0 Offset: 0x2D88EE1 VA: 0x2D88DE0
	|-InvokableCall<bool>.remove_Delegate
	|
	|-RVA: 0x2D892D0 Offset: 0x2D893D1 VA: 0x2D892D0
	|-InvokableCall<Color>.remove_Delegate
	|
	|-RVA: 0x2D897E0 Offset: 0x2D898E1 VA: 0x2D897E0
	|-InvokableCall<int>.remove_Delegate
	|
	|-RVA: 0x2D89CD0 Offset: 0x2D89DD1 VA: 0x2D89CD0
	|-InvokableCall<Int32Enum>.remove_Delegate
	|
	|-RVA: 0x2D8A1C0 Offset: 0x2D8A2C1 VA: 0x2D8A1C0
	|-InvokableCall<object>.remove_Delegate
	|
	|-RVA: 0x2D8A6A0 Offset: 0x2D8A7A1 VA: 0x2D8A6A0
	|-InvokableCall<float>.remove_Delegate
	|
	|-RVA: 0x2D8AB90 Offset: 0x2D8AC91 VA: 0x2D8AB90
	|-InvokableCall<Vector2>.remove_Delegate
	*/

	// RVA: -1 Offset: -1
	public void .ctor(object target, MethodInfo theFunction) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D88E90 Offset: 0x2D88F91 VA: 0x2D88E90
	|-InvokableCall<bool>..ctor
	|
	|-RVA: 0x2D89380 Offset: 0x2D89481 VA: 0x2D89380
	|-InvokableCall<Color>..ctor
	|
	|-RVA: 0x2D89890 Offset: 0x2D89991 VA: 0x2D89890
	|-InvokableCall<int>..ctor
	|
	|-RVA: 0x2D89D80 Offset: 0x2D89E81 VA: 0x2D89D80
	|-InvokableCall<Int32Enum>..ctor
	|
	|-RVA: 0x2D8A270 Offset: 0x2D8A371 VA: 0x2D8A270
	|-InvokableCall<object>..ctor
	|
	|-RVA: 0x2D8A750 Offset: 0x2D8A851 VA: 0x2D8A750
	|-InvokableCall<float>..ctor
	|
	|-RVA: 0x2D8AC40 Offset: 0x2D8AD41 VA: 0x2D8AC40
	|-InvokableCall<Vector2>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(UnityAction<T1> action) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D88FC0 Offset: 0x2D890C1 VA: 0x2D88FC0
	|-InvokableCall<bool>..ctor
	|
	|-RVA: 0x2D894B0 Offset: 0x2D895B1 VA: 0x2D894B0
	|-InvokableCall<Color>..ctor
	|
	|-RVA: 0x2D899C0 Offset: 0x2D89AC1 VA: 0x2D899C0
	|-InvokableCall<int>..ctor
	|
	|-RVA: 0x2D89EB0 Offset: 0x2D89FB1 VA: 0x2D89EB0
	|-InvokableCall<Int32Enum>..ctor
	|
	|-RVA: 0x2D8A3A0 Offset: 0x2D8A4A1 VA: 0x2D8A3A0
	|-InvokableCall<object>..ctor
	|
	|-RVA: 0x2D8A880 Offset: 0x2D8A981 VA: 0x2D8A880
	|-InvokableCall<float>..ctor
	|
	|-RVA: 0x2D8AD70 Offset: 0x2D8AE71 VA: 0x2D8AD70
	|-InvokableCall<Vector2>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public override void Invoke(object[] args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D89010 Offset: 0x2D89111 VA: 0x2D89010
	|-InvokableCall<bool>.Invoke
	|
	|-RVA: 0x2D89500 Offset: 0x2D89601 VA: 0x2D89500
	|-InvokableCall<Color>.Invoke
	|
	|-RVA: 0x2D89A10 Offset: 0x2D89B11 VA: 0x2D89A10
	|-InvokableCall<int>.Invoke
	|
	|-RVA: 0x2D89F00 Offset: 0x2D8A001 VA: 0x2D89F00
	|-InvokableCall<Int32Enum>.Invoke
	|
	|-RVA: 0x2D8A3F0 Offset: 0x2D8A4F1 VA: 0x2D8A3F0
	|-InvokableCall<object>.Invoke
	|
	|-RVA: 0x2D8A8D0 Offset: 0x2D8A9D1 VA: 0x2D8A8D0
	|-InvokableCall<float>.Invoke
	|
	|-RVA: 0x2D8ADC0 Offset: 0x2D8AEC1 VA: 0x2D8ADC0
	|-InvokableCall<Vector2>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public virtual void Invoke(T1 args0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D89160 Offset: 0x2D89261 VA: 0x2D89160
	|-InvokableCall<bool>.Invoke
	|
	|-RVA: 0x2D89650 Offset: 0x2D89751 VA: 0x2D89650
	|-InvokableCall<Color>.Invoke
	|
	|-RVA: 0x2D89B60 Offset: 0x2D89C61 VA: 0x2D89B60
	|-InvokableCall<int>.Invoke
	|
	|-RVA: 0x2D8A050 Offset: 0x2D8A151 VA: 0x2D8A050
	|-InvokableCall<Int32Enum>.Invoke
	|
	|-RVA: 0x2D8A530 Offset: 0x2D8A631 VA: 0x2D8A530
	|-InvokableCall<object>.Invoke
	|
	|-RVA: 0x2D8AA20 Offset: 0x2D8AB21 VA: 0x2D8AA20
	|-InvokableCall<float>.Invoke
	|
	|-RVA: 0x2D8AF10 Offset: 0x2D8B011 VA: 0x2D8AF10
	|-InvokableCall<Vector2>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public override bool Find(object targetObj, MethodInfo method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D891D0 Offset: 0x2D892D1 VA: 0x2D891D0
	|-InvokableCall<bool>.Find
	|
	|-RVA: 0x2D896E0 Offset: 0x2D897E1 VA: 0x2D896E0
	|-InvokableCall<Color>.Find
	|
	|-RVA: 0x2D89BD0 Offset: 0x2D89CD1 VA: 0x2D89BD0
	|-InvokableCall<int>.Find
	|
	|-RVA: 0x2D8A0C0 Offset: 0x2D8A1C1 VA: 0x2D8A0C0
	|-InvokableCall<Int32Enum>.Find
	|
	|-RVA: 0x2D8A5A0 Offset: 0x2D8A6A1 VA: 0x2D8A5A0
	|-InvokableCall<object>.Find
	|
	|-RVA: 0x2D8AA90 Offset: 0x2D8AB91 VA: 0x2D8AA90
	|-InvokableCall<float>.Find
	|
	|-RVA: 0x2D8AF80 Offset: 0x2D8B081 VA: 0x2D8AF80
	|-InvokableCall<Vector2>.Find
	*/
}

// Namespace: UnityEngine.Events
internal class InvokableCall<T1, T2> : BaseInvokableCall // TypeDefIndex: 3686
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x444100 Offset: 0x444201 VA: 0x444100
	[DebuggerBrowsableAttribute] // RVA: 0x444100 Offset: 0x444201 VA: 0x444100
	private UnityAction<T1, T2> Delegate; // 0x0

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x4528A0 Offset: 0x4529A1 VA: 0x4528A0
	// RVA: -1 Offset: -1
	protected void add_Delegate(UnityAction<T1, T2> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D8AFD0 Offset: 0x2D8B0D1 VA: 0x2D8AFD0
	|-InvokableCall<object, object>.add_Delegate
	*/

	[CompilerGeneratedAttribute] // RVA: 0x4528B0 Offset: 0x4529B1 VA: 0x4528B0
	// RVA: -1 Offset: -1
	protected void remove_Delegate(UnityAction<T1, T2> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D8B080 Offset: 0x2D8B181 VA: 0x2D8B080
	|-InvokableCall<object, object>.remove_Delegate
	*/

	// RVA: -1 Offset: -1
	public void .ctor(object target, MethodInfo theFunction) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D8B130 Offset: 0x2D8B231 VA: 0x2D8B130
	|-InvokableCall<object, object>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(UnityAction<T1, T2> action) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D8B240 Offset: 0x2D8B341 VA: 0x2D8B240
	|-InvokableCall<object, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public override void Invoke(object[] args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D8B290 Offset: 0x2D8B391 VA: 0x2D8B290
	|-InvokableCall<object, object>.Invoke
	*/

	// RVA: -1 Offset: -1
	public void Invoke(T1 args0, T2 args1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D8B460 Offset: 0x2D8B561 VA: 0x2D8B460
	|-InvokableCall<object, object>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public override bool Find(object targetObj, MethodInfo method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D8B4D0 Offset: 0x2D8B5D1 VA: 0x2D8B4D0
	|-InvokableCall<object, object>.Find
	*/
}

// Namespace: UnityEngine.Events
internal class InvokableCall<T1, T2, T3> : BaseInvokableCall // TypeDefIndex: 3687
{
	// Fields
	[DebuggerBrowsableAttribute] // RVA: 0x444140 Offset: 0x444241 VA: 0x444140
	[CompilerGeneratedAttribute] // RVA: 0x444140 Offset: 0x444241 VA: 0x444140
	private UnityAction<T1, T2, T3> Delegate; // 0x0

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x4528C0 Offset: 0x4529C1 VA: 0x4528C0
	// RVA: -1 Offset: -1
	protected void add_Delegate(UnityAction<T1, T2, T3> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D8B520 Offset: 0x2D8B621 VA: 0x2D8B520
	|-InvokableCall<object, int, int>.add_Delegate
	|
	|-RVA: 0x2D8BAF0 Offset: 0x2D8BBF1 VA: 0x2D8BAF0
	|-InvokableCall<object, object, object>.add_Delegate
	*/

	[CompilerGeneratedAttribute] // RVA: 0x4528D0 Offset: 0x4529D1 VA: 0x4528D0
	// RVA: -1 Offset: -1
	protected void remove_Delegate(UnityAction<T1, T2, T3> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D8B5D0 Offset: 0x2D8B6D1 VA: 0x2D8B5D0
	|-InvokableCall<object, int, int>.remove_Delegate
	|
	|-RVA: 0x2D8BBA0 Offset: 0x2D8BCA1 VA: 0x2D8BBA0
	|-InvokableCall<object, object, object>.remove_Delegate
	*/

	// RVA: -1 Offset: -1
	public void .ctor(object target, MethodInfo theFunction) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D8B680 Offset: 0x2D8B781 VA: 0x2D8B680
	|-InvokableCall<object, int, int>..ctor
	|
	|-RVA: 0x2D8BC50 Offset: 0x2D8BD51 VA: 0x2D8BC50
	|-InvokableCall<object, object, object>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(UnityAction<T1, T2, T3> action) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D8B790 Offset: 0x2D8B891 VA: 0x2D8B790
	|-InvokableCall<object, int, int>..ctor
	|
	|-RVA: 0x2D8BD60 Offset: 0x2D8BE61 VA: 0x2D8BD60
	|-InvokableCall<object, object, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public override void Invoke(object[] args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D8B7E0 Offset: 0x2D8B8E1 VA: 0x2D8B7E0
	|-InvokableCall<object, int, int>.Invoke
	|
	|-RVA: 0x2D8BDB0 Offset: 0x2D8BEB1 VA: 0x2D8BDB0
	|-InvokableCall<object, object, object>.Invoke
	*/

	// RVA: -1 Offset: -1
	public void Invoke(T1 args0, T2 args1, T3 args2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D8BA20 Offset: 0x2D8BB21 VA: 0x2D8BA20
	|-InvokableCall<object, int, int>.Invoke
	|
	|-RVA: 0x2D8BFF0 Offset: 0x2D8C0F1 VA: 0x2D8BFF0
	|-InvokableCall<object, object, object>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public override bool Find(object targetObj, MethodInfo method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D8BAA0 Offset: 0x2D8BBA1 VA: 0x2D8BAA0
	|-InvokableCall<object, int, int>.Find
	|
	|-RVA: 0x2D8C070 Offset: 0x2D8C171 VA: 0x2D8C070
	|-InvokableCall<object, object, object>.Find
	*/
}

// Namespace: UnityEngine.Events
internal class InvokableCall<T1, T2, T3, T4> : BaseInvokableCall // TypeDefIndex: 3688
{
	// Fields
	[DebuggerBrowsableAttribute] // RVA: 0x444180 Offset: 0x444281 VA: 0x444180
	[CompilerGeneratedAttribute] // RVA: 0x444180 Offset: 0x444281 VA: 0x444180
	private UnityAction<T1, T2, T3, T4> Delegate; // 0x0

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x4528E0 Offset: 0x4529E1 VA: 0x4528E0
	// RVA: -1 Offset: -1
	protected void add_Delegate(UnityAction<T1, T2, T3, T4> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D8C0C0 Offset: 0x2D8C1C1 VA: 0x2D8C0C0
	|-InvokableCall<object, object, object, object>.add_Delegate
	*/

	[CompilerGeneratedAttribute] // RVA: 0x4528F0 Offset: 0x4529F1 VA: 0x4528F0
	// RVA: -1 Offset: -1
	protected void remove_Delegate(UnityAction<T1, T2, T3, T4> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D8C170 Offset: 0x2D8C271 VA: 0x2D8C170
	|-InvokableCall<object, object, object, object>.remove_Delegate
	*/

	// RVA: -1 Offset: -1
	public void .ctor(object target, MethodInfo theFunction) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D8C220 Offset: 0x2D8C321 VA: 0x2D8C220
	|-InvokableCall<object, object, object, object>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(UnityAction<T1, T2, T3, T4> action) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D8C330 Offset: 0x2D8C431 VA: 0x2D8C330
	|-InvokableCall<object, object, object, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public override void Invoke(object[] args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D8C380 Offset: 0x2D8C481 VA: 0x2D8C380
	|-InvokableCall<object, object, object, object>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public override bool Find(object targetObj, MethodInfo method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D8C640 Offset: 0x2D8C741 VA: 0x2D8C640
	|-InvokableCall<object, object, object, object>.Find
	*/
}

