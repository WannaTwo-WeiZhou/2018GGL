// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by the Game Data Editor.
//
//      Changes to this file will be lost if the code is regenerated.
//
//      This file was generated from this data file:
//      Assets/GameDataEditor/Resources/gde_data.txt
//  </autogenerated>
// ------------------------------------------------------------------------------
using UnityEngine;
using System;
using System.Collections.Generic;

using GameDataEditor;

namespace GameDataEditor
{
    public class GDEWeaponData : IGDEData
    {
        static string IDKey = "ID";
		int _ID;
        public int ID
        {
            get { return _ID; }
            set {
                if (_ID != value)
                {
                    _ID = value;
					GDEDataManager.SetInt(_key, IDKey, _ID);
                }
            }
        }

        static string MagazineSizeKey = "MagazineSize";
		int _MagazineSize;
        public int MagazineSize
        {
            get { return _MagazineSize; }
            set {
                if (_MagazineSize != value)
                {
                    _MagazineSize = value;
					GDEDataManager.SetInt(_key, MagazineSizeKey, _MagazineSize);
                }
            }
        }

        static string ConsumePerHitKey = "ConsumePerHit";
		int _ConsumePerHit;
        public int ConsumePerHit
        {
            get { return _ConsumePerHit; }
            set {
                if (_ConsumePerHit != value)
                {
                    _ConsumePerHit = value;
					GDEDataManager.SetInt(_key, ConsumePerHitKey, _ConsumePerHit);
                }
            }
        }

        static string DamageValKey = "DamageVal";
		int _DamageVal;
        public int DamageVal
        {
            get { return _DamageVal; }
            set {
                if (_DamageVal != value)
                {
                    _DamageVal = value;
					GDEDataManager.SetInt(_key, DamageValKey, _DamageVal);
                }
            }
        }

        static string AtkIntervalKey = "AtkInterval";
		float _AtkInterval;
        public float AtkInterval
        {
            get { return _AtkInterval; }
            set {
                if (_AtkInterval != value)
                {
                    _AtkInterval = value;
					GDEDataManager.SetFloat(_key, AtkIntervalKey, _AtkInterval);
                }
            }
        }

        static string ChargeTimeKey = "ChargeTime";
		float _ChargeTime;
        public float ChargeTime
        {
            get { return _ChargeTime; }
            set {
                if (_ChargeTime != value)
                {
                    _ChargeTime = value;
					GDEDataManager.SetFloat(_key, ChargeTimeKey, _ChargeTime);
                }
            }
        }

        static string ReloadTimeKey = "ReloadTime";
		float _ReloadTime;
        public float ReloadTime
        {
            get { return _ReloadTime; }
            set {
                if (_ReloadTime != value)
                {
                    _ReloadTime = value;
					GDEDataManager.SetFloat(_key, ReloadTimeKey, _ReloadTime);
                }
            }
        }

        static string ThrustKey = "Thrust";
		float _Thrust;
        public float Thrust
        {
            get { return _Thrust; }
            set {
                if (_Thrust != value)
                {
                    _Thrust = value;
					GDEDataManager.SetFloat(_key, ThrustKey, _Thrust);
                }
            }
        }

        static string AlertRangeKey = "AlertRange";
		float _AlertRange;
        public float AlertRange
        {
            get { return _AlertRange; }
            set {
                if (_AlertRange != value)
                {
                    _AlertRange = value;
					GDEDataManager.SetFloat(_key, AlertRangeKey, _AlertRange);
                }
            }
        }

        static string PrefabPathKey = "PrefabPath";
		string _PrefabPath;
        public string PrefabPath
        {
            get { return _PrefabPath; }
            set {
                if (_PrefabPath != value)
                {
                    _PrefabPath = value;
					GDEDataManager.SetString(_key, PrefabPathKey, _PrefabPath);
                }
            }
        }

