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

