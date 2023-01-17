// Namespace: MoonSharp.Interpreter.Interop.BasicDescriptors
public abstract class DispatchingUserDataDescriptor : IUserDataDescriptor, IOptimizableDescriptor // TypeDefIndex: 6162
{
	// Fields
	private int m_ExtMethodsVersion; // 0x10
	private Dictionary<string, IMemberDescriptor> m_MetaMembers; // 0x18
	private Dictionary<string, IMemberDescriptor> m_Members; // 0x20
	protected const string SPECIALNAME_INDEXER_GET = "get_Item";
	protected const string SPECIALNAME_INDEXER_SET = "set_Item";
	protected const string SPECIALNAME_CAST_EXPLICIT = "op_Explicit";
	protected const string SPECIALNAME_CAST_IMPLICIT = "op_Implicit";
	[CompilerGeneratedAttribute] // RVA: 0xE9F0 Offset: 0xEAF1 VA: 0xE9F0
	private string <Name>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0xEA00 Offset: 0xEB01 VA: 0xEA00
	private Type <Type>k__BackingField; // 0x30
	[CompilerGeneratedAttribute] // RVA: 0xEA10 Offset: 0xEB11 VA: 0xEA10
	private string <FriendlyName>k__BackingField; // 0x38

	// Properties
	public string Name { get; set; }
	public Type Type { get; set; }
	public string FriendlyName { get; set; }
	public IEnumerable<string> MemberNames { get; }
	public IEnumerable<KeyValuePair<string, IMemberDescriptor>> Members { get; }
	public IEnumerable<string> MetaMemberNames { get; }
	public IEnumerable<KeyValuePair<string, IMemberDescriptor>> MetaMembers { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x10C60 Offset: 0x10D61 VA: 0x10C60
	// RVA: 0x3100400 Offset: 0x3100501 VA: 0x3100400 Slot: 4
	public string get_Name() { }

	[CompilerGeneratedAttribute] // RVA: 0x10C70 Offset: 0x10D71 VA: 0x10C70
	// RVA: 0x3100410 Offset: 0x3100511 VA: 0x3100410
	private void set_Name(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x10C80 Offset: 0x10D81 VA: 0x10C80
	// RVA: 0x3100420 Offset: 0x3100521 VA: 0x3100420 Slot: 5
	public Type get_Type() { }

	[CompilerGeneratedAttribute] // RVA: 0x10C90 Offset: 0x10D91 VA: 0x10C90
	// RVA: 0x3100430 Offset: 0x3100531 VA: 0x3100430
	private void set_Type(Type value) { }

	[CompilerGeneratedAttribute] // RVA: 0x10CA0 Offset: 0x10DA1 VA: 0x10CA0
	// RVA: 0x3100440 Offset: 0x3100541 VA: 0x3100440
	public string get_FriendlyName() { }

	[CompilerGeneratedAttribute] // RVA: 0x10CB0 Offset: 0x10DB1 VA: 0x10CB0
	// RVA: 0x3100450 Offset: 0x3100551 VA: 0x3100450
	private void set_FriendlyName(string value) { }

	// RVA: 0x3100460 Offset: 0x3100561 VA: 0x3100460
	protected void .ctor(Type type, string friendlyName) { }

	// RVA: 0x3100580 Offset: 0x3100681 VA: 0x3100580
	public void AddMetaMember(string name, IMemberDescriptor desc) { }

	// RVA: 0x3100790 Offset: 0x3100891 VA: 0x3100790
	public void AddDynValue(string name, DynValue value) { }

	// RVA: 0x3100820 Offset: 0x3100921 VA: 0x3100820
	public void AddMember(string name, IMemberDescriptor desc) { }

	// RVA: 0x3100840 Offset: 0x3100941 VA: 0x3100840
	public IEnumerable<string> get_MemberNames() { }

	// RVA: 0x31008A0 Offset: 0x31009A1 VA: 0x31008A0
	public IEnumerable<KeyValuePair<string, IMemberDescriptor>> get_Members() { }

	// RVA: 0x31008B0 Offset: 0x31009B1 VA: 0x31008B0
	public IMemberDescriptor FindMember(string memberName) { }

	// RVA: 0x3100910 Offset: 0x3100A11 VA: 0x3100910
	public void RemoveMember(string memberName) { }

	// RVA: 0x3100970 Offset: 0x3100A71 VA: 0x3100970
	public IEnumerable<string> get_MetaMemberNames() { }

	// RVA: 0x31009D0 Offset: 0x3100AD1 VA: 0x31009D0
	public IEnumerable<KeyValuePair<string, IMemberDescriptor>> get_MetaMembers() { }

	// RVA: 0x31009E0 Offset: 0x3100AE1 VA: 0x31009E0
	public IMemberDescriptor FindMetaMember(string memberName) { }

	// RVA: 0x3100A40 Offset: 0x3100B41 VA: 0x3100A40
	public void RemoveMetaMember(string memberName) { }

	// RVA: 0x31005A0 Offset: 0x31006A1 VA: 0x31005A0
	private void AddMemberTo(Dictionary<string, IMemberDescriptor> members, string name, IMemberDescriptor desc) { }

	// RVA: 0x3100AA0 Offset: 0x3100BA1 VA: 0x3100AA0 Slot: 12
	public virtual DynValue Index(Script script, object obj, DynValue index, bool isDirectIndexing) { }

	// RVA: 0x3100F30 Offset: 0x3101031 VA: 0x3100F30
	private DynValue TryIndexOnExtMethod(Script script, object obj, string indexName) { }

	// RVA: 0x31010E0 Offset: 0x31011E1 VA: 0x31010E0
	public bool HasMember(string exactName) { }

	// RVA: 0x3101140 Offset: 0x3101241 VA: 0x3101140
	public bool HasMetaMember(string exactName) { }

	// RVA: 0x31011A0 Offset: 0x31012A1 VA: 0x31011A0 Slot: 13
	protected virtual DynValue TryIndex(Script script, object obj, string indexName) { }

	// RVA: 0x31012B0 Offset: 0x31013B1 VA: 0x31012B0 Slot: 14
	public virtual bool SetIndex(Script script, object obj, DynValue index, DynValue value, bool isDirectIndexing) { }

	// RVA: 0x3101560 Offset: 0x3101661 VA: 0x3101560 Slot: 15
	protected virtual bool TrySetIndex(Script script, object obj, string indexName, DynValue value) { }

	// RVA: 0x3101670 Offset: 0x3101771 VA: 0x3101670 Slot: 11
	private void MoonSharp.Interpreter.Interop.BasicDescriptors.IOptimizableDescriptor.Optimize() { }

	// RVA: 0x3100F20 Offset: 0x3101021 VA: 0x3100F20
	protected static string Camelify(string name) { }

	// RVA: 0x3100F10 Offset: 0x3101011 VA: 0x3100F10
	protected static string UpperFirstLetter(string name) { }

	// RVA: 0x3101C10 Offset: 0x3101D11 VA: 0x3101C10 Slot: 16
	public virtual string AsString(object obj) { }

	// RVA: 0x3101C30 Offset: 0x3101D31 VA: 0x3101C30 Slot: 17
	protected virtual DynValue ExecuteIndexer(IMemberDescriptor mdesc, Script script, object obj, DynValue index, DynValue value) { }

	// RVA: 0x3102060 Offset: 0x3102161 VA: 0x3102060 Slot: 18
	public virtual DynValue MetaIndex(Script script, object obj, string metaname) { }

	// RVA: 0x3102E30 Offset: 0x3102F31 VA: 0x3102E30
	private int PerformComparison(object obj, object p1, object p2) { }

	// RVA: 0x31029E0 Offset: 0x3102AE1 VA: 0x31029E0
	private DynValue MultiDispatchLessThanOrEqual(Script script, object obj) { }

	// RVA: 0x3102880 Offset: 0x3102981 VA: 0x3102880
	private DynValue MultiDispatchLessThan(Script script, object obj) { }

	// RVA: 0x3102B40 Offset: 0x3102C41 VA: 0x3102B40
	private DynValue TryDispatchLength(Script script, object obj) { }

	// RVA: 0x3102760 Offset: 0x3102861 VA: 0x3102760
	private DynValue MultiDispatchEqual(Script script, object obj) { }

	// RVA: 0x3102FE0 Offset: 0x31030E1 VA: 0x3102FE0
	private bool CheckEquality(object obj, object p1, object p2) { }

	// RVA: 0x3102660 Offset: 0x3102761 VA: 0x3102660
	private DynValue DispatchMetaOnMethod(Script script, object obj, string methodName) { }

	// RVA: 0x3102C60 Offset: 0x3102D61 VA: 0x3102C60
	private DynValue TryDispatchToNumber(Script script, object obj) { }

	// RVA: 0x3102D40 Offset: 0x3102E41 VA: 0x3102D40
	private DynValue TryDispatchToBool(Script script, object obj) { }

	// RVA: 0x3103060 Offset: 0x3103161 VA: 0x3103060 Slot: 19
	public virtual bool IsTypeCompatible(Type type, object obj) { }
}

