using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp.Examples
{
  class SuperClass
  {
    public string field;

    public SuperClass()
    {
      field = "default";
    }

    public SuperClass(string str)
    {
      field = str;
    }
  }
}
