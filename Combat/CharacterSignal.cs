// Namespace: Combat
[DisallowMultipleComponent] // RVA: 0x273F80 Offset: 0x274081 VA: 0x273F80
public sealed class CharacterSignal : MonoBehaviour // TypeDefIndex: 8629
{
	// Fields
	private bool cp_cached; // 0x18
	private Character _cp; // 0x20
	private bool hitPassed; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x282C20 Offset: 0x282D21 VA: 0x282C20
	private Subject<Character> <Subject命中>k__BackingField; // 0x30
	[CompilerGeneratedAttribute] // RVA: 0x282C30 Offset: 0x282D31 VA: 0x282C30
	private Subject<Character> <Subject命中直後>k__BackingField; // 0x38
	[CompilerGeneratedAttribute] // RVA: 0x282C40 Offset: 0x282D41 VA: 0x282C40
	private Subject<Character> <Subject命中最後>k__BackingField; // 0x40
	[CompilerGeneratedAttribute] // RVA: 0x282C50 Offset: 0x282D51 VA: 0x282C50
	private Subject<Character> <Subject前キャンセル>k__BackingField; // 0x48
	[CompilerGeneratedAttribute] // RVA: 0x282C60 Offset: 0x282D61 VA: 0x282C60
	private Subject<Character> <Subject後キャン始>k__BackingField; // 0x50
	[CompilerGeneratedAttribute] // RVA: 0x282C70 Offset: 0x282D71 VA: 0x282C70
	private Subject<Character> <Subject相手回避>k__BackingField; // 0x58
	[CompilerGeneratedAttribute] // RVA: 0x282C80 Offset: 0x282D81 VA: 0x282C80
	private Subject<Character> <Subject相手動作>k__BackingField; // 0x60
	[CompilerGeneratedAttribute] // RVA: 0x282C90 Offset: 0x282D91 VA: 0x282C90
	private Subject<Character> <Subjectジャンプ>k__BackingField; // 0x68
	[CompilerGeneratedAttribute] // RVA: 0x282CA0 Offset: 0x282DA1 VA: 0x282CA0
	private Subject<Character> <Subject発射>k__BackingField; // 0x70
	[CompilerGeneratedAttribute] // RVA: 0x282CB0 Offset: 0x282DB1 VA: 0x282CB0
	private Subject<Character> <Subject左足接地>k__BackingField; // 0x78
	[CompilerGeneratedAttribute] // RVA: 0x282CC0 Offset: 0x282DC1 VA: 0x282CC0
	private Subject<Character> <Subject左足上昇>k__BackingField; // 0x80
	[CompilerGeneratedAttribute] // RVA: 0x282CD0 Offset: 0x282DD1 VA: 0x282CD0
	private Subject<Character> <Subject右足接地>k__BackingField; // 0x88
	[CompilerGeneratedAttribute] // RVA: 0x282CE0 Offset: 0x282DE1 VA: 0x282CE0
	private Subject<Character> <Subject右足上昇>k__BackingField; // 0x90
	[CompilerGeneratedAttribute] // RVA: 0x282CF0 Offset: 0x282DF1 VA: 0x282CF0
	private Subject<Character> <Subject左前足接地>k__BackingField; // 0x98
	[CompilerGeneratedAttribute] // RVA: 0x282D00 Offset: 0x282E01 VA: 0x282D00
	private Subject<Character> <Subject左前足上昇>k__BackingField; // 0xA0
	[CompilerGeneratedAttribute] // RVA: 0x282D10 Offset: 0x282E11 VA: 0x282D10
	private Subject<Character> <Subject右前足接地>k__BackingField; // 0xA8
	[CompilerGeneratedAttribute] // RVA: 0x282D20 Offset: 0x282E21 VA: 0x282D20
	private Subject<Character> <Subject右前足上昇>k__BackingField; // 0xB0
	[CompilerGeneratedAttribute] // RVA: 0x282D30 Offset: 0x282E31 VA: 0x282D30
	private Subject<Character> <Subject左後足接地>k__BackingField; // 0xB8
	[CompilerGeneratedAttribute] // RVA: 0x282D40 Offset: 0x282E41 VA: 0x282D40
	private Subject<Character> <Subject左後足上昇>k__BackingField; // 0xC0
	[CompilerGeneratedAttribute] // RVA: 0x282D50 Offset: 0x282E51 VA: 0x282D50
	private Subject<Character> <Subject右後足接地>k__BackingField; // 0xC8
	[CompilerGeneratedAttribute] // RVA: 0x282D60 Offset: 0x282E61 VA: 0x282D60
	private Subject<Character> <Subject右後足上昇>k__BackingField; // 0xD0
	[CompilerGeneratedAttribute] // RVA: 0x282D70 Offset: 0x282E71 VA: 0x282D70
	private Subject<Character> <Subject羽ばたき>k__BackingField; // 0xD8
	[CompilerGeneratedAttribute] // RVA: 0x282D80 Offset: 0x282E81 VA: 0x282D80
	private Subject<Character> <Subjectカメラ>k__BackingField; // 0xE0
	[CompilerGeneratedAttribute] // RVA: 0x282D90 Offset: 0x282E91 VA: 0x282D90
	private Subject<Character> <Subjectカメラ戻す>k__BackingField; // 0xE8
	[CompilerGeneratedAttribute] // RVA: 0x282DA0 Offset: 0x282EA1 VA: 0x282DA0
	private Subject<Character> <Subject重い動作始>k__BackingField; // 0xF0
	[CompilerGeneratedAttribute] // RVA: 0x282DB0 Offset: 0x282EB1 VA: 0x282DB0
	private Subject<Character> <Subject重い動作終>k__BackingField; // 0xF8
	[CompilerGeneratedAttribute] // RVA: 0x282DC0 Offset: 0x282EC1 VA: 0x282DC0
	private Subject<Character> <Subject素早い動作始>k__BackingField; // 0x100
	[CompilerGeneratedAttribute] // RVA: 0x282DD0 Offset: 0x282ED1 VA: 0x282DD0
	private Subject<Character> <Subject素早い動作終>k__BackingField; // 0x108
	[CompilerGeneratedAttribute] // RVA: 0x282DE0 Offset: 0x282EE1 VA: 0x282DE0
	private Subject<Character> <Subjectワールド時間>k__BackingField; // 0x110
	[CompilerGeneratedAttribute] // RVA: 0x282DF0 Offset: 0x282EF1 VA: 0x282DF0
	private Subject<Character> <Subject武器軌跡始>k__BackingField; // 0x118
	[CompilerGeneratedAttribute] // RVA: 0x282E00 Offset: 0x282F01 VA: 0x282E00
	private Subject<Character> <Subject武器軌跡終>k__BackingField; // 0x120
	[CompilerGeneratedAttribute] // RVA: 0x282E10 Offset: 0x282F11 VA: 0x282E10
	private Subject<Character> <Subject左手軌跡始>k__BackingField; // 0x128
	[CompilerGeneratedAttribute] // RVA: 0x282E20 Offset: 0x282F21 VA: 0x282E20
	private Subject<Character> <Subject左手軌跡終>k__BackingField; // 0x130
	[CompilerGeneratedAttribute] // RVA: 0x282E30 Offset: 0x282F31 VA: 0x282E30
	private Subject<Character> <Subject残像始>k__BackingField; // 0x138
	[CompilerGeneratedAttribute] // RVA: 0x282E40 Offset: 0x282F41 VA: 0x282E40
	private Subject<Character> <Subject残像終>k__BackingField; // 0x140
	[CompilerGeneratedAttribute] // RVA: 0x282E50 Offset: 0x282F51 VA: 0x282E50
	private Subject<Character> <Subject武器アニメ>k__BackingField; // 0x148
	[CompilerGeneratedAttribute] // RVA: 0x282E60 Offset: 0x282F61 VA: 0x282E60
	private Subject<Character> <Subject武器放り投げる>k__BackingField; // 0x150
	[CompilerGeneratedAttribute] // RVA: 0x282E70 Offset: 0x282F71 VA: 0x282E70
	private Subject<Character> <Subjectパーティクル>k__BackingField; // 0x158
	[CompilerGeneratedAttribute] // RVA: 0x282E80 Offset: 0x282F81 VA: 0x282E80
	private Subject<Character> <Subject命中パーティクル>k__BackingField; // 0x160
	[CompilerGeneratedAttribute] // RVA: 0x282E90 Offset: 0x282F91 VA: 0x282E90
	private Subject<Character> <Subjectパーティクル削除>k__BackingField; // 0x168
	[CompilerGeneratedAttribute] // RVA: 0x282EA0 Offset: 0x282FA1 VA: 0x282EA0
	private Subject<Character> <Subject地面パーティクル>k__BackingField; // 0x170
	[CompilerGeneratedAttribute] // RVA: 0x282EB0 Offset: 0x282FB1 VA: 0x282EB0
	private Subject<Character> <Subject表情>k__BackingField; // 0x178
	[CompilerGeneratedAttribute] // RVA: 0x282EC0 Offset: 0x282FC1 VA: 0x282EC0
	private Subject<Character> <Subject注目率>k__BackingField; // 0x180
	[CompilerGeneratedAttribute] // RVA: 0x282ED0 Offset: 0x282FD1 VA: 0x282ED0
	private Subject<Character> <Subject画面揺れ>k__BackingField; // 0x188
	[CompilerGeneratedAttribute] // RVA: 0x282EE0 Offset: 0x282FE1 VA: 0x282EE0
	private Subject<Character> <Subjectアーマー振動>k__BackingField; // 0x190
	[CompilerGeneratedAttribute] // RVA: 0x282EF0 Offset: 0x282FF1 VA: 0x282EF0
	private Subject<Character> <Subject音汎用>k__BackingField; // 0x198
	[CompilerGeneratedAttribute] // RVA: 0x282F00 Offset: 0x283001 VA: 0x282F00
	private Subject<Character> <Subject音ボイス>k__BackingField; // 0x1A0
	[CompilerGeneratedAttribute] // RVA: 0x282F10 Offset: 0x283011 VA: 0x282F10
	private Subject<Character> <Subject音攻撃ボイス>k__BackingField; // 0x1A8
	[CompilerGeneratedAttribute] // RVA: 0x282F20 Offset: 0x283021 VA: 0x282F20
	private Subject<Character> <Subject音必殺ボイス>k__BackingField; // 0x1B0
	[CompilerGeneratedAttribute] // RVA: 0x282F30 Offset: 0x283031 VA: 0x282F30
	private Subject<Character> <Subject魔法動作1>k__BackingField; // 0x1B8
	[CompilerGeneratedAttribute] // RVA: 0x282F40 Offset: 0x283041 VA: 0x282F40
	private Subject<Character> <Subject魔法動作2>k__BackingField; // 0x1C0
	[CompilerGeneratedAttribute] // RVA: 0x282F50 Offset: 0x283051 VA: 0x282F50
	private Subject<Character> <Subject魔法動作3>k__BackingField; // 0x1C8
	[CompilerGeneratedAttribute] // RVA: 0x282F60 Offset: 0x283061 VA: 0x282F60
	private Subject<Character> <Subject手綱>k__BackingField; // 0x1D0
	[CompilerGeneratedAttribute] // RVA: 0x282F70 Offset: 0x283071 VA: 0x282F70
	private Subject<Character> <Subjectフェード>k__BackingField; // 0x1D8
	[CompilerGeneratedAttribute] // RVA: 0x282F80 Offset: 0x283081 VA: 0x282F80
	private Subject<Character> <Subject姿を隠す>k__BackingField; // 0x1E0
	[CompilerGeneratedAttribute] // RVA: 0x282F90 Offset: 0x283091 VA: 0x282F90
	private Subject<Character> <Subject再生ジャンプ>k__BackingField; // 0x1E8
	[CompilerGeneratedAttribute] // RVA: 0x282FA0 Offset: 0x2830A1 VA: 0x282FA0
	private Subject<Character> <Subjectラジアルブラー>k__BackingField; // 0x1F0
	[CompilerGeneratedAttribute] // RVA: 0x282FB0 Offset: 0x2830B1 VA: 0x282FB0
	private Subject<Character> <Subject背景暗さ>k__BackingField; // 0x1F8
	[CompilerGeneratedAttribute] // RVA: 0x282FC0 Offset: 0x2830C1 VA: 0x282FC0
	private Subject<Character> <Subject体格標準化>k__BackingField; // 0x200
	[CompilerGeneratedAttribute] // RVA: 0x282FD0 Offset: 0x2830D1 VA: 0x282FD0
	private Subject<Character> <SubjectFootIK>k__BackingField; // 0x208

