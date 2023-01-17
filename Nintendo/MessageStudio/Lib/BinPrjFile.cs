// Namespace: Nintendo.MessageStudio.Lib
public class BinPrjFile : BinLibmsFileBase // TypeDefIndex: 15027
{
	// Methods

	// RVA: 0x22654A0 Offset: 0x22655A1 VA: 0x22654A0 Slot: 5
	protected override IntPtr InitObject(IntPtr resourcePtr) { }

	// RVA: 0x2265510 Offset: 0x2265611 VA: 0x2265510 Slot: 6
	protected override void CloseObject(IntPtr objectPtr) { }

	// RVA: 0x2265580 Offset: 0x2265681 VA: 0x2265580
	public int SearchProjectBlock(string name) { }

	// RVA: 0x2265600 Offset: 0x2265701 VA: 0x2265600
	public int GetColorIndex(string name) { }

	// RVA: 0x2265680 Offset: 0x2265781 VA: 0x2265680
	public LMSColor GetColor(int index) { }

	// RVA: 0x2265710 Offset: 0x2265811 VA: 0x2265710
	public LMSColor GetColor(string name) { }

	// RVA: 0x22657A0 Offset: 0x22658A1 VA: 0x22657A0
	public int GetColorNum() { }

	// RVA: 0x2265810 Offset: 0x2265911 VA: 0x2265810
	public int GetContentsNum() { }

	// RVA: 0x2265880 Offset: 0x2265981 VA: 0x2265880
	public string GetContentPath(int index) { }

	// RVA: 0x2265940 Offset: 0x2265A41 VA: 0x2265940
	public int GetAttrInfoIndex(string name) { }

	// RVA: 0x22659C0 Offset: 0x2265AC1 VA: 0x22659C0
	public LibmsType GetAttrType(int index) { }

	// RVA: 0x2265A40 Offset: 0x2265B41 VA: 0x2265A40
	public LibmsType GetAttrType(string name) { }

	// RVA: 0x2265AC0 Offset: 0x2265BC1 VA: 0x2265AC0
	public int GetAttrOffset(int index) { }

	// RVA: 0x2265B40 Offset: 0x2265C41 VA: 0x2265B40
	public int GetAttrOffset(string name) { }

	// RVA: 0x2265BC0 Offset: 0x2265CC1 VA: 0x2265BC0
	public string GetAttrListItemName(int attrIndex, int itemIndex) { }

	// RVA: 0x2265C90 Offset: 0x2265D91 VA: 0x2265C90
	public string GetAttrListItemName(string attrName, int itemIndex) { }

	// RVA: 0x2265D60 Offset: 0x2265E61 VA: 0x2265D60
	public int GetAttrNum() { }

	// RVA: 0x2265DD0 Offset: 0x2265ED1 VA: 0x2265DD0
	public int GetAttrListItemNum(int attrIndex) { }

	// RVA: 0x2265E50 Offset: 0x2265F51 VA: 0x2265E50
	public string GetTagGroupName(ushort groupId) { }

	// RVA: 0x2265F10 Offset: 0x2266011 VA: 0x2265F10
	public string GetTagName(ushort groupId, ushort tagId) { }

	// RVA: 0x2265FE0 Offset: 0x22660E1 VA: 0x2265FE0
	public string GetTagParamName(ushort groupId, ushort tagId, ushort paramId) { }

	// RVA: 0x22660B0 Offset: 0x22661B1 VA: 0x22660B0
	public LibmsType GetTagParamType(ushort groupId, ushort tagId, ushort paramId) { }

	// RVA: 0x2266140 Offset: 0x2266241 VA: 0x2266140
	public string GetTagListItemName(ushort groupId, ushort tagId, ushort paramId, ushort itemIndex) { }

	// RVA: 0x2266220 Offset: 0x2266321 VA: 0x2266220
	public int GetTagGroupNum() { }

	// RVA: 0x2266290 Offset: 0x2266391 VA: 0x2266290
	public int GetTagNum(ushort groupId) { }

	// RVA: 0x2266310 Offset: 0x2266411 VA: 0x2266310
	public int GetTagParamNum(ushort groupId, ushort tagId) { }

	// RVA: 0x22663A0 Offset: 0x22664A1 VA: 0x22663A0
	public int GetTagListItemNum(ushort groupId, ushort tagId, ushort paramId) { }

	// RVA: 0x2266430 Offset: 0x2266531 VA: 0x2266430
	public int GetStyleIndex(string name) { }

	// RVA: 0x22664B0 Offset: 0x22665B1 VA: 0x22664B0
	public int GetRegionWidth(int index) { }

	// RVA: 0x2266530 Offset: 0x2266631 VA: 0x2266530
	public int GetRegionWidth(string name) { }

	// RVA: 0x22665B0 Offset: 0x22666B1 VA: 0x22665B0
	public int GetLineNum(int index) { }

	// RVA: 0x2266630 Offset: 0x2266731 VA: 0x2266630
	public int GetLineNum(string name) { }

	// RVA: 0x22666B0 Offset: 0x22667B1 VA: 0x22666B0
	public int GetFontIndex(int index) { }

	// RVA: 0x2266730 Offset: 0x2266831 VA: 0x2266730
	public int GetFontIndex(string name) { }

	// RVA: 0x22667B0 Offset: 0x22668B1 VA: 0x22667B0
	public int GetBaseColorIndex(int index) { }

	// RVA: 0x2266830 Offset: 0x2266931 VA: 0x2266830
	public int GetBaseColorIndex(string name) { }

	// RVA: 0x22668B0 Offset: 0x22669B1 VA: 0x22668B0
	public int GetStyleNum() { }

	// RVA: 0x2266920 Offset: 0x2266A21 VA: 0x2266920
	public void .ctor() { }
}

