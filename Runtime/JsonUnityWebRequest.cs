using System;
using UnityEngine;
using UnityEngine.Networking;

// ReSharper disable InconsistentNaming
// ReSharper disable NotAccessedField.Local

namespace Kogane
{
    [Serializable]
    public struct JsonUnityWebRequest
    {
        [SerializeField] private bool                disposeCertificateHandlerOnDispose;
        [SerializeField] private bool                disposeDownloadHandlerOnDispose;
        [SerializeField] private bool                disposeUploadHandlerOnDispose;
        [SerializeField] private ulong               downloadedBytes;
        [SerializeField] private JsonDownloadHandler downloadHandler;
        [SerializeField] private float               downloadProgress;
        [SerializeField] private string              error;
        [SerializeField] private bool                isDone;
        [SerializeField] private bool                isModifiable;
        [SerializeField] private string              method;
        [SerializeField] private int                 redirectLimit;
        [SerializeField] private long                responseCode;
        [SerializeField] private string              result;
        [SerializeField] private int                 timeout;
        [SerializeField] private ulong               uploadedBytes;
        [SerializeField] private JsonUploadHandler   uploadHandler;
        [SerializeField] private float               uploadProgress;
        [SerializeField] private string              url;
        [SerializeField] private bool                useHttpContinue;

        public JsonUnityWebRequest( UnityWebRequest request )
        {
            disposeCertificateHandlerOnDispose = request.disposeCertificateHandlerOnDispose;
            disposeDownloadHandlerOnDispose    = request.disposeDownloadHandlerOnDispose;
            disposeUploadHandlerOnDispose      = request.disposeUploadHandlerOnDispose;
            downloadedBytes                    = request.downloadedBytes;
            downloadHandler                    = request.downloadHandler != null ? new JsonDownloadHandler( request.downloadHandler ) : default;
            downloadProgress                   = request.downloadProgress;
            error                              = request.error;
            isDone                             = request.isDone;
            isModifiable                       = request.isModifiable;
            method                             = request.method;
            redirectLimit                      = request.redirectLimit;
            responseCode                       = request.responseCode;
            result                             = request.result.ToString();
            timeout                            = request.timeout;
            uploadedBytes                      = request.uploadedBytes;
            uploadHandler                      = request.uploadHandler != null ? new JsonUploadHandler( request.uploadHandler ) : default;
            uploadProgress                     = request.uploadProgress;
            url                                = request.url;
            useHttpContinue                    = request.useHttpContinue;
        }

        public override string ToString()
        {
            return JsonUtility.ToJson( this, true );
        }
    }
}