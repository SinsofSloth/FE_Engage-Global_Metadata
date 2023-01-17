// Namespace: System.Reflection
[ComDefaultInterfaceAttribute] // RVA: 0x4725B0 Offset: 0x4726B1 VA: 0x4725B0
[ClassInterfaceAttribute] // RVA: 0x4725B0 Offset: 0x4726B1 VA: 0x4725B0
[ComVisibleAttribute] // RVA: 0x4725B0 Offset: 0x4726B1 VA: 0x4725B0
[Serializable]
public abstract class Module : ISerializable, ICustomAttributeProvider, _Module // TypeDefIndex: 569
{
	// Fields
	public static readonly TypeFilter FilterTypeName; // 0x0
	public static readonly TypeFilter FilterTypeNameIgnoreCase; // 0x8
	internal IntPtr _impl; // 0x10
	internal Assembly assembly; // 0x18
	internal string fqname; // 0x20
	internal string name; // 0x28
	internal string scopename; // 0x30
	internal bool is_resource; // 0x38
	internal int token; // 0x3C
	private const BindingFlags defaultBindingFlags = 28;

	// Properties
	public virtual Assembly Assembly { get; }
	public virtual string ScopeName { get; }
	public virtual Guid ModuleVersionId { get; }

	// Methods

	// RVA: 0x34F2850 Offset: 0x34F2951 VA: 0x34F2850
	protected void .ctor() { }

	// RVA: 0x34F2860 Offset: 0x34F2961 VA: 0x34F2860 Slot: 7
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x34F28A0 Offset: 0x34F29A1 VA: 0x34F28A0 Slot: 3
	public override string ToString() { }

	// RVA: 0x34F28B0 Offset: 0x34F29B1 VA: 0x34F28B0 Slot: 8
	internal virtual Guid GetModuleVersionId() { }

	// RVA: 0x34F2900 Offset: 0x34F2A01 VA: 0x34F2900
	private static bool filter_by_type_name(Type m, object filterCriteria) { }

	// RVA: 0x34F29F0 Offset: 0x34F2AF1 VA: 0x34F29F0
	private static bool filter_by_type_name_ignore_case(Type m, object filterCriteria) { }

	// RVA: 0x34F28F0 Offset: 0x34F29F1 VA: 0x34F28F0
	private string GetGuidInternal() { }

	// RVA: 0x34F2B00 Offset: 0x34F2C01 VA: 0x34F2B00 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x34F2B10 Offset: 0x34F2C11 VA: 0x34F2B10 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x34F2B20 Offset: 0x34F2C21 VA: 0x34F2B20
	public static bool op_Equality(Module left, Module right) { }

	// RVA: 0x34F2B60 Offset: 0x34F2C61 VA: 0x34F2B60 Slot: 9
	public virtual Assembly get_Assembly() { }

	// RVA: 0x34F2C50 Offset: 0x34F2D51 VA: 0x34F2C50 Slot: 10
	public virtual string get_ScopeName() { }

	// RVA: 0x34F2CC0 Offset: 0x34F2DC1 VA: 0x34F2CC0 Slot: 11
	public virtual Guid get_ModuleVersionId() { }

	// RVA: 0x34F2BD0 Offset: 0x34F2CD1 VA: 0x34F2BD0
	private static Exception CreateNIE() { }

	// RVA: 0x34F2D30 Offset: 0x34F2E31 VA: 0x34F2D30 Slot: 12
	public virtual bool IsResource() { }

	// RVA: 0x34F2DA0 Offset: 0x34F2EA1 VA: 0x34F2DA0 Slot: 13
	public virtual object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x34F2E10 Offset: 0x34F2F11 VA: 0x34F2E10 Slot: 14
	public virtual bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x34F2E80 Offset: 0x34F2F81 VA: 0x34F2E80
	private static void .cctor() { }
}

