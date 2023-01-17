// Namespace: System
internal class TypeSpec // TypeDefIndex: 417
{
	// Fields
	private TypeIdentifier name; // 0x10
	private string assembly_name; // 0x18
	private List<TypeIdentifier> nested; // 0x20
	private List<TypeSpec> generic_params; // 0x28
	private List<ModifierSpec> modifier_spec; // 0x30
	private bool is_byref; // 0x38
	private string display_fullname; // 0x40

	// Properties
	internal bool HasModifiers { get; }
	internal string DisplayFullName { get; }

	// Methods

	// RVA: 0x3644500 Offset: 0x3644601 VA: 0x3644500
	internal bool get_HasModifiers() { }

	// RVA: 0x3644510 Offset: 0x3644611 VA: 0x3644510
	private string GetDisplayFullName(TypeSpec.DisplayNameFormat flags) { }

	// RVA: 0x3644AD0 Offset: 0x3644BD1 VA: 0x3644AD0
	private StringBuilder GetModifierString(StringBuilder sb) { }

	// RVA: 0x3644A70 Offset: 0x3644B71 VA: 0x3644A70
	internal string get_DisplayFullName() { }

	// RVA: 0x3643B30 Offset: 0x3643C31 VA: 0x3643B30
	internal static TypeSpec Parse(string typeName) { }

	// RVA: 0x3645A80 Offset: 0x3645B81 VA: 0x3645A80
	internal static string UnescapeInternalName(string displayName) { }

	// RVA: 0x3643C10 Offset: 0x3643D11 VA: 0x3643C10
	internal Type Resolve(Func<AssemblyName, Assembly> assemblyResolver, Func<Assembly, string, bool, Type> typeResolver, bool throwOnError, bool ignoreCase) { }

	// RVA: 0x3645B70 Offset: 0x3645C71 VA: 0x3645B70
	private void AddName(string type_name) { }

	// RVA: 0x3645D50 Offset: 0x3645E51 VA: 0x3645D50
	private void AddModifier(ModifierSpec md) { }

	// RVA: 0x3645E00 Offset: 0x3645F01 VA: 0x3645E00
	private static void SkipSpace(string name, ref int pos) { }

	// RVA: 0x3645EC0 Offset: 0x3645FC1 VA: 0x3645EC0
	private static void BoundCheck(int idx, string s) { }

	// RVA: 0x3645CE0 Offset: 0x3645DE1 VA: 0x3645CE0
	private static TypeIdentifier ParsedTypeIdentifier(string displayName) { }

	// RVA: 0x3644C70 Offset: 0x3644D71 VA: 0x3644C70
	private static TypeSpec Parse(string name, ref int p, bool is_recurse, bool allow_aqn) { }

	// RVA: 0x3645F40 Offset: 0x3646041 VA: 0x3645F40
	public void .ctor() { }
}

