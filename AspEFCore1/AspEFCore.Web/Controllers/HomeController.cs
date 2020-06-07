using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AspEFCore.Web.Models;
using AspEFCore.Domain;
using AspEFCore.Data;
using Microsoft.IdentityModel.Tokens;
using Microsoft.AspNetCore.Identity.UI.Pages.Internal.Account;
using Microsoft.EntityFrameworkCore;

namespace AspEFCore.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly MyContext _context;
        private readonly MyContext _context2;
        public HomeController(MyContext context ,MyContext context2)
        {
            _context = context;
            _context2 = context2;
        }
        public IActionResult Index()
        {


            


            // /**
            //  * 这第一段是插入
            // */

            // var province = new Province
            // {
            //     //设置Province的属性值
            //     Name = "上海",
            //     Population = 2_000_000,

            // };
            // var province1 = new Province
            // {
            //     //设置Province的属性值
            //     Name = "北京",
            //     Population = 3_000_000,

            // };
            // var province2 = new Province
            // {
            //     //设置Province的属性值
            //     Name = "浙江",
            //     Population = 9_000_000,

            // };
            // var province3 = new Province
            // {
            //     //设置Province的属性值
            //     Name = "杭州",
            //     Population = 1_000_000,

            // };


            // var province4 = new Province
            // {
            //     //设置Province的属性值
            //     Name = "天津",
            //     Population = 1_000_000,

            // };
            // var company4 = new Company
            // {
            //     //设置Province的属性值
            //     Name = "TTTTT",
            //     EstablishDate = new DateTime(2000, 8, 12),
            //     Legaperson = "Seret Man"
            // };
            // //不同的类型一起放入
            // //_context.AddRange(province4, company4);
            // //_context.SaveChanges();

            // //以下两者执行效果一样将province对象加入内存开始追踪对象
            // //_context.Provinces.Add(province);
            // //_context.Add(province);
            // //检查追踪对象并生成sql语句将数据放入数据库
            // //_context.SaveChanges();

            // //批量操作集合写法比较多用
            // //_context.Provinces.AddRange(province1,province2,province3);
            // // _context.Provinces.AddRange(new List<Province> { province1, province2, province3 });
            // //_context.SaveChanges();


            // /**
            //  *第二段是搜查
            //  * */


            // //表中所有的数据全部取出来where里可以加条件  遇到Tolist才会查询
            // //将参数放到变量里比较安全
            // var param = "北京";
            // var provinces1 = _context.Provinces.Where(x => x.Name == param).ToList();
            // //ToList()可以改成.FirstOrDefault()返回第一条 Find(int n)等等

            // //(x => EF.Functions.Like(x.Name,"%bei%"))相当于Name like '%bei%'   %bei%可以用参数代替

            // //x => x.Name == "北京" 为lamda表达式可替换为下面
            // //private bool Filterbeijing(Province p)
            // //{
            // //    return p.Name == "北京";
            // //}

            // /*var provinces1 = (from p in _context.Provinces
            //                   where p.Name == "北京"
            //                   select p).ToList();*/

            // var provinces = _context.Provinces.ToList();

            // /****
            //  * 第三段修改updata 结合save
            //  */
            // //修改被追踪的对象
            // var province5 = _context.Provinces.FirstOrDefault();
            // if (province5 != null)
            // {
            //     province5.Population += 1000;
            //     _context.SaveChanges();
            // }

            // //修改离散对象
            // var province6 = _context.Provinces.FirstOrDefault();
            // _context2.Provinces.Update(province6);
            //// _context2.UpdateRange();
            //// _context2.Update();
            // _context2.SaveChanges();


            // /**
            //  * 第四段是删除 只能删除已经追踪的对象
            //  * **/

            // var province7 = _context.Provinces.FirstOrDefault();
            // _context.Provinces.Remove(province7);
            // _context.SaveChanges();


            /***
             * 数据的关联 城市与省份
             * **/

            //var province = new Province
            //{
            //    Name = "辽宁",
            //    Population = 40_000_000,
            //    //建立关联的导航的属性
            //    Cities = new List<City>
            //    {
            //        new City{ AreaCode="0244" , Name="沈阳"},
            //        new City{ AreaCode="0255" , Name="大连"}
            //    }
            //};

            //_context.Provinces.Add(province);

            //var province = _context.Provinces.Single(x => x.Name == "辽宁");
            //province.Cities.Add(new City
            //{
            //    AreaCode="02222",
            //    Name ="鞍山"
            //});

            //在离线状态下使用外键

            //var city = new City
            //{
            //    ProvinceId = 12,
            //    AreaCode ="02222",
            //    Name="鞍山"
            //};
            //_context.Cities.Add(city);

            /***
             * 查询关联数据
             * **/
            ////where根据情况加   Include(x => x.Cities)只能放在这个位子
            //var provinces = _context
            //    .Provinces
            //    .Include(x => x.Cities)
            //    .Where(x => x.Name=="辽宁")
            //    .ToList();

            ////多重关联属性查询
            //var provinces = _context
            //    .Provinces
            //    .Include(x => x.Cities)
            //    .ThenInclude(x => x.CityCompanies)
            //    .ThenInclude(x => x.Company)
            //    .ToList();


            ////映射查询 返回只有两个属性的集合
            //var ProvincesInfo = _context
            //    .Provinces
            //    .Select(x => new
            //    {
            //        x.Name,
            //        x.Id
            //    })
            //    .ToList();

            //var ProvincesInfo = _context
            //    .Provinces
            //    .Select(x => new
            //    {
            //        x.Name,
            //        x.Id,

            //        Cities=x.Cities.Where(y => y.Name == "沈阳").ToList()
            //    })
            //    .ToList();

            /***
              修改关联数据
             
             */
            //var ProvincesInfo = _context
            //    .Provinces
            //    .Include(x => x.Cities)
            //    .First(x => x.Cities.Any());
            //var city = ProvincesInfo.Cities[0];
            //city.Name += "updated";

            //离线状态
            //var ProvincesInfo = _context
            //    .Provinces
            //    .Include(x => x.Cities)
            //    .First(x => x.Cities.Any());
            //var city = ProvincesInfo.Cities[0];
            //city.Name += "updated";

            //_context2.Cities.Update(city);
            //_context2.SaveChanges();

            //_context.SaveChanges();

            return View();
        }

        

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
