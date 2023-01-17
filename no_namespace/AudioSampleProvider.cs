// Namespace: 
public sealed class AudioSampleProvider.SampleFramesHandler : MulticastDelegate // TypeDefIndex: 4743
{
	// Methods

	// RVA: 0x1C68B40 Offset: 0x1C68C41 VA: 0x1C68B40
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1C683E0 Offset: 0x1C684E1 VA: 0x1C683E0 Slot: 13
	public virtual void Invoke(AudioSampleProvider provider, uint sampleFrameCount) { }

	// RVA: 0x1C68B60 Offset: 0x1C68C61 VA: 0x1C68B60 Slot: 14
	public virtual IAsyncResult BeginInvoke(AudioSampleProvider provider, uint sampleFrameCount, AsyncCallback callback, object object) { }

	// RVA: 0x1C68C00 Offset: 0x1C68D01 VA: 0x1C68C00 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

