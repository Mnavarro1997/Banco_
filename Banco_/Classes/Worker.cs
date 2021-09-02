using System;
using System.Collections.Generic;
using System.Text;

namespace Banco_
{
    /// <summary>
    /// worker extends of person because person could be a client or a worker.
    /// </summary>
    public class Worker : Person
    {
        /// <summary>
        /// we pass the parameter of name, age and code to madre the "mother base" 
        /// </summary>
        /// <param name="Name"></param>
        /// <param name="Age"></param>
        /// <param name="Code"></param>
        public Worker(string Name = "María", int Age = 20, int Code = 5) : base(Name, Age, Code)
        {
        }

        public string WorkerCode { get; set; }
        

   
    }
}
