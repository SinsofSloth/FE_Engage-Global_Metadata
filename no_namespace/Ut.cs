// Namespace: 
private class Ut.EnumList : List<object> // TypeDefIndex: 14091
{
	// Methods

	// RVA: 0x1EDD410 Offset: 0x1EDD511 VA: 0x1EDD410
	public void .ctor(Type type) { }

	// RVA: 0x1EDD720 Offset: 0x1EDD821 VA: 0x1EDD720
	public int GetIndex(object value) { }
}

// Namespace: 
public sealed class Ut.GameObjectFunction : MulticastDelegate // TypeDefIndex: 14092
{
	// Methods

	// RVA: 0x1EDD880 Offset: 0x1EDD981 VA: 0x1EDD880
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1EDD8A0 Offset: 0x1EDD9A1 VA: 0x1EDD8A0 Slot: 13
	public virtual void Invoke(GameObject go) { }

	// RVA: 0x1EDDC00 Offset: 0x1EDDD01 VA: 0x1EDDC00 Slot: 14
	public virtual IAsyncResult BeginInvoke(GameObject go, AsyncCallback callback, object object) { }

	// RVA: 0x1EDDC30 Offset: 0x1EDDD31 VA: 0x1EDDC30 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

