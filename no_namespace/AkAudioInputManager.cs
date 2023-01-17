// Namespace: 
public sealed class AkAudioInputManager.AudioFormatDelegate : MulticastDelegate // TypeDefIndex: 7915
{
	// Methods

	// RVA: 0x24AFD90 Offset: 0x24AFE91 VA: 0x24AFD90
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x24AFDB0 Offset: 0x24AFEB1 VA: 0x24AFDB0 Slot: 13
	public virtual void Invoke(uint playingID, AkAudioFormat format) { }

	// RVA: 0x24AFFF0 Offset: 0x24B00F1 VA: 0x24AFFF0 Slot: 14
	public virtual IAsyncResult BeginInvoke(uint playingID, AkAudioFormat format, AsyncCallback callback, object object) { }

	// RVA: 0x24B0090 Offset: 0x24B0191 VA: 0x24B0090 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

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
public sealed class AkAudioInputManager.AudioSamplesDelegate : MulticastDelegate // TypeDefIndex: 7917
{
	// Methods

	// RVA: 0x24B03D0 Offset: 0x24B04D1 VA: 0x24B03D0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x24B03F0 Offset: 0x24B04F1 VA: 0x24B03F0 Slot: 13
	public virtual bool Invoke(uint playingID, uint channelIndex, float[] samples) { }

	// RVA: 0x24B0650 Offset: 0x24B0751 VA: 0x24B0650 Slot: 14
	public virtual IAsyncResult BeginInvoke(uint playingID, uint channelIndex, float[] samples, AsyncCallback callback, object object) { }

	// RVA: 0x24B0700 Offset: 0x24B0801 VA: 0x24B0700 Slot: 15
	public virtual bool EndInvoke(IAsyncResult result) { }
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

// Namespace: 
public static class AkAudioInputManager // TypeDefIndex: 7919
{
	// Fields
	private static bool initialized; // 0x0
	private static readonly Dictionary<uint, AkAudioInputManager.AudioSamplesDelegate> audioSamplesDelegates; // 0x8
	private static readonly Dictionary<uint, AkAudioInputManager.AudioFormatDelegate> audioFormatDelegates; // 0x10
	private static readonly AkAudioFormat audioFormat; // 0x18
	private static readonly AkAudioInputManager.AudioSamplesInteropDelegate audioSamplesDelegate; // 0x20
	private static readonly AkAudioInputManager.AudioFormatInteropDelegate audioFormatDelegate; // 0x28

	// Methods

	// RVA: 0x2ECEC70 Offset: 0x2ECED71 VA: 0x2ECEC70
	public static uint PostAudioInputEvent(Event akEvent, GameObject gameObject, AkAudioInputManager.AudioSamplesDelegate sampleDelegate, AkAudioInputManager.AudioFormatDelegate formatDelegate) { }

	// RVA: 0x2ECEF70 Offset: 0x2ECF071 VA: 0x2ECEF70
	public static uint PostAudioInputEvent(uint akEventID, GameObject gameObject, AkAudioInputManager.AudioSamplesDelegate sampleDelegate, AkAudioInputManager.AudioFormatDelegate formatDelegate) { }

	// RVA: 0x2ECF0A0 Offset: 0x2ECF1A1 VA: 0x2ECF0A0
	public static uint PostAudioInputEvent(string akEventName, GameObject gameObject, AkAudioInputManager.AudioSamplesDelegate sampleDelegate, AkAudioInputManager.AudioFormatDelegate formatDelegate) { }

	[MonoPInvokeCallbackAttribute] // RVA: 0x2A6EB0 Offset: 0x2A6FB1 VA: 0x2A6EB0
	// RVA: 0x2ECEA40 Offset: 0x2ECEB41 VA: 0x2ECEA40
	private static bool InternalAudioSamplesDelegate(uint playingID, float[] samples, uint channelIndex, uint frames) { }

	[MonoPInvokeCallbackAttribute] // RVA: 0x2A6F20 Offset: 0x2A7021 VA: 0x2A6F20
	// RVA: 0x2ECEB50 Offset: 0x2ECEC51 VA: 0x2ECEB50
	private static void InternalAudioFormatDelegate(uint playingID, IntPtr format) { }

	// RVA: 0x2ECED70 Offset: 0x2ECEE71 VA: 0x2ECED70
	private static void TryInitialize() { }

	// RVA: 0x2ECEE60 Offset: 0x2ECEF61 VA: 0x2ECEE60
	private static void AddPlayingID(uint playingID, AkAudioInputManager.AudioSamplesDelegate sampleDelegate, AkAudioInputManager.AudioFormatDelegate formatDelegate) { }

	// RVA: 0x2ECF1D0 Offset: 0x2ECF2D1 VA: 0x2ECF1D0
	private static void EventCallback(object cookie, AkCallbackType type, AkCallbackInfo callbackInfo) { }

	// RVA: 0x2ECF310 Offset: 0x2ECF411 VA: 0x2ECF310
	private static void .cctor() { }
}

