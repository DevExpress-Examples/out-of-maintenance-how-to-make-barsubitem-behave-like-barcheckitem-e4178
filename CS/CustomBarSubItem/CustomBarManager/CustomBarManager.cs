using System;
using System.Collections.Generic;
using System.Linq;
using DevExpress.XtraBars;
using System.ComponentModel;
using DevExpress.XtraBars.Styles;

namespace CustomBar.CustomBarManager {
    class CustomBarManager : BarManager {
        public CustomBarManager(IContainer container)
            : base(container) {

        }

        protected virtual void UpdateBarItemInfo() {
            foreach (BarManagerPaintStyle ps in GetController().PaintStyles) {
                if (ps is SkinBarManagerPaintStyle) {
                    foreach (BarItemInfo info in ps.ItemInfoCollection) {
                        if (info.Name == "BarSubItem") {
                            ps.ItemInfoCollection.Add(new BarItemInfo(CustomBarSubItem.BarItemName, CustomBarSubItem.SubBarItemCaption, -1, typeof(CustomBarSubItem), info.LinkType, info.ViewInfoType,  new CustomBarLinkPainter(ps), true, false));
                            return;
                        }
                    }
                }
            }
        }
        protected override void OnLoaded() {
            base.OnLoaded();
            UpdateBarItemInfo();
        }

        private void ChildItemChecking(CustomBarSubItem subItem) {
            subItem.IsChildItemChecked = false;
            for (int i = 0; i < subItem.ItemLinks.Count; i++) {
                if (subItem.ItemLinks[i].GetType() == typeof(BarCheckItemLink) && ((BarCheckItem)subItem.ItemLinks[i].Item).Checked) {
                    subItem.IsChildItemChecked = true;
                    break;
                }
            }
        }

        protected override void RaiseItemClick(ItemClickEventArgs e) {
            base.RaiseItemClick(e);
            if (e.Link != null && e.Link.Item.GetType() == typeof(BarCheckItem)) {
                if (e.Link.OwnerItem != null && e.Link.OwnerItem.GetType() == typeof(CustomBarSubItem)) {
                    ChildItemChecking((CustomBarSubItem)e.Link.OwnerItem);
                }
            }
        }
    }
}
