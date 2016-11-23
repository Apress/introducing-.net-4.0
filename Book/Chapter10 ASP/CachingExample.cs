using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Caching;

namespace Chapter10.ASP
{
    public class CachingExample
    {
        public void UseCache()
        {
            ObjectCache cache = MemoryCache.Default;
            string testData = cache["someData"] as string;

            if (testData == null)
            {
                CacheItemPolicy policy = new CacheItemPolicy();
                policy.AbsoluteExpiration = new DateTimeOffset(DateTime.Now.AddHours(1));
                cache.Set("someData", "some test data", policy);
            }
        }
    }
}