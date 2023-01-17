// Namespace: 
public class Grounding.Pelvis // TypeDefIndex: 14337
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x29FB90 Offset: 0x29FC91 VA: 0x29FB90
	private Vector3 <IKOffset>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x29FBA0 Offset: 0x29FCA1 VA: 0x29FBA0
	private float <heightOffset>k__BackingField; // 0x1C
	private Grounding grounding; // 0x20
	private Vector3 lastRootPosition; // 0x28
	private float damperF; // 0x34
	private bool initiated; // 0x38
	private double lastTime; // 0x40

	// Properties
	public Vector3 IKOffset { get; set; }
	public float heightOffset { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2CEC80 Offset: 0x2CED81 VA: 0x2CEC80
	// RVA: 0x1FA68B0 Offset: 0x1FA69B1 VA: 0x1FA68B0
	public Vector3 get_IKOffset() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CEC90 Offset: 0x2CED91 VA: 0x2CEC90
	// RVA: 0x1FA68C0 Offset: 0x1FA69C1 VA: 0x1FA68C0
	private void set_IKOffset(Vector3 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2CECA0 Offset: 0x2CEDA1 VA: 0x2CECA0
	// RVA: 0x1FA68D0 Offset: 0x1FA69D1 VA: 0x1FA68D0
	public float get_heightOffset() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CECB0 Offset: 0x2CEDB1 VA: 0x2CECB0
	// RVA: 0x1FA68E0 Offset: 0x1FA69E1 VA: 0x1FA68E0
	private void set_heightOffset(float value) { }

	// RVA: 0x1FA68F0 Offset: 0x1FA69F1 VA: 0x1FA68F0
	public void Initiate(Grounding grounding) { }

	// RVA: 0x1FA69A0 Offset: 0x1FA6AA1 VA: 0x1FA69A0
	public void Reset() { }

	// RVA: 0x1FA6950 Offset: 0x1FA6A51 VA: 0x1FA6950
	public void OnEnable() { }

	// RVA: 0x1FA6A10 Offset: 0x1FA6B11 VA: 0x1FA6A10
	public void Process(float lowestOffset, float highestOffset, bool isGrounded) { }

	// RVA: 0x1FA6B90 Offset: 0x1FA6C91 VA: 0x1FA6B90
	public void .ctor() { }
}

