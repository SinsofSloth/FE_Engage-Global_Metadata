// Namespace: AK.Wwise
[Serializable]
public class Event : BaseType // TypeDefIndex: 8073
{
	// Fields
	public WwiseEventReference WwiseObjectReference; // 0x20

	// Properties
	public override WwiseObjectReference ObjectReference { get; set; }
	public override WwiseObjectType WwiseObjectType { get; }

	// Methods

	// RVA: 0x26059D0 Offset: 0x2605AD1 VA: 0x26059D0 Slot: 4
	public override WwiseObjectReference get_ObjectReference() { }

	// RVA: 0x26059E0 Offset: 0x2605AE1 VA: 0x26059E0 Slot: 5
	public override void set_ObjectReference(WwiseObjectReference value) { }

	// RVA: 0x2605A70 Offset: 0x2605B71 VA: 0x2605A70 Slot: 6
	public override WwiseObjectType get_WwiseObjectType() { }

	// RVA: 0x2605A80 Offset: 0x2605B81 VA: 0x2605A80
	private void VerifyPlayingID(uint playingId) { }

	// RVA: 0x2605A90 Offset: 0x2605B91 VA: 0x2605A90
	public uint Post(GameObject gameObject) { }

	// RVA: 0x2605BE0 Offset: 0x2605CE1 VA: 0x2605BE0
	public uint Post(GameObject gameObject, CallbackFlags flags, AkCallbackManager.EventCallback callback, object cookie) { }

	// RVA: 0x2605D60 Offset: 0x2605E61 VA: 0x2605D60
	public uint Post(GameObject gameObject, uint flags, AkCallbackManager.EventCallback callback, object cookie) { }

	// RVA: 0x2605ED0 Offset: 0x2605FD1 VA: 0x2605ED0
	public void Stop(GameObject gameObject, int transitionDuration = 0, AkCurveInterpolation curveInterpolation = 4) { }

	// RVA: 0x2605EE0 Offset: 0x2605FE1 VA: 0x2605EE0
	public void ExecuteAction(GameObject gameObject, AkActionOnEventType actionOnEventType, int transitionDuration, AkCurveInterpolation curveInterpolation) { }

	// RVA: 0x2606060 Offset: 0x2606161 VA: 0x2606060
	public void PostMIDI(GameObject gameObject, AkMIDIPostArray array) { }

	// RVA: 0x26060D0 Offset: 0x26061D1 VA: 0x26060D0
	public void PostMIDI(GameObject gameObject, AkMIDIPostArray array, int count) { }

	// RVA: 0x2606140 Offset: 0x2606241 VA: 0x2606140
	public void StopMIDI(GameObject gameObject) { }

	// RVA: 0x26061F0 Offset: 0x26062F1 VA: 0x26061F0
	public void StopMIDI() { }

	// RVA: 0x2606290 Offset: 0x2606391 VA: 0x2606290
	public void .ctor() { }
}

