// Namespace: App
public abstract class EmissionAnimation : MonoBehaviour // TypeDefIndex: 14002
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x29D240 Offset: 0x29D341 VA: 0x29D240
	private bool <IsAnimate>k__BackingField; // 0x18
	[SerializeField] // RVA: 0x29D250 Offset: 0x29D351 VA: 0x29D250
	private AnimationCurve m_EmissionCurve; // 0x20
	public Material[] m_Materials; // 0x28
	private int m_EmissionPropertyKey; // 0x30

	// Properties
	public bool IsAnimate { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2CDC20 Offset: 0x2CDD21 VA: 0x2CDC20
	// RVA: 0x25F4AD0 Offset: 0x25F4BD1 VA: 0x25F4AD0
	public bool get_IsAnimate() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CDC30 Offset: 0x2CDD31 VA: 0x2CDC30
	// RVA: 0x25F4AE0 Offset: 0x25F4BE1 VA: 0x25F4AE0
	public void set_IsAnimate(bool value) { }

	// RVA: 0x25F4AF0 Offset: 0x25F4BF1 VA: 0x25F4AF0
	private void Awake() { }

	// RVA: 0x25F4B50 Offset: 0x25F4C51 VA: 0x25F4B50
	private void Update() { }

	// RVA: 0x25F4CD0 Offset: 0x25F4DD1 VA: 0x25F4CD0
	protected void .ctor() { }
}

