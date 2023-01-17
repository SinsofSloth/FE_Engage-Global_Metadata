// Namespace: 
[Serializable]
public class CinemachineTriggerAction.ActionSettings.TriggerEvent : UnityEvent // TypeDefIndex: 5872
{
	// Methods

	// RVA: 0x1C6C6E0 Offset: 0x1C6C7E1 VA: 0x1C6C6E0
	public void .ctor() { }
}

// Namespace: 
[Serializable]
public struct CinemachineTriggerAction.ActionSettings // TypeDefIndex: 5874
{
	// Fields
	[TooltipAttribute] // RVA: 0x223E0 Offset: 0x224E1 VA: 0x223E0
	public CinemachineTriggerAction.ActionSettings.Mode m_Action; // 0x0
	[TooltipAttribute] // RVA: 0x22420 Offset: 0x22521 VA: 0x22420
	public Object m_Target; // 0x8
	[TooltipAttribute] // RVA: 0x22460 Offset: 0x22561 VA: 0x22460
	public int m_BoostAmount; // 0x10
	[TooltipAttribute] // RVA: 0x224A0 Offset: 0x225A1 VA: 0x224A0
	public float m_StartTime; // 0x14
	[TooltipAttribute] // RVA: 0x224E0 Offset: 0x225E1 VA: 0x224E0
	public CinemachineTriggerAction.ActionSettings.TimeMode m_Mode; // 0x18
	[TooltipAttribute] // RVA: 0x22520 Offset: 0x22621 VA: 0x22520
	public CinemachineTriggerAction.ActionSettings.TriggerEvent m_Event; // 0x20

	// Methods

	// RVA: 0x1A7AD50 Offset: 0x1A7AE51 VA: 0x1A7AD50
	public void .ctor(CinemachineTriggerAction.ActionSettings.Mode action) { }

	// RVA: 0x1A79F70 Offset: 0x1A7A071 VA: 0x1A79F70
	public void Invoke() { }
}

