// Namespace: System.Xml.Schema
internal sealed class ParticleContentValidator : ContentValidator // TypeDefIndex: 1825
{
	// Fields
	private SymbolsDictionary symbols; // 0x18
	private Positions positions; // 0x20
	private Stack stack; // 0x28
	private SyntaxTreeNode contentNode; // 0x30
	private bool isPartial; // 0x38
	private int minMaxNodesCount; // 0x3C
	private bool enableUpaCheck; // 0x40

	// Methods

	// RVA: 0x3245E10 Offset: 0x3245F11 VA: 0x3245E10
	public void .ctor(XmlSchemaContentType contentType) { }

	// RVA: 0x3245E90 Offset: 0x3245F91 VA: 0x3245E90
	public void .ctor(XmlSchemaContentType contentType, bool enableUpaCheck) { }

	// RVA: 0x3245F20 Offset: 0x3246021 VA: 0x3245F20 Slot: 5
	public override void InitValidation(ValidationState context) { }

	// RVA: 0x3245F60 Offset: 0x3246061 VA: 0x3245F60 Slot: 6
	public override object ValidateElement(XmlQualifiedName name, ValidationState context, out int errorCode) { }

	// RVA: 0x3245FA0 Offset: 0x32460A1 VA: 0x3245FA0 Slot: 7
	public override bool CompleteValidation(ValidationState context) { }

	// RVA: 0x3245FE0 Offset: 0x32460E1 VA: 0x3245FE0
	public void Start() { }

	// RVA: 0x32461A0 Offset: 0x32462A1 VA: 0x32461A0
	public void OpenGroup() { }

	// RVA: 0x32461C0 Offset: 0x32462C1 VA: 0x32461C0
	public void CloseGroup() { }

	// RVA: 0x3246330 Offset: 0x3246431 VA: 0x3246330
	public bool Exists(XmlQualifiedName name) { }

	// RVA: 0x3246340 Offset: 0x3246441 VA: 0x3246340
	public void AddName(XmlQualifiedName name, object particle) { }

	// RVA: 0x3246550 Offset: 0x3246651 VA: 0x3246550
	public void AddNamespaceList(NamespaceList namespaceList, object particle) { }

	// RVA: 0x3246460 Offset: 0x3246561 VA: 0x3246460
	private void AddLeafNode(SyntaxTreeNode node) { }

	// RVA: 0x3246600 Offset: 0x3246701 VA: 0x3246600
	public void AddChoice() { }

	// RVA: 0x32466F0 Offset: 0x32467F1 VA: 0x32466F0
	public void AddSequence() { }

	// RVA: 0x32467E0 Offset: 0x32468E1 VA: 0x32467E0
	public void AddStar() { }

	// RVA: 0x32469E0 Offset: 0x3246AE1 VA: 0x32469E0
	public void AddPlus() { }

	// RVA: 0x3246A60 Offset: 0x3246B61 VA: 0x3246A60
	public void AddQMark() { }

	// RVA: 0x3246AD0 Offset: 0x3246BD1 VA: 0x3246AD0
	public void AddLeafRange(Decimal min, Decimal max) { }

	// RVA: 0x3246850 Offset: 0x3246951 VA: 0x3246850
	private void Closure(InteriorNode node) { }

	// RVA: 0x3246C40 Offset: 0x3246D41 VA: 0x3246C40
	public ContentValidator Finish(bool useDFA) { }

	// RVA: 0x3247280 Offset: 0x3247381 VA: 0x3247280
	private BitSet[] CalculateTotalFollowposForRangeNodes(BitSet firstpos, BitSet[] followpos, out BitSet posWithRangeTerminals) { }

	// RVA: 0x3247850 Offset: 0x3247951 VA: 0x3247850
	private void CheckCMUPAWithLeafRangeNodes(BitSet curpos) { }

	// RVA: 0x3247660 Offset: 0x3247761 VA: 0x3247660
	private BitSet GetApplicableMinMaxFollowPos(BitSet curpos, BitSet posWithRangeTerminals, BitSet[] minmaxFollowPos) { }

	// RVA: 0x3247A40 Offset: 0x3247B41 VA: 0x3247A40
	private void CheckUniqueParticleAttribution(BitSet firstpos, BitSet[] followpos) { }

	// RVA: 0x3248110 Offset: 0x3248211 VA: 0x3248110
	private void CheckUniqueParticleAttribution(BitSet curpos) { }

	// RVA: 0x3247AE0 Offset: 0x3247BE1 VA: 0x3247AE0
	private int[][] BuildTransitionTable(BitSet firstpos, BitSet[] followpos, int endMarkerPos) { }
}

