// Namespace: System.Reflection
[ComDefaultInterfaceAttribute] // RVA: 0x471E50 Offset: 0x471F51 VA: 0x471E50
[ClassInterfaceAttribute] // RVA: 0x471E50 Offset: 0x471F51 VA: 0x471E50
[ComVisibleAttribute] // RVA: 0x471E50 Offset: 0x471F51 VA: 0x471E50
[Serializable]
public abstract class MethodBase : MemberInfo, _MethodBase // TypeDefIndex: 537
{
	// Properties
	public abstract RuntimeMethodHandle MethodHandle { get; }
	public abstract MethodAttributes Attributes { get; }
	public virtual CallingConventions CallingConvention { get; }
	public virtual bool IsGenericMethodDefinition { get; }
	public virtual bool ContainsGenericParameters { get; }
	public virtual bool IsGenericMethod { get; }
	public virtual bool IsSecurityCritical { get; }
	public bool IsPublic { get; }
	public bool IsPrivate { get; }
	public bool IsFamily { get; }
	public bool IsAssembly { get; }
	public bool IsFamilyAndAssembly { get; }
	public bool IsFamilyOrAssembly { get; }
	public bool IsStatic { get; }
	public bool IsVirtual { get; }
	public bool IsAbstract { get; }
	public bool IsSpecialName { get; }
	[ComVisibleAttribute] // RVA: 0x47DD90 Offset: 0x47DE91 VA: 0x47DD90
	public bool IsConstructor { get; }

	// Methods

	// RVA: 0x34ECBB0 Offset: 0x34ECCB1 VA: 0x34ECBB0
	public static MethodBase GetMethodFromHandle(RuntimeMethodHandle handle) { }

	// RVA: 0x34ECE00 Offset: 0x34ECF01 VA: 0x34ECE00
	protected void .ctor() { }

	// RVA: 0x34E7C20 Offset: 0x34E7D21 VA: 0x34E7C20
	public static bool op_Equality(MethodBase left, MethodBase right) { }

	// RVA: 0x34E7C00 Offset: 0x34E7D01 VA: 0x34E7C00
	public static bool op_Inequality(MethodBase left, MethodBase right) { }

	// RVA: 0x34ECEF0 Offset: 0x34ECFF1 VA: 0x34ECEF0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x34ECF00 Offset: 0x34ED001 VA: 0x34ECF00 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x34ECF10 Offset: 0x34ED011 VA: 0x34ECF10 Slot: 16
	internal virtual ParameterInfo[] GetParametersNoCopy() { }

	// RVA: -1 Offset: -1 Slot: 17
	public abstract ParameterInfo[] GetParameters();

	// RVA: -1 Offset: -1 Slot: 18
	public abstract MethodImplAttributes GetMethodImplementationFlags();

	// RVA: -1 Offset: -1 Slot: 19
	public abstract RuntimeMethodHandle get_MethodHandle();

	// RVA: -1 Offset: -1 Slot: 20
	public abstract MethodAttributes get_Attributes();

	// RVA: -1 Offset: -1 Slot: 21
	public abstract object Invoke(object obj, BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture);

	// RVA: 0x34ECF20 Offset: 0x34ED021 VA: 0x34ECF20 Slot: 22
	public virtual CallingConventions get_CallingConvention() { }

	[ComVisibleAttribute] // RVA: 0x47BCD0 Offset: 0x47BDD1 VA: 0x47BCD0
	// RVA: 0x34ECF30 Offset: 0x34ED031 VA: 0x34ECF30 Slot: 23
	public virtual Type[] GetGenericArguments() { }

	// RVA: 0x34ECF90 Offset: 0x34ED091 VA: 0x34ECF90 Slot: 24
	public virtual bool get_IsGenericMethodDefinition() { }

	// RVA: 0x34ECFA0 Offset: 0x34ED0A1 VA: 0x34ECFA0 Slot: 25
	public virtual bool get_ContainsGenericParameters() { }

	// RVA: 0x34ECFB0 Offset: 0x34ED0B1 VA: 0x34ECFB0 Slot: 26
	public virtual bool get_IsGenericMethod() { }

