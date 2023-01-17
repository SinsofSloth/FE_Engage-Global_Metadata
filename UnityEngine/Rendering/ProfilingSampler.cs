// Namespace: UnityEngine.Rendering
public class ProfilingSampler // TypeDefIndex: 4589
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x3CC10 Offset: 0x3CD11 VA: 0x3CC10
	private CustomSampler <sampler>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x3CC20 Offset: 0x3CD21 VA: 0x3CC20
	private CustomSampler <inlineSampler>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x3CC30 Offset: 0x3CD31 VA: 0x3CC30
	private string <name>k__BackingField; // 0x20
	private Recorder m_Recorder; // 0x28
	private Recorder m_InlineRecorder; // 0x30

	// Properties
	internal CustomSampler sampler { get; set; }
	internal CustomSampler inlineSampler { get; set; }
	public string name { get; set; }
	public bool enableRecording { set; }
	public float gpuElapsedTime { get; }
	public int gpuSampleCount { get; }
	public float cpuElapsedTime { get; }
	public int cpuSampleCount { get; }
	public float inlineCpuElapsedTime { get; }
	public int inlineCpuSampleCount { get; }

	// Methods

	// RVA: -1 Offset: -1
	public static ProfilingSampler Get<TEnum>(TEnum marker) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2012950 Offset: 0x2012A51 VA: 0x2012950
	|-ProfilingSampler.Get<Int32Enum>
	|-ProfilingSampler.Get<RenderGraphProfileId>
	|-ProfilingSampler.Get<URPProfileId>
	|
	|-RVA: 0x2012A30 Offset: 0x2012B31 VA: 0x2012A30
	|-ProfilingSampler.Get<object>
	*/

	// RVA: 0x1A13160 Offset: 0x1A13261 VA: 0x1A13160
	public void .ctor(string name) { }

	// RVA: 0x1A132B0 Offset: 0x1A133B1 VA: 0x1A132B0
	public void Begin(CommandBuffer cmd) { }

	// RVA: 0x1A13320 Offset: 0x1A13421 VA: 0x1A13320
	public void End(CommandBuffer cmd) { }

	// RVA: 0x1A13390 Offset: 0x1A13491 VA: 0x1A13390
	internal bool IsValid() { }

	[CompilerGeneratedAttribute] // RVA: 0x3DA10 Offset: 0x3DB11 VA: 0x3DA10
	// RVA: 0x1A133B0 Offset: 0x1A134B1 VA: 0x1A133B0
	internal CustomSampler get_sampler() { }

	[CompilerGeneratedAttribute] // RVA: 0x3DA20 Offset: 0x3DB21 VA: 0x3DA20
	// RVA: 0x1A133C0 Offset: 0x1A134C1 VA: 0x1A133C0
	private void set_sampler(CustomSampler value) { }

	[CompilerGeneratedAttribute] // RVA: 0x3DA30 Offset: 0x3DB31 VA: 0x3DA30
	// RVA: 0x1A133D0 Offset: 0x1A134D1 VA: 0x1A133D0
	internal CustomSampler get_inlineSampler() { }

	[CompilerGeneratedAttribute] // RVA: 0x3DA40 Offset: 0x3DB41 VA: 0x3DA40
	// RVA: 0x1A133E0 Offset: 0x1A134E1 VA: 0x1A133E0
	private void set_inlineSampler(CustomSampler value) { }

	[CompilerGeneratedAttribute] // RVA: 0x3DA50 Offset: 0x3DB51 VA: 0x3DA50
	// RVA: 0x1A133F0 Offset: 0x1A134F1 VA: 0x1A133F0
	public string get_name() { }

	[CompilerGeneratedAttribute] // RVA: 0x3DA60 Offset: 0x3DB61 VA: 0x3DA60
	// RVA: 0x1A13400 Offset: 0x1A13501 VA: 0x1A13400
	private void set_name(string value) { }

	// RVA: 0x1A13410 Offset: 0x1A13511 VA: 0x1A13410
	public void set_enableRecording(bool value) { }

	// RVA: 0x1A13450 Offset: 0x1A13551 VA: 0x1A13450
	public float get_gpuElapsedTime() { }

	// RVA: 0x1A134B0 Offset: 0x1A135B1 VA: 0x1A134B0
	public int get_gpuSampleCount() { }

	// RVA: 0x1A13500 Offset: 0x1A13601 VA: 0x1A13500
	public float get_cpuElapsedTime() { }

	// RVA: 0x1A13560 Offset: 0x1A13661 VA: 0x1A13560
	public int get_cpuSampleCount() { }

	// RVA: 0x1A135B0 Offset: 0x1A136B1 VA: 0x1A135B0
	public float get_inlineCpuElapsedTime() { }

	// RVA: 0x1A13610 Offset: 0x1A13711 VA: 0x1A13610
	public int get_inlineCpuSampleCount() { }

	// RVA: 0x1A13660 Offset: 0x1A13761 VA: 0x1A13660
	private void .ctor() { }
}

