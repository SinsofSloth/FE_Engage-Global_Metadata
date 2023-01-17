// Namespace: UnityEngine.Profiling
[NativeHeaderAttribute] // RVA: 0x43F600 Offset: 0x43F701 VA: 0x43F600
[NativeHeaderAttribute] // RVA: 0x43F600 Offset: 0x43F701 VA: 0x43F600
[UsedByNativeCodeAttribute] // RVA: 0x43F600 Offset: 0x43F701 VA: 0x43F600
public sealed class Recorder // TypeDefIndex: 3667
{
	// Fields
	internal IntPtr m_Ptr; // 0x10
	internal static Recorder s_InvalidRecorder; // 0x0

	// Properties
	public bool isValid { get; }
	public bool enabled { get; set; }
	public long elapsedNanoseconds { get; }
	public long gpuElapsedNanoseconds { get; }
	public int sampleBlockCount { get; }
	public int gpuSampleBlockCount { get; }

	// Methods

	// RVA: 0x31D2370 Offset: 0x31D2471 VA: 0x31D2370
	internal void .ctor() { }

	// RVA: 0x31D2380 Offset: 0x31D2481 VA: 0x31D2380
	internal void .ctor(IntPtr ptr) { }

	// RVA: 0x31D23B0 Offset: 0x31D24B1 VA: 0x31D23B0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x31D2500 Offset: 0x31D2601 VA: 0x31D2500
	public bool get_isValid() { }

	[NativeMethodAttribute] // RVA: 0x452240 Offset: 0x452341 VA: 0x452240
	// RVA: 0x31D24B0 Offset: 0x31D25B1 VA: 0x31D24B0
	private static void DisposeNative(IntPtr ptr) { }

	// RVA: 0x31D2550 Offset: 0x31D2651 VA: 0x31D2550
	public bool get_enabled() { }

	// RVA: 0x31D2640 Offset: 0x31D2741 VA: 0x31D2640
	public void set_enabled(bool value) { }

	[NativeMethodAttribute] // RVA: 0x452290 Offset: 0x452391 VA: 0x452290
	// RVA: 0x31D25F0 Offset: 0x31D26F1 VA: 0x31D25F0
	private bool IsEnabled() { }

	[NativeMethodAttribute] // RVA: 0x4522D0 Offset: 0x4523D1 VA: 0x4522D0
	// RVA: 0x31D26E0 Offset: 0x31D27E1 VA: 0x31D26E0
	private void SetEnabled(bool enabled) { }

	// RVA: 0x31D2730 Offset: 0x31D2831 VA: 0x31D2730
	public long get_elapsedNanoseconds() { }

	// RVA: 0x31D2820 Offset: 0x31D2921 VA: 0x31D2820
	public long get_gpuElapsedNanoseconds() { }

	[NativeMethodAttribute] // RVA: 0x452310 Offset: 0x452411 VA: 0x452310
	// RVA: 0x31D27D0 Offset: 0x31D28D1 VA: 0x31D27D0
	private long GetElapsedNanoseconds() { }

	[NativeMethodAttribute] // RVA: 0x452350 Offset: 0x452451 VA: 0x452350
	// RVA: 0x31D28C0 Offset: 0x31D29C1 VA: 0x31D28C0
	private long GetGpuElapsedNanoseconds() { }

	// RVA: 0x31D2910 Offset: 0x31D2A11 VA: 0x31D2910
	public int get_sampleBlockCount() { }

	// RVA: 0x31D2A00 Offset: 0x31D2B01 VA: 0x31D2A00
	public int get_gpuSampleBlockCount() { }

	[NativeMethodAttribute] // RVA: 0x452390 Offset: 0x452491 VA: 0x452390
	// RVA: 0x31D29B0 Offset: 0x31D2AB1 VA: 0x31D29B0
	private int GetSampleBlockCount() { }

	[NativeMethodAttribute] // RVA: 0x4523D0 Offset: 0x4524D1 VA: 0x4523D0
	// RVA: 0x31D2AA0 Offset: 0x31D2BA1 VA: 0x31D2AA0
	private int GetGpuSampleBlockCount() { }

	// RVA: 0x31D2AF0 Offset: 0x31D2BF1 VA: 0x31D2AF0
	private static void .cctor() { }
}

