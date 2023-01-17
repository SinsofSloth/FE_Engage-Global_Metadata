// Namespace: MoonSharp.Interpreter.Interop
public class StandardGenericsUserDataDescriptor : IUserDataDescriptor, IGeneratorUserDataDescriptor // TypeDefIndex: 6125
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0xE920 Offset: 0xEA21 VA: 0xE920
	private InteropAccessMode <AccessMode>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0xE930 Offset: 0xEA31 VA: 0xE930
	private string <Name>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0xE940 Offset: 0xEA41 VA: 0xE940
	private Type <Type>k__BackingField; // 0x20

	// Properties
	public InteropAccessMode AccessMode { get; set; }
	public string Name { get; set; }
	public Type Type { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x10AA0 Offset: 0x10BA1 VA: 0x10AA0
	// RVA: 0x3024140 Offset: 0x3024241 VA: 0x3024140
	public InteropAccessMode get_AccessMode() { }

	[CompilerGeneratedAttribute] // RVA: 0x10AB0 Offset: 0x10BB1 VA: 0x10AB0
	// RVA: 0x3024150 Offset: 0x3024251 VA: 0x3024150
	private void set_AccessMode(InteropAccessMode value) { }

	// RVA: 0x3024160 Offset: 0x3024261 VA: 0x3024160
	public void .ctor(Type type, InteropAccessMode accessMode) { }

	[CompilerGeneratedAttribute] // RVA: 0x10AC0 Offset: 0x10BC1 VA: 0x10AC0
	// RVA: 0x3024260 Offset: 0x3024361 VA: 0x3024260 Slot: 4
	public string get_Name() { }

	[CompilerGeneratedAttribute] // RVA: 0x10AD0 Offset: 0x10BD1 VA: 0x10AD0
	// RVA: 0x3024270 Offset: 0x3024371 VA: 0x3024270
	private void set_Name(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x10AE0 Offset: 0x10BE1 VA: 0x10AE0
	// RVA: 0x3024280 Offset: 0x3024381 VA: 0x3024280 Slot: 5
	public Type get_Type() { }

	[CompilerGeneratedAttribute] // RVA: 0x10AF0 Offset: 0x10BF1 VA: 0x10AF0
	// RVA: 0x3024290 Offset: 0x3024391 VA: 0x3024290
	private void set_Type(Type value) { }

	// RVA: 0x30242A0 Offset: 0x30243A1 VA: 0x30242A0 Slot: 6
	public DynValue Index(Script script, object obj, DynValue index, bool isDirectIndexing) { }

	// RVA: 0x30242B0 Offset: 0x30243B1 VA: 0x30242B0 Slot: 7
	public bool SetIndex(Script script, object obj, DynValue index, DynValue value, bool isDirectIndexing) { }

	// RVA: 0x30242C0 Offset: 0x30243C1 VA: 0x30242C0 Slot: 8
	public string AsString(object obj) { }

	// RVA: 0x30242D0 Offset: 0x30243D1 VA: 0x30242D0 Slot: 9
	public DynValue MetaIndex(Script script, object obj, string metaname) { }

	// RVA: 0x30242E0 Offset: 0x30243E1 VA: 0x30242E0 Slot: 10
	public bool IsTypeCompatible(Type type, object obj) { }

	// RVA: 0x30243D0 Offset: 0x30244D1 VA: 0x30243D0 Slot: 11
	public IUserDataDescriptor Generate(Type type) { }
}

