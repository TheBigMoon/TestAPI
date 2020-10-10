using System;
using System.Collections.Generic;
using System.Text;

namespace Data
{
    public interface IModelBase
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
