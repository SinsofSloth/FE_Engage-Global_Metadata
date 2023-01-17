// Namespace: UnityEngine.Profiling
[NativeHeaderAttribute] // RVA: 0x43F670 Offset: 0x43F771 VA: 0x43F670
[NativeHeaderAttribute] // RVA: 0x43F670 Offset: 0x43F771 VA: 0x43F670
[UsedByNativeCodeAttribute] // RVA: 0x43F670 Offset: 0x43F771 VA: 0x43F670
public class Sampler // TypeDefIndex: 3668
{
	// Fields
	internal IntPtr m_Ptr; // 0x10
	internal static Sampler s_InvalidSampler; // 0x0

	// Properties
	public bool isValid { get; }

	// Methods

	// RVA: 0x31E17F0 Offset: 0x31E18F1 VA: 0x31E17F0
	internal void .ctor() { }

	// RVA: 0x31E1800 Offset: 0x31E1901 VA: 0x31E1800
	public bool get_isValid() { }

	// RVA: 0x31E1850 Offset: 0x31E1951 VA: 0x31E1850
	public Recorder GetRecorder() { }

	[NativeMethodAttribute] // RVA: 0x452410 Offset: 0x452511 VA: 0x452410
	// RVA: 0x31E1960 Offset: 0x31E1A61 VA: 0x31E1960
	private static IntPtr GetRecorderInternal(IntPtr ptr) { }

	// RVA: 0x31E19B0 Offset: 0x31E1AB1 VA: 0x31E19B0
	private static void .cctor() { }
}

