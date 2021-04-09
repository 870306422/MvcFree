using MvcFr.Models;
using MvcFr.ViewModels;
using System.Linq;
using System.Web.Mvc;
namespace MvcFr.Controllers
{
    public class StudentController : Controller
    {
        // 学生列表显示
        public ActionResult Index()
        {
            //创建数据库访问上下文对象(dbcontext)
            //using{}释放资源
            using (Student3 db = new Student3())
            {
                #region 基本查询
                //2.通过linq访问对象
                //limbda表达式
                //var list = db.stuinfo.Where(s => s.Id > 5 && s.Age > 20);
                #endregion
                #region 联合查询
                //通过linqe实现链接查询
                //var list = (from s in db.stuinfo
                //           join c in db.classes
                //           on s.Id equals c.Id
                //           select (new StudentviewModel()
                //           {
                //               Id = s.Id,
                //               Name1 = s.Name,
                //               Mobile1 = s.Mobile,
                //               Email1 = s.Email,
                //               Age1 = s.Age,
                //               ClassName1 = c.ClassName
                //           })).ToList();
                #endregion
                #region lambda表达式实现
                //var list = (db.stuinfo.Join(db.classes, s => s.Id, c => c.Id, (s, c) => new StudentviewModel()
                //{
                //    Id = s.Id,
                //    Name1 = s.Name,
                //    Mobile1 = s.Mobile,
                //    Email1 = s.Email,
                //    Age1 = s.Age,
                //    ClassName1 = c.ClassName
                //})).ToList();
                #endregion
                #region 导航关系实现lambda
                var list = (db.stuinfo.Select(s => new StudentviewModel()
                {
                    Id = s.Id,
                    Name1 = s.Name,
                    Mobile1 = s.Mobile,
                    Email1 = s.Email,
                    Age1 = s.Age,
                    ClassName1 = s.classes.ClassName
                })).ToList();
                return View(list);
                #endregion

            }
        }
    }
}