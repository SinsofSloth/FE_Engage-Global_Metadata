// Namespace: MoonSharp.Interpreter.Interop
public class DynValueMemberDescriptor : IMemberDescriptor, IWireableDescriptor // TypeDefIndex: 6084
{
	// Fields
	private DynValue m_Value; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0xE700 Offset: 0xE801 VA: 0xE700
	private string <Name>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0xE710 Offset: 0xE811 VA: 0xE710
	private MemberDescriptorAccess <MemberAccess>k__BackingField; // 0x20

	// Properties
	public bool IsStatic { get; }
	public string Name { get; set; }
	public MemberDescriptorAccess MemberAccess { get; set; }
	public virtual DynValue Value { get; }

	// Methods

	// RVA: 0x3304B70 Offset: 0x3304C71 VA: 0x3304B70
	protected void .ctor(string name, string serializedTableValue) { }

	// RVA: 0x3304D10 Offset: 0x3304E11 VA: 0x3304D10
	protected void .ctor(string name) { }

	// RVA: 0x3304D60 Offset: 0x3304E61 VA: 0x3304D60
	public void .ctor(string name, DynValue value) { }

	// RVA: 0x3304DD0 Offset: 0x3304ED1 VA: 0x3304DD0 Slot: 4
	public bool get_IsStatic() { }

	[CompilerGeneratedAttribute] // RVA: 0x10660 Offset: 0x10761 VA: 0x10660
	// RVA: 0x3304DE0 Offset: 0x3304EE1 VA: 0x3304DE0 Slot: 5
	public string get_Name() { }

	[CompilerGeneratedAttribute] // RVA: 0x10670 Offset: 0x10771 VA: 0x10670
	// RVA: 0x3304DF0 Offset: 0x3304EF1 VA: 0x3304DF0
	private void set_Name(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x10680 Offset: 0x10781 VA: 0x10680
	// RVA: 0x3304E00 Offset: 0x3304F01 VA: 0x3304E00 Slot: 6
	public MemberDescriptorAccess get_MemberAccess() { }

	[CompilerGeneratedAttribute] // RVA: 0x10690 Offset: 0x10791 VA: 0x10690
	// RVA: 0x3304E10 Offset: 0x3304F11 VA: 0x3304E10
	private void set_MemberAccess(MemberDescriptorAccess value) { }

	// RVA: 0x3304E20 Offset: 0x3304F21 VA: 0x3304E20 Slot: 10
	public virtual DynValue get_Value() { }

	// RVA: 0x3304E30 Offset: 0x3304F31 VA: 0x3304E30 Slot: 7
	public DynValue GetValue(Script script, object obj) { }

	// RVA: 0x3304E40 Offset: 0x3304F41 VA: 0x3304E40 Slot: 8
	public void SetValue(Script script, object obj, DynValue value) { }

	// RVA: 0x3304ED0 Offset: 0x3304FD1 VA: 0x3304ED0 Slot: 9
	public void PrepareForWiring(Table t) { }
}

