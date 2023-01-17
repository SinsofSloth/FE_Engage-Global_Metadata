// Namespace: Combat
public class LocationParams : MonoBehaviour // TypeDefIndex: 8773
{
	// Fields
	public static LocationParams Instance; // 0x0
	public float[] EmblemPos; // 0x18
	public float FlyWinThreshold; // 0x20
	public bool LookCenter; // 0x24

	// Methods

	// RVA: 0x1F90700 Offset: 0x1F90801 VA: 0x1F90700
	private void Awake() { }

	// RVA: 0x1F90760 Offset: 0x1F90861 VA: 0x1F90760
	public static int GetIndex(LocationParams.LocateStyle l, LocationParams.UnitType u, LocationParams.EmblemType e, LocationParams.DataType d) { }

	// RVA: 0x1F90790 Offset: 0x1F90891 VA: 0x1F90790
	public static float GetEmblemGroundLevel(Character master, Character emblem) { }

	// RVA: 0x1F90A60 Offset: 0x1F90B61 VA: 0x1F90A60
	public static void LocateEmblem(Character master, Character emblem, Vector3 masterPos, Vector3 masterDir, LocationParams.LocateStyle style) { }

	// RVA: 0x1F90870 Offset: 0x1F90971 VA: 0x1F90870
	private static ValueTuple<float, float, float, LocationParams.UnitType, LocationParams.EmblemType> GetValues(Character master, Character emblem, LocationParams.LocateStyle style) { }

	// RVA: 0x1F91030 Offset: 0x1F91131 VA: 0x1F91030
	public void .ctor() { }
}

