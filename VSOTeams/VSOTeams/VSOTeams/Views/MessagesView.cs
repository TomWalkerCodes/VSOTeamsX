﻿using System;
using System.Collections.Generic;
using System.Text;
using VSOTeams.Models;
using Xamarin.Forms;

namespace VSOTeams.Views
{
    public class MessagesView : BaseView
    {
        public MessagesView(SimpleRoomMessage item)
        {
            BindingContext = item;

            Label header = new Label
            {
                Text = item.Content,
                Font = Font.SystemFontOfSize(26),
                HorizontalOptions = LayoutOptions.Center
            };

            WebView webView = new WebView
            {
                Source = new UrlWebViewSource
                {
                    Url = item.Url
                },
                VerticalOptions = LayoutOptions.FillAndExpand
            };

            this.Padding = new Thickness(10, Device.OnPlatform(20, 0, 0), 10, 5);

            this.Content = new StackLayout
            {
                Children = 
                {
                    header,
                    webView
                }
            };
        }
    }
}
