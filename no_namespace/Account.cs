// Namespace: 
private class Account.SetupNsaSequence : ProcInst // TypeDefIndex: 9127
{
	// Fields
	private bool m_IsShowError; // 0x70
	private Account.SetupNsaResultFunction m_ResultFunc; // 0x78
	private AsyncContext m_Context; // 0x80
	private Result m_Result; // 0x88

	// Methods

	// RVA: 0x24AC470 Offset: 0x24AC571 VA: 0x24AC470
	private void .ctor(bool isShowError, Account.SetupNsaResultFunction resultFunc) { }

	// RVA: 0x24AC530 Offset: 0x24AC631 VA: 0x24AC530
	private void Ensure() { }

	// RVA: 0x24AC710 Offset: 0x24AC811 VA: 0x24AC710
	private void EnsureIdTokenCache() { }

	// RVA: 0x24AC840 Offset: 0x24AC941 VA: 0x24AC840
	private void EnsureIdTokenCacheTick() { }

	// RVA: 0x24ACA20 Offset: 0x24ACB21 VA: 0x24ACA20
	private void Success() { }

	// RVA: 0x24ACAA0 Offset: 0x24ACBA1 VA: 0x24ACAA0
	private void CheckError() { }

	// RVA: 0x24ACBD0 Offset: 0x24ACCD1 VA: 0x24ACBD0
	private void ShowError() { }

	// RVA: 0x24ACC10 Offset: 0x24ACD11 VA: 0x24ACC10
	private void Cancel() { }

	// RVA: 0x24ACC20 Offset: 0x24ACD21 VA: 0x24ACC20
	public static void CreateBind(ProcInst super, bool isShowError, Account.SetupNsaResultFunction resultFunc) { }
}

