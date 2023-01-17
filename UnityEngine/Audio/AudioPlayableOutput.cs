// Namespace: UnityEngine.Audio
[NativeHeaderAttribute] // RVA: 0x6DA80 Offset: 0x6DB81 VA: 0x6DA80
[NativeHeaderAttribute] // RVA: 0x6DA80 Offset: 0x6DB81 VA: 0x6DA80
[NativeHeaderAttribute] // RVA: 0x6DA80 Offset: 0x6DB81 VA: 0x6DA80
[StaticAccessorAttribute] // RVA: 0x6DA80 Offset: 0x6DB81 VA: 0x6DA80
[RequiredByNativeCodeAttribute] // RVA: 0x6DA80 Offset: 0x6DB81 VA: 0x6DA80
public struct AudioPlayableOutput : IPlayableOutput // TypeDefIndex: 4742
{
	// Fields
	private PlayableOutputHandle m_Handle; // 0x0

	// Methods

	// RVA: 0x1C68200 Offset: 0x1C68301 VA: 0x1C68200
	internal void .ctor(PlayableOutputHandle handle) { }

	// RVA: 0x1C682C0 Offset: 0x1C683C1 VA: 0x1C682C0 Slot: 4
	public PlayableOutputHandle GetHandle() { }

	// RVA: 0x1C682D0 Offset: 0x1C683D1 VA: 0x1C682D0
	public static AudioPlayableOutput op_Explicit(PlayableOutput output) { }

	// RVA: 0x1C68320 Offset: 0x1C68421 VA: 0x1C68320
	public void SetEvaluateOnSeek(bool value) { }

	[NativeThrowsAttribute] // RVA: 0x6DD20 Offset: 0x6DE21 VA: 0x6DD20
	// RVA: 0x1C68370 Offset: 0x1C68471 VA: 0x1C68370
	private static void InternalSetEvaluateOnSeek(ref PlayableOutputHandle output, bool value) { }
}

