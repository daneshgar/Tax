using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tax.Application.Dto
{
    public class TaxItemDto
    {
        public int Id { get; set; }
        public string Inno { get; set; }
        public bool IsConfirm { get; set; }
    }
}