        static string SkinNameKey = "SkinName";
		string _SkinName;
        public string SkinName
        {
            get { return _SkinName; }
            set {
                if (_SkinName != value)
                {
                    _SkinName = value;
					GDEDataManager.SetString(_key, SkinNameKey, _SkinName);
                }
            }
        }

        static string OpaTypeKey = "OpaType";
		GDEEnum_OpaTypeData _OpaType;
        public GDEEnum_OpaTypeData OpaType
        {
            get { return _OpaType; }
            set {
                if (_OpaType != value)
                {
                    _OpaType = value;
					GDEDataManager.SetCustom(_key, OpaTypeKey, _OpaType);
                }
            }
        }
        static string AniTypeKey = "AniType";
		GDEEnum_WeaponAniTypeData _AniType;
        public GDEEnum_WeaponAniTypeData AniType
        {
            get { return _AniType; }
            set {
                if (_AniType != value)
                {
                    _AniType = value;
					GDEDataManager.SetCustom(_key, AniTypeKey, _AniType);
                }
            }
        }

        public GDEWeaponData(string key) : base(key)
        {
            GDEDataManager.RegisterItem(this.SchemaName(), key);
        }
        public override Dictionary<string, object> SaveToDict()
		{
			var dict = new Dictionary<string, object>();
			dict.Add(GDMConstants.SchemaKey, "Weapon");
			
            dict.Merge(true, ID.ToGDEDict(IDKey));
            dict.Merge(true, MagazineSize.ToGDEDict(MagazineSizeKey));
            dict.Merge(true, ConsumePerHit.ToGDEDict(ConsumePerHitKey));
            dict.Merge(true, DamageVal.ToGDEDict(DamageValKey));
            dict.Merge(true, AtkInterval.ToGDEDict(AtkIntervalKey));
            dict.Merge(true, ChargeTime.ToGDEDict(ChargeTimeKey));
            dict.Merge(true, ReloadTime.ToGDEDict(ReloadTimeKey));
            dict.Merge(true, Thrust.ToGDEDict(ThrustKey));
            dict.Merge(true, AlertRange.ToGDEDict(AlertRangeKey));
            dict.Merge(true, PrefabPath.ToGDEDict(PrefabPathKey));
            dict.Merge(true, SkinName.ToGDEDict(SkinNameKey));

            dict.Merge(true, OpaType.ToGDEDict(OpaTypeKey));
            dict.Merge(true, AniType.ToGDEDict(AniTypeKey));
            return dict;
		}

        public override void UpdateCustomItems(bool rebuildKeyList)
        {
            GDEDataManager.UpdateItem(OpaType, rebuildKeyList);
            OpaType.UpdateCustomItems(rebuildKeyList);
            GDEDataManager.UpdateItem(AniType, rebuildKeyList);
            AniType.UpdateCustomItems(rebuildKeyList);
        }

        public override void LoadFromDict(string dataKey, Dictionary<string, object> dict)
        {
            _key = dataKey;

			if (dict == null)
				LoadFromSavedData(dataKey);
			else
			{
                dict.TryGetInt(IDKey, out _ID);
                dict.TryGetInt(MagazineSizeKey, out _MagazineSize);
                dict.TryGetInt(ConsumePerHitKey, out _ConsumePerHit);
                dict.TryGetInt(DamageValKey, out _DamageVal);
                dict.TryGetFloat(AtkIntervalKey, out _AtkInterval);
                dict.TryGetFloat(ChargeTimeKey, out _ChargeTime);
                dict.TryGetFloat(ReloadTimeKey, out _ReloadTime);
                dict.TryGetFloat(ThrustKey, out _Thrust);
                dict.TryGetFloat(AlertRangeKey, out _AlertRange);
                dict.TryGetString(PrefabPathKey, out _PrefabPath);
                dict.TryGetString(SkinNameKey, out _SkinName);

                string customDataKey;
                dict.TryGetString(OpaTypeKey, out customDataKey);
				_OpaType = new GDEEnum_OpaTypeData(customDataKey);
                dict.TryGetString(AniTypeKey, out customDataKey);
				_AniType = new GDEEnum_WeaponAniTypeData(customDataKey);
                LoadFromSavedData(dataKey);
			}
		}

