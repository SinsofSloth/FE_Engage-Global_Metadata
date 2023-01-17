// Namespace: System.Reflection
[ComVisibleAttribute] // RVA: 0x471CB0 Offset: 0x471DB1 VA: 0x471CB0
public class ManifestResourceInfo // TypeDefIndex: 529
{
	// Fields
	private Assembly _containingAssembly; // 0x10
	private string _containingFileName; // 0x18
	private ResourceLocation _resourceLocation; // 0x20

	// Properties
	public virtual Assembly ReferencedAssembly { get; }
	public virtual string FileName { get; }
	public virtual ResourceLocation ResourceLocation { get; }

	// Methods

	// RVA: 0x34E3320 Offset: 0x34E3421 VA: 0x34E3320
	public void .ctor(Assembly containingAssembly, string containingFileName, ResourceLocation resourceLocation) { }

	// RVA: 0x34E3380 Offset: 0x34E3481 VA: 0x34E3380 Slot: 4
	public virtual Assembly get_ReferencedAssembly() { }

	// RVA: 0x34E3390 Offset: 0x34E3491 VA: 0x34E3390 Slot: 5
	public virtual string get_FileName() { }

	// RVA: 0x34E33A0 Offset: 0x34E34A1 VA: 0x34E33A0 Slot: 6
	public virtual ResourceLocation get_ResourceLocation() { }
}

