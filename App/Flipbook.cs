// Namespace: App
public abstract class Flipbook : MonoBehaviour // TypeDefIndex: 14006
{
	// Fields
	public Vector2 m_patterns; // 0x18
	public float m_span; // 0x20
	public bool m_animateStrength; // 0x24
	public float m_strength; // 0x28
	public float m_strengthCycle; // 0x2C
	public Flipbook.Mode m_mode; // 0x30
	public bool m_autoPlay; // 0x34
	private bool m_playing; // 0x35
	private int m_spanIndex; // 0x38
	private int m_strengthCycleIndex; // 0x3C
	private int m_patternIndex; // 0x40
	private int m_patternCount; // 0x44
	private Material m_material; // 0x48
	private string m_targetTexture; // 0x50
	private int m_targetTextureId; // 0x58
	private string m_targetStrength; // 0x60
	private int m_targetStrengthId; // 0x68

	// Properties
	public int PatternIndex { get; }
	public bool Playing { get; }

	// Methods

	// RVA: 0x29FA450 Offset: 0x29FA551 VA: 0x29FA450
	public int get_PatternIndex() { }

	// RVA: 0x29FA460 Offset: 0x29FA561 VA: 0x29FA460
	private float Frac(float val) { }

	// RVA: 0x29FA490 Offset: 0x29FA591 VA: 0x29FA490
	private Vector2 GetUvOffset() { }

	// RVA: 0x29FA4E0 Offset: 0x29FA5E1 VA: 0x29FA4E0
	private Vector2 GetUvScale() { }

	// RVA: 0x29FA500 Offset: 0x29FA601 VA: 0x29FA500
	private void SetUvOffset() { }

	// RVA: 0x29FA560 Offset: 0x29FA661 VA: 0x29FA560
	private void SetUvScale() { }

	// RVA: 0x29FA590 Offset: 0x29FA691 VA: 0x29FA590
	private float GetStrength() { }

	// RVA: 0x29FA660 Offset: 0x29FA761 VA: 0x29FA660
	private void SetStrength() { }

	// RVA: 0x29FA760 Offset: 0x29FA861 VA: 0x29FA760
	public void Play() { }

	// RVA: 0x29FAB30 Offset: 0x29FAC31 VA: 0x29FAB30
	private void Awake() { }

	// RVA: 0x29FAB70 Offset: 0x29FAC71 VA: 0x29FAB70
	private void OnDestroy() { }

	// RVA: 0x29FABF0 Offset: 0x29FACF1 VA: 0x29FABF0
	private void Start() { }

	// RVA: 0x29FAC00 Offset: 0x29FAD01 VA: 0x29FAC00
	public void Update() { }

	// RVA: 0x29FAE80 Offset: 0x29FAF81 VA: 0x29FAE80
	public float GetPatternRate() { }

	// RVA: 0x29FAEB0 Offset: 0x29FAFB1 VA: 0x29FAEB0
	public bool get_Playing() { }

	// RVA: 0x29FAEC0 Offset: 0x29FAFC1 VA: 0x29FAEC0
	protected void .ctor() { }
}

