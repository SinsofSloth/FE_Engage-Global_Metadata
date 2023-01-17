// Namespace: 
public sealed class AkTriggerBase.Trigger : MulticastDelegate // TypeDefIndex: 8053
{
	// Methods

	// RVA: 0x1F5B7C0 Offset: 0x1F5B8C1 VA: 0x1F5B7C0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1F5B7E0 Offset: 0x1F5B8E1 VA: 0x1F5B7E0 Slot: 13
	public virtual void Invoke(GameObject in_gameObject) { }

	// RVA: 0x1F5BB40 Offset: 0x1F5BC41 VA: 0x1F5BB40 Slot: 14
	public virtual IAsyncResult BeginInvoke(GameObject in_gameObject, AsyncCallback callback, object object) { }

	// RVA: 0x1F5BB70 Offset: 0x1F5BC71 VA: 0x1F5BB70 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
public abstract class AkTriggerBase : MonoBehaviour // TypeDefIndex: 8054
{
	// Fields
	public AkTriggerBase.Trigger triggerDelegate; // 0x18

	// Methods

	// RVA: 0x20DE6E0 Offset: 0x20DE7E1 VA: 0x20DE6E0
	public static Dictionary<uint, string> GetAllDerivedTypes() { }

	// RVA: 0x20DEA00 Offset: 0x20DEB01 VA: 0x20DEA00
	protected void .ctor() { }
}

