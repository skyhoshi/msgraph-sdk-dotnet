using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Microsoft.Graph.Test.Requests.Functional
{
    //[Ignore]
    [TestClass]
    public class InsightTests : GraphTestBase
    {


        // Tests the Trending me/insights/trending insight.
        [TestMethod]
        public async System.Threading.Tasks.Task InsightsTrendingFilterTypeTest()
        {
            try
            {
                var query = new List<Option>()
                {
                    new QueryOption("filter", "resourcevisualization/containertype eq 'site'"),
                    new HeaderOption("Prefer", "exchange.behavior=\"officegraphinsights\"")
                };

                var insightPages = await graphClient.Me.Insights.Trending.Request(query).GetAsync();
                
                Assert.IsNotNull(insightPages, "Unexpected results, the results contains a null collection.");
            }
            catch (Microsoft.Graph.ServiceException e)
            {
                Assert.Fail("Something happened, check out a trace. Error code: {0}", e.Error.Code);
            }
        }

        // Tests the Trending me/insights/trending insight.
        [TestMethod]
        public async System.Threading.Tasks.Task InsightsTrendingTest()
        {
            try
            {
                var insightPages = await graphClient.Me.Insights.Trending.Request().GetAsync();

                Assert.IsNotNull(insightPages, "Unexpected results, the results contains a null collection.");
            }
            catch (Microsoft.Graph.ServiceException e)
            {
                Assert.Fail("Something happened, check out a trace. Error code: {0}", e.Error.Code);
            }
        }

        // Tests the Trending me/insights/trending insight with NextLink.
        [TestMethod]
        public async System.Threading.Tasks.Task InsightsTrendingNextlinkTest()
        {
            try
            {
                var query = new List<Option>()
                {
                    new QueryOption("top", "5")
                };

                var insightPage = await graphClient.Me.Insights.Trending.Request(query).GetAsync();

                while (insightPage.NextPageRequest != null)
                {
                    var nextPage = insightPage.NextPageRequest.GetAsync();
                }

                Assert.IsNotNull(insightPage.NextPageRequest, "Unexpected results, the NextPageRequest is null.");
            }
            catch (Microsoft.Graph.ServiceException e)
            {
                Assert.Fail("Something happened, check out a trace. Error code: {0}", e.Error.Code);
            }
        }

        // Tests the Trending me/insights/trendingaround insight .
        [TestMethod]
        public async System.Threading.Tasks.Task InsightsTrendingAroundTest()
        {
            try
            {
                var trendingAroundPage = await graphClient.Me.TrendingAround.Request().GetAsync();

                Assert.IsNotNull(trendingAroundPage, "Unexpected results, the trendingAroundPage is null.");
            }
            catch (Microsoft.Graph.ServiceException e)
            {
                Assert.Fail("Something happened, check out a trace. Error code: {0}", e.Error.Code);
            }
        }

    }
}
