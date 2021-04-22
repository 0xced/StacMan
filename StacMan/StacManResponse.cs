using System;
using System.Diagnostics.CodeAnalysis;

namespace StackExchange.StacMan
{
    /// <summary>
    /// StacMan API response
    /// </summary>
    public class StacManResponse<T> where T : StacManType
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StacManResponse{T}"/> class.
        /// </summary>
        /// <param name="apiUrl">The url of the underlying Stack Exchange API method.</param>
        public StacManResponse(string apiUrl)
        {
            ApiUrl = apiUrl;
        }

        /// <summary>
        /// True if the API call was successful.
        /// </summary>
        [MemberNotNullWhen(false, nameof(Error))]
        public bool Success => Error is null;

        /// <summary>
        /// Data returned by the Stack Exchange API method.
        /// </summary>
        public Wrapper<T>? Data { get; internal set; }

        /// <summary>
        /// Non-null whenever Success is false.
        /// </summary>
        public Exception? Error { get; internal set; }
        
        /// <summary>
        /// True if the underlying Stack Exchange API method responded, regardless of success.
        /// </summary>
        [MemberNotNullWhen(true, nameof(Data))]
        public bool ReceivedApiResponse => Data is not null;

        #region Properties for debugging

        /// <summary>
        /// The url of the underlying Stack Exchange API method.
        /// Useful for debugging.
        /// </summary>
        public string ApiUrl { get; }

        /// <summary>
        /// Response of the request made to the underlying Stack Exchange API method.
        /// Useful for debugging.
        /// </summary>
        public string? RawData { get; internal set; }

        #endregion
    }
}
