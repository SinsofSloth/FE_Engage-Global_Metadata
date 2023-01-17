// Namespace: 
public abstract class AkCommonPlatformSettings : AkBasePlatformSettings // TypeDefIndex: 7946
{
	// Properties
	public override AkInitializationSettings AkInitializationSettings { get; }
	public override AkSpatialAudioInitSettings AkSpatialAudioInitSettings { get; }
	public override AkCallbackManager.InitializationSettings CallbackManagerInitializationSettings { get; }
	public override string InitialLanguage { get; }
	public override string SoundBankPersistentDataPath { get; }
	public override bool RenderDuringFocusLoss { get; }
	public override string SoundbankPath { get; }
	public override bool UseAsyncOpen { get; }
	public override AkCommunicationSettings AkCommunicationSettings { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 13
	protected abstract AkCommonUserSettings GetUserSettings();

	// RVA: -1 Offset: -1 Slot: 14
	protected abstract AkCommonAdvancedSettings GetAdvancedSettings();

	// RVA: -1 Offset: -1 Slot: 15
	protected abstract AkCommonCommSettings GetCommsSettings();

	// RVA: 0x316AC50 Offset: 0x316AD51 VA: 0x316AC50 Slot: 4
	public override AkInitializationSettings get_AkInitializationSettings() { }

	// RVA: 0x316CA50 Offset: 0x316CB51 VA: 0x316CA50 Slot: 5
	public override AkSpatialAudioInitSettings get_AkSpatialAudioInitSettings() { }

	// RVA: 0x316CAD0 Offset: 0x316CBD1 VA: 0x316CAD0 Slot: 6
	public override AkCallbackManager.InitializationSettings get_CallbackManagerInitializationSettings() { }

	// RVA: 0x316CB50 Offset: 0x316CC51 VA: 0x316CB50 Slot: 8
	public override string get_InitialLanguage() { }

	// RVA: 0x316CB80 Offset: 0x316CC81 VA: 0x316CB80 Slot: 7
	public override string get_SoundBankPersistentDataPath() { }

	// RVA: 0x316CBB0 Offset: 0x316CCB1 VA: 0x316CBB0 Slot: 9
	public override bool get_RenderDuringFocusLoss() { }

	// RVA: 0x316CBE0 Offset: 0x316CCE1 VA: 0x316CBE0 Slot: 10
	public override string get_SoundbankPath() { }

	// RVA: 0x316CC10 Offset: 0x316CD11 VA: 0x316CC10 Slot: 12
	public override bool get_UseAsyncOpen() { }

	// RVA: 0x316CC40 Offset: 0x316CD41 VA: 0x316CC40 Slot: 11
	public override AkCommunicationSettings get_AkCommunicationSettings() { }

	// RVA: 0x316CC90 Offset: 0x316CD91 VA: 0x316CC90
	protected void .ctor() { }
}

