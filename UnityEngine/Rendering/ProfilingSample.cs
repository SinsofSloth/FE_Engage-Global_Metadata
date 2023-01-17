// Namespace: UnityEngine.Rendering
[ObsoleteAttribute] // RVA: 0x3B620 Offset: 0x3B721 VA: 0x3B620
public struct ProfilingSample : IDisposable // TypeDefIndex: 4591
{
	// Fields
	private readonly CommandBuffer m_Cmd; // 0x0
	private readonly string m_Name; // 0x8
	private bool m_Disposed; // 0x10
	private CustomSampler m_Sampler; // 0x18

	// Methods

	// RVA: 0x1A12DE0 Offset: 0x1A12EE1 VA: 0x1A12DE0
	public void .ctor(CommandBuffer cmd, string name, CustomSampler sampler) { }

	// RVA: 0x1A12EA0 Offset: 0x1A12FA1 VA: 0x1A12EA0
	public void .ctor(CommandBuffer cmd, string format, object arg) { }

	// RVA: 0x1A12F60 Offset: 0x1A13061 VA: 0x1A12F60
	public void .ctor(CommandBuffer cmd, string format, object[] args) { }

	// RVA: 0x1A13020 Offset: 0x1A13121 VA: 0x1A13020 Slot: 4
	public void Dispose() { }

	// RVA: 0x1A130B0 Offset: 0x1A131B1 VA: 0x1A130B0
	private void Dispose(bool disposing) { }
}

