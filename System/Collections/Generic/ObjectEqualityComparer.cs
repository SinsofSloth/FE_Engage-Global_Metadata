// Namespace: System.Collections.Generic
[Serializable]
internal class ObjectEqualityComparer<T> : EqualityComparer<T> // TypeDefIndex: 1422
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 8
	public override bool Equals(T x, T y) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BA5CD0 Offset: 0x2BA5DD1 VA: 0x2BA5CD0
	|-ObjectEqualityComparer<AsyncOperationHandle<object>>.Equals
	|
	|-RVA: 0x2BA6190 Offset: 0x2BA6291 VA: 0x2BA6190
	|-ObjectEqualityComparer<IntervalTree.Entry<object>>.Equals
	|
	|-RVA: 0x2BA6660 Offset: 0x2BA6761 VA: 0x2BA6660
	|-ObjectEqualityComparer<KeyValuePair<DateTime, object>>.Equals
	|
	|-RVA: 0x2BA6AD0 Offset: 0x2BA6BD1 VA: 0x2BA6AD0
	|-ObjectEqualityComparer<KeyValuePair<int, object>>.Equals
	|
	|-RVA: 0x2BA6F40 Offset: 0x2BA7041 VA: 0x2BA6F40
	|-ObjectEqualityComparer<KeyValuePair<object, ValueTuple<int, DateTime, object>>>.Equals
	|
	|-RVA: 0x2BA7410 Offset: 0x2BA7511 VA: 0x2BA7410
	|-ObjectEqualityComparer<KeyValuePair<object, object>>.Equals
	|
	|-RVA: 0x2BA7880 Offset: 0x2BA7981 VA: 0x2BA7880
	|-ObjectEqualityComparer<CommonBattleSequence.Reliance<object>>.Equals
	|
	|-RVA: 0x2BA7D50 Offset: 0x2BA7E51 VA: 0x2BA7D50
	|-ObjectEqualityComparer<RenderGraphResourcePool.ResourceLogInfo<object>>.Equals
	|
	|-RVA: 0x2BA81C0 Offset: 0x2BA82C1 VA: 0x2BA81C0
	|-ObjectEqualityComparer<TimeInterval<object>>.Equals
	|
	|-RVA: 0x2BA85F0 Offset: 0x2BA86F1 VA: 0x2BA85F0
	|-ObjectEqualityComparer<Timestamped<object>>.Equals
	|
	|-RVA: 0x2BA8A90 Offset: 0x2BA8B91 VA: 0x2BA8A90
	|-ObjectEqualityComparer<UniTask<object>>.Equals
	|
	|-RVA: 0x2BA8EF0 Offset: 0x2BA8FF1 VA: 0x2BA8EF0
	|-ObjectEqualityComparer<ValueTuple<ValueTuple<bool, object>>>.Equals
	|
	|-RVA: 0x2BA9320 Offset: 0x2BA9421 VA: 0x2BA9320
	|-ObjectEqualityComparer<ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>.Equals
	|
	|-RVA: 0x2BA97D0 Offset: 0x2BA98D1 VA: 0x2BA97D0
	|-ObjectEqualityComparer<ValueTuple<bool, UniTask<object>>>.Equals
	|
	|-RVA: 0x2BA9C80 Offset: 0x2BA9D81 VA: 0x2BA9C80
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>.Equals
	|
	|-RVA: 0x2BAA130 Offset: 0x2BAA231 VA: 0x2BAA130
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>>.Equals
	|
	|-RVA: 0x2BAA620 Offset: 0x2BAA721 VA: 0x2BAA620
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>>>.Equals
	|
	|-RVA: 0x2BAAB20 Offset: 0x2BAAC21 VA: 0x2BAAB20
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>>>.Equals
	|
	|-RVA: 0x2BAAF80 Offset: 0x2BAB081 VA: 0x2BAAF80
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>>>.Equals
	|
	|-RVA: 0x2BAB3E0 Offset: 0x2BAB4E1 VA: 0x2BAB3E0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>>>.Equals
	|
	|-RVA: 0x2BAB940 Offset: 0x2BABA41 VA: 0x2BAB940
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>>>.Equals
	|
	|-RVA: 0x2BABDA0 Offset: 0x2BABEA1 VA: 0x2BABDA0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>>>.Equals
	|
	|-RVA: 0x2BAC2E0 Offset: 0x2BAC3E1 VA: 0x2BAC2E0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>>>.Equals
	|
	|-RVA: 0x3A566D0 Offset: 0x3A567D1 VA: 0x3A566D0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>>>.Equals
	|
	|-RVA: 0x3A56B80 Offset: 0x3A56C81 VA: 0x3A56B80
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>>>.Equals
	|
	|-RVA: 0x3A57080 Offset: 0x3A57181 VA: 0x3A57080
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>>>.Equals
	|
	|-RVA: 0x3A57580 Offset: 0x3A57681 VA: 0x3A57580
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>>>.Equals
	|
	|-RVA: 0x3A57AC0 Offset: 0x3A57BC1 VA: 0x3A57AC0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>>>.Equals
	|
	|-RVA: 0x3A58000 Offset: 0x3A58101 VA: 0x3A58000
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>>>.Equals
	|
	|-RVA: 0x3A584B0 Offset: 0x3A585B1 VA: 0x3A584B0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>>>.Equals
	|
	|-RVA: 0x3A589B0 Offset: 0x3A58AB1 VA: 0x3A589B0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>>>.Equals
	|
	|-RVA: 0x3A58E10 Offset: 0x3A58F11 VA: 0x3A58E10
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>>>.Equals
	|
	|-RVA: 0x3A59300 Offset: 0x3A59401 VA: 0x3A59300
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>>>.Equals
	|
	|-RVA: 0x3A597B0 Offset: 0x3A598B1 VA: 0x3A597B0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>>>.Equals
	|
	|-RVA: 0x3A59CF0 Offset: 0x3A59DF1 VA: 0x3A59CF0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>>>.Equals
	|
	|-RVA: 0x3A5A1F0 Offset: 0x3A5A2F1 VA: 0x3A5A1F0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>>>.Equals
	|
	|-RVA: 0x3A5A6F0 Offset: 0x3A5A7F1 VA: 0x3A5A6F0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>>>.Equals
	|
	|-RVA: 0x3A5AC50 Offset: 0x3A5AD51 VA: 0x3A5AC50
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>>>.Equals
	|
	|-RVA: 0x3A5B1B0 Offset: 0x3A5B2B1 VA: 0x3A5B1B0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>>>.Equals
	|
	|-RVA: 0x3A5B750 Offset: 0x3A5B851 VA: 0x3A5B750
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>>>.Equals
	|
	|-RVA: 0x3A5BD00 Offset: 0x3A5BE01 VA: 0x3A5BD00
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>>>.Equals
	|
	|-RVA: 0x3A5C310 Offset: 0x3A5C411 VA: 0x3A5C310
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>>.Equals
	|
	|-RVA: 0x3A5C780 Offset: 0x3A5C881 VA: 0x3A5C780
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>>.Equals
	|
	|-RVA: 0x3A5CBF0 Offset: 0x3A5CCF1 VA: 0x3A5CBF0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>>.Equals
	|
	|-RVA: 0x3A5D0E0 Offset: 0x3A5D1E1 VA: 0x3A5D0E0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>>.Equals
	|
	|-RVA: 0x3A5D550 Offset: 0x3A5D651 VA: 0x3A5D550
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>>.Equals
	|
	|-RVA: 0x3A5DA00 Offset: 0x3A5DB01 VA: 0x3A5DA00
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>>.Equals
	|
	|-RVA: 0x3A5DEF0 Offset: 0x3A5DFF1 VA: 0x3A5DEF0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>>.Equals
	|
	|-RVA: 0x3A5E3A0 Offset: 0x3A5E4A1 VA: 0x3A5E3A0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>>.Equals
	|
	|-RVA: 0x3A5E890 Offset: 0x3A5E991 VA: 0x3A5E890
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>>.Equals
	|
	|-RVA: 0x3A5ED80 Offset: 0x3A5EE81 VA: 0x3A5ED80
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>>.Equals
	|
	|-RVA: 0x3A5F230 Offset: 0x3A5F331 VA: 0x3A5F230
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>>.Equals
	|
	|-RVA: 0x3A5F6E0 Offset: 0x3A5F7E1 VA: 0x3A5F6E0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>>.Equals
	|
	|-RVA: 0x3A5FB90 Offset: 0x3A5FC91 VA: 0x3A5FB90
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>>.Equals
	|
	|-RVA: 0x3A60080 Offset: 0x3A60181 VA: 0x3A60080
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>>.Equals
	|
	|-RVA: 0x3A604F0 Offset: 0x3A605F1 VA: 0x3A604F0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>>.Equals
	|
	|-RVA: 0x3A609A0 Offset: 0x3A60AA1 VA: 0x3A609A0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>>.Equals
	|
	|-RVA: 0x3A60E90 Offset: 0x3A60F91 VA: 0x3A60E90
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>>.Equals
	|
	|-RVA: 0x3A61340 Offset: 0x3A61441 VA: 0x3A61340
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>>.Equals
	|
	|-RVA: 0x3A61830 Offset: 0x3A61931 VA: 0x3A61830
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>>.Equals
	|
	|-RVA: 0x3A61D20 Offset: 0x3A61E21 VA: 0x3A61D20
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.Equals
	|
	|-RVA: 0x3A62280 Offset: 0x3A62381 VA: 0x3A62280
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>>.Equals
	|
	|-RVA: 0x3A62780 Offset: 0x3A62881 VA: 0x3A62780
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.Equals
	|
	|-RVA: 0x3A62D30 Offset: 0x3A62E31 VA: 0x3A62D30
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>>.Equals
	|
	|-RVA: 0x3A63290 Offset: 0x3A63391 VA: 0x3A63290
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.Equals
	|
	|-RVA: 0x3A638A0 Offset: 0x3A639A1 VA: 0x3A638A0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>>.Equals
	|
	|-RVA: 0x3A63E00 Offset: 0x3A63F01 VA: 0x3A63E00
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.Equals
	|
	|-RVA: 0x3A64460 Offset: 0x3A64561 VA: 0x3A64460
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>>.Equals
	|
	|-RVA: 0x3A64A00 Offset: 0x3A64B01 VA: 0x3A64A00
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.Equals
	|
	|-RVA: 0x3A650C0 Offset: 0x3A651C1 VA: 0x3A650C0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>>.Equals
	|
	|-RVA: 0x3A65670 Offset: 0x3A65771 VA: 0x3A65670
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>.Equals
	|
	|-RVA: 0x3A65A80 Offset: 0x3A65B81 VA: 0x3A65A80
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>.Equals
	|
	|-RVA: 0x3A65E90 Offset: 0x3A65F91 VA: 0x3A65E90
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>.Equals
	|
	|-RVA: 0x3A663D0 Offset: 0x3A664D1 VA: 0x3A663D0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>.Equals
	|
	|-RVA: 0x3A667E0 Offset: 0x3A668E1 VA: 0x3A667E0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>.Equals
	|
	|-RVA: 0x3A66CD0 Offset: 0x3A66DD1 VA: 0x3A66CD0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>.Equals
	|
	|-RVA: 0x3A67180 Offset: 0x3A67281 VA: 0x3A67180
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>.Equals
	|
	|-RVA: 0x3A675B0 Offset: 0x3A676B1 VA: 0x3A675B0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>.Equals
	|
	|-RVA: 0x3A67A60 Offset: 0x3A67B61 VA: 0x3A67A60
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>.Equals
	|
	|-RVA: 0x3A67F10 Offset: 0x3A68011 VA: 0x3A67F10
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>.Equals
	|
	|-RVA: 0x3A68400 Offset: 0x3A68501 VA: 0x3A68400
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>.Equals
	|
	|-RVA: 0x3A688F0 Offset: 0x3A689F1 VA: 0x3A688F0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>.Equals
	|
	|-RVA: 0x3A68D20 Offset: 0x3A68E21 VA: 0x3A68D20
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>.Equals
	|
	|-RVA: 0x3A691D0 Offset: 0x3A692D1 VA: 0x3A691D0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>.Equals
	|
	|-RVA: 0x3A695E0 Offset: 0x3A696E1 VA: 0x3A695E0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>.Equals
	|
	|-RVA: 0x3A69A90 Offset: 0x3A69B91 VA: 0x3A69A90
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>.Equals
	|
	|-RVA: 0x3A69F40 Offset: 0x3A6A041 VA: 0x3A69F40
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>.Equals
	|
	|-RVA: 0x3A6A430 Offset: 0x3A6A531 VA: 0x3A6A430
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>.Equals
	|
	|-RVA: 0x3A6A8E0 Offset: 0x3A6A9E1 VA: 0x3A6A8E0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>.Equals
	|
	|-RVA: 0x3A6AD90 Offset: 0x3A6AE91 VA: 0x3A6AD90
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.Equals
	|
	|-RVA: 0x3A6B2F0 Offset: 0x3A6B3F1 VA: 0x3A6B2F0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>.Equals
	|
	|-RVA: 0x3A6B7E0 Offset: 0x3A6B8E1 VA: 0x3A6B7E0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.Equals
	|
	|-RVA: 0x3A6BD80 Offset: 0x3A6BE81 VA: 0x3A6BD80
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>.Equals
	|
	|-RVA: 0x3A6C280 Offset: 0x3A6C381 VA: 0x3A6C280
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.Equals
	|
	|-RVA: 0x3A6C890 Offset: 0x3A6C991 VA: 0x3A6C890
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>.Equals
	|
	|-RVA: 0x3A6CDF0 Offset: 0x3A6CEF1 VA: 0x3A6CDF0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.Equals
	|
	|-RVA: 0x3A6D440 Offset: 0x3A6D541 VA: 0x3A6D440
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>.Equals
	|
	|-RVA: 0x3A6D9A0 Offset: 0x3A6DAA1 VA: 0x3A6D9A0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.Equals
	|
	|-RVA: 0x3A6E060 Offset: 0x3A6E161 VA: 0x3A6E060
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>.Equals
	|
	|-RVA: 0x3A6E600 Offset: 0x3A6E701 VA: 0x3A6E600
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>>>.Equals
	|
	|-RVA: 0x3A6EAD0 Offset: 0x3A6EBD1 VA: 0x3A6EAD0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.Equals
	|
	|-RVA: 0x3A6EFA0 Offset: 0x3A6F0A1 VA: 0x3A6EFA0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>.Equals
	|
	|-RVA: 0x3A6F410 Offset: 0x3A6F511 VA: 0x3A6F410
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, bool>>>.Equals
	|
	|-RVA: 0x3A6F880 Offset: 0x3A6F981 VA: 0x3A6F880
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, Bounds>>>.Equals
	|
	|-RVA: 0x3A6FD30 Offset: 0x3A6FE31 VA: 0x3A6FD30
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, byte>>>.Equals
	|
	|-RVA: 0x3A701A0 Offset: 0x3A702A1 VA: 0x3A701A0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, Color>>>.Equals
	|
	|-RVA: 0x3A70650 Offset: 0x3A70751 VA: 0x3A70650
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, double>>>.Equals
	|
	|-RVA: 0x3C2F060 Offset: 0x3C2F161 VA: 0x3C2F060
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, int>>>.Equals
	|
	|-RVA: 0x3C2F4D0 Offset: 0x3C2F5D1 VA: 0x3C2F4D0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, long>>>.Equals
	|
	|-RVA: 0x3C2F980 Offset: 0x3C2FA81 VA: 0x3C2F980
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, object>>>.Equals
	|
	|-RVA: 0x3C2FE30 Offset: 0x3C2FF31 VA: 0x3C2FE30
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, Quaternion>>>.Equals
	|
	|-RVA: 0x3C302E0 Offset: 0x3C303E1 VA: 0x3C302E0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, Rect>>>.Equals
	|
	|-RVA: 0x3C30790 Offset: 0x3C30891 VA: 0x3C30790
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, float>>>.Equals
	|
	|-RVA: 0x3C30C00 Offset: 0x3C30D01 VA: 0x3C30C00
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, UniTask>>>.Equals
	|
	|-RVA: 0x3C310B0 Offset: 0x3C311B1 VA: 0x3C310B0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, Unit>>>.Equals
	|
	|-RVA: 0x3C31520 Offset: 0x3C31621 VA: 0x3C31520
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, Vector2>>>.Equals
	|
	|-RVA: 0x3C31950 Offset: 0x3C31A51 VA: 0x3C31950
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, Vector3>>>.Equals
	|
	|-RVA: 0x3C31E00 Offset: 0x3C31F01 VA: 0x3C31E00
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, Vector4>>>.Equals
	|
	|-RVA: 0x3C322B0 Offset: 0x3C323B1 VA: 0x3C322B0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<int, object>>>.Equals
	|
	|-RVA: 0x3C32760 Offset: 0x3C32861 VA: 0x3C32760
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<object, object>>>.Equals
	|
	|-RVA: 0x3C32C10 Offset: 0x3C32D11 VA: 0x3C32C10
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.Equals
	|
	|-RVA: 0x3C33110 Offset: 0x3C33211 VA: 0x3C33110
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<object, object, object>>>.Equals
	|
	|-RVA: 0x3C335C0 Offset: 0x3C336C1 VA: 0x3C335C0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.Equals
	|
	|-RVA: 0x3C33B20 Offset: 0x3C33C21 VA: 0x3C33B20
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<object, object, object, object>>>.Equals
	|
	|-RVA: 0x3C34010 Offset: 0x3C34111 VA: 0x3C34010
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.Equals
	|
	|-RVA: 0x3C345C0 Offset: 0x3C346C1 VA: 0x3C345C0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<object, object, object, object, object>>>.Equals
	|
	|-RVA: 0x3C34AC0 Offset: 0x3C34BC1 VA: 0x3C34AC0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.Equals
	|
	|-RVA: 0x3C350D0 Offset: 0x3C351D1 VA: 0x3C350D0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>.Equals
	|
	|-RVA: 0x3C35630 Offset: 0x3C35731 VA: 0x3C35630
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.Equals
	|
	|-RVA: 0x3C35C90 Offset: 0x3C35D91 VA: 0x3C35C90
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>.Equals
	|
	|-RVA: 0x3C361F0 Offset: 0x3C362F1 VA: 0x3C361F0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>>.Equals
	|
	|-RVA: 0x3C368B0 Offset: 0x3C369B1 VA: 0x3C368B0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.Equals
	|
	|-RVA: 0x3C36D80 Offset: 0x3C36E81 VA: 0x3C36D80
	|-ObjectEqualityComparer<ValueTuple<bool, AsyncUnit>>.Equals
	|
	|-RVA: 0x3C37190 Offset: 0x3C37291 VA: 0x3C37190
	|-ObjectEqualityComparer<ValueTuple<bool, bool>>.Equals
	|
	|-RVA: 0x3C375A0 Offset: 0x3C376A1 VA: 0x3C375A0
	|-ObjectEqualityComparer<ValueTuple<bool, Bounds>>.Equals
	|
	|-RVA: 0x3C37A90 Offset: 0x3C37B91 VA: 0x3C37A90
	|-ObjectEqualityComparer<ValueTuple<bool, byte>>.Equals
	|
	|-RVA: 0x3C37EA0 Offset: 0x3C37FA1 VA: 0x3C37EA0
	|-ObjectEqualityComparer<ValueTuple<bool, Color>>.Equals
	|
	|-RVA: 0x3C38350 Offset: 0x3C38451 VA: 0x3C38350
	|-ObjectEqualityComparer<ValueTuple<bool, double>>.Equals
	|
	|-RVA: 0x3C38780 Offset: 0x3C38881 VA: 0x3C38780
	|-ObjectEqualityComparer<ValueTuple<bool, int>>.Equals
	|
	|-RVA: 0x3C38B90 Offset: 0x3C38C91 VA: 0x3C38B90
	|-ObjectEqualityComparer<ValueTuple<bool, long>>.Equals
	|
	|-RVA: 0x3C38FC0 Offset: 0x3C390C1 VA: 0x3C38FC0
	|-ObjectEqualityComparer<ValueTuple<bool, object>>.Equals
	|
	|-RVA: 0x3C393F0 Offset: 0x3C394F1 VA: 0x3C393F0
	|-ObjectEqualityComparer<ValueTuple<bool, Quaternion>>.Equals
	|
	|-RVA: 0x3C398A0 Offset: 0x3C399A1 VA: 0x3C398A0
	|-ObjectEqualityComparer<ValueTuple<bool, Rect>>.Equals
	|
	|-RVA: 0x3C39D50 Offset: 0x3C39E51 VA: 0x3C39D50
	|-ObjectEqualityComparer<ValueTuple<bool, float>>.Equals
	|
	|-RVA: 0x3C3A160 Offset: 0x3C3A261 VA: 0x3C3A160
	|-ObjectEqualityComparer<ValueTuple<bool, UniTask>>.Equals
	|
	|-RVA: 0x3C3A590 Offset: 0x3C3A691 VA: 0x3C3A590
	|-ObjectEqualityComparer<ValueTuple<bool, Unit>>.Equals
	|
	|-RVA: 0x3C3A9A0 Offset: 0x3C3AAA1 VA: 0x3C3A9A0
	|-ObjectEqualityComparer<ValueTuple<bool, Vector2>>.Equals
	|
	|-RVA: 0x3C3AE10 Offset: 0x3C3AF11 VA: 0x3C3AE10
	|-ObjectEqualityComparer<ValueTuple<bool, Vector3>>.Equals
	|
	|-RVA: 0x3C3B240 Offset: 0x3C3B341 VA: 0x3C3B240
	|-ObjectEqualityComparer<ValueTuple<bool, Vector4>>.Equals
	|
	|-RVA: 0x3C3B6F0 Offset: 0x3C3B7F1 VA: 0x3C3B6F0
	|-ObjectEqualityComparer<ValueTuple<int, object>>.Equals
	|
	|-RVA: 0x3C3BB10 Offset: 0x3C3BC11 VA: 0x3C3BB10
	|-ObjectEqualityComparer<ValueTuple<Int32Enum, int>>.Equals
	|
	|-RVA: 0x3C3BF20 Offset: 0x3C3C021 VA: 0x3C3BF20
	|-ObjectEqualityComparer<ValueTuple<object, ValueTuple<object, int>>>.Equals
	|
	|-RVA: 0x3C3C3C0 Offset: 0x3C3C4C1 VA: 0x3C3C3C0
	|-ObjectEqualityComparer<ValueTuple<object, int>>.Equals
	|
	|-RVA: 0x3C3C7E0 Offset: 0x3C3C8E1 VA: 0x3C3C7E0
	|-ObjectEqualityComparer<ValueTuple<object, object>>.Equals
	|
	|-RVA: 0x3C3CC00 Offset: 0x3C3CD01 VA: 0x3C3CC00
	|-ObjectEqualityComparer<ValueTuple<object, float>>.Equals
	|
	|-RVA: 0x3C3D020 Offset: 0x3C3D121 VA: 0x3C3D020
	|-ObjectEqualityComparer<ValueTuple<Vector3, float>>.Equals
	|
	|-RVA: 0x3C3D4C0 Offset: 0x3C3D5C1 VA: 0x3C3D4C0
	|-ObjectEqualityComparer<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>.Equals
	|
	|-RVA: 0x3C3D9B0 Offset: 0x3C3DAB1 VA: 0x3C3D9B0
	|-ObjectEqualityComparer<ValueTuple<object, Int32Enum, int>>.Equals
	|
	|-RVA: 0x3C3DDD0 Offset: 0x3C3DED1 VA: 0x3C3DDD0
	|-ObjectEqualityComparer<ValueTuple<object, object, object>>.Equals
	|
	|-RVA: 0x3C3E270 Offset: 0x3C3E371 VA: 0x3C3E270
	|-ObjectEqualityComparer<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.Equals
	|
	|-RVA: 0x3C3E7C0 Offset: 0x3C3E8C1 VA: 0x3C3E7C0
	|-ObjectEqualityComparer<ValueTuple<object, int, int, int>>.Equals
	|
	|-RVA: 0x3C3EC60 Offset: 0x3C3ED61 VA: 0x3C3EC60
	|-ObjectEqualityComparer<ValueTuple<object, object, object, object>>.Equals
	|
	|-RVA: 0x3C3F110 Offset: 0x3C3F211 VA: 0x3C3F110
	|-ObjectEqualityComparer<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.Equals
	|
	|-RVA: 0x3C3F6B0 Offset: 0x3C3F7B1 VA: 0x3C3F6B0
	|-ObjectEqualityComparer<ValueTuple<object, object, object, object, object>>.Equals
	|
	|-RVA: 0x3C3FBA0 Offset: 0x3C3FCA1 VA: 0x3C3FBA0
	|-ObjectEqualityComparer<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.Equals
	|
	|-RVA: 0x3C401A0 Offset: 0x3C402A1 VA: 0x3C401A0
	|-ObjectEqualityComparer<ValueTuple<object, object, object, object, object, object>>.Equals
	|
	|-RVA: 0x3C40690 Offset: 0x3C40791 VA: 0x3C40690
	|-ObjectEqualityComparer<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.Equals
	|
	|-RVA: 0x3C40CE0 Offset: 0x3C40DE1 VA: 0x3C40CE0
	|-ObjectEqualityComparer<ValueTuple<object, object, object, object, object, object, object>>.Equals
	|
	|-RVA: 0x3C41230 Offset: 0x3C41331 VA: 0x3C41230
	|-ObjectEqualityComparer<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>.Equals
	|
	|-RVA: 0x3C418E0 Offset: 0x3C419E1 VA: 0x3C418E0
	|-ObjectEqualityComparer<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>.Equals
	|
	|-RVA: 0x3C41DA0 Offset: 0x3C41EA1 VA: 0x3C41DA0
	|-ObjectEqualityComparer<AnimatorClipInfo>.Equals
	|
	|-RVA: 0x3C42200 Offset: 0x3C42301 VA: 0x3C42200
	|-ObjectEqualityComparer<AsyncOperationHandle>.Equals
	|
	|-RVA: 0x3C42650 Offset: 0x3C42751 VA: 0x3C42650
	|-ObjectEqualityComparer<AsyncUnit>.Equals
	|
	|-RVA: 0x3C42A60 Offset: 0x3C42B61 VA: 0x3C42A60
	|-ObjectEqualityComparer<BoneWeight>.Equals
	|
	|-RVA: 0x3C42D70 Offset: 0x3C42E71 VA: 0x3C42D70
	|-ObjectEqualityComparer<bool>.Equals
	|
	|-RVA: 0x3C43080 Offset: 0x3C43181 VA: 0x3C43080
	|-ObjectEqualityComparer<Bounds>.Equals
	|
	|-RVA: 0x3C43390 Offset: 0x3C43491 VA: 0x3C43390
	|-ObjectEqualityComparer<byte>.Equals
	|
	|-RVA: 0x3C43690 Offset: 0x3C43791 VA: 0x3C43690
	|-ObjectEqualityComparer<CameraInfo>.Equals
	|
	|-RVA: 0x3C43B00 Offset: 0x3C43C01 VA: 0x3C43B00
	|-ObjectEqualityComparer<CancellationToken>.Equals
	|
	|-RVA: 0x3C43E10 Offset: 0x3C43F11 VA: 0x3C43E10
	|-ObjectEqualityComparer<CancellationTokenRegistration>.Equals
	|
	|-RVA: 0x3C44120 Offset: 0x3C44221 VA: 0x3C44120
	|-ObjectEqualityComparer<char>.Equals
	|
	|-RVA: 0x3C44420 Offset: 0x3C44521 VA: 0x3C44420
	|-ObjectEqualityComparer<Color>.Equals
	|
	|-RVA: 0x3C44770 Offset: 0x3C44871 VA: 0x3C44770
	|-ObjectEqualityComparer<Color32>.Equals
	|
	|-RVA: 0x3C44BD0 Offset: 0x3C44CD1 VA: 0x3C44BD0
	|-ObjectEqualityComparer<ColorBlock>.Equals
	|
	|-RVA: 0x3C44F40 Offset: 0x3C45041 VA: 0x3C44F40
	|-ObjectEqualityComparer<ConstraintSource>.Equals
	|
	|-RVA: 0x3C453B0 Offset: 0x3C454B1 VA: 0x3C453B0
	|-ObjectEqualityComparer<ContourVertex>.Equals
	|
	|-RVA: 0x3C45880 Offset: 0x3C45981 VA: 0x3C45880
	|-ObjectEqualityComparer<DataStoreRatingInfo>.Equals
	|
	|-RVA: 0x3C45D50 Offset: 0x3C45E51 VA: 0x3C45D50
	|-ObjectEqualityComparer<DataStoreResult>.Equals
	|
	|-RVA: 0x3C461B0 Offset: 0x3C462B1 VA: 0x3C461B0
	|-ObjectEqualityComparer<DateTime>.Equals
	|
	|-RVA: 0x3C464C0 Offset: 0x3C465C1 VA: 0x3C464C0
	|-ObjectEqualityComparer<DateTimeOffset>.Equals
	|
	|-RVA: 0x3C467F0 Offset: 0x3C468F1 VA: 0x3C467F0
	|-ObjectEqualityComparer<Decimal>.Equals
	|
	|-RVA: 0x3C46B20 Offset: 0x3C46C21 VA: 0x3C46B20
	|-ObjectEqualityComparer<DiagnosticEvent>.Equals
	|
	|-RVA: 0x3C47020 Offset: 0x3C47121 VA: 0x3C47020
	|-ObjectEqualityComparer<double>.Equals
	|
	|-RVA: 0x3C47340 Offset: 0x3C47441 VA: 0x3C47340
	|-ObjectEqualityComparer<FXZ>.Equals
	|
	|-RVA: 0x3C47660 Offset: 0x3C47761 VA: 0x3C47660
	|-ObjectEqualityComparer<Friend>.Equals
	|
	|-RVA: 0x3C47B40 Offset: 0x3C47C41 VA: 0x3C47B40
	|-ObjectEqualityComparer<GlyphRect>.Equals
	|
	|-RVA: 0x3C47E70 Offset: 0x3C47F71 VA: 0x3C47E70
	|-ObjectEqualityComparer<Guid>.Equals
	|
	|-RVA: 0x3C481A0 Offset: 0x3C482A1 VA: 0x3C481A0
	|-ObjectEqualityComparer<short>.Equals
	|
	|-RVA: 0x3C484A0 Offset: 0x3C485A1 VA: 0x3C484A0
	|-ObjectEqualityComparer<int>.Equals
	|
	|-RVA: 0x3C487A0 Offset: 0x3C488A1 VA: 0x3C487A0
	|-ObjectEqualityComparer<Int32Enum>.Equals
	|
	|-RVA: 0x3C48B90 Offset: 0x3C48C91 VA: 0x3C48B90
	|-ObjectEqualityComparer<long>.Equals
	|
	|-RVA: 0x3C48EA0 Offset: 0x3C48FA1 VA: 0x3C48EA0
	|-ObjectEqualityComparer<Int64Enum>.Equals
	|
	|-RVA: 0x3C49290 Offset: 0x3C49391 VA: 0x3C49290
	|-ObjectEqualityComparer<IntPtr>.Equals
	|
	|-RVA: 0x3C495A0 Offset: 0x3C496A1 VA: 0x3C495A0
	|-ObjectEqualityComparer<InterpretedFrameInfo>.Equals
	|
	|-RVA: 0x3C49A10 Offset: 0x3C49B11 VA: 0x3C49A10
	|-ObjectEqualityComparer<IntervalTreeNode>.Equals
	|
	|-RVA: 0x3C49EE0 Offset: 0x3C49FE1 VA: 0x3C49EE0
	|-ObjectEqualityComparer<LayerMask>.Equals
	|
	|-RVA: 0x3C4A340 Offset: 0x3C4A441 VA: 0x3C4A340
	|-ObjectEqualityComparer<LengthLimitProperties>.Equals
	|
	|-RVA: 0x3C4A7A0 Offset: 0x3C4A8A1 VA: 0x3C4A7A0
	|-ObjectEqualityComparer<MapPos>.Equals
	|
	|-RVA: 0x3C4AAB0 Offset: 0x3C4ABB1 VA: 0x3C4AAB0
	|-ObjectEqualityComparer<Matrix4x4>.Equals
	|
	|-RVA: 0x3C4ADF0 Offset: 0x3C4AEF1 VA: 0x3C4ADF0
	|-ObjectEqualityComparer<Navigation>.Equals
	|
	|-RVA: 0x3C4B2F0 Offset: 0x3C4B3F1 VA: 0x3C4B2F0
	|-ObjectEqualityComparer<object>.Equals
	|
	|-RVA: 0x3C4B5C0 Offset: 0x3C4B6C1 VA: 0x3C4B5C0
	|-ObjectEqualityComparer<ObjectInitializationData>.Equals
	|
	|-RVA: 0x3C4BAC0 Offset: 0x3C4BBC1 VA: 0x3C4BAC0
	|-ObjectEqualityComparer<Playable>.Equals
	|
	|-RVA: 0x3C4BF30 Offset: 0x3C4C031 VA: 0x3C4BF30
	|-ObjectEqualityComparer<PlayableBinding>.Equals
	|
	|-RVA: 0x3C4C400 Offset: 0x3C4C501 VA: 0x3C4C400
	|-ObjectEqualityComparer<PlayerLoopSystem>.Equals
	|
	|-RVA: 0x3C4C900 Offset: 0x3C4CA01 VA: 0x3C4C900
	|-ObjectEqualityComparer<PlayerLoopSystemInternal>.Equals
	|
	|-RVA: 0x3C4CE00 Offset: 0x3C4CF01 VA: 0x3C4CE00
	|-ObjectEqualityComparer<Quaternion>.Equals
	|
	|-RVA: 0x3C4D150 Offset: 0x3C4D251 VA: 0x3C4D150
	|-ObjectEqualityComparer<RandomSeed>.Equals
	|
	|-RVA: 0x3C4D5C0 Offset: 0x3C4D6C1 VA: 0x3C4D5C0
	|-ObjectEqualityComparer<RangePositionInfo>.Equals
	|
	|-RVA: 0x3C4DA30 Offset: 0x3C4DB31 VA: 0x3C4DA30
	|-ObjectEqualityComparer<Ranking2ChartInfoInput>.Equals
	|
	|-RVA: 0x3C4DE90 Offset: 0x3C4DF91 VA: 0x3C4DE90
	|-ObjectEqualityComparer<RaycastHit2D>.Equals
	|
	|-RVA: 0x3C4E3D0 Offset: 0x3C4E4D1 VA: 0x3C4E3D0
	|-ObjectEqualityComparer<RaycastResult>.Equals
	|
	|-RVA: 0x3C4E940 Offset: 0x3C4EA41 VA: 0x3C4E940
	|-ObjectEqualityComparer<Rect>.Equals
	|
	|-RVA: 0x3C4EC90 Offset: 0x3C4ED91 VA: 0x3C4EC90
	|-ObjectEqualityComparer<RendererListHandle>.Equals
	|
	|-RVA: 0x3C4F0F0 Offset: 0x3C4F1F1 VA: 0x3C4F0F0
	|-ObjectEqualityComparer<ResourceHandle>.Equals
	|
	|-RVA: 0x3C4F550 Offset: 0x3C4F651 VA: 0x3C4F550
	|-ObjectEqualityComparer<ResourceLocator>.Equals
	|
	|-RVA: 0x3C4F9C0 Offset: 0x3C4FAC1 VA: 0x3C4F9C0
	|-ObjectEqualityComparer<sbyte>.Equals
	|
	|-RVA: 0x3C4FCC0 Offset: 0x3C4FDC1 VA: 0x3C4FCC0
	|-ObjectEqualityComparer<ShaderTagId>.Equals
	|
	|-RVA: 0x3C4FFD0 Offset: 0x3C500D1 VA: 0x3C4FFD0
	|-ObjectEqualityComparer<float>.Equals
	|
	|-RVA: 0x3C502E0 Offset: 0x3C503E1 VA: 0x3C502E0
	|-ObjectEqualityComparer<SphericalHarmonicsL2>.Equals
	|
	|-RVA: 0x3C50680 Offset: 0x3C50781 VA: 0x3C50680
	|-ObjectEqualityComparer<SpriteState>.Equals
	|
	|-RVA: 0x3C50B50 Offset: 0x3C50C51 VA: 0x3C50B50
	|-ObjectEqualityComparer<SubMeshDescriptor>.Equals
	|
	|-RVA: 0x3C51050 Offset: 0x3C51151 VA: 0x3C51050
	|-ObjectEqualityComparer<TablePair>.Equals
	|
	|-RVA: 0x3C514C0 Offset: 0x3C515C1 VA: 0x3C514C0
	|-ObjectEqualityComparer<TimeSpan>.Equals
	|
	|-RVA: 0x3C517D0 Offset: 0x3C518D1 VA: 0x3C517D0
	|-ObjectEqualityComparer<UICharInfo>.Equals
	|
	|-RVA: 0x3C51C90 Offset: 0x3C51D91 VA: 0x3C51C90
	|-ObjectEqualityComparer<UILineInfo>.Equals
	|
	|-RVA: 0x3C52100 Offset: 0x3C52201 VA: 0x3C52100
	|-ObjectEqualityComparer<UIVertex>.Equals
	|
	|-RVA: 0x3C52720 Offset: 0x3C52821 VA: 0x3C52720
	|-ObjectEqualityComparer<ushort>.Equals
	|
	|-RVA: 0x3C52A20 Offset: 0x3C52B21 VA: 0x3C52A20
	|-ObjectEqualityComparer<uint>.Equals
	|
	|-RVA: 0x3C52D20 Offset: 0x3C52E21 VA: 0x3C52D20
	|-ObjectEqualityComparer<ulong>.Equals
	|
	|-RVA: 0x3C53030 Offset: 0x3C53131 VA: 0x3C53030
	|-ObjectEqualityComparer<UniTask>.Equals
	|
	|-RVA: 0x3C53440 Offset: 0x3C53541 VA: 0x3C53440
	|-ObjectEqualityComparer<Unit>.Equals
	|
	|-RVA: 0x3C53750 Offset: 0x3C53851 VA: 0x3C53750
	|-ObjectEqualityComparer<Vector2>.Equals
	|
	|-RVA: 0x3C53A70 Offset: 0x3C53B71 VA: 0x3C53A70
	|-ObjectEqualityComparer<Vector3>.Equals
	|
	|-RVA: 0x3C53DD0 Offset: 0x3C53ED1 VA: 0x3C53DD0
	|-ObjectEqualityComparer<Vector4>.Equals
	|
	|-RVA: 0x3C54120 Offset: 0x3C54221 VA: 0x3C54120
	|-ObjectEqualityComparer<VertexAttributeDescriptor>.Equals
	|
	|-RVA: 0x3C54450 Offset: 0x3C54551 VA: 0x3C54450
	|-ObjectEqualityComparer<X509ChainStatus>.Equals
	|
	|-RVA: 0x3C548C0 Offset: 0x3C549C1 VA: 0x3C548C0
	|-ObjectEqualityComparer<XPathNodeRef>.Equals
	|
	|-RVA: 0x3C54CE0 Offset: 0x3C54DE1 VA: 0x3C54CE0
	|-ObjectEqualityComparer<XRView>.Equals
	|
	|-RVA: 0x3C551C0 Offset: 0x3C552C1 VA: 0x3C551C0
	|-ObjectEqualityComparer<AmiiboSequence.GainItemData>.Equals
	|
	|-RVA: 0x3C55630 Offset: 0x3C55731 VA: 0x3C55630
	|-ObjectEqualityComparer<AnimationOutputWeightProcessor.WeightInfo>.Equals
	|
	|-RVA: 0x3C55B30 Offset: 0x3C55C31 VA: 0x3C55B30
	|-ObjectEqualityComparer<ArenaOrderSequence.GodInfo>.Equals
	|
	|-RVA: 0x3C55FA0 Offset: 0x3C560A1 VA: 0x3C55FA0
	|-ObjectEqualityComparer<BattleInfo.SupportData>.Equals
	|
	|-RVA: 0x3C56410 Offset: 0x3C56511 VA: 0x3C56410
	|-ObjectEqualityComparer<BeforeRenderHelper.OrderBlock>.Equals
	|
	|-RVA: 0x3C56880 Offset: 0x3C56981 VA: 0x3C56880
	|-ObjectEqualityComparer<Camera.RenderRequest>.Equals
	|
	|-RVA: 0x3C56D50 Offset: 0x3C56E51 VA: 0x3C56D50
	|-ObjectEqualityComparer<CameraState.CustomBlendable>.Equals
	|
	|-RVA: 0x3C571C0 Offset: 0x3C572C1 VA: 0x3C571C0
	|-ObjectEqualityComparer<CinemachineClearShot.Pair>.Equals
	|
	|-RVA: 0x3C57620 Offset: 0x3C57721 VA: 0x3C57620
	|-ObjectEqualityComparer<CinemachineStateDrivenCamera.HashPair>.Equals
	|
	|-RVA: 0x3C57A80 Offset: 0x3C57B81 VA: 0x3C57A80
	|-ObjectEqualityComparer<DelayedActionManager.DelegateInfo>.Equals
	|
	|-RVA: 0x3C57F50 Offset: 0x3C58051 VA: 0x3C57F50
	|-ObjectEqualityComparer<Detail.AsyncResultInt>.Equals
	|
	|-RVA: 0x3C58450 Offset: 0x3C58551 VA: 0x3C58450
	|-ObjectEqualityComparer<Detail.CppArray>.Equals
	|
	|-RVA: 0x3C588C0 Offset: 0x3C589C1 VA: 0x3C588C0
	|-ObjectEqualityComparer<Detail.NotificationEventInt>.Equals
	|
	|-RVA: 0x3C58DC0 Offset: 0x3C58EC1 VA: 0x3C58DC0
	|-ObjectEqualityComparer<DragonRideTargetGroup.ChainParam>.Equals
	|
	|-RVA: 0x3C59230 Offset: 0x3C59331 VA: 0x3C59230
	|-ObjectEqualityComparer<DynamicMesh.State>.Equals
	|
	|-RVA: 0x3C59690 Offset: 0x3C59791 VA: 0x3C59690
	|-ObjectEqualityComparer<GameVariable.Value>.Equals
	|
	|-RVA: 0x3C59B00 Offset: 0x3C59C01 VA: 0x3C59B00
	|-ObjectEqualityComparer<GmapPathAdjuster.TargetModel>.Equals
	|
	|-RVA: 0x3C59FD0 Offset: 0x3C5A0D1 VA: 0x3C59FD0
	|-ObjectEqualityComparer<GmapSpotAdjuster.TargetModel>.Equals
	|
	|-RVA: 0x3C5A4A0 Offset: 0x3C5A5A1 VA: 0x3C5A4A0
	|-ObjectEqualityComparer<HubFastTravel.Location>.Equals
	|
	|-RVA: 0x3C5A970 Offset: 0x3C5AA71 VA: 0x3C5A970
	|-ObjectEqualityComparer<HubLensFlare.Flare>.Equals
	|
	|-RVA: 0x3C5AE70 Offset: 0x3C5AF71 VA: 0x3C5AE70
	|-ObjectEqualityComparer<InventoryPoolItemMenuContent.KindBgNameClass>.Equals
	|
	|-RVA: 0x3C5B2E0 Offset: 0x3C5B3E1 VA: 0x3C5B2E0
	|-ObjectEqualityComparer<Map.Pos>.Equals
	|
	|-RVA: 0x3C5B740 Offset: 0x3C5B841 VA: 0x3C5B740
	|-ObjectEqualityComparer<MapImage.BackupTerrain>.Equals
	|
	|-RVA: 0x3C5BBB0 Offset: 0x3C5BCB1 VA: 0x3C5BBB0
	|-ObjectEqualityComparer<MapImageRange.Pos>.Equals
	|
	|-RVA: 0x3C5C010 Offset: 0x3C5C111 VA: 0x3C5C010
	|-ObjectEqualityComparer<MapMind.Record>.Equals
	|
	|-RVA: 0x3C5C580 Offset: 0x3C5C681 VA: 0x3C5C580
	|-ObjectEqualityComparer<MapMind.Target>.Equals
	|
	|-RVA: 0x36FCDE0 Offset: 0x36FCEE1 VA: 0x36FCDE0
	|-ObjectEqualityComparer<MapPanelDebug.Entity>.Equals
	|
	|-RVA: 0x36FD2B0 Offset: 0x36FD3B1 VA: 0x36FD2B0
	|-ObjectEqualityComparer<NexRanking.Data>.Equals
	|
	|-RVA: 0x36FD710 Offset: 0x36FD811 VA: 0x36FD710
	|-ObjectEqualityComparer<NexVersus.RatingData>.Equals
	|
	|-RVA: 0x36FDB80 Offset: 0x36FDC81 VA: 0x36FDB80
	|-ObjectEqualityComparer<PackedPlayModeBuildLogs.RuntimeBuildLog>.Equals
	|
	|-RVA: 0x36FDFF0 Offset: 0x36FE0F1 VA: 0x36FDFF0
	|-ObjectEqualityComparer<ParticleSystem.Particle>.Equals
	|
	|-RVA: 0x36FE4D0 Offset: 0x36FE5D1 VA: 0x36FE4D0
	|-ObjectEqualityComparer<QualitySettingsStack.Settings>.Equals
	|
	|-RVA: 0x36FE9D0 Offset: 0x36FEAD1 VA: 0x36FE9D0
	|-ObjectEqualityComparer<RangeData.Offset>.Equals
	|
	|-RVA: 0x36FEE30 Offset: 0x36FEF31 VA: 0x36FEE30
	|-ObjectEqualityComparer<RenderGraphDebugData.PassDebugData>.Equals
	|
	|-RVA: 0x36FF300 Offset: 0x36FF401 VA: 0x36FF300
	|-ObjectEqualityComparer<RenderGraphDebugData.ResourceDebugData>.Equals
	|
	|-RVA: 0x36FF800 Offset: 0x36FF901 VA: 0x36FF800
	|-ObjectEqualityComparer<RingCleaningUnitSelectMenu.GodParam>.Equals
	|
	|-RVA: 0x36FFC70 Offset: 0x36FFD71 VA: 0x36FFC70
	|-ObjectEqualityComparer<SequenceNode.SequenceConstructPosContext>.Equals
	|
	|-RVA: 0x3700170 Offset: 0x3700271 VA: 0x3700170
	|-ObjectEqualityComparer<ShadowUtility.Edge>.Equals
	|
	|-RVA: 0x3700670 Offset: 0x3700771 VA: 0x3700670
	|-ObjectEqualityComparer<SimpleAnimationPlayable.QueuedState>.Equals
	|
	|-RVA: 0x3700AE0 Offset: 0x3700BE1 VA: 0x3700AE0
	|-ObjectEqualityComparer<SkillArray.Entity>.Equals
	|
	|-RVA: 0x3700F40 Offset: 0x3701041 VA: 0x3700F40
	|-ObjectEqualityComparer<Stream.Info>.Equals
	|
	|-RVA: 0x37013D0 Offset: 0x37014D1 VA: 0x37013D0
	|-ObjectEqualityComparer<TexturePacker_JsonArray.Frame>.Equals
	|
	|-RVA: 0x3701910 Offset: 0x3701A11 VA: 0x3701910
	|-ObjectEqualityComparer<TimeNotificationBehaviour.NotificationEntry>.Equals
	|
	|-RVA: 0x3701DE0 Offset: 0x3701EE1 VA: 0x3701DE0
	|-ObjectEqualityComparer<UnitySynchronizationContext.WorkRequest>.Equals
	|
	|-RVA: 0x37022B0 Offset: 0x37023B1 VA: 0x37022B0
	|-ObjectEqualityComparer<XmlSchemaObjectTable.XmlSchemaObjectEntry>.Equals
	|
	|-RVA: 0x3702720 Offset: 0x3702821 VA: 0x3702720
	|-ObjectEqualityComparer<AIThink.EnchantThink.SurroundingInfo>.Equals
	|
	|-RVA: 0x3702B80 Offset: 0x3702C81 VA: 0x3702B80
	|-ObjectEqualityComparer<AssetBundleBuildMap.AssetBundleEntry.AssetPathString>.Equals
	|
	|-RVA: 0x3702FF0 Offset: 0x37030F1 VA: 0x3702FF0
	|-ObjectEqualityComparer<Detail.DataStore.DataStoreChangeMetaParamInt>.Equals
	|
	|-RVA: 0x37034D0 Offset: 0x37035D1 VA: 0x37034D0
	|-ObjectEqualityComparer<Detail.DataStore.DataStoreDeleteParamInt>.Equals
	|
	|-RVA: 0x3703940 Offset: 0x3703A41 VA: 0x3703940
	|-ObjectEqualityComparer<Detail.DataStore.DataStoreGetMetaParamInt>.Equals
	|
	|-RVA: 0x3703E40 Offset: 0x3703F41 VA: 0x3703E40
	|-ObjectEqualityComparer<Detail.DataStore.DataStoreMetaInfoInt>.Equals
	|
	|-RVA: 0x3704320 Offset: 0x3704421 VA: 0x3704320
	|-ObjectEqualityComparer<Detail.DataStore.DataStorePasswordInfoInt>.Equals
	|
	|-RVA: 0x37047F0 Offset: 0x37048F1 VA: 0x37047F0
	|-ObjectEqualityComparer<Detail.DataStore.DataStorePersistenceInfoInt>.Equals
	|
	|-RVA: 0x3704CC0 Offset: 0x3704DC1 VA: 0x3704CC0
	|-ObjectEqualityComparer<Detail.DataStore.DataStorePreparePostParamInt>.Equals
	|
	|-RVA: 0x37051A0 Offset: 0x37052A1 VA: 0x37051A0
	|-ObjectEqualityComparer<Detail.DataStore.DataStoreRateObjectParamInt>.Equals
	|
	|-RVA: 0x3705610 Offset: 0x3705711 VA: 0x3705610
	|-ObjectEqualityComparer<Detail.DataStore.DataStoreRatingInitParamInt>.Equals
	|
	|-RVA: 0x3705AE0 Offset: 0x3705BE1 VA: 0x3705AE0
	|-ObjectEqualityComparer<Detail.DataStore.DataStoreRatingTargetInt>.Equals
	|
	|-RVA: 0x3705F50 Offset: 0x3706051 VA: 0x3705F50
	|-ObjectEqualityComparer<Detail.Ranking.RankingCachedResultInt>.Equals
	|
	|-RVA: 0x3706490 Offset: 0x3706591 VA: 0x3706490
	|-ObjectEqualityComparer<Detail.Ranking.RankingOrderParamInt>.Equals
	|
	|-RVA: 0x3706900 Offset: 0x3706A01 VA: 0x3706900
	|-ObjectEqualityComparer<Detail.Ranking.RankingRankDataInt>.Equals
	|
	|-RVA: 0x3706E40 Offset: 0x3706F41 VA: 0x3706E40
	|-ObjectEqualityComparer<Detail.Ranking2.Ranking2ChartInfoInt>.Equals
	|
	|-RVA: 0x37073F0 Offset: 0x37074F1 VA: 0x37073F0
	|-ObjectEqualityComparer<Detail.Ranking2.Ranking2RankDataInt>.Equals
	|
	|-RVA: 0x3707930 Offset: 0x3707A31 VA: 0x3707930
	|-ObjectEqualityComparer<Detail.Ranking2.Ranking2ScoreDataInt>.Equals
	|
	|-RVA: 0x3707DA0 Offset: 0x3707EA1 VA: 0x3707DA0
	|-ObjectEqualityComparer<Detail.Screening.ScreeningContextInfoInt>.Equals
	|
	|-RVA: 0x3708270 Offset: 0x3708371 VA: 0x3708270
	|-ObjectEqualityComparer<Detail.Subscriber.SubscriberContentInt>.Equals
	|
	|-RVA: 0x37087E0 Offset: 0x37088E1 VA: 0x37087E0
	|-ObjectEqualityComparer<Detail.Subscriber.SubscriberGetContentParamInt>.Equals
	|
	|-RVA: 0x3708CB0 Offset: 0x3708DB1 VA: 0x3708CB0
	|-ObjectEqualityComparer<Detail.Subscriber.SubscriberUserStatusInfoInt>.Equals
	|
	|-RVA: 0x37091B0 Offset: 0x37092B1 VA: 0x37091B0
	|-ObjectEqualityComparer<Detail.Subscriber.SubscriberUserStatusParamInt>.Equals
	|
	|-RVA: 0x3709680 Offset: 0x3709781 VA: 0x3709680
	|-ObjectEqualityComparer<Detail.Utility.IntegerSettings>.Equals
	|
	|-RVA: 0x3709AE0 Offset: 0x3709BE1 VA: 0x3709AE0
	|-ObjectEqualityComparer<Detail.Utility.UniqueIdInfoInt>.Equals
	|
	|-RVA: 0x3709F50 Offset: 0x370A051 VA: 0x3709F50
	|-ObjectEqualityComparer<MapHistory.Rewind.LatestInspectorData>.Equals
	|
	|-RVA: 0x370A400 Offset: 0x370A501 VA: 0x370A400
	|-ObjectEqualityComparer<MapHistory.Rewind.WorkTerrainData>.Equals
	|
	|-RVA: 0x370A8B0 Offset: 0x370A9B1 VA: 0x370A8B0
	|-ObjectEqualityComparer<MapSkill.AroundCalculator.Result>.Equals
	|
	|-RVA: 0x370AD20 Offset: 0x370AE21 VA: 0x370AD20
	|-ObjectEqualityComparer<TargetPositionCache.CacheCurve.Item>.Equals
	|
	|-RVA: 0x370B220 Offset: 0x370B321 VA: 0x370B220
	|-ObjectEqualityComparer<TargetPositionCache.CacheEntry.RecordingItem>.Equals
	|
	|-RVA: 0x370B760 Offset: 0x370B861 VA: 0x370B760
	|-ObjectEqualityComparer<TerrainUtility.TerrainMap.TileCoord>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public override int GetHashCode(T obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BA5DA0 Offset: 0x2BA5EA1 VA: 0x2BA5DA0
	|-ObjectEqualityComparer<AsyncOperationHandle<object>>.GetHashCode
	|
	|-RVA: 0x2BA6260 Offset: 0x2BA6361 VA: 0x2BA6260
	|-ObjectEqualityComparer<IntervalTree.Entry<object>>.GetHashCode
	|
	|-RVA: 0x2BA6710 Offset: 0x2BA6811 VA: 0x2BA6710
	|-ObjectEqualityComparer<KeyValuePair<DateTime, object>>.GetHashCode
	|
	|-RVA: 0x2BA6B80 Offset: 0x2BA6C81 VA: 0x2BA6B80
	|-ObjectEqualityComparer<KeyValuePair<int, object>>.GetHashCode
	|
	|-RVA: 0x2BA7010 Offset: 0x2BA7111 VA: 0x2BA7010
	|-ObjectEqualityComparer<KeyValuePair<object, ValueTuple<int, DateTime, object>>>.GetHashCode
	|
	|-RVA: 0x2BA74C0 Offset: 0x2BA75C1 VA: 0x2BA74C0
	|-ObjectEqualityComparer<KeyValuePair<object, object>>.GetHashCode
	|
	|-RVA: 0x2BA7950 Offset: 0x2BA7A51 VA: 0x2BA7950
	|-ObjectEqualityComparer<CommonBattleSequence.Reliance<object>>.GetHashCode
	|
	|-RVA: 0x2BA7E00 Offset: 0x2BA7F01 VA: 0x2BA7E00
	|-ObjectEqualityComparer<RenderGraphResourcePool.ResourceLogInfo<object>>.GetHashCode
	|
	|-RVA: 0x2BA8260 Offset: 0x2BA8361 VA: 0x2BA8260
	|-ObjectEqualityComparer<TimeInterval<object>>.GetHashCode
	|
	|-RVA: 0x2BA86C0 Offset: 0x2BA87C1 VA: 0x2BA86C0
	|-ObjectEqualityComparer<Timestamped<object>>.GetHashCode
	|
	|-RVA: 0x2BA8B40 Offset: 0x2BA8C41 VA: 0x2BA8B40
	|-ObjectEqualityComparer<UniTask<object>>.GetHashCode
	|
	|-RVA: 0x2BA8F90 Offset: 0x2BA9091 VA: 0x2BA8F90
	|-ObjectEqualityComparer<ValueTuple<ValueTuple<bool, object>>>.GetHashCode
	|
	|-RVA: 0x2BA93F0 Offset: 0x2BA94F1 VA: 0x2BA93F0
	|-ObjectEqualityComparer<ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>.GetHashCode
	|
	|-RVA: 0x2BA98A0 Offset: 0x2BA99A1 VA: 0x2BA98A0
	|-ObjectEqualityComparer<ValueTuple<bool, UniTask<object>>>.GetHashCode
	|
	|-RVA: 0x2BA9D50 Offset: 0x2BA9E51 VA: 0x2BA9D50
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>.GetHashCode
	|
	|-RVA: 0x2BAA210 Offset: 0x2BAA311 VA: 0x2BAA210
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>>.GetHashCode
	|
	|-RVA: 0x2BAA700 Offset: 0x2BAA801 VA: 0x2BAA700
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>>>.GetHashCode
	|
	|-RVA: 0x2BAABD0 Offset: 0x2BAACD1 VA: 0x2BAABD0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>>>.GetHashCode
	|
	|-RVA: 0x2BAB030 Offset: 0x2BAB131 VA: 0x2BAB030
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>>>.GetHashCode
	|
	|-RVA: 0x2BAB4E0 Offset: 0x2BAB5E1 VA: 0x2BAB4E0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>>>.GetHashCode
	|
	|-RVA: 0x2BAB9F0 Offset: 0x2BABAF1 VA: 0x2BAB9F0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>>>.GetHashCode
	|
	|-RVA: 0x2BABE90 Offset: 0x2BABF91 VA: 0x2BABE90
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>>>.GetHashCode
	|
	|-RVA: 0x2BAC3C0 Offset: 0x2BAC4C1 VA: 0x2BAC3C0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>>>.GetHashCode
	|
	|-RVA: 0x3A567A0 Offset: 0x3A568A1 VA: 0x3A567A0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>>>.GetHashCode
	|
	|-RVA: 0x3A56C60 Offset: 0x3A56D61 VA: 0x3A56C60
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>>>.GetHashCode
	|
	|-RVA: 0x3A57160 Offset: 0x3A57261 VA: 0x3A57160
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>>>.GetHashCode
	|
	|-RVA: 0x3A57670 Offset: 0x3A57771 VA: 0x3A57670
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>>>.GetHashCode
	|
	|-RVA: 0x3A57BB0 Offset: 0x3A57CB1 VA: 0x3A57BB0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>>>.GetHashCode
	|
	|-RVA: 0x3A580D0 Offset: 0x3A581D1 VA: 0x3A580D0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>>>.GetHashCode
	|
	|-RVA: 0x3A58590 Offset: 0x3A58691 VA: 0x3A58590
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>>>.GetHashCode
	|
	|-RVA: 0x3A58A60 Offset: 0x3A58B61 VA: 0x3A58A60
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>>>.GetHashCode
	|
	|-RVA: 0x3A58EF0 Offset: 0x3A58FF1 VA: 0x3A58EF0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>>>.GetHashCode
	|
	|-RVA: 0x3A593D0 Offset: 0x3A594D1 VA: 0x3A593D0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>>>.GetHashCode
	|
	|-RVA: 0x3A598A0 Offset: 0x3A599A1 VA: 0x3A598A0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>>>.GetHashCode
	|
	|-RVA: 0x3A59DD0 Offset: 0x3A59ED1 VA: 0x3A59DD0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>>>.GetHashCode
	|
	|-RVA: 0x3A5A2D0 Offset: 0x3A5A3D1 VA: 0x3A5A2D0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>>>.GetHashCode
	|
	|-RVA: 0x3A5A7F0 Offset: 0x3A5A8F1 VA: 0x3A5A7F0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>>>.GetHashCode
	|
	|-RVA: 0x3A5AD50 Offset: 0x3A5AE51 VA: 0x3A5AD50
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>>>.GetHashCode
	|
	|-RVA: 0x3A5B2C0 Offset: 0x3A5B3C1 VA: 0x3A5B2C0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>>>.GetHashCode
	|
	|-RVA: 0x3A5B860 Offset: 0x3A5B961 VA: 0x3A5B860
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>>>.GetHashCode
	|
	|-RVA: 0x3A5BE30 Offset: 0x3A5BF31 VA: 0x3A5BE30
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>>>.GetHashCode
	|
	|-RVA: 0x3A5C3C0 Offset: 0x3A5C4C1 VA: 0x3A5C3C0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>>.GetHashCode
	|
	|-RVA: 0x3A5C830 Offset: 0x3A5C931 VA: 0x3A5C830
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>>.GetHashCode
	|
	|-RVA: 0x3A5CCD0 Offset: 0x3A5CDD1 VA: 0x3A5CCD0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>>.GetHashCode
	|
	|-RVA: 0x3A5D190 Offset: 0x3A5D291 VA: 0x3A5D190
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>>.GetHashCode
	|
	|-RVA: 0x3A5D620 Offset: 0x3A5D721 VA: 0x3A5D620
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>>.GetHashCode
	|
	|-RVA: 0x3A5DAE0 Offset: 0x3A5DBE1 VA: 0x3A5DAE0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>>.GetHashCode
	|
	|-RVA: 0x3A5DFC0 Offset: 0x3A5E0C1 VA: 0x3A5DFC0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>>.GetHashCode
	|
	|-RVA: 0x3A5E480 Offset: 0x3A5E581 VA: 0x3A5E480
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>>.GetHashCode
	|
	|-RVA: 0x3A5E970 Offset: 0x3A5EA71 VA: 0x3A5E970
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>>.GetHashCode
	|
	|-RVA: 0x3A5EE50 Offset: 0x3A5EF51 VA: 0x3A5EE50
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>>.GetHashCode
	|
	|-RVA: 0x3A5F300 Offset: 0x3A5F401 VA: 0x3A5F300
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>>.GetHashCode
	|
	|-RVA: 0x3A5F7B0 Offset: 0x3A5F8B1 VA: 0x3A5F7B0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>>.GetHashCode
	|
	|-RVA: 0x3A5FC70 Offset: 0x3A5FD71 VA: 0x3A5FC70
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>>.GetHashCode
	|
	|-RVA: 0x3A60130 Offset: 0x3A60231 VA: 0x3A60130
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>>.GetHashCode
	|
	|-RVA: 0x3A605C0 Offset: 0x3A606C1 VA: 0x3A605C0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>>.GetHashCode
	|
	|-RVA: 0x3A60A80 Offset: 0x3A60B81 VA: 0x3A60A80
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>>.GetHashCode
	|
	|-RVA: 0x3A60F60 Offset: 0x3A61061 VA: 0x3A60F60
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>>.GetHashCode
	|
	|-RVA: 0x3A61420 Offset: 0x3A61521 VA: 0x3A61420
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>>.GetHashCode
	|
	|-RVA: 0x3A61910 Offset: 0x3A61A11 VA: 0x3A61910
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>>.GetHashCode
	|
	|-RVA: 0x3A61E20 Offset: 0x3A61F21 VA: 0x3A61E20
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.GetHashCode
	|
	|-RVA: 0x3A62360 Offset: 0x3A62461 VA: 0x3A62360
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>>.GetHashCode
	|
	|-RVA: 0x3A62890 Offset: 0x3A62991 VA: 0x3A62890
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.GetHashCode
	|
	|-RVA: 0x3A62E30 Offset: 0x3A62F31 VA: 0x3A62E30
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>>.GetHashCode
	|
	|-RVA: 0x3A633C0 Offset: 0x3A634C1 VA: 0x3A633C0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.GetHashCode
	|
	|-RVA: 0x3A639A0 Offset: 0x3A63AA1 VA: 0x3A639A0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>>.GetHashCode
	|
	|-RVA: 0x3A63F40 Offset: 0x3A64041 VA: 0x3A63F40
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.GetHashCode
	|
	|-RVA: 0x3A64570 Offset: 0x3A64671 VA: 0x3A64570
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>>.GetHashCode
	|
	|-RVA: 0x3A64B60 Offset: 0x3A64C61 VA: 0x3A64B60
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.GetHashCode
	|
	|-RVA: 0x3A651D0 Offset: 0x3A652D1 VA: 0x3A651D0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>>.GetHashCode
	|
	|-RVA: 0x3A65710 Offset: 0x3A65811 VA: 0x3A65710
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>.GetHashCode
	|
	|-RVA: 0x3A65B20 Offset: 0x3A65C21 VA: 0x3A65B20
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>.GetHashCode
	|
	|-RVA: 0x3A65F80 Offset: 0x3A66081 VA: 0x3A65F80
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>.GetHashCode
	|
	|-RVA: 0x3A66470 Offset: 0x3A66571 VA: 0x3A66470
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>.GetHashCode
	|
	|-RVA: 0x3A668C0 Offset: 0x3A669C1 VA: 0x3A668C0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>.GetHashCode
	|
	|-RVA: 0x3A66DA0 Offset: 0x3A66EA1 VA: 0x3A66DA0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>.GetHashCode
	|
	|-RVA: 0x3A67220 Offset: 0x3A67321 VA: 0x3A67220
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>.GetHashCode
	|
	|-RVA: 0x3A67680 Offset: 0x3A67781 VA: 0x3A67680
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>.GetHashCode
	|
	|-RVA: 0x3A67B30 Offset: 0x3A67C31 VA: 0x3A67B30
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>.GetHashCode
	|
	|-RVA: 0x3A67FF0 Offset: 0x3A680F1 VA: 0x3A67FF0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>.GetHashCode
	|
	|-RVA: 0x3A684E0 Offset: 0x3A685E1 VA: 0x3A684E0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>.GetHashCode
	|
	|-RVA: 0x3A68990 Offset: 0x3A68A91 VA: 0x3A68990
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>.GetHashCode
	|
	|-RVA: 0x3A68DF0 Offset: 0x3A68EF1 VA: 0x3A68DF0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>.GetHashCode
	|
	|-RVA: 0x3A69270 Offset: 0x3A69371 VA: 0x3A69270
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>.GetHashCode
	|
	|-RVA: 0x3A696B0 Offset: 0x3A697B1 VA: 0x3A696B0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>.GetHashCode
	|
	|-RVA: 0x3A69B60 Offset: 0x3A69C61 VA: 0x3A69B60
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>.GetHashCode
	|
	|-RVA: 0x3A6A020 Offset: 0x3A6A121 VA: 0x3A6A020
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>.GetHashCode
	|
	|-RVA: 0x3A6A500 Offset: 0x3A6A601 VA: 0x3A6A500
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>.GetHashCode
	|
	|-RVA: 0x3A6A9B0 Offset: 0x3A6AAB1 VA: 0x3A6A9B0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>.GetHashCode
	|
	|-RVA: 0x3A6AE90 Offset: 0x3A6AF91 VA: 0x3A6AE90
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.GetHashCode
	|
	|-RVA: 0x3A6B3D0 Offset: 0x3A6B4D1 VA: 0x3A6B3D0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>.GetHashCode
	|
	|-RVA: 0x3A6B8F0 Offset: 0x3A6B9F1 VA: 0x3A6B8F0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.GetHashCode
	|
	|-RVA: 0x3A6BE60 Offset: 0x3A6BF61 VA: 0x3A6BE60
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>.GetHashCode
	|
	|-RVA: 0x3A6C3B0 Offset: 0x3A6C4B1 VA: 0x3A6C3B0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.GetHashCode
	|
	|-RVA: 0x3A6C990 Offset: 0x3A6CA91 VA: 0x3A6C990
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>.GetHashCode
	|
	|-RVA: 0x3A6CF30 Offset: 0x3A6D031 VA: 0x3A6CF30
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.GetHashCode
	|
	|-RVA: 0x3A6D540 Offset: 0x3A6D641 VA: 0x3A6D540
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>.GetHashCode
	|
	|-RVA: 0x3A6DB00 Offset: 0x3A6DC01 VA: 0x3A6DB00
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.GetHashCode
	|
	|-RVA: 0x3A6E170 Offset: 0x3A6E271 VA: 0x3A6E170
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>.GetHashCode
	|
	|-RVA: 0x3A6E6E0 Offset: 0x3A6E7E1 VA: 0x3A6E6E0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>>>.GetHashCode
	|
	|-RVA: 0x3A6EBB0 Offset: 0x3A6ECB1 VA: 0x3A6EBB0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.GetHashCode
	|
	|-RVA: 0x3A6F050 Offset: 0x3A6F151 VA: 0x3A6F050
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>.GetHashCode
	|
	|-RVA: 0x3A6F4C0 Offset: 0x3A6F5C1 VA: 0x3A6F4C0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, bool>>>.GetHashCode
	|
	|-RVA: 0x3A6F950 Offset: 0x3A6FA51 VA: 0x3A6F950
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, Bounds>>>.GetHashCode
	|
	|-RVA: 0x3A6FDE0 Offset: 0x3A6FEE1 VA: 0x3A6FDE0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, byte>>>.GetHashCode
	|
	|-RVA: 0x3A70270 Offset: 0x3A70371 VA: 0x3A70270
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, Color>>>.GetHashCode
	|
	|-RVA: 0x3A70720 Offset: 0x3A70821 VA: 0x3A70720
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, double>>>.GetHashCode
	|
	|-RVA: 0x3C2F110 Offset: 0x3C2F211 VA: 0x3C2F110
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, int>>>.GetHashCode
	|
	|-RVA: 0x3C2F5A0 Offset: 0x3C2F6A1 VA: 0x3C2F5A0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, long>>>.GetHashCode
	|
	|-RVA: 0x3C2FA50 Offset: 0x3C2FB51 VA: 0x3C2FA50
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, object>>>.GetHashCode
	|
	|-RVA: 0x3C2FF00 Offset: 0x3C30001 VA: 0x3C2FF00
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, Quaternion>>>.GetHashCode
	|
	|-RVA: 0x3C303B0 Offset: 0x3C304B1 VA: 0x3C303B0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, Rect>>>.GetHashCode
	|
	|-RVA: 0x3C30840 Offset: 0x3C30941 VA: 0x3C30840
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, float>>>.GetHashCode
	|
	|-RVA: 0x3C30CD0 Offset: 0x3C30DD1 VA: 0x3C30CD0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, UniTask>>>.GetHashCode
	|
	|-RVA: 0x3C31160 Offset: 0x3C31261 VA: 0x3C31160
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, Unit>>>.GetHashCode
	|
	|-RVA: 0x3C315C0 Offset: 0x3C316C1 VA: 0x3C315C0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, Vector2>>>.GetHashCode
	|
	|-RVA: 0x3C31A20 Offset: 0x3C31B21 VA: 0x3C31A20
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, Vector3>>>.GetHashCode
	|
	|-RVA: 0x3C31ED0 Offset: 0x3C31FD1 VA: 0x3C31ED0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, Vector4>>>.GetHashCode
	|
	|-RVA: 0x3C32380 Offset: 0x3C32481 VA: 0x3C32380
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<int, object>>>.GetHashCode
	|
	|-RVA: 0x3C32830 Offset: 0x3C32931 VA: 0x3C32830
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<object, object>>>.GetHashCode
	|
	|-RVA: 0x3C32CF0 Offset: 0x3C32DF1 VA: 0x3C32CF0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.GetHashCode
	|
	|-RVA: 0x3C331E0 Offset: 0x3C332E1 VA: 0x3C331E0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<object, object, object>>>.GetHashCode
	|
	|-RVA: 0x3C336C0 Offset: 0x3C337C1 VA: 0x3C336C0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.GetHashCode
	|
	|-RVA: 0x3C33C00 Offset: 0x3C33D01 VA: 0x3C33C00
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<object, object, object, object>>>.GetHashCode
	|
	|-RVA: 0x3C34120 Offset: 0x3C34221 VA: 0x3C34120
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.GetHashCode
	|
	|-RVA: 0x3C346A0 Offset: 0x3C347A1 VA: 0x3C346A0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<object, object, object, object, object>>>.GetHashCode
	|
	|-RVA: 0x3C34BF0 Offset: 0x3C34CF1 VA: 0x3C34BF0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.GetHashCode
	|
	|-RVA: 0x3C351D0 Offset: 0x3C352D1 VA: 0x3C351D0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>.GetHashCode
	|
	|-RVA: 0x3C35770 Offset: 0x3C35871 VA: 0x3C35770
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.GetHashCode
	|
	|-RVA: 0x3C35D90 Offset: 0x3C35E91 VA: 0x3C35D90
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>.GetHashCode
	|
	|-RVA: 0x3C36350 Offset: 0x3C36451 VA: 0x3C36350
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>>.GetHashCode
	|
	|-RVA: 0x3C36990 Offset: 0x3C36A91 VA: 0x3C36990
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.GetHashCode
	|
	|-RVA: 0x3C36E20 Offset: 0x3C36F21 VA: 0x3C36E20
	|-ObjectEqualityComparer<ValueTuple<bool, AsyncUnit>>.GetHashCode
	|
	|-RVA: 0x3C37230 Offset: 0x3C37331 VA: 0x3C37230
	|-ObjectEqualityComparer<ValueTuple<bool, bool>>.GetHashCode
	|
	|-RVA: 0x3C37680 Offset: 0x3C37781 VA: 0x3C37680
	|-ObjectEqualityComparer<ValueTuple<bool, Bounds>>.GetHashCode
	|
	|-RVA: 0x3C37B30 Offset: 0x3C37C31 VA: 0x3C37B30
	|-ObjectEqualityComparer<ValueTuple<bool, byte>>.GetHashCode
	|
	|-RVA: 0x3C37F70 Offset: 0x3C38071 VA: 0x3C37F70
	|-ObjectEqualityComparer<ValueTuple<bool, Color>>.GetHashCode
	|
	|-RVA: 0x3C383F0 Offset: 0x3C384F1 VA: 0x3C383F0
	|-ObjectEqualityComparer<ValueTuple<bool, double>>.GetHashCode
	|
	|-RVA: 0x3C38820 Offset: 0x3C38921 VA: 0x3C38820
	|-ObjectEqualityComparer<ValueTuple<bool, int>>.GetHashCode
	|
	|-RVA: 0x3C38C30 Offset: 0x3C38D31 VA: 0x3C38C30
	|-ObjectEqualityComparer<ValueTuple<bool, long>>.GetHashCode
	|
	|-RVA: 0x3C39060 Offset: 0x3C39161 VA: 0x3C39060
	|-ObjectEqualityComparer<ValueTuple<bool, object>>.GetHashCode
	|
	|-RVA: 0x3C394C0 Offset: 0x3C395C1 VA: 0x3C394C0
	|-ObjectEqualityComparer<ValueTuple<bool, Quaternion>>.GetHashCode
	|
	|-RVA: 0x3C39970 Offset: 0x3C39A71 VA: 0x3C39970
	|-ObjectEqualityComparer<ValueTuple<bool, Rect>>.GetHashCode
	|
	|-RVA: 0x3C39DF0 Offset: 0x3C39EF1 VA: 0x3C39DF0
	|-ObjectEqualityComparer<ValueTuple<bool, float>>.GetHashCode
	|
	|-RVA: 0x3C3A200 Offset: 0x3C3A301 VA: 0x3C3A200
	|-ObjectEqualityComparer<ValueTuple<bool, UniTask>>.GetHashCode
	|
	|-RVA: 0x3C3A630 Offset: 0x3C3A731 VA: 0x3C3A630
	|-ObjectEqualityComparer<ValueTuple<bool, Unit>>.GetHashCode
	|
	|-RVA: 0x3C3AA50 Offset: 0x3C3AB51 VA: 0x3C3AA50
	|-ObjectEqualityComparer<ValueTuple<bool, Vector2>>.GetHashCode
	|
	|-RVA: 0x3C3AEB0 Offset: 0x3C3AFB1 VA: 0x3C3AEB0
	|-ObjectEqualityComparer<ValueTuple<bool, Vector3>>.GetHashCode
	|
	|-RVA: 0x3C3B310 Offset: 0x3C3B411 VA: 0x3C3B310
	|-ObjectEqualityComparer<ValueTuple<bool, Vector4>>.GetHashCode
	|
	|-RVA: 0x3C3B790 Offset: 0x3C3B891 VA: 0x3C3B790
	|-ObjectEqualityComparer<ValueTuple<int, object>>.GetHashCode
	|
	|-RVA: 0x3C3BBB0 Offset: 0x3C3BCB1 VA: 0x3C3BBB0
	|-ObjectEqualityComparer<ValueTuple<Int32Enum, int>>.GetHashCode
	|
	|-RVA: 0x3C3BFF0 Offset: 0x3C3C0F1 VA: 0x3C3BFF0
	|-ObjectEqualityComparer<ValueTuple<object, ValueTuple<object, int>>>.GetHashCode
	|
	|-RVA: 0x3C3C460 Offset: 0x3C3C561 VA: 0x3C3C460
	|-ObjectEqualityComparer<ValueTuple<object, int>>.GetHashCode
	|
	|-RVA: 0x3C3C880 Offset: 0x3C3C981 VA: 0x3C3C880
	|-ObjectEqualityComparer<ValueTuple<object, object>>.GetHashCode
	|
	|-RVA: 0x3C3CCA0 Offset: 0x3C3CDA1 VA: 0x3C3CCA0
	|-ObjectEqualityComparer<ValueTuple<object, float>>.GetHashCode
	|
	|-RVA: 0x3C3D0E0 Offset: 0x3C3D1E1 VA: 0x3C3D0E0
	|-ObjectEqualityComparer<ValueTuple<Vector3, float>>.GetHashCode
	|
	|-RVA: 0x3C3D5A0 Offset: 0x3C3D6A1 VA: 0x3C3D5A0
	|-ObjectEqualityComparer<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>.GetHashCode
	|
	|-RVA: 0x3C3DA50 Offset: 0x3C3DB51 VA: 0x3C3DA50
	|-ObjectEqualityComparer<ValueTuple<object, Int32Enum, int>>.GetHashCode
	|
	|-RVA: 0x3C3DEA0 Offset: 0x3C3DFA1 VA: 0x3C3DEA0
	|-ObjectEqualityComparer<ValueTuple<object, object, object>>.GetHashCode
	|
	|-RVA: 0x3C3E370 Offset: 0x3C3E471 VA: 0x3C3E370
	|-ObjectEqualityComparer<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.GetHashCode
	|
	|-RVA: 0x3C3E890 Offset: 0x3C3E991 VA: 0x3C3E890
	|-ObjectEqualityComparer<ValueTuple<object, int, int, int>>.GetHashCode
	|
	|-RVA: 0x3C3ED30 Offset: 0x3C3EE31 VA: 0x3C3ED30
	|-ObjectEqualityComparer<ValueTuple<object, object, object, object>>.GetHashCode
	|
	|-RVA: 0x3C3F220 Offset: 0x3C3F321 VA: 0x3C3F220
	|-ObjectEqualityComparer<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.GetHashCode
	|
	|-RVA: 0x3C3F790 Offset: 0x3C3F891 VA: 0x3C3F790
	|-ObjectEqualityComparer<ValueTuple<object, object, object, object, object>>.GetHashCode
	|
	|-RVA: 0x3C3FCD0 Offset: 0x3C3FDD1 VA: 0x3C3FCD0
	|-ObjectEqualityComparer<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.GetHashCode
	|
	|-RVA: 0x3C40280 Offset: 0x3C40381 VA: 0x3C40280
	|-ObjectEqualityComparer<ValueTuple<object, object, object, object, object, object>>.GetHashCode
	|
	|-RVA: 0x3C407D0 Offset: 0x3C408D1 VA: 0x3C407D0
	|-ObjectEqualityComparer<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.GetHashCode
	|
	|-RVA: 0x3C40DE0 Offset: 0x3C40EE1 VA: 0x3C40DE0
	|-ObjectEqualityComparer<ValueTuple<object, object, object, object, object, object, object>>.GetHashCode
	|
	|-RVA: 0x3C41390 Offset: 0x3C41491 VA: 0x3C41390
	|-ObjectEqualityComparer<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>.GetHashCode
	|
	|-RVA: 0x3C419C0 Offset: 0x3C41AC1 VA: 0x3C419C0
	|-ObjectEqualityComparer<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>.GetHashCode
	|
	|-RVA: 0x3C41E50 Offset: 0x3C41F51 VA: 0x3C41E50
	|-ObjectEqualityComparer<AnimatorClipInfo>.GetHashCode
	|
	|-RVA: 0x3C422D0 Offset: 0x3C423D1 VA: 0x3C422D0
	|-ObjectEqualityComparer<AsyncOperationHandle>.GetHashCode
	|
	|-RVA: 0x3C42700 Offset: 0x3C42801 VA: 0x3C42700
	|-ObjectEqualityComparer<AsyncUnit>.GetHashCode
	|
	|-RVA: 0x3C42AD0 Offset: 0x3C42BD1 VA: 0x3C42AD0
	|-ObjectEqualityComparer<BoneWeight>.GetHashCode
	|
	|-RVA: 0x3C42DE0 Offset: 0x3C42EE1 VA: 0x3C42DE0
	|-ObjectEqualityComparer<bool>.GetHashCode
	|
	|-RVA: 0x3C430F0 Offset: 0x3C431F1 VA: 0x3C430F0
	|-ObjectEqualityComparer<Bounds>.GetHashCode
	|
	|-RVA: 0x3C433F0 Offset: 0x3C434F1 VA: 0x3C433F0
	|-ObjectEqualityComparer<byte>.GetHashCode
	|
	|-RVA: 0x3C43740 Offset: 0x3C43841 VA: 0x3C43740
	|-ObjectEqualityComparer<CameraInfo>.GetHashCode
	|
	|-RVA: 0x3C43B70 Offset: 0x3C43C71 VA: 0x3C43B70
	|-ObjectEqualityComparer<CancellationToken>.GetHashCode
	|
	|-RVA: 0x3C43E80 Offset: 0x3C43F81 VA: 0x3C43E80
	|-ObjectEqualityComparer<CancellationTokenRegistration>.GetHashCode
	|
	|-RVA: 0x3C44180 Offset: 0x3C44281 VA: 0x3C44180
	|-ObjectEqualityComparer<char>.GetHashCode
	|
	|-RVA: 0x3C44490 Offset: 0x3C44591 VA: 0x3C44490
	|-ObjectEqualityComparer<Color>.GetHashCode
	|
	|-RVA: 0x3C44820 Offset: 0x3C44921 VA: 0x3C44820
	|-ObjectEqualityComparer<Color32>.GetHashCode
	|
	|-RVA: 0x3C44C60 Offset: 0x3C44D61 VA: 0x3C44C60
	|-ObjectEqualityComparer<ColorBlock>.GetHashCode
	|
	|-RVA: 0x3C44FF0 Offset: 0x3C450F1 VA: 0x3C44FF0
	|-ObjectEqualityComparer<ConstraintSource>.GetHashCode
	|
	|-RVA: 0x3C45480 Offset: 0x3C45581 VA: 0x3C45480
	|-ObjectEqualityComparer<ContourVertex>.GetHashCode
	|
	|-RVA: 0x3C45950 Offset: 0x3C45A51 VA: 0x3C45950
	|-ObjectEqualityComparer<DataStoreRatingInfo>.GetHashCode
	|
	|-RVA: 0x3C45E00 Offset: 0x3C45F01 VA: 0x3C45E00
	|-ObjectEqualityComparer<DataStoreResult>.GetHashCode
	|
	|-RVA: 0x3C46220 Offset: 0x3C46321 VA: 0x3C46220
	|-ObjectEqualityComparer<DateTime>.GetHashCode
	|
	|-RVA: 0x3C46530 Offset: 0x3C46631 VA: 0x3C46530
	|-ObjectEqualityComparer<DateTimeOffset>.GetHashCode
	|
	|-RVA: 0x3C46860 Offset: 0x3C46961 VA: 0x3C46860
	|-ObjectEqualityComparer<Decimal>.GetHashCode
	|
	|-RVA: 0x3C46C00 Offset: 0x3C46D01 VA: 0x3C46C00
	|-ObjectEqualityComparer<DiagnosticEvent>.GetHashCode
	|
	|-RVA: 0x3C47090 Offset: 0x3C47191 VA: 0x3C47090
	|-ObjectEqualityComparer<double>.GetHashCode
	|
	|-RVA: 0x3C473B0 Offset: 0x3C474B1 VA: 0x3C473B0
	|-ObjectEqualityComparer<FXZ>.GetHashCode
	|
	|-RVA: 0x3C47740 Offset: 0x3C47841 VA: 0x3C47740
	|-ObjectEqualityComparer<Friend>.GetHashCode
	|
	|-RVA: 0x3C47BB0 Offset: 0x3C47CB1 VA: 0x3C47BB0
	|-ObjectEqualityComparer<GlyphRect>.GetHashCode
	|
	|-RVA: 0x3C47EE0 Offset: 0x3C47FE1 VA: 0x3C47EE0
	|-ObjectEqualityComparer<Guid>.GetHashCode
	|
	|-RVA: 0x3C48200 Offset: 0x3C48301 VA: 0x3C48200
	|-ObjectEqualityComparer<short>.GetHashCode
	|
	|-RVA: 0x3C48500 Offset: 0x3C48601 VA: 0x3C48500
	|-ObjectEqualityComparer<int>.GetHashCode
	|
	|-RVA: 0x3C48840 Offset: 0x3C48941 VA: 0x3C48840
	|-ObjectEqualityComparer<Int32Enum>.GetHashCode
	|
	|-RVA: 0x3C48C00 Offset: 0x3C48D01 VA: 0x3C48C00
	|-ObjectEqualityComparer<long>.GetHashCode
	|
	|-RVA: 0x3C48F40 Offset: 0x3C49041 VA: 0x3C48F40
	|-ObjectEqualityComparer<Int64Enum>.GetHashCode
	|
	|-RVA: 0x3C49300 Offset: 0x3C49401 VA: 0x3C49300
	|-ObjectEqualityComparer<IntPtr>.GetHashCode
	|
	|-RVA: 0x3C49650 Offset: 0x3C49751 VA: 0x3C49650
	|-ObjectEqualityComparer<InterpretedFrameInfo>.GetHashCode
	|
	|-RVA: 0x3C49AE0 Offset: 0x3C49BE1 VA: 0x3C49AE0
	|-ObjectEqualityComparer<IntervalTreeNode>.GetHashCode
	|
	|-RVA: 0x3C49F90 Offset: 0x3C4A091 VA: 0x3C49F90
	|-ObjectEqualityComparer<LayerMask>.GetHashCode
	|
	|-RVA: 0x3C4A3F0 Offset: 0x3C4A4F1 VA: 0x3C4A3F0
	|-ObjectEqualityComparer<LengthLimitProperties>.GetHashCode
	|
	|-RVA: 0x3C4A810 Offset: 0x3C4A911 VA: 0x3C4A810
	|-ObjectEqualityComparer<MapPos>.GetHashCode
	|
	|-RVA: 0x3C4AB30 Offset: 0x3C4AC31 VA: 0x3C4AB30
	|-ObjectEqualityComparer<Matrix4x4>.GetHashCode
	|
	|-RVA: 0x3C4AED0 Offset: 0x3C4AFD1 VA: 0x3C4AED0
	|-ObjectEqualityComparer<Navigation>.GetHashCode
	|
	|-RVA: 0x3C4B330 Offset: 0x3C4B431 VA: 0x3C4B330
	|-ObjectEqualityComparer<object>.GetHashCode
	|
	|-RVA: 0x3C4B6A0 Offset: 0x3C4B7A1 VA: 0x3C4B6A0
	|-ObjectEqualityComparer<ObjectInitializationData>.GetHashCode
	|
	|-RVA: 0x3C4BB70 Offset: 0x3C4BC71 VA: 0x3C4BB70
	|-ObjectEqualityComparer<Playable>.GetHashCode
	|
	|-RVA: 0x3C4C000 Offset: 0x3C4C101 VA: 0x3C4C000
	|-ObjectEqualityComparer<PlayableBinding>.GetHashCode
	|
	|-RVA: 0x3C4C4E0 Offset: 0x3C4C5E1 VA: 0x3C4C4E0
	|-ObjectEqualityComparer<PlayerLoopSystem>.GetHashCode
	|
	|-RVA: 0x3C4C9E0 Offset: 0x3C4CAE1 VA: 0x3C4C9E0
	|-ObjectEqualityComparer<PlayerLoopSystemInternal>.GetHashCode
	|
	|-RVA: 0x3C4CE70 Offset: 0x3C4CF71 VA: 0x3C4CE70
	|-ObjectEqualityComparer<Quaternion>.GetHashCode
	|
	|-RVA: 0x3C4D200 Offset: 0x3C4D301 VA: 0x3C4D200
	|-ObjectEqualityComparer<RandomSeed>.GetHashCode
	|
	|-RVA: 0x3C4D670 Offset: 0x3C4D771 VA: 0x3C4D670
	|-ObjectEqualityComparer<RangePositionInfo>.GetHashCode
	|
	|-RVA: 0x3C4DAE0 Offset: 0x3C4DBE1 VA: 0x3C4DAE0
	|-ObjectEqualityComparer<Ranking2ChartInfoInput>.GetHashCode
	|
	|-RVA: 0x3C4DF80 Offset: 0x3C4E081 VA: 0x3C4DF80
	|-ObjectEqualityComparer<RaycastHit2D>.GetHashCode
	|
	|-RVA: 0x3C4E4D0 Offset: 0x3C4E5D1 VA: 0x3C4E4D0
	|-ObjectEqualityComparer<RaycastResult>.GetHashCode
	|
	|-RVA: 0x3C4E9B0 Offset: 0x3C4EAB1 VA: 0x3C4E9B0
	|-ObjectEqualityComparer<Rect>.GetHashCode
	|
	|-RVA: 0x3C4ED40 Offset: 0x3C4EE41 VA: 0x3C4ED40
	|-ObjectEqualityComparer<RendererListHandle>.GetHashCode
	|
	|-RVA: 0x3C4F1A0 Offset: 0x3C4F2A1 VA: 0x3C4F1A0
	|-ObjectEqualityComparer<ResourceHandle>.GetHashCode
	|
	|-RVA: 0x3C4F600 Offset: 0x3C4F701 VA: 0x3C4F600
	|-ObjectEqualityComparer<ResourceLocator>.GetHashCode
	|
	|-RVA: 0x3C4FA20 Offset: 0x3C4FB21 VA: 0x3C4FA20
	|-ObjectEqualityComparer<sbyte>.GetHashCode
	|
	|-RVA: 0x3C4FD30 Offset: 0x3C4FE31 VA: 0x3C4FD30
	|-ObjectEqualityComparer<ShaderTagId>.GetHashCode
	|
	|-RVA: 0x3C50030 Offset: 0x3C50131 VA: 0x3C50030
	|-ObjectEqualityComparer<float>.GetHashCode
	|
	|-RVA: 0x3C50380 Offset: 0x3C50481 VA: 0x3C50380
	|-ObjectEqualityComparer<SphericalHarmonicsL2>.GetHashCode
	|
	|-RVA: 0x3C50750 Offset: 0x3C50851 VA: 0x3C50750
	|-ObjectEqualityComparer<SpriteState>.GetHashCode
	|
	|-RVA: 0x3C50C30 Offset: 0x3C50D31 VA: 0x3C50C30
	|-ObjectEqualityComparer<SubMeshDescriptor>.GetHashCode
	|
	|-RVA: 0x3C51100 Offset: 0x3C51201 VA: 0x3C51100
	|-ObjectEqualityComparer<TablePair>.GetHashCode
	|
	|-RVA: 0x3C51530 Offset: 0x3C51631 VA: 0x3C51530
	|-ObjectEqualityComparer<TimeSpan>.GetHashCode
	|
	|-RVA: 0x3C51890 Offset: 0x3C51991 VA: 0x3C51890
	|-ObjectEqualityComparer<UICharInfo>.GetHashCode
	|
	|-RVA: 0x3C51D40 Offset: 0x3C51E41 VA: 0x3C51D40
	|-ObjectEqualityComparer<UILineInfo>.GetHashCode
	|
	|-RVA: 0x3C52230 Offset: 0x3C52331 VA: 0x3C52230
	|-ObjectEqualityComparer<UIVertex>.GetHashCode
	|
	|-RVA: 0x3C52780 Offset: 0x3C52881 VA: 0x3C52780
	|-ObjectEqualityComparer<ushort>.GetHashCode
	|
	|-RVA: 0x3C52A80 Offset: 0x3C52B81 VA: 0x3C52A80
	|-ObjectEqualityComparer<uint>.GetHashCode
	|
	|-RVA: 0x3C52D90 Offset: 0x3C52E91 VA: 0x3C52D90
	|-ObjectEqualityComparer<ulong>.GetHashCode
	|
	|-RVA: 0x3C530E0 Offset: 0x3C531E1 VA: 0x3C530E0
	|-ObjectEqualityComparer<UniTask>.GetHashCode
	|
	|-RVA: 0x3C534B0 Offset: 0x3C535B1 VA: 0x3C534B0
	|-ObjectEqualityComparer<Unit>.GetHashCode
	|
	|-RVA: 0x3C537C0 Offset: 0x3C538C1 VA: 0x3C537C0
	|-ObjectEqualityComparer<Vector2>.GetHashCode
	|
	|-RVA: 0x3C53AE0 Offset: 0x3C53BE1 VA: 0x3C53AE0
	|-ObjectEqualityComparer<Vector3>.GetHashCode
	|
	|-RVA: 0x3C53E40 Offset: 0x3C53F41 VA: 0x3C53E40
	|-ObjectEqualityComparer<Vector4>.GetHashCode
	|
	|-RVA: 0x3C54190 Offset: 0x3C54291 VA: 0x3C54190
	|-ObjectEqualityComparer<VertexAttributeDescriptor>.GetHashCode
	|
	|-RVA: 0x3C54500 Offset: 0x3C54601 VA: 0x3C54500
	|-ObjectEqualityComparer<X509ChainStatus>.GetHashCode
	|
	|-RVA: 0x3C54970 Offset: 0x3C54A71 VA: 0x3C54970
	|-ObjectEqualityComparer<XPathNodeRef>.GetHashCode
	|
	|-RVA: 0x3C54DC0 Offset: 0x3C54EC1 VA: 0x3C54DC0
	|-ObjectEqualityComparer<XRView>.GetHashCode
	|
	|-RVA: 0x3C55270 Offset: 0x3C55371 VA: 0x3C55270
	|-ObjectEqualityComparer<AmiiboSequence.GainItemData>.GetHashCode
	|
	|-RVA: 0x3C55710 Offset: 0x3C55811 VA: 0x3C55710
	|-ObjectEqualityComparer<AnimationOutputWeightProcessor.WeightInfo>.GetHashCode
	|
	|-RVA: 0x3C55BE0 Offset: 0x3C55CE1 VA: 0x3C55BE0
	|-ObjectEqualityComparer<ArenaOrderSequence.GodInfo>.GetHashCode
	|
	|-RVA: 0x3C56050 Offset: 0x3C56151 VA: 0x3C56050
	|-ObjectEqualityComparer<BattleInfo.SupportData>.GetHashCode
	|
	|-RVA: 0x3C564C0 Offset: 0x3C565C1 VA: 0x3C564C0
	|-ObjectEqualityComparer<BeforeRenderHelper.OrderBlock>.GetHashCode
	|
	|-RVA: 0x3C56950 Offset: 0x3C56A51 VA: 0x3C56950
	|-ObjectEqualityComparer<Camera.RenderRequest>.GetHashCode
	|
	|-RVA: 0x3C56E00 Offset: 0x3C56F01 VA: 0x3C56E00
	|-ObjectEqualityComparer<CameraState.CustomBlendable>.GetHashCode
	|
	|-RVA: 0x3C57270 Offset: 0x3C57371 VA: 0x3C57270
	|-ObjectEqualityComparer<CinemachineClearShot.Pair>.GetHashCode
	|
	|-RVA: 0x3C576D0 Offset: 0x3C577D1 VA: 0x3C576D0
	|-ObjectEqualityComparer<CinemachineStateDrivenCamera.HashPair>.GetHashCode
	|
	|-RVA: 0x3C57B50 Offset: 0x3C57C51 VA: 0x3C57B50
	|-ObjectEqualityComparer<DelayedActionManager.DelegateInfo>.GetHashCode
	|
	|-RVA: 0x3C58030 Offset: 0x3C58131 VA: 0x3C58030
	|-ObjectEqualityComparer<Detail.AsyncResultInt>.GetHashCode
	|
	|-RVA: 0x3C58500 Offset: 0x3C58601 VA: 0x3C58500
	|-ObjectEqualityComparer<Detail.CppArray>.GetHashCode
	|
	|-RVA: 0x3C589A0 Offset: 0x3C58AA1 VA: 0x3C589A0
	|-ObjectEqualityComparer<Detail.NotificationEventInt>.GetHashCode
	|
	|-RVA: 0x3C58E70 Offset: 0x3C58F71 VA: 0x3C58E70
	|-ObjectEqualityComparer<DragonRideTargetGroup.ChainParam>.GetHashCode
	|
	|-RVA: 0x3C592E0 Offset: 0x3C593E1 VA: 0x3C592E0
	|-ObjectEqualityComparer<DynamicMesh.State>.GetHashCode
	|
	|-RVA: 0x3C59740 Offset: 0x3C59841 VA: 0x3C59740
	|-ObjectEqualityComparer<GameVariable.Value>.GetHashCode
	|
	|-RVA: 0x3C59BD0 Offset: 0x3C59CD1 VA: 0x3C59BD0
	|-ObjectEqualityComparer<GmapPathAdjuster.TargetModel>.GetHashCode
	|
	|-RVA: 0x3C5A0A0 Offset: 0x3C5A1A1 VA: 0x3C5A0A0
	|-ObjectEqualityComparer<GmapSpotAdjuster.TargetModel>.GetHashCode
	|
	|-RVA: 0x3C5A570 Offset: 0x3C5A671 VA: 0x3C5A570
	|-ObjectEqualityComparer<HubFastTravel.Location>.GetHashCode
	|
	|-RVA: 0x3C5AA50 Offset: 0x3C5AB51 VA: 0x3C5AA50
	|-ObjectEqualityComparer<HubLensFlare.Flare>.GetHashCode
	|
	|-RVA: 0x3C5AF20 Offset: 0x3C5B021 VA: 0x3C5AF20
	|-ObjectEqualityComparer<InventoryPoolItemMenuContent.KindBgNameClass>.GetHashCode
	|
	|-RVA: 0x3C5B390 Offset: 0x3C5B491 VA: 0x3C5B390
	|-ObjectEqualityComparer<Map.Pos>.GetHashCode
	|
	|-RVA: 0x3C5B7F0 Offset: 0x3C5B8F1 VA: 0x3C5B7F0
	|-ObjectEqualityComparer<MapImage.BackupTerrain>.GetHashCode
	|
	|-RVA: 0x3C5BC60 Offset: 0x3C5BD61 VA: 0x3C5BC60
	|-ObjectEqualityComparer<MapImageRange.Pos>.GetHashCode
	|
	|-RVA: 0x3C5C110 Offset: 0x3C5C211 VA: 0x3C5C110
	|-ObjectEqualityComparer<MapMind.Record>.GetHashCode
	|
	|-RVA: 0x3C5C650 Offset: 0x3C5C751 VA: 0x3C5C650
	|-ObjectEqualityComparer<MapMind.Target>.GetHashCode
	|
	|-RVA: 0x36FCEB0 Offset: 0x36FCFB1 VA: 0x36FCEB0
	|-ObjectEqualityComparer<MapPanelDebug.Entity>.GetHashCode
	|
	|-RVA: 0x36FD360 Offset: 0x36FD461 VA: 0x36FD360
	|-ObjectEqualityComparer<NexRanking.Data>.GetHashCode
	|
	|-RVA: 0x36FD7C0 Offset: 0x36FD8C1 VA: 0x36FD7C0
	|-ObjectEqualityComparer<NexVersus.RatingData>.GetHashCode
	|
	|-RVA: 0x36FDC30 Offset: 0x36FDD31 VA: 0x36FDC30
	|-ObjectEqualityComparer<PackedPlayModeBuildLogs.RuntimeBuildLog>.GetHashCode
	|
	|-RVA: 0x36FE0D0 Offset: 0x36FE1D1 VA: 0x36FE0D0
	|-ObjectEqualityComparer<ParticleSystem.Particle>.GetHashCode
	|
	|-RVA: 0x36FE5B0 Offset: 0x36FE6B1 VA: 0x36FE5B0
	|-ObjectEqualityComparer<QualitySettingsStack.Settings>.GetHashCode
	|
	|-RVA: 0x36FEA80 Offset: 0x36FEB81 VA: 0x36FEA80
	|-ObjectEqualityComparer<RangeData.Offset>.GetHashCode
	|
	|-RVA: 0x36FEF00 Offset: 0x36FF001 VA: 0x36FEF00
	|-ObjectEqualityComparer<RenderGraphDebugData.PassDebugData>.GetHashCode
	|
	|-RVA: 0x36FF3E0 Offset: 0x36FF4E1 VA: 0x36FF3E0
	|-ObjectEqualityComparer<RenderGraphDebugData.ResourceDebugData>.GetHashCode
	|
	|-RVA: 0x36FF8B0 Offset: 0x36FF9B1 VA: 0x36FF8B0
	|-ObjectEqualityComparer<RingCleaningUnitSelectMenu.GodParam>.GetHashCode
	|
	|-RVA: 0x36FFD50 Offset: 0x36FFE51 VA: 0x36FFD50
	|-ObjectEqualityComparer<SequenceNode.SequenceConstructPosContext>.GetHashCode
	|
	|-RVA: 0x3700250 Offset: 0x3700351 VA: 0x3700250
	|-ObjectEqualityComparer<ShadowUtility.Edge>.GetHashCode
	|
	|-RVA: 0x3700720 Offset: 0x3700821 VA: 0x3700720
	|-ObjectEqualityComparer<SimpleAnimationPlayable.QueuedState>.GetHashCode
	|
	|-RVA: 0x3700B90 Offset: 0x3700C91 VA: 0x3700B90
	|-ObjectEqualityComparer<SkillArray.Entity>.GetHashCode
	|
	|-RVA: 0x3701000 Offset: 0x3701101 VA: 0x3701000
	|-ObjectEqualityComparer<Stream.Info>.GetHashCode
	|
	|-RVA: 0x37014C0 Offset: 0x37015C1 VA: 0x37014C0
	|-ObjectEqualityComparer<TexturePacker_JsonArray.Frame>.GetHashCode
	|
	|-RVA: 0x37019E0 Offset: 0x3701AE1 VA: 0x37019E0
	|-ObjectEqualityComparer<TimeNotificationBehaviour.NotificationEntry>.GetHashCode
	|
	|-RVA: 0x3701EB0 Offset: 0x3701FB1 VA: 0x3701EB0
	|-ObjectEqualityComparer<UnitySynchronizationContext.WorkRequest>.GetHashCode
	|
	|-RVA: 0x3702360 Offset: 0x3702461 VA: 0x3702360
	|-ObjectEqualityComparer<XmlSchemaObjectTable.XmlSchemaObjectEntry>.GetHashCode
	|
	|-RVA: 0x37027D0 Offset: 0x37028D1 VA: 0x37027D0
	|-ObjectEqualityComparer<AIThink.EnchantThink.SurroundingInfo>.GetHashCode
	|
	|-RVA: 0x3702C30 Offset: 0x3702D31 VA: 0x3702C30
	|-ObjectEqualityComparer<AssetBundleBuildMap.AssetBundleEntry.AssetPathString>.GetHashCode
	|
	|-RVA: 0x37030D0 Offset: 0x37031D1 VA: 0x37030D0
	|-ObjectEqualityComparer<Detail.DataStore.DataStoreChangeMetaParamInt>.GetHashCode
	|
	|-RVA: 0x3703580 Offset: 0x3703681 VA: 0x3703580
	|-ObjectEqualityComparer<Detail.DataStore.DataStoreDeleteParamInt>.GetHashCode
	|
	|-RVA: 0x3703A20 Offset: 0x3703B21 VA: 0x3703A20
	|-ObjectEqualityComparer<Detail.DataStore.DataStoreGetMetaParamInt>.GetHashCode
	|
	|-RVA: 0x3703F20 Offset: 0x3704021 VA: 0x3703F20
	|-ObjectEqualityComparer<Detail.DataStore.DataStoreMetaInfoInt>.GetHashCode
	|
	|-RVA: 0x37043F0 Offset: 0x37044F1 VA: 0x37043F0
	|-ObjectEqualityComparer<Detail.DataStore.DataStorePasswordInfoInt>.GetHashCode
	|
	|-RVA: 0x37048C0 Offset: 0x37049C1 VA: 0x37048C0
	|-ObjectEqualityComparer<Detail.DataStore.DataStorePersistenceInfoInt>.GetHashCode
	|
	|-RVA: 0x3704DA0 Offset: 0x3704EA1 VA: 0x3704DA0
	|-ObjectEqualityComparer<Detail.DataStore.DataStorePreparePostParamInt>.GetHashCode
	|
	|-RVA: 0x3705250 Offset: 0x3705351 VA: 0x3705250
	|-ObjectEqualityComparer<Detail.DataStore.DataStoreRateObjectParamInt>.GetHashCode
	|
	|-RVA: 0x37056E0 Offset: 0x37057E1 VA: 0x37056E0
	|-ObjectEqualityComparer<Detail.DataStore.DataStoreRatingInitParamInt>.GetHashCode
	|
	|-RVA: 0x3705B90 Offset: 0x3705C91 VA: 0x3705B90
	|-ObjectEqualityComparer<Detail.DataStore.DataStoreRatingTargetInt>.GetHashCode
	|
	|-RVA: 0x3706040 Offset: 0x3706141 VA: 0x3706040
	|-ObjectEqualityComparer<Detail.Ranking.RankingCachedResultInt>.GetHashCode
	|
	|-RVA: 0x3706540 Offset: 0x3706641 VA: 0x3706540
	|-ObjectEqualityComparer<Detail.Ranking.RankingOrderParamInt>.GetHashCode
	|
	|-RVA: 0x37069F0 Offset: 0x3706AF1 VA: 0x37069F0
	|-ObjectEqualityComparer<Detail.Ranking.RankingRankDataInt>.GetHashCode
	|
	|-RVA: 0x3706F50 Offset: 0x3707051 VA: 0x3706F50
	|-ObjectEqualityComparer<Detail.Ranking2.Ranking2ChartInfoInt>.GetHashCode
	|
	|-RVA: 0x37074E0 Offset: 0x37075E1 VA: 0x37074E0
	|-ObjectEqualityComparer<Detail.Ranking2.Ranking2RankDataInt>.GetHashCode
	|
	|-RVA: 0x37079E0 Offset: 0x3707AE1 VA: 0x37079E0
	|-ObjectEqualityComparer<Detail.Ranking2.Ranking2ScoreDataInt>.GetHashCode
	|
	|-RVA: 0x3707E70 Offset: 0x3707F71 VA: 0x3707E70
	|-ObjectEqualityComparer<Detail.Screening.ScreeningContextInfoInt>.GetHashCode
	|
	|-RVA: 0x3708370 Offset: 0x3708471 VA: 0x3708370
	|-ObjectEqualityComparer<Detail.Subscriber.SubscriberContentInt>.GetHashCode
	|
	|-RVA: 0x37088B0 Offset: 0x37089B1 VA: 0x37088B0
	|-ObjectEqualityComparer<Detail.Subscriber.SubscriberGetContentParamInt>.GetHashCode
	|
	|-RVA: 0x3708D90 Offset: 0x3708E91 VA: 0x3708D90
	|-ObjectEqualityComparer<Detail.Subscriber.SubscriberUserStatusInfoInt>.GetHashCode
	|
	|-RVA: 0x3709280 Offset: 0x3709381 VA: 0x3709280
	|-ObjectEqualityComparer<Detail.Subscriber.SubscriberUserStatusParamInt>.GetHashCode
	|
	|-RVA: 0x3709730 Offset: 0x3709831 VA: 0x3709730
	|-ObjectEqualityComparer<Detail.Utility.IntegerSettings>.GetHashCode
	|
	|-RVA: 0x3709B90 Offset: 0x3709C91 VA: 0x3709B90
	|-ObjectEqualityComparer<Detail.Utility.UniqueIdInfoInt>.GetHashCode
	|
	|-RVA: 0x370A010 Offset: 0x370A111 VA: 0x370A010
	|-ObjectEqualityComparer<MapHistory.Rewind.LatestInspectorData>.GetHashCode
	|
	|-RVA: 0x370A4C0 Offset: 0x370A5C1 VA: 0x370A4C0
	|-ObjectEqualityComparer<MapHistory.Rewind.WorkTerrainData>.GetHashCode
	|
	|-RVA: 0x370A960 Offset: 0x370AA61 VA: 0x370A960
	|-ObjectEqualityComparer<MapSkill.AroundCalculator.Result>.GetHashCode
	|
	|-RVA: 0x370AE00 Offset: 0x370AF01 VA: 0x370AE00
	|-ObjectEqualityComparer<TargetPositionCache.CacheCurve.Item>.GetHashCode
	|
	|-RVA: 0x370B310 Offset: 0x370B411 VA: 0x370B310
	|-ObjectEqualityComparer<TargetPositionCache.CacheEntry.RecordingItem>.GetHashCode
	|
	|-RVA: 0x370B810 Offset: 0x370B911 VA: 0x370B810
	|-ObjectEqualityComparer<TerrainUtility.TerrainMap.TileCoord>.GetHashCode
	*/

	// RVA: -1 Offset: -1 Slot: 10
	internal override int IndexOf(T[] array, T value, int startIndex, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BA5E20 Offset: 0x2BA5F21 VA: 0x2BA5E20
	|-ObjectEqualityComparer<AsyncOperationHandle<object>>.IndexOf
	|
	|-RVA: 0x2BA62F0 Offset: 0x2BA63F1 VA: 0x2BA62F0
	|-ObjectEqualityComparer<IntervalTree.Entry<object>>.IndexOf
	|
	|-RVA: 0x2BA6790 Offset: 0x2BA6891 VA: 0x2BA6790
	|-ObjectEqualityComparer<KeyValuePair<DateTime, object>>.IndexOf
	|
	|-RVA: 0x2BA6C00 Offset: 0x2BA6D01 VA: 0x2BA6C00
	|-ObjectEqualityComparer<KeyValuePair<int, object>>.IndexOf
	|
	|-RVA: 0x2BA70A0 Offset: 0x2BA71A1 VA: 0x2BA70A0
	|-ObjectEqualityComparer<KeyValuePair<object, ValueTuple<int, DateTime, object>>>.IndexOf
	|
	|-RVA: 0x2BA7540 Offset: 0x2BA7641 VA: 0x2BA7540
	|-ObjectEqualityComparer<KeyValuePair<object, object>>.IndexOf
	|
	|-RVA: 0x2BA79E0 Offset: 0x2BA7AE1 VA: 0x2BA79E0
	|-ObjectEqualityComparer<CommonBattleSequence.Reliance<object>>.IndexOf
	|
	|-RVA: 0x2BA7E80 Offset: 0x2BA7F81 VA: 0x2BA7E80
	|-ObjectEqualityComparer<RenderGraphResourcePool.ResourceLogInfo<object>>.IndexOf
	|
	|-RVA: 0x2BA82D0 Offset: 0x2BA83D1 VA: 0x2BA82D0
	|-ObjectEqualityComparer<TimeInterval<object>>.IndexOf
	|
	|-RVA: 0x2BA8740 Offset: 0x2BA8841 VA: 0x2BA8740
	|-ObjectEqualityComparer<Timestamped<object>>.IndexOf
	|
	|-RVA: 0x2BA8BB0 Offset: 0x2BA8CB1 VA: 0x2BA8BB0
	|-ObjectEqualityComparer<UniTask<object>>.IndexOf
	|
	|-RVA: 0x2BA9000 Offset: 0x2BA9101 VA: 0x2BA9000
	|-ObjectEqualityComparer<ValueTuple<ValueTuple<bool, object>>>.IndexOf
	|
	|-RVA: 0x2BA9470 Offset: 0x2BA9571 VA: 0x2BA9470
	|-ObjectEqualityComparer<ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>.IndexOf
	|
	|-RVA: 0x2BA9920 Offset: 0x2BA9A21 VA: 0x2BA9920
	|-ObjectEqualityComparer<ValueTuple<bool, UniTask<object>>>.IndexOf
	|
	|-RVA: 0x2BA9DD0 Offset: 0x2BA9ED1 VA: 0x2BA9DD0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>.IndexOf
	|
	|-RVA: 0x2BAA2A0 Offset: 0x2BAA3A1 VA: 0x2BAA2A0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>>.IndexOf
	|
	|-RVA: 0x2BAA790 Offset: 0x2BAA891 VA: 0x2BAA790
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>>>.IndexOf
	|
	|-RVA: 0x2BAAC30 Offset: 0x2BAAD31 VA: 0x2BAAC30
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>>>.IndexOf
	|
	|-RVA: 0x2BAB090 Offset: 0x2BAB191 VA: 0x2BAB090
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>>>.IndexOf
	|
	|-RVA: 0x2BAB580 Offset: 0x2BAB681 VA: 0x2BAB580
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>>>.IndexOf
	|
	|-RVA: 0x2BABA50 Offset: 0x2BABB51 VA: 0x2BABA50
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>>>.IndexOf
	|
	|-RVA: 0x2BABF20 Offset: 0x2BAC021 VA: 0x2BABF20
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>>>.IndexOf
	|
	|-RVA: 0x2BAC450 Offset: 0x2BAC551 VA: 0x2BAC450
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>>>.IndexOf
	|
	|-RVA: 0x3A56820 Offset: 0x3A56921 VA: 0x3A56820
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>>>.IndexOf
	|
	|-RVA: 0x3A56CF0 Offset: 0x3A56DF1 VA: 0x3A56CF0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>>>.IndexOf
	|
	|-RVA: 0x3A571F0 Offset: 0x3A572F1 VA: 0x3A571F0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>>>.IndexOf
	|
	|-RVA: 0x3A57700 Offset: 0x3A57801 VA: 0x3A57700
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>>>.IndexOf
	|
	|-RVA: 0x3A57C40 Offset: 0x3A57D41 VA: 0x3A57C40
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>>>.IndexOf
	|
	|-RVA: 0x3A58150 Offset: 0x3A58251 VA: 0x3A58150
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>>>.IndexOf
	|
	|-RVA: 0x3A58620 Offset: 0x3A58721 VA: 0x3A58620
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>>>.IndexOf
	|
	|-RVA: 0x3A58AC0 Offset: 0x3A58BC1 VA: 0x3A58AC0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>>>.IndexOf
	|
	|-RVA: 0x3A58F80 Offset: 0x3A59081 VA: 0x3A58F80
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>>>.IndexOf
	|
	|-RVA: 0x3A59450 Offset: 0x3A59551 VA: 0x3A59450
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>>>.IndexOf
	|
	|-RVA: 0x3A59930 Offset: 0x3A59A31 VA: 0x3A59930
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>>>.IndexOf
	|
	|-RVA: 0x3A59E60 Offset: 0x3A59F61 VA: 0x3A59E60
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>>>.IndexOf
	|
	|-RVA: 0x3A5A360 Offset: 0x3A5A461 VA: 0x3A5A360
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>>>.IndexOf
	|
	|-RVA: 0x3A5A890 Offset: 0x3A5A991 VA: 0x3A5A890
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>>>.IndexOf
	|
	|-RVA: 0x3A5ADF0 Offset: 0x3A5AEF1 VA: 0x3A5ADF0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>>>.IndexOf
	|
	|-RVA: 0x3A5B370 Offset: 0x3A5B471 VA: 0x3A5B370
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>>>.IndexOf
	|
	|-RVA: 0x3A5B910 Offset: 0x3A5BA11 VA: 0x3A5B910
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>>>.IndexOf
	|
	|-RVA: 0x3A5BEF0 Offset: 0x3A5BFF1 VA: 0x3A5BEF0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>>>.IndexOf
	|
	|-RVA: 0x3A5C420 Offset: 0x3A5C521 VA: 0x3A5C420
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>>.IndexOf
	|
	|-RVA: 0x3A5C890 Offset: 0x3A5C991 VA: 0x3A5C890
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>>.IndexOf
	|
	|-RVA: 0x3A5CD60 Offset: 0x3A5CE61 VA: 0x3A5CD60
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>>.IndexOf
	|
	|-RVA: 0x3A5D1F0 Offset: 0x3A5D2F1 VA: 0x3A5D1F0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>>.IndexOf
	|
	|-RVA: 0x3A5D6A0 Offset: 0x3A5D7A1 VA: 0x3A5D6A0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>>.IndexOf
	|
	|-RVA: 0x3A5DB70 Offset: 0x3A5DC71 VA: 0x3A5DB70
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>>.IndexOf
	|
	|-RVA: 0x3A5E040 Offset: 0x3A5E141 VA: 0x3A5E040
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>>.IndexOf
	|
	|-RVA: 0x3A5E510 Offset: 0x3A5E611 VA: 0x3A5E510
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>>.IndexOf
	|
	|-RVA: 0x3A5EA00 Offset: 0x3A5EB01 VA: 0x3A5EA00
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>>.IndexOf
	|
	|-RVA: 0x3A5EED0 Offset: 0x3A5EFD1 VA: 0x3A5EED0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>>.IndexOf
	|
	|-RVA: 0x3A5F380 Offset: 0x3A5F481 VA: 0x3A5F380
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>>.IndexOf
	|
	|-RVA: 0x3A5F830 Offset: 0x3A5F931 VA: 0x3A5F830
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>>.IndexOf
	|
	|-RVA: 0x3A5FD00 Offset: 0x3A5FE01 VA: 0x3A5FD00
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>>.IndexOf
	|
	|-RVA: 0x3A60190 Offset: 0x3A60291 VA: 0x3A60190
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>>.IndexOf
	|
	|-RVA: 0x3A60640 Offset: 0x3A60741 VA: 0x3A60640
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>>.IndexOf
	|
	|-RVA: 0x3A60B10 Offset: 0x3A60C11 VA: 0x3A60B10
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>>.IndexOf
	|
	|-RVA: 0x3A60FE0 Offset: 0x3A610E1 VA: 0x3A60FE0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>>.IndexOf
	|
	|-RVA: 0x3A614B0 Offset: 0x3A615B1 VA: 0x3A614B0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>>.IndexOf
	|
	|-RVA: 0x3A619A0 Offset: 0x3A61AA1 VA: 0x3A619A0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>>.IndexOf
	|
	|-RVA: 0x3A61EC0 Offset: 0x3A61FC1 VA: 0x3A61EC0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.IndexOf
	|
	|-RVA: 0x3A623F0 Offset: 0x3A624F1 VA: 0x3A623F0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>>.IndexOf
	|
	|-RVA: 0x3A62940 Offset: 0x3A62A41 VA: 0x3A62940
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.IndexOf
	|
	|-RVA: 0x3A62ED0 Offset: 0x3A62FD1 VA: 0x3A62ED0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>>.IndexOf
	|
	|-RVA: 0x3A63480 Offset: 0x3A63581 VA: 0x3A63480
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.IndexOf
	|
	|-RVA: 0x3A63A40 Offset: 0x3A63B41 VA: 0x3A63A40
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>>.IndexOf
	|
	|-RVA: 0x3A64010 Offset: 0x3A64111 VA: 0x3A64010
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.IndexOf
	|
	|-RVA: 0x3A64620 Offset: 0x3A64721 VA: 0x3A64620
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>>.IndexOf
	|
	|-RVA: 0x3A64C40 Offset: 0x3A64D41 VA: 0x3A64C40
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.IndexOf
	|
	|-RVA: 0x3A65280 Offset: 0x3A65381 VA: 0x3A65280
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>>.IndexOf
	|
	|-RVA: 0x3A65770 Offset: 0x3A65871 VA: 0x3A65770
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>.IndexOf
	|
	|-RVA: 0x3A65B80 Offset: 0x3A65C81 VA: 0x3A65B80
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>.IndexOf
	|
	|-RVA: 0x3A66010 Offset: 0x3A66111 VA: 0x3A66010
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>.IndexOf
	|
	|-RVA: 0x3A664D0 Offset: 0x3A665D1 VA: 0x3A664D0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>.IndexOf
	|
	|-RVA: 0x3A66950 Offset: 0x3A66A51 VA: 0x3A66950
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>.IndexOf
	|
	|-RVA: 0x3A66E20 Offset: 0x3A66F21 VA: 0x3A66E20
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>.IndexOf
	|
	|-RVA: 0x3A67290 Offset: 0x3A67391 VA: 0x3A67290
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>.IndexOf
	|
	|-RVA: 0x3A67700 Offset: 0x3A67801 VA: 0x3A67700
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>.IndexOf
	|
	|-RVA: 0x3A67BB0 Offset: 0x3A67CB1 VA: 0x3A67BB0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>.IndexOf
	|
	|-RVA: 0x3A68080 Offset: 0x3A68181 VA: 0x3A68080
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>.IndexOf
	|
	|-RVA: 0x3A68570 Offset: 0x3A68671 VA: 0x3A68570
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>.IndexOf
	|
	|-RVA: 0x3A68A00 Offset: 0x3A68B01 VA: 0x3A68A00
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>.IndexOf
	|
	|-RVA: 0x3A68E70 Offset: 0x3A68F71 VA: 0x3A68E70
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>.IndexOf
	|
	|-RVA: 0x3A692D0 Offset: 0x3A693D1 VA: 0x3A692D0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>.IndexOf
	|
	|-RVA: 0x3A69730 Offset: 0x3A69831 VA: 0x3A69730
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>.IndexOf
	|
	|-RVA: 0x3A69BE0 Offset: 0x3A69CE1 VA: 0x3A69BE0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>.IndexOf
	|
	|-RVA: 0x3A6A0B0 Offset: 0x3A6A1B1 VA: 0x3A6A0B0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>.IndexOf
	|
	|-RVA: 0x3A6A580 Offset: 0x3A6A681 VA: 0x3A6A580
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>.IndexOf
	|
	|-RVA: 0x3A6AA30 Offset: 0x3A6AB31 VA: 0x3A6AA30
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>.IndexOf
	|
	|-RVA: 0x3A6AF30 Offset: 0x3A6B031 VA: 0x3A6AF30
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.IndexOf
	|
	|-RVA: 0x3A6B460 Offset: 0x3A6B561 VA: 0x3A6B460
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>.IndexOf
	|
	|-RVA: 0x3A6B9A0 Offset: 0x3A6BAA1 VA: 0x3A6B9A0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.IndexOf
	|
	|-RVA: 0x3A6BEF0 Offset: 0x3A6BFF1 VA: 0x3A6BEF0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>.IndexOf
	|
	|-RVA: 0x3A6C470 Offset: 0x3A6C571 VA: 0x3A6C470
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.IndexOf
	|
	|-RVA: 0x3A6CA30 Offset: 0x3A6CB31 VA: 0x3A6CA30
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>.IndexOf
	|
	|-RVA: 0x3A6D000 Offset: 0x3A6D101 VA: 0x3A6D000
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.IndexOf
	|
	|-RVA: 0x3A6D5E0 Offset: 0x3A6D6E1 VA: 0x3A6D5E0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>.IndexOf
	|
	|-RVA: 0x3A6DBE0 Offset: 0x3A6DCE1 VA: 0x3A6DBE0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.IndexOf
	|
	|-RVA: 0x3A6E220 Offset: 0x3A6E321 VA: 0x3A6E220
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>.IndexOf
	|
	|-RVA: 0x3A6E770 Offset: 0x3A6E871 VA: 0x3A6E770
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>>>.IndexOf
	|
	|-RVA: 0x3A6EC40 Offset: 0x3A6ED41 VA: 0x3A6EC40
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.IndexOf
	|
	|-RVA: 0x3A6F0B0 Offset: 0x3A6F1B1 VA: 0x3A6F0B0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>.IndexOf
	|
	|-RVA: 0x3A6F520 Offset: 0x3A6F621 VA: 0x3A6F520
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, bool>>>.IndexOf
	|
	|-RVA: 0x3A6F9D0 Offset: 0x3A6FAD1 VA: 0x3A6F9D0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, Bounds>>>.IndexOf
	|
	|-RVA: 0x3A6FE40 Offset: 0x3A6FF41 VA: 0x3A6FE40
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, byte>>>.IndexOf
	|
	|-RVA: 0x3A702F0 Offset: 0x3A703F1 VA: 0x3A702F0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, Color>>>.IndexOf
	|
	|-RVA: 0x3A707A0 Offset: 0x3A708A1 VA: 0x3A707A0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, double>>>.IndexOf
	|
	|-RVA: 0x3C2F180 Offset: 0x3C2F281 VA: 0x3C2F180
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, int>>>.IndexOf
	|
	|-RVA: 0x3C2F620 Offset: 0x3C2F721 VA: 0x3C2F620
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, long>>>.IndexOf
	|
	|-RVA: 0x3C2FAD0 Offset: 0x3C2FBD1 VA: 0x3C2FAD0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, object>>>.IndexOf
	|
	|-RVA: 0x3C2FF80 Offset: 0x3C30081 VA: 0x3C2FF80
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, Quaternion>>>.IndexOf
	|
	|-RVA: 0x3C30430 Offset: 0x3C30531 VA: 0x3C30430
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, Rect>>>.IndexOf
	|
	|-RVA: 0x3C308B0 Offset: 0x3C309B1 VA: 0x3C308B0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, float>>>.IndexOf
	|
	|-RVA: 0x3C30D50 Offset: 0x3C30E51 VA: 0x3C30D50
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, UniTask>>>.IndexOf
	|
	|-RVA: 0x3C311C0 Offset: 0x3C312C1 VA: 0x3C311C0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, Unit>>>.IndexOf
	|
	|-RVA: 0x3C31630 Offset: 0x3C31731 VA: 0x3C31630
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, Vector2>>>.IndexOf
	|
	|-RVA: 0x3C31AA0 Offset: 0x3C31BA1 VA: 0x3C31AA0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, Vector3>>>.IndexOf
	|
	|-RVA: 0x3C31F50 Offset: 0x3C32051 VA: 0x3C31F50
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, Vector4>>>.IndexOf
	|
	|-RVA: 0x3C32400 Offset: 0x3C32501 VA: 0x3C32400
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<int, object>>>.IndexOf
	|
	|-RVA: 0x3C328B0 Offset: 0x3C329B1 VA: 0x3C328B0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<object, object>>>.IndexOf
	|
	|-RVA: 0x3C32D80 Offset: 0x3C32E81 VA: 0x3C32D80
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.IndexOf
	|
	|-RVA: 0x3C33260 Offset: 0x3C33361 VA: 0x3C33260
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<object, object, object>>>.IndexOf
	|
	|-RVA: 0x3C33760 Offset: 0x3C33861 VA: 0x3C33760
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.IndexOf
	|
	|-RVA: 0x3C33C90 Offset: 0x3C33D91 VA: 0x3C33C90
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<object, object, object, object>>>.IndexOf
	|
	|-RVA: 0x3C341D0 Offset: 0x3C342D1 VA: 0x3C341D0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.IndexOf
	|
	|-RVA: 0x3C34730 Offset: 0x3C34831 VA: 0x3C34730
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<object, object, object, object, object>>>.IndexOf
	|
	|-RVA: 0x3C34CB0 Offset: 0x3C34DB1 VA: 0x3C34CB0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.IndexOf
	|
	|-RVA: 0x3C35270 Offset: 0x3C35371 VA: 0x3C35270
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>.IndexOf
	|
	|-RVA: 0x3C35840 Offset: 0x3C35941 VA: 0x3C35840
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.IndexOf
	|
	|-RVA: 0x3C35E30 Offset: 0x3C35F31 VA: 0x3C35E30
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>.IndexOf
	|
	|-RVA: 0x3C36430 Offset: 0x3C36531 VA: 0x3C36430
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>>.IndexOf
	|
	|-RVA: 0x3C36A20 Offset: 0x3C36B21 VA: 0x3C36A20
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.IndexOf
	|
	|-RVA: 0x3C36E80 Offset: 0x3C36F81 VA: 0x3C36E80
	|-ObjectEqualityComparer<ValueTuple<bool, AsyncUnit>>.IndexOf
	|
	|-RVA: 0x3C37290 Offset: 0x3C37391 VA: 0x3C37290
	|-ObjectEqualityComparer<ValueTuple<bool, bool>>.IndexOf
	|
	|-RVA: 0x3C37710 Offset: 0x3C37811 VA: 0x3C37710
	|-ObjectEqualityComparer<ValueTuple<bool, Bounds>>.IndexOf
	|
	|-RVA: 0x3C37B90 Offset: 0x3C37C91 VA: 0x3C37B90
	|-ObjectEqualityComparer<ValueTuple<bool, byte>>.IndexOf
	|
	|-RVA: 0x3C37FF0 Offset: 0x3C380F1 VA: 0x3C37FF0
	|-ObjectEqualityComparer<ValueTuple<bool, Color>>.IndexOf
	|
	|-RVA: 0x3C38460 Offset: 0x3C38561 VA: 0x3C38460
	|-ObjectEqualityComparer<ValueTuple<bool, double>>.IndexOf
	|
	|-RVA: 0x3C38880 Offset: 0x3C38981 VA: 0x3C38880
	|-ObjectEqualityComparer<ValueTuple<bool, int>>.IndexOf
	|
	|-RVA: 0x3C38CA0 Offset: 0x3C38DA1 VA: 0x3C38CA0
	|-ObjectEqualityComparer<ValueTuple<bool, long>>.IndexOf
	|
	|-RVA: 0x3C390D0 Offset: 0x3C391D1 VA: 0x3C390D0
	|-ObjectEqualityComparer<ValueTuple<bool, object>>.IndexOf
	|
	|-RVA: 0x3C39540 Offset: 0x3C39641 VA: 0x3C39540
	|-ObjectEqualityComparer<ValueTuple<bool, Quaternion>>.IndexOf
	|
	|-RVA: 0x3C399F0 Offset: 0x3C39AF1 VA: 0x3C399F0
	|-ObjectEqualityComparer<ValueTuple<bool, Rect>>.IndexOf
	|
	|-RVA: 0x3C39E50 Offset: 0x3C39F51 VA: 0x3C39E50
	|-ObjectEqualityComparer<ValueTuple<bool, float>>.IndexOf
	|
	|-RVA: 0x3C3A270 Offset: 0x3C3A371 VA: 0x3C3A270
	|-ObjectEqualityComparer<ValueTuple<bool, UniTask>>.IndexOf
	|
	|-RVA: 0x3C3A690 Offset: 0x3C3A791 VA: 0x3C3A690
	|-ObjectEqualityComparer<ValueTuple<bool, Unit>>.IndexOf
	|
	|-RVA: 0x3C3AAC0 Offset: 0x3C3ABC1 VA: 0x3C3AAC0
	|-ObjectEqualityComparer<ValueTuple<bool, Vector2>>.IndexOf
	|
	|-RVA: 0x3C3AF20 Offset: 0x3C3B021 VA: 0x3C3AF20
	|-ObjectEqualityComparer<ValueTuple<bool, Vector3>>.IndexOf
	|
	|-RVA: 0x3C3B390 Offset: 0x3C3B491 VA: 0x3C3B390
	|-ObjectEqualityComparer<ValueTuple<bool, Vector4>>.IndexOf
	|
	|-RVA: 0x3C3B800 Offset: 0x3C3B901 VA: 0x3C3B800
	|-ObjectEqualityComparer<ValueTuple<int, object>>.IndexOf
	|
	|-RVA: 0x3C3BC10 Offset: 0x3C3BD11 VA: 0x3C3BC10
	|-ObjectEqualityComparer<ValueTuple<Int32Enum, int>>.IndexOf
	|
	|-RVA: 0x3C3C070 Offset: 0x3C3C171 VA: 0x3C3C070
	|-ObjectEqualityComparer<ValueTuple<object, ValueTuple<object, int>>>.IndexOf
	|
	|-RVA: 0x3C3C4D0 Offset: 0x3C3C5D1 VA: 0x3C3C4D0
	|-ObjectEqualityComparer<ValueTuple<object, int>>.IndexOf
	|
	|-RVA: 0x3C3C8F0 Offset: 0x3C3C9F1 VA: 0x3C3C8F0
	|-ObjectEqualityComparer<ValueTuple<object, object>>.IndexOf
	|
	|-RVA: 0x3C3CD10 Offset: 0x3C3CE11 VA: 0x3C3CD10
	|-ObjectEqualityComparer<ValueTuple<object, float>>.IndexOf
	|
	|-RVA: 0x3C3D160 Offset: 0x3C3D261 VA: 0x3C3D160
	|-ObjectEqualityComparer<ValueTuple<Vector3, float>>.IndexOf
	|
	|-RVA: 0x3C3D630 Offset: 0x3C3D731 VA: 0x3C3D630
	|-ObjectEqualityComparer<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>.IndexOf
	|
	|-RVA: 0x3C3DAC0 Offset: 0x3C3DBC1 VA: 0x3C3DAC0
	|-ObjectEqualityComparer<ValueTuple<object, Int32Enum, int>>.IndexOf
	|
	|-RVA: 0x3C3DF20 Offset: 0x3C3E021 VA: 0x3C3DF20
	|-ObjectEqualityComparer<ValueTuple<object, object, object>>.IndexOf
	|
	|-RVA: 0x3C3E410 Offset: 0x3C3E511 VA: 0x3C3E410
	|-ObjectEqualityComparer<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.IndexOf
	|
	|-RVA: 0x3C3E910 Offset: 0x3C3EA11 VA: 0x3C3E910
	|-ObjectEqualityComparer<ValueTuple<object, int, int, int>>.IndexOf
	|
	|-RVA: 0x3C3EDB0 Offset: 0x3C3EEB1 VA: 0x3C3EDB0
	|-ObjectEqualityComparer<ValueTuple<object, object, object, object>>.IndexOf
	|
	|-RVA: 0x3C3F2D0 Offset: 0x3C3F3D1 VA: 0x3C3F2D0
	|-ObjectEqualityComparer<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.IndexOf
	|
	|-RVA: 0x3C3F820 Offset: 0x3C3F921 VA: 0x3C3F820
	|-ObjectEqualityComparer<ValueTuple<object, object, object, object, object>>.IndexOf
	|
	|-RVA: 0x3C3FD90 Offset: 0x3C3FE91 VA: 0x3C3FD90
	|-ObjectEqualityComparer<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.IndexOf
	|
	|-RVA: 0x3C40310 Offset: 0x3C40411 VA: 0x3C40310
	|-ObjectEqualityComparer<ValueTuple<object, object, object, object, object, object>>.IndexOf
	|
	|-RVA: 0x3C408A0 Offset: 0x3C409A1 VA: 0x3C408A0
	|-ObjectEqualityComparer<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.IndexOf
	|
	|-RVA: 0x3C40E80 Offset: 0x3C40F81 VA: 0x3C40E80
	|-ObjectEqualityComparer<ValueTuple<object, object, object, object, object, object, object>>.IndexOf
	|
	|-RVA: 0x3C41470 Offset: 0x3C41571 VA: 0x3C41470
	|-ObjectEqualityComparer<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>.IndexOf
	|
	|-RVA: 0x3C41A50 Offset: 0x3C41B51 VA: 0x3C41A50
	|-ObjectEqualityComparer<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>.IndexOf
	|
	|-RVA: 0x3C41ED0 Offset: 0x3C41FD1 VA: 0x3C41ED0
	|-ObjectEqualityComparer<AnimatorClipInfo>.IndexOf
	|
	|-RVA: 0x3C422E0 Offset: 0x3C423E1 VA: 0x3C422E0
	|-ObjectEqualityComparer<AsyncOperationHandle>.IndexOf
	|
	|-RVA: 0x3C42730 Offset: 0x3C42831 VA: 0x3C42730
	|-ObjectEqualityComparer<AsyncUnit>.IndexOf
	|
	|-RVA: 0x3C42AE0 Offset: 0x3C42BE1 VA: 0x3C42AE0
	|-ObjectEqualityComparer<BoneWeight>.IndexOf
	|
	|-RVA: 0x3C42E10 Offset: 0x3C42F11 VA: 0x3C42E10
	|-ObjectEqualityComparer<bool>.IndexOf
	|
	|-RVA: 0x3C43100 Offset: 0x3C43201 VA: 0x3C43100
	|-ObjectEqualityComparer<Bounds>.IndexOf
	|
	|-RVA: 0x3C43420 Offset: 0x3C43521 VA: 0x3C43420
	|-ObjectEqualityComparer<byte>.IndexOf
	|
	|-RVA: 0x3C437C0 Offset: 0x3C438C1 VA: 0x3C437C0
	|-ObjectEqualityComparer<CameraInfo>.IndexOf
	|
	|-RVA: 0x3C43BA0 Offset: 0x3C43CA1 VA: 0x3C43BA0
	|-ObjectEqualityComparer<CancellationToken>.IndexOf
	|
	|-RVA: 0x3C43E90 Offset: 0x3C43F91 VA: 0x3C43E90
	|-ObjectEqualityComparer<CancellationTokenRegistration>.IndexOf
	|
	|-RVA: 0x3C441B0 Offset: 0x3C442B1 VA: 0x3C441B0
	|-ObjectEqualityComparer<char>.IndexOf
	|
	|-RVA: 0x3C444C0 Offset: 0x3C445C1 VA: 0x3C444C0
	|-ObjectEqualityComparer<Color>.IndexOf
	|
	|-RVA: 0x3C448A0 Offset: 0x3C449A1 VA: 0x3C448A0
	|-ObjectEqualityComparer<Color32>.IndexOf
	|
	|-RVA: 0x3C44C70 Offset: 0x3C44D71 VA: 0x3C44C70
	|-ObjectEqualityComparer<ColorBlock>.IndexOf
	|
	|-RVA: 0x3C45070 Offset: 0x3C45171 VA: 0x3C45070
	|-ObjectEqualityComparer<ConstraintSource>.IndexOf
	|
	|-RVA: 0x3C45510 Offset: 0x3C45611 VA: 0x3C45510
	|-ObjectEqualityComparer<ContourVertex>.IndexOf
	|
	|-RVA: 0x3C459E0 Offset: 0x3C45AE1 VA: 0x3C459E0
	|-ObjectEqualityComparer<DataStoreRatingInfo>.IndexOf
	|
	|-RVA: 0x3C45E80 Offset: 0x3C45F81 VA: 0x3C45E80
	|-ObjectEqualityComparer<DataStoreResult>.IndexOf
	|
	|-RVA: 0x3C46250 Offset: 0x3C46351 VA: 0x3C46250
	|-ObjectEqualityComparer<DateTime>.IndexOf
	|
	|-RVA: 0x3C46560 Offset: 0x3C46661 VA: 0x3C46560
	|-ObjectEqualityComparer<DateTimeOffset>.IndexOf
	|
	|-RVA: 0x3C46890 Offset: 0x3C46991 VA: 0x3C46890
	|-ObjectEqualityComparer<Decimal>.IndexOf
	|
	|-RVA: 0x3C46C90 Offset: 0x3C46D91 VA: 0x3C46C90
	|-ObjectEqualityComparer<DiagnosticEvent>.IndexOf
	|
	|-RVA: 0x3C470C0 Offset: 0x3C471C1 VA: 0x3C470C0
	|-ObjectEqualityComparer<double>.IndexOf
	|
	|-RVA: 0x3C473E0 Offset: 0x3C474E1 VA: 0x3C473E0
	|-ObjectEqualityComparer<FXZ>.IndexOf
	|
	|-RVA: 0x3C477D0 Offset: 0x3C478D1 VA: 0x3C477D0
	|-ObjectEqualityComparer<Friend>.IndexOf
	|
	|-RVA: 0x3C47BE0 Offset: 0x3C47CE1 VA: 0x3C47BE0
	|-ObjectEqualityComparer<GlyphRect>.IndexOf
	|
	|-RVA: 0x3C47F10 Offset: 0x3C48011 VA: 0x3C47F10
	|-ObjectEqualityComparer<Guid>.IndexOf
	|
	|-RVA: 0x3C48230 Offset: 0x3C48331 VA: 0x3C48230
	|-ObjectEqualityComparer<short>.IndexOf
	|
	|-RVA: 0x3C48530 Offset: 0x3C48631 VA: 0x3C48530
	|-ObjectEqualityComparer<int>.IndexOf
	|
	|-RVA: 0x3C488A0 Offset: 0x3C489A1 VA: 0x3C488A0
	|-ObjectEqualityComparer<Int32Enum>.IndexOf
	|
	|-RVA: 0x3C48C30 Offset: 0x3C48D31 VA: 0x3C48C30
	|-ObjectEqualityComparer<long>.IndexOf
	|
	|-RVA: 0x3C48FA0 Offset: 0x3C490A1 VA: 0x3C48FA0
	|-ObjectEqualityComparer<Int64Enum>.IndexOf
	|
	|-RVA: 0x3C49330 Offset: 0x3C49431 VA: 0x3C49330
	|-ObjectEqualityComparer<IntPtr>.IndexOf
	|
	|-RVA: 0x3C496D0 Offset: 0x3C497D1 VA: 0x3C496D0
	|-ObjectEqualityComparer<InterpretedFrameInfo>.IndexOf
	|
	|-RVA: 0x3C49B70 Offset: 0x3C49C71 VA: 0x3C49B70
	|-ObjectEqualityComparer<IntervalTreeNode>.IndexOf
	|
	|-RVA: 0x3C4A010 Offset: 0x3C4A111 VA: 0x3C4A010
	|-ObjectEqualityComparer<LayerMask>.IndexOf
	|
	|-RVA: 0x3C4A470 Offset: 0x3C4A571 VA: 0x3C4A470
	|-ObjectEqualityComparer<LengthLimitProperties>.IndexOf
	|
	|-RVA: 0x3C4A840 Offset: 0x3C4A941 VA: 0x3C4A840
	|-ObjectEqualityComparer<MapPos>.IndexOf
	|
	|-RVA: 0x3C4AB40 Offset: 0x3C4AC41 VA: 0x3C4AB40
	|-ObjectEqualityComparer<Matrix4x4>.IndexOf
	|
	|-RVA: 0x3C4AF60 Offset: 0x3C4B061 VA: 0x3C4AF60
	|-ObjectEqualityComparer<Navigation>.IndexOf
	|
	|-RVA: 0x3C4B350 Offset: 0x3C4B451 VA: 0x3C4B350
	|-ObjectEqualityComparer<object>.IndexOf
	|
	|-RVA: 0x3C4B730 Offset: 0x3C4B831 VA: 0x3C4B730
	|-ObjectEqualityComparer<ObjectInitializationData>.IndexOf
	|
	|-RVA: 0x3C4BBF0 Offset: 0x3C4BCF1 VA: 0x3C4BBF0
	|-ObjectEqualityComparer<Playable>.IndexOf
	|
	|-RVA: 0x3C4C090 Offset: 0x3C4C191 VA: 0x3C4C090
	|-ObjectEqualityComparer<PlayableBinding>.IndexOf
	|
	|-RVA: 0x3C4C570 Offset: 0x3C4C671 VA: 0x3C4C570
	|-ObjectEqualityComparer<PlayerLoopSystem>.IndexOf
	|
	|-RVA: 0x3C4CA70 Offset: 0x3C4CB71 VA: 0x3C4CA70
	|-ObjectEqualityComparer<PlayerLoopSystemInternal>.IndexOf
	|
	|-RVA: 0x3C4CEA0 Offset: 0x3C4CFA1 VA: 0x3C4CEA0
	|-ObjectEqualityComparer<Quaternion>.IndexOf
	|
	|-RVA: 0x3C4D280 Offset: 0x3C4D381 VA: 0x3C4D280
	|-ObjectEqualityComparer<RandomSeed>.IndexOf
	|
	|-RVA: 0x3C4D6F0 Offset: 0x3C4D7F1 VA: 0x3C4D6F0
	|-ObjectEqualityComparer<RangePositionInfo>.IndexOf
	|
	|-RVA: 0x3C4DB60 Offset: 0x3C4DC61 VA: 0x3C4DB60
	|-ObjectEqualityComparer<Ranking2ChartInfoInput>.IndexOf
	|
	|-RVA: 0x3C4E020 Offset: 0x3C4E121 VA: 0x3C4E020
	|-ObjectEqualityComparer<RaycastHit2D>.IndexOf
	|
	|-RVA: 0x3C4E570 Offset: 0x3C4E671 VA: 0x3C4E570
	|-ObjectEqualityComparer<RaycastResult>.IndexOf
	|
	|-RVA: 0x3C4E9E0 Offset: 0x3C4EAE1 VA: 0x3C4E9E0
	|-ObjectEqualityComparer<Rect>.IndexOf
	|
	|-RVA: 0x3C4EDC0 Offset: 0x3C4EEC1 VA: 0x3C4EDC0
	|-ObjectEqualityComparer<RendererListHandle>.IndexOf
	|
	|-RVA: 0x3C4F220 Offset: 0x3C4F321 VA: 0x3C4F220
	|-ObjectEqualityComparer<ResourceHandle>.IndexOf
	|
	|-RVA: 0x3C4F680 Offset: 0x3C4F781 VA: 0x3C4F680
	|-ObjectEqualityComparer<ResourceLocator>.IndexOf
	|
	|-RVA: 0x3C4FA50 Offset: 0x3C4FB51 VA: 0x3C4FA50
	|-ObjectEqualityComparer<sbyte>.IndexOf
	|
	|-RVA: 0x3C4FD60 Offset: 0x3C4FE61 VA: 0x3C4FD60
	|-ObjectEqualityComparer<ShaderTagId>.IndexOf
	|
	|-RVA: 0x3C50060 Offset: 0x3C50161 VA: 0x3C50060
	|-ObjectEqualityComparer<float>.IndexOf
	|
	|-RVA: 0x3C50390 Offset: 0x3C50491 VA: 0x3C50390
	|-ObjectEqualityComparer<SphericalHarmonicsL2>.IndexOf
	|
	|-RVA: 0x3C507E0 Offset: 0x3C508E1 VA: 0x3C507E0
	|-ObjectEqualityComparer<SpriteState>.IndexOf
	|
	|-RVA: 0x3C50CC0 Offset: 0x3C50DC1 VA: 0x3C50CC0
	|-ObjectEqualityComparer<SubMeshDescriptor>.IndexOf
	|
	|-RVA: 0x3C51180 Offset: 0x3C51281 VA: 0x3C51180
	|-ObjectEqualityComparer<TablePair>.IndexOf
	|
	|-RVA: 0x3C51560 Offset: 0x3C51661 VA: 0x3C51560
	|-ObjectEqualityComparer<TimeSpan>.IndexOf
	|
	|-RVA: 0x3C51910 Offset: 0x3C51A11 VA: 0x3C51910
	|-ObjectEqualityComparer<UICharInfo>.IndexOf
	|
	|-RVA: 0x3C51DC0 Offset: 0x3C51EC1 VA: 0x3C51DC0
	|-ObjectEqualityComparer<UILineInfo>.IndexOf
	|
	|-RVA: 0x3C522F0 Offset: 0x3C523F1 VA: 0x3C522F0
	|-ObjectEqualityComparer<UIVertex>.IndexOf
	|
	|-RVA: 0x3C527B0 Offset: 0x3C528B1 VA: 0x3C527B0
	|-ObjectEqualityComparer<ushort>.IndexOf
	|
	|-RVA: 0x3C52AB0 Offset: 0x3C52BB1 VA: 0x3C52AB0
	|-ObjectEqualityComparer<uint>.IndexOf
	|
	|-RVA: 0x3C52DC0 Offset: 0x3C52EC1 VA: 0x3C52DC0
	|-ObjectEqualityComparer<ulong>.IndexOf
	|
	|-RVA: 0x3C53110 Offset: 0x3C53211 VA: 0x3C53110
	|-ObjectEqualityComparer<UniTask>.IndexOf
	|
	|-RVA: 0x3C534E0 Offset: 0x3C535E1 VA: 0x3C534E0
	|-ObjectEqualityComparer<Unit>.IndexOf
	|
	|-RVA: 0x3C537F0 Offset: 0x3C538F1 VA: 0x3C537F0
	|-ObjectEqualityComparer<Vector2>.IndexOf
	|
	|-RVA: 0x3C53B10 Offset: 0x3C53C11 VA: 0x3C53B10
	|-ObjectEqualityComparer<Vector3>.IndexOf
	|
	|-RVA: 0x3C53E70 Offset: 0x3C53F71 VA: 0x3C53E70
	|-ObjectEqualityComparer<Vector4>.IndexOf
	|
	|-RVA: 0x3C541C0 Offset: 0x3C542C1 VA: 0x3C541C0
	|-ObjectEqualityComparer<VertexAttributeDescriptor>.IndexOf
	|
	|-RVA: 0x3C54580 Offset: 0x3C54681 VA: 0x3C54580
	|-ObjectEqualityComparer<X509ChainStatus>.IndexOf
	|
	|-RVA: 0x3C549A0 Offset: 0x3C54AA1 VA: 0x3C549A0
	|-ObjectEqualityComparer<XPathNodeRef>.IndexOf
	|
	|-RVA: 0x3C54E50 Offset: 0x3C54F51 VA: 0x3C54E50
	|-ObjectEqualityComparer<XRView>.IndexOf
	|
	|-RVA: 0x3C552F0 Offset: 0x3C553F1 VA: 0x3C552F0
	|-ObjectEqualityComparer<AmiiboSequence.GainItemData>.IndexOf
	|
	|-RVA: 0x3C557A0 Offset: 0x3C558A1 VA: 0x3C557A0
	|-ObjectEqualityComparer<AnimationOutputWeightProcessor.WeightInfo>.IndexOf
	|
	|-RVA: 0x3C55C60 Offset: 0x3C55D61 VA: 0x3C55C60
	|-ObjectEqualityComparer<ArenaOrderSequence.GodInfo>.IndexOf
	|
	|-RVA: 0x3C560D0 Offset: 0x3C561D1 VA: 0x3C560D0
	|-ObjectEqualityComparer<BattleInfo.SupportData>.IndexOf
	|
	|-RVA: 0x3C56540 Offset: 0x3C56641 VA: 0x3C56540
	|-ObjectEqualityComparer<BeforeRenderHelper.OrderBlock>.IndexOf
	|
	|-RVA: 0x3C569E0 Offset: 0x3C56AE1 VA: 0x3C569E0
	|-ObjectEqualityComparer<Camera.RenderRequest>.IndexOf
	|
	|-RVA: 0x3C56E80 Offset: 0x3C56F81 VA: 0x3C56E80
	|-ObjectEqualityComparer<CameraState.CustomBlendable>.IndexOf
	|
	|-RVA: 0x3C572F0 Offset: 0x3C573F1 VA: 0x3C572F0
	|-ObjectEqualityComparer<CinemachineClearShot.Pair>.IndexOf
	|
	|-RVA: 0x3C57750 Offset: 0x3C57851 VA: 0x3C57750
	|-ObjectEqualityComparer<CinemachineStateDrivenCamera.HashPair>.IndexOf
	|
	|-RVA: 0x3C57BE0 Offset: 0x3C57CE1 VA: 0x3C57BE0
	|-ObjectEqualityComparer<DelayedActionManager.DelegateInfo>.IndexOf
	|
	|-RVA: 0x3C580C0 Offset: 0x3C581C1 VA: 0x3C580C0
	|-ObjectEqualityComparer<Detail.AsyncResultInt>.IndexOf
	|
	|-RVA: 0x3C58580 Offset: 0x3C58681 VA: 0x3C58580
	|-ObjectEqualityComparer<Detail.CppArray>.IndexOf
	|
	|-RVA: 0x3C58A30 Offset: 0x3C58B31 VA: 0x3C58A30
	|-ObjectEqualityComparer<Detail.NotificationEventInt>.IndexOf
	|
	|-RVA: 0x3C58EF0 Offset: 0x3C58FF1 VA: 0x3C58EF0
	|-ObjectEqualityComparer<DragonRideTargetGroup.ChainParam>.IndexOf
	|
	|-RVA: 0x3C59360 Offset: 0x3C59461 VA: 0x3C59360
	|-ObjectEqualityComparer<DynamicMesh.State>.IndexOf
	|
	|-RVA: 0x3C597C0 Offset: 0x3C598C1 VA: 0x3C597C0
	|-ObjectEqualityComparer<GameVariable.Value>.IndexOf
	|
	|-RVA: 0x3C59C60 Offset: 0x3C59D61 VA: 0x3C59C60
	|-ObjectEqualityComparer<GmapPathAdjuster.TargetModel>.IndexOf
	|
	|-RVA: 0x3C5A130 Offset: 0x3C5A231 VA: 0x3C5A130
	|-ObjectEqualityComparer<GmapSpotAdjuster.TargetModel>.IndexOf
	|
	|-RVA: 0x3C5A600 Offset: 0x3C5A701 VA: 0x3C5A600
	|-ObjectEqualityComparer<HubFastTravel.Location>.IndexOf
	|
	|-RVA: 0x3C5AAE0 Offset: 0x3C5ABE1 VA: 0x3C5AAE0
	|-ObjectEqualityComparer<HubLensFlare.Flare>.IndexOf
	|
	|-RVA: 0x3C5AFA0 Offset: 0x3C5B0A1 VA: 0x3C5AFA0
	|-ObjectEqualityComparer<InventoryPoolItemMenuContent.KindBgNameClass>.IndexOf
	|
	|-RVA: 0x3C5B410 Offset: 0x3C5B511 VA: 0x3C5B410
	|-ObjectEqualityComparer<Map.Pos>.IndexOf
	|
	|-RVA: 0x3C5B870 Offset: 0x3C5B971 VA: 0x3C5B870
	|-ObjectEqualityComparer<MapImage.BackupTerrain>.IndexOf
	|
	|-RVA: 0x3C5BCE0 Offset: 0x3C5BDE1 VA: 0x3C5BCE0
	|-ObjectEqualityComparer<MapImageRange.Pos>.IndexOf
	|
	|-RVA: 0x3C5C1B0 Offset: 0x3C5C2B1 VA: 0x3C5C1B0
	|-ObjectEqualityComparer<MapMind.Record>.IndexOf
	|
	|-RVA: 0x3C5C6E0 Offset: 0x3C5C7E1 VA: 0x3C5C6E0
	|-ObjectEqualityComparer<MapMind.Target>.IndexOf
	|
	|-RVA: 0x36FCF40 Offset: 0x36FD041 VA: 0x36FCF40
	|-ObjectEqualityComparer<MapPanelDebug.Entity>.IndexOf
	|
	|-RVA: 0x36FD3E0 Offset: 0x36FD4E1 VA: 0x36FD3E0
	|-ObjectEqualityComparer<NexRanking.Data>.IndexOf
	|
	|-RVA: 0x36FD840 Offset: 0x36FD941 VA: 0x36FD840
	|-ObjectEqualityComparer<NexVersus.RatingData>.IndexOf
	|
	|-RVA: 0x36FDCB0 Offset: 0x36FDDB1 VA: 0x36FDCB0
	|-ObjectEqualityComparer<PackedPlayModeBuildLogs.RuntimeBuildLog>.IndexOf
	|
	|-RVA: 0x36FE160 Offset: 0x36FE261 VA: 0x36FE160
	|-ObjectEqualityComparer<ParticleSystem.Particle>.IndexOf
	|
	|-RVA: 0x36FE640 Offset: 0x36FE741 VA: 0x36FE640
	|-ObjectEqualityComparer<QualitySettingsStack.Settings>.IndexOf
	|
	|-RVA: 0x36FEB00 Offset: 0x36FEC01 VA: 0x36FEB00
	|-ObjectEqualityComparer<RangeData.Offset>.IndexOf
	|
	|-RVA: 0x36FEF90 Offset: 0x36FF091 VA: 0x36FEF90
	|-ObjectEqualityComparer<RenderGraphDebugData.PassDebugData>.IndexOf
	|
	|-RVA: 0x36FF470 Offset: 0x36FF571 VA: 0x36FF470
	|-ObjectEqualityComparer<RenderGraphDebugData.ResourceDebugData>.IndexOf
	|
	|-RVA: 0x36FF930 Offset: 0x36FFA31 VA: 0x36FF930
	|-ObjectEqualityComparer<RingCleaningUnitSelectMenu.GodParam>.IndexOf
	|
	|-RVA: 0x36FFDE0 Offset: 0x36FFEE1 VA: 0x36FFDE0
	|-ObjectEqualityComparer<SequenceNode.SequenceConstructPosContext>.IndexOf
	|
	|-RVA: 0x37002E0 Offset: 0x37003E1 VA: 0x37002E0
	|-ObjectEqualityComparer<ShadowUtility.Edge>.IndexOf
	|
	|-RVA: 0x37007A0 Offset: 0x37008A1 VA: 0x37007A0
	|-ObjectEqualityComparer<SimpleAnimationPlayable.QueuedState>.IndexOf
	|
	|-RVA: 0x3700C10 Offset: 0x3700D11 VA: 0x3700C10
	|-ObjectEqualityComparer<SkillArray.Entity>.IndexOf
	|
	|-RVA: 0x3701080 Offset: 0x3701181 VA: 0x3701080
	|-ObjectEqualityComparer<Stream.Info>.IndexOf
	|
	|-RVA: 0x3701560 Offset: 0x3701661 VA: 0x3701560
	|-ObjectEqualityComparer<TexturePacker_JsonArray.Frame>.IndexOf
	|
	|-RVA: 0x3701A70 Offset: 0x3701B71 VA: 0x3701A70
	|-ObjectEqualityComparer<TimeNotificationBehaviour.NotificationEntry>.IndexOf
	|
	|-RVA: 0x3701F40 Offset: 0x3702041 VA: 0x3701F40
	|-ObjectEqualityComparer<UnitySynchronizationContext.WorkRequest>.IndexOf
	|
	|-RVA: 0x37023E0 Offset: 0x37024E1 VA: 0x37023E0
	|-ObjectEqualityComparer<XmlSchemaObjectTable.XmlSchemaObjectEntry>.IndexOf
	|
	|-RVA: 0x3702850 Offset: 0x3702951 VA: 0x3702850
	|-ObjectEqualityComparer<AIThink.EnchantThink.SurroundingInfo>.IndexOf
	|
	|-RVA: 0x3702CB0 Offset: 0x3702DB1 VA: 0x3702CB0
	|-ObjectEqualityComparer<AssetBundleBuildMap.AssetBundleEntry.AssetPathString>.IndexOf
	|
	|-RVA: 0x3703160 Offset: 0x3703261 VA: 0x3703160
	|-ObjectEqualityComparer<Detail.DataStore.DataStoreChangeMetaParamInt>.IndexOf
	|
	|-RVA: 0x3703600 Offset: 0x3703701 VA: 0x3703600
	|-ObjectEqualityComparer<Detail.DataStore.DataStoreDeleteParamInt>.IndexOf
	|
	|-RVA: 0x3703AB0 Offset: 0x3703BB1 VA: 0x3703AB0
	|-ObjectEqualityComparer<Detail.DataStore.DataStoreGetMetaParamInt>.IndexOf
	|
	|-RVA: 0x3703FB0 Offset: 0x37040B1 VA: 0x3703FB0
	|-ObjectEqualityComparer<Detail.DataStore.DataStoreMetaInfoInt>.IndexOf
	|
	|-RVA: 0x3704480 Offset: 0x3704581 VA: 0x3704480
	|-ObjectEqualityComparer<Detail.DataStore.DataStorePasswordInfoInt>.IndexOf
	|
	|-RVA: 0x3704950 Offset: 0x3704A51 VA: 0x3704950
	|-ObjectEqualityComparer<Detail.DataStore.DataStorePersistenceInfoInt>.IndexOf
	|
	|-RVA: 0x3704E30 Offset: 0x3704F31 VA: 0x3704E30
	|-ObjectEqualityComparer<Detail.DataStore.DataStorePreparePostParamInt>.IndexOf
	|
	|-RVA: 0x37052D0 Offset: 0x37053D1 VA: 0x37052D0
	|-ObjectEqualityComparer<Detail.DataStore.DataStoreRateObjectParamInt>.IndexOf
	|
	|-RVA: 0x3705770 Offset: 0x3705871 VA: 0x3705770
	|-ObjectEqualityComparer<Detail.DataStore.DataStoreRatingInitParamInt>.IndexOf
	|
	|-RVA: 0x3705C10 Offset: 0x3705D11 VA: 0x3705C10
	|-ObjectEqualityComparer<Detail.DataStore.DataStoreRatingTargetInt>.IndexOf
	|
	|-RVA: 0x37060E0 Offset: 0x37061E1 VA: 0x37060E0
	|-ObjectEqualityComparer<Detail.Ranking.RankingCachedResultInt>.IndexOf
	|
	|-RVA: 0x37065C0 Offset: 0x37066C1 VA: 0x37065C0
	|-ObjectEqualityComparer<Detail.Ranking.RankingOrderParamInt>.IndexOf
	|
	|-RVA: 0x3706A90 Offset: 0x3706B91 VA: 0x3706A90
	|-ObjectEqualityComparer<Detail.Ranking.RankingRankDataInt>.IndexOf
	|
	|-RVA: 0x3707000 Offset: 0x3707101 VA: 0x3707000
	|-ObjectEqualityComparer<Detail.Ranking2.Ranking2ChartInfoInt>.IndexOf
	|
	|-RVA: 0x3707580 Offset: 0x3707681 VA: 0x3707580
	|-ObjectEqualityComparer<Detail.Ranking2.Ranking2RankDataInt>.IndexOf
	|
	|-RVA: 0x3707A60 Offset: 0x3707B61 VA: 0x3707A60
	|-ObjectEqualityComparer<Detail.Ranking2.Ranking2ScoreDataInt>.IndexOf
	|
	|-RVA: 0x3707F00 Offset: 0x3708001 VA: 0x3707F00
	|-ObjectEqualityComparer<Detail.Screening.ScreeningContextInfoInt>.IndexOf
	|
	|-RVA: 0x3708410 Offset: 0x3708511 VA: 0x3708410
	|-ObjectEqualityComparer<Detail.Subscriber.SubscriberContentInt>.IndexOf
	|
	|-RVA: 0x3708940 Offset: 0x3708A41 VA: 0x3708940
	|-ObjectEqualityComparer<Detail.Subscriber.SubscriberGetContentParamInt>.IndexOf
	|
	|-RVA: 0x3708E20 Offset: 0x3708F21 VA: 0x3708E20
	|-ObjectEqualityComparer<Detail.Subscriber.SubscriberUserStatusInfoInt>.IndexOf
	|
	|-RVA: 0x3709310 Offset: 0x3709411 VA: 0x3709310
	|-ObjectEqualityComparer<Detail.Subscriber.SubscriberUserStatusParamInt>.IndexOf
	|
	|-RVA: 0x37097B0 Offset: 0x37098B1 VA: 0x37097B0
	|-ObjectEqualityComparer<Detail.Utility.IntegerSettings>.IndexOf
	|
	|-RVA: 0x3709C10 Offset: 0x3709D11 VA: 0x3709C10
	|-ObjectEqualityComparer<Detail.Utility.UniqueIdInfoInt>.IndexOf
	|
	|-RVA: 0x370A090 Offset: 0x370A191 VA: 0x370A090
	|-ObjectEqualityComparer<MapHistory.Rewind.LatestInspectorData>.IndexOf
	|
	|-RVA: 0x370A540 Offset: 0x370A641 VA: 0x370A540
	|-ObjectEqualityComparer<MapHistory.Rewind.WorkTerrainData>.IndexOf
	|
	|-RVA: 0x370A9E0 Offset: 0x370AAE1 VA: 0x370A9E0
	|-ObjectEqualityComparer<MapSkill.AroundCalculator.Result>.IndexOf
	|
	|-RVA: 0x370AE90 Offset: 0x370AF91 VA: 0x370AE90
	|-ObjectEqualityComparer<TargetPositionCache.CacheCurve.Item>.IndexOf
	|
	|-RVA: 0x370B3B0 Offset: 0x370B4B1 VA: 0x370B3B0
	|-ObjectEqualityComparer<TargetPositionCache.CacheEntry.RecordingItem>.IndexOf
	|
	|-RVA: 0x370B890 Offset: 0x370B991 VA: 0x370B890
	|-ObjectEqualityComparer<TerrainUtility.TerrainMap.TileCoord>.IndexOf
	*/

	// RVA: -1 Offset: -1 Slot: 11
	internal override int LastIndexOf(T[] array, T value, int startIndex, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BA5F90 Offset: 0x2BA6091 VA: 0x2BA5F90
	|-ObjectEqualityComparer<AsyncOperationHandle<object>>.LastIndexOf
	|
	|-RVA: 0x2BA6460 Offset: 0x2BA6561 VA: 0x2BA6460
	|-ObjectEqualityComparer<IntervalTree.Entry<object>>.LastIndexOf
	|
	|-RVA: 0x2BA68E0 Offset: 0x2BA69E1 VA: 0x2BA68E0
	|-ObjectEqualityComparer<KeyValuePair<DateTime, object>>.LastIndexOf
	|
	|-RVA: 0x2BA6D50 Offset: 0x2BA6E51 VA: 0x2BA6D50
	|-ObjectEqualityComparer<KeyValuePair<int, object>>.LastIndexOf
	|
	|-RVA: 0x2BA7210 Offset: 0x2BA7311 VA: 0x2BA7210
	|-ObjectEqualityComparer<KeyValuePair<object, ValueTuple<int, DateTime, object>>>.LastIndexOf
	|
	|-RVA: 0x2BA7690 Offset: 0x2BA7791 VA: 0x2BA7690
	|-ObjectEqualityComparer<KeyValuePair<object, object>>.LastIndexOf
	|
	|-RVA: 0x2BA7B50 Offset: 0x2BA7C51 VA: 0x2BA7B50
	|-ObjectEqualityComparer<CommonBattleSequence.Reliance<object>>.LastIndexOf
	|
	|-RVA: 0x2BA7FD0 Offset: 0x2BA80D1 VA: 0x2BA7FD0
	|-ObjectEqualityComparer<RenderGraphResourcePool.ResourceLogInfo<object>>.LastIndexOf
	|
	|-RVA: 0x2BA8410 Offset: 0x2BA8511 VA: 0x2BA8410
	|-ObjectEqualityComparer<TimeInterval<object>>.LastIndexOf
	|
	|-RVA: 0x2BA88A0 Offset: 0x2BA89A1 VA: 0x2BA88A0
	|-ObjectEqualityComparer<Timestamped<object>>.LastIndexOf
	|
	|-RVA: 0x2BA8D00 Offset: 0x2BA8E01 VA: 0x2BA8D00
	|-ObjectEqualityComparer<UniTask<object>>.LastIndexOf
	|
	|-RVA: 0x2BA9140 Offset: 0x2BA9241 VA: 0x2BA9140
	|-ObjectEqualityComparer<ValueTuple<ValueTuple<bool, object>>>.LastIndexOf
	|
	|-RVA: 0x2BA95D0 Offset: 0x2BA96D1 VA: 0x2BA95D0
	|-ObjectEqualityComparer<ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>.LastIndexOf
	|
	|-RVA: 0x2BA9A80 Offset: 0x2BA9B81 VA: 0x2BA9A80
	|-ObjectEqualityComparer<ValueTuple<bool, UniTask<object>>>.LastIndexOf
	|
	|-RVA: 0x2BA9F30 Offset: 0x2BAA031 VA: 0x2BA9F30
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>.LastIndexOf
	|
	|-RVA: 0x2BAA410 Offset: 0x2BAA511 VA: 0x2BAA410
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>>.LastIndexOf
	|
	|-RVA: 0x2BAA900 Offset: 0x2BAAA01 VA: 0x2BAA900
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>>>.LastIndexOf
	|
	|-RVA: 0x2BAAD80 Offset: 0x2BAAE81 VA: 0x2BAAD80
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>>>.LastIndexOf
	|
	|-RVA: 0x2BAB1E0 Offset: 0x2BAB2E1 VA: 0x2BAB1E0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>>>.LastIndexOf
	|
	|-RVA: 0x2BAB710 Offset: 0x2BAB811 VA: 0x2BAB710
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>>>.LastIndexOf
	|
	|-RVA: 0x2BABBA0 Offset: 0x2BABCA1 VA: 0x2BABBA0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>>>.LastIndexOf
	|
	|-RVA: 0x2BAC0B0 Offset: 0x2BAC1B1 VA: 0x2BAC0B0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>>>.LastIndexOf
	|
	|-RVA: 0x2BAC5C0 Offset: 0x2BAC6C1 VA: 0x2BAC5C0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>>>.LastIndexOf
	|
	|-RVA: 0x3A56980 Offset: 0x3A56A81 VA: 0x3A56980
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>>>.LastIndexOf
	|
	|-RVA: 0x3A56E60 Offset: 0x3A56F61 VA: 0x3A56E60
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>>>.LastIndexOf
	|
	|-RVA: 0x3A57360 Offset: 0x3A57461 VA: 0x3A57360
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>>>.LastIndexOf
	|
	|-RVA: 0x3A57890 Offset: 0x3A57991 VA: 0x3A57890
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>>>.LastIndexOf
	|
	|-RVA: 0x3A57DD0 Offset: 0x3A57ED1 VA: 0x3A57DD0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>>>.LastIndexOf
	|
	|-RVA: 0x3A582B0 Offset: 0x3A583B1 VA: 0x3A582B0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>>>.LastIndexOf
	|
	|-RVA: 0x3A58790 Offset: 0x3A58891 VA: 0x3A58790
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>>>.LastIndexOf
	|
	|-RVA: 0x3A58C10 Offset: 0x3A58D11 VA: 0x3A58C10
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>>>.LastIndexOf
	|
	|-RVA: 0x3A590F0 Offset: 0x3A591F1 VA: 0x3A590F0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>>>.LastIndexOf
	|
	|-RVA: 0x3A595B0 Offset: 0x3A596B1 VA: 0x3A595B0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>>>.LastIndexOf
	|
	|-RVA: 0x3A59AC0 Offset: 0x3A59BC1 VA: 0x3A59AC0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>>>.LastIndexOf
	|
	|-RVA: 0x3A59FD0 Offset: 0x3A5A0D1 VA: 0x3A59FD0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>>>.LastIndexOf
	|
	|-RVA: 0x3A5A4D0 Offset: 0x3A5A5D1 VA: 0x3A5A4D0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>>>.LastIndexOf
	|
	|-RVA: 0x3A5AA20 Offset: 0x3A5AB21 VA: 0x3A5AA20
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>>>.LastIndexOf
	|
	|-RVA: 0x3A5AF80 Offset: 0x3A5B081 VA: 0x3A5AF80
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>>>.LastIndexOf
	|
	|-RVA: 0x3A5B510 Offset: 0x3A5B611 VA: 0x3A5B510
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>>>.LastIndexOf
	|
	|-RVA: 0x3A5BAB0 Offset: 0x3A5BBB1 VA: 0x3A5BAB0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>>>.LastIndexOf
	|
	|-RVA: 0x3A5C0B0 Offset: 0x3A5C1B1 VA: 0x3A5C0B0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>>>.LastIndexOf
	|
	|-RVA: 0x3A5C580 Offset: 0x3A5C681 VA: 0x3A5C580
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>>.LastIndexOf
	|
	|-RVA: 0x3A5C9F0 Offset: 0x3A5CAF1 VA: 0x3A5C9F0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>>.LastIndexOf
	|
	|-RVA: 0x3A5CED0 Offset: 0x3A5CFD1 VA: 0x3A5CED0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>>.LastIndexOf
	|
	|-RVA: 0x3A5D350 Offset: 0x3A5D451 VA: 0x3A5D350
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>>.LastIndexOf
	|
	|-RVA: 0x3A5D800 Offset: 0x3A5D901 VA: 0x3A5D800
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>>.LastIndexOf
	|
	|-RVA: 0x3A5DCE0 Offset: 0x3A5DDE1 VA: 0x3A5DCE0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>>.LastIndexOf
	|
	|-RVA: 0x3A5E1A0 Offset: 0x3A5E2A1 VA: 0x3A5E1A0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>>.LastIndexOf
	|
	|-RVA: 0x3A5E680 Offset: 0x3A5E781 VA: 0x3A5E680
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>>.LastIndexOf
	|
	|-RVA: 0x3A5EB70 Offset: 0x3A5EC71 VA: 0x3A5EB70
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>>.LastIndexOf
	|
	|-RVA: 0x3A5F030 Offset: 0x3A5F131 VA: 0x3A5F030
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>>.LastIndexOf
	|
	|-RVA: 0x3A5F4E0 Offset: 0x3A5F5E1 VA: 0x3A5F4E0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>>.LastIndexOf
	|
	|-RVA: 0x3A5F990 Offset: 0x3A5FA91 VA: 0x3A5F990
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>>.LastIndexOf
	|
	|-RVA: 0x3A5FE70 Offset: 0x3A5FF71 VA: 0x3A5FE70
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>>.LastIndexOf
	|
	|-RVA: 0x3A602F0 Offset: 0x3A603F1 VA: 0x3A602F0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>>.LastIndexOf
	|
	|-RVA: 0x3A607A0 Offset: 0x3A608A1 VA: 0x3A607A0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>>.LastIndexOf
	|
	|-RVA: 0x3A60C80 Offset: 0x3A60D81 VA: 0x3A60C80
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>>.LastIndexOf
	|
	|-RVA: 0x3A61140 Offset: 0x3A61241 VA: 0x3A61140
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>>.LastIndexOf
	|
	|-RVA: 0x3A61620 Offset: 0x3A61721 VA: 0x3A61620
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>>.LastIndexOf
	|
	|-RVA: 0x3A61B10 Offset: 0x3A61C11 VA: 0x3A61B10
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>>.LastIndexOf
	|
	|-RVA: 0x3A62050 Offset: 0x3A62151 VA: 0x3A62050
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.LastIndexOf
	|
	|-RVA: 0x3A62560 Offset: 0x3A62661 VA: 0x3A62560
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>>.LastIndexOf
	|
	|-RVA: 0x3A62AE0 Offset: 0x3A62BE1 VA: 0x3A62AE0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.LastIndexOf
	|
	|-RVA: 0x3A63060 Offset: 0x3A63161 VA: 0x3A63060
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>>.LastIndexOf
	|
	|-RVA: 0x3A63640 Offset: 0x3A63741 VA: 0x3A63640
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.LastIndexOf
	|
	|-RVA: 0x3A63BD0 Offset: 0x3A63CD1 VA: 0x3A63BD0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>>.LastIndexOf
	|
	|-RVA: 0x3A641E0 Offset: 0x3A642E1 VA: 0x3A641E0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.LastIndexOf
	|
	|-RVA: 0x3A647C0 Offset: 0x3A648C1 VA: 0x3A647C0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>>.LastIndexOf
	|
	|-RVA: 0x3A64E30 Offset: 0x3A64F31 VA: 0x3A64E30
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.LastIndexOf
	|
	|-RVA: 0x3A65420 Offset: 0x3A65521 VA: 0x3A65420
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>>.LastIndexOf
	|
	|-RVA: 0x3A658B0 Offset: 0x3A659B1 VA: 0x3A658B0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>.LastIndexOf
	|
	|-RVA: 0x3A65CC0 Offset: 0x3A65DC1 VA: 0x3A65CC0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>.LastIndexOf
	|
	|-RVA: 0x3A661A0 Offset: 0x3A662A1 VA: 0x3A661A0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>.LastIndexOf
	|
	|-RVA: 0x3A66610 Offset: 0x3A66711 VA: 0x3A66610
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>.LastIndexOf
	|
	|-RVA: 0x3A66AC0 Offset: 0x3A66BC1 VA: 0x3A66AC0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>.LastIndexOf
	|
	|-RVA: 0x3A66F80 Offset: 0x3A67081 VA: 0x3A66F80
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>.LastIndexOf
	|
	|-RVA: 0x3A673D0 Offset: 0x3A674D1 VA: 0x3A673D0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>.LastIndexOf
	|
	|-RVA: 0x3A67860 Offset: 0x3A67961 VA: 0x3A67860
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>.LastIndexOf
	|
	|-RVA: 0x3A67D10 Offset: 0x3A67E11 VA: 0x3A67D10
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>.LastIndexOf
	|
	|-RVA: 0x3A681F0 Offset: 0x3A682F1 VA: 0x3A681F0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>.LastIndexOf
	|
	|-RVA: 0x3A686E0 Offset: 0x3A687E1 VA: 0x3A686E0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>.LastIndexOf
	|
	|-RVA: 0x3A68B40 Offset: 0x3A68C41 VA: 0x3A68B40
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>.LastIndexOf
	|
	|-RVA: 0x3A68FD0 Offset: 0x3A690D1 VA: 0x3A68FD0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>.LastIndexOf
	|
	|-RVA: 0x3A69410 Offset: 0x3A69511 VA: 0x3A69410
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>.LastIndexOf
	|
	|-RVA: 0x3A69890 Offset: 0x3A69991 VA: 0x3A69890
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>.LastIndexOf
	|
	|-RVA: 0x3A69D40 Offset: 0x3A69E41 VA: 0x3A69D40
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>.LastIndexOf
	|
	|-RVA: 0x3A6A220 Offset: 0x3A6A321 VA: 0x3A6A220
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>.LastIndexOf
	|
	|-RVA: 0x3A6A6E0 Offset: 0x3A6A7E1 VA: 0x3A6A6E0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>.LastIndexOf
	|
	|-RVA: 0x3A6AB90 Offset: 0x3A6AC91 VA: 0x3A6AB90
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>.LastIndexOf
	|
	|-RVA: 0x3A6B0C0 Offset: 0x3A6B1C1 VA: 0x3A6B0C0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.LastIndexOf
	|
	|-RVA: 0x3A6B5D0 Offset: 0x3A6B6D1 VA: 0x3A6B5D0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>.LastIndexOf
	|
	|-RVA: 0x3A6BB40 Offset: 0x3A6BC41 VA: 0x3A6BB40
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.LastIndexOf
	|
	|-RVA: 0x3A6C060 Offset: 0x3A6C161 VA: 0x3A6C060
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>.LastIndexOf
	|
	|-RVA: 0x3A6C630 Offset: 0x3A6C731 VA: 0x3A6C630
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.LastIndexOf
	|
	|-RVA: 0x3A6CBC0 Offset: 0x3A6CCC1 VA: 0x3A6CBC0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>.LastIndexOf
	|
	|-RVA: 0x3A6D1D0 Offset: 0x3A6D2D1 VA: 0x3A6D1D0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.LastIndexOf
	|
	|-RVA: 0x3A6D770 Offset: 0x3A6D871 VA: 0x3A6D770
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>.LastIndexOf
	|
	|-RVA: 0x3A6DDD0 Offset: 0x3A6DED1 VA: 0x3A6DDD0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.LastIndexOf
	|
	|-RVA: 0x3A6E3C0 Offset: 0x3A6E4C1 VA: 0x3A6E3C0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>.LastIndexOf
	|
	|-RVA: 0x3A6E8D0 Offset: 0x3A6E9D1 VA: 0x3A6E8D0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>>>.LastIndexOf
	|
	|-RVA: 0x3A6EDA0 Offset: 0x3A6EEA1 VA: 0x3A6EDA0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.LastIndexOf
	|
	|-RVA: 0x3A6F210 Offset: 0x3A6F311 VA: 0x3A6F210
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>.LastIndexOf
	|
	|-RVA: 0x3A6F680 Offset: 0x3A6F781 VA: 0x3A6F680
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, bool>>>.LastIndexOf
	|
	|-RVA: 0x3A6FB30 Offset: 0x3A6FC31 VA: 0x3A6FB30
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, Bounds>>>.LastIndexOf
	|
	|-RVA: 0x3A6FFA0 Offset: 0x3A700A1 VA: 0x3A6FFA0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, byte>>>.LastIndexOf
	|
	|-RVA: 0x3A70450 Offset: 0x3A70551 VA: 0x3A70450
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, Color>>>.LastIndexOf
	|
	|-RVA: 0x3A70900 Offset: 0x3A70A01 VA: 0x3A70900
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, double>>>.LastIndexOf
	|
	|-RVA: 0x3C2F2D0 Offset: 0x3C2F3D1 VA: 0x3C2F2D0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, int>>>.LastIndexOf
	|
	|-RVA: 0x3C2F780 Offset: 0x3C2F881 VA: 0x3C2F780
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, long>>>.LastIndexOf
	|
	|-RVA: 0x3C2FC30 Offset: 0x3C2FD31 VA: 0x3C2FC30
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, object>>>.LastIndexOf
	|
	|-RVA: 0x3C300E0 Offset: 0x3C301E1 VA: 0x3C300E0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, Quaternion>>>.LastIndexOf
	|
	|-RVA: 0x3C30590 Offset: 0x3C30691 VA: 0x3C30590
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, Rect>>>.LastIndexOf
	|
	|-RVA: 0x3C30A00 Offset: 0x3C30B01 VA: 0x3C30A00
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, float>>>.LastIndexOf
	|
	|-RVA: 0x3C30EB0 Offset: 0x3C30FB1 VA: 0x3C30EB0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, UniTask>>>.LastIndexOf
	|
	|-RVA: 0x3C31320 Offset: 0x3C31421 VA: 0x3C31320
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, Unit>>>.LastIndexOf
	|
	|-RVA: 0x3C31770 Offset: 0x3C31871 VA: 0x3C31770
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, Vector2>>>.LastIndexOf
	|
	|-RVA: 0x3C31C00 Offset: 0x3C31D01 VA: 0x3C31C00
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, Vector3>>>.LastIndexOf
	|
	|-RVA: 0x3C320B0 Offset: 0x3C321B1 VA: 0x3C320B0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, Vector4>>>.LastIndexOf
	|
	|-RVA: 0x3C32560 Offset: 0x3C32661 VA: 0x3C32560
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<int, object>>>.LastIndexOf
	|
	|-RVA: 0x3C32A10 Offset: 0x3C32B11 VA: 0x3C32A10
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<object, object>>>.LastIndexOf
	|
	|-RVA: 0x3C32EF0 Offset: 0x3C32FF1 VA: 0x3C32EF0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.LastIndexOf
	|
	|-RVA: 0x3C333C0 Offset: 0x3C334C1 VA: 0x3C333C0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<object, object, object>>>.LastIndexOf
	|
	|-RVA: 0x3C338F0 Offset: 0x3C339F1 VA: 0x3C338F0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.LastIndexOf
	|
	|-RVA: 0x3C33E00 Offset: 0x3C33F01 VA: 0x3C33E00
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<object, object, object, object>>>.LastIndexOf
	|
	|-RVA: 0x3C34370 Offset: 0x3C34471 VA: 0x3C34370
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.LastIndexOf
	|
	|-RVA: 0x3C348A0 Offset: 0x3C349A1 VA: 0x3C348A0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<object, object, object, object, object>>>.LastIndexOf
	|
	|-RVA: 0x3C34E70 Offset: 0x3C34F71 VA: 0x3C34E70
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.LastIndexOf
	|
	|-RVA: 0x3C35400 Offset: 0x3C35501 VA: 0x3C35400
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>.LastIndexOf
	|
	|-RVA: 0x3C35A10 Offset: 0x3C35B11 VA: 0x3C35A10
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.LastIndexOf
	|
	|-RVA: 0x3C35FC0 Offset: 0x3C360C1 VA: 0x3C35FC0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>.LastIndexOf
	|
	|-RVA: 0x3C36620 Offset: 0x3C36721 VA: 0x3C36620
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>>.LastIndexOf
	|
	|-RVA: 0x3C36B80 Offset: 0x3C36C81 VA: 0x3C36B80
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.LastIndexOf
	|
	|-RVA: 0x3C36FC0 Offset: 0x3C370C1 VA: 0x3C36FC0
	|-ObjectEqualityComparer<ValueTuple<bool, AsyncUnit>>.LastIndexOf
	|
	|-RVA: 0x3C373D0 Offset: 0x3C374D1 VA: 0x3C373D0
	|-ObjectEqualityComparer<ValueTuple<bool, bool>>.LastIndexOf
	|
	|-RVA: 0x3C37880 Offset: 0x3C37981 VA: 0x3C37880
	|-ObjectEqualityComparer<ValueTuple<bool, Bounds>>.LastIndexOf
	|
	|-RVA: 0x3C37CD0 Offset: 0x3C37DD1 VA: 0x3C37CD0
	|-ObjectEqualityComparer<ValueTuple<bool, byte>>.LastIndexOf
	|
	|-RVA: 0x3C38150 Offset: 0x3C38251 VA: 0x3C38150
	|-ObjectEqualityComparer<ValueTuple<bool, Color>>.LastIndexOf
	|
	|-RVA: 0x3C385A0 Offset: 0x3C386A1 VA: 0x3C385A0
	|-ObjectEqualityComparer<ValueTuple<bool, double>>.LastIndexOf
	|
	|-RVA: 0x3C389C0 Offset: 0x3C38AC1 VA: 0x3C389C0
	|-ObjectEqualityComparer<ValueTuple<bool, int>>.LastIndexOf
	|
	|-RVA: 0x3C38DE0 Offset: 0x3C38EE1 VA: 0x3C38DE0
	|-ObjectEqualityComparer<ValueTuple<bool, long>>.LastIndexOf
	|
	|-RVA: 0x3C39210 Offset: 0x3C39311 VA: 0x3C39210
	|-ObjectEqualityComparer<ValueTuple<bool, object>>.LastIndexOf
	|
	|-RVA: 0x3C396A0 Offset: 0x3C397A1 VA: 0x3C396A0
	|-ObjectEqualityComparer<ValueTuple<bool, Quaternion>>.LastIndexOf
	|
	|-RVA: 0x3C39B50 Offset: 0x3C39C51 VA: 0x3C39B50
	|-ObjectEqualityComparer<ValueTuple<bool, Rect>>.LastIndexOf
	|
	|-RVA: 0x3C39F90 Offset: 0x3C3A091 VA: 0x3C39F90
	|-ObjectEqualityComparer<ValueTuple<bool, float>>.LastIndexOf
	|
	|-RVA: 0x3C3A3B0 Offset: 0x3C3A4B1 VA: 0x3C3A3B0
	|-ObjectEqualityComparer<ValueTuple<bool, UniTask>>.LastIndexOf
	|
	|-RVA: 0x3C3A7D0 Offset: 0x3C3A8D1 VA: 0x3C3A7D0
	|-ObjectEqualityComparer<ValueTuple<bool, Unit>>.LastIndexOf
	|
	|-RVA: 0x3C3AC10 Offset: 0x3C3AD11 VA: 0x3C3AC10
	|-ObjectEqualityComparer<ValueTuple<bool, Vector2>>.LastIndexOf
	|
	|-RVA: 0x3C3B060 Offset: 0x3C3B161 VA: 0x3C3B060
	|-ObjectEqualityComparer<ValueTuple<bool, Vector3>>.LastIndexOf
	|
	|-RVA: 0x3C3B4F0 Offset: 0x3C3B5F1 VA: 0x3C3B4F0
	|-ObjectEqualityComparer<ValueTuple<bool, Vector4>>.LastIndexOf
	|
	|-RVA: 0x3C3B940 Offset: 0x3C3BA41 VA: 0x3C3B940
	|-ObjectEqualityComparer<ValueTuple<int, object>>.LastIndexOf
	|
	|-RVA: 0x3C3BD50 Offset: 0x3C3BE51 VA: 0x3C3BD50
	|-ObjectEqualityComparer<ValueTuple<Int32Enum, int>>.LastIndexOf
	|
	|-RVA: 0x3C3C1D0 Offset: 0x3C3C2D1 VA: 0x3C3C1D0
	|-ObjectEqualityComparer<ValueTuple<object, ValueTuple<object, int>>>.LastIndexOf
	|
	|-RVA: 0x3C3C610 Offset: 0x3C3C711 VA: 0x3C3C610
	|-ObjectEqualityComparer<ValueTuple<object, int>>.LastIndexOf
	|
	|-RVA: 0x3C3CA30 Offset: 0x3C3CB31 VA: 0x3C3CA30
	|-ObjectEqualityComparer<ValueTuple<object, object>>.LastIndexOf
	|
	|-RVA: 0x3C3CE50 Offset: 0x3C3CF51 VA: 0x3C3CE50
	|-ObjectEqualityComparer<ValueTuple<object, float>>.LastIndexOf
	|
	|-RVA: 0x3C3D2C0 Offset: 0x3C3D3C1 VA: 0x3C3D2C0
	|-ObjectEqualityComparer<ValueTuple<Vector3, float>>.LastIndexOf
	|
	|-RVA: 0x3C3D7A0 Offset: 0x3C3D8A1 VA: 0x3C3D7A0
	|-ObjectEqualityComparer<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>.LastIndexOf
	|
	|-RVA: 0x3C3DC00 Offset: 0x3C3DD01 VA: 0x3C3DC00
	|-ObjectEqualityComparer<ValueTuple<object, Int32Enum, int>>.LastIndexOf
	|
	|-RVA: 0x3C3E080 Offset: 0x3C3E181 VA: 0x3C3E080
	|-ObjectEqualityComparer<ValueTuple<object, object, object>>.LastIndexOf
	|
	|-RVA: 0x3C3E5A0 Offset: 0x3C3E6A1 VA: 0x3C3E5A0
	|-ObjectEqualityComparer<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.LastIndexOf
	|
	|-RVA: 0x3C3EA70 Offset: 0x3C3EB71 VA: 0x3C3EA70
	|-ObjectEqualityComparer<ValueTuple<object, int, int, int>>.LastIndexOf
	|
	|-RVA: 0x3C3EF10 Offset: 0x3C3F011 VA: 0x3C3EF10
	|-ObjectEqualityComparer<ValueTuple<object, object, object, object>>.LastIndexOf
	|
	|-RVA: 0x3C3F470 Offset: 0x3C3F571 VA: 0x3C3F470
	|-ObjectEqualityComparer<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.LastIndexOf
	|
	|-RVA: 0x3C3F990 Offset: 0x3C3FA91 VA: 0x3C3F990
	|-ObjectEqualityComparer<ValueTuple<object, object, object, object, object>>.LastIndexOf
	|
	|-RVA: 0x3C3FF50 Offset: 0x3C40051 VA: 0x3C3FF50
	|-ObjectEqualityComparer<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.LastIndexOf
	|
	|-RVA: 0x3C40480 Offset: 0x3C40581 VA: 0x3C40480
	|-ObjectEqualityComparer<ValueTuple<object, object, object, object, object, object>>.LastIndexOf
	|
	|-RVA: 0x3C40A70 Offset: 0x3C40B71 VA: 0x3C40A70
	|-ObjectEqualityComparer<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.LastIndexOf
	|
	|-RVA: 0x3C41010 Offset: 0x3C41111 VA: 0x3C41010
	|-ObjectEqualityComparer<ValueTuple<object, object, object, object, object, object, object>>.LastIndexOf
	|
	|-RVA: 0x3C41660 Offset: 0x3C41761 VA: 0x3C41660
	|-ObjectEqualityComparer<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>.LastIndexOf
	|
	|-RVA: 0x3C41BB0 Offset: 0x3C41CB1 VA: 0x3C41BB0
	|-ObjectEqualityComparer<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>.LastIndexOf
	|
	|-RVA: 0x3C42020 Offset: 0x3C42121 VA: 0x3C42020
	|-ObjectEqualityComparer<AnimatorClipInfo>.LastIndexOf
	|
	|-RVA: 0x3C42450 Offset: 0x3C42551 VA: 0x3C42450
	|-ObjectEqualityComparer<AsyncOperationHandle>.LastIndexOf
	|
	|-RVA: 0x3C42880 Offset: 0x3C42981 VA: 0x3C42880
	|-ObjectEqualityComparer<AsyncUnit>.LastIndexOf
	|
	|-RVA: 0x3C42BE0 Offset: 0x3C42CE1 VA: 0x3C42BE0
	|-ObjectEqualityComparer<BoneWeight>.LastIndexOf
	|
	|-RVA: 0x3C42F00 Offset: 0x3C43001 VA: 0x3C42F00
	|-ObjectEqualityComparer<bool>.LastIndexOf
	|
	|-RVA: 0x3C43200 Offset: 0x3C43301 VA: 0x3C43200
	|-ObjectEqualityComparer<Bounds>.LastIndexOf
	|
	|-RVA: 0x3C43510 Offset: 0x3C43611 VA: 0x3C43510
	|-ObjectEqualityComparer<byte>.LastIndexOf
	|
	|-RVA: 0x3C43910 Offset: 0x3C43A11 VA: 0x3C43910
	|-ObjectEqualityComparer<CameraInfo>.LastIndexOf
	|
	|-RVA: 0x3C43C90 Offset: 0x3C43D91 VA: 0x3C43C90
	|-ObjectEqualityComparer<CancellationToken>.LastIndexOf
	|
	|-RVA: 0x3C43F90 Offset: 0x3C44091 VA: 0x3C43F90
	|-ObjectEqualityComparer<CancellationTokenRegistration>.LastIndexOf
	|
	|-RVA: 0x3C442A0 Offset: 0x3C443A1 VA: 0x3C442A0
	|-ObjectEqualityComparer<char>.LastIndexOf
	|
	|-RVA: 0x3C445D0 Offset: 0x3C446D1 VA: 0x3C445D0
	|-ObjectEqualityComparer<Color>.LastIndexOf
	|
	|-RVA: 0x3C449F0 Offset: 0x3C44AF1 VA: 0x3C449F0
	|-ObjectEqualityComparer<Color32>.LastIndexOf
	|
	|-RVA: 0x3C44D90 Offset: 0x3C44E91 VA: 0x3C44D90
	|-ObjectEqualityComparer<ColorBlock>.LastIndexOf
	|
	|-RVA: 0x3C451C0 Offset: 0x3C452C1 VA: 0x3C451C0
	|-ObjectEqualityComparer<ConstraintSource>.LastIndexOf
	|
	|-RVA: 0x3C45680 Offset: 0x3C45781 VA: 0x3C45680
	|-ObjectEqualityComparer<ContourVertex>.LastIndexOf
	|
	|-RVA: 0x3C45B50 Offset: 0x3C45C51 VA: 0x3C45B50
	|-ObjectEqualityComparer<DataStoreRatingInfo>.LastIndexOf
	|
	|-RVA: 0x3C45FD0 Offset: 0x3C460D1 VA: 0x3C45FD0
	|-ObjectEqualityComparer<DataStoreResult>.LastIndexOf
	|
	|-RVA: 0x3C46340 Offset: 0x3C46441 VA: 0x3C46340
	|-ObjectEqualityComparer<DateTime>.LastIndexOf
	|
	|-RVA: 0x3C46660 Offset: 0x3C46761 VA: 0x3C46660
	|-ObjectEqualityComparer<DateTimeOffset>.LastIndexOf
	|
	|-RVA: 0x3C46990 Offset: 0x3C46A91 VA: 0x3C46990
	|-ObjectEqualityComparer<Decimal>.LastIndexOf
	|
	|-RVA: 0x3C46E10 Offset: 0x3C46F11 VA: 0x3C46E10
	|-ObjectEqualityComparer<DiagnosticEvent>.LastIndexOf
	|
	|-RVA: 0x3C471C0 Offset: 0x3C472C1 VA: 0x3C471C0
	|-ObjectEqualityComparer<double>.LastIndexOf
	|
	|-RVA: 0x3C474D0 Offset: 0x3C475D1 VA: 0x3C474D0
	|-ObjectEqualityComparer<FXZ>.LastIndexOf
	|
	|-RVA: 0x3C47940 Offset: 0x3C47A41 VA: 0x3C47940
	|-ObjectEqualityComparer<Friend>.LastIndexOf
	|
	|-RVA: 0x3C47CE0 Offset: 0x3C47DE1 VA: 0x3C47CE0
	|-ObjectEqualityComparer<GlyphRect>.LastIndexOf
	|
	|-RVA: 0x3C48010 Offset: 0x3C48111 VA: 0x3C48010
	|-ObjectEqualityComparer<Guid>.LastIndexOf
	|
	|-RVA: 0x3C48320 Offset: 0x3C48421 VA: 0x3C48320
	|-ObjectEqualityComparer<short>.LastIndexOf
	|
	|-RVA: 0x3C48620 Offset: 0x3C48721 VA: 0x3C48620
	|-ObjectEqualityComparer<int>.LastIndexOf
	|
	|-RVA: 0x3C489D0 Offset: 0x3C48AD1 VA: 0x3C489D0
	|-ObjectEqualityComparer<Int32Enum>.LastIndexOf
	|
	|-RVA: 0x3C48D20 Offset: 0x3C48E21 VA: 0x3C48D20
	|-ObjectEqualityComparer<long>.LastIndexOf
	|
	|-RVA: 0x3C490D0 Offset: 0x3C491D1 VA: 0x3C490D0
	|-ObjectEqualityComparer<Int64Enum>.LastIndexOf
	|
	|-RVA: 0x3C49420 Offset: 0x3C49521 VA: 0x3C49420
	|-ObjectEqualityComparer<IntPtr>.LastIndexOf
	|
	|-RVA: 0x3C49820 Offset: 0x3C49921 VA: 0x3C49820
	|-ObjectEqualityComparer<InterpretedFrameInfo>.LastIndexOf
	|
	|-RVA: 0x3C49CE0 Offset: 0x3C49DE1 VA: 0x3C49CE0
	|-ObjectEqualityComparer<IntervalTreeNode>.LastIndexOf
	|
	|-RVA: 0x3C4A160 Offset: 0x3C4A261 VA: 0x3C4A160
	|-ObjectEqualityComparer<LayerMask>.LastIndexOf
	|
	|-RVA: 0x3C4A5C0 Offset: 0x3C4A6C1 VA: 0x3C4A5C0
	|-ObjectEqualityComparer<LengthLimitProperties>.LastIndexOf
	|
	|-RVA: 0x3C4A930 Offset: 0x3C4AA31 VA: 0x3C4A930
	|-ObjectEqualityComparer<MapPos>.LastIndexOf
	|
	|-RVA: 0x3C4AC50 Offset: 0x3C4AD51 VA: 0x3C4AC50
	|-ObjectEqualityComparer<Matrix4x4>.LastIndexOf
	|
	|-RVA: 0x3C4B0E0 Offset: 0x3C4B1E1 VA: 0x3C4B0E0
	|-ObjectEqualityComparer<Navigation>.LastIndexOf
	|
	|-RVA: 0x3C4B440 Offset: 0x3C4B541 VA: 0x3C4B440
	|-ObjectEqualityComparer<object>.LastIndexOf
	|
	|-RVA: 0x3C4B8B0 Offset: 0x3C4B9B1 VA: 0x3C4B8B0
	|-ObjectEqualityComparer<ObjectInitializationData>.LastIndexOf
	|
	|-RVA: 0x3C4BD40 Offset: 0x3C4BE41 VA: 0x3C4BD40
	|-ObjectEqualityComparer<Playable>.LastIndexOf
	|
	|-RVA: 0x3C4C200 Offset: 0x3C4C301 VA: 0x3C4C200
	|-ObjectEqualityComparer<PlayableBinding>.LastIndexOf
	|
	|-RVA: 0x3C4C6F0 Offset: 0x3C4C7F1 VA: 0x3C4C6F0
	|-ObjectEqualityComparer<PlayerLoopSystem>.LastIndexOf
	|
	|-RVA: 0x3C4CBF0 Offset: 0x3C4CCF1 VA: 0x3C4CBF0
	|-ObjectEqualityComparer<PlayerLoopSystemInternal>.LastIndexOf
	|
	|-RVA: 0x3C4CFB0 Offset: 0x3C4D0B1 VA: 0x3C4CFB0
	|-ObjectEqualityComparer<Quaternion>.LastIndexOf
	|
	|-RVA: 0x3C4D3D0 Offset: 0x3C4D4D1 VA: 0x3C4D3D0
	|-ObjectEqualityComparer<RandomSeed>.LastIndexOf
	|
	|-RVA: 0x3C4D840 Offset: 0x3C4D941 VA: 0x3C4D840
	|-ObjectEqualityComparer<RangePositionInfo>.LastIndexOf
	|
	|-RVA: 0x3C4DCB0 Offset: 0x3C4DDB1 VA: 0x3C4DCB0
	|-ObjectEqualityComparer<Ranking2ChartInfoInput>.LastIndexOf
	|
	|-RVA: 0x3C4E1B0 Offset: 0x3C4E2B1 VA: 0x3C4E1B0
	|-ObjectEqualityComparer<RaycastHit2D>.LastIndexOf
	|
	|-RVA: 0x3C4E710 Offset: 0x3C4E811 VA: 0x3C4E710
	|-ObjectEqualityComparer<RaycastResult>.LastIndexOf
	|
	|-RVA: 0x3C4EAF0 Offset: 0x3C4EBF1 VA: 0x3C4EAF0
	|-ObjectEqualityComparer<Rect>.LastIndexOf
	|
	|-RVA: 0x3C4EF10 Offset: 0x3C4F011 VA: 0x3C4EF10
	|-ObjectEqualityComparer<RendererListHandle>.LastIndexOf
	|
	|-RVA: 0x3C4F370 Offset: 0x3C4F471 VA: 0x3C4F370
	|-ObjectEqualityComparer<ResourceHandle>.LastIndexOf
	|
	|-RVA: 0x3C4F7D0 Offset: 0x3C4F8D1 VA: 0x3C4F7D0
	|-ObjectEqualityComparer<ResourceLocator>.LastIndexOf
	|
	|-RVA: 0x3C4FB40 Offset: 0x3C4FC41 VA: 0x3C4FB40
	|-ObjectEqualityComparer<sbyte>.LastIndexOf
	|
	|-RVA: 0x3C4FE50 Offset: 0x3C4FF51 VA: 0x3C4FE50
	|-ObjectEqualityComparer<ShaderTagId>.LastIndexOf
	|
	|-RVA: 0x3C50160 Offset: 0x3C50261 VA: 0x3C50160
	|-ObjectEqualityComparer<float>.LastIndexOf
	|
	|-RVA: 0x3C504C0 Offset: 0x3C505C1 VA: 0x3C504C0
	|-ObjectEqualityComparer<SphericalHarmonicsL2>.LastIndexOf
	|
	|-RVA: 0x3C50950 Offset: 0x3C50A51 VA: 0x3C50950
	|-ObjectEqualityComparer<SpriteState>.LastIndexOf
	|
	|-RVA: 0x3C50E40 Offset: 0x3C50F41 VA: 0x3C50E40
	|-ObjectEqualityComparer<SubMeshDescriptor>.LastIndexOf
	|
	|-RVA: 0x3C512D0 Offset: 0x3C513D1 VA: 0x3C512D0
	|-ObjectEqualityComparer<TablePair>.LastIndexOf
	|
	|-RVA: 0x3C51650 Offset: 0x3C51751 VA: 0x3C51650
	|-ObjectEqualityComparer<TimeSpan>.LastIndexOf
	|
	|-RVA: 0x3C51A80 Offset: 0x3C51B81 VA: 0x3C51A80
	|-ObjectEqualityComparer<UICharInfo>.LastIndexOf
	|
	|-RVA: 0x3C51F10 Offset: 0x3C52011 VA: 0x3C51F10
	|-ObjectEqualityComparer<UILineInfo>.LastIndexOf
	|
	|-RVA: 0x3C524C0 Offset: 0x3C525C1 VA: 0x3C524C0
	|-ObjectEqualityComparer<UIVertex>.LastIndexOf
	|
	|-RVA: 0x3C528A0 Offset: 0x3C529A1 VA: 0x3C528A0
	|-ObjectEqualityComparer<ushort>.LastIndexOf
	|
	|-RVA: 0x3C52BA0 Offset: 0x3C52CA1 VA: 0x3C52BA0
	|-ObjectEqualityComparer<uint>.LastIndexOf
	|
	|-RVA: 0x3C52EB0 Offset: 0x3C52FB1 VA: 0x3C52EB0
	|-ObjectEqualityComparer<ulong>.LastIndexOf
	|
	|-RVA: 0x3C53260 Offset: 0x3C53361 VA: 0x3C53260
	|-ObjectEqualityComparer<UniTask>.LastIndexOf
	|
	|-RVA: 0x3C535D0 Offset: 0x3C536D1 VA: 0x3C535D0
	|-ObjectEqualityComparer<Unit>.LastIndexOf
	|
	|-RVA: 0x3C538E0 Offset: 0x3C539E1 VA: 0x3C538E0
	|-ObjectEqualityComparer<Vector2>.LastIndexOf
	|
	|-RVA: 0x3C53C20 Offset: 0x3C53D21 VA: 0x3C53C20
	|-ObjectEqualityComparer<Vector3>.LastIndexOf
	|
	|-RVA: 0x3C53F80 Offset: 0x3C54081 VA: 0x3C53F80
	|-ObjectEqualityComparer<Vector4>.LastIndexOf
	|
	|-RVA: 0x3C542C0 Offset: 0x3C543C1 VA: 0x3C542C0
	|-ObjectEqualityComparer<VertexAttributeDescriptor>.LastIndexOf
	|
	|-RVA: 0x3C546D0 Offset: 0x3C547D1 VA: 0x3C546D0
	|-ObjectEqualityComparer<X509ChainStatus>.LastIndexOf
	|
	|-RVA: 0x3C54AF0 Offset: 0x3C54BF1 VA: 0x3C54AF0
	|-ObjectEqualityComparer<XPathNodeRef>.LastIndexOf
	|
	|-RVA: 0x3C54FC0 Offset: 0x3C550C1 VA: 0x3C54FC0
	|-ObjectEqualityComparer<XRView>.LastIndexOf
	|
	|-RVA: 0x3C55440 Offset: 0x3C55541 VA: 0x3C55440
	|-ObjectEqualityComparer<AmiiboSequence.GainItemData>.LastIndexOf
	|
	|-RVA: 0x3C55920 Offset: 0x3C55A21 VA: 0x3C55920
	|-ObjectEqualityComparer<AnimationOutputWeightProcessor.WeightInfo>.LastIndexOf
	|
	|-RVA: 0x3C55DB0 Offset: 0x3C55EB1 VA: 0x3C55DB0
	|-ObjectEqualityComparer<ArenaOrderSequence.GodInfo>.LastIndexOf
	|
	|-RVA: 0x3C56220 Offset: 0x3C56321 VA: 0x3C56220
	|-ObjectEqualityComparer<BattleInfo.SupportData>.LastIndexOf
	|
	|-RVA: 0x3C56690 Offset: 0x3C56791 VA: 0x3C56690
	|-ObjectEqualityComparer<BeforeRenderHelper.OrderBlock>.LastIndexOf
	|
	|-RVA: 0x3C56B50 Offset: 0x3C56C51 VA: 0x3C56B50
	|-ObjectEqualityComparer<Camera.RenderRequest>.LastIndexOf
	|
	|-RVA: 0x3C56FD0 Offset: 0x3C570D1 VA: 0x3C56FD0
	|-ObjectEqualityComparer<CameraState.CustomBlendable>.LastIndexOf
	|
	|-RVA: 0x3C57440 Offset: 0x3C57541 VA: 0x3C57440
	|-ObjectEqualityComparer<CinemachineClearShot.Pair>.LastIndexOf
	|
	|-RVA: 0x3C578A0 Offset: 0x3C579A1 VA: 0x3C578A0
	|-ObjectEqualityComparer<CinemachineStateDrivenCamera.HashPair>.LastIndexOf
	|
	|-RVA: 0x3C57D50 Offset: 0x3C57E51 VA: 0x3C57D50
	|-ObjectEqualityComparer<DelayedActionManager.DelegateInfo>.LastIndexOf
	|
	|-RVA: 0x3C58240 Offset: 0x3C58341 VA: 0x3C58240
	|-ObjectEqualityComparer<Detail.AsyncResultInt>.LastIndexOf
	|
	|-RVA: 0x3C586D0 Offset: 0x3C587D1 VA: 0x3C586D0
	|-ObjectEqualityComparer<Detail.CppArray>.LastIndexOf
	|
	|-RVA: 0x3C58BB0 Offset: 0x3C58CB1 VA: 0x3C58BB0
	|-ObjectEqualityComparer<Detail.NotificationEventInt>.LastIndexOf
	|
	|-RVA: 0x3C59040 Offset: 0x3C59141 VA: 0x3C59040
	|-ObjectEqualityComparer<DragonRideTargetGroup.ChainParam>.LastIndexOf
	|
	|-RVA: 0x3C594B0 Offset: 0x3C595B1 VA: 0x3C594B0
	|-ObjectEqualityComparer<DynamicMesh.State>.LastIndexOf
	|
	|-RVA: 0x3C59910 Offset: 0x3C59A11 VA: 0x3C59910
	|-ObjectEqualityComparer<GameVariable.Value>.LastIndexOf
	|
	|-RVA: 0x3C59DD0 Offset: 0x3C59ED1 VA: 0x3C59DD0
	|-ObjectEqualityComparer<GmapPathAdjuster.TargetModel>.LastIndexOf
	|
	|-RVA: 0x3C5A2A0 Offset: 0x3C5A3A1 VA: 0x3C5A2A0
	|-ObjectEqualityComparer<GmapSpotAdjuster.TargetModel>.LastIndexOf
	|
	|-RVA: 0x3C5A770 Offset: 0x3C5A871 VA: 0x3C5A770
	|-ObjectEqualityComparer<HubFastTravel.Location>.LastIndexOf
	|
	|-RVA: 0x3C5AC60 Offset: 0x3C5AD61 VA: 0x3C5AC60
	|-ObjectEqualityComparer<HubLensFlare.Flare>.LastIndexOf
	|
	|-RVA: 0x3C5B0F0 Offset: 0x3C5B1F1 VA: 0x3C5B0F0
	|-ObjectEqualityComparer<InventoryPoolItemMenuContent.KindBgNameClass>.LastIndexOf
	|
	|-RVA: 0x3C5B560 Offset: 0x3C5B661 VA: 0x3C5B560
	|-ObjectEqualityComparer<Map.Pos>.LastIndexOf
	|
	|-RVA: 0x3C5B9C0 Offset: 0x3C5BAC1 VA: 0x3C5B9C0
	|-ObjectEqualityComparer<MapImage.BackupTerrain>.LastIndexOf
	|
	|-RVA: 0x3C5BE30 Offset: 0x3C5BF31 VA: 0x3C5BE30
	|-ObjectEqualityComparer<MapImageRange.Pos>.LastIndexOf
	|
	|-RVA: 0x3C5C350 Offset: 0x3C5C451 VA: 0x3C5C350
	|-ObjectEqualityComparer<MapMind.Record>.LastIndexOf
	|
	|-RVA: 0x3C5C850 Offset: 0x3C5C951 VA: 0x3C5C850
	|-ObjectEqualityComparer<MapMind.Target>.LastIndexOf
	|
	|-RVA: 0x36FD0B0 Offset: 0x36FD1B1 VA: 0x36FD0B0
	|-ObjectEqualityComparer<MapPanelDebug.Entity>.LastIndexOf
	|
	|-RVA: 0x36FD530 Offset: 0x36FD631 VA: 0x36FD530
	|-ObjectEqualityComparer<NexRanking.Data>.LastIndexOf
	|
	|-RVA: 0x36FD990 Offset: 0x36FDA91 VA: 0x36FD990
	|-ObjectEqualityComparer<NexVersus.RatingData>.LastIndexOf
	|
	|-RVA: 0x36FDE00 Offset: 0x36FDF01 VA: 0x36FDE00
	|-ObjectEqualityComparer<PackedPlayModeBuildLogs.RuntimeBuildLog>.LastIndexOf
	|
	|-RVA: 0x36FE2D0 Offset: 0x36FE3D1 VA: 0x36FE2D0
	|-ObjectEqualityComparer<ParticleSystem.Particle>.LastIndexOf
	|
	|-RVA: 0x36FE7C0 Offset: 0x36FE8C1 VA: 0x36FE7C0
	|-ObjectEqualityComparer<QualitySettingsStack.Settings>.LastIndexOf
	|
	|-RVA: 0x36FEC50 Offset: 0x36FED51 VA: 0x36FEC50
	|-ObjectEqualityComparer<RangeData.Offset>.LastIndexOf
	|
	|-RVA: 0x36FF100 Offset: 0x36FF201 VA: 0x36FF100
	|-ObjectEqualityComparer<RenderGraphDebugData.PassDebugData>.LastIndexOf
	|
	|-RVA: 0x36FF5F0 Offset: 0x36FF6F1 VA: 0x36FF5F0
	|-ObjectEqualityComparer<RenderGraphDebugData.ResourceDebugData>.LastIndexOf
	|
	|-RVA: 0x36FFA80 Offset: 0x36FFB81 VA: 0x36FFA80
	|-ObjectEqualityComparer<RingCleaningUnitSelectMenu.GodParam>.LastIndexOf
	|
	|-RVA: 0x36FFF60 Offset: 0x3700061 VA: 0x36FFF60
	|-ObjectEqualityComparer<SequenceNode.SequenceConstructPosContext>.LastIndexOf
	|
	|-RVA: 0x3700460 Offset: 0x3700561 VA: 0x3700460
	|-ObjectEqualityComparer<ShadowUtility.Edge>.LastIndexOf
	|
	|-RVA: 0x37008F0 Offset: 0x37009F1 VA: 0x37008F0
	|-ObjectEqualityComparer<SimpleAnimationPlayable.QueuedState>.LastIndexOf
	|
	|-RVA: 0x3700D60 Offset: 0x3700E61 VA: 0x3700D60
	|-ObjectEqualityComparer<SkillArray.Entity>.LastIndexOf
	|
	|-RVA: 0x37011E0 Offset: 0x37012E1 VA: 0x37011E0
	|-ObjectEqualityComparer<Stream.Info>.LastIndexOf
	|
	|-RVA: 0x37016F0 Offset: 0x37017F1 VA: 0x37016F0
	|-ObjectEqualityComparer<TexturePacker_JsonArray.Frame>.LastIndexOf
	|
	|-RVA: 0x3701BE0 Offset: 0x3701CE1 VA: 0x3701BE0
	|-ObjectEqualityComparer<TimeNotificationBehaviour.NotificationEntry>.LastIndexOf
	|
	|-RVA: 0x37020B0 Offset: 0x37021B1 VA: 0x37020B0
	|-ObjectEqualityComparer<UnitySynchronizationContext.WorkRequest>.LastIndexOf
	|
	|-RVA: 0x3702530 Offset: 0x3702631 VA: 0x3702530
	|-ObjectEqualityComparer<XmlSchemaObjectTable.XmlSchemaObjectEntry>.LastIndexOf
	|
	|-RVA: 0x37029A0 Offset: 0x3702AA1 VA: 0x37029A0
	|-ObjectEqualityComparer<AIThink.EnchantThink.SurroundingInfo>.LastIndexOf
	|
	|-RVA: 0x3702E00 Offset: 0x3702F01 VA: 0x3702E00
	|-ObjectEqualityComparer<AssetBundleBuildMap.AssetBundleEntry.AssetPathString>.LastIndexOf
	|
	|-RVA: 0x37032D0 Offset: 0x37033D1 VA: 0x37032D0
	|-ObjectEqualityComparer<Detail.DataStore.DataStoreChangeMetaParamInt>.LastIndexOf
	|
	|-RVA: 0x3703750 Offset: 0x3703851 VA: 0x3703750
	|-ObjectEqualityComparer<Detail.DataStore.DataStoreDeleteParamInt>.LastIndexOf
	|
	|-RVA: 0x3703C30 Offset: 0x3703D31 VA: 0x3703C30
	|-ObjectEqualityComparer<Detail.DataStore.DataStoreGetMetaParamInt>.LastIndexOf
	|
	|-RVA: 0x3704120 Offset: 0x3704221 VA: 0x3704120
	|-ObjectEqualityComparer<Detail.DataStore.DataStoreMetaInfoInt>.LastIndexOf
	|
	|-RVA: 0x37045F0 Offset: 0x37046F1 VA: 0x37045F0
	|-ObjectEqualityComparer<Detail.DataStore.DataStorePasswordInfoInt>.LastIndexOf
	|
	|-RVA: 0x3704AC0 Offset: 0x3704BC1 VA: 0x3704AC0
	|-ObjectEqualityComparer<Detail.DataStore.DataStorePersistenceInfoInt>.LastIndexOf
	|
	|-RVA: 0x3704FA0 Offset: 0x37050A1 VA: 0x3704FA0
	|-ObjectEqualityComparer<Detail.DataStore.DataStorePreparePostParamInt>.LastIndexOf
	|
	|-RVA: 0x3705420 Offset: 0x3705521 VA: 0x3705420
	|-ObjectEqualityComparer<Detail.DataStore.DataStoreRateObjectParamInt>.LastIndexOf
	|
	|-RVA: 0x37058E0 Offset: 0x37059E1 VA: 0x37058E0
	|-ObjectEqualityComparer<Detail.DataStore.DataStoreRatingInitParamInt>.LastIndexOf
	|
	|-RVA: 0x3705D60 Offset: 0x3705E61 VA: 0x3705D60
	|-ObjectEqualityComparer<Detail.DataStore.DataStoreRatingTargetInt>.LastIndexOf
	|
	|-RVA: 0x3706270 Offset: 0x3706371 VA: 0x3706270
	|-ObjectEqualityComparer<Detail.Ranking.RankingCachedResultInt>.LastIndexOf
	|
	|-RVA: 0x3706710 Offset: 0x3706811 VA: 0x3706710
	|-ObjectEqualityComparer<Detail.Ranking.RankingOrderParamInt>.LastIndexOf
	|
	|-RVA: 0x3706C20 Offset: 0x3706D21 VA: 0x3706C20
	|-ObjectEqualityComparer<Detail.Ranking.RankingRankDataInt>.LastIndexOf
	|
	|-RVA: 0x37071B0 Offset: 0x37072B1 VA: 0x37071B0
	|-ObjectEqualityComparer<Detail.Ranking2.Ranking2ChartInfoInt>.LastIndexOf
	|
	|-RVA: 0x3707710 Offset: 0x3707811 VA: 0x3707710
	|-ObjectEqualityComparer<Detail.Ranking2.Ranking2RankDataInt>.LastIndexOf
	|
	|-RVA: 0x3707BB0 Offset: 0x3707CB1 VA: 0x3707BB0
	|-ObjectEqualityComparer<Detail.Ranking2.Ranking2ScoreDataInt>.LastIndexOf
	|
	|-RVA: 0x3708070 Offset: 0x3708171 VA: 0x3708070
	|-ObjectEqualityComparer<Detail.Screening.ScreeningContextInfoInt>.LastIndexOf
	|
	|-RVA: 0x37085B0 Offset: 0x37086B1 VA: 0x37085B0
	|-ObjectEqualityComparer<Detail.Subscriber.SubscriberContentInt>.LastIndexOf
	|
	|-RVA: 0x3708AB0 Offset: 0x3708BB1 VA: 0x3708AB0
	|-ObjectEqualityComparer<Detail.Subscriber.SubscriberGetContentParamInt>.LastIndexOf
	|
	|-RVA: 0x3708FA0 Offset: 0x37090A1 VA: 0x3708FA0
	|-ObjectEqualityComparer<Detail.Subscriber.SubscriberUserStatusInfoInt>.LastIndexOf
	|
	|-RVA: 0x3709480 Offset: 0x3709581 VA: 0x3709480
	|-ObjectEqualityComparer<Detail.Subscriber.SubscriberUserStatusParamInt>.LastIndexOf
	|
	|-RVA: 0x3709900 Offset: 0x3709A01 VA: 0x3709900
	|-ObjectEqualityComparer<Detail.Utility.IntegerSettings>.LastIndexOf
	|
	|-RVA: 0x3709D60 Offset: 0x3709E61 VA: 0x3709D60
	|-ObjectEqualityComparer<Detail.Utility.UniqueIdInfoInt>.LastIndexOf
	|
	|-RVA: 0x370A200 Offset: 0x370A301 VA: 0x370A200
	|-ObjectEqualityComparer<MapHistory.Rewind.LatestInspectorData>.LastIndexOf
	|
	|-RVA: 0x370A6B0 Offset: 0x370A7B1 VA: 0x370A6B0
	|-ObjectEqualityComparer<MapHistory.Rewind.WorkTerrainData>.LastIndexOf
	|
	|-RVA: 0x370AB30 Offset: 0x370AC31 VA: 0x370AB30
	|-ObjectEqualityComparer<MapSkill.AroundCalculator.Result>.LastIndexOf
	|
	|-RVA: 0x370B010 Offset: 0x370B111 VA: 0x370B010
	|-ObjectEqualityComparer<TargetPositionCache.CacheCurve.Item>.LastIndexOf
	|
	|-RVA: 0x370B540 Offset: 0x370B641 VA: 0x370B540
	|-ObjectEqualityComparer<TargetPositionCache.CacheEntry.RecordingItem>.LastIndexOf
	|
	|-RVA: 0x370B9E0 Offset: 0x370BAE1 VA: 0x370B9E0
	|-ObjectEqualityComparer<TerrainUtility.TerrainMap.TileCoord>.LastIndexOf
	*/

	// RVA: -1 Offset: -1 Slot: 0
	public override bool Equals(object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BA60F0 Offset: 0x2BA61F1 VA: 0x2BA60F0
	|-ObjectEqualityComparer<AsyncOperationHandle<object>>.Equals
	|
	|-RVA: 0x2BA65C0 Offset: 0x2BA66C1 VA: 0x2BA65C0
	|-ObjectEqualityComparer<IntervalTree.Entry<object>>.Equals
	|
	|-RVA: 0x2BA6A30 Offset: 0x2BA6B31 VA: 0x2BA6A30
	|-ObjectEqualityComparer<KeyValuePair<DateTime, object>>.Equals
	|
	|-RVA: 0x2BA6EA0 Offset: 0x2BA6FA1 VA: 0x2BA6EA0
	|-ObjectEqualityComparer<KeyValuePair<int, object>>.Equals
	|
	|-RVA: 0x2BA7370 Offset: 0x2BA7471 VA: 0x2BA7370
	|-ObjectEqualityComparer<KeyValuePair<object, ValueTuple<int, DateTime, object>>>.Equals
	|
	|-RVA: 0x2BA77E0 Offset: 0x2BA78E1 VA: 0x2BA77E0
	|-ObjectEqualityComparer<KeyValuePair<object, object>>.Equals
	|
	|-RVA: 0x2BA7CB0 Offset: 0x2BA7DB1 VA: 0x2BA7CB0
	|-ObjectEqualityComparer<CommonBattleSequence.Reliance<object>>.Equals
	|
	|-RVA: 0x2BA8120 Offset: 0x2BA8221 VA: 0x2BA8120
	|-ObjectEqualityComparer<RenderGraphResourcePool.ResourceLogInfo<object>>.Equals
	|
	|-RVA: 0x2BA8550 Offset: 0x2BA8651 VA: 0x2BA8550
	|-ObjectEqualityComparer<TimeInterval<object>>.Equals
	|
	|-RVA: 0x2BA89F0 Offset: 0x2BA8AF1 VA: 0x2BA89F0
	|-ObjectEqualityComparer<Timestamped<object>>.Equals
	|
	|-RVA: 0x2BA8E50 Offset: 0x2BA8F51 VA: 0x2BA8E50
	|-ObjectEqualityComparer<UniTask<object>>.Equals
	|
	|-RVA: 0x2BA9280 Offset: 0x2BA9381 VA: 0x2BA9280
	|-ObjectEqualityComparer<ValueTuple<ValueTuple<bool, object>>>.Equals
	|
	|-RVA: 0x2BA9730 Offset: 0x2BA9831 VA: 0x2BA9730
	|-ObjectEqualityComparer<ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>.Equals
	|
	|-RVA: 0x2BA9BE0 Offset: 0x2BA9CE1 VA: 0x2BA9BE0
	|-ObjectEqualityComparer<ValueTuple<bool, UniTask<object>>>.Equals
	|
	|-RVA: 0x2BAA090 Offset: 0x2BAA191 VA: 0x2BAA090
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>.Equals
	|
	|-RVA: 0x2BAA580 Offset: 0x2BAA681 VA: 0x2BAA580
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>>.Equals
	|
	|-RVA: 0x2BAAA80 Offset: 0x2BAAB81 VA: 0x2BAAA80
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>>>.Equals
	|
	|-RVA: 0x2BAAEE0 Offset: 0x2BAAFE1 VA: 0x2BAAEE0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>>>.Equals
	|
	|-RVA: 0x2BAB340 Offset: 0x2BAB441 VA: 0x2BAB340
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>>>.Equals
	|
	|-RVA: 0x2BAB8A0 Offset: 0x2BAB9A1 VA: 0x2BAB8A0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>>>.Equals
	|
	|-RVA: 0x2BABD00 Offset: 0x2BABE01 VA: 0x2BABD00
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>>>.Equals
	|
	|-RVA: 0x2BAC240 Offset: 0x2BAC341 VA: 0x2BAC240
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>>>.Equals
	|
	|-RVA: 0x2BAC740 Offset: 0x2BAC841 VA: 0x2BAC740
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>>>.Equals
	|
	|-RVA: 0x3A56AE0 Offset: 0x3A56BE1 VA: 0x3A56AE0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>>>.Equals
	|
	|-RVA: 0x3A56FE0 Offset: 0x3A570E1 VA: 0x3A56FE0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>>>.Equals
	|
	|-RVA: 0x3A574E0 Offset: 0x3A575E1 VA: 0x3A574E0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>>>.Equals
	|
	|-RVA: 0x3A57A20 Offset: 0x3A57B21 VA: 0x3A57A20
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>>>.Equals
	|
	|-RVA: 0x3A57F60 Offset: 0x3A58061 VA: 0x3A57F60
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>>>.Equals
	|
	|-RVA: 0x3A58410 Offset: 0x3A58511 VA: 0x3A58410
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>>>.Equals
	|
	|-RVA: 0x3A58910 Offset: 0x3A58A11 VA: 0x3A58910
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>>>.Equals
	|
	|-RVA: 0x3A58D70 Offset: 0x3A58E71 VA: 0x3A58D70
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>>>.Equals
	|
	|-RVA: 0x3A59260 Offset: 0x3A59361 VA: 0x3A59260
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>>>.Equals
	|
	|-RVA: 0x3A59710 Offset: 0x3A59811 VA: 0x3A59710
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>>>.Equals
	|
	|-RVA: 0x3A59C50 Offset: 0x3A59D51 VA: 0x3A59C50
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>>>.Equals
	|
	|-RVA: 0x3A5A150 Offset: 0x3A5A251 VA: 0x3A5A150
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>>>.Equals
	|
	|-RVA: 0x3A5A650 Offset: 0x3A5A751 VA: 0x3A5A650
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>>>.Equals
	|
	|-RVA: 0x3A5ABB0 Offset: 0x3A5ACB1 VA: 0x3A5ABB0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>>>.Equals
	|
	|-RVA: 0x3A5B110 Offset: 0x3A5B211 VA: 0x3A5B110
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>>>.Equals
	|
	|-RVA: 0x3A5B6B0 Offset: 0x3A5B7B1 VA: 0x3A5B6B0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>>>.Equals
	|
	|-RVA: 0x3A5BC60 Offset: 0x3A5BD61 VA: 0x3A5BC60
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>>>.Equals
	|
	|-RVA: 0x3A5C270 Offset: 0x3A5C371 VA: 0x3A5C270
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>>>.Equals
	|
	|-RVA: 0x3A5C6E0 Offset: 0x3A5C7E1 VA: 0x3A5C6E0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>>.Equals
	|
	|-RVA: 0x3A5CB50 Offset: 0x3A5CC51 VA: 0x3A5CB50
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>>.Equals
	|
	|-RVA: 0x3A5D040 Offset: 0x3A5D141 VA: 0x3A5D040
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>>.Equals
	|
	|-RVA: 0x3A5D4B0 Offset: 0x3A5D5B1 VA: 0x3A5D4B0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>>.Equals
	|
	|-RVA: 0x3A5D960 Offset: 0x3A5DA61 VA: 0x3A5D960
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>>.Equals
	|
	|-RVA: 0x3A5DE50 Offset: 0x3A5DF51 VA: 0x3A5DE50
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>>.Equals
	|
	|-RVA: 0x3A5E300 Offset: 0x3A5E401 VA: 0x3A5E300
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>>.Equals
	|
	|-RVA: 0x3A5E7F0 Offset: 0x3A5E8F1 VA: 0x3A5E7F0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>>.Equals
	|
	|-RVA: 0x3A5ECE0 Offset: 0x3A5EDE1 VA: 0x3A5ECE0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>>.Equals
	|
	|-RVA: 0x3A5F190 Offset: 0x3A5F291 VA: 0x3A5F190
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>>.Equals
	|
	|-RVA: 0x3A5F640 Offset: 0x3A5F741 VA: 0x3A5F640
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>>.Equals
	|
	|-RVA: 0x3A5FAF0 Offset: 0x3A5FBF1 VA: 0x3A5FAF0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>>.Equals
	|
	|-RVA: 0x3A5FFE0 Offset: 0x3A600E1 VA: 0x3A5FFE0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>>.Equals
	|
	|-RVA: 0x3A60450 Offset: 0x3A60551 VA: 0x3A60450
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>>.Equals
	|
	|-RVA: 0x3A60900 Offset: 0x3A60A01 VA: 0x3A60900
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>>.Equals
	|
	|-RVA: 0x3A60DF0 Offset: 0x3A60EF1 VA: 0x3A60DF0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>>.Equals
	|
	|-RVA: 0x3A612A0 Offset: 0x3A613A1 VA: 0x3A612A0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>>.Equals
	|
	|-RVA: 0x3A61790 Offset: 0x3A61891 VA: 0x3A61790
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>>.Equals
	|
	|-RVA: 0x3A61C80 Offset: 0x3A61D81 VA: 0x3A61C80
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>>.Equals
	|
	|-RVA: 0x3A621E0 Offset: 0x3A622E1 VA: 0x3A621E0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.Equals
	|
	|-RVA: 0x3A626E0 Offset: 0x3A627E1 VA: 0x3A626E0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>>.Equals
	|
	|-RVA: 0x3A62C90 Offset: 0x3A62D91 VA: 0x3A62C90
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.Equals
	|
	|-RVA: 0x3A631F0 Offset: 0x3A632F1 VA: 0x3A631F0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>>.Equals
	|
	|-RVA: 0x3A63800 Offset: 0x3A63901 VA: 0x3A63800
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.Equals
	|
	|-RVA: 0x3A63D60 Offset: 0x3A63E61 VA: 0x3A63D60
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>>.Equals
	|
	|-RVA: 0x3A643C0 Offset: 0x3A644C1 VA: 0x3A643C0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.Equals
	|
	|-RVA: 0x3A64960 Offset: 0x3A64A61 VA: 0x3A64960
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>>.Equals
	|
	|-RVA: 0x3A65020 Offset: 0x3A65121 VA: 0x3A65020
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.Equals
	|
	|-RVA: 0x3A655D0 Offset: 0x3A656D1 VA: 0x3A655D0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>>.Equals
	|
	|-RVA: 0x3A659E0 Offset: 0x3A65AE1 VA: 0x3A659E0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>.Equals
	|
	|-RVA: 0x3A65DF0 Offset: 0x3A65EF1 VA: 0x3A65DF0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>.Equals
	|
	|-RVA: 0x3A66330 Offset: 0x3A66431 VA: 0x3A66330
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>.Equals
	|
	|-RVA: 0x3A66740 Offset: 0x3A66841 VA: 0x3A66740
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>.Equals
	|
	|-RVA: 0x3A66C30 Offset: 0x3A66D31 VA: 0x3A66C30
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>.Equals
	|
	|-RVA: 0x3A670E0 Offset: 0x3A671E1 VA: 0x3A670E0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>.Equals
	|
	|-RVA: 0x3A67510 Offset: 0x3A67611 VA: 0x3A67510
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>.Equals
	|
	|-RVA: 0x3A679C0 Offset: 0x3A67AC1 VA: 0x3A679C0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>.Equals
	|
	|-RVA: 0x3A67E70 Offset: 0x3A67F71 VA: 0x3A67E70
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>.Equals
	|
	|-RVA: 0x3A68360 Offset: 0x3A68461 VA: 0x3A68360
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>.Equals
	|
	|-RVA: 0x3A68850 Offset: 0x3A68951 VA: 0x3A68850
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>.Equals
	|
	|-RVA: 0x3A68C80 Offset: 0x3A68D81 VA: 0x3A68C80
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>.Equals
	|
	|-RVA: 0x3A69130 Offset: 0x3A69231 VA: 0x3A69130
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>.Equals
	|
	|-RVA: 0x3A69540 Offset: 0x3A69641 VA: 0x3A69540
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>.Equals
	|
	|-RVA: 0x3A699F0 Offset: 0x3A69AF1 VA: 0x3A699F0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>.Equals
	|
	|-RVA: 0x3A69EA0 Offset: 0x3A69FA1 VA: 0x3A69EA0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>.Equals
	|
	|-RVA: 0x3A6A390 Offset: 0x3A6A491 VA: 0x3A6A390
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>.Equals
	|
	|-RVA: 0x3A6A840 Offset: 0x3A6A941 VA: 0x3A6A840
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>.Equals
	|
	|-RVA: 0x3A6ACF0 Offset: 0x3A6ADF1 VA: 0x3A6ACF0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>.Equals
	|
	|-RVA: 0x3A6B250 Offset: 0x3A6B351 VA: 0x3A6B250
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.Equals
	|
	|-RVA: 0x3A6B740 Offset: 0x3A6B841 VA: 0x3A6B740
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>.Equals
	|
	|-RVA: 0x3A6BCE0 Offset: 0x3A6BDE1 VA: 0x3A6BCE0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.Equals
	|
	|-RVA: 0x3A6C1E0 Offset: 0x3A6C2E1 VA: 0x3A6C1E0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>.Equals
	|
	|-RVA: 0x3A6C7F0 Offset: 0x3A6C8F1 VA: 0x3A6C7F0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.Equals
	|
	|-RVA: 0x3A6CD50 Offset: 0x3A6CE51 VA: 0x3A6CD50
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>.Equals
	|
	|-RVA: 0x3A6D3A0 Offset: 0x3A6D4A1 VA: 0x3A6D3A0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.Equals
	|
	|-RVA: 0x3A6D900 Offset: 0x3A6DA01 VA: 0x3A6D900
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>.Equals
	|
	|-RVA: 0x3A6DFC0 Offset: 0x3A6E0C1 VA: 0x3A6DFC0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.Equals
	|
	|-RVA: 0x3A6E560 Offset: 0x3A6E661 VA: 0x3A6E560
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>.Equals
	|
	|-RVA: 0x3A6EA30 Offset: 0x3A6EB31 VA: 0x3A6EA30
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>>>.Equals
	|
	|-RVA: 0x3A6EF00 Offset: 0x3A6F001 VA: 0x3A6EF00
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.Equals
	|
	|-RVA: 0x3A6F370 Offset: 0x3A6F471 VA: 0x3A6F370
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>.Equals
	|
	|-RVA: 0x3A6F7E0 Offset: 0x3A6F8E1 VA: 0x3A6F7E0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, bool>>>.Equals
	|
	|-RVA: 0x3A6FC90 Offset: 0x3A6FD91 VA: 0x3A6FC90
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, Bounds>>>.Equals
	|
	|-RVA: 0x3A70100 Offset: 0x3A70201 VA: 0x3A70100
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, byte>>>.Equals
	|
	|-RVA: 0x3A705B0 Offset: 0x3A706B1 VA: 0x3A705B0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, Color>>>.Equals
	|
	|-RVA: 0x3A70A60 Offset: 0x3A70B61 VA: 0x3A70A60
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, double>>>.Equals
	|
	|-RVA: 0x3C2F430 Offset: 0x3C2F531 VA: 0x3C2F430
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, int>>>.Equals
	|
	|-RVA: 0x3C2F8E0 Offset: 0x3C2F9E1 VA: 0x3C2F8E0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, long>>>.Equals
	|
	|-RVA: 0x3C2FD90 Offset: 0x3C2FE91 VA: 0x3C2FD90
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, object>>>.Equals
	|
	|-RVA: 0x3C30240 Offset: 0x3C30341 VA: 0x3C30240
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, Quaternion>>>.Equals
	|
	|-RVA: 0x3C306F0 Offset: 0x3C307F1 VA: 0x3C306F0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, Rect>>>.Equals
	|
	|-RVA: 0x3C30B60 Offset: 0x3C30C61 VA: 0x3C30B60
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, float>>>.Equals
	|
	|-RVA: 0x3C31010 Offset: 0x3C31111 VA: 0x3C31010
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, UniTask>>>.Equals
	|
	|-RVA: 0x3C31480 Offset: 0x3C31581 VA: 0x3C31480
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, Unit>>>.Equals
	|
	|-RVA: 0x3C318B0 Offset: 0x3C319B1 VA: 0x3C318B0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, Vector2>>>.Equals
	|
	|-RVA: 0x3C31D60 Offset: 0x3C31E61 VA: 0x3C31D60
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, Vector3>>>.Equals
	|
	|-RVA: 0x3C32210 Offset: 0x3C32311 VA: 0x3C32210
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, Vector4>>>.Equals
	|
	|-RVA: 0x3C326C0 Offset: 0x3C327C1 VA: 0x3C326C0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<int, object>>>.Equals
	|
	|-RVA: 0x3C32B70 Offset: 0x3C32C71 VA: 0x3C32B70
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<object, object>>>.Equals
	|
	|-RVA: 0x3C33070 Offset: 0x3C33171 VA: 0x3C33070
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.Equals
	|
	|-RVA: 0x3C33520 Offset: 0x3C33621 VA: 0x3C33520
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<object, object, object>>>.Equals
	|
	|-RVA: 0x3C33A80 Offset: 0x3C33B81 VA: 0x3C33A80
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.Equals
	|
	|-RVA: 0x3C33F70 Offset: 0x3C34071 VA: 0x3C33F70
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<object, object, object, object>>>.Equals
	|
	|-RVA: 0x3C34520 Offset: 0x3C34621 VA: 0x3C34520
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.Equals
	|
	|-RVA: 0x3C34A20 Offset: 0x3C34B21 VA: 0x3C34A20
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<object, object, object, object, object>>>.Equals
	|
	|-RVA: 0x3C35030 Offset: 0x3C35131 VA: 0x3C35030
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.Equals
	|
	|-RVA: 0x3C35590 Offset: 0x3C35691 VA: 0x3C35590
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>.Equals
	|
	|-RVA: 0x3C35BF0 Offset: 0x3C35CF1 VA: 0x3C35BF0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.Equals
	|
	|-RVA: 0x3C36150 Offset: 0x3C36251 VA: 0x3C36150
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>.Equals
	|
	|-RVA: 0x3C36810 Offset: 0x3C36911 VA: 0x3C36810
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>>.Equals
	|
	|-RVA: 0x3C36CE0 Offset: 0x3C36DE1 VA: 0x3C36CE0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.Equals
	|
	|-RVA: 0x3C370F0 Offset: 0x3C371F1 VA: 0x3C370F0
	|-ObjectEqualityComparer<ValueTuple<bool, AsyncUnit>>.Equals
	|
	|-RVA: 0x3C37500 Offset: 0x3C37601 VA: 0x3C37500
	|-ObjectEqualityComparer<ValueTuple<bool, bool>>.Equals
	|
	|-RVA: 0x3C379F0 Offset: 0x3C37AF1 VA: 0x3C379F0
	|-ObjectEqualityComparer<ValueTuple<bool, Bounds>>.Equals
	|
	|-RVA: 0x3C37E00 Offset: 0x3C37F01 VA: 0x3C37E00
	|-ObjectEqualityComparer<ValueTuple<bool, byte>>.Equals
	|
	|-RVA: 0x3C382B0 Offset: 0x3C383B1 VA: 0x3C382B0
	|-ObjectEqualityComparer<ValueTuple<bool, Color>>.Equals
	|
	|-RVA: 0x3C386E0 Offset: 0x3C387E1 VA: 0x3C386E0
	|-ObjectEqualityComparer<ValueTuple<bool, double>>.Equals
	|
	|-RVA: 0x3C38AF0 Offset: 0x3C38BF1 VA: 0x3C38AF0
	|-ObjectEqualityComparer<ValueTuple<bool, int>>.Equals
	|
	|-RVA: 0x3C38F20 Offset: 0x3C39021 VA: 0x3C38F20
	|-ObjectEqualityComparer<ValueTuple<bool, long>>.Equals
	|
	|-RVA: 0x3C39350 Offset: 0x3C39451 VA: 0x3C39350
	|-ObjectEqualityComparer<ValueTuple<bool, object>>.Equals
	|
	|-RVA: 0x3C39800 Offset: 0x3C39901 VA: 0x3C39800
	|-ObjectEqualityComparer<ValueTuple<bool, Quaternion>>.Equals
	|
	|-RVA: 0x3C39CB0 Offset: 0x3C39DB1 VA: 0x3C39CB0
	|-ObjectEqualityComparer<ValueTuple<bool, Rect>>.Equals
	|
	|-RVA: 0x3C3A0C0 Offset: 0x3C3A1C1 VA: 0x3C3A0C0
	|-ObjectEqualityComparer<ValueTuple<bool, float>>.Equals
	|
	|-RVA: 0x3C3A4F0 Offset: 0x3C3A5F1 VA: 0x3C3A4F0
	|-ObjectEqualityComparer<ValueTuple<bool, UniTask>>.Equals
	|
	|-RVA: 0x3C3A900 Offset: 0x3C3AA01 VA: 0x3C3A900
	|-ObjectEqualityComparer<ValueTuple<bool, Unit>>.Equals
	|
	|-RVA: 0x3C3AD70 Offset: 0x3C3AE71 VA: 0x3C3AD70
	|-ObjectEqualityComparer<ValueTuple<bool, Vector2>>.Equals
	|
	|-RVA: 0x3C3B1A0 Offset: 0x3C3B2A1 VA: 0x3C3B1A0
	|-ObjectEqualityComparer<ValueTuple<bool, Vector3>>.Equals
	|
	|-RVA: 0x3C3B650 Offset: 0x3C3B751 VA: 0x3C3B650
	|-ObjectEqualityComparer<ValueTuple<bool, Vector4>>.Equals
	|
	|-RVA: 0x3C3BA70 Offset: 0x3C3BB71 VA: 0x3C3BA70
	|-ObjectEqualityComparer<ValueTuple<int, object>>.Equals
	|
	|-RVA: 0x3C3BE80 Offset: 0x3C3BF81 VA: 0x3C3BE80
	|-ObjectEqualityComparer<ValueTuple<Int32Enum, int>>.Equals
	|
	|-RVA: 0x3C3C320 Offset: 0x3C3C421 VA: 0x3C3C320
	|-ObjectEqualityComparer<ValueTuple<object, ValueTuple<object, int>>>.Equals
	|
	|-RVA: 0x3C3C740 Offset: 0x3C3C841 VA: 0x3C3C740
	|-ObjectEqualityComparer<ValueTuple<object, int>>.Equals
	|
	|-RVA: 0x3C3CB60 Offset: 0x3C3CC61 VA: 0x3C3CB60
	|-ObjectEqualityComparer<ValueTuple<object, object>>.Equals
	|
	|-RVA: 0x3C3CF80 Offset: 0x3C3D081 VA: 0x3C3CF80
	|-ObjectEqualityComparer<ValueTuple<object, float>>.Equals
	|
	|-RVA: 0x3C3D420 Offset: 0x3C3D521 VA: 0x3C3D420
	|-ObjectEqualityComparer<ValueTuple<Vector3, float>>.Equals
	|
	|-RVA: 0x3C3D910 Offset: 0x3C3DA11 VA: 0x3C3D910
	|-ObjectEqualityComparer<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>.Equals
	|
	|-RVA: 0x3C3DD30 Offset: 0x3C3DE31 VA: 0x3C3DD30
	|-ObjectEqualityComparer<ValueTuple<object, Int32Enum, int>>.Equals
	|
	|-RVA: 0x3C3E1D0 Offset: 0x3C3E2D1 VA: 0x3C3E1D0
	|-ObjectEqualityComparer<ValueTuple<object, object, object>>.Equals
	|
	|-RVA: 0x3C3E720 Offset: 0x3C3E821 VA: 0x3C3E720
	|-ObjectEqualityComparer<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.Equals
	|
	|-RVA: 0x3C3EBC0 Offset: 0x3C3ECC1 VA: 0x3C3EBC0
	|-ObjectEqualityComparer<ValueTuple<object, int, int, int>>.Equals
	|
	|-RVA: 0x3C3F070 Offset: 0x3C3F171 VA: 0x3C3F070
	|-ObjectEqualityComparer<ValueTuple<object, object, object, object>>.Equals
	|
	|-RVA: 0x3C3F610 Offset: 0x3C3F711 VA: 0x3C3F610
	|-ObjectEqualityComparer<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.Equals
	|
	|-RVA: 0x3C3FB00 Offset: 0x3C3FC01 VA: 0x3C3FB00
	|-ObjectEqualityComparer<ValueTuple<object, object, object, object, object>>.Equals
	|
	|-RVA: 0x3C40100 Offset: 0x3C40201 VA: 0x3C40100
	|-ObjectEqualityComparer<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.Equals
	|
	|-RVA: 0x3C405F0 Offset: 0x3C406F1 VA: 0x3C405F0
	|-ObjectEqualityComparer<ValueTuple<object, object, object, object, object, object>>.Equals
	|
	|-RVA: 0x3C40C40 Offset: 0x3C40D41 VA: 0x3C40C40
	|-ObjectEqualityComparer<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.Equals
	|
	|-RVA: 0x3C41190 Offset: 0x3C41291 VA: 0x3C41190
	|-ObjectEqualityComparer<ValueTuple<object, object, object, object, object, object, object>>.Equals
	|
	|-RVA: 0x3C41840 Offset: 0x3C41941 VA: 0x3C41840
	|-ObjectEqualityComparer<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>.Equals
	|
	|-RVA: 0x3C41D00 Offset: 0x3C41E01 VA: 0x3C41D00
	|-ObjectEqualityComparer<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>.Equals
	|
	|-RVA: 0x3C42160 Offset: 0x3C42261 VA: 0x3C42160
	|-ObjectEqualityComparer<AnimatorClipInfo>.Equals
	|
	|-RVA: 0x3C425B0 Offset: 0x3C426B1 VA: 0x3C425B0
	|-ObjectEqualityComparer<AsyncOperationHandle>.Equals
	|
	|-RVA: 0x3C429C0 Offset: 0x3C42AC1 VA: 0x3C429C0
	|-ObjectEqualityComparer<AsyncUnit>.Equals
	|
	|-RVA: 0x3C42CD0 Offset: 0x3C42DD1 VA: 0x3C42CD0
	|-ObjectEqualityComparer<BoneWeight>.Equals
	|
	|-RVA: 0x3C42FE0 Offset: 0x3C430E1 VA: 0x3C42FE0
	|-ObjectEqualityComparer<bool>.Equals
	|
	|-RVA: 0x3C432F0 Offset: 0x3C433F1 VA: 0x3C432F0
	|-ObjectEqualityComparer<Bounds>.Equals
	|
	|-RVA: 0x3C435F0 Offset: 0x3C436F1 VA: 0x3C435F0
	|-ObjectEqualityComparer<byte>.Equals
	|
	|-RVA: 0x3C43A60 Offset: 0x3C43B61 VA: 0x3C43A60
	|-ObjectEqualityComparer<CameraInfo>.Equals
	|
	|-RVA: 0x3C43D70 Offset: 0x3C43E71 VA: 0x3C43D70
	|-ObjectEqualityComparer<CancellationToken>.Equals
	|
	|-RVA: 0x3C44080 Offset: 0x3C44181 VA: 0x3C44080
	|-ObjectEqualityComparer<CancellationTokenRegistration>.Equals
	|
	|-RVA: 0x3C44380 Offset: 0x3C44481 VA: 0x3C44380
	|-ObjectEqualityComparer<char>.Equals
	|
	|-RVA: 0x3C446D0 Offset: 0x3C447D1 VA: 0x3C446D0
	|-ObjectEqualityComparer<Color>.Equals
	|
	|-RVA: 0x3C44B30 Offset: 0x3C44C31 VA: 0x3C44B30
	|-ObjectEqualityComparer<Color32>.Equals
	|
	|-RVA: 0x3C44EA0 Offset: 0x3C44FA1 VA: 0x3C44EA0
	|-ObjectEqualityComparer<ColorBlock>.Equals
	|
	|-RVA: 0x3C45310 Offset: 0x3C45411 VA: 0x3C45310
	|-ObjectEqualityComparer<ConstraintSource>.Equals
	|
	|-RVA: 0x3C457E0 Offset: 0x3C458E1 VA: 0x3C457E0
	|-ObjectEqualityComparer<ContourVertex>.Equals
	|
	|-RVA: 0x3C45CB0 Offset: 0x3C45DB1 VA: 0x3C45CB0
	|-ObjectEqualityComparer<DataStoreRatingInfo>.Equals
	|
	|-RVA: 0x3C46110 Offset: 0x3C46211 VA: 0x3C46110
	|-ObjectEqualityComparer<DataStoreResult>.Equals
	|
	|-RVA: 0x3C46420 Offset: 0x3C46521 VA: 0x3C46420
	|-ObjectEqualityComparer<DateTime>.Equals
	|
	|-RVA: 0x3C46750 Offset: 0x3C46851 VA: 0x3C46750
	|-ObjectEqualityComparer<DateTimeOffset>.Equals
	|
	|-RVA: 0x3C46A80 Offset: 0x3C46B81 VA: 0x3C46A80
	|-ObjectEqualityComparer<Decimal>.Equals
	|
	|-RVA: 0x3C46F80 Offset: 0x3C47081 VA: 0x3C46F80
	|-ObjectEqualityComparer<DiagnosticEvent>.Equals
	|
	|-RVA: 0x3C472A0 Offset: 0x3C473A1 VA: 0x3C472A0
	|-ObjectEqualityComparer<double>.Equals
	|
	|-RVA: 0x3C475C0 Offset: 0x3C476C1 VA: 0x3C475C0
	|-ObjectEqualityComparer<FXZ>.Equals
	|
	|-RVA: 0x3C47AA0 Offset: 0x3C47BA1 VA: 0x3C47AA0
	|-ObjectEqualityComparer<Friend>.Equals
	|
	|-RVA: 0x3C47DD0 Offset: 0x3C47ED1 VA: 0x3C47DD0
	|-ObjectEqualityComparer<GlyphRect>.Equals
	|
	|-RVA: 0x3C48100 Offset: 0x3C48201 VA: 0x3C48100
	|-ObjectEqualityComparer<Guid>.Equals
	|
	|-RVA: 0x3C48400 Offset: 0x3C48501 VA: 0x3C48400
	|-ObjectEqualityComparer<short>.Equals
	|
	|-RVA: 0x3C48700 Offset: 0x3C48801 VA: 0x3C48700
	|-ObjectEqualityComparer<int>.Equals
	|
	|-RVA: 0x3C48AF0 Offset: 0x3C48BF1 VA: 0x3C48AF0
	|-ObjectEqualityComparer<Int32Enum>.Equals
	|
	|-RVA: 0x3C48E00 Offset: 0x3C48F01 VA: 0x3C48E00
	|-ObjectEqualityComparer<long>.Equals
	|
	|-RVA: 0x3C491F0 Offset: 0x3C492F1 VA: 0x3C491F0
	|-ObjectEqualityComparer<Int64Enum>.Equals
	|
	|-RVA: 0x3C49500 Offset: 0x3C49601 VA: 0x3C49500
	|-ObjectEqualityComparer<IntPtr>.Equals
	|
	|-RVA: 0x3C49970 Offset: 0x3C49A71 VA: 0x3C49970
	|-ObjectEqualityComparer<InterpretedFrameInfo>.Equals
	|
	|-RVA: 0x3C49E40 Offset: 0x3C49F41 VA: 0x3C49E40
	|-ObjectEqualityComparer<IntervalTreeNode>.Equals
	|
	|-RVA: 0x3C4A2A0 Offset: 0x3C4A3A1 VA: 0x3C4A2A0
	|-ObjectEqualityComparer<LayerMask>.Equals
	|
	|-RVA: 0x3C4A700 Offset: 0x3C4A801 VA: 0x3C4A700
	|-ObjectEqualityComparer<LengthLimitProperties>.Equals
	|
	|-RVA: 0x3C4AA10 Offset: 0x3C4AB11 VA: 0x3C4AA10
	|-ObjectEqualityComparer<MapPos>.Equals
	|
	|-RVA: 0x3C4AD50 Offset: 0x3C4AE51 VA: 0x3C4AD50
	|-ObjectEqualityComparer<Matrix4x4>.Equals
	|
	|-RVA: 0x3C4B250 Offset: 0x3C4B351 VA: 0x3C4B250
	|-ObjectEqualityComparer<Navigation>.Equals
	|
	|-RVA: 0x3C4B520 Offset: 0x3C4B621 VA: 0x3C4B520
	|-ObjectEqualityComparer<object>.Equals
	|
	|-RVA: 0x3C4BA20 Offset: 0x3C4BB21 VA: 0x3C4BA20
	|-ObjectEqualityComparer<ObjectInitializationData>.Equals
	|
	|-RVA: 0x3C4BE90 Offset: 0x3C4BF91 VA: 0x3C4BE90
	|-ObjectEqualityComparer<Playable>.Equals
	|
	|-RVA: 0x3C4C360 Offset: 0x3C4C461 VA: 0x3C4C360
	|-ObjectEqualityComparer<PlayableBinding>.Equals
	|
	|-RVA: 0x3C4C860 Offset: 0x3C4C961 VA: 0x3C4C860
	|-ObjectEqualityComparer<PlayerLoopSystem>.Equals
	|
	|-RVA: 0x3C4CD60 Offset: 0x3C4CE61 VA: 0x3C4CD60
	|-ObjectEqualityComparer<PlayerLoopSystemInternal>.Equals
	|
	|-RVA: 0x3C4D0B0 Offset: 0x3C4D1B1 VA: 0x3C4D0B0
	|-ObjectEqualityComparer<Quaternion>.Equals
	|
	|-RVA: 0x3C4D520 Offset: 0x3C4D621 VA: 0x3C4D520
	|-ObjectEqualityComparer<RandomSeed>.Equals
	|
	|-RVA: 0x3C4D990 Offset: 0x3C4DA91 VA: 0x3C4D990
	|-ObjectEqualityComparer<RangePositionInfo>.Equals
	|
	|-RVA: 0x3C4DDF0 Offset: 0x3C4DEF1 VA: 0x3C4DDF0
	|-ObjectEqualityComparer<Ranking2ChartInfoInput>.Equals
	|
	|-RVA: 0x3C4E330 Offset: 0x3C4E431 VA: 0x3C4E330
	|-ObjectEqualityComparer<RaycastHit2D>.Equals
	|
	|-RVA: 0x3C4E8A0 Offset: 0x3C4E9A1 VA: 0x3C4E8A0
	|-ObjectEqualityComparer<RaycastResult>.Equals
	|
	|-RVA: 0x3C4EBF0 Offset: 0x3C4ECF1 VA: 0x3C4EBF0
	|-ObjectEqualityComparer<Rect>.Equals
	|
	|-RVA: 0x3C4F050 Offset: 0x3C4F151 VA: 0x3C4F050
	|-ObjectEqualityComparer<RendererListHandle>.Equals
	|
	|-RVA: 0x3C4F4B0 Offset: 0x3C4F5B1 VA: 0x3C4F4B0
	|-ObjectEqualityComparer<ResourceHandle>.Equals
	|
	|-RVA: 0x3C4F920 Offset: 0x3C4FA21 VA: 0x3C4F920
	|-ObjectEqualityComparer<ResourceLocator>.Equals
	|
	|-RVA: 0x3C4FC20 Offset: 0x3C4FD21 VA: 0x3C4FC20
	|-ObjectEqualityComparer<sbyte>.Equals
	|
	|-RVA: 0x3C4FF30 Offset: 0x3C50031 VA: 0x3C4FF30
	|-ObjectEqualityComparer<ShaderTagId>.Equals
	|
	|-RVA: 0x3C50240 Offset: 0x3C50341 VA: 0x3C50240
	|-ObjectEqualityComparer<float>.Equals
	|
	|-RVA: 0x3C505E0 Offset: 0x3C506E1 VA: 0x3C505E0
	|-ObjectEqualityComparer<SphericalHarmonicsL2>.Equals
	|
	|-RVA: 0x3C50AB0 Offset: 0x3C50BB1 VA: 0x3C50AB0
	|-ObjectEqualityComparer<SpriteState>.Equals
	|
	|-RVA: 0x3C50FB0 Offset: 0x3C510B1 VA: 0x3C50FB0
	|-ObjectEqualityComparer<SubMeshDescriptor>.Equals
	|
	|-RVA: 0x3C51420 Offset: 0x3C51521 VA: 0x3C51420
	|-ObjectEqualityComparer<TablePair>.Equals
	|
	|-RVA: 0x3C51730 Offset: 0x3C51831 VA: 0x3C51730
	|-ObjectEqualityComparer<TimeSpan>.Equals
	|
	|-RVA: 0x3C51BF0 Offset: 0x3C51CF1 VA: 0x3C51BF0
	|-ObjectEqualityComparer<UICharInfo>.Equals
	|
	|-RVA: 0x3C52060 Offset: 0x3C52161 VA: 0x3C52060
	|-ObjectEqualityComparer<UILineInfo>.Equals
	|
	|-RVA: 0x3C52680 Offset: 0x3C52781 VA: 0x3C52680
	|-ObjectEqualityComparer<UIVertex>.Equals
	|
	|-RVA: 0x3C52980 Offset: 0x3C52A81 VA: 0x3C52980
	|-ObjectEqualityComparer<ushort>.Equals
	|
	|-RVA: 0x3C52C80 Offset: 0x3C52D81 VA: 0x3C52C80
	|-ObjectEqualityComparer<uint>.Equals
	|
	|-RVA: 0x3C52F90 Offset: 0x3C53091 VA: 0x3C52F90
	|-ObjectEqualityComparer<ulong>.Equals
	|
	|-RVA: 0x3C533A0 Offset: 0x3C534A1 VA: 0x3C533A0
	|-ObjectEqualityComparer<UniTask>.Equals
	|
	|-RVA: 0x3C536B0 Offset: 0x3C537B1 VA: 0x3C536B0
	|-ObjectEqualityComparer<Unit>.Equals
	|
	|-RVA: 0x3C539D0 Offset: 0x3C53AD1 VA: 0x3C539D0
	|-ObjectEqualityComparer<Vector2>.Equals
	|
	|-RVA: 0x3C53D30 Offset: 0x3C53E31 VA: 0x3C53D30
	|-ObjectEqualityComparer<Vector3>.Equals
	|
	|-RVA: 0x3C54080 Offset: 0x3C54181 VA: 0x3C54080
	|-ObjectEqualityComparer<Vector4>.Equals
	|
	|-RVA: 0x3C543B0 Offset: 0x3C544B1 VA: 0x3C543B0
	|-ObjectEqualityComparer<VertexAttributeDescriptor>.Equals
	|
	|-RVA: 0x3C54820 Offset: 0x3C54921 VA: 0x3C54820
	|-ObjectEqualityComparer<X509ChainStatus>.Equals
	|
	|-RVA: 0x3C54C40 Offset: 0x3C54D41 VA: 0x3C54C40
	|-ObjectEqualityComparer<XPathNodeRef>.Equals
	|
	|-RVA: 0x3C55120 Offset: 0x3C55221 VA: 0x3C55120
	|-ObjectEqualityComparer<XRView>.Equals
	|
	|-RVA: 0x3C55590 Offset: 0x3C55691 VA: 0x3C55590
	|-ObjectEqualityComparer<AmiiboSequence.GainItemData>.Equals
	|
	|-RVA: 0x3C55A90 Offset: 0x3C55B91 VA: 0x3C55A90
	|-ObjectEqualityComparer<AnimationOutputWeightProcessor.WeightInfo>.Equals
	|
	|-RVA: 0x3C55F00 Offset: 0x3C56001 VA: 0x3C55F00
	|-ObjectEqualityComparer<ArenaOrderSequence.GodInfo>.Equals
	|
	|-RVA: 0x3C56370 Offset: 0x3C56471 VA: 0x3C56370
	|-ObjectEqualityComparer<BattleInfo.SupportData>.Equals
	|
	|-RVA: 0x3C567E0 Offset: 0x3C568E1 VA: 0x3C567E0
	|-ObjectEqualityComparer<BeforeRenderHelper.OrderBlock>.Equals
	|
	|-RVA: 0x3C56CB0 Offset: 0x3C56DB1 VA: 0x3C56CB0
	|-ObjectEqualityComparer<Camera.RenderRequest>.Equals
	|
	|-RVA: 0x3C57120 Offset: 0x3C57221 VA: 0x3C57120
	|-ObjectEqualityComparer<CameraState.CustomBlendable>.Equals
	|
	|-RVA: 0x3C57580 Offset: 0x3C57681 VA: 0x3C57580
	|-ObjectEqualityComparer<CinemachineClearShot.Pair>.Equals
	|
	|-RVA: 0x3C579E0 Offset: 0x3C57AE1 VA: 0x3C579E0
	|-ObjectEqualityComparer<CinemachineStateDrivenCamera.HashPair>.Equals
	|
	|-RVA: 0x3C57EB0 Offset: 0x3C57FB1 VA: 0x3C57EB0
	|-ObjectEqualityComparer<DelayedActionManager.DelegateInfo>.Equals
	|
	|-RVA: 0x3C583B0 Offset: 0x3C584B1 VA: 0x3C583B0
	|-ObjectEqualityComparer<Detail.AsyncResultInt>.Equals
	|
	|-RVA: 0x3C58820 Offset: 0x3C58921 VA: 0x3C58820
	|-ObjectEqualityComparer<Detail.CppArray>.Equals
	|
	|-RVA: 0x3C58D20 Offset: 0x3C58E21 VA: 0x3C58D20
	|-ObjectEqualityComparer<Detail.NotificationEventInt>.Equals
	|
	|-RVA: 0x3C59190 Offset: 0x3C59291 VA: 0x3C59190
	|-ObjectEqualityComparer<DragonRideTargetGroup.ChainParam>.Equals
	|
	|-RVA: 0x3C595F0 Offset: 0x3C596F1 VA: 0x3C595F0
	|-ObjectEqualityComparer<DynamicMesh.State>.Equals
	|
	|-RVA: 0x3C59A60 Offset: 0x3C59B61 VA: 0x3C59A60
	|-ObjectEqualityComparer<GameVariable.Value>.Equals
	|
	|-RVA: 0x3C59F30 Offset: 0x3C5A031 VA: 0x3C59F30
	|-ObjectEqualityComparer<GmapPathAdjuster.TargetModel>.Equals
	|
	|-RVA: 0x3C5A400 Offset: 0x3C5A501 VA: 0x3C5A400
	|-ObjectEqualityComparer<GmapSpotAdjuster.TargetModel>.Equals
	|
	|-RVA: 0x3C5A8D0 Offset: 0x3C5A9D1 VA: 0x3C5A8D0
	|-ObjectEqualityComparer<HubFastTravel.Location>.Equals
	|
	|-RVA: 0x3C5ADD0 Offset: 0x3C5AED1 VA: 0x3C5ADD0
	|-ObjectEqualityComparer<HubLensFlare.Flare>.Equals
	|
	|-RVA: 0x3C5B240 Offset: 0x3C5B341 VA: 0x3C5B240
	|-ObjectEqualityComparer<InventoryPoolItemMenuContent.KindBgNameClass>.Equals
	|
	|-RVA: 0x3C5B6A0 Offset: 0x3C5B7A1 VA: 0x3C5B6A0
	|-ObjectEqualityComparer<Map.Pos>.Equals
	|
	|-RVA: 0x3C5BB10 Offset: 0x3C5BC11 VA: 0x3C5BB10
	|-ObjectEqualityComparer<MapImage.BackupTerrain>.Equals
	|
	|-RVA: 0x3C5BF70 Offset: 0x3C5C071 VA: 0x3C5BF70
	|-ObjectEqualityComparer<MapImageRange.Pos>.Equals
	|
	|-RVA: 0x3C5C4E0 Offset: 0x3C5C5E1 VA: 0x3C5C4E0
	|-ObjectEqualityComparer<MapMind.Record>.Equals
	|
	|-RVA: 0x3C5C9B0 Offset: 0x3C5CAB1 VA: 0x3C5C9B0
	|-ObjectEqualityComparer<MapMind.Target>.Equals
	|
	|-RVA: 0x36FD210 Offset: 0x36FD311 VA: 0x36FD210
	|-ObjectEqualityComparer<MapPanelDebug.Entity>.Equals
	|
	|-RVA: 0x36FD670 Offset: 0x36FD771 VA: 0x36FD670
	|-ObjectEqualityComparer<NexRanking.Data>.Equals
	|
	|-RVA: 0x36FDAE0 Offset: 0x36FDBE1 VA: 0x36FDAE0
	|-ObjectEqualityComparer<NexVersus.RatingData>.Equals
	|
	|-RVA: 0x36FDF50 Offset: 0x36FE051 VA: 0x36FDF50
	|-ObjectEqualityComparer<PackedPlayModeBuildLogs.RuntimeBuildLog>.Equals
	|
	|-RVA: 0x36FE430 Offset: 0x36FE531 VA: 0x36FE430
	|-ObjectEqualityComparer<ParticleSystem.Particle>.Equals
	|
	|-RVA: 0x36FE930 Offset: 0x36FEA31 VA: 0x36FE930
	|-ObjectEqualityComparer<QualitySettingsStack.Settings>.Equals
	|
	|-RVA: 0x36FED90 Offset: 0x36FEE91 VA: 0x36FED90
	|-ObjectEqualityComparer<RangeData.Offset>.Equals
	|
	|-RVA: 0x36FF260 Offset: 0x36FF361 VA: 0x36FF260
	|-ObjectEqualityComparer<RenderGraphDebugData.PassDebugData>.Equals
	|
	|-RVA: 0x36FF760 Offset: 0x36FF861 VA: 0x36FF760
	|-ObjectEqualityComparer<RenderGraphDebugData.ResourceDebugData>.Equals
	|
	|-RVA: 0x36FFBD0 Offset: 0x36FFCD1 VA: 0x36FFBD0
	|-ObjectEqualityComparer<RingCleaningUnitSelectMenu.GodParam>.Equals
	|
	|-RVA: 0x37000D0 Offset: 0x37001D1 VA: 0x37000D0
	|-ObjectEqualityComparer<SequenceNode.SequenceConstructPosContext>.Equals
	|
	|-RVA: 0x37005D0 Offset: 0x37006D1 VA: 0x37005D0
	|-ObjectEqualityComparer<ShadowUtility.Edge>.Equals
	|
	|-RVA: 0x3700A40 Offset: 0x3700B41 VA: 0x3700A40
	|-ObjectEqualityComparer<SimpleAnimationPlayable.QueuedState>.Equals
	|
	|-RVA: 0x3700EA0 Offset: 0x3700FA1 VA: 0x3700EA0
	|-ObjectEqualityComparer<SkillArray.Entity>.Equals
	|
	|-RVA: 0x3701330 Offset: 0x3701431 VA: 0x3701330
	|-ObjectEqualityComparer<Stream.Info>.Equals
	|
	|-RVA: 0x3701870 Offset: 0x3701971 VA: 0x3701870
	|-ObjectEqualityComparer<TexturePacker_JsonArray.Frame>.Equals
	|
	|-RVA: 0x3701D40 Offset: 0x3701E41 VA: 0x3701D40
	|-ObjectEqualityComparer<TimeNotificationBehaviour.NotificationEntry>.Equals
	|
	|-RVA: 0x3702210 Offset: 0x3702311 VA: 0x3702210
	|-ObjectEqualityComparer<UnitySynchronizationContext.WorkRequest>.Equals
	|
	|-RVA: 0x3702680 Offset: 0x3702781 VA: 0x3702680
	|-ObjectEqualityComparer<XmlSchemaObjectTable.XmlSchemaObjectEntry>.Equals
	|
	|-RVA: 0x3702AE0 Offset: 0x3702BE1 VA: 0x3702AE0
	|-ObjectEqualityComparer<AIThink.EnchantThink.SurroundingInfo>.Equals
	|
	|-RVA: 0x3702F50 Offset: 0x3703051 VA: 0x3702F50
	|-ObjectEqualityComparer<AssetBundleBuildMap.AssetBundleEntry.AssetPathString>.Equals
	|
	|-RVA: 0x3703430 Offset: 0x3703531 VA: 0x3703430
	|-ObjectEqualityComparer<Detail.DataStore.DataStoreChangeMetaParamInt>.Equals
	|
	|-RVA: 0x37038A0 Offset: 0x37039A1 VA: 0x37038A0
	|-ObjectEqualityComparer<Detail.DataStore.DataStoreDeleteParamInt>.Equals
	|
	|-RVA: 0x3703DA0 Offset: 0x3703EA1 VA: 0x3703DA0
	|-ObjectEqualityComparer<Detail.DataStore.DataStoreGetMetaParamInt>.Equals
	|
	|-RVA: 0x3704280 Offset: 0x3704381 VA: 0x3704280
	|-ObjectEqualityComparer<Detail.DataStore.DataStoreMetaInfoInt>.Equals
	|
	|-RVA: 0x3704750 Offset: 0x3704851 VA: 0x3704750
	|-ObjectEqualityComparer<Detail.DataStore.DataStorePasswordInfoInt>.Equals
	|
	|-RVA: 0x3704C20 Offset: 0x3704D21 VA: 0x3704C20
	|-ObjectEqualityComparer<Detail.DataStore.DataStorePersistenceInfoInt>.Equals
	|
	|-RVA: 0x3705100 Offset: 0x3705201 VA: 0x3705100
	|-ObjectEqualityComparer<Detail.DataStore.DataStorePreparePostParamInt>.Equals
	|
	|-RVA: 0x3705570 Offset: 0x3705671 VA: 0x3705570
	|-ObjectEqualityComparer<Detail.DataStore.DataStoreRateObjectParamInt>.Equals
	|
	|-RVA: 0x3705A40 Offset: 0x3705B41 VA: 0x3705A40
	|-ObjectEqualityComparer<Detail.DataStore.DataStoreRatingInitParamInt>.Equals
	|
	|-RVA: 0x3705EB0 Offset: 0x3705FB1 VA: 0x3705EB0
	|-ObjectEqualityComparer<Detail.DataStore.DataStoreRatingTargetInt>.Equals
	|
	|-RVA: 0x37063F0 Offset: 0x37064F1 VA: 0x37063F0
	|-ObjectEqualityComparer<Detail.Ranking.RankingCachedResultInt>.Equals
	|
	|-RVA: 0x3706860 Offset: 0x3706961 VA: 0x3706860
	|-ObjectEqualityComparer<Detail.Ranking.RankingOrderParamInt>.Equals
	|
	|-RVA: 0x3706DA0 Offset: 0x3706EA1 VA: 0x3706DA0
	|-ObjectEqualityComparer<Detail.Ranking.RankingRankDataInt>.Equals
	|
	|-RVA: 0x3707350 Offset: 0x3707451 VA: 0x3707350
	|-ObjectEqualityComparer<Detail.Ranking2.Ranking2ChartInfoInt>.Equals
	|
	|-RVA: 0x3707890 Offset: 0x3707991 VA: 0x3707890
	|-ObjectEqualityComparer<Detail.Ranking2.Ranking2RankDataInt>.Equals
	|
	|-RVA: 0x3707D00 Offset: 0x3707E01 VA: 0x3707D00
	|-ObjectEqualityComparer<Detail.Ranking2.Ranking2ScoreDataInt>.Equals
	|
	|-RVA: 0x37081D0 Offset: 0x37082D1 VA: 0x37081D0
	|-ObjectEqualityComparer<Detail.Screening.ScreeningContextInfoInt>.Equals
	|
	|-RVA: 0x3708740 Offset: 0x3708841 VA: 0x3708740
	|-ObjectEqualityComparer<Detail.Subscriber.SubscriberContentInt>.Equals
	|
	|-RVA: 0x3708C10 Offset: 0x3708D11 VA: 0x3708C10
	|-ObjectEqualityComparer<Detail.Subscriber.SubscriberGetContentParamInt>.Equals
	|
	|-RVA: 0x3709110 Offset: 0x3709211 VA: 0x3709110
	|-ObjectEqualityComparer<Detail.Subscriber.SubscriberUserStatusInfoInt>.Equals
	|
	|-RVA: 0x37095E0 Offset: 0x37096E1 VA: 0x37095E0
	|-ObjectEqualityComparer<Detail.Subscriber.SubscriberUserStatusParamInt>.Equals
	|
	|-RVA: 0x3709A40 Offset: 0x3709B41 VA: 0x3709A40
	|-ObjectEqualityComparer<Detail.Utility.IntegerSettings>.Equals
	|
	|-RVA: 0x3709EB0 Offset: 0x3709FB1 VA: 0x3709EB0
	|-ObjectEqualityComparer<Detail.Utility.UniqueIdInfoInt>.Equals
	|
	|-RVA: 0x370A360 Offset: 0x370A461 VA: 0x370A360
	|-ObjectEqualityComparer<MapHistory.Rewind.LatestInspectorData>.Equals
	|
	|-RVA: 0x370A810 Offset: 0x370A911 VA: 0x370A810
	|-ObjectEqualityComparer<MapHistory.Rewind.WorkTerrainData>.Equals
	|
	|-RVA: 0x370AC80 Offset: 0x370AD81 VA: 0x370AC80
	|-ObjectEqualityComparer<MapSkill.AroundCalculator.Result>.Equals
	|
	|-RVA: 0x370B180 Offset: 0x370B281 VA: 0x370B180
	|-ObjectEqualityComparer<TargetPositionCache.CacheCurve.Item>.Equals
	|
	|-RVA: 0x370B6C0 Offset: 0x370B7C1 VA: 0x370B6C0
	|-ObjectEqualityComparer<TargetPositionCache.CacheEntry.RecordingItem>.Equals
	|
	|-RVA: 0x370BB20 Offset: 0x370BC21 VA: 0x370BB20
	|-ObjectEqualityComparer<TerrainUtility.TerrainMap.TileCoord>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public override int GetHashCode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BA6140 Offset: 0x2BA6241 VA: 0x2BA6140
	|-ObjectEqualityComparer<AsyncOperationHandle<object>>.GetHashCode
	|
	|-RVA: 0x2BA6610 Offset: 0x2BA6711 VA: 0x2BA6610
	|-ObjectEqualityComparer<IntervalTree.Entry<object>>.GetHashCode
	|
	|-RVA: 0x2BA6A80 Offset: 0x2BA6B81 VA: 0x2BA6A80
	|-ObjectEqualityComparer<KeyValuePair<DateTime, object>>.GetHashCode
	|
	|-RVA: 0x2BA6EF0 Offset: 0x2BA6FF1 VA: 0x2BA6EF0
	|-ObjectEqualityComparer<KeyValuePair<int, object>>.GetHashCode
	|
	|-RVA: 0x2BA73C0 Offset: 0x2BA74C1 VA: 0x2BA73C0
	|-ObjectEqualityComparer<KeyValuePair<object, ValueTuple<int, DateTime, object>>>.GetHashCode
	|
	|-RVA: 0x2BA7830 Offset: 0x2BA7931 VA: 0x2BA7830
	|-ObjectEqualityComparer<KeyValuePair<object, object>>.GetHashCode
	|
	|-RVA: 0x2BA7D00 Offset: 0x2BA7E01 VA: 0x2BA7D00
	|-ObjectEqualityComparer<CommonBattleSequence.Reliance<object>>.GetHashCode
	|
	|-RVA: 0x2BA8170 Offset: 0x2BA8271 VA: 0x2BA8170
	|-ObjectEqualityComparer<RenderGraphResourcePool.ResourceLogInfo<object>>.GetHashCode
	|
	|-RVA: 0x2BA85A0 Offset: 0x2BA86A1 VA: 0x2BA85A0
	|-ObjectEqualityComparer<TimeInterval<object>>.GetHashCode
	|
	|-RVA: 0x2BA8A40 Offset: 0x2BA8B41 VA: 0x2BA8A40
	|-ObjectEqualityComparer<Timestamped<object>>.GetHashCode
	|
	|-RVA: 0x2BA8EA0 Offset: 0x2BA8FA1 VA: 0x2BA8EA0
	|-ObjectEqualityComparer<UniTask<object>>.GetHashCode
	|
	|-RVA: 0x2BA92D0 Offset: 0x2BA93D1 VA: 0x2BA92D0
	|-ObjectEqualityComparer<ValueTuple<ValueTuple<bool, object>>>.GetHashCode
	|
	|-RVA: 0x2BA9780 Offset: 0x2BA9881 VA: 0x2BA9780
	|-ObjectEqualityComparer<ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>.GetHashCode
	|
	|-RVA: 0x2BA9C30 Offset: 0x2BA9D31 VA: 0x2BA9C30
	|-ObjectEqualityComparer<ValueTuple<bool, UniTask<object>>>.GetHashCode
	|
	|-RVA: 0x2BAA0E0 Offset: 0x2BAA1E1 VA: 0x2BAA0E0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>.GetHashCode
	|
	|-RVA: 0x2BAA5D0 Offset: 0x2BAA6D1 VA: 0x2BAA5D0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>>.GetHashCode
	|
	|-RVA: 0x2BAAAD0 Offset: 0x2BAABD1 VA: 0x2BAAAD0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>>>.GetHashCode
	|
	|-RVA: 0x2BAAF30 Offset: 0x2BAB031 VA: 0x2BAAF30
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>>>.GetHashCode
	|
	|-RVA: 0x2BAB390 Offset: 0x2BAB491 VA: 0x2BAB390
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>>>.GetHashCode
	|
	|-RVA: 0x2BAB8F0 Offset: 0x2BAB9F1 VA: 0x2BAB8F0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>>>.GetHashCode
	|
	|-RVA: 0x2BABD50 Offset: 0x2BABE51 VA: 0x2BABD50
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>>>.GetHashCode
	|
	|-RVA: 0x2BAC290 Offset: 0x2BAC391 VA: 0x2BAC290
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>>>.GetHashCode
	|
	|-RVA: 0x2BAC790 Offset: 0x2BAC891 VA: 0x2BAC790
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>>>.GetHashCode
	|
	|-RVA: 0x3A56B30 Offset: 0x3A56C31 VA: 0x3A56B30
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>>>.GetHashCode
	|
	|-RVA: 0x3A57030 Offset: 0x3A57131 VA: 0x3A57030
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>>>.GetHashCode
	|
	|-RVA: 0x3A57530 Offset: 0x3A57631 VA: 0x3A57530
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>>>.GetHashCode
	|
	|-RVA: 0x3A57A70 Offset: 0x3A57B71 VA: 0x3A57A70
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>>>.GetHashCode
	|
	|-RVA: 0x3A57FB0 Offset: 0x3A580B1 VA: 0x3A57FB0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>>>.GetHashCode
	|
	|-RVA: 0x3A58460 Offset: 0x3A58561 VA: 0x3A58460
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>>>.GetHashCode
	|
	|-RVA: 0x3A58960 Offset: 0x3A58A61 VA: 0x3A58960
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>>>.GetHashCode
	|
	|-RVA: 0x3A58DC0 Offset: 0x3A58EC1 VA: 0x3A58DC0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>>>.GetHashCode
	|
	|-RVA: 0x3A592B0 Offset: 0x3A593B1 VA: 0x3A592B0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>>>.GetHashCode
	|
	|-RVA: 0x3A59760 Offset: 0x3A59861 VA: 0x3A59760
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>>>.GetHashCode
	|
	|-RVA: 0x3A59CA0 Offset: 0x3A59DA1 VA: 0x3A59CA0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>>>.GetHashCode
	|
	|-RVA: 0x3A5A1A0 Offset: 0x3A5A2A1 VA: 0x3A5A1A0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>>>.GetHashCode
	|
	|-RVA: 0x3A5A6A0 Offset: 0x3A5A7A1 VA: 0x3A5A6A0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>>>.GetHashCode
	|
	|-RVA: 0x3A5AC00 Offset: 0x3A5AD01 VA: 0x3A5AC00
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>>>.GetHashCode
	|
	|-RVA: 0x3A5B160 Offset: 0x3A5B261 VA: 0x3A5B160
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>>>.GetHashCode
	|
	|-RVA: 0x3A5B700 Offset: 0x3A5B801 VA: 0x3A5B700
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>>>.GetHashCode
	|
	|-RVA: 0x3A5BCB0 Offset: 0x3A5BDB1 VA: 0x3A5BCB0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>>>.GetHashCode
	|
	|-RVA: 0x3A5C2C0 Offset: 0x3A5C3C1 VA: 0x3A5C2C0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>>>.GetHashCode
	|
	|-RVA: 0x3A5C730 Offset: 0x3A5C831 VA: 0x3A5C730
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>>.GetHashCode
	|
	|-RVA: 0x3A5CBA0 Offset: 0x3A5CCA1 VA: 0x3A5CBA0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>>.GetHashCode
	|
	|-RVA: 0x3A5D090 Offset: 0x3A5D191 VA: 0x3A5D090
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>>.GetHashCode
	|
	|-RVA: 0x3A5D500 Offset: 0x3A5D601 VA: 0x3A5D500
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>>.GetHashCode
	|
	|-RVA: 0x3A5D9B0 Offset: 0x3A5DAB1 VA: 0x3A5D9B0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>>.GetHashCode
	|
	|-RVA: 0x3A5DEA0 Offset: 0x3A5DFA1 VA: 0x3A5DEA0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>>.GetHashCode
	|
	|-RVA: 0x3A5E350 Offset: 0x3A5E451 VA: 0x3A5E350
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>>.GetHashCode
	|
	|-RVA: 0x3A5E840 Offset: 0x3A5E941 VA: 0x3A5E840
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>>.GetHashCode
	|
	|-RVA: 0x3A5ED30 Offset: 0x3A5EE31 VA: 0x3A5ED30
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>>.GetHashCode
	|
	|-RVA: 0x3A5F1E0 Offset: 0x3A5F2E1 VA: 0x3A5F1E0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>>.GetHashCode
	|
	|-RVA: 0x3A5F690 Offset: 0x3A5F791 VA: 0x3A5F690
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>>.GetHashCode
	|
	|-RVA: 0x3A5FB40 Offset: 0x3A5FC41 VA: 0x3A5FB40
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>>.GetHashCode
	|
	|-RVA: 0x3A60030 Offset: 0x3A60131 VA: 0x3A60030
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>>.GetHashCode
	|
	|-RVA: 0x3A604A0 Offset: 0x3A605A1 VA: 0x3A604A0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>>.GetHashCode
	|
	|-RVA: 0x3A60950 Offset: 0x3A60A51 VA: 0x3A60950
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>>.GetHashCode
	|
	|-RVA: 0x3A60E40 Offset: 0x3A60F41 VA: 0x3A60E40
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>>.GetHashCode
	|
	|-RVA: 0x3A612F0 Offset: 0x3A613F1 VA: 0x3A612F0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>>.GetHashCode
	|
	|-RVA: 0x3A617E0 Offset: 0x3A618E1 VA: 0x3A617E0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>>.GetHashCode
	|
	|-RVA: 0x3A61CD0 Offset: 0x3A61DD1 VA: 0x3A61CD0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>>.GetHashCode
	|
	|-RVA: 0x3A62230 Offset: 0x3A62331 VA: 0x3A62230
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.GetHashCode
	|
	|-RVA: 0x3A62730 Offset: 0x3A62831 VA: 0x3A62730
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>>.GetHashCode
	|
	|-RVA: 0x3A62CE0 Offset: 0x3A62DE1 VA: 0x3A62CE0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.GetHashCode
	|
	|-RVA: 0x3A63240 Offset: 0x3A63341 VA: 0x3A63240
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>>.GetHashCode
	|
	|-RVA: 0x3A63850 Offset: 0x3A63951 VA: 0x3A63850
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.GetHashCode
	|
	|-RVA: 0x3A63DB0 Offset: 0x3A63EB1 VA: 0x3A63DB0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>>.GetHashCode
	|
	|-RVA: 0x3A64410 Offset: 0x3A64511 VA: 0x3A64410
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.GetHashCode
	|
	|-RVA: 0x3A649B0 Offset: 0x3A64AB1 VA: 0x3A649B0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>>.GetHashCode
	|
	|-RVA: 0x3A65070 Offset: 0x3A65171 VA: 0x3A65070
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.GetHashCode
	|
	|-RVA: 0x3A65620 Offset: 0x3A65721 VA: 0x3A65620
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>>.GetHashCode
	|
	|-RVA: 0x3A65A30 Offset: 0x3A65B31 VA: 0x3A65A30
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>.GetHashCode
	|
	|-RVA: 0x3A65E40 Offset: 0x3A65F41 VA: 0x3A65E40
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>.GetHashCode
	|
	|-RVA: 0x3A66380 Offset: 0x3A66481 VA: 0x3A66380
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>.GetHashCode
	|
	|-RVA: 0x3A66790 Offset: 0x3A66891 VA: 0x3A66790
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>.GetHashCode
	|
	|-RVA: 0x3A66C80 Offset: 0x3A66D81 VA: 0x3A66C80
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>.GetHashCode
	|
	|-RVA: 0x3A67130 Offset: 0x3A67231 VA: 0x3A67130
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>.GetHashCode
	|
	|-RVA: 0x3A67560 Offset: 0x3A67661 VA: 0x3A67560
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>.GetHashCode
	|
	|-RVA: 0x3A67A10 Offset: 0x3A67B11 VA: 0x3A67A10
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>.GetHashCode
	|
	|-RVA: 0x3A67EC0 Offset: 0x3A67FC1 VA: 0x3A67EC0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>.GetHashCode
	|
	|-RVA: 0x3A683B0 Offset: 0x3A684B1 VA: 0x3A683B0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>.GetHashCode
	|
	|-RVA: 0x3A688A0 Offset: 0x3A689A1 VA: 0x3A688A0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>.GetHashCode
	|
	|-RVA: 0x3A68CD0 Offset: 0x3A68DD1 VA: 0x3A68CD0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>.GetHashCode
	|
	|-RVA: 0x3A69180 Offset: 0x3A69281 VA: 0x3A69180
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>.GetHashCode
	|
	|-RVA: 0x3A69590 Offset: 0x3A69691 VA: 0x3A69590
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>.GetHashCode
	|
	|-RVA: 0x3A69A40 Offset: 0x3A69B41 VA: 0x3A69A40
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>.GetHashCode
	|
	|-RVA: 0x3A69EF0 Offset: 0x3A69FF1 VA: 0x3A69EF0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>.GetHashCode
	|
	|-RVA: 0x3A6A3E0 Offset: 0x3A6A4E1 VA: 0x3A6A3E0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>.GetHashCode
	|
	|-RVA: 0x3A6A890 Offset: 0x3A6A991 VA: 0x3A6A890
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>.GetHashCode
	|
	|-RVA: 0x3A6AD40 Offset: 0x3A6AE41 VA: 0x3A6AD40
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>.GetHashCode
	|
	|-RVA: 0x3A6B2A0 Offset: 0x3A6B3A1 VA: 0x3A6B2A0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.GetHashCode
	|
	|-RVA: 0x3A6B790 Offset: 0x3A6B891 VA: 0x3A6B790
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>.GetHashCode
	|
	|-RVA: 0x3A6BD30 Offset: 0x3A6BE31 VA: 0x3A6BD30
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.GetHashCode
	|
	|-RVA: 0x3A6C230 Offset: 0x3A6C331 VA: 0x3A6C230
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>.GetHashCode
	|
	|-RVA: 0x3A6C840 Offset: 0x3A6C941 VA: 0x3A6C840
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.GetHashCode
	|
	|-RVA: 0x3A6CDA0 Offset: 0x3A6CEA1 VA: 0x3A6CDA0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>.GetHashCode
	|
	|-RVA: 0x3A6D3F0 Offset: 0x3A6D4F1 VA: 0x3A6D3F0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.GetHashCode
	|
	|-RVA: 0x3A6D950 Offset: 0x3A6DA51 VA: 0x3A6D950
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>.GetHashCode
	|
	|-RVA: 0x3A6E010 Offset: 0x3A6E111 VA: 0x3A6E010
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.GetHashCode
	|
	|-RVA: 0x3A6E5B0 Offset: 0x3A6E6B1 VA: 0x3A6E5B0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>.GetHashCode
	|
	|-RVA: 0x3A6EA80 Offset: 0x3A6EB81 VA: 0x3A6EA80
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>>>.GetHashCode
	|
	|-RVA: 0x3A6EF50 Offset: 0x3A6F051 VA: 0x3A6EF50
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.GetHashCode
	|
	|-RVA: 0x3A6F3C0 Offset: 0x3A6F4C1 VA: 0x3A6F3C0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>.GetHashCode
	|
	|-RVA: 0x3A6F830 Offset: 0x3A6F931 VA: 0x3A6F830
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, bool>>>.GetHashCode
	|
	|-RVA: 0x3A6FCE0 Offset: 0x3A6FDE1 VA: 0x3A6FCE0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, Bounds>>>.GetHashCode
	|
	|-RVA: 0x3A70150 Offset: 0x3A70251 VA: 0x3A70150
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, byte>>>.GetHashCode
	|
	|-RVA: 0x3A70600 Offset: 0x3A70701 VA: 0x3A70600
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, Color>>>.GetHashCode
	|
	|-RVA: 0x3A70AB0 Offset: 0x3A70BB1 VA: 0x3A70AB0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, double>>>.GetHashCode
	|
	|-RVA: 0x3C2F480 Offset: 0x3C2F581 VA: 0x3C2F480
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, int>>>.GetHashCode
	|
	|-RVA: 0x3C2F930 Offset: 0x3C2FA31 VA: 0x3C2F930
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, long>>>.GetHashCode
	|
	|-RVA: 0x3C2FDE0 Offset: 0x3C2FEE1 VA: 0x3C2FDE0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, object>>>.GetHashCode
	|
	|-RVA: 0x3C30290 Offset: 0x3C30391 VA: 0x3C30290
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, Quaternion>>>.GetHashCode
	|
	|-RVA: 0x3C30740 Offset: 0x3C30841 VA: 0x3C30740
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, Rect>>>.GetHashCode
	|
	|-RVA: 0x3C30BB0 Offset: 0x3C30CB1 VA: 0x3C30BB0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, float>>>.GetHashCode
	|
	|-RVA: 0x3C31060 Offset: 0x3C31161 VA: 0x3C31060
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, UniTask>>>.GetHashCode
	|
	|-RVA: 0x3C314D0 Offset: 0x3C315D1 VA: 0x3C314D0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, Unit>>>.GetHashCode
	|
	|-RVA: 0x3C31900 Offset: 0x3C31A01 VA: 0x3C31900
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, Vector2>>>.GetHashCode
	|
	|-RVA: 0x3C31DB0 Offset: 0x3C31EB1 VA: 0x3C31DB0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, Vector3>>>.GetHashCode
	|
	|-RVA: 0x3C32260 Offset: 0x3C32361 VA: 0x3C32260
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, Vector4>>>.GetHashCode
	|
	|-RVA: 0x3C32710 Offset: 0x3C32811 VA: 0x3C32710
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<int, object>>>.GetHashCode
	|
	|-RVA: 0x3C32BC0 Offset: 0x3C32CC1 VA: 0x3C32BC0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<object, object>>>.GetHashCode
	|
	|-RVA: 0x3C330C0 Offset: 0x3C331C1 VA: 0x3C330C0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.GetHashCode
	|
	|-RVA: 0x3C33570 Offset: 0x3C33671 VA: 0x3C33570
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<object, object, object>>>.GetHashCode
	|
	|-RVA: 0x3C33AD0 Offset: 0x3C33BD1 VA: 0x3C33AD0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.GetHashCode
	|
	|-RVA: 0x3C33FC0 Offset: 0x3C340C1 VA: 0x3C33FC0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<object, object, object, object>>>.GetHashCode
	|
	|-RVA: 0x3C34570 Offset: 0x3C34671 VA: 0x3C34570
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.GetHashCode
	|
	|-RVA: 0x3C34A70 Offset: 0x3C34B71 VA: 0x3C34A70
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<object, object, object, object, object>>>.GetHashCode
	|
	|-RVA: 0x3C35080 Offset: 0x3C35181 VA: 0x3C35080
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.GetHashCode
	|
	|-RVA: 0x3C355E0 Offset: 0x3C356E1 VA: 0x3C355E0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>.GetHashCode
	|
	|-RVA: 0x3C35C40 Offset: 0x3C35D41 VA: 0x3C35C40
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.GetHashCode
	|
	|-RVA: 0x3C361A0 Offset: 0x3C362A1 VA: 0x3C361A0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>.GetHashCode
	|
	|-RVA: 0x3C36860 Offset: 0x3C36961 VA: 0x3C36860
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>>.GetHashCode
	|
	|-RVA: 0x3C36D30 Offset: 0x3C36E31 VA: 0x3C36D30
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.GetHashCode
	|
	|-RVA: 0x3C37140 Offset: 0x3C37241 VA: 0x3C37140
	|-ObjectEqualityComparer<ValueTuple<bool, AsyncUnit>>.GetHashCode
	|
	|-RVA: 0x3C37550 Offset: 0x3C37651 VA: 0x3C37550
	|-ObjectEqualityComparer<ValueTuple<bool, bool>>.GetHashCode
	|
	|-RVA: 0x3C37A40 Offset: 0x3C37B41 VA: 0x3C37A40
	|-ObjectEqualityComparer<ValueTuple<bool, Bounds>>.GetHashCode
	|
	|-RVA: 0x3C37E50 Offset: 0x3C37F51 VA: 0x3C37E50
	|-ObjectEqualityComparer<ValueTuple<bool, byte>>.GetHashCode
	|
	|-RVA: 0x3C38300 Offset: 0x3C38401 VA: 0x3C38300
	|-ObjectEqualityComparer<ValueTuple<bool, Color>>.GetHashCode
	|
	|-RVA: 0x3C38730 Offset: 0x3C38831 VA: 0x3C38730
	|-ObjectEqualityComparer<ValueTuple<bool, double>>.GetHashCode
	|
	|-RVA: 0x3C38B40 Offset: 0x3C38C41 VA: 0x3C38B40
	|-ObjectEqualityComparer<ValueTuple<bool, int>>.GetHashCode
	|
	|-RVA: 0x3C38F70 Offset: 0x3C39071 VA: 0x3C38F70
	|-ObjectEqualityComparer<ValueTuple<bool, long>>.GetHashCode
	|
	|-RVA: 0x3C393A0 Offset: 0x3C394A1 VA: 0x3C393A0
	|-ObjectEqualityComparer<ValueTuple<bool, object>>.GetHashCode
	|
	|-RVA: 0x3C39850 Offset: 0x3C39951 VA: 0x3C39850
	|-ObjectEqualityComparer<ValueTuple<bool, Quaternion>>.GetHashCode
	|
	|-RVA: 0x3C39D00 Offset: 0x3C39E01 VA: 0x3C39D00
	|-ObjectEqualityComparer<ValueTuple<bool, Rect>>.GetHashCode
	|
	|-RVA: 0x3C3A110 Offset: 0x3C3A211 VA: 0x3C3A110
	|-ObjectEqualityComparer<ValueTuple<bool, float>>.GetHashCode
	|
	|-RVA: 0x3C3A540 Offset: 0x3C3A641 VA: 0x3C3A540
	|-ObjectEqualityComparer<ValueTuple<bool, UniTask>>.GetHashCode
	|
	|-RVA: 0x3C3A950 Offset: 0x3C3AA51 VA: 0x3C3A950
	|-ObjectEqualityComparer<ValueTuple<bool, Unit>>.GetHashCode
	|
	|-RVA: 0x3C3ADC0 Offset: 0x3C3AEC1 VA: 0x3C3ADC0
	|-ObjectEqualityComparer<ValueTuple<bool, Vector2>>.GetHashCode
	|
	|-RVA: 0x3C3B1F0 Offset: 0x3C3B2F1 VA: 0x3C3B1F0
	|-ObjectEqualityComparer<ValueTuple<bool, Vector3>>.GetHashCode
	|
	|-RVA: 0x3C3B6A0 Offset: 0x3C3B7A1 VA: 0x3C3B6A0
	|-ObjectEqualityComparer<ValueTuple<bool, Vector4>>.GetHashCode
	|
	|-RVA: 0x3C3BAC0 Offset: 0x3C3BBC1 VA: 0x3C3BAC0
	|-ObjectEqualityComparer<ValueTuple<int, object>>.GetHashCode
	|
	|-RVA: 0x3C3BED0 Offset: 0x3C3BFD1 VA: 0x3C3BED0
	|-ObjectEqualityComparer<ValueTuple<Int32Enum, int>>.GetHashCode
	|
	|-RVA: 0x3C3C370 Offset: 0x3C3C471 VA: 0x3C3C370
	|-ObjectEqualityComparer<ValueTuple<object, ValueTuple<object, int>>>.GetHashCode
	|
	|-RVA: 0x3C3C790 Offset: 0x3C3C891 VA: 0x3C3C790
	|-ObjectEqualityComparer<ValueTuple<object, int>>.GetHashCode
	|
	|-RVA: 0x3C3CBB0 Offset: 0x3C3CCB1 VA: 0x3C3CBB0
	|-ObjectEqualityComparer<ValueTuple<object, object>>.GetHashCode
	|
	|-RVA: 0x3C3CFD0 Offset: 0x3C3D0D1 VA: 0x3C3CFD0
	|-ObjectEqualityComparer<ValueTuple<object, float>>.GetHashCode
	|
	|-RVA: 0x3C3D470 Offset: 0x3C3D571 VA: 0x3C3D470
	|-ObjectEqualityComparer<ValueTuple<Vector3, float>>.GetHashCode
	|
	|-RVA: 0x3C3D960 Offset: 0x3C3DA61 VA: 0x3C3D960
	|-ObjectEqualityComparer<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>.GetHashCode
	|
	|-RVA: 0x3C3DD80 Offset: 0x3C3DE81 VA: 0x3C3DD80
	|-ObjectEqualityComparer<ValueTuple<object, Int32Enum, int>>.GetHashCode
	|
	|-RVA: 0x3C3E220 Offset: 0x3C3E321 VA: 0x3C3E220
	|-ObjectEqualityComparer<ValueTuple<object, object, object>>.GetHashCode
	|
	|-RVA: 0x3C3E770 Offset: 0x3C3E871 VA: 0x3C3E770
	|-ObjectEqualityComparer<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.GetHashCode
	|
	|-RVA: 0x3C3EC10 Offset: 0x3C3ED11 VA: 0x3C3EC10
	|-ObjectEqualityComparer<ValueTuple<object, int, int, int>>.GetHashCode
	|
	|-RVA: 0x3C3F0C0 Offset: 0x3C3F1C1 VA: 0x3C3F0C0
	|-ObjectEqualityComparer<ValueTuple<object, object, object, object>>.GetHashCode
	|
	|-RVA: 0x3C3F660 Offset: 0x3C3F761 VA: 0x3C3F660
	|-ObjectEqualityComparer<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.GetHashCode
	|
	|-RVA: 0x3C3FB50 Offset: 0x3C3FC51 VA: 0x3C3FB50
	|-ObjectEqualityComparer<ValueTuple<object, object, object, object, object>>.GetHashCode
	|
	|-RVA: 0x3C40150 Offset: 0x3C40251 VA: 0x3C40150
	|-ObjectEqualityComparer<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.GetHashCode
	|
	|-RVA: 0x3C40640 Offset: 0x3C40741 VA: 0x3C40640
	|-ObjectEqualityComparer<ValueTuple<object, object, object, object, object, object>>.GetHashCode
	|
	|-RVA: 0x3C40C90 Offset: 0x3C40D91 VA: 0x3C40C90
	|-ObjectEqualityComparer<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.GetHashCode
	|
	|-RVA: 0x3C411E0 Offset: 0x3C412E1 VA: 0x3C411E0
	|-ObjectEqualityComparer<ValueTuple<object, object, object, object, object, object, object>>.GetHashCode
	|
	|-RVA: 0x3C41890 Offset: 0x3C41991 VA: 0x3C41890
	|-ObjectEqualityComparer<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>.GetHashCode
	|
	|-RVA: 0x3C41D50 Offset: 0x3C41E51 VA: 0x3C41D50
	|-ObjectEqualityComparer<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>.GetHashCode
	|
	|-RVA: 0x3C421B0 Offset: 0x3C422B1 VA: 0x3C421B0
	|-ObjectEqualityComparer<AnimatorClipInfo>.GetHashCode
	|
	|-RVA: 0x3C42600 Offset: 0x3C42701 VA: 0x3C42600
	|-ObjectEqualityComparer<AsyncOperationHandle>.GetHashCode
	|
	|-RVA: 0x3C42A10 Offset: 0x3C42B11 VA: 0x3C42A10
	|-ObjectEqualityComparer<AsyncUnit>.GetHashCode
	|
	|-RVA: 0x3C42D20 Offset: 0x3C42E21 VA: 0x3C42D20
	|-ObjectEqualityComparer<BoneWeight>.GetHashCode
	|
	|-RVA: 0x3C43030 Offset: 0x3C43131 VA: 0x3C43030
	|-ObjectEqualityComparer<bool>.GetHashCode
	|
	|-RVA: 0x3C43340 Offset: 0x3C43441 VA: 0x3C43340
	|-ObjectEqualityComparer<Bounds>.GetHashCode
	|
	|-RVA: 0x3C43640 Offset: 0x3C43741 VA: 0x3C43640
	|-ObjectEqualityComparer<byte>.GetHashCode
	|
	|-RVA: 0x3C43AB0 Offset: 0x3C43BB1 VA: 0x3C43AB0
	|-ObjectEqualityComparer<CameraInfo>.GetHashCode
	|
	|-RVA: 0x3C43DC0 Offset: 0x3C43EC1 VA: 0x3C43DC0
	|-ObjectEqualityComparer<CancellationToken>.GetHashCode
	|
	|-RVA: 0x3C440D0 Offset: 0x3C441D1 VA: 0x3C440D0
	|-ObjectEqualityComparer<CancellationTokenRegistration>.GetHashCode
	|
	|-RVA: 0x3C443D0 Offset: 0x3C444D1 VA: 0x3C443D0
	|-ObjectEqualityComparer<char>.GetHashCode
	|
	|-RVA: 0x3C44720 Offset: 0x3C44821 VA: 0x3C44720
	|-ObjectEqualityComparer<Color>.GetHashCode
	|
	|-RVA: 0x3C44B80 Offset: 0x3C44C81 VA: 0x3C44B80
	|-ObjectEqualityComparer<Color32>.GetHashCode
	|
	|-RVA: 0x3C44EF0 Offset: 0x3C44FF1 VA: 0x3C44EF0
	|-ObjectEqualityComparer<ColorBlock>.GetHashCode
	|
	|-RVA: 0x3C45360 Offset: 0x3C45461 VA: 0x3C45360
	|-ObjectEqualityComparer<ConstraintSource>.GetHashCode
	|
	|-RVA: 0x3C45830 Offset: 0x3C45931 VA: 0x3C45830
	|-ObjectEqualityComparer<ContourVertex>.GetHashCode
	|
	|-RVA: 0x3C45D00 Offset: 0x3C45E01 VA: 0x3C45D00
	|-ObjectEqualityComparer<DataStoreRatingInfo>.GetHashCode
	|
	|-RVA: 0x3C46160 Offset: 0x3C46261 VA: 0x3C46160
	|-ObjectEqualityComparer<DataStoreResult>.GetHashCode
	|
	|-RVA: 0x3C46470 Offset: 0x3C46571 VA: 0x3C46470
	|-ObjectEqualityComparer<DateTime>.GetHashCode
	|
	|-RVA: 0x3C467A0 Offset: 0x3C468A1 VA: 0x3C467A0
	|-ObjectEqualityComparer<DateTimeOffset>.GetHashCode
	|
	|-RVA: 0x3C46AD0 Offset: 0x3C46BD1 VA: 0x3C46AD0
	|-ObjectEqualityComparer<Decimal>.GetHashCode
	|
	|-RVA: 0x3C46FD0 Offset: 0x3C470D1 VA: 0x3C46FD0
	|-ObjectEqualityComparer<DiagnosticEvent>.GetHashCode
	|
	|-RVA: 0x3C472F0 Offset: 0x3C473F1 VA: 0x3C472F0
	|-ObjectEqualityComparer<double>.GetHashCode
	|
	|-RVA: 0x3C47610 Offset: 0x3C47711 VA: 0x3C47610
	|-ObjectEqualityComparer<FXZ>.GetHashCode
	|
	|-RVA: 0x3C47AF0 Offset: 0x3C47BF1 VA: 0x3C47AF0
	|-ObjectEqualityComparer<Friend>.GetHashCode
	|
	|-RVA: 0x3C47E20 Offset: 0x3C47F21 VA: 0x3C47E20
	|-ObjectEqualityComparer<GlyphRect>.GetHashCode
	|
	|-RVA: 0x3C48150 Offset: 0x3C48251 VA: 0x3C48150
	|-ObjectEqualityComparer<Guid>.GetHashCode
	|
	|-RVA: 0x3C48450 Offset: 0x3C48551 VA: 0x3C48450
	|-ObjectEqualityComparer<short>.GetHashCode
	|
	|-RVA: 0x3C48750 Offset: 0x3C48851 VA: 0x3C48750
	|-ObjectEqualityComparer<int>.GetHashCode
	|
	|-RVA: 0x3C48B40 Offset: 0x3C48C41 VA: 0x3C48B40
	|-ObjectEqualityComparer<Int32Enum>.GetHashCode
	|
	|-RVA: 0x3C48E50 Offset: 0x3C48F51 VA: 0x3C48E50
	|-ObjectEqualityComparer<long>.GetHashCode
	|
	|-RVA: 0x3C49240 Offset: 0x3C49341 VA: 0x3C49240
	|-ObjectEqualityComparer<Int64Enum>.GetHashCode
	|
	|-RVA: 0x3C49550 Offset: 0x3C49651 VA: 0x3C49550
	|-ObjectEqualityComparer<IntPtr>.GetHashCode
	|
	|-RVA: 0x3C499C0 Offset: 0x3C49AC1 VA: 0x3C499C0
	|-ObjectEqualityComparer<InterpretedFrameInfo>.GetHashCode
	|
	|-RVA: 0x3C49E90 Offset: 0x3C49F91 VA: 0x3C49E90
	|-ObjectEqualityComparer<IntervalTreeNode>.GetHashCode
	|
	|-RVA: 0x3C4A2F0 Offset: 0x3C4A3F1 VA: 0x3C4A2F0
	|-ObjectEqualityComparer<LayerMask>.GetHashCode
	|
	|-RVA: 0x3C4A750 Offset: 0x3C4A851 VA: 0x3C4A750
	|-ObjectEqualityComparer<LengthLimitProperties>.GetHashCode
	|
	|-RVA: 0x3C4AA60 Offset: 0x3C4AB61 VA: 0x3C4AA60
	|-ObjectEqualityComparer<MapPos>.GetHashCode
	|
	|-RVA: 0x3C4ADA0 Offset: 0x3C4AEA1 VA: 0x3C4ADA0
	|-ObjectEqualityComparer<Matrix4x4>.GetHashCode
	|
	|-RVA: 0x3C4B2A0 Offset: 0x3C4B3A1 VA: 0x3C4B2A0
	|-ObjectEqualityComparer<Navigation>.GetHashCode
	|
	|-RVA: 0x3C4B570 Offset: 0x3C4B671 VA: 0x3C4B570
	|-ObjectEqualityComparer<object>.GetHashCode
	|
	|-RVA: 0x3C4BA70 Offset: 0x3C4BB71 VA: 0x3C4BA70
	|-ObjectEqualityComparer<ObjectInitializationData>.GetHashCode
	|
	|-RVA: 0x3C4BEE0 Offset: 0x3C4BFE1 VA: 0x3C4BEE0
	|-ObjectEqualityComparer<Playable>.GetHashCode
	|
	|-RVA: 0x3C4C3B0 Offset: 0x3C4C4B1 VA: 0x3C4C3B0
	|-ObjectEqualityComparer<PlayableBinding>.GetHashCode
	|
	|-RVA: 0x3C4C8B0 Offset: 0x3C4C9B1 VA: 0x3C4C8B0
	|-ObjectEqualityComparer<PlayerLoopSystem>.GetHashCode
	|
	|-RVA: 0x3C4CDB0 Offset: 0x3C4CEB1 VA: 0x3C4CDB0
	|-ObjectEqualityComparer<PlayerLoopSystemInternal>.GetHashCode
	|
	|-RVA: 0x3C4D100 Offset: 0x3C4D201 VA: 0x3C4D100
	|-ObjectEqualityComparer<Quaternion>.GetHashCode
	|
	|-RVA: 0x3C4D570 Offset: 0x3C4D671 VA: 0x3C4D570
	|-ObjectEqualityComparer<RandomSeed>.GetHashCode
	|
	|-RVA: 0x3C4D9E0 Offset: 0x3C4DAE1 VA: 0x3C4D9E0
	|-ObjectEqualityComparer<RangePositionInfo>.GetHashCode
	|
	|-RVA: 0x3C4DE40 Offset: 0x3C4DF41 VA: 0x3C4DE40
	|-ObjectEqualityComparer<Ranking2ChartInfoInput>.GetHashCode
	|
	|-RVA: 0x3C4E380 Offset: 0x3C4E481 VA: 0x3C4E380
	|-ObjectEqualityComparer<RaycastHit2D>.GetHashCode
	|
	|-RVA: 0x3C4E8F0 Offset: 0x3C4E9F1 VA: 0x3C4E8F0
	|-ObjectEqualityComparer<RaycastResult>.GetHashCode
	|
	|-RVA: 0x3C4EC40 Offset: 0x3C4ED41 VA: 0x3C4EC40
	|-ObjectEqualityComparer<Rect>.GetHashCode
	|
	|-RVA: 0x3C4F0A0 Offset: 0x3C4F1A1 VA: 0x3C4F0A0
	|-ObjectEqualityComparer<RendererListHandle>.GetHashCode
	|
	|-RVA: 0x3C4F500 Offset: 0x3C4F601 VA: 0x3C4F500
	|-ObjectEqualityComparer<ResourceHandle>.GetHashCode
	|
	|-RVA: 0x3C4F970 Offset: 0x3C4FA71 VA: 0x3C4F970
	|-ObjectEqualityComparer<ResourceLocator>.GetHashCode
	|
	|-RVA: 0x3C4FC70 Offset: 0x3C4FD71 VA: 0x3C4FC70
	|-ObjectEqualityComparer<sbyte>.GetHashCode
	|
	|-RVA: 0x3C4FF80 Offset: 0x3C50081 VA: 0x3C4FF80
	|-ObjectEqualityComparer<ShaderTagId>.GetHashCode
	|
	|-RVA: 0x3C50290 Offset: 0x3C50391 VA: 0x3C50290
	|-ObjectEqualityComparer<float>.GetHashCode
	|
	|-RVA: 0x3C50630 Offset: 0x3C50731 VA: 0x3C50630
	|-ObjectEqualityComparer<SphericalHarmonicsL2>.GetHashCode
	|
	|-RVA: 0x3C50B00 Offset: 0x3C50C01 VA: 0x3C50B00
	|-ObjectEqualityComparer<SpriteState>.GetHashCode
	|
	|-RVA: 0x3C51000 Offset: 0x3C51101 VA: 0x3C51000
	|-ObjectEqualityComparer<SubMeshDescriptor>.GetHashCode
	|
	|-RVA: 0x3C51470 Offset: 0x3C51571 VA: 0x3C51470
	|-ObjectEqualityComparer<TablePair>.GetHashCode
	|
	|-RVA: 0x3C51780 Offset: 0x3C51881 VA: 0x3C51780
	|-ObjectEqualityComparer<TimeSpan>.GetHashCode
	|
	|-RVA: 0x3C51C40 Offset: 0x3C51D41 VA: 0x3C51C40
	|-ObjectEqualityComparer<UICharInfo>.GetHashCode
	|
	|-RVA: 0x3C520B0 Offset: 0x3C521B1 VA: 0x3C520B0
	|-ObjectEqualityComparer<UILineInfo>.GetHashCode
	|
	|-RVA: 0x3C526D0 Offset: 0x3C527D1 VA: 0x3C526D0
	|-ObjectEqualityComparer<UIVertex>.GetHashCode
	|
	|-RVA: 0x3C529D0 Offset: 0x3C52AD1 VA: 0x3C529D0
	|-ObjectEqualityComparer<ushort>.GetHashCode
	|
	|-RVA: 0x3C52CD0 Offset: 0x3C52DD1 VA: 0x3C52CD0
	|-ObjectEqualityComparer<uint>.GetHashCode
	|
	|-RVA: 0x3C52FE0 Offset: 0x3C530E1 VA: 0x3C52FE0
	|-ObjectEqualityComparer<ulong>.GetHashCode
	|
	|-RVA: 0x3C533F0 Offset: 0x3C534F1 VA: 0x3C533F0
	|-ObjectEqualityComparer<UniTask>.GetHashCode
	|
	|-RVA: 0x3C53700 Offset: 0x3C53801 VA: 0x3C53700
	|-ObjectEqualityComparer<Unit>.GetHashCode
	|
	|-RVA: 0x3C53A20 Offset: 0x3C53B21 VA: 0x3C53A20
	|-ObjectEqualityComparer<Vector2>.GetHashCode
	|
	|-RVA: 0x3C53D80 Offset: 0x3C53E81 VA: 0x3C53D80
	|-ObjectEqualityComparer<Vector3>.GetHashCode
	|
	|-RVA: 0x3C540D0 Offset: 0x3C541D1 VA: 0x3C540D0
	|-ObjectEqualityComparer<Vector4>.GetHashCode
	|
	|-RVA: 0x3C54400 Offset: 0x3C54501 VA: 0x3C54400
	|-ObjectEqualityComparer<VertexAttributeDescriptor>.GetHashCode
	|
	|-RVA: 0x3C54870 Offset: 0x3C54971 VA: 0x3C54870
	|-ObjectEqualityComparer<X509ChainStatus>.GetHashCode
	|
	|-RVA: 0x3C54C90 Offset: 0x3C54D91 VA: 0x3C54C90
	|-ObjectEqualityComparer<XPathNodeRef>.GetHashCode
	|
	|-RVA: 0x3C55170 Offset: 0x3C55271 VA: 0x3C55170
	|-ObjectEqualityComparer<XRView>.GetHashCode
	|
	|-RVA: 0x3C555E0 Offset: 0x3C556E1 VA: 0x3C555E0
	|-ObjectEqualityComparer<AmiiboSequence.GainItemData>.GetHashCode
	|
	|-RVA: 0x3C55AE0 Offset: 0x3C55BE1 VA: 0x3C55AE0
	|-ObjectEqualityComparer<AnimationOutputWeightProcessor.WeightInfo>.GetHashCode
	|
	|-RVA: 0x3C55F50 Offset: 0x3C56051 VA: 0x3C55F50
	|-ObjectEqualityComparer<ArenaOrderSequence.GodInfo>.GetHashCode
	|
	|-RVA: 0x3C563C0 Offset: 0x3C564C1 VA: 0x3C563C0
	|-ObjectEqualityComparer<BattleInfo.SupportData>.GetHashCode
	|
	|-RVA: 0x3C56830 Offset: 0x3C56931 VA: 0x3C56830
	|-ObjectEqualityComparer<BeforeRenderHelper.OrderBlock>.GetHashCode
	|
	|-RVA: 0x3C56D00 Offset: 0x3C56E01 VA: 0x3C56D00
	|-ObjectEqualityComparer<Camera.RenderRequest>.GetHashCode
	|
	|-RVA: 0x3C57170 Offset: 0x3C57271 VA: 0x3C57170
	|-ObjectEqualityComparer<CameraState.CustomBlendable>.GetHashCode
	|
	|-RVA: 0x3C575D0 Offset: 0x3C576D1 VA: 0x3C575D0
	|-ObjectEqualityComparer<CinemachineClearShot.Pair>.GetHashCode
	|
	|-RVA: 0x3C57A30 Offset: 0x3C57B31 VA: 0x3C57A30
	|-ObjectEqualityComparer<CinemachineStateDrivenCamera.HashPair>.GetHashCode
	|
	|-RVA: 0x3C57F00 Offset: 0x3C58001 VA: 0x3C57F00
	|-ObjectEqualityComparer<DelayedActionManager.DelegateInfo>.GetHashCode
	|
	|-RVA: 0x3C58400 Offset: 0x3C58501 VA: 0x3C58400
	|-ObjectEqualityComparer<Detail.AsyncResultInt>.GetHashCode
	|
	|-RVA: 0x3C58870 Offset: 0x3C58971 VA: 0x3C58870
	|-ObjectEqualityComparer<Detail.CppArray>.GetHashCode
	|
	|-RVA: 0x3C58D70 Offset: 0x3C58E71 VA: 0x3C58D70
	|-ObjectEqualityComparer<Detail.NotificationEventInt>.GetHashCode
	|
	|-RVA: 0x3C591E0 Offset: 0x3C592E1 VA: 0x3C591E0
	|-ObjectEqualityComparer<DragonRideTargetGroup.ChainParam>.GetHashCode
	|
	|-RVA: 0x3C59640 Offset: 0x3C59741 VA: 0x3C59640
	|-ObjectEqualityComparer<DynamicMesh.State>.GetHashCode
	|
	|-RVA: 0x3C59AB0 Offset: 0x3C59BB1 VA: 0x3C59AB0
	|-ObjectEqualityComparer<GameVariable.Value>.GetHashCode
	|
	|-RVA: 0x3C59F80 Offset: 0x3C5A081 VA: 0x3C59F80
	|-ObjectEqualityComparer<GmapPathAdjuster.TargetModel>.GetHashCode
	|
	|-RVA: 0x3C5A450 Offset: 0x3C5A551 VA: 0x3C5A450
	|-ObjectEqualityComparer<GmapSpotAdjuster.TargetModel>.GetHashCode
	|
	|-RVA: 0x3C5A920 Offset: 0x3C5AA21 VA: 0x3C5A920
	|-ObjectEqualityComparer<HubFastTravel.Location>.GetHashCode
	|
	|-RVA: 0x3C5AE20 Offset: 0x3C5AF21 VA: 0x3C5AE20
	|-ObjectEqualityComparer<HubLensFlare.Flare>.GetHashCode
	|
	|-RVA: 0x3C5B290 Offset: 0x3C5B391 VA: 0x3C5B290
	|-ObjectEqualityComparer<InventoryPoolItemMenuContent.KindBgNameClass>.GetHashCode
	|
	|-RVA: 0x3C5B6F0 Offset: 0x3C5B7F1 VA: 0x3C5B6F0
	|-ObjectEqualityComparer<Map.Pos>.GetHashCode
	|
	|-RVA: 0x3C5BB60 Offset: 0x3C5BC61 VA: 0x3C5BB60
	|-ObjectEqualityComparer<MapImage.BackupTerrain>.GetHashCode
	|
	|-RVA: 0x3C5BFC0 Offset: 0x3C5C0C1 VA: 0x3C5BFC0
	|-ObjectEqualityComparer<MapImageRange.Pos>.GetHashCode
	|
	|-RVA: 0x3C5C530 Offset: 0x3C5C631 VA: 0x3C5C530
	|-ObjectEqualityComparer<MapMind.Record>.GetHashCode
	|
	|-RVA: 0x3C5CA00 Offset: 0x3C5CB01 VA: 0x3C5CA00
	|-ObjectEqualityComparer<MapMind.Target>.GetHashCode
	|
	|-RVA: 0x36FD260 Offset: 0x36FD361 VA: 0x36FD260
	|-ObjectEqualityComparer<MapPanelDebug.Entity>.GetHashCode
	|
	|-RVA: 0x36FD6C0 Offset: 0x36FD7C1 VA: 0x36FD6C0
	|-ObjectEqualityComparer<NexRanking.Data>.GetHashCode
	|
	|-RVA: 0x36FDB30 Offset: 0x36FDC31 VA: 0x36FDB30
	|-ObjectEqualityComparer<NexVersus.RatingData>.GetHashCode
	|
	|-RVA: 0x36FDFA0 Offset: 0x36FE0A1 VA: 0x36FDFA0
	|-ObjectEqualityComparer<PackedPlayModeBuildLogs.RuntimeBuildLog>.GetHashCode
	|
	|-RVA: 0x36FE480 Offset: 0x36FE581 VA: 0x36FE480
	|-ObjectEqualityComparer<ParticleSystem.Particle>.GetHashCode
	|
	|-RVA: 0x36FE980 Offset: 0x36FEA81 VA: 0x36FE980
	|-ObjectEqualityComparer<QualitySettingsStack.Settings>.GetHashCode
	|
	|-RVA: 0x36FEDE0 Offset: 0x36FEEE1 VA: 0x36FEDE0
	|-ObjectEqualityComparer<RangeData.Offset>.GetHashCode
	|
	|-RVA: 0x36FF2B0 Offset: 0x36FF3B1 VA: 0x36FF2B0
	|-ObjectEqualityComparer<RenderGraphDebugData.PassDebugData>.GetHashCode
	|
	|-RVA: 0x36FF7B0 Offset: 0x36FF8B1 VA: 0x36FF7B0
	|-ObjectEqualityComparer<RenderGraphDebugData.ResourceDebugData>.GetHashCode
	|
	|-RVA: 0x36FFC20 Offset: 0x36FFD21 VA: 0x36FFC20
	|-ObjectEqualityComparer<RingCleaningUnitSelectMenu.GodParam>.GetHashCode
	|
	|-RVA: 0x3700120 Offset: 0x3700221 VA: 0x3700120
	|-ObjectEqualityComparer<SequenceNode.SequenceConstructPosContext>.GetHashCode
	|
	|-RVA: 0x3700620 Offset: 0x3700721 VA: 0x3700620
	|-ObjectEqualityComparer<ShadowUtility.Edge>.GetHashCode
	|
	|-RVA: 0x3700A90 Offset: 0x3700B91 VA: 0x3700A90
	|-ObjectEqualityComparer<SimpleAnimationPlayable.QueuedState>.GetHashCode
	|
	|-RVA: 0x3700EF0 Offset: 0x3700FF1 VA: 0x3700EF0
	|-ObjectEqualityComparer<SkillArray.Entity>.GetHashCode
	|
	|-RVA: 0x3701380 Offset: 0x3701481 VA: 0x3701380
	|-ObjectEqualityComparer<Stream.Info>.GetHashCode
	|
	|-RVA: 0x37018C0 Offset: 0x37019C1 VA: 0x37018C0
	|-ObjectEqualityComparer<TexturePacker_JsonArray.Frame>.GetHashCode
	|
	|-RVA: 0x3701D90 Offset: 0x3701E91 VA: 0x3701D90
	|-ObjectEqualityComparer<TimeNotificationBehaviour.NotificationEntry>.GetHashCode
	|
	|-RVA: 0x3702260 Offset: 0x3702361 VA: 0x3702260
	|-ObjectEqualityComparer<UnitySynchronizationContext.WorkRequest>.GetHashCode
	|
	|-RVA: 0x37026D0 Offset: 0x37027D1 VA: 0x37026D0
	|-ObjectEqualityComparer<XmlSchemaObjectTable.XmlSchemaObjectEntry>.GetHashCode
	|
	|-RVA: 0x3702B30 Offset: 0x3702C31 VA: 0x3702B30
	|-ObjectEqualityComparer<AIThink.EnchantThink.SurroundingInfo>.GetHashCode
	|
	|-RVA: 0x3702FA0 Offset: 0x37030A1 VA: 0x3702FA0
	|-ObjectEqualityComparer<AssetBundleBuildMap.AssetBundleEntry.AssetPathString>.GetHashCode
	|
	|-RVA: 0x3703480 Offset: 0x3703581 VA: 0x3703480
	|-ObjectEqualityComparer<Detail.DataStore.DataStoreChangeMetaParamInt>.GetHashCode
	|
	|-RVA: 0x37038F0 Offset: 0x37039F1 VA: 0x37038F0
	|-ObjectEqualityComparer<Detail.DataStore.DataStoreDeleteParamInt>.GetHashCode
	|
	|-RVA: 0x3703DF0 Offset: 0x3703EF1 VA: 0x3703DF0
	|-ObjectEqualityComparer<Detail.DataStore.DataStoreGetMetaParamInt>.GetHashCode
	|
	|-RVA: 0x37042D0 Offset: 0x37043D1 VA: 0x37042D0
	|-ObjectEqualityComparer<Detail.DataStore.DataStoreMetaInfoInt>.GetHashCode
	|
	|-RVA: 0x37047A0 Offset: 0x37048A1 VA: 0x37047A0
	|-ObjectEqualityComparer<Detail.DataStore.DataStorePasswordInfoInt>.GetHashCode
	|
	|-RVA: 0x3704C70 Offset: 0x3704D71 VA: 0x3704C70
	|-ObjectEqualityComparer<Detail.DataStore.DataStorePersistenceInfoInt>.GetHashCode
	|
	|-RVA: 0x3705150 Offset: 0x3705251 VA: 0x3705150
	|-ObjectEqualityComparer<Detail.DataStore.DataStorePreparePostParamInt>.GetHashCode
	|
	|-RVA: 0x37055C0 Offset: 0x37056C1 VA: 0x37055C0
	|-ObjectEqualityComparer<Detail.DataStore.DataStoreRateObjectParamInt>.GetHashCode
	|
	|-RVA: 0x3705A90 Offset: 0x3705B91 VA: 0x3705A90
	|-ObjectEqualityComparer<Detail.DataStore.DataStoreRatingInitParamInt>.GetHashCode
	|
	|-RVA: 0x3705F00 Offset: 0x3706001 VA: 0x3705F00
	|-ObjectEqualityComparer<Detail.DataStore.DataStoreRatingTargetInt>.GetHashCode
	|
	|-RVA: 0x3706440 Offset: 0x3706541 VA: 0x3706440
	|-ObjectEqualityComparer<Detail.Ranking.RankingCachedResultInt>.GetHashCode
	|
	|-RVA: 0x37068B0 Offset: 0x37069B1 VA: 0x37068B0
	|-ObjectEqualityComparer<Detail.Ranking.RankingOrderParamInt>.GetHashCode
	|
	|-RVA: 0x3706DF0 Offset: 0x3706EF1 VA: 0x3706DF0
	|-ObjectEqualityComparer<Detail.Ranking.RankingRankDataInt>.GetHashCode
	|
	|-RVA: 0x37073A0 Offset: 0x37074A1 VA: 0x37073A0
	|-ObjectEqualityComparer<Detail.Ranking2.Ranking2ChartInfoInt>.GetHashCode
	|
	|-RVA: 0x37078E0 Offset: 0x37079E1 VA: 0x37078E0
	|-ObjectEqualityComparer<Detail.Ranking2.Ranking2RankDataInt>.GetHashCode
	|
	|-RVA: 0x3707D50 Offset: 0x3707E51 VA: 0x3707D50
	|-ObjectEqualityComparer<Detail.Ranking2.Ranking2ScoreDataInt>.GetHashCode
	|
	|-RVA: 0x3708220 Offset: 0x3708321 VA: 0x3708220
	|-ObjectEqualityComparer<Detail.Screening.ScreeningContextInfoInt>.GetHashCode
	|
	|-RVA: 0x3708790 Offset: 0x3708891 VA: 0x3708790
	|-ObjectEqualityComparer<Detail.Subscriber.SubscriberContentInt>.GetHashCode
	|
	|-RVA: 0x3708C60 Offset: 0x3708D61 VA: 0x3708C60
	|-ObjectEqualityComparer<Detail.Subscriber.SubscriberGetContentParamInt>.GetHashCode
	|
	|-RVA: 0x3709160 Offset: 0x3709261 VA: 0x3709160
	|-ObjectEqualityComparer<Detail.Subscriber.SubscriberUserStatusInfoInt>.GetHashCode
	|
	|-RVA: 0x3709630 Offset: 0x3709731 VA: 0x3709630
	|-ObjectEqualityComparer<Detail.Subscriber.SubscriberUserStatusParamInt>.GetHashCode
	|
	|-RVA: 0x3709A90 Offset: 0x3709B91 VA: 0x3709A90
	|-ObjectEqualityComparer<Detail.Utility.IntegerSettings>.GetHashCode
	|
	|-RVA: 0x3709F00 Offset: 0x370A001 VA: 0x3709F00
	|-ObjectEqualityComparer<Detail.Utility.UniqueIdInfoInt>.GetHashCode
	|
	|-RVA: 0x370A3B0 Offset: 0x370A4B1 VA: 0x370A3B0
	|-ObjectEqualityComparer<MapHistory.Rewind.LatestInspectorData>.GetHashCode
	|
	|-RVA: 0x370A860 Offset: 0x370A961 VA: 0x370A860
	|-ObjectEqualityComparer<MapHistory.Rewind.WorkTerrainData>.GetHashCode
	|
	|-RVA: 0x370ACD0 Offset: 0x370ADD1 VA: 0x370ACD0
	|-ObjectEqualityComparer<MapSkill.AroundCalculator.Result>.GetHashCode
	|
	|-RVA: 0x370B1D0 Offset: 0x370B2D1 VA: 0x370B1D0
	|-ObjectEqualityComparer<TargetPositionCache.CacheCurve.Item>.GetHashCode
	|
	|-RVA: 0x370B710 Offset: 0x370B811 VA: 0x370B710
	|-ObjectEqualityComparer<TargetPositionCache.CacheEntry.RecordingItem>.GetHashCode
	|
	|-RVA: 0x370BB70 Offset: 0x370BC71 VA: 0x370BB70
	|-ObjectEqualityComparer<TerrainUtility.TerrainMap.TileCoord>.GetHashCode
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BA6170 Offset: 0x2BA6271 VA: 0x2BA6170
	|-ObjectEqualityComparer<AsyncOperationHandle<object>>..ctor
	|
	|-RVA: 0x2BA6640 Offset: 0x2BA6741 VA: 0x2BA6640
	|-ObjectEqualityComparer<IntervalTree.Entry<object>>..ctor
	|
	|-RVA: 0x2BA6AB0 Offset: 0x2BA6BB1 VA: 0x2BA6AB0
	|-ObjectEqualityComparer<KeyValuePair<DateTime, object>>..ctor
	|
	|-RVA: 0x2BA6F20 Offset: 0x2BA7021 VA: 0x2BA6F20
	|-ObjectEqualityComparer<KeyValuePair<int, object>>..ctor
	|
	|-RVA: 0x2BA73F0 Offset: 0x2BA74F1 VA: 0x2BA73F0
	|-ObjectEqualityComparer<KeyValuePair<object, ValueTuple<int, DateTime, object>>>..ctor
	|
	|-RVA: 0x2BA7860 Offset: 0x2BA7961 VA: 0x2BA7860
	|-ObjectEqualityComparer<KeyValuePair<object, object>>..ctor
	|
	|-RVA: 0x2BA7D30 Offset: 0x2BA7E31 VA: 0x2BA7D30
	|-ObjectEqualityComparer<CommonBattleSequence.Reliance<object>>..ctor
	|
	|-RVA: 0x2BA81A0 Offset: 0x2BA82A1 VA: 0x2BA81A0
	|-ObjectEqualityComparer<RenderGraphResourcePool.ResourceLogInfo<object>>..ctor
	|
	|-RVA: 0x2BA85D0 Offset: 0x2BA86D1 VA: 0x2BA85D0
	|-ObjectEqualityComparer<TimeInterval<object>>..ctor
	|
	|-RVA: 0x2BA8A70 Offset: 0x2BA8B71 VA: 0x2BA8A70
	|-ObjectEqualityComparer<Timestamped<object>>..ctor
	|
	|-RVA: 0x2BA8ED0 Offset: 0x2BA8FD1 VA: 0x2BA8ED0
	|-ObjectEqualityComparer<UniTask<object>>..ctor
	|
	|-RVA: 0x2BA9300 Offset: 0x2BA9401 VA: 0x2BA9300
	|-ObjectEqualityComparer<ValueTuple<ValueTuple<bool, object>>>..ctor
	|
	|-RVA: 0x2BA97B0 Offset: 0x2BA98B1 VA: 0x2BA97B0
	|-ObjectEqualityComparer<ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>..ctor
	|
	|-RVA: 0x2BA9C60 Offset: 0x2BA9D61 VA: 0x2BA9C60
	|-ObjectEqualityComparer<ValueTuple<bool, UniTask<object>>>..ctor
	|
	|-RVA: 0x2BAA110 Offset: 0x2BAA211 VA: 0x2BAA110
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>..ctor
	|
	|-RVA: 0x2BAA600 Offset: 0x2BAA701 VA: 0x2BAA600
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>>..ctor
	|
	|-RVA: 0x2BAAB00 Offset: 0x2BAAC01 VA: 0x2BAAB00
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>>>..ctor
	|
	|-RVA: 0x2BAAF60 Offset: 0x2BAB061 VA: 0x2BAAF60
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>>>..ctor
	|
	|-RVA: 0x2BAB3C0 Offset: 0x2BAB4C1 VA: 0x2BAB3C0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>>>..ctor
	|
	|-RVA: 0x2BAB920 Offset: 0x2BABA21 VA: 0x2BAB920
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>>>..ctor
	|
	|-RVA: 0x2BABD80 Offset: 0x2BABE81 VA: 0x2BABD80
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>>>..ctor
	|
	|-RVA: 0x2BAC2C0 Offset: 0x2BAC3C1 VA: 0x2BAC2C0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>>>..ctor
	|
	|-RVA: 0x2BAC7C0 Offset: 0x2BAC8C1 VA: 0x2BAC7C0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>>>..ctor
	|
	|-RVA: 0x3A56B60 Offset: 0x3A56C61 VA: 0x3A56B60
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>>>..ctor
	|
	|-RVA: 0x3A57060 Offset: 0x3A57161 VA: 0x3A57060
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>>>..ctor
	|
	|-RVA: 0x3A57560 Offset: 0x3A57661 VA: 0x3A57560
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>>>..ctor
	|
	|-RVA: 0x3A57AA0 Offset: 0x3A57BA1 VA: 0x3A57AA0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>>>..ctor
	|
	|-RVA: 0x3A57FE0 Offset: 0x3A580E1 VA: 0x3A57FE0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>>>..ctor
	|
	|-RVA: 0x3A58490 Offset: 0x3A58591 VA: 0x3A58490
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>>>..ctor
	|
	|-RVA: 0x3A58990 Offset: 0x3A58A91 VA: 0x3A58990
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>>>..ctor
	|
	|-RVA: 0x3A58DF0 Offset: 0x3A58EF1 VA: 0x3A58DF0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>>>..ctor
	|
	|-RVA: 0x3A592E0 Offset: 0x3A593E1 VA: 0x3A592E0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>>>..ctor
	|
	|-RVA: 0x3A59790 Offset: 0x3A59891 VA: 0x3A59790
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>>>..ctor
	|
	|-RVA: 0x3A59CD0 Offset: 0x3A59DD1 VA: 0x3A59CD0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>>>..ctor
	|
	|-RVA: 0x3A5A1D0 Offset: 0x3A5A2D1 VA: 0x3A5A1D0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>>>..ctor
	|
	|-RVA: 0x3A5A6D0 Offset: 0x3A5A7D1 VA: 0x3A5A6D0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>>>..ctor
	|
	|-RVA: 0x3A5AC30 Offset: 0x3A5AD31 VA: 0x3A5AC30
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>>>..ctor
	|
	|-RVA: 0x3A5B190 Offset: 0x3A5B291 VA: 0x3A5B190
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>>>..ctor
	|
	|-RVA: 0x3A5B730 Offset: 0x3A5B831 VA: 0x3A5B730
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>>>..ctor
	|
	|-RVA: 0x3A5BCE0 Offset: 0x3A5BDE1 VA: 0x3A5BCE0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>>>..ctor
	|
	|-RVA: 0x3A5C2F0 Offset: 0x3A5C3F1 VA: 0x3A5C2F0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>>>..ctor
	|
	|-RVA: 0x3A5C760 Offset: 0x3A5C861 VA: 0x3A5C760
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>>..ctor
	|
	|-RVA: 0x3A5CBD0 Offset: 0x3A5CCD1 VA: 0x3A5CBD0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>>..ctor
	|
	|-RVA: 0x3A5D0C0 Offset: 0x3A5D1C1 VA: 0x3A5D0C0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>>..ctor
	|
	|-RVA: 0x3A5D530 Offset: 0x3A5D631 VA: 0x3A5D530
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>>..ctor
	|
	|-RVA: 0x3A5D9E0 Offset: 0x3A5DAE1 VA: 0x3A5D9E0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>>..ctor
	|
	|-RVA: 0x3A5DED0 Offset: 0x3A5DFD1 VA: 0x3A5DED0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>>..ctor
	|
	|-RVA: 0x3A5E380 Offset: 0x3A5E481 VA: 0x3A5E380
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>>..ctor
	|
	|-RVA: 0x3A5E870 Offset: 0x3A5E971 VA: 0x3A5E870
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>>..ctor
	|
	|-RVA: 0x3A5ED60 Offset: 0x3A5EE61 VA: 0x3A5ED60
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>>..ctor
	|
	|-RVA: 0x3A5F210 Offset: 0x3A5F311 VA: 0x3A5F210
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>>..ctor
	|
	|-RVA: 0x3A5F6C0 Offset: 0x3A5F7C1 VA: 0x3A5F6C0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>>..ctor
	|
	|-RVA: 0x3A5FB70 Offset: 0x3A5FC71 VA: 0x3A5FB70
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>>..ctor
	|
	|-RVA: 0x3A60060 Offset: 0x3A60161 VA: 0x3A60060
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>>..ctor
	|
	|-RVA: 0x3A604D0 Offset: 0x3A605D1 VA: 0x3A604D0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>>..ctor
	|
	|-RVA: 0x3A60980 Offset: 0x3A60A81 VA: 0x3A60980
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>>..ctor
	|
	|-RVA: 0x3A60E70 Offset: 0x3A60F71 VA: 0x3A60E70
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>>..ctor
	|
	|-RVA: 0x3A61320 Offset: 0x3A61421 VA: 0x3A61320
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>>..ctor
	|
	|-RVA: 0x3A61810 Offset: 0x3A61911 VA: 0x3A61810
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>>..ctor
	|
	|-RVA: 0x3A61D00 Offset: 0x3A61E01 VA: 0x3A61D00
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>>..ctor
	|
	|-RVA: 0x3A62260 Offset: 0x3A62361 VA: 0x3A62260
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>..ctor
	|
	|-RVA: 0x3A62760 Offset: 0x3A62861 VA: 0x3A62760
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>>..ctor
	|
	|-RVA: 0x3A62D10 Offset: 0x3A62E11 VA: 0x3A62D10
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>..ctor
	|
	|-RVA: 0x3A63270 Offset: 0x3A63371 VA: 0x3A63270
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>>..ctor
	|
	|-RVA: 0x3A63880 Offset: 0x3A63981 VA: 0x3A63880
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>..ctor
	|
	|-RVA: 0x3A63DE0 Offset: 0x3A63EE1 VA: 0x3A63DE0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>>..ctor
	|
	|-RVA: 0x3A64440 Offset: 0x3A64541 VA: 0x3A64440
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>..ctor
	|
	|-RVA: 0x3A649E0 Offset: 0x3A64AE1 VA: 0x3A649E0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>>..ctor
	|
	|-RVA: 0x3A650A0 Offset: 0x3A651A1 VA: 0x3A650A0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>..ctor
	|
	|-RVA: 0x3A65650 Offset: 0x3A65751 VA: 0x3A65650
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>>..ctor
	|
	|-RVA: 0x3A65A60 Offset: 0x3A65B61 VA: 0x3A65A60
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>..ctor
	|
	|-RVA: 0x3A65E70 Offset: 0x3A65F71 VA: 0x3A65E70
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>..ctor
	|
	|-RVA: 0x3A663B0 Offset: 0x3A664B1 VA: 0x3A663B0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>..ctor
	|
	|-RVA: 0x3A667C0 Offset: 0x3A668C1 VA: 0x3A667C0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>..ctor
	|
	|-RVA: 0x3A66CB0 Offset: 0x3A66DB1 VA: 0x3A66CB0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>..ctor
	|
	|-RVA: 0x3A67160 Offset: 0x3A67261 VA: 0x3A67160
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>..ctor
	|
	|-RVA: 0x3A67590 Offset: 0x3A67691 VA: 0x3A67590
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>..ctor
	|
	|-RVA: 0x3A67A40 Offset: 0x3A67B41 VA: 0x3A67A40
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>..ctor
	|
	|-RVA: 0x3A67EF0 Offset: 0x3A67FF1 VA: 0x3A67EF0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>..ctor
	|
	|-RVA: 0x3A683E0 Offset: 0x3A684E1 VA: 0x3A683E0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>..ctor
	|
	|-RVA: 0x3A688D0 Offset: 0x3A689D1 VA: 0x3A688D0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>..ctor
	|
	|-RVA: 0x3A68D00 Offset: 0x3A68E01 VA: 0x3A68D00
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>..ctor
	|
	|-RVA: 0x3A691B0 Offset: 0x3A692B1 VA: 0x3A691B0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>..ctor
	|
	|-RVA: 0x3A695C0 Offset: 0x3A696C1 VA: 0x3A695C0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>..ctor
	|
	|-RVA: 0x3A69A70 Offset: 0x3A69B71 VA: 0x3A69A70
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>..ctor
	|
	|-RVA: 0x3A69F20 Offset: 0x3A6A021 VA: 0x3A69F20
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>..ctor
	|
	|-RVA: 0x3A6A410 Offset: 0x3A6A511 VA: 0x3A6A410
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>..ctor
	|
	|-RVA: 0x3A6A8C0 Offset: 0x3A6A9C1 VA: 0x3A6A8C0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>..ctor
	|
	|-RVA: 0x3A6AD70 Offset: 0x3A6AE71 VA: 0x3A6AD70
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>..ctor
	|
	|-RVA: 0x3A6B2D0 Offset: 0x3A6B3D1 VA: 0x3A6B2D0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>..ctor
	|
	|-RVA: 0x3A6B7C0 Offset: 0x3A6B8C1 VA: 0x3A6B7C0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>..ctor
	|
	|-RVA: 0x3A6BD60 Offset: 0x3A6BE61 VA: 0x3A6BD60
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>..ctor
	|
	|-RVA: 0x3A6C260 Offset: 0x3A6C361 VA: 0x3A6C260
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>..ctor
	|
	|-RVA: 0x3A6C870 Offset: 0x3A6C971 VA: 0x3A6C870
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>..ctor
	|
	|-RVA: 0x3A6CDD0 Offset: 0x3A6CED1 VA: 0x3A6CDD0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>..ctor
	|
	|-RVA: 0x3A6D420 Offset: 0x3A6D521 VA: 0x3A6D420
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>..ctor
	|
	|-RVA: 0x3A6D980 Offset: 0x3A6DA81 VA: 0x3A6D980
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>..ctor
	|
	|-RVA: 0x3A6E040 Offset: 0x3A6E141 VA: 0x3A6E040
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>..ctor
	|
	|-RVA: 0x3A6E5E0 Offset: 0x3A6E6E1 VA: 0x3A6E5E0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>..ctor
	|
	|-RVA: 0x3A6EAB0 Offset: 0x3A6EBB1 VA: 0x3A6EAB0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>>>..ctor
	|
	|-RVA: 0x3A6EF80 Offset: 0x3A6F081 VA: 0x3A6EF80
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>..ctor
	|
	|-RVA: 0x3A6F3F0 Offset: 0x3A6F4F1 VA: 0x3A6F3F0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>..ctor
	|
	|-RVA: 0x3A6F860 Offset: 0x3A6F961 VA: 0x3A6F860
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, bool>>>..ctor
	|
	|-RVA: 0x3A6FD10 Offset: 0x3A6FE11 VA: 0x3A6FD10
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, Bounds>>>..ctor
	|
	|-RVA: 0x3A70180 Offset: 0x3A70281 VA: 0x3A70180
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, byte>>>..ctor
	|
	|-RVA: 0x3A70630 Offset: 0x3A70731 VA: 0x3A70630
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, Color>>>..ctor
	|
	|-RVA: 0x3A70AE0 Offset: 0x3A70BE1 VA: 0x3A70AE0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, double>>>..ctor
	|
	|-RVA: 0x3C2F4B0 Offset: 0x3C2F5B1 VA: 0x3C2F4B0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, int>>>..ctor
	|
	|-RVA: 0x3C2F960 Offset: 0x3C2FA61 VA: 0x3C2F960
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, long>>>..ctor
	|
	|-RVA: 0x3C2FE10 Offset: 0x3C2FF11 VA: 0x3C2FE10
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, object>>>..ctor
	|
	|-RVA: 0x3C302C0 Offset: 0x3C303C1 VA: 0x3C302C0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, Quaternion>>>..ctor
	|
	|-RVA: 0x3C30770 Offset: 0x3C30871 VA: 0x3C30770
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, Rect>>>..ctor
	|
	|-RVA: 0x3C30BE0 Offset: 0x3C30CE1 VA: 0x3C30BE0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, float>>>..ctor
	|
	|-RVA: 0x3C31090 Offset: 0x3C31191 VA: 0x3C31090
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, UniTask>>>..ctor
	|
	|-RVA: 0x3C31500 Offset: 0x3C31601 VA: 0x3C31500
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, Unit>>>..ctor
	|
	|-RVA: 0x3C31930 Offset: 0x3C31A31 VA: 0x3C31930
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, Vector2>>>..ctor
	|
	|-RVA: 0x3C31DE0 Offset: 0x3C31EE1 VA: 0x3C31DE0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, Vector3>>>..ctor
	|
	|-RVA: 0x3C32290 Offset: 0x3C32391 VA: 0x3C32290
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<bool, Vector4>>>..ctor
	|
	|-RVA: 0x3C32740 Offset: 0x3C32841 VA: 0x3C32740
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<int, object>>>..ctor
	|
	|-RVA: 0x3C32BF0 Offset: 0x3C32CF1 VA: 0x3C32BF0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<object, object>>>..ctor
	|
	|-RVA: 0x3C330F0 Offset: 0x3C331F1 VA: 0x3C330F0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>..ctor
	|
	|-RVA: 0x3C335A0 Offset: 0x3C336A1 VA: 0x3C335A0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<object, object, object>>>..ctor
	|
	|-RVA: 0x3C33B00 Offset: 0x3C33C01 VA: 0x3C33B00
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>..ctor
	|
	|-RVA: 0x3C33FF0 Offset: 0x3C340F1 VA: 0x3C33FF0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<object, object, object, object>>>..ctor
	|
	|-RVA: 0x3C345A0 Offset: 0x3C346A1 VA: 0x3C345A0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>..ctor
	|
	|-RVA: 0x3C34AA0 Offset: 0x3C34BA1 VA: 0x3C34AA0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<object, object, object, object, object>>>..ctor
	|
	|-RVA: 0x3C350B0 Offset: 0x3C351B1 VA: 0x3C350B0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>..ctor
	|
	|-RVA: 0x3C35610 Offset: 0x3C35711 VA: 0x3C35610
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>..ctor
	|
	|-RVA: 0x3C35C70 Offset: 0x3C35D71 VA: 0x3C35C70
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>..ctor
	|
	|-RVA: 0x3C361D0 Offset: 0x3C362D1 VA: 0x3C361D0
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>..ctor
	|
	|-RVA: 0x3C36890 Offset: 0x3C36991 VA: 0x3C36890
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>>..ctor
	|
	|-RVA: 0x3C36D60 Offset: 0x3C36E61 VA: 0x3C36D60
	|-ObjectEqualityComparer<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>>..ctor
	|
	|-RVA: 0x3C37170 Offset: 0x3C37271 VA: 0x3C37170
	|-ObjectEqualityComparer<ValueTuple<bool, AsyncUnit>>..ctor
	|
	|-RVA: 0x3C37580 Offset: 0x3C37681 VA: 0x3C37580
	|-ObjectEqualityComparer<ValueTuple<bool, bool>>..ctor
	|
	|-RVA: 0x3C37A70 Offset: 0x3C37B71 VA: 0x3C37A70
	|-ObjectEqualityComparer<ValueTuple<bool, Bounds>>..ctor
	|
	|-RVA: 0x3C37E80 Offset: 0x3C37F81 VA: 0x3C37E80
	|-ObjectEqualityComparer<ValueTuple<bool, byte>>..ctor
	|
	|-RVA: 0x3C38330 Offset: 0x3C38431 VA: 0x3C38330
	|-ObjectEqualityComparer<ValueTuple<bool, Color>>..ctor
	|
	|-RVA: 0x3C38760 Offset: 0x3C38861 VA: 0x3C38760
	|-ObjectEqualityComparer<ValueTuple<bool, double>>..ctor
	|
	|-RVA: 0x3C38B70 Offset: 0x3C38C71 VA: 0x3C38B70
	|-ObjectEqualityComparer<ValueTuple<bool, int>>..ctor
	|
	|-RVA: 0x3C38FA0 Offset: 0x3C390A1 VA: 0x3C38FA0
	|-ObjectEqualityComparer<ValueTuple<bool, long>>..ctor
	|
	|-RVA: 0x3C393D0 Offset: 0x3C394D1 VA: 0x3C393D0
	|-ObjectEqualityComparer<ValueTuple<bool, object>>..ctor
	|
	|-RVA: 0x3C39880 Offset: 0x3C39981 VA: 0x3C39880
	|-ObjectEqualityComparer<ValueTuple<bool, Quaternion>>..ctor
	|
	|-RVA: 0x3C39D30 Offset: 0x3C39E31 VA: 0x3C39D30
	|-ObjectEqualityComparer<ValueTuple<bool, Rect>>..ctor
	|
	|-RVA: 0x3C3A140 Offset: 0x3C3A241 VA: 0x3C3A140
	|-ObjectEqualityComparer<ValueTuple<bool, float>>..ctor
	|
	|-RVA: 0x3C3A570 Offset: 0x3C3A671 VA: 0x3C3A570
	|-ObjectEqualityComparer<ValueTuple<bool, UniTask>>..ctor
	|
	|-RVA: 0x3C3A980 Offset: 0x3C3AA81 VA: 0x3C3A980
	|-ObjectEqualityComparer<ValueTuple<bool, Unit>>..ctor
	|
	|-RVA: 0x3C3ADF0 Offset: 0x3C3AEF1 VA: 0x3C3ADF0
	|-ObjectEqualityComparer<ValueTuple<bool, Vector2>>..ctor
	|
	|-RVA: 0x3C3B220 Offset: 0x3C3B321 VA: 0x3C3B220
	|-ObjectEqualityComparer<ValueTuple<bool, Vector3>>..ctor
	|
	|-RVA: 0x3C3B6D0 Offset: 0x3C3B7D1 VA: 0x3C3B6D0
	|-ObjectEqualityComparer<ValueTuple<bool, Vector4>>..ctor
	|
	|-RVA: 0x3C3BAF0 Offset: 0x3C3BBF1 VA: 0x3C3BAF0
	|-ObjectEqualityComparer<ValueTuple<int, object>>..ctor
	|
	|-RVA: 0x3C3BF00 Offset: 0x3C3C001 VA: 0x3C3BF00
	|-ObjectEqualityComparer<ValueTuple<Int32Enum, int>>..ctor
	|
	|-RVA: 0x3C3C3A0 Offset: 0x3C3C4A1 VA: 0x3C3C3A0
	|-ObjectEqualityComparer<ValueTuple<object, ValueTuple<object, int>>>..ctor
	|
	|-RVA: 0x3C3C7C0 Offset: 0x3C3C8C1 VA: 0x3C3C7C0
	|-ObjectEqualityComparer<ValueTuple<object, int>>..ctor
	|
	|-RVA: 0x3C3CBE0 Offset: 0x3C3CCE1 VA: 0x3C3CBE0
	|-ObjectEqualityComparer<ValueTuple<object, object>>..ctor
	|
	|-RVA: 0x3C3D000 Offset: 0x3C3D101 VA: 0x3C3D000
	|-ObjectEqualityComparer<ValueTuple<object, float>>..ctor
	|
	|-RVA: 0x3C3D4A0 Offset: 0x3C3D5A1 VA: 0x3C3D4A0
	|-ObjectEqualityComparer<ValueTuple<Vector3, float>>..ctor
	|
	|-RVA: 0x3C3D990 Offset: 0x3C3DA91 VA: 0x3C3D990
	|-ObjectEqualityComparer<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>..ctor
	|
	|-RVA: 0x3C3DDB0 Offset: 0x3C3DEB1 VA: 0x3C3DDB0
	|-ObjectEqualityComparer<ValueTuple<object, Int32Enum, int>>..ctor
	|
	|-RVA: 0x3C3E250 Offset: 0x3C3E351 VA: 0x3C3E250
	|-ObjectEqualityComparer<ValueTuple<object, object, object>>..ctor
	|
	|-RVA: 0x3C3E7A0 Offset: 0x3C3E8A1 VA: 0x3C3E7A0
	|-ObjectEqualityComparer<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>..ctor
	|
	|-RVA: 0x3C3EC40 Offset: 0x3C3ED41 VA: 0x3C3EC40
	|-ObjectEqualityComparer<ValueTuple<object, int, int, int>>..ctor
	|
	|-RVA: 0x3C3F0F0 Offset: 0x3C3F1F1 VA: 0x3C3F0F0
	|-ObjectEqualityComparer<ValueTuple<object, object, object, object>>..ctor
	|
	|-RVA: 0x3C3F690 Offset: 0x3C3F791 VA: 0x3C3F690
	|-ObjectEqualityComparer<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>..ctor
	|
	|-RVA: 0x3C3FB80 Offset: 0x3C3FC81 VA: 0x3C3FB80
	|-ObjectEqualityComparer<ValueTuple<object, object, object, object, object>>..ctor
	|
	|-RVA: 0x3C40180 Offset: 0x3C40281 VA: 0x3C40180
	|-ObjectEqualityComparer<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>..ctor
	|
	|-RVA: 0x3C40670 Offset: 0x3C40771 VA: 0x3C40670
	|-ObjectEqualityComparer<ValueTuple<object, object, object, object, object, object>>..ctor
	|
	|-RVA: 0x3C40CC0 Offset: 0x3C40DC1 VA: 0x3C40CC0
	|-ObjectEqualityComparer<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>..ctor
	|
	|-RVA: 0x3C41210 Offset: 0x3C41311 VA: 0x3C41210
	|-ObjectEqualityComparer<ValueTuple<object, object, object, object, object, object, object>>..ctor
	|
	|-RVA: 0x3C418C0 Offset: 0x3C419C1 VA: 0x3C418C0
	|-ObjectEqualityComparer<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>..ctor
	|
	|-RVA: 0x3C41D80 Offset: 0x3C41E81 VA: 0x3C41D80
	|-ObjectEqualityComparer<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>..ctor
	|
	|-RVA: 0x3C421E0 Offset: 0x3C422E1 VA: 0x3C421E0
	|-ObjectEqualityComparer<AnimatorClipInfo>..ctor
	|
	|-RVA: 0x3C42630 Offset: 0x3C42731 VA: 0x3C42630
	|-ObjectEqualityComparer<AsyncOperationHandle>..ctor
	|
	|-RVA: 0x3C42A40 Offset: 0x3C42B41 VA: 0x3C42A40
	|-ObjectEqualityComparer<AsyncUnit>..ctor
	|
	|-RVA: 0x3C42D50 Offset: 0x3C42E51 VA: 0x3C42D50
	|-ObjectEqualityComparer<BoneWeight>..ctor
	|
	|-RVA: 0x3C43060 Offset: 0x3C43161 VA: 0x3C43060
	|-ObjectEqualityComparer<bool>..ctor
	|
	|-RVA: 0x3C43370 Offset: 0x3C43471 VA: 0x3C43370
	|-ObjectEqualityComparer<Bounds>..ctor
	|
	|-RVA: 0x3C43670 Offset: 0x3C43771 VA: 0x3C43670
	|-ObjectEqualityComparer<byte>..ctor
	|
	|-RVA: 0x3C43AE0 Offset: 0x3C43BE1 VA: 0x3C43AE0
	|-ObjectEqualityComparer<CameraInfo>..ctor
	|
	|-RVA: 0x3C43DF0 Offset: 0x3C43EF1 VA: 0x3C43DF0
	|-ObjectEqualityComparer<CancellationToken>..ctor
	|
	|-RVA: 0x3C44100 Offset: 0x3C44201 VA: 0x3C44100
	|-ObjectEqualityComparer<CancellationTokenRegistration>..ctor
	|
	|-RVA: 0x3C44400 Offset: 0x3C44501 VA: 0x3C44400
	|-ObjectEqualityComparer<char>..ctor
	|
	|-RVA: 0x3C44750 Offset: 0x3C44851 VA: 0x3C44750
	|-ObjectEqualityComparer<Color>..ctor
	|
	|-RVA: 0x3C44BB0 Offset: 0x3C44CB1 VA: 0x3C44BB0
	|-ObjectEqualityComparer<Color32>..ctor
	|
	|-RVA: 0x3C44F20 Offset: 0x3C45021 VA: 0x3C44F20
	|-ObjectEqualityComparer<ColorBlock>..ctor
	|
	|-RVA: 0x3C45390 Offset: 0x3C45491 VA: 0x3C45390
	|-ObjectEqualityComparer<ConstraintSource>..ctor
	|
	|-RVA: 0x3C45860 Offset: 0x3C45961 VA: 0x3C45860
	|-ObjectEqualityComparer<ContourVertex>..ctor
	|
	|-RVA: 0x3C45D30 Offset: 0x3C45E31 VA: 0x3C45D30
	|-ObjectEqualityComparer<DataStoreRatingInfo>..ctor
	|
	|-RVA: 0x3C46190 Offset: 0x3C46291 VA: 0x3C46190
	|-ObjectEqualityComparer<DataStoreResult>..ctor
	|
	|-RVA: 0x3C464A0 Offset: 0x3C465A1 VA: 0x3C464A0
	|-ObjectEqualityComparer<DateTime>..ctor
	|
	|-RVA: 0x3C467D0 Offset: 0x3C468D1 VA: 0x3C467D0
	|-ObjectEqualityComparer<DateTimeOffset>..ctor
	|
	|-RVA: 0x3C46B00 Offset: 0x3C46C01 VA: 0x3C46B00
	|-ObjectEqualityComparer<Decimal>..ctor
	|
	|-RVA: 0x3C47000 Offset: 0x3C47101 VA: 0x3C47000
	|-ObjectEqualityComparer<DiagnosticEvent>..ctor
	|
	|-RVA: 0x3C47320 Offset: 0x3C47421 VA: 0x3C47320
	|-ObjectEqualityComparer<double>..ctor
	|
	|-RVA: 0x3C47640 Offset: 0x3C47741 VA: 0x3C47640
	|-ObjectEqualityComparer<FXZ>..ctor
	|
	|-RVA: 0x3C47B20 Offset: 0x3C47C21 VA: 0x3C47B20
	|-ObjectEqualityComparer<Friend>..ctor
	|
	|-RVA: 0x3C47E50 Offset: 0x3C47F51 VA: 0x3C47E50
	|-ObjectEqualityComparer<GlyphRect>..ctor
	|
	|-RVA: 0x3C48180 Offset: 0x3C48281 VA: 0x3C48180
	|-ObjectEqualityComparer<Guid>..ctor
	|
	|-RVA: 0x3C48480 Offset: 0x3C48581 VA: 0x3C48480
	|-ObjectEqualityComparer<short>..ctor
	|
	|-RVA: 0x3C48780 Offset: 0x3C48881 VA: 0x3C48780
	|-ObjectEqualityComparer<int>..ctor
	|
	|-RVA: 0x3C48B70 Offset: 0x3C48C71 VA: 0x3C48B70
	|-ObjectEqualityComparer<Int32Enum>..ctor
	|
	|-RVA: 0x3C48E80 Offset: 0x3C48F81 VA: 0x3C48E80
	|-ObjectEqualityComparer<long>..ctor
	|
	|-RVA: 0x3C49270 Offset: 0x3C49371 VA: 0x3C49270
	|-ObjectEqualityComparer<Int64Enum>..ctor
	|
	|-RVA: 0x3C49580 Offset: 0x3C49681 VA: 0x3C49580
	|-ObjectEqualityComparer<IntPtr>..ctor
	|
	|-RVA: 0x3C499F0 Offset: 0x3C49AF1 VA: 0x3C499F0
	|-ObjectEqualityComparer<InterpretedFrameInfo>..ctor
	|
	|-RVA: 0x3C49EC0 Offset: 0x3C49FC1 VA: 0x3C49EC0
	|-ObjectEqualityComparer<IntervalTreeNode>..ctor
	|
	|-RVA: 0x3C4A320 Offset: 0x3C4A421 VA: 0x3C4A320
	|-ObjectEqualityComparer<LayerMask>..ctor
	|
	|-RVA: 0x3C4A780 Offset: 0x3C4A881 VA: 0x3C4A780
	|-ObjectEqualityComparer<LengthLimitProperties>..ctor
	|
	|-RVA: 0x3C4AA90 Offset: 0x3C4AB91 VA: 0x3C4AA90
	|-ObjectEqualityComparer<MapPos>..ctor
	|
	|-RVA: 0x3C4ADD0 Offset: 0x3C4AED1 VA: 0x3C4ADD0
	|-ObjectEqualityComparer<Matrix4x4>..ctor
	|
	|-RVA: 0x3C4B2D0 Offset: 0x3C4B3D1 VA: 0x3C4B2D0
	|-ObjectEqualityComparer<Navigation>..ctor
	|
	|-RVA: 0x3C4B5A0 Offset: 0x3C4B6A1 VA: 0x3C4B5A0
	|-ObjectEqualityComparer<object>..ctor
	|
	|-RVA: 0x3C4BAA0 Offset: 0x3C4BBA1 VA: 0x3C4BAA0
	|-ObjectEqualityComparer<ObjectInitializationData>..ctor
	|
	|-RVA: 0x3C4BF10 Offset: 0x3C4C011 VA: 0x3C4BF10
	|-ObjectEqualityComparer<Playable>..ctor
	|
	|-RVA: 0x3C4C3E0 Offset: 0x3C4C4E1 VA: 0x3C4C3E0
	|-ObjectEqualityComparer<PlayableBinding>..ctor
	|
	|-RVA: 0x3C4C8E0 Offset: 0x3C4C9E1 VA: 0x3C4C8E0
	|-ObjectEqualityComparer<PlayerLoopSystem>..ctor
	|
	|-RVA: 0x3C4CDE0 Offset: 0x3C4CEE1 VA: 0x3C4CDE0
	|-ObjectEqualityComparer<PlayerLoopSystemInternal>..ctor
	|
	|-RVA: 0x3C4D130 Offset: 0x3C4D231 VA: 0x3C4D130
	|-ObjectEqualityComparer<Quaternion>..ctor
	|
	|-RVA: 0x3C4D5A0 Offset: 0x3C4D6A1 VA: 0x3C4D5A0
	|-ObjectEqualityComparer<RandomSeed>..ctor
	|
	|-RVA: 0x3C4DA10 Offset: 0x3C4DB11 VA: 0x3C4DA10
	|-ObjectEqualityComparer<RangePositionInfo>..ctor
	|
	|-RVA: 0x3C4DE70 Offset: 0x3C4DF71 VA: 0x3C4DE70
	|-ObjectEqualityComparer<Ranking2ChartInfoInput>..ctor
	|
	|-RVA: 0x3C4E3B0 Offset: 0x3C4E4B1 VA: 0x3C4E3B0
	|-ObjectEqualityComparer<RaycastHit2D>..ctor
	|
	|-RVA: 0x3C4E920 Offset: 0x3C4EA21 VA: 0x3C4E920
	|-ObjectEqualityComparer<RaycastResult>..ctor
	|
	|-RVA: 0x3C4EC70 Offset: 0x3C4ED71 VA: 0x3C4EC70
	|-ObjectEqualityComparer<Rect>..ctor
	|
	|-RVA: 0x3C4F0D0 Offset: 0x3C4F1D1 VA: 0x3C4F0D0
	|-ObjectEqualityComparer<RendererListHandle>..ctor
	|
	|-RVA: 0x3C4F530 Offset: 0x3C4F631 VA: 0x3C4F530
	|-ObjectEqualityComparer<ResourceHandle>..ctor
	|
	|-RVA: 0x3C4F9A0 Offset: 0x3C4FAA1 VA: 0x3C4F9A0
	|-ObjectEqualityComparer<ResourceLocator>..ctor
	|
	|-RVA: 0x3C4FCA0 Offset: 0x3C4FDA1 VA: 0x3C4FCA0
	|-ObjectEqualityComparer<sbyte>..ctor
	|
	|-RVA: 0x3C4FFB0 Offset: 0x3C500B1 VA: 0x3C4FFB0
	|-ObjectEqualityComparer<ShaderTagId>..ctor
	|
	|-RVA: 0x3C502C0 Offset: 0x3C503C1 VA: 0x3C502C0
	|-ObjectEqualityComparer<float>..ctor
	|
	|-RVA: 0x3C50660 Offset: 0x3C50761 VA: 0x3C50660
	|-ObjectEqualityComparer<SphericalHarmonicsL2>..ctor
	|
	|-RVA: 0x3C50B30 Offset: 0x3C50C31 VA: 0x3C50B30
	|-ObjectEqualityComparer<SpriteState>..ctor
	|
	|-RVA: 0x3C51030 Offset: 0x3C51131 VA: 0x3C51030
	|-ObjectEqualityComparer<SubMeshDescriptor>..ctor
	|
	|-RVA: 0x3C514A0 Offset: 0x3C515A1 VA: 0x3C514A0
	|-ObjectEqualityComparer<TablePair>..ctor
	|
	|-RVA: 0x3C517B0 Offset: 0x3C518B1 VA: 0x3C517B0
	|-ObjectEqualityComparer<TimeSpan>..ctor
	|
	|-RVA: 0x3C51C70 Offset: 0x3C51D71 VA: 0x3C51C70
	|-ObjectEqualityComparer<UICharInfo>..ctor
	|
	|-RVA: 0x3C520E0 Offset: 0x3C521E1 VA: 0x3C520E0
	|-ObjectEqualityComparer<UILineInfo>..ctor
	|
	|-RVA: 0x3C52700 Offset: 0x3C52801 VA: 0x3C52700
	|-ObjectEqualityComparer<UIVertex>..ctor
	|
	|-RVA: 0x3C52A00 Offset: 0x3C52B01 VA: 0x3C52A00
	|-ObjectEqualityComparer<ushort>..ctor
	|
	|-RVA: 0x3C52D00 Offset: 0x3C52E01 VA: 0x3C52D00
	|-ObjectEqualityComparer<uint>..ctor
	|
	|-RVA: 0x3C53010 Offset: 0x3C53111 VA: 0x3C53010
	|-ObjectEqualityComparer<ulong>..ctor
	|
	|-RVA: 0x3C53420 Offset: 0x3C53521 VA: 0x3C53420
	|-ObjectEqualityComparer<UniTask>..ctor
	|
	|-RVA: 0x3C53730 Offset: 0x3C53831 VA: 0x3C53730
	|-ObjectEqualityComparer<Unit>..ctor
	|
	|-RVA: 0x3C53A50 Offset: 0x3C53B51 VA: 0x3C53A50
	|-ObjectEqualityComparer<Vector2>..ctor
	|
	|-RVA: 0x3C53DB0 Offset: 0x3C53EB1 VA: 0x3C53DB0
	|-ObjectEqualityComparer<Vector3>..ctor
	|
	|-RVA: 0x3C54100 Offset: 0x3C54201 VA: 0x3C54100
	|-ObjectEqualityComparer<Vector4>..ctor
	|
	|-RVA: 0x3C54430 Offset: 0x3C54531 VA: 0x3C54430
	|-ObjectEqualityComparer<VertexAttributeDescriptor>..ctor
	|
	|-RVA: 0x3C548A0 Offset: 0x3C549A1 VA: 0x3C548A0
	|-ObjectEqualityComparer<X509ChainStatus>..ctor
	|
	|-RVA: 0x3C54CC0 Offset: 0x3C54DC1 VA: 0x3C54CC0
	|-ObjectEqualityComparer<XPathNodeRef>..ctor
	|
	|-RVA: 0x3C551A0 Offset: 0x3C552A1 VA: 0x3C551A0
	|-ObjectEqualityComparer<XRView>..ctor
	|
	|-RVA: 0x3C55610 Offset: 0x3C55711 VA: 0x3C55610
	|-ObjectEqualityComparer<AmiiboSequence.GainItemData>..ctor
	|
	|-RVA: 0x3C55B10 Offset: 0x3C55C11 VA: 0x3C55B10
	|-ObjectEqualityComparer<AnimationOutputWeightProcessor.WeightInfo>..ctor
	|
	|-RVA: 0x3C55F80 Offset: 0x3C56081 VA: 0x3C55F80
	|-ObjectEqualityComparer<ArenaOrderSequence.GodInfo>..ctor
	|
	|-RVA: 0x3C563F0 Offset: 0x3C564F1 VA: 0x3C563F0
	|-ObjectEqualityComparer<BattleInfo.SupportData>..ctor
	|
	|-RVA: 0x3C56860 Offset: 0x3C56961 VA: 0x3C56860
	|-ObjectEqualityComparer<BeforeRenderHelper.OrderBlock>..ctor
	|
	|-RVA: 0x3C56D30 Offset: 0x3C56E31 VA: 0x3C56D30
	|-ObjectEqualityComparer<Camera.RenderRequest>..ctor
	|
	|-RVA: 0x3C571A0 Offset: 0x3C572A1 VA: 0x3C571A0
	|-ObjectEqualityComparer<CameraState.CustomBlendable>..ctor
	|
	|-RVA: 0x3C57600 Offset: 0x3C57701 VA: 0x3C57600
	|-ObjectEqualityComparer<CinemachineClearShot.Pair>..ctor
	|
	|-RVA: 0x3C57A60 Offset: 0x3C57B61 VA: 0x3C57A60
	|-ObjectEqualityComparer<CinemachineStateDrivenCamera.HashPair>..ctor
	|
	|-RVA: 0x3C57F30 Offset: 0x3C58031 VA: 0x3C57F30
	|-ObjectEqualityComparer<DelayedActionManager.DelegateInfo>..ctor
	|
	|-RVA: 0x3C58430 Offset: 0x3C58531 VA: 0x3C58430
	|-ObjectEqualityComparer<Detail.AsyncResultInt>..ctor
	|
	|-RVA: 0x3C588A0 Offset: 0x3C589A1 VA: 0x3C588A0
	|-ObjectEqualityComparer<Detail.CppArray>..ctor
	|
	|-RVA: 0x3C58DA0 Offset: 0x3C58EA1 VA: 0x3C58DA0
	|-ObjectEqualityComparer<Detail.NotificationEventInt>..ctor
	|
	|-RVA: 0x3C59210 Offset: 0x3C59311 VA: 0x3C59210
	|-ObjectEqualityComparer<DragonRideTargetGroup.ChainParam>..ctor
	|
	|-RVA: 0x3C59670 Offset: 0x3C59771 VA: 0x3C59670
	|-ObjectEqualityComparer<DynamicMesh.State>..ctor
	|
	|-RVA: 0x3C59AE0 Offset: 0x3C59BE1 VA: 0x3C59AE0
	|-ObjectEqualityComparer<GameVariable.Value>..ctor
	|
	|-RVA: 0x3C59FB0 Offset: 0x3C5A0B1 VA: 0x3C59FB0
	|-ObjectEqualityComparer<GmapPathAdjuster.TargetModel>..ctor
	|
	|-RVA: 0x3C5A480 Offset: 0x3C5A581 VA: 0x3C5A480
	|-ObjectEqualityComparer<GmapSpotAdjuster.TargetModel>..ctor
	|
	|-RVA: 0x3C5A950 Offset: 0x3C5AA51 VA: 0x3C5A950
	|-ObjectEqualityComparer<HubFastTravel.Location>..ctor
	|
	|-RVA: 0x3C5AE50 Offset: 0x3C5AF51 VA: 0x3C5AE50
	|-ObjectEqualityComparer<HubLensFlare.Flare>..ctor
	|
	|-RVA: 0x3C5B2C0 Offset: 0x3C5B3C1 VA: 0x3C5B2C0
	|-ObjectEqualityComparer<InventoryPoolItemMenuContent.KindBgNameClass>..ctor
	|
	|-RVA: 0x3C5B720 Offset: 0x3C5B821 VA: 0x3C5B720
	|-ObjectEqualityComparer<Map.Pos>..ctor
	|
	|-RVA: 0x3C5BB90 Offset: 0x3C5BC91 VA: 0x3C5BB90
	|-ObjectEqualityComparer<MapImage.BackupTerrain>..ctor
	|
	|-RVA: 0x3C5BFF0 Offset: 0x3C5C0F1 VA: 0x3C5BFF0
	|-ObjectEqualityComparer<MapImageRange.Pos>..ctor
	|
	|-RVA: 0x3C5C560 Offset: 0x3C5C661 VA: 0x3C5C560
	|-ObjectEqualityComparer<MapMind.Record>..ctor
	|
	|-RVA: 0x3C5CA30 Offset: 0x3C5CB31 VA: 0x3C5CA30
	|-ObjectEqualityComparer<MapMind.Target>..ctor
	|
	|-RVA: 0x36FD290 Offset: 0x36FD391 VA: 0x36FD290
	|-ObjectEqualityComparer<MapPanelDebug.Entity>..ctor
	|
	|-RVA: 0x36FD6F0 Offset: 0x36FD7F1 VA: 0x36FD6F0
	|-ObjectEqualityComparer<NexRanking.Data>..ctor
	|
	|-RVA: 0x36FDB60 Offset: 0x36FDC61 VA: 0x36FDB60
	|-ObjectEqualityComparer<NexVersus.RatingData>..ctor
	|
	|-RVA: 0x36FDFD0 Offset: 0x36FE0D1 VA: 0x36FDFD0
	|-ObjectEqualityComparer<PackedPlayModeBuildLogs.RuntimeBuildLog>..ctor
	|
	|-RVA: 0x36FE4B0 Offset: 0x36FE5B1 VA: 0x36FE4B0
	|-ObjectEqualityComparer<ParticleSystem.Particle>..ctor
	|
	|-RVA: 0x36FE9B0 Offset: 0x36FEAB1 VA: 0x36FE9B0
	|-ObjectEqualityComparer<QualitySettingsStack.Settings>..ctor
	|
	|-RVA: 0x36FEE10 Offset: 0x36FEF11 VA: 0x36FEE10
	|-ObjectEqualityComparer<RangeData.Offset>..ctor
	|
	|-RVA: 0x36FF2E0 Offset: 0x36FF3E1 VA: 0x36FF2E0
	|-ObjectEqualityComparer<RenderGraphDebugData.PassDebugData>..ctor
	|
	|-RVA: 0x36FF7E0 Offset: 0x36FF8E1 VA: 0x36FF7E0
	|-ObjectEqualityComparer<RenderGraphDebugData.ResourceDebugData>..ctor
	|
	|-RVA: 0x36FFC50 Offset: 0x36FFD51 VA: 0x36FFC50
	|-ObjectEqualityComparer<RingCleaningUnitSelectMenu.GodParam>..ctor
	|
	|-RVA: 0x3700150 Offset: 0x3700251 VA: 0x3700150
	|-ObjectEqualityComparer<SequenceNode.SequenceConstructPosContext>..ctor
	|
	|-RVA: 0x3700650 Offset: 0x3700751 VA: 0x3700650
	|-ObjectEqualityComparer<ShadowUtility.Edge>..ctor
	|
	|-RVA: 0x3700AC0 Offset: 0x3700BC1 VA: 0x3700AC0
	|-ObjectEqualityComparer<SimpleAnimationPlayable.QueuedState>..ctor
	|
	|-RVA: 0x3700F20 Offset: 0x3701021 VA: 0x3700F20
	|-ObjectEqualityComparer<SkillArray.Entity>..ctor
	|
	|-RVA: 0x37013B0 Offset: 0x37014B1 VA: 0x37013B0
	|-ObjectEqualityComparer<Stream.Info>..ctor
	|
	|-RVA: 0x37018F0 Offset: 0x37019F1 VA: 0x37018F0
	|-ObjectEqualityComparer<TexturePacker_JsonArray.Frame>..ctor
	|
	|-RVA: 0x3701DC0 Offset: 0x3701EC1 VA: 0x3701DC0
	|-ObjectEqualityComparer<TimeNotificationBehaviour.NotificationEntry>..ctor
	|
	|-RVA: 0x3702290 Offset: 0x3702391 VA: 0x3702290
	|-ObjectEqualityComparer<UnitySynchronizationContext.WorkRequest>..ctor
	|
	|-RVA: 0x3702700 Offset: 0x3702801 VA: 0x3702700
	|-ObjectEqualityComparer<XmlSchemaObjectTable.XmlSchemaObjectEntry>..ctor
	|
	|-RVA: 0x3702B60 Offset: 0x3702C61 VA: 0x3702B60
	|-ObjectEqualityComparer<AIThink.EnchantThink.SurroundingInfo>..ctor
	|
	|-RVA: 0x3702FD0 Offset: 0x37030D1 VA: 0x3702FD0
	|-ObjectEqualityComparer<AssetBundleBuildMap.AssetBundleEntry.AssetPathString>..ctor
	|
	|-RVA: 0x37034B0 Offset: 0x37035B1 VA: 0x37034B0
	|-ObjectEqualityComparer<Detail.DataStore.DataStoreChangeMetaParamInt>..ctor
	|
	|-RVA: 0x3703920 Offset: 0x3703A21 VA: 0x3703920
	|-ObjectEqualityComparer<Detail.DataStore.DataStoreDeleteParamInt>..ctor
	|
	|-RVA: 0x3703E20 Offset: 0x3703F21 VA: 0x3703E20
	|-ObjectEqualityComparer<Detail.DataStore.DataStoreGetMetaParamInt>..ctor
	|
	|-RVA: 0x3704300 Offset: 0x3704401 VA: 0x3704300
	|-ObjectEqualityComparer<Detail.DataStore.DataStoreMetaInfoInt>..ctor
	|
	|-RVA: 0x37047D0 Offset: 0x37048D1 VA: 0x37047D0
	|-ObjectEqualityComparer<Detail.DataStore.DataStorePasswordInfoInt>..ctor
	|
	|-RVA: 0x3704CA0 Offset: 0x3704DA1 VA: 0x3704CA0
	|-ObjectEqualityComparer<Detail.DataStore.DataStorePersistenceInfoInt>..ctor
	|
	|-RVA: 0x3705180 Offset: 0x3705281 VA: 0x3705180
	|-ObjectEqualityComparer<Detail.DataStore.DataStorePreparePostParamInt>..ctor
	|
	|-RVA: 0x37055F0 Offset: 0x37056F1 VA: 0x37055F0
	|-ObjectEqualityComparer<Detail.DataStore.DataStoreRateObjectParamInt>..ctor
	|
	|-RVA: 0x3705AC0 Offset: 0x3705BC1 VA: 0x3705AC0
	|-ObjectEqualityComparer<Detail.DataStore.DataStoreRatingInitParamInt>..ctor
	|
	|-RVA: 0x3705F30 Offset: 0x3706031 VA: 0x3705F30
	|-ObjectEqualityComparer<Detail.DataStore.DataStoreRatingTargetInt>..ctor
	|
	|-RVA: 0x3706470 Offset: 0x3706571 VA: 0x3706470
	|-ObjectEqualityComparer<Detail.Ranking.RankingCachedResultInt>..ctor
	|
	|-RVA: 0x37068E0 Offset: 0x37069E1 VA: 0x37068E0
	|-ObjectEqualityComparer<Detail.Ranking.RankingOrderParamInt>..ctor
	|
	|-RVA: 0x3706E20 Offset: 0x3706F21 VA: 0x3706E20
	|-ObjectEqualityComparer<Detail.Ranking.RankingRankDataInt>..ctor
	|
	|-RVA: 0x37073D0 Offset: 0x37074D1 VA: 0x37073D0
	|-ObjectEqualityComparer<Detail.Ranking2.Ranking2ChartInfoInt>..ctor
	|
	|-RVA: 0x3707910 Offset: 0x3707A11 VA: 0x3707910
	|-ObjectEqualityComparer<Detail.Ranking2.Ranking2RankDataInt>..ctor
	|
	|-RVA: 0x3707D80 Offset: 0x3707E81 VA: 0x3707D80
	|-ObjectEqualityComparer<Detail.Ranking2.Ranking2ScoreDataInt>..ctor
	|
	|-RVA: 0x3708250 Offset: 0x3708351 VA: 0x3708250
	|-ObjectEqualityComparer<Detail.Screening.ScreeningContextInfoInt>..ctor
	|
	|-RVA: 0x37087C0 Offset: 0x37088C1 VA: 0x37087C0
	|-ObjectEqualityComparer<Detail.Subscriber.SubscriberContentInt>..ctor
	|
	|-RVA: 0x3708C90 Offset: 0x3708D91 VA: 0x3708C90
	|-ObjectEqualityComparer<Detail.Subscriber.SubscriberGetContentParamInt>..ctor
	|
	|-RVA: 0x3709190 Offset: 0x3709291 VA: 0x3709190
	|-ObjectEqualityComparer<Detail.Subscriber.SubscriberUserStatusInfoInt>..ctor
	|
	|-RVA: 0x3709660 Offset: 0x3709761 VA: 0x3709660
	|-ObjectEqualityComparer<Detail.Subscriber.SubscriberUserStatusParamInt>..ctor
	|
	|-RVA: 0x3709AC0 Offset: 0x3709BC1 VA: 0x3709AC0
	|-ObjectEqualityComparer<Detail.Utility.IntegerSettings>..ctor
	|
	|-RVA: 0x3709F30 Offset: 0x370A031 VA: 0x3709F30
	|-ObjectEqualityComparer<Detail.Utility.UniqueIdInfoInt>..ctor
	|
	|-RVA: 0x370A3E0 Offset: 0x370A4E1 VA: 0x370A3E0
	|-ObjectEqualityComparer<MapHistory.Rewind.LatestInspectorData>..ctor
	|
	|-RVA: 0x370A890 Offset: 0x370A991 VA: 0x370A890
	|-ObjectEqualityComparer<MapHistory.Rewind.WorkTerrainData>..ctor
	|
	|-RVA: 0x370AD00 Offset: 0x370AE01 VA: 0x370AD00
	|-ObjectEqualityComparer<MapSkill.AroundCalculator.Result>..ctor
	|
	|-RVA: 0x370B200 Offset: 0x370B301 VA: 0x370B200
	|-ObjectEqualityComparer<TargetPositionCache.CacheCurve.Item>..ctor
	|
	|-RVA: 0x370B740 Offset: 0x370B841 VA: 0x370B740
	|-ObjectEqualityComparer<TargetPositionCache.CacheEntry.RecordingItem>..ctor
	|
	|-RVA: 0x370BBA0 Offset: 0x370BCA1 VA: 0x370BBA0
	|-ObjectEqualityComparer<TerrainUtility.TerrainMap.TileCoord>..ctor
	*/
}

