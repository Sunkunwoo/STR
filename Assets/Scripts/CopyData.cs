using UnityEditor;
using UnityEngine;
using System.IO;

public class CopyData : EditorWindow
{
    [MenuItem("Custom/Copy Data")]
    static void CopyDataToResources()
    {
        string sourceFolder = "Assets/BaseDatabase";  // 베이스 데이터베이스 폴더 경로
        string destinationFolder = "Assets/Resources";  // 복사할 폴더 경로

        CopyAll(new DirectoryInfo(sourceFolder), new DirectoryInfo(destinationFolder));
        AssetDatabase.Refresh();
    }

    static void CopyAll(DirectoryInfo source, DirectoryInfo target)
    {
        Directory.CreateDirectory(target.FullName);

        foreach (FileInfo fi in source.GetFiles())
        {
            fi.CopyTo(Path.Combine(target.FullName, fi.Name), true);
        }

        foreach (DirectoryInfo diSourceSubDir in source.GetDirectories())
        {
            DirectoryInfo nextTargetSubDir = target.CreateSubdirectory(diSourceSubDir.Name);
            CopyAll(diSourceSubDir, nextTargetSubDir);
        }
    }
}
