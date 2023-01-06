using AdminLog.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Extensions;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.AspNetCore.OData.Query.Validator;
using Microsoft.AspNetCore.OData.Query.Wrapper;
using Microsoft.AspNetCore.OData.Results;
using Microsoft.AspNetCore.OData.Routing.Controllers;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using ODataTest;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text.Json;
using System.Threading.Tasks;
using System.Web;

namespace ODataTest3._1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ODataController
    {
        private JsonSerializerOptions _jsonOptions;
        public UsersController(IOptions<JsonOptions> jsonOptions)
        {
            _jsonOptions = jsonOptions.Value.JsonSerializerOptions;
        }

        [HttpGet]
        // [EnableQuery] // if you have ODataQueryOptions as parameters, don't enable it.
        public IActionResult Get(ODataQueryOptions<User> query)
        {
            SystemDB db = new SystemDB();
            if (query == null)
            {
                return Ok(db.Users);
            }
            else
            {
                //IQueryable queryable = db.Users.AsQueryable();
                var queried = query.ApplyTo(db.Users.AsQueryable(), new ODataQuerySettings { PageSize = 2 });
                var elementType = queried.ElementType;
                if (typeof(ISelectExpandWrapper).IsAssignableFrom(elementType))
                {
                    // you can serialize it as array for test.
                    //string a = Serialize(queried);

                    IList<IDictionary<string, object>> list = new List<IDictionary<string, object>>();
                    foreach (var item in queried)
                    {
                        var wrapper = item as ISelectExpandWrapper;
                        var dic = wrapper.ToDictionary();
                        list.Add(dic);
                    }

                    return Ok(list);
                }
                else
                {
                    return Ok(queried.Cast<User>());
                }
            }
        }
        //private string Serialize(IQueryable queryable)
        //{
        //    // Should include the SelectExpandWrapperConverter in the json options.
        //    // You can introduce it by calling AddOData
        //    // or directly create a serializerOptions and add converter into converters.
        //    var s = JsonSerializer.Serialize(queryable, _jsonOptions);
        //    return s;
        //}

        // Test2
        [EnableQuery]
        public IQueryable<User> GetTest1(ODataQueryOptions<User> opts)
        {
            SystemDB db = new SystemDB();
            if (opts.SelectExpand != null)
            {
                opts.SelectExpand.LevelsMaxLiteralExpansionDepth = 5;
            }
            var users = opts.SelectExpand.ApplyTo(db.Users.AsQueryable(), new ODataQuerySettings());
            var result = users as IQueryable<User>;
            return result;
        }

        // Working
        //[EnableQuery]
        public PageResult<User> GetTest2(ODataQueryOptions<User> options)
        {
            SystemDB db = new SystemDB();
            IQueryable<User> result = null;
            int count = 0;
            var validationSettings = new ODataValidationSettings
            {
                AllowedQueryOptions = AllowedQueryOptions.All,
                AllowedFunctions = AllowedFunctions.All,
                AllowedArithmeticOperators = AllowedArithmeticOperators.All,
                AllowedLogicalOperators = AllowedLogicalOperators.All
            };

            if (options?.Filter != null)
            {
                result = options.Filter.ApplyTo(db.Users, new ODataQuerySettings()) as IQueryable<User>;
                count = result.Count();
            }
            else
            {
                result = db.Users; // This gets all
                count = result.Count();
            }
            //options.Validate(validationSettings);
            IQueryable resultSet = options.ApplyTo(result, new ODataQuerySettings { PageSize = 2 });
            IList<IDictionary<string, object>> list = new List<IDictionary<string, object>>();
            List<User> resultList = new List<User>();
            foreach (var item in resultSet)
            {
                if (item is User)
                {
                    resultList.Add((User)item);
                }
                else if (item.GetType().Name == "SelectAllAndExpand`1")
                {
                    var entityProperty = item.GetType().GetProperty("Instance");
                    resultList.Add((User)entityProperty.GetValue(item));
                }
                else if (item.GetType().Name == "SelectSome`1")
                {
                    var dict = ((ISelectExpandWrapper)item).ToDictionary();
                    var Response = JsonConvert.SerializeObject(dict);
                    var model = JsonConvert.DeserializeObject<User>(Response);
                    //var model = dict.TObject<User>();
                    resultList.Add(model);
                }
            }
            return new PageResult<User>(resultList, null, count);
        } // Enf of Working


    }
}
