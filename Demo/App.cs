﻿using InterfaceBuilder;
using Xamarin.Forms;
using System;
using System.Collections.Generic;

namespace Demo
{
    public class App : Application
    {
        public App()
        {
            var ui = new UI();

            var modules = new List<Module> {
                new FundamentalsModule(ui)
            };

            var masterDetail = new MasterDetailPage();
            masterDetail.Master = new Menu(ui, masterDetail, modules).Page;
            MainPage = masterDetail;
        }
    }
}
