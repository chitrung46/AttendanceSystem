using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DynamicSessionTable
    {
        private DataTable data;

        public DynamicSessionTable(DataTable data)
        {
            this.data = data;
        }
        
        public DynamicSessionTable() { }    

        public DataTable Data { get => Data; set => Data = value; }
    }
}
