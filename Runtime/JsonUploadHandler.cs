using System;
using UnityEngine;
using UnityEngine.Networking;

// ReSharper disable InconsistentNaming
// ReSharper disable NotAccessedField.Local

namespace Kogane
{
    [Serializable]
    public struct JsonUploadHandler
    {
        [SerializeField] private string contentType;
        [SerializeField] private float  progress;

        public JsonUploadHandler( UploadHandler handler )
        {
            contentType = handler.contentType;
            progress    = handler.progress;
        }

        public override string ToString()
        {
            return JsonUtility.ToJson( this, true );
        }
    }
}