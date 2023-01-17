// Namespace: UnityEngine.Timeline
public class SignalReceiver : MonoBehaviour, INotificationReceiver // TypeDefIndex: 5672
{
	// Fields
	[SerializeField] // RVA: 0x57D10 Offset: 0x57E11 VA: 0x57D10
	private SignalReceiver.EventKeyValue m_Events; // 0x18

	// Methods

	// RVA: 0x36A8D60 Offset: 0x36A8E61 VA: 0x36A8D60 Slot: 4
	public void OnNotify(Playable origin, INotification notification, object context) { }

	// RVA: 0x36A8F70 Offset: 0x36A9071 VA: 0x36A8F70
	public void AddReaction(SignalAsset asset, UnityEvent reaction) { }

	// RVA: 0x36A9190 Offset: 0x36A9291 VA: 0x36A9190
	public int AddEmptyReaction(UnityEvent reaction) { }

	// RVA: 0x36A9250 Offset: 0x36A9351 VA: 0x36A9250
	public void Remove(SignalAsset asset) { }

	// RVA: 0x36A93D0 Offset: 0x36A94D1 VA: 0x36A93D0
	public IEnumerable<SignalAsset> GetRegisteredSignals() { }

	// RVA: 0x36A93E0 Offset: 0x36A94E1 VA: 0x36A93E0
	public UnityEvent GetReaction(SignalAsset key) { }

	// RVA: 0x36A9420 Offset: 0x36A9521 VA: 0x36A9420
	public int Count() { }

	// RVA: 0x36A9470 Offset: 0x36A9571 VA: 0x36A9470
	public void ChangeSignalAtIndex(int idx, SignalAsset newKey) { }

	// RVA: 0x36A96D0 Offset: 0x36A97D1 VA: 0x36A96D0
	public void RemoveAtIndex(int idx) { }

	// RVA: 0x36A9870 Offset: 0x36A9971 VA: 0x36A9870
	public void ChangeReactionAtIndex(int idx, UnityEvent reaction) { }

	// RVA: 0x36A9930 Offset: 0x36A9A31 VA: 0x36A9930
	public UnityEvent GetReactionAtIndex(int idx) { }

	// RVA: 0x36A99F0 Offset: 0x36A9AF1 VA: 0x36A99F0
	public SignalAsset GetSignalAssetAtIndex(int idx) { }

	// RVA: 0x36A9AB0 Offset: 0x36A9BB1 VA: 0x36A9AB0
	private void OnEnable() { }

	// RVA: 0x36A9AC0 Offset: 0x36A9BC1 VA: 0x36A9AC0
	public void .ctor() { }
}

