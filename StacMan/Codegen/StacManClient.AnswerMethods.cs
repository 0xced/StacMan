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
    public partial class StacManClient : IAnswerMethods
    {
        /// <summary>
        /// Stack Exchange API Answers methods
        /// </summary>
        public IAnswerMethods Answers
        {
            get { return this; }
        }

        Task<StacManResponse<Answer>> IAnswerMethods.GetAll(string site, string? filter, int? page, int? pagesize, DateTime? fromdate, DateTime? todate, Answers.Sort sort, DateTime? mindate, DateTime? maxdate, int? min, int? max, Order? order)
        {
            ValidateString(site, "site");
            ValidatePaging(page, pagesize);
            ValidateSortMinMax(sort, mindate: mindate, maxdate: maxdate, min: min, max: max);

            var ub = new ApiUrlBuilder(Version, "/answers", useHttps: false);

            ub.AddParameter("site", site);
            ub.AddParameter("filter", filter);
            ub.AddParameter("page", page);
            ub.AddParameter("pagesize", pagesize);
            ub.AddParameter("fromdate", fromdate);
            ub.AddParameter("todate", todate);
            ub.AddParameter("sort", sort);
            ub.AddParameter("min", mindate);
            ub.AddParameter("max", maxdate);
            ub.AddParameter("min", min);
            ub.AddParameter("max", max);
            ub.AddParameter("order", order);

            return CreateApiTask<Answer>(ub, HttpMethod.GET, "/answers");
        }

        Task<StacManResponse<Answer>> IAnswerMethods.GetByIds(string site, IEnumerable<int> ids, string? filter, int? page, int? pagesize, DateTime? fromdate, DateTime? todate, Answers.Sort sort, DateTime? mindate, DateTime? maxdate, int? min, int? max, Order? order)
        {
            ValidateString(site, "site");
            ValidateEnumerable(ids, "ids");
            ValidatePaging(page, pagesize);
            ValidateSortMinMax(sort, mindate: mindate, maxdate: maxdate, min: min, max: max);

            var ub = new ApiUrlBuilder(Version, String.Format("/answers/{0}", String.Join(";", ids)), useHttps: false);

            ub.AddParameter("site", site);
            ub.AddParameter("filter", filter);
            ub.AddParameter("page", page);
            ub.AddParameter("pagesize", pagesize);
            ub.AddParameter("fromdate", fromdate);
            ub.AddParameter("todate", todate);
            ub.AddParameter("sort", sort);
            ub.AddParameter("min", mindate);
            ub.AddParameter("max", maxdate);
            ub.AddParameter("min", min);
            ub.AddParameter("max", max);
            ub.AddParameter("order", order);

            return CreateApiTask<Answer>(ub, HttpMethod.GET, "/answers/{ids}");
        }

        Task<StacManResponse<Comment>> IAnswerMethods.GetComments(string site, IEnumerable<int> ids, string? filter, int? page, int? pagesize, DateTime? fromdate, DateTime? todate, Comments.Sort sort, DateTime? mindate, DateTime? maxdate, int? min, int? max, Order? order)
        {
            ValidateString(site, "site");
            ValidateEnumerable(ids, "ids");
            ValidatePaging(page, pagesize);
            ValidateSortMinMax(sort, mindate: mindate, maxdate: maxdate, min: min, max: max);

            var ub = new ApiUrlBuilder(Version, String.Format("/answers/{0}/comments", String.Join(";", ids)), useHttps: false);

            ub.AddParameter("site", site);
            ub.AddParameter("filter", filter);
            ub.AddParameter("page", page);
            ub.AddParameter("pagesize", pagesize);
            ub.AddParameter("fromdate", fromdate);
            ub.AddParameter("todate", todate);
            ub.AddParameter("sort", sort);
            ub.AddParameter("min", mindate);
            ub.AddParameter("max", maxdate);
            ub.AddParameter("min", min);
            ub.AddParameter("max", max);
            ub.AddParameter("order", order);

            return CreateApiTask<Comment>(ub, HttpMethod.GET, "/answers/{ids}/comments");
        }
    }

    /// <summary>
    /// Stack Exchange API Answers methods
    /// </summary>
    public interface IAnswerMethods
    {
        /// <summary>
        /// Get all answers on the site. (API Method: "/answers")
        /// </summary>
        Task<StacManResponse<Answer>> GetAll(string site, string? filter = default, int? page = default, int? pagesize = default, DateTime? fromdate = default, DateTime? todate = default, Answers.Sort sort = default, DateTime? mindate = default, DateTime? maxdate = default, int? min = default, int? max = default, Order? order = default);

        /// <summary>
        /// Get answers identified by a set of ids. (API Method: "/answers/{ids}")
        /// </summary>
        Task<StacManResponse<Answer>> GetByIds(string site, IEnumerable<int> ids, string? filter = default, int? page = default, int? pagesize = default, DateTime? fromdate = default, DateTime? todate = default, Answers.Sort sort = default, DateTime? mindate = default, DateTime? maxdate = default, int? min = default, int? max = default, Order? order = default);

        /// <summary>
        /// Get comments on the answers identified by a set of ids. (API Method: "/answers/{ids}/comments")
        /// </summary>
        Task<StacManResponse<Comment>> GetComments(string site, IEnumerable<int> ids, string? filter = default, int? page = default, int? pagesize = default, DateTime? fromdate = default, DateTime? todate = default, Comments.Sort sort = default, DateTime? mindate = default, DateTime? maxdate = default, int? min = default, int? max = default, Order? order = default);

    }
}
