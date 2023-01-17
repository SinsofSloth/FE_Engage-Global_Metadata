// Namespace: UnityEngine
[RequiredByNativeCodeAttribute] // RVA: 0x5C7C0 Offset: 0x5C8C1 VA: 0x5C7C0
[NativeHeaderAttribute] // RVA: 0x5C7C0 Offset: 0x5C8C1 VA: 0x5C7C0
[NativeClassAttribute] // RVA: 0x5C7C0 Offset: 0x5C8C1 VA: 0x5C7C0
public struct ContactPoint2D // TypeDefIndex: 4050
{
	// Fields
	[NativeNameAttribute] // RVA: 0x5CE70 Offset: 0x5CF71 VA: 0x5CE70
	private Vector2 m_Point; // 0x0
	[NativeNameAttribute] // RVA: 0x5CEB0 Offset: 0x5CFB1 VA: 0x5CEB0
	private Vector2 m_Normal; // 0x8
	[NativeNameAttribute] // RVA: 0x5CEF0 Offset: 0x5CFF1 VA: 0x5CEF0
	private Vector2 m_RelativeVelocity; // 0x10
	[NativeNameAttribute] // RVA: 0x5CF30 Offset: 0x5D031 VA: 0x5CF30
	private float m_Separation; // 0x18
	[NativeNameAttribute] // RVA: 0x5CF70 Offset: 0x5D071 VA: 0x5CF70
	private float m_NormalImpulse; // 0x1C
	[NativeNameAttribute] // RVA: 0x5CFB0 Offset: 0x5D0B1 VA: 0x5CFB0
	private float m_TangentImpulse; // 0x20
	[NativeNameAttribute] // RVA: 0x5CFF0 Offset: 0x5D0F1 VA: 0x5CFF0
	private int m_Collider; // 0x24
	[NativeNameAttribute] // RVA: 0x5D030 Offset: 0x5D131 VA: 0x5D030
	private int m_OtherCollider; // 0x28
	[NativeNameAttribute] // RVA: 0x5D070 Offset: 0x5D171 VA: 0x5D070
	private int m_Rigidbody; // 0x2C
	[NativeNameAttribute] // RVA: 0x5D0B0 Offset: 0x5D1B1 VA: 0x5D0B0
	private int m_OtherRigidbody; // 0x30
	[NativeNameAttribute] // RVA: 0x5D0F0 Offset: 0x5D1F1 VA: 0x5D0F0
	private int m_Enabled; // 0x34
}

// Namespace: UnityEngine
[UsedByNativeCodeAttribute] // RVA: 0x485C40 Offset: 0x485D41 VA: 0x485C40
[NativeHeaderAttribute] // RVA: 0x485C40 Offset: 0x485D41 VA: 0x485C40
public struct ContactPoint // TypeDefIndex: 4209
{
	// Fields
	internal Vector3 m_Point; // 0x0
	internal Vector3 m_Normal; // 0xC
	internal int m_ThisColliderInstanceID; // 0x18
	internal int m_OtherColliderInstanceID; // 0x1C
	internal float m_Separation; // 0x20
}

