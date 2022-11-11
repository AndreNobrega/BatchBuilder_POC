using MemoManager.Services;
using Microsoft.AspNetCore.Mvc;

namespace MemoManager.Controllers
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
