// Namespace: 
public abstract class MapUnitCommandMenu.JumpToMenuItem : MapUnitCommandMenu.BaseMenuItem // TypeDefIndex: 12302
{
	// Properties
	protected abstract MapSequenceHuman.Label Label { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 36
	protected abstract MapSequenceHuman.Label get_Label();

	// RVA: 0x2146420 Offset: 0x2146521 VA: 0x2146420
	protected void JumpSequence() { }

	// RVA: 0x214A3B0 Offset: 0x214A4B1 VA: 0x214A3B0 Slot: 18
	public override BasicMenu.Result ACall() { }

	// RVA: 0x2145FE0 Offset: 0x21460E1 VA: 0x2145FE0
	protected int Enumerate(MapMind.Type mind, MapTarget.ActionMask actionMask) { }

	// RVA: 0x2146470 Offset: 0x2146571 VA: 0x2146470
	protected void .ctor() { }
}

// Namespace: 
private abstract class MapUnitCommandMenu.BreakdownBaseMenuItem : MapUnitCommandMenu.BaseMenuItem // TypeDefIndex: 12304
{
	// Properties
	protected override string FlagID { get; }

	// Methods

	// RVA: 0x2147050 Offset: 0x2147151 VA: 0x2147050 Slot: 10
	public override void OnBuild() { }

	// RVA: 0x21470F0 Offset: 0x21471F1 VA: 0x21470F0 Slot: 11
	public override void OnBuildMenuItemContent() { }

	// RVA: 0x2147100 Offset: 0x2147201 VA: 0x2147100 Slot: 27
	protected override string get_FlagID() { }

	// RVA: 0x2147150 Offset: 0x2147251 VA: 0x2147150 Slot: 4
	public override string GetName() { }

	// RVA: 0x21471D0 Offset: 0x21472D1 VA: 0x21471D0 Slot: 34
	public override string GetCommandHelp() { }

	// RVA: -1 Offset: -1 Slot: 36
	protected abstract Force.Type GetForce();

	// RVA: -1 Offset: -1 Slot: 37
	protected abstract MapInspector.Kind GetKind();

	// RVA: -1 Offset: -1 Slot: 38
	protected abstract MapMind.Type GetMind();

	// RVA: 0x2147250 Offset: 0x2147351 VA: 0x2147250 Slot: 29
	protected override BasicMenuItem.Attribute GetMapAttribute() { }

	// RVA: 0x21473B0 Offset: 0x21474B1 VA: 0x21473B0 Slot: 18
	public override BasicMenu.Result ACall() { }

	// RVA: 0x2147410 Offset: 0x2147511 VA: 0x2147410
	protected void .ctor() { }
}

// Namespace: 
private class MapUnitCommandMenu.BreakdownEnemyMenuItem : MapUnitCommandMenu.BreakdownBaseMenuItem // TypeDefIndex: 12306
{
	// Methods

	// RVA: 0x2147420 Offset: 0x2147521 VA: 0x2147420 Slot: 36
	protected override Force.Type GetForce() { }

	// RVA: 0x2147430 Offset: 0x2147531 VA: 0x2147430 Slot: 37
	protected override MapInspector.Kind GetKind() { }

	// RVA: 0x2147440 Offset: 0x2147541 VA: 0x2147440 Slot: 38
	protected override MapMind.Type GetMind() { }

	// RVA: 0x2147450 Offset: 0x2147551 VA: 0x2147450
	public void .ctor() { }
}

// Namespace: 
private class MapUnitCommandMenu.BreakthroughMenuItem : MapUnitCommandMenu.BaseMenuItem // TypeDefIndex: 12308
{
	// Properties
	protected override string FlagID { get; }

	// Methods

	// RVA: 0x21474A0 Offset: 0x21475A1 VA: 0x21474A0 Slot: 10
	public override void OnBuild() { }

	// RVA: 0x2147540 Offset: 0x2147641 VA: 0x2147540 Slot: 11
	public override void OnBuildMenuItemContent() { }

	// RVA: 0x2147550 Offset: 0x2147651 VA: 0x2147550 Slot: 27
	protected override string get_FlagID() { }

