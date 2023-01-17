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

