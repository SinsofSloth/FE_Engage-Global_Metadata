// Namespace: UnityEngine.Rendering
[DefaultMemberAttribute] // RVA: 0x3BA80 Offset: 0x3BB81 VA: 0x3BA80
[Serializable]
public class TextureCurve : IDisposable // TypeDefIndex: 4637
{
	// Fields
	private const int k_Precision = 128;
	private const float k_Step = 0.0078125;
	[CompilerGeneratedAttribute] // RVA: 0x3CD50 Offset: 0x3CE51 VA: 0x3CD50
	[SerializeField] // RVA: 0x3CD50 Offset: 0x3CE51 VA: 0x3CD50
	private int <length>k__BackingField; // 0x10
	[SerializeField] // RVA: 0x3CD90 Offset: 0x3CE91 VA: 0x3CD90
	private bool m_Loop; // 0x14
	[SerializeField] // RVA: 0x3CDA0 Offset: 0x3CEA1 VA: 0x3CDA0
	private float m_ZeroValue; // 0x18
	[SerializeField] // RVA: 0x3CDB0 Offset: 0x3CEB1 VA: 0x3CDB0
	private float m_Range; // 0x1C
	[SerializeField] // RVA: 0x3CDC0 Offset: 0x3CEC1 VA: 0x3CDC0
	private AnimationCurve m_Curve; // 0x20
	private AnimationCurve m_LoopingCurve; // 0x28
	private Texture2D m_Texture; // 0x30
	private bool m_IsCurveDirty; // 0x38
	private bool m_IsTextureDirty; // 0x39

	// Properties
	public int length { get; set; }
	public Keyframe Item { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x3DBA0 Offset: 0x3DCA1 VA: 0x3DBA0
	// RVA: 0x35466C0 Offset: 0x35467C1 VA: 0x35466C0
	public int get_length() { }

	[CompilerGeneratedAttribute] // RVA: 0x3DBB0 Offset: 0x3DCB1 VA: 0x3DBB0
	// RVA: 0x35466D0 Offset: 0x35467D1 VA: 0x35466D0
	private void set_length(int value) { }

	// RVA: 0x35466E0 Offset: 0x35467E1 VA: 0x35466E0
	public Keyframe get_Item(int index) { }

	// RVA: 0x3546730 Offset: 0x3546831 VA: 0x3546730
	public void .ctor(AnimationCurve baseCurve, float zeroValue, bool loop, in Vector2 bounds) { }

	// RVA: 0x3546790 Offset: 0x3546891 VA: 0x3546790
	public void .ctor(Keyframe[] keys, float zeroValue, bool loop, in Vector2 bounds) { }

	// RVA: 0x3546870 Offset: 0x3546971 VA: 0x3546870 Slot: 1
	protected override void Finalize() { }

	[ObsoleteAttribute] // RVA: 0x3DBC0 Offset: 0x3DCC1 VA: 0x3DBC0
	// RVA: 0x3546880 Offset: 0x3546981 VA: 0x3546880 Slot: 4
	public void Dispose() { }

	// RVA: 0x3546890 Offset: 0x3546991 VA: 0x3546890
	public void Release() { }

	// RVA: 0x3546910 Offset: 0x3546A11 VA: 0x3546910
	public void SetDirty() { }

	// RVA: 0x3546920 Offset: 0x3546A21 VA: 0x3546920
	private static TextureFormat GetTextureFormat() { }

	// RVA: 0x3546980 Offset: 0x3546A81 VA: 0x3546980
	public Texture2D GetTexture() { }

	// RVA: 0x3546B90 Offset: 0x3546C91 VA: 0x3546B90
	public float Evaluate(float time) { }

	// RVA: 0x3546DB0 Offset: 0x3546EB1 VA: 0x3546DB0
	public int AddKey(float time, float value) { }

	// RVA: 0x3546E00 Offset: 0x3546F01 VA: 0x3546E00
	public int MoveKey(int index, in Keyframe key) { }

	// RVA: 0x3546E60 Offset: 0x3546F61 VA: 0x3546E60
	public void RemoveKey(int index) { }

	// RVA: 0x3546E90 Offset: 0x3546F91 VA: 0x3546E90
	public void SmoothTangents(int index, float weight) { }
}

