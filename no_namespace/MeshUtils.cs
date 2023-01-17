// Namespace: 
public abstract class MeshUtils.Pooled<T> // TypeDefIndex: 5511
{
	// Fields
	private static Stack<T> _stack; // 0x0

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void Reset();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-MeshUtils.Pooled<object>.Reset
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public virtual void OnFree() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A61810 Offset: 0x2A61911 VA: 0x2A61810
	|-MeshUtils.Pooled<object>.OnFree
	|-MeshUtils.Pooled<MeshUtils.Edge>.OnFree
	|-MeshUtils.Pooled<MeshUtils.Face>.OnFree
	|-MeshUtils.Pooled<MeshUtils.Vertex>.OnFree
	*/

	// RVA: -1 Offset: -1
	public static T Create() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A61820 Offset: 0x2A61921 VA: 0x2A61820
	|-MeshUtils.Pooled<object>.Create
	|-MeshUtils.Pooled<MeshUtils.Edge>.Create
	|-MeshUtils.Pooled<MeshUtils.Face>.Create
	|-MeshUtils.Pooled<MeshUtils.Vertex>.Create
	*/

	// RVA: -1 Offset: -1
	public void Free() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A61A10 Offset: 0x2A61B11 VA: 0x2A61A10
	|-MeshUtils.Pooled<Mesh>.Free
	|-MeshUtils.Pooled<object>.Free
	|-MeshUtils.Pooled<MeshUtils.Edge>.Free
	|-MeshUtils.Pooled<MeshUtils.Face>.Free
	|-MeshUtils.Pooled<MeshUtils.Vertex>.Free
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A61B70 Offset: 0x2A61C71 VA: 0x2A61B70
	|-MeshUtils.Pooled<Mesh>..ctor
	|-MeshUtils.Pooled<object>..ctor
	|-MeshUtils.Pooled<MeshUtils.Edge>..ctor
	|-MeshUtils.Pooled<MeshUtils.Face>..ctor
	|-MeshUtils.Pooled<MeshUtils.Vertex>..ctor
	*/
}

// Namespace: 
public class MeshUtils.Vertex : MeshUtils.Pooled<MeshUtils.Vertex> // TypeDefIndex: 5512
{
	// Fields
	internal MeshUtils.Vertex _prev; // 0x10
	internal MeshUtils.Vertex _next; // 0x18
	internal MeshUtils.Edge _anEdge; // 0x20
	internal Vec3 _coords; // 0x28
	internal float _s; // 0x34
	internal float _t; // 0x38
	internal PQHandle _pqHandle; // 0x3C
	internal int _n; // 0x40
	internal object _data; // 0x48

	// Methods

	// RVA: 0x2FA3C30 Offset: 0x2FA3D31 VA: 0x2FA3C30 Slot: 4
	public override void Reset() { }

	// RVA: 0x2FA3CF0 Offset: 0x2FA3DF1 VA: 0x2FA3CF0
	public void .ctor() { }
}

// Namespace: 
public class MeshUtils.Face : MeshUtils.Pooled<MeshUtils.Face> // TypeDefIndex: 5513
{
	// Fields
	internal MeshUtils.Face _prev; // 0x10
	internal MeshUtils.Face _next; // 0x18
	internal MeshUtils.Edge _anEdge; // 0x20
	internal MeshUtils.Face _trail; // 0x28
	internal int _n; // 0x30
	internal bool _marked; // 0x34
	internal bool _inside; // 0x35

	// Properties
	internal int VertsCount { get; }

	// Methods

	// RVA: 0x2FA3B40 Offset: 0x2FA3C41 VA: 0x2FA3B40
	internal int get_VertsCount() { }

	// RVA: 0x2FA3B70 Offset: 0x2FA3C71 VA: 0x2FA3B70 Slot: 4
	public override void Reset() { }

	// RVA: 0x2FA3BD0 Offset: 0x2FA3CD1 VA: 0x2FA3BD0
	public void .ctor() { }
}

// Namespace: 
public struct MeshUtils.EdgePair // TypeDefIndex: 5514
{
	// Fields
	internal MeshUtils.Edge _e; // 0x0
	internal MeshUtils.Edge _eSym; // 0x8

	// Methods

	// RVA: 0x2FA3A80 Offset: 0x2FA3B81 VA: 0x2FA3A80
	public static MeshUtils.EdgePair Create() { }

