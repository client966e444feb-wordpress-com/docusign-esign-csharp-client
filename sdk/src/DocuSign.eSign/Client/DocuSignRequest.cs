/* 
 * DocuSign REST API
 *
 * The DocuSign REST API provides you with a powerful, convenient, and simple Web services API for interacting with DocuSign.
 *
 * OpenAPI spec version: v2.1
 * Contact: devcenter@docusign.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace DocuSign.eSign.Client
{
    public class FileParameter
    {
        public FileParameter(string name, string fileName, string contentDisposition, byte[] content)
        {
            Name = name;
            FileName = fileName;
            ContentDisposition = contentDisposition;
            Content = content;
        }

        public string Name { get; set; }

        public string FileName { get; set; }

        public string ContentDisposition { get; set; }

        public byte[] Content { get; set; }

    }

    public class DocuSignRequest
    {
        public HttpMethod Method { get; }

        public string Url { get; }

        public Object BodyContent { get; set; }

        public String ContentType { get; set; }

        public String ContentDisposition { get; set; }

        /// <summary>
        /// Query parameters
        /// </summary>
        public List<KeyValuePair<string, string>> QueryParams { get; private set; }

        /// <summary>
        /// Post parameters
        /// </summary>
        public List<KeyValuePair<string, string>> PostParams { get; private set; }

        /// <summary>
        /// Header parameters
        /// </summary>
        public List<KeyValuePair<string, string>> HeaderParams { get; private set; }

        /// <summary>
        /// Path parameters
        /// </summary>
        public List<KeyValuePair<string, string>> PathParams { get; private set; }

        public List<FileParameter> FileParams { get; private set; }

        public DocuSignRequest(HttpMethod method, string path) : this(method, path, null, null, null, null, null, null, null, null) { }

        public DocuSignRequest(HttpMethod method, string path, string contentType) : this(method, path, null, null, null, null, null, null, contentType, null) { }

        public DocuSignRequest(HttpMethod method, string path, List<KeyValuePair<string, string>> queryParams = null, Object bodyContent = null,
            List<KeyValuePair<string, string>> headerParams = null, List<KeyValuePair<string, string>> postParams = null, List<KeyValuePair<string,string>> pathParams = null,
            List<FileParameter> fileParams = null, string contentType = null, string contentDisposition = null)
        {
            Method = method;

            Url = path;
            ContentType = contentType;
            ContentDisposition = contentDisposition;
            BodyContent = bodyContent;
            QueryParams = queryParams ?? new List<KeyValuePair<string, string>>();
            PostParams = postParams ?? new List<KeyValuePair<string, string>>();
            HeaderParams = headerParams ?? new List<KeyValuePair<string, string>>();
            PathParams = pathParams ?? new List<KeyValuePair<string, string>>();
            FileParams = fileParams ?? new List<FileParameter>();
        }

        public void AddHeaderParameter(string name, string value) => HeaderParams.Add(new KeyValuePair<string, string>(name, value));

        public void AddPostParameter(string name, string value) => PostParams.Add(new KeyValuePair<string, string>(name, value));

        public void AddQueryParameter(string name, string value) => QueryParams.Add(new KeyValuePair<string, string>(name, value));

        public void AddPathParameter(string name, string value) => PathParams.Add(new KeyValuePair<string, string>(name, value));

        public void AddFileParameter(string name, string fileName, string contentDisposition, byte[] content) => FileParams.Add(new FileParameter(name, fileName, contentDisposition, content));
    }
}