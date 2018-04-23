using System;
using System.Collections.Generic;
using System.Linq;
using DevExpress.XtraBars.Painters;
using DevExpress.XtraBars.Styles;

namespace CustomBar.CustomBarManager {
    class CustomBarLinkPainter : BarCustomContainerLinkPainter{
        public CustomBarLinkPainter(BarManagerPaintStyle paintStyle)
            : base(paintStyle) {
            
        }

        protected override void DrawLinkHorizontal(BarLinkPaintArgs e) {
            CustomBarSubItem item = e.LinkInfo.Link.Item as CustomBarSubItem;
            if (item.IsChildItemChecked )
                base.DrawLinkPressed(e);
            else
                base.DrawLinkHorizontal(e);
        }
    }
}
