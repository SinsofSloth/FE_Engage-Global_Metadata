// Namespace: Combat
public sealed class CharacterEyeDart : MonoBehaviour // TypeDefIndex: 8600
{
	// Fields
	public float m_AmplitudeMin; // 0x18
	public float m_AmplitudeMax; // 0x1C
	public float m_IntervalMin; // 0x20
	public float m_IntervalMax; // 0x24
	public float m_TransitionTime; // 0x28
	private CharacterEyeDart.State m_State; // 0x2C
	private LookAtIK m_IK; // 0x30
	private float m_StayTime; // 0x38
	private float m_NowTime; // 0x3C
	private float m_PrevWeight; // 0x40
	private float m_NextWeight; // 0x44

	// Methods

	// RVA: 0x2B72D50 Offset: 0x2B72E51 VA: 0x2B72D50
	private void Start() { }

	// RVA: 0x2B72E10 Offset: 0x2B72F11 VA: 0x2B72E10
	private void Update() { }

	// RVA: 0x2B72FC0 Offset: 0x2B730C1 VA: 0x2B72FC0
	private void ToStay() { }

	// RVA: 0x2B72F70 Offset: 0x2B73071 VA: 0x2B72F70
	private void ToTransition() { }

	// RVA: 0x2B73000 Offset: 0x2B73101 VA: 0x2B73000
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AA8F0 Offset: 0x2AA9F1 VA: 0x2AA8F0
	// RVA: 0x2B73010 Offset: 0x2B73111 VA: 0x2B73010
	private void <Start>b__12_0() { }
}

