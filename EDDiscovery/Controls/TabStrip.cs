﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDDiscovery.Controls
{
    public partial class TabStrip : UserControl
    {
        public bool StripAtTop { get; set;  } = false;
        public Bitmap[] Images;     // images
        public string[] ToolTips;

        public int SelectedIndex { get { return si; } set { ChangePanel(value); } }
        public Control CurrentControl;

        public delegate void RemoveTab(TabStrip t, Control c);
        public event RemoveTab OnRemoving;

        public delegate Control CreateTab(TabStrip t, int no);
        public event CreateTab OnCreateTab;

        public delegate void PostCreateTab(TabStrip t, int no);
        public event PostCreateTab OnPostCreateTab;

        private Panel[] imagepanels;
        private Timer autofade = new Timer();
        private int si = 0;
       
        public TabStrip()
        {
            InitializeComponent();
            labelCurrent.Text = "None";
            autofade.Tick += FadeInOut;
        }

        public void PanelClick(object sender , EventArgs e )
        {
            int i = (int)(((Panel)sender).Tag);
            ChangePanel(i);
        }

        void ChangePanel(int i)
        {
            if ( CurrentControl != null )
            {
                if (OnRemoving!=null)
                    OnRemoving(this,CurrentControl);

                this.Controls.Remove(CurrentControl);
                CurrentControl.Dispose();
                CurrentControl = null;
            }

            if ( OnCreateTab != null )
            {
                CurrentControl = OnCreateTab(this,i);
                CurrentControl.Dock = DockStyle.Fill;

                if (StripAtTop)
                {
                    Control p = this.Controls[0];
                    this.Controls.Clear();
                    this.Controls.Add(CurrentControl);
                    this.Controls.Add(p);
                }
                else
                    this.Controls.Add(CurrentControl);
                labelCurrent.Text = CurrentControl.Text;
                panelSelected.BackgroundImage = Images[i];
                si = i;

                OnPostCreateTab(this, i);
            }
        }

        bool tobevisible = false;

        private void panelBottom_MouseEnter(object sender, EventArgs e)
        {
            if (imagepanels == null && Images != null)
            {
                imagepanels = new Panel[Images.Length];

                int xpos = 150;

                for (int i = 0; i < Images.Length; i++)
                {
                    imagepanels[i] = new Panel()
                    {
                        BackgroundImage = Images[i],
                        Location = new Point(xpos, 4),
                        Tag = i,
                        BackgroundImageLayout = ImageLayout.None,
                        Visible = false
                    };

                    imagepanels[i].Size = new Size(Images[i].Width, Images[i].Height);
                    imagepanels[i].Click += PanelClick;
                    imagepanels[i].MouseEnter += panelBottom_MouseEnter;
                    imagepanels[i].MouseLeave += panelBottom_MouseLeave;

                    if ( ToolTips != null )
                        toolTip1.SetToolTip(imagepanels[i], ToolTips[i]);

                    toolTip1.ShowAlways =true;      // if not, it never appears

                    panelBottom.Controls.Add(imagepanels[i]);

                    xpos += Images[i].Width + 8;
                }
            }

            autofade.Stop();

            if (!tobevisible)
            {
                tobevisible = true;
                autofade.Interval = 350;
                autofade.Start();
                //System.Diagnostics.Debug.WriteLine("{0} {1} Fade in", Environment.TickCount, Name);
            }
        }

        private void panelBottom_MouseLeave(object sender, EventArgs e)     // get this when leaving a panel and going to the icons.. so fade out slowly so it can be cancelled
        {
            autofade.Stop();

            if (tobevisible)
            {
                tobevisible = false;
                autofade.Interval = 750;
                autofade.Start();
                //System.Diagnostics.Debug.WriteLine("{0} {1} Fade out", Environment.TickCount, Name);
            }
        }

        void FadeInOut(object sender, EventArgs e)            // hiding
        {
            autofade.Stop();

            //System.Diagnostics.Debug.WriteLine("{0} {1} Fade {2}" , Environment.TickCount, Name, tobevisible);

            if (imagepanels[0].Visible != tobevisible )
            { 
                for (int i = 0; i < Images.Length; i++)
                    imagepanels[i].Visible = tobevisible;
            }
        }

        private void TabStrip_Layout(object sender, LayoutEventArgs e)
        {
            if (StripAtTop && panelBottom.Dock != DockStyle.Top )
            {
                panelBottom.Dock = DockStyle.Top;
            }
        }
    }
}