	// RVA: 0x2FA39E0 Offset: 0x2FA3AE1 VA: 0x2FA39E0
	public void Reset() { }
}

// Namespace: 
public class MeshUtils.Edge : MeshUtils.Pooled<MeshUtils.Edge> // TypeDefIndex: 5515
{
	// Fields
	internal MeshUtils.EdgePair _pair; // 0x10
	internal MeshUtils.Edge _next; // 0x20
	internal MeshUtils.Edge _Sym; // 0x28
	internal MeshUtils.Edge _Onext; // 0x30
	internal MeshUtils.Edge _Lnext; // 0x38
	internal MeshUtils.Vertex _Org; // 0x40
	internal MeshUtils.Face _Lface; // 0x48
	internal Tess.ActiveRegion _activeRegion; // 0x50
	internal int _winding; // 0x58

	// Properties
	internal MeshUtils.Face _Rface { get; set; }
	internal MeshUtils.Vertex _Dst { get; set; }
	internal MeshUtils.Edge _Oprev { get; set; }
	internal MeshUtils.Edge _Lprev { get; set; }
	internal MeshUtils.Edge _Dprev { get; set; }
	internal MeshUtils.Edge _Rprev { get; set; }
	internal MeshUtils.Edge _Dnext { get; set; }
	internal MeshUtils.Edge _Rnext { get; set; }

	// Methods

	// RVA: 0x2FA3810 Offset: 0x2FA3911 VA: 0x2FA3810
	internal MeshUtils.Face get__Rface() { }

	// RVA: 0x2FA3820 Offset: 0x2FA3921 VA: 0x2FA3820
	internal void set__Rface(MeshUtils.Face value) { }

	// RVA: 0x2FA3830 Offset: 0x2FA3931 VA: 0x2FA3830
	internal MeshUtils.Vertex get__Dst() { }

	// RVA: 0x2FA3840 Offset: 0x2FA3941 VA: 0x2FA3840
	internal void set__Dst(MeshUtils.Vertex value) { }

	// RVA: 0x2FA3850 Offset: 0x2FA3951 VA: 0x2FA3850
	internal MeshUtils.Edge get__Oprev() { }

	// RVA: 0x2FA3860 Offset: 0x2FA3961 VA: 0x2FA3860
	internal void set__Oprev(MeshUtils.Edge value) { }

	// RVA: 0x2FA3870 Offset: 0x2FA3971 VA: 0x2FA3870
	internal MeshUtils.Edge get__Lprev() { }

	// RVA: 0x2FA3880 Offset: 0x2FA3981 VA: 0x2FA3880
	internal void set__Lprev(MeshUtils.Edge value) { }

	// RVA: 0x2FA3890 Offset: 0x2FA3991 VA: 0x2FA3890
	internal MeshUtils.Edge get__Dprev() { }

	// RVA: 0x2FA38A0 Offset: 0x2FA39A1 VA: 0x2FA38A0
	internal void set__Dprev(MeshUtils.Edge value) { }

	// RVA: 0x2FA38B0 Offset: 0x2FA39B1 VA: 0x2FA38B0
	internal MeshUtils.Edge get__Rprev() { }

	// RVA: 0x2FA38C0 Offset: 0x2FA39C1 VA: 0x2FA38C0
	internal void set__Rprev(MeshUtils.Edge value) { }

	// RVA: 0x2FA38D0 Offset: 0x2FA39D1 VA: 0x2FA38D0
	internal MeshUtils.Edge get__Dnext() { }

	// RVA: 0x2FA38E0 Offset: 0x2FA39E1 VA: 0x2FA38E0
	internal void set__Dnext(MeshUtils.Edge value) { }

	// RVA: 0x2FA38F0 Offset: 0x2FA39F1 VA: 0x2FA38F0
	internal MeshUtils.Edge get__Rnext() { }

	// RVA: 0x2FA3900 Offset: 0x2FA3A01 VA: 0x2FA3900
	internal void set__Rnext(MeshUtils.Edge value) { }

	// RVA: 0x2FA3910 Offset: 0x2FA3A11 VA: 0x2FA3910
	internal static void EnsureFirst(ref MeshUtils.Edge e) { }

	// RVA: 0x2FA3930 Offset: 0x2FA3A31 VA: 0x2FA3930 Slot: 4
	public override void Reset() { }

	// RVA: 0x2FA3A20 Offset: 0x2FA3B21 VA: 0x2FA3A20
	public void .ctor() { }
}

