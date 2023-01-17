// Namespace: 
public enum RectTransform.Edge // TypeDefIndex: 3645
{
	// Fields
	public int value__; // 0x0
	public const RectTransform.Edge Left = 0;
	public const RectTransform.Edge Right = 1;
	public const RectTransform.Edge Top = 2;
	public const RectTransform.Edge Bottom = 3;
}

// Namespace: 
public enum RectTransform.Axis // TypeDefIndex: 3646
{
	// Fields
	public int value__; // 0x0
	public const RectTransform.Axis Horizontal = 0;
	public const RectTransform.Axis Vertical = 1;
}

// Namespace: 
public sealed class RectTransform.ReapplyDrivenProperties : MulticastDelegate // TypeDefIndex: 3647
{
	// Methods

	// RVA: 0x3855A50 Offset: 0x3855B51 VA: 0x3855A50
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3855A70 Offset: 0x3855B71 VA: 0x3855A70 Slot: 13
	public virtual void Invoke(RectTransform driven) { }

	// RVA: 0x3855DD0 Offset: 0x3855ED1 VA: 0x3855DD0 Slot: 14
	public virtual IAsyncResult BeginInvoke(RectTransform driven, AsyncCallback callback, object object) { }

	// RVA: 0x3855E00 Offset: 0x3855F01 VA: 0x3855E00 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

