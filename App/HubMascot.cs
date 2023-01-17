// Namespace: App
internal class HubMascot // TypeDefIndex: 10826
{
	// Fields
	public static GameObject MascotObject; // 0x0
	private static Character m_CurrentCharacter; // 0x8
	private static Character m_LoadingCharacter; // 0x10
	private static Transform m_ParentTransform; // 0x18
	private static Transform m_PlayerTransform; // 0x20
	private static Vector3 m_Position; // 0x28
	private static Quaternion m_Rotation; // 0x34

	// Methods

	// RVA: 0x2BE1EA0 Offset: 0x2BE1FA1 VA: 0x2BE1EA0
	public static void Start(Transform parent, Transform player) { }

	// RVA: 0x2BE2390 Offset: 0x2BE2491 VA: 0x2BE2390
	public static void Load(bool requestFollowEnable) { }

	// RVA: 0x2BE2910 Offset: 0x2BE2A11 VA: 0x2BE2910
	public static void End() { }

	// RVA: 0x2BE2B30 Offset: 0x2BE2C31 VA: 0x2BE2B30
	public static void Stop() { }

	// RVA: 0x2BE2C10 Offset: 0x2BE2D11 VA: 0x2BE2C10
	public static void Restart() { }

	// RVA: 0x2BE2D10 Offset: 0x2BE2E11 VA: 0x2BE2D10
	public static void EnablePlayerFollow() { }

	// RVA: 0x2BE2DF0 Offset: 0x2BE2EF1 VA: 0x2BE2DF0
	public static void DisablePlayerFollow() { }

	// RVA: 0x2BE2ED0 Offset: 0x2BE2FD1 VA: 0x2BE2ED0
	public static void ChangeMascotColor() { }

	// RVA: 0x2BE3100 Offset: 0x2BE3201 VA: 0x2BE3100
	public void .ctor() { }

	// RVA: 0x2BE3110 Offset: 0x2BE3211 VA: 0x2BE3110
	private static void .cctor() { }
}