	// RVA: 0x21475A0 Offset: 0x21476A1 VA: 0x21475A0 Slot: 4
	public override string GetName() { }

	// RVA: 0x2147620 Offset: 0x2147721 VA: 0x2147620 Slot: 34
	public override string GetCommandHelp() { }

	// RVA: 0x21476A0 Offset: 0x21477A1 VA: 0x21476A0 Slot: 29
	protected override BasicMenuItem.Attribute GetMapAttribute() { }

	// RVA: 0x2147750 Offset: 0x2147851 VA: 0x2147750 Slot: 18
	public override BasicMenu.Result ACall() { }

	// RVA: 0x21477A0 Offset: 0x21478A1 VA: 0x21477A0
	public void .ctor() { }
}

// Namespace: 
public class MapUnitCommandMenu.SkillAttackMenuItem : MapUnitCommandMenu.AttackMenuItem // TypeDefIndex: 12310
{
	// Fields
	private SkillData m_CommandSkill; // 0x68

	// Properties
	protected override SkillData CommandSkill { get; }
	protected override MapMind.Type Mind { get; }
	protected override MapMind.Type ActiveMind { get; }
	protected override MapPanelDeploy.Mode DeployMode { get; }

	// Methods

	// RVA: 0x2149DC0 Offset: 0x2149EC1 VA: 0x2149DC0
	public void .ctor(SkillData commandSkill) { }

	// RVA: 0x214D310 Offset: 0x214D411 VA: 0x214D310 Slot: 32
	protected override SkillData get_CommandSkill() { }

	// RVA: 0x214D320 Offset: 0x214D421 VA: 0x214D320 Slot: 37
	protected override MapMind.Type get_Mind() { }

	// RVA: 0x214D330 Offset: 0x214D431 VA: 0x214D330 Slot: 30
	protected override MapMind.Type get_ActiveMind() { }

	// RVA: 0x214D340 Offset: 0x214D441 VA: 0x214D340 Slot: 31
	protected override MapPanelDeploy.Mode get_DeployMode() { }

	// RVA: 0x214D450 Offset: 0x214D551 VA: 0x214D450 Slot: 29
	protected override BasicMenuItem.Attribute GetMapAttribute() { }
}

// Namespace: 
private class MapUnitCommandMenu.CannonMenuItem : MapUnitCommandMenu.JumpToMenuItem // TypeDefIndex: 12312
{
	// Fields
	private MapUnitCommandMenu.CannonMenuItem.States m_State; // 0x64

	// Properties
	protected override string FlagID { get; }
	protected override MapSequenceHuman.Label Label { get; }
	protected override MapMind.Type ActiveMind { get; }
	protected override MapPanelDeploy.Mode DeployMode { get; }
	protected override bool IsForecast { get; }

	// Methods

	// RVA: 0x21477B0 Offset: 0x21478B1 VA: 0x21477B0 Slot: 27
	protected override string get_FlagID() { }

	// RVA: 0x2147800 Offset: 0x2147901 VA: 0x2147800 Slot: 36
	protected override MapSequenceHuman.Label get_Label() { }

	// RVA: 0x2147810 Offset: 0x2147911 VA: 0x2147810 Slot: 30
	protected override MapMind.Type get_ActiveMind() { }

	// RVA: 0x2147820 Offset: 0x2147921 VA: 0x2147820 Slot: 31
	protected override MapPanelDeploy.Mode get_DeployMode() { }

	// RVA: 0x2147830 Offset: 0x2147931 VA: 0x2147830 Slot: 33
	protected override bool get_IsForecast() { }

	// RVA: 0x2147840 Offset: 0x2147941 VA: 0x2147840
	private MapUnitCommandMenu.CannonMenuItem.States CalcState() { }

	// RVA: 0x2148660 Offset: 0x2148761 VA: 0x2148660
	public void .ctor() { }

	// RVA: 0x2148690 Offset: 0x2148791 VA: 0x2148690 Slot: 4
	public override string GetName() { }

