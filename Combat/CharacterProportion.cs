// Namespace: Combat
[DisallowMultipleComponent] // RVA: 0x273F30 Offset: 0x274031 VA: 0x273F30
[ExecuteInEditMode] // RVA: 0x273F30 Offset: 0x274031 VA: 0x273F30
public sealed class CharacterProportion : MonoBehaviour // TypeDefIndex: 8627
{
	// Fields
	public ProportionParameters ProportionParameters; // 0x18
	private float shadowScaleAll; // 0x20
	private float shadowScaleLegs; // 0x24
	private float shadowScaleFeet; // 0x28
	private CharacterJoint _chrJoint; // 0x30
	private Character _cp; // 0x38

	// Properties
	private CharacterJoint CharacterJoint { get; }
	private Character CP { get; }

	// Methods

	// RVA: 0x29B4DE0 Offset: 0x29B4EE1 VA: 0x29B4DE0
	private bool isShadowScaleOne() { }

	// RVA: 0x29B4E20 Offset: 0x29B4F21 VA: 0x29B4E20
	private CharacterJoint get_CharacterJoint() { }

	// RVA: 0x29B4EE0 Offset: 0x29B4FE1 VA: 0x29B4EE0
	private Character get_CP() { }

	// RVA: 0x29B4FA0 Offset: 0x29B50A1 VA: 0x29B4FA0
	private void Start() { }

	// RVA: 0x29B5120 Offset: 0x29B5221 VA: 0x29B5120
	public void Reset() { }

	// RVA: 0x29B51E0 Offset: 0x29B52E1 VA: 0x29B51E0
	private void Swap() { }

	// RVA: 0x29B52B0 Offset: 0x29B53B1 VA: 0x29B52B0
	private void LateUpdate() { }

	// RVA: 0x29B5350 Offset: 0x29B5451 VA: 0x29B5350
	public void CommitChanges() { }

	// RVA: 0x29B53F0 Offset: 0x29B54F1 VA: 0x29B53F0
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AAF30 Offset: 0x2AB031 VA: 0x2AAF30
	// RVA: 0x29B5280 Offset: 0x29B5381 VA: 0x29B5280
	internal static bool <Swap>g__sw|13_0(ref float A, ref float B) { }
}

