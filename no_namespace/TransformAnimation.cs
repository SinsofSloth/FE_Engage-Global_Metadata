// Namespace: 
public enum TransformAnimation.Kinds // TypeDefIndex: 14060
{
	// Fields
	public int value__; // 0x0
	public const TransformAnimation.Kinds None = 0;
	public const TransformAnimation.Kinds Position = 1;
	public const TransformAnimation.Kinds Rotation = 2;
	public const TransformAnimation.Kinds Scale = 3;
}

// Namespace: 
public enum TransformAnimation.Actions // TypeDefIndex: 14061
{
	// Fields
	public int value__; // 0x0
	public const TransformAnimation.Actions None = 0;
	public const TransformAnimation.Actions Loop = 1;
	public const TransformAnimation.Actions Repeat = 2;
}

// Namespace: 
[Serializable]
public class TransformAnimation.Animation // TypeDefIndex: 14062
{
	// Fields
	public TransformAnimation.Kinds Kind; // 0x10
	public TransformAnimation.Actions Action; // 0x14
	public Vector3 Start; // 0x18
	public Vector3 End; // 0x24
	public float Cycle; // 0x30
	public bool IsRandom; // 0x34
	public GameObject[] Tragets; // 0x38

	// Methods

	// RVA: 0x23A67C0 Offset: 0x23A68C1 VA: 0x23A67C0
	public void .ctor() { }

	// RVA: 0x23A6820 Offset: 0x23A6921 VA: 0x23A6820
	public float CalcCycle() { }

	// RVA: 0x23A6850 Offset: 0x23A6951 VA: 0x23A6850
	public float CalcInverse() { }
}

// Namespace: 
private class TransformAnimation.Animator.Node // TypeDefIndex: 14063
{
	// Fields
	private Transform m_Target; // 0x10
	private Vector3 m_Start; // 0x18
	private Vector3 m_End; // 0x24

	// Methods

	// RVA: 0x2D68BE0 Offset: 0x2D68CE1 VA: 0x2D68BE0
	public void .ctor(GameObject go) { }

	// RVA: 0x2D68C20 Offset: 0x2D68D21 VA: 0x2D68C20
	public void Commit(TransformAnimation.Animation animation) { }

	// RVA: 0x2D68DC0 Offset: 0x2D68EC1 VA: 0x2D68DC0
	public void Update(TransformAnimation.Animation animation, float t) { }
}

// Namespace: 
private class TransformAnimation.Animator // TypeDefIndex: 14064
{
	// Fields
	private TransformAnimation.Animation m_Animation; // 0x10
	private float m_Time; // 0x18
	private float m_Cycle; // 0x1C
	private float m_Inverse; // 0x20
	private List<TransformAnimation.Animator.Node> m_Nodes; // 0x28

	// Methods

	// RVA: 0x23A6890 Offset: 0x23A6991 VA: 0x23A6890
	public void .ctor(TransformAnimation.Animation animation) { }

	// RVA: 0x23A6A60 Offset: 0x23A6B61 VA: 0x23A6A60
	public void Commit() { }

	// RVA: 0x23A6BA0 Offset: 0x23A6CA1 VA: 0x23A6BA0
	public void Update(float deltaTime) { }
}

