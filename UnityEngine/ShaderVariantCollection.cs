// Namespace: UnityEngine
public sealed class ShaderVariantCollection : Object // TypeDefIndex: 3630
{
	// Properties
	public int shaderCount { get; }
	public int variantCount { get; }
	public bool isWarmedUp { get; }

	// Methods

	// RVA: 0x31EAEA0 Offset: 0x31EAFA1 VA: 0x31EAEA0
	public int get_shaderCount() { }

	// RVA: 0x31EAEF0 Offset: 0x31EAFF1 VA: 0x31EAEF0
	public int get_variantCount() { }

	[NativeNameAttribute] // RVA: 0x450B00 Offset: 0x450C01 VA: 0x450B00
	// RVA: 0x31EAF40 Offset: 0x31EB041 VA: 0x31EAF40
	public bool get_isWarmedUp() { }

	// RVA: 0x31EAF90 Offset: 0x31EB091 VA: 0x31EAF90
	private bool AddVariant(Shader shader, PassType passType, string[] keywords) { }

	// RVA: 0x31EB000 Offset: 0x31EB101 VA: 0x31EB000
	private bool RemoveVariant(Shader shader, PassType passType, string[] keywords) { }

	// RVA: 0x31EB070 Offset: 0x31EB171 VA: 0x31EB070
	private bool ContainsVariant(Shader shader, PassType passType, string[] keywords) { }

	[NativeNameAttribute] // RVA: 0x450B40 Offset: 0x450C41 VA: 0x450B40
	// RVA: 0x31EB0E0 Offset: 0x31EB1E1 VA: 0x31EB0E0
	public void Clear() { }

	[NativeNameAttribute] // RVA: 0x450B80 Offset: 0x450C81 VA: 0x450B80
	// RVA: 0x31EB130 Offset: 0x31EB231 VA: 0x31EB130
	public void WarmUp() { }

	[NativeNameAttribute] // RVA: 0x450BC0 Offset: 0x450CC1 VA: 0x450BC0
	// RVA: 0x31EB180 Offset: 0x31EB281 VA: 0x31EB180
	private static void Internal_Create(ShaderVariantCollection svc) { }

	// RVA: 0x31EB1D0 Offset: 0x31EB2D1 VA: 0x31EB1D0
	public void .ctor() { }

	// RVA: 0x31EB270 Offset: 0x31EB371 VA: 0x31EB270
	public bool Add(ShaderVariantCollection.ShaderVariant variant) { }

	// RVA: 0x31EB2E0 Offset: 0x31EB3E1 VA: 0x31EB2E0
	public bool Remove(ShaderVariantCollection.ShaderVariant variant) { }

	// RVA: 0x31EB350 Offset: 0x31EB451 VA: 0x31EB350
	public bool Contains(ShaderVariantCollection.ShaderVariant variant) { }
}

