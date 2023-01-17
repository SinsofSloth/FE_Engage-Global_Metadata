// Namespace: 
[Serializable]
public struct CinemachineStateDrivenCamera.Instruction // TypeDefIndex: 5765
{
	// Fields
	[TooltipAttribute] // RVA: 0x1E200 Offset: 0x1E301 VA: 0x1E200
	public int m_FullHash; // 0x0
	[TooltipAttribute] // RVA: 0x1E240 Offset: 0x1E341 VA: 0x1E240
	public CinemachineVirtualCameraBase m_VirtualCamera; // 0x8
	[TooltipAttribute] // RVA: 0x1E280 Offset: 0x1E381 VA: 0x1E280
	public float m_ActivateAfter; // 0x10
	[TooltipAttribute] // RVA: 0x1E2C0 Offset: 0x1E3C1 VA: 0x1E2C0
	public float m_MinDuration; // 0x14
}

// Namespace: 
[DocumentationSortingAttribute] // RVA: 0x1AFD0 Offset: 0x1B0D1 VA: 0x1AFD0
[Serializable]
internal struct CinemachineStateDrivenCamera.ParentHash // TypeDefIndex: 5766
{
	// Fields
	public int m_Hash; // 0x0
	public int m_ParentHash; // 0x4

	// Methods

	// RVA: 0x1A8B550 Offset: 0x1A8B651 VA: 0x1A8B550
	public void .ctor(int h, int p) { }
}

// Namespace: 
private struct CinemachineStateDrivenCamera.HashPair // TypeDefIndex: 5767
{
	// Fields
	public int parentHash; // 0x0
	public int hash; // 0x4
}

