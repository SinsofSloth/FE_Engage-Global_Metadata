// Namespace: App
public abstract class HubConditionController : MonoBehaviour // TypeDefIndex: 10668
{
	// Fields
	public HubUtil.ConditionType m_conditionType; // 0x18
	public HubConditionController.ControlType m_controlType; // 0x1C
	private bool m_conditionFlag; // 0x20
	[SpaceAttribute] // RVA: 0x2942C0 Offset: 0x2943C1 VA: 0x2942C0
	public bool m_isUseTargets; // 0x21
	public List<GameObject> m_targets; // 0x28
	public List<GameObject> m_lods; // 0x30

	// Methods

	// RVA: 0x3052D20 Offset: 0x3052E21 VA: 0x3052D20
	private void Awake() { }

	// RVA: 0x3052DA0 Offset: 0x3052EA1 VA: 0x3052DA0
	private void Start() { }

	// RVA: 0x3052DE0 Offset: 0x3052EE1 VA: 0x3052DE0
	private void SetActive(bool active) { }

	// RVA: 0x3053080 Offset: 0x3053181 VA: 0x3053080
	public void Apply() { }

	// RVA: 0x3053150 Offset: 0x3053251 VA: 0x3053150
	protected void .ctor() { }
}

