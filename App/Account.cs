// Namespace: App
public static class Account // TypeDefIndex: 9128
{
	// Fields
	private static UserHandle s_UserHandle; // 0x0
	private static Uid s_Uid; // 0x18
	private static bool s_IsNsaValid; // 0x28
	private static NetworkServiceAccountId s_NsaId; // 0x30
	private static byte[] s_NsaIdTokenCache; // 0x38

	// Properties
	public static UserHandle UserHandle { get; }
	public static Uid Uid { get; }
	public static NetworkServiceAccountId NsaId { get; }
	public static byte[] NsaIdTokenCache { get; }

	// Methods

	// RVA: 0x2B239D0 Offset: 0x2B23AD1 VA: 0x2B239D0
	public static void Initialize() { }

	// RVA: 0x2B23AE0 Offset: 0x2B23BE1 VA: 0x2B23AE0
	public static void SetupNsa(ProcInst super, bool isShowError, Account.SetupNsaResultFunction resultFunc) { }

	// RVA: 0x2B23AF0 Offset: 0x2B23BF1 VA: 0x2B23AF0
	public static bool IsUserValid() { }

	// RVA: 0x2B23B60 Offset: 0x2B23C61 VA: 0x2B23B60
	public static bool IsNsaValid() { }

	// RVA: 0x2B23BD0 Offset: 0x2B23CD1 VA: 0x2B23BD0
	public static string GetNickname() { }

	// RVA: 0x2B23E50 Offset: 0x2B23F51 VA: 0x2B23E50
	public static UserHandle get_UserHandle() { }

	// RVA: 0x2B23ED0 Offset: 0x2B23FD1 VA: 0x2B23ED0
	public static Uid get_Uid() { }

	// RVA: 0x2B23F40 Offset: 0x2B24041 VA: 0x2B23F40
	public static NetworkServiceAccountId get_NsaId() { }

	// RVA: 0x2B23FB0 Offset: 0x2B240B1 VA: 0x2B23FB0
	public static byte[] get_NsaIdTokenCache() { }

	// RVA: 0x2B24020 Offset: 0x2B24121 VA: 0x2B24020
	private static void .cctor() { }
}

