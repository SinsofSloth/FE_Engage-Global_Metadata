// Namespace: MoonSharp.Interpreter.Interop
public class PropertyMemberDescriptor : IMemberDescriptor, IOptimizableDescriptor, IWireableDescriptor // TypeDefIndex: 6119
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0xE880 Offset: 0xE981 VA: 0xE880
	private PropertyInfo <PropertyInfo>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0xE890 Offset: 0xE991 VA: 0xE890
	private InteropAccessMode <AccessMode>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0xE8A0 Offset: 0xE9A1 VA: 0xE8A0
	private bool <IsStatic>k__BackingField; // 0x1C
	[CompilerGeneratedAttribute] // RVA: 0xE8B0 Offset: 0xE9B1 VA: 0xE8B0
	private string <Name>k__BackingField; // 0x20
	private MethodInfo m_Getter; // 0x28
	private MethodInfo m_Setter; // 0x30
	private Func<object, object> m_OptimizedGetter; // 0x38
	private Action<object, object> m_OptimizedSetter; // 0x40

	// Properties
	public PropertyInfo PropertyInfo { get; set; }
	public InteropAccessMode AccessMode { get; set; }
	public bool IsStatic { get; set; }
	public string Name { get; set; }
	public bool CanRead { get; }
	public bool CanWrite { get; }
	public MemberDescriptorAccess MemberAccess { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x10960 Offset: 0x10A61 VA: 0x10960
	// RVA: 0x300D810 Offset: 0x300D911 VA: 0x300D810
	public PropertyInfo get_PropertyInfo() { }

	[CompilerGeneratedAttribute] // RVA: 0x10970 Offset: 0x10A71 VA: 0x10970
	// RVA: 0x300D820 Offset: 0x300D921 VA: 0x300D820
	private void set_PropertyInfo(PropertyInfo value) { }

	[CompilerGeneratedAttribute] // RVA: 0x10980 Offset: 0x10A81 VA: 0x10980
	// RVA: 0x300D830 Offset: 0x300D931 VA: 0x300D830
	public InteropAccessMode get_AccessMode() { }

	[CompilerGeneratedAttribute] // RVA: 0x10990 Offset: 0x10A91 VA: 0x10990
	// RVA: 0x300D840 Offset: 0x300D941 VA: 0x300D840
	private void set_AccessMode(InteropAccessMode value) { }

	[CompilerGeneratedAttribute] // RVA: 0x109A0 Offset: 0x10AA1 VA: 0x109A0
	// RVA: 0x300D850 Offset: 0x300D951 VA: 0x300D850 Slot: 4
	public bool get_IsStatic() { }

	[CompilerGeneratedAttribute] // RVA: 0x109B0 Offset: 0x10AB1 VA: 0x109B0
	// RVA: 0x300D860 Offset: 0x300D961 VA: 0x300D860
	private void set_IsStatic(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x109C0 Offset: 0x10AC1 VA: 0x109C0
	// RVA: 0x300D870 Offset: 0x300D971 VA: 0x300D870 Slot: 5
	public string get_Name() { }

	[CompilerGeneratedAttribute] // RVA: 0x109D0 Offset: 0x10AD1 VA: 0x109D0
	// RVA: 0x300D880 Offset: 0x300D981 VA: 0x300D880
	private void set_Name(string value) { }

	// RVA: 0x300D890 Offset: 0x300D991 VA: 0x300D890
	public bool get_CanRead() { }

	// RVA: 0x300D8A0 Offset: 0x300D9A1 VA: 0x300D8A0
	public bool get_CanWrite() { }

	// RVA: 0x300D8B0 Offset: 0x300D9B1 VA: 0x300D8B0
	public static PropertyMemberDescriptor TryCreateIfVisible(PropertyInfo pi, InteropAccessMode accessMode) { }

	// RVA: 0x300DBA0 Offset: 0x300DCA1 VA: 0x300DBA0
	private static PropertyMemberDescriptor TryCreate(PropertyInfo pi, InteropAccessMode accessMode, MethodInfo getter, MethodInfo setter) { }

	// RVA: 0x300DEF0 Offset: 0x300DFF1 VA: 0x300DEF0
	public void .ctor(PropertyInfo pi, InteropAccessMode accessMode) { }

	// RVA: 0x300DC60 Offset: 0x300DD61 VA: 0x300DC60
	public void .ctor(PropertyInfo pi, InteropAccessMode accessMode, MethodInfo getter, MethodInfo setter) { }

	// RVA: 0x300ECC0 Offset: 0x300EDC1 VA: 0x300ECC0 Slot: 7
	public DynValue GetValue(Script script, object obj) { }

	// RVA: 0x300E060 Offset: 0x300E161 VA: 0x300E060
	internal void OptimizeGetter() { }

	// RVA: 0x300E520 Offset: 0x300E621 VA: 0x300E520
	internal void OptimizeSetter() { }

	// RVA: 0x300EE70 Offset: 0x300EF71 VA: 0x300EE70 Slot: 8
	public void SetValue(Script script, object obj, DynValue v) { }

	// RVA: 0x300FE60 Offset: 0x300FF61 VA: 0x300FE60 Slot: 6
	public MemberDescriptorAccess get_MemberAccess() { }

	// RVA: 0x300FEB0 Offset: 0x300FFB1 VA: 0x300FEB0 Slot: 9
	private void MoonSharp.Interpreter.Interop.BasicDescriptors.IOptimizableDescriptor.Optimize() { }

	// RVA: 0x300FEE0 Offset: 0x300FFE1 VA: 0x300FEE0 Slot: 10
	public void PrepareForWiring(Table t) { }
}

