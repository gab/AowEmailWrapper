﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AowEmailWrapper.ConfigFramework;
using AowEmailWrapper.Games;
using AowEmailWrapper.Classes;
using AowEmailWrapper.Localization;

namespace AowEmailWrapper.Controls
{
    public delegate void ActivityListViewEventHandler(object sender, List<Activity> list);

    public partial class ActivityListView : UserControl
    {
        #region Private Members

        private ActivityList _activityLog;
        private ListViewColumnSorter _lvwColumnSorter;
        private ContextMenu _contextMenu;
        private MenuItem _resendMenuItem;

        private const string Menu_Remove_Tag = "menuItemRemove";
        private const string Menu_MarkEnded_Tag = "menuItemMarkEnded";
        private const string Menu_MarkSent_Tag = "menuItemMarkSent";
        private const string Menu_Resend_Tag = "menuItemResend";

        #endregion

        #region Public Properties

        new public ActivityListViewEventHandler OnDoubleClick;
        public ActivityListViewEventHandler OnMarkAsEnded;
        public ActivityListViewEventHandler OnResendClick;
        public ActivityListViewEventHandler OnDeleteClick;
        public EventHandler OnListChanged;

        public ActivityList ActivityLog
        {
            get 
            { 
                return _activityLog; 
            }
            set 
            { 
                _activityLog = value;
                Populate();
            }
        }

        public ImageList SmallImageList
        {
            get { return listView.SmallImageList; }
            set { listView.SmallImageList = value; }
        }

        #endregion

        #region Constructors

        public ActivityListView()
        {
            InitializeComponent();
            _lvwColumnSorter = new ListViewColumnSorter();
            _lvwColumnSorter.Order = SortOrder.Descending;
            listView.ListViewItemSorter = _lvwColumnSorter;
            listView.ClientSizeChanged += new EventHandler(ActivityListView_Resize);
            listView.ColumnWidthChanging += new ColumnWidthChangingEventHandler(listView_ColumnWidthChanging);
            CreateContextMenu();
        }

        #endregion

        #region Public Methods

        public override void Refresh()
        {            
            Populate();
            base.Refresh();
        }

        #endregion

        #region Private Methods

        private void Populate()
        {
            listView.BeginUpdate();

            listView.Items.Clear();

            if (_activityLog != null && _activityLog.Activities != null && _activityLog.Activities.Count > 0)
            {
                foreach (Activity activity in _activityLog.Activities)
                {
                    ListViewItem item = new ListViewItem();
                    int age = GetAgeInDays(activity.DateTicks);                    
                    SetItemColour(item, activity, age);
                    
                    item.Text = activity.FileName;
                    item.ToolTipText = item.Text;
                    item.SubItems.Add(new ListViewItem.ListViewSubItem(item, activity.MapTitle));
                    item.SubItems.Add(new ListViewItem.ListViewSubItem(item, activity.TurnNumber));
                    item.SubItems.Add(new ListViewItem.ListViewSubItem(item, (age > 0) ? age.ToString() : string.Empty));
                    item.SubItems.Add(new ListViewItem.ListViewSubItem(item, activity.Status.Equals(ActivityState.None) ? string.Empty : Translator.TranslateEnum(activity.Status)));                    
                    item.SubItems.Add(new ListViewItem.ListViewSubItem(item, activity.DateTicks));

                    item.Tag = activity;

                    switch (activity.GameType)
                    {
                        case AowGameType.Aow1:
                            item.ImageIndex = 3;
                            break;
                        case AowGameType.Aow2:
                            item.ImageIndex = 4;
                            break;
                        case AowGameType.AowSm:
                            item.ImageIndex = 5;
                            break;
                        case AowGameType.AowMpe:
                            item.ImageIndex = 6;
                            break;
                        case AowGameType.Unknown:
                            item.ImageIndex = 7;
                            break;
                    }

                    listView.Items.Add(item);
                }

                _lvwColumnSorter.SortColumn = 5;
                listView.Sort();

                ListViewColumnResizer.ResizeColumns(listView);
            }
            else
            {
                ListViewColumnResizer.ResizeColumns(listView);
            }

            listView.EndUpdate();
        }

        private void listView_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = listView.Columns[e.ColumnIndex].Width;
        }

        private void RaiseListChanged()
        {
            if (OnListChanged != null)
            {
                OnListChanged(this, new EventArgs());
            }
        }

        private List<Activity> GetSelectedActivities()
        {
            List<Activity> returnVal = new List<Activity>();

            if (listView.SelectedItems.Count > 0)
            {
                foreach (ListViewItem selected in listView.SelectedItems)
                {
                    returnVal.Add((Activity)selected.Tag);
                }
            }

            return returnVal;
        }

        private void RemoveSelected(List<Activity> theActivities)
        {
            if (theActivities != null && theActivities.Count > 0)
            {
                foreach (Activity activity in theActivities)
                {
                    _activityLog.Activities.Remove(activity);
                }                
                Refresh();
                RaiseListChanged();
            }
        }

