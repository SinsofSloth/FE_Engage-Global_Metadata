// Namespace: UnityEngine.Experimental.Rendering.RenderGraphModule
[DebuggerDisplayAttribute] // RVA: 0x3B340 Offset: 0x3B441 VA: 0x3B340
public struct TextureHandle // TypeDefIndex: 4499
{
	// Fields
	private static TextureHandle s_NullHandle; // 0x0
	internal ResourceHandle handle; // 0x0

	// Properties
	public static TextureHandle nullHandle { get; }

	// Methods

	// RVA: 0x3547340 Offset: 0x3547441 VA: 0x3547340
	public static TextureHandle get_nullHandle() { }

	// RVA: 0x3542CC0 Offset: 0x3542DC1 VA: 0x3542CC0
	internal void .ctor(int handle) { }

	// RVA: 0x35473B0 Offset: 0x35474B1 VA: 0x35473B0
	public static RTHandle op_Implicit(TextureHandle texture) { }

	// RVA: 0x35475A0 Offset: 0x35476A1 VA: 0x35475A0
	public static RenderTargetIdentifier op_Implicit(TextureHandle texture) { }

	// RVA: 0x35477B0 Offset: 0x35478B1 VA: 0x35477B0
	public static RenderTexture op_Implicit(TextureHandle texture) { }

	// RVA: 0x3541A80 Offset: 0x3541B81 VA: 0x3541A80
	public bool IsValid() { }

	// RVA: 0x35479A0 Offset: 0x3547AA1 VA: 0x35479A0
	private static void .cctor() { }
}