	// RVA: 0x2148710 Offset: 0x2148811 VA: 0x2148710 Slot: 34
	public override string GetCommandHelp() { }

	// RVA: 0x2148790 Offset: 0x2148891 VA: 0x2148790 Slot: 29
	protected override BasicMenuItem.Attribute GetMapAttribute() { }

	// RVA: 0x2148880 Offset: 0x2148981 VA: 0x2148880 Slot: 18
	public override BasicMenu.Result ACall() { }
}

// Namespace: 
private abstract class MapUnitCommandMenu.EngageCommandMenuItem : MapUnitCommandMenu.JumpToMenuItem // TypeDefIndex: 12314
{
	// Properties
	protected override MapMind.Type ActiveMind { get; }
	protected override MapPanelDeploy.Mode DeployMode { get; }
	protected abstract MapMind.Type Mind { get; }

	// Methods

	// RVA: 0x214A150 Offset: 0x214A251 VA: 0x214A150 Slot: 30
	protected override MapMind.Type get_ActiveMind() { }

	// RVA: 0x214A160 Offset: 0x214A261 VA: 0x214A160 Slot: 31
	protected override MapPanelDeploy.Mode get_DeployMode() { }

	// RVA: -1 Offset: -1 Slot: 37
	protected abstract MapMind.Type get_Mind();

	// RVA: 0x214A170 Offset: 0x214A271 VA: 0x214A170 Slot: 10
	public override void OnBuild() { }

	// RVA: 0x214A210 Offset: 0x214A311 VA: 0x214A210 Slot: 11
	public override void OnBuildMenuItemContent() { }

	// RVA: 0x214A220 Offset: 0x214A321 VA: 0x214A220 Slot: 18
	public override BasicMenu.Result ACall() { }

	// RVA: 0x214A410 Offset: 0x214A511 VA: 0x214A410
	protected void .ctor() { }
}

// Namespace: 
private class MapUnitCommandMenu.EngageLinkMenuItem : MapUnitCommandMenu.EngageCommandMenuItem // TypeDefIndex: 12316
{
	// Properties
	protected override string FlagID { get; }
	protected override MapSequenceHuman.Label Label { get; }
	protected override MapMind.Type Mind { get; }
	protected override MapMind.Type ActiveMind { get; }
	protected override MapPanelDeploy.Mode DeployMode { get; }

	// Methods

	// RVA: 0x214A420 Offset: 0x214A521 VA: 0x214A420 Slot: 27
	protected override string get_FlagID() { }

	// RVA: 0x214A470 Offset: 0x214A571 VA: 0x214A470 Slot: 36
	protected override MapSequenceHuman.Label get_Label() { }

	// RVA: 0x214A480 Offset: 0x214A581 VA: 0x214A480 Slot: 37
	protected override MapMind.Type get_Mind() { }

	// RVA: 0x214A490 Offset: 0x214A591 VA: 0x214A490 Slot: 30
	protected override MapMind.Type get_ActiveMind() { }

	// RVA: 0x214A4A0 Offset: 0x214A5A1 VA: 0x214A4A0 Slot: 31
	protected override MapPanelDeploy.Mode get_DeployMode() { }

	// RVA: 0x214A4B0 Offset: 0x214A5B1 VA: 0x214A4B0 Slot: 4
	public override string GetName() { }

	// RVA: 0x214A530 Offset: 0x214A631 VA: 0x214A530 Slot: 34
	public override string GetCommandHelp() { }

	// RVA: 0x214A5B0 Offset: 0x214A6B1 VA: 0x214A5B0 Slot: 29
	protected override BasicMenuItem.Attribute GetMapAttribute() { }

	// RVA: 0x214A790 Offset: 0x214A891 VA: 0x214A790 Slot: 18
	public override BasicMenu.Result ACall() { }

	// RVA: 0x214A850 Offset: 0x214A951 VA: 0x214A850
	public void .ctor() { }
}

// Namespace: 
private abstract class MapUnitCommandMenu.EngageActionBaseMenuItem : MapUnitCommandMenu.SkillAttackMenuItem // TypeDefIndex: 12318
{
	// Properties
	protected override string FlagID { get; }
	protected override MapSequenceHuman.Label Label { get; }
	protected override MapMind.Type Mind { get; }

