// Namespace: 
[Serializable]
public class AkGameObjListenerList : AkAudioListener.BaseListenerList // TypeDefIndex: 8025
{
	// Fields
	private AkGameObj akGameObj; // 0x20
	[SerializeField] // RVA: 0x27ECA0 Offset: 0x27EDA1 VA: 0x27ECA0
	public List<AkAudioListener> initialListenerList; // 0x28
	[SerializeField] // RVA: 0x27ECB0 Offset: 0x27EDB1 VA: 0x27ECB0
	public bool useDefaultListeners; // 0x30

	// Methods

	// RVA: 0x31771A0 Offset: 0x31772A1 VA: 0x31771A0
	public void SetUseDefaultListeners(bool useDefault) { }

	// RVA: 0x3175FF0 Offset: 0x31760F1 VA: 0x3175FF0
	public void Init(AkGameObj akGameObj) { }

	// RVA: 0x3177370 Offset: 0x3177471 VA: 0x3177370 Slot: 4
	public override bool Add(AkAudioListener listener) { }

	// RVA: 0x3177460 Offset: 0x3177561 VA: 0x3177460 Slot: 5
	public override bool Remove(AkAudioListener listener) { }

	// RVA: 0x31768F0 Offset: 0x31769F1 VA: 0x31768F0
	public void .ctor() { }
}

