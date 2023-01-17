// Namespace: App
[ExecuteInEditMode] // RVA: 0x278CF0 Offset: 0x278DF1 VA: 0x278CF0
public abstract class TextMeshAnimation : MonoBehaviour // TypeDefIndex: 13447
{
	// Fields
	public TextMeshAnimation.AnimationParams[] Params; // 0x18
	private TMP_Text m_TextComponent; // 0x20
	private bool m_IsAnimation; // 0x28
	private bool m_IsFirstFrame; // 0x29
	private int m_NowAnimationIndex; // 0x2C
	private float m_NowTime; // 0x30
	[CompilerGeneratedAttribute] // RVA: 0x29C100 Offset: 0x29C201 VA: 0x29C100
	private bool <isUnscaledDeltaTime>k__BackingField; // 0x34

	// Properties
	[HideInInspector] // RVA: 0x2D4F60 Offset: 0x2D5061 VA: 0x2D4F60
	public bool isUnscaledDeltaTime { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2CB9D0 Offset: 0x2CBAD1 VA: 0x2CB9D0
	// RVA: 0x25DAC90 Offset: 0x25DAD91 VA: 0x25DAC90
	public bool get_isUnscaledDeltaTime() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CB9E0 Offset: 0x2CBAE1 VA: 0x2CB9E0
	// RVA: 0x25DACA0 Offset: 0x25DADA1 VA: 0x25DACA0
	public void set_isUnscaledDeltaTime(bool value) { }

	// RVA: 0x25DACB0 Offset: 0x25DADB1 VA: 0x25DACB0
	private void Awake() { }

	// RVA: 0x25DAE20 Offset: 0x25DAF21 VA: 0x25DAE20
	private void Update() { }

	// RVA: 0x25DAEF0 Offset: 0x25DAFF1 VA: 0x25DAEF0
	private void AnimationText() { }

	// RVA: 0x25DB8B0 Offset: 0x25DB9B1 VA: 0x25DB8B0
	public void SetText(string text) { }

	// RVA: 0x25DB960 Offset: 0x25DBA61 VA: 0x25DB960
	public void Restart() { }

	// RVA: 0x25DB9A0 Offset: 0x25DBAA1 VA: 0x25DB9A0
	private void StartAnimation() { }

	// RVA: 0x25DBA90 Offset: 0x25DBB91 VA: 0x25DBA90
	public void Skip() { }

	// RVA: 0x25DB9B0 Offset: 0x25DBAB1 VA: 0x25DB9B0
	public void StartAnimation(int index) { }

	// RVA: 0x25DB890 Offset: 0x25DB991 VA: 0x25DB890
	public void ToNextAnimation() { }

	// RVA: 0x25DBB10 Offset: 0x25DBC11 VA: 0x25DBB10
	public static void SetAsUnscaledInChildren(Transform root, bool v = True) { }

	// RVA: 0x25DBBC0 Offset: 0x25DBCC1 VA: 0x25DBBC0
	protected void .ctor() { }
}

