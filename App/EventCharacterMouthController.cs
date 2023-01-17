// Namespace: App
public abstract class EventCharacterMouthController : MonoBehaviour // TypeDefIndex: 10198
{
	// Fields
	private string[] LayerNameArray; // 0x18
	private Animator m_animator; // 0x20
	private int[] m_animLayerIndexArray; // 0x28
	private WeightFader[] m_weight; // 0x30
	private string m_voiceEventName; // 0x38
	[SerializeField] // RVA: 0x28DA10 Offset: 0x28DB11 VA: 0x28DA10
	private AnimationCurve m_weight_a; // 0x40
	[SerializeField] // RVA: 0x28DA20 Offset: 0x28DB21 VA: 0x28DA20
	private AnimationCurve m_weight_i; // 0x48
	[SerializeField] // RVA: 0x28DA30 Offset: 0x28DB31 VA: 0x28DA30
	private AnimationCurve m_weight_u; // 0x50
	[SerializeField] // RVA: 0x28DA40 Offset: 0x28DB41 VA: 0x28DA40
	private AnimationCurve m_weight_e; // 0x58
	[SerializeField] // RVA: 0x28DA50 Offset: 0x28DB51 VA: 0x28DA50
	private AnimationCurve m_weight_o; // 0x60
	[SerializeField] // RVA: 0x28DA60 Offset: 0x28DB61 VA: 0x28DA60
	private AnimationCurve m_weightScale_vol; // 0x68
	[SerializeField] // RVA: 0x28DA70 Offset: 0x28DB71 VA: 0x28DA70
	private AnimationCurve m_weightOffset_vol; // 0x70

	// Methods

	// RVA: 0x2607D00 Offset: 0x2607E01 VA: 0x2607D00
	public void .ctor() { }

	// RVA: 0x2608090 Offset: 0x2608191 VA: 0x2608090
	private void Start() { }

	// RVA: 0x26080A0 Offset: 0x26081A1 VA: 0x26080A0
	private void Init() { }

	// RVA: 0x2608400 Offset: 0x2608501 VA: 0x2608400
	private void Update() { }

	// RVA: 0x26088C0 Offset: 0x26089C1 VA: 0x26088C0
	public float GetWeight(int animLayerIndex) { }

	// RVA: 0x2608910 Offset: 0x2608A11 VA: 0x2608910
	public void SetVoiceEventName(string voiceEventName) { }

	// RVA: 0x2608870 Offset: 0x2608971 VA: 0x2608870
	public void SetWeight(int animLayerIndex, float weight, float msec) { }
}

