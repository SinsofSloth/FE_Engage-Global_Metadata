// Namespace: System
[ClassInterfaceAttribute] // RVA: 0x471010 Offset: 0x471111 VA: 0x471010
[ComVisibleAttribute] // RVA: 0x471010 Offset: 0x471111 VA: 0x471010
[Serializable]
public abstract class Delegate : ICloneable, ISerializable // TypeDefIndex: 358
{
	// Fields
	private IntPtr method_ptr; // 0x10
	private IntPtr invoke_impl; // 0x18
	private object m_target; // 0x20
	private IntPtr method; // 0x28
	private IntPtr delegate_trampoline; // 0x30
	private IntPtr extra_arg; // 0x38
	private IntPtr method_code; // 0x40
	private MethodInfo method_info; // 0x48
	private MethodInfo original_method_info; // 0x50
	private DelegateData data; // 0x58
	private bool method_is_virtual; // 0x60

	// Properties
	public MethodInfo Method { get; }
	public object Target { get; }

	// Methods

	// RVA: 0x3725650 Offset: 0x3725751 VA: 0x3725650
	public MethodInfo get_Method() { }

	// RVA: 0x3725660 Offset: 0x3725761 VA: 0x3725660
	private MethodInfo GetVirtualMethod_internal() { }

	// RVA: 0x3725670 Offset: 0x3725771 VA: 0x3725670
	public object get_Target() { }

	// RVA: 0x3725680 Offset: 0x3725781 VA: 0x3725680
	internal static Delegate CreateDelegate_internal(Type type, object target, MethodInfo info, bool throwOnBindFailure) { }

	// RVA: 0x3725690 Offset: 0x3725791 VA: 0x3725690
	private static bool arg_type_match(Type delArgType, Type argType) { }

	// RVA: 0x3725850 Offset: 0x3725951 VA: 0x3725850
	private static bool arg_type_match_this(Type delArgType, Type argType, bool boxedThis) { }

	// RVA: 0x37259C0 Offset: 0x3725AC1 VA: 0x37259C0
	private static bool return_type_match(Type delReturnType, Type returnType) { }

	// RVA: 0x3725C00 Offset: 0x3725D01 VA: 0x3725C00
	public static Delegate CreateDelegate(Type type, object firstArgument, MethodInfo method, bool throwOnBindFailure) { }

	// RVA: 0x3725C10 Offset: 0x3725D11 VA: 0x3725C10
	private static Delegate CreateDelegate(Type type, object firstArgument, MethodInfo method, bool throwOnBindFailure, bool allowClosed) { }

	// RVA: 0x3726400 Offset: 0x3726501 VA: 0x3726400
	public static Delegate CreateDelegate(Type type, object firstArgument, MethodInfo method) { }

	// RVA: 0x3726410 Offset: 0x3726511 VA: 0x3726410
	public static Delegate CreateDelegate(Type type, MethodInfo method, bool throwOnBindFailure) { }

	// RVA: 0x3726430 Offset: 0x3726531 VA: 0x3726430
	public static Delegate CreateDelegate(Type type, MethodInfo method) { }

	// RVA: 0x3726450 Offset: 0x3726551 VA: 0x3726450
	public static Delegate CreateDelegate(Type type, object target, string method) { }

	// RVA: 0x3726470 Offset: 0x3726571 VA: 0x3726470
	private static MethodInfo GetCandidateMethod(Type type, Type target, string method, BindingFlags bflags, bool ignoreCase, bool throwOnBindFailure) { }

	// RVA: 0x37268D0 Offset: 0x37269D1 VA: 0x37268D0
	public static Delegate CreateDelegate(Type type, Type target, string method, bool ignoreCase, bool throwOnBindFailure) { }

	// RVA: 0x3726A10 Offset: 0x3726B11 VA: 0x3726A10
	public static Delegate CreateDelegate(Type type, Type target, string method) { }

	// RVA: 0x3726A20 Offset: 0x3726B21 VA: 0x3726A20
	public static Delegate CreateDelegate(Type type, object target, string method, bool ignoreCase, bool throwOnBindFailure) { }

	// RVA: 0x3726460 Offset: 0x3726561 VA: 0x3726460
	public static Delegate CreateDelegate(Type type, object target, string method, bool ignoreCase) { }

	// RVA: 0x3726B10 Offset: 0x3726C11 VA: 0x3726B10
	public object DynamicInvoke(object[] args) { }

	// RVA: 0x3726B20 Offset: 0x3726C21 VA: 0x3726B20
	private void InitializeDelegateData() { }

	// RVA: 0x3726C10 Offset: 0x3726D11 VA: 0x3726C10 Slot: 6
	protected virtual object DynamicInvokeImpl(object[] args) { }

	// RVA: 0x3726F10 Offset: 0x3727011 VA: 0x3726F10 Slot: 7
	public virtual object Clone() { }

	// RVA: 0x3726F20 Offset: 0x3727021 VA: 0x3726F20 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x37270F0 Offset: 0x37271F1 VA: 0x37270F0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x3727170 Offset: 0x3727271 VA: 0x3727170 Slot: 8
	protected virtual MethodInfo GetMethodImpl() { }

	// RVA: 0x3727270 Offset: 0x3727371 VA: 0x3727270 Slot: 9
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x37274F0 Offset: 0x37275F1 VA: 0x37274F0 Slot: 10
	public virtual Delegate[] GetInvocationList() { }

	// RVA: 0x37275A0 Offset: 0x37276A1 VA: 0x37275A0
	public static Delegate Combine(Delegate a, Delegate b) { }

	[ComVisibleAttribute] // RVA: 0x47AF90 Offset: 0x47B091 VA: 0x47AF90
	// RVA: 0x3727750 Offset: 0x3727851 VA: 0x3727750
	public static Delegate Combine(Delegate[] delegates) { }

	// RVA: 0x37277E0 Offset: 0x37278E1 VA: 0x37277E0 Slot: 11
	protected virtual Delegate CombineImpl(Delegate d) { }

	// RVA: 0x3727840 Offset: 0x3727941 VA: 0x3727840
	public static Delegate Remove(Delegate source, Delegate value) { }

	// RVA: 0x37279F0 Offset: 0x3727AF1 VA: 0x37279F0 Slot: 12
	protected virtual Delegate RemoveImpl(Delegate d) { }

	// RVA: 0x3727A20 Offset: 0x3727B21 VA: 0x3727A20
	public static bool op_Equality(Delegate d1, Delegate d2) { }

	// RVA: 0x3727A50 Offset: 0x3727B51 VA: 0x3727A50
	internal static Delegate CreateDelegateNoSecurityCheck(RuntimeType type, object firstArgument, MethodInfo method) { }

	// RVA: 0x3727A60 Offset: 0x3727B61 VA: 0x3727A60
	internal static MulticastDelegate AllocDelegateLike_internal(Delegate d) { }
}

