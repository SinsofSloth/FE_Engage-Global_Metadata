// Namespace: UnityEngine.Rendering
public static class CommandBufferPool // TypeDefIndex: 4509
{
	// Fields
	private static ObjectPool<CommandBuffer> s_BufferPool; // 0x0

	// Methods

	// RVA: 0x1B2CA50 Offset: 0x1B2CB51 VA: 0x1B2CA50
	public static CommandBuffer Get() { }

	// RVA: 0x1B2CB00 Offset: 0x1B2CC01 VA: 0x1B2CB00
	public static CommandBuffer Get(string name) { }

	// RVA: 0x1B2CBA0 Offset: 0x1B2CCA1 VA: 0x1B2CBA0
	public static void Release(CommandBuffer buffer) { }

	// RVA: 0x1B2CC30 Offset: 0x1B2CD31 VA: 0x1B2CC30
	private static void .cctor() { }
}

