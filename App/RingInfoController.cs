// Namespace: App
public class RingInfoController : MonoBehaviour // TypeDefIndex: 11771
{
	// Fields
	[SerializeField] // RVA: 0x2991B0 Offset: 0x2992B1 VA: 0x2991B0
	private TextMeshProUGUI m_RingName; // 0x18
	[SerializeField] // RVA: 0x2991C0 Offset: 0x2992C1 VA: 0x2991C0
	private Image m_RingConditionIconImage; // 0x20
	[SerializeField] // RVA: 0x2991D0 Offset: 0x2992D1 VA: 0x2991D0
	private TextMeshProUGUI m_GodName; // 0x28
	[SerializeField] // RVA: 0x2991E0 Offset: 0x2992E1 VA: 0x2991E0
	private GameObject m_RingImage; // 0x30
	[SerializeField] // RVA: 0x2991F0 Offset: 0x2992F1 VA: 0x2991F0
	private TextMeshProUGUI m_Message; // 0x38
	[HeaderAttribute] // RVA: 0x299200 Offset: 0x299301 VA: 0x299200
	public List<Sprite> m_ConditionIcons; // 0x40

	// Properties
	public RenderTexture RingImageTexture { set; }

	// Methods

	// RVA: 0x268D5A0 Offset: 0x268D6A1 VA: 0x268D5A0
	private string GetHelpText(GodUnit god, RingCleaningSequence.GodType type) { }

	// RVA: 0x268D6A0 Offset: 0x268D7A1 VA: 0x268D6A0
	private string GetRingNameText(GodUnit god, RingCleaningSequence.GodType type) { }

	// RVA: 0x268D6B0 Offset: 0x268D7B1 VA: 0x268D6B0
	public void SetStatus(GodUnit god, RingCleaningSequence.GodType type) { }

	// RVA: 0x268D7D0 Offset: 0x268D8D1 VA: 0x268D7D0
	public void set_RingImageTexture(RenderTexture value) { }

	// RVA: 0x268D850 Offset: 0x268D951 VA: 0x268D850
	public void Open() { }

	// RVA: 0x268D870 Offset: 0x268D971 VA: 0x268D870
	public void Close() { }

	// RVA: 0x268D880 Offset: 0x268D981 VA: 0x268D880
	public void .ctor() { }
}

