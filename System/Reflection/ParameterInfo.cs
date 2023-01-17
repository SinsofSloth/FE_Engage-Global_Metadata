// Namespace: System.Reflection
[ClassInterfaceAttribute] // RVA: 0x472800 Offset: 0x472901 VA: 0x472800
[ComVisibleAttribute] // RVA: 0x472800 Offset: 0x472901 VA: 0x472800
[ComDefaultInterfaceAttribute] // RVA: 0x472800 Offset: 0x472901 VA: 0x472800
[Serializable]
public class ParameterInfo : ICustomAttributeProvider, IObjectReference, _ParameterInfo // TypeDefIndex: 594
{
	// Fields
	protected Type ClassImpl; // 0x10
	protected object DefaultValueImpl; // 0x18
	protected MemberInfo MemberImpl; // 0x20
	protected string NameImpl; // 0x28
	protected int PositionImpl; // 0x30
	protected ParameterAttributes AttrsImpl; // 0x34
	internal MarshalAsAttribute marshalAs; // 0x38

	// Properties
	public virtual Type ParameterType { get; }
	public virtual ParameterAttributes Attributes { get; }
	public bool IsIn { get; }
	public bool IsOptional { get; }
	public bool IsOut { get; }
	public bool IsRetval { get; }
	public virtual string Name { get; }
	public virtual int Position { get; }
	public virtual object DefaultValue { get; }

	// Methods

	// RVA: 0x3817CB0 Offset: 0x3817DB1 VA: 0x3817CB0
	protected void .ctor() { }

	// RVA: 0x3817CC0 Offset: 0x3817DC1 VA: 0x3817CC0 Slot: 3
	public override string ToString() { }

	// RVA: 0x3817EA0 Offset: 0x3817FA1 VA: 0x3817EA0
	internal static void FormatParameters(StringBuilder sb, ParameterInfo[] p, CallingConventions callingConvention, bool serialization) { }

	// RVA: 0x3818120 Offset: 0x3818221 VA: 0x3818120 Slot: 7
	public virtual Type get_ParameterType() { }

	// RVA: 0x3818130 Offset: 0x3818231 VA: 0x3818130 Slot: 8
	public virtual ParameterAttributes get_Attributes() { }

	// RVA: 0x3818140 Offset: 0x3818241 VA: 0x3818140
	public bool get_IsIn() { }

	// RVA: 0x3818160 Offset: 0x3818261 VA: 0x3818160
	public bool get_IsOptional() { }

	// RVA: 0x3818180 Offset: 0x3818281 VA: 0x3818180
	public bool get_IsOut() { }

	// RVA: 0x3817E80 Offset: 0x3817F81 VA: 0x3817E80
	public bool get_IsRetval() { }

	// RVA: 0x38181A0 Offset: 0x38182A1 VA: 0x38181A0 Slot: 9
	public virtual string get_Name() { }

	// RVA: 0x38181B0 Offset: 0x38182B1 VA: 0x38181B0 Slot: 10
	public virtual int get_Position() { }

	// RVA: 0x38181C0 Offset: 0x38182C1 VA: 0x38181C0
	internal object[] GetPseudoCustomAttributes() { }

	// RVA: 0x3818450 Offset: 0x3818551 VA: 0x3818450
	internal object GetDefaultValueImpl() { }

	// RVA: 0x3818460 Offset: 0x3818561 VA: 0x3818460 Slot: 11
	public virtual object get_DefaultValue() { }

	// RVA: 0x38184A0 Offset: 0x38185A1 VA: 0x38184A0 Slot: 12
	public virtual object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x38184F0 Offset: 0x38185F1 VA: 0x38184F0 Slot: 6
	public object GetRealObject(StreamingContext context) { }

	// RVA: 0x3818530 Offset: 0x3818631 VA: 0x3818530 Slot: 13
	public virtual bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x3818540 Offset: 0x3818641 VA: 0x3818540
	internal static ParameterInfo New(ParameterInfo pinfo, MemberInfo member) { }
}

