// Namespace: UnityEngine.Profiling.Memory.Experimental
[NativeHeaderAttribute] // RVA: 0x43F750 Offset: 0x43F851 VA: 0x43F750
public sealed class MemoryProfiler // TypeDefIndex: 3672
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x443E20 Offset: 0x443F21 VA: 0x443E20
	[DebuggerBrowsableAttribute] // RVA: 0x443E20 Offset: 0x443F21 VA: 0x443E20
	private static Action<string, bool> m_SnapshotFinished; // 0x0
	[DebuggerBrowsableAttribute] // RVA: 0x443E60 Offset: 0x443F61 VA: 0x443E60
	[CompilerGeneratedAttribute] // RVA: 0x443E60 Offset: 0x443F61 VA: 0x443E60
	private static Action<string, bool, DebugScreenCapture> m_SaveScreenshotToDisk; // 0x8
	[DebuggerBrowsableAttribute] // RVA: 0x443EA0 Offset: 0x443FA1 VA: 0x443EA0
	[CompilerGeneratedAttribute] // RVA: 0x443EA0 Offset: 0x443FA1 VA: 0x443EA0
	private static Action<MetaData> createMetaData; // 0x10

	// Methods

	[RequiredByNativeCodeAttribute] // RVA: 0x452500 Offset: 0x452601 VA: 0x452500
	// RVA: 0x3480DA0 Offset: 0x3480EA1 VA: 0x3480DA0
	private static byte[] PrepareMetadata() { }

	// RVA: 0x3481020 Offset: 0x3481121 VA: 0x3481020
	internal static int WriteIntToByteArray(byte[] array, int offset, int value) { }

	// RVA: 0x34810C0 Offset: 0x34811C1 VA: 0x34810C0
	internal static int WriteStringToByteArray(byte[] array, int offset, string value) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x452510 Offset: 0x452611 VA: 0x452510
	// RVA: 0x3481170 Offset: 0x3481271 VA: 0x3481170
	private static void FinalizeSnapshot(string path, bool result) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x452520 Offset: 0x452621 VA: 0x452520
	// RVA: 0x3481210 Offset: 0x3481311 VA: 0x3481210
	private static void SaveScreenshotToDisk(string path, bool result, IntPtr pixelsPtr, int pixelsCount, TextureFormat format, int width, int height) { }
}

