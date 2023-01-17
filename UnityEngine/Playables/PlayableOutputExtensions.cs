// Namespace: UnityEngine.Playables
[ExtensionAttribute] // RVA: 0x4413A0 Offset: 0x4414A1 VA: 0x4413A0
public static class PlayableOutputExtensions // TypeDefIndex: 3998
{
	// Methods

	[ExtensionAttribute] // RVA: 0x455530 Offset: 0x455631 VA: 0x455530
	// RVA: -1 Offset: -1
	public static void SetReferenceObject<U>(U output, Object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2011AE0 Offset: 0x2011BE1 VA: 0x2011AE0
	|-PlayableOutputExtensions.SetReferenceObject<PlayableOutput>
	*/

	[ExtensionAttribute] // RVA: 0x455540 Offset: 0x455641 VA: 0x455540
	// RVA: -1 Offset: -1
	public static void SetUserData<U>(U output, Object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2011C10 Offset: 0x2011D11 VA: 0x2011C10
	|-PlayableOutputExtensions.SetUserData<PlayableOutput>
	*/

	[ExtensionAttribute] // RVA: 0x455550 Offset: 0x455651 VA: 0x455550
	// RVA: -1 Offset: -1
	public static Playable GetSourcePlayable<U>(U output) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2011A10 Offset: 0x2011B11 VA: 0x2011A10
	|-PlayableOutputExtensions.GetSourcePlayable<AnimationPlayableOutput>
	*/

	[ExtensionAttribute] // RVA: 0x455560 Offset: 0x455661 VA: 0x455560
	// RVA: -1 Offset: -1
	public static void SetSourcePlayable<U, V>(U output, V value, int port) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2011B30 Offset: 0x2011C31 VA: 0x2011B30
	|-PlayableOutputExtensions.SetSourcePlayable<AnimationPlayableOutput, Playable>
	|
	|-RVA: 0x2011BA0 Offset: 0x2011CA1 VA: 0x2011BA0
	|-PlayableOutputExtensions.SetSourcePlayable<PlayableOutput, Playable>
	*/

	[ExtensionAttribute] // RVA: 0x455570 Offset: 0x455671 VA: 0x455570
	// RVA: -1 Offset: -1
	public static int GetSourceOutputPort<U>(U output) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x20119D0 Offset: 0x2011AD1 VA: 0x20119D0
	|-PlayableOutputExtensions.GetSourceOutputPort<AnimationPlayableOutput>
	*/

	[ExtensionAttribute] // RVA: 0x455580 Offset: 0x455681 VA: 0x455580
	// RVA: -1 Offset: -1
	public static void SetWeight<U>(U output, float value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2011C60 Offset: 0x2011D61 VA: 0x2011C60
	|-PlayableOutputExtensions.SetWeight<AnimationPlayableOutput>
	|
	|-RVA: 0x2011CB0 Offset: 0x2011DB1 VA: 0x2011CB0
	|-PlayableOutputExtensions.SetWeight<PlayableOutput>
	*/

	[ExtensionAttribute] // RVA: 0x455590 Offset: 0x455691 VA: 0x455590
	// RVA: -1 Offset: -1
	public static void PushNotification<U>(U output, Playable origin, INotification notification, object context) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2011A70 Offset: 0x2011B71 VA: 0x2011A70
	|-PlayableOutputExtensions.PushNotification<PlayableOutput>
	*/

	[ExtensionAttribute] // RVA: 0x4555A0 Offset: 0x4556A1 VA: 0x4555A0
	// RVA: -1 Offset: -1
	public static void AddNotificationReceiver<U>(U output, INotificationReceiver receiver) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2011980 Offset: 0x2011A81 VA: 0x2011980
	|-PlayableOutputExtensions.AddNotificationReceiver<PlayableOutput>
	*/
}

