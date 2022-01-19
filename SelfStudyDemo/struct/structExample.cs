using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 结构
{
    public struct Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public char Gender { get; set; }

        public 有无二胎 Kid { get; set; }
    }

    public enum 有无二胎
    {
        丁克,
        一胎,
        二胎,
        响应国家号召重赏三胎
    }
    internal class structExample
{
}
}
