using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class People1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            #region  //增加

            efDemoContainer db = new efDemoContainer();
            People model = new People { Age = "89", Name = "zry" };
            db.PeopleSet.Add(model);//将数据添加到EF并且添加了添加标记。
            db.SaveChanges();//数据才会保存到数据库。,返回受影响的行数。
            Response.Write(model.Id + "  " + model.Age + " " + model.Name);

            #endregion

            #region  //修改

            //model = new People { Id = 2, Age = "89", Name = "帅哥" };
            //db.Entry<People>(model).State = System.Data.Entity.EntityState.Modified;
            //db.SaveChanges();
            //Response.Write(model.Id + "  " + model.Age + " " + model.Name);

            #endregion

            #region  //查询

            //var list = (from u in db.PeopleSet where u.Id == 1 select u).ToList();
            //Response.Write(list[0].Name);

            #endregion

            #region  //删除

            //db.Entry<People>(model).State = System.Data.Entity.EntityState.Deleted;
            //db.SaveChanges();

            #endregion
        }
    }
}