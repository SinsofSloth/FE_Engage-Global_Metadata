// Namespace: 
public enum SpringBone.CollisionStatus // TypeDefIndex: 6400
{
	// Fields
	public int value__; // 0x0
	public const SpringBone.CollisionStatus NoCollision = 0;
	public const SpringBone.CollisionStatus HeadIsEmbedded = 1;
	public const SpringBone.CollisionStatus TailCollision = 2;
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x5B360 Offset: 0x5B461 VA: 0x5B360
[Serializable]
private sealed class SpringBone.<>c // TypeDefIndex: 6401
{
	// Fields
	public static readonly SpringBone.<>c <>9; // 0x0
	public static Func<SpringSphereCollider, bool> <>9__21_0; // 0x8
	public static Func<SpringCapsuleCollider, bool> <>9__21_1; // 0x10
	public static Func<SpringPanelCollider, bool> <>9__21_2; // 0x18
	public static Func<Transform, bool> <>9__21_3; // 0x20

	// Methods

	// RVA: 0x3A7A750 Offset: 0x3A7A851 VA: 0x3A7A750
	private static void .cctor() { }

	// RVA: 0x3A7A7C0 Offset: 0x3A7A8C1 VA: 0x3A7A7C0
	public void .ctor() { }

	// RVA: 0x3A7A7D0 Offset: 0x3A7A8D1 VA: 0x3A7A7D0
	internal bool <Initialize>b__21_0(SpringSphereCollider item) { }

	// RVA: 0x3A7A840 Offset: 0x3A7A941 VA: 0x3A7A840
	internal bool <Initialize>b__21_1(SpringCapsuleCollider item) { }

	// RVA: 0x3A7A8B0 Offset: 0x3A7A9B1 VA: 0x3A7A8B0
	internal bool <Initialize>b__21_2(SpringPanelCollider item) { }

	// RVA: 0x3A7A920 Offset: 0x3A7AA21 VA: 0x3A7A920
	internal bool <Initialize>b__21_3(Transform target) { }
}

