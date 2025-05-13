using UnityEditor;
using UnityEditor.Compilation;
using UnityEngine;


public static class AssemblyTest
{
	[MenuItem("Assembly/Test")]
	public static void Test()
	{
		Debug.Log("Assemblies:");
		var assemblies = CompilationPipeline.GetAssemblies();
		foreach (var assembly in assemblies)
		{
		}

		Debug.Log("-------------------------------------");

		Debug.Log("precompiled:");
		foreach (var refs in CompilationPipeline.GetPrecompiledAssemblyNames())
		{
			Debug.Log($"{refs}");
		}
	}
}
