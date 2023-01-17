// Namespace: MoonSharp.Interpreter.Interop.StandardDescriptors.HardwiredDescriptors
public abstract class HardwiredMemberDescriptor : IMemberDescriptor // TypeDefIndex: 6139
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0xE970 Offset: 0xEA71 VA: 0xE970
	private Type <MemberType>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0xE980 Offset: 0xEA81 VA: 0xE980
	private bool <IsStatic>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0xE990 Offset: 0xEA91 VA: 0xE990
	private string <Name>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0xE9A0 Offset: 0xEAA1 VA: 0xE9A0
	private MemberDescriptorAccess <MemberAccess>k__BackingField; // 0x28

	// Properties
	public Type MemberType { get; set; }
	public bool IsStatic { get; set; }
	public string Name { get; set; }
	public MemberDescriptorAccess MemberAccess { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x10B60 Offset: 0x10C61 VA: 0x10B60
	// RVA: 0x3316210 Offset: 0x3316311 VA: 0x3316210
	public Type get_MemberType() { }

	[CompilerGeneratedAttribute] // RVA: 0x10B70 Offset: 0x10C71 VA: 0x10B70
	// RVA: 0x3316220 Offset: 0x3316321 VA: 0x3316220
	private void set_MemberType(Type value) { }

	// RVA: 0x3316230 Offset: 0x3316331 VA: 0x3316230
	protected void .ctor(Type memberType, string name, bool isStatic, MemberDescriptorAccess access) { }

	[CompilerGeneratedAttribute] // RVA: 0x10B80 Offset: 0x10C81 VA: 0x10B80
	// RVA: 0x33162A0 Offset: 0x33163A1 VA: 0x33162A0 Slot: 4
	public bool get_IsStatic() { }

	[CompilerGeneratedAttribute] // RVA: 0x10B90 Offset: 0x10C91 VA: 0x10B90
	// RVA: 0x33162B0 Offset: 0x33163B1 VA: 0x33162B0
	private void set_IsStatic(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x10BA0 Offset: 0x10CA1 VA: 0x10BA0
	// RVA: 0x33162C0 Offset: 0x33163C1 VA: 0x33162C0 Slot: 5
	public string get_Name() { }

	[CompilerGeneratedAttribute] // RVA: 0x10BB0 Offset: 0x10CB1 VA: 0x10BB0
	// RVA: 0x33162D0 Offset: 0x33163D1 VA: 0x33162D0
	private void set_Name(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x10BC0 Offset: 0x10CC1 VA: 0x10BC0
	// RVA: 0x33162E0 Offset: 0x33163E1 VA: 0x33162E0 Slot: 6
	public MemberDescriptorAccess get_MemberAccess() { }

	[CompilerGeneratedAttribute] // RVA: 0x10BD0 Offset: 0x10CD1 VA: 0x10BD0
	// RVA: 0x33162F0 Offset: 0x33163F1 VA: 0x33162F0
	private void set_MemberAccess(MemberDescriptorAccess value) { }

	// RVA: 0x3316300 Offset: 0x3316401 VA: 0x3316300 Slot: 7
	public DynValue GetValue(Script script, object obj) { }

	// RVA: 0x3316360 Offset: 0x3316461 VA: 0x3316360 Slot: 8
	public void SetValue(Script script, object obj, DynValue value) { }

	// RVA: 0x33163D0 Offset: 0x33164D1 VA: 0x33163D0 Slot: 9
	protected virtual object GetValueImpl(Script script, object obj) { }

	// RVA: 0x3316440 Offset: 0x3316541 VA: 0x3316440 Slot: 10
	protected virtual void SetValueImpl(Script script, object obj, object value) { }
}

