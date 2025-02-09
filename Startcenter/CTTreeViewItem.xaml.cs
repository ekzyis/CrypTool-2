﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Startcenter
{
    /// <summary>
    /// Interaction logic for CTTreeViewItem.xaml
    /// </summary>
    public partial class CTTreeViewItem : TreeViewItem
    {
        public static readonly DependencyProperty IconProperty =
            DependencyProperty.Register(
            "Icon",
            typeof(ImageSource),
            typeof(CTTreeViewItem),
            new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsRender, null));

        public ImageSource Icon
        {
            get => (ImageSource)GetValue(IconProperty);
            set => SetValue(IconProperty, value);
        }

        public static readonly DependencyProperty IsDirectoryProperty =
            DependencyProperty.Register(
            "IsDirectory",
            typeof(bool),
            typeof(CTTreeViewItem),
            new FrameworkPropertyMetadata(false, FrameworkPropertyMetadataOptions.AffectsRender, null));

        public bool IsDirectory
        {
            get => (bool)GetValue(IsDirectoryProperty);
            set => SetValue(IsDirectoryProperty, value);
        }

        public static readonly DependencyProperty DirectoryProperty =
            DependencyProperty.Register(
            "Directory",
            typeof(DirectoryInfo),
            typeof(CTTreeViewItem),
            new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsRender, null));

        public DirectoryInfo Directory
        {
            get => (DirectoryInfo)GetValue(DirectoryProperty);
            set => SetValue(DirectoryProperty, value);
        }

        public FileInfo File { get; private set; }
        public string Title { get; private set; }
        public int Order { get; private set; }

        /// <summary>
        /// Constructor only for files
        /// </summary>
        public CTTreeViewItem(FileInfo file, string title, Span tooltip, ImageSource image)
        {
            File = file;
            Order = -1;
            Title = title;
            Icon = image;
            IsDirectory = false;
            Tag = new KeyValuePair<string, string>(file.FullName, title);
            TextBlock tooltipBlock = new TextBlock(tooltip) { TextWrapping = TextWrapping.Wrap, MaxWidth = 400 };
            ToolTip = tooltipBlock;
            MetaTooltip = tooltip;
            InitializeComponent();
        }

        /// <summary>
        /// Constructor only for directories
        /// </summary>
        public CTTreeViewItem(string title, int order = -1, Inline tooltip = null, ImageSource image = null)
        {
            Title = title;
            Order = order;
            IsDirectory = true;
            if (tooltip != null)
            {
                ToolTip = new TextBlock(tooltip) { TextWrapping = TextWrapping.Wrap, MaxWidth = 400 };
            }

            if (image != null)
            {
                Icon = image;
            }
            else
            {
                Icon = new BitmapImage(new Uri("pack://application:,,,/CrypWin;component/images/Open32.png"));
            }
            InitializeComponent();
        }

        public Span MetaTooltip { get; set; }
    }
}
