// Namespace: UnityEngine
[NativeHeaderAttribute] // RVA: 0x4F220 Offset: 0x4F321 VA: 0x4F220
[NativeHeaderAttribute] // RVA: 0x4F220 Offset: 0x4F321 VA: 0x4F220
[NativeHeaderAttribute] // RVA: 0x4F220 Offset: 0x4F321 VA: 0x4F220
[NativeHeaderAttribute] // RVA: 0x4F220 Offset: 0x4F321 VA: 0x4F220
[RequireComponent] // RVA: 0x4F220 Offset: 0x4F321 VA: 0x4F220
[NativeHeaderAttribute] // RVA: 0x4F220 Offset: 0x4F321 VA: 0x4F220
public class ParticleSystemForceField : Component // TypeDefIndex: 4849
{
	// Properties
	[NativeNameAttribute] // RVA: 0x514F0 Offset: 0x515F1 VA: 0x514F0
	public ParticleSystemForceFieldShape shape { get; set; }
	public float startRange { get; set; }
	public float endRange { get; set; }
	public float length { get; set; }
	public float gravityFocus { get; set; }
	public Vector2 rotationRandomness { get; set; }
	public bool multiplyDragByParticleSize { get; set; }
	public bool multiplyDragByParticleVelocity { get; set; }
	public Texture3D vectorField { get; set; }
	public ParticleSystem.MinMaxCurve directionX { get; set; }
	public ParticleSystem.MinMaxCurve directionY { get; set; }
	public ParticleSystem.MinMaxCurve directionZ { get; set; }
	public ParticleSystem.MinMaxCurve gravity { get; set; }
	public ParticleSystem.MinMaxCurve rotationSpeed { get; set; }
	public ParticleSystem.MinMaxCurve rotationAttraction { get; set; }
	public ParticleSystem.MinMaxCurve drag { get; set; }
	public ParticleSystem.MinMaxCurve vectorFieldSpeed { get; set; }
	public ParticleSystem.MinMaxCurve vectorFieldAttraction { get; set; }

	// Methods

	// RVA: 0x1C33C00 Offset: 0x1C33D01 VA: 0x1C33C00
	public ParticleSystemForceFieldShape get_shape() { }

	// RVA: 0x1C33C50 Offset: 0x1C33D51 VA: 0x1C33C50
	public void set_shape(ParticleSystemForceFieldShape value) { }

	// RVA: 0x1C33CA0 Offset: 0x1C33DA1 VA: 0x1C33CA0
	public float get_startRange() { }

	// RVA: 0x1C33CF0 Offset: 0x1C33DF1 VA: 0x1C33CF0
	public void set_startRange(float value) { }

	// RVA: 0x1C33D40 Offset: 0x1C33E41 VA: 0x1C33D40
	public float get_endRange() { }

	// RVA: 0x1C33D90 Offset: 0x1C33E91 VA: 0x1C33D90
	public void set_endRange(float value) { }

	// RVA: 0x1C33DE0 Offset: 0x1C33EE1 VA: 0x1C33DE0
	public float get_length() { }

	// RVA: 0x1C33E30 Offset: 0x1C33F31 VA: 0x1C33E30
	public void set_length(float value) { }

	// RVA: 0x1C33E80 Offset: 0x1C33F81 VA: 0x1C33E80
	public float get_gravityFocus() { }

	// RVA: 0x1C33ED0 Offset: 0x1C33FD1 VA: 0x1C33ED0
	public void set_gravityFocus(float value) { }

	// RVA: 0x1C33F20 Offset: 0x1C34021 VA: 0x1C33F20
	public Vector2 get_rotationRandomness() { }

	// RVA: 0x1C33FD0 Offset: 0x1C340D1 VA: 0x1C33FD0
	public void set_rotationRandomness(Vector2 value) { }

	// RVA: 0x1C34080 Offset: 0x1C34181 VA: 0x1C34080
	public bool get_multiplyDragByParticleSize() { }