	// RVA: 0x34ECFC0 Offset: 0x34ED0C1 VA: 0x34ECFC0 Slot: 27
	public virtual bool get_IsSecurityCritical() { }

	[DebuggerHiddenAttribute] // RVA: 0x47BCF0 Offset: 0x47BDF1 VA: 0x47BCF0
	[DebuggerStepThroughAttribute] // RVA: 0x47BCF0 Offset: 0x47BDF1 VA: 0x47BCF0
	// RVA: 0x34ED000 Offset: 0x34ED101 VA: 0x34ED000 Slot: 28
	public object Invoke(object obj, object[] parameters) { }

	// RVA: 0x34ED020 Offset: 0x34ED121 VA: 0x34ED020 Slot: 29
	public bool get_IsPublic() { }

	// RVA: 0x34ED050 Offset: 0x34ED151 VA: 0x34ED050 Slot: 30
	public bool get_IsPrivate() { }

	// RVA: 0x34ED080 Offset: 0x34ED181 VA: 0x34ED080 Slot: 31
	public bool get_IsFamily() { }

	// RVA: 0x34ED0B0 Offset: 0x34ED1B1 VA: 0x34ED0B0 Slot: 32
	public bool get_IsAssembly() { }

	// RVA: 0x34ED0E0 Offset: 0x34ED1E1 VA: 0x34ED0E0 Slot: 33
	public bool get_IsFamilyAndAssembly() { }

	// RVA: 0x34ED110 Offset: 0x34ED211 VA: 0x34ED110 Slot: 34
	public bool get_IsFamilyOrAssembly() { }

	// RVA: 0x34ED140 Offset: 0x34ED241 VA: 0x34ED140 Slot: 35
	public bool get_IsStatic() { }

	// RVA: 0x34ED170 Offset: 0x34ED271 VA: 0x34ED170 Slot: 36
	public bool get_IsVirtual() { }

	// RVA: 0x34ED1A0 Offset: 0x34ED2A1 VA: 0x34ED1A0 Slot: 37
	public bool get_IsAbstract() { }

	// RVA: 0x34ED1D0 Offset: 0x34ED2D1 VA: 0x34ED1D0 Slot: 38
	public bool get_IsSpecialName() { }

	// RVA: 0x34ED200 Offset: 0x34ED301 VA: 0x34ED200 Slot: 39
	public bool get_IsConstructor() { }

	// RVA: 0x34ED2B0 Offset: 0x34ED3B1 VA: 0x34ED2B0
	internal static string ConstructParameters(Type[] parameterTypes, CallingConventions callingConvention, bool serialization) { }

	// RVA: 0x34ED520 Offset: 0x34ED621 VA: 0x34ED520 Slot: 40
	internal virtual string FormatNameAndSig(bool serialization) { }

	// RVA: 0x34ED650 Offset: 0x34ED751 VA: 0x34ED650 Slot: 41
	internal virtual Type[] GetParameterTypes() { }

	// RVA: 0x34ED780 Offset: 0x34ED881 VA: 0x34ED780 Slot: 42
	internal virtual ParameterInfo[] GetParametersInternal() { }

	// RVA: 0x34ED790 Offset: 0x34ED891 VA: 0x34ED790 Slot: 43
	internal virtual int GetParametersCount() { }

	// RVA: 0x34ED7C0 Offset: 0x34ED8C1 VA: 0x34ED7C0
	internal static MethodBase GetMethodFromHandleNoGenericCheck(RuntimeMethodHandle handle) { }

	// RVA: 0x34ED820 Offset: 0x34ED921 VA: 0x34ED820
	internal static MethodBase GetMethodFromHandleNoGenericCheck(RuntimeMethodHandle handle, RuntimeTypeHandle reflectedType) { }

	// RVA: 0x34ECDF0 Offset: 0x34ECEF1 VA: 0x34ECDF0
	private static MethodBase GetMethodFromHandleInternalType(IntPtr method_handle, IntPtr type_handle) { }

	// RVA: 0x34ED810 Offset: 0x34ED911 VA: 0x34ED810
	internal static MethodBase GetMethodFromHandleInternalType_native(IntPtr method_handle, IntPtr type_handle, bool genericCheck) { }
}

