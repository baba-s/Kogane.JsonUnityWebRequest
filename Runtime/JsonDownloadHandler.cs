using System;
using UnityEngine;
using UnityEngine.Networking;

// ReSharper disable InconsistentNaming
// ReSharper disable NotAccessedField.Local

namespace Kogane
{
    [Serializable]
    public struct JsonDownloadHandler
    {
        [SerializeField] private string error;
        [SerializeField] private bool   isDone;
        [SerializeField] private string text;

        public JsonDownloadHandler( DownloadHandler handler )
        {
            error  = handler.error;
            isDone = handler.isDone;
            text   = handler.text;
        }

        public override string ToString()
        {
            return JsonUtility.ToJson( this, true );
        }
    }
}