	// Methods

	// RVA: 0x2149BF0 Offset: 0x2149CF1 VA: 0x2149BF0 Slot: 27
	protected override string get_FlagID() { }

	// RVA: 0x2149C40 Offset: 0x2149D41 VA: 0x2149C40 Slot: 36
	protected override MapSequenceHuman.Label get_Label() { }

	// RVA: 0x2149C50 Offset: 0x2149D51 VA: 0x2149C50 Slot: 37
	protected override MapMind.Type get_Mind() { }

	// RVA: 0x2149C60 Offset: 0x2149D61 VA: 0x2149C60 Slot: 10
	public override void OnBuild() { }

	// RVA: 0x2149D00 Offset: 0x2149E01 VA: 0x2149D00 Slot: 11
	public override void OnBuildMenuItemContent() { }

	// RVA: 0x2149D10 Offset: 0x2149E11 VA: 0x2149D10
	public void .ctor() { }

	// RVA: 0x2149E00 Offset: 0x2149F01 VA: 0x2149E00
	protected MapMind.Type GetEngageMind(Unit unit) { }

	// RVA: 0x214A030 Offset: 0x214A131 VA: 0x214A030 Slot: 35
	protected override bool CheckBuildableWithUnit(Unit unit) { }
}

// Namespace: 
private class MapUnitCommandMenu.EngageRewarpMenuItem : MapUnitCommandMenu.EngageActionBaseMenuItem // TypeDefIndex: 12320
{
	// Properties
	protected override MapMind.Type Mind { get; }
	protected override MapSequenceHuman.Label Label { get; }
	protected override MapMind.Type ActiveMind { get; }
	protected override MapPanelDeploy.Mode DeployMode { get; }

	// Methods

	// RVA: 0x214A860 Offset: 0x214A961 VA: 0x214A860 Slot: 37
	protected override MapMind.Type get_Mind() { }

	// RVA: 0x214A870 Offset: 0x214A971 VA: 0x214A870 Slot: 36
	protected override MapSequenceHuman.Label get_Label() { }

	// RVA: 0x214A880 Offset: 0x214A981 VA: 0x214A880 Slot: 30
	protected override MapMind.Type get_ActiveMind() { }

	// RVA: 0x214A890 Offset: 0x214A991 VA: 0x214A890 Slot: 31
	protected override MapPanelDeploy.Mode get_DeployMode() { }

	// RVA: 0x214A8A0 Offset: 0x214A9A1 VA: 0x214A8A0 Slot: 29
	protected override BasicMenuItem.Attribute GetMapAttribute() { }

	// RVA: 0x214A950 Offset: 0x214AA51 VA: 0x214A950 Slot: 18
	public override BasicMenu.Result ACall() { }

	// RVA: 0x214AA70 Offset: 0x214AB71 VA: 0x214AA70
	public void .ctor() { }
}

// Namespace: 
private class MapUnitCommandMenu.EngageChargeMenuItem : MapUnitCommandMenu.EngageActionBaseMenuItem // TypeDefIndex: 12322
{
	// Properties
	protected override MapMind.Type Mind { get; }
	protected override MapTarget.ActionMask ActionMask { get; }
	protected override MapSequenceHuman.Label Label { get; }
	protected override MapMind.Type ActiveMind { get; }
	protected override MapPanelDeploy.Mode DeployMode { get; }
	protected override bool IsForecast { get; }

	// Methods

	// RVA: 0x214A0E0 Offset: 0x214A1E1 VA: 0x214A0E0 Slot: 37
	protected override MapMind.Type get_Mind() { }

	// RVA: 0x214A0F0 Offset: 0x214A1F1 VA: 0x214A0F0 Slot: 38
	protected override MapTarget.ActionMask get_ActionMask() { }

	// RVA: 0x214A100 Offset: 0x214A201 VA: 0x214A100 Slot: 36
	protected override MapSequenceHuman.Label get_Label() { }

