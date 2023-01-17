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

