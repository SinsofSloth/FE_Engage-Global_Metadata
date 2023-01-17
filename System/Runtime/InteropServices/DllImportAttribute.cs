// Namespace: System.Runtime.InteropServices
[AttributeUsageAttribute] // RVA: 0x475F70 Offset: 0x476071 VA: 0x475F70
[ComVisibleAttribute] // RVA: 0x475F70 Offset: 0x476071 VA: 0x475F70
public sealed class DllImportAttribute : Attribute // TypeDefIndex: 1301
{
	// Fields
	internal string _val; // 0x10
	public string EntryPoint; // 0x18
	public CharSet CharSet; // 0x20
	public bool SetLastError; // 0x24
	public bool ExactSpelling; // 0x25
	public bool PreserveSig; // 0x26
	public CallingConvention CallingConvention; // 0x28
	public bool BestFitMapping; // 0x2C
	public bool ThrowOnUnmappableChar; // 0x2D

	// Properties
	public string Value { get; }

	// Methods

	// RVA: 0x372A2C0 Offset: 0x372A3C1 VA: 0x372A2C0
	internal static Attribute GetCustomAttribute(RuntimeMethodInfo method) { }

	// RVA: 0x372A590 Offset: 0x372A691 VA: 0x372A590
	internal static bool IsDefined(RuntimeMethodInfo method) { }

	// RVA: 0x372A4D0 Offset: 0x372A5D1 VA: 0x372A4D0
	internal void .ctor(string dllName, string entryPoint, CharSet charSet, bool exactSpelling, bool setLastError, bool preserveSig, CallingConvention callingConvention, bool bestFitMapping, bool throwOnUnmappableChar) { }

	// RVA: 0x372A5C0 Offset: 0x372A6C1 VA: 0x372A5C0
	public void .ctor(string dllName) { }

	// RVA: 0x372A600 Offset: 0x372A701 VA: 0x372A600
	public string get_Value() { }
}

