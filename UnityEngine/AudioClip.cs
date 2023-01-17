// Namespace: UnityEngine
[NativeHeaderAttribute] // RVA: 0x6D800 Offset: 0x6D901 VA: 0x6D800
[StaticAccessorAttribute] // RVA: 0x6D800 Offset: 0x6D901 VA: 0x6D800
public sealed class AudioClip : Object // TypeDefIndex: 4737
{
	// Fields
	[DebuggerBrowsableAttribute] // RVA: 0x6DBF0 Offset: 0x6DCF1 VA: 0x6DBF0
	[CompilerGeneratedAttribute] // RVA: 0x6DBF0 Offset: 0x6DCF1 VA: 0x6DBF0
	private AudioClip.PCMReaderCallback m_PCMReaderCallback; // 0x18
	[DebuggerBrowsableAttribute] // RVA: 0x6DC30 Offset: 0x6DD31 VA: 0x6DC30
	[CompilerGeneratedAttribute] // RVA: 0x6DC30 Offset: 0x6DD31 VA: 0x6DC30
	private AudioClip.PCMSetPositionCallback m_PCMSetPositionCallback; // 0x20

	// Methods

	[RequiredByNativeCodeAttribute] // RVA: 0x6DD00 Offset: 0x6DE01 VA: 0x6DD00
	// RVA: 0x1C67B10 Offset: 0x1C67C11 VA: 0x1C67B10
	private void InvokePCMReaderCallback_Internal(float[] data) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6DD10 Offset: 0x6DE11 VA: 0x6DD10
	// RVA: 0x1C67E80 Offset: 0x1C67F81 VA: 0x1C67E80
	private void InvokePCMSetPositionCallback_Internal(int position) { }
}

