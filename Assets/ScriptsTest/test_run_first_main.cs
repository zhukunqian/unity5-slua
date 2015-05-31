using UnityEngine;
using System.Collections;
using SLua;
using System.IO;

public class test_run_first_main : MonoBehaviour {

	// 需要实现一个framework,有自动下载的功能。

	// lua打为一个整包？
	// 暂时先不要自动下载及其它等功能。

	// Use this for initialization
	// lua service只有一个，那加载的lua呢，按一个写呢，还是按多个写呢，应该尽量只按一个写。
	LuaSvr luaService=null;
	LuaTable mainLua=null;
	LuaFunction mainUpdateFunction=null;
	void Start () {
		LuaState.loaderDelegate=new LuaState.LoaderDelegate(LoaderDelegate);
		luaService=new LuaSvr();
		mainLua=(LuaTable)luaService.start("Lua_src/test_run_first.lua");

		mainUpdateFunction=(LuaFunction)mainLua["update"];
	}
	
	// Update is called once per frame
	void Update () {
		if(mainUpdateFunction!=null){
			mainUpdateFunction.call ();
		}
	}

	void Destroy(){

	}

	public byte[] LoaderDelegate(string fn){
		// 暂时先只用File读取
		string filePath = System.IO.Path.Combine(Application.dataPath, fn);
		return File.ReadAllBytes(filePath);
	}
}
