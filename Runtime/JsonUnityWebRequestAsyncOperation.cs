using System;
using UnityEngine;
using UnityEngine.Networking;

// ReSharper disable InconsistentNaming
// ReSharper disable NotAccessedField.Local

namespace Kogane
{
    [Serializable]
    public struct JsonUnityWebRequestAsyncOperation
    {
        [SerializeField] private JsonUnityWebRequest webRequest;
        [SerializeField] private bool                allowSceneActivation;
        [SerializeField] private bool                isDone;
        [SerializeField] private int                 priority;
        [SerializeField] private float               progress;

        public JsonUnityWebRequestAsyncOperation( UnityWebRequestAsyncOperation operation )
        {
            webRequest           = operation.webRequest != null ? new JsonUnityWebRequest( operation.webRequest ) : default;
            allowSceneActivation = operation.allowSceneActivation;
            isDone               = operation.isDone;
            priority             = operation.priority;
            progress             = operation.progress;
        }

        public override string ToString()
        {
            return JsonUtility.ToJson( this, true );
        }
    }
}