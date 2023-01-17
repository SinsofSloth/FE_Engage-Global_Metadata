// Namespace: 
public class SkyCastle : SingletonMonoBehaviour<SkyCastle> // TypeDefIndex: 7818
{
	// Fields
	[SerializeField] // RVA: 0x27D470 Offset: 0x27D571 VA: 0x27D470
	[HeaderAttribute] // RVA: 0x27D470 Offset: 0x27D571 VA: 0x27D470
	[SpaceAttribute] // RVA: 0x27D470 Offset: 0x27D571 VA: 0x27D470
	private GameObject m_LeftSkyCastleObject; // 0x20
	[SerializeField] // RVA: 0x27D4D0 Offset: 0x27D5D1 VA: 0x27D4D0
	private GameObject m_RightSkyCastleObject; // 0x28
	[SerializeField] // RVA: 0x27D4E0 Offset: 0x27D5E1 VA: 0x27D4E0
	[HeaderAttribute] // RVA: 0x27D4E0 Offset: 0x27D5E1 VA: 0x27D4E0
	[SpaceAttribute] // RVA: 0x27D4E0 Offset: 0x27D5E1 VA: 0x27D4E0
	private Animator m_LeftSkyCastleAnimator; // 0x30
	[SerializeField] // RVA: 0x27D540 Offset: 0x27D641 VA: 0x27D540
	private Animator m_RightSkyCastleAnimator; // 0x38
	[HeaderAttribute] // RVA: 0x27D550 Offset: 0x27D651 VA: 0x27D550
	[SerializeField] // RVA: 0x27D550 Offset: 0x27D651 VA: 0x27D550
	[SpaceAttribute] // RVA: 0x27D550 Offset: 0x27D651 VA: 0x27D550
	private GameObject[] m_SkyCastleEffect; // 0x40
	private Vector3[] m_Now; // 0x48
	private Vector3[] m_Old; // 0x50
	private Vector3[] m_Vec; // 0x58
	private bool[] m_IsUpdate; // 0x60

	// Properties
	public Animator LeftSkyCastleAnimator { get; }
	public Animator RightSkyCastleAnimator { get; }

	// Methods

	// RVA: 0x27E4650 Offset: 0x27E4751 VA: 0x27E4650
	private void Start() { }

	// RVA: 0x27E4760 Offset: 0x27E4861 VA: 0x27E4760
	private void Update() { }

	// RVA: 0x27E47A0 Offset: 0x27E48A1 VA: 0x27E47A0
	private void UpdateSkyCastle(GameObject gameObject, Animator animator, int index) { }

	// RVA: 0x27E49E0 Offset: 0x27E4AE1 VA: 0x27E49E0
	public bool IsPlayingSkyCastle() { }

	// RVA: 0x27E4AA0 Offset: 0x27E4BA1 VA: 0x27E4AA0
	public Vector3 GetVec(SkyCastle.MovingSkyCastle index) { }

	// RVA: 0x27E4AE0 Offset: 0x27E4BE1 VA: 0x27E4AE0
	public Animator get_LeftSkyCastleAnimator() { }

	// RVA: 0x27E4AF0 Offset: 0x27E4BF1 VA: 0x27E4AF0
	public Animator get_RightSkyCastleAnimator() { }

	// RVA: 0x27E4B00 Offset: 0x27E4C01 VA: 0x27E4B00
	public void .ctor() { }
}

