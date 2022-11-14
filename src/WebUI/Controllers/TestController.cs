using Application.Common.Interfaces.Memos;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.Controllers
{
    public class TestController : Controller, ITestController
    {
        private readonly IMemoService _memoService;

        public TestController(IMemoService memoService)
        {
            _memoService = memoService;
        }

        public void Index()
        {
            _memoService.TestBatch();
        }
    }
}
