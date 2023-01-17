// Namespace: UnityEngine.Rendering
[UsedByNativeCodeAttribute] // RVA: 0x440AB0 Offset: 0x440BB1 VA: 0x440AB0
[NativeHeaderAttribute] // RVA: 0x440AB0 Offset: 0x440BB1 VA: 0x440AB0
[ExtensionAttribute] // RVA: 0x440AB0 Offset: 0x440BB1 VA: 0x440AB0
public static class CommandBufferExtensions // TypeDefIndex: 3921
{
	// Methods

	[FreeFunctionAttribute] // RVA: 0x453F20 Offset: 0x454021 VA: 0x453F20
	// RVA: 0x2F1A7B0 Offset: 0x2F1A8B1 VA: 0x2F1A7B0
	private static void Internal_SwitchIntoFastMemory(CommandBuffer cmd, ref RenderTargetIdentifier rt, FastMemoryFlags fastMemoryFlags, float residency, bool copyContents) { }

	[FreeFunctionAttribute] // RVA: 0x453F60 Offset: 0x454061 VA: 0x453F60
	// RVA: 0x2F1A830 Offset: 0x2F1A931 VA: 0x2F1A830
	private static void Internal_SwitchOutOfFastMemory(CommandBuffer cmd, ref RenderTargetIdentifier rt, bool copyContents) { }

	[ExtensionAttribute] // RVA: 0x453FA0 Offset: 0x4540A1 VA: 0x453FA0
	[NativeConditionalAttribute] // RVA: 0x453FA0 Offset: 0x4540A1 VA: 0x453FA0
	// RVA: 0x2F1A890 Offset: 0x2F1A991 VA: 0x2F1A890
	public static void SwitchIntoFastMemory(CommandBuffer cmd, RenderTargetIdentifier rid, FastMemoryFlags fastMemoryFlags, float residency, bool copyContents) { }

	[ExtensionAttribute] // RVA: 0x453FF0 Offset: 0x4540F1 VA: 0x453FF0
	[NativeConditionalAttribute] // RVA: 0x453FF0 Offset: 0x4540F1 VA: 0x453FF0
	// RVA: 0x2F1A910 Offset: 0x2F1AA11 VA: 0x2F1A910
	public static void SwitchOutOfFastMemory(CommandBuffer cmd, RenderTargetIdentifier rid, bool copyContents) { }
}

