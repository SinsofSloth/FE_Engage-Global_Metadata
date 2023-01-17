// Namespace: UnityEngine.Rendering.Universal
internal class ShaderData : IDisposable // TypeDefIndex: 5336
{
	// Fields
	private static ShaderData m_Instance; // 0x0
	private ComputeBuffer m_LightDataBuffer; // 0x10
	private ComputeBuffer m_LightIndicesBuffer; // 0x18
	private ComputeBuffer m_ShadowDataBuffer; // 0x20
	private ComputeBuffer m_ShadowIndicesBuffer; // 0x28

	// Properties
	internal static ShaderData instance { get; }

	// Methods

	// RVA: 0x312E700 Offset: 0x312E801 VA: 0x312E700
	private void .ctor() { }

	// RVA: 0x312E710 Offset: 0x312E811 VA: 0x312E710
	internal static ShaderData get_instance() { }

	// RVA: 0x312E7F0 Offset: 0x312E8F1 VA: 0x312E7F0 Slot: 4
	public void Dispose() { }

	// RVA: 0x312E8F0 Offset: 0x312E9F1 VA: 0x312E8F0
	internal ComputeBuffer GetLightDataBuffer(int size) { }

	// RVA: 0x312E950 Offset: 0x312EA51 VA: 0x312E950
	internal ComputeBuffer GetLightIndicesBuffer(int size) { }

	// RVA: 0x312E9B0 Offset: 0x312EAB1 VA: 0x312E9B0
	internal ComputeBuffer GetShadowDataBuffer(int size) { }

	// RVA: 0x312EA10 Offset: 0x312EB11 VA: 0x312EA10
	internal ComputeBuffer GetShadowIndicesBuffer(int size) { }

	// RVA: -1 Offset: -1
	private ComputeBuffer GetOrUpdateBuffer<T>(ref ComputeBuffer buffer, int size) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x201CC30 Offset: 0x201CD31 VA: 0x201CC30
	|-ShaderData.GetOrUpdateBuffer<int>
	|
	|-RVA: 0x201CD20 Offset: 0x201CE21 VA: 0x201CD20
	|-ShaderData.GetOrUpdateBuffer<ShaderInput.LightData>
	|
	|-RVA: 0x201CE10 Offset: 0x201CF11 VA: 0x201CE10
	|-ShaderData.GetOrUpdateBuffer<ShaderInput.ShadowData>
	*/

	// RVA: 0x312E8A0 Offset: 0x312E9A1 VA: 0x312E8A0
	private void DisposeBuffer(ref ComputeBuffer buffer) { }

	// RVA: 0x312EA70 Offset: 0x312EB71 VA: 0x312EA70
	private static void .cctor() { }
}