	// Properties
	private Character CP { get; }
	public Subject<Character> Subject命中 { get; set; }
	public Subject<Character> Subject命中直後 { get; set; }
	public Subject<Character> Subject命中最後 { get; set; }
	public Subject<Character> Subject前キャンセル { get; set; }
	public Subject<Character> Subject後キャン始 { get; set; }
	public Subject<Character> Subject相手回避 { get; set; }
	public Subject<Character> Subject相手動作 { get; set; }
	public Subject<Character> Subjectジャンプ { get; set; }
	public Subject<Character> Subject発射 { get; set; }
	public Subject<Character> Subject左足接地 { get; set; }
	public Subject<Character> Subject左足上昇 { get; set; }
	public Subject<Character> Subject右足接地 { get; set; }
	public Subject<Character> Subject右足上昇 { get; set; }
	public Subject<Character> Subject左前足接地 { get; set; }
	public Subject<Character> Subject左前足上昇 { get; set; }
	public Subject<Character> Subject右前足接地 { get; set; }
	public Subject<Character> Subject右前足上昇 { get; set; }
	public Subject<Character> Subject左後足接地 { get; set; }
	public Subject<Character> Subject左後足上昇 { get; set; }
	public Subject<Character> Subject右後足接地 { get; set; }
	public Subject<Character> Subject右後足上昇 { get; set; }
	public Subject<Character> Subject羽ばたき { get; set; }
	public Subject<Character> Subjectカメラ { get; set; }
	public Subject<Character> Subjectカメラ戻す { get; set; }
	public Subject<Character> Subject重い動作始 { get; set; }
	public Subject<Character> Subject重い動作終 { get; set; }
	public Subject<Character> Subject素早い動作始 { get; set; }
	public Subject<Character> Subject素早い動作終 { get; set; }
	public Subject<Character> Subjectワールド時間 { get; set; }
	public Subject<Character> Subject武器軌跡始 { get; set; }
	public Subject<Character> Subject武器軌跡終 { get; set; }
	public Subject<Character> Subject左手軌跡始 { get; set; }
	public Subject<Character> Subject左手軌跡終 { get; set; }
	public Subject<Character> Subject残像始 { get; set; }
	public Subject<Character> Subject残像終 { get; set; }
	public Subject<Character> Subject武器アニメ { get; set; }
	public Subject<Character> Subject武器放り投げる { get; set; }
	public Subject<Character> Subjectパーティクル { get; set; }
	public Subject<Character> Subject命中パーティクル { get; set; }
	public Subject<Character> Subjectパーティクル削除 { get; set; }
	public Subject<Character> Subject地面パーティクル { get; set; }
	public Subject<Character> Subject表情 { get; set; }
	public Subject<Character> Subject注目率 { get; set; }
	public Subject<Character> Subject画面揺れ { get; set; }
	public Subject<Character> Subjectアーマー振動 { get; set; }
	public Subject<Character> Subject音汎用 { get; set; }
	public Subject<Character> Subject音ボイス { get; set; }
	public Subject<Character> Subject音攻撃ボイス { get; set; }
	public Subject<Character> Subject音必殺ボイス { get; set; }
	public Subject<Character> Subject魔法動作1 { get; set; }
	public Subject<Character> Subject魔法動作2 { get; set; }
	public Subject<Character> Subject魔法動作3 { get; set; }
	public Subject<Character> Subject手綱 { get; set; }
	public Subject<Character> Subjectフェード { get; set; }
	public Subject<Character> Subject姿を隠す { get; set; }
	public Subject<Character> Subject再生ジャンプ { get; set; }
	public Subject<Character> Subjectラジアルブラー { get; set; }
	public Subject<Character> Subject背景暗さ { get; set; }
	public Subject<Character> Subject体格標準化 { get; set; }
	public Subject<Character> SubjectFootIK { get; set; }

