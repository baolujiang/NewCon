using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console1
{
    public class Car
    {

    	public string Name {get;set;}

    	public void Move()
    	{
    		Console.WriteLine("Moving");
    	}

    	public override string ToString() => Name;
    }
}
