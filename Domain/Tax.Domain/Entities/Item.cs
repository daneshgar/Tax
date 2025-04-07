using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tax.Domain.Entities
{
    public class TaxItem
    {
        public int Id { get; private set; }
        public string Inno { get; private set; }
        public bool IsConfirm { get; private set; }

        public TaxItem(string inno)
        {
            Inno = inno;
            IsConfirm = false; // مقدار پیش‌فرض
        }

        public void Confirm()
        {
            IsConfirm = true;
        }
    }
}
