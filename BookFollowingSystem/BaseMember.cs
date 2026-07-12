using System;
using System.Collections.Generic;
using System.Text;

namespace BookFollowingSystem
{
    internal abstract class BaseMember
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public int PublishYear { get; set; }
        public bool IsAvaiable { get; set; } = true;
    }
}
