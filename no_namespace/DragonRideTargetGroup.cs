// Namespace: 
private class DragonRideTargetGroup.ChainSEManager // TypeDefIndex: 10545
{
	// Fields
	private const string cBigChainSE_Normal = "SE_DragonRide_Target_Big_01";
	private const string cBigChainSE_Special = "SE_DragonRide_Target_Big_02";
	private const string cBigChainSE_Double = "SE_DragonRide_Target_Big_03";
	private string[] cLinkChainSE; // 0x10
	private int[] cLinkSETable; // 0x18
	private string m_RootID; // 0x20
	private int m_ChainCount; // 0x28
	private bool m_IsLink; // 0x2C
	private bool m_IsSpecial; // 0x2D
	private bool m_IsDoubleEx; // 0x2E
	private float m_AliveLimitCounter; // 0x30
	[CompilerGeneratedAttribute] // RVA: 0x28F5A0 Offset: 0x28F6A1 VA: 0x28F5A0
	private bool <IsAlive>k__BackingField; // 0x34

	// Properties
	public bool IsAlive { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2BF2D0 Offset: 0x2BF3D1 VA: 0x2BF2D0
	// RVA: 0x1F014C0 Offset: 0x1F015C1 VA: 0x1F014C0
	public bool get_IsAlive() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BF2E0 Offset: 0x2BF3E1 VA: 0x2BF2E0
	// RVA: 0x1F014D0 Offset: 0x1F015D1 VA: 0x1F014D0
	private void set_IsAlive(bool value) { }

	// RVA: 0x1F014E0 Offset: 0x1F015E1 VA: 0x1F014E0
	public void .ctor() { }

	// RVA: 0x1F018D0 Offset: 0x1F019D1 VA: 0x1F018D0
	public void ResetChain() { }

	// RVA: 0x1F01930 Offset: 0x1F01A31 VA: 0x1F01930
	public void StartChain(string rootID, bool isLink, bool isSpecial, bool isDoubleEx) { }

	// RVA: 0x1F019F0 Offset: 0x1F01AF1 VA: 0x1F019F0
	public void TryPlayChainSE(ref DragonRideTarget targetScript) { }

	// RVA: 0x1F01C80 Offset: 0x1F01D81 VA: 0x1F01C80
	public void TickLimit() { }
}

