// Namespace: MoonSharp.Interpreter.Interop
public sealed class ProxyUserDataDescriptor : IUserDataDescriptor // TypeDefIndex: 6090
{
	// Fields
	private IUserDataDescriptor m_ProxyDescriptor; // 0x10
	private IProxyFactory m_ProxyFactory; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0xE790 Offset: 0xE891 VA: 0xE790
	private string <Name>k__BackingField; // 0x20

	// Properties
	public IUserDataDescriptor InnerDescriptor { get; }
	public string Name { get; set; }
	public Type Type { get; }

	// Methods

	// RVA: 0x30127A0 Offset: 0x30128A1 VA: 0x30127A0
	internal void .ctor(IProxyFactory proxyFactory, IUserDataDescriptor proxyDescriptor, string friendlyName) { }

	// RVA: 0x30128D0 Offset: 0x30129D1 VA: 0x30128D0
	public IUserDataDescriptor get_InnerDescriptor() { }

	[CompilerGeneratedAttribute] // RVA: 0x10780 Offset: 0x10881 VA: 0x10780
	// RVA: 0x30128E0 Offset: 0x30129E1 VA: 0x30128E0 Slot: 4
	public string get_Name() { }

	[CompilerGeneratedAttribute] // RVA: 0x10790 Offset: 0x10891 VA: 0x10790
	// RVA: 0x30128F0 Offset: 0x30129F1 VA: 0x30128F0
	private void set_Name(string value) { }

	// RVA: 0x3012900 Offset: 0x3012A01 VA: 0x3012900 Slot: 5
	public Type get_Type() { }

	// RVA: 0x30129B0 Offset: 0x3012AB1 VA: 0x30129B0
	private object Proxy(object obj) { }

	// RVA: 0x3012A80 Offset: 0x3012B81 VA: 0x3012A80 Slot: 6
	public DynValue Index(Script script, object obj, DynValue index, bool isDirectIndexing) { }

	// RVA: 0x3012C20 Offset: 0x3012D21 VA: 0x3012C20 Slot: 7
	public bool SetIndex(Script script, object obj, DynValue index, DynValue value, bool isDirectIndexing) { }

	// RVA: 0x3012DC0 Offset: 0x3012EC1 VA: 0x3012DC0 Slot: 8
	public string AsString(object obj) { }

	// RVA: 0x3012F30 Offset: 0x3013031 VA: 0x3012F30 Slot: 9
	public DynValue MetaIndex(Script script, object obj, string metaname) { }

	// RVA: 0x30130C0 Offset: 0x30131C1 VA: 0x30130C0 Slot: 10
	public bool IsTypeCompatible(Type type, object obj) { }
}

