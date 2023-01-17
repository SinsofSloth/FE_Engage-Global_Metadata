// Namespace: UnityEngine
[UsedByNativeCodeAttribute] // RVA: 0x43C190 Offset: 0x43C291 VA: 0x43C190
[NativeHeaderAttribute] // RVA: 0x43C190 Offset: 0x43C291 VA: 0x43C190
[Serializable]
public class RectOffset : IFormattable // TypeDefIndex: 3432
{
	// Fields
	[VisibleToOtherModulesAttribute] // RVA: 0x442780 Offset: 0x442881 VA: 0x442780
	internal IntPtr m_Ptr; // 0x10
	private readonly object m_SourceStyle; // 0x18

	// Properties
	[NativePropertyAttribute] // RVA: 0x459480 Offset: 0x459581 VA: 0x459480
	public int left { get; }
	[NativePropertyAttribute] // RVA: 0x4594C0 Offset: 0x4595C1 VA: 0x4594C0
	public int right { get; }
	[NativePropertyAttribute] // RVA: 0x459500 Offset: 0x459601 VA: 0x459500
	public int top { get; }
	[NativePropertyAttribute] // RVA: 0x459540 Offset: 0x459641 VA: 0x459540
	public int bottom { get; }
	public int horizontal { get; }
	public int vertical { get; }

	// Methods

	// RVA: 0x31D3890 Offset: 0x31D3991 VA: 0x31D3890
	public void .ctor() { }

	[VisibleToOtherModulesAttribute] // RVA: 0x4472D0 Offset: 0x4473D1 VA: 0x4472D0
	// RVA: 0x31D3920 Offset: 0x31D3A21 VA: 0x31D3920
	internal void .ctor(object sourceStyle, IntPtr source) { }

	// RVA: 0x31D3970 Offset: 0x31D3A71 VA: 0x31D3970 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x31D3AE0 Offset: 0x31D3BE1 VA: 0x31D3AE0 Slot: 3
	public override string ToString() { }

	// RVA: 0x31D3B70 Offset: 0x31D3C71 VA: 0x31D3B70 Slot: 4
	public string ToString(string format, IFormatProvider formatProvider) { }

	// RVA: 0x31D3A50 Offset: 0x31D3B51 VA: 0x31D3A50
	private void Destroy() { }

	[ThreadAndSerializationSafeAttribute] // RVA: 0x447360 Offset: 0x447461 VA: 0x447360
	// RVA: 0x31D38E0 Offset: 0x31D39E1 VA: 0x31D38E0
	private static IntPtr InternalCreate() { }

	[ThreadAndSerializationSafeAttribute] // RVA: 0x447370 Offset: 0x447471 VA: 0x447370
	// RVA: 0x31D3F40 Offset: 0x31D4041 VA: 0x31D3F40
	private static void InternalDestroy(IntPtr ptr) { }

	// RVA: 0x31D3E00 Offset: 0x31D3F01 VA: 0x31D3E00
	public int get_left() { }

	// RVA: 0x31D3E50 Offset: 0x31D3F51 VA: 0x31D3E50
	public int get_right() { }

	// RVA: 0x31D3EA0 Offset: 0x31D3FA1 VA: 0x31D3EA0
	public int get_top() { }

	// RVA: 0x31D3EF0 Offset: 0x31D3FF1 VA: 0x31D3EF0
	public int get_bottom() { }

	// RVA: 0x31D3F90 Offset: 0x31D4091 VA: 0x31D3F90
	public int get_horizontal() { }

	// RVA: 0x31D3FE0 Offset: 0x31D40E1 VA: 0x31D3FE0
	public int get_vertical() { }

	// RVA: 0x31D4030 Offset: 0x31D4131 VA: 0x31D4030
	public Rect Remove(Rect rect) { }

	// RVA: 0x31D40A0 Offset: 0x31D41A1 VA: 0x31D40A0
	private void Remove_Injected(ref Rect rect, out Rect ret) { }
}

