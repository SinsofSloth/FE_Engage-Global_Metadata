// Namespace: 
public enum HubUtil.TimezoneType // TypeDefIndex: 10817
{
	// Fields
	public int value__; // 0x0
	public const HubUtil.TimezoneType Morning = 0;
	public const HubUtil.TimezoneType Day = 1;
	public const HubUtil.TimezoneType Evening = 2;
	public const HubUtil.TimezoneType Night = 3;
	public const HubUtil.TimezoneType Max = 4;
}

// Namespace: 
public enum HubUtil.ConditionType // TypeDefIndex: 10818
{
	// Fields
	public int value__; // 0x0
	[InspectorNameAttribute] // RVA: 0x295700 Offset: 0x295801 VA: 0x295700
	public const HubUtil.ConditionType Morning = 0;
	[InspectorNameAttribute] // RVA: 0x295740 Offset: 0x295841 VA: 0x295740
	public const HubUtil.ConditionType Day = 1;
	[InspectorNameAttribute] // RVA: 0x295780 Offset: 0x295881 VA: 0x295780
	public const HubUtil.ConditionType Evening = 2;
	[InspectorNameAttribute] // RVA: 0x2957C0 Offset: 0x2958C1 VA: 0x2957C0
	public const HubUtil.ConditionType Night = 3;
	[InspectorNameAttribute] // RVA: 0x295800 Offset: 0x295901 VA: 0x295800
	public const HubUtil.ConditionType WeaponOpened = 4;
	[InspectorNameAttribute] // RVA: 0x295840 Offset: 0x295941 VA: 0x295840
	public const HubUtil.ConditionType ItemOpened = 5;
	[InspectorNameAttribute] // RVA: 0x295880 Offset: 0x295981 VA: 0x295880
	public const HubUtil.ConditionType RefinementOpened = 6;
	[InspectorNameAttribute] // RVA: 0x2958C0 Offset: 0x2959C1 VA: 0x2958C0
	public const HubUtil.ConditionType AccessoryOpened = 7;
	[InspectorNameAttribute] // RVA: 0x295900 Offset: 0x295A01 VA: 0x295900
	public const HubUtil.ConditionType Tent1 = 8;
	[InspectorNameAttribute] // RVA: 0x295940 Offset: 0x295A41 VA: 0x295940
	public const HubUtil.ConditionType Tent2 = 9;
	[InspectorNameAttribute] // RVA: 0x295980 Offset: 0x295A81 VA: 0x295980
	public const HubUtil.ConditionType Tent3 = 10;
	[InspectorNameAttribute] // RVA: 0x2959C0 Offset: 0x295AC1 VA: 0x2959C0
	public const HubUtil.ConditionType Fire = 11;
	[InspectorNameAttribute] // RVA: 0x295A00 Offset: 0x295B01 VA: 0x295A00
	public const HubUtil.ConditionType FortuneHutOpened = 12;
	[InspectorNameAttribute] // RVA: 0x295A40 Offset: 0x295B41 VA: 0x295A40
	public const HubUtil.ConditionType FleaMarket = 13;
	[InspectorNameAttribute] // RVA: 0x295A80 Offset: 0x295B81 VA: 0x295A80
	public const HubUtil.ConditionType Statue = 14;
	[InspectorNameAttribute] // RVA: 0x295AC0 Offset: 0x295BC1 VA: 0x295AC0
	public const HubUtil.ConditionType PoolCircleSwim = 15;
}

// Namespace: 
public class HubUtil.BSpline // TypeDefIndex: 10819
{
	// Methods

	// RVA: 0x35F89A0 Offset: 0x35F8AA1 VA: 0x35F89A0
	private static int Loop(int n, int min, int max) { }

	// RVA: 0x35F89D0 Offset: 0x35F8AD1 VA: 0x35F89D0
	private static float Coefficient(float t) { }

	// RVA: 0x35F8A50 Offset: 0x35F8B51 VA: 0x35F8A50
	public static Vector3 Calc(Vector3[] v, float t) { }

	// RVA: 0x35F8BE0 Offset: 0x35F8CE1 VA: 0x35F8BE0
	public static Vector3 CalcLoop(Vector3[] v, float t) { }

	// RVA: 0x35F8D90 Offset: 0x35F8E91 VA: 0x35F8D90
	public void .ctor() { }
}

