using System;
using System.Collections.Generic;
using System.Text;

namespace Lista
{
    public class TaskClass
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Priority { get; set; }
        public string Image
        {
            get
            {
                if (Priority == "Ważne")
                    return "https://cdn-icons-png.flaticon.com/512/5619/5619095.png";
                return "https://upload.wikimedia.org/wikipedia/commons/4/43/Minimalist_info_Icon.png";
            }
        }
    }
}
