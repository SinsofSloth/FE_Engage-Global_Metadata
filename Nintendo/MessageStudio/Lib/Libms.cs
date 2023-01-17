// Namespace: Nintendo.MessageStudio.Lib
public static class Libms // TypeDefIndex: 15041
{
	// Fields
	private const string LibmsDllFileName = "__Internal";

	// Methods

	// RVA: 0x1F8C6B0 Offset: 0x1F8C7B1 VA: 0x1F8C6B0
	private static void .cctor() { }

	[MonoPInvokeCallbackAttribute] // RVA: 0x2D2150 Offset: 0x2D2251 VA: 0x2D2150
	// RVA: 0x1F8C5D0 Offset: 0x1F8C6D1 VA: 0x1F8C5D0
	private static IntPtr Alloc(int size) { }

	[MonoPInvokeCallbackAttribute] // RVA: 0x2D21C0 Offset: 0x2D22C1 VA: 0x2D21C0
	// RVA: 0x1F8C640 Offset: 0x1F8C741 VA: 0x1F8C640
	private static void Free(IntPtr ptr) { }

	// RVA: 0x1F8C790 Offset: 0x1F8C891 VA: 0x1F8C790
	public static extern void LMS_SetMemFuncs(Libms.LMSMallocPtr pMalloc, Libms.LMSFreePtr pFree) { }

	// RVA: 0x1F8C7D0 Offset: 0x1F8C8D1 VA: 0x1F8C7D0
	public static extern IntPtr LMS_InitMessage(IntPtr pResource) { }

	// RVA: 0x1F8C7E0 Offset: 0x1F8C8E1 VA: 0x1F8C7E0
	public static extern void LMS_CloseMessage(IntPtr pFile) { }

	// RVA: 0x1F8C7F0 Offset: 0x1F8C8F1 VA: 0x1F8C7F0
	public static extern int LMS_SearchMessageBlockByName(IntPtr pFile, string pBlockName) { }

	// RVA: 0x1F8C840 Offset: 0x1F8C941 VA: 0x1F8C840
	public static extern IntPtr LMS_GetMessageBlockInfoByName(IntPtr pFile, string pBlockName) { }

	// RVA: 0x1F8C890 Offset: 0x1F8C991 VA: 0x1F8C890
	public static extern int LMS_GetTextNum(IntPtr pFile) { }

	// RVA: 0x1F8C8A0 Offset: 0x1F8C9A1 VA: 0x1F8C8A0
	public static extern int LMS_GetTextIndexByLabel(IntPtr pFile, string labelName) { }

	// RVA: 0x1F8C8F0 Offset: 0x1F8C9F1 VA: 0x1F8C8F0
	public static extern IntPtr LMS_GetText(IntPtr pFile, int nTextIndex) { }

	// RVA: 0x1F8C900 Offset: 0x1F8CA01 VA: 0x1F8C900
	public static extern int LMS_GetTextSize(IntPtr pFile, int nTextIndex) { }

	// RVA: 0x1F8C910 Offset: 0x1F8CA11 VA: 0x1F8C910
	public static extern IntPtr LMS_GetTextByLabel(IntPtr pFile, string labelName) { }

	// RVA: 0x1F8C960 Offset: 0x1F8CA61 VA: 0x1F8C960
	public static extern int LMS_GetLabelByTextIndex(IntPtr pFile, int nTextIndex, StringBuilder labelName) { }

	// RVA: 0x1F8C9D0 Offset: 0x1F8CAD1 VA: 0x1F8C9D0
	public static extern int LMS_GetTextStyle(IntPtr pFile, int nTextIndex) { }

	// RVA: 0x1F8C9E0 Offset: 0x1F8CAE1 VA: 0x1F8C9E0
	public static extern int LMS_GetTextStyleByLabel(IntPtr pFile, string labelName) { }

	// RVA: 0x1F8CA30 Offset: 0x1F8CB31 VA: 0x1F8CA30
	public static extern uint LMS_GetAttributeSize(IntPtr pFile) { }

	// RVA: 0x1F8CA40 Offset: 0x1F8CB41 VA: 0x1F8CA40
	public static extern IntPtr LMS_GetAttribute(IntPtr pFile, int index) { }

	// RVA: 0x1F8CA50 Offset: 0x1F8CB51 VA: 0x1F8CA50
	public static extern IntPtr LMS_GetAttributeText(IntPtr pFile, uint offset) { }

	// RVA: 0x1F8CA60 Offset: 0x1F8CB61 VA: 0x1F8CA60
	public static extern int LMS_GetAttrFilteredOffset(IntPtr pFile, int nAttrIndex) { }

	// RVA: 0x1F8CA70 Offset: 0x1F8CB71 VA: 0x1F8CA70
	public static extern IntPtr LMS_InitProject(IntPtr pResource) { }

