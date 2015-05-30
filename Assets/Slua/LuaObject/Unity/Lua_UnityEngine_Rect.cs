﻿using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_Rect : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			UnityEngine.Rect o;
			if(argc==5){
				System.Single a1;
				checkType(l,2,out a1);
				System.Single a2;
				checkType(l,3,out a2);
				System.Single a3;
				checkType(l,4,out a3);
				System.Single a4;
				checkType(l,5,out a4);
				o=new UnityEngine.Rect(a1,a2,a3,a4);
				pushValue(l,o);
				return 1;
			}
			else if(argc==2){
				UnityEngine.Rect a1;
				checkType(l,2,out a1);
				o=new UnityEngine.Rect(a1);
				pushValue(l,o);
				return 1;
			}
			LuaDLL.luaL_error(l,"New object failed.");
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Set(IntPtr l) {
		try {
			UnityEngine.Rect self;
			checkType(l,1,out self);
			System.Single a1;
			checkType(l,2,out a1);
			System.Single a2;
			checkType(l,3,out a2);
			System.Single a3;
			checkType(l,4,out a3);
			System.Single a4;
			checkType(l,5,out a4);
			self.Set(a1,a2,a3,a4);
			setBack(l,self);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Contains(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l,argc,2,typeof(UnityEngine.Vector2))){
				UnityEngine.Rect self;
				checkType(l,1,out self);
				UnityEngine.Vector2 a1;
				checkType(l,2,out a1);
				System.Boolean ret=self.Contains(a1);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,argc,2,typeof(UnityEngine.Vector3))){
				UnityEngine.Rect self;
				checkType(l,1,out self);
				UnityEngine.Vector3 a1;
				checkType(l,2,out a1);
				System.Boolean ret=self.Contains(a1);
				pushValue(l,ret);
				return 1;
			}
			else if(argc==3){
				UnityEngine.Rect self;
				checkType(l,1,out self);
				UnityEngine.Vector3 a1;
				checkType(l,2,out a1);
				System.Boolean a2;
				checkType(l,3,out a2);
				System.Boolean ret=self.Contains(a1,a2);
				pushValue(l,ret);
				return 1;
			}
			LuaDLL.luaL_error(l,"No matched override function to call");
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Overlaps(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==2){
				UnityEngine.Rect self;
				checkType(l,1,out self);
				UnityEngine.Rect a1;
				checkType(l,2,out a1);
				System.Boolean ret=self.Overlaps(a1);
				pushValue(l,ret);
				return 1;
			}
			else if(argc==3){
				UnityEngine.Rect self;
				checkType(l,1,out self);
				UnityEngine.Rect a1;
				checkType(l,2,out a1);
				System.Boolean a2;
				checkType(l,3,out a2);
				System.Boolean ret=self.Overlaps(a1,a2);
				pushValue(l,ret);
				return 1;
			}
			LuaDLL.luaL_error(l,"No matched override function to call");
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int MinMaxRect_s(IntPtr l) {
		try {
			System.Single a1;
			checkType(l,1,out a1);
			System.Single a2;
			checkType(l,2,out a2);
			System.Single a3;
			checkType(l,3,out a3);
			System.Single a4;
			checkType(l,4,out a4);
			UnityEngine.Rect ret=UnityEngine.Rect.MinMaxRect(a1,a2,a3,a4);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int NormalizedToPoint_s(IntPtr l) {
		try {
			UnityEngine.Rect a1;
			checkType(l,1,out a1);
			UnityEngine.Vector2 a2;
			checkType(l,2,out a2);
			UnityEngine.Vector2 ret=UnityEngine.Rect.NormalizedToPoint(a1,a2);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int PointToNormalized_s(IntPtr l) {
		try {
			UnityEngine.Rect a1;
			checkType(l,1,out a1);
			UnityEngine.Vector2 a2;
			checkType(l,2,out a2);
			UnityEngine.Vector2 ret=UnityEngine.Rect.PointToNormalized(a1,a2);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int op_Inequality(IntPtr l) {
		try {
			UnityEngine.Rect a1;
			checkType(l,1,out a1);
			UnityEngine.Rect a2;
			checkType(l,2,out a2);
			System.Boolean ret=(a1!=a2);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int op_Equality(IntPtr l) {
		try {
			UnityEngine.Rect a1;
			checkType(l,1,out a1);
			UnityEngine.Rect a2;
			checkType(l,2,out a2);
			System.Boolean ret=(a1==a2);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_x(IntPtr l) {
		try {
			UnityEngine.Rect self;
			checkType(l,1,out self);
			pushValue(l,self.x);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_x(IntPtr l) {
		try {
			UnityEngine.Rect self;
			checkType(l,1,out self);
			float v;
			checkType(l,2,out v);
			self.x=v;
			setBack(l,self);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_y(IntPtr l) {
		try {
			UnityEngine.Rect self;
			checkType(l,1,out self);
			pushValue(l,self.y);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_y(IntPtr l) {
		try {
			UnityEngine.Rect self;
			checkType(l,1,out self);
			float v;
			checkType(l,2,out v);
			self.y=v;
			setBack(l,self);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_position(IntPtr l) {
		try {
			UnityEngine.Rect self;
			checkType(l,1,out self);
			pushValue(l,self.position);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_position(IntPtr l) {
		try {
			UnityEngine.Rect self;
			checkType(l,1,out self);
			UnityEngine.Vector2 v;
			checkType(l,2,out v);
			self.position=v;
			setBack(l,self);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_center(IntPtr l) {
		try {
			UnityEngine.Rect self;
			checkType(l,1,out self);
			pushValue(l,self.center);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_center(IntPtr l) {
		try {
			UnityEngine.Rect self;
			checkType(l,1,out self);
			UnityEngine.Vector2 v;
			checkType(l,2,out v);
			self.center=v;
			setBack(l,self);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_min(IntPtr l) {
		try {
			UnityEngine.Rect self;
			checkType(l,1,out self);
			pushValue(l,self.min);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_min(IntPtr l) {
		try {
			UnityEngine.Rect self;
			checkType(l,1,out self);
			UnityEngine.Vector2 v;
			checkType(l,2,out v);
			self.min=v;
			setBack(l,self);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_max(IntPtr l) {
		try {
			UnityEngine.Rect self;
			checkType(l,1,out self);
			pushValue(l,self.max);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_max(IntPtr l) {
		try {
			UnityEngine.Rect self;
			checkType(l,1,out self);
			UnityEngine.Vector2 v;
			checkType(l,2,out v);
			self.max=v;
			setBack(l,self);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_width(IntPtr l) {
		try {
			UnityEngine.Rect self;
			checkType(l,1,out self);
			pushValue(l,self.width);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_width(IntPtr l) {
		try {
			UnityEngine.Rect self;
			checkType(l,1,out self);
			float v;
			checkType(l,2,out v);
			self.width=v;
			setBack(l,self);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_height(IntPtr l) {
		try {
			UnityEngine.Rect self;
			checkType(l,1,out self);
			pushValue(l,self.height);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_height(IntPtr l) {
		try {
			UnityEngine.Rect self;
			checkType(l,1,out self);
			float v;
			checkType(l,2,out v);
			self.height=v;
			setBack(l,self);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_size(IntPtr l) {
		try {
			UnityEngine.Rect self;
			checkType(l,1,out self);
			pushValue(l,self.size);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_size(IntPtr l) {
		try {
			UnityEngine.Rect self;
			checkType(l,1,out self);
			UnityEngine.Vector2 v;
			checkType(l,2,out v);
			self.size=v;
			setBack(l,self);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_xMin(IntPtr l) {
		try {
			UnityEngine.Rect self;
			checkType(l,1,out self);
			pushValue(l,self.xMin);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_xMin(IntPtr l) {
		try {
			UnityEngine.Rect self;
			checkType(l,1,out self);
			float v;
			checkType(l,2,out v);
			self.xMin=v;
			setBack(l,self);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_yMin(IntPtr l) {
		try {
			UnityEngine.Rect self;
			checkType(l,1,out self);
			pushValue(l,self.yMin);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_yMin(IntPtr l) {
		try {
			UnityEngine.Rect self;
			checkType(l,1,out self);
			float v;
			checkType(l,2,out v);
			self.yMin=v;
			setBack(l,self);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_xMax(IntPtr l) {
		try {
			UnityEngine.Rect self;
			checkType(l,1,out self);
			pushValue(l,self.xMax);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_xMax(IntPtr l) {
		try {
			UnityEngine.Rect self;
			checkType(l,1,out self);
			float v;
			checkType(l,2,out v);
			self.xMax=v;
			setBack(l,self);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_yMax(IntPtr l) {
		try {
			UnityEngine.Rect self;
			checkType(l,1,out self);
			pushValue(l,self.yMax);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_yMax(IntPtr l) {
		try {
			UnityEngine.Rect self;
			checkType(l,1,out self);
			float v;
			checkType(l,2,out v);
			self.yMax=v;
			setBack(l,self);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Rect");
		addMember(l,Set);
		addMember(l,Contains);
		addMember(l,Overlaps);
		addMember(l,MinMaxRect_s);
		addMember(l,NormalizedToPoint_s);
		addMember(l,PointToNormalized_s);
		addMember(l,op_Inequality);
		addMember(l,op_Equality);
		addMember(l,"x",get_x,set_x,true);
		addMember(l,"y",get_y,set_y,true);
		addMember(l,"position",get_position,set_position,true);
		addMember(l,"center",get_center,set_center,true);
		addMember(l,"min",get_min,set_min,true);
		addMember(l,"max",get_max,set_max,true);
		addMember(l,"width",get_width,set_width,true);
		addMember(l,"height",get_height,set_height,true);
		addMember(l,"size",get_size,set_size,true);
		addMember(l,"xMin",get_xMin,set_xMin,true);
		addMember(l,"yMin",get_yMin,set_yMin,true);
		addMember(l,"xMax",get_xMax,set_xMax,true);
		addMember(l,"yMax",get_yMax,set_yMax,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.Rect));
	}
}