        public override void LoadFromSavedData(string dataKey)
		{
			_key = dataKey;
			
            _ID = GDEDataManager.GetInt(_key, IDKey, _ID);
            _MagazineSize = GDEDataManager.GetInt(_key, MagazineSizeKey, _MagazineSize);
            _ConsumePerHit = GDEDataManager.GetInt(_key, ConsumePerHitKey, _ConsumePerHit);
            _DamageVal = GDEDataManager.GetInt(_key, DamageValKey, _DamageVal);
            _AtkInterval = GDEDataManager.GetFloat(_key, AtkIntervalKey, _AtkInterval);
            _ChargeTime = GDEDataManager.GetFloat(_key, ChargeTimeKey, _ChargeTime);
            _ReloadTime = GDEDataManager.GetFloat(_key, ReloadTimeKey, _ReloadTime);
            _Thrust = GDEDataManager.GetFloat(_key, ThrustKey, _Thrust);
            _AlertRange = GDEDataManager.GetFloat(_key, AlertRangeKey, _AlertRange);
            _PrefabPath = GDEDataManager.GetString(_key, PrefabPathKey, _PrefabPath);
            _SkinName = GDEDataManager.GetString(_key, SkinNameKey, _SkinName);

            _OpaType = GDEDataManager.GetCustom(_key, OpaTypeKey, _OpaType);
            _AniType = GDEDataManager.GetCustom(_key, AniTypeKey, _AniType);
        }

        public GDEWeaponData ShallowClone()
		{
			string newKey = Guid.NewGuid().ToString();
			GDEWeaponData newClone = new GDEWeaponData(newKey);

            newClone.ID = ID;
            newClone.MagazineSize = MagazineSize;
            newClone.ConsumePerHit = ConsumePerHit;
            newClone.DamageVal = DamageVal;
            newClone.AtkInterval = AtkInterval;
            newClone.ChargeTime = ChargeTime;
            newClone.ReloadTime = ReloadTime;
            newClone.Thrust = Thrust;
            newClone.AlertRange = AlertRange;
            newClone.PrefabPath = PrefabPath;
            newClone.SkinName = SkinName;

            newClone.OpaType = OpaType;
            newClone.AniType = AniType;

            return newClone;
		}

        public GDEWeaponData DeepClone()
		{
			GDEWeaponData newClone = ShallowClone();
            newClone.OpaType = OpaType.DeepClone();
            newClone.AniType = AniType.DeepClone();
            return newClone;
		}

        public void Reset_ID()
        {
            GDEDataManager.ResetToDefault(_key, IDKey);

            Dictionary<string, object> dict;
            GDEDataManager.Get(_key, out dict);
            dict.TryGetInt(IDKey, out _ID);
        }

        public void Reset_MagazineSize()
        {
            GDEDataManager.ResetToDefault(_key, MagazineSizeKey);

            Dictionary<string, object> dict;
            GDEDataManager.Get(_key, out dict);
            dict.TryGetInt(MagazineSizeKey, out _MagazineSize);
        }

        public void Reset_ConsumePerHit()
        {
            GDEDataManager.ResetToDefault(_key, ConsumePerHitKey);

            Dictionary<string, object> dict;
            GDEDataManager.Get(_key, out dict);
            dict.TryGetInt(ConsumePerHitKey, out _ConsumePerHit);
        }

        public void Reset_DamageVal()
        {
            GDEDataManager.ResetToDefault(_key, DamageValKey);

            Dictionary<string, object> dict;
            GDEDataManager.Get(_key, out dict);
            dict.TryGetInt(DamageValKey, out _DamageVal);
        }

