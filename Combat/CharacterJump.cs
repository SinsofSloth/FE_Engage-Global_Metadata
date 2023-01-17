// Namespace: Combat
public sealed class CharacterJump // TypeDefIndex: 8621
{
	// Fields
	private Character m_Chr; // 0x10
	private Transform m_Target; // 0x18
	private Vector3 m_StartPos; // 0x20
	private Vector3 m_GoalPos; // 0x2C
	private float m_PullOffset; // 0x38
	private float m_Elapsed; // 0x3C
	private float m_Duration; // 0x40
	private Curve.Type m_CurveType; // 0x44
	private bool m_bGrounding; // 0x48

	// Properties
	public bool IsEnd { get; }

	// Methods

	// RVA: 0x2B807C0 Offset: 0x2B808C1 VA: 0x2B807C0
	public bool get_IsEnd() { }

	// RVA: 0x2B807D0 Offset: 0x2B808D1 VA: 0x2B807D0
	public static Vector3 ClampToBorder(Vector3 start, Vector3 goal, bool isBig) { }

	// RVA: 0x2B80810 Offset: 0x2B80911 VA: 0x2B80810
	public static Vector3 ClampToBorder(Vector3 start, Vector3 goal, float radius) { }

	// RVA: 0x2B809F0 Offset: 0x2B80AF1 VA: 0x2B809F0
	public static Vector3 ClampToBorder(Vector3 start, Vector3 goal, Character chr) { }

	// RVA: 0x2B80840 Offset: 0x2B80941 VA: 0x2B80840
	private static Vector3 ClampToBorder(Vector3 start, Vector3 goal, float radius, Vector3 offset) { }

	// RVA: 0x2B80B60 Offset: 0x2B80C61 VA: 0x2B80B60
	public void JumpTo(Character chr, Vector3 goal, float pullOffset, float duration, bool isGrounding) { }

	// RVA: 0x2B80C60 Offset: 0x2B80D61 VA: 0x2B80C60
	public void JumpTo(Character chr, Transform target, float pullOffset, float duration, bool isGrounding) { }

	// RVA: 0x2B80CF0 Offset: 0x2B80DF1 VA: 0x2B80CF0
	public void Stop() { }

	// RVA: 0x2B80D00 Offset: 0x2B80E01 VA: 0x2B80D00
	public void Update(float deltaTime) { }

	// RVA: 0x2B80F20 Offset: 0x2B81021 VA: 0x2B80F20
	public void .ctor() { }
}

