# Kogane Json Unity Web Request

UnityWebRequest クラスを JSON 形式の文字列に変換できるパッケージ

## 使用例

```cs
using Cysharp.Threading.Tasks;
using Kogane;
using UnityEngine;
using UnityEngine.Networking;

public class Example : MonoBehaviour
{
    private async UniTaskVoid Start()
    {
        var unityWebRequest = UnityWebRequest.Get( "" );
        await unityWebRequest.SendWebRequest();
        Debug.Log( new JsonUnityWebRequest( unityWebRequest ) );
    }
}
```