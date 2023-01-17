// Namespace: UnityEngine.Rendering
public class BufferedRTHandleSystem : IDisposable // TypeDefIndex: 4602
{
	// Fields
	private Dictionary<int, RTHandle[]> m_RTHandles; // 0x10
	private RTHandleSystem m_RTHandleSystem; // 0x18
	private bool m_DisposedValue; // 0x20

	// Properties
	public int maxWidth { get; }
	public int maxHeight { get; }
	public RTHandleProperties rtHandleProperties { get; }

	// Methods

	// RVA: 0x1B29CC0 Offset: 0x1B29DC1 VA: 0x1B29CC0
	public int get_maxWidth() { }

	// RVA: 0x1B29CD0 Offset: 0x1B29DD1 VA: 0x1B29CD0
	public int get_maxHeight() { }

	// RVA: 0x1B29CE0 Offset: 0x1B29DE1 VA: 0x1B29CE0
	public RTHandleProperties get_rtHandleProperties() { }

	// RVA: 0x1B29D00 Offset: 0x1B29E01 VA: 0x1B29D00
	public RTHandle GetFrameRT(int bufferId, int frameIndex) { }

	// RVA: 0x1B29DC0 Offset: 0x1B29EC1 VA: 0x1B29DC0
	public void AllocBuffer(int bufferId, Func<RTHandleSystem, int, RTHandle> allocator, int bufferCount) { }

	// RVA: 0x1B29F70 Offset: 0x1B2A071 VA: 0x1B29F70
	public void ReleaseBuffer(int bufferId) { }

	// RVA: 0x1B2A060 Offset: 0x1B2A161 VA: 0x1B2A060
	public void SwapAndSetReferenceSize(int width, int height, MSAASamples msaaSamples) { }

	// RVA: 0x1B2A3A0 Offset: 0x1B2A4A1 VA: 0x1B2A3A0
	public void ResetReferenceSize(int width, int height) { }

	// RVA: 0x1B2A0B0 Offset: 0x1B2A1B1 VA: 0x1B2A0B0
	private void Swap() { }

	// RVA: 0x1B2A3B0 Offset: 0x1B2A4B1 VA: 0x1B2A3B0
	private void Dispose(bool disposing) { }

	// RVA: 0x1B2A5C0 Offset: 0x1B2A6C1 VA: 0x1B2A5C0 Slot: 4
	public void Dispose() { }

	// RVA: 0x1B2A420 Offset: 0x1B2A521 VA: 0x1B2A420
	public void ReleaseAll() { }

	// RVA: 0x1B2A620 Offset: 0x1B2A721 VA: 0x1B2A620
	public void .ctor() { }
}

