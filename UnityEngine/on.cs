// Namespace: UnityEngine
public class WaitForSecondsRealtime : CustomYieldInstruction // TypeDefIndex: 3621
{
	// Fields
	[DebuggerBrowsableAttribute] // RVA: 0x443950 Offset: 0x443A51 VA: 0x443950
	[CompilerGeneratedAttribute] // RVA: 0x443950 Offset: 0x443A51 VA: 0x443950
	private float <waitTime>k__BackingField; // 0x10
	private float m_WaitUntilTime; // 0x14

	// Properties
	public float waitTime { get; set; }
	public override bool keepWaiting { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x450950 Offset: 0x450A51 VA: 0x450950
	// RVA: 0x38521B0 Offset: 0x38522B1 VA: 0x38521B0
	public float get_waitTime() { }

	[CompilerGeneratedAttribute] // RVA: 0x450960 Offset: 0x450A61 VA: 0x450960
	// RVA: 0x38521C0 Offset: 0x38522C1 VA: 0x38521C0
	public void set_waitTime(float value) { }

	// RVA: 0x38521D0 Offset: 0x38522D1 VA: 0x38521D0 Slot: 7
	public override bool get_keepWaiting() { }

	// RVA: 0x3852270 Offset: 0x3852371 VA: 0x3852270
	public void .ctor(float time) { }

	// RVA: 0x38522B0 Offset: 0x38523B1 VA: 0x38522B0 Slot: 8
	public override void Reset() { }
}

