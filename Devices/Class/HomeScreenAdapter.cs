﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Devices.Class
{
    
        class HomeScreenAdapter : BaseAdapter<Devi>
        {
            List<Devi> items;
            Activity context;
            public HomeScreenAdapter(Activity context, List<Devi> items) : base()
            {
                this.context = context;
                this.items = items;
            }
            public override long GetItemId(int position)
            {
                return position;
            }
            public override Devi this[int position]
            {
                get { return items[position]; }
            }
            public override int Count
            {
                get { return items.Count; }
            }
            public override View GetView(int position, View convertView, ViewGroup parent)
            {
                var item = items[position];
                View view = convertView;
                if (view == null) // no view to re-use, create new
                    view = context.LayoutInflater.Inflate(Resource.Layout.tikit, null);

            // view.FindViewById<ImageView>(Resource.Id.imageViewLogement);
            view.FindViewById<TextView>(Resource.Id.textViewdevisechange).Text = item.Drvice.ToString();
                view.FindViewById<TextView>(Resource.Id.textViewDevise).Text = item.Devise.ToString();
                view.FindViewById<TextView>(Resource.Id.textViewMontant).Text = item.RAt.ToString();
                view.FindViewById<TextView>(Resource.Id.textViewdate).Text = item.Datemiseajour.ToString();
            //view.FindViewById<TextView>(Resource.Id.textViewDevisee).Text = item.Devise.ToLower();

                return view;
            }
        }
    }

