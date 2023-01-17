// Namespace: Mono
[DefaultMemberAttribute] // RVA: 0x46F5C0 Offset: 0x46F6C1 VA: 0x46F5C0
internal struct RuntimeGPtrArrayHandle // TypeDefIndex: 9
{
	// Fields
	private RuntimeStructs.GPtrArray* value; // 0x0

	// Properties
	internal int Length { get; }
	internal IntPtr Item { get; }

	// Methods

	// RVA: 0x322CBE0 Offset: 0x322CCE1 VA: 0x322CBE0
	internal void .ctor(IntPtr ptr) { }

	// RVA: 0x322CC10 Offset: 0x322CD11 VA: 0x322CC10
	internal int get_Length() { }

	// RVA: 0x322CC20 Offset: 0x322CD21 VA: 0x322CC20
	internal IntPtr get_Item(int i) { }

	// RVA: 0x322CC90 Offset: 0x322CD91 VA: 0x322CC90
	internal IntPtr Lookup(int i) { }

	// RVA: 0x322CD00 Offset: 0x322CE01 VA: 0x322CD00
	private static void GPtrArrayFree(RuntimeStructs.GPtrArray* value) { }

	// RVA: 0x322CD10 Offset: 0x322CE11 VA: 0x322CD10
	internal static void DestroyAndFree(ref RuntimeGPtrArrayHandle h) { }
}