        public void Reset_AtkInterval()
        {
            GDEDataManager.ResetToDefault(_key, AtkIntervalKey);

            Dictionary<string, object> dict;
            GDEDataManager.Get(_key, out dict);
            dict.TryGetFloat(AtkIntervalKey, out _AtkInterval);
        }

        public void Reset_ChargeTime()
        {
            GDEDataManager.ResetToDefault(_key, ChargeTimeKey);

            Dictionary<string, object> dict;
            GDEDataManager.Get(_key, out dict);
            dict.TryGetFloat(ChargeTimeKey, out _ChargeTime);
        }

        public void Reset_ReloadTime()
        {
            GDEDataManager.ResetToDefault(_key, ReloadTimeKey);

            Dictionary<string, object> dict;
            GDEDataManager.Get(_key, out dict);
            dict.TryGetFloat(ReloadTimeKey, out _ReloadTime);
        }

        public void Reset_Thrust()
        {
            GDEDataManager.ResetToDefault(_key, ThrustKey);

            Dictionary<string, object> dict;
            GDEDataManager.Get(_key, out dict);
            dict.TryGetFloat(ThrustKey, out _Thrust);
        }

        public void Reset_AlertRange()
        {
            GDEDataManager.ResetToDefault(_key, AlertRangeKey);

            Dictionary<string, object> dict;
            GDEDataManager.Get(_key, out dict);
            dict.TryGetFloat(AlertRangeKey, out _AlertRange);
        }

        public void Reset_PrefabPath()
        {
            GDEDataManager.ResetToDefault(_key, PrefabPathKey);

            Dictionary<string, object> dict;
            GDEDataManager.Get(_key, out dict);
            dict.TryGetString(PrefabPathKey, out _PrefabPath);
        }

        public void Reset_SkinName()
        {
            GDEDataManager.ResetToDefault(_key, SkinNameKey);

            Dictionary<string, object> dict;
            GDEDataManager.Get(_key, out dict);
            dict.TryGetString(SkinNameKey, out _SkinName);
        }

        public void Reset_OpaType()
		{
			GDEDataManager.ResetToDefault(_key, OpaTypeKey);

			Dictionary<string, object> dict;
	        GDEDataManager.Get(_key, out dict);

			string customDataKey;
            dict.TryGetString(OpaTypeKey, out customDataKey);
			_OpaType = new GDEEnum_OpaTypeData(customDataKey);

			OpaType.ResetAll();
		}
        public void Reset_AniType()
		{
			GDEDataManager.ResetToDefault(_key, AniTypeKey);

			Dictionary<string, object> dict;
	        GDEDataManager.Get(_key, out dict);

			string customDataKey;
            dict.TryGetString(AniTypeKey, out customDataKey);
			_AniType = new GDEEnum_WeaponAniTypeData(customDataKey);

			AniType.ResetAll();
		}

        public void ResetAll()
        {
            GDEDataManager.ResetToDefault(_key, IDKey);
            GDEDataManager.ResetToDefault(_key, OpaTypeKey);
            GDEDataManager.ResetToDefault(_key, AtkIntervalKey);
            GDEDataManager.ResetToDefault(_key, ChargeTimeKey);
            GDEDataManager.ResetToDefault(_key, ConsumePerHitKey);
            GDEDataManager.ResetToDefault(_key, ReloadTimeKey);
            GDEDataManager.ResetToDefault(_key, DamageValKey);
            GDEDataManager.ResetToDefault(_key, ThrustKey);
            GDEDataManager.ResetToDefault(_key, PrefabPathKey);
            GDEDataManager.ResetToDefault(_key, SkinNameKey);
            GDEDataManager.ResetToDefault(_key, AniTypeKey);
            GDEDataManager.ResetToDefault(_key, MagazineSizeKey);
            GDEDataManager.ResetToDefault(_key, AlertRangeKey);

            Reset_OpaType();
            Reset_AniType();

            Dictionary<string, object> dict;
            GDEDataManager.Get(_key, out dict);
            LoadFromDict(_key, dict);
        }
    }
}
