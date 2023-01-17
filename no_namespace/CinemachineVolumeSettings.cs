// Namespace: 
public enum CinemachineVolumeSettings.FocusTrackingMode // TypeDefIndex: 5894
{
	// Fields
	public int value__; // 0x0
	public const CinemachineVolumeSettings.FocusTrackingMode None = 0;
	public const CinemachineVolumeSettings.FocusTrackingMode LookAtTarget = 1;
	public const CinemachineVolumeSettings.FocusTrackingMode FollowTarget = 2;
	public const CinemachineVolumeSettings.FocusTrackingMode CustomTarget = 3;
	public const CinemachineVolumeSettings.FocusTrackingMode Camera = 4;
}

// Namespace: 
private class CinemachineVolumeSettings.VcamExtraState // TypeDefIndex: 5895
{
	// Fields
	public VolumeProfile mProfileCopy; // 0x10

	// Methods

	// RVA: 0x1A80780 Offset: 0x1A80881 VA: 0x1A80780
	public void CreateProfileCopy(VolumeProfile source) { }

	// RVA: 0x1A802E0 Offset: 0x1A803E1 VA: 0x1A802E0
	public void DestroyProfileCopy() { }

	// RVA: 0x1A8B6F0 Offset: 0x1A8B7F1 VA: 0x1A8B6F0
	public void .ctor() { }
}

