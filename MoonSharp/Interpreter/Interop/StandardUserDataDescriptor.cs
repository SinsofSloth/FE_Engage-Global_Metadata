// Namespace: MoonSharp.Interpreter.Interop
public class StandardUserDataDescriptor : DispatchingUserDataDescriptor, IWireableDescriptor // TypeDefIndex: 6127
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0xE950 Offset: 0xEA51 VA: 0xE950
	private InteropAccessMode <AccessMode>k__BackingField; // 0x40

	// Properties
	public InteropAccessMode AccessMode { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x10B00 Offset: 0x10C01 VA: 0x10B00
	// RVA: 0x3024E50 Offset: 0x3024F51 VA: 0x3024E50
	public InteropAccessMode get_AccessMode() { }

	[CompilerGeneratedAttribute] // RVA: 0x10B10 Offset: 0x10C11 VA: 0x10B10
	// RVA: 0x3024E60 Offset: 0x3024F61 VA: 0x3024E60
	private void set_AccessMode(InteropAccessMode value) { }

	// RVA: 0x3024E70 Offset: 0x3024F71 VA: 0x3024E70
	public void .ctor(Type type, InteropAccessMode accessMode, string friendlyName) { }

	// RVA: 0x3025070 Offset: 0x3025171 VA: 0x3025070
	private void FillMemberList() { }

	// RVA: 0x30264B0 Offset: 0x30265B1 VA: 0x30264B0 Slot: 20
	public void PrepareForWiring(Table t) { }

	// RVA: 0x30267D0 Offset: 0x30268D1 VA: 0x30267D0
	private void Serialize(Table t, IEnumerable<KeyValuePair<string, IMemberDescriptor>> members) { }
}

