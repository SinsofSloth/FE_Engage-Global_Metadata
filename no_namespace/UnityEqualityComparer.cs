// Namespace: 
private static class UnityEqualityComparer.Cache<T> // TypeDefIndex: 4892
{
	// Fields
	public static readonly IEqualityComparer<T> Comparer; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30C6140 Offset: 0x30C6241 VA: 0x30C6140
	|-UnityEqualityComparer.Cache<bool>..cctor
	|
	|-RVA: 0x30C6340 Offset: 0x30C6441 VA: 0x30C6340
	|-UnityEqualityComparer.Cache<Bounds>..cctor
	|
	|-RVA: 0x30C6540 Offset: 0x30C6641 VA: 0x30C6540
	|-UnityEqualityComparer.Cache<byte>..cctor
	|
	|-RVA: 0x30C6740 Offset: 0x30C6841 VA: 0x30C6740
	|-UnityEqualityComparer.Cache<Color>..cctor
	|
	|-RVA: 0x30C6940 Offset: 0x30C6A41 VA: 0x30C6940
	|-UnityEqualityComparer.Cache<double>..cctor
	|
	|-RVA: 0x30C6B40 Offset: 0x30C6C41 VA: 0x30C6B40
	|-UnityEqualityComparer.Cache<int>..cctor
	|
	|-RVA: 0x30C6D40 Offset: 0x30C6E41 VA: 0x30C6D40
	|-UnityEqualityComparer.Cache<long>..cctor
	|
	|-RVA: 0x30C6F40 Offset: 0x30C7041 VA: 0x30C6F40
	|-UnityEqualityComparer.Cache<object>..cctor
	|
	|-RVA: 0x30C7140 Offset: 0x30C7241 VA: 0x30C7140
	|-UnityEqualityComparer.Cache<Quaternion>..cctor
	|
	|-RVA: 0x30C7340 Offset: 0x30C7441 VA: 0x30C7340
	|-UnityEqualityComparer.Cache<Rect>..cctor
	|
	|-RVA: 0x30C7540 Offset: 0x30C7641 VA: 0x30C7540
	|-UnityEqualityComparer.Cache<float>..cctor
	|
	|-RVA: 0x30C7740 Offset: 0x30C7841 VA: 0x30C7740
	|-UnityEqualityComparer.Cache<Vector2>..cctor
	|
	|-RVA: 0x30C7940 Offset: 0x30C7A41 VA: 0x30C7940
	|-UnityEqualityComparer.Cache<Vector3>..cctor
	|
	|-RVA: 0x30C7B40 Offset: 0x30C7C41 VA: 0x30C7B40
	|-UnityEqualityComparer.Cache<Vector4>..cctor
	*/
}

// Namespace: 
private sealed class UnityEqualityComparer.Vector3EqualityComparer : IEqualityComparer<Vector3> // TypeDefIndex: 4894
{
	// Methods

	// RVA: 0x1C2E9C0 Offset: 0x1C2EAC1 VA: 0x1C2E9C0 Slot: 4
	public bool Equals(Vector3 self, Vector3 vector) { }

	// RVA: 0x1C2EA40 Offset: 0x1C2EB41 VA: 0x1C2EA40 Slot: 5
	public int GetHashCode(Vector3 obj) { }

	// RVA: 0x1C2EAB0 Offset: 0x1C2EBB1 VA: 0x1C2EAB0
	public void .ctor() { }
}

// Namespace: 
private sealed class UnityEqualityComparer.ColorEqualityComparer : IEqualityComparer<Color> // TypeDefIndex: 4896
{
	// Methods

	// RVA: 0x1C2E150 Offset: 0x1C2E251 VA: 0x1C2E150 Slot: 4
	public bool Equals(Color self, Color other) { }

	// RVA: 0x1C2E1F0 Offset: 0x1C2E2F1 VA: 0x1C2E1F0 Slot: 5
	public int GetHashCode(Color obj) { }

	// RVA: 0x1C2E280 Offset: 0x1C2E381 VA: 0x1C2E280
	public void .ctor() { }
}

// Namespace: 
private sealed class UnityEqualityComparer.BoundsEqualityComparer : IEqualityComparer<Bounds> // TypeDefIndex: 4898
{
	// Methods

	// RVA: 0x1C2DB30 Offset: 0x1C2DC31 VA: 0x1C2DB30 Slot: 4
	public bool Equals(Bounds self, Bounds vector) { }

	// RVA: 0x1C2DBC0 Offset: 0x1C2DCC1 VA: 0x1C2DBC0 Slot: 5
	public int GetHashCode(Bounds obj) { }

	// RVA: 0x1C2DC30 Offset: 0x1C2DD31 VA: 0x1C2DC30
	public void .ctor() { }
}

// Namespace: 
private sealed class UnityEqualityComparer.Color32EqualityComparer : IEqualityComparer<Color32> // TypeDefIndex: 4900
{
	// Methods

	// RVA: 0x1C2E030 Offset: 0x1C2E131 VA: 0x1C2E030 Slot: 4
	public bool Equals(Color32 self, Color32 vector) { }

	// RVA: 0x1C2E0C0 Offset: 0x1C2E1C1 VA: 0x1C2E0C0 Slot: 5
	public int GetHashCode(Color32 obj) { }

	// RVA: 0x1C2E140 Offset: 0x1C2E241 VA: 0x1C2E140
	public void .ctor() { }
}

// Namespace: 
private sealed class UnityEqualityComparer.Vector3IntEqualityComparer : IEqualityComparer<Vector3Int> // TypeDefIndex: 4902
{
	// Fields
	public static readonly UnityEqualityComparer.Vector3IntEqualityComparer Default; // 0x0

	// Methods

	// RVA: 0x1C2DD50 Offset: 0x1C2DE51 VA: 0x1C2DD50 Slot: 4
	public bool Equals(Vector3Int self, Vector3Int vector) { }

	// RVA: 0x1C2DF90 Offset: 0x1C2E091 VA: 0x1C2DF90 Slot: 5
	public int GetHashCode(Vector3Int obj) { }

	// RVA: 0x1C2EAC0 Offset: 0x1C2EBC1 VA: 0x1C2EAC0
	public void .ctor() { }

	// RVA: 0x1C2EAD0 Offset: 0x1C2EBD1 VA: 0x1C2EAD0
	private static void .cctor() { }
}

// Namespace: 
private sealed class UnityEqualityComparer.RectIntEqualityComparer : IEqualityComparer<RectInt> // TypeDefIndex: 4904
{
	// Methods

	// RVA: 0x1C2E650 Offset: 0x1C2E751 VA: 0x1C2E650 Slot: 4
	public bool Equals(RectInt self, RectInt other) { }

	// RVA: 0x1C2E750 Offset: 0x1C2E851 VA: 0x1C2E750 Slot: 5
	public int GetHashCode(RectInt obj) { }

	// RVA: 0x1C2E810 Offset: 0x1C2E911 VA: 0x1C2E810
	public void .ctor() { }
}