        private void MarkState(ActivityState state, List<Activity> theActivities)
        {
            if (theActivities != null && theActivities.Count > 0)
            {
                foreach (Activity activity in theActivities)
                {
                    activity.Status = state;
                }
                Refresh();
                RaiseListChanged();
            }
        }

        private void listView_DoubleClick(object sender, System.EventArgs e)
        {
            if (OnDoubleClick != null)
            {
                List<Activity> theList = GetSelectedActivities();

                if (theList != null && theList.Count == 1)
                {
                    OnDoubleClick(this, theList);
                }
            }
        }

        private void SetItemColour(ListViewItem listItem, Activity activity, int age)
        {
            switch (activity.Status)
            { 
                case ActivityState.Received:
                    listItem.BackColor = SystemColors.Info;
                    break;
                case ActivityState.Sent:
                    if (age >= 14 && age < 28)
                    {
                        listItem.BackColor = Color.PeachPuff;
                    }
                    else if (age >= 28)
                    {
                        listItem.BackColor = Color.MistyRose;
                    }
                    break;
                case ActivityState.Pending:
                    listItem.ForeColor = Color.Blue;
                    break;
                case ActivityState.Ended:
                    listItem.ForeColor = Color.Gray;
                    break;
            }
        }

        private int GetAgeInDays(string theTicks)
        {
            int returnVal = 0;
            long ticks = 0;
            if (long.TryParse(theTicks, out ticks))
            {
                DateTime timeStamp = new DateTime(ticks);

                TimeSpan age = DateTime.Now.Subtract(timeStamp);
                returnVal = age.Days;
            }
            return returnVal;
        }

        private void ActivityListView_Resize(object sender, EventArgs e)
        {
            listView.BeginUpdate();
            ListViewColumnResizer.ResizeColumns(listView);
            listView.EndUpdate();
        }

        #endregion

        #region Context Menu

        private void CreateContextMenu()
        {
            _contextMenu = new ContextMenu();

            int indexCount = 0;

            EventHandler menuItemClickEvent = new EventHandler(ContextMenu_Click);
            _contextMenu = new ContextMenu();

            MenuItem remove = new MenuItem();
            MenuItem markEnded = new MenuItem();
            MenuItem markSent = new MenuItem();
            _resendMenuItem = new MenuItem();

            _contextMenu.MenuItems.AddRange(new MenuItem[] { _resendMenuItem, markEnded, markSent, remove });

            _contextMenu.Popup += new EventHandler(ContextMenu_Popup);

            _resendMenuItem.Index = indexCount;
            _resendMenuItem.Text = Translator.Translate(Menu_Resend_Tag);
            _resendMenuItem.Tag = Menu_Resend_Tag;
            _resendMenuItem.Click += menuItemClickEvent;

            indexCount++;
            markEnded.Index = indexCount;
            markEnded.Text = Translator.Translate(Menu_MarkEnded_Tag);
            markEnded.Tag = Menu_MarkEnded_Tag;
            markEnded.Click += menuItemClickEvent;

            indexCount++;
            markSent.Index = indexCount;
            markSent.Text = Translator.Translate(Menu_MarkSent_Tag);
            markSent.Tag = Menu_MarkSent_Tag;
            markSent.Click += menuItemClickEvent;

            indexCount++;
            remove.Index = indexCount;
            remove.Text = Translator.Translate(Menu_Remove_Tag);
            remove.Tag = Menu_Remove_Tag;
            remove.Click += menuItemClickEvent;

            listView.ContextMenu = _contextMenu;
        }

        private void ContextMenu_Click(object sender, EventArgs e)
        {
            List<Activity> selected = GetSelectedActivities();

            if (selected != null && selected.Count > 0)
            {
                string senderTag = ((MenuItem)sender).Tag.ToString();

                switch (senderTag)
                {
                    case Menu_Remove_Tag:
                        RemoveSelected(selected);
                        if (OnDeleteClick != null)
                        {
                            OnDeleteClick(this, selected);
                        }
                        break;
                    case Menu_MarkEnded_Tag:
                        MarkState(ActivityState.Ended, selected);
                        if (OnMarkAsEnded != null)
                        {
                            OnMarkAsEnded(this, selected);
                        }
                        break;
                    case Menu_MarkSent_Tag:
                        MarkState(ActivityState.Sent, selected);
                        break;
                    case Menu_Resend_Tag:
                        if (OnResendClick != null)
                        {
                            OnResendClick(this, selected);
                        }
                        break;
                }
            }
        }

        private void ContextMenu_Popup(object sender, EventArgs e)
        {
            bool enabled = listView.SelectedItems.Count > 0;
            foreach (MenuItem menu in _contextMenu.MenuItems)
            {
                menu.Enabled = enabled;
            }

            bool resend = false;
            foreach (Activity activity in GetSelectedActivities())
            {
                resend = !activity.Status.Equals(ActivityState.Ended) && AowEmailWrapper.Helpers.ResendHelper.CanResend(activity.FileName);
                if (!resend)
                {
                    break;
                }
            }

            _resendMenuItem.Enabled = resend;
        }

        #endregion
    }
}
