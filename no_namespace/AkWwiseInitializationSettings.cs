// Namespace: 
public class AkWwiseInitializationSettings.CommonPlatformSettings : AkWwiseInitializationSettings.PlatformSettings // TypeDefIndex: 7959
{
	// Fields
	[HideInInspector] // RVA: 0x27E4E0 Offset: 0x27E5E1 VA: 0x27E4E0
	public AkCommonUserSettings UserSettings; // 0x30
	[HideInInspector] // RVA: 0x27E4F0 Offset: 0x27E5F1 VA: 0x27E4F0
	public AkCommonAdvancedSettings AdvancedSettings; // 0x38
	[HideInInspector] // RVA: 0x27E500 Offset: 0x27E601 VA: 0x27E500
	public AkCommonCommSettings CommsSettings; // 0x40

	// Methods

	// RVA: 0x1F5BEA0 Offset: 0x1F5BFA1 VA: 0x1F5BEA0 Slot: 13
	protected override AkCommonUserSettings GetUserSettings() { }

	// RVA: 0x1F5BEB0 Offset: 0x1F5BFB1 VA: 0x1F5BEB0 Slot: 14
	protected override AkCommonAdvancedSettings GetAdvancedSettings() { }

	// RVA: 0x1F5BEC0 Offset: 0x1F5BFC1 VA: 0x1F5BEC0 Slot: 15
	protected override AkCommonCommSettings GetCommsSettings() { }

	// RVA: 0x1F5BED0 Offset: 0x1F5BFD1 VA: 0x1F5BED0
	public void .ctor() { }
}

