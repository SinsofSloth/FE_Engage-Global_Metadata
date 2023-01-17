// Namespace: Combat
[DisallowMultipleComponent] // RVA: 0x273FF0 Offset: 0x2740F1 VA: 0x273FF0
public sealed class CharacterSignalObserver : MonoBehaviour // TypeDefIndex: 8646
{
	// Fields
	private Character _cp; // 0x18
	private CustomRadialBlur _radialBlur; // 0x20
	private StringBuilder sb; // 0x28
	private bool pushedFootIKEnabled; // 0x30

	// Properties
	private Character CP { get; }
	public CustomRadialBlur RadialBlur { get; }

	// Methods

	// RVA: 0x29BB970 Offset: 0x29BBA71 VA: 0x29BB970
	private Character get_CP() { }

	// RVA: 0x29BBA30 Offset: 0x29BBB31 VA: 0x29BBA30
	public CustomRadialBlur get_RadialBlur() { }

	// RVA: 0x29BBB10 Offset: 0x29BBC11 VA: 0x29BBB10
	private static Volume FindVolumeFromScene() { }

	// RVA: 0x29BBC10 Offset: 0x29BBD11 VA: 0x29BBC10
	private void Start() { }

	// RVA: 0x29BBCB0 Offset: 0x29BBDB1 VA: 0x29BBCB0
	private void MyStart() { }

	// RVA: 0x29BCB50 Offset: 0x29BCC51 VA: 0x29BCB50
	private void PushAndEnableFootIK(bool v) { }

	// RVA: 0x29BCC20 Offset: 0x29BCD21 VA: 0x29BCC20
	private void PopFootIK() { }

	// RVA: 0x29BCCE0 Offset: 0x29BCDE1 VA: 0x29BCCE0
	private void GroundAttrDirt(StringBuilder sb, Vector3 pos) { }

	// RVA: 0x29B3070 Offset: 0x29B3171 VA: 0x29B3070
	public void GroundParticle(int effectType, string nodeName) { }

	// RVA: 0x29BCDF0 Offset: 0x29BCEF1 VA: 0x29BCDF0
	public void StopFootstepObservers() { }

	// RVA: 0x29BCEA0 Offset: 0x29BCFA1 VA: 0x29BCEA0
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AB880 Offset: 0x2AB981 VA: 0x2AB880
	// RVA: 0x29BCF20 Offset: 0x29BD021 VA: 0x29BCF20
	private void <Start>b__8_0() { }
}

