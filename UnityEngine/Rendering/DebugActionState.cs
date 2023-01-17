// Namespace: UnityEngine.Rendering
internal class DebugActionState // TypeDefIndex: 4553
{
	// Fields
	private DebugActionState.DebugActionKeyType m_Type; // 0x10
	private string[] m_PressedButtons; // 0x18
	private string m_PressedAxis; // 0x20
	private KeyCode[] m_PressedKeys; // 0x28
	private bool[] m_TriggerPressedUp; // 0x30
	private float m_Timer; // 0x38
	[CompilerGeneratedAttribute] // RVA: 0x3CAB0 Offset: 0x3CBB1 VA: 0x3CAB0
	private bool <runningAction>k__BackingField; // 0x3C
	[CompilerGeneratedAttribute] // RVA: 0x3CAC0 Offset: 0x3CBC1 VA: 0x3CAC0
	private float <actionState>k__BackingField; // 0x40

	// Properties
	internal bool runningAction { get; set; }
	internal float actionState { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x3D750 Offset: 0x3D851 VA: 0x3D750
	// RVA: 0x1B32B20 Offset: 0x1B32C21 VA: 0x1B32B20
	internal bool get_runningAction() { }

	[CompilerGeneratedAttribute] // RVA: 0x3D760 Offset: 0x3D861 VA: 0x3D760
	// RVA: 0x1B32B30 Offset: 0x1B32C31 VA: 0x1B32B30
	private void set_runningAction(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x3D770 Offset: 0x3D871 VA: 0x3D770
	// RVA: 0x1B32B40 Offset: 0x1B32C41 VA: 0x1B32B40
	internal float get_actionState() { }

	[CompilerGeneratedAttribute] // RVA: 0x3D780 Offset: 0x3D881 VA: 0x3D780
	// RVA: 0x1B32B50 Offset: 0x1B32C51 VA: 0x1B32B50
	private void set_actionState(float value) { }

	// RVA: 0x1B32B60 Offset: 0x1B32C61 VA: 0x1B32B60
	private void Trigger(int triggerCount, float state) { }

	// RVA: 0x1B32C40 Offset: 0x1B32D41 VA: 0x1B32C40
	public void TriggerWithButton(string[] buttons, float state) { }

	// RVA: 0x1B32CD0 Offset: 0x1B32DD1 VA: 0x1B32CD0
	public void TriggerWithAxis(string axis, float state) { }

	// RVA: 0x1B32D20 Offset: 0x1B32E21 VA: 0x1B32D20
	public void TriggerWithKey(KeyCode[] keys, float state) { }

	// RVA: 0x1B32DB0 Offset: 0x1B32EB1 VA: 0x1B32DB0
	private void Reset() { }

	// RVA: 0x1B32DD0 Offset: 0x1B32ED1 VA: 0x1B32DD0
	public void Update(DebugActionDesc desc) { }

	// RVA: 0x1B32FD0 Offset: 0x1B330D1 VA: 0x1B32FD0
	public void .ctor() { }
}

