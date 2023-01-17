// Namespace: MoonSharp.Interpreter.Interop
public class FieldMemberDescriptor : IMemberDescriptor, IOptimizableDescriptor, IWireableDescriptor // TypeDefIndex: 6111
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0xE7C0 Offset: 0xE8C1 VA: 0xE7C0
	private FieldInfo <FieldInfo>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0xE7D0 Offset: 0xE8D1 VA: 0xE7D0
	private InteropAccessMode <AccessMode>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0xE7E0 Offset: 0xE8E1 VA: 0xE7E0
	private bool <IsStatic>k__BackingField; // 0x1C
	[CompilerGeneratedAttribute] // RVA: 0xE7F0 Offset: 0xE8F1 VA: 0xE7F0
	private string <Name>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0xE800 Offset: 0xE901 VA: 0xE800
	private bool <IsConst>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0xE810 Offset: 0xE911 VA: 0xE810
	private bool <IsReadonly>k__BackingField; // 0x29
	private object m_ConstValue; // 0x30
	private Func<object, object> m_OptimizedGetter; // 0x38

	// Properties
	public FieldInfo FieldInfo { get; set; }
	public InteropAccessMode AccessMode { get; set; }
	public bool IsStatic { get; set; }
	public string Name { get; set; }
	public bool IsConst { get; set; }
	public bool IsReadonly { get; set; }
	public MemberDescriptorAccess MemberAccess { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x107E0 Offset: 0x108E1 VA: 0x107E0
	// RVA: 0x330EB10 Offset: 0x330EC11 VA: 0x330EB10
	public FieldInfo get_FieldInfo() { }

	[CompilerGeneratedAttribute] // RVA: 0x107F0 Offset: 0x108F1 VA: 0x107F0
	// RVA: 0x330EB20 Offset: 0x330EC21 VA: 0x330EB20
	private void set_FieldInfo(FieldInfo value) { }

	[CompilerGeneratedAttribute] // RVA: 0x10800 Offset: 0x10901 VA: 0x10800
	// RVA: 0x330EB30 Offset: 0x330EC31 VA: 0x330EB30
	public InteropAccessMode get_AccessMode() { }

	[CompilerGeneratedAttribute] // RVA: 0x10810 Offset: 0x10911 VA: 0x10810
	// RVA: 0x330EB40 Offset: 0x330EC41 VA: 0x330EB40
	private void set_AccessMode(InteropAccessMode value) { }

	[CompilerGeneratedAttribute] // RVA: 0x10820 Offset: 0x10921 VA: 0x10820
	// RVA: 0x330EB50 Offset: 0x330EC51 VA: 0x330EB50 Slot: 4
	public bool get_IsStatic() { }

	[CompilerGeneratedAttribute] // RVA: 0x10830 Offset: 0x10931 VA: 0x10830
	// RVA: 0x330EB60 Offset: 0x330EC61 VA: 0x330EB60
	private void set_IsStatic(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x10840 Offset: 0x10941 VA: 0x10840
	// RVA: 0x330EB70 Offset: 0x330EC71 VA: 0x330EB70 Slot: 5
	public string get_Name() { }

	[CompilerGeneratedAttribute] // RVA: 0x10850 Offset: 0x10951 VA: 0x10850
	// RVA: 0x330EB80 Offset: 0x330EC81 VA: 0x330EB80
	private void set_Name(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x10860 Offset: 0x10961 VA: 0x10860
	// RVA: 0x330EB90 Offset: 0x330EC91 VA: 0x330EB90
	public bool get_IsConst() { }

	[CompilerGeneratedAttribute] // RVA: 0x10870 Offset: 0x10971 VA: 0x10870
	// RVA: 0x330EBA0 Offset: 0x330ECA1 VA: 0x330EBA0
	private void set_IsConst(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x10880 Offset: 0x10981 VA: 0x10880
	// RVA: 0x330EBB0 Offset: 0x330ECB1 VA: 0x330EBB0
	public bool get_IsReadonly() { }

	[CompilerGeneratedAttribute] // RVA: 0x10890 Offset: 0x10991 VA: 0x10890
	// RVA: 0x330EBC0 Offset: 0x330ECC1 VA: 0x330EBC0
	private void set_IsReadonly(bool value) { }

	// RVA: 0x330EBD0 Offset: 0x330ECD1 VA: 0x330EBD0
	public static FieldMemberDescriptor TryCreateIfVisible(FieldInfo fi, InteropAccessMode accessMode) { }

	// RVA: 0x330ECA0 Offset: 0x330EDA1 VA: 0x330ECA0
	public void .ctor(FieldInfo fi, InteropAccessMode accessMode) { }

	// RVA: 0x330F380 Offset: 0x330F481 VA: 0x330F380 Slot: 7
	public DynValue GetValue(Script script, object obj) { }

	// RVA: 0x330EED0 Offset: 0x330EFD1 VA: 0x330EED0
	internal void OptimizeGetter() { }

	// RVA: 0x330F460 Offset: 0x330F561 VA: 0x330F460 Slot: 8
	public void SetValue(Script script, object obj, DynValue v) { }

	// RVA: 0x330F7A0 Offset: 0x330F8A1 VA: 0x330F7A0 Slot: 6
	public MemberDescriptorAccess get_MemberAccess() { }

	// RVA: 0x330F7D0 Offset: 0x330F8D1 VA: 0x330F7D0 Slot: 9
	private void MoonSharp.Interpreter.Interop.BasicDescriptors.IOptimizableDescriptor.Optimize() { }

	// RVA: 0x330F7E0 Offset: 0x330F8E1 VA: 0x330F7E0 Slot: 10
	public void PrepareForWiring(Table t) { }
}

