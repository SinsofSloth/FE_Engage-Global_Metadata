// Namespace: App
public class FortuneTellingResultMenu : MonoBehaviour // TypeDefIndex: 10623
{
	// Fields
	public static readonly uint ForceMask; // 0x0
	private static int MessageKind; // 0x4
	public TextMeshProUGUI m_unitName; // 0x18
	[HeaderAttribute] // RVA: 0x292F40 Offset: 0x293041 VA: 0x292F40
	public GameObject m_cardRoot; // 0x20
	[HeaderAttribute] // RVA: 0x292F80 Offset: 0x293081 VA: 0x292F80
	public TextMeshProUGUI m_result0Title; // 0x28
	public TextMeshProUGUI m_result0Text; // 0x30
	[HeaderAttribute] // RVA: 0x292FC0 Offset: 0x2930C1 VA: 0x292FC0
	public TextMeshProUGUI m_result1Title; // 0x38
	public TextMeshProUGUI m_result1Text; // 0x40
	private Unit m_unit; // 0x48
	private int m_cardKind; // 0x50
	private bool m_bCardPositive; // 0x54
	private Animator m_cardAnimator; // 0x58
	private StringBuilder m_nameBuider; // 0x60

	// Methods

	// RVA: 0x2A02900 Offset: 0x2A02A01 VA: 0x2A02900
	private void Start() { }

	// RVA: 0x2A02910 Offset: 0x2A02A11 VA: 0x2A02910
	public void Init(Unit unit) { }

	// RVA: 0x2A03060 Offset: 0x2A03161 VA: 0x2A03060
	private void Update() { }

	// RVA: 0x2A03310 Offset: 0x2A03411 VA: 0x2A03310
	public string GetResultMessage() { }

	// RVA: 0x2A03470 Offset: 0x2A03571 VA: 0x2A03470
	public void .ctor() { }

	// RVA: 0x2A034F0 Offset: 0x2A035F1 VA: 0x2A034F0
	private static void .cctor() { }
}

