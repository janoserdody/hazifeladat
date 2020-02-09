using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Registrator;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Base.Handler;
using DevExpress.XtraGrid.Views.Base.ViewInfo;

namespace View
{
    [ToolboxItem(true)]
    public class UserList : GridControl
    {
        protected override BaseView CreateDefaultView()
        {
            return CreateView("UserListGridView");
        }

        protected override void RegisterAvailableViewsCore(InfoCollection collection)
        {
            base.RegisterAvailableViewsCore(collection);
            collection.Add(new UserListGridViewInfoRegistrator());
        }
    }

    public class UserListGridViewInfoRegistrator : GridInfoRegistrator
    {
        public override string ViewName => "UserListGridView";

        public override BaseView CreateView(GridControl grid)
        {
            return new UserListGridView(grid);
        }

        public override BaseViewInfo CreateViewInfo(BaseView view)
        {
            return new UserListGridViewInfo(view as UserListGridView);
        }

        public override BaseViewHandler CreateHandler(BaseView view)
        {
            return new UserListGridViewHandler(view as UserListGridView);
        }

        public override BaseViewPainter CreatePainter(BaseView view)
        {
            return new UserListGridViewPainter(view as UserListGridView);
        }
    }

    public class UserListGridView : DevExpress.XtraGrid.Views.Grid.GridView
    {
        public UserListGridView()
        {
        }

        public UserListGridView(GridControl grid) : base(grid)
        {
        }

        protected override string ViewName => "UserListGridView";
    }

    public class UserListGridViewInfo : DevExpress.XtraGrid.Views.Grid.ViewInfo.GridViewInfo
    {
        public UserListGridViewInfo(DevExpress.XtraGrid.Views.Grid.GridView view) : base(view)
        {
        }
    }

    public class UserListGridViewHandler : DevExpress.XtraGrid.Views.Grid.Handler.GridHandler
    {
        public UserListGridViewHandler(DevExpress.XtraGrid.Views.Grid.GridView view) : base(view)
        {
        }
    }

    public class UserListGridViewPainter : DevExpress.XtraGrid.Views.Grid.Drawing.GridPainter
    {
        public UserListGridViewPainter(DevExpress.XtraGrid.Views.Grid.GridView view) : base(view)
        {
        }
    }
}
