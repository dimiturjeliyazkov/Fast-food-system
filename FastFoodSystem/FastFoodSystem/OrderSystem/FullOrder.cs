using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CompleteSystem.OrdersSystem.Models;
using PastaMadnessSystem;

namespace CompleteSystem.OrdersSystem
{
    public class FullOrder
    {
        public static bool isRazplatena = false;
        public Button button { get; set; }
        public IndividualnaPorucha form { get; set; }
        public Glovo glovo { get; set; }
        public Takeaway takeaway { get; set; }
        public Poruchka poruchka { get; set; }
        public FullOrder()
        {
            button = new Button();
            poruchka = new Poruchka();
            // form = new IndividualnaPorucha();
        }
    }
}
