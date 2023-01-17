// Namespace: 
public enum CinemachineVirtualCameraBase.StandbyUpdateMode // TypeDefIndex: 5848
{
	// Fields
	public int value__; // 0x0
	public const CinemachineVirtualCameraBase.StandbyUpdateMode Never = 0;
	public const CinemachineVirtualCameraBase.StandbyUpdateMode Always = 1;
	public const CinemachineVirtualCameraBase.StandbyUpdateMode RoundRobin = 2;
}

// Namespace: 
[Serializable]
public struct CinemachineVirtualCameraBase.TransitionParams // TypeDefIndex: 5850
{
	// Fields
	[TooltipAttribute] // RVA: 0x21D30 Offset: 0x21E31 VA: 0x21D30
	[FormerlySerializedAsAttribute] // RVA: 0x21D30 Offset: 0x21E31 VA: 0x21D30
	public CinemachineVirtualCameraBase.BlendHint m_BlendHint; // 0x0
	[TooltipAttribute] // RVA: 0x21D90 Offset: 0x21E91 VA: 0x21D90
	public bool m_InheritPosition; // 0x4
	[TooltipAttribute] // RVA: 0x21DD0 Offset: 0x21ED1 VA: 0x21DD0
	public CinemachineBrain.VcamActivatedEvent m_OnCameraLive; // 0x8
}

