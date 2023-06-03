using Microsoft.ML.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class ModelInput
    {
        [ColumnName("duration"), LoadColumn(1)]
        public float Duration { get; set; }

        [ColumnName("credit_amount"), LoadColumn(4)]
        public float CreditAmount { get; set; }

        [ColumnName("age"), LoadColumn(12)]
        public float Age { get; set; }

        [ColumnName("class"), LoadColumn(20)]
        public string Class { get; set; }
    }
}