	// RVA: 0x1C340D0 Offset: 0x1C341D1 VA: 0x1C340D0
	public void set_multiplyDragByParticleSize(bool value) { }

	// RVA: 0x1C34120 Offset: 0x1C34221 VA: 0x1C34120
	public bool get_multiplyDragByParticleVelocity() { }

	// RVA: 0x1C34170 Offset: 0x1C34271 VA: 0x1C34170
	public void set_multiplyDragByParticleVelocity(bool value) { }

	// RVA: 0x1C341C0 Offset: 0x1C342C1 VA: 0x1C341C0
	public Texture3D get_vectorField() { }

	// RVA: 0x1C34210 Offset: 0x1C34311 VA: 0x1C34210
	public void set_vectorField(Texture3D value) { }

	// RVA: 0x1C34260 Offset: 0x1C34361 VA: 0x1C34260
	public ParticleSystem.MinMaxCurve get_directionX() { }

	// RVA: 0x1C34330 Offset: 0x1C34431 VA: 0x1C34330
	public void set_directionX(ParticleSystem.MinMaxCurve value) { }

	// RVA: 0x1C343D0 Offset: 0x1C344D1 VA: 0x1C343D0
	public ParticleSystem.MinMaxCurve get_directionY() { }

	// RVA: 0x1C344A0 Offset: 0x1C345A1 VA: 0x1C344A0
	public void set_directionY(ParticleSystem.MinMaxCurve value) { }

	// RVA: 0x1C34540 Offset: 0x1C34641 VA: 0x1C34540
	public ParticleSystem.MinMaxCurve get_directionZ() { }

	// RVA: 0x1C34610 Offset: 0x1C34711 VA: 0x1C34610
	public void set_directionZ(ParticleSystem.MinMaxCurve value) { }

	// RVA: 0x1C346B0 Offset: 0x1C347B1 VA: 0x1C346B0
	public ParticleSystem.MinMaxCurve get_gravity() { }

	// RVA: 0x1C34780 Offset: 0x1C34881 VA: 0x1C34780
	public void set_gravity(ParticleSystem.MinMaxCurve value) { }

	// RVA: 0x1C34820 Offset: 0x1C34921 VA: 0x1C34820
	public ParticleSystem.MinMaxCurve get_rotationSpeed() { }

	// RVA: 0x1C348F0 Offset: 0x1C349F1 VA: 0x1C348F0
	public void set_rotationSpeed(ParticleSystem.MinMaxCurve value) { }

	// RVA: 0x1C34990 Offset: 0x1C34A91 VA: 0x1C34990
	public ParticleSystem.MinMaxCurve get_rotationAttraction() { }

	// RVA: 0x1C34A60 Offset: 0x1C34B61 VA: 0x1C34A60
	public void set_rotationAttraction(ParticleSystem.MinMaxCurve value) { }

	// RVA: 0x1C34B00 Offset: 0x1C34C01 VA: 0x1C34B00
	public ParticleSystem.MinMaxCurve get_drag() { }

	// RVA: 0x1C34BD0 Offset: 0x1C34CD1 VA: 0x1C34BD0
	public void set_drag(ParticleSystem.MinMaxCurve value) { }

	// RVA: 0x1C34C70 Offset: 0x1C34D71 VA: 0x1C34C70
	public ParticleSystem.MinMaxCurve get_vectorFieldSpeed() { }

	// RVA: 0x1C34D40 Offset: 0x1C34E41 VA: 0x1C34D40
	public void set_vectorFieldSpeed(ParticleSystem.MinMaxCurve value) { }

	// RVA: 0x1C34DE0 Offset: 0x1C34EE1 VA: 0x1C34DE0
	public ParticleSystem.MinMaxCurve get_vectorFieldAttraction() { }

	// RVA: 0x1C34EB0 Offset: 0x1C34FB1 VA: 0x1C34EB0
	public void set_vectorFieldAttraction(ParticleSystem.MinMaxCurve value) { }

