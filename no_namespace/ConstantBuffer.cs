// Namespace: 
internal abstract class ConstantBuffer.ConstantBufferBase // TypeDefIndex: 4512
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void Release();

	// RVA: 0x354EE00 Offset: 0x354EF01 VA: 0x354EE00
	protected void .ctor() { }
}

// Namespace: 
private class ConstantBuffer.TypedConstantBuffer<CBType> : ConstantBuffer.ConstantBufferBase // TypeDefIndex: 4513
{
	// Fields
	private HashSet<int> m_GlobalBindings; // 0x0
	private CBType[] m_Data; // 0x0
	private static ConstantBuffer.TypedConstantBuffer<CBType> s_Instance; // 0x0
	private ComputeBuffer m_GPUConstantBuffer; // 0x0

	// Properties
	internal static ConstantBuffer.TypedConstantBuffer<CBType> instance { get; set; }

	// Methods

	// RVA: -1 Offset: -1
	internal static ConstantBuffer.TypedConstantBuffer<CBType> get_instance() { }

	// RVA: -1 Offset: -1
	internal static void set_instance(ConstantBuffer.TypedConstantBuffer<CBType> value) { }

	// RVA: -1 Offset: -1
	private void .ctor() { }

	// RVA: -1 Offset: -1
	public void UpdateData(CommandBuffer cmd, in CBType data) { }

	// RVA: -1 Offset: -1
	public void SetGlobal(CommandBuffer cmd, int shaderId) { }

	// RVA: -1 Offset: -1
	public void Set(CommandBuffer cmd, ComputeShader cs, int shaderId) { }

	// RVA: -1 Offset: -1
	public void Set(Material mat, int shaderId) { }

	// RVA: -1 Offset: -1 Slot: 4
	public override void Release() { }

	// RVA: -1 Offset: -1
	private static void .cctor() { }
}

