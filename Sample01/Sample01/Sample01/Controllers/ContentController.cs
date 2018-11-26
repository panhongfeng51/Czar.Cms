using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Sample01.Models;

namespace Sample01.Controllers
{
    /// <summary>
    /// Content 控制器
    /// </summary>
    public class ContentController : Controller
    {
        private readonly Content contents;

        public ContentController(IOptions<Content> option) {
            contents = option.Value;
        }
        /// <summary>
        /// 首页显示
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            ContentViewModel con = new ContentViewModel();
            var content = new List<Content>();
            content.Add(contents);
            //for (int i = 0; i < 12; i++)
            //{
            //    contents.Add(new Content { Id = i, title = $"{i}的标题", content = $"{i}的内容", status = 1, add_time = DateTime.Now.AddDays(-i) });
            //}
            con.Contents = content;
            return View(con);
        }
    }
}