	// RVA: 0x1F8CA80 Offset: 0x1F8CB81 VA: 0x1F8CA80
	public static extern void LMS_CloseProject(IntPtr pFile) { }

	// RVA: 0x1F8CA90 Offset: 0x1F8CB91 VA: 0x1F8CA90
	public static extern int LMS_SearchProjectBlockByName(IntPtr pFile, string pBlockName) { }

	// RVA: 0x1F8CAE0 Offset: 0x1F8CBE1 VA: 0x1F8CAE0
	public static extern int LMS_GetColorIndexByName(IntPtr pFile, string pName) { }

	// RVA: 0x1F8CB30 Offset: 0x1F8CC31 VA: 0x1F8CB30
	public static extern int LMS_GetColor(IntPtr pFile, int nColorIndex, ref LMSColor pColor) { }

	// RVA: 0x1F8CB40 Offset: 0x1F8CC41 VA: 0x1F8CB40
	public static extern int LMS_GetColorByName(IntPtr pFile, string pName, ref LMSColor pColor) { }

	// RVA: 0x1F8CBA0 Offset: 0x1F8CCA1 VA: 0x1F8CBA0
	public static extern int LMS_GetColorNum(IntPtr pFile) { }

	// RVA: 0x1F8CBB0 Offset: 0x1F8CCB1 VA: 0x1F8CBB0
	public static extern int LMS_GetContentsNum(IntPtr pFile) { }

	// RVA: 0x1F8CBC0 Offset: 0x1F8CCC1 VA: 0x1F8CBC0
	public static extern IntPtr LMS_GetContentPath(IntPtr pFile, int nContentIndex) { }

	// RVA: 0x1F8CBD0 Offset: 0x1F8CCD1 VA: 0x1F8CBD0
	public static extern int LMS_GetAttrInfoIndexByName(IntPtr pFile, string pName) { }

	// RVA: 0x1F8CC20 Offset: 0x1F8CD21 VA: 0x1F8CC20
	public static extern LibmsType LMS_GetAttrType(IntPtr pFile, int nAttrIndex) { }

	// RVA: 0x1F8CC30 Offset: 0x1F8CD31 VA: 0x1F8CC30
	public static extern int LMS_GetAttrOffset(IntPtr pFile, int nAttrIndex) { }

	// RVA: 0x1F8CC40 Offset: 0x1F8CD41 VA: 0x1F8CC40
	public static extern LibmsType LMS_GetAttrTypeByName(IntPtr pFile, string pName) { }

	// RVA: 0x1F8CC90 Offset: 0x1F8CD91 VA: 0x1F8CC90
	public static extern int LMS_GetAttrOffsetByName(IntPtr pFile, string pName) { }

	// RVA: 0x1F8CCE0 Offset: 0x1F8CDE1 VA: 0x1F8CCE0
	public static extern IntPtr LMS_GetAttrListItemName(IntPtr pFile, int nAttrIndex, int nItemIndex) { }

	// RVA: 0x1F8CCF0 Offset: 0x1F8CDF1 VA: 0x1F8CCF0
	public static extern IntPtr LMS_GetAttrListItemNameByName(IntPtr pFile, string pAttrName, int nItemIndex) { }

	// RVA: 0x1F8CD50 Offset: 0x1F8CE51 VA: 0x1F8CD50
	public static extern int LMS_GetAttrNum(IntPtr pFile) { }

	// RVA: 0x1F8CD60 Offset: 0x1F8CE61 VA: 0x1F8CD60
	public static extern int LMS_GetAttrListItemNum(IntPtr pFile, int nAttrIndex) { }

	// RVA: 0x1F8CD70 Offset: 0x1F8CE71 VA: 0x1F8CD70
	public static extern IntPtr LMS_GetTagGroupName(IntPtr pFile, ushort nGroupId) { }

	// RVA: 0x1F8CD80 Offset: 0x1F8CE81 VA: 0x1F8CD80
	public static extern IntPtr LMS_GetTagName(IntPtr pFile, ushort nGroupId, ushort nTagId) { }

	// RVA: 0x1F8CD90 Offset: 0x1F8CE91 VA: 0x1F8CD90
	public static extern IntPtr LMS_GetTagParamName(IntPtr pFile, ushort nGroupId, ushort nTagId, ushort nParamIndex) { }

	// RVA: 0x1F8CDA0 Offset: 0x1F8CEA1 VA: 0x1F8CDA0
	public static extern LibmsType LMS_GetTagParamType(IntPtr pFile, ushort nGroupId, ushort nTagId, ushort nParamIndex) { }

