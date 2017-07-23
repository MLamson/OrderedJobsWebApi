using System;
using OrderedJobs.DataTwo;

namespace OrderedJobs.DomainTwo
{
    public class TestDomain
    {
        public TestDomain()
        {
            
        }

		public string Test()
		{
            var databaseAccess = new DatabaseAccess();
            var result = databaseAccess.TestText();
            return result;
		}

		public void AddToDatabase()
		{

		}
    }
}