	// RVA: 0x1C34F50 Offset: 0x1C35051 VA: 0x1C34F50
	public void .ctor() { }

	// RVA: 0x1C33F80 Offset: 0x1C34081 VA: 0x1C33F80
	private void get_rotationRandomness_Injected(out Vector2 ret) { }

	// RVA: 0x1C34030 Offset: 0x1C34131 VA: 0x1C34030
	private void set_rotationRandomness_Injected(ref Vector2 value) { }

	// RVA: 0x1C342E0 Offset: 0x1C343E1 VA: 0x1C342E0
	private void get_directionX_Injected(out ParticleSystem.MinMaxCurve ret) { }

	// RVA: 0x1C34380 Offset: 0x1C34481 VA: 0x1C34380
	private void set_directionX_Injected(ref ParticleSystem.MinMaxCurve value) { }

	// RVA: 0x1C34450 Offset: 0x1C34551 VA: 0x1C34450
	private void get_directionY_Injected(out ParticleSystem.MinMaxCurve ret) { }

	// RVA: 0x1C344F0 Offset: 0x1C345F1 VA: 0x1C344F0
	private void set_directionY_Injected(ref ParticleSystem.MinMaxCurve value) { }

	// RVA: 0x1C345C0 Offset: 0x1C346C1 VA: 0x1C345C0
	private void get_directionZ_Injected(out ParticleSystem.MinMaxCurve ret) { }

	// RVA: 0x1C34660 Offset: 0x1C34761 VA: 0x1C34660
	private void set_directionZ_Injected(ref ParticleSystem.MinMaxCurve value) { }

	// RVA: 0x1C34730 Offset: 0x1C34831 VA: 0x1C34730
	private void get_gravity_Injected(out ParticleSystem.MinMaxCurve ret) { }

	// RVA: 0x1C347D0 Offset: 0x1C348D1 VA: 0x1C347D0
	private void set_gravity_Injected(ref ParticleSystem.MinMaxCurve value) { }

	// RVA: 0x1C348A0 Offset: 0x1C349A1 VA: 0x1C348A0
	private void get_rotationSpeed_Injected(out ParticleSystem.MinMaxCurve ret) { }

	// RVA: 0x1C34940 Offset: 0x1C34A41 VA: 0x1C34940
	private void set_rotationSpeed_Injected(ref ParticleSystem.MinMaxCurve value) { }

	// RVA: 0x1C34A10 Offset: 0x1C34B11 VA: 0x1C34A10
	private void get_rotationAttraction_Injected(out ParticleSystem.MinMaxCurve ret) { }

	// RVA: 0x1C34AB0 Offset: 0x1C34BB1 VA: 0x1C34AB0
	private void set_rotationAttraction_Injected(ref ParticleSystem.MinMaxCurve value) { }

	// RVA: 0x1C34B80 Offset: 0x1C34C81 VA: 0x1C34B80
	private void get_drag_Injected(out ParticleSystem.MinMaxCurve ret) { }

	// RVA: 0x1C34C20 Offset: 0x1C34D21 VA: 0x1C34C20
	private void set_drag_Injected(ref ParticleSystem.MinMaxCurve value) { }

	// RVA: 0x1C34CF0 Offset: 0x1C34DF1 VA: 0x1C34CF0
	private void get_vectorFieldSpeed_Injected(out ParticleSystem.MinMaxCurve ret) { }

	// RVA: 0x1C34D90 Offset: 0x1C34E91 VA: 0x1C34D90
	private void set_vectorFieldSpeed_Injected(ref ParticleSystem.MinMaxCurve value) { }

	// RVA: 0x1C34E60 Offset: 0x1C34F61 VA: 0x1C34E60
	private void get_vectorFieldAttraction_Injected(out ParticleSystem.MinMaxCurve ret) { }

	// RVA: 0x1C34F00 Offset: 0x1C35001 VA: 0x1C34F00
	private void set_vectorFieldAttraction_Injected(ref ParticleSystem.MinMaxCurve value) { }
}

