// Namespace: UnityEngine.UI
public static class StencilMaterial // TypeDefIndex: 4351
{
	// Fields
	private static List<StencilMaterial.MatEntry> m_List; // 0x0

	// Methods

	[EditorBrowsableAttribute] // RVA: 0x461D0 Offset: 0x462D1 VA: 0x461D0
	[ObsoleteAttribute] // RVA: 0x461D0 Offset: 0x462D1 VA: 0x461D0
	// RVA: 0x1BF5800 Offset: 0x1BF5901 VA: 0x1BF5800
	public static Material Add(Material baseMat, int stencilID) { }

	// RVA: 0x1BF5810 Offset: 0x1BF5911 VA: 0x1BF5810
	public static Material Add(Material baseMat, int stencilID, StencilOp operation, CompareFunction compareFunction, ColorWriteMask colorWriteMask) { }

	// RVA: 0x1BF58B0 Offset: 0x1BF59B1 VA: 0x1BF58B0
	public static Material Add(Material baseMat, int stencilID, StencilOp operation, CompareFunction compareFunction, ColorWriteMask colorWriteMask, int readMask, int writeMask) { }

	// RVA: 0x1BF62C0 Offset: 0x1BF63C1 VA: 0x1BF62C0
	public static void Remove(Material customMat) { }

	// RVA: 0x1BF64C0 Offset: 0x1BF65C1 VA: 0x1BF64C0
	public static void ClearAll() { }

	// RVA: 0x1BF6630 Offset: 0x1BF6731 VA: 0x1BF6630
	private static void .cctor() { }
}

