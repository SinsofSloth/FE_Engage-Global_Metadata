// Namespace: UnityEngine
public class ResourcesAPI // TypeDefIndex: 3568
{
	// Fields
	private static ResourcesAPI s_DefaultAPI; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x443810 Offset: 0x443911 VA: 0x443810
	[DebuggerBrowsableAttribute] // RVA: 0x443810 Offset: 0x443911 VA: 0x443810
	private static ResourcesAPI <overrideAPI>k__BackingField; // 0x8

	// Properties
	internal static ResourcesAPI ActiveAPI { get; }
	public static ResourcesAPI overrideAPI { get; }

	// Methods

	// RVA: 0x31E0F80 Offset: 0x31E1081 VA: 0x31E0F80
	internal static ResourcesAPI get_ActiveAPI() { }

	[CompilerGeneratedAttribute] // RVA: 0x44ED60 Offset: 0x44EE61 VA: 0x44ED60
	// RVA: 0x31E12A0 Offset: 0x31E13A1 VA: 0x31E12A0
	public static ResourcesAPI get_overrideAPI() { }

	// RVA: 0x31E1310 Offset: 0x31E1411 VA: 0x31E1310
	protected internal void .ctor() { }

	// RVA: 0x31E1320 Offset: 0x31E1421 VA: 0x31E1320 Slot: 4
	protected internal virtual Object[] FindObjectsOfTypeAll(Type systemTypeInstance) { }

	// RVA: 0x31E13C0 Offset: 0x31E14C1 VA: 0x31E13C0 Slot: 5
	protected internal virtual Shader FindShaderByName(string name) { }

	// RVA: 0x31E1460 Offset: 0x31E1561 VA: 0x31E1460 Slot: 6
	protected internal virtual Object Load(string path, Type systemTypeInstance) { }

	// RVA: 0x31E1500 Offset: 0x31E1601 VA: 0x31E1500 Slot: 7
	protected internal virtual Object[] LoadAll(string path, Type systemTypeInstance) { }

	// RVA: 0x31E15A0 Offset: 0x31E16A1 VA: 0x31E15A0 Slot: 8
	protected internal virtual ResourceRequest LoadAsync(string path, Type systemTypeInstance) { }

	// RVA: 0x31E1670 Offset: 0x31E1771 VA: 0x31E1670 Slot: 9
	protected internal virtual void UnloadAsset(Object assetToUnload) { }

	// RVA: 0x31E1710 Offset: 0x31E1811 VA: 0x31E1710
	private static void .cctor() { }
}

