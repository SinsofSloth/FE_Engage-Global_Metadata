// Namespace: 
[Serializable]
public struct CinemachineFreeLook.Orbit // TypeDefIndex: 5754
{
	// Fields
	public float m_Height; // 0x0
	public float m_Radius; // 0x4

	// Methods

	// RVA: 0x1A89E50 Offset: 0x1A89F51 VA: 0x1A89E50
	public void .ctor(float h, float r) { }
}

// Namespace: 
public sealed class CinemachineFreeLook.DestroyRigDelegate : MulticastDelegate // TypeDefIndex: 5756
{
	// Methods

	// RVA: 0x1A89A90 Offset: 0x1A89B91 VA: 0x1A89A90
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1A89AB0 Offset: 0x1A89BB1 VA: 0x1A89AB0 Slot: 13
	public virtual void Invoke(GameObject rig) { }

	// RVA: 0x1A89E10 Offset: 0x1A89F11 VA: 0x1A89E10 Slot: 14
	public virtual IAsyncResult BeginInvoke(GameObject rig, AsyncCallback callback, object object) { }

	// RVA: 0x1A89E40 Offset: 0x1A89F41 VA: 0x1A89E40 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