	// RVA: 0x1F8CDB0 Offset: 0x1F8CEB1 VA: 0x1F8CDB0
	public static extern IntPtr LMS_GetTagListItemName(IntPtr pFile, ushort nGroupId, ushort nTagId, ushort nParamIndex, ushort nItemIndex) { }

	// RVA: 0x1F8CDC0 Offset: 0x1F8CEC1 VA: 0x1F8CDC0
	public static extern int LMS_GetTagGroupNum(IntPtr pFile) { }

	// RVA: 0x1F8CDD0 Offset: 0x1F8CED1 VA: 0x1F8CDD0
	public static extern int LMS_GetTagNum(IntPtr pFile, ushort nGroupId) { }

	// RVA: 0x1F8CDE0 Offset: 0x1F8CEE1 VA: 0x1F8CDE0
	public static extern int LMS_GetTagParamNum(IntPtr pFile, ushort nGroupId, ushort nTagId) { }

	// RVA: 0x1F8CDF0 Offset: 0x1F8CEF1 VA: 0x1F8CDF0
	public static extern int LMS_GetTagListItemNum(IntPtr pFile, ushort nGroupId, ushort nTagId, ushort nParamIndex) { }

	// RVA: 0x1F8CE00 Offset: 0x1F8CF01 VA: 0x1F8CE00
	public static extern int LMS_GetStyleIndexByName(IntPtr pFile, string pStyleName) { }

	// RVA: 0x1F8CE50 Offset: 0x1F8CF51 VA: 0x1F8CE50
	public static extern int LMS_GetRegionWidth(IntPtr pFile, int nStyleIndex) { }

	// RVA: 0x1F8CE60 Offset: 0x1F8CF61 VA: 0x1F8CE60
	public static extern int LMS_GetRegionWidthByName(IntPtr pFile, string pStyleName) { }

	// RVA: 0x1F8CEB0 Offset: 0x1F8CFB1 VA: 0x1F8CEB0
	public static extern int LMS_GetLineNum(IntPtr pFile, int nStyleIndex) { }

	// RVA: 0x1F8CEC0 Offset: 0x1F8CFC1 VA: 0x1F8CEC0
	public static extern int LMS_GetLineNumByName(IntPtr pFile, string pStyleName) { }

	// RVA: 0x1F8CF10 Offset: 0x1F8D011 VA: 0x1F8CF10
	public static extern int LMS_GetFontIndex(IntPtr pFile, int nStyleIndex) { }

	// RVA: 0x1F8CF20 Offset: 0x1F8D021 VA: 0x1F8CF20
	public static extern int LMS_GetFontIndexByName(IntPtr pFile, string pStyleName) { }

	// RVA: 0x1F8CF70 Offset: 0x1F8D071 VA: 0x1F8CF70
	public static extern int LMS_GetBaseColorIndex(IntPtr pFile, int nStyleIndex) { }

	// RVA: 0x1F8CF80 Offset: 0x1F8D081 VA: 0x1F8CF80
	public static extern int LMS_GetBaseColorIndexByName(IntPtr pFile, string pStyleName) { }

	// RVA: 0x1F8CFD0 Offset: 0x1F8D0D1 VA: 0x1F8CFD0
	public static extern int LMS_GetStyleNum(IntPtr pFile) { }

	// RVA: 0x1F8CFE0 Offset: 0x1F8D0E1 VA: 0x1F8CFE0
	public static extern IntPtr LMS_InitFlowchart(IntPtr pResource) { }

	// RVA: 0x1F8CFF0 Offset: 0x1F8D0F1 VA: 0x1F8CFF0
	public static extern void LMS_CloseFlowchart(IntPtr pFile) { }

	// RVA: 0x1F8D000 Offset: 0x1F8D101 VA: 0x1F8D000
	public static extern int LMS_GetNodeNum(IntPtr pFile) { }

	// RVA: 0x1F8D010 Offset: 0x1F8D111 VA: 0x1F8D010
	public static extern int LMS_GetEntryNodeIndex(IntPtr pFile, string pLabel) { }

	// RVA: 0x1F8D060 Offset: 0x1F8D161 VA: 0x1F8D060
	public static extern IntPtr LMS_GetNodeDataPtr(IntPtr pFile, int index) { }

	// RVA: 0x1F8D070 Offset: 0x1F8D171 VA: 0x1F8D070
	public static extern int LMS_GetFlowNodeIndex(IntPtr pFile, IntPtr pNode) { }

	// RVA: 0x1F8D080 Offset: 0x1F8D181 VA: 0x1F8D080
	public static extern IntPtr LMS_GetCaseIndexesFromBranchNode(IntPtr pFile, int index) { }

	// RVA: 0x1F8D090 Offset: 0x1F8D191 VA: 0x1F8D090
	public static extern IntPtr LMS_GetFlowParamText(IntPtr pFile, int offset) { }
}

