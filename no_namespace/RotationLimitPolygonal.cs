// Namespace: 
[Serializable]
public class RotationLimitPolygonal.ReachCone // TypeDefIndex: 14436
{
	// Fields
	public Vector3[] tetrahedron; // 0x10
	public float volume; // 0x18
	public Vector3 S; // 0x1C
	public Vector3 B; // 0x28

	// Properties
	public Vector3 o { get; }
	public Vector3 a { get; }
	public Vector3 b { get; }
	public Vector3 c { get; }
	public bool isValid { get; }

	// Methods

	// RVA: 0x1F58CA0 Offset: 0x1F58DA1 VA: 0x1F58CA0
	public Vector3 get_o() { }

	// RVA: 0x1F58CD0 Offset: 0x1F58DD1 VA: 0x1F58CD0
	public Vector3 get_a() { }

	// RVA: 0x1F58D10 Offset: 0x1F58E11 VA: 0x1F58D10
	public Vector3 get_b() { }

	// RVA: 0x1F58D50 Offset: 0x1F58E51 VA: 0x1F58D50
	public Vector3 get_c() { }

	// RVA: 0x1F58D90 Offset: 0x1F58E91 VA: 0x1F58D90
	public void .ctor(Vector3 _o, Vector3 _a, Vector3 _b, Vector3 _c) { }

	// RVA: 0x1F58EF0 Offset: 0x1F58FF1 VA: 0x1F58EF0
	public bool get_isValid() { }

	// RVA: 0x1F58F00 Offset: 0x1F59001 VA: 0x1F58F00
	public void Calculate() { }
}

// Namespace: 
[Serializable]
public class RotationLimitPolygonal.LimitPoint // TypeDefIndex: 14437
{
	// Fields
	public Vector3 point; // 0x10
	public float tangentWeight; // 0x1C

	// Methods

	// RVA: 0x1F58C60 Offset: 0x1F58D61 VA: 0x1F58C60
	public void .ctor() { }
}

