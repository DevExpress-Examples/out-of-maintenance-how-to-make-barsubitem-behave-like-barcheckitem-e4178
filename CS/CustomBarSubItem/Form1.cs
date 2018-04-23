using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using CustomBar.CustomBarManager;
using DevExpress.XtraBars;

namespace CustomBar {
    public partial class Form1 : Form {
        
        public Form1() {
            InitializeComponent();
            CustomBarBuilding();
        }

        public void CustomBarBuilding() {

            BarCheckItem menuCheckItem = new BarCheckItem(customBarManager1, false) { Caption = "customCheckItem"};

            CustomBarSubItem subItem = new CustomBarSubItem(customBarManager1, "Menu");

            BarCheckItem subMenuCheckItem = new BarCheckItem(customBarManager1, false) { Caption = "checkItem1"};
            BarCheckItem subMenuCheckItem1 = new BarCheckItem(customBarManager1, false) { Caption = "checkItem2" };
            BarCheckItem subMenuCheckItem2 = new BarCheckItem(customBarManager1, false) { Caption = "checkItem3" };
            
            subItem.AddItems(new BarItem[] { subMenuCheckItem, subMenuCheckItem1, subMenuCheckItem2 });
            bar2.AddItems(new BarItem[] { subItem, menuCheckItem });
        }

    }
}