	// RVA: 0x214A110 Offset: 0x214A211 VA: 0x214A110 Slot: 30
	protected override MapMind.Type get_ActiveMind() { }

	// RVA: 0x214A120 Offset: 0x214A221 VA: 0x214A120 Slot: 31
	protected override MapPanelDeploy.Mode get_DeployMode() { }

	// RVA: 0x214A130 Offset: 0x214A231 VA: 0x214A130 Slot: 33
	protected override bool get_IsForecast() { }

	// RVA: 0x214A140 Offset: 0x214A241 VA: 0x214A140
	public void .ctor() { }
}

// Namespace: 
private class MapUnitCommandMenu.EngageSummonMenuItem : MapUnitCommandMenu.EngageActionBaseMenuItem // TypeDefIndex: 12324
{
	// Properties
	protected override MapMind.Type Mind { get; }
	protected override MapTarget.ActionMask ActionMask { get; }
	protected override MapSequenceHuman.Label Label { get; }
	protected override MapMind.Type ActiveMind { get; }
	protected override MapPanelDeploy.Mode DeployMode { get; }
	protected override bool IsForecast { get; }

	// Methods

	// RVA: 0x214ADE0 Offset: 0x214AEE1 VA: 0x214ADE0 Slot: 37
	protected override MapMind.Type get_Mind() { }

	// RVA: 0x214ADF0 Offset: 0x214AEF1 VA: 0x214ADF0 Slot: 38
	protected override MapTarget.ActionMask get_ActionMask() { }

	// RVA: 0x214AE00 Offset: 0x214AF01 VA: 0x214AE00 Slot: 36
	protected override MapSequenceHuman.Label get_Label() { }

	// RVA: 0x214AE10 Offset: 0x214AF11 VA: 0x214AE10 Slot: 30
	protected override MapMind.Type get_ActiveMind() { }

	// RVA: 0x214AE20 Offset: 0x214AF21 VA: 0x214AE20 Slot: 31
	protected override MapPanelDeploy.Mode get_DeployMode() { }

	// RVA: 0x214AE30 Offset: 0x214AF31 VA: 0x214AE30 Slot: 33
	protected override bool get_IsForecast() { }

	// RVA: 0x214AE40 Offset: 0x214AF41 VA: 0x214AE40
	public void .ctor() { }
}

// Namespace: 
private class MapUnitCommandMenu.DanceMenuItem : MapUnitCommandMenu.TargetSelectMenuItem // TypeDefIndex: 12326
{
	// Properties
	protected override string FlagID { get; }
	protected override MapMind.Type Mind { get; }
	protected override MapPanelDeploy.Mode DeployMode { get; }
	protected override MapMind.Type ActiveMind { get; }

	// Methods

	// RVA: 0x2149190 Offset: 0x2149291 VA: 0x2149190 Slot: 27
	protected override string get_FlagID() { }

	// RVA: 0x21491E0 Offset: 0x21492E1 VA: 0x21491E0 Slot: 36
	protected override MapMind.Type get_Mind() { }

	// RVA: 0x21491F0 Offset: 0x21492F1 VA: 0x21491F0 Slot: 31
	protected override MapPanelDeploy.Mode get_DeployMode() { }

	// RVA: 0x2149200 Offset: 0x2149301 VA: 0x2149200 Slot: 30
	protected override MapMind.Type get_ActiveMind() { }

	// RVA: 0x2149210 Offset: 0x2149311 VA: 0x2149210 Slot: 4
	public override string GetName() { }

	// RVA: 0x2149290 Offset: 0x2149391 VA: 0x2149290 Slot: 34
	public override string GetCommandHelp() { }

	// RVA: 0x2149310 Offset: 0x2149411 VA: 0x2149310 Slot: 29
	protected override BasicMenuItem.Attribute GetMapAttribute() { }

	// RVA: 0x21493E0 Offset: 0x21494E1 VA: 0x21493E0
	public void .ctor() { }
}

// Namespace: 
private class MapUnitCommandMenu.TreasureBoxMenuItem : MapUnitCommandMenu.BaseMenuItem // TypeDefIndex: 12328
{
	// Properties
	protected override string FlagID { get; }
	protected override MapMind.Type ActiveMind { get; }
	protected override MapPanelDeploy.Mode DeployMode { get; }

