// Namespace: 
public abstract class AkTriggerHandler : MonoBehaviour // TypeDefIndex: 8061
{
	// Fields
	public const int AWAKE_TRIGGER_ID = 1151176110;
	public const int START_TRIGGER_ID = 1281810935;
	public const int DESTROY_TRIGGER_ID = -358577003;
	public const int ON_ENABLE_TRIGGER_ID = -320808462;
	public const int MAX_NB_TRIGGERS = 32;
	public static Dictionary<uint, string> triggerTypes; // 0x0
	private bool didDestroy; // 0x18
	public List<int> triggerList; // 0x20
	public bool useOtherObject; // 0x28

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void HandleEvent(GameObject in_gameObject);

	// RVA: 0x20DEF90 Offset: 0x20DF091 VA: 0x20DEF90 Slot: 5
	protected virtual void Awake() { }

	// RVA: 0x20DF4B0 Offset: 0x20DF5B1 VA: 0x20DF4B0 Slot: 6
	protected virtual void Start() { }

	// RVA: 0x20DF540 Offset: 0x20DF641 VA: 0x20DF540 Slot: 7
	protected virtual void OnDestroy() { }

	// RVA: 0x20DF5E0 Offset: 0x20DF6E1 VA: 0x20DF5E0
	public void DoDestroy() { }

	// RVA: 0x20DFAC0 Offset: 0x20DFBC1 VA: 0x20DFAC0 Slot: 8
	public virtual void OnEnable() { }

	// RVA: 0x20DF020 Offset: 0x20DF121 VA: 0x20DF020
	protected void RegisterTriggers(List<int> in_triggerList, AkTriggerBase.Trigger in_delegate) { }

	// RVA: 0x20DF670 Offset: 0x20DF771 VA: 0x20DF670
	protected void UnregisterTriggers(List<int> in_triggerList, AkTriggerBase.Trigger in_delegate) { }

	// RVA: 0x20DFB50 Offset: 0x20DFC51 VA: 0x20DFB50
	protected void .ctor() { }

	// RVA: 0x20DFC10 Offset: 0x20DFD11 VA: 0x20DFC10
	private static void .cctor() { }
}

