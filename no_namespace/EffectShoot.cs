// Namespace: 
public sealed class EffectShoot.Callback : MulticastDelegate // TypeDefIndex: 13999
{
	// Methods

	// RVA: 0x1F02780 Offset: 0x1F02881 VA: 0x1F02780
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1F027A0 Offset: 0x1F028A1 VA: 0x1F027A0 Slot: 13
	public virtual void Invoke(EffectShoot shoot) { }

	// RVA: 0x1F02B00 Offset: 0x1F02C01 VA: 0x1F02B00 Slot: 14
	public virtual IAsyncResult BeginInvoke(EffectShoot shoot, AsyncCallback callback, object object) { }

	// RVA: 0x1F02B30 Offset: 0x1F02C31 VA: 0x1F02B30 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

