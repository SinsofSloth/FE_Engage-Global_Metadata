// Namespace: UnityEngine.Experimental.Audio
[NativeTypeAttribute] // RVA: 0x6DB40 Offset: 0x6DC41 VA: 0x6DB40
[StaticAccessorAttribute] // RVA: 0x6DB40 Offset: 0x6DC41 VA: 0x6DB40
public class AudioSampleProvider // TypeDefIndex: 4744
{
	// Fields
	[DebuggerBrowsableAttribute] // RVA: 0x6DC70 Offset: 0x6DD71 VA: 0x6DC70
	[CompilerGeneratedAttribute] // RVA: 0x6DC70 Offset: 0x6DD71 VA: 0x6DC70
	private AudioSampleProvider.SampleFramesHandler sampleFramesAvailable; // 0x10
	[DebuggerBrowsableAttribute] // RVA: 0x6DCB0 Offset: 0x6DDB1 VA: 0x6DCB0
	[CompilerGeneratedAttribute] // RVA: 0x6DCB0 Offset: 0x6DDB1 VA: 0x6DCB0
	private AudioSampleProvider.SampleFramesHandler sampleFramesOverflow; // 0x18

	// Methods

	[RequiredByNativeCodeAttribute] // RVA: 0x6DD30 Offset: 0x6DE31 VA: 0x6DD30
	// RVA: 0x1C683C0 Offset: 0x1C684C1 VA: 0x1C683C0
	private void InvokeSampleFramesAvailable(int sampleFrameCount) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6DD40 Offset: 0x6DE41 VA: 0x6DD40
	// RVA: 0x1C68750 Offset: 0x1C68851 VA: 0x1C68750
	private void InvokeSampleFramesOverflow(int droppedSampleFrameCount) { }
}

