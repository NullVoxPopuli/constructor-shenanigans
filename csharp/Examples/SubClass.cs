using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp.Examples
{
  class SubClass : SuperClass
  {

    // 2. Add a constructor to SubClass that takes one parameter
    //    because the constructor with one parameter in the 
    //    SuperClass is not inherited.
    public SubClass(string str)
      : base(str)
    {
      // nothing additional to do, superclass handles constructing
    }

    // 4. Add a parameterless constructor
    public SubClass()
      : base()
    {
      // nothing additional to do, superclass handles constructing
    }
  }
}
