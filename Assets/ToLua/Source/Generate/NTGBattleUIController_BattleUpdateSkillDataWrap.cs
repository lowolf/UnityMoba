﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class NTGBattleUIController_BattleUpdateSkillDataWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(NTGBattleUIController.BattleUpdateSkillData), typeof(System.Object));
		L.RegFunction("New", _CreateNTGBattleUIController_BattleUpdateSkillData);
		L.RegFunction("__tostring", Lua_ToString);
		L.RegVar("Valid", get_Valid, set_Valid);
		L.RegVar("Id", get_Id, set_Id);
		L.RegVar("Level", get_Level, set_Level);
		L.RegVar("MPCost", get_MPCost, set_MPCost);
		L.RegVar("CD", get_CD, set_CD);
		L.RegVar("MaxCD", get_MaxCD, set_MaxCD);
		L.RegVar("MpEnough", get_MpEnough, set_MpEnough);
		L.RegVar("CanUpgrade", get_CanUpgrade, set_CanUpgrade);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateNTGBattleUIController_BattleUpdateSkillData(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 0)
			{
				NTGBattleUIController.BattleUpdateSkillData obj = new NTGBattleUIController.BattleUpdateSkillData();
				ToLua.PushObject(L, obj);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to ctor method: NTGBattleUIController.BattleUpdateSkillData.New");
			}
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Lua_ToString(IntPtr L)
	{
		object obj = ToLua.ToObject(L, 1);

		if (obj != null)
		{
			LuaDLL.lua_pushstring(L, obj.ToString());
		}
		else
		{
			LuaDLL.lua_pushnil(L);
		}

		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Valid(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			NTGBattleUIController.BattleUpdateSkillData obj = (NTGBattleUIController.BattleUpdateSkillData)o;
			bool ret = obj.Valid;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index Valid on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Id(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			NTGBattleUIController.BattleUpdateSkillData obj = (NTGBattleUIController.BattleUpdateSkillData)o;
			int ret = obj.Id;
			LuaDLL.lua_pushinteger(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index Id on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Level(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			NTGBattleUIController.BattleUpdateSkillData obj = (NTGBattleUIController.BattleUpdateSkillData)o;
			int ret = obj.Level;
			LuaDLL.lua_pushinteger(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index Level on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_MPCost(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			NTGBattleUIController.BattleUpdateSkillData obj = (NTGBattleUIController.BattleUpdateSkillData)o;
			int ret = obj.MPCost;
			LuaDLL.lua_pushinteger(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index MPCost on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_CD(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			NTGBattleUIController.BattleUpdateSkillData obj = (NTGBattleUIController.BattleUpdateSkillData)o;
			float ret = obj.CD;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index CD on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_MaxCD(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			NTGBattleUIController.BattleUpdateSkillData obj = (NTGBattleUIController.BattleUpdateSkillData)o;
			int ret = obj.MaxCD;
			LuaDLL.lua_pushinteger(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index MaxCD on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_MpEnough(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			NTGBattleUIController.BattleUpdateSkillData obj = (NTGBattleUIController.BattleUpdateSkillData)o;
			bool ret = obj.MpEnough;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index MpEnough on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_CanUpgrade(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			NTGBattleUIController.BattleUpdateSkillData obj = (NTGBattleUIController.BattleUpdateSkillData)o;
			bool ret = obj.CanUpgrade;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index CanUpgrade on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_Valid(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			NTGBattleUIController.BattleUpdateSkillData obj = (NTGBattleUIController.BattleUpdateSkillData)o;
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			obj.Valid = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index Valid on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_Id(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			NTGBattleUIController.BattleUpdateSkillData obj = (NTGBattleUIController.BattleUpdateSkillData)o;
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			obj.Id = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index Id on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_Level(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			NTGBattleUIController.BattleUpdateSkillData obj = (NTGBattleUIController.BattleUpdateSkillData)o;
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			obj.Level = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index Level on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_MPCost(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			NTGBattleUIController.BattleUpdateSkillData obj = (NTGBattleUIController.BattleUpdateSkillData)o;
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			obj.MPCost = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index MPCost on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_CD(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			NTGBattleUIController.BattleUpdateSkillData obj = (NTGBattleUIController.BattleUpdateSkillData)o;
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.CD = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index CD on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_MaxCD(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			NTGBattleUIController.BattleUpdateSkillData obj = (NTGBattleUIController.BattleUpdateSkillData)o;
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			obj.MaxCD = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index MaxCD on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_MpEnough(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			NTGBattleUIController.BattleUpdateSkillData obj = (NTGBattleUIController.BattleUpdateSkillData)o;
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			obj.MpEnough = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index MpEnough on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_CanUpgrade(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			NTGBattleUIController.BattleUpdateSkillData obj = (NTGBattleUIController.BattleUpdateSkillData)o;
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			obj.CanUpgrade = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index CanUpgrade on a nil value" : e.Message);
		}
	}
}

