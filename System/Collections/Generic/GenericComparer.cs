// Namespace: System.Collections.Generic
[Serializable]
internal class GenericComparer<T> : Comparer<T> // TypeDefIndex: 1415
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 6
	public override int Compare(T x, T y) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E8F580 Offset: 0x1E8F681 VA: 0x1E8F580
	|-GenericComparer<ValueTuple<ValueTuple<bool, object>>>.Compare
	|
	|-RVA: 0x1E8F710 Offset: 0x1E8F811 VA: 0x1E8F710
	|-GenericComparer<ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>.Compare
	|
	|-RVA: 0x1E8F8D0 Offset: 0x1E8F9D1 VA: 0x1E8F8D0
	|-GenericComparer<ValueTuple<bool, UniTask<object>>>.Compare
	|
	|-RVA: 0x1E8FA90 Offset: 0x1E8FB91 VA: 0x1E8FA90
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>.Compare
	|
	|-RVA: 0x1E8FC50 Offset: 0x1E8FD51 VA: 0x1E8FC50
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>>.Compare
	|
	|-RVA: 0x1E8FE30 Offset: 0x1E8FF31 VA: 0x1E8FE30
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>>>.Compare
	|
	|-RVA: 0x1E90010 Offset: 0x1E90111 VA: 0x1E90010
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>>>.Compare
	|
	|-RVA: 0x1E90190 Offset: 0x1E90291 VA: 0x1E90190
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>>>.Compare
	|
	|-RVA: 0x1E90310 Offset: 0x1E90411 VA: 0x1E90310
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>>>.Compare
	|
	|-RVA: 0x1E90510 Offset: 0x1E90611 VA: 0x1E90510
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>>>.Compare
	|
	|-RVA: 0x1E90690 Offset: 0x1E90791 VA: 0x1E90690
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>>>.Compare
	|
	|-RVA: 0x1E90880 Offset: 0x1E90981 VA: 0x1E90880
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>>>.Compare
	|
	|-RVA: 0x1E90A60 Offset: 0x1E90B61 VA: 0x1E90A60
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>>>.Compare
	|
	|-RVA: 0x1E90C20 Offset: 0x1E90D21 VA: 0x1E90C20
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>>>.Compare
	|
	|-RVA: 0x1E90E00 Offset: 0x1E90F01 VA: 0x1E90E00
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>>>.Compare
	|
	|-RVA: 0x1E90FE0 Offset: 0x1E910E1 VA: 0x1E90FE0
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>>>.Compare
	|
	|-RVA: 0x1E911D0 Offset: 0x1E912D1 VA: 0x1E911D0
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>>>.Compare
	|
	|-RVA: 0x1E913C0 Offset: 0x1E914C1 VA: 0x1E913C0
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>>>.Compare
	|
	|-RVA: 0x1E91580 Offset: 0x1E91681 VA: 0x1E91580
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>>>.Compare
	|
	|-RVA: 0x1E91760 Offset: 0x1E91861 VA: 0x1E91760
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>>>.Compare
	|
	|-RVA: 0x1E918E0 Offset: 0x1E919E1 VA: 0x1E918E0
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>>>.Compare
	|
	|-RVA: 0x1E91AC0 Offset: 0x1E91BC1 VA: 0x1E91AC0
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>>>.Compare
	|
	|-RVA: 0x1E91C80 Offset: 0x1E91D81 VA: 0x1E91C80
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>>>.Compare
	|
	|-RVA: 0x1E91E70 Offset: 0x1E91F71 VA: 0x1E91E70
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>>>.Compare
	|
	|-RVA: 0x1E92050 Offset: 0x1E92151 VA: 0x1E92050
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>>>.Compare
	|
	|-RVA: 0x1E92230 Offset: 0x1E92331 VA: 0x1E92230
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>>>.Compare
	|
	|-RVA: 0x1E92430 Offset: 0x1E92531 VA: 0x1E92430
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>>>.Compare
	|
	|-RVA: 0x1E92630 Offset: 0x1E92731 VA: 0x1E92630
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>>>.Compare
	|
	|-RVA: 0x1E92850 Offset: 0x1E92951 VA: 0x1E92850
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>>>.Compare
	|
	|-RVA: 0x1E92A70 Offset: 0x1E92B71 VA: 0x1E92A70
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>>>.Compare
	|
	|-RVA: 0x1E92CB0 Offset: 0x1E92DB1 VA: 0x1E92CB0
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>>.Compare
	|
	|-RVA: 0x1E92E30 Offset: 0x1E92F31 VA: 0x1E92E30
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>>.Compare
	|
	|-RVA: 0x1E92FB0 Offset: 0x1E930B1 VA: 0x1E92FB0
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>>.Compare
	|
	|-RVA: 0x1E93190 Offset: 0x1E93291 VA: 0x1E93190
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>>.Compare
	|
	|-RVA: 0x1E93310 Offset: 0x1E93411 VA: 0x1E93310
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>>.Compare
	|
	|-RVA: 0x1E934D0 Offset: 0x1E935D1 VA: 0x1E934D0
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>>.Compare
	|
	|-RVA: 0x1E936B0 Offset: 0x1E937B1 VA: 0x1E936B0
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>>.Compare
	|
	|-RVA: 0x1E93870 Offset: 0x1E93971 VA: 0x1E93870
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>>.Compare
	|
	|-RVA: 0x1E93A50 Offset: 0x1E93B51 VA: 0x1E93A50
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>>.Compare
	|
	|-RVA: 0x1E93C30 Offset: 0x1E93D31 VA: 0x1E93C30
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>>.Compare
	|
	|-RVA: 0x1E93DF0 Offset: 0x1E93EF1 VA: 0x1E93DF0
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>>.Compare
	|
	|-RVA: 0x1E93FB0 Offset: 0x1E940B1 VA: 0x1E93FB0
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>>.Compare
	|
	|-RVA: 0x1E94170 Offset: 0x1E94271 VA: 0x1E94170
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>>.Compare
	|
	|-RVA: 0x1E94350 Offset: 0x1E94451 VA: 0x1E94350
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>>.Compare
	|
	|-RVA: 0x1E944D0 Offset: 0x1E945D1 VA: 0x1E944D0
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>>.Compare
	|
	|-RVA: 0x1E94690 Offset: 0x1E94791 VA: 0x1E94690
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>>.Compare
	|
	|-RVA: 0x1E94870 Offset: 0x1E94971 VA: 0x1E94870
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>>.Compare
	|
	|-RVA: 0x1E94A30 Offset: 0x1E94B31 VA: 0x1E94A30
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>>.Compare
	|
	|-RVA: 0x1E94C10 Offset: 0x1E94D11 VA: 0x1E94C10
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>>.Compare
	|
	|-RVA: 0x1E94DF0 Offset: 0x1E94EF1 VA: 0x1E94DF0
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.Compare
	|
	|-RVA: 0x1E94FF0 Offset: 0x1E950F1 VA: 0x1E94FF0
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>>.Compare
	|
	|-RVA: 0x1E951D0 Offset: 0x1E952D1 VA: 0x1E951D0
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.Compare
	|
	|-RVA: 0x1E953F0 Offset: 0x1E954F1 VA: 0x1E953F0
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>>.Compare
	|
	|-RVA: 0x1E955F0 Offset: 0x1E956F1 VA: 0x1E955F0
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.Compare
	|
	|-RVA: 0x1E95830 Offset: 0x1E95931 VA: 0x1E95830
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>>.Compare
	|
	|-RVA: 0x1E95A30 Offset: 0x1E95B31 VA: 0x1E95A30
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.Compare
	|
	|-RVA: 0x1E95C90 Offset: 0x1E95D91 VA: 0x1E95C90
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>>.Compare
	|
	|-RVA: 0x1E95EB0 Offset: 0x1E95FB1 VA: 0x1E95EB0
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.Compare
	|
	|-RVA: 0x1E96130 Offset: 0x1E96231 VA: 0x1E96130
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>>.Compare
	|
	|-RVA: 0x1E96350 Offset: 0x1E96451 VA: 0x1E96350
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>.Compare
	|
	|-RVA: 0x1E964C0 Offset: 0x1E965C1 VA: 0x1E964C0
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>.Compare
	|
	|-RVA: 0x1E96630 Offset: 0x1E96731 VA: 0x1E96630
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>.Compare
	|
	|-RVA: 0x1E96820 Offset: 0x1E96921 VA: 0x1E96820
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>.Compare
	|
	|-RVA: 0x1E96990 Offset: 0x1E96A91 VA: 0x1E96990
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>.Compare
	|
	|-RVA: 0x1E96B70 Offset: 0x1E96C71 VA: 0x1E96B70
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>.Compare
	|
	|-RVA: 0x1E96D30 Offset: 0x1E96E31 VA: 0x1E96D30
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>.Compare
	|
	|-RVA: 0x1E96EC0 Offset: 0x1E96FC1 VA: 0x1E96EC0
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>.Compare
	|
	|-RVA: 0x1E97080 Offset: 0x1E97181 VA: 0x1E97080
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>.Compare
	|
	|-RVA: 0x1E97240 Offset: 0x1E97341 VA: 0x1E97240
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>.Compare
	|
	|-RVA: 0x1E97420 Offset: 0x1E97521 VA: 0x1E97420
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>.Compare
	|
	|-RVA: 0x1E97600 Offset: 0x1E97701 VA: 0x1E97600
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>.Compare
	|
	|-RVA: 0x1E97790 Offset: 0x1E97891 VA: 0x1E97790
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>.Compare
	|
	|-RVA: 0x1E97950 Offset: 0x1E97A51 VA: 0x1E97950
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>.Compare
	|
	|-RVA: 0x1E97AC0 Offset: 0x1E97BC1 VA: 0x1E97AC0
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>.Compare
	|
	|-RVA: 0x1E97C80 Offset: 0x1E97D81 VA: 0x1E97C80
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>.Compare
	|
	|-RVA: 0x1E97E40 Offset: 0x1E97F41 VA: 0x1E97E40
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>.Compare
	|
	|-RVA: 0x1E98020 Offset: 0x1E98121 VA: 0x1E98020
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>.Compare
	|
	|-RVA: 0x1E981E0 Offset: 0x1E982E1 VA: 0x1E981E0
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>.Compare
	|
	|-RVA: 0x1E983A0 Offset: 0x1E984A1 VA: 0x1E983A0
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.Compare
	|
	|-RVA: 0x1E985A0 Offset: 0x1E986A1 VA: 0x1E985A0
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>.Compare
	|
	|-RVA: 0x1E98780 Offset: 0x1E98881 VA: 0x1E98780
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.Compare
	|
	|-RVA: 0x1E989A0 Offset: 0x1E98AA1 VA: 0x1E989A0
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>.Compare
	|
	|-RVA: 0x1E98B80 Offset: 0x1E98C81 VA: 0x1E98B80
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.Compare
	|
	|-RVA: 0x1E98DC0 Offset: 0x1E98EC1 VA: 0x1E98DC0
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>.Compare
	|
	|-RVA: 0x1E98FC0 Offset: 0x1E990C1 VA: 0x1E98FC0
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.Compare
	|
	|-RVA: 0x1E99220 Offset: 0x1E99321 VA: 0x1E99220
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>.Compare
	|
	|-RVA: 0x1E99420 Offset: 0x1E99521 VA: 0x1E99420
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.Compare
	|
	|-RVA: 0x1E996A0 Offset: 0x1E997A1 VA: 0x1E996A0
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>.Compare
	|
	|-RVA: 0x1E998C0 Offset: 0x1E999C1 VA: 0x1E998C0
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>>>.Compare
	|
	|-RVA: 0x1E99A90 Offset: 0x1E99B91 VA: 0x1E99A90
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.Compare
	|
	|-RVA: 0x1E99C60 Offset: 0x1E99D61 VA: 0x1E99C60
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>.Compare
	|
	|-RVA: 0x1E99DE0 Offset: 0x1E99EE1 VA: 0x1E99DE0
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, bool>>>.Compare
	|
	|-RVA: 0x1E99F60 Offset: 0x1E9A061 VA: 0x1E99F60
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, Bounds>>>.Compare
	|
	|-RVA: 0x1E9A120 Offset: 0x1E9A221 VA: 0x1E9A120
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, byte>>>.Compare
	|
	|-RVA: 0x1E9A2A0 Offset: 0x1E9A3A1 VA: 0x1E9A2A0
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, Color>>>.Compare
	|
	|-RVA: 0x1E9A460 Offset: 0x1E9A561 VA: 0x1E9A460
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, double>>>.Compare
	|
	|-RVA: 0x1E9A620 Offset: 0x1E9A721 VA: 0x1E9A620
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, int>>>.Compare
	|
	|-RVA: 0x1E9A7B0 Offset: 0x1E9A8B1 VA: 0x1E9A7B0
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, long>>>.Compare
	|
	|-RVA: 0x1E9A970 Offset: 0x1E9AA71 VA: 0x1E9A970
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, object>>>.Compare
	|
	|-RVA: 0x1E9AB30 Offset: 0x1E9AC31 VA: 0x1E9AB30
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, Quaternion>>>.Compare
	|
	|-RVA: 0x1E9ACF0 Offset: 0x1E9ADF1 VA: 0x1E9ACF0
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, Rect>>>.Compare
	|
	|-RVA: 0x1E9AEB0 Offset: 0x1E9AFB1 VA: 0x1E9AEB0
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, float>>>.Compare
	|
	|-RVA: 0x1E9B040 Offset: 0x1E9B141 VA: 0x1E9B040
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, UniTask>>>.Compare
	|
	|-RVA: 0x1E9B200 Offset: 0x1E9B301 VA: 0x1E9B200
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, Unit>>>.Compare
	|
	|-RVA: 0x1E9B380 Offset: 0x1E9B481 VA: 0x1E9B380
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, Vector2>>>.Compare
	|
	|-RVA: 0x1E9B510 Offset: 0x1E9B611 VA: 0x1E9B510
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, Vector3>>>.Compare
	|
	|-RVA: 0x1E9B6D0 Offset: 0x1E9B7D1 VA: 0x1E9B6D0
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, Vector4>>>.Compare
	|
	|-RVA: 0x1E9B890 Offset: 0x1E9B991 VA: 0x1E9B890
	|-GenericComparer<ValueTuple<bool, ValueTuple<int, object>>>.Compare
	|
	|-RVA: 0x1E9BA50 Offset: 0x1E9BB51 VA: 0x1E9BA50
	|-GenericComparer<ValueTuple<bool, ValueTuple<object, object>>>.Compare
	|
	|-RVA: 0x1E9BC10 Offset: 0x1E9BD11 VA: 0x1E9BC10
	|-GenericComparer<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.Compare
	|
	|-RVA: 0x1E9BDF0 Offset: 0x1E9BEF1 VA: 0x1E9BDF0
	|-GenericComparer<ValueTuple<bool, ValueTuple<object, object, object>>>.Compare
	|
	|-RVA: 0x1E9BFB0 Offset: 0x1E9C0B1 VA: 0x1E9BFB0
	|-GenericComparer<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.Compare
	|
	|-RVA: 0x1E9C1B0 Offset: 0x1E9C2B1 VA: 0x1E9C1B0
	|-GenericComparer<ValueTuple<bool, ValueTuple<object, object, object, object>>>.Compare
	|
	|-RVA: 0x1E9C390 Offset: 0x1E9C491 VA: 0x1E9C390
	|-GenericComparer<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.Compare
	|
	|-RVA: 0x1E9C5B0 Offset: 0x1E9C6B1 VA: 0x1E9C5B0
	|-GenericComparer<ValueTuple<bool, ValueTuple<object, object, object, object, object>>>.Compare
	|
	|-RVA: 0x1E9C790 Offset: 0x1E9C891 VA: 0x1E9C790
	|-GenericComparer<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.Compare
	|
	|-RVA: 0x1E9C9D0 Offset: 0x1E9CAD1 VA: 0x1E9C9D0
	|-GenericComparer<ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>.Compare
	|
	|-RVA: 0x1E9CBD0 Offset: 0x1E9CCD1 VA: 0x1E9CBD0
	|-GenericComparer<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.Compare
	|
	|-RVA: 0x1E9CE30 Offset: 0x1E9CF31 VA: 0x1E9CE30
	|-GenericComparer<ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>.Compare
	|
	|-RVA: 0x1E9D030 Offset: 0x1E9D131 VA: 0x1E9D030
	|-GenericComparer<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>>.Compare
	|
	|-RVA: 0x1E9D2B0 Offset: 0x1E9D3B1 VA: 0x1E9D2B0
	|-GenericComparer<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.Compare
	|
	|-RVA: 0x1E9D480 Offset: 0x1E9D581 VA: 0x1E9D480
	|-GenericComparer<ValueTuple<bool, AsyncUnit>>.Compare
	|
	|-RVA: 0x1E9D5F0 Offset: 0x1E9D6F1 VA: 0x1E9D5F0
	|-GenericComparer<ValueTuple<bool, bool>>.Compare
	|
	|-RVA: 0x1E9D760 Offset: 0x1E9D861 VA: 0x1E9D760
	|-GenericComparer<ValueTuple<bool, Bounds>>.Compare
	|
	|-RVA: 0x1E9D940 Offset: 0x1E9DA41 VA: 0x1E9D940
	|-GenericComparer<ValueTuple<bool, byte>>.Compare
	|
	|-RVA: 0x1E9DAB0 Offset: 0x1E9DBB1 VA: 0x1E9DAB0
	|-GenericComparer<ValueTuple<bool, Color>>.Compare
	|
	|-RVA: 0x1E9DC70 Offset: 0x1E9DD71 VA: 0x1E9DC70
	|-GenericComparer<ValueTuple<bool, double>>.Compare
	|
	|-RVA: 0x1E9DE00 Offset: 0x1E9DF01 VA: 0x1E9DE00
	|-GenericComparer<ValueTuple<bool, int>>.Compare
	|
	|-RVA: 0x1E9DF70 Offset: 0x1E9E071 VA: 0x1E9DF70
	|-GenericComparer<ValueTuple<bool, long>>.Compare
	|
	|-RVA: 0x1E9E100 Offset: 0x1E9E201 VA: 0x1E9E100
	|-GenericComparer<ValueTuple<bool, object>>.Compare
	|
	|-RVA: 0x1E9E290 Offset: 0x1E9E391 VA: 0x1E9E290
	|-GenericComparer<ValueTuple<bool, Quaternion>>.Compare
	|
	|-RVA: 0x1E9E450 Offset: 0x1E9E551 VA: 0x1E9E450
	|-GenericComparer<ValueTuple<bool, Rect>>.Compare
	|
	|-RVA: 0x1E9E610 Offset: 0x1E9E711 VA: 0x1E9E610
	|-GenericComparer<ValueTuple<bool, float>>.Compare
	|
	|-RVA: 0x1E9E780 Offset: 0x1E9E881 VA: 0x1E9E780
	|-GenericComparer<ValueTuple<bool, UniTask>>.Compare
	|
	|-RVA: 0x1E9E910 Offset: 0x1E9EA11 VA: 0x1E9E910
	|-GenericComparer<ValueTuple<bool, Unit>>.Compare
	|
	|-RVA: 0x1E9EA80 Offset: 0x1E9EB81 VA: 0x1E9EA80
	|-GenericComparer<ValueTuple<bool, Vector2>>.Compare
	|
	|-RVA: 0x1E9EC10 Offset: 0x1E9ED11 VA: 0x1E9EC10
	|-GenericComparer<ValueTuple<bool, Vector3>>.Compare
	|
	|-RVA: 0x1E9EDA0 Offset: 0x1E9EEA1 VA: 0x1E9EDA0
	|-GenericComparer<ValueTuple<bool, Vector4>>.Compare
	|
	|-RVA: 0x1E9EF60 Offset: 0x1E9F061 VA: 0x1E9EF60
	|-GenericComparer<ValueTuple<int, object>>.Compare
	|
	|-RVA: 0x1E9F0F0 Offset: 0x1E9F1F1 VA: 0x1E9F0F0
	|-GenericComparer<ValueTuple<Int32Enum, int>>.Compare
	|
	|-RVA: 0x1E9F260 Offset: 0x1E9F361 VA: 0x1E9F260
	|-GenericComparer<ValueTuple<object, ValueTuple<object, int>>>.Compare
	|
	|-RVA: 0x1E9F420 Offset: 0x1E9F521 VA: 0x1E9F420
	|-GenericComparer<ValueTuple<object, int>>.Compare
	|
	|-RVA: 0x1E9F5B0 Offset: 0x1E9F6B1 VA: 0x1E9F5B0
	|-GenericComparer<ValueTuple<object, object>>.Compare
	|
	|-RVA: 0x1E9F740 Offset: 0x1E9F841 VA: 0x1E9F740
	|-GenericComparer<ValueTuple<Vector3, float>>.Compare
	|
	|-RVA: 0x1E9F8F0 Offset: 0x1E9F9F1 VA: 0x1E9F8F0
	|-GenericComparer<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>.Compare
	|
	|-RVA: 0x1E9FAD0 Offset: 0x1E9FBD1 VA: 0x1E9FAD0
	|-GenericComparer<ValueTuple<object, Int32Enum, int>>.Compare
	|
	|-RVA: 0x1E9FC60 Offset: 0x1E9FD61 VA: 0x1E9FC60
	|-GenericComparer<ValueTuple<object, object, object>>.Compare
	|
	|-RVA: 0x1E9FE20 Offset: 0x1E9FF21 VA: 0x1E9FE20
	|-GenericComparer<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.Compare
	|
	|-RVA: 0x1EA0020 Offset: 0x1EA0121 VA: 0x1EA0020
	|-GenericComparer<ValueTuple<object, int, int, int>>.Compare
	|
	|-RVA: 0x1EA01E0 Offset: 0x1EA02E1 VA: 0x1EA01E0
	|-GenericComparer<ValueTuple<object, object, object, object>>.Compare
	|
	|-RVA: 0x1EA03A0 Offset: 0x1EA04A1 VA: 0x1EA03A0
	|-GenericComparer<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.Compare
	|
	|-RVA: 0x1EA05C0 Offset: 0x1EA06C1 VA: 0x1EA05C0
	|-GenericComparer<ValueTuple<object, object, object, object, object>>.Compare
	|
	|-RVA: 0x1EA07A0 Offset: 0x1EA08A1 VA: 0x1EA07A0
	|-GenericComparer<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.Compare
	|
	|-RVA: 0x1EA09E0 Offset: 0x1EA0AE1 VA: 0x1EA09E0
	|-GenericComparer<ValueTuple<object, object, object, object, object, object>>.Compare
	|
	|-RVA: 0x1EA0BC0 Offset: 0x1EA0CC1 VA: 0x1EA0BC0
	|-GenericComparer<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.Compare
	|
	|-RVA: 0x1EA0E20 Offset: 0x1EA0F21 VA: 0x1EA0E20
	|-GenericComparer<ValueTuple<object, object, object, object, object, object, object>>.Compare
	|
	|-RVA: 0x1EA1020 Offset: 0x1EA1121 VA: 0x1EA1020
	|-GenericComparer<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>.Compare
	|
	|-RVA: 0x1EA12A0 Offset: 0x1EA13A1 VA: 0x1EA12A0
	|-GenericComparer<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>.Compare
	|
	|-RVA: 0x1EA1470 Offset: 0x1EA1571 VA: 0x1EA1470
	|-GenericComparer<bool>.Compare
	|
	|-RVA: 0x1EA1540 Offset: 0x1EA1641 VA: 0x1EA1540
	|-GenericComparer<byte>.Compare
	|
	|-RVA: 0x1EA1610 Offset: 0x1EA1711 VA: 0x1EA1610
	|-GenericComparer<char>.Compare
	|
	|-RVA: 0x1EA16E0 Offset: 0x1EA17E1 VA: 0x1EA16E0
	|-GenericComparer<DateTime>.Compare
	|
	|-RVA: 0x1EA17B0 Offset: 0x1EA18B1 VA: 0x1EA17B0
	|-GenericComparer<DateTimeOffset>.Compare
	|
	|-RVA: 0x1EA1880 Offset: 0x1EA1981 VA: 0x1EA1880
	|-GenericComparer<Decimal>.Compare
	|
	|-RVA: 0x1EA1950 Offset: 0x1EA1A51 VA: 0x1EA1950
	|-GenericComparer<double>.Compare
	|
	|-RVA: 0x1EA1A20 Offset: 0x1EA1B21 VA: 0x1EA1A20
	|-GenericComparer<short>.Compare
	|
	|-RVA: 0x1EA1AF0 Offset: 0x1EA1BF1 VA: 0x1EA1AF0
	|-GenericComparer<int>.Compare
	|
	|-RVA: 0x1EA1BC0 Offset: 0x1EA1CC1 VA: 0x1EA1BC0
	|-GenericComparer<long>.Compare
	|
	|-RVA: 0x1EA1C90 Offset: 0x1EA1D91 VA: 0x1EA1C90
	|-GenericComparer<object>.Compare
	|
	|-RVA: 0x1EA1E00 Offset: 0x1EA1F01 VA: 0x1EA1E00
	|-GenericComparer<sbyte>.Compare
	|
	|-RVA: 0x1EA1ED0 Offset: 0x1EA1FD1 VA: 0x1EA1ED0
	|-GenericComparer<float>.Compare
	|
	|-RVA: 0x1EA1FA0 Offset: 0x1EA20A1 VA: 0x1EA1FA0
	|-GenericComparer<TimeSpan>.Compare
	|
	|-RVA: 0x1EA2070 Offset: 0x1EA2171 VA: 0x1EA2070
	|-GenericComparer<ushort>.Compare
	|
	|-RVA: 0x1EA2140 Offset: 0x1EA2241 VA: 0x1EA2140
	|-GenericComparer<uint>.Compare
	|
	|-RVA: 0x1EA2210 Offset: 0x1EA2311 VA: 0x1EA2210
	|-GenericComparer<ulong>.Compare
	|
	|-RVA: 0x1EA22E0 Offset: 0x1EA23E1 VA: 0x1EA22E0
	|-GenericComparer<ShadowUtility.Edge>.Compare
	|
	|-RVA: 0x1EA23C0 Offset: 0x1EA24C1 VA: 0x1EA23C0
	|-GenericComparer<AIThink.EnchantThink.ItemInfo>.Compare
	*/

	// RVA: -1 Offset: -1 Slot: 0
	public override bool Equals(object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E8F670 Offset: 0x1E8F771 VA: 0x1E8F670
	|-GenericComparer<ValueTuple<ValueTuple<bool, object>>>.Equals
	|
	|-RVA: 0x1E8F830 Offset: 0x1E8F931 VA: 0x1E8F830
	|-GenericComparer<ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>.Equals
	|
	|-RVA: 0x1E8F9F0 Offset: 0x1E8FAF1 VA: 0x1E8F9F0
	|-GenericComparer<ValueTuple<bool, UniTask<object>>>.Equals
	|
	|-RVA: 0x1E8FBB0 Offset: 0x1E8FCB1 VA: 0x1E8FBB0
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>.Equals
	|
	|-RVA: 0x1E8FD90 Offset: 0x1E8FE91 VA: 0x1E8FD90
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>>.Equals
	|
	|-RVA: 0x1E8FF70 Offset: 0x1E90071 VA: 0x1E8FF70
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>>>.Equals
	|
	|-RVA: 0x1E900F0 Offset: 0x1E901F1 VA: 0x1E900F0
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>>>.Equals
	|
	|-RVA: 0x1E90270 Offset: 0x1E90371 VA: 0x1E90270
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>>>.Equals
	|
	|-RVA: 0x1E90470 Offset: 0x1E90571 VA: 0x1E90470
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>>>.Equals
	|
	|-RVA: 0x1E905F0 Offset: 0x1E906F1 VA: 0x1E905F0
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>>>.Equals
	|
	|-RVA: 0x1E907E0 Offset: 0x1E908E1 VA: 0x1E907E0
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>>>.Equals
	|
	|-RVA: 0x1E909C0 Offset: 0x1E90AC1 VA: 0x1E909C0
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>>>.Equals
	|
	|-RVA: 0x1E90B80 Offset: 0x1E90C81 VA: 0x1E90B80
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>>>.Equals
	|
	|-RVA: 0x1E90D60 Offset: 0x1E90E61 VA: 0x1E90D60
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>>>.Equals
	|
	|-RVA: 0x1E90F40 Offset: 0x1E91041 VA: 0x1E90F40
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>>>.Equals
	|
	|-RVA: 0x1E91130 Offset: 0x1E91231 VA: 0x1E91130
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>>>.Equals
	|
	|-RVA: 0x1E91320 Offset: 0x1E91421 VA: 0x1E91320
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>>>.Equals
	|
	|-RVA: 0x1E914E0 Offset: 0x1E915E1 VA: 0x1E914E0
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>>>.Equals
	|
	|-RVA: 0x1E916C0 Offset: 0x1E917C1 VA: 0x1E916C0
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>>>.Equals
	|
	|-RVA: 0x1E91840 Offset: 0x1E91941 VA: 0x1E91840
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>>>.Equals
	|
	|-RVA: 0x1E91A20 Offset: 0x1E91B21 VA: 0x1E91A20
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>>>.Equals
	|
	|-RVA: 0x1E91BE0 Offset: 0x1E91CE1 VA: 0x1E91BE0
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>>>.Equals
	|
	|-RVA: 0x1E91DD0 Offset: 0x1E91ED1 VA: 0x1E91DD0
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>>>.Equals
	|
	|-RVA: 0x1E91FB0 Offset: 0x1E920B1 VA: 0x1E91FB0
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>>>.Equals
	|
	|-RVA: 0x1E92190 Offset: 0x1E92291 VA: 0x1E92190
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>>>.Equals
	|
	|-RVA: 0x1E92390 Offset: 0x1E92491 VA: 0x1E92390
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>>>.Equals
	|
	|-RVA: 0x1E92590 Offset: 0x1E92691 VA: 0x1E92590
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>>>.Equals
	|
	|-RVA: 0x1E927B0 Offset: 0x1E928B1 VA: 0x1E927B0
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>>>.Equals
	|
	|-RVA: 0x1E929D0 Offset: 0x1E92AD1 VA: 0x1E929D0
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>>>.Equals
	|
	|-RVA: 0x1E92C10 Offset: 0x1E92D11 VA: 0x1E92C10
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>>>.Equals
	|
	|-RVA: 0x1E92D90 Offset: 0x1E92E91 VA: 0x1E92D90
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>>.Equals
	|
	|-RVA: 0x1E92F10 Offset: 0x1E93011 VA: 0x1E92F10
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>>.Equals
	|
	|-RVA: 0x1E930F0 Offset: 0x1E931F1 VA: 0x1E930F0
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>>.Equals
	|
	|-RVA: 0x1E93270 Offset: 0x1E93371 VA: 0x1E93270
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>>.Equals
	|
	|-RVA: 0x1E93430 Offset: 0x1E93531 VA: 0x1E93430
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>>.Equals
	|
	|-RVA: 0x1E93610 Offset: 0x1E93711 VA: 0x1E93610
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>>.Equals
	|
	|-RVA: 0x1E937D0 Offset: 0x1E938D1 VA: 0x1E937D0
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>>.Equals
	|
	|-RVA: 0x1E939B0 Offset: 0x1E93AB1 VA: 0x1E939B0
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>>.Equals
	|
	|-RVA: 0x1E93B90 Offset: 0x1E93C91 VA: 0x1E93B90
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>>.Equals
	|
	|-RVA: 0x1E93D50 Offset: 0x1E93E51 VA: 0x1E93D50
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>>.Equals
	|
	|-RVA: 0x1E93F10 Offset: 0x1E94011 VA: 0x1E93F10
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>>.Equals
	|
	|-RVA: 0x1E940D0 Offset: 0x1E941D1 VA: 0x1E940D0
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>>.Equals
	|
	|-RVA: 0x1E942B0 Offset: 0x1E943B1 VA: 0x1E942B0
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>>.Equals
	|
	|-RVA: 0x1E94430 Offset: 0x1E94531 VA: 0x1E94430
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>>.Equals
	|
	|-RVA: 0x1E945F0 Offset: 0x1E946F1 VA: 0x1E945F0
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>>.Equals
	|
	|-RVA: 0x1E947D0 Offset: 0x1E948D1 VA: 0x1E947D0
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>>.Equals
	|
	|-RVA: 0x1E94990 Offset: 0x1E94A91 VA: 0x1E94990
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>>.Equals
	|
	|-RVA: 0x1E94B70 Offset: 0x1E94C71 VA: 0x1E94B70
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>>.Equals
	|
	|-RVA: 0x1E94D50 Offset: 0x1E94E51 VA: 0x1E94D50
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>>.Equals
	|
	|-RVA: 0x1E94F50 Offset: 0x1E95051 VA: 0x1E94F50
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.Equals
	|
	|-RVA: 0x1E95130 Offset: 0x1E95231 VA: 0x1E95130
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>>.Equals
	|
	|-RVA: 0x1E95350 Offset: 0x1E95451 VA: 0x1E95350
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.Equals
	|
	|-RVA: 0x1E95550 Offset: 0x1E95651 VA: 0x1E95550
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>>.Equals
	|
	|-RVA: 0x1E95790 Offset: 0x1E95891 VA: 0x1E95790
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.Equals
	|
	|-RVA: 0x1E95990 Offset: 0x1E95A91 VA: 0x1E95990
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>>.Equals
	|
	|-RVA: 0x1E95BF0 Offset: 0x1E95CF1 VA: 0x1E95BF0
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.Equals
	|
	|-RVA: 0x1E95E10 Offset: 0x1E95F11 VA: 0x1E95E10
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>>.Equals
	|
	|-RVA: 0x1E96090 Offset: 0x1E96191 VA: 0x1E96090
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.Equals
	|
	|-RVA: 0x1E962B0 Offset: 0x1E963B1 VA: 0x1E962B0
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>>.Equals
	|
	|-RVA: 0x1E96420 Offset: 0x1E96521 VA: 0x1E96420
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>.Equals
	|
	|-RVA: 0x1E96590 Offset: 0x1E96691 VA: 0x1E96590
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>.Equals
	|
	|-RVA: 0x1E96780 Offset: 0x1E96881 VA: 0x1E96780
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>.Equals
	|
	|-RVA: 0x1E968F0 Offset: 0x1E969F1 VA: 0x1E968F0
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>.Equals
	|
	|-RVA: 0x1E96AD0 Offset: 0x1E96BD1 VA: 0x1E96AD0
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>.Equals
	|
	|-RVA: 0x1E96C90 Offset: 0x1E96D91 VA: 0x1E96C90
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>.Equals
	|
	|-RVA: 0x1E96E20 Offset: 0x1E96F21 VA: 0x1E96E20
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>.Equals
	|
	|-RVA: 0x1E96FE0 Offset: 0x1E970E1 VA: 0x1E96FE0
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>.Equals
	|
	|-RVA: 0x1E971A0 Offset: 0x1E972A1 VA: 0x1E971A0
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>.Equals
	|
	|-RVA: 0x1E97380 Offset: 0x1E97481 VA: 0x1E97380
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>.Equals
	|
	|-RVA: 0x1E97560 Offset: 0x1E97661 VA: 0x1E97560
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>.Equals
	|
	|-RVA: 0x1E976F0 Offset: 0x1E977F1 VA: 0x1E976F0
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>.Equals
	|
	|-RVA: 0x1E978B0 Offset: 0x1E979B1 VA: 0x1E978B0
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>.Equals
	|
	|-RVA: 0x1E97A20 Offset: 0x1E97B21 VA: 0x1E97A20
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>.Equals
	|
	|-RVA: 0x1E97BE0 Offset: 0x1E97CE1 VA: 0x1E97BE0
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>.Equals
	|
	|-RVA: 0x1E97DA0 Offset: 0x1E97EA1 VA: 0x1E97DA0
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>.Equals
	|
	|-RVA: 0x1E97F80 Offset: 0x1E98081 VA: 0x1E97F80
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>.Equals
	|
	|-RVA: 0x1E98140 Offset: 0x1E98241 VA: 0x1E98140
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>.Equals
	|
	|-RVA: 0x1E98300 Offset: 0x1E98401 VA: 0x1E98300
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>.Equals
	|
	|-RVA: 0x1E98500 Offset: 0x1E98601 VA: 0x1E98500
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.Equals
	|
	|-RVA: 0x1E986E0 Offset: 0x1E987E1 VA: 0x1E986E0
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>.Equals
	|
	|-RVA: 0x1E98900 Offset: 0x1E98A01 VA: 0x1E98900
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.Equals
	|
	|-RVA: 0x1E98AE0 Offset: 0x1E98BE1 VA: 0x1E98AE0
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>.Equals
	|
	|-RVA: 0x1E98D20 Offset: 0x1E98E21 VA: 0x1E98D20
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.Equals
	|
	|-RVA: 0x1E98F20 Offset: 0x1E99021 VA: 0x1E98F20
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>.Equals
	|
	|-RVA: 0x1E99180 Offset: 0x1E99281 VA: 0x1E99180
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.Equals
	|
	|-RVA: 0x1E99380 Offset: 0x1E99481 VA: 0x1E99380
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>.Equals
	|
	|-RVA: 0x1E99600 Offset: 0x1E99701 VA: 0x1E99600
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.Equals
	|
	|-RVA: 0x1E99820 Offset: 0x1E99921 VA: 0x1E99820
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>.Equals
	|
	|-RVA: 0x1E999F0 Offset: 0x1E99AF1 VA: 0x1E999F0
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>>>.Equals
	|
	|-RVA: 0x1E99BC0 Offset: 0x1E99CC1 VA: 0x1E99BC0
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.Equals
	|
	|-RVA: 0x1E99D40 Offset: 0x1E99E41 VA: 0x1E99D40
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>.Equals
	|
	|-RVA: 0x1E99EC0 Offset: 0x1E99FC1 VA: 0x1E99EC0
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, bool>>>.Equals
	|
	|-RVA: 0x1E9A080 Offset: 0x1E9A181 VA: 0x1E9A080
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, Bounds>>>.Equals
	|
	|-RVA: 0x1E9A200 Offset: 0x1E9A301 VA: 0x1E9A200
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, byte>>>.Equals
	|
	|-RVA: 0x1E9A3C0 Offset: 0x1E9A4C1 VA: 0x1E9A3C0
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, Color>>>.Equals
	|
	|-RVA: 0x1E9A580 Offset: 0x1E9A681 VA: 0x1E9A580
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, double>>>.Equals
	|
	|-RVA: 0x1E9A710 Offset: 0x1E9A811 VA: 0x1E9A710
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, int>>>.Equals
	|
	|-RVA: 0x1E9A8D0 Offset: 0x1E9A9D1 VA: 0x1E9A8D0
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, long>>>.Equals
	|
	|-RVA: 0x1E9AA90 Offset: 0x1E9AB91 VA: 0x1E9AA90
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, object>>>.Equals
	|
	|-RVA: 0x1E9AC50 Offset: 0x1E9AD51 VA: 0x1E9AC50
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, Quaternion>>>.Equals
	|
	|-RVA: 0x1E9AE10 Offset: 0x1E9AF11 VA: 0x1E9AE10
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, Rect>>>.Equals
	|
	|-RVA: 0x1E9AFA0 Offset: 0x1E9B0A1 VA: 0x1E9AFA0
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, float>>>.Equals
	|
	|-RVA: 0x1E9B160 Offset: 0x1E9B261 VA: 0x1E9B160
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, UniTask>>>.Equals
	|
	|-RVA: 0x1E9B2E0 Offset: 0x1E9B3E1 VA: 0x1E9B2E0
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, Unit>>>.Equals
	|
	|-RVA: 0x1E9B470 Offset: 0x1E9B571 VA: 0x1E9B470
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, Vector2>>>.Equals
	|
	|-RVA: 0x1E9B630 Offset: 0x1E9B731 VA: 0x1E9B630
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, Vector3>>>.Equals
	|
	|-RVA: 0x1E9B7F0 Offset: 0x1E9B8F1 VA: 0x1E9B7F0
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, Vector4>>>.Equals
	|
	|-RVA: 0x1E9B9B0 Offset: 0x1E9BAB1 VA: 0x1E9B9B0
	|-GenericComparer<ValueTuple<bool, ValueTuple<int, object>>>.Equals
	|
	|-RVA: 0x1E9BB70 Offset: 0x1E9BC71 VA: 0x1E9BB70
	|-GenericComparer<ValueTuple<bool, ValueTuple<object, object>>>.Equals
	|
	|-RVA: 0x1E9BD50 Offset: 0x1E9BE51 VA: 0x1E9BD50
	|-GenericComparer<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.Equals
	|
	|-RVA: 0x1E9BF10 Offset: 0x1E9C011 VA: 0x1E9BF10
	|-GenericComparer<ValueTuple<bool, ValueTuple<object, object, object>>>.Equals
	|
	|-RVA: 0x1E9C110 Offset: 0x1E9C211 VA: 0x1E9C110
	|-GenericComparer<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.Equals
	|
	|-RVA: 0x1E9C2F0 Offset: 0x1E9C3F1 VA: 0x1E9C2F0
	|-GenericComparer<ValueTuple<bool, ValueTuple<object, object, object, object>>>.Equals
	|
	|-RVA: 0x1E9C510 Offset: 0x1E9C611 VA: 0x1E9C510
	|-GenericComparer<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.Equals
	|
	|-RVA: 0x1E9C6F0 Offset: 0x1E9C7F1 VA: 0x1E9C6F0
	|-GenericComparer<ValueTuple<bool, ValueTuple<object, object, object, object, object>>>.Equals
	|
	|-RVA: 0x1E9C930 Offset: 0x1E9CA31 VA: 0x1E9C930
	|-GenericComparer<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.Equals
	|
	|-RVA: 0x1E9CB30 Offset: 0x1E9CC31 VA: 0x1E9CB30
	|-GenericComparer<ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>.Equals
	|
	|-RVA: 0x1E9CD90 Offset: 0x1E9CE91 VA: 0x1E9CD90
	|-GenericComparer<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.Equals
	|
	|-RVA: 0x1E9CF90 Offset: 0x1E9D091 VA: 0x1E9CF90
	|-GenericComparer<ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>.Equals
	|
	|-RVA: 0x1E9D210 Offset: 0x1E9D311 VA: 0x1E9D210
	|-GenericComparer<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>>.Equals
	|
	|-RVA: 0x1E9D3E0 Offset: 0x1E9D4E1 VA: 0x1E9D3E0
	|-GenericComparer<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.Equals
	|
	|-RVA: 0x1E9D550 Offset: 0x1E9D651 VA: 0x1E9D550
	|-GenericComparer<ValueTuple<bool, AsyncUnit>>.Equals
	|
	|-RVA: 0x1E9D6C0 Offset: 0x1E9D7C1 VA: 0x1E9D6C0
	|-GenericComparer<ValueTuple<bool, bool>>.Equals
	|
	|-RVA: 0x1E9D8A0 Offset: 0x1E9D9A1 VA: 0x1E9D8A0
	|-GenericComparer<ValueTuple<bool, Bounds>>.Equals
	|
	|-RVA: 0x1E9DA10 Offset: 0x1E9DB11 VA: 0x1E9DA10
	|-GenericComparer<ValueTuple<bool, byte>>.Equals
	|
	|-RVA: 0x1E9DBD0 Offset: 0x1E9DCD1 VA: 0x1E9DBD0
	|-GenericComparer<ValueTuple<bool, Color>>.Equals
	|
	|-RVA: 0x1E9DD60 Offset: 0x1E9DE61 VA: 0x1E9DD60
	|-GenericComparer<ValueTuple<bool, double>>.Equals
	|
	|-RVA: 0x1E9DED0 Offset: 0x1E9DFD1 VA: 0x1E9DED0
	|-GenericComparer<ValueTuple<bool, int>>.Equals
	|
	|-RVA: 0x1E9E060 Offset: 0x1E9E161 VA: 0x1E9E060
	|-GenericComparer<ValueTuple<bool, long>>.Equals
	|
	|-RVA: 0x1E9E1F0 Offset: 0x1E9E2F1 VA: 0x1E9E1F0
	|-GenericComparer<ValueTuple<bool, object>>.Equals
	|
	|-RVA: 0x1E9E3B0 Offset: 0x1E9E4B1 VA: 0x1E9E3B0
	|-GenericComparer<ValueTuple<bool, Quaternion>>.Equals
	|
	|-RVA: 0x1E9E570 Offset: 0x1E9E671 VA: 0x1E9E570
	|-GenericComparer<ValueTuple<bool, Rect>>.Equals
	|
	|-RVA: 0x1E9E6E0 Offset: 0x1E9E7E1 VA: 0x1E9E6E0
	|-GenericComparer<ValueTuple<bool, float>>.Equals
	|
	|-RVA: 0x1E9E870 Offset: 0x1E9E971 VA: 0x1E9E870
	|-GenericComparer<ValueTuple<bool, UniTask>>.Equals
	|
	|-RVA: 0x1E9E9E0 Offset: 0x1E9EAE1 VA: 0x1E9E9E0
	|-GenericComparer<ValueTuple<bool, Unit>>.Equals
	|
	|-RVA: 0x1E9EB70 Offset: 0x1E9EC71 VA: 0x1E9EB70
	|-GenericComparer<ValueTuple<bool, Vector2>>.Equals
	|
	|-RVA: 0x1E9ED00 Offset: 0x1E9EE01 VA: 0x1E9ED00
	|-GenericComparer<ValueTuple<bool, Vector3>>.Equals
	|
	|-RVA: 0x1E9EEC0 Offset: 0x1E9EFC1 VA: 0x1E9EEC0
	|-GenericComparer<ValueTuple<bool, Vector4>>.Equals
	|
	|-RVA: 0x1E9F050 Offset: 0x1E9F151 VA: 0x1E9F050
	|-GenericComparer<ValueTuple<int, object>>.Equals
	|
	|-RVA: 0x1E9F1C0 Offset: 0x1E9F2C1 VA: 0x1E9F1C0
	|-GenericComparer<ValueTuple<Int32Enum, int>>.Equals
	|
	|-RVA: 0x1E9F380 Offset: 0x1E9F481 VA: 0x1E9F380
	|-GenericComparer<ValueTuple<object, ValueTuple<object, int>>>.Equals
	|
	|-RVA: 0x1E9F510 Offset: 0x1E9F611 VA: 0x1E9F510
	|-GenericComparer<ValueTuple<object, int>>.Equals
	|
	|-RVA: 0x1E9F6A0 Offset: 0x1E9F7A1 VA: 0x1E9F6A0
	|-GenericComparer<ValueTuple<object, object>>.Equals
	|
	|-RVA: 0x1E9F850 Offset: 0x1E9F951 VA: 0x1E9F850
	|-GenericComparer<ValueTuple<Vector3, float>>.Equals
	|
	|-RVA: 0x1E9FA30 Offset: 0x1E9FB31 VA: 0x1E9FA30
	|-GenericComparer<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>.Equals
	|
	|-RVA: 0x1E9FBC0 Offset: 0x1E9FCC1 VA: 0x1E9FBC0
	|-GenericComparer<ValueTuple<object, Int32Enum, int>>.Equals
	|
	|-RVA: 0x1E9FD80 Offset: 0x1E9FE81 VA: 0x1E9FD80
	|-GenericComparer<ValueTuple<object, object, object>>.Equals
	|
	|-RVA: 0x1E9FF80 Offset: 0x1EA0081 VA: 0x1E9FF80
	|-GenericComparer<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.Equals
	|
	|-RVA: 0x1EA0140 Offset: 0x1EA0241 VA: 0x1EA0140
	|-GenericComparer<ValueTuple<object, int, int, int>>.Equals
	|
	|-RVA: 0x1EA0300 Offset: 0x1EA0401 VA: 0x1EA0300
	|-GenericComparer<ValueTuple<object, object, object, object>>.Equals
	|
	|-RVA: 0x1EA0520 Offset: 0x1EA0621 VA: 0x1EA0520
	|-GenericComparer<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.Equals
	|
	|-RVA: 0x1EA0700 Offset: 0x1EA0801 VA: 0x1EA0700
	|-GenericComparer<ValueTuple<object, object, object, object, object>>.Equals
	|
	|-RVA: 0x1EA0940 Offset: 0x1EA0A41 VA: 0x1EA0940
	|-GenericComparer<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.Equals
	|
	|-RVA: 0x1EA0B20 Offset: 0x1EA0C21 VA: 0x1EA0B20
	|-GenericComparer<ValueTuple<object, object, object, object, object, object>>.Equals
	|
	|-RVA: 0x1EA0D80 Offset: 0x1EA0E81 VA: 0x1EA0D80
	|-GenericComparer<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.Equals
	|
	|-RVA: 0x1EA0F80 Offset: 0x1EA1081 VA: 0x1EA0F80
	|-GenericComparer<ValueTuple<object, object, object, object, object, object, object>>.Equals
	|
	|-RVA: 0x1EA1200 Offset: 0x1EA1301 VA: 0x1EA1200
	|-GenericComparer<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>.Equals
	|
	|-RVA: 0x1EA13D0 Offset: 0x1EA14D1 VA: 0x1EA13D0
	|-GenericComparer<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>.Equals
	|
	|-RVA: 0x1EA14A0 Offset: 0x1EA15A1 VA: 0x1EA14A0
	|-GenericComparer<bool>.Equals
	|
	|-RVA: 0x1EA1570 Offset: 0x1EA1671 VA: 0x1EA1570
	|-GenericComparer<byte>.Equals
	|
	|-RVA: 0x1EA1640 Offset: 0x1EA1741 VA: 0x1EA1640
	|-GenericComparer<char>.Equals
	|
	|-RVA: 0x1EA1710 Offset: 0x1EA1811 VA: 0x1EA1710
	|-GenericComparer<DateTime>.Equals
	|
	|-RVA: 0x1EA17E0 Offset: 0x1EA18E1 VA: 0x1EA17E0
	|-GenericComparer<DateTimeOffset>.Equals
	|
	|-RVA: 0x1EA18B0 Offset: 0x1EA19B1 VA: 0x1EA18B0
	|-GenericComparer<Decimal>.Equals
	|
	|-RVA: 0x1EA1980 Offset: 0x1EA1A81 VA: 0x1EA1980
	|-GenericComparer<double>.Equals
	|
	|-RVA: 0x1EA1A50 Offset: 0x1EA1B51 VA: 0x1EA1A50
	|-GenericComparer<short>.Equals
	|
	|-RVA: 0x1EA1B20 Offset: 0x1EA1C21 VA: 0x1EA1B20
	|-GenericComparer<int>.Equals
	|
	|-RVA: 0x1EA1BF0 Offset: 0x1EA1CF1 VA: 0x1EA1BF0
	|-GenericComparer<long>.Equals
	|
	|-RVA: 0x1EA1D60 Offset: 0x1EA1E61 VA: 0x1EA1D60
	|-GenericComparer<object>.Equals
	|
	|-RVA: 0x1EA1E30 Offset: 0x1EA1F31 VA: 0x1EA1E30
	|-GenericComparer<sbyte>.Equals
	|
	|-RVA: 0x1EA1F00 Offset: 0x1EA2001 VA: 0x1EA1F00
	|-GenericComparer<float>.Equals
	|
	|-RVA: 0x1EA1FD0 Offset: 0x1EA20D1 VA: 0x1EA1FD0
	|-GenericComparer<TimeSpan>.Equals
	|
	|-RVA: 0x1EA20A0 Offset: 0x1EA21A1 VA: 0x1EA20A0
	|-GenericComparer<ushort>.Equals
	|
	|-RVA: 0x1EA2170 Offset: 0x1EA2271 VA: 0x1EA2170
	|-GenericComparer<uint>.Equals
	|
	|-RVA: 0x1EA2240 Offset: 0x1EA2341 VA: 0x1EA2240
	|-GenericComparer<ulong>.Equals
	|
	|-RVA: 0x1EA2320 Offset: 0x1EA2421 VA: 0x1EA2320
	|-GenericComparer<ShadowUtility.Edge>.Equals
	|
	|-RVA: 0x1EA23F0 Offset: 0x1EA24F1 VA: 0x1EA23F0
	|-GenericComparer<AIThink.EnchantThink.ItemInfo>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public override int GetHashCode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E8F6C0 Offset: 0x1E8F7C1 VA: 0x1E8F6C0
	|-GenericComparer<ValueTuple<ValueTuple<bool, object>>>.GetHashCode
	|
	|-RVA: 0x1E8F880 Offset: 0x1E8F981 VA: 0x1E8F880
	|-GenericComparer<ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>.GetHashCode
	|
	|-RVA: 0x1E8FA40 Offset: 0x1E8FB41 VA: 0x1E8FA40
	|-GenericComparer<ValueTuple<bool, UniTask<object>>>.GetHashCode
	|
	|-RVA: 0x1E8FC00 Offset: 0x1E8FD01 VA: 0x1E8FC00
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>.GetHashCode
	|
	|-RVA: 0x1E8FDE0 Offset: 0x1E8FEE1 VA: 0x1E8FDE0
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>>.GetHashCode
	|
	|-RVA: 0x1E8FFC0 Offset: 0x1E900C1 VA: 0x1E8FFC0
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>>>.GetHashCode
	|
	|-RVA: 0x1E90140 Offset: 0x1E90241 VA: 0x1E90140
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>>>.GetHashCode
	|
	|-RVA: 0x1E902C0 Offset: 0x1E903C1 VA: 0x1E902C0
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>>>.GetHashCode
	|
	|-RVA: 0x1E904C0 Offset: 0x1E905C1 VA: 0x1E904C0
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>>>.GetHashCode
	|
	|-RVA: 0x1E90640 Offset: 0x1E90741 VA: 0x1E90640
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>>>.GetHashCode
	|
	|-RVA: 0x1E90830 Offset: 0x1E90931 VA: 0x1E90830
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>>>.GetHashCode
	|
	|-RVA: 0x1E90A10 Offset: 0x1E90B11 VA: 0x1E90A10
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>>>.GetHashCode
	|
	|-RVA: 0x1E90BD0 Offset: 0x1E90CD1 VA: 0x1E90BD0
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>>>.GetHashCode
	|
	|-RVA: 0x1E90DB0 Offset: 0x1E90EB1 VA: 0x1E90DB0
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>>>.GetHashCode
	|
	|-RVA: 0x1E90F90 Offset: 0x1E91091 VA: 0x1E90F90
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>>>.GetHashCode
	|
	|-RVA: 0x1E91180 Offset: 0x1E91281 VA: 0x1E91180
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>>>.GetHashCode
	|
	|-RVA: 0x1E91370 Offset: 0x1E91471 VA: 0x1E91370
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>>>.GetHashCode
	|
	|-RVA: 0x1E91530 Offset: 0x1E91631 VA: 0x1E91530
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>>>.GetHashCode
	|
	|-RVA: 0x1E91710 Offset: 0x1E91811 VA: 0x1E91710
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>>>.GetHashCode
	|
	|-RVA: 0x1E91890 Offset: 0x1E91991 VA: 0x1E91890
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>>>.GetHashCode
	|
	|-RVA: 0x1E91A70 Offset: 0x1E91B71 VA: 0x1E91A70
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>>>.GetHashCode
	|
	|-RVA: 0x1E91C30 Offset: 0x1E91D31 VA: 0x1E91C30
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>>>.GetHashCode
	|
	|-RVA: 0x1E91E20 Offset: 0x1E91F21 VA: 0x1E91E20
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>>>.GetHashCode
	|
	|-RVA: 0x1E92000 Offset: 0x1E92101 VA: 0x1E92000
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>>>.GetHashCode
	|
	|-RVA: 0x1E921E0 Offset: 0x1E922E1 VA: 0x1E921E0
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>>>.GetHashCode
	|
	|-RVA: 0x1E923E0 Offset: 0x1E924E1 VA: 0x1E923E0
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>>>.GetHashCode
	|
	|-RVA: 0x1E925E0 Offset: 0x1E926E1 VA: 0x1E925E0
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>>>.GetHashCode
	|
	|-RVA: 0x1E92800 Offset: 0x1E92901 VA: 0x1E92800
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>>>.GetHashCode
	|
	|-RVA: 0x1E92A20 Offset: 0x1E92B21 VA: 0x1E92A20
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>>>.GetHashCode
	|
	|-RVA: 0x1E92C60 Offset: 0x1E92D61 VA: 0x1E92C60
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>>>.GetHashCode
	|
	|-RVA: 0x1E92DE0 Offset: 0x1E92EE1 VA: 0x1E92DE0
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>>.GetHashCode
	|
	|-RVA: 0x1E92F60 Offset: 0x1E93061 VA: 0x1E92F60
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>>.GetHashCode
	|
	|-RVA: 0x1E93140 Offset: 0x1E93241 VA: 0x1E93140
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>>.GetHashCode
	|
	|-RVA: 0x1E932C0 Offset: 0x1E933C1 VA: 0x1E932C0
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>>.GetHashCode
	|
	|-RVA: 0x1E93480 Offset: 0x1E93581 VA: 0x1E93480
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>>.GetHashCode
	|
	|-RVA: 0x1E93660 Offset: 0x1E93761 VA: 0x1E93660
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>>.GetHashCode
	|
	|-RVA: 0x1E93820 Offset: 0x1E93921 VA: 0x1E93820
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>>.GetHashCode
	|
	|-RVA: 0x1E93A00 Offset: 0x1E93B01 VA: 0x1E93A00
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>>.GetHashCode
	|
	|-RVA: 0x1E93BE0 Offset: 0x1E93CE1 VA: 0x1E93BE0
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>>.GetHashCode
	|
	|-RVA: 0x1E93DA0 Offset: 0x1E93EA1 VA: 0x1E93DA0
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>>.GetHashCode
	|
	|-RVA: 0x1E93F60 Offset: 0x1E94061 VA: 0x1E93F60
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>>.GetHashCode
	|
	|-RVA: 0x1E94120 Offset: 0x1E94221 VA: 0x1E94120
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>>.GetHashCode
	|
	|-RVA: 0x1E94300 Offset: 0x1E94401 VA: 0x1E94300
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>>.GetHashCode
	|
	|-RVA: 0x1E94480 Offset: 0x1E94581 VA: 0x1E94480
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>>.GetHashCode
	|
	|-RVA: 0x1E94640 Offset: 0x1E94741 VA: 0x1E94640
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>>.GetHashCode
	|
	|-RVA: 0x1E94820 Offset: 0x1E94921 VA: 0x1E94820
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>>.GetHashCode
	|
	|-RVA: 0x1E949E0 Offset: 0x1E94AE1 VA: 0x1E949E0
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>>.GetHashCode
	|
	|-RVA: 0x1E94BC0 Offset: 0x1E94CC1 VA: 0x1E94BC0
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>>.GetHashCode
	|
	|-RVA: 0x1E94DA0 Offset: 0x1E94EA1 VA: 0x1E94DA0
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>>.GetHashCode
	|
	|-RVA: 0x1E94FA0 Offset: 0x1E950A1 VA: 0x1E94FA0
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.GetHashCode
	|
	|-RVA: 0x1E95180 Offset: 0x1E95281 VA: 0x1E95180
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>>.GetHashCode
	|
	|-RVA: 0x1E953A0 Offset: 0x1E954A1 VA: 0x1E953A0
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.GetHashCode
	|
	|-RVA: 0x1E955A0 Offset: 0x1E956A1 VA: 0x1E955A0
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>>.GetHashCode
	|
	|-RVA: 0x1E957E0 Offset: 0x1E958E1 VA: 0x1E957E0
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.GetHashCode
	|
	|-RVA: 0x1E959E0 Offset: 0x1E95AE1 VA: 0x1E959E0
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>>.GetHashCode
	|
	|-RVA: 0x1E95C40 Offset: 0x1E95D41 VA: 0x1E95C40
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.GetHashCode
	|
	|-RVA: 0x1E95E60 Offset: 0x1E95F61 VA: 0x1E95E60
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>>.GetHashCode
	|
	|-RVA: 0x1E960E0 Offset: 0x1E961E1 VA: 0x1E960E0
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.GetHashCode
	|
	|-RVA: 0x1E96300 Offset: 0x1E96401 VA: 0x1E96300
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>>.GetHashCode
	|
	|-RVA: 0x1E96470 Offset: 0x1E96571 VA: 0x1E96470
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>.GetHashCode
	|
	|-RVA: 0x1E965E0 Offset: 0x1E966E1 VA: 0x1E965E0
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>.GetHashCode
	|
	|-RVA: 0x1E967D0 Offset: 0x1E968D1 VA: 0x1E967D0
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>.GetHashCode
	|
	|-RVA: 0x1E96940 Offset: 0x1E96A41 VA: 0x1E96940
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>.GetHashCode
	|
	|-RVA: 0x1E96B20 Offset: 0x1E96C21 VA: 0x1E96B20
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>.GetHashCode
	|
	|-RVA: 0x1E96CE0 Offset: 0x1E96DE1 VA: 0x1E96CE0
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>.GetHashCode
	|
	|-RVA: 0x1E96E70 Offset: 0x1E96F71 VA: 0x1E96E70
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>.GetHashCode
	|
	|-RVA: 0x1E97030 Offset: 0x1E97131 VA: 0x1E97030
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>.GetHashCode
	|
	|-RVA: 0x1E971F0 Offset: 0x1E972F1 VA: 0x1E971F0
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>.GetHashCode
	|
	|-RVA: 0x1E973D0 Offset: 0x1E974D1 VA: 0x1E973D0
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>.GetHashCode
	|
	|-RVA: 0x1E975B0 Offset: 0x1E976B1 VA: 0x1E975B0
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>.GetHashCode
	|
	|-RVA: 0x1E97740 Offset: 0x1E97841 VA: 0x1E97740
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>.GetHashCode
	|
	|-RVA: 0x1E97900 Offset: 0x1E97A01 VA: 0x1E97900
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>.GetHashCode
	|
	|-RVA: 0x1E97A70 Offset: 0x1E97B71 VA: 0x1E97A70
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>.GetHashCode
	|
	|-RVA: 0x1E97C30 Offset: 0x1E97D31 VA: 0x1E97C30
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>.GetHashCode
	|
	|-RVA: 0x1E97DF0 Offset: 0x1E97EF1 VA: 0x1E97DF0
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>.GetHashCode
	|
	|-RVA: 0x1E97FD0 Offset: 0x1E980D1 VA: 0x1E97FD0
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>.GetHashCode
	|
	|-RVA: 0x1E98190 Offset: 0x1E98291 VA: 0x1E98190
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>.GetHashCode
	|
	|-RVA: 0x1E98350 Offset: 0x1E98451 VA: 0x1E98350
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>.GetHashCode
	|
	|-RVA: 0x1E98550 Offset: 0x1E98651 VA: 0x1E98550
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.GetHashCode
	|
	|-RVA: 0x1E98730 Offset: 0x1E98831 VA: 0x1E98730
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>.GetHashCode
	|
	|-RVA: 0x1E98950 Offset: 0x1E98A51 VA: 0x1E98950
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.GetHashCode
	|
	|-RVA: 0x1E98B30 Offset: 0x1E98C31 VA: 0x1E98B30
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>.GetHashCode
	|
	|-RVA: 0x1E98D70 Offset: 0x1E98E71 VA: 0x1E98D70
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.GetHashCode
	|
	|-RVA: 0x1E98F70 Offset: 0x1E99071 VA: 0x1E98F70
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>.GetHashCode
	|
	|-RVA: 0x1E991D0 Offset: 0x1E992D1 VA: 0x1E991D0
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.GetHashCode
	|
	|-RVA: 0x1E993D0 Offset: 0x1E994D1 VA: 0x1E993D0
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>.GetHashCode
	|
	|-RVA: 0x1E99650 Offset: 0x1E99751 VA: 0x1E99650
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.GetHashCode
	|
	|-RVA: 0x1E99870 Offset: 0x1E99971 VA: 0x1E99870
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>.GetHashCode
	|
	|-RVA: 0x1E99A40 Offset: 0x1E99B41 VA: 0x1E99A40
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>>>.GetHashCode
	|
	|-RVA: 0x1E99C10 Offset: 0x1E99D11 VA: 0x1E99C10
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.GetHashCode
	|
	|-RVA: 0x1E99D90 Offset: 0x1E99E91 VA: 0x1E99D90
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>.GetHashCode
	|
	|-RVA: 0x1E99F10 Offset: 0x1E9A011 VA: 0x1E99F10
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, bool>>>.GetHashCode
	|
	|-RVA: 0x1E9A0D0 Offset: 0x1E9A1D1 VA: 0x1E9A0D0
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, Bounds>>>.GetHashCode
	|
	|-RVA: 0x1E9A250 Offset: 0x1E9A351 VA: 0x1E9A250
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, byte>>>.GetHashCode
	|
	|-RVA: 0x1E9A410 Offset: 0x1E9A511 VA: 0x1E9A410
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, Color>>>.GetHashCode
	|
	|-RVA: 0x1E9A5D0 Offset: 0x1E9A6D1 VA: 0x1E9A5D0
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, double>>>.GetHashCode
	|
	|-RVA: 0x1E9A760 Offset: 0x1E9A861 VA: 0x1E9A760
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, int>>>.GetHashCode
	|
	|-RVA: 0x1E9A920 Offset: 0x1E9AA21 VA: 0x1E9A920
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, long>>>.GetHashCode
	|
	|-RVA: 0x1E9AAE0 Offset: 0x1E9ABE1 VA: 0x1E9AAE0
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, object>>>.GetHashCode
	|
	|-RVA: 0x1E9ACA0 Offset: 0x1E9ADA1 VA: 0x1E9ACA0
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, Quaternion>>>.GetHashCode
	|
	|-RVA: 0x1E9AE60 Offset: 0x1E9AF61 VA: 0x1E9AE60
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, Rect>>>.GetHashCode
	|
	|-RVA: 0x1E9AFF0 Offset: 0x1E9B0F1 VA: 0x1E9AFF0
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, float>>>.GetHashCode
	|
	|-RVA: 0x1E9B1B0 Offset: 0x1E9B2B1 VA: 0x1E9B1B0
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, UniTask>>>.GetHashCode
	|
	|-RVA: 0x1E9B330 Offset: 0x1E9B431 VA: 0x1E9B330
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, Unit>>>.GetHashCode
	|
	|-RVA: 0x1E9B4C0 Offset: 0x1E9B5C1 VA: 0x1E9B4C0
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, Vector2>>>.GetHashCode
	|
	|-RVA: 0x1E9B680 Offset: 0x1E9B781 VA: 0x1E9B680
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, Vector3>>>.GetHashCode
	|
	|-RVA: 0x1E9B840 Offset: 0x1E9B941 VA: 0x1E9B840
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, Vector4>>>.GetHashCode
	|
	|-RVA: 0x1E9BA00 Offset: 0x1E9BB01 VA: 0x1E9BA00
	|-GenericComparer<ValueTuple<bool, ValueTuple<int, object>>>.GetHashCode
	|
	|-RVA: 0x1E9BBC0 Offset: 0x1E9BCC1 VA: 0x1E9BBC0
	|-GenericComparer<ValueTuple<bool, ValueTuple<object, object>>>.GetHashCode
	|
	|-RVA: 0x1E9BDA0 Offset: 0x1E9BEA1 VA: 0x1E9BDA0
	|-GenericComparer<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.GetHashCode
	|
	|-RVA: 0x1E9BF60 Offset: 0x1E9C061 VA: 0x1E9BF60
	|-GenericComparer<ValueTuple<bool, ValueTuple<object, object, object>>>.GetHashCode
	|
	|-RVA: 0x1E9C160 Offset: 0x1E9C261 VA: 0x1E9C160
	|-GenericComparer<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.GetHashCode
	|
	|-RVA: 0x1E9C340 Offset: 0x1E9C441 VA: 0x1E9C340
	|-GenericComparer<ValueTuple<bool, ValueTuple<object, object, object, object>>>.GetHashCode
	|
	|-RVA: 0x1E9C560 Offset: 0x1E9C661 VA: 0x1E9C560
	|-GenericComparer<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.GetHashCode
	|
	|-RVA: 0x1E9C740 Offset: 0x1E9C841 VA: 0x1E9C740
	|-GenericComparer<ValueTuple<bool, ValueTuple<object, object, object, object, object>>>.GetHashCode
	|
	|-RVA: 0x1E9C980 Offset: 0x1E9CA81 VA: 0x1E9C980
	|-GenericComparer<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.GetHashCode
	|
	|-RVA: 0x1E9CB80 Offset: 0x1E9CC81 VA: 0x1E9CB80
	|-GenericComparer<ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>.GetHashCode
	|
	|-RVA: 0x1E9CDE0 Offset: 0x1E9CEE1 VA: 0x1E9CDE0
	|-GenericComparer<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.GetHashCode
	|
	|-RVA: 0x1E9CFE0 Offset: 0x1E9D0E1 VA: 0x1E9CFE0
	|-GenericComparer<ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>.GetHashCode
	|
	|-RVA: 0x1E9D260 Offset: 0x1E9D361 VA: 0x1E9D260
	|-GenericComparer<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>>.GetHashCode
	|
	|-RVA: 0x1E9D430 Offset: 0x1E9D531 VA: 0x1E9D430
	|-GenericComparer<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.GetHashCode
	|
	|-RVA: 0x1E9D5A0 Offset: 0x1E9D6A1 VA: 0x1E9D5A0
	|-GenericComparer<ValueTuple<bool, AsyncUnit>>.GetHashCode
	|
	|-RVA: 0x1E9D710 Offset: 0x1E9D811 VA: 0x1E9D710
	|-GenericComparer<ValueTuple<bool, bool>>.GetHashCode
	|
	|-RVA: 0x1E9D8F0 Offset: 0x1E9D9F1 VA: 0x1E9D8F0
	|-GenericComparer<ValueTuple<bool, Bounds>>.GetHashCode
	|
	|-RVA: 0x1E9DA60 Offset: 0x1E9DB61 VA: 0x1E9DA60
	|-GenericComparer<ValueTuple<bool, byte>>.GetHashCode
	|
	|-RVA: 0x1E9DC20 Offset: 0x1E9DD21 VA: 0x1E9DC20
	|-GenericComparer<ValueTuple<bool, Color>>.GetHashCode
	|
	|-RVA: 0x1E9DDB0 Offset: 0x1E9DEB1 VA: 0x1E9DDB0
	|-GenericComparer<ValueTuple<bool, double>>.GetHashCode
	|
	|-RVA: 0x1E9DF20 Offset: 0x1E9E021 VA: 0x1E9DF20
	|-GenericComparer<ValueTuple<bool, int>>.GetHashCode
	|
	|-RVA: 0x1E9E0B0 Offset: 0x1E9E1B1 VA: 0x1E9E0B0
	|-GenericComparer<ValueTuple<bool, long>>.GetHashCode
	|
	|-RVA: 0x1E9E240 Offset: 0x1E9E341 VA: 0x1E9E240
	|-GenericComparer<ValueTuple<bool, object>>.GetHashCode
	|
	|-RVA: 0x1E9E400 Offset: 0x1E9E501 VA: 0x1E9E400
	|-GenericComparer<ValueTuple<bool, Quaternion>>.GetHashCode
	|
	|-RVA: 0x1E9E5C0 Offset: 0x1E9E6C1 VA: 0x1E9E5C0
	|-GenericComparer<ValueTuple<bool, Rect>>.GetHashCode
	|
	|-RVA: 0x1E9E730 Offset: 0x1E9E831 VA: 0x1E9E730
	|-GenericComparer<ValueTuple<bool, float>>.GetHashCode
	|
	|-RVA: 0x1E9E8C0 Offset: 0x1E9E9C1 VA: 0x1E9E8C0
	|-GenericComparer<ValueTuple<bool, UniTask>>.GetHashCode
	|
	|-RVA: 0x1E9EA30 Offset: 0x1E9EB31 VA: 0x1E9EA30
	|-GenericComparer<ValueTuple<bool, Unit>>.GetHashCode
	|
	|-RVA: 0x1E9EBC0 Offset: 0x1E9ECC1 VA: 0x1E9EBC0
	|-GenericComparer<ValueTuple<bool, Vector2>>.GetHashCode
	|
	|-RVA: 0x1E9ED50 Offset: 0x1E9EE51 VA: 0x1E9ED50
	|-GenericComparer<ValueTuple<bool, Vector3>>.GetHashCode
	|
	|-RVA: 0x1E9EF10 Offset: 0x1E9F011 VA: 0x1E9EF10
	|-GenericComparer<ValueTuple<bool, Vector4>>.GetHashCode
	|
	|-RVA: 0x1E9F0A0 Offset: 0x1E9F1A1 VA: 0x1E9F0A0
	|-GenericComparer<ValueTuple<int, object>>.GetHashCode
	|
	|-RVA: 0x1E9F210 Offset: 0x1E9F311 VA: 0x1E9F210
	|-GenericComparer<ValueTuple<Int32Enum, int>>.GetHashCode
	|
	|-RVA: 0x1E9F3D0 Offset: 0x1E9F4D1 VA: 0x1E9F3D0
	|-GenericComparer<ValueTuple<object, ValueTuple<object, int>>>.GetHashCode
	|
	|-RVA: 0x1E9F560 Offset: 0x1E9F661 VA: 0x1E9F560
	|-GenericComparer<ValueTuple<object, int>>.GetHashCode
	|
	|-RVA: 0x1E9F6F0 Offset: 0x1E9F7F1 VA: 0x1E9F6F0
	|-GenericComparer<ValueTuple<object, object>>.GetHashCode
	|
	|-RVA: 0x1E9F8A0 Offset: 0x1E9F9A1 VA: 0x1E9F8A0
	|-GenericComparer<ValueTuple<Vector3, float>>.GetHashCode
	|
	|-RVA: 0x1E9FA80 Offset: 0x1E9FB81 VA: 0x1E9FA80
	|-GenericComparer<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>.GetHashCode
	|
	|-RVA: 0x1E9FC10 Offset: 0x1E9FD11 VA: 0x1E9FC10
	|-GenericComparer<ValueTuple<object, Int32Enum, int>>.GetHashCode
	|
	|-RVA: 0x1E9FDD0 Offset: 0x1E9FED1 VA: 0x1E9FDD0
	|-GenericComparer<ValueTuple<object, object, object>>.GetHashCode
	|
	|-RVA: 0x1E9FFD0 Offset: 0x1EA00D1 VA: 0x1E9FFD0
	|-GenericComparer<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.GetHashCode
	|
	|-RVA: 0x1EA0190 Offset: 0x1EA0291 VA: 0x1EA0190
	|-GenericComparer<ValueTuple<object, int, int, int>>.GetHashCode
	|
	|-RVA: 0x1EA0350 Offset: 0x1EA0451 VA: 0x1EA0350
	|-GenericComparer<ValueTuple<object, object, object, object>>.GetHashCode
	|
	|-RVA: 0x1EA0570 Offset: 0x1EA0671 VA: 0x1EA0570
	|-GenericComparer<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.GetHashCode
	|
	|-RVA: 0x1EA0750 Offset: 0x1EA0851 VA: 0x1EA0750
	|-GenericComparer<ValueTuple<object, object, object, object, object>>.GetHashCode
	|
	|-RVA: 0x1EA0990 Offset: 0x1EA0A91 VA: 0x1EA0990
	|-GenericComparer<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.GetHashCode
	|
	|-RVA: 0x1EA0B70 Offset: 0x1EA0C71 VA: 0x1EA0B70
	|-GenericComparer<ValueTuple<object, object, object, object, object, object>>.GetHashCode
	|
	|-RVA: 0x1EA0DD0 Offset: 0x1EA0ED1 VA: 0x1EA0DD0
	|-GenericComparer<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.GetHashCode
	|
	|-RVA: 0x1EA0FD0 Offset: 0x1EA10D1 VA: 0x1EA0FD0
	|-GenericComparer<ValueTuple<object, object, object, object, object, object, object>>.GetHashCode
	|
	|-RVA: 0x1EA1250 Offset: 0x1EA1351 VA: 0x1EA1250
	|-GenericComparer<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>.GetHashCode
	|
	|-RVA: 0x1EA1420 Offset: 0x1EA1521 VA: 0x1EA1420
	|-GenericComparer<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>.GetHashCode
	|
	|-RVA: 0x1EA14F0 Offset: 0x1EA15F1 VA: 0x1EA14F0
	|-GenericComparer<bool>.GetHashCode
	|
	|-RVA: 0x1EA15C0 Offset: 0x1EA16C1 VA: 0x1EA15C0
	|-GenericComparer<byte>.GetHashCode
	|
	|-RVA: 0x1EA1690 Offset: 0x1EA1791 VA: 0x1EA1690
	|-GenericComparer<char>.GetHashCode
	|
	|-RVA: 0x1EA1760 Offset: 0x1EA1861 VA: 0x1EA1760
	|-GenericComparer<DateTime>.GetHashCode
	|
	|-RVA: 0x1EA1830 Offset: 0x1EA1931 VA: 0x1EA1830
	|-GenericComparer<DateTimeOffset>.GetHashCode
	|
	|-RVA: 0x1EA1900 Offset: 0x1EA1A01 VA: 0x1EA1900
	|-GenericComparer<Decimal>.GetHashCode
	|
	|-RVA: 0x1EA19D0 Offset: 0x1EA1AD1 VA: 0x1EA19D0
	|-GenericComparer<double>.GetHashCode
	|
	|-RVA: 0x1EA1AA0 Offset: 0x1EA1BA1 VA: 0x1EA1AA0
	|-GenericComparer<short>.GetHashCode
	|
	|-RVA: 0x1EA1B70 Offset: 0x1EA1C71 VA: 0x1EA1B70
	|-GenericComparer<int>.GetHashCode
	|
	|-RVA: 0x1EA1C40 Offset: 0x1EA1D41 VA: 0x1EA1C40
	|-GenericComparer<long>.GetHashCode
	|
	|-RVA: 0x1EA1DB0 Offset: 0x1EA1EB1 VA: 0x1EA1DB0
	|-GenericComparer<object>.GetHashCode
	|
	|-RVA: 0x1EA1E80 Offset: 0x1EA1F81 VA: 0x1EA1E80
	|-GenericComparer<sbyte>.GetHashCode
	|
	|-RVA: 0x1EA1F50 Offset: 0x1EA2051 VA: 0x1EA1F50
	|-GenericComparer<float>.GetHashCode
	|
	|-RVA: 0x1EA2020 Offset: 0x1EA2121 VA: 0x1EA2020
	|-GenericComparer<TimeSpan>.GetHashCode
	|
	|-RVA: 0x1EA20F0 Offset: 0x1EA21F1 VA: 0x1EA20F0
	|-GenericComparer<ushort>.GetHashCode
	|
	|-RVA: 0x1EA21C0 Offset: 0x1EA22C1 VA: 0x1EA21C0
	|-GenericComparer<uint>.GetHashCode
	|
	|-RVA: 0x1EA2290 Offset: 0x1EA2391 VA: 0x1EA2290
	|-GenericComparer<ulong>.GetHashCode
	|
	|-RVA: 0x1EA2370 Offset: 0x1EA2471 VA: 0x1EA2370
	|-GenericComparer<ShadowUtility.Edge>.GetHashCode
	|
	|-RVA: 0x1EA2440 Offset: 0x1EA2541 VA: 0x1EA2440
	|-GenericComparer<AIThink.EnchantThink.ItemInfo>.GetHashCode
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E8F6F0 Offset: 0x1E8F7F1 VA: 0x1E8F6F0
	|-GenericComparer<ValueTuple<ValueTuple<bool, object>>>..ctor
	|
	|-RVA: 0x1E8F8B0 Offset: 0x1E8F9B1 VA: 0x1E8F8B0
	|-GenericComparer<ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>..ctor
	|
	|-RVA: 0x1E8FA70 Offset: 0x1E8FB71 VA: 0x1E8FA70
	|-GenericComparer<ValueTuple<bool, UniTask<object>>>..ctor
	|
	|-RVA: 0x1E8FC30 Offset: 0x1E8FD31 VA: 0x1E8FC30
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>..ctor
	|
	|-RVA: 0x1E8FE10 Offset: 0x1E8FF11 VA: 0x1E8FE10
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>>..ctor
	|
	|-RVA: 0x1E8FFF0 Offset: 0x1E900F1 VA: 0x1E8FFF0
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>>>..ctor
	|
	|-RVA: 0x1E90170 Offset: 0x1E90271 VA: 0x1E90170
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>>>..ctor
	|
	|-RVA: 0x1E902F0 Offset: 0x1E903F1 VA: 0x1E902F0
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>>>..ctor
	|
	|-RVA: 0x1E904F0 Offset: 0x1E905F1 VA: 0x1E904F0
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>>>..ctor
	|
	|-RVA: 0x1E90670 Offset: 0x1E90771 VA: 0x1E90670
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>>>..ctor
	|
	|-RVA: 0x1E90860 Offset: 0x1E90961 VA: 0x1E90860
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>>>..ctor
	|
	|-RVA: 0x1E90A40 Offset: 0x1E90B41 VA: 0x1E90A40
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>>>..ctor
	|
	|-RVA: 0x1E90C00 Offset: 0x1E90D01 VA: 0x1E90C00
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>>>..ctor
	|
	|-RVA: 0x1E90DE0 Offset: 0x1E90EE1 VA: 0x1E90DE0
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>>>..ctor
	|
	|-RVA: 0x1E90FC0 Offset: 0x1E910C1 VA: 0x1E90FC0
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>>>..ctor
	|
	|-RVA: 0x1E911B0 Offset: 0x1E912B1 VA: 0x1E911B0
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>>>..ctor
	|
	|-RVA: 0x1E913A0 Offset: 0x1E914A1 VA: 0x1E913A0
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>>>..ctor
	|
	|-RVA: 0x1E91560 Offset: 0x1E91661 VA: 0x1E91560
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>>>..ctor
	|
	|-RVA: 0x1E91740 Offset: 0x1E91841 VA: 0x1E91740
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>>>..ctor
	|
	|-RVA: 0x1E918C0 Offset: 0x1E919C1 VA: 0x1E918C0
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>>>..ctor
	|
	|-RVA: 0x1E91AA0 Offset: 0x1E91BA1 VA: 0x1E91AA0
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>>>..ctor
	|
	|-RVA: 0x1E91C60 Offset: 0x1E91D61 VA: 0x1E91C60
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>>>..ctor
	|
	|-RVA: 0x1E91E50 Offset: 0x1E91F51 VA: 0x1E91E50
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>>>..ctor
	|
	|-RVA: 0x1E92030 Offset: 0x1E92131 VA: 0x1E92030
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>>>..ctor
	|
	|-RVA: 0x1E92210 Offset: 0x1E92311 VA: 0x1E92210
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>>>..ctor
	|
	|-RVA: 0x1E92410 Offset: 0x1E92511 VA: 0x1E92410
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>>>..ctor
	|
	|-RVA: 0x1E92610 Offset: 0x1E92711 VA: 0x1E92610
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>>>..ctor
	|
	|-RVA: 0x1E92830 Offset: 0x1E92931 VA: 0x1E92830
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>>>..ctor
	|
	|-RVA: 0x1E92A50 Offset: 0x1E92B51 VA: 0x1E92A50
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>>>..ctor
	|
	|-RVA: 0x1E92C90 Offset: 0x1E92D91 VA: 0x1E92C90
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>>>..ctor
	|
	|-RVA: 0x1E92E10 Offset: 0x1E92F11 VA: 0x1E92E10
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>>..ctor
	|
	|-RVA: 0x1E92F90 Offset: 0x1E93091 VA: 0x1E92F90
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>>..ctor
	|
	|-RVA: 0x1E93170 Offset: 0x1E93271 VA: 0x1E93170
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>>..ctor
	|
	|-RVA: 0x1E932F0 Offset: 0x1E933F1 VA: 0x1E932F0
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>>..ctor
	|
	|-RVA: 0x1E934B0 Offset: 0x1E935B1 VA: 0x1E934B0
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>>..ctor
	|
	|-RVA: 0x1E93690 Offset: 0x1E93791 VA: 0x1E93690
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>>..ctor
	|
	|-RVA: 0x1E93850 Offset: 0x1E93951 VA: 0x1E93850
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>>..ctor
	|
	|-RVA: 0x1E93A30 Offset: 0x1E93B31 VA: 0x1E93A30
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>>..ctor
	|
	|-RVA: 0x1E93C10 Offset: 0x1E93D11 VA: 0x1E93C10
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>>..ctor
	|
	|-RVA: 0x1E93DD0 Offset: 0x1E93ED1 VA: 0x1E93DD0
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>>..ctor
	|
	|-RVA: 0x1E93F90 Offset: 0x1E94091 VA: 0x1E93F90
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>>..ctor
	|
	|-RVA: 0x1E94150 Offset: 0x1E94251 VA: 0x1E94150
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>>..ctor
	|
	|-RVA: 0x1E94330 Offset: 0x1E94431 VA: 0x1E94330
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>>..ctor
	|
	|-RVA: 0x1E944B0 Offset: 0x1E945B1 VA: 0x1E944B0
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>>..ctor
	|
	|-RVA: 0x1E94670 Offset: 0x1E94771 VA: 0x1E94670
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>>..ctor
	|
	|-RVA: 0x1E94850 Offset: 0x1E94951 VA: 0x1E94850
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>>..ctor
	|
	|-RVA: 0x1E94A10 Offset: 0x1E94B11 VA: 0x1E94A10
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>>..ctor
	|
	|-RVA: 0x1E94BF0 Offset: 0x1E94CF1 VA: 0x1E94BF0
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>>..ctor
	|
	|-RVA: 0x1E94DD0 Offset: 0x1E94ED1 VA: 0x1E94DD0
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>>..ctor
	|
	|-RVA: 0x1E94FD0 Offset: 0x1E950D1 VA: 0x1E94FD0
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>..ctor
	|
	|-RVA: 0x1E951B0 Offset: 0x1E952B1 VA: 0x1E951B0
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>>..ctor
	|
	|-RVA: 0x1E953D0 Offset: 0x1E954D1 VA: 0x1E953D0
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>..ctor
	|
	|-RVA: 0x1E955D0 Offset: 0x1E956D1 VA: 0x1E955D0
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>>..ctor
	|
	|-RVA: 0x1E95810 Offset: 0x1E95911 VA: 0x1E95810
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>..ctor
	|
	|-RVA: 0x1E95A10 Offset: 0x1E95B11 VA: 0x1E95A10
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>>..ctor
	|
	|-RVA: 0x1E95C70 Offset: 0x1E95D71 VA: 0x1E95C70
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>..ctor
	|
	|-RVA: 0x1E95E90 Offset: 0x1E95F91 VA: 0x1E95E90
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>>..ctor
	|
	|-RVA: 0x1E96110 Offset: 0x1E96211 VA: 0x1E96110
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>..ctor
	|
	|-RVA: 0x1E96330 Offset: 0x1E96431 VA: 0x1E96330
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>>..ctor
	|
	|-RVA: 0x1E964A0 Offset: 0x1E965A1 VA: 0x1E964A0
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>..ctor
	|
	|-RVA: 0x1E96610 Offset: 0x1E96711 VA: 0x1E96610
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>..ctor
	|
	|-RVA: 0x1E96800 Offset: 0x1E96901 VA: 0x1E96800
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>..ctor
	|
	|-RVA: 0x1E96970 Offset: 0x1E96A71 VA: 0x1E96970
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>..ctor
	|
	|-RVA: 0x1E96B50 Offset: 0x1E96C51 VA: 0x1E96B50
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>..ctor
	|
	|-RVA: 0x1E96D10 Offset: 0x1E96E11 VA: 0x1E96D10
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>..ctor
	|
	|-RVA: 0x1E96EA0 Offset: 0x1E96FA1 VA: 0x1E96EA0
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>..ctor
	|
	|-RVA: 0x1E97060 Offset: 0x1E97161 VA: 0x1E97060
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>..ctor
	|
	|-RVA: 0x1E97220 Offset: 0x1E97321 VA: 0x1E97220
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>..ctor
	|
	|-RVA: 0x1E97400 Offset: 0x1E97501 VA: 0x1E97400
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>..ctor
	|
	|-RVA: 0x1E975E0 Offset: 0x1E976E1 VA: 0x1E975E0
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>..ctor
	|
	|-RVA: 0x1E97770 Offset: 0x1E97871 VA: 0x1E97770
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>..ctor
	|
	|-RVA: 0x1E97930 Offset: 0x1E97A31 VA: 0x1E97930
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>..ctor
	|
	|-RVA: 0x1E97AA0 Offset: 0x1E97BA1 VA: 0x1E97AA0
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>..ctor
	|
	|-RVA: 0x1E97C60 Offset: 0x1E97D61 VA: 0x1E97C60
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>..ctor
	|
	|-RVA: 0x1E97E20 Offset: 0x1E97F21 VA: 0x1E97E20
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>..ctor
	|
	|-RVA: 0x1E98000 Offset: 0x1E98101 VA: 0x1E98000
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>..ctor
	|
	|-RVA: 0x1E981C0 Offset: 0x1E982C1 VA: 0x1E981C0
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>..ctor
	|
	|-RVA: 0x1E98380 Offset: 0x1E98481 VA: 0x1E98380
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>..ctor
	|
	|-RVA: 0x1E98580 Offset: 0x1E98681 VA: 0x1E98580
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>..ctor
	|
	|-RVA: 0x1E98760 Offset: 0x1E98861 VA: 0x1E98760
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>..ctor
	|
	|-RVA: 0x1E98980 Offset: 0x1E98A81 VA: 0x1E98980
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>..ctor
	|
	|-RVA: 0x1E98B60 Offset: 0x1E98C61 VA: 0x1E98B60
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>..ctor
	|
	|-RVA: 0x1E98DA0 Offset: 0x1E98EA1 VA: 0x1E98DA0
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>..ctor
	|
	|-RVA: 0x1E98FA0 Offset: 0x1E990A1 VA: 0x1E98FA0
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>..ctor
	|
	|-RVA: 0x1E99200 Offset: 0x1E99301 VA: 0x1E99200
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>..ctor
	|
	|-RVA: 0x1E99400 Offset: 0x1E99501 VA: 0x1E99400
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>..ctor
	|
	|-RVA: 0x1E99680 Offset: 0x1E99781 VA: 0x1E99680
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>..ctor
	|
	|-RVA: 0x1E998A0 Offset: 0x1E999A1 VA: 0x1E998A0
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>..ctor
	|
	|-RVA: 0x1E99A70 Offset: 0x1E99B71 VA: 0x1E99A70
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>>>..ctor
	|
	|-RVA: 0x1E99C40 Offset: 0x1E99D41 VA: 0x1E99C40
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>..ctor
	|
	|-RVA: 0x1E99DC0 Offset: 0x1E99EC1 VA: 0x1E99DC0
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>..ctor
	|
	|-RVA: 0x1E99F40 Offset: 0x1E9A041 VA: 0x1E99F40
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, bool>>>..ctor
	|
	|-RVA: 0x1E9A100 Offset: 0x1E9A201 VA: 0x1E9A100
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, Bounds>>>..ctor
	|
	|-RVA: 0x1E9A280 Offset: 0x1E9A381 VA: 0x1E9A280
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, byte>>>..ctor
	|
	|-RVA: 0x1E9A440 Offset: 0x1E9A541 VA: 0x1E9A440
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, Color>>>..ctor
	|
	|-RVA: 0x1E9A600 Offset: 0x1E9A701 VA: 0x1E9A600
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, double>>>..ctor
	|
	|-RVA: 0x1E9A790 Offset: 0x1E9A891 VA: 0x1E9A790
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, int>>>..ctor
	|
	|-RVA: 0x1E9A950 Offset: 0x1E9AA51 VA: 0x1E9A950
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, long>>>..ctor
	|
	|-RVA: 0x1E9AB10 Offset: 0x1E9AC11 VA: 0x1E9AB10
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, object>>>..ctor
	|
	|-RVA: 0x1E9ACD0 Offset: 0x1E9ADD1 VA: 0x1E9ACD0
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, Quaternion>>>..ctor
	|
	|-RVA: 0x1E9AE90 Offset: 0x1E9AF91 VA: 0x1E9AE90
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, Rect>>>..ctor
	|
	|-RVA: 0x1E9B020 Offset: 0x1E9B121 VA: 0x1E9B020
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, float>>>..ctor
	|
	|-RVA: 0x1E9B1E0 Offset: 0x1E9B2E1 VA: 0x1E9B1E0
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, UniTask>>>..ctor
	|
	|-RVA: 0x1E9B360 Offset: 0x1E9B461 VA: 0x1E9B360
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, Unit>>>..ctor
	|
	|-RVA: 0x1E9B4F0 Offset: 0x1E9B5F1 VA: 0x1E9B4F0
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, Vector2>>>..ctor
	|
	|-RVA: 0x1E9B6B0 Offset: 0x1E9B7B1 VA: 0x1E9B6B0
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, Vector3>>>..ctor
	|
	|-RVA: 0x1E9B870 Offset: 0x1E9B971 VA: 0x1E9B870
	|-GenericComparer<ValueTuple<bool, ValueTuple<bool, Vector4>>>..ctor
	|
	|-RVA: 0x1E9BA30 Offset: 0x1E9BB31 VA: 0x1E9BA30
	|-GenericComparer<ValueTuple<bool, ValueTuple<int, object>>>..ctor
	|
	|-RVA: 0x1E9BBF0 Offset: 0x1E9BCF1 VA: 0x1E9BBF0
	|-GenericComparer<ValueTuple<bool, ValueTuple<object, object>>>..ctor
	|
	|-RVA: 0x1E9BDD0 Offset: 0x1E9BED1 VA: 0x1E9BDD0
	|-GenericComparer<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>..ctor
	|
	|-RVA: 0x1E9BF90 Offset: 0x1E9C091 VA: 0x1E9BF90
	|-GenericComparer<ValueTuple<bool, ValueTuple<object, object, object>>>..ctor
	|
	|-RVA: 0x1E9C190 Offset: 0x1E9C291 VA: 0x1E9C190
	|-GenericComparer<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>..ctor
	|
	|-RVA: 0x1E9C370 Offset: 0x1E9C471 VA: 0x1E9C370
	|-GenericComparer<ValueTuple<bool, ValueTuple<object, object, object, object>>>..ctor
	|
	|-RVA: 0x1E9C590 Offset: 0x1E9C691 VA: 0x1E9C590
	|-GenericComparer<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>..ctor
	|
	|-RVA: 0x1E9C770 Offset: 0x1E9C871 VA: 0x1E9C770
	|-GenericComparer<ValueTuple<bool, ValueTuple<object, object, object, object, object>>>..ctor
	|
	|-RVA: 0x1E9C9B0 Offset: 0x1E9CAB1 VA: 0x1E9C9B0
	|-GenericComparer<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>..ctor
	|
	|-RVA: 0x1E9CBB0 Offset: 0x1E9CCB1 VA: 0x1E9CBB0
	|-GenericComparer<ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>..ctor
	|
	|-RVA: 0x1E9CE10 Offset: 0x1E9CF11 VA: 0x1E9CE10
	|-GenericComparer<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>..ctor
	|
	|-RVA: 0x1E9D010 Offset: 0x1E9D111 VA: 0x1E9D010
	|-GenericComparer<ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>..ctor
	|
	|-RVA: 0x1E9D290 Offset: 0x1E9D391 VA: 0x1E9D290
	|-GenericComparer<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>>..ctor
	|
	|-RVA: 0x1E9D460 Offset: 0x1E9D561 VA: 0x1E9D460
	|-GenericComparer<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>>..ctor
	|
	|-RVA: 0x1E9D5D0 Offset: 0x1E9D6D1 VA: 0x1E9D5D0
	|-GenericComparer<ValueTuple<bool, AsyncUnit>>..ctor
	|
	|-RVA: 0x1E9D740 Offset: 0x1E9D841 VA: 0x1E9D740
	|-GenericComparer<ValueTuple<bool, bool>>..ctor
	|
	|-RVA: 0x1E9D920 Offset: 0x1E9DA21 VA: 0x1E9D920
	|-GenericComparer<ValueTuple<bool, Bounds>>..ctor
	|
	|-RVA: 0x1E9DA90 Offset: 0x1E9DB91 VA: 0x1E9DA90
	|-GenericComparer<ValueTuple<bool, byte>>..ctor
	|
	|-RVA: 0x1E9DC50 Offset: 0x1E9DD51 VA: 0x1E9DC50
	|-GenericComparer<ValueTuple<bool, Color>>..ctor
	|
	|-RVA: 0x1E9DDE0 Offset: 0x1E9DEE1 VA: 0x1E9DDE0
	|-GenericComparer<ValueTuple<bool, double>>..ctor
	|
	|-RVA: 0x1E9DF50 Offset: 0x1E9E051 VA: 0x1E9DF50
	|-GenericComparer<ValueTuple<bool, int>>..ctor
	|
	|-RVA: 0x1E9E0E0 Offset: 0x1E9E1E1 VA: 0x1E9E0E0
	|-GenericComparer<ValueTuple<bool, long>>..ctor
	|
	|-RVA: 0x1E9E270 Offset: 0x1E9E371 VA: 0x1E9E270
	|-GenericComparer<ValueTuple<bool, object>>..ctor
	|
	|-RVA: 0x1E9E430 Offset: 0x1E9E531 VA: 0x1E9E430
	|-GenericComparer<ValueTuple<bool, Quaternion>>..ctor
	|
	|-RVA: 0x1E9E5F0 Offset: 0x1E9E6F1 VA: 0x1E9E5F0
	|-GenericComparer<ValueTuple<bool, Rect>>..ctor
	|
	|-RVA: 0x1E9E760 Offset: 0x1E9E861 VA: 0x1E9E760
	|-GenericComparer<ValueTuple<bool, float>>..ctor
	|
	|-RVA: 0x1E9E8F0 Offset: 0x1E9E9F1 VA: 0x1E9E8F0
	|-GenericComparer<ValueTuple<bool, UniTask>>..ctor
	|
	|-RVA: 0x1E9EA60 Offset: 0x1E9EB61 VA: 0x1E9EA60
	|-GenericComparer<ValueTuple<bool, Unit>>..ctor
	|
	|-RVA: 0x1E9EBF0 Offset: 0x1E9ECF1 VA: 0x1E9EBF0
	|-GenericComparer<ValueTuple<bool, Vector2>>..ctor
	|
	|-RVA: 0x1E9ED80 Offset: 0x1E9EE81 VA: 0x1E9ED80
	|-GenericComparer<ValueTuple<bool, Vector3>>..ctor
	|
	|-RVA: 0x1E9EF40 Offset: 0x1E9F041 VA: 0x1E9EF40
	|-GenericComparer<ValueTuple<bool, Vector4>>..ctor
	|
	|-RVA: 0x1E9F0D0 Offset: 0x1E9F1D1 VA: 0x1E9F0D0
	|-GenericComparer<ValueTuple<int, object>>..ctor
	|
	|-RVA: 0x1E9F240 Offset: 0x1E9F341 VA: 0x1E9F240
	|-GenericComparer<ValueTuple<Int32Enum, int>>..ctor
	|
	|-RVA: 0x1E9F400 Offset: 0x1E9F501 VA: 0x1E9F400
	|-GenericComparer<ValueTuple<object, ValueTuple<object, int>>>..ctor
	|
	|-RVA: 0x1E9F590 Offset: 0x1E9F691 VA: 0x1E9F590
	|-GenericComparer<ValueTuple<object, int>>..ctor
	|
	|-RVA: 0x1E9F720 Offset: 0x1E9F821 VA: 0x1E9F720
	|-GenericComparer<ValueTuple<object, object>>..ctor
	|
	|-RVA: 0x1E9F8D0 Offset: 0x1E9F9D1 VA: 0x1E9F8D0
	|-GenericComparer<ValueTuple<Vector3, float>>..ctor
	|
	|-RVA: 0x1E9FAB0 Offset: 0x1E9FBB1 VA: 0x1E9FAB0
	|-GenericComparer<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>..ctor
	|
	|-RVA: 0x1E9FC40 Offset: 0x1E9FD41 VA: 0x1E9FC40
	|-GenericComparer<ValueTuple<object, Int32Enum, int>>..ctor
	|
	|-RVA: 0x1E9FE00 Offset: 0x1E9FF01 VA: 0x1E9FE00
	|-GenericComparer<ValueTuple<object, object, object>>..ctor
	|
	|-RVA: 0x1EA0000 Offset: 0x1EA0101 VA: 0x1EA0000
	|-GenericComparer<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>..ctor
	|
	|-RVA: 0x1EA01C0 Offset: 0x1EA02C1 VA: 0x1EA01C0
	|-GenericComparer<ValueTuple<object, int, int, int>>..ctor
	|
	|-RVA: 0x1EA0380 Offset: 0x1EA0481 VA: 0x1EA0380
	|-GenericComparer<ValueTuple<object, object, object, object>>..ctor
	|
	|-RVA: 0x1EA05A0 Offset: 0x1EA06A1 VA: 0x1EA05A0
	|-GenericComparer<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>..ctor
	|
	|-RVA: 0x1EA0780 Offset: 0x1EA0881 VA: 0x1EA0780
	|-GenericComparer<ValueTuple<object, object, object, object, object>>..ctor
	|
	|-RVA: 0x1EA09C0 Offset: 0x1EA0AC1 VA: 0x1EA09C0
	|-GenericComparer<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>..ctor
	|
	|-RVA: 0x1EA0BA0 Offset: 0x1EA0CA1 VA: 0x1EA0BA0
	|-GenericComparer<ValueTuple<object, object, object, object, object, object>>..ctor
	|
	|-RVA: 0x1EA0E00 Offset: 0x1EA0F01 VA: 0x1EA0E00
	|-GenericComparer<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>..ctor
	|
	|-RVA: 0x1EA1000 Offset: 0x1EA1101 VA: 0x1EA1000
	|-GenericComparer<ValueTuple<object, object, object, object, object, object, object>>..ctor
	|
	|-RVA: 0x1EA1280 Offset: 0x1EA1381 VA: 0x1EA1280
	|-GenericComparer<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>..ctor
	|
	|-RVA: 0x1EA1450 Offset: 0x1EA1551 VA: 0x1EA1450
	|-GenericComparer<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>..ctor
	|
	|-RVA: 0x1EA1520 Offset: 0x1EA1621 VA: 0x1EA1520
	|-GenericComparer<bool>..ctor
	|
	|-RVA: 0x1EA15F0 Offset: 0x1EA16F1 VA: 0x1EA15F0
	|-GenericComparer<byte>..ctor
	|
	|-RVA: 0x1EA16C0 Offset: 0x1EA17C1 VA: 0x1EA16C0
	|-GenericComparer<char>..ctor
	|
	|-RVA: 0x1EA1790 Offset: 0x1EA1891 VA: 0x1EA1790
	|-GenericComparer<DateTime>..ctor
	|
	|-RVA: 0x1EA1860 Offset: 0x1EA1961 VA: 0x1EA1860
	|-GenericComparer<DateTimeOffset>..ctor
	|
	|-RVA: 0x1EA1930 Offset: 0x1EA1A31 VA: 0x1EA1930
	|-GenericComparer<Decimal>..ctor
	|
	|-RVA: 0x1EA1A00 Offset: 0x1EA1B01 VA: 0x1EA1A00
	|-GenericComparer<double>..ctor
	|
	|-RVA: 0x1EA1AD0 Offset: 0x1EA1BD1 VA: 0x1EA1AD0
	|-GenericComparer<short>..ctor
	|
	|-RVA: 0x1EA1BA0 Offset: 0x1EA1CA1 VA: 0x1EA1BA0
	|-GenericComparer<int>..ctor
	|
	|-RVA: 0x1EA1C70 Offset: 0x1EA1D71 VA: 0x1EA1C70
	|-GenericComparer<long>..ctor
	|
	|-RVA: 0x1EA1DE0 Offset: 0x1EA1EE1 VA: 0x1EA1DE0
	|-GenericComparer<object>..ctor
	|
	|-RVA: 0x1EA1EB0 Offset: 0x1EA1FB1 VA: 0x1EA1EB0
	|-GenericComparer<sbyte>..ctor
	|
	|-RVA: 0x1EA1F80 Offset: 0x1EA2081 VA: 0x1EA1F80
	|-GenericComparer<float>..ctor
	|
	|-RVA: 0x1EA2050 Offset: 0x1EA2151 VA: 0x1EA2050
	|-GenericComparer<TimeSpan>..ctor
	|
	|-RVA: 0x1EA2120 Offset: 0x1EA2221 VA: 0x1EA2120
	|-GenericComparer<ushort>..ctor
	|
	|-RVA: 0x1EA21F0 Offset: 0x1EA22F1 VA: 0x1EA21F0
	|-GenericComparer<uint>..ctor
	|
	|-RVA: 0x1EA22C0 Offset: 0x1EA23C1 VA: 0x1EA22C0
	|-GenericComparer<ulong>..ctor
	|
	|-RVA: 0x1EA23A0 Offset: 0x1EA24A1 VA: 0x1EA23A0
	|-GenericComparer<ShadowUtility.Edge>..ctor
	|
	|-RVA: 0x1EA2470 Offset: 0x1EA2571 VA: 0x1EA2470
	|-GenericComparer<AIThink.EnchantThink.ItemInfo>..ctor
	*/
}

