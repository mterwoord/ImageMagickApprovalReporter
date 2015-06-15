﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ImageMagickApprovalReporter.UI
{
    /// <summary>
    /// Interaction logic for ImageDetails.xaml
    /// </summary>
    internal partial class ImageDetails : UserControl
    {
        public ImageDetails()
        {
            InitializeComponent();
        }

        public ImageData Data
        {
            get { return (ImageData)DataContext; }
            set { DataContext = value; }
        }
    }
}