// Namespace: App
[DisallowMultipleComponent] // RVA: 0x274DE0 Offset: 0x274EE1 VA: 0x274DE0
public class UnitSignal : MonoBehaviour // TypeDefIndex: 8987
{
	// Fields
	private UnitModel m_Model; // 0x18
	private UnitSignal.Func m_HitCallback; // 0x20
	private UnitSignal.Func m_ShootCallback; // 0x28
	private UnitSignal.Func m_AvoidCallback; // 0x30
	private object m_Arg; // 0x38

	// Methods

	// RVA: 0x2092C20 Offset: 0x2092D21 VA: 0x2092C20
	public UnitSignal SetModel(UnitModel model) { }

	// RVA: 0x2092C50 Offset: 0x2092D51 VA: 0x2092C50
	public UnitSignal SetHitCallback(UnitSignal.Func func) { }

	// RVA: 0x2092C80 Offset: 0x2092D81 VA: 0x2092C80
	public UnitSignal SetShootCallback(UnitSignal.Func func) { }

	// RVA: 0x2092CB0 Offset: 0x2092DB1 VA: 0x2092CB0
	public UnitSignal SetAvoidCallback(UnitSignal.Func func) { }

	// RVA: 0x2092CE0 Offset: 0x2092DE1 VA: 0x2092CE0
	public UnitSignal SetUnitItem(UnitItem unitItem) { }

	// RVA: 0x2092D10 Offset: 0x2092E11 VA: 0x2092D10
	public UnitSignal ClearCallback() { }

	// RVA: 0x2092D70 Offset: 0x2092E71 VA: 0x2092D70
	public static void PlayShoot(UnitSignal signal) { }

	// RVA: 0x2093000 Offset: 0x2093101 VA: 0x2093000
	private void OnFootstep(string name) { }

	// RVA: 0x2093390 Offset: 0x2093491 VA: 0x2093390
	private void OnFlapping() { }

	// RVA: 0x2093450 Offset: 0x2093551 VA: 0x2093450
	private void 羽ばたき() { }

	// RVA: 0x2093510 Offset: 0x2093611 VA: 0x2093510
	private void 左足接地() { }

	// RVA: 0x2093550 Offset: 0x2093651 VA: 0x2093550
	private void 右足接地() { }

	// RVA: 0x2093590 Offset: 0x2093691 VA: 0x2093590
	private void 左前足接地() { }

	// RVA: 0x20935D0 Offset: 0x20936D1 VA: 0x20935D0
	private void 右前足接地() { }

	// RVA: 0x2093610 Offset: 0x2093711 VA: 0x2093610
	private void 左後足接地() { }

	// RVA: 0x2093650 Offset: 0x2093751 VA: 0x2093650
	private void 右後足接地() { }

	// RVA: 0x2093690 Offset: 0x2093791 VA: 0x2093690
	private void 命中() { }

	// RVA: 0x20936B0 Offset: 0x20937B1 VA: 0x20936B0
	private void 魔法動作1() { }

	// RVA: 0x20936C0 Offset: 0x20937C1 VA: 0x20936C0
	private void 魔法動作2() { }

	// RVA: 0x20936D0 Offset: 0x20937D1 VA: 0x20936D0
	private void 魔法動作3() { }

	// RVA: 0x2093720 Offset: 0x2093821 VA: 0x2093720
	private void 相手回避() { }

	// RVA: 0x2093740 Offset: 0x2093841 VA: 0x2093740
	private void 発射() { }

	// RVA: 0x2093760 Offset: 0x2093861 VA: 0x2093760
	private void 前キャンセル() { }

	// RVA: 0x2093770 Offset: 0x2093871 VA: 0x2093770
	private void 後キャン始() { }

	// RVA: 0x2093780 Offset: 0x2093881 VA: 0x2093780
	private void 相手動作() { }

	// RVA: 0x2093790 Offset: 0x2093891 VA: 0x2093790
	private void ジャンプ() { }

	// RVA: 0x20937A0 Offset: 0x20938A1 VA: 0x20937A0
	private void 左足上昇() { }

	// RVA: 0x20937B0 Offset: 0x20938B1 VA: 0x20937B0
	private void 右足上昇() { }

	// RVA: 0x20937C0 Offset: 0x20938C1 VA: 0x20937C0
	private void 左前足上昇() { }

	// RVA: 0x20937D0 Offset: 0x20938D1 VA: 0x20937D0
	private void 右前足上昇() { }

	// RVA: 0x20937E0 Offset: 0x20938E1 VA: 0x20937E0
	private void 左後足上昇() { }

	// RVA: 0x20937F0 Offset: 0x20938F1 VA: 0x20937F0
	private void 右後足上昇() { }

	// RVA: 0x2093800 Offset: 0x2093901 VA: 0x2093800
	private void カメラ() { }

	// RVA: 0x2093810 Offset: 0x2093911 VA: 0x2093810
	private void カメラ戻す() { }

	// RVA: 0x2093820 Offset: 0x2093921 VA: 0x2093820
	private void 重い動作始() { }

	// RVA: 0x2093830 Offset: 0x2093931 VA: 0x2093830
	private void 重い動作終() { }

	// RVA: 0x2093840 Offset: 0x2093941 VA: 0x2093840
	private void 素早い動作始() { }

