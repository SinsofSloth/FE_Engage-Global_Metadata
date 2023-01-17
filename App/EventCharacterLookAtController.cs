// Namespace: App
internal class EventCharacterLookAtController : MonoBehaviour // TypeDefIndex: 10195
{
	// Fields
	private const string CurrentTargetNameOfEye = "CurrentLookAtTargetOfEye";
	private const string CurrentTargetNameOfHead = "CurrentLookAtTargetOfHead";
	private const float WeightMin = 1E-05;
	private Character m_character; // 0x18
	private CharacterJoint m_characterJoint; // 0x20
	private GameObject m_currentTargetOfEye; // 0x28
	private GameObject m_currentTargetOfHead; // 0x30
	private EventCharacterLookAtController.PositionFader m_currentTargetPosOfEye; // 0x38
	private EventCharacterLookAtController.PositionFader m_currentTargetPosOfHead; // 0x40
	private WeightFader m_weightOfEye; // 0x48
	private WeightFader m_weightOfHead; // 0x50
	private LookAtIK m_ikEye; // 0x58
	private LookAtIK m_ikHead; // 0x60

	// Methods

	// RVA: 0x2607120 Offset: 0x2607221 VA: 0x2607120
	public void .ctor() { }

	// RVA: 0x2607130 Offset: 0x2607231 VA: 0x2607130
	public void Init(Character character, string pid) { }

	// RVA: 0x2607780 Offset: 0x2607881 VA: 0x2607780
	private void Update() { }

	// RVA: 0x2607700 Offset: 0x2607801 VA: 0x2607700
	public void Reset(float msec) { }

	// RVA: 0x2607950 Offset: 0x2607A51 VA: 0x2607950
	public void SetTargetObjectOfEye(GameObject target, float msec) { }

	// RVA: 0x2607A30 Offset: 0x2607B31 VA: 0x2607A30
	public void SetTargetObjectOfHead(GameObject target, float msec) { }

	// RVA: 0x2607B50 Offset: 0x2607C51 VA: 0x2607B50
	private Vector3 CalcDefaultTargetPos() { }

	// RVA: 0x2607B10 Offset: 0x2607C11 VA: 0x2607B10
	private void SetWeightOfEye(float weight, float msec) { }

	// RVA: 0x2607B30 Offset: 0x2607C31 VA: 0x2607B30
	private void SetWeightOfHead(float weight, float msec) { }
}

