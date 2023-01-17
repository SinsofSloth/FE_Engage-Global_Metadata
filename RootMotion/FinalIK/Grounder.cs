// Namespace: RootMotion.FinalIK
public abstract class Grounder : MonoBehaviour // TypeDefIndex: 14327
{
	// Fields
	[TooltipAttribute] // RVA: 0x29EDA0 Offset: 0x29EEA1 VA: 0x29EDA0
	[RangeAttribute] // RVA: 0x29EDA0 Offset: 0x29EEA1 VA: 0x29EDA0
	public float weight; // 0x18
	[TooltipAttribute] // RVA: 0x29EE00 Offset: 0x29EF01 VA: 0x29EE00
	public Grounding solver; // 0x20
	public Grounder.GrounderDelegate OnPreGrounder; // 0x28
	public Grounder.GrounderDelegate OnPostGrounder; // 0x30
	[CompilerGeneratedAttribute] // RVA: 0x29EE40 Offset: 0x29EF41 VA: 0x29EE40
	private bool <initiated>k__BackingField; // 0x38

	// Properties
	public bool initiated { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void ResetPosition();

	[CompilerGeneratedAttribute] // RVA: 0x2CE7A0 Offset: 0x2CE8A1 VA: 0x2CE7A0
	// RVA: 0x2DB00F0 Offset: 0x2DB01F1 VA: 0x2DB00F0
	public bool get_initiated() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CE7B0 Offset: 0x2CE8B1 VA: 0x2CE7B0
	// RVA: 0x2DB0100 Offset: 0x2DB0201 VA: 0x2DB0100
	protected void set_initiated(bool value) { }

	// RVA: 0x2DB0110 Offset: 0x2DB0211 VA: 0x2DB0110
	protected Vector3 GetSpineOffsetTarget() { }

	// RVA: 0x2DB02B0 Offset: 0x2DB03B1 VA: 0x2DB02B0
	protected void LogWarning(string message) { }

	// RVA: 0x2DB01C0 Offset: 0x2DB02C1 VA: 0x2DB01C0
	private Vector3 GetLegSpineBendVector(Grounding.Leg leg) { }

	// RVA: 0x2DB02F0 Offset: 0x2DB03F1 VA: 0x2DB02F0
	private Vector3 GetLegSpineTangent(Grounding.Leg leg) { }

	// RVA: -1 Offset: -1 Slot: 5
	protected abstract void OpenUserManual();

	// RVA: -1 Offset: -1 Slot: 6
	protected abstract void OpenScriptReference();

	// RVA: 0x2DB0400 Offset: 0x2DB0501 VA: 0x2DB0400
	protected void .ctor() { }
}

