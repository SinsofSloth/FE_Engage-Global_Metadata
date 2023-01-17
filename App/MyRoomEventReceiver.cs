// Namespace: App
public abstract class MyRoomEventReceiver : MonoBehaviour, INotificationReceiver // TypeDefIndex: 11396
{
	// Properties
	private double AdjustedTime { get; }

	// Methods

	// RVA: 0x282C740 Offset: 0x282C841 VA: 0x282C740
	private double get_AdjustedTime() { }

	// RVA: 0x282C840 Offset: 0x282C941 VA: 0x282C840 Slot: 4
	public void OnNotify(Playable origin, INotification notification, object context) { }

	// RVA: 0x282C9A0 Offset: 0x282CAA1 VA: 0x282C9A0
	private void OnNotifyEffectMarker(MyRoomEffectMarker effectMarker) { }

	// RVA: 0x282CBE0 Offset: 0x282CCE1 VA: 0x282CBE0
	private void OnNotifySEMarker(MyRoomSEMarker seMarker) { }

	// RVA: 0x282CCC0 Offset: 0x282CDC1 VA: 0x282CCC0
	private void OnNotifyCameraMarker(MyRoomCameraMarker cameraMarker) { }

	// RVA: 0x282D160 Offset: 0x282D261 VA: 0x282D160
	private void OnNotifyLookingCameraMarker(MyRoomLookingCameraMarker lookingCameraMarker) { }

	// RVA: 0x282D380 Offset: 0x282D481 VA: 0x282D380
	protected void .ctor() { }
}

