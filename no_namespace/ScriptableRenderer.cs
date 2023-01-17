// Namespace: 
internal struct ScriptableRenderer.RenderBlocks : IDisposable // TypeDefIndex: 5275
{
	// Fields
	private NativeArray<RenderPassEvent> m_BlockEventLimits; // 0x0
	private NativeArray<int> m_BlockRanges; // 0x10
	private NativeArray<int> m_BlockRangeLengths; // 0x20

	// Methods

	// RVA: 0x2FA64F0 Offset: 0x2FA65F1 VA: 0x2FA64F0
	public void .ctor(List<ScriptableRenderPass> activeRenderPassQueue) { }

	// RVA: 0x2FA67F0 Offset: 0x2FA68F1 VA: 0x2FA67F0 Slot: 4
	public void Dispose() { }

	// RVA: 0x2FA66D0 Offset: 0x2FA67D1 VA: 0x2FA66D0
	private void FillBlockRanges(List<ScriptableRenderPass> activeRenderPassQueue) { }

	// RVA: 0x2FA6850 Offset: 0x2FA6951 VA: 0x2FA6850
	public int GetLength(int index) { }

	// RVA: 0x2FA6860 Offset: 0x2FA6961 VA: 0x2FA6860
	public ScriptableRenderer.RenderBlocks.BlockRange GetRange(int index) { }
}

