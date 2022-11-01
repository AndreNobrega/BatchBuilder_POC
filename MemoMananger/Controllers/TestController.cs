using Microsoft.AspNetCore.Mvc;

namespace MemoMananger.Controllers
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
