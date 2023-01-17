// Namespace: UnityEngine.Rendering
public struct RenderQueueRange : IEquatable<RenderQueueRange> // TypeDefIndex: 3953
{
	// Fields
	private int m_LowerBound; // 0x0
	private int m_UpperBound; // 0x4
	private const int k_MinimumBound = 0;
	public static readonly int minimumBound; // 0x0
	private const int k_MaximumBound = 5000;
	public static readonly int maximumBound; // 0x4

	// Properties
	public static RenderQueueRange all { get; }
	public static RenderQueueRange opaque { get; }
	public static RenderQueueRange transparent { get; }
	public int lowerBound { set; }
	public int upperBound { set; }

	// Methods

	// RVA: 0x31D9B90 Offset: 0x31D9C91 VA: 0x31D9B90
	public static RenderQueueRange get_all() { }

	// RVA: 0x31D9BA0 Offset: 0x31D9CA1 VA: 0x31D9BA0
	public static RenderQueueRange get_opaque() { }

	// RVA: 0x31D9BB0 Offset: 0x31D9CB1 VA: 0x31D9BB0
	public static RenderQueueRange get_transparent() { }

	// RVA: 0x31D9BC0 Offset: 0x31D9CC1 VA: 0x31D9BC0
	public void set_lowerBound(int value) { }

	// RVA: 0x31D9C90 Offset: 0x31D9D91 VA: 0x31D9C90
	public void set_upperBound(int value) { }

	// RVA: 0x31D9D60 Offset: 0x31D9E61 VA: 0x31D9D60 Slot: 4
	public bool Equals(RenderQueueRange other) { }

	// RVA: 0x31D9D90 Offset: 0x31D9E91 VA: 0x31D9D90 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x31D9E30 Offset: 0x31D9F31 VA: 0x31D9E30 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x31D9E50 Offset: 0x31D9F51 VA: 0x31D9E50
	private static void .cctor() { }
}

