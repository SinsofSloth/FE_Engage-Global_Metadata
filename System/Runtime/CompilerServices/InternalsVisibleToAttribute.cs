// Namespace: System.Runtime.CompilerServices
[AttributeUsageAttribute] // RVA: 0x475970 Offset: 0x475A71 VA: 0x475970
public sealed class InternalsVisibleToAttribute : Attribute // TypeDefIndex: 1272
{
	// Fields
	private string _assemblyName; // 0x10
	private bool _allInternalsVisible; // 0x18

	// Properties
	public string AssemblyName { get; }
	public bool AllInternalsVisible { get; set; }

	// Methods

	// RVA: 0x3412E60 Offset: 0x3412F61 VA: 0x3412E60
	public void .ctor(string assemblyName) { }

	// RVA: 0x3412EA0 Offset: 0x3412FA1 VA: 0x3412EA0
	public string get_AssemblyName() { }

	// RVA: 0x3412EB0 Offset: 0x3412FB1 VA: 0x3412EB0
	public bool get_AllInternalsVisible() { }

	// RVA: 0x3412EC0 Offset: 0x3412FC1 VA: 0x3412EC0
	public void set_AllInternalsVisible(bool value) { }
}

