using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18
{
    class Vector3D
    {
        int x, y, z;
        public Vector3D(String a, String b, String c) {
             x = int.Parse(a);
             y = int.Parse(b);
             z = int.Parse(c);
        }
        public String getLength() {
            String length= Math.Sqrt((x*x)+(y*y)+(z*z)).ToString();
            return length;
        }
    }
   
    
}
