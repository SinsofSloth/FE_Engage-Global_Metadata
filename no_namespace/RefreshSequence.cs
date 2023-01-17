// Namespace: 
private enum RefreshSequence.Label // TypeDefIndex: 11696
{
	// Fields
	public int value__; // 0x0
	public const RefreshSequence.Label Entry = 0;
	public const RefreshSequence.Label LoadResources = 1;
	public const RefreshSequence.Label CreateRoot = 2;
	public const RefreshSequence.Label FacilitySelect = 3;
	public const RefreshSequence.Label CheckVisited = 4;
	public const RefreshSequence.Label UnitSet = 5;
	public const RefreshSequence.Label UnitSelect = 6;
	public const RefreshSequence.Label Confirm = 7;
	public const RefreshSequence.Label Demo = 8;
	public const RefreshSequence.Label Result = 9;
	public const RefreshSequence.Label End = 10;
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x277A80 Offset: 0x277B81 VA: 0x277A80
[Serializable]
private sealed class RefreshSequence.<>c // TypeDefIndex: 11697
{
	// Fields
	public static readonly RefreshSequence.<>c <>9; // 0x0
	public static RefreshFacilitySelectMenu.SelectEventHandler <>9__22_0; // 0x8
	public static RefreshFacilitySelectMenu.CloseEventHandler <>9__22_2; // 0x10

	// Methods

	// RVA: 0x1F398D0 Offset: 0x1F399D1 VA: 0x1F398D0
	private static void .cctor() { }

	// RVA: 0x1F39940 Offset: 0x1F39A41 VA: 0x1F39940
	public void .ctor() { }

	// RVA: 0x1F39950 Offset: 0x1F39A51 VA: 0x1F39950
	internal void <CreateFacilitySelectMenu>b__22_0(HubFacilityData data) { }

	// RVA: 0x1F39960 Offset: 0x1F39A61 VA: 0x1F39960
	internal void <CreateFacilitySelectMenu>b__22_2() { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x277A90 Offset: 0x277B91 VA: 0x277A90
private sealed class RefreshSequence.<>c__DisplayClass23_0 // TypeDefIndex: 11698
{
	// Fields
	public RefreshSequence <>4__this; // 0x10
	public Dictionary<string, Unit[]> unitArrayDic; // 0x18

	// Methods

	// RVA: 0x1F39970 Offset: 0x1F39A71 VA: 0x1F39970
	public void .ctor() { }

	// RVA: 0x1F39980 Offset: 0x1F39A81 VA: 0x1F39980
	internal void <CreateUnitSet>b__0(HubFacilityData facilityData) { }

	// RVA: 0x1F39990 Offset: 0x1F39A91 VA: 0x1F39990
	internal void <CreateUnitSet>b__1(int index, Unit unit) { }

	// RVA: 0x1F39B20 Offset: 0x1F39C21 VA: 0x1F39B20
	internal void <CreateUnitSet>b__2(RefreshUnitSetMenu.Result2 result, int index, HubFacilityData facilityData) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x277AA0 Offset: 0x277BA1 VA: 0x277AA0
private sealed class RefreshSequence.<>c__DisplayClass24_0 // TypeDefIndex: 11699
{
	// Fields
	public RefreshSequence <>4__this; // 0x10
	public int facilityIndex; // 0x18

	// Methods

	// RVA: 0x1F39DA0 Offset: 0x1F39EA1 VA: 0x1F39DA0
	public void .ctor() { }

	// RVA: 0x1F39DB0 Offset: 0x1F39EB1 VA: 0x1F39DB0
	internal void <CreateUnitSelect>b__0(Unit unit, string captionMid, string messageMid) { }

	// RVA: 0x1F39F70 Offset: 0x1F3A071 VA: 0x1F39F70
	internal void <CreateUnitSelect>b__1(Unit unit, bool isEntrust, int scrollIndex) { }

	// RVA: 0x1F3A110 Offset: 0x1F3A211 VA: 0x1F3A110
	internal void <CreateUnitSelect>b__2() { }

	// RVA: 0x1F3A130 Offset: 0x1F3A231 VA: 0x1F3A130
	internal void <CreateUnitSelect>b__3() { }
}

