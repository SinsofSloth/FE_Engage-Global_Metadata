// Namespace: App
public abstract class BasicSkillMenuItem : BasicMenuItem // TypeDefIndex: 12523
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 27
	public abstract SkillData GetSkill();

	// RVA: -1 Offset: -1 Slot: 28
	public abstract bool IsActiveSkillIcon();

	// RVA: -1 Offset: -1 Slot: 29
	public abstract BasicSkillMenuItemContent.SubText GetSubText();

	// RVA: 0x2904C00 Offset: 0x2904D01 VA: 0x2904C00 Slot: 30
	public virtual string GetBlankText() { }

	// RVA: 0x2904C50 Offset: 0x2904D51 VA: 0x2904C50 Slot: 11
	public override void OnBuildMenuItemContent() { }

	// RVA: 0x2904C60 Offset: 0x2904D61 VA: 0x2904C60 Slot: 31
	public virtual void SetInitialColor() { }

	// RVA: 0x2904C70 Offset: 0x2904D71 VA: 0x2904C70
	protected void .ctor() { }
}

