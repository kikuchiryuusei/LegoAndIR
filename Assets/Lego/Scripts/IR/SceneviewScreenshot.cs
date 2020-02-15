using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Windows;

public class SceneviewScreenshot : MonoBehaviour
{
    [ContextMenu("capture")]
    void CaptureSceneCameraView()
    {
        // 保存するパス
        var filePath = string.Format("{0}/image.png", Application.dataPath);
        // シーンカメラのテクスチャを取得する
        var renderTextureRef = UnityEditor.SceneView.lastActiveSceneView.camera.activeTexture;
        // Texture2Dに書き込む
        Texture2D tex = new Texture2D(renderTextureRef.width, renderTextureRef.height, TextureFormat.RGB24, false);
        RenderTexture.active = renderTextureRef;
        tex.ReadPixels(new Rect(0, 0, renderTextureRef.width, renderTextureRef.height), 0, 0);
        tex.Apply();

        // PNGに変換
        byte[] bytes = tex.EncodeToPNG();
        // 保存する
        File.WriteAllBytes(filePath, bytes);
    }

    /*
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    */
}