	// RVA: 0x2093850 Offset: 0x2093951 VA: 0x2093850
	private void 素早い動作終() { }

	// RVA: 0x2093860 Offset: 0x2093961 VA: 0x2093860
	private void ワールド時間() { }

	// RVA: 0x2093870 Offset: 0x2093971 VA: 0x2093870
	private void 武器軌跡始() { }

	// RVA: 0x2093880 Offset: 0x2093981 VA: 0x2093880
	private void 武器軌跡終() { }

	// RVA: 0x2093890 Offset: 0x2093991 VA: 0x2093890
	private void 左手軌跡始() { }

	// RVA: 0x20938A0 Offset: 0x20939A1 VA: 0x20938A0
	private void 左手軌跡終() { }

	// RVA: 0x20938B0 Offset: 0x20939B1 VA: 0x20938B0
	private void 残像始() { }

	// RVA: 0x20938C0 Offset: 0x20939C1 VA: 0x20938C0
	private void 残像終() { }

	// RVA: 0x20938D0 Offset: 0x20939D1 VA: 0x20938D0
	private void 武器アニメ() { }

	// RVA: 0x20938E0 Offset: 0x20939E1 VA: 0x20938E0
	private void 武器放り投げる() { }

	// RVA: 0x20938F0 Offset: 0x20939F1 VA: 0x20938F0
	private void パーティクル() { }

	// RVA: 0x2093900 Offset: 0x2093A01 VA: 0x2093900
	private void パーティクル削除() { }

	// RVA: 0x2093910 Offset: 0x2093A11 VA: 0x2093910
	private void 地面パーティクル() { }

	// RVA: 0x2093920 Offset: 0x2093A21 VA: 0x2093920
	private void 表情() { }

	// RVA: 0x2093930 Offset: 0x2093A31 VA: 0x2093930
	private void 注目率() { }

	// RVA: 0x2093940 Offset: 0x2093A41 VA: 0x2093940
	private void 画面揺れ() { }

	// RVA: 0x2093950 Offset: 0x2093A51 VA: 0x2093950
	private void アーマー振動() { }

	// RVA: 0x2093960 Offset: 0x2093A61 VA: 0x2093960
	private void 音汎用() { }

	// RVA: 0x2093970 Offset: 0x2093A71 VA: 0x2093970
	private void 音ボイス() { }

	// RVA: 0x2093980 Offset: 0x2093A81 VA: 0x2093980
	private void 音攻撃ボイス() { }

	// RVA: 0x2093990 Offset: 0x2093A91 VA: 0x2093990
	private void 音必殺ボイス() { }

	// RVA: 0x20939A0 Offset: 0x2093AA1 VA: 0x20939A0
	private void 手綱() { }

	// RVA: 0x20939B0 Offset: 0x2093AB1 VA: 0x20939B0
	private void 拠点アクセス() { }

	// RVA: 0x20939C0 Offset: 0x2093AC1 VA: 0x20939C0
	private void フェード() { }

	// RVA: 0x20939D0 Offset: 0x2093AD1 VA: 0x20939D0
	private void 姿を隠す() { }

	// RVA: 0x20939E0 Offset: 0x2093AE1 VA: 0x20939E0
	private void 再生ジャンプ() { }

	// RVA: 0x20939F0 Offset: 0x2093AF1 VA: 0x20939F0
	private void ラジアルブラー() { }

	// RVA: 0x2093A00 Offset: 0x2093B01 VA: 0x2093A00
	private void 背景暗さ() { }

	// RVA: 0x2093A10 Offset: 0x2093B11 VA: 0x2093A10
	private void なし() { }

	// RVA: 0x2093A20 Offset: 0x2093B21 VA: 0x2093A20
	private void 突進前キャン() { }

	// RVA: 0x2093A30 Offset: 0x2093B31 VA: 0x2093A30
	private void 後キャン終() { }

	// RVA: 0x2093A40 Offset: 0x2093B41 VA: 0x2093A40
	private void 攻撃可能範囲() { }

	// RVA: 0x2093A50 Offset: 0x2093B51 VA: 0x2093A50
	private void 着地() { }

	// RVA: 0x2093A60 Offset: 0x2093B61 VA: 0x2093A60
	private void 遷移時間() { }

	// RVA: 0x2093A70 Offset: 0x2093B71 VA: 0x2093A70
	private void 汎用Object() { }

	// RVA: 0x2093A80 Offset: 0x2093B81 VA: 0x2093A80
	private void Run速度() { }

	// RVA: 0x2093A90 Offset: 0x2093B91 VA: 0x2093A90
	private void Vec3() { }

	// RVA: 0x2093AA0 Offset: 0x2093BA1 VA: 0x2093AA0
	private void 最終位置() { }

	// RVA: 0x2093AB0 Offset: 0x2093BB1 VA: 0x2093AB0
	private void 死亡落下() { }

	// RVA: 0x2093AC0 Offset: 0x2093BC1 VA: 0x2093AC0
	private void 自動生成除外() { }

	// RVA: 0x2093AD0 Offset: 0x2093BD1 VA: 0x2093AD0
	private void 開発一時停止() { }

	// RVA: 0x2093AE0 Offset: 0x2093BE1 VA: 0x2093AE0
	public void .ctor() { }
}

