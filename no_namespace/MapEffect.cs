// Namespace: 
private class MapEffect.LocationNode : Pool.Node // TypeDefIndex: 11997
{
	// Fields
	public string Name; // 0x10
	public Vector3 Position; // 0x18
	public Quaternion Rotation; // 0x24
	public ResourceObject Effect; // 0x38

	// Methods

	// RVA: 0x1D3E7B0 Offset: 0x1D3E8B1 VA: 0x1D3E7B0 Slot: 4
	public override void OnEnter() { }

	// RVA: 0x1D3E7C0 Offset: 0x1D3E8C1 VA: 0x1D3E7C0 Slot: 5
	public override void OnExit() { }

	// RVA: 0x1D3E820 Offset: 0x1D3E921 VA: 0x1D3E820
	public bool IsMatch(string name, Vector3 position) { }

	// RVA: 0x1D3E8E0 Offset: 0x1D3E9E1 VA: 0x1D3E8E0
	public void TryCreateEffect() { }

	// RVA: 0x1D3EA60 Offset: 0x1D3EB61 VA: 0x1D3EA60
	public void TryDeleteEffect() { }

	// RVA: 0x1D3EB10 Offset: 0x1D3EC11 VA: 0x1D3EB10
	public void .ctor() { }
}

// Namespace: 
private class MapEffect.LocationPool : Pool.List<MapEffect.LocationNode> // TypeDefIndex: 11998
{
	// Methods

	// RVA: 0x1D3EB20 Offset: 0x1D3EC21 VA: 0x1D3EB20
	public void .ctor() { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x277DF0 Offset: 0x277EF1 VA: 0x277DF0
private sealed class MapEffect.<>c__DisplayClass35_0 // TypeDefIndex: 11999
{
	// Fields
	public Vector3 start; // 0x10
	public Vector3 goal; // 0x1C
	public float time; // 0x28
	public EffectShoot.Callback callback; // 0x30

	// Methods

	// RVA: 0x1D3E690 Offset: 0x1D3E791 VA: 0x1D3E690
	public void .ctor() { }

	// RVA: 0x1D3E6A0 Offset: 0x1D3E7A1 VA: 0x1D3E6A0
	internal void <Shoot>b__0(GameObject go) { }
}

