// Namespace: 
public enum Account.SetupNsaResult // TypeDefIndex: 9124
{
	// Fields
	public int value__; // 0x0
	public const Account.SetupNsaResult Failed = 0;
	public const Account.SetupNsaResult Cancelled = 1;
	public const Account.SetupNsaResult Succeeded = 2;
}

// Namespace: 
public sealed class Account.SetupNsaResultFunction : MulticastDelegate // TypeDefIndex: 9125
{
	// Methods

	// RVA: 0x24AC150 Offset: 0x24AC251 VA: 0x24AC150
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x24AC170 Offset: 0x24AC271 VA: 0x24AC170 Slot: 13
	public virtual void Invoke(Account.SetupNsaResult result) { }

	// RVA: 0x24AC3D0 Offset: 0x24AC4D1 VA: 0x24AC3D0 Slot: 14
	public virtual IAsyncResult BeginInvoke(Account.SetupNsaResult result, AsyncCallback callback, object object) { }

	// RVA: 0x24AC460 Offset: 0x24AC561 VA: 0x24AC460 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
private enum Account.SetupNsaSequence.Label // TypeDefIndex: 9126
{
	// Fields
	public int value__; // 0x0
	public const Account.SetupNsaSequence.Label Ensure = 0;
	public const Account.SetupNsaSequence.Label EnsureIdTokenCache = 1;
	public const Account.SetupNsaSequence.Label Error = 2;
	public const Account.SetupNsaSequence.Label ShowError = 3;
	public const Account.SetupNsaSequence.Label Cancel = 4;
	public const Account.SetupNsaSequence.Label End = 5;
}

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

