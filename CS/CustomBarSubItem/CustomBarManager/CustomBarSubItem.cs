using System;
using System.Collections.Generic;
using System.Linq;
using DevExpress.XtraBars;

namespace CustomBar.CustomBarManager {
    class CustomBarSubItem : BarSubItem{

        public const string BaseBarItemName = "BarSubItem";
        public const string BarItemName = "CustomBarCheckSubItem";
        public const string SubBarItemCaption = "CustomBarCheckSubItem";

        private bool isChecked;

        public bool IsChildItemChecked {
            get {
                return isChecked;
            }
            set {
                if (value != isChecked) 
                { 
                    isChecked = value; 
                }
            }
        }
        
        public CustomBarSubItem(BarManager manager, string caption)
            : base(manager, caption) {
                IsChildItemChecked = false;
                
        }

        public CustomBarSubItem(BarManager manager, string caption, BarItem[] items)
            : base(manager, caption, items) {
            
        }

        public CustomBarSubItem(BarManager manager, string caption, int imageIndex)
            : base(manager, caption, imageIndex) {
            
        }

        public CustomBarSubItem(BarManager manager, string caption, int imageIndex, BarItem[] items)
            : base(manager, caption, imageIndex, items) {
            
        }
    }   
}
