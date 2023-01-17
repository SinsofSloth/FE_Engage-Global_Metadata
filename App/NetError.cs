// Namespace: App
internal static class NetError // TypeDefIndex: 12719
{
	// Fields
	private static NetError.Kind s_Kind; // 0x0
	private static Result s_Result; // 0x4
	private static NetError.App s_App; // 0x8

	// Methods

	// RVA: 0x23540B0 Offset: 0x23541B1 VA: 0x23540B0
	public static void Show(ProcInst super) { }

	// RVA: 0x2354230 Offset: 0x2354331 VA: 0x2354230
	public static void Show(Result result) { }

	// RVA: 0x2354270 Offset: 0x2354371 VA: 0x2354270
	public static void Show(ProcInst super, NetError.App app) { }

	// RVA: 0x23543B0 Offset: 0x23544B1 VA: 0x23543B0
	public static void Clear() { }

	// RVA: 0x2354430 Offset: 0x2354531 VA: 0x2354430
	public static void SetError(AsyncResult error) { }

	// RVA: 0x23544B0 Offset: 0x23545B1 VA: 0x23544B0
	public static void SetError(Result error) { }

	// RVA: 0x2354530 Offset: 0x2354631 VA: 0x2354530
	public static void SetError(NetError.App error) { }

	// RVA: 0x23545B0 Offset: 0x23546B1 VA: 0x23545B0
	private static void .cctor() { }
}

