// Namespace: RootMotion
public class Hierarchy // TypeDefIndex: 14301
{
	// Methods

	// RVA: 0x2665C40 Offset: 0x2665D41 VA: 0x2665C40
	public static bool HierarchyIsValid(Transform[] bones) { }

	// RVA: 0x2665E30 Offset: 0x2665F31 VA: 0x2665E30
	public static Object ContainsDuplicate(Object[] objects) { }

	// RVA: 0x2665CE0 Offset: 0x2665DE1 VA: 0x2665CE0
	public static bool IsAncestor(Transform transform, Transform ancestor) { }

	// RVA: 0x2665F60 Offset: 0x2666061 VA: 0x2665F60
	public static bool ContainsChild(Transform transform, Transform child) { }

	// RVA: 0x2666080 Offset: 0x2666181 VA: 0x2666080
	public static void AddAncestors(Transform transform, Transform blocker, ref Transform[] array) { }

	// RVA: 0x26662B0 Offset: 0x26663B1 VA: 0x26662B0
	public static Transform GetAncestor(Transform transform, int minChildCount) { }

	// RVA: 0x26663B0 Offset: 0x26664B1 VA: 0x26663B0
	public static Transform GetFirstCommonAncestor(Transform t1, Transform t2) { }

	// RVA: 0x2666510 Offset: 0x2666611 VA: 0x2666510
	public static Transform GetFirstCommonAncestor(Transform[] transforms) { }

	// RVA: 0x2666790 Offset: 0x2666891 VA: 0x2666790
	public static Transform GetFirstCommonAncestorRecursive(Transform transform, Transform[] transforms) { }

	// RVA: 0x2666630 Offset: 0x2666731 VA: 0x2666630
	public static bool IsCommonAncestor(Transform transform, Transform[] transforms) { }

	// RVA: 0x26668E0 Offset: 0x26669E1 VA: 0x26668E0
	public void .ctor() { }
}

