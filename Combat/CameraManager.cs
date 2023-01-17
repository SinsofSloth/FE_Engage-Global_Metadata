// Namespace: Combat
[DisallowMultipleComponent] // RVA: 0x273990 Offset: 0x273A91 VA: 0x273990
[Serializable]
public class CameraManager : SingletonMonoBehaviour<CameraManager> // TypeDefIndex: 8555
{
	// Fields
	private CameraSwitch Switch; // 0x20
	private CameraPositionData PosData; // 0x28
	private CameraSituationConverter Selector; // 0x30
	private float m_LastUnusedTime; // 0x38
	private bool m_IsTemporaryCamera; // 0x3C
	private float m_LastChangeTime; // 0x40

	// Properties
	public float TransitionProgress { get; set; }
	public bool IsPositionCrossed { get; }

	// Methods

	// RVA: 0x299F9E0 Offset: 0x299FAE1 VA: 0x299F9E0
	public float get_TransitionProgress() { }

	// RVA: 0x29A30A0 Offset: 0x29A31A1 VA: 0x29A30A0
	public void set_TransitionProgress(float value) { }

	// RVA: 0x29A31C0 Offset: 0x29A32C1 VA: 0x29A31C0
	public bool get_IsPositionCrossed() { }

	// RVA: 0x29A31D0 Offset: 0x29A32D1 VA: 0x29A31D0
	public bool IsTargeting(int side) { }

	// RVA: 0x29A3290 Offset: 0x29A3391 VA: 0x29A3290
	private void Start() { }

	// RVA: 0x29A3330 Offset: 0x29A3431 VA: 0x29A3330
	private void LateUpdate() { }

	// RVA: 0x29A3D40 Offset: 0x29A3E41 VA: 0x29A3D40
	public void BeginCamera(CombatRecord record, bool transition = True) { }

	// RVA: 0x29A4A40 Offset: 0x29A4B41 VA: 0x29A4A40
	public void BeginCamera(Character[] chara, bool transition) { }

	// RVA: 0x29A4D20 Offset: 0x29A4E21 VA: 0x29A4D20
	public void EndCamera(bool transition, ViewMode.Mode cameraMode = 0) { }

	[IteratorStateMachineAttribute] // RVA: 0x2A98A0 Offset: 0x2A99A1 VA: 0x2A98A0
	// RVA: 0x29A50C0 Offset: 0x29A51C1 VA: 0x29A50C0
	private IEnumerator ReverseCamera() { }

	// RVA: 0x29A5000 Offset: 0x29A5101 VA: 0x29A5000
	private void ReverseMainCamera() { }

	// RVA: 0x29A3AC0 Offset: 0x29A3BC1 VA: 0x29A3AC0
	public void UpdateSituation(CameraSituation changeStyle, bool changeForce = False) { }

	// RVA: 0x29A5150 Offset: 0x29A5251 VA: 0x29A5150
	public void UpdateSituation(AnimationEvent ev, int callSide) { }

	// RVA: 0x29A5290 Offset: 0x29A5391 VA: 0x29A5290
	public void SwitchCamera(CameraPosition pos) { }

	// RVA: 0x29A52A0 Offset: 0x29A53A1 VA: 0x29A52A0
	public void StartShake(float magnitude, Vector3 sourcePos, bool isCritical = False) { }

	// RVA: 0x29A5420 Offset: 0x29A5521 VA: 0x29A5420
	public void ArmorShake(float magnitude, Vector3 sourcePos) { }

	// RVA: 0x29A5590 Offset: 0x29A5691 VA: 0x29A5590
	public void Stabilize() { }

	// RVA: 0x29A4970 Offset: 0x29A4A71 VA: 0x29A4970
	private void BeginTransition(CameraPosition cameraPos) { }

	// RVA: 0x29A56A0 Offset: 0x29A57A1 VA: 0x29A56A0
	public void .ctor() { }
}