	// Methods

	// RVA: 0x214EEE0 Offset: 0x214EFE1 VA: 0x214EEE0 Slot: 10
	public override void OnBuild() { }

	// RVA: 0x214EF80 Offset: 0x214F081 VA: 0x214EF80 Slot: 11
	public override void OnBuildMenuItemContent() { }

	// RVA: 0x214EF90 Offset: 0x214F091 VA: 0x214EF90 Slot: 27
	protected override string get_FlagID() { }

	// RVA: 0x214EFE0 Offset: 0x214F0E1 VA: 0x214EFE0 Slot: 30
	protected override MapMind.Type get_ActiveMind() { }

	// RVA: 0x214EFF0 Offset: 0x214F0F1 VA: 0x214EFF0 Slot: 31
	protected override MapPanelDeploy.Mode get_DeployMode() { }

	// RVA: 0x214F000 Offset: 0x214F101 VA: 0x214F000 Slot: 4
	public override string GetName() { }

	// RVA: 0x214F080 Offset: 0x214F181 VA: 0x214F080 Slot: 34
	public override string GetCommandHelp() { }

	// RVA: 0x214F100 Offset: 0x214F201 VA: 0x214F100 Slot: 29
	protected override BasicMenuItem.Attribute GetMapAttribute() { }

	// RVA: 0x214F230 Offset: 0x214F331 VA: 0x214F230 Slot: 18
	public override BasicMenu.Result ACall() { }

	// RVA: 0x214F460 Offset: 0x214F561 VA: 0x214F460
	public void .ctor() { }
}

// Namespace: 
private class MapUnitCommandMenu.TorchOnMenuItem : MapUnitCommandMenu.BaseMenuItem // TypeDefIndex: 12330
{
	// Properties
	protected override string FlagID { get; }
	protected override MapMind.Type ActiveMind { get; }
	protected override MapPanelDeploy.Mode DeployMode { get; }

	// Methods

	// RVA: 0x214DC90 Offset: 0x214DD91 VA: 0x214DC90 Slot: 27
	protected override string get_FlagID() { }

	// RVA: 0x214DCE0 Offset: 0x214DDE1 VA: 0x214DCE0 Slot: 30
	protected override MapMind.Type get_ActiveMind() { }

	// RVA: 0x214DCF0 Offset: 0x214DDF1 VA: 0x214DCF0 Slot: 31
	protected override MapPanelDeploy.Mode get_DeployMode() { }

	// RVA: 0x214DD00 Offset: 0x214DE01 VA: 0x214DD00 Slot: 4
	public override string GetName() { }

	// RVA: 0x214DD80 Offset: 0x214DE81 VA: 0x214DD80 Slot: 34
	public override string GetCommandHelp() { }

	// RVA: 0x214DE00 Offset: 0x214DF01 VA: 0x214DE00
	private TerrainData.Commands GetTerrainCommand() { }

	// RVA: 0x214E050 Offset: 0x214E151 VA: 0x214E050
	private void Decide(MapMind.Type mind) { }

	// RVA: 0x214E2B0 Offset: 0x214E3B1 VA: 0x214E2B0 Slot: 29
	protected override BasicMenuItem.Attribute GetMapAttribute() { }

	// RVA: 0x214E2D0 Offset: 0x214E3D1 VA: 0x214E2D0 Slot: 18
	public override BasicMenu.Result ACall() { }

