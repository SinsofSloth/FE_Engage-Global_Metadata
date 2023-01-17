// Namespace: UnityEngine.Timeline
[ExcludeFromPresetAttribute] // RVA: 0x56C80 Offset: 0x56D81 VA: 0x56C80
[CustomStyleAttribute] // RVA: 0x56C80 Offset: 0x56D81 VA: 0x56C80
[Serializable]
public class SignalEmitter : Marker, INotification, INotificationOptionProvider // TypeDefIndex: 5670
{
	// Fields
	[SerializeField] // RVA: 0x57CE0 Offset: 0x57DE1 VA: 0x57CE0
	private bool m_Retroactive; // 0x28
	[SerializeField] // RVA: 0x57CF0 Offset: 0x57DF1 VA: 0x57CF0
	private bool m_EmitOnce; // 0x29
	[SerializeField] // RVA: 0x57D00 Offset: 0x57E01 VA: 0x57D00
	private SignalAsset m_Asset; // 0x30

	// Properties
	public bool retroactive { get; set; }
	public bool emitOnce { get; set; }
	public SignalAsset asset { get; set; }
	private PropertyName UnityEngine.Playables.INotification.id { get; }
	private NotificationFlags UnityEngine.Timeline.INotificationOptionProvider.flags { get; }

	// Methods

	// RVA: 0x36A8C00 Offset: 0x36A8D01 VA: 0x36A8C00
	public bool get_retroactive() { }

	// RVA: 0x36A8C10 Offset: 0x36A8D11 VA: 0x36A8C10
	public void set_retroactive(bool value) { }

	// RVA: 0x36A8C20 Offset: 0x36A8D21 VA: 0x36A8C20
	public bool get_emitOnce() { }

	// RVA: 0x36A8C30 Offset: 0x36A8D31 VA: 0x36A8C30
	public void set_emitOnce(bool value) { }

	// RVA: 0x36A8C40 Offset: 0x36A8D41 VA: 0x36A8C40
	public SignalAsset get_asset() { }

	// RVA: 0x36A8C50 Offset: 0x36A8D51 VA: 0x36A8C50
	public void set_asset(SignalAsset value) { }

	// RVA: 0x36A8C60 Offset: 0x36A8D61 VA: 0x36A8C60 Slot: 9
	private PropertyName UnityEngine.Playables.INotification.get_id() { }

	// RVA: 0x36A8D30 Offset: 0x36A8E31 VA: 0x36A8D30 Slot: 10
	private NotificationFlags UnityEngine.Timeline.INotificationOptionProvider.get_flags() { }

	// RVA: 0x36A8D50 Offset: 0x36A8E51 VA: 0x36A8D50
	public void .ctor() { }
}