	// Methods

	// RVA: 0x29B5480 Offset: 0x29B5581 VA: 0x29B5480
	private Character get_CP() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AAF40 Offset: 0x2AB041 VA: 0x2AAF40
	// RVA: 0x29B5510 Offset: 0x29B5611 VA: 0x29B5510
	public Subject<Character> get_Subject命中() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AAF50 Offset: 0x2AB051 VA: 0x2AAF50
	// RVA: 0x29B5520 Offset: 0x29B5621 VA: 0x29B5520
	private void set_Subject命中(Subject<Character> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AAF60 Offset: 0x2AB061 VA: 0x2AAF60
	// RVA: 0x29B5530 Offset: 0x29B5631 VA: 0x29B5530
	public Subject<Character> get_Subject命中直後() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AAF70 Offset: 0x2AB071 VA: 0x2AAF70
	// RVA: 0x29B5540 Offset: 0x29B5641 VA: 0x29B5540
	private void set_Subject命中直後(Subject<Character> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AAF80 Offset: 0x2AB081 VA: 0x2AAF80
	// RVA: 0x29B5550 Offset: 0x29B5651 VA: 0x29B5550
	public Subject<Character> get_Subject命中最後() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AAF90 Offset: 0x2AB091 VA: 0x2AAF90
	// RVA: 0x29B5560 Offset: 0x29B5661 VA: 0x29B5560
	private void set_Subject命中最後(Subject<Character> value) { }

	// RVA: 0x29B5570 Offset: 0x29B5671 VA: 0x29B5570
	public void InitOnAttackState() { }

	// RVA: 0x29B5580 Offset: 0x29B5681 VA: 0x29B5580
	public void 命中先行呼び出し(AnimationEvent ev) { }

	// RVA: 0x29B5700 Offset: 0x29B5801 VA: 0x29B5700
	public void 命中(AnimationEvent ev) { }

	// RVA: 0x29B55B0 Offset: 0x29B56B1 VA: 0x29B55B0
	private void Call命中Common(AnimationEvent ev) { }

	// RVA: 0x29B5730 Offset: 0x29B5831 VA: 0x29B5730
	private void ノード移動(AnimationEvent ev) { }

	// RVA: 0x29B5960 Offset: 0x29B5A61 VA: 0x29B5960
	public IDisposable Subscribeジャンプ(bool chase = True) { }

	// RVA: 0x29B5CB0 Offset: 0x29B5DB1 VA: 0x29B5CB0
	private void なし() { }

	// RVA: 0x29B5CC0 Offset: 0x29B5DC1 VA: 0x29B5CC0
	private void 突進前キャン() { }

	// RVA: 0x29B5CD0 Offset: 0x29B5DD1 VA: 0x29B5CD0
	private void 後キャン終() { }

	// RVA: 0x29B5CE0 Offset: 0x29B5DE1 VA: 0x29B5CE0
	private void 攻撃可能範囲() { }

	// RVA: 0x29B5CF0 Offset: 0x29B5DF1 VA: 0x29B5CF0
	private void 着地() { }

	// RVA: 0x29B5D00 Offset: 0x29B5E01 VA: 0x29B5D00
	private void 汎用Object() { }

	// RVA: 0x29B5D10 Offset: 0x29B5E11 VA: 0x29B5D10
	private void Run速度() { }

	// RVA: 0x29B5D20 Offset: 0x29B5E21 VA: 0x29B5D20
	private void 最終位置() { }

	// RVA: 0x29B5D30 Offset: 0x29B5E31 VA: 0x29B5D30
	private void 死亡落下() { }

	// RVA: 0x29B5D40 Offset: 0x29B5E41 VA: 0x29B5D40
	private void 自動生成除外() { }

	// RVA: 0x29B5D50 Offset: 0x29B5E51 VA: 0x29B5D50
	private void 開発一時停止() { }

	// RVA: 0x29B5D60 Offset: 0x29B5E61 VA: 0x29B5D60
	private void 再生着地() { }

	// RVA: 0x29B5D70 Offset: 0x29B5E71 VA: 0x29B5D70
	private void やられ終わり() { }

	// RVA: 0x29B5D80 Offset: 0x29B5E81 VA: 0x29B5D80
	private void 発射の前兆() { }

	// RVA: 0x29B5D90 Offset: 0x29B5E91 VA: 0x29B5D90
	private void ノード移動() { }

	// RVA: 0x29B5DA0 Offset: 0x29B5EA1 VA: 0x29B5DA0
	private void Vec3() { }

	// RVA: 0x29B5DB0 Offset: 0x29B5EB1 VA: 0x29B5DB0
	private void 遷移時間() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AAFA0 Offset: 0x2AB0A1 VA: 0x2AAFA0
	// RVA: 0x29B5DC0 Offset: 0x29B5EC1 VA: 0x29B5DC0
	public Subject<Character> get_Subject前キャンセル() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AAFB0 Offset: 0x2AB0B1 VA: 0x2AAFB0
	// RVA: 0x29B5DD0 Offset: 0x29B5ED1 VA: 0x29B5DD0
	private void set_Subject前キャンセル(Subject<Character> value) { }

	// RVA: 0x29B5DE0 Offset: 0x29B5EE1 VA: 0x29B5DE0
	private void 前キャンセル(AnimationEvent ev) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AAFC0 Offset: 0x2AB0C1 VA: 0x2AAFC0
	// RVA: 0x29B5F10 Offset: 0x29B6011 VA: 0x29B5F10
	public Subject<Character> get_Subject後キャン始() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AAFD0 Offset: 0x2AB0D1 VA: 0x2AAFD0
	// RVA: 0x29B5F20 Offset: 0x29B6021 VA: 0x29B5F20
	private void set_Subject後キャン始(Subject<Character> value) { }

	// RVA: 0x29B5F30 Offset: 0x29B6031 VA: 0x29B5F30
	private void 後キャン始(AnimationEvent ev) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AAFE0 Offset: 0x2AB0E1 VA: 0x2AAFE0
	// RVA: 0x29B6060 Offset: 0x29B6161 VA: 0x29B6060
	public Subject<Character> get_Subject相手回避() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AAFF0 Offset: 0x2AB0F1 VA: 0x2AAFF0
	// RVA: 0x29B6070 Offset: 0x29B6171 VA: 0x29B6070
	private void set_Subject相手回避(Subject<Character> value) { }

	// RVA: 0x29B6080 Offset: 0x29B6181 VA: 0x29B6080
	private void 相手回避(AnimationEvent ev) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AB000 Offset: 0x2AB101 VA: 0x2AB000
	// RVA: 0x29B61B0 Offset: 0x29B62B1 VA: 0x29B61B0
	public Subject<Character> get_Subject相手動作() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AB010 Offset: 0x2AB111 VA: 0x2AB010
	// RVA: 0x29B61C0 Offset: 0x29B62C1 VA: 0x29B61C0
	private void set_Subject相手動作(Subject<Character> value) { }

	// RVA: 0x29B61D0 Offset: 0x29B62D1 VA: 0x29B61D0
	private void 相手動作(AnimationEvent ev) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AB020 Offset: 0x2AB121 VA: 0x2AB020
	// RVA: 0x29B6300 Offset: 0x29B6401 VA: 0x29B6300
	public Subject<Character> get_Subjectジャンプ() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AB030 Offset: 0x2AB131 VA: 0x2AB030
	// RVA: 0x29B6310 Offset: 0x29B6411 VA: 0x29B6310
	private void set_Subjectジャンプ(Subject<Character> value) { }

	// RVA: 0x29B6320 Offset: 0x29B6421 VA: 0x29B6320
	private void ジャンプ(AnimationEvent ev) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AB040 Offset: 0x2AB141 VA: 0x2AB040
	// RVA: 0x29B6450 Offset: 0x29B6551 VA: 0x29B6450
	public Subject<Character> get_Subject発射() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AB050 Offset: 0x2AB151 VA: 0x2AB050
	// RVA: 0x29B6460 Offset: 0x29B6561 VA: 0x29B6460
	private void set_Subject発射(Subject<Character> value) { }

	// RVA: 0x29B6470 Offset: 0x29B6571 VA: 0x29B6470
	private void 発射(AnimationEvent ev) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AB060 Offset: 0x2AB161 VA: 0x2AB060
	// RVA: 0x29B65A0 Offset: 0x29B66A1 VA: 0x29B65A0
	public Subject<Character> get_Subject左足接地() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AB070 Offset: 0x2AB171 VA: 0x2AB070
	// RVA: 0x29B65B0 Offset: 0x29B66B1 VA: 0x29B65B0
	private void set_Subject左足接地(Subject<Character> value) { }

	// RVA: 0x29B65C0 Offset: 0x29B66C1 VA: 0x29B65C0
	private void 左足接地(AnimationEvent ev) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AB080 Offset: 0x2AB181 VA: 0x2AB080
	// RVA: 0x29B66F0 Offset: 0x29B67F1 VA: 0x29B66F0
	public Subject<Character> get_Subject左足上昇() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AB090 Offset: 0x2AB191 VA: 0x2AB090
	// RVA: 0x29B6700 Offset: 0x29B6801 VA: 0x29B6700
	private void set_Subject左足上昇(Subject<Character> value) { }

	// RVA: 0x29B6710 Offset: 0x29B6811 VA: 0x29B6710
	private void 左足上昇(AnimationEvent ev) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AB0A0 Offset: 0x2AB1A1 VA: 0x2AB0A0
	// RVA: 0x29B6840 Offset: 0x29B6941 VA: 0x29B6840
	public Subject<Character> get_Subject右足接地() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AB0B0 Offset: 0x2AB1B1 VA: 0x2AB0B0
	// RVA: 0x29B6850 Offset: 0x29B6951 VA: 0x29B6850
	private void set_Subject右足接地(Subject<Character> value) { }

	// RVA: 0x29B6860 Offset: 0x29B6961 VA: 0x29B6860
	private void 右足接地(AnimationEvent ev) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AB0C0 Offset: 0x2AB1C1 VA: 0x2AB0C0
	// RVA: 0x29B6990 Offset: 0x29B6A91 VA: 0x29B6990
	public Subject<Character> get_Subject右足上昇() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AB0D0 Offset: 0x2AB1D1 VA: 0x2AB0D0
	// RVA: 0x29B69A0 Offset: 0x29B6AA1 VA: 0x29B69A0
	private void set_Subject右足上昇(Subject<Character> value) { }

	// RVA: 0x29B69B0 Offset: 0x29B6AB1 VA: 0x29B69B0
	private void 右足上昇(AnimationEvent ev) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AB0E0 Offset: 0x2AB1E1 VA: 0x2AB0E0
	// RVA: 0x29B6AE0 Offset: 0x29B6BE1 VA: 0x29B6AE0
	public Subject<Character> get_Subject左前足接地() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AB0F0 Offset: 0x2AB1F1 VA: 0x2AB0F0
	// RVA: 0x29B6AF0 Offset: 0x29B6BF1 VA: 0x29B6AF0
	private void set_Subject左前足接地(Subject<Character> value) { }

	// RVA: 0x29B6B00 Offset: 0x29B6C01 VA: 0x29B6B00
	private void 左前足接地(AnimationEvent ev) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AB100 Offset: 0x2AB201 VA: 0x2AB100
	// RVA: 0x29B6C30 Offset: 0x29B6D31 VA: 0x29B6C30
	public Subject<Character> get_Subject左前足上昇() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AB110 Offset: 0x2AB211 VA: 0x2AB110
	// RVA: 0x29B6C40 Offset: 0x29B6D41 VA: 0x29B6C40
	private void set_Subject左前足上昇(Subject<Character> value) { }

	// RVA: 0x29B6C50 Offset: 0x29B6D51 VA: 0x29B6C50
	private void 左前足上昇(AnimationEvent ev) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AB120 Offset: 0x2AB221 VA: 0x2AB120
	// RVA: 0x29B6D80 Offset: 0x29B6E81 VA: 0x29B6D80
	public Subject<Character> get_Subject右前足接地() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AB130 Offset: 0x2AB231 VA: 0x2AB130
	// RVA: 0x29B6D90 Offset: 0x29B6E91 VA: 0x29B6D90
	private void set_Subject右前足接地(Subject<Character> value) { }

	// RVA: 0x29B6DA0 Offset: 0x29B6EA1 VA: 0x29B6DA0
	private void 右前足接地(AnimationEvent ev) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AB140 Offset: 0x2AB241 VA: 0x2AB140
	// RVA: 0x29B6ED0 Offset: 0x29B6FD1 VA: 0x29B6ED0
	public Subject<Character> get_Subject右前足上昇() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AB150 Offset: 0x2AB251 VA: 0x2AB150
	// RVA: 0x29B6EE0 Offset: 0x29B6FE1 VA: 0x29B6EE0
	private void set_Subject右前足上昇(Subject<Character> value) { }

	// RVA: 0x29B6EF0 Offset: 0x29B6FF1 VA: 0x29B6EF0
	private void 右前足上昇(AnimationEvent ev) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AB160 Offset: 0x2AB261 VA: 0x2AB160
	// RVA: 0x29B7020 Offset: 0x29B7121 VA: 0x29B7020
	public Subject<Character> get_Subject左後足接地() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AB170 Offset: 0x2AB271 VA: 0x2AB170
	// RVA: 0x29B7030 Offset: 0x29B7131 VA: 0x29B7030
	private void set_Subject左後足接地(Subject<Character> value) { }

	// RVA: 0x29B7040 Offset: 0x29B7141 VA: 0x29B7040
	private void 左後足接地(AnimationEvent ev) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AB180 Offset: 0x2AB281 VA: 0x2AB180
	// RVA: 0x29B7170 Offset: 0x29B7271 VA: 0x29B7170
	public Subject<Character> get_Subject左後足上昇() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AB190 Offset: 0x2AB291 VA: 0x2AB190
	// RVA: 0x29B7180 Offset: 0x29B7281 VA: 0x29B7180
	private void set_Subject左後足上昇(Subject<Character> value) { }

	// RVA: 0x29B7190 Offset: 0x29B7291 VA: 0x29B7190
	private void 左後足上昇(AnimationEvent ev) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AB1A0 Offset: 0x2AB2A1 VA: 0x2AB1A0
	// RVA: 0x29B72C0 Offset: 0x29B73C1 VA: 0x29B72C0
	public Subject<Character> get_Subject右後足接地() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AB1B0 Offset: 0x2AB2B1 VA: 0x2AB1B0
	// RVA: 0x29B72D0 Offset: 0x29B73D1 VA: 0x29B72D0
	private void set_Subject右後足接地(Subject<Character> value) { }

	// RVA: 0x29B72E0 Offset: 0x29B73E1 VA: 0x29B72E0
	private void 右後足接地(AnimationEvent ev) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AB1C0 Offset: 0x2AB2C1 VA: 0x2AB1C0
	// RVA: 0x29B7410 Offset: 0x29B7511 VA: 0x29B7410
	public Subject<Character> get_Subject右後足上昇() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AB1D0 Offset: 0x2AB2D1 VA: 0x2AB1D0
	// RVA: 0x29B7420 Offset: 0x29B7521 VA: 0x29B7420
	private void set_Subject右後足上昇(Subject<Character> value) { }

	// RVA: 0x29B7430 Offset: 0x29B7531 VA: 0x29B7430
	private void 右後足上昇(AnimationEvent ev) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AB1E0 Offset: 0x2AB2E1 VA: 0x2AB1E0
	// RVA: 0x29B7560 Offset: 0x29B7661 VA: 0x29B7560
	public Subject<Character> get_Subject羽ばたき() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AB1F0 Offset: 0x2AB2F1 VA: 0x2AB1F0
	// RVA: 0x29B7570 Offset: 0x29B7671 VA: 0x29B7570
	private void set_Subject羽ばたき(Subject<Character> value) { }

	// RVA: 0x29B7580 Offset: 0x29B7681 VA: 0x29B7580
	private void 羽ばたき(AnimationEvent ev) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AB200 Offset: 0x2AB301 VA: 0x2AB200
	// RVA: 0x29B76B0 Offset: 0x29B77B1 VA: 0x29B76B0
	public Subject<Character> get_Subjectカメラ() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AB210 Offset: 0x2AB311 VA: 0x2AB210
	// RVA: 0x29B76C0 Offset: 0x29B77C1 VA: 0x29B76C0
	private void set_Subjectカメラ(Subject<Character> value) { }

	// RVA: 0x29B76D0 Offset: 0x29B77D1 VA: 0x29B76D0
	private void カメラ(AnimationEvent ev) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AB220 Offset: 0x2AB321 VA: 0x2AB220
	// RVA: 0x29B7800 Offset: 0x29B7901 VA: 0x29B7800
	public Subject<Character> get_Subjectカメラ戻す() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AB230 Offset: 0x2AB331 VA: 0x2AB230
	// RVA: 0x29B7810 Offset: 0x29B7911 VA: 0x29B7810
	private void set_Subjectカメラ戻す(Subject<Character> value) { }

	// RVA: 0x29B7820 Offset: 0x29B7921 VA: 0x29B7820
	private void カメラ戻す(AnimationEvent ev) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AB240 Offset: 0x2AB341 VA: 0x2AB240
	// RVA: 0x29B7950 Offset: 0x29B7A51 VA: 0x29B7950
	public Subject<Character> get_Subject重い動作始() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AB250 Offset: 0x2AB351 VA: 0x2AB250
	// RVA: 0x29B7960 Offset: 0x29B7A61 VA: 0x29B7960
	private void set_Subject重い動作始(Subject<Character> value) { }

	// RVA: 0x29B7970 Offset: 0x29B7A71 VA: 0x29B7970
	private void 重い動作始(AnimationEvent ev) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AB260 Offset: 0x2AB361 VA: 0x2AB260
	// RVA: 0x29B7AA0 Offset: 0x29B7BA1 VA: 0x29B7AA0
	public Subject<Character> get_Subject重い動作終() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AB270 Offset: 0x2AB371 VA: 0x2AB270
	// RVA: 0x29B7AB0 Offset: 0x29B7BB1 VA: 0x29B7AB0
	private void set_Subject重い動作終(Subject<Character> value) { }

	// RVA: 0x29B7AC0 Offset: 0x29B7BC1 VA: 0x29B7AC0
	private void 重い動作終(AnimationEvent ev) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AB280 Offset: 0x2AB381 VA: 0x2AB280
	// RVA: 0x29B7BF0 Offset: 0x29B7CF1 VA: 0x29B7BF0
	public Subject<Character> get_Subject素早い動作始() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AB290 Offset: 0x2AB391 VA: 0x2AB290
	// RVA: 0x29B7C00 Offset: 0x29B7D01 VA: 0x29B7C00
	private void set_Subject素早い動作始(Subject<Character> value) { }

	// RVA: 0x29B7C10 Offset: 0x29B7D11 VA: 0x29B7C10
	private void 素早い動作始(AnimationEvent ev) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AB2A0 Offset: 0x2AB3A1 VA: 0x2AB2A0
	// RVA: 0x29B7D40 Offset: 0x29B7E41 VA: 0x29B7D40
	public Subject<Character> get_Subject素早い動作終() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AB2B0 Offset: 0x2AB3B1 VA: 0x2AB2B0
	// RVA: 0x29B7D50 Offset: 0x29B7E51 VA: 0x29B7D50
	private void set_Subject素早い動作終(Subject<Character> value) { }

	// RVA: 0x29B7D60 Offset: 0x29B7E61 VA: 0x29B7D60
	private void 素早い動作終(AnimationEvent ev) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AB2C0 Offset: 0x2AB3C1 VA: 0x2AB2C0
	// RVA: 0x29B7E90 Offset: 0x29B7F91 VA: 0x29B7E90
	public Subject<Character> get_Subjectワールド時間() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AB2D0 Offset: 0x2AB3D1 VA: 0x2AB2D0
	// RVA: 0x29B7EA0 Offset: 0x29B7FA1 VA: 0x29B7EA0
	private void set_Subjectワールド時間(Subject<Character> value) { }

	// RVA: 0x29B7EB0 Offset: 0x29B7FB1 VA: 0x29B7EB0
	private void ワールド時間(AnimationEvent ev) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AB2E0 Offset: 0x2AB3E1 VA: 0x2AB2E0
	// RVA: 0x29B7FE0 Offset: 0x29B80E1 VA: 0x29B7FE0
	public Subject<Character> get_Subject武器軌跡始() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AB2F0 Offset: 0x2AB3F1 VA: 0x2AB2F0
	// RVA: 0x29B7FF0 Offset: 0x29B80F1 VA: 0x29B7FF0
	private void set_Subject武器軌跡始(Subject<Character> value) { }

	// RVA: 0x29B8000 Offset: 0x29B8101 VA: 0x29B8000
	private void 武器軌跡始(AnimationEvent ev) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AB300 Offset: 0x2AB401 VA: 0x2AB300
	// RVA: 0x29B8130 Offset: 0x29B8231 VA: 0x29B8130
	public Subject<Character> get_Subject武器軌跡終() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AB310 Offset: 0x2AB411 VA: 0x2AB310
	// RVA: 0x29B8140 Offset: 0x29B8241 VA: 0x29B8140
	private void set_Subject武器軌跡終(Subject<Character> value) { }

	// RVA: 0x29B8150 Offset: 0x29B8251 VA: 0x29B8150
	private void 武器軌跡終(AnimationEvent ev) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AB320 Offset: 0x2AB421 VA: 0x2AB320
	// RVA: 0x29B8280 Offset: 0x29B8381 VA: 0x29B8280
	public Subject<Character> get_Subject左手軌跡始() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AB330 Offset: 0x2AB431 VA: 0x2AB330
	// RVA: 0x29B8290 Offset: 0x29B8391 VA: 0x29B8290
	private void set_Subject左手軌跡始(Subject<Character> value) { }

	// RVA: 0x29B82A0 Offset: 0x29B83A1 VA: 0x29B82A0
	private void 左手軌跡始(AnimationEvent ev) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AB340 Offset: 0x2AB441 VA: 0x2AB340
	// RVA: 0x29B83D0 Offset: 0x29B84D1 VA: 0x29B83D0
	public Subject<Character> get_Subject左手軌跡終() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AB350 Offset: 0x2AB451 VA: 0x2AB350
	// RVA: 0x29B83E0 Offset: 0x29B84E1 VA: 0x29B83E0
	private void set_Subject左手軌跡終(Subject<Character> value) { }

	// RVA: 0x29B83F0 Offset: 0x29B84F1 VA: 0x29B83F0
	private void 左手軌跡終(AnimationEvent ev) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AB360 Offset: 0x2AB461 VA: 0x2AB360
	// RVA: 0x29B8520 Offset: 0x29B8621 VA: 0x29B8520
	public Subject<Character> get_Subject残像始() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AB370 Offset: 0x2AB471 VA: 0x2AB370
	// RVA: 0x29B8530 Offset: 0x29B8631 VA: 0x29B8530
	private void set_Subject残像始(Subject<Character> value) { }

	// RVA: 0x29B8540 Offset: 0x29B8641 VA: 0x29B8540
	private void 残像始(AnimationEvent ev) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AB380 Offset: 0x2AB481 VA: 0x2AB380
	// RVA: 0x29B8670 Offset: 0x29B8771 VA: 0x29B8670
	public Subject<Character> get_Subject残像終() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AB390 Offset: 0x2AB491 VA: 0x2AB390
	// RVA: 0x29B8680 Offset: 0x29B8781 VA: 0x29B8680
	private void set_Subject残像終(Subject<Character> value) { }

	// RVA: 0x29B8690 Offset: 0x29B8791 VA: 0x29B8690
	private void 残像終(AnimationEvent ev) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AB3A0 Offset: 0x2AB4A1 VA: 0x2AB3A0
	// RVA: 0x29B87C0 Offset: 0x29B88C1 VA: 0x29B87C0
	public Subject<Character> get_Subject武器アニメ() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AB3B0 Offset: 0x2AB4B1 VA: 0x2AB3B0
	// RVA: 0x29B87D0 Offset: 0x29B88D1 VA: 0x29B87D0
	private void set_Subject武器アニメ(Subject<Character> value) { }

	// RVA: 0x29B87E0 Offset: 0x29B88E1 VA: 0x29B87E0
	private void 武器アニメ(AnimationEvent ev) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AB3C0 Offset: 0x2AB4C1 VA: 0x2AB3C0
	// RVA: 0x29B8910 Offset: 0x29B8A11 VA: 0x29B8910
	public Subject<Character> get_Subject武器放り投げる() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AB3D0 Offset: 0x2AB4D1 VA: 0x2AB3D0
	// RVA: 0x29B8920 Offset: 0x29B8A21 VA: 0x29B8920
	private void set_Subject武器放り投げる(Subject<Character> value) { }

	// RVA: 0x29B8930 Offset: 0x29B8A31 VA: 0x29B8930
	private void 武器放り投げる(AnimationEvent ev) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AB3E0 Offset: 0x2AB4E1 VA: 0x2AB3E0
	// RVA: 0x29B8A60 Offset: 0x29B8B61 VA: 0x29B8A60
	public Subject<Character> get_Subjectパーティクル() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AB3F0 Offset: 0x2AB4F1 VA: 0x2AB3F0
	// RVA: 0x29B8A70 Offset: 0x29B8B71 VA: 0x29B8A70
	private void set_Subjectパーティクル(Subject<Character> value) { }

	// RVA: 0x29B8A80 Offset: 0x29B8B81 VA: 0x29B8A80
	private void パーティクル(AnimationEvent ev) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AB400 Offset: 0x2AB501 VA: 0x2AB400
	// RVA: 0x29B8BB0 Offset: 0x29B8CB1 VA: 0x29B8BB0
	public Subject<Character> get_Subject命中パーティクル() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AB410 Offset: 0x2AB511 VA: 0x2AB410
	// RVA: 0x29B8BC0 Offset: 0x29B8CC1 VA: 0x29B8BC0
	private void set_Subject命中パーティクル(Subject<Character> value) { }

	// RVA: 0x29B8BD0 Offset: 0x29B8CD1 VA: 0x29B8BD0
	private void 命中パーティクル(AnimationEvent ev) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AB420 Offset: 0x2AB521 VA: 0x2AB420
	// RVA: 0x29B8D00 Offset: 0x29B8E01 VA: 0x29B8D00
	public Subject<Character> get_Subjectパーティクル削除() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AB430 Offset: 0x2AB531 VA: 0x2AB430
	// RVA: 0x29B8D10 Offset: 0x29B8E11 VA: 0x29B8D10
	private void set_Subjectパーティクル削除(Subject<Character> value) { }

	// RVA: 0x29B8D20 Offset: 0x29B8E21 VA: 0x29B8D20
	private void パーティクル削除(AnimationEvent ev) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AB440 Offset: 0x2AB541 VA: 0x2AB440
	// RVA: 0x29B8E50 Offset: 0x29B8F51 VA: 0x29B8E50
	public Subject<Character> get_Subject地面パーティクル() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AB450 Offset: 0x2AB551 VA: 0x2AB450
	// RVA: 0x29B8E60 Offset: 0x29B8F61 VA: 0x29B8E60
	private void set_Subject地面パーティクル(Subject<Character> value) { }

	// RVA: 0x29B8E70 Offset: 0x29B8F71 VA: 0x29B8E70
	private void 地面パーティクル(AnimationEvent ev) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AB460 Offset: 0x2AB561 VA: 0x2AB460
	// RVA: 0x29B8FA0 Offset: 0x29B90A1 VA: 0x29B8FA0
	public Subject<Character> get_Subject表情() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AB470 Offset: 0x2AB571 VA: 0x2AB470
	// RVA: 0x29B8FB0 Offset: 0x29B90B1 VA: 0x29B8FB0
	private void set_Subject表情(Subject<Character> value) { }

	// RVA: 0x29B8FC0 Offset: 0x29B90C1 VA: 0x29B8FC0
	private void 表情(AnimationEvent ev) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AB480 Offset: 0x2AB581 VA: 0x2AB480
	// RVA: 0x29B90F0 Offset: 0x29B91F1 VA: 0x29B90F0
	public Subject<Character> get_Subject注目率() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AB490 Offset: 0x2AB591 VA: 0x2AB490
	// RVA: 0x29B9100 Offset: 0x29B9201 VA: 0x29B9100
	private void set_Subject注目率(Subject<Character> value) { }

	// RVA: 0x29B9110 Offset: 0x29B9211 VA: 0x29B9110
	private void 注目率(AnimationEvent ev) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AB4A0 Offset: 0x2AB5A1 VA: 0x2AB4A0
	// RVA: 0x29B9240 Offset: 0x29B9341 VA: 0x29B9240
	public Subject<Character> get_Subject画面揺れ() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AB4B0 Offset: 0x2AB5B1 VA: 0x2AB4B0
	// RVA: 0x29B9250 Offset: 0x29B9351 VA: 0x29B9250
	private void set_Subject画面揺れ(Subject<Character> value) { }

	// RVA: 0x29B9260 Offset: 0x29B9361 VA: 0x29B9260
	private void 画面揺れ(AnimationEvent ev) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AB4C0 Offset: 0x2AB5C1 VA: 0x2AB4C0
	// RVA: 0x29B9390 Offset: 0x29B9491 VA: 0x29B9390
	public Subject<Character> get_Subjectアーマー振動() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AB4D0 Offset: 0x2AB5D1 VA: 0x2AB4D0
	// RVA: 0x29B93A0 Offset: 0x29B94A1 VA: 0x29B93A0
	private void set_Subjectアーマー振動(Subject<Character> value) { }

	// RVA: 0x29B93B0 Offset: 0x29B94B1 VA: 0x29B93B0
	private void アーマー振動(AnimationEvent ev) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AB4E0 Offset: 0x2AB5E1 VA: 0x2AB4E0
	// RVA: 0x29B94E0 Offset: 0x29B95E1 VA: 0x29B94E0
	public Subject<Character> get_Subject音汎用() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AB4F0 Offset: 0x2AB5F1 VA: 0x2AB4F0
	// RVA: 0x29B94F0 Offset: 0x29B95F1 VA: 0x29B94F0
	private void set_Subject音汎用(Subject<Character> value) { }

	// RVA: 0x29B9500 Offset: 0x29B9601 VA: 0x29B9500
	private void 音汎用(AnimationEvent ev) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AB500 Offset: 0x2AB601 VA: 0x2AB500
	// RVA: 0x29B9630 Offset: 0x29B9731 VA: 0x29B9630
	public Subject<Character> get_Subject音ボイス() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AB510 Offset: 0x2AB611 VA: 0x2AB510
	// RVA: 0x29B9640 Offset: 0x29B9741 VA: 0x29B9640
	private void set_Subject音ボイス(Subject<Character> value) { }

	// RVA: 0x29B9650 Offset: 0x29B9751 VA: 0x29B9650
	private void 音ボイス(AnimationEvent ev) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AB520 Offset: 0x2AB621 VA: 0x2AB520
	// RVA: 0x29B9780 Offset: 0x29B9881 VA: 0x29B9780
	public Subject<Character> get_Subject音攻撃ボイス() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AB530 Offset: 0x2AB631 VA: 0x2AB530
	// RVA: 0x29B9790 Offset: 0x29B9891 VA: 0x29B9790
	private void set_Subject音攻撃ボイス(Subject<Character> value) { }

	// RVA: 0x29B97A0 Offset: 0x29B98A1 VA: 0x29B97A0
	private void 音攻撃ボイス(AnimationEvent ev) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AB540 Offset: 0x2AB641 VA: 0x2AB540
	// RVA: 0x29B98D0 Offset: 0x29B99D1 VA: 0x29B98D0
	public Subject<Character> get_Subject音必殺ボイス() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AB550 Offset: 0x2AB651 VA: 0x2AB550
	// RVA: 0x29B98E0 Offset: 0x29B99E1 VA: 0x29B98E0
	private void set_Subject音必殺ボイス(Subject<Character> value) { }

	// RVA: 0x29B98F0 Offset: 0x29B99F1 VA: 0x29B98F0
	private void 音必殺ボイス(AnimationEvent ev) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AB560 Offset: 0x2AB661 VA: 0x2AB560
	// RVA: 0x29B9A20 Offset: 0x29B9B21 VA: 0x29B9A20
	public Subject<Character> get_Subject魔法動作1() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AB570 Offset: 0x2AB671 VA: 0x2AB570
	// RVA: 0x29B9A30 Offset: 0x29B9B31 VA: 0x29B9A30
	private void set_Subject魔法動作1(Subject<Character> value) { }

	// RVA: 0x29B9A40 Offset: 0x29B9B41 VA: 0x29B9A40
	private void 魔法動作1(AnimationEvent ev) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AB580 Offset: 0x2AB681 VA: 0x2AB580
	// RVA: 0x29B9B70 Offset: 0x29B9C71 VA: 0x29B9B70
	public Subject<Character> get_Subject魔法動作2() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AB590 Offset: 0x2AB691 VA: 0x2AB590
	// RVA: 0x29B9B80 Offset: 0x29B9C81 VA: 0x29B9B80
	private void set_Subject魔法動作2(Subject<Character> value) { }

	// RVA: 0x29B9B90 Offset: 0x29B9C91 VA: 0x29B9B90
	private void 魔法動作2(AnimationEvent ev) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AB5A0 Offset: 0x2AB6A1 VA: 0x2AB5A0
	// RVA: 0x29B9CC0 Offset: 0x29B9DC1 VA: 0x29B9CC0
	public Subject<Character> get_Subject魔法動作3() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AB5B0 Offset: 0x2AB6B1 VA: 0x2AB5B0
	// RVA: 0x29B9CD0 Offset: 0x29B9DD1 VA: 0x29B9CD0
	private void set_Subject魔法動作3(Subject<Character> value) { }

	// RVA: 0x29B9CE0 Offset: 0x29B9DE1 VA: 0x29B9CE0
	private void 魔法動作3(AnimationEvent ev) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AB5C0 Offset: 0x2AB6C1 VA: 0x2AB5C0
	// RVA: 0x29B9E10 Offset: 0x29B9F11 VA: 0x29B9E10
	public Subject<Character> get_Subject手綱() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AB5D0 Offset: 0x2AB6D1 VA: 0x2AB5D0
	// RVA: 0x29B9E20 Offset: 0x29B9F21 VA: 0x29B9E20
	private void set_Subject手綱(Subject<Character> value) { }

	// RVA: 0x29B9E30 Offset: 0x29B9F31 VA: 0x29B9E30
	private void 手綱(AnimationEvent ev) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AB5E0 Offset: 0x2AB6E1 VA: 0x2AB5E0
	// RVA: 0x29B9F60 Offset: 0x29BA061 VA: 0x29B9F60
	public Subject<Character> get_Subjectフェード() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AB5F0 Offset: 0x2AB6F1 VA: 0x2AB5F0
	// RVA: 0x29B9F70 Offset: 0x29BA071 VA: 0x29B9F70
	private void set_Subjectフェード(Subject<Character> value) { }

	// RVA: 0x29B9F80 Offset: 0x29BA081 VA: 0x29B9F80
	private void フェード(AnimationEvent ev) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AB600 Offset: 0x2AB701 VA: 0x2AB600
	// RVA: 0x29BA0B0 Offset: 0x29BA1B1 VA: 0x29BA0B0
	public Subject<Character> get_Subject姿を隠す() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AB610 Offset: 0x2AB711 VA: 0x2AB610
	// RVA: 0x29BA0C0 Offset: 0x29BA1C1 VA: 0x29BA0C0
	private void set_Subject姿を隠す(Subject<Character> value) { }

	// RVA: 0x29BA0D0 Offset: 0x29BA1D1 VA: 0x29BA0D0
	private void 姿を隠す(AnimationEvent ev) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AB620 Offset: 0x2AB721 VA: 0x2AB620
	// RVA: 0x29BA200 Offset: 0x29BA301 VA: 0x29BA200
	public Subject<Character> get_Subject再生ジャンプ() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AB630 Offset: 0x2AB731 VA: 0x2AB630
	// RVA: 0x29BA210 Offset: 0x29BA311 VA: 0x29BA210
	private void set_Subject再生ジャンプ(Subject<Character> value) { }

	// RVA: 0x29BA220 Offset: 0x29BA321 VA: 0x29BA220
	private void 再生ジャンプ(AnimationEvent ev) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AB640 Offset: 0x2AB741 VA: 0x2AB640
	// RVA: 0x29BA350 Offset: 0x29BA451 VA: 0x29BA350
	public Subject<Character> get_Subjectラジアルブラー() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AB650 Offset: 0x2AB751 VA: 0x2AB650
	// RVA: 0x29BA360 Offset: 0x29BA461 VA: 0x29BA360
	private void set_Subjectラジアルブラー(Subject<Character> value) { }

	// RVA: 0x29BA370 Offset: 0x29BA471 VA: 0x29BA370
	private void ラジアルブラー(AnimationEvent ev) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AB660 Offset: 0x2AB761 VA: 0x2AB660
	// RVA: 0x29BA4A0 Offset: 0x29BA5A1 VA: 0x29BA4A0
	public Subject<Character> get_Subject背景暗さ() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AB670 Offset: 0x2AB771 VA: 0x2AB670
	// RVA: 0x29BA4B0 Offset: 0x29BA5B1 VA: 0x29BA4B0
	private void set_Subject背景暗さ(Subject<Character> value) { }

	// RVA: 0x29BA4C0 Offset: 0x29BA5C1 VA: 0x29BA4C0
	private void 背景暗さ(AnimationEvent ev) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AB680 Offset: 0x2AB781 VA: 0x2AB680
	// RVA: 0x29BA5F0 Offset: 0x29BA6F1 VA: 0x29BA5F0
	public Subject<Character> get_Subject体格標準化() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AB690 Offset: 0x2AB791 VA: 0x2AB690
	// RVA: 0x29BA600 Offset: 0x29BA701 VA: 0x29BA600
	private void set_Subject体格標準化(Subject<Character> value) { }

	// RVA: 0x29BA610 Offset: 0x29BA711 VA: 0x29BA610
	private void 体格標準化(AnimationEvent ev) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AB6A0 Offset: 0x2AB7A1 VA: 0x2AB6A0
	// RVA: 0x29BA740 Offset: 0x29BA841 VA: 0x29BA740
	public Subject<Character> get_SubjectFootIK() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AB6B0 Offset: 0x2AB7B1 VA: 0x2AB6B0
	// RVA: 0x29BA750 Offset: 0x29BA851 VA: 0x29BA750
	private void set_SubjectFootIK(Subject<Character> value) { }

	// RVA: 0x29BA760 Offset: 0x29BA861 VA: 0x29BA760
	private void FootIK(AnimationEvent ev) { }

	// RVA: 0x29BA890 Offset: 0x29BA991 VA: 0x29BA890
	private void OnDestroy() { }

	// RVA: 0x29BB090 Offset: 0x29BB191 VA: 0x29BB090
	public void .ctor() { }
}

