// Namespace: 
[UnmanagedFunctionPointerAttribute] // RVA: 0x271C30 Offset: 0x271D31 VA: 0x271C30
public sealed class AkAudioInputManager.AudioFormatInteropDelegate : MulticastDelegate // TypeDefIndex: 7916
{
	// Methods

	// RVA: 0x24B00A0 Offset: 0x24B01A1 VA: 0x24B00A0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x24B00C0 Offset: 0x24B01C1 VA: 0x24B00C0 Slot: 13
	public virtual void Invoke(uint playingID, IntPtr format) { }

	// RVA: 0x24B0300 Offset: 0x24B0401 VA: 0x24B0300 Slot: 14
	public virtual IAsyncResult BeginInvoke(uint playingID, IntPtr format, AsyncCallback callback, object object) { }

	// RVA: 0x24B03C0 Offset: 0x24B04C1 VA: 0x24B03C0 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointerAttribute] // RVA: 0x271C50 Offset: 0x271D51 VA: 0x271C50
public sealed class AkAudioInputManager.AudioSamplesInteropDelegate : MulticastDelegate // TypeDefIndex: 7918
{
	// Methods

	// RVA: 0x24B0730 Offset: 0x24B0831 VA: 0x24B0730
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x24B0750 Offset: 0x24B0851 VA: 0x24B0750 Slot: 13
	public virtual bool Invoke(uint playingID, [In] [Out] float[] samples, uint channelIndex, uint frames) { }

	// RVA: 0x24B09D0 Offset: 0x24B0AD1 VA: 0x24B09D0 Slot: 14
	public virtual IAsyncResult BeginInvoke(uint playingID, [In] [Out] float[] samples, uint channelIndex, uint frames, AsyncCallback callback, object object) { }

	// RVA: 0x24B0A90 Offset: 0x24B0B91 VA: 0x24B0A90 Slot: 15
	public virtual bool EndInvoke(IAsyncResult result) { }
}