	// RVA: 0x214E320 Offset: 0x214E421 VA: 0x214E320
	public void .ctor() { }
}

// Namespace: 
public abstract class MapUnitCommandMenu.TargetSelectMenuItem : MapUnitCommandMenu.BaseMenuItem // TypeDefIndex: 12332
{
	// Properties
	protected abstract MapMind.Type Mind { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 36
	protected abstract MapMind.Type get_Mind();

	// RVA: 0x2148F60 Offset: 0x2149061 VA: 0x2148F60
	protected int Enumerate(SkillData skill) { }

	// RVA: 0x214DC30 Offset: 0x214DD31 VA: 0x214DC30 Slot: 18
	public override BasicMenu.Result ACall() { }

	// RVA: 0x2148C40 Offset: 0x2148D41 VA: 0x2148C40
	protected void .ctor() { }
}

// Namespace: 
private class MapUnitCommandMenu.TransporterMenuItem : MapUnitCommandMenu.BaseMenuItem // TypeDefIndex: 12334
{
	// Properties
	protected override string FlagID { get; }
	protected override MapMind.Type ActiveMind { get; }
	protected override MapPanelDeploy.Mode DeployMode { get; }

	// Methods

	// RVA: 0x214E6C0 Offset: 0x214E7C1 VA: 0x214E6C0 Slot: 27
	protected override string get_FlagID() { }

	// RVA: 0x214E710 Offset: 0x214E811 VA: 0x214E710 Slot: 30
	protected override MapMind.Type get_ActiveMind() { }

	// RVA: 0x214E720 Offset: 0x214E821 VA: 0x214E720 Slot: 31
	protected override MapPanelDeploy.Mode get_DeployMode() { }

	// RVA: 0x214E730 Offset: 0x214E831 VA: 0x214E730 Slot: 4
	public override string GetName() { }

	// RVA: 0x214E7B0 Offset: 0x214E8B1 VA: 0x214E7B0 Slot: 34
	public override string GetCommandHelp() { }

	// RVA: 0x214E830 Offset: 0x214E931 VA: 0x214E830 Slot: 29
	protected override BasicMenuItem.Attribute GetMapAttribute() { }

	// RVA: 0x214EE80 Offset: 0x214EF81 VA: 0x214EE80 Slot: 18
	public override BasicMenu.Result ACall() { }

	// RVA: 0x214EED0 Offset: 0x214EFD1 VA: 0x214EED0
	public void .ctor() { }
}

// Namespace: 
public class MapUnitCommandMenu.OverlapSkillMenuItem : MapBasicMenuItem // TypeDefIndex: 12336
{
	// Fields
	private SkillData m_Skill; // 0x68

	// Properties
	protected override string FlagID { get; }

	// Methods

	// RVA: 0x214C690 Offset: 0x214C791 VA: 0x214C690 Slot: 27
	protected override string get_FlagID() { }

	// RVA: 0x214C6E0 Offset: 0x214C7E1 VA: 0x214C6E0
	public void .ctor(SkillData skill) { }

	// RVA: 0x214C720 Offset: 0x214C821 VA: 0x214C720 Slot: 10
	public override void OnBuild() { }

	// RVA: 0x214C860 Offset: 0x214C961 VA: 0x214C860 Slot: 12
	public override void OnSelect() { }

	// RVA: 0x214CAE0 Offset: 0x214CBE1 VA: 0x214CAE0 Slot: 13
	public override void OnDeselect() { }

	// RVA: 0x214CBD0 Offset: 0x214CCD1 VA: 0x214CBD0 Slot: 14
	public override void OnCursorMoveEnd() { }

	// RVA: 0x214CCC0 Offset: 0x214CDC1 VA: 0x214CCC0 Slot: 4
	public override string GetName() { }

	// RVA: 0x214CD60 Offset: 0x214CE61 VA: 0x214CD60 Slot: 30
	public virtual string GetCommandHelp() { }

	// RVA: 0x214C750 Offset: 0x214C851 VA: 0x214C750
	protected void SetupHelpText() { }

	// RVA: 0x214C9C0 Offset: 0x214CAC1 VA: 0x214C9C0
	protected int Enumerate(SkillData skill) { }

	// RVA: 0x214CE00 Offset: 0x214CF01 VA: 0x214CE00 Slot: 29
	protected override BasicMenuItem.Attribute GetMapAttribute() { }

