using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace BookFollowingSystem
{

    interface ILoanable { 
    bool IsAvailable { get; set; }
    string BorrowerName { get; set; }
        DateTime? DueTime { get; set; }
        void BorrowItem(string memberName);
        void ReturnItem();
    }

    internal class Book : BaseMember, ILoanable
    {
        public string Author { get; set; }
        public int pageCount { get; set; }
        public int ISBN { get; set; }

        public bool IsAvailable { get; set; } = true;
        public string BorrowerName { get; set; }
        public DateTime? DueTime { get; set; }

        public void BorrowItem(string memberName)
        {
            if (!IsAvailable)
            {
                Console.WriteLine(Title + " isimli kitap " + BorrowerName + " kullanıcı tarafından zaten ödünç alınmıştır");
                return;
            }
            IsAvailable = false;
            BorrowerName = memberName;
            DueTime = DateTime.Now.AddDays(14);
            Console.WriteLine(Title + " isimli kitap " + BorrowerName + " adlı üye tarafından başarı ile ödünç alınmıştır");

        }

        public void ReturnItem()
        {
            if (IsAvailable)
            {
                Console.WriteLine(Title + " isimli kitap zaten kütüphanede mevcut, iade edilemez");
                return;
            }
            IsAvailable = true;
            BorrowerName = null;
            DueTime = null;
            Console.WriteLine(Title + " isimli kitap " + DateTime.Now + " tarihinde iade edilmiştir");
        }





    }
}
