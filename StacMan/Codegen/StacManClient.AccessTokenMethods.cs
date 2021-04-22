// <auto-generated>
//     This file was generated by a T4 template.
//     Don't change it directly as your change would get overwritten. Instead, make changes
//     to the .tt file (i.e. the T4 template) and save it to regenerate this file.
// </auto-generated>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

#nullable enable

namespace StackExchange.StacMan
{
    public partial class StacManClient : IAccessTokenMethods
    {
        /// <summary>
        /// Stack Exchange API AccessTokens methods
        /// </summary>
        public IAccessTokenMethods AccessTokens
        {
            get { return this; }
        }

        Task<StacManResponse<AccessToken>> IAccessTokenMethods.Invalidate(IEnumerable<string> accessTokens, string? filter, int? page, int? pagesize)
        {
            ValidateEnumerable(accessTokens, "accessTokens");
            ValidatePaging(page, pagesize);

            var ub = new ApiUrlBuilder(Version, String.Format("/access-tokens/{0}/invalidate", String.Join(";", accessTokens.Select(HttpUtility.UrlEncode))), useHttps: false);

            ub.AddParameter("filter", filter);
            ub.AddParameter("page", page);
            ub.AddParameter("pagesize", pagesize);

            return CreateApiTask<AccessToken>(ub, HttpMethod.GET, "/access-tokens/{accessTokens}/invalidate");
        }

        Task<StacManResponse<AccessToken>> IAccessTokenMethods.Get(IEnumerable<string> accessTokens, string? filter, int? page, int? pagesize)
        {
            ValidateEnumerable(accessTokens, "accessTokens");
            ValidatePaging(page, pagesize);

            var ub = new ApiUrlBuilder(Version, String.Format("/access-tokens/{0}", String.Join(";", accessTokens.Select(HttpUtility.UrlEncode))), useHttps: false);

            ub.AddParameter("filter", filter);
            ub.AddParameter("page", page);
            ub.AddParameter("pagesize", pagesize);

            return CreateApiTask<AccessToken>(ub, HttpMethod.GET, "/access-tokens/{accessTokens}");
        }
    }

    /// <summary>
    /// Stack Exchange API AccessTokens methods
    /// </summary>
    public interface IAccessTokenMethods
    {
        /// <summary>
        /// Allows an application to dispose of access_tokens when it is done with them. (API Method: "/access-tokens/{accessTokens}/invalidate")
        /// </summary>
        Task<StacManResponse<AccessToken>> Invalidate(IEnumerable<string> accessTokens, string? filter = default, int? page = default, int? pagesize = default);

        /// <summary>
        /// Allows an application to inspect access_tokens it has, useful for debugging. (API Method: "/access-tokens/{accessTokens}")
        /// </summary>
        Task<StacManResponse<AccessToken>> Get(IEnumerable<string> accessTokens, string? filter = default, int? page = default, int? pagesize = default);

    }
}
