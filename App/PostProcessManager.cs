// Namespace: App
[ExecuteInEditMode] // RVA: 0x2794E0 Offset: 0x2795E1 VA: 0x2794E0
public abstract class PostProcessManager : SingletonMonoBehaviour<PostProcessManager> // TypeDefIndex: 14048
{
	// Fields
	private Volume m_Root; // 0x20
	private Volume m_Bmap; // 0x28
	private Volume m_Combat; // 0x30
	public float BmapCombatChangeTime; // 0x38
	public AnimationCurve CurveInterpolate; // 0x40
	public AnimationCurve CurveBlur; // 0x48

	// Methods

	// RVA: 0x29DA5E0 Offset: 0x29DA6E1 VA: 0x29DA5E0
	private void Start() { }

	// RVA: 0x29DAA80 Offset: 0x29DAB81 VA: 0x29DAA80
	private void TryAddCustomRadialBlur() { }

	// RVA: 0x29DACF0 Offset: 0x29DADF1 VA: 0x29DACF0
	private void SetWeight(Volume volume, float weight) { }

	// RVA: 0x29DAC50 Offset: 0x29DAD51 VA: 0x29DAC50
	private void SetEnabled(Volume volume, bool enabled) { }

	// RVA: 0x29DAD80 Offset: 0x29DAE81 VA: 0x29DAD80
	private void SetLayer(Volume volume, string layer) { }

	// RVA: 0x29DA9B0 Offset: 0x29DAAB1 VA: 0x29DA9B0
	private Volume GetVolume(string name) { }

	// RVA: 0x29DAE40 Offset: 0x29DAF41 VA: 0x29DAE40
	public void SetTransition(float transition) { }

	// RVA: 0x29DB020 Offset: 0x29DB121 VA: 0x29DB020
	protected void .ctor() { }
}

