// Namespace: App
[Serializable]
public class MyRoomEventBehaviour : PlayableBehaviour // TypeDefIndex: 11398
{
	// Fields
	public MyRoomEventClip.EventClipType eventType; // 0x10
	public string eventName; // 0x18
	public MyRoomEventClip.EventClipLayer eventLayer; // 0x20
	public bool isOut; // 0x24
	private GameObject effectObject; // 0x28
	private GameSound.Handle soundHandle; // 0x30

	// Methods

	// RVA: 0x282B8D0 Offset: 0x282B9D1 VA: 0x282B8D0 Slot: 17
	public override void OnBehaviourPlay(Playable playable, FrameData info) { }

	// RVA: 0x282BB20 Offset: 0x282BC21 VA: 0x282BB20 Slot: 18
	public override void OnBehaviourPause(Playable playable, FrameData info) { }

	// RVA: 0x282BC00 Offset: 0x282BD01 VA: 0x282BC00 Slot: 20
	public override void ProcessFrame(Playable playable, FrameData info, object playerData) { }

	// RVA: 0x282B9A0 Offset: 0x282BAA1 VA: 0x282B9A0
	private GameObject CreateEffect(string name) { }

	// RVA: 0x282C500 Offset: 0x282C601 VA: 0x282C500
	private Transform GetLayerParent() { }

	// RVA: 0x282C5E0 Offset: 0x282C6E1 VA: 0x282C5E0
	public void .ctor() { }
}

