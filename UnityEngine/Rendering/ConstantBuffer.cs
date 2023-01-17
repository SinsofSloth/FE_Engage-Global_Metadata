// Namespace: UnityEngine.Rendering
public class ConstantBuffer // TypeDefIndex: 4514
{
	// Fields
	private static List<ConstantBuffer.ConstantBufferBase> m_RegisteredConstantBuffers; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public static void PushGlobal<CBType>(CommandBuffer cmd, in CBType data, int shaderId) { }

	// RVA: -1 Offset: -1
	public static void Push<CBType>(CommandBuffer cmd, in CBType data, ComputeShader cs, int shaderId) { }

	// RVA: -1 Offset: -1
	public static void Push<CBType>(CommandBuffer cmd, in CBType data, Material mat, int shaderId) { }

	// RVA: -1 Offset: -1
	public static void UpdateData<CBType>(CommandBuffer cmd, in CBType data) { }

	// RVA: -1 Offset: -1
	public static void SetGlobal<CBType>(CommandBuffer cmd, int shaderId) { }

	// RVA: -1 Offset: -1
	public static void Set<CBType>(CommandBuffer cmd, ComputeShader cs, int shaderId) { }

	// RVA: -1 Offset: -1
	public static void Set<CBType>(Material mat, int shaderId) { }

	// RVA: 0x1B2D350 Offset: 0x1B2D451 VA: 0x1B2D350
	public static void ReleaseAll() { }

	// RVA: 0x1B2D4E0 Offset: 0x1B2D5E1 VA: 0x1B2D4E0
	internal static void Register(ConstantBuffer.ConstantBufferBase cb) { }

	// RVA: 0x1B2D570 Offset: 0x1B2D671 VA: 0x1B2D570
	public void .ctor() { }

	// RVA: 0x1B2D580 Offset: 0x1B2D681 VA: 0x1B2D580
	private static void .cctor() { }
}

