// Namespace: System.Threading
internal static class PlatformHelper // TypeDefIndex: 748
{
	// Fields
	private static int s_processorCount; // 0x0
	private static int s_lastProcessorCountRefreshTicks; // 0x4

	// Properties
	internal static int ProcessorCount { get; }
	internal static bool IsSingleProcessor { get; }

	// Methods

	// RVA: 0x38219A0 Offset: 0x3821AA1 VA: 0x38219A0
	internal static int get_ProcessorCount() { }

	// RVA: 0x3821A60 Offset: 0x3821B61 VA: 0x3821A60
	internal static bool get_IsSingleProcessor() { }
}