	// RVA: 0x214CE30 Offset: 0x214CF31 VA: 0x214CE30 Slot: 18
	public override BasicMenu.Result ACall() { }
}

// Namespace: 
private class MapUnitCommandMenu.VisionDeleteMenuItem : MapUnitCommandMenu.TargetSelectMenuItem // TypeDefIndex: 12338
{
	// Properties
	protected override string FlagID { get; }
	protected override MapMind.Type Mind { get; }
	protected override MapMind.Type ActiveMind { get; }
	protected override MapPanelDeploy.Mode DeployMode { get; }

	// Methods

	// RVA: 0x214F720 Offset: 0x214F821 VA: 0x214F720 Slot: 27
	protected override string get_FlagID() { }

	// RVA: 0x214F770 Offset: 0x214F871 VA: 0x214F770 Slot: 36
	protected override MapMind.Type get_Mind() { }

	// RVA: 0x214F780 Offset: 0x214F881 VA: 0x214F780 Slot: 30
	protected override MapMind.Type get_ActiveMind() { }

	// RVA: 0x214F790 Offset: 0x214F891 VA: 0x214F790 Slot: 31
	protected override MapPanelDeploy.Mode get_DeployMode() { }

	// RVA: 0x214F7A0 Offset: 0x214F8A1 VA: 0x214F7A0 Slot: 4
	public override string GetName() { }

	// RVA: 0x214F820 Offset: 0x214F921 VA: 0x214F820 Slot: 34
	public override string GetCommandHelp() { }

	// RVA: 0x214F8A0 Offset: 0x214F9A1 VA: 0x214F8A0 Slot: 29
	protected override BasicMenuItem.Attribute GetMapAttribute() { }

	// RVA: 0x214F9C0 Offset: 0x214FAC1 VA: 0x214F9C0
	public void .ctor() { }
}

// Namespace: 
private class MapUnitCommandMenu.GuardMenuItem : MapUnitCommandMenu.TargetSelectMenuItem // TypeDefIndex: 12340
{
	// Fields
	private Unit.GuardType m_GuardType; // 0x64
	private SkillData m_GuardSkill; // 0x68

	// Properties
	protected override string FlagID { get; }
	protected override MapMind.Type Mind { get; }
	protected override MapMind.Type ActiveMind { get; }
	protected override MapPanelDeploy.Mode DeployMode { get; }

	// Methods

	// RVA: 0x214B690 Offset: 0x214B791 VA: 0x214B690 Slot: 27
	protected override string get_FlagID() { }

	// RVA: 0x214B6E0 Offset: 0x214B7E1 VA: 0x214B6E0 Slot: 36
	protected override MapMind.Type get_Mind() { }

	// RVA: 0x214B6F0 Offset: 0x214B7F1 VA: 0x214B6F0 Slot: 30
	protected override MapMind.Type get_ActiveMind() { }

	// RVA: 0x214B700 Offset: 0x214B801 VA: 0x214B700 Slot: 31
	protected override MapPanelDeploy.Mode get_DeployMode() { }

	// RVA: 0x214B710 Offset: 0x214B811 VA: 0x214B710
	public void .ctor() { }

	// RVA: 0x214BB90 Offset: 0x214BC91 VA: 0x214BB90 Slot: 4
	public override string GetName() { }

	// RVA: 0x214BCA0 Offset: 0x214BDA1 VA: 0x214BCA0 Slot: 34
	public override string GetCommandHelp() { }

	// RVA: 0x214BDB0 Offset: 0x214BEB1 VA: 0x214BDB0 Slot: 29
	protected override BasicMenuItem.Attribute GetMapAttribute() { }

	// RVA: 0x214BEA0 Offset: 0x214BFA1 VA: 0x214BEA0 Slot: 18
	public override BasicMenu.Result ACall() { }
}

// Namespace: 
private class MapUnitCommandMenu.NoCancelMagicMenuItem : MapUnitCommandMenu.SkillAttackMenuItem // TypeDefIndex: 12342
{
	// Methods

	// RVA: 0x214C4B0 Offset: 0x214C5B1 VA: 0x214C4B0
	public void .ctor() { }

	// RVA: 0x214C680 Offset: 0x214C781 VA: 0x214C680 Slot: 19
	public override BasicMenu.Result BCall() { }
}

