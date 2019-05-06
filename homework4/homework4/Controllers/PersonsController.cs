using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using homework4.Models; //导入模型

namespace homework4.Controllers
{
    public class PersonsController : ApiController
    {
        //首先创建数据容器和对应的编号容器
        private static List<Person> persons = new List<Person>()
        {
            new Person{ID=1,First="f1",Last="l1"},
            new Person{ID=2,First="f2",Last="l2"},
            new Person{ID=3,First="f3",Last="l3"}
        };
        private static List<int> ids = new List<int>
        {
            1,2,3
        };
        //定义api调用的方法，加[HttpGet]是为了标识，防止方法名不标准导致的调用失败
        [HttpGet]   //"api/Get"
        //无参Get方法
        public IEnumerable<Person> Get()
        {
            if (persons.Count() == 0)   //容器为空，返回一个错误信息
                return new List<Person>{
                    new Person{ID=0,First="Error!",Last="No person!"}
                };
            return persons; //容器不为空，返回persons中的所有person
        }
        [HttpGet]
        //有参Get方法，默认从url中提取参数
        public Person Get(int id)
        {
            if (ids.Contains(id))   //查找到id，返回对应person
            {
                int index = ids.IndexOf(id);
                return persons[index];
            }
            return new Person { ID = 0, First = "Error!", Last = "False id!" }; //否则，返回一个错误信息
        }
        [HttpPost]
        //有参Post方法，默认从request中提取参数
        public string Post([FromBody]Person value)
        {
            if (!ids.Contains(value.ID))    //不存在value，则插入一个
            {
                persons.Add(new Person { ID=value.ID,First=value.First,Last=value.Last });
                ids.Add(value.ID);
                return "Create it!";
            }
            return "Already exist!";     //否则，返回一个错误信息
        }
        [HttpPut]
        //有参Put方法，默认从url和request中提取参数
        public string Put(int id, [FromBody]Person value)
        {
            if (ids.Contains(id))    //存在id，则可以继续修改
            {
                int index = ids.IndexOf(id);
                persons[index].First = value.First;
                persons[index].Last = value.Last;
                return "Update it!";
            }
            return "No exist!";    //否则，返回一个错误信息
        }
        [HttpDelete]
        //有参Delete方法，默认从url中提取参数
        public string Delete(int id)
        {
            if (ids.Contains(id))   //存在id，就删除
            {
                int index = ids.IndexOf(id);
                ids.Remove(id);
                persons.RemoveAt(index);
                return "Delete it!";
            }
            return "No exist!";    //否则，返回一个错误信息
        }
    }
}
